'=========================================================================================================================================================
'   TABLE : (PFK7199)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7199

Structure T7199_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	DateExchange	 AS String	'			char(8)		*
Public 	seUnitPrice	 AS String	'			char(3)		*
Public 	cdUnitPrice	 AS String	'			char(3)		*
Public 	Value	 AS Double	'			decimal
Public 	Value1	 AS Double	'			decimal
Public 	Value2	 AS Double	'			decimal
Public 	Value3	 AS Double	'			decimal
Public 	Value4	 AS Double	'			decimal
Public 	Value5	 AS Double	'			decimal
Public 	Value6	 AS Double	'			decimal
Public 	Value7	 AS Double	'			decimal
Public 	Value8	 AS Double	'			decimal
Public 	Value9	 AS Double	'			decimal
Public 	Remark	 AS Double	'			decimal
'=========================================================================================================================================================
End structure

Public D7199 As T7199_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7199(DATEEXCHANGE AS String, SEUNITPRICE AS String, CDUNITPRICE AS String) As Boolean
    READ_PFK7199 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7199 "
            SQL = SQL & " WHERE K7199_DateExchange		 <= '" & DATEEXCHANGE & "' "
            SQL = SQL & "   AND K7199_seUnitPrice		 = '" & SEUNITPRICE & "' "
            SQL = SQL & "   AND K7199_cdUnitPrice		 = '" & CDUNITPRICE & "' ORDER BY K7199_DateExchange DESC"
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7199_CLEAR: GoTo SKIP_READ_PFK7199
                
    Call K7199_MOVE(rd)
    READ_PFK7199 = True

SKIP_READ_PFK7199:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7199",vbCritical)
 End Try
    End Function

    Public Function READ_PFK7199_IU(DATEEXCHANGE As String, SEUNITPRICE As String, CDUNITPRICE As String) As Boolean
        READ_PFK7199_IU = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7199 "
            SQL = SQL & " WHERE K7199_DateExchange		 = '" & DATEEXCHANGE & "' "
            SQL = SQL & "   AND K7199_seUnitPrice		 = '" & SEUNITPRICE & "' "
            SQL = SQL & "   AND K7199_cdUnitPrice		 = '" & CDUNITPRICE & "' ORDER BY K7199_DateExchange DESC"
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7199_CLEAR() : GoTo SKIP_READ_PFK7199

            Call K7199_MOVE(rd)
            READ_PFK7199_IU = True

