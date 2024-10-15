'=========================================================================================================================================================
'   TABLE : (PFK9171)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K9171

Structure T9171_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	BasicSel	 AS String	'			char(3)		*
Public 	BasicCode	 AS String	'			char(3)		*
Public 	NameHLPButton	 AS String	'			nvarchar(50)
Public 	DisplaySeq	 AS Double	'			decimal
Public 	DevelopmentCode	 AS String	'			nvarchar(50)
Public 	selBasicMaster	 AS String	'			char(3)
Public 	cdBasicMaster	 AS String	'			char(3)
Public 	BasicName	 AS String	'			nvarchar(100)
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
Public 	CheckName1	 AS String	'			nvarchar(1000)
Public 	CheckName2	 AS String	'			nvarchar(1000)
Public 	CheckName3	 AS String	'			nvarchar(1000)
Public 	CheckName4	 AS String	'			nvarchar(1000)
Public 	CheckName5	 AS String	'			nvarchar(1000)
Public 	CheckName6	 AS String	'			nvarchar(1000)
Public 	CheckName7	 AS String	'			nvarchar(1000)
Public 	CheckName8	 AS String	'			nvarchar(1000)
Public 	CheckName9	 AS String	'			nvarchar(1000)
Public 	CheckName10	 AS String	'			nvarchar(1000)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	TimeInsert	 AS String	'			char(14)
Public 	TimeUpdate	 AS String	'			char(14)
Public 	TimeLast	 AS String	'			char(14)
Public 	CheckUse	 AS String	'			char(1)
Public 	Remark	 AS String	'			nvarchar(1000)
'=========================================================================================================================================================
End structure

Public D9171 As T9171_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK9171(BASICSEL AS String, BASICCODE AS String) As Boolean
    READ_PFK9171 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9171 "
    SQL = SQL & " WHERE K9171_BasicSel		 = '" & BasicSel & "' " 
    SQL = SQL & "   AND K9171_BasicCode		 = '" & BasicCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D9171_CLEAR: GoTo SKIP_READ_PFK9171
                
    Call K9171_MOVE(rd)
    READ_PFK9171 = True

SKIP_READ_PFK9171:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK9171",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK9171(BASICSEL AS String, BASICCODE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9171 "
    SQL = SQL & " WHERE K9171_BasicSel		 = '" & BasicSel & "' " 
    SQL = SQL & "   AND K9171_BasicCode		 = '" & BasicCode & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK9171",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK9171(z9171 As T9171_AREA) As Boolean
    WRITE_PFK9171 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z9171)
 
    SQL = " INSERT INTO PFK9171 "
    SQL = SQL & " ( "
    SQL = SQL & " K9171_BasicSel," 
    SQL = SQL & " K9171_BasicCode," 
    SQL = SQL & " K9171_NameHLPButton," 
    SQL = SQL & " K9171_DisplaySeq," 
    SQL = SQL & " K9171_DevelopmentCode," 
    SQL = SQL & " K9171_selBasicMaster," 
    SQL = SQL & " K9171_cdBasicMaster," 
    SQL = SQL & " K9171_BasicName," 
    SQL = SQL & " K9171_NameSimply," 
    SQL = SQL & " K9171_ForeignName1," 
    SQL = SQL & " K9171_ForeignName2," 
    SQL = SQL & " K9171_Check1," 
    SQL = SQL & " K9171_Check2," 
    SQL = SQL & " K9171_Check3," 
    SQL = SQL & " K9171_Check4," 
    SQL = SQL & " K9171_Check5," 
    SQL = SQL & " K9171_Check6," 
    SQL = SQL & " K9171_Check7," 
    SQL = SQL & " K9171_Check8," 
    SQL = SQL & " K9171_Check9," 
    SQL = SQL & " K9171_Check10," 
    SQL = SQL & " K9171_CheckName1," 
    SQL = SQL & " K9171_CheckName2," 
    SQL = SQL & " K9171_CheckName3," 
    SQL = SQL & " K9171_CheckName4," 
    SQL = SQL & " K9171_CheckName5," 
    SQL = SQL & " K9171_CheckName6," 
    SQL = SQL & " K9171_CheckName7," 
    SQL = SQL & " K9171_CheckName8," 
    SQL = SQL & " K9171_CheckName9," 
    SQL = SQL & " K9171_CheckName10," 
    SQL = SQL & " K9171_DateInsert," 
    SQL = SQL & " K9171_DateUpdate," 
    SQL = SQL & " K9171_TimeInsert," 
    SQL = SQL & " K9171_TimeUpdate," 
    SQL = SQL & " K9171_TimeLast," 
    SQL = SQL & " K9171_CheckUse," 
    SQL = SQL & " K9171_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z9171.BasicSel) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9171.BasicCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9171.NameHLPButton) & "', "  
    SQL = SQL & "   " & FormatSQL(z9171.DisplaySeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z9171.DevelopmentCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9171.selBasicMaster) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9171.cdBasicMaster) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9171.BasicName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9171.NameSimply) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9171.ForeignName1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9171.ForeignName2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9171.Check1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9171.Check2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9171.Check3) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9171.Check4) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9171.Check5) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9171.Check6) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9171.Check7) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9171.Check8) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9171.Check9) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9171.Check10) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9171.CheckName1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9171.CheckName2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9171.CheckName3) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9171.CheckName4) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9171.CheckName5) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9171.CheckName6) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9171.CheckName7) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9171.CheckName8) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9171.CheckName9) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9171.CheckName10) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9171.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9171.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9171.TimeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9171.TimeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9171.TimeLast) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9171.CheckUse) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9171.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK9171 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK9171",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK9171(z9171 As T9171_AREA) As Boolean
    REWRITE_PFK9171 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z9171)
   
    SQL = " UPDATE PFK9171 SET "
    SQL = SQL & "    K9171_NameHLPButton      = N'" & FormatSQL(z9171.NameHLPButton) & "', " 
    SQL = SQL & "    K9171_DisplaySeq      =  " & FormatSQL(z9171.DisplaySeq) & ", " 
    SQL = SQL & "    K9171_DevelopmentCode      = N'" & FormatSQL(z9171.DevelopmentCode) & "', " 
    SQL = SQL & "    K9171_selBasicMaster      = N'" & FormatSQL(z9171.selBasicMaster) & "', " 
    SQL = SQL & "    K9171_cdBasicMaster      = N'" & FormatSQL(z9171.cdBasicMaster) & "', " 
    SQL = SQL & "    K9171_BasicName      = N'" & FormatSQL(z9171.BasicName) & "', " 
    SQL = SQL & "    K9171_NameSimply      = N'" & FormatSQL(z9171.NameSimply) & "', " 
    SQL = SQL & "    K9171_ForeignName1      = N'" & FormatSQL(z9171.ForeignName1) & "', " 
    SQL = SQL & "    K9171_ForeignName2      = N'" & FormatSQL(z9171.ForeignName2) & "', " 
    SQL = SQL & "    K9171_Check1      = N'" & FormatSQL(z9171.Check1) & "', " 
    SQL = SQL & "    K9171_Check2      = N'" & FormatSQL(z9171.Check2) & "', " 
    SQL = SQL & "    K9171_Check3      = N'" & FormatSQL(z9171.Check3) & "', " 
    SQL = SQL & "    K9171_Check4      = N'" & FormatSQL(z9171.Check4) & "', " 
    SQL = SQL & "    K9171_Check5      = N'" & FormatSQL(z9171.Check5) & "', " 
    SQL = SQL & "    K9171_Check6      = N'" & FormatSQL(z9171.Check6) & "', " 
    SQL = SQL & "    K9171_Check7      = N'" & FormatSQL(z9171.Check7) & "', " 
    SQL = SQL & "    K9171_Check8      = N'" & FormatSQL(z9171.Check8) & "', " 
    SQL = SQL & "    K9171_Check9      = N'" & FormatSQL(z9171.Check9) & "', " 
    SQL = SQL & "    K9171_Check10      = N'" & FormatSQL(z9171.Check10) & "', " 
    SQL = SQL & "    K9171_CheckName1      = N'" & FormatSQL(z9171.CheckName1) & "', " 
    SQL = SQL & "    K9171_CheckName2      = N'" & FormatSQL(z9171.CheckName2) & "', " 
    SQL = SQL & "    K9171_CheckName3      = N'" & FormatSQL(z9171.CheckName3) & "', " 
    SQL = SQL & "    K9171_CheckName4      = N'" & FormatSQL(z9171.CheckName4) & "', " 
    SQL = SQL & "    K9171_CheckName5      = N'" & FormatSQL(z9171.CheckName5) & "', " 
    SQL = SQL & "    K9171_CheckName6      = N'" & FormatSQL(z9171.CheckName6) & "', " 
    SQL = SQL & "    K9171_CheckName7      = N'" & FormatSQL(z9171.CheckName7) & "', " 
    SQL = SQL & "    K9171_CheckName8      = N'" & FormatSQL(z9171.CheckName8) & "', " 
    SQL = SQL & "    K9171_CheckName9      = N'" & FormatSQL(z9171.CheckName9) & "', " 
    SQL = SQL & "    K9171_CheckName10      = N'" & FormatSQL(z9171.CheckName10) & "', " 
    SQL = SQL & "    K9171_DateInsert      = N'" & FormatSQL(z9171.DateInsert) & "', " 
    SQL = SQL & "    K9171_DateUpdate      = N'" & FormatSQL(z9171.DateUpdate) & "', " 
    SQL = SQL & "    K9171_TimeInsert      = N'" & FormatSQL(z9171.TimeInsert) & "', " 
    SQL = SQL & "    K9171_TimeUpdate      = N'" & FormatSQL(z9171.TimeUpdate) & "', " 
    SQL = SQL & "    K9171_TimeLast      = N'" & FormatSQL(z9171.TimeLast) & "', " 
    SQL = SQL & "    K9171_CheckUse      = N'" & FormatSQL(z9171.CheckUse) & "', " 
    SQL = SQL & "    K9171_Remark      = N'" & FormatSQL(z9171.Remark) & "'  " 
    SQL = SQL & " WHERE K9171_BasicSel		 = '" & z9171.BasicSel & "' " 
    SQL = SQL & "   AND K9171_BasicCode		 = '" & z9171.BasicCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK9171 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK9171",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK9171(z9171 As T9171_AREA) As Boolean
    DELETE_PFK9171 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK9171 "
    SQL = SQL & " WHERE K9171_BasicSel		 = '" & z9171.BasicSel & "' " 
    SQL = SQL & "   AND K9171_BasicCode		 = '" & z9171.BasicCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK9171 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK9171",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D9171_CLEAR()
