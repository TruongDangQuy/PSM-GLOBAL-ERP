'=========================================================================================================================================================
'   TABLE : (PFK3413)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K3413

Structure T3413_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	PurchasingOrderNo	 AS String	'			char(9)		*
Public 	ExpenseSeq	 AS Double	'			decimal		*
Public 	seExpense	 AS String	'			char(3)
Public 	cdExpense	 AS String	'			char(3)
Public 	RateExpense	 AS Double	'			decimal
Public 	PackExpense	 AS Double	'			decimal
Public 	QtyExpense	 AS Double	'			decimal
Public 	AmountExpense	 AS Double	'			decimal
Public 	AmountExpenseVND	 AS Double	'			decimal
Public 	AmountExpenseUSD	 AS Double	'			decimal
Public 	Remark	 AS String	'			nchar(200)
'=========================================================================================================================================================
End structure

Public D3413 As T3413_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK3413(PURCHASINGORDERNO AS String, EXPENSESEQ AS Double) As Boolean
    READ_PFK3413 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3413 "
    SQL = SQL & " WHERE K3413_PurchasingOrderNo		 = '" & PurchasingOrderNo & "' " 
    SQL = SQL & "   AND K3413_ExpenseSeq		 =  " & ExpenseSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D3413_CLEAR: GoTo SKIP_READ_PFK3413
                
    Call K3413_MOVE(rd)
    READ_PFK3413 = True

SKIP_READ_PFK3413:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK3413",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK3413(PURCHASINGORDERNO AS String, EXPENSESEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3413 "
    SQL = SQL & " WHERE K3413_PurchasingOrderNo		 = '" & PurchasingOrderNo & "' " 
    SQL = SQL & "   AND K3413_ExpenseSeq		 =  " & ExpenseSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK3413",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK3413(z3413 As T3413_AREA) As Boolean
    WRITE_PFK3413 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z3413)
 
    SQL = " INSERT INTO PFK3413 "
    SQL = SQL & " ( "
    SQL = SQL & " K3413_PurchasingOrderNo," 
    SQL = SQL & " K3413_ExpenseSeq," 
    SQL = SQL & " K3413_seExpense," 
    SQL = SQL & " K3413_cdExpense," 
    SQL = SQL & " K3413_RateExpense," 
    SQL = SQL & " K3413_PackExpense," 
    SQL = SQL & " K3413_QtyExpense," 
    SQL = SQL & " K3413_AmountExpense," 
    SQL = SQL & " K3413_AmountExpenseVND," 
    SQL = SQL & " K3413_AmountExpenseUSD," 
    SQL = SQL & " K3413_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z3413.PurchasingOrderNo) & "', "  
    SQL = SQL & "   " & FormatSQL(z3413.ExpenseSeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3413.seExpense) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3413.cdExpense) & "', "  
    SQL = SQL & "   " & FormatSQL(z3413.RateExpense) & ", "  
    SQL = SQL & "   " & FormatSQL(z3413.PackExpense) & ", "  
    SQL = SQL & "   " & FormatSQL(z3413.QtyExpense) & ", "  
    SQL = SQL & "   " & FormatSQL(z3413.AmountExpense) & ", "  
    SQL = SQL & "   " & FormatSQL(z3413.AmountExpenseVND) & ", "  
    SQL = SQL & "   " & FormatSQL(z3413.AmountExpenseUSD) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3413.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK3413 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK3413",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK3413(z3413 As T3413_AREA) As Boolean
    REWRITE_PFK3413 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z3413)
   
    SQL = " UPDATE PFK3413 SET "
    SQL = SQL & "    K3413_seExpense      = N'" & FormatSQL(z3413.seExpense) & "', " 
    SQL = SQL & "    K3413_cdExpense      = N'" & FormatSQL(z3413.cdExpense) & "', " 
    SQL = SQL & "    K3413_RateExpense      =  " & FormatSQL(z3413.RateExpense) & ", " 
    SQL = SQL & "    K3413_PackExpense      =  " & FormatSQL(z3413.PackExpense) & ", " 
    SQL = SQL & "    K3413_QtyExpense      =  " & FormatSQL(z3413.QtyExpense) & ", " 
    SQL = SQL & "    K3413_AmountExpense      =  " & FormatSQL(z3413.AmountExpense) & ", " 
    SQL = SQL & "    K3413_AmountExpenseVND      =  " & FormatSQL(z3413.AmountExpenseVND) & ", " 
    SQL = SQL & "    K3413_AmountExpenseUSD      =  " & FormatSQL(z3413.AmountExpenseUSD) & ", " 
    SQL = SQL & "    K3413_Remark      = N'" & FormatSQL(z3413.Remark) & "'  " 
    SQL = SQL & " WHERE K3413_PurchasingOrderNo		 = '" & z3413.PurchasingOrderNo & "' " 
    SQL = SQL & "   AND K3413_ExpenseSeq		 =  " & z3413.ExpenseSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK3413 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK3413",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK3413(z3413 As T3413_AREA) As Boolean
    DELETE_PFK3413 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK3413 "
    SQL = SQL & " WHERE K3413_PurchasingOrderNo		 = '" & z3413.PurchasingOrderNo & "' " 
    SQL = SQL & "   AND K3413_ExpenseSeq		 =  " & z3413.ExpenseSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK3413 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK3413",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D3413_CLEAR()
