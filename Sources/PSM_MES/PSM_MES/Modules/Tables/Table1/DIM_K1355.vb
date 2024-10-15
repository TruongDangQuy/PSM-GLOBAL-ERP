'=========================================================================================================================================================
'   TABLE : (PFK1355)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K1355

Structure T1355_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	OrderNo	 AS String	'			char(9)		*
Public 	OrderNoSeq	 AS String	'			char(3)		*
Public 	Szno	 AS String	'			char(2)		*
Public 	Dseq	 AS Double	'			decimal		*
Public 	cdFOBPrice	 AS String	'			char(3)		*
Public 	FOBType	 AS String	'			char(1)
Public 	seFOBPrice	 AS String	'			char(3)
Public 	PriceFOB	 AS Double	'			decimal
'=========================================================================================================================================================
End structure

Public D1355 As T1355_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK1355(ORDERNO AS String, ORDERNOSEQ AS String, SZNO AS String, DSEQ AS Double, CDFOBPRICE AS String) As Boolean
    READ_PFK1355 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK1355 "
    SQL = SQL & " WHERE K1355_OrderNo		 = '" & OrderNo & "' " 
    SQL = SQL & "   AND K1355_OrderNoSeq		 = '" & OrderNoSeq & "' " 
    SQL = SQL & "   AND K1355_Szno		 = '" & Szno & "' " 
    SQL = SQL & "   AND K1355_Dseq		 =  " & Dseq & "  " 
    SQL = SQL & "   AND K1355_cdFOBPrice		 = '" & cdFOBPrice & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D1355_CLEAR: GoTo SKIP_READ_PFK1355
                
    Call K1355_MOVE(rd)
    READ_PFK1355 = True

SKIP_READ_PFK1355:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK1355",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK1355(ORDERNO AS String, ORDERNOSEQ AS String, SZNO AS String, DSEQ AS Double, CDFOBPRICE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK1355 "
    SQL = SQL & " WHERE K1355_OrderNo		 = '" & OrderNo & "' " 
    SQL = SQL & "   AND K1355_OrderNoSeq		 = '" & OrderNoSeq & "' " 
    SQL = SQL & "   AND K1355_Szno		 = '" & Szno & "' " 
    SQL = SQL & "   AND K1355_Dseq		 =  " & Dseq & "  " 
    SQL = SQL & "   AND K1355_cdFOBPrice		 = '" & cdFOBPrice & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK1355",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK1355(z1355 As T1355_AREA) As Boolean
    WRITE_PFK1355 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z1355)
 
    SQL = " INSERT INTO PFK1355 "
    SQL = SQL & " ( "
    SQL = SQL & " K1355_OrderNo," 
    SQL = SQL & " K1355_OrderNoSeq," 
    SQL = SQL & " K1355_Szno," 
    SQL = SQL & " K1355_Dseq," 
    SQL = SQL & " K1355_cdFOBPrice," 
    SQL = SQL & " K1355_FOBType," 
    SQL = SQL & " K1355_seFOBPrice," 
    SQL = SQL & " K1355_PriceFOB " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z1355.OrderNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1355.OrderNoSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1355.Szno) & "', "  
    SQL = SQL & "   " & FormatSQL(z1355.Dseq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z1355.cdFOBPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1355.FOBType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1355.seFOBPrice) & "', "  
    SQL = SQL & "   " & FormatSQL(z1355.PriceFOB) & "  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK1355 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK1355",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK1355(z1355 As T1355_AREA) As Boolean
    REWRITE_PFK1355 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z1355)
   
    SQL = " UPDATE PFK1355 SET "
    SQL = SQL & "    K1355_FOBType      = N'" & FormatSQL(z1355.FOBType) & "', " 
    SQL = SQL & "    K1355_seFOBPrice      = N'" & FormatSQL(z1355.seFOBPrice) & "', " 
    SQL = SQL & "    K1355_PriceFOB      =  " & FormatSQL(z1355.PriceFOB) & "  " 
    SQL = SQL & " WHERE K1355_OrderNo		 = '" & z1355.OrderNo & "' " 
    SQL = SQL & "   AND K1355_OrderNoSeq		 = '" & z1355.OrderNoSeq & "' " 
    SQL = SQL & "   AND K1355_Szno		 = '" & z1355.Szno & "' " 
    SQL = SQL & "   AND K1355_Dseq		 =  " & z1355.Dseq & "  " 
    SQL = SQL & "   AND K1355_cdFOBPrice		 = '" & z1355.cdFOBPrice & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK1355 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK1355",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK1355(z1355 As T1355_AREA) As Boolean
    DELETE_PFK1355 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK1355 "
    SQL = SQL & " WHERE K1355_OrderNo		 = '" & z1355.OrderNo & "' " 
    SQL = SQL & "   AND K1355_OrderNoSeq		 = '" & z1355.OrderNoSeq & "' " 
    SQL = SQL & "   AND K1355_Szno		 = '" & z1355.Szno & "' " 
    SQL = SQL & "   AND K1355_Dseq		 =  " & z1355.Dseq & "  " 
    SQL = SQL & "   AND K1355_cdFOBPrice		 = '" & z1355.cdFOBPrice & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK1355 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK1355",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D1355_CLEAR()