Try
    
   D9171.BasicSel = ""
   D9171.BasicCode = ""
   D9171.NameHLPButton = ""
    D9171.DisplaySeq = 0 
   D9171.DevelopmentCode = ""
   D9171.selBasicMaster = ""
   D9171.cdBasicMaster = ""
   D9171.BasicName = ""
   D9171.NameSimply = ""
   D9171.ForeignName1 = ""
   D9171.ForeignName2 = ""
   D9171.Check1 = ""
   D9171.Check2 = ""
   D9171.Check3 = ""
   D9171.Check4 = ""
   D9171.Check5 = ""
   D9171.Check6 = ""
   D9171.Check7 = ""
   D9171.Check8 = ""
   D9171.Check9 = ""
   D9171.Check10 = ""
   D9171.CheckName1 = ""
   D9171.CheckName2 = ""
   D9171.CheckName3 = ""
   D9171.CheckName4 = ""
   D9171.CheckName5 = ""
   D9171.CheckName6 = ""
   D9171.CheckName7 = ""
   D9171.CheckName8 = ""
   D9171.CheckName9 = ""
   D9171.CheckName10 = ""
   D9171.DateInsert = ""
   D9171.DateUpdate = ""
   D9171.TimeInsert = ""
   D9171.TimeUpdate = ""
   D9171.TimeLast = ""
   D9171.CheckUse = ""
   D9171.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D9171_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x9171 As T9171_AREA)
