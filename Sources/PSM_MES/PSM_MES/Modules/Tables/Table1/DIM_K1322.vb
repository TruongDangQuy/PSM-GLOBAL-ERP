'=========================================================================================================================================================
'   TABLE : (PFK1322)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K1322

Structure T1322_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	MatchingAutoKey	 AS String	'			char(8)		*
Public 	MatchingDate	 AS String	'			char(8)
Public 	MatchingTime	 AS String	'			char(14)
Public 	InchargeMatching	 AS String	'			char(8)
Public 	OrderNo	 AS String	'			char(9)
Public 	OrderNoSeq	 AS String	'			char(3)
Public 	ShoesCode	 AS String	'			char(6)
Public 	ShoesMatching	 AS String	'			char(6)
Public 	QtyMatching	 AS Double	'			decimal
Public 	SpeciticSize	 AS String	'			nvarchar(4)
Public 	DateSize	 AS String	'			char(8)
'=========================================================================================================================================================
End structure

Public D1322 As T1322_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK1322(MATCHINGAUTOKEY AS String) As Boolean
    READ_PFK1322 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK1322 "
    SQL = SQL & " WHERE K1322_MatchingAutoKey		 = '" & MatchingAutoKey & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D1322_CLEAR: GoTo SKIP_READ_PFK1322
                
    Call K1322_MOVE(rd)
    READ_PFK1322 = True

SKIP_READ_PFK1322:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK1322",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK1322(MATCHINGAUTOKEY AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK1322 "
    SQL = SQL & " WHERE K1322_MatchingAutoKey		 = '" & MatchingAutoKey & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK1322",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK1322(z1322 As T1322_AREA) As Boolean
    WRITE_PFK1322 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z1322)
 
    SQL = " INSERT INTO PFK1322 "
    SQL = SQL & " ( "
    SQL = SQL & " K1322_MatchingAutoKey," 
    SQL = SQL & " K1322_MatchingDate," 
    SQL = SQL & " K1322_MatchingTime," 
    SQL = SQL & " K1322_InchargeMatching," 
    SQL = SQL & " K1322_OrderNo," 
    SQL = SQL & " K1322_OrderNoSeq," 
    SQL = SQL & " K1322_ShoesCode," 
    SQL = SQL & " K1322_ShoesMatching," 
    SQL = SQL & " K1322_QtyMatching," 
    SQL = SQL & " K1322_SpeciticSize," 
    SQL = SQL & " K1322_DateSize " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z1322.MatchingAutoKey) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1322.MatchingDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1322.MatchingTime) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1322.InchargeMatching) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1322.OrderNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1322.OrderNoSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1322.ShoesCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1322.ShoesMatching) & "', "  
    SQL = SQL & "   " & FormatSQL(z1322.QtyMatching) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z1322.SpeciticSize) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1322.DateSize) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK1322 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK1322",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK1322(z1322 As T1322_AREA) As Boolean
    REWRITE_PFK1322 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z1322)
   
    SQL = " UPDATE PFK1322 SET "
    SQL = SQL & "    K1322_MatchingDate      = N'" & FormatSQL(z1322.MatchingDate) & "', " 
    SQL = SQL & "    K1322_MatchingTime      = N'" & FormatSQL(z1322.MatchingTime) & "', " 
    SQL = SQL & "    K1322_InchargeMatching      = N'" & FormatSQL(z1322.InchargeMatching) & "', " 
    SQL = SQL & "    K1322_OrderNo      = N'" & FormatSQL(z1322.OrderNo) & "', " 
    SQL = SQL & "    K1322_OrderNoSeq      = N'" & FormatSQL(z1322.OrderNoSeq) & "', " 
    SQL = SQL & "    K1322_ShoesCode      = N'" & FormatSQL(z1322.ShoesCode) & "', " 
    SQL = SQL & "    K1322_ShoesMatching      = N'" & FormatSQL(z1322.ShoesMatching) & "', " 
    SQL = SQL & "    K1322_QtyMatching      =  " & FormatSQL(z1322.QtyMatching) & ", " 
    SQL = SQL & "    K1322_SpeciticSize      = N'" & FormatSQL(z1322.SpeciticSize) & "', " 
    SQL = SQL & "    K1322_DateSize      = N'" & FormatSQL(z1322.DateSize) & "'  " 
    SQL = SQL & " WHERE K1322_MatchingAutoKey		 = '" & z1322.MatchingAutoKey & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK1322 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK1322",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK1322(z1322 As T1322_AREA) As Boolean
    DELETE_PFK1322 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK1322 "
    SQL = SQL & " WHERE K1322_MatchingAutoKey		 = '" & z1322.MatchingAutoKey & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK1322 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK1322",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D1322_CLEAR()
