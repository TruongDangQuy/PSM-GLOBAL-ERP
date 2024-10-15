'=========================================================================================================================================================
'   TABLE : (PFK7208)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7208

Structure T7208_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	GroupComponentBOM	 AS String	'			char(6)		*
Public 	GroupComponentSeq	 AS Double	'			decimal		*
Public 	Dseq	 AS Double	'			decimal
Public 	ProcessSeq	 AS String	'			nvarchar(10)
Public 	CustomerCode	 AS String	'			char(6)
Public 	selGroupComponent	 AS String	'			char(3)
Public 	cdGroupComponent	 AS String	'			char(3)
Public 	ComponentName	 AS String	'			nvarchar(100)
Public 	MaterialCode	 AS String	'			char(6)
Public 	seUnitMaterial	 AS String	'			char(3)
Public 	cdUnitMaterial	 AS String	'			char(3)
Public 	Specification	 AS String	'			nvarchar(200)
Public 	Width	 AS String	'			nvarchar(100)
Public 	WidthID	 AS String	'			nvarchar(20)
Public 	Height	 AS String	'			nvarchar(100)
Public 	SizeName	 AS String	'			nvarchar(100)
Public 	cdColorCode	 AS String	'			char(3)
Public 	ColorCode	 AS String	'			char(6)
Public 	ColorName	 AS String	'			nvarchar(200)
Public 	seShoesStatus	 AS String	'			char(3)
Public 	cdShoesStatus	 AS String	'			char(3)
Public 	seDepartment	 AS String	'			char(3)
Public 	cdDepartment	 AS String	'			char(3)
Public 	ContractID	 AS String	'			char(6)
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
Public 	CheckP1	 AS String	'			char(1)
Public 	CheckP2	 AS String	'			char(1)
Public 	CheckP3	 AS String	'			char(1)
Public 	CheckP4	 AS String	'			char(1)
Public 	CheckP5	 AS String	'			char(1)
Public 	CheckP6	 AS String	'			char(1)
Public 	CheckP7	 AS String	'			char(1)
Public 	CheckP8	 AS String	'			char(1)
Public 	CheckP9	 AS String	'			char(1)
Public 	CheckUse1	 AS String	'			char(1)
Public 	CheckMatching	 AS String	'			char(1)
Public 	Remark	 AS String	'			nvarchar(200)
Public 	MaterialCode_K3011	 AS String	'			char(6)
        Public seSite As String  '			char(3)
Public 	cdSite	 AS String	'			char(3)
'=========================================================================================================================================================
End structure

Public D7208 As T7208_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7208(GROUPCOMPONENTBOM AS String, GROUPCOMPONENTSEQ AS Double) As Boolean
    READ_PFK7208 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7208 "
    SQL = SQL & " WHERE K7208_GroupComponentBOM		 = '" & GroupComponentBOM & "' " 
    SQL = SQL & "   AND K7208_GroupComponentSeq		 =  " & GroupComponentSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7208_CLEAR: GoTo SKIP_READ_PFK7208
                
    Call K7208_MOVE(rd)
    READ_PFK7208 = True

SKIP_READ_PFK7208:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7208",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7208(GROUPCOMPONENTBOM AS String, GROUPCOMPONENTSEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7208 "
    SQL = SQL & " WHERE K7208_GroupComponentBOM		 = '" & GroupComponentBOM & "' " 
    SQL = SQL & "   AND K7208_GroupComponentSeq		 =  " & GroupComponentSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7208",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7208(z7208 As T7208_AREA) As Boolean
    WRITE_PFK7208 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7208)
 
    SQL = " INSERT INTO PFK7208 "
    SQL = SQL & " ( "
    SQL = SQL & " K7208_GroupComponentBOM," 
    SQL = SQL & " K7208_GroupComponentSeq," 
    SQL = SQL & " K7208_Dseq," 
    SQL = SQL & " K7208_ProcessSeq," 
    SQL = SQL & " K7208_CustomerCode," 
    SQL = SQL & " K7208_selGroupComponent," 
    SQL = SQL & " K7208_cdGroupComponent," 
    SQL = SQL & " K7208_ComponentName," 
    SQL = SQL & " K7208_MaterialCode," 
    SQL = SQL & " K7208_seUnitMaterial," 
    SQL = SQL & " K7208_cdUnitMaterial," 
    SQL = SQL & " K7208_Specification," 
    SQL = SQL & " K7208_Width," 
    SQL = SQL & " K7208_WidthID," 
    SQL = SQL & " K7208_Height," 
    SQL = SQL & " K7208_SizeName," 
    SQL = SQL & " K7208_cdColorCode," 
    SQL = SQL & " K7208_ColorCode," 
    SQL = SQL & " K7208_ColorName," 
    SQL = SQL & " K7208_seShoesStatus," 
    SQL = SQL & " K7208_cdShoesStatus," 
    SQL = SQL & " K7208_seDepartment," 
    SQL = SQL & " K7208_cdDepartment," 
    SQL = SQL & " K7208_ContractID," 
    SQL = SQL & " K7208_SupplierCode," 
    SQL = SQL & " K7208_PriceMaterial," 
    SQL = SQL & " K7208_ExchangeCost," 
    SQL = SQL & " K7208_ComplicationCost," 
    SQL = SQL & " K7208_AddedCost," 
    SQL = SQL & " K7208_ShippingRate," 
    SQL = SQL & " K7208_ShippingCost," 
    SQL = SQL & " K7208_PriceRnD," 
    SQL = SQL & " K7208_Price," 
    SQL = SQL & " K7208_seUnitPrice," 
    SQL = SQL & " K7208_cdUnitPrice," 
    SQL = SQL & " K7208_QtyComponent," 
    SQL = SQL & " K7208_Consumption," 
    SQL = SQL & " K7208_Loss," 
    SQL = SQL & " K7208_GrossUsage," 
    SQL = SQL & " K7208_MaterialAMT," 
    SQL = SQL & " K7208_MaterialAMTPurchasing," 
    SQL = SQL & " K7208_MaterialAMTSales," 
    SQL = SQL & " K7208_seSubProcess," 
    SQL = SQL & " K7208_cdSubProcess," 
    SQL = SQL & " K7208_seSpecialProcess," 
    SQL = SQL & " K7208_cdSpecialProcess," 
    SQL = SQL & " K7208_CheckMark," 
    SQL = SQL & " K7208_CheckUse," 
    SQL = SQL & " K7208_CheckP1," 
    SQL = SQL & " K7208_CheckP2," 
    SQL = SQL & " K7208_CheckP3," 
    SQL = SQL & " K7208_CheckP4," 
    SQL = SQL & " K7208_CheckP5," 
    SQL = SQL & " K7208_CheckP6," 
    SQL = SQL & " K7208_CheckP7," 
    SQL = SQL & " K7208_CheckP8," 
    SQL = SQL & " K7208_CheckP9," 
    SQL = SQL & " K7208_CheckUse1," 
    SQL = SQL & " K7208_CheckMatching," 
    SQL = SQL & " K7208_Remark," 
    SQL = SQL & " K7208_MaterialCode_K3011," 
            SQL = SQL & " K7208_seSite,"
    SQL = SQL & " K7208_cdSite " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7208.GroupComponentBOM) & "', "  
    SQL = SQL & "   " & FormatSQL(z7208.GroupComponentSeq) & ", "  
    SQL = SQL & "   " & FormatSQL(z7208.Dseq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7208.ProcessSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.CustomerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.selGroupComponent) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.cdGroupComponent) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.ComponentName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.MaterialCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.seUnitMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.cdUnitMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.Specification) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.Width) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.WidthID) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.Height) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.SizeName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.cdColorCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.ColorCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.ColorName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.seShoesStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.cdShoesStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.seDepartment) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.cdDepartment) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.ContractID) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.SupplierCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z7208.PriceMaterial) & ", "  
    SQL = SQL & "   " & FormatSQL(z7208.ExchangeCost) & ", "  
    SQL = SQL & "   " & FormatSQL(z7208.ComplicationCost) & ", "  
    SQL = SQL & "   " & FormatSQL(z7208.AddedCost) & ", "  
    SQL = SQL & "   " & FormatSQL(z7208.ShippingRate) & ", "  
    SQL = SQL & "   " & FormatSQL(z7208.ShippingCost) & ", "  
    SQL = SQL & "   " & FormatSQL(z7208.PriceRnD) & ", "  
    SQL = SQL & "   " & FormatSQL(z7208.Price) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7208.seUnitPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.cdUnitPrice) & "', "  
    SQL = SQL & "   " & FormatSQL(z7208.QtyComponent) & ", "  
    SQL = SQL & "   " & FormatSQL(z7208.Consumption) & ", "  
    SQL = SQL & "   " & FormatSQL(z7208.Loss) & ", "  
    SQL = SQL & "   " & FormatSQL(z7208.GrossUsage) & ", "  
    SQL = SQL & "   " & FormatSQL(z7208.MaterialAMT) & ", "  
    SQL = SQL & "   " & FormatSQL(z7208.MaterialAMTPurchasing) & ", "  
    SQL = SQL & "   " & FormatSQL(z7208.MaterialAMTSales) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7208.seSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.cdSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.seSpecialProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.cdSpecialProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.CheckMark) & "', "  
        SQL = SQL & "  N'1', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.CheckP1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.CheckP2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.CheckP3) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.CheckP4) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.CheckP5) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.CheckP6) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.CheckP7) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.CheckP8) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.CheckP9) & "', "  
        SQL = SQL & "  N'1', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.CheckMatching) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.Remark) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7208.MaterialCode_K3011) & "', "  
            SQL = SQL & "  N'" & FormatSQL(z7208.seSite) & "', "
    SQL = SQL & "  N'" & FormatSQL(z7208.cdSite) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7208 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7208",vbCritical)
