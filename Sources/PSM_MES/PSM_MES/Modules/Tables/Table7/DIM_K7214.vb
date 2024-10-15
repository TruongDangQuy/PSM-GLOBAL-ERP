'=========================================================================================================================================================
'   TABLE : (PFK7214)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7214

Structure T7214_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	Autokey	 AS Double	'			decimal		*
Public 	Article	 AS String	'			nvarchar(50)
Public 	CustomerCode	 AS String	'			char(6)
Public 	seSeason	 AS String	'			char(3)
Public 	cdSeason	 AS String	'			char(3)
Public 	SizeWeight01	 AS Double	'			decimal
Public 	SizeWeight02	 AS Double	'			decimal
Public 	SizeWeight03	 AS Double	'			decimal
Public 	SizeWeight04	 AS Double	'			decimal
Public 	SizeWeight05	 AS Double	'			decimal
Public 	SizeWeight06	 AS Double	'			decimal
Public 	SizeWeight07	 AS Double	'			decimal
Public 	SizeWeight08	 AS Double	'			decimal
Public 	SizeWeight09	 AS Double	'			decimal
Public 	SizeWeight10	 AS Double	'			decimal
Public 	SizeWeight11	 AS Double	'			decimal
Public 	SizeWeight12	 AS Double	'			decimal
Public 	SizeWeight13	 AS Double	'			decimal
Public 	SizeWeight14	 AS Double	'			decimal
Public 	SizeWeight15	 AS Double	'			decimal
Public 	SizeWeight16	 AS Double	'			decimal
Public 	SizeWeight17	 AS Double	'			decimal
Public 	SizeWeight18	 AS Double	'			decimal
Public 	SizeWeight19	 AS Double	'			decimal
Public 	SizeWeight20	 AS Double	'			decimal
Public 	SizeWeight21	 AS Double	'			decimal
Public 	SizeWeight22	 AS Double	'			decimal
Public 	SizeWeight23	 AS Double	'			decimal
Public 	SizeWeight24	 AS Double	'			decimal
Public 	SizeWeight25	 AS Double	'			decimal
Public 	SizeWeight26	 AS Double	'			decimal
Public 	SizeWeight27	 AS Double	'			decimal
Public 	SizeWeight28	 AS Double	'			decimal
Public 	SizeWeight29	 AS Double	'			decimal
Public 	SizeWeight30	 AS Double	'			decimal
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	CheckUse	 AS String	'			char(1)
Public 	CheckComplete	 AS String	'			char(1)
Public 	Remark	 AS String	'			nvarchar(50)
'=========================================================================================================================================================
End structure

Public D7214 As T7214_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7214(AUTOKEY AS Double) As Boolean
    READ_PFK7214 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7214 "
    SQL = SQL & " WHERE K7214_Autokey		 =  " & Autokey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7214_CLEAR: GoTo SKIP_READ_PFK7214
                
    Call K7214_MOVE(rd)
    READ_PFK7214 = True

SKIP_READ_PFK7214:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7214",vbCritical)
 End Try
    End Function

   
