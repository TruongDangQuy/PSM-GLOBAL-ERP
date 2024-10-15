'=========================================================================================================================================================
'   TABLE : (PFK1321)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K1321

Structure T1321_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	TestOrder	 AS String	'			char(9)		*
Public 	TestSeq	 AS String	'			char(3)		*
Public 	OrderNo	 AS String	'			char(9)
Public 	OrderNoSeq	 AS String	'			char(3)
Public 	TestQty	 AS Double	'			decimal
Public 	DateTest	 AS String	'			char(8)
Public 	seTestCode	 AS String	'			char(3)
Public 	cdTestCode	 AS String	'			char(3)
Public 	SupplierCode	 AS String	'			char(6)
Public 	seProductionProcess	 AS String	'			char(3)
Public 	cdProductionProcess	 AS String	'			char(3)
Public 	TestStatus	 AS String	'			char(1)
Public 	Remark	 AS String	'			nvarchar(500)
'=========================================================================================================================================================
End structure

Public D1321 As T1321_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK1321(TESTORDER AS String, TESTSEQ AS String) As Boolean
    READ_PFK1321 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK1321 "
    SQL = SQL & " WHERE K1321_TestOrder		 = '" & TestOrder & "' " 
    SQL = SQL & "   AND K1321_TestSeq		 = '" & TestSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D1321_CLEAR: GoTo SKIP_READ_PFK1321
                
    Call K1321_MOVE(rd)
    READ_PFK1321 = True

SKIP_READ_PFK1321:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK1321",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK1321(TESTORDER AS String, TESTSEQ AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK1321 "
    SQL = SQL & " WHERE K1321_TestOrder		 = '" & TestOrder & "' " 
    SQL = SQL & "   AND K1321_TestSeq		 = '" & TestSeq & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK1321",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK1321(z1321 As T1321_AREA) As Boolean
    WRITE_PFK1321 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z1321)
 
    SQL = " INSERT INTO PFK1321 "
    SQL = SQL & " ( "
    SQL = SQL & " K1321_TestOrder," 
    SQL = SQL & " K1321_TestSeq," 
    SQL = SQL & " K1321_OrderNo," 
    SQL = SQL & " K1321_OrderNoSeq," 
    SQL = SQL & " K1321_TestQty," 
    SQL = SQL & " K1321_DateTest," 
    SQL = SQL & " K1321_seTestCode," 
    SQL = SQL & " K1321_cdTestCode," 
    SQL = SQL & " K1321_SupplierCode," 
    SQL = SQL & " K1321_seProductionProcess," 
    SQL = SQL & " K1321_cdProductionProcess," 
    SQL = SQL & " K1321_TestStatus," 
    SQL = SQL & " K1321_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z1321.TestOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1321.TestSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1321.OrderNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1321.OrderNoSeq) & "', "  
    SQL = SQL & "   " & FormatSQL(z1321.TestQty) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z1321.DateTest) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1321.seTestCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1321.cdTestCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1321.SupplierCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1321.seProductionProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1321.cdProductionProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1321.TestStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1321.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK1321 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK1321",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK1321(z1321 As T1321_AREA) As Boolean
    REWRITE_PFK1321 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z1321)
   
    SQL = " UPDATE PFK1321 SET "
    SQL = SQL & "    K1321_OrderNo      = N'" & FormatSQL(z1321.OrderNo) & "', " 
    SQL = SQL & "    K1321_OrderNoSeq      = N'" & FormatSQL(z1321.OrderNoSeq) & "', " 
    SQL = SQL & "    K1321_TestQty      =  " & FormatSQL(z1321.TestQty) & ", " 
    SQL = SQL & "    K1321_DateTest      = N'" & FormatSQL(z1321.DateTest) & "', " 
    SQL = SQL & "    K1321_seTestCode      = N'" & FormatSQL(z1321.seTestCode) & "', " 
    SQL = SQL & "    K1321_cdTestCode      = N'" & FormatSQL(z1321.cdTestCode) & "', " 
    SQL = SQL & "    K1321_SupplierCode      = N'" & FormatSQL(z1321.SupplierCode) & "', " 
    SQL = SQL & "    K1321_seProductionProcess      = N'" & FormatSQL(z1321.seProductionProcess) & "', " 
    SQL = SQL & "    K1321_cdProductionProcess      = N'" & FormatSQL(z1321.cdProductionProcess) & "', " 
    SQL = SQL & "    K1321_TestStatus      = N'" & FormatSQL(z1321.TestStatus) & "', " 
    SQL = SQL & "    K1321_Remark      = N'" & FormatSQL(z1321.Remark) & "'  " 
    SQL = SQL & " WHERE K1321_TestOrder		 = '" & z1321.TestOrder & "' " 
    SQL = SQL & "   AND K1321_TestSeq		 = '" & z1321.TestSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK1321 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK1321",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK1321(z1321 As T1321_AREA) As Boolean
    DELETE_PFK1321 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK1321 "
    SQL = SQL & " WHERE K1321_TestOrder		 = '" & z1321.TestOrder & "' " 
    SQL = SQL & "   AND K1321_TestSeq		 = '" & z1321.TestSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK1321 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK1321",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D1321_CLEAR()