SKIP_READ_PFK7199:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7199", vbCritical)
        End Try
    End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7199(DATEEXCHANGE AS String, SEUNITPRICE AS String, CDUNITPRICE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7199 "
    SQL = SQL & " WHERE K7199_DateExchange		 = '" & DateExchange & "' " 
    SQL = SQL & "   AND K7199_seUnitPrice		 = '" & seUnitPrice & "' " 
            SQL = SQL & "   AND K7199_cdUnitPrice		 = '" & CDUNITPRICE & "' ORDER BY K7199_DateExchange DESC"
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7199",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7199(z7199 As T7199_AREA) As Boolean
    WRITE_PFK7199 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7199)
 
    SQL = " INSERT INTO PFK7199 "
    SQL = SQL & " ( "
    SQL = SQL & " K7199_DateExchange," 
    SQL = SQL & " K7199_seUnitPrice," 
    SQL = SQL & " K7199_cdUnitPrice," 
    SQL = SQL & " K7199_Value," 
    SQL = SQL & " K7199_Value1," 
    SQL = SQL & " K7199_Value2," 
    SQL = SQL & " K7199_Value3," 
    SQL = SQL & " K7199_Value4," 
    SQL = SQL & " K7199_Value5," 
    SQL = SQL & " K7199_Value6," 
    SQL = SQL & " K7199_Value7," 
    SQL = SQL & " K7199_Value8," 
    SQL = SQL & " K7199_Value9," 
    SQL = SQL & " K7199_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7199.DateExchange) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7199.seUnitPrice) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7199.cdUnitPrice) & "', "  
    SQL = SQL & "   " & FormatSQL(z7199.Value) & ", "  
    SQL = SQL & "   " & FormatSQL(z7199.Value1) & ", "  
    SQL = SQL & "   " & FormatSQL(z7199.Value2) & ", "  
    SQL = SQL & "   " & FormatSQL(z7199.Value3) & ", "  
    SQL = SQL & "   " & FormatSQL(z7199.Value4) & ", "  
    SQL = SQL & "   " & FormatSQL(z7199.Value5) & ", "  
    SQL = SQL & "   " & FormatSQL(z7199.Value6) & ", "  
    SQL = SQL & "   " & FormatSQL(z7199.Value7) & ", "  
    SQL = SQL & "   " & FormatSQL(z7199.Value8) & ", "  
    SQL = SQL & "   " & FormatSQL(z7199.Value9) & ", "  
    SQL = SQL & "   " & FormatSQL(z7199.Remark) & "  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7199 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7199",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7199(z7199 As T7199_AREA) As Boolean
    REWRITE_PFK7199 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7199)
   
    SQL = " UPDATE PFK7199 SET "
    SQL = SQL & "    K7199_Value      =  " & FormatSQL(z7199.Value) & ", " 
    SQL = SQL & "    K7199_Value1      =  " & FormatSQL(z7199.Value1) & ", " 
    SQL = SQL & "    K7199_Value2      =  " & FormatSQL(z7199.Value2) & ", " 
    SQL = SQL & "    K7199_Value3      =  " & FormatSQL(z7199.Value3) & ", " 
    SQL = SQL & "    K7199_Value4      =  " & FormatSQL(z7199.Value4) & ", " 
    SQL = SQL & "    K7199_Value5      =  " & FormatSQL(z7199.Value5) & ", " 
    SQL = SQL & "    K7199_Value6      =  " & FormatSQL(z7199.Value6) & ", " 
    SQL = SQL & "    K7199_Value7      =  " & FormatSQL(z7199.Value7) & ", " 
    SQL = SQL & "    K7199_Value8      =  " & FormatSQL(z7199.Value8) & ", " 
    SQL = SQL & "    K7199_Value9      =  " & FormatSQL(z7199.Value9) & ", " 
    SQL = SQL & "    K7199_Remark      =  " & FormatSQL(z7199.Remark) & "  " 
    SQL = SQL & " WHERE K7199_DateExchange		 = '" & z7199.DateExchange & "' " 
    SQL = SQL & "   AND K7199_seUnitPrice		 = '" & z7199.seUnitPrice & "' " 
    SQL = SQL & "   AND K7199_cdUnitPrice		 = '" & z7199.cdUnitPrice & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7199 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7199",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7199(z7199 As T7199_AREA) As Boolean
    DELETE_PFK7199 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7199 "
    SQL = SQL & " WHERE K7199_DateExchange		 = '" & z7199.DateExchange & "' " 
    SQL = SQL & "   AND K7199_seUnitPrice		 = '" & z7199.seUnitPrice & "' " 
    SQL = SQL & "   AND K7199_cdUnitPrice		 = '" & z7199.cdUnitPrice & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7199 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7199",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7199_CLEAR()
