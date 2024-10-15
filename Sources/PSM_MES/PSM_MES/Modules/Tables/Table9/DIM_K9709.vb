'=========================================================================================================================================================
'   TABLE : (PFK9709)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K9709

Structure T9709_AREA
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

Public D9709 As T9709_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK9709(LOGNO AS Long) As Boolean
    READ_PFK9709 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9709 "
    SQL = SQL & " WHERE K9709_LogNo		 =  " & LogNo & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D9709_CLEAR: GoTo SKIP_READ_PFK9709
                
    Call K9709_MOVE(rd)
    READ_PFK9709 = True

SKIP_READ_PFK9709:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK9709",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK9709(LOGNO AS Long, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9709 "
    SQL = SQL & " WHERE K9709_LogNo		 =  " & LogNo & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK9709",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK9709(z9709 As T9709_AREA) As Boolean
    WRITE_PFK9709 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z9709)
 
    SQL = " INSERT INTO PFK9709 "
    SQL = SQL & " ( "
            SQL = SQL & " K9709_ComputerName,"
    SQL = SQL & " K9709_AccountWin," 
    SQL = SQL & " K9709_UserCode," 
    SQL = SQL & " K9709_DateTimeCreate," 
    SQL = SQL & " K9709_DateCreate," 
    SQL = SQL & " K9709_FormName," 
    SQL = SQL & " K9709_ActionName," 
    SQL = SQL & " K9709_Reference," 
    SQL = SQL & " K9709_DNSdomain," 
    SQL = SQL & " K9709_DHCPServer," 
    SQL = SQL & " K9709_IPv4Address," 
    SQL = SQL & " K9709_IPWan," 
    SQL = SQL & " K9709_MACAddress," 
    SQL = SQL & " K9709_HDDSerialNo," 
    SQL = SQL & " K9709_DeviceName," 
    SQL = SQL & " K9709_Description," 
    SQL = SQL & " K9709_Active " 
    SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z9709.ComputerName) & "', "
    SQL = SQL & "  N'" & FormatSQL(z9709.AccountWin) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9709.UserCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9709.DateTimeCreate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9709.DateCreate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9709.FormName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9709.ActionName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9709.Reference) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9709.DNSdomain) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9709.DHCPServer) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9709.IPv4Address) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9709.IPWan) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9709.MACAddress) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9709.HDDSerialNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9709.DeviceName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9709.Description) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9709.Active) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK9709 = True
    Exit Function
Catch ex As Exception
            'Call MsgBoxP("WRITE_PFK9709",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK9709(z9709 As T9709_AREA) As Boolean
    REWRITE_PFK9709 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z9709)
   
    SQL = " UPDATE PFK9709 SET "
    SQL = SQL & "    K9709_ComputerName      = N'" & FormatSQL(z9709.ComputerName) & "', " 
    SQL = SQL & "    K9709_AccountWin      = N'" & FormatSQL(z9709.AccountWin) & "', " 
    SQL = SQL & "    K9709_UserCode      = N'" & FormatSQL(z9709.UserCode) & "', " 
    SQL = SQL & "    K9709_DateTimeCreate      = N'" & FormatSQL(z9709.DateTimeCreate) & "', " 
    SQL = SQL & "    K9709_DateCreate      = N'" & FormatSQL(z9709.DateCreate) & "', " 
    SQL = SQL & "    K9709_FormName      = N'" & FormatSQL(z9709.FormName) & "', " 
    SQL = SQL & "    K9709_ActionName      = N'" & FormatSQL(z9709.ActionName) & "', " 
    SQL = SQL & "    K9709_Reference      = N'" & FormatSQL(z9709.Reference) & "', " 
    SQL = SQL & "    K9709_DNSdomain      = N'" & FormatSQL(z9709.DNSdomain) & "', " 
    SQL = SQL & "    K9709_DHCPServer      = N'" & FormatSQL(z9709.DHCPServer) & "', " 
    SQL = SQL & "    K9709_IPv4Address      = N'" & FormatSQL(z9709.IPv4Address) & "', " 
    SQL = SQL & "    K9709_IPWan      = N'" & FormatSQL(z9709.IPWan) & "', " 
    SQL = SQL & "    K9709_MACAddress      = N'" & FormatSQL(z9709.MACAddress) & "', " 
    SQL = SQL & "    K9709_HDDSerialNo      = N'" & FormatSQL(z9709.HDDSerialNo) & "', " 
    SQL = SQL & "    K9709_DeviceName      = N'" & FormatSQL(z9709.DeviceName) & "', " 
    SQL = SQL & "    K9709_Description      = N'" & FormatSQL(z9709.Description) & "', " 
    SQL = SQL & "    K9709_Active      = N'" & FormatSQL(z9709.Active) & "'  " 
    SQL = SQL & " WHERE K9709_LogNo		 =  " & z9709.LogNo & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK9709 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK9709",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK9709(z9709 As T9709_AREA) As Boolean
    DELETE_PFK9709 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK9709 "
    SQL = SQL & " WHERE K9709_LogNo		 =  " & z9709.LogNo & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK9709 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK9709",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D9709_CLEAR()
