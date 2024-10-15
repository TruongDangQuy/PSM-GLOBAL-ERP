'=========================================================================================================================================================
'   TABLE : (PFK7360)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7360

Structure T7360_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	ContractID	 AS String	'			char(6)		*
Public 	DateAccept	 AS String	'			char(8)
Public 	CustomerCode	 AS String	'			char(6)
Public 	seSubProcess	 AS String	'			char(3)
Public 	cdSubProcess	 AS String	'			char(3)
Public 	CheckProcessType	 AS String	'			char(1)
Public 	CheckIOType	 AS String	'			char(1)
Public 	ContractNo	 AS String	'			nvarchar(50)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(6)
Public 	InchargeUpdate	 AS String	'			char(6)
Public 	InchargePurchasing	 AS String	'			char(8)
Public 	CheckSupplierPrice	 AS String	'			char(1)
Public 	seTax1	 AS String	'			char(3)
Public 	cdTax1	 AS String	'			char(3)
Public 	seTax2	 AS String	'			char(3)
Public 	cdTax2	 AS String	'			char(3)
Public 	seTax3	 AS String	'			char(3)
Public 	cdTax3	 AS String	'			char(3)
Public 	DateComplete	 AS String	'			char(8)
Public 	DateApproved	 AS String	'			char(8)
Public 	DateCancel	 AS String	'			char(8)
Public 	DatePending1	 AS String	'			char(8)
Public 	DatePending2	 AS String	'			char(8)
Public 	CheckUse	 AS String	'			char(1)
Public 	Remark	 AS String	'			nvarchar(1000)
'=========================================================================================================================================================
End structure

Public D7360 As T7360_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7360(CONTRACTID AS String) As Boolean
    READ_PFK7360 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7360 "
    SQL = SQL & " WHERE K7360_ContractID		 = '" & ContractID & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7360_CLEAR: GoTo SKIP_READ_PFK7360
                
    Call K7360_MOVE(rd)
    READ_PFK7360 = True

