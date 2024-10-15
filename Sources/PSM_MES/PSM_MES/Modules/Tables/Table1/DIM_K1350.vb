'=========================================================================================================================================================
'   TABLE : (PFK1350)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K1350

Structure T1350_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	PINo	 AS String	'			char(15)		*
Public 	seMarketType	 AS String	'			char(3)
Public 	cdMarketType	 AS String	'			char(3)
Public 	cdPaymentCondition	 AS String	'			char(3)
Public 	sePaymentCondition	 AS String	'			char(3)
Public 	InchargePI	 AS String	'			char(8)
Public 	DateShipping	 AS String	'			char(8)
Public 	DatePI	 AS String	'			char(8)
Public 	DateDuePI	 AS String	'			char(8)
Public 	DateRequestPI	 AS String	'			char(8)
Public 	DateApprovalPI	 AS String	'			char(8)
Public 	DateCancelPI	 AS String	'			char(8)
Public 	DateCompletePI	 AS String	'			char(8)
Public 	StatusPI	 AS String	'			char(1)
Public 	CustomerCode	 AS String	'			char(6)
Public 	BuyerCode	 AS String	'			char(6)
Public 	Attention	 AS String	'			nvarchar(200)
Public 	BankName	 AS String	'			nvarchar(100)
Public 	SwiftCode	 AS String	'			varchar(20)
Public 	AccountNo	 AS String	'			nvarchar(50)
Public 	AccountName	 AS String	'			nvarchar(100)
Public 	PriceExchange	 AS Double	'			decimal
Public 	DateExchange	 AS String	'			char(8)
Public 	seUnitPrice	 AS String	'			char(3)
Public 	cdUnitPrice	 AS String	'			char(3)
Public 	TotalQty	 AS Double	'			decimal
Public 	TotalAmount	 AS Double	'			decimal
Public 	DateInsert	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	Remark	 AS String	'			nvarchar(200)
'=========================================================================================================================================================
End structure

Public D1350 As T1350_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK1350(PINO AS String) As Boolean
    READ_PFK1350 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK1350 "
    SQL = SQL & " WHERE K1350_PINo		 = '" & PINo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D1350_CLEAR: GoTo SKIP_READ_PFK1350
                
    Call K1350_MOVE(rd)
    READ_PFK1350 = True

