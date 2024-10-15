'=========================================================================================================================================================
'   TABLE : (PFK7866)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7866

Structure T7866_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	BugCode	 AS String	'			char(6)		*
Public 	BugCode_001	 AS String	'			nvarchar(20)
Public 	BugCode_002	 AS String	'			nvarchar(20)
Public 	seProject	 AS String	'			char(3)
Public 	cdProject	 AS String	'			char(3)
Public 	seDepartment	 AS String	'			char(3)
Public 	cdDepartment	 AS String	'			char(3)
Public 	seModule	 AS String	'			char(3)
Public 	cdModule	 AS String	'			char(3)
Public 	BugFunction	 AS String	'			nvarchar(100)
Public 	BugName	 AS String	'			nvarchar(100)
Public 	BugContent	 AS String	'			nvarchar(1000)
Public 	BugExplain	 AS String	'			nvarchar(1000)
Public 	CheckDev	 AS String	'			char(1)
Public 	CheckBugType	 AS String	'			char(1)
Public 	CheckRank	 AS String	'			char(1)
Public 	CheckUrgent	 AS String	'			char(1)
Public 	CheckStatus	 AS String	'			char(1)
Public 	DateAccept	 AS String	'			char(8)
Public 	DateStart	 AS String	'			char(8)
Public 	DateFinish	 AS String	'			char(8)
Public 	InchargeAccept	 AS String	'			char(8)
Public 	InchargeConfirm	 AS String	'			char(8)
Public 	InchargeConfirm1	 AS String	'			char(8)
Public 	InchargeConfirm2	 AS String	'			char(8)
Public 	InchargeConfirm3	 AS String	'			char(8)
Public 	InchargeConfirm4	 AS String	'			char(8)
Public 	DateConfirm	 AS String	'			char(8)
Public 	DateConfirm1	 AS String	'			char(8)
Public 	DateConfirm2	 AS String	'			char(8)
Public 	DateConfirm3	 AS String	'			char(8)
Public 	DateConfirm4	 AS String	'			char(8)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	CheckComplete	 AS String	'			char(1)
Public 	Remark	 AS String	'			nvarchar(50)
'=========================================================================================================================================================
End structure

Public D7866 As T7866_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7866(BUGCODE AS String) As Boolean
    READ_PFK7866 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7866 "
    SQL = SQL & " WHERE K7866_BugCode		 = '" & BugCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7866_CLEAR: GoTo SKIP_READ_PFK7866
                
    Call K7866_MOVE(rd)
    READ_PFK7866 = True

SKIP_READ_PFK7866:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7866",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7866(BUGCODE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7866 "
    SQL = SQL & " WHERE K7866_BugCode		 = '" & BugCode & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7866",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7866(z7866 As T7866_AREA) As Boolean
    WRITE_PFK7866 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7866)
 
    SQL = " INSERT INTO PFK7866 "
    SQL = SQL & " ( "
    SQL = SQL & " K7866_BugCode," 
    SQL = SQL & " K7866_BugCode_001," 
    SQL = SQL & " K7866_BugCode_002," 
    SQL = SQL & " K7866_seProject," 
    SQL = SQL & " K7866_cdProject," 
    SQL = SQL & " K7866_seDepartment," 
    SQL = SQL & " K7866_cdDepartment," 
    SQL = SQL & " K7866_seModule," 
    SQL = SQL & " K7866_cdModule," 
    SQL = SQL & " K7866_BugFunction," 
    SQL = SQL & " K7866_BugName," 
    SQL = SQL & " K7866_BugContent," 
    SQL = SQL & " K7866_BugExplain," 
    SQL = SQL & " K7866_CheckDev," 
    SQL = SQL & " K7866_CheckBugType," 
    SQL = SQL & " K7866_CheckRank," 
    SQL = SQL & " K7866_CheckUrgent," 
    SQL = SQL & " K7866_CheckStatus," 
    SQL = SQL & " K7866_DateAccept," 
    SQL = SQL & " K7866_DateStart," 
    SQL = SQL & " K7866_DateFinish," 
    SQL = SQL & " K7866_InchargeAccept," 
    SQL = SQL & " K7866_InchargeConfirm," 
    SQL = SQL & " K7866_InchargeConfirm1," 
    SQL = SQL & " K7866_InchargeConfirm2," 
    SQL = SQL & " K7866_InchargeConfirm3," 
    SQL = SQL & " K7866_InchargeConfirm4," 
    SQL = SQL & " K7866_DateConfirm," 
    SQL = SQL & " K7866_DateConfirm1," 
    SQL = SQL & " K7866_DateConfirm2," 
    SQL = SQL & " K7866_DateConfirm3," 
    SQL = SQL & " K7866_DateConfirm4," 
    SQL = SQL & " K7866_DateInsert," 
    SQL = SQL & " K7866_DateUpdate," 
    SQL = SQL & " K7866_InchargeInsert," 
    SQL = SQL & " K7866_InchargeUpdate," 
    SQL = SQL & " K7866_CheckComplete," 
    SQL = SQL & " K7866_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7866.BugCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7866.BugCode_001) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7866.BugCode_002) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7866.seProject) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7866.cdProject) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7866.seDepartment) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7866.cdDepartment) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7866.seModule) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7866.cdModule) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7866.BugFunction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7866.BugName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7866.BugContent) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7866.BugExplain) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7866.CheckDev) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7866.CheckBugType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7866.CheckRank) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7866.CheckUrgent) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7866.CheckStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7866.DateAccept) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7866.DateStart) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7866.DateFinish) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7866.InchargeAccept) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7866.InchargeConfirm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7866.InchargeConfirm1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7866.InchargeConfirm2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7866.InchargeConfirm3) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7866.InchargeConfirm4) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7866.DateConfirm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7866.DateConfirm1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7866.DateConfirm2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7866.DateConfirm3) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7866.DateConfirm4) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7866.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7866.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7866.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7866.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7866.CheckComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7866.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7866 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7866",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7866(z7866 As T7866_AREA) As Boolean
    REWRITE_PFK7866 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7866)
   
    SQL = " UPDATE PFK7866 SET "
    SQL = SQL & "    K7866_BugCode_001      = N'" & FormatSQL(z7866.BugCode_001) & "', " 
    SQL = SQL & "    K7866_BugCode_002      = N'" & FormatSQL(z7866.BugCode_002) & "', " 
    SQL = SQL & "    K7866_seProject      = N'" & FormatSQL(z7866.seProject) & "', " 
    SQL = SQL & "    K7866_cdProject      = N'" & FormatSQL(z7866.cdProject) & "', " 
    SQL = SQL & "    K7866_seDepartment      = N'" & FormatSQL(z7866.seDepartment) & "', " 
    SQL = SQL & "    K7866_cdDepartment      = N'" & FormatSQL(z7866.cdDepartment) & "', " 
    SQL = SQL & "    K7866_seModule      = N'" & FormatSQL(z7866.seModule) & "', " 
    SQL = SQL & "    K7866_cdModule      = N'" & FormatSQL(z7866.cdModule) & "', " 
    SQL = SQL & "    K7866_BugFunction      = N'" & FormatSQL(z7866.BugFunction) & "', " 
    SQL = SQL & "    K7866_BugName      = N'" & FormatSQL(z7866.BugName) & "', " 
    SQL = SQL & "    K7866_BugContent      = N'" & FormatSQL(z7866.BugContent) & "', " 
    SQL = SQL & "    K7866_BugExplain      = N'" & FormatSQL(z7866.BugExplain) & "', " 
    SQL = SQL & "    K7866_CheckDev      = N'" & FormatSQL(z7866.CheckDev) & "', " 
    SQL = SQL & "    K7866_CheckBugType      = N'" & FormatSQL(z7866.CheckBugType) & "', " 
    SQL = SQL & "    K7866_CheckRank      = N'" & FormatSQL(z7866.CheckRank) & "', " 
    SQL = SQL & "    K7866_CheckUrgent      = N'" & FormatSQL(z7866.CheckUrgent) & "', " 
    SQL = SQL & "    K7866_CheckStatus      = N'" & FormatSQL(z7866.CheckStatus) & "', " 
    SQL = SQL & "    K7866_DateAccept      = N'" & FormatSQL(z7866.DateAccept) & "', " 
    SQL = SQL & "    K7866_DateStart      = N'" & FormatSQL(z7866.DateStart) & "', " 
    SQL = SQL & "    K7866_DateFinish      = N'" & FormatSQL(z7866.DateFinish) & "', " 
    SQL = SQL & "    K7866_InchargeAccept      = N'" & FormatSQL(z7866.InchargeAccept) & "', " 
    SQL = SQL & "    K7866_InchargeConfirm      = N'" & FormatSQL(z7866.InchargeConfirm) & "', " 
    SQL = SQL & "    K7866_InchargeConfirm1      = N'" & FormatSQL(z7866.InchargeConfirm1) & "', " 
    SQL = SQL & "    K7866_InchargeConfirm2      = N'" & FormatSQL(z7866.InchargeConfirm2) & "', " 
    SQL = SQL & "    K7866_InchargeConfirm3      = N'" & FormatSQL(z7866.InchargeConfirm3) & "', " 
    SQL = SQL & "    K7866_InchargeConfirm4      = N'" & FormatSQL(z7866.InchargeConfirm4) & "', " 
    SQL = SQL & "    K7866_DateConfirm      = N'" & FormatSQL(z7866.DateConfirm) & "', " 
    SQL = SQL & "    K7866_DateConfirm1      = N'" & FormatSQL(z7866.DateConfirm1) & "', " 
    SQL = SQL & "    K7866_DateConfirm2      = N'" & FormatSQL(z7866.DateConfirm2) & "', " 
    SQL = SQL & "    K7866_DateConfirm3      = N'" & FormatSQL(z7866.DateConfirm3) & "', " 
    SQL = SQL & "    K7866_DateConfirm4      = N'" & FormatSQL(z7866.DateConfirm4) & "', " 
    SQL = SQL & "    K7866_DateInsert      = N'" & FormatSQL(z7866.DateInsert) & "', " 
    SQL = SQL & "    K7866_DateUpdate      = N'" & FormatSQL(z7866.DateUpdate) & "', " 
    SQL = SQL & "    K7866_InchargeInsert      = N'" & FormatSQL(z7866.InchargeInsert) & "', " 
    SQL = SQL & "    K7866_InchargeUpdate      = N'" & FormatSQL(z7866.InchargeUpdate) & "', " 
    SQL = SQL & "    K7866_CheckComplete      = N'" & FormatSQL(z7866.CheckComplete) & "', " 
    SQL = SQL & "    K7866_Remark      = N'" & FormatSQL(z7866.Remark) & "'  " 
    SQL = SQL & " WHERE K7866_BugCode		 = '" & z7866.BugCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7866 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7866",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7866(z7866 As T7866_AREA) As Boolean
    DELETE_PFK7866 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7866 "
    SQL = SQL & " WHERE K7866_BugCode		 = '" & z7866.BugCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7866 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7866",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7866_CLEAR()
