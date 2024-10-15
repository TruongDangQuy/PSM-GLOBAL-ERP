'=========================================================================================================================================================
'   TABLE : (PFK7101)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7101

Structure T7101_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	CustomerCode	 AS String	'			char(6)		*
Public 	ACodeReceivable	 AS String	'			nvarchar(20)
Public 	ACodePayable	 AS String	'			nvarchar(20)
Public 	DevelopmentCode	 AS String	'			nvarchar(20)
Public 	CustomerName	 AS String	'			nvarchar(200)
Public 	CustomerName1	 AS String	'			nvarchar(200)
Public 	CustomerNameSimply	 AS String	'			nvarchar(100)
Public 	CustomerNameSimply1	 AS String	'			nvarchar(100)
Public 	sePassWord	 AS String	'			char(3)
Public 	cdPassWord	 AS String	'			char(3)
Public 	seDeliveryTerm	 AS String	'			char(3)
Public 	cdDeliveryTerm	 AS String	'			char(3)
Public 	sePaymentTerm	 AS String	'			char(3)
Public 	cdPaymentTerm	 AS String	'			char(3)
Public 	sePaymentCondition	 AS String	'			char(3)
Public 	cdPaymentCondition	 AS String	'			char(3)
Public 	sePaymentDay	 AS String	'			char(3)
Public 	cdPaymentDay	 AS String	'			char(3)
Public 	sePaymentTime	 AS String	'			char(3)
Public 	cdPaymentTime	 AS String	'			char(3)
Public 	seSite	 AS String	'			char(3)
Public 	cdSite	 AS String	'			char(3)
Public 	seTeam	 AS String	'			char(3)
Public 	cdTeam	 AS String	'			char(3)
Public 	ForeignName1	 AS String	'			nvarchar(100)
Public 	ForeignName2	 AS String	'			nvarchar(100)
Public 	CompanyID	 AS String	'			varchar(30)
Public 	CompanyType	 AS String	'			varchar(50)
Public 	CompanyItem	 AS String	'			varchar(50)
Public 	Representative	 AS String	'			nvarchar(50)
Public 	AddressNo	 AS String	'			nvarchar(100)
Public 	Address1	 AS String	'			nvarchar(500)
Public 	Address2	 AS String	'			nvarchar(500)
Public 	Destination	 AS String	'			nvarchar(500)
Public 	FinalShop	 AS String	'			nvarchar(500)
Public 	Country	 AS String	'			nvarchar(500)
Public 	InvoiceAccount	 AS String	'			nvarchar(50)
Public 	TaxExempt	 AS String	'			nvarchar(50)
Public 	seSupplierGroup	 AS String	'			char(3)
Public 	cdSupplierGroup	 AS String	'			char(3)
Public 	sePOGroup	 AS String	'			char(3)
Public 	cdPOGroup	 AS String	'			char(3)
Public 	seSOGroup	 AS String	'			char(3)
Public 	cdSOGroup	 AS String	'			char(3)
Public 	TelephoneCompany	 AS String	'			nvarchar(50)
Public 	TelephoneHand	 AS String	'			nvarchar(50)
Public 	FaxNo	 AS String	'			varchar(20)
Public 	Email	 AS String	'			varchar(50)
Public 	BeneficiaryName	 AS String	'			nvarchar(500)
Public 	AccountNumber	 AS String	'			nvarchar(500)
Public 	BankName	 AS String	'			nvarchar(500)
Public 	BankAddress	 AS String	'			nvarchar(500)
Public 	SwiftCode	 AS String	'			nvarchar(500)
Public 	cdFactory	 AS String	'			char(3)
        Public CheckKindCustomer As String  '			char(1)
        Public seCustomerDivision As String  '			char(3)
        Public cdCustomerDivision As String  '			char(3)

        Public seCancelDate As String  '			char(3)
        Public cdCancelDate As String  '			char(3)

Public 	seCustomerLocation	 AS String	'			char(3)
Public 	cdCustomerLocation	 AS String	'			char(3)
Public 	seTaxGroup	 AS String	'			char(3)
Public 	cdTaxGroup	 AS String	'			char(3)
Public 	InCharge	 AS String	'			char(8)
Public 	InChargeSale	 AS String	'			char(8)
Public 	CheckTax	 AS String	'			char(1)
Public 	CheckCustomer	 AS String	'			char(1)
Public 	CheckSupplier	 AS String	'			char(1)
Public 	CheckEmployee	 AS String	'			char(1)
Public 	CheckInside	 AS String	'			char(1)
Public 	CheckOutside	 AS String	'			char(1)
Public 	CheckOthers	 AS String	'			char(1)
Public 	CheckUse	 AS String	'			char(1)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	TimeInsert	 AS String	'			char(14)
Public 	TimeUpdate	 AS String	'			char(14)
Public 	TimeLast	 AS String	'			char(14)
Public 	DateActive	 AS String	'			char(8)
Public 	DateDeactive	 AS String	'			char(8)
Public 	CheckActive	 AS String	'			char(1)
Public 	ParaNo1	 AS Double	'			decimal
Public 	ParaNo2	 AS Double	'			decimal
Public 	ParaNo3	 AS Double	'			decimal
Public 	CheckSync	 AS String	'			char(1)
Public 	CheckCustomerStatus	 AS String	'			char(1)
Public 	DateComplete	 AS String	'			char(8)
Public 	DateApproved	 AS String	'			char(8)
Public 	DateCancel	 AS String	'			char(8)
Public 	DatePending1	 AS String	'			char(8)
Public 	DatePending2	 AS String	'			char(8)
Public 	Remark	 AS String	'			nvarchar(300)
Public 	CheckOption1	 AS String	'			char(1)
Public 	CheckOption2	 AS String	'			char(1)
Public 	CheckOption3	 AS String	'			char(1)
Public 	CheckOption4	 AS String	'			char(1)
Public 	CheckOption5	 AS String	'			char(1)
Public 	CheckOption6	 AS String	'			char(1)
Public 	CheckOption7	 AS String	'			char(1)
Public 	CheckOption8	 AS String	'			char(1)
Public 	CheckOption9	 AS String	'			char(1)
Public 	CheckOption10	 AS String	'			char(1)
'=========================================================================================================================================================
End structure

Public D7101 As T7101_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7101(CUSTOMERCODE AS String) As Boolean
    READ_PFK7101 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7101 "
    SQL = SQL & " WHERE K7101_CustomerCode		 = '" & CustomerCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7101_CLEAR: GoTo SKIP_READ_PFK7101
                
    Call K7101_MOVE(rd)
    READ_PFK7101 = True

SKIP_READ_PFK7101:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7101",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7101(CUSTOMERCODE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7101 "
    SQL = SQL & " WHERE K7101_CustomerCode		 = '" & CustomerCode & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7101",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7101(z7101 As T7101_AREA) As Boolean
    WRITE_PFK7101 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7101)
 
    SQL = " INSERT INTO PFK7101 "
    SQL = SQL & " ( "
    SQL = SQL & " K7101_CustomerCode," 
    SQL = SQL & " K7101_ACodeReceivable," 
    SQL = SQL & " K7101_ACodePayable," 
    SQL = SQL & " K7101_DevelopmentCode," 
    SQL = SQL & " K7101_CustomerName," 
    SQL = SQL & " K7101_CustomerName1," 
    SQL = SQL & " K7101_CustomerNameSimply," 
    SQL = SQL & " K7101_CustomerNameSimply1," 
    SQL = SQL & " K7101_sePassWord," 
    SQL = SQL & " K7101_cdPassWord," 
    SQL = SQL & " K7101_seDeliveryTerm," 
    SQL = SQL & " K7101_cdDeliveryTerm," 
    SQL = SQL & " K7101_sePaymentTerm," 
    SQL = SQL & " K7101_cdPaymentTerm," 
    SQL = SQL & " K7101_sePaymentCondition," 
    SQL = SQL & " K7101_cdPaymentCondition," 
    SQL = SQL & " K7101_sePaymentDay," 
    SQL = SQL & " K7101_cdPaymentDay," 
    SQL = SQL & " K7101_sePaymentTime," 
    SQL = SQL & " K7101_cdPaymentTime," 
    SQL = SQL & " K7101_seSite," 
    SQL = SQL & " K7101_cdSite," 
    SQL = SQL & " K7101_seTeam," 
    SQL = SQL & " K7101_cdTeam," 
    SQL = SQL & " K7101_ForeignName1," 
    SQL = SQL & " K7101_ForeignName2," 
    SQL = SQL & " K7101_CompanyID," 
    SQL = SQL & " K7101_CompanyType," 
    SQL = SQL & " K7101_CompanyItem," 
    SQL = SQL & " K7101_Representative," 
    SQL = SQL & " K7101_AddressNo," 
    SQL = SQL & " K7101_Address1," 
    SQL = SQL & " K7101_Address2," 
    SQL = SQL & " K7101_Destination," 
    SQL = SQL & " K7101_FinalShop," 
    SQL = SQL & " K7101_Country," 
    SQL = SQL & " K7101_InvoiceAccount," 
    SQL = SQL & " K7101_TaxExempt," 
    SQL = SQL & " K7101_seSupplierGroup," 
    SQL = SQL & " K7101_cdSupplierGroup," 
    SQL = SQL & " K7101_sePOGroup," 
    SQL = SQL & " K7101_cdPOGroup," 
    SQL = SQL & " K7101_seSOGroup," 
    SQL = SQL & " K7101_cdSOGroup," 
    SQL = SQL & " K7101_TelephoneCompany," 
    SQL = SQL & " K7101_TelephoneHand," 
    SQL = SQL & " K7101_FaxNo," 
    SQL = SQL & " K7101_Email," 
    SQL = SQL & " K7101_BeneficiaryName," 
    SQL = SQL & " K7101_AccountNumber," 
    SQL = SQL & " K7101_BankName," 
    SQL = SQL & " K7101_BankAddress," 
    SQL = SQL & " K7101_SwiftCode," 
    SQL = SQL & " K7101_cdFactory," 
            SQL = SQL & " K7101_CheckKindCustomer,"
            SQL = SQL & " K7101_seCancelDate,"
            SQL = SQL & " K7101_cdCancelDate,"

    SQL = SQL & " K7101_seCustomerDivision," 
    SQL = SQL & " K7101_cdCustomerDivision," 
    SQL = SQL & " K7101_seCustomerLocation," 
    SQL = SQL & " K7101_cdCustomerLocation," 
    SQL = SQL & " K7101_seTaxGroup," 
    SQL = SQL & " K7101_cdTaxGroup," 
    SQL = SQL & " K7101_InCharge," 
    SQL = SQL & " K7101_InChargeSale," 
    SQL = SQL & " K7101_CheckTax," 
    SQL = SQL & " K7101_CheckCustomer," 
    SQL = SQL & " K7101_CheckSupplier," 
    SQL = SQL & " K7101_CheckEmployee," 
    SQL = SQL & " K7101_CheckInside," 
    SQL = SQL & " K7101_CheckOutside," 
    SQL = SQL & " K7101_CheckOthers," 
    SQL = SQL & " K7101_CheckUse," 
    SQL = SQL & " K7101_InchargeInsert," 
    SQL = SQL & " K7101_InchargeUpdate," 
    SQL = SQL & " K7101_DateInsert," 
    SQL = SQL & " K7101_DateUpdate," 
    SQL = SQL & " K7101_TimeInsert," 
    SQL = SQL & " K7101_TimeUpdate," 
    SQL = SQL & " K7101_TimeLast," 
    SQL = SQL & " K7101_DateActive," 
    SQL = SQL & " K7101_DateDeactive," 
    SQL = SQL & " K7101_CheckActive," 
    SQL = SQL & " K7101_ParaNo1," 
    SQL = SQL & " K7101_ParaNo2," 
    SQL = SQL & " K7101_ParaNo3," 
    SQL = SQL & " K7101_CheckSync," 
    SQL = SQL & " K7101_CheckCustomerStatus," 
    SQL = SQL & " K7101_DateComplete," 
    SQL = SQL & " K7101_DateApproved," 
    SQL = SQL & " K7101_DateCancel," 
    SQL = SQL & " K7101_DatePending1," 
    SQL = SQL & " K7101_DatePending2," 
    SQL = SQL & " K7101_Remark," 
    SQL = SQL & " K7101_CheckOption1," 
    SQL = SQL & " K7101_CheckOption2," 
    SQL = SQL & " K7101_CheckOption3," 
    SQL = SQL & " K7101_CheckOption4," 
    SQL = SQL & " K7101_CheckOption5," 
    SQL = SQL & " K7101_CheckOption6," 
    SQL = SQL & " K7101_CheckOption7," 
    SQL = SQL & " K7101_CheckOption8," 
    SQL = SQL & " K7101_CheckOption9," 
    SQL = SQL & " K7101_CheckOption10 " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7101.CustomerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.ACodeReceivable) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.ACodePayable) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.DevelopmentCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.CustomerName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.CustomerName1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.CustomerNameSimply) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.CustomerNameSimply1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.sePassWord) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.cdPassWord) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.seDeliveryTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.cdDeliveryTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.sePaymentTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.cdPaymentTerm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.sePaymentCondition) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.cdPaymentCondition) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.sePaymentDay) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.cdPaymentDay) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.sePaymentTime) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.cdPaymentTime) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.seSite) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.cdSite) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.seTeam) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.cdTeam) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.ForeignName1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.ForeignName2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.CompanyID) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.CompanyType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.CompanyItem) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.Representative) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.AddressNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.Address1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.Address2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.Destination) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.FinalShop) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.Country) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.InvoiceAccount) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.TaxExempt) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.seSupplierGroup) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.cdSupplierGroup) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.sePOGroup) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.cdPOGroup) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.seSOGroup) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.cdSOGroup) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.TelephoneCompany) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.TelephoneHand) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.FaxNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.Email) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.BeneficiaryName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.AccountNumber) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.BankName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.BankAddress) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.SwiftCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.cdFactory) & "', "  
            SQL = SQL & "  N'" & FormatSQL(z7101.CheckKindCustomer) & "', "

            SQL = SQL & "  N'" & FormatSQL(z7101.seCancelDate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7101.cdCancelDate) & "', "

    SQL = SQL & "  N'" & FormatSQL(z7101.seCustomerDivision) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.cdCustomerDivision) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.seCustomerLocation) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.cdCustomerLocation) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.seTaxGroup) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.cdTaxGroup) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.InCharge) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.InChargeSale) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.CheckTax) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.CheckCustomer) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.CheckSupplier) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.CheckEmployee) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.CheckInside) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.CheckOutside) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.CheckOthers) & "', "  
        SQL = SQL & "  N'1', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.TimeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.TimeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.TimeLast) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.DateActive) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.DateDeactive) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.CheckActive) & "', "  
    SQL = SQL & "   " & FormatSQL(z7101.ParaNo1) & ", "  
    SQL = SQL & "   " & FormatSQL(z7101.ParaNo2) & ", "  
    SQL = SQL & "   " & FormatSQL(z7101.ParaNo3) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7101.CheckSync) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.CheckCustomerStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.DateComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.DateApproved) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.DateCancel) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.DatePending1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.DatePending2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.Remark) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.CheckOption1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.CheckOption2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.CheckOption3) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.CheckOption4) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.CheckOption5) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.CheckOption6) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.CheckOption7) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.CheckOption8) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.CheckOption9) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7101.CheckOption10) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7101 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7101",vbCritical)
