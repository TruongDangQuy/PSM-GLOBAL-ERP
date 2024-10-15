'=========================================================================================================================================================
'   TABLE : (PFK9970)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K9970

Structure T9970_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	cdSite	 AS String	'			char(3)		*
Public 	ProgramName	 AS String	'			nvarchar(50)		*
Public 	seSite	 AS String	'			char(3)
Public 	CheckType	 AS String	'			char(1)
Public 	TemplateNo	 AS Double	'			decimal
Public 	ProgramFix	 AS String	'			nvarchar(50)
Public 	cntTab	 AS Double	'			decimal
Public 	TagName1	 AS String	'			nvarchar(100)
Public 	TagName2	 AS String	'			nvarchar(100)
Public 	TagName3	 AS String	'			nvarchar(100)
Public 	SheetName10	 AS String	'			nvarchar(200)
Public 	SheetName11	 AS String	'			nvarchar(200)
Public 	SheetName12	 AS String	'			nvarchar(200)
Public 	SheetName20	 AS String	'			nvarchar(200)
Public 	SheetName21	 AS String	'			nvarchar(200)
Public 	SheetName22	 AS String	'			nvarchar(200)
Public 	SheetName30	 AS String	'			nvarchar(200)
Public 	SheetName31	 AS String	'			nvarchar(200)
Public 	SheetName32	 AS String	'			nvarchar(200)
Public 	Parameter01	 AS String	'			nvarchar(20)
Public 	Parameter02	 AS String	'			nvarchar(20)
Public 	Parameter03	 AS String	'			nvarchar(20)
Public 	Parameter04	 AS String	'			nvarchar(20)
Public 	Parameter05	 AS String	'			nvarchar(20)
Public 	Parameter06	 AS String	'			nvarchar(20)
Public 	Parameter07	 AS String	'			nvarchar(20)
Public 	Parameter08	 AS String	'			nvarchar(20)
Public 	Parameter09	 AS String	'			nvarchar(20)
Public 	Parameter10	 AS String	'			nvarchar(20)
Public 	Parameter11	 AS String	'			nvarchar(20)
Public 	Parameter12	 AS String	'			nvarchar(20)
Public 	Parameter13	 AS String	'			nvarchar(20)
Public 	Parameter14	 AS String	'			nvarchar(20)
Public 	Parameter15	 AS String	'			nvarchar(20)
Public 	Parameter16	 AS String	'			nvarchar(20)
Public 	Parameter17	 AS String	'			nvarchar(20)
Public 	Parameter18	 AS String	'			nvarchar(20)
Public 	Parameter19	 AS String	'			nvarchar(20)
Public 	Parameter20	 AS String	'			nvarchar(20)
Public 	DateInsert	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
'=========================================================================================================================================================
End structure

Public D9970 As T9970_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK9970(CDSITE AS String, PROGRAMNAME AS String) As Boolean
    READ_PFK9970 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9970 "
    SQL = SQL & " WHERE K9970_cdSite		 = '" & cdSite & "' " 
    SQL = SQL & "   AND K9970_ProgramName		 = '" & ProgramName & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D9970_CLEAR: GoTo SKIP_READ_PFK9970
                
    Call K9970_MOVE(rd)
    READ_PFK9970 = True

SKIP_READ_PFK9970:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK9970",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK9970(CDSITE AS String, PROGRAMNAME AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9970 "
    SQL = SQL & " WHERE K9970_cdSite		 = '" & cdSite & "' " 
    SQL = SQL & "   AND K9970_ProgramName		 = '" & ProgramName & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK9970",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK9970(z9970 As T9970_AREA) As Boolean
    WRITE_PFK9970 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z9970)
 
    SQL = " INSERT INTO PFK9970 "
    SQL = SQL & " ( "
    SQL = SQL & " K9970_cdSite," 
    SQL = SQL & " K9970_ProgramName," 
    SQL = SQL & " K9970_seSite," 
    SQL = SQL & " K9970_CheckType," 
    SQL = SQL & " K9970_TemplateNo," 
    SQL = SQL & " K9970_ProgramFix," 
    SQL = SQL & " K9970_cntTab," 
    SQL = SQL & " K9970_TagName1," 
    SQL = SQL & " K9970_TagName2," 
    SQL = SQL & " K9970_TagName3," 
    SQL = SQL & " K9970_SheetName10," 
    SQL = SQL & " K9970_SheetName11," 
    SQL = SQL & " K9970_SheetName12," 
    SQL = SQL & " K9970_SheetName20," 
    SQL = SQL & " K9970_SheetName21," 
    SQL = SQL & " K9970_SheetName22," 
    SQL = SQL & " K9970_SheetName30," 
    SQL = SQL & " K9970_SheetName31," 
    SQL = SQL & " K9970_SheetName32," 
    SQL = SQL & " K9970_Parameter01," 
    SQL = SQL & " K9970_Parameter02," 
    SQL = SQL & " K9970_Parameter03," 
    SQL = SQL & " K9970_Parameter04," 
    SQL = SQL & " K9970_Parameter05," 
    SQL = SQL & " K9970_Parameter06," 
    SQL = SQL & " K9970_Parameter07," 
    SQL = SQL & " K9970_Parameter08," 
    SQL = SQL & " K9970_Parameter09," 
    SQL = SQL & " K9970_Parameter10," 
    SQL = SQL & " K9970_Parameter11," 
    SQL = SQL & " K9970_Parameter12," 
    SQL = SQL & " K9970_Parameter13," 
    SQL = SQL & " K9970_Parameter14," 
    SQL = SQL & " K9970_Parameter15," 
    SQL = SQL & " K9970_Parameter16," 
    SQL = SQL & " K9970_Parameter17," 
    SQL = SQL & " K9970_Parameter18," 
    SQL = SQL & " K9970_Parameter19," 
    SQL = SQL & " K9970_Parameter20," 
    SQL = SQL & " K9970_DateInsert," 
    SQL = SQL & " K9970_InchargeInsert," 
    SQL = SQL & " K9970_DateUpdate," 
    SQL = SQL & " K9970_InchargeUpdate " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z9970.cdSite) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.ProgramName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.seSite) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.CheckType) & "', "  
    SQL = SQL & "   " & FormatSQL(z9970.TemplateNo) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z9970.ProgramFix) & "', "  
    SQL = SQL & "   " & FormatSQL(z9970.cntTab) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z9970.TagName1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.TagName2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.TagName3) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.SheetName10) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.SheetName11) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.SheetName12) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.SheetName20) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.SheetName21) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.SheetName22) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.SheetName30) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.SheetName31) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.SheetName32) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.Parameter01) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.Parameter02) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.Parameter03) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.Parameter04) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.Parameter05) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.Parameter06) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.Parameter07) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.Parameter08) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.Parameter09) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.Parameter10) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.Parameter11) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.Parameter12) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.Parameter13) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.Parameter14) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.Parameter15) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.Parameter16) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.Parameter17) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.Parameter18) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.Parameter19) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.Parameter20) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9970.InchargeUpdate) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK9970 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK9970",vbCritical)
