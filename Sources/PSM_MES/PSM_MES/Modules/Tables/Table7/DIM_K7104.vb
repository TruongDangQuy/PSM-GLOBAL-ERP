'=========================================================================================================================================================
'   TABLE : (PFK7104)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7104

Structure T7104_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	SizeRange	 AS String	'			char(6)		*
Public 	CustomerCode	 AS String	'			char(6)
Public 	SizeRangeName	 AS String	'			nvarchar(100)
Public 	SizeRangeSimpleName	 AS String	'			nvarchar(100)
Public 	seGender	 AS String	'			char(3)
Public 	cdGender	 AS String	'			char(3)
Public 	seSeason	 AS String	'			char(3)
Public 	cdSeason	 AS String	'			char(3)
Public 	SizeAverage01	 AS String	'			nvarchar(10)
Public 	SizeAverage02	 AS String	'			nvarchar(10)
Public 	SizeAverage03	 AS String	'			nvarchar(10)
Public 	SizeAverage04	 AS String	'			nvarchar(10)
Public 	SizeAverage05	 AS String	'			nvarchar(10)
Public 	Size01	 AS String	'			nvarchar(10)
Public 	Size02	 AS String	'			nvarchar(10)
Public 	Size03	 AS String	'			nvarchar(10)
Public 	Size04	 AS String	'			nvarchar(10)
Public 	Size05	 AS String	'			nvarchar(10)
Public 	Size06	 AS String	'			nvarchar(10)
Public 	Size07	 AS String	'			nvarchar(10)
Public 	Size08	 AS String	'			nvarchar(10)
Public 	Size09	 AS String	'			nvarchar(10)
Public 	Size10	 AS String	'			nvarchar(10)
Public 	Size11	 AS String	'			nvarchar(10)
Public 	Size12	 AS String	'			nvarchar(10)
Public 	Size13	 AS String	'			nvarchar(10)
Public 	Size14	 AS String	'			nvarchar(10)
Public 	Size15	 AS String	'			nvarchar(10)
Public 	Size16	 AS String	'			nvarchar(10)
Public 	Size17	 AS String	'			nvarchar(10)
Public 	Size18	 AS String	'			nvarchar(10)
Public 	Size19	 AS String	'			nvarchar(10)
Public 	Size20	 AS String	'			nvarchar(10)
Public 	Size21	 AS String	'			nvarchar(10)
Public 	Size22	 AS String	'			nvarchar(10)
Public 	Size23	 AS String	'			nvarchar(10)
Public 	Size24	 AS String	'			nvarchar(10)
Public 	Size25	 AS String	'			nvarchar(10)
Public 	Size26	 AS String	'			nvarchar(10)
Public 	Size27	 AS String	'			nvarchar(10)
Public 	Size28	 AS String	'			nvarchar(10)
Public 	Size29	 AS String	'			nvarchar(10)
Public 	Size30	 AS String	'			nvarchar(10)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(6)
Public 	InchargeUpdate	 AS String	'			char(6)
Public 	CheckUse	 AS String	'			char(1)
Public 	CheckComplete	 AS String	'			char(1)
Public 	Remark	 AS String	'			nvarchar(500)
'=========================================================================================================================================================
End structure

Public D7104 As T7104_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7104(SIZERANGE AS String) As Boolean
    READ_PFK7104 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7104 "
    SQL = SQL & " WHERE K7104_SizeRange		 = '" & SizeRange & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7104_CLEAR: GoTo SKIP_READ_PFK7104
                
    Call K7104_MOVE(rd)
    READ_PFK7104 = True

