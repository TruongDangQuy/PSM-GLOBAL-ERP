'=========================================================================================================================================================
'   TABLE : (PFK3209)
'
'      WORKER : PSM GLOBAL ., LTD
'       WORK DATE : 2019 NEW
'       DEVELOPER    : MRNLV
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K3209

Structure T3209_AREA
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
Public 	Width	 AS String	'			nvarchar(20)
Public 	WidthID	 AS String	'			nvarchar(20)
Public 	Height	 AS String	'			nvarchar(20)
Public 	SizeName	 AS String	'			nvarchar(20)
Public 	cdColorCode	 AS String	'			char(3)
Public 	ColorCode	 AS String	'			char(6)
Public 	ColorName	 AS String	'			nvarchar(200)
Public 	seShoesStatus	 AS String	'			char(3)
Public 	cdShoesStatus	 AS String	'			char(3)
Public 	seDepartment	 AS String	'			char(3)
Public 	cdDepartment	 AS String	'			char(3)
Public 	ContractID	 AS String	'			char(6)
Public 	ContracSeq	 AS Double	'			decimal
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
Public 	seSite	 AS String	'			char(3)
Public 	cdSite	 AS String	'			char(3)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	TimeInsert	 AS String	'			char(14)
Public 	TimeUpdate	 AS String	'			char(14)
'=========================================================================================================================================================
End structure

Public D3209 As T3209_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK3209(GROUPCOMPONENTBOM AS String, GROUPCOMPONENTSEQ AS Double) As Boolean
    READ_PFK3209 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3209 "
    SQL = SQL & " WHERE K3209_GroupComponentBOM		 = '" & GroupComponentBOM & "' " 
    SQL = SQL & "   AND K3209_GroupComponentSeq		 =  " & GroupComponentSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D3209_CLEAR: GoTo SKIP_READ_PFK3209
                
    Call K3209_MOVE(rd)
    READ_PFK3209 = True

SKIP_READ_PFK3209:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK3209",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK3209(GROUPCOMPONENTBOM AS String, GROUPCOMPONENTSEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3209 "
    SQL = SQL & " WHERE K3209_GroupComponentBOM		 = '" & GroupComponentBOM & "' " 
    SQL = SQL & "   AND K3209_GroupComponentSeq		 =  " & GroupComponentSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK3209",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK3209(z3209 As T3209_AREA) As Boolean
    WRITE_PFK3209 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z3209)
 
    SQL = " INSERT INTO PFK3209 "
    SQL = SQL & " ( "
    SQL = SQL & " K3209_GroupComponentBOM," 
    SQL = SQL & " K3209_GroupComponentSeq," 
    SQL = SQL & " K3209_Dseq," 
    SQL = SQL & " K3209_ProcessSeq," 
    SQL = SQL & " K3209_CustomerCode," 
    SQL = SQL & " K3209_selGroupComponent," 
    SQL = SQL & " K3209_cdGroupComponent," 
    SQL = SQL & " K3209_ComponentName," 
    SQL = SQL & " K3209_MaterialCode," 
    SQL = SQL & " K3209_seUnitMaterial," 
    SQL = SQL & " K3209_cdUnitMaterial," 
    SQL = SQL & " K3209_Specification," 
    SQL = SQL & " K3209_Width," 
    SQL = SQL & " K3209_WidthID," 
    SQL = SQL & " K3209_Height," 
    SQL = SQL & " K3209_SizeName," 
    SQL = SQL & " K3209_cdColorCode," 
    SQL = SQL & " K3209_ColorCode," 
    SQL = SQL & " K3209_ColorName," 
    SQL = SQL & " K3209_seShoesStatus," 
    SQL = SQL & " K3209_cdShoesStatus," 
    SQL = SQL & " K3209_seDepartment," 
    SQL = SQL & " K3209_cdDepartment," 
    SQL = SQL & " K3209_ContractID," 
    SQL = SQL & " K3209_ContracSeq," 
    SQL = SQL & " K3209_SupplierCode," 
    SQL = SQL & " K3209_PriceMaterial," 
    SQL = SQL & " K3209_ExchangeCost," 
    SQL = SQL & " K3209_ComplicationCost," 
    SQL = SQL & " K3209_AddedCost," 
    SQL = SQL & " K3209_ShippingRate," 
    SQL = SQL & " K3209_ShippingCost," 
    SQL = SQL & " K3209_PriceRnD," 
    SQL = SQL & " K3209_Price," 
    SQL = SQL & " K3209_seUnitPrice," 
    SQL = SQL & " K3209_cdUnitPrice," 
    SQL = SQL & " K3209_QtyComponent," 
    SQL = SQL & " K3209_Consumption," 
    SQL = SQL & " K3209_Loss," 
    SQL = SQL & " K3209_GrossUsage," 
    SQL = SQL & " K3209_MaterialAMT," 
    SQL = SQL & " K3209_MaterialAMTPurchasing," 
    SQL = SQL & " K3209_MaterialAMTSales," 
    SQL = SQL & " K3209_seSubProcess," 
    SQL = SQL & " K3209_cdSubProcess," 
    SQL = SQL & " K3209_seSpecialProcess," 
    SQL = SQL & " K3209_cdSpecialProcess," 
    SQL = SQL & " K3209_CheckMark," 
    SQL = SQL & " K3209_CheckUse," 
    SQL = SQL & " K3209_CheckP1," 
    SQL = SQL & " K3209_CheckP2," 
    SQL = SQL & " K3209_CheckP3," 
    SQL = SQL & " K3209_CheckP4," 
    SQL = SQL & " K3209_CheckP5," 
    SQL = SQL & " K3209_CheckP6," 
    SQL = SQL & " K3209_CheckP7," 
    SQL = SQL & " K3209_CheckP8," 
    SQL = SQL & " K3209_CheckP9," 
    SQL = SQL & " K3209_CheckUse1," 
    SQL = SQL & " K3209_CheckMatching," 
    SQL = SQL & " K3209_Remark," 
    SQL = SQL & " K3209_MaterialCode_K3011," 
    SQL = SQL & " K3209_seSite," 
    SQL = SQL & " K3209_cdSite," 
    SQL = SQL & " K3209_DateInsert," 
    SQL = SQL & " K3209_DateUpdate," 
    SQL = SQL & " K3209_InchargeInsert," 
    SQL = SQL & " K3209_InchargeUpdate," 
    SQL = SQL & " K3209_TimeInsert," 
    SQL = SQL & " K3209_TimeUpdate " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z3209.GroupComponentBOM) & "', "  
    SQL = SQL & "   " & FormatSQL(z3209.GroupComponentSeq) & ", "  
    SQL = SQL & "   " & FormatSQL(z3209.Dseq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3209.ProcessSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.CustomerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.selGroupComponent) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.cdGroupComponent) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.ComponentName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.MaterialCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.seUnitMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.cdUnitMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.Specification) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.Width) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.WidthID) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.Height) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.SizeName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.cdColorCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.ColorCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.ColorName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.seShoesStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.cdShoesStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.seDepartment) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.cdDepartment) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.ContractID) & "', "  
    SQL = SQL & "   " & FormatSQL(z3209.ContracSeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3209.SupplierCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z3209.PriceMaterial) & ", "  
    SQL = SQL & "   " & FormatSQL(z3209.ExchangeCost) & ", "  
    SQL = SQL & "   " & FormatSQL(z3209.ComplicationCost) & ", "  
    SQL = SQL & "   " & FormatSQL(z3209.AddedCost) & ", "  
    SQL = SQL & "   " & FormatSQL(z3209.ShippingRate) & ", "  
    SQL = SQL & "   " & FormatSQL(z3209.ShippingCost) & ", "  
    SQL = SQL & "   " & FormatSQL(z3209.PriceRnD) & ", "  
    SQL = SQL & "   " & FormatSQL(z3209.Price) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3209.seUnitPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.cdUnitPrice) & "', "  
    SQL = SQL & "   " & FormatSQL(z3209.QtyComponent) & ", "  
    SQL = SQL & "   " & FormatSQL(z3209.Consumption) & ", "  
    SQL = SQL & "   " & FormatSQL(z3209.Loss) & ", "  
    SQL = SQL & "   " & FormatSQL(z3209.GrossUsage) & ", "  
    SQL = SQL & "   " & FormatSQL(z3209.MaterialAMT) & ", "  
    SQL = SQL & "   " & FormatSQL(z3209.MaterialAMTPurchasing) & ", "  
    SQL = SQL & "   " & FormatSQL(z3209.MaterialAMTSales) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3209.seSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.cdSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.seSpecialProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.cdSpecialProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.CheckMark) & "', "  
        SQL = SQL & "  N'1', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.CheckP1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.CheckP2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.CheckP3) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.CheckP4) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.CheckP5) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.CheckP6) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.CheckP7) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.CheckP8) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.CheckP9) & "', "  
        SQL = SQL & "  N'1', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.CheckMatching) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.Remark) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.MaterialCode_K3011) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.seSite) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.cdSite) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.DAT) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.SAW) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.TIME) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3209.TimeUpdate) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK3209 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK3209",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK3209(z3209 As T3209_AREA) As Boolean
    REWRITE_PFK3209 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z3209)
   
    SQL = " UPDATE PFK3209 SET "
    SQL = SQL & "    K3209_Dseq      =  " & FormatSQL(z3209.Dseq) & ", " 
    SQL = SQL & "    K3209_ProcessSeq      = N'" & FormatSQL(z3209.ProcessSeq) & "', " 
    SQL = SQL & "    K3209_CustomerCode      = N'" & FormatSQL(z3209.CustomerCode) & "', " 
    SQL = SQL & "    K3209_selGroupComponent      = N'" & FormatSQL(z3209.selGroupComponent) & "', " 
    SQL = SQL & "    K3209_cdGroupComponent      = N'" & FormatSQL(z3209.cdGroupComponent) & "', " 
    SQL = SQL & "    K3209_ComponentName      = N'" & FormatSQL(z3209.ComponentName) & "', " 
    SQL = SQL & "    K3209_MaterialCode      = N'" & FormatSQL(z3209.MaterialCode) & "', " 
    SQL = SQL & "    K3209_seUnitMaterial      = N'" & FormatSQL(z3209.seUnitMaterial) & "', " 
    SQL = SQL & "    K3209_cdUnitMaterial      = N'" & FormatSQL(z3209.cdUnitMaterial) & "', " 
    SQL = SQL & "    K3209_Specification      = N'" & FormatSQL(z3209.Specification) & "', " 
    SQL = SQL & "    K3209_Width      = N'" & FormatSQL(z3209.Width) & "', " 
    SQL = SQL & "    K3209_WidthID      = N'" & FormatSQL(z3209.WidthID) & "', " 
    SQL = SQL & "    K3209_Height      = N'" & FormatSQL(z3209.Height) & "', " 
    SQL = SQL & "    K3209_SizeName      = N'" & FormatSQL(z3209.SizeName) & "', " 
    SQL = SQL & "    K3209_cdColorCode      = N'" & FormatSQL(z3209.cdColorCode) & "', " 
    SQL = SQL & "    K3209_ColorCode      = N'" & FormatSQL(z3209.ColorCode) & "', " 
    SQL = SQL & "    K3209_ColorName      = N'" & FormatSQL(z3209.ColorName) & "', " 
    SQL = SQL & "    K3209_seShoesStatus      = N'" & FormatSQL(z3209.seShoesStatus) & "', " 
    SQL = SQL & "    K3209_cdShoesStatus      = N'" & FormatSQL(z3209.cdShoesStatus) & "', " 
    SQL = SQL & "    K3209_seDepartment      = N'" & FormatSQL(z3209.seDepartment) & "', " 
    SQL = SQL & "    K3209_cdDepartment      = N'" & FormatSQL(z3209.cdDepartment) & "', " 
    SQL = SQL & "    K3209_ContractID      = N'" & FormatSQL(z3209.ContractID) & "', " 
    SQL = SQL & "    K3209_ContracSeq      =  " & FormatSQL(z3209.ContracSeq) & ", " 
    SQL = SQL & "    K3209_SupplierCode      = N'" & FormatSQL(z3209.SupplierCode) & "', " 
    SQL = SQL & "    K3209_PriceMaterial      =  " & FormatSQL(z3209.PriceMaterial) & ", " 
    SQL = SQL & "    K3209_ExchangeCost      =  " & FormatSQL(z3209.ExchangeCost) & ", " 
    SQL = SQL & "    K3209_ComplicationCost      =  " & FormatSQL(z3209.ComplicationCost) & ", " 
    SQL = SQL & "    K3209_AddedCost      =  " & FormatSQL(z3209.AddedCost) & ", " 
    SQL = SQL & "    K3209_ShippingRate      =  " & FormatSQL(z3209.ShippingRate) & ", " 
    SQL = SQL & "    K3209_ShippingCost      =  " & FormatSQL(z3209.ShippingCost) & ", " 
    SQL = SQL & "    K3209_PriceRnD      =  " & FormatSQL(z3209.PriceRnD) & ", " 
    SQL = SQL & "    K3209_Price      =  " & FormatSQL(z3209.Price) & ", " 
    SQL = SQL & "    K3209_seUnitPrice      = N'" & FormatSQL(z3209.seUnitPrice) & "', " 
    SQL = SQL & "    K3209_cdUnitPrice      = N'" & FormatSQL(z3209.cdUnitPrice) & "', " 
    SQL = SQL & "    K3209_QtyComponent      =  " & FormatSQL(z3209.QtyComponent) & ", " 
    SQL = SQL & "    K3209_Consumption      =  " & FormatSQL(z3209.Consumption) & ", " 
    SQL = SQL & "    K3209_Loss      =  " & FormatSQL(z3209.Loss) & ", " 
    SQL = SQL & "    K3209_GrossUsage      =  " & FormatSQL(z3209.GrossUsage) & ", " 
    SQL = SQL & "    K3209_MaterialAMT      =  " & FormatSQL(z3209.MaterialAMT) & ", " 
    SQL = SQL & "    K3209_MaterialAMTPurchasing      =  " & FormatSQL(z3209.MaterialAMTPurchasing) & ", " 
    SQL = SQL & "    K3209_MaterialAMTSales      =  " & FormatSQL(z3209.MaterialAMTSales) & ", " 
    SQL = SQL & "    K3209_seSubProcess      = N'" & FormatSQL(z3209.seSubProcess) & "', " 
    SQL = SQL & "    K3209_cdSubProcess      = N'" & FormatSQL(z3209.cdSubProcess) & "', " 
    SQL = SQL & "    K3209_seSpecialProcess      = N'" & FormatSQL(z3209.seSpecialProcess) & "', " 
    SQL = SQL & "    K3209_cdSpecialProcess      = N'" & FormatSQL(z3209.cdSpecialProcess) & "', " 
    SQL = SQL & "    K3209_CheckMark      = N'" & FormatSQL(z3209.CheckMark) & "', " 
    SQL = SQL & "    K3209_CheckUse      = N'" & FormatSQL(z3209.CheckUse) & "', " 
    SQL = SQL & "    K3209_CheckP1      = N'" & FormatSQL(z3209.CheckP1) & "', " 
    SQL = SQL & "    K3209_CheckP2      = N'" & FormatSQL(z3209.CheckP2) & "', " 
    SQL = SQL & "    K3209_CheckP3      = N'" & FormatSQL(z3209.CheckP3) & "', " 
    SQL = SQL & "    K3209_CheckP4      = N'" & FormatSQL(z3209.CheckP4) & "', " 
    SQL = SQL & "    K3209_CheckP5      = N'" & FormatSQL(z3209.CheckP5) & "', " 
    SQL = SQL & "    K3209_CheckP6      = N'" & FormatSQL(z3209.CheckP6) & "', " 
    SQL = SQL & "    K3209_CheckP7      = N'" & FormatSQL(z3209.CheckP7) & "', " 
    SQL = SQL & "    K3209_CheckP8      = N'" & FormatSQL(z3209.CheckP8) & "', " 
    SQL = SQL & "    K3209_CheckP9      = N'" & FormatSQL(z3209.CheckP9) & "', " 
    SQL = SQL & "    K3209_CheckUse1      = N'" & FormatSQL(z3209.CheckUse1) & "', " 
    SQL = SQL & "    K3209_CheckMatching      = N'" & FormatSQL(z3209.CheckMatching) & "', " 
    SQL = SQL & "    K3209_Remark      = N'" & FormatSQL(z3209.Remark) & "', " 
    SQL = SQL & "    K3209_MaterialCode_K3011      = N'" & FormatSQL(z3209.MaterialCode_K3011) & "', " 
    SQL = SQL & "    K3209_seSite      = N'" & FormatSQL(z3209.seSite) & "', " 
    SQL = SQL & "    K3209_cdSite      = N'" & FormatSQL(z3209.cdSite) & "', " 
    SQL = SQL & "    K3209_DateInsert      = N'" & FormatSQL(z3209.DateInsert) & "', " 
    SQL = SQL & "    K3209_DateUpdate      = N'" & FormatSQL(PUB.DAT) & "', " 
    SQL = SQL & "    K3209_InchargeInsert      = N'" & FormatSQL(z3209.InchargeInsert) & "', " 
    SQL = SQL & "    K3209_InchargeUpdate      = N'" & FormatSQL(PUB.SAW) & "', " 
    SQL = SQL & "    K3209_TimeInsert      = N'" & FormatSQL(z3209.TimeInsert) & "', " 
    SQL = SQL & "    K3209_TimeUpdate      = N'" & FormatSQL(PUB.TIME) & "'  " 
    SQL = SQL & " WHERE K3209_GroupComponentBOM		 = '" & z3209.GroupComponentBOM & "' " 
    SQL = SQL & "   AND K3209_GroupComponentSeq		 =  " & z3209.GroupComponentSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  

    REWRITE_PFK3209 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK3209",vbCritical)

  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK3209(z3209 As T3209_AREA) As Boolean
    DELETE_PFK3209 = False

   Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z3209)
      
        SQL = " DELETE FROM PFK3209  "
    SQL = SQL & " WHERE K3209_GroupComponentBOM		 = '" & z3209.GroupComponentBOM & "' " 
    SQL = SQL & "   AND K3209_GroupComponentSeq		 =  " & z3209.GroupComponentSeq & "  " 

    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK3209 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK3209",vbCritical)
