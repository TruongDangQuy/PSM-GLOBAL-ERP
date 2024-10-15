'=========================================================================================================================================================
'   TABLE : (PFK7261)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7261

Structure T7261_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	ContractID	 AS String	'			char(6)		*
Public 	ContracSeq	 AS Double	'			decimal		*
Public 	Dseq	 AS Double	'			decimal
Public 	MaterialCode	 AS String	'			char(6)
Public 	ColorName	 AS String	'			nvarchar(200)
Public 	ColorCode	 AS String	'			char(6)
Public 	CustomerCode	 AS String	'			char(6)
Public 	seSite	 AS String	'			char(3)
Public 	cdSite	 AS String	'			char(3)
Public 	seDepartment	 AS String	'			char(3)
Public 	cdDepartment	 AS String	'			char(3)
Public 	seFactory	 AS String	'			char(3)
Public 	cdFactory	 AS String	'			char(3)
Public 	seUnitPacking	 AS String	'			char(3)
Public 	cdUnitPacking	 AS String	'			char(3)
Public 	QtyMOQ	 AS Double	'			decimal
Public 	QtyBasic	 AS Double	'			decimal
Public 	UnitBaseCheck	 AS String	'			char(1)
Public 	seUnitMaterial	 AS String	'			char(3)
Public 	cdUnitMaterial	 AS String	'			char(3)
Public 	PriceMaterialVND	 AS Double	'			decimal
Public 	seUnitPrice	 AS String	'			char(3)
Public 	cdUnitPrice	 AS String	'			char(3)
Public 	PriceMaterialEX	 AS Double	'			decimal
Public 	PriceCharge	 AS Double	'			decimal
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(6)
Public 	InchargeUpdate	 AS String	'			char(6)
Public 	DateSync	 AS String	'			char(8)
Public 	CheckSync	 AS String	'			char(1)
Public 	Remark	 AS String	'			nvarchar(1000)
'=========================================================================================================================================================
End structure

Public D7261 As T7261_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7261(CONTRACTID AS String, CONTRACSEQ AS Double) As Boolean
    READ_PFK7261 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7261 "
    SQL = SQL & " WHERE K7261_ContractID		 = '" & ContractID & "' " 
    SQL = SQL & "   AND K7261_ContracSeq		 =  " & ContracSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7261_CLEAR: GoTo SKIP_READ_PFK7261
                
    Call K7261_MOVE(rd)
    READ_PFK7261 = True

SKIP_READ_PFK7261:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7261",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7261(CONTRACTID AS String, CONTRACSEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7261 "
    SQL = SQL & " WHERE K7261_ContractID		 = '" & ContractID & "' " 
    SQL = SQL & "   AND K7261_ContracSeq		 =  " & ContracSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7261",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7261(z7261 As T7261_AREA) As Boolean
    WRITE_PFK7261 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7261)
 
    SQL = " INSERT INTO PFK7261 "
    SQL = SQL & " ( "
    SQL = SQL & " K7261_ContractID," 
    SQL = SQL & " K7261_ContracSeq," 
    SQL = SQL & " K7261_Dseq," 
    SQL = SQL & " K7261_MaterialCode," 
    SQL = SQL & " K7261_ColorName," 
    SQL = SQL & " K7261_ColorCode," 
    SQL = SQL & " K7261_CustomerCode," 
    SQL = SQL & " K7261_seSite," 
    SQL = SQL & " K7261_cdSite," 
    SQL = SQL & " K7261_seDepartment," 
    SQL = SQL & " K7261_cdDepartment," 
    SQL = SQL & " K7261_seFactory," 
    SQL = SQL & " K7261_cdFactory," 
    SQL = SQL & " K7261_seUnitPacking," 
    SQL = SQL & " K7261_cdUnitPacking," 
    SQL = SQL & " K7261_QtyMOQ," 
    SQL = SQL & " K7261_QtyBasic," 
    SQL = SQL & " K7261_UnitBaseCheck," 
    SQL = SQL & " K7261_seUnitMaterial," 
    SQL = SQL & " K7261_cdUnitMaterial," 
    SQL = SQL & " K7261_PriceMaterialVND," 
    SQL = SQL & " K7261_seUnitPrice," 
    SQL = SQL & " K7261_cdUnitPrice," 
    SQL = SQL & " K7261_PriceMaterialEX," 
    SQL = SQL & " K7261_PriceCharge," 
    SQL = SQL & " K7261_DateInsert," 
    SQL = SQL & " K7261_DateUpdate," 
    SQL = SQL & " K7261_InchargeInsert," 
    SQL = SQL & " K7261_InchargeUpdate," 
    SQL = SQL & " K7261_DateSync," 
    SQL = SQL & " K7261_CheckSync," 
    SQL = SQL & " K7261_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7261.ContractID) & "', "  
    SQL = SQL & "   " & FormatSQL(z7261.ContracSeq) & ", "  
    SQL = SQL & "   " & FormatSQL(z7261.Dseq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7261.MaterialCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7261.ColorName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7261.ColorCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7261.CustomerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7261.seSite) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7261.cdSite) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7261.seDepartment) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7261.cdDepartment) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7261.seFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7261.cdFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7261.seUnitPacking) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7261.cdUnitPacking) & "', "  
    SQL = SQL & "   " & FormatSQL(z7261.QtyMOQ) & ", "  
    SQL = SQL & "   " & FormatSQL(z7261.QtyBasic) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7261.UnitBaseCheck) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7261.seUnitMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7261.cdUnitMaterial) & "', "  
    SQL = SQL & "   " & FormatSQL(z7261.PriceMaterialVND) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7261.seUnitPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7261.cdUnitPrice) & "', "  
    SQL = SQL & "   " & FormatSQL(z7261.PriceMaterialEX) & ", "  
    SQL = SQL & "   " & FormatSQL(z7261.PriceCharge) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7261.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7261.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7261.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7261.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7261.DateSync) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7261.CheckSync) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7261.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7261 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7261",vbCritical)
