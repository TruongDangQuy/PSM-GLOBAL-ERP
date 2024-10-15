'=========================================================================================================================================================
'   TABLE : (PFK0101)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K0101

Structure T0101_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	SpecNo	 AS String	'			char(9)		*
Public 	ShoesCode	 AS String	'			char(6)
Public 	OrderNo	 AS String	'			char(9)
Public 	OrderNoSeq	 AS String	'			char(3)
Public 	seSpecKind	 AS String	'			char(3)
Public 	cdSpecKind	 AS String	'			char(3)
Public 	StartTime	 AS String	'			char(14)
Public 	FinishTime	 AS String	'			char(14)
Public 	DateAccept	 AS String	'			char(8)
Public 	InsertDate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	UpdateDate	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	AttchID	 AS String	'			char(6)
Public 	CheckConfirm	 AS String	'			char(1)
Public 	DateConfirm	 AS String	'			char(8)
Public 	RemarkOrder	 AS String	'			nvarchar(200)
Public 	RemarkCustomer	 AS String	'			nvarchar(200)
Public 	Remark	 AS String	'			nvarchar(200)
'=========================================================================================================================================================
End structure

Public D0101 As T0101_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK0101(SPECNO AS String) As Boolean
    READ_PFK0101 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0101 "
    SQL = SQL & " WHERE K0101_SpecNo		 = '" & SpecNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D0101_CLEAR: GoTo SKIP_READ_PFK0101
                
    Call K0101_MOVE(rd)
    READ_PFK0101 = True

SKIP_READ_PFK0101:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK0101",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK0101(SPECNO AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0101 "
    SQL = SQL & " WHERE K0101_SpecNo		 = '" & SpecNo & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK0101",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK0101(z0101 As T0101_AREA) As Boolean
    WRITE_PFK0101 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z0101)
 
    SQL = " INSERT INTO PFK0101 "
    SQL = SQL & " ( "
    SQL = SQL & " K0101_SpecNo," 
    SQL = SQL & " K0101_ShoesCode," 
    SQL = SQL & " K0101_OrderNo," 
    SQL = SQL & " K0101_OrderNoSeq," 
    SQL = SQL & " K0101_seSpecKind," 
    SQL = SQL & " K0101_cdSpecKind," 
    SQL = SQL & " K0101_StartTime," 
    SQL = SQL & " K0101_FinishTime," 
    SQL = SQL & " K0101_DateAccept," 
    SQL = SQL & " K0101_InsertDate," 
    SQL = SQL & " K0101_InchargeInsert," 
    SQL = SQL & " K0101_UpdateDate," 
    SQL = SQL & " K0101_InchargeUpdate," 
    SQL = SQL & " K0101_AttchID," 
    SQL = SQL & " K0101_CheckConfirm," 
    SQL = SQL & " K0101_DateConfirm," 
    SQL = SQL & " K0101_RemarkOrder," 
    SQL = SQL & " K0101_RemarkCustomer," 
    SQL = SQL & " K0101_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z0101.SpecNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0101.ShoesCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0101.OrderNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0101.OrderNoSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0101.seSpecKind) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0101.cdSpecKind) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0101.StartTime) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0101.FinishTime) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0101.DateAccept) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0101.InsertDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0101.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0101.UpdateDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0101.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0101.AttchID) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0101.CheckConfirm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0101.DateConfirm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0101.RemarkOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0101.RemarkCustomer) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0101.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK0101 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK0101",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK0101(z0101 As T0101_AREA) As Boolean
    REWRITE_PFK0101 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z0101)
   
    SQL = " UPDATE PFK0101 SET "
    SQL = SQL & "    K0101_ShoesCode      = N'" & FormatSQL(z0101.ShoesCode) & "', " 
    SQL = SQL & "    K0101_OrderNo      = N'" & FormatSQL(z0101.OrderNo) & "', " 
    SQL = SQL & "    K0101_OrderNoSeq      = N'" & FormatSQL(z0101.OrderNoSeq) & "', " 
    SQL = SQL & "    K0101_seSpecKind      = N'" & FormatSQL(z0101.seSpecKind) & "', " 
    SQL = SQL & "    K0101_cdSpecKind      = N'" & FormatSQL(z0101.cdSpecKind) & "', " 
    SQL = SQL & "    K0101_StartTime      = N'" & FormatSQL(z0101.StartTime) & "', " 
    SQL = SQL & "    K0101_FinishTime      = N'" & FormatSQL(z0101.FinishTime) & "', " 
    SQL = SQL & "    K0101_DateAccept      = N'" & FormatSQL(z0101.DateAccept) & "', " 
    SQL = SQL & "    K0101_InsertDate      = N'" & FormatSQL(z0101.InsertDate) & "', " 
    SQL = SQL & "    K0101_InchargeInsert      = N'" & FormatSQL(z0101.InchargeInsert) & "', " 
    SQL = SQL & "    K0101_UpdateDate      = N'" & FormatSQL(z0101.UpdateDate) & "', " 
    SQL = SQL & "    K0101_InchargeUpdate      = N'" & FormatSQL(z0101.InchargeUpdate) & "', " 
    SQL = SQL & "    K0101_AttchID      = N'" & FormatSQL(z0101.AttchID) & "', " 
    SQL = SQL & "    K0101_CheckConfirm      = N'" & FormatSQL(z0101.CheckConfirm) & "', " 
    SQL = SQL & "    K0101_DateConfirm      = N'" & FormatSQL(z0101.DateConfirm) & "', " 
    SQL = SQL & "    K0101_RemarkOrder      = N'" & FormatSQL(z0101.RemarkOrder) & "', " 
    SQL = SQL & "    K0101_RemarkCustomer      = N'" & FormatSQL(z0101.RemarkCustomer) & "', " 
    SQL = SQL & "    K0101_Remark      = N'" & FormatSQL(z0101.Remark) & "'  " 
    SQL = SQL & " WHERE K0101_SpecNo		 = '" & z0101.SpecNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK0101 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK0101",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK0101(z0101 As T0101_AREA) As Boolean
    DELETE_PFK0101 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK0101 "
    SQL = SQL & " WHERE K0101_SpecNo		 = '" & z0101.SpecNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK0101 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK0101",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D0101_CLEAR()