Try
    
   D1322.MatchingAutoKey = ""
   D1322.MatchingDate = ""
   D1322.MatchingTime = ""
   D1322.InchargeMatching = ""
   D1322.OrderNo = ""
   D1322.OrderNoSeq = ""
   D1322.ShoesCode = ""
   D1322.ShoesMatching = ""
    D1322.QtyMatching = 0 
   D1322.SpeciticSize = ""
   D1322.DateSize = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D1322_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x1322 As T1322_AREA)
Try
    
    x1322.MatchingAutoKey = trim$(  x1322.MatchingAutoKey)
    x1322.MatchingDate = trim$(  x1322.MatchingDate)
    x1322.MatchingTime = trim$(  x1322.MatchingTime)
    x1322.InchargeMatching = trim$(  x1322.InchargeMatching)
    x1322.OrderNo = trim$(  x1322.OrderNo)
    x1322.OrderNoSeq = trim$(  x1322.OrderNoSeq)
    x1322.ShoesCode = trim$(  x1322.ShoesCode)
    x1322.ShoesMatching = trim$(  x1322.ShoesMatching)
    x1322.QtyMatching = trim$(  x1322.QtyMatching)
    x1322.SpeciticSize = trim$(  x1322.SpeciticSize)
    x1322.DateSize = trim$(  x1322.DateSize)
     
    If trim$( x1322.MatchingAutoKey ) = "" Then x1322.MatchingAutoKey = Space(1) 
    If trim$( x1322.MatchingDate ) = "" Then x1322.MatchingDate = Space(1) 
    If trim$( x1322.MatchingTime ) = "" Then x1322.MatchingTime = Space(1) 
    If trim$( x1322.InchargeMatching ) = "" Then x1322.InchargeMatching = Space(1) 
    If trim$( x1322.OrderNo ) = "" Then x1322.OrderNo = Space(1) 
    If trim$( x1322.OrderNoSeq ) = "" Then x1322.OrderNoSeq = Space(1) 
    If trim$( x1322.ShoesCode ) = "" Then x1322.ShoesCode = Space(1) 
    If trim$( x1322.ShoesMatching ) = "" Then x1322.ShoesMatching = Space(1) 
    If trim$( x1322.QtyMatching ) = "" Then x1322.QtyMatching = 0 
    If trim$( x1322.SpeciticSize ) = "" Then x1322.SpeciticSize = Space(1) 
    If trim$( x1322.DateSize ) = "" Then x1322.DateSize = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K1322_MOVE(rs1322 As SqlClient.SqlDataReader)
Try

    call D1322_CLEAR()   

    If IsdbNull(rs1322!K1322_MatchingAutoKey) = False Then D1322.MatchingAutoKey = Trim$(rs1322!K1322_MatchingAutoKey)
    If IsdbNull(rs1322!K1322_MatchingDate) = False Then D1322.MatchingDate = Trim$(rs1322!K1322_MatchingDate)
    If IsdbNull(rs1322!K1322_MatchingTime) = False Then D1322.MatchingTime = Trim$(rs1322!K1322_MatchingTime)
    If IsdbNull(rs1322!K1322_InchargeMatching) = False Then D1322.InchargeMatching = Trim$(rs1322!K1322_InchargeMatching)
    If IsdbNull(rs1322!K1322_OrderNo) = False Then D1322.OrderNo = Trim$(rs1322!K1322_OrderNo)
    If IsdbNull(rs1322!K1322_OrderNoSeq) = False Then D1322.OrderNoSeq = Trim$(rs1322!K1322_OrderNoSeq)
    If IsdbNull(rs1322!K1322_ShoesCode) = False Then D1322.ShoesCode = Trim$(rs1322!K1322_ShoesCode)
    If IsdbNull(rs1322!K1322_ShoesMatching) = False Then D1322.ShoesMatching = Trim$(rs1322!K1322_ShoesMatching)
    If IsdbNull(rs1322!K1322_QtyMatching) = False Then D1322.QtyMatching = Trim$(rs1322!K1322_QtyMatching)
    If IsdbNull(rs1322!K1322_SpeciticSize) = False Then D1322.SpeciticSize = Trim$(rs1322!K1322_SpeciticSize)
    If IsdbNull(rs1322!K1322_DateSize) = False Then D1322.DateSize = Trim$(rs1322!K1322_DateSize)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K1322_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K1322_MOVE(rs1322 As DataRow)
