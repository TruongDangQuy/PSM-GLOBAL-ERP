'=========================================================================================================================================================
'   TABLE : (PFK7260)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7260

Structure T7260_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	ContractID	 AS String	'			char(6)		*
Public 	DateAccept	 AS String	'			char(8)
Public 	CustomerCode	 AS String	'			char(6)
Public 	CheckProcessType	 AS String	'			char(1)
Public 	CheckIOType	 AS String	'			char(1)
Public 	CheckMaterialType	 AS String	'			char(1)
Public 	CheckMarketType	 AS String	'			char(1)
Public 	CheckRelationType	 AS String	'			char(1)
Public 	seDeliveryTerm	 AS String	'			char(3)
Public 	cdDeliveryTerm	 AS String	'			char(3)
Public 	seOrigin	 AS String	'			char(3)
Public 	cdOrigin	 AS String	'			char(3)
Public 	seCommercialTerm	 AS String	'			char(3)
Public 	cdCommercialTerm	 AS String	'			char(3)
Public 	sePaymentTerm	 AS String	'			char(3)
Public 	cdPaymentTerm	 AS String	'			char(3)
Public 	sePaymentCondition	 AS String	'			char(3)
Public 	cdPaymentCondition	 AS String	'			char(3)
Public 	sePaymentTime	 AS String	'			char(3)
Public 	cdPaymentTime	 AS String	'			char(3)
Public 	sePaymentDay	 AS String	'			char(3)
Public 	cdPaymentDay	 AS String	'			char(3)
Public 	seBuyingType	 AS String	'			char(3)
Public 	cdBuyingType	 AS String	'			char(3)
Public 	seUnitPrice	 AS String	'			char(3)
Public 	cdUnitPrice	 AS String	'			char(3)
Public 	DateExchange	 AS String	'			char(8)
Public 	PriceExchange	 AS Double	'			decimal
Public 	QualityRequest	 AS String	'			nvarchar(50)
Public 	ContractNo	 AS String	'			nvarchar(50)
Public 	Tolerance	 AS String	'			nvarchar(50)
Public 	Destination	 AS String	'			nvarchar(50)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(6)
Public 	InchargeUpdate	 AS String	'			char(6)
Public 	InchargePurchasing	 AS String	'			char(8)
Public 	CheckSupplierPrice	 AS String	'			char(1)
Public 	DateComplete	 AS String	'			char(8)
Public 	DateApproved	 AS String	'			char(8)
Public 	DateCancel	 AS String	'			char(8)
Public 	DatePending1	 AS String	'			char(8)
Public 	DatePending2	 AS String	'			char(8)
Public 	CheckUse	 AS String	'			char(1)
Public 	Remark	 AS String	'			nvarchar(1000)
'=========================================================================================================================================================
End structure

Public D7260 As T7260_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7260(CONTRACTID AS String) As Boolean
    READ_PFK7260 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7260 "
    SQL = SQL & " WHERE K7260_ContractID		 = '" & ContractID & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7260_CLEAR: GoTo SKIP_READ_PFK7260
                
    Call K7260_MOVE(rd)
    READ_PFK7260 = True

SKIP_READ_PFK7260:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7260",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7260(CONTRACTID AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7260 "
    SQL = SQL & " WHERE K7260_ContractID		 = '" & ContractID & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7260",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7260(z7260 As T7260_AREA) As Boolean
    WRITE_PFK7260 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7260)
 
    SQL = " INSERT INTO PFK7260 "
    SQL = SQL & " ( "
    SQL = SQL & " K7260_ContractID," 
    SQL = SQL & " K7260_DateAccept," 
    SQL = SQL & " K7260_CustomerCode," 
    SQL = SQL & " K7260_CheckProcessType," 
    SQL = SQL & " K7260_CheckIOType," 
    SQL = SQL & " K7260_CheckMaterialType," 
    SQL = SQL & " K7260_CheckMarketType," 
    SQL = SQL & " K7260_CheckRelationType," 
    SQL = SQL & " K7260_seDeliveryTerm," 
    SQL = SQL & " K7260_cdDeliveryTerm," 
    SQL = SQL & " K7260_seOrigin," 
    SQL = SQL & " K7260_cdOrigin," 
    SQL = SQL & " K7260_seCommercialTerm," 
    SQL = SQL & " K7260_cdCommercialTerm," 
    SQL = SQL & " K7260_sePaymentTerm," 
    SQL = SQL & " K7260_cdPaymentTerm," 
    SQL = SQL & " K7260_sePaymentCondition," 
    SQL = SQL & " K7260_cdPaymentCondition," 
    SQL = SQL & " K7260_sePaymentTime," 
    SQL = SQL & " K7260_cdPaymentTime," 
    SQL = SQL & " K7260_sePaymentDay," 
    SQL = SQL & " K7260_cdPaymentDay," 
    SQL = SQL & " K7260_seBuyingType," 
    SQL = SQL & " K7260_cdBuyingType," 
    SQL = SQL & " K7260_seUnitPrice," 
    SQL = SQL & " K7260_cdUnitPrice," 
    SQL = SQL & " K7260_DateExchange," 
    SQL = SQL & " K7260_PriceExchange," 
    SQL = SQL & " K7260_QualityRequest," 
    SQL = SQL & " K7260_ContractNo," 
    SQL = SQL & " K7260_Tolerance," 
    SQL = SQL & " K7260_Destination," 
    SQL = SQL & " K7260_DateInsert," 
    SQL = SQL & " K7260_DateUpdate," 
    SQL = SQL & " K7260_InchargeInsert," 
    SQL = SQL & " K7260_InchargeUpdate," 
    SQL = SQL & " K7260_InchargePurchasing," 
    SQL = SQL & " K7260_CheckSupplierPrice," 
    SQL = SQL & " K7260_DateComplete," 
    SQL = SQL & " K7260_DateApproved," 
    SQL = SQL & " K7260_DateCancel," 
    SQL = SQL & " K7260_DatePending1," 
    SQL = SQL & " K7260_DatePending2," 
    SQL = SQL & " K7260_CheckUse," 
    SQL = SQL & " K7260_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7260.ContractID) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.DateAccept) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.CustomerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.CheckProcessType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.CheckIOType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.CheckMaterialType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.CheckMarketType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.CheckRelationType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.seDeliveryTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.cdDeliveryTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.seOrigin) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.cdOrigin) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.seCommercialTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.cdCommercialTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.sePaymentTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.cdPaymentTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.sePaymentCondition) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.cdPaymentCondition) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.sePaymentTime) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.cdPaymentTime) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.sePaymentDay) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.cdPaymentDay) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.seBuyingType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.cdBuyingType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.seUnitPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.cdUnitPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.DateExchange) & "', "  
    SQL = SQL & "   " & FormatSQL(z7260.PriceExchange) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7260.QualityRequest) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.ContractNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.Tolerance) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.Destination) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.InchargePurchasing) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.CheckSupplierPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.DateComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.DateApproved) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.DateCancel) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.DatePending1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.DatePending2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.CheckUse) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7260.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7260 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7260",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7260(z7260 As T7260_AREA) As Boolean
    REWRITE_PFK7260 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7260)
   
    SQL = " UPDATE PFK7260 SET "
    SQL = SQL & "    K7260_DateAccept      = N'" & FormatSQL(z7260.DateAccept) & "', " 
    SQL = SQL & "    K7260_CustomerCode      = N'" & FormatSQL(z7260.CustomerCode) & "', " 
    SQL = SQL & "    K7260_CheckProcessType      = N'" & FormatSQL(z7260.CheckProcessType) & "', " 
    SQL = SQL & "    K7260_CheckIOType      = N'" & FormatSQL(z7260.CheckIOType) & "', " 
    SQL = SQL & "    K7260_CheckMaterialType      = N'" & FormatSQL(z7260.CheckMaterialType) & "', " 
    SQL = SQL & "    K7260_CheckMarketType      = N'" & FormatSQL(z7260.CheckMarketType) & "', " 
    SQL = SQL & "    K7260_CheckRelationType      = N'" & FormatSQL(z7260.CheckRelationType) & "', " 
    SQL = SQL & "    K7260_seDeliveryTerm      = N'" & FormatSQL(z7260.seDeliveryTerm) & "', " 
    SQL = SQL & "    K7260_cdDeliveryTerm      = N'" & FormatSQL(z7260.cdDeliveryTerm) & "', " 
    SQL = SQL & "    K7260_seOrigin      = N'" & FormatSQL(z7260.seOrigin) & "', " 
    SQL = SQL & "    K7260_cdOrigin      = N'" & FormatSQL(z7260.cdOrigin) & "', " 
    SQL = SQL & "    K7260_seCommercialTerm      = N'" & FormatSQL(z7260.seCommercialTerm) & "', " 
    SQL = SQL & "    K7260_cdCommercialTerm      = N'" & FormatSQL(z7260.cdCommercialTerm) & "', " 
    SQL = SQL & "    K7260_sePaymentTerm      = N'" & FormatSQL(z7260.sePaymentTerm) & "', " 
    SQL = SQL & "    K7260_cdPaymentTerm      = N'" & FormatSQL(z7260.cdPaymentTerm) & "', " 
    SQL = SQL & "    K7260_sePaymentCondition      = N'" & FormatSQL(z7260.sePaymentCondition) & "', " 
    SQL = SQL & "    K7260_cdPaymentCondition      = N'" & FormatSQL(z7260.cdPaymentCondition) & "', " 
    SQL = SQL & "    K7260_sePaymentTime      = N'" & FormatSQL(z7260.sePaymentTime) & "', " 
    SQL = SQL & "    K7260_cdPaymentTime      = N'" & FormatSQL(z7260.cdPaymentTime) & "', " 
    SQL = SQL & "    K7260_sePaymentDay      = N'" & FormatSQL(z7260.sePaymentDay) & "', " 
    SQL = SQL & "    K7260_cdPaymentDay      = N'" & FormatSQL(z7260.cdPaymentDay) & "', " 
    SQL = SQL & "    K7260_seBuyingType      = N'" & FormatSQL(z7260.seBuyingType) & "', " 
    SQL = SQL & "    K7260_cdBuyingType      = N'" & FormatSQL(z7260.cdBuyingType) & "', " 
    SQL = SQL & "    K7260_seUnitPrice      = N'" & FormatSQL(z7260.seUnitPrice) & "', " 
    SQL = SQL & "    K7260_cdUnitPrice      = N'" & FormatSQL(z7260.cdUnitPrice) & "', " 
    SQL = SQL & "    K7260_DateExchange      = N'" & FormatSQL(z7260.DateExchange) & "', " 
    SQL = SQL & "    K7260_PriceExchange      =  " & FormatSQL(z7260.PriceExchange) & ", " 
    SQL = SQL & "    K7260_QualityRequest      = N'" & FormatSQL(z7260.QualityRequest) & "', " 
    SQL = SQL & "    K7260_ContractNo      = N'" & FormatSQL(z7260.ContractNo) & "', " 
    SQL = SQL & "    K7260_Tolerance      = N'" & FormatSQL(z7260.Tolerance) & "', " 
    SQL = SQL & "    K7260_Destination      = N'" & FormatSQL(z7260.Destination) & "', " 
    SQL = SQL & "    K7260_DateInsert      = N'" & FormatSQL(z7260.DateInsert) & "', " 
    SQL = SQL & "    K7260_DateUpdate      = N'" & FormatSQL(z7260.DateUpdate) & "', " 
    SQL = SQL & "    K7260_InchargeInsert      = N'" & FormatSQL(z7260.InchargeInsert) & "', " 
    SQL = SQL & "    K7260_InchargeUpdate      = N'" & FormatSQL(z7260.InchargeUpdate) & "', " 
    SQL = SQL & "    K7260_InchargePurchasing      = N'" & FormatSQL(z7260.InchargePurchasing) & "', " 
    SQL = SQL & "    K7260_CheckSupplierPrice      = N'" & FormatSQL(z7260.CheckSupplierPrice) & "', " 
    SQL = SQL & "    K7260_DateComplete      = N'" & FormatSQL(z7260.DateComplete) & "', " 
    SQL = SQL & "    K7260_DateApproved      = N'" & FormatSQL(z7260.DateApproved) & "', " 
    SQL = SQL & "    K7260_DateCancel      = N'" & FormatSQL(z7260.DateCancel) & "', " 
    SQL = SQL & "    K7260_DatePending1      = N'" & FormatSQL(z7260.DatePending1) & "', " 
    SQL = SQL & "    K7260_DatePending2      = N'" & FormatSQL(z7260.DatePending2) & "', " 
    SQL = SQL & "    K7260_CheckUse      = N'" & FormatSQL(z7260.CheckUse) & "', " 
    SQL = SQL & "    K7260_Remark      = N'" & FormatSQL(z7260.Remark) & "'  " 
    SQL = SQL & " WHERE K7260_ContractID		 = '" & z7260.ContractID & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7260 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7260",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7260(z7260 As T7260_AREA) As Boolean
    DELETE_PFK7260 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7260 "
    SQL = SQL & " WHERE K7260_ContractID		 = '" & z7260.ContractID & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7260 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7260",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7260_CLEAR()
