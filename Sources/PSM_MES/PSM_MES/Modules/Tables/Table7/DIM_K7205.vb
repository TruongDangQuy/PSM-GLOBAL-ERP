'=========================================================================================================================================================
'   TABLE : (PFK7205)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7205

Structure T7205_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	ShoesCode	 AS String	'			char(6)		*
Public 	seSizeGroup	 AS String	'			char(3)		*
Public 	cdSizeGroup	 AS String	'			char(3)		*
Public 	GradingName	 AS String	'			nvarchar(50)
Public 	Size01	 AS String	'			nvarchar(6)
Public 	Size02	 AS String	'			nvarchar(6)
Public 	Size03	 AS String	'			nvarchar(6)
Public 	Size04	 AS String	'			nvarchar(6)
Public 	Size05	 AS String	'			nvarchar(6)
Public 	Size06	 AS String	'			nvarchar(6)
Public 	Size07	 AS String	'			nvarchar(6)
Public 	Size08	 AS String	'			nvarchar(6)
Public 	Size09	 AS String	'			nvarchar(6)
Public 	Size10	 AS String	'			nvarchar(6)
Public 	Size11	 AS String	'			nvarchar(6)
Public 	Size12	 AS String	'			nvarchar(6)
Public 	Size13	 AS String	'			nvarchar(6)
Public 	Size14	 AS String	'			nvarchar(6)
Public 	Size15	 AS String	'			nvarchar(6)
Public 	Size16	 AS String	'			nvarchar(6)
Public 	Size17	 AS String	'			nvarchar(6)
Public 	Size18	 AS String	'			nvarchar(6)
Public 	Size19	 AS String	'			nvarchar(6)
Public 	Size20	 AS String	'			nvarchar(6)
Public 	Size21	 AS String	'			nvarchar(6)
Public 	Size22	 AS String	'			nvarchar(6)
Public 	Size23	 AS String	'			nvarchar(6)
Public 	Size24	 AS String	'			nvarchar(6)
Public 	Size25	 AS String	'			nvarchar(6)
Public 	Size26	 AS String	'			nvarchar(6)
Public 	Size27	 AS String	'			nvarchar(6)
Public 	Size28	 AS String	'			nvarchar(6)
Public 	Size29	 AS String	'			nvarchar(6)
Public 	Size30	 AS String	'			nvarchar(6)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	CheckUse	 AS String	'			char(1)
Public 	CheckComplete	 AS String	'			char(1)
Public 	CheckCondition	 AS String	'			char(1)
Public 	Remark	 AS String	'			nvarchar(50)
'=========================================================================================================================================================
End structure

Public D7205 As T7205_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7205(SHOESCODE AS String, SESIZEGROUP AS String, CDSIZEGROUP AS String) As Boolean
    READ_PFK7205 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7205 "
    SQL = SQL & " WHERE K7205_ShoesCode		 = '" & ShoesCode & "' " 
    SQL = SQL & "   AND K7205_seSizeGroup		 = '" & seSizeGroup & "' " 
    SQL = SQL & "   AND K7205_cdSizeGroup		 = '" & cdSizeGroup & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7205_CLEAR: GoTo SKIP_READ_PFK7205
                
    Call K7205_MOVE(rd)
    READ_PFK7205 = True