Finally
        Call GetFullInformation("PFK9970", "I", SQL)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK9970(z9970 As T9970_AREA) As Boolean
    REWRITE_PFK9970 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z9970)
   
    SQL = " UPDATE PFK9970 SET "
    SQL = SQL & "    K9970_seSite      = N'" & FormatSQL(z9970.seSite) & "', " 
    SQL = SQL & "    K9970_CheckType      = N'" & FormatSQL(z9970.CheckType) & "', " 
    SQL = SQL & "    K9970_TemplateNo      =  " & FormatSQL(z9970.TemplateNo) & ", " 
    SQL = SQL & "    K9970_ProgramFix      = N'" & FormatSQL(z9970.ProgramFix) & "', " 
    SQL = SQL & "    K9970_cntTab      =  " & FormatSQL(z9970.cntTab) & ", " 
    SQL = SQL & "    K9970_TagName1      = N'" & FormatSQL(z9970.TagName1) & "', " 
    SQL = SQL & "    K9970_TagName2      = N'" & FormatSQL(z9970.TagName2) & "', " 
    SQL = SQL & "    K9970_TagName3      = N'" & FormatSQL(z9970.TagName3) & "', " 
    SQL = SQL & "    K9970_SheetName10      = N'" & FormatSQL(z9970.SheetName10) & "', " 
    SQL = SQL & "    K9970_SheetName11      = N'" & FormatSQL(z9970.SheetName11) & "', " 
    SQL = SQL & "    K9970_SheetName12      = N'" & FormatSQL(z9970.SheetName12) & "', " 
    SQL = SQL & "    K9970_SheetName20      = N'" & FormatSQL(z9970.SheetName20) & "', " 
    SQL = SQL & "    K9970_SheetName21      = N'" & FormatSQL(z9970.SheetName21) & "', " 
    SQL = SQL & "    K9970_SheetName22      = N'" & FormatSQL(z9970.SheetName22) & "', " 
    SQL = SQL & "    K9970_SheetName30      = N'" & FormatSQL(z9970.SheetName30) & "', " 
    SQL = SQL & "    K9970_SheetName31      = N'" & FormatSQL(z9970.SheetName31) & "', " 
    SQL = SQL & "    K9970_SheetName32      = N'" & FormatSQL(z9970.SheetName32) & "', " 
    SQL = SQL & "    K9970_Parameter01      = N'" & FormatSQL(z9970.Parameter01) & "', " 
    SQL = SQL & "    K9970_Parameter02      = N'" & FormatSQL(z9970.Parameter02) & "', " 
    SQL = SQL & "    K9970_Parameter03      = N'" & FormatSQL(z9970.Parameter03) & "', " 
    SQL = SQL & "    K9970_Parameter04      = N'" & FormatSQL(z9970.Parameter04) & "', " 
    SQL = SQL & "    K9970_Parameter05      = N'" & FormatSQL(z9970.Parameter05) & "', " 
    SQL = SQL & "    K9970_Parameter06      = N'" & FormatSQL(z9970.Parameter06) & "', " 
    SQL = SQL & "    K9970_Parameter07      = N'" & FormatSQL(z9970.Parameter07) & "', " 
    SQL = SQL & "    K9970_Parameter08      = N'" & FormatSQL(z9970.Parameter08) & "', " 
    SQL = SQL & "    K9970_Parameter09      = N'" & FormatSQL(z9970.Parameter09) & "', " 
    SQL = SQL & "    K9970_Parameter10      = N'" & FormatSQL(z9970.Parameter10) & "', " 
    SQL = SQL & "    K9970_Parameter11      = N'" & FormatSQL(z9970.Parameter11) & "', " 
    SQL = SQL & "    K9970_Parameter12      = N'" & FormatSQL(z9970.Parameter12) & "', " 
    SQL = SQL & "    K9970_Parameter13      = N'" & FormatSQL(z9970.Parameter13) & "', " 
    SQL = SQL & "    K9970_Parameter14      = N'" & FormatSQL(z9970.Parameter14) & "', " 
    SQL = SQL & "    K9970_Parameter15      = N'" & FormatSQL(z9970.Parameter15) & "', " 
    SQL = SQL & "    K9970_Parameter16      = N'" & FormatSQL(z9970.Parameter16) & "', " 
    SQL = SQL & "    K9970_Parameter17      = N'" & FormatSQL(z9970.Parameter17) & "', " 
    SQL = SQL & "    K9970_Parameter18      = N'" & FormatSQL(z9970.Parameter18) & "', " 
    SQL = SQL & "    K9970_Parameter19      = N'" & FormatSQL(z9970.Parameter19) & "', " 
    SQL = SQL & "    K9970_Parameter20      = N'" & FormatSQL(z9970.Parameter20) & "', " 
    SQL = SQL & "    K9970_DateInsert      = N'" & FormatSQL(z9970.DateInsert) & "', " 
    SQL = SQL & "    K9970_InchargeInsert      = N'" & FormatSQL(z9970.InchargeInsert) & "', " 
    SQL = SQL & "    K9970_DateUpdate      = N'" & FormatSQL(z9970.DateUpdate) & "', " 
    SQL = SQL & "    K9970_InchargeUpdate      = N'" & FormatSQL(z9970.InchargeUpdate) & "'  " 
    SQL = SQL & " WHERE K9970_cdSite		 = '" & z9970.cdSite & "' " 
    SQL = SQL & "   AND K9970_ProgramName		 = '" & z9970.ProgramName & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
	REWRITE_PFK9970 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK9970",vbCritical)
Finally
        Call GetFullInformation("PFK9970", "U", SQL)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK9970(z9970 As T9970_AREA) As Boolean
    DELETE_PFK9970 = False

   Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z9970)
      
        SQL = " DELETE FROM PFK9970  "
    SQL = SQL & " WHERE K9970_cdSite		 = '" & z9970.cdSite & "' " 
    SQL = SQL & "   AND K9970_ProgramName		 = '" & z9970.ProgramName & "' " 

    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK9970 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK9970",vbCritical)
Finally
        Call GetFullInformation("PFK9970", "U", SQL)
  End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D9970_CLEAR()
Try
    
   D9970.cdSite = ""
   D9970.ProgramName = ""
   D9970.seSite = ""
   D9970.CheckType = ""
    D9970.TemplateNo = 0 
   D9970.ProgramFix = ""
    D9970.cntTab = 0 
   D9970.TagName1 = ""
   D9970.TagName2 = ""
   D9970.TagName3 = ""
   D9970.SheetName10 = ""
   D9970.SheetName11 = ""
   D9970.SheetName12 = ""
   D9970.SheetName20 = ""
   D9970.SheetName21 = ""
   D9970.SheetName22 = ""
   D9970.SheetName30 = ""
   D9970.SheetName31 = ""
   D9970.SheetName32 = ""
   D9970.Parameter01 = ""
   D9970.Parameter02 = ""
   D9970.Parameter03 = ""
   D9970.Parameter04 = ""
   D9970.Parameter05 = ""
   D9970.Parameter06 = ""
   D9970.Parameter07 = ""
   D9970.Parameter08 = ""
   D9970.Parameter09 = ""
   D9970.Parameter10 = ""
   D9970.Parameter11 = ""
   D9970.Parameter12 = ""
   D9970.Parameter13 = ""
   D9970.Parameter14 = ""
   D9970.Parameter15 = ""
   D9970.Parameter16 = ""
   D9970.Parameter17 = ""
   D9970.Parameter18 = ""
   D9970.Parameter19 = ""
   D9970.Parameter20 = ""
   D9970.DateInsert = ""
   D9970.InchargeInsert = ""
   D9970.DateUpdate = ""
   D9970.InchargeUpdate = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D9970_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x9970 As T9970_AREA)