Try
    
   D7260.ContractID = ""
   D7260.DateAccept = ""
   D7260.CustomerCode = ""
   D7260.CheckProcessType = ""
   D7260.CheckIOType = ""
   D7260.CheckMaterialType = ""
   D7260.CheckMarketType = ""
   D7260.CheckRelationType = ""
   D7260.seDeliveryTerm = ""
   D7260.cdDeliveryTerm = ""
   D7260.seOrigin = ""
   D7260.cdOrigin = ""
   D7260.seCommercialTerm = ""
   D7260.cdCommercialTerm = ""
   D7260.sePaymentTerm = ""
   D7260.cdPaymentTerm = ""
   D7260.sePaymentCondition = ""
   D7260.cdPaymentCondition = ""
   D7260.sePaymentTime = ""
   D7260.cdPaymentTime = ""
   D7260.sePaymentDay = ""
   D7260.cdPaymentDay = ""
   D7260.seBuyingType = ""
   D7260.cdBuyingType = ""
   D7260.seUnitPrice = ""
   D7260.cdUnitPrice = ""
   D7260.DateExchange = ""
    D7260.PriceExchange = 0 
   D7260.QualityRequest = ""
   D7260.ContractNo = ""
   D7260.Tolerance = ""
   D7260.Destination = ""
   D7260.DateInsert = ""
   D7260.DateUpdate = ""
   D7260.InchargeInsert = ""
   D7260.InchargeUpdate = ""
   D7260.InchargePurchasing = ""
   D7260.CheckSupplierPrice = ""
   D7260.DateComplete = ""
   D7260.DateApproved = ""
   D7260.DateCancel = ""
   D7260.DatePending1 = ""
   D7260.DatePending2 = ""
   D7260.CheckUse = ""
   D7260.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7260_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7260 As T7260_AREA)