Try
    
   D0101.SpecNo = ""
   D0101.ShoesCode = ""
   D0101.OrderNo = ""
   D0101.OrderNoSeq = ""
   D0101.seSpecKind = ""
   D0101.cdSpecKind = ""
   D0101.StartTime = ""
   D0101.FinishTime = ""
   D0101.DateAccept = ""
   D0101.InsertDate = ""
   D0101.InchargeInsert = ""
   D0101.UpdateDate = ""
   D0101.InchargeUpdate = ""
   D0101.AttchID = ""
   D0101.CheckConfirm = ""
   D0101.DateConfirm = ""
   D0101.RemarkOrder = ""
   D0101.RemarkCustomer = ""
   D0101.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D0101_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x0101 As T0101_AREA)
Try
    
    x0101.SpecNo = trim$(  x0101.SpecNo)
    x0101.ShoesCode = trim$(  x0101.ShoesCode)
    x0101.OrderNo = trim$(  x0101.OrderNo)
    x0101.OrderNoSeq = trim$(  x0101.OrderNoSeq)
    x0101.seSpecKind = trim$(  x0101.seSpecKind)
    x0101.cdSpecKind = trim$(  x0101.cdSpecKind)
    x0101.StartTime = trim$(  x0101.StartTime)
    x0101.FinishTime = trim$(  x0101.FinishTime)
    x0101.DateAccept = trim$(  x0101.DateAccept)
    x0101.InsertDate = trim$(  x0101.InsertDate)
    x0101.InchargeInsert = trim$(  x0101.InchargeInsert)
    x0101.UpdateDate = trim$(  x0101.UpdateDate)
    x0101.InchargeUpdate = trim$(  x0101.InchargeUpdate)
    x0101.AttchID = trim$(  x0101.AttchID)
    x0101.CheckConfirm = trim$(  x0101.CheckConfirm)
    x0101.DateConfirm = trim$(  x0101.DateConfirm)
    x0101.RemarkOrder = trim$(  x0101.RemarkOrder)
    x0101.RemarkCustomer = trim$(  x0101.RemarkCustomer)
    x0101.Remark = trim$(  x0101.Remark)
     
    If trim$( x0101.SpecNo ) = "" Then x0101.SpecNo = Space(1) 
    If trim$( x0101.ShoesCode ) = "" Then x0101.ShoesCode = Space(1) 
    If trim$( x0101.OrderNo ) = "" Then x0101.OrderNo = Space(1) 
    If trim$( x0101.OrderNoSeq ) = "" Then x0101.OrderNoSeq = Space(1) 
    If trim$( x0101.seSpecKind ) = "" Then x0101.seSpecKind = Space(1) 
    If trim$( x0101.cdSpecKind ) = "" Then x0101.cdSpecKind = Space(1) 
    If trim$( x0101.StartTime ) = "" Then x0101.StartTime = Space(1) 
    If trim$( x0101.FinishTime ) = "" Then x0101.FinishTime = Space(1) 
    If trim$( x0101.DateAccept ) = "" Then x0101.DateAccept = Space(1) 
    If trim$( x0101.InsertDate ) = "" Then x0101.InsertDate = Space(1) 
    If trim$( x0101.InchargeInsert ) = "" Then x0101.InchargeInsert = Space(1) 
    If trim$( x0101.UpdateDate ) = "" Then x0101.UpdateDate = Space(1) 
    If trim$( x0101.InchargeUpdate ) = "" Then x0101.InchargeUpdate = Space(1) 
    If trim$( x0101.AttchID ) = "" Then x0101.AttchID = Space(1) 
    If trim$( x0101.CheckConfirm ) = "" Then x0101.CheckConfirm = Space(1) 
    If trim$( x0101.DateConfirm ) = "" Then x0101.DateConfirm = Space(1) 
    If trim$( x0101.RemarkOrder ) = "" Then x0101.RemarkOrder = Space(1) 
    If trim$( x0101.RemarkCustomer ) = "" Then x0101.RemarkCustomer = Space(1) 
    If trim$( x0101.Remark ) = "" Then x0101.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K0101_MOVE(rs0101 As SqlClient.SqlDataReader)
