'=========================================================================================================================================================
'   TABLE : (PFK9001)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K9001

Structure T9001_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	MappingNo	 AS String	'			char(6)		*
Public 	MappingName	 AS String	'			nvarchar(50)
Public 	CustomerCode	 AS String	'			char(6)
Public 	InchargeMapping	 AS String	'			char(8)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	Remark	 AS String	'			nvarchar(50)
'=========================================================================================================================================================
End structure

Public D9001 As T9001_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK9001(MAPPINGNO AS String) As Boolean
    READ_PFK9001 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9001 "
    SQL = SQL & " WHERE K9001_MappingNo		 = '" & MappingNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D9001_CLEAR: GoTo SKIP_READ_PFK9001
                
    Call K9001_MOVE(rd)
    READ_PFK9001 = True

SKIP_READ_PFK9001:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK9001",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK9001(MAPPINGNO AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9001 "
    SQL = SQL & " WHERE K9001_MappingNo		 = '" & MappingNo & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK9001",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK9001(z9001 As T9001_AREA) As Boolean
    WRITE_PFK9001 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z9001)
 
    SQL = " INSERT INTO PFK9001 "
    SQL = SQL & " ( "
    SQL = SQL & " K9001_MappingNo," 
    SQL = SQL & " K9001_MappingName," 
    SQL = SQL & " K9001_CustomerCode," 
    SQL = SQL & " K9001_InchargeMapping," 
    SQL = SQL & " K9001_DateInsert," 
    SQL = SQL & " K9001_DateUpdate," 
    SQL = SQL & " K9001_InchargeInsert," 
    SQL = SQL & " K9001_InchargeUpdate," 
    SQL = SQL & " K9001_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z9001.MappingNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9001.MappingName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9001.CustomerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9001.InchargeMapping) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9001.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9001.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9001.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9001.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9001.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK9001 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK9001",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK9001(z9001 As T9001_AREA) As Boolean
    REWRITE_PFK9001 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z9001)
   
    SQL = " UPDATE PFK9001 SET "
    SQL = SQL & "    K9001_MappingName      = N'" & FormatSQL(z9001.MappingName) & "', " 
    SQL = SQL & "    K9001_CustomerCode      = N'" & FormatSQL(z9001.CustomerCode) & "', " 
    SQL = SQL & "    K9001_InchargeMapping      = N'" & FormatSQL(z9001.InchargeMapping) & "', " 
    SQL = SQL & "    K9001_DateInsert      = N'" & FormatSQL(z9001.DateInsert) & "', " 
    SQL = SQL & "    K9001_DateUpdate      = N'" & FormatSQL(z9001.DateUpdate) & "', " 
    SQL = SQL & "    K9001_InchargeInsert      = N'" & FormatSQL(z9001.InchargeInsert) & "', " 
    SQL = SQL & "    K9001_InchargeUpdate      = N'" & FormatSQL(z9001.InchargeUpdate) & "', " 
    SQL = SQL & "    K9001_Remark      = N'" & FormatSQL(z9001.Remark) & "'  " 
    SQL = SQL & " WHERE K9001_MappingNo		 = '" & z9001.MappingNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK9001 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK9001",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK9001(z9001 As T9001_AREA) As Boolean
    DELETE_PFK9001 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK9001 "
    SQL = SQL & " WHERE K9001_MappingNo		 = '" & z9001.MappingNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK9001 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK9001",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D9001_CLEAR()
Try
    
   D9001.MappingNo = ""
   D9001.MappingName = ""
   D9001.CustomerCode = ""
   D9001.InchargeMapping = ""
   D9001.DateInsert = ""
   D9001.DateUpdate = ""
   D9001.InchargeInsert = ""
   D9001.InchargeUpdate = ""
   D9001.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D9001_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x9001 As T9001_AREA)