Try
    
   D7866.BugCode = ""
   D7866.BugCode_001 = ""
   D7866.BugCode_002 = ""
   D7866.seProject = ""
   D7866.cdProject = ""
   D7866.seDepartment = ""
   D7866.cdDepartment = ""
   D7866.seModule = ""
   D7866.cdModule = ""
   D7866.BugFunction = ""
   D7866.BugName = ""
   D7866.BugContent = ""
   D7866.BugExplain = ""
   D7866.CheckDev = ""
   D7866.CheckBugType = ""
   D7866.CheckRank = ""
   D7866.CheckUrgent = ""
   D7866.CheckStatus = ""
   D7866.DateAccept = ""
   D7866.DateStart = ""
   D7866.DateFinish = ""
   D7866.InchargeAccept = ""
   D7866.InchargeConfirm = ""
   D7866.InchargeConfirm1 = ""
   D7866.InchargeConfirm2 = ""
   D7866.InchargeConfirm3 = ""
   D7866.InchargeConfirm4 = ""
   D7866.DateConfirm = ""
   D7866.DateConfirm1 = ""
   D7866.DateConfirm2 = ""
   D7866.DateConfirm3 = ""
   D7866.DateConfirm4 = ""
   D7866.DateInsert = ""
   D7866.DateUpdate = ""
   D7866.InchargeInsert = ""
   D7866.InchargeUpdate = ""
   D7866.CheckComplete = ""
   D7866.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7866_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7866 As T7866_AREA)
