'=========================================================================================================================================================
'   TABLE : (PFK7421)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7421

Structure T7421_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	IDNO	 AS String	'			char(8)		*
Public 	ItemCode	 AS String	'			char(6)		*
Public 	ItemCodeData	 AS String	'			nvarchar(100)
Public 	ItemCodeCode	 AS String	'			nvarchar(100)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(6)
Public 	InchargeUpdate	 AS String	'			char(6)
Public 	CheckUse	 AS String	'			char(1)
'=========================================================================================================================================================
End structure

Public D7421 As T7421_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7421(IDNO AS String, ITEMCODE AS String) As Boolean
    READ_PFK7421 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7421 "
    SQL = SQL & " WHERE K7421_IDNO		 = '" & IDNO & "' " 
    SQL = SQL & "   AND K7421_ItemCode		 = '" & ItemCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7421_CLEAR: GoTo SKIP_READ_PFK7421
                
    Call K7421_MOVE(rd)
    READ_PFK7421 = True

SKIP_READ_PFK7421:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7421",vbCritical)
 End Try
    End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7421(IDNO AS String, ITEMCODE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7421 "
    SQL = SQL & " WHERE K7421_IDNO		 = '" & IDNO & "' " 
    SQL = SQL & "   AND K7421_ItemCode		 = '" & ItemCode & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7421",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7421(z7421 As T7421_AREA) As Boolean
    WRITE_PFK7421 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7421)
 
    SQL = " INSERT INTO PFK7421 "
    SQL = SQL & " ( "
    SQL = SQL & " K7421_IDNO," 
    SQL = SQL & " K7421_ItemCode," 
    SQL = SQL & " K7421_ItemCodeData," 
    SQL = SQL & " K7421_ItemCodeCode," 
    SQL = SQL & " K7421_DateInsert," 
    SQL = SQL & " K7421_DateUpdate," 
    SQL = SQL & " K7421_InchargeInsert," 
    SQL = SQL & " K7421_InchargeUpdate," 
    SQL = SQL & " K7421_CheckUse " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7421.IDNO) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7421.ItemCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7421.ItemCodeData) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7421.ItemCodeCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7421.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7421.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7421.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7421.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7421.CheckUse) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7421 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7421",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7421(z7421 As T7421_AREA) As Boolean
    REWRITE_PFK7421 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7421)
   
    SQL = " UPDATE PFK7421 SET "
    SQL = SQL & "    K7421_ItemCodeData      = N'" & FormatSQL(z7421.ItemCodeData) & "', " 
    SQL = SQL & "    K7421_ItemCodeCode      = N'" & FormatSQL(z7421.ItemCodeCode) & "', " 
    SQL = SQL & "    K7421_DateInsert      = N'" & FormatSQL(z7421.DateInsert) & "', " 
    SQL = SQL & "    K7421_DateUpdate      = N'" & FormatSQL(z7421.DateUpdate) & "', " 
    SQL = SQL & "    K7421_InchargeInsert      = N'" & FormatSQL(z7421.InchargeInsert) & "', " 
    SQL = SQL & "    K7421_InchargeUpdate      = N'" & FormatSQL(z7421.InchargeUpdate) & "', " 
    SQL = SQL & "    K7421_CheckUse      = N'" & FormatSQL(z7421.CheckUse) & "'  " 
    SQL = SQL & " WHERE K7421_IDNO		 = '" & z7421.IDNO & "' " 
    SQL = SQL & "   AND K7421_ItemCode		 = '" & z7421.ItemCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7421 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7421",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7421(z7421 As T7421_AREA) As Boolean
    DELETE_PFK7421 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7421 "
    SQL = SQL & " WHERE K7421_IDNO		 = '" & z7421.IDNO & "' " 
    SQL = SQL & "   AND K7421_ItemCode		 = '" & z7421.ItemCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7421 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7421",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7421_CLEAR()
Try
    
   D7421.IDNO = ""
   D7421.ItemCode = ""
   D7421.ItemCodeData = ""
   D7421.ItemCodeCode = ""
   D7421.DateInsert = ""
   D7421.DateUpdate = ""
   D7421.InchargeInsert = ""
   D7421.InchargeUpdate = ""
   D7421.CheckUse = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7421_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7421 As T7421_AREA)
