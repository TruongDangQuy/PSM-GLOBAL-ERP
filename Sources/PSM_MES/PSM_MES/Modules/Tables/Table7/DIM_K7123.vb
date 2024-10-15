'=========================================================================================================================================================
'   TABLE : (PFK7123)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7123

Structure T7123_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	SpecCode	 AS String	'			char(6)		*
Public 	SpecSeq	 AS Double	'			decimal		*
Public 	Width	 AS String	'			nvarchar(20)
Public 	Height	 AS String	'			nvarchar(20)
Public 	SizeName	 AS String	'			nvarchar(20)
Public 	CheckUse	 AS String	'			char(1)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	Remark	 AS String	'			nvarchar(100)
'=========================================================================================================================================================
End structure

Public D7123 As T7123_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7123(SPECCODE AS String, SPECSEQ AS Double) As Boolean
    READ_PFK7123 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7123 "
    SQL = SQL & " WHERE K7123_SpecCode		 = '" & SpecCode & "' " 
    SQL = SQL & "   AND K7123_SpecSeq		 =  " & SpecSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7123_CLEAR: GoTo SKIP_READ_PFK7123
                
    Call K7123_MOVE(rd)
    READ_PFK7123 = True

SKIP_READ_PFK7123:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7123",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7123(SPECCODE AS String, SPECSEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7123 "
    SQL = SQL & " WHERE K7123_SpecCode		 = '" & SpecCode & "' " 
    SQL = SQL & "   AND K7123_SpecSeq		 =  " & SpecSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7123",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7123(z7123 As T7123_AREA) As Boolean
    WRITE_PFK7123 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7123)
 
    SQL = " INSERT INTO PFK7123 "
    SQL = SQL & " ( "
    SQL = SQL & " K7123_SpecCode," 
    SQL = SQL & " K7123_SpecSeq," 
    SQL = SQL & " K7123_Width," 
    SQL = SQL & " K7123_Height," 
    SQL = SQL & " K7123_SizeName," 
    SQL = SQL & " K7123_CheckUse," 
    SQL = SQL & " K7123_DateInsert," 
    SQL = SQL & " K7123_DateUpdate," 
    SQL = SQL & " K7123_InchargeInsert," 
    SQL = SQL & " K7123_InchargeUpdate," 
    SQL = SQL & " K7123_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7123.SpecCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z7123.SpecSeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7123.Width) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7123.Height) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7123.SizeName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7123.CheckUse) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7123.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7123.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7123.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7123.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7123.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7123 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7123",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7123(z7123 As T7123_AREA) As Boolean
    REWRITE_PFK7123 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7123)
   
    SQL = " UPDATE PFK7123 SET "
    SQL = SQL & "    K7123_Width      = N'" & FormatSQL(z7123.Width) & "', " 
    SQL = SQL & "    K7123_Height      = N'" & FormatSQL(z7123.Height) & "', " 
    SQL = SQL & "    K7123_SizeName      = N'" & FormatSQL(z7123.SizeName) & "', " 
    SQL = SQL & "    K7123_CheckUse      = N'" & FormatSQL(z7123.CheckUse) & "', " 
    SQL = SQL & "    K7123_DateInsert      = N'" & FormatSQL(z7123.DateInsert) & "', " 
    SQL = SQL & "    K7123_DateUpdate      = N'" & FormatSQL(z7123.DateUpdate) & "', " 
    SQL = SQL & "    K7123_InchargeInsert      = N'" & FormatSQL(z7123.InchargeInsert) & "', " 
    SQL = SQL & "    K7123_InchargeUpdate      = N'" & FormatSQL(z7123.InchargeUpdate) & "', " 
    SQL = SQL & "    K7123_Remark      = N'" & FormatSQL(z7123.Remark) & "'  " 
    SQL = SQL & " WHERE K7123_SpecCode		 = '" & z7123.SpecCode & "' " 
    SQL = SQL & "   AND K7123_SpecSeq		 =  " & z7123.SpecSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7123 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7123",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7123(z7123 As T7123_AREA) As Boolean
    DELETE_PFK7123 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7123 "
    SQL = SQL & " WHERE K7123_SpecCode		 = '" & z7123.SpecCode & "' " 
    SQL = SQL & "   AND K7123_SpecSeq		 =  " & z7123.SpecSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7123 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7123",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7123_CLEAR()
Try
    
   D7123.SpecCode = ""
    D7123.SpecSeq = 0 
   D7123.Width = ""
   D7123.Height = ""
   D7123.SizeName = ""
   D7123.CheckUse = ""
   D7123.DateInsert = ""
   D7123.DateUpdate = ""
   D7123.InchargeInsert = ""
   D7123.InchargeUpdate = ""
   D7123.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7123_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7123 As T7123_AREA)
