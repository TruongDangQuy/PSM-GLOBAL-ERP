'=========================================================================================================================================================
'   TABLE : (PFK7420)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7420

Structure T7420_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	GroupBase	 AS String	'			char(3)		*
Public 	ItemCode	 AS String	'			char(6)		*
Public 	ItemCodeData	 AS String	'			nvarchar(100)
Public 	ItemCodeCode	 AS String	'			nvarchar(100)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(6)
Public 	InchargeUpdate	 AS String	'			char(6)
Public 	CheckFix	 AS String	'			char(1)
Public 	CheckUse	 AS String	'			char(1)
'=========================================================================================================================================================
End structure

Public D7420 As T7420_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7420(GROUPBASE AS String, ITEMCODE AS String) As Boolean
    READ_PFK7420 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7420 "
    SQL = SQL & " WHERE K7420_GroupBase		 = '" & GroupBase & "' " 
    SQL = SQL & "   AND K7420_ItemCode		 = '" & ItemCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7420_CLEAR: GoTo SKIP_READ_PFK7420
                
    Call K7420_MOVE(rd)
    READ_PFK7420 = True

SKIP_READ_PFK7420:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7420",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7420(GROUPBASE AS String, ITEMCODE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7420 "
    SQL = SQL & " WHERE K7420_GroupBase		 = '" & GroupBase & "' " 
    SQL = SQL & "   AND K7420_ItemCode		 = '" & ItemCode & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7420",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7420(z7420 As T7420_AREA) As Boolean
    WRITE_PFK7420 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7420)
 
    SQL = " INSERT INTO PFK7420 "
    SQL = SQL & " ( "
    SQL = SQL & " K7420_GroupBase," 
    SQL = SQL & " K7420_ItemCode," 
    SQL = SQL & " K7420_ItemCodeData," 
    SQL = SQL & " K7420_ItemCodeCode," 
    SQL = SQL & " K7420_DateInsert," 
    SQL = SQL & " K7420_DateUpdate," 
    SQL = SQL & " K7420_InchargeInsert," 
    SQL = SQL & " K7420_InchargeUpdate," 
    SQL = SQL & " K7420_CheckFix," 
    SQL = SQL & " K7420_CheckUse " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7420.GroupBase) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7420.ItemCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7420.ItemCodeData) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7420.ItemCodeCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7420.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7420.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7420.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7420.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7420.CheckFix) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7420.CheckUse) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7420 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7420",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7420(z7420 As T7420_AREA) As Boolean
    REWRITE_PFK7420 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7420)
   
    SQL = " UPDATE PFK7420 SET "
    SQL = SQL & "    K7420_ItemCodeData      = N'" & FormatSQL(z7420.ItemCodeData) & "', " 
    SQL = SQL & "    K7420_ItemCodeCode      = N'" & FormatSQL(z7420.ItemCodeCode) & "', " 
    SQL = SQL & "    K7420_DateInsert      = N'" & FormatSQL(z7420.DateInsert) & "', " 
    SQL = SQL & "    K7420_DateUpdate      = N'" & FormatSQL(z7420.DateUpdate) & "', " 
    SQL = SQL & "    K7420_InchargeInsert      = N'" & FormatSQL(z7420.InchargeInsert) & "', " 
    SQL = SQL & "    K7420_InchargeUpdate      = N'" & FormatSQL(z7420.InchargeUpdate) & "', " 
    SQL = SQL & "    K7420_CheckFix      = N'" & FormatSQL(z7420.CheckFix) & "', " 
    SQL = SQL & "    K7420_CheckUse      = N'" & FormatSQL(z7420.CheckUse) & "'  " 
    SQL = SQL & " WHERE K7420_GroupBase		 = '" & z7420.GroupBase & "' " 
    SQL = SQL & "   AND K7420_ItemCode		 = '" & z7420.ItemCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7420 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7420",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7420(z7420 As T7420_AREA) As Boolean
    DELETE_PFK7420 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7420 "
    SQL = SQL & " WHERE K7420_GroupBase		 = '" & z7420.GroupBase & "' " 
    SQL = SQL & "   AND K7420_ItemCode		 = '" & z7420.ItemCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7420 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7420",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7420_CLEAR()
Try
    
   D7420.GroupBase = ""
   D7420.ItemCode = ""
   D7420.ItemCodeData = ""
   D7420.ItemCodeCode = ""
   D7420.DateInsert = ""
   D7420.DateUpdate = ""
   D7420.InchargeInsert = ""
   D7420.InchargeUpdate = ""
   D7420.CheckFix = ""
   D7420.CheckUse = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7420_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7420 As T7420_AREA)