SKIP_READ_PFK7360:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7360",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7360(CONTRACTID AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7360 "
    SQL = SQL & " WHERE K7360_ContractID		 = '" & ContractID & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7360",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7360(z7360 As T7360_AREA) As Boolean
    WRITE_PFK7360 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7360)
 
    SQL = " INSERT INTO PFK7360 "
    SQL = SQL & " ( "
    SQL = SQL & " K7360_ContractID," 
    SQL = SQL & " K7360_DateAccept," 
    SQL = SQL & " K7360_CustomerCode," 
    SQL = SQL & " K7360_seSubProcess," 
    SQL = SQL & " K7360_cdSubProcess," 
    SQL = SQL & " K7360_CheckProcessType," 
    SQL = SQL & " K7360_CheckIOType," 
    SQL = SQL & " K7360_ContractNo," 
    SQL = SQL & " K7360_DateInsert," 
    SQL = SQL & " K7360_DateUpdate," 
    SQL = SQL & " K7360_InchargeInsert," 
    SQL = SQL & " K7360_InchargeUpdate," 
    SQL = SQL & " K7360_InchargePurchasing," 
    SQL = SQL & " K7360_CheckSupplierPrice," 
    SQL = SQL & " K7360_seTax1," 
    SQL = SQL & " K7360_cdTax1," 
    SQL = SQL & " K7360_seTax2," 
    SQL = SQL & " K7360_cdTax2," 
    SQL = SQL & " K7360_seTax3," 
    SQL = SQL & " K7360_cdTax3," 
    SQL = SQL & " K7360_DateComplete," 
    SQL = SQL & " K7360_DateApproved," 
    SQL = SQL & " K7360_DateCancel," 
    SQL = SQL & " K7360_DatePending1," 
    SQL = SQL & " K7360_DatePending2," 
    SQL = SQL & " K7360_CheckUse," 
    SQL = SQL & " K7360_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7360.ContractID) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7360.DateAccept) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7360.CustomerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7360.seSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7360.cdSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7360.CheckProcessType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7360.CheckIOType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7360.ContractNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7360.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7360.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7360.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7360.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7360.InchargePurchasing) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7360.CheckSupplierPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7360.seTax1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7360.cdTax1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7360.seTax2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7360.cdTax2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7360.seTax3) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7360.cdTax3) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7360.DateComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7360.DateApproved) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7360.DateCancel) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7360.DatePending1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7360.DatePending2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7360.CheckUse) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7360.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7360 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7360",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7360(z7360 As T7360_AREA) As Boolean
    REWRITE_PFK7360 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7360)
   
    SQL = " UPDATE PFK7360 SET "
    SQL = SQL & "    K7360_DateAccept      = N'" & FormatSQL(z7360.DateAccept) & "', " 
    SQL = SQL & "    K7360_CustomerCode      = N'" & FormatSQL(z7360.CustomerCode) & "', " 
    SQL = SQL & "    K7360_seSubProcess      = N'" & FormatSQL(z7360.seSubProcess) & "', " 
    SQL = SQL & "    K7360_cdSubProcess      = N'" & FormatSQL(z7360.cdSubProcess) & "', " 
    SQL = SQL & "    K7360_CheckProcessType      = N'" & FormatSQL(z7360.CheckProcessType) & "', " 
    SQL = SQL & "    K7360_CheckIOType      = N'" & FormatSQL(z7360.CheckIOType) & "', " 
    SQL = SQL & "    K7360_ContractNo      = N'" & FormatSQL(z7360.ContractNo) & "', " 
    SQL = SQL & "    K7360_DateInsert      = N'" & FormatSQL(z7360.DateInsert) & "', " 
    SQL = SQL & "    K7360_DateUpdate      = N'" & FormatSQL(z7360.DateUpdate) & "', " 
    SQL = SQL & "    K7360_InchargeInsert      = N'" & FormatSQL(z7360.InchargeInsert) & "', " 
    SQL = SQL & "    K7360_InchargeUpdate      = N'" & FormatSQL(z7360.InchargeUpdate) & "', " 
    SQL = SQL & "    K7360_InchargePurchasing      = N'" & FormatSQL(z7360.InchargePurchasing) & "', " 
    SQL = SQL & "    K7360_CheckSupplierPrice      = N'" & FormatSQL(z7360.CheckSupplierPrice) & "', " 
    SQL = SQL & "    K7360_seTax1      = N'" & FormatSQL(z7360.seTax1) & "', " 
    SQL = SQL & "    K7360_cdTax1      = N'" & FormatSQL(z7360.cdTax1) & "', " 
    SQL = SQL & "    K7360_seTax2      = N'" & FormatSQL(z7360.seTax2) & "', " 
    SQL = SQL & "    K7360_cdTax2      = N'" & FormatSQL(z7360.cdTax2) & "', " 
    SQL = SQL & "    K7360_seTax3      = N'" & FormatSQL(z7360.seTax3) & "', " 
    SQL = SQL & "    K7360_cdTax3      = N'" & FormatSQL(z7360.cdTax3) & "', " 
    SQL = SQL & "    K7360_DateComplete      = N'" & FormatSQL(z7360.DateComplete) & "', " 
    SQL = SQL & "    K7360_DateApproved      = N'" & FormatSQL(z7360.DateApproved) & "', " 
    SQL = SQL & "    K7360_DateCancel      = N'" & FormatSQL(z7360.DateCancel) & "', " 
    SQL = SQL & "    K7360_DatePending1      = N'" & FormatSQL(z7360.DatePending1) & "', " 
    SQL = SQL & "    K7360_DatePending2      = N'" & FormatSQL(z7360.DatePending2) & "', " 
    SQL = SQL & "    K7360_CheckUse      = N'" & FormatSQL(z7360.CheckUse) & "', " 
    SQL = SQL & "    K7360_Remark      = N'" & FormatSQL(z7360.Remark) & "'  " 
    SQL = SQL & " WHERE K7360_ContractID		 = '" & z7360.ContractID & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7360 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7360",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7360(z7360 As T7360_AREA) As Boolean
    DELETE_PFK7360 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7360 "
    SQL = SQL & " WHERE K7360_ContractID		 = '" & z7360.ContractID & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7360 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7360",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7360_CLEAR()
Try
    
   D7360.ContractID = ""
   D7360.DateAccept = ""
   D7360.CustomerCode = ""
   D7360.seSubProcess = ""
   D7360.cdSubProcess = ""
   D7360.CheckProcessType = ""
   D7360.CheckIOType = ""
   D7360.ContractNo = ""
   D7360.DateInsert = ""
   D7360.DateUpdate = ""
   D7360.InchargeInsert = ""
   D7360.InchargeUpdate = ""
   D7360.InchargePurchasing = ""
   D7360.CheckSupplierPrice = ""
   D7360.seTax1 = ""
   D7360.cdTax1 = ""
   D7360.seTax2 = ""
   D7360.cdTax2 = ""
   D7360.seTax3 = ""
   D7360.cdTax3 = ""
   D7360.DateComplete = ""
   D7360.DateApproved = ""
   D7360.DateCancel = ""
   D7360.DatePending1 = ""
   D7360.DatePending2 = ""
   D7360.CheckUse = ""
   D7360.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7360_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7360 As T7360_AREA)