Try
    
   D1355.OrderNo = ""
   D1355.OrderNoSeq = ""
   D1355.Szno = ""
    D1355.Dseq = 0 
   D1355.cdFOBPrice = ""
   D1355.FOBType = ""
   D1355.seFOBPrice = ""
    D1355.PriceFOB = 0 

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D1355_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x1355 As T1355_AREA)
Try
    
    x1355.OrderNo = trim$(  x1355.OrderNo)
    x1355.OrderNoSeq = trim$(  x1355.OrderNoSeq)
    x1355.Szno = trim$(  x1355.Szno)
    x1355.Dseq = trim$(  x1355.Dseq)
    x1355.cdFOBPrice = trim$(  x1355.cdFOBPrice)
    x1355.FOBType = trim$(  x1355.FOBType)
    x1355.seFOBPrice = trim$(  x1355.seFOBPrice)
    x1355.PriceFOB = trim$(  x1355.PriceFOB)
     
    If trim$( x1355.OrderNo ) = "" Then x1355.OrderNo = Space(1) 
    If trim$( x1355.OrderNoSeq ) = "" Then x1355.OrderNoSeq = Space(1) 
    If trim$( x1355.Szno ) = "" Then x1355.Szno = Space(1) 
    If trim$( x1355.Dseq ) = "" Then x1355.Dseq = 0 
    If trim$( x1355.cdFOBPrice ) = "" Then x1355.cdFOBPrice = Space(1) 
    If trim$( x1355.FOBType ) = "" Then x1355.FOBType = Space(1) 
    If trim$( x1355.seFOBPrice ) = "" Then x1355.seFOBPrice = Space(1) 
    If trim$( x1355.PriceFOB ) = "" Then x1355.PriceFOB = 0 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K1355_MOVE(rs1355 As SqlClient.SqlDataReader)
Try

    call D1355_CLEAR()   

    If IsdbNull(rs1355!K1355_OrderNo) = False Then D1355.OrderNo = Trim$(rs1355!K1355_OrderNo)
    If IsdbNull(rs1355!K1355_OrderNoSeq) = False Then D1355.OrderNoSeq = Trim$(rs1355!K1355_OrderNoSeq)
    If IsdbNull(rs1355!K1355_Szno) = False Then D1355.Szno = Trim$(rs1355!K1355_Szno)
    If IsdbNull(rs1355!K1355_Dseq) = False Then D1355.Dseq = Trim$(rs1355!K1355_Dseq)
    If IsdbNull(rs1355!K1355_cdFOBPrice) = False Then D1355.cdFOBPrice = Trim$(rs1355!K1355_cdFOBPrice)
    If IsdbNull(rs1355!K1355_FOBType) = False Then D1355.FOBType = Trim$(rs1355!K1355_FOBType)
    If IsdbNull(rs1355!K1355_seFOBPrice) = False Then D1355.seFOBPrice = Trim$(rs1355!K1355_seFOBPrice)
    If IsdbNull(rs1355!K1355_PriceFOB) = False Then D1355.PriceFOB = Trim$(rs1355!K1355_PriceFOB)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K1355_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K1355_MOVE(rs1355 As DataRow)
