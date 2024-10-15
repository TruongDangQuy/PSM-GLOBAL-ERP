'=========================================================================================================================================================
'   TABLE : (PFK7355)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7355

Structure T7355_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	ProcessBOMCode	 AS String	'			nvarchar(6)		*
Public 	ProcessBOMName	 AS String	'			nvarchar(200)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(6)
Public 	InchargeUpdate	 AS String	'			char(6)
Public 	CheckUse	 AS String	'			char(1)
Public 	DateActive	 AS String	'			char(8)
Public 	DateDeactive	 AS String	'			char(8)
Public 	CheckActive	 AS String	'			char(1)
Public 	Remark	 AS String	'			nvarchar(500)
'=========================================================================================================================================================
End structure

Public D7355 As T7355_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7355(PROCESSBOMCODE AS String) As Boolean
    READ_PFK7355 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7355 "
    SQL = SQL & " WHERE K7355_ProcessBOMCode		 = '" & ProcessBOMCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7355_CLEAR: GoTo SKIP_READ_PFK7355
                
    Call K7355_MOVE(rd)
    READ_PFK7355 = True

SKIP_READ_PFK7355:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7355",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7355(PROCESSBOMCODE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7355 "
    SQL = SQL & " WHERE K7355_ProcessBOMCode		 = '" & ProcessBOMCode & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7355",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7355(z7355 As T7355_AREA) As Boolean
    WRITE_PFK7355 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7355)
 
    SQL = " INSERT INTO PFK7355 "
    SQL = SQL & " ( "
    SQL = SQL & " K7355_ProcessBOMCode," 
    SQL = SQL & " K7355_ProcessBOMName," 
    SQL = SQL & " K7355_DateInsert," 
    SQL = SQL & " K7355_DateUpdate," 
    SQL = SQL & " K7355_InchargeInsert," 
    SQL = SQL & " K7355_InchargeUpdate," 
    SQL = SQL & " K7355_CheckUse," 
    SQL = SQL & " K7355_DateActive," 
    SQL = SQL & " K7355_DateDeactive," 
    SQL = SQL & " K7355_CheckActive," 
    SQL = SQL & " K7355_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7355.ProcessBOMCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7355.ProcessBOMName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7355.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7355.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7355.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7355.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7355.CheckUse) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7355.DateActive) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7355.DateDeactive) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7355.CheckActive) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7355.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7355 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7355",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7355(z7355 As T7355_AREA) As Boolean
    REWRITE_PFK7355 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7355)
   
    SQL = " UPDATE PFK7355 SET "
    SQL = SQL & "    K7355_ProcessBOMName      = N'" & FormatSQL(z7355.ProcessBOMName) & "', " 
    SQL = SQL & "    K7355_DateInsert      = N'" & FormatSQL(z7355.DateInsert) & "', " 
    SQL = SQL & "    K7355_DateUpdate      = N'" & FormatSQL(z7355.DateUpdate) & "', " 
    SQL = SQL & "    K7355_InchargeInsert      = N'" & FormatSQL(z7355.InchargeInsert) & "', " 
    SQL = SQL & "    K7355_InchargeUpdate      = N'" & FormatSQL(z7355.InchargeUpdate) & "', " 
    SQL = SQL & "    K7355_CheckUse      = N'" & FormatSQL(z7355.CheckUse) & "', " 
    SQL = SQL & "    K7355_DateActive      = N'" & FormatSQL(z7355.DateActive) & "', " 
    SQL = SQL & "    K7355_DateDeactive      = N'" & FormatSQL(z7355.DateDeactive) & "', " 
    SQL = SQL & "    K7355_CheckActive      = N'" & FormatSQL(z7355.CheckActive) & "', " 
    SQL = SQL & "    K7355_Remark      = N'" & FormatSQL(z7355.Remark) & "'  " 
    SQL = SQL & " WHERE K7355_ProcessBOMCode		 = '" & z7355.ProcessBOMCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7355 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7355",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7355(z7355 As T7355_AREA) As Boolean
    DELETE_PFK7355 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7355 "
    SQL = SQL & " WHERE K7355_ProcessBOMCode		 = '" & z7355.ProcessBOMCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7355 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7355",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7355_CLEAR()
