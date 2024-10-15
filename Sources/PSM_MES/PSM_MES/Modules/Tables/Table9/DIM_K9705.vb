'=========================================================================================================================================================
'   TABLE : (PFK9705)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K9705

Structure T9705_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	FormName	 AS String	'			varchar(50)		*
Public 	GroupUser	 AS String	'			char(3)		*
Public 	Version	 AS String	'			varchar(20)
Public 	Data	 AS String	'			varchar(-1)
Public 	DateCreate	 AS String	'			char(8)
'=========================================================================================================================================================
End structure

Public D9705 As T9705_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK9705(FORMNAME AS String, GROUPUSER AS String) As Boolean
    READ_PFK9705 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9705 "
    SQL = SQL & " WHERE K9705_FormName		 = '" & FormName & "' " 
    SQL = SQL & "   AND K9705_GroupUser		 = '" & GroupUser & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D9705_CLEAR: GoTo SKIP_READ_PFK9705
                
    Call K9705_MOVE(rd)
    READ_PFK9705 = True

SKIP_READ_PFK9705:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK9705",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK9705(FORMNAME AS String, GROUPUSER AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9705 "
    SQL = SQL & " WHERE K9705_FormName		 = '" & FormName & "' " 
    SQL = SQL & "   AND K9705_GroupUser		 = '" & GroupUser & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK9705",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK9705(z9705 As T9705_AREA) As Boolean
    WRITE_PFK9705 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z9705)
 
    SQL = " INSERT INTO PFK9705 "
    SQL = SQL & " ( "
    SQL = SQL & " K9705_FormName," 
    SQL = SQL & " K9705_GroupUser," 
    SQL = SQL & " K9705_Version," 
    SQL = SQL & " K9705_Data," 
    SQL = SQL & " K9705_DateCreate " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z9705.FormName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9705.GroupUser) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9705.Version) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9705.Data) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9705.DateCreate) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK9705 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK9705",vbCritical)
Finally
        Call GetFullInformation("PFK9705", "I", SQL)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK9705(z9705 As T9705_AREA) As Boolean
    REWRITE_PFK9705 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z9705)
   
    SQL = " UPDATE PFK9705 SET "
    SQL = SQL & "    K9705_Version      = N'" & FormatSQL(z9705.Version) & "', " 
    SQL = SQL & "    K9705_Data      = N'" & FormatSQL(z9705.Data) & "', " 
    SQL = SQL & "    K9705_DateCreate      = N'" & FormatSQL(z9705.DateCreate) & "'  " 
    SQL = SQL & " WHERE K9705_FormName		 = '" & z9705.FormName & "' " 
    SQL = SQL & "   AND K9705_GroupUser		 = '" & z9705.GroupUser & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK9705 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK9705",vbCritical)
Finally
        Call GetFullInformation("PFK9705", "U", SQL)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK9705(z9705 As T9705_AREA) As Boolean
    DELETE_PFK9705 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK9705 "
    SQL = SQL & " WHERE K9705_FormName		 = '" & z9705.FormName & "' " 
    SQL = SQL & "   AND K9705_GroupUser		 = '" & z9705.GroupUser & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK9705 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK9705",vbCritical)
Finally
        Call GetFullInformation("PFK9705", "D", SQL)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D9705_CLEAR()
Try
    
   D9705.FormName = ""
   D9705.GroupUser = ""
   D9705.Version = ""
   D9705.Data = ""
   D9705.DateCreate = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D9705_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x9705 As T9705_AREA)
Try
    
    x9705.FormName = trim$(  x9705.FormName)
    x9705.GroupUser = trim$(  x9705.GroupUser)
    x9705.Version = trim$(  x9705.Version)
    x9705.Data = trim$(  x9705.Data)
    x9705.DateCreate = trim$(  x9705.DateCreate)
     
    If trim$( x9705.FormName ) = "" Then x9705.FormName = Space(1) 
    If trim$( x9705.GroupUser ) = "" Then x9705.GroupUser = Space(1) 
    If trim$( x9705.Version ) = "" Then x9705.Version = Space(1) 
    If trim$( x9705.Data ) = "" Then x9705.Data = Space(1) 
    If trim$( x9705.DateCreate ) = "" Then x9705.DateCreate = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K9705_MOVE(rs9705 As SqlClient.SqlDataReader)
Try

    call D9705_CLEAR()   

    If IsdbNull(rs9705!K9705_FormName) = False Then D9705.FormName = Trim$(rs9705!K9705_FormName)
    If IsdbNull(rs9705!K9705_GroupUser) = False Then D9705.GroupUser = Trim$(rs9705!K9705_GroupUser)
    If IsdbNull(rs9705!K9705_Version) = False Then D9705.Version = Trim$(rs9705!K9705_Version)
    If IsdbNull(rs9705!K9705_Data) = False Then D9705.Data = Trim$(rs9705!K9705_Data)
    If IsdbNull(rs9705!K9705_DateCreate) = False Then D9705.DateCreate = Trim$(rs9705!K9705_DateCreate)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9705_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K9705_MOVE(rs9705 As DataRow)
Try

    call D9705_CLEAR()   

    If IsdbNull(rs9705!K9705_FormName) = False Then D9705.FormName = Trim$(rs9705!K9705_FormName)
    If IsdbNull(rs9705!K9705_GroupUser) = False Then D9705.GroupUser = Trim$(rs9705!K9705_GroupUser)
    If IsdbNull(rs9705!K9705_Version) = False Then D9705.Version = Trim$(rs9705!K9705_Version)
    If IsdbNull(rs9705!K9705_Data) = False Then D9705.Data = Trim$(rs9705!K9705_Data)
    If IsdbNull(rs9705!K9705_DateCreate) = False Then D9705.DateCreate = Trim$(rs9705!K9705_DateCreate)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9705_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K9705_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9705 As T9705_AREA, FORMNAME AS String, GROUPUSER AS String) as Boolean

