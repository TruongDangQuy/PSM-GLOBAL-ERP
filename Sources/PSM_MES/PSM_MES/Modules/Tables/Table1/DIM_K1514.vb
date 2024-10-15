'=========================================================================================================================================================
'   TABLE : (PFK1514)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K1514

Structure T1514_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	PaidCode	 AS String	'			char(6)		*
Public 	PaidName	 AS String	'			nvarchar(50)
Public 	BankCode	 AS String	'			char(6)
Public 	DatePayment	 AS String	'			char(8)
Public 	DateExchange	 AS String	'			char(8)
Public 	PriceExchange	 AS Double	'			decimal
Public 	CheckDC	 AS String	'			char(1)
Public 	CheckComplete	 AS String	'			char(1)
Public 	Remark	 AS String	'			nvarchar(150)
'=========================================================================================================================================================
End structure

Public D1514 As T1514_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK1514(PAIDCODE AS String) As Boolean
    READ_PFK1514 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK1514 "
    SQL = SQL & " WHERE K1514_PaidCode		 = '" & PaidCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D1514_CLEAR: GoTo SKIP_READ_PFK1514
                
    Call K1514_MOVE(rd)
    READ_PFK1514 = True

SKIP_READ_PFK1514:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK1514",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK1514(PAIDCODE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK1514 "
    SQL = SQL & " WHERE K1514_PaidCode		 = '" & PaidCode & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK1514",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK1514(z1514 As T1514_AREA) As Boolean
    WRITE_PFK1514 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z1514)
 
    SQL = " INSERT INTO PFK1514 "
    SQL = SQL & " ( "
    SQL = SQL & " K1514_PaidCode," 
    SQL = SQL & " K1514_PaidName," 
    SQL = SQL & " K1514_BankCode," 
    SQL = SQL & " K1514_DatePayment," 
    SQL = SQL & " K1514_DateExchange," 
    SQL = SQL & " K1514_PriceExchange," 
    SQL = SQL & " K1514_CheckDC," 
    SQL = SQL & " K1514_CheckComplete," 
    SQL = SQL & " K1514_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & z1514.PaidCode & "', "  
    SQL = SQL & "  N'" & z1514.PaidName & "', "  
    SQL = SQL & "  N'" & z1514.BankCode & "', "  
    SQL = SQL & "  N'" & z1514.DatePayment & "', "  
    SQL = SQL & "  N'" & z1514.DateExchange & "', "  
    SQL = SQL & "   " & z1514.PriceExchange & ", "  
    SQL = SQL & "  N'" & z1514.CheckDC & "', "  
    SQL = SQL & "  N'" & z1514.CheckComplete & "', "  
    SQL = SQL & "  N'" & z1514.Remark & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK1514 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK1514",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK1514(z1514 As T1514_AREA) As Boolean
    REWRITE_PFK1514 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z1514)
   
    SQL = " UPDATE PFK1514 SET "
    SQL = SQL & "    K1514_PaidName      = N'" & z1514.PaidName & "', " 
    SQL = SQL & "    K1514_BankCode      = N'" & z1514.BankCode & "', " 
    SQL = SQL & "    K1514_DatePayment      = N'" & z1514.DatePayment & "', " 
    SQL = SQL & "    K1514_DateExchange      = N'" & z1514.DateExchange & "', " 
    SQL = SQL & "    K1514_PriceExchange      =  " & z1514.PriceExchange & ", " 
    SQL = SQL & "    K1514_CheckDC      = N'" & z1514.CheckDC & "', " 
    SQL = SQL & "    K1514_CheckComplete      = N'" & z1514.CheckComplete & "', " 
    SQL = SQL & "    K1514_Remark      = N'" & z1514.Remark & "'  " 
    SQL = SQL & " WHERE K1514_PaidCode		 = '" & z1514.PaidCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK1514 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK1514",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK1514(z1514 As T1514_AREA) As Boolean
    DELETE_PFK1514 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK1514 "
    SQL = SQL & " WHERE K1514_PaidCode		 = '" & z1514.PaidCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK1514 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK1514",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D1514_CLEAR()