Try
    
    x7420.GroupBase = trim$(  x7420.GroupBase)
    x7420.ItemCode = trim$(  x7420.ItemCode)
    x7420.ItemCodeData = trim$(  x7420.ItemCodeData)
    x7420.ItemCodeCode = trim$(  x7420.ItemCodeCode)
    x7420.DateInsert = trim$(  x7420.DateInsert)
    x7420.DateUpdate = trim$(  x7420.DateUpdate)
    x7420.InchargeInsert = trim$(  x7420.InchargeInsert)
    x7420.InchargeUpdate = trim$(  x7420.InchargeUpdate)
    x7420.CheckFix = trim$(  x7420.CheckFix)
    x7420.CheckUse = trim$(  x7420.CheckUse)
     
    If trim$( x7420.GroupBase ) = "" Then x7420.GroupBase = Space(1) 
    If trim$( x7420.ItemCode ) = "" Then x7420.ItemCode = Space(1) 
    If trim$( x7420.ItemCodeData ) = "" Then x7420.ItemCodeData = Space(1) 
    If trim$( x7420.ItemCodeCode ) = "" Then x7420.ItemCodeCode = Space(1) 
    If trim$( x7420.DateInsert ) = "" Then x7420.DateInsert = Space(1) 
    If trim$( x7420.DateUpdate ) = "" Then x7420.DateUpdate = Space(1) 
    If trim$( x7420.InchargeInsert ) = "" Then x7420.InchargeInsert = Space(1) 
    If trim$( x7420.InchargeUpdate ) = "" Then x7420.InchargeUpdate = Space(1) 
    If trim$( x7420.CheckFix ) = "" Then x7420.CheckFix = Space(1) 
    If trim$( x7420.CheckUse ) = "" Then x7420.CheckUse = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7420_MOVE(rs7420 As SqlClient.SqlDataReader)
Try

    call D7420_CLEAR()   

    If IsdbNull(rs7420!K7420_GroupBase) = False Then D7420.GroupBase = Trim$(rs7420!K7420_GroupBase)
    If IsdbNull(rs7420!K7420_ItemCode) = False Then D7420.ItemCode = Trim$(rs7420!K7420_ItemCode)
    If IsdbNull(rs7420!K7420_ItemCodeData) = False Then D7420.ItemCodeData = Trim$(rs7420!K7420_ItemCodeData)
    If IsdbNull(rs7420!K7420_ItemCodeCode) = False Then D7420.ItemCodeCode = Trim$(rs7420!K7420_ItemCodeCode)
    If IsdbNull(rs7420!K7420_DateInsert) = False Then D7420.DateInsert = Trim$(rs7420!K7420_DateInsert)
    If IsdbNull(rs7420!K7420_DateUpdate) = False Then D7420.DateUpdate = Trim$(rs7420!K7420_DateUpdate)
    If IsdbNull(rs7420!K7420_InchargeInsert) = False Then D7420.InchargeInsert = Trim$(rs7420!K7420_InchargeInsert)
    If IsdbNull(rs7420!K7420_InchargeUpdate) = False Then D7420.InchargeUpdate = Trim$(rs7420!K7420_InchargeUpdate)
    If IsdbNull(rs7420!K7420_CheckFix) = False Then D7420.CheckFix = Trim$(rs7420!K7420_CheckFix)
    If IsdbNull(rs7420!K7420_CheckUse) = False Then D7420.CheckUse = Trim$(rs7420!K7420_CheckUse)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7420_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7420_MOVE(rs7420 As DataRow)
Try

    call D7420_CLEAR()   

    If IsdbNull(rs7420!K7420_GroupBase) = False Then D7420.GroupBase = Trim$(rs7420!K7420_GroupBase)
    If IsdbNull(rs7420!K7420_ItemCode) = False Then D7420.ItemCode = Trim$(rs7420!K7420_ItemCode)
    If IsdbNull(rs7420!K7420_ItemCodeData) = False Then D7420.ItemCodeData = Trim$(rs7420!K7420_ItemCodeData)
    If IsdbNull(rs7420!K7420_ItemCodeCode) = False Then D7420.ItemCodeCode = Trim$(rs7420!K7420_ItemCodeCode)
    If IsdbNull(rs7420!K7420_DateInsert) = False Then D7420.DateInsert = Trim$(rs7420!K7420_DateInsert)
    If IsdbNull(rs7420!K7420_DateUpdate) = False Then D7420.DateUpdate = Trim$(rs7420!K7420_DateUpdate)
    If IsdbNull(rs7420!K7420_InchargeInsert) = False Then D7420.InchargeInsert = Trim$(rs7420!K7420_InchargeInsert)
    If IsdbNull(rs7420!K7420_InchargeUpdate) = False Then D7420.InchargeUpdate = Trim$(rs7420!K7420_InchargeUpdate)
    If IsdbNull(rs7420!K7420_CheckFix) = False Then D7420.CheckFix = Trim$(rs7420!K7420_CheckFix)
    If IsdbNull(rs7420!K7420_CheckUse) = False Then D7420.CheckUse = Trim$(rs7420!K7420_CheckUse)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7420_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7420_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7420 As T7420_AREA, GROUPBASE AS String, ITEMCODE AS String) as Boolean

K7420_MOVE = False