Try

    call D1355_CLEAR()   

    If IsdbNull(rs1355!K1355_OrderNo) = False Then D1355.OrderNo = Trim$(rs1355!K1355_OrderNo)
    If IsdbNull(rs1355!K1355_OrderNoSeq) = False Then D1355.OrderNoSeq = Trim$(rs1355!K1355_OrderNoSeq)
    If IsdbNull(rs1355!K1355_Szno) = False Then D1355.Szno = Trim$(rs1355!K1355_Szno)
    If IsdbNull(rs1355!K1355_Dseq) = False Then D1355.Dseq = Trim$(rs1355!K1355_Dseq)
    If IsdbNull(rs1355!K1355_cdFOBPrice) = False Then D1355.cdFOBPrice = Trim$(rs1355!K1355_cdFOBPrice)
    If IsdbNull(rs1355!K1355_FOBType) = False Then D1355.FOBType = Trim$(rs1355!K1355_FOBType)
    If IsdbNull(rs1355!K1355_seFOBPrice) = False Then D1355.seFOBPrice = Trim$(rs1355!K1355_seFOBPrice)
    If IsdbNull(rs1355!K1355_PriceFOB) = False Then D1355.PriceFOB = Trim$(rs1355!K1355_PriceFOB)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K1355_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K1355_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z1355 As T1355_AREA, ORDERNO AS String, ORDERNOSEQ AS String, SZNO AS String, DSEQ AS Double, CDFOBPRICE AS String) as Boolean

K1355_MOVE = False

