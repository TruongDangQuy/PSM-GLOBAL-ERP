'=========================================================================================================================================================
'   TABLE : (PFK7171)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7171

Structure T7171_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	BasicSel	 AS String	'			char(3)		*
Public 	BasicCode	 AS String	'			char(3)		*
Public 	NameHLPButton	 AS String	'			nvarchar(50)
Public 	DisplaySeq	 AS Double	'			decimal
Public 	DevelopmentCode	 AS String	'			nvarchar(50)
Public 	seBasicMaster	 AS String	'			char(3)
Public 	cdBasicMaster	 AS String	'			char(3)
Public 	BasicName	 AS String	'			nvarchar(250)
Public 	NameSimply	 AS String	'			nvarchar(100)
Public 	ForeignName1	 AS String	'			nvarchar(100)
Public 	ForeignName2	 AS String	'			nvarchar(100)
Public 	Check1	 AS String	'			char(1)
Public 	Check2	 AS String	'			char(1)
Public 	Check3	 AS String	'			char(1)
Public 	Check4	 AS String	'			char(1)
Public 	Check5	 AS String	'			char(1)
Public 	Check6	 AS String	'			nvarchar(10)
Public 	Check7	 AS String	'			nvarchar(10)
Public 	Check8	 AS String	'			nvarchar(10)
Public 	Check9	 AS String	'			nvarchar(10)
Public 	Check10	 AS String	'			nvarchar(10)
Public 	CheckName1	 AS String	'			nvarchar(50)
Public 	CheckName2	 AS String	'			nvarchar(50)
Public 	CheckName3	 AS String	'			nvarchar(50)
Public 	CheckName4	 AS String	'			nvarchar(10)
Public 	CheckName5	 AS String	'			nvarchar(10)
Public 	CheckName6	 AS String	'			nvarchar(10)
Public 	CheckName7	 AS String	'			nvarchar(20)
Public 	CheckName8	 AS String	'			nvarchar(10)
Public 	CheckName9	 AS String	'			nvarchar(10)
Public 	CheckName10	 AS String	'			nvarchar(10)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	TimeInsert	 AS String	'			char(14)
Public 	TimeUpdate	 AS String	'			char(14)
Public 	TimeLast	 AS String	'			char(14)
Public 	CheckUse	 AS String	'			char(1)
Public 	Remark	 AS String	'			nvarchar(100)
'=========================================================================================================================================================
End structure

Public D7171 As T7171_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7171(BASICSEL AS String, BASICCODE AS String) As Boolean
    READ_PFK7171 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7171 "
    SQL = SQL & " WHERE K7171_BasicSel		 = '" & BasicSel & "' " 
    SQL = SQL & "   AND K7171_BasicCode		 = '" & BasicCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7171_CLEAR: GoTo SKIP_READ_PFK7171
                
    Call K7171_MOVE(rd)
    READ_PFK7171 = True