Finally
        Call GetFullInformation("PFK7208", "I", SQL)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7208(z7208 As T7208_AREA) As Boolean
    REWRITE_PFK7208 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7208)
   
    SQL = " UPDATE PFK7208 SET "
    SQL = SQL & "    K7208_Dseq      =  " & FormatSQL(z7208.Dseq) & ", " 
    SQL = SQL & "    K7208_ProcessSeq      = N'" & FormatSQL(z7208.ProcessSeq) & "', " 
    SQL = SQL & "    K7208_CustomerCode      = N'" & FormatSQL(z7208.CustomerCode) & "', " 
    SQL = SQL & "    K7208_selGroupComponent      = N'" & FormatSQL(z7208.selGroupComponent) & "', " 
    SQL = SQL & "    K7208_cdGroupComponent      = N'" & FormatSQL(z7208.cdGroupComponent) & "', " 
    SQL = SQL & "    K7208_ComponentName      = N'" & FormatSQL(z7208.ComponentName) & "', " 
    SQL = SQL & "    K7208_MaterialCode      = N'" & FormatSQL(z7208.MaterialCode) & "', " 
    SQL = SQL & "    K7208_seUnitMaterial      = N'" & FormatSQL(z7208.seUnitMaterial) & "', " 
    SQL = SQL & "    K7208_cdUnitMaterial      = N'" & FormatSQL(z7208.cdUnitMaterial) & "', " 
    SQL = SQL & "    K7208_Specification      = N'" & FormatSQL(z7208.Specification) & "', " 
    SQL = SQL & "    K7208_Width      = N'" & FormatSQL(z7208.Width) & "', " 
    SQL = SQL & "    K7208_WidthID      = N'" & FormatSQL(z7208.WidthID) & "', " 
    SQL = SQL & "    K7208_Height      = N'" & FormatSQL(z7208.Height) & "', " 
    SQL = SQL & "    K7208_SizeName      = N'" & FormatSQL(z7208.SizeName) & "', " 
    SQL = SQL & "    K7208_cdColorCode      = N'" & FormatSQL(z7208.cdColorCode) & "', " 
    SQL = SQL & "    K7208_ColorCode      = N'" & FormatSQL(z7208.ColorCode) & "', " 
    SQL = SQL & "    K7208_ColorName      = N'" & FormatSQL(z7208.ColorName) & "', " 
    SQL = SQL & "    K7208_seShoesStatus      = N'" & FormatSQL(z7208.seShoesStatus) & "', " 
    SQL = SQL & "    K7208_cdShoesStatus      = N'" & FormatSQL(z7208.cdShoesStatus) & "', " 
    SQL = SQL & "    K7208_seDepartment      = N'" & FormatSQL(z7208.seDepartment) & "', " 
    SQL = SQL & "    K7208_cdDepartment      = N'" & FormatSQL(z7208.cdDepartment) & "', " 
    SQL = SQL & "    K7208_ContractID      = N'" & FormatSQL(z7208.ContractID) & "', " 
    SQL = SQL & "    K7208_SupplierCode      = N'" & FormatSQL(z7208.SupplierCode) & "', " 
    SQL = SQL & "    K7208_PriceMaterial      =  " & FormatSQL(z7208.PriceMaterial) & ", " 
    SQL = SQL & "    K7208_ExchangeCost      =  " & FormatSQL(z7208.ExchangeCost) & ", " 
    SQL = SQL & "    K7208_ComplicationCost      =  " & FormatSQL(z7208.ComplicationCost) & ", " 
    SQL = SQL & "    K7208_AddedCost      =  " & FormatSQL(z7208.AddedCost) & ", " 
    SQL = SQL & "    K7208_ShippingRate      =  " & FormatSQL(z7208.ShippingRate) & ", " 
    SQL = SQL & "    K7208_ShippingCost      =  " & FormatSQL(z7208.ShippingCost) & ", " 
    SQL = SQL & "    K7208_PriceRnD      =  " & FormatSQL(z7208.PriceRnD) & ", " 
    SQL = SQL & "    K7208_Price      =  " & FormatSQL(z7208.Price) & ", " 
    SQL = SQL & "    K7208_seUnitPrice      = N'" & FormatSQL(z7208.seUnitPrice) & "', " 
    SQL = SQL & "    K7208_cdUnitPrice      = N'" & FormatSQL(z7208.cdUnitPrice) & "', " 
    SQL = SQL & "    K7208_QtyComponent      =  " & FormatSQL(z7208.QtyComponent) & ", " 
    SQL = SQL & "    K7208_Consumption      =  " & FormatSQL(z7208.Consumption) & ", " 
    SQL = SQL & "    K7208_Loss      =  " & FormatSQL(z7208.Loss) & ", " 
    SQL = SQL & "    K7208_GrossUsage      =  " & FormatSQL(z7208.GrossUsage) & ", " 
    SQL = SQL & "    K7208_MaterialAMT      =  " & FormatSQL(z7208.MaterialAMT) & ", " 
    SQL = SQL & "    K7208_MaterialAMTPurchasing      =  " & FormatSQL(z7208.MaterialAMTPurchasing) & ", " 
    SQL = SQL & "    K7208_MaterialAMTSales      =  " & FormatSQL(z7208.MaterialAMTSales) & ", " 
    SQL = SQL & "    K7208_seSubProcess      = N'" & FormatSQL(z7208.seSubProcess) & "', " 
    SQL = SQL & "    K7208_cdSubProcess      = N'" & FormatSQL(z7208.cdSubProcess) & "', " 
    SQL = SQL & "    K7208_seSpecialProcess      = N'" & FormatSQL(z7208.seSpecialProcess) & "', " 
    SQL = SQL & "    K7208_cdSpecialProcess      = N'" & FormatSQL(z7208.cdSpecialProcess) & "', " 
    SQL = SQL & "    K7208_CheckMark      = N'" & FormatSQL(z7208.CheckMark) & "', " 
    SQL = SQL & "    K7208_CheckUse      = N'" & FormatSQL(z7208.CheckUse) & "', " 
    SQL = SQL & "    K7208_CheckP1      = N'" & FormatSQL(z7208.CheckP1) & "', " 
    SQL = SQL & "    K7208_CheckP2      = N'" & FormatSQL(z7208.CheckP2) & "', " 
    SQL = SQL & "    K7208_CheckP3      = N'" & FormatSQL(z7208.CheckP3) & "', " 
    SQL = SQL & "    K7208_CheckP4      = N'" & FormatSQL(z7208.CheckP4) & "', " 
    SQL = SQL & "    K7208_CheckP5      = N'" & FormatSQL(z7208.CheckP5) & "', " 
    SQL = SQL & "    K7208_CheckP6      = N'" & FormatSQL(z7208.CheckP6) & "', " 
    SQL = SQL & "    K7208_CheckP7      = N'" & FormatSQL(z7208.CheckP7) & "', " 
    SQL = SQL & "    K7208_CheckP8      = N'" & FormatSQL(z7208.CheckP8) & "', " 
    SQL = SQL & "    K7208_CheckP9      = N'" & FormatSQL(z7208.CheckP9) & "', " 
    SQL = SQL & "    K7208_CheckUse1      = N'" & FormatSQL(z7208.CheckUse1) & "', " 
    SQL = SQL & "    K7208_CheckMatching      = N'" & FormatSQL(z7208.CheckMatching) & "', " 
    SQL = SQL & "    K7208_Remark      = N'" & FormatSQL(z7208.Remark) & "', " 
    SQL = SQL & "    K7208_MaterialCode_K3011      = N'" & FormatSQL(z7208.MaterialCode_K3011) & "', " 
            SQL = SQL & "    K7208_seSite      = N'" & FormatSQL(z7208.seSite) & "', "
    SQL = SQL & "    K7208_cdSite      = N'" & FormatSQL(z7208.cdSite) & "'  " 
    SQL = SQL & " WHERE K7208_GroupComponentBOM		 = '" & z7208.GroupComponentBOM & "' " 
    SQL = SQL & "   AND K7208_GroupComponentSeq		 =  " & z7208.GroupComponentSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
	REWRITE_PFK7208 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7208",vbCritical)
Finally
        Call GetFullInformation("PFK7208", "U", SQL)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7208(z7208 As T7208_AREA) As Boolean
    DELETE_PFK7208 = False

   Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7208)
      
        SQL = " DELETE FROM PFK7208  "
    SQL = SQL & " WHERE K7208_GroupComponentBOM		 = '" & z7208.GroupComponentBOM & "' " 
    SQL = SQL & "   AND K7208_GroupComponentSeq		 =  " & z7208.GroupComponentSeq & "  " 

    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7208 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7208",vbCritical)
Finally
        Call GetFullInformation("PFK7208", "U", SQL)
  End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7208_CLEAR()
Try
    
   D7208.GroupComponentBOM = ""
    D7208.GroupComponentSeq = 0 
    D7208.Dseq = 0 
   D7208.ProcessSeq = ""
   D7208.CustomerCode = ""
   D7208.selGroupComponent = ""
   D7208.cdGroupComponent = ""
   D7208.ComponentName = ""
   D7208.MaterialCode = ""
   D7208.seUnitMaterial = ""
   D7208.cdUnitMaterial = ""
   D7208.Specification = ""
   D7208.Width = ""
   D7208.WidthID = ""
   D7208.Height = ""
   D7208.SizeName = ""
   D7208.cdColorCode = ""
   D7208.ColorCode = ""
   D7208.ColorName = ""
   D7208.seShoesStatus = ""
   D7208.cdShoesStatus = ""
   D7208.seDepartment = ""
   D7208.cdDepartment = ""
   D7208.ContractID = ""
   D7208.SupplierCode = ""
    D7208.PriceMaterial = 0 
    D7208.ExchangeCost = 0 
    D7208.ComplicationCost = 0 
    D7208.AddedCost = 0 
    D7208.ShippingRate = 0 
    D7208.ShippingCost = 0 
    D7208.PriceRnD = 0 
    D7208.Price = 0 
   D7208.seUnitPrice = ""
   D7208.cdUnitPrice = ""
    D7208.QtyComponent = 0 
    D7208.Consumption = 0 
    D7208.Loss = 0 
    D7208.GrossUsage = 0 
    D7208.MaterialAMT = 0 
    D7208.MaterialAMTPurchasing = 0 
    D7208.MaterialAMTSales = 0 
   D7208.seSubProcess = ""
   D7208.cdSubProcess = ""
   D7208.seSpecialProcess = ""
   D7208.cdSpecialProcess = ""
   D7208.CheckMark = ""
   D7208.CheckUse = ""
   D7208.CheckP1 = ""
   D7208.CheckP2 = ""
   D7208.CheckP3 = ""
   D7208.CheckP4 = ""
   D7208.CheckP5 = ""
   D7208.CheckP6 = ""
   D7208.CheckP7 = ""
   D7208.CheckP8 = ""
   D7208.CheckP9 = ""
   D7208.CheckUse1 = ""
   D7208.CheckMatching = ""
   D7208.Remark = ""
   D7208.MaterialCode_K3011 = ""
            D7208.seSite = ""
   D7208.cdSite = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7208_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7208 As T7208_AREA)
