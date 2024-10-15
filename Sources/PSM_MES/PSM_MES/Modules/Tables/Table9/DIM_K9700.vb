'=========================================================================================================================================================
'   TABLE : (PFK9700)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K9700

Structure T9700_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	LogNo	 AS Long	'			int		*
Public 	ComputerName	 AS String	'			nvarchar(200)
Public 	AccountWin	 AS String	'			nvarchar(50)
Public 	UserCode	 AS String	'			char(6)
Public 	DateTimeCreate	 AS String	'			char(14)
Public 	DateCreate	 AS String	'			char(8)
Public 	FormName	 AS String	'			nvarchar(200)
Public 	ActionName	 AS String	'			nvarchar(200)
Public 	Reference	 AS String	'			nvarchar(-1)
Public 	DNSdomain	 AS String	'			nvarchar(50)
Public 	DHCPServer	 AS String	'			varchar(20)
Public 	IPv4Address	 AS String	'			varchar(20)
Public 	IPWan	 AS String	'			varchar(30)
Public 	MACAddress	 AS String	'			varchar(40)
Public 	HDDSerialNo	 AS String	'			varchar(50)
Public 	DeviceName	 AS String	'			nvarchar(500)
Public 	Description	 AS String	'			nvarchar(500)
Public 	Active	 AS String	'			char(1)
'=========================================================================================================================================================
End structure

Public D9700 As T9700_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK9700(LOGNO AS Long) As Boolean
    READ_PFK9700 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9700 "
    SQL = SQL & " WHERE K9700_LogNo		 =  " & LogNo & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D9700_CLEAR: GoTo SKIP_READ_PFK9700
                
    Call K9700_MOVE(rd)
    READ_PFK9700 = True

SKIP_READ_PFK9700:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK9700",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK9700(LOGNO AS Long, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9700 "
    SQL = SQL & " WHERE K9700_LogNo		 =  " & LogNo & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK9700",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK9700(z9700 As T9700_AREA) As Boolean
    WRITE_PFK9700 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z9700)
 
    SQL = " INSERT INTO PFK9700 "
    SQL = SQL & " ( "
            SQL = SQL & " K9700_ComputerName,"
    SQL = SQL & " K9700_AccountWin," 
    SQL = SQL & " K9700_UserCode," 
    SQL = SQL & " K9700_DateTimeCreate," 
    SQL = SQL & " K9700_DateCreate," 
    SQL = SQL & " K9700_FormName," 
    SQL = SQL & " K9700_ActionName," 
    SQL = SQL & " K9700_Reference," 
    SQL = SQL & " K9700_DNSdomain," 
    SQL = SQL & " K9700_DHCPServer," 
    SQL = SQL & " K9700_IPv4Address," 
    SQL = SQL & " K9700_IPWan," 
    SQL = SQL & " K9700_MACAddress," 
    SQL = SQL & " K9700_HDDSerialNo," 
    SQL = SQL & " K9700_DeviceName," 
    SQL = SQL & " K9700_Description," 
    SQL = SQL & " K9700_Active " 
    SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z9700.ComputerName) & "', "
    SQL = SQL & "  N'" & FormatSQL(z9700.AccountWin) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9700.UserCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9700.DateTimeCreate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9700.DateCreate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9700.FormName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9700.ActionName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9700.Reference) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9700.DNSdomain) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9700.DHCPServer) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9700.IPv4Address) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9700.IPWan) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9700.MACAddress) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9700.HDDSerialNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9700.DeviceName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9700.Description) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9700.Active) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK9700 = True
    Exit Function