Finally
        Call GetFullInformation("PFK7101", "I", SQL)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7101(z7101 As T7101_AREA) As Boolean
    REWRITE_PFK7101 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7101)
   
    SQL = " UPDATE PFK7101 SET "
    SQL = SQL & "    K7101_ACodeReceivable      = N'" & FormatSQL(z7101.ACodeReceivable) & "', " 
    SQL = SQL & "    K7101_ACodePayable      = N'" & FormatSQL(z7101.ACodePayable) & "', " 
    SQL = SQL & "    K7101_DevelopmentCode      = N'" & FormatSQL(z7101.DevelopmentCode) & "', " 
    SQL = SQL & "    K7101_CustomerName      = N'" & FormatSQL(z7101.CustomerName) & "', " 
    SQL = SQL & "    K7101_CustomerName1      = N'" & FormatSQL(z7101.CustomerName1) & "', " 
    SQL = SQL & "    K7101_CustomerNameSimply      = N'" & FormatSQL(z7101.CustomerNameSimply) & "', " 
    SQL = SQL & "    K7101_CustomerNameSimply1      = N'" & FormatSQL(z7101.CustomerNameSimply1) & "', " 
    SQL = SQL & "    K7101_sePassWord      = N'" & FormatSQL(z7101.sePassWord) & "', " 
    SQL = SQL & "    K7101_cdPassWord      = N'" & FormatSQL(z7101.cdPassWord) & "', " 
    SQL = SQL & "    K7101_seDeliveryTerm      = N'" & FormatSQL(z7101.seDeliveryTerm) & "', " 
    SQL = SQL & "    K7101_cdDeliveryTerm      = N'" & FormatSQL(z7101.cdDeliveryTerm) & "', " 
    SQL = SQL & "    K7101_sePaymentTerm      = N'" & FormatSQL(z7101.sePaymentTerm) & "', " 
    SQL = SQL & "    K7101_cdPaymentTerm      = N'" & FormatSQL(z7101.cdPaymentTerm) & "', " 
    SQL = SQL & "    K7101_sePaymentCondition      = N'" & FormatSQL(z7101.sePaymentCondition) & "', " 
    SQL = SQL & "    K7101_cdPaymentCondition      = N'" & FormatSQL(z7101.cdPaymentCondition) & "', " 
    SQL = SQL & "    K7101_sePaymentDay      = N'" & FormatSQL(z7101.sePaymentDay) & "', " 
    SQL = SQL & "    K7101_cdPaymentDay      = N'" & FormatSQL(z7101.cdPaymentDay) & "', " 
    SQL = SQL & "    K7101_sePaymentTime      = N'" & FormatSQL(z7101.sePaymentTime) & "', " 
    SQL = SQL & "    K7101_cdPaymentTime      = N'" & FormatSQL(z7101.cdPaymentTime) & "', " 
    SQL = SQL & "    K7101_seSite      = N'" & FormatSQL(z7101.seSite) & "', " 
    SQL = SQL & "    K7101_cdSite      = N'" & FormatSQL(z7101.cdSite) & "', " 
    SQL = SQL & "    K7101_seTeam      = N'" & FormatSQL(z7101.seTeam) & "', " 
    SQL = SQL & "    K7101_cdTeam      = N'" & FormatSQL(z7101.cdTeam) & "', " 
    SQL = SQL & "    K7101_ForeignName1      = N'" & FormatSQL(z7101.ForeignName1) & "', " 
    SQL = SQL & "    K7101_ForeignName2      = N'" & FormatSQL(z7101.ForeignName2) & "', " 
    SQL = SQL & "    K7101_CompanyID      = N'" & FormatSQL(z7101.CompanyID) & "', " 
    SQL = SQL & "    K7101_CompanyType      = N'" & FormatSQL(z7101.CompanyType) & "', " 
    SQL = SQL & "    K7101_CompanyItem      = N'" & FormatSQL(z7101.CompanyItem) & "', " 
    SQL = SQL & "    K7101_Representative      = N'" & FormatSQL(z7101.Representative) & "', " 
    SQL = SQL & "    K7101_AddressNo      = N'" & FormatSQL(z7101.AddressNo) & "', " 
    SQL = SQL & "    K7101_Address1      = N'" & FormatSQL(z7101.Address1) & "', " 
    SQL = SQL & "    K7101_Address2      = N'" & FormatSQL(z7101.Address2) & "', " 
    SQL = SQL & "    K7101_Destination      = N'" & FormatSQL(z7101.Destination) & "', " 
    SQL = SQL & "    K7101_FinalShop      = N'" & FormatSQL(z7101.FinalShop) & "', " 
    SQL = SQL & "    K7101_Country      = N'" & FormatSQL(z7101.Country) & "', " 
    SQL = SQL & "    K7101_InvoiceAccount      = N'" & FormatSQL(z7101.InvoiceAccount) & "', " 
    SQL = SQL & "    K7101_TaxExempt      = N'" & FormatSQL(z7101.TaxExempt) & "', " 
    SQL = SQL & "    K7101_seSupplierGroup      = N'" & FormatSQL(z7101.seSupplierGroup) & "', " 
    SQL = SQL & "    K7101_cdSupplierGroup      = N'" & FormatSQL(z7101.cdSupplierGroup) & "', " 
    SQL = SQL & "    K7101_sePOGroup      = N'" & FormatSQL(z7101.sePOGroup) & "', " 
    SQL = SQL & "    K7101_cdPOGroup      = N'" & FormatSQL(z7101.cdPOGroup) & "', " 
    SQL = SQL & "    K7101_seSOGroup      = N'" & FormatSQL(z7101.seSOGroup) & "', " 
    SQL = SQL & "    K7101_cdSOGroup      = N'" & FormatSQL(z7101.cdSOGroup) & "', " 
    SQL = SQL & "    K7101_TelephoneCompany      = N'" & FormatSQL(z7101.TelephoneCompany) & "', " 
    SQL = SQL & "    K7101_TelephoneHand      = N'" & FormatSQL(z7101.TelephoneHand) & "', " 
    SQL = SQL & "    K7101_FaxNo      = N'" & FormatSQL(z7101.FaxNo) & "', " 
    SQL = SQL & "    K7101_Email      = N'" & FormatSQL(z7101.Email) & "', " 
    SQL = SQL & "    K7101_BeneficiaryName      = N'" & FormatSQL(z7101.BeneficiaryName) & "', " 
    SQL = SQL & "    K7101_AccountNumber      = N'" & FormatSQL(z7101.AccountNumber) & "', " 
    SQL = SQL & "    K7101_BankName      = N'" & FormatSQL(z7101.BankName) & "', " 
    SQL = SQL & "    K7101_BankAddress      = N'" & FormatSQL(z7101.BankAddress) & "', " 
    SQL = SQL & "    K7101_SwiftCode      = N'" & FormatSQL(z7101.SwiftCode) & "', " 
    SQL = SQL & "    K7101_cdFactory      = N'" & FormatSQL(z7101.cdFactory) & "', " 
            SQL = SQL & "    K7101_CheckKindCustomer      = N'" & FormatSQL(z7101.CheckKindCustomer) & "', "
            SQL = SQL & "    K7101_seCancelDate      = N'" & FormatSQL(z7101.seCancelDate) & "', "
            SQL = SQL & "    K7101_cdCancelDate      = N'" & FormatSQL(z7101.cdCancelDate) & "', "

    SQL = SQL & "    K7101_seCustomerDivision      = N'" & FormatSQL(z7101.seCustomerDivision) & "', " 
    SQL = SQL & "    K7101_cdCustomerDivision      = N'" & FormatSQL(z7101.cdCustomerDivision) & "', " 
    SQL = SQL & "    K7101_seCustomerLocation      = N'" & FormatSQL(z7101.seCustomerLocation) & "', " 
    SQL = SQL & "    K7101_cdCustomerLocation      = N'" & FormatSQL(z7101.cdCustomerLocation) & "', " 
    SQL = SQL & "    K7101_seTaxGroup      = N'" & FormatSQL(z7101.seTaxGroup) & "', " 
    SQL = SQL & "    K7101_cdTaxGroup      = N'" & FormatSQL(z7101.cdTaxGroup) & "', " 
    SQL = SQL & "    K7101_InCharge      = N'" & FormatSQL(z7101.InCharge) & "', " 
    SQL = SQL & "    K7101_InChargeSale      = N'" & FormatSQL(z7101.InChargeSale) & "', " 
    SQL = SQL & "    K7101_CheckTax      = N'" & FormatSQL(z7101.CheckTax) & "', " 
    SQL = SQL & "    K7101_CheckCustomer      = N'" & FormatSQL(z7101.CheckCustomer) & "', " 
    SQL = SQL & "    K7101_CheckSupplier      = N'" & FormatSQL(z7101.CheckSupplier) & "', " 
    SQL = SQL & "    K7101_CheckEmployee      = N'" & FormatSQL(z7101.CheckEmployee) & "', " 
    SQL = SQL & "    K7101_CheckInside      = N'" & FormatSQL(z7101.CheckInside) & "', " 
    SQL = SQL & "    K7101_CheckOutside      = N'" & FormatSQL(z7101.CheckOutside) & "', " 
    SQL = SQL & "    K7101_CheckOthers      = N'" & FormatSQL(z7101.CheckOthers) & "', " 
    SQL = SQL & "    K7101_CheckUse      = N'" & FormatSQL(z7101.CheckUse) & "', " 
    SQL = SQL & "    K7101_InchargeInsert      = N'" & FormatSQL(z7101.InchargeInsert) & "', " 
    SQL = SQL & "    K7101_InchargeUpdate      = N'" & FormatSQL(z7101.InchargeUpdate) & "', " 
    SQL = SQL & "    K7101_DateInsert      = N'" & FormatSQL(z7101.DateInsert) & "', " 
    SQL = SQL & "    K7101_DateUpdate      = N'" & FormatSQL(z7101.DateUpdate) & "', " 
    SQL = SQL & "    K7101_TimeInsert      = N'" & FormatSQL(z7101.TimeInsert) & "', " 
    SQL = SQL & "    K7101_TimeUpdate      = N'" & FormatSQL(z7101.TimeUpdate) & "', " 
    SQL = SQL & "    K7101_TimeLast      = N'" & FormatSQL(z7101.TimeLast) & "', " 
    SQL = SQL & "    K7101_DateActive      = N'" & FormatSQL(z7101.DateActive) & "', " 
    SQL = SQL & "    K7101_DateDeactive      = N'" & FormatSQL(z7101.DateDeactive) & "', " 
    SQL = SQL & "    K7101_CheckActive      = N'" & FormatSQL(z7101.CheckActive) & "', " 
    SQL = SQL & "    K7101_ParaNo1      =  " & FormatSQL(z7101.ParaNo1) & ", " 
    SQL = SQL & "    K7101_ParaNo2      =  " & FormatSQL(z7101.ParaNo2) & ", " 
    SQL = SQL & "    K7101_ParaNo3      =  " & FormatSQL(z7101.ParaNo3) & ", " 
    SQL = SQL & "    K7101_CheckSync      = N'" & FormatSQL(z7101.CheckSync) & "', " 
    SQL = SQL & "    K7101_CheckCustomerStatus      = N'" & FormatSQL(z7101.CheckCustomerStatus) & "', " 
    SQL = SQL & "    K7101_DateComplete      = N'" & FormatSQL(z7101.DateComplete) & "', " 
    SQL = SQL & "    K7101_DateApproved      = N'" & FormatSQL(z7101.DateApproved) & "', " 
    SQL = SQL & "    K7101_DateCancel      = N'" & FormatSQL(z7101.DateCancel) & "', " 
    SQL = SQL & "    K7101_DatePending1      = N'" & FormatSQL(z7101.DatePending1) & "', " 
    SQL = SQL & "    K7101_DatePending2      = N'" & FormatSQL(z7101.DatePending2) & "', " 
    SQL = SQL & "    K7101_Remark      = N'" & FormatSQL(z7101.Remark) & "', " 
    SQL = SQL & "    K7101_CheckOption1      = N'" & FormatSQL(z7101.CheckOption1) & "', " 
    SQL = SQL & "    K7101_CheckOption2      = N'" & FormatSQL(z7101.CheckOption2) & "', " 
    SQL = SQL & "    K7101_CheckOption3      = N'" & FormatSQL(z7101.CheckOption3) & "', " 
    SQL = SQL & "    K7101_CheckOption4      = N'" & FormatSQL(z7101.CheckOption4) & "', " 
    SQL = SQL & "    K7101_CheckOption5      = N'" & FormatSQL(z7101.CheckOption5) & "', " 
    SQL = SQL & "    K7101_CheckOption6      = N'" & FormatSQL(z7101.CheckOption6) & "', " 
    SQL = SQL & "    K7101_CheckOption7      = N'" & FormatSQL(z7101.CheckOption7) & "', " 
    SQL = SQL & "    K7101_CheckOption8      = N'" & FormatSQL(z7101.CheckOption8) & "', " 
    SQL = SQL & "    K7101_CheckOption9      = N'" & FormatSQL(z7101.CheckOption9) & "', " 
    SQL = SQL & "    K7101_CheckOption10      = N'" & FormatSQL(z7101.CheckOption10) & "'  " 
    SQL = SQL & " WHERE K7101_CustomerCode		 = '" & z7101.CustomerCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
	REWRITE_PFK7101 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7101",vbCritical)
Finally
        Call GetFullInformation("PFK7101", "U", SQL)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7101(z7101 As T7101_AREA) As Boolean
    DELETE_PFK7101 = False

   Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7101)
      
        SQL = " DELETE FROM PFK7101  "
    SQL = SQL & " WHERE K7101_CustomerCode		 = '" & z7101.CustomerCode & "' " 

    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7101 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7101",vbCritical)
Finally
        Call GetFullInformation("PFK7101", "U", SQL)
  End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7101_CLEAR()
Try
    
   D7101.CustomerCode = ""
   D7101.ACodeReceivable = ""
   D7101.ACodePayable = ""
   D7101.DevelopmentCode = ""
   D7101.CustomerName = ""
   D7101.CustomerName1 = ""
   D7101.CustomerNameSimply = ""
   D7101.CustomerNameSimply1 = ""
   D7101.sePassWord = ""
   D7101.cdPassWord = ""
   D7101.seDeliveryTerm = ""
   D7101.cdDeliveryTerm = ""
   D7101.sePaymentTerm = ""
   D7101.cdPaymentTerm = ""
   D7101.sePaymentCondition = ""
   D7101.cdPaymentCondition = ""
   D7101.sePaymentDay = ""
   D7101.cdPaymentDay = ""
   D7101.sePaymentTime = ""
   D7101.cdPaymentTime = ""
   D7101.seSite = ""
   D7101.cdSite = ""
   D7101.seTeam = ""
   D7101.cdTeam = ""
   D7101.ForeignName1 = ""
   D7101.ForeignName2 = ""
   D7101.CompanyID = ""
   D7101.CompanyType = ""
   D7101.CompanyItem = ""
   D7101.Representative = ""
   D7101.AddressNo = ""
   D7101.Address1 = ""
   D7101.Address2 = ""
   D7101.Destination = ""
   D7101.FinalShop = ""
   D7101.Country = ""
   D7101.InvoiceAccount = ""
   D7101.TaxExempt = ""
   D7101.seSupplierGroup = ""
   D7101.cdSupplierGroup = ""
   D7101.sePOGroup = ""
   D7101.cdPOGroup = ""
   D7101.seSOGroup = ""
   D7101.cdSOGroup = ""
   D7101.TelephoneCompany = ""
   D7101.TelephoneHand = ""
   D7101.FaxNo = ""
   D7101.Email = ""
   D7101.BeneficiaryName = ""
   D7101.AccountNumber = ""
   D7101.BankName = ""
   D7101.BankAddress = ""
   D7101.SwiftCode = ""
   D7101.cdFactory = ""
            D7101.CheckKindCustomer = ""
            D7101.seCancelDate = ""
            D7101.cdCancelDate = ""
   D7101.seCustomerDivision = ""
   D7101.cdCustomerDivision = ""
   D7101.seCustomerLocation = ""
   D7101.cdCustomerLocation = ""
   D7101.seTaxGroup = ""
   D7101.cdTaxGroup = ""
   D7101.InCharge = ""
   D7101.InChargeSale = ""
   D7101.CheckTax = ""
   D7101.CheckCustomer = ""
   D7101.CheckSupplier = ""
   D7101.CheckEmployee = ""
   D7101.CheckInside = ""
   D7101.CheckOutside = ""
   D7101.CheckOthers = ""
   D7101.CheckUse = ""
   D7101.InchargeInsert = ""
   D7101.InchargeUpdate = ""
   D7101.DateInsert = ""
   D7101.DateUpdate = ""
   D7101.TimeInsert = ""
   D7101.TimeUpdate = ""
   D7101.TimeLast = ""
   D7101.DateActive = ""
   D7101.DateDeactive = ""
   D7101.CheckActive = ""
    D7101.ParaNo1 = 0 
    D7101.ParaNo2 = 0 
    D7101.ParaNo3 = 0 
   D7101.CheckSync = ""
   D7101.CheckCustomerStatus = ""
   D7101.DateComplete = ""
   D7101.DateApproved = ""
   D7101.DateCancel = ""
   D7101.DatePending1 = ""
   D7101.DatePending2 = ""
   D7101.Remark = ""
   D7101.CheckOption1 = ""
   D7101.CheckOption2 = ""
   D7101.CheckOption3 = ""
   D7101.CheckOption4 = ""
   D7101.CheckOption5 = ""
   D7101.CheckOption6 = ""
   D7101.CheckOption7 = ""
   D7101.CheckOption8 = ""
   D7101.CheckOption9 = ""
   D7101.CheckOption10 = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7101_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7101 As T7101_AREA)
Try
    
    x7101.CustomerCode = trim$(  x7101.CustomerCode)
    x7101.ACodeReceivable = trim$(  x7101.ACodeReceivable)
    x7101.ACodePayable = trim$(  x7101.ACodePayable)
    x7101.DevelopmentCode = trim$(  x7101.DevelopmentCode)
    x7101.CustomerName = trim$(  x7101.CustomerName)
    x7101.CustomerName1 = trim$(  x7101.CustomerName1)
    x7101.CustomerNameSimply = trim$(  x7101.CustomerNameSimply)
    x7101.CustomerNameSimply1 = trim$(  x7101.CustomerNameSimply1)
    x7101.sePassWord = trim$(  x7101.sePassWord)
    x7101.cdPassWord = trim$(  x7101.cdPassWord)
    x7101.seDeliveryTerm = trim$(  x7101.seDeliveryTerm)
    x7101.cdDeliveryTerm = trim$(  x7101.cdDeliveryTerm)
    x7101.sePaymentTerm = trim$(  x7101.sePaymentTerm)
    x7101.cdPaymentTerm = trim$(  x7101.cdPaymentTerm)
    x7101.sePaymentCondition = trim$(  x7101.sePaymentCondition)
    x7101.cdPaymentCondition = trim$(  x7101.cdPaymentCondition)
    x7101.sePaymentDay = trim$(  x7101.sePaymentDay)
    x7101.cdPaymentDay = trim$(  x7101.cdPaymentDay)
    x7101.sePaymentTime = trim$(  x7101.sePaymentTime)
    x7101.cdPaymentTime = trim$(  x7101.cdPaymentTime)
    x7101.seSite = trim$(  x7101.seSite)
    x7101.cdSite = trim$(  x7101.cdSite)
    x7101.seTeam = trim$(  x7101.seTeam)
    x7101.cdTeam = trim$(  x7101.cdTeam)
    x7101.ForeignName1 = trim$(  x7101.ForeignName1)
    x7101.ForeignName2 = trim$(  x7101.ForeignName2)
    x7101.CompanyID = trim$(  x7101.CompanyID)
    x7101.CompanyType = trim$(  x7101.CompanyType)
    x7101.CompanyItem = trim$(  x7101.CompanyItem)
    x7101.Representative = trim$(  x7101.Representative)
    x7101.AddressNo = trim$(  x7101.AddressNo)
    x7101.Address1 = trim$(  x7101.Address1)
    x7101.Address2 = trim$(  x7101.Address2)
    x7101.Destination = trim$(  x7101.Destination)
    x7101.FinalShop = trim$(  x7101.FinalShop)
    x7101.Country = trim$(  x7101.Country)
    x7101.InvoiceAccount = trim$(  x7101.InvoiceAccount)
    x7101.TaxExempt = trim$(  x7101.TaxExempt)
    x7101.seSupplierGroup = trim$(  x7101.seSupplierGroup)
    x7101.cdSupplierGroup = trim$(  x7101.cdSupplierGroup)
    x7101.sePOGroup = trim$(  x7101.sePOGroup)
    x7101.cdPOGroup = trim$(  x7101.cdPOGroup)
    x7101.seSOGroup = trim$(  x7101.seSOGroup)
    x7101.cdSOGroup = trim$(  x7101.cdSOGroup)
    x7101.TelephoneCompany = trim$(  x7101.TelephoneCompany)
    x7101.TelephoneHand = trim$(  x7101.TelephoneHand)
    x7101.FaxNo = trim$(  x7101.FaxNo)
    x7101.Email = trim$(  x7101.Email)
    x7101.BeneficiaryName = trim$(  x7101.BeneficiaryName)
    x7101.AccountNumber = trim$(  x7101.AccountNumber)
    x7101.BankName = trim$(  x7101.BankName)
    x7101.BankAddress = trim$(  x7101.BankAddress)
    x7101.SwiftCode = trim$(  x7101.SwiftCode)
    x7101.cdFactory = trim$(  x7101.cdFactory)
            x7101.CheckKindCustomer = Trim$(x7101.CheckKindCustomer)
            x7101.seCancelDate = Trim$(x7101.seCancelDate)
            x7101.cdCancelDate = Trim$(x7101.cdCancelDate)
    x7101.seCustomerDivision = trim$(  x7101.seCustomerDivision)
    x7101.cdCustomerDivision = trim$(  x7101.cdCustomerDivision)
    x7101.seCustomerLocation = trim$(  x7101.seCustomerLocation)
    x7101.cdCustomerLocation = trim$(  x7101.cdCustomerLocation)
    x7101.seTaxGroup = trim$(  x7101.seTaxGroup)
    x7101.cdTaxGroup = trim$(  x7101.cdTaxGroup)
    x7101.InCharge = trim$(  x7101.InCharge)
    x7101.InChargeSale = trim$(  x7101.InChargeSale)
    x7101.CheckTax = trim$(  x7101.CheckTax)
    x7101.CheckCustomer = trim$(  x7101.CheckCustomer)
    x7101.CheckSupplier = trim$(  x7101.CheckSupplier)
    x7101.CheckEmployee = trim$(  x7101.CheckEmployee)
    x7101.CheckInside = trim$(  x7101.CheckInside)
    x7101.CheckOutside = trim$(  x7101.CheckOutside)
    x7101.CheckOthers = trim$(  x7101.CheckOthers)
    x7101.CheckUse = trim$(  x7101.CheckUse)
    x7101.InchargeInsert = trim$(  x7101.InchargeInsert)
    x7101.InchargeUpdate = trim$(  x7101.InchargeUpdate)
    x7101.DateInsert = trim$(  x7101.DateInsert)
    x7101.DateUpdate = trim$(  x7101.DateUpdate)
    x7101.TimeInsert = trim$(  x7101.TimeInsert)
    x7101.TimeUpdate = trim$(  x7101.TimeUpdate)
    x7101.TimeLast = trim$(  x7101.TimeLast)
    x7101.DateActive = trim$(  x7101.DateActive)
    x7101.DateDeactive = trim$(  x7101.DateDeactive)
    x7101.CheckActive = trim$(  x7101.CheckActive)
    x7101.ParaNo1 = trim$(  x7101.ParaNo1)
    x7101.ParaNo2 = trim$(  x7101.ParaNo2)
    x7101.ParaNo3 = trim$(  x7101.ParaNo3)
    x7101.CheckSync = trim$(  x7101.CheckSync)
    x7101.CheckCustomerStatus = trim$(  x7101.CheckCustomerStatus)
    x7101.DateComplete = trim$(  x7101.DateComplete)
    x7101.DateApproved = trim$(  x7101.DateApproved)
    x7101.DateCancel = trim$(  x7101.DateCancel)
    x7101.DatePending1 = trim$(  x7101.DatePending1)
    x7101.DatePending2 = trim$(  x7101.DatePending2)
    x7101.Remark = trim$(  x7101.Remark)
    x7101.CheckOption1 = trim$(  x7101.CheckOption1)
    x7101.CheckOption2 = trim$(  x7101.CheckOption2)
    x7101.CheckOption3 = trim$(  x7101.CheckOption3)
    x7101.CheckOption4 = trim$(  x7101.CheckOption4)
    x7101.CheckOption5 = trim$(  x7101.CheckOption5)
    x7101.CheckOption6 = trim$(  x7101.CheckOption6)
    x7101.CheckOption7 = trim$(  x7101.CheckOption7)
    x7101.CheckOption8 = trim$(  x7101.CheckOption8)
    x7101.CheckOption9 = trim$(  x7101.CheckOption9)
    x7101.CheckOption10 = trim$(  x7101.CheckOption10)
     
    If trim$( x7101.CustomerCode ) = "" Then x7101.CustomerCode = Space(1) 
    If trim$( x7101.ACodeReceivable ) = "" Then x7101.ACodeReceivable = Space(1) 
    If trim$( x7101.ACodePayable ) = "" Then x7101.ACodePayable = Space(1) 
    If trim$( x7101.DevelopmentCode ) = "" Then x7101.DevelopmentCode = Space(1) 
    If trim$( x7101.CustomerName ) = "" Then x7101.CustomerName = Space(1) 
    If trim$( x7101.CustomerName1 ) = "" Then x7101.CustomerName1 = Space(1) 
    If trim$( x7101.CustomerNameSimply ) = "" Then x7101.CustomerNameSimply = Space(1) 
    If trim$( x7101.CustomerNameSimply1 ) = "" Then x7101.CustomerNameSimply1 = Space(1) 
    If trim$( x7101.sePassWord ) = "" Then x7101.sePassWord = Space(1) 
    If trim$( x7101.cdPassWord ) = "" Then x7101.cdPassWord = Space(1) 
    If trim$( x7101.seDeliveryTerm ) = "" Then x7101.seDeliveryTerm = Space(1) 
    If trim$( x7101.cdDeliveryTerm ) = "" Then x7101.cdDeliveryTerm = Space(1) 
    If trim$( x7101.sePaymentTerm ) = "" Then x7101.sePaymentTerm = Space(1) 
    If trim$( x7101.cdPaymentTerm ) = "" Then x7101.cdPaymentTerm = Space(1) 
    If trim$( x7101.sePaymentCondition ) = "" Then x7101.sePaymentCondition = Space(1) 
    If trim$( x7101.cdPaymentCondition ) = "" Then x7101.cdPaymentCondition = Space(1) 
    If trim$( x7101.sePaymentDay ) = "" Then x7101.sePaymentDay = Space(1) 
    If trim$( x7101.cdPaymentDay ) = "" Then x7101.cdPaymentDay = Space(1) 
    If trim$( x7101.sePaymentTime ) = "" Then x7101.sePaymentTime = Space(1) 
    If trim$( x7101.cdPaymentTime ) = "" Then x7101.cdPaymentTime = Space(1) 
    If trim$( x7101.seSite ) = "" Then x7101.seSite = Space(1) 
    If trim$( x7101.cdSite ) = "" Then x7101.cdSite = Space(1) 
    If trim$( x7101.seTeam ) = "" Then x7101.seTeam = Space(1) 
    If trim$( x7101.cdTeam ) = "" Then x7101.cdTeam = Space(1) 
    If trim$( x7101.ForeignName1 ) = "" Then x7101.ForeignName1 = Space(1) 
    If trim$( x7101.ForeignName2 ) = "" Then x7101.ForeignName2 = Space(1) 
    If trim$( x7101.CompanyID ) = "" Then x7101.CompanyID = Space(1) 
    If trim$( x7101.CompanyType ) = "" Then x7101.CompanyType = Space(1) 
    If trim$( x7101.CompanyItem ) = "" Then x7101.CompanyItem = Space(1) 
    If trim$( x7101.Representative ) = "" Then x7101.Representative = Space(1) 
    If trim$( x7101.AddressNo ) = "" Then x7101.AddressNo = Space(1) 
    If trim$( x7101.Address1 ) = "" Then x7101.Address1 = Space(1) 
    If trim$( x7101.Address2 ) = "" Then x7101.Address2 = Space(1) 
    If trim$( x7101.Destination ) = "" Then x7101.Destination = Space(1) 
    If trim$( x7101.FinalShop ) = "" Then x7101.FinalShop = Space(1) 
    If trim$( x7101.Country ) = "" Then x7101.Country = Space(1) 
    If trim$( x7101.InvoiceAccount ) = "" Then x7101.InvoiceAccount = Space(1) 
    If trim$( x7101.TaxExempt ) = "" Then x7101.TaxExempt = Space(1) 
    If trim$( x7101.seSupplierGroup ) = "" Then x7101.seSupplierGroup = Space(1) 
    If trim$( x7101.cdSupplierGroup ) = "" Then x7101.cdSupplierGroup = Space(1) 
    If trim$( x7101.sePOGroup ) = "" Then x7101.sePOGroup = Space(1) 
    If trim$( x7101.cdPOGroup ) = "" Then x7101.cdPOGroup = Space(1) 
    If trim$( x7101.seSOGroup ) = "" Then x7101.seSOGroup = Space(1) 
    If trim$( x7101.cdSOGroup ) = "" Then x7101.cdSOGroup = Space(1) 
    If trim$( x7101.TelephoneCompany ) = "" Then x7101.TelephoneCompany = Space(1) 
    If trim$( x7101.TelephoneHand ) = "" Then x7101.TelephoneHand = Space(1) 
    If trim$( x7101.FaxNo ) = "" Then x7101.FaxNo = Space(1) 
    If trim$( x7101.Email ) = "" Then x7101.Email = Space(1) 
    If trim$( x7101.BeneficiaryName ) = "" Then x7101.BeneficiaryName = Space(1) 
    If trim$( x7101.AccountNumber ) = "" Then x7101.AccountNumber = Space(1) 
    If trim$( x7101.BankName ) = "" Then x7101.BankName = Space(1) 
    If trim$( x7101.BankAddress ) = "" Then x7101.BankAddress = Space(1) 
    If trim$( x7101.SwiftCode ) = "" Then x7101.SwiftCode = Space(1) 
    If trim$( x7101.cdFactory ) = "" Then x7101.cdFactory = Space(1) 
            If Trim$(x7101.CheckKindCustomer) = "" Then x7101.CheckKindCustomer = Space(1)
            If Trim$(x7101.seCancelDate) = "" Then x7101.seCancelDate = Space(1)
            If Trim$(x7101.cdCancelDate) = "" Then x7101.cdCancelDate = Space(1)
    If trim$( x7101.seCustomerDivision ) = "" Then x7101.seCustomerDivision = Space(1) 
    If trim$( x7101.cdCustomerDivision ) = "" Then x7101.cdCustomerDivision = Space(1) 
    If trim$( x7101.seCustomerLocation ) = "" Then x7101.seCustomerLocation = Space(1) 
    If trim$( x7101.cdCustomerLocation ) = "" Then x7101.cdCustomerLocation = Space(1) 
    If trim$( x7101.seTaxGroup ) = "" Then x7101.seTaxGroup = Space(1) 
    If trim$( x7101.cdTaxGroup ) = "" Then x7101.cdTaxGroup = Space(1) 
    If trim$( x7101.InCharge ) = "" Then x7101.InCharge = Space(1) 
    If trim$( x7101.InChargeSale ) = "" Then x7101.InChargeSale = Space(1) 
    If trim$( x7101.CheckTax ) = "" Then x7101.CheckTax = Space(1) 
    If trim$( x7101.CheckCustomer ) = "" Then x7101.CheckCustomer = Space(1) 
    If trim$( x7101.CheckSupplier ) = "" Then x7101.CheckSupplier = Space(1) 
    If trim$( x7101.CheckEmployee ) = "" Then x7101.CheckEmployee = Space(1) 
    If trim$( x7101.CheckInside ) = "" Then x7101.CheckInside = Space(1) 
    If trim$( x7101.CheckOutside ) = "" Then x7101.CheckOutside = Space(1) 
    If trim$( x7101.CheckOthers ) = "" Then x7101.CheckOthers = Space(1) 
    If trim$( x7101.CheckUse ) = "" Then x7101.CheckUse = Space(1) 
    If trim$( x7101.InchargeInsert ) = "" Then x7101.InchargeInsert = Space(1) 
    If trim$( x7101.InchargeUpdate ) = "" Then x7101.InchargeUpdate = Space(1) 
    If trim$( x7101.DateInsert ) = "" Then x7101.DateInsert = Space(1) 
    If trim$( x7101.DateUpdate ) = "" Then x7101.DateUpdate = Space(1) 
    If trim$( x7101.TimeInsert ) = "" Then x7101.TimeInsert = Space(1) 
    If trim$( x7101.TimeUpdate ) = "" Then x7101.TimeUpdate = Space(1) 
    If trim$( x7101.TimeLast ) = "" Then x7101.TimeLast = Space(1) 
    If trim$( x7101.DateActive ) = "" Then x7101.DateActive = Space(1) 
    If trim$( x7101.DateDeactive ) = "" Then x7101.DateDeactive = Space(1) 
    If trim$( x7101.CheckActive ) = "" Then x7101.CheckActive = Space(1) 
    If trim$( x7101.ParaNo1 ) = "" Then x7101.ParaNo1 = 0 
    If trim$( x7101.ParaNo2 ) = "" Then x7101.ParaNo2 = 0 
    If trim$( x7101.ParaNo3 ) = "" Then x7101.ParaNo3 = 0 
    If trim$( x7101.CheckSync ) = "" Then x7101.CheckSync = Space(1) 
    If trim$( x7101.CheckCustomerStatus ) = "" Then x7101.CheckCustomerStatus = Space(1) 
    If trim$( x7101.DateComplete ) = "" Then x7101.DateComplete = Space(1) 
    If trim$( x7101.DateApproved ) = "" Then x7101.DateApproved = Space(1) 
    If trim$( x7101.DateCancel ) = "" Then x7101.DateCancel = Space(1) 
    If trim$( x7101.DatePending1 ) = "" Then x7101.DatePending1 = Space(1) 
    If trim$( x7101.DatePending2 ) = "" Then x7101.DatePending2 = Space(1) 
    If trim$( x7101.Remark ) = "" Then x7101.Remark = Space(1) 
    If trim$( x7101.CheckOption1 ) = "" Then x7101.CheckOption1 = Space(1) 
    If trim$( x7101.CheckOption2 ) = "" Then x7101.CheckOption2 = Space(1) 
    If trim$( x7101.CheckOption3 ) = "" Then x7101.CheckOption3 = Space(1) 
    If trim$( x7101.CheckOption4 ) = "" Then x7101.CheckOption4 = Space(1) 
    If trim$( x7101.CheckOption5 ) = "" Then x7101.CheckOption5 = Space(1) 
    If trim$( x7101.CheckOption6 ) = "" Then x7101.CheckOption6 = Space(1) 
    If trim$( x7101.CheckOption7 ) = "" Then x7101.CheckOption7 = Space(1) 
    If trim$( x7101.CheckOption8 ) = "" Then x7101.CheckOption8 = Space(1) 
    If trim$( x7101.CheckOption9 ) = "" Then x7101.CheckOption9 = Space(1) 
    If trim$( x7101.CheckOption10 ) = "" Then x7101.CheckOption10 = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7101_MOVE(rs7101 As SqlClient.SqlDataReader)
