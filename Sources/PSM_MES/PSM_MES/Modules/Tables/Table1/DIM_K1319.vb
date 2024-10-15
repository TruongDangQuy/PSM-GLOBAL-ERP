'=========================================================================================================================================================
'   TABLE : (PFK1319)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K1319

Structure T1319_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	ShoesCode	 AS String	'			char(6)		*
Public 	SizeRange	 AS String	'			char(6)
Public 	Barcode01	 AS String	'			nvarchar(50)
Public 	Barcode02	 AS String	'			nvarchar(50)
Public 	Barcode03	 AS String	'			nvarchar(50)
Public 	Barcode04	 AS String	'			nvarchar(50)
Public 	Barcode05	 AS String	'			nvarchar(50)
Public 	Barcode06	 AS String	'			nvarchar(50)
Public 	Barcode07	 AS String	'			nvarchar(50)
Public 	Barcode08	 AS String	'			nvarchar(50)
Public 	Barcode09	 AS String	'			nvarchar(50)
Public 	Barcode10	 AS String	'			nvarchar(50)
Public 	Barcode11	 AS String	'			nvarchar(50)
Public 	Barcode12	 AS String	'			nvarchar(50)
Public 	Barcode13	 AS String	'			nvarchar(50)
Public 	Barcode14	 AS String	'			nvarchar(50)
Public 	Barcode15	 AS String	'			nvarchar(50)
Public 	Barcode16	 AS String	'			nvarchar(50)
Public 	Barcode17	 AS String	'			nvarchar(50)
Public 	Barcode18	 AS String	'			nvarchar(50)
Public 	Barcode19	 AS String	'			nvarchar(50)
Public 	Barcode20	 AS String	'			nvarchar(50)
Public 	Barcode21	 AS String	'			nvarchar(50)
Public 	Barcode22	 AS String	'			nvarchar(50)
Public 	Barcode23	 AS String	'			nvarchar(50)
Public 	Barcode24	 AS String	'			nvarchar(50)
Public 	Barcode25	 AS String	'			nvarchar(50)
Public 	Barcode26	 AS String	'			nvarchar(50)
Public 	Barcode27	 AS String	'			nvarchar(50)
Public 	Barcode28	 AS String	'			nvarchar(50)
Public 	Barcode29	 AS String	'			nvarchar(50)
Public 	Barcode30	 AS String	'			nvarchar(50)
Public 	DateInsert	 AS Double	'			decimal
'=========================================================================================================================================================
End structure

Public D1319 As T1319_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK1319(SHOESCODE AS String) As Boolean
    READ_PFK1319 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK1319 "
    SQL = SQL & " WHERE K1319_ShoesCode		 = '" & ShoesCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D1319_CLEAR: GoTo SKIP_READ_PFK1319
                
    Call K1319_MOVE(rd)
    READ_PFK1319 = True

