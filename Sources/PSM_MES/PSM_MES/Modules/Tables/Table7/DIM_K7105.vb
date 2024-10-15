'=========================================================================================================================================================
'   TABLE : (PFK7105)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7105

Structure T7105_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	SizeRangeTool	 AS String	'			char(6)		*
Public 	seSizeGroup	 AS String	'			char(3)
Public 	cdSizeGroup	 AS String	'			char(3)
Public 	CustomerCode	 AS String	'			char(6)
Public 	SizeRangeToolName	 AS String	'			nvarchar(50)
Public 	SizeRangeToolSimpleName	 AS String	'			nvarchar(50)
Public 	seGender	 AS String	'			char(3)
Public 	cdGender	 AS String	'			char(3)
Public 	seSeason	 AS String	'			char(3)
Public 	cdSeason	 AS String	'			char(3)
Public 	SizeAverage01	 AS String	'			nvarchar(4)
Public 	SizeAverage02	 AS String	'			nvarchar(4)
Public 	SizeAverage03	 AS String	'			nvarchar(4)
Public 	SizeAverage04	 AS String	'			nvarchar(4)
Public 	SizeAverage05	 AS String	'			nvarchar(4)
Public 	Size01	 AS String	'			nvarchar(4)
Public 	Size02	 AS String	'			nvarchar(4)
Public 	Size03	 AS String	'			nvarchar(4)
Public 	Size04	 AS String	'			nvarchar(4)
Public 	Size05	 AS String	'			nvarchar(4)
Public 	Size06	 AS String	'			nvarchar(4)
Public 	Size07	 AS String	'			nvarchar(4)
Public 	Size08	 AS String	'			nvarchar(4)
Public 	Size09	 AS String	'			nvarchar(4)
Public 	Size10	 AS String	'			nvarchar(4)
Public 	Size11	 AS String	'			nvarchar(4)
Public 	Size12	 AS String	'			nvarchar(4)
Public 	Size13	 AS String	'			nvarchar(4)
Public 	Size14	 AS String	'			nvarchar(4)
Public 	Size15	 AS String	'			nvarchar(4)
Public 	Size16	 AS String	'			nvarchar(4)
Public 	Size17	 AS String	'			nvarchar(4)
Public 	Size18	 AS String	'			nvarchar(4)
Public 	Size19	 AS String	'			nvarchar(4)
Public 	Size20	 AS String	'			nvarchar(4)
Public 	Size21	 AS String	'			nvarchar(4)
Public 	Size22	 AS String	'			nvarchar(4)
Public 	Size23	 AS String	'			nvarchar(4)
Public 	Size24	 AS String	'			nvarchar(4)
Public 	Size25	 AS String	'			nvarchar(4)
Public 	Size26	 AS String	'			nvarchar(4)
Public 	Size27	 AS String	'			nvarchar(4)
Public 	Size28	 AS String	'			nvarchar(4)
Public 	Size29	 AS String	'			nvarchar(4)
Public 	Size30	 AS String	'			nvarchar(4)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(6)
Public 	InchargeUpdate	 AS String	'			char(6)
Public 	CheckUse	 AS String	'			char(1)
Public 	CheckComplete	 AS String	'			char(1)
Public 	Remark	 AS String	'			nvarchar(50)
'=========================================================================================================================================================
End structure

Public D7105 As T7105_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7105(SIZERANGETOOL AS String) As Boolean
    READ_PFK7105 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7105 "
    SQL = SQL & " WHERE K7105_SizeRangeTool		 = '" & SizeRangeTool & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7105_CLEAR: GoTo SKIP_READ_PFK7105
                
    Call K7105_MOVE(rd)
    READ_PFK7105 = True