Try
    
    x7866.BugCode = trim$(  x7866.BugCode)
    x7866.BugCode_001 = trim$(  x7866.BugCode_001)
    x7866.BugCode_002 = trim$(  x7866.BugCode_002)
    x7866.seProject = trim$(  x7866.seProject)
    x7866.cdProject = trim$(  x7866.cdProject)
    x7866.seDepartment = trim$(  x7866.seDepartment)
    x7866.cdDepartment = trim$(  x7866.cdDepartment)
    x7866.seModule = trim$(  x7866.seModule)
    x7866.cdModule = trim$(  x7866.cdModule)
    x7866.BugFunction = trim$(  x7866.BugFunction)
    x7866.BugName = trim$(  x7866.BugName)
    x7866.BugContent = trim$(  x7866.BugContent)
    x7866.BugExplain = trim$(  x7866.BugExplain)
    x7866.CheckDev = trim$(  x7866.CheckDev)
    x7866.CheckBugType = trim$(  x7866.CheckBugType)
    x7866.CheckRank = trim$(  x7866.CheckRank)
    x7866.CheckUrgent = trim$(  x7866.CheckUrgent)
    x7866.CheckStatus = trim$(  x7866.CheckStatus)
    x7866.DateAccept = trim$(  x7866.DateAccept)
    x7866.DateStart = trim$(  x7866.DateStart)
    x7866.DateFinish = trim$(  x7866.DateFinish)
    x7866.InchargeAccept = trim$(  x7866.InchargeAccept)
    x7866.InchargeConfirm = trim$(  x7866.InchargeConfirm)
    x7866.InchargeConfirm1 = trim$(  x7866.InchargeConfirm1)
    x7866.InchargeConfirm2 = trim$(  x7866.InchargeConfirm2)
    x7866.InchargeConfirm3 = trim$(  x7866.InchargeConfirm3)
    x7866.InchargeConfirm4 = trim$(  x7866.InchargeConfirm4)
    x7866.DateConfirm = trim$(  x7866.DateConfirm)
    x7866.DateConfirm1 = trim$(  x7866.DateConfirm1)
    x7866.DateConfirm2 = trim$(  x7866.DateConfirm2)
    x7866.DateConfirm3 = trim$(  x7866.DateConfirm3)
    x7866.DateConfirm4 = trim$(  x7866.DateConfirm4)
    x7866.DateInsert = trim$(  x7866.DateInsert)
    x7866.DateUpdate = trim$(  x7866.DateUpdate)
    x7866.InchargeInsert = trim$(  x7866.InchargeInsert)
    x7866.InchargeUpdate = trim$(  x7866.InchargeUpdate)
    x7866.CheckComplete = trim$(  x7866.CheckComplete)
    x7866.Remark = trim$(  x7866.Remark)
     
    If trim$( x7866.BugCode ) = "" Then x7866.BugCode = Space(1) 
    If trim$( x7866.BugCode_001 ) = "" Then x7866.BugCode_001 = Space(1) 
    If trim$( x7866.BugCode_002 ) = "" Then x7866.BugCode_002 = Space(1) 
    If trim$( x7866.seProject ) = "" Then x7866.seProject = Space(1) 
    If trim$( x7866.cdProject ) = "" Then x7866.cdProject = Space(1) 
    If trim$( x7866.seDepartment ) = "" Then x7866.seDepartment = Space(1) 
    If trim$( x7866.cdDepartment ) = "" Then x7866.cdDepartment = Space(1) 
    If trim$( x7866.seModule ) = "" Then x7866.seModule = Space(1) 
    If trim$( x7866.cdModule ) = "" Then x7866.cdModule = Space(1) 
    If trim$( x7866.BugFunction ) = "" Then x7866.BugFunction = Space(1) 
    If trim$( x7866.BugName ) = "" Then x7866.BugName = Space(1) 
    If trim$( x7866.BugContent ) = "" Then x7866.BugContent = Space(1) 
    If trim$( x7866.BugExplain ) = "" Then x7866.BugExplain = Space(1) 
    If trim$( x7866.CheckDev ) = "" Then x7866.CheckDev = Space(1) 
    If trim$( x7866.CheckBugType ) = "" Then x7866.CheckBugType = Space(1) 
    If trim$( x7866.CheckRank ) = "" Then x7866.CheckRank = Space(1) 
    If trim$( x7866.CheckUrgent ) = "" Then x7866.CheckUrgent = Space(1) 
    If trim$( x7866.CheckStatus ) = "" Then x7866.CheckStatus = Space(1) 
    If trim$( x7866.DateAccept ) = "" Then x7866.DateAccept = Space(1) 
    If trim$( x7866.DateStart ) = "" Then x7866.DateStart = Space(1) 
    If trim$( x7866.DateFinish ) = "" Then x7866.DateFinish = Space(1) 
    If trim$( x7866.InchargeAccept ) = "" Then x7866.InchargeAccept = Space(1) 
    If trim$( x7866.InchargeConfirm ) = "" Then x7866.InchargeConfirm = Space(1) 
    If trim$( x7866.InchargeConfirm1 ) = "" Then x7866.InchargeConfirm1 = Space(1) 
    If trim$( x7866.InchargeConfirm2 ) = "" Then x7866.InchargeConfirm2 = Space(1) 
    If trim$( x7866.InchargeConfirm3 ) = "" Then x7866.InchargeConfirm3 = Space(1) 
    If trim$( x7866.InchargeConfirm4 ) = "" Then x7866.InchargeConfirm4 = Space(1) 
    If trim$( x7866.DateConfirm ) = "" Then x7866.DateConfirm = Space(1) 
    If trim$( x7866.DateConfirm1 ) = "" Then x7866.DateConfirm1 = Space(1) 
    If trim$( x7866.DateConfirm2 ) = "" Then x7866.DateConfirm2 = Space(1) 
    If trim$( x7866.DateConfirm3 ) = "" Then x7866.DateConfirm3 = Space(1) 
    If trim$( x7866.DateConfirm4 ) = "" Then x7866.DateConfirm4 = Space(1) 
    If trim$( x7866.DateInsert ) = "" Then x7866.DateInsert = Space(1) 
    If trim$( x7866.DateUpdate ) = "" Then x7866.DateUpdate = Space(1) 
    If trim$( x7866.InchargeInsert ) = "" Then x7866.InchargeInsert = Space(1) 
    If trim$( x7866.InchargeUpdate ) = "" Then x7866.InchargeUpdate = Space(1) 
    If trim$( x7866.CheckComplete ) = "" Then x7866.CheckComplete = Space(1) 
    If trim$( x7866.Remark ) = "" Then x7866.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7866_MOVE(rs7866 As SqlClient.SqlDataReader)
