'=========================================================================================================================================================
'   TABLE : (PFK3551)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K3551

Structure T3551_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	LABNo	 AS String	'			char(9)		*
Public 	LABNoSeq	 AS String	'			char(3)		*
Public 	TestOrder	 AS String	'			char(9)
Public 	TestSeq	 AS String	'			char(3)
Public 	OrderNo	 AS String	'			char(9)
Public 	OrderNoSeq	 AS String	'			char(3)
Public 	SpecStatus	 AS String	'			char(1)
Public 	SpecNo	 AS String	'			char(9)
Public 	Article	 AS String	'			nvarchar(100)
Public 	Line	 AS String	'			nvarchar(100)
Public 	SizeRange	 AS String	'			char(6)
Public 	SpeciticSize	 AS String	'			varchar(20)
Public 	QtyTest	 AS Double	'			decimal
Public 	seTestCode	 AS String	'			char(3)
Public 	cdTestCode	 AS String	'			char(3)
Public 	SupplierCode	 AS String	'			char(6)
Public 	seProductionProcess	 AS String	'			char(3)
Public 	cdProductionProcess	 AS String	'			char(3)
Public 	Remark	 AS String	'			nvarchar(500)
'=========================================================================================================================================================
End structure

Public D3551 As T3551_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK3551(LABNO AS String, LABNOSEQ AS String) As Boolean
    READ_PFK3551 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3551 "
    SQL = SQL & " WHERE K3551_LABNo		 = '" & LABNo & "' " 
    SQL = SQL & "   AND K3551_LABNoSeq		 = '" & LABNoSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D3551_CLEAR: GoTo SKIP_READ_PFK3551
                
    Call K3551_MOVE(rd)
    READ_PFK3551 = True