SKIP_READ_PFK7104:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7104",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7104(SIZERANGE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7104 "
    SQL = SQL & " WHERE K7104_SizeRange		 = '" & SizeRange & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7104",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7104(z7104 As T7104_AREA) As Boolean
    WRITE_PFK7104 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7104)
 
    SQL = " INSERT INTO PFK7104 "
    SQL = SQL & " ( "
    SQL = SQL & " K7104_SizeRange," 
    SQL = SQL & " K7104_CustomerCode," 
    SQL = SQL & " K7104_SizeRangeName," 
    SQL = SQL & " K7104_SizeRangeSimpleName," 
    SQL = SQL & " K7104_seGender," 
    SQL = SQL & " K7104_cdGender," 
    SQL = SQL & " K7104_seSeason," 
    SQL = SQL & " K7104_cdSeason," 
    SQL = SQL & " K7104_SizeAverage01," 
    SQL = SQL & " K7104_SizeAverage02," 
    SQL = SQL & " K7104_SizeAverage03," 
    SQL = SQL & " K7104_SizeAverage04," 
    SQL = SQL & " K7104_SizeAverage05," 
    SQL = SQL & " K7104_Size01," 
    SQL = SQL & " K7104_Size02," 
    SQL = SQL & " K7104_Size03," 
    SQL = SQL & " K7104_Size04," 
    SQL = SQL & " K7104_Size05," 
    SQL = SQL & " K7104_Size06," 
    SQL = SQL & " K7104_Size07," 
    SQL = SQL & " K7104_Size08," 
    SQL = SQL & " K7104_Size09," 
    SQL = SQL & " K7104_Size10," 
    SQL = SQL & " K7104_Size11," 
    SQL = SQL & " K7104_Size12," 
    SQL = SQL & " K7104_Size13," 
    SQL = SQL & " K7104_Size14," 
    SQL = SQL & " K7104_Size15," 
    SQL = SQL & " K7104_Size16," 
    SQL = SQL & " K7104_Size17," 
    SQL = SQL & " K7104_Size18," 
    SQL = SQL & " K7104_Size19," 
    SQL = SQL & " K7104_Size20," 
    SQL = SQL & " K7104_Size21," 
    SQL = SQL & " K7104_Size22," 
    SQL = SQL & " K7104_Size23," 
    SQL = SQL & " K7104_Size24," 
    SQL = SQL & " K7104_Size25," 
    SQL = SQL & " K7104_Size26," 
    SQL = SQL & " K7104_Size27," 
    SQL = SQL & " K7104_Size28," 
    SQL = SQL & " K7104_Size29," 
    SQL = SQL & " K7104_Size30," 
    SQL = SQL & " K7104_DateInsert," 
    SQL = SQL & " K7104_DateUpdate," 
    SQL = SQL & " K7104_InchargeInsert," 
    SQL = SQL & " K7104_InchargeUpdate," 
    SQL = SQL & " K7104_CheckUse," 
    SQL = SQL & " K7104_CheckComplete," 
    SQL = SQL & " K7104_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7104.SizeRange) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.CustomerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.SizeRangeName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.SizeRangeSimpleName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.seGender) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.cdGender) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.seSeason) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.cdSeason) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.SizeAverage01) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.SizeAverage02) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.SizeAverage03) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.SizeAverage04) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.SizeAverage05) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.Size01) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.Size02) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.Size03) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.Size04) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.Size05) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.Size06) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.Size07) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.Size08) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.Size09) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.Size10) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.Size11) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.Size12) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.Size13) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.Size14) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.Size15) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.Size16) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.Size17) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.Size18) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.Size19) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.Size20) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.Size21) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.Size22) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.Size23) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.Size24) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.Size25) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.Size26) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.Size27) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.Size28) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.Size29) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.Size30) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.CheckUse) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.CheckComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7104.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7104 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7104",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7104(z7104 As T7104_AREA) As Boolean
    REWRITE_PFK7104 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7104)
   
    SQL = " UPDATE PFK7104 SET "
    SQL = SQL & "    K7104_CustomerCode      = N'" & FormatSQL(z7104.CustomerCode) & "', " 
    SQL = SQL & "    K7104_SizeRangeName      = N'" & FormatSQL(z7104.SizeRangeName) & "', " 
    SQL = SQL & "    K7104_SizeRangeSimpleName      = N'" & FormatSQL(z7104.SizeRangeSimpleName) & "', " 
    SQL = SQL & "    K7104_seGender      = N'" & FormatSQL(z7104.seGender) & "', " 
    SQL = SQL & "    K7104_cdGender      = N'" & FormatSQL(z7104.cdGender) & "', " 
    SQL = SQL & "    K7104_seSeason      = N'" & FormatSQL(z7104.seSeason) & "', " 
    SQL = SQL & "    K7104_cdSeason      = N'" & FormatSQL(z7104.cdSeason) & "', " 
    SQL = SQL & "    K7104_SizeAverage01      = N'" & FormatSQL(z7104.SizeAverage01) & "', " 
    SQL = SQL & "    K7104_SizeAverage02      = N'" & FormatSQL(z7104.SizeAverage02) & "', " 
    SQL = SQL & "    K7104_SizeAverage03      = N'" & FormatSQL(z7104.SizeAverage03) & "', " 
    SQL = SQL & "    K7104_SizeAverage04      = N'" & FormatSQL(z7104.SizeAverage04) & "', " 
    SQL = SQL & "    K7104_SizeAverage05      = N'" & FormatSQL(z7104.SizeAverage05) & "', " 
    SQL = SQL & "    K7104_Size01      = N'" & FormatSQL(z7104.Size01) & "', " 
    SQL = SQL & "    K7104_Size02      = N'" & FormatSQL(z7104.Size02) & "', " 
    SQL = SQL & "    K7104_Size03      = N'" & FormatSQL(z7104.Size03) & "', " 
    SQL = SQL & "    K7104_Size04      = N'" & FormatSQL(z7104.Size04) & "', " 
    SQL = SQL & "    K7104_Size05      = N'" & FormatSQL(z7104.Size05) & "', " 
    SQL = SQL & "    K7104_Size06      = N'" & FormatSQL(z7104.Size06) & "', " 
    SQL = SQL & "    K7104_Size07      = N'" & FormatSQL(z7104.Size07) & "', " 
    SQL = SQL & "    K7104_Size08      = N'" & FormatSQL(z7104.Size08) & "', " 
    SQL = SQL & "    K7104_Size09      = N'" & FormatSQL(z7104.Size09) & "', " 
    SQL = SQL & "    K7104_Size10      = N'" & FormatSQL(z7104.Size10) & "', " 
    SQL = SQL & "    K7104_Size11      = N'" & FormatSQL(z7104.Size11) & "', " 
    SQL = SQL & "    K7104_Size12      = N'" & FormatSQL(z7104.Size12) & "', " 
    SQL = SQL & "    K7104_Size13      = N'" & FormatSQL(z7104.Size13) & "', " 
    SQL = SQL & "    K7104_Size14      = N'" & FormatSQL(z7104.Size14) & "', " 
    SQL = SQL & "    K7104_Size15      = N'" & FormatSQL(z7104.Size15) & "', " 
    SQL = SQL & "    K7104_Size16      = N'" & FormatSQL(z7104.Size16) & "', " 
    SQL = SQL & "    K7104_Size17      = N'" & FormatSQL(z7104.Size17) & "', " 
    SQL = SQL & "    K7104_Size18      = N'" & FormatSQL(z7104.Size18) & "', " 
    SQL = SQL & "    K7104_Size19      = N'" & FormatSQL(z7104.Size19) & "', " 
    SQL = SQL & "    K7104_Size20      = N'" & FormatSQL(z7104.Size20) & "', " 
    SQL = SQL & "    K7104_Size21      = N'" & FormatSQL(z7104.Size21) & "', " 
    SQL = SQL & "    K7104_Size22      = N'" & FormatSQL(z7104.Size22) & "', " 
    SQL = SQL & "    K7104_Size23      = N'" & FormatSQL(z7104.Size23) & "', " 
    SQL = SQL & "    K7104_Size24      = N'" & FormatSQL(z7104.Size24) & "', " 
    SQL = SQL & "    K7104_Size25      = N'" & FormatSQL(z7104.Size25) & "', " 
    SQL = SQL & "    K7104_Size26      = N'" & FormatSQL(z7104.Size26) & "', " 
    SQL = SQL & "    K7104_Size27      = N'" & FormatSQL(z7104.Size27) & "', " 
    SQL = SQL & "    K7104_Size28      = N'" & FormatSQL(z7104.Size28) & "', " 
    SQL = SQL & "    K7104_Size29      = N'" & FormatSQL(z7104.Size29) & "', " 
    SQL = SQL & "    K7104_Size30      = N'" & FormatSQL(z7104.Size30) & "', " 
    SQL = SQL & "    K7104_DateInsert      = N'" & FormatSQL(z7104.DateInsert) & "', " 
    SQL = SQL & "    K7104_DateUpdate      = N'" & FormatSQL(z7104.DateUpdate) & "', " 
    SQL = SQL & "    K7104_InchargeInsert      = N'" & FormatSQL(z7104.InchargeInsert) & "', " 
    SQL = SQL & "    K7104_InchargeUpdate      = N'" & FormatSQL(z7104.InchargeUpdate) & "', " 
    SQL = SQL & "    K7104_CheckUse      = N'" & FormatSQL(z7104.CheckUse) & "', " 
    SQL = SQL & "    K7104_CheckComplete      = N'" & FormatSQL(z7104.CheckComplete) & "', " 
    SQL = SQL & "    K7104_Remark      = N'" & FormatSQL(z7104.Remark) & "'  " 
    SQL = SQL & " WHERE K7104_SizeRange		 = '" & z7104.SizeRange & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7104 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7104",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7104(z7104 As T7104_AREA) As Boolean
    DELETE_PFK7104 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7104 "
    SQL = SQL & " WHERE K7104_SizeRange		 = '" & z7104.SizeRange & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7104 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7104",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7104_CLEAR()
Try
    
   D7104.SizeRange = ""
   D7104.CustomerCode = ""
   D7104.SizeRangeName = ""
   D7104.SizeRangeSimpleName = ""
   D7104.seGender = ""
   D7104.cdGender = ""
   D7104.seSeason = ""
   D7104.cdSeason = ""
   D7104.SizeAverage01 = ""
   D7104.SizeAverage02 = ""
   D7104.SizeAverage03 = ""
   D7104.SizeAverage04 = ""
   D7104.SizeAverage05 = ""
   D7104.Size01 = ""
   D7104.Size02 = ""
   D7104.Size03 = ""
   D7104.Size04 = ""
   D7104.Size05 = ""
   D7104.Size06 = ""
   D7104.Size07 = ""
   D7104.Size08 = ""
   D7104.Size09 = ""
   D7104.Size10 = ""
   D7104.Size11 = ""
   D7104.Size12 = ""
   D7104.Size13 = ""
   D7104.Size14 = ""
   D7104.Size15 = ""
   D7104.Size16 = ""
   D7104.Size17 = ""
   D7104.Size18 = ""
   D7104.Size19 = ""
   D7104.Size20 = ""
   D7104.Size21 = ""
   D7104.Size22 = ""
   D7104.Size23 = ""
   D7104.Size24 = ""
   D7104.Size25 = ""
   D7104.Size26 = ""
   D7104.Size27 = ""
   D7104.Size28 = ""
   D7104.Size29 = ""
   D7104.Size30 = ""
   D7104.DateInsert = ""
   D7104.DateUpdate = ""
   D7104.InchargeInsert = ""
   D7104.InchargeUpdate = ""
   D7104.CheckUse = ""
   D7104.CheckComplete = ""
   D7104.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7104_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7104 As T7104_AREA)