'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7214(AUTOKEY AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7214 "
            SQL = SQL & " WHERE K7214_Autokey		 =  " & AUTOKEY & "  "
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7214",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7214(z7214 As T7214_AREA) As Boolean
    WRITE_PFK7214 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7214)
 
    SQL = " INSERT INTO PFK7214 "
    SQL = SQL & " ( "
    SQL = SQL & " K7214_Article," 
    SQL = SQL & " K7214_CustomerCode," 
    SQL = SQL & " K7214_seSeason," 
    SQL = SQL & " K7214_cdSeason," 
    SQL = SQL & " K7214_SizeWeight01," 
    SQL = SQL & " K7214_SizeWeight02," 
    SQL = SQL & " K7214_SizeWeight03," 
    SQL = SQL & " K7214_SizeWeight04," 
    SQL = SQL & " K7214_SizeWeight05," 
    SQL = SQL & " K7214_SizeWeight06," 
    SQL = SQL & " K7214_SizeWeight07," 
    SQL = SQL & " K7214_SizeWeight08," 
    SQL = SQL & " K7214_SizeWeight09," 
    SQL = SQL & " K7214_SizeWeight10," 
    SQL = SQL & " K7214_SizeWeight11," 
    SQL = SQL & " K7214_SizeWeight12," 
    SQL = SQL & " K7214_SizeWeight13," 
    SQL = SQL & " K7214_SizeWeight14," 
    SQL = SQL & " K7214_SizeWeight15," 
    SQL = SQL & " K7214_SizeWeight16," 
    SQL = SQL & " K7214_SizeWeight17," 
    SQL = SQL & " K7214_SizeWeight18," 
    SQL = SQL & " K7214_SizeWeight19," 
    SQL = SQL & " K7214_SizeWeight20," 
    SQL = SQL & " K7214_SizeWeight21," 
    SQL = SQL & " K7214_SizeWeight22," 
    SQL = SQL & " K7214_SizeWeight23," 
    SQL = SQL & " K7214_SizeWeight24," 
    SQL = SQL & " K7214_SizeWeight25," 
    SQL = SQL & " K7214_SizeWeight26," 
    SQL = SQL & " K7214_SizeWeight27," 
    SQL = SQL & " K7214_SizeWeight28," 
    SQL = SQL & " K7214_SizeWeight29," 
    SQL = SQL & " K7214_SizeWeight30," 
    SQL = SQL & " K7214_DateInsert," 
    SQL = SQL & " K7214_DateUpdate," 
    SQL = SQL & " K7214_InchargeInsert," 
    SQL = SQL & " K7214_InchargeUpdate," 
    SQL = SQL & " K7214_CheckUse," 
    SQL = SQL & " K7214_CheckComplete," 
    SQL = SQL & " K7214_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7214.Article) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7214.CustomerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7214.seSeason) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7214.cdSeason) & "', "  
    SQL = SQL & "   " & FormatSQL(z7214.SizeWeight01) & ", "  
    SQL = SQL & "   " & FormatSQL(z7214.SizeWeight02) & ", "  
    SQL = SQL & "   " & FormatSQL(z7214.SizeWeight03) & ", "  
    SQL = SQL & "   " & FormatSQL(z7214.SizeWeight04) & ", "  
    SQL = SQL & "   " & FormatSQL(z7214.SizeWeight05) & ", "  
    SQL = SQL & "   " & FormatSQL(z7214.SizeWeight06) & ", "  
    SQL = SQL & "   " & FormatSQL(z7214.SizeWeight07) & ", "  
    SQL = SQL & "   " & FormatSQL(z7214.SizeWeight08) & ", "  
    SQL = SQL & "   " & FormatSQL(z7214.SizeWeight09) & ", "  
    SQL = SQL & "   " & FormatSQL(z7214.SizeWeight10) & ", "  
    SQL = SQL & "   " & FormatSQL(z7214.SizeWeight11) & ", "  
    SQL = SQL & "   " & FormatSQL(z7214.SizeWeight12) & ", "  
    SQL = SQL & "   " & FormatSQL(z7214.SizeWeight13) & ", "  
    SQL = SQL & "   " & FormatSQL(z7214.SizeWeight14) & ", "  
    SQL = SQL & "   " & FormatSQL(z7214.SizeWeight15) & ", "  
    SQL = SQL & "   " & FormatSQL(z7214.SizeWeight16) & ", "  
    SQL = SQL & "   " & FormatSQL(z7214.SizeWeight17) & ", "  
    SQL = SQL & "   " & FormatSQL(z7214.SizeWeight18) & ", "  
    SQL = SQL & "   " & FormatSQL(z7214.SizeWeight19) & ", "  
    SQL = SQL & "   " & FormatSQL(z7214.SizeWeight20) & ", "  
    SQL = SQL & "   " & FormatSQL(z7214.SizeWeight21) & ", "  
    SQL = SQL & "   " & FormatSQL(z7214.SizeWeight22) & ", "  
    SQL = SQL & "   " & FormatSQL(z7214.SizeWeight23) & ", "  
    SQL = SQL & "   " & FormatSQL(z7214.SizeWeight24) & ", "  
    SQL = SQL & "   " & FormatSQL(z7214.SizeWeight25) & ", "  
    SQL = SQL & "   " & FormatSQL(z7214.SizeWeight26) & ", "  
    SQL = SQL & "   " & FormatSQL(z7214.SizeWeight27) & ", "  
    SQL = SQL & "   " & FormatSQL(z7214.SizeWeight28) & ", "  
    SQL = SQL & "   " & FormatSQL(z7214.SizeWeight29) & ", "  
    SQL = SQL & "   " & FormatSQL(z7214.SizeWeight30) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7214.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7214.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7214.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7214.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7214.CheckUse) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7214.CheckComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7214.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7214 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7214",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7214(z7214 As T7214_AREA) As Boolean
    REWRITE_PFK7214 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7214)
   
    SQL = " UPDATE PFK7214 SET "
    SQL = SQL & "    K7214_Article      = N'" & FormatSQL(z7214.Article) & "', " 
    SQL = SQL & "    K7214_CustomerCode      = N'" & FormatSQL(z7214.CustomerCode) & "', " 
    SQL = SQL & "    K7214_seSeason      = N'" & FormatSQL(z7214.seSeason) & "', " 
    SQL = SQL & "    K7214_cdSeason      = N'" & FormatSQL(z7214.cdSeason) & "', " 
    SQL = SQL & "    K7214_SizeWeight01      =  " & FormatSQL(z7214.SizeWeight01) & ", " 
    SQL = SQL & "    K7214_SizeWeight02      =  " & FormatSQL(z7214.SizeWeight02) & ", " 
    SQL = SQL & "    K7214_SizeWeight03      =  " & FormatSQL(z7214.SizeWeight03) & ", " 
    SQL = SQL & "    K7214_SizeWeight04      =  " & FormatSQL(z7214.SizeWeight04) & ", " 
    SQL = SQL & "    K7214_SizeWeight05      =  " & FormatSQL(z7214.SizeWeight05) & ", " 
    SQL = SQL & "    K7214_SizeWeight06      =  " & FormatSQL(z7214.SizeWeight06) & ", " 
    SQL = SQL & "    K7214_SizeWeight07      =  " & FormatSQL(z7214.SizeWeight07) & ", " 
    SQL = SQL & "    K7214_SizeWeight08      =  " & FormatSQL(z7214.SizeWeight08) & ", " 
    SQL = SQL & "    K7214_SizeWeight09      =  " & FormatSQL(z7214.SizeWeight09) & ", " 
    SQL = SQL & "    K7214_SizeWeight10      =  " & FormatSQL(z7214.SizeWeight10) & ", " 
    SQL = SQL & "    K7214_SizeWeight11      =  " & FormatSQL(z7214.SizeWeight11) & ", " 
    SQL = SQL & "    K7214_SizeWeight12      =  " & FormatSQL(z7214.SizeWeight12) & ", " 
    SQL = SQL & "    K7214_SizeWeight13      =  " & FormatSQL(z7214.SizeWeight13) & ", " 
    SQL = SQL & "    K7214_SizeWeight14      =  " & FormatSQL(z7214.SizeWeight14) & ", " 
    SQL = SQL & "    K7214_SizeWeight15      =  " & FormatSQL(z7214.SizeWeight15) & ", " 
    SQL = SQL & "    K7214_SizeWeight16      =  " & FormatSQL(z7214.SizeWeight16) & ", " 
    SQL = SQL & "    K7214_SizeWeight17      =  " & FormatSQL(z7214.SizeWeight17) & ", " 
    SQL = SQL & "    K7214_SizeWeight18      =  " & FormatSQL(z7214.SizeWeight18) & ", " 
    SQL = SQL & "    K7214_SizeWeight19      =  " & FormatSQL(z7214.SizeWeight19) & ", " 
    SQL = SQL & "    K7214_SizeWeight20      =  " & FormatSQL(z7214.SizeWeight20) & ", " 
    SQL = SQL & "    K7214_SizeWeight21      =  " & FormatSQL(z7214.SizeWeight21) & ", " 
    SQL = SQL & "    K7214_SizeWeight22      =  " & FormatSQL(z7214.SizeWeight22) & ", " 
    SQL = SQL & "    K7214_SizeWeight23      =  " & FormatSQL(z7214.SizeWeight23) & ", " 
    SQL = SQL & "    K7214_SizeWeight24      =  " & FormatSQL(z7214.SizeWeight24) & ", " 
    SQL = SQL & "    K7214_SizeWeight25      =  " & FormatSQL(z7214.SizeWeight25) & ", " 
    SQL = SQL & "    K7214_SizeWeight26      =  " & FormatSQL(z7214.SizeWeight26) & ", " 
    SQL = SQL & "    K7214_SizeWeight27      =  " & FormatSQL(z7214.SizeWeight27) & ", " 
    SQL = SQL & "    K7214_SizeWeight28      =  " & FormatSQL(z7214.SizeWeight28) & ", " 
    SQL = SQL & "    K7214_SizeWeight29      =  " & FormatSQL(z7214.SizeWeight29) & ", " 
    SQL = SQL & "    K7214_SizeWeight30      =  " & FormatSQL(z7214.SizeWeight30) & ", " 
    SQL = SQL & "    K7214_DateInsert      = N'" & FormatSQL(z7214.DateInsert) & "', " 
    SQL = SQL & "    K7214_DateUpdate      = N'" & FormatSQL(z7214.DateUpdate) & "', " 
    SQL = SQL & "    K7214_InchargeInsert      = N'" & FormatSQL(z7214.InchargeInsert) & "', " 
    SQL = SQL & "    K7214_InchargeUpdate      = N'" & FormatSQL(z7214.InchargeUpdate) & "', " 
    SQL = SQL & "    K7214_CheckUse      = N'" & FormatSQL(z7214.CheckUse) & "', " 
    SQL = SQL & "    K7214_CheckComplete      = N'" & FormatSQL(z7214.CheckComplete) & "', " 
    SQL = SQL & "    K7214_Remark      = N'" & FormatSQL(z7214.Remark) & "'  " 
    SQL = SQL & " WHERE K7214_Autokey		 =  " & z7214.Autokey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7214 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7214",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7214(z7214 As T7214_AREA) As Boolean
    DELETE_PFK7214 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7214 "
    SQL = SQL & " WHERE K7214_Autokey		 =  " & z7214.Autokey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7214 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7214",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7214_CLEAR()
Try
    
    D7214.Autokey = 0 
   D7214.Article = ""
   D7214.CustomerCode = ""
   D7214.seSeason = ""
   D7214.cdSeason = ""
    D7214.SizeWeight01 = 0 
    D7214.SizeWeight02 = 0 
    D7214.SizeWeight03 = 0 
    D7214.SizeWeight04 = 0 
    D7214.SizeWeight05 = 0 
    D7214.SizeWeight06 = 0 
    D7214.SizeWeight07 = 0 
    D7214.SizeWeight08 = 0 
    D7214.SizeWeight09 = 0 
    D7214.SizeWeight10 = 0 
    D7214.SizeWeight11 = 0 
    D7214.SizeWeight12 = 0 
    D7214.SizeWeight13 = 0 
    D7214.SizeWeight14 = 0 
    D7214.SizeWeight15 = 0 
    D7214.SizeWeight16 = 0 
    D7214.SizeWeight17 = 0 
    D7214.SizeWeight18 = 0 
    D7214.SizeWeight19 = 0 
    D7214.SizeWeight20 = 0 
    D7214.SizeWeight21 = 0 
    D7214.SizeWeight22 = 0 
    D7214.SizeWeight23 = 0 
    D7214.SizeWeight24 = 0 
    D7214.SizeWeight25 = 0 
    D7214.SizeWeight26 = 0 
    D7214.SizeWeight27 = 0 
    D7214.SizeWeight28 = 0 
    D7214.SizeWeight29 = 0 
    D7214.SizeWeight30 = 0 
   D7214.DateInsert = ""
   D7214.DateUpdate = ""
   D7214.InchargeInsert = ""
   D7214.InchargeUpdate = ""
   D7214.CheckUse = ""
   D7214.CheckComplete = ""
   D7214.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7214_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7214 As T7214_AREA)
