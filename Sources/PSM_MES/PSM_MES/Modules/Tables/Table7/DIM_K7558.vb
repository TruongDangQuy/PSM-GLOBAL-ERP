'=========================================================================================================================================================
'   TABLE : (PFK7558)
'
'      WORKER : PSM GLOBAL ., LTD
'       WORK DATE : 2019 NEW
'       DEVELOPER    : MRNLV
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7558

Structure T7558_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	Autokey	 AS Double	'			decimal		*
Public 	TableName	 AS String	'			nvarchar(20)
Public 	Parameter	 AS String	'			nvarchar(50)
Public 	FileName	 AS String	'			nvarchar(200)
Public 	FileType	 AS String	'			nvarchar(10)
Public 	AttachDate	 AS String	'			char(8)
Public 	AttachIncharge	 AS String	'			char(8)
Public 	TimeAction	 AS String	'			nvarchar(20)
Public 	IsInsert	 AS String	'			char(1)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	DateInsert	 AS String	'			char(8)
Public 	TimeInsert	 AS String	'			char(14)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	TimeUpdate	 AS String	'			char(14)
Public 	seSite	 AS String	'			char(3)
Public 	cdSite	 AS String	'			char(3)
'=========================================================================================================================================================
End structure

Public D7558 As T7558_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7558(AUTOKEY AS Double) As Boolean
    READ_PFK7558 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7558 "
    SQL = SQL & " WHERE K7558_Autokey		 =  " & Autokey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7558_CLEAR: GoTo SKIP_READ_PFK7558
                
    Call K7558_MOVE(rd)
    READ_PFK7558 = True

SKIP_READ_PFK7558:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7558",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7558(AUTOKEY AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7558 "
    SQL = SQL & " WHERE K7558_Autokey		 =  " & Autokey & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7558",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7558(z7558 As T7558_AREA) As Boolean
    WRITE_PFK7558 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7558)
 
    SQL = " INSERT INTO PFK7558 "
    SQL = SQL & " ( "
            SQL = SQL & " K7558_TableName,"
    SQL = SQL & " K7558_Parameter," 
    SQL = SQL & " K7558_FileName," 
    SQL = SQL & " K7558_FileType," 
    SQL = SQL & " K7558_AttachDate," 
    SQL = SQL & " K7558_AttachIncharge," 
    SQL = SQL & " K7558_TimeAction," 
    SQL = SQL & " K7558_IsInsert," 
    SQL = SQL & " K7558_InchargeInsert," 
    SQL = SQL & " K7558_DateInsert," 
    SQL = SQL & " K7558_TimeInsert," 
    SQL = SQL & " K7558_InchargeUpdate," 
    SQL = SQL & " K7558_DateUpdate," 
    SQL = SQL & " K7558_TimeUpdate," 
    SQL = SQL & " K7558_seSite," 
    SQL = SQL & " K7558_cdSite " 
    SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z7558.TableName) & "', "
    SQL = SQL & "  N'" & FormatSQL(z7558.Parameter) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7558.FileName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7558.FileType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7558.AttachDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7558.AttachIncharge) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7558.TimeAction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7558.IsInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.SAW) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.DAT) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.TIME) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7558.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7558.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7558.TimeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7558.seSite) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7558.cdSite) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7558 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7558",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7558(z7558 As T7558_AREA) As Boolean
    REWRITE_PFK7558 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7558)
   
    SQL = " UPDATE PFK7558 SET "
    SQL = SQL & "    K7558_TableName      = N'" & FormatSQL(z7558.TableName) & "', " 
    SQL = SQL & "    K7558_Parameter      = N'" & FormatSQL(z7558.Parameter) & "', " 
    SQL = SQL & "    K7558_FileName      = N'" & FormatSQL(z7558.FileName) & "', " 
    SQL = SQL & "    K7558_FileType      = N'" & FormatSQL(z7558.FileType) & "', " 
    SQL = SQL & "    K7558_AttachDate      = N'" & FormatSQL(z7558.AttachDate) & "', " 
    SQL = SQL & "    K7558_AttachIncharge      = N'" & FormatSQL(z7558.AttachIncharge) & "', " 
    SQL = SQL & "    K7558_TimeAction      = N'" & FormatSQL(z7558.TimeAction) & "', " 
    SQL = SQL & "    K7558_IsInsert      = N'" & FormatSQL(z7558.IsInsert) & "', " 
    SQL = SQL & "    K7558_InchargeInsert      = N'" & FormatSQL(z7558.InchargeInsert) & "', " 
    SQL = SQL & "    K7558_DateInsert      = N'" & FormatSQL(z7558.DateInsert) & "', " 
    SQL = SQL & "    K7558_TimeInsert      = N'" & FormatSQL(z7558.TimeInsert) & "', " 
    SQL = SQL & "    K7558_InchargeUpdate      = N'" & FormatSQL(PUB.SAW) & "', " 
    SQL = SQL & "    K7558_DateUpdate      = N'" & FormatSQL(PUB.DAT) & "', " 
    SQL = SQL & "    K7558_TimeUpdate      = N'" & FormatSQL(PUB.TIME) & "', " 
    SQL = SQL & "    K7558_seSite      = N'" & FormatSQL(z7558.seSite) & "', " 
    SQL = SQL & "    K7558_cdSite      = N'" & FormatSQL(z7558.cdSite) & "'  " 
    SQL = SQL & " WHERE K7558_Autokey		 =  " & z7558.Autokey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  

    REWRITE_PFK7558 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7558",vbCritical)

  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7558(z7558 As T7558_AREA) As Boolean
    DELETE_PFK7558 = False

   Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7558)
      
        SQL = " DELETE FROM PFK7558  "
    SQL = SQL & " WHERE K7558_Autokey		 =  " & z7558.Autokey & "  " 

    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7558 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7558",vbCritical)
