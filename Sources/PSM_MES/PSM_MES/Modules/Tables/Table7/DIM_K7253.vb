'=========================================================================================================================================================
'   TABLE : (PFK7253)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7253

Structure T7253_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	YearMaterial	 AS String	'			char(4)		*
Public 	MonthMaterial	 AS String	'			char(2)		*
Public 	CustomerCode	 AS String	'			char(6)		*
Public 	MaterialCode	 AS String	'			char(6)		*
Public 	CostMaterial	 AS Double	'			decimal
Public 	PriceSalesUsd	 AS Double	'			decimal
Public 	PriceSalesVND	 AS Double	'			decimal
Public 	PerProfit	 AS Double	'			decimal
Public 	PriceFinalUsd	 AS Double	'			decimal
Public 	PriceFinalVND	 AS Double	'			decimal
Public 	DateExchange	 AS String	'			char(8)
Public 	PriceExchange	 AS Double	'			decimal
Public 	Remark	 AS String	'			nvarchar(50)
'=========================================================================================================================================================
End structure

Public D7253 As T7253_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7253(YEARMATERIAL AS String, MONTHMATERIAL AS String, CUSTOMERCODE AS String, MATERIALCODE AS String) As Boolean
    READ_PFK7253 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7253 "
    SQL = SQL & " WHERE K7253_YearMaterial		 = '" & YearMaterial & "' " 
    SQL = SQL & "   AND K7253_MonthMaterial		 = '" & MonthMaterial & "' " 
    SQL = SQL & "   AND K7253_CustomerCode		 = '" & CustomerCode & "' " 
    SQL = SQL & "   AND K7253_MaterialCode		 = '" & MaterialCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7253_CLEAR: GoTo SKIP_READ_PFK7253
                
    Call K7253_MOVE(rd)
    READ_PFK7253 = True

