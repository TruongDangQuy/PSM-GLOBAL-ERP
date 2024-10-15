'=========================================================================================================================================================
'   TABLE : (PFK7118)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7118

Structure T7118_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	BarcodeInnerBox	 AS String	'			nvarchar(50)		*
Public 	ShoesCode	 AS String	'			char(6)
Public 	SizeRange	 AS String	'			char(6)
Public 	SizeNo	 AS String	'			char(2)
Public 	SizeName	 AS String	'			nvarchar(4)
Public 	DateInsert	 AS Double	'			decimal
'=========================================================================================================================================================
End structure

Public D7118 As T7118_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7118(BARCODEINNERBOX AS String) As Boolean
    READ_PFK7118 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7118 "
    SQL = SQL & " WHERE K7118_BarcodeInnerBox		 = '" & BarcodeInnerBox & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7118_CLEAR: GoTo SKIP_READ_PFK7118
                
    Call K7118_MOVE(rd)
    READ_PFK7118 = True

SKIP_READ_PFK7118:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7118",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7118(BARCODEINNERBOX AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7118 "
    SQL = SQL & " WHERE K7118_BarcodeInnerBox		 = '" & BarcodeInnerBox & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7118",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7118(z7118 As T7118_AREA) As Boolean
    WRITE_PFK7118 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7118)
 
    SQL = " INSERT INTO PFK7118 "
    SQL = SQL & " ( "
    SQL = SQL & " K7118_BarcodeInnerBox," 
    SQL = SQL & " K7118_ShoesCode," 
    SQL = SQL & " K7118_SizeRange," 
    SQL = SQL & " K7118_SizeNo," 
    SQL = SQL & " K7118_SizeName," 
    SQL = SQL & " K7118_DateInsert " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7118.BarcodeInnerBox) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7118.ShoesCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7118.SizeRange) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7118.SizeNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7118.SizeName) & "', "  
    SQL = SQL & "   " & FormatSQL(z7118.DateInsert) & "  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7118 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7118",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7118(z7118 As T7118_AREA) As Boolean
    REWRITE_PFK7118 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7118)
   
    SQL = " UPDATE PFK7118 SET "
    SQL = SQL & "    K7118_ShoesCode      = N'" & FormatSQL(z7118.ShoesCode) & "', " 
    SQL = SQL & "    K7118_SizeRange      = N'" & FormatSQL(z7118.SizeRange) & "', " 
    SQL = SQL & "    K7118_SizeNo      = N'" & FormatSQL(z7118.SizeNo) & "', " 
    SQL = SQL & "    K7118_SizeName      = N'" & FormatSQL(z7118.SizeName) & "', " 
    SQL = SQL & "    K7118_DateInsert      =  " & FormatSQL(z7118.DateInsert) & "  " 
    SQL = SQL & " WHERE K7118_BarcodeInnerBox		 = '" & z7118.BarcodeInnerBox & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7118 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7118",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7118(z7118 As T7118_AREA) As Boolean
    DELETE_PFK7118 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7118 "
    SQL = SQL & " WHERE K7118_BarcodeInnerBox		 = '" & z7118.BarcodeInnerBox & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7118 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7118",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7118_CLEAR()
Try
    
   D7118.BarcodeInnerBox = ""
   D7118.ShoesCode = ""
   D7118.SizeRange = ""
   D7118.SizeNo = ""
   D7118.SizeName = ""
    D7118.DateInsert = 0 

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7118_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7118 As T7118_AREA)
Try
    
    x7118.BarcodeInnerBox = trim$(  x7118.BarcodeInnerBox)
    x7118.ShoesCode = trim$(  x7118.ShoesCode)
    x7118.SizeRange = trim$(  x7118.SizeRange)
    x7118.SizeNo = trim$(  x7118.SizeNo)
    x7118.SizeName = trim$(  x7118.SizeName)
    x7118.DateInsert = trim$(  x7118.DateInsert)
     
    If trim$( x7118.BarcodeInnerBox ) = "" Then x7118.BarcodeInnerBox = Space(1) 
    If trim$( x7118.ShoesCode ) = "" Then x7118.ShoesCode = Space(1) 
    If trim$( x7118.SizeRange ) = "" Then x7118.SizeRange = Space(1) 
    If trim$( x7118.SizeNo ) = "" Then x7118.SizeNo = Space(1) 
    If trim$( x7118.SizeName ) = "" Then x7118.SizeName = Space(1) 
    If trim$( x7118.DateInsert ) = "" Then x7118.DateInsert = 0 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7118_MOVE(rs7118 As SqlClient.SqlDataReader)
Try

    call D7118_CLEAR()   

    If IsdbNull(rs7118!K7118_BarcodeInnerBox) = False Then D7118.BarcodeInnerBox = Trim$(rs7118!K7118_BarcodeInnerBox)
    If IsdbNull(rs7118!K7118_ShoesCode) = False Then D7118.ShoesCode = Trim$(rs7118!K7118_ShoesCode)
    If IsdbNull(rs7118!K7118_SizeRange) = False Then D7118.SizeRange = Trim$(rs7118!K7118_SizeRange)
    If IsdbNull(rs7118!K7118_SizeNo) = False Then D7118.SizeNo = Trim$(rs7118!K7118_SizeNo)
    If IsdbNull(rs7118!K7118_SizeName) = False Then D7118.SizeName = Trim$(rs7118!K7118_SizeName)
    If IsdbNull(rs7118!K7118_DateInsert) = False Then D7118.DateInsert = Trim$(rs7118!K7118_DateInsert)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7118_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7118_MOVE(rs7118 As DataRow)