Finally
        Call GetFullInformation("PFK7261", "I", SQL)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7261(z7261 As T7261_AREA) As Boolean
    REWRITE_PFK7261 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7261)
   
    SQL = " UPDATE PFK7261 SET "
    SQL = SQL & "    K7261_Dseq      =  " & FormatSQL(z7261.Dseq) & ", " 
    SQL = SQL & "    K7261_MaterialCode      = N'" & FormatSQL(z7261.MaterialCode) & "', " 
    SQL = SQL & "    K7261_ColorName      = N'" & FormatSQL(z7261.ColorName) & "', " 
    SQL = SQL & "    K7261_ColorCode      = N'" & FormatSQL(z7261.ColorCode) & "', " 
    SQL = SQL & "    K7261_CustomerCode      = N'" & FormatSQL(z7261.CustomerCode) & "', " 
    SQL = SQL & "    K7261_seSite      = N'" & FormatSQL(z7261.seSite) & "', " 
    SQL = SQL & "    K7261_cdSite      = N'" & FormatSQL(z7261.cdSite) & "', " 
    SQL = SQL & "    K7261_seDepartment      = N'" & FormatSQL(z7261.seDepartment) & "', " 
    SQL = SQL & "    K7261_cdDepartment      = N'" & FormatSQL(z7261.cdDepartment) & "', " 
    SQL = SQL & "    K7261_seFactory      = N'" & FormatSQL(z7261.seFactory) & "', " 
    SQL = SQL & "    K7261_cdFactory      = N'" & FormatSQL(z7261.cdFactory) & "', " 
    SQL = SQL & "    K7261_seUnitPacking      = N'" & FormatSQL(z7261.seUnitPacking) & "', " 
    SQL = SQL & "    K7261_cdUnitPacking      = N'" & FormatSQL(z7261.cdUnitPacking) & "', " 
    SQL = SQL & "    K7261_QtyMOQ      =  " & FormatSQL(z7261.QtyMOQ) & ", " 
    SQL = SQL & "    K7261_QtyBasic      =  " & FormatSQL(z7261.QtyBasic) & ", " 
    SQL = SQL & "    K7261_UnitBaseCheck      = N'" & FormatSQL(z7261.UnitBaseCheck) & "', " 
    SQL = SQL & "    K7261_seUnitMaterial      = N'" & FormatSQL(z7261.seUnitMaterial) & "', " 
    SQL = SQL & "    K7261_cdUnitMaterial      = N'" & FormatSQL(z7261.cdUnitMaterial) & "', " 
    SQL = SQL & "    K7261_PriceMaterialVND      =  " & FormatSQL(z7261.PriceMaterialVND) & ", " 
    SQL = SQL & "    K7261_seUnitPrice      = N'" & FormatSQL(z7261.seUnitPrice) & "', " 
    SQL = SQL & "    K7261_cdUnitPrice      = N'" & FormatSQL(z7261.cdUnitPrice) & "', " 
    SQL = SQL & "    K7261_PriceMaterialEX      =  " & FormatSQL(z7261.PriceMaterialEX) & ", " 
    SQL = SQL & "    K7261_PriceCharge      =  " & FormatSQL(z7261.PriceCharge) & ", " 
    SQL = SQL & "    K7261_DateInsert      = N'" & FormatSQL(z7261.DateInsert) & "', " 
    SQL = SQL & "    K7261_DateUpdate      = N'" & FormatSQL(z7261.DateUpdate) & "', " 
    SQL = SQL & "    K7261_InchargeInsert      = N'" & FormatSQL(z7261.InchargeInsert) & "', " 
    SQL = SQL & "    K7261_InchargeUpdate      = N'" & FormatSQL(z7261.InchargeUpdate) & "', " 
    SQL = SQL & "    K7261_DateSync      = N'" & FormatSQL(z7261.DateSync) & "', " 
    SQL = SQL & "    K7261_CheckSync      = N'" & FormatSQL(z7261.CheckSync) & "', " 
    SQL = SQL & "    K7261_Remark      = N'" & FormatSQL(z7261.Remark) & "'  " 
    SQL = SQL & " WHERE K7261_ContractID		 = '" & z7261.ContractID & "' " 
    SQL = SQL & "   AND K7261_ContracSeq		 =  " & z7261.ContracSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
	REWRITE_PFK7261 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7261",vbCritical)
Finally
        Call GetFullInformation("PFK7261", "U", SQL)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7261(z7261 As T7261_AREA) As Boolean
    DELETE_PFK7261 = False

   Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7261)
      
        SQL = " DELETE FROM PFK7261  "
    SQL = SQL & " WHERE K7261_ContractID		 = '" & z7261.ContractID & "' " 
    SQL = SQL & "   AND K7261_ContracSeq		 =  " & z7261.ContracSeq & "  " 

    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7261 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7261",vbCritical)
Finally
        Call GetFullInformation("PFK7261", "U", SQL)
  End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7261_CLEAR()
Try
    
   D7261.ContractID = ""
    D7261.ContracSeq = 0 
    D7261.Dseq = 0 
   D7261.MaterialCode = ""
   D7261.ColorName = ""
   D7261.ColorCode = ""
   D7261.CustomerCode = ""
   D7261.seSite = ""
   D7261.cdSite = ""
   D7261.seDepartment = ""
   D7261.cdDepartment = ""
   D7261.seFactory = ""
   D7261.cdFactory = ""
   D7261.seUnitPacking = ""
   D7261.cdUnitPacking = ""
    D7261.QtyMOQ = 0 
    D7261.QtyBasic = 0 
   D7261.UnitBaseCheck = ""
   D7261.seUnitMaterial = ""
   D7261.cdUnitMaterial = ""
    D7261.PriceMaterialVND = 0 
   D7261.seUnitPrice = ""
   D7261.cdUnitPrice = ""
    D7261.PriceMaterialEX = 0 
    D7261.PriceCharge = 0 
   D7261.DateInsert = ""
   D7261.DateUpdate = ""
   D7261.InchargeInsert = ""
   D7261.InchargeUpdate = ""
   D7261.DateSync = ""
   D7261.CheckSync = ""
   D7261.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7261_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7261 As T7261_AREA)