Try
    
    x9001.MappingNo = trim$(  x9001.MappingNo)
    x9001.MappingName = trim$(  x9001.MappingName)
    x9001.CustomerCode = trim$(  x9001.CustomerCode)
    x9001.InchargeMapping = trim$(  x9001.InchargeMapping)
    x9001.DateInsert = trim$(  x9001.DateInsert)
    x9001.DateUpdate = trim$(  x9001.DateUpdate)
    x9001.InchargeInsert = trim$(  x9001.InchargeInsert)
    x9001.InchargeUpdate = trim$(  x9001.InchargeUpdate)
    x9001.Remark = trim$(  x9001.Remark)
     
    If trim$( x9001.MappingNo ) = "" Then x9001.MappingNo = Space(1) 
    If trim$( x9001.MappingName ) = "" Then x9001.MappingName = Space(1) 
    If trim$( x9001.CustomerCode ) = "" Then x9001.CustomerCode = Space(1) 
    If trim$( x9001.InchargeMapping ) = "" Then x9001.InchargeMapping = Space(1) 
    If trim$( x9001.DateInsert ) = "" Then x9001.DateInsert = Space(1) 
    If trim$( x9001.DateUpdate ) = "" Then x9001.DateUpdate = Space(1) 
    If trim$( x9001.InchargeInsert ) = "" Then x9001.InchargeInsert = Space(1) 
    If trim$( x9001.InchargeUpdate ) = "" Then x9001.InchargeUpdate = Space(1) 
    If trim$( x9001.Remark ) = "" Then x9001.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K9001_MOVE(rs9001 As SqlClient.SqlDataReader)