Try
    
   D3413.PurchasingOrderNo = ""
    D3413.ExpenseSeq = 0 
   D3413.seExpense = ""
   D3413.cdExpense = ""
    D3413.RateExpense = 0 
    D3413.PackExpense = 0 
    D3413.QtyExpense = 0 
    D3413.AmountExpense = 0 
    D3413.AmountExpenseVND = 0 
    D3413.AmountExpenseUSD = 0 
   D3413.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D3413_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x3413 As T3413_AREA)
Try
    
    x3413.PurchasingOrderNo = trim$(  x3413.PurchasingOrderNo)
    x3413.ExpenseSeq = trim$(  x3413.ExpenseSeq)
    x3413.seExpense = trim$(  x3413.seExpense)
    x3413.cdExpense = trim$(  x3413.cdExpense)
    x3413.RateExpense = trim$(  x3413.RateExpense)
    x3413.PackExpense = trim$(  x3413.PackExpense)
    x3413.QtyExpense = trim$(  x3413.QtyExpense)
    x3413.AmountExpense = trim$(  x3413.AmountExpense)
    x3413.AmountExpenseVND = trim$(  x3413.AmountExpenseVND)
    x3413.AmountExpenseUSD = trim$(  x3413.AmountExpenseUSD)
    x3413.Remark = trim$(  x3413.Remark)
     
    If trim$( x3413.PurchasingOrderNo ) = "" Then x3413.PurchasingOrderNo = Space(1) 
    If trim$( x3413.ExpenseSeq ) = "" Then x3413.ExpenseSeq = 0 
    If trim$( x3413.seExpense ) = "" Then x3413.seExpense = Space(1) 
    If trim$( x3413.cdExpense ) = "" Then x3413.cdExpense = Space(1) 
    If trim$( x3413.RateExpense ) = "" Then x3413.RateExpense = 0 
    If trim$( x3413.PackExpense ) = "" Then x3413.PackExpense = 0 
    If trim$( x3413.QtyExpense ) = "" Then x3413.QtyExpense = 0 
    If trim$( x3413.AmountExpense ) = "" Then x3413.AmountExpense = 0 
    If trim$( x3413.AmountExpenseVND ) = "" Then x3413.AmountExpenseVND = 0 
    If trim$( x3413.AmountExpenseUSD ) = "" Then x3413.AmountExpenseUSD = 0 
    If trim$( x3413.Remark ) = "" Then x3413.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K3413_MOVE(rs3413 As SqlClient.SqlDataReader)