Catch ex As Exception
            'Call MsgBoxP("WRITE_PFK9700",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK9700(z9700 As T9700_AREA) As Boolean
    REWRITE_PFK9700 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z9700)
   
    SQL = " UPDATE PFK9700 SET "
    SQL = SQL & "    K9700_ComputerName      = N'" & FormatSQL(z9700.ComputerName) & "', " 
    SQL = SQL & "    K9700_AccountWin      = N'" & FormatSQL(z9700.AccountWin) & "', " 
    SQL = SQL & "    K9700_UserCode      = N'" & FormatSQL(z9700.UserCode) & "', " 
    SQL = SQL & "    K9700_DateTimeCreate      = N'" & FormatSQL(z9700.DateTimeCreate) & "', " 
    SQL = SQL & "    K9700_DateCreate      = N'" & FormatSQL(z9700.DateCreate) & "', " 
    SQL = SQL & "    K9700_FormName      = N'" & FormatSQL(z9700.FormName) & "', " 
    SQL = SQL & "    K9700_ActionName      = N'" & FormatSQL(z9700.ActionName) & "', " 
    SQL = SQL & "    K9700_Reference      = N'" & FormatSQL(z9700.Reference) & "', " 
    SQL = SQL & "    K9700_DNSdomain      = N'" & FormatSQL(z9700.DNSdomain) & "', " 
    SQL = SQL & "    K9700_DHCPServer      = N'" & FormatSQL(z9700.DHCPServer) & "', " 
    SQL = SQL & "    K9700_IPv4Address      = N'" & FormatSQL(z9700.IPv4Address) & "', " 
    SQL = SQL & "    K9700_IPWan      = N'" & FormatSQL(z9700.IPWan) & "', " 
    SQL = SQL & "    K9700_MACAddress      = N'" & FormatSQL(z9700.MACAddress) & "', " 
    SQL = SQL & "    K9700_HDDSerialNo      = N'" & FormatSQL(z9700.HDDSerialNo) & "', " 
    SQL = SQL & "    K9700_DeviceName      = N'" & FormatSQL(z9700.DeviceName) & "', " 
    SQL = SQL & "    K9700_Description      = N'" & FormatSQL(z9700.Description) & "', " 
    SQL = SQL & "    K9700_Active      = N'" & FormatSQL(z9700.Active) & "'  " 
    SQL = SQL & " WHERE K9700_LogNo		 =  " & z9700.LogNo & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK9700 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK9700",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK9700(z9700 As T9700_AREA) As Boolean
    DELETE_PFK9700 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK9700 "
    SQL = SQL & " WHERE K9700_LogNo		 =  " & z9700.LogNo & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK9700 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK9700",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D9700_CLEAR()
Try
    
    D9700.LogNo = 0 
   D9700.ComputerName = ""
   D9700.AccountWin = ""
   D9700.UserCode = ""
   D9700.DateTimeCreate = ""
   D9700.DateCreate = ""
   D9700.FormName = ""
   D9700.ActionName = ""
   D9700.Reference = ""
   D9700.DNSdomain = ""
   D9700.DHCPServer = ""
   D9700.IPv4Address = ""
   D9700.IPWan = ""
   D9700.MACAddress = ""
   D9700.HDDSerialNo = ""
   D9700.DeviceName = ""
   D9700.Description = ""
   D9700.Active = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D9700_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x9700 As T9700_AREA)