Finally
        Call GetFullInformation("PFK7558", "D", SQL)
  End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7558_CLEAR()
Try
    
    D7558.Autokey = 0 
   D7558.TableName = ""
   D7558.Parameter = ""
   D7558.FileName = ""
   D7558.FileType = ""
   D7558.AttachDate = ""
   D7558.AttachIncharge = ""
   D7558.TimeAction = ""
   D7558.IsInsert = ""
   D7558.InchargeInsert = ""
   D7558.DateInsert = ""
   D7558.TimeInsert = ""
   D7558.InchargeUpdate = ""
   D7558.DateUpdate = ""
   D7558.TimeUpdate = ""
   D7558.seSite = ""
   D7558.cdSite = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7558_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7558 As T7558_AREA)
Try
    
    x7558.Autokey = trim$(  x7558.Autokey)
    x7558.TableName = trim$(  x7558.TableName)
    x7558.Parameter = trim$(  x7558.Parameter)
    x7558.FileName = trim$(  x7558.FileName)
    x7558.FileType = trim$(  x7558.FileType)
    x7558.AttachDate = trim$(  x7558.AttachDate)
    x7558.AttachIncharge = trim$(  x7558.AttachIncharge)
    x7558.TimeAction = trim$(  x7558.TimeAction)
    x7558.IsInsert = trim$(  x7558.IsInsert)
    x7558.InchargeInsert = trim$(  x7558.InchargeInsert)
    x7558.DateInsert = trim$(  x7558.DateInsert)
    x7558.TimeInsert = trim$(  x7558.TimeInsert)
    x7558.InchargeUpdate = trim$(  x7558.InchargeUpdate)
    x7558.DateUpdate = trim$(  x7558.DateUpdate)
    x7558.TimeUpdate = trim$(  x7558.TimeUpdate)
    x7558.seSite = trim$(  x7558.seSite)
    x7558.cdSite = trim$(  x7558.cdSite)
     
    If trim$( x7558.Autokey ) = "" Then x7558.Autokey = 0 
    If trim$( x7558.TableName ) = "" Then x7558.TableName = Space(1) 
    If trim$( x7558.Parameter ) = "" Then x7558.Parameter = Space(1) 
    If trim$( x7558.FileName ) = "" Then x7558.FileName = Space(1) 
    If trim$( x7558.FileType ) = "" Then x7558.FileType = Space(1) 
    If trim$( x7558.AttachDate ) = "" Then x7558.AttachDate = Space(1) 
    If trim$( x7558.AttachIncharge ) = "" Then x7558.AttachIncharge = Space(1) 
    If trim$( x7558.TimeAction ) = "" Then x7558.TimeAction = Space(1) 
    If trim$( x7558.IsInsert ) = "" Then x7558.IsInsert = Space(1) 
    If trim$( x7558.InchargeInsert ) = "" Then x7558.InchargeInsert = Space(1) 
    If trim$( x7558.DateInsert ) = "" Then x7558.DateInsert = Space(1) 
    If trim$( x7558.TimeInsert ) = "" Then x7558.TimeInsert = Space(1) 
    If trim$( x7558.InchargeUpdate ) = "" Then x7558.InchargeUpdate = Space(1) 
    If trim$( x7558.DateUpdate ) = "" Then x7558.DateUpdate = Space(1) 
    If trim$( x7558.TimeUpdate ) = "" Then x7558.TimeUpdate = Space(1) 
    If trim$( x7558.seSite ) = "" Then x7558.seSite = Space(1) 
    If trim$( x7558.cdSite ) = "" Then x7558.cdSite = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7558_MOVE(rs7558 As SqlClient.SqlDataReader)
