'=========================================================================================================================================================
'   TABLE : (PFK1320)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K1320

Structure T1320_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	TestOrder	 AS String	'			char(9)		*
Public 	seSite	 AS String	'			char(3)
Public 	cdSite	 AS String	'			char(3)
Public 	CustomerCode	 AS String	'			char(6)
Public 	TotalQty	 AS Double	'			decimal
Public 	Incharge	 AS String	'			char(8)
Public 	DateTest	 AS String	'			char(8)
Public 	DateDelivery	 AS String	'			char(8)
Public 	InsertDate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	UpdateDate	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	TestStatus	 AS String	'			char(1)
Public 	DateApproval	 AS String	'			char(8)
Public 	DateCancel	 AS String	'			char(8)
Public 	DateComplete	 AS String	'			char(8)
Public 	DatePending	 AS String	'			char(8)
Public 	Remark	 AS String	'			nvarchar(500)
'=========================================================================================================================================================
End structure

Public D1320 As T1320_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK1320(TESTORDER AS String) As Boolean
    READ_PFK1320 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK1320 "
    SQL = SQL & " WHERE K1320_TestOrder		 = '" & TestOrder & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D1320_CLEAR: GoTo SKIP_READ_PFK1320
                
    Call K1320_MOVE(rd)
    READ_PFK1320 = True

SKIP_READ_PFK1320:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK1320",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK1320(TESTORDER AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK1320 "
    SQL = SQL & " WHERE K1320_TestOrder		 = '" & TestOrder & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK1320",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK1320(z1320 As T1320_AREA) As Boolean
    WRITE_PFK1320 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z1320)
 
    SQL = " INSERT INTO PFK1320 "
    SQL = SQL & " ( "
    SQL = SQL & " K1320_TestOrder," 
    SQL = SQL & " K1320_seSite," 
    SQL = SQL & " K1320_cdSite," 
    SQL = SQL & " K1320_CustomerCode," 
    SQL = SQL & " K1320_TotalQty," 
    SQL = SQL & " K1320_Incharge," 
    SQL = SQL & " K1320_DateTest," 
    SQL = SQL & " K1320_DateDelivery," 
    SQL = SQL & " K1320_InsertDate," 
    SQL = SQL & " K1320_InchargeInsert," 
    SQL = SQL & " K1320_UpdateDate," 
    SQL = SQL & " K1320_InchargeUpdate," 
    SQL = SQL & " K1320_TestStatus," 
    SQL = SQL & " K1320_DateApproval," 
    SQL = SQL & " K1320_DateCancel," 
    SQL = SQL & " K1320_DateComplete," 
    SQL = SQL & " K1320_DatePending," 
    SQL = SQL & " K1320_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z1320.TestOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1320.seSite) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1320.cdSite) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1320.CustomerCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z1320.TotalQty) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z1320.Incharge) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1320.DateTest) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1320.DateDelivery) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1320.InsertDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1320.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1320.UpdateDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1320.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1320.TestStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1320.DateApproval) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1320.DateCancel) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1320.DateComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1320.DatePending) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1320.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK1320 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK1320",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK1320(z1320 As T1320_AREA) As Boolean
    REWRITE_PFK1320 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z1320)
   
    SQL = " UPDATE PFK1320 SET "
    SQL = SQL & "    K1320_seSite      = N'" & FormatSQL(z1320.seSite) & "', " 
    SQL = SQL & "    K1320_cdSite      = N'" & FormatSQL(z1320.cdSite) & "', " 
    SQL = SQL & "    K1320_CustomerCode      = N'" & FormatSQL(z1320.CustomerCode) & "', " 
    SQL = SQL & "    K1320_TotalQty      =  " & FormatSQL(z1320.TotalQty) & ", " 
    SQL = SQL & "    K1320_Incharge      = N'" & FormatSQL(z1320.Incharge) & "', " 
    SQL = SQL & "    K1320_DateTest      = N'" & FormatSQL(z1320.DateTest) & "', " 
    SQL = SQL & "    K1320_DateDelivery      = N'" & FormatSQL(z1320.DateDelivery) & "', " 
    SQL = SQL & "    K1320_InsertDate      = N'" & FormatSQL(z1320.InsertDate) & "', " 
    SQL = SQL & "    K1320_InchargeInsert      = N'" & FormatSQL(z1320.InchargeInsert) & "', " 
    SQL = SQL & "    K1320_UpdateDate      = N'" & FormatSQL(z1320.UpdateDate) & "', " 
    SQL = SQL & "    K1320_InchargeUpdate      = N'" & FormatSQL(z1320.InchargeUpdate) & "', " 
    SQL = SQL & "    K1320_TestStatus      = N'" & FormatSQL(z1320.TestStatus) & "', " 
    SQL = SQL & "    K1320_DateApproval      = N'" & FormatSQL(z1320.DateApproval) & "', " 
    SQL = SQL & "    K1320_DateCancel      = N'" & FormatSQL(z1320.DateCancel) & "', " 
    SQL = SQL & "    K1320_DateComplete      = N'" & FormatSQL(z1320.DateComplete) & "', " 
    SQL = SQL & "    K1320_DatePending      = N'" & FormatSQL(z1320.DatePending) & "', " 
    SQL = SQL & "    K1320_Remark      = N'" & FormatSQL(z1320.Remark) & "'  " 
    SQL = SQL & " WHERE K1320_TestOrder		 = '" & z1320.TestOrder & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK1320 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK1320",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK1320(z1320 As T1320_AREA) As Boolean
    DELETE_PFK1320 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK1320 "
    SQL = SQL & " WHERE K1320_TestOrder		 = '" & z1320.TestOrder & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK1320 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK1320",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D1320_CLEAR()