SKIP_READ_PFK7105:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7105",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7105(SIZERANGETOOL AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7105 "
    SQL = SQL & " WHERE K7105_SizeRangeTool		 = '" & SizeRangeTool & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7105",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7105(z7105 As T7105_AREA) As Boolean
    WRITE_PFK7105 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7105)
 
    SQL = " INSERT INTO PFK7105 "
    SQL = SQL & " ( "
    SQL = SQL & " K7105_SizeRangeTool," 
    SQL = SQL & " K7105_seSizeGroup," 
    SQL = SQL & " K7105_cdSizeGroup," 
    SQL = SQL & " K7105_CustomerCode," 
    SQL = SQL & " K7105_SizeRangeToolName," 
    SQL = SQL & " K7105_SizeRangeToolSimpleName," 
    SQL = SQL & " K7105_seGender," 
    SQL = SQL & " K7105_cdGender," 
    SQL = SQL & " K7105_seSeason," 
    SQL = SQL & " K7105_cdSeason," 
    SQL = SQL & " K7105_SizeAverage01," 
    SQL = SQL & " K7105_SizeAverage02," 
    SQL = SQL & " K7105_SizeAverage03," 
    SQL = SQL & " K7105_SizeAverage04," 
    SQL = SQL & " K7105_SizeAverage05," 
    SQL = SQL & " K7105_Size01," 
    SQL = SQL & " K7105_Size02," 
    SQL = SQL & " K7105_Size03," 
    SQL = SQL & " K7105_Size04," 
    SQL = SQL & " K7105_Size05," 
    SQL = SQL & " K7105_Size06," 
    SQL = SQL & " K7105_Size07," 
    SQL = SQL & " K7105_Size08," 
    SQL = SQL & " K7105_Size09," 
    SQL = SQL & " K7105_Size10," 
    SQL = SQL & " K7105_Size11," 
    SQL = SQL & " K7105_Size12," 
    SQL = SQL & " K7105_Size13," 
    SQL = SQL & " K7105_Size14," 
    SQL = SQL & " K7105_Size15," 
    SQL = SQL & " K7105_Size16," 
    SQL = SQL & " K7105_Size17," 
    SQL = SQL & " K7105_Size18," 
    SQL = SQL & " K7105_Size19," 
    SQL = SQL & " K7105_Size20," 
    SQL = SQL & " K7105_Size21," 
    SQL = SQL & " K7105_Size22," 
    SQL = SQL & " K7105_Size23," 
    SQL = SQL & " K7105_Size24," 
    SQL = SQL & " K7105_Size25," 
    SQL = SQL & " K7105_Size26," 
    SQL = SQL & " K7105_Size27," 
    SQL = SQL & " K7105_Size28," 
    SQL = SQL & " K7105_Size29," 
    SQL = SQL & " K7105_Size30," 
    SQL = SQL & " K7105_DateInsert," 
    SQL = SQL & " K7105_DateUpdate," 
    SQL = SQL & " K7105_InchargeInsert," 
    SQL = SQL & " K7105_InchargeUpdate," 
    SQL = SQL & " K7105_CheckUse," 
    SQL = SQL & " K7105_CheckComplete," 
    SQL = SQL & " K7105_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7105.SizeRangeTool) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.seSizeGroup) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.cdSizeGroup) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.CustomerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.SizeRangeToolName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.SizeRangeToolSimpleName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.seGender) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.cdGender) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.seSeason) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.cdSeason) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.SizeAverage01) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.SizeAverage02) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.SizeAverage03) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.SizeAverage04) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.SizeAverage05) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.Size01) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.Size02) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.Size03) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.Size04) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.Size05) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.Size06) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.Size07) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.Size08) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.Size09) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.Size10) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.Size11) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.Size12) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.Size13) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.Size14) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.Size15) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.Size16) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.Size17) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.Size18) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.Size19) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.Size20) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.Size21) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.Size22) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.Size23) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.Size24) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.Size25) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.Size26) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.Size27) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.Size28) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.Size29) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.Size30) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.CheckUse) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.CheckComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7105.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7105 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7105",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7105(z7105 As T7105_AREA) As Boolean
    REWRITE_PFK7105 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7105)
   
    SQL = " UPDATE PFK7105 SET "
    SQL = SQL & "    K7105_seSizeGroup      = N'" & FormatSQL(z7105.seSizeGroup) & "', " 
    SQL = SQL & "    K7105_cdSizeGroup      = N'" & FormatSQL(z7105.cdSizeGroup) & "', " 
    SQL = SQL & "    K7105_CustomerCode      = N'" & FormatSQL(z7105.CustomerCode) & "', " 
    SQL = SQL & "    K7105_SizeRangeToolName      = N'" & FormatSQL(z7105.SizeRangeToolName) & "', " 
    SQL = SQL & "    K7105_SizeRangeToolSimpleName      = N'" & FormatSQL(z7105.SizeRangeToolSimpleName) & "', " 
    SQL = SQL & "    K7105_seGender      = N'" & FormatSQL(z7105.seGender) & "', " 
    SQL = SQL & "    K7105_cdGender      = N'" & FormatSQL(z7105.cdGender) & "', " 
    SQL = SQL & "    K7105_seSeason      = N'" & FormatSQL(z7105.seSeason) & "', " 
    SQL = SQL & "    K7105_cdSeason      = N'" & FormatSQL(z7105.cdSeason) & "', " 
    SQL = SQL & "    K7105_SizeAverage01      = N'" & FormatSQL(z7105.SizeAverage01) & "', " 
    SQL = SQL & "    K7105_SizeAverage02      = N'" & FormatSQL(z7105.SizeAverage02) & "', " 
    SQL = SQL & "    K7105_SizeAverage03      = N'" & FormatSQL(z7105.SizeAverage03) & "', " 
    SQL = SQL & "    K7105_SizeAverage04      = N'" & FormatSQL(z7105.SizeAverage04) & "', " 
    SQL = SQL & "    K7105_SizeAverage05      = N'" & FormatSQL(z7105.SizeAverage05) & "', " 
    SQL = SQL & "    K7105_Size01      = N'" & FormatSQL(z7105.Size01) & "', " 
    SQL = SQL & "    K7105_Size02      = N'" & FormatSQL(z7105.Size02) & "', " 
    SQL = SQL & "    K7105_Size03      = N'" & FormatSQL(z7105.Size03) & "', " 
    SQL = SQL & "    K7105_Size04      = N'" & FormatSQL(z7105.Size04) & "', " 
    SQL = SQL & "    K7105_Size05      = N'" & FormatSQL(z7105.Size05) & "', " 
    SQL = SQL & "    K7105_Size06      = N'" & FormatSQL(z7105.Size06) & "', " 
    SQL = SQL & "    K7105_Size07      = N'" & FormatSQL(z7105.Size07) & "', " 
    SQL = SQL & "    K7105_Size08      = N'" & FormatSQL(z7105.Size08) & "', " 
    SQL = SQL & "    K7105_Size09      = N'" & FormatSQL(z7105.Size09) & "', " 
    SQL = SQL & "    K7105_Size10      = N'" & FormatSQL(z7105.Size10) & "', " 
    SQL = SQL & "    K7105_Size11      = N'" & FormatSQL(z7105.Size11) & "', " 
    SQL = SQL & "    K7105_Size12      = N'" & FormatSQL(z7105.Size12) & "', " 
    SQL = SQL & "    K7105_Size13      = N'" & FormatSQL(z7105.Size13) & "', " 
    SQL = SQL & "    K7105_Size14      = N'" & FormatSQL(z7105.Size14) & "', " 
    SQL = SQL & "    K7105_Size15      = N'" & FormatSQL(z7105.Size15) & "', " 
    SQL = SQL & "    K7105_Size16      = N'" & FormatSQL(z7105.Size16) & "', " 
    SQL = SQL & "    K7105_Size17      = N'" & FormatSQL(z7105.Size17) & "', " 
    SQL = SQL & "    K7105_Size18      = N'" & FormatSQL(z7105.Size18) & "', " 
    SQL = SQL & "    K7105_Size19      = N'" & FormatSQL(z7105.Size19) & "', " 
    SQL = SQL & "    K7105_Size20      = N'" & FormatSQL(z7105.Size20) & "', " 
    SQL = SQL & "    K7105_Size21      = N'" & FormatSQL(z7105.Size21) & "', " 
    SQL = SQL & "    K7105_Size22      = N'" & FormatSQL(z7105.Size22) & "', " 
    SQL = SQL & "    K7105_Size23      = N'" & FormatSQL(z7105.Size23) & "', " 
    SQL = SQL & "    K7105_Size24      = N'" & FormatSQL(z7105.Size24) & "', " 
    SQL = SQL & "    K7105_Size25      = N'" & FormatSQL(z7105.Size25) & "', " 
    SQL = SQL & "    K7105_Size26      = N'" & FormatSQL(z7105.Size26) & "', " 
    SQL = SQL & "    K7105_Size27      = N'" & FormatSQL(z7105.Size27) & "', " 
    SQL = SQL & "    K7105_Size28      = N'" & FormatSQL(z7105.Size28) & "', " 
    SQL = SQL & "    K7105_Size29      = N'" & FormatSQL(z7105.Size29) & "', " 
    SQL = SQL & "    K7105_Size30      = N'" & FormatSQL(z7105.Size30) & "', " 
    SQL = SQL & "    K7105_DateInsert      = N'" & FormatSQL(z7105.DateInsert) & "', " 
    SQL = SQL & "    K7105_DateUpdate      = N'" & FormatSQL(z7105.DateUpdate) & "', " 
    SQL = SQL & "    K7105_InchargeInsert      = N'" & FormatSQL(z7105.InchargeInsert) & "', " 
    SQL = SQL & "    K7105_InchargeUpdate      = N'" & FormatSQL(z7105.InchargeUpdate) & "', " 
    SQL = SQL & "    K7105_CheckUse      = N'" & FormatSQL(z7105.CheckUse) & "', " 
    SQL = SQL & "    K7105_CheckComplete      = N'" & FormatSQL(z7105.CheckComplete) & "', " 
    SQL = SQL & "    K7105_Remark      = N'" & FormatSQL(z7105.Remark) & "'  " 
    SQL = SQL & " WHERE K7105_SizeRangeTool		 = '" & z7105.SizeRangeTool & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7105 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7105",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7105(z7105 As T7105_AREA) As Boolean
    DELETE_PFK7105 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7105 "
    SQL = SQL & " WHERE K7105_SizeRangeTool		 = '" & z7105.SizeRangeTool & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7105 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7105",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7105_CLEAR()
Try
    
   D7105.SizeRangeTool = ""
   D7105.seSizeGroup = ""
   D7105.cdSizeGroup = ""
   D7105.CustomerCode = ""
   D7105.SizeRangeToolName = ""
   D7105.SizeRangeToolSimpleName = ""
   D7105.seGender = ""
   D7105.cdGender = ""
   D7105.seSeason = ""
   D7105.cdSeason = ""
   D7105.SizeAverage01 = ""
   D7105.SizeAverage02 = ""
   D7105.SizeAverage03 = ""
   D7105.SizeAverage04 = ""
   D7105.SizeAverage05 = ""
   D7105.Size01 = ""
   D7105.Size02 = ""
   D7105.Size03 = ""
   D7105.Size04 = ""
   D7105.Size05 = ""
   D7105.Size06 = ""
   D7105.Size07 = ""
   D7105.Size08 = ""
   D7105.Size09 = ""
   D7105.Size10 = ""
   D7105.Size11 = ""
   D7105.Size12 = ""
   D7105.Size13 = ""
   D7105.Size14 = ""
   D7105.Size15 = ""
   D7105.Size16 = ""
   D7105.Size17 = ""
   D7105.Size18 = ""
   D7105.Size19 = ""
   D7105.Size20 = ""
   D7105.Size21 = ""
   D7105.Size22 = ""
   D7105.Size23 = ""
   D7105.Size24 = ""
   D7105.Size25 = ""
   D7105.Size26 = ""
   D7105.Size27 = ""
   D7105.Size28 = ""
   D7105.Size29 = ""
   D7105.Size30 = ""
   D7105.DateInsert = ""
   D7105.DateUpdate = ""
   D7105.InchargeInsert = ""
   D7105.InchargeUpdate = ""
   D7105.CheckUse = ""
   D7105.CheckComplete = ""
   D7105.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7105_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7105 As T7105_AREA)
