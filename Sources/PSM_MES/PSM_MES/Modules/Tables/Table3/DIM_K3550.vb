'=========================================================================================================================================================
'   TABLE : (PFK3550)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K3550

Structure T3550_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	LABNo	 AS String	'			char(9)		*
Public 	TestOrder	 AS String	'			char(9)
Public 	seTestSide	 AS String	'			char(3)
Public 	cdTestSide	 AS String	'			char(3)
Public 	CustomerCode	 AS String	'			char(6)
Public 	TotalQty	 AS Double	'			decimal
Public 	InchargeOrder	 AS String	'			char(6)
Public 	InchargeAccept	 AS String	'			char(6)
Public 	InsertDate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(6)
Public 	UpdateDate	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(6)
Public 	LabTestStatus	 AS String	'			char(1)
Public 	DateAccept	 AS String	'			char(8)
Public 	DateApproval	 AS String	'			char(8)
Public 	DateProcess	 AS String	'			char(8)
Public 	DateCancel	 AS String	'			char(8)
Public 	DateComplete	 AS String	'			char(8)
Public 	DatePending	 AS String	'			char(8)
Public 	Remark	 AS String	'			nvarchar(500)
'=========================================================================================================================================================
End structure

Public D3550 As T3550_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK3550(LABNO AS String) As Boolean
    READ_PFK3550 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3550 "
    SQL = SQL & " WHERE K3550_LABNo		 = '" & LABNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D3550_CLEAR: GoTo SKIP_READ_PFK3550
                
    Call K3550_MOVE(rd)
    READ_PFK3550 = True

SKIP_READ_PFK3550:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK3550",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK3550(LABNO AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3550 "
    SQL = SQL & " WHERE K3550_LABNo		 = '" & LABNo & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK3550",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK3550(z3550 As T3550_AREA) As Boolean
    WRITE_PFK3550 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z3550)
 
    SQL = " INSERT INTO PFK3550 "
    SQL = SQL & " ( "
    SQL = SQL & " K3550_LABNo," 
    SQL = SQL & " K3550_TestOrder," 
    SQL = SQL & " K3550_seTestSide," 
    SQL = SQL & " K3550_cdTestSide," 
    SQL = SQL & " K3550_CustomerCode," 
    SQL = SQL & " K3550_TotalQty," 
    SQL = SQL & " K3550_InchargeOrder," 
    SQL = SQL & " K3550_InchargeAccept," 
    SQL = SQL & " K3550_InsertDate," 
    SQL = SQL & " K3550_InchargeInsert," 
    SQL = SQL & " K3550_UpdateDate," 
    SQL = SQL & " K3550_InchargeUpdate," 
    SQL = SQL & " K3550_LabTestStatus," 
    SQL = SQL & " K3550_DateAccept," 
    SQL = SQL & " K3550_DateApproval," 
    SQL = SQL & " K3550_DateProcess," 
    SQL = SQL & " K3550_DateCancel," 
    SQL = SQL & " K3550_DateComplete," 
    SQL = SQL & " K3550_DatePending," 
    SQL = SQL & " K3550_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z3550.LABNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3550.TestOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3550.seTestSide) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3550.cdTestSide) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3550.CustomerCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z3550.TotalQty) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3550.InchargeOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3550.InchargeAccept) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3550.InsertDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3550.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3550.UpdateDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3550.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3550.LabTestStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3550.DateAccept) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3550.DateApproval) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3550.DateProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3550.DateCancel) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3550.DateComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3550.DatePending) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3550.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK3550 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK3550",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK3550(z3550 As T3550_AREA) As Boolean
    REWRITE_PFK3550 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z3550)
   
    SQL = " UPDATE PFK3550 SET "
    SQL = SQL & "    K3550_TestOrder      = N'" & FormatSQL(z3550.TestOrder) & "', " 
    SQL = SQL & "    K3550_seTestSide      = N'" & FormatSQL(z3550.seTestSide) & "', " 
    SQL = SQL & "    K3550_cdTestSide      = N'" & FormatSQL(z3550.cdTestSide) & "', " 
    SQL = SQL & "    K3550_CustomerCode      = N'" & FormatSQL(z3550.CustomerCode) & "', " 
    SQL = SQL & "    K3550_TotalQty      =  " & FormatSQL(z3550.TotalQty) & ", " 
    SQL = SQL & "    K3550_InchargeOrder      = N'" & FormatSQL(z3550.InchargeOrder) & "', " 
    SQL = SQL & "    K3550_InchargeAccept      = N'" & FormatSQL(z3550.InchargeAccept) & "', " 
    SQL = SQL & "    K3550_InsertDate      = N'" & FormatSQL(z3550.InsertDate) & "', " 
    SQL = SQL & "    K3550_InchargeInsert      = N'" & FormatSQL(z3550.InchargeInsert) & "', " 
    SQL = SQL & "    K3550_UpdateDate      = N'" & FormatSQL(z3550.UpdateDate) & "', " 
    SQL = SQL & "    K3550_InchargeUpdate      = N'" & FormatSQL(z3550.InchargeUpdate) & "', " 
    SQL = SQL & "    K3550_LabTestStatus      = N'" & FormatSQL(z3550.LabTestStatus) & "', " 
    SQL = SQL & "    K3550_DateAccept      = N'" & FormatSQL(z3550.DateAccept) & "', " 
    SQL = SQL & "    K3550_DateApproval      = N'" & FormatSQL(z3550.DateApproval) & "', " 
    SQL = SQL & "    K3550_DateProcess      = N'" & FormatSQL(z3550.DateProcess) & "', " 
    SQL = SQL & "    K3550_DateCancel      = N'" & FormatSQL(z3550.DateCancel) & "', " 
    SQL = SQL & "    K3550_DateComplete      = N'" & FormatSQL(z3550.DateComplete) & "', " 
    SQL = SQL & "    K3550_DatePending      = N'" & FormatSQL(z3550.DatePending) & "', " 
    SQL = SQL & "    K3550_Remark      = N'" & FormatSQL(z3550.Remark) & "'  " 
    SQL = SQL & " WHERE K3550_LABNo		 = '" & z3550.LABNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK3550 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK3550",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK3550(z3550 As T3550_AREA) As Boolean
    DELETE_PFK3550 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK3550 "
    SQL = SQL & " WHERE K3550_LABNo		 = '" & z3550.LABNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK3550 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK3550",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D3550_CLEAR()