Try

    call D7101_CLEAR()   

    If IsdbNull(rs7101!K7101_CustomerCode) = False Then D7101.CustomerCode = Trim$(rs7101!K7101_CustomerCode)
    If IsdbNull(rs7101!K7101_ACodeReceivable) = False Then D7101.ACodeReceivable = Trim$(rs7101!K7101_ACodeReceivable)
    If IsdbNull(rs7101!K7101_ACodePayable) = False Then D7101.ACodePayable = Trim$(rs7101!K7101_ACodePayable)
    If IsdbNull(rs7101!K7101_DevelopmentCode) = False Then D7101.DevelopmentCode = Trim$(rs7101!K7101_DevelopmentCode)
    If IsdbNull(rs7101!K7101_CustomerName) = False Then D7101.CustomerName = Trim$(rs7101!K7101_CustomerName)
    If IsdbNull(rs7101!K7101_CustomerName1) = False Then D7101.CustomerName1 = Trim$(rs7101!K7101_CustomerName1)
    If IsdbNull(rs7101!K7101_CustomerNameSimply) = False Then D7101.CustomerNameSimply = Trim$(rs7101!K7101_CustomerNameSimply)
    If IsdbNull(rs7101!K7101_CustomerNameSimply1) = False Then D7101.CustomerNameSimply1 = Trim$(rs7101!K7101_CustomerNameSimply1)
    If IsdbNull(rs7101!K7101_sePassWord) = False Then D7101.sePassWord = Trim$(rs7101!K7101_sePassWord)
    If IsdbNull(rs7101!K7101_cdPassWord) = False Then D7101.cdPassWord = Trim$(rs7101!K7101_cdPassWord)
    If IsdbNull(rs7101!K7101_seDeliveryTerm) = False Then D7101.seDeliveryTerm = Trim$(rs7101!K7101_seDeliveryTerm)
    If IsdbNull(rs7101!K7101_cdDeliveryTerm) = False Then D7101.cdDeliveryTerm = Trim$(rs7101!K7101_cdDeliveryTerm)
    If IsdbNull(rs7101!K7101_sePaymentTerm) = False Then D7101.sePaymentTerm = Trim$(rs7101!K7101_sePaymentTerm)
    If IsdbNull(rs7101!K7101_cdPaymentTerm) = False Then D7101.cdPaymentTerm = Trim$(rs7101!K7101_cdPaymentTerm)
    If IsdbNull(rs7101!K7101_sePaymentCondition) = False Then D7101.sePaymentCondition = Trim$(rs7101!K7101_sePaymentCondition)
    If IsdbNull(rs7101!K7101_cdPaymentCondition) = False Then D7101.cdPaymentCondition = Trim$(rs7101!K7101_cdPaymentCondition)
    If IsdbNull(rs7101!K7101_sePaymentDay) = False Then D7101.sePaymentDay = Trim$(rs7101!K7101_sePaymentDay)
    If IsdbNull(rs7101!K7101_cdPaymentDay) = False Then D7101.cdPaymentDay = Trim$(rs7101!K7101_cdPaymentDay)
    If IsdbNull(rs7101!K7101_sePaymentTime) = False Then D7101.sePaymentTime = Trim$(rs7101!K7101_sePaymentTime)
    If IsdbNull(rs7101!K7101_cdPaymentTime) = False Then D7101.cdPaymentTime = Trim$(rs7101!K7101_cdPaymentTime)
    If IsdbNull(rs7101!K7101_seSite) = False Then D7101.seSite = Trim$(rs7101!K7101_seSite)
    If IsdbNull(rs7101!K7101_cdSite) = False Then D7101.cdSite = Trim$(rs7101!K7101_cdSite)
    If IsdbNull(rs7101!K7101_seTeam) = False Then D7101.seTeam = Trim$(rs7101!K7101_seTeam)
    If IsdbNull(rs7101!K7101_cdTeam) = False Then D7101.cdTeam = Trim$(rs7101!K7101_cdTeam)
    If IsdbNull(rs7101!K7101_ForeignName1) = False Then D7101.ForeignName1 = Trim$(rs7101!K7101_ForeignName1)
    If IsdbNull(rs7101!K7101_ForeignName2) = False Then D7101.ForeignName2 = Trim$(rs7101!K7101_ForeignName2)
    If IsdbNull(rs7101!K7101_CompanyID) = False Then D7101.CompanyID = Trim$(rs7101!K7101_CompanyID)
    If IsdbNull(rs7101!K7101_CompanyType) = False Then D7101.CompanyType = Trim$(rs7101!K7101_CompanyType)
    If IsdbNull(rs7101!K7101_CompanyItem) = False Then D7101.CompanyItem = Trim$(rs7101!K7101_CompanyItem)
    If IsdbNull(rs7101!K7101_Representative) = False Then D7101.Representative = Trim$(rs7101!K7101_Representative)
    If IsdbNull(rs7101!K7101_AddressNo) = False Then D7101.AddressNo = Trim$(rs7101!K7101_AddressNo)
    If IsdbNull(rs7101!K7101_Address1) = False Then D7101.Address1 = Trim$(rs7101!K7101_Address1)
    If IsdbNull(rs7101!K7101_Address2) = False Then D7101.Address2 = Trim$(rs7101!K7101_Address2)
    If IsdbNull(rs7101!K7101_Destination) = False Then D7101.Destination = Trim$(rs7101!K7101_Destination)
    If IsdbNull(rs7101!K7101_FinalShop) = False Then D7101.FinalShop = Trim$(rs7101!K7101_FinalShop)
    If IsdbNull(rs7101!K7101_Country) = False Then D7101.Country = Trim$(rs7101!K7101_Country)
    If IsdbNull(rs7101!K7101_InvoiceAccount) = False Then D7101.InvoiceAccount = Trim$(rs7101!K7101_InvoiceAccount)
    If IsdbNull(rs7101!K7101_TaxExempt) = False Then D7101.TaxExempt = Trim$(rs7101!K7101_TaxExempt)
    If IsdbNull(rs7101!K7101_seSupplierGroup) = False Then D7101.seSupplierGroup = Trim$(rs7101!K7101_seSupplierGroup)
    If IsdbNull(rs7101!K7101_cdSupplierGroup) = False Then D7101.cdSupplierGroup = Trim$(rs7101!K7101_cdSupplierGroup)
    If IsdbNull(rs7101!K7101_sePOGroup) = False Then D7101.sePOGroup = Trim$(rs7101!K7101_sePOGroup)
    If IsdbNull(rs7101!K7101_cdPOGroup) = False Then D7101.cdPOGroup = Trim$(rs7101!K7101_cdPOGroup)
    If IsdbNull(rs7101!K7101_seSOGroup) = False Then D7101.seSOGroup = Trim$(rs7101!K7101_seSOGroup)
    If IsdbNull(rs7101!K7101_cdSOGroup) = False Then D7101.cdSOGroup = Trim$(rs7101!K7101_cdSOGroup)
    If IsdbNull(rs7101!K7101_TelephoneCompany) = False Then D7101.TelephoneCompany = Trim$(rs7101!K7101_TelephoneCompany)
    If IsdbNull(rs7101!K7101_TelephoneHand) = False Then D7101.TelephoneHand = Trim$(rs7101!K7101_TelephoneHand)
    If IsdbNull(rs7101!K7101_FaxNo) = False Then D7101.FaxNo = Trim$(rs7101!K7101_FaxNo)
    If IsdbNull(rs7101!K7101_Email) = False Then D7101.Email = Trim$(rs7101!K7101_Email)
    If IsdbNull(rs7101!K7101_BeneficiaryName) = False Then D7101.BeneficiaryName = Trim$(rs7101!K7101_BeneficiaryName)
    If IsdbNull(rs7101!K7101_AccountNumber) = False Then D7101.AccountNumber = Trim$(rs7101!K7101_AccountNumber)
    If IsdbNull(rs7101!K7101_BankName) = False Then D7101.BankName = Trim$(rs7101!K7101_BankName)
    If IsdbNull(rs7101!K7101_BankAddress) = False Then D7101.BankAddress = Trim$(rs7101!K7101_BankAddress)
    If IsdbNull(rs7101!K7101_SwiftCode) = False Then D7101.SwiftCode = Trim$(rs7101!K7101_SwiftCode)
    If IsdbNull(rs7101!K7101_cdFactory) = False Then D7101.cdFactory = Trim$(rs7101!K7101_cdFactory)
            If IsDBNull(rs7101!K7101_CheckKindCustomer) = False Then D7101.CheckKindCustomer = Trim$(rs7101!K7101_CheckKindCustomer)
            If IsDBNull(rs7101!K7101_seCancelDate) = False Then D7101.seCancelDate = Trim$(rs7101!K7101_seCancelDate)
            If IsDBNull(rs7101!K7101_cdCancelDate) = False Then D7101.cdCancelDate = Trim$(rs7101!K7101_cdCancelDate)

    If IsdbNull(rs7101!K7101_seCustomerDivision) = False Then D7101.seCustomerDivision = Trim$(rs7101!K7101_seCustomerDivision)
    If IsdbNull(rs7101!K7101_cdCustomerDivision) = False Then D7101.cdCustomerDivision = Trim$(rs7101!K7101_cdCustomerDivision)
    If IsdbNull(rs7101!K7101_seCustomerLocation) = False Then D7101.seCustomerLocation = Trim$(rs7101!K7101_seCustomerLocation)
    If IsdbNull(rs7101!K7101_cdCustomerLocation) = False Then D7101.cdCustomerLocation = Trim$(rs7101!K7101_cdCustomerLocation)
    If IsdbNull(rs7101!K7101_seTaxGroup) = False Then D7101.seTaxGroup = Trim$(rs7101!K7101_seTaxGroup)
    If IsdbNull(rs7101!K7101_cdTaxGroup) = False Then D7101.cdTaxGroup = Trim$(rs7101!K7101_cdTaxGroup)
    If IsdbNull(rs7101!K7101_InCharge) = False Then D7101.InCharge = Trim$(rs7101!K7101_InCharge)
    If IsdbNull(rs7101!K7101_InChargeSale) = False Then D7101.InChargeSale = Trim$(rs7101!K7101_InChargeSale)
    If IsdbNull(rs7101!K7101_CheckTax) = False Then D7101.CheckTax = Trim$(rs7101!K7101_CheckTax)
    If IsdbNull(rs7101!K7101_CheckCustomer) = False Then D7101.CheckCustomer = Trim$(rs7101!K7101_CheckCustomer)
    If IsdbNull(rs7101!K7101_CheckSupplier) = False Then D7101.CheckSupplier = Trim$(rs7101!K7101_CheckSupplier)
    If IsdbNull(rs7101!K7101_CheckEmployee) = False Then D7101.CheckEmployee = Trim$(rs7101!K7101_CheckEmployee)
    If IsdbNull(rs7101!K7101_CheckInside) = False Then D7101.CheckInside = Trim$(rs7101!K7101_CheckInside)
    If IsdbNull(rs7101!K7101_CheckOutside) = False Then D7101.CheckOutside = Trim$(rs7101!K7101_CheckOutside)
    If IsdbNull(rs7101!K7101_CheckOthers) = False Then D7101.CheckOthers = Trim$(rs7101!K7101_CheckOthers)
    If IsdbNull(rs7101!K7101_CheckUse) = False Then D7101.CheckUse = Trim$(rs7101!K7101_CheckUse)
    If IsdbNull(rs7101!K7101_InchargeInsert) = False Then D7101.InchargeInsert = Trim$(rs7101!K7101_InchargeInsert)
    If IsdbNull(rs7101!K7101_InchargeUpdate) = False Then D7101.InchargeUpdate = Trim$(rs7101!K7101_InchargeUpdate)
    If IsdbNull(rs7101!K7101_DateInsert) = False Then D7101.DateInsert = Trim$(rs7101!K7101_DateInsert)
    If IsdbNull(rs7101!K7101_DateUpdate) = False Then D7101.DateUpdate = Trim$(rs7101!K7101_DateUpdate)
    If IsdbNull(rs7101!K7101_TimeInsert) = False Then D7101.TimeInsert = Trim$(rs7101!K7101_TimeInsert)
    If IsdbNull(rs7101!K7101_TimeUpdate) = False Then D7101.TimeUpdate = Trim$(rs7101!K7101_TimeUpdate)
    If IsdbNull(rs7101!K7101_TimeLast) = False Then D7101.TimeLast = Trim$(rs7101!K7101_TimeLast)
    If IsdbNull(rs7101!K7101_DateActive) = False Then D7101.DateActive = Trim$(rs7101!K7101_DateActive)
    If IsdbNull(rs7101!K7101_DateDeactive) = False Then D7101.DateDeactive = Trim$(rs7101!K7101_DateDeactive)
    If IsdbNull(rs7101!K7101_CheckActive) = False Then D7101.CheckActive = Trim$(rs7101!K7101_CheckActive)
    If IsdbNull(rs7101!K7101_ParaNo1) = False Then D7101.ParaNo1 = Trim$(rs7101!K7101_ParaNo1)
    If IsdbNull(rs7101!K7101_ParaNo2) = False Then D7101.ParaNo2 = Trim$(rs7101!K7101_ParaNo2)
    If IsdbNull(rs7101!K7101_ParaNo3) = False Then D7101.ParaNo3 = Trim$(rs7101!K7101_ParaNo3)
    If IsdbNull(rs7101!K7101_CheckSync) = False Then D7101.CheckSync = Trim$(rs7101!K7101_CheckSync)
    If IsdbNull(rs7101!K7101_CheckCustomerStatus) = False Then D7101.CheckCustomerStatus = Trim$(rs7101!K7101_CheckCustomerStatus)
    If IsdbNull(rs7101!K7101_DateComplete) = False Then D7101.DateComplete = Trim$(rs7101!K7101_DateComplete)
    If IsdbNull(rs7101!K7101_DateApproved) = False Then D7101.DateApproved = Trim$(rs7101!K7101_DateApproved)
    If IsdbNull(rs7101!K7101_DateCancel) = False Then D7101.DateCancel = Trim$(rs7101!K7101_DateCancel)
    If IsdbNull(rs7101!K7101_DatePending1) = False Then D7101.DatePending1 = Trim$(rs7101!K7101_DatePending1)
    If IsdbNull(rs7101!K7101_DatePending2) = False Then D7101.DatePending2 = Trim$(rs7101!K7101_DatePending2)
    If IsdbNull(rs7101!K7101_Remark) = False Then D7101.Remark = Trim$(rs7101!K7101_Remark)
    If IsdbNull(rs7101!K7101_CheckOption1) = False Then D7101.CheckOption1 = Trim$(rs7101!K7101_CheckOption1)
    If IsdbNull(rs7101!K7101_CheckOption2) = False Then D7101.CheckOption2 = Trim$(rs7101!K7101_CheckOption2)
    If IsdbNull(rs7101!K7101_CheckOption3) = False Then D7101.CheckOption3 = Trim$(rs7101!K7101_CheckOption3)
    If IsdbNull(rs7101!K7101_CheckOption4) = False Then D7101.CheckOption4 = Trim$(rs7101!K7101_CheckOption4)
    If IsdbNull(rs7101!K7101_CheckOption5) = False Then D7101.CheckOption5 = Trim$(rs7101!K7101_CheckOption5)
    If IsdbNull(rs7101!K7101_CheckOption6) = False Then D7101.CheckOption6 = Trim$(rs7101!K7101_CheckOption6)
    If IsdbNull(rs7101!K7101_CheckOption7) = False Then D7101.CheckOption7 = Trim$(rs7101!K7101_CheckOption7)
    If IsdbNull(rs7101!K7101_CheckOption8) = False Then D7101.CheckOption8 = Trim$(rs7101!K7101_CheckOption8)
    If IsdbNull(rs7101!K7101_CheckOption9) = False Then D7101.CheckOption9 = Trim$(rs7101!K7101_CheckOption9)
    If IsdbNull(rs7101!K7101_CheckOption10) = False Then D7101.CheckOption10 = Trim$(rs7101!K7101_CheckOption10)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7101_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7101_MOVE(rs7101 As DataRow)