Try
    
    x7214.Autokey = trim$(  x7214.Autokey)
    x7214.Article = trim$(  x7214.Article)
    x7214.CustomerCode = trim$(  x7214.CustomerCode)
    x7214.seSeason = trim$(  x7214.seSeason)
    x7214.cdSeason = trim$(  x7214.cdSeason)
    x7214.SizeWeight01 = trim$(  x7214.SizeWeight01)
    x7214.SizeWeight02 = trim$(  x7214.SizeWeight02)
    x7214.SizeWeight03 = trim$(  x7214.SizeWeight03)
    x7214.SizeWeight04 = trim$(  x7214.SizeWeight04)
    x7214.SizeWeight05 = trim$(  x7214.SizeWeight05)
    x7214.SizeWeight06 = trim$(  x7214.SizeWeight06)
    x7214.SizeWeight07 = trim$(  x7214.SizeWeight07)
    x7214.SizeWeight08 = trim$(  x7214.SizeWeight08)
    x7214.SizeWeight09 = trim$(  x7214.SizeWeight09)
    x7214.SizeWeight10 = trim$(  x7214.SizeWeight10)
    x7214.SizeWeight11 = trim$(  x7214.SizeWeight11)
    x7214.SizeWeight12 = trim$(  x7214.SizeWeight12)
    x7214.SizeWeight13 = trim$(  x7214.SizeWeight13)
    x7214.SizeWeight14 = trim$(  x7214.SizeWeight14)
    x7214.SizeWeight15 = trim$(  x7214.SizeWeight15)
    x7214.SizeWeight16 = trim$(  x7214.SizeWeight16)
    x7214.SizeWeight17 = trim$(  x7214.SizeWeight17)
    x7214.SizeWeight18 = trim$(  x7214.SizeWeight18)
    x7214.SizeWeight19 = trim$(  x7214.SizeWeight19)
    x7214.SizeWeight20 = trim$(  x7214.SizeWeight20)
    x7214.SizeWeight21 = trim$(  x7214.SizeWeight21)
    x7214.SizeWeight22 = trim$(  x7214.SizeWeight22)
    x7214.SizeWeight23 = trim$(  x7214.SizeWeight23)
    x7214.SizeWeight24 = trim$(  x7214.SizeWeight24)
    x7214.SizeWeight25 = trim$(  x7214.SizeWeight25)
    x7214.SizeWeight26 = trim$(  x7214.SizeWeight26)
    x7214.SizeWeight27 = trim$(  x7214.SizeWeight27)
    x7214.SizeWeight28 = trim$(  x7214.SizeWeight28)
    x7214.SizeWeight29 = trim$(  x7214.SizeWeight29)
    x7214.SizeWeight30 = trim$(  x7214.SizeWeight30)
    x7214.DateInsert = trim$(  x7214.DateInsert)
    x7214.DateUpdate = trim$(  x7214.DateUpdate)
    x7214.InchargeInsert = trim$(  x7214.InchargeInsert)
    x7214.InchargeUpdate = trim$(  x7214.InchargeUpdate)
    x7214.CheckUse = trim$(  x7214.CheckUse)
    x7214.CheckComplete = trim$(  x7214.CheckComplete)
    x7214.Remark = trim$(  x7214.Remark)
     
    If trim$( x7214.Autokey ) = "" Then x7214.Autokey = 0 
    If trim$( x7214.Article ) = "" Then x7214.Article = Space(1) 
    If trim$( x7214.CustomerCode ) = "" Then x7214.CustomerCode = Space(1) 
    If trim$( x7214.seSeason ) = "" Then x7214.seSeason = Space(1) 
    If trim$( x7214.cdSeason ) = "" Then x7214.cdSeason = Space(1) 
    If trim$( x7214.SizeWeight01 ) = "" Then x7214.SizeWeight01 = 0 
    If trim$( x7214.SizeWeight02 ) = "" Then x7214.SizeWeight02 = 0 
    If trim$( x7214.SizeWeight03 ) = "" Then x7214.SizeWeight03 = 0 
    If trim$( x7214.SizeWeight04 ) = "" Then x7214.SizeWeight04 = 0 
    If trim$( x7214.SizeWeight05 ) = "" Then x7214.SizeWeight05 = 0 
    If trim$( x7214.SizeWeight06 ) = "" Then x7214.SizeWeight06 = 0 
    If trim$( x7214.SizeWeight07 ) = "" Then x7214.SizeWeight07 = 0 
    If trim$( x7214.SizeWeight08 ) = "" Then x7214.SizeWeight08 = 0 
    If trim$( x7214.SizeWeight09 ) = "" Then x7214.SizeWeight09 = 0 
    If trim$( x7214.SizeWeight10 ) = "" Then x7214.SizeWeight10 = 0 
    If trim$( x7214.SizeWeight11 ) = "" Then x7214.SizeWeight11 = 0 
    If trim$( x7214.SizeWeight12 ) = "" Then x7214.SizeWeight12 = 0 
    If trim$( x7214.SizeWeight13 ) = "" Then x7214.SizeWeight13 = 0 
    If trim$( x7214.SizeWeight14 ) = "" Then x7214.SizeWeight14 = 0 
    If trim$( x7214.SizeWeight15 ) = "" Then x7214.SizeWeight15 = 0 
    If trim$( x7214.SizeWeight16 ) = "" Then x7214.SizeWeight16 = 0 
    If trim$( x7214.SizeWeight17 ) = "" Then x7214.SizeWeight17 = 0 
    If trim$( x7214.SizeWeight18 ) = "" Then x7214.SizeWeight18 = 0 
    If trim$( x7214.SizeWeight19 ) = "" Then x7214.SizeWeight19 = 0 
    If trim$( x7214.SizeWeight20 ) = "" Then x7214.SizeWeight20 = 0 
    If trim$( x7214.SizeWeight21 ) = "" Then x7214.SizeWeight21 = 0 
    If trim$( x7214.SizeWeight22 ) = "" Then x7214.SizeWeight22 = 0 
    If trim$( x7214.SizeWeight23 ) = "" Then x7214.SizeWeight23 = 0 
    If trim$( x7214.SizeWeight24 ) = "" Then x7214.SizeWeight24 = 0 
    If trim$( x7214.SizeWeight25 ) = "" Then x7214.SizeWeight25 = 0 
    If trim$( x7214.SizeWeight26 ) = "" Then x7214.SizeWeight26 = 0 
    If trim$( x7214.SizeWeight27 ) = "" Then x7214.SizeWeight27 = 0 
    If trim$( x7214.SizeWeight28 ) = "" Then x7214.SizeWeight28 = 0 
    If trim$( x7214.SizeWeight29 ) = "" Then x7214.SizeWeight29 = 0 
    If trim$( x7214.SizeWeight30 ) = "" Then x7214.SizeWeight30 = 0 
    If trim$( x7214.DateInsert ) = "" Then x7214.DateInsert = Space(1) 
    If trim$( x7214.DateUpdate ) = "" Then x7214.DateUpdate = Space(1) 
    If trim$( x7214.InchargeInsert ) = "" Then x7214.InchargeInsert = Space(1) 
    If trim$( x7214.InchargeUpdate ) = "" Then x7214.InchargeUpdate = Space(1) 
    If trim$( x7214.CheckUse ) = "" Then x7214.CheckUse = Space(1) 
    If trim$( x7214.CheckComplete ) = "" Then x7214.CheckComplete = Space(1) 
    If trim$( x7214.Remark ) = "" Then x7214.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7214_MOVE(rs7214 As SqlClient.SqlDataReader)