Try
    
    x9700.LogNo = trim$(  x9700.LogNo)
    x9700.ComputerName = trim$(  x9700.ComputerName)
    x9700.AccountWin = trim$(  x9700.AccountWin)
    x9700.UserCode = trim$(  x9700.UserCode)
    x9700.DateTimeCreate = trim$(  x9700.DateTimeCreate)
    x9700.DateCreate = trim$(  x9700.DateCreate)
    x9700.FormName = trim$(  x9700.FormName)
    x9700.ActionName = trim$(  x9700.ActionName)
    x9700.Reference = trim$(  x9700.Reference)
    x9700.DNSdomain = trim$(  x9700.DNSdomain)
    x9700.DHCPServer = trim$(  x9700.DHCPServer)
    x9700.IPv4Address = trim$(  x9700.IPv4Address)
    x9700.IPWan = trim$(  x9700.IPWan)
    x9700.MACAddress = trim$(  x9700.MACAddress)
    x9700.HDDSerialNo = trim$(  x9700.HDDSerialNo)
    x9700.DeviceName = trim$(  x9700.DeviceName)
    x9700.Description = trim$(  x9700.Description)
    x9700.Active = trim$(  x9700.Active)
     
    If trim$( x9700.LogNo ) = "" Then x9700.LogNo = 0 
    If trim$( x9700.ComputerName ) = "" Then x9700.ComputerName = Space(1) 
    If trim$( x9700.AccountWin ) = "" Then x9700.AccountWin = Space(1) 
    If trim$( x9700.UserCode ) = "" Then x9700.UserCode = Space(1) 
    If trim$( x9700.DateTimeCreate ) = "" Then x9700.DateTimeCreate = Space(1) 
    If trim$( x9700.DateCreate ) = "" Then x9700.DateCreate = Space(1) 
    If trim$( x9700.FormName ) = "" Then x9700.FormName = Space(1) 
    If trim$( x9700.ActionName ) = "" Then x9700.ActionName = Space(1) 
    If trim$( x9700.Reference ) = "" Then x9700.Reference = Space(1) 
    If trim$( x9700.DNSdomain ) = "" Then x9700.DNSdomain = Space(1) 
    If trim$( x9700.DHCPServer ) = "" Then x9700.DHCPServer = Space(1) 
    If trim$( x9700.IPv4Address ) = "" Then x9700.IPv4Address = Space(1) 
    If trim$( x9700.IPWan ) = "" Then x9700.IPWan = Space(1) 
    If trim$( x9700.MACAddress ) = "" Then x9700.MACAddress = Space(1) 
    If trim$( x9700.HDDSerialNo ) = "" Then x9700.HDDSerialNo = Space(1) 
    If trim$( x9700.DeviceName ) = "" Then x9700.DeviceName = Space(1) 
    If trim$( x9700.Description ) = "" Then x9700.Description = Space(1) 
    If trim$( x9700.Active ) = "" Then x9700.Active = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K9700_MOVE(rs9700 As SqlClient.SqlDataReader)
Try

    call D9700_CLEAR()   

    If IsdbNull(rs9700!K9700_LogNo) = False Then D9700.LogNo = Trim$(rs9700!K9700_LogNo)
    If IsdbNull(rs9700!K9700_ComputerName) = False Then D9700.ComputerName = Trim$(rs9700!K9700_ComputerName)
    If IsdbNull(rs9700!K9700_AccountWin) = False Then D9700.AccountWin = Trim$(rs9700!K9700_AccountWin)
    If IsdbNull(rs9700!K9700_UserCode) = False Then D9700.UserCode = Trim$(rs9700!K9700_UserCode)
    If IsdbNull(rs9700!K9700_DateTimeCreate) = False Then D9700.DateTimeCreate = Trim$(rs9700!K9700_DateTimeCreate)
    If IsdbNull(rs9700!K9700_DateCreate) = False Then D9700.DateCreate = Trim$(rs9700!K9700_DateCreate)
    If IsdbNull(rs9700!K9700_FormName) = False Then D9700.FormName = Trim$(rs9700!K9700_FormName)
    If IsdbNull(rs9700!K9700_ActionName) = False Then D9700.ActionName = Trim$(rs9700!K9700_ActionName)
    If IsdbNull(rs9700!K9700_Reference) = False Then D9700.Reference = Trim$(rs9700!K9700_Reference)
    If IsdbNull(rs9700!K9700_DNSdomain) = False Then D9700.DNSdomain = Trim$(rs9700!K9700_DNSdomain)
    If IsdbNull(rs9700!K9700_DHCPServer) = False Then D9700.DHCPServer = Trim$(rs9700!K9700_DHCPServer)
    If IsdbNull(rs9700!K9700_IPv4Address) = False Then D9700.IPv4Address = Trim$(rs9700!K9700_IPv4Address)
    If IsdbNull(rs9700!K9700_IPWan) = False Then D9700.IPWan = Trim$(rs9700!K9700_IPWan)
    If IsdbNull(rs9700!K9700_MACAddress) = False Then D9700.MACAddress = Trim$(rs9700!K9700_MACAddress)
    If IsdbNull(rs9700!K9700_HDDSerialNo) = False Then D9700.HDDSerialNo = Trim$(rs9700!K9700_HDDSerialNo)
    If IsdbNull(rs9700!K9700_DeviceName) = False Then D9700.DeviceName = Trim$(rs9700!K9700_DeviceName)
    If IsdbNull(rs9700!K9700_Description) = False Then D9700.Description = Trim$(rs9700!K9700_Description)
    If IsdbNull(rs9700!K9700_Active) = False Then D9700.Active = Trim$(rs9700!K9700_Active)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9700_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K9700_MOVE(rs9700 As DataRow)