Try
    
   D3550.LABNo = ""
   D3550.TestOrder = ""
   D3550.seTestSide = ""
   D3550.cdTestSide = ""
   D3550.CustomerCode = ""
    D3550.TotalQty = 0 
   D3550.InchargeOrder = ""
   D3550.InchargeAccept = ""
   D3550.InsertDate = ""
   D3550.InchargeInsert = ""
   D3550.UpdateDate = ""
   D3550.InchargeUpdate = ""
   D3550.LabTestStatus = ""
   D3550.DateAccept = ""
   D3550.DateApproval = ""
   D3550.DateProcess = ""
   D3550.DateCancel = ""
   D3550.DateComplete = ""
   D3550.DatePending = ""
   D3550.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D3550_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x3550 As T3550_AREA)
Try
    
    x3550.LABNo = trim$(  x3550.LABNo)
    x3550.TestOrder = trim$(  x3550.TestOrder)
    x3550.seTestSide = trim$(  x3550.seTestSide)
    x3550.cdTestSide = trim$(  x3550.cdTestSide)
    x3550.CustomerCode = trim$(  x3550.CustomerCode)
    x3550.TotalQty = trim$(  x3550.TotalQty)
    x3550.InchargeOrder = trim$(  x3550.InchargeOrder)
    x3550.InchargeAccept = trim$(  x3550.InchargeAccept)
    x3550.InsertDate = trim$(  x3550.InsertDate)
    x3550.InchargeInsert = trim$(  x3550.InchargeInsert)
    x3550.UpdateDate = trim$(  x3550.UpdateDate)
    x3550.InchargeUpdate = trim$(  x3550.InchargeUpdate)
    x3550.LabTestStatus = trim$(  x3550.LabTestStatus)
    x3550.DateAccept = trim$(  x3550.DateAccept)
    x3550.DateApproval = trim$(  x3550.DateApproval)
    x3550.DateProcess = trim$(  x3550.DateProcess)
    x3550.DateCancel = trim$(  x3550.DateCancel)
    x3550.DateComplete = trim$(  x3550.DateComplete)
    x3550.DatePending = trim$(  x3550.DatePending)
    x3550.Remark = trim$(  x3550.Remark)
     
    If trim$( x3550.LABNo ) = "" Then x3550.LABNo = Space(1) 
    If trim$( x3550.TestOrder ) = "" Then x3550.TestOrder = Space(1) 
    If trim$( x3550.seTestSide ) = "" Then x3550.seTestSide = Space(1) 
    If trim$( x3550.cdTestSide ) = "" Then x3550.cdTestSide = Space(1) 
    If trim$( x3550.CustomerCode ) = "" Then x3550.CustomerCode = Space(1) 
    If trim$( x3550.TotalQty ) = "" Then x3550.TotalQty = 0 
    If trim$( x3550.InchargeOrder ) = "" Then x3550.InchargeOrder = Space(1) 
    If trim$( x3550.InchargeAccept ) = "" Then x3550.InchargeAccept = Space(1) 
    If trim$( x3550.InsertDate ) = "" Then x3550.InsertDate = Space(1) 
    If trim$( x3550.InchargeInsert ) = "" Then x3550.InchargeInsert = Space(1) 
    If trim$( x3550.UpdateDate ) = "" Then x3550.UpdateDate = Space(1) 
    If trim$( x3550.InchargeUpdate ) = "" Then x3550.InchargeUpdate = Space(1) 
    If trim$( x3550.LabTestStatus ) = "" Then x3550.LabTestStatus = Space(1) 
    If trim$( x3550.DateAccept ) = "" Then x3550.DateAccept = Space(1) 
    If trim$( x3550.DateApproval ) = "" Then x3550.DateApproval = Space(1) 
    If trim$( x3550.DateProcess ) = "" Then x3550.DateProcess = Space(1) 
    If trim$( x3550.DateCancel ) = "" Then x3550.DateCancel = Space(1) 
    If trim$( x3550.DateComplete ) = "" Then x3550.DateComplete = Space(1) 
    If trim$( x3550.DatePending ) = "" Then x3550.DatePending = Space(1) 
    If trim$( x3550.Remark ) = "" Then x3550.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K3550_MOVE(rs3550 As SqlClient.SqlDataReader)