Try
    
   D1514.PaidCode = ""
   D1514.PaidName = ""
   D1514.BankCode = ""
   D1514.DatePayment = ""
   D1514.DateExchange = ""
    D1514.PriceExchange = 0 
   D1514.CheckDC = ""
   D1514.CheckComplete = ""
   D1514.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D1514_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x1514 As T1514_AREA)
Try
    
    x1514.PaidCode = trim$(  x1514.PaidCode)
    x1514.PaidName = trim$(  x1514.PaidName)
    x1514.BankCode = trim$(  x1514.BankCode)
    x1514.DatePayment = trim$(  x1514.DatePayment)
    x1514.DateExchange = trim$(  x1514.DateExchange)
    x1514.PriceExchange = trim$(  x1514.PriceExchange)
    x1514.CheckDC = trim$(  x1514.CheckDC)
    x1514.CheckComplete = trim$(  x1514.CheckComplete)
    x1514.Remark = trim$(  x1514.Remark)
     
    If trim$( x1514.PaidCode ) = "" Then x1514.PaidCode = Space(1) 
    If trim$( x1514.PaidName ) = "" Then x1514.PaidName = Space(1) 
    If trim$( x1514.BankCode ) = "" Then x1514.BankCode = Space(1) 
    If trim$( x1514.DatePayment ) = "" Then x1514.DatePayment = Space(1) 
    If trim$( x1514.DateExchange ) = "" Then x1514.DateExchange = Space(1) 
    If trim$( x1514.PriceExchange ) = "" Then x1514.PriceExchange = 0 
    If trim$( x1514.CheckDC ) = "" Then x1514.CheckDC = Space(1) 
    If trim$( x1514.CheckComplete ) = "" Then x1514.CheckComplete = Space(1) 
    If trim$( x1514.Remark ) = "" Then x1514.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K1514_MOVE(rs1514 As SqlClient.SqlDataReader)