SKIP_READ_PFK1350:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK1350",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK1350(PINO AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK1350 "
    SQL = SQL & " WHERE K1350_PINo		 = '" & PINo & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK1350",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK1350(z1350 As T1350_AREA) As Boolean
    WRITE_PFK1350 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z1350)
 
    SQL = " INSERT INTO PFK1350 "
    SQL = SQL & " ( "
    SQL = SQL & " K1350_PINo," 
    SQL = SQL & " K1350_seMarketType," 
    SQL = SQL & " K1350_cdMarketType," 
    SQL = SQL & " K1350_cdPaymentCondition," 
    SQL = SQL & " K1350_sePaymentCondition," 
    SQL = SQL & " K1350_InchargePI," 
    SQL = SQL & " K1350_DateShipping," 
    SQL = SQL & " K1350_DatePI," 
    SQL = SQL & " K1350_DateDuePI," 
    SQL = SQL & " K1350_DateRequestPI," 
    SQL = SQL & " K1350_DateApprovalPI," 
    SQL = SQL & " K1350_DateCancelPI," 
    SQL = SQL & " K1350_DateCompletePI," 
    SQL = SQL & " K1350_StatusPI," 
    SQL = SQL & " K1350_CustomerCode," 
    SQL = SQL & " K1350_BuyerCode," 
    SQL = SQL & " K1350_Attention," 
    SQL = SQL & " K1350_BankName," 
    SQL = SQL & " K1350_SwiftCode," 
    SQL = SQL & " K1350_AccountNo," 
    SQL = SQL & " K1350_AccountName," 
    SQL = SQL & " K1350_PriceExchange," 
    SQL = SQL & " K1350_DateExchange," 
    SQL = SQL & " K1350_seUnitPrice," 
    SQL = SQL & " K1350_cdUnitPrice," 
    SQL = SQL & " K1350_TotalQty," 
    SQL = SQL & " K1350_TotalAmount," 
    SQL = SQL & " K1350_DateInsert," 
    SQL = SQL & " K1350_InchargeInsert," 
    SQL = SQL & " K1350_DateUpdate," 
    SQL = SQL & " K1350_InchargeUpdate," 
    SQL = SQL & " K1350_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z1350.PINo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1350.seMarketType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1350.cdMarketType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1350.cdPaymentCondition) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1350.sePaymentCondition) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1350.InchargePI) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1350.DateShipping) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1350.DatePI) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1350.DateDuePI) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1350.DateRequestPI) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1350.DateApprovalPI) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1350.DateCancelPI) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1350.DateCompletePI) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1350.StatusPI) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1350.CustomerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1350.BuyerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1350.Attention) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1350.BankName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1350.SwiftCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1350.AccountNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1350.AccountName) & "', "  
    SQL = SQL & "   " & FormatSQL(z1350.PriceExchange) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z1350.DateExchange) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1350.seUnitPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1350.cdUnitPrice) & "', "  
    SQL = SQL & "   " & FormatSQL(z1350.TotalQty) & ", "  
    SQL = SQL & "   " & FormatSQL(z1350.TotalAmount) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z1350.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1350.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1350.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1350.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1350.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK1350 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK1350",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK1350(z1350 As T1350_AREA) As Boolean
    REWRITE_PFK1350 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z1350)
   
    SQL = " UPDATE PFK1350 SET "
    SQL = SQL & "    K1350_seMarketType      = N'" & FormatSQL(z1350.seMarketType) & "', " 
    SQL = SQL & "    K1350_cdMarketType      = N'" & FormatSQL(z1350.cdMarketType) & "', " 
    SQL = SQL & "    K1350_cdPaymentCondition      = N'" & FormatSQL(z1350.cdPaymentCondition) & "', " 
    SQL = SQL & "    K1350_sePaymentCondition      = N'" & FormatSQL(z1350.sePaymentCondition) & "', " 
    SQL = SQL & "    K1350_InchargePI      = N'" & FormatSQL(z1350.InchargePI) & "', " 
    SQL = SQL & "    K1350_DateShipping      = N'" & FormatSQL(z1350.DateShipping) & "', " 
    SQL = SQL & "    K1350_DatePI      = N'" & FormatSQL(z1350.DatePI) & "', " 
    SQL = SQL & "    K1350_DateDuePI      = N'" & FormatSQL(z1350.DateDuePI) & "', " 
    SQL = SQL & "    K1350_DateRequestPI      = N'" & FormatSQL(z1350.DateRequestPI) & "', " 
    SQL = SQL & "    K1350_DateApprovalPI      = N'" & FormatSQL(z1350.DateApprovalPI) & "', " 
    SQL = SQL & "    K1350_DateCancelPI      = N'" & FormatSQL(z1350.DateCancelPI) & "', " 
    SQL = SQL & "    K1350_DateCompletePI      = N'" & FormatSQL(z1350.DateCompletePI) & "', " 
    SQL = SQL & "    K1350_StatusPI      = N'" & FormatSQL(z1350.StatusPI) & "', " 
    SQL = SQL & "    K1350_CustomerCode      = N'" & FormatSQL(z1350.CustomerCode) & "', " 
    SQL = SQL & "    K1350_BuyerCode      = N'" & FormatSQL(z1350.BuyerCode) & "', " 
    SQL = SQL & "    K1350_Attention      = N'" & FormatSQL(z1350.Attention) & "', " 
    SQL = SQL & "    K1350_BankName      = N'" & FormatSQL(z1350.BankName) & "', " 
    SQL = SQL & "    K1350_SwiftCode      = N'" & FormatSQL(z1350.SwiftCode) & "', " 
    SQL = SQL & "    K1350_AccountNo      = N'" & FormatSQL(z1350.AccountNo) & "', " 
    SQL = SQL & "    K1350_AccountName      = N'" & FormatSQL(z1350.AccountName) & "', " 
    SQL = SQL & "    K1350_PriceExchange      =  " & FormatSQL(z1350.PriceExchange) & ", " 
    SQL = SQL & "    K1350_DateExchange      = N'" & FormatSQL(z1350.DateExchange) & "', " 
    SQL = SQL & "    K1350_seUnitPrice      = N'" & FormatSQL(z1350.seUnitPrice) & "', " 
    SQL = SQL & "    K1350_cdUnitPrice      = N'" & FormatSQL(z1350.cdUnitPrice) & "', " 
    SQL = SQL & "    K1350_TotalQty      =  " & FormatSQL(z1350.TotalQty) & ", " 
    SQL = SQL & "    K1350_TotalAmount      =  " & FormatSQL(z1350.TotalAmount) & ", " 
    SQL = SQL & "    K1350_DateInsert      = N'" & FormatSQL(z1350.DateInsert) & "', " 
    SQL = SQL & "    K1350_InchargeInsert      = N'" & FormatSQL(z1350.InchargeInsert) & "', " 
    SQL = SQL & "    K1350_DateUpdate      = N'" & FormatSQL(z1350.DateUpdate) & "', " 
    SQL = SQL & "    K1350_InchargeUpdate      = N'" & FormatSQL(z1350.InchargeUpdate) & "', " 
    SQL = SQL & "    K1350_Remark      = N'" & FormatSQL(z1350.Remark) & "'  " 
    SQL = SQL & " WHERE K1350_PINo		 = '" & z1350.PINo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK1350 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK1350",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK1350(z1350 As T1350_AREA) As Boolean
    DELETE_PFK1350 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK1350 "
    SQL = SQL & " WHERE K1350_PINo		 = '" & z1350.PINo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK1350 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK1350",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D1350_CLEAR()
Try
    
   D1350.PINo = ""
   D1350.seMarketType = ""
   D1350.cdMarketType = ""
   D1350.cdPaymentCondition = ""
   D1350.sePaymentCondition = ""
   D1350.InchargePI = ""
   D1350.DateShipping = ""
   D1350.DatePI = ""
   D1350.DateDuePI = ""
   D1350.DateRequestPI = ""
   D1350.DateApprovalPI = ""
   D1350.DateCancelPI = ""
   D1350.DateCompletePI = ""
   D1350.StatusPI = ""
   D1350.CustomerCode = ""
   D1350.BuyerCode = ""
   D1350.Attention = ""
   D1350.BankName = ""
   D1350.SwiftCode = ""
   D1350.AccountNo = ""
   D1350.AccountName = ""
    D1350.PriceExchange = 0 
   D1350.DateExchange = ""
   D1350.seUnitPrice = ""
   D1350.cdUnitPrice = ""
    D1350.TotalQty = 0 
    D1350.TotalAmount = 0 
   D1350.DateInsert = ""
   D1350.InchargeInsert = ""
   D1350.DateUpdate = ""
   D1350.InchargeUpdate = ""
   D1350.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D1350_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x1350 As T1350_AREA)