Try

    call D1322_CLEAR()   

    If IsdbNull(rs1322!K1322_MatchingAutoKey) = False Then D1322.MatchingAutoKey = Trim$(rs1322!K1322_MatchingAutoKey)
    If IsdbNull(rs1322!K1322_MatchingDate) = False Then D1322.MatchingDate = Trim$(rs1322!K1322_MatchingDate)
    If IsdbNull(rs1322!K1322_MatchingTime) = False Then D1322.MatchingTime = Trim$(rs1322!K1322_MatchingTime)
    If IsdbNull(rs1322!K1322_InchargeMatching) = False Then D1322.InchargeMatching = Trim$(rs1322!K1322_InchargeMatching)
    If IsdbNull(rs1322!K1322_OrderNo) = False Then D1322.OrderNo = Trim$(rs1322!K1322_OrderNo)
    If IsdbNull(rs1322!K1322_OrderNoSeq) = False Then D1322.OrderNoSeq = Trim$(rs1322!K1322_OrderNoSeq)
    If IsdbNull(rs1322!K1322_ShoesCode) = False Then D1322.ShoesCode = Trim$(rs1322!K1322_ShoesCode)
    If IsdbNull(rs1322!K1322_ShoesMatching) = False Then D1322.ShoesMatching = Trim$(rs1322!K1322_ShoesMatching)
    If IsdbNull(rs1322!K1322_QtyMatching) = False Then D1322.QtyMatching = Trim$(rs1322!K1322_QtyMatching)
    If IsdbNull(rs1322!K1322_SpeciticSize) = False Then D1322.SpeciticSize = Trim$(rs1322!K1322_SpeciticSize)
    If IsdbNull(rs1322!K1322_DateSize) = False Then D1322.DateSize = Trim$(rs1322!K1322_DateSize)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K1322_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K1322_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z1322 As T1322_AREA, MATCHINGAUTOKEY AS String) as Boolean

K1322_MOVE = False

