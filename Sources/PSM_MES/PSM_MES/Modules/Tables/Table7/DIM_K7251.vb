'=========================================================================================================================================================
'   TABLE : (PFK7251)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7251

Structure T7251_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	YearMaterial	 AS String	'			char(4)		*
Public 	MonthMaterial	 AS String	'			char(2)		*
Public 	MaterialCode	 AS String	'			char(6)		*
Public 	PriceMaterialUsd	 AS Double	'			decimal
Public 	PriceMaterialVND	 AS Double	'			decimal
'=========================================================================================================================================================
End structure

Public D7251 As T7251_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7251(YEARMATERIAL AS String, MONTHMATERIAL AS String, MATERIALCODE AS String) As Boolean
    READ_PFK7251 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7251 "
    SQL = SQL & " WHERE K7251_YearMaterial		 = '" & YearMaterial & "' " 
    SQL = SQL & "   AND K7251_MonthMaterial		 = '" & MonthMaterial & "' " 
    SQL = SQL & "   AND K7251_MaterialCode		 = '" & MaterialCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7251_CLEAR: GoTo SKIP_READ_PFK7251
                
    Call K7251_MOVE(rd)
    READ_PFK7251 = True

SKIP_READ_PFK7251:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7251",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7251(YEARMATERIAL AS String, MONTHMATERIAL AS String, MATERIALCODE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7251 "
    SQL = SQL & " WHERE K7251_YearMaterial		 = '" & YearMaterial & "' " 
    SQL = SQL & "   AND K7251_MonthMaterial		 = '" & MonthMaterial & "' " 
    SQL = SQL & "   AND K7251_MaterialCode		 = '" & MaterialCode & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7251",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7251(z7251 As T7251_AREA) As Boolean
    WRITE_PFK7251 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7251)
 
    SQL = " INSERT INTO PFK7251 "
    SQL = SQL & " ( "
    SQL = SQL & " K7251_YearMaterial," 
    SQL = SQL & " K7251_MonthMaterial," 
    SQL = SQL & " K7251_MaterialCode," 
    SQL = SQL & " K7251_PriceMaterialUsd," 
    SQL = SQL & " K7251_PriceMaterialVND " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7251.YearMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7251.MonthMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7251.MaterialCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z7251.PriceMaterialUsd) & ", "  
    SQL = SQL & "   " & FormatSQL(z7251.PriceMaterialVND) & "  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7251 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7251",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7251(z7251 As T7251_AREA) As Boolean
    REWRITE_PFK7251 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7251)
   
    SQL = " UPDATE PFK7251 SET "
    SQL = SQL & "    K7251_PriceMaterialUsd      =  " & FormatSQL(z7251.PriceMaterialUsd) & ", " 
    SQL = SQL & "    K7251_PriceMaterialVND      =  " & FormatSQL(z7251.PriceMaterialVND) & "  " 
    SQL = SQL & " WHERE K7251_YearMaterial		 = '" & z7251.YearMaterial & "' " 
    SQL = SQL & "   AND K7251_MonthMaterial		 = '" & z7251.MonthMaterial & "' " 
    SQL = SQL & "   AND K7251_MaterialCode		 = '" & z7251.MaterialCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7251 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7251",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7251(z7251 As T7251_AREA) As Boolean
    DELETE_PFK7251 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7251 "
    SQL = SQL & " WHERE K7251_YearMaterial		 = '" & z7251.YearMaterial & "' " 
    SQL = SQL & "   AND K7251_MonthMaterial		 = '" & z7251.MonthMaterial & "' " 
    SQL = SQL & "   AND K7251_MaterialCode		 = '" & z7251.MaterialCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7251 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7251",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7251_CLEAR()