Try

    call D7214_CLEAR()   

    If IsdbNull(rs7214!K7214_Autokey) = False Then D7214.Autokey = Trim$(rs7214!K7214_Autokey)
    If IsdbNull(rs7214!K7214_Article) = False Then D7214.Article = Trim$(rs7214!K7214_Article)
    If IsdbNull(rs7214!K7214_CustomerCode) = False Then D7214.CustomerCode = Trim$(rs7214!K7214_CustomerCode)
    If IsdbNull(rs7214!K7214_seSeason) = False Then D7214.seSeason = Trim$(rs7214!K7214_seSeason)
    If IsdbNull(rs7214!K7214_cdSeason) = False Then D7214.cdSeason = Trim$(rs7214!K7214_cdSeason)
    If IsdbNull(rs7214!K7214_SizeWeight01) = False Then D7214.SizeWeight01 = Trim$(rs7214!K7214_SizeWeight01)
    If IsdbNull(rs7214!K7214_SizeWeight02) = False Then D7214.SizeWeight02 = Trim$(rs7214!K7214_SizeWeight02)
    If IsdbNull(rs7214!K7214_SizeWeight03) = False Then D7214.SizeWeight03 = Trim$(rs7214!K7214_SizeWeight03)
    If IsdbNull(rs7214!K7214_SizeWeight04) = False Then D7214.SizeWeight04 = Trim$(rs7214!K7214_SizeWeight04)
    If IsdbNull(rs7214!K7214_SizeWeight05) = False Then D7214.SizeWeight05 = Trim$(rs7214!K7214_SizeWeight05)
    If IsdbNull(rs7214!K7214_SizeWeight06) = False Then D7214.SizeWeight06 = Trim$(rs7214!K7214_SizeWeight06)
    If IsdbNull(rs7214!K7214_SizeWeight07) = False Then D7214.SizeWeight07 = Trim$(rs7214!K7214_SizeWeight07)
    If IsdbNull(rs7214!K7214_SizeWeight08) = False Then D7214.SizeWeight08 = Trim$(rs7214!K7214_SizeWeight08)
    If IsdbNull(rs7214!K7214_SizeWeight09) = False Then D7214.SizeWeight09 = Trim$(rs7214!K7214_SizeWeight09)
    If IsdbNull(rs7214!K7214_SizeWeight10) = False Then D7214.SizeWeight10 = Trim$(rs7214!K7214_SizeWeight10)
    If IsdbNull(rs7214!K7214_SizeWeight11) = False Then D7214.SizeWeight11 = Trim$(rs7214!K7214_SizeWeight11)
    If IsdbNull(rs7214!K7214_SizeWeight12) = False Then D7214.SizeWeight12 = Trim$(rs7214!K7214_SizeWeight12)
    If IsdbNull(rs7214!K7214_SizeWeight13) = False Then D7214.SizeWeight13 = Trim$(rs7214!K7214_SizeWeight13)
    If IsdbNull(rs7214!K7214_SizeWeight14) = False Then D7214.SizeWeight14 = Trim$(rs7214!K7214_SizeWeight14)
    If IsdbNull(rs7214!K7214_SizeWeight15) = False Then D7214.SizeWeight15 = Trim$(rs7214!K7214_SizeWeight15)
    If IsdbNull(rs7214!K7214_SizeWeight16) = False Then D7214.SizeWeight16 = Trim$(rs7214!K7214_SizeWeight16)
    If IsdbNull(rs7214!K7214_SizeWeight17) = False Then D7214.SizeWeight17 = Trim$(rs7214!K7214_SizeWeight17)
    If IsdbNull(rs7214!K7214_SizeWeight18) = False Then D7214.SizeWeight18 = Trim$(rs7214!K7214_SizeWeight18)
    If IsdbNull(rs7214!K7214_SizeWeight19) = False Then D7214.SizeWeight19 = Trim$(rs7214!K7214_SizeWeight19)
    If IsdbNull(rs7214!K7214_SizeWeight20) = False Then D7214.SizeWeight20 = Trim$(rs7214!K7214_SizeWeight20)
    If IsdbNull(rs7214!K7214_SizeWeight21) = False Then D7214.SizeWeight21 = Trim$(rs7214!K7214_SizeWeight21)
    If IsdbNull(rs7214!K7214_SizeWeight22) = False Then D7214.SizeWeight22 = Trim$(rs7214!K7214_SizeWeight22)
    If IsdbNull(rs7214!K7214_SizeWeight23) = False Then D7214.SizeWeight23 = Trim$(rs7214!K7214_SizeWeight23)
    If IsdbNull(rs7214!K7214_SizeWeight24) = False Then D7214.SizeWeight24 = Trim$(rs7214!K7214_SizeWeight24)
    If IsdbNull(rs7214!K7214_SizeWeight25) = False Then D7214.SizeWeight25 = Trim$(rs7214!K7214_SizeWeight25)
    If IsdbNull(rs7214!K7214_SizeWeight26) = False Then D7214.SizeWeight26 = Trim$(rs7214!K7214_SizeWeight26)
    If IsdbNull(rs7214!K7214_SizeWeight27) = False Then D7214.SizeWeight27 = Trim$(rs7214!K7214_SizeWeight27)
    If IsdbNull(rs7214!K7214_SizeWeight28) = False Then D7214.SizeWeight28 = Trim$(rs7214!K7214_SizeWeight28)
    If IsdbNull(rs7214!K7214_SizeWeight29) = False Then D7214.SizeWeight29 = Trim$(rs7214!K7214_SizeWeight29)
    If IsdbNull(rs7214!K7214_SizeWeight30) = False Then D7214.SizeWeight30 = Trim$(rs7214!K7214_SizeWeight30)
    If IsdbNull(rs7214!K7214_DateInsert) = False Then D7214.DateInsert = Trim$(rs7214!K7214_DateInsert)
    If IsdbNull(rs7214!K7214_DateUpdate) = False Then D7214.DateUpdate = Trim$(rs7214!K7214_DateUpdate)
    If IsdbNull(rs7214!K7214_InchargeInsert) = False Then D7214.InchargeInsert = Trim$(rs7214!K7214_InchargeInsert)
    If IsdbNull(rs7214!K7214_InchargeUpdate) = False Then D7214.InchargeUpdate = Trim$(rs7214!K7214_InchargeUpdate)
    If IsdbNull(rs7214!K7214_CheckUse) = False Then D7214.CheckUse = Trim$(rs7214!K7214_CheckUse)
    If IsdbNull(rs7214!K7214_CheckComplete) = False Then D7214.CheckComplete = Trim$(rs7214!K7214_CheckComplete)
    If IsdbNull(rs7214!K7214_Remark) = False Then D7214.Remark = Trim$(rs7214!K7214_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7214_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7214_MOVE(rs7214 As DataRow)
Try

    call D7214_CLEAR()   

    If IsdbNull(rs7214!K7214_Autokey) = False Then D7214.Autokey = Trim$(rs7214!K7214_Autokey)
    If IsdbNull(rs7214!K7214_Article) = False Then D7214.Article = Trim$(rs7214!K7214_Article)
    If IsdbNull(rs7214!K7214_CustomerCode) = False Then D7214.CustomerCode = Trim$(rs7214!K7214_CustomerCode)
    If IsdbNull(rs7214!K7214_seSeason) = False Then D7214.seSeason = Trim$(rs7214!K7214_seSeason)
    If IsdbNull(rs7214!K7214_cdSeason) = False Then D7214.cdSeason = Trim$(rs7214!K7214_cdSeason)
    If IsdbNull(rs7214!K7214_SizeWeight01) = False Then D7214.SizeWeight01 = Trim$(rs7214!K7214_SizeWeight01)
    If IsdbNull(rs7214!K7214_SizeWeight02) = False Then D7214.SizeWeight02 = Trim$(rs7214!K7214_SizeWeight02)
    If IsdbNull(rs7214!K7214_SizeWeight03) = False Then D7214.SizeWeight03 = Trim$(rs7214!K7214_SizeWeight03)
    If IsdbNull(rs7214!K7214_SizeWeight04) = False Then D7214.SizeWeight04 = Trim$(rs7214!K7214_SizeWeight04)
    If IsdbNull(rs7214!K7214_SizeWeight05) = False Then D7214.SizeWeight05 = Trim$(rs7214!K7214_SizeWeight05)
    If IsdbNull(rs7214!K7214_SizeWeight06) = False Then D7214.SizeWeight06 = Trim$(rs7214!K7214_SizeWeight06)
    If IsdbNull(rs7214!K7214_SizeWeight07) = False Then D7214.SizeWeight07 = Trim$(rs7214!K7214_SizeWeight07)
    If IsdbNull(rs7214!K7214_SizeWeight08) = False Then D7214.SizeWeight08 = Trim$(rs7214!K7214_SizeWeight08)
    If IsdbNull(rs7214!K7214_SizeWeight09) = False Then D7214.SizeWeight09 = Trim$(rs7214!K7214_SizeWeight09)
    If IsdbNull(rs7214!K7214_SizeWeight10) = False Then D7214.SizeWeight10 = Trim$(rs7214!K7214_SizeWeight10)
    If IsdbNull(rs7214!K7214_SizeWeight11) = False Then D7214.SizeWeight11 = Trim$(rs7214!K7214_SizeWeight11)
    If IsdbNull(rs7214!K7214_SizeWeight12) = False Then D7214.SizeWeight12 = Trim$(rs7214!K7214_SizeWeight12)
    If IsdbNull(rs7214!K7214_SizeWeight13) = False Then D7214.SizeWeight13 = Trim$(rs7214!K7214_SizeWeight13)
    If IsdbNull(rs7214!K7214_SizeWeight14) = False Then D7214.SizeWeight14 = Trim$(rs7214!K7214_SizeWeight14)
    If IsdbNull(rs7214!K7214_SizeWeight15) = False Then D7214.SizeWeight15 = Trim$(rs7214!K7214_SizeWeight15)
    If IsdbNull(rs7214!K7214_SizeWeight16) = False Then D7214.SizeWeight16 = Trim$(rs7214!K7214_SizeWeight16)
    If IsdbNull(rs7214!K7214_SizeWeight17) = False Then D7214.SizeWeight17 = Trim$(rs7214!K7214_SizeWeight17)
    If IsdbNull(rs7214!K7214_SizeWeight18) = False Then D7214.SizeWeight18 = Trim$(rs7214!K7214_SizeWeight18)
    If IsdbNull(rs7214!K7214_SizeWeight19) = False Then D7214.SizeWeight19 = Trim$(rs7214!K7214_SizeWeight19)
    If IsdbNull(rs7214!K7214_SizeWeight20) = False Then D7214.SizeWeight20 = Trim$(rs7214!K7214_SizeWeight20)
    If IsdbNull(rs7214!K7214_SizeWeight21) = False Then D7214.SizeWeight21 = Trim$(rs7214!K7214_SizeWeight21)
    If IsdbNull(rs7214!K7214_SizeWeight22) = False Then D7214.SizeWeight22 = Trim$(rs7214!K7214_SizeWeight22)
    If IsdbNull(rs7214!K7214_SizeWeight23) = False Then D7214.SizeWeight23 = Trim$(rs7214!K7214_SizeWeight23)
    If IsdbNull(rs7214!K7214_SizeWeight24) = False Then D7214.SizeWeight24 = Trim$(rs7214!K7214_SizeWeight24)
    If IsdbNull(rs7214!K7214_SizeWeight25) = False Then D7214.SizeWeight25 = Trim$(rs7214!K7214_SizeWeight25)
    If IsdbNull(rs7214!K7214_SizeWeight26) = False Then D7214.SizeWeight26 = Trim$(rs7214!K7214_SizeWeight26)
    If IsdbNull(rs7214!K7214_SizeWeight27) = False Then D7214.SizeWeight27 = Trim$(rs7214!K7214_SizeWeight27)
    If IsdbNull(rs7214!K7214_SizeWeight28) = False Then D7214.SizeWeight28 = Trim$(rs7214!K7214_SizeWeight28)
    If IsdbNull(rs7214!K7214_SizeWeight29) = False Then D7214.SizeWeight29 = Trim$(rs7214!K7214_SizeWeight29)
    If IsdbNull(rs7214!K7214_SizeWeight30) = False Then D7214.SizeWeight30 = Trim$(rs7214!K7214_SizeWeight30)
    If IsdbNull(rs7214!K7214_DateInsert) = False Then D7214.DateInsert = Trim$(rs7214!K7214_DateInsert)
    If IsdbNull(rs7214!K7214_DateUpdate) = False Then D7214.DateUpdate = Trim$(rs7214!K7214_DateUpdate)
    If IsdbNull(rs7214!K7214_InchargeInsert) = False Then D7214.InchargeInsert = Trim$(rs7214!K7214_InchargeInsert)
    If IsdbNull(rs7214!K7214_InchargeUpdate) = False Then D7214.InchargeUpdate = Trim$(rs7214!K7214_InchargeUpdate)
    If IsdbNull(rs7214!K7214_CheckUse) = False Then D7214.CheckUse = Trim$(rs7214!K7214_CheckUse)
    If IsdbNull(rs7214!K7214_CheckComplete) = False Then D7214.CheckComplete = Trim$(rs7214!K7214_CheckComplete)
    If IsdbNull(rs7214!K7214_Remark) = False Then D7214.Remark = Trim$(rs7214!K7214_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7214_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7214_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7214 As T7214_AREA, AUTOKEY AS Double) as Boolean

K7214_MOVE = False

Try
    If READ_PFK7214(AUTOKEY) = True Then
                z7214 = D7214
		K7214_MOVE = True
		else
	z7214 = nothing
     End If

     If  getColumIndex(spr,"Autokey") > -1 then z7214.Autokey = getDataM(spr, getColumIndex(spr,"Autokey"), xRow)
     If  getColumIndex(spr,"Article") > -1 then z7214.Article = getDataM(spr, getColumIndex(spr,"Article"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z7214.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"seSeason") > -1 then z7214.seSeason = getDataM(spr, getColumIndex(spr,"seSeason"), xRow)
     If  getColumIndex(spr,"cdSeason") > -1 then z7214.cdSeason = getDataM(spr, getColumIndex(spr,"cdSeason"), xRow)
     If  getColumIndex(spr,"SizeWeight01") > -1 then z7214.SizeWeight01 = getDataM(spr, getColumIndex(spr,"SizeWeight01"), xRow)
     If  getColumIndex(spr,"SizeWeight02") > -1 then z7214.SizeWeight02 = getDataM(spr, getColumIndex(spr,"SizeWeight02"), xRow)
     If  getColumIndex(spr,"SizeWeight03") > -1 then z7214.SizeWeight03 = getDataM(spr, getColumIndex(spr,"SizeWeight03"), xRow)
     If  getColumIndex(spr,"SizeWeight04") > -1 then z7214.SizeWeight04 = getDataM(spr, getColumIndex(spr,"SizeWeight04"), xRow)
     If  getColumIndex(spr,"SizeWeight05") > -1 then z7214.SizeWeight05 = getDataM(spr, getColumIndex(spr,"SizeWeight05"), xRow)
     If  getColumIndex(spr,"SizeWeight06") > -1 then z7214.SizeWeight06 = getDataM(spr, getColumIndex(spr,"SizeWeight06"), xRow)
     If  getColumIndex(spr,"SizeWeight07") > -1 then z7214.SizeWeight07 = getDataM(spr, getColumIndex(spr,"SizeWeight07"), xRow)
     If  getColumIndex(spr,"SizeWeight08") > -1 then z7214.SizeWeight08 = getDataM(spr, getColumIndex(spr,"SizeWeight08"), xRow)
     If  getColumIndex(spr,"SizeWeight09") > -1 then z7214.SizeWeight09 = getDataM(spr, getColumIndex(spr,"SizeWeight09"), xRow)
     If  getColumIndex(spr,"SizeWeight10") > -1 then z7214.SizeWeight10 = getDataM(spr, getColumIndex(spr,"SizeWeight10"), xRow)
     If  getColumIndex(spr,"SizeWeight11") > -1 then z7214.SizeWeight11 = getDataM(spr, getColumIndex(spr,"SizeWeight11"), xRow)
     If  getColumIndex(spr,"SizeWeight12") > -1 then z7214.SizeWeight12 = getDataM(spr, getColumIndex(spr,"SizeWeight12"), xRow)
     If  getColumIndex(spr,"SizeWeight13") > -1 then z7214.SizeWeight13 = getDataM(spr, getColumIndex(spr,"SizeWeight13"), xRow)
     If  getColumIndex(spr,"SizeWeight14") > -1 then z7214.SizeWeight14 = getDataM(spr, getColumIndex(spr,"SizeWeight14"), xRow)
     If  getColumIndex(spr,"SizeWeight15") > -1 then z7214.SizeWeight15 = getDataM(spr, getColumIndex(spr,"SizeWeight15"), xRow)
     If  getColumIndex(spr,"SizeWeight16") > -1 then z7214.SizeWeight16 = getDataM(spr, getColumIndex(spr,"SizeWeight16"), xRow)
     If  getColumIndex(spr,"SizeWeight17") > -1 then z7214.SizeWeight17 = getDataM(spr, getColumIndex(spr,"SizeWeight17"), xRow)
     If  getColumIndex(spr,"SizeWeight18") > -1 then z7214.SizeWeight18 = getDataM(spr, getColumIndex(spr,"SizeWeight18"), xRow)
     If  getColumIndex(spr,"SizeWeight19") > -1 then z7214.SizeWeight19 = getDataM(spr, getColumIndex(spr,"SizeWeight19"), xRow)
     If  getColumIndex(spr,"SizeWeight20") > -1 then z7214.SizeWeight20 = getDataM(spr, getColumIndex(spr,"SizeWeight20"), xRow)
     If  getColumIndex(spr,"SizeWeight21") > -1 then z7214.SizeWeight21 = getDataM(spr, getColumIndex(spr,"SizeWeight21"), xRow)
     If  getColumIndex(spr,"SizeWeight22") > -1 then z7214.SizeWeight22 = getDataM(spr, getColumIndex(spr,"SizeWeight22"), xRow)
     If  getColumIndex(spr,"SizeWeight23") > -1 then z7214.SizeWeight23 = getDataM(spr, getColumIndex(spr,"SizeWeight23"), xRow)
     If  getColumIndex(spr,"SizeWeight24") > -1 then z7214.SizeWeight24 = getDataM(spr, getColumIndex(spr,"SizeWeight24"), xRow)
     If  getColumIndex(spr,"SizeWeight25") > -1 then z7214.SizeWeight25 = getDataM(spr, getColumIndex(spr,"SizeWeight25"), xRow)
     If  getColumIndex(spr,"SizeWeight26") > -1 then z7214.SizeWeight26 = getDataM(spr, getColumIndex(spr,"SizeWeight26"), xRow)
     If  getColumIndex(spr,"SizeWeight27") > -1 then z7214.SizeWeight27 = getDataM(spr, getColumIndex(spr,"SizeWeight27"), xRow)
     If  getColumIndex(spr,"SizeWeight28") > -1 then z7214.SizeWeight28 = getDataM(spr, getColumIndex(spr,"SizeWeight28"), xRow)
     If  getColumIndex(spr,"SizeWeight29") > -1 then z7214.SizeWeight29 = getDataM(spr, getColumIndex(spr,"SizeWeight29"), xRow)
     If  getColumIndex(spr,"SizeWeight30") > -1 then z7214.SizeWeight30 = getDataM(spr, getColumIndex(spr,"SizeWeight30"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7214.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7214.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7214.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7214.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7214.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z7214.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7214.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7214_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7214_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7214 As T7214_AREA,CheckClear as Boolean,AUTOKEY AS Double) as Boolean

K7214_MOVE = False

Try
    If READ_PFK7214(AUTOKEY) = True Then
                z7214 = D7214
		K7214_MOVE = True
		else
	If CheckClear  = True then z7214 = nothing
     End If

     If  getColumIndex(spr,"Autokey") > -1 then z7214.Autokey = getDataM(spr, getColumIndex(spr,"Autokey"), xRow)
     If  getColumIndex(spr,"Article") > -1 then z7214.Article = getDataM(spr, getColumIndex(spr,"Article"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z7214.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"seSeason") > -1 then z7214.seSeason = getDataM(spr, getColumIndex(spr,"seSeason"), xRow)
     If  getColumIndex(spr,"cdSeason") > -1 then z7214.cdSeason = getDataM(spr, getColumIndex(spr,"cdSeason"), xRow)
     If  getColumIndex(spr,"SizeWeight01") > -1 then z7214.SizeWeight01 = getDataM(spr, getColumIndex(spr,"SizeWeight01"), xRow)
     If  getColumIndex(spr,"SizeWeight02") > -1 then z7214.SizeWeight02 = getDataM(spr, getColumIndex(spr,"SizeWeight02"), xRow)
     If  getColumIndex(spr,"SizeWeight03") > -1 then z7214.SizeWeight03 = getDataM(spr, getColumIndex(spr,"SizeWeight03"), xRow)
     If  getColumIndex(spr,"SizeWeight04") > -1 then z7214.SizeWeight04 = getDataM(spr, getColumIndex(spr,"SizeWeight04"), xRow)
     If  getColumIndex(spr,"SizeWeight05") > -1 then z7214.SizeWeight05 = getDataM(spr, getColumIndex(spr,"SizeWeight05"), xRow)
     If  getColumIndex(spr,"SizeWeight06") > -1 then z7214.SizeWeight06 = getDataM(spr, getColumIndex(spr,"SizeWeight06"), xRow)
     If  getColumIndex(spr,"SizeWeight07") > -1 then z7214.SizeWeight07 = getDataM(spr, getColumIndex(spr,"SizeWeight07"), xRow)
     If  getColumIndex(spr,"SizeWeight08") > -1 then z7214.SizeWeight08 = getDataM(spr, getColumIndex(spr,"SizeWeight08"), xRow)
     If  getColumIndex(spr,"SizeWeight09") > -1 then z7214.SizeWeight09 = getDataM(spr, getColumIndex(spr,"SizeWeight09"), xRow)
     If  getColumIndex(spr,"SizeWeight10") > -1 then z7214.SizeWeight10 = getDataM(spr, getColumIndex(spr,"SizeWeight10"), xRow)
     If  getColumIndex(spr,"SizeWeight11") > -1 then z7214.SizeWeight11 = getDataM(spr, getColumIndex(spr,"SizeWeight11"), xRow)
     If  getColumIndex(spr,"SizeWeight12") > -1 then z7214.SizeWeight12 = getDataM(spr, getColumIndex(spr,"SizeWeight12"), xRow)
     If  getColumIndex(spr,"SizeWeight13") > -1 then z7214.SizeWeight13 = getDataM(spr, getColumIndex(spr,"SizeWeight13"), xRow)
     If  getColumIndex(spr,"SizeWeight14") > -1 then z7214.SizeWeight14 = getDataM(spr, getColumIndex(spr,"SizeWeight14"), xRow)
     If  getColumIndex(spr,"SizeWeight15") > -1 then z7214.SizeWeight15 = getDataM(spr, getColumIndex(spr,"SizeWeight15"), xRow)
     If  getColumIndex(spr,"SizeWeight16") > -1 then z7214.SizeWeight16 = getDataM(spr, getColumIndex(spr,"SizeWeight16"), xRow)
     If  getColumIndex(spr,"SizeWeight17") > -1 then z7214.SizeWeight17 = getDataM(spr, getColumIndex(spr,"SizeWeight17"), xRow)
     If  getColumIndex(spr,"SizeWeight18") > -1 then z7214.SizeWeight18 = getDataM(spr, getColumIndex(spr,"SizeWeight18"), xRow)
     If  getColumIndex(spr,"SizeWeight19") > -1 then z7214.SizeWeight19 = getDataM(spr, getColumIndex(spr,"SizeWeight19"), xRow)
     If  getColumIndex(spr,"SizeWeight20") > -1 then z7214.SizeWeight20 = getDataM(spr, getColumIndex(spr,"SizeWeight20"), xRow)
     If  getColumIndex(spr,"SizeWeight21") > -1 then z7214.SizeWeight21 = getDataM(spr, getColumIndex(spr,"SizeWeight21"), xRow)
     If  getColumIndex(spr,"SizeWeight22") > -1 then z7214.SizeWeight22 = getDataM(spr, getColumIndex(spr,"SizeWeight22"), xRow)
     If  getColumIndex(spr,"SizeWeight23") > -1 then z7214.SizeWeight23 = getDataM(spr, getColumIndex(spr,"SizeWeight23"), xRow)
     If  getColumIndex(spr,"SizeWeight24") > -1 then z7214.SizeWeight24 = getDataM(spr, getColumIndex(spr,"SizeWeight24"), xRow)
     If  getColumIndex(spr,"SizeWeight25") > -1 then z7214.SizeWeight25 = getDataM(spr, getColumIndex(spr,"SizeWeight25"), xRow)
     If  getColumIndex(spr,"SizeWeight26") > -1 then z7214.SizeWeight26 = getDataM(spr, getColumIndex(spr,"SizeWeight26"), xRow)
     If  getColumIndex(spr,"SizeWeight27") > -1 then z7214.SizeWeight27 = getDataM(spr, getColumIndex(spr,"SizeWeight27"), xRow)
     If  getColumIndex(spr,"SizeWeight28") > -1 then z7214.SizeWeight28 = getDataM(spr, getColumIndex(spr,"SizeWeight28"), xRow)
     If  getColumIndex(spr,"SizeWeight29") > -1 then z7214.SizeWeight29 = getDataM(spr, getColumIndex(spr,"SizeWeight29"), xRow)
     If  getColumIndex(spr,"SizeWeight30") > -1 then z7214.SizeWeight30 = getDataM(spr, getColumIndex(spr,"SizeWeight30"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7214.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7214.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7214.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7214.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7214.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z7214.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7214.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7214_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7214_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7214 As T7214_AREA, Job as String, AUTOKEY AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7214_MOVE = False

Try
    If READ_PFK7214(AUTOKEY) = True Then
                z7214 = D7214
		K7214_MOVE = True
		else
	z7214 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7214")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z7214.Autokey = Children(i).Code
   Case "ARTICLE":z7214.Article = Children(i).Code
   Case "CUSTOMERCODE":z7214.CustomerCode = Children(i).Code
   Case "SESEASON":z7214.seSeason = Children(i).Code
   Case "CDSEASON":z7214.cdSeason = Children(i).Code
   Case "SIZEWEIGHT01":z7214.SizeWeight01 = Children(i).Code
   Case "SIZEWEIGHT02":z7214.SizeWeight02 = Children(i).Code
   Case "SIZEWEIGHT03":z7214.SizeWeight03 = Children(i).Code
   Case "SIZEWEIGHT04":z7214.SizeWeight04 = Children(i).Code
   Case "SIZEWEIGHT05":z7214.SizeWeight05 = Children(i).Code
   Case "SIZEWEIGHT06":z7214.SizeWeight06 = Children(i).Code
   Case "SIZEWEIGHT07":z7214.SizeWeight07 = Children(i).Code
   Case "SIZEWEIGHT08":z7214.SizeWeight08 = Children(i).Code
   Case "SIZEWEIGHT09":z7214.SizeWeight09 = Children(i).Code
   Case "SIZEWEIGHT10":z7214.SizeWeight10 = Children(i).Code
   Case "SIZEWEIGHT11":z7214.SizeWeight11 = Children(i).Code
   Case "SIZEWEIGHT12":z7214.SizeWeight12 = Children(i).Code
   Case "SIZEWEIGHT13":z7214.SizeWeight13 = Children(i).Code
   Case "SIZEWEIGHT14":z7214.SizeWeight14 = Children(i).Code
   Case "SIZEWEIGHT15":z7214.SizeWeight15 = Children(i).Code
   Case "SIZEWEIGHT16":z7214.SizeWeight16 = Children(i).Code
   Case "SIZEWEIGHT17":z7214.SizeWeight17 = Children(i).Code
   Case "SIZEWEIGHT18":z7214.SizeWeight18 = Children(i).Code
   Case "SIZEWEIGHT19":z7214.SizeWeight19 = Children(i).Code
   Case "SIZEWEIGHT20":z7214.SizeWeight20 = Children(i).Code
   Case "SIZEWEIGHT21":z7214.SizeWeight21 = Children(i).Code
   Case "SIZEWEIGHT22":z7214.SizeWeight22 = Children(i).Code
   Case "SIZEWEIGHT23":z7214.SizeWeight23 = Children(i).Code
   Case "SIZEWEIGHT24":z7214.SizeWeight24 = Children(i).Code
   Case "SIZEWEIGHT25":z7214.SizeWeight25 = Children(i).Code
   Case "SIZEWEIGHT26":z7214.SizeWeight26 = Children(i).Code
   Case "SIZEWEIGHT27":z7214.SizeWeight27 = Children(i).Code
   Case "SIZEWEIGHT28":z7214.SizeWeight28 = Children(i).Code
   Case "SIZEWEIGHT29":z7214.SizeWeight29 = Children(i).Code
   Case "SIZEWEIGHT30":z7214.SizeWeight30 = Children(i).Code
   Case "DATEINSERT":z7214.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7214.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7214.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7214.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7214.CheckUse = Children(i).Code
   Case "CHECKCOMPLETE":z7214.CheckComplete = Children(i).Code
   Case "REMARK":z7214.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z7214.Autokey = Children(i).Data
   Case "ARTICLE":z7214.Article = Children(i).Data
   Case "CUSTOMERCODE":z7214.CustomerCode = Children(i).Data
   Case "SESEASON":z7214.seSeason = Children(i).Data
   Case "CDSEASON":z7214.cdSeason = Children(i).Data
   Case "SIZEWEIGHT01":z7214.SizeWeight01 = Children(i).Data
   Case "SIZEWEIGHT02":z7214.SizeWeight02 = Children(i).Data
   Case "SIZEWEIGHT03":z7214.SizeWeight03 = Children(i).Data
   Case "SIZEWEIGHT04":z7214.SizeWeight04 = Children(i).Data
   Case "SIZEWEIGHT05":z7214.SizeWeight05 = Children(i).Data
   Case "SIZEWEIGHT06":z7214.SizeWeight06 = Children(i).Data
   Case "SIZEWEIGHT07":z7214.SizeWeight07 = Children(i).Data
   Case "SIZEWEIGHT08":z7214.SizeWeight08 = Children(i).Data
   Case "SIZEWEIGHT09":z7214.SizeWeight09 = Children(i).Data
   Case "SIZEWEIGHT10":z7214.SizeWeight10 = Children(i).Data
   Case "SIZEWEIGHT11":z7214.SizeWeight11 = Children(i).Data
   Case "SIZEWEIGHT12":z7214.SizeWeight12 = Children(i).Data
   Case "SIZEWEIGHT13":z7214.SizeWeight13 = Children(i).Data
   Case "SIZEWEIGHT14":z7214.SizeWeight14 = Children(i).Data
   Case "SIZEWEIGHT15":z7214.SizeWeight15 = Children(i).Data
   Case "SIZEWEIGHT16":z7214.SizeWeight16 = Children(i).Data
   Case "SIZEWEIGHT17":z7214.SizeWeight17 = Children(i).Data
   Case "SIZEWEIGHT18":z7214.SizeWeight18 = Children(i).Data
   Case "SIZEWEIGHT19":z7214.SizeWeight19 = Children(i).Data
   Case "SIZEWEIGHT20":z7214.SizeWeight20 = Children(i).Data
   Case "SIZEWEIGHT21":z7214.SizeWeight21 = Children(i).Data
   Case "SIZEWEIGHT22":z7214.SizeWeight22 = Children(i).Data
   Case "SIZEWEIGHT23":z7214.SizeWeight23 = Children(i).Data
   Case "SIZEWEIGHT24":z7214.SizeWeight24 = Children(i).Data
   Case "SIZEWEIGHT25":z7214.SizeWeight25 = Children(i).Data
   Case "SIZEWEIGHT26":z7214.SizeWeight26 = Children(i).Data
   Case "SIZEWEIGHT27":z7214.SizeWeight27 = Children(i).Data
   Case "SIZEWEIGHT28":z7214.SizeWeight28 = Children(i).Data
   Case "SIZEWEIGHT29":z7214.SizeWeight29 = Children(i).Data
   Case "SIZEWEIGHT30":z7214.SizeWeight30 = Children(i).Data
   Case "DATEINSERT":z7214.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7214.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7214.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7214.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7214.CheckUse = Children(i).Data
   Case "CHECKCOMPLETE":z7214.CheckComplete = Children(i).Data
   Case "REMARK":z7214.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7214_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7214_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7214 As T7214_AREA, Job as String, CheckClear as Boolean, AUTOKEY AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7214_MOVE = False

Try
    If READ_PFK7214(AUTOKEY) = True Then
                z7214 = D7214
		K7214_MOVE = True
		else
	If CheckClear  = True then z7214 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7214")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z7214.Autokey = Children(i).Code
   Case "ARTICLE":z7214.Article = Children(i).Code
   Case "CUSTOMERCODE":z7214.CustomerCode = Children(i).Code
   Case "SESEASON":z7214.seSeason = Children(i).Code
   Case "CDSEASON":z7214.cdSeason = Children(i).Code
   Case "SIZEWEIGHT01":z7214.SizeWeight01 = Children(i).Code
   Case "SIZEWEIGHT02":z7214.SizeWeight02 = Children(i).Code
   Case "SIZEWEIGHT03":z7214.SizeWeight03 = Children(i).Code
   Case "SIZEWEIGHT04":z7214.SizeWeight04 = Children(i).Code
   Case "SIZEWEIGHT05":z7214.SizeWeight05 = Children(i).Code
   Case "SIZEWEIGHT06":z7214.SizeWeight06 = Children(i).Code
   Case "SIZEWEIGHT07":z7214.SizeWeight07 = Children(i).Code
   Case "SIZEWEIGHT08":z7214.SizeWeight08 = Children(i).Code
   Case "SIZEWEIGHT09":z7214.SizeWeight09 = Children(i).Code
   Case "SIZEWEIGHT10":z7214.SizeWeight10 = Children(i).Code
   Case "SIZEWEIGHT11":z7214.SizeWeight11 = Children(i).Code
   Case "SIZEWEIGHT12":z7214.SizeWeight12 = Children(i).Code
   Case "SIZEWEIGHT13":z7214.SizeWeight13 = Children(i).Code
   Case "SIZEWEIGHT14":z7214.SizeWeight14 = Children(i).Code
   Case "SIZEWEIGHT15":z7214.SizeWeight15 = Children(i).Code
   Case "SIZEWEIGHT16":z7214.SizeWeight16 = Children(i).Code
   Case "SIZEWEIGHT17":z7214.SizeWeight17 = Children(i).Code
   Case "SIZEWEIGHT18":z7214.SizeWeight18 = Children(i).Code
   Case "SIZEWEIGHT19":z7214.SizeWeight19 = Children(i).Code
   Case "SIZEWEIGHT20":z7214.SizeWeight20 = Children(i).Code
   Case "SIZEWEIGHT21":z7214.SizeWeight21 = Children(i).Code
   Case "SIZEWEIGHT22":z7214.SizeWeight22 = Children(i).Code
   Case "SIZEWEIGHT23":z7214.SizeWeight23 = Children(i).Code
   Case "SIZEWEIGHT24":z7214.SizeWeight24 = Children(i).Code
   Case "SIZEWEIGHT25":z7214.SizeWeight25 = Children(i).Code
   Case "SIZEWEIGHT26":z7214.SizeWeight26 = Children(i).Code
   Case "SIZEWEIGHT27":z7214.SizeWeight27 = Children(i).Code
   Case "SIZEWEIGHT28":z7214.SizeWeight28 = Children(i).Code
   Case "SIZEWEIGHT29":z7214.SizeWeight29 = Children(i).Code
   Case "SIZEWEIGHT30":z7214.SizeWeight30 = Children(i).Code
   Case "DATEINSERT":z7214.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7214.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7214.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7214.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7214.CheckUse = Children(i).Code
   Case "CHECKCOMPLETE":z7214.CheckComplete = Children(i).Code
   Case "REMARK":z7214.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z7214.Autokey = Children(i).Data
   Case "ARTICLE":z7214.Article = Children(i).Data
   Case "CUSTOMERCODE":z7214.CustomerCode = Children(i).Data
   Case "SESEASON":z7214.seSeason = Children(i).Data
   Case "CDSEASON":z7214.cdSeason = Children(i).Data
   Case "SIZEWEIGHT01":z7214.SizeWeight01 = Children(i).Data
   Case "SIZEWEIGHT02":z7214.SizeWeight02 = Children(i).Data
   Case "SIZEWEIGHT03":z7214.SizeWeight03 = Children(i).Data
   Case "SIZEWEIGHT04":z7214.SizeWeight04 = Children(i).Data
   Case "SIZEWEIGHT05":z7214.SizeWeight05 = Children(i).Data
   Case "SIZEWEIGHT06":z7214.SizeWeight06 = Children(i).Data
   Case "SIZEWEIGHT07":z7214.SizeWeight07 = Children(i).Data
   Case "SIZEWEIGHT08":z7214.SizeWeight08 = Children(i).Data
   Case "SIZEWEIGHT09":z7214.SizeWeight09 = Children(i).Data
   Case "SIZEWEIGHT10":z7214.SizeWeight10 = Children(i).Data
   Case "SIZEWEIGHT11":z7214.SizeWeight11 = Children(i).Data
   Case "SIZEWEIGHT12":z7214.SizeWeight12 = Children(i).Data
   Case "SIZEWEIGHT13":z7214.SizeWeight13 = Children(i).Data
   Case "SIZEWEIGHT14":z7214.SizeWeight14 = Children(i).Data
   Case "SIZEWEIGHT15":z7214.SizeWeight15 = Children(i).Data
   Case "SIZEWEIGHT16":z7214.SizeWeight16 = Children(i).Data
   Case "SIZEWEIGHT17":z7214.SizeWeight17 = Children(i).Data
   Case "SIZEWEIGHT18":z7214.SizeWeight18 = Children(i).Data
   Case "SIZEWEIGHT19":z7214.SizeWeight19 = Children(i).Data
   Case "SIZEWEIGHT20":z7214.SizeWeight20 = Children(i).Data
   Case "SIZEWEIGHT21":z7214.SizeWeight21 = Children(i).Data
   Case "SIZEWEIGHT22":z7214.SizeWeight22 = Children(i).Data
   Case "SIZEWEIGHT23":z7214.SizeWeight23 = Children(i).Data
   Case "SIZEWEIGHT24":z7214.SizeWeight24 = Children(i).Data
   Case "SIZEWEIGHT25":z7214.SizeWeight25 = Children(i).Data
   Case "SIZEWEIGHT26":z7214.SizeWeight26 = Children(i).Data
   Case "SIZEWEIGHT27":z7214.SizeWeight27 = Children(i).Data
   Case "SIZEWEIGHT28":z7214.SizeWeight28 = Children(i).Data
   Case "SIZEWEIGHT29":z7214.SizeWeight29 = Children(i).Data
   Case "SIZEWEIGHT30":z7214.SizeWeight30 = Children(i).Data
   Case "DATEINSERT":z7214.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7214.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7214.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7214.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7214.CheckUse = Children(i).Data
   Case "CHECKCOMPLETE":z7214.CheckComplete = Children(i).Data
   Case "REMARK":z7214.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7214_MOVE",vbCritical)
End Try
End Function 
    
End Module 