Try

    call D7101_CLEAR()   

    If IsdbNull(rs7101!K7101_CustomerCode) = False Then D7101.CustomerCode = Trim$(rs7101!K7101_CustomerCode)
    If IsdbNull(rs7101!K7101_ACodeReceivable) = False Then D7101.ACodeReceivable = Trim$(rs7101!K7101_ACodeReceivable)
    If IsdbNull(rs7101!K7101_ACodePayable) = False Then D7101.ACodePayable = Trim$(rs7101!K7101_ACodePayable)
    If IsdbNull(rs7101!K7101_DevelopmentCode) = False Then D7101.DevelopmentCode = Trim$(rs7101!K7101_DevelopmentCode)
    If IsdbNull(rs7101!K7101_CustomerName) = False Then D7101.CustomerName = Trim$(rs7101!K7101_CustomerName)
    If IsdbNull(rs7101!K7101_CustomerName1) = False Then D7101.CustomerName1 = Trim$(rs7101!K7101_CustomerName1)
    If IsdbNull(rs7101!K7101_CustomerNameSimply) = False Then D7101.CustomerNameSimply = Trim$(rs7101!K7101_CustomerNameSimply)
    If IsdbNull(rs7101!K7101_CustomerNameSimply1) = False Then D7101.CustomerNameSimply1 = Trim$(rs7101!K7101_CustomerNameSimply1)
    If IsdbNull(rs7101!K7101_sePassWord) = False Then D7101.sePassWord = Trim$(rs7101!K7101_sePassWord)
    If IsdbNull(rs7101!K7101_cdPassWord) = False Then D7101.cdPassWord = Trim$(rs7101!K7101_cdPassWord)
    If IsdbNull(rs7101!K7101_seDeliveryTerm) = False Then D7101.seDeliveryTerm = Trim$(rs7101!K7101_seDeliveryTerm)
    If IsdbNull(rs7101!K7101_cdDeliveryTerm) = False Then D7101.cdDeliveryTerm = Trim$(rs7101!K7101_cdDeliveryTerm)
    If IsdbNull(rs7101!K7101_sePaymentTerm) = False Then D7101.sePaymentTerm = Trim$(rs7101!K7101_sePaymentTerm)
    If IsdbNull(rs7101!K7101_cdPaymentTerm) = False Then D7101.cdPaymentTerm = Trim$(rs7101!K7101_cdPaymentTerm)
    If IsdbNull(rs7101!K7101_sePaymentCondition) = False Then D7101.sePaymentCondition = Trim$(rs7101!K7101_sePaymentCondition)
    If IsdbNull(rs7101!K7101_cdPaymentCondition) = False Then D7101.cdPaymentCondition = Trim$(rs7101!K7101_cdPaymentCondition)
    If IsdbNull(rs7101!K7101_sePaymentDay) = False Then D7101.sePaymentDay = Trim$(rs7101!K7101_sePaymentDay)
    If IsdbNull(rs7101!K7101_cdPaymentDay) = False Then D7101.cdPaymentDay = Trim$(rs7101!K7101_cdPaymentDay)
    If IsdbNull(rs7101!K7101_sePaymentTime) = False Then D7101.sePaymentTime = Trim$(rs7101!K7101_sePaymentTime)
    If IsdbNull(rs7101!K7101_cdPaymentTime) = False Then D7101.cdPaymentTime = Trim$(rs7101!K7101_cdPaymentTime)
    If IsdbNull(rs7101!K7101_seSite) = False Then D7101.seSite = Trim$(rs7101!K7101_seSite)
    If IsdbNull(rs7101!K7101_cdSite) = False Then D7101.cdSite = Trim$(rs7101!K7101_cdSite)
    If IsdbNull(rs7101!K7101_seTeam) = False Then D7101.seTeam = Trim$(rs7101!K7101_seTeam)
    If IsdbNull(rs7101!K7101_cdTeam) = False Then D7101.cdTeam = Trim$(rs7101!K7101_cdTeam)
    If IsdbNull(rs7101!K7101_ForeignName1) = False Then D7101.ForeignName1 = Trim$(rs7101!K7101_ForeignName1)
    If IsdbNull(rs7101!K7101_ForeignName2) = False Then D7101.ForeignName2 = Trim$(rs7101!K7101_ForeignName2)
    If IsdbNull(rs7101!K7101_CompanyID) = False Then D7101.CompanyID = Trim$(rs7101!K7101_CompanyID)
    If IsdbNull(rs7101!K7101_CompanyType) = False Then D7101.CompanyType = Trim$(rs7101!K7101_CompanyType)
    If IsdbNull(rs7101!K7101_CompanyItem) = False Then D7101.CompanyItem = Trim$(rs7101!K7101_CompanyItem)
    If IsdbNull(rs7101!K7101_Representative) = False Then D7101.Representative = Trim$(rs7101!K7101_Representative)
    If IsdbNull(rs7101!K7101_AddressNo) = False Then D7101.AddressNo = Trim$(rs7101!K7101_AddressNo)
    If IsdbNull(rs7101!K7101_Address1) = False Then D7101.Address1 = Trim$(rs7101!K7101_Address1)
    If IsdbNull(rs7101!K7101_Address2) = False Then D7101.Address2 = Trim$(rs7101!K7101_Address2)
    If IsdbNull(rs7101!K7101_Destination) = False Then D7101.Destination = Trim$(rs7101!K7101_Destination)
    If IsdbNull(rs7101!K7101_FinalShop) = False Then D7101.FinalShop = Trim$(rs7101!K7101_FinalShop)
    If IsdbNull(rs7101!K7101_Country) = False Then D7101.Country = Trim$(rs7101!K7101_Country)
    If IsdbNull(rs7101!K7101_InvoiceAccount) = False Then D7101.InvoiceAccount = Trim$(rs7101!K7101_InvoiceAccount)
    If IsdbNull(rs7101!K7101_TaxExempt) = False Then D7101.TaxExempt = Trim$(rs7101!K7101_TaxExempt)
    If IsdbNull(rs7101!K7101_seSupplierGroup) = False Then D7101.seSupplierGroup = Trim$(rs7101!K7101_seSupplierGroup)
    If IsdbNull(rs7101!K7101_cdSupplierGroup) = False Then D7101.cdSupplierGroup = Trim$(rs7101!K7101_cdSupplierGroup)
    If IsdbNull(rs7101!K7101_sePOGroup) = False Then D7101.sePOGroup = Trim$(rs7101!K7101_sePOGroup)
    If IsdbNull(rs7101!K7101_cdPOGroup) = False Then D7101.cdPOGroup = Trim$(rs7101!K7101_cdPOGroup)
    If IsdbNull(rs7101!K7101_seSOGroup) = False Then D7101.seSOGroup = Trim$(rs7101!K7101_seSOGroup)
    If IsdbNull(rs7101!K7101_cdSOGroup) = False Then D7101.cdSOGroup = Trim$(rs7101!K7101_cdSOGroup)
    If IsdbNull(rs7101!K7101_TelephoneCompany) = False Then D7101.TelephoneCompany = Trim$(rs7101!K7101_TelephoneCompany)
    If IsdbNull(rs7101!K7101_TelephoneHand) = False Then D7101.TelephoneHand = Trim$(rs7101!K7101_TelephoneHand)
    If IsdbNull(rs7101!K7101_FaxNo) = False Then D7101.FaxNo = Trim$(rs7101!K7101_FaxNo)
    If IsdbNull(rs7101!K7101_Email) = False Then D7101.Email = Trim$(rs7101!K7101_Email)
    If IsdbNull(rs7101!K7101_BeneficiaryName) = False Then D7101.BeneficiaryName = Trim$(rs7101!K7101_BeneficiaryName)
    If IsdbNull(rs7101!K7101_AccountNumber) = False Then D7101.AccountNumber = Trim$(rs7101!K7101_AccountNumber)
    If IsdbNull(rs7101!K7101_BankName) = False Then D7101.BankName = Trim$(rs7101!K7101_BankName)
    If IsdbNull(rs7101!K7101_BankAddress) = False Then D7101.BankAddress = Trim$(rs7101!K7101_BankAddress)
    If IsdbNull(rs7101!K7101_SwiftCode) = False Then D7101.SwiftCode = Trim$(rs7101!K7101_SwiftCode)
    If IsdbNull(rs7101!K7101_cdFactory) = False Then D7101.cdFactory = Trim$(rs7101!K7101_cdFactory)
            If IsDBNull(rs7101!K7101_CheckKindCustomer) = False Then D7101.CheckKindCustomer = Trim$(rs7101!K7101_CheckKindCustomer)
            If IsDBNull(rs7101!K7101_seCancelDate) = False Then D7101.seCancelDate = Trim$(rs7101!K7101_seCancelDate)
            If IsDBNull(rs7101!K7101_cdCancelDate) = False Then D7101.cdCancelDate = Trim$(rs7101!K7101_cdCancelDate)

    If IsdbNull(rs7101!K7101_seCustomerDivision) = False Then D7101.seCustomerDivision = Trim$(rs7101!K7101_seCustomerDivision)
    If IsdbNull(rs7101!K7101_cdCustomerDivision) = False Then D7101.cdCustomerDivision = Trim$(rs7101!K7101_cdCustomerDivision)
    If IsdbNull(rs7101!K7101_seCustomerLocation) = False Then D7101.seCustomerLocation = Trim$(rs7101!K7101_seCustomerLocation)
    If IsdbNull(rs7101!K7101_cdCustomerLocation) = False Then D7101.cdCustomerLocation = Trim$(rs7101!K7101_cdCustomerLocation)
    If IsdbNull(rs7101!K7101_seTaxGroup) = False Then D7101.seTaxGroup = Trim$(rs7101!K7101_seTaxGroup)
    If IsdbNull(rs7101!K7101_cdTaxGroup) = False Then D7101.cdTaxGroup = Trim$(rs7101!K7101_cdTaxGroup)
    If IsdbNull(rs7101!K7101_InCharge) = False Then D7101.InCharge = Trim$(rs7101!K7101_InCharge)
    If IsdbNull(rs7101!K7101_InChargeSale) = False Then D7101.InChargeSale = Trim$(rs7101!K7101_InChargeSale)
    If IsdbNull(rs7101!K7101_CheckTax) = False Then D7101.CheckTax = Trim$(rs7101!K7101_CheckTax)
    If IsdbNull(rs7101!K7101_CheckCustomer) = False Then D7101.CheckCustomer = Trim$(rs7101!K7101_CheckCustomer)
    If IsdbNull(rs7101!K7101_CheckSupplier) = False Then D7101.CheckSupplier = Trim$(rs7101!K7101_CheckSupplier)
    If IsdbNull(rs7101!K7101_CheckEmployee) = False Then D7101.CheckEmployee = Trim$(rs7101!K7101_CheckEmployee)
    If IsdbNull(rs7101!K7101_CheckInside) = False Then D7101.CheckInside = Trim$(rs7101!K7101_CheckInside)
    If IsdbNull(rs7101!K7101_CheckOutside) = False Then D7101.CheckOutside = Trim$(rs7101!K7101_CheckOutside)
    If IsdbNull(rs7101!K7101_CheckOthers) = False Then D7101.CheckOthers = Trim$(rs7101!K7101_CheckOthers)
    If IsdbNull(rs7101!K7101_CheckUse) = False Then D7101.CheckUse = Trim$(rs7101!K7101_CheckUse)
    If IsdbNull(rs7101!K7101_InchargeInsert) = False Then D7101.InchargeInsert = Trim$(rs7101!K7101_InchargeInsert)
    If IsdbNull(rs7101!K7101_InchargeUpdate) = False Then D7101.InchargeUpdate = Trim$(rs7101!K7101_InchargeUpdate)
    If IsdbNull(rs7101!K7101_DateInsert) = False Then D7101.DateInsert = Trim$(rs7101!K7101_DateInsert)
    If IsdbNull(rs7101!K7101_DateUpdate) = False Then D7101.DateUpdate = Trim$(rs7101!K7101_DateUpdate)
    If IsdbNull(rs7101!K7101_TimeInsert) = False Then D7101.TimeInsert = Trim$(rs7101!K7101_TimeInsert)
    If IsdbNull(rs7101!K7101_TimeUpdate) = False Then D7101.TimeUpdate = Trim$(rs7101!K7101_TimeUpdate)
    If IsdbNull(rs7101!K7101_TimeLast) = False Then D7101.TimeLast = Trim$(rs7101!K7101_TimeLast)
    If IsdbNull(rs7101!K7101_DateActive) = False Then D7101.DateActive = Trim$(rs7101!K7101_DateActive)
    If IsdbNull(rs7101!K7101_DateDeactive) = False Then D7101.DateDeactive = Trim$(rs7101!K7101_DateDeactive)
    If IsdbNull(rs7101!K7101_CheckActive) = False Then D7101.CheckActive = Trim$(rs7101!K7101_CheckActive)
    If IsdbNull(rs7101!K7101_ParaNo1) = False Then D7101.ParaNo1 = Trim$(rs7101!K7101_ParaNo1)
    If IsdbNull(rs7101!K7101_ParaNo2) = False Then D7101.ParaNo2 = Trim$(rs7101!K7101_ParaNo2)
    If IsdbNull(rs7101!K7101_ParaNo3) = False Then D7101.ParaNo3 = Trim$(rs7101!K7101_ParaNo3)
    If IsdbNull(rs7101!K7101_CheckSync) = False Then D7101.CheckSync = Trim$(rs7101!K7101_CheckSync)
    If IsdbNull(rs7101!K7101_CheckCustomerStatus) = False Then D7101.CheckCustomerStatus = Trim$(rs7101!K7101_CheckCustomerStatus)
    If IsdbNull(rs7101!K7101_DateComplete) = False Then D7101.DateComplete = Trim$(rs7101!K7101_DateComplete)
    If IsdbNull(rs7101!K7101_DateApproved) = False Then D7101.DateApproved = Trim$(rs7101!K7101_DateApproved)
    If IsdbNull(rs7101!K7101_DateCancel) = False Then D7101.DateCancel = Trim$(rs7101!K7101_DateCancel)
    If IsdbNull(rs7101!K7101_DatePending1) = False Then D7101.DatePending1 = Trim$(rs7101!K7101_DatePending1)
    If IsdbNull(rs7101!K7101_DatePending2) = False Then D7101.DatePending2 = Trim$(rs7101!K7101_DatePending2)
    If IsdbNull(rs7101!K7101_Remark) = False Then D7101.Remark = Trim$(rs7101!K7101_Remark)
    If IsdbNull(rs7101!K7101_CheckOption1) = False Then D7101.CheckOption1 = Trim$(rs7101!K7101_CheckOption1)
    If IsdbNull(rs7101!K7101_CheckOption2) = False Then D7101.CheckOption2 = Trim$(rs7101!K7101_CheckOption2)
    If IsdbNull(rs7101!K7101_CheckOption3) = False Then D7101.CheckOption3 = Trim$(rs7101!K7101_CheckOption3)
    If IsdbNull(rs7101!K7101_CheckOption4) = False Then D7101.CheckOption4 = Trim$(rs7101!K7101_CheckOption4)
    If IsdbNull(rs7101!K7101_CheckOption5) = False Then D7101.CheckOption5 = Trim$(rs7101!K7101_CheckOption5)
    If IsdbNull(rs7101!K7101_CheckOption6) = False Then D7101.CheckOption6 = Trim$(rs7101!K7101_CheckOption6)
    If IsdbNull(rs7101!K7101_CheckOption7) = False Then D7101.CheckOption7 = Trim$(rs7101!K7101_CheckOption7)
    If IsdbNull(rs7101!K7101_CheckOption8) = False Then D7101.CheckOption8 = Trim$(rs7101!K7101_CheckOption8)
    If IsdbNull(rs7101!K7101_CheckOption9) = False Then D7101.CheckOption9 = Trim$(rs7101!K7101_CheckOption9)
    If IsdbNull(rs7101!K7101_CheckOption10) = False Then D7101.CheckOption10 = Trim$(rs7101!K7101_CheckOption10)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7101_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7101_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7101 As T7101_AREA, CUSTOMERCODE AS String) as Boolean

K7101_MOVE = False