Try
    
   D1320.TestOrder = ""
   D1320.seSite = ""
   D1320.cdSite = ""
   D1320.CustomerCode = ""
    D1320.TotalQty = 0 
   D1320.Incharge = ""
   D1320.DateTest = ""
   D1320.DateDelivery = ""
   D1320.InsertDate = ""
   D1320.InchargeInsert = ""
   D1320.UpdateDate = ""
   D1320.InchargeUpdate = ""
   D1320.TestStatus = ""
   D1320.DateApproval = ""
   D1320.DateCancel = ""
   D1320.DateComplete = ""
   D1320.DatePending = ""
   D1320.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D1320_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x1320 As T1320_AREA)
Try
    
    x1320.TestOrder = trim$(  x1320.TestOrder)
    x1320.seSite = trim$(  x1320.seSite)
    x1320.cdSite = trim$(  x1320.cdSite)
    x1320.CustomerCode = trim$(  x1320.CustomerCode)
    x1320.TotalQty = trim$(  x1320.TotalQty)
    x1320.Incharge = trim$(  x1320.Incharge)
    x1320.DateTest = trim$(  x1320.DateTest)
    x1320.DateDelivery = trim$(  x1320.DateDelivery)
    x1320.InsertDate = trim$(  x1320.InsertDate)
    x1320.InchargeInsert = trim$(  x1320.InchargeInsert)
    x1320.UpdateDate = trim$(  x1320.UpdateDate)
    x1320.InchargeUpdate = trim$(  x1320.InchargeUpdate)
    x1320.TestStatus = trim$(  x1320.TestStatus)
    x1320.DateApproval = trim$(  x1320.DateApproval)
    x1320.DateCancel = trim$(  x1320.DateCancel)
    x1320.DateComplete = trim$(  x1320.DateComplete)
    x1320.DatePending = trim$(  x1320.DatePending)
    x1320.Remark = trim$(  x1320.Remark)
     
    If trim$( x1320.TestOrder ) = "" Then x1320.TestOrder = Space(1) 
    If trim$( x1320.seSite ) = "" Then x1320.seSite = Space(1) 
    If trim$( x1320.cdSite ) = "" Then x1320.cdSite = Space(1) 
    If trim$( x1320.CustomerCode ) = "" Then x1320.CustomerCode = Space(1) 
    If trim$( x1320.TotalQty ) = "" Then x1320.TotalQty = 0 
    If trim$( x1320.Incharge ) = "" Then x1320.Incharge = Space(1) 
    If trim$( x1320.DateTest ) = "" Then x1320.DateTest = Space(1) 
    If trim$( x1320.DateDelivery ) = "" Then x1320.DateDelivery = Space(1) 
    If trim$( x1320.InsertDate ) = "" Then x1320.InsertDate = Space(1) 
    If trim$( x1320.InchargeInsert ) = "" Then x1320.InchargeInsert = Space(1) 
    If trim$( x1320.UpdateDate ) = "" Then x1320.UpdateDate = Space(1) 
    If trim$( x1320.InchargeUpdate ) = "" Then x1320.InchargeUpdate = Space(1) 
    If trim$( x1320.TestStatus ) = "" Then x1320.TestStatus = Space(1) 
    If trim$( x1320.DateApproval ) = "" Then x1320.DateApproval = Space(1) 
    If trim$( x1320.DateCancel ) = "" Then x1320.DateCancel = Space(1) 
    If trim$( x1320.DateComplete ) = "" Then x1320.DateComplete = Space(1) 
    If trim$( x1320.DatePending ) = "" Then x1320.DatePending = Space(1) 
    If trim$( x1320.Remark ) = "" Then x1320.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K1320_MOVE(rs1320 As SqlClient.SqlDataReader)