SKIP_READ_PFK1319:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK1319",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK1319(SHOESCODE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK1319 "
    SQL = SQL & " WHERE K1319_ShoesCode		 = '" & ShoesCode & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK1319",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK1319(z1319 As T1319_AREA) As Boolean
    WRITE_PFK1319 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z1319)
 
    SQL = " INSERT INTO PFK1319 "
    SQL = SQL & " ( "
    SQL = SQL & " K1319_ShoesCode," 
    SQL = SQL & " K1319_SizeRange," 
    SQL = SQL & " K1319_Barcode01," 
    SQL = SQL & " K1319_Barcode02," 
    SQL = SQL & " K1319_Barcode03," 
    SQL = SQL & " K1319_Barcode04," 
    SQL = SQL & " K1319_Barcode05," 
    SQL = SQL & " K1319_Barcode06," 
    SQL = SQL & " K1319_Barcode07," 
    SQL = SQL & " K1319_Barcode08," 
    SQL = SQL & " K1319_Barcode09," 
    SQL = SQL & " K1319_Barcode10," 
    SQL = SQL & " K1319_Barcode11," 
    SQL = SQL & " K1319_Barcode12," 
    SQL = SQL & " K1319_Barcode13," 
    SQL = SQL & " K1319_Barcode14," 
    SQL = SQL & " K1319_Barcode15," 
    SQL = SQL & " K1319_Barcode16," 
    SQL = SQL & " K1319_Barcode17," 
    SQL = SQL & " K1319_Barcode18," 
    SQL = SQL & " K1319_Barcode19," 
    SQL = SQL & " K1319_Barcode20," 
    SQL = SQL & " K1319_Barcode21," 
    SQL = SQL & " K1319_Barcode22," 
    SQL = SQL & " K1319_Barcode23," 
    SQL = SQL & " K1319_Barcode24," 
    SQL = SQL & " K1319_Barcode25," 
    SQL = SQL & " K1319_Barcode26," 
    SQL = SQL & " K1319_Barcode27," 
    SQL = SQL & " K1319_Barcode28," 
    SQL = SQL & " K1319_Barcode29," 
    SQL = SQL & " K1319_Barcode30," 
    SQL = SQL & " K1319_DateInsert " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z1319.ShoesCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1319.SizeRange) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1319.Barcode01) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1319.Barcode02) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1319.Barcode03) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1319.Barcode04) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1319.Barcode05) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1319.Barcode06) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1319.Barcode07) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1319.Barcode08) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1319.Barcode09) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1319.Barcode10) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1319.Barcode11) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1319.Barcode12) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1319.Barcode13) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1319.Barcode14) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1319.Barcode15) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1319.Barcode16) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1319.Barcode17) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1319.Barcode18) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1319.Barcode19) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1319.Barcode20) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1319.Barcode21) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1319.Barcode22) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1319.Barcode23) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1319.Barcode24) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1319.Barcode25) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1319.Barcode26) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1319.Barcode27) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1319.Barcode28) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1319.Barcode29) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1319.Barcode30) & "', "  
    SQL = SQL & "   " & FormatSQL(z1319.DateInsert) & "  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK1319 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK1319",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK1319(z1319 As T1319_AREA) As Boolean
    REWRITE_PFK1319 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z1319)
   
    SQL = " UPDATE PFK1319 SET "
    SQL = SQL & "    K1319_SizeRange      = N'" & FormatSQL(z1319.SizeRange) & "', " 
    SQL = SQL & "    K1319_Barcode01      = N'" & FormatSQL(z1319.Barcode01) & "', " 
    SQL = SQL & "    K1319_Barcode02      = N'" & FormatSQL(z1319.Barcode02) & "', " 
    SQL = SQL & "    K1319_Barcode03      = N'" & FormatSQL(z1319.Barcode03) & "', " 
    SQL = SQL & "    K1319_Barcode04      = N'" & FormatSQL(z1319.Barcode04) & "', " 
    SQL = SQL & "    K1319_Barcode05      = N'" & FormatSQL(z1319.Barcode05) & "', " 
    SQL = SQL & "    K1319_Barcode06      = N'" & FormatSQL(z1319.Barcode06) & "', " 
    SQL = SQL & "    K1319_Barcode07      = N'" & FormatSQL(z1319.Barcode07) & "', " 
    SQL = SQL & "    K1319_Barcode08      = N'" & FormatSQL(z1319.Barcode08) & "', " 
    SQL = SQL & "    K1319_Barcode09      = N'" & FormatSQL(z1319.Barcode09) & "', " 
    SQL = SQL & "    K1319_Barcode10      = N'" & FormatSQL(z1319.Barcode10) & "', " 
    SQL = SQL & "    K1319_Barcode11      = N'" & FormatSQL(z1319.Barcode11) & "', " 
    SQL = SQL & "    K1319_Barcode12      = N'" & FormatSQL(z1319.Barcode12) & "', " 
    SQL = SQL & "    K1319_Barcode13      = N'" & FormatSQL(z1319.Barcode13) & "', " 
    SQL = SQL & "    K1319_Barcode14      = N'" & FormatSQL(z1319.Barcode14) & "', " 
    SQL = SQL & "    K1319_Barcode15      = N'" & FormatSQL(z1319.Barcode15) & "', " 
    SQL = SQL & "    K1319_Barcode16      = N'" & FormatSQL(z1319.Barcode16) & "', " 
    SQL = SQL & "    K1319_Barcode17      = N'" & FormatSQL(z1319.Barcode17) & "', " 
    SQL = SQL & "    K1319_Barcode18      = N'" & FormatSQL(z1319.Barcode18) & "', " 
    SQL = SQL & "    K1319_Barcode19      = N'" & FormatSQL(z1319.Barcode19) & "', " 
    SQL = SQL & "    K1319_Barcode20      = N'" & FormatSQL(z1319.Barcode20) & "', " 
    SQL = SQL & "    K1319_Barcode21      = N'" & FormatSQL(z1319.Barcode21) & "', " 
    SQL = SQL & "    K1319_Barcode22      = N'" & FormatSQL(z1319.Barcode22) & "', " 
    SQL = SQL & "    K1319_Barcode23      = N'" & FormatSQL(z1319.Barcode23) & "', " 
    SQL = SQL & "    K1319_Barcode24      = N'" & FormatSQL(z1319.Barcode24) & "', " 
    SQL = SQL & "    K1319_Barcode25      = N'" & FormatSQL(z1319.Barcode25) & "', " 
    SQL = SQL & "    K1319_Barcode26      = N'" & FormatSQL(z1319.Barcode26) & "', " 
    SQL = SQL & "    K1319_Barcode27      = N'" & FormatSQL(z1319.Barcode27) & "', " 
    SQL = SQL & "    K1319_Barcode28      = N'" & FormatSQL(z1319.Barcode28) & "', " 
    SQL = SQL & "    K1319_Barcode29      = N'" & FormatSQL(z1319.Barcode29) & "', " 
    SQL = SQL & "    K1319_Barcode30      = N'" & FormatSQL(z1319.Barcode30) & "', " 
    SQL = SQL & "    K1319_DateInsert      =  " & FormatSQL(z1319.DateInsert) & "  " 
    SQL = SQL & " WHERE K1319_ShoesCode		 = '" & z1319.ShoesCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK1319 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK1319",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK1319(z1319 As T1319_AREA) As Boolean
    DELETE_PFK1319 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK1319 "
    SQL = SQL & " WHERE K1319_ShoesCode		 = '" & z1319.ShoesCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK1319 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK1319",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D1319_CLEAR()