Try

    call D9001_CLEAR()   

    If IsdbNull(rs9001!K9001_MappingNo) = False Then D9001.MappingNo = Trim$(rs9001!K9001_MappingNo)
    If IsdbNull(rs9001!K9001_MappingName) = False Then D9001.MappingName = Trim$(rs9001!K9001_MappingName)
    If IsdbNull(rs9001!K9001_CustomerCode) = False Then D9001.CustomerCode = Trim$(rs9001!K9001_CustomerCode)
    If IsdbNull(rs9001!K9001_InchargeMapping) = False Then D9001.InchargeMapping = Trim$(rs9001!K9001_InchargeMapping)
    If IsdbNull(rs9001!K9001_DateInsert) = False Then D9001.DateInsert = Trim$(rs9001!K9001_DateInsert)
    If IsdbNull(rs9001!K9001_DateUpdate) = False Then D9001.DateUpdate = Trim$(rs9001!K9001_DateUpdate)
    If IsdbNull(rs9001!K9001_InchargeInsert) = False Then D9001.InchargeInsert = Trim$(rs9001!K9001_InchargeInsert)
    If IsdbNull(rs9001!K9001_InchargeUpdate) = False Then D9001.InchargeUpdate = Trim$(rs9001!K9001_InchargeUpdate)
    If IsdbNull(rs9001!K9001_Remark) = False Then D9001.Remark = Trim$(rs9001!K9001_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9001_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K9001_MOVE(rs9001 As DataRow)
Try

    call D9001_CLEAR()   

    If IsdbNull(rs9001!K9001_MappingNo) = False Then D9001.MappingNo = Trim$(rs9001!K9001_MappingNo)
    If IsdbNull(rs9001!K9001_MappingName) = False Then D9001.MappingName = Trim$(rs9001!K9001_MappingName)
    If IsdbNull(rs9001!K9001_CustomerCode) = False Then D9001.CustomerCode = Trim$(rs9001!K9001_CustomerCode)
    If IsdbNull(rs9001!K9001_InchargeMapping) = False Then D9001.InchargeMapping = Trim$(rs9001!K9001_InchargeMapping)
    If IsdbNull(rs9001!K9001_DateInsert) = False Then D9001.DateInsert = Trim$(rs9001!K9001_DateInsert)
    If IsdbNull(rs9001!K9001_DateUpdate) = False Then D9001.DateUpdate = Trim$(rs9001!K9001_DateUpdate)
    If IsdbNull(rs9001!K9001_InchargeInsert) = False Then D9001.InchargeInsert = Trim$(rs9001!K9001_InchargeInsert)
    If IsdbNull(rs9001!K9001_InchargeUpdate) = False Then D9001.InchargeUpdate = Trim$(rs9001!K9001_InchargeUpdate)
    If IsdbNull(rs9001!K9001_Remark) = False Then D9001.Remark = Trim$(rs9001!K9001_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9001_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K9001_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9001 As T9001_AREA, MAPPINGNO AS String) as Boolean

K9001_MOVE = False

Try
    If READ_PFK9001(MAPPINGNO) = True Then
                z9001 = D9001
		K9001_MOVE = True
		else
	z9001 = nothing
     End If

     If  getColumIndex(spr,"MappingNo") > -1 then z9001.MappingNo = getDataM(spr, getColumIndex(spr,"MappingNo"), xRow)
     If  getColumIndex(spr,"MappingName") > -1 then z9001.MappingName = getDataM(spr, getColumIndex(spr,"MappingName"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z9001.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"InchargeMapping") > -1 then z9001.InchargeMapping = getDataM(spr, getColumIndex(spr,"InchargeMapping"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z9001.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z9001.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z9001.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z9001.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z9001.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K9001_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K9001_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9001 As T9001_AREA,CheckClear as Boolean,MAPPINGNO AS String) as Boolean

K9001_MOVE = False

Try
    If READ_PFK9001(MAPPINGNO) = True Then
                z9001 = D9001
		K9001_MOVE = True
		else
	If CheckClear  = True then z9001 = nothing
     End If

     If  getColumIndex(spr,"MappingNo") > -1 then z9001.MappingNo = getDataM(spr, getColumIndex(spr,"MappingNo"), xRow)
     If  getColumIndex(spr,"MappingName") > -1 then z9001.MappingName = getDataM(spr, getColumIndex(spr,"MappingName"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z9001.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"InchargeMapping") > -1 then z9001.InchargeMapping = getDataM(spr, getColumIndex(spr,"InchargeMapping"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z9001.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z9001.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z9001.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z9001.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z9001.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K9001_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K9001_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9001 As T9001_AREA, Job as String, MAPPINGNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9001_MOVE = False

Try
    If READ_PFK9001(MAPPINGNO) = True Then
                z9001 = D9001
		K9001_MOVE = True
		else
	z9001 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9001")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "MAPPINGNO":z9001.MappingNo = Children(i).Code
   Case "MAPPINGNAME":z9001.MappingName = Children(i).Code
   Case "CUSTOMERCODE":z9001.CustomerCode = Children(i).Code
   Case "INCHARGEMAPPING":z9001.InchargeMapping = Children(i).Code
   Case "DATEINSERT":z9001.DateInsert = Children(i).Code
   Case "DATEUPDATE":z9001.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z9001.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z9001.InchargeUpdate = Children(i).Code
   Case "REMARK":z9001.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "MAPPINGNO":z9001.MappingNo = Children(i).Data
   Case "MAPPINGNAME":z9001.MappingName = Children(i).Data
   Case "CUSTOMERCODE":z9001.CustomerCode = Children(i).Data
   Case "INCHARGEMAPPING":z9001.InchargeMapping = Children(i).Data
   Case "DATEINSERT":z9001.DateInsert = Children(i).Data
   Case "DATEUPDATE":z9001.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z9001.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z9001.InchargeUpdate = Children(i).Data
   Case "REMARK":z9001.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K9001_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K9001_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9001 As T9001_AREA, Job as String, CheckClear as Boolean, MAPPINGNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9001_MOVE = False

Try
    If READ_PFK9001(MAPPINGNO) = True Then
                z9001 = D9001
		K9001_MOVE = True
		else
	If CheckClear  = True then z9001 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9001")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "MAPPINGNO":z9001.MappingNo = Children(i).Code
   Case "MAPPINGNAME":z9001.MappingName = Children(i).Code
   Case "CUSTOMERCODE":z9001.CustomerCode = Children(i).Code
   Case "INCHARGEMAPPING":z9001.InchargeMapping = Children(i).Code
   Case "DATEINSERT":z9001.DateInsert = Children(i).Code
   Case "DATEUPDATE":z9001.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z9001.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z9001.InchargeUpdate = Children(i).Code
   Case "REMARK":z9001.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "MAPPINGNO":z9001.MappingNo = Children(i).Data
   Case "MAPPINGNAME":z9001.MappingName = Children(i).Data
   Case "CUSTOMERCODE":z9001.CustomerCode = Children(i).Data
   Case "INCHARGEMAPPING":z9001.InchargeMapping = Children(i).Data
   Case "DATEINSERT":z9001.DateInsert = Children(i).Data
   Case "DATEUPDATE":z9001.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z9001.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z9001.InchargeUpdate = Children(i).Data
   Case "REMARK":z9001.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K9001_MOVE",vbCritical)
End Try
End Function 
    
End Module 
