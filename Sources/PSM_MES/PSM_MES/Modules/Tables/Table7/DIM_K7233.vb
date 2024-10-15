'=========================================================================================================================================================
'   TABLE : (PFK7233)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7233

Structure T7233_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	MaterialCode	 AS String	'			char(6)		*
Public 	POSX	 AS Double	'			decimal
Public 	POSY	 AS Double	'			decimal
Public 	FontName	 AS String	'			nvarchar(50)
Public 	FontSize	 AS Double	'			decimal
Public 	FontBold	 AS String	'			char(1)
'=========================================================================================================================================================
End structure

Public D7233 As T7233_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7233(MATERIALCODE AS String) As Boolean
    READ_PFK7233 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7233 "
    SQL = SQL & " WHERE K7233_MaterialCode		 = '" & MaterialCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7233_CLEAR: GoTo SKIP_READ_PFK7233
                
    Call K7233_MOVE(rd)
    READ_PFK7233 = True

SKIP_READ_PFK7233:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7233",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7233(MATERIALCODE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7233 "
    SQL = SQL & " WHERE K7233_MaterialCode		 = '" & MaterialCode & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7233",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7233(z7233 As T7233_AREA) As Boolean
    WRITE_PFK7233 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7233)
 
    SQL = " INSERT INTO PFK7233 "
    SQL = SQL & " ( "
    SQL = SQL & " K7233_MaterialCode," 
    SQL = SQL & " K7233_POSX," 
    SQL = SQL & " K7233_POSY," 
    SQL = SQL & " K7233_FontName," 
    SQL = SQL & " K7233_FontSize," 
    SQL = SQL & " K7233_FontBold " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7233.MaterialCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z7233.POSX) & ", "  
    SQL = SQL & "   " & FormatSQL(z7233.POSY) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7233.FontName) & "', "  
    SQL = SQL & "   " & FormatSQL(z7233.FontSize) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7233.FontBold) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7233 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7233",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7233(z7233 As T7233_AREA) As Boolean
    REWRITE_PFK7233 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7233)
   
    SQL = " UPDATE PFK7233 SET "
    SQL = SQL & "    K7233_POSX      =  " & FormatSQL(z7233.POSX) & ", " 
    SQL = SQL & "    K7233_POSY      =  " & FormatSQL(z7233.POSY) & ", " 
    SQL = SQL & "    K7233_FontName      = N'" & FormatSQL(z7233.FontName) & "', " 
    SQL = SQL & "    K7233_FontSize      =  " & FormatSQL(z7233.FontSize) & ", " 
    SQL = SQL & "    K7233_FontBold      = N'" & FormatSQL(z7233.FontBold) & "'  " 
    SQL = SQL & " WHERE K7233_MaterialCode		 = '" & z7233.MaterialCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7233 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7233",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7233(z7233 As T7233_AREA) As Boolean
    DELETE_PFK7233 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7233 "
    SQL = SQL & " WHERE K7233_MaterialCode		 = '" & z7233.MaterialCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7233 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7233",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7233_CLEAR()
Try
    
   D7233.MaterialCode = ""
    D7233.POSX = 0 
    D7233.POSY = 0 
   D7233.FontName = ""
    D7233.FontSize = 0 
   D7233.FontBold = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7233_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7233 As T7233_AREA)
Try
    
    x7233.MaterialCode = trim$(  x7233.MaterialCode)
    x7233.POSX = trim$(  x7233.POSX)
    x7233.POSY = trim$(  x7233.POSY)
    x7233.FontName = trim$(  x7233.FontName)
    x7233.FontSize = trim$(  x7233.FontSize)
    x7233.FontBold = trim$(  x7233.FontBold)
     
    If trim$( x7233.MaterialCode ) = "" Then x7233.MaterialCode = Space(1) 
    If trim$( x7233.POSX ) = "" Then x7233.POSX = 0 
    If trim$( x7233.POSY ) = "" Then x7233.POSY = 0 
    If trim$( x7233.FontName ) = "" Then x7233.FontName = Space(1) 
    If trim$( x7233.FontSize ) = "" Then x7233.FontSize = 0 
    If trim$( x7233.FontBold ) = "" Then x7233.FontBold = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7233_MOVE(rs7233 As SqlClient.SqlDataReader)
Try

    call D7233_CLEAR()   

    If IsdbNull(rs7233!K7233_MaterialCode) = False Then D7233.MaterialCode = Trim$(rs7233!K7233_MaterialCode)
    If IsdbNull(rs7233!K7233_POSX) = False Then D7233.POSX = Trim$(rs7233!K7233_POSX)
    If IsdbNull(rs7233!K7233_POSY) = False Then D7233.POSY = Trim$(rs7233!K7233_POSY)
    If IsdbNull(rs7233!K7233_FontName) = False Then D7233.FontName = Trim$(rs7233!K7233_FontName)
    If IsdbNull(rs7233!K7233_FontSize) = False Then D7233.FontSize = Trim$(rs7233!K7233_FontSize)
    If IsdbNull(rs7233!K7233_FontBold) = False Then D7233.FontBold = Trim$(rs7233!K7233_FontBold)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7233_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7233_MOVE(rs7233 As DataRow)