Try
    
   D1319.ShoesCode = ""
   D1319.SizeRange = ""
   D1319.Barcode01 = ""
   D1319.Barcode02 = ""
   D1319.Barcode03 = ""
   D1319.Barcode04 = ""
   D1319.Barcode05 = ""
   D1319.Barcode06 = ""
   D1319.Barcode07 = ""
   D1319.Barcode08 = ""
   D1319.Barcode09 = ""
   D1319.Barcode10 = ""
   D1319.Barcode11 = ""
   D1319.Barcode12 = ""
   D1319.Barcode13 = ""
   D1319.Barcode14 = ""
   D1319.Barcode15 = ""
   D1319.Barcode16 = ""
   D1319.Barcode17 = ""
   D1319.Barcode18 = ""
   D1319.Barcode19 = ""
   D1319.Barcode20 = ""
   D1319.Barcode21 = ""
   D1319.Barcode22 = ""
   D1319.Barcode23 = ""
   D1319.Barcode24 = ""
   D1319.Barcode25 = ""
   D1319.Barcode26 = ""
   D1319.Barcode27 = ""
   D1319.Barcode28 = ""
   D1319.Barcode29 = ""
   D1319.Barcode30 = ""
    D1319.DateInsert = 0 

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D1319_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x1319 As T1319_AREA)
Try
    
    x1319.ShoesCode = trim$(  x1319.ShoesCode)
    x1319.SizeRange = trim$(  x1319.SizeRange)
    x1319.Barcode01 = trim$(  x1319.Barcode01)
    x1319.Barcode02 = trim$(  x1319.Barcode02)
    x1319.Barcode03 = trim$(  x1319.Barcode03)
    x1319.Barcode04 = trim$(  x1319.Barcode04)
    x1319.Barcode05 = trim$(  x1319.Barcode05)
    x1319.Barcode06 = trim$(  x1319.Barcode06)
    x1319.Barcode07 = trim$(  x1319.Barcode07)
    x1319.Barcode08 = trim$(  x1319.Barcode08)
    x1319.Barcode09 = trim$(  x1319.Barcode09)
    x1319.Barcode10 = trim$(  x1319.Barcode10)
    x1319.Barcode11 = trim$(  x1319.Barcode11)
    x1319.Barcode12 = trim$(  x1319.Barcode12)
    x1319.Barcode13 = trim$(  x1319.Barcode13)
    x1319.Barcode14 = trim$(  x1319.Barcode14)
    x1319.Barcode15 = trim$(  x1319.Barcode15)
    x1319.Barcode16 = trim$(  x1319.Barcode16)
    x1319.Barcode17 = trim$(  x1319.Barcode17)
    x1319.Barcode18 = trim$(  x1319.Barcode18)
    x1319.Barcode19 = trim$(  x1319.Barcode19)
    x1319.Barcode20 = trim$(  x1319.Barcode20)
    x1319.Barcode21 = trim$(  x1319.Barcode21)
    x1319.Barcode22 = trim$(  x1319.Barcode22)
    x1319.Barcode23 = trim$(  x1319.Barcode23)
    x1319.Barcode24 = trim$(  x1319.Barcode24)
    x1319.Barcode25 = trim$(  x1319.Barcode25)
    x1319.Barcode26 = trim$(  x1319.Barcode26)
    x1319.Barcode27 = trim$(  x1319.Barcode27)
    x1319.Barcode28 = trim$(  x1319.Barcode28)
    x1319.Barcode29 = trim$(  x1319.Barcode29)
    x1319.Barcode30 = trim$(  x1319.Barcode30)
    x1319.DateInsert = trim$(  x1319.DateInsert)
     
    If trim$( x1319.ShoesCode ) = "" Then x1319.ShoesCode = Space(1) 
    If trim$( x1319.SizeRange ) = "" Then x1319.SizeRange = Space(1) 
    If trim$( x1319.Barcode01 ) = "" Then x1319.Barcode01 = Space(1) 
    If trim$( x1319.Barcode02 ) = "" Then x1319.Barcode02 = Space(1) 
    If trim$( x1319.Barcode03 ) = "" Then x1319.Barcode03 = Space(1) 
    If trim$( x1319.Barcode04 ) = "" Then x1319.Barcode04 = Space(1) 
    If trim$( x1319.Barcode05 ) = "" Then x1319.Barcode05 = Space(1) 
    If trim$( x1319.Barcode06 ) = "" Then x1319.Barcode06 = Space(1) 
    If trim$( x1319.Barcode07 ) = "" Then x1319.Barcode07 = Space(1) 
    If trim$( x1319.Barcode08 ) = "" Then x1319.Barcode08 = Space(1) 
    If trim$( x1319.Barcode09 ) = "" Then x1319.Barcode09 = Space(1) 
    If trim$( x1319.Barcode10 ) = "" Then x1319.Barcode10 = Space(1) 
    If trim$( x1319.Barcode11 ) = "" Then x1319.Barcode11 = Space(1) 
    If trim$( x1319.Barcode12 ) = "" Then x1319.Barcode12 = Space(1) 
    If trim$( x1319.Barcode13 ) = "" Then x1319.Barcode13 = Space(1) 
    If trim$( x1319.Barcode14 ) = "" Then x1319.Barcode14 = Space(1) 
    If trim$( x1319.Barcode15 ) = "" Then x1319.Barcode15 = Space(1) 
    If trim$( x1319.Barcode16 ) = "" Then x1319.Barcode16 = Space(1) 
    If trim$( x1319.Barcode17 ) = "" Then x1319.Barcode17 = Space(1) 
    If trim$( x1319.Barcode18 ) = "" Then x1319.Barcode18 = Space(1) 
    If trim$( x1319.Barcode19 ) = "" Then x1319.Barcode19 = Space(1) 
    If trim$( x1319.Barcode20 ) = "" Then x1319.Barcode20 = Space(1) 
    If trim$( x1319.Barcode21 ) = "" Then x1319.Barcode21 = Space(1) 
    If trim$( x1319.Barcode22 ) = "" Then x1319.Barcode22 = Space(1) 
    If trim$( x1319.Barcode23 ) = "" Then x1319.Barcode23 = Space(1) 
    If trim$( x1319.Barcode24 ) = "" Then x1319.Barcode24 = Space(1) 
    If trim$( x1319.Barcode25 ) = "" Then x1319.Barcode25 = Space(1) 
    If trim$( x1319.Barcode26 ) = "" Then x1319.Barcode26 = Space(1) 
    If trim$( x1319.Barcode27 ) = "" Then x1319.Barcode27 = Space(1) 
    If trim$( x1319.Barcode28 ) = "" Then x1319.Barcode28 = Space(1) 
    If trim$( x1319.Barcode29 ) = "" Then x1319.Barcode29 = Space(1) 
    If trim$( x1319.Barcode30 ) = "" Then x1319.Barcode30 = Space(1) 
    If trim$( x1319.DateInsert ) = "" Then x1319.DateInsert = 0 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K1319_MOVE(rs1319 As SqlClient.SqlDataReader)