Try
    
    D9709.LogNo = 0 
   D9709.ComputerName = ""
   D9709.AccountWin = ""
   D9709.UserCode = ""
   D9709.DateTimeCreate = ""
   D9709.DateCreate = ""
   D9709.FormName = ""
   D9709.ActionName = ""
   D9709.Reference = ""
   D9709.DNSdomain = ""
   D9709.DHCPServer = ""
   D9709.IPv4Address = ""
   D9709.IPWan = ""
   D9709.MACAddress = ""
   D9709.HDDSerialNo = ""
   D9709.DeviceName = ""
   D9709.Description = ""
   D9709.Active = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D9709_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x9709 As T9709_AREA)
Try
    
    x9709.LogNo = trim$(  x9709.LogNo)
    x9709.ComputerName = trim$(  x9709.ComputerName)
    x9709.AccountWin = trim$(  x9709.AccountWin)
    x9709.UserCode = trim$(  x9709.UserCode)
    x9709.DateTimeCreate = trim$(  x9709.DateTimeCreate)
    x9709.DateCreate = trim$(  x9709.DateCreate)
    x9709.FormName = trim$(  x9709.FormName)
    x9709.ActionName = trim$(  x9709.ActionName)
    x9709.Reference = trim$(  x9709.Reference)
    x9709.DNSdomain = trim$(  x9709.DNSdomain)
    x9709.DHCPServer = trim$(  x9709.DHCPServer)
    x9709.IPv4Address = trim$(  x9709.IPv4Address)
    x9709.IPWan = trim$(  x9709.IPWan)
    x9709.MACAddress = trim$(  x9709.MACAddress)
    x9709.HDDSerialNo = trim$(  x9709.HDDSerialNo)
    x9709.DeviceName = trim$(  x9709.DeviceName)
    x9709.Description = trim$(  x9709.Description)
    x9709.Active = trim$(  x9709.Active)
     
    If trim$( x9709.LogNo ) = "" Then x9709.LogNo = 0 
    If trim$( x9709.ComputerName ) = "" Then x9709.ComputerName = Space(1) 
    If trim$( x9709.AccountWin ) = "" Then x9709.AccountWin = Space(1) 
    If trim$( x9709.UserCode ) = "" Then x9709.UserCode = Space(1) 
    If trim$( x9709.DateTimeCreate ) = "" Then x9709.DateTimeCreate = Space(1) 
    If trim$( x9709.DateCreate ) = "" Then x9709.DateCreate = Space(1) 
    If trim$( x9709.FormName ) = "" Then x9709.FormName = Space(1) 
    If trim$( x9709.ActionName ) = "" Then x9709.ActionName = Space(1) 
    If trim$( x9709.Reference ) = "" Then x9709.Reference = Space(1) 
    If trim$( x9709.DNSdomain ) = "" Then x9709.DNSdomain = Space(1) 
    If trim$( x9709.DHCPServer ) = "" Then x9709.DHCPServer = Space(1) 
    If trim$( x9709.IPv4Address ) = "" Then x9709.IPv4Address = Space(1) 
    If trim$( x9709.IPWan ) = "" Then x9709.IPWan = Space(1) 
    If trim$( x9709.MACAddress ) = "" Then x9709.MACAddress = Space(1) 
    If trim$( x9709.HDDSerialNo ) = "" Then x9709.HDDSerialNo = Space(1) 
    If trim$( x9709.DeviceName ) = "" Then x9709.DeviceName = Space(1) 
    If trim$( x9709.Description ) = "" Then x9709.Description = Space(1) 
    If trim$( x9709.Active ) = "" Then x9709.Active = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K9709_MOVE(rs9709 As SqlClient.SqlDataReader)