Try
    
    x1350.PINo = trim$(  x1350.PINo)
    x1350.seMarketType = trim$(  x1350.seMarketType)
    x1350.cdMarketType = trim$(  x1350.cdMarketType)
    x1350.cdPaymentCondition = trim$(  x1350.cdPaymentCondition)
    x1350.sePaymentCondition = trim$(  x1350.sePaymentCondition)
    x1350.InchargePI = trim$(  x1350.InchargePI)
    x1350.DateShipping = trim$(  x1350.DateShipping)
    x1350.DatePI = trim$(  x1350.DatePI)
    x1350.DateDuePI = trim$(  x1350.DateDuePI)
    x1350.DateRequestPI = trim$(  x1350.DateRequestPI)
    x1350.DateApprovalPI = trim$(  x1350.DateApprovalPI)
    x1350.DateCancelPI = trim$(  x1350.DateCancelPI)
    x1350.DateCompletePI = trim$(  x1350.DateCompletePI)
    x1350.StatusPI = trim$(  x1350.StatusPI)
    x1350.CustomerCode = trim$(  x1350.CustomerCode)
    x1350.BuyerCode = trim$(  x1350.BuyerCode)
    x1350.Attention = trim$(  x1350.Attention)
    x1350.BankName = trim$(  x1350.BankName)
    x1350.SwiftCode = trim$(  x1350.SwiftCode)
    x1350.AccountNo = trim$(  x1350.AccountNo)
    x1350.AccountName = trim$(  x1350.AccountName)
    x1350.PriceExchange = trim$(  x1350.PriceExchange)
    x1350.DateExchange = trim$(  x1350.DateExchange)
    x1350.seUnitPrice = trim$(  x1350.seUnitPrice)
    x1350.cdUnitPrice = trim$(  x1350.cdUnitPrice)
    x1350.TotalQty = trim$(  x1350.TotalQty)
    x1350.TotalAmount = trim$(  x1350.TotalAmount)
    x1350.DateInsert = trim$(  x1350.DateInsert)
    x1350.InchargeInsert = trim$(  x1350.InchargeInsert)
    x1350.DateUpdate = trim$(  x1350.DateUpdate)
    x1350.InchargeUpdate = trim$(  x1350.InchargeUpdate)
    x1350.Remark = trim$(  x1350.Remark)
     
    If trim$( x1350.PINo ) = "" Then x1350.PINo = Space(1) 
    If trim$( x1350.seMarketType ) = "" Then x1350.seMarketType = Space(1) 
    If trim$( x1350.cdMarketType ) = "" Then x1350.cdMarketType = Space(1) 
    If trim$( x1350.cdPaymentCondition ) = "" Then x1350.cdPaymentCondition = Space(1) 
    If trim$( x1350.sePaymentCondition ) = "" Then x1350.sePaymentCondition = Space(1) 
    If trim$( x1350.InchargePI ) = "" Then x1350.InchargePI = Space(1) 
    If trim$( x1350.DateShipping ) = "" Then x1350.DateShipping = Space(1) 
    If trim$( x1350.DatePI ) = "" Then x1350.DatePI = Space(1) 
    If trim$( x1350.DateDuePI ) = "" Then x1350.DateDuePI = Space(1) 
    If trim$( x1350.DateRequestPI ) = "" Then x1350.DateRequestPI = Space(1) 
    If trim$( x1350.DateApprovalPI ) = "" Then x1350.DateApprovalPI = Space(1) 
    If trim$( x1350.DateCancelPI ) = "" Then x1350.DateCancelPI = Space(1) 
    If trim$( x1350.DateCompletePI ) = "" Then x1350.DateCompletePI = Space(1) 
    If trim$( x1350.StatusPI ) = "" Then x1350.StatusPI = Space(1) 
    If trim$( x1350.CustomerCode ) = "" Then x1350.CustomerCode = Space(1) 
    If trim$( x1350.BuyerCode ) = "" Then x1350.BuyerCode = Space(1) 
    If trim$( x1350.Attention ) = "" Then x1350.Attention = Space(1) 
    If trim$( x1350.BankName ) = "" Then x1350.BankName = Space(1) 
    If trim$( x1350.SwiftCode ) = "" Then x1350.SwiftCode = Space(1) 
    If trim$( x1350.AccountNo ) = "" Then x1350.AccountNo = Space(1) 
    If trim$( x1350.AccountName ) = "" Then x1350.AccountName = Space(1) 
    If trim$( x1350.PriceExchange ) = "" Then x1350.PriceExchange = 0 
    If trim$( x1350.DateExchange ) = "" Then x1350.DateExchange = Space(1) 
    If trim$( x1350.seUnitPrice ) = "" Then x1350.seUnitPrice = Space(1) 
    If trim$( x1350.cdUnitPrice ) = "" Then x1350.cdUnitPrice = Space(1) 
    If trim$( x1350.TotalQty ) = "" Then x1350.TotalQty = 0 
    If trim$( x1350.TotalAmount ) = "" Then x1350.TotalAmount = 0 
    If trim$( x1350.DateInsert ) = "" Then x1350.DateInsert = Space(1) 
    If trim$( x1350.InchargeInsert ) = "" Then x1350.InchargeInsert = Space(1) 
    If trim$( x1350.DateUpdate ) = "" Then x1350.DateUpdate = Space(1) 
    If trim$( x1350.InchargeUpdate ) = "" Then x1350.InchargeUpdate = Space(1) 
    If trim$( x1350.Remark ) = "" Then x1350.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K1350_MOVE(rs1350 As SqlClient.SqlDataReader)