Try

    call D3550_CLEAR()   

    If IsdbNull(rs3550!K3550_LABNo) = False Then D3550.LABNo = Trim$(rs3550!K3550_LABNo)
    If IsdbNull(rs3550!K3550_TestOrder) = False Then D3550.TestOrder = Trim$(rs3550!K3550_TestOrder)
    If IsdbNull(rs3550!K3550_seTestSide) = False Then D3550.seTestSide = Trim$(rs3550!K3550_seTestSide)
    If IsdbNull(rs3550!K3550_cdTestSide) = False Then D3550.cdTestSide = Trim$(rs3550!K3550_cdTestSide)
    If IsdbNull(rs3550!K3550_CustomerCode) = False Then D3550.CustomerCode = Trim$(rs3550!K3550_CustomerCode)
    If IsdbNull(rs3550!K3550_TotalQty) = False Then D3550.TotalQty = Trim$(rs3550!K3550_TotalQty)
    If IsdbNull(rs3550!K3550_InchargeOrder) = False Then D3550.InchargeOrder = Trim$(rs3550!K3550_InchargeOrder)
    If IsdbNull(rs3550!K3550_InchargeAccept) = False Then D3550.InchargeAccept = Trim$(rs3550!K3550_InchargeAccept)
    If IsdbNull(rs3550!K3550_InsertDate) = False Then D3550.InsertDate = Trim$(rs3550!K3550_InsertDate)
    If IsdbNull(rs3550!K3550_InchargeInsert) = False Then D3550.InchargeInsert = Trim$(rs3550!K3550_InchargeInsert)
    If IsdbNull(rs3550!K3550_UpdateDate) = False Then D3550.UpdateDate = Trim$(rs3550!K3550_UpdateDate)
    If IsdbNull(rs3550!K3550_InchargeUpdate) = False Then D3550.InchargeUpdate = Trim$(rs3550!K3550_InchargeUpdate)
    If IsdbNull(rs3550!K3550_LabTestStatus) = False Then D3550.LabTestStatus = Trim$(rs3550!K3550_LabTestStatus)
    If IsdbNull(rs3550!K3550_DateAccept) = False Then D3550.DateAccept = Trim$(rs3550!K3550_DateAccept)
    If IsdbNull(rs3550!K3550_DateApproval) = False Then D3550.DateApproval = Trim$(rs3550!K3550_DateApproval)
    If IsdbNull(rs3550!K3550_DateProcess) = False Then D3550.DateProcess = Trim$(rs3550!K3550_DateProcess)
    If IsdbNull(rs3550!K3550_DateCancel) = False Then D3550.DateCancel = Trim$(rs3550!K3550_DateCancel)
    If IsdbNull(rs3550!K3550_DateComplete) = False Then D3550.DateComplete = Trim$(rs3550!K3550_DateComplete)
    If IsdbNull(rs3550!K3550_DatePending) = False Then D3550.DatePending = Trim$(rs3550!K3550_DatePending)
    If IsdbNull(rs3550!K3550_Remark) = False Then D3550.Remark = Trim$(rs3550!K3550_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3550_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K3550_MOVE(rs3550 As DataRow)
Try

    call D3550_CLEAR()   

    If IsdbNull(rs3550!K3550_LABNo) = False Then D3550.LABNo = Trim$(rs3550!K3550_LABNo)
    If IsdbNull(rs3550!K3550_TestOrder) = False Then D3550.TestOrder = Trim$(rs3550!K3550_TestOrder)
    If IsdbNull(rs3550!K3550_seTestSide) = False Then D3550.seTestSide = Trim$(rs3550!K3550_seTestSide)
    If IsdbNull(rs3550!K3550_cdTestSide) = False Then D3550.cdTestSide = Trim$(rs3550!K3550_cdTestSide)
    If IsdbNull(rs3550!K3550_CustomerCode) = False Then D3550.CustomerCode = Trim$(rs3550!K3550_CustomerCode)
    If IsdbNull(rs3550!K3550_TotalQty) = False Then D3550.TotalQty = Trim$(rs3550!K3550_TotalQty)
    If IsdbNull(rs3550!K3550_InchargeOrder) = False Then D3550.InchargeOrder = Trim$(rs3550!K3550_InchargeOrder)
    If IsdbNull(rs3550!K3550_InchargeAccept) = False Then D3550.InchargeAccept = Trim$(rs3550!K3550_InchargeAccept)
    If IsdbNull(rs3550!K3550_InsertDate) = False Then D3550.InsertDate = Trim$(rs3550!K3550_InsertDate)
    If IsdbNull(rs3550!K3550_InchargeInsert) = False Then D3550.InchargeInsert = Trim$(rs3550!K3550_InchargeInsert)
    If IsdbNull(rs3550!K3550_UpdateDate) = False Then D3550.UpdateDate = Trim$(rs3550!K3550_UpdateDate)
    If IsdbNull(rs3550!K3550_InchargeUpdate) = False Then D3550.InchargeUpdate = Trim$(rs3550!K3550_InchargeUpdate)
    If IsdbNull(rs3550!K3550_LabTestStatus) = False Then D3550.LabTestStatus = Trim$(rs3550!K3550_LabTestStatus)
    If IsdbNull(rs3550!K3550_DateAccept) = False Then D3550.DateAccept = Trim$(rs3550!K3550_DateAccept)
    If IsdbNull(rs3550!K3550_DateApproval) = False Then D3550.DateApproval = Trim$(rs3550!K3550_DateApproval)
    If IsdbNull(rs3550!K3550_DateProcess) = False Then D3550.DateProcess = Trim$(rs3550!K3550_DateProcess)
    If IsdbNull(rs3550!K3550_DateCancel) = False Then D3550.DateCancel = Trim$(rs3550!K3550_DateCancel)
    If IsdbNull(rs3550!K3550_DateComplete) = False Then D3550.DateComplete = Trim$(rs3550!K3550_DateComplete)
    If IsdbNull(rs3550!K3550_DatePending) = False Then D3550.DatePending = Trim$(rs3550!K3550_DatePending)
    If IsdbNull(rs3550!K3550_Remark) = False Then D3550.Remark = Trim$(rs3550!K3550_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3550_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K3550_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3550 As T3550_AREA, LABNO AS String) as Boolean

K3550_MOVE = False

Try
    If READ_PFK3550(LABNO) = True Then
                z3550 = D3550
		K3550_MOVE = True
		else
	z3550 = nothing
     End If

     If  getColumIndex(spr,"LABNo") > -1 then z3550.LABNo = getDataM(spr, getColumIndex(spr,"LABNo"), xRow)
     If  getColumIndex(spr,"TestOrder") > -1 then z3550.TestOrder = getDataM(spr, getColumIndex(spr,"TestOrder"), xRow)
     If  getColumIndex(spr,"seTestSide") > -1 then z3550.seTestSide = getDataM(spr, getColumIndex(spr,"seTestSide"), xRow)
     If  getColumIndex(spr,"cdTestSide") > -1 then z3550.cdTestSide = getDataM(spr, getColumIndex(spr,"cdTestSide"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z3550.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"TotalQty") > -1 then z3550.TotalQty = getDataM(spr, getColumIndex(spr,"TotalQty"), xRow)
     If  getColumIndex(spr,"InchargeOrder") > -1 then z3550.InchargeOrder = getDataM(spr, getColumIndex(spr,"InchargeOrder"), xRow)
     If  getColumIndex(spr,"InchargeAccept") > -1 then z3550.InchargeAccept = getDataM(spr, getColumIndex(spr,"InchargeAccept"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z3550.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z3550.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z3550.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z3550.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"LabTestStatus") > -1 then z3550.LabTestStatus = getDataM(spr, getColumIndex(spr,"LabTestStatus"), xRow)
     If  getColumIndex(spr,"DateAccept") > -1 then z3550.DateAccept = getDataM(spr, getColumIndex(spr,"DateAccept"), xRow)
     If  getColumIndex(spr,"DateApproval") > -1 then z3550.DateApproval = getDataM(spr, getColumIndex(spr,"DateApproval"), xRow)
     If  getColumIndex(spr,"DateProcess") > -1 then z3550.DateProcess = getDataM(spr, getColumIndex(spr,"DateProcess"), xRow)
     If  getColumIndex(spr,"DateCancel") > -1 then z3550.DateCancel = getDataM(spr, getColumIndex(spr,"DateCancel"), xRow)
     If  getColumIndex(spr,"DateComplete") > -1 then z3550.DateComplete = getDataM(spr, getColumIndex(spr,"DateComplete"), xRow)
     If  getColumIndex(spr,"DatePending") > -1 then z3550.DatePending = getDataM(spr, getColumIndex(spr,"DatePending"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z3550.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3550_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K3550_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3550 As T3550_AREA,CheckClear as Boolean,LABNO AS String) as Boolean

K3550_MOVE = False

Try
    If READ_PFK3550(LABNO) = True Then
                z3550 = D3550
		K3550_MOVE = True
		else
	If CheckClear  = True then z3550 = nothing
     End If

     If  getColumIndex(spr,"LABNo") > -1 then z3550.LABNo = getDataM(spr, getColumIndex(spr,"LABNo"), xRow)
     If  getColumIndex(spr,"TestOrder") > -1 then z3550.TestOrder = getDataM(spr, getColumIndex(spr,"TestOrder"), xRow)
     If  getColumIndex(spr,"seTestSide") > -1 then z3550.seTestSide = getDataM(spr, getColumIndex(spr,"seTestSide"), xRow)
     If  getColumIndex(spr,"cdTestSide") > -1 then z3550.cdTestSide = getDataM(spr, getColumIndex(spr,"cdTestSide"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z3550.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"TotalQty") > -1 then z3550.TotalQty = getDataM(spr, getColumIndex(spr,"TotalQty"), xRow)
     If  getColumIndex(spr,"InchargeOrder") > -1 then z3550.InchargeOrder = getDataM(spr, getColumIndex(spr,"InchargeOrder"), xRow)
     If  getColumIndex(spr,"InchargeAccept") > -1 then z3550.InchargeAccept = getDataM(spr, getColumIndex(spr,"InchargeAccept"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z3550.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z3550.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z3550.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z3550.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"LabTestStatus") > -1 then z3550.LabTestStatus = getDataM(spr, getColumIndex(spr,"LabTestStatus"), xRow)
     If  getColumIndex(spr,"DateAccept") > -1 then z3550.DateAccept = getDataM(spr, getColumIndex(spr,"DateAccept"), xRow)
     If  getColumIndex(spr,"DateApproval") > -1 then z3550.DateApproval = getDataM(spr, getColumIndex(spr,"DateApproval"), xRow)
     If  getColumIndex(spr,"DateProcess") > -1 then z3550.DateProcess = getDataM(spr, getColumIndex(spr,"DateProcess"), xRow)
     If  getColumIndex(spr,"DateCancel") > -1 then z3550.DateCancel = getDataM(spr, getColumIndex(spr,"DateCancel"), xRow)
     If  getColumIndex(spr,"DateComplete") > -1 then z3550.DateComplete = getDataM(spr, getColumIndex(spr,"DateComplete"), xRow)
     If  getColumIndex(spr,"DatePending") > -1 then z3550.DatePending = getDataM(spr, getColumIndex(spr,"DatePending"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z3550.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3550_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K3550_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3550 As T3550_AREA, Job as String, LABNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3550_MOVE = False

Try
    If READ_PFK3550(LABNO) = True Then
                z3550 = D3550
		K3550_MOVE = True
		else
	z3550 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3550")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "LABNO":z3550.LABNo = Children(i).Code
   Case "TESTORDER":z3550.TestOrder = Children(i).Code
   Case "SETESTSIDE":z3550.seTestSide = Children(i).Code
   Case "CDTESTSIDE":z3550.cdTestSide = Children(i).Code
   Case "CUSTOMERCODE":z3550.CustomerCode = Children(i).Code
   Case "TOTALQTY":z3550.TotalQty = Children(i).Code
   Case "INCHARGEORDER":z3550.InchargeOrder = Children(i).Code
   Case "INCHARGEACCEPT":z3550.InchargeAccept = Children(i).Code
   Case "INSERTDATE":z3550.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z3550.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z3550.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z3550.InchargeUpdate = Children(i).Code
   Case "LABTESTSTATUS":z3550.LabTestStatus = Children(i).Code
   Case "DATEACCEPT":z3550.DateAccept = Children(i).Code
   Case "DATEAPPROVAL":z3550.DateApproval = Children(i).Code
   Case "DATEPROCESS":z3550.DateProcess = Children(i).Code
   Case "DATECANCEL":z3550.DateCancel = Children(i).Code
   Case "DATECOMPLETE":z3550.DateComplete = Children(i).Code
   Case "DATEPENDING":z3550.DatePending = Children(i).Code
   Case "REMARK":z3550.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "LABNO":z3550.LABNo = Children(i).Data
   Case "TESTORDER":z3550.TestOrder = Children(i).Data
   Case "SETESTSIDE":z3550.seTestSide = Children(i).Data
   Case "CDTESTSIDE":z3550.cdTestSide = Children(i).Data
   Case "CUSTOMERCODE":z3550.CustomerCode = Children(i).Data
   Case "TOTALQTY":z3550.TotalQty = Children(i).Data
   Case "INCHARGEORDER":z3550.InchargeOrder = Children(i).Data
   Case "INCHARGEACCEPT":z3550.InchargeAccept = Children(i).Data
   Case "INSERTDATE":z3550.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z3550.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z3550.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z3550.InchargeUpdate = Children(i).Data
   Case "LABTESTSTATUS":z3550.LabTestStatus = Children(i).Data
   Case "DATEACCEPT":z3550.DateAccept = Children(i).Data
   Case "DATEAPPROVAL":z3550.DateApproval = Children(i).Data
   Case "DATEPROCESS":z3550.DateProcess = Children(i).Data
   Case "DATECANCEL":z3550.DateCancel = Children(i).Data
   Case "DATECOMPLETE":z3550.DateComplete = Children(i).Data
   Case "DATEPENDING":z3550.DatePending = Children(i).Data
   Case "REMARK":z3550.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3550_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K3550_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3550 As T3550_AREA, Job as String, CheckClear as Boolean, LABNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3550_MOVE = False

Try
    If READ_PFK3550(LABNO) = True Then
                z3550 = D3550
		K3550_MOVE = True
		else
	If CheckClear  = True then z3550 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3550")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "LABNO":z3550.LABNo = Children(i).Code
   Case "TESTORDER":z3550.TestOrder = Children(i).Code
   Case "SETESTSIDE":z3550.seTestSide = Children(i).Code
   Case "CDTESTSIDE":z3550.cdTestSide = Children(i).Code
   Case "CUSTOMERCODE":z3550.CustomerCode = Children(i).Code
   Case "TOTALQTY":z3550.TotalQty = Children(i).Code
   Case "INCHARGEORDER":z3550.InchargeOrder = Children(i).Code
   Case "INCHARGEACCEPT":z3550.InchargeAccept = Children(i).Code
   Case "INSERTDATE":z3550.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z3550.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z3550.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z3550.InchargeUpdate = Children(i).Code
   Case "LABTESTSTATUS":z3550.LabTestStatus = Children(i).Code
   Case "DATEACCEPT":z3550.DateAccept = Children(i).Code
   Case "DATEAPPROVAL":z3550.DateApproval = Children(i).Code
   Case "DATEPROCESS":z3550.DateProcess = Children(i).Code
   Case "DATECANCEL":z3550.DateCancel = Children(i).Code
   Case "DATECOMPLETE":z3550.DateComplete = Children(i).Code
   Case "DATEPENDING":z3550.DatePending = Children(i).Code
   Case "REMARK":z3550.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "LABNO":z3550.LABNo = Children(i).Data
   Case "TESTORDER":z3550.TestOrder = Children(i).Data
   Case "SETESTSIDE":z3550.seTestSide = Children(i).Data
   Case "CDTESTSIDE":z3550.cdTestSide = Children(i).Data
   Case "CUSTOMERCODE":z3550.CustomerCode = Children(i).Data
   Case "TOTALQTY":z3550.TotalQty = Children(i).Data
   Case "INCHARGEORDER":z3550.InchargeOrder = Children(i).Data
   Case "INCHARGEACCEPT":z3550.InchargeAccept = Children(i).Data
   Case "INSERTDATE":z3550.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z3550.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z3550.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z3550.InchargeUpdate = Children(i).Data
   Case "LABTESTSTATUS":z3550.LabTestStatus = Children(i).Data
   Case "DATEACCEPT":z3550.DateAccept = Children(i).Data
   Case "DATEAPPROVAL":z3550.DateApproval = Children(i).Data
   Case "DATEPROCESS":z3550.DateProcess = Children(i).Data
   Case "DATECANCEL":z3550.DateCancel = Children(i).Data
   Case "DATECOMPLETE":z3550.DateComplete = Children(i).Data
   Case "DATEPENDING":z3550.DatePending = Children(i).Data
   Case "REMARK":z3550.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3550_MOVE",vbCritical)
End Try
End Function 
    
End Module 