Try
    
    x7260.ContractID = trim$(  x7260.ContractID)
    x7260.DateAccept = trim$(  x7260.DateAccept)
    x7260.CustomerCode = trim$(  x7260.CustomerCode)
    x7260.CheckProcessType = trim$(  x7260.CheckProcessType)
    x7260.CheckIOType = trim$(  x7260.CheckIOType)
    x7260.CheckMaterialType = trim$(  x7260.CheckMaterialType)
    x7260.CheckMarketType = trim$(  x7260.CheckMarketType)
    x7260.CheckRelationType = trim$(  x7260.CheckRelationType)
    x7260.seDeliveryTerm = trim$(  x7260.seDeliveryTerm)
    x7260.cdDeliveryTerm = trim$(  x7260.cdDeliveryTerm)
    x7260.seOrigin = trim$(  x7260.seOrigin)
    x7260.cdOrigin = trim$(  x7260.cdOrigin)
    x7260.seCommercialTerm = trim$(  x7260.seCommercialTerm)
    x7260.cdCommercialTerm = trim$(  x7260.cdCommercialTerm)
    x7260.sePaymentTerm = trim$(  x7260.sePaymentTerm)
    x7260.cdPaymentTerm = trim$(  x7260.cdPaymentTerm)
    x7260.sePaymentCondition = trim$(  x7260.sePaymentCondition)
    x7260.cdPaymentCondition = trim$(  x7260.cdPaymentCondition)
    x7260.sePaymentTime = trim$(  x7260.sePaymentTime)
    x7260.cdPaymentTime = trim$(  x7260.cdPaymentTime)
    x7260.sePaymentDay = trim$(  x7260.sePaymentDay)
    x7260.cdPaymentDay = trim$(  x7260.cdPaymentDay)
    x7260.seBuyingType = trim$(  x7260.seBuyingType)
    x7260.cdBuyingType = trim$(  x7260.cdBuyingType)
    x7260.seUnitPrice = trim$(  x7260.seUnitPrice)
    x7260.cdUnitPrice = trim$(  x7260.cdUnitPrice)
    x7260.DateExchange = trim$(  x7260.DateExchange)
    x7260.PriceExchange = trim$(  x7260.PriceExchange)
    x7260.QualityRequest = trim$(  x7260.QualityRequest)
    x7260.ContractNo = trim$(  x7260.ContractNo)
    x7260.Tolerance = trim$(  x7260.Tolerance)
    x7260.Destination = trim$(  x7260.Destination)
    x7260.DateInsert = trim$(  x7260.DateInsert)
    x7260.DateUpdate = trim$(  x7260.DateUpdate)
    x7260.InchargeInsert = trim$(  x7260.InchargeInsert)
    x7260.InchargeUpdate = trim$(  x7260.InchargeUpdate)
    x7260.InchargePurchasing = trim$(  x7260.InchargePurchasing)
    x7260.CheckSupplierPrice = trim$(  x7260.CheckSupplierPrice)
    x7260.DateComplete = trim$(  x7260.DateComplete)
    x7260.DateApproved = trim$(  x7260.DateApproved)
    x7260.DateCancel = trim$(  x7260.DateCancel)
    x7260.DatePending1 = trim$(  x7260.DatePending1)
    x7260.DatePending2 = trim$(  x7260.DatePending2)
    x7260.CheckUse = trim$(  x7260.CheckUse)
    x7260.Remark = trim$(  x7260.Remark)
     
    If trim$( x7260.ContractID ) = "" Then x7260.ContractID = Space(1) 
    If trim$( x7260.DateAccept ) = "" Then x7260.DateAccept = Space(1) 
    If trim$( x7260.CustomerCode ) = "" Then x7260.CustomerCode = Space(1) 
    If trim$( x7260.CheckProcessType ) = "" Then x7260.CheckProcessType = Space(1) 
    If trim$( x7260.CheckIOType ) = "" Then x7260.CheckIOType = Space(1) 
    If trim$( x7260.CheckMaterialType ) = "" Then x7260.CheckMaterialType = Space(1) 
    If trim$( x7260.CheckMarketType ) = "" Then x7260.CheckMarketType = Space(1) 
    If trim$( x7260.CheckRelationType ) = "" Then x7260.CheckRelationType = Space(1) 
    If trim$( x7260.seDeliveryTerm ) = "" Then x7260.seDeliveryTerm = Space(1) 
    If trim$( x7260.cdDeliveryTerm ) = "" Then x7260.cdDeliveryTerm = Space(1) 
    If trim$( x7260.seOrigin ) = "" Then x7260.seOrigin = Space(1) 
    If trim$( x7260.cdOrigin ) = "" Then x7260.cdOrigin = Space(1) 
    If trim$( x7260.seCommercialTerm ) = "" Then x7260.seCommercialTerm = Space(1) 
    If trim$( x7260.cdCommercialTerm ) = "" Then x7260.cdCommercialTerm = Space(1) 
    If trim$( x7260.sePaymentTerm ) = "" Then x7260.sePaymentTerm = Space(1) 
    If trim$( x7260.cdPaymentTerm ) = "" Then x7260.cdPaymentTerm = Space(1) 
    If trim$( x7260.sePaymentCondition ) = "" Then x7260.sePaymentCondition = Space(1) 
    If trim$( x7260.cdPaymentCondition ) = "" Then x7260.cdPaymentCondition = Space(1) 
    If trim$( x7260.sePaymentTime ) = "" Then x7260.sePaymentTime = Space(1) 
    If trim$( x7260.cdPaymentTime ) = "" Then x7260.cdPaymentTime = Space(1) 
    If trim$( x7260.sePaymentDay ) = "" Then x7260.sePaymentDay = Space(1) 
    If trim$( x7260.cdPaymentDay ) = "" Then x7260.cdPaymentDay = Space(1) 
    If trim$( x7260.seBuyingType ) = "" Then x7260.seBuyingType = Space(1) 
    If trim$( x7260.cdBuyingType ) = "" Then x7260.cdBuyingType = Space(1) 
    If trim$( x7260.seUnitPrice ) = "" Then x7260.seUnitPrice = Space(1) 
    If trim$( x7260.cdUnitPrice ) = "" Then x7260.cdUnitPrice = Space(1) 
    If trim$( x7260.DateExchange ) = "" Then x7260.DateExchange = Space(1) 
    If trim$( x7260.PriceExchange ) = "" Then x7260.PriceExchange = 0 
    If trim$( x7260.QualityRequest ) = "" Then x7260.QualityRequest = Space(1) 
    If trim$( x7260.ContractNo ) = "" Then x7260.ContractNo = Space(1) 
    If trim$( x7260.Tolerance ) = "" Then x7260.Tolerance = Space(1) 
    If trim$( x7260.Destination ) = "" Then x7260.Destination = Space(1) 
    If trim$( x7260.DateInsert ) = "" Then x7260.DateInsert = Space(1) 
    If trim$( x7260.DateUpdate ) = "" Then x7260.DateUpdate = Space(1) 
    If trim$( x7260.InchargeInsert ) = "" Then x7260.InchargeInsert = Space(1) 
    If trim$( x7260.InchargeUpdate ) = "" Then x7260.InchargeUpdate = Space(1) 
    If trim$( x7260.InchargePurchasing ) = "" Then x7260.InchargePurchasing = Space(1) 
    If trim$( x7260.CheckSupplierPrice ) = "" Then x7260.CheckSupplierPrice = Space(1) 
    If trim$( x7260.DateComplete ) = "" Then x7260.DateComplete = Space(1) 
    If trim$( x7260.DateApproved ) = "" Then x7260.DateApproved = Space(1) 
    If trim$( x7260.DateCancel ) = "" Then x7260.DateCancel = Space(1) 
    If trim$( x7260.DatePending1 ) = "" Then x7260.DatePending1 = Space(1) 
    If trim$( x7260.DatePending2 ) = "" Then x7260.DatePending2 = Space(1) 
    If trim$( x7260.CheckUse ) = "" Then x7260.CheckUse = Space(1) 
    If trim$( x7260.Remark ) = "" Then x7260.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7260_MOVE(rs7260 As SqlClient.SqlDataReader)