Try
    
    x7104.SizeRange = trim$(  x7104.SizeRange)
    x7104.CustomerCode = trim$(  x7104.CustomerCode)
    x7104.SizeRangeName = trim$(  x7104.SizeRangeName)
    x7104.SizeRangeSimpleName = trim$(  x7104.SizeRangeSimpleName)
    x7104.seGender = trim$(  x7104.seGender)
    x7104.cdGender = trim$(  x7104.cdGender)
    x7104.seSeason = trim$(  x7104.seSeason)
    x7104.cdSeason = trim$(  x7104.cdSeason)
    x7104.SizeAverage01 = trim$(  x7104.SizeAverage01)
    x7104.SizeAverage02 = trim$(  x7104.SizeAverage02)
    x7104.SizeAverage03 = trim$(  x7104.SizeAverage03)
    x7104.SizeAverage04 = trim$(  x7104.SizeAverage04)
    x7104.SizeAverage05 = trim$(  x7104.SizeAverage05)
    x7104.Size01 = trim$(  x7104.Size01)
    x7104.Size02 = trim$(  x7104.Size02)
    x7104.Size03 = trim$(  x7104.Size03)
    x7104.Size04 = trim$(  x7104.Size04)
    x7104.Size05 = trim$(  x7104.Size05)
    x7104.Size06 = trim$(  x7104.Size06)
    x7104.Size07 = trim$(  x7104.Size07)
    x7104.Size08 = trim$(  x7104.Size08)
    x7104.Size09 = trim$(  x7104.Size09)
    x7104.Size10 = trim$(  x7104.Size10)
    x7104.Size11 = trim$(  x7104.Size11)
    x7104.Size12 = trim$(  x7104.Size12)
    x7104.Size13 = trim$(  x7104.Size13)
    x7104.Size14 = trim$(  x7104.Size14)
    x7104.Size15 = trim$(  x7104.Size15)
    x7104.Size16 = trim$(  x7104.Size16)
    x7104.Size17 = trim$(  x7104.Size17)
    x7104.Size18 = trim$(  x7104.Size18)
    x7104.Size19 = trim$(  x7104.Size19)
    x7104.Size20 = trim$(  x7104.Size20)
    x7104.Size21 = trim$(  x7104.Size21)
    x7104.Size22 = trim$(  x7104.Size22)
    x7104.Size23 = trim$(  x7104.Size23)
    x7104.Size24 = trim$(  x7104.Size24)
    x7104.Size25 = trim$(  x7104.Size25)
    x7104.Size26 = trim$(  x7104.Size26)
    x7104.Size27 = trim$(  x7104.Size27)
    x7104.Size28 = trim$(  x7104.Size28)
    x7104.Size29 = trim$(  x7104.Size29)
    x7104.Size30 = trim$(  x7104.Size30)
    x7104.DateInsert = trim$(  x7104.DateInsert)
    x7104.DateUpdate = trim$(  x7104.DateUpdate)
    x7104.InchargeInsert = trim$(  x7104.InchargeInsert)
    x7104.InchargeUpdate = trim$(  x7104.InchargeUpdate)
    x7104.CheckUse = trim$(  x7104.CheckUse)
    x7104.CheckComplete = trim$(  x7104.CheckComplete)
    x7104.Remark = trim$(  x7104.Remark)
     
    If trim$( x7104.SizeRange ) = "" Then x7104.SizeRange = Space(1) 
    If trim$( x7104.CustomerCode ) = "" Then x7104.CustomerCode = Space(1) 
    If trim$( x7104.SizeRangeName ) = "" Then x7104.SizeRangeName = Space(1) 
    If trim$( x7104.SizeRangeSimpleName ) = "" Then x7104.SizeRangeSimpleName = Space(1) 
    If trim$( x7104.seGender ) = "" Then x7104.seGender = Space(1) 
    If trim$( x7104.cdGender ) = "" Then x7104.cdGender = Space(1) 
    If trim$( x7104.seSeason ) = "" Then x7104.seSeason = Space(1) 
    If trim$( x7104.cdSeason ) = "" Then x7104.cdSeason = Space(1) 
    If trim$( x7104.SizeAverage01 ) = "" Then x7104.SizeAverage01 = Space(1) 
    If trim$( x7104.SizeAverage02 ) = "" Then x7104.SizeAverage02 = Space(1) 
    If trim$( x7104.SizeAverage03 ) = "" Then x7104.SizeAverage03 = Space(1) 
    If trim$( x7104.SizeAverage04 ) = "" Then x7104.SizeAverage04 = Space(1) 
    If trim$( x7104.SizeAverage05 ) = "" Then x7104.SizeAverage05 = Space(1) 
    If trim$( x7104.Size01 ) = "" Then x7104.Size01 = Space(1) 
    If trim$( x7104.Size02 ) = "" Then x7104.Size02 = Space(1) 
    If trim$( x7104.Size03 ) = "" Then x7104.Size03 = Space(1) 
    If trim$( x7104.Size04 ) = "" Then x7104.Size04 = Space(1) 
    If trim$( x7104.Size05 ) = "" Then x7104.Size05 = Space(1) 
    If trim$( x7104.Size06 ) = "" Then x7104.Size06 = Space(1) 
    If trim$( x7104.Size07 ) = "" Then x7104.Size07 = Space(1) 
    If trim$( x7104.Size08 ) = "" Then x7104.Size08 = Space(1) 
    If trim$( x7104.Size09 ) = "" Then x7104.Size09 = Space(1) 
    If trim$( x7104.Size10 ) = "" Then x7104.Size10 = Space(1) 
    If trim$( x7104.Size11 ) = "" Then x7104.Size11 = Space(1) 
    If trim$( x7104.Size12 ) = "" Then x7104.Size12 = Space(1) 
    If trim$( x7104.Size13 ) = "" Then x7104.Size13 = Space(1) 
    If trim$( x7104.Size14 ) = "" Then x7104.Size14 = Space(1) 
    If trim$( x7104.Size15 ) = "" Then x7104.Size15 = Space(1) 
    If trim$( x7104.Size16 ) = "" Then x7104.Size16 = Space(1) 
    If trim$( x7104.Size17 ) = "" Then x7104.Size17 = Space(1) 
    If trim$( x7104.Size18 ) = "" Then x7104.Size18 = Space(1) 
    If trim$( x7104.Size19 ) = "" Then x7104.Size19 = Space(1) 
    If trim$( x7104.Size20 ) = "" Then x7104.Size20 = Space(1) 
    If trim$( x7104.Size21 ) = "" Then x7104.Size21 = Space(1) 
    If trim$( x7104.Size22 ) = "" Then x7104.Size22 = Space(1) 
    If trim$( x7104.Size23 ) = "" Then x7104.Size23 = Space(1) 
    If trim$( x7104.Size24 ) = "" Then x7104.Size24 = Space(1) 
    If trim$( x7104.Size25 ) = "" Then x7104.Size25 = Space(1) 
    If trim$( x7104.Size26 ) = "" Then x7104.Size26 = Space(1) 
    If trim$( x7104.Size27 ) = "" Then x7104.Size27 = Space(1) 
    If trim$( x7104.Size28 ) = "" Then x7104.Size28 = Space(1) 
    If trim$( x7104.Size29 ) = "" Then x7104.Size29 = Space(1) 
    If trim$( x7104.Size30 ) = "" Then x7104.Size30 = Space(1) 
    If trim$( x7104.DateInsert ) = "" Then x7104.DateInsert = Space(1) 
    If trim$( x7104.DateUpdate ) = "" Then x7104.DateUpdate = Space(1) 
    If trim$( x7104.InchargeInsert ) = "" Then x7104.InchargeInsert = Space(1) 
    If trim$( x7104.InchargeUpdate ) = "" Then x7104.InchargeUpdate = Space(1) 
    If trim$( x7104.CheckUse ) = "" Then x7104.CheckUse = Space(1) 
    If trim$( x7104.CheckComplete ) = "" Then x7104.CheckComplete = Space(1) 
    If trim$( x7104.Remark ) = "" Then x7104.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7104_MOVE(rs7104 As SqlClient.SqlDataReader)