Try

    call D1319_CLEAR()   

    If IsdbNull(rs1319!K1319_ShoesCode) = False Then D1319.ShoesCode = Trim$(rs1319!K1319_ShoesCode)
    If IsdbNull(rs1319!K1319_SizeRange) = False Then D1319.SizeRange = Trim$(rs1319!K1319_SizeRange)
    If IsdbNull(rs1319!K1319_Barcode01) = False Then D1319.Barcode01 = Trim$(rs1319!K1319_Barcode01)
    If IsdbNull(rs1319!K1319_Barcode02) = False Then D1319.Barcode02 = Trim$(rs1319!K1319_Barcode02)
    If IsdbNull(rs1319!K1319_Barcode03) = False Then D1319.Barcode03 = Trim$(rs1319!K1319_Barcode03)
    If IsdbNull(rs1319!K1319_Barcode04) = False Then D1319.Barcode04 = Trim$(rs1319!K1319_Barcode04)
    If IsdbNull(rs1319!K1319_Barcode05) = False Then D1319.Barcode05 = Trim$(rs1319!K1319_Barcode05)
    If IsdbNull(rs1319!K1319_Barcode06) = False Then D1319.Barcode06 = Trim$(rs1319!K1319_Barcode06)
    If IsdbNull(rs1319!K1319_Barcode07) = False Then D1319.Barcode07 = Trim$(rs1319!K1319_Barcode07)
    If IsdbNull(rs1319!K1319_Barcode08) = False Then D1319.Barcode08 = Trim$(rs1319!K1319_Barcode08)
    If IsdbNull(rs1319!K1319_Barcode09) = False Then D1319.Barcode09 = Trim$(rs1319!K1319_Barcode09)
    If IsdbNull(rs1319!K1319_Barcode10) = False Then D1319.Barcode10 = Trim$(rs1319!K1319_Barcode10)
    If IsdbNull(rs1319!K1319_Barcode11) = False Then D1319.Barcode11 = Trim$(rs1319!K1319_Barcode11)
    If IsdbNull(rs1319!K1319_Barcode12) = False Then D1319.Barcode12 = Trim$(rs1319!K1319_Barcode12)
    If IsdbNull(rs1319!K1319_Barcode13) = False Then D1319.Barcode13 = Trim$(rs1319!K1319_Barcode13)
    If IsdbNull(rs1319!K1319_Barcode14) = False Then D1319.Barcode14 = Trim$(rs1319!K1319_Barcode14)
    If IsdbNull(rs1319!K1319_Barcode15) = False Then D1319.Barcode15 = Trim$(rs1319!K1319_Barcode15)
    If IsdbNull(rs1319!K1319_Barcode16) = False Then D1319.Barcode16 = Trim$(rs1319!K1319_Barcode16)
    If IsdbNull(rs1319!K1319_Barcode17) = False Then D1319.Barcode17 = Trim$(rs1319!K1319_Barcode17)
    If IsdbNull(rs1319!K1319_Barcode18) = False Then D1319.Barcode18 = Trim$(rs1319!K1319_Barcode18)
    If IsdbNull(rs1319!K1319_Barcode19) = False Then D1319.Barcode19 = Trim$(rs1319!K1319_Barcode19)
    If IsdbNull(rs1319!K1319_Barcode20) = False Then D1319.Barcode20 = Trim$(rs1319!K1319_Barcode20)
    If IsdbNull(rs1319!K1319_Barcode21) = False Then D1319.Barcode21 = Trim$(rs1319!K1319_Barcode21)
    If IsdbNull(rs1319!K1319_Barcode22) = False Then D1319.Barcode22 = Trim$(rs1319!K1319_Barcode22)
    If IsdbNull(rs1319!K1319_Barcode23) = False Then D1319.Barcode23 = Trim$(rs1319!K1319_Barcode23)
    If IsdbNull(rs1319!K1319_Barcode24) = False Then D1319.Barcode24 = Trim$(rs1319!K1319_Barcode24)
    If IsdbNull(rs1319!K1319_Barcode25) = False Then D1319.Barcode25 = Trim$(rs1319!K1319_Barcode25)
    If IsdbNull(rs1319!K1319_Barcode26) = False Then D1319.Barcode26 = Trim$(rs1319!K1319_Barcode26)
    If IsdbNull(rs1319!K1319_Barcode27) = False Then D1319.Barcode27 = Trim$(rs1319!K1319_Barcode27)
    If IsdbNull(rs1319!K1319_Barcode28) = False Then D1319.Barcode28 = Trim$(rs1319!K1319_Barcode28)
    If IsdbNull(rs1319!K1319_Barcode29) = False Then D1319.Barcode29 = Trim$(rs1319!K1319_Barcode29)
    If IsdbNull(rs1319!K1319_Barcode30) = False Then D1319.Barcode30 = Trim$(rs1319!K1319_Barcode30)
    If IsdbNull(rs1319!K1319_DateInsert) = False Then D1319.DateInsert = Trim$(rs1319!K1319_DateInsert)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K1319_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K1319_MOVE(rs1319 As DataRow)