Finally
        Call GetFullInformation("PFK3209", "D", SQL)
  End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D3209_CLEAR()
Try
    
   D3209.GroupComponentBOM = ""
    D3209.GroupComponentSeq = 0 
    D3209.Dseq = 0 
   D3209.ProcessSeq = ""
   D3209.CustomerCode = ""
   D3209.selGroupComponent = ""
   D3209.cdGroupComponent = ""
   D3209.ComponentName = ""
   D3209.MaterialCode = ""
   D3209.seUnitMaterial = ""
   D3209.cdUnitMaterial = ""
   D3209.Specification = ""
   D3209.Width = ""
   D3209.WidthID = ""
   D3209.Height = ""
   D3209.SizeName = ""
   D3209.cdColorCode = ""
   D3209.ColorCode = ""
   D3209.ColorName = ""
   D3209.seShoesStatus = ""
   D3209.cdShoesStatus = ""
   D3209.seDepartment = ""
   D3209.cdDepartment = ""
   D3209.ContractID = ""
    D3209.ContracSeq = 0 
   D3209.SupplierCode = ""
    D3209.PriceMaterial = 0 
    D3209.ExchangeCost = 0 
    D3209.ComplicationCost = 0 
    D3209.AddedCost = 0 
    D3209.ShippingRate = 0 
    D3209.ShippingCost = 0 
    D3209.PriceRnD = 0 
    D3209.Price = 0 
   D3209.seUnitPrice = ""
   D3209.cdUnitPrice = ""
    D3209.QtyComponent = 0 
    D3209.Consumption = 0 
    D3209.Loss = 0 
    D3209.GrossUsage = 0 
    D3209.MaterialAMT = 0 
    D3209.MaterialAMTPurchasing = 0 
    D3209.MaterialAMTSales = 0 
   D3209.seSubProcess = ""
   D3209.cdSubProcess = ""
   D3209.seSpecialProcess = ""
   D3209.cdSpecialProcess = ""
   D3209.CheckMark = ""
   D3209.CheckUse = ""
   D3209.CheckP1 = ""
   D3209.CheckP2 = ""
   D3209.CheckP3 = ""
   D3209.CheckP4 = ""
   D3209.CheckP5 = ""
   D3209.CheckP6 = ""
   D3209.CheckP7 = ""
   D3209.CheckP8 = ""
   D3209.CheckP9 = ""
   D3209.CheckUse1 = ""
   D3209.CheckMatching = ""
   D3209.Remark = ""
   D3209.MaterialCode_K3011 = ""
   D3209.seSite = ""
   D3209.cdSite = ""
   D3209.DateInsert = ""
   D3209.DateUpdate = ""
   D3209.InchargeInsert = ""
   D3209.InchargeUpdate = ""
   D3209.TimeInsert = ""
   D3209.TimeUpdate = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D3209_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x3209 As T3209_AREA)
Try
    
    x3209.GroupComponentBOM = trim$(  x3209.GroupComponentBOM)
    x3209.GroupComponentSeq = trim$(  x3209.GroupComponentSeq)
    x3209.Dseq = trim$(  x3209.Dseq)
    x3209.ProcessSeq = trim$(  x3209.ProcessSeq)
    x3209.CustomerCode = trim$(  x3209.CustomerCode)
    x3209.selGroupComponent = trim$(  x3209.selGroupComponent)
    x3209.cdGroupComponent = trim$(  x3209.cdGroupComponent)
    x3209.ComponentName = trim$(  x3209.ComponentName)
    x3209.MaterialCode = trim$(  x3209.MaterialCode)
    x3209.seUnitMaterial = trim$(  x3209.seUnitMaterial)
    x3209.cdUnitMaterial = trim$(  x3209.cdUnitMaterial)
    x3209.Specification = trim$(  x3209.Specification)
    x3209.Width = trim$(  x3209.Width)
    x3209.WidthID = trim$(  x3209.WidthID)
    x3209.Height = trim$(  x3209.Height)
    x3209.SizeName = trim$(  x3209.SizeName)
    x3209.cdColorCode = trim$(  x3209.cdColorCode)
    x3209.ColorCode = trim$(  x3209.ColorCode)
    x3209.ColorName = trim$(  x3209.ColorName)
    x3209.seShoesStatus = trim$(  x3209.seShoesStatus)
    x3209.cdShoesStatus = trim$(  x3209.cdShoesStatus)
    x3209.seDepartment = trim$(  x3209.seDepartment)
    x3209.cdDepartment = trim$(  x3209.cdDepartment)
    x3209.ContractID = trim$(  x3209.ContractID)
    x3209.ContracSeq = trim$(  x3209.ContracSeq)
    x3209.SupplierCode = trim$(  x3209.SupplierCode)
    x3209.PriceMaterial = trim$(  x3209.PriceMaterial)
    x3209.ExchangeCost = trim$(  x3209.ExchangeCost)
    x3209.ComplicationCost = trim$(  x3209.ComplicationCost)
    x3209.AddedCost = trim$(  x3209.AddedCost)
    x3209.ShippingRate = trim$(  x3209.ShippingRate)
    x3209.ShippingCost = trim$(  x3209.ShippingCost)
    x3209.PriceRnD = trim$(  x3209.PriceRnD)
    x3209.Price = trim$(  x3209.Price)
    x3209.seUnitPrice = trim$(  x3209.seUnitPrice)
    x3209.cdUnitPrice = trim$(  x3209.cdUnitPrice)
    x3209.QtyComponent = trim$(  x3209.QtyComponent)
    x3209.Consumption = trim$(  x3209.Consumption)
    x3209.Loss = trim$(  x3209.Loss)
    x3209.GrossUsage = trim$(  x3209.GrossUsage)
    x3209.MaterialAMT = trim$(  x3209.MaterialAMT)
    x3209.MaterialAMTPurchasing = trim$(  x3209.MaterialAMTPurchasing)
    x3209.MaterialAMTSales = trim$(  x3209.MaterialAMTSales)
    x3209.seSubProcess = trim$(  x3209.seSubProcess)
    x3209.cdSubProcess = trim$(  x3209.cdSubProcess)
    x3209.seSpecialProcess = trim$(  x3209.seSpecialProcess)
    x3209.cdSpecialProcess = trim$(  x3209.cdSpecialProcess)
    x3209.CheckMark = trim$(  x3209.CheckMark)
    x3209.CheckUse = trim$(  x3209.CheckUse)
    x3209.CheckP1 = trim$(  x3209.CheckP1)
    x3209.CheckP2 = trim$(  x3209.CheckP2)
    x3209.CheckP3 = trim$(  x3209.CheckP3)
    x3209.CheckP4 = trim$(  x3209.CheckP4)
    x3209.CheckP5 = trim$(  x3209.CheckP5)
    x3209.CheckP6 = trim$(  x3209.CheckP6)
    x3209.CheckP7 = trim$(  x3209.CheckP7)
    x3209.CheckP8 = trim$(  x3209.CheckP8)
    x3209.CheckP9 = trim$(  x3209.CheckP9)
    x3209.CheckUse1 = trim$(  x3209.CheckUse1)
    x3209.CheckMatching = trim$(  x3209.CheckMatching)
    x3209.Remark = trim$(  x3209.Remark)
    x3209.MaterialCode_K3011 = trim$(  x3209.MaterialCode_K3011)
    x3209.seSite = trim$(  x3209.seSite)
    x3209.cdSite = trim$(  x3209.cdSite)
    x3209.DateInsert = trim$(  x3209.DateInsert)
    x3209.DateUpdate = trim$(  x3209.DateUpdate)
    x3209.InchargeInsert = trim$(  x3209.InchargeInsert)
    x3209.InchargeUpdate = trim$(  x3209.InchargeUpdate)
    x3209.TimeInsert = trim$(  x3209.TimeInsert)
    x3209.TimeUpdate = trim$(  x3209.TimeUpdate)
     
    If trim$( x3209.GroupComponentBOM ) = "" Then x3209.GroupComponentBOM = Space(1) 
    If trim$( x3209.GroupComponentSeq ) = "" Then x3209.GroupComponentSeq = 0 
    If trim$( x3209.Dseq ) = "" Then x3209.Dseq = 0 
    If trim$( x3209.ProcessSeq ) = "" Then x3209.ProcessSeq = Space(1) 
    If trim$( x3209.CustomerCode ) = "" Then x3209.CustomerCode = Space(1) 
    If trim$( x3209.selGroupComponent ) = "" Then x3209.selGroupComponent = Space(1) 
    If trim$( x3209.cdGroupComponent ) = "" Then x3209.cdGroupComponent = Space(1) 
    If trim$( x3209.ComponentName ) = "" Then x3209.ComponentName = Space(1) 
    If trim$( x3209.MaterialCode ) = "" Then x3209.MaterialCode = Space(1) 
    If trim$( x3209.seUnitMaterial ) = "" Then x3209.seUnitMaterial = Space(1) 
    If trim$( x3209.cdUnitMaterial ) = "" Then x3209.cdUnitMaterial = Space(1) 
    If trim$( x3209.Specification ) = "" Then x3209.Specification = Space(1) 
    If trim$( x3209.Width ) = "" Then x3209.Width = Space(1) 
    If trim$( x3209.WidthID ) = "" Then x3209.WidthID = Space(1) 
    If trim$( x3209.Height ) = "" Then x3209.Height = Space(1) 
    If trim$( x3209.SizeName ) = "" Then x3209.SizeName = Space(1) 
    If trim$( x3209.cdColorCode ) = "" Then x3209.cdColorCode = Space(1) 
    If trim$( x3209.ColorCode ) = "" Then x3209.ColorCode = Space(1) 
    If trim$( x3209.ColorName ) = "" Then x3209.ColorName = Space(1) 
    If trim$( x3209.seShoesStatus ) = "" Then x3209.seShoesStatus = Space(1) 
    If trim$( x3209.cdShoesStatus ) = "" Then x3209.cdShoesStatus = Space(1) 
    If trim$( x3209.seDepartment ) = "" Then x3209.seDepartment = Space(1) 
    If trim$( x3209.cdDepartment ) = "" Then x3209.cdDepartment = Space(1) 
    If trim$( x3209.ContractID ) = "" Then x3209.ContractID = Space(1) 
    If trim$( x3209.ContracSeq ) = "" Then x3209.ContracSeq = 0 
    If trim$( x3209.SupplierCode ) = "" Then x3209.SupplierCode = Space(1) 
    If trim$( x3209.PriceMaterial ) = "" Then x3209.PriceMaterial = 0 
    If trim$( x3209.ExchangeCost ) = "" Then x3209.ExchangeCost = 0 
    If trim$( x3209.ComplicationCost ) = "" Then x3209.ComplicationCost = 0 
    If trim$( x3209.AddedCost ) = "" Then x3209.AddedCost = 0 
    If trim$( x3209.ShippingRate ) = "" Then x3209.ShippingRate = 0 
    If trim$( x3209.ShippingCost ) = "" Then x3209.ShippingCost = 0 
    If trim$( x3209.PriceRnD ) = "" Then x3209.PriceRnD = 0 
    If trim$( x3209.Price ) = "" Then x3209.Price = 0 
    If trim$( x3209.seUnitPrice ) = "" Then x3209.seUnitPrice = Space(1) 
    If trim$( x3209.cdUnitPrice ) = "" Then x3209.cdUnitPrice = Space(1) 
    If trim$( x3209.QtyComponent ) = "" Then x3209.QtyComponent = 0 
    If trim$( x3209.Consumption ) = "" Then x3209.Consumption = 0 
    If trim$( x3209.Loss ) = "" Then x3209.Loss = 0 
    If trim$( x3209.GrossUsage ) = "" Then x3209.GrossUsage = 0 
    If trim$( x3209.MaterialAMT ) = "" Then x3209.MaterialAMT = 0 
    If trim$( x3209.MaterialAMTPurchasing ) = "" Then x3209.MaterialAMTPurchasing = 0 
    If trim$( x3209.MaterialAMTSales ) = "" Then x3209.MaterialAMTSales = 0 
    If trim$( x3209.seSubProcess ) = "" Then x3209.seSubProcess = Space(1) 
    If trim$( x3209.cdSubProcess ) = "" Then x3209.cdSubProcess = Space(1) 
    If trim$( x3209.seSpecialProcess ) = "" Then x3209.seSpecialProcess = Space(1) 
    If trim$( x3209.cdSpecialProcess ) = "" Then x3209.cdSpecialProcess = Space(1) 
    If trim$( x3209.CheckMark ) = "" Then x3209.CheckMark = Space(1) 
    If trim$( x3209.CheckUse ) = "" Then x3209.CheckUse = Space(1) 
    If trim$( x3209.CheckP1 ) = "" Then x3209.CheckP1 = Space(1) 
    If trim$( x3209.CheckP2 ) = "" Then x3209.CheckP2 = Space(1) 
    If trim$( x3209.CheckP3 ) = "" Then x3209.CheckP3 = Space(1) 
    If trim$( x3209.CheckP4 ) = "" Then x3209.CheckP4 = Space(1) 
    If trim$( x3209.CheckP5 ) = "" Then x3209.CheckP5 = Space(1) 
    If trim$( x3209.CheckP6 ) = "" Then x3209.CheckP6 = Space(1) 
    If trim$( x3209.CheckP7 ) = "" Then x3209.CheckP7 = Space(1) 
    If trim$( x3209.CheckP8 ) = "" Then x3209.CheckP8 = Space(1) 
    If trim$( x3209.CheckP9 ) = "" Then x3209.CheckP9 = Space(1) 
    If trim$( x3209.CheckUse1 ) = "" Then x3209.CheckUse1 = Space(1) 
    If trim$( x3209.CheckMatching ) = "" Then x3209.CheckMatching = Space(1) 
    If trim$( x3209.Remark ) = "" Then x3209.Remark = Space(1) 
    If trim$( x3209.MaterialCode_K3011 ) = "" Then x3209.MaterialCode_K3011 = Space(1) 
    If trim$( x3209.seSite ) = "" Then x3209.seSite = Space(1) 
    If trim$( x3209.cdSite ) = "" Then x3209.cdSite = Space(1) 
    If trim$( x3209.DateInsert ) = "" Then x3209.DateInsert = Space(1) 
    If trim$( x3209.DateUpdate ) = "" Then x3209.DateUpdate = Space(1) 
    If trim$( x3209.InchargeInsert ) = "" Then x3209.InchargeInsert = Space(1) 
    If trim$( x3209.InchargeUpdate ) = "" Then x3209.InchargeUpdate = Space(1) 
    If trim$( x3209.TimeInsert ) = "" Then x3209.TimeInsert = Space(1) 
    If trim$( x3209.TimeUpdate ) = "" Then x3209.TimeUpdate = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K3209_MOVE(rs3209 As SqlClient.SqlDataReader)