Try
    
    x7421.IDNO = trim$(  x7421.IDNO)
    x7421.ItemCode = trim$(  x7421.ItemCode)
    x7421.ItemCodeData = trim$(  x7421.ItemCodeData)
    x7421.ItemCodeCode = trim$(  x7421.ItemCodeCode)
    x7421.DateInsert = trim$(  x7421.DateInsert)
    x7421.DateUpdate = trim$(  x7421.DateUpdate)
    x7421.InchargeInsert = trim$(  x7421.InchargeInsert)
    x7421.InchargeUpdate = trim$(  x7421.InchargeUpdate)
    x7421.CheckUse = trim$(  x7421.CheckUse)
     
    If trim$( x7421.IDNO ) = "" Then x7421.IDNO = Space(1) 
    If trim$( x7421.ItemCode ) = "" Then x7421.ItemCode = Space(1) 
    If trim$( x7421.ItemCodeData ) = "" Then x7421.ItemCodeData = Space(1) 
    If trim$( x7421.ItemCodeCode ) = "" Then x7421.ItemCodeCode = Space(1) 
    If trim$( x7421.DateInsert ) = "" Then x7421.DateInsert = Space(1) 
    If trim$( x7421.DateUpdate ) = "" Then x7421.DateUpdate = Space(1) 
    If trim$( x7421.InchargeInsert ) = "" Then x7421.InchargeInsert = Space(1) 
    If trim$( x7421.InchargeUpdate ) = "" Then x7421.InchargeUpdate = Space(1) 
    If trim$( x7421.CheckUse ) = "" Then x7421.CheckUse = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7421_MOVE(rs7421 As SqlClient.SqlDataReader)
Try

    call D7421_CLEAR()   

    If IsdbNull(rs7421!K7421_IDNO) = False Then D7421.IDNO = Trim$(rs7421!K7421_IDNO)
    If IsdbNull(rs7421!K7421_ItemCode) = False Then D7421.ItemCode = Trim$(rs7421!K7421_ItemCode)
    If IsdbNull(rs7421!K7421_ItemCodeData) = False Then D7421.ItemCodeData = Trim$(rs7421!K7421_ItemCodeData)
    If IsdbNull(rs7421!K7421_ItemCodeCode) = False Then D7421.ItemCodeCode = Trim$(rs7421!K7421_ItemCodeCode)
    If IsdbNull(rs7421!K7421_DateInsert) = False Then D7421.DateInsert = Trim$(rs7421!K7421_DateInsert)
    If IsdbNull(rs7421!K7421_DateUpdate) = False Then D7421.DateUpdate = Trim$(rs7421!K7421_DateUpdate)
    If IsdbNull(rs7421!K7421_InchargeInsert) = False Then D7421.InchargeInsert = Trim$(rs7421!K7421_InchargeInsert)
    If IsdbNull(rs7421!K7421_InchargeUpdate) = False Then D7421.InchargeUpdate = Trim$(rs7421!K7421_InchargeUpdate)
    If IsdbNull(rs7421!K7421_CheckUse) = False Then D7421.CheckUse = Trim$(rs7421!K7421_CheckUse)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7421_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7421_MOVE(rs7421 As DataRow)
Try

    call D7421_CLEAR()   

    If IsdbNull(rs7421!K7421_IDNO) = False Then D7421.IDNO = Trim$(rs7421!K7421_IDNO)
    If IsdbNull(rs7421!K7421_ItemCode) = False Then D7421.ItemCode = Trim$(rs7421!K7421_ItemCode)
    If IsdbNull(rs7421!K7421_ItemCodeData) = False Then D7421.ItemCodeData = Trim$(rs7421!K7421_ItemCodeData)
    If IsdbNull(rs7421!K7421_ItemCodeCode) = False Then D7421.ItemCodeCode = Trim$(rs7421!K7421_ItemCodeCode)
    If IsdbNull(rs7421!K7421_DateInsert) = False Then D7421.DateInsert = Trim$(rs7421!K7421_DateInsert)
    If IsdbNull(rs7421!K7421_DateUpdate) = False Then D7421.DateUpdate = Trim$(rs7421!K7421_DateUpdate)
    If IsdbNull(rs7421!K7421_InchargeInsert) = False Then D7421.InchargeInsert = Trim$(rs7421!K7421_InchargeInsert)
    If IsdbNull(rs7421!K7421_InchargeUpdate) = False Then D7421.InchargeUpdate = Trim$(rs7421!K7421_InchargeUpdate)
    If IsdbNull(rs7421!K7421_CheckUse) = False Then D7421.CheckUse = Trim$(rs7421!K7421_CheckUse)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7421_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7421_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7421 As T7421_AREA, IDNO AS String, ITEMCODE AS String) as Boolean

