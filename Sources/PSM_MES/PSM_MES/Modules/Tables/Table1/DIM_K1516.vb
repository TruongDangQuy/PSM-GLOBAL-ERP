'=========================================================================================================================================================
'   TABLE : (PFK1516)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K1516

Structure T1516_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	OrderNo	 AS String	'			char(9)		*
Public 	OrderSeq	 AS Double	'			decimal		*
Public 	CustomerOrder	 AS String	'			char(6)
Public 	DateOrder	 AS String	'			char(8)
Public 	AmountForecastOrderUSD	 AS Double	'			decimal
Public 	AmountForecastOrderVND	 AS Double	'			decimal
Public 	AmountActualOrderUSD	 AS Double	'			decimal
Public 	AmountActualOrderVND	 AS Double	'			decimal
Public 	AmountReceivedOrderUSD	 AS Double	'			decimal
Public 	AmountReceivedOrderVND	 AS Double	'			decimal
Public 	CheckComplete	 AS String	'			char(1)
Public 	Remark	 AS String	'			nvarchar(150)
'=========================================================================================================================================================
End structure

Public D1516 As T1516_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK1516(ORDERNO AS String, ORDERSEQ AS Double) As Boolean
    READ_PFK1516 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK1516 "
    SQL = SQL & " WHERE K1516_OrderNo		 = '" & OrderNo & "' " 
    SQL = SQL & "   AND K1516_OrderSeq		 =  " & OrderSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D1516_CLEAR: GoTo SKIP_READ_PFK1516
                
    Call K1516_MOVE(rd)
    READ_PFK1516 = True

SKIP_READ_PFK1516:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK1516",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK1516(ORDERNO AS String, ORDERSEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK1516 "
    SQL = SQL & " WHERE K1516_OrderNo		 = '" & OrderNo & "' " 
    SQL = SQL & "   AND K1516_OrderSeq		 =  " & OrderSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK1516",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK1516(z1516 As T1516_AREA) As Boolean
    WRITE_PFK1516 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z1516)
 
    SQL = " INSERT INTO PFK1516 "
    SQL = SQL & " ( "
    SQL = SQL & " K1516_OrderNo," 
    SQL = SQL & " K1516_OrderSeq," 
    SQL = SQL & " K1516_CustomerOrder," 
    SQL = SQL & " K1516_DateOrder," 
    SQL = SQL & " K1516_AmountForecastOrderUSD," 
    SQL = SQL & " K1516_AmountForecastOrderVND," 
    SQL = SQL & " K1516_AmountActualOrderUSD," 
    SQL = SQL & " K1516_AmountActualOrderVND," 
    SQL = SQL & " K1516_AmountReceivedOrderUSD," 
    SQL = SQL & " K1516_AmountReceivedOrderVND," 
    SQL = SQL & " K1516_CheckComplete," 
    SQL = SQL & " K1516_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & z1516.OrderNo & "', "  
    SQL = SQL & "   " & z1516.OrderSeq & ", "  
    SQL = SQL & "  N'" & z1516.CustomerOrder & "', "  
    SQL = SQL & "  N'" & z1516.DateOrder & "', "  
    SQL = SQL & "   " & z1516.AmountForecastOrderUSD & ", "  
    SQL = SQL & "   " & z1516.AmountForecastOrderVND & ", "  
    SQL = SQL & "   " & z1516.AmountActualOrderUSD & ", "  
    SQL = SQL & "   " & z1516.AmountActualOrderVND & ", "  
    SQL = SQL & "   " & z1516.AmountReceivedOrderUSD & ", "  
    SQL = SQL & "   " & z1516.AmountReceivedOrderVND & ", "  
    SQL = SQL & "  N'" & z1516.CheckComplete & "', "  
    SQL = SQL & "  N'" & z1516.Remark & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK1516 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK1516",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK1516(z1516 As T1516_AREA) As Boolean
    REWRITE_PFK1516 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z1516)
   
    SQL = " UPDATE PFK1516 SET "
    SQL = SQL & "    K1516_CustomerOrder      = N'" & z1516.CustomerOrder & "', " 
    SQL = SQL & "    K1516_DateOrder      = N'" & z1516.DateOrder & "', " 
    SQL = SQL & "    K1516_AmountForecastOrderUSD      =  " & z1516.AmountForecastOrderUSD & ", " 
    SQL = SQL & "    K1516_AmountForecastOrderVND      =  " & z1516.AmountForecastOrderVND & ", " 
    SQL = SQL & "    K1516_AmountActualOrderUSD      =  " & z1516.AmountActualOrderUSD & ", " 
    SQL = SQL & "    K1516_AmountActualOrderVND      =  " & z1516.AmountActualOrderVND & ", " 
    SQL = SQL & "    K1516_AmountReceivedOrderUSD      =  " & z1516.AmountReceivedOrderUSD & ", " 
    SQL = SQL & "    K1516_AmountReceivedOrderVND      =  " & z1516.AmountReceivedOrderVND & ", " 
    SQL = SQL & "    K1516_CheckComplete      = N'" & z1516.CheckComplete & "', " 
    SQL = SQL & "    K1516_Remark      = N'" & z1516.Remark & "'  " 
    SQL = SQL & " WHERE K1516_OrderNo		 = '" & z1516.OrderNo & "' " 
    SQL = SQL & "   AND K1516_OrderSeq		 =  " & z1516.OrderSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK1516 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK1516",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK1516(z1516 As T1516_AREA) As Boolean
    DELETE_PFK1516 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK1516 "
    SQL = SQL & " WHERE K1516_OrderNo		 = '" & z1516.OrderNo & "' " 
    SQL = SQL & "   AND K1516_OrderSeq		 =  " & z1516.OrderSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK1516 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK1516",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D1516_CLEAR()