Try

    call D0101_CLEAR()   

    If IsdbNull(rs0101!K0101_SpecNo) = False Then D0101.SpecNo = Trim$(rs0101!K0101_SpecNo)
    If IsdbNull(rs0101!K0101_ShoesCode) = False Then D0101.ShoesCode = Trim$(rs0101!K0101_ShoesCode)
    If IsdbNull(rs0101!K0101_OrderNo) = False Then D0101.OrderNo = Trim$(rs0101!K0101_OrderNo)
    If IsdbNull(rs0101!K0101_OrderNoSeq) = False Then D0101.OrderNoSeq = Trim$(rs0101!K0101_OrderNoSeq)
    If IsdbNull(rs0101!K0101_seSpecKind) = False Then D0101.seSpecKind = Trim$(rs0101!K0101_seSpecKind)
    If IsdbNull(rs0101!K0101_cdSpecKind) = False Then D0101.cdSpecKind = Trim$(rs0101!K0101_cdSpecKind)
    If IsdbNull(rs0101!K0101_StartTime) = False Then D0101.StartTime = Trim$(rs0101!K0101_StartTime)
    If IsdbNull(rs0101!K0101_FinishTime) = False Then D0101.FinishTime = Trim$(rs0101!K0101_FinishTime)
    If IsdbNull(rs0101!K0101_DateAccept) = False Then D0101.DateAccept = Trim$(rs0101!K0101_DateAccept)
    If IsdbNull(rs0101!K0101_InsertDate) = False Then D0101.InsertDate = Trim$(rs0101!K0101_InsertDate)
    If IsdbNull(rs0101!K0101_InchargeInsert) = False Then D0101.InchargeInsert = Trim$(rs0101!K0101_InchargeInsert)
    If IsdbNull(rs0101!K0101_UpdateDate) = False Then D0101.UpdateDate = Trim$(rs0101!K0101_UpdateDate)
    If IsdbNull(rs0101!K0101_InchargeUpdate) = False Then D0101.InchargeUpdate = Trim$(rs0101!K0101_InchargeUpdate)
    If IsdbNull(rs0101!K0101_AttchID) = False Then D0101.AttchID = Trim$(rs0101!K0101_AttchID)
    If IsdbNull(rs0101!K0101_CheckConfirm) = False Then D0101.CheckConfirm = Trim$(rs0101!K0101_CheckConfirm)
    If IsdbNull(rs0101!K0101_DateConfirm) = False Then D0101.DateConfirm = Trim$(rs0101!K0101_DateConfirm)
    If IsdbNull(rs0101!K0101_RemarkOrder) = False Then D0101.RemarkOrder = Trim$(rs0101!K0101_RemarkOrder)
    If IsdbNull(rs0101!K0101_RemarkCustomer) = False Then D0101.RemarkCustomer = Trim$(rs0101!K0101_RemarkCustomer)
    If IsdbNull(rs0101!K0101_Remark) = False Then D0101.Remark = Trim$(rs0101!K0101_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0101_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K0101_MOVE(rs0101 As DataRow)
Try

    call D0101_CLEAR()   

    If IsdbNull(rs0101!K0101_SpecNo) = False Then D0101.SpecNo = Trim$(rs0101!K0101_SpecNo)
    If IsdbNull(rs0101!K0101_ShoesCode) = False Then D0101.ShoesCode = Trim$(rs0101!K0101_ShoesCode)
    If IsdbNull(rs0101!K0101_OrderNo) = False Then D0101.OrderNo = Trim$(rs0101!K0101_OrderNo)
    If IsdbNull(rs0101!K0101_OrderNoSeq) = False Then D0101.OrderNoSeq = Trim$(rs0101!K0101_OrderNoSeq)
    If IsdbNull(rs0101!K0101_seSpecKind) = False Then D0101.seSpecKind = Trim$(rs0101!K0101_seSpecKind)
    If IsdbNull(rs0101!K0101_cdSpecKind) = False Then D0101.cdSpecKind = Trim$(rs0101!K0101_cdSpecKind)
    If IsdbNull(rs0101!K0101_StartTime) = False Then D0101.StartTime = Trim$(rs0101!K0101_StartTime)
    If IsdbNull(rs0101!K0101_FinishTime) = False Then D0101.FinishTime = Trim$(rs0101!K0101_FinishTime)
    If IsdbNull(rs0101!K0101_DateAccept) = False Then D0101.DateAccept = Trim$(rs0101!K0101_DateAccept)
    If IsdbNull(rs0101!K0101_InsertDate) = False Then D0101.InsertDate = Trim$(rs0101!K0101_InsertDate)
    If IsdbNull(rs0101!K0101_InchargeInsert) = False Then D0101.InchargeInsert = Trim$(rs0101!K0101_InchargeInsert)
    If IsdbNull(rs0101!K0101_UpdateDate) = False Then D0101.UpdateDate = Trim$(rs0101!K0101_UpdateDate)
    If IsdbNull(rs0101!K0101_InchargeUpdate) = False Then D0101.InchargeUpdate = Trim$(rs0101!K0101_InchargeUpdate)
    If IsdbNull(rs0101!K0101_AttchID) = False Then D0101.AttchID = Trim$(rs0101!K0101_AttchID)
    If IsdbNull(rs0101!K0101_CheckConfirm) = False Then D0101.CheckConfirm = Trim$(rs0101!K0101_CheckConfirm)
    If IsdbNull(rs0101!K0101_DateConfirm) = False Then D0101.DateConfirm = Trim$(rs0101!K0101_DateConfirm)
    If IsdbNull(rs0101!K0101_RemarkOrder) = False Then D0101.RemarkOrder = Trim$(rs0101!K0101_RemarkOrder)
    If IsdbNull(rs0101!K0101_RemarkCustomer) = False Then D0101.RemarkCustomer = Trim$(rs0101!K0101_RemarkCustomer)
    If IsdbNull(rs0101!K0101_Remark) = False Then D0101.Remark = Trim$(rs0101!K0101_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0101_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K0101_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0101 As T0101_AREA, SPECNO AS String) as Boolean

K0101_MOVE = False

Try
    If READ_PFK0101(SPECNO) = True Then
                z0101 = D0101
		K0101_MOVE = True
		else
	z0101 = nothing
     End If

     If  getColumIndex(spr,"SpecNo") > -1 then z0101.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"ShoesCode") > -1 then z0101.ShoesCode = getDataM(spr, getColumIndex(spr,"ShoesCode"), xRow)
     If  getColumIndex(spr,"OrderNo") > -1 then z0101.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"OrderNoSeq") > -1 then z0101.OrderNoSeq = getDataM(spr, getColumIndex(spr,"OrderNoSeq"), xRow)
     If  getColumIndex(spr,"seSpecKind") > -1 then z0101.seSpecKind = getDataM(spr, getColumIndex(spr,"seSpecKind"), xRow)
     If  getColumIndex(spr,"cdSpecKind") > -1 then z0101.cdSpecKind = getDataM(spr, getColumIndex(spr,"cdSpecKind"), xRow)
     If  getColumIndex(spr,"StartTime") > -1 then z0101.StartTime = getDataM(spr, getColumIndex(spr,"StartTime"), xRow)
     If  getColumIndex(spr,"FinishTime") > -1 then z0101.FinishTime = getDataM(spr, getColumIndex(spr,"FinishTime"), xRow)
     If  getColumIndex(spr,"DateAccept") > -1 then z0101.DateAccept = getDataM(spr, getColumIndex(spr,"DateAccept"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z0101.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z0101.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z0101.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z0101.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"AttchID") > -1 then z0101.AttchID = getDataM(spr, getColumIndex(spr,"AttchID"), xRow)
     If  getColumIndex(spr,"CheckConfirm") > -1 then z0101.CheckConfirm = getDataM(spr, getColumIndex(spr,"CheckConfirm"), xRow)
     If  getColumIndex(spr,"DateConfirm") > -1 then z0101.DateConfirm = getDataM(spr, getColumIndex(spr,"DateConfirm"), xRow)
     If  getColumIndex(spr,"RemarkOrder") > -1 then z0101.RemarkOrder = getDataM(spr, getColumIndex(spr,"RemarkOrder"), xRow)
     If  getColumIndex(spr,"RemarkCustomer") > -1 then z0101.RemarkCustomer = getDataM(spr, getColumIndex(spr,"RemarkCustomer"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0101.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0101_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K0101_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0101 As T0101_AREA,CheckClear as Boolean,SPECNO AS String) as Boolean

K0101_MOVE = False

Try
    If READ_PFK0101(SPECNO) = True Then
                z0101 = D0101
		K0101_MOVE = True
		else
	If CheckClear  = True then z0101 = nothing
     End If

     If  getColumIndex(spr,"SpecNo") > -1 then z0101.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"ShoesCode") > -1 then z0101.ShoesCode = getDataM(spr, getColumIndex(spr,"ShoesCode"), xRow)
     If  getColumIndex(spr,"OrderNo") > -1 then z0101.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"OrderNoSeq") > -1 then z0101.OrderNoSeq = getDataM(spr, getColumIndex(spr,"OrderNoSeq"), xRow)
     If  getColumIndex(spr,"seSpecKind") > -1 then z0101.seSpecKind = getDataM(spr, getColumIndex(spr,"seSpecKind"), xRow)
     If  getColumIndex(spr,"cdSpecKind") > -1 then z0101.cdSpecKind = getDataM(spr, getColumIndex(spr,"cdSpecKind"), xRow)
     If  getColumIndex(spr,"StartTime") > -1 then z0101.StartTime = getDataM(spr, getColumIndex(spr,"StartTime"), xRow)
     If  getColumIndex(spr,"FinishTime") > -1 then z0101.FinishTime = getDataM(spr, getColumIndex(spr,"FinishTime"), xRow)
     If  getColumIndex(spr,"DateAccept") > -1 then z0101.DateAccept = getDataM(spr, getColumIndex(spr,"DateAccept"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z0101.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z0101.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z0101.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z0101.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"AttchID") > -1 then z0101.AttchID = getDataM(spr, getColumIndex(spr,"AttchID"), xRow)
     If  getColumIndex(spr,"CheckConfirm") > -1 then z0101.CheckConfirm = getDataM(spr, getColumIndex(spr,"CheckConfirm"), xRow)
     If  getColumIndex(spr,"DateConfirm") > -1 then z0101.DateConfirm = getDataM(spr, getColumIndex(spr,"DateConfirm"), xRow)
     If  getColumIndex(spr,"RemarkOrder") > -1 then z0101.RemarkOrder = getDataM(spr, getColumIndex(spr,"RemarkOrder"), xRow)
     If  getColumIndex(spr,"RemarkCustomer") > -1 then z0101.RemarkCustomer = getDataM(spr, getColumIndex(spr,"RemarkCustomer"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0101.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0101_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K0101_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0101 As T0101_AREA, Job as String, SPECNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0101_MOVE = False

Try
    If READ_PFK0101(SPECNO) = True Then
                z0101 = D0101
		K0101_MOVE = True
		else
	z0101 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0101")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SPECNO":z0101.SpecNo = Children(i).Code
   Case "SHOESCODE":z0101.ShoesCode = Children(i).Code
   Case "ORDERNO":z0101.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z0101.OrderNoSeq = Children(i).Code
   Case "SESPECKIND":z0101.seSpecKind = Children(i).Code
   Case "CDSPECKIND":z0101.cdSpecKind = Children(i).Code
   Case "STARTTIME":z0101.StartTime = Children(i).Code
   Case "FINISHTIME":z0101.FinishTime = Children(i).Code
   Case "DATEACCEPT":z0101.DateAccept = Children(i).Code
   Case "INSERTDATE":z0101.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z0101.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z0101.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z0101.InchargeUpdate = Children(i).Code
   Case "ATTCHID":z0101.AttchID = Children(i).Code
   Case "CHECKCONFIRM":z0101.CheckConfirm = Children(i).Code
   Case "DATECONFIRM":z0101.DateConfirm = Children(i).Code
   Case "REMARKORDER":z0101.RemarkOrder = Children(i).Code
   Case "REMARKCUSTOMER":z0101.RemarkCustomer = Children(i).Code
   Case "REMARK":z0101.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SPECNO":z0101.SpecNo = Children(i).Data
   Case "SHOESCODE":z0101.ShoesCode = Children(i).Data
   Case "ORDERNO":z0101.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z0101.OrderNoSeq = Children(i).Data
   Case "SESPECKIND":z0101.seSpecKind = Children(i).Data
   Case "CDSPECKIND":z0101.cdSpecKind = Children(i).Data
   Case "STARTTIME":z0101.StartTime = Children(i).Data
   Case "FINISHTIME":z0101.FinishTime = Children(i).Data
   Case "DATEACCEPT":z0101.DateAccept = Children(i).Data
   Case "INSERTDATE":z0101.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z0101.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z0101.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z0101.InchargeUpdate = Children(i).Data
   Case "ATTCHID":z0101.AttchID = Children(i).Data
   Case "CHECKCONFIRM":z0101.CheckConfirm = Children(i).Data
   Case "DATECONFIRM":z0101.DateConfirm = Children(i).Data
   Case "REMARKORDER":z0101.RemarkOrder = Children(i).Data
   Case "REMARKCUSTOMER":z0101.RemarkCustomer = Children(i).Data
   Case "REMARK":z0101.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0101_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K0101_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0101 As T0101_AREA, Job as String, CheckClear as Boolean, SPECNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0101_MOVE = False

Try
    If READ_PFK0101(SPECNO) = True Then
                z0101 = D0101
		K0101_MOVE = True
		else
	If CheckClear  = True then z0101 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0101")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SPECNO":z0101.SpecNo = Children(i).Code
   Case "SHOESCODE":z0101.ShoesCode = Children(i).Code
   Case "ORDERNO":z0101.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z0101.OrderNoSeq = Children(i).Code
   Case "SESPECKIND":z0101.seSpecKind = Children(i).Code
   Case "CDSPECKIND":z0101.cdSpecKind = Children(i).Code
   Case "STARTTIME":z0101.StartTime = Children(i).Code
   Case "FINISHTIME":z0101.FinishTime = Children(i).Code
   Case "DATEACCEPT":z0101.DateAccept = Children(i).Code
   Case "INSERTDATE":z0101.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z0101.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z0101.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z0101.InchargeUpdate = Children(i).Code
   Case "ATTCHID":z0101.AttchID = Children(i).Code
   Case "CHECKCONFIRM":z0101.CheckConfirm = Children(i).Code
   Case "DATECONFIRM":z0101.DateConfirm = Children(i).Code
   Case "REMARKORDER":z0101.RemarkOrder = Children(i).Code
   Case "REMARKCUSTOMER":z0101.RemarkCustomer = Children(i).Code
   Case "REMARK":z0101.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SPECNO":z0101.SpecNo = Children(i).Data
   Case "SHOESCODE":z0101.ShoesCode = Children(i).Data
   Case "ORDERNO":z0101.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z0101.OrderNoSeq = Children(i).Data
   Case "SESPECKIND":z0101.seSpecKind = Children(i).Data
   Case "CDSPECKIND":z0101.cdSpecKind = Children(i).Data
   Case "STARTTIME":z0101.StartTime = Children(i).Data
   Case "FINISHTIME":z0101.FinishTime = Children(i).Data
   Case "DATEACCEPT":z0101.DateAccept = Children(i).Data
   Case "INSERTDATE":z0101.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z0101.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z0101.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z0101.InchargeUpdate = Children(i).Data
   Case "ATTCHID":z0101.AttchID = Children(i).Data
   Case "CHECKCONFIRM":z0101.CheckConfirm = Children(i).Data
   Case "DATECONFIRM":z0101.DateConfirm = Children(i).Data
   Case "REMARKORDER":z0101.RemarkOrder = Children(i).Data
   Case "REMARKCUSTOMER":z0101.RemarkCustomer = Children(i).Data
   Case "REMARK":z0101.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0101_MOVE",vbCritical)
End Try
End Function 
    
End Module 