Try
    
   D1321.TestOrder = ""
   D1321.TestSeq = ""
   D1321.OrderNo = ""
   D1321.OrderNoSeq = ""
    D1321.TestQty = 0 
   D1321.DateTest = ""
   D1321.seTestCode = ""
   D1321.cdTestCode = ""
   D1321.SupplierCode = ""
   D1321.seProductionProcess = ""
   D1321.cdProductionProcess = ""
   D1321.TestStatus = ""
   D1321.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D1321_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x1321 As T1321_AREA)
Try
    
    x1321.TestOrder = trim$(  x1321.TestOrder)
    x1321.TestSeq = trim$(  x1321.TestSeq)
    x1321.OrderNo = trim$(  x1321.OrderNo)
    x1321.OrderNoSeq = trim$(  x1321.OrderNoSeq)
    x1321.TestQty = trim$(  x1321.TestQty)
    x1321.DateTest = trim$(  x1321.DateTest)
    x1321.seTestCode = trim$(  x1321.seTestCode)
    x1321.cdTestCode = trim$(  x1321.cdTestCode)
    x1321.SupplierCode = trim$(  x1321.SupplierCode)
    x1321.seProductionProcess = trim$(  x1321.seProductionProcess)
    x1321.cdProductionProcess = trim$(  x1321.cdProductionProcess)
    x1321.TestStatus = trim$(  x1321.TestStatus)
    x1321.Remark = trim$(  x1321.Remark)
     
    If trim$( x1321.TestOrder ) = "" Then x1321.TestOrder = Space(1) 
    If trim$( x1321.TestSeq ) = "" Then x1321.TestSeq = Space(1) 
    If trim$( x1321.OrderNo ) = "" Then x1321.OrderNo = Space(1) 
    If trim$( x1321.OrderNoSeq ) = "" Then x1321.OrderNoSeq = Space(1) 
    If trim$( x1321.TestQty ) = "" Then x1321.TestQty = 0 
    If trim$( x1321.DateTest ) = "" Then x1321.DateTest = Space(1) 
    If trim$( x1321.seTestCode ) = "" Then x1321.seTestCode = Space(1) 
    If trim$( x1321.cdTestCode ) = "" Then x1321.cdTestCode = Space(1) 
    If trim$( x1321.SupplierCode ) = "" Then x1321.SupplierCode = Space(1) 
    If trim$( x1321.seProductionProcess ) = "" Then x1321.seProductionProcess = Space(1) 
    If trim$( x1321.cdProductionProcess ) = "" Then x1321.cdProductionProcess = Space(1) 
    If trim$( x1321.TestStatus ) = "" Then x1321.TestStatus = Space(1) 
    If trim$( x1321.Remark ) = "" Then x1321.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K1321_MOVE(rs1321 As SqlClient.SqlDataReader)