SKIP_READ_PFK3551:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK3551",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK3551(LABNO AS String, LABNOSEQ AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3551 "
    SQL = SQL & " WHERE K3551_LABNo		 = '" & LABNo & "' " 
    SQL = SQL & "   AND K3551_LABNoSeq		 = '" & LABNoSeq & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK3551",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK3551(z3551 As T3551_AREA) As Boolean
    WRITE_PFK3551 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z3551)
 
    SQL = " INSERT INTO PFK3551 "
    SQL = SQL & " ( "
    SQL = SQL & " K3551_LABNo," 
    SQL = SQL & " K3551_LABNoSeq," 
    SQL = SQL & " K3551_TestOrder," 
    SQL = SQL & " K3551_TestSeq," 
    SQL = SQL & " K3551_OrderNo," 
    SQL = SQL & " K3551_OrderNoSeq," 
    SQL = SQL & " K3551_SpecStatus," 
    SQL = SQL & " K3551_SpecNo," 
    SQL = SQL & " K3551_Article," 
    SQL = SQL & " K3551_Line," 
    SQL = SQL & " K3551_SizeRange," 
    SQL = SQL & " K3551_SpeciticSize," 
    SQL = SQL & " K3551_QtyTest," 
    SQL = SQL & " K3551_seTestCode," 
    SQL = SQL & " K3551_cdTestCode," 
    SQL = SQL & " K3551_SupplierCode," 
    SQL = SQL & " K3551_seProductionProcess," 
    SQL = SQL & " K3551_cdProductionProcess," 
    SQL = SQL & " K3551_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z3551.LABNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3551.LABNoSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3551.TestOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3551.TestSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3551.OrderNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3551.OrderNoSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3551.SpecStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3551.SpecNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3551.Article) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3551.Line) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3551.SizeRange) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3551.SpeciticSize) & "', "  
    SQL = SQL & "   " & FormatSQL(z3551.QtyTest) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3551.seTestCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3551.cdTestCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3551.SupplierCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3551.seProductionProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3551.cdProductionProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3551.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK3551 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK3551",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK3551(z3551 As T3551_AREA) As Boolean
    REWRITE_PFK3551 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z3551)
   
    SQL = " UPDATE PFK3551 SET "
    SQL = SQL & "    K3551_TestOrder      = N'" & FormatSQL(z3551.TestOrder) & "', " 
    SQL = SQL & "    K3551_TestSeq      = N'" & FormatSQL(z3551.TestSeq) & "', " 
    SQL = SQL & "    K3551_OrderNo      = N'" & FormatSQL(z3551.OrderNo) & "', " 
    SQL = SQL & "    K3551_OrderNoSeq      = N'" & FormatSQL(z3551.OrderNoSeq) & "', " 
    SQL = SQL & "    K3551_SpecStatus      = N'" & FormatSQL(z3551.SpecStatus) & "', " 
    SQL = SQL & "    K3551_SpecNo      = N'" & FormatSQL(z3551.SpecNo) & "', " 
    SQL = SQL & "    K3551_Article      = N'" & FormatSQL(z3551.Article) & "', " 
    SQL = SQL & "    K3551_Line      = N'" & FormatSQL(z3551.Line) & "', " 
    SQL = SQL & "    K3551_SizeRange      = N'" & FormatSQL(z3551.SizeRange) & "', " 
    SQL = SQL & "    K3551_SpeciticSize      = N'" & FormatSQL(z3551.SpeciticSize) & "', " 
    SQL = SQL & "    K3551_QtyTest      =  " & FormatSQL(z3551.QtyTest) & ", " 
    SQL = SQL & "    K3551_seTestCode      = N'" & FormatSQL(z3551.seTestCode) & "', " 
    SQL = SQL & "    K3551_cdTestCode      = N'" & FormatSQL(z3551.cdTestCode) & "', " 
    SQL = SQL & "    K3551_SupplierCode      = N'" & FormatSQL(z3551.SupplierCode) & "', " 
    SQL = SQL & "    K3551_seProductionProcess      = N'" & FormatSQL(z3551.seProductionProcess) & "', " 
    SQL = SQL & "    K3551_cdProductionProcess      = N'" & FormatSQL(z3551.cdProductionProcess) & "', " 
    SQL = SQL & "    K3551_Remark      = N'" & FormatSQL(z3551.Remark) & "'  " 
    SQL = SQL & " WHERE K3551_LABNo		 = '" & z3551.LABNo & "' " 
    SQL = SQL & "   AND K3551_LABNoSeq		 = '" & z3551.LABNoSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK3551 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK3551",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK3551(z3551 As T3551_AREA) As Boolean
    DELETE_PFK3551 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK3551 "
    SQL = SQL & " WHERE K3551_LABNo		 = '" & z3551.LABNo & "' " 
    SQL = SQL & "   AND K3551_LABNoSeq		 = '" & z3551.LABNoSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK3551 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK3551",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D3551_CLEAR()
Try
    
   D3551.LABNo = ""
   D3551.LABNoSeq = ""
   D3551.TestOrder = ""
   D3551.TestSeq = ""
   D3551.OrderNo = ""
   D3551.OrderNoSeq = ""
   D3551.SpecStatus = ""
   D3551.SpecNo = ""
   D3551.Article = ""
   D3551.Line = ""
   D3551.SizeRange = ""
   D3551.SpeciticSize = ""
    D3551.QtyTest = 0 
   D3551.seTestCode = ""
   D3551.cdTestCode = ""
   D3551.SupplierCode = ""
   D3551.seProductionProcess = ""
   D3551.cdProductionProcess = ""
   D3551.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D3551_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x3551 As T3551_AREA)
