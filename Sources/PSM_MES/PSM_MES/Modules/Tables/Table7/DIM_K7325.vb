'=========================================================================================================================================================
'   TABLE : (PFK7325)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7325

Structure T7325_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	ProcessBOMCode	 AS String	'			nvarchar(6)		*
Public 	ProcessBOMName	 AS String	'			nvarchar(50)
Public 	seMainProcess	 AS String	'			char(3)
Public 	cdMainProcess	 AS String	'			char(3)
Public 	ShoesCode	 AS String	'			char(6)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(6)
Public 	InchargeUpdate	 AS String	'			char(6)
Public 	CheckUse	 AS String	'			char(1)
Public 	DateActive	 AS String	'			char(8)
Public 	DateDeactive	 AS String	'			char(8)
Public 	CheckActive	 AS String	'			char(1)
Public 	Remark	 AS String	'			nvarchar(100)
'=========================================================================================================================================================
End structure

Public D7325 As T7325_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7325(PROCESSBOMCODE AS String) As Boolean
    READ_PFK7325 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7325 "
    SQL = SQL & " WHERE K7325_ProcessBOMCode		 = '" & ProcessBOMCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7325_CLEAR: GoTo SKIP_READ_PFK7325
                
    Call K7325_MOVE(rd)
    READ_PFK7325 = True

SKIP_READ_PFK7325:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7325",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7325(PROCESSBOMCODE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7325 "
    SQL = SQL & " WHERE K7325_ProcessBOMCode		 = '" & ProcessBOMCode & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7325",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7325(z7325 As T7325_AREA) As Boolean
    WRITE_PFK7325 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7325)
 
    SQL = " INSERT INTO PFK7325 "
    SQL = SQL & " ( "
    SQL = SQL & " K7325_ProcessBOMCode," 
    SQL = SQL & " K7325_ProcessBOMName," 
    SQL = SQL & " K7325_seMainProcess," 
    SQL = SQL & " K7325_cdMainProcess," 
    SQL = SQL & " K7325_ShoesCode," 
    SQL = SQL & " K7325_DateInsert," 
    SQL = SQL & " K7325_DateUpdate," 
    SQL = SQL & " K7325_InchargeInsert," 
    SQL = SQL & " K7325_InchargeUpdate," 
    SQL = SQL & " K7325_CheckUse," 
    SQL = SQL & " K7325_DateActive," 
    SQL = SQL & " K7325_DateDeactive," 
    SQL = SQL & " K7325_CheckActive," 
    SQL = SQL & " K7325_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7325.ProcessBOMCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7325.ProcessBOMName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7325.seMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7325.cdMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7325.ShoesCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7325.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7325.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7325.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7325.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7325.CheckUse) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7325.DateActive) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7325.DateDeactive) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7325.CheckActive) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7325.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7325 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7325",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7325(z7325 As T7325_AREA) As Boolean
    REWRITE_PFK7325 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7325)
   
    SQL = " UPDATE PFK7325 SET "
    SQL = SQL & "    K7325_ProcessBOMName      = N'" & FormatSQL(z7325.ProcessBOMName) & "', " 
    SQL = SQL & "    K7325_seMainProcess      = N'" & FormatSQL(z7325.seMainProcess) & "', " 
    SQL = SQL & "    K7325_cdMainProcess      = N'" & FormatSQL(z7325.cdMainProcess) & "', " 
    SQL = SQL & "    K7325_ShoesCode      = N'" & FormatSQL(z7325.ShoesCode) & "', " 
    SQL = SQL & "    K7325_DateInsert      = N'" & FormatSQL(z7325.DateInsert) & "', " 
    SQL = SQL & "    K7325_DateUpdate      = N'" & FormatSQL(z7325.DateUpdate) & "', " 
    SQL = SQL & "    K7325_InchargeInsert      = N'" & FormatSQL(z7325.InchargeInsert) & "', " 
    SQL = SQL & "    K7325_InchargeUpdate      = N'" & FormatSQL(z7325.InchargeUpdate) & "', " 
    SQL = SQL & "    K7325_CheckUse      = N'" & FormatSQL(z7325.CheckUse) & "', " 
    SQL = SQL & "    K7325_DateActive      = N'" & FormatSQL(z7325.DateActive) & "', " 
    SQL = SQL & "    K7325_DateDeactive      = N'" & FormatSQL(z7325.DateDeactive) & "', " 
    SQL = SQL & "    K7325_CheckActive      = N'" & FormatSQL(z7325.CheckActive) & "', " 
    SQL = SQL & "    K7325_Remark      = N'" & FormatSQL(z7325.Remark) & "'  " 
    SQL = SQL & " WHERE K7325_ProcessBOMCode		 = '" & z7325.ProcessBOMCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7325 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7325",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7325(z7325 As T7325_AREA) As Boolean
    DELETE_PFK7325 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7325 "
    SQL = SQL & " WHERE K7325_ProcessBOMCode		 = '" & z7325.ProcessBOMCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7325 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7325",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7325_CLEAR()