Try
    
    x7123.SpecCode = trim$(  x7123.SpecCode)
    x7123.SpecSeq = trim$(  x7123.SpecSeq)
    x7123.Width = trim$(  x7123.Width)
    x7123.Height = trim$(  x7123.Height)
    x7123.SizeName = trim$(  x7123.SizeName)
    x7123.CheckUse = trim$(  x7123.CheckUse)
    x7123.DateInsert = trim$(  x7123.DateInsert)
    x7123.DateUpdate = trim$(  x7123.DateUpdate)
    x7123.InchargeInsert = trim$(  x7123.InchargeInsert)
    x7123.InchargeUpdate = trim$(  x7123.InchargeUpdate)
    x7123.Remark = trim$(  x7123.Remark)
     
    If trim$( x7123.SpecCode ) = "" Then x7123.SpecCode = Space(1) 
    If trim$( x7123.SpecSeq ) = "" Then x7123.SpecSeq = 0 
    If trim$( x7123.Width ) = "" Then x7123.Width = Space(1) 
    If trim$( x7123.Height ) = "" Then x7123.Height = Space(1) 
    If trim$( x7123.SizeName ) = "" Then x7123.SizeName = Space(1) 
    If trim$( x7123.CheckUse ) = "" Then x7123.CheckUse = Space(1) 
    If trim$( x7123.DateInsert ) = "" Then x7123.DateInsert = Space(1) 
    If trim$( x7123.DateUpdate ) = "" Then x7123.DateUpdate = Space(1) 
    If trim$( x7123.InchargeInsert ) = "" Then x7123.InchargeInsert = Space(1) 
    If trim$( x7123.InchargeUpdate ) = "" Then x7123.InchargeUpdate = Space(1) 
    If trim$( x7123.Remark ) = "" Then x7123.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7123_MOVE(rs7123 As SqlClient.SqlDataReader)