Try
    If READ_PFK1355(ORDERNO, ORDERNOSEQ, SZNO, DSEQ, CDFOBPRICE) = True Then
                z1355 = D1355
		K1355_MOVE = True
		else
	z1355 = nothing
     End If

     If  getColumIndex(spr,"OrderNo") > -1 then z1355.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"OrderNoSeq") > -1 then z1355.OrderNoSeq = getDataM(spr, getColumIndex(spr,"OrderNoSeq"), xRow)
     If  getColumIndex(spr,"Szno") > -1 then z1355.Szno = getDataM(spr, getColumIndex(spr,"Szno"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z1355.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"cdFOBPrice") > -1 then z1355.cdFOBPrice = getDataM(spr, getColumIndex(spr,"cdFOBPrice"), xRow)
     If  getColumIndex(spr,"FOBType") > -1 then z1355.FOBType = getDataM(spr, getColumIndex(spr,"FOBType"), xRow)
     If  getColumIndex(spr,"seFOBPrice") > -1 then z1355.seFOBPrice = getDataM(spr, getColumIndex(spr,"seFOBPrice"), xRow)
     If  getColumIndex(spr,"PriceFOB") > -1 then z1355.PriceFOB = getDataM(spr, getColumIndex(spr,"PriceFOB"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K1355_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K1355_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z1355 As T1355_AREA,CheckClear as Boolean,ORDERNO AS String, ORDERNOSEQ AS String, SZNO AS String, DSEQ AS Double, CDFOBPRICE AS String) as Boolean

K1355_MOVE = False

Try
    If READ_PFK1355(ORDERNO, ORDERNOSEQ, SZNO, DSEQ, CDFOBPRICE) = True Then
                z1355 = D1355
		K1355_MOVE = True
		else
	If CheckClear  = True then z1355 = nothing
     End If

     If  getColumIndex(spr,"OrderNo") > -1 then z1355.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"OrderNoSeq") > -1 then z1355.OrderNoSeq = getDataM(spr, getColumIndex(spr,"OrderNoSeq"), xRow)
     If  getColumIndex(spr,"Szno") > -1 then z1355.Szno = getDataM(spr, getColumIndex(spr,"Szno"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z1355.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"cdFOBPrice") > -1 then z1355.cdFOBPrice = getDataM(spr, getColumIndex(spr,"cdFOBPrice"), xRow)
     If  getColumIndex(spr,"FOBType") > -1 then z1355.FOBType = getDataM(spr, getColumIndex(spr,"FOBType"), xRow)
     If  getColumIndex(spr,"seFOBPrice") > -1 then z1355.seFOBPrice = getDataM(spr, getColumIndex(spr,"seFOBPrice"), xRow)
     If  getColumIndex(spr,"PriceFOB") > -1 then z1355.PriceFOB = getDataM(spr, getColumIndex(spr,"PriceFOB"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K1355_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K1355_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z1355 As T1355_AREA, Job as String, ORDERNO AS String, ORDERNOSEQ AS String, SZNO AS String, DSEQ AS Double, CDFOBPRICE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K1355_MOVE = False

Try
    If READ_PFK1355(ORDERNO, ORDERNOSEQ, SZNO, DSEQ, CDFOBPRICE) = True Then
                z1355 = D1355
		K1355_MOVE = True
		else
	z1355 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1355")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "ORDERNO":z1355.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z1355.OrderNoSeq = Children(i).Code
   Case "SZNO":z1355.Szno = Children(i).Code
   Case "DSEQ":z1355.Dseq = Children(i).Code
   Case "CDFOBPRICE":z1355.cdFOBPrice = Children(i).Code
   Case "FOBTYPE":z1355.FOBType = Children(i).Code
   Case "SEFOBPRICE":z1355.seFOBPrice = Children(i).Code
   Case "PRICEFOB":z1355.PriceFOB = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "ORDERNO":z1355.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z1355.OrderNoSeq = Children(i).Data
   Case "SZNO":z1355.Szno = Children(i).Data
   Case "DSEQ":z1355.Dseq = Children(i).Data
   Case "CDFOBPRICE":z1355.cdFOBPrice = Children(i).Data
   Case "FOBTYPE":z1355.FOBType = Children(i).Data
   Case "SEFOBPRICE":z1355.seFOBPrice = Children(i).Data
   Case "PRICEFOB":z1355.PriceFOB = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K1355_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K1355_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z1355 As T1355_AREA, Job as String, CheckClear as Boolean, ORDERNO AS String, ORDERNOSEQ AS String, SZNO AS String, DSEQ AS Double, CDFOBPRICE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K1355_MOVE = False

Try
    If READ_PFK1355(ORDERNO, ORDERNOSEQ, SZNO, DSEQ, CDFOBPRICE) = True Then
                z1355 = D1355
		K1355_MOVE = True
		else
	If CheckClear  = True then z1355 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1355")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "ORDERNO":z1355.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z1355.OrderNoSeq = Children(i).Code
   Case "SZNO":z1355.Szno = Children(i).Code
   Case "DSEQ":z1355.Dseq = Children(i).Code
   Case "CDFOBPRICE":z1355.cdFOBPrice = Children(i).Code
   Case "FOBTYPE":z1355.FOBType = Children(i).Code
   Case "SEFOBPRICE":z1355.seFOBPrice = Children(i).Code
   Case "PRICEFOB":z1355.PriceFOB = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "ORDERNO":z1355.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z1355.OrderNoSeq = Children(i).Data
   Case "SZNO":z1355.Szno = Children(i).Data
   Case "DSEQ":z1355.Dseq = Children(i).Data
   Case "CDFOBPRICE":z1355.cdFOBPrice = Children(i).Data
   Case "FOBTYPE":z1355.FOBType = Children(i).Data
   Case "SEFOBPRICE":z1355.seFOBPrice = Children(i).Data
   Case "PRICEFOB":z1355.PriceFOB = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K1355_MOVE",vbCritical)
End Try
End Function 
    
End Module 
