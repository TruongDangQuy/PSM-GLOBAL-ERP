'=========================================================================================================================================================
'   TABLE : (PFK7305)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7305

Structure T7305_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	ProcessBOMCode	 AS String	'			nvarchar(6)		*
Public 	ProcessBOMName	 AS String	'			nvarchar(200)
Public 	ShoesCode	 AS String	'			char(6)
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

Public D7305 As T7305_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7305(PROCESSBOMCODE AS String) As Boolean
    READ_PFK7305 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7305 "
    SQL = SQL & " WHERE K7305_ProcessBOMCode		 = '" & ProcessBOMCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7305_CLEAR: GoTo SKIP_READ_PFK7305
                
    Call K7305_MOVE(rd)
    READ_PFK7305 = True

SKIP_READ_PFK7305:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7305",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7305(PROCESSBOMCODE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7305 "
    SQL = SQL & " WHERE K7305_ProcessBOMCode		 = '" & ProcessBOMCode & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7305",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7305(z7305 As T7305_AREA) As Boolean
    WRITE_PFK7305 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7305)
 
    SQL = " INSERT INTO PFK7305 "
    SQL = SQL & " ( "
    SQL = SQL & " K7305_ProcessBOMCode," 
    SQL = SQL & " K7305_ProcessBOMName," 
    SQL = SQL & " K7305_ShoesCode," 
    SQL = SQL & " K7305_DateInsert," 
    SQL = SQL & " K7305_DateUpdate," 
    SQL = SQL & " K7305_InchargeInsert," 
    SQL = SQL & " K7305_InchargeUpdate," 
    SQL = SQL & " K7305_CheckUse," 
    SQL = SQL & " K7305_DateActive," 
    SQL = SQL & " K7305_DateDeactive," 
    SQL = SQL & " K7305_CheckActive," 
    SQL = SQL & " K7305_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7305.ProcessBOMCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7305.ProcessBOMName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7305.ShoesCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7305.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7305.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7305.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7305.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7305.CheckUse) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7305.DateActive) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7305.DateDeactive) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7305.CheckActive) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7305.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7305 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7305",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7305(z7305 As T7305_AREA) As Boolean
    REWRITE_PFK7305 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7305)
   
    SQL = " UPDATE PFK7305 SET "
    SQL = SQL & "    K7305_ProcessBOMName      = N'" & FormatSQL(z7305.ProcessBOMName) & "', " 
    SQL = SQL & "    K7305_ShoesCode      = N'" & FormatSQL(z7305.ShoesCode) & "', " 
    SQL = SQL & "    K7305_DateInsert      = N'" & FormatSQL(z7305.DateInsert) & "', " 
    SQL = SQL & "    K7305_DateUpdate      = N'" & FormatSQL(z7305.DateUpdate) & "', " 
    SQL = SQL & "    K7305_InchargeInsert      = N'" & FormatSQL(z7305.InchargeInsert) & "', " 
    SQL = SQL & "    K7305_InchargeUpdate      = N'" & FormatSQL(z7305.InchargeUpdate) & "', " 
    SQL = SQL & "    K7305_CheckUse      = N'" & FormatSQL(z7305.CheckUse) & "', " 
    SQL = SQL & "    K7305_DateActive      = N'" & FormatSQL(z7305.DateActive) & "', " 
    SQL = SQL & "    K7305_DateDeactive      = N'" & FormatSQL(z7305.DateDeactive) & "', " 
    SQL = SQL & "    K7305_CheckActive      = N'" & FormatSQL(z7305.CheckActive) & "', " 
    SQL = SQL & "    K7305_Remark      = N'" & FormatSQL(z7305.Remark) & "'  " 
    SQL = SQL & " WHERE K7305_ProcessBOMCode		 = '" & z7305.ProcessBOMCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7305 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7305",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7305(z7305 As T7305_AREA) As Boolean
    DELETE_PFK7305 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7305 "
    SQL = SQL & " WHERE K7305_ProcessBOMCode		 = '" & z7305.ProcessBOMCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7305 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7305",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7305_CLEAR()