SKIP_READ_PFK7171:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7171",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7171(BASICSEL AS String, BASICCODE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7171 "
    SQL = SQL & " WHERE K7171_BasicSel		 = '" & BasicSel & "' " 
    SQL = SQL & "   AND K7171_BasicCode		 = '" & BasicCode & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7171",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7171(z7171 As T7171_AREA) As Boolean
    WRITE_PFK7171 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7171)
 
    SQL = " INSERT INTO PFK7171 "
    SQL = SQL & " ( "
    SQL = SQL & " K7171_BasicSel," 
    SQL = SQL & " K7171_BasicCode," 
    SQL = SQL & " K7171_NameHLPButton," 
    SQL = SQL & " K7171_DisplaySeq," 
    SQL = SQL & " K7171_DevelopmentCode," 
    SQL = SQL & " K7171_seBasicMaster," 
    SQL = SQL & " K7171_cdBasicMaster," 
    SQL = SQL & " K7171_BasicName," 
    SQL = SQL & " K7171_NameSimply," 
    SQL = SQL & " K7171_ForeignName1," 
    SQL = SQL & " K7171_ForeignName2," 
    SQL = SQL & " K7171_Check1," 
    SQL = SQL & " K7171_Check2," 
    SQL = SQL & " K7171_Check3," 
    SQL = SQL & " K7171_Check4," 
    SQL = SQL & " K7171_Check5," 
    SQL = SQL & " K7171_Check6," 
    SQL = SQL & " K7171_Check7," 
    SQL = SQL & " K7171_Check8," 
    SQL = SQL & " K7171_Check9," 
    SQL = SQL & " K7171_Check10," 
    SQL = SQL & " K7171_CheckName1," 
    SQL = SQL & " K7171_CheckName2," 
    SQL = SQL & " K7171_CheckName3," 
    SQL = SQL & " K7171_CheckName4," 
    SQL = SQL & " K7171_CheckName5," 
    SQL = SQL & " K7171_CheckName6," 
    SQL = SQL & " K7171_CheckName7," 
    SQL = SQL & " K7171_CheckName8," 
    SQL = SQL & " K7171_CheckName9," 
    SQL = SQL & " K7171_CheckName10," 
    SQL = SQL & " K7171_InchargeInsert," 
    SQL = SQL & " K7171_InchargeUpdate," 
    SQL = SQL & " K7171_DateInsert," 
    SQL = SQL & " K7171_DateUpdate," 
    SQL = SQL & " K7171_TimeInsert," 
    SQL = SQL & " K7171_TimeUpdate," 
    SQL = SQL & " K7171_TimeLast," 
    SQL = SQL & " K7171_CheckUse," 
    SQL = SQL & " K7171_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7171.BasicSel) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7171.BasicCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7171.NameHLPButton) & "', "  
    SQL = SQL & "   " & FormatSQL(z7171.DisplaySeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7171.DevelopmentCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7171.seBasicMaster) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7171.cdBasicMaster) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7171.BasicName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7171.NameSimply) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7171.ForeignName1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7171.ForeignName2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7171.Check1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7171.Check2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7171.Check3) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7171.Check4) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7171.Check5) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7171.Check6) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7171.Check7) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7171.Check8) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7171.Check9) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7171.Check10) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7171.CheckName1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7171.CheckName2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7171.CheckName3) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7171.CheckName4) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7171.CheckName5) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7171.CheckName6) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7171.CheckName7) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7171.CheckName8) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7171.CheckName9) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7171.CheckName10) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7171.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7171.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7171.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7171.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7171.TimeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7171.TimeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7171.TimeLast) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7171.CheckUse) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7171.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7171 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7171",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7171(z7171 As T7171_AREA) As Boolean
    REWRITE_PFK7171 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7171)
   
    SQL = " UPDATE PFK7171 SET "
    SQL = SQL & "    K7171_NameHLPButton      = N'" & FormatSQL(z7171.NameHLPButton) & "', " 
    SQL = SQL & "    K7171_DisplaySeq      =  " & FormatSQL(z7171.DisplaySeq) & ", " 
    SQL = SQL & "    K7171_DevelopmentCode      = N'" & FormatSQL(z7171.DevelopmentCode) & "', " 
    SQL = SQL & "    K7171_seBasicMaster      = N'" & FormatSQL(z7171.seBasicMaster) & "', " 
    SQL = SQL & "    K7171_cdBasicMaster      = N'" & FormatSQL(z7171.cdBasicMaster) & "', " 
    SQL = SQL & "    K7171_BasicName      = N'" & FormatSQL(z7171.BasicName) & "', " 
    SQL = SQL & "    K7171_NameSimply      = N'" & FormatSQL(z7171.NameSimply) & "', " 
    SQL = SQL & "    K7171_ForeignName1      = N'" & FormatSQL(z7171.ForeignName1) & "', " 
    SQL = SQL & "    K7171_ForeignName2      = N'" & FormatSQL(z7171.ForeignName2) & "', " 
    SQL = SQL & "    K7171_Check1      = N'" & FormatSQL(z7171.Check1) & "', " 
    SQL = SQL & "    K7171_Check2      = N'" & FormatSQL(z7171.Check2) & "', " 
    SQL = SQL & "    K7171_Check3      = N'" & FormatSQL(z7171.Check3) & "', " 
    SQL = SQL & "    K7171_Check4      = N'" & FormatSQL(z7171.Check4) & "', " 
    SQL = SQL & "    K7171_Check5      = N'" & FormatSQL(z7171.Check5) & "', " 
    SQL = SQL & "    K7171_Check6      = N'" & FormatSQL(z7171.Check6) & "', " 
    SQL = SQL & "    K7171_Check7      = N'" & FormatSQL(z7171.Check7) & "', " 
    SQL = SQL & "    K7171_Check8      = N'" & FormatSQL(z7171.Check8) & "', " 
    SQL = SQL & "    K7171_Check9      = N'" & FormatSQL(z7171.Check9) & "', " 
    SQL = SQL & "    K7171_Check10      = N'" & FormatSQL(z7171.Check10) & "', " 
    SQL = SQL & "    K7171_CheckName1      = N'" & FormatSQL(z7171.CheckName1) & "', " 
    SQL = SQL & "    K7171_CheckName2      = N'" & FormatSQL(z7171.CheckName2) & "', " 
    SQL = SQL & "    K7171_CheckName3      = N'" & FormatSQL(z7171.CheckName3) & "', " 
    SQL = SQL & "    K7171_CheckName4      = N'" & FormatSQL(z7171.CheckName4) & "', " 
    SQL = SQL & "    K7171_CheckName5      = N'" & FormatSQL(z7171.CheckName5) & "', " 
    SQL = SQL & "    K7171_CheckName6      = N'" & FormatSQL(z7171.CheckName6) & "', " 
    SQL = SQL & "    K7171_CheckName7      = N'" & FormatSQL(z7171.CheckName7) & "', " 
    SQL = SQL & "    K7171_CheckName8      = N'" & FormatSQL(z7171.CheckName8) & "', " 
    SQL = SQL & "    K7171_CheckName9      = N'" & FormatSQL(z7171.CheckName9) & "', " 
    SQL = SQL & "    K7171_CheckName10      = N'" & FormatSQL(z7171.CheckName10) & "', " 
    SQL = SQL & "    K7171_InchargeInsert      = N'" & FormatSQL(z7171.InchargeInsert) & "', " 
    SQL = SQL & "    K7171_InchargeUpdate      = N'" & FormatSQL(z7171.InchargeUpdate) & "', " 
    SQL = SQL & "    K7171_DateInsert      = N'" & FormatSQL(z7171.DateInsert) & "', " 
    SQL = SQL & "    K7171_DateUpdate      = N'" & FormatSQL(z7171.DateUpdate) & "', " 
    SQL = SQL & "    K7171_TimeInsert      = N'" & FormatSQL(z7171.TimeInsert) & "', " 
    SQL = SQL & "    K7171_TimeUpdate      = N'" & FormatSQL(z7171.TimeUpdate) & "', " 
    SQL = SQL & "    K7171_TimeLast      = N'" & FormatSQL(z7171.TimeLast) & "', " 
    SQL = SQL & "    K7171_CheckUse      = N'" & FormatSQL(z7171.CheckUse) & "', " 
    SQL = SQL & "    K7171_Remark      = N'" & FormatSQL(z7171.Remark) & "'  " 
    SQL = SQL & " WHERE K7171_BasicSel		 = '" & z7171.BasicSel & "' " 
    SQL = SQL & "   AND K7171_BasicCode		 = '" & z7171.BasicCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7171 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7171",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7171(z7171 As T7171_AREA) As Boolean
    DELETE_PFK7171 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7171 "
    SQL = SQL & " WHERE K7171_BasicSel		 = '" & z7171.BasicSel & "' " 
    SQL = SQL & "   AND K7171_BasicCode		 = '" & z7171.BasicCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7171 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7171",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7171_CLEAR()
Try
    
   D7171.BasicSel = ""
   D7171.BasicCode = ""
   D7171.NameHLPButton = ""
    D7171.DisplaySeq = 0 
   D7171.DevelopmentCode = ""
   D7171.seBasicMaster = ""
   D7171.cdBasicMaster = ""
   D7171.BasicName = ""
   D7171.NameSimply = ""
   D7171.ForeignName1 = ""
   D7171.ForeignName2 = ""
   D7171.Check1 = ""
   D7171.Check2 = ""
   D7171.Check3 = ""
   D7171.Check4 = ""
   D7171.Check5 = ""
   D7171.Check6 = ""
   D7171.Check7 = ""
   D7171.Check8 = ""
   D7171.Check9 = ""
   D7171.Check10 = ""
   D7171.CheckName1 = ""
   D7171.CheckName2 = ""
   D7171.CheckName3 = ""
   D7171.CheckName4 = ""
   D7171.CheckName5 = ""
   D7171.CheckName6 = ""
   D7171.CheckName7 = ""
   D7171.CheckName8 = ""
   D7171.CheckName9 = ""
   D7171.CheckName10 = ""
   D7171.InchargeInsert = ""
   D7171.InchargeUpdate = ""
   D7171.DateInsert = ""
   D7171.DateUpdate = ""
   D7171.TimeInsert = ""
   D7171.TimeUpdate = ""
   D7171.TimeLast = ""
   D7171.CheckUse = ""
   D7171.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7171_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7171 As T7171_AREA)