Try
    
   D7251.YearMaterial = ""
   D7251.MonthMaterial = ""
   D7251.MaterialCode = ""
    D7251.PriceMaterialUsd = 0 
    D7251.PriceMaterialVND = 0 

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7251_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7251 As T7251_AREA)
Try
    
    x7251.YearMaterial = trim$(  x7251.YearMaterial)
    x7251.MonthMaterial = trim$(  x7251.MonthMaterial)
    x7251.MaterialCode = trim$(  x7251.MaterialCode)
    x7251.PriceMaterialUsd = trim$(  x7251.PriceMaterialUsd)
    x7251.PriceMaterialVND = trim$(  x7251.PriceMaterialVND)
     
    If trim$( x7251.YearMaterial ) = "" Then x7251.YearMaterial = Space(1) 
    If trim$( x7251.MonthMaterial ) = "" Then x7251.MonthMaterial = Space(1) 
    If trim$( x7251.MaterialCode ) = "" Then x7251.MaterialCode = Space(1) 
    If trim$( x7251.PriceMaterialUsd ) = "" Then x7251.PriceMaterialUsd = 0 
    If trim$( x7251.PriceMaterialVND ) = "" Then x7251.PriceMaterialVND = 0 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7251_MOVE(rs7251 As SqlClient.SqlDataReader)
Try

    call D7251_CLEAR()   

    If IsdbNull(rs7251!K7251_YearMaterial) = False Then D7251.YearMaterial = Trim$(rs7251!K7251_YearMaterial)
    If IsdbNull(rs7251!K7251_MonthMaterial) = False Then D7251.MonthMaterial = Trim$(rs7251!K7251_MonthMaterial)
    If IsdbNull(rs7251!K7251_MaterialCode) = False Then D7251.MaterialCode = Trim$(rs7251!K7251_MaterialCode)
    If IsdbNull(rs7251!K7251_PriceMaterialUsd) = False Then D7251.PriceMaterialUsd = Trim$(rs7251!K7251_PriceMaterialUsd)
    If IsdbNull(rs7251!K7251_PriceMaterialVND) = False Then D7251.PriceMaterialVND = Trim$(rs7251!K7251_PriceMaterialVND)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7251_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7251_MOVE(rs7251 As DataRow)
Try

    call D7251_CLEAR()   

    If IsdbNull(rs7251!K7251_YearMaterial) = False Then D7251.YearMaterial = Trim$(rs7251!K7251_YearMaterial)
    If IsdbNull(rs7251!K7251_MonthMaterial) = False Then D7251.MonthMaterial = Trim$(rs7251!K7251_MonthMaterial)
    If IsdbNull(rs7251!K7251_MaterialCode) = False Then D7251.MaterialCode = Trim$(rs7251!K7251_MaterialCode)
    If IsdbNull(rs7251!K7251_PriceMaterialUsd) = False Then D7251.PriceMaterialUsd = Trim$(rs7251!K7251_PriceMaterialUsd)
    If IsdbNull(rs7251!K7251_PriceMaterialVND) = False Then D7251.PriceMaterialVND = Trim$(rs7251!K7251_PriceMaterialVND)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7251_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7251_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7251 As T7251_AREA, YEARMATERIAL AS String, MONTHMATERIAL AS String, MATERIALCODE AS String) as Boolean

K7251_MOVE = False