Try
    
    x3551.LABNo = trim$(  x3551.LABNo)
    x3551.LABNoSeq = trim$(  x3551.LABNoSeq)
    x3551.TestOrder = trim$(  x3551.TestOrder)
    x3551.TestSeq = trim$(  x3551.TestSeq)
    x3551.OrderNo = trim$(  x3551.OrderNo)
    x3551.OrderNoSeq = trim$(  x3551.OrderNoSeq)
    x3551.SpecStatus = trim$(  x3551.SpecStatus)
    x3551.SpecNo = trim$(  x3551.SpecNo)
    x3551.Article = trim$(  x3551.Article)
    x3551.Line = trim$(  x3551.Line)
    x3551.SizeRange = trim$(  x3551.SizeRange)
    x3551.SpeciticSize = trim$(  x3551.SpeciticSize)
    x3551.QtyTest = trim$(  x3551.QtyTest)
    x3551.seTestCode = trim$(  x3551.seTestCode)
    x3551.cdTestCode = trim$(  x3551.cdTestCode)
    x3551.SupplierCode = trim$(  x3551.SupplierCode)
    x3551.seProductionProcess = trim$(  x3551.seProductionProcess)
    x3551.cdProductionProcess = trim$(  x3551.cdProductionProcess)
    x3551.Remark = trim$(  x3551.Remark)
     
    If trim$( x3551.LABNo ) = "" Then x3551.LABNo = Space(1) 
    If trim$( x3551.LABNoSeq ) = "" Then x3551.LABNoSeq = Space(1) 
    If trim$( x3551.TestOrder ) = "" Then x3551.TestOrder = Space(1) 
    If trim$( x3551.TestSeq ) = "" Then x3551.TestSeq = Space(1) 
    If trim$( x3551.OrderNo ) = "" Then x3551.OrderNo = Space(1) 
    If trim$( x3551.OrderNoSeq ) = "" Then x3551.OrderNoSeq = Space(1) 
    If trim$( x3551.SpecStatus ) = "" Then x3551.SpecStatus = Space(1) 
    If trim$( x3551.SpecNo ) = "" Then x3551.SpecNo = Space(1) 
    If trim$( x3551.Article ) = "" Then x3551.Article = Space(1) 
    If trim$( x3551.Line ) = "" Then x3551.Line = Space(1) 
    If trim$( x3551.SizeRange ) = "" Then x3551.SizeRange = Space(1) 
    If trim$( x3551.SpeciticSize ) = "" Then x3551.SpeciticSize = Space(1) 
    If trim$( x3551.QtyTest ) = "" Then x3551.QtyTest = 0 
    If trim$( x3551.seTestCode ) = "" Then x3551.seTestCode = Space(1) 
    If trim$( x3551.cdTestCode ) = "" Then x3551.cdTestCode = Space(1) 
    If trim$( x3551.SupplierCode ) = "" Then x3551.SupplierCode = Space(1) 
    If trim$( x3551.seProductionProcess ) = "" Then x3551.seProductionProcess = Space(1) 
    If trim$( x3551.cdProductionProcess ) = "" Then x3551.cdProductionProcess = Space(1) 
    If trim$( x3551.Remark ) = "" Then x3551.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K3551_MOVE(rs3551 As SqlClient.SqlDataReader)