Try
    
    x7208.GroupComponentBOM = trim$(  x7208.GroupComponentBOM)
    x7208.GroupComponentSeq = trim$(  x7208.GroupComponentSeq)
    x7208.Dseq = trim$(  x7208.Dseq)
    x7208.ProcessSeq = trim$(  x7208.ProcessSeq)
    x7208.CustomerCode = trim$(  x7208.CustomerCode)
    x7208.selGroupComponent = trim$(  x7208.selGroupComponent)
    x7208.cdGroupComponent = trim$(  x7208.cdGroupComponent)
    x7208.ComponentName = trim$(  x7208.ComponentName)
    x7208.MaterialCode = trim$(  x7208.MaterialCode)
    x7208.seUnitMaterial = trim$(  x7208.seUnitMaterial)
    x7208.cdUnitMaterial = trim$(  x7208.cdUnitMaterial)
    x7208.Specification = trim$(  x7208.Specification)
    x7208.Width = trim$(  x7208.Width)
    x7208.WidthID = trim$(  x7208.WidthID)
    x7208.Height = trim$(  x7208.Height)
    x7208.SizeName = trim$(  x7208.SizeName)
    x7208.cdColorCode = trim$(  x7208.cdColorCode)
    x7208.ColorCode = trim$(  x7208.ColorCode)
    x7208.ColorName = trim$(  x7208.ColorName)
    x7208.seShoesStatus = trim$(  x7208.seShoesStatus)
    x7208.cdShoesStatus = trim$(  x7208.cdShoesStatus)
    x7208.seDepartment = trim$(  x7208.seDepartment)
    x7208.cdDepartment = trim$(  x7208.cdDepartment)
    x7208.ContractID = trim$(  x7208.ContractID)
    x7208.SupplierCode = trim$(  x7208.SupplierCode)
    x7208.PriceMaterial = trim$(  x7208.PriceMaterial)
    x7208.ExchangeCost = trim$(  x7208.ExchangeCost)
    x7208.ComplicationCost = trim$(  x7208.ComplicationCost)
    x7208.AddedCost = trim$(  x7208.AddedCost)
    x7208.ShippingRate = trim$(  x7208.ShippingRate)
    x7208.ShippingCost = trim$(  x7208.ShippingCost)
    x7208.PriceRnD = trim$(  x7208.PriceRnD)
    x7208.Price = trim$(  x7208.Price)
    x7208.seUnitPrice = trim$(  x7208.seUnitPrice)
    x7208.cdUnitPrice = trim$(  x7208.cdUnitPrice)
    x7208.QtyComponent = trim$(  x7208.QtyComponent)
    x7208.Consumption = trim$(  x7208.Consumption)
    x7208.Loss = trim$(  x7208.Loss)
    x7208.GrossUsage = trim$(  x7208.GrossUsage)
    x7208.MaterialAMT = trim$(  x7208.MaterialAMT)
    x7208.MaterialAMTPurchasing = trim$(  x7208.MaterialAMTPurchasing)
    x7208.MaterialAMTSales = trim$(  x7208.MaterialAMTSales)
    x7208.seSubProcess = trim$(  x7208.seSubProcess)
    x7208.cdSubProcess = trim$(  x7208.cdSubProcess)
    x7208.seSpecialProcess = trim$(  x7208.seSpecialProcess)
    x7208.cdSpecialProcess = trim$(  x7208.cdSpecialProcess)
    x7208.CheckMark = trim$(  x7208.CheckMark)
    x7208.CheckUse = trim$(  x7208.CheckUse)
    x7208.CheckP1 = trim$(  x7208.CheckP1)
    x7208.CheckP2 = trim$(  x7208.CheckP2)
    x7208.CheckP3 = trim$(  x7208.CheckP3)
    x7208.CheckP4 = trim$(  x7208.CheckP4)
    x7208.CheckP5 = trim$(  x7208.CheckP5)
    x7208.CheckP6 = trim$(  x7208.CheckP6)
    x7208.CheckP7 = trim$(  x7208.CheckP7)
    x7208.CheckP8 = trim$(  x7208.CheckP8)
    x7208.CheckP9 = trim$(  x7208.CheckP9)
    x7208.CheckUse1 = trim$(  x7208.CheckUse1)
    x7208.CheckMatching = trim$(  x7208.CheckMatching)
    x7208.Remark = trim$(  x7208.Remark)
    x7208.MaterialCode_K3011 = trim$(  x7208.MaterialCode_K3011)
            x7208.seSite = Trim$(x7208.seSite)
    x7208.cdSite = trim$(  x7208.cdSite)
     
    If trim$( x7208.GroupComponentBOM ) = "" Then x7208.GroupComponentBOM = Space(1) 
    If trim$( x7208.GroupComponentSeq ) = "" Then x7208.GroupComponentSeq = 0 
    If trim$( x7208.Dseq ) = "" Then x7208.Dseq = 0 
    If trim$( x7208.ProcessSeq ) = "" Then x7208.ProcessSeq = Space(1) 
    If trim$( x7208.CustomerCode ) = "" Then x7208.CustomerCode = Space(1) 
    If trim$( x7208.selGroupComponent ) = "" Then x7208.selGroupComponent = Space(1) 
    If trim$( x7208.cdGroupComponent ) = "" Then x7208.cdGroupComponent = Space(1) 
    If trim$( x7208.ComponentName ) = "" Then x7208.ComponentName = Space(1) 
    If trim$( x7208.MaterialCode ) = "" Then x7208.MaterialCode = Space(1) 
    If trim$( x7208.seUnitMaterial ) = "" Then x7208.seUnitMaterial = Space(1) 
    If trim$( x7208.cdUnitMaterial ) = "" Then x7208.cdUnitMaterial = Space(1) 
    If trim$( x7208.Specification ) = "" Then x7208.Specification = Space(1) 
    If trim$( x7208.Width ) = "" Then x7208.Width = Space(1) 
    If trim$( x7208.WidthID ) = "" Then x7208.WidthID = Space(1) 
    If trim$( x7208.Height ) = "" Then x7208.Height = Space(1) 
    If trim$( x7208.SizeName ) = "" Then x7208.SizeName = Space(1) 
    If trim$( x7208.cdColorCode ) = "" Then x7208.cdColorCode = Space(1) 
    If trim$( x7208.ColorCode ) = "" Then x7208.ColorCode = Space(1) 
    If trim$( x7208.ColorName ) = "" Then x7208.ColorName = Space(1) 
    If trim$( x7208.seShoesStatus ) = "" Then x7208.seShoesStatus = Space(1) 
    If trim$( x7208.cdShoesStatus ) = "" Then x7208.cdShoesStatus = Space(1) 
    If trim$( x7208.seDepartment ) = "" Then x7208.seDepartment = Space(1) 
    If trim$( x7208.cdDepartment ) = "" Then x7208.cdDepartment = Space(1) 
    If trim$( x7208.ContractID ) = "" Then x7208.ContractID = Space(1) 
    If trim$( x7208.SupplierCode ) = "" Then x7208.SupplierCode = Space(1) 
    If trim$( x7208.PriceMaterial ) = "" Then x7208.PriceMaterial = 0 
    If trim$( x7208.ExchangeCost ) = "" Then x7208.ExchangeCost = 0 
    If trim$( x7208.ComplicationCost ) = "" Then x7208.ComplicationCost = 0 
    If trim$( x7208.AddedCost ) = "" Then x7208.AddedCost = 0 
    If trim$( x7208.ShippingRate ) = "" Then x7208.ShippingRate = 0 
    If trim$( x7208.ShippingCost ) = "" Then x7208.ShippingCost = 0 
    If trim$( x7208.PriceRnD ) = "" Then x7208.PriceRnD = 0 
    If trim$( x7208.Price ) = "" Then x7208.Price = 0 
    If trim$( x7208.seUnitPrice ) = "" Then x7208.seUnitPrice = Space(1) 
    If trim$( x7208.cdUnitPrice ) = "" Then x7208.cdUnitPrice = Space(1) 
    If trim$( x7208.QtyComponent ) = "" Then x7208.QtyComponent = 0 
    If trim$( x7208.Consumption ) = "" Then x7208.Consumption = 0 
    If trim$( x7208.Loss ) = "" Then x7208.Loss = 0 
    If trim$( x7208.GrossUsage ) = "" Then x7208.GrossUsage = 0 
    If trim$( x7208.MaterialAMT ) = "" Then x7208.MaterialAMT = 0 
    If trim$( x7208.MaterialAMTPurchasing ) = "" Then x7208.MaterialAMTPurchasing = 0 
    If trim$( x7208.MaterialAMTSales ) = "" Then x7208.MaterialAMTSales = 0 
    If trim$( x7208.seSubProcess ) = "" Then x7208.seSubProcess = Space(1) 
    If trim$( x7208.cdSubProcess ) = "" Then x7208.cdSubProcess = Space(1) 
    If trim$( x7208.seSpecialProcess ) = "" Then x7208.seSpecialProcess = Space(1) 
    If trim$( x7208.cdSpecialProcess ) = "" Then x7208.cdSpecialProcess = Space(1) 
    If trim$( x7208.CheckMark ) = "" Then x7208.CheckMark = Space(1) 
    If trim$( x7208.CheckUse ) = "" Then x7208.CheckUse = Space(1) 
    If trim$( x7208.CheckP1 ) = "" Then x7208.CheckP1 = Space(1) 
    If trim$( x7208.CheckP2 ) = "" Then x7208.CheckP2 = Space(1) 
    If trim$( x7208.CheckP3 ) = "" Then x7208.CheckP3 = Space(1) 
    If trim$( x7208.CheckP4 ) = "" Then x7208.CheckP4 = Space(1) 
    If trim$( x7208.CheckP5 ) = "" Then x7208.CheckP5 = Space(1) 
    If trim$( x7208.CheckP6 ) = "" Then x7208.CheckP6 = Space(1) 
    If trim$( x7208.CheckP7 ) = "" Then x7208.CheckP7 = Space(1) 
    If trim$( x7208.CheckP8 ) = "" Then x7208.CheckP8 = Space(1) 
    If trim$( x7208.CheckP9 ) = "" Then x7208.CheckP9 = Space(1) 
    If trim$( x7208.CheckUse1 ) = "" Then x7208.CheckUse1 = Space(1) 
    If trim$( x7208.CheckMatching ) = "" Then x7208.CheckMatching = Space(1) 
    If trim$( x7208.Remark ) = "" Then x7208.Remark = Space(1) 
    If trim$( x7208.MaterialCode_K3011 ) = "" Then x7208.MaterialCode_K3011 = Space(1) 
            If Trim$(x7208.seSite) = "" Then x7208.seSite = Space(1)
    If trim$( x7208.cdSite ) = "" Then x7208.cdSite = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7208_MOVE(rs7208 As SqlClient.SqlDataReader)
Try

    call D7208_CLEAR()   

    If IsdbNull(rs7208!K7208_GroupComponentBOM) = False Then D7208.GroupComponentBOM = Trim$(rs7208!K7208_GroupComponentBOM)
    If IsdbNull(rs7208!K7208_GroupComponentSeq) = False Then D7208.GroupComponentSeq = Trim$(rs7208!K7208_GroupComponentSeq)
    If IsdbNull(rs7208!K7208_Dseq) = False Then D7208.Dseq = Trim$(rs7208!K7208_Dseq)
    If IsdbNull(rs7208!K7208_ProcessSeq) = False Then D7208.ProcessSeq = Trim$(rs7208!K7208_ProcessSeq)
    If IsdbNull(rs7208!K7208_CustomerCode) = False Then D7208.CustomerCode = Trim$(rs7208!K7208_CustomerCode)
    If IsdbNull(rs7208!K7208_selGroupComponent) = False Then D7208.selGroupComponent = Trim$(rs7208!K7208_selGroupComponent)
    If IsdbNull(rs7208!K7208_cdGroupComponent) = False Then D7208.cdGroupComponent = Trim$(rs7208!K7208_cdGroupComponent)
    If IsdbNull(rs7208!K7208_ComponentName) = False Then D7208.ComponentName = Trim$(rs7208!K7208_ComponentName)
    If IsdbNull(rs7208!K7208_MaterialCode) = False Then D7208.MaterialCode = Trim$(rs7208!K7208_MaterialCode)
    If IsdbNull(rs7208!K7208_seUnitMaterial) = False Then D7208.seUnitMaterial = Trim$(rs7208!K7208_seUnitMaterial)
    If IsdbNull(rs7208!K7208_cdUnitMaterial) = False Then D7208.cdUnitMaterial = Trim$(rs7208!K7208_cdUnitMaterial)
    If IsdbNull(rs7208!K7208_Specification) = False Then D7208.Specification = Trim$(rs7208!K7208_Specification)
    If IsdbNull(rs7208!K7208_Width) = False Then D7208.Width = Trim$(rs7208!K7208_Width)
    If IsdbNull(rs7208!K7208_WidthID) = False Then D7208.WidthID = Trim$(rs7208!K7208_WidthID)
    If IsdbNull(rs7208!K7208_Height) = False Then D7208.Height = Trim$(rs7208!K7208_Height)
    If IsdbNull(rs7208!K7208_SizeName) = False Then D7208.SizeName = Trim$(rs7208!K7208_SizeName)
    If IsdbNull(rs7208!K7208_cdColorCode) = False Then D7208.cdColorCode = Trim$(rs7208!K7208_cdColorCode)
    If IsdbNull(rs7208!K7208_ColorCode) = False Then D7208.ColorCode = Trim$(rs7208!K7208_ColorCode)
    If IsdbNull(rs7208!K7208_ColorName) = False Then D7208.ColorName = Trim$(rs7208!K7208_ColorName)
    If IsdbNull(rs7208!K7208_seShoesStatus) = False Then D7208.seShoesStatus = Trim$(rs7208!K7208_seShoesStatus)
    If IsdbNull(rs7208!K7208_cdShoesStatus) = False Then D7208.cdShoesStatus = Trim$(rs7208!K7208_cdShoesStatus)
    If IsdbNull(rs7208!K7208_seDepartment) = False Then D7208.seDepartment = Trim$(rs7208!K7208_seDepartment)
    If IsdbNull(rs7208!K7208_cdDepartment) = False Then D7208.cdDepartment = Trim$(rs7208!K7208_cdDepartment)
    If IsdbNull(rs7208!K7208_ContractID) = False Then D7208.ContractID = Trim$(rs7208!K7208_ContractID)
    If IsdbNull(rs7208!K7208_SupplierCode) = False Then D7208.SupplierCode = Trim$(rs7208!K7208_SupplierCode)
    If IsdbNull(rs7208!K7208_PriceMaterial) = False Then D7208.PriceMaterial = Trim$(rs7208!K7208_PriceMaterial)
    If IsdbNull(rs7208!K7208_ExchangeCost) = False Then D7208.ExchangeCost = Trim$(rs7208!K7208_ExchangeCost)
    If IsdbNull(rs7208!K7208_ComplicationCost) = False Then D7208.ComplicationCost = Trim$(rs7208!K7208_ComplicationCost)
    If IsdbNull(rs7208!K7208_AddedCost) = False Then D7208.AddedCost = Trim$(rs7208!K7208_AddedCost)
    If IsdbNull(rs7208!K7208_ShippingRate) = False Then D7208.ShippingRate = Trim$(rs7208!K7208_ShippingRate)
    If IsdbNull(rs7208!K7208_ShippingCost) = False Then D7208.ShippingCost = Trim$(rs7208!K7208_ShippingCost)
    If IsdbNull(rs7208!K7208_PriceRnD) = False Then D7208.PriceRnD = Trim$(rs7208!K7208_PriceRnD)
    If IsdbNull(rs7208!K7208_Price) = False Then D7208.Price = Trim$(rs7208!K7208_Price)
    If IsdbNull(rs7208!K7208_seUnitPrice) = False Then D7208.seUnitPrice = Trim$(rs7208!K7208_seUnitPrice)
    If IsdbNull(rs7208!K7208_cdUnitPrice) = False Then D7208.cdUnitPrice = Trim$(rs7208!K7208_cdUnitPrice)
    If IsdbNull(rs7208!K7208_QtyComponent) = False Then D7208.QtyComponent = Trim$(rs7208!K7208_QtyComponent)
    If IsdbNull(rs7208!K7208_Consumption) = False Then D7208.Consumption = Trim$(rs7208!K7208_Consumption)
    If IsdbNull(rs7208!K7208_Loss) = False Then D7208.Loss = Trim$(rs7208!K7208_Loss)
    If IsdbNull(rs7208!K7208_GrossUsage) = False Then D7208.GrossUsage = Trim$(rs7208!K7208_GrossUsage)
    If IsdbNull(rs7208!K7208_MaterialAMT) = False Then D7208.MaterialAMT = Trim$(rs7208!K7208_MaterialAMT)
    If IsdbNull(rs7208!K7208_MaterialAMTPurchasing) = False Then D7208.MaterialAMTPurchasing = Trim$(rs7208!K7208_MaterialAMTPurchasing)
    If IsdbNull(rs7208!K7208_MaterialAMTSales) = False Then D7208.MaterialAMTSales = Trim$(rs7208!K7208_MaterialAMTSales)
    If IsdbNull(rs7208!K7208_seSubProcess) = False Then D7208.seSubProcess = Trim$(rs7208!K7208_seSubProcess)
    If IsdbNull(rs7208!K7208_cdSubProcess) = False Then D7208.cdSubProcess = Trim$(rs7208!K7208_cdSubProcess)
    If IsdbNull(rs7208!K7208_seSpecialProcess) = False Then D7208.seSpecialProcess = Trim$(rs7208!K7208_seSpecialProcess)
    If IsdbNull(rs7208!K7208_cdSpecialProcess) = False Then D7208.cdSpecialProcess = Trim$(rs7208!K7208_cdSpecialProcess)
    If IsdbNull(rs7208!K7208_CheckMark) = False Then D7208.CheckMark = Trim$(rs7208!K7208_CheckMark)
    If IsdbNull(rs7208!K7208_CheckUse) = False Then D7208.CheckUse = Trim$(rs7208!K7208_CheckUse)
    If IsdbNull(rs7208!K7208_CheckP1) = False Then D7208.CheckP1 = Trim$(rs7208!K7208_CheckP1)
    If IsdbNull(rs7208!K7208_CheckP2) = False Then D7208.CheckP2 = Trim$(rs7208!K7208_CheckP2)
    If IsdbNull(rs7208!K7208_CheckP3) = False Then D7208.CheckP3 = Trim$(rs7208!K7208_CheckP3)
    If IsdbNull(rs7208!K7208_CheckP4) = False Then D7208.CheckP4 = Trim$(rs7208!K7208_CheckP4)
    If IsdbNull(rs7208!K7208_CheckP5) = False Then D7208.CheckP5 = Trim$(rs7208!K7208_CheckP5)
    If IsdbNull(rs7208!K7208_CheckP6) = False Then D7208.CheckP6 = Trim$(rs7208!K7208_CheckP6)
    If IsdbNull(rs7208!K7208_CheckP7) = False Then D7208.CheckP7 = Trim$(rs7208!K7208_CheckP7)
    If IsdbNull(rs7208!K7208_CheckP8) = False Then D7208.CheckP8 = Trim$(rs7208!K7208_CheckP8)
    If IsdbNull(rs7208!K7208_CheckP9) = False Then D7208.CheckP9 = Trim$(rs7208!K7208_CheckP9)
    If IsdbNull(rs7208!K7208_CheckUse1) = False Then D7208.CheckUse1 = Trim$(rs7208!K7208_CheckUse1)
    If IsdbNull(rs7208!K7208_CheckMatching) = False Then D7208.CheckMatching = Trim$(rs7208!K7208_CheckMatching)
    If IsdbNull(rs7208!K7208_Remark) = False Then D7208.Remark = Trim$(rs7208!K7208_Remark)
    If IsdbNull(rs7208!K7208_MaterialCode_K3011) = False Then D7208.MaterialCode_K3011 = Trim$(rs7208!K7208_MaterialCode_K3011)
            If IsDBNull(rs7208!K7208_seSite) = False Then D7208.seSite = Trim$(rs7208!K7208_seSite)
    If IsdbNull(rs7208!K7208_cdSite) = False Then D7208.cdSite = Trim$(rs7208!K7208_cdSite)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7208_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7208_MOVE(rs7208 As DataRow)