Try
    If READ_PFK7251(YEARMATERIAL, MONTHMATERIAL, MATERIALCODE) = True Then
                z7251 = D7251
		K7251_MOVE = True
		else
	z7251 = nothing
     End If

     If  getColumIndex(spr,"YearMaterial") > -1 then z7251.YearMaterial = getDataM(spr, getColumIndex(spr,"YearMaterial"), xRow)
     If  getColumIndex(spr,"MonthMaterial") > -1 then z7251.MonthMaterial = getDataM(spr, getColumIndex(spr,"MonthMaterial"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z7251.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"PriceMaterialUsd") > -1 then z7251.PriceMaterialUsd = getDataM(spr, getColumIndex(spr,"PriceMaterialUsd"), xRow)
     If  getColumIndex(spr,"PriceMaterialVND") > -1 then z7251.PriceMaterialVND = getDataM(spr, getColumIndex(spr,"PriceMaterialVND"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7251_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7251_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7251 As T7251_AREA,CheckClear as Boolean,YEARMATERIAL AS String, MONTHMATERIAL AS String, MATERIALCODE AS String) as Boolean

K7251_MOVE = False

Try
    If READ_PFK7251(YEARMATERIAL, MONTHMATERIAL, MATERIALCODE) = True Then
                z7251 = D7251
		K7251_MOVE = True
		else
	If CheckClear  = True then z7251 = nothing
     End If

     If  getColumIndex(spr,"YearMaterial") > -1 then z7251.YearMaterial = getDataM(spr, getColumIndex(spr,"YearMaterial"), xRow)
     If  getColumIndex(spr,"MonthMaterial") > -1 then z7251.MonthMaterial = getDataM(spr, getColumIndex(spr,"MonthMaterial"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z7251.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"PriceMaterialUsd") > -1 then z7251.PriceMaterialUsd = getDataM(spr, getColumIndex(spr,"PriceMaterialUsd"), xRow)
     If  getColumIndex(spr,"PriceMaterialVND") > -1 then z7251.PriceMaterialVND = getDataM(spr, getColumIndex(spr,"PriceMaterialVND"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7251_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7251_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7251 As T7251_AREA, Job as String, YEARMATERIAL AS String, MONTHMATERIAL AS String, MATERIALCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7251_MOVE = False

Try
    If READ_PFK7251(YEARMATERIAL, MONTHMATERIAL, MATERIALCODE) = True Then
                z7251 = D7251
		K7251_MOVE = True
		else
	z7251 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7251")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "YEARMATERIAL":z7251.YearMaterial = Children(i).Code
   Case "MONTHMATERIAL":z7251.MonthMaterial = Children(i).Code
   Case "MATERIALCODE":z7251.MaterialCode = Children(i).Code
   Case "PRICEMATERIALUSD":z7251.PriceMaterialUsd = Children(i).Code
   Case "PRICEMATERIALVND":z7251.PriceMaterialVND = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "YEARMATERIAL":z7251.YearMaterial = Children(i).Data
   Case "MONTHMATERIAL":z7251.MonthMaterial = Children(i).Data
   Case "MATERIALCODE":z7251.MaterialCode = Children(i).Data
   Case "PRICEMATERIALUSD":z7251.PriceMaterialUsd = Children(i).Data
   Case "PRICEMATERIALVND":z7251.PriceMaterialVND = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7251_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7251_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7251 As T7251_AREA, Job as String, CheckClear as Boolean, YEARMATERIAL AS String, MONTHMATERIAL AS String, MATERIALCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7251_MOVE = False

Try
    If READ_PFK7251(YEARMATERIAL, MONTHMATERIAL, MATERIALCODE) = True Then
                z7251 = D7251
		K7251_MOVE = True
		else
	If CheckClear  = True then z7251 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7251")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "YEARMATERIAL":z7251.YearMaterial = Children(i).Code
   Case "MONTHMATERIAL":z7251.MonthMaterial = Children(i).Code
   Case "MATERIALCODE":z7251.MaterialCode = Children(i).Code
   Case "PRICEMATERIALUSD":z7251.PriceMaterialUsd = Children(i).Code
   Case "PRICEMATERIALVND":z7251.PriceMaterialVND = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "YEARMATERIAL":z7251.YearMaterial = Children(i).Data
   Case "MONTHMATERIAL":z7251.MonthMaterial = Children(i).Data
   Case "MATERIALCODE":z7251.MaterialCode = Children(i).Data
   Case "PRICEMATERIALUSD":z7251.PriceMaterialUsd = Children(i).Data
   Case "PRICEMATERIALVND":z7251.PriceMaterialVND = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7251_MOVE",vbCritical)
End Try
End Function 
    
End Module 