Try

    call D3209_CLEAR()   

    If IsdbNull(rs3209!K3209_GroupComponentBOM) = False Then D3209.GroupComponentBOM = Trim$(rs3209!K3209_GroupComponentBOM)
    If IsdbNull(rs3209!K3209_GroupComponentSeq) = False Then D3209.GroupComponentSeq = Trim$(rs3209!K3209_GroupComponentSeq)
    If IsdbNull(rs3209!K3209_Dseq) = False Then D3209.Dseq = Trim$(rs3209!K3209_Dseq)
    If IsdbNull(rs3209!K3209_ProcessSeq) = False Then D3209.ProcessSeq = Trim$(rs3209!K3209_ProcessSeq)
    If IsdbNull(rs3209!K3209_CustomerCode) = False Then D3209.CustomerCode = Trim$(rs3209!K3209_CustomerCode)
    If IsdbNull(rs3209!K3209_selGroupComponent) = False Then D3209.selGroupComponent = Trim$(rs3209!K3209_selGroupComponent)
    If IsdbNull(rs3209!K3209_cdGroupComponent) = False Then D3209.cdGroupComponent = Trim$(rs3209!K3209_cdGroupComponent)
    If IsdbNull(rs3209!K3209_ComponentName) = False Then D3209.ComponentName = Trim$(rs3209!K3209_ComponentName)
    If IsdbNull(rs3209!K3209_MaterialCode) = False Then D3209.MaterialCode = Trim$(rs3209!K3209_MaterialCode)
    If IsdbNull(rs3209!K3209_seUnitMaterial) = False Then D3209.seUnitMaterial = Trim$(rs3209!K3209_seUnitMaterial)
    If IsdbNull(rs3209!K3209_cdUnitMaterial) = False Then D3209.cdUnitMaterial = Trim$(rs3209!K3209_cdUnitMaterial)
    If IsdbNull(rs3209!K3209_Specification) = False Then D3209.Specification = Trim$(rs3209!K3209_Specification)
    If IsdbNull(rs3209!K3209_Width) = False Then D3209.Width = Trim$(rs3209!K3209_Width)
    If IsdbNull(rs3209!K3209_WidthID) = False Then D3209.WidthID = Trim$(rs3209!K3209_WidthID)
    If IsdbNull(rs3209!K3209_Height) = False Then D3209.Height = Trim$(rs3209!K3209_Height)
    If IsdbNull(rs3209!K3209_SizeName) = False Then D3209.SizeName = Trim$(rs3209!K3209_SizeName)
    If IsdbNull(rs3209!K3209_cdColorCode) = False Then D3209.cdColorCode = Trim$(rs3209!K3209_cdColorCode)
    If IsdbNull(rs3209!K3209_ColorCode) = False Then D3209.ColorCode = Trim$(rs3209!K3209_ColorCode)
    If IsdbNull(rs3209!K3209_ColorName) = False Then D3209.ColorName = Trim$(rs3209!K3209_ColorName)
    If IsdbNull(rs3209!K3209_seShoesStatus) = False Then D3209.seShoesStatus = Trim$(rs3209!K3209_seShoesStatus)
    If IsdbNull(rs3209!K3209_cdShoesStatus) = False Then D3209.cdShoesStatus = Trim$(rs3209!K3209_cdShoesStatus)
    If IsdbNull(rs3209!K3209_seDepartment) = False Then D3209.seDepartment = Trim$(rs3209!K3209_seDepartment)
    If IsdbNull(rs3209!K3209_cdDepartment) = False Then D3209.cdDepartment = Trim$(rs3209!K3209_cdDepartment)
    If IsdbNull(rs3209!K3209_ContractID) = False Then D3209.ContractID = Trim$(rs3209!K3209_ContractID)
    If IsdbNull(rs3209!K3209_ContracSeq) = False Then D3209.ContracSeq = Trim$(rs3209!K3209_ContracSeq)
    If IsdbNull(rs3209!K3209_SupplierCode) = False Then D3209.SupplierCode = Trim$(rs3209!K3209_SupplierCode)
    If IsdbNull(rs3209!K3209_PriceMaterial) = False Then D3209.PriceMaterial = Trim$(rs3209!K3209_PriceMaterial)
    If IsdbNull(rs3209!K3209_ExchangeCost) = False Then D3209.ExchangeCost = Trim$(rs3209!K3209_ExchangeCost)
    If IsdbNull(rs3209!K3209_ComplicationCost) = False Then D3209.ComplicationCost = Trim$(rs3209!K3209_ComplicationCost)
    If IsdbNull(rs3209!K3209_AddedCost) = False Then D3209.AddedCost = Trim$(rs3209!K3209_AddedCost)
    If IsdbNull(rs3209!K3209_ShippingRate) = False Then D3209.ShippingRate = Trim$(rs3209!K3209_ShippingRate)
    If IsdbNull(rs3209!K3209_ShippingCost) = False Then D3209.ShippingCost = Trim$(rs3209!K3209_ShippingCost)
    If IsdbNull(rs3209!K3209_PriceRnD) = False Then D3209.PriceRnD = Trim$(rs3209!K3209_PriceRnD)
    If IsdbNull(rs3209!K3209_Price) = False Then D3209.Price = Trim$(rs3209!K3209_Price)
    If IsdbNull(rs3209!K3209_seUnitPrice) = False Then D3209.seUnitPrice = Trim$(rs3209!K3209_seUnitPrice)
    If IsdbNull(rs3209!K3209_cdUnitPrice) = False Then D3209.cdUnitPrice = Trim$(rs3209!K3209_cdUnitPrice)
    If IsdbNull(rs3209!K3209_QtyComponent) = False Then D3209.QtyComponent = Trim$(rs3209!K3209_QtyComponent)
    If IsdbNull(rs3209!K3209_Consumption) = False Then D3209.Consumption = Trim$(rs3209!K3209_Consumption)
    If IsdbNull(rs3209!K3209_Loss) = False Then D3209.Loss = Trim$(rs3209!K3209_Loss)
    If IsdbNull(rs3209!K3209_GrossUsage) = False Then D3209.GrossUsage = Trim$(rs3209!K3209_GrossUsage)
    If IsdbNull(rs3209!K3209_MaterialAMT) = False Then D3209.MaterialAMT = Trim$(rs3209!K3209_MaterialAMT)
    If IsdbNull(rs3209!K3209_MaterialAMTPurchasing) = False Then D3209.MaterialAMTPurchasing = Trim$(rs3209!K3209_MaterialAMTPurchasing)
    If IsdbNull(rs3209!K3209_MaterialAMTSales) = False Then D3209.MaterialAMTSales = Trim$(rs3209!K3209_MaterialAMTSales)
    If IsdbNull(rs3209!K3209_seSubProcess) = False Then D3209.seSubProcess = Trim$(rs3209!K3209_seSubProcess)
    If IsdbNull(rs3209!K3209_cdSubProcess) = False Then D3209.cdSubProcess = Trim$(rs3209!K3209_cdSubProcess)
    If IsdbNull(rs3209!K3209_seSpecialProcess) = False Then D3209.seSpecialProcess = Trim$(rs3209!K3209_seSpecialProcess)
    If IsdbNull(rs3209!K3209_cdSpecialProcess) = False Then D3209.cdSpecialProcess = Trim$(rs3209!K3209_cdSpecialProcess)
    If IsdbNull(rs3209!K3209_CheckMark) = False Then D3209.CheckMark = Trim$(rs3209!K3209_CheckMark)
    If IsdbNull(rs3209!K3209_CheckUse) = False Then D3209.CheckUse = Trim$(rs3209!K3209_CheckUse)
    If IsdbNull(rs3209!K3209_CheckP1) = False Then D3209.CheckP1 = Trim$(rs3209!K3209_CheckP1)
    If IsdbNull(rs3209!K3209_CheckP2) = False Then D3209.CheckP2 = Trim$(rs3209!K3209_CheckP2)
    If IsdbNull(rs3209!K3209_CheckP3) = False Then D3209.CheckP3 = Trim$(rs3209!K3209_CheckP3)
    If IsdbNull(rs3209!K3209_CheckP4) = False Then D3209.CheckP4 = Trim$(rs3209!K3209_CheckP4)
    If IsdbNull(rs3209!K3209_CheckP5) = False Then D3209.CheckP5 = Trim$(rs3209!K3209_CheckP5)
    If IsdbNull(rs3209!K3209_CheckP6) = False Then D3209.CheckP6 = Trim$(rs3209!K3209_CheckP6)
    If IsdbNull(rs3209!K3209_CheckP7) = False Then D3209.CheckP7 = Trim$(rs3209!K3209_CheckP7)
    If IsdbNull(rs3209!K3209_CheckP8) = False Then D3209.CheckP8 = Trim$(rs3209!K3209_CheckP8)
    If IsdbNull(rs3209!K3209_CheckP9) = False Then D3209.CheckP9 = Trim$(rs3209!K3209_CheckP9)
    If IsdbNull(rs3209!K3209_CheckUse1) = False Then D3209.CheckUse1 = Trim$(rs3209!K3209_CheckUse1)
    If IsdbNull(rs3209!K3209_CheckMatching) = False Then D3209.CheckMatching = Trim$(rs3209!K3209_CheckMatching)
    If IsdbNull(rs3209!K3209_Remark) = False Then D3209.Remark = Trim$(rs3209!K3209_Remark)
    If IsdbNull(rs3209!K3209_MaterialCode_K3011) = False Then D3209.MaterialCode_K3011 = Trim$(rs3209!K3209_MaterialCode_K3011)
    If IsdbNull(rs3209!K3209_seSite) = False Then D3209.seSite = Trim$(rs3209!K3209_seSite)
    If IsdbNull(rs3209!K3209_cdSite) = False Then D3209.cdSite = Trim$(rs3209!K3209_cdSite)
    If IsdbNull(rs3209!K3209_DateInsert) = False Then D3209.DateInsert = Trim$(rs3209!K3209_DateInsert)
    If IsdbNull(rs3209!K3209_DateUpdate) = False Then D3209.DateUpdate = Trim$(rs3209!K3209_DateUpdate)
    If IsdbNull(rs3209!K3209_InchargeInsert) = False Then D3209.InchargeInsert = Trim$(rs3209!K3209_InchargeInsert)
    If IsdbNull(rs3209!K3209_InchargeUpdate) = False Then D3209.InchargeUpdate = Trim$(rs3209!K3209_InchargeUpdate)
    If IsdbNull(rs3209!K3209_TimeInsert) = False Then D3209.TimeInsert = Trim$(rs3209!K3209_TimeInsert)
    If IsdbNull(rs3209!K3209_TimeUpdate) = False Then D3209.TimeUpdate = Trim$(rs3209!K3209_TimeUpdate)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3209_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K3209_MOVE(rs3209 As DataRow)