Try
    
    x7261.ContractID = trim$(  x7261.ContractID)
    x7261.ContracSeq = trim$(  x7261.ContracSeq)
    x7261.Dseq = trim$(  x7261.Dseq)
    x7261.MaterialCode = trim$(  x7261.MaterialCode)
    x7261.ColorName = trim$(  x7261.ColorName)
    x7261.ColorCode = trim$(  x7261.ColorCode)
    x7261.CustomerCode = trim$(  x7261.CustomerCode)
    x7261.seSite = trim$(  x7261.seSite)
    x7261.cdSite = trim$(  x7261.cdSite)
    x7261.seDepartment = trim$(  x7261.seDepartment)
    x7261.cdDepartment = trim$(  x7261.cdDepartment)
    x7261.seFactory = trim$(  x7261.seFactory)
    x7261.cdFactory = trim$(  x7261.cdFactory)
    x7261.seUnitPacking = trim$(  x7261.seUnitPacking)
    x7261.cdUnitPacking = trim$(  x7261.cdUnitPacking)
    x7261.QtyMOQ = trim$(  x7261.QtyMOQ)
    x7261.QtyBasic = trim$(  x7261.QtyBasic)
    x7261.UnitBaseCheck = trim$(  x7261.UnitBaseCheck)
    x7261.seUnitMaterial = trim$(  x7261.seUnitMaterial)
    x7261.cdUnitMaterial = trim$(  x7261.cdUnitMaterial)
    x7261.PriceMaterialVND = trim$(  x7261.PriceMaterialVND)
    x7261.seUnitPrice = trim$(  x7261.seUnitPrice)
    x7261.cdUnitPrice = trim$(  x7261.cdUnitPrice)
    x7261.PriceMaterialEX = trim$(  x7261.PriceMaterialEX)
    x7261.PriceCharge = trim$(  x7261.PriceCharge)
    x7261.DateInsert = trim$(  x7261.DateInsert)
    x7261.DateUpdate = trim$(  x7261.DateUpdate)
    x7261.InchargeInsert = trim$(  x7261.InchargeInsert)
    x7261.InchargeUpdate = trim$(  x7261.InchargeUpdate)
    x7261.DateSync = trim$(  x7261.DateSync)
    x7261.CheckSync = trim$(  x7261.CheckSync)
    x7261.Remark = trim$(  x7261.Remark)
     
    If trim$( x7261.ContractID ) = "" Then x7261.ContractID = Space(1) 
    If trim$( x7261.ContracSeq ) = "" Then x7261.ContracSeq = 0 
    If trim$( x7261.Dseq ) = "" Then x7261.Dseq = 0 
    If trim$( x7261.MaterialCode ) = "" Then x7261.MaterialCode = Space(1) 
    If trim$( x7261.ColorName ) = "" Then x7261.ColorName = Space(1) 
    If trim$( x7261.ColorCode ) = "" Then x7261.ColorCode = Space(1) 
    If trim$( x7261.CustomerCode ) = "" Then x7261.CustomerCode = Space(1) 
    If trim$( x7261.seSite ) = "" Then x7261.seSite = Space(1) 
    If trim$( x7261.cdSite ) = "" Then x7261.cdSite = Space(1) 
    If trim$( x7261.seDepartment ) = "" Then x7261.seDepartment = Space(1) 
    If trim$( x7261.cdDepartment ) = "" Then x7261.cdDepartment = Space(1) 
    If trim$( x7261.seFactory ) = "" Then x7261.seFactory = Space(1) 
    If trim$( x7261.cdFactory ) = "" Then x7261.cdFactory = Space(1) 
    If trim$( x7261.seUnitPacking ) = "" Then x7261.seUnitPacking = Space(1) 
    If trim$( x7261.cdUnitPacking ) = "" Then x7261.cdUnitPacking = Space(1) 
    If trim$( x7261.QtyMOQ ) = "" Then x7261.QtyMOQ = 0 
    If trim$( x7261.QtyBasic ) = "" Then x7261.QtyBasic = 0 
    If trim$( x7261.UnitBaseCheck ) = "" Then x7261.UnitBaseCheck = Space(1) 
    If trim$( x7261.seUnitMaterial ) = "" Then x7261.seUnitMaterial = Space(1) 
    If trim$( x7261.cdUnitMaterial ) = "" Then x7261.cdUnitMaterial = Space(1) 
    If trim$( x7261.PriceMaterialVND ) = "" Then x7261.PriceMaterialVND = 0 
    If trim$( x7261.seUnitPrice ) = "" Then x7261.seUnitPrice = Space(1) 
    If trim$( x7261.cdUnitPrice ) = "" Then x7261.cdUnitPrice = Space(1) 
    If trim$( x7261.PriceMaterialEX ) = "" Then x7261.PriceMaterialEX = 0 
    If trim$( x7261.PriceCharge ) = "" Then x7261.PriceCharge = 0 
    If trim$( x7261.DateInsert ) = "" Then x7261.DateInsert = Space(1) 
    If trim$( x7261.DateUpdate ) = "" Then x7261.DateUpdate = Space(1) 
    If trim$( x7261.InchargeInsert ) = "" Then x7261.InchargeInsert = Space(1) 
    If trim$( x7261.InchargeUpdate ) = "" Then x7261.InchargeUpdate = Space(1) 
    If trim$( x7261.DateSync ) = "" Then x7261.DateSync = Space(1) 
    If trim$( x7261.CheckSync ) = "" Then x7261.CheckSync = Space(1) 
    If trim$( x7261.Remark ) = "" Then x7261.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7261_MOVE(rs7261 As SqlClient.SqlDataReader)