SKIP_READ_PFK7205:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7205",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7205(SHOESCODE AS String, SESIZEGROUP AS String, CDSIZEGROUP AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7205 "
    SQL = SQL & " WHERE K7205_ShoesCode		 = '" & ShoesCode & "' " 
    SQL = SQL & "   AND K7205_seSizeGroup		 = '" & seSizeGroup & "' " 
    SQL = SQL & "   AND K7205_cdSizeGroup		 = '" & cdSizeGroup & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7205",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7205(z7205 As T7205_AREA) As Boolean
    WRITE_PFK7205 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7205)
 
    SQL = " INSERT INTO PFK7205 "
    SQL = SQL & " ( "
    SQL = SQL & " K7205_ShoesCode," 
    SQL = SQL & " K7205_seSizeGroup," 
    SQL = SQL & " K7205_cdSizeGroup," 
    SQL = SQL & " K7205_GradingName," 
    SQL = SQL & " K7205_Size01," 
    SQL = SQL & " K7205_Size02," 
    SQL = SQL & " K7205_Size03," 
    SQL = SQL & " K7205_Size04," 
    SQL = SQL & " K7205_Size05," 
    SQL = SQL & " K7205_Size06," 
    SQL = SQL & " K7205_Size07," 
    SQL = SQL & " K7205_Size08," 
    SQL = SQL & " K7205_Size09," 
    SQL = SQL & " K7205_Size10," 
    SQL = SQL & " K7205_Size11," 
    SQL = SQL & " K7205_Size12," 
    SQL = SQL & " K7205_Size13," 
    SQL = SQL & " K7205_Size14," 
    SQL = SQL & " K7205_Size15," 
    SQL = SQL & " K7205_Size16," 
    SQL = SQL & " K7205_Size17," 
    SQL = SQL & " K7205_Size18," 
    SQL = SQL & " K7205_Size19," 
    SQL = SQL & " K7205_Size20," 
    SQL = SQL & " K7205_Size21," 
    SQL = SQL & " K7205_Size22," 
    SQL = SQL & " K7205_Size23," 
    SQL = SQL & " K7205_Size24," 
    SQL = SQL & " K7205_Size25," 
    SQL = SQL & " K7205_Size26," 
    SQL = SQL & " K7205_Size27," 
    SQL = SQL & " K7205_Size28," 
    SQL = SQL & " K7205_Size29," 
    SQL = SQL & " K7205_Size30," 
    SQL = SQL & " K7205_DateInsert," 
    SQL = SQL & " K7205_DateUpdate," 
    SQL = SQL & " K7205_InchargeInsert," 
    SQL = SQL & " K7205_InchargeUpdate," 
    SQL = SQL & " K7205_CheckUse," 
    SQL = SQL & " K7205_CheckComplete," 
    SQL = SQL & " K7205_CheckCondition," 
    SQL = SQL & " K7205_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7205.ShoesCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.seSizeGroup) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.cdSizeGroup) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.GradingName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.Size01) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.Size02) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.Size03) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.Size04) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.Size05) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.Size06) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.Size07) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.Size08) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.Size09) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.Size10) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.Size11) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.Size12) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.Size13) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.Size14) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.Size15) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.Size16) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.Size17) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.Size18) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.Size19) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.Size20) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.Size21) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.Size22) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.Size23) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.Size24) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.Size25) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.Size26) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.Size27) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.Size28) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.Size29) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.Size30) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.CheckUse) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.CheckComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.CheckCondition) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7205.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7205 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7205",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7205(z7205 As T7205_AREA) As Boolean
    REWRITE_PFK7205 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7205)
   
    SQL = " UPDATE PFK7205 SET "
    SQL = SQL & "    K7205_GradingName      = N'" & FormatSQL(z7205.GradingName) & "', " 
    SQL = SQL & "    K7205_Size01      = N'" & FormatSQL(z7205.Size01) & "', " 
    SQL = SQL & "    K7205_Size02      = N'" & FormatSQL(z7205.Size02) & "', " 
    SQL = SQL & "    K7205_Size03      = N'" & FormatSQL(z7205.Size03) & "', " 
    SQL = SQL & "    K7205_Size04      = N'" & FormatSQL(z7205.Size04) & "', " 
    SQL = SQL & "    K7205_Size05      = N'" & FormatSQL(z7205.Size05) & "', " 
    SQL = SQL & "    K7205_Size06      = N'" & FormatSQL(z7205.Size06) & "', " 
    SQL = SQL & "    K7205_Size07      = N'" & FormatSQL(z7205.Size07) & "', " 
    SQL = SQL & "    K7205_Size08      = N'" & FormatSQL(z7205.Size08) & "', " 
    SQL = SQL & "    K7205_Size09      = N'" & FormatSQL(z7205.Size09) & "', " 
    SQL = SQL & "    K7205_Size10      = N'" & FormatSQL(z7205.Size10) & "', " 
    SQL = SQL & "    K7205_Size11      = N'" & FormatSQL(z7205.Size11) & "', " 
    SQL = SQL & "    K7205_Size12      = N'" & FormatSQL(z7205.Size12) & "', " 
    SQL = SQL & "    K7205_Size13      = N'" & FormatSQL(z7205.Size13) & "', " 
    SQL = SQL & "    K7205_Size14      = N'" & FormatSQL(z7205.Size14) & "', " 
    SQL = SQL & "    K7205_Size15      = N'" & FormatSQL(z7205.Size15) & "', " 
    SQL = SQL & "    K7205_Size16      = N'" & FormatSQL(z7205.Size16) & "', " 
    SQL = SQL & "    K7205_Size17      = N'" & FormatSQL(z7205.Size17) & "', " 
    SQL = SQL & "    K7205_Size18      = N'" & FormatSQL(z7205.Size18) & "', " 
    SQL = SQL & "    K7205_Size19      = N'" & FormatSQL(z7205.Size19) & "', " 
    SQL = SQL & "    K7205_Size20      = N'" & FormatSQL(z7205.Size20) & "', " 
    SQL = SQL & "    K7205_Size21      = N'" & FormatSQL(z7205.Size21) & "', " 
    SQL = SQL & "    K7205_Size22      = N'" & FormatSQL(z7205.Size22) & "', " 
    SQL = SQL & "    K7205_Size23      = N'" & FormatSQL(z7205.Size23) & "', " 
    SQL = SQL & "    K7205_Size24      = N'" & FormatSQL(z7205.Size24) & "', " 
    SQL = SQL & "    K7205_Size25      = N'" & FormatSQL(z7205.Size25) & "', " 
    SQL = SQL & "    K7205_Size26      = N'" & FormatSQL(z7205.Size26) & "', " 
    SQL = SQL & "    K7205_Size27      = N'" & FormatSQL(z7205.Size27) & "', " 
    SQL = SQL & "    K7205_Size28      = N'" & FormatSQL(z7205.Size28) & "', " 
    SQL = SQL & "    K7205_Size29      = N'" & FormatSQL(z7205.Size29) & "', " 
    SQL = SQL & "    K7205_Size30      = N'" & FormatSQL(z7205.Size30) & "', " 
    SQL = SQL & "    K7205_DateInsert      = N'" & FormatSQL(z7205.DateInsert) & "', " 
    SQL = SQL & "    K7205_DateUpdate      = N'" & FormatSQL(z7205.DateUpdate) & "', " 
    SQL = SQL & "    K7205_InchargeInsert      = N'" & FormatSQL(z7205.InchargeInsert) & "', " 
    SQL = SQL & "    K7205_InchargeUpdate      = N'" & FormatSQL(z7205.InchargeUpdate) & "', " 
    SQL = SQL & "    K7205_CheckUse      = N'" & FormatSQL(z7205.CheckUse) & "', " 
    SQL = SQL & "    K7205_CheckComplete      = N'" & FormatSQL(z7205.CheckComplete) & "', " 
    SQL = SQL & "    K7205_CheckCondition      = N'" & FormatSQL(z7205.CheckCondition) & "', " 
    SQL = SQL & "    K7205_Remark      = N'" & FormatSQL(z7205.Remark) & "'  " 
    SQL = SQL & " WHERE K7205_ShoesCode		 = '" & z7205.ShoesCode & "' " 
    SQL = SQL & "   AND K7205_seSizeGroup		 = '" & z7205.seSizeGroup & "' " 
    SQL = SQL & "   AND K7205_cdSizeGroup		 = '" & z7205.cdSizeGroup & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7205 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7205",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7205(z7205 As T7205_AREA) As Boolean
    DELETE_PFK7205 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7205 "
    SQL = SQL & " WHERE K7205_ShoesCode		 = '" & z7205.ShoesCode & "' " 
    SQL = SQL & "   AND K7205_seSizeGroup		 = '" & z7205.seSizeGroup & "' " 
    SQL = SQL & "   AND K7205_cdSizeGroup		 = '" & z7205.cdSizeGroup & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7205 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7205",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7205_CLEAR()
Try
    
   D7205.ShoesCode = ""
   D7205.seSizeGroup = ""
   D7205.cdSizeGroup = ""
   D7205.GradingName = ""
   D7205.Size01 = ""
   D7205.Size02 = ""
   D7205.Size03 = ""
   D7205.Size04 = ""
   D7205.Size05 = ""
   D7205.Size06 = ""
   D7205.Size07 = ""
   D7205.Size08 = ""
   D7205.Size09 = ""
   D7205.Size10 = ""
   D7205.Size11 = ""
   D7205.Size12 = ""
   D7205.Size13 = ""
   D7205.Size14 = ""
   D7205.Size15 = ""
   D7205.Size16 = ""
   D7205.Size17 = ""
   D7205.Size18 = ""
   D7205.Size19 = ""
   D7205.Size20 = ""
   D7205.Size21 = ""
   D7205.Size22 = ""
   D7205.Size23 = ""
   D7205.Size24 = ""
   D7205.Size25 = ""
   D7205.Size26 = ""
   D7205.Size27 = ""
   D7205.Size28 = ""
   D7205.Size29 = ""
   D7205.Size30 = ""
   D7205.DateInsert = ""
   D7205.DateUpdate = ""
   D7205.InchargeInsert = ""
   D7205.InchargeUpdate = ""
   D7205.CheckUse = ""
   D7205.CheckComplete = ""
   D7205.CheckCondition = ""
   D7205.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7205_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7205 As T7205_AREA)
