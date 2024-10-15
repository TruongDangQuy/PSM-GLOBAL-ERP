'=========================================================================================================================================================
'   TABLE : (PFK7226)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7226

Structure T7226_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	ExpenseYY	 AS String	'			char(4)		*
Public 	ExpenseMM	 AS String	'			char(2)		*
Public 	ExpenseCode	 AS String	'			char(3)		*
Public 	PriceWeaving	 AS Double	'			decimal
Public 	PriceDyeing	 AS Double	'			decimal
Public 	PriceSpecial	 AS Double	'			decimal
'=========================================================================================================================================================
End structure

Public D7226 As T7226_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7226(EXPENSEYY AS String, EXPENSEMM AS String, EXPENSECODE AS String) As Boolean
    READ_PFK7226 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7226 "
    SQL = SQL & " WHERE K7226_ExpenseYY		 = '" & ExpenseYY & "' " 
    SQL = SQL & "   AND K7226_ExpenseMM		 = '" & ExpenseMM & "' " 
    SQL = SQL & "   AND K7226_ExpenseCode		 = '" & ExpenseCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7226_CLEAR: GoTo SKIP_READ_PFK7226
                
    Call K7226_MOVE(rd)
    READ_PFK7226 = True

SKIP_READ_PFK7226:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7226",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7226(EXPENSEYY AS String, EXPENSEMM AS String, EXPENSECODE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7226 "
    SQL = SQL & " WHERE K7226_ExpenseYY		 = '" & ExpenseYY & "' " 
    SQL = SQL & "   AND K7226_ExpenseMM		 = '" & ExpenseMM & "' " 
    SQL = SQL & "   AND K7226_ExpenseCode		 = '" & ExpenseCode & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7226",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7226(z7226 As T7226_AREA) As Boolean
    WRITE_PFK7226 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7226)
 
    SQL = " INSERT INTO PFK7226 "
    SQL = SQL & " ( "
    SQL = SQL & " K7226_ExpenseYY," 
    SQL = SQL & " K7226_ExpenseMM," 
    SQL = SQL & " K7226_ExpenseCode," 
    SQL = SQL & " K7226_PriceWeaving," 
    SQL = SQL & " K7226_PriceDyeing," 
    SQL = SQL & " K7226_PriceSpecial " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  '" & z7226.ExpenseYY & "', "  
    SQL = SQL & "  '" & z7226.ExpenseMM & "', "  
    SQL = SQL & "  '" & z7226.ExpenseCode & "', "  
    SQL = SQL & "   " & z7226.PriceWeaving & " , "  
    SQL = SQL & "   " & z7226.PriceDyeing & " , "  
    SQL = SQL & "   " & z7226.PriceSpecial & "   "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7226 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7226",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7226(z7226 As T7226_AREA) As Boolean
    REWRITE_PFK7226 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7226)
   
    SQL = " UPDATE PFK7226 SET "
    SQL = SQL & "    K7226_PriceWeaving      =  " & z7226.PriceWeaving & " , " 
    SQL = SQL & "    K7226_PriceDyeing      =  " & z7226.PriceDyeing & " , " 
    SQL = SQL & "    K7226_PriceSpecial      =  " & z7226.PriceSpecial & "   " 
    SQL = SQL & " WHERE K7226_ExpenseYY		 = '" & z7226.ExpenseYY & "' " 
    SQL = SQL & "   AND K7226_ExpenseMM		 = '" & z7226.ExpenseMM & "' " 
    SQL = SQL & "   AND K7226_ExpenseCode		 = '" & z7226.ExpenseCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7226 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7226",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7226(z7226 As T7226_AREA) As Boolean
    DELETE_PFK7226 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7226 "
    SQL = SQL & " WHERE K7226_ExpenseYY		 = '" & z7226.ExpenseYY & "' " 
    SQL = SQL & "   AND K7226_ExpenseMM		 = '" & z7226.ExpenseMM & "' " 
    SQL = SQL & "   AND K7226_ExpenseCode		 = '" & z7226.ExpenseCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7226 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7226",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7226_CLEAR()
Try
    
   D7226.ExpenseYY = ""
   D7226.ExpenseMM = ""
   D7226.ExpenseCode = ""
    D7226.PriceWeaving = 0 
    D7226.PriceDyeing = 0 
    D7226.PriceSpecial = 0 

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7226_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7226 As T7226_AREA)
Try
    
    x7226.ExpenseYY = trim$(  x7226.ExpenseYY)
    x7226.ExpenseMM = trim$(  x7226.ExpenseMM)
    x7226.ExpenseCode = trim$(  x7226.ExpenseCode)
    x7226.PriceWeaving = trim$(  x7226.PriceWeaving)
    x7226.PriceDyeing = trim$(  x7226.PriceDyeing)
    x7226.PriceSpecial = trim$(  x7226.PriceSpecial)
     
    If trim$( x7226.ExpenseYY ) = "" Then x7226.ExpenseYY = Space(1) 
    If trim$( x7226.ExpenseMM ) = "" Then x7226.ExpenseMM = Space(1) 
    If trim$( x7226.ExpenseCode ) = "" Then x7226.ExpenseCode = Space(1) 
    If trim$( x7226.PriceWeaving ) = "" Then x7226.PriceWeaving = 0 
    If trim$( x7226.PriceDyeing ) = "" Then x7226.PriceDyeing = 0 
    If trim$( x7226.PriceSpecial ) = "" Then x7226.PriceSpecial = 0 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7226_MOVE(rs7226 As SqlClient.SqlDataReader)