K7421_MOVE = False

Try
    If READ_PFK7421(IDNO, ITEMCODE) = True Then
                z7421 = D7421
		K7421_MOVE = True
		else
	z7421 = nothing
     End If

     If  getColumIndex(spr,"IDNO") > -1 then z7421.IDNO = getDataM(spr, getColumIndex(spr,"IDNO"), xRow)
     If  getColumIndex(spr,"ItemCode") > -1 then z7421.ItemCode = getDataM(spr, getColumIndex(spr,"ItemCode"), xRow)
     If  getColumIndex(spr,"ItemCodeData") > -1 then z7421.ItemCodeData = getDataM(spr, getColumIndex(spr,"ItemCodeData"), xRow)
     If  getColumIndex(spr,"ItemCodeCode") > -1 then z7421.ItemCodeCode = getDataM(spr, getColumIndex(spr,"ItemCodeCode"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7421.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7421.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7421.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7421.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7421.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7421_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7421_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7421 As T7421_AREA,CheckClear as Boolean,IDNO AS String, ITEMCODE AS String) as Boolean

K7421_MOVE = False

Try
    If READ_PFK7421(IDNO, ITEMCODE) = True Then
                z7421 = D7421
		K7421_MOVE = True
		else
	If CheckClear  = True then z7421 = nothing
     End If

     If  getColumIndex(spr,"IDNO") > -1 then z7421.IDNO = getDataM(spr, getColumIndex(spr,"IDNO"), xRow)
     If  getColumIndex(spr,"ItemCode") > -1 then z7421.ItemCode = getDataM(spr, getColumIndex(spr,"ItemCode"), xRow)
     If  getColumIndex(spr,"ItemCodeData") > -1 then z7421.ItemCodeData = getDataM(spr, getColumIndex(spr,"ItemCodeData"), xRow)
     If  getColumIndex(spr,"ItemCodeCode") > -1 then z7421.ItemCodeCode = getDataM(spr, getColumIndex(spr,"ItemCodeCode"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7421.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7421.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7421.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7421.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7421.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7421_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7421_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7421 As T7421_AREA, Job as String, IDNO AS String, ITEMCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7421_MOVE = False

Try
    If READ_PFK7421(IDNO, ITEMCODE) = True Then
                z7421 = D7421
		K7421_MOVE = True
		else
	z7421 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7421")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "IDNO":z7421.IDNO = Children(i).Code
   Case "ITEMCODE":z7421.ItemCode = Children(i).Code
   Case "ITEMCODEDATA":z7421.ItemCodeData = Children(i).Code
   Case "ITEMCODECODE":z7421.ItemCodeCode = Children(i).Code
   Case "DATEINSERT":z7421.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7421.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7421.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7421.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7421.CheckUse = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "IDNO":z7421.IDNO = Children(i).Data
   Case "ITEMCODE":z7421.ItemCode = Children(i).Data
   Case "ITEMCODEDATA":z7421.ItemCodeData = Children(i).Data
   Case "ITEMCODECODE":z7421.ItemCodeCode = Children(i).Data
   Case "DATEINSERT":z7421.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7421.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7421.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7421.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7421.CheckUse = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7421_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7421_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7421 As T7421_AREA, Job as String, CheckClear as Boolean, IDNO AS String, ITEMCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7421_MOVE = False

Try
    If READ_PFK7421(IDNO, ITEMCODE) = True Then
                z7421 = D7421
		K7421_MOVE = True
		else
	If CheckClear  = True then z7421 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7421")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "IDNO":z7421.IDNO = Children(i).Code
   Case "ITEMCODE":z7421.ItemCode = Children(i).Code
   Case "ITEMCODEDATA":z7421.ItemCodeData = Children(i).Code
   Case "ITEMCODECODE":z7421.ItemCodeCode = Children(i).Code
   Case "DATEINSERT":z7421.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7421.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7421.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7421.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7421.CheckUse = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "IDNO":z7421.IDNO = Children(i).Data
   Case "ITEMCODE":z7421.ItemCode = Children(i).Data
   Case "ITEMCODEDATA":z7421.ItemCodeData = Children(i).Data
   Case "ITEMCODECODE":z7421.ItemCodeCode = Children(i).Data
   Case "DATEINSERT":z7421.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7421.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7421.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7421.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7421.CheckUse = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7421_MOVE",vbCritical)
End Try
End Function 
    
End Module 