Try
    If READ_PFK7420(GROUPBASE, ITEMCODE) = True Then
                z7420 = D7420
		K7420_MOVE = True
		else
	z7420 = nothing
     End If

     If  getColumIndex(spr,"GroupBase") > -1 then z7420.GroupBase = getDataM(spr, getColumIndex(spr,"GroupBase"), xRow)
     If  getColumIndex(spr,"ItemCode") > -1 then z7420.ItemCode = getDataM(spr, getColumIndex(spr,"ItemCode"), xRow)
     If  getColumIndex(spr,"ItemCodeData") > -1 then z7420.ItemCodeData = getDataM(spr, getColumIndex(spr,"ItemCodeData"), xRow)
     If  getColumIndex(spr,"ItemCodeCode") > -1 then z7420.ItemCodeCode = getDataM(spr, getColumIndex(spr,"ItemCodeCode"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7420.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7420.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7420.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7420.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckFix") > -1 then z7420.CheckFix = getDataM(spr, getColumIndex(spr,"CheckFix"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7420.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7420_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7420_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7420 As T7420_AREA,CheckClear as Boolean,GROUPBASE AS String, ITEMCODE AS String) as Boolean

K7420_MOVE = False

Try
    If READ_PFK7420(GROUPBASE, ITEMCODE) = True Then
                z7420 = D7420
		K7420_MOVE = True
		else
	If CheckClear  = True then z7420 = nothing
     End If

     If  getColumIndex(spr,"GroupBase") > -1 then z7420.GroupBase = getDataM(spr, getColumIndex(spr,"GroupBase"), xRow)
     If  getColumIndex(spr,"ItemCode") > -1 then z7420.ItemCode = getDataM(spr, getColumIndex(spr,"ItemCode"), xRow)
     If  getColumIndex(spr,"ItemCodeData") > -1 then z7420.ItemCodeData = getDataM(spr, getColumIndex(spr,"ItemCodeData"), xRow)
     If  getColumIndex(spr,"ItemCodeCode") > -1 then z7420.ItemCodeCode = getDataM(spr, getColumIndex(spr,"ItemCodeCode"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7420.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7420.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7420.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7420.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckFix") > -1 then z7420.CheckFix = getDataM(spr, getColumIndex(spr,"CheckFix"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7420.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7420_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7420_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7420 As T7420_AREA, Job as String, GROUPBASE AS String, ITEMCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7420_MOVE = False

Try
    If READ_PFK7420(GROUPBASE, ITEMCODE) = True Then
                z7420 = D7420
		K7420_MOVE = True
		else
	z7420 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7420")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "GROUPBASE":z7420.GroupBase = Children(i).Code
   Case "ITEMCODE":z7420.ItemCode = Children(i).Code
   Case "ITEMCODEDATA":z7420.ItemCodeData = Children(i).Code
   Case "ITEMCODECODE":z7420.ItemCodeCode = Children(i).Code
   Case "DATEINSERT":z7420.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7420.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7420.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7420.InchargeUpdate = Children(i).Code
   Case "CHECKFIX":z7420.CheckFix = Children(i).Code
   Case "CHECKUSE":z7420.CheckUse = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "GROUPBASE":z7420.GroupBase = Children(i).Data
   Case "ITEMCODE":z7420.ItemCode = Children(i).Data
   Case "ITEMCODEDATA":z7420.ItemCodeData = Children(i).Data
   Case "ITEMCODECODE":z7420.ItemCodeCode = Children(i).Data
   Case "DATEINSERT":z7420.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7420.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7420.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7420.InchargeUpdate = Children(i).Data
   Case "CHECKFIX":z7420.CheckFix = Children(i).Data
   Case "CHECKUSE":z7420.CheckUse = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7420_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7420_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7420 As T7420_AREA, Job as String, CheckClear as Boolean, GROUPBASE AS String, ITEMCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7420_MOVE = False

Try
    If READ_PFK7420(GROUPBASE, ITEMCODE) = True Then
                z7420 = D7420
		K7420_MOVE = True
		else
	If CheckClear  = True then z7420 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7420")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "GROUPBASE":z7420.GroupBase = Children(i).Code
   Case "ITEMCODE":z7420.ItemCode = Children(i).Code
   Case "ITEMCODEDATA":z7420.ItemCodeData = Children(i).Code
   Case "ITEMCODECODE":z7420.ItemCodeCode = Children(i).Code
   Case "DATEINSERT":z7420.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7420.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7420.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7420.InchargeUpdate = Children(i).Code
   Case "CHECKFIX":z7420.CheckFix = Children(i).Code
   Case "CHECKUSE":z7420.CheckUse = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "GROUPBASE":z7420.GroupBase = Children(i).Data
   Case "ITEMCODE":z7420.ItemCode = Children(i).Data
   Case "ITEMCODEDATA":z7420.ItemCodeData = Children(i).Data
   Case "ITEMCODECODE":z7420.ItemCodeCode = Children(i).Data
   Case "DATEINSERT":z7420.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7420.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7420.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7420.InchargeUpdate = Children(i).Data
   Case "CHECKFIX":z7420.CheckFix = Children(i).Data
   Case "CHECKUSE":z7420.CheckUse = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7420_MOVE",vbCritical)
End Try
End Function 
    
End Module 