Try
    
    x9171.BasicSel = trim$(  x9171.BasicSel)
    x9171.BasicCode = trim$(  x9171.BasicCode)
    x9171.NameHLPButton = trim$(  x9171.NameHLPButton)
    x9171.DisplaySeq = trim$(  x9171.DisplaySeq)
    x9171.DevelopmentCode = trim$(  x9171.DevelopmentCode)
    x9171.selBasicMaster = trim$(  x9171.selBasicMaster)
    x9171.cdBasicMaster = trim$(  x9171.cdBasicMaster)
    x9171.BasicName = trim$(  x9171.BasicName)
    x9171.NameSimply = trim$(  x9171.NameSimply)
    x9171.ForeignName1 = trim$(  x9171.ForeignName1)
    x9171.ForeignName2 = trim$(  x9171.ForeignName2)
    x9171.Check1 = trim$(  x9171.Check1)
    x9171.Check2 = trim$(  x9171.Check2)
    x9171.Check3 = trim$(  x9171.Check3)
    x9171.Check4 = trim$(  x9171.Check4)
    x9171.Check5 = trim$(  x9171.Check5)
    x9171.Check6 = trim$(  x9171.Check6)
    x9171.Check7 = trim$(  x9171.Check7)
    x9171.Check8 = trim$(  x9171.Check8)
    x9171.Check9 = trim$(  x9171.Check9)
    x9171.Check10 = trim$(  x9171.Check10)
    x9171.CheckName1 = trim$(  x9171.CheckName1)
    x9171.CheckName2 = trim$(  x9171.CheckName2)
    x9171.CheckName3 = trim$(  x9171.CheckName3)
    x9171.CheckName4 = trim$(  x9171.CheckName4)
    x9171.CheckName5 = trim$(  x9171.CheckName5)
    x9171.CheckName6 = trim$(  x9171.CheckName6)
    x9171.CheckName7 = trim$(  x9171.CheckName7)
    x9171.CheckName8 = trim$(  x9171.CheckName8)
    x9171.CheckName9 = trim$(  x9171.CheckName9)
    x9171.CheckName10 = trim$(  x9171.CheckName10)
    x9171.DateInsert = trim$(  x9171.DateInsert)
    x9171.DateUpdate = trim$(  x9171.DateUpdate)
    x9171.TimeInsert = trim$(  x9171.TimeInsert)
    x9171.TimeUpdate = trim$(  x9171.TimeUpdate)
    x9171.TimeLast = trim$(  x9171.TimeLast)
    x9171.CheckUse = trim$(  x9171.CheckUse)
    x9171.Remark = trim$(  x9171.Remark)
     
    If trim$( x9171.BasicSel ) = "" Then x9171.BasicSel = Space(1) 
    If trim$( x9171.BasicCode ) = "" Then x9171.BasicCode = Space(1) 
    If trim$( x9171.NameHLPButton ) = "" Then x9171.NameHLPButton = Space(1) 
    If trim$( x9171.DisplaySeq ) = "" Then x9171.DisplaySeq = 0 
    If trim$( x9171.DevelopmentCode ) = "" Then x9171.DevelopmentCode = Space(1) 
    If trim$( x9171.selBasicMaster ) = "" Then x9171.selBasicMaster = Space(1) 
    If trim$( x9171.cdBasicMaster ) = "" Then x9171.cdBasicMaster = Space(1) 
    If trim$( x9171.BasicName ) = "" Then x9171.BasicName = Space(1) 
    If trim$( x9171.NameSimply ) = "" Then x9171.NameSimply = Space(1) 
    If trim$( x9171.ForeignName1 ) = "" Then x9171.ForeignName1 = Space(1) 
    If trim$( x9171.ForeignName2 ) = "" Then x9171.ForeignName2 = Space(1) 
    If trim$( x9171.Check1 ) = "" Then x9171.Check1 = Space(1) 
    If trim$( x9171.Check2 ) = "" Then x9171.Check2 = Space(1) 
    If trim$( x9171.Check3 ) = "" Then x9171.Check3 = Space(1) 
    If trim$( x9171.Check4 ) = "" Then x9171.Check4 = Space(1) 
    If trim$( x9171.Check5 ) = "" Then x9171.Check5 = Space(1) 
    If trim$( x9171.Check6 ) = "" Then x9171.Check6 = Space(1) 
    If trim$( x9171.Check7 ) = "" Then x9171.Check7 = Space(1) 
    If trim$( x9171.Check8 ) = "" Then x9171.Check8 = Space(1) 
    If trim$( x9171.Check9 ) = "" Then x9171.Check9 = Space(1) 
    If trim$( x9171.Check10 ) = "" Then x9171.Check10 = Space(1) 
    If trim$( x9171.CheckName1 ) = "" Then x9171.CheckName1 = Space(1) 
    If trim$( x9171.CheckName2 ) = "" Then x9171.CheckName2 = Space(1) 
    If trim$( x9171.CheckName3 ) = "" Then x9171.CheckName3 = Space(1) 
    If trim$( x9171.CheckName4 ) = "" Then x9171.CheckName4 = Space(1) 
    If trim$( x9171.CheckName5 ) = "" Then x9171.CheckName5 = Space(1) 
    If trim$( x9171.CheckName6 ) = "" Then x9171.CheckName6 = Space(1) 
    If trim$( x9171.CheckName7 ) = "" Then x9171.CheckName7 = Space(1) 
    If trim$( x9171.CheckName8 ) = "" Then x9171.CheckName8 = Space(1) 
    If trim$( x9171.CheckName9 ) = "" Then x9171.CheckName9 = Space(1) 
    If trim$( x9171.CheckName10 ) = "" Then x9171.CheckName10 = Space(1) 
    If trim$( x9171.DateInsert ) = "" Then x9171.DateInsert = Space(1) 
    If trim$( x9171.DateUpdate ) = "" Then x9171.DateUpdate = Space(1) 
    If trim$( x9171.TimeInsert ) = "" Then x9171.TimeInsert = Space(1) 
    If trim$( x9171.TimeUpdate ) = "" Then x9171.TimeUpdate = Space(1) 
    If trim$( x9171.TimeLast ) = "" Then x9171.TimeLast = Space(1) 
    If trim$( x9171.CheckUse ) = "" Then x9171.CheckUse = Space(1) 
    If trim$( x9171.Remark ) = "" Then x9171.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K9171_MOVE(rs9171 As SqlClient.SqlDataReader)