Try
    
   D7355.ProcessBOMCode = ""
   D7355.ProcessBOMName = ""
   D7355.DateInsert = ""
   D7355.DateUpdate = ""
   D7355.InchargeInsert = ""
   D7355.InchargeUpdate = ""
   D7355.CheckUse = ""
   D7355.DateActive = ""
   D7355.DateDeactive = ""
   D7355.CheckActive = ""
   D7355.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7355_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7355 As T7355_AREA)
Try
    
    x7355.ProcessBOMCode = trim$(  x7355.ProcessBOMCode)
    x7355.ProcessBOMName = trim$(  x7355.ProcessBOMName)
    x7355.DateInsert = trim$(  x7355.DateInsert)
    x7355.DateUpdate = trim$(  x7355.DateUpdate)
    x7355.InchargeInsert = trim$(  x7355.InchargeInsert)
    x7355.InchargeUpdate = trim$(  x7355.InchargeUpdate)
    x7355.CheckUse = trim$(  x7355.CheckUse)
    x7355.DateActive = trim$(  x7355.DateActive)
    x7355.DateDeactive = trim$(  x7355.DateDeactive)
    x7355.CheckActive = trim$(  x7355.CheckActive)
    x7355.Remark = trim$(  x7355.Remark)
     
    If trim$( x7355.ProcessBOMCode ) = "" Then x7355.ProcessBOMCode = Space(1) 
    If trim$( x7355.ProcessBOMName ) = "" Then x7355.ProcessBOMName = Space(1) 
    If trim$( x7355.DateInsert ) = "" Then x7355.DateInsert = Space(1) 
    If trim$( x7355.DateUpdate ) = "" Then x7355.DateUpdate = Space(1) 
    If trim$( x7355.InchargeInsert ) = "" Then x7355.InchargeInsert = Space(1) 
    If trim$( x7355.InchargeUpdate ) = "" Then x7355.InchargeUpdate = Space(1) 
    If trim$( x7355.CheckUse ) = "" Then x7355.CheckUse = Space(1) 
    If trim$( x7355.DateActive ) = "" Then x7355.DateActive = Space(1) 
    If trim$( x7355.DateDeactive ) = "" Then x7355.DateDeactive = Space(1) 
    If trim$( x7355.CheckActive ) = "" Then x7355.CheckActive = Space(1) 
    If trim$( x7355.Remark ) = "" Then x7355.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7355_MOVE(rs7355 As SqlClient.SqlDataReader)