Try
    
    x7360.ContractID = trim$(  x7360.ContractID)
    x7360.DateAccept = trim$(  x7360.DateAccept)
    x7360.CustomerCode = trim$(  x7360.CustomerCode)
    x7360.seSubProcess = trim$(  x7360.seSubProcess)
    x7360.cdSubProcess = trim$(  x7360.cdSubProcess)
    x7360.CheckProcessType = trim$(  x7360.CheckProcessType)
    x7360.CheckIOType = trim$(  x7360.CheckIOType)
    x7360.ContractNo = trim$(  x7360.ContractNo)
    x7360.DateInsert = trim$(  x7360.DateInsert)
    x7360.DateUpdate = trim$(  x7360.DateUpdate)
    x7360.InchargeInsert = trim$(  x7360.InchargeInsert)
    x7360.InchargeUpdate = trim$(  x7360.InchargeUpdate)
    x7360.InchargePurchasing = trim$(  x7360.InchargePurchasing)
    x7360.CheckSupplierPrice = trim$(  x7360.CheckSupplierPrice)
    x7360.seTax1 = trim$(  x7360.seTax1)
    x7360.cdTax1 = trim$(  x7360.cdTax1)
    x7360.seTax2 = trim$(  x7360.seTax2)
    x7360.cdTax2 = trim$(  x7360.cdTax2)
    x7360.seTax3 = trim$(  x7360.seTax3)
    x7360.cdTax3 = trim$(  x7360.cdTax3)
    x7360.DateComplete = trim$(  x7360.DateComplete)
    x7360.DateApproved = trim$(  x7360.DateApproved)
    x7360.DateCancel = trim$(  x7360.DateCancel)
    x7360.DatePending1 = trim$(  x7360.DatePending1)
    x7360.DatePending2 = trim$(  x7360.DatePending2)
    x7360.CheckUse = trim$(  x7360.CheckUse)
    x7360.Remark = trim$(  x7360.Remark)
     
    If trim$( x7360.ContractID ) = "" Then x7360.ContractID = Space(1) 
    If trim$( x7360.DateAccept ) = "" Then x7360.DateAccept = Space(1) 
    If trim$( x7360.CustomerCode ) = "" Then x7360.CustomerCode = Space(1) 
    If trim$( x7360.seSubProcess ) = "" Then x7360.seSubProcess = Space(1) 
    If trim$( x7360.cdSubProcess ) = "" Then x7360.cdSubProcess = Space(1) 
    If trim$( x7360.CheckProcessType ) = "" Then x7360.CheckProcessType = Space(1) 
    If trim$( x7360.CheckIOType ) = "" Then x7360.CheckIOType = Space(1) 
    If trim$( x7360.ContractNo ) = "" Then x7360.ContractNo = Space(1) 
    If trim$( x7360.DateInsert ) = "" Then x7360.DateInsert = Space(1) 
    If trim$( x7360.DateUpdate ) = "" Then x7360.DateUpdate = Space(1) 
    If trim$( x7360.InchargeInsert ) = "" Then x7360.InchargeInsert = Space(1) 
    If trim$( x7360.InchargeUpdate ) = "" Then x7360.InchargeUpdate = Space(1) 
    If trim$( x7360.InchargePurchasing ) = "" Then x7360.InchargePurchasing = Space(1) 
    If trim$( x7360.CheckSupplierPrice ) = "" Then x7360.CheckSupplierPrice = Space(1) 
    If trim$( x7360.seTax1 ) = "" Then x7360.seTax1 = Space(1) 
    If trim$( x7360.cdTax1 ) = "" Then x7360.cdTax1 = Space(1) 
    If trim$( x7360.seTax2 ) = "" Then x7360.seTax2 = Space(1) 
    If trim$( x7360.cdTax2 ) = "" Then x7360.cdTax2 = Space(1) 
    If trim$( x7360.seTax3 ) = "" Then x7360.seTax3 = Space(1) 
    If trim$( x7360.cdTax3 ) = "" Then x7360.cdTax3 = Space(1) 
    If trim$( x7360.DateComplete ) = "" Then x7360.DateComplete = Space(1) 
    If trim$( x7360.DateApproved ) = "" Then x7360.DateApproved = Space(1) 
    If trim$( x7360.DateCancel ) = "" Then x7360.DateCancel = Space(1) 
    If trim$( x7360.DatePending1 ) = "" Then x7360.DatePending1 = Space(1) 
    If trim$( x7360.DatePending2 ) = "" Then x7360.DatePending2 = Space(1) 
    If trim$( x7360.CheckUse ) = "" Then x7360.CheckUse = Space(1) 
    If trim$( x7360.Remark ) = "" Then x7360.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7360_MOVE(rs7360 As SqlClient.SqlDataReader)