Try

    call D1350_CLEAR()   

    If IsdbNull(rs1350!K1350_PINo) = False Then D1350.PINo = Trim$(rs1350!K1350_PINo)
    If IsdbNull(rs1350!K1350_seMarketType) = False Then D1350.seMarketType = Trim$(rs1350!K1350_seMarketType)
    If IsdbNull(rs1350!K1350_cdMarketType) = False Then D1350.cdMarketType = Trim$(rs1350!K1350_cdMarketType)
    If IsdbNull(rs1350!K1350_cdPaymentCondition) = False Then D1350.cdPaymentCondition = Trim$(rs1350!K1350_cdPaymentCondition)
    If IsdbNull(rs1350!K1350_sePaymentCondition) = False Then D1350.sePaymentCondition = Trim$(rs1350!K1350_sePaymentCondition)
    If IsdbNull(rs1350!K1350_InchargePI) = False Then D1350.InchargePI = Trim$(rs1350!K1350_InchargePI)
    If IsdbNull(rs1350!K1350_DateShipping) = False Then D1350.DateShipping = Trim$(rs1350!K1350_DateShipping)
    If IsdbNull(rs1350!K1350_DatePI) = False Then D1350.DatePI = Trim$(rs1350!K1350_DatePI)
    If IsdbNull(rs1350!K1350_DateDuePI) = False Then D1350.DateDuePI = Trim$(rs1350!K1350_DateDuePI)
    If IsdbNull(rs1350!K1350_DateRequestPI) = False Then D1350.DateRequestPI = Trim$(rs1350!K1350_DateRequestPI)
    If IsdbNull(rs1350!K1350_DateApprovalPI) = False Then D1350.DateApprovalPI = Trim$(rs1350!K1350_DateApprovalPI)
    If IsdbNull(rs1350!K1350_DateCancelPI) = False Then D1350.DateCancelPI = Trim$(rs1350!K1350_DateCancelPI)
    If IsdbNull(rs1350!K1350_DateCompletePI) = False Then D1350.DateCompletePI = Trim$(rs1350!K1350_DateCompletePI)
    If IsdbNull(rs1350!K1350_StatusPI) = False Then D1350.StatusPI = Trim$(rs1350!K1350_StatusPI)
    If IsdbNull(rs1350!K1350_CustomerCode) = False Then D1350.CustomerCode = Trim$(rs1350!K1350_CustomerCode)
    If IsdbNull(rs1350!K1350_BuyerCode) = False Then D1350.BuyerCode = Trim$(rs1350!K1350_BuyerCode)
    If IsdbNull(rs1350!K1350_Attention) = False Then D1350.Attention = Trim$(rs1350!K1350_Attention)
    If IsdbNull(rs1350!K1350_BankName) = False Then D1350.BankName = Trim$(rs1350!K1350_BankName)
    If IsdbNull(rs1350!K1350_SwiftCode) = False Then D1350.SwiftCode = Trim$(rs1350!K1350_SwiftCode)
    If IsdbNull(rs1350!K1350_AccountNo) = False Then D1350.AccountNo = Trim$(rs1350!K1350_AccountNo)
    If IsdbNull(rs1350!K1350_AccountName) = False Then D1350.AccountName = Trim$(rs1350!K1350_AccountName)
    If IsdbNull(rs1350!K1350_PriceExchange) = False Then D1350.PriceExchange = Trim$(rs1350!K1350_PriceExchange)
    If IsdbNull(rs1350!K1350_DateExchange) = False Then D1350.DateExchange = Trim$(rs1350!K1350_DateExchange)
    If IsdbNull(rs1350!K1350_seUnitPrice) = False Then D1350.seUnitPrice = Trim$(rs1350!K1350_seUnitPrice)
    If IsdbNull(rs1350!K1350_cdUnitPrice) = False Then D1350.cdUnitPrice = Trim$(rs1350!K1350_cdUnitPrice)
    If IsdbNull(rs1350!K1350_TotalQty) = False Then D1350.TotalQty = Trim$(rs1350!K1350_TotalQty)
    If IsdbNull(rs1350!K1350_TotalAmount) = False Then D1350.TotalAmount = Trim$(rs1350!K1350_TotalAmount)
    If IsdbNull(rs1350!K1350_DateInsert) = False Then D1350.DateInsert = Trim$(rs1350!K1350_DateInsert)
    If IsdbNull(rs1350!K1350_InchargeInsert) = False Then D1350.InchargeInsert = Trim$(rs1350!K1350_InchargeInsert)
    If IsdbNull(rs1350!K1350_DateUpdate) = False Then D1350.DateUpdate = Trim$(rs1350!K1350_DateUpdate)
    If IsdbNull(rs1350!K1350_InchargeUpdate) = False Then D1350.InchargeUpdate = Trim$(rs1350!K1350_InchargeUpdate)
    If IsdbNull(rs1350!K1350_Remark) = False Then D1350.Remark = Trim$(rs1350!K1350_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K1350_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K1350_MOVE(rs1350 As DataRow)
Try

    call D1350_CLEAR()   

    If IsdbNull(rs1350!K1350_PINo) = False Then D1350.PINo = Trim$(rs1350!K1350_PINo)
    If IsdbNull(rs1350!K1350_seMarketType) = False Then D1350.seMarketType = Trim$(rs1350!K1350_seMarketType)
    If IsdbNull(rs1350!K1350_cdMarketType) = False Then D1350.cdMarketType = Trim$(rs1350!K1350_cdMarketType)
    If IsdbNull(rs1350!K1350_cdPaymentCondition) = False Then D1350.cdPaymentCondition = Trim$(rs1350!K1350_cdPaymentCondition)
    If IsdbNull(rs1350!K1350_sePaymentCondition) = False Then D1350.sePaymentCondition = Trim$(rs1350!K1350_sePaymentCondition)
    If IsdbNull(rs1350!K1350_InchargePI) = False Then D1350.InchargePI = Trim$(rs1350!K1350_InchargePI)
    If IsdbNull(rs1350!K1350_DateShipping) = False Then D1350.DateShipping = Trim$(rs1350!K1350_DateShipping)
    If IsdbNull(rs1350!K1350_DatePI) = False Then D1350.DatePI = Trim$(rs1350!K1350_DatePI)
    If IsdbNull(rs1350!K1350_DateDuePI) = False Then D1350.DateDuePI = Trim$(rs1350!K1350_DateDuePI)
    If IsdbNull(rs1350!K1350_DateRequestPI) = False Then D1350.DateRequestPI = Trim$(rs1350!K1350_DateRequestPI)
    If IsdbNull(rs1350!K1350_DateApprovalPI) = False Then D1350.DateApprovalPI = Trim$(rs1350!K1350_DateApprovalPI)
    If IsdbNull(rs1350!K1350_DateCancelPI) = False Then D1350.DateCancelPI = Trim$(rs1350!K1350_DateCancelPI)
    If IsdbNull(rs1350!K1350_DateCompletePI) = False Then D1350.DateCompletePI = Trim$(rs1350!K1350_DateCompletePI)
    If IsdbNull(rs1350!K1350_StatusPI) = False Then D1350.StatusPI = Trim$(rs1350!K1350_StatusPI)
    If IsdbNull(rs1350!K1350_CustomerCode) = False Then D1350.CustomerCode = Trim$(rs1350!K1350_CustomerCode)
    If IsdbNull(rs1350!K1350_BuyerCode) = False Then D1350.BuyerCode = Trim$(rs1350!K1350_BuyerCode)
    If IsdbNull(rs1350!K1350_Attention) = False Then D1350.Attention = Trim$(rs1350!K1350_Attention)
    If IsdbNull(rs1350!K1350_BankName) = False Then D1350.BankName = Trim$(rs1350!K1350_BankName)
    If IsdbNull(rs1350!K1350_SwiftCode) = False Then D1350.SwiftCode = Trim$(rs1350!K1350_SwiftCode)
    If IsdbNull(rs1350!K1350_AccountNo) = False Then D1350.AccountNo = Trim$(rs1350!K1350_AccountNo)
    If IsdbNull(rs1350!K1350_AccountName) = False Then D1350.AccountName = Trim$(rs1350!K1350_AccountName)
    If IsdbNull(rs1350!K1350_PriceExchange) = False Then D1350.PriceExchange = Trim$(rs1350!K1350_PriceExchange)
    If IsdbNull(rs1350!K1350_DateExchange) = False Then D1350.DateExchange = Trim$(rs1350!K1350_DateExchange)
    If IsdbNull(rs1350!K1350_seUnitPrice) = False Then D1350.seUnitPrice = Trim$(rs1350!K1350_seUnitPrice)
    If IsdbNull(rs1350!K1350_cdUnitPrice) = False Then D1350.cdUnitPrice = Trim$(rs1350!K1350_cdUnitPrice)
    If IsdbNull(rs1350!K1350_TotalQty) = False Then D1350.TotalQty = Trim$(rs1350!K1350_TotalQty)
    If IsdbNull(rs1350!K1350_TotalAmount) = False Then D1350.TotalAmount = Trim$(rs1350!K1350_TotalAmount)
    If IsdbNull(rs1350!K1350_DateInsert) = False Then D1350.DateInsert = Trim$(rs1350!K1350_DateInsert)
    If IsdbNull(rs1350!K1350_InchargeInsert) = False Then D1350.InchargeInsert = Trim$(rs1350!K1350_InchargeInsert)
    If IsdbNull(rs1350!K1350_DateUpdate) = False Then D1350.DateUpdate = Trim$(rs1350!K1350_DateUpdate)
    If IsdbNull(rs1350!K1350_InchargeUpdate) = False Then D1350.InchargeUpdate = Trim$(rs1350!K1350_InchargeUpdate)
    If IsdbNull(rs1350!K1350_Remark) = False Then D1350.Remark = Trim$(rs1350!K1350_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K1350_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K1350_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z1350 As T1350_AREA, PINO AS String) as Boolean

K1350_MOVE = False

Try
    If READ_PFK1350(PINO) = True Then
                z1350 = D1350
		K1350_MOVE = True
		else
	z1350 = nothing
     End If

     If  getColumIndex(spr,"PINo") > -1 then z1350.PINo = getDataM(spr, getColumIndex(spr,"PINo"), xRow)
     If  getColumIndex(spr,"seMarketType") > -1 then z1350.seMarketType = getDataM(spr, getColumIndex(spr,"seMarketType"), xRow)
     If  getColumIndex(spr,"cdMarketType") > -1 then z1350.cdMarketType = getDataM(spr, getColumIndex(spr,"cdMarketType"), xRow)
     If  getColumIndex(spr,"cdPaymentCondition") > -1 then z1350.cdPaymentCondition = getDataM(spr, getColumIndex(spr,"cdPaymentCondition"), xRow)
     If  getColumIndex(spr,"sePaymentCondition") > -1 then z1350.sePaymentCondition = getDataM(spr, getColumIndex(spr,"sePaymentCondition"), xRow)
     If  getColumIndex(spr,"InchargePI") > -1 then z1350.InchargePI = getDataM(spr, getColumIndex(spr,"InchargePI"), xRow)
     If  getColumIndex(spr,"DateShipping") > -1 then z1350.DateShipping = getDataM(spr, getColumIndex(spr,"DateShipping"), xRow)
     If  getColumIndex(spr,"DatePI") > -1 then z1350.DatePI = getDataM(spr, getColumIndex(spr,"DatePI"), xRow)
     If  getColumIndex(spr,"DateDuePI") > -1 then z1350.DateDuePI = getDataM(spr, getColumIndex(spr,"DateDuePI"), xRow)
     If  getColumIndex(spr,"DateRequestPI") > -1 then z1350.DateRequestPI = getDataM(spr, getColumIndex(spr,"DateRequestPI"), xRow)
     If  getColumIndex(spr,"DateApprovalPI") > -1 then z1350.DateApprovalPI = getDataM(spr, getColumIndex(spr,"DateApprovalPI"), xRow)
     If  getColumIndex(spr,"DateCancelPI") > -1 then z1350.DateCancelPI = getDataM(spr, getColumIndex(spr,"DateCancelPI"), xRow)
     If  getColumIndex(spr,"DateCompletePI") > -1 then z1350.DateCompletePI = getDataM(spr, getColumIndex(spr,"DateCompletePI"), xRow)
     If  getColumIndex(spr,"StatusPI") > -1 then z1350.StatusPI = getDataM(spr, getColumIndex(spr,"StatusPI"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z1350.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"BuyerCode") > -1 then z1350.BuyerCode = getDataM(spr, getColumIndex(spr,"BuyerCode"), xRow)
     If  getColumIndex(spr,"Attention") > -1 then z1350.Attention = getDataM(spr, getColumIndex(spr,"Attention"), xRow)
     If  getColumIndex(spr,"BankName") > -1 then z1350.BankName = getDataM(spr, getColumIndex(spr,"BankName"), xRow)
     If  getColumIndex(spr,"SwiftCode") > -1 then z1350.SwiftCode = getDataM(spr, getColumIndex(spr,"SwiftCode"), xRow)
     If  getColumIndex(spr,"AccountNo") > -1 then z1350.AccountNo = getDataM(spr, getColumIndex(spr,"AccountNo"), xRow)
     If  getColumIndex(spr,"AccountName") > -1 then z1350.AccountName = getDataM(spr, getColumIndex(spr,"AccountName"), xRow)
     If  getColumIndex(spr,"PriceExchange") > -1 then z1350.PriceExchange = getDataM(spr, getColumIndex(spr,"PriceExchange"), xRow)
     If  getColumIndex(spr,"DateExchange") > -1 then z1350.DateExchange = getDataM(spr, getColumIndex(spr,"DateExchange"), xRow)
     If  getColumIndex(spr,"seUnitPrice") > -1 then z1350.seUnitPrice = getDataM(spr, getColumIndex(spr,"seUnitPrice"), xRow)
     If  getColumIndex(spr,"cdUnitPrice") > -1 then z1350.cdUnitPrice = getDataM(spr, getColumIndex(spr,"cdUnitPrice"), xRow)
     If  getColumIndex(spr,"TotalQty") > -1 then z1350.TotalQty = getDataM(spr, getColumIndex(spr,"TotalQty"), xRow)
     If  getColumIndex(spr,"TotalAmount") > -1 then z1350.TotalAmount = getDataM(spr, getColumIndex(spr,"TotalAmount"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z1350.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z1350.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z1350.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z1350.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z1350.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K1350_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K1350_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z1350 As T1350_AREA,CheckClear as Boolean,PINO AS String) as Boolean

K1350_MOVE = False

Try
    If READ_PFK1350(PINO) = True Then
                z1350 = D1350
		K1350_MOVE = True
		else
	If CheckClear  = True then z1350 = nothing
     End If

     If  getColumIndex(spr,"PINo") > -1 then z1350.PINo = getDataM(spr, getColumIndex(spr,"PINo"), xRow)
     If  getColumIndex(spr,"seMarketType") > -1 then z1350.seMarketType = getDataM(spr, getColumIndex(spr,"seMarketType"), xRow)
     If  getColumIndex(spr,"cdMarketType") > -1 then z1350.cdMarketType = getDataM(spr, getColumIndex(spr,"cdMarketType"), xRow)
     If  getColumIndex(spr,"cdPaymentCondition") > -1 then z1350.cdPaymentCondition = getDataM(spr, getColumIndex(spr,"cdPaymentCondition"), xRow)
     If  getColumIndex(spr,"sePaymentCondition") > -1 then z1350.sePaymentCondition = getDataM(spr, getColumIndex(spr,"sePaymentCondition"), xRow)
     If  getColumIndex(spr,"InchargePI") > -1 then z1350.InchargePI = getDataM(spr, getColumIndex(spr,"InchargePI"), xRow)
     If  getColumIndex(spr,"DateShipping") > -1 then z1350.DateShipping = getDataM(spr, getColumIndex(spr,"DateShipping"), xRow)
     If  getColumIndex(spr,"DatePI") > -1 then z1350.DatePI = getDataM(spr, getColumIndex(spr,"DatePI"), xRow)
     If  getColumIndex(spr,"DateDuePI") > -1 then z1350.DateDuePI = getDataM(spr, getColumIndex(spr,"DateDuePI"), xRow)
     If  getColumIndex(spr,"DateRequestPI") > -1 then z1350.DateRequestPI = getDataM(spr, getColumIndex(spr,"DateRequestPI"), xRow)
     If  getColumIndex(spr,"DateApprovalPI") > -1 then z1350.DateApprovalPI = getDataM(spr, getColumIndex(spr,"DateApprovalPI"), xRow)
     If  getColumIndex(spr,"DateCancelPI") > -1 then z1350.DateCancelPI = getDataM(spr, getColumIndex(spr,"DateCancelPI"), xRow)
     If  getColumIndex(spr,"DateCompletePI") > -1 then z1350.DateCompletePI = getDataM(spr, getColumIndex(spr,"DateCompletePI"), xRow)
     If  getColumIndex(spr,"StatusPI") > -1 then z1350.StatusPI = getDataM(spr, getColumIndex(spr,"StatusPI"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z1350.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"BuyerCode") > -1 then z1350.BuyerCode = getDataM(spr, getColumIndex(spr,"BuyerCode"), xRow)
     If  getColumIndex(spr,"Attention") > -1 then z1350.Attention = getDataM(spr, getColumIndex(spr,"Attention"), xRow)
     If  getColumIndex(spr,"BankName") > -1 then z1350.BankName = getDataM(spr, getColumIndex(spr,"BankName"), xRow)
     If  getColumIndex(spr,"SwiftCode") > -1 then z1350.SwiftCode = getDataM(spr, getColumIndex(spr,"SwiftCode"), xRow)
     If  getColumIndex(spr,"AccountNo") > -1 then z1350.AccountNo = getDataM(spr, getColumIndex(spr,"AccountNo"), xRow)
     If  getColumIndex(spr,"AccountName") > -1 then z1350.AccountName = getDataM(spr, getColumIndex(spr,"AccountName"), xRow)
     If  getColumIndex(spr,"PriceExchange") > -1 then z1350.PriceExchange = getDataM(spr, getColumIndex(spr,"PriceExchange"), xRow)
     If  getColumIndex(spr,"DateExchange") > -1 then z1350.DateExchange = getDataM(spr, getColumIndex(spr,"DateExchange"), xRow)
     If  getColumIndex(spr,"seUnitPrice") > -1 then z1350.seUnitPrice = getDataM(spr, getColumIndex(spr,"seUnitPrice"), xRow)
     If  getColumIndex(spr,"cdUnitPrice") > -1 then z1350.cdUnitPrice = getDataM(spr, getColumIndex(spr,"cdUnitPrice"), xRow)
     If  getColumIndex(spr,"TotalQty") > -1 then z1350.TotalQty = getDataM(spr, getColumIndex(spr,"TotalQty"), xRow)
     If  getColumIndex(spr,"TotalAmount") > -1 then z1350.TotalAmount = getDataM(spr, getColumIndex(spr,"TotalAmount"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z1350.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z1350.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z1350.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z1350.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z1350.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K1350_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K1350_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z1350 As T1350_AREA, Job as String, PINO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K1350_MOVE = False

Try
    If READ_PFK1350(PINO) = True Then
                z1350 = D1350
		K1350_MOVE = True
		else
	z1350 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1350")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PINO":z1350.PINo = Children(i).Code
   Case "SEMARKETTYPE":z1350.seMarketType = Children(i).Code
   Case "CDMARKETTYPE":z1350.cdMarketType = Children(i).Code
   Case "CDPAYMENTCONDITION":z1350.cdPaymentCondition = Children(i).Code
   Case "SEPAYMENTCONDITION":z1350.sePaymentCondition = Children(i).Code
   Case "INCHARGEPI":z1350.InchargePI = Children(i).Code
   Case "DATESHIPPING":z1350.DateShipping = Children(i).Code
   Case "DATEPI":z1350.DatePI = Children(i).Code
   Case "DATEDUEPI":z1350.DateDuePI = Children(i).Code
   Case "DATEREQUESTPI":z1350.DateRequestPI = Children(i).Code
   Case "DATEAPPROVALPI":z1350.DateApprovalPI = Children(i).Code
   Case "DATECANCELPI":z1350.DateCancelPI = Children(i).Code
   Case "DATECOMPLETEPI":z1350.DateCompletePI = Children(i).Code
   Case "STATUSPI":z1350.StatusPI = Children(i).Code
   Case "CUSTOMERCODE":z1350.CustomerCode = Children(i).Code
   Case "BUYERCODE":z1350.BuyerCode = Children(i).Code
   Case "ATTENTION":z1350.Attention = Children(i).Code
   Case "BANKNAME":z1350.BankName = Children(i).Code
   Case "SWIFTCODE":z1350.SwiftCode = Children(i).Code
   Case "ACCOUNTNO":z1350.AccountNo = Children(i).Code
   Case "ACCOUNTNAME":z1350.AccountName = Children(i).Code
   Case "PRICEEXCHANGE":z1350.PriceExchange = Children(i).Code
   Case "DATEEXCHANGE":z1350.DateExchange = Children(i).Code
   Case "SEUNITPRICE":z1350.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z1350.cdUnitPrice = Children(i).Code
   Case "TOTALQTY":z1350.TotalQty = Children(i).Code
   Case "TOTALAMOUNT":z1350.TotalAmount = Children(i).Code
   Case "DATEINSERT":z1350.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z1350.InchargeInsert = Children(i).Code
   Case "DATEUPDATE":z1350.DateUpdate = Children(i).Code
   Case "INCHARGEUPDATE":z1350.InchargeUpdate = Children(i).Code
   Case "REMARK":z1350.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PINO":z1350.PINo = Children(i).Data
   Case "SEMARKETTYPE":z1350.seMarketType = Children(i).Data
   Case "CDMARKETTYPE":z1350.cdMarketType = Children(i).Data
   Case "CDPAYMENTCONDITION":z1350.cdPaymentCondition = Children(i).Data
   Case "SEPAYMENTCONDITION":z1350.sePaymentCondition = Children(i).Data
   Case "INCHARGEPI":z1350.InchargePI = Children(i).Data
   Case "DATESHIPPING":z1350.DateShipping = Children(i).Data
   Case "DATEPI":z1350.DatePI = Children(i).Data
   Case "DATEDUEPI":z1350.DateDuePI = Children(i).Data
   Case "DATEREQUESTPI":z1350.DateRequestPI = Children(i).Data
   Case "DATEAPPROVALPI":z1350.DateApprovalPI = Children(i).Data
   Case "DATECANCELPI":z1350.DateCancelPI = Children(i).Data
   Case "DATECOMPLETEPI":z1350.DateCompletePI = Children(i).Data
   Case "STATUSPI":z1350.StatusPI = Children(i).Data
   Case "CUSTOMERCODE":z1350.CustomerCode = Children(i).Data
   Case "BUYERCODE":z1350.BuyerCode = Children(i).Data
   Case "ATTENTION":z1350.Attention = Children(i).Data
   Case "BANKNAME":z1350.BankName = Children(i).Data
   Case "SWIFTCODE":z1350.SwiftCode = Children(i).Data
   Case "ACCOUNTNO":z1350.AccountNo = Children(i).Data
   Case "ACCOUNTNAME":z1350.AccountName = Children(i).Data
   Case "PRICEEXCHANGE":z1350.PriceExchange = Children(i).Data
   Case "DATEEXCHANGE":z1350.DateExchange = Children(i).Data
   Case "SEUNITPRICE":z1350.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z1350.cdUnitPrice = Children(i).Data
   Case "TOTALQTY":z1350.TotalQty = Children(i).Data
   Case "TOTALAMOUNT":z1350.TotalAmount = Children(i).Data
   Case "DATEINSERT":z1350.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z1350.InchargeInsert = Children(i).Data
   Case "DATEUPDATE":z1350.DateUpdate = Children(i).Data
   Case "INCHARGEUPDATE":z1350.InchargeUpdate = Children(i).Data
   Case "REMARK":z1350.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K1350_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K1350_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z1350 As T1350_AREA, Job as String, CheckClear as Boolean, PINO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K1350_MOVE = False

Try
    If READ_PFK1350(PINO) = True Then
                z1350 = D1350
		K1350_MOVE = True
		else
	If CheckClear  = True then z1350 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1350")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PINO":z1350.PINo = Children(i).Code
   Case "SEMARKETTYPE":z1350.seMarketType = Children(i).Code
   Case "CDMARKETTYPE":z1350.cdMarketType = Children(i).Code
   Case "CDPAYMENTCONDITION":z1350.cdPaymentCondition = Children(i).Code
   Case "SEPAYMENTCONDITION":z1350.sePaymentCondition = Children(i).Code
   Case "INCHARGEPI":z1350.InchargePI = Children(i).Code
   Case "DATESHIPPING":z1350.DateShipping = Children(i).Code
   Case "DATEPI":z1350.DatePI = Children(i).Code
   Case "DATEDUEPI":z1350.DateDuePI = Children(i).Code
   Case "DATEREQUESTPI":z1350.DateRequestPI = Children(i).Code
   Case "DATEAPPROVALPI":z1350.DateApprovalPI = Children(i).Code
   Case "DATECANCELPI":z1350.DateCancelPI = Children(i).Code
   Case "DATECOMPLETEPI":z1350.DateCompletePI = Children(i).Code
   Case "STATUSPI":z1350.StatusPI = Children(i).Code
   Case "CUSTOMERCODE":z1350.CustomerCode = Children(i).Code
   Case "BUYERCODE":z1350.BuyerCode = Children(i).Code
   Case "ATTENTION":z1350.Attention = Children(i).Code
   Case "BANKNAME":z1350.BankName = Children(i).Code
   Case "SWIFTCODE":z1350.SwiftCode = Children(i).Code
   Case "ACCOUNTNO":z1350.AccountNo = Children(i).Code
   Case "ACCOUNTNAME":z1350.AccountName = Children(i).Code
   Case "PRICEEXCHANGE":z1350.PriceExchange = Children(i).Code
   Case "DATEEXCHANGE":z1350.DateExchange = Children(i).Code
   Case "SEUNITPRICE":z1350.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z1350.cdUnitPrice = Children(i).Code
   Case "TOTALQTY":z1350.TotalQty = Children(i).Code
   Case "TOTALAMOUNT":z1350.TotalAmount = Children(i).Code
   Case "DATEINSERT":z1350.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z1350.InchargeInsert = Children(i).Code
   Case "DATEUPDATE":z1350.DateUpdate = Children(i).Code
   Case "INCHARGEUPDATE":z1350.InchargeUpdate = Children(i).Code
   Case "REMARK":z1350.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PINO":z1350.PINo = Children(i).Data
   Case "SEMARKETTYPE":z1350.seMarketType = Children(i).Data
   Case "CDMARKETTYPE":z1350.cdMarketType = Children(i).Data
   Case "CDPAYMENTCONDITION":z1350.cdPaymentCondition = Children(i).Data
   Case "SEPAYMENTCONDITION":z1350.sePaymentCondition = Children(i).Data
   Case "INCHARGEPI":z1350.InchargePI = Children(i).Data
   Case "DATESHIPPING":z1350.DateShipping = Children(i).Data
   Case "DATEPI":z1350.DatePI = Children(i).Data
   Case "DATEDUEPI":z1350.DateDuePI = Children(i).Data
   Case "DATEREQUESTPI":z1350.DateRequestPI = Children(i).Data
   Case "DATEAPPROVALPI":z1350.DateApprovalPI = Children(i).Data
   Case "DATECANCELPI":z1350.DateCancelPI = Children(i).Data
   Case "DATECOMPLETEPI":z1350.DateCompletePI = Children(i).Data
   Case "STATUSPI":z1350.StatusPI = Children(i).Data
   Case "CUSTOMERCODE":z1350.CustomerCode = Children(i).Data
   Case "BUYERCODE":z1350.BuyerCode = Children(i).Data
   Case "ATTENTION":z1350.Attention = Children(i).Data
   Case "BANKNAME":z1350.BankName = Children(i).Data
   Case "SWIFTCODE":z1350.SwiftCode = Children(i).Data
   Case "ACCOUNTNO":z1350.AccountNo = Children(i).Data
   Case "ACCOUNTNAME":z1350.AccountName = Children(i).Data
   Case "PRICEEXCHANGE":z1350.PriceExchange = Children(i).Data
   Case "DATEEXCHANGE":z1350.DateExchange = Children(i).Data
   Case "SEUNITPRICE":z1350.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z1350.cdUnitPrice = Children(i).Data
   Case "TOTALQTY":z1350.TotalQty = Children(i).Data
   Case "TOTALAMOUNT":z1350.TotalAmount = Children(i).Data
   Case "DATEINSERT":z1350.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z1350.InchargeInsert = Children(i).Data
   Case "DATEUPDATE":z1350.DateUpdate = Children(i).Data
   Case "INCHARGEUPDATE":z1350.InchargeUpdate = Children(i).Data
   Case "REMARK":z1350.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K1350_MOVE",vbCritical)
End Try
End Function 
    
End Module 