Try

    call D7558_CLEAR()   

    If IsdbNull(rs7558!K7558_Autokey) = False Then D7558.Autokey = Trim$(rs7558!K7558_Autokey)
    If IsdbNull(rs7558!K7558_TableName) = False Then D7558.TableName = Trim$(rs7558!K7558_TableName)
    If IsdbNull(rs7558!K7558_Parameter) = False Then D7558.Parameter = Trim$(rs7558!K7558_Parameter)
    If IsdbNull(rs7558!K7558_FileName) = False Then D7558.FileName = Trim$(rs7558!K7558_FileName)
    If IsdbNull(rs7558!K7558_FileType) = False Then D7558.FileType = Trim$(rs7558!K7558_FileType)
    If IsdbNull(rs7558!K7558_AttachDate) = False Then D7558.AttachDate = Trim$(rs7558!K7558_AttachDate)
    If IsdbNull(rs7558!K7558_AttachIncharge) = False Then D7558.AttachIncharge = Trim$(rs7558!K7558_AttachIncharge)
    If IsdbNull(rs7558!K7558_TimeAction) = False Then D7558.TimeAction = Trim$(rs7558!K7558_TimeAction)
    If IsdbNull(rs7558!K7558_IsInsert) = False Then D7558.IsInsert = Trim$(rs7558!K7558_IsInsert)
    If IsdbNull(rs7558!K7558_InchargeInsert) = False Then D7558.InchargeInsert = Trim$(rs7558!K7558_InchargeInsert)
    If IsdbNull(rs7558!K7558_DateInsert) = False Then D7558.DateInsert = Trim$(rs7558!K7558_DateInsert)
    If IsdbNull(rs7558!K7558_TimeInsert) = False Then D7558.TimeInsert = Trim$(rs7558!K7558_TimeInsert)
    If IsdbNull(rs7558!K7558_InchargeUpdate) = False Then D7558.InchargeUpdate = Trim$(rs7558!K7558_InchargeUpdate)
    If IsdbNull(rs7558!K7558_DateUpdate) = False Then D7558.DateUpdate = Trim$(rs7558!K7558_DateUpdate)
    If IsdbNull(rs7558!K7558_TimeUpdate) = False Then D7558.TimeUpdate = Trim$(rs7558!K7558_TimeUpdate)
    If IsdbNull(rs7558!K7558_seSite) = False Then D7558.seSite = Trim$(rs7558!K7558_seSite)
    If IsdbNull(rs7558!K7558_cdSite) = False Then D7558.cdSite = Trim$(rs7558!K7558_cdSite)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7558_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7558_MOVE(rs7558 As DataRow)