Try
    
   D7305.ProcessBOMCode = ""
   D7305.ProcessBOMName = ""
   D7305.ShoesCode = ""
   D7305.DateInsert = ""
   D7305.DateUpdate = ""
   D7305.InchargeInsert = ""
   D7305.InchargeUpdate = ""
   D7305.CheckUse = ""
   D7305.DateActive = ""
   D7305.DateDeactive = ""
   D7305.CheckActive = ""
   D7305.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7305_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7305 As T7305_AREA)
Try
    
    x7305.ProcessBOMCode = trim$(  x7305.ProcessBOMCode)
    x7305.ProcessBOMName = trim$(  x7305.ProcessBOMName)
    x7305.ShoesCode = trim$(  x7305.ShoesCode)
    x7305.DateInsert = trim$(  x7305.DateInsert)
    x7305.DateUpdate = trim$(  x7305.DateUpdate)
    x7305.InchargeInsert = trim$(  x7305.InchargeInsert)
    x7305.InchargeUpdate = trim$(  x7305.InchargeUpdate)
    x7305.CheckUse = trim$(  x7305.CheckUse)
    x7305.DateActive = trim$(  x7305.DateActive)
    x7305.DateDeactive = trim$(  x7305.DateDeactive)
    x7305.CheckActive = trim$(  x7305.CheckActive)
    x7305.Remark = trim$(  x7305.Remark)
     
    If trim$( x7305.ProcessBOMCode ) = "" Then x7305.ProcessBOMCode = Space(1) 
    If trim$( x7305.ProcessBOMName ) = "" Then x7305.ProcessBOMName = Space(1) 
    If trim$( x7305.ShoesCode ) = "" Then x7305.ShoesCode = Space(1) 
    If trim$( x7305.DateInsert ) = "" Then x7305.DateInsert = Space(1) 
    If trim$( x7305.DateUpdate ) = "" Then x7305.DateUpdate = Space(1) 
    If trim$( x7305.InchargeInsert ) = "" Then x7305.InchargeInsert = Space(1) 
    If trim$( x7305.InchargeUpdate ) = "" Then x7305.InchargeUpdate = Space(1) 
    If trim$( x7305.CheckUse ) = "" Then x7305.CheckUse = Space(1) 
    If trim$( x7305.DateActive ) = "" Then x7305.DateActive = Space(1) 
    If trim$( x7305.DateDeactive ) = "" Then x7305.DateDeactive = Space(1) 
    If trim$( x7305.CheckActive ) = "" Then x7305.CheckActive = Space(1) 
    If trim$( x7305.Remark ) = "" Then x7305.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7305_MOVE(rs7305 As SqlClient.SqlDataReader)