Try

    call D1319_CLEAR()   

    If IsdbNull(rs1319!K1319_ShoesCode) = False Then D1319.ShoesCode = Trim$(rs1319!K1319_ShoesCode)
    If IsdbNull(rs1319!K1319_SizeRange) = False Then D1319.SizeRange = Trim$(rs1319!K1319_SizeRange)
    If IsdbNull(rs1319!K1319_Barcode01) = False Then D1319.Barcode01 = Trim$(rs1319!K1319_Barcode01)
    If IsdbNull(rs1319!K1319_Barcode02) = False Then D1319.Barcode02 = Trim$(rs1319!K1319_Barcode02)
    If IsdbNull(rs1319!K1319_Barcode03) = False Then D1319.Barcode03 = Trim$(rs1319!K1319_Barcode03)
    If IsdbNull(rs1319!K1319_Barcode04) = False Then D1319.Barcode04 = Trim$(rs1319!K1319_Barcode04)
    If IsdbNull(rs1319!K1319_Barcode05) = False Then D1319.Barcode05 = Trim$(rs1319!K1319_Barcode05)
    If IsdbNull(rs1319!K1319_Barcode06) = False Then D1319.Barcode06 = Trim$(rs1319!K1319_Barcode06)
    If IsdbNull(rs1319!K1319_Barcode07) = False Then D1319.Barcode07 = Trim$(rs1319!K1319_Barcode07)
    If IsdbNull(rs1319!K1319_Barcode08) = False Then D1319.Barcode08 = Trim$(rs1319!K1319_Barcode08)
    If IsdbNull(rs1319!K1319_Barcode09) = False Then D1319.Barcode09 = Trim$(rs1319!K1319_Barcode09)
    If IsdbNull(rs1319!K1319_Barcode10) = False Then D1319.Barcode10 = Trim$(rs1319!K1319_Barcode10)
    If IsdbNull(rs1319!K1319_Barcode11) = False Then D1319.Barcode11 = Trim$(rs1319!K1319_Barcode11)
    If IsdbNull(rs1319!K1319_Barcode12) = False Then D1319.Barcode12 = Trim$(rs1319!K1319_Barcode12)
    If IsdbNull(rs1319!K1319_Barcode13) = False Then D1319.Barcode13 = Trim$(rs1319!K1319_Barcode13)
    If IsdbNull(rs1319!K1319_Barcode14) = False Then D1319.Barcode14 = Trim$(rs1319!K1319_Barcode14)
    If IsdbNull(rs1319!K1319_Barcode15) = False Then D1319.Barcode15 = Trim$(rs1319!K1319_Barcode15)
    If IsdbNull(rs1319!K1319_Barcode16) = False Then D1319.Barcode16 = Trim$(rs1319!K1319_Barcode16)
    If IsdbNull(rs1319!K1319_Barcode17) = False Then D1319.Barcode17 = Trim$(rs1319!K1319_Barcode17)
    If IsdbNull(rs1319!K1319_Barcode18) = False Then D1319.Barcode18 = Trim$(rs1319!K1319_Barcode18)
    If IsdbNull(rs1319!K1319_Barcode19) = False Then D1319.Barcode19 = Trim$(rs1319!K1319_Barcode19)
    If IsdbNull(rs1319!K1319_Barcode20) = False Then D1319.Barcode20 = Trim$(rs1319!K1319_Barcode20)
    If IsdbNull(rs1319!K1319_Barcode21) = False Then D1319.Barcode21 = Trim$(rs1319!K1319_Barcode21)
    If IsdbNull(rs1319!K1319_Barcode22) = False Then D1319.Barcode22 = Trim$(rs1319!K1319_Barcode22)
    If IsdbNull(rs1319!K1319_Barcode23) = False Then D1319.Barcode23 = Trim$(rs1319!K1319_Barcode23)
    If IsdbNull(rs1319!K1319_Barcode24) = False Then D1319.Barcode24 = Trim$(rs1319!K1319_Barcode24)
    If IsdbNull(rs1319!K1319_Barcode25) = False Then D1319.Barcode25 = Trim$(rs1319!K1319_Barcode25)
    If IsdbNull(rs1319!K1319_Barcode26) = False Then D1319.Barcode26 = Trim$(rs1319!K1319_Barcode26)
    If IsdbNull(rs1319!K1319_Barcode27) = False Then D1319.Barcode27 = Trim$(rs1319!K1319_Barcode27)
    If IsdbNull(rs1319!K1319_Barcode28) = False Then D1319.Barcode28 = Trim$(rs1319!K1319_Barcode28)
    If IsdbNull(rs1319!K1319_Barcode29) = False Then D1319.Barcode29 = Trim$(rs1319!K1319_Barcode29)
    If IsdbNull(rs1319!K1319_Barcode30) = False Then D1319.Barcode30 = Trim$(rs1319!K1319_Barcode30)
    If IsdbNull(rs1319!K1319_DateInsert) = False Then D1319.DateInsert = Trim$(rs1319!K1319_DateInsert)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K1319_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K1319_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z1319 As T1319_AREA, SHOESCODE AS String) as Boolean

K1319_MOVE = False