Try
    
   D7199.DateExchange = ""
   D7199.seUnitPrice = ""
   D7199.cdUnitPrice = ""
    D7199.Value = 0 
    D7199.Value1 = 0 
    D7199.Value2 = 0 
    D7199.Value3 = 0 
    D7199.Value4 = 0 
    D7199.Value5 = 0 
    D7199.Value6 = 0 
    D7199.Value7 = 0 
    D7199.Value8 = 0 
    D7199.Value9 = 0 
    D7199.Remark = 0 

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7199_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7199 As T7199_AREA)
Try
    
    x7199.DateExchange = trim$(  x7199.DateExchange)
    x7199.seUnitPrice = trim$(  x7199.seUnitPrice)
    x7199.cdUnitPrice = trim$(  x7199.cdUnitPrice)
    x7199.Value = trim$(  x7199.Value)
    x7199.Value1 = trim$(  x7199.Value1)
    x7199.Value2 = trim$(  x7199.Value2)
    x7199.Value3 = trim$(  x7199.Value3)
    x7199.Value4 = trim$(  x7199.Value4)
    x7199.Value5 = trim$(  x7199.Value5)
    x7199.Value6 = trim$(  x7199.Value6)
    x7199.Value7 = trim$(  x7199.Value7)
    x7199.Value8 = trim$(  x7199.Value8)
    x7199.Value9 = trim$(  x7199.Value9)
    x7199.Remark = trim$(  x7199.Remark)
     
    If trim$( x7199.DateExchange ) = "" Then x7199.DateExchange = Space(1) 
    If trim$( x7199.seUnitPrice ) = "" Then x7199.seUnitPrice = Space(1) 
    If trim$( x7199.cdUnitPrice ) = "" Then x7199.cdUnitPrice = Space(1) 
    If trim$( x7199.Value ) = "" Then x7199.Value = 0 
    If trim$( x7199.Value1 ) = "" Then x7199.Value1 = 0 
    If trim$( x7199.Value2 ) = "" Then x7199.Value2 = 0 
    If trim$( x7199.Value3 ) = "" Then x7199.Value3 = 0 
    If trim$( x7199.Value4 ) = "" Then x7199.Value4 = 0 
    If trim$( x7199.Value5 ) = "" Then x7199.Value5 = 0 
    If trim$( x7199.Value6 ) = "" Then x7199.Value6 = 0 
    If trim$( x7199.Value7 ) = "" Then x7199.Value7 = 0 
    If trim$( x7199.Value8 ) = "" Then x7199.Value8 = 0 
    If trim$( x7199.Value9 ) = "" Then x7199.Value9 = 0 
    If trim$( x7199.Remark ) = "" Then x7199.Remark = 0 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7199_MOVE(rs7199 As SqlClient.SqlDataReader)