Try

    call D9700_CLEAR()   

    If IsdbNull(rs9700!K9700_LogNo) = False Then D9700.LogNo = Trim$(rs9700!K9700_LogNo)
    If IsdbNull(rs9700!K9700_ComputerName) = False Then D9700.ComputerName = Trim$(rs9700!K9700_ComputerName)
    If IsdbNull(rs9700!K9700_AccountWin) = False Then D9700.AccountWin = Trim$(rs9700!K9700_AccountWin)
    If IsdbNull(rs9700!K9700_UserCode) = False Then D9700.UserCode = Trim$(rs9700!K9700_UserCode)
    If IsdbNull(rs9700!K9700_DateTimeCreate) = False Then D9700.DateTimeCreate = Trim$(rs9700!K9700_DateTimeCreate)
    If IsdbNull(rs9700!K9700_DateCreate) = False Then D9700.DateCreate = Trim$(rs9700!K9700_DateCreate)
    If IsdbNull(rs9700!K9700_FormName) = False Then D9700.FormName = Trim$(rs9700!K9700_FormName)
    If IsdbNull(rs9700!K9700_ActionName) = False Then D9700.ActionName = Trim$(rs9700!K9700_ActionName)
    If IsdbNull(rs9700!K9700_Reference) = False Then D9700.Reference = Trim$(rs9700!K9700_Reference)
    If IsdbNull(rs9700!K9700_DNSdomain) = False Then D9700.DNSdomain = Trim$(rs9700!K9700_DNSdomain)
    If IsdbNull(rs9700!K9700_DHCPServer) = False Then D9700.DHCPServer = Trim$(rs9700!K9700_DHCPServer)
    If IsdbNull(rs9700!K9700_IPv4Address) = False Then D9700.IPv4Address = Trim$(rs9700!K9700_IPv4Address)
    If IsdbNull(rs9700!K9700_IPWan) = False Then D9700.IPWan = Trim$(rs9700!K9700_IPWan)
    If IsdbNull(rs9700!K9700_MACAddress) = False Then D9700.MACAddress = Trim$(rs9700!K9700_MACAddress)
    If IsdbNull(rs9700!K9700_HDDSerialNo) = False Then D9700.HDDSerialNo = Trim$(rs9700!K9700_HDDSerialNo)
    If IsdbNull(rs9700!K9700_DeviceName) = False Then D9700.DeviceName = Trim$(rs9700!K9700_DeviceName)
    If IsdbNull(rs9700!K9700_Description) = False Then D9700.Description = Trim$(rs9700!K9700_Description)
    If IsdbNull(rs9700!K9700_Active) = False Then D9700.Active = Trim$(rs9700!K9700_Active)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9700_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K9700_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9700 As T9700_AREA, LOGNO AS Long) as Boolean

K9700_MOVE = False