Try

    call D9709_CLEAR()   

    If IsdbNull(rs9709!K9709_LogNo) = False Then D9709.LogNo = Trim$(rs9709!K9709_LogNo)
    If IsdbNull(rs9709!K9709_ComputerName) = False Then D9709.ComputerName = Trim$(rs9709!K9709_ComputerName)
    If IsdbNull(rs9709!K9709_AccountWin) = False Then D9709.AccountWin = Trim$(rs9709!K9709_AccountWin)
    If IsdbNull(rs9709!K9709_UserCode) = False Then D9709.UserCode = Trim$(rs9709!K9709_UserCode)
    If IsdbNull(rs9709!K9709_DateTimeCreate) = False Then D9709.DateTimeCreate = Trim$(rs9709!K9709_DateTimeCreate)
    If IsdbNull(rs9709!K9709_DateCreate) = False Then D9709.DateCreate = Trim$(rs9709!K9709_DateCreate)
    If IsdbNull(rs9709!K9709_FormName) = False Then D9709.FormName = Trim$(rs9709!K9709_FormName)
    If IsdbNull(rs9709!K9709_ActionName) = False Then D9709.ActionName = Trim$(rs9709!K9709_ActionName)
    If IsdbNull(rs9709!K9709_Reference) = False Then D9709.Reference = Trim$(rs9709!K9709_Reference)
    If IsdbNull(rs9709!K9709_DNSdomain) = False Then D9709.DNSdomain = Trim$(rs9709!K9709_DNSdomain)
    If IsdbNull(rs9709!K9709_DHCPServer) = False Then D9709.DHCPServer = Trim$(rs9709!K9709_DHCPServer)
    If IsdbNull(rs9709!K9709_IPv4Address) = False Then D9709.IPv4Address = Trim$(rs9709!K9709_IPv4Address)
    If IsdbNull(rs9709!K9709_IPWan) = False Then D9709.IPWan = Trim$(rs9709!K9709_IPWan)
    If IsdbNull(rs9709!K9709_MACAddress) = False Then D9709.MACAddress = Trim$(rs9709!K9709_MACAddress)
    If IsdbNull(rs9709!K9709_HDDSerialNo) = False Then D9709.HDDSerialNo = Trim$(rs9709!K9709_HDDSerialNo)
    If IsdbNull(rs9709!K9709_DeviceName) = False Then D9709.DeviceName = Trim$(rs9709!K9709_DeviceName)
    If IsdbNull(rs9709!K9709_Description) = False Then D9709.Description = Trim$(rs9709!K9709_Description)
    If IsdbNull(rs9709!K9709_Active) = False Then D9709.Active = Trim$(rs9709!K9709_Active)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9709_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K9709_MOVE(rs9709 As DataRow)
Try

    call D9709_CLEAR()   

    If IsdbNull(rs9709!K9709_LogNo) = False Then D9709.LogNo = Trim$(rs9709!K9709_LogNo)
    If IsdbNull(rs9709!K9709_ComputerName) = False Then D9709.ComputerName = Trim$(rs9709!K9709_ComputerName)
    If IsdbNull(rs9709!K9709_AccountWin) = False Then D9709.AccountWin = Trim$(rs9709!K9709_AccountWin)
    If IsdbNull(rs9709!K9709_UserCode) = False Then D9709.UserCode = Trim$(rs9709!K9709_UserCode)
    If IsdbNull(rs9709!K9709_DateTimeCreate) = False Then D9709.DateTimeCreate = Trim$(rs9709!K9709_DateTimeCreate)
    If IsdbNull(rs9709!K9709_DateCreate) = False Then D9709.DateCreate = Trim$(rs9709!K9709_DateCreate)
    If IsdbNull(rs9709!K9709_FormName) = False Then D9709.FormName = Trim$(rs9709!K9709_FormName)
    If IsdbNull(rs9709!K9709_ActionName) = False Then D9709.ActionName = Trim$(rs9709!K9709_ActionName)
    If IsdbNull(rs9709!K9709_Reference) = False Then D9709.Reference = Trim$(rs9709!K9709_Reference)
    If IsdbNull(rs9709!K9709_DNSdomain) = False Then D9709.DNSdomain = Trim$(rs9709!K9709_DNSdomain)
    If IsdbNull(rs9709!K9709_DHCPServer) = False Then D9709.DHCPServer = Trim$(rs9709!K9709_DHCPServer)
    If IsdbNull(rs9709!K9709_IPv4Address) = False Then D9709.IPv4Address = Trim$(rs9709!K9709_IPv4Address)
    If IsdbNull(rs9709!K9709_IPWan) = False Then D9709.IPWan = Trim$(rs9709!K9709_IPWan)
    If IsdbNull(rs9709!K9709_MACAddress) = False Then D9709.MACAddress = Trim$(rs9709!K9709_MACAddress)
    If IsdbNull(rs9709!K9709_HDDSerialNo) = False Then D9709.HDDSerialNo = Trim$(rs9709!K9709_HDDSerialNo)
    If IsdbNull(rs9709!K9709_DeviceName) = False Then D9709.DeviceName = Trim$(rs9709!K9709_DeviceName)
    If IsdbNull(rs9709!K9709_Description) = False Then D9709.Description = Trim$(rs9709!K9709_Description)
    If IsdbNull(rs9709!K9709_Active) = False Then D9709.Active = Trim$(rs9709!K9709_Active)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9709_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K9709_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9709 As T9709_AREA, LOGNO AS Long) as Boolean