K9705_MOVE = False

Try
    If READ_PFK9705(FORMNAME, GROUPUSER) = True Then
                z9705 = D9705
		K9705_MOVE = True
		else
	z9705 = nothing
     End If

     If  getColumnIndex(spr,"FormName") > -1 then z9705.FormName = getDataM(spr, getColumnIndex(spr,"FormName"), xRow)
     If  getColumnIndex(spr,"GroupUser") > -1 then z9705.GroupUser = getDataM(spr, getColumnIndex(spr,"GroupUser"), xRow)
     If  getColumnIndex(spr,"Version") > -1 then z9705.Version = getDataM(spr, getColumnIndex(spr,"Version"), xRow)
     If  getColumnIndex(spr,"Data") > -1 then z9705.Data = getDataM(spr, getColumnIndex(spr,"Data"), xRow)
     If  getColumnIndex(spr,"DateCreate") > -1 then z9705.DateCreate = getDataM(spr, getColumnIndex(spr,"DateCreate"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K9705_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K9705_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9705 As T9705_AREA,CheckClear as Boolean,FORMNAME AS String, GROUPUSER AS String) as Boolean

K9705_MOVE = False

Try
    If READ_PFK9705(FORMNAME, GROUPUSER) = True Then
                z9705 = D9705
		K9705_MOVE = True
		else
	If CheckClear  = True then z9705 = nothing
     End If

     If  getColumnIndex(spr,"FormName") > -1 then z9705.FormName = getDataM(spr, getColumnIndex(spr,"FormName"), xRow)
     If  getColumnIndex(spr,"GroupUser") > -1 then z9705.GroupUser = getDataM(spr, getColumnIndex(spr,"GroupUser"), xRow)
     If  getColumnIndex(spr,"Version") > -1 then z9705.Version = getDataM(spr, getColumnIndex(spr,"Version"), xRow)
     If  getColumnIndex(spr,"Data") > -1 then z9705.Data = getDataM(spr, getColumnIndex(spr,"Data"), xRow)
     If  getColumnIndex(spr,"DateCreate") > -1 then z9705.DateCreate = getDataM(spr, getColumnIndex(spr,"DateCreate"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K9705_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K9705_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9705 As T9705_AREA, Job as String, FORMNAME AS String, GROUPUSER AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9705_MOVE = False

Try
    If READ_PFK9705(FORMNAME, GROUPUSER) = True Then
                z9705 = D9705
		K9705_MOVE = True
		else
	z9705 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9705")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "FORMNAME":z9705.FormName = Children(i).Code
   Case "GROUPUSER":z9705.GroupUser = Children(i).Code
   Case "VERSION":z9705.Version = Children(i).Code
   Case "DATA":z9705.Data = Children(i).Code
   Case "DATECREATE":z9705.DateCreate = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "FORMNAME":z9705.FormName = Children(i).Data
   Case "GROUPUSER":z9705.GroupUser = Children(i).Data
   Case "VERSION":z9705.Version = Children(i).Data
   Case "DATA":z9705.Data = Children(i).Data
   Case "DATECREATE":z9705.DateCreate = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K9705_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K9705_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9705 As T9705_AREA, Job as String, CheckClear as Boolean, FORMNAME AS String, GROUPUSER AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9705_MOVE = False

Try
    If READ_PFK9705(FORMNAME, GROUPUSER) = True Then
                z9705 = D9705
		K9705_MOVE = True
		else
	If CheckClear  = True then z9705 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9705")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "FORMNAME":z9705.FormName = Children(i).Code
   Case "GROUPUSER":z9705.GroupUser = Children(i).Code
   Case "VERSION":z9705.Version = Children(i).Code
   Case "DATA":z9705.Data = Children(i).Code
   Case "DATECREATE":z9705.DateCreate = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "FORMNAME":z9705.FormName = Children(i).Data
   Case "GROUPUSER":z9705.GroupUser = Children(i).Data
   Case "VERSION":z9705.Version = Children(i).Data
   Case "DATA":z9705.Data = Children(i).Data
   Case "DATECREATE":z9705.DateCreate = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K9705_MOVE",vbCritical)
End Try
End Function 
    

'=========================================================================================================================================================
' DATA MOVE FORM NEW AREA
'=========================================================================================================================================================
Public Sub K9705_MOVE(ByRef a9705 As T9705_AREA, ByRef b9705 As T9705_AREA) 
Try
If trim$( a9705.FormName ) = "" Then b9705.FormName = ""  Else b9705.FormName=a9705.FormName
If trim$( a9705.GroupUser ) = "" Then b9705.GroupUser = ""  Else b9705.GroupUser=a9705.GroupUser
If trim$( a9705.Version ) = "" Then b9705.Version = ""  Else b9705.Version=a9705.Version
If trim$( a9705.Data ) = "" Then b9705.Data = ""  Else b9705.Data=a9705.Data
If trim$( a9705.DateCreate ) = "" Then b9705.DateCreate = ""  Else b9705.DateCreate=a9705.DateCreate
Catch ex As Exception
      Call MsgBoxP("K9705_MOVE",vbCritical)
End Try
End Sub 


End Module 