Try
    If READ_PFK1319(SHOESCODE) = True Then
                z1319 = D1319
		K1319_MOVE = True
		else
	z1319 = nothing
     End If

     If  getColumIndex(spr,"ShoesCode") > -1 then z1319.ShoesCode = getDataM(spr, getColumIndex(spr,"ShoesCode"), xRow)
     If  getColumIndex(spr,"SizeRange") > -1 then z1319.SizeRange = getDataM(spr, getColumIndex(spr,"SizeRange"), xRow)
     If  getColumIndex(spr,"Barcode01") > -1 then z1319.Barcode01 = getDataM(spr, getColumIndex(spr,"Barcode01"), xRow)
     If  getColumIndex(spr,"Barcode02") > -1 then z1319.Barcode02 = getDataM(spr, getColumIndex(spr,"Barcode02"), xRow)
     If  getColumIndex(spr,"Barcode03") > -1 then z1319.Barcode03 = getDataM(spr, getColumIndex(spr,"Barcode03"), xRow)
     If  getColumIndex(spr,"Barcode04") > -1 then z1319.Barcode04 = getDataM(spr, getColumIndex(spr,"Barcode04"), xRow)
     If  getColumIndex(spr,"Barcode05") > -1 then z1319.Barcode05 = getDataM(spr, getColumIndex(spr,"Barcode05"), xRow)
     If  getColumIndex(spr,"Barcode06") > -1 then z1319.Barcode06 = getDataM(spr, getColumIndex(spr,"Barcode06"), xRow)
     If  getColumIndex(spr,"Barcode07") > -1 then z1319.Barcode07 = getDataM(spr, getColumIndex(spr,"Barcode07"), xRow)
     If  getColumIndex(spr,"Barcode08") > -1 then z1319.Barcode08 = getDataM(spr, getColumIndex(spr,"Barcode08"), xRow)
     If  getColumIndex(spr,"Barcode09") > -1 then z1319.Barcode09 = getDataM(spr, getColumIndex(spr,"Barcode09"), xRow)
     If  getColumIndex(spr,"Barcode10") > -1 then z1319.Barcode10 = getDataM(spr, getColumIndex(spr,"Barcode10"), xRow)
     If  getColumIndex(spr,"Barcode11") > -1 then z1319.Barcode11 = getDataM(spr, getColumIndex(spr,"Barcode11"), xRow)
     If  getColumIndex(spr,"Barcode12") > -1 then z1319.Barcode12 = getDataM(spr, getColumIndex(spr,"Barcode12"), xRow)
     If  getColumIndex(spr,"Barcode13") > -1 then z1319.Barcode13 = getDataM(spr, getColumIndex(spr,"Barcode13"), xRow)
     If  getColumIndex(spr,"Barcode14") > -1 then z1319.Barcode14 = getDataM(spr, getColumIndex(spr,"Barcode14"), xRow)
     If  getColumIndex(spr,"Barcode15") > -1 then z1319.Barcode15 = getDataM(spr, getColumIndex(spr,"Barcode15"), xRow)
     If  getColumIndex(spr,"Barcode16") > -1 then z1319.Barcode16 = getDataM(spr, getColumIndex(spr,"Barcode16"), xRow)
     If  getColumIndex(spr,"Barcode17") > -1 then z1319.Barcode17 = getDataM(spr, getColumIndex(spr,"Barcode17"), xRow)
     If  getColumIndex(spr,"Barcode18") > -1 then z1319.Barcode18 = getDataM(spr, getColumIndex(spr,"Barcode18"), xRow)
     If  getColumIndex(spr,"Barcode19") > -1 then z1319.Barcode19 = getDataM(spr, getColumIndex(spr,"Barcode19"), xRow)
     If  getColumIndex(spr,"Barcode20") > -1 then z1319.Barcode20 = getDataM(spr, getColumIndex(spr,"Barcode20"), xRow)
     If  getColumIndex(spr,"Barcode21") > -1 then z1319.Barcode21 = getDataM(spr, getColumIndex(spr,"Barcode21"), xRow)
     If  getColumIndex(spr,"Barcode22") > -1 then z1319.Barcode22 = getDataM(spr, getColumIndex(spr,"Barcode22"), xRow)
     If  getColumIndex(spr,"Barcode23") > -1 then z1319.Barcode23 = getDataM(spr, getColumIndex(spr,"Barcode23"), xRow)
     If  getColumIndex(spr,"Barcode24") > -1 then z1319.Barcode24 = getDataM(spr, getColumIndex(spr,"Barcode24"), xRow)
     If  getColumIndex(spr,"Barcode25") > -1 then z1319.Barcode25 = getDataM(spr, getColumIndex(spr,"Barcode25"), xRow)
     If  getColumIndex(spr,"Barcode26") > -1 then z1319.Barcode26 = getDataM(spr, getColumIndex(spr,"Barcode26"), xRow)
     If  getColumIndex(spr,"Barcode27") > -1 then z1319.Barcode27 = getDataM(spr, getColumIndex(spr,"Barcode27"), xRow)
     If  getColumIndex(spr,"Barcode28") > -1 then z1319.Barcode28 = getDataM(spr, getColumIndex(spr,"Barcode28"), xRow)
     If  getColumIndex(spr,"Barcode29") > -1 then z1319.Barcode29 = getDataM(spr, getColumIndex(spr,"Barcode29"), xRow)
     If  getColumIndex(spr,"Barcode30") > -1 then z1319.Barcode30 = getDataM(spr, getColumIndex(spr,"Barcode30"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z1319.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K1319_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K1319_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z1319 As T1319_AREA,CheckClear as Boolean,SHOESCODE AS String) as Boolean

K1319_MOVE = False

Try
    If READ_PFK1319(SHOESCODE) = True Then
                z1319 = D1319
		K1319_MOVE = True
		else
	If CheckClear  = True then z1319 = nothing
     End If

     If  getColumIndex(spr,"ShoesCode") > -1 then z1319.ShoesCode = getDataM(spr, getColumIndex(spr,"ShoesCode"), xRow)
     If  getColumIndex(spr,"SizeRange") > -1 then z1319.SizeRange = getDataM(spr, getColumIndex(spr,"SizeRange"), xRow)
     If  getColumIndex(spr,"Barcode01") > -1 then z1319.Barcode01 = getDataM(spr, getColumIndex(spr,"Barcode01"), xRow)
     If  getColumIndex(spr,"Barcode02") > -1 then z1319.Barcode02 = getDataM(spr, getColumIndex(spr,"Barcode02"), xRow)
     If  getColumIndex(spr,"Barcode03") > -1 then z1319.Barcode03 = getDataM(spr, getColumIndex(spr,"Barcode03"), xRow)
     If  getColumIndex(spr,"Barcode04") > -1 then z1319.Barcode04 = getDataM(spr, getColumIndex(spr,"Barcode04"), xRow)
     If  getColumIndex(spr,"Barcode05") > -1 then z1319.Barcode05 = getDataM(spr, getColumIndex(spr,"Barcode05"), xRow)
     If  getColumIndex(spr,"Barcode06") > -1 then z1319.Barcode06 = getDataM(spr, getColumIndex(spr,"Barcode06"), xRow)
     If  getColumIndex(spr,"Barcode07") > -1 then z1319.Barcode07 = getDataM(spr, getColumIndex(spr,"Barcode07"), xRow)
     If  getColumIndex(spr,"Barcode08") > -1 then z1319.Barcode08 = getDataM(spr, getColumIndex(spr,"Barcode08"), xRow)
     If  getColumIndex(spr,"Barcode09") > -1 then z1319.Barcode09 = getDataM(spr, getColumIndex(spr,"Barcode09"), xRow)
     If  getColumIndex(spr,"Barcode10") > -1 then z1319.Barcode10 = getDataM(spr, getColumIndex(spr,"Barcode10"), xRow)
     If  getColumIndex(spr,"Barcode11") > -1 then z1319.Barcode11 = getDataM(spr, getColumIndex(spr,"Barcode11"), xRow)
     If  getColumIndex(spr,"Barcode12") > -1 then z1319.Barcode12 = getDataM(spr, getColumIndex(spr,"Barcode12"), xRow)
     If  getColumIndex(spr,"Barcode13") > -1 then z1319.Barcode13 = getDataM(spr, getColumIndex(spr,"Barcode13"), xRow)
     If  getColumIndex(spr,"Barcode14") > -1 then z1319.Barcode14 = getDataM(spr, getColumIndex(spr,"Barcode14"), xRow)
     If  getColumIndex(spr,"Barcode15") > -1 then z1319.Barcode15 = getDataM(spr, getColumIndex(spr,"Barcode15"), xRow)
     If  getColumIndex(spr,"Barcode16") > -1 then z1319.Barcode16 = getDataM(spr, getColumIndex(spr,"Barcode16"), xRow)
     If  getColumIndex(spr,"Barcode17") > -1 then z1319.Barcode17 = getDataM(spr, getColumIndex(spr,"Barcode17"), xRow)
     If  getColumIndex(spr,"Barcode18") > -1 then z1319.Barcode18 = getDataM(spr, getColumIndex(spr,"Barcode18"), xRow)
     If  getColumIndex(spr,"Barcode19") > -1 then z1319.Barcode19 = getDataM(spr, getColumIndex(spr,"Barcode19"), xRow)
     If  getColumIndex(spr,"Barcode20") > -1 then z1319.Barcode20 = getDataM(spr, getColumIndex(spr,"Barcode20"), xRow)
     If  getColumIndex(spr,"Barcode21") > -1 then z1319.Barcode21 = getDataM(spr, getColumIndex(spr,"Barcode21"), xRow)
     If  getColumIndex(spr,"Barcode22") > -1 then z1319.Barcode22 = getDataM(spr, getColumIndex(spr,"Barcode22"), xRow)
     If  getColumIndex(spr,"Barcode23") > -1 then z1319.Barcode23 = getDataM(spr, getColumIndex(spr,"Barcode23"), xRow)
     If  getColumIndex(spr,"Barcode24") > -1 then z1319.Barcode24 = getDataM(spr, getColumIndex(spr,"Barcode24"), xRow)
     If  getColumIndex(spr,"Barcode25") > -1 then z1319.Barcode25 = getDataM(spr, getColumIndex(spr,"Barcode25"), xRow)
     If  getColumIndex(spr,"Barcode26") > -1 then z1319.Barcode26 = getDataM(spr, getColumIndex(spr,"Barcode26"), xRow)
     If  getColumIndex(spr,"Barcode27") > -1 then z1319.Barcode27 = getDataM(spr, getColumIndex(spr,"Barcode27"), xRow)
     If  getColumIndex(spr,"Barcode28") > -1 then z1319.Barcode28 = getDataM(spr, getColumIndex(spr,"Barcode28"), xRow)
     If  getColumIndex(spr,"Barcode29") > -1 then z1319.Barcode29 = getDataM(spr, getColumIndex(spr,"Barcode29"), xRow)
     If  getColumIndex(spr,"Barcode30") > -1 then z1319.Barcode30 = getDataM(spr, getColumIndex(spr,"Barcode30"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z1319.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K1319_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K1319_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z1319 As T1319_AREA, Job as String, SHOESCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K1319_MOVE = False

Try
    If READ_PFK1319(SHOESCODE) = True Then
                z1319 = D1319
		K1319_MOVE = True
		else
	z1319 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1319")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SHOESCODE":z1319.ShoesCode = Children(i).Code
   Case "SIZERANGE":z1319.SizeRange = Children(i).Code
   Case "BARCODE01":z1319.Barcode01 = Children(i).Code
   Case "BARCODE02":z1319.Barcode02 = Children(i).Code
   Case "BARCODE03":z1319.Barcode03 = Children(i).Code
   Case "BARCODE04":z1319.Barcode04 = Children(i).Code
   Case "BARCODE05":z1319.Barcode05 = Children(i).Code
   Case "BARCODE06":z1319.Barcode06 = Children(i).Code
   Case "BARCODE07":z1319.Barcode07 = Children(i).Code
   Case "BARCODE08":z1319.Barcode08 = Children(i).Code
   Case "BARCODE09":z1319.Barcode09 = Children(i).Code
   Case "BARCODE10":z1319.Barcode10 = Children(i).Code
   Case "BARCODE11":z1319.Barcode11 = Children(i).Code
   Case "BARCODE12":z1319.Barcode12 = Children(i).Code
   Case "BARCODE13":z1319.Barcode13 = Children(i).Code
   Case "BARCODE14":z1319.Barcode14 = Children(i).Code
   Case "BARCODE15":z1319.Barcode15 = Children(i).Code
   Case "BARCODE16":z1319.Barcode16 = Children(i).Code
   Case "BARCODE17":z1319.Barcode17 = Children(i).Code
   Case "BARCODE18":z1319.Barcode18 = Children(i).Code
   Case "BARCODE19":z1319.Barcode19 = Children(i).Code
   Case "BARCODE20":z1319.Barcode20 = Children(i).Code
   Case "BARCODE21":z1319.Barcode21 = Children(i).Code
   Case "BARCODE22":z1319.Barcode22 = Children(i).Code
   Case "BARCODE23":z1319.Barcode23 = Children(i).Code
   Case "BARCODE24":z1319.Barcode24 = Children(i).Code
   Case "BARCODE25":z1319.Barcode25 = Children(i).Code
   Case "BARCODE26":z1319.Barcode26 = Children(i).Code
   Case "BARCODE27":z1319.Barcode27 = Children(i).Code
   Case "BARCODE28":z1319.Barcode28 = Children(i).Code
   Case "BARCODE29":z1319.Barcode29 = Children(i).Code
   Case "BARCODE30":z1319.Barcode30 = Children(i).Code
   Case "DATEINSERT":z1319.DateInsert = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SHOESCODE":z1319.ShoesCode = Children(i).Data
   Case "SIZERANGE":z1319.SizeRange = Children(i).Data
   Case "BARCODE01":z1319.Barcode01 = Children(i).Data
   Case "BARCODE02":z1319.Barcode02 = Children(i).Data
   Case "BARCODE03":z1319.Barcode03 = Children(i).Data
   Case "BARCODE04":z1319.Barcode04 = Children(i).Data
   Case "BARCODE05":z1319.Barcode05 = Children(i).Data
   Case "BARCODE06":z1319.Barcode06 = Children(i).Data
   Case "BARCODE07":z1319.Barcode07 = Children(i).Data
   Case "BARCODE08":z1319.Barcode08 = Children(i).Data
   Case "BARCODE09":z1319.Barcode09 = Children(i).Data
   Case "BARCODE10":z1319.Barcode10 = Children(i).Data
   Case "BARCODE11":z1319.Barcode11 = Children(i).Data
   Case "BARCODE12":z1319.Barcode12 = Children(i).Data
   Case "BARCODE13":z1319.Barcode13 = Children(i).Data
   Case "BARCODE14":z1319.Barcode14 = Children(i).Data
   Case "BARCODE15":z1319.Barcode15 = Children(i).Data
   Case "BARCODE16":z1319.Barcode16 = Children(i).Data
   Case "BARCODE17":z1319.Barcode17 = Children(i).Data
   Case "BARCODE18":z1319.Barcode18 = Children(i).Data
   Case "BARCODE19":z1319.Barcode19 = Children(i).Data
   Case "BARCODE20":z1319.Barcode20 = Children(i).Data
   Case "BARCODE21":z1319.Barcode21 = Children(i).Data
   Case "BARCODE22":z1319.Barcode22 = Children(i).Data
   Case "BARCODE23":z1319.Barcode23 = Children(i).Data
   Case "BARCODE24":z1319.Barcode24 = Children(i).Data
   Case "BARCODE25":z1319.Barcode25 = Children(i).Data
   Case "BARCODE26":z1319.Barcode26 = Children(i).Data
   Case "BARCODE27":z1319.Barcode27 = Children(i).Data
   Case "BARCODE28":z1319.Barcode28 = Children(i).Data
   Case "BARCODE29":z1319.Barcode29 = Children(i).Data
   Case "BARCODE30":z1319.Barcode30 = Children(i).Data
   Case "DATEINSERT":z1319.DateInsert = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K1319_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K1319_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z1319 As T1319_AREA, Job as String, CheckClear as Boolean, SHOESCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K1319_MOVE = False

Try
    If READ_PFK1319(SHOESCODE) = True Then
                z1319 = D1319
		K1319_MOVE = True
		else
	If CheckClear  = True then z1319 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1319")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SHOESCODE":z1319.ShoesCode = Children(i).Code
   Case "SIZERANGE":z1319.SizeRange = Children(i).Code
   Case "BARCODE01":z1319.Barcode01 = Children(i).Code
   Case "BARCODE02":z1319.Barcode02 = Children(i).Code
   Case "BARCODE03":z1319.Barcode03 = Children(i).Code
   Case "BARCODE04":z1319.Barcode04 = Children(i).Code
   Case "BARCODE05":z1319.Barcode05 = Children(i).Code
   Case "BARCODE06":z1319.Barcode06 = Children(i).Code
   Case "BARCODE07":z1319.Barcode07 = Children(i).Code
   Case "BARCODE08":z1319.Barcode08 = Children(i).Code
   Case "BARCODE09":z1319.Barcode09 = Children(i).Code
   Case "BARCODE10":z1319.Barcode10 = Children(i).Code
   Case "BARCODE11":z1319.Barcode11 = Children(i).Code
   Case "BARCODE12":z1319.Barcode12 = Children(i).Code
   Case "BARCODE13":z1319.Barcode13 = Children(i).Code
   Case "BARCODE14":z1319.Barcode14 = Children(i).Code
   Case "BARCODE15":z1319.Barcode15 = Children(i).Code
   Case "BARCODE16":z1319.Barcode16 = Children(i).Code
   Case "BARCODE17":z1319.Barcode17 = Children(i).Code
   Case "BARCODE18":z1319.Barcode18 = Children(i).Code
   Case "BARCODE19":z1319.Barcode19 = Children(i).Code
   Case "BARCODE20":z1319.Barcode20 = Children(i).Code
   Case "BARCODE21":z1319.Barcode21 = Children(i).Code
   Case "BARCODE22":z1319.Barcode22 = Children(i).Code
   Case "BARCODE23":z1319.Barcode23 = Children(i).Code
   Case "BARCODE24":z1319.Barcode24 = Children(i).Code
   Case "BARCODE25":z1319.Barcode25 = Children(i).Code
   Case "BARCODE26":z1319.Barcode26 = Children(i).Code
   Case "BARCODE27":z1319.Barcode27 = Children(i).Code
   Case "BARCODE28":z1319.Barcode28 = Children(i).Code
   Case "BARCODE29":z1319.Barcode29 = Children(i).Code
   Case "BARCODE30":z1319.Barcode30 = Children(i).Code
   Case "DATEINSERT":z1319.DateInsert = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SHOESCODE":z1319.ShoesCode = Children(i).Data
   Case "SIZERANGE":z1319.SizeRange = Children(i).Data
   Case "BARCODE01":z1319.Barcode01 = Children(i).Data
   Case "BARCODE02":z1319.Barcode02 = Children(i).Data
   Case "BARCODE03":z1319.Barcode03 = Children(i).Data
   Case "BARCODE04":z1319.Barcode04 = Children(i).Data
   Case "BARCODE05":z1319.Barcode05 = Children(i).Data
   Case "BARCODE06":z1319.Barcode06 = Children(i).Data
   Case "BARCODE07":z1319.Barcode07 = Children(i).Data
   Case "BARCODE08":z1319.Barcode08 = Children(i).Data
   Case "BARCODE09":z1319.Barcode09 = Children(i).Data
   Case "BARCODE10":z1319.Barcode10 = Children(i).Data
   Case "BARCODE11":z1319.Barcode11 = Children(i).Data
   Case "BARCODE12":z1319.Barcode12 = Children(i).Data
   Case "BARCODE13":z1319.Barcode13 = Children(i).Data
   Case "BARCODE14":z1319.Barcode14 = Children(i).Data
   Case "BARCODE15":z1319.Barcode15 = Children(i).Data
   Case "BARCODE16":z1319.Barcode16 = Children(i).Data
   Case "BARCODE17":z1319.Barcode17 = Children(i).Data
   Case "BARCODE18":z1319.Barcode18 = Children(i).Data
   Case "BARCODE19":z1319.Barcode19 = Children(i).Data
   Case "BARCODE20":z1319.Barcode20 = Children(i).Data
   Case "BARCODE21":z1319.Barcode21 = Children(i).Data
   Case "BARCODE22":z1319.Barcode22 = Children(i).Data
   Case "BARCODE23":z1319.Barcode23 = Children(i).Data
   Case "BARCODE24":z1319.Barcode24 = Children(i).Data
   Case "BARCODE25":z1319.Barcode25 = Children(i).Data
   Case "BARCODE26":z1319.Barcode26 = Children(i).Data
   Case "BARCODE27":z1319.Barcode27 = Children(i).Data
   Case "BARCODE28":z1319.Barcode28 = Children(i).Data
   Case "BARCODE29":z1319.Barcode29 = Children(i).Data
   Case "BARCODE30":z1319.Barcode30 = Children(i).Data
   Case "DATEINSERT":z1319.DateInsert = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K1319_MOVE",vbCritical)
End Try
End Function 
    
End Module 
