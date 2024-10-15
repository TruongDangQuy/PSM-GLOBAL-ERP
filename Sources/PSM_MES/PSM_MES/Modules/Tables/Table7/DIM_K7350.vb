'=========================================================================================================================================================
'   TABLE : (PFK7350)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7350

Structure T7350_AREA
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

Public D7350 As T7350_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7350(PROCESSBOMCODE AS String) As Boolean
    READ_PFK7350 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7350 "
    SQL = SQL & " WHERE K7350_ProcessBOMCode		 = '" & ProcessBOMCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7350_CLEAR: GoTo SKIP_READ_PFK7350
                
    Call K7350_MOVE(rd)
    READ_PFK7350 = True

SKIP_READ_PFK7350:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7350",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7350(PROCESSBOMCODE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7350 "
    SQL = SQL & " WHERE K7350_ProcessBOMCode		 = '" & ProcessBOMCode & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7350",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7350(z7350 As T7350_AREA) As Boolean
    WRITE_PFK7350 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7350)
 
    SQL = " INSERT INTO PFK7350 "
    SQL = SQL & " ( "
    SQL = SQL & " K7350_ProcessBOMCode," 
    SQL = SQL & " K7350_ProcessBOMName," 
    SQL = SQL & " K7350_ShoesCode," 
    SQL = SQL & " K7350_DateInsert," 
    SQL = SQL & " K7350_DateUpdate," 
    SQL = SQL & " K7350_InchargeInsert," 
    SQL = SQL & " K7350_InchargeUpdate," 
    SQL = SQL & " K7350_CheckUse," 
    SQL = SQL & " K7350_DateActive," 
    SQL = SQL & " K7350_DateDeactive," 
    SQL = SQL & " K7350_CheckActive," 
    SQL = SQL & " K7350_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7350.ProcessBOMCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7350.ProcessBOMName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7350.ShoesCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7350.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7350.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7350.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7350.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7350.CheckUse) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7350.DateActive) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7350.DateDeactive) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7350.CheckActive) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7350.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7350 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7350",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7350(z7350 As T7350_AREA) As Boolean
    REWRITE_PFK7350 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7350)
   
    SQL = " UPDATE PFK7350 SET "
    SQL = SQL & "    K7350_ProcessBOMName      = N'" & FormatSQL(z7350.ProcessBOMName) & "', " 
    SQL = SQL & "    K7350_ShoesCode      = N'" & FormatSQL(z7350.ShoesCode) & "', " 
    SQL = SQL & "    K7350_DateInsert      = N'" & FormatSQL(z7350.DateInsert) & "', " 
    SQL = SQL & "    K7350_DateUpdate      = N'" & FormatSQL(z7350.DateUpdate) & "', " 
    SQL = SQL & "    K7350_InchargeInsert      = N'" & FormatSQL(z7350.InchargeInsert) & "', " 
    SQL = SQL & "    K7350_InchargeUpdate      = N'" & FormatSQL(z7350.InchargeUpdate) & "', " 
    SQL = SQL & "    K7350_CheckUse      = N'" & FormatSQL(z7350.CheckUse) & "', " 
    SQL = SQL & "    K7350_DateActive      = N'" & FormatSQL(z7350.DateActive) & "', " 
    SQL = SQL & "    K7350_DateDeactive      = N'" & FormatSQL(z7350.DateDeactive) & "', " 
    SQL = SQL & "    K7350_CheckActive      = N'" & FormatSQL(z7350.CheckActive) & "', " 
    SQL = SQL & "    K7350_Remark      = N'" & FormatSQL(z7350.Remark) & "'  " 
    SQL = SQL & " WHERE K7350_ProcessBOMCode		 = '" & z7350.ProcessBOMCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7350 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7350",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7350(z7350 As T7350_AREA) As Boolean
    DELETE_PFK7350 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7350 "
    SQL = SQL & " WHERE K7350_ProcessBOMCode		 = '" & z7350.ProcessBOMCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7350 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7350",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7350_CLEAR()