Try

    call D7233_CLEAR()   

    If IsdbNull(rs7233!K7233_MaterialCode) = False Then D7233.MaterialCode = Trim$(rs7233!K7233_MaterialCode)
    If IsdbNull(rs7233!K7233_POSX) = False Then D7233.POSX = Trim$(rs7233!K7233_POSX)
    If IsdbNull(rs7233!K7233_POSY) = False Then D7233.POSY = Trim$(rs7233!K7233_POSY)
    If IsdbNull(rs7233!K7233_FontName) = False Then D7233.FontName = Trim$(rs7233!K7233_FontName)
    If IsdbNull(rs7233!K7233_FontSize) = False Then D7233.FontSize = Trim$(rs7233!K7233_FontSize)
    If IsdbNull(rs7233!K7233_FontBold) = False Then D7233.FontBold = Trim$(rs7233!K7233_FontBold)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7233_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7233_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7233 As T7233_AREA, MATERIALCODE AS String) as Boolean

K7233_MOVE = False

Try
    If READ_PFK7233(MATERIALCODE) = True Then
                z7233 = D7233
		K7233_MOVE = True
		else
	z7233 = nothing
     End If

     If  getColumIndex(spr,"MaterialCode") > -1 then z7233.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"POSX") > -1 then z7233.POSX = getDataM(spr, getColumIndex(spr,"POSX"), xRow)
     If  getColumIndex(spr,"POSY") > -1 then z7233.POSY = getDataM(spr, getColumIndex(spr,"POSY"), xRow)
     If  getColumIndex(spr,"FontName") > -1 then z7233.FontName = getDataM(spr, getColumIndex(spr,"FontName"), xRow)
     If  getColumIndex(spr,"FontSize") > -1 then z7233.FontSize = getDataM(spr, getColumIndex(spr,"FontSize"), xRow)
     If  getColumIndex(spr,"FontBold") > -1 then z7233.FontBold = getDataM(spr, getColumIndex(spr,"FontBold"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7233_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7233_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7233 As T7233_AREA,CheckClear as Boolean,MATERIALCODE AS String) as Boolean

K7233_MOVE = False

Try
    If READ_PFK7233(MATERIALCODE) = True Then
                z7233 = D7233
		K7233_MOVE = True
		else
	If CheckClear  = True then z7233 = nothing
     End If

     If  getColumIndex(spr,"MaterialCode") > -1 then z7233.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"POSX") > -1 then z7233.POSX = getDataM(spr, getColumIndex(spr,"POSX"), xRow)
     If  getColumIndex(spr,"POSY") > -1 then z7233.POSY = getDataM(spr, getColumIndex(spr,"POSY"), xRow)
     If  getColumIndex(spr,"FontName") > -1 then z7233.FontName = getDataM(spr, getColumIndex(spr,"FontName"), xRow)
     If  getColumIndex(spr,"FontSize") > -1 then z7233.FontSize = getDataM(spr, getColumIndex(spr,"FontSize"), xRow)
     If  getColumIndex(spr,"FontBold") > -1 then z7233.FontBold = getDataM(spr, getColumIndex(spr,"FontBold"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7233_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7233_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7233 As T7233_AREA, Job as String, MATERIALCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7233_MOVE = False

Try
    If READ_PFK7233(MATERIALCODE) = True Then
                z7233 = D7233
		K7233_MOVE = True
		else
	z7233 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7233")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "MATERIALCODE":z7233.MaterialCode = Children(i).Code
   Case "POSX":z7233.POSX = Children(i).Code
   Case "POSY":z7233.POSY = Children(i).Code
   Case "FONTNAME":z7233.FontName = Children(i).Code
   Case "FONTSIZE":z7233.FontSize = Children(i).Code
   Case "FONTBOLD":z7233.FontBold = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "MATERIALCODE":z7233.MaterialCode = Children(i).Data
   Case "POSX":z7233.POSX = Children(i).Data
   Case "POSY":z7233.POSY = Children(i).Data
   Case "FONTNAME":z7233.FontName = Children(i).Data
   Case "FONTSIZE":z7233.FontSize = Children(i).Data
   Case "FONTBOLD":z7233.FontBold = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7233_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7233_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7233 As T7233_AREA, Job as String, CheckClear as Boolean, MATERIALCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7233_MOVE = False

Try
    If READ_PFK7233(MATERIALCODE) = True Then
                z7233 = D7233
		K7233_MOVE = True
		else
	If CheckClear  = True then z7233 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7233")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "MATERIALCODE":z7233.MaterialCode = Children(i).Code
   Case "POSX":z7233.POSX = Children(i).Code
   Case "POSY":z7233.POSY = Children(i).Code
   Case "FONTNAME":z7233.FontName = Children(i).Code
   Case "FONTSIZE":z7233.FontSize = Children(i).Code
   Case "FONTBOLD":z7233.FontBold = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "MATERIALCODE":z7233.MaterialCode = Children(i).Data
   Case "POSX":z7233.POSX = Children(i).Data
   Case "POSY":z7233.POSY = Children(i).Data
   Case "FONTNAME":z7233.FontName = Children(i).Data
   Case "FONTSIZE":z7233.FontSize = Children(i).Data
   Case "FONTBOLD":z7233.FontBold = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7233_MOVE",vbCritical)
End Try
End Function 
    
End Module 