Try

    call D7208_CLEAR()   

    If IsdbNull(rs7208!K7208_GroupComponentBOM) = False Then D7208.GroupComponentBOM = Trim$(rs7208!K7208_GroupComponentBOM)
    If IsdbNull(rs7208!K7208_GroupComponentSeq) = False Then D7208.GroupComponentSeq = Trim$(rs7208!K7208_GroupComponentSeq)
    If IsdbNull(rs7208!K7208_Dseq) = False Then D7208.Dseq = Trim$(rs7208!K7208_Dseq)
    If IsdbNull(rs7208!K7208_ProcessSeq) = False Then D7208.ProcessSeq = Trim$(rs7208!K7208_ProcessSeq)
    If IsdbNull(rs7208!K7208_CustomerCode) = False Then D7208.CustomerCode = Trim$(rs7208!K7208_CustomerCode)
    If IsdbNull(rs7208!K7208_selGroupComponent) = False Then D7208.selGroupComponent = Trim$(rs7208!K7208_selGroupComponent)
    If IsdbNull(rs7208!K7208_cdGroupComponent) = False Then D7208.cdGroupComponent = Trim$(rs7208!K7208_cdGroupComponent)
    If IsdbNull(rs7208!K7208_ComponentName) = False Then D7208.ComponentName = Trim$(rs7208!K7208_ComponentName)
    If IsdbNull(rs7208!K7208_MaterialCode) = False Then D7208.MaterialCode = Trim$(rs7208!K7208_MaterialCode)
    If IsdbNull(rs7208!K7208_seUnitMaterial) = False Then D7208.seUnitMaterial = Trim$(rs7208!K7208_seUnitMaterial)
    If IsdbNull(rs7208!K7208_cdUnitMaterial) = False Then D7208.cdUnitMaterial = Trim$(rs7208!K7208_cdUnitMaterial)
    If IsdbNull(rs7208!K7208_Specification) = False Then D7208.Specification = Trim$(rs7208!K7208_Specification)
    If IsdbNull(rs7208!K7208_Width) = False Then D7208.Width = Trim$(rs7208!K7208_Width)
    If IsdbNull(rs7208!K7208_WidthID) = False Then D7208.WidthID = Trim$(rs7208!K7208_WidthID)
    If IsdbNull(rs7208!K7208_Height) = False Then D7208.Height = Trim$(rs7208!K7208_Height)
    If IsdbNull(rs7208!K7208_SizeName) = False Then D7208.SizeName = Trim$(rs7208!K7208_SizeName)
    If IsdbNull(rs7208!K7208_cdColorCode) = False Then D7208.cdColorCode = Trim$(rs7208!K7208_cdColorCode)
    If IsdbNull(rs7208!K7208_ColorCode) = False Then D7208.ColorCode = Trim$(rs7208!K7208_ColorCode)
    If IsdbNull(rs7208!K7208_ColorName) = False Then D7208.ColorName = Trim$(rs7208!K7208_ColorName)
    If IsdbNull(rs7208!K7208_seShoesStatus) = False Then D7208.seShoesStatus = Trim$(rs7208!K7208_seShoesStatus)
    If IsdbNull(rs7208!K7208_cdShoesStatus) = False Then D7208.cdShoesStatus = Trim$(rs7208!K7208_cdShoesStatus)
    If IsdbNull(rs7208!K7208_seDepartment) = False Then D7208.seDepartment = Trim$(rs7208!K7208_seDepartment)
    If IsdbNull(rs7208!K7208_cdDepartment) = False Then D7208.cdDepartment = Trim$(rs7208!K7208_cdDepartment)
    If IsdbNull(rs7208!K7208_ContractID) = False Then D7208.ContractID = Trim$(rs7208!K7208_ContractID)
    If IsdbNull(rs7208!K7208_SupplierCode) = False Then D7208.SupplierCode = Trim$(rs7208!K7208_SupplierCode)
    If IsdbNull(rs7208!K7208_PriceMaterial) = False Then D7208.PriceMaterial = Trim$(rs7208!K7208_PriceMaterial)
    If IsdbNull(rs7208!K7208_ExchangeCost) = False Then D7208.ExchangeCost = Trim$(rs7208!K7208_ExchangeCost)
    If IsdbNull(rs7208!K7208_ComplicationCost) = False Then D7208.ComplicationCost = Trim$(rs7208!K7208_ComplicationCost)
    If IsdbNull(rs7208!K7208_AddedCost) = False Then D7208.AddedCost = Trim$(rs7208!K7208_AddedCost)
    If IsdbNull(rs7208!K7208_ShippingRate) = False Then D7208.ShippingRate = Trim$(rs7208!K7208_ShippingRate)
    If IsdbNull(rs7208!K7208_ShippingCost) = False Then D7208.ShippingCost = Trim$(rs7208!K7208_ShippingCost)
    If IsdbNull(rs7208!K7208_PriceRnD) = False Then D7208.PriceRnD = Trim$(rs7208!K7208_PriceRnD)
    If IsdbNull(rs7208!K7208_Price) = False Then D7208.Price = Trim$(rs7208!K7208_Price)
    If IsdbNull(rs7208!K7208_seUnitPrice) = False Then D7208.seUnitPrice = Trim$(rs7208!K7208_seUnitPrice)
    If IsdbNull(rs7208!K7208_cdUnitPrice) = False Then D7208.cdUnitPrice = Trim$(rs7208!K7208_cdUnitPrice)
    If IsdbNull(rs7208!K7208_QtyComponent) = False Then D7208.QtyComponent = Trim$(rs7208!K7208_QtyComponent)
    If IsdbNull(rs7208!K7208_Consumption) = False Then D7208.Consumption = Trim$(rs7208!K7208_Consumption)
    If IsdbNull(rs7208!K7208_Loss) = False Then D7208.Loss = Trim$(rs7208!K7208_Loss)
    If IsdbNull(rs7208!K7208_GrossUsage) = False Then D7208.GrossUsage = Trim$(rs7208!K7208_GrossUsage)
    If IsdbNull(rs7208!K7208_MaterialAMT) = False Then D7208.MaterialAMT = Trim$(rs7208!K7208_MaterialAMT)
    If IsdbNull(rs7208!K7208_MaterialAMTPurchasing) = False Then D7208.MaterialAMTPurchasing = Trim$(rs7208!K7208_MaterialAMTPurchasing)
    If IsdbNull(rs7208!K7208_MaterialAMTSales) = False Then D7208.MaterialAMTSales = Trim$(rs7208!K7208_MaterialAMTSales)
    If IsdbNull(rs7208!K7208_seSubProcess) = False Then D7208.seSubProcess = Trim$(rs7208!K7208_seSubProcess)
    If IsdbNull(rs7208!K7208_cdSubProcess) = False Then D7208.cdSubProcess = Trim$(rs7208!K7208_cdSubProcess)
    If IsdbNull(rs7208!K7208_seSpecialProcess) = False Then D7208.seSpecialProcess = Trim$(rs7208!K7208_seSpecialProcess)
    If IsdbNull(rs7208!K7208_cdSpecialProcess) = False Then D7208.cdSpecialProcess = Trim$(rs7208!K7208_cdSpecialProcess)
    If IsdbNull(rs7208!K7208_CheckMark) = False Then D7208.CheckMark = Trim$(rs7208!K7208_CheckMark)
    If IsdbNull(rs7208!K7208_CheckUse) = False Then D7208.CheckUse = Trim$(rs7208!K7208_CheckUse)
    If IsdbNull(rs7208!K7208_CheckP1) = False Then D7208.CheckP1 = Trim$(rs7208!K7208_CheckP1)
    If IsdbNull(rs7208!K7208_CheckP2) = False Then D7208.CheckP2 = Trim$(rs7208!K7208_CheckP2)
    If IsdbNull(rs7208!K7208_CheckP3) = False Then D7208.CheckP3 = Trim$(rs7208!K7208_CheckP3)
    If IsdbNull(rs7208!K7208_CheckP4) = False Then D7208.CheckP4 = Trim$(rs7208!K7208_CheckP4)
    If IsdbNull(rs7208!K7208_CheckP5) = False Then D7208.CheckP5 = Trim$(rs7208!K7208_CheckP5)
    If IsdbNull(rs7208!K7208_CheckP6) = False Then D7208.CheckP6 = Trim$(rs7208!K7208_CheckP6)
    If IsdbNull(rs7208!K7208_CheckP7) = False Then D7208.CheckP7 = Trim$(rs7208!K7208_CheckP7)
    If IsdbNull(rs7208!K7208_CheckP8) = False Then D7208.CheckP8 = Trim$(rs7208!K7208_CheckP8)
    If IsdbNull(rs7208!K7208_CheckP9) = False Then D7208.CheckP9 = Trim$(rs7208!K7208_CheckP9)
    If IsdbNull(rs7208!K7208_CheckUse1) = False Then D7208.CheckUse1 = Trim$(rs7208!K7208_CheckUse1)
    If IsdbNull(rs7208!K7208_CheckMatching) = False Then D7208.CheckMatching = Trim$(rs7208!K7208_CheckMatching)
    If IsdbNull(rs7208!K7208_Remark) = False Then D7208.Remark = Trim$(rs7208!K7208_Remark)
    If IsdbNull(rs7208!K7208_MaterialCode_K3011) = False Then D7208.MaterialCode_K3011 = Trim$(rs7208!K7208_MaterialCode_K3011)
            If IsDBNull(rs7208!K7208_seSite) = False Then D7208.seSite = Trim$(rs7208!K7208_seSite)
    If IsdbNull(rs7208!K7208_cdSite) = False Then D7208.cdSite = Trim$(rs7208!K7208_cdSite)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7208_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7208_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7208 As T7208_AREA, GROUPCOMPONENTBOM AS String, GROUPCOMPONENTSEQ AS Double) as Boolean

K7208_MOVE = False