Try

    call D7558_CLEAR()   

    If IsdbNull(rs7558!K7558_Autokey) = False Then D7558.Autokey = Trim$(rs7558!K7558_Autokey)
    If IsdbNull(rs7558!K7558_TableName) = False Then D7558.TableName = Trim$(rs7558!K7558_TableName)
    If IsdbNull(rs7558!K7558_Parameter) = False Then D7558.Parameter = Trim$(rs7558!K7558_Parameter)
    If IsdbNull(rs7558!K7558_FileName) = False Then D7558.FileName = Trim$(rs7558!K7558_FileName)
    If IsdbNull(rs7558!K7558_FileType) = False Then D7558.FileType = Trim$(rs7558!K7558_FileType)
    If IsdbNull(rs7558!K7558_AttachDate) = False Then D7558.AttachDate = Trim$(rs7558!K7558_AttachDate)
    If IsdbNull(rs7558!K7558_AttachIncharge) = False Then D7558.AttachIncharge = Trim$(rs7558!K7558_AttachIncharge)
    If IsdbNull(rs7558!K7558_TimeAction) = False Then D7558.TimeAction = Trim$(rs7558!K7558_TimeAction)
    If IsdbNull(rs7558!K7558_IsInsert) = False Then D7558.IsInsert = Trim$(rs7558!K7558_IsInsert)
    If IsdbNull(rs7558!K7558_InchargeInsert) = False Then D7558.InchargeInsert = Trim$(rs7558!K7558_InchargeInsert)
    If IsdbNull(rs7558!K7558_DateInsert) = False Then D7558.DateInsert = Trim$(rs7558!K7558_DateInsert)
    If IsdbNull(rs7558!K7558_TimeInsert) = False Then D7558.TimeInsert = Trim$(rs7558!K7558_TimeInsert)
    If IsdbNull(rs7558!K7558_InchargeUpdate) = False Then D7558.InchargeUpdate = Trim$(rs7558!K7558_InchargeUpdate)
    If IsdbNull(rs7558!K7558_DateUpdate) = False Then D7558.DateUpdate = Trim$(rs7558!K7558_DateUpdate)
    If IsdbNull(rs7558!K7558_TimeUpdate) = False Then D7558.TimeUpdate = Trim$(rs7558!K7558_TimeUpdate)
    If IsdbNull(rs7558!K7558_seSite) = False Then D7558.seSite = Trim$(rs7558!K7558_seSite)
    If IsdbNull(rs7558!K7558_cdSite) = False Then D7558.cdSite = Trim$(rs7558!K7558_cdSite)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7558_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7558_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7558 As T7558_AREA, AUTOKEY AS Double) as Boolean

K7558_MOVE = False