Try

    call D7118_CLEAR()   

    If IsdbNull(rs7118!K7118_BarcodeInnerBox) = False Then D7118.BarcodeInnerBox = Trim$(rs7118!K7118_BarcodeInnerBox)
    If IsdbNull(rs7118!K7118_ShoesCode) = False Then D7118.ShoesCode = Trim$(rs7118!K7118_ShoesCode)
    If IsdbNull(rs7118!K7118_SizeRange) = False Then D7118.SizeRange = Trim$(rs7118!K7118_SizeRange)
    If IsdbNull(rs7118!K7118_SizeNo) = False Then D7118.SizeNo = Trim$(rs7118!K7118_SizeNo)
    If IsdbNull(rs7118!K7118_SizeName) = False Then D7118.SizeName = Trim$(rs7118!K7118_SizeName)
    If IsdbNull(rs7118!K7118_DateInsert) = False Then D7118.DateInsert = Trim$(rs7118!K7118_DateInsert)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7118_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7118_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7118 As T7118_AREA, BARCODEINNERBOX AS String) as Boolean

K7118_MOVE = False

Try
    If READ_PFK7118(BARCODEINNERBOX) = True Then
                z7118 = D7118
		K7118_MOVE = True
		else
	z7118 = nothing
     End If

     If  getColumIndex(spr,"BarcodeInnerBox") > -1 then z7118.BarcodeInnerBox = getDataM(spr, getColumIndex(spr,"BarcodeInnerBox"), xRow)
     If  getColumIndex(spr,"ShoesCode") > -1 then z7118.ShoesCode = getDataM(spr, getColumIndex(spr,"ShoesCode"), xRow)
     If  getColumIndex(spr,"SizeRange") > -1 then z7118.SizeRange = getDataM(spr, getColumIndex(spr,"SizeRange"), xRow)
     If  getColumIndex(spr,"SizeNo") > -1 then z7118.SizeNo = getDataM(spr, getColumIndex(spr,"SizeNo"), xRow)
     If  getColumIndex(spr,"SizeName") > -1 then z7118.SizeName = getDataM(spr, getColumIndex(spr,"SizeName"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7118.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7118_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7118_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7118 As T7118_AREA,CheckClear as Boolean,BARCODEINNERBOX AS String) as Boolean

K7118_MOVE = False

Try
    If READ_PFK7118(BARCODEINNERBOX) = True Then
                z7118 = D7118
		K7118_MOVE = True
		else
	If CheckClear  = True then z7118 = nothing
     End If

     If  getColumIndex(spr,"BarcodeInnerBox") > -1 then z7118.BarcodeInnerBox = getDataM(spr, getColumIndex(spr,"BarcodeInnerBox"), xRow)
     If  getColumIndex(spr,"ShoesCode") > -1 then z7118.ShoesCode = getDataM(spr, getColumIndex(spr,"ShoesCode"), xRow)
     If  getColumIndex(spr,"SizeRange") > -1 then z7118.SizeRange = getDataM(spr, getColumIndex(spr,"SizeRange"), xRow)
     If  getColumIndex(spr,"SizeNo") > -1 then z7118.SizeNo = getDataM(spr, getColumIndex(spr,"SizeNo"), xRow)
     If  getColumIndex(spr,"SizeName") > -1 then z7118.SizeName = getDataM(spr, getColumIndex(spr,"SizeName"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7118.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7118_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7118_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7118 As T7118_AREA, Job as String, BARCODEINNERBOX AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7118_MOVE = False

Try
    If READ_PFK7118(BARCODEINNERBOX) = True Then
                z7118 = D7118
		K7118_MOVE = True
		else
	z7118 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7118")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "BARCODEINNERBOX":z7118.BarcodeInnerBox = Children(i).Code
   Case "SHOESCODE":z7118.ShoesCode = Children(i).Code
   Case "SIZERANGE":z7118.SizeRange = Children(i).Code
   Case "SIZENO":z7118.SizeNo = Children(i).Code
   Case "SIZENAME":z7118.SizeName = Children(i).Code
   Case "DATEINSERT":z7118.DateInsert = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "BARCODEINNERBOX":z7118.BarcodeInnerBox = Children(i).Data
   Case "SHOESCODE":z7118.ShoesCode = Children(i).Data
   Case "SIZERANGE":z7118.SizeRange = Children(i).Data
   Case "SIZENO":z7118.SizeNo = Children(i).Data
   Case "SIZENAME":z7118.SizeName = Children(i).Data
   Case "DATEINSERT":z7118.DateInsert = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7118_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7118_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7118 As T7118_AREA, Job as String, CheckClear as Boolean, BARCODEINNERBOX AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7118_MOVE = False

Try
    If READ_PFK7118(BARCODEINNERBOX) = True Then
                z7118 = D7118
		K7118_MOVE = True
		else
	If CheckClear  = True then z7118 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7118")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "BARCODEINNERBOX":z7118.BarcodeInnerBox = Children(i).Code
   Case "SHOESCODE":z7118.ShoesCode = Children(i).Code
   Case "SIZERANGE":z7118.SizeRange = Children(i).Code
   Case "SIZENO":z7118.SizeNo = Children(i).Code
   Case "SIZENAME":z7118.SizeName = Children(i).Code
   Case "DATEINSERT":z7118.DateInsert = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "BARCODEINNERBOX":z7118.BarcodeInnerBox = Children(i).Data
   Case "SHOESCODE":z7118.ShoesCode = Children(i).Data
   Case "SIZERANGE":z7118.SizeRange = Children(i).Data
   Case "SIZENO":z7118.SizeNo = Children(i).Data
   Case "SIZENAME":z7118.SizeName = Children(i).Data
   Case "DATEINSERT":z7118.DateInsert = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7118_MOVE",vbCritical)
End Try
End Function 
    
End Module 