Try

    call D7123_CLEAR()   

    If IsdbNull(rs7123!K7123_SpecCode) = False Then D7123.SpecCode = Trim$(rs7123!K7123_SpecCode)
    If IsdbNull(rs7123!K7123_SpecSeq) = False Then D7123.SpecSeq = Trim$(rs7123!K7123_SpecSeq)
    If IsdbNull(rs7123!K7123_Width) = False Then D7123.Width = Trim$(rs7123!K7123_Width)
    If IsdbNull(rs7123!K7123_Height) = False Then D7123.Height = Trim$(rs7123!K7123_Height)
    If IsdbNull(rs7123!K7123_SizeName) = False Then D7123.SizeName = Trim$(rs7123!K7123_SizeName)
    If IsdbNull(rs7123!K7123_CheckUse) = False Then D7123.CheckUse = Trim$(rs7123!K7123_CheckUse)
    If IsdbNull(rs7123!K7123_DateInsert) = False Then D7123.DateInsert = Trim$(rs7123!K7123_DateInsert)
    If IsdbNull(rs7123!K7123_DateUpdate) = False Then D7123.DateUpdate = Trim$(rs7123!K7123_DateUpdate)
    If IsdbNull(rs7123!K7123_InchargeInsert) = False Then D7123.InchargeInsert = Trim$(rs7123!K7123_InchargeInsert)
    If IsdbNull(rs7123!K7123_InchargeUpdate) = False Then D7123.InchargeUpdate = Trim$(rs7123!K7123_InchargeUpdate)
    If IsdbNull(rs7123!K7123_Remark) = False Then D7123.Remark = Trim$(rs7123!K7123_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7123_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7123_MOVE(rs7123 As DataRow)
Try

    call D7123_CLEAR()   

    If IsdbNull(rs7123!K7123_SpecCode) = False Then D7123.SpecCode = Trim$(rs7123!K7123_SpecCode)
    If IsdbNull(rs7123!K7123_SpecSeq) = False Then D7123.SpecSeq = Trim$(rs7123!K7123_SpecSeq)
    If IsdbNull(rs7123!K7123_Width) = False Then D7123.Width = Trim$(rs7123!K7123_Width)
    If IsdbNull(rs7123!K7123_Height) = False Then D7123.Height = Trim$(rs7123!K7123_Height)
    If IsdbNull(rs7123!K7123_SizeName) = False Then D7123.SizeName = Trim$(rs7123!K7123_SizeName)
    If IsdbNull(rs7123!K7123_CheckUse) = False Then D7123.CheckUse = Trim$(rs7123!K7123_CheckUse)
    If IsdbNull(rs7123!K7123_DateInsert) = False Then D7123.DateInsert = Trim$(rs7123!K7123_DateInsert)
    If IsdbNull(rs7123!K7123_DateUpdate) = False Then D7123.DateUpdate = Trim$(rs7123!K7123_DateUpdate)
    If IsdbNull(rs7123!K7123_InchargeInsert) = False Then D7123.InchargeInsert = Trim$(rs7123!K7123_InchargeInsert)
    If IsdbNull(rs7123!K7123_InchargeUpdate) = False Then D7123.InchargeUpdate = Trim$(rs7123!K7123_InchargeUpdate)
    If IsdbNull(rs7123!K7123_Remark) = False Then D7123.Remark = Trim$(rs7123!K7123_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7123_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7123_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7123 As T7123_AREA, SPECCODE AS String, SPECSEQ AS Double) as Boolean

K7123_MOVE = False

Try
    If READ_PFK7123(SPECCODE, SPECSEQ) = True Then
                z7123 = D7123
		K7123_MOVE = True
		else
	z7123 = nothing
     End If

     If  getColumIndex(spr,"SpecCode") > -1 then z7123.SpecCode = getDataM(spr, getColumIndex(spr,"SpecCode"), xRow)
     If  getColumIndex(spr,"SpecSeq") > -1 then z7123.SpecSeq = getDataM(spr, getColumIndex(spr,"SpecSeq"), xRow)
     If  getColumIndex(spr,"Width") > -1 then z7123.Width = getDataM(spr, getColumIndex(spr,"Width"), xRow)
     If  getColumIndex(spr,"Height") > -1 then z7123.Height = getDataM(spr, getColumIndex(spr,"Height"), xRow)
     If  getColumIndex(spr,"SizeName") > -1 then z7123.SizeName = getDataM(spr, getColumIndex(spr,"SizeName"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7123.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7123.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7123.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7123.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7123.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7123.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7123_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7123_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7123 As T7123_AREA,CheckClear as Boolean,SPECCODE AS String, SPECSEQ AS Double) as Boolean

K7123_MOVE = False

Try
    If READ_PFK7123(SPECCODE, SPECSEQ) = True Then
                z7123 = D7123
		K7123_MOVE = True
		else
	If CheckClear  = True then z7123 = nothing
     End If

     If  getColumIndex(spr,"SpecCode") > -1 then z7123.SpecCode = getDataM(spr, getColumIndex(spr,"SpecCode"), xRow)
     If  getColumIndex(spr,"SpecSeq") > -1 then z7123.SpecSeq = getDataM(spr, getColumIndex(spr,"SpecSeq"), xRow)
     If  getColumIndex(spr,"Width") > -1 then z7123.Width = getDataM(spr, getColumIndex(spr,"Width"), xRow)
     If  getColumIndex(spr,"Height") > -1 then z7123.Height = getDataM(spr, getColumIndex(spr,"Height"), xRow)
     If  getColumIndex(spr,"SizeName") > -1 then z7123.SizeName = getDataM(spr, getColumIndex(spr,"SizeName"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7123.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7123.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7123.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7123.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7123.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7123.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7123_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7123_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7123 As T7123_AREA, Job as String, SPECCODE AS String, SPECSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7123_MOVE = False

Try
    If READ_PFK7123(SPECCODE, SPECSEQ) = True Then
                z7123 = D7123
		K7123_MOVE = True
		else
	z7123 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7123")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SPECCODE":z7123.SpecCode = Children(i).Code
   Case "SPECSEQ":z7123.SpecSeq = Children(i).Code
   Case "WIDTH":z7123.Width = Children(i).Code
   Case "HEIGHT":z7123.Height = Children(i).Code
   Case "SIZENAME":z7123.SizeName = Children(i).Code
   Case "CHECKUSE":z7123.CheckUse = Children(i).Code
   Case "DATEINSERT":z7123.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7123.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7123.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7123.InchargeUpdate = Children(i).Code
   Case "REMARK":z7123.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SPECCODE":z7123.SpecCode = Children(i).Data
   Case "SPECSEQ":z7123.SpecSeq = Children(i).Data
   Case "WIDTH":z7123.Width = Children(i).Data
   Case "HEIGHT":z7123.Height = Children(i).Data
   Case "SIZENAME":z7123.SizeName = Children(i).Data
   Case "CHECKUSE":z7123.CheckUse = Children(i).Data
   Case "DATEINSERT":z7123.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7123.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7123.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7123.InchargeUpdate = Children(i).Data
   Case "REMARK":z7123.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7123_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7123_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7123 As T7123_AREA, Job as String, CheckClear as Boolean, SPECCODE AS String, SPECSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7123_MOVE = False

Try
    If READ_PFK7123(SPECCODE, SPECSEQ) = True Then
                z7123 = D7123
		K7123_MOVE = True
		else
	If CheckClear  = True then z7123 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7123")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SPECCODE":z7123.SpecCode = Children(i).Code
   Case "SPECSEQ":z7123.SpecSeq = Children(i).Code
   Case "WIDTH":z7123.Width = Children(i).Code
   Case "HEIGHT":z7123.Height = Children(i).Code
   Case "SIZENAME":z7123.SizeName = Children(i).Code
   Case "CHECKUSE":z7123.CheckUse = Children(i).Code
   Case "DATEINSERT":z7123.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7123.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7123.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7123.InchargeUpdate = Children(i).Code
   Case "REMARK":z7123.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SPECCODE":z7123.SpecCode = Children(i).Data
   Case "SPECSEQ":z7123.SpecSeq = Children(i).Data
   Case "WIDTH":z7123.Width = Children(i).Data
   Case "HEIGHT":z7123.Height = Children(i).Data
   Case "SIZENAME":z7123.SizeName = Children(i).Data
   Case "CHECKUSE":z7123.CheckUse = Children(i).Data
   Case "DATEINSERT":z7123.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7123.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7123.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7123.InchargeUpdate = Children(i).Data
   Case "REMARK":z7123.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7123_MOVE",vbCritical)
End Try
End Function 
    
End Module 