Try
    If READ_PFK7558(AUTOKEY) = True Then
                z7558 = D7558
		K7558_MOVE = True
		else
	z7558 = nothing
     End If

     If  getColumnIndex(spr,"Autokey") > -1 then z7558.Autokey = Cdecp(getDataM(spr, getColumnIndex(spr,"Autokey"), xRow))
     If  getColumnIndex(spr,"TableName") > -1 then z7558.TableName = getDataM(spr, getColumnIndex(spr,"TableName"), xRow)
     If  getColumnIndex(spr,"Parameter") > -1 then z7558.Parameter = getDataM(spr, getColumnIndex(spr,"Parameter"), xRow)
     If  getColumnIndex(spr,"FileName") > -1 then z7558.FileName = getDataM(spr, getColumnIndex(spr,"FileName"), xRow)
     If  getColumnIndex(spr,"FileType") > -1 then z7558.FileType = getDataM(spr, getColumnIndex(spr,"FileType"), xRow)
     If  getColumnIndex(spr,"AttachDate") > -1 then z7558.AttachDate = getDataM(spr, getColumnIndex(spr,"AttachDate"), xRow)
     If  getColumnIndex(spr,"AttachIncharge") > -1 then z7558.AttachIncharge = getDataM(spr, getColumnIndex(spr,"AttachIncharge"), xRow)
     If  getColumnIndex(spr,"TimeAction") > -1 then z7558.TimeAction = getDataM(spr, getColumnIndex(spr,"TimeAction"), xRow)
     If  getColumnIndex(spr,"IsInsert") > -1 then z7558.IsInsert = getDataM(spr, getColumnIndex(spr,"IsInsert"), xRow)
     If  getColumnIndex(spr,"InchargeInsert") > -1 then z7558.InchargeInsert = getDataM(spr, getColumnIndex(spr,"InchargeInsert"), xRow)
     If  getColumnIndex(spr,"DateInsert") > -1 then z7558.DateInsert = getDataM(spr, getColumnIndex(spr,"DateInsert"), xRow)
     If  getColumnIndex(spr,"TimeInsert") > -1 then z7558.TimeInsert = getDataM(spr, getColumnIndex(spr,"TimeInsert"), xRow)
     If  getColumnIndex(spr,"InchargeUpdate") > -1 then z7558.InchargeUpdate = getDataM(spr, getColumnIndex(spr,"InchargeUpdate"), xRow)
     If  getColumnIndex(spr,"DateUpdate") > -1 then z7558.DateUpdate = getDataM(spr, getColumnIndex(spr,"DateUpdate"), xRow)
     If  getColumnIndex(spr,"TimeUpdate") > -1 then z7558.TimeUpdate = getDataM(spr, getColumnIndex(spr,"TimeUpdate"), xRow)
     If  getColumnIndex(spr,"seSite") > -1 then z7558.seSite = getDataM(spr, getColumnIndex(spr,"seSite"), xRow)
     If  getColumnIndex(spr,"cdSite") > -1 then z7558.cdSite = getDataM(spr, getColumnIndex(spr,"cdSite"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7558_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7558_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7558 As T7558_AREA,CheckClear as Boolean,AUTOKEY AS Double) as Boolean

K7558_MOVE = False

Try
    If READ_PFK7558(AUTOKEY) = True Then
                z7558 = D7558
		K7558_MOVE = True
		else
	If CheckClear  = True then z7558 = nothing
     End If

     If  getColumnIndex(spr,"Autokey") > -1 then z7558.Autokey = Cdecp(getDataM(spr, getColumnIndex(spr,"Autokey"), xRow))
     If  getColumnIndex(spr,"TableName") > -1 then z7558.TableName = getDataM(spr, getColumnIndex(spr,"TableName"), xRow)
     If  getColumnIndex(spr,"Parameter") > -1 then z7558.Parameter = getDataM(spr, getColumnIndex(spr,"Parameter"), xRow)
     If  getColumnIndex(spr,"FileName") > -1 then z7558.FileName = getDataM(spr, getColumnIndex(spr,"FileName"), xRow)
     If  getColumnIndex(spr,"FileType") > -1 then z7558.FileType = getDataM(spr, getColumnIndex(spr,"FileType"), xRow)
     If  getColumnIndex(spr,"AttachDate") > -1 then z7558.AttachDate = getDataM(spr, getColumnIndex(spr,"AttachDate"), xRow)
     If  getColumnIndex(spr,"AttachIncharge") > -1 then z7558.AttachIncharge = getDataM(spr, getColumnIndex(spr,"AttachIncharge"), xRow)
     If  getColumnIndex(spr,"TimeAction") > -1 then z7558.TimeAction = getDataM(spr, getColumnIndex(spr,"TimeAction"), xRow)
     If  getColumnIndex(spr,"IsInsert") > -1 then z7558.IsInsert = getDataM(spr, getColumnIndex(spr,"IsInsert"), xRow)
     If  getColumnIndex(spr,"InchargeInsert") > -1 then z7558.InchargeInsert = getDataM(spr, getColumnIndex(spr,"InchargeInsert"), xRow)
     If  getColumnIndex(spr,"DateInsert") > -1 then z7558.DateInsert = getDataM(spr, getColumnIndex(spr,"DateInsert"), xRow)
     If  getColumnIndex(spr,"TimeInsert") > -1 then z7558.TimeInsert = getDataM(spr, getColumnIndex(spr,"TimeInsert"), xRow)
     If  getColumnIndex(spr,"InchargeUpdate") > -1 then z7558.InchargeUpdate = getDataM(spr, getColumnIndex(spr,"InchargeUpdate"), xRow)
     If  getColumnIndex(spr,"DateUpdate") > -1 then z7558.DateUpdate = getDataM(spr, getColumnIndex(spr,"DateUpdate"), xRow)
     If  getColumnIndex(spr,"TimeUpdate") > -1 then z7558.TimeUpdate = getDataM(spr, getColumnIndex(spr,"TimeUpdate"), xRow)
     If  getColumnIndex(spr,"seSite") > -1 then z7558.seSite = getDataM(spr, getColumnIndex(spr,"seSite"), xRow)
     If  getColumnIndex(spr,"cdSite") > -1 then z7558.cdSite = getDataM(spr, getColumnIndex(spr,"cdSite"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7558_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7558_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7558 As T7558_AREA, Job as String, AUTOKEY AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7558_MOVE = False

Try
    If READ_PFK7558(AUTOKEY) = True Then
                z7558 = D7558
		K7558_MOVE = True
		else
	z7558 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7558")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z7558.Autokey = Children(i).Code
   Case "TABLENAME":z7558.TableName = Children(i).Code
   Case "PARAMETER":z7558.Parameter = Children(i).Code
   Case "FILENAME":z7558.FileName = Children(i).Code
   Case "FILETYPE":z7558.FileType = Children(i).Code
   Case "ATTACHDATE":z7558.AttachDate = Children(i).Code
   Case "ATTACHINCHARGE":z7558.AttachIncharge = Children(i).Code
   Case "TIMEACTION":z7558.TimeAction = Children(i).Code
   Case "ISINSERT":z7558.IsInsert = Children(i).Code
   Case "INCHARGEINSERT":z7558.InchargeInsert = Children(i).Code
   Case "DATEINSERT":z7558.DateInsert = Children(i).Code
   Case "TIMEINSERT":z7558.TimeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7558.InchargeUpdate = Children(i).Code
   Case "DATEUPDATE":z7558.DateUpdate = Children(i).Code
   Case "TIMEUPDATE":z7558.TimeUpdate = Children(i).Code
   Case "SESITE":z7558.seSite = Children(i).Code
   Case "CDSITE":z7558.cdSite = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z7558.Autokey = Cdecp(Children(i).Data)
   Case "TABLENAME":z7558.TableName = Children(i).Data
   Case "PARAMETER":z7558.Parameter = Children(i).Data
   Case "FILENAME":z7558.FileName = Children(i).Data
   Case "FILETYPE":z7558.FileType = Children(i).Data
   Case "ATTACHDATE":z7558.AttachDate = Children(i).Data
   Case "ATTACHINCHARGE":z7558.AttachIncharge = Children(i).Data
   Case "TIMEACTION":z7558.TimeAction = Children(i).Data
   Case "ISINSERT":z7558.IsInsert = Children(i).Data
   Case "INCHARGEINSERT":z7558.InchargeInsert = Children(i).Data
   Case "DATEINSERT":z7558.DateInsert = Children(i).Data
   Case "TIMEINSERT":z7558.TimeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7558.InchargeUpdate = Children(i).Data
   Case "DATEUPDATE":z7558.DateUpdate = Children(i).Data
   Case "TIMEUPDATE":z7558.TimeUpdate = Children(i).Data
   Case "SESITE":z7558.seSite = Children(i).Data
   Case "CDSITE":z7558.cdSite = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7558_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7558_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7558 As T7558_AREA, Job as String, CheckClear as Boolean, AUTOKEY AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7558_MOVE = False

Try
    If READ_PFK7558(AUTOKEY) = True Then
                z7558 = D7558
		K7558_MOVE = True
		else
	If CheckClear  = True then z7558 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7558")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z7558.Autokey = Children(i).Code
   Case "TABLENAME":z7558.TableName = Children(i).Code
   Case "PARAMETER":z7558.Parameter = Children(i).Code
   Case "FILENAME":z7558.FileName = Children(i).Code
   Case "FILETYPE":z7558.FileType = Children(i).Code
   Case "ATTACHDATE":z7558.AttachDate = Children(i).Code
   Case "ATTACHINCHARGE":z7558.AttachIncharge = Children(i).Code
   Case "TIMEACTION":z7558.TimeAction = Children(i).Code
   Case "ISINSERT":z7558.IsInsert = Children(i).Code
   Case "INCHARGEINSERT":z7558.InchargeInsert = Children(i).Code
   Case "DATEINSERT":z7558.DateInsert = Children(i).Code
   Case "TIMEINSERT":z7558.TimeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7558.InchargeUpdate = Children(i).Code
   Case "DATEUPDATE":z7558.DateUpdate = Children(i).Code
   Case "TIMEUPDATE":z7558.TimeUpdate = Children(i).Code
   Case "SESITE":z7558.seSite = Children(i).Code
   Case "CDSITE":z7558.cdSite = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z7558.Autokey = Cdecp(Children(i).Data)
   Case "TABLENAME":z7558.TableName = Children(i).Data
   Case "PARAMETER":z7558.Parameter = Children(i).Data
   Case "FILENAME":z7558.FileName = Children(i).Data
   Case "FILETYPE":z7558.FileType = Children(i).Data
   Case "ATTACHDATE":z7558.AttachDate = Children(i).Data
   Case "ATTACHINCHARGE":z7558.AttachIncharge = Children(i).Data
   Case "TIMEACTION":z7558.TimeAction = Children(i).Data
   Case "ISINSERT":z7558.IsInsert = Children(i).Data
   Case "INCHARGEINSERT":z7558.InchargeInsert = Children(i).Data
   Case "DATEINSERT":z7558.DateInsert = Children(i).Data
   Case "TIMEINSERT":z7558.TimeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7558.InchargeUpdate = Children(i).Data
   Case "DATEUPDATE":z7558.DateUpdate = Children(i).Data
   Case "TIMEUPDATE":z7558.TimeUpdate = Children(i).Data
   Case "SESITE":z7558.seSite = Children(i).Data
   Case "CDSITE":z7558.cdSite = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7558_MOVE",vbCritical)
End Try
End Function 
    

'=========================================================================================================================================================
' DATA MOVE FORM NEW AREA
'=========================================================================================================================================================
Public Sub K7558_MOVE(ByRef a7558 As T7558_AREA, ByRef b7558 As T7558_AREA) 
Try
If trim$( a7558.Autokey ) = "" Then b7558.Autokey = ""  Else b7558.Autokey=a7558.Autokey
If trim$( a7558.TableName ) = "" Then b7558.TableName = ""  Else b7558.TableName=a7558.TableName
If trim$( a7558.Parameter ) = "" Then b7558.Parameter = ""  Else b7558.Parameter=a7558.Parameter
If trim$( a7558.FileName ) = "" Then b7558.FileName = ""  Else b7558.FileName=a7558.FileName
If trim$( a7558.FileType ) = "" Then b7558.FileType = ""  Else b7558.FileType=a7558.FileType
If trim$( a7558.AttachDate ) = "" Then b7558.AttachDate = ""  Else b7558.AttachDate=a7558.AttachDate
If trim$( a7558.AttachIncharge ) = "" Then b7558.AttachIncharge = ""  Else b7558.AttachIncharge=a7558.AttachIncharge
If trim$( a7558.TimeAction ) = "" Then b7558.TimeAction = ""  Else b7558.TimeAction=a7558.TimeAction
If trim$( a7558.IsInsert ) = "" Then b7558.IsInsert = ""  Else b7558.IsInsert=a7558.IsInsert
If trim$( a7558.InchargeInsert ) = "" Then b7558.InchargeInsert = ""  Else b7558.InchargeInsert=a7558.InchargeInsert
If trim$( a7558.DateInsert ) = "" Then b7558.DateInsert = ""  Else b7558.DateInsert=a7558.DateInsert
If trim$( a7558.TimeInsert ) = "" Then b7558.TimeInsert = ""  Else b7558.TimeInsert=a7558.TimeInsert
If trim$( a7558.InchargeUpdate ) = "" Then b7558.InchargeUpdate = ""  Else b7558.InchargeUpdate=a7558.InchargeUpdate
If trim$( a7558.DateUpdate ) = "" Then b7558.DateUpdate = ""  Else b7558.DateUpdate=a7558.DateUpdate
If trim$( a7558.TimeUpdate ) = "" Then b7558.TimeUpdate = ""  Else b7558.TimeUpdate=a7558.TimeUpdate
If trim$( a7558.seSite ) = "" Then b7558.seSite = ""  Else b7558.seSite=a7558.seSite
If trim$( a7558.cdSite ) = "" Then b7558.cdSite = ""  Else b7558.cdSite=a7558.cdSite
Catch ex As Exception
      Call MsgBoxP("K7558_MOVE",vbCritical)
End Try
End Sub 


End Module 