Try
    If READ_PFK7208(GROUPCOMPONENTBOM, GROUPCOMPONENTSEQ) = True Then
                z7208 = D7208
		K7208_MOVE = True
		else
	z7208 = nothing
     End If

     If  getColumnIndex(spr,"GroupComponentBOM") > -1 then z7208.GroupComponentBOM = getDataM(spr, getColumnIndex(spr,"GroupComponentBOM"), xRow)
     If  getColumnIndex(spr,"GroupComponentSeq") > -1 then z7208.GroupComponentSeq = getDataM(spr, getColumnIndex(spr,"GroupComponentSeq"), xRow)
     If  getColumnIndex(spr,"Dseq") > -1 then z7208.Dseq = getDataM(spr, getColumnIndex(spr,"Dseq"), xRow)
     If  getColumnIndex(spr,"ProcessSeq") > -1 then z7208.ProcessSeq = getDataM(spr, getColumnIndex(spr,"ProcessSeq"), xRow)
     If  getColumnIndex(spr,"CustomerCode") > -1 then z7208.CustomerCode = getDataM(spr, getColumnIndex(spr,"CustomerCode"), xRow)
     If  getColumnIndex(spr,"selGroupComponent") > -1 then z7208.selGroupComponent = getDataM(spr, getColumnIndex(spr,"selGroupComponent"), xRow)
     If  getColumnIndex(spr,"cdGroupComponent") > -1 then z7208.cdGroupComponent = getDataM(spr, getColumnIndex(spr,"cdGroupComponent"), xRow)
     If  getColumnIndex(spr,"ComponentName") > -1 then z7208.ComponentName = getDataM(spr, getColumnIndex(spr,"ComponentName"), xRow)
     If  getColumnIndex(spr,"MaterialCode") > -1 then z7208.MaterialCode = getDataM(spr, getColumnIndex(spr,"MaterialCode"), xRow)
     If  getColumnIndex(spr,"seUnitMaterial") > -1 then z7208.seUnitMaterial = getDataM(spr, getColumnIndex(spr,"seUnitMaterial"), xRow)
     If  getColumnIndex(spr,"cdUnitMaterial") > -1 then z7208.cdUnitMaterial = getDataM(spr, getColumnIndex(spr,"cdUnitMaterial"), xRow)
     If  getColumnIndex(spr,"Specification") > -1 then z7208.Specification = getDataM(spr, getColumnIndex(spr,"Specification"), xRow)
     If  getColumnIndex(spr,"Width") > -1 then z7208.Width = getDataM(spr, getColumnIndex(spr,"Width"), xRow)
     If  getColumnIndex(spr,"WidthID") > -1 then z7208.WidthID = getDataM(spr, getColumnIndex(spr,"WidthID"), xRow)
     If  getColumnIndex(spr,"Height") > -1 then z7208.Height = getDataM(spr, getColumnIndex(spr,"Height"), xRow)
     If  getColumnIndex(spr,"SizeName") > -1 then z7208.SizeName = getDataM(spr, getColumnIndex(spr,"SizeName"), xRow)
     If  getColumnIndex(spr,"cdColorCode") > -1 then z7208.cdColorCode = getDataM(spr, getColumnIndex(spr,"cdColorCode"), xRow)
     If  getColumnIndex(spr,"ColorCode") > -1 then z7208.ColorCode = getDataM(spr, getColumnIndex(spr,"ColorCode"), xRow)
     If  getColumnIndex(spr,"ColorName") > -1 then z7208.ColorName = getDataM(spr, getColumnIndex(spr,"ColorName"), xRow)
     If  getColumnIndex(spr,"seShoesStatus") > -1 then z7208.seShoesStatus = getDataM(spr, getColumnIndex(spr,"seShoesStatus"), xRow)
     If  getColumnIndex(spr,"cdShoesStatus") > -1 then z7208.cdShoesStatus = getDataM(spr, getColumnIndex(spr,"cdShoesStatus"), xRow)
     If  getColumnIndex(spr,"seDepartment") > -1 then z7208.seDepartment = getDataM(spr, getColumnIndex(spr,"seDepartment"), xRow)
     If  getColumnIndex(spr,"cdDepartment") > -1 then z7208.cdDepartment = getDataM(spr, getColumnIndex(spr,"cdDepartment"), xRow)
     If  getColumnIndex(spr,"ContractID") > -1 then z7208.ContractID = getDataM(spr, getColumnIndex(spr,"ContractID"), xRow)
     If  getColumnIndex(spr,"SupplierCode") > -1 then z7208.SupplierCode = getDataM(spr, getColumnIndex(spr,"SupplierCode"), xRow)
     If  getColumnIndex(spr,"PriceMaterial") > -1 then z7208.PriceMaterial = getDataM(spr, getColumnIndex(spr,"PriceMaterial"), xRow)
     If  getColumnIndex(spr,"ExchangeCost") > -1 then z7208.ExchangeCost = getDataM(spr, getColumnIndex(spr,"ExchangeCost"), xRow)
     If  getColumnIndex(spr,"ComplicationCost") > -1 then z7208.ComplicationCost = getDataM(spr, getColumnIndex(spr,"ComplicationCost"), xRow)
     If  getColumnIndex(spr,"AddedCost") > -1 then z7208.AddedCost = getDataM(spr, getColumnIndex(spr,"AddedCost"), xRow)
     If  getColumnIndex(spr,"ShippingRate") > -1 then z7208.ShippingRate = getDataM(spr, getColumnIndex(spr,"ShippingRate"), xRow)
     If  getColumnIndex(spr,"ShippingCost") > -1 then z7208.ShippingCost = getDataM(spr, getColumnIndex(spr,"ShippingCost"), xRow)
     If  getColumnIndex(spr,"PriceRnD") > -1 then z7208.PriceRnD = getDataM(spr, getColumnIndex(spr,"PriceRnD"), xRow)
     If  getColumnIndex(spr,"Price") > -1 then z7208.Price = getDataM(spr, getColumnIndex(spr,"Price"), xRow)
     If  getColumnIndex(spr,"seUnitPrice") > -1 then z7208.seUnitPrice = getDataM(spr, getColumnIndex(spr,"seUnitPrice"), xRow)
     If  getColumnIndex(spr,"cdUnitPrice") > -1 then z7208.cdUnitPrice = getDataM(spr, getColumnIndex(spr,"cdUnitPrice"), xRow)
     If  getColumnIndex(spr,"QtyComponent") > -1 then z7208.QtyComponent = getDataM(spr, getColumnIndex(spr,"QtyComponent"), xRow)
     If  getColumnIndex(spr,"Consumption") > -1 then z7208.Consumption = getDataM(spr, getColumnIndex(spr,"Consumption"), xRow)
     If  getColumnIndex(spr,"Loss") > -1 then z7208.Loss = getDataM(spr, getColumnIndex(spr,"Loss"), xRow)
     If  getColumnIndex(spr,"GrossUsage") > -1 then z7208.GrossUsage = getDataM(spr, getColumnIndex(spr,"GrossUsage"), xRow)
     If  getColumnIndex(spr,"MaterialAMT") > -1 then z7208.MaterialAMT = getDataM(spr, getColumnIndex(spr,"MaterialAMT"), xRow)
     If  getColumnIndex(spr,"MaterialAMTPurchasing") > -1 then z7208.MaterialAMTPurchasing = getDataM(spr, getColumnIndex(spr,"MaterialAMTPurchasing"), xRow)
     If  getColumnIndex(spr,"MaterialAMTSales") > -1 then z7208.MaterialAMTSales = getDataM(spr, getColumnIndex(spr,"MaterialAMTSales"), xRow)
     If  getColumnIndex(spr,"seSubProcess") > -1 then z7208.seSubProcess = getDataM(spr, getColumnIndex(spr,"seSubProcess"), xRow)
     If  getColumnIndex(spr,"cdSubProcess") > -1 then z7208.cdSubProcess = getDataM(spr, getColumnIndex(spr,"cdSubProcess"), xRow)
     If  getColumnIndex(spr,"seSpecialProcess") > -1 then z7208.seSpecialProcess = getDataM(spr, getColumnIndex(spr,"seSpecialProcess"), xRow)
     If  getColumnIndex(spr,"cdSpecialProcess") > -1 then z7208.cdSpecialProcess = getDataM(spr, getColumnIndex(spr,"cdSpecialProcess"), xRow)
     If  getColumnIndex(spr,"CheckMark") > -1 then z7208.CheckMark = getDataM(spr, getColumnIndex(spr,"CheckMark"), xRow)
     If  getColumnIndex(spr,"CheckUse") > -1 then z7208.CheckUse = getDataM(spr, getColumnIndex(spr,"CheckUse"), xRow)
     If  getColumnIndex(spr,"CheckP1") > -1 then z7208.CheckP1 = getDataM(spr, getColumnIndex(spr,"CheckP1"), xRow)
     If  getColumnIndex(spr,"CheckP2") > -1 then z7208.CheckP2 = getDataM(spr, getColumnIndex(spr,"CheckP2"), xRow)
     If  getColumnIndex(spr,"CheckP3") > -1 then z7208.CheckP3 = getDataM(spr, getColumnIndex(spr,"CheckP3"), xRow)
     If  getColumnIndex(spr,"CheckP4") > -1 then z7208.CheckP4 = getDataM(spr, getColumnIndex(spr,"CheckP4"), xRow)
     If  getColumnIndex(spr,"CheckP5") > -1 then z7208.CheckP5 = getDataM(spr, getColumnIndex(spr,"CheckP5"), xRow)
     If  getColumnIndex(spr,"CheckP6") > -1 then z7208.CheckP6 = getDataM(spr, getColumnIndex(spr,"CheckP6"), xRow)
     If  getColumnIndex(spr,"CheckP7") > -1 then z7208.CheckP7 = getDataM(spr, getColumnIndex(spr,"CheckP7"), xRow)
     If  getColumnIndex(spr,"CheckP8") > -1 then z7208.CheckP8 = getDataM(spr, getColumnIndex(spr,"CheckP8"), xRow)
     If  getColumnIndex(spr,"CheckP9") > -1 then z7208.CheckP9 = getDataM(spr, getColumnIndex(spr,"CheckP9"), xRow)
     If  getColumnIndex(spr,"CheckUse1") > -1 then z7208.CheckUse1 = getDataM(spr, getColumnIndex(spr,"CheckUse1"), xRow)
     If  getColumnIndex(spr,"CheckMatching") > -1 then z7208.CheckMatching = getDataM(spr, getColumnIndex(spr,"CheckMatching"), xRow)
     If  getColumnIndex(spr,"Remark") > -1 then z7208.Remark = getDataM(spr, getColumnIndex(spr,"Remark"), xRow)
     If  getColumnIndex(spr,"MaterialCode_K3011") > -1 then z7208.MaterialCode_K3011 = getDataM(spr, getColumnIndex(spr,"MaterialCode_K3011"), xRow)
            If getColumnIndex(spr, "seSite") > -1 Then z7208.seSite = getDataM(spr, getColumnIndex(spr, "seSite"), xRow)
     If  getColumnIndex(spr,"cdSite") > -1 then z7208.cdSite = getDataM(spr, getColumnIndex(spr,"cdSite"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7208_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7208_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7208 As T7208_AREA,CheckClear as Boolean,GROUPCOMPONENTBOM AS String, GROUPCOMPONENTSEQ AS Double) as Boolean

K7208_MOVE = False

Try
    If READ_PFK7208(GROUPCOMPONENTBOM, GROUPCOMPONENTSEQ) = True Then
                z7208 = D7208
		K7208_MOVE = True
		else
	If CheckClear  = True then z7208 = nothing
     End If

     If  getColumnIndex(spr,"GroupComponentBOM") > -1 then z7208.GroupComponentBOM = getDataM(spr, getColumnIndex(spr,"GroupComponentBOM"), xRow)
     If  getColumnIndex(spr,"GroupComponentSeq") > -1 then z7208.GroupComponentSeq = getDataM(spr, getColumnIndex(spr,"GroupComponentSeq"), xRow)
     If  getColumnIndex(spr,"Dseq") > -1 then z7208.Dseq = getDataM(spr, getColumnIndex(spr,"Dseq"), xRow)
     If  getColumnIndex(spr,"ProcessSeq") > -1 then z7208.ProcessSeq = getDataM(spr, getColumnIndex(spr,"ProcessSeq"), xRow)
     If  getColumnIndex(spr,"CustomerCode") > -1 then z7208.CustomerCode = getDataM(spr, getColumnIndex(spr,"CustomerCode"), xRow)
     If  getColumnIndex(spr,"selGroupComponent") > -1 then z7208.selGroupComponent = getDataM(spr, getColumnIndex(spr,"selGroupComponent"), xRow)
     If  getColumnIndex(spr,"cdGroupComponent") > -1 then z7208.cdGroupComponent = getDataM(spr, getColumnIndex(spr,"cdGroupComponent"), xRow)
     If  getColumnIndex(spr,"ComponentName") > -1 then z7208.ComponentName = getDataM(spr, getColumnIndex(spr,"ComponentName"), xRow)
     If  getColumnIndex(spr,"MaterialCode") > -1 then z7208.MaterialCode = getDataM(spr, getColumnIndex(spr,"MaterialCode"), xRow)
     If  getColumnIndex(spr,"seUnitMaterial") > -1 then z7208.seUnitMaterial = getDataM(spr, getColumnIndex(spr,"seUnitMaterial"), xRow)
     If  getColumnIndex(spr,"cdUnitMaterial") > -1 then z7208.cdUnitMaterial = getDataM(spr, getColumnIndex(spr,"cdUnitMaterial"), xRow)
     If  getColumnIndex(spr,"Specification") > -1 then z7208.Specification = getDataM(spr, getColumnIndex(spr,"Specification"), xRow)
     If  getColumnIndex(spr,"Width") > -1 then z7208.Width = getDataM(spr, getColumnIndex(spr,"Width"), xRow)
     If  getColumnIndex(spr,"WidthID") > -1 then z7208.WidthID = getDataM(spr, getColumnIndex(spr,"WidthID"), xRow)
     If  getColumnIndex(spr,"Height") > -1 then z7208.Height = getDataM(spr, getColumnIndex(spr,"Height"), xRow)
     If  getColumnIndex(spr,"SizeName") > -1 then z7208.SizeName = getDataM(spr, getColumnIndex(spr,"SizeName"), xRow)
     If  getColumnIndex(spr,"cdColorCode") > -1 then z7208.cdColorCode = getDataM(spr, getColumnIndex(spr,"cdColorCode"), xRow)
     If  getColumnIndex(spr,"ColorCode") > -1 then z7208.ColorCode = getDataM(spr, getColumnIndex(spr,"ColorCode"), xRow)
     If  getColumnIndex(spr,"ColorName") > -1 then z7208.ColorName = getDataM(spr, getColumnIndex(spr,"ColorName"), xRow)
     If  getColumnIndex(spr,"seShoesStatus") > -1 then z7208.seShoesStatus = getDataM(spr, getColumnIndex(spr,"seShoesStatus"), xRow)
     If  getColumnIndex(spr,"cdShoesStatus") > -1 then z7208.cdShoesStatus = getDataM(spr, getColumnIndex(spr,"cdShoesStatus"), xRow)
     If  getColumnIndex(spr,"seDepartment") > -1 then z7208.seDepartment = getDataM(spr, getColumnIndex(spr,"seDepartment"), xRow)
     If  getColumnIndex(spr,"cdDepartment") > -1 then z7208.cdDepartment = getDataM(spr, getColumnIndex(spr,"cdDepartment"), xRow)
     If  getColumnIndex(spr,"ContractID") > -1 then z7208.ContractID = getDataM(spr, getColumnIndex(spr,"ContractID"), xRow)
     If  getColumnIndex(spr,"SupplierCode") > -1 then z7208.SupplierCode = getDataM(spr, getColumnIndex(spr,"SupplierCode"), xRow)
     If  getColumnIndex(spr,"PriceMaterial") > -1 then z7208.PriceMaterial = getDataM(spr, getColumnIndex(spr,"PriceMaterial"), xRow)
     If  getColumnIndex(spr,"ExchangeCost") > -1 then z7208.ExchangeCost = getDataM(spr, getColumnIndex(spr,"ExchangeCost"), xRow)
     If  getColumnIndex(spr,"ComplicationCost") > -1 then z7208.ComplicationCost = getDataM(spr, getColumnIndex(spr,"ComplicationCost"), xRow)
     If  getColumnIndex(spr,"AddedCost") > -1 then z7208.AddedCost = getDataM(spr, getColumnIndex(spr,"AddedCost"), xRow)
     If  getColumnIndex(spr,"ShippingRate") > -1 then z7208.ShippingRate = getDataM(spr, getColumnIndex(spr,"ShippingRate"), xRow)
     If  getColumnIndex(spr,"ShippingCost") > -1 then z7208.ShippingCost = getDataM(spr, getColumnIndex(spr,"ShippingCost"), xRow)
     If  getColumnIndex(spr,"PriceRnD") > -1 then z7208.PriceRnD = getDataM(spr, getColumnIndex(spr,"PriceRnD"), xRow)
     If  getColumnIndex(spr,"Price") > -1 then z7208.Price = getDataM(spr, getColumnIndex(spr,"Price"), xRow)
     If  getColumnIndex(spr,"seUnitPrice") > -1 then z7208.seUnitPrice = getDataM(spr, getColumnIndex(spr,"seUnitPrice"), xRow)
     If  getColumnIndex(spr,"cdUnitPrice") > -1 then z7208.cdUnitPrice = getDataM(spr, getColumnIndex(spr,"cdUnitPrice"), xRow)
     If  getColumnIndex(spr,"QtyComponent") > -1 then z7208.QtyComponent = getDataM(spr, getColumnIndex(spr,"QtyComponent"), xRow)
     If  getColumnIndex(spr,"Consumption") > -1 then z7208.Consumption = getDataM(spr, getColumnIndex(spr,"Consumption"), xRow)
     If  getColumnIndex(spr,"Loss") > -1 then z7208.Loss = getDataM(spr, getColumnIndex(spr,"Loss"), xRow)
     If  getColumnIndex(spr,"GrossUsage") > -1 then z7208.GrossUsage = getDataM(spr, getColumnIndex(spr,"GrossUsage"), xRow)
     If  getColumnIndex(spr,"MaterialAMT") > -1 then z7208.MaterialAMT = getDataM(spr, getColumnIndex(spr,"MaterialAMT"), xRow)
     If  getColumnIndex(spr,"MaterialAMTPurchasing") > -1 then z7208.MaterialAMTPurchasing = getDataM(spr, getColumnIndex(spr,"MaterialAMTPurchasing"), xRow)
     If  getColumnIndex(spr,"MaterialAMTSales") > -1 then z7208.MaterialAMTSales = getDataM(spr, getColumnIndex(spr,"MaterialAMTSales"), xRow)
     If  getColumnIndex(spr,"seSubProcess") > -1 then z7208.seSubProcess = getDataM(spr, getColumnIndex(spr,"seSubProcess"), xRow)
     If  getColumnIndex(spr,"cdSubProcess") > -1 then z7208.cdSubProcess = getDataM(spr, getColumnIndex(spr,"cdSubProcess"), xRow)
     If  getColumnIndex(spr,"seSpecialProcess") > -1 then z7208.seSpecialProcess = getDataM(spr, getColumnIndex(spr,"seSpecialProcess"), xRow)
     If  getColumnIndex(spr,"cdSpecialProcess") > -1 then z7208.cdSpecialProcess = getDataM(spr, getColumnIndex(spr,"cdSpecialProcess"), xRow)
     If  getColumnIndex(spr,"CheckMark") > -1 then z7208.CheckMark = getDataM(spr, getColumnIndex(spr,"CheckMark"), xRow)
     If  getColumnIndex(spr,"CheckUse") > -1 then z7208.CheckUse = getDataM(spr, getColumnIndex(spr,"CheckUse"), xRow)
     If  getColumnIndex(spr,"CheckP1") > -1 then z7208.CheckP1 = getDataM(spr, getColumnIndex(spr,"CheckP1"), xRow)
     If  getColumnIndex(spr,"CheckP2") > -1 then z7208.CheckP2 = getDataM(spr, getColumnIndex(spr,"CheckP2"), xRow)
     If  getColumnIndex(spr,"CheckP3") > -1 then z7208.CheckP3 = getDataM(spr, getColumnIndex(spr,"CheckP3"), xRow)
     If  getColumnIndex(spr,"CheckP4") > -1 then z7208.CheckP4 = getDataM(spr, getColumnIndex(spr,"CheckP4"), xRow)
     If  getColumnIndex(spr,"CheckP5") > -1 then z7208.CheckP5 = getDataM(spr, getColumnIndex(spr,"CheckP5"), xRow)
     If  getColumnIndex(spr,"CheckP6") > -1 then z7208.CheckP6 = getDataM(spr, getColumnIndex(spr,"CheckP6"), xRow)
     If  getColumnIndex(spr,"CheckP7") > -1 then z7208.CheckP7 = getDataM(spr, getColumnIndex(spr,"CheckP7"), xRow)
     If  getColumnIndex(spr,"CheckP8") > -1 then z7208.CheckP8 = getDataM(spr, getColumnIndex(spr,"CheckP8"), xRow)
     If  getColumnIndex(spr,"CheckP9") > -1 then z7208.CheckP9 = getDataM(spr, getColumnIndex(spr,"CheckP9"), xRow)
     If  getColumnIndex(spr,"CheckUse1") > -1 then z7208.CheckUse1 = getDataM(spr, getColumnIndex(spr,"CheckUse1"), xRow)
     If  getColumnIndex(spr,"CheckMatching") > -1 then z7208.CheckMatching = getDataM(spr, getColumnIndex(spr,"CheckMatching"), xRow)
     If  getColumnIndex(spr,"Remark") > -1 then z7208.Remark = getDataM(spr, getColumnIndex(spr,"Remark"), xRow)
     If  getColumnIndex(spr,"MaterialCode_K3011") > -1 then z7208.MaterialCode_K3011 = getDataM(spr, getColumnIndex(spr,"MaterialCode_K3011"), xRow)
            If getColumnIndex(spr, "seSite") > -1 Then z7208.seSite = getDataM(spr, getColumnIndex(spr, "seSite"), xRow)
     If  getColumnIndex(spr,"cdSite") > -1 then z7208.cdSite = getDataM(spr, getColumnIndex(spr,"cdSite"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7208_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7208_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7208 As T7208_AREA, Job as String, GROUPCOMPONENTBOM AS String, GROUPCOMPONENTSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7208_MOVE = False

Try
    If READ_PFK7208(GROUPCOMPONENTBOM, GROUPCOMPONENTSEQ) = True Then
                z7208 = D7208
		K7208_MOVE = True
		else
	z7208 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7208")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "GROUPCOMPONENTBOM":z7208.GroupComponentBOM = Children(i).Code
   Case "GROUPCOMPONENTSEQ":z7208.GroupComponentSeq = Children(i).Code
   Case "DSEQ":z7208.Dseq = Children(i).Code
   Case "PROCESSSEQ":z7208.ProcessSeq = Children(i).Code
   Case "CUSTOMERCODE":z7208.CustomerCode = Children(i).Code
   Case "SELGROUPCOMPONENT":z7208.selGroupComponent = Children(i).Code
   Case "CDGROUPCOMPONENT":z7208.cdGroupComponent = Children(i).Code
   Case "COMPONENTNAME":z7208.ComponentName = Children(i).Code
   Case "MATERIALCODE":z7208.MaterialCode = Children(i).Code
   Case "SEUNITMATERIAL":z7208.seUnitMaterial = Children(i).Code
   Case "CDUNITMATERIAL":z7208.cdUnitMaterial = Children(i).Code
   Case "SPECIFICATION":z7208.Specification = Children(i).Code
   Case "WIDTH":z7208.Width = Children(i).Code
   Case "WIDTHID":z7208.WidthID = Children(i).Code
   Case "HEIGHT":z7208.Height = Children(i).Code
   Case "SIZENAME":z7208.SizeName = Children(i).Code
   Case "CDCOLORCODE":z7208.cdColorCode = Children(i).Code
   Case "COLORCODE":z7208.ColorCode = Children(i).Code
   Case "COLORNAME":z7208.ColorName = Children(i).Code
   Case "SESHOESSTATUS":z7208.seShoesStatus = Children(i).Code
   Case "CDSHOESSTATUS":z7208.cdShoesStatus = Children(i).Code
   Case "SEDEPARTMENT":z7208.seDepartment = Children(i).Code
   Case "CDDEPARTMENT":z7208.cdDepartment = Children(i).Code
   Case "CONTRACTID":z7208.ContractID = Children(i).Code
   Case "SUPPLIERCODE":z7208.SupplierCode = Children(i).Code
   Case "PRICEMATERIAL":z7208.PriceMaterial = Children(i).Code
   Case "EXCHANGECOST":z7208.ExchangeCost = Children(i).Code
   Case "COMPLICATIONCOST":z7208.ComplicationCost = Children(i).Code
   Case "ADDEDCOST":z7208.AddedCost = Children(i).Code
   Case "SHIPPINGRATE":z7208.ShippingRate = Children(i).Code
   Case "SHIPPINGCOST":z7208.ShippingCost = Children(i).Code
   Case "PRICERND":z7208.PriceRnD = Children(i).Code
   Case "PRICE":z7208.Price = Children(i).Code
   Case "SEUNITPRICE":z7208.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z7208.cdUnitPrice = Children(i).Code
   Case "QTYCOMPONENT":z7208.QtyComponent = Children(i).Code
   Case "CONSUMPTION":z7208.Consumption = Children(i).Code
   Case "LOSS":z7208.Loss = Children(i).Code
   Case "GROSSUSAGE":z7208.GrossUsage = Children(i).Code
   Case "MATERIALAMT":z7208.MaterialAMT = Children(i).Code
   Case "MATERIALAMTPURCHASING":z7208.MaterialAMTPurchasing = Children(i).Code
   Case "MATERIALAMTSALES":z7208.MaterialAMTSales = Children(i).Code
   Case "SESUBPROCESS":z7208.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z7208.cdSubProcess = Children(i).Code
   Case "SESPECIALPROCESS":z7208.seSpecialProcess = Children(i).Code
   Case "CDSPECIALPROCESS":z7208.cdSpecialProcess = Children(i).Code
   Case "CHECKMARK":z7208.CheckMark = Children(i).Code
   Case "CHECKUSE":z7208.CheckUse = Children(i).Code
   Case "CHECKP1":z7208.CheckP1 = Children(i).Code
   Case "CHECKP2":z7208.CheckP2 = Children(i).Code
   Case "CHECKP3":z7208.CheckP3 = Children(i).Code
   Case "CHECKP4":z7208.CheckP4 = Children(i).Code
   Case "CHECKP5":z7208.CheckP5 = Children(i).Code
   Case "CHECKP6":z7208.CheckP6 = Children(i).Code
   Case "CHECKP7":z7208.CheckP7 = Children(i).Code
   Case "CHECKP8":z7208.CheckP8 = Children(i).Code
   Case "CHECKP9":z7208.CheckP9 = Children(i).Code
   Case "CHECKUSE1":z7208.CheckUse1 = Children(i).Code
   Case "CHECKMATCHING":z7208.CheckMatching = Children(i).Code
   Case "REMARK":z7208.Remark = Children(i).Code
   Case "MATERIALCODE_K3011":z7208.MaterialCode_K3011 = Children(i).Code
                                Case "SESITE" : z7208.seSite = Children(i).Code
   Case "CDSITE":z7208.cdSite = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "GROUPCOMPONENTBOM":z7208.GroupComponentBOM = Children(i).Data
   Case "GROUPCOMPONENTSEQ":z7208.GroupComponentSeq = Children(i).Data
   Case "DSEQ":z7208.Dseq = Children(i).Data
   Case "PROCESSSEQ":z7208.ProcessSeq = Children(i).Data
   Case "CUSTOMERCODE":z7208.CustomerCode = Children(i).Data
   Case "SELGROUPCOMPONENT":z7208.selGroupComponent = Children(i).Data
   Case "CDGROUPCOMPONENT":z7208.cdGroupComponent = Children(i).Data
   Case "COMPONENTNAME":z7208.ComponentName = Children(i).Data
   Case "MATERIALCODE":z7208.MaterialCode = Children(i).Data
   Case "SEUNITMATERIAL":z7208.seUnitMaterial = Children(i).Data
   Case "CDUNITMATERIAL":z7208.cdUnitMaterial = Children(i).Data
   Case "SPECIFICATION":z7208.Specification = Children(i).Data
   Case "WIDTH":z7208.Width = Children(i).Data
   Case "WIDTHID":z7208.WidthID = Children(i).Data
   Case "HEIGHT":z7208.Height = Children(i).Data
   Case "SIZENAME":z7208.SizeName = Children(i).Data
   Case "CDCOLORCODE":z7208.cdColorCode = Children(i).Data
   Case "COLORCODE":z7208.ColorCode = Children(i).Data
   Case "COLORNAME":z7208.ColorName = Children(i).Data
   Case "SESHOESSTATUS":z7208.seShoesStatus = Children(i).Data
   Case "CDSHOESSTATUS":z7208.cdShoesStatus = Children(i).Data
   Case "SEDEPARTMENT":z7208.seDepartment = Children(i).Data
   Case "CDDEPARTMENT":z7208.cdDepartment = Children(i).Data
   Case "CONTRACTID":z7208.ContractID = Children(i).Data
   Case "SUPPLIERCODE":z7208.SupplierCode = Children(i).Data
   Case "PRICEMATERIAL":z7208.PriceMaterial = Children(i).Data
   Case "EXCHANGECOST":z7208.ExchangeCost = Children(i).Data
   Case "COMPLICATIONCOST":z7208.ComplicationCost = Children(i).Data
   Case "ADDEDCOST":z7208.AddedCost = Children(i).Data
   Case "SHIPPINGRATE":z7208.ShippingRate = Children(i).Data
   Case "SHIPPINGCOST":z7208.ShippingCost = Children(i).Data
   Case "PRICERND":z7208.PriceRnD = Children(i).Data
   Case "PRICE":z7208.Price = Children(i).Data
   Case "SEUNITPRICE":z7208.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z7208.cdUnitPrice = Children(i).Data
   Case "QTYCOMPONENT":z7208.QtyComponent = Children(i).Data
   Case "CONSUMPTION":z7208.Consumption = Children(i).Data
   Case "LOSS":z7208.Loss = Children(i).Data
   Case "GROSSUSAGE":z7208.GrossUsage = Children(i).Data
   Case "MATERIALAMT":z7208.MaterialAMT = Children(i).Data
   Case "MATERIALAMTPURCHASING":z7208.MaterialAMTPurchasing = Children(i).Data
   Case "MATERIALAMTSALES":z7208.MaterialAMTSales = Children(i).Data
   Case "SESUBPROCESS":z7208.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z7208.cdSubProcess = Children(i).Data
   Case "SESPECIALPROCESS":z7208.seSpecialProcess = Children(i).Data
   Case "CDSPECIALPROCESS":z7208.cdSpecialProcess = Children(i).Data
   Case "CHECKMARK":z7208.CheckMark = Children(i).Data
   Case "CHECKUSE":z7208.CheckUse = Children(i).Data
   Case "CHECKP1":z7208.CheckP1 = Children(i).Data
   Case "CHECKP2":z7208.CheckP2 = Children(i).Data
   Case "CHECKP3":z7208.CheckP3 = Children(i).Data
   Case "CHECKP4":z7208.CheckP4 = Children(i).Data
   Case "CHECKP5":z7208.CheckP5 = Children(i).Data
   Case "CHECKP6":z7208.CheckP6 = Children(i).Data
   Case "CHECKP7":z7208.CheckP7 = Children(i).Data
   Case "CHECKP8":z7208.CheckP8 = Children(i).Data
   Case "CHECKP9":z7208.CheckP9 = Children(i).Data
   Case "CHECKUSE1":z7208.CheckUse1 = Children(i).Data
   Case "CHECKMATCHING":z7208.CheckMatching = Children(i).Data
   Case "REMARK":z7208.Remark = Children(i).Data
   Case "MATERIALCODE_K3011":z7208.MaterialCode_K3011 = Children(i).Data
                                Case "SESITE" : z7208.seSite = Children(i).Data
   Case "CDSITE":z7208.cdSite = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7208_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7208_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7208 As T7208_AREA, Job as String, CheckClear as Boolean, GROUPCOMPONENTBOM AS String, GROUPCOMPONENTSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7208_MOVE = False

Try
    If READ_PFK7208(GROUPCOMPONENTBOM, GROUPCOMPONENTSEQ) = True Then
                z7208 = D7208
		K7208_MOVE = True
		else
	If CheckClear  = True then z7208 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7208")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "GROUPCOMPONENTBOM":z7208.GroupComponentBOM = Children(i).Code
   Case "GROUPCOMPONENTSEQ":z7208.GroupComponentSeq = Children(i).Code
   Case "DSEQ":z7208.Dseq = Children(i).Code
   Case "PROCESSSEQ":z7208.ProcessSeq = Children(i).Code
   Case "CUSTOMERCODE":z7208.CustomerCode = Children(i).Code
   Case "SELGROUPCOMPONENT":z7208.selGroupComponent = Children(i).Code
   Case "CDGROUPCOMPONENT":z7208.cdGroupComponent = Children(i).Code
   Case "COMPONENTNAME":z7208.ComponentName = Children(i).Code
   Case "MATERIALCODE":z7208.MaterialCode = Children(i).Code
   Case "SEUNITMATERIAL":z7208.seUnitMaterial = Children(i).Code
   Case "CDUNITMATERIAL":z7208.cdUnitMaterial = Children(i).Code
   Case "SPECIFICATION":z7208.Specification = Children(i).Code
   Case "WIDTH":z7208.Width = Children(i).Code
   Case "WIDTHID":z7208.WidthID = Children(i).Code
   Case "HEIGHT":z7208.Height = Children(i).Code
   Case "SIZENAME":z7208.SizeName = Children(i).Code
   Case "CDCOLORCODE":z7208.cdColorCode = Children(i).Code
   Case "COLORCODE":z7208.ColorCode = Children(i).Code
   Case "COLORNAME":z7208.ColorName = Children(i).Code
   Case "SESHOESSTATUS":z7208.seShoesStatus = Children(i).Code
   Case "CDSHOESSTATUS":z7208.cdShoesStatus = Children(i).Code
   Case "SEDEPARTMENT":z7208.seDepartment = Children(i).Code
   Case "CDDEPARTMENT":z7208.cdDepartment = Children(i).Code
   Case "CONTRACTID":z7208.ContractID = Children(i).Code
   Case "SUPPLIERCODE":z7208.SupplierCode = Children(i).Code
   Case "PRICEMATERIAL":z7208.PriceMaterial = Children(i).Code
   Case "EXCHANGECOST":z7208.ExchangeCost = Children(i).Code
   Case "COMPLICATIONCOST":z7208.ComplicationCost = Children(i).Code
   Case "ADDEDCOST":z7208.AddedCost = Children(i).Code
   Case "SHIPPINGRATE":z7208.ShippingRate = Children(i).Code
   Case "SHIPPINGCOST":z7208.ShippingCost = Children(i).Code
   Case "PRICERND":z7208.PriceRnD = Children(i).Code
   Case "PRICE":z7208.Price = Children(i).Code
   Case "SEUNITPRICE":z7208.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z7208.cdUnitPrice = Children(i).Code
   Case "QTYCOMPONENT":z7208.QtyComponent = Children(i).Code
   Case "CONSUMPTION":z7208.Consumption = Children(i).Code
   Case "LOSS":z7208.Loss = Children(i).Code
   Case "GROSSUSAGE":z7208.GrossUsage = Children(i).Code
   Case "MATERIALAMT":z7208.MaterialAMT = Children(i).Code
   Case "MATERIALAMTPURCHASING":z7208.MaterialAMTPurchasing = Children(i).Code
   Case "MATERIALAMTSALES":z7208.MaterialAMTSales = Children(i).Code
   Case "SESUBPROCESS":z7208.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z7208.cdSubProcess = Children(i).Code
   Case "SESPECIALPROCESS":z7208.seSpecialProcess = Children(i).Code
   Case "CDSPECIALPROCESS":z7208.cdSpecialProcess = Children(i).Code
   Case "CHECKMARK":z7208.CheckMark = Children(i).Code
   Case "CHECKUSE":z7208.CheckUse = Children(i).Code
   Case "CHECKP1":z7208.CheckP1 = Children(i).Code
   Case "CHECKP2":z7208.CheckP2 = Children(i).Code
   Case "CHECKP3":z7208.CheckP3 = Children(i).Code
   Case "CHECKP4":z7208.CheckP4 = Children(i).Code
   Case "CHECKP5":z7208.CheckP5 = Children(i).Code
   Case "CHECKP6":z7208.CheckP6 = Children(i).Code
   Case "CHECKP7":z7208.CheckP7 = Children(i).Code
   Case "CHECKP8":z7208.CheckP8 = Children(i).Code
   Case "CHECKP9":z7208.CheckP9 = Children(i).Code
   Case "CHECKUSE1":z7208.CheckUse1 = Children(i).Code
   Case "CHECKMATCHING":z7208.CheckMatching = Children(i).Code
   Case "REMARK":z7208.Remark = Children(i).Code
   Case "MATERIALCODE_K3011":z7208.MaterialCode_K3011 = Children(i).Code
                                Case "SESITE" : z7208.seSite = Children(i).Code
   Case "CDSITE":z7208.cdSite = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "GROUPCOMPONENTBOM":z7208.GroupComponentBOM = Children(i).Data
   Case "GROUPCOMPONENTSEQ":z7208.GroupComponentSeq = Children(i).Data
   Case "DSEQ":z7208.Dseq = Children(i).Data
   Case "PROCESSSEQ":z7208.ProcessSeq = Children(i).Data
   Case "CUSTOMERCODE":z7208.CustomerCode = Children(i).Data
   Case "SELGROUPCOMPONENT":z7208.selGroupComponent = Children(i).Data
   Case "CDGROUPCOMPONENT":z7208.cdGroupComponent = Children(i).Data
   Case "COMPONENTNAME":z7208.ComponentName = Children(i).Data
   Case "MATERIALCODE":z7208.MaterialCode = Children(i).Data
   Case "SEUNITMATERIAL":z7208.seUnitMaterial = Children(i).Data
   Case "CDUNITMATERIAL":z7208.cdUnitMaterial = Children(i).Data
   Case "SPECIFICATION":z7208.Specification = Children(i).Data
   Case "WIDTH":z7208.Width = Children(i).Data
   Case "WIDTHID":z7208.WidthID = Children(i).Data
   Case "HEIGHT":z7208.Height = Children(i).Data
   Case "SIZENAME":z7208.SizeName = Children(i).Data
   Case "CDCOLORCODE":z7208.cdColorCode = Children(i).Data
   Case "COLORCODE":z7208.ColorCode = Children(i).Data
   Case "COLORNAME":z7208.ColorName = Children(i).Data
   Case "SESHOESSTATUS":z7208.seShoesStatus = Children(i).Data
   Case "CDSHOESSTATUS":z7208.cdShoesStatus = Children(i).Data
   Case "SEDEPARTMENT":z7208.seDepartment = Children(i).Data
   Case "CDDEPARTMENT":z7208.cdDepartment = Children(i).Data
   Case "CONTRACTID":z7208.ContractID = Children(i).Data
   Case "SUPPLIERCODE":z7208.SupplierCode = Children(i).Data
   Case "PRICEMATERIAL":z7208.PriceMaterial = Children(i).Data
   Case "EXCHANGECOST":z7208.ExchangeCost = Children(i).Data
   Case "COMPLICATIONCOST":z7208.ComplicationCost = Children(i).Data
   Case "ADDEDCOST":z7208.AddedCost = Children(i).Data
   Case "SHIPPINGRATE":z7208.ShippingRate = Children(i).Data
   Case "SHIPPINGCOST":z7208.ShippingCost = Children(i).Data
   Case "PRICERND":z7208.PriceRnD = Children(i).Data
   Case "PRICE":z7208.Price = Children(i).Data
   Case "SEUNITPRICE":z7208.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z7208.cdUnitPrice = Children(i).Data
   Case "QTYCOMPONENT":z7208.QtyComponent = Children(i).Data
   Case "CONSUMPTION":z7208.Consumption = Children(i).Data
   Case "LOSS":z7208.Loss = Children(i).Data
   Case "GROSSUSAGE":z7208.GrossUsage = Children(i).Data
   Case "MATERIALAMT":z7208.MaterialAMT = Children(i).Data
   Case "MATERIALAMTPURCHASING":z7208.MaterialAMTPurchasing = Children(i).Data
   Case "MATERIALAMTSALES":z7208.MaterialAMTSales = Children(i).Data
   Case "SESUBPROCESS":z7208.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z7208.cdSubProcess = Children(i).Data
   Case "SESPECIALPROCESS":z7208.seSpecialProcess = Children(i).Data
   Case "CDSPECIALPROCESS":z7208.cdSpecialProcess = Children(i).Data
   Case "CHECKMARK":z7208.CheckMark = Children(i).Data
   Case "CHECKUSE":z7208.CheckUse = Children(i).Data
   Case "CHECKP1":z7208.CheckP1 = Children(i).Data
   Case "CHECKP2":z7208.CheckP2 = Children(i).Data
   Case "CHECKP3":z7208.CheckP3 = Children(i).Data
   Case "CHECKP4":z7208.CheckP4 = Children(i).Data
   Case "CHECKP5":z7208.CheckP5 = Children(i).Data
   Case "CHECKP6":z7208.CheckP6 = Children(i).Data
   Case "CHECKP7":z7208.CheckP7 = Children(i).Data
   Case "CHECKP8":z7208.CheckP8 = Children(i).Data
   Case "CHECKP9":z7208.CheckP9 = Children(i).Data
   Case "CHECKUSE1":z7208.CheckUse1 = Children(i).Data
   Case "CHECKMATCHING":z7208.CheckMatching = Children(i).Data
   Case "REMARK":z7208.Remark = Children(i).Data
   Case "MATERIALCODE_K3011":z7208.MaterialCode_K3011 = Children(i).Data
                                Case "SESITE" : z7208.seSite = Children(i).Data
   Case "CDSITE":z7208.cdSite = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7208_MOVE",vbCritical)
End Try
End Function 
    

'=========================================================================================================================================================
' DATA MOVE FORM NEW AREA
'=========================================================================================================================================================
Public Sub K7208_MOVE(ByRef a7208 As T7208_AREA, ByRef b7208 As T7208_AREA) 
Try
If trim$( a7208.GroupComponentBOM ) = "" Then b7208.GroupComponentBOM = ""  Else b7208.GroupComponentBOM=a7208.GroupComponentBOM
If trim$( a7208.GroupComponentSeq ) = "" Then b7208.GroupComponentSeq = ""  Else b7208.GroupComponentSeq=a7208.GroupComponentSeq
If trim$( a7208.Dseq ) = "" Then b7208.Dseq = ""  Else b7208.Dseq=a7208.Dseq
If trim$( a7208.ProcessSeq ) = "" Then b7208.ProcessSeq = ""  Else b7208.ProcessSeq=a7208.ProcessSeq
If trim$( a7208.CustomerCode ) = "" Then b7208.CustomerCode = ""  Else b7208.CustomerCode=a7208.CustomerCode
If trim$( a7208.selGroupComponent ) = "" Then b7208.selGroupComponent = ""  Else b7208.selGroupComponent=a7208.selGroupComponent
If trim$( a7208.cdGroupComponent ) = "" Then b7208.cdGroupComponent = ""  Else b7208.cdGroupComponent=a7208.cdGroupComponent
If trim$( a7208.ComponentName ) = "" Then b7208.ComponentName = ""  Else b7208.ComponentName=a7208.ComponentName
If trim$( a7208.MaterialCode ) = "" Then b7208.MaterialCode = ""  Else b7208.MaterialCode=a7208.MaterialCode
If trim$( a7208.seUnitMaterial ) = "" Then b7208.seUnitMaterial = ""  Else b7208.seUnitMaterial=a7208.seUnitMaterial
If trim$( a7208.cdUnitMaterial ) = "" Then b7208.cdUnitMaterial = ""  Else b7208.cdUnitMaterial=a7208.cdUnitMaterial
If trim$( a7208.Specification ) = "" Then b7208.Specification = ""  Else b7208.Specification=a7208.Specification
If trim$( a7208.Width ) = "" Then b7208.Width = ""  Else b7208.Width=a7208.Width
If trim$( a7208.WidthID ) = "" Then b7208.WidthID = ""  Else b7208.WidthID=a7208.WidthID
If trim$( a7208.Height ) = "" Then b7208.Height = ""  Else b7208.Height=a7208.Height
If trim$( a7208.SizeName ) = "" Then b7208.SizeName = ""  Else b7208.SizeName=a7208.SizeName
If trim$( a7208.cdColorCode ) = "" Then b7208.cdColorCode = ""  Else b7208.cdColorCode=a7208.cdColorCode
If trim$( a7208.ColorCode ) = "" Then b7208.ColorCode = ""  Else b7208.ColorCode=a7208.ColorCode
If trim$( a7208.ColorName ) = "" Then b7208.ColorName = ""  Else b7208.ColorName=a7208.ColorName
If trim$( a7208.seShoesStatus ) = "" Then b7208.seShoesStatus = ""  Else b7208.seShoesStatus=a7208.seShoesStatus
If trim$( a7208.cdShoesStatus ) = "" Then b7208.cdShoesStatus = ""  Else b7208.cdShoesStatus=a7208.cdShoesStatus
If trim$( a7208.seDepartment ) = "" Then b7208.seDepartment = ""  Else b7208.seDepartment=a7208.seDepartment
If trim$( a7208.cdDepartment ) = "" Then b7208.cdDepartment = ""  Else b7208.cdDepartment=a7208.cdDepartment
If trim$( a7208.ContractID ) = "" Then b7208.ContractID = ""  Else b7208.ContractID=a7208.ContractID
If trim$( a7208.SupplierCode ) = "" Then b7208.SupplierCode = ""  Else b7208.SupplierCode=a7208.SupplierCode
If trim$( a7208.PriceMaterial ) = "" Then b7208.PriceMaterial = ""  Else b7208.PriceMaterial=a7208.PriceMaterial
If trim$( a7208.ExchangeCost ) = "" Then b7208.ExchangeCost = ""  Else b7208.ExchangeCost=a7208.ExchangeCost
If trim$( a7208.ComplicationCost ) = "" Then b7208.ComplicationCost = ""  Else b7208.ComplicationCost=a7208.ComplicationCost
If trim$( a7208.AddedCost ) = "" Then b7208.AddedCost = ""  Else b7208.AddedCost=a7208.AddedCost
If trim$( a7208.ShippingRate ) = "" Then b7208.ShippingRate = ""  Else b7208.ShippingRate=a7208.ShippingRate
If trim$( a7208.ShippingCost ) = "" Then b7208.ShippingCost = ""  Else b7208.ShippingCost=a7208.ShippingCost
If trim$( a7208.PriceRnD ) = "" Then b7208.PriceRnD = ""  Else b7208.PriceRnD=a7208.PriceRnD
If trim$( a7208.Price ) = "" Then b7208.Price = ""  Else b7208.Price=a7208.Price
If trim$( a7208.seUnitPrice ) = "" Then b7208.seUnitPrice = ""  Else b7208.seUnitPrice=a7208.seUnitPrice
If trim$( a7208.cdUnitPrice ) = "" Then b7208.cdUnitPrice = ""  Else b7208.cdUnitPrice=a7208.cdUnitPrice
If trim$( a7208.QtyComponent ) = "" Then b7208.QtyComponent = ""  Else b7208.QtyComponent=a7208.QtyComponent
If trim$( a7208.Consumption ) = "" Then b7208.Consumption = ""  Else b7208.Consumption=a7208.Consumption
If trim$( a7208.Loss ) = "" Then b7208.Loss = ""  Else b7208.Loss=a7208.Loss
If trim$( a7208.GrossUsage ) = "" Then b7208.GrossUsage = ""  Else b7208.GrossUsage=a7208.GrossUsage
If trim$( a7208.MaterialAMT ) = "" Then b7208.MaterialAMT = ""  Else b7208.MaterialAMT=a7208.MaterialAMT
If trim$( a7208.MaterialAMTPurchasing ) = "" Then b7208.MaterialAMTPurchasing = ""  Else b7208.MaterialAMTPurchasing=a7208.MaterialAMTPurchasing
If trim$( a7208.MaterialAMTSales ) = "" Then b7208.MaterialAMTSales = ""  Else b7208.MaterialAMTSales=a7208.MaterialAMTSales
If trim$( a7208.seSubProcess ) = "" Then b7208.seSubProcess = ""  Else b7208.seSubProcess=a7208.seSubProcess
If trim$( a7208.cdSubProcess ) = "" Then b7208.cdSubProcess = ""  Else b7208.cdSubProcess=a7208.cdSubProcess
If trim$( a7208.seSpecialProcess ) = "" Then b7208.seSpecialProcess = ""  Else b7208.seSpecialProcess=a7208.seSpecialProcess
If trim$( a7208.cdSpecialProcess ) = "" Then b7208.cdSpecialProcess = ""  Else b7208.cdSpecialProcess=a7208.cdSpecialProcess
If trim$( a7208.CheckMark ) = "" Then b7208.CheckMark = ""  Else b7208.CheckMark=a7208.CheckMark
If trim$( a7208.CheckUse ) = "" Then b7208.CheckUse = ""  Else b7208.CheckUse=a7208.CheckUse
If trim$( a7208.CheckP1 ) = "" Then b7208.CheckP1 = ""  Else b7208.CheckP1=a7208.CheckP1
If trim$( a7208.CheckP2 ) = "" Then b7208.CheckP2 = ""  Else b7208.CheckP2=a7208.CheckP2
If trim$( a7208.CheckP3 ) = "" Then b7208.CheckP3 = ""  Else b7208.CheckP3=a7208.CheckP3
If trim$( a7208.CheckP4 ) = "" Then b7208.CheckP4 = ""  Else b7208.CheckP4=a7208.CheckP4
If trim$( a7208.CheckP5 ) = "" Then b7208.CheckP5 = ""  Else b7208.CheckP5=a7208.CheckP5
If trim$( a7208.CheckP6 ) = "" Then b7208.CheckP6 = ""  Else b7208.CheckP6=a7208.CheckP6
If trim$( a7208.CheckP7 ) = "" Then b7208.CheckP7 = ""  Else b7208.CheckP7=a7208.CheckP7
If trim$( a7208.CheckP8 ) = "" Then b7208.CheckP8 = ""  Else b7208.CheckP8=a7208.CheckP8
If trim$( a7208.CheckP9 ) = "" Then b7208.CheckP9 = ""  Else b7208.CheckP9=a7208.CheckP9
If trim$( a7208.CheckUse1 ) = "" Then b7208.CheckUse1 = ""  Else b7208.CheckUse1=a7208.CheckUse1
If trim$( a7208.CheckMatching ) = "" Then b7208.CheckMatching = ""  Else b7208.CheckMatching=a7208.CheckMatching
If trim$( a7208.Remark ) = "" Then b7208.Remark = ""  Else b7208.Remark=a7208.Remark
If trim$( a7208.MaterialCode_K3011 ) = "" Then b7208.MaterialCode_K3011 = ""  Else b7208.MaterialCode_K3011=a7208.MaterialCode_K3011
            If Trim$(a7208.seSite) = "" Then b7208.seSite = "" Else b7208.seSite = a7208.seSite
If trim$( a7208.cdSite ) = "" Then b7208.cdSite = ""  Else b7208.cdSite=a7208.cdSite
Catch ex As Exception
      Call MsgBoxP("K7208_MOVE",vbCritical)
End Try
End Sub 


End Module 