Try

    call D7261_CLEAR()   

    If IsdbNull(rs7261!K7261_ContractID) = False Then D7261.ContractID = Trim$(rs7261!K7261_ContractID)
    If IsdbNull(rs7261!K7261_ContracSeq) = False Then D7261.ContracSeq = Trim$(rs7261!K7261_ContracSeq)
    If IsdbNull(rs7261!K7261_Dseq) = False Then D7261.Dseq = Trim$(rs7261!K7261_Dseq)
    If IsdbNull(rs7261!K7261_MaterialCode) = False Then D7261.MaterialCode = Trim$(rs7261!K7261_MaterialCode)
    If IsdbNull(rs7261!K7261_ColorName) = False Then D7261.ColorName = Trim$(rs7261!K7261_ColorName)
    If IsdbNull(rs7261!K7261_ColorCode) = False Then D7261.ColorCode = Trim$(rs7261!K7261_ColorCode)
    If IsdbNull(rs7261!K7261_CustomerCode) = False Then D7261.CustomerCode = Trim$(rs7261!K7261_CustomerCode)
    If IsdbNull(rs7261!K7261_seSite) = False Then D7261.seSite = Trim$(rs7261!K7261_seSite)
    If IsdbNull(rs7261!K7261_cdSite) = False Then D7261.cdSite = Trim$(rs7261!K7261_cdSite)
    If IsdbNull(rs7261!K7261_seDepartment) = False Then D7261.seDepartment = Trim$(rs7261!K7261_seDepartment)
    If IsdbNull(rs7261!K7261_cdDepartment) = False Then D7261.cdDepartment = Trim$(rs7261!K7261_cdDepartment)
    If IsdbNull(rs7261!K7261_seFactory) = False Then D7261.seFactory = Trim$(rs7261!K7261_seFactory)
    If IsdbNull(rs7261!K7261_cdFactory) = False Then D7261.cdFactory = Trim$(rs7261!K7261_cdFactory)
    If IsdbNull(rs7261!K7261_seUnitPacking) = False Then D7261.seUnitPacking = Trim$(rs7261!K7261_seUnitPacking)
    If IsdbNull(rs7261!K7261_cdUnitPacking) = False Then D7261.cdUnitPacking = Trim$(rs7261!K7261_cdUnitPacking)
    If IsdbNull(rs7261!K7261_QtyMOQ) = False Then D7261.QtyMOQ = Trim$(rs7261!K7261_QtyMOQ)
    If IsdbNull(rs7261!K7261_QtyBasic) = False Then D7261.QtyBasic = Trim$(rs7261!K7261_QtyBasic)
    If IsdbNull(rs7261!K7261_UnitBaseCheck) = False Then D7261.UnitBaseCheck = Trim$(rs7261!K7261_UnitBaseCheck)
    If IsdbNull(rs7261!K7261_seUnitMaterial) = False Then D7261.seUnitMaterial = Trim$(rs7261!K7261_seUnitMaterial)
    If IsdbNull(rs7261!K7261_cdUnitMaterial) = False Then D7261.cdUnitMaterial = Trim$(rs7261!K7261_cdUnitMaterial)
    If IsdbNull(rs7261!K7261_PriceMaterialVND) = False Then D7261.PriceMaterialVND = Trim$(rs7261!K7261_PriceMaterialVND)
    If IsdbNull(rs7261!K7261_seUnitPrice) = False Then D7261.seUnitPrice = Trim$(rs7261!K7261_seUnitPrice)
    If IsdbNull(rs7261!K7261_cdUnitPrice) = False Then D7261.cdUnitPrice = Trim$(rs7261!K7261_cdUnitPrice)
    If IsdbNull(rs7261!K7261_PriceMaterialEX) = False Then D7261.PriceMaterialEX = Trim$(rs7261!K7261_PriceMaterialEX)
    If IsdbNull(rs7261!K7261_PriceCharge) = False Then D7261.PriceCharge = Trim$(rs7261!K7261_PriceCharge)
    If IsdbNull(rs7261!K7261_DateInsert) = False Then D7261.DateInsert = Trim$(rs7261!K7261_DateInsert)
    If IsdbNull(rs7261!K7261_DateUpdate) = False Then D7261.DateUpdate = Trim$(rs7261!K7261_DateUpdate)
    If IsdbNull(rs7261!K7261_InchargeInsert) = False Then D7261.InchargeInsert = Trim$(rs7261!K7261_InchargeInsert)
    If IsdbNull(rs7261!K7261_InchargeUpdate) = False Then D7261.InchargeUpdate = Trim$(rs7261!K7261_InchargeUpdate)
    If IsdbNull(rs7261!K7261_DateSync) = False Then D7261.DateSync = Trim$(rs7261!K7261_DateSync)
    If IsdbNull(rs7261!K7261_CheckSync) = False Then D7261.CheckSync = Trim$(rs7261!K7261_CheckSync)
    If IsdbNull(rs7261!K7261_Remark) = False Then D7261.Remark = Trim$(rs7261!K7261_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7261_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7261_MOVE(rs7261 As DataRow)
Try

    call D7261_CLEAR()   

    If IsdbNull(rs7261!K7261_ContractID) = False Then D7261.ContractID = Trim$(rs7261!K7261_ContractID)
    If IsdbNull(rs7261!K7261_ContracSeq) = False Then D7261.ContracSeq = Trim$(rs7261!K7261_ContracSeq)
    If IsdbNull(rs7261!K7261_Dseq) = False Then D7261.Dseq = Trim$(rs7261!K7261_Dseq)
    If IsdbNull(rs7261!K7261_MaterialCode) = False Then D7261.MaterialCode = Trim$(rs7261!K7261_MaterialCode)
    If IsdbNull(rs7261!K7261_ColorName) = False Then D7261.ColorName = Trim$(rs7261!K7261_ColorName)
    If IsdbNull(rs7261!K7261_ColorCode) = False Then D7261.ColorCode = Trim$(rs7261!K7261_ColorCode)
    If IsdbNull(rs7261!K7261_CustomerCode) = False Then D7261.CustomerCode = Trim$(rs7261!K7261_CustomerCode)
    If IsdbNull(rs7261!K7261_seSite) = False Then D7261.seSite = Trim$(rs7261!K7261_seSite)
    If IsdbNull(rs7261!K7261_cdSite) = False Then D7261.cdSite = Trim$(rs7261!K7261_cdSite)
    If IsdbNull(rs7261!K7261_seDepartment) = False Then D7261.seDepartment = Trim$(rs7261!K7261_seDepartment)
    If IsdbNull(rs7261!K7261_cdDepartment) = False Then D7261.cdDepartment = Trim$(rs7261!K7261_cdDepartment)
    If IsdbNull(rs7261!K7261_seFactory) = False Then D7261.seFactory = Trim$(rs7261!K7261_seFactory)
    If IsdbNull(rs7261!K7261_cdFactory) = False Then D7261.cdFactory = Trim$(rs7261!K7261_cdFactory)
    If IsdbNull(rs7261!K7261_seUnitPacking) = False Then D7261.seUnitPacking = Trim$(rs7261!K7261_seUnitPacking)
    If IsdbNull(rs7261!K7261_cdUnitPacking) = False Then D7261.cdUnitPacking = Trim$(rs7261!K7261_cdUnitPacking)
    If IsdbNull(rs7261!K7261_QtyMOQ) = False Then D7261.QtyMOQ = Trim$(rs7261!K7261_QtyMOQ)
    If IsdbNull(rs7261!K7261_QtyBasic) = False Then D7261.QtyBasic = Trim$(rs7261!K7261_QtyBasic)
    If IsdbNull(rs7261!K7261_UnitBaseCheck) = False Then D7261.UnitBaseCheck = Trim$(rs7261!K7261_UnitBaseCheck)
    If IsdbNull(rs7261!K7261_seUnitMaterial) = False Then D7261.seUnitMaterial = Trim$(rs7261!K7261_seUnitMaterial)
    If IsdbNull(rs7261!K7261_cdUnitMaterial) = False Then D7261.cdUnitMaterial = Trim$(rs7261!K7261_cdUnitMaterial)
    If IsdbNull(rs7261!K7261_PriceMaterialVND) = False Then D7261.PriceMaterialVND = Trim$(rs7261!K7261_PriceMaterialVND)
    If IsdbNull(rs7261!K7261_seUnitPrice) = False Then D7261.seUnitPrice = Trim$(rs7261!K7261_seUnitPrice)
    If IsdbNull(rs7261!K7261_cdUnitPrice) = False Then D7261.cdUnitPrice = Trim$(rs7261!K7261_cdUnitPrice)
    If IsdbNull(rs7261!K7261_PriceMaterialEX) = False Then D7261.PriceMaterialEX = Trim$(rs7261!K7261_PriceMaterialEX)
    If IsdbNull(rs7261!K7261_PriceCharge) = False Then D7261.PriceCharge = Trim$(rs7261!K7261_PriceCharge)
    If IsdbNull(rs7261!K7261_DateInsert) = False Then D7261.DateInsert = Trim$(rs7261!K7261_DateInsert)
    If IsdbNull(rs7261!K7261_DateUpdate) = False Then D7261.DateUpdate = Trim$(rs7261!K7261_DateUpdate)
    If IsdbNull(rs7261!K7261_InchargeInsert) = False Then D7261.InchargeInsert = Trim$(rs7261!K7261_InchargeInsert)
    If IsdbNull(rs7261!K7261_InchargeUpdate) = False Then D7261.InchargeUpdate = Trim$(rs7261!K7261_InchargeUpdate)
    If IsdbNull(rs7261!K7261_DateSync) = False Then D7261.DateSync = Trim$(rs7261!K7261_DateSync)
    If IsdbNull(rs7261!K7261_CheckSync) = False Then D7261.CheckSync = Trim$(rs7261!K7261_CheckSync)
    If IsdbNull(rs7261!K7261_Remark) = False Then D7261.Remark = Trim$(rs7261!K7261_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7261_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7261_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7261 As T7261_AREA, CONTRACTID AS String, CONTRACSEQ AS Double) as Boolean

K7261_MOVE = False

Try
    If READ_PFK7261(CONTRACTID, CONTRACSEQ) = True Then
                z7261 = D7261
		K7261_MOVE = True
		else
	z7261 = nothing
     End If

     If  getColumnIndex(spr,"ContractID") > -1 then z7261.ContractID = getDataM(spr, getColumnIndex(spr,"ContractID"), xRow)
     If  getColumnIndex(spr,"ContracSeq") > -1 then z7261.ContracSeq = getDataM(spr, getColumnIndex(spr,"ContracSeq"), xRow)
     If  getColumnIndex(spr,"Dseq") > -1 then z7261.Dseq = getDataM(spr, getColumnIndex(spr,"Dseq"), xRow)
     If  getColumnIndex(spr,"MaterialCode") > -1 then z7261.MaterialCode = getDataM(spr, getColumnIndex(spr,"MaterialCode"), xRow)
     If  getColumnIndex(spr,"ColorName") > -1 then z7261.ColorName = getDataM(spr, getColumnIndex(spr,"ColorName"), xRow)
     If  getColumnIndex(spr,"ColorCode") > -1 then z7261.ColorCode = getDataM(spr, getColumnIndex(spr,"ColorCode"), xRow)
     If  getColumnIndex(spr,"CustomerCode") > -1 then z7261.CustomerCode = getDataM(spr, getColumnIndex(spr,"CustomerCode"), xRow)
     If  getColumnIndex(spr,"seSite") > -1 then z7261.seSite = getDataM(spr, getColumnIndex(spr,"seSite"), xRow)
     If  getColumnIndex(spr,"cdSite") > -1 then z7261.cdSite = getDataM(spr, getColumnIndex(spr,"cdSite"), xRow)
     If  getColumnIndex(spr,"seDepartment") > -1 then z7261.seDepartment = getDataM(spr, getColumnIndex(spr,"seDepartment"), xRow)
     If  getColumnIndex(spr,"cdDepartment") > -1 then z7261.cdDepartment = getDataM(spr, getColumnIndex(spr,"cdDepartment"), xRow)
     If  getColumnIndex(spr,"seFactory") > -1 then z7261.seFactory = getDataM(spr, getColumnIndex(spr,"seFactory"), xRow)
     If  getColumnIndex(spr,"cdFactory") > -1 then z7261.cdFactory = getDataM(spr, getColumnIndex(spr,"cdFactory"), xRow)
     If  getColumnIndex(spr,"seUnitPacking") > -1 then z7261.seUnitPacking = getDataM(spr, getColumnIndex(spr,"seUnitPacking"), xRow)
     If  getColumnIndex(spr,"cdUnitPacking") > -1 then z7261.cdUnitPacking = getDataM(spr, getColumnIndex(spr,"cdUnitPacking"), xRow)
     If  getColumnIndex(spr,"QtyMOQ") > -1 then z7261.QtyMOQ = getDataM(spr, getColumnIndex(spr,"QtyMOQ"), xRow)
     If  getColumnIndex(spr,"QtyBasic") > -1 then z7261.QtyBasic = getDataM(spr, getColumnIndex(spr,"QtyBasic"), xRow)
     If  getColumnIndex(spr,"UnitBaseCheck") > -1 then z7261.UnitBaseCheck = getDataM(spr, getColumnIndex(spr,"UnitBaseCheck"), xRow)
     If  getColumnIndex(spr,"seUnitMaterial") > -1 then z7261.seUnitMaterial = getDataM(spr, getColumnIndex(spr,"seUnitMaterial"), xRow)
     If  getColumnIndex(spr,"cdUnitMaterial") > -1 then z7261.cdUnitMaterial = getDataM(spr, getColumnIndex(spr,"cdUnitMaterial"), xRow)
     If  getColumnIndex(spr,"PriceMaterialVND") > -1 then z7261.PriceMaterialVND = getDataM(spr, getColumnIndex(spr,"PriceMaterialVND"), xRow)
     If  getColumnIndex(spr,"seUnitPrice") > -1 then z7261.seUnitPrice = getDataM(spr, getColumnIndex(spr,"seUnitPrice"), xRow)
     If  getColumnIndex(spr,"cdUnitPrice") > -1 then z7261.cdUnitPrice = getDataM(spr, getColumnIndex(spr,"cdUnitPrice"), xRow)
     If  getColumnIndex(spr,"PriceMaterialEX") > -1 then z7261.PriceMaterialEX = getDataM(spr, getColumnIndex(spr,"PriceMaterialEX"), xRow)
     If  getColumnIndex(spr,"PriceCharge") > -1 then z7261.PriceCharge = getDataM(spr, getColumnIndex(spr,"PriceCharge"), xRow)
     If  getColumnIndex(spr,"DateInsert") > -1 then z7261.DateInsert = getDataM(spr, getColumnIndex(spr,"DateInsert"), xRow)
     If  getColumnIndex(spr,"DateUpdate") > -1 then z7261.DateUpdate = getDataM(spr, getColumnIndex(spr,"DateUpdate"), xRow)
     If  getColumnIndex(spr,"InchargeInsert") > -1 then z7261.InchargeInsert = getDataM(spr, getColumnIndex(spr,"InchargeInsert"), xRow)
     If  getColumnIndex(spr,"InchargeUpdate") > -1 then z7261.InchargeUpdate = getDataM(spr, getColumnIndex(spr,"InchargeUpdate"), xRow)
     If  getColumnIndex(spr,"DateSync") > -1 then z7261.DateSync = getDataM(spr, getColumnIndex(spr,"DateSync"), xRow)
     If  getColumnIndex(spr,"CheckSync") > -1 then z7261.CheckSync = getDataM(spr, getColumnIndex(spr,"CheckSync"), xRow)
     If  getColumnIndex(spr,"Remark") > -1 then z7261.Remark = getDataM(spr, getColumnIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7261_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7261_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7261 As T7261_AREA,CheckClear as Boolean,CONTRACTID AS String, CONTRACSEQ AS Double) as Boolean

K7261_MOVE = False

Try
    If READ_PFK7261(CONTRACTID, CONTRACSEQ) = True Then
                z7261 = D7261
		K7261_MOVE = True
		else
	If CheckClear  = True then z7261 = nothing
     End If

     If  getColumnIndex(spr,"ContractID") > -1 then z7261.ContractID = getDataM(spr, getColumnIndex(spr,"ContractID"), xRow)
     If  getColumnIndex(spr,"ContracSeq") > -1 then z7261.ContracSeq = getDataM(spr, getColumnIndex(spr,"ContracSeq"), xRow)
     If  getColumnIndex(spr,"Dseq") > -1 then z7261.Dseq = getDataM(spr, getColumnIndex(spr,"Dseq"), xRow)
     If  getColumnIndex(spr,"MaterialCode") > -1 then z7261.MaterialCode = getDataM(spr, getColumnIndex(spr,"MaterialCode"), xRow)
     If  getColumnIndex(spr,"ColorName") > -1 then z7261.ColorName = getDataM(spr, getColumnIndex(spr,"ColorName"), xRow)
     If  getColumnIndex(spr,"ColorCode") > -1 then z7261.ColorCode = getDataM(spr, getColumnIndex(spr,"ColorCode"), xRow)
     If  getColumnIndex(spr,"CustomerCode") > -1 then z7261.CustomerCode = getDataM(spr, getColumnIndex(spr,"CustomerCode"), xRow)
     If  getColumnIndex(spr,"seSite") > -1 then z7261.seSite = getDataM(spr, getColumnIndex(spr,"seSite"), xRow)
     If  getColumnIndex(spr,"cdSite") > -1 then z7261.cdSite = getDataM(spr, getColumnIndex(spr,"cdSite"), xRow)
     If  getColumnIndex(spr,"seDepartment") > -1 then z7261.seDepartment = getDataM(spr, getColumnIndex(spr,"seDepartment"), xRow)
     If  getColumnIndex(spr,"cdDepartment") > -1 then z7261.cdDepartment = getDataM(spr, getColumnIndex(spr,"cdDepartment"), xRow)
     If  getColumnIndex(spr,"seFactory") > -1 then z7261.seFactory = getDataM(spr, getColumnIndex(spr,"seFactory"), xRow)
     If  getColumnIndex(spr,"cdFactory") > -1 then z7261.cdFactory = getDataM(spr, getColumnIndex(spr,"cdFactory"), xRow)
     If  getColumnIndex(spr,"seUnitPacking") > -1 then z7261.seUnitPacking = getDataM(spr, getColumnIndex(spr,"seUnitPacking"), xRow)
     If  getColumnIndex(spr,"cdUnitPacking") > -1 then z7261.cdUnitPacking = getDataM(spr, getColumnIndex(spr,"cdUnitPacking"), xRow)
     If  getColumnIndex(spr,"QtyMOQ") > -1 then z7261.QtyMOQ = getDataM(spr, getColumnIndex(spr,"QtyMOQ"), xRow)
     If  getColumnIndex(spr,"QtyBasic") > -1 then z7261.QtyBasic = getDataM(spr, getColumnIndex(spr,"QtyBasic"), xRow)
     If  getColumnIndex(spr,"UnitBaseCheck") > -1 then z7261.UnitBaseCheck = getDataM(spr, getColumnIndex(spr,"UnitBaseCheck"), xRow)
     If  getColumnIndex(spr,"seUnitMaterial") > -1 then z7261.seUnitMaterial = getDataM(spr, getColumnIndex(spr,"seUnitMaterial"), xRow)
     If  getColumnIndex(spr,"cdUnitMaterial") > -1 then z7261.cdUnitMaterial = getDataM(spr, getColumnIndex(spr,"cdUnitMaterial"), xRow)
     If  getColumnIndex(spr,"PriceMaterialVND") > -1 then z7261.PriceMaterialVND = getDataM(spr, getColumnIndex(spr,"PriceMaterialVND"), xRow)
     If  getColumnIndex(spr,"seUnitPrice") > -1 then z7261.seUnitPrice = getDataM(spr, getColumnIndex(spr,"seUnitPrice"), xRow)
     If  getColumnIndex(spr,"cdUnitPrice") > -1 then z7261.cdUnitPrice = getDataM(spr, getColumnIndex(spr,"cdUnitPrice"), xRow)
     If  getColumnIndex(spr,"PriceMaterialEX") > -1 then z7261.PriceMaterialEX = getDataM(spr, getColumnIndex(spr,"PriceMaterialEX"), xRow)
     If  getColumnIndex(spr,"PriceCharge") > -1 then z7261.PriceCharge = getDataM(spr, getColumnIndex(spr,"PriceCharge"), xRow)
     If  getColumnIndex(spr,"DateInsert") > -1 then z7261.DateInsert = getDataM(spr, getColumnIndex(spr,"DateInsert"), xRow)
     If  getColumnIndex(spr,"DateUpdate") > -1 then z7261.DateUpdate = getDataM(spr, getColumnIndex(spr,"DateUpdate"), xRow)
     If  getColumnIndex(spr,"InchargeInsert") > -1 then z7261.InchargeInsert = getDataM(spr, getColumnIndex(spr,"InchargeInsert"), xRow)
     If  getColumnIndex(spr,"InchargeUpdate") > -1 then z7261.InchargeUpdate = getDataM(spr, getColumnIndex(spr,"InchargeUpdate"), xRow)
     If  getColumnIndex(spr,"DateSync") > -1 then z7261.DateSync = getDataM(spr, getColumnIndex(spr,"DateSync"), xRow)
     If  getColumnIndex(spr,"CheckSync") > -1 then z7261.CheckSync = getDataM(spr, getColumnIndex(spr,"CheckSync"), xRow)
     If  getColumnIndex(spr,"Remark") > -1 then z7261.Remark = getDataM(spr, getColumnIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7261_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7261_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7261 As T7261_AREA, Job as String, CONTRACTID AS String, CONTRACSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7261_MOVE = False

Try
    If READ_PFK7261(CONTRACTID, CONTRACSEQ) = True Then
                z7261 = D7261
		K7261_MOVE = True
		else
	z7261 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7261")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "CONTRACTID":z7261.ContractID = Children(i).Code
   Case "CONTRACSEQ":z7261.ContracSeq = Children(i).Code
   Case "DSEQ":z7261.Dseq = Children(i).Code
   Case "MATERIALCODE":z7261.MaterialCode = Children(i).Code
   Case "COLORNAME":z7261.ColorName = Children(i).Code
   Case "COLORCODE":z7261.ColorCode = Children(i).Code
   Case "CUSTOMERCODE":z7261.CustomerCode = Children(i).Code
   Case "SESITE":z7261.seSite = Children(i).Code
   Case "CDSITE":z7261.cdSite = Children(i).Code
   Case "SEDEPARTMENT":z7261.seDepartment = Children(i).Code
   Case "CDDEPARTMENT":z7261.cdDepartment = Children(i).Code
   Case "SEFACTORY":z7261.seFactory = Children(i).Code
   Case "CDFACTORY":z7261.cdFactory = Children(i).Code
   Case "SEUNITPACKING":z7261.seUnitPacking = Children(i).Code
   Case "CDUNITPACKING":z7261.cdUnitPacking = Children(i).Code
   Case "QTYMOQ":z7261.QtyMOQ = Children(i).Code
   Case "QTYBASIC":z7261.QtyBasic = Children(i).Code
   Case "UNITBASECHECK":z7261.UnitBaseCheck = Children(i).Code
   Case "SEUNITMATERIAL":z7261.seUnitMaterial = Children(i).Code
   Case "CDUNITMATERIAL":z7261.cdUnitMaterial = Children(i).Code
   Case "PRICEMATERIALVND":z7261.PriceMaterialVND = Children(i).Code
   Case "SEUNITPRICE":z7261.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z7261.cdUnitPrice = Children(i).Code
   Case "PRICEMATERIALEX":z7261.PriceMaterialEX = Children(i).Code
   Case "PRICECHARGE":z7261.PriceCharge = Children(i).Code
   Case "DATEINSERT":z7261.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7261.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7261.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7261.InchargeUpdate = Children(i).Code
   Case "DATESYNC":z7261.DateSync = Children(i).Code
   Case "CHECKSYNC":z7261.CheckSync = Children(i).Code
   Case "REMARK":z7261.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "CONTRACTID":z7261.ContractID = Children(i).Data
   Case "CONTRACSEQ":z7261.ContracSeq = Children(i).Data
   Case "DSEQ":z7261.Dseq = Children(i).Data
   Case "MATERIALCODE":z7261.MaterialCode = Children(i).Data
   Case "COLORNAME":z7261.ColorName = Children(i).Data
   Case "COLORCODE":z7261.ColorCode = Children(i).Data
   Case "CUSTOMERCODE":z7261.CustomerCode = Children(i).Data
   Case "SESITE":z7261.seSite = Children(i).Data
   Case "CDSITE":z7261.cdSite = Children(i).Data
   Case "SEDEPARTMENT":z7261.seDepartment = Children(i).Data
   Case "CDDEPARTMENT":z7261.cdDepartment = Children(i).Data
   Case "SEFACTORY":z7261.seFactory = Children(i).Data
   Case "CDFACTORY":z7261.cdFactory = Children(i).Data
   Case "SEUNITPACKING":z7261.seUnitPacking = Children(i).Data
   Case "CDUNITPACKING":z7261.cdUnitPacking = Children(i).Data
   Case "QTYMOQ":z7261.QtyMOQ = Children(i).Data
   Case "QTYBASIC":z7261.QtyBasic = Children(i).Data
   Case "UNITBASECHECK":z7261.UnitBaseCheck = Children(i).Data
   Case "SEUNITMATERIAL":z7261.seUnitMaterial = Children(i).Data
   Case "CDUNITMATERIAL":z7261.cdUnitMaterial = Children(i).Data
   Case "PRICEMATERIALVND":z7261.PriceMaterialVND = Children(i).Data
   Case "SEUNITPRICE":z7261.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z7261.cdUnitPrice = Children(i).Data
   Case "PRICEMATERIALEX":z7261.PriceMaterialEX = Children(i).Data
   Case "PRICECHARGE":z7261.PriceCharge = Children(i).Data
   Case "DATEINSERT":z7261.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7261.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7261.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7261.InchargeUpdate = Children(i).Data
   Case "DATESYNC":z7261.DateSync = Children(i).Data
   Case "CHECKSYNC":z7261.CheckSync = Children(i).Data
   Case "REMARK":z7261.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7261_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7261_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7261 As T7261_AREA, Job as String, CheckClear as Boolean, CONTRACTID AS String, CONTRACSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7261_MOVE = False

Try
    If READ_PFK7261(CONTRACTID, CONTRACSEQ) = True Then
                z7261 = D7261
		K7261_MOVE = True
		else
	If CheckClear  = True then z7261 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7261")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "CONTRACTID":z7261.ContractID = Children(i).Code
   Case "CONTRACSEQ":z7261.ContracSeq = Children(i).Code
   Case "DSEQ":z7261.Dseq = Children(i).Code
   Case "MATERIALCODE":z7261.MaterialCode = Children(i).Code
   Case "COLORNAME":z7261.ColorName = Children(i).Code
   Case "COLORCODE":z7261.ColorCode = Children(i).Code
   Case "CUSTOMERCODE":z7261.CustomerCode = Children(i).Code
   Case "SESITE":z7261.seSite = Children(i).Code
   Case "CDSITE":z7261.cdSite = Children(i).Code
   Case "SEDEPARTMENT":z7261.seDepartment = Children(i).Code
   Case "CDDEPARTMENT":z7261.cdDepartment = Children(i).Code
   Case "SEFACTORY":z7261.seFactory = Children(i).Code
   Case "CDFACTORY":z7261.cdFactory = Children(i).Code
   Case "SEUNITPACKING":z7261.seUnitPacking = Children(i).Code
   Case "CDUNITPACKING":z7261.cdUnitPacking = Children(i).Code
   Case "QTYMOQ":z7261.QtyMOQ = Children(i).Code
   Case "QTYBASIC":z7261.QtyBasic = Children(i).Code
   Case "UNITBASECHECK":z7261.UnitBaseCheck = Children(i).Code
   Case "SEUNITMATERIAL":z7261.seUnitMaterial = Children(i).Code
   Case "CDUNITMATERIAL":z7261.cdUnitMaterial = Children(i).Code
   Case "PRICEMATERIALVND":z7261.PriceMaterialVND = Children(i).Code
   Case "SEUNITPRICE":z7261.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z7261.cdUnitPrice = Children(i).Code
   Case "PRICEMATERIALEX":z7261.PriceMaterialEX = Children(i).Code
   Case "PRICECHARGE":z7261.PriceCharge = Children(i).Code
   Case "DATEINSERT":z7261.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7261.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7261.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7261.InchargeUpdate = Children(i).Code
   Case "DATESYNC":z7261.DateSync = Children(i).Code
   Case "CHECKSYNC":z7261.CheckSync = Children(i).Code
   Case "REMARK":z7261.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "CONTRACTID":z7261.ContractID = Children(i).Data
   Case "CONTRACSEQ":z7261.ContracSeq = Children(i).Data
   Case "DSEQ":z7261.Dseq = Children(i).Data
   Case "MATERIALCODE":z7261.MaterialCode = Children(i).Data
   Case "COLORNAME":z7261.ColorName = Children(i).Data
   Case "COLORCODE":z7261.ColorCode = Children(i).Data
   Case "CUSTOMERCODE":z7261.CustomerCode = Children(i).Data
   Case "SESITE":z7261.seSite = Children(i).Data
   Case "CDSITE":z7261.cdSite = Children(i).Data
   Case "SEDEPARTMENT":z7261.seDepartment = Children(i).Data
   Case "CDDEPARTMENT":z7261.cdDepartment = Children(i).Data
   Case "SEFACTORY":z7261.seFactory = Children(i).Data
   Case "CDFACTORY":z7261.cdFactory = Children(i).Data
   Case "SEUNITPACKING":z7261.seUnitPacking = Children(i).Data
   Case "CDUNITPACKING":z7261.cdUnitPacking = Children(i).Data
   Case "QTYMOQ":z7261.QtyMOQ = Children(i).Data
   Case "QTYBASIC":z7261.QtyBasic = Children(i).Data
   Case "UNITBASECHECK":z7261.UnitBaseCheck = Children(i).Data
   Case "SEUNITMATERIAL":z7261.seUnitMaterial = Children(i).Data
   Case "CDUNITMATERIAL":z7261.cdUnitMaterial = Children(i).Data
   Case "PRICEMATERIALVND":z7261.PriceMaterialVND = Children(i).Data
   Case "SEUNITPRICE":z7261.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z7261.cdUnitPrice = Children(i).Data
   Case "PRICEMATERIALEX":z7261.PriceMaterialEX = Children(i).Data
   Case "PRICECHARGE":z7261.PriceCharge = Children(i).Data
   Case "DATEINSERT":z7261.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7261.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7261.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7261.InchargeUpdate = Children(i).Data
   Case "DATESYNC":z7261.DateSync = Children(i).Data
   Case "CHECKSYNC":z7261.CheckSync = Children(i).Data
   Case "REMARK":z7261.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7261_MOVE",vbCritical)
End Try
End Function 
    

'=========================================================================================================================================================
' DATA MOVE FORM NEW AREA
'=========================================================================================================================================================
Public Sub K7261_MOVE(ByRef a7261 As T7261_AREA, ByRef b7261 As T7261_AREA) 
Try
If trim$( a7261.ContractID ) = "" Then b7261.ContractID = ""  Else b7261.ContractID=a7261.ContractID
If trim$( a7261.ContracSeq ) = "" Then b7261.ContracSeq = ""  Else b7261.ContracSeq=a7261.ContracSeq
If trim$( a7261.Dseq ) = "" Then b7261.Dseq = ""  Else b7261.Dseq=a7261.Dseq
If trim$( a7261.MaterialCode ) = "" Then b7261.MaterialCode = ""  Else b7261.MaterialCode=a7261.MaterialCode
If trim$( a7261.ColorName ) = "" Then b7261.ColorName = ""  Else b7261.ColorName=a7261.ColorName
If trim$( a7261.ColorCode ) = "" Then b7261.ColorCode = ""  Else b7261.ColorCode=a7261.ColorCode
If trim$( a7261.CustomerCode ) = "" Then b7261.CustomerCode = ""  Else b7261.CustomerCode=a7261.CustomerCode
If trim$( a7261.seSite ) = "" Then b7261.seSite = ""  Else b7261.seSite=a7261.seSite
If trim$( a7261.cdSite ) = "" Then b7261.cdSite = ""  Else b7261.cdSite=a7261.cdSite
If trim$( a7261.seDepartment ) = "" Then b7261.seDepartment = ""  Else b7261.seDepartment=a7261.seDepartment
If trim$( a7261.cdDepartment ) = "" Then b7261.cdDepartment = ""  Else b7261.cdDepartment=a7261.cdDepartment
If trim$( a7261.seFactory ) = "" Then b7261.seFactory = ""  Else b7261.seFactory=a7261.seFactory
If trim$( a7261.cdFactory ) = "" Then b7261.cdFactory = ""  Else b7261.cdFactory=a7261.cdFactory
If trim$( a7261.seUnitPacking ) = "" Then b7261.seUnitPacking = ""  Else b7261.seUnitPacking=a7261.seUnitPacking
If trim$( a7261.cdUnitPacking ) = "" Then b7261.cdUnitPacking = ""  Else b7261.cdUnitPacking=a7261.cdUnitPacking
If trim$( a7261.QtyMOQ ) = "" Then b7261.QtyMOQ = ""  Else b7261.QtyMOQ=a7261.QtyMOQ
If trim$( a7261.QtyBasic ) = "" Then b7261.QtyBasic = ""  Else b7261.QtyBasic=a7261.QtyBasic
If trim$( a7261.UnitBaseCheck ) = "" Then b7261.UnitBaseCheck = ""  Else b7261.UnitBaseCheck=a7261.UnitBaseCheck
If trim$( a7261.seUnitMaterial ) = "" Then b7261.seUnitMaterial = ""  Else b7261.seUnitMaterial=a7261.seUnitMaterial
If trim$( a7261.cdUnitMaterial ) = "" Then b7261.cdUnitMaterial = ""  Else b7261.cdUnitMaterial=a7261.cdUnitMaterial
If trim$( a7261.PriceMaterialVND ) = "" Then b7261.PriceMaterialVND = ""  Else b7261.PriceMaterialVND=a7261.PriceMaterialVND
If trim$( a7261.seUnitPrice ) = "" Then b7261.seUnitPrice = ""  Else b7261.seUnitPrice=a7261.seUnitPrice
If trim$( a7261.cdUnitPrice ) = "" Then b7261.cdUnitPrice = ""  Else b7261.cdUnitPrice=a7261.cdUnitPrice
If trim$( a7261.PriceMaterialEX ) = "" Then b7261.PriceMaterialEX = ""  Else b7261.PriceMaterialEX=a7261.PriceMaterialEX
If trim$( a7261.PriceCharge ) = "" Then b7261.PriceCharge = ""  Else b7261.PriceCharge=a7261.PriceCharge
If trim$( a7261.DateInsert ) = "" Then b7261.DateInsert = ""  Else b7261.DateInsert=a7261.DateInsert
If trim$( a7261.DateUpdate ) = "" Then b7261.DateUpdate = ""  Else b7261.DateUpdate=a7261.DateUpdate
If trim$( a7261.InchargeInsert ) = "" Then b7261.InchargeInsert = ""  Else b7261.InchargeInsert=a7261.InchargeInsert
If trim$( a7261.InchargeUpdate ) = "" Then b7261.InchargeUpdate = ""  Else b7261.InchargeUpdate=a7261.InchargeUpdate
If trim$( a7261.DateSync ) = "" Then b7261.DateSync = ""  Else b7261.DateSync=a7261.DateSync
If trim$( a7261.CheckSync ) = "" Then b7261.CheckSync = ""  Else b7261.CheckSync=a7261.CheckSync
If trim$( a7261.Remark ) = "" Then b7261.Remark = ""  Else b7261.Remark=a7261.Remark
Catch ex As Exception
      Call MsgBoxP("K7261_MOVE",vbCritical)
End Try
End Sub 


End Module 