Try

    call D7226_CLEAR()   

    If IsdbNull(rs7226!K7226_ExpenseYY) = False Then D7226.ExpenseYY = Trim$(rs7226!K7226_ExpenseYY)
    If IsdbNull(rs7226!K7226_ExpenseMM) = False Then D7226.ExpenseMM = Trim$(rs7226!K7226_ExpenseMM)
    If IsdbNull(rs7226!K7226_ExpenseCode) = False Then D7226.ExpenseCode = Trim$(rs7226!K7226_ExpenseCode)
    If IsdbNull(rs7226!K7226_PriceWeaving) = False Then D7226.PriceWeaving = Trim$(rs7226!K7226_PriceWeaving)
    If IsdbNull(rs7226!K7226_PriceDyeing) = False Then D7226.PriceDyeing = Trim$(rs7226!K7226_PriceDyeing)
    If IsdbNull(rs7226!K7226_PriceSpecial) = False Then D7226.PriceSpecial = Trim$(rs7226!K7226_PriceSpecial)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7226_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7226_MOVE(rs7226 As DataRow)
Try

    call D7226_CLEAR()   

    If IsdbNull(rs7226!K7226_ExpenseYY) = False Then D7226.ExpenseYY = Trim$(rs7226!K7226_ExpenseYY)
    If IsdbNull(rs7226!K7226_ExpenseMM) = False Then D7226.ExpenseMM = Trim$(rs7226!K7226_ExpenseMM)
    If IsdbNull(rs7226!K7226_ExpenseCode) = False Then D7226.ExpenseCode = Trim$(rs7226!K7226_ExpenseCode)
    If IsdbNull(rs7226!K7226_PriceWeaving) = False Then D7226.PriceWeaving = Trim$(rs7226!K7226_PriceWeaving)
    If IsdbNull(rs7226!K7226_PriceDyeing) = False Then D7226.PriceDyeing = Trim$(rs7226!K7226_PriceDyeing)
    If IsdbNull(rs7226!K7226_PriceSpecial) = False Then D7226.PriceSpecial = Trim$(rs7226!K7226_PriceSpecial)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7226_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7226_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7226 As T7226_AREA,EXPENSEYY AS String, EXPENSEMM AS String, EXPENSECODE AS String) as Boolean

K7226_MOVE = False

Try
    If READ_PFK7226(EXPENSEYY, EXPENSEMM, EXPENSECODE) = True Then
                z7226 = D7226
		K7226_MOVE = True
		else
		 z7226 = nothing
     End If

     If  getColumIndex(spr,"ExpenseYY") > -1 then z7226.ExpenseYY = getDataM(spr, getColumIndex(spr,"ExpenseYY"), xRow)
     If  getColumIndex(spr,"ExpenseMM") > -1 then z7226.ExpenseMM = getDataM(spr, getColumIndex(spr,"ExpenseMM"), xRow)
     If  getColumIndex(spr,"ExpenseCode") > -1 then z7226.ExpenseCode = getDataM(spr, getColumIndex(spr,"ExpenseCode"), xRow)
     If  getColumIndex(spr,"PriceWeaving") > -1 then z7226.PriceWeaving = getDataM(spr, getColumIndex(spr,"PriceWeaving"), xRow)
     If  getColumIndex(spr,"PriceDyeing") > -1 then z7226.PriceDyeing = getDataM(spr, getColumIndex(spr,"PriceDyeing"), xRow)
     If  getColumIndex(spr,"PriceSpecial") > -1 then z7226.PriceSpecial = getDataM(spr, getColumIndex(spr,"PriceSpecial"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7226_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7226_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7226 As T7226_AREA, Job as String,EXPENSEYY AS String, EXPENSEMM AS String, EXPENSECODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7226_MOVE = False

Try
    If READ_PFK7226(EXPENSEYY, EXPENSEMM, EXPENSECODE) = True Then
                z7226 = D7226
		K7226_MOVE = True
		else
		 z7226 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7226")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "ExpenseYY":z7226.ExpenseYY = Children(i).Code
   Case "ExpenseMM":z7226.ExpenseMM = Children(i).Code
   Case "ExpenseCode":z7226.ExpenseCode = Children(i).Code
   Case "PriceWeaving":z7226.PriceWeaving = Children(i).Code
   Case "PriceDyeing":z7226.PriceDyeing = Children(i).Code
   Case "PriceSpecial":z7226.PriceSpecial = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "ExpenseYY":z7226.ExpenseYY = Children(i).Data
   Case "ExpenseMM":z7226.ExpenseMM = Children(i).Data
   Case "ExpenseCode":z7226.ExpenseCode = Children(i).Data
   Case "PriceWeaving":z7226.PriceWeaving = Children(i).Data
   Case "PriceDyeing":z7226.PriceDyeing = Children(i).Data
   Case "PriceSpecial":z7226.PriceSpecial = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7226_MOVE",vbCritical)
End Try
End Function 
    
End Module 