Try
    
    x9970.cdSite = trim$(  x9970.cdSite)
    x9970.ProgramName = trim$(  x9970.ProgramName)
    x9970.seSite = trim$(  x9970.seSite)
    x9970.CheckType = trim$(  x9970.CheckType)
    x9970.TemplateNo = trim$(  x9970.TemplateNo)
    x9970.ProgramFix = trim$(  x9970.ProgramFix)
    x9970.cntTab = trim$(  x9970.cntTab)
    x9970.TagName1 = trim$(  x9970.TagName1)
    x9970.TagName2 = trim$(  x9970.TagName2)
    x9970.TagName3 = trim$(  x9970.TagName3)
    x9970.SheetName10 = trim$(  x9970.SheetName10)
    x9970.SheetName11 = trim$(  x9970.SheetName11)
    x9970.SheetName12 = trim$(  x9970.SheetName12)
    x9970.SheetName20 = trim$(  x9970.SheetName20)
    x9970.SheetName21 = trim$(  x9970.SheetName21)
    x9970.SheetName22 = trim$(  x9970.SheetName22)
    x9970.SheetName30 = trim$(  x9970.SheetName30)
    x9970.SheetName31 = trim$(  x9970.SheetName31)
    x9970.SheetName32 = trim$(  x9970.SheetName32)
    x9970.Parameter01 = trim$(  x9970.Parameter01)
    x9970.Parameter02 = trim$(  x9970.Parameter02)
    x9970.Parameter03 = trim$(  x9970.Parameter03)
    x9970.Parameter04 = trim$(  x9970.Parameter04)
    x9970.Parameter05 = trim$(  x9970.Parameter05)
    x9970.Parameter06 = trim$(  x9970.Parameter06)
    x9970.Parameter07 = trim$(  x9970.Parameter07)
    x9970.Parameter08 = trim$(  x9970.Parameter08)
    x9970.Parameter09 = trim$(  x9970.Parameter09)
    x9970.Parameter10 = trim$(  x9970.Parameter10)
    x9970.Parameter11 = trim$(  x9970.Parameter11)
    x9970.Parameter12 = trim$(  x9970.Parameter12)
    x9970.Parameter13 = trim$(  x9970.Parameter13)
    x9970.Parameter14 = trim$(  x9970.Parameter14)
    x9970.Parameter15 = trim$(  x9970.Parameter15)
    x9970.Parameter16 = trim$(  x9970.Parameter16)
    x9970.Parameter17 = trim$(  x9970.Parameter17)
    x9970.Parameter18 = trim$(  x9970.Parameter18)
    x9970.Parameter19 = trim$(  x9970.Parameter19)
    x9970.Parameter20 = trim$(  x9970.Parameter20)
    x9970.DateInsert = trim$(  x9970.DateInsert)
    x9970.InchargeInsert = trim$(  x9970.InchargeInsert)
    x9970.DateUpdate = trim$(  x9970.DateUpdate)
    x9970.InchargeUpdate = trim$(  x9970.InchargeUpdate)
     
    If trim$( x9970.cdSite ) = "" Then x9970.cdSite = Space(1) 
    If trim$( x9970.ProgramName ) = "" Then x9970.ProgramName = Space(1) 
    If trim$( x9970.seSite ) = "" Then x9970.seSite = Space(1) 
    If trim$( x9970.CheckType ) = "" Then x9970.CheckType = Space(1) 
    If trim$( x9970.TemplateNo ) = "" Then x9970.TemplateNo = 0 
    If trim$( x9970.ProgramFix ) = "" Then x9970.ProgramFix = Space(1) 
    If trim$( x9970.cntTab ) = "" Then x9970.cntTab = 0 
    If trim$( x9970.TagName1 ) = "" Then x9970.TagName1 = Space(1) 
    If trim$( x9970.TagName2 ) = "" Then x9970.TagName2 = Space(1) 
    If trim$( x9970.TagName3 ) = "" Then x9970.TagName3 = Space(1) 
    If trim$( x9970.SheetName10 ) = "" Then x9970.SheetName10 = Space(1) 
    If trim$( x9970.SheetName11 ) = "" Then x9970.SheetName11 = Space(1) 
    If trim$( x9970.SheetName12 ) = "" Then x9970.SheetName12 = Space(1) 
    If trim$( x9970.SheetName20 ) = "" Then x9970.SheetName20 = Space(1) 
    If trim$( x9970.SheetName21 ) = "" Then x9970.SheetName21 = Space(1) 
    If trim$( x9970.SheetName22 ) = "" Then x9970.SheetName22 = Space(1) 
    If trim$( x9970.SheetName30 ) = "" Then x9970.SheetName30 = Space(1) 
    If trim$( x9970.SheetName31 ) = "" Then x9970.SheetName31 = Space(1) 
    If trim$( x9970.SheetName32 ) = "" Then x9970.SheetName32 = Space(1) 
    If trim$( x9970.Parameter01 ) = "" Then x9970.Parameter01 = Space(1) 
    If trim$( x9970.Parameter02 ) = "" Then x9970.Parameter02 = Space(1) 
    If trim$( x9970.Parameter03 ) = "" Then x9970.Parameter03 = Space(1) 
    If trim$( x9970.Parameter04 ) = "" Then x9970.Parameter04 = Space(1) 
    If trim$( x9970.Parameter05 ) = "" Then x9970.Parameter05 = Space(1) 
    If trim$( x9970.Parameter06 ) = "" Then x9970.Parameter06 = Space(1) 
    If trim$( x9970.Parameter07 ) = "" Then x9970.Parameter07 = Space(1) 
    If trim$( x9970.Parameter08 ) = "" Then x9970.Parameter08 = Space(1) 
    If trim$( x9970.Parameter09 ) = "" Then x9970.Parameter09 = Space(1) 
    If trim$( x9970.Parameter10 ) = "" Then x9970.Parameter10 = Space(1) 
    If trim$( x9970.Parameter11 ) = "" Then x9970.Parameter11 = Space(1) 
    If trim$( x9970.Parameter12 ) = "" Then x9970.Parameter12 = Space(1) 
    If trim$( x9970.Parameter13 ) = "" Then x9970.Parameter13 = Space(1) 
    If trim$( x9970.Parameter14 ) = "" Then x9970.Parameter14 = Space(1) 
    If trim$( x9970.Parameter15 ) = "" Then x9970.Parameter15 = Space(1) 
    If trim$( x9970.Parameter16 ) = "" Then x9970.Parameter16 = Space(1) 
    If trim$( x9970.Parameter17 ) = "" Then x9970.Parameter17 = Space(1) 
    If trim$( x9970.Parameter18 ) = "" Then x9970.Parameter18 = Space(1) 
    If trim$( x9970.Parameter19 ) = "" Then x9970.Parameter19 = Space(1) 
    If trim$( x9970.Parameter20 ) = "" Then x9970.Parameter20 = Space(1) 
    If trim$( x9970.DateInsert ) = "" Then x9970.DateInsert = Space(1) 
    If trim$( x9970.InchargeInsert ) = "" Then x9970.InchargeInsert = Space(1) 
    If trim$( x9970.DateUpdate ) = "" Then x9970.DateUpdate = Space(1) 
    If trim$( x9970.InchargeUpdate ) = "" Then x9970.InchargeUpdate = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K9970_MOVE(rs9970 As SqlClient.SqlDataReader)
Try

    call D9970_CLEAR()   

    If IsdbNull(rs9970!K9970_cdSite) = False Then D9970.cdSite = Trim$(rs9970!K9970_cdSite)
    If IsdbNull(rs9970!K9970_ProgramName) = False Then D9970.ProgramName = Trim$(rs9970!K9970_ProgramName)
    If IsdbNull(rs9970!K9970_seSite) = False Then D9970.seSite = Trim$(rs9970!K9970_seSite)
    If IsdbNull(rs9970!K9970_CheckType) = False Then D9970.CheckType = Trim$(rs9970!K9970_CheckType)
    If IsdbNull(rs9970!K9970_TemplateNo) = False Then D9970.TemplateNo = Trim$(rs9970!K9970_TemplateNo)
    If IsdbNull(rs9970!K9970_ProgramFix) = False Then D9970.ProgramFix = Trim$(rs9970!K9970_ProgramFix)
    If IsdbNull(rs9970!K9970_cntTab) = False Then D9970.cntTab = Trim$(rs9970!K9970_cntTab)
    If IsdbNull(rs9970!K9970_TagName1) = False Then D9970.TagName1 = Trim$(rs9970!K9970_TagName1)
    If IsdbNull(rs9970!K9970_TagName2) = False Then D9970.TagName2 = Trim$(rs9970!K9970_TagName2)
    If IsdbNull(rs9970!K9970_TagName3) = False Then D9970.TagName3 = Trim$(rs9970!K9970_TagName3)
    If IsdbNull(rs9970!K9970_SheetName10) = False Then D9970.SheetName10 = Trim$(rs9970!K9970_SheetName10)
    If IsdbNull(rs9970!K9970_SheetName11) = False Then D9970.SheetName11 = Trim$(rs9970!K9970_SheetName11)
    If IsdbNull(rs9970!K9970_SheetName12) = False Then D9970.SheetName12 = Trim$(rs9970!K9970_SheetName12)
    If IsdbNull(rs9970!K9970_SheetName20) = False Then D9970.SheetName20 = Trim$(rs9970!K9970_SheetName20)
    If IsdbNull(rs9970!K9970_SheetName21) = False Then D9970.SheetName21 = Trim$(rs9970!K9970_SheetName21)
    If IsdbNull(rs9970!K9970_SheetName22) = False Then D9970.SheetName22 = Trim$(rs9970!K9970_SheetName22)
    If IsdbNull(rs9970!K9970_SheetName30) = False Then D9970.SheetName30 = Trim$(rs9970!K9970_SheetName30)
    If IsdbNull(rs9970!K9970_SheetName31) = False Then D9970.SheetName31 = Trim$(rs9970!K9970_SheetName31)
    If IsdbNull(rs9970!K9970_SheetName32) = False Then D9970.SheetName32 = Trim$(rs9970!K9970_SheetName32)
    If IsdbNull(rs9970!K9970_Parameter01) = False Then D9970.Parameter01 = Trim$(rs9970!K9970_Parameter01)
    If IsdbNull(rs9970!K9970_Parameter02) = False Then D9970.Parameter02 = Trim$(rs9970!K9970_Parameter02)
    If IsdbNull(rs9970!K9970_Parameter03) = False Then D9970.Parameter03 = Trim$(rs9970!K9970_Parameter03)
    If IsdbNull(rs9970!K9970_Parameter04) = False Then D9970.Parameter04 = Trim$(rs9970!K9970_Parameter04)
    If IsdbNull(rs9970!K9970_Parameter05) = False Then D9970.Parameter05 = Trim$(rs9970!K9970_Parameter05)
    If IsdbNull(rs9970!K9970_Parameter06) = False Then D9970.Parameter06 = Trim$(rs9970!K9970_Parameter06)
    If IsdbNull(rs9970!K9970_Parameter07) = False Then D9970.Parameter07 = Trim$(rs9970!K9970_Parameter07)
    If IsdbNull(rs9970!K9970_Parameter08) = False Then D9970.Parameter08 = Trim$(rs9970!K9970_Parameter08)
    If IsdbNull(rs9970!K9970_Parameter09) = False Then D9970.Parameter09 = Trim$(rs9970!K9970_Parameter09)
    If IsdbNull(rs9970!K9970_Parameter10) = False Then D9970.Parameter10 = Trim$(rs9970!K9970_Parameter10)
    If IsdbNull(rs9970!K9970_Parameter11) = False Then D9970.Parameter11 = Trim$(rs9970!K9970_Parameter11)
    If IsdbNull(rs9970!K9970_Parameter12) = False Then D9970.Parameter12 = Trim$(rs9970!K9970_Parameter12)
    If IsdbNull(rs9970!K9970_Parameter13) = False Then D9970.Parameter13 = Trim$(rs9970!K9970_Parameter13)
    If IsdbNull(rs9970!K9970_Parameter14) = False Then D9970.Parameter14 = Trim$(rs9970!K9970_Parameter14)
    If IsdbNull(rs9970!K9970_Parameter15) = False Then D9970.Parameter15 = Trim$(rs9970!K9970_Parameter15)
    If IsdbNull(rs9970!K9970_Parameter16) = False Then D9970.Parameter16 = Trim$(rs9970!K9970_Parameter16)
    If IsdbNull(rs9970!K9970_Parameter17) = False Then D9970.Parameter17 = Trim$(rs9970!K9970_Parameter17)
    If IsdbNull(rs9970!K9970_Parameter18) = False Then D9970.Parameter18 = Trim$(rs9970!K9970_Parameter18)
    If IsdbNull(rs9970!K9970_Parameter19) = False Then D9970.Parameter19 = Trim$(rs9970!K9970_Parameter19)
    If IsdbNull(rs9970!K9970_Parameter20) = False Then D9970.Parameter20 = Trim$(rs9970!K9970_Parameter20)
    If IsdbNull(rs9970!K9970_DateInsert) = False Then D9970.DateInsert = Trim$(rs9970!K9970_DateInsert)
    If IsdbNull(rs9970!K9970_InchargeInsert) = False Then D9970.InchargeInsert = Trim$(rs9970!K9970_InchargeInsert)
    If IsdbNull(rs9970!K9970_DateUpdate) = False Then D9970.DateUpdate = Trim$(rs9970!K9970_DateUpdate)
    If IsdbNull(rs9970!K9970_InchargeUpdate) = False Then D9970.InchargeUpdate = Trim$(rs9970!K9970_InchargeUpdate)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9970_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K9970_MOVE(rs9970 As DataRow)