SKIP_READ_PFK7253:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7253",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7253(YEARMATERIAL AS String, MONTHMATERIAL AS String, CUSTOMERCODE AS String, MATERIALCODE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7253 "
    SQL = SQL & " WHERE K7253_YearMaterial		 = '" & YearMaterial & "' " 
    SQL = SQL & "   AND K7253_MonthMaterial		 = '" & MonthMaterial & "' " 
    SQL = SQL & "   AND K7253_CustomerCode		 = '" & CustomerCode & "' " 
    SQL = SQL & "   AND K7253_MaterialCode		 = '" & MaterialCode & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7253",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7253(z7253 As T7253_AREA) As Boolean
    WRITE_PFK7253 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7253)
 
    SQL = " INSERT INTO PFK7253 "
    SQL = SQL & " ( "
    SQL = SQL & " K7253_YearMaterial," 
    SQL = SQL & " K7253_MonthMaterial," 
    SQL = SQL & " K7253_CustomerCode," 
    SQL = SQL & " K7253_MaterialCode," 
            SQL = SQL & " K7253_CostMaterial,"
    SQL = SQL & " K7253_PriceSalesUsd," 
    SQL = SQL & " K7253_PriceSalesVND," 
    SQL = SQL & " K7253_PerProfit," 
    SQL = SQL & " K7253_PriceFinalUsd," 
    SQL = SQL & " K7253_PriceFinalVND," 
    SQL = SQL & " K7253_DateExchange," 
    SQL = SQL & " K7253_PriceExchange," 
    SQL = SQL & " K7253_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7253.YearMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7253.MonthMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7253.CustomerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7253.MaterialCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z7253.CostMaterial) & ", "  
    SQL = SQL & "   " & FormatSQL(z7253.PriceSalesUsd) & ", "  
    SQL = SQL & "   " & FormatSQL(z7253.PriceSalesVND) & ", "  
    SQL = SQL & "   " & FormatSQL(z7253.PerProfit) & ", "  
    SQL = SQL & "   " & FormatSQL(z7253.PriceFinalUsd) & ", "  
    SQL = SQL & "   " & FormatSQL(z7253.PriceFinalVND) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7253.DateExchange) & "', "  
    SQL = SQL & "   " & FormatSQL(z7253.PriceExchange) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7253.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7253 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7253",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7253(z7253 As T7253_AREA) As Boolean
    REWRITE_PFK7253 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7253)
   
    SQL = " UPDATE PFK7253 SET "
            SQL = SQL & "    K7253_CostMaterial      =  " & FormatSQL(z7253.CostMaterial) & ", "
    SQL = SQL & "    K7253_PriceSalesUsd      =  " & FormatSQL(z7253.PriceSalesUsd) & ", " 
    SQL = SQL & "    K7253_PriceSalesVND      =  " & FormatSQL(z7253.PriceSalesVND) & ", " 
    SQL = SQL & "    K7253_PerProfit      =  " & FormatSQL(z7253.PerProfit) & ", " 
    SQL = SQL & "    K7253_PriceFinalUsd      =  " & FormatSQL(z7253.PriceFinalUsd) & ", " 
    SQL = SQL & "    K7253_PriceFinalVND      =  " & FormatSQL(z7253.PriceFinalVND) & ", " 
    SQL = SQL & "    K7253_DateExchange      = N'" & FormatSQL(z7253.DateExchange) & "', " 
    SQL = SQL & "    K7253_PriceExchange      =  " & FormatSQL(z7253.PriceExchange) & ", " 
    SQL = SQL & "    K7253_Remark      = N'" & FormatSQL(z7253.Remark) & "'  " 
    SQL = SQL & " WHERE K7253_YearMaterial		 = '" & z7253.YearMaterial & "' " 
    SQL = SQL & "   AND K7253_MonthMaterial		 = '" & z7253.MonthMaterial & "' " 
    SQL = SQL & "   AND K7253_CustomerCode		 = '" & z7253.CustomerCode & "' " 
    SQL = SQL & "   AND K7253_MaterialCode		 = '" & z7253.MaterialCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7253 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7253",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7253(z7253 As T7253_AREA) As Boolean
    DELETE_PFK7253 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7253 "
    SQL = SQL & " WHERE K7253_YearMaterial		 = '" & z7253.YearMaterial & "' " 
    SQL = SQL & "   AND K7253_MonthMaterial		 = '" & z7253.MonthMaterial & "' " 
    SQL = SQL & "   AND K7253_CustomerCode		 = '" & z7253.CustomerCode & "' " 
    SQL = SQL & "   AND K7253_MaterialCode		 = '" & z7253.MaterialCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7253 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7253",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7253_CLEAR()
Try
    
   D7253.YearMaterial = ""
   D7253.MonthMaterial = ""
   D7253.CustomerCode = ""
   D7253.MaterialCode = ""
    D7253.CostMaterial = 0 
    D7253.PriceSalesUsd = 0 
    D7253.PriceSalesVND = 0 
    D7253.PerProfit = 0 
    D7253.PriceFinalUsd = 0 
    D7253.PriceFinalVND = 0 
   D7253.DateExchange = ""
    D7253.PriceExchange = 0 
   D7253.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7253_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7253 As T7253_AREA)