Try

    call D3209_CLEAR()   

    If IsdbNull(rs3209!K3209_GroupComponentBOM) = False Then D3209.GroupComponentBOM = Trim$(rs3209!K3209_GroupComponentBOM)
    If IsdbNull(rs3209!K3209_GroupComponentSeq) = False Then D3209.GroupComponentSeq = Trim$(rs3209!K3209_GroupComponentSeq)
    If IsdbNull(rs3209!K3209_Dseq) = False Then D3209.Dseq = Trim$(rs3209!K3209_Dseq)
    If IsdbNull(rs3209!K3209_ProcessSeq) = False Then D3209.ProcessSeq = Trim$(rs3209!K3209_ProcessSeq)
    If IsdbNull(rs3209!K3209_CustomerCode) = False Then D3209.CustomerCode = Trim$(rs3209!K3209_CustomerCode)
    If IsdbNull(rs3209!K3209_selGroupComponent) = False Then D3209.selGroupComponent = Trim$(rs3209!K3209_selGroupComponent)
    If IsdbNull(rs3209!K3209_cdGroupComponent) = False Then D3209.cdGroupComponent = Trim$(rs3209!K3209_cdGroupComponent)
    If IsdbNull(rs3209!K3209_ComponentName) = False Then D3209.ComponentName = Trim$(rs3209!K3209_ComponentName)
    If IsdbNull(rs3209!K3209_MaterialCode) = False Then D3209.MaterialCode = Trim$(rs3209!K3209_MaterialCode)
    If IsdbNull(rs3209!K3209_seUnitMaterial) = False Then D3209.seUnitMaterial = Trim$(rs3209!K3209_seUnitMaterial)
    If IsdbNull(rs3209!K3209_cdUnitMaterial) = False Then D3209.cdUnitMaterial = Trim$(rs3209!K3209_cdUnitMaterial)
    If IsdbNull(rs3209!K3209_Specification) = False Then D3209.Specification = Trim$(rs3209!K3209_Specification)
    If IsdbNull(rs3209!K3209_Width) = False Then D3209.Width = Trim$(rs3209!K3209_Width)
    If IsdbNull(rs3209!K3209_WidthID) = False Then D3209.WidthID = Trim$(rs3209!K3209_WidthID)
    If IsdbNull(rs3209!K3209_Height) = False Then D3209.Height = Trim$(rs3209!K3209_Height)
    If IsdbNull(rs3209!K3209_SizeName) = False Then D3209.SizeName = Trim$(rs3209!K3209_SizeName)
    If IsdbNull(rs3209!K3209_cdColorCode) = False Then D3209.cdColorCode = Trim$(rs3209!K3209_cdColorCode)
    If IsdbNull(rs3209!K3209_ColorCode) = False Then D3209.ColorCode = Trim$(rs3209!K3209_ColorCode)
    If IsdbNull(rs3209!K3209_ColorName) = False Then D3209.ColorName = Trim$(rs3209!K3209_ColorName)
    If IsdbNull(rs3209!K3209_seShoesStatus) = False Then D3209.seShoesStatus = Trim$(rs3209!K3209_seShoesStatus)
    If IsdbNull(rs3209!K3209_cdShoesStatus) = False Then D3209.cdShoesStatus = Trim$(rs3209!K3209_cdShoesStatus)
    If IsdbNull(rs3209!K3209_seDepartment) = False Then D3209.seDepartment = Trim$(rs3209!K3209_seDepartment)
    If IsdbNull(rs3209!K3209_cdDepartment) = False Then D3209.cdDepartment = Trim$(rs3209!K3209_cdDepartment)
    If IsdbNull(rs3209!K3209_ContractID) = False Then D3209.ContractID = Trim$(rs3209!K3209_ContractID)
    If IsdbNull(rs3209!K3209_ContracSeq) = False Then D3209.ContracSeq = Trim$(rs3209!K3209_ContracSeq)
    If IsdbNull(rs3209!K3209_SupplierCode) = False Then D3209.SupplierCode = Trim$(rs3209!K3209_SupplierCode)
    If IsdbNull(rs3209!K3209_PriceMaterial) = False Then D3209.PriceMaterial = Trim$(rs3209!K3209_PriceMaterial)
    If IsdbNull(rs3209!K3209_ExchangeCost) = False Then D3209.ExchangeCost = Trim$(rs3209!K3209_ExchangeCost)
    If IsdbNull(rs3209!K3209_ComplicationCost) = False Then D3209.ComplicationCost = Trim$(rs3209!K3209_ComplicationCost)
    If IsdbNull(rs3209!K3209_AddedCost) = False Then D3209.AddedCost = Trim$(rs3209!K3209_AddedCost)
    If IsdbNull(rs3209!K3209_ShippingRate) = False Then D3209.ShippingRate = Trim$(rs3209!K3209_ShippingRate)
    If IsdbNull(rs3209!K3209_ShippingCost) = False Then D3209.ShippingCost = Trim$(rs3209!K3209_ShippingCost)
    If IsdbNull(rs3209!K3209_PriceRnD) = False Then D3209.PriceRnD = Trim$(rs3209!K3209_PriceRnD)
    If IsdbNull(rs3209!K3209_Price) = False Then D3209.Price = Trim$(rs3209!K3209_Price)
    If IsdbNull(rs3209!K3209_seUnitPrice) = False Then D3209.seUnitPrice = Trim$(rs3209!K3209_seUnitPrice)
    If IsdbNull(rs3209!K3209_cdUnitPrice) = False Then D3209.cdUnitPrice = Trim$(rs3209!K3209_cdUnitPrice)
    If IsdbNull(rs3209!K3209_QtyComponent) = False Then D3209.QtyComponent = Trim$(rs3209!K3209_QtyComponent)
    If IsdbNull(rs3209!K3209_Consumption) = False Then D3209.Consumption = Trim$(rs3209!K3209_Consumption)
    If IsdbNull(rs3209!K3209_Loss) = False Then D3209.Loss = Trim$(rs3209!K3209_Loss)
    If IsdbNull(rs3209!K3209_GrossUsage) = False Then D3209.GrossUsage = Trim$(rs3209!K3209_GrossUsage)
    If IsdbNull(rs3209!K3209_MaterialAMT) = False Then D3209.MaterialAMT = Trim$(rs3209!K3209_MaterialAMT)
    If IsdbNull(rs3209!K3209_MaterialAMTPurchasing) = False Then D3209.MaterialAMTPurchasing = Trim$(rs3209!K3209_MaterialAMTPurchasing)
    If IsdbNull(rs3209!K3209_MaterialAMTSales) = False Then D3209.MaterialAMTSales = Trim$(rs3209!K3209_MaterialAMTSales)
    If IsdbNull(rs3209!K3209_seSubProcess) = False Then D3209.seSubProcess = Trim$(rs3209!K3209_seSubProcess)
    If IsdbNull(rs3209!K3209_cdSubProcess) = False Then D3209.cdSubProcess = Trim$(rs3209!K3209_cdSubProcess)
    If IsdbNull(rs3209!K3209_seSpecialProcess) = False Then D3209.seSpecialProcess = Trim$(rs3209!K3209_seSpecialProcess)
    If IsdbNull(rs3209!K3209_cdSpecialProcess) = False Then D3209.cdSpecialProcess = Trim$(rs3209!K3209_cdSpecialProcess)
    If IsdbNull(rs3209!K3209_CheckMark) = False Then D3209.CheckMark = Trim$(rs3209!K3209_CheckMark)
    If IsdbNull(rs3209!K3209_CheckUse) = False Then D3209.CheckUse = Trim$(rs3209!K3209_CheckUse)
    If IsdbNull(rs3209!K3209_CheckP1) = False Then D3209.CheckP1 = Trim$(rs3209!K3209_CheckP1)
    If IsdbNull(rs3209!K3209_CheckP2) = False Then D3209.CheckP2 = Trim$(rs3209!K3209_CheckP2)
    If IsdbNull(rs3209!K3209_CheckP3) = False Then D3209.CheckP3 = Trim$(rs3209!K3209_CheckP3)
    If IsdbNull(rs3209!K3209_CheckP4) = False Then D3209.CheckP4 = Trim$(rs3209!K3209_CheckP4)
    If IsdbNull(rs3209!K3209_CheckP5) = False Then D3209.CheckP5 = Trim$(rs3209!K3209_CheckP5)
    If IsdbNull(rs3209!K3209_CheckP6) = False Then D3209.CheckP6 = Trim$(rs3209!K3209_CheckP6)
    If IsdbNull(rs3209!K3209_CheckP7) = False Then D3209.CheckP7 = Trim$(rs3209!K3209_CheckP7)
    If IsdbNull(rs3209!K3209_CheckP8) = False Then D3209.CheckP8 = Trim$(rs3209!K3209_CheckP8)
    If IsdbNull(rs3209!K3209_CheckP9) = False Then D3209.CheckP9 = Trim$(rs3209!K3209_CheckP9)
    If IsdbNull(rs3209!K3209_CheckUse1) = False Then D3209.CheckUse1 = Trim$(rs3209!K3209_CheckUse1)
    If IsdbNull(rs3209!K3209_CheckMatching) = False Then D3209.CheckMatching = Trim$(rs3209!K3209_CheckMatching)
    If IsdbNull(rs3209!K3209_Remark) = False Then D3209.Remark = Trim$(rs3209!K3209_Remark)
    If IsdbNull(rs3209!K3209_MaterialCode_K3011) = False Then D3209.MaterialCode_K3011 = Trim$(rs3209!K3209_MaterialCode_K3011)
    If IsdbNull(rs3209!K3209_seSite) = False Then D3209.seSite = Trim$(rs3209!K3209_seSite)
    If IsdbNull(rs3209!K3209_cdSite) = False Then D3209.cdSite = Trim$(rs3209!K3209_cdSite)
    If IsdbNull(rs3209!K3209_DateInsert) = False Then D3209.DateInsert = Trim$(rs3209!K3209_DateInsert)
    If IsdbNull(rs3209!K3209_DateUpdate) = False Then D3209.DateUpdate = Trim$(rs3209!K3209_DateUpdate)
    If IsdbNull(rs3209!K3209_InchargeInsert) = False Then D3209.InchargeInsert = Trim$(rs3209!K3209_InchargeInsert)
    If IsdbNull(rs3209!K3209_InchargeUpdate) = False Then D3209.InchargeUpdate = Trim$(rs3209!K3209_InchargeUpdate)
    If IsdbNull(rs3209!K3209_TimeInsert) = False Then D3209.TimeInsert = Trim$(rs3209!K3209_TimeInsert)
    If IsdbNull(rs3209!K3209_TimeUpdate) = False Then D3209.TimeUpdate = Trim$(rs3209!K3209_TimeUpdate)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3209_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K3209_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3209 As T3209_AREA, GROUPCOMPONENTBOM AS String, GROUPCOMPONENTSEQ AS Double) as Boolean

K3209_MOVE = False