Try
    
   D7350.ProcessBOMCode = ""
   D7350.ProcessBOMName = ""
   D7350.ShoesCode = ""
   D7350.DateInsert = ""
   D7350.DateUpdate = ""
   D7350.InchargeInsert = ""
   D7350.InchargeUpdate = ""
   D7350.CheckUse = ""
   D7350.DateActive = ""
   D7350.DateDeactive = ""
   D7350.CheckActive = ""
   D7350.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7350_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7350 As T7350_AREA)
Try
    
    x7350.ProcessBOMCode = trim$(  x7350.ProcessBOMCode)
    x7350.ProcessBOMName = trim$(  x7350.ProcessBOMName)
    x7350.ShoesCode = trim$(  x7350.ShoesCode)
    x7350.DateInsert = trim$(  x7350.DateInsert)
    x7350.DateUpdate = trim$(  x7350.DateUpdate)
    x7350.InchargeInsert = trim$(  x7350.InchargeInsert)
    x7350.InchargeUpdate = trim$(  x7350.InchargeUpdate)
    x7350.CheckUse = trim$(  x7350.CheckUse)
    x7350.DateActive = trim$(  x7350.DateActive)
    x7350.DateDeactive = trim$(  x7350.DateDeactive)
    x7350.CheckActive = trim$(  x7350.CheckActive)
    x7350.Remark = trim$(  x7350.Remark)
     
    If trim$( x7350.ProcessBOMCode ) = "" Then x7350.ProcessBOMCode = Space(1) 
    If trim$( x7350.ProcessBOMName ) = "" Then x7350.ProcessBOMName = Space(1) 
    If trim$( x7350.ShoesCode ) = "" Then x7350.ShoesCode = Space(1) 
    If trim$( x7350.DateInsert ) = "" Then x7350.DateInsert = Space(1) 
    If trim$( x7350.DateUpdate ) = "" Then x7350.DateUpdate = Space(1) 
    If trim$( x7350.InchargeInsert ) = "" Then x7350.InchargeInsert = Space(1) 
    If trim$( x7350.InchargeUpdate ) = "" Then x7350.InchargeUpdate = Space(1) 
    If trim$( x7350.CheckUse ) = "" Then x7350.CheckUse = Space(1) 
    If trim$( x7350.DateActive ) = "" Then x7350.DateActive = Space(1) 
    If trim$( x7350.DateDeactive ) = "" Then x7350.DateDeactive = Space(1) 
    If trim$( x7350.CheckActive ) = "" Then x7350.CheckActive = Space(1) 
    If trim$( x7350.Remark ) = "" Then x7350.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7350_MOVE(rs7350 As SqlClient.SqlDataReader)
