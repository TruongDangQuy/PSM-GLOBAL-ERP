'=========================================================================================================================================================
'   TABLE : (PFK7423)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7423

Structure T7423_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	IDNO	 AS String	'			char(8)		*
Public 	ProgramNo	 AS String	'			nvarchar(100)		*
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

Public D7423 As T7423_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7423(IDNO AS String, PROGRAMNO AS String, ITEMCODE AS String) As Boolean
    READ_PFK7423 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7423 "
    SQL = SQL & " WHERE K7423_IDNO		 = '" & IDNO & "' " 
    SQL = SQL & "   AND K7423_ProgramNo		 = '" & ProgramNo & "' " 
    SQL = SQL & "   AND K7423_ItemCode		 = '" & ItemCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7423_CLEAR: GoTo SKIP_READ_PFK7423
                
    Call K7423_MOVE(rd)
    READ_PFK7423 = True

SKIP_READ_PFK7423:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7423",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7423(IDNO AS String, PROGRAMNO AS String, ITEMCODE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7423 "
    SQL = SQL & " WHERE K7423_IDNO		 = '" & IDNO & "' " 
    SQL = SQL & "   AND K7423_ProgramNo		 = '" & ProgramNo & "' " 
    SQL = SQL & "   AND K7423_ItemCode		 = '" & ItemCode & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7423",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7423(z7423 As T7423_AREA) As Boolean
    WRITE_PFK7423 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7423)
 
    SQL = " INSERT INTO PFK7423 "
    SQL = SQL & " ( "
    SQL = SQL & " K7423_IDNO," 
    SQL = SQL & " K7423_ProgramNo," 
    SQL = SQL & " K7423_ItemCode," 
    SQL = SQL & " K7423_ItemCodeData," 
    SQL = SQL & " K7423_ItemCodeCode," 
    SQL = SQL & " K7423_DateInsert," 
    SQL = SQL & " K7423_DateUpdate," 
    SQL = SQL & " K7423_InchargeInsert," 
    SQL = SQL & " K7423_InchargeUpdate," 
    SQL = SQL & " K7423_CheckUse " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7423.IDNO) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7423.ProgramNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7423.ItemCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7423.ItemCodeData) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7423.ItemCodeCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7423.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7423.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7423.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7423.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7423.CheckUse) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7423 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7423",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7423(z7423 As T7423_AREA) As Boolean
    REWRITE_PFK7423 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7423)
   
    SQL = " UPDATE PFK7423 SET "
    SQL = SQL & "    K7423_ItemCodeData      = N'" & FormatSQL(z7423.ItemCodeData) & "', " 
    SQL = SQL & "    K7423_ItemCodeCode      = N'" & FormatSQL(z7423.ItemCodeCode) & "', " 
    SQL = SQL & "    K7423_DateInsert      = N'" & FormatSQL(z7423.DateInsert) & "', " 
    SQL = SQL & "    K7423_DateUpdate      = N'" & FormatSQL(z7423.DateUpdate) & "', " 
    SQL = SQL & "    K7423_InchargeInsert      = N'" & FormatSQL(z7423.InchargeInsert) & "', " 
    SQL = SQL & "    K7423_InchargeUpdate      = N'" & FormatSQL(z7423.InchargeUpdate) & "', " 
    SQL = SQL & "    K7423_CheckUse      = N'" & FormatSQL(z7423.CheckUse) & "'  " 
    SQL = SQL & " WHERE K7423_IDNO		 = '" & z7423.IDNO & "' " 
    SQL = SQL & "   AND K7423_ProgramNo		 = '" & z7423.ProgramNo & "' " 
    SQL = SQL & "   AND K7423_ItemCode		 = '" & z7423.ItemCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7423 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7423",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7423(z7423 As T7423_AREA) As Boolean
    DELETE_PFK7423 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7423 "
    SQL = SQL & " WHERE K7423_IDNO		 = '" & z7423.IDNO & "' " 
    SQL = SQL & "   AND K7423_ProgramNo		 = '" & z7423.ProgramNo & "' " 
    SQL = SQL & "   AND K7423_ItemCode		 = '" & z7423.ItemCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7423 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7423",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7423_CLEAR()
Try
    
   D7423.IDNO = ""
   D7423.ProgramNo = ""
   D7423.ItemCode = ""
   D7423.ItemCodeData = ""
   D7423.ItemCodeCode = ""
   D7423.DateInsert = ""
   D7423.DateUpdate = ""
   D7423.InchargeInsert = ""
   D7423.InchargeUpdate = ""
   D7423.CheckUse = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7423_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7423 As T7423_AREA)