Try
    
    x7253.YearMaterial = trim$(  x7253.YearMaterial)
    x7253.MonthMaterial = trim$(  x7253.MonthMaterial)
    x7253.CustomerCode = trim$(  x7253.CustomerCode)
    x7253.MaterialCode = trim$(  x7253.MaterialCode)
    x7253.CostMaterial = trim$(  x7253.CostMaterial)
    x7253.PriceSalesUsd = trim$(  x7253.PriceSalesUsd)
    x7253.PriceSalesVND = trim$(  x7253.PriceSalesVND)
    x7253.PerProfit = trim$(  x7253.PerProfit)
    x7253.PriceFinalUsd = trim$(  x7253.PriceFinalUsd)
    x7253.PriceFinalVND = trim$(  x7253.PriceFinalVND)
    x7253.DateExchange = trim$(  x7253.DateExchange)
    x7253.PriceExchange = trim$(  x7253.PriceExchange)
    x7253.Remark = trim$(  x7253.Remark)
     
    If trim$( x7253.YearMaterial ) = "" Then x7253.YearMaterial = Space(1) 
    If trim$( x7253.MonthMaterial ) = "" Then x7253.MonthMaterial = Space(1) 
    If trim$( x7253.CustomerCode ) = "" Then x7253.CustomerCode = Space(1) 
    If trim$( x7253.MaterialCode ) = "" Then x7253.MaterialCode = Space(1) 
    If trim$( x7253.CostMaterial ) = "" Then x7253.CostMaterial = 0 
    If trim$( x7253.PriceSalesUsd ) = "" Then x7253.PriceSalesUsd = 0 
    If trim$( x7253.PriceSalesVND ) = "" Then x7253.PriceSalesVND = 0 
    If trim$( x7253.PerProfit ) = "" Then x7253.PerProfit = 0 
    If trim$( x7253.PriceFinalUsd ) = "" Then x7253.PriceFinalUsd = 0 
    If trim$( x7253.PriceFinalVND ) = "" Then x7253.PriceFinalVND = 0 
    If trim$( x7253.DateExchange ) = "" Then x7253.DateExchange = Space(1) 
    If trim$( x7253.PriceExchange ) = "" Then x7253.PriceExchange = 0 
    If trim$( x7253.Remark ) = "" Then x7253.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7253_MOVE(rs7253 As SqlClient.SqlDataReader)