Try

    call D7305_CLEAR()   

    If IsdbNull(rs7305!K7305_ProcessBOMCode) = False Then D7305.ProcessBOMCode = Trim$(rs7305!K7305_ProcessBOMCode)
    If IsdbNull(rs7305!K7305_ProcessBOMName) = False Then D7305.ProcessBOMName = Trim$(rs7305!K7305_ProcessBOMName)
    If IsdbNull(rs7305!K7305_ShoesCode) = False Then D7305.ShoesCode = Trim$(rs7305!K7305_ShoesCode)
    If IsdbNull(rs7305!K7305_DateInsert) = False Then D7305.DateInsert = Trim$(rs7305!K7305_DateInsert)
    If IsdbNull(rs7305!K7305_DateUpdate) = False Then D7305.DateUpdate = Trim$(rs7305!K7305_DateUpdate)
    If IsdbNull(rs7305!K7305_InchargeInsert) = False Then D7305.InchargeInsert = Trim$(rs7305!K7305_InchargeInsert)
    If IsdbNull(rs7305!K7305_InchargeUpdate) = False Then D7305.InchargeUpdate = Trim$(rs7305!K7305_InchargeUpdate)
    If IsdbNull(rs7305!K7305_CheckUse) = False Then D7305.CheckUse = Trim$(rs7305!K7305_CheckUse)
    If IsdbNull(rs7305!K7305_DateActive) = False Then D7305.DateActive = Trim$(rs7305!K7305_DateActive)
    If IsdbNull(rs7305!K7305_DateDeactive) = False Then D7305.DateDeactive = Trim$(rs7305!K7305_DateDeactive)
    If IsdbNull(rs7305!K7305_CheckActive) = False Then D7305.CheckActive = Trim$(rs7305!K7305_CheckActive)
    If IsdbNull(rs7305!K7305_Remark) = False Then D7305.Remark = Trim$(rs7305!K7305_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7305_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7305_MOVE(rs7305 As DataRow)
Try

    call D7305_CLEAR()   

    If IsdbNull(rs7305!K7305_ProcessBOMCode) = False Then D7305.ProcessBOMCode = Trim$(rs7305!K7305_ProcessBOMCode)
    If IsdbNull(rs7305!K7305_ProcessBOMName) = False Then D7305.ProcessBOMName = Trim$(rs7305!K7305_ProcessBOMName)
    If IsdbNull(rs7305!K7305_ShoesCode) = False Then D7305.ShoesCode = Trim$(rs7305!K7305_ShoesCode)
    If IsdbNull(rs7305!K7305_DateInsert) = False Then D7305.DateInsert = Trim$(rs7305!K7305_DateInsert)
    If IsdbNull(rs7305!K7305_DateUpdate) = False Then D7305.DateUpdate = Trim$(rs7305!K7305_DateUpdate)
    If IsdbNull(rs7305!K7305_InchargeInsert) = False Then D7305.InchargeInsert = Trim$(rs7305!K7305_InchargeInsert)
    If IsdbNull(rs7305!K7305_InchargeUpdate) = False Then D7305.InchargeUpdate = Trim$(rs7305!K7305_InchargeUpdate)
    If IsdbNull(rs7305!K7305_CheckUse) = False Then D7305.CheckUse = Trim$(rs7305!K7305_CheckUse)
    If IsdbNull(rs7305!K7305_DateActive) = False Then D7305.DateActive = Trim$(rs7305!K7305_DateActive)
    If IsdbNull(rs7305!K7305_DateDeactive) = False Then D7305.DateDeactive = Trim$(rs7305!K7305_DateDeactive)
    If IsdbNull(rs7305!K7305_CheckActive) = False Then D7305.CheckActive = Trim$(rs7305!K7305_CheckActive)
    If IsdbNull(rs7305!K7305_Remark) = False Then D7305.Remark = Trim$(rs7305!K7305_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7305_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7305_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7305 As T7305_AREA, PROCESSBOMCODE AS String) as Boolean

K7305_MOVE = False

Try
    If READ_PFK7305(PROCESSBOMCODE) = True Then
                z7305 = D7305
		K7305_MOVE = True
		else
	z7305 = nothing
     End If

     If  getColumIndex(spr,"ProcessBOMCode") > -1 then z7305.ProcessBOMCode = getDataM(spr, getColumIndex(spr,"ProcessBOMCode"), xRow)
     If  getColumIndex(spr,"ProcessBOMName") > -1 then z7305.ProcessBOMName = getDataM(spr, getColumIndex(spr,"ProcessBOMName"), xRow)
     If  getColumIndex(spr,"ShoesCode") > -1 then z7305.ShoesCode = getDataM(spr, getColumIndex(spr,"ShoesCode"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7305.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7305.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7305.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7305.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7305.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"DateActive") > -1 then z7305.DateActive = getDataM(spr, getColumIndex(spr,"DateActive"), xRow)
     If  getColumIndex(spr,"DateDeactive") > -1 then z7305.DateDeactive = getDataM(spr, getColumIndex(spr,"DateDeactive"), xRow)
     If  getColumIndex(spr,"CheckActive") > -1 then z7305.CheckActive = getDataM(spr, getColumIndex(spr,"CheckActive"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7305.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7305_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7305_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7305 As T7305_AREA,CheckClear as Boolean,PROCESSBOMCODE AS String) as Boolean

K7305_MOVE = False

Try
    If READ_PFK7305(PROCESSBOMCODE) = True Then
                z7305 = D7305
		K7305_MOVE = True
		else
	If CheckClear  = True then z7305 = nothing
     End If

     If  getColumIndex(spr,"ProcessBOMCode") > -1 then z7305.ProcessBOMCode = getDataM(spr, getColumIndex(spr,"ProcessBOMCode"), xRow)
     If  getColumIndex(spr,"ProcessBOMName") > -1 then z7305.ProcessBOMName = getDataM(spr, getColumIndex(spr,"ProcessBOMName"), xRow)
     If  getColumIndex(spr,"ShoesCode") > -1 then z7305.ShoesCode = getDataM(spr, getColumIndex(spr,"ShoesCode"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7305.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7305.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7305.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7305.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7305.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"DateActive") > -1 then z7305.DateActive = getDataM(spr, getColumIndex(spr,"DateActive"), xRow)
     If  getColumIndex(spr,"DateDeactive") > -1 then z7305.DateDeactive = getDataM(spr, getColumIndex(spr,"DateDeactive"), xRow)
     If  getColumIndex(spr,"CheckActive") > -1 then z7305.CheckActive = getDataM(spr, getColumIndex(spr,"CheckActive"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7305.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7305_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7305_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7305 As T7305_AREA, Job as String, PROCESSBOMCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7305_MOVE = False

Try
    If READ_PFK7305(PROCESSBOMCODE) = True Then
                z7305 = D7305
		K7305_MOVE = True
		else
	z7305 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7305")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PROCESSBOMCODE":z7305.ProcessBOMCode = Children(i).Code
   Case "PROCESSBOMNAME":z7305.ProcessBOMName = Children(i).Code
   Case "SHOESCODE":z7305.ShoesCode = Children(i).Code
   Case "DATEINSERT":z7305.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7305.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7305.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7305.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7305.CheckUse = Children(i).Code
   Case "DATEACTIVE":z7305.DateActive = Children(i).Code
   Case "DATEDEACTIVE":z7305.DateDeactive = Children(i).Code
   Case "CHECKACTIVE":z7305.CheckActive = Children(i).Code
   Case "REMARK":z7305.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PROCESSBOMCODE":z7305.ProcessBOMCode = Children(i).Data
   Case "PROCESSBOMNAME":z7305.ProcessBOMName = Children(i).Data
   Case "SHOESCODE":z7305.ShoesCode = Children(i).Data
   Case "DATEINSERT":z7305.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7305.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7305.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7305.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7305.CheckUse = Children(i).Data
   Case "DATEACTIVE":z7305.DateActive = Children(i).Data
   Case "DATEDEACTIVE":z7305.DateDeactive = Children(i).Data
   Case "CHECKACTIVE":z7305.CheckActive = Children(i).Data
   Case "REMARK":z7305.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7305_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7305_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7305 As T7305_AREA, Job as String, CheckClear as Boolean, PROCESSBOMCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7305_MOVE = False

Try
    If READ_PFK7305(PROCESSBOMCODE) = True Then
                z7305 = D7305
		K7305_MOVE = True
		else
	If CheckClear  = True then z7305 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7305")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PROCESSBOMCODE":z7305.ProcessBOMCode = Children(i).Code
   Case "PROCESSBOMNAME":z7305.ProcessBOMName = Children(i).Code
   Case "SHOESCODE":z7305.ShoesCode = Children(i).Code
   Case "DATEINSERT":z7305.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7305.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7305.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7305.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7305.CheckUse = Children(i).Code
   Case "DATEACTIVE":z7305.DateActive = Children(i).Code
   Case "DATEDEACTIVE":z7305.DateDeactive = Children(i).Code
   Case "CHECKACTIVE":z7305.CheckActive = Children(i).Code
   Case "REMARK":z7305.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PROCESSBOMCODE":z7305.ProcessBOMCode = Children(i).Data
   Case "PROCESSBOMNAME":z7305.ProcessBOMName = Children(i).Data
   Case "SHOESCODE":z7305.ShoesCode = Children(i).Data
   Case "DATEINSERT":z7305.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7305.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7305.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7305.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7305.CheckUse = Children(i).Data
   Case "DATEACTIVE":z7305.DateActive = Children(i).Data
   Case "DATEDEACTIVE":z7305.DateDeactive = Children(i).Data
   Case "CHECKACTIVE":z7305.CheckActive = Children(i).Data
   Case "REMARK":z7305.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7305_MOVE",vbCritical)
End Try
End Function 
    
End Module 