Try
    
    x7171.BasicSel = trim$(  x7171.BasicSel)
    x7171.BasicCode = trim$(  x7171.BasicCode)
    x7171.NameHLPButton = trim$(  x7171.NameHLPButton)
    x7171.DisplaySeq = trim$(  x7171.DisplaySeq)
    x7171.DevelopmentCode = trim$(  x7171.DevelopmentCode)
    x7171.seBasicMaster = trim$(  x7171.seBasicMaster)
    x7171.cdBasicMaster = trim$(  x7171.cdBasicMaster)
    x7171.BasicName = trim$(  x7171.BasicName)
    x7171.NameSimply = trim$(  x7171.NameSimply)
    x7171.ForeignName1 = trim$(  x7171.ForeignName1)
    x7171.ForeignName2 = trim$(  x7171.ForeignName2)
    x7171.Check1 = trim$(  x7171.Check1)
    x7171.Check2 = trim$(  x7171.Check2)
    x7171.Check3 = trim$(  x7171.Check3)
    x7171.Check4 = trim$(  x7171.Check4)
    x7171.Check5 = trim$(  x7171.Check5)
    x7171.Check6 = trim$(  x7171.Check6)
    x7171.Check7 = trim$(  x7171.Check7)
    x7171.Check8 = trim$(  x7171.Check8)
    x7171.Check9 = trim$(  x7171.Check9)
    x7171.Check10 = trim$(  x7171.Check10)
    x7171.CheckName1 = trim$(  x7171.CheckName1)
    x7171.CheckName2 = trim$(  x7171.CheckName2)
    x7171.CheckName3 = trim$(  x7171.CheckName3)
    x7171.CheckName4 = trim$(  x7171.CheckName4)
    x7171.CheckName5 = trim$(  x7171.CheckName5)
    x7171.CheckName6 = trim$(  x7171.CheckName6)
    x7171.CheckName7 = trim$(  x7171.CheckName7)
    x7171.CheckName8 = trim$(  x7171.CheckName8)
    x7171.CheckName9 = trim$(  x7171.CheckName9)
    x7171.CheckName10 = trim$(  x7171.CheckName10)
    x7171.InchargeInsert = trim$(  x7171.InchargeInsert)
    x7171.InchargeUpdate = trim$(  x7171.InchargeUpdate)
    x7171.DateInsert = trim$(  x7171.DateInsert)
    x7171.DateUpdate = trim$(  x7171.DateUpdate)
    x7171.TimeInsert = trim$(  x7171.TimeInsert)
    x7171.TimeUpdate = trim$(  x7171.TimeUpdate)
    x7171.TimeLast = trim$(  x7171.TimeLast)
    x7171.CheckUse = trim$(  x7171.CheckUse)
    x7171.Remark = trim$(  x7171.Remark)
     
    If trim$( x7171.BasicSel ) = "" Then x7171.BasicSel = Space(1) 
    If trim$( x7171.BasicCode ) = "" Then x7171.BasicCode = Space(1) 
    If trim$( x7171.NameHLPButton ) = "" Then x7171.NameHLPButton = Space(1) 
    If trim$( x7171.DisplaySeq ) = "" Then x7171.DisplaySeq = 0 
    If trim$( x7171.DevelopmentCode ) = "" Then x7171.DevelopmentCode = Space(1) 
    If trim$( x7171.seBasicMaster ) = "" Then x7171.seBasicMaster = Space(1) 
    If trim$( x7171.cdBasicMaster ) = "" Then x7171.cdBasicMaster = Space(1) 
    If trim$( x7171.BasicName ) = "" Then x7171.BasicName = Space(1) 
    If trim$( x7171.NameSimply ) = "" Then x7171.NameSimply = Space(1) 
    If trim$( x7171.ForeignName1 ) = "" Then x7171.ForeignName1 = Space(1) 
    If trim$( x7171.ForeignName2 ) = "" Then x7171.ForeignName2 = Space(1) 
    If trim$( x7171.Check1 ) = "" Then x7171.Check1 = Space(1) 
    If trim$( x7171.Check2 ) = "" Then x7171.Check2 = Space(1) 
    If trim$( x7171.Check3 ) = "" Then x7171.Check3 = Space(1) 
    If trim$( x7171.Check4 ) = "" Then x7171.Check4 = Space(1) 
    If trim$( x7171.Check5 ) = "" Then x7171.Check5 = Space(1) 
    If trim$( x7171.Check6 ) = "" Then x7171.Check6 = Space(1) 
    If trim$( x7171.Check7 ) = "" Then x7171.Check7 = Space(1) 
    If trim$( x7171.Check8 ) = "" Then x7171.Check8 = Space(1) 
    If trim$( x7171.Check9 ) = "" Then x7171.Check9 = Space(1) 
    If trim$( x7171.Check10 ) = "" Then x7171.Check10 = Space(1) 
    If trim$( x7171.CheckName1 ) = "" Then x7171.CheckName1 = Space(1) 
    If trim$( x7171.CheckName2 ) = "" Then x7171.CheckName2 = Space(1) 
    If trim$( x7171.CheckName3 ) = "" Then x7171.CheckName3 = Space(1) 
    If trim$( x7171.CheckName4 ) = "" Then x7171.CheckName4 = Space(1) 
    If trim$( x7171.CheckName5 ) = "" Then x7171.CheckName5 = Space(1) 
    If trim$( x7171.CheckName6 ) = "" Then x7171.CheckName6 = Space(1) 
    If trim$( x7171.CheckName7 ) = "" Then x7171.CheckName7 = Space(1) 
    If trim$( x7171.CheckName8 ) = "" Then x7171.CheckName8 = Space(1) 
    If trim$( x7171.CheckName9 ) = "" Then x7171.CheckName9 = Space(1) 
    If trim$( x7171.CheckName10 ) = "" Then x7171.CheckName10 = Space(1) 
    If trim$( x7171.InchargeInsert ) = "" Then x7171.InchargeInsert = Space(1) 
    If trim$( x7171.InchargeUpdate ) = "" Then x7171.InchargeUpdate = Space(1) 
    If trim$( x7171.DateInsert ) = "" Then x7171.DateInsert = Space(1) 
    If trim$( x7171.DateUpdate ) = "" Then x7171.DateUpdate = Space(1) 
    If trim$( x7171.TimeInsert ) = "" Then x7171.TimeInsert = Space(1) 
    If trim$( x7171.TimeUpdate ) = "" Then x7171.TimeUpdate = Space(1) 
    If trim$( x7171.TimeLast ) = "" Then x7171.TimeLast = Space(1) 
    If trim$( x7171.CheckUse ) = "" Then x7171.CheckUse = Space(1) 
    If trim$( x7171.Remark ) = "" Then x7171.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7171_MOVE(rs7171 As SqlClient.SqlDataReader)