Try
    
   D7325.ProcessBOMCode = ""
   D7325.ProcessBOMName = ""
   D7325.seMainProcess = ""
   D7325.cdMainProcess = ""
   D7325.ShoesCode = ""
   D7325.DateInsert = ""
   D7325.DateUpdate = ""
   D7325.InchargeInsert = ""
   D7325.InchargeUpdate = ""
   D7325.CheckUse = ""
   D7325.DateActive = ""
   D7325.DateDeactive = ""
   D7325.CheckActive = ""
   D7325.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7325_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7325 As T7325_AREA)
Try
    
    x7325.ProcessBOMCode = trim$(  x7325.ProcessBOMCode)
    x7325.ProcessBOMName = trim$(  x7325.ProcessBOMName)
    x7325.seMainProcess = trim$(  x7325.seMainProcess)
    x7325.cdMainProcess = trim$(  x7325.cdMainProcess)
    x7325.ShoesCode = trim$(  x7325.ShoesCode)
    x7325.DateInsert = trim$(  x7325.DateInsert)
    x7325.DateUpdate = trim$(  x7325.DateUpdate)
    x7325.InchargeInsert = trim$(  x7325.InchargeInsert)
    x7325.InchargeUpdate = trim$(  x7325.InchargeUpdate)
    x7325.CheckUse = trim$(  x7325.CheckUse)
    x7325.DateActive = trim$(  x7325.DateActive)
    x7325.DateDeactive = trim$(  x7325.DateDeactive)
    x7325.CheckActive = trim$(  x7325.CheckActive)
    x7325.Remark = trim$(  x7325.Remark)
     
    If trim$( x7325.ProcessBOMCode ) = "" Then x7325.ProcessBOMCode = Space(1) 
    If trim$( x7325.ProcessBOMName ) = "" Then x7325.ProcessBOMName = Space(1) 
    If trim$( x7325.seMainProcess ) = "" Then x7325.seMainProcess = Space(1) 
    If trim$( x7325.cdMainProcess ) = "" Then x7325.cdMainProcess = Space(1) 
    If trim$( x7325.ShoesCode ) = "" Then x7325.ShoesCode = Space(1) 
    If trim$( x7325.DateInsert ) = "" Then x7325.DateInsert = Space(1) 
    If trim$( x7325.DateUpdate ) = "" Then x7325.DateUpdate = Space(1) 
    If trim$( x7325.InchargeInsert ) = "" Then x7325.InchargeInsert = Space(1) 
    If trim$( x7325.InchargeUpdate ) = "" Then x7325.InchargeUpdate = Space(1) 
    If trim$( x7325.CheckUse ) = "" Then x7325.CheckUse = Space(1) 
    If trim$( x7325.DateActive ) = "" Then x7325.DateActive = Space(1) 
    If trim$( x7325.DateDeactive ) = "" Then x7325.DateDeactive = Space(1) 
    If trim$( x7325.CheckActive ) = "" Then x7325.CheckActive = Space(1) 
    If trim$( x7325.Remark ) = "" Then x7325.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7325_MOVE(rs7325 As SqlClient.SqlDataReader)