Try

    call D1514_CLEAR()   

    If IsdbNull(rs1514!K1514_PaidCode) = False Then D1514.PaidCode = Trim$(rs1514!K1514_PaidCode)
    If IsdbNull(rs1514!K1514_PaidName) = False Then D1514.PaidName = Trim$(rs1514!K1514_PaidName)
    If IsdbNull(rs1514!K1514_BankCode) = False Then D1514.BankCode = Trim$(rs1514!K1514_BankCode)
    If IsdbNull(rs1514!K1514_DatePayment) = False Then D1514.DatePayment = Trim$(rs1514!K1514_DatePayment)
    If IsdbNull(rs1514!K1514_DateExchange) = False Then D1514.DateExchange = Trim$(rs1514!K1514_DateExchange)
    If IsdbNull(rs1514!K1514_PriceExchange) = False Then D1514.PriceExchange = Trim$(rs1514!K1514_PriceExchange)
    If IsdbNull(rs1514!K1514_CheckDC) = False Then D1514.CheckDC = Trim$(rs1514!K1514_CheckDC)
    If IsdbNull(rs1514!K1514_CheckComplete) = False Then D1514.CheckComplete = Trim$(rs1514!K1514_CheckComplete)
    If IsdbNull(rs1514!K1514_Remark) = False Then D1514.Remark = Trim$(rs1514!K1514_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K1514_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K1514_MOVE(rs1514 As DataRow)
Try

    call D1514_CLEAR()   

    If IsdbNull(rs1514!K1514_PaidCode) = False Then D1514.PaidCode = Trim$(rs1514!K1514_PaidCode)
    If IsdbNull(rs1514!K1514_PaidName) = False Then D1514.PaidName = Trim$(rs1514!K1514_PaidName)
    If IsdbNull(rs1514!K1514_BankCode) = False Then D1514.BankCode = Trim$(rs1514!K1514_BankCode)
    If IsdbNull(rs1514!K1514_DatePayment) = False Then D1514.DatePayment = Trim$(rs1514!K1514_DatePayment)
    If IsdbNull(rs1514!K1514_DateExchange) = False Then D1514.DateExchange = Trim$(rs1514!K1514_DateExchange)
    If IsdbNull(rs1514!K1514_PriceExchange) = False Then D1514.PriceExchange = Trim$(rs1514!K1514_PriceExchange)
    If IsdbNull(rs1514!K1514_CheckDC) = False Then D1514.CheckDC = Trim$(rs1514!K1514_CheckDC)
    If IsdbNull(rs1514!K1514_CheckComplete) = False Then D1514.CheckComplete = Trim$(rs1514!K1514_CheckComplete)
    If IsdbNull(rs1514!K1514_Remark) = False Then D1514.Remark = Trim$(rs1514!K1514_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K1514_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K1514_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z1514 As T1514_AREA,PAIDCODE AS String) as Boolean

K1514_MOVE = False

Try
    If READ_PFK1514(PAIDCODE) = True Then
                z1514 = D1514
		K1514_MOVE = True
		else
		 z1514 = nothing
     End If

     If  getColumIndex(spr,"PaidCode") > -1 then z1514.PaidCode = getDataM(spr, getColumIndex(spr,"PaidCode"), xRow)
     If  getColumIndex(spr,"PaidName") > -1 then z1514.PaidName = getDataM(spr, getColumIndex(spr,"PaidName"), xRow)
     If  getColumIndex(spr,"BankCode") > -1 then z1514.BankCode = getDataM(spr, getColumIndex(spr,"BankCode"), xRow)
     If  getColumIndex(spr,"DatePayment") > -1 then z1514.DatePayment = getDataM(spr, getColumIndex(spr,"DatePayment"), xRow)
     If  getColumIndex(spr,"DateExchange") > -1 then z1514.DateExchange = getDataM(spr, getColumIndex(spr,"DateExchange"), xRow)
     If  getColumIndex(spr,"PriceExchange") > -1 then z1514.PriceExchange = getDataM(spr, getColumIndex(spr,"PriceExchange"), xRow)
     If  getColumIndex(spr,"CheckDC") > -1 then z1514.CheckDC = getDataM(spr, getColumIndex(spr,"CheckDC"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z1514.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z1514.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K1514_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K1514_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z1514 As T1514_AREA, Job as String,PAIDCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K1514_MOVE = False

Try
    If READ_PFK1514(PAIDCODE) = True Then
                z1514 = D1514
		K1514_MOVE = True
		else
		 z1514 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1514")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PaidCode":z1514.PaidCode = Children(i).Code
   Case "PaidName":z1514.PaidName = Children(i).Code
   Case "BankCode":z1514.BankCode = Children(i).Code
   Case "DatePayment":z1514.DatePayment = Children(i).Code
   Case "DateExchange":z1514.DateExchange = Children(i).Code
   Case "PriceExchange":z1514.PriceExchange = Children(i).Code
   Case "CheckDC":z1514.CheckDC = Children(i).Code
   Case "CheckComplete":z1514.CheckComplete = Children(i).Code
   Case "Remark":z1514.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PaidCode":z1514.PaidCode = Children(i).Data
   Case "PaidName":z1514.PaidName = Children(i).Data
   Case "BankCode":z1514.BankCode = Children(i).Data
   Case "DatePayment":z1514.DatePayment = Children(i).Data
   Case "DateExchange":z1514.DateExchange = Children(i).Data
   Case "PriceExchange":z1514.PriceExchange = Children(i).Data
   Case "CheckDC":z1514.CheckDC = Children(i).Data
   Case "CheckComplete":z1514.CheckComplete = Children(i).Data
   Case "Remark":z1514.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K1514_MOVE",vbCritical)
End Try
End Function 
    
End Module 