Try

    call D9171_CLEAR()   

    If IsdbNull(rs9171!K9171_BasicSel) = False Then D9171.BasicSel = Trim$(rs9171!K9171_BasicSel)
    If IsdbNull(rs9171!K9171_BasicCode) = False Then D9171.BasicCode = Trim$(rs9171!K9171_BasicCode)
    If IsdbNull(rs9171!K9171_NameHLPButton) = False Then D9171.NameHLPButton = Trim$(rs9171!K9171_NameHLPButton)
    If IsdbNull(rs9171!K9171_DisplaySeq) = False Then D9171.DisplaySeq = Trim$(rs9171!K9171_DisplaySeq)
    If IsdbNull(rs9171!K9171_DevelopmentCode) = False Then D9171.DevelopmentCode = Trim$(rs9171!K9171_DevelopmentCode)
    If IsdbNull(rs9171!K9171_selBasicMaster) = False Then D9171.selBasicMaster = Trim$(rs9171!K9171_selBasicMaster)
    If IsdbNull(rs9171!K9171_cdBasicMaster) = False Then D9171.cdBasicMaster = Trim$(rs9171!K9171_cdBasicMaster)
    If IsdbNull(rs9171!K9171_BasicName) = False Then D9171.BasicName = Trim$(rs9171!K9171_BasicName)
    If IsdbNull(rs9171!K9171_NameSimply) = False Then D9171.NameSimply = Trim$(rs9171!K9171_NameSimply)
    If IsdbNull(rs9171!K9171_ForeignName1) = False Then D9171.ForeignName1 = Trim$(rs9171!K9171_ForeignName1)
    If IsdbNull(rs9171!K9171_ForeignName2) = False Then D9171.ForeignName2 = Trim$(rs9171!K9171_ForeignName2)
    If IsdbNull(rs9171!K9171_Check1) = False Then D9171.Check1 = Trim$(rs9171!K9171_Check1)
    If IsdbNull(rs9171!K9171_Check2) = False Then D9171.Check2 = Trim$(rs9171!K9171_Check2)
    If IsdbNull(rs9171!K9171_Check3) = False Then D9171.Check3 = Trim$(rs9171!K9171_Check3)
    If IsdbNull(rs9171!K9171_Check4) = False Then D9171.Check4 = Trim$(rs9171!K9171_Check4)
    If IsdbNull(rs9171!K9171_Check5) = False Then D9171.Check5 = Trim$(rs9171!K9171_Check5)
    If IsdbNull(rs9171!K9171_Check6) = False Then D9171.Check6 = Trim$(rs9171!K9171_Check6)
    If IsdbNull(rs9171!K9171_Check7) = False Then D9171.Check7 = Trim$(rs9171!K9171_Check7)
    If IsdbNull(rs9171!K9171_Check8) = False Then D9171.Check8 = Trim$(rs9171!K9171_Check8)
    If IsdbNull(rs9171!K9171_Check9) = False Then D9171.Check9 = Trim$(rs9171!K9171_Check9)
    If IsdbNull(rs9171!K9171_Check10) = False Then D9171.Check10 = Trim$(rs9171!K9171_Check10)
    If IsdbNull(rs9171!K9171_CheckName1) = False Then D9171.CheckName1 = Trim$(rs9171!K9171_CheckName1)
    If IsdbNull(rs9171!K9171_CheckName2) = False Then D9171.CheckName2 = Trim$(rs9171!K9171_CheckName2)
    If IsdbNull(rs9171!K9171_CheckName3) = False Then D9171.CheckName3 = Trim$(rs9171!K9171_CheckName3)
    If IsdbNull(rs9171!K9171_CheckName4) = False Then D9171.CheckName4 = Trim$(rs9171!K9171_CheckName4)
    If IsdbNull(rs9171!K9171_CheckName5) = False Then D9171.CheckName5 = Trim$(rs9171!K9171_CheckName5)
    If IsdbNull(rs9171!K9171_CheckName6) = False Then D9171.CheckName6 = Trim$(rs9171!K9171_CheckName6)
    If IsdbNull(rs9171!K9171_CheckName7) = False Then D9171.CheckName7 = Trim$(rs9171!K9171_CheckName7)
    If IsdbNull(rs9171!K9171_CheckName8) = False Then D9171.CheckName8 = Trim$(rs9171!K9171_CheckName8)
    If IsdbNull(rs9171!K9171_CheckName9) = False Then D9171.CheckName9 = Trim$(rs9171!K9171_CheckName9)
    If IsdbNull(rs9171!K9171_CheckName10) = False Then D9171.CheckName10 = Trim$(rs9171!K9171_CheckName10)
    If IsdbNull(rs9171!K9171_DateInsert) = False Then D9171.DateInsert = Trim$(rs9171!K9171_DateInsert)
    If IsdbNull(rs9171!K9171_DateUpdate) = False Then D9171.DateUpdate = Trim$(rs9171!K9171_DateUpdate)
    If IsdbNull(rs9171!K9171_TimeInsert) = False Then D9171.TimeInsert = Trim$(rs9171!K9171_TimeInsert)
    If IsdbNull(rs9171!K9171_TimeUpdate) = False Then D9171.TimeUpdate = Trim$(rs9171!K9171_TimeUpdate)
    If IsdbNull(rs9171!K9171_TimeLast) = False Then D9171.TimeLast = Trim$(rs9171!K9171_TimeLast)
    If IsdbNull(rs9171!K9171_CheckUse) = False Then D9171.CheckUse = Trim$(rs9171!K9171_CheckUse)
    If IsdbNull(rs9171!K9171_Remark) = False Then D9171.Remark = Trim$(rs9171!K9171_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9171_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K9171_MOVE(rs9171 As DataRow)
Try

    call D9171_CLEAR()   

    If IsdbNull(rs9171!K9171_BasicSel) = False Then D9171.BasicSel = Trim$(rs9171!K9171_BasicSel)
    If IsdbNull(rs9171!K9171_BasicCode) = False Then D9171.BasicCode = Trim$(rs9171!K9171_BasicCode)
    If IsdbNull(rs9171!K9171_NameHLPButton) = False Then D9171.NameHLPButton = Trim$(rs9171!K9171_NameHLPButton)
    If IsdbNull(rs9171!K9171_DisplaySeq) = False Then D9171.DisplaySeq = Trim$(rs9171!K9171_DisplaySeq)
    If IsdbNull(rs9171!K9171_DevelopmentCode) = False Then D9171.DevelopmentCode = Trim$(rs9171!K9171_DevelopmentCode)
    If IsdbNull(rs9171!K9171_selBasicMaster) = False Then D9171.selBasicMaster = Trim$(rs9171!K9171_selBasicMaster)
    If IsdbNull(rs9171!K9171_cdBasicMaster) = False Then D9171.cdBasicMaster = Trim$(rs9171!K9171_cdBasicMaster)
    If IsdbNull(rs9171!K9171_BasicName) = False Then D9171.BasicName = Trim$(rs9171!K9171_BasicName)
    If IsdbNull(rs9171!K9171_NameSimply) = False Then D9171.NameSimply = Trim$(rs9171!K9171_NameSimply)
    If IsdbNull(rs9171!K9171_ForeignName1) = False Then D9171.ForeignName1 = Trim$(rs9171!K9171_ForeignName1)
    If IsdbNull(rs9171!K9171_ForeignName2) = False Then D9171.ForeignName2 = Trim$(rs9171!K9171_ForeignName2)
    If IsdbNull(rs9171!K9171_Check1) = False Then D9171.Check1 = Trim$(rs9171!K9171_Check1)
    If IsdbNull(rs9171!K9171_Check2) = False Then D9171.Check2 = Trim$(rs9171!K9171_Check2)
    If IsdbNull(rs9171!K9171_Check3) = False Then D9171.Check3 = Trim$(rs9171!K9171_Check3)
    If IsdbNull(rs9171!K9171_Check4) = False Then D9171.Check4 = Trim$(rs9171!K9171_Check4)
    If IsdbNull(rs9171!K9171_Check5) = False Then D9171.Check5 = Trim$(rs9171!K9171_Check5)
    If IsdbNull(rs9171!K9171_Check6) = False Then D9171.Check6 = Trim$(rs9171!K9171_Check6)
    If IsdbNull(rs9171!K9171_Check7) = False Then D9171.Check7 = Trim$(rs9171!K9171_Check7)
    If IsdbNull(rs9171!K9171_Check8) = False Then D9171.Check8 = Trim$(rs9171!K9171_Check8)
    If IsdbNull(rs9171!K9171_Check9) = False Then D9171.Check9 = Trim$(rs9171!K9171_Check9)
    If IsdbNull(rs9171!K9171_Check10) = False Then D9171.Check10 = Trim$(rs9171!K9171_Check10)
    If IsdbNull(rs9171!K9171_CheckName1) = False Then D9171.CheckName1 = Trim$(rs9171!K9171_CheckName1)
    If IsdbNull(rs9171!K9171_CheckName2) = False Then D9171.CheckName2 = Trim$(rs9171!K9171_CheckName2)
    If IsdbNull(rs9171!K9171_CheckName3) = False Then D9171.CheckName3 = Trim$(rs9171!K9171_CheckName3)
    If IsdbNull(rs9171!K9171_CheckName4) = False Then D9171.CheckName4 = Trim$(rs9171!K9171_CheckName4)
    If IsdbNull(rs9171!K9171_CheckName5) = False Then D9171.CheckName5 = Trim$(rs9171!K9171_CheckName5)
    If IsdbNull(rs9171!K9171_CheckName6) = False Then D9171.CheckName6 = Trim$(rs9171!K9171_CheckName6)
    If IsdbNull(rs9171!K9171_CheckName7) = False Then D9171.CheckName7 = Trim$(rs9171!K9171_CheckName7)
    If IsdbNull(rs9171!K9171_CheckName8) = False Then D9171.CheckName8 = Trim$(rs9171!K9171_CheckName8)
    If IsdbNull(rs9171!K9171_CheckName9) = False Then D9171.CheckName9 = Trim$(rs9171!K9171_CheckName9)
    If IsdbNull(rs9171!K9171_CheckName10) = False Then D9171.CheckName10 = Trim$(rs9171!K9171_CheckName10)
    If IsdbNull(rs9171!K9171_DateInsert) = False Then D9171.DateInsert = Trim$(rs9171!K9171_DateInsert)
    If IsdbNull(rs9171!K9171_DateUpdate) = False Then D9171.DateUpdate = Trim$(rs9171!K9171_DateUpdate)
    If IsdbNull(rs9171!K9171_TimeInsert) = False Then D9171.TimeInsert = Trim$(rs9171!K9171_TimeInsert)
    If IsdbNull(rs9171!K9171_TimeUpdate) = False Then D9171.TimeUpdate = Trim$(rs9171!K9171_TimeUpdate)
    If IsdbNull(rs9171!K9171_TimeLast) = False Then D9171.TimeLast = Trim$(rs9171!K9171_TimeLast)
    If IsdbNull(rs9171!K9171_CheckUse) = False Then D9171.CheckUse = Trim$(rs9171!K9171_CheckUse)
    If IsdbNull(rs9171!K9171_Remark) = False Then D9171.Remark = Trim$(rs9171!K9171_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9171_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K9171_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9171 As T9171_AREA, BASICSEL AS String, BASICCODE AS String) as Boolean

K9171_MOVE = False

Try
    If READ_PFK9171(BASICSEL, BASICCODE) = True Then
                z9171 = D9171
		K9171_MOVE = True
		else
	z9171 = nothing
     End If

     If  getColumIndex(spr,"BasicSel") > -1 then z9171.BasicSel = getDataM(spr, getColumIndex(spr,"BasicSel"), xRow)
     If  getColumIndex(spr,"BasicCode") > -1 then z9171.BasicCode = getDataM(spr, getColumIndex(spr,"BasicCode"), xRow)
     If  getColumIndex(spr,"NameHLPButton") > -1 then z9171.NameHLPButton = getDataM(spr, getColumIndex(spr,"NameHLPButton"), xRow)
     If  getColumIndex(spr,"DisplaySeq") > -1 then z9171.DisplaySeq = getDataM(spr, getColumIndex(spr,"DisplaySeq"), xRow)
     If  getColumIndex(spr,"DevelopmentCode") > -1 then z9171.DevelopmentCode = getDataM(spr, getColumIndex(spr,"DevelopmentCode"), xRow)
     If  getColumIndex(spr,"selBasicMaster") > -1 then z9171.selBasicMaster = getDataM(spr, getColumIndex(spr,"selBasicMaster"), xRow)
     If  getColumIndex(spr,"cdBasicMaster") > -1 then z9171.cdBasicMaster = getDataM(spr, getColumIndex(spr,"cdBasicMaster"), xRow)
     If  getColumIndex(spr,"BasicName") > -1 then z9171.BasicName = getDataM(spr, getColumIndex(spr,"BasicName"), xRow)
     If  getColumIndex(spr,"NameSimply") > -1 then z9171.NameSimply = getDataM(spr, getColumIndex(spr,"NameSimply"), xRow)
     If  getColumIndex(spr,"ForeignName1") > -1 then z9171.ForeignName1 = getDataM(spr, getColumIndex(spr,"ForeignName1"), xRow)
     If  getColumIndex(spr,"ForeignName2") > -1 then z9171.ForeignName2 = getDataM(spr, getColumIndex(spr,"ForeignName2"), xRow)
     If  getColumIndex(spr,"Check1") > -1 then z9171.Check1 = getDataM(spr, getColumIndex(spr,"Check1"), xRow)
     If  getColumIndex(spr,"Check2") > -1 then z9171.Check2 = getDataM(spr, getColumIndex(spr,"Check2"), xRow)
     If  getColumIndex(spr,"Check3") > -1 then z9171.Check3 = getDataM(spr, getColumIndex(spr,"Check3"), xRow)
     If  getColumIndex(spr,"Check4") > -1 then z9171.Check4 = getDataM(spr, getColumIndex(spr,"Check4"), xRow)
     If  getColumIndex(spr,"Check5") > -1 then z9171.Check5 = getDataM(spr, getColumIndex(spr,"Check5"), xRow)
     If  getColumIndex(spr,"Check6") > -1 then z9171.Check6 = getDataM(spr, getColumIndex(spr,"Check6"), xRow)
     If  getColumIndex(spr,"Check7") > -1 then z9171.Check7 = getDataM(spr, getColumIndex(spr,"Check7"), xRow)
     If  getColumIndex(spr,"Check8") > -1 then z9171.Check8 = getDataM(spr, getColumIndex(spr,"Check8"), xRow)
     If  getColumIndex(spr,"Check9") > -1 then z9171.Check9 = getDataM(spr, getColumIndex(spr,"Check9"), xRow)
     If  getColumIndex(spr,"Check10") > -1 then z9171.Check10 = getDataM(spr, getColumIndex(spr,"Check10"), xRow)
     If  getColumIndex(spr,"CheckName1") > -1 then z9171.CheckName1 = getDataM(spr, getColumIndex(spr,"CheckName1"), xRow)
     If  getColumIndex(spr,"CheckName2") > -1 then z9171.CheckName2 = getDataM(spr, getColumIndex(spr,"CheckName2"), xRow)
     If  getColumIndex(spr,"CheckName3") > -1 then z9171.CheckName3 = getDataM(spr, getColumIndex(spr,"CheckName3"), xRow)
     If  getColumIndex(spr,"CheckName4") > -1 then z9171.CheckName4 = getDataM(spr, getColumIndex(spr,"CheckName4"), xRow)
     If  getColumIndex(spr,"CheckName5") > -1 then z9171.CheckName5 = getDataM(spr, getColumIndex(spr,"CheckName5"), xRow)
     If  getColumIndex(spr,"CheckName6") > -1 then z9171.CheckName6 = getDataM(spr, getColumIndex(spr,"CheckName6"), xRow)
     If  getColumIndex(spr,"CheckName7") > -1 then z9171.CheckName7 = getDataM(spr, getColumIndex(spr,"CheckName7"), xRow)
     If  getColumIndex(spr,"CheckName8") > -1 then z9171.CheckName8 = getDataM(spr, getColumIndex(spr,"CheckName8"), xRow)
     If  getColumIndex(spr,"CheckName9") > -1 then z9171.CheckName9 = getDataM(spr, getColumIndex(spr,"CheckName9"), xRow)
     If  getColumIndex(spr,"CheckName10") > -1 then z9171.CheckName10 = getDataM(spr, getColumIndex(spr,"CheckName10"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z9171.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z9171.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"TimeInsert") > -1 then z9171.TimeInsert = getDataM(spr, getColumIndex(spr,"TimeInsert"), xRow)
     If  getColumIndex(spr,"TimeUpdate") > -1 then z9171.TimeUpdate = getDataM(spr, getColumIndex(spr,"TimeUpdate"), xRow)
     If  getColumIndex(spr,"TimeLast") > -1 then z9171.TimeLast = getDataM(spr, getColumIndex(spr,"TimeLast"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z9171.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z9171.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K9171_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K9171_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9171 As T9171_AREA,CheckClear as Boolean,BASICSEL AS String, BASICCODE AS String) as Boolean

K9171_MOVE = False

Try
    If READ_PFK9171(BASICSEL, BASICCODE) = True Then
                z9171 = D9171
		K9171_MOVE = True
		else
	If CheckClear  = True then z9171 = nothing
     End If

     If  getColumIndex(spr,"BasicSel") > -1 then z9171.BasicSel = getDataM(spr, getColumIndex(spr,"BasicSel"), xRow)
     If  getColumIndex(spr,"BasicCode") > -1 then z9171.BasicCode = getDataM(spr, getColumIndex(spr,"BasicCode"), xRow)
     If  getColumIndex(spr,"NameHLPButton") > -1 then z9171.NameHLPButton = getDataM(spr, getColumIndex(spr,"NameHLPButton"), xRow)
     If  getColumIndex(spr,"DisplaySeq") > -1 then z9171.DisplaySeq = getDataM(spr, getColumIndex(spr,"DisplaySeq"), xRow)
     If  getColumIndex(spr,"DevelopmentCode") > -1 then z9171.DevelopmentCode = getDataM(spr, getColumIndex(spr,"DevelopmentCode"), xRow)
     If  getColumIndex(spr,"selBasicMaster") > -1 then z9171.selBasicMaster = getDataM(spr, getColumIndex(spr,"selBasicMaster"), xRow)
     If  getColumIndex(spr,"cdBasicMaster") > -1 then z9171.cdBasicMaster = getDataM(spr, getColumIndex(spr,"cdBasicMaster"), xRow)
     If  getColumIndex(spr,"BasicName") > -1 then z9171.BasicName = getDataM(spr, getColumIndex(spr,"BasicName"), xRow)
     If  getColumIndex(spr,"NameSimply") > -1 then z9171.NameSimply = getDataM(spr, getColumIndex(spr,"NameSimply"), xRow)
     If  getColumIndex(spr,"ForeignName1") > -1 then z9171.ForeignName1 = getDataM(spr, getColumIndex(spr,"ForeignName1"), xRow)
     If  getColumIndex(spr,"ForeignName2") > -1 then z9171.ForeignName2 = getDataM(spr, getColumIndex(spr,"ForeignName2"), xRow)
     If  getColumIndex(spr,"Check1") > -1 then z9171.Check1 = getDataM(spr, getColumIndex(spr,"Check1"), xRow)
     If  getColumIndex(spr,"Check2") > -1 then z9171.Check2 = getDataM(spr, getColumIndex(spr,"Check2"), xRow)
     If  getColumIndex(spr,"Check3") > -1 then z9171.Check3 = getDataM(spr, getColumIndex(spr,"Check3"), xRow)
     If  getColumIndex(spr,"Check4") > -1 then z9171.Check4 = getDataM(spr, getColumIndex(spr,"Check4"), xRow)
     If  getColumIndex(spr,"Check5") > -1 then z9171.Check5 = getDataM(spr, getColumIndex(spr,"Check5"), xRow)
     If  getColumIndex(spr,"Check6") > -1 then z9171.Check6 = getDataM(spr, getColumIndex(spr,"Check6"), xRow)
     If  getColumIndex(spr,"Check7") > -1 then z9171.Check7 = getDataM(spr, getColumIndex(spr,"Check7"), xRow)
     If  getColumIndex(spr,"Check8") > -1 then z9171.Check8 = getDataM(spr, getColumIndex(spr,"Check8"), xRow)
     If  getColumIndex(spr,"Check9") > -1 then z9171.Check9 = getDataM(spr, getColumIndex(spr,"Check9"), xRow)
     If  getColumIndex(spr,"Check10") > -1 then z9171.Check10 = getDataM(spr, getColumIndex(spr,"Check10"), xRow)
     If  getColumIndex(spr,"CheckName1") > -1 then z9171.CheckName1 = getDataM(spr, getColumIndex(spr,"CheckName1"), xRow)
     If  getColumIndex(spr,"CheckName2") > -1 then z9171.CheckName2 = getDataM(spr, getColumIndex(spr,"CheckName2"), xRow)
     If  getColumIndex(spr,"CheckName3") > -1 then z9171.CheckName3 = getDataM(spr, getColumIndex(spr,"CheckName3"), xRow)
     If  getColumIndex(spr,"CheckName4") > -1 then z9171.CheckName4 = getDataM(spr, getColumIndex(spr,"CheckName4"), xRow)
     If  getColumIndex(spr,"CheckName5") > -1 then z9171.CheckName5 = getDataM(spr, getColumIndex(spr,"CheckName5"), xRow)
     If  getColumIndex(spr,"CheckName6") > -1 then z9171.CheckName6 = getDataM(spr, getColumIndex(spr,"CheckName6"), xRow)
     If  getColumIndex(spr,"CheckName7") > -1 then z9171.CheckName7 = getDataM(spr, getColumIndex(spr,"CheckName7"), xRow)
     If  getColumIndex(spr,"CheckName8") > -1 then z9171.CheckName8 = getDataM(spr, getColumIndex(spr,"CheckName8"), xRow)
     If  getColumIndex(spr,"CheckName9") > -1 then z9171.CheckName9 = getDataM(spr, getColumIndex(spr,"CheckName9"), xRow)
     If  getColumIndex(spr,"CheckName10") > -1 then z9171.CheckName10 = getDataM(spr, getColumIndex(spr,"CheckName10"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z9171.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z9171.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"TimeInsert") > -1 then z9171.TimeInsert = getDataM(spr, getColumIndex(spr,"TimeInsert"), xRow)
     If  getColumIndex(spr,"TimeUpdate") > -1 then z9171.TimeUpdate = getDataM(spr, getColumIndex(spr,"TimeUpdate"), xRow)
     If  getColumIndex(spr,"TimeLast") > -1 then z9171.TimeLast = getDataM(spr, getColumIndex(spr,"TimeLast"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z9171.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z9171.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K9171_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K9171_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9171 As T9171_AREA, Job as String, BASICSEL AS String, BASICCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9171_MOVE = False

Try
    If READ_PFK9171(BASICSEL, BASICCODE) = True Then
                z9171 = D9171
		K9171_MOVE = True
		else
	z9171 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9171")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "BASICSEL":z9171.BasicSel = Children(i).Code
   Case "BASICCODE":z9171.BasicCode = Children(i).Code
   Case "NAMEHLPBUTTON":z9171.NameHLPButton = Children(i).Code
   Case "DISPLAYSEQ":z9171.DisplaySeq = Children(i).Code
   Case "DEVELOPMENTCODE":z9171.DevelopmentCode = Children(i).Code
   Case "SELBASICMASTER":z9171.selBasicMaster = Children(i).Code
   Case "CDBASICMASTER":z9171.cdBasicMaster = Children(i).Code
   Case "BASICNAME":z9171.BasicName = Children(i).Code
   Case "NAMESIMPLY":z9171.NameSimply = Children(i).Code
   Case "FOREIGNNAME1":z9171.ForeignName1 = Children(i).Code
   Case "FOREIGNNAME2":z9171.ForeignName2 = Children(i).Code
   Case "CHECK1":z9171.Check1 = Children(i).Code
   Case "CHECK2":z9171.Check2 = Children(i).Code
   Case "CHECK3":z9171.Check3 = Children(i).Code
   Case "CHECK4":z9171.Check4 = Children(i).Code
   Case "CHECK5":z9171.Check5 = Children(i).Code
   Case "CHECK6":z9171.Check6 = Children(i).Code
   Case "CHECK7":z9171.Check7 = Children(i).Code
   Case "CHECK8":z9171.Check8 = Children(i).Code
   Case "CHECK9":z9171.Check9 = Children(i).Code
   Case "CHECK10":z9171.Check10 = Children(i).Code
   Case "CHECKNAME1":z9171.CheckName1 = Children(i).Code
   Case "CHECKNAME2":z9171.CheckName2 = Children(i).Code
   Case "CHECKNAME3":z9171.CheckName3 = Children(i).Code
   Case "CHECKNAME4":z9171.CheckName4 = Children(i).Code
   Case "CHECKNAME5":z9171.CheckName5 = Children(i).Code
   Case "CHECKNAME6":z9171.CheckName6 = Children(i).Code
   Case "CHECKNAME7":z9171.CheckName7 = Children(i).Code
   Case "CHECKNAME8":z9171.CheckName8 = Children(i).Code
   Case "CHECKNAME9":z9171.CheckName9 = Children(i).Code
   Case "CHECKNAME10":z9171.CheckName10 = Children(i).Code
   Case "DATEINSERT":z9171.DateInsert = Children(i).Code
   Case "DATEUPDATE":z9171.DateUpdate = Children(i).Code
   Case "TIMEINSERT":z9171.TimeInsert = Children(i).Code
   Case "TIMEUPDATE":z9171.TimeUpdate = Children(i).Code
   Case "TIMELAST":z9171.TimeLast = Children(i).Code
   Case "CHECKUSE":z9171.CheckUse = Children(i).Code
   Case "REMARK":z9171.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "BASICSEL":z9171.BasicSel = Children(i).Data
   Case "BASICCODE":z9171.BasicCode = Children(i).Data
   Case "NAMEHLPBUTTON":z9171.NameHLPButton = Children(i).Data
   Case "DISPLAYSEQ":z9171.DisplaySeq = Children(i).Data
   Case "DEVELOPMENTCODE":z9171.DevelopmentCode = Children(i).Data
   Case "SELBASICMASTER":z9171.selBasicMaster = Children(i).Data
   Case "CDBASICMASTER":z9171.cdBasicMaster = Children(i).Data
   Case "BASICNAME":z9171.BasicName = Children(i).Data
   Case "NAMESIMPLY":z9171.NameSimply = Children(i).Data
   Case "FOREIGNNAME1":z9171.ForeignName1 = Children(i).Data
   Case "FOREIGNNAME2":z9171.ForeignName2 = Children(i).Data
   Case "CHECK1":z9171.Check1 = Children(i).Data
   Case "CHECK2":z9171.Check2 = Children(i).Data
   Case "CHECK3":z9171.Check3 = Children(i).Data
   Case "CHECK4":z9171.Check4 = Children(i).Data
   Case "CHECK5":z9171.Check5 = Children(i).Data
   Case "CHECK6":z9171.Check6 = Children(i).Data
   Case "CHECK7":z9171.Check7 = Children(i).Data
   Case "CHECK8":z9171.Check8 = Children(i).Data
   Case "CHECK9":z9171.Check9 = Children(i).Data
   Case "CHECK10":z9171.Check10 = Children(i).Data
   Case "CHECKNAME1":z9171.CheckName1 = Children(i).Data
   Case "CHECKNAME2":z9171.CheckName2 = Children(i).Data
   Case "CHECKNAME3":z9171.CheckName3 = Children(i).Data
   Case "CHECKNAME4":z9171.CheckName4 = Children(i).Data
   Case "CHECKNAME5":z9171.CheckName5 = Children(i).Data
   Case "CHECKNAME6":z9171.CheckName6 = Children(i).Data
   Case "CHECKNAME7":z9171.CheckName7 = Children(i).Data
   Case "CHECKNAME8":z9171.CheckName8 = Children(i).Data
   Case "CHECKNAME9":z9171.CheckName9 = Children(i).Data
   Case "CHECKNAME10":z9171.CheckName10 = Children(i).Data
   Case "DATEINSERT":z9171.DateInsert = Children(i).Data
   Case "DATEUPDATE":z9171.DateUpdate = Children(i).Data
   Case "TIMEINSERT":z9171.TimeInsert = Children(i).Data
   Case "TIMEUPDATE":z9171.TimeUpdate = Children(i).Data
   Case "TIMELAST":z9171.TimeLast = Children(i).Data
   Case "CHECKUSE":z9171.CheckUse = Children(i).Data
   Case "REMARK":z9171.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K9171_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K9171_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9171 As T9171_AREA, Job as String, CheckClear as Boolean, BASICSEL AS String, BASICCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9171_MOVE = False

Try
    If READ_PFK9171(BASICSEL, BASICCODE) = True Then
                z9171 = D9171
		K9171_MOVE = True
		else
	If CheckClear  = True then z9171 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9171")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "BASICSEL":z9171.BasicSel = Children(i).Code
   Case "BASICCODE":z9171.BasicCode = Children(i).Code
   Case "NAMEHLPBUTTON":z9171.NameHLPButton = Children(i).Code
   Case "DISPLAYSEQ":z9171.DisplaySeq = Children(i).Code
   Case "DEVELOPMENTCODE":z9171.DevelopmentCode = Children(i).Code
   Case "SELBASICMASTER":z9171.selBasicMaster = Children(i).Code
   Case "CDBASICMASTER":z9171.cdBasicMaster = Children(i).Code
   Case "BASICNAME":z9171.BasicName = Children(i).Code
   Case "NAMESIMPLY":z9171.NameSimply = Children(i).Code
   Case "FOREIGNNAME1":z9171.ForeignName1 = Children(i).Code
   Case "FOREIGNNAME2":z9171.ForeignName2 = Children(i).Code
   Case "CHECK1":z9171.Check1 = Children(i).Code
   Case "CHECK2":z9171.Check2 = Children(i).Code
   Case "CHECK3":z9171.Check3 = Children(i).Code
   Case "CHECK4":z9171.Check4 = Children(i).Code
   Case "CHECK5":z9171.Check5 = Children(i).Code
   Case "CHECK6":z9171.Check6 = Children(i).Code
   Case "CHECK7":z9171.Check7 = Children(i).Code
   Case "CHECK8":z9171.Check8 = Children(i).Code
   Case "CHECK9":z9171.Check9 = Children(i).Code
   Case "CHECK10":z9171.Check10 = Children(i).Code
   Case "CHECKNAME1":z9171.CheckName1 = Children(i).Code
   Case "CHECKNAME2":z9171.CheckName2 = Children(i).Code
   Case "CHECKNAME3":z9171.CheckName3 = Children(i).Code
   Case "CHECKNAME4":z9171.CheckName4 = Children(i).Code
   Case "CHECKNAME5":z9171.CheckName5 = Children(i).Code
   Case "CHECKNAME6":z9171.CheckName6 = Children(i).Code
   Case "CHECKNAME7":z9171.CheckName7 = Children(i).Code
   Case "CHECKNAME8":z9171.CheckName8 = Children(i).Code
   Case "CHECKNAME9":z9171.CheckName9 = Children(i).Code
   Case "CHECKNAME10":z9171.CheckName10 = Children(i).Code
   Case "DATEINSERT":z9171.DateInsert = Children(i).Code
   Case "DATEUPDATE":z9171.DateUpdate = Children(i).Code
   Case "TIMEINSERT":z9171.TimeInsert = Children(i).Code
   Case "TIMEUPDATE":z9171.TimeUpdate = Children(i).Code
   Case "TIMELAST":z9171.TimeLast = Children(i).Code
   Case "CHECKUSE":z9171.CheckUse = Children(i).Code
   Case "REMARK":z9171.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "BASICSEL":z9171.BasicSel = Children(i).Data
   Case "BASICCODE":z9171.BasicCode = Children(i).Data
   Case "NAMEHLPBUTTON":z9171.NameHLPButton = Children(i).Data
   Case "DISPLAYSEQ":z9171.DisplaySeq = Children(i).Data
   Case "DEVELOPMENTCODE":z9171.DevelopmentCode = Children(i).Data
   Case "SELBASICMASTER":z9171.selBasicMaster = Children(i).Data
   Case "CDBASICMASTER":z9171.cdBasicMaster = Children(i).Data
   Case "BASICNAME":z9171.BasicName = Children(i).Data
   Case "NAMESIMPLY":z9171.NameSimply = Children(i).Data
   Case "FOREIGNNAME1":z9171.ForeignName1 = Children(i).Data
   Case "FOREIGNNAME2":z9171.ForeignName2 = Children(i).Data
   Case "CHECK1":z9171.Check1 = Children(i).Data
   Case "CHECK2":z9171.Check2 = Children(i).Data
   Case "CHECK3":z9171.Check3 = Children(i).Data
   Case "CHECK4":z9171.Check4 = Children(i).Data
   Case "CHECK5":z9171.Check5 = Children(i).Data
   Case "CHECK6":z9171.Check6 = Children(i).Data
   Case "CHECK7":z9171.Check7 = Children(i).Data
   Case "CHECK8":z9171.Check8 = Children(i).Data
   Case "CHECK9":z9171.Check9 = Children(i).Data
   Case "CHECK10":z9171.Check10 = Children(i).Data
   Case "CHECKNAME1":z9171.CheckName1 = Children(i).Data
   Case "CHECKNAME2":z9171.CheckName2 = Children(i).Data
   Case "CHECKNAME3":z9171.CheckName3 = Children(i).Data
   Case "CHECKNAME4":z9171.CheckName4 = Children(i).Data
   Case "CHECKNAME5":z9171.CheckName5 = Children(i).Data
   Case "CHECKNAME6":z9171.CheckName6 = Children(i).Data
   Case "CHECKNAME7":z9171.CheckName7 = Children(i).Data
   Case "CHECKNAME8":z9171.CheckName8 = Children(i).Data
   Case "CHECKNAME9":z9171.CheckName9 = Children(i).Data
   Case "CHECKNAME10":z9171.CheckName10 = Children(i).Data
   Case "DATEINSERT":z9171.DateInsert = Children(i).Data
   Case "DATEUPDATE":z9171.DateUpdate = Children(i).Data
   Case "TIMEINSERT":z9171.TimeInsert = Children(i).Data
   Case "TIMEUPDATE":z9171.TimeUpdate = Children(i).Data
   Case "TIMELAST":z9171.TimeLast = Children(i).Data
   Case "CHECKUSE":z9171.CheckUse = Children(i).Data
   Case "REMARK":z9171.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K9171_MOVE",vbCritical)
End Try
End Function 
    
End Module 