Try
    
    x7105.SizeRangeTool = trim$(  x7105.SizeRangeTool)
    x7105.seSizeGroup = trim$(  x7105.seSizeGroup)
    x7105.cdSizeGroup = trim$(  x7105.cdSizeGroup)
    x7105.CustomerCode = trim$(  x7105.CustomerCode)
    x7105.SizeRangeToolName = trim$(  x7105.SizeRangeToolName)
    x7105.SizeRangeToolSimpleName = trim$(  x7105.SizeRangeToolSimpleName)
    x7105.seGender = trim$(  x7105.seGender)
    x7105.cdGender = trim$(  x7105.cdGender)
    x7105.seSeason = trim$(  x7105.seSeason)
    x7105.cdSeason = trim$(  x7105.cdSeason)
    x7105.SizeAverage01 = trim$(  x7105.SizeAverage01)
    x7105.SizeAverage02 = trim$(  x7105.SizeAverage02)
    x7105.SizeAverage03 = trim$(  x7105.SizeAverage03)
    x7105.SizeAverage04 = trim$(  x7105.SizeAverage04)
    x7105.SizeAverage05 = trim$(  x7105.SizeAverage05)
    x7105.Size01 = trim$(  x7105.Size01)
    x7105.Size02 = trim$(  x7105.Size02)
    x7105.Size03 = trim$(  x7105.Size03)
    x7105.Size04 = trim$(  x7105.Size04)
    x7105.Size05 = trim$(  x7105.Size05)
    x7105.Size06 = trim$(  x7105.Size06)
    x7105.Size07 = trim$(  x7105.Size07)
    x7105.Size08 = trim$(  x7105.Size08)
    x7105.Size09 = trim$(  x7105.Size09)
    x7105.Size10 = trim$(  x7105.Size10)
    x7105.Size11 = trim$(  x7105.Size11)
    x7105.Size12 = trim$(  x7105.Size12)
    x7105.Size13 = trim$(  x7105.Size13)
    x7105.Size14 = trim$(  x7105.Size14)
    x7105.Size15 = trim$(  x7105.Size15)
    x7105.Size16 = trim$(  x7105.Size16)
    x7105.Size17 = trim$(  x7105.Size17)
    x7105.Size18 = trim$(  x7105.Size18)
    x7105.Size19 = trim$(  x7105.Size19)
    x7105.Size20 = trim$(  x7105.Size20)
    x7105.Size21 = trim$(  x7105.Size21)
    x7105.Size22 = trim$(  x7105.Size22)
    x7105.Size23 = trim$(  x7105.Size23)
    x7105.Size24 = trim$(  x7105.Size24)
    x7105.Size25 = trim$(  x7105.Size25)
    x7105.Size26 = trim$(  x7105.Size26)
    x7105.Size27 = trim$(  x7105.Size27)
    x7105.Size28 = trim$(  x7105.Size28)
    x7105.Size29 = trim$(  x7105.Size29)
    x7105.Size30 = trim$(  x7105.Size30)
    x7105.DateInsert = trim$(  x7105.DateInsert)
    x7105.DateUpdate = trim$(  x7105.DateUpdate)
    x7105.InchargeInsert = trim$(  x7105.InchargeInsert)
    x7105.InchargeUpdate = trim$(  x7105.InchargeUpdate)
    x7105.CheckUse = trim$(  x7105.CheckUse)
    x7105.CheckComplete = trim$(  x7105.CheckComplete)
    x7105.Remark = trim$(  x7105.Remark)
     
    If trim$( x7105.SizeRangeTool ) = "" Then x7105.SizeRangeTool = Space(1) 
    If trim$( x7105.seSizeGroup ) = "" Then x7105.seSizeGroup = Space(1) 
    If trim$( x7105.cdSizeGroup ) = "" Then x7105.cdSizeGroup = Space(1) 
    If trim$( x7105.CustomerCode ) = "" Then x7105.CustomerCode = Space(1) 
    If trim$( x7105.SizeRangeToolName ) = "" Then x7105.SizeRangeToolName = Space(1) 
    If trim$( x7105.SizeRangeToolSimpleName ) = "" Then x7105.SizeRangeToolSimpleName = Space(1) 
    If trim$( x7105.seGender ) = "" Then x7105.seGender = Space(1) 
    If trim$( x7105.cdGender ) = "" Then x7105.cdGender = Space(1) 
    If trim$( x7105.seSeason ) = "" Then x7105.seSeason = Space(1) 
    If trim$( x7105.cdSeason ) = "" Then x7105.cdSeason = Space(1) 
    If trim$( x7105.SizeAverage01 ) = "" Then x7105.SizeAverage01 = Space(1) 
    If trim$( x7105.SizeAverage02 ) = "" Then x7105.SizeAverage02 = Space(1) 
    If trim$( x7105.SizeAverage03 ) = "" Then x7105.SizeAverage03 = Space(1) 
    If trim$( x7105.SizeAverage04 ) = "" Then x7105.SizeAverage04 = Space(1) 
    If trim$( x7105.SizeAverage05 ) = "" Then x7105.SizeAverage05 = Space(1) 
    If trim$( x7105.Size01 ) = "" Then x7105.Size01 = Space(1) 
    If trim$( x7105.Size02 ) = "" Then x7105.Size02 = Space(1) 
    If trim$( x7105.Size03 ) = "" Then x7105.Size03 = Space(1) 
    If trim$( x7105.Size04 ) = "" Then x7105.Size04 = Space(1) 
    If trim$( x7105.Size05 ) = "" Then x7105.Size05 = Space(1) 
    If trim$( x7105.Size06 ) = "" Then x7105.Size06 = Space(1) 
    If trim$( x7105.Size07 ) = "" Then x7105.Size07 = Space(1) 
    If trim$( x7105.Size08 ) = "" Then x7105.Size08 = Space(1) 
    If trim$( x7105.Size09 ) = "" Then x7105.Size09 = Space(1) 
    If trim$( x7105.Size10 ) = "" Then x7105.Size10 = Space(1) 
    If trim$( x7105.Size11 ) = "" Then x7105.Size11 = Space(1) 
    If trim$( x7105.Size12 ) = "" Then x7105.Size12 = Space(1) 
    If trim$( x7105.Size13 ) = "" Then x7105.Size13 = Space(1) 
    If trim$( x7105.Size14 ) = "" Then x7105.Size14 = Space(1) 
    If trim$( x7105.Size15 ) = "" Then x7105.Size15 = Space(1) 
    If trim$( x7105.Size16 ) = "" Then x7105.Size16 = Space(1) 
    If trim$( x7105.Size17 ) = "" Then x7105.Size17 = Space(1) 
    If trim$( x7105.Size18 ) = "" Then x7105.Size18 = Space(1) 
    If trim$( x7105.Size19 ) = "" Then x7105.Size19 = Space(1) 
    If trim$( x7105.Size20 ) = "" Then x7105.Size20 = Space(1) 
    If trim$( x7105.Size21 ) = "" Then x7105.Size21 = Space(1) 
    If trim$( x7105.Size22 ) = "" Then x7105.Size22 = Space(1) 
    If trim$( x7105.Size23 ) = "" Then x7105.Size23 = Space(1) 
    If trim$( x7105.Size24 ) = "" Then x7105.Size24 = Space(1) 
    If trim$( x7105.Size25 ) = "" Then x7105.Size25 = Space(1) 
    If trim$( x7105.Size26 ) = "" Then x7105.Size26 = Space(1) 
    If trim$( x7105.Size27 ) = "" Then x7105.Size27 = Space(1) 
    If trim$( x7105.Size28 ) = "" Then x7105.Size28 = Space(1) 
    If trim$( x7105.Size29 ) = "" Then x7105.Size29 = Space(1) 
    If trim$( x7105.Size30 ) = "" Then x7105.Size30 = Space(1) 
    If trim$( x7105.DateInsert ) = "" Then x7105.DateInsert = Space(1) 
    If trim$( x7105.DateUpdate ) = "" Then x7105.DateUpdate = Space(1) 
    If trim$( x7105.InchargeInsert ) = "" Then x7105.InchargeInsert = Space(1) 
    If trim$( x7105.InchargeUpdate ) = "" Then x7105.InchargeUpdate = Space(1) 
    If trim$( x7105.CheckUse ) = "" Then x7105.CheckUse = Space(1) 
    If trim$( x7105.CheckComplete ) = "" Then x7105.CheckComplete = Space(1) 
    If trim$( x7105.Remark ) = "" Then x7105.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7105_MOVE(rs7105 As SqlClient.SqlDataReader)