Try

    call D3413_CLEAR()   

    If IsdbNull(rs3413!K3413_PurchasingOrderNo) = False Then D3413.PurchasingOrderNo = Trim$(rs3413!K3413_PurchasingOrderNo)
    If IsdbNull(rs3413!K3413_ExpenseSeq) = False Then D3413.ExpenseSeq = Trim$(rs3413!K3413_ExpenseSeq)
    If IsdbNull(rs3413!K3413_seExpense) = False Then D3413.seExpense = Trim$(rs3413!K3413_seExpense)
    If IsdbNull(rs3413!K3413_cdExpense) = False Then D3413.cdExpense = Trim$(rs3413!K3413_cdExpense)
    If IsdbNull(rs3413!K3413_RateExpense) = False Then D3413.RateExpense = Trim$(rs3413!K3413_RateExpense)
    If IsdbNull(rs3413!K3413_PackExpense) = False Then D3413.PackExpense = Trim$(rs3413!K3413_PackExpense)
    If IsdbNull(rs3413!K3413_QtyExpense) = False Then D3413.QtyExpense = Trim$(rs3413!K3413_QtyExpense)
    If IsdbNull(rs3413!K3413_AmountExpense) = False Then D3413.AmountExpense = Trim$(rs3413!K3413_AmountExpense)
    If IsdbNull(rs3413!K3413_AmountExpenseVND) = False Then D3413.AmountExpenseVND = Trim$(rs3413!K3413_AmountExpenseVND)
    If IsdbNull(rs3413!K3413_AmountExpenseUSD) = False Then D3413.AmountExpenseUSD = Trim$(rs3413!K3413_AmountExpenseUSD)
    If IsdbNull(rs3413!K3413_Remark) = False Then D3413.Remark = Trim$(rs3413!K3413_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3413_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K3413_MOVE(rs3413 As DataRow)
Try

    call D3413_CLEAR()   

    If IsdbNull(rs3413!K3413_PurchasingOrderNo) = False Then D3413.PurchasingOrderNo = Trim$(rs3413!K3413_PurchasingOrderNo)
    If IsdbNull(rs3413!K3413_ExpenseSeq) = False Then D3413.ExpenseSeq = Trim$(rs3413!K3413_ExpenseSeq)
    If IsdbNull(rs3413!K3413_seExpense) = False Then D3413.seExpense = Trim$(rs3413!K3413_seExpense)
    If IsdbNull(rs3413!K3413_cdExpense) = False Then D3413.cdExpense = Trim$(rs3413!K3413_cdExpense)
    If IsdbNull(rs3413!K3413_RateExpense) = False Then D3413.RateExpense = Trim$(rs3413!K3413_RateExpense)
    If IsdbNull(rs3413!K3413_PackExpense) = False Then D3413.PackExpense = Trim$(rs3413!K3413_PackExpense)
    If IsdbNull(rs3413!K3413_QtyExpense) = False Then D3413.QtyExpense = Trim$(rs3413!K3413_QtyExpense)
    If IsdbNull(rs3413!K3413_AmountExpense) = False Then D3413.AmountExpense = Trim$(rs3413!K3413_AmountExpense)
    If IsdbNull(rs3413!K3413_AmountExpenseVND) = False Then D3413.AmountExpenseVND = Trim$(rs3413!K3413_AmountExpenseVND)
    If IsdbNull(rs3413!K3413_AmountExpenseUSD) = False Then D3413.AmountExpenseUSD = Trim$(rs3413!K3413_AmountExpenseUSD)
    If IsdbNull(rs3413!K3413_Remark) = False Then D3413.Remark = Trim$(rs3413!K3413_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3413_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K3413_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3413 As T3413_AREA, PURCHASINGORDERNO AS String, EXPENSESEQ AS Double) as Boolean

K3413_MOVE = False

Try
    If READ_PFK3413(PURCHASINGORDERNO, EXPENSESEQ) = True Then
                z3413 = D3413
		K3413_MOVE = True
		else
	z3413 = nothing
     End If

     If  getColumIndex(spr,"PurchasingOrderNo") > -1 then z3413.PurchasingOrderNo = getDataM(spr, getColumIndex(spr,"PurchasingOrderNo"), xRow)
     If  getColumIndex(spr,"ExpenseSeq") > -1 then z3413.ExpenseSeq = getDataM(spr, getColumIndex(spr,"ExpenseSeq"), xRow)
     If  getColumIndex(spr,"seExpense") > -1 then z3413.seExpense = getDataM(spr, getColumIndex(spr,"seExpense"), xRow)
     If  getColumIndex(spr,"cdExpense") > -1 then z3413.cdExpense = getDataM(spr, getColumIndex(spr,"cdExpense"), xRow)
     If  getColumIndex(spr,"RateExpense") > -1 then z3413.RateExpense = getDataM(spr, getColumIndex(spr,"RateExpense"), xRow)
     If  getColumIndex(spr,"PackExpense") > -1 then z3413.PackExpense = getDataM(spr, getColumIndex(spr,"PackExpense"), xRow)
     If  getColumIndex(spr,"QtyExpense") > -1 then z3413.QtyExpense = getDataM(spr, getColumIndex(spr,"QtyExpense"), xRow)
     If  getColumIndex(spr,"AmountExpense") > -1 then z3413.AmountExpense = getDataM(spr, getColumIndex(spr,"AmountExpense"), xRow)
     If  getColumIndex(spr,"AmountExpenseVND") > -1 then z3413.AmountExpenseVND = getDataM(spr, getColumIndex(spr,"AmountExpenseVND"), xRow)
     If  getColumIndex(spr,"AmountExpenseUSD") > -1 then z3413.AmountExpenseUSD = getDataM(spr, getColumIndex(spr,"AmountExpenseUSD"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z3413.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3413_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K3413_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3413 As T3413_AREA,CheckClear as Boolean,PURCHASINGORDERNO AS String, EXPENSESEQ AS Double) as Boolean

K3413_MOVE = False

Try
    If READ_PFK3413(PURCHASINGORDERNO, EXPENSESEQ) = True Then
                z3413 = D3413
		K3413_MOVE = True
		else
	If CheckClear  = True then z3413 = nothing
     End If

     If  getColumIndex(spr,"PurchasingOrderNo") > -1 then z3413.PurchasingOrderNo = getDataM(spr, getColumIndex(spr,"PurchasingOrderNo"), xRow)
     If  getColumIndex(spr,"ExpenseSeq") > -1 then z3413.ExpenseSeq = getDataM(spr, getColumIndex(spr,"ExpenseSeq"), xRow)
     If  getColumIndex(spr,"seExpense") > -1 then z3413.seExpense = getDataM(spr, getColumIndex(spr,"seExpense"), xRow)
     If  getColumIndex(spr,"cdExpense") > -1 then z3413.cdExpense = getDataM(spr, getColumIndex(spr,"cdExpense"), xRow)
     If  getColumIndex(spr,"RateExpense") > -1 then z3413.RateExpense = getDataM(spr, getColumIndex(spr,"RateExpense"), xRow)
     If  getColumIndex(spr,"PackExpense") > -1 then z3413.PackExpense = getDataM(spr, getColumIndex(spr,"PackExpense"), xRow)
     If  getColumIndex(spr,"QtyExpense") > -1 then z3413.QtyExpense = getDataM(spr, getColumIndex(spr,"QtyExpense"), xRow)
     If  getColumIndex(spr,"AmountExpense") > -1 then z3413.AmountExpense = getDataM(spr, getColumIndex(spr,"AmountExpense"), xRow)
     If  getColumIndex(spr,"AmountExpenseVND") > -1 then z3413.AmountExpenseVND = getDataM(spr, getColumIndex(spr,"AmountExpenseVND"), xRow)
     If  getColumIndex(spr,"AmountExpenseUSD") > -1 then z3413.AmountExpenseUSD = getDataM(spr, getColumIndex(spr,"AmountExpenseUSD"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z3413.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3413_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K3413_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3413 As T3413_AREA, Job as String, PURCHASINGORDERNO AS String, EXPENSESEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3413_MOVE = False

Try
    If READ_PFK3413(PURCHASINGORDERNO, EXPENSESEQ) = True Then
                z3413 = D3413
		K3413_MOVE = True
		else
	z3413 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3413")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PURCHASINGORDERNO":z3413.PurchasingOrderNo = Children(i).Code
   Case "EXPENSESEQ":z3413.ExpenseSeq = Children(i).Code
   Case "SEEXPENSE":z3413.seExpense = Children(i).Code
   Case "CDEXPENSE":z3413.cdExpense = Children(i).Code
   Case "RATEEXPENSE":z3413.RateExpense = Children(i).Code
   Case "PACKEXPENSE":z3413.PackExpense = Children(i).Code
   Case "QTYEXPENSE":z3413.QtyExpense = Children(i).Code
   Case "AMOUNTEXPENSE":z3413.AmountExpense = Children(i).Code
   Case "AMOUNTEXPENSEVND":z3413.AmountExpenseVND = Children(i).Code
   Case "AMOUNTEXPENSEUSD":z3413.AmountExpenseUSD = Children(i).Code
   Case "REMARK":z3413.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PURCHASINGORDERNO":z3413.PurchasingOrderNo = Children(i).Data
   Case "EXPENSESEQ":z3413.ExpenseSeq = Children(i).Data
   Case "SEEXPENSE":z3413.seExpense = Children(i).Data
   Case "CDEXPENSE":z3413.cdExpense = Children(i).Data
   Case "RATEEXPENSE":z3413.RateExpense = Children(i).Data
   Case "PACKEXPENSE":z3413.PackExpense = Children(i).Data
   Case "QTYEXPENSE":z3413.QtyExpense = Children(i).Data
   Case "AMOUNTEXPENSE":z3413.AmountExpense = Children(i).Data
   Case "AMOUNTEXPENSEVND":z3413.AmountExpenseVND = Children(i).Data
   Case "AMOUNTEXPENSEUSD":z3413.AmountExpenseUSD = Children(i).Data
   Case "REMARK":z3413.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3413_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K3413_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3413 As T3413_AREA, Job as String, CheckClear as Boolean, PURCHASINGORDERNO AS String, EXPENSESEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3413_MOVE = False

Try
    If READ_PFK3413(PURCHASINGORDERNO, EXPENSESEQ) = True Then
                z3413 = D3413
		K3413_MOVE = True
		else
	If CheckClear  = True then z3413 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3413")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PURCHASINGORDERNO":z3413.PurchasingOrderNo = Children(i).Code
   Case "EXPENSESEQ":z3413.ExpenseSeq = Children(i).Code
   Case "SEEXPENSE":z3413.seExpense = Children(i).Code
   Case "CDEXPENSE":z3413.cdExpense = Children(i).Code
   Case "RATEEXPENSE":z3413.RateExpense = Children(i).Code
   Case "PACKEXPENSE":z3413.PackExpense = Children(i).Code
   Case "QTYEXPENSE":z3413.QtyExpense = Children(i).Code
   Case "AMOUNTEXPENSE":z3413.AmountExpense = Children(i).Code
   Case "AMOUNTEXPENSEVND":z3413.AmountExpenseVND = Children(i).Code
   Case "AMOUNTEXPENSEUSD":z3413.AmountExpenseUSD = Children(i).Code
   Case "REMARK":z3413.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PURCHASINGORDERNO":z3413.PurchasingOrderNo = Children(i).Data
   Case "EXPENSESEQ":z3413.ExpenseSeq = Children(i).Data
   Case "SEEXPENSE":z3413.seExpense = Children(i).Data
   Case "CDEXPENSE":z3413.cdExpense = Children(i).Data
   Case "RATEEXPENSE":z3413.RateExpense = Children(i).Data
   Case "PACKEXPENSE":z3413.PackExpense = Children(i).Data
   Case "QTYEXPENSE":z3413.QtyExpense = Children(i).Data
   Case "AMOUNTEXPENSE":z3413.AmountExpense = Children(i).Data
   Case "AMOUNTEXPENSEVND":z3413.AmountExpenseVND = Children(i).Data
   Case "AMOUNTEXPENSEUSD":z3413.AmountExpenseUSD = Children(i).Data
   Case "REMARK":z3413.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3413_MOVE",vbCritical)
End Try
End Function 
    
End Module 