Try
    
   D1516.OrderNo = ""
    D1516.OrderSeq = 0 
   D1516.CustomerOrder = ""
   D1516.DateOrder = ""
    D1516.AmountForecastOrderUSD = 0 
    D1516.AmountForecastOrderVND = 0 
    D1516.AmountActualOrderUSD = 0 
    D1516.AmountActualOrderVND = 0 
    D1516.AmountReceivedOrderUSD = 0 
    D1516.AmountReceivedOrderVND = 0 
   D1516.CheckComplete = ""
   D1516.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D1516_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x1516 As T1516_AREA)
Try
    
    x1516.OrderNo = trim$(  x1516.OrderNo)
    x1516.OrderSeq = trim$(  x1516.OrderSeq)
    x1516.CustomerOrder = trim$(  x1516.CustomerOrder)
    x1516.DateOrder = trim$(  x1516.DateOrder)
    x1516.AmountForecastOrderUSD = trim$(  x1516.AmountForecastOrderUSD)
    x1516.AmountForecastOrderVND = trim$(  x1516.AmountForecastOrderVND)
    x1516.AmountActualOrderUSD = trim$(  x1516.AmountActualOrderUSD)
    x1516.AmountActualOrderVND = trim$(  x1516.AmountActualOrderVND)
    x1516.AmountReceivedOrderUSD = trim$(  x1516.AmountReceivedOrderUSD)
    x1516.AmountReceivedOrderVND = trim$(  x1516.AmountReceivedOrderVND)
    x1516.CheckComplete = trim$(  x1516.CheckComplete)
    x1516.Remark = trim$(  x1516.Remark)
     
    If trim$( x1516.OrderNo ) = "" Then x1516.OrderNo = Space(1) 
    If trim$( x1516.OrderSeq ) = "" Then x1516.OrderSeq = 0 
    If trim$( x1516.CustomerOrder ) = "" Then x1516.CustomerOrder = Space(1) 
    If trim$( x1516.DateOrder ) = "" Then x1516.DateOrder = Space(1) 
    If trim$( x1516.AmountForecastOrderUSD ) = "" Then x1516.AmountForecastOrderUSD = 0 
    If trim$( x1516.AmountForecastOrderVND ) = "" Then x1516.AmountForecastOrderVND = 0 
    If trim$( x1516.AmountActualOrderUSD ) = "" Then x1516.AmountActualOrderUSD = 0 
    If trim$( x1516.AmountActualOrderVND ) = "" Then x1516.AmountActualOrderVND = 0 
    If trim$( x1516.AmountReceivedOrderUSD ) = "" Then x1516.AmountReceivedOrderUSD = 0 
    If trim$( x1516.AmountReceivedOrderVND ) = "" Then x1516.AmountReceivedOrderVND = 0 
    If trim$( x1516.CheckComplete ) = "" Then x1516.CheckComplete = Space(1) 
    If trim$( x1516.Remark ) = "" Then x1516.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K1516_MOVE(rs1516 As SqlClient.SqlDataReader)