Try

    call D9970_CLEAR()   

    If IsdbNull(rs9970!K9970_cdSite) = False Then D9970.cdSite = Trim$(rs9970!K9970_cdSite)
    If IsdbNull(rs9970!K9970_ProgramName) = False Then D9970.ProgramName = Trim$(rs9970!K9970_ProgramName)
    If IsdbNull(rs9970!K9970_seSite) = False Then D9970.seSite = Trim$(rs9970!K9970_seSite)
    If IsdbNull(rs9970!K9970_CheckType) = False Then D9970.CheckType = Trim$(rs9970!K9970_CheckType)
    If IsdbNull(rs9970!K9970_TemplateNo) = False Then D9970.TemplateNo = Trim$(rs9970!K9970_TemplateNo)
    If IsdbNull(rs9970!K9970_ProgramFix) = False Then D9970.ProgramFix = Trim$(rs9970!K9970_ProgramFix)
    If IsdbNull(rs9970!K9970_cntTab) = False Then D9970.cntTab = Trim$(rs9970!K9970_cntTab)
    If IsdbNull(rs9970!K9970_TagName1) = False Then D9970.TagName1 = Trim$(rs9970!K9970_TagName1)
    If IsdbNull(rs9970!K9970_TagName2) = False Then D9970.TagName2 = Trim$(rs9970!K9970_TagName2)
    If IsdbNull(rs9970!K9970_TagName3) = False Then D9970.TagName3 = Trim$(rs9970!K9970_TagName3)
    If IsdbNull(rs9970!K9970_SheetName10) = False Then D9970.SheetName10 = Trim$(rs9970!K9970_SheetName10)
    If IsdbNull(rs9970!K9970_SheetName11) = False Then D9970.SheetName11 = Trim$(rs9970!K9970_SheetName11)
    If IsdbNull(rs9970!K9970_SheetName12) = False Then D9970.SheetName12 = Trim$(rs9970!K9970_SheetName12)
    If IsdbNull(rs9970!K9970_SheetName20) = False Then D9970.SheetName20 = Trim$(rs9970!K9970_SheetName20)
    If IsdbNull(rs9970!K9970_SheetName21) = False Then D9970.SheetName21 = Trim$(rs9970!K9970_SheetName21)
    If IsdbNull(rs9970!K9970_SheetName22) = False Then D9970.SheetName22 = Trim$(rs9970!K9970_SheetName22)
    If IsdbNull(rs9970!K9970_SheetName30) = False Then D9970.SheetName30 = Trim$(rs9970!K9970_SheetName30)
    If IsdbNull(rs9970!K9970_SheetName31) = False Then D9970.SheetName31 = Trim$(rs9970!K9970_SheetName31)
    If IsdbNull(rs9970!K9970_SheetName32) = False Then D9970.SheetName32 = Trim$(rs9970!K9970_SheetName32)
    If IsdbNull(rs9970!K9970_Parameter01) = False Then D9970.Parameter01 = Trim$(rs9970!K9970_Parameter01)
    If IsdbNull(rs9970!K9970_Parameter02) = False Then D9970.Parameter02 = Trim$(rs9970!K9970_Parameter02)
    If IsdbNull(rs9970!K9970_Parameter03) = False Then D9970.Parameter03 = Trim$(rs9970!K9970_Parameter03)
    If IsdbNull(rs9970!K9970_Parameter04) = False Then D9970.Parameter04 = Trim$(rs9970!K9970_Parameter04)
    If IsdbNull(rs9970!K9970_Parameter05) = False Then D9970.Parameter05 = Trim$(rs9970!K9970_Parameter05)
    If IsdbNull(rs9970!K9970_Parameter06) = False Then D9970.Parameter06 = Trim$(rs9970!K9970_Parameter06)
    If IsdbNull(rs9970!K9970_Parameter07) = False Then D9970.Parameter07 = Trim$(rs9970!K9970_Parameter07)
    If IsdbNull(rs9970!K9970_Parameter08) = False Then D9970.Parameter08 = Trim$(rs9970!K9970_Parameter08)
    If IsdbNull(rs9970!K9970_Parameter09) = False Then D9970.Parameter09 = Trim$(rs9970!K9970_Parameter09)
    If IsdbNull(rs9970!K9970_Parameter10) = False Then D9970.Parameter10 = Trim$(rs9970!K9970_Parameter10)
    If IsdbNull(rs9970!K9970_Parameter11) = False Then D9970.Parameter11 = Trim$(rs9970!K9970_Parameter11)
    If IsdbNull(rs9970!K9970_Parameter12) = False Then D9970.Parameter12 = Trim$(rs9970!K9970_Parameter12)
    If IsdbNull(rs9970!K9970_Parameter13) = False Then D9970.Parameter13 = Trim$(rs9970!K9970_Parameter13)
    If IsdbNull(rs9970!K9970_Parameter14) = False Then D9970.Parameter14 = Trim$(rs9970!K9970_Parameter14)
    If IsdbNull(rs9970!K9970_Parameter15) = False Then D9970.Parameter15 = Trim$(rs9970!K9970_Parameter15)
    If IsdbNull(rs9970!K9970_Parameter16) = False Then D9970.Parameter16 = Trim$(rs9970!K9970_Parameter16)
    If IsdbNull(rs9970!K9970_Parameter17) = False Then D9970.Parameter17 = Trim$(rs9970!K9970_Parameter17)
    If IsdbNull(rs9970!K9970_Parameter18) = False Then D9970.Parameter18 = Trim$(rs9970!K9970_Parameter18)
    If IsdbNull(rs9970!K9970_Parameter19) = False Then D9970.Parameter19 = Trim$(rs9970!K9970_Parameter19)
    If IsdbNull(rs9970!K9970_Parameter20) = False Then D9970.Parameter20 = Trim$(rs9970!K9970_Parameter20)
    If IsdbNull(rs9970!K9970_DateInsert) = False Then D9970.DateInsert = Trim$(rs9970!K9970_DateInsert)
    If IsdbNull(rs9970!K9970_InchargeInsert) = False Then D9970.InchargeInsert = Trim$(rs9970!K9970_InchargeInsert)
    If IsdbNull(rs9970!K9970_DateUpdate) = False Then D9970.DateUpdate = Trim$(rs9970!K9970_DateUpdate)
    If IsdbNull(rs9970!K9970_InchargeUpdate) = False Then D9970.InchargeUpdate = Trim$(rs9970!K9970_InchargeUpdate)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9970_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K9970_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9970 As T9970_AREA, CDSITE AS String, PROGRAMNAME AS String) as Boolean

K9970_MOVE = False