Try
    
    x7423.IDNO = trim$(  x7423.IDNO)
    x7423.ProgramNo = trim$(  x7423.ProgramNo)
    x7423.ItemCode = trim$(  x7423.ItemCode)
    x7423.ItemCodeData = trim$(  x7423.ItemCodeData)
    x7423.ItemCodeCode = trim$(  x7423.ItemCodeCode)
    x7423.DateInsert = trim$(  x7423.DateInsert)
    x7423.DateUpdate = trim$(  x7423.DateUpdate)
    x7423.InchargeInsert = trim$(  x7423.InchargeInsert)
    x7423.InchargeUpdate = trim$(  x7423.InchargeUpdate)
    x7423.CheckUse = trim$(  x7423.CheckUse)
     
    If trim$( x7423.IDNO ) = "" Then x7423.IDNO = Space(1) 
    If trim$( x7423.ProgramNo ) = "" Then x7423.ProgramNo = Space(1) 
    If trim$( x7423.ItemCode ) = "" Then x7423.ItemCode = Space(1) 
    If trim$( x7423.ItemCodeData ) = "" Then x7423.ItemCodeData = Space(1) 
    If trim$( x7423.ItemCodeCode ) = "" Then x7423.ItemCodeCode = Space(1) 
    If trim$( x7423.DateInsert ) = "" Then x7423.DateInsert = Space(1) 
    If trim$( x7423.DateUpdate ) = "" Then x7423.DateUpdate = Space(1) 
    If trim$( x7423.InchargeInsert ) = "" Then x7423.InchargeInsert = Space(1) 
    If trim$( x7423.InchargeUpdate ) = "" Then x7423.InchargeUpdate = Space(1) 
    If trim$( x7423.CheckUse ) = "" Then x7423.CheckUse = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7423_MOVE(rs7423 As SqlClient.SqlDataReader)
Try

    call D7423_CLEAR()   

    If IsdbNull(rs7423!K7423_IDNO) = False Then D7423.IDNO = Trim$(rs7423!K7423_IDNO)
    If IsdbNull(rs7423!K7423_ProgramNo) = False Then D7423.ProgramNo = Trim$(rs7423!K7423_ProgramNo)
    If IsdbNull(rs7423!K7423_ItemCode) = False Then D7423.ItemCode = Trim$(rs7423!K7423_ItemCode)
    If IsdbNull(rs7423!K7423_ItemCodeData) = False Then D7423.ItemCodeData = Trim$(rs7423!K7423_ItemCodeData)
    If IsdbNull(rs7423!K7423_ItemCodeCode) = False Then D7423.ItemCodeCode = Trim$(rs7423!K7423_ItemCodeCode)
    If IsdbNull(rs7423!K7423_DateInsert) = False Then D7423.DateInsert = Trim$(rs7423!K7423_DateInsert)
    If IsdbNull(rs7423!K7423_DateUpdate) = False Then D7423.DateUpdate = Trim$(rs7423!K7423_DateUpdate)
    If IsdbNull(rs7423!K7423_InchargeInsert) = False Then D7423.InchargeInsert = Trim$(rs7423!K7423_InchargeInsert)
    If IsdbNull(rs7423!K7423_InchargeUpdate) = False Then D7423.InchargeUpdate = Trim$(rs7423!K7423_InchargeUpdate)
    If IsdbNull(rs7423!K7423_CheckUse) = False Then D7423.CheckUse = Trim$(rs7423!K7423_CheckUse)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7423_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7423_MOVE(rs7423 As DataRow)
Try

    call D7423_CLEAR()   

    If IsdbNull(rs7423!K7423_IDNO) = False Then D7423.IDNO = Trim$(rs7423!K7423_IDNO)
    If IsdbNull(rs7423!K7423_ProgramNo) = False Then D7423.ProgramNo = Trim$(rs7423!K7423_ProgramNo)
    If IsdbNull(rs7423!K7423_ItemCode) = False Then D7423.ItemCode = Trim$(rs7423!K7423_ItemCode)
    If IsdbNull(rs7423!K7423_ItemCodeData) = False Then D7423.ItemCodeData = Trim$(rs7423!K7423_ItemCodeData)
    If IsdbNull(rs7423!K7423_ItemCodeCode) = False Then D7423.ItemCodeCode = Trim$(rs7423!K7423_ItemCodeCode)
    If IsdbNull(rs7423!K7423_DateInsert) = False Then D7423.DateInsert = Trim$(rs7423!K7423_DateInsert)
    If IsdbNull(rs7423!K7423_DateUpdate) = False Then D7423.DateUpdate = Trim$(rs7423!K7423_DateUpdate)
    If IsdbNull(rs7423!K7423_InchargeInsert) = False Then D7423.InchargeInsert = Trim$(rs7423!K7423_InchargeInsert)
    If IsdbNull(rs7423!K7423_InchargeUpdate) = False Then D7423.InchargeUpdate = Trim$(rs7423!K7423_InchargeUpdate)
    If IsdbNull(rs7423!K7423_CheckUse) = False Then D7423.CheckUse = Trim$(rs7423!K7423_CheckUse)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7423_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7423_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7423 As T7423_AREA, IDNO AS String, PROGRAMNO AS String, ITEMCODE AS String) as Boolean

K7423_MOVE = False