Try
    If READ_PFK3209(GROUPCOMPONENTBOM, GROUPCOMPONENTSEQ) = True Then
                z3209 = D3209
		K3209_MOVE = True
		else
	z3209 = nothing
     End If

     If  getColumnIndex(spr,"GroupComponentBOM") > -1 then z3209.GroupComponentBOM = getDataM(spr, getColumnIndex(spr,"GroupComponentBOM"), xRow)
     If  getColumnIndex(spr,"GroupComponentSeq") > -1 then z3209.GroupComponentSeq = Cdecp(getDataM(spr, getColumnIndex(spr,"GroupComponentSeq"), xRow))
     If  getColumnIndex(spr,"Dseq") > -1 then z3209.Dseq = Cdecp(getDataM(spr, getColumnIndex(spr,"Dseq"), xRow))
     If  getColumnIndex(spr,"ProcessSeq") > -1 then z3209.ProcessSeq = getDataM(spr, getColumnIndex(spr,"ProcessSeq"), xRow)
     If  getColumnIndex(spr,"CustomerCode") > -1 then z3209.CustomerCode = getDataM(spr, getColumnIndex(spr,"CustomerCode"), xRow)
     If  getColumnIndex(spr,"selGroupComponent") > -1 then z3209.selGroupComponent = getDataM(spr, getColumnIndex(spr,"selGroupComponent"), xRow)
     If  getColumnIndex(spr,"cdGroupComponent") > -1 then z3209.cdGroupComponent = getDataM(spr, getColumnIndex(spr,"cdGroupComponent"), xRow)
     If  getColumnIndex(spr,"ComponentName") > -1 then z3209.ComponentName = getDataM(spr, getColumnIndex(spr,"ComponentName"), xRow)
     If  getColumnIndex(spr,"MaterialCode") > -1 then z3209.MaterialCode = getDataM(spr, getColumnIndex(spr,"MaterialCode"), xRow)
     If  getColumnIndex(spr,"seUnitMaterial") > -1 then z3209.seUnitMaterial = getDataM(spr, getColumnIndex(spr,"seUnitMaterial"), xRow)
     If  getColumnIndex(spr,"cdUnitMaterial") > -1 then z3209.cdUnitMaterial = getDataM(spr, getColumnIndex(spr,"cdUnitMaterial"), xRow)
     If  getColumnIndex(spr,"Specification") > -1 then z3209.Specification = getDataM(spr, getColumnIndex(spr,"Specification"), xRow)
     If  getColumnIndex(spr,"Width") > -1 then z3209.Width = getDataM(spr, getColumnIndex(spr,"Width"), xRow)
     If  getColumnIndex(spr,"WidthID") > -1 then z3209.WidthID = getDataM(spr, getColumnIndex(spr,"WidthID"), xRow)
     If  getColumnIndex(spr,"Height") > -1 then z3209.Height = getDataM(spr, getColumnIndex(spr,"Height"), xRow)
     If  getColumnIndex(spr,"SizeName") > -1 then z3209.SizeName = getDataM(spr, getColumnIndex(spr,"SizeName"), xRow)
     If  getColumnIndex(spr,"cdColorCode") > -1 then z3209.cdColorCode = getDataM(spr, getColumnIndex(spr,"cdColorCode"), xRow)
     If  getColumnIndex(spr,"ColorCode") > -1 then z3209.ColorCode = getDataM(spr, getColumnIndex(spr,"ColorCode"), xRow)
     If  getColumnIndex(spr,"ColorName") > -1 then z3209.ColorName = getDataM(spr, getColumnIndex(spr,"ColorName"), xRow)
     If  getColumnIndex(spr,"seShoesStatus") > -1 then z3209.seShoesStatus = getDataM(spr, getColumnIndex(spr,"seShoesStatus"), xRow)
     If  getColumnIndex(spr,"cdShoesStatus") > -1 then z3209.cdShoesStatus = getDataM(spr, getColumnIndex(spr,"cdShoesStatus"), xRow)
     If  getColumnIndex(spr,"seDepartment") > -1 then z3209.seDepartment = getDataM(spr, getColumnIndex(spr,"seDepartment"), xRow)
     If  getColumnIndex(spr,"cdDepartment") > -1 then z3209.cdDepartment = getDataM(spr, getColumnIndex(spr,"cdDepartment"), xRow)
     If  getColumnIndex(spr,"ContractID") > -1 then z3209.ContractID = getDataM(spr, getColumnIndex(spr,"ContractID"), xRow)
     If  getColumnIndex(spr,"ContracSeq") > -1 then z3209.ContracSeq = Cdecp(getDataM(spr, getColumnIndex(spr,"ContracSeq"), xRow))
     If  getColumnIndex(spr,"SupplierCode") > -1 then z3209.SupplierCode = getDataM(spr, getColumnIndex(spr,"SupplierCode"), xRow)
     If  getColumnIndex(spr,"PriceMaterial") > -1 then z3209.PriceMaterial = Cdecp(getDataM(spr, getColumnIndex(spr,"PriceMaterial"), xRow))
     If  getColumnIndex(spr,"ExchangeCost") > -1 then z3209.ExchangeCost = Cdecp(getDataM(spr, getColumnIndex(spr,"ExchangeCost"), xRow))
     If  getColumnIndex(spr,"ComplicationCost") > -1 then z3209.ComplicationCost = Cdecp(getDataM(spr, getColumnIndex(spr,"ComplicationCost"), xRow))
     If  getColumnIndex(spr,"AddedCost") > -1 then z3209.AddedCost = Cdecp(getDataM(spr, getColumnIndex(spr,"AddedCost"), xRow))
     If  getColumnIndex(spr,"ShippingRate") > -1 then z3209.ShippingRate = Cdecp(getDataM(spr, getColumnIndex(spr,"ShippingRate"), xRow))
     If  getColumnIndex(spr,"ShippingCost") > -1 then z3209.ShippingCost = Cdecp(getDataM(spr, getColumnIndex(spr,"ShippingCost"), xRow))
     If  getColumnIndex(spr,"PriceRnD") > -1 then z3209.PriceRnD = Cdecp(getDataM(spr, getColumnIndex(spr,"PriceRnD"), xRow))
     If  getColumnIndex(spr,"Price") > -1 then z3209.Price = Cdecp(getDataM(spr, getColumnIndex(spr,"Price"), xRow))
     If  getColumnIndex(spr,"seUnitPrice") > -1 then z3209.seUnitPrice = getDataM(spr, getColumnIndex(spr,"seUnitPrice"), xRow)
     If  getColumnIndex(spr,"cdUnitPrice") > -1 then z3209.cdUnitPrice = getDataM(spr, getColumnIndex(spr,"cdUnitPrice"), xRow)
     If  getColumnIndex(spr,"QtyComponent") > -1 then z3209.QtyComponent = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyComponent"), xRow))
     If  getColumnIndex(spr,"Consumption") > -1 then z3209.Consumption = Cdecp(getDataM(spr, getColumnIndex(spr,"Consumption"), xRow))
     If  getColumnIndex(spr,"Loss") > -1 then z3209.Loss = Cdecp(getDataM(spr, getColumnIndex(spr,"Loss"), xRow))
     If  getColumnIndex(spr,"GrossUsage") > -1 then z3209.GrossUsage = Cdecp(getDataM(spr, getColumnIndex(spr,"GrossUsage"), xRow))
     If  getColumnIndex(spr,"MaterialAMT") > -1 then z3209.MaterialAMT = Cdecp(getDataM(spr, getColumnIndex(spr,"MaterialAMT"), xRow))
     If  getColumnIndex(spr,"MaterialAMTPurchasing") > -1 then z3209.MaterialAMTPurchasing = Cdecp(getDataM(spr, getColumnIndex(spr,"MaterialAMTPurchasing"), xRow))
     If  getColumnIndex(spr,"MaterialAMTSales") > -1 then z3209.MaterialAMTSales = Cdecp(getDataM(spr, getColumnIndex(spr,"MaterialAMTSales"), xRow))
     If  getColumnIndex(spr,"seSubProcess") > -1 then z3209.seSubProcess = getDataM(spr, getColumnIndex(spr,"seSubProcess"), xRow)
     If  getColumnIndex(spr,"cdSubProcess") > -1 then z3209.cdSubProcess = getDataM(spr, getColumnIndex(spr,"cdSubProcess"), xRow)
     If  getColumnIndex(spr,"seSpecialProcess") > -1 then z3209.seSpecialProcess = getDataM(spr, getColumnIndex(spr,"seSpecialProcess"), xRow)
     If  getColumnIndex(spr,"cdSpecialProcess") > -1 then z3209.cdSpecialProcess = getDataM(spr, getColumnIndex(spr,"cdSpecialProcess"), xRow)
     If  getColumnIndex(spr,"CheckMark") > -1 then z3209.CheckMark = getDataM(spr, getColumnIndex(spr,"CheckMark"), xRow)
     If  getColumnIndex(spr,"CheckUse") > -1 then z3209.CheckUse = getDataM(spr, getColumnIndex(spr,"CheckUse"), xRow)
     If  getColumnIndex(spr,"CheckP1") > -1 then z3209.CheckP1 = getDataM(spr, getColumnIndex(spr,"CheckP1"), xRow)
     If  getColumnIndex(spr,"CheckP2") > -1 then z3209.CheckP2 = getDataM(spr, getColumnIndex(spr,"CheckP2"), xRow)
     If  getColumnIndex(spr,"CheckP3") > -1 then z3209.CheckP3 = getDataM(spr, getColumnIndex(spr,"CheckP3"), xRow)
     If  getColumnIndex(spr,"CheckP4") > -1 then z3209.CheckP4 = getDataM(spr, getColumnIndex(spr,"CheckP4"), xRow)
     If  getColumnIndex(spr,"CheckP5") > -1 then z3209.CheckP5 = getDataM(spr, getColumnIndex(spr,"CheckP5"), xRow)
     If  getColumnIndex(spr,"CheckP6") > -1 then z3209.CheckP6 = getDataM(spr, getColumnIndex(spr,"CheckP6"), xRow)
     If  getColumnIndex(spr,"CheckP7") > -1 then z3209.CheckP7 = getDataM(spr, getColumnIndex(spr,"CheckP7"), xRow)
     If  getColumnIndex(spr,"CheckP8") > -1 then z3209.CheckP8 = getDataM(spr, getColumnIndex(spr,"CheckP8"), xRow)
     If  getColumnIndex(spr,"CheckP9") > -1 then z3209.CheckP9 = getDataM(spr, getColumnIndex(spr,"CheckP9"), xRow)
     If  getColumnIndex(spr,"CheckUse1") > -1 then z3209.CheckUse1 = getDataM(spr, getColumnIndex(spr,"CheckUse1"), xRow)
     If  getColumnIndex(spr,"CheckMatching") > -1 then z3209.CheckMatching = getDataM(spr, getColumnIndex(spr,"CheckMatching"), xRow)
     If  getColumnIndex(spr,"Remark") > -1 then z3209.Remark = getDataM(spr, getColumnIndex(spr,"Remark"), xRow)
     If  getColumnIndex(spr,"MaterialCode_K3011") > -1 then z3209.MaterialCode_K3011 = getDataM(spr, getColumnIndex(spr,"MaterialCode_K3011"), xRow)
     If  getColumnIndex(spr,"seSite") > -1 then z3209.seSite = getDataM(spr, getColumnIndex(spr,"seSite"), xRow)
     If  getColumnIndex(spr,"cdSite") > -1 then z3209.cdSite = getDataM(spr, getColumnIndex(spr,"cdSite"), xRow)
     If  getColumnIndex(spr,"DateInsert") > -1 then z3209.DateInsert = getDataM(spr, getColumnIndex(spr,"DateInsert"), xRow)
     If  getColumnIndex(spr,"DateUpdate") > -1 then z3209.DateUpdate = getDataM(spr, getColumnIndex(spr,"DateUpdate"), xRow)
     If  getColumnIndex(spr,"InchargeInsert") > -1 then z3209.InchargeInsert = getDataM(spr, getColumnIndex(spr,"InchargeInsert"), xRow)
     If  getColumnIndex(spr,"InchargeUpdate") > -1 then z3209.InchargeUpdate = getDataM(spr, getColumnIndex(spr,"InchargeUpdate"), xRow)
     If  getColumnIndex(spr,"TimeInsert") > -1 then z3209.TimeInsert = getDataM(spr, getColumnIndex(spr,"TimeInsert"), xRow)
     If  getColumnIndex(spr,"TimeUpdate") > -1 then z3209.TimeUpdate = getDataM(spr, getColumnIndex(spr,"TimeUpdate"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3209_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K3209_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3209 As T3209_AREA,CheckClear as Boolean,GROUPCOMPONENTBOM AS String, GROUPCOMPONENTSEQ AS Double) as Boolean

K3209_MOVE = False

Try
    If READ_PFK3209(GROUPCOMPONENTBOM, GROUPCOMPONENTSEQ) = True Then
                z3209 = D3209
		K3209_MOVE = True
		else
	If CheckClear  = True then z3209 = nothing
     End If

     If  getColumnIndex(spr,"GroupComponentBOM") > -1 then z3209.GroupComponentBOM = getDataM(spr, getColumnIndex(spr,"GroupComponentBOM"), xRow)
     If  getColumnIndex(spr,"GroupComponentSeq") > -1 then z3209.GroupComponentSeq = Cdecp(getDataM(spr, getColumnIndex(spr,"GroupComponentSeq"), xRow))
     If  getColumnIndex(spr,"Dseq") > -1 then z3209.Dseq = Cdecp(getDataM(spr, getColumnIndex(spr,"Dseq"), xRow))
     If  getColumnIndex(spr,"ProcessSeq") > -1 then z3209.ProcessSeq = getDataM(spr, getColumnIndex(spr,"ProcessSeq"), xRow)
     If  getColumnIndex(spr,"CustomerCode") > -1 then z3209.CustomerCode = getDataM(spr, getColumnIndex(spr,"CustomerCode"), xRow)
     If  getColumnIndex(spr,"selGroupComponent") > -1 then z3209.selGroupComponent = getDataM(spr, getColumnIndex(spr,"selGroupComponent"), xRow)
     If  getColumnIndex(spr,"cdGroupComponent") > -1 then z3209.cdGroupComponent = getDataM(spr, getColumnIndex(spr,"cdGroupComponent"), xRow)
     If  getColumnIndex(spr,"ComponentName") > -1 then z3209.ComponentName = getDataM(spr, getColumnIndex(spr,"ComponentName"), xRow)
     If  getColumnIndex(spr,"MaterialCode") > -1 then z3209.MaterialCode = getDataM(spr, getColumnIndex(spr,"MaterialCode"), xRow)
     If  getColumnIndex(spr,"seUnitMaterial") > -1 then z3209.seUnitMaterial = getDataM(spr, getColumnIndex(spr,"seUnitMaterial"), xRow)
     If  getColumnIndex(spr,"cdUnitMaterial") > -1 then z3209.cdUnitMaterial = getDataM(spr, getColumnIndex(spr,"cdUnitMaterial"), xRow)
     If  getColumnIndex(spr,"Specification") > -1 then z3209.Specification = getDataM(spr, getColumnIndex(spr,"Specification"), xRow)
     If  getColumnIndex(spr,"Width") > -1 then z3209.Width = getDataM(spr, getColumnIndex(spr,"Width"), xRow)
     If  getColumnIndex(spr,"WidthID") > -1 then z3209.WidthID = getDataM(spr, getColumnIndex(spr,"WidthID"), xRow)
     If  getColumnIndex(spr,"Height") > -1 then z3209.Height = getDataM(spr, getColumnIndex(spr,"Height"), xRow)
     If  getColumnIndex(spr,"SizeName") > -1 then z3209.SizeName = getDataM(spr, getColumnIndex(spr,"SizeName"), xRow)
     If  getColumnIndex(spr,"cdColorCode") > -1 then z3209.cdColorCode = getDataM(spr, getColumnIndex(spr,"cdColorCode"), xRow)
     If  getColumnIndex(spr,"ColorCode") > -1 then z3209.ColorCode = getDataM(spr, getColumnIndex(spr,"ColorCode"), xRow)
     If  getColumnIndex(spr,"ColorName") > -1 then z3209.ColorName = getDataM(spr, getColumnIndex(spr,"ColorName"), xRow)
     If  getColumnIndex(spr,"seShoesStatus") > -1 then z3209.seShoesStatus = getDataM(spr, getColumnIndex(spr,"seShoesStatus"), xRow)
     If  getColumnIndex(spr,"cdShoesStatus") > -1 then z3209.cdShoesStatus = getDataM(spr, getColumnIndex(spr,"cdShoesStatus"), xRow)
     If  getColumnIndex(spr,"seDepartment") > -1 then z3209.seDepartment = getDataM(spr, getColumnIndex(spr,"seDepartment"), xRow)
     If  getColumnIndex(spr,"cdDepartment") > -1 then z3209.cdDepartment = getDataM(spr, getColumnIndex(spr,"cdDepartment"), xRow)
     If  getColumnIndex(spr,"ContractID") > -1 then z3209.ContractID = getDataM(spr, getColumnIndex(spr,"ContractID"), xRow)
     If  getColumnIndex(spr,"ContracSeq") > -1 then z3209.ContracSeq = Cdecp(getDataM(spr, getColumnIndex(spr,"ContracSeq"), xRow))
     If  getColumnIndex(spr,"SupplierCode") > -1 then z3209.SupplierCode = getDataM(spr, getColumnIndex(spr,"SupplierCode"), xRow)
     If  getColumnIndex(spr,"PriceMaterial") > -1 then z3209.PriceMaterial = Cdecp(getDataM(spr, getColumnIndex(spr,"PriceMaterial"), xRow))
     If  getColumnIndex(spr,"ExchangeCost") > -1 then z3209.ExchangeCost = Cdecp(getDataM(spr, getColumnIndex(spr,"ExchangeCost"), xRow))
     If  getColumnIndex(spr,"ComplicationCost") > -1 then z3209.ComplicationCost = Cdecp(getDataM(spr, getColumnIndex(spr,"ComplicationCost"), xRow))
     If  getColumnIndex(spr,"AddedCost") > -1 then z3209.AddedCost = Cdecp(getDataM(spr, getColumnIndex(spr,"AddedCost"), xRow))
     If  getColumnIndex(spr,"ShippingRate") > -1 then z3209.ShippingRate = Cdecp(getDataM(spr, getColumnIndex(spr,"ShippingRate"), xRow))
     If  getColumnIndex(spr,"ShippingCost") > -1 then z3209.ShippingCost = Cdecp(getDataM(spr, getColumnIndex(spr,"ShippingCost"), xRow))
     If  getColumnIndex(spr,"PriceRnD") > -1 then z3209.PriceRnD = Cdecp(getDataM(spr, getColumnIndex(spr,"PriceRnD"), xRow))
     If  getColumnIndex(spr,"Price") > -1 then z3209.Price = Cdecp(getDataM(spr, getColumnIndex(spr,"Price"), xRow))
     If  getColumnIndex(spr,"seUnitPrice") > -1 then z3209.seUnitPrice = getDataM(spr, getColumnIndex(spr,"seUnitPrice"), xRow)
     If  getColumnIndex(spr,"cdUnitPrice") > -1 then z3209.cdUnitPrice = getDataM(spr, getColumnIndex(spr,"cdUnitPrice"), xRow)
     If  getColumnIndex(spr,"QtyComponent") > -1 then z3209.QtyComponent = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyComponent"), xRow))
     If  getColumnIndex(spr,"Consumption") > -1 then z3209.Consumption = Cdecp(getDataM(spr, getColumnIndex(spr,"Consumption"), xRow))
     If  getColumnIndex(spr,"Loss") > -1 then z3209.Loss = Cdecp(getDataM(spr, getColumnIndex(spr,"Loss"), xRow))
     If  getColumnIndex(spr,"GrossUsage") > -1 then z3209.GrossUsage = Cdecp(getDataM(spr, getColumnIndex(spr,"GrossUsage"), xRow))
     If  getColumnIndex(spr,"MaterialAMT") > -1 then z3209.MaterialAMT = Cdecp(getDataM(spr, getColumnIndex(spr,"MaterialAMT"), xRow))
     If  getColumnIndex(spr,"MaterialAMTPurchasing") > -1 then z3209.MaterialAMTPurchasing = Cdecp(getDataM(spr, getColumnIndex(spr,"MaterialAMTPurchasing"), xRow))
     If  getColumnIndex(spr,"MaterialAMTSales") > -1 then z3209.MaterialAMTSales = Cdecp(getDataM(spr, getColumnIndex(spr,"MaterialAMTSales"), xRow))
     If  getColumnIndex(spr,"seSubProcess") > -1 then z3209.seSubProcess = getDataM(spr, getColumnIndex(spr,"seSubProcess"), xRow)
     If  getColumnIndex(spr,"cdSubProcess") > -1 then z3209.cdSubProcess = getDataM(spr, getColumnIndex(spr,"cdSubProcess"), xRow)
     If  getColumnIndex(spr,"seSpecialProcess") > -1 then z3209.seSpecialProcess = getDataM(spr, getColumnIndex(spr,"seSpecialProcess"), xRow)
     If  getColumnIndex(spr,"cdSpecialProcess") > -1 then z3209.cdSpecialProcess = getDataM(spr, getColumnIndex(spr,"cdSpecialProcess"), xRow)
     If  getColumnIndex(spr,"CheckMark") > -1 then z3209.CheckMark = getDataM(spr, getColumnIndex(spr,"CheckMark"), xRow)
     If  getColumnIndex(spr,"CheckUse") > -1 then z3209.CheckUse = getDataM(spr, getColumnIndex(spr,"CheckUse"), xRow)
     If  getColumnIndex(spr,"CheckP1") > -1 then z3209.CheckP1 = getDataM(spr, getColumnIndex(spr,"CheckP1"), xRow)
     If  getColumnIndex(spr,"CheckP2") > -1 then z3209.CheckP2 = getDataM(spr, getColumnIndex(spr,"CheckP2"), xRow)
     If  getColumnIndex(spr,"CheckP3") > -1 then z3209.CheckP3 = getDataM(spr, getColumnIndex(spr,"CheckP3"), xRow)
     If  getColumnIndex(spr,"CheckP4") > -1 then z3209.CheckP4 = getDataM(spr, getColumnIndex(spr,"CheckP4"), xRow)
     If  getColumnIndex(spr,"CheckP5") > -1 then z3209.CheckP5 = getDataM(spr, getColumnIndex(spr,"CheckP5"), xRow)
     If  getColumnIndex(spr,"CheckP6") > -1 then z3209.CheckP6 = getDataM(spr, getColumnIndex(spr,"CheckP6"), xRow)
     If  getColumnIndex(spr,"CheckP7") > -1 then z3209.CheckP7 = getDataM(spr, getColumnIndex(spr,"CheckP7"), xRow)
     If  getColumnIndex(spr,"CheckP8") > -1 then z3209.CheckP8 = getDataM(spr, getColumnIndex(spr,"CheckP8"), xRow)
     If  getColumnIndex(spr,"CheckP9") > -1 then z3209.CheckP9 = getDataM(spr, getColumnIndex(spr,"CheckP9"), xRow)
     If  getColumnIndex(spr,"CheckUse1") > -1 then z3209.CheckUse1 = getDataM(spr, getColumnIndex(spr,"CheckUse1"), xRow)
     If  getColumnIndex(spr,"CheckMatching") > -1 then z3209.CheckMatching = getDataM(spr, getColumnIndex(spr,"CheckMatching"), xRow)
     If  getColumnIndex(spr,"Remark") > -1 then z3209.Remark = getDataM(spr, getColumnIndex(spr,"Remark"), xRow)
     If  getColumnIndex(spr,"MaterialCode_K3011") > -1 then z3209.MaterialCode_K3011 = getDataM(spr, getColumnIndex(spr,"MaterialCode_K3011"), xRow)
     If  getColumnIndex(spr,"seSite") > -1 then z3209.seSite = getDataM(spr, getColumnIndex(spr,"seSite"), xRow)
     If  getColumnIndex(spr,"cdSite") > -1 then z3209.cdSite = getDataM(spr, getColumnIndex(spr,"cdSite"), xRow)
     If  getColumnIndex(spr,"DateInsert") > -1 then z3209.DateInsert = getDataM(spr, getColumnIndex(spr,"DateInsert"), xRow)
     If  getColumnIndex(spr,"DateUpdate") > -1 then z3209.DateUpdate = getDataM(spr, getColumnIndex(spr,"DateUpdate"), xRow)
     If  getColumnIndex(spr,"InchargeInsert") > -1 then z3209.InchargeInsert = getDataM(spr, getColumnIndex(spr,"InchargeInsert"), xRow)
     If  getColumnIndex(spr,"InchargeUpdate") > -1 then z3209.InchargeUpdate = getDataM(spr, getColumnIndex(spr,"InchargeUpdate"), xRow)
     If  getColumnIndex(spr,"TimeInsert") > -1 then z3209.TimeInsert = getDataM(spr, getColumnIndex(spr,"TimeInsert"), xRow)
     If  getColumnIndex(spr,"TimeUpdate") > -1 then z3209.TimeUpdate = getDataM(spr, getColumnIndex(spr,"TimeUpdate"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3209_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K3209_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3209 As T3209_AREA, Job as String, GROUPCOMPONENTBOM AS String, GROUPCOMPONENTSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3209_MOVE = False

Try
    If READ_PFK3209(GROUPCOMPONENTBOM, GROUPCOMPONENTSEQ) = True Then
                z3209 = D3209
		K3209_MOVE = True
		else
	z3209 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3209")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "GROUPCOMPONENTBOM":z3209.GroupComponentBOM = Children(i).Code
   Case "GROUPCOMPONENTSEQ":z3209.GroupComponentSeq = Children(i).Code
   Case "DSEQ":z3209.Dseq = Children(i).Code
   Case "PROCESSSEQ":z3209.ProcessSeq = Children(i).Code
   Case "CUSTOMERCODE":z3209.CustomerCode = Children(i).Code
   Case "SELGROUPCOMPONENT":z3209.selGroupComponent = Children(i).Code
   Case "CDGROUPCOMPONENT":z3209.cdGroupComponent = Children(i).Code
   Case "COMPONENTNAME":z3209.ComponentName = Children(i).Code
   Case "MATERIALCODE":z3209.MaterialCode = Children(i).Code
   Case "SEUNITMATERIAL":z3209.seUnitMaterial = Children(i).Code
   Case "CDUNITMATERIAL":z3209.cdUnitMaterial = Children(i).Code
   Case "SPECIFICATION":z3209.Specification = Children(i).Code
   Case "WIDTH":z3209.Width = Children(i).Code
   Case "WIDTHID":z3209.WidthID = Children(i).Code
   Case "HEIGHT":z3209.Height = Children(i).Code
   Case "SIZENAME":z3209.SizeName = Children(i).Code
   Case "CDCOLORCODE":z3209.cdColorCode = Children(i).Code
   Case "COLORCODE":z3209.ColorCode = Children(i).Code
   Case "COLORNAME":z3209.ColorName = Children(i).Code
   Case "SESHOESSTATUS":z3209.seShoesStatus = Children(i).Code
   Case "CDSHOESSTATUS":z3209.cdShoesStatus = Children(i).Code
   Case "SEDEPARTMENT":z3209.seDepartment = Children(i).Code
   Case "CDDEPARTMENT":z3209.cdDepartment = Children(i).Code
   Case "CONTRACTID":z3209.ContractID = Children(i).Code
   Case "CONTRACSEQ":z3209.ContracSeq = Children(i).Code
   Case "SUPPLIERCODE":z3209.SupplierCode = Children(i).Code
   Case "PRICEMATERIAL":z3209.PriceMaterial = Children(i).Code
   Case "EXCHANGECOST":z3209.ExchangeCost = Children(i).Code
   Case "COMPLICATIONCOST":z3209.ComplicationCost = Children(i).Code
   Case "ADDEDCOST":z3209.AddedCost = Children(i).Code
   Case "SHIPPINGRATE":z3209.ShippingRate = Children(i).Code
   Case "SHIPPINGCOST":z3209.ShippingCost = Children(i).Code
   Case "PRICERND":z3209.PriceRnD = Children(i).Code
   Case "PRICE":z3209.Price = Children(i).Code
   Case "SEUNITPRICE":z3209.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z3209.cdUnitPrice = Children(i).Code
   Case "QTYCOMPONENT":z3209.QtyComponent = Children(i).Code
   Case "CONSUMPTION":z3209.Consumption = Children(i).Code
   Case "LOSS":z3209.Loss = Children(i).Code
   Case "GROSSUSAGE":z3209.GrossUsage = Children(i).Code
   Case "MATERIALAMT":z3209.MaterialAMT = Children(i).Code
   Case "MATERIALAMTPURCHASING":z3209.MaterialAMTPurchasing = Children(i).Code
   Case "MATERIALAMTSALES":z3209.MaterialAMTSales = Children(i).Code
   Case "SESUBPROCESS":z3209.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z3209.cdSubProcess = Children(i).Code
   Case "SESPECIALPROCESS":z3209.seSpecialProcess = Children(i).Code
   Case "CDSPECIALPROCESS":z3209.cdSpecialProcess = Children(i).Code
   Case "CHECKMARK":z3209.CheckMark = Children(i).Code
   Case "CHECKUSE":z3209.CheckUse = Children(i).Code
   Case "CHECKP1":z3209.CheckP1 = Children(i).Code
   Case "CHECKP2":z3209.CheckP2 = Children(i).Code
   Case "CHECKP3":z3209.CheckP3 = Children(i).Code
   Case "CHECKP4":z3209.CheckP4 = Children(i).Code
   Case "CHECKP5":z3209.CheckP5 = Children(i).Code
   Case "CHECKP6":z3209.CheckP6 = Children(i).Code
   Case "CHECKP7":z3209.CheckP7 = Children(i).Code
   Case "CHECKP8":z3209.CheckP8 = Children(i).Code
   Case "CHECKP9":z3209.CheckP9 = Children(i).Code
   Case "CHECKUSE1":z3209.CheckUse1 = Children(i).Code
   Case "CHECKMATCHING":z3209.CheckMatching = Children(i).Code
   Case "REMARK":z3209.Remark = Children(i).Code
   Case "MATERIALCODE_K3011":z3209.MaterialCode_K3011 = Children(i).Code
   Case "SESITE":z3209.seSite = Children(i).Code
   Case "CDSITE":z3209.cdSite = Children(i).Code
   Case "DATEINSERT":z3209.DateInsert = Children(i).Code
   Case "DATEUPDATE":z3209.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z3209.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z3209.InchargeUpdate = Children(i).Code
   Case "TIMEINSERT":z3209.TimeInsert = Children(i).Code
   Case "TIMEUPDATE":z3209.TimeUpdate = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "GROUPCOMPONENTBOM":z3209.GroupComponentBOM = Children(i).Data
   Case "GROUPCOMPONENTSEQ":z3209.GroupComponentSeq = Cdecp(Children(i).Data)
   Case "DSEQ":z3209.Dseq = Cdecp(Children(i).Data)
   Case "PROCESSSEQ":z3209.ProcessSeq = Children(i).Data
   Case "CUSTOMERCODE":z3209.CustomerCode = Children(i).Data
   Case "SELGROUPCOMPONENT":z3209.selGroupComponent = Children(i).Data
   Case "CDGROUPCOMPONENT":z3209.cdGroupComponent = Children(i).Data
   Case "COMPONENTNAME":z3209.ComponentName = Children(i).Data
   Case "MATERIALCODE":z3209.MaterialCode = Children(i).Data
   Case "SEUNITMATERIAL":z3209.seUnitMaterial = Children(i).Data
   Case "CDUNITMATERIAL":z3209.cdUnitMaterial = Children(i).Data
   Case "SPECIFICATION":z3209.Specification = Children(i).Data
   Case "WIDTH":z3209.Width = Children(i).Data
   Case "WIDTHID":z3209.WidthID = Children(i).Data
   Case "HEIGHT":z3209.Height = Children(i).Data
   Case "SIZENAME":z3209.SizeName = Children(i).Data
   Case "CDCOLORCODE":z3209.cdColorCode = Children(i).Data
   Case "COLORCODE":z3209.ColorCode = Children(i).Data
   Case "COLORNAME":z3209.ColorName = Children(i).Data
   Case "SESHOESSTATUS":z3209.seShoesStatus = Children(i).Data
   Case "CDSHOESSTATUS":z3209.cdShoesStatus = Children(i).Data
   Case "SEDEPARTMENT":z3209.seDepartment = Children(i).Data
   Case "CDDEPARTMENT":z3209.cdDepartment = Children(i).Data
   Case "CONTRACTID":z3209.ContractID = Children(i).Data
   Case "CONTRACSEQ":z3209.ContracSeq = Cdecp(Children(i).Data)
   Case "SUPPLIERCODE":z3209.SupplierCode = Children(i).Data
   Case "PRICEMATERIAL":z3209.PriceMaterial = Cdecp(Children(i).Data)
   Case "EXCHANGECOST":z3209.ExchangeCost = Cdecp(Children(i).Data)
   Case "COMPLICATIONCOST":z3209.ComplicationCost = Cdecp(Children(i).Data)
   Case "ADDEDCOST":z3209.AddedCost = Cdecp(Children(i).Data)
   Case "SHIPPINGRATE":z3209.ShippingRate = Cdecp(Children(i).Data)
   Case "SHIPPINGCOST":z3209.ShippingCost = Cdecp(Children(i).Data)
   Case "PRICERND":z3209.PriceRnD = Cdecp(Children(i).Data)
   Case "PRICE":z3209.Price = Cdecp(Children(i).Data)
   Case "SEUNITPRICE":z3209.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z3209.cdUnitPrice = Children(i).Data
   Case "QTYCOMPONENT":z3209.QtyComponent = Cdecp(Children(i).Data)
   Case "CONSUMPTION":z3209.Consumption = Cdecp(Children(i).Data)
   Case "LOSS":z3209.Loss = Cdecp(Children(i).Data)
   Case "GROSSUSAGE":z3209.GrossUsage = Cdecp(Children(i).Data)
   Case "MATERIALAMT":z3209.MaterialAMT = Cdecp(Children(i).Data)
   Case "MATERIALAMTPURCHASING":z3209.MaterialAMTPurchasing = Cdecp(Children(i).Data)
   Case "MATERIALAMTSALES":z3209.MaterialAMTSales = Cdecp(Children(i).Data)
   Case "SESUBPROCESS":z3209.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z3209.cdSubProcess = Children(i).Data
   Case "SESPECIALPROCESS":z3209.seSpecialProcess = Children(i).Data
   Case "CDSPECIALPROCESS":z3209.cdSpecialProcess = Children(i).Data
   Case "CHECKMARK":z3209.CheckMark = Children(i).Data
   Case "CHECKUSE":z3209.CheckUse = Children(i).Data
   Case "CHECKP1":z3209.CheckP1 = Children(i).Data
   Case "CHECKP2":z3209.CheckP2 = Children(i).Data
   Case "CHECKP3":z3209.CheckP3 = Children(i).Data
   Case "CHECKP4":z3209.CheckP4 = Children(i).Data
   Case "CHECKP5":z3209.CheckP5 = Children(i).Data
   Case "CHECKP6":z3209.CheckP6 = Children(i).Data
   Case "CHECKP7":z3209.CheckP7 = Children(i).Data
   Case "CHECKP8":z3209.CheckP8 = Children(i).Data
   Case "CHECKP9":z3209.CheckP9 = Children(i).Data
   Case "CHECKUSE1":z3209.CheckUse1 = Children(i).Data
   Case "CHECKMATCHING":z3209.CheckMatching = Children(i).Data
   Case "REMARK":z3209.Remark = Children(i).Data
   Case "MATERIALCODE_K3011":z3209.MaterialCode_K3011 = Children(i).Data
   Case "SESITE":z3209.seSite = Children(i).Data
   Case "CDSITE":z3209.cdSite = Children(i).Data
   Case "DATEINSERT":z3209.DateInsert = Children(i).Data
   Case "DATEUPDATE":z3209.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z3209.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z3209.InchargeUpdate = Children(i).Data
   Case "TIMEINSERT":z3209.TimeInsert = Children(i).Data
   Case "TIMEUPDATE":z3209.TimeUpdate = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3209_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K3209_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3209 As T3209_AREA, Job as String, CheckClear as Boolean, GROUPCOMPONENTBOM AS String, GROUPCOMPONENTSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3209_MOVE = False

Try
    If READ_PFK3209(GROUPCOMPONENTBOM, GROUPCOMPONENTSEQ) = True Then
                z3209 = D3209
		K3209_MOVE = True
		else
	If CheckClear  = True then z3209 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3209")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "GROUPCOMPONENTBOM":z3209.GroupComponentBOM = Children(i).Code
   Case "GROUPCOMPONENTSEQ":z3209.GroupComponentSeq = Children(i).Code
   Case "DSEQ":z3209.Dseq = Children(i).Code
   Case "PROCESSSEQ":z3209.ProcessSeq = Children(i).Code
   Case "CUSTOMERCODE":z3209.CustomerCode = Children(i).Code
   Case "SELGROUPCOMPONENT":z3209.selGroupComponent = Children(i).Code
   Case "CDGROUPCOMPONENT":z3209.cdGroupComponent = Children(i).Code
   Case "COMPONENTNAME":z3209.ComponentName = Children(i).Code
   Case "MATERIALCODE":z3209.MaterialCode = Children(i).Code
   Case "SEUNITMATERIAL":z3209.seUnitMaterial = Children(i).Code
   Case "CDUNITMATERIAL":z3209.cdUnitMaterial = Children(i).Code
   Case "SPECIFICATION":z3209.Specification = Children(i).Code
   Case "WIDTH":z3209.Width = Children(i).Code
   Case "WIDTHID":z3209.WidthID = Children(i).Code
   Case "HEIGHT":z3209.Height = Children(i).Code
   Case "SIZENAME":z3209.SizeName = Children(i).Code
   Case "CDCOLORCODE":z3209.cdColorCode = Children(i).Code
   Case "COLORCODE":z3209.ColorCode = Children(i).Code
   Case "COLORNAME":z3209.ColorName = Children(i).Code
   Case "SESHOESSTATUS":z3209.seShoesStatus = Children(i).Code
   Case "CDSHOESSTATUS":z3209.cdShoesStatus = Children(i).Code
   Case "SEDEPARTMENT":z3209.seDepartment = Children(i).Code
   Case "CDDEPARTMENT":z3209.cdDepartment = Children(i).Code
   Case "CONTRACTID":z3209.ContractID = Children(i).Code
   Case "CONTRACSEQ":z3209.ContracSeq = Children(i).Code
   Case "SUPPLIERCODE":z3209.SupplierCode = Children(i).Code
   Case "PRICEMATERIAL":z3209.PriceMaterial = Children(i).Code
   Case "EXCHANGECOST":z3209.ExchangeCost = Children(i).Code
   Case "COMPLICATIONCOST":z3209.ComplicationCost = Children(i).Code
   Case "ADDEDCOST":z3209.AddedCost = Children(i).Code
   Case "SHIPPINGRATE":z3209.ShippingRate = Children(i).Code
   Case "SHIPPINGCOST":z3209.ShippingCost = Children(i).Code
   Case "PRICERND":z3209.PriceRnD = Children(i).Code
   Case "PRICE":z3209.Price = Children(i).Code
   Case "SEUNITPRICE":z3209.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z3209.cdUnitPrice = Children(i).Code
   Case "QTYCOMPONENT":z3209.QtyComponent = Children(i).Code
   Case "CONSUMPTION":z3209.Consumption = Children(i).Code
   Case "LOSS":z3209.Loss = Children(i).Code
   Case "GROSSUSAGE":z3209.GrossUsage = Children(i).Code
   Case "MATERIALAMT":z3209.MaterialAMT = Children(i).Code
   Case "MATERIALAMTPURCHASING":z3209.MaterialAMTPurchasing = Children(i).Code
   Case "MATERIALAMTSALES":z3209.MaterialAMTSales = Children(i).Code
   Case "SESUBPROCESS":z3209.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z3209.cdSubProcess = Children(i).Code
   Case "SESPECIALPROCESS":z3209.seSpecialProcess = Children(i).Code
   Case "CDSPECIALPROCESS":z3209.cdSpecialProcess = Children(i).Code
   Case "CHECKMARK":z3209.CheckMark = Children(i).Code
   Case "CHECKUSE":z3209.CheckUse = Children(i).Code
   Case "CHECKP1":z3209.CheckP1 = Children(i).Code
   Case "CHECKP2":z3209.CheckP2 = Children(i).Code
   Case "CHECKP3":z3209.CheckP3 = Children(i).Code
   Case "CHECKP4":z3209.CheckP4 = Children(i).Code
   Case "CHECKP5":z3209.CheckP5 = Children(i).Code
   Case "CHECKP6":z3209.CheckP6 = Children(i).Code
   Case "CHECKP7":z3209.CheckP7 = Children(i).Code
   Case "CHECKP8":z3209.CheckP8 = Children(i).Code
   Case "CHECKP9":z3209.CheckP9 = Children(i).Code
   Case "CHECKUSE1":z3209.CheckUse1 = Children(i).Code
   Case "CHECKMATCHING":z3209.CheckMatching = Children(i).Code
   Case "REMARK":z3209.Remark = Children(i).Code
   Case "MATERIALCODE_K3011":z3209.MaterialCode_K3011 = Children(i).Code
   Case "SESITE":z3209.seSite = Children(i).Code
   Case "CDSITE":z3209.cdSite = Children(i).Code
   Case "DATEINSERT":z3209.DateInsert = Children(i).Code
   Case "DATEUPDATE":z3209.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z3209.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z3209.InchargeUpdate = Children(i).Code
   Case "TIMEINSERT":z3209.TimeInsert = Children(i).Code
   Case "TIMEUPDATE":z3209.TimeUpdate = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "GROUPCOMPONENTBOM":z3209.GroupComponentBOM = Children(i).Data
   Case "GROUPCOMPONENTSEQ":z3209.GroupComponentSeq = Cdecp(Children(i).Data)
   Case "DSEQ":z3209.Dseq = Cdecp(Children(i).Data)
   Case "PROCESSSEQ":z3209.ProcessSeq = Children(i).Data
   Case "CUSTOMERCODE":z3209.CustomerCode = Children(i).Data
   Case "SELGROUPCOMPONENT":z3209.selGroupComponent = Children(i).Data
   Case "CDGROUPCOMPONENT":z3209.cdGroupComponent = Children(i).Data
   Case "COMPONENTNAME":z3209.ComponentName = Children(i).Data
   Case "MATERIALCODE":z3209.MaterialCode = Children(i).Data
   Case "SEUNITMATERIAL":z3209.seUnitMaterial = Children(i).Data
   Case "CDUNITMATERIAL":z3209.cdUnitMaterial = Children(i).Data
   Case "SPECIFICATION":z3209.Specification = Children(i).Data
   Case "WIDTH":z3209.Width = Children(i).Data
   Case "WIDTHID":z3209.WidthID = Children(i).Data
   Case "HEIGHT":z3209.Height = Children(i).Data
   Case "SIZENAME":z3209.SizeName = Children(i).Data
   Case "CDCOLORCODE":z3209.cdColorCode = Children(i).Data
   Case "COLORCODE":z3209.ColorCode = Children(i).Data
   Case "COLORNAME":z3209.ColorName = Children(i).Data
   Case "SESHOESSTATUS":z3209.seShoesStatus = Children(i).Data
   Case "CDSHOESSTATUS":z3209.cdShoesStatus = Children(i).Data
   Case "SEDEPARTMENT":z3209.seDepartment = Children(i).Data
   Case "CDDEPARTMENT":z3209.cdDepartment = Children(i).Data
   Case "CONTRACTID":z3209.ContractID = Children(i).Data
   Case "CONTRACSEQ":z3209.ContracSeq = Cdecp(Children(i).Data)
   Case "SUPPLIERCODE":z3209.SupplierCode = Children(i).Data
   Case "PRICEMATERIAL":z3209.PriceMaterial = Cdecp(Children(i).Data)
   Case "EXCHANGECOST":z3209.ExchangeCost = Cdecp(Children(i).Data)
   Case "COMPLICATIONCOST":z3209.ComplicationCost = Cdecp(Children(i).Data)
   Case "ADDEDCOST":z3209.AddedCost = Cdecp(Children(i).Data)
   Case "SHIPPINGRATE":z3209.ShippingRate = Cdecp(Children(i).Data)
   Case "SHIPPINGCOST":z3209.ShippingCost = Cdecp(Children(i).Data)
   Case "PRICERND":z3209.PriceRnD = Cdecp(Children(i).Data)
   Case "PRICE":z3209.Price = Cdecp(Children(i).Data)
   Case "SEUNITPRICE":z3209.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z3209.cdUnitPrice = Children(i).Data
   Case "QTYCOMPONENT":z3209.QtyComponent = Cdecp(Children(i).Data)
   Case "CONSUMPTION":z3209.Consumption = Cdecp(Children(i).Data)
   Case "LOSS":z3209.Loss = Cdecp(Children(i).Data)
   Case "GROSSUSAGE":z3209.GrossUsage = Cdecp(Children(i).Data)
   Case "MATERIALAMT":z3209.MaterialAMT = Cdecp(Children(i).Data)
   Case "MATERIALAMTPURCHASING":z3209.MaterialAMTPurchasing = Cdecp(Children(i).Data)
   Case "MATERIALAMTSALES":z3209.MaterialAMTSales = Cdecp(Children(i).Data)
   Case "SESUBPROCESS":z3209.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z3209.cdSubProcess = Children(i).Data
   Case "SESPECIALPROCESS":z3209.seSpecialProcess = Children(i).Data
   Case "CDSPECIALPROCESS":z3209.cdSpecialProcess = Children(i).Data
   Case "CHECKMARK":z3209.CheckMark = Children(i).Data
   Case "CHECKUSE":z3209.CheckUse = Children(i).Data
   Case "CHECKP1":z3209.CheckP1 = Children(i).Data
   Case "CHECKP2":z3209.CheckP2 = Children(i).Data
   Case "CHECKP3":z3209.CheckP3 = Children(i).Data
   Case "CHECKP4":z3209.CheckP4 = Children(i).Data
   Case "CHECKP5":z3209.CheckP5 = Children(i).Data
   Case "CHECKP6":z3209.CheckP6 = Children(i).Data
   Case "CHECKP7":z3209.CheckP7 = Children(i).Data
   Case "CHECKP8":z3209.CheckP8 = Children(i).Data
   Case "CHECKP9":z3209.CheckP9 = Children(i).Data
   Case "CHECKUSE1":z3209.CheckUse1 = Children(i).Data
   Case "CHECKMATCHING":z3209.CheckMatching = Children(i).Data
   Case "REMARK":z3209.Remark = Children(i).Data
   Case "MATERIALCODE_K3011":z3209.MaterialCode_K3011 = Children(i).Data
   Case "SESITE":z3209.seSite = Children(i).Data
   Case "CDSITE":z3209.cdSite = Children(i).Data
   Case "DATEINSERT":z3209.DateInsert = Children(i).Data
   Case "DATEUPDATE":z3209.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z3209.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z3209.InchargeUpdate = Children(i).Data
   Case "TIMEINSERT":z3209.TimeInsert = Children(i).Data
   Case "TIMEUPDATE":z3209.TimeUpdate = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3209_MOVE",vbCritical)
End Try
End Function 
    

'=========================================================================================================================================================
' DATA MOVE FORM NEW AREA
'=========================================================================================================================================================
Public Sub K3209_MOVE(ByRef a3209 As T3209_AREA, ByRef b3209 As T3209_AREA) 
Try
If trim$( a3209.GroupComponentBOM ) = "" Then b3209.GroupComponentBOM = ""  Else b3209.GroupComponentBOM=a3209.GroupComponentBOM
If trim$( a3209.GroupComponentSeq ) = "" Then b3209.GroupComponentSeq = ""  Else b3209.GroupComponentSeq=a3209.GroupComponentSeq
If trim$( a3209.Dseq ) = "" Then b3209.Dseq = ""  Else b3209.Dseq=a3209.Dseq
If trim$( a3209.ProcessSeq ) = "" Then b3209.ProcessSeq = ""  Else b3209.ProcessSeq=a3209.ProcessSeq
If trim$( a3209.CustomerCode ) = "" Then b3209.CustomerCode = ""  Else b3209.CustomerCode=a3209.CustomerCode
If trim$( a3209.selGroupComponent ) = "" Then b3209.selGroupComponent = ""  Else b3209.selGroupComponent=a3209.selGroupComponent
If trim$( a3209.cdGroupComponent ) = "" Then b3209.cdGroupComponent = ""  Else b3209.cdGroupComponent=a3209.cdGroupComponent
If trim$( a3209.ComponentName ) = "" Then b3209.ComponentName = ""  Else b3209.ComponentName=a3209.ComponentName
If trim$( a3209.MaterialCode ) = "" Then b3209.MaterialCode = ""  Else b3209.MaterialCode=a3209.MaterialCode
If trim$( a3209.seUnitMaterial ) = "" Then b3209.seUnitMaterial = ""  Else b3209.seUnitMaterial=a3209.seUnitMaterial
If trim$( a3209.cdUnitMaterial ) = "" Then b3209.cdUnitMaterial = ""  Else b3209.cdUnitMaterial=a3209.cdUnitMaterial
If trim$( a3209.Specification ) = "" Then b3209.Specification = ""  Else b3209.Specification=a3209.Specification
If trim$( a3209.Width ) = "" Then b3209.Width = ""  Else b3209.Width=a3209.Width
If trim$( a3209.WidthID ) = "" Then b3209.WidthID = ""  Else b3209.WidthID=a3209.WidthID
If trim$( a3209.Height ) = "" Then b3209.Height = ""  Else b3209.Height=a3209.Height
If trim$( a3209.SizeName ) = "" Then b3209.SizeName = ""  Else b3209.SizeName=a3209.SizeName
If trim$( a3209.cdColorCode ) = "" Then b3209.cdColorCode = ""  Else b3209.cdColorCode=a3209.cdColorCode
If trim$( a3209.ColorCode ) = "" Then b3209.ColorCode = ""  Else b3209.ColorCode=a3209.ColorCode
If trim$( a3209.ColorName ) = "" Then b3209.ColorName = ""  Else b3209.ColorName=a3209.ColorName
If trim$( a3209.seShoesStatus ) = "" Then b3209.seShoesStatus = ""  Else b3209.seShoesStatus=a3209.seShoesStatus
If trim$( a3209.cdShoesStatus ) = "" Then b3209.cdShoesStatus = ""  Else b3209.cdShoesStatus=a3209.cdShoesStatus
If trim$( a3209.seDepartment ) = "" Then b3209.seDepartment = ""  Else b3209.seDepartment=a3209.seDepartment
If trim$( a3209.cdDepartment ) = "" Then b3209.cdDepartment = ""  Else b3209.cdDepartment=a3209.cdDepartment
If trim$( a3209.ContractID ) = "" Then b3209.ContractID = ""  Else b3209.ContractID=a3209.ContractID
If trim$( a3209.ContracSeq ) = "" Then b3209.ContracSeq = ""  Else b3209.ContracSeq=a3209.ContracSeq
If trim$( a3209.SupplierCode ) = "" Then b3209.SupplierCode = ""  Else b3209.SupplierCode=a3209.SupplierCode
If trim$( a3209.PriceMaterial ) = "" Then b3209.PriceMaterial = ""  Else b3209.PriceMaterial=a3209.PriceMaterial
If trim$( a3209.ExchangeCost ) = "" Then b3209.ExchangeCost = ""  Else b3209.ExchangeCost=a3209.ExchangeCost
If trim$( a3209.ComplicationCost ) = "" Then b3209.ComplicationCost = ""  Else b3209.ComplicationCost=a3209.ComplicationCost
If trim$( a3209.AddedCost ) = "" Then b3209.AddedCost = ""  Else b3209.AddedCost=a3209.AddedCost
If trim$( a3209.ShippingRate ) = "" Then b3209.ShippingRate = ""  Else b3209.ShippingRate=a3209.ShippingRate
If trim$( a3209.ShippingCost ) = "" Then b3209.ShippingCost = ""  Else b3209.ShippingCost=a3209.ShippingCost
If trim$( a3209.PriceRnD ) = "" Then b3209.PriceRnD = ""  Else b3209.PriceRnD=a3209.PriceRnD
If trim$( a3209.Price ) = "" Then b3209.Price = ""  Else b3209.Price=a3209.Price
If trim$( a3209.seUnitPrice ) = "" Then b3209.seUnitPrice = ""  Else b3209.seUnitPrice=a3209.seUnitPrice
If trim$( a3209.cdUnitPrice ) = "" Then b3209.cdUnitPrice = ""  Else b3209.cdUnitPrice=a3209.cdUnitPrice
If trim$( a3209.QtyComponent ) = "" Then b3209.QtyComponent = ""  Else b3209.QtyComponent=a3209.QtyComponent
If trim$( a3209.Consumption ) = "" Then b3209.Consumption = ""  Else b3209.Consumption=a3209.Consumption
If trim$( a3209.Loss ) = "" Then b3209.Loss = ""  Else b3209.Loss=a3209.Loss
If trim$( a3209.GrossUsage ) = "" Then b3209.GrossUsage = ""  Else b3209.GrossUsage=a3209.GrossUsage
If trim$( a3209.MaterialAMT ) = "" Then b3209.MaterialAMT = ""  Else b3209.MaterialAMT=a3209.MaterialAMT
If trim$( a3209.MaterialAMTPurchasing ) = "" Then b3209.MaterialAMTPurchasing = ""  Else b3209.MaterialAMTPurchasing=a3209.MaterialAMTPurchasing
If trim$( a3209.MaterialAMTSales ) = "" Then b3209.MaterialAMTSales = ""  Else b3209.MaterialAMTSales=a3209.MaterialAMTSales
If trim$( a3209.seSubProcess ) = "" Then b3209.seSubProcess = ""  Else b3209.seSubProcess=a3209.seSubProcess
If trim$( a3209.cdSubProcess ) = "" Then b3209.cdSubProcess = ""  Else b3209.cdSubProcess=a3209.cdSubProcess
If trim$( a3209.seSpecialProcess ) = "" Then b3209.seSpecialProcess = ""  Else b3209.seSpecialProcess=a3209.seSpecialProcess
If trim$( a3209.cdSpecialProcess ) = "" Then b3209.cdSpecialProcess = ""  Else b3209.cdSpecialProcess=a3209.cdSpecialProcess
If trim$( a3209.CheckMark ) = "" Then b3209.CheckMark = ""  Else b3209.CheckMark=a3209.CheckMark
If trim$( a3209.CheckUse ) = "" Then b3209.CheckUse = ""  Else b3209.CheckUse=a3209.CheckUse
If trim$( a3209.CheckP1 ) = "" Then b3209.CheckP1 = ""  Else b3209.CheckP1=a3209.CheckP1
If trim$( a3209.CheckP2 ) = "" Then b3209.CheckP2 = ""  Else b3209.CheckP2=a3209.CheckP2
If trim$( a3209.CheckP3 ) = "" Then b3209.CheckP3 = ""  Else b3209.CheckP3=a3209.CheckP3
If trim$( a3209.CheckP4 ) = "" Then b3209.CheckP4 = ""  Else b3209.CheckP4=a3209.CheckP4
If trim$( a3209.CheckP5 ) = "" Then b3209.CheckP5 = ""  Else b3209.CheckP5=a3209.CheckP5
If trim$( a3209.CheckP6 ) = "" Then b3209.CheckP6 = ""  Else b3209.CheckP6=a3209.CheckP6
If trim$( a3209.CheckP7 ) = "" Then b3209.CheckP7 = ""  Else b3209.CheckP7=a3209.CheckP7
If trim$( a3209.CheckP8 ) = "" Then b3209.CheckP8 = ""  Else b3209.CheckP8=a3209.CheckP8
If trim$( a3209.CheckP9 ) = "" Then b3209.CheckP9 = ""  Else b3209.CheckP9=a3209.CheckP9
If trim$( a3209.CheckUse1 ) = "" Then b3209.CheckUse1 = ""  Else b3209.CheckUse1=a3209.CheckUse1
If trim$( a3209.CheckMatching ) = "" Then b3209.CheckMatching = ""  Else b3209.CheckMatching=a3209.CheckMatching
If trim$( a3209.Remark ) = "" Then b3209.Remark = ""  Else b3209.Remark=a3209.Remark
If trim$( a3209.MaterialCode_K3011 ) = "" Then b3209.MaterialCode_K3011 = ""  Else b3209.MaterialCode_K3011=a3209.MaterialCode_K3011
If trim$( a3209.seSite ) = "" Then b3209.seSite = ""  Else b3209.seSite=a3209.seSite
If trim$( a3209.cdSite ) = "" Then b3209.cdSite = ""  Else b3209.cdSite=a3209.cdSite
If trim$( a3209.DateInsert ) = "" Then b3209.DateInsert = ""  Else b3209.DateInsert=a3209.DateInsert
If trim$( a3209.DateUpdate ) = "" Then b3209.DateUpdate = ""  Else b3209.DateUpdate=a3209.DateUpdate
If trim$( a3209.InchargeInsert ) = "" Then b3209.InchargeInsert = ""  Else b3209.InchargeInsert=a3209.InchargeInsert
If trim$( a3209.InchargeUpdate ) = "" Then b3209.InchargeUpdate = ""  Else b3209.InchargeUpdate=a3209.InchargeUpdate
If trim$( a3209.TimeInsert ) = "" Then b3209.TimeInsert = ""  Else b3209.TimeInsert=a3209.TimeInsert
If trim$( a3209.TimeUpdate ) = "" Then b3209.TimeUpdate = ""  Else b3209.TimeUpdate=a3209.TimeUpdate
Catch ex As Exception
      Call MsgBoxP("K3209_MOVE",vbCritical)
End Try
End Sub 


End Module 