Try

    call D7350_CLEAR()   

    If IsdbNull(rs7350!K7350_ProcessBOMCode) = False Then D7350.ProcessBOMCode = Trim$(rs7350!K7350_ProcessBOMCode)
    If IsdbNull(rs7350!K7350_ProcessBOMName) = False Then D7350.ProcessBOMName = Trim$(rs7350!K7350_ProcessBOMName)
    If IsdbNull(rs7350!K7350_ShoesCode) = False Then D7350.ShoesCode = Trim$(rs7350!K7350_ShoesCode)
    If IsdbNull(rs7350!K7350_DateInsert) = False Then D7350.DateInsert = Trim$(rs7350!K7350_DateInsert)
    If IsdbNull(rs7350!K7350_DateUpdate) = False Then D7350.DateUpdate = Trim$(rs7350!K7350_DateUpdate)
    If IsdbNull(rs7350!K7350_InchargeInsert) = False Then D7350.InchargeInsert = Trim$(rs7350!K7350_InchargeInsert)
    If IsdbNull(rs7350!K7350_InchargeUpdate) = False Then D7350.InchargeUpdate = Trim$(rs7350!K7350_InchargeUpdate)
    If IsdbNull(rs7350!K7350_CheckUse) = False Then D7350.CheckUse = Trim$(rs7350!K7350_CheckUse)
    If IsdbNull(rs7350!K7350_DateActive) = False Then D7350.DateActive = Trim$(rs7350!K7350_DateActive)
    If IsdbNull(rs7350!K7350_DateDeactive) = False Then D7350.DateDeactive = Trim$(rs7350!K7350_DateDeactive)
    If IsdbNull(rs7350!K7350_CheckActive) = False Then D7350.CheckActive = Trim$(rs7350!K7350_CheckActive)
    If IsdbNull(rs7350!K7350_Remark) = False Then D7350.Remark = Trim$(rs7350!K7350_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7350_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7350_MOVE(rs7350 As DataRow)
Try

    call D7350_CLEAR()   

    If IsdbNull(rs7350!K7350_ProcessBOMCode) = False Then D7350.ProcessBOMCode = Trim$(rs7350!K7350_ProcessBOMCode)
    If IsdbNull(rs7350!K7350_ProcessBOMName) = False Then D7350.ProcessBOMName = Trim$(rs7350!K7350_ProcessBOMName)
    If IsdbNull(rs7350!K7350_ShoesCode) = False Then D7350.ShoesCode = Trim$(rs7350!K7350_ShoesCode)
    If IsdbNull(rs7350!K7350_DateInsert) = False Then D7350.DateInsert = Trim$(rs7350!K7350_DateInsert)
    If IsdbNull(rs7350!K7350_DateUpdate) = False Then D7350.DateUpdate = Trim$(rs7350!K7350_DateUpdate)
    If IsdbNull(rs7350!K7350_InchargeInsert) = False Then D7350.InchargeInsert = Trim$(rs7350!K7350_InchargeInsert)
    If IsdbNull(rs7350!K7350_InchargeUpdate) = False Then D7350.InchargeUpdate = Trim$(rs7350!K7350_InchargeUpdate)
    If IsdbNull(rs7350!K7350_CheckUse) = False Then D7350.CheckUse = Trim$(rs7350!K7350_CheckUse)
    If IsdbNull(rs7350!K7350_DateActive) = False Then D7350.DateActive = Trim$(rs7350!K7350_DateActive)
    If IsdbNull(rs7350!K7350_DateDeactive) = False Then D7350.DateDeactive = Trim$(rs7350!K7350_DateDeactive)
    If IsdbNull(rs7350!K7350_CheckActive) = False Then D7350.CheckActive = Trim$(rs7350!K7350_CheckActive)
    If IsdbNull(rs7350!K7350_Remark) = False Then D7350.Remark = Trim$(rs7350!K7350_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7350_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7350_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7350 As T7350_AREA, PROCESSBOMCODE AS String) as Boolean

K7350_MOVE = False

Try
    If READ_PFK7350(PROCESSBOMCODE) = True Then
                z7350 = D7350
		K7350_MOVE = True
		else
	z7350 = nothing
     End If

     If  getColumIndex(spr,"ProcessBOMCode") > -1 then z7350.ProcessBOMCode = getDataM(spr, getColumIndex(spr,"ProcessBOMCode"), xRow)
     If  getColumIndex(spr,"ProcessBOMName") > -1 then z7350.ProcessBOMName = getDataM(spr, getColumIndex(spr,"ProcessBOMName"), xRow)
     If  getColumIndex(spr,"ShoesCode") > -1 then z7350.ShoesCode = getDataM(spr, getColumIndex(spr,"ShoesCode"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7350.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7350.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7350.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7350.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7350.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"DateActive") > -1 then z7350.DateActive = getDataM(spr, getColumIndex(spr,"DateActive"), xRow)
     If  getColumIndex(spr,"DateDeactive") > -1 then z7350.DateDeactive = getDataM(spr, getColumIndex(spr,"DateDeactive"), xRow)
     If  getColumIndex(spr,"CheckActive") > -1 then z7350.CheckActive = getDataM(spr, getColumIndex(spr,"CheckActive"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7350.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7350_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7350_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7350 As T7350_AREA,CheckClear as Boolean,PROCESSBOMCODE AS String) as Boolean

K7350_MOVE = False

Try
    If READ_PFK7350(PROCESSBOMCODE) = True Then
                z7350 = D7350
		K7350_MOVE = True
		else
	If CheckClear  = True then z7350 = nothing
     End If

     If  getColumIndex(spr,"ProcessBOMCode") > -1 then z7350.ProcessBOMCode = getDataM(spr, getColumIndex(spr,"ProcessBOMCode"), xRow)
     If  getColumIndex(spr,"ProcessBOMName") > -1 then z7350.ProcessBOMName = getDataM(spr, getColumIndex(spr,"ProcessBOMName"), xRow)
     If  getColumIndex(spr,"ShoesCode") > -1 then z7350.ShoesCode = getDataM(spr, getColumIndex(spr,"ShoesCode"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7350.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7350.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7350.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7350.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7350.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"DateActive") > -1 then z7350.DateActive = getDataM(spr, getColumIndex(spr,"DateActive"), xRow)
     If  getColumIndex(spr,"DateDeactive") > -1 then z7350.DateDeactive = getDataM(spr, getColumIndex(spr,"DateDeactive"), xRow)
     If  getColumIndex(spr,"CheckActive") > -1 then z7350.CheckActive = getDataM(spr, getColumIndex(spr,"CheckActive"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7350.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7350_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7350_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7350 As T7350_AREA, Job as String, PROCESSBOMCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7350_MOVE = False

Try
    If READ_PFK7350(PROCESSBOMCODE) = True Then
                z7350 = D7350
		K7350_MOVE = True
		else
	z7350 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7350")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PROCESSBOMCODE":z7350.ProcessBOMCode = Children(i).Code
   Case "PROCESSBOMNAME":z7350.ProcessBOMName = Children(i).Code
   Case "SHOESCODE":z7350.ShoesCode = Children(i).Code
   Case "DATEINSERT":z7350.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7350.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7350.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7350.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7350.CheckUse = Children(i).Code
   Case "DATEACTIVE":z7350.DateActive = Children(i).Code
   Case "DATEDEACTIVE":z7350.DateDeactive = Children(i).Code
   Case "CHECKACTIVE":z7350.CheckActive = Children(i).Code
   Case "REMARK":z7350.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PROCESSBOMCODE":z7350.ProcessBOMCode = Children(i).Data
   Case "PROCESSBOMNAME":z7350.ProcessBOMName = Children(i).Data
   Case "SHOESCODE":z7350.ShoesCode = Children(i).Data
   Case "DATEINSERT":z7350.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7350.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7350.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7350.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7350.CheckUse = Children(i).Data
   Case "DATEACTIVE":z7350.DateActive = Children(i).Data
   Case "DATEDEACTIVE":z7350.DateDeactive = Children(i).Data
   Case "CHECKACTIVE":z7350.CheckActive = Children(i).Data
   Case "REMARK":z7350.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7350_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7350_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7350 As T7350_AREA, Job as String, CheckClear as Boolean, PROCESSBOMCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7350_MOVE = False

Try
    If READ_PFK7350(PROCESSBOMCODE) = True Then
                z7350 = D7350
		K7350_MOVE = True
		else
	If CheckClear  = True then z7350 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7350")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PROCESSBOMCODE":z7350.ProcessBOMCode = Children(i).Code
   Case "PROCESSBOMNAME":z7350.ProcessBOMName = Children(i).Code
   Case "SHOESCODE":z7350.ShoesCode = Children(i).Code
   Case "DATEINSERT":z7350.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7350.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7350.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7350.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7350.CheckUse = Children(i).Code
   Case "DATEACTIVE":z7350.DateActive = Children(i).Code
   Case "DATEDEACTIVE":z7350.DateDeactive = Children(i).Code
   Case "CHECKACTIVE":z7350.CheckActive = Children(i).Code
   Case "REMARK":z7350.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PROCESSBOMCODE":z7350.ProcessBOMCode = Children(i).Data
   Case "PROCESSBOMNAME":z7350.ProcessBOMName = Children(i).Data
   Case "SHOESCODE":z7350.ShoesCode = Children(i).Data
   Case "DATEINSERT":z7350.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7350.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7350.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7350.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7350.CheckUse = Children(i).Data
   Case "DATEACTIVE":z7350.DateActive = Children(i).Data
   Case "DATEDEACTIVE":z7350.DateDeactive = Children(i).Data
   Case "CHECKACTIVE":z7350.CheckActive = Children(i).Data
   Case "REMARK":z7350.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7350_MOVE",vbCritical)
End Try
End Function 
    
End Module 