Try
    
    x7205.ShoesCode = trim$(  x7205.ShoesCode)
    x7205.seSizeGroup = trim$(  x7205.seSizeGroup)
    x7205.cdSizeGroup = trim$(  x7205.cdSizeGroup)
    x7205.GradingName = trim$(  x7205.GradingName)
    x7205.Size01 = trim$(  x7205.Size01)
    x7205.Size02 = trim$(  x7205.Size02)
    x7205.Size03 = trim$(  x7205.Size03)
    x7205.Size04 = trim$(  x7205.Size04)
    x7205.Size05 = trim$(  x7205.Size05)
    x7205.Size06 = trim$(  x7205.Size06)
    x7205.Size07 = trim$(  x7205.Size07)
    x7205.Size08 = trim$(  x7205.Size08)
    x7205.Size09 = trim$(  x7205.Size09)
    x7205.Size10 = trim$(  x7205.Size10)
    x7205.Size11 = trim$(  x7205.Size11)
    x7205.Size12 = trim$(  x7205.Size12)
    x7205.Size13 = trim$(  x7205.Size13)
    x7205.Size14 = trim$(  x7205.Size14)
    x7205.Size15 = trim$(  x7205.Size15)
    x7205.Size16 = trim$(  x7205.Size16)
    x7205.Size17 = trim$(  x7205.Size17)
    x7205.Size18 = trim$(  x7205.Size18)
    x7205.Size19 = trim$(  x7205.Size19)
    x7205.Size20 = trim$(  x7205.Size20)
    x7205.Size21 = trim$(  x7205.Size21)
    x7205.Size22 = trim$(  x7205.Size22)
    x7205.Size23 = trim$(  x7205.Size23)
    x7205.Size24 = trim$(  x7205.Size24)
    x7205.Size25 = trim$(  x7205.Size25)
    x7205.Size26 = trim$(  x7205.Size26)
    x7205.Size27 = trim$(  x7205.Size27)
    x7205.Size28 = trim$(  x7205.Size28)
    x7205.Size29 = trim$(  x7205.Size29)
    x7205.Size30 = trim$(  x7205.Size30)
    x7205.DateInsert = trim$(  x7205.DateInsert)
    x7205.DateUpdate = trim$(  x7205.DateUpdate)
    x7205.InchargeInsert = trim$(  x7205.InchargeInsert)
    x7205.InchargeUpdate = trim$(  x7205.InchargeUpdate)
    x7205.CheckUse = trim$(  x7205.CheckUse)
    x7205.CheckComplete = trim$(  x7205.CheckComplete)
    x7205.CheckCondition = trim$(  x7205.CheckCondition)
    x7205.Remark = trim$(  x7205.Remark)
     
    If trim$( x7205.ShoesCode ) = "" Then x7205.ShoesCode = Space(1) 
    If trim$( x7205.seSizeGroup ) = "" Then x7205.seSizeGroup = Space(1) 
    If trim$( x7205.cdSizeGroup ) = "" Then x7205.cdSizeGroup = Space(1) 
    If trim$( x7205.GradingName ) = "" Then x7205.GradingName = Space(1) 
    If trim$( x7205.Size01 ) = "" Then x7205.Size01 = Space(1) 
    If trim$( x7205.Size02 ) = "" Then x7205.Size02 = Space(1) 
    If trim$( x7205.Size03 ) = "" Then x7205.Size03 = Space(1) 
    If trim$( x7205.Size04 ) = "" Then x7205.Size04 = Space(1) 
    If trim$( x7205.Size05 ) = "" Then x7205.Size05 = Space(1) 
    If trim$( x7205.Size06 ) = "" Then x7205.Size06 = Space(1) 
    If trim$( x7205.Size07 ) = "" Then x7205.Size07 = Space(1) 
    If trim$( x7205.Size08 ) = "" Then x7205.Size08 = Space(1) 
    If trim$( x7205.Size09 ) = "" Then x7205.Size09 = Space(1) 
    If trim$( x7205.Size10 ) = "" Then x7205.Size10 = Space(1) 
    If trim$( x7205.Size11 ) = "" Then x7205.Size11 = Space(1) 
    If trim$( x7205.Size12 ) = "" Then x7205.Size12 = Space(1) 
    If trim$( x7205.Size13 ) = "" Then x7205.Size13 = Space(1) 
    If trim$( x7205.Size14 ) = "" Then x7205.Size14 = Space(1) 
    If trim$( x7205.Size15 ) = "" Then x7205.Size15 = Space(1) 
    If trim$( x7205.Size16 ) = "" Then x7205.Size16 = Space(1) 
    If trim$( x7205.Size17 ) = "" Then x7205.Size17 = Space(1) 
    If trim$( x7205.Size18 ) = "" Then x7205.Size18 = Space(1) 
    If trim$( x7205.Size19 ) = "" Then x7205.Size19 = Space(1) 
    If trim$( x7205.Size20 ) = "" Then x7205.Size20 = Space(1) 
    If trim$( x7205.Size21 ) = "" Then x7205.Size21 = Space(1) 
    If trim$( x7205.Size22 ) = "" Then x7205.Size22 = Space(1) 
    If trim$( x7205.Size23 ) = "" Then x7205.Size23 = Space(1) 
    If trim$( x7205.Size24 ) = "" Then x7205.Size24 = Space(1) 
    If trim$( x7205.Size25 ) = "" Then x7205.Size25 = Space(1) 
    If trim$( x7205.Size26 ) = "" Then x7205.Size26 = Space(1) 
    If trim$( x7205.Size27 ) = "" Then x7205.Size27 = Space(1) 
    If trim$( x7205.Size28 ) = "" Then x7205.Size28 = Space(1) 
    If trim$( x7205.Size29 ) = "" Then x7205.Size29 = Space(1) 
    If trim$( x7205.Size30 ) = "" Then x7205.Size30 = Space(1) 
    If trim$( x7205.DateInsert ) = "" Then x7205.DateInsert = Space(1) 
    If trim$( x7205.DateUpdate ) = "" Then x7205.DateUpdate = Space(1) 
    If trim$( x7205.InchargeInsert ) = "" Then x7205.InchargeInsert = Space(1) 
    If trim$( x7205.InchargeUpdate ) = "" Then x7205.InchargeUpdate = Space(1) 
    If trim$( x7205.CheckUse ) = "" Then x7205.CheckUse = Space(1) 
    If trim$( x7205.CheckComplete ) = "" Then x7205.CheckComplete = Space(1) 
    If trim$( x7205.CheckCondition ) = "" Then x7205.CheckCondition = Space(1) 
    If trim$( x7205.Remark ) = "" Then x7205.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7205_MOVE(rs7205 As SqlClient.SqlDataReader)