Try

    call D1320_CLEAR()   

    If IsdbNull(rs1320!K1320_TestOrder) = False Then D1320.TestOrder = Trim$(rs1320!K1320_TestOrder)
    If IsdbNull(rs1320!K1320_seSite) = False Then D1320.seSite = Trim$(rs1320!K1320_seSite)
    If IsdbNull(rs1320!K1320_cdSite) = False Then D1320.cdSite = Trim$(rs1320!K1320_cdSite)
    If IsdbNull(rs1320!K1320_CustomerCode) = False Then D1320.CustomerCode = Trim$(rs1320!K1320_CustomerCode)
    If IsdbNull(rs1320!K1320_TotalQty) = False Then D1320.TotalQty = Trim$(rs1320!K1320_TotalQty)
    If IsdbNull(rs1320!K1320_Incharge) = False Then D1320.Incharge = Trim$(rs1320!K1320_Incharge)
    If IsdbNull(rs1320!K1320_DateTest) = False Then D1320.DateTest = Trim$(rs1320!K1320_DateTest)
    If IsdbNull(rs1320!K1320_DateDelivery) = False Then D1320.DateDelivery = Trim$(rs1320!K1320_DateDelivery)
    If IsdbNull(rs1320!K1320_InsertDate) = False Then D1320.InsertDate = Trim$(rs1320!K1320_InsertDate)
    If IsdbNull(rs1320!K1320_InchargeInsert) = False Then D1320.InchargeInsert = Trim$(rs1320!K1320_InchargeInsert)
    If IsdbNull(rs1320!K1320_UpdateDate) = False Then D1320.UpdateDate = Trim$(rs1320!K1320_UpdateDate)
    If IsdbNull(rs1320!K1320_InchargeUpdate) = False Then D1320.InchargeUpdate = Trim$(rs1320!K1320_InchargeUpdate)
    If IsdbNull(rs1320!K1320_TestStatus) = False Then D1320.TestStatus = Trim$(rs1320!K1320_TestStatus)
    If IsdbNull(rs1320!K1320_DateApproval) = False Then D1320.DateApproval = Trim$(rs1320!K1320_DateApproval)
    If IsdbNull(rs1320!K1320_DateCancel) = False Then D1320.DateCancel = Trim$(rs1320!K1320_DateCancel)
    If IsdbNull(rs1320!K1320_DateComplete) = False Then D1320.DateComplete = Trim$(rs1320!K1320_DateComplete)
    If IsdbNull(rs1320!K1320_DatePending) = False Then D1320.DatePending = Trim$(rs1320!K1320_DatePending)
    If IsdbNull(rs1320!K1320_Remark) = False Then D1320.Remark = Trim$(rs1320!K1320_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K1320_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K1320_MOVE(rs1320 As DataRow)
Try

    call D1320_CLEAR()   

    If IsdbNull(rs1320!K1320_TestOrder) = False Then D1320.TestOrder = Trim$(rs1320!K1320_TestOrder)
    If IsdbNull(rs1320!K1320_seSite) = False Then D1320.seSite = Trim$(rs1320!K1320_seSite)
    If IsdbNull(rs1320!K1320_cdSite) = False Then D1320.cdSite = Trim$(rs1320!K1320_cdSite)
    If IsdbNull(rs1320!K1320_CustomerCode) = False Then D1320.CustomerCode = Trim$(rs1320!K1320_CustomerCode)
    If IsdbNull(rs1320!K1320_TotalQty) = False Then D1320.TotalQty = Trim$(rs1320!K1320_TotalQty)
    If IsdbNull(rs1320!K1320_Incharge) = False Then D1320.Incharge = Trim$(rs1320!K1320_Incharge)
    If IsdbNull(rs1320!K1320_DateTest) = False Then D1320.DateTest = Trim$(rs1320!K1320_DateTest)
    If IsdbNull(rs1320!K1320_DateDelivery) = False Then D1320.DateDelivery = Trim$(rs1320!K1320_DateDelivery)
    If IsdbNull(rs1320!K1320_InsertDate) = False Then D1320.InsertDate = Trim$(rs1320!K1320_InsertDate)
    If IsdbNull(rs1320!K1320_InchargeInsert) = False Then D1320.InchargeInsert = Trim$(rs1320!K1320_InchargeInsert)
    If IsdbNull(rs1320!K1320_UpdateDate) = False Then D1320.UpdateDate = Trim$(rs1320!K1320_UpdateDate)
    If IsdbNull(rs1320!K1320_InchargeUpdate) = False Then D1320.InchargeUpdate = Trim$(rs1320!K1320_InchargeUpdate)
    If IsdbNull(rs1320!K1320_TestStatus) = False Then D1320.TestStatus = Trim$(rs1320!K1320_TestStatus)
    If IsdbNull(rs1320!K1320_DateApproval) = False Then D1320.DateApproval = Trim$(rs1320!K1320_DateApproval)
    If IsdbNull(rs1320!K1320_DateCancel) = False Then D1320.DateCancel = Trim$(rs1320!K1320_DateCancel)
    If IsdbNull(rs1320!K1320_DateComplete) = False Then D1320.DateComplete = Trim$(rs1320!K1320_DateComplete)
    If IsdbNull(rs1320!K1320_DatePending) = False Then D1320.DatePending = Trim$(rs1320!K1320_DatePending)
    If IsdbNull(rs1320!K1320_Remark) = False Then D1320.Remark = Trim$(rs1320!K1320_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K1320_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K1320_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z1320 As T1320_AREA, TESTORDER AS String) as Boolean

K1320_MOVE = False

Try
    If READ_PFK1320(TESTORDER) = True Then
                z1320 = D1320
		K1320_MOVE = True
		else
	z1320 = nothing
     End If

     If  getColumIndex(spr,"TestOrder") > -1 then z1320.TestOrder = getDataM(spr, getColumIndex(spr,"TestOrder"), xRow)
     If  getColumIndex(spr,"seSite") > -1 then z1320.seSite = getDataM(spr, getColumIndex(spr,"seSite"), xRow)
     If  getColumIndex(spr,"cdSite") > -1 then z1320.cdSite = getDataM(spr, getColumIndex(spr,"cdSite"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z1320.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"TotalQty") > -1 then z1320.TotalQty = getDataM(spr, getColumIndex(spr,"TotalQty"), xRow)
     If  getColumIndex(spr,"Incharge") > -1 then z1320.Incharge = getDataM(spr, getColumIndex(spr,"Incharge"), xRow)
     If  getColumIndex(spr,"DateTest") > -1 then z1320.DateTest = getDataM(spr, getColumIndex(spr,"DateTest"), xRow)
     If  getColumIndex(spr,"DateDelivery") > -1 then z1320.DateDelivery = getDataM(spr, getColumIndex(spr,"DateDelivery"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z1320.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z1320.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z1320.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z1320.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"TestStatus") > -1 then z1320.TestStatus = getDataM(spr, getColumIndex(spr,"TestStatus"), xRow)
     If  getColumIndex(spr,"DateApproval") > -1 then z1320.DateApproval = getDataM(spr, getColumIndex(spr,"DateApproval"), xRow)
     If  getColumIndex(spr,"DateCancel") > -1 then z1320.DateCancel = getDataM(spr, getColumIndex(spr,"DateCancel"), xRow)
     If  getColumIndex(spr,"DateComplete") > -1 then z1320.DateComplete = getDataM(spr, getColumIndex(spr,"DateComplete"), xRow)
     If  getColumIndex(spr,"DatePending") > -1 then z1320.DatePending = getDataM(spr, getColumIndex(spr,"DatePending"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z1320.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K1320_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K1320_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z1320 As T1320_AREA,CheckClear as Boolean,TESTORDER AS String) as Boolean

K1320_MOVE = False

Try
    If READ_PFK1320(TESTORDER) = True Then
                z1320 = D1320
		K1320_MOVE = True
		else
	If CheckClear  = True then z1320 = nothing
     End If

     If  getColumIndex(spr,"TestOrder") > -1 then z1320.TestOrder = getDataM(spr, getColumIndex(spr,"TestOrder"), xRow)
     If  getColumIndex(spr,"seSite") > -1 then z1320.seSite = getDataM(spr, getColumIndex(spr,"seSite"), xRow)
     If  getColumIndex(spr,"cdSite") > -1 then z1320.cdSite = getDataM(spr, getColumIndex(spr,"cdSite"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z1320.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"TotalQty") > -1 then z1320.TotalQty = getDataM(spr, getColumIndex(spr,"TotalQty"), xRow)
     If  getColumIndex(spr,"Incharge") > -1 then z1320.Incharge = getDataM(spr, getColumIndex(spr,"Incharge"), xRow)
     If  getColumIndex(spr,"DateTest") > -1 then z1320.DateTest = getDataM(spr, getColumIndex(spr,"DateTest"), xRow)
     If  getColumIndex(spr,"DateDelivery") > -1 then z1320.DateDelivery = getDataM(spr, getColumIndex(spr,"DateDelivery"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z1320.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z1320.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z1320.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z1320.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"TestStatus") > -1 then z1320.TestStatus = getDataM(spr, getColumIndex(spr,"TestStatus"), xRow)
     If  getColumIndex(spr,"DateApproval") > -1 then z1320.DateApproval = getDataM(spr, getColumIndex(spr,"DateApproval"), xRow)
     If  getColumIndex(spr,"DateCancel") > -1 then z1320.DateCancel = getDataM(spr, getColumIndex(spr,"DateCancel"), xRow)
     If  getColumIndex(spr,"DateComplete") > -1 then z1320.DateComplete = getDataM(spr, getColumIndex(spr,"DateComplete"), xRow)
     If  getColumIndex(spr,"DatePending") > -1 then z1320.DatePending = getDataM(spr, getColumIndex(spr,"DatePending"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z1320.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K1320_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K1320_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z1320 As T1320_AREA, Job as String, TESTORDER AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K1320_MOVE = False

Try
    If READ_PFK1320(TESTORDER) = True Then
                z1320 = D1320
		K1320_MOVE = True
		else
	z1320 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1320")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "TESTORDER":z1320.TestOrder = Children(i).Code
   Case "SESITE":z1320.seSite = Children(i).Code
   Case "CDSITE":z1320.cdSite = Children(i).Code
   Case "CUSTOMERCODE":z1320.CustomerCode = Children(i).Code
   Case "TOTALQTY":z1320.TotalQty = Children(i).Code
   Case "INCHARGE":z1320.Incharge = Children(i).Code
   Case "DATETEST":z1320.DateTest = Children(i).Code
   Case "DATEDELIVERY":z1320.DateDelivery = Children(i).Code
   Case "INSERTDATE":z1320.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z1320.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z1320.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z1320.InchargeUpdate = Children(i).Code
   Case "TESTSTATUS":z1320.TestStatus = Children(i).Code
   Case "DATEAPPROVAL":z1320.DateApproval = Children(i).Code
   Case "DATECANCEL":z1320.DateCancel = Children(i).Code
   Case "DATECOMPLETE":z1320.DateComplete = Children(i).Code
   Case "DATEPENDING":z1320.DatePending = Children(i).Code
   Case "REMARK":z1320.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "TESTORDER":z1320.TestOrder = Children(i).Data
   Case "SESITE":z1320.seSite = Children(i).Data
   Case "CDSITE":z1320.cdSite = Children(i).Data
   Case "CUSTOMERCODE":z1320.CustomerCode = Children(i).Data
   Case "TOTALQTY":z1320.TotalQty = Children(i).Data
   Case "INCHARGE":z1320.Incharge = Children(i).Data
   Case "DATETEST":z1320.DateTest = Children(i).Data
   Case "DATEDELIVERY":z1320.DateDelivery = Children(i).Data
   Case "INSERTDATE":z1320.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z1320.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z1320.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z1320.InchargeUpdate = Children(i).Data
   Case "TESTSTATUS":z1320.TestStatus = Children(i).Data
   Case "DATEAPPROVAL":z1320.DateApproval = Children(i).Data
   Case "DATECANCEL":z1320.DateCancel = Children(i).Data
   Case "DATECOMPLETE":z1320.DateComplete = Children(i).Data
   Case "DATEPENDING":z1320.DatePending = Children(i).Data
   Case "REMARK":z1320.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K1320_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K1320_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z1320 As T1320_AREA, Job as String, CheckClear as Boolean, TESTORDER AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K1320_MOVE = False

Try
    If READ_PFK1320(TESTORDER) = True Then
                z1320 = D1320
		K1320_MOVE = True
		else
	If CheckClear  = True then z1320 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1320")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "TESTORDER":z1320.TestOrder = Children(i).Code
   Case "SESITE":z1320.seSite = Children(i).Code
   Case "CDSITE":z1320.cdSite = Children(i).Code
   Case "CUSTOMERCODE":z1320.CustomerCode = Children(i).Code
   Case "TOTALQTY":z1320.TotalQty = Children(i).Code
   Case "INCHARGE":z1320.Incharge = Children(i).Code
   Case "DATETEST":z1320.DateTest = Children(i).Code
   Case "DATEDELIVERY":z1320.DateDelivery = Children(i).Code
   Case "INSERTDATE":z1320.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z1320.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z1320.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z1320.InchargeUpdate = Children(i).Code
   Case "TESTSTATUS":z1320.TestStatus = Children(i).Code
   Case "DATEAPPROVAL":z1320.DateApproval = Children(i).Code
   Case "DATECANCEL":z1320.DateCancel = Children(i).Code
   Case "DATECOMPLETE":z1320.DateComplete = Children(i).Code
   Case "DATEPENDING":z1320.DatePending = Children(i).Code
   Case "REMARK":z1320.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "TESTORDER":z1320.TestOrder = Children(i).Data
   Case "SESITE":z1320.seSite = Children(i).Data
   Case "CDSITE":z1320.cdSite = Children(i).Data
   Case "CUSTOMERCODE":z1320.CustomerCode = Children(i).Data
   Case "TOTALQTY":z1320.TotalQty = Children(i).Data
   Case "INCHARGE":z1320.Incharge = Children(i).Data
   Case "DATETEST":z1320.DateTest = Children(i).Data
   Case "DATEDELIVERY":z1320.DateDelivery = Children(i).Data
   Case "INSERTDATE":z1320.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z1320.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z1320.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z1320.InchargeUpdate = Children(i).Data
   Case "TESTSTATUS":z1320.TestStatus = Children(i).Data
   Case "DATEAPPROVAL":z1320.DateApproval = Children(i).Data
   Case "DATECANCEL":z1320.DateCancel = Children(i).Data
   Case "DATECOMPLETE":z1320.DateComplete = Children(i).Data
   Case "DATEPENDING":z1320.DatePending = Children(i).Data
   Case "REMARK":z1320.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K1320_MOVE",vbCritical)
End Try
End Function 
    
End Module 