Try

    call D7199_CLEAR()   

    If IsdbNull(rs7199!K7199_DateExchange) = False Then D7199.DateExchange = Trim$(rs7199!K7199_DateExchange)
    If IsdbNull(rs7199!K7199_seUnitPrice) = False Then D7199.seUnitPrice = Trim$(rs7199!K7199_seUnitPrice)
    If IsdbNull(rs7199!K7199_cdUnitPrice) = False Then D7199.cdUnitPrice = Trim$(rs7199!K7199_cdUnitPrice)
    If IsdbNull(rs7199!K7199_Value) = False Then D7199.Value = Trim$(rs7199!K7199_Value)
    If IsdbNull(rs7199!K7199_Value1) = False Then D7199.Value1 = Trim$(rs7199!K7199_Value1)
    If IsdbNull(rs7199!K7199_Value2) = False Then D7199.Value2 = Trim$(rs7199!K7199_Value2)
    If IsdbNull(rs7199!K7199_Value3) = False Then D7199.Value3 = Trim$(rs7199!K7199_Value3)
    If IsdbNull(rs7199!K7199_Value4) = False Then D7199.Value4 = Trim$(rs7199!K7199_Value4)
    If IsdbNull(rs7199!K7199_Value5) = False Then D7199.Value5 = Trim$(rs7199!K7199_Value5)
    If IsdbNull(rs7199!K7199_Value6) = False Then D7199.Value6 = Trim$(rs7199!K7199_Value6)
    If IsdbNull(rs7199!K7199_Value7) = False Then D7199.Value7 = Trim$(rs7199!K7199_Value7)
    If IsdbNull(rs7199!K7199_Value8) = False Then D7199.Value8 = Trim$(rs7199!K7199_Value8)
    If IsdbNull(rs7199!K7199_Value9) = False Then D7199.Value9 = Trim$(rs7199!K7199_Value9)
    If IsdbNull(rs7199!K7199_Remark) = False Then D7199.Remark = Trim$(rs7199!K7199_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7199_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7199_MOVE(rs7199 As DataRow)
Try

    call D7199_CLEAR()   

    If IsdbNull(rs7199!K7199_DateExchange) = False Then D7199.DateExchange = Trim$(rs7199!K7199_DateExchange)
    If IsdbNull(rs7199!K7199_seUnitPrice) = False Then D7199.seUnitPrice = Trim$(rs7199!K7199_seUnitPrice)
    If IsdbNull(rs7199!K7199_cdUnitPrice) = False Then D7199.cdUnitPrice = Trim$(rs7199!K7199_cdUnitPrice)
    If IsdbNull(rs7199!K7199_Value) = False Then D7199.Value = Trim$(rs7199!K7199_Value)
    If IsdbNull(rs7199!K7199_Value1) = False Then D7199.Value1 = Trim$(rs7199!K7199_Value1)
    If IsdbNull(rs7199!K7199_Value2) = False Then D7199.Value2 = Trim$(rs7199!K7199_Value2)
    If IsdbNull(rs7199!K7199_Value3) = False Then D7199.Value3 = Trim$(rs7199!K7199_Value3)
    If IsdbNull(rs7199!K7199_Value4) = False Then D7199.Value4 = Trim$(rs7199!K7199_Value4)
    If IsdbNull(rs7199!K7199_Value5) = False Then D7199.Value5 = Trim$(rs7199!K7199_Value5)
    If IsdbNull(rs7199!K7199_Value6) = False Then D7199.Value6 = Trim$(rs7199!K7199_Value6)
    If IsdbNull(rs7199!K7199_Value7) = False Then D7199.Value7 = Trim$(rs7199!K7199_Value7)
    If IsdbNull(rs7199!K7199_Value8) = False Then D7199.Value8 = Trim$(rs7199!K7199_Value8)
    If IsdbNull(rs7199!K7199_Value9) = False Then D7199.Value9 = Trim$(rs7199!K7199_Value9)
    If IsdbNull(rs7199!K7199_Remark) = False Then D7199.Remark = Trim$(rs7199!K7199_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7199_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7199_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7199 As T7199_AREA, DATEEXCHANGE AS String, SEUNITPRICE AS String, CDUNITPRICE AS String) as Boolean

K7199_MOVE = False

Try
    If READ_PFK7199(DATEEXCHANGE, SEUNITPRICE, CDUNITPRICE) = True Then
                z7199 = D7199
		K7199_MOVE = True
		else
	z7199 = nothing
     End If

     If  getColumIndex(spr,"DateExchange") > -1 then z7199.DateExchange = getDataM(spr, getColumIndex(spr,"DateExchange"), xRow)
     If  getColumIndex(spr,"seUnitPrice") > -1 then z7199.seUnitPrice = getDataM(spr, getColumIndex(spr,"seUnitPrice"), xRow)
     If  getColumIndex(spr,"cdUnitPrice") > -1 then z7199.cdUnitPrice = getDataM(spr, getColumIndex(spr,"cdUnitPrice"), xRow)
     If  getColumIndex(spr,"Value") > -1 then z7199.Value = getDataM(spr, getColumIndex(spr,"Value"), xRow)
     If  getColumIndex(spr,"Value1") > -1 then z7199.Value1 = getDataM(spr, getColumIndex(spr,"Value1"), xRow)
     If  getColumIndex(spr,"Value2") > -1 then z7199.Value2 = getDataM(spr, getColumIndex(spr,"Value2"), xRow)
     If  getColumIndex(spr,"Value3") > -1 then z7199.Value3 = getDataM(spr, getColumIndex(spr,"Value3"), xRow)
     If  getColumIndex(spr,"Value4") > -1 then z7199.Value4 = getDataM(spr, getColumIndex(spr,"Value4"), xRow)
     If  getColumIndex(spr,"Value5") > -1 then z7199.Value5 = getDataM(spr, getColumIndex(spr,"Value5"), xRow)
     If  getColumIndex(spr,"Value6") > -1 then z7199.Value6 = getDataM(spr, getColumIndex(spr,"Value6"), xRow)
     If  getColumIndex(spr,"Value7") > -1 then z7199.Value7 = getDataM(spr, getColumIndex(spr,"Value7"), xRow)
     If  getColumIndex(spr,"Value8") > -1 then z7199.Value8 = getDataM(spr, getColumIndex(spr,"Value8"), xRow)
     If  getColumIndex(spr,"Value9") > -1 then z7199.Value9 = getDataM(spr, getColumIndex(spr,"Value9"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7199.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7199_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7199_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7199 As T7199_AREA,CheckClear as Boolean,DATEEXCHANGE AS String, SEUNITPRICE AS String, CDUNITPRICE AS String) as Boolean

K7199_MOVE = False

Try
    If READ_PFK7199(DATEEXCHANGE, SEUNITPRICE, CDUNITPRICE) = True Then
                z7199 = D7199
		K7199_MOVE = True
		else
	If CheckClear  = True then z7199 = nothing
     End If

     If  getColumIndex(spr,"DateExchange") > -1 then z7199.DateExchange = getDataM(spr, getColumIndex(spr,"DateExchange"), xRow)
     If  getColumIndex(spr,"seUnitPrice") > -1 then z7199.seUnitPrice = getDataM(spr, getColumIndex(spr,"seUnitPrice"), xRow)
     If  getColumIndex(spr,"cdUnitPrice") > -1 then z7199.cdUnitPrice = getDataM(spr, getColumIndex(spr,"cdUnitPrice"), xRow)
     If  getColumIndex(spr,"Value") > -1 then z7199.Value = getDataM(spr, getColumIndex(spr,"Value"), xRow)
     If  getColumIndex(spr,"Value1") > -1 then z7199.Value1 = getDataM(spr, getColumIndex(spr,"Value1"), xRow)
     If  getColumIndex(spr,"Value2") > -1 then z7199.Value2 = getDataM(spr, getColumIndex(spr,"Value2"), xRow)
     If  getColumIndex(spr,"Value3") > -1 then z7199.Value3 = getDataM(spr, getColumIndex(spr,"Value3"), xRow)
     If  getColumIndex(spr,"Value4") > -1 then z7199.Value4 = getDataM(spr, getColumIndex(spr,"Value4"), xRow)
     If  getColumIndex(spr,"Value5") > -1 then z7199.Value5 = getDataM(spr, getColumIndex(spr,"Value5"), xRow)
     If  getColumIndex(spr,"Value6") > -1 then z7199.Value6 = getDataM(spr, getColumIndex(spr,"Value6"), xRow)
     If  getColumIndex(spr,"Value7") > -1 then z7199.Value7 = getDataM(spr, getColumIndex(spr,"Value7"), xRow)
     If  getColumIndex(spr,"Value8") > -1 then z7199.Value8 = getDataM(spr, getColumIndex(spr,"Value8"), xRow)
     If  getColumIndex(spr,"Value9") > -1 then z7199.Value9 = getDataM(spr, getColumIndex(spr,"Value9"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7199.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7199_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7199_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7199 As T7199_AREA, Job as String, DATEEXCHANGE AS String, SEUNITPRICE AS String, CDUNITPRICE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7199_MOVE = False

Try
    If READ_PFK7199(DATEEXCHANGE, SEUNITPRICE, CDUNITPRICE) = True Then
                z7199 = D7199
		K7199_MOVE = True
		else
	z7199 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7199")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "DATEEXCHANGE":z7199.DateExchange = Children(i).Code
   Case "SEUNITPRICE":z7199.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z7199.cdUnitPrice = Children(i).Code
   Case "VALUE":z7199.Value = Children(i).Code
   Case "VALUE1":z7199.Value1 = Children(i).Code
   Case "VALUE2":z7199.Value2 = Children(i).Code
   Case "VALUE3":z7199.Value3 = Children(i).Code
   Case "VALUE4":z7199.Value4 = Children(i).Code
   Case "VALUE5":z7199.Value5 = Children(i).Code
   Case "VALUE6":z7199.Value6 = Children(i).Code
   Case "VALUE7":z7199.Value7 = Children(i).Code
   Case "VALUE8":z7199.Value8 = Children(i).Code
   Case "VALUE9":z7199.Value9 = Children(i).Code
   Case "REMARK":z7199.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "DATEEXCHANGE":z7199.DateExchange = Children(i).Data
   Case "SEUNITPRICE":z7199.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z7199.cdUnitPrice = Children(i).Data
   Case "VALUE":z7199.Value = Children(i).Data
   Case "VALUE1":z7199.Value1 = Children(i).Data
   Case "VALUE2":z7199.Value2 = Children(i).Data
   Case "VALUE3":z7199.Value3 = Children(i).Data
   Case "VALUE4":z7199.Value4 = Children(i).Data
   Case "VALUE5":z7199.Value5 = Children(i).Data
   Case "VALUE6":z7199.Value6 = Children(i).Data
   Case "VALUE7":z7199.Value7 = Children(i).Data
   Case "VALUE8":z7199.Value8 = Children(i).Data
   Case "VALUE9":z7199.Value9 = Children(i).Data
   Case "REMARK":z7199.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7199_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7199_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7199 As T7199_AREA, Job as String, CheckClear as Boolean, DATEEXCHANGE AS String, SEUNITPRICE AS String, CDUNITPRICE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7199_MOVE = False

Try
    If READ_PFK7199(DATEEXCHANGE, SEUNITPRICE, CDUNITPRICE) = True Then
                z7199 = D7199
		K7199_MOVE = True
		else
	If CheckClear  = True then z7199 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7199")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "DATEEXCHANGE":z7199.DateExchange = Children(i).Code
   Case "SEUNITPRICE":z7199.seUnitPrice = Children(i).Code
   Case "CDUNITPRICE":z7199.cdUnitPrice = Children(i).Code
   Case "VALUE":z7199.Value = Children(i).Code
   Case "VALUE1":z7199.Value1 = Children(i).Code
   Case "VALUE2":z7199.Value2 = Children(i).Code
   Case "VALUE3":z7199.Value3 = Children(i).Code
   Case "VALUE4":z7199.Value4 = Children(i).Code
   Case "VALUE5":z7199.Value5 = Children(i).Code
   Case "VALUE6":z7199.Value6 = Children(i).Code
   Case "VALUE7":z7199.Value7 = Children(i).Code
   Case "VALUE8":z7199.Value8 = Children(i).Code
   Case "VALUE9":z7199.Value9 = Children(i).Code
   Case "REMARK":z7199.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "DATEEXCHANGE":z7199.DateExchange = Children(i).Data
   Case "SEUNITPRICE":z7199.seUnitPrice = Children(i).Data
   Case "CDUNITPRICE":z7199.cdUnitPrice = Children(i).Data
   Case "VALUE":z7199.Value = Children(i).Data
   Case "VALUE1":z7199.Value1 = Children(i).Data
   Case "VALUE2":z7199.Value2 = Children(i).Data
   Case "VALUE3":z7199.Value3 = Children(i).Data
   Case "VALUE4":z7199.Value4 = Children(i).Data
   Case "VALUE5":z7199.Value5 = Children(i).Data
   Case "VALUE6":z7199.Value6 = Children(i).Data
   Case "VALUE7":z7199.Value7 = Children(i).Data
   Case "VALUE8":z7199.Value8 = Children(i).Data
   Case "VALUE9":z7199.Value9 = Children(i).Data
   Case "REMARK":z7199.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7199_MOVE",vbCritical)
End Try
End Function 
    
End Module 