Try
    If READ_PFK7423(IDNO, PROGRAMNO, ITEMCODE) = True Then
                z7423 = D7423
		K7423_MOVE = True
		else
	z7423 = nothing
     End If

     If  getColumIndex(spr,"IDNO") > -1 then z7423.IDNO = getDataM(spr, getColumIndex(spr,"IDNO"), xRow)
     If  getColumIndex(spr,"ProgramNo") > -1 then z7423.ProgramNo = getDataM(spr, getColumIndex(spr,"ProgramNo"), xRow)
     If  getColumIndex(spr,"ItemCode") > -1 then z7423.ItemCode = getDataM(spr, getColumIndex(spr,"ItemCode"), xRow)
     If  getColumIndex(spr,"ItemCodeData") > -1 then z7423.ItemCodeData = getDataM(spr, getColumIndex(spr,"ItemCodeData"), xRow)
     If  getColumIndex(spr,"ItemCodeCode") > -1 then z7423.ItemCodeCode = getDataM(spr, getColumIndex(spr,"ItemCodeCode"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7423.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7423.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7423.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7423.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7423.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7423_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7423_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7423 As T7423_AREA,CheckClear as Boolean,IDNO AS String, PROGRAMNO AS String, ITEMCODE AS String) as Boolean

K7423_MOVE = False

Try
    If READ_PFK7423(IDNO, PROGRAMNO, ITEMCODE) = True Then
                z7423 = D7423
		K7423_MOVE = True
		else
	If CheckClear  = True then z7423 = nothing
     End If

     If  getColumIndex(spr,"IDNO") > -1 then z7423.IDNO = getDataM(spr, getColumIndex(spr,"IDNO"), xRow)
     If  getColumIndex(spr,"ProgramNo") > -1 then z7423.ProgramNo = getDataM(spr, getColumIndex(spr,"ProgramNo"), xRow)
     If  getColumIndex(spr,"ItemCode") > -1 then z7423.ItemCode = getDataM(spr, getColumIndex(spr,"ItemCode"), xRow)
     If  getColumIndex(spr,"ItemCodeData") > -1 then z7423.ItemCodeData = getDataM(spr, getColumIndex(spr,"ItemCodeData"), xRow)
     If  getColumIndex(spr,"ItemCodeCode") > -1 then z7423.ItemCodeCode = getDataM(spr, getColumIndex(spr,"ItemCodeCode"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7423.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7423.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7423.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7423.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7423.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7423_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7423_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7423 As T7423_AREA, Job as String, IDNO AS String, PROGRAMNO AS String, ITEMCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7423_MOVE = False

Try
    If READ_PFK7423(IDNO, PROGRAMNO, ITEMCODE) = True Then
                z7423 = D7423
		K7423_MOVE = True
		else
	z7423 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7423")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "IDNO":z7423.IDNO = Children(i).Code
   Case "PROGRAMNO":z7423.ProgramNo = Children(i).Code
   Case "ITEMCODE":z7423.ItemCode = Children(i).Code
   Case "ITEMCODEDATA":z7423.ItemCodeData = Children(i).Code
   Case "ITEMCODECODE":z7423.ItemCodeCode = Children(i).Code
   Case "DATEINSERT":z7423.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7423.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7423.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7423.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7423.CheckUse = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "IDNO":z7423.IDNO = Children(i).Data
   Case "PROGRAMNO":z7423.ProgramNo = Children(i).Data
   Case "ITEMCODE":z7423.ItemCode = Children(i).Data
   Case "ITEMCODEDATA":z7423.ItemCodeData = Children(i).Data
   Case "ITEMCODECODE":z7423.ItemCodeCode = Children(i).Data
   Case "DATEINSERT":z7423.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7423.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7423.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7423.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7423.CheckUse = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7423_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7423_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7423 As T7423_AREA, Job as String, CheckClear as Boolean, IDNO AS String, PROGRAMNO AS String, ITEMCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7423_MOVE = False

Try
    If READ_PFK7423(IDNO, PROGRAMNO, ITEMCODE) = True Then
                z7423 = D7423
		K7423_MOVE = True
		else
	If CheckClear  = True then z7423 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7423")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "IDNO":z7423.IDNO = Children(i).Code
   Case "PROGRAMNO":z7423.ProgramNo = Children(i).Code
   Case "ITEMCODE":z7423.ItemCode = Children(i).Code
   Case "ITEMCODEDATA":z7423.ItemCodeData = Children(i).Code
   Case "ITEMCODECODE":z7423.ItemCodeCode = Children(i).Code
   Case "DATEINSERT":z7423.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7423.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7423.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7423.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7423.CheckUse = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "IDNO":z7423.IDNO = Children(i).Data
   Case "PROGRAMNO":z7423.ProgramNo = Children(i).Data
   Case "ITEMCODE":z7423.ItemCode = Children(i).Data
   Case "ITEMCODEDATA":z7423.ItemCodeData = Children(i).Data
   Case "ITEMCODECODE":z7423.ItemCodeCode = Children(i).Data
   Case "DATEINSERT":z7423.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7423.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7423.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7423.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7423.CheckUse = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7423_MOVE",vbCritical)
End Try
End Function 
    
End Module 