Try
    If READ_PFK7101(CUSTOMERCODE) = True Then
                z7101 = D7101
		K7101_MOVE = True
		else
	z7101 = nothing
     End If

     If  getColumnIndex(spr,"CustomerCode") > -1 then z7101.CustomerCode = getDataM(spr, getColumnIndex(spr,"CustomerCode"), xRow)
     If  getColumnIndex(spr,"ACodeReceivable") > -1 then z7101.ACodeReceivable = getDataM(spr, getColumnIndex(spr,"ACodeReceivable"), xRow)
     If  getColumnIndex(spr,"ACodePayable") > -1 then z7101.ACodePayable = getDataM(spr, getColumnIndex(spr,"ACodePayable"), xRow)
     If  getColumnIndex(spr,"DevelopmentCode") > -1 then z7101.DevelopmentCode = getDataM(spr, getColumnIndex(spr,"DevelopmentCode"), xRow)
     If  getColumnIndex(spr,"CustomerName") > -1 then z7101.CustomerName = getDataM(spr, getColumnIndex(spr,"CustomerName"), xRow)
     If  getColumnIndex(spr,"CustomerName1") > -1 then z7101.CustomerName1 = getDataM(spr, getColumnIndex(spr,"CustomerName1"), xRow)
     If  getColumnIndex(spr,"CustomerNameSimply") > -1 then z7101.CustomerNameSimply = getDataM(spr, getColumnIndex(spr,"CustomerNameSimply"), xRow)
     If  getColumnIndex(spr,"CustomerNameSimply1") > -1 then z7101.CustomerNameSimply1 = getDataM(spr, getColumnIndex(spr,"CustomerNameSimply1"), xRow)
     If  getColumnIndex(spr,"sePassWord") > -1 then z7101.sePassWord = getDataM(spr, getColumnIndex(spr,"sePassWord"), xRow)
     If  getColumnIndex(spr,"cdPassWord") > -1 then z7101.cdPassWord = getDataM(spr, getColumnIndex(spr,"cdPassWord"), xRow)
     If  getColumnIndex(spr,"seDeliveryTerm") > -1 then z7101.seDeliveryTerm = getDataM(spr, getColumnIndex(spr,"seDeliveryTerm"), xRow)
     If  getColumnIndex(spr,"cdDeliveryTerm") > -1 then z7101.cdDeliveryTerm = getDataM(spr, getColumnIndex(spr,"cdDeliveryTerm"), xRow)
     If  getColumnIndex(spr,"sePaymentTerm") > -1 then z7101.sePaymentTerm = getDataM(spr, getColumnIndex(spr,"sePaymentTerm"), xRow)
     If  getColumnIndex(spr,"cdPaymentTerm") > -1 then z7101.cdPaymentTerm = getDataM(spr, getColumnIndex(spr,"cdPaymentTerm"), xRow)
     If  getColumnIndex(spr,"sePaymentCondition") > -1 then z7101.sePaymentCondition = getDataM(spr, getColumnIndex(spr,"sePaymentCondition"), xRow)
     If  getColumnIndex(spr,"cdPaymentCondition") > -1 then z7101.cdPaymentCondition = getDataM(spr, getColumnIndex(spr,"cdPaymentCondition"), xRow)
     If  getColumnIndex(spr,"sePaymentDay") > -1 then z7101.sePaymentDay = getDataM(spr, getColumnIndex(spr,"sePaymentDay"), xRow)
     If  getColumnIndex(spr,"cdPaymentDay") > -1 then z7101.cdPaymentDay = getDataM(spr, getColumnIndex(spr,"cdPaymentDay"), xRow)
     If  getColumnIndex(spr,"sePaymentTime") > -1 then z7101.sePaymentTime = getDataM(spr, getColumnIndex(spr,"sePaymentTime"), xRow)
     If  getColumnIndex(spr,"cdPaymentTime") > -1 then z7101.cdPaymentTime = getDataM(spr, getColumnIndex(spr,"cdPaymentTime"), xRow)
     If  getColumnIndex(spr,"seSite") > -1 then z7101.seSite = getDataM(spr, getColumnIndex(spr,"seSite"), xRow)
     If  getColumnIndex(spr,"cdSite") > -1 then z7101.cdSite = getDataM(spr, getColumnIndex(spr,"cdSite"), xRow)
     If  getColumnIndex(spr,"seTeam") > -1 then z7101.seTeam = getDataM(spr, getColumnIndex(spr,"seTeam"), xRow)
     If  getColumnIndex(spr,"cdTeam") > -1 then z7101.cdTeam = getDataM(spr, getColumnIndex(spr,"cdTeam"), xRow)
     If  getColumnIndex(spr,"ForeignName1") > -1 then z7101.ForeignName1 = getDataM(spr, getColumnIndex(spr,"ForeignName1"), xRow)
     If  getColumnIndex(spr,"ForeignName2") > -1 then z7101.ForeignName2 = getDataM(spr, getColumnIndex(spr,"ForeignName2"), xRow)
     If  getColumnIndex(spr,"CompanyID") > -1 then z7101.CompanyID = getDataM(spr, getColumnIndex(spr,"CompanyID"), xRow)
     If  getColumnIndex(spr,"CompanyType") > -1 then z7101.CompanyType = getDataM(spr, getColumnIndex(spr,"CompanyType"), xRow)
     If  getColumnIndex(spr,"CompanyItem") > -1 then z7101.CompanyItem = getDataM(spr, getColumnIndex(spr,"CompanyItem"), xRow)
     If  getColumnIndex(spr,"Representative") > -1 then z7101.Representative = getDataM(spr, getColumnIndex(spr,"Representative"), xRow)
     If  getColumnIndex(spr,"AddressNo") > -1 then z7101.AddressNo = getDataM(spr, getColumnIndex(spr,"AddressNo"), xRow)
     If  getColumnIndex(spr,"Address1") > -1 then z7101.Address1 = getDataM(spr, getColumnIndex(spr,"Address1"), xRow)
     If  getColumnIndex(spr,"Address2") > -1 then z7101.Address2 = getDataM(spr, getColumnIndex(spr,"Address2"), xRow)
     If  getColumnIndex(spr,"Destination") > -1 then z7101.Destination = getDataM(spr, getColumnIndex(spr,"Destination"), xRow)
     If  getColumnIndex(spr,"FinalShop") > -1 then z7101.FinalShop = getDataM(spr, getColumnIndex(spr,"FinalShop"), xRow)
     If  getColumnIndex(spr,"Country") > -1 then z7101.Country = getDataM(spr, getColumnIndex(spr,"Country"), xRow)
     If  getColumnIndex(spr,"InvoiceAccount") > -1 then z7101.InvoiceAccount = getDataM(spr, getColumnIndex(spr,"InvoiceAccount"), xRow)
     If  getColumnIndex(spr,"TaxExempt") > -1 then z7101.TaxExempt = getDataM(spr, getColumnIndex(spr,"TaxExempt"), xRow)
     If  getColumnIndex(spr,"seSupplierGroup") > -1 then z7101.seSupplierGroup = getDataM(spr, getColumnIndex(spr,"seSupplierGroup"), xRow)
     If  getColumnIndex(spr,"cdSupplierGroup") > -1 then z7101.cdSupplierGroup = getDataM(spr, getColumnIndex(spr,"cdSupplierGroup"), xRow)
     If  getColumnIndex(spr,"sePOGroup") > -1 then z7101.sePOGroup = getDataM(spr, getColumnIndex(spr,"sePOGroup"), xRow)
     If  getColumnIndex(spr,"cdPOGroup") > -1 then z7101.cdPOGroup = getDataM(spr, getColumnIndex(spr,"cdPOGroup"), xRow)
     If  getColumnIndex(spr,"seSOGroup") > -1 then z7101.seSOGroup = getDataM(spr, getColumnIndex(spr,"seSOGroup"), xRow)
     If  getColumnIndex(spr,"cdSOGroup") > -1 then z7101.cdSOGroup = getDataM(spr, getColumnIndex(spr,"cdSOGroup"), xRow)
     If  getColumnIndex(spr,"TelephoneCompany") > -1 then z7101.TelephoneCompany = getDataM(spr, getColumnIndex(spr,"TelephoneCompany"), xRow)
     If  getColumnIndex(spr,"TelephoneHand") > -1 then z7101.TelephoneHand = getDataM(spr, getColumnIndex(spr,"TelephoneHand"), xRow)
     If  getColumnIndex(spr,"FaxNo") > -1 then z7101.FaxNo = getDataM(spr, getColumnIndex(spr,"FaxNo"), xRow)
     If  getColumnIndex(spr,"Email") > -1 then z7101.Email = getDataM(spr, getColumnIndex(spr,"Email"), xRow)
     If  getColumnIndex(spr,"BeneficiaryName") > -1 then z7101.BeneficiaryName = getDataM(spr, getColumnIndex(spr,"BeneficiaryName"), xRow)
     If  getColumnIndex(spr,"AccountNumber") > -1 then z7101.AccountNumber = getDataM(spr, getColumnIndex(spr,"AccountNumber"), xRow)
     If  getColumnIndex(spr,"BankName") > -1 then z7101.BankName = getDataM(spr, getColumnIndex(spr,"BankName"), xRow)
     If  getColumnIndex(spr,"BankAddress") > -1 then z7101.BankAddress = getDataM(spr, getColumnIndex(spr,"BankAddress"), xRow)
     If  getColumnIndex(spr,"SwiftCode") > -1 then z7101.SwiftCode = getDataM(spr, getColumnIndex(spr,"SwiftCode"), xRow)
     If  getColumnIndex(spr,"cdFactory") > -1 then z7101.cdFactory = getDataM(spr, getColumnIndex(spr,"cdFactory"), xRow)
            If getColumnIndex(spr, "CheckKindCustomer") > -1 Then z7101.CheckKindCustomer = getDataM(spr, getColumnIndex(spr, "CheckKindCustomer"), xRow)
            If getColumnIndex(spr, "SECANCELDATE") > -1 Then z7101.seCancelDate = getDataM(spr, getColumnIndex(spr, "SECANCELDATE"), xRow)
            If getColumnIndex(spr, "CDCANCELDATE") > -1 Then z7101.cdCancelDate = getDataM(spr, getColumnIndex(spr, "CDCANCELDATE"), xRow)

     If  getColumnIndex(spr,"seCustomerDivision") > -1 then z7101.seCustomerDivision = getDataM(spr, getColumnIndex(spr,"seCustomerDivision"), xRow)
     If  getColumnIndex(spr,"cdCustomerDivision") > -1 then z7101.cdCustomerDivision = getDataM(spr, getColumnIndex(spr,"cdCustomerDivision"), xRow)
     If  getColumnIndex(spr,"seCustomerLocation") > -1 then z7101.seCustomerLocation = getDataM(spr, getColumnIndex(spr,"seCustomerLocation"), xRow)
     If  getColumnIndex(spr,"cdCustomerLocation") > -1 then z7101.cdCustomerLocation = getDataM(spr, getColumnIndex(spr,"cdCustomerLocation"), xRow)
     If  getColumnIndex(spr,"seTaxGroup") > -1 then z7101.seTaxGroup = getDataM(spr, getColumnIndex(spr,"seTaxGroup"), xRow)
     If  getColumnIndex(spr,"cdTaxGroup") > -1 then z7101.cdTaxGroup = getDataM(spr, getColumnIndex(spr,"cdTaxGroup"), xRow)
     If  getColumnIndex(spr,"InCharge") > -1 then z7101.InCharge = getDataM(spr, getColumnIndex(spr,"InCharge"), xRow)
     If  getColumnIndex(spr,"InChargeSale") > -1 then z7101.InChargeSale = getDataM(spr, getColumnIndex(spr,"InChargeSale"), xRow)
     If  getColumnIndex(spr,"CheckTax") > -1 then z7101.CheckTax = getDataM(spr, getColumnIndex(spr,"CheckTax"), xRow)
     If  getColumnIndex(spr,"CheckCustomer") > -1 then z7101.CheckCustomer = getDataM(spr, getColumnIndex(spr,"CheckCustomer"), xRow)
     If  getColumnIndex(spr,"CheckSupplier") > -1 then z7101.CheckSupplier = getDataM(spr, getColumnIndex(spr,"CheckSupplier"), xRow)
     If  getColumnIndex(spr,"CheckEmployee") > -1 then z7101.CheckEmployee = getDataM(spr, getColumnIndex(spr,"CheckEmployee"), xRow)
     If  getColumnIndex(spr,"CheckInside") > -1 then z7101.CheckInside = getDataM(spr, getColumnIndex(spr,"CheckInside"), xRow)
     If  getColumnIndex(spr,"CheckOutside") > -1 then z7101.CheckOutside = getDataM(spr, getColumnIndex(spr,"CheckOutside"), xRow)
     If  getColumnIndex(spr,"CheckOthers") > -1 then z7101.CheckOthers = getDataM(spr, getColumnIndex(spr,"CheckOthers"), xRow)
     If  getColumnIndex(spr,"CheckUse") > -1 then z7101.CheckUse = getDataM(spr, getColumnIndex(spr,"CheckUse"), xRow)
     If  getColumnIndex(spr,"InchargeInsert") > -1 then z7101.InchargeInsert = getDataM(spr, getColumnIndex(spr,"InchargeInsert"), xRow)
     If  getColumnIndex(spr,"InchargeUpdate") > -1 then z7101.InchargeUpdate = getDataM(spr, getColumnIndex(spr,"InchargeUpdate"), xRow)
     If  getColumnIndex(spr,"DateInsert") > -1 then z7101.DateInsert = getDataM(spr, getColumnIndex(spr,"DateInsert"), xRow)
     If  getColumnIndex(spr,"DateUpdate") > -1 then z7101.DateUpdate = getDataM(spr, getColumnIndex(spr,"DateUpdate"), xRow)
     If  getColumnIndex(spr,"TimeInsert") > -1 then z7101.TimeInsert = getDataM(spr, getColumnIndex(spr,"TimeInsert"), xRow)
     If  getColumnIndex(spr,"TimeUpdate") > -1 then z7101.TimeUpdate = getDataM(spr, getColumnIndex(spr,"TimeUpdate"), xRow)
     If  getColumnIndex(spr,"TimeLast") > -1 then z7101.TimeLast = getDataM(spr, getColumnIndex(spr,"TimeLast"), xRow)
     If  getColumnIndex(spr,"DateActive") > -1 then z7101.DateActive = getDataM(spr, getColumnIndex(spr,"DateActive"), xRow)
     If  getColumnIndex(spr,"DateDeactive") > -1 then z7101.DateDeactive = getDataM(spr, getColumnIndex(spr,"DateDeactive"), xRow)
     If  getColumnIndex(spr,"CheckActive") > -1 then z7101.CheckActive = getDataM(spr, getColumnIndex(spr,"CheckActive"), xRow)
     If  getColumnIndex(spr,"ParaNo1") > -1 then z7101.ParaNo1 = getDataM(spr, getColumnIndex(spr,"ParaNo1"), xRow)
     If  getColumnIndex(spr,"ParaNo2") > -1 then z7101.ParaNo2 = getDataM(spr, getColumnIndex(spr,"ParaNo2"), xRow)
     If  getColumnIndex(spr,"ParaNo3") > -1 then z7101.ParaNo3 = getDataM(spr, getColumnIndex(spr,"ParaNo3"), xRow)
     If  getColumnIndex(spr,"CheckSync") > -1 then z7101.CheckSync = getDataM(spr, getColumnIndex(spr,"CheckSync"), xRow)
     If  getColumnIndex(spr,"CheckCustomerStatus") > -1 then z7101.CheckCustomerStatus = getDataM(spr, getColumnIndex(spr,"CheckCustomerStatus"), xRow)
     If  getColumnIndex(spr,"DateComplete") > -1 then z7101.DateComplete = getDataM(spr, getColumnIndex(spr,"DateComplete"), xRow)
     If  getColumnIndex(spr,"DateApproved") > -1 then z7101.DateApproved = getDataM(spr, getColumnIndex(spr,"DateApproved"), xRow)
     If  getColumnIndex(spr,"DateCancel") > -1 then z7101.DateCancel = getDataM(spr, getColumnIndex(spr,"DateCancel"), xRow)
     If  getColumnIndex(spr,"DatePending1") > -1 then z7101.DatePending1 = getDataM(spr, getColumnIndex(spr,"DatePending1"), xRow)
     If  getColumnIndex(spr,"DatePending2") > -1 then z7101.DatePending2 = getDataM(spr, getColumnIndex(spr,"DatePending2"), xRow)
     If  getColumnIndex(spr,"Remark") > -1 then z7101.Remark = getDataM(spr, getColumnIndex(spr,"Remark"), xRow)
     If  getColumnIndex(spr,"CheckOption1") > -1 then z7101.CheckOption1 = getDataM(spr, getColumnIndex(spr,"CheckOption1"), xRow)
     If  getColumnIndex(spr,"CheckOption2") > -1 then z7101.CheckOption2 = getDataM(spr, getColumnIndex(spr,"CheckOption2"), xRow)
     If  getColumnIndex(spr,"CheckOption3") > -1 then z7101.CheckOption3 = getDataM(spr, getColumnIndex(spr,"CheckOption3"), xRow)
     If  getColumnIndex(spr,"CheckOption4") > -1 then z7101.CheckOption4 = getDataM(spr, getColumnIndex(spr,"CheckOption4"), xRow)
     If  getColumnIndex(spr,"CheckOption5") > -1 then z7101.CheckOption5 = getDataM(spr, getColumnIndex(spr,"CheckOption5"), xRow)
     If  getColumnIndex(spr,"CheckOption6") > -1 then z7101.CheckOption6 = getDataM(spr, getColumnIndex(spr,"CheckOption6"), xRow)
     If  getColumnIndex(spr,"CheckOption7") > -1 then z7101.CheckOption7 = getDataM(spr, getColumnIndex(spr,"CheckOption7"), xRow)
     If  getColumnIndex(spr,"CheckOption8") > -1 then z7101.CheckOption8 = getDataM(spr, getColumnIndex(spr,"CheckOption8"), xRow)
     If  getColumnIndex(spr,"CheckOption9") > -1 then z7101.CheckOption9 = getDataM(spr, getColumnIndex(spr,"CheckOption9"), xRow)
     If  getColumnIndex(spr,"CheckOption10") > -1 then z7101.CheckOption10 = getDataM(spr, getColumnIndex(spr,"CheckOption10"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7101_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7101_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7101 As T7101_AREA,CheckClear as Boolean,CUSTOMERCODE AS String) as Boolean

K7101_MOVE = False

Try
    If READ_PFK7101(CUSTOMERCODE) = True Then
                z7101 = D7101
		K7101_MOVE = True
		else
	If CheckClear  = True then z7101 = nothing
     End If

     If  getColumnIndex(spr,"CustomerCode") > -1 then z7101.CustomerCode = getDataM(spr, getColumnIndex(spr,"CustomerCode"), xRow)
     If  getColumnIndex(spr,"ACodeReceivable") > -1 then z7101.ACodeReceivable = getDataM(spr, getColumnIndex(spr,"ACodeReceivable"), xRow)
     If  getColumnIndex(spr,"ACodePayable") > -1 then z7101.ACodePayable = getDataM(spr, getColumnIndex(spr,"ACodePayable"), xRow)
     If  getColumnIndex(spr,"DevelopmentCode") > -1 then z7101.DevelopmentCode = getDataM(spr, getColumnIndex(spr,"DevelopmentCode"), xRow)
     If  getColumnIndex(spr,"CustomerName") > -1 then z7101.CustomerName = getDataM(spr, getColumnIndex(spr,"CustomerName"), xRow)
     If  getColumnIndex(spr,"CustomerName1") > -1 then z7101.CustomerName1 = getDataM(spr, getColumnIndex(spr,"CustomerName1"), xRow)
     If  getColumnIndex(spr,"CustomerNameSimply") > -1 then z7101.CustomerNameSimply = getDataM(spr, getColumnIndex(spr,"CustomerNameSimply"), xRow)
     If  getColumnIndex(spr,"CustomerNameSimply1") > -1 then z7101.CustomerNameSimply1 = getDataM(spr, getColumnIndex(spr,"CustomerNameSimply1"), xRow)
     If  getColumnIndex(spr,"sePassWord") > -1 then z7101.sePassWord = getDataM(spr, getColumnIndex(spr,"sePassWord"), xRow)
     If  getColumnIndex(spr,"cdPassWord") > -1 then z7101.cdPassWord = getDataM(spr, getColumnIndex(spr,"cdPassWord"), xRow)
     If  getColumnIndex(spr,"seDeliveryTerm") > -1 then z7101.seDeliveryTerm = getDataM(spr, getColumnIndex(spr,"seDeliveryTerm"), xRow)
     If  getColumnIndex(spr,"cdDeliveryTerm") > -1 then z7101.cdDeliveryTerm = getDataM(spr, getColumnIndex(spr,"cdDeliveryTerm"), xRow)
     If  getColumnIndex(spr,"sePaymentTerm") > -1 then z7101.sePaymentTerm = getDataM(spr, getColumnIndex(spr,"sePaymentTerm"), xRow)
     If  getColumnIndex(spr,"cdPaymentTerm") > -1 then z7101.cdPaymentTerm = getDataM(spr, getColumnIndex(spr,"cdPaymentTerm"), xRow)
     If  getColumnIndex(spr,"sePaymentCondition") > -1 then z7101.sePaymentCondition = getDataM(spr, getColumnIndex(spr,"sePaymentCondition"), xRow)
     If  getColumnIndex(spr,"cdPaymentCondition") > -1 then z7101.cdPaymentCondition = getDataM(spr, getColumnIndex(spr,"cdPaymentCondition"), xRow)
     If  getColumnIndex(spr,"sePaymentDay") > -1 then z7101.sePaymentDay = getDataM(spr, getColumnIndex(spr,"sePaymentDay"), xRow)
     If  getColumnIndex(spr,"cdPaymentDay") > -1 then z7101.cdPaymentDay = getDataM(spr, getColumnIndex(spr,"cdPaymentDay"), xRow)
     If  getColumnIndex(spr,"sePaymentTime") > -1 then z7101.sePaymentTime = getDataM(spr, getColumnIndex(spr,"sePaymentTime"), xRow)
     If  getColumnIndex(spr,"cdPaymentTime") > -1 then z7101.cdPaymentTime = getDataM(spr, getColumnIndex(spr,"cdPaymentTime"), xRow)
     If  getColumnIndex(spr,"seSite") > -1 then z7101.seSite = getDataM(spr, getColumnIndex(spr,"seSite"), xRow)
     If  getColumnIndex(spr,"cdSite") > -1 then z7101.cdSite = getDataM(spr, getColumnIndex(spr,"cdSite"), xRow)
     If  getColumnIndex(spr,"seTeam") > -1 then z7101.seTeam = getDataM(spr, getColumnIndex(spr,"seTeam"), xRow)
     If  getColumnIndex(spr,"cdTeam") > -1 then z7101.cdTeam = getDataM(spr, getColumnIndex(spr,"cdTeam"), xRow)
     If  getColumnIndex(spr,"ForeignName1") > -1 then z7101.ForeignName1 = getDataM(spr, getColumnIndex(spr,"ForeignName1"), xRow)
     If  getColumnIndex(spr,"ForeignName2") > -1 then z7101.ForeignName2 = getDataM(spr, getColumnIndex(spr,"ForeignName2"), xRow)
     If  getColumnIndex(spr,"CompanyID") > -1 then z7101.CompanyID = getDataM(spr, getColumnIndex(spr,"CompanyID"), xRow)
     If  getColumnIndex(spr,"CompanyType") > -1 then z7101.CompanyType = getDataM(spr, getColumnIndex(spr,"CompanyType"), xRow)
     If  getColumnIndex(spr,"CompanyItem") > -1 then z7101.CompanyItem = getDataM(spr, getColumnIndex(spr,"CompanyItem"), xRow)
     If  getColumnIndex(spr,"Representative") > -1 then z7101.Representative = getDataM(spr, getColumnIndex(spr,"Representative"), xRow)
     If  getColumnIndex(spr,"AddressNo") > -1 then z7101.AddressNo = getDataM(spr, getColumnIndex(spr,"AddressNo"), xRow)
     If  getColumnIndex(spr,"Address1") > -1 then z7101.Address1 = getDataM(spr, getColumnIndex(spr,"Address1"), xRow)
     If  getColumnIndex(spr,"Address2") > -1 then z7101.Address2 = getDataM(spr, getColumnIndex(spr,"Address2"), xRow)
     If  getColumnIndex(spr,"Destination") > -1 then z7101.Destination = getDataM(spr, getColumnIndex(spr,"Destination"), xRow)
     If  getColumnIndex(spr,"FinalShop") > -1 then z7101.FinalShop = getDataM(spr, getColumnIndex(spr,"FinalShop"), xRow)
     If  getColumnIndex(spr,"Country") > -1 then z7101.Country = getDataM(spr, getColumnIndex(spr,"Country"), xRow)
     If  getColumnIndex(spr,"InvoiceAccount") > -1 then z7101.InvoiceAccount = getDataM(spr, getColumnIndex(spr,"InvoiceAccount"), xRow)
     If  getColumnIndex(spr,"TaxExempt") > -1 then z7101.TaxExempt = getDataM(spr, getColumnIndex(spr,"TaxExempt"), xRow)
     If  getColumnIndex(spr,"seSupplierGroup") > -1 then z7101.seSupplierGroup = getDataM(spr, getColumnIndex(spr,"seSupplierGroup"), xRow)
     If  getColumnIndex(spr,"cdSupplierGroup") > -1 then z7101.cdSupplierGroup = getDataM(spr, getColumnIndex(spr,"cdSupplierGroup"), xRow)
     If  getColumnIndex(spr,"sePOGroup") > -1 then z7101.sePOGroup = getDataM(spr, getColumnIndex(spr,"sePOGroup"), xRow)
     If  getColumnIndex(spr,"cdPOGroup") > -1 then z7101.cdPOGroup = getDataM(spr, getColumnIndex(spr,"cdPOGroup"), xRow)
     If  getColumnIndex(spr,"seSOGroup") > -1 then z7101.seSOGroup = getDataM(spr, getColumnIndex(spr,"seSOGroup"), xRow)
     If  getColumnIndex(spr,"cdSOGroup") > -1 then z7101.cdSOGroup = getDataM(spr, getColumnIndex(spr,"cdSOGroup"), xRow)
     If  getColumnIndex(spr,"TelephoneCompany") > -1 then z7101.TelephoneCompany = getDataM(spr, getColumnIndex(spr,"TelephoneCompany"), xRow)
     If  getColumnIndex(spr,"TelephoneHand") > -1 then z7101.TelephoneHand = getDataM(spr, getColumnIndex(spr,"TelephoneHand"), xRow)
     If  getColumnIndex(spr,"FaxNo") > -1 then z7101.FaxNo = getDataM(spr, getColumnIndex(spr,"FaxNo"), xRow)
     If  getColumnIndex(spr,"Email") > -1 then z7101.Email = getDataM(spr, getColumnIndex(spr,"Email"), xRow)
     If  getColumnIndex(spr,"BeneficiaryName") > -1 then z7101.BeneficiaryName = getDataM(spr, getColumnIndex(spr,"BeneficiaryName"), xRow)
     If  getColumnIndex(spr,"AccountNumber") > -1 then z7101.AccountNumber = getDataM(spr, getColumnIndex(spr,"AccountNumber"), xRow)
     If  getColumnIndex(spr,"BankName") > -1 then z7101.BankName = getDataM(spr, getColumnIndex(spr,"BankName"), xRow)
     If  getColumnIndex(spr,"BankAddress") > -1 then z7101.BankAddress = getDataM(spr, getColumnIndex(spr,"BankAddress"), xRow)
     If  getColumnIndex(spr,"SwiftCode") > -1 then z7101.SwiftCode = getDataM(spr, getColumnIndex(spr,"SwiftCode"), xRow)
     If  getColumnIndex(spr,"cdFactory") > -1 then z7101.cdFactory = getDataM(spr, getColumnIndex(spr,"cdFactory"), xRow)
            If getColumnIndex(spr, "CheckKindCustomer") > -1 Then z7101.CheckKindCustomer = getDataM(spr, getColumnIndex(spr, "CheckKindCustomer"), xRow)
            If getColumnIndex(spr, "SECANCELDATE") > -1 Then z7101.seCancelDate = getDataM(spr, getColumnIndex(spr, "SECANCELDATE"), xRow)
            If getColumnIndex(spr, "CDCANCELDATE") > -1 Then z7101.cdCancelDate = getDataM(spr, getColumnIndex(spr, "CDCANCELDATE"), xRow)

     If  getColumnIndex(spr,"seCustomerDivision") > -1 then z7101.seCustomerDivision = getDataM(spr, getColumnIndex(spr,"seCustomerDivision"), xRow)
     If  getColumnIndex(spr,"cdCustomerDivision") > -1 then z7101.cdCustomerDivision = getDataM(spr, getColumnIndex(spr,"cdCustomerDivision"), xRow)
     If  getColumnIndex(spr,"seCustomerLocation") > -1 then z7101.seCustomerLocation = getDataM(spr, getColumnIndex(spr,"seCustomerLocation"), xRow)
     If  getColumnIndex(spr,"cdCustomerLocation") > -1 then z7101.cdCustomerLocation = getDataM(spr, getColumnIndex(spr,"cdCustomerLocation"), xRow)
     If  getColumnIndex(spr,"seTaxGroup") > -1 then z7101.seTaxGroup = getDataM(spr, getColumnIndex(spr,"seTaxGroup"), xRow)
     If  getColumnIndex(spr,"cdTaxGroup") > -1 then z7101.cdTaxGroup = getDataM(spr, getColumnIndex(spr,"cdTaxGroup"), xRow)
     If  getColumnIndex(spr,"InCharge") > -1 then z7101.InCharge = getDataM(spr, getColumnIndex(spr,"InCharge"), xRow)
     If  getColumnIndex(spr,"InChargeSale") > -1 then z7101.InChargeSale = getDataM(spr, getColumnIndex(spr,"InChargeSale"), xRow)
     If  getColumnIndex(spr,"CheckTax") > -1 then z7101.CheckTax = getDataM(spr, getColumnIndex(spr,"CheckTax"), xRow)
     If  getColumnIndex(spr,"CheckCustomer") > -1 then z7101.CheckCustomer = getDataM(spr, getColumnIndex(spr,"CheckCustomer"), xRow)
     If  getColumnIndex(spr,"CheckSupplier") > -1 then z7101.CheckSupplier = getDataM(spr, getColumnIndex(spr,"CheckSupplier"), xRow)
     If  getColumnIndex(spr,"CheckEmployee") > -1 then z7101.CheckEmployee = getDataM(spr, getColumnIndex(spr,"CheckEmployee"), xRow)
     If  getColumnIndex(spr,"CheckInside") > -1 then z7101.CheckInside = getDataM(spr, getColumnIndex(spr,"CheckInside"), xRow)
     If  getColumnIndex(spr,"CheckOutside") > -1 then z7101.CheckOutside = getDataM(spr, getColumnIndex(spr,"CheckOutside"), xRow)
     If  getColumnIndex(spr,"CheckOthers") > -1 then z7101.CheckOthers = getDataM(spr, getColumnIndex(spr,"CheckOthers"), xRow)
     If  getColumnIndex(spr,"CheckUse") > -1 then z7101.CheckUse = getDataM(spr, getColumnIndex(spr,"CheckUse"), xRow)
     If  getColumnIndex(spr,"InchargeInsert") > -1 then z7101.InchargeInsert = getDataM(spr, getColumnIndex(spr,"InchargeInsert"), xRow)
     If  getColumnIndex(spr,"InchargeUpdate") > -1 then z7101.InchargeUpdate = getDataM(spr, getColumnIndex(spr,"InchargeUpdate"), xRow)
     If  getColumnIndex(spr,"DateInsert") > -1 then z7101.DateInsert = getDataM(spr, getColumnIndex(spr,"DateInsert"), xRow)
     If  getColumnIndex(spr,"DateUpdate") > -1 then z7101.DateUpdate = getDataM(spr, getColumnIndex(spr,"DateUpdate"), xRow)
     If  getColumnIndex(spr,"TimeInsert") > -1 then z7101.TimeInsert = getDataM(spr, getColumnIndex(spr,"TimeInsert"), xRow)
     If  getColumnIndex(spr,"TimeUpdate") > -1 then z7101.TimeUpdate = getDataM(spr, getColumnIndex(spr,"TimeUpdate"), xRow)
     If  getColumnIndex(spr,"TimeLast") > -1 then z7101.TimeLast = getDataM(spr, getColumnIndex(spr,"TimeLast"), xRow)
     If  getColumnIndex(spr,"DateActive") > -1 then z7101.DateActive = getDataM(spr, getColumnIndex(spr,"DateActive"), xRow)
     If  getColumnIndex(spr,"DateDeactive") > -1 then z7101.DateDeactive = getDataM(spr, getColumnIndex(spr,"DateDeactive"), xRow)
     If  getColumnIndex(spr,"CheckActive") > -1 then z7101.CheckActive = getDataM(spr, getColumnIndex(spr,"CheckActive"), xRow)
     If  getColumnIndex(spr,"ParaNo1") > -1 then z7101.ParaNo1 = getDataM(spr, getColumnIndex(spr,"ParaNo1"), xRow)
     If  getColumnIndex(spr,"ParaNo2") > -1 then z7101.ParaNo2 = getDataM(spr, getColumnIndex(spr,"ParaNo2"), xRow)
     If  getColumnIndex(spr,"ParaNo3") > -1 then z7101.ParaNo3 = getDataM(spr, getColumnIndex(spr,"ParaNo3"), xRow)
     If  getColumnIndex(spr,"CheckSync") > -1 then z7101.CheckSync = getDataM(spr, getColumnIndex(spr,"CheckSync"), xRow)
     If  getColumnIndex(spr,"CheckCustomerStatus") > -1 then z7101.CheckCustomerStatus = getDataM(spr, getColumnIndex(spr,"CheckCustomerStatus"), xRow)
     If  getColumnIndex(spr,"DateComplete") > -1 then z7101.DateComplete = getDataM(spr, getColumnIndex(spr,"DateComplete"), xRow)
     If  getColumnIndex(spr,"DateApproved") > -1 then z7101.DateApproved = getDataM(spr, getColumnIndex(spr,"DateApproved"), xRow)
     If  getColumnIndex(spr,"DateCancel") > -1 then z7101.DateCancel = getDataM(spr, getColumnIndex(spr,"DateCancel"), xRow)
     If  getColumnIndex(spr,"DatePending1") > -1 then z7101.DatePending1 = getDataM(spr, getColumnIndex(spr,"DatePending1"), xRow)
     If  getColumnIndex(spr,"DatePending2") > -1 then z7101.DatePending2 = getDataM(spr, getColumnIndex(spr,"DatePending2"), xRow)
     If  getColumnIndex(spr,"Remark") > -1 then z7101.Remark = getDataM(spr, getColumnIndex(spr,"Remark"), xRow)
     If  getColumnIndex(spr,"CheckOption1") > -1 then z7101.CheckOption1 = getDataM(spr, getColumnIndex(spr,"CheckOption1"), xRow)
     If  getColumnIndex(spr,"CheckOption2") > -1 then z7101.CheckOption2 = getDataM(spr, getColumnIndex(spr,"CheckOption2"), xRow)
     If  getColumnIndex(spr,"CheckOption3") > -1 then z7101.CheckOption3 = getDataM(spr, getColumnIndex(spr,"CheckOption3"), xRow)
     If  getColumnIndex(spr,"CheckOption4") > -1 then z7101.CheckOption4 = getDataM(spr, getColumnIndex(spr,"CheckOption4"), xRow)
     If  getColumnIndex(spr,"CheckOption5") > -1 then z7101.CheckOption5 = getDataM(spr, getColumnIndex(spr,"CheckOption5"), xRow)
     If  getColumnIndex(spr,"CheckOption6") > -1 then z7101.CheckOption6 = getDataM(spr, getColumnIndex(spr,"CheckOption6"), xRow)
     If  getColumnIndex(spr,"CheckOption7") > -1 then z7101.CheckOption7 = getDataM(spr, getColumnIndex(spr,"CheckOption7"), xRow)
     If  getColumnIndex(spr,"CheckOption8") > -1 then z7101.CheckOption8 = getDataM(spr, getColumnIndex(spr,"CheckOption8"), xRow)
     If  getColumnIndex(spr,"CheckOption9") > -1 then z7101.CheckOption9 = getDataM(spr, getColumnIndex(spr,"CheckOption9"), xRow)
     If  getColumnIndex(spr,"CheckOption10") > -1 then z7101.CheckOption10 = getDataM(spr, getColumnIndex(spr,"CheckOption10"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7101_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7101_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7101 As T7101_AREA, Job as String, CUSTOMERCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7101_MOVE = False

Try
    If READ_PFK7101(CUSTOMERCODE) = True Then
                z7101 = D7101
		K7101_MOVE = True
		else
	z7101 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7101")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "CUSTOMERCODE":z7101.CustomerCode = Children(i).Code
   Case "ACODERECEIVABLE":z7101.ACodeReceivable = Children(i).Code
   Case "ACODEPAYABLE":z7101.ACodePayable = Children(i).Code
   Case "DEVELOPMENTCODE":z7101.DevelopmentCode = Children(i).Code
   Case "CUSTOMERNAME":z7101.CustomerName = Children(i).Code
   Case "CUSTOMERNAME1":z7101.CustomerName1 = Children(i).Code
   Case "CUSTOMERNAMESIMPLY":z7101.CustomerNameSimply = Children(i).Code
   Case "CUSTOMERNAMESIMPLY1":z7101.CustomerNameSimply1 = Children(i).Code
   Case "SEPASSWORD":z7101.sePassWord = Children(i).Code
   Case "CDPASSWORD":z7101.cdPassWord = Children(i).Code
   Case "SEDELIVERYTERM":z7101.seDeliveryTerm = Children(i).Code
   Case "CDDELIVERYTERM":z7101.cdDeliveryTerm = Children(i).Code
   Case "SEPAYMENTTERM":z7101.sePaymentTerm = Children(i).Code
   Case "CDPAYMENTTERM":z7101.cdPaymentTerm = Children(i).Code
   Case "SEPAYMENTCONDITION":z7101.sePaymentCondition = Children(i).Code
   Case "CDPAYMENTCONDITION":z7101.cdPaymentCondition = Children(i).Code
   Case "SEPAYMENTDAY":z7101.sePaymentDay = Children(i).Code
   Case "CDPAYMENTDAY":z7101.cdPaymentDay = Children(i).Code
   Case "SEPAYMENTTIME":z7101.sePaymentTime = Children(i).Code
   Case "CDPAYMENTTIME":z7101.cdPaymentTime = Children(i).Code
   Case "SESITE":z7101.seSite = Children(i).Code
   Case "CDSITE":z7101.cdSite = Children(i).Code
   Case "SETEAM":z7101.seTeam = Children(i).Code
   Case "CDTEAM":z7101.cdTeam = Children(i).Code
   Case "FOREIGNNAME1":z7101.ForeignName1 = Children(i).Code
   Case "FOREIGNNAME2":z7101.ForeignName2 = Children(i).Code
   Case "COMPANYID":z7101.CompanyID = Children(i).Code
   Case "COMPANYTYPE":z7101.CompanyType = Children(i).Code
   Case "COMPANYITEM":z7101.CompanyItem = Children(i).Code
   Case "REPRESENTATIVE":z7101.Representative = Children(i).Code
   Case "ADDRESSNO":z7101.AddressNo = Children(i).Code
   Case "ADDRESS1":z7101.Address1 = Children(i).Code
   Case "ADDRESS2":z7101.Address2 = Children(i).Code
   Case "DESTINATION":z7101.Destination = Children(i).Code
   Case "FINALSHOP":z7101.FinalShop = Children(i).Code
   Case "COUNTRY":z7101.Country = Children(i).Code
   Case "INVOICEACCOUNT":z7101.InvoiceAccount = Children(i).Code
   Case "TAXEXEMPT":z7101.TaxExempt = Children(i).Code
   Case "SESUPPLIERGROUP":z7101.seSupplierGroup = Children(i).Code
   Case "CDSUPPLIERGROUP":z7101.cdSupplierGroup = Children(i).Code
   Case "SEPOGROUP":z7101.sePOGroup = Children(i).Code
   Case "CDPOGROUP":z7101.cdPOGroup = Children(i).Code
   Case "SESOGROUP":z7101.seSOGroup = Children(i).Code
   Case "CDSOGROUP":z7101.cdSOGroup = Children(i).Code
   Case "TELEPHONECOMPANY":z7101.TelephoneCompany = Children(i).Code
   Case "TELEPHONEHAND":z7101.TelephoneHand = Children(i).Code
   Case "FAXNO":z7101.FaxNo = Children(i).Code
   Case "EMAIL":z7101.Email = Children(i).Code
   Case "BENEFICIARYNAME":z7101.BeneficiaryName = Children(i).Code
   Case "ACCOUNTNUMBER":z7101.AccountNumber = Children(i).Code
   Case "BANKNAME":z7101.BankName = Children(i).Code
   Case "BANKADDRESS":z7101.BankAddress = Children(i).Code
   Case "SWIFTCODE":z7101.SwiftCode = Children(i).Code
   Case "CDFACTORY":z7101.cdFactory = Children(i).Code
                                Case "CHECKKINDCUSTOMER" : z7101.CheckKindCustomer = Children(i).Code
                                Case "SECANCELDATE" : z7101.seCancelDate = Children(i).Code
                                Case "CDCANCELDATE" : z7101.cdCancelDate = Children(i).Code

   Case "SECUSTOMERDIVISION":z7101.seCustomerDivision = Children(i).Code
   Case "CDCUSTOMERDIVISION":z7101.cdCustomerDivision = Children(i).Code
   Case "SECUSTOMERLOCATION":z7101.seCustomerLocation = Children(i).Code
   Case "CDCUSTOMERLOCATION":z7101.cdCustomerLocation = Children(i).Code
   Case "SETAXGROUP":z7101.seTaxGroup = Children(i).Code
   Case "CDTAXGROUP":z7101.cdTaxGroup = Children(i).Code
   Case "INCHARGE":z7101.InCharge = Children(i).Code
   Case "INCHARGESALE":z7101.InChargeSale = Children(i).Code
   Case "CHECKTAX":z7101.CheckTax = Children(i).Code
   Case "CHECKCUSTOMER":z7101.CheckCustomer = Children(i).Code
   Case "CHECKSUPPLIER":z7101.CheckSupplier = Children(i).Code
   Case "CHECKEMPLOYEE":z7101.CheckEmployee = Children(i).Code
   Case "CHECKINSIDE":z7101.CheckInside = Children(i).Code
   Case "CHECKOUTSIDE":z7101.CheckOutside = Children(i).Code
   Case "CHECKOTHERS":z7101.CheckOthers = Children(i).Code
   Case "CHECKUSE":z7101.CheckUse = Children(i).Code
   Case "INCHARGEINSERT":z7101.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7101.InchargeUpdate = Children(i).Code
   Case "DATEINSERT":z7101.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7101.DateUpdate = Children(i).Code
   Case "TIMEINSERT":z7101.TimeInsert = Children(i).Code
   Case "TIMEUPDATE":z7101.TimeUpdate = Children(i).Code
   Case "TIMELAST":z7101.TimeLast = Children(i).Code
   Case "DATEACTIVE":z7101.DateActive = Children(i).Code
   Case "DATEDEACTIVE":z7101.DateDeactive = Children(i).Code
   Case "CHECKACTIVE":z7101.CheckActive = Children(i).Code
   Case "PARANO1":z7101.ParaNo1 = Children(i).Code
   Case "PARANO2":z7101.ParaNo2 = Children(i).Code
   Case "PARANO3":z7101.ParaNo3 = Children(i).Code
   Case "CHECKSYNC":z7101.CheckSync = Children(i).Code
   Case "CHECKCUSTOMERSTATUS":z7101.CheckCustomerStatus = Children(i).Code
   Case "DATECOMPLETE":z7101.DateComplete = Children(i).Code
   Case "DATEAPPROVED":z7101.DateApproved = Children(i).Code
   Case "DATECANCEL":z7101.DateCancel = Children(i).Code
   Case "DATEPENDING1":z7101.DatePending1 = Children(i).Code
   Case "DATEPENDING2":z7101.DatePending2 = Children(i).Code
   Case "REMARK":z7101.Remark = Children(i).Code
   Case "CHECKOPTION1":z7101.CheckOption1 = Children(i).Code
   Case "CHECKOPTION2":z7101.CheckOption2 = Children(i).Code
   Case "CHECKOPTION3":z7101.CheckOption3 = Children(i).Code
   Case "CHECKOPTION4":z7101.CheckOption4 = Children(i).Code
   Case "CHECKOPTION5":z7101.CheckOption5 = Children(i).Code
   Case "CHECKOPTION6":z7101.CheckOption6 = Children(i).Code
   Case "CHECKOPTION7":z7101.CheckOption7 = Children(i).Code
   Case "CHECKOPTION8":z7101.CheckOption8 = Children(i).Code
   Case "CHECKOPTION9":z7101.CheckOption9 = Children(i).Code
   Case "CHECKOPTION10":z7101.CheckOption10 = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "CUSTOMERCODE":z7101.CustomerCode = Children(i).Data
   Case "ACODERECEIVABLE":z7101.ACodeReceivable = Children(i).Data
   Case "ACODEPAYABLE":z7101.ACodePayable = Children(i).Data
   Case "DEVELOPMENTCODE":z7101.DevelopmentCode = Children(i).Data
   Case "CUSTOMERNAME":z7101.CustomerName = Children(i).Data
   Case "CUSTOMERNAME1":z7101.CustomerName1 = Children(i).Data
   Case "CUSTOMERNAMESIMPLY":z7101.CustomerNameSimply = Children(i).Data
   Case "CUSTOMERNAMESIMPLY1":z7101.CustomerNameSimply1 = Children(i).Data
   Case "SEPASSWORD":z7101.sePassWord = Children(i).Data
   Case "CDPASSWORD":z7101.cdPassWord = Children(i).Data
   Case "SEDELIVERYTERM":z7101.seDeliveryTerm = Children(i).Data
   Case "CDDELIVERYTERM":z7101.cdDeliveryTerm = Children(i).Data
   Case "SEPAYMENTTERM":z7101.sePaymentTerm = Children(i).Data
   Case "CDPAYMENTTERM":z7101.cdPaymentTerm = Children(i).Data
   Case "SEPAYMENTCONDITION":z7101.sePaymentCondition = Children(i).Data
   Case "CDPAYMENTCONDITION":z7101.cdPaymentCondition = Children(i).Data
   Case "SEPAYMENTDAY":z7101.sePaymentDay = Children(i).Data
   Case "CDPAYMENTDAY":z7101.cdPaymentDay = Children(i).Data
   Case "SEPAYMENTTIME":z7101.sePaymentTime = Children(i).Data
   Case "CDPAYMENTTIME":z7101.cdPaymentTime = Children(i).Data
   Case "SESITE":z7101.seSite = Children(i).Data
   Case "CDSITE":z7101.cdSite = Children(i).Data
   Case "SETEAM":z7101.seTeam = Children(i).Data
   Case "CDTEAM":z7101.cdTeam = Children(i).Data
   Case "FOREIGNNAME1":z7101.ForeignName1 = Children(i).Data
   Case "FOREIGNNAME2":z7101.ForeignName2 = Children(i).Data
   Case "COMPANYID":z7101.CompanyID = Children(i).Data
   Case "COMPANYTYPE":z7101.CompanyType = Children(i).Data
   Case "COMPANYITEM":z7101.CompanyItem = Children(i).Data
   Case "REPRESENTATIVE":z7101.Representative = Children(i).Data
   Case "ADDRESSNO":z7101.AddressNo = Children(i).Data
   Case "ADDRESS1":z7101.Address1 = Children(i).Data
   Case "ADDRESS2":z7101.Address2 = Children(i).Data
   Case "DESTINATION":z7101.Destination = Children(i).Data
   Case "FINALSHOP":z7101.FinalShop = Children(i).Data
   Case "COUNTRY":z7101.Country = Children(i).Data
   Case "INVOICEACCOUNT":z7101.InvoiceAccount = Children(i).Data
   Case "TAXEXEMPT":z7101.TaxExempt = Children(i).Data
   Case "SESUPPLIERGROUP":z7101.seSupplierGroup = Children(i).Data
   Case "CDSUPPLIERGROUP":z7101.cdSupplierGroup = Children(i).Data
   Case "SEPOGROUP":z7101.sePOGroup = Children(i).Data
   Case "CDPOGROUP":z7101.cdPOGroup = Children(i).Data
   Case "SESOGROUP":z7101.seSOGroup = Children(i).Data
   Case "CDSOGROUP":z7101.cdSOGroup = Children(i).Data
   Case "TELEPHONECOMPANY":z7101.TelephoneCompany = Children(i).Data
   Case "TELEPHONEHAND":z7101.TelephoneHand = Children(i).Data
   Case "FAXNO":z7101.FaxNo = Children(i).Data
   Case "EMAIL":z7101.Email = Children(i).Data
   Case "BENEFICIARYNAME":z7101.BeneficiaryName = Children(i).Data
   Case "ACCOUNTNUMBER":z7101.AccountNumber = Children(i).Data
   Case "BANKNAME":z7101.BankName = Children(i).Data
   Case "BANKADDRESS":z7101.BankAddress = Children(i).Data
   Case "SWIFTCODE":z7101.SwiftCode = Children(i).Data
   Case "CDFACTORY":z7101.cdFactory = Children(i).Data
                                Case "CHECKKINDCUSTOMER" : z7101.CheckKindCustomer = Children(i).Data
                                Case "SECANCELDATE" : z7101.seCancelDate = Children(i).Data
                                Case "CDCANCELDATE" : z7101.cdCancelDate = Children(i).Data

   Case "SECUSTOMERDIVISION":z7101.seCustomerDivision = Children(i).Data
   Case "CDCUSTOMERDIVISION":z7101.cdCustomerDivision = Children(i).Data
   Case "SECUSTOMERLOCATION":z7101.seCustomerLocation = Children(i).Data
   Case "CDCUSTOMERLOCATION":z7101.cdCustomerLocation = Children(i).Data
   Case "SETAXGROUP":z7101.seTaxGroup = Children(i).Data
   Case "CDTAXGROUP":z7101.cdTaxGroup = Children(i).Data
   Case "INCHARGE":z7101.InCharge = Children(i).Data
   Case "INCHARGESALE":z7101.InChargeSale = Children(i).Data
   Case "CHECKTAX":z7101.CheckTax = Children(i).Data
   Case "CHECKCUSTOMER":z7101.CheckCustomer = Children(i).Data
   Case "CHECKSUPPLIER":z7101.CheckSupplier = Children(i).Data
   Case "CHECKEMPLOYEE":z7101.CheckEmployee = Children(i).Data
   Case "CHECKINSIDE":z7101.CheckInside = Children(i).Data
   Case "CHECKOUTSIDE":z7101.CheckOutside = Children(i).Data
   Case "CHECKOTHERS":z7101.CheckOthers = Children(i).Data
   Case "CHECKUSE":z7101.CheckUse = Children(i).Data
   Case "INCHARGEINSERT":z7101.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7101.InchargeUpdate = Children(i).Data
   Case "DATEINSERT":z7101.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7101.DateUpdate = Children(i).Data
   Case "TIMEINSERT":z7101.TimeInsert = Children(i).Data
   Case "TIMEUPDATE":z7101.TimeUpdate = Children(i).Data
   Case "TIMELAST":z7101.TimeLast = Children(i).Data
   Case "DATEACTIVE":z7101.DateActive = Children(i).Data
   Case "DATEDEACTIVE":z7101.DateDeactive = Children(i).Data
   Case "CHECKACTIVE":z7101.CheckActive = Children(i).Data
   Case "PARANO1":z7101.ParaNo1 = Children(i).Data
   Case "PARANO2":z7101.ParaNo2 = Children(i).Data
   Case "PARANO3":z7101.ParaNo3 = Children(i).Data
   Case "CHECKSYNC":z7101.CheckSync = Children(i).Data
   Case "CHECKCUSTOMERSTATUS":z7101.CheckCustomerStatus = Children(i).Data
   Case "DATECOMPLETE":z7101.DateComplete = Children(i).Data
   Case "DATEAPPROVED":z7101.DateApproved = Children(i).Data
   Case "DATECANCEL":z7101.DateCancel = Children(i).Data
   Case "DATEPENDING1":z7101.DatePending1 = Children(i).Data
   Case "DATEPENDING2":z7101.DatePending2 = Children(i).Data
   Case "REMARK":z7101.Remark = Children(i).Data
   Case "CHECKOPTION1":z7101.CheckOption1 = Children(i).Data
   Case "CHECKOPTION2":z7101.CheckOption2 = Children(i).Data
   Case "CHECKOPTION3":z7101.CheckOption3 = Children(i).Data
   Case "CHECKOPTION4":z7101.CheckOption4 = Children(i).Data
   Case "CHECKOPTION5":z7101.CheckOption5 = Children(i).Data
   Case "CHECKOPTION6":z7101.CheckOption6 = Children(i).Data
   Case "CHECKOPTION7":z7101.CheckOption7 = Children(i).Data
   Case "CHECKOPTION8":z7101.CheckOption8 = Children(i).Data
   Case "CHECKOPTION9":z7101.CheckOption9 = Children(i).Data
   Case "CHECKOPTION10":z7101.CheckOption10 = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7101_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7101_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7101 As T7101_AREA, Job as String, CheckClear as Boolean, CUSTOMERCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7101_MOVE = False

Try
    If READ_PFK7101(CUSTOMERCODE) = True Then
                z7101 = D7101
		K7101_MOVE = True
		else
	If CheckClear  = True then z7101 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7101")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "CUSTOMERCODE":z7101.CustomerCode = Children(i).Code
   Case "ACODERECEIVABLE":z7101.ACodeReceivable = Children(i).Code
   Case "ACODEPAYABLE":z7101.ACodePayable = Children(i).Code
   Case "DEVELOPMENTCODE":z7101.DevelopmentCode = Children(i).Code
   Case "CUSTOMERNAME":z7101.CustomerName = Children(i).Code
   Case "CUSTOMERNAME1":z7101.CustomerName1 = Children(i).Code
   Case "CUSTOMERNAMESIMPLY":z7101.CustomerNameSimply = Children(i).Code
   Case "CUSTOMERNAMESIMPLY1":z7101.CustomerNameSimply1 = Children(i).Code
   Case "SEPASSWORD":z7101.sePassWord = Children(i).Code
   Case "CDPASSWORD":z7101.cdPassWord = Children(i).Code
   Case "SEDELIVERYTERM":z7101.seDeliveryTerm = Children(i).Code
   Case "CDDELIVERYTERM":z7101.cdDeliveryTerm = Children(i).Code
   Case "SEPAYMENTTERM":z7101.sePaymentTerm = Children(i).Code
   Case "CDPAYMENTTERM":z7101.cdPaymentTerm = Children(i).Code
   Case "SEPAYMENTCONDITION":z7101.sePaymentCondition = Children(i).Code
   Case "CDPAYMENTCONDITION":z7101.cdPaymentCondition = Children(i).Code
   Case "SEPAYMENTDAY":z7101.sePaymentDay = Children(i).Code
   Case "CDPAYMENTDAY":z7101.cdPaymentDay = Children(i).Code
   Case "SEPAYMENTTIME":z7101.sePaymentTime = Children(i).Code
   Case "CDPAYMENTTIME":z7101.cdPaymentTime = Children(i).Code
   Case "SESITE":z7101.seSite = Children(i).Code
   Case "CDSITE":z7101.cdSite = Children(i).Code
   Case "SETEAM":z7101.seTeam = Children(i).Code
   Case "CDTEAM":z7101.cdTeam = Children(i).Code
   Case "FOREIGNNAME1":z7101.ForeignName1 = Children(i).Code
   Case "FOREIGNNAME2":z7101.ForeignName2 = Children(i).Code
   Case "COMPANYID":z7101.CompanyID = Children(i).Code
   Case "COMPANYTYPE":z7101.CompanyType = Children(i).Code
   Case "COMPANYITEM":z7101.CompanyItem = Children(i).Code
   Case "REPRESENTATIVE":z7101.Representative = Children(i).Code
   Case "ADDRESSNO":z7101.AddressNo = Children(i).Code
   Case "ADDRESS1":z7101.Address1 = Children(i).Code
   Case "ADDRESS2":z7101.Address2 = Children(i).Code
   Case "DESTINATION":z7101.Destination = Children(i).Code
   Case "FINALSHOP":z7101.FinalShop = Children(i).Code
   Case "COUNTRY":z7101.Country = Children(i).Code
   Case "INVOICEACCOUNT":z7101.InvoiceAccount = Children(i).Code
   Case "TAXEXEMPT":z7101.TaxExempt = Children(i).Code
   Case "SESUPPLIERGROUP":z7101.seSupplierGroup = Children(i).Code
   Case "CDSUPPLIERGROUP":z7101.cdSupplierGroup = Children(i).Code
   Case "SEPOGROUP":z7101.sePOGroup = Children(i).Code
   Case "CDPOGROUP":z7101.cdPOGroup = Children(i).Code
   Case "SESOGROUP":z7101.seSOGroup = Children(i).Code
   Case "CDSOGROUP":z7101.cdSOGroup = Children(i).Code
   Case "TELEPHONECOMPANY":z7101.TelephoneCompany = Children(i).Code
   Case "TELEPHONEHAND":z7101.TelephoneHand = Children(i).Code
   Case "FAXNO":z7101.FaxNo = Children(i).Code
   Case "EMAIL":z7101.Email = Children(i).Code
   Case "BENEFICIARYNAME":z7101.BeneficiaryName = Children(i).Code
   Case "ACCOUNTNUMBER":z7101.AccountNumber = Children(i).Code
   Case "BANKNAME":z7101.BankName = Children(i).Code
   Case "BANKADDRESS":z7101.BankAddress = Children(i).Code
   Case "SWIFTCODE":z7101.SwiftCode = Children(i).Code
   Case "CDFACTORY":z7101.cdFactory = Children(i).Code
                                Case "CHECKKINDCUSTOMER" : z7101.CheckKindCustomer = Children(i).Code
                                Case "SECANCELDATE" : z7101.seCancelDate = Children(i).Code
                                Case "CDCANCELDATE" : z7101.cdCancelDate = Children(i).Code

   Case "SECUSTOMERDIVISION":z7101.seCustomerDivision = Children(i).Code
   Case "CDCUSTOMERDIVISION":z7101.cdCustomerDivision = Children(i).Code
   Case "SECUSTOMERLOCATION":z7101.seCustomerLocation = Children(i).Code
   Case "CDCUSTOMERLOCATION":z7101.cdCustomerLocation = Children(i).Code
   Case "SETAXGROUP":z7101.seTaxGroup = Children(i).Code
   Case "CDTAXGROUP":z7101.cdTaxGroup = Children(i).Code
   Case "INCHARGE":z7101.InCharge = Children(i).Code
   Case "INCHARGESALE":z7101.InChargeSale = Children(i).Code
   Case "CHECKTAX":z7101.CheckTax = Children(i).Code
   Case "CHECKCUSTOMER":z7101.CheckCustomer = Children(i).Code
   Case "CHECKSUPPLIER":z7101.CheckSupplier = Children(i).Code
   Case "CHECKEMPLOYEE":z7101.CheckEmployee = Children(i).Code
   Case "CHECKINSIDE":z7101.CheckInside = Children(i).Code
   Case "CHECKOUTSIDE":z7101.CheckOutside = Children(i).Code
   Case "CHECKOTHERS":z7101.CheckOthers = Children(i).Code
   Case "CHECKUSE":z7101.CheckUse = Children(i).Code
   Case "INCHARGEINSERT":z7101.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7101.InchargeUpdate = Children(i).Code
   Case "DATEINSERT":z7101.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7101.DateUpdate = Children(i).Code
   Case "TIMEINSERT":z7101.TimeInsert = Children(i).Code
   Case "TIMEUPDATE":z7101.TimeUpdate = Children(i).Code
   Case "TIMELAST":z7101.TimeLast = Children(i).Code
   Case "DATEACTIVE":z7101.DateActive = Children(i).Code
   Case "DATEDEACTIVE":z7101.DateDeactive = Children(i).Code
   Case "CHECKACTIVE":z7101.CheckActive = Children(i).Code
   Case "PARANO1":z7101.ParaNo1 = Children(i).Code
   Case "PARANO2":z7101.ParaNo2 = Children(i).Code
   Case "PARANO3":z7101.ParaNo3 = Children(i).Code
   Case "CHECKSYNC":z7101.CheckSync = Children(i).Code
   Case "CHECKCUSTOMERSTATUS":z7101.CheckCustomerStatus = Children(i).Code
   Case "DATECOMPLETE":z7101.DateComplete = Children(i).Code
   Case "DATEAPPROVED":z7101.DateApproved = Children(i).Code
   Case "DATECANCEL":z7101.DateCancel = Children(i).Code
   Case "DATEPENDING1":z7101.DatePending1 = Children(i).Code
   Case "DATEPENDING2":z7101.DatePending2 = Children(i).Code
   Case "REMARK":z7101.Remark = Children(i).Code
   Case "CHECKOPTION1":z7101.CheckOption1 = Children(i).Code
   Case "CHECKOPTION2":z7101.CheckOption2 = Children(i).Code
   Case "CHECKOPTION3":z7101.CheckOption3 = Children(i).Code
   Case "CHECKOPTION4":z7101.CheckOption4 = Children(i).Code
   Case "CHECKOPTION5":z7101.CheckOption5 = Children(i).Code
   Case "CHECKOPTION6":z7101.CheckOption6 = Children(i).Code
   Case "CHECKOPTION7":z7101.CheckOption7 = Children(i).Code
   Case "CHECKOPTION8":z7101.CheckOption8 = Children(i).Code
   Case "CHECKOPTION9":z7101.CheckOption9 = Children(i).Code
   Case "CHECKOPTION10":z7101.CheckOption10 = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "CUSTOMERCODE":z7101.CustomerCode = Children(i).Data
   Case "ACODERECEIVABLE":z7101.ACodeReceivable = Children(i).Data
   Case "ACODEPAYABLE":z7101.ACodePayable = Children(i).Data
   Case "DEVELOPMENTCODE":z7101.DevelopmentCode = Children(i).Data
   Case "CUSTOMERNAME":z7101.CustomerName = Children(i).Data
   Case "CUSTOMERNAME1":z7101.CustomerName1 = Children(i).Data
   Case "CUSTOMERNAMESIMPLY":z7101.CustomerNameSimply = Children(i).Data
   Case "CUSTOMERNAMESIMPLY1":z7101.CustomerNameSimply1 = Children(i).Data
   Case "SEPASSWORD":z7101.sePassWord = Children(i).Data
   Case "CDPASSWORD":z7101.cdPassWord = Children(i).Data
   Case "SEDELIVERYTERM":z7101.seDeliveryTerm = Children(i).Data
   Case "CDDELIVERYTERM":z7101.cdDeliveryTerm = Children(i).Data
   Case "SEPAYMENTTERM":z7101.sePaymentTerm = Children(i).Data
   Case "CDPAYMENTTERM":z7101.cdPaymentTerm = Children(i).Data
   Case "SEPAYMENTCONDITION":z7101.sePaymentCondition = Children(i).Data
   Case "CDPAYMENTCONDITION":z7101.cdPaymentCondition = Children(i).Data
   Case "SEPAYMENTDAY":z7101.sePaymentDay = Children(i).Data
   Case "CDPAYMENTDAY":z7101.cdPaymentDay = Children(i).Data
   Case "SEPAYMENTTIME":z7101.sePaymentTime = Children(i).Data
   Case "CDPAYMENTTIME":z7101.cdPaymentTime = Children(i).Data
   Case "SESITE":z7101.seSite = Children(i).Data
   Case "CDSITE":z7101.cdSite = Children(i).Data
   Case "SETEAM":z7101.seTeam = Children(i).Data
   Case "CDTEAM":z7101.cdTeam = Children(i).Data
   Case "FOREIGNNAME1":z7101.ForeignName1 = Children(i).Data
   Case "FOREIGNNAME2":z7101.ForeignName2 = Children(i).Data
   Case "COMPANYID":z7101.CompanyID = Children(i).Data
   Case "COMPANYTYPE":z7101.CompanyType = Children(i).Data
   Case "COMPANYITEM":z7101.CompanyItem = Children(i).Data
   Case "REPRESENTATIVE":z7101.Representative = Children(i).Data
   Case "ADDRESSNO":z7101.AddressNo = Children(i).Data
   Case "ADDRESS1":z7101.Address1 = Children(i).Data
   Case "ADDRESS2":z7101.Address2 = Children(i).Data
   Case "DESTINATION":z7101.Destination = Children(i).Data
   Case "FINALSHOP":z7101.FinalShop = Children(i).Data
   Case "COUNTRY":z7101.Country = Children(i).Data
   Case "INVOICEACCOUNT":z7101.InvoiceAccount = Children(i).Data
   Case "TAXEXEMPT":z7101.TaxExempt = Children(i).Data
   Case "SESUPPLIERGROUP":z7101.seSupplierGroup = Children(i).Data
   Case "CDSUPPLIERGROUP":z7101.cdSupplierGroup = Children(i).Data
   Case "SEPOGROUP":z7101.sePOGroup = Children(i).Data
   Case "CDPOGROUP":z7101.cdPOGroup = Children(i).Data
   Case "SESOGROUP":z7101.seSOGroup = Children(i).Data
   Case "CDSOGROUP":z7101.cdSOGroup = Children(i).Data
   Case "TELEPHONECOMPANY":z7101.TelephoneCompany = Children(i).Data
   Case "TELEPHONEHAND":z7101.TelephoneHand = Children(i).Data
   Case "FAXNO":z7101.FaxNo = Children(i).Data
   Case "EMAIL":z7101.Email = Children(i).Data
   Case "BENEFICIARYNAME":z7101.BeneficiaryName = Children(i).Data
   Case "ACCOUNTNUMBER":z7101.AccountNumber = Children(i).Data
   Case "BANKNAME":z7101.BankName = Children(i).Data
   Case "BANKADDRESS":z7101.BankAddress = Children(i).Data
   Case "SWIFTCODE":z7101.SwiftCode = Children(i).Data
   Case "CDFACTORY":z7101.cdFactory = Children(i).Data
                                Case "CHECKKINDCUSTOMER" : z7101.CheckKindCustomer = Children(i).Data
                                Case "SECANCELDATE" : z7101.seCancelDate = Children(i).Data
                                Case "CDCANCELDATE" : z7101.cdCancelDate = Children(i).Data

   Case "SECUSTOMERDIVISION":z7101.seCustomerDivision = Children(i).Data
   Case "CDCUSTOMERDIVISION":z7101.cdCustomerDivision = Children(i).Data
   Case "SECUSTOMERLOCATION":z7101.seCustomerLocation = Children(i).Data
   Case "CDCUSTOMERLOCATION":z7101.cdCustomerLocation = Children(i).Data
   Case "SETAXGROUP":z7101.seTaxGroup = Children(i).Data
   Case "CDTAXGROUP":z7101.cdTaxGroup = Children(i).Data
   Case "INCHARGE":z7101.InCharge = Children(i).Data
   Case "INCHARGESALE":z7101.InChargeSale = Children(i).Data
   Case "CHECKTAX":z7101.CheckTax = Children(i).Data
   Case "CHECKCUSTOMER":z7101.CheckCustomer = Children(i).Data
   Case "CHECKSUPPLIER":z7101.CheckSupplier = Children(i).Data
   Case "CHECKEMPLOYEE":z7101.CheckEmployee = Children(i).Data
   Case "CHECKINSIDE":z7101.CheckInside = Children(i).Data
   Case "CHECKOUTSIDE":z7101.CheckOutside = Children(i).Data
   Case "CHECKOTHERS":z7101.CheckOthers = Children(i).Data
   Case "CHECKUSE":z7101.CheckUse = Children(i).Data
   Case "INCHARGEINSERT":z7101.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7101.InchargeUpdate = Children(i).Data
   Case "DATEINSERT":z7101.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7101.DateUpdate = Children(i).Data
   Case "TIMEINSERT":z7101.TimeInsert = Children(i).Data
   Case "TIMEUPDATE":z7101.TimeUpdate = Children(i).Data
   Case "TIMELAST":z7101.TimeLast = Children(i).Data
   Case "DATEACTIVE":z7101.DateActive = Children(i).Data
   Case "DATEDEACTIVE":z7101.DateDeactive = Children(i).Data
   Case "CHECKACTIVE":z7101.CheckActive = Children(i).Data
   Case "PARANO1":z7101.ParaNo1 = Children(i).Data
   Case "PARANO2":z7101.ParaNo2 = Children(i).Data
   Case "PARANO3":z7101.ParaNo3 = Children(i).Data
   Case "CHECKSYNC":z7101.CheckSync = Children(i).Data
   Case "CHECKCUSTOMERSTATUS":z7101.CheckCustomerStatus = Children(i).Data
   Case "DATECOMPLETE":z7101.DateComplete = Children(i).Data
   Case "DATEAPPROVED":z7101.DateApproved = Children(i).Data
   Case "DATECANCEL":z7101.DateCancel = Children(i).Data
   Case "DATEPENDING1":z7101.DatePending1 = Children(i).Data
   Case "DATEPENDING2":z7101.DatePending2 = Children(i).Data
   Case "REMARK":z7101.Remark = Children(i).Data
   Case "CHECKOPTION1":z7101.CheckOption1 = Children(i).Data
   Case "CHECKOPTION2":z7101.CheckOption2 = Children(i).Data
   Case "CHECKOPTION3":z7101.CheckOption3 = Children(i).Data
   Case "CHECKOPTION4":z7101.CheckOption4 = Children(i).Data
   Case "CHECKOPTION5":z7101.CheckOption5 = Children(i).Data
   Case "CHECKOPTION6":z7101.CheckOption6 = Children(i).Data
   Case "CHECKOPTION7":z7101.CheckOption7 = Children(i).Data
   Case "CHECKOPTION8":z7101.CheckOption8 = Children(i).Data
   Case "CHECKOPTION9":z7101.CheckOption9 = Children(i).Data
   Case "CHECKOPTION10":z7101.CheckOption10 = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7101_MOVE",vbCritical)
End Try
End Function 
    

'=========================================================================================================================================================
' DATA MOVE FORM NEW AREA
'=========================================================================================================================================================
Public Sub K7101_MOVE(ByRef a7101 As T7101_AREA, ByRef b7101 As T7101_AREA) 
Try
If trim$( a7101.CustomerCode ) = "" Then b7101.CustomerCode = ""  Else b7101.CustomerCode=a7101.CustomerCode
If trim$( a7101.ACodeReceivable ) = "" Then b7101.ACodeReceivable = ""  Else b7101.ACodeReceivable=a7101.ACodeReceivable
If trim$( a7101.ACodePayable ) = "" Then b7101.ACodePayable = ""  Else b7101.ACodePayable=a7101.ACodePayable
If trim$( a7101.DevelopmentCode ) = "" Then b7101.DevelopmentCode = ""  Else b7101.DevelopmentCode=a7101.DevelopmentCode
If trim$( a7101.CustomerName ) = "" Then b7101.CustomerName = ""  Else b7101.CustomerName=a7101.CustomerName
If trim$( a7101.CustomerName1 ) = "" Then b7101.CustomerName1 = ""  Else b7101.CustomerName1=a7101.CustomerName1
If trim$( a7101.CustomerNameSimply ) = "" Then b7101.CustomerNameSimply = ""  Else b7101.CustomerNameSimply=a7101.CustomerNameSimply
If trim$( a7101.CustomerNameSimply1 ) = "" Then b7101.CustomerNameSimply1 = ""  Else b7101.CustomerNameSimply1=a7101.CustomerNameSimply1
If trim$( a7101.sePassWord ) = "" Then b7101.sePassWord = ""  Else b7101.sePassWord=a7101.sePassWord
If trim$( a7101.cdPassWord ) = "" Then b7101.cdPassWord = ""  Else b7101.cdPassWord=a7101.cdPassWord
If trim$( a7101.seDeliveryTerm ) = "" Then b7101.seDeliveryTerm = ""  Else b7101.seDeliveryTerm=a7101.seDeliveryTerm
If trim$( a7101.cdDeliveryTerm ) = "" Then b7101.cdDeliveryTerm = ""  Else b7101.cdDeliveryTerm=a7101.cdDeliveryTerm
If trim$( a7101.sePaymentTerm ) = "" Then b7101.sePaymentTerm = ""  Else b7101.sePaymentTerm=a7101.sePaymentTerm
If trim$( a7101.cdPaymentTerm ) = "" Then b7101.cdPaymentTerm = ""  Else b7101.cdPaymentTerm=a7101.cdPaymentTerm
If trim$( a7101.sePaymentCondition ) = "" Then b7101.sePaymentCondition = ""  Else b7101.sePaymentCondition=a7101.sePaymentCondition
If trim$( a7101.cdPaymentCondition ) = "" Then b7101.cdPaymentCondition = ""  Else b7101.cdPaymentCondition=a7101.cdPaymentCondition
If trim$( a7101.sePaymentDay ) = "" Then b7101.sePaymentDay = ""  Else b7101.sePaymentDay=a7101.sePaymentDay
If trim$( a7101.cdPaymentDay ) = "" Then b7101.cdPaymentDay = ""  Else b7101.cdPaymentDay=a7101.cdPaymentDay
If trim$( a7101.sePaymentTime ) = "" Then b7101.sePaymentTime = ""  Else b7101.sePaymentTime=a7101.sePaymentTime
If trim$( a7101.cdPaymentTime ) = "" Then b7101.cdPaymentTime = ""  Else b7101.cdPaymentTime=a7101.cdPaymentTime
If trim$( a7101.seSite ) = "" Then b7101.seSite = ""  Else b7101.seSite=a7101.seSite
If trim$( a7101.cdSite ) = "" Then b7101.cdSite = ""  Else b7101.cdSite=a7101.cdSite
If trim$( a7101.seTeam ) = "" Then b7101.seTeam = ""  Else b7101.seTeam=a7101.seTeam
If trim$( a7101.cdTeam ) = "" Then b7101.cdTeam = ""  Else b7101.cdTeam=a7101.cdTeam
If trim$( a7101.ForeignName1 ) = "" Then b7101.ForeignName1 = ""  Else b7101.ForeignName1=a7101.ForeignName1
If trim$( a7101.ForeignName2 ) = "" Then b7101.ForeignName2 = ""  Else b7101.ForeignName2=a7101.ForeignName2
If trim$( a7101.CompanyID ) = "" Then b7101.CompanyID = ""  Else b7101.CompanyID=a7101.CompanyID
If trim$( a7101.CompanyType ) = "" Then b7101.CompanyType = ""  Else b7101.CompanyType=a7101.CompanyType
If trim$( a7101.CompanyItem ) = "" Then b7101.CompanyItem = ""  Else b7101.CompanyItem=a7101.CompanyItem
If trim$( a7101.Representative ) = "" Then b7101.Representative = ""  Else b7101.Representative=a7101.Representative
If trim$( a7101.AddressNo ) = "" Then b7101.AddressNo = ""  Else b7101.AddressNo=a7101.AddressNo
If trim$( a7101.Address1 ) = "" Then b7101.Address1 = ""  Else b7101.Address1=a7101.Address1
If trim$( a7101.Address2 ) = "" Then b7101.Address2 = ""  Else b7101.Address2=a7101.Address2
If trim$( a7101.Destination ) = "" Then b7101.Destination = ""  Else b7101.Destination=a7101.Destination
If trim$( a7101.FinalShop ) = "" Then b7101.FinalShop = ""  Else b7101.FinalShop=a7101.FinalShop
If trim$( a7101.Country ) = "" Then b7101.Country = ""  Else b7101.Country=a7101.Country
If trim$( a7101.InvoiceAccount ) = "" Then b7101.InvoiceAccount = ""  Else b7101.InvoiceAccount=a7101.InvoiceAccount
If trim$( a7101.TaxExempt ) = "" Then b7101.TaxExempt = ""  Else b7101.TaxExempt=a7101.TaxExempt
If trim$( a7101.seSupplierGroup ) = "" Then b7101.seSupplierGroup = ""  Else b7101.seSupplierGroup=a7101.seSupplierGroup
If trim$( a7101.cdSupplierGroup ) = "" Then b7101.cdSupplierGroup = ""  Else b7101.cdSupplierGroup=a7101.cdSupplierGroup
If trim$( a7101.sePOGroup ) = "" Then b7101.sePOGroup = ""  Else b7101.sePOGroup=a7101.sePOGroup
If trim$( a7101.cdPOGroup ) = "" Then b7101.cdPOGroup = ""  Else b7101.cdPOGroup=a7101.cdPOGroup
If trim$( a7101.seSOGroup ) = "" Then b7101.seSOGroup = ""  Else b7101.seSOGroup=a7101.seSOGroup
If trim$( a7101.cdSOGroup ) = "" Then b7101.cdSOGroup = ""  Else b7101.cdSOGroup=a7101.cdSOGroup
If trim$( a7101.TelephoneCompany ) = "" Then b7101.TelephoneCompany = ""  Else b7101.TelephoneCompany=a7101.TelephoneCompany
If trim$( a7101.TelephoneHand ) = "" Then b7101.TelephoneHand = ""  Else b7101.TelephoneHand=a7101.TelephoneHand
If trim$( a7101.FaxNo ) = "" Then b7101.FaxNo = ""  Else b7101.FaxNo=a7101.FaxNo
If trim$( a7101.Email ) = "" Then b7101.Email = ""  Else b7101.Email=a7101.Email
If trim$( a7101.BeneficiaryName ) = "" Then b7101.BeneficiaryName = ""  Else b7101.BeneficiaryName=a7101.BeneficiaryName
If trim$( a7101.AccountNumber ) = "" Then b7101.AccountNumber = ""  Else b7101.AccountNumber=a7101.AccountNumber
If trim$( a7101.BankName ) = "" Then b7101.BankName = ""  Else b7101.BankName=a7101.BankName
If trim$( a7101.BankAddress ) = "" Then b7101.BankAddress = ""  Else b7101.BankAddress=a7101.BankAddress
If trim$( a7101.SwiftCode ) = "" Then b7101.SwiftCode = ""  Else b7101.SwiftCode=a7101.SwiftCode
If trim$( a7101.cdFactory ) = "" Then b7101.cdFactory = ""  Else b7101.cdFactory=a7101.cdFactory
            If Trim$(a7101.CheckKindCustomer) = "" Then b7101.CheckKindCustomer = "" Else b7101.CheckKindCustomer = a7101.CheckKindCustomer
            If Trim$(a7101.seCancelDate) = "" Then b7101.seCancelDate = "" Else b7101.seCancelDate = a7101.seCancelDate
            If Trim$(a7101.cdCancelDate) = "" Then b7101.cdCancelDate = "" Else b7101.cdCancelDate = a7101.cdCancelDate
If trim$( a7101.seCustomerDivision ) = "" Then b7101.seCustomerDivision = ""  Else b7101.seCustomerDivision=a7101.seCustomerDivision
If trim$( a7101.cdCustomerDivision ) = "" Then b7101.cdCustomerDivision = ""  Else b7101.cdCustomerDivision=a7101.cdCustomerDivision
If trim$( a7101.seCustomerLocation ) = "" Then b7101.seCustomerLocation = ""  Else b7101.seCustomerLocation=a7101.seCustomerLocation
If trim$( a7101.cdCustomerLocation ) = "" Then b7101.cdCustomerLocation = ""  Else b7101.cdCustomerLocation=a7101.cdCustomerLocation
If trim$( a7101.seTaxGroup ) = "" Then b7101.seTaxGroup = ""  Else b7101.seTaxGroup=a7101.seTaxGroup
If trim$( a7101.cdTaxGroup ) = "" Then b7101.cdTaxGroup = ""  Else b7101.cdTaxGroup=a7101.cdTaxGroup
If trim$( a7101.InCharge ) = "" Then b7101.InCharge = ""  Else b7101.InCharge=a7101.InCharge
If trim$( a7101.InChargeSale ) = "" Then b7101.InChargeSale = ""  Else b7101.InChargeSale=a7101.InChargeSale
If trim$( a7101.CheckTax ) = "" Then b7101.CheckTax = ""  Else b7101.CheckTax=a7101.CheckTax
If trim$( a7101.CheckCustomer ) = "" Then b7101.CheckCustomer = ""  Else b7101.CheckCustomer=a7101.CheckCustomer
If trim$( a7101.CheckSupplier ) = "" Then b7101.CheckSupplier = ""  Else b7101.CheckSupplier=a7101.CheckSupplier
If trim$( a7101.CheckEmployee ) = "" Then b7101.CheckEmployee = ""  Else b7101.CheckEmployee=a7101.CheckEmployee
If trim$( a7101.CheckInside ) = "" Then b7101.CheckInside = ""  Else b7101.CheckInside=a7101.CheckInside
If trim$( a7101.CheckOutside ) = "" Then b7101.CheckOutside = ""  Else b7101.CheckOutside=a7101.CheckOutside
If trim$( a7101.CheckOthers ) = "" Then b7101.CheckOthers = ""  Else b7101.CheckOthers=a7101.CheckOthers
If trim$( a7101.CheckUse ) = "" Then b7101.CheckUse = ""  Else b7101.CheckUse=a7101.CheckUse
If trim$( a7101.InchargeInsert ) = "" Then b7101.InchargeInsert = ""  Else b7101.InchargeInsert=a7101.InchargeInsert
If trim$( a7101.InchargeUpdate ) = "" Then b7101.InchargeUpdate = ""  Else b7101.InchargeUpdate=a7101.InchargeUpdate
If trim$( a7101.DateInsert ) = "" Then b7101.DateInsert = ""  Else b7101.DateInsert=a7101.DateInsert
If trim$( a7101.DateUpdate ) = "" Then b7101.DateUpdate = ""  Else b7101.DateUpdate=a7101.DateUpdate
If trim$( a7101.TimeInsert ) = "" Then b7101.TimeInsert = ""  Else b7101.TimeInsert=a7101.TimeInsert
If trim$( a7101.TimeUpdate ) = "" Then b7101.TimeUpdate = ""  Else b7101.TimeUpdate=a7101.TimeUpdate
If trim$( a7101.TimeLast ) = "" Then b7101.TimeLast = ""  Else b7101.TimeLast=a7101.TimeLast
If trim$( a7101.DateActive ) = "" Then b7101.DateActive = ""  Else b7101.DateActive=a7101.DateActive
If trim$( a7101.DateDeactive ) = "" Then b7101.DateDeactive = ""  Else b7101.DateDeactive=a7101.DateDeactive
If trim$( a7101.CheckActive ) = "" Then b7101.CheckActive = ""  Else b7101.CheckActive=a7101.CheckActive
If trim$( a7101.ParaNo1 ) = "" Then b7101.ParaNo1 = ""  Else b7101.ParaNo1=a7101.ParaNo1
If trim$( a7101.ParaNo2 ) = "" Then b7101.ParaNo2 = ""  Else b7101.ParaNo2=a7101.ParaNo2
If trim$( a7101.ParaNo3 ) = "" Then b7101.ParaNo3 = ""  Else b7101.ParaNo3=a7101.ParaNo3
If trim$( a7101.CheckSync ) = "" Then b7101.CheckSync = ""  Else b7101.CheckSync=a7101.CheckSync
If trim$( a7101.CheckCustomerStatus ) = "" Then b7101.CheckCustomerStatus = ""  Else b7101.CheckCustomerStatus=a7101.CheckCustomerStatus
If trim$( a7101.DateComplete ) = "" Then b7101.DateComplete = ""  Else b7101.DateComplete=a7101.DateComplete
If trim$( a7101.DateApproved ) = "" Then b7101.DateApproved = ""  Else b7101.DateApproved=a7101.DateApproved
If trim$( a7101.DateCancel ) = "" Then b7101.DateCancel = ""  Else b7101.DateCancel=a7101.DateCancel
If trim$( a7101.DatePending1 ) = "" Then b7101.DatePending1 = ""  Else b7101.DatePending1=a7101.DatePending1
If trim$( a7101.DatePending2 ) = "" Then b7101.DatePending2 = ""  Else b7101.DatePending2=a7101.DatePending2
If trim$( a7101.Remark ) = "" Then b7101.Remark = ""  Else b7101.Remark=a7101.Remark
If trim$( a7101.CheckOption1 ) = "" Then b7101.CheckOption1 = ""  Else b7101.CheckOption1=a7101.CheckOption1
If trim$( a7101.CheckOption2 ) = "" Then b7101.CheckOption2 = ""  Else b7101.CheckOption2=a7101.CheckOption2
If trim$( a7101.CheckOption3 ) = "" Then b7101.CheckOption3 = ""  Else b7101.CheckOption3=a7101.CheckOption3
If trim$( a7101.CheckOption4 ) = "" Then b7101.CheckOption4 = ""  Else b7101.CheckOption4=a7101.CheckOption4
If trim$( a7101.CheckOption5 ) = "" Then b7101.CheckOption5 = ""  Else b7101.CheckOption5=a7101.CheckOption5
If trim$( a7101.CheckOption6 ) = "" Then b7101.CheckOption6 = ""  Else b7101.CheckOption6=a7101.CheckOption6
If trim$( a7101.CheckOption7 ) = "" Then b7101.CheckOption7 = ""  Else b7101.CheckOption7=a7101.CheckOption7
If trim$( a7101.CheckOption8 ) = "" Then b7101.CheckOption8 = ""  Else b7101.CheckOption8=a7101.CheckOption8
If trim$( a7101.CheckOption9 ) = "" Then b7101.CheckOption9 = ""  Else b7101.CheckOption9=a7101.CheckOption9
If trim$( a7101.CheckOption10 ) = "" Then b7101.CheckOption10 = ""  Else b7101.CheckOption10=a7101.CheckOption10
Catch ex As Exception
      Call MsgBoxP("K7101_MOVE",vbCritical)
End Try
End Sub 


End Module 