K9709_MOVE = False

Try
    If READ_PFK9709(LOGNO) = True Then
                z9709 = D9709
		K9709_MOVE = True
		else
	z9709 = nothing
     End If

     If  getColumIndex(spr,"LogNo") > -1 then z9709.LogNo = getDataM(spr, getColumIndex(spr,"LogNo"), xRow)
     If  getColumIndex(spr,"ComputerName") > -1 then z9709.ComputerName = getDataM(spr, getColumIndex(spr,"ComputerName"), xRow)
     If  getColumIndex(spr,"AccountWin") > -1 then z9709.AccountWin = getDataM(spr, getColumIndex(spr,"AccountWin"), xRow)
     If  getColumIndex(spr,"UserCode") > -1 then z9709.UserCode = getDataM(spr, getColumIndex(spr,"UserCode"), xRow)
     If  getColumIndex(spr,"DateTimeCreate") > -1 then z9709.DateTimeCreate = getDataM(spr, getColumIndex(spr,"DateTimeCreate"), xRow)
     If  getColumIndex(spr,"DateCreate") > -1 then z9709.DateCreate = getDataM(spr, getColumIndex(spr,"DateCreate"), xRow)
     If  getColumIndex(spr,"FormName") > -1 then z9709.FormName = getDataM(spr, getColumIndex(spr,"FormName"), xRow)
     If  getColumIndex(spr,"ActionName") > -1 then z9709.ActionName = getDataM(spr, getColumIndex(spr,"ActionName"), xRow)
     If  getColumIndex(spr,"Reference") > -1 then z9709.Reference = getDataM(spr, getColumIndex(spr,"Reference"), xRow)
     If  getColumIndex(spr,"DNSdomain") > -1 then z9709.DNSdomain = getDataM(spr, getColumIndex(spr,"DNSdomain"), xRow)
     If  getColumIndex(spr,"DHCPServer") > -1 then z9709.DHCPServer = getDataM(spr, getColumIndex(spr,"DHCPServer"), xRow)
     If  getColumIndex(spr,"IPv4Address") > -1 then z9709.IPv4Address = getDataM(spr, getColumIndex(spr,"IPv4Address"), xRow)
     If  getColumIndex(spr,"IPWan") > -1 then z9709.IPWan = getDataM(spr, getColumIndex(spr,"IPWan"), xRow)
     If  getColumIndex(spr,"MACAddress") > -1 then z9709.MACAddress = getDataM(spr, getColumIndex(spr,"MACAddress"), xRow)
     If  getColumIndex(spr,"HDDSerialNo") > -1 then z9709.HDDSerialNo = getDataM(spr, getColumIndex(spr,"HDDSerialNo"), xRow)
     If  getColumIndex(spr,"DeviceName") > -1 then z9709.DeviceName = getDataM(spr, getColumIndex(spr,"DeviceName"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z9709.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"Active") > -1 then z9709.Active = getDataM(spr, getColumIndex(spr,"Active"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K9709_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K9709_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9709 As T9709_AREA,CheckClear as Boolean,LOGNO AS Long) as Boolean

K9709_MOVE = False

Try
    If READ_PFK9709(LOGNO) = True Then
                z9709 = D9709
		K9709_MOVE = True
		else
	If CheckClear  = True then z9709 = nothing
     End If

     If  getColumIndex(spr,"LogNo") > -1 then z9709.LogNo = getDataM(spr, getColumIndex(spr,"LogNo"), xRow)
     If  getColumIndex(spr,"ComputerName") > -1 then z9709.ComputerName = getDataM(spr, getColumIndex(spr,"ComputerName"), xRow)
     If  getColumIndex(spr,"AccountWin") > -1 then z9709.AccountWin = getDataM(spr, getColumIndex(spr,"AccountWin"), xRow)
     If  getColumIndex(spr,"UserCode") > -1 then z9709.UserCode = getDataM(spr, getColumIndex(spr,"UserCode"), xRow)
     If  getColumIndex(spr,"DateTimeCreate") > -1 then z9709.DateTimeCreate = getDataM(spr, getColumIndex(spr,"DateTimeCreate"), xRow)
     If  getColumIndex(spr,"DateCreate") > -1 then z9709.DateCreate = getDataM(spr, getColumIndex(spr,"DateCreate"), xRow)
     If  getColumIndex(spr,"FormName") > -1 then z9709.FormName = getDataM(spr, getColumIndex(spr,"FormName"), xRow)
     If  getColumIndex(spr,"ActionName") > -1 then z9709.ActionName = getDataM(spr, getColumIndex(spr,"ActionName"), xRow)
     If  getColumIndex(spr,"Reference") > -1 then z9709.Reference = getDataM(spr, getColumIndex(spr,"Reference"), xRow)
     If  getColumIndex(spr,"DNSdomain") > -1 then z9709.DNSdomain = getDataM(spr, getColumIndex(spr,"DNSdomain"), xRow)
     If  getColumIndex(spr,"DHCPServer") > -1 then z9709.DHCPServer = getDataM(spr, getColumIndex(spr,"DHCPServer"), xRow)
     If  getColumIndex(spr,"IPv4Address") > -1 then z9709.IPv4Address = getDataM(spr, getColumIndex(spr,"IPv4Address"), xRow)
     If  getColumIndex(spr,"IPWan") > -1 then z9709.IPWan = getDataM(spr, getColumIndex(spr,"IPWan"), xRow)
     If  getColumIndex(spr,"MACAddress") > -1 then z9709.MACAddress = getDataM(spr, getColumIndex(spr,"MACAddress"), xRow)
     If  getColumIndex(spr,"HDDSerialNo") > -1 then z9709.HDDSerialNo = getDataM(spr, getColumIndex(spr,"HDDSerialNo"), xRow)
     If  getColumIndex(spr,"DeviceName") > -1 then z9709.DeviceName = getDataM(spr, getColumIndex(spr,"DeviceName"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z9709.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"Active") > -1 then z9709.Active = getDataM(spr, getColumIndex(spr,"Active"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K9709_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K9709_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9709 As T9709_AREA, Job as String, LOGNO AS Long) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9709_MOVE = False

Try
    If READ_PFK9709(LOGNO) = True Then
                z9709 = D9709
		K9709_MOVE = True
		else
	z9709 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9709")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "LOGNO":z9709.LogNo = Children(i).Code
   Case "COMPUTERNAME":z9709.ComputerName = Children(i).Code
   Case "ACCOUNTWIN":z9709.AccountWin = Children(i).Code
   Case "USERCODE":z9709.UserCode = Children(i).Code
   Case "DATETIMECREATE":z9709.DateTimeCreate = Children(i).Code
   Case "DATECREATE":z9709.DateCreate = Children(i).Code
   Case "FORMNAME":z9709.FormName = Children(i).Code
   Case "ACTIONNAME":z9709.ActionName = Children(i).Code
   Case "REFERENCE":z9709.Reference = Children(i).Code
   Case "DNSDOMAIN":z9709.DNSdomain = Children(i).Code
   Case "DHCPSERVER":z9709.DHCPServer = Children(i).Code
   Case "IPV4ADDRESS":z9709.IPv4Address = Children(i).Code
   Case "IPWAN":z9709.IPWan = Children(i).Code
   Case "MACADDRESS":z9709.MACAddress = Children(i).Code
   Case "HDDSERIALNO":z9709.HDDSerialNo = Children(i).Code
   Case "DEVICENAME":z9709.DeviceName = Children(i).Code
   Case "DESCRIPTION":z9709.Description = Children(i).Code
   Case "ACTIVE":z9709.Active = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "LOGNO":z9709.LogNo = Children(i).Data
   Case "COMPUTERNAME":z9709.ComputerName = Children(i).Data
   Case "ACCOUNTWIN":z9709.AccountWin = Children(i).Data
   Case "USERCODE":z9709.UserCode = Children(i).Data
   Case "DATETIMECREATE":z9709.DateTimeCreate = Children(i).Data
   Case "DATECREATE":z9709.DateCreate = Children(i).Data
   Case "FORMNAME":z9709.FormName = Children(i).Data
   Case "ACTIONNAME":z9709.ActionName = Children(i).Data
   Case "REFERENCE":z9709.Reference = Children(i).Data
   Case "DNSDOMAIN":z9709.DNSdomain = Children(i).Data
   Case "DHCPSERVER":z9709.DHCPServer = Children(i).Data
   Case "IPV4ADDRESS":z9709.IPv4Address = Children(i).Data
   Case "IPWAN":z9709.IPWan = Children(i).Data
   Case "MACADDRESS":z9709.MACAddress = Children(i).Data
   Case "HDDSERIALNO":z9709.HDDSerialNo = Children(i).Data
   Case "DEVICENAME":z9709.DeviceName = Children(i).Data
   Case "DESCRIPTION":z9709.Description = Children(i).Data
   Case "ACTIVE":z9709.Active = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K9709_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K9709_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9709 As T9709_AREA, Job as String, CheckClear as Boolean, LOGNO AS Long) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9709_MOVE = False

Try
    If READ_PFK9709(LOGNO) = True Then
                z9709 = D9709
		K9709_MOVE = True
		else
	If CheckClear  = True then z9709 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9709")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "LOGNO":z9709.LogNo = Children(i).Code
   Case "COMPUTERNAME":z9709.ComputerName = Children(i).Code
   Case "ACCOUNTWIN":z9709.AccountWin = Children(i).Code
   Case "USERCODE":z9709.UserCode = Children(i).Code
   Case "DATETIMECREATE":z9709.DateTimeCreate = Children(i).Code
   Case "DATECREATE":z9709.DateCreate = Children(i).Code
   Case "FORMNAME":z9709.FormName = Children(i).Code
   Case "ACTIONNAME":z9709.ActionName = Children(i).Code
   Case "REFERENCE":z9709.Reference = Children(i).Code
   Case "DNSDOMAIN":z9709.DNSdomain = Children(i).Code
   Case "DHCPSERVER":z9709.DHCPServer = Children(i).Code
   Case "IPV4ADDRESS":z9709.IPv4Address = Children(i).Code
   Case "IPWAN":z9709.IPWan = Children(i).Code
   Case "MACADDRESS":z9709.MACAddress = Children(i).Code
   Case "HDDSERIALNO":z9709.HDDSerialNo = Children(i).Code
   Case "DEVICENAME":z9709.DeviceName = Children(i).Code
   Case "DESCRIPTION":z9709.Description = Children(i).Code
   Case "ACTIVE":z9709.Active = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "LOGNO":z9709.LogNo = Children(i).Data
   Case "COMPUTERNAME":z9709.ComputerName = Children(i).Data
   Case "ACCOUNTWIN":z9709.AccountWin = Children(i).Data
   Case "USERCODE":z9709.UserCode = Children(i).Data
   Case "DATETIMECREATE":z9709.DateTimeCreate = Children(i).Data
   Case "DATECREATE":z9709.DateCreate = Children(i).Data
   Case "FORMNAME":z9709.FormName = Children(i).Data
   Case "ACTIONNAME":z9709.ActionName = Children(i).Data
   Case "REFERENCE":z9709.Reference = Children(i).Data
   Case "DNSDOMAIN":z9709.DNSdomain = Children(i).Data
   Case "DHCPSERVER":z9709.DHCPServer = Children(i).Data
   Case "IPV4ADDRESS":z9709.IPv4Address = Children(i).Data
   Case "IPWAN":z9709.IPWan = Children(i).Data
   Case "MACADDRESS":z9709.MACAddress = Children(i).Data
   Case "HDDSERIALNO":z9709.HDDSerialNo = Children(i).Data
   Case "DEVICENAME":z9709.DeviceName = Children(i).Data
   Case "DESCRIPTION":z9709.Description = Children(i).Data
   Case "ACTIVE":z9709.Active = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K9709_MOVE",vbCritical)
End Try
End Function 
    
End Module 