Try

    call D7205_CLEAR()   

    If IsdbNull(rs7205!K7205_ShoesCode) = False Then D7205.ShoesCode = Trim$(rs7205!K7205_ShoesCode)
    If IsdbNull(rs7205!K7205_seSizeGroup) = False Then D7205.seSizeGroup = Trim$(rs7205!K7205_seSizeGroup)
    If IsdbNull(rs7205!K7205_cdSizeGroup) = False Then D7205.cdSizeGroup = Trim$(rs7205!K7205_cdSizeGroup)
    If IsdbNull(rs7205!K7205_GradingName) = False Then D7205.GradingName = Trim$(rs7205!K7205_GradingName)
    If IsdbNull(rs7205!K7205_Size01) = False Then D7205.Size01 = Trim$(rs7205!K7205_Size01)
    If IsdbNull(rs7205!K7205_Size02) = False Then D7205.Size02 = Trim$(rs7205!K7205_Size02)
    If IsdbNull(rs7205!K7205_Size03) = False Then D7205.Size03 = Trim$(rs7205!K7205_Size03)
    If IsdbNull(rs7205!K7205_Size04) = False Then D7205.Size04 = Trim$(rs7205!K7205_Size04)
    If IsdbNull(rs7205!K7205_Size05) = False Then D7205.Size05 = Trim$(rs7205!K7205_Size05)
    If IsdbNull(rs7205!K7205_Size06) = False Then D7205.Size06 = Trim$(rs7205!K7205_Size06)
    If IsdbNull(rs7205!K7205_Size07) = False Then D7205.Size07 = Trim$(rs7205!K7205_Size07)
    If IsdbNull(rs7205!K7205_Size08) = False Then D7205.Size08 = Trim$(rs7205!K7205_Size08)
    If IsdbNull(rs7205!K7205_Size09) = False Then D7205.Size09 = Trim$(rs7205!K7205_Size09)
    If IsdbNull(rs7205!K7205_Size10) = False Then D7205.Size10 = Trim$(rs7205!K7205_Size10)
    If IsdbNull(rs7205!K7205_Size11) = False Then D7205.Size11 = Trim$(rs7205!K7205_Size11)
    If IsdbNull(rs7205!K7205_Size12) = False Then D7205.Size12 = Trim$(rs7205!K7205_Size12)
    If IsdbNull(rs7205!K7205_Size13) = False Then D7205.Size13 = Trim$(rs7205!K7205_Size13)
    If IsdbNull(rs7205!K7205_Size14) = False Then D7205.Size14 = Trim$(rs7205!K7205_Size14)
    If IsdbNull(rs7205!K7205_Size15) = False Then D7205.Size15 = Trim$(rs7205!K7205_Size15)
    If IsdbNull(rs7205!K7205_Size16) = False Then D7205.Size16 = Trim$(rs7205!K7205_Size16)
    If IsdbNull(rs7205!K7205_Size17) = False Then D7205.Size17 = Trim$(rs7205!K7205_Size17)
    If IsdbNull(rs7205!K7205_Size18) = False Then D7205.Size18 = Trim$(rs7205!K7205_Size18)
    If IsdbNull(rs7205!K7205_Size19) = False Then D7205.Size19 = Trim$(rs7205!K7205_Size19)
    If IsdbNull(rs7205!K7205_Size20) = False Then D7205.Size20 = Trim$(rs7205!K7205_Size20)
    If IsdbNull(rs7205!K7205_Size21) = False Then D7205.Size21 = Trim$(rs7205!K7205_Size21)
    If IsdbNull(rs7205!K7205_Size22) = False Then D7205.Size22 = Trim$(rs7205!K7205_Size22)
    If IsdbNull(rs7205!K7205_Size23) = False Then D7205.Size23 = Trim$(rs7205!K7205_Size23)
    If IsdbNull(rs7205!K7205_Size24) = False Then D7205.Size24 = Trim$(rs7205!K7205_Size24)
    If IsdbNull(rs7205!K7205_Size25) = False Then D7205.Size25 = Trim$(rs7205!K7205_Size25)
    If IsdbNull(rs7205!K7205_Size26) = False Then D7205.Size26 = Trim$(rs7205!K7205_Size26)
    If IsdbNull(rs7205!K7205_Size27) = False Then D7205.Size27 = Trim$(rs7205!K7205_Size27)
    If IsdbNull(rs7205!K7205_Size28) = False Then D7205.Size28 = Trim$(rs7205!K7205_Size28)
    If IsdbNull(rs7205!K7205_Size29) = False Then D7205.Size29 = Trim$(rs7205!K7205_Size29)
    If IsdbNull(rs7205!K7205_Size30) = False Then D7205.Size30 = Trim$(rs7205!K7205_Size30)
    If IsdbNull(rs7205!K7205_DateInsert) = False Then D7205.DateInsert = Trim$(rs7205!K7205_DateInsert)
    If IsdbNull(rs7205!K7205_DateUpdate) = False Then D7205.DateUpdate = Trim$(rs7205!K7205_DateUpdate)
    If IsdbNull(rs7205!K7205_InchargeInsert) = False Then D7205.InchargeInsert = Trim$(rs7205!K7205_InchargeInsert)
    If IsdbNull(rs7205!K7205_InchargeUpdate) = False Then D7205.InchargeUpdate = Trim$(rs7205!K7205_InchargeUpdate)
    If IsdbNull(rs7205!K7205_CheckUse) = False Then D7205.CheckUse = Trim$(rs7205!K7205_CheckUse)
    If IsdbNull(rs7205!K7205_CheckComplete) = False Then D7205.CheckComplete = Trim$(rs7205!K7205_CheckComplete)
    If IsdbNull(rs7205!K7205_CheckCondition) = False Then D7205.CheckCondition = Trim$(rs7205!K7205_CheckCondition)
    If IsdbNull(rs7205!K7205_Remark) = False Then D7205.Remark = Trim$(rs7205!K7205_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7205_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7205_MOVE(rs7205 As DataRow)
Try

    call D7205_CLEAR()   

    If IsdbNull(rs7205!K7205_ShoesCode) = False Then D7205.ShoesCode = Trim$(rs7205!K7205_ShoesCode)
    If IsdbNull(rs7205!K7205_seSizeGroup) = False Then D7205.seSizeGroup = Trim$(rs7205!K7205_seSizeGroup)
    If IsdbNull(rs7205!K7205_cdSizeGroup) = False Then D7205.cdSizeGroup = Trim$(rs7205!K7205_cdSizeGroup)
    If IsdbNull(rs7205!K7205_GradingName) = False Then D7205.GradingName = Trim$(rs7205!K7205_GradingName)
    If IsdbNull(rs7205!K7205_Size01) = False Then D7205.Size01 = Trim$(rs7205!K7205_Size01)
    If IsdbNull(rs7205!K7205_Size02) = False Then D7205.Size02 = Trim$(rs7205!K7205_Size02)
    If IsdbNull(rs7205!K7205_Size03) = False Then D7205.Size03 = Trim$(rs7205!K7205_Size03)
    If IsdbNull(rs7205!K7205_Size04) = False Then D7205.Size04 = Trim$(rs7205!K7205_Size04)
    If IsdbNull(rs7205!K7205_Size05) = False Then D7205.Size05 = Trim$(rs7205!K7205_Size05)
    If IsdbNull(rs7205!K7205_Size06) = False Then D7205.Size06 = Trim$(rs7205!K7205_Size06)
    If IsdbNull(rs7205!K7205_Size07) = False Then D7205.Size07 = Trim$(rs7205!K7205_Size07)
    If IsdbNull(rs7205!K7205_Size08) = False Then D7205.Size08 = Trim$(rs7205!K7205_Size08)
    If IsdbNull(rs7205!K7205_Size09) = False Then D7205.Size09 = Trim$(rs7205!K7205_Size09)
    If IsdbNull(rs7205!K7205_Size10) = False Then D7205.Size10 = Trim$(rs7205!K7205_Size10)
    If IsdbNull(rs7205!K7205_Size11) = False Then D7205.Size11 = Trim$(rs7205!K7205_Size11)
    If IsdbNull(rs7205!K7205_Size12) = False Then D7205.Size12 = Trim$(rs7205!K7205_Size12)
    If IsdbNull(rs7205!K7205_Size13) = False Then D7205.Size13 = Trim$(rs7205!K7205_Size13)
    If IsdbNull(rs7205!K7205_Size14) = False Then D7205.Size14 = Trim$(rs7205!K7205_Size14)
    If IsdbNull(rs7205!K7205_Size15) = False Then D7205.Size15 = Trim$(rs7205!K7205_Size15)
    If IsdbNull(rs7205!K7205_Size16) = False Then D7205.Size16 = Trim$(rs7205!K7205_Size16)
    If IsdbNull(rs7205!K7205_Size17) = False Then D7205.Size17 = Trim$(rs7205!K7205_Size17)
    If IsdbNull(rs7205!K7205_Size18) = False Then D7205.Size18 = Trim$(rs7205!K7205_Size18)
    If IsdbNull(rs7205!K7205_Size19) = False Then D7205.Size19 = Trim$(rs7205!K7205_Size19)
    If IsdbNull(rs7205!K7205_Size20) = False Then D7205.Size20 = Trim$(rs7205!K7205_Size20)
    If IsdbNull(rs7205!K7205_Size21) = False Then D7205.Size21 = Trim$(rs7205!K7205_Size21)
    If IsdbNull(rs7205!K7205_Size22) = False Then D7205.Size22 = Trim$(rs7205!K7205_Size22)
    If IsdbNull(rs7205!K7205_Size23) = False Then D7205.Size23 = Trim$(rs7205!K7205_Size23)
    If IsdbNull(rs7205!K7205_Size24) = False Then D7205.Size24 = Trim$(rs7205!K7205_Size24)
    If IsdbNull(rs7205!K7205_Size25) = False Then D7205.Size25 = Trim$(rs7205!K7205_Size25)
    If IsdbNull(rs7205!K7205_Size26) = False Then D7205.Size26 = Trim$(rs7205!K7205_Size26)
    If IsdbNull(rs7205!K7205_Size27) = False Then D7205.Size27 = Trim$(rs7205!K7205_Size27)
    If IsdbNull(rs7205!K7205_Size28) = False Then D7205.Size28 = Trim$(rs7205!K7205_Size28)
    If IsdbNull(rs7205!K7205_Size29) = False Then D7205.Size29 = Trim$(rs7205!K7205_Size29)
    If IsdbNull(rs7205!K7205_Size30) = False Then D7205.Size30 = Trim$(rs7205!K7205_Size30)
    If IsdbNull(rs7205!K7205_DateInsert) = False Then D7205.DateInsert = Trim$(rs7205!K7205_DateInsert)
    If IsdbNull(rs7205!K7205_DateUpdate) = False Then D7205.DateUpdate = Trim$(rs7205!K7205_DateUpdate)
    If IsdbNull(rs7205!K7205_InchargeInsert) = False Then D7205.InchargeInsert = Trim$(rs7205!K7205_InchargeInsert)
    If IsdbNull(rs7205!K7205_InchargeUpdate) = False Then D7205.InchargeUpdate = Trim$(rs7205!K7205_InchargeUpdate)
    If IsdbNull(rs7205!K7205_CheckUse) = False Then D7205.CheckUse = Trim$(rs7205!K7205_CheckUse)
    If IsdbNull(rs7205!K7205_CheckComplete) = False Then D7205.CheckComplete = Trim$(rs7205!K7205_CheckComplete)
    If IsdbNull(rs7205!K7205_CheckCondition) = False Then D7205.CheckCondition = Trim$(rs7205!K7205_CheckCondition)
    If IsdbNull(rs7205!K7205_Remark) = False Then D7205.Remark = Trim$(rs7205!K7205_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7205_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7205_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7205 As T7205_AREA, SHOESCODE AS String, SESIZEGROUP AS String, CDSIZEGROUP AS String) as Boolean

K7205_MOVE = False

Try
    If READ_PFK7205(SHOESCODE, SESIZEGROUP, CDSIZEGROUP) = True Then
                z7205 = D7205
		K7205_MOVE = True
		else
	z7205 = nothing
     End If

     If  getColumIndex(spr,"ShoesCode") > -1 then z7205.ShoesCode = getDataM(spr, getColumIndex(spr,"ShoesCode"), xRow)
     If  getColumIndex(spr,"seSizeGroup") > -1 then z7205.seSizeGroup = getDataM(spr, getColumIndex(spr,"seSizeGroup"), xRow)
     If  getColumIndex(spr,"cdSizeGroup") > -1 then z7205.cdSizeGroup = getDataM(spr, getColumIndex(spr,"cdSizeGroup"), xRow)
     If  getColumIndex(spr,"GradingName") > -1 then z7205.GradingName = getDataM(spr, getColumIndex(spr,"GradingName"), xRow)
     If  getColumIndex(spr,"Size01") > -1 then z7205.Size01 = getDataM(spr, getColumIndex(spr,"Size01"), xRow)
     If  getColumIndex(spr,"Size02") > -1 then z7205.Size02 = getDataM(spr, getColumIndex(spr,"Size02"), xRow)
     If  getColumIndex(spr,"Size03") > -1 then z7205.Size03 = getDataM(spr, getColumIndex(spr,"Size03"), xRow)
     If  getColumIndex(spr,"Size04") > -1 then z7205.Size04 = getDataM(spr, getColumIndex(spr,"Size04"), xRow)
     If  getColumIndex(spr,"Size05") > -1 then z7205.Size05 = getDataM(spr, getColumIndex(spr,"Size05"), xRow)
     If  getColumIndex(spr,"Size06") > -1 then z7205.Size06 = getDataM(spr, getColumIndex(spr,"Size06"), xRow)
     If  getColumIndex(spr,"Size07") > -1 then z7205.Size07 = getDataM(spr, getColumIndex(spr,"Size07"), xRow)
     If  getColumIndex(spr,"Size08") > -1 then z7205.Size08 = getDataM(spr, getColumIndex(spr,"Size08"), xRow)
     If  getColumIndex(spr,"Size09") > -1 then z7205.Size09 = getDataM(spr, getColumIndex(spr,"Size09"), xRow)
     If  getColumIndex(spr,"Size10") > -1 then z7205.Size10 = getDataM(spr, getColumIndex(spr,"Size10"), xRow)
     If  getColumIndex(spr,"Size11") > -1 then z7205.Size11 = getDataM(spr, getColumIndex(spr,"Size11"), xRow)
     If  getColumIndex(spr,"Size12") > -1 then z7205.Size12 = getDataM(spr, getColumIndex(spr,"Size12"), xRow)
     If  getColumIndex(spr,"Size13") > -1 then z7205.Size13 = getDataM(spr, getColumIndex(spr,"Size13"), xRow)
     If  getColumIndex(spr,"Size14") > -1 then z7205.Size14 = getDataM(spr, getColumIndex(spr,"Size14"), xRow)
     If  getColumIndex(spr,"Size15") > -1 then z7205.Size15 = getDataM(spr, getColumIndex(spr,"Size15"), xRow)
     If  getColumIndex(spr,"Size16") > -1 then z7205.Size16 = getDataM(spr, getColumIndex(spr,"Size16"), xRow)
     If  getColumIndex(spr,"Size17") > -1 then z7205.Size17 = getDataM(spr, getColumIndex(spr,"Size17"), xRow)
     If  getColumIndex(spr,"Size18") > -1 then z7205.Size18 = getDataM(spr, getColumIndex(spr,"Size18"), xRow)
     If  getColumIndex(spr,"Size19") > -1 then z7205.Size19 = getDataM(spr, getColumIndex(spr,"Size19"), xRow)
     If  getColumIndex(spr,"Size20") > -1 then z7205.Size20 = getDataM(spr, getColumIndex(spr,"Size20"), xRow)
     If  getColumIndex(spr,"Size21") > -1 then z7205.Size21 = getDataM(spr, getColumIndex(spr,"Size21"), xRow)
     If  getColumIndex(spr,"Size22") > -1 then z7205.Size22 = getDataM(spr, getColumIndex(spr,"Size22"), xRow)
     If  getColumIndex(spr,"Size23") > -1 then z7205.Size23 = getDataM(spr, getColumIndex(spr,"Size23"), xRow)
     If  getColumIndex(spr,"Size24") > -1 then z7205.Size24 = getDataM(spr, getColumIndex(spr,"Size24"), xRow)
     If  getColumIndex(spr,"Size25") > -1 then z7205.Size25 = getDataM(spr, getColumIndex(spr,"Size25"), xRow)
     If  getColumIndex(spr,"Size26") > -1 then z7205.Size26 = getDataM(spr, getColumIndex(spr,"Size26"), xRow)
     If  getColumIndex(spr,"Size27") > -1 then z7205.Size27 = getDataM(spr, getColumIndex(spr,"Size27"), xRow)
     If  getColumIndex(spr,"Size28") > -1 then z7205.Size28 = getDataM(spr, getColumIndex(spr,"Size28"), xRow)
     If  getColumIndex(spr,"Size29") > -1 then z7205.Size29 = getDataM(spr, getColumIndex(spr,"Size29"), xRow)
     If  getColumIndex(spr,"Size30") > -1 then z7205.Size30 = getDataM(spr, getColumIndex(spr,"Size30"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7205.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7205.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7205.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7205.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7205.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z7205.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"CheckCondition") > -1 then z7205.CheckCondition = getDataM(spr, getColumIndex(spr,"CheckCondition"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7205.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7205_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7205_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7205 As T7205_AREA,CheckClear as Boolean,SHOESCODE AS String, SESIZEGROUP AS String, CDSIZEGROUP AS String) as Boolean

K7205_MOVE = False

Try
    If READ_PFK7205(SHOESCODE, SESIZEGROUP, CDSIZEGROUP) = True Then
                z7205 = D7205
		K7205_MOVE = True
		else
	If CheckClear  = True then z7205 = nothing
     End If

     If  getColumIndex(spr,"ShoesCode") > -1 then z7205.ShoesCode = getDataM(spr, getColumIndex(spr,"ShoesCode"), xRow)
     If  getColumIndex(spr,"seSizeGroup") > -1 then z7205.seSizeGroup = getDataM(spr, getColumIndex(spr,"seSizeGroup"), xRow)
     If  getColumIndex(spr,"cdSizeGroup") > -1 then z7205.cdSizeGroup = getDataM(spr, getColumIndex(spr,"cdSizeGroup"), xRow)
     If  getColumIndex(spr,"GradingName") > -1 then z7205.GradingName = getDataM(spr, getColumIndex(spr,"GradingName"), xRow)
     If  getColumIndex(spr,"Size01") > -1 then z7205.Size01 = getDataM(spr, getColumIndex(spr,"Size01"), xRow)
     If  getColumIndex(spr,"Size02") > -1 then z7205.Size02 = getDataM(spr, getColumIndex(spr,"Size02"), xRow)
     If  getColumIndex(spr,"Size03") > -1 then z7205.Size03 = getDataM(spr, getColumIndex(spr,"Size03"), xRow)
     If  getColumIndex(spr,"Size04") > -1 then z7205.Size04 = getDataM(spr, getColumIndex(spr,"Size04"), xRow)
     If  getColumIndex(spr,"Size05") > -1 then z7205.Size05 = getDataM(spr, getColumIndex(spr,"Size05"), xRow)
     If  getColumIndex(spr,"Size06") > -1 then z7205.Size06 = getDataM(spr, getColumIndex(spr,"Size06"), xRow)
     If  getColumIndex(spr,"Size07") > -1 then z7205.Size07 = getDataM(spr, getColumIndex(spr,"Size07"), xRow)
     If  getColumIndex(spr,"Size08") > -1 then z7205.Size08 = getDataM(spr, getColumIndex(spr,"Size08"), xRow)
     If  getColumIndex(spr,"Size09") > -1 then z7205.Size09 = getDataM(spr, getColumIndex(spr,"Size09"), xRow)
     If  getColumIndex(spr,"Size10") > -1 then z7205.Size10 = getDataM(spr, getColumIndex(spr,"Size10"), xRow)
     If  getColumIndex(spr,"Size11") > -1 then z7205.Size11 = getDataM(spr, getColumIndex(spr,"Size11"), xRow)
     If  getColumIndex(spr,"Size12") > -1 then z7205.Size12 = getDataM(spr, getColumIndex(spr,"Size12"), xRow)
     If  getColumIndex(spr,"Size13") > -1 then z7205.Size13 = getDataM(spr, getColumIndex(spr,"Size13"), xRow)
     If  getColumIndex(spr,"Size14") > -1 then z7205.Size14 = getDataM(spr, getColumIndex(spr,"Size14"), xRow)
     If  getColumIndex(spr,"Size15") > -1 then z7205.Size15 = getDataM(spr, getColumIndex(spr,"Size15"), xRow)
     If  getColumIndex(spr,"Size16") > -1 then z7205.Size16 = getDataM(spr, getColumIndex(spr,"Size16"), xRow)
     If  getColumIndex(spr,"Size17") > -1 then z7205.Size17 = getDataM(spr, getColumIndex(spr,"Size17"), xRow)
     If  getColumIndex(spr,"Size18") > -1 then z7205.Size18 = getDataM(spr, getColumIndex(spr,"Size18"), xRow)
     If  getColumIndex(spr,"Size19") > -1 then z7205.Size19 = getDataM(spr, getColumIndex(spr,"Size19"), xRow)
     If  getColumIndex(spr,"Size20") > -1 then z7205.Size20 = getDataM(spr, getColumIndex(spr,"Size20"), xRow)
     If  getColumIndex(spr,"Size21") > -1 then z7205.Size21 = getDataM(spr, getColumIndex(spr,"Size21"), xRow)
     If  getColumIndex(spr,"Size22") > -1 then z7205.Size22 = getDataM(spr, getColumIndex(spr,"Size22"), xRow)
     If  getColumIndex(spr,"Size23") > -1 then z7205.Size23 = getDataM(spr, getColumIndex(spr,"Size23"), xRow)
     If  getColumIndex(spr,"Size24") > -1 then z7205.Size24 = getDataM(spr, getColumIndex(spr,"Size24"), xRow)
     If  getColumIndex(spr,"Size25") > -1 then z7205.Size25 = getDataM(spr, getColumIndex(spr,"Size25"), xRow)
     If  getColumIndex(spr,"Size26") > -1 then z7205.Size26 = getDataM(spr, getColumIndex(spr,"Size26"), xRow)
     If  getColumIndex(spr,"Size27") > -1 then z7205.Size27 = getDataM(spr, getColumIndex(spr,"Size27"), xRow)
     If  getColumIndex(spr,"Size28") > -1 then z7205.Size28 = getDataM(spr, getColumIndex(spr,"Size28"), xRow)
     If  getColumIndex(spr,"Size29") > -1 then z7205.Size29 = getDataM(spr, getColumIndex(spr,"Size29"), xRow)
     If  getColumIndex(spr,"Size30") > -1 then z7205.Size30 = getDataM(spr, getColumIndex(spr,"Size30"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7205.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7205.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7205.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7205.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7205.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z7205.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"CheckCondition") > -1 then z7205.CheckCondition = getDataM(spr, getColumIndex(spr,"CheckCondition"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7205.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7205_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7205_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7205 As T7205_AREA, Job as String, SHOESCODE AS String, SESIZEGROUP AS String, CDSIZEGROUP AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7205_MOVE = False

Try
    If READ_PFK7205(SHOESCODE, SESIZEGROUP, CDSIZEGROUP) = True Then
                z7205 = D7205
		K7205_MOVE = True
		else
	z7205 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7205")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SHOESCODE":z7205.ShoesCode = Children(i).Code
   Case "SESIZEGROUP":z7205.seSizeGroup = Children(i).Code
   Case "CDSIZEGROUP":z7205.cdSizeGroup = Children(i).Code
   Case "GRADINGNAME":z7205.GradingName = Children(i).Code
   Case "SIZE01":z7205.Size01 = Children(i).Code
   Case "SIZE02":z7205.Size02 = Children(i).Code
   Case "SIZE03":z7205.Size03 = Children(i).Code
   Case "SIZE04":z7205.Size04 = Children(i).Code
   Case "SIZE05":z7205.Size05 = Children(i).Code
   Case "SIZE06":z7205.Size06 = Children(i).Code
   Case "SIZE07":z7205.Size07 = Children(i).Code
   Case "SIZE08":z7205.Size08 = Children(i).Code
   Case "SIZE09":z7205.Size09 = Children(i).Code
   Case "SIZE10":z7205.Size10 = Children(i).Code
   Case "SIZE11":z7205.Size11 = Children(i).Code
   Case "SIZE12":z7205.Size12 = Children(i).Code
   Case "SIZE13":z7205.Size13 = Children(i).Code
   Case "SIZE14":z7205.Size14 = Children(i).Code
   Case "SIZE15":z7205.Size15 = Children(i).Code
   Case "SIZE16":z7205.Size16 = Children(i).Code
   Case "SIZE17":z7205.Size17 = Children(i).Code
   Case "SIZE18":z7205.Size18 = Children(i).Code
   Case "SIZE19":z7205.Size19 = Children(i).Code
   Case "SIZE20":z7205.Size20 = Children(i).Code
   Case "SIZE21":z7205.Size21 = Children(i).Code
   Case "SIZE22":z7205.Size22 = Children(i).Code
   Case "SIZE23":z7205.Size23 = Children(i).Code
   Case "SIZE24":z7205.Size24 = Children(i).Code
   Case "SIZE25":z7205.Size25 = Children(i).Code
   Case "SIZE26":z7205.Size26 = Children(i).Code
   Case "SIZE27":z7205.Size27 = Children(i).Code
   Case "SIZE28":z7205.Size28 = Children(i).Code
   Case "SIZE29":z7205.Size29 = Children(i).Code
   Case "SIZE30":z7205.Size30 = Children(i).Code
   Case "DATEINSERT":z7205.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7205.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7205.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7205.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7205.CheckUse = Children(i).Code
   Case "CHECKCOMPLETE":z7205.CheckComplete = Children(i).Code
   Case "CHECKCONDITION":z7205.CheckCondition = Children(i).Code
   Case "REMARK":z7205.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SHOESCODE":z7205.ShoesCode = Children(i).Data
   Case "SESIZEGROUP":z7205.seSizeGroup = Children(i).Data
   Case "CDSIZEGROUP":z7205.cdSizeGroup = Children(i).Data
   Case "GRADINGNAME":z7205.GradingName = Children(i).Data
   Case "SIZE01":z7205.Size01 = Children(i).Data
   Case "SIZE02":z7205.Size02 = Children(i).Data
   Case "SIZE03":z7205.Size03 = Children(i).Data
   Case "SIZE04":z7205.Size04 = Children(i).Data
   Case "SIZE05":z7205.Size05 = Children(i).Data
   Case "SIZE06":z7205.Size06 = Children(i).Data
   Case "SIZE07":z7205.Size07 = Children(i).Data
   Case "SIZE08":z7205.Size08 = Children(i).Data
   Case "SIZE09":z7205.Size09 = Children(i).Data
   Case "SIZE10":z7205.Size10 = Children(i).Data
   Case "SIZE11":z7205.Size11 = Children(i).Data
   Case "SIZE12":z7205.Size12 = Children(i).Data
   Case "SIZE13":z7205.Size13 = Children(i).Data
   Case "SIZE14":z7205.Size14 = Children(i).Data
   Case "SIZE15":z7205.Size15 = Children(i).Data
   Case "SIZE16":z7205.Size16 = Children(i).Data
   Case "SIZE17":z7205.Size17 = Children(i).Data
   Case "SIZE18":z7205.Size18 = Children(i).Data
   Case "SIZE19":z7205.Size19 = Children(i).Data
   Case "SIZE20":z7205.Size20 = Children(i).Data
   Case "SIZE21":z7205.Size21 = Children(i).Data
   Case "SIZE22":z7205.Size22 = Children(i).Data
   Case "SIZE23":z7205.Size23 = Children(i).Data
   Case "SIZE24":z7205.Size24 = Children(i).Data
   Case "SIZE25":z7205.Size25 = Children(i).Data
   Case "SIZE26":z7205.Size26 = Children(i).Data
   Case "SIZE27":z7205.Size27 = Children(i).Data
   Case "SIZE28":z7205.Size28 = Children(i).Data
   Case "SIZE29":z7205.Size29 = Children(i).Data
   Case "SIZE30":z7205.Size30 = Children(i).Data
   Case "DATEINSERT":z7205.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7205.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7205.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7205.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7205.CheckUse = Children(i).Data
   Case "CHECKCOMPLETE":z7205.CheckComplete = Children(i).Data
   Case "CHECKCONDITION":z7205.CheckCondition = Children(i).Data
   Case "REMARK":z7205.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7205_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7205_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7205 As T7205_AREA, Job as String, CheckClear as Boolean, SHOESCODE AS String, SESIZEGROUP AS String, CDSIZEGROUP AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7205_MOVE = False

Try
    If READ_PFK7205(SHOESCODE, SESIZEGROUP, CDSIZEGROUP) = True Then
                z7205 = D7205
		K7205_MOVE = True
		else
	If CheckClear  = True then z7205 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7205")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SHOESCODE":z7205.ShoesCode = Children(i).Code
   Case "SESIZEGROUP":z7205.seSizeGroup = Children(i).Code
   Case "CDSIZEGROUP":z7205.cdSizeGroup = Children(i).Code
   Case "GRADINGNAME":z7205.GradingName = Children(i).Code
   Case "SIZE01":z7205.Size01 = Children(i).Code
   Case "SIZE02":z7205.Size02 = Children(i).Code
   Case "SIZE03":z7205.Size03 = Children(i).Code
   Case "SIZE04":z7205.Size04 = Children(i).Code
   Case "SIZE05":z7205.Size05 = Children(i).Code
   Case "SIZE06":z7205.Size06 = Children(i).Code
   Case "SIZE07":z7205.Size07 = Children(i).Code
   Case "SIZE08":z7205.Size08 = Children(i).Code
   Case "SIZE09":z7205.Size09 = Children(i).Code
   Case "SIZE10":z7205.Size10 = Children(i).Code
   Case "SIZE11":z7205.Size11 = Children(i).Code
   Case "SIZE12":z7205.Size12 = Children(i).Code
   Case "SIZE13":z7205.Size13 = Children(i).Code
   Case "SIZE14":z7205.Size14 = Children(i).Code
   Case "SIZE15":z7205.Size15 = Children(i).Code
   Case "SIZE16":z7205.Size16 = Children(i).Code
   Case "SIZE17":z7205.Size17 = Children(i).Code
   Case "SIZE18":z7205.Size18 = Children(i).Code
   Case "SIZE19":z7205.Size19 = Children(i).Code
   Case "SIZE20":z7205.Size20 = Children(i).Code
   Case "SIZE21":z7205.Size21 = Children(i).Code
   Case "SIZE22":z7205.Size22 = Children(i).Code
   Case "SIZE23":z7205.Size23 = Children(i).Code
   Case "SIZE24":z7205.Size24 = Children(i).Code
   Case "SIZE25":z7205.Size25 = Children(i).Code
   Case "SIZE26":z7205.Size26 = Children(i).Code
   Case "SIZE27":z7205.Size27 = Children(i).Code
   Case "SIZE28":z7205.Size28 = Children(i).Code
   Case "SIZE29":z7205.Size29 = Children(i).Code
   Case "SIZE30":z7205.Size30 = Children(i).Code
   Case "DATEINSERT":z7205.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7205.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7205.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7205.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7205.CheckUse = Children(i).Code
   Case "CHECKCOMPLETE":z7205.CheckComplete = Children(i).Code
   Case "CHECKCONDITION":z7205.CheckCondition = Children(i).Code
   Case "REMARK":z7205.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SHOESCODE":z7205.ShoesCode = Children(i).Data
   Case "SESIZEGROUP":z7205.seSizeGroup = Children(i).Data
   Case "CDSIZEGROUP":z7205.cdSizeGroup = Children(i).Data
   Case "GRADINGNAME":z7205.GradingName = Children(i).Data
   Case "SIZE01":z7205.Size01 = Children(i).Data
   Case "SIZE02":z7205.Size02 = Children(i).Data
   Case "SIZE03":z7205.Size03 = Children(i).Data
   Case "SIZE04":z7205.Size04 = Children(i).Data
   Case "SIZE05":z7205.Size05 = Children(i).Data
   Case "SIZE06":z7205.Size06 = Children(i).Data
   Case "SIZE07":z7205.Size07 = Children(i).Data
   Case "SIZE08":z7205.Size08 = Children(i).Data
   Case "SIZE09":z7205.Size09 = Children(i).Data
   Case "SIZE10":z7205.Size10 = Children(i).Data
   Case "SIZE11":z7205.Size11 = Children(i).Data
   Case "SIZE12":z7205.Size12 = Children(i).Data
   Case "SIZE13":z7205.Size13 = Children(i).Data
   Case "SIZE14":z7205.Size14 = Children(i).Data
   Case "SIZE15":z7205.Size15 = Children(i).Data
   Case "SIZE16":z7205.Size16 = Children(i).Data
   Case "SIZE17":z7205.Size17 = Children(i).Data
   Case "SIZE18":z7205.Size18 = Children(i).Data
   Case "SIZE19":z7205.Size19 = Children(i).Data
   Case "SIZE20":z7205.Size20 = Children(i).Data
   Case "SIZE21":z7205.Size21 = Children(i).Data
   Case "SIZE22":z7205.Size22 = Children(i).Data
   Case "SIZE23":z7205.Size23 = Children(i).Data
   Case "SIZE24":z7205.Size24 = Children(i).Data
   Case "SIZE25":z7205.Size25 = Children(i).Data
   Case "SIZE26":z7205.Size26 = Children(i).Data
   Case "SIZE27":z7205.Size27 = Children(i).Data
   Case "SIZE28":z7205.Size28 = Children(i).Data
   Case "SIZE29":z7205.Size29 = Children(i).Data
   Case "SIZE30":z7205.Size30 = Children(i).Data
   Case "DATEINSERT":z7205.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7205.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7205.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7205.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7205.CheckUse = Children(i).Data
   Case "CHECKCOMPLETE":z7205.CheckComplete = Children(i).Data
   Case "CHECKCONDITION":z7205.CheckCondition = Children(i).Data
   Case "REMARK":z7205.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7205_MOVE",vbCritical)
End Try
End Function 
    
End Module 