Try
    If READ_PFK1322(MATCHINGAUTOKEY) = True Then
                z1322 = D1322
		K1322_MOVE = True
		else
	z1322 = nothing
     End If

     If  getColumIndex(spr,"MatchingAutoKey") > -1 then z1322.MatchingAutoKey = getDataM(spr, getColumIndex(spr,"MatchingAutoKey"), xRow)
     If  getColumIndex(spr,"MatchingDate") > -1 then z1322.MatchingDate = getDataM(spr, getColumIndex(spr,"MatchingDate"), xRow)
     If  getColumIndex(spr,"MatchingTime") > -1 then z1322.MatchingTime = getDataM(spr, getColumIndex(spr,"MatchingTime"), xRow)
     If  getColumIndex(spr,"InchargeMatching") > -1 then z1322.InchargeMatching = getDataM(spr, getColumIndex(spr,"InchargeMatching"), xRow)
     If  getColumIndex(spr,"OrderNo") > -1 then z1322.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"OrderNoSeq") > -1 then z1322.OrderNoSeq = getDataM(spr, getColumIndex(spr,"OrderNoSeq"), xRow)
     If  getColumIndex(spr,"ShoesCode") > -1 then z1322.ShoesCode = getDataM(spr, getColumIndex(spr,"ShoesCode"), xRow)
     If  getColumIndex(spr,"ShoesMatching") > -1 then z1322.ShoesMatching = getDataM(spr, getColumIndex(spr,"ShoesMatching"), xRow)
     If  getColumIndex(spr,"QtyMatching") > -1 then z1322.QtyMatching = getDataM(spr, getColumIndex(spr,"QtyMatching"), xRow)
     If  getColumIndex(spr,"SpeciticSize") > -1 then z1322.SpeciticSize = getDataM(spr, getColumIndex(spr,"SpeciticSize"), xRow)
     If  getColumIndex(spr,"DateSize") > -1 then z1322.DateSize = getDataM(spr, getColumIndex(spr,"DateSize"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K1322_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K1322_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z1322 As T1322_AREA,CheckClear as Boolean,MATCHINGAUTOKEY AS String) as Boolean

K1322_MOVE = False

Try
    If READ_PFK1322(MATCHINGAUTOKEY) = True Then
                z1322 = D1322
		K1322_MOVE = True
		else
	If CheckClear  = True then z1322 = nothing
     End If

     If  getColumIndex(spr,"MatchingAutoKey") > -1 then z1322.MatchingAutoKey = getDataM(spr, getColumIndex(spr,"MatchingAutoKey"), xRow)
     If  getColumIndex(spr,"MatchingDate") > -1 then z1322.MatchingDate = getDataM(spr, getColumIndex(spr,"MatchingDate"), xRow)
     If  getColumIndex(spr,"MatchingTime") > -1 then z1322.MatchingTime = getDataM(spr, getColumIndex(spr,"MatchingTime"), xRow)
     If  getColumIndex(spr,"InchargeMatching") > -1 then z1322.InchargeMatching = getDataM(spr, getColumIndex(spr,"InchargeMatching"), xRow)
     If  getColumIndex(spr,"OrderNo") > -1 then z1322.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"OrderNoSeq") > -1 then z1322.OrderNoSeq = getDataM(spr, getColumIndex(spr,"OrderNoSeq"), xRow)
     If  getColumIndex(spr,"ShoesCode") > -1 then z1322.ShoesCode = getDataM(spr, getColumIndex(spr,"ShoesCode"), xRow)
     If  getColumIndex(spr,"ShoesMatching") > -1 then z1322.ShoesMatching = getDataM(spr, getColumIndex(spr,"ShoesMatching"), xRow)
     If  getColumIndex(spr,"QtyMatching") > -1 then z1322.QtyMatching = getDataM(spr, getColumIndex(spr,"QtyMatching"), xRow)
     If  getColumIndex(spr,"SpeciticSize") > -1 then z1322.SpeciticSize = getDataM(spr, getColumIndex(spr,"SpeciticSize"), xRow)
     If  getColumIndex(spr,"DateSize") > -1 then z1322.DateSize = getDataM(spr, getColumIndex(spr,"DateSize"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K1322_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K1322_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z1322 As T1322_AREA, Job as String, MATCHINGAUTOKEY AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K1322_MOVE = False

Try
    If READ_PFK1322(MATCHINGAUTOKEY) = True Then
                z1322 = D1322
		K1322_MOVE = True
		else
	z1322 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1322")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "MATCHINGAUTOKEY":z1322.MatchingAutoKey = Children(i).Code
   Case "MATCHINGDATE":z1322.MatchingDate = Children(i).Code
   Case "MATCHINGTIME":z1322.MatchingTime = Children(i).Code
   Case "INCHARGEMATCHING":z1322.InchargeMatching = Children(i).Code
   Case "ORDERNO":z1322.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z1322.OrderNoSeq = Children(i).Code
   Case "SHOESCODE":z1322.ShoesCode = Children(i).Code
   Case "SHOESMATCHING":z1322.ShoesMatching = Children(i).Code
   Case "QTYMATCHING":z1322.QtyMatching = Children(i).Code
   Case "SPECITICSIZE":z1322.SpeciticSize = Children(i).Code
   Case "DATESIZE":z1322.DateSize = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "MATCHINGAUTOKEY":z1322.MatchingAutoKey = Children(i).Data
   Case "MATCHINGDATE":z1322.MatchingDate = Children(i).Data
   Case "MATCHINGTIME":z1322.MatchingTime = Children(i).Data
   Case "INCHARGEMATCHING":z1322.InchargeMatching = Children(i).Data
   Case "ORDERNO":z1322.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z1322.OrderNoSeq = Children(i).Data
   Case "SHOESCODE":z1322.ShoesCode = Children(i).Data
   Case "SHOESMATCHING":z1322.ShoesMatching = Children(i).Data
   Case "QTYMATCHING":z1322.QtyMatching = Children(i).Data
   Case "SPECITICSIZE":z1322.SpeciticSize = Children(i).Data
   Case "DATESIZE":z1322.DateSize = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K1322_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K1322_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z1322 As T1322_AREA, Job as String, CheckClear as Boolean, MATCHINGAUTOKEY AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K1322_MOVE = False

Try
    If READ_PFK1322(MATCHINGAUTOKEY) = True Then
                z1322 = D1322
		K1322_MOVE = True
		else
	If CheckClear  = True then z1322 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1322")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "MATCHINGAUTOKEY":z1322.MatchingAutoKey = Children(i).Code
   Case "MATCHINGDATE":z1322.MatchingDate = Children(i).Code
   Case "MATCHINGTIME":z1322.MatchingTime = Children(i).Code
   Case "INCHARGEMATCHING":z1322.InchargeMatching = Children(i).Code
   Case "ORDERNO":z1322.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z1322.OrderNoSeq = Children(i).Code
   Case "SHOESCODE":z1322.ShoesCode = Children(i).Code
   Case "SHOESMATCHING":z1322.ShoesMatching = Children(i).Code
   Case "QTYMATCHING":z1322.QtyMatching = Children(i).Code
   Case "SPECITICSIZE":z1322.SpeciticSize = Children(i).Code
   Case "DATESIZE":z1322.DateSize = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "MATCHINGAUTOKEY":z1322.MatchingAutoKey = Children(i).Data
   Case "MATCHINGDATE":z1322.MatchingDate = Children(i).Data
   Case "MATCHINGTIME":z1322.MatchingTime = Children(i).Data
   Case "INCHARGEMATCHING":z1322.InchargeMatching = Children(i).Data
   Case "ORDERNO":z1322.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z1322.OrderNoSeq = Children(i).Data
   Case "SHOESCODE":z1322.ShoesCode = Children(i).Data
   Case "SHOESMATCHING":z1322.ShoesMatching = Children(i).Data
   Case "QTYMATCHING":z1322.QtyMatching = Children(i).Data
   Case "SPECITICSIZE":z1322.SpeciticSize = Children(i).Data
   Case "DATESIZE":z1322.DateSize = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K1322_MOVE",vbCritical)
End Try
End Function 
    
End Module 