Try

    call D7171_CLEAR()   

    If IsdbNull(rs7171!K7171_BasicSel) = False Then D7171.BasicSel = Trim$(rs7171!K7171_BasicSel)
    If IsdbNull(rs7171!K7171_BasicCode) = False Then D7171.BasicCode = Trim$(rs7171!K7171_BasicCode)
    If IsdbNull(rs7171!K7171_NameHLPButton) = False Then D7171.NameHLPButton = Trim$(rs7171!K7171_NameHLPButton)
    If IsdbNull(rs7171!K7171_DisplaySeq) = False Then D7171.DisplaySeq = Trim$(rs7171!K7171_DisplaySeq)
    If IsdbNull(rs7171!K7171_DevelopmentCode) = False Then D7171.DevelopmentCode = Trim$(rs7171!K7171_DevelopmentCode)
    If IsdbNull(rs7171!K7171_seBasicMaster) = False Then D7171.seBasicMaster = Trim$(rs7171!K7171_seBasicMaster)
    If IsdbNull(rs7171!K7171_cdBasicMaster) = False Then D7171.cdBasicMaster = Trim$(rs7171!K7171_cdBasicMaster)
    If IsdbNull(rs7171!K7171_BasicName) = False Then D7171.BasicName = Trim$(rs7171!K7171_BasicName)
    If IsdbNull(rs7171!K7171_NameSimply) = False Then D7171.NameSimply = Trim$(rs7171!K7171_NameSimply)
    If IsdbNull(rs7171!K7171_ForeignName1) = False Then D7171.ForeignName1 = Trim$(rs7171!K7171_ForeignName1)
    If IsdbNull(rs7171!K7171_ForeignName2) = False Then D7171.ForeignName2 = Trim$(rs7171!K7171_ForeignName2)
    If IsdbNull(rs7171!K7171_Check1) = False Then D7171.Check1 = Trim$(rs7171!K7171_Check1)
    If IsdbNull(rs7171!K7171_Check2) = False Then D7171.Check2 = Trim$(rs7171!K7171_Check2)
    If IsdbNull(rs7171!K7171_Check3) = False Then D7171.Check3 = Trim$(rs7171!K7171_Check3)
    If IsdbNull(rs7171!K7171_Check4) = False Then D7171.Check4 = Trim$(rs7171!K7171_Check4)
    If IsdbNull(rs7171!K7171_Check5) = False Then D7171.Check5 = Trim$(rs7171!K7171_Check5)
    If IsdbNull(rs7171!K7171_Check6) = False Then D7171.Check6 = Trim$(rs7171!K7171_Check6)
    If IsdbNull(rs7171!K7171_Check7) = False Then D7171.Check7 = Trim$(rs7171!K7171_Check7)
    If IsdbNull(rs7171!K7171_Check8) = False Then D7171.Check8 = Trim$(rs7171!K7171_Check8)
    If IsdbNull(rs7171!K7171_Check9) = False Then D7171.Check9 = Trim$(rs7171!K7171_Check9)
    If IsdbNull(rs7171!K7171_Check10) = False Then D7171.Check10 = Trim$(rs7171!K7171_Check10)
    If IsdbNull(rs7171!K7171_CheckName1) = False Then D7171.CheckName1 = Trim$(rs7171!K7171_CheckName1)
    If IsdbNull(rs7171!K7171_CheckName2) = False Then D7171.CheckName2 = Trim$(rs7171!K7171_CheckName2)
    If IsdbNull(rs7171!K7171_CheckName3) = False Then D7171.CheckName3 = Trim$(rs7171!K7171_CheckName3)
    If IsdbNull(rs7171!K7171_CheckName4) = False Then D7171.CheckName4 = Trim$(rs7171!K7171_CheckName4)
    If IsdbNull(rs7171!K7171_CheckName5) = False Then D7171.CheckName5 = Trim$(rs7171!K7171_CheckName5)
    If IsdbNull(rs7171!K7171_CheckName6) = False Then D7171.CheckName6 = Trim$(rs7171!K7171_CheckName6)
    If IsdbNull(rs7171!K7171_CheckName7) = False Then D7171.CheckName7 = Trim$(rs7171!K7171_CheckName7)
    If IsdbNull(rs7171!K7171_CheckName8) = False Then D7171.CheckName8 = Trim$(rs7171!K7171_CheckName8)
    If IsdbNull(rs7171!K7171_CheckName9) = False Then D7171.CheckName9 = Trim$(rs7171!K7171_CheckName9)
    If IsdbNull(rs7171!K7171_CheckName10) = False Then D7171.CheckName10 = Trim$(rs7171!K7171_CheckName10)
    If IsdbNull(rs7171!K7171_InchargeInsert) = False Then D7171.InchargeInsert = Trim$(rs7171!K7171_InchargeInsert)
    If IsdbNull(rs7171!K7171_InchargeUpdate) = False Then D7171.InchargeUpdate = Trim$(rs7171!K7171_InchargeUpdate)
    If IsdbNull(rs7171!K7171_DateInsert) = False Then D7171.DateInsert = Trim$(rs7171!K7171_DateInsert)
    If IsdbNull(rs7171!K7171_DateUpdate) = False Then D7171.DateUpdate = Trim$(rs7171!K7171_DateUpdate)
    If IsdbNull(rs7171!K7171_TimeInsert) = False Then D7171.TimeInsert = Trim$(rs7171!K7171_TimeInsert)
    If IsdbNull(rs7171!K7171_TimeUpdate) = False Then D7171.TimeUpdate = Trim$(rs7171!K7171_TimeUpdate)
    If IsdbNull(rs7171!K7171_TimeLast) = False Then D7171.TimeLast = Trim$(rs7171!K7171_TimeLast)
    If IsdbNull(rs7171!K7171_CheckUse) = False Then D7171.CheckUse = Trim$(rs7171!K7171_CheckUse)
    If IsdbNull(rs7171!K7171_Remark) = False Then D7171.Remark = Trim$(rs7171!K7171_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7171_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7171_MOVE(rs7171 As DataRow)
Try

    call D7171_CLEAR()   

    If IsdbNull(rs7171!K7171_BasicSel) = False Then D7171.BasicSel = Trim$(rs7171!K7171_BasicSel)
    If IsdbNull(rs7171!K7171_BasicCode) = False Then D7171.BasicCode = Trim$(rs7171!K7171_BasicCode)
    If IsdbNull(rs7171!K7171_NameHLPButton) = False Then D7171.NameHLPButton = Trim$(rs7171!K7171_NameHLPButton)
    If IsdbNull(rs7171!K7171_DisplaySeq) = False Then D7171.DisplaySeq = Trim$(rs7171!K7171_DisplaySeq)
    If IsdbNull(rs7171!K7171_DevelopmentCode) = False Then D7171.DevelopmentCode = Trim$(rs7171!K7171_DevelopmentCode)
    If IsdbNull(rs7171!K7171_seBasicMaster) = False Then D7171.seBasicMaster = Trim$(rs7171!K7171_seBasicMaster)
    If IsdbNull(rs7171!K7171_cdBasicMaster) = False Then D7171.cdBasicMaster = Trim$(rs7171!K7171_cdBasicMaster)
    If IsdbNull(rs7171!K7171_BasicName) = False Then D7171.BasicName = Trim$(rs7171!K7171_BasicName)
    If IsdbNull(rs7171!K7171_NameSimply) = False Then D7171.NameSimply = Trim$(rs7171!K7171_NameSimply)
    If IsdbNull(rs7171!K7171_ForeignName1) = False Then D7171.ForeignName1 = Trim$(rs7171!K7171_ForeignName1)
    If IsdbNull(rs7171!K7171_ForeignName2) = False Then D7171.ForeignName2 = Trim$(rs7171!K7171_ForeignName2)
    If IsdbNull(rs7171!K7171_Check1) = False Then D7171.Check1 = Trim$(rs7171!K7171_Check1)
    If IsdbNull(rs7171!K7171_Check2) = False Then D7171.Check2 = Trim$(rs7171!K7171_Check2)
    If IsdbNull(rs7171!K7171_Check3) = False Then D7171.Check3 = Trim$(rs7171!K7171_Check3)
    If IsdbNull(rs7171!K7171_Check4) = False Then D7171.Check4 = Trim$(rs7171!K7171_Check4)
    If IsdbNull(rs7171!K7171_Check5) = False Then D7171.Check5 = Trim$(rs7171!K7171_Check5)
    If IsdbNull(rs7171!K7171_Check6) = False Then D7171.Check6 = Trim$(rs7171!K7171_Check6)
    If IsdbNull(rs7171!K7171_Check7) = False Then D7171.Check7 = Trim$(rs7171!K7171_Check7)
    If IsdbNull(rs7171!K7171_Check8) = False Then D7171.Check8 = Trim$(rs7171!K7171_Check8)
    If IsdbNull(rs7171!K7171_Check9) = False Then D7171.Check9 = Trim$(rs7171!K7171_Check9)
    If IsdbNull(rs7171!K7171_Check10) = False Then D7171.Check10 = Trim$(rs7171!K7171_Check10)
    If IsdbNull(rs7171!K7171_CheckName1) = False Then D7171.CheckName1 = Trim$(rs7171!K7171_CheckName1)
    If IsdbNull(rs7171!K7171_CheckName2) = False Then D7171.CheckName2 = Trim$(rs7171!K7171_CheckName2)
    If IsdbNull(rs7171!K7171_CheckName3) = False Then D7171.CheckName3 = Trim$(rs7171!K7171_CheckName3)
    If IsdbNull(rs7171!K7171_CheckName4) = False Then D7171.CheckName4 = Trim$(rs7171!K7171_CheckName4)
    If IsdbNull(rs7171!K7171_CheckName5) = False Then D7171.CheckName5 = Trim$(rs7171!K7171_CheckName5)
    If IsdbNull(rs7171!K7171_CheckName6) = False Then D7171.CheckName6 = Trim$(rs7171!K7171_CheckName6)
    If IsdbNull(rs7171!K7171_CheckName7) = False Then D7171.CheckName7 = Trim$(rs7171!K7171_CheckName7)
    If IsdbNull(rs7171!K7171_CheckName8) = False Then D7171.CheckName8 = Trim$(rs7171!K7171_CheckName8)
    If IsdbNull(rs7171!K7171_CheckName9) = False Then D7171.CheckName9 = Trim$(rs7171!K7171_CheckName9)
    If IsdbNull(rs7171!K7171_CheckName10) = False Then D7171.CheckName10 = Trim$(rs7171!K7171_CheckName10)
    If IsdbNull(rs7171!K7171_InchargeInsert) = False Then D7171.InchargeInsert = Trim$(rs7171!K7171_InchargeInsert)
    If IsdbNull(rs7171!K7171_InchargeUpdate) = False Then D7171.InchargeUpdate = Trim$(rs7171!K7171_InchargeUpdate)
    If IsdbNull(rs7171!K7171_DateInsert) = False Then D7171.DateInsert = Trim$(rs7171!K7171_DateInsert)
    If IsdbNull(rs7171!K7171_DateUpdate) = False Then D7171.DateUpdate = Trim$(rs7171!K7171_DateUpdate)
    If IsdbNull(rs7171!K7171_TimeInsert) = False Then D7171.TimeInsert = Trim$(rs7171!K7171_TimeInsert)
    If IsdbNull(rs7171!K7171_TimeUpdate) = False Then D7171.TimeUpdate = Trim$(rs7171!K7171_TimeUpdate)
    If IsdbNull(rs7171!K7171_TimeLast) = False Then D7171.TimeLast = Trim$(rs7171!K7171_TimeLast)
    If IsdbNull(rs7171!K7171_CheckUse) = False Then D7171.CheckUse = Trim$(rs7171!K7171_CheckUse)
    If IsdbNull(rs7171!K7171_Remark) = False Then D7171.Remark = Trim$(rs7171!K7171_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7171_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7171_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7171 As T7171_AREA, BASICSEL AS String, BASICCODE AS String) as Boolean

K7171_MOVE = False

Try
    If READ_PFK7171(BASICSEL, BASICCODE) = True Then
                z7171 = D7171
		K7171_MOVE = True
		else
	z7171 = nothing
     End If

     If  getColumIndex(spr,"BasicSel") > -1 then z7171.BasicSel = getDataM(spr, getColumIndex(spr,"BasicSel"), xRow)
     If  getColumIndex(spr,"BasicCode") > -1 then z7171.BasicCode = getDataM(spr, getColumIndex(spr,"BasicCode"), xRow)
     If  getColumIndex(spr,"NameHLPButton") > -1 then z7171.NameHLPButton = getDataM(spr, getColumIndex(spr,"NameHLPButton"), xRow)
     If  getColumIndex(spr,"DisplaySeq") > -1 then z7171.DisplaySeq = getDataM(spr, getColumIndex(spr,"DisplaySeq"), xRow)
     If  getColumIndex(spr,"DevelopmentCode") > -1 then z7171.DevelopmentCode = getDataM(spr, getColumIndex(spr,"DevelopmentCode"), xRow)
     If  getColumIndex(spr,"seBasicMaster") > -1 then z7171.seBasicMaster = getDataM(spr, getColumIndex(spr,"seBasicMaster"), xRow)
     If  getColumIndex(spr,"cdBasicMaster") > -1 then z7171.cdBasicMaster = getDataM(spr, getColumIndex(spr,"cdBasicMaster"), xRow)
     If  getColumIndex(spr,"BasicName") > -1 then z7171.BasicName = getDataM(spr, getColumIndex(spr,"BasicName"), xRow)
     If  getColumIndex(spr,"NameSimply") > -1 then z7171.NameSimply = getDataM(spr, getColumIndex(spr,"NameSimply"), xRow)
     If  getColumIndex(spr,"ForeignName1") > -1 then z7171.ForeignName1 = getDataM(spr, getColumIndex(spr,"ForeignName1"), xRow)
     If  getColumIndex(spr,"ForeignName2") > -1 then z7171.ForeignName2 = getDataM(spr, getColumIndex(spr,"ForeignName2"), xRow)
     If  getColumIndex(spr,"Check1") > -1 then z7171.Check1 = getDataM(spr, getColumIndex(spr,"Check1"), xRow)
     If  getColumIndex(spr,"Check2") > -1 then z7171.Check2 = getDataM(spr, getColumIndex(spr,"Check2"), xRow)
     If  getColumIndex(spr,"Check3") > -1 then z7171.Check3 = getDataM(spr, getColumIndex(spr,"Check3"), xRow)
     If  getColumIndex(spr,"Check4") > -1 then z7171.Check4 = getDataM(spr, getColumIndex(spr,"Check4"), xRow)
     If  getColumIndex(spr,"Check5") > -1 then z7171.Check5 = getDataM(spr, getColumIndex(spr,"Check5"), xRow)
     If  getColumIndex(spr,"Check6") > -1 then z7171.Check6 = getDataM(spr, getColumIndex(spr,"Check6"), xRow)
     If  getColumIndex(spr,"Check7") > -1 then z7171.Check7 = getDataM(spr, getColumIndex(spr,"Check7"), xRow)
     If  getColumIndex(spr,"Check8") > -1 then z7171.Check8 = getDataM(spr, getColumIndex(spr,"Check8"), xRow)
     If  getColumIndex(spr,"Check9") > -1 then z7171.Check9 = getDataM(spr, getColumIndex(spr,"Check9"), xRow)
     If  getColumIndex(spr,"Check10") > -1 then z7171.Check10 = getDataM(spr, getColumIndex(spr,"Check10"), xRow)
     If  getColumIndex(spr,"CheckName1") > -1 then z7171.CheckName1 = getDataM(spr, getColumIndex(spr,"CheckName1"), xRow)
     If  getColumIndex(spr,"CheckName2") > -1 then z7171.CheckName2 = getDataM(spr, getColumIndex(spr,"CheckName2"), xRow)
     If  getColumIndex(spr,"CheckName3") > -1 then z7171.CheckName3 = getDataM(spr, getColumIndex(spr,"CheckName3"), xRow)
     If  getColumIndex(spr,"CheckName4") > -1 then z7171.CheckName4 = getDataM(spr, getColumIndex(spr,"CheckName4"), xRow)
     If  getColumIndex(spr,"CheckName5") > -1 then z7171.CheckName5 = getDataM(spr, getColumIndex(spr,"CheckName5"), xRow)
     If  getColumIndex(spr,"CheckName6") > -1 then z7171.CheckName6 = getDataM(spr, getColumIndex(spr,"CheckName6"), xRow)
     If  getColumIndex(spr,"CheckName7") > -1 then z7171.CheckName7 = getDataM(spr, getColumIndex(spr,"CheckName7"), xRow)
     If  getColumIndex(spr,"CheckName8") > -1 then z7171.CheckName8 = getDataM(spr, getColumIndex(spr,"CheckName8"), xRow)
     If  getColumIndex(spr,"CheckName9") > -1 then z7171.CheckName9 = getDataM(spr, getColumIndex(spr,"CheckName9"), xRow)
     If  getColumIndex(spr,"CheckName10") > -1 then z7171.CheckName10 = getDataM(spr, getColumIndex(spr,"CheckName10"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7171.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7171.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7171.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7171.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"TimeInsert") > -1 then z7171.TimeInsert = getDataM(spr, getColumIndex(spr,"TimeInsert"), xRow)
     If  getColumIndex(spr,"TimeUpdate") > -1 then z7171.TimeUpdate = getDataM(spr, getColumIndex(spr,"TimeUpdate"), xRow)
     If  getColumIndex(spr,"TimeLast") > -1 then z7171.TimeLast = getDataM(spr, getColumIndex(spr,"TimeLast"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7171.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7171.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7171_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7171_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7171 As T7171_AREA,CheckClear as Boolean,BASICSEL AS String, BASICCODE AS String) as Boolean

K7171_MOVE = False

Try
    If READ_PFK7171(BASICSEL, BASICCODE) = True Then
                z7171 = D7171
		K7171_MOVE = True
		else
	If CheckClear  = True then z7171 = nothing
     End If

     If  getColumIndex(spr,"BasicSel") > -1 then z7171.BasicSel = getDataM(spr, getColumIndex(spr,"BasicSel"), xRow)
     If  getColumIndex(spr,"BasicCode") > -1 then z7171.BasicCode = getDataM(spr, getColumIndex(spr,"BasicCode"), xRow)
     If  getColumIndex(spr,"NameHLPButton") > -1 then z7171.NameHLPButton = getDataM(spr, getColumIndex(spr,"NameHLPButton"), xRow)
     If  getColumIndex(spr,"DisplaySeq") > -1 then z7171.DisplaySeq = getDataM(spr, getColumIndex(spr,"DisplaySeq"), xRow)
     If  getColumIndex(spr,"DevelopmentCode") > -1 then z7171.DevelopmentCode = getDataM(spr, getColumIndex(spr,"DevelopmentCode"), xRow)
     If  getColumIndex(spr,"seBasicMaster") > -1 then z7171.seBasicMaster = getDataM(spr, getColumIndex(spr,"seBasicMaster"), xRow)
     If  getColumIndex(spr,"cdBasicMaster") > -1 then z7171.cdBasicMaster = getDataM(spr, getColumIndex(spr,"cdBasicMaster"), xRow)
     If  getColumIndex(spr,"BasicName") > -1 then z7171.BasicName = getDataM(spr, getColumIndex(spr,"BasicName"), xRow)
     If  getColumIndex(spr,"NameSimply") > -1 then z7171.NameSimply = getDataM(spr, getColumIndex(spr,"NameSimply"), xRow)
     If  getColumIndex(spr,"ForeignName1") > -1 then z7171.ForeignName1 = getDataM(spr, getColumIndex(spr,"ForeignName1"), xRow)
     If  getColumIndex(spr,"ForeignName2") > -1 then z7171.ForeignName2 = getDataM(spr, getColumIndex(spr,"ForeignName2"), xRow)
     If  getColumIndex(spr,"Check1") > -1 then z7171.Check1 = getDataM(spr, getColumIndex(spr,"Check1"), xRow)
     If  getColumIndex(spr,"Check2") > -1 then z7171.Check2 = getDataM(spr, getColumIndex(spr,"Check2"), xRow)
     If  getColumIndex(spr,"Check3") > -1 then z7171.Check3 = getDataM(spr, getColumIndex(spr,"Check3"), xRow)
     If  getColumIndex(spr,"Check4") > -1 then z7171.Check4 = getDataM(spr, getColumIndex(spr,"Check4"), xRow)
     If  getColumIndex(spr,"Check5") > -1 then z7171.Check5 = getDataM(spr, getColumIndex(spr,"Check5"), xRow)
     If  getColumIndex(spr,"Check6") > -1 then z7171.Check6 = getDataM(spr, getColumIndex(spr,"Check6"), xRow)
     If  getColumIndex(spr,"Check7") > -1 then z7171.Check7 = getDataM(spr, getColumIndex(spr,"Check7"), xRow)
     If  getColumIndex(spr,"Check8") > -1 then z7171.Check8 = getDataM(spr, getColumIndex(spr,"Check8"), xRow)
     If  getColumIndex(spr,"Check9") > -1 then z7171.Check9 = getDataM(spr, getColumIndex(spr,"Check9"), xRow)
     If  getColumIndex(spr,"Check10") > -1 then z7171.Check10 = getDataM(spr, getColumIndex(spr,"Check10"), xRow)
     If  getColumIndex(spr,"CheckName1") > -1 then z7171.CheckName1 = getDataM(spr, getColumIndex(spr,"CheckName1"), xRow)
     If  getColumIndex(spr,"CheckName2") > -1 then z7171.CheckName2 = getDataM(spr, getColumIndex(spr,"CheckName2"), xRow)
     If  getColumIndex(spr,"CheckName3") > -1 then z7171.CheckName3 = getDataM(spr, getColumIndex(spr,"CheckName3"), xRow)
     If  getColumIndex(spr,"CheckName4") > -1 then z7171.CheckName4 = getDataM(spr, getColumIndex(spr,"CheckName4"), xRow)
     If  getColumIndex(spr,"CheckName5") > -1 then z7171.CheckName5 = getDataM(spr, getColumIndex(spr,"CheckName5"), xRow)
     If  getColumIndex(spr,"CheckName6") > -1 then z7171.CheckName6 = getDataM(spr, getColumIndex(spr,"CheckName6"), xRow)
     If  getColumIndex(spr,"CheckName7") > -1 then z7171.CheckName7 = getDataM(spr, getColumIndex(spr,"CheckName7"), xRow)
     If  getColumIndex(spr,"CheckName8") > -1 then z7171.CheckName8 = getDataM(spr, getColumIndex(spr,"CheckName8"), xRow)
     If  getColumIndex(spr,"CheckName9") > -1 then z7171.CheckName9 = getDataM(spr, getColumIndex(spr,"CheckName9"), xRow)
     If  getColumIndex(spr,"CheckName10") > -1 then z7171.CheckName10 = getDataM(spr, getColumIndex(spr,"CheckName10"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7171.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7171.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7171.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7171.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"TimeInsert") > -1 then z7171.TimeInsert = getDataM(spr, getColumIndex(spr,"TimeInsert"), xRow)
     If  getColumIndex(spr,"TimeUpdate") > -1 then z7171.TimeUpdate = getDataM(spr, getColumIndex(spr,"TimeUpdate"), xRow)
     If  getColumIndex(spr,"TimeLast") > -1 then z7171.TimeLast = getDataM(spr, getColumIndex(spr,"TimeLast"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7171.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7171.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7171_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7171_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7171 As T7171_AREA, Job as String, BASICSEL AS String, BASICCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7171_MOVE = False

Try
    If READ_PFK7171(BASICSEL, BASICCODE) = True Then
                z7171 = D7171
		K7171_MOVE = True
		else
	z7171 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7171")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "BASICSEL":z7171.BasicSel = Children(i).Code
   Case "BASICCODE":z7171.BasicCode = Children(i).Code
   Case "NAMEHLPBUTTON":z7171.NameHLPButton = Children(i).Code
   Case "DISPLAYSEQ":z7171.DisplaySeq = Children(i).Code
   Case "DEVELOPMENTCODE":z7171.DevelopmentCode = Children(i).Code
   Case "SEBASICMASTER":z7171.seBasicMaster = Children(i).Code
   Case "CDBASICMASTER":z7171.cdBasicMaster = Children(i).Code
   Case "BASICNAME":z7171.BasicName = Children(i).Code
   Case "NAMESIMPLY":z7171.NameSimply = Children(i).Code
   Case "FOREIGNNAME1":z7171.ForeignName1 = Children(i).Code
   Case "FOREIGNNAME2":z7171.ForeignName2 = Children(i).Code
   Case "CHECK1":z7171.Check1 = Children(i).Code
   Case "CHECK2":z7171.Check2 = Children(i).Code
   Case "CHECK3":z7171.Check3 = Children(i).Code
   Case "CHECK4":z7171.Check4 = Children(i).Code
   Case "CHECK5":z7171.Check5 = Children(i).Code
   Case "CHECK6":z7171.Check6 = Children(i).Code
   Case "CHECK7":z7171.Check7 = Children(i).Code
   Case "CHECK8":z7171.Check8 = Children(i).Code
   Case "CHECK9":z7171.Check9 = Children(i).Code
   Case "CHECK10":z7171.Check10 = Children(i).Code
   Case "CHECKNAME1":z7171.CheckName1 = Children(i).Code
   Case "CHECKNAME2":z7171.CheckName2 = Children(i).Code
   Case "CHECKNAME3":z7171.CheckName3 = Children(i).Code
   Case "CHECKNAME4":z7171.CheckName4 = Children(i).Code
   Case "CHECKNAME5":z7171.CheckName5 = Children(i).Code
   Case "CHECKNAME6":z7171.CheckName6 = Children(i).Code
   Case "CHECKNAME7":z7171.CheckName7 = Children(i).Code
   Case "CHECKNAME8":z7171.CheckName8 = Children(i).Code
   Case "CHECKNAME9":z7171.CheckName9 = Children(i).Code
   Case "CHECKNAME10":z7171.CheckName10 = Children(i).Code
   Case "INCHARGEINSERT":z7171.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7171.InchargeUpdate = Children(i).Code
   Case "DATEINSERT":z7171.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7171.DateUpdate = Children(i).Code
   Case "TIMEINSERT":z7171.TimeInsert = Children(i).Code
   Case "TIMEUPDATE":z7171.TimeUpdate = Children(i).Code
   Case "TIMELAST":z7171.TimeLast = Children(i).Code
   Case "CHECKUSE":z7171.CheckUse = Children(i).Code
   Case "REMARK":z7171.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "BASICSEL":z7171.BasicSel = Children(i).Data
   Case "BASICCODE":z7171.BasicCode = Children(i).Data
   Case "NAMEHLPBUTTON":z7171.NameHLPButton = Children(i).Data
   Case "DISPLAYSEQ":z7171.DisplaySeq = Children(i).Data
   Case "DEVELOPMENTCODE":z7171.DevelopmentCode = Children(i).Data
   Case "SEBASICMASTER":z7171.seBasicMaster = Children(i).Data
   Case "CDBASICMASTER":z7171.cdBasicMaster = Children(i).Data
   Case "BASICNAME":z7171.BasicName = Children(i).Data
   Case "NAMESIMPLY":z7171.NameSimply = Children(i).Data
   Case "FOREIGNNAME1":z7171.ForeignName1 = Children(i).Data
   Case "FOREIGNNAME2":z7171.ForeignName2 = Children(i).Data
   Case "CHECK1":z7171.Check1 = Children(i).Data
   Case "CHECK2":z7171.Check2 = Children(i).Data
   Case "CHECK3":z7171.Check3 = Children(i).Data
   Case "CHECK4":z7171.Check4 = Children(i).Data
   Case "CHECK5":z7171.Check5 = Children(i).Data
   Case "CHECK6":z7171.Check6 = Children(i).Data
   Case "CHECK7":z7171.Check7 = Children(i).Data
   Case "CHECK8":z7171.Check8 = Children(i).Data
   Case "CHECK9":z7171.Check9 = Children(i).Data
   Case "CHECK10":z7171.Check10 = Children(i).Data
   Case "CHECKNAME1":z7171.CheckName1 = Children(i).Data
   Case "CHECKNAME2":z7171.CheckName2 = Children(i).Data
   Case "CHECKNAME3":z7171.CheckName3 = Children(i).Data
   Case "CHECKNAME4":z7171.CheckName4 = Children(i).Data
   Case "CHECKNAME5":z7171.CheckName5 = Children(i).Data
   Case "CHECKNAME6":z7171.CheckName6 = Children(i).Data
   Case "CHECKNAME7":z7171.CheckName7 = Children(i).Data
   Case "CHECKNAME8":z7171.CheckName8 = Children(i).Data
   Case "CHECKNAME9":z7171.CheckName9 = Children(i).Data
   Case "CHECKNAME10":z7171.CheckName10 = Children(i).Data
   Case "INCHARGEINSERT":z7171.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7171.InchargeUpdate = Children(i).Data
   Case "DATEINSERT":z7171.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7171.DateUpdate = Children(i).Data
   Case "TIMEINSERT":z7171.TimeInsert = Children(i).Data
   Case "TIMEUPDATE":z7171.TimeUpdate = Children(i).Data
   Case "TIMELAST":z7171.TimeLast = Children(i).Data
   Case "CHECKUSE":z7171.CheckUse = Children(i).Data
   Case "REMARK":z7171.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7171_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7171_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7171 As T7171_AREA, Job as String, CheckClear as Boolean, BASICSEL AS String, BASICCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7171_MOVE = False

Try
    If READ_PFK7171(BASICSEL, BASICCODE) = True Then
                z7171 = D7171
		K7171_MOVE = True
		else
	If CheckClear  = True then z7171 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7171")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "BASICSEL":z7171.BasicSel = Children(i).Code
   Case "BASICCODE":z7171.BasicCode = Children(i).Code
   Case "NAMEHLPBUTTON":z7171.NameHLPButton = Children(i).Code
   Case "DISPLAYSEQ":z7171.DisplaySeq = Children(i).Code
   Case "DEVELOPMENTCODE":z7171.DevelopmentCode = Children(i).Code
   Case "SEBASICMASTER":z7171.seBasicMaster = Children(i).Code
   Case "CDBASICMASTER":z7171.cdBasicMaster = Children(i).Code
   Case "BASICNAME":z7171.BasicName = Children(i).Code
   Case "NAMESIMPLY":z7171.NameSimply = Children(i).Code
   Case "FOREIGNNAME1":z7171.ForeignName1 = Children(i).Code
   Case "FOREIGNNAME2":z7171.ForeignName2 = Children(i).Code
   Case "CHECK1":z7171.Check1 = Children(i).Code
   Case "CHECK2":z7171.Check2 = Children(i).Code
   Case "CHECK3":z7171.Check3 = Children(i).Code
   Case "CHECK4":z7171.Check4 = Children(i).Code
   Case "CHECK5":z7171.Check5 = Children(i).Code
   Case "CHECK6":z7171.Check6 = Children(i).Code
   Case "CHECK7":z7171.Check7 = Children(i).Code
   Case "CHECK8":z7171.Check8 = Children(i).Code
   Case "CHECK9":z7171.Check9 = Children(i).Code
   Case "CHECK10":z7171.Check10 = Children(i).Code
   Case "CHECKNAME1":z7171.CheckName1 = Children(i).Code
   Case "CHECKNAME2":z7171.CheckName2 = Children(i).Code
   Case "CHECKNAME3":z7171.CheckName3 = Children(i).Code
   Case "CHECKNAME4":z7171.CheckName4 = Children(i).Code
   Case "CHECKNAME5":z7171.CheckName5 = Children(i).Code
   Case "CHECKNAME6":z7171.CheckName6 = Children(i).Code
   Case "CHECKNAME7":z7171.CheckName7 = Children(i).Code
   Case "CHECKNAME8":z7171.CheckName8 = Children(i).Code
   Case "CHECKNAME9":z7171.CheckName9 = Children(i).Code
   Case "CHECKNAME10":z7171.CheckName10 = Children(i).Code
   Case "INCHARGEINSERT":z7171.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7171.InchargeUpdate = Children(i).Code
   Case "DATEINSERT":z7171.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7171.DateUpdate = Children(i).Code
   Case "TIMEINSERT":z7171.TimeInsert = Children(i).Code
   Case "TIMEUPDATE":z7171.TimeUpdate = Children(i).Code
   Case "TIMELAST":z7171.TimeLast = Children(i).Code
   Case "CHECKUSE":z7171.CheckUse = Children(i).Code
   Case "REMARK":z7171.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "BASICSEL":z7171.BasicSel = Children(i).Data
   Case "BASICCODE":z7171.BasicCode = Children(i).Data
   Case "NAMEHLPBUTTON":z7171.NameHLPButton = Children(i).Data
   Case "DISPLAYSEQ":z7171.DisplaySeq = Children(i).Data
   Case "DEVELOPMENTCODE":z7171.DevelopmentCode = Children(i).Data
   Case "SEBASICMASTER":z7171.seBasicMaster = Children(i).Data
   Case "CDBASICMASTER":z7171.cdBasicMaster = Children(i).Data
   Case "BASICNAME":z7171.BasicName = Children(i).Data
   Case "NAMESIMPLY":z7171.NameSimply = Children(i).Data
   Case "FOREIGNNAME1":z7171.ForeignName1 = Children(i).Data
   Case "FOREIGNNAME2":z7171.ForeignName2 = Children(i).Data
   Case "CHECK1":z7171.Check1 = Children(i).Data
   Case "CHECK2":z7171.Check2 = Children(i).Data
   Case "CHECK3":z7171.Check3 = Children(i).Data
   Case "CHECK4":z7171.Check4 = Children(i).Data
   Case "CHECK5":z7171.Check5 = Children(i).Data
   Case "CHECK6":z7171.Check6 = Children(i).Data
   Case "CHECK7":z7171.Check7 = Children(i).Data
   Case "CHECK8":z7171.Check8 = Children(i).Data
   Case "CHECK9":z7171.Check9 = Children(i).Data
   Case "CHECK10":z7171.Check10 = Children(i).Data
   Case "CHECKNAME1":z7171.CheckName1 = Children(i).Data
   Case "CHECKNAME2":z7171.CheckName2 = Children(i).Data
   Case "CHECKNAME3":z7171.CheckName3 = Children(i).Data
   Case "CHECKNAME4":z7171.CheckName4 = Children(i).Data
   Case "CHECKNAME5":z7171.CheckName5 = Children(i).Data
   Case "CHECKNAME6":z7171.CheckName6 = Children(i).Data
   Case "CHECKNAME7":z7171.CheckName7 = Children(i).Data
   Case "CHECKNAME8":z7171.CheckName8 = Children(i).Data
   Case "CHECKNAME9":z7171.CheckName9 = Children(i).Data
   Case "CHECKNAME10":z7171.CheckName10 = Children(i).Data
   Case "INCHARGEINSERT":z7171.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7171.InchargeUpdate = Children(i).Data
   Case "DATEINSERT":z7171.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7171.DateUpdate = Children(i).Data
   Case "TIMEINSERT":z7171.TimeInsert = Children(i).Data
   Case "TIMEUPDATE":z7171.TimeUpdate = Children(i).Data
   Case "TIMELAST":z7171.TimeLast = Children(i).Data
   Case "CHECKUSE":z7171.CheckUse = Children(i).Data
   Case "REMARK":z7171.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7171_MOVE",vbCritical)
End Try
End Function 
    
End Module 