Try

    call D7260_CLEAR()   

    If IsdbNull(rs7260!K7260_ContractID) = False Then D7260.ContractID = Trim$(rs7260!K7260_ContractID)
    If IsdbNull(rs7260!K7260_DateAccept) = False Then D7260.DateAccept = Trim$(rs7260!K7260_DateAccept)
    If IsdbNull(rs7260!K7260_CustomerCode) = False Then D7260.CustomerCode = Trim$(rs7260!K7260_CustomerCode)
    If IsdbNull(rs7260!K7260_CheckProcessType) = False Then D7260.CheckProcessType = Trim$(rs7260!K7260_CheckProcessType)
    If IsdbNull(rs7260!K7260_CheckIOType) = False Then D7260.CheckIOType = Trim$(rs7260!K7260_CheckIOType)
    If IsdbNull(rs7260!K7260_CheckMaterialType) = False Then D7260.CheckMaterialType = Trim$(rs7260!K7260_CheckMaterialType)
    If IsdbNull(rs7260!K7260_CheckMarketType) = False Then D7260.CheckMarketType = Trim$(rs7260!K7260_CheckMarketType)
    If IsdbNull(rs7260!K7260_CheckRelationType) = False Then D7260.CheckRelationType = Trim$(rs7260!K7260_CheckRelationType)
    If IsdbNull(rs7260!K7260_seDeliveryTerm) = False Then D7260.seDeliveryTerm = Trim$(rs7260!K7260_seDeliveryTerm)
    If IsdbNull(rs7260!K7260_cdDeliveryTerm) = False Then D7260.cdDeliveryTerm = Trim$(rs7260!K7260_cdDeliveryTerm)
    If IsdbNull(rs7260!K7260_seOrigin) = False Then D7260.seOrigin = Trim$(rs7260!K7260_seOrigin)
    If IsdbNull(rs7260!K7260_cdOrigin) = False Then D7260.cdOrigin = Trim$(rs7260!K7260_cdOrigin)
    If IsdbNull(rs7260!K7260_seCommercialTerm) = False Then D7260.seCommercialTerm = Trim$(rs7260!K7260_seCommercialTerm)
    If IsdbNull(rs7260!K7260_cdCommercialTerm) = False Then D7260.cdCommercialTerm = Trim$(rs7260!K7260_cdCommercialTerm)
    If IsdbNull(rs7260!K7260_sePaymentTerm) = False Then D7260.sePaymentTerm = Trim$(rs7260!K7260_sePaymentTerm)
    If IsdbNull(rs7260!K7260_cdPaymentTerm) = False Then D7260.cdPaymentTerm = Trim$(rs7260!K7260_cdPaymentTerm)
    If IsdbNull(rs7260!K7260_sePaymentCondition) = False Then D7260.sePaymentCondition = Trim$(rs7260!K7260_sePaymentCondition)
    If IsdbNull(rs7260!K7260_cdPaymentCondition) = False Then D7260.cdPaymentCondition = Trim$(rs7260!K7260_cdPaymentCondition)
    If IsdbNull(rs7260!K7260_sePaymentTime) = False Then D7260.sePaymentTime = Trim$(rs7260!K7260_sePaymentTime)
    If IsdbNull(rs7260!K7260_cdPaymentTime) = False Then D7260.cdPaymentTime = Trim$(rs7260!K7260_cdPaymentTime)
    If IsdbNull(rs7260!K7260_sePaymentDay) = False Then D7260.sePaymentDay = Trim$(rs7260!K7260_sePaymentDay)
    If IsdbNull(rs7260!K7260_cdPaymentDay) = False Then D7260.cdPaymentDay = Trim$(rs7260!K7260_cdPaymentDay)
    If IsdbNull(rs7260!K7260_seBuyingType) = False Then D7260.seBuyingType = Trim$(rs7260!K7260_seBuyingType)
    If IsdbNull(rs7260!K7260_cdBuyingType) = False Then D7260.cdBuyingType = Trim$(rs7260!K7260_cdBuyingType)
    If IsdbNull(rs7260!K7260_seUnitPrice) = False Then D7260.seUnitPrice = Trim$(rs7260!K7260_seUnitPrice)
    If IsdbNull(rs7260!K7260_cdUnitPrice) = False Then D7260.cdUnitPrice = Trim$(rs7260!K7260_cdUnitPrice)
    If IsdbNull(rs7260!K7260_DateExchange) = False Then D7260.DateExchange = Trim$(rs7260!K7260_DateExchange)
    If IsdbNull(rs7260!K7260_PriceExchange) = False Then D7260.PriceExchange = Trim$(rs7260!K7260_PriceExchange)
    If IsdbNull(rs7260!K7260_QualityRequest) = False Then D7260.QualityRequest = Trim$(rs7260!K7260_QualityRequest)
    If IsdbNull(rs7260!K7260_ContractNo) = False Then D7260.ContractNo = Trim$(rs7260!K7260_ContractNo)
    If IsdbNull(rs7260!K7260_Tolerance) = False Then D7260.Tolerance = Trim$(rs7260!K7260_Tolerance)
    If IsdbNull(rs7260!K7260_Destination) = False Then D7260.Destination = Trim$(rs7260!K7260_Destination)
    If IsdbNull(rs7260!K7260_DateInsert) = False Then D7260.DateInsert = Trim$(rs7260!K7260_DateInsert)
    If IsdbNull(rs7260!K7260_DateUpdate) = False Then D7260.DateUpdate = Trim$(rs7260!K7260_DateUpdate)
    If IsdbNull(rs7260!K7260_InchargeInsert) = False Then D7260.InchargeInsert = Trim$(rs7260!K7260_InchargeInsert)
    If IsdbNull(rs7260!K7260_InchargeUpdate) = False Then D7260.InchargeUpdate = Trim$(rs7260!K7260_InchargeUpdate)
    If IsdbNull(rs7260!K7260_InchargePurchasing) = False Then D7260.InchargePurchasing = Trim$(rs7260!K7260_InchargePurchasing)
    If IsdbNull(rs7260!K7260_CheckSupplierPrice) = False Then D7260.CheckSupplierPrice = Trim$(rs7260!K7260_CheckSupplierPrice)
    If IsdbNull(rs7260!K7260_DateComplete) = False Then D7260.DateComplete = Trim$(rs7260!K7260_DateComplete)
    If IsdbNull(rs7260!K7260_DateApproved) = False Then D7260.DateApproved = Trim$(rs7260!K7260_DateApproved)
    If IsdbNull(rs7260!K7260_DateCancel) = False Then D7260.DateCancel = Trim$(rs7260!K7260_DateCancel)
    If IsdbNull(rs7260!K7260_DatePending1) = False Then D7260.DatePending1 = Trim$(rs7260!K7260_DatePending1)
    If IsdbNull(rs7260!K7260_DatePending2) = False Then D7260.DatePending2 = Trim$(rs7260!K7260_DatePending2)
    If IsdbNull(rs7260!K7260_CheckUse) = False Then D7260.CheckUse = Trim$(rs7260!K7260_CheckUse)
    If IsdbNull(rs7260!K7260_Remark) = False Then D7260.Remark = Trim$(rs7260!K7260_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7260_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7260_MOVE(rs7260 As DataRow)
Try

    call D7260_CLEAR()   

    If IsdbNull(rs7260!K7260_ContractID) = False Then D7260.ContractID = Trim$(rs7260!K7260_ContractID)
    If IsdbNull(rs7260!K7260_DateAccept) = False Then D7260.DateAccept = Trim$(rs7260!K7260_DateAccept)
    If IsdbNull(rs7260!K7260_CustomerCode) = False Then D7260.CustomerCode = Trim$(rs7260!K7260_CustomerCode)
    If IsdbNull(rs7260!K7260_CheckProcessType) = False Then D7260.CheckProcessType = Trim$(rs7260!K7260_CheckProcessType)
    If IsdbNull(rs7260!K7260_CheckIOType) = False Then D7260.CheckIOType = Trim$(rs7260!K7260_CheckIOType)
    If IsdbNull(rs7260!K7260_CheckMaterialType) = False Then D7260.CheckMaterialType = Trim$(rs7260!K7260_CheckMaterialType)
    If IsdbNull(rs7260!K7260_CheckMarketType) = False Then D7260.CheckMarketType = Trim$(rs7260!K7260_CheckMarketType)
    If IsdbNull(rs7260!K7260_CheckRelationType) = False Then D7260.CheckRelationType = Trim$(rs7260!K7260_CheckRelationType)
    If IsdbNull(rs7260!K7260_seDeliveryTerm) = False Then D7260.seDeliveryTerm = Trim$(rs7260!K7260_seDeliveryTerm)
    If IsdbNull(rs7260!K7260_cdDeliveryTerm) = False Then D7260.cdDeliveryTerm = Trim$(rs7260!K7260_cdDeliveryTerm)
    If IsdbNull(rs7260!K7260_seOrigin) = False Then D7260.seOrigin = Trim$(rs7260!K7260_seOrigin)
    If IsdbNull(rs7260!K7260_cdOrigin) = False Then D7260.cdOrigin = Trim$(rs7260!K7260_cdOrigin)
    If IsdbNull(rs7260!K7260_seCommercialTerm) = False Then D7260.seCommercialTerm = Trim$(rs7260!K7260_seCommercialTerm)
    If IsdbNull(rs7260!K7260_cdCommercialTerm) = False Then D7260.cdCommercialTerm = Trim$(rs7260!K7260_cdCommercialTerm)
    If IsdbNull(rs7260!K7260_sePaymentTerm) = False Then D7260.sePaymentTerm = Trim$(rs7260!K7260_sePaymentTerm)
    If IsdbNull(rs7260!K7260_cdPaymentTerm) = False Then D7260.cdPaymentTerm = Trim$(rs7260!K7260_cdPaymentTerm)
    If IsdbNull(rs7260!K7260_sePaymentCondition) = False Then D7260.sePaymentCondition = Trim$(rs7260!K7260_sePaymentCondition)
    If IsdbNull(rs7260!K7260_cdPaymentCondition) = False Then D7260.cdPaymentCondition = Trim$(rs7260!K7260_cdPaymentCondition)
    If IsdbNull(rs7260!K7260_sePaymentTime) = False Then D7260.sePaymentTime = Trim$(rs7260!K7260_sePaymentTime)
    If IsdbNull(rs7260!K7260_cdPaymentTime) = False Then D7260.cdPaymentTime = Trim$(rs7260!K7260_cdPaymentTime)
    If IsdbNull(rs7260!K7260_sePaymentDay) = False Then D7260.sePaymentDay = Trim$(rs7260!K7260_sePaymentDay)
    If IsdbNull(rs7260!K7260_cdPaymentDay) = False Then D7260.cdPaymentDay = Trim$(rs7260!K7260_cdPaymentDay)
    If IsdbNull(rs7260!K7260_seBuyingType) = False Then D7260.seBuyingType = Trim$(rs7260!K7260_seBuyingType)
    If IsdbNull(rs7260!K7260_cdBuyingType) = False Then D7260.cdBuyingType = Trim$(rs7260!K7260_cdBuyingType)
    If IsdbNull(rs7260!K7260_seUnitPrice) = False Then D7260.seUnitPrice = Trim$(rs7260!K7260_seUnitPrice)
    If IsdbNull(rs7260!K7260_cdUnitPrice) = False Then D7260.cdUnitPrice = Trim$(rs7260!K7260_cdUnitPrice)
    If IsdbNull(rs7260!K7260_DateExchange) = False Then D7260.DateExchange = Trim$(rs7260!K7260_DateExchange)
    If IsdbNull(rs7260!K7260_PriceExchange) = False Then D7260.PriceExchange = Trim$(rs7260!K7260_PriceExchange)
    If IsdbNull(rs7260!K7260_QualityRequest) = False Then D7260.QualityRequest = Trim$(rs7260!K7260_QualityRequest)
    If IsdbNull(rs7260!K7260_ContractNo) = False Then D7260.ContractNo = Trim$(rs7260!K7260_ContractNo)
    If IsdbNull(rs7260!K7260_Tolerance) = False Then D7260.Tolerance = Trim$(rs7260!K7260_Tolerance)
    If IsdbNull(rs7260!K7260_Destination) = False Then D7260.Destination = Trim$(rs7260!K7260_Destination)
    If IsdbNull(rs7260!K7260_DateInsert) = False Then D7260.DateInsert = Trim$(rs7260!K7260_DateInsert)
    If IsdbNull(rs7260!K7260_DateUpdate) = False Then D7260.DateUpdate = Trim$(rs7260!K7260_DateUpdate)
    If IsdbNull(rs7260!K7260_InchargeInsert) = False Then D7260.InchargeInsert = Trim$(rs7260!K7260_InchargeInsert)
    If IsdbNull(rs7260!K7260_InchargeUpdate) = False Then D7260.InchargeUpdate = Trim$(rs7260!K7260_InchargeUpdate)
    If IsdbNull(rs7260!K7260_InchargePurchasing) = False Then D7260.InchargePurchasing = Trim$(rs7260!K7260_InchargePurchasing)
    If IsdbNull(rs7260!K7260_CheckSupplierPrice) = False Then D7260.CheckSupplierPrice = Trim$(rs7260!K7260_CheckSupplierPrice)
    If IsdbNull(rs7260!K7260_DateComplete) = False Then D7260.DateComplete = Trim$(rs7260!K7260_DateComplete)
    If IsdbNull(rs7260!K7260_DateApproved) = False Then D7260.DateApproved = Trim$(rs7260!K7260_DateApproved)
    If IsdbNull(rs7260!K7260_DateCancel) = False Then D7260.DateCancel = Trim$(rs7260!K7260_DateCancel)
    If IsdbNull(rs7260!K7260_DatePending1) = False Then D7260.DatePending1 = Trim$(rs7260!K7260_DatePending1)
    If IsdbNull(rs7260!K7260_DatePending2) = False Then D7260.DatePending2 = Trim$(rs7260!K7260_DatePending2)
    If IsdbNull(rs7260!K7260_CheckUse) = False Then D7260.CheckUse = Trim$(rs7260!K7260_CheckUse)
    If IsdbNull(rs7260!K7260_Remark) = False Then D7260.Remark = Trim$(rs7260!K7260_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7260_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7260_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7260 As T7260_AREA, CONTRACTID AS String) as Boolean

K7260_MOVE = False

Try
    If READ_PFK7260(CONTRACTID) = True Then
                z7260 = D7260
		K7260_MOVE = True
		else
	z7260 = nothing
     End If

     If  getColumIndex(spr,"ContractID") > -1 then z7260.ContractID = getDataM(spr, getColumIndex(spr,"ContractID"), xRow)
     If  getColumIndex(spr,"DateAccept") > -1 then z7260.DateAccept = getDataM(spr, getColumIndex(spr,"DateAccept"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z7260.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"CheckProcessType") > -1 then z7260.CheckProcessType = getDataM(spr, getColumIndex(spr,"CheckProcessType"), xRow)
     If  getColumIndex(spr,"CheckIOType") > -1 then z7260.CheckIOType = getDataM(spr, getColumIndex(spr,"CheckIOType"), xRow)
     If  getColumIndex(spr,"CheckMaterialType") > -1 then z7260.CheckMaterialType = getDataM(spr, getColumIndex(spr,"CheckMaterialType"), xRow)
     If  getColumIndex(spr,"CheckMarketType") > -1 then z7260.CheckMarketType = getDataM(spr, getColumIndex(spr,"CheckMarketType"), xRow)
     If  getColumIndex(spr,"CheckRelationType") > -1 then z7260.CheckRelationType = getDataM(spr, getColumIndex(spr,"CheckRelationType"), xRow)
     If  getColumIndex(spr,"seDeliveryTerm") > -1 then z7260.seDeliveryTerm = getDataM(spr, getColumIndex(spr,"seDeliveryTerm"), xRow)
     If  getColumIndex(spr,"cdDeliveryTerm") > -1 then z7260.cdDeliveryTerm = getDataM(spr, getColumIndex(spr,"cdDeliveryTerm"), xRow)
     If  getColumIndex(spr,"seOrigin") > -1 then z7260.seOrigin = getDataM(spr, getColumIndex(spr,"seOrigin"), xRow)
     If  getColumIndex(spr,"cdOrigin") > -1 then z7260.cdOrigin = getDataM(spr, getColumIndex(spr,"cdOrigin"), xRow)
     If  getColumIndex(spr,"seCommercialTerm") > -1 then z7260.seCommercialTerm = getDataM(spr, getColumIndex(spr,"seCommercialTerm"), xRow)
     If  getColumIndex(spr,"cdCommercialTerm") > -1 then z7260.cdCommercialTerm = getDataM(spr, getColumIndex(spr,"cdCommercialTerm"), xRow)
     If  getColumIndex(spr,"sePaymentTerm") > -1 then z7260.sePaymentTerm = getDataM(spr, getColumIndex(spr,"sePaymentTerm"), xRow)
     If  getColumIndex(spr,"cdPaymentTerm") > -1 then z7260.cdPaymentTerm = getDataM(spr, getColumIndex(spr,"cdPaymentTerm"), xRow)
     If  getColumIndex(spr,"sePaymentCondition") > -1 then z7260.sePaymentCondition = getDataM(spr, getColumIndex(spr,"sePaymentCondition"), xRow)
     If  getColumIndex(spr,"cdPaymentCondition") > -1 then z7260.cdPaymentCondition = getDataM(spr, getColumIndex(spr,"cdPaymentCondition"), xRow)
     If  getColumIndex(spr,"sePaymentTime") > -1 then z7260.sePaymentTime = getDataM(spr, getColumIndex(spr,"sePaymentTime"), xRow)
     If  getColumIndex(spr,"cdPaymentTime") > -1 then z7260.cdPaymentTime = getDataM(spr, getColumIndex(spr,"cdPaymentTime"), xRow)
     If  getColumIndex(spr,"sePaymentDay") > -1 then z7260.sePaymentDay = getDataM(spr, getColumIndex(spr,"sePaymentDay"), xRow)
     If  getColumIndex(spr,"cdPaymentDay") > -1 then z7260.cdPaymentDay = getDataM(spr, getColumIndex(spr,"cdPaymentDay"), xRow)
     If  getColumIndex(spr,"seBuyingType") > -1 then z7260.seBuyingType = getDataM(spr, getColumIndex(spr,"seBuyingType"), xRow)
     If  getColumIndex(spr,"cdBuyingType") > -1 then z7260.cdBuyingType = getDataM(spr, getColumIndex(spr,"cdBuyingType"), xRow)
     If  getColumIndex(spr,"seUnitPrice") > -1 then z7260.seUnitPrice = getDataM(spr, getColumIndex(spr,"seUnitPrice"), xRow)
     If  getColumIndex(spr,"cdUnitPrice") > -1 then z7260.cdUnitPrice = getDataM(spr, getColumIndex(spr,"cdUnitPrice"), xRow)
     If  getColumIndex(spr,"DateExchange") > -1 then z7260.DateExchange = getDataM(spr, getColumIndex(spr,"DateExchange"), xRow)
     If  getColumIndex(spr,"PriceExchange") > -1 then z7260.PriceExchange = getDataM(spr, getColumIndex(spr,"PriceExchange"), xRow)
     If  getColumIndex(spr,"QualityRequest") > -1 then z7260.QualityRequest = getDataM(spr, getColumIndex(spr,"QualityRequest"), xRow)
     If  getColumIndex(spr,"ContractNo") > -1 then z7260.ContractNo = getDataM(spr, getColumIndex(spr,"ContractNo"), xRow)
     If  getColumIndex(spr,"Tolerance") > -1 then z7260.Tolerance = getDataM(spr, getColumIndex(spr,"Tolerance"), xRow)
     If  getColumIndex(spr,"Destination") > -1 then z7260.Destination = getDataM(spr, getColumIndex(spr,"Destination"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7260.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7260.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7260.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7260.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"InchargePurchasing") > -1 then z7260.InchargePurchasing = getDataM(spr, getColumIndex(spr,"InchargePurchasing"), xRow)
     If  getColumIndex(spr,"CheckSupplierPrice") > -1 then z7260.CheckSupplierPrice = getDataM(spr, getColumIndex(spr,"CheckSupplierPrice"), xRow)
     If  getColumIndex(spr,"DateComplete") > -1 then z7260.DateComplete = getDataM(spr, getColumIndex(spr,"DateComplete"), xRow)
     If  getColumIndex(spr,"DateApproved") > -1 then z7260.DateApproved = getDataM(spr, getColumIndex(spr,"DateApproved"), xRow)
     If  getColumIndex(spr,"DateCancel") > -1 then z7260.DateCancel = getDataM(spr, getColumIndex(spr,"DateCancel"), xRow)
     If  getColumIndex(spr,"DatePending1") > -1 then z7260.DatePending1 = getDataM(spr, getColumIndex(spr,"DatePending1"), xRow)
     If  getColumIndex(spr,"DatePending2") > -1 then z7260.DatePending2 = getDataM(spr, getColumIndex(spr,"DatePending2"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7260.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7260.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7260_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7260_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7260 As T7260_AREA,CheckClear as Boolean,CONTRACTID AS String) as Boolean

K7260_MOVE = False

Try
    If READ_PFK7260(CONTRACTID) = True Then
                z7260 = D7260
		K7260_MOVE = True
		else
	If CheckClear  = True then z7260 = nothing
     End If

     If  getColumIndex(spr,"ContractID") > -1 then z7260.ContractID = getDataM(spr, getColumIndex(spr,"ContractID"), xRow)
     If  getColumIndex(spr,"DateAccept") > -1 then z7260.DateAccept = getDataM(spr, getColumIndex(spr,"DateAccept"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z7260.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"CheckProcessType") > -1 then z7260.CheckProcessType = getDataM(spr, getColumIndex(spr,"CheckProcessType"), xRow)
     If  getColumIndex(spr,"CheckIOType") > -1 then z7260.CheckIOType = getDataM(spr, getColumIndex(spr,"CheckIOType"), xRow)
     If  getColumIndex(spr,"CheckMaterialType") > -1 then z7260.CheckMaterialType = getDataM(spr, getColumIndex(spr,"CheckMaterialType"), xRow)
     If  getColumIndex(spr,"CheckMarketType") > -1 then z7260.CheckMarketType = getDataM(spr, getColumIndex(spr,"CheckMarketType"), xRow)
     If  getColumIndex(spr,"CheckRelationType") > -1 then z7260.CheckRelationType = getDataM(spr, getColumIndex(spr,"CheckRelationType"), xRow)
     If  getColumIndex(spr,"seDeliveryTerm") > -1 then z7260.seDeliveryTerm = getDataM(spr, getColumIndex(spr,"seDeliveryTerm"), xRow)
     If  getColumIndex(spr,"cdDeliveryTerm") > -1 then z7260.cdDeliveryTerm = getDataM(spr, getColumIndex(spr,"cdDeliveryTerm"), xRow)
     If  getColumIndex(spr,"seOrigin") > -1 then z7260.seOrigin = getDataM(spr, getColumIndex(spr,"seOrigin"), xRow)
     If  getColumIndex(spr,"cdOrigin") > -1 then z7260.cdOrigin = getDataM(spr, getColumIndex(spr,"cdOrigin"), xRow)
     If  getColumIndex(spr,"seCommercialTerm") > -1 then z7260.seCommercialTerm = getDataM(spr, getColumIndex(spr,"seCommercialTerm"), xRow)
     If  getColumIndex(spr,"cdCommercialTerm") > -1 then z7260.cdCommercialTerm = getDataM(spr, getColumIndex(spr,"cdCommercialTerm"), xRow)
     If  getColumIndex(spr,"sePaymentTerm") > -1 then z7260.sePaymentTerm = getDataM(spr, getColumIndex(spr,"sePaymentTerm"), xRow)
     If  getColumIndex(spr,"cdPaymentTerm") > -1 then z7260.cdPaymentTerm = getDataM(spr, getColumIndex(spr,"cdPaymentTerm"), xRow)
     If  getColumIndex(spr,"sePaymentCondition") > -1 then z7260.sePaymentCondition = getDataM(spr, getColumIndex(spr,"sePaymentCondition"), xRow)
     If  getColumIndex(spr,"cdPaymentCondition") > -1 then z7260.cdPaymentCondition = getDataM(spr, getColumIndex(spr,"cdPaymentCondition"), xRow)
     If  getColumIndex(spr,"sePaymentTime") > -1 then z7260.sePaymentTime = getDataM(spr, getColumIndex(spr,"sePaymentTime"), xRow)
     If  getColumIndex(spr,"cdPaymentTime") > -1 then z7260.cdPaymentTime = getDataM(spr, getColumIndex(spr,"cdPaymentTime"), xRow)
     If  getColumIndex(spr,"sePaymentDay") > -1 then z7260.sePaymentDay = getDataM(spr, getColumIndex(spr,"sePaymentDay"), xRow)
     If  getColumIndex(spr,"cdPaymentDay") > -1 then z7260.cdPaymentDay = getDataM(spr, getColumIndex(spr,"cdPaymentDay"), xRow)
     If  getColumIndex(spr,"seBuyingType") > -1 then z7260.seBuyingType = getDataM(spr, getColumIndex(spr,"seBuyingType"), xRow)
     If  getColumIndex(spr,"cdBuyingType") > -1 then z7260.cdBuyingType = getDataM(spr, getColumIndex(spr,"cdBuyingType"), xRow)
     If  getColumIndex(spr,"seUnitPrice") > -1 then z7260.seUnitPrice = getDataM(spr, getColumIndex(spr,"seUnitPrice"), xRow)
     If  getColumIndex(spr,"cdUnitPrice") > -1 then z7260.cdUnitPrice = getDataM(spr, getColumIndex(spr,"cdUnitPrice"), xRow)
     If  getColumIndex(spr,"DateExchange") > -1 then z7260.DateExchange = getDataM(spr, getColumIndex(spr,"DateExchange"), xRow)
     If  getColumIndex(spr,"PriceExchange") > -1 then z7260.PriceExchange = getDataM(spr, getColumIndex(spr,"PriceExchange"), xRow)
     If  getColumIndex(spr,"QualityRequest") > -1 then z7260.QualityRequest = getDataM(spr, getColumIndex(spr,"QualityRequest"), xRow)
     If  getColumIndex(spr,"ContractNo") > -1 then z7260.ContractNo = getDataM(spr, getColumIndex(spr,"ContractNo"), xRow)
     If  getColumIndex(spr,"Tolerance") > -1 then z7260.Tolerance = getDataM(spr, getColumIndex(spr,"Tolerance"), xRow)
     If  getColumIndex(spr,"Destination") > -1 then z7260.Destination = getDataM(spr, getColumIndex(spr,"Destination"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7260.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7260.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7260.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7260.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"InchargePurchasing") > -1 then z7260.InchargePurchasing = getDataM(spr, getColumIndex(spr,"InchargePurchasing"), xRow)
     If  getColumIndex(spr,"CheckSupplierPrice") > -1 then z7260.CheckSupplierPrice = getDataM(spr, getColumIndex(spr,"CheckSupplierPrice"), xRow)
     If  getColumIndex(spr,"DateComplete") > -1 then z7260.DateComplete = getDataM(spr, getColumIndex(spr,"DateComplete"), xRow)
     If  getColumIndex(spr,"DateApproved") > -1 then z7260.DateApproved = getDataM(spr, getColumIndex(spr,"DateApproved"), xRow)
     If  getColumIndex(spr,"DateCancel") > -1 then z7260.DateCancel = getDataM(spr, getColumIndex(spr,"DateCancel"), xRow)
     If  getColumIndex(spr,"DatePending1") > -1 then z7260.DatePending1 = getDataM(spr, getColumIndex(spr,"DatePending1"), xRow)
     If  getColumIndex(spr,"DatePending2") > -1 then z7260.DatePending2 = getDataM(spr, getColumIndex(spr,"DatePending2"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7260.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7260.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7260_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7260_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7260 As T7260_AREA, Job as String, CONTRACTID AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7260_MOVE = False

Try
    If READ_PFK7260(CONTRACTID) = True Then
                z7260 = D7260
		K7260_MOVE = True
		else
	z7260 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7260")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "CONTRACTID":z7260.ContractID = Children(i).Code
   Case "DATEACCEPT":z7260.DateAccept = Children(i).Code
   Case "CUSTOMERCODE":z7260.CustomerCode = Children(i).Code
   Case "CHECKPROCESSTYPE":z7260.CheckProcessType = Children(i).Code
   Case "CHECKIOTYPE":z7260.CheckIOType = Children(i).Code
   Case "CHECKMATERIALTYPE":z7260.CheckMaterialType = Children(i).Code
   Case "CHECKMARKETTYPE":z7260.CheckMarketType = Children(i).Code
   Case "CHECKRELATIONTYPE":z7260.CheckRelationType = Children(i).Code
   Case "SEDELIVERYTERM":z7260.seDeliveryTerm = Children(i).Code
   Case "CDDELIVERYTERM":z7260.cdDeliveryTerm = Children(i).Code
   Case "SEORIGIN":z7260.seOrigin = Children(i).Code
   Case "CDORIGIN":z7260.cdOrigin = Children(i).Code
   Case "SECOMMERCIALTERM":z7260.seCommercialTerm = Children(i).Code
   Case "CDCOMMERCIALTERM":z7260.cdCommercialTerm = Children(i).Code
   Case "SEPAYMENTTERM":z7260.sePaymentTerm = Children(i).Code
   Case "CDPAYMENTTERM":z7260.cdPaymentTerm = Children(i).Code
   Case "SEPAYMENTCONDITION":z7260.sePaymentCondition = Children(i).Code
   Case "CDPAYMENTCONDITION":z7260.cdPaymentCondition = Children(i).Code
   Case "SEPAYMENTTIME":z7260.sePaymentTime = Children(i).Code
   Case "CDPAYMENTTIME":z7260.cdPaymentTime = Children(i).Code
   Case "SEPAYMENTDAY":z7260.sePaymentDay = Children(i).Code
   Case "CDPAYMENTDAY":z7260.cdPaymentDay = Children(i).Code
   Case "SEBUYINGTYPE":z7260.seBuyingType = Children(i).Code
   Case "CDBUYINGTYPE":z7260.cdBuyingType = Children(i).Code
   Case "SEUNITPRICE":z7260.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z7260.cdUnitPrice = Children(i).Code
   Case "DATEEXCHANGE":z7260.DateExchange = Children(i).Code
   Case "PRICEEXCHANGE":z7260.PriceExchange = Children(i).Code
   Case "QUALITYREQUEST":z7260.QualityRequest = Children(i).Code
   Case "CONTRACTNO":z7260.ContractNo = Children(i).Code
   Case "TOLERANCE":z7260.Tolerance = Children(i).Code
   Case "DESTINATION":z7260.Destination = Children(i).Code
   Case "DATEINSERT":z7260.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7260.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7260.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7260.InchargeUpdate = Children(i).Code
   Case "INCHARGEPURCHASING":z7260.InchargePurchasing = Children(i).Code
   Case "CHECKSUPPLIERPRICE":z7260.CheckSupplierPrice = Children(i).Code
   Case "DATECOMPLETE":z7260.DateComplete = Children(i).Code
   Case "DATEAPPROVED":z7260.DateApproved = Children(i).Code
   Case "DATECANCEL":z7260.DateCancel = Children(i).Code
   Case "DATEPENDING1":z7260.DatePending1 = Children(i).Code
   Case "DATEPENDING2":z7260.DatePending2 = Children(i).Code
   Case "CHECKUSE":z7260.CheckUse = Children(i).Code
   Case "REMARK":z7260.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "CONTRACTID":z7260.ContractID = Children(i).Data
   Case "DATEACCEPT":z7260.DateAccept = Children(i).Data
   Case "CUSTOMERCODE":z7260.CustomerCode = Children(i).Data
   Case "CHECKPROCESSTYPE":z7260.CheckProcessType = Children(i).Data
   Case "CHECKIOTYPE":z7260.CheckIOType = Children(i).Data
   Case "CHECKMATERIALTYPE":z7260.CheckMaterialType = Children(i).Data
   Case "CHECKMARKETTYPE":z7260.CheckMarketType = Children(i).Data
   Case "CHECKRELATIONTYPE":z7260.CheckRelationType = Children(i).Data
   Case "SEDELIVERYTERM":z7260.seDeliveryTerm = Children(i).Data
   Case "CDDELIVERYTERM":z7260.cdDeliveryTerm = Children(i).Data
   Case "SEORIGIN":z7260.seOrigin = Children(i).Data
   Case "CDORIGIN":z7260.cdOrigin = Children(i).Data
   Case "SECOMMERCIALTERM":z7260.seCommercialTerm = Children(i).Data
   Case "CDCOMMERCIALTERM":z7260.cdCommercialTerm = Children(i).Data
   Case "SEPAYMENTTERM":z7260.sePaymentTerm = Children(i).Data
   Case "CDPAYMENTTERM":z7260.cdPaymentTerm = Children(i).Data
   Case "SEPAYMENTCONDITION":z7260.sePaymentCondition = Children(i).Data
   Case "CDPAYMENTCONDITION":z7260.cdPaymentCondition = Children(i).Data
   Case "SEPAYMENTTIME":z7260.sePaymentTime = Children(i).Data
   Case "CDPAYMENTTIME":z7260.cdPaymentTime = Children(i).Data
   Case "SEPAYMENTDAY":z7260.sePaymentDay = Children(i).Data
   Case "CDPAYMENTDAY":z7260.cdPaymentDay = Children(i).Data
   Case "SEBUYINGTYPE":z7260.seBuyingType = Children(i).Data
   Case "CDBUYINGTYPE":z7260.cdBuyingType = Children(i).Data
   Case "SEUNITPRICE":z7260.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z7260.cdUnitPrice = Children(i).Data
   Case "DATEEXCHANGE":z7260.DateExchange = Children(i).Data
   Case "PRICEEXCHANGE":z7260.PriceExchange = Children(i).Data
   Case "QUALITYREQUEST":z7260.QualityRequest = Children(i).Data
   Case "CONTRACTNO":z7260.ContractNo = Children(i).Data
   Case "TOLERANCE":z7260.Tolerance = Children(i).Data
   Case "DESTINATION":z7260.Destination = Children(i).Data
   Case "DATEINSERT":z7260.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7260.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7260.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7260.InchargeUpdate = Children(i).Data
   Case "INCHARGEPURCHASING":z7260.InchargePurchasing = Children(i).Data
   Case "CHECKSUPPLIERPRICE":z7260.CheckSupplierPrice = Children(i).Data
   Case "DATECOMPLETE":z7260.DateComplete = Children(i).Data
   Case "DATEAPPROVED":z7260.DateApproved = Children(i).Data
   Case "DATECANCEL":z7260.DateCancel = Children(i).Data
   Case "DATEPENDING1":z7260.DatePending1 = Children(i).Data
   Case "DATEPENDING2":z7260.DatePending2 = Children(i).Data
   Case "CHECKUSE":z7260.CheckUse = Children(i).Data
   Case "REMARK":z7260.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7260_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7260_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7260 As T7260_AREA, Job as String, CheckClear as Boolean, CONTRACTID AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7260_MOVE = False

Try
    If READ_PFK7260(CONTRACTID) = True Then
                z7260 = D7260
		K7260_MOVE = True
		else
	If CheckClear  = True then z7260 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7260")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "CONTRACTID":z7260.ContractID = Children(i).Code
   Case "DATEACCEPT":z7260.DateAccept = Children(i).Code
   Case "CUSTOMERCODE":z7260.CustomerCode = Children(i).Code
   Case "CHECKPROCESSTYPE":z7260.CheckProcessType = Children(i).Code
   Case "CHECKIOTYPE":z7260.CheckIOType = Children(i).Code
   Case "CHECKMATERIALTYPE":z7260.CheckMaterialType = Children(i).Code
   Case "CHECKMARKETTYPE":z7260.CheckMarketType = Children(i).Code
   Case "CHECKRELATIONTYPE":z7260.CheckRelationType = Children(i).Code
   Case "SEDELIVERYTERM":z7260.seDeliveryTerm = Children(i).Code
   Case "CDDELIVERYTERM":z7260.cdDeliveryTerm = Children(i).Code
   Case "SEORIGIN":z7260.seOrigin = Children(i).Code
   Case "CDORIGIN":z7260.cdOrigin = Children(i).Code
   Case "SECOMMERCIALTERM":z7260.seCommercialTerm = Children(i).Code
   Case "CDCOMMERCIALTERM":z7260.cdCommercialTerm = Children(i).Code
   Case "SEPAYMENTTERM":z7260.sePaymentTerm = Children(i).Code
   Case "CDPAYMENTTERM":z7260.cdPaymentTerm = Children(i).Code
   Case "SEPAYMENTCONDITION":z7260.sePaymentCondition = Children(i).Code
   Case "CDPAYMENTCONDITION":z7260.cdPaymentCondition = Children(i).Code
   Case "SEPAYMENTTIME":z7260.sePaymentTime = Children(i).Code
   Case "CDPAYMENTTIME":z7260.cdPaymentTime = Children(i).Code
   Case "SEPAYMENTDAY":z7260.sePaymentDay = Children(i).Code
   Case "CDPAYMENTDAY":z7260.cdPaymentDay = Children(i).Code
   Case "SEBUYINGTYPE":z7260.seBuyingType = Children(i).Code
   Case "CDBUYINGTYPE":z7260.cdBuyingType = Children(i).Code
   Case "SEUNITPRICE":z7260.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z7260.cdUnitPrice = Children(i).Code
   Case "DATEEXCHANGE":z7260.DateExchange = Children(i).Code
   Case "PRICEEXCHANGE":z7260.PriceExchange = Children(i).Code
   Case "QUALITYREQUEST":z7260.QualityRequest = Children(i).Code
   Case "CONTRACTNO":z7260.ContractNo = Children(i).Code
   Case "TOLERANCE":z7260.Tolerance = Children(i).Code
   Case "DESTINATION":z7260.Destination = Children(i).Code
   Case "DATEINSERT":z7260.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7260.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7260.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7260.InchargeUpdate = Children(i).Code
   Case "INCHARGEPURCHASING":z7260.InchargePurchasing = Children(i).Code
   Case "CHECKSUPPLIERPRICE":z7260.CheckSupplierPrice = Children(i).Code
   Case "DATECOMPLETE":z7260.DateComplete = Children(i).Code
   Case "DATEAPPROVED":z7260.DateApproved = Children(i).Code
   Case "DATECANCEL":z7260.DateCancel = Children(i).Code
   Case "DATEPENDING1":z7260.DatePending1 = Children(i).Code
   Case "DATEPENDING2":z7260.DatePending2 = Children(i).Code
   Case "CHECKUSE":z7260.CheckUse = Children(i).Code
   Case "REMARK":z7260.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "CONTRACTID":z7260.ContractID = Children(i).Data
   Case "DATEACCEPT":z7260.DateAccept = Children(i).Data
   Case "CUSTOMERCODE":z7260.CustomerCode = Children(i).Data
   Case "CHECKPROCESSTYPE":z7260.CheckProcessType = Children(i).Data
   Case "CHECKIOTYPE":z7260.CheckIOType = Children(i).Data
   Case "CHECKMATERIALTYPE":z7260.CheckMaterialType = Children(i).Data
   Case "CHECKMARKETTYPE":z7260.CheckMarketType = Children(i).Data
   Case "CHECKRELATIONTYPE":z7260.CheckRelationType = Children(i).Data
   Case "SEDELIVERYTERM":z7260.seDeliveryTerm = Children(i).Data
   Case "CDDELIVERYTERM":z7260.cdDeliveryTerm = Children(i).Data
   Case "SEORIGIN":z7260.seOrigin = Children(i).Data
   Case "CDORIGIN":z7260.cdOrigin = Children(i).Data
   Case "SECOMMERCIALTERM":z7260.seCommercialTerm = Children(i).Data
   Case "CDCOMMERCIALTERM":z7260.cdCommercialTerm = Children(i).Data
   Case "SEPAYMENTTERM":z7260.sePaymentTerm = Children(i).Data
   Case "CDPAYMENTTERM":z7260.cdPaymentTerm = Children(i).Data
   Case "SEPAYMENTCONDITION":z7260.sePaymentCondition = Children(i).Data
   Case "CDPAYMENTCONDITION":z7260.cdPaymentCondition = Children(i).Data
   Case "SEPAYMENTTIME":z7260.sePaymentTime = Children(i).Data
   Case "CDPAYMENTTIME":z7260.cdPaymentTime = Children(i).Data
   Case "SEPAYMENTDAY":z7260.sePaymentDay = Children(i).Data
   Case "CDPAYMENTDAY":z7260.cdPaymentDay = Children(i).Data
   Case "SEBUYINGTYPE":z7260.seBuyingType = Children(i).Data
   Case "CDBUYINGTYPE":z7260.cdBuyingType = Children(i).Data
   Case "SEUNITPRICE":z7260.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z7260.cdUnitPrice = Children(i).Data
   Case "DATEEXCHANGE":z7260.DateExchange = Children(i).Data
   Case "PRICEEXCHANGE":z7260.PriceExchange = Children(i).Data
   Case "QUALITYREQUEST":z7260.QualityRequest = Children(i).Data
   Case "CONTRACTNO":z7260.ContractNo = Children(i).Data
   Case "TOLERANCE":z7260.Tolerance = Children(i).Data
   Case "DESTINATION":z7260.Destination = Children(i).Data
   Case "DATEINSERT":z7260.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7260.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7260.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7260.InchargeUpdate = Children(i).Data
   Case "INCHARGEPURCHASING":z7260.InchargePurchasing = Children(i).Data
   Case "CHECKSUPPLIERPRICE":z7260.CheckSupplierPrice = Children(i).Data
   Case "DATECOMPLETE":z7260.DateComplete = Children(i).Data
   Case "DATEAPPROVED":z7260.DateApproved = Children(i).Data
   Case "DATECANCEL":z7260.DateCancel = Children(i).Data
   Case "DATEPENDING1":z7260.DatePending1 = Children(i).Data
   Case "DATEPENDING2":z7260.DatePending2 = Children(i).Data
   Case "CHECKUSE":z7260.CheckUse = Children(i).Data
   Case "REMARK":z7260.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7260_MOVE",vbCritical)
End Try
End Function 
    
End Module 