Try

    call D3551_CLEAR()   

    If IsdbNull(rs3551!K3551_LABNo) = False Then D3551.LABNo = Trim$(rs3551!K3551_LABNo)
    If IsdbNull(rs3551!K3551_LABNoSeq) = False Then D3551.LABNoSeq = Trim$(rs3551!K3551_LABNoSeq)
    If IsdbNull(rs3551!K3551_TestOrder) = False Then D3551.TestOrder = Trim$(rs3551!K3551_TestOrder)
    If IsdbNull(rs3551!K3551_TestSeq) = False Then D3551.TestSeq = Trim$(rs3551!K3551_TestSeq)
    If IsdbNull(rs3551!K3551_OrderNo) = False Then D3551.OrderNo = Trim$(rs3551!K3551_OrderNo)
    If IsdbNull(rs3551!K3551_OrderNoSeq) = False Then D3551.OrderNoSeq = Trim$(rs3551!K3551_OrderNoSeq)
    If IsdbNull(rs3551!K3551_SpecStatus) = False Then D3551.SpecStatus = Trim$(rs3551!K3551_SpecStatus)
    If IsdbNull(rs3551!K3551_SpecNo) = False Then D3551.SpecNo = Trim$(rs3551!K3551_SpecNo)
    If IsdbNull(rs3551!K3551_Article) = False Then D3551.Article = Trim$(rs3551!K3551_Article)
    If IsdbNull(rs3551!K3551_Line) = False Then D3551.Line = Trim$(rs3551!K3551_Line)
    If IsdbNull(rs3551!K3551_SizeRange) = False Then D3551.SizeRange = Trim$(rs3551!K3551_SizeRange)
    If IsdbNull(rs3551!K3551_SpeciticSize) = False Then D3551.SpeciticSize = Trim$(rs3551!K3551_SpeciticSize)
    If IsdbNull(rs3551!K3551_QtyTest) = False Then D3551.QtyTest = Trim$(rs3551!K3551_QtyTest)
    If IsdbNull(rs3551!K3551_seTestCode) = False Then D3551.seTestCode = Trim$(rs3551!K3551_seTestCode)
    If IsdbNull(rs3551!K3551_cdTestCode) = False Then D3551.cdTestCode = Trim$(rs3551!K3551_cdTestCode)
    If IsdbNull(rs3551!K3551_SupplierCode) = False Then D3551.SupplierCode = Trim$(rs3551!K3551_SupplierCode)
    If IsdbNull(rs3551!K3551_seProductionProcess) = False Then D3551.seProductionProcess = Trim$(rs3551!K3551_seProductionProcess)
    If IsdbNull(rs3551!K3551_cdProductionProcess) = False Then D3551.cdProductionProcess = Trim$(rs3551!K3551_cdProductionProcess)
    If IsdbNull(rs3551!K3551_Remark) = False Then D3551.Remark = Trim$(rs3551!K3551_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3551_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K3551_MOVE(rs3551 As DataRow)
Try

    call D3551_CLEAR()   

    If IsdbNull(rs3551!K3551_LABNo) = False Then D3551.LABNo = Trim$(rs3551!K3551_LABNo)
    If IsdbNull(rs3551!K3551_LABNoSeq) = False Then D3551.LABNoSeq = Trim$(rs3551!K3551_LABNoSeq)
    If IsdbNull(rs3551!K3551_TestOrder) = False Then D3551.TestOrder = Trim$(rs3551!K3551_TestOrder)
    If IsdbNull(rs3551!K3551_TestSeq) = False Then D3551.TestSeq = Trim$(rs3551!K3551_TestSeq)
    If IsdbNull(rs3551!K3551_OrderNo) = False Then D3551.OrderNo = Trim$(rs3551!K3551_OrderNo)
    If IsdbNull(rs3551!K3551_OrderNoSeq) = False Then D3551.OrderNoSeq = Trim$(rs3551!K3551_OrderNoSeq)
    If IsdbNull(rs3551!K3551_SpecStatus) = False Then D3551.SpecStatus = Trim$(rs3551!K3551_SpecStatus)
    If IsdbNull(rs3551!K3551_SpecNo) = False Then D3551.SpecNo = Trim$(rs3551!K3551_SpecNo)
    If IsdbNull(rs3551!K3551_Article) = False Then D3551.Article = Trim$(rs3551!K3551_Article)
    If IsdbNull(rs3551!K3551_Line) = False Then D3551.Line = Trim$(rs3551!K3551_Line)
    If IsdbNull(rs3551!K3551_SizeRange) = False Then D3551.SizeRange = Trim$(rs3551!K3551_SizeRange)
    If IsdbNull(rs3551!K3551_SpeciticSize) = False Then D3551.SpeciticSize = Trim$(rs3551!K3551_SpeciticSize)
    If IsdbNull(rs3551!K3551_QtyTest) = False Then D3551.QtyTest = Trim$(rs3551!K3551_QtyTest)
    If IsdbNull(rs3551!K3551_seTestCode) = False Then D3551.seTestCode = Trim$(rs3551!K3551_seTestCode)
    If IsdbNull(rs3551!K3551_cdTestCode) = False Then D3551.cdTestCode = Trim$(rs3551!K3551_cdTestCode)
    If IsdbNull(rs3551!K3551_SupplierCode) = False Then D3551.SupplierCode = Trim$(rs3551!K3551_SupplierCode)
    If IsdbNull(rs3551!K3551_seProductionProcess) = False Then D3551.seProductionProcess = Trim$(rs3551!K3551_seProductionProcess)
    If IsdbNull(rs3551!K3551_cdProductionProcess) = False Then D3551.cdProductionProcess = Trim$(rs3551!K3551_cdProductionProcess)
    If IsdbNull(rs3551!K3551_Remark) = False Then D3551.Remark = Trim$(rs3551!K3551_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3551_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K3551_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3551 As T3551_AREA, LABNO AS String, LABNOSEQ AS String) as Boolean

K3551_MOVE = False

Try
    If READ_PFK3551(LABNO, LABNOSEQ) = True Then
                z3551 = D3551
		K3551_MOVE = True
		else
	z3551 = nothing
     End If

     If  getColumIndex(spr,"LABNo") > -1 then z3551.LABNo = getDataM(spr, getColumIndex(spr,"LABNo"), xRow)
     If  getColumIndex(spr,"LABNoSeq") > -1 then z3551.LABNoSeq = getDataM(spr, getColumIndex(spr,"LABNoSeq"), xRow)
     If  getColumIndex(spr,"TestOrder") > -1 then z3551.TestOrder = getDataM(spr, getColumIndex(spr,"TestOrder"), xRow)
     If  getColumIndex(spr,"TestSeq") > -1 then z3551.TestSeq = getDataM(spr, getColumIndex(spr,"TestSeq"), xRow)
     If  getColumIndex(spr,"OrderNo") > -1 then z3551.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"OrderNoSeq") > -1 then z3551.OrderNoSeq = getDataM(spr, getColumIndex(spr,"OrderNoSeq"), xRow)
     If  getColumIndex(spr,"SpecStatus") > -1 then z3551.SpecStatus = getDataM(spr, getColumIndex(spr,"SpecStatus"), xRow)
     If  getColumIndex(spr,"SpecNo") > -1 then z3551.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"Article") > -1 then z3551.Article = getDataM(spr, getColumIndex(spr,"Article"), xRow)
     If  getColumIndex(spr,"Line") > -1 then z3551.Line = getDataM(spr, getColumIndex(spr,"Line"), xRow)
     If  getColumIndex(spr,"SizeRange") > -1 then z3551.SizeRange = getDataM(spr, getColumIndex(spr,"SizeRange"), xRow)
     If  getColumIndex(spr,"SpeciticSize") > -1 then z3551.SpeciticSize = getDataM(spr, getColumIndex(spr,"SpeciticSize"), xRow)
     If  getColumIndex(spr,"QtyTest") > -1 then z3551.QtyTest = getDataM(spr, getColumIndex(spr,"QtyTest"), xRow)
     If  getColumIndex(spr,"seTestCode") > -1 then z3551.seTestCode = getDataM(spr, getColumIndex(spr,"seTestCode"), xRow)
     If  getColumIndex(spr,"cdTestCode") > -1 then z3551.cdTestCode = getDataM(spr, getColumIndex(spr,"cdTestCode"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z3551.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"seProductionProcess") > -1 then z3551.seProductionProcess = getDataM(spr, getColumIndex(spr,"seProductionProcess"), xRow)
     If  getColumIndex(spr,"cdProductionProcess") > -1 then z3551.cdProductionProcess = getDataM(spr, getColumIndex(spr,"cdProductionProcess"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z3551.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3551_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K3551_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3551 As T3551_AREA,CheckClear as Boolean,LABNO AS String, LABNOSEQ AS String) as Boolean

K3551_MOVE = False

Try
    If READ_PFK3551(LABNO, LABNOSEQ) = True Then
                z3551 = D3551
		K3551_MOVE = True
		else
	If CheckClear  = True then z3551 = nothing
     End If

     If  getColumIndex(spr,"LABNo") > -1 then z3551.LABNo = getDataM(spr, getColumIndex(spr,"LABNo"), xRow)
     If  getColumIndex(spr,"LABNoSeq") > -1 then z3551.LABNoSeq = getDataM(spr, getColumIndex(spr,"LABNoSeq"), xRow)
     If  getColumIndex(spr,"TestOrder") > -1 then z3551.TestOrder = getDataM(spr, getColumIndex(spr,"TestOrder"), xRow)
     If  getColumIndex(spr,"TestSeq") > -1 then z3551.TestSeq = getDataM(spr, getColumIndex(spr,"TestSeq"), xRow)
     If  getColumIndex(spr,"OrderNo") > -1 then z3551.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"OrderNoSeq") > -1 then z3551.OrderNoSeq = getDataM(spr, getColumIndex(spr,"OrderNoSeq"), xRow)
     If  getColumIndex(spr,"SpecStatus") > -1 then z3551.SpecStatus = getDataM(spr, getColumIndex(spr,"SpecStatus"), xRow)
     If  getColumIndex(spr,"SpecNo") > -1 then z3551.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"Article") > -1 then z3551.Article = getDataM(spr, getColumIndex(spr,"Article"), xRow)
     If  getColumIndex(spr,"Line") > -1 then z3551.Line = getDataM(spr, getColumIndex(spr,"Line"), xRow)
     If  getColumIndex(spr,"SizeRange") > -1 then z3551.SizeRange = getDataM(spr, getColumIndex(spr,"SizeRange"), xRow)
     If  getColumIndex(spr,"SpeciticSize") > -1 then z3551.SpeciticSize = getDataM(spr, getColumIndex(spr,"SpeciticSize"), xRow)
     If  getColumIndex(spr,"QtyTest") > -1 then z3551.QtyTest = getDataM(spr, getColumIndex(spr,"QtyTest"), xRow)
     If  getColumIndex(spr,"seTestCode") > -1 then z3551.seTestCode = getDataM(spr, getColumIndex(spr,"seTestCode"), xRow)
     If  getColumIndex(spr,"cdTestCode") > -1 then z3551.cdTestCode = getDataM(spr, getColumIndex(spr,"cdTestCode"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z3551.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"seProductionProcess") > -1 then z3551.seProductionProcess = getDataM(spr, getColumIndex(spr,"seProductionProcess"), xRow)
     If  getColumIndex(spr,"cdProductionProcess") > -1 then z3551.cdProductionProcess = getDataM(spr, getColumIndex(spr,"cdProductionProcess"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z3551.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3551_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K3551_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3551 As T3551_AREA, Job as String, LABNO AS String, LABNOSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3551_MOVE = False

Try
    If READ_PFK3551(LABNO, LABNOSEQ) = True Then
                z3551 = D3551
		K3551_MOVE = True
		else
	z3551 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3551")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "LABNO":z3551.LABNo = Children(i).Code
   Case "LABNOSEQ":z3551.LABNoSeq = Children(i).Code
   Case "TESTORDER":z3551.TestOrder = Children(i).Code
   Case "TESTSEQ":z3551.TestSeq = Children(i).Code
   Case "ORDERNO":z3551.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z3551.OrderNoSeq = Children(i).Code
   Case "SPECSTATUS":z3551.SpecStatus = Children(i).Code
   Case "SPECNO":z3551.SpecNo = Children(i).Code
   Case "ARTICLE":z3551.Article = Children(i).Code
   Case "LINE":z3551.Line = Children(i).Code
   Case "SIZERANGE":z3551.SizeRange = Children(i).Code
   Case "SPECITICSIZE":z3551.SpeciticSize = Children(i).Code
   Case "QTYTEST":z3551.QtyTest = Children(i).Code
   Case "SETESTCODE":z3551.seTestCode = Children(i).Code
   Case "CDTESTCODE":z3551.cdTestCode = Children(i).Code
   Case "SUPPLIERCODE":z3551.SupplierCode = Children(i).Code
   Case "SEPRODUCTIONPROCESS":z3551.seProductionProcess = Children(i).Code
   Case "CDPRODUCTIONPROCESS":z3551.cdProductionProcess = Children(i).Code
   Case "REMARK":z3551.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "LABNO":z3551.LABNo = Children(i).Data
   Case "LABNOSEQ":z3551.LABNoSeq = Children(i).Data
   Case "TESTORDER":z3551.TestOrder = Children(i).Data
   Case "TESTSEQ":z3551.TestSeq = Children(i).Data
   Case "ORDERNO":z3551.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z3551.OrderNoSeq = Children(i).Data
   Case "SPECSTATUS":z3551.SpecStatus = Children(i).Data
   Case "SPECNO":z3551.SpecNo = Children(i).Data
   Case "ARTICLE":z3551.Article = Children(i).Data
   Case "LINE":z3551.Line = Children(i).Data
   Case "SIZERANGE":z3551.SizeRange = Children(i).Data
   Case "SPECITICSIZE":z3551.SpeciticSize = Children(i).Data
   Case "QTYTEST":z3551.QtyTest = Children(i).Data
   Case "SETESTCODE":z3551.seTestCode = Children(i).Data
   Case "CDTESTCODE":z3551.cdTestCode = Children(i).Data
   Case "SUPPLIERCODE":z3551.SupplierCode = Children(i).Data
   Case "SEPRODUCTIONPROCESS":z3551.seProductionProcess = Children(i).Data
   Case "CDPRODUCTIONPROCESS":z3551.cdProductionProcess = Children(i).Data
   Case "REMARK":z3551.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3551_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K3551_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3551 As T3551_AREA, Job as String, CheckClear as Boolean, LABNO AS String, LABNOSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3551_MOVE = False

Try
    If READ_PFK3551(LABNO, LABNOSEQ) = True Then
                z3551 = D3551
		K3551_MOVE = True
		else
	If CheckClear  = True then z3551 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3551")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "LABNO":z3551.LABNo = Children(i).Code
   Case "LABNOSEQ":z3551.LABNoSeq = Children(i).Code
   Case "TESTORDER":z3551.TestOrder = Children(i).Code
   Case "TESTSEQ":z3551.TestSeq = Children(i).Code
   Case "ORDERNO":z3551.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z3551.OrderNoSeq = Children(i).Code
   Case "SPECSTATUS":z3551.SpecStatus = Children(i).Code
   Case "SPECNO":z3551.SpecNo = Children(i).Code
   Case "ARTICLE":z3551.Article = Children(i).Code
   Case "LINE":z3551.Line = Children(i).Code
   Case "SIZERANGE":z3551.SizeRange = Children(i).Code
   Case "SPECITICSIZE":z3551.SpeciticSize = Children(i).Code
   Case "QTYTEST":z3551.QtyTest = Children(i).Code
   Case "SETESTCODE":z3551.seTestCode = Children(i).Code
   Case "CDTESTCODE":z3551.cdTestCode = Children(i).Code
   Case "SUPPLIERCODE":z3551.SupplierCode = Children(i).Code
   Case "SEPRODUCTIONPROCESS":z3551.seProductionProcess = Children(i).Code
   Case "CDPRODUCTIONPROCESS":z3551.cdProductionProcess = Children(i).Code
   Case "REMARK":z3551.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "LABNO":z3551.LABNo = Children(i).Data
   Case "LABNOSEQ":z3551.LABNoSeq = Children(i).Data
   Case "TESTORDER":z3551.TestOrder = Children(i).Data
   Case "TESTSEQ":z3551.TestSeq = Children(i).Data
   Case "ORDERNO":z3551.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z3551.OrderNoSeq = Children(i).Data
   Case "SPECSTATUS":z3551.SpecStatus = Children(i).Data
   Case "SPECNO":z3551.SpecNo = Children(i).Data
   Case "ARTICLE":z3551.Article = Children(i).Data
   Case "LINE":z3551.Line = Children(i).Data
   Case "SIZERANGE":z3551.SizeRange = Children(i).Data
   Case "SPECITICSIZE":z3551.SpeciticSize = Children(i).Data
   Case "QTYTEST":z3551.QtyTest = Children(i).Data
   Case "SETESTCODE":z3551.seTestCode = Children(i).Data
   Case "CDTESTCODE":z3551.cdTestCode = Children(i).Data
   Case "SUPPLIERCODE":z3551.SupplierCode = Children(i).Data
   Case "SEPRODUCTIONPROCESS":z3551.seProductionProcess = Children(i).Data
   Case "CDPRODUCTIONPROCESS":z3551.cdProductionProcess = Children(i).Data
   Case "REMARK":z3551.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3551_MOVE",vbCritical)
End Try
End Function 
    
End Module 