Try

    call D1321_CLEAR()   

    If IsdbNull(rs1321!K1321_TestOrder) = False Then D1321.TestOrder = Trim$(rs1321!K1321_TestOrder)
    If IsdbNull(rs1321!K1321_TestSeq) = False Then D1321.TestSeq = Trim$(rs1321!K1321_TestSeq)
    If IsdbNull(rs1321!K1321_OrderNo) = False Then D1321.OrderNo = Trim$(rs1321!K1321_OrderNo)
    If IsdbNull(rs1321!K1321_OrderNoSeq) = False Then D1321.OrderNoSeq = Trim$(rs1321!K1321_OrderNoSeq)
    If IsdbNull(rs1321!K1321_TestQty) = False Then D1321.TestQty = Trim$(rs1321!K1321_TestQty)
    If IsdbNull(rs1321!K1321_DateTest) = False Then D1321.DateTest = Trim$(rs1321!K1321_DateTest)
    If IsdbNull(rs1321!K1321_seTestCode) = False Then D1321.seTestCode = Trim$(rs1321!K1321_seTestCode)
    If IsdbNull(rs1321!K1321_cdTestCode) = False Then D1321.cdTestCode = Trim$(rs1321!K1321_cdTestCode)
    If IsdbNull(rs1321!K1321_SupplierCode) = False Then D1321.SupplierCode = Trim$(rs1321!K1321_SupplierCode)
    If IsdbNull(rs1321!K1321_seProductionProcess) = False Then D1321.seProductionProcess = Trim$(rs1321!K1321_seProductionProcess)
    If IsdbNull(rs1321!K1321_cdProductionProcess) = False Then D1321.cdProductionProcess = Trim$(rs1321!K1321_cdProductionProcess)
    If IsdbNull(rs1321!K1321_TestStatus) = False Then D1321.TestStatus = Trim$(rs1321!K1321_TestStatus)
    If IsdbNull(rs1321!K1321_Remark) = False Then D1321.Remark = Trim$(rs1321!K1321_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K1321_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K1321_MOVE(rs1321 As DataRow)
Try

    call D1321_CLEAR()   

    If IsdbNull(rs1321!K1321_TestOrder) = False Then D1321.TestOrder = Trim$(rs1321!K1321_TestOrder)
    If IsdbNull(rs1321!K1321_TestSeq) = False Then D1321.TestSeq = Trim$(rs1321!K1321_TestSeq)
    If IsdbNull(rs1321!K1321_OrderNo) = False Then D1321.OrderNo = Trim$(rs1321!K1321_OrderNo)
    If IsdbNull(rs1321!K1321_OrderNoSeq) = False Then D1321.OrderNoSeq = Trim$(rs1321!K1321_OrderNoSeq)
    If IsdbNull(rs1321!K1321_TestQty) = False Then D1321.TestQty = Trim$(rs1321!K1321_TestQty)
    If IsdbNull(rs1321!K1321_DateTest) = False Then D1321.DateTest = Trim$(rs1321!K1321_DateTest)
    If IsdbNull(rs1321!K1321_seTestCode) = False Then D1321.seTestCode = Trim$(rs1321!K1321_seTestCode)
    If IsdbNull(rs1321!K1321_cdTestCode) = False Then D1321.cdTestCode = Trim$(rs1321!K1321_cdTestCode)
    If IsdbNull(rs1321!K1321_SupplierCode) = False Then D1321.SupplierCode = Trim$(rs1321!K1321_SupplierCode)
    If IsdbNull(rs1321!K1321_seProductionProcess) = False Then D1321.seProductionProcess = Trim$(rs1321!K1321_seProductionProcess)
    If IsdbNull(rs1321!K1321_cdProductionProcess) = False Then D1321.cdProductionProcess = Trim$(rs1321!K1321_cdProductionProcess)
    If IsdbNull(rs1321!K1321_TestStatus) = False Then D1321.TestStatus = Trim$(rs1321!K1321_TestStatus)
    If IsdbNull(rs1321!K1321_Remark) = False Then D1321.Remark = Trim$(rs1321!K1321_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K1321_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K1321_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z1321 As T1321_AREA, TESTORDER AS String, TESTSEQ AS String) as Boolean

K1321_MOVE = False

Try
    If READ_PFK1321(TESTORDER, TESTSEQ) = True Then
                z1321 = D1321
		K1321_MOVE = True
		else
	z1321 = nothing
     End If

     If  getColumIndex(spr,"TestOrder") > -1 then z1321.TestOrder = getDataM(spr, getColumIndex(spr,"TestOrder"), xRow)
     If  getColumIndex(spr,"TestSeq") > -1 then z1321.TestSeq = getDataM(spr, getColumIndex(spr,"TestSeq"), xRow)
     If  getColumIndex(spr,"OrderNo") > -1 then z1321.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"OrderNoSeq") > -1 then z1321.OrderNoSeq = getDataM(spr, getColumIndex(spr,"OrderNoSeq"), xRow)
     If  getColumIndex(spr,"TestQty") > -1 then z1321.TestQty = getDataM(spr, getColumIndex(spr,"TestQty"), xRow)
     If  getColumIndex(spr,"DateTest") > -1 then z1321.DateTest = getDataM(spr, getColumIndex(spr,"DateTest"), xRow)
     If  getColumIndex(spr,"seTestCode") > -1 then z1321.seTestCode = getDataM(spr, getColumIndex(spr,"seTestCode"), xRow)
     If  getColumIndex(spr,"cdTestCode") > -1 then z1321.cdTestCode = getDataM(spr, getColumIndex(spr,"cdTestCode"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z1321.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"seProductionProcess") > -1 then z1321.seProductionProcess = getDataM(spr, getColumIndex(spr,"seProductionProcess"), xRow)
     If  getColumIndex(spr,"cdProductionProcess") > -1 then z1321.cdProductionProcess = getDataM(spr, getColumIndex(spr,"cdProductionProcess"), xRow)
     If  getColumIndex(spr,"TestStatus") > -1 then z1321.TestStatus = getDataM(spr, getColumIndex(spr,"TestStatus"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z1321.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K1321_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K1321_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z1321 As T1321_AREA,CheckClear as Boolean,TESTORDER AS String, TESTSEQ AS String) as Boolean

K1321_MOVE = False

Try
    If READ_PFK1321(TESTORDER, TESTSEQ) = True Then
                z1321 = D1321
		K1321_MOVE = True
		else
	If CheckClear  = True then z1321 = nothing
     End If

     If  getColumIndex(spr,"TestOrder") > -1 then z1321.TestOrder = getDataM(spr, getColumIndex(spr,"TestOrder"), xRow)
     If  getColumIndex(spr,"TestSeq") > -1 then z1321.TestSeq = getDataM(spr, getColumIndex(spr,"TestSeq"), xRow)
     If  getColumIndex(spr,"OrderNo") > -1 then z1321.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"OrderNoSeq") > -1 then z1321.OrderNoSeq = getDataM(spr, getColumIndex(spr,"OrderNoSeq"), xRow)
     If  getColumIndex(spr,"TestQty") > -1 then z1321.TestQty = getDataM(spr, getColumIndex(spr,"TestQty"), xRow)
     If  getColumIndex(spr,"DateTest") > -1 then z1321.DateTest = getDataM(spr, getColumIndex(spr,"DateTest"), xRow)
     If  getColumIndex(spr,"seTestCode") > -1 then z1321.seTestCode = getDataM(spr, getColumIndex(spr,"seTestCode"), xRow)
     If  getColumIndex(spr,"cdTestCode") > -1 then z1321.cdTestCode = getDataM(spr, getColumIndex(spr,"cdTestCode"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z1321.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"seProductionProcess") > -1 then z1321.seProductionProcess = getDataM(spr, getColumIndex(spr,"seProductionProcess"), xRow)
     If  getColumIndex(spr,"cdProductionProcess") > -1 then z1321.cdProductionProcess = getDataM(spr, getColumIndex(spr,"cdProductionProcess"), xRow)
     If  getColumIndex(spr,"TestStatus") > -1 then z1321.TestStatus = getDataM(spr, getColumIndex(spr,"TestStatus"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z1321.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K1321_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K1321_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z1321 As T1321_AREA, Job as String, TESTORDER AS String, TESTSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K1321_MOVE = False

Try
    If READ_PFK1321(TESTORDER, TESTSEQ) = True Then
                z1321 = D1321
		K1321_MOVE = True
		else
	z1321 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1321")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "TESTORDER":z1321.TestOrder = Children(i).Code
   Case "TESTSEQ":z1321.TestSeq = Children(i).Code
   Case "ORDERNO":z1321.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z1321.OrderNoSeq = Children(i).Code
   Case "TESTQTY":z1321.TestQty = Children(i).Code
   Case "DATETEST":z1321.DateTest = Children(i).Code
   Case "SETESTCODE":z1321.seTestCode = Children(i).Code
   Case "CDTESTCODE":z1321.cdTestCode = Children(i).Code
   Case "SUPPLIERCODE":z1321.SupplierCode = Children(i).Code
   Case "SEPRODUCTIONPROCESS":z1321.seProductionProcess = Children(i).Code
   Case "CDPRODUCTIONPROCESS":z1321.cdProductionProcess = Children(i).Code
   Case "TESTSTATUS":z1321.TestStatus = Children(i).Code
   Case "REMARK":z1321.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "TESTORDER":z1321.TestOrder = Children(i).Data
   Case "TESTSEQ":z1321.TestSeq = Children(i).Data
   Case "ORDERNO":z1321.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z1321.OrderNoSeq = Children(i).Data
   Case "TESTQTY":z1321.TestQty = Children(i).Data
   Case "DATETEST":z1321.DateTest = Children(i).Data
   Case "SETESTCODE":z1321.seTestCode = Children(i).Data
   Case "CDTESTCODE":z1321.cdTestCode = Children(i).Data
   Case "SUPPLIERCODE":z1321.SupplierCode = Children(i).Data
   Case "SEPRODUCTIONPROCESS":z1321.seProductionProcess = Children(i).Data
   Case "CDPRODUCTIONPROCESS":z1321.cdProductionProcess = Children(i).Data
   Case "TESTSTATUS":z1321.TestStatus = Children(i).Data
   Case "REMARK":z1321.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K1321_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K1321_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z1321 As T1321_AREA, Job as String, CheckClear as Boolean, TESTORDER AS String, TESTSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K1321_MOVE = False

Try
    If READ_PFK1321(TESTORDER, TESTSEQ) = True Then
                z1321 = D1321
		K1321_MOVE = True
		else
	If CheckClear  = True then z1321 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1321")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "TESTORDER":z1321.TestOrder = Children(i).Code
   Case "TESTSEQ":z1321.TestSeq = Children(i).Code
   Case "ORDERNO":z1321.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z1321.OrderNoSeq = Children(i).Code
   Case "TESTQTY":z1321.TestQty = Children(i).Code
   Case "DATETEST":z1321.DateTest = Children(i).Code
   Case "SETESTCODE":z1321.seTestCode = Children(i).Code
   Case "CDTESTCODE":z1321.cdTestCode = Children(i).Code
   Case "SUPPLIERCODE":z1321.SupplierCode = Children(i).Code
   Case "SEPRODUCTIONPROCESS":z1321.seProductionProcess = Children(i).Code
   Case "CDPRODUCTIONPROCESS":z1321.cdProductionProcess = Children(i).Code
   Case "TESTSTATUS":z1321.TestStatus = Children(i).Code
   Case "REMARK":z1321.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "TESTORDER":z1321.TestOrder = Children(i).Data
   Case "TESTSEQ":z1321.TestSeq = Children(i).Data
   Case "ORDERNO":z1321.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z1321.OrderNoSeq = Children(i).Data
   Case "TESTQTY":z1321.TestQty = Children(i).Data
   Case "DATETEST":z1321.DateTest = Children(i).Data
   Case "SETESTCODE":z1321.seTestCode = Children(i).Data
   Case "CDTESTCODE":z1321.cdTestCode = Children(i).Data
   Case "SUPPLIERCODE":z1321.SupplierCode = Children(i).Data
   Case "SEPRODUCTIONPROCESS":z1321.seProductionProcess = Children(i).Data
   Case "CDPRODUCTIONPROCESS":z1321.cdProductionProcess = Children(i).Data
   Case "TESTSTATUS":z1321.TestStatus = Children(i).Data
   Case "REMARK":z1321.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K1321_MOVE",vbCritical)
End Try
End Function 
    
End Module 