Try

    call D7105_CLEAR()   

    If IsdbNull(rs7105!K7105_SizeRangeTool) = False Then D7105.SizeRangeTool = Trim$(rs7105!K7105_SizeRangeTool)
    If IsdbNull(rs7105!K7105_seSizeGroup) = False Then D7105.seSizeGroup = Trim$(rs7105!K7105_seSizeGroup)
    If IsdbNull(rs7105!K7105_cdSizeGroup) = False Then D7105.cdSizeGroup = Trim$(rs7105!K7105_cdSizeGroup)
    If IsdbNull(rs7105!K7105_CustomerCode) = False Then D7105.CustomerCode = Trim$(rs7105!K7105_CustomerCode)
    If IsdbNull(rs7105!K7105_SizeRangeToolName) = False Then D7105.SizeRangeToolName = Trim$(rs7105!K7105_SizeRangeToolName)
    If IsdbNull(rs7105!K7105_SizeRangeToolSimpleName) = False Then D7105.SizeRangeToolSimpleName = Trim$(rs7105!K7105_SizeRangeToolSimpleName)
    If IsdbNull(rs7105!K7105_seGender) = False Then D7105.seGender = Trim$(rs7105!K7105_seGender)
    If IsdbNull(rs7105!K7105_cdGender) = False Then D7105.cdGender = Trim$(rs7105!K7105_cdGender)
    If IsdbNull(rs7105!K7105_seSeason) = False Then D7105.seSeason = Trim$(rs7105!K7105_seSeason)
    If IsdbNull(rs7105!K7105_cdSeason) = False Then D7105.cdSeason = Trim$(rs7105!K7105_cdSeason)
    If IsdbNull(rs7105!K7105_SizeAverage01) = False Then D7105.SizeAverage01 = Trim$(rs7105!K7105_SizeAverage01)
    If IsdbNull(rs7105!K7105_SizeAverage02) = False Then D7105.SizeAverage02 = Trim$(rs7105!K7105_SizeAverage02)
    If IsdbNull(rs7105!K7105_SizeAverage03) = False Then D7105.SizeAverage03 = Trim$(rs7105!K7105_SizeAverage03)
    If IsdbNull(rs7105!K7105_SizeAverage04) = False Then D7105.SizeAverage04 = Trim$(rs7105!K7105_SizeAverage04)
    If IsdbNull(rs7105!K7105_SizeAverage05) = False Then D7105.SizeAverage05 = Trim$(rs7105!K7105_SizeAverage05)
    If IsdbNull(rs7105!K7105_Size01) = False Then D7105.Size01 = Trim$(rs7105!K7105_Size01)
    If IsdbNull(rs7105!K7105_Size02) = False Then D7105.Size02 = Trim$(rs7105!K7105_Size02)
    If IsdbNull(rs7105!K7105_Size03) = False Then D7105.Size03 = Trim$(rs7105!K7105_Size03)
    If IsdbNull(rs7105!K7105_Size04) = False Then D7105.Size04 = Trim$(rs7105!K7105_Size04)
    If IsdbNull(rs7105!K7105_Size05) = False Then D7105.Size05 = Trim$(rs7105!K7105_Size05)
    If IsdbNull(rs7105!K7105_Size06) = False Then D7105.Size06 = Trim$(rs7105!K7105_Size06)
    If IsdbNull(rs7105!K7105_Size07) = False Then D7105.Size07 = Trim$(rs7105!K7105_Size07)
    If IsdbNull(rs7105!K7105_Size08) = False Then D7105.Size08 = Trim$(rs7105!K7105_Size08)
    If IsdbNull(rs7105!K7105_Size09) = False Then D7105.Size09 = Trim$(rs7105!K7105_Size09)
    If IsdbNull(rs7105!K7105_Size10) = False Then D7105.Size10 = Trim$(rs7105!K7105_Size10)
    If IsdbNull(rs7105!K7105_Size11) = False Then D7105.Size11 = Trim$(rs7105!K7105_Size11)
    If IsdbNull(rs7105!K7105_Size12) = False Then D7105.Size12 = Trim$(rs7105!K7105_Size12)
    If IsdbNull(rs7105!K7105_Size13) = False Then D7105.Size13 = Trim$(rs7105!K7105_Size13)
    If IsdbNull(rs7105!K7105_Size14) = False Then D7105.Size14 = Trim$(rs7105!K7105_Size14)
    If IsdbNull(rs7105!K7105_Size15) = False Then D7105.Size15 = Trim$(rs7105!K7105_Size15)
    If IsdbNull(rs7105!K7105_Size16) = False Then D7105.Size16 = Trim$(rs7105!K7105_Size16)
    If IsdbNull(rs7105!K7105_Size17) = False Then D7105.Size17 = Trim$(rs7105!K7105_Size17)
    If IsdbNull(rs7105!K7105_Size18) = False Then D7105.Size18 = Trim$(rs7105!K7105_Size18)
    If IsdbNull(rs7105!K7105_Size19) = False Then D7105.Size19 = Trim$(rs7105!K7105_Size19)
    If IsdbNull(rs7105!K7105_Size20) = False Then D7105.Size20 = Trim$(rs7105!K7105_Size20)
    If IsdbNull(rs7105!K7105_Size21) = False Then D7105.Size21 = Trim$(rs7105!K7105_Size21)
    If IsdbNull(rs7105!K7105_Size22) = False Then D7105.Size22 = Trim$(rs7105!K7105_Size22)
    If IsdbNull(rs7105!K7105_Size23) = False Then D7105.Size23 = Trim$(rs7105!K7105_Size23)
    If IsdbNull(rs7105!K7105_Size24) = False Then D7105.Size24 = Trim$(rs7105!K7105_Size24)
    If IsdbNull(rs7105!K7105_Size25) = False Then D7105.Size25 = Trim$(rs7105!K7105_Size25)
    If IsdbNull(rs7105!K7105_Size26) = False Then D7105.Size26 = Trim$(rs7105!K7105_Size26)
    If IsdbNull(rs7105!K7105_Size27) = False Then D7105.Size27 = Trim$(rs7105!K7105_Size27)
    If IsdbNull(rs7105!K7105_Size28) = False Then D7105.Size28 = Trim$(rs7105!K7105_Size28)
    If IsdbNull(rs7105!K7105_Size29) = False Then D7105.Size29 = Trim$(rs7105!K7105_Size29)
    If IsdbNull(rs7105!K7105_Size30) = False Then D7105.Size30 = Trim$(rs7105!K7105_Size30)
    If IsdbNull(rs7105!K7105_DateInsert) = False Then D7105.DateInsert = Trim$(rs7105!K7105_DateInsert)
    If IsdbNull(rs7105!K7105_DateUpdate) = False Then D7105.DateUpdate = Trim$(rs7105!K7105_DateUpdate)
    If IsdbNull(rs7105!K7105_InchargeInsert) = False Then D7105.InchargeInsert = Trim$(rs7105!K7105_InchargeInsert)
    If IsdbNull(rs7105!K7105_InchargeUpdate) = False Then D7105.InchargeUpdate = Trim$(rs7105!K7105_InchargeUpdate)
    If IsdbNull(rs7105!K7105_CheckUse) = False Then D7105.CheckUse = Trim$(rs7105!K7105_CheckUse)
    If IsdbNull(rs7105!K7105_CheckComplete) = False Then D7105.CheckComplete = Trim$(rs7105!K7105_CheckComplete)
    If IsdbNull(rs7105!K7105_Remark) = False Then D7105.Remark = Trim$(rs7105!K7105_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7105_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7105_MOVE(rs7105 As DataRow)
Try

    call D7105_CLEAR()   

    If IsdbNull(rs7105!K7105_SizeRangeTool) = False Then D7105.SizeRangeTool = Trim$(rs7105!K7105_SizeRangeTool)
    If IsdbNull(rs7105!K7105_seSizeGroup) = False Then D7105.seSizeGroup = Trim$(rs7105!K7105_seSizeGroup)
    If IsdbNull(rs7105!K7105_cdSizeGroup) = False Then D7105.cdSizeGroup = Trim$(rs7105!K7105_cdSizeGroup)
    If IsdbNull(rs7105!K7105_CustomerCode) = False Then D7105.CustomerCode = Trim$(rs7105!K7105_CustomerCode)
    If IsdbNull(rs7105!K7105_SizeRangeToolName) = False Then D7105.SizeRangeToolName = Trim$(rs7105!K7105_SizeRangeToolName)
    If IsdbNull(rs7105!K7105_SizeRangeToolSimpleName) = False Then D7105.SizeRangeToolSimpleName = Trim$(rs7105!K7105_SizeRangeToolSimpleName)
    If IsdbNull(rs7105!K7105_seGender) = False Then D7105.seGender = Trim$(rs7105!K7105_seGender)
    If IsdbNull(rs7105!K7105_cdGender) = False Then D7105.cdGender = Trim$(rs7105!K7105_cdGender)
    If IsdbNull(rs7105!K7105_seSeason) = False Then D7105.seSeason = Trim$(rs7105!K7105_seSeason)
    If IsdbNull(rs7105!K7105_cdSeason) = False Then D7105.cdSeason = Trim$(rs7105!K7105_cdSeason)
    If IsdbNull(rs7105!K7105_SizeAverage01) = False Then D7105.SizeAverage01 = Trim$(rs7105!K7105_SizeAverage01)
    If IsdbNull(rs7105!K7105_SizeAverage02) = False Then D7105.SizeAverage02 = Trim$(rs7105!K7105_SizeAverage02)
    If IsdbNull(rs7105!K7105_SizeAverage03) = False Then D7105.SizeAverage03 = Trim$(rs7105!K7105_SizeAverage03)
    If IsdbNull(rs7105!K7105_SizeAverage04) = False Then D7105.SizeAverage04 = Trim$(rs7105!K7105_SizeAverage04)
    If IsdbNull(rs7105!K7105_SizeAverage05) = False Then D7105.SizeAverage05 = Trim$(rs7105!K7105_SizeAverage05)
    If IsdbNull(rs7105!K7105_Size01) = False Then D7105.Size01 = Trim$(rs7105!K7105_Size01)
    If IsdbNull(rs7105!K7105_Size02) = False Then D7105.Size02 = Trim$(rs7105!K7105_Size02)
    If IsdbNull(rs7105!K7105_Size03) = False Then D7105.Size03 = Trim$(rs7105!K7105_Size03)
    If IsdbNull(rs7105!K7105_Size04) = False Then D7105.Size04 = Trim$(rs7105!K7105_Size04)
    If IsdbNull(rs7105!K7105_Size05) = False Then D7105.Size05 = Trim$(rs7105!K7105_Size05)
    If IsdbNull(rs7105!K7105_Size06) = False Then D7105.Size06 = Trim$(rs7105!K7105_Size06)
    If IsdbNull(rs7105!K7105_Size07) = False Then D7105.Size07 = Trim$(rs7105!K7105_Size07)
    If IsdbNull(rs7105!K7105_Size08) = False Then D7105.Size08 = Trim$(rs7105!K7105_Size08)
    If IsdbNull(rs7105!K7105_Size09) = False Then D7105.Size09 = Trim$(rs7105!K7105_Size09)
    If IsdbNull(rs7105!K7105_Size10) = False Then D7105.Size10 = Trim$(rs7105!K7105_Size10)
    If IsdbNull(rs7105!K7105_Size11) = False Then D7105.Size11 = Trim$(rs7105!K7105_Size11)
    If IsdbNull(rs7105!K7105_Size12) = False Then D7105.Size12 = Trim$(rs7105!K7105_Size12)
    If IsdbNull(rs7105!K7105_Size13) = False Then D7105.Size13 = Trim$(rs7105!K7105_Size13)
    If IsdbNull(rs7105!K7105_Size14) = False Then D7105.Size14 = Trim$(rs7105!K7105_Size14)
    If IsdbNull(rs7105!K7105_Size15) = False Then D7105.Size15 = Trim$(rs7105!K7105_Size15)
    If IsdbNull(rs7105!K7105_Size16) = False Then D7105.Size16 = Trim$(rs7105!K7105_Size16)
    If IsdbNull(rs7105!K7105_Size17) = False Then D7105.Size17 = Trim$(rs7105!K7105_Size17)
    If IsdbNull(rs7105!K7105_Size18) = False Then D7105.Size18 = Trim$(rs7105!K7105_Size18)
    If IsdbNull(rs7105!K7105_Size19) = False Then D7105.Size19 = Trim$(rs7105!K7105_Size19)
    If IsdbNull(rs7105!K7105_Size20) = False Then D7105.Size20 = Trim$(rs7105!K7105_Size20)
    If IsdbNull(rs7105!K7105_Size21) = False Then D7105.Size21 = Trim$(rs7105!K7105_Size21)
    If IsdbNull(rs7105!K7105_Size22) = False Then D7105.Size22 = Trim$(rs7105!K7105_Size22)
    If IsdbNull(rs7105!K7105_Size23) = False Then D7105.Size23 = Trim$(rs7105!K7105_Size23)
    If IsdbNull(rs7105!K7105_Size24) = False Then D7105.Size24 = Trim$(rs7105!K7105_Size24)
    If IsdbNull(rs7105!K7105_Size25) = False Then D7105.Size25 = Trim$(rs7105!K7105_Size25)
    If IsdbNull(rs7105!K7105_Size26) = False Then D7105.Size26 = Trim$(rs7105!K7105_Size26)
    If IsdbNull(rs7105!K7105_Size27) = False Then D7105.Size27 = Trim$(rs7105!K7105_Size27)
    If IsdbNull(rs7105!K7105_Size28) = False Then D7105.Size28 = Trim$(rs7105!K7105_Size28)
    If IsdbNull(rs7105!K7105_Size29) = False Then D7105.Size29 = Trim$(rs7105!K7105_Size29)
    If IsdbNull(rs7105!K7105_Size30) = False Then D7105.Size30 = Trim$(rs7105!K7105_Size30)
    If IsdbNull(rs7105!K7105_DateInsert) = False Then D7105.DateInsert = Trim$(rs7105!K7105_DateInsert)
    If IsdbNull(rs7105!K7105_DateUpdate) = False Then D7105.DateUpdate = Trim$(rs7105!K7105_DateUpdate)
    If IsdbNull(rs7105!K7105_InchargeInsert) = False Then D7105.InchargeInsert = Trim$(rs7105!K7105_InchargeInsert)
    If IsdbNull(rs7105!K7105_InchargeUpdate) = False Then D7105.InchargeUpdate = Trim$(rs7105!K7105_InchargeUpdate)
    If IsdbNull(rs7105!K7105_CheckUse) = False Then D7105.CheckUse = Trim$(rs7105!K7105_CheckUse)
    If IsdbNull(rs7105!K7105_CheckComplete) = False Then D7105.CheckComplete = Trim$(rs7105!K7105_CheckComplete)
    If IsdbNull(rs7105!K7105_Remark) = False Then D7105.Remark = Trim$(rs7105!K7105_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7105_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7105_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7105 As T7105_AREA, SIZERANGETOOL AS String) as Boolean

K7105_MOVE = False

Try
    If READ_PFK7105(SIZERANGETOOL) = True Then
                z7105 = D7105
		K7105_MOVE = True
		else
	z7105 = nothing
     End If

     If  getColumIndex(spr,"SizeRangeTool") > -1 then z7105.SizeRangeTool = getDataM(spr, getColumIndex(spr,"SizeRangeTool"), xRow)
     If  getColumIndex(spr,"seSizeGroup") > -1 then z7105.seSizeGroup = getDataM(spr, getColumIndex(spr,"seSizeGroup"), xRow)
     If  getColumIndex(spr,"cdSizeGroup") > -1 then z7105.cdSizeGroup = getDataM(spr, getColumIndex(spr,"cdSizeGroup"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z7105.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"SizeRangeToolName") > -1 then z7105.SizeRangeToolName = getDataM(spr, getColumIndex(spr,"SizeRangeToolName"), xRow)
     If  getColumIndex(spr,"SizeRangeToolSimpleName") > -1 then z7105.SizeRangeToolSimpleName = getDataM(spr, getColumIndex(spr,"SizeRangeToolSimpleName"), xRow)
     If  getColumIndex(spr,"seGender") > -1 then z7105.seGender = getDataM(spr, getColumIndex(spr,"seGender"), xRow)
     If  getColumIndex(spr,"cdGender") > -1 then z7105.cdGender = getDataM(spr, getColumIndex(spr,"cdGender"), xRow)
     If  getColumIndex(spr,"seSeason") > -1 then z7105.seSeason = getDataM(spr, getColumIndex(spr,"seSeason"), xRow)
     If  getColumIndex(spr,"cdSeason") > -1 then z7105.cdSeason = getDataM(spr, getColumIndex(spr,"cdSeason"), xRow)
     If  getColumIndex(spr,"SizeAverage01") > -1 then z7105.SizeAverage01 = getDataM(spr, getColumIndex(spr,"SizeAverage01"), xRow)
     If  getColumIndex(spr,"SizeAverage02") > -1 then z7105.SizeAverage02 = getDataM(spr, getColumIndex(spr,"SizeAverage02"), xRow)
     If  getColumIndex(spr,"SizeAverage03") > -1 then z7105.SizeAverage03 = getDataM(spr, getColumIndex(spr,"SizeAverage03"), xRow)
     If  getColumIndex(spr,"SizeAverage04") > -1 then z7105.SizeAverage04 = getDataM(spr, getColumIndex(spr,"SizeAverage04"), xRow)
     If  getColumIndex(spr,"SizeAverage05") > -1 then z7105.SizeAverage05 = getDataM(spr, getColumIndex(spr,"SizeAverage05"), xRow)
     If  getColumIndex(spr,"Size01") > -1 then z7105.Size01 = getDataM(spr, getColumIndex(spr,"Size01"), xRow)
     If  getColumIndex(spr,"Size02") > -1 then z7105.Size02 = getDataM(spr, getColumIndex(spr,"Size02"), xRow)
     If  getColumIndex(spr,"Size03") > -1 then z7105.Size03 = getDataM(spr, getColumIndex(spr,"Size03"), xRow)
     If  getColumIndex(spr,"Size04") > -1 then z7105.Size04 = getDataM(spr, getColumIndex(spr,"Size04"), xRow)
     If  getColumIndex(spr,"Size05") > -1 then z7105.Size05 = getDataM(spr, getColumIndex(spr,"Size05"), xRow)
     If  getColumIndex(spr,"Size06") > -1 then z7105.Size06 = getDataM(spr, getColumIndex(spr,"Size06"), xRow)
     If  getColumIndex(spr,"Size07") > -1 then z7105.Size07 = getDataM(spr, getColumIndex(spr,"Size07"), xRow)
     If  getColumIndex(spr,"Size08") > -1 then z7105.Size08 = getDataM(spr, getColumIndex(spr,"Size08"), xRow)
     If  getColumIndex(spr,"Size09") > -1 then z7105.Size09 = getDataM(spr, getColumIndex(spr,"Size09"), xRow)
     If  getColumIndex(spr,"Size10") > -1 then z7105.Size10 = getDataM(spr, getColumIndex(spr,"Size10"), xRow)
     If  getColumIndex(spr,"Size11") > -1 then z7105.Size11 = getDataM(spr, getColumIndex(spr,"Size11"), xRow)
     If  getColumIndex(spr,"Size12") > -1 then z7105.Size12 = getDataM(spr, getColumIndex(spr,"Size12"), xRow)
     If  getColumIndex(spr,"Size13") > -1 then z7105.Size13 = getDataM(spr, getColumIndex(spr,"Size13"), xRow)
     If  getColumIndex(spr,"Size14") > -1 then z7105.Size14 = getDataM(spr, getColumIndex(spr,"Size14"), xRow)
     If  getColumIndex(spr,"Size15") > -1 then z7105.Size15 = getDataM(spr, getColumIndex(spr,"Size15"), xRow)
     If  getColumIndex(spr,"Size16") > -1 then z7105.Size16 = getDataM(spr, getColumIndex(spr,"Size16"), xRow)
     If  getColumIndex(spr,"Size17") > -1 then z7105.Size17 = getDataM(spr, getColumIndex(spr,"Size17"), xRow)
     If  getColumIndex(spr,"Size18") > -1 then z7105.Size18 = getDataM(spr, getColumIndex(spr,"Size18"), xRow)
     If  getColumIndex(spr,"Size19") > -1 then z7105.Size19 = getDataM(spr, getColumIndex(spr,"Size19"), xRow)
     If  getColumIndex(spr,"Size20") > -1 then z7105.Size20 = getDataM(spr, getColumIndex(spr,"Size20"), xRow)
     If  getColumIndex(spr,"Size21") > -1 then z7105.Size21 = getDataM(spr, getColumIndex(spr,"Size21"), xRow)
     If  getColumIndex(spr,"Size22") > -1 then z7105.Size22 = getDataM(spr, getColumIndex(spr,"Size22"), xRow)
     If  getColumIndex(spr,"Size23") > -1 then z7105.Size23 = getDataM(spr, getColumIndex(spr,"Size23"), xRow)
     If  getColumIndex(spr,"Size24") > -1 then z7105.Size24 = getDataM(spr, getColumIndex(spr,"Size24"), xRow)
     If  getColumIndex(spr,"Size25") > -1 then z7105.Size25 = getDataM(spr, getColumIndex(spr,"Size25"), xRow)
     If  getColumIndex(spr,"Size26") > -1 then z7105.Size26 = getDataM(spr, getColumIndex(spr,"Size26"), xRow)
     If  getColumIndex(spr,"Size27") > -1 then z7105.Size27 = getDataM(spr, getColumIndex(spr,"Size27"), xRow)
     If  getColumIndex(spr,"Size28") > -1 then z7105.Size28 = getDataM(spr, getColumIndex(spr,"Size28"), xRow)
     If  getColumIndex(spr,"Size29") > -1 then z7105.Size29 = getDataM(spr, getColumIndex(spr,"Size29"), xRow)
     If  getColumIndex(spr,"Size30") > -1 then z7105.Size30 = getDataM(spr, getColumIndex(spr,"Size30"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7105.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7105.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7105.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7105.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7105.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z7105.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7105.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7105_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7105_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7105 As T7105_AREA,CheckClear as Boolean,SIZERANGETOOL AS String) as Boolean

K7105_MOVE = False

Try
    If READ_PFK7105(SIZERANGETOOL) = True Then
                z7105 = D7105
		K7105_MOVE = True
		else
	If CheckClear  = True then z7105 = nothing
     End If

     If  getColumIndex(spr,"SizeRangeTool") > -1 then z7105.SizeRangeTool = getDataM(spr, getColumIndex(spr,"SizeRangeTool"), xRow)
     If  getColumIndex(spr,"seSizeGroup") > -1 then z7105.seSizeGroup = getDataM(spr, getColumIndex(spr,"seSizeGroup"), xRow)
     If  getColumIndex(spr,"cdSizeGroup") > -1 then z7105.cdSizeGroup = getDataM(spr, getColumIndex(spr,"cdSizeGroup"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z7105.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"SizeRangeToolName") > -1 then z7105.SizeRangeToolName = getDataM(spr, getColumIndex(spr,"SizeRangeToolName"), xRow)
     If  getColumIndex(spr,"SizeRangeToolSimpleName") > -1 then z7105.SizeRangeToolSimpleName = getDataM(spr, getColumIndex(spr,"SizeRangeToolSimpleName"), xRow)
     If  getColumIndex(spr,"seGender") > -1 then z7105.seGender = getDataM(spr, getColumIndex(spr,"seGender"), xRow)
     If  getColumIndex(spr,"cdGender") > -1 then z7105.cdGender = getDataM(spr, getColumIndex(spr,"cdGender"), xRow)
     If  getColumIndex(spr,"seSeason") > -1 then z7105.seSeason = getDataM(spr, getColumIndex(spr,"seSeason"), xRow)
     If  getColumIndex(spr,"cdSeason") > -1 then z7105.cdSeason = getDataM(spr, getColumIndex(spr,"cdSeason"), xRow)
     If  getColumIndex(spr,"SizeAverage01") > -1 then z7105.SizeAverage01 = getDataM(spr, getColumIndex(spr,"SizeAverage01"), xRow)
     If  getColumIndex(spr,"SizeAverage02") > -1 then z7105.SizeAverage02 = getDataM(spr, getColumIndex(spr,"SizeAverage02"), xRow)
     If  getColumIndex(spr,"SizeAverage03") > -1 then z7105.SizeAverage03 = getDataM(spr, getColumIndex(spr,"SizeAverage03"), xRow)
     If  getColumIndex(spr,"SizeAverage04") > -1 then z7105.SizeAverage04 = getDataM(spr, getColumIndex(spr,"SizeAverage04"), xRow)
     If  getColumIndex(spr,"SizeAverage05") > -1 then z7105.SizeAverage05 = getDataM(spr, getColumIndex(spr,"SizeAverage05"), xRow)
     If  getColumIndex(spr,"Size01") > -1 then z7105.Size01 = getDataM(spr, getColumIndex(spr,"Size01"), xRow)
     If  getColumIndex(spr,"Size02") > -1 then z7105.Size02 = getDataM(spr, getColumIndex(spr,"Size02"), xRow)
     If  getColumIndex(spr,"Size03") > -1 then z7105.Size03 = getDataM(spr, getColumIndex(spr,"Size03"), xRow)
     If  getColumIndex(spr,"Size04") > -1 then z7105.Size04 = getDataM(spr, getColumIndex(spr,"Size04"), xRow)
     If  getColumIndex(spr,"Size05") > -1 then z7105.Size05 = getDataM(spr, getColumIndex(spr,"Size05"), xRow)
     If  getColumIndex(spr,"Size06") > -1 then z7105.Size06 = getDataM(spr, getColumIndex(spr,"Size06"), xRow)
     If  getColumIndex(spr,"Size07") > -1 then z7105.Size07 = getDataM(spr, getColumIndex(spr,"Size07"), xRow)
     If  getColumIndex(spr,"Size08") > -1 then z7105.Size08 = getDataM(spr, getColumIndex(spr,"Size08"), xRow)
     If  getColumIndex(spr,"Size09") > -1 then z7105.Size09 = getDataM(spr, getColumIndex(spr,"Size09"), xRow)
     If  getColumIndex(spr,"Size10") > -1 then z7105.Size10 = getDataM(spr, getColumIndex(spr,"Size10"), xRow)
     If  getColumIndex(spr,"Size11") > -1 then z7105.Size11 = getDataM(spr, getColumIndex(spr,"Size11"), xRow)
     If  getColumIndex(spr,"Size12") > -1 then z7105.Size12 = getDataM(spr, getColumIndex(spr,"Size12"), xRow)
     If  getColumIndex(spr,"Size13") > -1 then z7105.Size13 = getDataM(spr, getColumIndex(spr,"Size13"), xRow)
     If  getColumIndex(spr,"Size14") > -1 then z7105.Size14 = getDataM(spr, getColumIndex(spr,"Size14"), xRow)
     If  getColumIndex(spr,"Size15") > -1 then z7105.Size15 = getDataM(spr, getColumIndex(spr,"Size15"), xRow)
     If  getColumIndex(spr,"Size16") > -1 then z7105.Size16 = getDataM(spr, getColumIndex(spr,"Size16"), xRow)
     If  getColumIndex(spr,"Size17") > -1 then z7105.Size17 = getDataM(spr, getColumIndex(spr,"Size17"), xRow)
     If  getColumIndex(spr,"Size18") > -1 then z7105.Size18 = getDataM(spr, getColumIndex(spr,"Size18"), xRow)
     If  getColumIndex(spr,"Size19") > -1 then z7105.Size19 = getDataM(spr, getColumIndex(spr,"Size19"), xRow)
     If  getColumIndex(spr,"Size20") > -1 then z7105.Size20 = getDataM(spr, getColumIndex(spr,"Size20"), xRow)
     If  getColumIndex(spr,"Size21") > -1 then z7105.Size21 = getDataM(spr, getColumIndex(spr,"Size21"), xRow)
     If  getColumIndex(spr,"Size22") > -1 then z7105.Size22 = getDataM(spr, getColumIndex(spr,"Size22"), xRow)
     If  getColumIndex(spr,"Size23") > -1 then z7105.Size23 = getDataM(spr, getColumIndex(spr,"Size23"), xRow)
     If  getColumIndex(spr,"Size24") > -1 then z7105.Size24 = getDataM(spr, getColumIndex(spr,"Size24"), xRow)
     If  getColumIndex(spr,"Size25") > -1 then z7105.Size25 = getDataM(spr, getColumIndex(spr,"Size25"), xRow)
     If  getColumIndex(spr,"Size26") > -1 then z7105.Size26 = getDataM(spr, getColumIndex(spr,"Size26"), xRow)
     If  getColumIndex(spr,"Size27") > -1 then z7105.Size27 = getDataM(spr, getColumIndex(spr,"Size27"), xRow)
     If  getColumIndex(spr,"Size28") > -1 then z7105.Size28 = getDataM(spr, getColumIndex(spr,"Size28"), xRow)
     If  getColumIndex(spr,"Size29") > -1 then z7105.Size29 = getDataM(spr, getColumIndex(spr,"Size29"), xRow)
     If  getColumIndex(spr,"Size30") > -1 then z7105.Size30 = getDataM(spr, getColumIndex(spr,"Size30"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7105.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7105.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7105.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7105.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7105.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z7105.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7105.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7105_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7105_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7105 As T7105_AREA, Job as String, SIZERANGETOOL AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7105_MOVE = False

Try
    If READ_PFK7105(SIZERANGETOOL) = True Then
                z7105 = D7105
		K7105_MOVE = True
		else
	z7105 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7105")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SIZERANGETOOL":z7105.SizeRangeTool = Children(i).Code
   Case "SESIZEGROUP":z7105.seSizeGroup = Children(i).Code
   Case "CDSIZEGROUP":z7105.cdSizeGroup = Children(i).Code
   Case "CUSTOMERCODE":z7105.CustomerCode = Children(i).Code
   Case "SIZERANGETOOLNAME":z7105.SizeRangeToolName = Children(i).Code
   Case "SIZERANGETOOLSIMPLENAME":z7105.SizeRangeToolSimpleName = Children(i).Code
   Case "SEGENDER":z7105.seGender = Children(i).Code
   Case "CDGENDER":z7105.cdGender = Children(i).Code
   Case "SESEASON":z7105.seSeason = Children(i).Code
   Case "CDSEASON":z7105.cdSeason = Children(i).Code
   Case "SIZEAVERAGE01":z7105.SizeAverage01 = Children(i).Code
   Case "SIZEAVERAGE02":z7105.SizeAverage02 = Children(i).Code
   Case "SIZEAVERAGE03":z7105.SizeAverage03 = Children(i).Code
   Case "SIZEAVERAGE04":z7105.SizeAverage04 = Children(i).Code
   Case "SIZEAVERAGE05":z7105.SizeAverage05 = Children(i).Code
   Case "SIZE01":z7105.Size01 = Children(i).Code
   Case "SIZE02":z7105.Size02 = Children(i).Code
   Case "SIZE03":z7105.Size03 = Children(i).Code
   Case "SIZE04":z7105.Size04 = Children(i).Code
   Case "SIZE05":z7105.Size05 = Children(i).Code
   Case "SIZE06":z7105.Size06 = Children(i).Code
   Case "SIZE07":z7105.Size07 = Children(i).Code
   Case "SIZE08":z7105.Size08 = Children(i).Code
   Case "SIZE09":z7105.Size09 = Children(i).Code
   Case "SIZE10":z7105.Size10 = Children(i).Code
   Case "SIZE11":z7105.Size11 = Children(i).Code
   Case "SIZE12":z7105.Size12 = Children(i).Code
   Case "SIZE13":z7105.Size13 = Children(i).Code
   Case "SIZE14":z7105.Size14 = Children(i).Code
   Case "SIZE15":z7105.Size15 = Children(i).Code
   Case "SIZE16":z7105.Size16 = Children(i).Code
   Case "SIZE17":z7105.Size17 = Children(i).Code
   Case "SIZE18":z7105.Size18 = Children(i).Code
   Case "SIZE19":z7105.Size19 = Children(i).Code
   Case "SIZE20":z7105.Size20 = Children(i).Code
   Case "SIZE21":z7105.Size21 = Children(i).Code
   Case "SIZE22":z7105.Size22 = Children(i).Code
   Case "SIZE23":z7105.Size23 = Children(i).Code
   Case "SIZE24":z7105.Size24 = Children(i).Code
   Case "SIZE25":z7105.Size25 = Children(i).Code
   Case "SIZE26":z7105.Size26 = Children(i).Code
   Case "SIZE27":z7105.Size27 = Children(i).Code
   Case "SIZE28":z7105.Size28 = Children(i).Code
   Case "SIZE29":z7105.Size29 = Children(i).Code
   Case "SIZE30":z7105.Size30 = Children(i).Code
   Case "DATEINSERT":z7105.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7105.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7105.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7105.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7105.CheckUse = Children(i).Code
   Case "CHECKCOMPLETE":z7105.CheckComplete = Children(i).Code
   Case "REMARK":z7105.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SIZERANGETOOL":z7105.SizeRangeTool = Children(i).Data
   Case "SESIZEGROUP":z7105.seSizeGroup = Children(i).Data
   Case "CDSIZEGROUP":z7105.cdSizeGroup = Children(i).Data
   Case "CUSTOMERCODE":z7105.CustomerCode = Children(i).Data
   Case "SIZERANGETOOLNAME":z7105.SizeRangeToolName = Children(i).Data
   Case "SIZERANGETOOLSIMPLENAME":z7105.SizeRangeToolSimpleName = Children(i).Data
   Case "SEGENDER":z7105.seGender = Children(i).Data
   Case "CDGENDER":z7105.cdGender = Children(i).Data
   Case "SESEASON":z7105.seSeason = Children(i).Data
   Case "CDSEASON":z7105.cdSeason = Children(i).Data
   Case "SIZEAVERAGE01":z7105.SizeAverage01 = Children(i).Data
   Case "SIZEAVERAGE02":z7105.SizeAverage02 = Children(i).Data
   Case "SIZEAVERAGE03":z7105.SizeAverage03 = Children(i).Data
   Case "SIZEAVERAGE04":z7105.SizeAverage04 = Children(i).Data
   Case "SIZEAVERAGE05":z7105.SizeAverage05 = Children(i).Data
   Case "SIZE01":z7105.Size01 = Children(i).Data
   Case "SIZE02":z7105.Size02 = Children(i).Data
   Case "SIZE03":z7105.Size03 = Children(i).Data
   Case "SIZE04":z7105.Size04 = Children(i).Data
   Case "SIZE05":z7105.Size05 = Children(i).Data
   Case "SIZE06":z7105.Size06 = Children(i).Data
   Case "SIZE07":z7105.Size07 = Children(i).Data
   Case "SIZE08":z7105.Size08 = Children(i).Data
   Case "SIZE09":z7105.Size09 = Children(i).Data
   Case "SIZE10":z7105.Size10 = Children(i).Data
   Case "SIZE11":z7105.Size11 = Children(i).Data
   Case "SIZE12":z7105.Size12 = Children(i).Data
   Case "SIZE13":z7105.Size13 = Children(i).Data
   Case "SIZE14":z7105.Size14 = Children(i).Data
   Case "SIZE15":z7105.Size15 = Children(i).Data
   Case "SIZE16":z7105.Size16 = Children(i).Data
   Case "SIZE17":z7105.Size17 = Children(i).Data
   Case "SIZE18":z7105.Size18 = Children(i).Data
   Case "SIZE19":z7105.Size19 = Children(i).Data
   Case "SIZE20":z7105.Size20 = Children(i).Data
   Case "SIZE21":z7105.Size21 = Children(i).Data
   Case "SIZE22":z7105.Size22 = Children(i).Data
   Case "SIZE23":z7105.Size23 = Children(i).Data
   Case "SIZE24":z7105.Size24 = Children(i).Data
   Case "SIZE25":z7105.Size25 = Children(i).Data
   Case "SIZE26":z7105.Size26 = Children(i).Data
   Case "SIZE27":z7105.Size27 = Children(i).Data
   Case "SIZE28":z7105.Size28 = Children(i).Data
   Case "SIZE29":z7105.Size29 = Children(i).Data
   Case "SIZE30":z7105.Size30 = Children(i).Data
   Case "DATEINSERT":z7105.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7105.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7105.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7105.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7105.CheckUse = Children(i).Data
   Case "CHECKCOMPLETE":z7105.CheckComplete = Children(i).Data
   Case "REMARK":z7105.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7105_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7105_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7105 As T7105_AREA, Job as String, CheckClear as Boolean, SIZERANGETOOL AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7105_MOVE = False

Try
    If READ_PFK7105(SIZERANGETOOL) = True Then
                z7105 = D7105
		K7105_MOVE = True
		else
	If CheckClear  = True then z7105 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7105")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SIZERANGETOOL":z7105.SizeRangeTool = Children(i).Code
   Case "SESIZEGROUP":z7105.seSizeGroup = Children(i).Code
   Case "CDSIZEGROUP":z7105.cdSizeGroup = Children(i).Code
   Case "CUSTOMERCODE":z7105.CustomerCode = Children(i).Code
   Case "SIZERANGETOOLNAME":z7105.SizeRangeToolName = Children(i).Code
   Case "SIZERANGETOOLSIMPLENAME":z7105.SizeRangeToolSimpleName = Children(i).Code
   Case "SEGENDER":z7105.seGender = Children(i).Code
   Case "CDGENDER":z7105.cdGender = Children(i).Code
   Case "SESEASON":z7105.seSeason = Children(i).Code
   Case "CDSEASON":z7105.cdSeason = Children(i).Code
   Case "SIZEAVERAGE01":z7105.SizeAverage01 = Children(i).Code
   Case "SIZEAVERAGE02":z7105.SizeAverage02 = Children(i).Code
   Case "SIZEAVERAGE03":z7105.SizeAverage03 = Children(i).Code
   Case "SIZEAVERAGE04":z7105.SizeAverage04 = Children(i).Code
   Case "SIZEAVERAGE05":z7105.SizeAverage05 = Children(i).Code
   Case "SIZE01":z7105.Size01 = Children(i).Code
   Case "SIZE02":z7105.Size02 = Children(i).Code
   Case "SIZE03":z7105.Size03 = Children(i).Code
   Case "SIZE04":z7105.Size04 = Children(i).Code
   Case "SIZE05":z7105.Size05 = Children(i).Code
   Case "SIZE06":z7105.Size06 = Children(i).Code
   Case "SIZE07":z7105.Size07 = Children(i).Code
   Case "SIZE08":z7105.Size08 = Children(i).Code
   Case "SIZE09":z7105.Size09 = Children(i).Code
   Case "SIZE10":z7105.Size10 = Children(i).Code
   Case "SIZE11":z7105.Size11 = Children(i).Code
   Case "SIZE12":z7105.Size12 = Children(i).Code
   Case "SIZE13":z7105.Size13 = Children(i).Code
   Case "SIZE14":z7105.Size14 = Children(i).Code
   Case "SIZE15":z7105.Size15 = Children(i).Code
   Case "SIZE16":z7105.Size16 = Children(i).Code
   Case "SIZE17":z7105.Size17 = Children(i).Code
   Case "SIZE18":z7105.Size18 = Children(i).Code
   Case "SIZE19":z7105.Size19 = Children(i).Code
   Case "SIZE20":z7105.Size20 = Children(i).Code
   Case "SIZE21":z7105.Size21 = Children(i).Code
   Case "SIZE22":z7105.Size22 = Children(i).Code
   Case "SIZE23":z7105.Size23 = Children(i).Code
   Case "SIZE24":z7105.Size24 = Children(i).Code
   Case "SIZE25":z7105.Size25 = Children(i).Code
   Case "SIZE26":z7105.Size26 = Children(i).Code
   Case "SIZE27":z7105.Size27 = Children(i).Code
   Case "SIZE28":z7105.Size28 = Children(i).Code
   Case "SIZE29":z7105.Size29 = Children(i).Code
   Case "SIZE30":z7105.Size30 = Children(i).Code
   Case "DATEINSERT":z7105.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7105.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7105.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7105.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7105.CheckUse = Children(i).Code
   Case "CHECKCOMPLETE":z7105.CheckComplete = Children(i).Code
   Case "REMARK":z7105.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SIZERANGETOOL":z7105.SizeRangeTool = Children(i).Data
   Case "SESIZEGROUP":z7105.seSizeGroup = Children(i).Data
   Case "CDSIZEGROUP":z7105.cdSizeGroup = Children(i).Data
   Case "CUSTOMERCODE":z7105.CustomerCode = Children(i).Data
   Case "SIZERANGETOOLNAME":z7105.SizeRangeToolName = Children(i).Data
   Case "SIZERANGETOOLSIMPLENAME":z7105.SizeRangeToolSimpleName = Children(i).Data
   Case "SEGENDER":z7105.seGender = Children(i).Data
   Case "CDGENDER":z7105.cdGender = Children(i).Data
   Case "SESEASON":z7105.seSeason = Children(i).Data
   Case "CDSEASON":z7105.cdSeason = Children(i).Data
   Case "SIZEAVERAGE01":z7105.SizeAverage01 = Children(i).Data
   Case "SIZEAVERAGE02":z7105.SizeAverage02 = Children(i).Data
   Case "SIZEAVERAGE03":z7105.SizeAverage03 = Children(i).Data
   Case "SIZEAVERAGE04":z7105.SizeAverage04 = Children(i).Data
   Case "SIZEAVERAGE05":z7105.SizeAverage05 = Children(i).Data
   Case "SIZE01":z7105.Size01 = Children(i).Data
   Case "SIZE02":z7105.Size02 = Children(i).Data
   Case "SIZE03":z7105.Size03 = Children(i).Data
   Case "SIZE04":z7105.Size04 = Children(i).Data
   Case "SIZE05":z7105.Size05 = Children(i).Data
   Case "SIZE06":z7105.Size06 = Children(i).Data
   Case "SIZE07":z7105.Size07 = Children(i).Data
   Case "SIZE08":z7105.Size08 = Children(i).Data
   Case "SIZE09":z7105.Size09 = Children(i).Data
   Case "SIZE10":z7105.Size10 = Children(i).Data
   Case "SIZE11":z7105.Size11 = Children(i).Data
   Case "SIZE12":z7105.Size12 = Children(i).Data
   Case "SIZE13":z7105.Size13 = Children(i).Data
   Case "SIZE14":z7105.Size14 = Children(i).Data
   Case "SIZE15":z7105.Size15 = Children(i).Data
   Case "SIZE16":z7105.Size16 = Children(i).Data
   Case "SIZE17":z7105.Size17 = Children(i).Data
   Case "SIZE18":z7105.Size18 = Children(i).Data
   Case "SIZE19":z7105.Size19 = Children(i).Data
   Case "SIZE20":z7105.Size20 = Children(i).Data
   Case "SIZE21":z7105.Size21 = Children(i).Data
   Case "SIZE22":z7105.Size22 = Children(i).Data
   Case "SIZE23":z7105.Size23 = Children(i).Data
   Case "SIZE24":z7105.Size24 = Children(i).Data
   Case "SIZE25":z7105.Size25 = Children(i).Data
   Case "SIZE26":z7105.Size26 = Children(i).Data
   Case "SIZE27":z7105.Size27 = Children(i).Data
   Case "SIZE28":z7105.Size28 = Children(i).Data
   Case "SIZE29":z7105.Size29 = Children(i).Data
   Case "SIZE30":z7105.Size30 = Children(i).Data
   Case "DATEINSERT":z7105.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7105.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7105.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7105.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7105.CheckUse = Children(i).Data
   Case "CHECKCOMPLETE":z7105.CheckComplete = Children(i).Data
   Case "REMARK":z7105.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7105_MOVE",vbCritical)
End Try
End Function 
    
End Module 