Try

    call D7866_CLEAR()   

    If IsdbNull(rs7866!K7866_BugCode) = False Then D7866.BugCode = Trim$(rs7866!K7866_BugCode)
    If IsdbNull(rs7866!K7866_BugCode_001) = False Then D7866.BugCode_001 = Trim$(rs7866!K7866_BugCode_001)
    If IsdbNull(rs7866!K7866_BugCode_002) = False Then D7866.BugCode_002 = Trim$(rs7866!K7866_BugCode_002)
    If IsdbNull(rs7866!K7866_seProject) = False Then D7866.seProject = Trim$(rs7866!K7866_seProject)
    If IsdbNull(rs7866!K7866_cdProject) = False Then D7866.cdProject = Trim$(rs7866!K7866_cdProject)
    If IsdbNull(rs7866!K7866_seDepartment) = False Then D7866.seDepartment = Trim$(rs7866!K7866_seDepartment)
    If IsdbNull(rs7866!K7866_cdDepartment) = False Then D7866.cdDepartment = Trim$(rs7866!K7866_cdDepartment)
    If IsdbNull(rs7866!K7866_seModule) = False Then D7866.seModule = Trim$(rs7866!K7866_seModule)
    If IsdbNull(rs7866!K7866_cdModule) = False Then D7866.cdModule = Trim$(rs7866!K7866_cdModule)
    If IsdbNull(rs7866!K7866_BugFunction) = False Then D7866.BugFunction = Trim$(rs7866!K7866_BugFunction)
    If IsdbNull(rs7866!K7866_BugName) = False Then D7866.BugName = Trim$(rs7866!K7866_BugName)
    If IsdbNull(rs7866!K7866_BugContent) = False Then D7866.BugContent = Trim$(rs7866!K7866_BugContent)
    If IsdbNull(rs7866!K7866_BugExplain) = False Then D7866.BugExplain = Trim$(rs7866!K7866_BugExplain)
    If IsdbNull(rs7866!K7866_CheckDev) = False Then D7866.CheckDev = Trim$(rs7866!K7866_CheckDev)
    If IsdbNull(rs7866!K7866_CheckBugType) = False Then D7866.CheckBugType = Trim$(rs7866!K7866_CheckBugType)
    If IsdbNull(rs7866!K7866_CheckRank) = False Then D7866.CheckRank = Trim$(rs7866!K7866_CheckRank)
    If IsdbNull(rs7866!K7866_CheckUrgent) = False Then D7866.CheckUrgent = Trim$(rs7866!K7866_CheckUrgent)
    If IsdbNull(rs7866!K7866_CheckStatus) = False Then D7866.CheckStatus = Trim$(rs7866!K7866_CheckStatus)
    If IsdbNull(rs7866!K7866_DateAccept) = False Then D7866.DateAccept = Trim$(rs7866!K7866_DateAccept)
    If IsdbNull(rs7866!K7866_DateStart) = False Then D7866.DateStart = Trim$(rs7866!K7866_DateStart)
    If IsdbNull(rs7866!K7866_DateFinish) = False Then D7866.DateFinish = Trim$(rs7866!K7866_DateFinish)
    If IsdbNull(rs7866!K7866_InchargeAccept) = False Then D7866.InchargeAccept = Trim$(rs7866!K7866_InchargeAccept)
    If IsdbNull(rs7866!K7866_InchargeConfirm) = False Then D7866.InchargeConfirm = Trim$(rs7866!K7866_InchargeConfirm)
    If IsdbNull(rs7866!K7866_InchargeConfirm1) = False Then D7866.InchargeConfirm1 = Trim$(rs7866!K7866_InchargeConfirm1)
    If IsdbNull(rs7866!K7866_InchargeConfirm2) = False Then D7866.InchargeConfirm2 = Trim$(rs7866!K7866_InchargeConfirm2)
    If IsdbNull(rs7866!K7866_InchargeConfirm3) = False Then D7866.InchargeConfirm3 = Trim$(rs7866!K7866_InchargeConfirm3)
    If IsdbNull(rs7866!K7866_InchargeConfirm4) = False Then D7866.InchargeConfirm4 = Trim$(rs7866!K7866_InchargeConfirm4)
    If IsdbNull(rs7866!K7866_DateConfirm) = False Then D7866.DateConfirm = Trim$(rs7866!K7866_DateConfirm)
    If IsdbNull(rs7866!K7866_DateConfirm1) = False Then D7866.DateConfirm1 = Trim$(rs7866!K7866_DateConfirm1)
    If IsdbNull(rs7866!K7866_DateConfirm2) = False Then D7866.DateConfirm2 = Trim$(rs7866!K7866_DateConfirm2)
    If IsdbNull(rs7866!K7866_DateConfirm3) = False Then D7866.DateConfirm3 = Trim$(rs7866!K7866_DateConfirm3)
    If IsdbNull(rs7866!K7866_DateConfirm4) = False Then D7866.DateConfirm4 = Trim$(rs7866!K7866_DateConfirm4)
    If IsdbNull(rs7866!K7866_DateInsert) = False Then D7866.DateInsert = Trim$(rs7866!K7866_DateInsert)
    If IsdbNull(rs7866!K7866_DateUpdate) = False Then D7866.DateUpdate = Trim$(rs7866!K7866_DateUpdate)
    If IsdbNull(rs7866!K7866_InchargeInsert) = False Then D7866.InchargeInsert = Trim$(rs7866!K7866_InchargeInsert)
    If IsdbNull(rs7866!K7866_InchargeUpdate) = False Then D7866.InchargeUpdate = Trim$(rs7866!K7866_InchargeUpdate)
    If IsdbNull(rs7866!K7866_CheckComplete) = False Then D7866.CheckComplete = Trim$(rs7866!K7866_CheckComplete)
    If IsdbNull(rs7866!K7866_Remark) = False Then D7866.Remark = Trim$(rs7866!K7866_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7866_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7866_MOVE(rs7866 As DataRow)
Try

    call D7866_CLEAR()   

    If IsdbNull(rs7866!K7866_BugCode) = False Then D7866.BugCode = Trim$(rs7866!K7866_BugCode)
    If IsdbNull(rs7866!K7866_BugCode_001) = False Then D7866.BugCode_001 = Trim$(rs7866!K7866_BugCode_001)
    If IsdbNull(rs7866!K7866_BugCode_002) = False Then D7866.BugCode_002 = Trim$(rs7866!K7866_BugCode_002)
    If IsdbNull(rs7866!K7866_seProject) = False Then D7866.seProject = Trim$(rs7866!K7866_seProject)
    If IsdbNull(rs7866!K7866_cdProject) = False Then D7866.cdProject = Trim$(rs7866!K7866_cdProject)
    If IsdbNull(rs7866!K7866_seDepartment) = False Then D7866.seDepartment = Trim$(rs7866!K7866_seDepartment)
    If IsdbNull(rs7866!K7866_cdDepartment) = False Then D7866.cdDepartment = Trim$(rs7866!K7866_cdDepartment)
    If IsdbNull(rs7866!K7866_seModule) = False Then D7866.seModule = Trim$(rs7866!K7866_seModule)
    If IsdbNull(rs7866!K7866_cdModule) = False Then D7866.cdModule = Trim$(rs7866!K7866_cdModule)
    If IsdbNull(rs7866!K7866_BugFunction) = False Then D7866.BugFunction = Trim$(rs7866!K7866_BugFunction)
    If IsdbNull(rs7866!K7866_BugName) = False Then D7866.BugName = Trim$(rs7866!K7866_BugName)
    If IsdbNull(rs7866!K7866_BugContent) = False Then D7866.BugContent = Trim$(rs7866!K7866_BugContent)
    If IsdbNull(rs7866!K7866_BugExplain) = False Then D7866.BugExplain = Trim$(rs7866!K7866_BugExplain)
    If IsdbNull(rs7866!K7866_CheckDev) = False Then D7866.CheckDev = Trim$(rs7866!K7866_CheckDev)
    If IsdbNull(rs7866!K7866_CheckBugType) = False Then D7866.CheckBugType = Trim$(rs7866!K7866_CheckBugType)
    If IsdbNull(rs7866!K7866_CheckRank) = False Then D7866.CheckRank = Trim$(rs7866!K7866_CheckRank)
    If IsdbNull(rs7866!K7866_CheckUrgent) = False Then D7866.CheckUrgent = Trim$(rs7866!K7866_CheckUrgent)
    If IsdbNull(rs7866!K7866_CheckStatus) = False Then D7866.CheckStatus = Trim$(rs7866!K7866_CheckStatus)
    If IsdbNull(rs7866!K7866_DateAccept) = False Then D7866.DateAccept = Trim$(rs7866!K7866_DateAccept)
    If IsdbNull(rs7866!K7866_DateStart) = False Then D7866.DateStart = Trim$(rs7866!K7866_DateStart)
    If IsdbNull(rs7866!K7866_DateFinish) = False Then D7866.DateFinish = Trim$(rs7866!K7866_DateFinish)
    If IsdbNull(rs7866!K7866_InchargeAccept) = False Then D7866.InchargeAccept = Trim$(rs7866!K7866_InchargeAccept)
    If IsdbNull(rs7866!K7866_InchargeConfirm) = False Then D7866.InchargeConfirm = Trim$(rs7866!K7866_InchargeConfirm)
    If IsdbNull(rs7866!K7866_InchargeConfirm1) = False Then D7866.InchargeConfirm1 = Trim$(rs7866!K7866_InchargeConfirm1)
    If IsdbNull(rs7866!K7866_InchargeConfirm2) = False Then D7866.InchargeConfirm2 = Trim$(rs7866!K7866_InchargeConfirm2)
    If IsdbNull(rs7866!K7866_InchargeConfirm3) = False Then D7866.InchargeConfirm3 = Trim$(rs7866!K7866_InchargeConfirm3)
    If IsdbNull(rs7866!K7866_InchargeConfirm4) = False Then D7866.InchargeConfirm4 = Trim$(rs7866!K7866_InchargeConfirm4)
    If IsdbNull(rs7866!K7866_DateConfirm) = False Then D7866.DateConfirm = Trim$(rs7866!K7866_DateConfirm)
    If IsdbNull(rs7866!K7866_DateConfirm1) = False Then D7866.DateConfirm1 = Trim$(rs7866!K7866_DateConfirm1)
    If IsdbNull(rs7866!K7866_DateConfirm2) = False Then D7866.DateConfirm2 = Trim$(rs7866!K7866_DateConfirm2)
    If IsdbNull(rs7866!K7866_DateConfirm3) = False Then D7866.DateConfirm3 = Trim$(rs7866!K7866_DateConfirm3)
    If IsdbNull(rs7866!K7866_DateConfirm4) = False Then D7866.DateConfirm4 = Trim$(rs7866!K7866_DateConfirm4)
    If IsdbNull(rs7866!K7866_DateInsert) = False Then D7866.DateInsert = Trim$(rs7866!K7866_DateInsert)
    If IsdbNull(rs7866!K7866_DateUpdate) = False Then D7866.DateUpdate = Trim$(rs7866!K7866_DateUpdate)
    If IsdbNull(rs7866!K7866_InchargeInsert) = False Then D7866.InchargeInsert = Trim$(rs7866!K7866_InchargeInsert)
    If IsdbNull(rs7866!K7866_InchargeUpdate) = False Then D7866.InchargeUpdate = Trim$(rs7866!K7866_InchargeUpdate)
    If IsdbNull(rs7866!K7866_CheckComplete) = False Then D7866.CheckComplete = Trim$(rs7866!K7866_CheckComplete)
    If IsdbNull(rs7866!K7866_Remark) = False Then D7866.Remark = Trim$(rs7866!K7866_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7866_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7866_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7866 As T7866_AREA, BUGCODE AS String) as Boolean

K7866_MOVE = False

Try
    If READ_PFK7866(BUGCODE) = True Then
                z7866 = D7866
		K7866_MOVE = True
		else
	z7866 = nothing
     End If

     If  getColumIndex(spr,"BugCode") > -1 then z7866.BugCode = getDataM(spr, getColumIndex(spr,"BugCode"), xRow)
     If  getColumIndex(spr,"BugCode_001") > -1 then z7866.BugCode_001 = getDataM(spr, getColumIndex(spr,"BugCode_001"), xRow)
     If  getColumIndex(spr,"BugCode_002") > -1 then z7866.BugCode_002 = getDataM(spr, getColumIndex(spr,"BugCode_002"), xRow)
     If  getColumIndex(spr,"seProject") > -1 then z7866.seProject = getDataM(spr, getColumIndex(spr,"seProject"), xRow)
     If  getColumIndex(spr,"cdProject") > -1 then z7866.cdProject = getDataM(spr, getColumIndex(spr,"cdProject"), xRow)
     If  getColumIndex(spr,"seDepartment") > -1 then z7866.seDepartment = getDataM(spr, getColumIndex(spr,"seDepartment"), xRow)
     If  getColumIndex(spr,"cdDepartment") > -1 then z7866.cdDepartment = getDataM(spr, getColumIndex(spr,"cdDepartment"), xRow)
     If  getColumIndex(spr,"seModule") > -1 then z7866.seModule = getDataM(spr, getColumIndex(spr,"seModule"), xRow)
     If  getColumIndex(spr,"cdModule") > -1 then z7866.cdModule = getDataM(spr, getColumIndex(spr,"cdModule"), xRow)
     If  getColumIndex(spr,"BugFunction") > -1 then z7866.BugFunction = getDataM(spr, getColumIndex(spr,"BugFunction"), xRow)
     If  getColumIndex(spr,"BugName") > -1 then z7866.BugName = getDataM(spr, getColumIndex(spr,"BugName"), xRow)
     If  getColumIndex(spr,"BugContent") > -1 then z7866.BugContent = getDataM(spr, getColumIndex(spr,"BugContent"), xRow)
     If  getColumIndex(spr,"BugExplain") > -1 then z7866.BugExplain = getDataM(spr, getColumIndex(spr,"BugExplain"), xRow)
     If  getColumIndex(spr,"CheckDev") > -1 then z7866.CheckDev = getDataM(spr, getColumIndex(spr,"CheckDev"), xRow)
     If  getColumIndex(spr,"CheckBugType") > -1 then z7866.CheckBugType = getDataM(spr, getColumIndex(spr,"CheckBugType"), xRow)
     If  getColumIndex(spr,"CheckRank") > -1 then z7866.CheckRank = getDataM(spr, getColumIndex(spr,"CheckRank"), xRow)
     If  getColumIndex(spr,"CheckUrgent") > -1 then z7866.CheckUrgent = getDataM(spr, getColumIndex(spr,"CheckUrgent"), xRow)
     If  getColumIndex(spr,"CheckStatus") > -1 then z7866.CheckStatus = getDataM(spr, getColumIndex(spr,"CheckStatus"), xRow)
     If  getColumIndex(spr,"DateAccept") > -1 then z7866.DateAccept = getDataM(spr, getColumIndex(spr,"DateAccept"), xRow)
     If  getColumIndex(spr,"DateStart") > -1 then z7866.DateStart = getDataM(spr, getColumIndex(spr,"DateStart"), xRow)
     If  getColumIndex(spr,"DateFinish") > -1 then z7866.DateFinish = getDataM(spr, getColumIndex(spr,"DateFinish"), xRow)
     If  getColumIndex(spr,"InchargeAccept") > -1 then z7866.InchargeAccept = getDataM(spr, getColumIndex(spr,"InchargeAccept"), xRow)
     If  getColumIndex(spr,"InchargeConfirm") > -1 then z7866.InchargeConfirm = getDataM(spr, getColumIndex(spr,"InchargeConfirm"), xRow)
     If  getColumIndex(spr,"InchargeConfirm1") > -1 then z7866.InchargeConfirm1 = getDataM(spr, getColumIndex(spr,"InchargeConfirm1"), xRow)
     If  getColumIndex(spr,"InchargeConfirm2") > -1 then z7866.InchargeConfirm2 = getDataM(spr, getColumIndex(spr,"InchargeConfirm2"), xRow)
     If  getColumIndex(spr,"InchargeConfirm3") > -1 then z7866.InchargeConfirm3 = getDataM(spr, getColumIndex(spr,"InchargeConfirm3"), xRow)
     If  getColumIndex(spr,"InchargeConfirm4") > -1 then z7866.InchargeConfirm4 = getDataM(spr, getColumIndex(spr,"InchargeConfirm4"), xRow)
     If  getColumIndex(spr,"DateConfirm") > -1 then z7866.DateConfirm = getDataM(spr, getColumIndex(spr,"DateConfirm"), xRow)
     If  getColumIndex(spr,"DateConfirm1") > -1 then z7866.DateConfirm1 = getDataM(spr, getColumIndex(spr,"DateConfirm1"), xRow)
     If  getColumIndex(spr,"DateConfirm2") > -1 then z7866.DateConfirm2 = getDataM(spr, getColumIndex(spr,"DateConfirm2"), xRow)
     If  getColumIndex(spr,"DateConfirm3") > -1 then z7866.DateConfirm3 = getDataM(spr, getColumIndex(spr,"DateConfirm3"), xRow)
     If  getColumIndex(spr,"DateConfirm4") > -1 then z7866.DateConfirm4 = getDataM(spr, getColumIndex(spr,"DateConfirm4"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7866.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7866.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7866.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7866.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z7866.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7866.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7866_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7866_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7866 As T7866_AREA,CheckClear as Boolean,BUGCODE AS String) as Boolean

K7866_MOVE = False

Try
    If READ_PFK7866(BUGCODE) = True Then
                z7866 = D7866
		K7866_MOVE = True
		else
	If CheckClear  = True then z7866 = nothing
     End If

     If  getColumIndex(spr,"BugCode") > -1 then z7866.BugCode = getDataM(spr, getColumIndex(spr,"BugCode"), xRow)
     If  getColumIndex(spr,"BugCode_001") > -1 then z7866.BugCode_001 = getDataM(spr, getColumIndex(spr,"BugCode_001"), xRow)
     If  getColumIndex(spr,"BugCode_002") > -1 then z7866.BugCode_002 = getDataM(spr, getColumIndex(spr,"BugCode_002"), xRow)
     If  getColumIndex(spr,"seProject") > -1 then z7866.seProject = getDataM(spr, getColumIndex(spr,"seProject"), xRow)
     If  getColumIndex(spr,"cdProject") > -1 then z7866.cdProject = getDataM(spr, getColumIndex(spr,"cdProject"), xRow)
     If  getColumIndex(spr,"seDepartment") > -1 then z7866.seDepartment = getDataM(spr, getColumIndex(spr,"seDepartment"), xRow)
     If  getColumIndex(spr,"cdDepartment") > -1 then z7866.cdDepartment = getDataM(spr, getColumIndex(spr,"cdDepartment"), xRow)
     If  getColumIndex(spr,"seModule") > -1 then z7866.seModule = getDataM(spr, getColumIndex(spr,"seModule"), xRow)
     If  getColumIndex(spr,"cdModule") > -1 then z7866.cdModule = getDataM(spr, getColumIndex(spr,"cdModule"), xRow)
     If  getColumIndex(spr,"BugFunction") > -1 then z7866.BugFunction = getDataM(spr, getColumIndex(spr,"BugFunction"), xRow)
     If  getColumIndex(spr,"BugName") > -1 then z7866.BugName = getDataM(spr, getColumIndex(spr,"BugName"), xRow)
     If  getColumIndex(spr,"BugContent") > -1 then z7866.BugContent = getDataM(spr, getColumIndex(spr,"BugContent"), xRow)
     If  getColumIndex(spr,"BugExplain") > -1 then z7866.BugExplain = getDataM(spr, getColumIndex(spr,"BugExplain"), xRow)
     If  getColumIndex(spr,"CheckDev") > -1 then z7866.CheckDev = getDataM(spr, getColumIndex(spr,"CheckDev"), xRow)
     If  getColumIndex(spr,"CheckBugType") > -1 then z7866.CheckBugType = getDataM(spr, getColumIndex(spr,"CheckBugType"), xRow)
     If  getColumIndex(spr,"CheckRank") > -1 then z7866.CheckRank = getDataM(spr, getColumIndex(spr,"CheckRank"), xRow)
     If  getColumIndex(spr,"CheckUrgent") > -1 then z7866.CheckUrgent = getDataM(spr, getColumIndex(spr,"CheckUrgent"), xRow)
     If  getColumIndex(spr,"CheckStatus") > -1 then z7866.CheckStatus = getDataM(spr, getColumIndex(spr,"CheckStatus"), xRow)
     If  getColumIndex(spr,"DateAccept") > -1 then z7866.DateAccept = getDataM(spr, getColumIndex(spr,"DateAccept"), xRow)
     If  getColumIndex(spr,"DateStart") > -1 then z7866.DateStart = getDataM(spr, getColumIndex(spr,"DateStart"), xRow)
     If  getColumIndex(spr,"DateFinish") > -1 then z7866.DateFinish = getDataM(spr, getColumIndex(spr,"DateFinish"), xRow)
     If  getColumIndex(spr,"InchargeAccept") > -1 then z7866.InchargeAccept = getDataM(spr, getColumIndex(spr,"InchargeAccept"), xRow)
     If  getColumIndex(spr,"InchargeConfirm") > -1 then z7866.InchargeConfirm = getDataM(spr, getColumIndex(spr,"InchargeConfirm"), xRow)
     If  getColumIndex(spr,"InchargeConfirm1") > -1 then z7866.InchargeConfirm1 = getDataM(spr, getColumIndex(spr,"InchargeConfirm1"), xRow)
     If  getColumIndex(spr,"InchargeConfirm2") > -1 then z7866.InchargeConfirm2 = getDataM(spr, getColumIndex(spr,"InchargeConfirm2"), xRow)
     If  getColumIndex(spr,"InchargeConfirm3") > -1 then z7866.InchargeConfirm3 = getDataM(spr, getColumIndex(spr,"InchargeConfirm3"), xRow)
     If  getColumIndex(spr,"InchargeConfirm4") > -1 then z7866.InchargeConfirm4 = getDataM(spr, getColumIndex(spr,"InchargeConfirm4"), xRow)
     If  getColumIndex(spr,"DateConfirm") > -1 then z7866.DateConfirm = getDataM(spr, getColumIndex(spr,"DateConfirm"), xRow)
     If  getColumIndex(spr,"DateConfirm1") > -1 then z7866.DateConfirm1 = getDataM(spr, getColumIndex(spr,"DateConfirm1"), xRow)
     If  getColumIndex(spr,"DateConfirm2") > -1 then z7866.DateConfirm2 = getDataM(spr, getColumIndex(spr,"DateConfirm2"), xRow)
     If  getColumIndex(spr,"DateConfirm3") > -1 then z7866.DateConfirm3 = getDataM(spr, getColumIndex(spr,"DateConfirm3"), xRow)
     If  getColumIndex(spr,"DateConfirm4") > -1 then z7866.DateConfirm4 = getDataM(spr, getColumIndex(spr,"DateConfirm4"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7866.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7866.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7866.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7866.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z7866.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7866.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7866_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7866_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7866 As T7866_AREA, Job as String, BUGCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7866_MOVE = False

Try
    If READ_PFK7866(BUGCODE) = True Then
                z7866 = D7866
		K7866_MOVE = True
		else
	z7866 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7866")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "BUGCODE":z7866.BugCode = Children(i).Code
   Case "BUGCODE_001":z7866.BugCode_001 = Children(i).Code
   Case "BUGCODE_002":z7866.BugCode_002 = Children(i).Code
   Case "SEPROJECT":z7866.seProject = Children(i).Code
   Case "CDPROJECT":z7866.cdProject = Children(i).Code
   Case "SEDEPARTMENT":z7866.seDepartment = Children(i).Code
   Case "CDDEPARTMENT":z7866.cdDepartment = Children(i).Code
   Case "SEMODULE":z7866.seModule = Children(i).Code
   Case "CDMODULE":z7866.cdModule = Children(i).Code
   Case "BUGFUNCTION":z7866.BugFunction = Children(i).Code
   Case "BUGNAME":z7866.BugName = Children(i).Code
   Case "BUGCONTENT":z7866.BugContent = Children(i).Code
   Case "BUGEXPLAIN":z7866.BugExplain = Children(i).Code
   Case "CHECKDEV":z7866.CheckDev = Children(i).Code
   Case "CHECKBUGTYPE":z7866.CheckBugType = Children(i).Code
   Case "CHECKRANK":z7866.CheckRank = Children(i).Code
   Case "CHECKURGENT":z7866.CheckUrgent = Children(i).Code
   Case "CHECKSTATUS":z7866.CheckStatus = Children(i).Code
   Case "DATEACCEPT":z7866.DateAccept = Children(i).Code
   Case "DATESTART":z7866.DateStart = Children(i).Code
   Case "DATEFINISH":z7866.DateFinish = Children(i).Code
   Case "INCHARGEACCEPT":z7866.InchargeAccept = Children(i).Code
   Case "INCHARGECONFIRM":z7866.InchargeConfirm = Children(i).Code
   Case "INCHARGECONFIRM1":z7866.InchargeConfirm1 = Children(i).Code
   Case "INCHARGECONFIRM2":z7866.InchargeConfirm2 = Children(i).Code
   Case "INCHARGECONFIRM3":z7866.InchargeConfirm3 = Children(i).Code
   Case "INCHARGECONFIRM4":z7866.InchargeConfirm4 = Children(i).Code
   Case "DATECONFIRM":z7866.DateConfirm = Children(i).Code
   Case "DATECONFIRM1":z7866.DateConfirm1 = Children(i).Code
   Case "DATECONFIRM2":z7866.DateConfirm2 = Children(i).Code
   Case "DATECONFIRM3":z7866.DateConfirm3 = Children(i).Code
   Case "DATECONFIRM4":z7866.DateConfirm4 = Children(i).Code
   Case "DATEINSERT":z7866.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7866.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7866.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7866.InchargeUpdate = Children(i).Code
   Case "CHECKCOMPLETE":z7866.CheckComplete = Children(i).Code
   Case "REMARK":z7866.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "BUGCODE":z7866.BugCode = Children(i).Data
   Case "BUGCODE_001":z7866.BugCode_001 = Children(i).Data
   Case "BUGCODE_002":z7866.BugCode_002 = Children(i).Data
   Case "SEPROJECT":z7866.seProject = Children(i).Data
   Case "CDPROJECT":z7866.cdProject = Children(i).Data
   Case "SEDEPARTMENT":z7866.seDepartment = Children(i).Data
   Case "CDDEPARTMENT":z7866.cdDepartment = Children(i).Data
   Case "SEMODULE":z7866.seModule = Children(i).Data
   Case "CDMODULE":z7866.cdModule = Children(i).Data
   Case "BUGFUNCTION":z7866.BugFunction = Children(i).Data
   Case "BUGNAME":z7866.BugName = Children(i).Data
   Case "BUGCONTENT":z7866.BugContent = Children(i).Data
   Case "BUGEXPLAIN":z7866.BugExplain = Children(i).Data
   Case "CHECKDEV":z7866.CheckDev = Children(i).Data
   Case "CHECKBUGTYPE":z7866.CheckBugType = Children(i).Data
   Case "CHECKRANK":z7866.CheckRank = Children(i).Data
   Case "CHECKURGENT":z7866.CheckUrgent = Children(i).Data
   Case "CHECKSTATUS":z7866.CheckStatus = Children(i).Data
   Case "DATEACCEPT":z7866.DateAccept = Children(i).Data
   Case "DATESTART":z7866.DateStart = Children(i).Data
   Case "DATEFINISH":z7866.DateFinish = Children(i).Data
   Case "INCHARGEACCEPT":z7866.InchargeAccept = Children(i).Data
   Case "INCHARGECONFIRM":z7866.InchargeConfirm = Children(i).Data
   Case "INCHARGECONFIRM1":z7866.InchargeConfirm1 = Children(i).Data
   Case "INCHARGECONFIRM2":z7866.InchargeConfirm2 = Children(i).Data
   Case "INCHARGECONFIRM3":z7866.InchargeConfirm3 = Children(i).Data
   Case "INCHARGECONFIRM4":z7866.InchargeConfirm4 = Children(i).Data
   Case "DATECONFIRM":z7866.DateConfirm = Children(i).Data
   Case "DATECONFIRM1":z7866.DateConfirm1 = Children(i).Data
   Case "DATECONFIRM2":z7866.DateConfirm2 = Children(i).Data
   Case "DATECONFIRM3":z7866.DateConfirm3 = Children(i).Data
   Case "DATECONFIRM4":z7866.DateConfirm4 = Children(i).Data
   Case "DATEINSERT":z7866.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7866.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7866.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7866.InchargeUpdate = Children(i).Data
   Case "CHECKCOMPLETE":z7866.CheckComplete = Children(i).Data
   Case "REMARK":z7866.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7866_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7866_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7866 As T7866_AREA, Job as String, CheckClear as Boolean, BUGCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7866_MOVE = False

Try
    If READ_PFK7866(BUGCODE) = True Then
                z7866 = D7866
		K7866_MOVE = True
		else
	If CheckClear  = True then z7866 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7866")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "BUGCODE":z7866.BugCode = Children(i).Code
   Case "BUGCODE_001":z7866.BugCode_001 = Children(i).Code
   Case "BUGCODE_002":z7866.BugCode_002 = Children(i).Code
   Case "SEPROJECT":z7866.seProject = Children(i).Code
   Case "CDPROJECT":z7866.cdProject = Children(i).Code
   Case "SEDEPARTMENT":z7866.seDepartment = Children(i).Code
   Case "CDDEPARTMENT":z7866.cdDepartment = Children(i).Code
   Case "SEMODULE":z7866.seModule = Children(i).Code
   Case "CDMODULE":z7866.cdModule = Children(i).Code
   Case "BUGFUNCTION":z7866.BugFunction = Children(i).Code
   Case "BUGNAME":z7866.BugName = Children(i).Code
   Case "BUGCONTENT":z7866.BugContent = Children(i).Code
   Case "BUGEXPLAIN":z7866.BugExplain = Children(i).Code
   Case "CHECKDEV":z7866.CheckDev = Children(i).Code
   Case "CHECKBUGTYPE":z7866.CheckBugType = Children(i).Code
   Case "CHECKRANK":z7866.CheckRank = Children(i).Code
   Case "CHECKURGENT":z7866.CheckUrgent = Children(i).Code
   Case "CHECKSTATUS":z7866.CheckStatus = Children(i).Code
   Case "DATEACCEPT":z7866.DateAccept = Children(i).Code
   Case "DATESTART":z7866.DateStart = Children(i).Code
   Case "DATEFINISH":z7866.DateFinish = Children(i).Code
   Case "INCHARGEACCEPT":z7866.InchargeAccept = Children(i).Code
   Case "INCHARGECONFIRM":z7866.InchargeConfirm = Children(i).Code
   Case "INCHARGECONFIRM1":z7866.InchargeConfirm1 = Children(i).Code
   Case "INCHARGECONFIRM2":z7866.InchargeConfirm2 = Children(i).Code
   Case "INCHARGECONFIRM3":z7866.InchargeConfirm3 = Children(i).Code
   Case "INCHARGECONFIRM4":z7866.InchargeConfirm4 = Children(i).Code
   Case "DATECONFIRM":z7866.DateConfirm = Children(i).Code
   Case "DATECONFIRM1":z7866.DateConfirm1 = Children(i).Code
   Case "DATECONFIRM2":z7866.DateConfirm2 = Children(i).Code
   Case "DATECONFIRM3":z7866.DateConfirm3 = Children(i).Code
   Case "DATECONFIRM4":z7866.DateConfirm4 = Children(i).Code
   Case "DATEINSERT":z7866.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7866.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7866.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7866.InchargeUpdate = Children(i).Code
   Case "CHECKCOMPLETE":z7866.CheckComplete = Children(i).Code
   Case "REMARK":z7866.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "BUGCODE":z7866.BugCode = Children(i).Data
   Case "BUGCODE_001":z7866.BugCode_001 = Children(i).Data
   Case "BUGCODE_002":z7866.BugCode_002 = Children(i).Data
   Case "SEPROJECT":z7866.seProject = Children(i).Data
   Case "CDPROJECT":z7866.cdProject = Children(i).Data
   Case "SEDEPARTMENT":z7866.seDepartment = Children(i).Data
   Case "CDDEPARTMENT":z7866.cdDepartment = Children(i).Data
   Case "SEMODULE":z7866.seModule = Children(i).Data
   Case "CDMODULE":z7866.cdModule = Children(i).Data
   Case "BUGFUNCTION":z7866.BugFunction = Children(i).Data
   Case "BUGNAME":z7866.BugName = Children(i).Data
   Case "BUGCONTENT":z7866.BugContent = Children(i).Data
   Case "BUGEXPLAIN":z7866.BugExplain = Children(i).Data
   Case "CHECKDEV":z7866.CheckDev = Children(i).Data
   Case "CHECKBUGTYPE":z7866.CheckBugType = Children(i).Data
   Case "CHECKRANK":z7866.CheckRank = Children(i).Data
   Case "CHECKURGENT":z7866.CheckUrgent = Children(i).Data
   Case "CHECKSTATUS":z7866.CheckStatus = Children(i).Data
   Case "DATEACCEPT":z7866.DateAccept = Children(i).Data
   Case "DATESTART":z7866.DateStart = Children(i).Data
   Case "DATEFINISH":z7866.DateFinish = Children(i).Data
   Case "INCHARGEACCEPT":z7866.InchargeAccept = Children(i).Data
   Case "INCHARGECONFIRM":z7866.InchargeConfirm = Children(i).Data
   Case "INCHARGECONFIRM1":z7866.InchargeConfirm1 = Children(i).Data
   Case "INCHARGECONFIRM2":z7866.InchargeConfirm2 = Children(i).Data
   Case "INCHARGECONFIRM3":z7866.InchargeConfirm3 = Children(i).Data
   Case "INCHARGECONFIRM4":z7866.InchargeConfirm4 = Children(i).Data
   Case "DATECONFIRM":z7866.DateConfirm = Children(i).Data
   Case "DATECONFIRM1":z7866.DateConfirm1 = Children(i).Data
   Case "DATECONFIRM2":z7866.DateConfirm2 = Children(i).Data
   Case "DATECONFIRM3":z7866.DateConfirm3 = Children(i).Data
   Case "DATECONFIRM4":z7866.DateConfirm4 = Children(i).Data
   Case "DATEINSERT":z7866.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7866.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7866.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7866.InchargeUpdate = Children(i).Data
   Case "CHECKCOMPLETE":z7866.CheckComplete = Children(i).Data
   Case "REMARK":z7866.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7866_MOVE",vbCritical)
End Try
End Function 
    
End Module 