Try

    call D7360_CLEAR()   

    If IsdbNull(rs7360!K7360_ContractID) = False Then D7360.ContractID = Trim$(rs7360!K7360_ContractID)
    If IsdbNull(rs7360!K7360_DateAccept) = False Then D7360.DateAccept = Trim$(rs7360!K7360_DateAccept)
    If IsdbNull(rs7360!K7360_CustomerCode) = False Then D7360.CustomerCode = Trim$(rs7360!K7360_CustomerCode)
    If IsdbNull(rs7360!K7360_seSubProcess) = False Then D7360.seSubProcess = Trim$(rs7360!K7360_seSubProcess)
    If IsdbNull(rs7360!K7360_cdSubProcess) = False Then D7360.cdSubProcess = Trim$(rs7360!K7360_cdSubProcess)
    If IsdbNull(rs7360!K7360_CheckProcessType) = False Then D7360.CheckProcessType = Trim$(rs7360!K7360_CheckProcessType)
    If IsdbNull(rs7360!K7360_CheckIOType) = False Then D7360.CheckIOType = Trim$(rs7360!K7360_CheckIOType)
    If IsdbNull(rs7360!K7360_ContractNo) = False Then D7360.ContractNo = Trim$(rs7360!K7360_ContractNo)
    If IsdbNull(rs7360!K7360_DateInsert) = False Then D7360.DateInsert = Trim$(rs7360!K7360_DateInsert)
    If IsdbNull(rs7360!K7360_DateUpdate) = False Then D7360.DateUpdate = Trim$(rs7360!K7360_DateUpdate)
    If IsdbNull(rs7360!K7360_InchargeInsert) = False Then D7360.InchargeInsert = Trim$(rs7360!K7360_InchargeInsert)
    If IsdbNull(rs7360!K7360_InchargeUpdate) = False Then D7360.InchargeUpdate = Trim$(rs7360!K7360_InchargeUpdate)
    If IsdbNull(rs7360!K7360_InchargePurchasing) = False Then D7360.InchargePurchasing = Trim$(rs7360!K7360_InchargePurchasing)
    If IsdbNull(rs7360!K7360_CheckSupplierPrice) = False Then D7360.CheckSupplierPrice = Trim$(rs7360!K7360_CheckSupplierPrice)
    If IsdbNull(rs7360!K7360_seTax1) = False Then D7360.seTax1 = Trim$(rs7360!K7360_seTax1)
    If IsdbNull(rs7360!K7360_cdTax1) = False Then D7360.cdTax1 = Trim$(rs7360!K7360_cdTax1)
    If IsdbNull(rs7360!K7360_seTax2) = False Then D7360.seTax2 = Trim$(rs7360!K7360_seTax2)
    If IsdbNull(rs7360!K7360_cdTax2) = False Then D7360.cdTax2 = Trim$(rs7360!K7360_cdTax2)
    If IsdbNull(rs7360!K7360_seTax3) = False Then D7360.seTax3 = Trim$(rs7360!K7360_seTax3)
    If IsdbNull(rs7360!K7360_cdTax3) = False Then D7360.cdTax3 = Trim$(rs7360!K7360_cdTax3)
    If IsdbNull(rs7360!K7360_DateComplete) = False Then D7360.DateComplete = Trim$(rs7360!K7360_DateComplete)
    If IsdbNull(rs7360!K7360_DateApproved) = False Then D7360.DateApproved = Trim$(rs7360!K7360_DateApproved)
    If IsdbNull(rs7360!K7360_DateCancel) = False Then D7360.DateCancel = Trim$(rs7360!K7360_DateCancel)
    If IsdbNull(rs7360!K7360_DatePending1) = False Then D7360.DatePending1 = Trim$(rs7360!K7360_DatePending1)
    If IsdbNull(rs7360!K7360_DatePending2) = False Then D7360.DatePending2 = Trim$(rs7360!K7360_DatePending2)
    If IsdbNull(rs7360!K7360_CheckUse) = False Then D7360.CheckUse = Trim$(rs7360!K7360_CheckUse)
    If IsdbNull(rs7360!K7360_Remark) = False Then D7360.Remark = Trim$(rs7360!K7360_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7360_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7360_MOVE(rs7360 As DataRow)
Try

    call D7360_CLEAR()   

    If IsdbNull(rs7360!K7360_ContractID) = False Then D7360.ContractID = Trim$(rs7360!K7360_ContractID)
    If IsdbNull(rs7360!K7360_DateAccept) = False Then D7360.DateAccept = Trim$(rs7360!K7360_DateAccept)
    If IsdbNull(rs7360!K7360_CustomerCode) = False Then D7360.CustomerCode = Trim$(rs7360!K7360_CustomerCode)
    If IsdbNull(rs7360!K7360_seSubProcess) = False Then D7360.seSubProcess = Trim$(rs7360!K7360_seSubProcess)
    If IsdbNull(rs7360!K7360_cdSubProcess) = False Then D7360.cdSubProcess = Trim$(rs7360!K7360_cdSubProcess)
    If IsdbNull(rs7360!K7360_CheckProcessType) = False Then D7360.CheckProcessType = Trim$(rs7360!K7360_CheckProcessType)
    If IsdbNull(rs7360!K7360_CheckIOType) = False Then D7360.CheckIOType = Trim$(rs7360!K7360_CheckIOType)
    If IsdbNull(rs7360!K7360_ContractNo) = False Then D7360.ContractNo = Trim$(rs7360!K7360_ContractNo)
    If IsdbNull(rs7360!K7360_DateInsert) = False Then D7360.DateInsert = Trim$(rs7360!K7360_DateInsert)
    If IsdbNull(rs7360!K7360_DateUpdate) = False Then D7360.DateUpdate = Trim$(rs7360!K7360_DateUpdate)
    If IsdbNull(rs7360!K7360_InchargeInsert) = False Then D7360.InchargeInsert = Trim$(rs7360!K7360_InchargeInsert)
    If IsdbNull(rs7360!K7360_InchargeUpdate) = False Then D7360.InchargeUpdate = Trim$(rs7360!K7360_InchargeUpdate)
    If IsdbNull(rs7360!K7360_InchargePurchasing) = False Then D7360.InchargePurchasing = Trim$(rs7360!K7360_InchargePurchasing)
    If IsdbNull(rs7360!K7360_CheckSupplierPrice) = False Then D7360.CheckSupplierPrice = Trim$(rs7360!K7360_CheckSupplierPrice)
    If IsdbNull(rs7360!K7360_seTax1) = False Then D7360.seTax1 = Trim$(rs7360!K7360_seTax1)
    If IsdbNull(rs7360!K7360_cdTax1) = False Then D7360.cdTax1 = Trim$(rs7360!K7360_cdTax1)
    If IsdbNull(rs7360!K7360_seTax2) = False Then D7360.seTax2 = Trim$(rs7360!K7360_seTax2)
    If IsdbNull(rs7360!K7360_cdTax2) = False Then D7360.cdTax2 = Trim$(rs7360!K7360_cdTax2)
    If IsdbNull(rs7360!K7360_seTax3) = False Then D7360.seTax3 = Trim$(rs7360!K7360_seTax3)
    If IsdbNull(rs7360!K7360_cdTax3) = False Then D7360.cdTax3 = Trim$(rs7360!K7360_cdTax3)
    If IsdbNull(rs7360!K7360_DateComplete) = False Then D7360.DateComplete = Trim$(rs7360!K7360_DateComplete)
    If IsdbNull(rs7360!K7360_DateApproved) = False Then D7360.DateApproved = Trim$(rs7360!K7360_DateApproved)
    If IsdbNull(rs7360!K7360_DateCancel) = False Then D7360.DateCancel = Trim$(rs7360!K7360_DateCancel)
    If IsdbNull(rs7360!K7360_DatePending1) = False Then D7360.DatePending1 = Trim$(rs7360!K7360_DatePending1)
    If IsdbNull(rs7360!K7360_DatePending2) = False Then D7360.DatePending2 = Trim$(rs7360!K7360_DatePending2)
    If IsdbNull(rs7360!K7360_CheckUse) = False Then D7360.CheckUse = Trim$(rs7360!K7360_CheckUse)
    If IsdbNull(rs7360!K7360_Remark) = False Then D7360.Remark = Trim$(rs7360!K7360_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7360_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7360_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7360 As T7360_AREA, CONTRACTID AS String) as Boolean

K7360_MOVE = False

Try
    If READ_PFK7360(CONTRACTID) = True Then
                z7360 = D7360
		K7360_MOVE = True
		else
	z7360 = nothing
     End If

     If  getColumIndex(spr,"ContractID") > -1 then z7360.ContractID = getDataM(spr, getColumIndex(spr,"ContractID"), xRow)
     If  getColumIndex(spr,"DateAccept") > -1 then z7360.DateAccept = getDataM(spr, getColumIndex(spr,"DateAccept"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z7360.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z7360.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z7360.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"CheckProcessType") > -1 then z7360.CheckProcessType = getDataM(spr, getColumIndex(spr,"CheckProcessType"), xRow)
     If  getColumIndex(spr,"CheckIOType") > -1 then z7360.CheckIOType = getDataM(spr, getColumIndex(spr,"CheckIOType"), xRow)
     If  getColumIndex(spr,"ContractNo") > -1 then z7360.ContractNo = getDataM(spr, getColumIndex(spr,"ContractNo"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7360.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7360.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7360.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7360.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"InchargePurchasing") > -1 then z7360.InchargePurchasing = getDataM(spr, getColumIndex(spr,"InchargePurchasing"), xRow)
     If  getColumIndex(spr,"CheckSupplierPrice") > -1 then z7360.CheckSupplierPrice = getDataM(spr, getColumIndex(spr,"CheckSupplierPrice"), xRow)
     If  getColumIndex(spr,"seTax1") > -1 then z7360.seTax1 = getDataM(spr, getColumIndex(spr,"seTax1"), xRow)
     If  getColumIndex(spr,"cdTax1") > -1 then z7360.cdTax1 = getDataM(spr, getColumIndex(spr,"cdTax1"), xRow)
     If  getColumIndex(spr,"seTax2") > -1 then z7360.seTax2 = getDataM(spr, getColumIndex(spr,"seTax2"), xRow)
     If  getColumIndex(spr,"cdTax2") > -1 then z7360.cdTax2 = getDataM(spr, getColumIndex(spr,"cdTax2"), xRow)
     If  getColumIndex(spr,"seTax3") > -1 then z7360.seTax3 = getDataM(spr, getColumIndex(spr,"seTax3"), xRow)
     If  getColumIndex(spr,"cdTax3") > -1 then z7360.cdTax3 = getDataM(spr, getColumIndex(spr,"cdTax3"), xRow)
     If  getColumIndex(spr,"DateComplete") > -1 then z7360.DateComplete = getDataM(spr, getColumIndex(spr,"DateComplete"), xRow)
     If  getColumIndex(spr,"DateApproved") > -1 then z7360.DateApproved = getDataM(spr, getColumIndex(spr,"DateApproved"), xRow)
     If  getColumIndex(spr,"DateCancel") > -1 then z7360.DateCancel = getDataM(spr, getColumIndex(spr,"DateCancel"), xRow)
     If  getColumIndex(spr,"DatePending1") > -1 then z7360.DatePending1 = getDataM(spr, getColumIndex(spr,"DatePending1"), xRow)
     If  getColumIndex(spr,"DatePending2") > -1 then z7360.DatePending2 = getDataM(spr, getColumIndex(spr,"DatePending2"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7360.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7360.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7360_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7360_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7360 As T7360_AREA,CheckClear as Boolean,CONTRACTID AS String) as Boolean

K7360_MOVE = False

Try
    If READ_PFK7360(CONTRACTID) = True Then
                z7360 = D7360
		K7360_MOVE = True
		else
	If CheckClear  = True then z7360 = nothing
     End If

     If  getColumIndex(spr,"ContractID") > -1 then z7360.ContractID = getDataM(spr, getColumIndex(spr,"ContractID"), xRow)
     If  getColumIndex(spr,"DateAccept") > -1 then z7360.DateAccept = getDataM(spr, getColumIndex(spr,"DateAccept"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z7360.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z7360.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z7360.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"CheckProcessType") > -1 then z7360.CheckProcessType = getDataM(spr, getColumIndex(spr,"CheckProcessType"), xRow)
     If  getColumIndex(spr,"CheckIOType") > -1 then z7360.CheckIOType = getDataM(spr, getColumIndex(spr,"CheckIOType"), xRow)
     If  getColumIndex(spr,"ContractNo") > -1 then z7360.ContractNo = getDataM(spr, getColumIndex(spr,"ContractNo"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7360.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7360.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7360.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7360.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"InchargePurchasing") > -1 then z7360.InchargePurchasing = getDataM(spr, getColumIndex(spr,"InchargePurchasing"), xRow)
     If  getColumIndex(spr,"CheckSupplierPrice") > -1 then z7360.CheckSupplierPrice = getDataM(spr, getColumIndex(spr,"CheckSupplierPrice"), xRow)
     If  getColumIndex(spr,"seTax1") > -1 then z7360.seTax1 = getDataM(spr, getColumIndex(spr,"seTax1"), xRow)
     If  getColumIndex(spr,"cdTax1") > -1 then z7360.cdTax1 = getDataM(spr, getColumIndex(spr,"cdTax1"), xRow)
     If  getColumIndex(spr,"seTax2") > -1 then z7360.seTax2 = getDataM(spr, getColumIndex(spr,"seTax2"), xRow)
     If  getColumIndex(spr,"cdTax2") > -1 then z7360.cdTax2 = getDataM(spr, getColumIndex(spr,"cdTax2"), xRow)
     If  getColumIndex(spr,"seTax3") > -1 then z7360.seTax3 = getDataM(spr, getColumIndex(spr,"seTax3"), xRow)
     If  getColumIndex(spr,"cdTax3") > -1 then z7360.cdTax3 = getDataM(spr, getColumIndex(spr,"cdTax3"), xRow)
     If  getColumIndex(spr,"DateComplete") > -1 then z7360.DateComplete = getDataM(spr, getColumIndex(spr,"DateComplete"), xRow)
     If  getColumIndex(spr,"DateApproved") > -1 then z7360.DateApproved = getDataM(spr, getColumIndex(spr,"DateApproved"), xRow)
     If  getColumIndex(spr,"DateCancel") > -1 then z7360.DateCancel = getDataM(spr, getColumIndex(spr,"DateCancel"), xRow)
     If  getColumIndex(spr,"DatePending1") > -1 then z7360.DatePending1 = getDataM(spr, getColumIndex(spr,"DatePending1"), xRow)
     If  getColumIndex(spr,"DatePending2") > -1 then z7360.DatePending2 = getDataM(spr, getColumIndex(spr,"DatePending2"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7360.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7360.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7360_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7360_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7360 As T7360_AREA, Job as String, CONTRACTID AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7360_MOVE = False

Try
    If READ_PFK7360(CONTRACTID) = True Then
                z7360 = D7360
		K7360_MOVE = True
		else
	z7360 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7360")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "CONTRACTID":z7360.ContractID = Children(i).Code
   Case "DATEACCEPT":z7360.DateAccept = Children(i).Code
   Case "CUSTOMERCODE":z7360.CustomerCode = Children(i).Code
   Case "SESUBPROCESS":z7360.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z7360.cdSubProcess = Children(i).Code
   Case "CHECKPROCESSTYPE":z7360.CheckProcessType = Children(i).Code
   Case "CHECKIOTYPE":z7360.CheckIOType = Children(i).Code
   Case "CONTRACTNO":z7360.ContractNo = Children(i).Code
   Case "DATEINSERT":z7360.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7360.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7360.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7360.InchargeUpdate = Children(i).Code
   Case "INCHARGEPURCHASING":z7360.InchargePurchasing = Children(i).Code
   Case "CHECKSUPPLIERPRICE":z7360.CheckSupplierPrice = Children(i).Code
   Case "SETAX1":z7360.seTax1 = Children(i).Code
   Case "CDTAX1":z7360.cdTax1 = Children(i).Code
   Case "SETAX2":z7360.seTax2 = Children(i).Code
   Case "CDTAX2":z7360.cdTax2 = Children(i).Code
   Case "SETAX3":z7360.seTax3 = Children(i).Code
   Case "CDTAX3":z7360.cdTax3 = Children(i).Code
   Case "DATECOMPLETE":z7360.DateComplete = Children(i).Code
   Case "DATEAPPROVED":z7360.DateApproved = Children(i).Code
   Case "DATECANCEL":z7360.DateCancel = Children(i).Code
   Case "DATEPENDING1":z7360.DatePending1 = Children(i).Code
   Case "DATEPENDING2":z7360.DatePending2 = Children(i).Code
   Case "CHECKUSE":z7360.CheckUse = Children(i).Code
   Case "REMARK":z7360.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "CONTRACTID":z7360.ContractID = Children(i).Data
   Case "DATEACCEPT":z7360.DateAccept = Children(i).Data
   Case "CUSTOMERCODE":z7360.CustomerCode = Children(i).Data
   Case "SESUBPROCESS":z7360.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z7360.cdSubProcess = Children(i).Data
   Case "CHECKPROCESSTYPE":z7360.CheckProcessType = Children(i).Data
   Case "CHECKIOTYPE":z7360.CheckIOType = Children(i).Data
   Case "CONTRACTNO":z7360.ContractNo = Children(i).Data
   Case "DATEINSERT":z7360.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7360.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7360.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7360.InchargeUpdate = Children(i).Data
   Case "INCHARGEPURCHASING":z7360.InchargePurchasing = Children(i).Data
   Case "CHECKSUPPLIERPRICE":z7360.CheckSupplierPrice = Children(i).Data
   Case "SETAX1":z7360.seTax1 = Children(i).Data
   Case "CDTAX1":z7360.cdTax1 = Children(i).Data
   Case "SETAX2":z7360.seTax2 = Children(i).Data
   Case "CDTAX2":z7360.cdTax2 = Children(i).Data
   Case "SETAX3":z7360.seTax3 = Children(i).Data
   Case "CDTAX3":z7360.cdTax3 = Children(i).Data
   Case "DATECOMPLETE":z7360.DateComplete = Children(i).Data
   Case "DATEAPPROVED":z7360.DateApproved = Children(i).Data
   Case "DATECANCEL":z7360.DateCancel = Children(i).Data
   Case "DATEPENDING1":z7360.DatePending1 = Children(i).Data
   Case "DATEPENDING2":z7360.DatePending2 = Children(i).Data
   Case "CHECKUSE":z7360.CheckUse = Children(i).Data
   Case "REMARK":z7360.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7360_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7360_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7360 As T7360_AREA, Job as String, CheckClear as Boolean, CONTRACTID AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7360_MOVE = False

Try
    If READ_PFK7360(CONTRACTID) = True Then
                z7360 = D7360
		K7360_MOVE = True
		else
	If CheckClear  = True then z7360 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7360")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "CONTRACTID":z7360.ContractID = Children(i).Code
   Case "DATEACCEPT":z7360.DateAccept = Children(i).Code
   Case "CUSTOMERCODE":z7360.CustomerCode = Children(i).Code
   Case "SESUBPROCESS":z7360.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z7360.cdSubProcess = Children(i).Code
   Case "CHECKPROCESSTYPE":z7360.CheckProcessType = Children(i).Code
   Case "CHECKIOTYPE":z7360.CheckIOType = Children(i).Code
   Case "CONTRACTNO":z7360.ContractNo = Children(i).Code
   Case "DATEINSERT":z7360.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7360.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7360.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7360.InchargeUpdate = Children(i).Code
   Case "INCHARGEPURCHASING":z7360.InchargePurchasing = Children(i).Code
   Case "CHECKSUPPLIERPRICE":z7360.CheckSupplierPrice = Children(i).Code
   Case "SETAX1":z7360.seTax1 = Children(i).Code
   Case "CDTAX1":z7360.cdTax1 = Children(i).Code
   Case "SETAX2":z7360.seTax2 = Children(i).Code
   Case "CDTAX2":z7360.cdTax2 = Children(i).Code
   Case "SETAX3":z7360.seTax3 = Children(i).Code
   Case "CDTAX3":z7360.cdTax3 = Children(i).Code
   Case "DATECOMPLETE":z7360.DateComplete = Children(i).Code
   Case "DATEAPPROVED":z7360.DateApproved = Children(i).Code
   Case "DATECANCEL":z7360.DateCancel = Children(i).Code
   Case "DATEPENDING1":z7360.DatePending1 = Children(i).Code
   Case "DATEPENDING2":z7360.DatePending2 = Children(i).Code
   Case "CHECKUSE":z7360.CheckUse = Children(i).Code
   Case "REMARK":z7360.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "CONTRACTID":z7360.ContractID = Children(i).Data
   Case "DATEACCEPT":z7360.DateAccept = Children(i).Data
   Case "CUSTOMERCODE":z7360.CustomerCode = Children(i).Data
   Case "SESUBPROCESS":z7360.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z7360.cdSubProcess = Children(i).Data
   Case "CHECKPROCESSTYPE":z7360.CheckProcessType = Children(i).Data
   Case "CHECKIOTYPE":z7360.CheckIOType = Children(i).Data
   Case "CONTRACTNO":z7360.ContractNo = Children(i).Data
   Case "DATEINSERT":z7360.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7360.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7360.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7360.InchargeUpdate = Children(i).Data
   Case "INCHARGEPURCHASING":z7360.InchargePurchasing = Children(i).Data
   Case "CHECKSUPPLIERPRICE":z7360.CheckSupplierPrice = Children(i).Data
   Case "SETAX1":z7360.seTax1 = Children(i).Data
   Case "CDTAX1":z7360.cdTax1 = Children(i).Data
   Case "SETAX2":z7360.seTax2 = Children(i).Data
   Case "CDTAX2":z7360.cdTax2 = Children(i).Data
   Case "SETAX3":z7360.seTax3 = Children(i).Data
   Case "CDTAX3":z7360.cdTax3 = Children(i).Data
   Case "DATECOMPLETE":z7360.DateComplete = Children(i).Data
   Case "DATEAPPROVED":z7360.DateApproved = Children(i).Data
   Case "DATECANCEL":z7360.DateCancel = Children(i).Data
   Case "DATEPENDING1":z7360.DatePending1 = Children(i).Data
   Case "DATEPENDING2":z7360.DatePending2 = Children(i).Data
   Case "CHECKUSE":z7360.CheckUse = Children(i).Data
   Case "REMARK":z7360.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7360_MOVE",vbCritical)
End Try
End Function 
    
End Module 