Try

    call D7355_CLEAR()   

    If IsdbNull(rs7355!K7355_ProcessBOMCode) = False Then D7355.ProcessBOMCode = Trim$(rs7355!K7355_ProcessBOMCode)
    If IsdbNull(rs7355!K7355_ProcessBOMName) = False Then D7355.ProcessBOMName = Trim$(rs7355!K7355_ProcessBOMName)
    If IsdbNull(rs7355!K7355_DateInsert) = False Then D7355.DateInsert = Trim$(rs7355!K7355_DateInsert)
    If IsdbNull(rs7355!K7355_DateUpdate) = False Then D7355.DateUpdate = Trim$(rs7355!K7355_DateUpdate)
    If IsdbNull(rs7355!K7355_InchargeInsert) = False Then D7355.InchargeInsert = Trim$(rs7355!K7355_InchargeInsert)
    If IsdbNull(rs7355!K7355_InchargeUpdate) = False Then D7355.InchargeUpdate = Trim$(rs7355!K7355_InchargeUpdate)
    If IsdbNull(rs7355!K7355_CheckUse) = False Then D7355.CheckUse = Trim$(rs7355!K7355_CheckUse)
    If IsdbNull(rs7355!K7355_DateActive) = False Then D7355.DateActive = Trim$(rs7355!K7355_DateActive)
    If IsdbNull(rs7355!K7355_DateDeactive) = False Then D7355.DateDeactive = Trim$(rs7355!K7355_DateDeactive)
    If IsdbNull(rs7355!K7355_CheckActive) = False Then D7355.CheckActive = Trim$(rs7355!K7355_CheckActive)
    If IsdbNull(rs7355!K7355_Remark) = False Then D7355.Remark = Trim$(rs7355!K7355_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7355_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7355_MOVE(rs7355 As DataRow)
Try

    call D7355_CLEAR()   

    If IsdbNull(rs7355!K7355_ProcessBOMCode) = False Then D7355.ProcessBOMCode = Trim$(rs7355!K7355_ProcessBOMCode)
    If IsdbNull(rs7355!K7355_ProcessBOMName) = False Then D7355.ProcessBOMName = Trim$(rs7355!K7355_ProcessBOMName)
    If IsdbNull(rs7355!K7355_DateInsert) = False Then D7355.DateInsert = Trim$(rs7355!K7355_DateInsert)
    If IsdbNull(rs7355!K7355_DateUpdate) = False Then D7355.DateUpdate = Trim$(rs7355!K7355_DateUpdate)
    If IsdbNull(rs7355!K7355_InchargeInsert) = False Then D7355.InchargeInsert = Trim$(rs7355!K7355_InchargeInsert)
    If IsdbNull(rs7355!K7355_InchargeUpdate) = False Then D7355.InchargeUpdate = Trim$(rs7355!K7355_InchargeUpdate)
    If IsdbNull(rs7355!K7355_CheckUse) = False Then D7355.CheckUse = Trim$(rs7355!K7355_CheckUse)
    If IsdbNull(rs7355!K7355_DateActive) = False Then D7355.DateActive = Trim$(rs7355!K7355_DateActive)
    If IsdbNull(rs7355!K7355_DateDeactive) = False Then D7355.DateDeactive = Trim$(rs7355!K7355_DateDeactive)
    If IsdbNull(rs7355!K7355_CheckActive) = False Then D7355.CheckActive = Trim$(rs7355!K7355_CheckActive)
    If IsdbNull(rs7355!K7355_Remark) = False Then D7355.Remark = Trim$(rs7355!K7355_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7355_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7355_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7355 As T7355_AREA, PROCESSBOMCODE AS String) as Boolean

K7355_MOVE = False

Try
    If READ_PFK7355(PROCESSBOMCODE) = True Then
                z7355 = D7355
		K7355_MOVE = True
		else
	z7355 = nothing
     End If

     If  getColumIndex(spr,"ProcessBOMCode") > -1 then z7355.ProcessBOMCode = getDataM(spr, getColumIndex(spr,"ProcessBOMCode"), xRow)
     If  getColumIndex(spr,"ProcessBOMName") > -1 then z7355.ProcessBOMName = getDataM(spr, getColumIndex(spr,"ProcessBOMName"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7355.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7355.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7355.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7355.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7355.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"DateActive") > -1 then z7355.DateActive = getDataM(spr, getColumIndex(spr,"DateActive"), xRow)
     If  getColumIndex(spr,"DateDeactive") > -1 then z7355.DateDeactive = getDataM(spr, getColumIndex(spr,"DateDeactive"), xRow)
     If  getColumIndex(spr,"CheckActive") > -1 then z7355.CheckActive = getDataM(spr, getColumIndex(spr,"CheckActive"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7355.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7355_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7355_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7355 As T7355_AREA,CheckClear as Boolean,PROCESSBOMCODE AS String) as Boolean

K7355_MOVE = False

Try
    If READ_PFK7355(PROCESSBOMCODE) = True Then
                z7355 = D7355
		K7355_MOVE = True
		else
	If CheckClear  = True then z7355 = nothing
     End If

     If  getColumIndex(spr,"ProcessBOMCode") > -1 then z7355.ProcessBOMCode = getDataM(spr, getColumIndex(spr,"ProcessBOMCode"), xRow)
     If  getColumIndex(spr,"ProcessBOMName") > -1 then z7355.ProcessBOMName = getDataM(spr, getColumIndex(spr,"ProcessBOMName"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7355.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7355.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7355.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7355.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7355.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"DateActive") > -1 then z7355.DateActive = getDataM(spr, getColumIndex(spr,"DateActive"), xRow)
     If  getColumIndex(spr,"DateDeactive") > -1 then z7355.DateDeactive = getDataM(spr, getColumIndex(spr,"DateDeactive"), xRow)
     If  getColumIndex(spr,"CheckActive") > -1 then z7355.CheckActive = getDataM(spr, getColumIndex(spr,"CheckActive"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7355.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7355_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7355_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7355 As T7355_AREA, Job as String, PROCESSBOMCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7355_MOVE = False

Try
    If READ_PFK7355(PROCESSBOMCODE) = True Then
                z7355 = D7355
		K7355_MOVE = True
		else
	z7355 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7355")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PROCESSBOMCODE":z7355.ProcessBOMCode = Children(i).Code
   Case "PROCESSBOMNAME":z7355.ProcessBOMName = Children(i).Code
   Case "DATEINSERT":z7355.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7355.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7355.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7355.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7355.CheckUse = Children(i).Code
   Case "DATEACTIVE":z7355.DateActive = Children(i).Code
   Case "DATEDEACTIVE":z7355.DateDeactive = Children(i).Code
   Case "CHECKACTIVE":z7355.CheckActive = Children(i).Code
   Case "REMARK":z7355.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PROCESSBOMCODE":z7355.ProcessBOMCode = Children(i).Data
   Case "PROCESSBOMNAME":z7355.ProcessBOMName = Children(i).Data
   Case "DATEINSERT":z7355.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7355.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7355.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7355.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7355.CheckUse = Children(i).Data
   Case "DATEACTIVE":z7355.DateActive = Children(i).Data
   Case "DATEDEACTIVE":z7355.DateDeactive = Children(i).Data
   Case "CHECKACTIVE":z7355.CheckActive = Children(i).Data
   Case "REMARK":z7355.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7355_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7355_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7355 As T7355_AREA, Job as String, CheckClear as Boolean, PROCESSBOMCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7355_MOVE = False

Try
    If READ_PFK7355(PROCESSBOMCODE) = True Then
                z7355 = D7355
		K7355_MOVE = True
		else
	If CheckClear  = True then z7355 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7355")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PROCESSBOMCODE":z7355.ProcessBOMCode = Children(i).Code
   Case "PROCESSBOMNAME":z7355.ProcessBOMName = Children(i).Code
   Case "DATEINSERT":z7355.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7355.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7355.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7355.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7355.CheckUse = Children(i).Code
   Case "DATEACTIVE":z7355.DateActive = Children(i).Code
   Case "DATEDEACTIVE":z7355.DateDeactive = Children(i).Code
   Case "CHECKACTIVE":z7355.CheckActive = Children(i).Code
   Case "REMARK":z7355.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PROCESSBOMCODE":z7355.ProcessBOMCode = Children(i).Data
   Case "PROCESSBOMNAME":z7355.ProcessBOMName = Children(i).Data
   Case "DATEINSERT":z7355.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7355.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7355.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7355.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7355.CheckUse = Children(i).Data
   Case "DATEACTIVE":z7355.DateActive = Children(i).Data
   Case "DATEDEACTIVE":z7355.DateDeactive = Children(i).Data
   Case "CHECKACTIVE":z7355.CheckActive = Children(i).Data
   Case "REMARK":z7355.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7355_MOVE",vbCritical)
End Try
End Function 
    
End Module 