Try

    call D7325_CLEAR()   

    If IsdbNull(rs7325!K7325_ProcessBOMCode) = False Then D7325.ProcessBOMCode = Trim$(rs7325!K7325_ProcessBOMCode)
    If IsdbNull(rs7325!K7325_ProcessBOMName) = False Then D7325.ProcessBOMName = Trim$(rs7325!K7325_ProcessBOMName)
    If IsdbNull(rs7325!K7325_seMainProcess) = False Then D7325.seMainProcess = Trim$(rs7325!K7325_seMainProcess)
    If IsdbNull(rs7325!K7325_cdMainProcess) = False Then D7325.cdMainProcess = Trim$(rs7325!K7325_cdMainProcess)
    If IsdbNull(rs7325!K7325_ShoesCode) = False Then D7325.ShoesCode = Trim$(rs7325!K7325_ShoesCode)
    If IsdbNull(rs7325!K7325_DateInsert) = False Then D7325.DateInsert = Trim$(rs7325!K7325_DateInsert)
    If IsdbNull(rs7325!K7325_DateUpdate) = False Then D7325.DateUpdate = Trim$(rs7325!K7325_DateUpdate)
    If IsdbNull(rs7325!K7325_InchargeInsert) = False Then D7325.InchargeInsert = Trim$(rs7325!K7325_InchargeInsert)
    If IsdbNull(rs7325!K7325_InchargeUpdate) = False Then D7325.InchargeUpdate = Trim$(rs7325!K7325_InchargeUpdate)
    If IsdbNull(rs7325!K7325_CheckUse) = False Then D7325.CheckUse = Trim$(rs7325!K7325_CheckUse)
    If IsdbNull(rs7325!K7325_DateActive) = False Then D7325.DateActive = Trim$(rs7325!K7325_DateActive)
    If IsdbNull(rs7325!K7325_DateDeactive) = False Then D7325.DateDeactive = Trim$(rs7325!K7325_DateDeactive)
    If IsdbNull(rs7325!K7325_CheckActive) = False Then D7325.CheckActive = Trim$(rs7325!K7325_CheckActive)
    If IsdbNull(rs7325!K7325_Remark) = False Then D7325.Remark = Trim$(rs7325!K7325_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7325_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7325_MOVE(rs7325 As DataRow)
Try

    call D7325_CLEAR()   

    If IsdbNull(rs7325!K7325_ProcessBOMCode) = False Then D7325.ProcessBOMCode = Trim$(rs7325!K7325_ProcessBOMCode)
    If IsdbNull(rs7325!K7325_ProcessBOMName) = False Then D7325.ProcessBOMName = Trim$(rs7325!K7325_ProcessBOMName)
    If IsdbNull(rs7325!K7325_seMainProcess) = False Then D7325.seMainProcess = Trim$(rs7325!K7325_seMainProcess)
    If IsdbNull(rs7325!K7325_cdMainProcess) = False Then D7325.cdMainProcess = Trim$(rs7325!K7325_cdMainProcess)
    If IsdbNull(rs7325!K7325_ShoesCode) = False Then D7325.ShoesCode = Trim$(rs7325!K7325_ShoesCode)
    If IsdbNull(rs7325!K7325_DateInsert) = False Then D7325.DateInsert = Trim$(rs7325!K7325_DateInsert)
    If IsdbNull(rs7325!K7325_DateUpdate) = False Then D7325.DateUpdate = Trim$(rs7325!K7325_DateUpdate)
    If IsdbNull(rs7325!K7325_InchargeInsert) = False Then D7325.InchargeInsert = Trim$(rs7325!K7325_InchargeInsert)
    If IsdbNull(rs7325!K7325_InchargeUpdate) = False Then D7325.InchargeUpdate = Trim$(rs7325!K7325_InchargeUpdate)
    If IsdbNull(rs7325!K7325_CheckUse) = False Then D7325.CheckUse = Trim$(rs7325!K7325_CheckUse)
    If IsdbNull(rs7325!K7325_DateActive) = False Then D7325.DateActive = Trim$(rs7325!K7325_DateActive)
    If IsdbNull(rs7325!K7325_DateDeactive) = False Then D7325.DateDeactive = Trim$(rs7325!K7325_DateDeactive)
    If IsdbNull(rs7325!K7325_CheckActive) = False Then D7325.CheckActive = Trim$(rs7325!K7325_CheckActive)
    If IsdbNull(rs7325!K7325_Remark) = False Then D7325.Remark = Trim$(rs7325!K7325_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7325_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7325_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7325 As T7325_AREA, PROCESSBOMCODE AS String) as Boolean

K7325_MOVE = False

Try
    If READ_PFK7325(PROCESSBOMCODE) = True Then
                z7325 = D7325
		K7325_MOVE = True
		else
	z7325 = nothing
     End If

     If  getColumIndex(spr,"ProcessBOMCode") > -1 then z7325.ProcessBOMCode = getDataM(spr, getColumIndex(spr,"ProcessBOMCode"), xRow)
     If  getColumIndex(spr,"ProcessBOMName") > -1 then z7325.ProcessBOMName = getDataM(spr, getColumIndex(spr,"ProcessBOMName"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z7325.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z7325.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"ShoesCode") > -1 then z7325.ShoesCode = getDataM(spr, getColumIndex(spr,"ShoesCode"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7325.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7325.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7325.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7325.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7325.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"DateActive") > -1 then z7325.DateActive = getDataM(spr, getColumIndex(spr,"DateActive"), xRow)
     If  getColumIndex(spr,"DateDeactive") > -1 then z7325.DateDeactive = getDataM(spr, getColumIndex(spr,"DateDeactive"), xRow)
     If  getColumIndex(spr,"CheckActive") > -1 then z7325.CheckActive = getDataM(spr, getColumIndex(spr,"CheckActive"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7325.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7325_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7325_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7325 As T7325_AREA,CheckClear as Boolean,PROCESSBOMCODE AS String) as Boolean

K7325_MOVE = False

Try
    If READ_PFK7325(PROCESSBOMCODE) = True Then
                z7325 = D7325
		K7325_MOVE = True
		else
	If CheckClear  = True then z7325 = nothing
     End If

     If  getColumIndex(spr,"ProcessBOMCode") > -1 then z7325.ProcessBOMCode = getDataM(spr, getColumIndex(spr,"ProcessBOMCode"), xRow)
     If  getColumIndex(spr,"ProcessBOMName") > -1 then z7325.ProcessBOMName = getDataM(spr, getColumIndex(spr,"ProcessBOMName"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z7325.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z7325.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"ShoesCode") > -1 then z7325.ShoesCode = getDataM(spr, getColumIndex(spr,"ShoesCode"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7325.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7325.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7325.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7325.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7325.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"DateActive") > -1 then z7325.DateActive = getDataM(spr, getColumIndex(spr,"DateActive"), xRow)
     If  getColumIndex(spr,"DateDeactive") > -1 then z7325.DateDeactive = getDataM(spr, getColumIndex(spr,"DateDeactive"), xRow)
     If  getColumIndex(spr,"CheckActive") > -1 then z7325.CheckActive = getDataM(spr, getColumIndex(spr,"CheckActive"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7325.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7325_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7325_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7325 As T7325_AREA, Job as String, PROCESSBOMCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7325_MOVE = False

Try
    If READ_PFK7325(PROCESSBOMCODE) = True Then
                z7325 = D7325
		K7325_MOVE = True
		else
	z7325 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7325")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PROCESSBOMCODE":z7325.ProcessBOMCode = Children(i).Code
   Case "PROCESSBOMNAME":z7325.ProcessBOMName = Children(i).Code
   Case "SEMAINPROCESS":z7325.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z7325.cdMainProcess = Children(i).Code
   Case "SHOESCODE":z7325.ShoesCode = Children(i).Code
   Case "DATEINSERT":z7325.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7325.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7325.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7325.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7325.CheckUse = Children(i).Code
   Case "DATEACTIVE":z7325.DateActive = Children(i).Code
   Case "DATEDEACTIVE":z7325.DateDeactive = Children(i).Code
   Case "CHECKACTIVE":z7325.CheckActive = Children(i).Code
   Case "REMARK":z7325.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PROCESSBOMCODE":z7325.ProcessBOMCode = Children(i).Data
   Case "PROCESSBOMNAME":z7325.ProcessBOMName = Children(i).Data
   Case "SEMAINPROCESS":z7325.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z7325.cdMainProcess = Children(i).Data
   Case "SHOESCODE":z7325.ShoesCode = Children(i).Data
   Case "DATEINSERT":z7325.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7325.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7325.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7325.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7325.CheckUse = Children(i).Data
   Case "DATEACTIVE":z7325.DateActive = Children(i).Data
   Case "DATEDEACTIVE":z7325.DateDeactive = Children(i).Data
   Case "CHECKACTIVE":z7325.CheckActive = Children(i).Data
   Case "REMARK":z7325.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7325_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7325_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7325 As T7325_AREA, Job as String, CheckClear as Boolean, PROCESSBOMCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7325_MOVE = False

Try
    If READ_PFK7325(PROCESSBOMCODE) = True Then
                z7325 = D7325
		K7325_MOVE = True
		else
	If CheckClear  = True then z7325 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7325")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PROCESSBOMCODE":z7325.ProcessBOMCode = Children(i).Code
   Case "PROCESSBOMNAME":z7325.ProcessBOMName = Children(i).Code
   Case "SEMAINPROCESS":z7325.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z7325.cdMainProcess = Children(i).Code
   Case "SHOESCODE":z7325.ShoesCode = Children(i).Code
   Case "DATEINSERT":z7325.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7325.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7325.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7325.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7325.CheckUse = Children(i).Code
   Case "DATEACTIVE":z7325.DateActive = Children(i).Code
   Case "DATEDEACTIVE":z7325.DateDeactive = Children(i).Code
   Case "CHECKACTIVE":z7325.CheckActive = Children(i).Code
   Case "REMARK":z7325.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PROCESSBOMCODE":z7325.ProcessBOMCode = Children(i).Data
   Case "PROCESSBOMNAME":z7325.ProcessBOMName = Children(i).Data
   Case "SEMAINPROCESS":z7325.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z7325.cdMainProcess = Children(i).Data
   Case "SHOESCODE":z7325.ShoesCode = Children(i).Data
   Case "DATEINSERT":z7325.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7325.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7325.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7325.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7325.CheckUse = Children(i).Data
   Case "DATEACTIVE":z7325.DateActive = Children(i).Data
   Case "DATEDEACTIVE":z7325.DateDeactive = Children(i).Data
   Case "CHECKACTIVE":z7325.CheckActive = Children(i).Data
   Case "REMARK":z7325.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7325_MOVE",vbCritical)
End Try
End Function 
    
End Module 