Try
    If READ_PFK9700(LOGNO) = True Then
                z9700 = D9700
		K9700_MOVE = True
		else
	z9700 = nothing
     End If

     If  getColumIndex(spr,"LogNo") > -1 then z9700.LogNo = getDataM(spr, getColumIndex(spr,"LogNo"), xRow)
     If  getColumIndex(spr,"ComputerName") > -1 then z9700.ComputerName = getDataM(spr, getColumIndex(spr,"ComputerName"), xRow)
     If  getColumIndex(spr,"AccountWin") > -1 then z9700.AccountWin = getDataM(spr, getColumIndex(spr,"AccountWin"), xRow)
     If  getColumIndex(spr,"UserCode") > -1 then z9700.UserCode = getDataM(spr, getColumIndex(spr,"UserCode"), xRow)
     If  getColumIndex(spr,"DateTimeCreate") > -1 then z9700.DateTimeCreate = getDataM(spr, getColumIndex(spr,"DateTimeCreate"), xRow)
     If  getColumIndex(spr,"DateCreate") > -1 then z9700.DateCreate = getDataM(spr, getColumIndex(spr,"DateCreate"), xRow)
     If  getColumIndex(spr,"FormName") > -1 then z9700.FormName = getDataM(spr, getColumIndex(spr,"FormName"), xRow)
     If  getColumIndex(spr,"ActionName") > -1 then z9700.ActionName = getDataM(spr, getColumIndex(spr,"ActionName"), xRow)
     If  getColumIndex(spr,"Reference") > -1 then z9700.Reference = getDataM(spr, getColumIndex(spr,"Reference"), xRow)
     If  getColumIndex(spr,"DNSdomain") > -1 then z9700.DNSdomain = getDataM(spr, getColumIndex(spr,"DNSdomain"), xRow)
     If  getColumIndex(spr,"DHCPServer") > -1 then z9700.DHCPServer = getDataM(spr, getColumIndex(spr,"DHCPServer"), xRow)
     If  getColumIndex(spr,"IPv4Address") > -1 then z9700.IPv4Address = getDataM(spr, getColumIndex(spr,"IPv4Address"), xRow)
     If  getColumIndex(spr,"IPWan") > -1 then z9700.IPWan = getDataM(spr, getColumIndex(spr,"IPWan"), xRow)
     If  getColumIndex(spr,"MACAddress") > -1 then z9700.MACAddress = getDataM(spr, getColumIndex(spr,"MACAddress"), xRow)
     If  getColumIndex(spr,"HDDSerialNo") > -1 then z9700.HDDSerialNo = getDataM(spr, getColumIndex(spr,"HDDSerialNo"), xRow)
     If  getColumIndex(spr,"DeviceName") > -1 then z9700.DeviceName = getDataM(spr, getColumIndex(spr,"DeviceName"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z9700.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"Active") > -1 then z9700.Active = getDataM(spr, getColumIndex(spr,"Active"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K9700_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K9700_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9700 As T9700_AREA,CheckClear as Boolean,LOGNO AS Long) as Boolean

K9700_MOVE = False

Try
    If READ_PFK9700(LOGNO) = True Then
                z9700 = D9700
		K9700_MOVE = True
		else
	If CheckClear  = True then z9700 = nothing
     End If

     If  getColumIndex(spr,"LogNo") > -1 then z9700.LogNo = getDataM(spr, getColumIndex(spr,"LogNo"), xRow)
     If  getColumIndex(spr,"ComputerName") > -1 then z9700.ComputerName = getDataM(spr, getColumIndex(spr,"ComputerName"), xRow)
     If  getColumIndex(spr,"AccountWin") > -1 then z9700.AccountWin = getDataM(spr, getColumIndex(spr,"AccountWin"), xRow)
     If  getColumIndex(spr,"UserCode") > -1 then z9700.UserCode = getDataM(spr, getColumIndex(spr,"UserCode"), xRow)
     If  getColumIndex(spr,"DateTimeCreate") > -1 then z9700.DateTimeCreate = getDataM(spr, getColumIndex(spr,"DateTimeCreate"), xRow)
     If  getColumIndex(spr,"DateCreate") > -1 then z9700.DateCreate = getDataM(spr, getColumIndex(spr,"DateCreate"), xRow)
     If  getColumIndex(spr,"FormName") > -1 then z9700.FormName = getDataM(spr, getColumIndex(spr,"FormName"), xRow)
     If  getColumIndex(spr,"ActionName") > -1 then z9700.ActionName = getDataM(spr, getColumIndex(spr,"ActionName"), xRow)
     If  getColumIndex(spr,"Reference") > -1 then z9700.Reference = getDataM(spr, getColumIndex(spr,"Reference"), xRow)
     If  getColumIndex(spr,"DNSdomain") > -1 then z9700.DNSdomain = getDataM(spr, getColumIndex(spr,"DNSdomain"), xRow)
     If  getColumIndex(spr,"DHCPServer") > -1 then z9700.DHCPServer = getDataM(spr, getColumIndex(spr,"DHCPServer"), xRow)
     If  getColumIndex(spr,"IPv4Address") > -1 then z9700.IPv4Address = getDataM(spr, getColumIndex(spr,"IPv4Address"), xRow)
     If  getColumIndex(spr,"IPWan") > -1 then z9700.IPWan = getDataM(spr, getColumIndex(spr,"IPWan"), xRow)
     If  getColumIndex(spr,"MACAddress") > -1 then z9700.MACAddress = getDataM(spr, getColumIndex(spr,"MACAddress"), xRow)
     If  getColumIndex(spr,"HDDSerialNo") > -1 then z9700.HDDSerialNo = getDataM(spr, getColumIndex(spr,"HDDSerialNo"), xRow)
     If  getColumIndex(spr,"DeviceName") > -1 then z9700.DeviceName = getDataM(spr, getColumIndex(spr,"DeviceName"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z9700.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"Active") > -1 then z9700.Active = getDataM(spr, getColumIndex(spr,"Active"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K9700_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K9700_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9700 As T9700_AREA, Job as String, LOGNO AS Long) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9700_MOVE = False

Try
    If READ_PFK9700(LOGNO) = True Then
                z9700 = D9700
		K9700_MOVE = True
		else
	z9700 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9700")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "LOGNO":z9700.LogNo = Children(i).Code
   Case "COMPUTERNAME":z9700.ComputerName = Children(i).Code
   Case "ACCOUNTWIN":z9700.AccountWin = Children(i).Code
   Case "USERCODE":z9700.UserCode = Children(i).Code
   Case "DATETIMECREATE":z9700.DateTimeCreate = Children(i).Code
   Case "DATECREATE":z9700.DateCreate = Children(i).Code
   Case "FORMNAME":z9700.FormName = Children(i).Code
   Case "ACTIONNAME":z9700.ActionName = Children(i).Code
   Case "REFERENCE":z9700.Reference = Children(i).Code
   Case "DNSDOMAIN":z9700.DNSdomain = Children(i).Code
   Case "DHCPSERVER":z9700.DHCPServer = Children(i).Code
   Case "IPV4ADDRESS":z9700.IPv4Address = Children(i).Code
   Case "IPWAN":z9700.IPWan = Children(i).Code
   Case "MACADDRESS":z9700.MACAddress = Children(i).Code
   Case "HDDSERIALNO":z9700.HDDSerialNo = Children(i).Code
   Case "DEVICENAME":z9700.DeviceName = Children(i).Code
   Case "DESCRIPTION":z9700.Description = Children(i).Code
   Case "ACTIVE":z9700.Active = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "LOGNO":z9700.LogNo = Children(i).Data
   Case "COMPUTERNAME":z9700.ComputerName = Children(i).Data
   Case "ACCOUNTWIN":z9700.AccountWin = Children(i).Data
   Case "USERCODE":z9700.UserCode = Children(i).Data
   Case "DATETIMECREATE":z9700.DateTimeCreate = Children(i).Data
   Case "DATECREATE":z9700.DateCreate = Children(i).Data
   Case "FORMNAME":z9700.FormName = Children(i).Data
   Case "ACTIONNAME":z9700.ActionName = Children(i).Data
   Case "REFERENCE":z9700.Reference = Children(i).Data
   Case "DNSDOMAIN":z9700.DNSdomain = Children(i).Data
   Case "DHCPSERVER":z9700.DHCPServer = Children(i).Data
   Case "IPV4ADDRESS":z9700.IPv4Address = Children(i).Data
   Case "IPWAN":z9700.IPWan = Children(i).Data
   Case "MACADDRESS":z9700.MACAddress = Children(i).Data
   Case "HDDSERIALNO":z9700.HDDSerialNo = Children(i).Data
   Case "DEVICENAME":z9700.DeviceName = Children(i).Data
   Case "DESCRIPTION":z9700.Description = Children(i).Data
   Case "ACTIVE":z9700.Active = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K9700_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K9700_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9700 As T9700_AREA, Job as String, CheckClear as Boolean, LOGNO AS Long) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9700_MOVE = False

Try
    If READ_PFK9700(LOGNO) = True Then
                z9700 = D9700
		K9700_MOVE = True
		else
	If CheckClear  = True then z9700 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9700")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "LOGNO":z9700.LogNo = Children(i).Code
   Case "COMPUTERNAME":z9700.ComputerName = Children(i).Code
   Case "ACCOUNTWIN":z9700.AccountWin = Children(i).Code
   Case "USERCODE":z9700.UserCode = Children(i).Code
   Case "DATETIMECREATE":z9700.DateTimeCreate = Children(i).Code
   Case "DATECREATE":z9700.DateCreate = Children(i).Code
   Case "FORMNAME":z9700.FormName = Children(i).Code
   Case "ACTIONNAME":z9700.ActionName = Children(i).Code
   Case "REFERENCE":z9700.Reference = Children(i).Code
   Case "DNSDOMAIN":z9700.DNSdomain = Children(i).Code
   Case "DHCPSERVER":z9700.DHCPServer = Children(i).Code
   Case "IPV4ADDRESS":z9700.IPv4Address = Children(i).Code
   Case "IPWAN":z9700.IPWan = Children(i).Code
   Case "MACADDRESS":z9700.MACAddress = Children(i).Code
   Case "HDDSERIALNO":z9700.HDDSerialNo = Children(i).Code
   Case "DEVICENAME":z9700.DeviceName = Children(i).Code
   Case "DESCRIPTION":z9700.Description = Children(i).Code
   Case "ACTIVE":z9700.Active = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "LOGNO":z9700.LogNo = Children(i).Data
   Case "COMPUTERNAME":z9700.ComputerName = Children(i).Data
   Case "ACCOUNTWIN":z9700.AccountWin = Children(i).Data
   Case "USERCODE":z9700.UserCode = Children(i).Data
   Case "DATETIMECREATE":z9700.DateTimeCreate = Children(i).Data
   Case "DATECREATE":z9700.DateCreate = Children(i).Data
   Case "FORMNAME":z9700.FormName = Children(i).Data
   Case "ACTIONNAME":z9700.ActionName = Children(i).Data
   Case "REFERENCE":z9700.Reference = Children(i).Data
   Case "DNSDOMAIN":z9700.DNSdomain = Children(i).Data
   Case "DHCPSERVER":z9700.DHCPServer = Children(i).Data
   Case "IPV4ADDRESS":z9700.IPv4Address = Children(i).Data
   Case "IPWAN":z9700.IPWan = Children(i).Data
   Case "MACADDRESS":z9700.MACAddress = Children(i).Data
   Case "HDDSERIALNO":z9700.HDDSerialNo = Children(i).Data
   Case "DEVICENAME":z9700.DeviceName = Children(i).Data
   Case "DESCRIPTION":z9700.Description = Children(i).Data
   Case "ACTIVE":z9700.Active = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K9700_MOVE",vbCritical)
End Try
End Function 
    
End Module 