Try
    If READ_PFK9970(CDSITE, PROGRAMNAME) = True Then
                z9970 = D9970
		K9970_MOVE = True
		else
	z9970 = nothing
     End If

     If  getColumnIndex(spr,"cdSite") > -1 then z9970.cdSite = getDataM(spr, getColumnIndex(spr,"cdSite"), xRow)
     If  getColumnIndex(spr,"ProgramName") > -1 then z9970.ProgramName = getDataM(spr, getColumnIndex(spr,"ProgramName"), xRow)
     If  getColumnIndex(spr,"seSite") > -1 then z9970.seSite = getDataM(spr, getColumnIndex(spr,"seSite"), xRow)
     If  getColumnIndex(spr,"CheckType") > -1 then z9970.CheckType = getDataM(spr, getColumnIndex(spr,"CheckType"), xRow)
     If  getColumnIndex(spr,"TemplateNo") > -1 then z9970.TemplateNo = getDataM(spr, getColumnIndex(spr,"TemplateNo"), xRow)
     If  getColumnIndex(spr,"ProgramFix") > -1 then z9970.ProgramFix = getDataM(spr, getColumnIndex(spr,"ProgramFix"), xRow)
     If  getColumnIndex(spr,"cntTab") > -1 then z9970.cntTab = getDataM(spr, getColumnIndex(spr,"cntTab"), xRow)
     If  getColumnIndex(spr,"TagName1") > -1 then z9970.TagName1 = getDataM(spr, getColumnIndex(spr,"TagName1"), xRow)
     If  getColumnIndex(spr,"TagName2") > -1 then z9970.TagName2 = getDataM(spr, getColumnIndex(spr,"TagName2"), xRow)
     If  getColumnIndex(spr,"TagName3") > -1 then z9970.TagName3 = getDataM(spr, getColumnIndex(spr,"TagName3"), xRow)
     If  getColumnIndex(spr,"SheetName10") > -1 then z9970.SheetName10 = getDataM(spr, getColumnIndex(spr,"SheetName10"), xRow)
     If  getColumnIndex(spr,"SheetName11") > -1 then z9970.SheetName11 = getDataM(spr, getColumnIndex(spr,"SheetName11"), xRow)
     If  getColumnIndex(spr,"SheetName12") > -1 then z9970.SheetName12 = getDataM(spr, getColumnIndex(spr,"SheetName12"), xRow)
     If  getColumnIndex(spr,"SheetName20") > -1 then z9970.SheetName20 = getDataM(spr, getColumnIndex(spr,"SheetName20"), xRow)
     If  getColumnIndex(spr,"SheetName21") > -1 then z9970.SheetName21 = getDataM(spr, getColumnIndex(spr,"SheetName21"), xRow)
     If  getColumnIndex(spr,"SheetName22") > -1 then z9970.SheetName22 = getDataM(spr, getColumnIndex(spr,"SheetName22"), xRow)
     If  getColumnIndex(spr,"SheetName30") > -1 then z9970.SheetName30 = getDataM(spr, getColumnIndex(spr,"SheetName30"), xRow)
     If  getColumnIndex(spr,"SheetName31") > -1 then z9970.SheetName31 = getDataM(spr, getColumnIndex(spr,"SheetName31"), xRow)
     If  getColumnIndex(spr,"SheetName32") > -1 then z9970.SheetName32 = getDataM(spr, getColumnIndex(spr,"SheetName32"), xRow)
     If  getColumnIndex(spr,"Parameter01") > -1 then z9970.Parameter01 = getDataM(spr, getColumnIndex(spr,"Parameter01"), xRow)
     If  getColumnIndex(spr,"Parameter02") > -1 then z9970.Parameter02 = getDataM(spr, getColumnIndex(spr,"Parameter02"), xRow)
     If  getColumnIndex(spr,"Parameter03") > -1 then z9970.Parameter03 = getDataM(spr, getColumnIndex(spr,"Parameter03"), xRow)
     If  getColumnIndex(spr,"Parameter04") > -1 then z9970.Parameter04 = getDataM(spr, getColumnIndex(spr,"Parameter04"), xRow)
     If  getColumnIndex(spr,"Parameter05") > -1 then z9970.Parameter05 = getDataM(spr, getColumnIndex(spr,"Parameter05"), xRow)
     If  getColumnIndex(spr,"Parameter06") > -1 then z9970.Parameter06 = getDataM(spr, getColumnIndex(spr,"Parameter06"), xRow)
     If  getColumnIndex(spr,"Parameter07") > -1 then z9970.Parameter07 = getDataM(spr, getColumnIndex(spr,"Parameter07"), xRow)
     If  getColumnIndex(spr,"Parameter08") > -1 then z9970.Parameter08 = getDataM(spr, getColumnIndex(spr,"Parameter08"), xRow)
     If  getColumnIndex(spr,"Parameter09") > -1 then z9970.Parameter09 = getDataM(spr, getColumnIndex(spr,"Parameter09"), xRow)
     If  getColumnIndex(spr,"Parameter10") > -1 then z9970.Parameter10 = getDataM(spr, getColumnIndex(spr,"Parameter10"), xRow)
     If  getColumnIndex(spr,"Parameter11") > -1 then z9970.Parameter11 = getDataM(spr, getColumnIndex(spr,"Parameter11"), xRow)
     If  getColumnIndex(spr,"Parameter12") > -1 then z9970.Parameter12 = getDataM(spr, getColumnIndex(spr,"Parameter12"), xRow)
     If  getColumnIndex(spr,"Parameter13") > -1 then z9970.Parameter13 = getDataM(spr, getColumnIndex(spr,"Parameter13"), xRow)
     If  getColumnIndex(spr,"Parameter14") > -1 then z9970.Parameter14 = getDataM(spr, getColumnIndex(spr,"Parameter14"), xRow)
     If  getColumnIndex(spr,"Parameter15") > -1 then z9970.Parameter15 = getDataM(spr, getColumnIndex(spr,"Parameter15"), xRow)
     If  getColumnIndex(spr,"Parameter16") > -1 then z9970.Parameter16 = getDataM(spr, getColumnIndex(spr,"Parameter16"), xRow)
     If  getColumnIndex(spr,"Parameter17") > -1 then z9970.Parameter17 = getDataM(spr, getColumnIndex(spr,"Parameter17"), xRow)
     If  getColumnIndex(spr,"Parameter18") > -1 then z9970.Parameter18 = getDataM(spr, getColumnIndex(spr,"Parameter18"), xRow)
     If  getColumnIndex(spr,"Parameter19") > -1 then z9970.Parameter19 = getDataM(spr, getColumnIndex(spr,"Parameter19"), xRow)
     If  getColumnIndex(spr,"Parameter20") > -1 then z9970.Parameter20 = getDataM(spr, getColumnIndex(spr,"Parameter20"), xRow)
     If  getColumnIndex(spr,"DateInsert") > -1 then z9970.DateInsert = getDataM(spr, getColumnIndex(spr,"DateInsert"), xRow)
     If  getColumnIndex(spr,"InchargeInsert") > -1 then z9970.InchargeInsert = getDataM(spr, getColumnIndex(spr,"InchargeInsert"), xRow)
     If  getColumnIndex(spr,"DateUpdate") > -1 then z9970.DateUpdate = getDataM(spr, getColumnIndex(spr,"DateUpdate"), xRow)
     If  getColumnIndex(spr,"InchargeUpdate") > -1 then z9970.InchargeUpdate = getDataM(spr, getColumnIndex(spr,"InchargeUpdate"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K9970_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K9970_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9970 As T9970_AREA,CheckClear as Boolean,CDSITE AS String, PROGRAMNAME AS String) as Boolean

K9970_MOVE = False

Try
    If READ_PFK9970(CDSITE, PROGRAMNAME) = True Then
                z9970 = D9970
		K9970_MOVE = True
		else
	If CheckClear  = True then z9970 = nothing
     End If

     If  getColumnIndex(spr,"cdSite") > -1 then z9970.cdSite = getDataM(spr, getColumnIndex(spr,"cdSite"), xRow)
     If  getColumnIndex(spr,"ProgramName") > -1 then z9970.ProgramName = getDataM(spr, getColumnIndex(spr,"ProgramName"), xRow)
     If  getColumnIndex(spr,"seSite") > -1 then z9970.seSite = getDataM(spr, getColumnIndex(spr,"seSite"), xRow)
     If  getColumnIndex(spr,"CheckType") > -1 then z9970.CheckType = getDataM(spr, getColumnIndex(spr,"CheckType"), xRow)
     If  getColumnIndex(spr,"TemplateNo") > -1 then z9970.TemplateNo = getDataM(spr, getColumnIndex(spr,"TemplateNo"), xRow)
     If  getColumnIndex(spr,"ProgramFix") > -1 then z9970.ProgramFix = getDataM(spr, getColumnIndex(spr,"ProgramFix"), xRow)
     If  getColumnIndex(spr,"cntTab") > -1 then z9970.cntTab = getDataM(spr, getColumnIndex(spr,"cntTab"), xRow)
     If  getColumnIndex(spr,"TagName1") > -1 then z9970.TagName1 = getDataM(spr, getColumnIndex(spr,"TagName1"), xRow)
     If  getColumnIndex(spr,"TagName2") > -1 then z9970.TagName2 = getDataM(spr, getColumnIndex(spr,"TagName2"), xRow)
     If  getColumnIndex(spr,"TagName3") > -1 then z9970.TagName3 = getDataM(spr, getColumnIndex(spr,"TagName3"), xRow)
     If  getColumnIndex(spr,"SheetName10") > -1 then z9970.SheetName10 = getDataM(spr, getColumnIndex(spr,"SheetName10"), xRow)
     If  getColumnIndex(spr,"SheetName11") > -1 then z9970.SheetName11 = getDataM(spr, getColumnIndex(spr,"SheetName11"), xRow)
     If  getColumnIndex(spr,"SheetName12") > -1 then z9970.SheetName12 = getDataM(spr, getColumnIndex(spr,"SheetName12"), xRow)
     If  getColumnIndex(spr,"SheetName20") > -1 then z9970.SheetName20 = getDataM(spr, getColumnIndex(spr,"SheetName20"), xRow)
     If  getColumnIndex(spr,"SheetName21") > -1 then z9970.SheetName21 = getDataM(spr, getColumnIndex(spr,"SheetName21"), xRow)
     If  getColumnIndex(spr,"SheetName22") > -1 then z9970.SheetName22 = getDataM(spr, getColumnIndex(spr,"SheetName22"), xRow)
     If  getColumnIndex(spr,"SheetName30") > -1 then z9970.SheetName30 = getDataM(spr, getColumnIndex(spr,"SheetName30"), xRow)
     If  getColumnIndex(spr,"SheetName31") > -1 then z9970.SheetName31 = getDataM(spr, getColumnIndex(spr,"SheetName31"), xRow)
     If  getColumnIndex(spr,"SheetName32") > -1 then z9970.SheetName32 = getDataM(spr, getColumnIndex(spr,"SheetName32"), xRow)
     If  getColumnIndex(spr,"Parameter01") > -1 then z9970.Parameter01 = getDataM(spr, getColumnIndex(spr,"Parameter01"), xRow)
     If  getColumnIndex(spr,"Parameter02") > -1 then z9970.Parameter02 = getDataM(spr, getColumnIndex(spr,"Parameter02"), xRow)
     If  getColumnIndex(spr,"Parameter03") > -1 then z9970.Parameter03 = getDataM(spr, getColumnIndex(spr,"Parameter03"), xRow)
     If  getColumnIndex(spr,"Parameter04") > -1 then z9970.Parameter04 = getDataM(spr, getColumnIndex(spr,"Parameter04"), xRow)
     If  getColumnIndex(spr,"Parameter05") > -1 then z9970.Parameter05 = getDataM(spr, getColumnIndex(spr,"Parameter05"), xRow)
     If  getColumnIndex(spr,"Parameter06") > -1 then z9970.Parameter06 = getDataM(spr, getColumnIndex(spr,"Parameter06"), xRow)
     If  getColumnIndex(spr,"Parameter07") > -1 then z9970.Parameter07 = getDataM(spr, getColumnIndex(spr,"Parameter07"), xRow)
     If  getColumnIndex(spr,"Parameter08") > -1 then z9970.Parameter08 = getDataM(spr, getColumnIndex(spr,"Parameter08"), xRow)
     If  getColumnIndex(spr,"Parameter09") > -1 then z9970.Parameter09 = getDataM(spr, getColumnIndex(spr,"Parameter09"), xRow)
     If  getColumnIndex(spr,"Parameter10") > -1 then z9970.Parameter10 = getDataM(spr, getColumnIndex(spr,"Parameter10"), xRow)
     If  getColumnIndex(spr,"Parameter11") > -1 then z9970.Parameter11 = getDataM(spr, getColumnIndex(spr,"Parameter11"), xRow)
     If  getColumnIndex(spr,"Parameter12") > -1 then z9970.Parameter12 = getDataM(spr, getColumnIndex(spr,"Parameter12"), xRow)
     If  getColumnIndex(spr,"Parameter13") > -1 then z9970.Parameter13 = getDataM(spr, getColumnIndex(spr,"Parameter13"), xRow)
     If  getColumnIndex(spr,"Parameter14") > -1 then z9970.Parameter14 = getDataM(spr, getColumnIndex(spr,"Parameter14"), xRow)
     If  getColumnIndex(spr,"Parameter15") > -1 then z9970.Parameter15 = getDataM(spr, getColumnIndex(spr,"Parameter15"), xRow)
     If  getColumnIndex(spr,"Parameter16") > -1 then z9970.Parameter16 = getDataM(spr, getColumnIndex(spr,"Parameter16"), xRow)
     If  getColumnIndex(spr,"Parameter17") > -1 then z9970.Parameter17 = getDataM(spr, getColumnIndex(spr,"Parameter17"), xRow)
     If  getColumnIndex(spr,"Parameter18") > -1 then z9970.Parameter18 = getDataM(spr, getColumnIndex(spr,"Parameter18"), xRow)
     If  getColumnIndex(spr,"Parameter19") > -1 then z9970.Parameter19 = getDataM(spr, getColumnIndex(spr,"Parameter19"), xRow)
     If  getColumnIndex(spr,"Parameter20") > -1 then z9970.Parameter20 = getDataM(spr, getColumnIndex(spr,"Parameter20"), xRow)
     If  getColumnIndex(spr,"DateInsert") > -1 then z9970.DateInsert = getDataM(spr, getColumnIndex(spr,"DateInsert"), xRow)
     If  getColumnIndex(spr,"InchargeInsert") > -1 then z9970.InchargeInsert = getDataM(spr, getColumnIndex(spr,"InchargeInsert"), xRow)
     If  getColumnIndex(spr,"DateUpdate") > -1 then z9970.DateUpdate = getDataM(spr, getColumnIndex(spr,"DateUpdate"), xRow)
     If  getColumnIndex(spr,"InchargeUpdate") > -1 then z9970.InchargeUpdate = getDataM(spr, getColumnIndex(spr,"InchargeUpdate"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K9970_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K9970_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9970 As T9970_AREA, Job as String, CDSITE AS String, PROGRAMNAME AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9970_MOVE = False

Try
    If READ_PFK9970(CDSITE, PROGRAMNAME) = True Then
                z9970 = D9970
		K9970_MOVE = True
		else
	z9970 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9970")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "CDSITE":z9970.cdSite = Children(i).Code
   Case "PROGRAMNAME":z9970.ProgramName = Children(i).Code
   Case "SESITE":z9970.seSite = Children(i).Code
   Case "CHECKTYPE":z9970.CheckType = Children(i).Code
   Case "TEMPLATENO":z9970.TemplateNo = Children(i).Code
   Case "PROGRAMFIX":z9970.ProgramFix = Children(i).Code
   Case "CNTTAB":z9970.cntTab = Children(i).Code
   Case "TAGNAME1":z9970.TagName1 = Children(i).Code
   Case "TAGNAME2":z9970.TagName2 = Children(i).Code
   Case "TAGNAME3":z9970.TagName3 = Children(i).Code
   Case "SHEETNAME10":z9970.SheetName10 = Children(i).Code
   Case "SHEETNAME11":z9970.SheetName11 = Children(i).Code
   Case "SHEETNAME12":z9970.SheetName12 = Children(i).Code
   Case "SHEETNAME20":z9970.SheetName20 = Children(i).Code
   Case "SHEETNAME21":z9970.SheetName21 = Children(i).Code
   Case "SHEETNAME22":z9970.SheetName22 = Children(i).Code
   Case "SHEETNAME30":z9970.SheetName30 = Children(i).Code
   Case "SHEETNAME31":z9970.SheetName31 = Children(i).Code
   Case "SHEETNAME32":z9970.SheetName32 = Children(i).Code
   Case "PARAMETER01":z9970.Parameter01 = Children(i).Code
   Case "PARAMETER02":z9970.Parameter02 = Children(i).Code
   Case "PARAMETER03":z9970.Parameter03 = Children(i).Code
   Case "PARAMETER04":z9970.Parameter04 = Children(i).Code
   Case "PARAMETER05":z9970.Parameter05 = Children(i).Code
   Case "PARAMETER06":z9970.Parameter06 = Children(i).Code
   Case "PARAMETER07":z9970.Parameter07 = Children(i).Code
   Case "PARAMETER08":z9970.Parameter08 = Children(i).Code
   Case "PARAMETER09":z9970.Parameter09 = Children(i).Code
   Case "PARAMETER10":z9970.Parameter10 = Children(i).Code
   Case "PARAMETER11":z9970.Parameter11 = Children(i).Code
   Case "PARAMETER12":z9970.Parameter12 = Children(i).Code
   Case "PARAMETER13":z9970.Parameter13 = Children(i).Code
   Case "PARAMETER14":z9970.Parameter14 = Children(i).Code
   Case "PARAMETER15":z9970.Parameter15 = Children(i).Code
   Case "PARAMETER16":z9970.Parameter16 = Children(i).Code
   Case "PARAMETER17":z9970.Parameter17 = Children(i).Code
   Case "PARAMETER18":z9970.Parameter18 = Children(i).Code
   Case "PARAMETER19":z9970.Parameter19 = Children(i).Code
   Case "PARAMETER20":z9970.Parameter20 = Children(i).Code
   Case "DATEINSERT":z9970.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z9970.InchargeInsert = Children(i).Code
   Case "DATEUPDATE":z9970.DateUpdate = Children(i).Code
   Case "INCHARGEUPDATE":z9970.InchargeUpdate = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "CDSITE":z9970.cdSite = Children(i).Data
   Case "PROGRAMNAME":z9970.ProgramName = Children(i).Data
   Case "SESITE":z9970.seSite = Children(i).Data
   Case "CHECKTYPE":z9970.CheckType = Children(i).Data
   Case "TEMPLATENO":z9970.TemplateNo = Children(i).Data
   Case "PROGRAMFIX":z9970.ProgramFix = Children(i).Data
   Case "CNTTAB":z9970.cntTab = Children(i).Data
   Case "TAGNAME1":z9970.TagName1 = Children(i).Data
   Case "TAGNAME2":z9970.TagName2 = Children(i).Data
   Case "TAGNAME3":z9970.TagName3 = Children(i).Data
   Case "SHEETNAME10":z9970.SheetName10 = Children(i).Data
   Case "SHEETNAME11":z9970.SheetName11 = Children(i).Data
   Case "SHEETNAME12":z9970.SheetName12 = Children(i).Data
   Case "SHEETNAME20":z9970.SheetName20 = Children(i).Data
   Case "SHEETNAME21":z9970.SheetName21 = Children(i).Data
   Case "SHEETNAME22":z9970.SheetName22 = Children(i).Data
   Case "SHEETNAME30":z9970.SheetName30 = Children(i).Data
   Case "SHEETNAME31":z9970.SheetName31 = Children(i).Data
   Case "SHEETNAME32":z9970.SheetName32 = Children(i).Data
   Case "PARAMETER01":z9970.Parameter01 = Children(i).Data
   Case "PARAMETER02":z9970.Parameter02 = Children(i).Data
   Case "PARAMETER03":z9970.Parameter03 = Children(i).Data
   Case "PARAMETER04":z9970.Parameter04 = Children(i).Data
   Case "PARAMETER05":z9970.Parameter05 = Children(i).Data
   Case "PARAMETER06":z9970.Parameter06 = Children(i).Data
   Case "PARAMETER07":z9970.Parameter07 = Children(i).Data
   Case "PARAMETER08":z9970.Parameter08 = Children(i).Data
   Case "PARAMETER09":z9970.Parameter09 = Children(i).Data
   Case "PARAMETER10":z9970.Parameter10 = Children(i).Data
   Case "PARAMETER11":z9970.Parameter11 = Children(i).Data
   Case "PARAMETER12":z9970.Parameter12 = Children(i).Data
   Case "PARAMETER13":z9970.Parameter13 = Children(i).Data
   Case "PARAMETER14":z9970.Parameter14 = Children(i).Data
   Case "PARAMETER15":z9970.Parameter15 = Children(i).Data
   Case "PARAMETER16":z9970.Parameter16 = Children(i).Data
   Case "PARAMETER17":z9970.Parameter17 = Children(i).Data
   Case "PARAMETER18":z9970.Parameter18 = Children(i).Data
   Case "PARAMETER19":z9970.Parameter19 = Children(i).Data
   Case "PARAMETER20":z9970.Parameter20 = Children(i).Data
   Case "DATEINSERT":z9970.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z9970.InchargeInsert = Children(i).Data
   Case "DATEUPDATE":z9970.DateUpdate = Children(i).Data
   Case "INCHARGEUPDATE":z9970.InchargeUpdate = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K9970_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K9970_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9970 As T9970_AREA, Job as String, CheckClear as Boolean, CDSITE AS String, PROGRAMNAME AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9970_MOVE = False

Try
    If READ_PFK9970(CDSITE, PROGRAMNAME) = True Then
                z9970 = D9970
		K9970_MOVE = True
		else
	If CheckClear  = True then z9970 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9970")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "CDSITE":z9970.cdSite = Children(i).Code
   Case "PROGRAMNAME":z9970.ProgramName = Children(i).Code
   Case "SESITE":z9970.seSite = Children(i).Code
   Case "CHECKTYPE":z9970.CheckType = Children(i).Code
   Case "TEMPLATENO":z9970.TemplateNo = Children(i).Code
   Case "PROGRAMFIX":z9970.ProgramFix = Children(i).Code
   Case "CNTTAB":z9970.cntTab = Children(i).Code
   Case "TAGNAME1":z9970.TagName1 = Children(i).Code
   Case "TAGNAME2":z9970.TagName2 = Children(i).Code
   Case "TAGNAME3":z9970.TagName3 = Children(i).Code
   Case "SHEETNAME10":z9970.SheetName10 = Children(i).Code
   Case "SHEETNAME11":z9970.SheetName11 = Children(i).Code
   Case "SHEETNAME12":z9970.SheetName12 = Children(i).Code
   Case "SHEETNAME20":z9970.SheetName20 = Children(i).Code
   Case "SHEETNAME21":z9970.SheetName21 = Children(i).Code
   Case "SHEETNAME22":z9970.SheetName22 = Children(i).Code
   Case "SHEETNAME30":z9970.SheetName30 = Children(i).Code
   Case "SHEETNAME31":z9970.SheetName31 = Children(i).Code
   Case "SHEETNAME32":z9970.SheetName32 = Children(i).Code
   Case "PARAMETER01":z9970.Parameter01 = Children(i).Code
   Case "PARAMETER02":z9970.Parameter02 = Children(i).Code
   Case "PARAMETER03":z9970.Parameter03 = Children(i).Code
   Case "PARAMETER04":z9970.Parameter04 = Children(i).Code
   Case "PARAMETER05":z9970.Parameter05 = Children(i).Code
   Case "PARAMETER06":z9970.Parameter06 = Children(i).Code
   Case "PARAMETER07":z9970.Parameter07 = Children(i).Code
   Case "PARAMETER08":z9970.Parameter08 = Children(i).Code
   Case "PARAMETER09":z9970.Parameter09 = Children(i).Code
   Case "PARAMETER10":z9970.Parameter10 = Children(i).Code
   Case "PARAMETER11":z9970.Parameter11 = Children(i).Code
   Case "PARAMETER12":z9970.Parameter12 = Children(i).Code
   Case "PARAMETER13":z9970.Parameter13 = Children(i).Code
   Case "PARAMETER14":z9970.Parameter14 = Children(i).Code
   Case "PARAMETER15":z9970.Parameter15 = Children(i).Code
   Case "PARAMETER16":z9970.Parameter16 = Children(i).Code
   Case "PARAMETER17":z9970.Parameter17 = Children(i).Code
   Case "PARAMETER18":z9970.Parameter18 = Children(i).Code
   Case "PARAMETER19":z9970.Parameter19 = Children(i).Code
   Case "PARAMETER20":z9970.Parameter20 = Children(i).Code
   Case "DATEINSERT":z9970.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z9970.InchargeInsert = Children(i).Code
   Case "DATEUPDATE":z9970.DateUpdate = Children(i).Code
   Case "INCHARGEUPDATE":z9970.InchargeUpdate = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "CDSITE":z9970.cdSite = Children(i).Data
   Case "PROGRAMNAME":z9970.ProgramName = Children(i).Data
   Case "SESITE":z9970.seSite = Children(i).Data
   Case "CHECKTYPE":z9970.CheckType = Children(i).Data
   Case "TEMPLATENO":z9970.TemplateNo = Children(i).Data
   Case "PROGRAMFIX":z9970.ProgramFix = Children(i).Data
   Case "CNTTAB":z9970.cntTab = Children(i).Data
   Case "TAGNAME1":z9970.TagName1 = Children(i).Data
   Case "TAGNAME2":z9970.TagName2 = Children(i).Data
   Case "TAGNAME3":z9970.TagName3 = Children(i).Data
   Case "SHEETNAME10":z9970.SheetName10 = Children(i).Data
   Case "SHEETNAME11":z9970.SheetName11 = Children(i).Data
   Case "SHEETNAME12":z9970.SheetName12 = Children(i).Data
   Case "SHEETNAME20":z9970.SheetName20 = Children(i).Data
   Case "SHEETNAME21":z9970.SheetName21 = Children(i).Data
   Case "SHEETNAME22":z9970.SheetName22 = Children(i).Data
   Case "SHEETNAME30":z9970.SheetName30 = Children(i).Data
   Case "SHEETNAME31":z9970.SheetName31 = Children(i).Data
   Case "SHEETNAME32":z9970.SheetName32 = Children(i).Data
   Case "PARAMETER01":z9970.Parameter01 = Children(i).Data
   Case "PARAMETER02":z9970.Parameter02 = Children(i).Data
   Case "PARAMETER03":z9970.Parameter03 = Children(i).Data
   Case "PARAMETER04":z9970.Parameter04 = Children(i).Data
   Case "PARAMETER05":z9970.Parameter05 = Children(i).Data
   Case "PARAMETER06":z9970.Parameter06 = Children(i).Data
   Case "PARAMETER07":z9970.Parameter07 = Children(i).Data
   Case "PARAMETER08":z9970.Parameter08 = Children(i).Data
   Case "PARAMETER09":z9970.Parameter09 = Children(i).Data
   Case "PARAMETER10":z9970.Parameter10 = Children(i).Data
   Case "PARAMETER11":z9970.Parameter11 = Children(i).Data
   Case "PARAMETER12":z9970.Parameter12 = Children(i).Data
   Case "PARAMETER13":z9970.Parameter13 = Children(i).Data
   Case "PARAMETER14":z9970.Parameter14 = Children(i).Data
   Case "PARAMETER15":z9970.Parameter15 = Children(i).Data
   Case "PARAMETER16":z9970.Parameter16 = Children(i).Data
   Case "PARAMETER17":z9970.Parameter17 = Children(i).Data
   Case "PARAMETER18":z9970.Parameter18 = Children(i).Data
   Case "PARAMETER19":z9970.Parameter19 = Children(i).Data
   Case "PARAMETER20":z9970.Parameter20 = Children(i).Data
   Case "DATEINSERT":z9970.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z9970.InchargeInsert = Children(i).Data
   Case "DATEUPDATE":z9970.DateUpdate = Children(i).Data
   Case "INCHARGEUPDATE":z9970.InchargeUpdate = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K9970_MOVE",vbCritical)
End Try
End Function 
    

'=========================================================================================================================================================
' DATA MOVE FORM NEW AREA
'=========================================================================================================================================================
Public Sub K9970_MOVE(ByRef a9970 As T9970_AREA, ByRef b9970 As T9970_AREA) 
Try
If trim$( a9970.cdSite ) = "" Then b9970.cdSite = ""  Else b9970.cdSite=a9970.cdSite
If trim$( a9970.ProgramName ) = "" Then b9970.ProgramName = ""  Else b9970.ProgramName=a9970.ProgramName
If trim$( a9970.seSite ) = "" Then b9970.seSite = ""  Else b9970.seSite=a9970.seSite
If trim$( a9970.CheckType ) = "" Then b9970.CheckType = ""  Else b9970.CheckType=a9970.CheckType
If trim$( a9970.TemplateNo ) = "" Then b9970.TemplateNo = ""  Else b9970.TemplateNo=a9970.TemplateNo
If trim$( a9970.ProgramFix ) = "" Then b9970.ProgramFix = ""  Else b9970.ProgramFix=a9970.ProgramFix
If trim$( a9970.cntTab ) = "" Then b9970.cntTab = ""  Else b9970.cntTab=a9970.cntTab
If trim$( a9970.TagName1 ) = "" Then b9970.TagName1 = ""  Else b9970.TagName1=a9970.TagName1
If trim$( a9970.TagName2 ) = "" Then b9970.TagName2 = ""  Else b9970.TagName2=a9970.TagName2
If trim$( a9970.TagName3 ) = "" Then b9970.TagName3 = ""  Else b9970.TagName3=a9970.TagName3
If trim$( a9970.SheetName10 ) = "" Then b9970.SheetName10 = ""  Else b9970.SheetName10=a9970.SheetName10
If trim$( a9970.SheetName11 ) = "" Then b9970.SheetName11 = ""  Else b9970.SheetName11=a9970.SheetName11
If trim$( a9970.SheetName12 ) = "" Then b9970.SheetName12 = ""  Else b9970.SheetName12=a9970.SheetName12
If trim$( a9970.SheetName20 ) = "" Then b9970.SheetName20 = ""  Else b9970.SheetName20=a9970.SheetName20
If trim$( a9970.SheetName21 ) = "" Then b9970.SheetName21 = ""  Else b9970.SheetName21=a9970.SheetName21
If trim$( a9970.SheetName22 ) = "" Then b9970.SheetName22 = ""  Else b9970.SheetName22=a9970.SheetName22
If trim$( a9970.SheetName30 ) = "" Then b9970.SheetName30 = ""  Else b9970.SheetName30=a9970.SheetName30
If trim$( a9970.SheetName31 ) = "" Then b9970.SheetName31 = ""  Else b9970.SheetName31=a9970.SheetName31
If trim$( a9970.SheetName32 ) = "" Then b9970.SheetName32 = ""  Else b9970.SheetName32=a9970.SheetName32
If trim$( a9970.Parameter01 ) = "" Then b9970.Parameter01 = ""  Else b9970.Parameter01=a9970.Parameter01
If trim$( a9970.Parameter02 ) = "" Then b9970.Parameter02 = ""  Else b9970.Parameter02=a9970.Parameter02
If trim$( a9970.Parameter03 ) = "" Then b9970.Parameter03 = ""  Else b9970.Parameter03=a9970.Parameter03
If trim$( a9970.Parameter04 ) = "" Then b9970.Parameter04 = ""  Else b9970.Parameter04=a9970.Parameter04
If trim$( a9970.Parameter05 ) = "" Then b9970.Parameter05 = ""  Else b9970.Parameter05=a9970.Parameter05
If trim$( a9970.Parameter06 ) = "" Then b9970.Parameter06 = ""  Else b9970.Parameter06=a9970.Parameter06
If trim$( a9970.Parameter07 ) = "" Then b9970.Parameter07 = ""  Else b9970.Parameter07=a9970.Parameter07
If trim$( a9970.Parameter08 ) = "" Then b9970.Parameter08 = ""  Else b9970.Parameter08=a9970.Parameter08
If trim$( a9970.Parameter09 ) = "" Then b9970.Parameter09 = ""  Else b9970.Parameter09=a9970.Parameter09
If trim$( a9970.Parameter10 ) = "" Then b9970.Parameter10 = ""  Else b9970.Parameter10=a9970.Parameter10
If trim$( a9970.Parameter11 ) = "" Then b9970.Parameter11 = ""  Else b9970.Parameter11=a9970.Parameter11
If trim$( a9970.Parameter12 ) = "" Then b9970.Parameter12 = ""  Else b9970.Parameter12=a9970.Parameter12
If trim$( a9970.Parameter13 ) = "" Then b9970.Parameter13 = ""  Else b9970.Parameter13=a9970.Parameter13
If trim$( a9970.Parameter14 ) = "" Then b9970.Parameter14 = ""  Else b9970.Parameter14=a9970.Parameter14
If trim$( a9970.Parameter15 ) = "" Then b9970.Parameter15 = ""  Else b9970.Parameter15=a9970.Parameter15
If trim$( a9970.Parameter16 ) = "" Then b9970.Parameter16 = ""  Else b9970.Parameter16=a9970.Parameter16
If trim$( a9970.Parameter17 ) = "" Then b9970.Parameter17 = ""  Else b9970.Parameter17=a9970.Parameter17
If trim$( a9970.Parameter18 ) = "" Then b9970.Parameter18 = ""  Else b9970.Parameter18=a9970.Parameter18
If trim$( a9970.Parameter19 ) = "" Then b9970.Parameter19 = ""  Else b9970.Parameter19=a9970.Parameter19
If trim$( a9970.Parameter20 ) = "" Then b9970.Parameter20 = ""  Else b9970.Parameter20=a9970.Parameter20
If trim$( a9970.DateInsert ) = "" Then b9970.DateInsert = ""  Else b9970.DateInsert=a9970.DateInsert
If trim$( a9970.InchargeInsert ) = "" Then b9970.InchargeInsert = ""  Else b9970.InchargeInsert=a9970.InchargeInsert
If trim$( a9970.DateUpdate ) = "" Then b9970.DateUpdate = ""  Else b9970.DateUpdate=a9970.DateUpdate
If trim$( a9970.InchargeUpdate ) = "" Then b9970.InchargeUpdate = ""  Else b9970.InchargeUpdate=a9970.InchargeUpdate
Catch ex As Exception
      Call MsgBoxP("K9970_MOVE",vbCritical)
End Try
End Sub 


End Module 