Try

    call D1516_CLEAR()   

    If IsdbNull(rs1516!K1516_OrderNo) = False Then D1516.OrderNo = Trim$(rs1516!K1516_OrderNo)
    If IsdbNull(rs1516!K1516_OrderSeq) = False Then D1516.OrderSeq = Trim$(rs1516!K1516_OrderSeq)
    If IsdbNull(rs1516!K1516_CustomerOrder) = False Then D1516.CustomerOrder = Trim$(rs1516!K1516_CustomerOrder)
    If IsdbNull(rs1516!K1516_DateOrder) = False Then D1516.DateOrder = Trim$(rs1516!K1516_DateOrder)
    If IsdbNull(rs1516!K1516_AmountForecastOrderUSD) = False Then D1516.AmountForecastOrderUSD = Trim$(rs1516!K1516_AmountForecastOrderUSD)
    If IsdbNull(rs1516!K1516_AmountForecastOrderVND) = False Then D1516.AmountForecastOrderVND = Trim$(rs1516!K1516_AmountForecastOrderVND)
    If IsdbNull(rs1516!K1516_AmountActualOrderUSD) = False Then D1516.AmountActualOrderUSD = Trim$(rs1516!K1516_AmountActualOrderUSD)
    If IsdbNull(rs1516!K1516_AmountActualOrderVND) = False Then D1516.AmountActualOrderVND = Trim$(rs1516!K1516_AmountActualOrderVND)
    If IsdbNull(rs1516!K1516_AmountReceivedOrderUSD) = False Then D1516.AmountReceivedOrderUSD = Trim$(rs1516!K1516_AmountReceivedOrderUSD)
    If IsdbNull(rs1516!K1516_AmountReceivedOrderVND) = False Then D1516.AmountReceivedOrderVND = Trim$(rs1516!K1516_AmountReceivedOrderVND)
    If IsdbNull(rs1516!K1516_CheckComplete) = False Then D1516.CheckComplete = Trim$(rs1516!K1516_CheckComplete)
    If IsdbNull(rs1516!K1516_Remark) = False Then D1516.Remark = Trim$(rs1516!K1516_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K1516_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K1516_MOVE(rs1516 As DataRow)
Try

    call D1516_CLEAR()   

    If IsdbNull(rs1516!K1516_OrderNo) = False Then D1516.OrderNo = Trim$(rs1516!K1516_OrderNo)
    If IsdbNull(rs1516!K1516_OrderSeq) = False Then D1516.OrderSeq = Trim$(rs1516!K1516_OrderSeq)
    If IsdbNull(rs1516!K1516_CustomerOrder) = False Then D1516.CustomerOrder = Trim$(rs1516!K1516_CustomerOrder)
    If IsdbNull(rs1516!K1516_DateOrder) = False Then D1516.DateOrder = Trim$(rs1516!K1516_DateOrder)
    If IsdbNull(rs1516!K1516_AmountForecastOrderUSD) = False Then D1516.AmountForecastOrderUSD = Trim$(rs1516!K1516_AmountForecastOrderUSD)
    If IsdbNull(rs1516!K1516_AmountForecastOrderVND) = False Then D1516.AmountForecastOrderVND = Trim$(rs1516!K1516_AmountForecastOrderVND)
    If IsdbNull(rs1516!K1516_AmountActualOrderUSD) = False Then D1516.AmountActualOrderUSD = Trim$(rs1516!K1516_AmountActualOrderUSD)
    If IsdbNull(rs1516!K1516_AmountActualOrderVND) = False Then D1516.AmountActualOrderVND = Trim$(rs1516!K1516_AmountActualOrderVND)
    If IsdbNull(rs1516!K1516_AmountReceivedOrderUSD) = False Then D1516.AmountReceivedOrderUSD = Trim$(rs1516!K1516_AmountReceivedOrderUSD)
    If IsdbNull(rs1516!K1516_AmountReceivedOrderVND) = False Then D1516.AmountReceivedOrderVND = Trim$(rs1516!K1516_AmountReceivedOrderVND)
    If IsdbNull(rs1516!K1516_CheckComplete) = False Then D1516.CheckComplete = Trim$(rs1516!K1516_CheckComplete)
    If IsdbNull(rs1516!K1516_Remark) = False Then D1516.Remark = Trim$(rs1516!K1516_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K1516_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K1516_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z1516 As T1516_AREA,ORDERNO AS String, ORDERSEQ AS Double) as Boolean

K1516_MOVE = False

Try
    If READ_PFK1516(ORDERNO, ORDERSEQ) = True Then
                z1516 = D1516
		K1516_MOVE = True
		else
		 z1516 = nothing
     End If

     If  getColumIndex(spr,"OrderNo") > -1 then z1516.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"OrderSeq") > -1 then z1516.OrderSeq = getDataM(spr, getColumIndex(spr,"OrderSeq"), xRow)
     If  getColumIndex(spr,"CustomerOrder") > -1 then z1516.CustomerOrder = getDataM(spr, getColumIndex(spr,"CustomerOrder"), xRow)
     If  getColumIndex(spr,"DateOrder") > -1 then z1516.DateOrder = getDataM(spr, getColumIndex(spr,"DateOrder"), xRow)
     If  getColumIndex(spr,"AmountForecastOrderUSD") > -1 then z1516.AmountForecastOrderUSD = getDataM(spr, getColumIndex(spr,"AmountForecastOrderUSD"), xRow)
     If  getColumIndex(spr,"AmountForecastOrderVND") > -1 then z1516.AmountForecastOrderVND = getDataM(spr, getColumIndex(spr,"AmountForecastOrderVND"), xRow)
     If  getColumIndex(spr,"AmountActualOrderUSD") > -1 then z1516.AmountActualOrderUSD = getDataM(spr, getColumIndex(spr,"AmountActualOrderUSD"), xRow)
     If  getColumIndex(spr,"AmountActualOrderVND") > -1 then z1516.AmountActualOrderVND = getDataM(spr, getColumIndex(spr,"AmountActualOrderVND"), xRow)
     If  getColumIndex(spr,"AmountReceivedOrderUSD") > -1 then z1516.AmountReceivedOrderUSD = getDataM(spr, getColumIndex(spr,"AmountReceivedOrderUSD"), xRow)
     If  getColumIndex(spr,"AmountReceivedOrderVND") > -1 then z1516.AmountReceivedOrderVND = getDataM(spr, getColumIndex(spr,"AmountReceivedOrderVND"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z1516.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z1516.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K1516_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K1516_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z1516 As T1516_AREA, Job as String,ORDERNO AS String, ORDERSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K1516_MOVE = False

Try
    If READ_PFK1516(ORDERNO, ORDERSEQ) = True Then
                z1516 = D1516
		K1516_MOVE = True
		else
		 z1516 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1516")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "OrderNo":z1516.OrderNo = Children(i).Code
   Case "OrderSeq":z1516.OrderSeq = Children(i).Code
   Case "CustomerOrder":z1516.CustomerOrder = Children(i).Code
   Case "DateOrder":z1516.DateOrder = Children(i).Code
   Case "AmountForecastOrderUSD":z1516.AmountForecastOrderUSD = Children(i).Code
   Case "AmountForecastOrderVND":z1516.AmountForecastOrderVND = Children(i).Code
   Case "AmountActualOrderUSD":z1516.AmountActualOrderUSD = Children(i).Code
   Case "AmountActualOrderVND":z1516.AmountActualOrderVND = Children(i).Code
   Case "AmountReceivedOrderUSD":z1516.AmountReceivedOrderUSD = Children(i).Code
   Case "AmountReceivedOrderVND":z1516.AmountReceivedOrderVND = Children(i).Code
   Case "CheckComplete":z1516.CheckComplete = Children(i).Code
   Case "Remark":z1516.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "OrderNo":z1516.OrderNo = Children(i).Data
   Case "OrderSeq":z1516.OrderSeq = Children(i).Data
   Case "CustomerOrder":z1516.CustomerOrder = Children(i).Data
   Case "DateOrder":z1516.DateOrder = Children(i).Data
   Case "AmountForecastOrderUSD":z1516.AmountForecastOrderUSD = Children(i).Data
   Case "AmountForecastOrderVND":z1516.AmountForecastOrderVND = Children(i).Data
   Case "AmountActualOrderUSD":z1516.AmountActualOrderUSD = Children(i).Data
   Case "AmountActualOrderVND":z1516.AmountActualOrderVND = Children(i).Data
   Case "AmountReceivedOrderUSD":z1516.AmountReceivedOrderUSD = Children(i).Data
   Case "AmountReceivedOrderVND":z1516.AmountReceivedOrderVND = Children(i).Data
   Case "CheckComplete":z1516.CheckComplete = Children(i).Data
   Case "Remark":z1516.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K1516_MOVE",vbCritical)
End Try
End Function 
    
End Module 