Try

    call D7253_CLEAR()   

    If IsdbNull(rs7253!K7253_YearMaterial) = False Then D7253.YearMaterial = Trim$(rs7253!K7253_YearMaterial)
    If IsdbNull(rs7253!K7253_MonthMaterial) = False Then D7253.MonthMaterial = Trim$(rs7253!K7253_MonthMaterial)
    If IsdbNull(rs7253!K7253_CustomerCode) = False Then D7253.CustomerCode = Trim$(rs7253!K7253_CustomerCode)
    If IsdbNull(rs7253!K7253_MaterialCode) = False Then D7253.MaterialCode = Trim$(rs7253!K7253_MaterialCode)
    If IsdbNull(rs7253!K7253_CostMaterial) = False Then D7253.CostMaterial = Trim$(rs7253!K7253_CostMaterial)
    If IsdbNull(rs7253!K7253_PriceSalesUsd) = False Then D7253.PriceSalesUsd = Trim$(rs7253!K7253_PriceSalesUsd)
    If IsdbNull(rs7253!K7253_PriceSalesVND) = False Then D7253.PriceSalesVND = Trim$(rs7253!K7253_PriceSalesVND)
    If IsdbNull(rs7253!K7253_PerProfit) = False Then D7253.PerProfit = Trim$(rs7253!K7253_PerProfit)
    If IsdbNull(rs7253!K7253_PriceFinalUsd) = False Then D7253.PriceFinalUsd = Trim$(rs7253!K7253_PriceFinalUsd)
    If IsdbNull(rs7253!K7253_PriceFinalVND) = False Then D7253.PriceFinalVND = Trim$(rs7253!K7253_PriceFinalVND)
    If IsdbNull(rs7253!K7253_DateExchange) = False Then D7253.DateExchange = Trim$(rs7253!K7253_DateExchange)
    If IsdbNull(rs7253!K7253_PriceExchange) = False Then D7253.PriceExchange = Trim$(rs7253!K7253_PriceExchange)
    If IsdbNull(rs7253!K7253_Remark) = False Then D7253.Remark = Trim$(rs7253!K7253_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7253_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7253_MOVE(rs7253 As DataRow)
Try

    call D7253_CLEAR()   

    If IsdbNull(rs7253!K7253_YearMaterial) = False Then D7253.YearMaterial = Trim$(rs7253!K7253_YearMaterial)
    If IsdbNull(rs7253!K7253_MonthMaterial) = False Then D7253.MonthMaterial = Trim$(rs7253!K7253_MonthMaterial)
    If IsdbNull(rs7253!K7253_CustomerCode) = False Then D7253.CustomerCode = Trim$(rs7253!K7253_CustomerCode)
    If IsdbNull(rs7253!K7253_MaterialCode) = False Then D7253.MaterialCode = Trim$(rs7253!K7253_MaterialCode)
    If IsdbNull(rs7253!K7253_CostMaterial) = False Then D7253.CostMaterial = Trim$(rs7253!K7253_CostMaterial)
    If IsdbNull(rs7253!K7253_PriceSalesUsd) = False Then D7253.PriceSalesUsd = Trim$(rs7253!K7253_PriceSalesUsd)
    If IsdbNull(rs7253!K7253_PriceSalesVND) = False Then D7253.PriceSalesVND = Trim$(rs7253!K7253_PriceSalesVND)
    If IsdbNull(rs7253!K7253_PerProfit) = False Then D7253.PerProfit = Trim$(rs7253!K7253_PerProfit)
    If IsdbNull(rs7253!K7253_PriceFinalUsd) = False Then D7253.PriceFinalUsd = Trim$(rs7253!K7253_PriceFinalUsd)
    If IsdbNull(rs7253!K7253_PriceFinalVND) = False Then D7253.PriceFinalVND = Trim$(rs7253!K7253_PriceFinalVND)
    If IsdbNull(rs7253!K7253_DateExchange) = False Then D7253.DateExchange = Trim$(rs7253!K7253_DateExchange)
    If IsdbNull(rs7253!K7253_PriceExchange) = False Then D7253.PriceExchange = Trim$(rs7253!K7253_PriceExchange)
    If IsdbNull(rs7253!K7253_Remark) = False Then D7253.Remark = Trim$(rs7253!K7253_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7253_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7253_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7253 As T7253_AREA, YEARMATERIAL AS String, MONTHMATERIAL AS String, CUSTOMERCODE AS String, MATERIALCODE AS String) as Boolean

K7253_MOVE = False

Try
    If READ_PFK7253(YEARMATERIAL, MONTHMATERIAL, CUSTOMERCODE, MATERIALCODE) = True Then
                z7253 = D7253
		K7253_MOVE = True
		else
	z7253 = nothing
     End If

     If  getColumIndex(spr,"YearMaterial") > -1 then z7253.YearMaterial = getDataM(spr, getColumIndex(spr,"YearMaterial"), xRow)
     If  getColumIndex(spr,"MonthMaterial") > -1 then z7253.MonthMaterial = getDataM(spr, getColumIndex(spr,"MonthMaterial"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z7253.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z7253.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"CostMaterial") > -1 then z7253.CostMaterial = getDataM(spr, getColumIndex(spr,"CostMaterial"), xRow)
     If  getColumIndex(spr,"PriceSalesUsd") > -1 then z7253.PriceSalesUsd = getDataM(spr, getColumIndex(spr,"PriceSalesUsd"), xRow)
     If  getColumIndex(spr,"PriceSalesVND") > -1 then z7253.PriceSalesVND = getDataM(spr, getColumIndex(spr,"PriceSalesVND"), xRow)
     If  getColumIndex(spr,"PerProfit") > -1 then z7253.PerProfit = getDataM(spr, getColumIndex(spr,"PerProfit"), xRow)
     If  getColumIndex(spr,"PriceFinalUsd") > -1 then z7253.PriceFinalUsd = getDataM(spr, getColumIndex(spr,"PriceFinalUsd"), xRow)
     If  getColumIndex(spr,"PriceFinalVND") > -1 then z7253.PriceFinalVND = getDataM(spr, getColumIndex(spr,"PriceFinalVND"), xRow)
     If  getColumIndex(spr,"DateExchange") > -1 then z7253.DateExchange = getDataM(spr, getColumIndex(spr,"DateExchange"), xRow)
     If  getColumIndex(spr,"PriceExchange") > -1 then z7253.PriceExchange = getDataM(spr, getColumIndex(spr,"PriceExchange"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7253.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7253_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7253_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7253 As T7253_AREA,CheckClear as Boolean,YEARMATERIAL AS String, MONTHMATERIAL AS String, CUSTOMERCODE AS String, MATERIALCODE AS String) as Boolean

K7253_MOVE = False

Try
    If READ_PFK7253(YEARMATERIAL, MONTHMATERIAL, CUSTOMERCODE, MATERIALCODE) = True Then
                z7253 = D7253
		K7253_MOVE = True
		else
	If CheckClear  = True then z7253 = nothing
     End If

     If  getColumIndex(spr,"YearMaterial") > -1 then z7253.YearMaterial = getDataM(spr, getColumIndex(spr,"YearMaterial"), xRow)
     If  getColumIndex(spr,"MonthMaterial") > -1 then z7253.MonthMaterial = getDataM(spr, getColumIndex(spr,"MonthMaterial"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z7253.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z7253.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"CostMaterial") > -1 then z7253.CostMaterial = getDataM(spr, getColumIndex(spr,"CostMaterial"), xRow)
     If  getColumIndex(spr,"PriceSalesUsd") > -1 then z7253.PriceSalesUsd = getDataM(spr, getColumIndex(spr,"PriceSalesUsd"), xRow)
     If  getColumIndex(spr,"PriceSalesVND") > -1 then z7253.PriceSalesVND = getDataM(spr, getColumIndex(spr,"PriceSalesVND"), xRow)
     If  getColumIndex(spr,"PerProfit") > -1 then z7253.PerProfit = getDataM(spr, getColumIndex(spr,"PerProfit"), xRow)
     If  getColumIndex(spr,"PriceFinalUsd") > -1 then z7253.PriceFinalUsd = getDataM(spr, getColumIndex(spr,"PriceFinalUsd"), xRow)
     If  getColumIndex(spr,"PriceFinalVND") > -1 then z7253.PriceFinalVND = getDataM(spr, getColumIndex(spr,"PriceFinalVND"), xRow)
     If  getColumIndex(spr,"DateExchange") > -1 then z7253.DateExchange = getDataM(spr, getColumIndex(spr,"DateExchange"), xRow)
     If  getColumIndex(spr,"PriceExchange") > -1 then z7253.PriceExchange = getDataM(spr, getColumIndex(spr,"PriceExchange"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7253.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7253_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7253_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7253 As T7253_AREA, Job as String, YEARMATERIAL AS String, MONTHMATERIAL AS String, CUSTOMERCODE AS String, MATERIALCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7253_MOVE = False

Try
    If READ_PFK7253(YEARMATERIAL, MONTHMATERIAL, CUSTOMERCODE, MATERIALCODE) = True Then
                z7253 = D7253
		K7253_MOVE = True
		else
	z7253 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7253")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "YEARMATERIAL":z7253.YearMaterial = Children(i).Code
   Case "MONTHMATERIAL":z7253.MonthMaterial = Children(i).Code
   Case "CUSTOMERCODE":z7253.CustomerCode = Children(i).Code
   Case "MATERIALCODE":z7253.MaterialCode = Children(i).Code
   Case "COSTMATERIAL":z7253.CostMaterial = Children(i).Code
   Case "PRICESALESUSD":z7253.PriceSalesUsd = Children(i).Code
   Case "PRICESALESVND":z7253.PriceSalesVND = Children(i).Code
   Case "PERPROFIT":z7253.PerProfit = Children(i).Code
   Case "PRICEFINALUSD":z7253.PriceFinalUsd = Children(i).Code
   Case "PRICEFINALVND":z7253.PriceFinalVND = Children(i).Code
   Case "DATEEXCHANGE":z7253.DateExchange = Children(i).Code
   Case "PRICEEXCHANGE":z7253.PriceExchange = Children(i).Code
   Case "REMARK":z7253.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "YEARMATERIAL":z7253.YearMaterial = Children(i).Data
   Case "MONTHMATERIAL":z7253.MonthMaterial = Children(i).Data
   Case "CUSTOMERCODE":z7253.CustomerCode = Children(i).Data
   Case "MATERIALCODE":z7253.MaterialCode = Children(i).Data
   Case "COSTMATERIAL":z7253.CostMaterial = Children(i).Data
   Case "PRICESALESUSD":z7253.PriceSalesUsd = Children(i).Data
   Case "PRICESALESVND":z7253.PriceSalesVND = Children(i).Data
   Case "PERPROFIT":z7253.PerProfit = Children(i).Data
   Case "PRICEFINALUSD":z7253.PriceFinalUsd = Children(i).Data
   Case "PRICEFINALVND":z7253.PriceFinalVND = Children(i).Data
   Case "DATEEXCHANGE":z7253.DateExchange = Children(i).Data
   Case "PRICEEXCHANGE":z7253.PriceExchange = Children(i).Data
   Case "REMARK":z7253.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7253_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7253_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7253 As T7253_AREA, Job as String, CheckClear as Boolean, YEARMATERIAL AS String, MONTHMATERIAL AS String, CUSTOMERCODE AS String, MATERIALCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7253_MOVE = False

Try
    If READ_PFK7253(YEARMATERIAL, MONTHMATERIAL, CUSTOMERCODE, MATERIALCODE) = True Then
                z7253 = D7253
		K7253_MOVE = True
		else
	If CheckClear  = True then z7253 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7253")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "YEARMATERIAL":z7253.YearMaterial = Children(i).Code
   Case "MONTHMATERIAL":z7253.MonthMaterial = Children(i).Code
   Case "CUSTOMERCODE":z7253.CustomerCode = Children(i).Code
   Case "MATERIALCODE":z7253.MaterialCode = Children(i).Code
   Case "COSTMATERIAL":z7253.CostMaterial = Children(i).Code
   Case "PRICESALESUSD":z7253.PriceSalesUsd = Children(i).Code
   Case "PRICESALESVND":z7253.PriceSalesVND = Children(i).Code
   Case "PERPROFIT":z7253.PerProfit = Children(i).Code
   Case "PRICEFINALUSD":z7253.PriceFinalUsd = Children(i).Code
   Case "PRICEFINALVND":z7253.PriceFinalVND = Children(i).Code
   Case "DATEEXCHANGE":z7253.DateExchange = Children(i).Code
   Case "PRICEEXCHANGE":z7253.PriceExchange = Children(i).Code
   Case "REMARK":z7253.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "YEARMATERIAL":z7253.YearMaterial = Children(i).Data
   Case "MONTHMATERIAL":z7253.MonthMaterial = Children(i).Data
   Case "CUSTOMERCODE":z7253.CustomerCode = Children(i).Data
   Case "MATERIALCODE":z7253.MaterialCode = Children(i).Data
   Case "COSTMATERIAL":z7253.CostMaterial = Children(i).Data
   Case "PRICESALESUSD":z7253.PriceSalesUsd = Children(i).Data
   Case "PRICESALESVND":z7253.PriceSalesVND = Children(i).Data
   Case "PERPROFIT":z7253.PerProfit = Children(i).Data
   Case "PRICEFINALUSD":z7253.PriceFinalUsd = Children(i).Data
   Case "PRICEFINALVND":z7253.PriceFinalVND = Children(i).Data
   Case "DATEEXCHANGE":z7253.DateExchange = Children(i).Data
   Case "PRICEEXCHANGE":z7253.PriceExchange = Children(i).Data
   Case "REMARK":z7253.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7253_MOVE",vbCritical)
End Try
End Function 
    
End Module 