Try

    call D7104_CLEAR()   

    If IsdbNull(rs7104!K7104_SizeRange) = False Then D7104.SizeRange = Trim$(rs7104!K7104_SizeRange)
    If IsdbNull(rs7104!K7104_CustomerCode) = False Then D7104.CustomerCode = Trim$(rs7104!K7104_CustomerCode)
    If IsdbNull(rs7104!K7104_SizeRangeName) = False Then D7104.SizeRangeName = Trim$(rs7104!K7104_SizeRangeName)
    If IsdbNull(rs7104!K7104_SizeRangeSimpleName) = False Then D7104.SizeRangeSimpleName = Trim$(rs7104!K7104_SizeRangeSimpleName)
    If IsdbNull(rs7104!K7104_seGender) = False Then D7104.seGender = Trim$(rs7104!K7104_seGender)
    If IsdbNull(rs7104!K7104_cdGender) = False Then D7104.cdGender = Trim$(rs7104!K7104_cdGender)
    If IsdbNull(rs7104!K7104_seSeason) = False Then D7104.seSeason = Trim$(rs7104!K7104_seSeason)
    If IsdbNull(rs7104!K7104_cdSeason) = False Then D7104.cdSeason = Trim$(rs7104!K7104_cdSeason)
    If IsdbNull(rs7104!K7104_SizeAverage01) = False Then D7104.SizeAverage01 = Trim$(rs7104!K7104_SizeAverage01)
    If IsdbNull(rs7104!K7104_SizeAverage02) = False Then D7104.SizeAverage02 = Trim$(rs7104!K7104_SizeAverage02)
    If IsdbNull(rs7104!K7104_SizeAverage03) = False Then D7104.SizeAverage03 = Trim$(rs7104!K7104_SizeAverage03)
    If IsdbNull(rs7104!K7104_SizeAverage04) = False Then D7104.SizeAverage04 = Trim$(rs7104!K7104_SizeAverage04)
    If IsdbNull(rs7104!K7104_SizeAverage05) = False Then D7104.SizeAverage05 = Trim$(rs7104!K7104_SizeAverage05)
    If IsdbNull(rs7104!K7104_Size01) = False Then D7104.Size01 = Trim$(rs7104!K7104_Size01)
    If IsdbNull(rs7104!K7104_Size02) = False Then D7104.Size02 = Trim$(rs7104!K7104_Size02)
    If IsdbNull(rs7104!K7104_Size03) = False Then D7104.Size03 = Trim$(rs7104!K7104_Size03)
    If IsdbNull(rs7104!K7104_Size04) = False Then D7104.Size04 = Trim$(rs7104!K7104_Size04)
    If IsdbNull(rs7104!K7104_Size05) = False Then D7104.Size05 = Trim$(rs7104!K7104_Size05)
    If IsdbNull(rs7104!K7104_Size06) = False Then D7104.Size06 = Trim$(rs7104!K7104_Size06)
    If IsdbNull(rs7104!K7104_Size07) = False Then D7104.Size07 = Trim$(rs7104!K7104_Size07)
    If IsdbNull(rs7104!K7104_Size08) = False Then D7104.Size08 = Trim$(rs7104!K7104_Size08)
    If IsdbNull(rs7104!K7104_Size09) = False Then D7104.Size09 = Trim$(rs7104!K7104_Size09)
    If IsdbNull(rs7104!K7104_Size10) = False Then D7104.Size10 = Trim$(rs7104!K7104_Size10)
    If IsdbNull(rs7104!K7104_Size11) = False Then D7104.Size11 = Trim$(rs7104!K7104_Size11)
    If IsdbNull(rs7104!K7104_Size12) = False Then D7104.Size12 = Trim$(rs7104!K7104_Size12)
    If IsdbNull(rs7104!K7104_Size13) = False Then D7104.Size13 = Trim$(rs7104!K7104_Size13)
    If IsdbNull(rs7104!K7104_Size14) = False Then D7104.Size14 = Trim$(rs7104!K7104_Size14)
    If IsdbNull(rs7104!K7104_Size15) = False Then D7104.Size15 = Trim$(rs7104!K7104_Size15)
    If IsdbNull(rs7104!K7104_Size16) = False Then D7104.Size16 = Trim$(rs7104!K7104_Size16)
    If IsdbNull(rs7104!K7104_Size17) = False Then D7104.Size17 = Trim$(rs7104!K7104_Size17)
    If IsdbNull(rs7104!K7104_Size18) = False Then D7104.Size18 = Trim$(rs7104!K7104_Size18)
    If IsdbNull(rs7104!K7104_Size19) = False Then D7104.Size19 = Trim$(rs7104!K7104_Size19)
    If IsdbNull(rs7104!K7104_Size20) = False Then D7104.Size20 = Trim$(rs7104!K7104_Size20)
    If IsdbNull(rs7104!K7104_Size21) = False Then D7104.Size21 = Trim$(rs7104!K7104_Size21)
    If IsdbNull(rs7104!K7104_Size22) = False Then D7104.Size22 = Trim$(rs7104!K7104_Size22)
    If IsdbNull(rs7104!K7104_Size23) = False Then D7104.Size23 = Trim$(rs7104!K7104_Size23)
    If IsdbNull(rs7104!K7104_Size24) = False Then D7104.Size24 = Trim$(rs7104!K7104_Size24)
    If IsdbNull(rs7104!K7104_Size25) = False Then D7104.Size25 = Trim$(rs7104!K7104_Size25)
    If IsdbNull(rs7104!K7104_Size26) = False Then D7104.Size26 = Trim$(rs7104!K7104_Size26)
    If IsdbNull(rs7104!K7104_Size27) = False Then D7104.Size27 = Trim$(rs7104!K7104_Size27)
    If IsdbNull(rs7104!K7104_Size28) = False Then D7104.Size28 = Trim$(rs7104!K7104_Size28)
    If IsdbNull(rs7104!K7104_Size29) = False Then D7104.Size29 = Trim$(rs7104!K7104_Size29)
    If IsdbNull(rs7104!K7104_Size30) = False Then D7104.Size30 = Trim$(rs7104!K7104_Size30)
    If IsdbNull(rs7104!K7104_DateInsert) = False Then D7104.DateInsert = Trim$(rs7104!K7104_DateInsert)
    If IsdbNull(rs7104!K7104_DateUpdate) = False Then D7104.DateUpdate = Trim$(rs7104!K7104_DateUpdate)
    If IsdbNull(rs7104!K7104_InchargeInsert) = False Then D7104.InchargeInsert = Trim$(rs7104!K7104_InchargeInsert)
    If IsdbNull(rs7104!K7104_InchargeUpdate) = False Then D7104.InchargeUpdate = Trim$(rs7104!K7104_InchargeUpdate)
    If IsdbNull(rs7104!K7104_CheckUse) = False Then D7104.CheckUse = Trim$(rs7104!K7104_CheckUse)
    If IsdbNull(rs7104!K7104_CheckComplete) = False Then D7104.CheckComplete = Trim$(rs7104!K7104_CheckComplete)
    If IsdbNull(rs7104!K7104_Remark) = False Then D7104.Remark = Trim$(rs7104!K7104_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7104_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7104_MOVE(rs7104 As DataRow)
Try

    call D7104_CLEAR()   

    If IsdbNull(rs7104!K7104_SizeRange) = False Then D7104.SizeRange = Trim$(rs7104!K7104_SizeRange)
    If IsdbNull(rs7104!K7104_CustomerCode) = False Then D7104.CustomerCode = Trim$(rs7104!K7104_CustomerCode)
    If IsdbNull(rs7104!K7104_SizeRangeName) = False Then D7104.SizeRangeName = Trim$(rs7104!K7104_SizeRangeName)
    If IsdbNull(rs7104!K7104_SizeRangeSimpleName) = False Then D7104.SizeRangeSimpleName = Trim$(rs7104!K7104_SizeRangeSimpleName)
    If IsdbNull(rs7104!K7104_seGender) = False Then D7104.seGender = Trim$(rs7104!K7104_seGender)
    If IsdbNull(rs7104!K7104_cdGender) = False Then D7104.cdGender = Trim$(rs7104!K7104_cdGender)
    If IsdbNull(rs7104!K7104_seSeason) = False Then D7104.seSeason = Trim$(rs7104!K7104_seSeason)
    If IsdbNull(rs7104!K7104_cdSeason) = False Then D7104.cdSeason = Trim$(rs7104!K7104_cdSeason)
    If IsdbNull(rs7104!K7104_SizeAverage01) = False Then D7104.SizeAverage01 = Trim$(rs7104!K7104_SizeAverage01)
    If IsdbNull(rs7104!K7104_SizeAverage02) = False Then D7104.SizeAverage02 = Trim$(rs7104!K7104_SizeAverage02)
    If IsdbNull(rs7104!K7104_SizeAverage03) = False Then D7104.SizeAverage03 = Trim$(rs7104!K7104_SizeAverage03)
    If IsdbNull(rs7104!K7104_SizeAverage04) = False Then D7104.SizeAverage04 = Trim$(rs7104!K7104_SizeAverage04)
    If IsdbNull(rs7104!K7104_SizeAverage05) = False Then D7104.SizeAverage05 = Trim$(rs7104!K7104_SizeAverage05)
    If IsdbNull(rs7104!K7104_Size01) = False Then D7104.Size01 = Trim$(rs7104!K7104_Size01)
    If IsdbNull(rs7104!K7104_Size02) = False Then D7104.Size02 = Trim$(rs7104!K7104_Size02)
    If IsdbNull(rs7104!K7104_Size03) = False Then D7104.Size03 = Trim$(rs7104!K7104_Size03)
    If IsdbNull(rs7104!K7104_Size04) = False Then D7104.Size04 = Trim$(rs7104!K7104_Size04)
    If IsdbNull(rs7104!K7104_Size05) = False Then D7104.Size05 = Trim$(rs7104!K7104_Size05)
    If IsdbNull(rs7104!K7104_Size06) = False Then D7104.Size06 = Trim$(rs7104!K7104_Size06)
    If IsdbNull(rs7104!K7104_Size07) = False Then D7104.Size07 = Trim$(rs7104!K7104_Size07)
    If IsdbNull(rs7104!K7104_Size08) = False Then D7104.Size08 = Trim$(rs7104!K7104_Size08)
    If IsdbNull(rs7104!K7104_Size09) = False Then D7104.Size09 = Trim$(rs7104!K7104_Size09)
    If IsdbNull(rs7104!K7104_Size10) = False Then D7104.Size10 = Trim$(rs7104!K7104_Size10)
    If IsdbNull(rs7104!K7104_Size11) = False Then D7104.Size11 = Trim$(rs7104!K7104_Size11)
    If IsdbNull(rs7104!K7104_Size12) = False Then D7104.Size12 = Trim$(rs7104!K7104_Size12)
    If IsdbNull(rs7104!K7104_Size13) = False Then D7104.Size13 = Trim$(rs7104!K7104_Size13)
    If IsdbNull(rs7104!K7104_Size14) = False Then D7104.Size14 = Trim$(rs7104!K7104_Size14)
    If IsdbNull(rs7104!K7104_Size15) = False Then D7104.Size15 = Trim$(rs7104!K7104_Size15)
    If IsdbNull(rs7104!K7104_Size16) = False Then D7104.Size16 = Trim$(rs7104!K7104_Size16)
    If IsdbNull(rs7104!K7104_Size17) = False Then D7104.Size17 = Trim$(rs7104!K7104_Size17)
    If IsdbNull(rs7104!K7104_Size18) = False Then D7104.Size18 = Trim$(rs7104!K7104_Size18)
    If IsdbNull(rs7104!K7104_Size19) = False Then D7104.Size19 = Trim$(rs7104!K7104_Size19)
    If IsdbNull(rs7104!K7104_Size20) = False Then D7104.Size20 = Trim$(rs7104!K7104_Size20)
    If IsdbNull(rs7104!K7104_Size21) = False Then D7104.Size21 = Trim$(rs7104!K7104_Size21)
    If IsdbNull(rs7104!K7104_Size22) = False Then D7104.Size22 = Trim$(rs7104!K7104_Size22)
    If IsdbNull(rs7104!K7104_Size23) = False Then D7104.Size23 = Trim$(rs7104!K7104_Size23)
    If IsdbNull(rs7104!K7104_Size24) = False Then D7104.Size24 = Trim$(rs7104!K7104_Size24)
    If IsdbNull(rs7104!K7104_Size25) = False Then D7104.Size25 = Trim$(rs7104!K7104_Size25)
    If IsdbNull(rs7104!K7104_Size26) = False Then D7104.Size26 = Trim$(rs7104!K7104_Size26)
    If IsdbNull(rs7104!K7104_Size27) = False Then D7104.Size27 = Trim$(rs7104!K7104_Size27)
    If IsdbNull(rs7104!K7104_Size28) = False Then D7104.Size28 = Trim$(rs7104!K7104_Size28)
    If IsdbNull(rs7104!K7104_Size29) = False Then D7104.Size29 = Trim$(rs7104!K7104_Size29)
    If IsdbNull(rs7104!K7104_Size30) = False Then D7104.Size30 = Trim$(rs7104!K7104_Size30)
    If IsdbNull(rs7104!K7104_DateInsert) = False Then D7104.DateInsert = Trim$(rs7104!K7104_DateInsert)
    If IsdbNull(rs7104!K7104_DateUpdate) = False Then D7104.DateUpdate = Trim$(rs7104!K7104_DateUpdate)
    If IsdbNull(rs7104!K7104_InchargeInsert) = False Then D7104.InchargeInsert = Trim$(rs7104!K7104_InchargeInsert)
    If IsdbNull(rs7104!K7104_InchargeUpdate) = False Then D7104.InchargeUpdate = Trim$(rs7104!K7104_InchargeUpdate)
    If IsdbNull(rs7104!K7104_CheckUse) = False Then D7104.CheckUse = Trim$(rs7104!K7104_CheckUse)
    If IsdbNull(rs7104!K7104_CheckComplete) = False Then D7104.CheckComplete = Trim$(rs7104!K7104_CheckComplete)
    If IsdbNull(rs7104!K7104_Remark) = False Then D7104.Remark = Trim$(rs7104!K7104_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7104_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7104_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7104 As T7104_AREA, SIZERANGE AS String) as Boolean

K7104_MOVE = False

Try
    If READ_PFK7104(SIZERANGE) = True Then
                z7104 = D7104
		K7104_MOVE = True
		else
	z7104 = nothing
     End If

     If  getColumIndex(spr,"SizeRange") > -1 then z7104.SizeRange = getDataM(spr, getColumIndex(spr,"SizeRange"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z7104.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"SizeRangeName") > -1 then z7104.SizeRangeName = getDataM(spr, getColumIndex(spr,"SizeRangeName"), xRow)
     If  getColumIndex(spr,"SizeRangeSimpleName") > -1 then z7104.SizeRangeSimpleName = getDataM(spr, getColumIndex(spr,"SizeRangeSimpleName"), xRow)
     If  getColumIndex(spr,"seGender") > -1 then z7104.seGender = getDataM(spr, getColumIndex(spr,"seGender"), xRow)
     If  getColumIndex(spr,"cdGender") > -1 then z7104.cdGender = getDataM(spr, getColumIndex(spr,"cdGender"), xRow)
     If  getColumIndex(spr,"seSeason") > -1 then z7104.seSeason = getDataM(spr, getColumIndex(spr,"seSeason"), xRow)
     If  getColumIndex(spr,"cdSeason") > -1 then z7104.cdSeason = getDataM(spr, getColumIndex(spr,"cdSeason"), xRow)
     If  getColumIndex(spr,"SizeAverage01") > -1 then z7104.SizeAverage01 = getDataM(spr, getColumIndex(spr,"SizeAverage01"), xRow)
     If  getColumIndex(spr,"SizeAverage02") > -1 then z7104.SizeAverage02 = getDataM(spr, getColumIndex(spr,"SizeAverage02"), xRow)
     If  getColumIndex(spr,"SizeAverage03") > -1 then z7104.SizeAverage03 = getDataM(spr, getColumIndex(spr,"SizeAverage03"), xRow)
     If  getColumIndex(spr,"SizeAverage04") > -1 then z7104.SizeAverage04 = getDataM(spr, getColumIndex(spr,"SizeAverage04"), xRow)
     If  getColumIndex(spr,"SizeAverage05") > -1 then z7104.SizeAverage05 = getDataM(spr, getColumIndex(spr,"SizeAverage05"), xRow)
     If  getColumIndex(spr,"Size01") > -1 then z7104.Size01 = getDataM(spr, getColumIndex(spr,"Size01"), xRow)
     If  getColumIndex(spr,"Size02") > -1 then z7104.Size02 = getDataM(spr, getColumIndex(spr,"Size02"), xRow)
     If  getColumIndex(spr,"Size03") > -1 then z7104.Size03 = getDataM(spr, getColumIndex(spr,"Size03"), xRow)
     If  getColumIndex(spr,"Size04") > -1 then z7104.Size04 = getDataM(spr, getColumIndex(spr,"Size04"), xRow)
     If  getColumIndex(spr,"Size05") > -1 then z7104.Size05 = getDataM(spr, getColumIndex(spr,"Size05"), xRow)
     If  getColumIndex(spr,"Size06") > -1 then z7104.Size06 = getDataM(spr, getColumIndex(spr,"Size06"), xRow)
     If  getColumIndex(spr,"Size07") > -1 then z7104.Size07 = getDataM(spr, getColumIndex(spr,"Size07"), xRow)
     If  getColumIndex(spr,"Size08") > -1 then z7104.Size08 = getDataM(spr, getColumIndex(spr,"Size08"), xRow)
     If  getColumIndex(spr,"Size09") > -1 then z7104.Size09 = getDataM(spr, getColumIndex(spr,"Size09"), xRow)
     If  getColumIndex(spr,"Size10") > -1 then z7104.Size10 = getDataM(spr, getColumIndex(spr,"Size10"), xRow)
     If  getColumIndex(spr,"Size11") > -1 then z7104.Size11 = getDataM(spr, getColumIndex(spr,"Size11"), xRow)
     If  getColumIndex(spr,"Size12") > -1 then z7104.Size12 = getDataM(spr, getColumIndex(spr,"Size12"), xRow)
     If  getColumIndex(spr,"Size13") > -1 then z7104.Size13 = getDataM(spr, getColumIndex(spr,"Size13"), xRow)
     If  getColumIndex(spr,"Size14") > -1 then z7104.Size14 = getDataM(spr, getColumIndex(spr,"Size14"), xRow)
     If  getColumIndex(spr,"Size15") > -1 then z7104.Size15 = getDataM(spr, getColumIndex(spr,"Size15"), xRow)
     If  getColumIndex(spr,"Size16") > -1 then z7104.Size16 = getDataM(spr, getColumIndex(spr,"Size16"), xRow)
     If  getColumIndex(spr,"Size17") > -1 then z7104.Size17 = getDataM(spr, getColumIndex(spr,"Size17"), xRow)
     If  getColumIndex(spr,"Size18") > -1 then z7104.Size18 = getDataM(spr, getColumIndex(spr,"Size18"), xRow)
     If  getColumIndex(spr,"Size19") > -1 then z7104.Size19 = getDataM(spr, getColumIndex(spr,"Size19"), xRow)
     If  getColumIndex(spr,"Size20") > -1 then z7104.Size20 = getDataM(spr, getColumIndex(spr,"Size20"), xRow)
     If  getColumIndex(spr,"Size21") > -1 then z7104.Size21 = getDataM(spr, getColumIndex(spr,"Size21"), xRow)
     If  getColumIndex(spr,"Size22") > -1 then z7104.Size22 = getDataM(spr, getColumIndex(spr,"Size22"), xRow)
     If  getColumIndex(spr,"Size23") > -1 then z7104.Size23 = getDataM(spr, getColumIndex(spr,"Size23"), xRow)
     If  getColumIndex(spr,"Size24") > -1 then z7104.Size24 = getDataM(spr, getColumIndex(spr,"Size24"), xRow)
     If  getColumIndex(spr,"Size25") > -1 then z7104.Size25 = getDataM(spr, getColumIndex(spr,"Size25"), xRow)
     If  getColumIndex(spr,"Size26") > -1 then z7104.Size26 = getDataM(spr, getColumIndex(spr,"Size26"), xRow)
     If  getColumIndex(spr,"Size27") > -1 then z7104.Size27 = getDataM(spr, getColumIndex(spr,"Size27"), xRow)
     If  getColumIndex(spr,"Size28") > -1 then z7104.Size28 = getDataM(spr, getColumIndex(spr,"Size28"), xRow)
     If  getColumIndex(spr,"Size29") > -1 then z7104.Size29 = getDataM(spr, getColumIndex(spr,"Size29"), xRow)
     If  getColumIndex(spr,"Size30") > -1 then z7104.Size30 = getDataM(spr, getColumIndex(spr,"Size30"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7104.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7104.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7104.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7104.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7104.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z7104.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7104.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7104_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7104_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7104 As T7104_AREA,CheckClear as Boolean,SIZERANGE AS String) as Boolean

K7104_MOVE = False

Try
    If READ_PFK7104(SIZERANGE) = True Then
                z7104 = D7104
		K7104_MOVE = True
		else
	If CheckClear  = True then z7104 = nothing
     End If

     If  getColumIndex(spr,"SizeRange") > -1 then z7104.SizeRange = getDataM(spr, getColumIndex(spr,"SizeRange"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z7104.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"SizeRangeName") > -1 then z7104.SizeRangeName = getDataM(spr, getColumIndex(spr,"SizeRangeName"), xRow)
     If  getColumIndex(spr,"SizeRangeSimpleName") > -1 then z7104.SizeRangeSimpleName = getDataM(spr, getColumIndex(spr,"SizeRangeSimpleName"), xRow)
     If  getColumIndex(spr,"seGender") > -1 then z7104.seGender = getDataM(spr, getColumIndex(spr,"seGender"), xRow)
     If  getColumIndex(spr,"cdGender") > -1 then z7104.cdGender = getDataM(spr, getColumIndex(spr,"cdGender"), xRow)
     If  getColumIndex(spr,"seSeason") > -1 then z7104.seSeason = getDataM(spr, getColumIndex(spr,"seSeason"), xRow)
     If  getColumIndex(spr,"cdSeason") > -1 then z7104.cdSeason = getDataM(spr, getColumIndex(spr,"cdSeason"), xRow)
     If  getColumIndex(spr,"SizeAverage01") > -1 then z7104.SizeAverage01 = getDataM(spr, getColumIndex(spr,"SizeAverage01"), xRow)
     If  getColumIndex(spr,"SizeAverage02") > -1 then z7104.SizeAverage02 = getDataM(spr, getColumIndex(spr,"SizeAverage02"), xRow)
     If  getColumIndex(spr,"SizeAverage03") > -1 then z7104.SizeAverage03 = getDataM(spr, getColumIndex(spr,"SizeAverage03"), xRow)
     If  getColumIndex(spr,"SizeAverage04") > -1 then z7104.SizeAverage04 = getDataM(spr, getColumIndex(spr,"SizeAverage04"), xRow)
     If  getColumIndex(spr,"SizeAverage05") > -1 then z7104.SizeAverage05 = getDataM(spr, getColumIndex(spr,"SizeAverage05"), xRow)
     If  getColumIndex(spr,"Size01") > -1 then z7104.Size01 = getDataM(spr, getColumIndex(spr,"Size01"), xRow)
     If  getColumIndex(spr,"Size02") > -1 then z7104.Size02 = getDataM(spr, getColumIndex(spr,"Size02"), xRow)
     If  getColumIndex(spr,"Size03") > -1 then z7104.Size03 = getDataM(spr, getColumIndex(spr,"Size03"), xRow)
     If  getColumIndex(spr,"Size04") > -1 then z7104.Size04 = getDataM(spr, getColumIndex(spr,"Size04"), xRow)
     If  getColumIndex(spr,"Size05") > -1 then z7104.Size05 = getDataM(spr, getColumIndex(spr,"Size05"), xRow)
     If  getColumIndex(spr,"Size06") > -1 then z7104.Size06 = getDataM(spr, getColumIndex(spr,"Size06"), xRow)
     If  getColumIndex(spr,"Size07") > -1 then z7104.Size07 = getDataM(spr, getColumIndex(spr,"Size07"), xRow)
     If  getColumIndex(spr,"Size08") > -1 then z7104.Size08 = getDataM(spr, getColumIndex(spr,"Size08"), xRow)
     If  getColumIndex(spr,"Size09") > -1 then z7104.Size09 = getDataM(spr, getColumIndex(spr,"Size09"), xRow)
     If  getColumIndex(spr,"Size10") > -1 then z7104.Size10 = getDataM(spr, getColumIndex(spr,"Size10"), xRow)
     If  getColumIndex(spr,"Size11") > -1 then z7104.Size11 = getDataM(spr, getColumIndex(spr,"Size11"), xRow)
     If  getColumIndex(spr,"Size12") > -1 then z7104.Size12 = getDataM(spr, getColumIndex(spr,"Size12"), xRow)
     If  getColumIndex(spr,"Size13") > -1 then z7104.Size13 = getDataM(spr, getColumIndex(spr,"Size13"), xRow)
     If  getColumIndex(spr,"Size14") > -1 then z7104.Size14 = getDataM(spr, getColumIndex(spr,"Size14"), xRow)
     If  getColumIndex(spr,"Size15") > -1 then z7104.Size15 = getDataM(spr, getColumIndex(spr,"Size15"), xRow)
     If  getColumIndex(spr,"Size16") > -1 then z7104.Size16 = getDataM(spr, getColumIndex(spr,"Size16"), xRow)
     If  getColumIndex(spr,"Size17") > -1 then z7104.Size17 = getDataM(spr, getColumIndex(spr,"Size17"), xRow)
     If  getColumIndex(spr,"Size18") > -1 then z7104.Size18 = getDataM(spr, getColumIndex(spr,"Size18"), xRow)
     If  getColumIndex(spr,"Size19") > -1 then z7104.Size19 = getDataM(spr, getColumIndex(spr,"Size19"), xRow)
     If  getColumIndex(spr,"Size20") > -1 then z7104.Size20 = getDataM(spr, getColumIndex(spr,"Size20"), xRow)
     If  getColumIndex(spr,"Size21") > -1 then z7104.Size21 = getDataM(spr, getColumIndex(spr,"Size21"), xRow)
     If  getColumIndex(spr,"Size22") > -1 then z7104.Size22 = getDataM(spr, getColumIndex(spr,"Size22"), xRow)
     If  getColumIndex(spr,"Size23") > -1 then z7104.Size23 = getDataM(spr, getColumIndex(spr,"Size23"), xRow)
     If  getColumIndex(spr,"Size24") > -1 then z7104.Size24 = getDataM(spr, getColumIndex(spr,"Size24"), xRow)
     If  getColumIndex(spr,"Size25") > -1 then z7104.Size25 = getDataM(spr, getColumIndex(spr,"Size25"), xRow)
     If  getColumIndex(spr,"Size26") > -1 then z7104.Size26 = getDataM(spr, getColumIndex(spr,"Size26"), xRow)
     If  getColumIndex(spr,"Size27") > -1 then z7104.Size27 = getDataM(spr, getColumIndex(spr,"Size27"), xRow)
     If  getColumIndex(spr,"Size28") > -1 then z7104.Size28 = getDataM(spr, getColumIndex(spr,"Size28"), xRow)
     If  getColumIndex(spr,"Size29") > -1 then z7104.Size29 = getDataM(spr, getColumIndex(spr,"Size29"), xRow)
     If  getColumIndex(spr,"Size30") > -1 then z7104.Size30 = getDataM(spr, getColumIndex(spr,"Size30"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7104.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7104.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7104.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7104.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7104.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z7104.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7104.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7104_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7104_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7104 As T7104_AREA, Job as String, SIZERANGE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7104_MOVE = False

Try
    If READ_PFK7104(SIZERANGE) = True Then
                z7104 = D7104
		K7104_MOVE = True
		else
	z7104 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7104")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SIZERANGE":z7104.SizeRange = Children(i).Code
   Case "CUSTOMERCODE":z7104.CustomerCode = Children(i).Code
   Case "SIZERANGENAME":z7104.SizeRangeName = Children(i).Code
   Case "SIZERANGESIMPLENAME":z7104.SizeRangeSimpleName = Children(i).Code
   Case "SEGENDER":z7104.seGender = Children(i).Code
   Case "CDGENDER":z7104.cdGender = Children(i).Code
   Case "SESEASON":z7104.seSeason = Children(i).Code
   Case "CDSEASON":z7104.cdSeason = Children(i).Code
   Case "SIZEAVERAGE01":z7104.SizeAverage01 = Children(i).Code
   Case "SIZEAVERAGE02":z7104.SizeAverage02 = Children(i).Code
   Case "SIZEAVERAGE03":z7104.SizeAverage03 = Children(i).Code
   Case "SIZEAVERAGE04":z7104.SizeAverage04 = Children(i).Code
   Case "SIZEAVERAGE05":z7104.SizeAverage05 = Children(i).Code
   Case "SIZE01":z7104.Size01 = Children(i).Code
   Case "SIZE02":z7104.Size02 = Children(i).Code
   Case "SIZE03":z7104.Size03 = Children(i).Code
   Case "SIZE04":z7104.Size04 = Children(i).Code
   Case "SIZE05":z7104.Size05 = Children(i).Code
   Case "SIZE06":z7104.Size06 = Children(i).Code
   Case "SIZE07":z7104.Size07 = Children(i).Code
   Case "SIZE08":z7104.Size08 = Children(i).Code
   Case "SIZE09":z7104.Size09 = Children(i).Code
   Case "SIZE10":z7104.Size10 = Children(i).Code
   Case "SIZE11":z7104.Size11 = Children(i).Code
   Case "SIZE12":z7104.Size12 = Children(i).Code
   Case "SIZE13":z7104.Size13 = Children(i).Code
   Case "SIZE14":z7104.Size14 = Children(i).Code
   Case "SIZE15":z7104.Size15 = Children(i).Code
   Case "SIZE16":z7104.Size16 = Children(i).Code
   Case "SIZE17":z7104.Size17 = Children(i).Code
   Case "SIZE18":z7104.Size18 = Children(i).Code
   Case "SIZE19":z7104.Size19 = Children(i).Code
   Case "SIZE20":z7104.Size20 = Children(i).Code
   Case "SIZE21":z7104.Size21 = Children(i).Code
   Case "SIZE22":z7104.Size22 = Children(i).Code
   Case "SIZE23":z7104.Size23 = Children(i).Code
   Case "SIZE24":z7104.Size24 = Children(i).Code
   Case "SIZE25":z7104.Size25 = Children(i).Code
   Case "SIZE26":z7104.Size26 = Children(i).Code
   Case "SIZE27":z7104.Size27 = Children(i).Code
   Case "SIZE28":z7104.Size28 = Children(i).Code
   Case "SIZE29":z7104.Size29 = Children(i).Code
   Case "SIZE30":z7104.Size30 = Children(i).Code
   Case "DATEINSERT":z7104.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7104.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7104.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7104.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7104.CheckUse = Children(i).Code
   Case "CHECKCOMPLETE":z7104.CheckComplete = Children(i).Code
   Case "REMARK":z7104.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SIZERANGE":z7104.SizeRange = Children(i).Data
   Case "CUSTOMERCODE":z7104.CustomerCode = Children(i).Data
   Case "SIZERANGENAME":z7104.SizeRangeName = Children(i).Data
   Case "SIZERANGESIMPLENAME":z7104.SizeRangeSimpleName = Children(i).Data
   Case "SEGENDER":z7104.seGender = Children(i).Data
   Case "CDGENDER":z7104.cdGender = Children(i).Data
   Case "SESEASON":z7104.seSeason = Children(i).Data
   Case "CDSEASON":z7104.cdSeason = Children(i).Data
   Case "SIZEAVERAGE01":z7104.SizeAverage01 = Children(i).Data
   Case "SIZEAVERAGE02":z7104.SizeAverage02 = Children(i).Data
   Case "SIZEAVERAGE03":z7104.SizeAverage03 = Children(i).Data
   Case "SIZEAVERAGE04":z7104.SizeAverage04 = Children(i).Data
   Case "SIZEAVERAGE05":z7104.SizeAverage05 = Children(i).Data
   Case "SIZE01":z7104.Size01 = Children(i).Data
   Case "SIZE02":z7104.Size02 = Children(i).Data
   Case "SIZE03":z7104.Size03 = Children(i).Data
   Case "SIZE04":z7104.Size04 = Children(i).Data
   Case "SIZE05":z7104.Size05 = Children(i).Data
   Case "SIZE06":z7104.Size06 = Children(i).Data
   Case "SIZE07":z7104.Size07 = Children(i).Data
   Case "SIZE08":z7104.Size08 = Children(i).Data
   Case "SIZE09":z7104.Size09 = Children(i).Data
   Case "SIZE10":z7104.Size10 = Children(i).Data
   Case "SIZE11":z7104.Size11 = Children(i).Data
   Case "SIZE12":z7104.Size12 = Children(i).Data
   Case "SIZE13":z7104.Size13 = Children(i).Data
   Case "SIZE14":z7104.Size14 = Children(i).Data
   Case "SIZE15":z7104.Size15 = Children(i).Data
   Case "SIZE16":z7104.Size16 = Children(i).Data
   Case "SIZE17":z7104.Size17 = Children(i).Data
   Case "SIZE18":z7104.Size18 = Children(i).Data
   Case "SIZE19":z7104.Size19 = Children(i).Data
   Case "SIZE20":z7104.Size20 = Children(i).Data
   Case "SIZE21":z7104.Size21 = Children(i).Data
   Case "SIZE22":z7104.Size22 = Children(i).Data
   Case "SIZE23":z7104.Size23 = Children(i).Data
   Case "SIZE24":z7104.Size24 = Children(i).Data
   Case "SIZE25":z7104.Size25 = Children(i).Data
   Case "SIZE26":z7104.Size26 = Children(i).Data
   Case "SIZE27":z7104.Size27 = Children(i).Data
   Case "SIZE28":z7104.Size28 = Children(i).Data
   Case "SIZE29":z7104.Size29 = Children(i).Data
   Case "SIZE30":z7104.Size30 = Children(i).Data
   Case "DATEINSERT":z7104.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7104.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7104.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7104.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7104.CheckUse = Children(i).Data
   Case "CHECKCOMPLETE":z7104.CheckComplete = Children(i).Data
   Case "REMARK":z7104.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7104_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7104_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7104 As T7104_AREA, Job as String, CheckClear as Boolean, SIZERANGE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7104_MOVE = False

Try
    If READ_PFK7104(SIZERANGE) = True Then
                z7104 = D7104
		K7104_MOVE = True
		else
	If CheckClear  = True then z7104 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7104")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SIZERANGE":z7104.SizeRange = Children(i).Code
   Case "CUSTOMERCODE":z7104.CustomerCode = Children(i).Code
   Case "SIZERANGENAME":z7104.SizeRangeName = Children(i).Code
   Case "SIZERANGESIMPLENAME":z7104.SizeRangeSimpleName = Children(i).Code
   Case "SEGENDER":z7104.seGender = Children(i).Code
   Case "CDGENDER":z7104.cdGender = Children(i).Code
   Case "SESEASON":z7104.seSeason = Children(i).Code
   Case "CDSEASON":z7104.cdSeason = Children(i).Code
   Case "SIZEAVERAGE01":z7104.SizeAverage01 = Children(i).Code
   Case "SIZEAVERAGE02":z7104.SizeAverage02 = Children(i).Code
   Case "SIZEAVERAGE03":z7104.SizeAverage03 = Children(i).Code
   Case "SIZEAVERAGE04":z7104.SizeAverage04 = Children(i).Code
   Case "SIZEAVERAGE05":z7104.SizeAverage05 = Children(i).Code
   Case "SIZE01":z7104.Size01 = Children(i).Code
   Case "SIZE02":z7104.Size02 = Children(i).Code
   Case "SIZE03":z7104.Size03 = Children(i).Code
   Case "SIZE04":z7104.Size04 = Children(i).Code
   Case "SIZE05":z7104.Size05 = Children(i).Code
   Case "SIZE06":z7104.Size06 = Children(i).Code
   Case "SIZE07":z7104.Size07 = Children(i).Code
   Case "SIZE08":z7104.Size08 = Children(i).Code
   Case "SIZE09":z7104.Size09 = Children(i).Code
   Case "SIZE10":z7104.Size10 = Children(i).Code
   Case "SIZE11":z7104.Size11 = Children(i).Code
   Case "SIZE12":z7104.Size12 = Children(i).Code
   Case "SIZE13":z7104.Size13 = Children(i).Code
   Case "SIZE14":z7104.Size14 = Children(i).Code
   Case "SIZE15":z7104.Size15 = Children(i).Code
   Case "SIZE16":z7104.Size16 = Children(i).Code
   Case "SIZE17":z7104.Size17 = Children(i).Code
   Case "SIZE18":z7104.Size18 = Children(i).Code
   Case "SIZE19":z7104.Size19 = Children(i).Code
   Case "SIZE20":z7104.Size20 = Children(i).Code
   Case "SIZE21":z7104.Size21 = Children(i).Code
   Case "SIZE22":z7104.Size22 = Children(i).Code
   Case "SIZE23":z7104.Size23 = Children(i).Code
   Case "SIZE24":z7104.Size24 = Children(i).Code
   Case "SIZE25":z7104.Size25 = Children(i).Code
   Case "SIZE26":z7104.Size26 = Children(i).Code
   Case "SIZE27":z7104.Size27 = Children(i).Code
   Case "SIZE28":z7104.Size28 = Children(i).Code
   Case "SIZE29":z7104.Size29 = Children(i).Code
   Case "SIZE30":z7104.Size30 = Children(i).Code
   Case "DATEINSERT":z7104.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7104.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7104.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7104.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7104.CheckUse = Children(i).Code
   Case "CHECKCOMPLETE":z7104.CheckComplete = Children(i).Code
   Case "REMARK":z7104.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SIZERANGE":z7104.SizeRange = Children(i).Data
   Case "CUSTOMERCODE":z7104.CustomerCode = Children(i).Data
   Case "SIZERANGENAME":z7104.SizeRangeName = Children(i).Data
   Case "SIZERANGESIMPLENAME":z7104.SizeRangeSimpleName = Children(i).Data
   Case "SEGENDER":z7104.seGender = Children(i).Data
   Case "CDGENDER":z7104.cdGender = Children(i).Data
   Case "SESEASON":z7104.seSeason = Children(i).Data
   Case "CDSEASON":z7104.cdSeason = Children(i).Data
   Case "SIZEAVERAGE01":z7104.SizeAverage01 = Children(i).Data
   Case "SIZEAVERAGE02":z7104.SizeAverage02 = Children(i).Data
   Case "SIZEAVERAGE03":z7104.SizeAverage03 = Children(i).Data
   Case "SIZEAVERAGE04":z7104.SizeAverage04 = Children(i).Data
   Case "SIZEAVERAGE05":z7104.SizeAverage05 = Children(i).Data
   Case "SIZE01":z7104.Size01 = Children(i).Data
   Case "SIZE02":z7104.Size02 = Children(i).Data
   Case "SIZE03":z7104.Size03 = Children(i).Data
   Case "SIZE04":z7104.Size04 = Children(i).Data
   Case "SIZE05":z7104.Size05 = Children(i).Data
   Case "SIZE06":z7104.Size06 = Children(i).Data
   Case "SIZE07":z7104.Size07 = Children(i).Data
   Case "SIZE08":z7104.Size08 = Children(i).Data
   Case "SIZE09":z7104.Size09 = Children(i).Data
   Case "SIZE10":z7104.Size10 = Children(i).Data
   Case "SIZE11":z7104.Size11 = Children(i).Data
   Case "SIZE12":z7104.Size12 = Children(i).Data
   Case "SIZE13":z7104.Size13 = Children(i).Data
   Case "SIZE14":z7104.Size14 = Children(i).Data
   Case "SIZE15":z7104.Size15 = Children(i).Data
   Case "SIZE16":z7104.Size16 = Children(i).Data
   Case "SIZE17":z7104.Size17 = Children(i).Data
   Case "SIZE18":z7104.Size18 = Children(i).Data
   Case "SIZE19":z7104.Size19 = Children(i).Data
   Case "SIZE20":z7104.Size20 = Children(i).Data
   Case "SIZE21":z7104.Size21 = Children(i).Data
   Case "SIZE22":z7104.Size22 = Children(i).Data
   Case "SIZE23":z7104.Size23 = Children(i).Data
   Case "SIZE24":z7104.Size24 = Children(i).Data
   Case "SIZE25":z7104.Size25 = Children(i).Data
   Case "SIZE26":z7104.Size26 = Children(i).Data
   Case "SIZE27":z7104.Size27 = Children(i).Data
   Case "SIZE28":z7104.Size28 = Children(i).Data
   Case "SIZE29":z7104.Size29 = Children(i).Data
   Case "SIZE30":z7104.Size30 = Children(i).Data
   Case "DATEINSERT":z7104.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7104.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7104.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7104.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7104.CheckUse = Children(i).Data
   Case "CHECKCOMPLETE":z7104.CheckComplete = Children(i).Data
   Case "REMARK":z7104.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7104_MOVE",vbCritical)
End Try
End Function 
    
End Module 
