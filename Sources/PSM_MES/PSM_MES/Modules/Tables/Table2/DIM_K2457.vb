'=========================================================================================================================================================
'   TABLE : (PFK2457)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K2457

Structure T2457_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	ProductOutboundNo	 AS String	'			char(9)		*
Public 	ProductOutboundSeq	 AS String	'			char(3)		*
Public 	SizeQtyOutbound01	 AS Double	'			decimal
Public 	SizeQtyOutbound02	 AS Double	'			decimal
Public 	SizeQtyOutbound03	 AS Double	'			decimal
Public 	SizeQtyOutbound04	 AS Double	'			decimal
Public 	SizeQtyOutbound05	 AS Double	'			decimal
Public 	SizeQtyOutbound06	 AS Double	'			decimal
Public 	SizeQtyOutbound07	 AS Double	'			decimal
Public 	SizeQtyOutbound08	 AS Double	'			decimal
Public 	SizeQtyOutbound09	 AS Double	'			decimal
Public 	SizeQtyOutbound10	 AS Double	'			decimal
Public 	SizeQtyOutbound11	 AS Double	'			decimal
Public 	SizeQtyOutbound12	 AS Double	'			decimal
Public 	SizeQtyOutbound13	 AS Double	'			decimal
Public 	SizeQtyOutbound14	 AS Double	'			decimal
Public 	SizeQtyOutbound15	 AS Double	'			decimal
Public 	SizeQtyOutbound16	 AS Double	'			decimal
Public 	SizeQtyOutbound17	 AS Double	'			decimal
Public 	SizeQtyOutbound18	 AS Double	'			decimal
Public 	SizeQtyOutbound19	 AS Double	'			decimal
Public 	SizeQtyOutbound20	 AS Double	'			decimal
Public 	SizeQtyOutbound21	 AS Double	'			decimal
Public 	SizeQtyOutbound22	 AS Double	'			decimal
Public 	SizeQtyOutbound23	 AS Double	'			decimal
Public 	SizeQtyOutbound24	 AS Double	'			decimal
Public 	SizeQtyOutbound25	 AS Double	'			decimal
Public 	SizeQtyOutbound26	 AS Double	'			decimal
Public 	SizeQtyOutbound27	 AS Double	'			decimal
Public 	SizeQtyOutbound28	 AS Double	'			decimal
Public 	SizeQtyOutbound29	 AS Double	'			decimal
Public 	SizeQtyOutbound30	 AS Double	'			decimal
'=========================================================================================================================================================
End structure

Public D2457 As T2457_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK2457(PRODUCTOUTBOUNDNO AS String, PRODUCTOUTBOUNDSEQ AS String) As Boolean
    READ_PFK2457 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK2457 "
    SQL = SQL & " WHERE K2457_ProductOutboundNo		 = '" & ProductOutboundNo & "' " 
    SQL = SQL & "   AND K2457_ProductOutboundSeq		 = '" & ProductOutboundSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D2457_CLEAR: GoTo SKIP_READ_PFK2457
                
    Call K2457_MOVE(rd)
    READ_PFK2457 = True

SKIP_READ_PFK2457:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK2457",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK2457(PRODUCTOUTBOUNDNO AS String, PRODUCTOUTBOUNDSEQ AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK2457 "
    SQL = SQL & " WHERE K2457_ProductOutboundNo		 = '" & ProductOutboundNo & "' " 
    SQL = SQL & "   AND K2457_ProductOutboundSeq		 = '" & ProductOutboundSeq & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK2457",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK2457(z2457 As T2457_AREA) As Boolean
    WRITE_PFK2457 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z2457)
 
    SQL = " INSERT INTO PFK2457 "
    SQL = SQL & " ( "
    SQL = SQL & " K2457_ProductOutboundNo," 
    SQL = SQL & " K2457_ProductOutboundSeq," 
    SQL = SQL & " K2457_SizeQtyOutbound01," 
    SQL = SQL & " K2457_SizeQtyOutbound02," 
    SQL = SQL & " K2457_SizeQtyOutbound03," 
    SQL = SQL & " K2457_SizeQtyOutbound04," 
    SQL = SQL & " K2457_SizeQtyOutbound05," 
    SQL = SQL & " K2457_SizeQtyOutbound06," 
    SQL = SQL & " K2457_SizeQtyOutbound07," 
    SQL = SQL & " K2457_SizeQtyOutbound08," 
    SQL = SQL & " K2457_SizeQtyOutbound09," 
    SQL = SQL & " K2457_SizeQtyOutbound10," 
    SQL = SQL & " K2457_SizeQtyOutbound11," 
    SQL = SQL & " K2457_SizeQtyOutbound12," 
    SQL = SQL & " K2457_SizeQtyOutbound13," 
    SQL = SQL & " K2457_SizeQtyOutbound14," 
    SQL = SQL & " K2457_SizeQtyOutbound15," 
    SQL = SQL & " K2457_SizeQtyOutbound16," 
    SQL = SQL & " K2457_SizeQtyOutbound17," 
    SQL = SQL & " K2457_SizeQtyOutbound18," 
    SQL = SQL & " K2457_SizeQtyOutbound19," 
    SQL = SQL & " K2457_SizeQtyOutbound20," 
    SQL = SQL & " K2457_SizeQtyOutbound21," 
    SQL = SQL & " K2457_SizeQtyOutbound22," 
    SQL = SQL & " K2457_SizeQtyOutbound23," 
    SQL = SQL & " K2457_SizeQtyOutbound24," 
    SQL = SQL & " K2457_SizeQtyOutbound25," 
    SQL = SQL & " K2457_SizeQtyOutbound26," 
    SQL = SQL & " K2457_SizeQtyOutbound27," 
    SQL = SQL & " K2457_SizeQtyOutbound28," 
    SQL = SQL & " K2457_SizeQtyOutbound29," 
    SQL = SQL & " K2457_SizeQtyOutbound30 " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z2457.ProductOutboundNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2457.ProductOutboundSeq) & "', "  
    SQL = SQL & "   " & FormatSQL(z2457.SizeQtyOutbound01) & ", "  
    SQL = SQL & "   " & FormatSQL(z2457.SizeQtyOutbound02) & ", "  
    SQL = SQL & "   " & FormatSQL(z2457.SizeQtyOutbound03) & ", "  
    SQL = SQL & "   " & FormatSQL(z2457.SizeQtyOutbound04) & ", "  
    SQL = SQL & "   " & FormatSQL(z2457.SizeQtyOutbound05) & ", "  
    SQL = SQL & "   " & FormatSQL(z2457.SizeQtyOutbound06) & ", "  
    SQL = SQL & "   " & FormatSQL(z2457.SizeQtyOutbound07) & ", "  
    SQL = SQL & "   " & FormatSQL(z2457.SizeQtyOutbound08) & ", "  
    SQL = SQL & "   " & FormatSQL(z2457.SizeQtyOutbound09) & ", "  
    SQL = SQL & "   " & FormatSQL(z2457.SizeQtyOutbound10) & ", "  
    SQL = SQL & "   " & FormatSQL(z2457.SizeQtyOutbound11) & ", "  
    SQL = SQL & "   " & FormatSQL(z2457.SizeQtyOutbound12) & ", "  
    SQL = SQL & "   " & FormatSQL(z2457.SizeQtyOutbound13) & ", "  
    SQL = SQL & "   " & FormatSQL(z2457.SizeQtyOutbound14) & ", "  
    SQL = SQL & "   " & FormatSQL(z2457.SizeQtyOutbound15) & ", "  
    SQL = SQL & "   " & FormatSQL(z2457.SizeQtyOutbound16) & ", "  
    SQL = SQL & "   " & FormatSQL(z2457.SizeQtyOutbound17) & ", "  
    SQL = SQL & "   " & FormatSQL(z2457.SizeQtyOutbound18) & ", "  
    SQL = SQL & "   " & FormatSQL(z2457.SizeQtyOutbound19) & ", "  
    SQL = SQL & "   " & FormatSQL(z2457.SizeQtyOutbound20) & ", "  
    SQL = SQL & "   " & FormatSQL(z2457.SizeQtyOutbound21) & ", "  
    SQL = SQL & "   " & FormatSQL(z2457.SizeQtyOutbound22) & ", "  
    SQL = SQL & "   " & FormatSQL(z2457.SizeQtyOutbound23) & ", "  
    SQL = SQL & "   " & FormatSQL(z2457.SizeQtyOutbound24) & ", "  
    SQL = SQL & "   " & FormatSQL(z2457.SizeQtyOutbound25) & ", "  
    SQL = SQL & "   " & FormatSQL(z2457.SizeQtyOutbound26) & ", "  
    SQL = SQL & "   " & FormatSQL(z2457.SizeQtyOutbound27) & ", "  
    SQL = SQL & "   " & FormatSQL(z2457.SizeQtyOutbound28) & ", "  
    SQL = SQL & "   " & FormatSQL(z2457.SizeQtyOutbound29) & ", "  
    SQL = SQL & "   " & FormatSQL(z2457.SizeQtyOutbound30) & "  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK2457 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK2457",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK2457(z2457 As T2457_AREA) As Boolean
    REWRITE_PFK2457 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z2457)
   
    SQL = " UPDATE PFK2457 SET "
    SQL = SQL & "    K2457_SizeQtyOutbound01      =  " & FormatSQL(z2457.SizeQtyOutbound01) & ", " 
    SQL = SQL & "    K2457_SizeQtyOutbound02      =  " & FormatSQL(z2457.SizeQtyOutbound02) & ", " 
    SQL = SQL & "    K2457_SizeQtyOutbound03      =  " & FormatSQL(z2457.SizeQtyOutbound03) & ", " 
    SQL = SQL & "    K2457_SizeQtyOutbound04      =  " & FormatSQL(z2457.SizeQtyOutbound04) & ", " 
    SQL = SQL & "    K2457_SizeQtyOutbound05      =  " & FormatSQL(z2457.SizeQtyOutbound05) & ", " 
    SQL = SQL & "    K2457_SizeQtyOutbound06      =  " & FormatSQL(z2457.SizeQtyOutbound06) & ", " 
    SQL = SQL & "    K2457_SizeQtyOutbound07      =  " & FormatSQL(z2457.SizeQtyOutbound07) & ", " 
    SQL = SQL & "    K2457_SizeQtyOutbound08      =  " & FormatSQL(z2457.SizeQtyOutbound08) & ", " 
    SQL = SQL & "    K2457_SizeQtyOutbound09      =  " & FormatSQL(z2457.SizeQtyOutbound09) & ", " 
    SQL = SQL & "    K2457_SizeQtyOutbound10      =  " & FormatSQL(z2457.SizeQtyOutbound10) & ", " 
    SQL = SQL & "    K2457_SizeQtyOutbound11      =  " & FormatSQL(z2457.SizeQtyOutbound11) & ", " 
    SQL = SQL & "    K2457_SizeQtyOutbound12      =  " & FormatSQL(z2457.SizeQtyOutbound12) & ", " 
    SQL = SQL & "    K2457_SizeQtyOutbound13      =  " & FormatSQL(z2457.SizeQtyOutbound13) & ", " 
    SQL = SQL & "    K2457_SizeQtyOutbound14      =  " & FormatSQL(z2457.SizeQtyOutbound14) & ", " 
    SQL = SQL & "    K2457_SizeQtyOutbound15      =  " & FormatSQL(z2457.SizeQtyOutbound15) & ", " 
    SQL = SQL & "    K2457_SizeQtyOutbound16      =  " & FormatSQL(z2457.SizeQtyOutbound16) & ", " 
    SQL = SQL & "    K2457_SizeQtyOutbound17      =  " & FormatSQL(z2457.SizeQtyOutbound17) & ", " 
    SQL = SQL & "    K2457_SizeQtyOutbound18      =  " & FormatSQL(z2457.SizeQtyOutbound18) & ", " 
    SQL = SQL & "    K2457_SizeQtyOutbound19      =  " & FormatSQL(z2457.SizeQtyOutbound19) & ", " 
    SQL = SQL & "    K2457_SizeQtyOutbound20      =  " & FormatSQL(z2457.SizeQtyOutbound20) & ", " 
    SQL = SQL & "    K2457_SizeQtyOutbound21      =  " & FormatSQL(z2457.SizeQtyOutbound21) & ", " 
    SQL = SQL & "    K2457_SizeQtyOutbound22      =  " & FormatSQL(z2457.SizeQtyOutbound22) & ", " 
    SQL = SQL & "    K2457_SizeQtyOutbound23      =  " & FormatSQL(z2457.SizeQtyOutbound23) & ", " 
    SQL = SQL & "    K2457_SizeQtyOutbound24      =  " & FormatSQL(z2457.SizeQtyOutbound24) & ", " 
    SQL = SQL & "    K2457_SizeQtyOutbound25      =  " & FormatSQL(z2457.SizeQtyOutbound25) & ", " 
    SQL = SQL & "    K2457_SizeQtyOutbound26      =  " & FormatSQL(z2457.SizeQtyOutbound26) & ", " 
    SQL = SQL & "    K2457_SizeQtyOutbound27      =  " & FormatSQL(z2457.SizeQtyOutbound27) & ", " 
    SQL = SQL & "    K2457_SizeQtyOutbound28      =  " & FormatSQL(z2457.SizeQtyOutbound28) & ", " 
    SQL = SQL & "    K2457_SizeQtyOutbound29      =  " & FormatSQL(z2457.SizeQtyOutbound29) & ", " 
    SQL = SQL & "    K2457_SizeQtyOutbound30      =  " & FormatSQL(z2457.SizeQtyOutbound30) & "  " 
    SQL = SQL & " WHERE K2457_ProductOutboundNo		 = '" & z2457.ProductOutboundNo & "' " 
    SQL = SQL & "   AND K2457_ProductOutboundSeq		 = '" & z2457.ProductOutboundSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK2457 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK2457",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK2457(z2457 As T2457_AREA) As Boolean
    DELETE_PFK2457 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK2457 "
    SQL = SQL & " WHERE K2457_ProductOutboundNo		 = '" & z2457.ProductOutboundNo & "' " 
    SQL = SQL & "   AND K2457_ProductOutboundSeq		 = '" & z2457.ProductOutboundSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK2457 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK2457",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D2457_CLEAR()
Try
    
   D2457.ProductOutboundNo = ""
   D2457.ProductOutboundSeq = ""
    D2457.SizeQtyOutbound01 = 0 
    D2457.SizeQtyOutbound02 = 0 
    D2457.SizeQtyOutbound03 = 0 
    D2457.SizeQtyOutbound04 = 0 
    D2457.SizeQtyOutbound05 = 0 
    D2457.SizeQtyOutbound06 = 0 
    D2457.SizeQtyOutbound07 = 0 
    D2457.SizeQtyOutbound08 = 0 
    D2457.SizeQtyOutbound09 = 0 
    D2457.SizeQtyOutbound10 = 0 
    D2457.SizeQtyOutbound11 = 0 
    D2457.SizeQtyOutbound12 = 0 
    D2457.SizeQtyOutbound13 = 0 
    D2457.SizeQtyOutbound14 = 0 
    D2457.SizeQtyOutbound15 = 0 
    D2457.SizeQtyOutbound16 = 0 
    D2457.SizeQtyOutbound17 = 0 
    D2457.SizeQtyOutbound18 = 0 
    D2457.SizeQtyOutbound19 = 0 
    D2457.SizeQtyOutbound20 = 0 
    D2457.SizeQtyOutbound21 = 0 
    D2457.SizeQtyOutbound22 = 0 
    D2457.SizeQtyOutbound23 = 0 
    D2457.SizeQtyOutbound24 = 0 
    D2457.SizeQtyOutbound25 = 0 
    D2457.SizeQtyOutbound26 = 0 
    D2457.SizeQtyOutbound27 = 0 
    D2457.SizeQtyOutbound28 = 0 
    D2457.SizeQtyOutbound29 = 0 
    D2457.SizeQtyOutbound30 = 0 

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D2457_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x2457 As T2457_AREA)
Try
    
    x2457.ProductOutboundNo = trim$(  x2457.ProductOutboundNo)
    x2457.ProductOutboundSeq = trim$(  x2457.ProductOutboundSeq)
    x2457.SizeQtyOutbound01 = trim$(  x2457.SizeQtyOutbound01)
    x2457.SizeQtyOutbound02 = trim$(  x2457.SizeQtyOutbound02)
    x2457.SizeQtyOutbound03 = trim$(  x2457.SizeQtyOutbound03)
    x2457.SizeQtyOutbound04 = trim$(  x2457.SizeQtyOutbound04)
    x2457.SizeQtyOutbound05 = trim$(  x2457.SizeQtyOutbound05)
    x2457.SizeQtyOutbound06 = trim$(  x2457.SizeQtyOutbound06)
    x2457.SizeQtyOutbound07 = trim$(  x2457.SizeQtyOutbound07)
    x2457.SizeQtyOutbound08 = trim$(  x2457.SizeQtyOutbound08)
    x2457.SizeQtyOutbound09 = trim$(  x2457.SizeQtyOutbound09)
    x2457.SizeQtyOutbound10 = trim$(  x2457.SizeQtyOutbound10)
    x2457.SizeQtyOutbound11 = trim$(  x2457.SizeQtyOutbound11)
    x2457.SizeQtyOutbound12 = trim$(  x2457.SizeQtyOutbound12)
    x2457.SizeQtyOutbound13 = trim$(  x2457.SizeQtyOutbound13)
    x2457.SizeQtyOutbound14 = trim$(  x2457.SizeQtyOutbound14)
    x2457.SizeQtyOutbound15 = trim$(  x2457.SizeQtyOutbound15)
    x2457.SizeQtyOutbound16 = trim$(  x2457.SizeQtyOutbound16)
    x2457.SizeQtyOutbound17 = trim$(  x2457.SizeQtyOutbound17)
    x2457.SizeQtyOutbound18 = trim$(  x2457.SizeQtyOutbound18)
    x2457.SizeQtyOutbound19 = trim$(  x2457.SizeQtyOutbound19)
    x2457.SizeQtyOutbound20 = trim$(  x2457.SizeQtyOutbound20)
    x2457.SizeQtyOutbound21 = trim$(  x2457.SizeQtyOutbound21)
    x2457.SizeQtyOutbound22 = trim$(  x2457.SizeQtyOutbound22)
    x2457.SizeQtyOutbound23 = trim$(  x2457.SizeQtyOutbound23)
    x2457.SizeQtyOutbound24 = trim$(  x2457.SizeQtyOutbound24)
    x2457.SizeQtyOutbound25 = trim$(  x2457.SizeQtyOutbound25)
    x2457.SizeQtyOutbound26 = trim$(  x2457.SizeQtyOutbound26)
    x2457.SizeQtyOutbound27 = trim$(  x2457.SizeQtyOutbound27)
    x2457.SizeQtyOutbound28 = trim$(  x2457.SizeQtyOutbound28)
    x2457.SizeQtyOutbound29 = trim$(  x2457.SizeQtyOutbound29)
    x2457.SizeQtyOutbound30 = trim$(  x2457.SizeQtyOutbound30)
     
    If trim$( x2457.ProductOutboundNo ) = "" Then x2457.ProductOutboundNo = Space(1) 
    If trim$( x2457.ProductOutboundSeq ) = "" Then x2457.ProductOutboundSeq = Space(1) 
    If trim$( x2457.SizeQtyOutbound01 ) = "" Then x2457.SizeQtyOutbound01 = 0 
    If trim$( x2457.SizeQtyOutbound02 ) = "" Then x2457.SizeQtyOutbound02 = 0 
    If trim$( x2457.SizeQtyOutbound03 ) = "" Then x2457.SizeQtyOutbound03 = 0 
    If trim$( x2457.SizeQtyOutbound04 ) = "" Then x2457.SizeQtyOutbound04 = 0 
    If trim$( x2457.SizeQtyOutbound05 ) = "" Then x2457.SizeQtyOutbound05 = 0 
    If trim$( x2457.SizeQtyOutbound06 ) = "" Then x2457.SizeQtyOutbound06 = 0 
    If trim$( x2457.SizeQtyOutbound07 ) = "" Then x2457.SizeQtyOutbound07 = 0 
    If trim$( x2457.SizeQtyOutbound08 ) = "" Then x2457.SizeQtyOutbound08 = 0 
    If trim$( x2457.SizeQtyOutbound09 ) = "" Then x2457.SizeQtyOutbound09 = 0 
    If trim$( x2457.SizeQtyOutbound10 ) = "" Then x2457.SizeQtyOutbound10 = 0 
    If trim$( x2457.SizeQtyOutbound11 ) = "" Then x2457.SizeQtyOutbound11 = 0 
    If trim$( x2457.SizeQtyOutbound12 ) = "" Then x2457.SizeQtyOutbound12 = 0 
    If trim$( x2457.SizeQtyOutbound13 ) = "" Then x2457.SizeQtyOutbound13 = 0 
    If trim$( x2457.SizeQtyOutbound14 ) = "" Then x2457.SizeQtyOutbound14 = 0 
    If trim$( x2457.SizeQtyOutbound15 ) = "" Then x2457.SizeQtyOutbound15 = 0 
    If trim$( x2457.SizeQtyOutbound16 ) = "" Then x2457.SizeQtyOutbound16 = 0 
    If trim$( x2457.SizeQtyOutbound17 ) = "" Then x2457.SizeQtyOutbound17 = 0 
    If trim$( x2457.SizeQtyOutbound18 ) = "" Then x2457.SizeQtyOutbound18 = 0 
    If trim$( x2457.SizeQtyOutbound19 ) = "" Then x2457.SizeQtyOutbound19 = 0 
    If trim$( x2457.SizeQtyOutbound20 ) = "" Then x2457.SizeQtyOutbound20 = 0 
    If trim$( x2457.SizeQtyOutbound21 ) = "" Then x2457.SizeQtyOutbound21 = 0 
    If trim$( x2457.SizeQtyOutbound22 ) = "" Then x2457.SizeQtyOutbound22 = 0 
    If trim$( x2457.SizeQtyOutbound23 ) = "" Then x2457.SizeQtyOutbound23 = 0 
    If trim$( x2457.SizeQtyOutbound24 ) = "" Then x2457.SizeQtyOutbound24 = 0 
    If trim$( x2457.SizeQtyOutbound25 ) = "" Then x2457.SizeQtyOutbound25 = 0 
    If trim$( x2457.SizeQtyOutbound26 ) = "" Then x2457.SizeQtyOutbound26 = 0 
    If trim$( x2457.SizeQtyOutbound27 ) = "" Then x2457.SizeQtyOutbound27 = 0 
    If trim$( x2457.SizeQtyOutbound28 ) = "" Then x2457.SizeQtyOutbound28 = 0 
    If trim$( x2457.SizeQtyOutbound29 ) = "" Then x2457.SizeQtyOutbound29 = 0 
    If trim$( x2457.SizeQtyOutbound30 ) = "" Then x2457.SizeQtyOutbound30 = 0 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K2457_MOVE(rs2457 As SqlClient.SqlDataReader)
Try

    call D2457_CLEAR()   

    If IsdbNull(rs2457!K2457_ProductOutboundNo) = False Then D2457.ProductOutboundNo = Trim$(rs2457!K2457_ProductOutboundNo)
    If IsdbNull(rs2457!K2457_ProductOutboundSeq) = False Then D2457.ProductOutboundSeq = Trim$(rs2457!K2457_ProductOutboundSeq)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound01) = False Then D2457.SizeQtyOutbound01 = Trim$(rs2457!K2457_SizeQtyOutbound01)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound02) = False Then D2457.SizeQtyOutbound02 = Trim$(rs2457!K2457_SizeQtyOutbound02)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound03) = False Then D2457.SizeQtyOutbound03 = Trim$(rs2457!K2457_SizeQtyOutbound03)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound04) = False Then D2457.SizeQtyOutbound04 = Trim$(rs2457!K2457_SizeQtyOutbound04)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound05) = False Then D2457.SizeQtyOutbound05 = Trim$(rs2457!K2457_SizeQtyOutbound05)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound06) = False Then D2457.SizeQtyOutbound06 = Trim$(rs2457!K2457_SizeQtyOutbound06)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound07) = False Then D2457.SizeQtyOutbound07 = Trim$(rs2457!K2457_SizeQtyOutbound07)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound08) = False Then D2457.SizeQtyOutbound08 = Trim$(rs2457!K2457_SizeQtyOutbound08)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound09) = False Then D2457.SizeQtyOutbound09 = Trim$(rs2457!K2457_SizeQtyOutbound09)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound10) = False Then D2457.SizeQtyOutbound10 = Trim$(rs2457!K2457_SizeQtyOutbound10)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound11) = False Then D2457.SizeQtyOutbound11 = Trim$(rs2457!K2457_SizeQtyOutbound11)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound12) = False Then D2457.SizeQtyOutbound12 = Trim$(rs2457!K2457_SizeQtyOutbound12)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound13) = False Then D2457.SizeQtyOutbound13 = Trim$(rs2457!K2457_SizeQtyOutbound13)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound14) = False Then D2457.SizeQtyOutbound14 = Trim$(rs2457!K2457_SizeQtyOutbound14)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound15) = False Then D2457.SizeQtyOutbound15 = Trim$(rs2457!K2457_SizeQtyOutbound15)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound16) = False Then D2457.SizeQtyOutbound16 = Trim$(rs2457!K2457_SizeQtyOutbound16)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound17) = False Then D2457.SizeQtyOutbound17 = Trim$(rs2457!K2457_SizeQtyOutbound17)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound18) = False Then D2457.SizeQtyOutbound18 = Trim$(rs2457!K2457_SizeQtyOutbound18)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound19) = False Then D2457.SizeQtyOutbound19 = Trim$(rs2457!K2457_SizeQtyOutbound19)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound20) = False Then D2457.SizeQtyOutbound20 = Trim$(rs2457!K2457_SizeQtyOutbound20)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound21) = False Then D2457.SizeQtyOutbound21 = Trim$(rs2457!K2457_SizeQtyOutbound21)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound22) = False Then D2457.SizeQtyOutbound22 = Trim$(rs2457!K2457_SizeQtyOutbound22)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound23) = False Then D2457.SizeQtyOutbound23 = Trim$(rs2457!K2457_SizeQtyOutbound23)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound24) = False Then D2457.SizeQtyOutbound24 = Trim$(rs2457!K2457_SizeQtyOutbound24)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound25) = False Then D2457.SizeQtyOutbound25 = Trim$(rs2457!K2457_SizeQtyOutbound25)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound26) = False Then D2457.SizeQtyOutbound26 = Trim$(rs2457!K2457_SizeQtyOutbound26)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound27) = False Then D2457.SizeQtyOutbound27 = Trim$(rs2457!K2457_SizeQtyOutbound27)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound28) = False Then D2457.SizeQtyOutbound28 = Trim$(rs2457!K2457_SizeQtyOutbound28)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound29) = False Then D2457.SizeQtyOutbound29 = Trim$(rs2457!K2457_SizeQtyOutbound29)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound30) = False Then D2457.SizeQtyOutbound30 = Trim$(rs2457!K2457_SizeQtyOutbound30)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K2457_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K2457_MOVE(rs2457 As DataRow)
Try

    call D2457_CLEAR()   

    If IsdbNull(rs2457!K2457_ProductOutboundNo) = False Then D2457.ProductOutboundNo = Trim$(rs2457!K2457_ProductOutboundNo)
    If IsdbNull(rs2457!K2457_ProductOutboundSeq) = False Then D2457.ProductOutboundSeq = Trim$(rs2457!K2457_ProductOutboundSeq)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound01) = False Then D2457.SizeQtyOutbound01 = Trim$(rs2457!K2457_SizeQtyOutbound01)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound02) = False Then D2457.SizeQtyOutbound02 = Trim$(rs2457!K2457_SizeQtyOutbound02)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound03) = False Then D2457.SizeQtyOutbound03 = Trim$(rs2457!K2457_SizeQtyOutbound03)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound04) = False Then D2457.SizeQtyOutbound04 = Trim$(rs2457!K2457_SizeQtyOutbound04)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound05) = False Then D2457.SizeQtyOutbound05 = Trim$(rs2457!K2457_SizeQtyOutbound05)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound06) = False Then D2457.SizeQtyOutbound06 = Trim$(rs2457!K2457_SizeQtyOutbound06)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound07) = False Then D2457.SizeQtyOutbound07 = Trim$(rs2457!K2457_SizeQtyOutbound07)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound08) = False Then D2457.SizeQtyOutbound08 = Trim$(rs2457!K2457_SizeQtyOutbound08)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound09) = False Then D2457.SizeQtyOutbound09 = Trim$(rs2457!K2457_SizeQtyOutbound09)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound10) = False Then D2457.SizeQtyOutbound10 = Trim$(rs2457!K2457_SizeQtyOutbound10)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound11) = False Then D2457.SizeQtyOutbound11 = Trim$(rs2457!K2457_SizeQtyOutbound11)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound12) = False Then D2457.SizeQtyOutbound12 = Trim$(rs2457!K2457_SizeQtyOutbound12)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound13) = False Then D2457.SizeQtyOutbound13 = Trim$(rs2457!K2457_SizeQtyOutbound13)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound14) = False Then D2457.SizeQtyOutbound14 = Trim$(rs2457!K2457_SizeQtyOutbound14)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound15) = False Then D2457.SizeQtyOutbound15 = Trim$(rs2457!K2457_SizeQtyOutbound15)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound16) = False Then D2457.SizeQtyOutbound16 = Trim$(rs2457!K2457_SizeQtyOutbound16)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound17) = False Then D2457.SizeQtyOutbound17 = Trim$(rs2457!K2457_SizeQtyOutbound17)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound18) = False Then D2457.SizeQtyOutbound18 = Trim$(rs2457!K2457_SizeQtyOutbound18)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound19) = False Then D2457.SizeQtyOutbound19 = Trim$(rs2457!K2457_SizeQtyOutbound19)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound20) = False Then D2457.SizeQtyOutbound20 = Trim$(rs2457!K2457_SizeQtyOutbound20)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound21) = False Then D2457.SizeQtyOutbound21 = Trim$(rs2457!K2457_SizeQtyOutbound21)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound22) = False Then D2457.SizeQtyOutbound22 = Trim$(rs2457!K2457_SizeQtyOutbound22)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound23) = False Then D2457.SizeQtyOutbound23 = Trim$(rs2457!K2457_SizeQtyOutbound23)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound24) = False Then D2457.SizeQtyOutbound24 = Trim$(rs2457!K2457_SizeQtyOutbound24)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound25) = False Then D2457.SizeQtyOutbound25 = Trim$(rs2457!K2457_SizeQtyOutbound25)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound26) = False Then D2457.SizeQtyOutbound26 = Trim$(rs2457!K2457_SizeQtyOutbound26)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound27) = False Then D2457.SizeQtyOutbound27 = Trim$(rs2457!K2457_SizeQtyOutbound27)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound28) = False Then D2457.SizeQtyOutbound28 = Trim$(rs2457!K2457_SizeQtyOutbound28)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound29) = False Then D2457.SizeQtyOutbound29 = Trim$(rs2457!K2457_SizeQtyOutbound29)
    If IsdbNull(rs2457!K2457_SizeQtyOutbound30) = False Then D2457.SizeQtyOutbound30 = Trim$(rs2457!K2457_SizeQtyOutbound30)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K2457_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K2457_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z2457 As T2457_AREA, PRODUCTOUTBOUNDNO AS String, PRODUCTOUTBOUNDSEQ AS String) as Boolean

K2457_MOVE = False

Try
    If READ_PFK2457(PRODUCTOUTBOUNDNO, PRODUCTOUTBOUNDSEQ) = True Then
                z2457 = D2457
		K2457_MOVE = True
		else
	z2457 = nothing
     End If

     If  getColumIndex(spr,"ProductOutboundNo") > -1 then z2457.ProductOutboundNo = getDataM(spr, getColumIndex(spr,"ProductOutboundNo"), xRow)
     If  getColumIndex(spr,"ProductOutboundSeq") > -1 then z2457.ProductOutboundSeq = getDataM(spr, getColumIndex(spr,"ProductOutboundSeq"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound01") > -1 then z2457.SizeQtyOutbound01 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound01"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound02") > -1 then z2457.SizeQtyOutbound02 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound02"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound03") > -1 then z2457.SizeQtyOutbound03 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound03"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound04") > -1 then z2457.SizeQtyOutbound04 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound04"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound05") > -1 then z2457.SizeQtyOutbound05 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound05"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound06") > -1 then z2457.SizeQtyOutbound06 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound06"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound07") > -1 then z2457.SizeQtyOutbound07 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound07"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound08") > -1 then z2457.SizeQtyOutbound08 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound08"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound09") > -1 then z2457.SizeQtyOutbound09 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound09"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound10") > -1 then z2457.SizeQtyOutbound10 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound10"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound11") > -1 then z2457.SizeQtyOutbound11 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound11"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound12") > -1 then z2457.SizeQtyOutbound12 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound12"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound13") > -1 then z2457.SizeQtyOutbound13 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound13"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound14") > -1 then z2457.SizeQtyOutbound14 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound14"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound15") > -1 then z2457.SizeQtyOutbound15 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound15"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound16") > -1 then z2457.SizeQtyOutbound16 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound16"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound17") > -1 then z2457.SizeQtyOutbound17 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound17"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound18") > -1 then z2457.SizeQtyOutbound18 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound18"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound19") > -1 then z2457.SizeQtyOutbound19 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound19"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound20") > -1 then z2457.SizeQtyOutbound20 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound20"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound21") > -1 then z2457.SizeQtyOutbound21 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound21"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound22") > -1 then z2457.SizeQtyOutbound22 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound22"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound23") > -1 then z2457.SizeQtyOutbound23 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound23"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound24") > -1 then z2457.SizeQtyOutbound24 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound24"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound25") > -1 then z2457.SizeQtyOutbound25 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound25"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound26") > -1 then z2457.SizeQtyOutbound26 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound26"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound27") > -1 then z2457.SizeQtyOutbound27 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound27"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound28") > -1 then z2457.SizeQtyOutbound28 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound28"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound29") > -1 then z2457.SizeQtyOutbound29 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound29"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound30") > -1 then z2457.SizeQtyOutbound30 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound30"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K2457_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K2457_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z2457 As T2457_AREA,CheckClear as Boolean,PRODUCTOUTBOUNDNO AS String, PRODUCTOUTBOUNDSEQ AS String) as Boolean

K2457_MOVE = False

Try
    If READ_PFK2457(PRODUCTOUTBOUNDNO, PRODUCTOUTBOUNDSEQ) = True Then
                z2457 = D2457
		K2457_MOVE = True
		else
	If CheckClear  = True then z2457 = nothing
     End If

     If  getColumIndex(spr,"ProductOutboundNo") > -1 then z2457.ProductOutboundNo = getDataM(spr, getColumIndex(spr,"ProductOutboundNo"), xRow)
     If  getColumIndex(spr,"ProductOutboundSeq") > -1 then z2457.ProductOutboundSeq = getDataM(spr, getColumIndex(spr,"ProductOutboundSeq"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound01") > -1 then z2457.SizeQtyOutbound01 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound01"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound02") > -1 then z2457.SizeQtyOutbound02 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound02"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound03") > -1 then z2457.SizeQtyOutbound03 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound03"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound04") > -1 then z2457.SizeQtyOutbound04 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound04"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound05") > -1 then z2457.SizeQtyOutbound05 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound05"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound06") > -1 then z2457.SizeQtyOutbound06 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound06"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound07") > -1 then z2457.SizeQtyOutbound07 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound07"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound08") > -1 then z2457.SizeQtyOutbound08 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound08"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound09") > -1 then z2457.SizeQtyOutbound09 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound09"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound10") > -1 then z2457.SizeQtyOutbound10 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound10"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound11") > -1 then z2457.SizeQtyOutbound11 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound11"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound12") > -1 then z2457.SizeQtyOutbound12 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound12"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound13") > -1 then z2457.SizeQtyOutbound13 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound13"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound14") > -1 then z2457.SizeQtyOutbound14 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound14"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound15") > -1 then z2457.SizeQtyOutbound15 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound15"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound16") > -1 then z2457.SizeQtyOutbound16 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound16"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound17") > -1 then z2457.SizeQtyOutbound17 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound17"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound18") > -1 then z2457.SizeQtyOutbound18 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound18"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound19") > -1 then z2457.SizeQtyOutbound19 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound19"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound20") > -1 then z2457.SizeQtyOutbound20 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound20"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound21") > -1 then z2457.SizeQtyOutbound21 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound21"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound22") > -1 then z2457.SizeQtyOutbound22 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound22"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound23") > -1 then z2457.SizeQtyOutbound23 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound23"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound24") > -1 then z2457.SizeQtyOutbound24 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound24"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound25") > -1 then z2457.SizeQtyOutbound25 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound25"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound26") > -1 then z2457.SizeQtyOutbound26 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound26"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound27") > -1 then z2457.SizeQtyOutbound27 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound27"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound28") > -1 then z2457.SizeQtyOutbound28 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound28"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound29") > -1 then z2457.SizeQtyOutbound29 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound29"), xRow)
     If  getColumIndex(spr,"SizeQtyOutbound30") > -1 then z2457.SizeQtyOutbound30 = getDataM(spr, getColumIndex(spr,"SizeQtyOutbound30"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K2457_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K2457_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z2457 As T2457_AREA, Job as String, PRODUCTOUTBOUNDNO AS String, PRODUCTOUTBOUNDSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K2457_MOVE = False

Try
    If READ_PFK2457(PRODUCTOUTBOUNDNO, PRODUCTOUTBOUNDSEQ) = True Then
                z2457 = D2457
		K2457_MOVE = True
		else
	z2457 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2457")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PRODUCTOUTBOUNDNO":z2457.ProductOutboundNo = Children(i).Code
   Case "PRODUCTOUTBOUNDSEQ":z2457.ProductOutboundSeq = Children(i).Code
   Case "SIZEQTYOUTBOUND01":z2457.SizeQtyOutbound01 = Children(i).Code
   Case "SIZEQTYOUTBOUND02":z2457.SizeQtyOutbound02 = Children(i).Code
   Case "SIZEQTYOUTBOUND03":z2457.SizeQtyOutbound03 = Children(i).Code
   Case "SIZEQTYOUTBOUND04":z2457.SizeQtyOutbound04 = Children(i).Code
   Case "SIZEQTYOUTBOUND05":z2457.SizeQtyOutbound05 = Children(i).Code
   Case "SIZEQTYOUTBOUND06":z2457.SizeQtyOutbound06 = Children(i).Code
   Case "SIZEQTYOUTBOUND07":z2457.SizeQtyOutbound07 = Children(i).Code
   Case "SIZEQTYOUTBOUND08":z2457.SizeQtyOutbound08 = Children(i).Code
   Case "SIZEQTYOUTBOUND09":z2457.SizeQtyOutbound09 = Children(i).Code
   Case "SIZEQTYOUTBOUND10":z2457.SizeQtyOutbound10 = Children(i).Code
   Case "SIZEQTYOUTBOUND11":z2457.SizeQtyOutbound11 = Children(i).Code
   Case "SIZEQTYOUTBOUND12":z2457.SizeQtyOutbound12 = Children(i).Code
   Case "SIZEQTYOUTBOUND13":z2457.SizeQtyOutbound13 = Children(i).Code
   Case "SIZEQTYOUTBOUND14":z2457.SizeQtyOutbound14 = Children(i).Code
   Case "SIZEQTYOUTBOUND15":z2457.SizeQtyOutbound15 = Children(i).Code
   Case "SIZEQTYOUTBOUND16":z2457.SizeQtyOutbound16 = Children(i).Code
   Case "SIZEQTYOUTBOUND17":z2457.SizeQtyOutbound17 = Children(i).Code
   Case "SIZEQTYOUTBOUND18":z2457.SizeQtyOutbound18 = Children(i).Code
   Case "SIZEQTYOUTBOUND19":z2457.SizeQtyOutbound19 = Children(i).Code
   Case "SIZEQTYOUTBOUND20":z2457.SizeQtyOutbound20 = Children(i).Code
   Case "SIZEQTYOUTBOUND21":z2457.SizeQtyOutbound21 = Children(i).Code
   Case "SIZEQTYOUTBOUND22":z2457.SizeQtyOutbound22 = Children(i).Code
   Case "SIZEQTYOUTBOUND23":z2457.SizeQtyOutbound23 = Children(i).Code
   Case "SIZEQTYOUTBOUND24":z2457.SizeQtyOutbound24 = Children(i).Code
   Case "SIZEQTYOUTBOUND25":z2457.SizeQtyOutbound25 = Children(i).Code
   Case "SIZEQTYOUTBOUND26":z2457.SizeQtyOutbound26 = Children(i).Code
   Case "SIZEQTYOUTBOUND27":z2457.SizeQtyOutbound27 = Children(i).Code
   Case "SIZEQTYOUTBOUND28":z2457.SizeQtyOutbound28 = Children(i).Code
   Case "SIZEQTYOUTBOUND29":z2457.SizeQtyOutbound29 = Children(i).Code
   Case "SIZEQTYOUTBOUND30":z2457.SizeQtyOutbound30 = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PRODUCTOUTBOUNDNO":z2457.ProductOutboundNo = Children(i).Data
   Case "PRODUCTOUTBOUNDSEQ":z2457.ProductOutboundSeq = Children(i).Data
   Case "SIZEQTYOUTBOUND01":z2457.SizeQtyOutbound01 = Children(i).Data
   Case "SIZEQTYOUTBOUND02":z2457.SizeQtyOutbound02 = Children(i).Data
   Case "SIZEQTYOUTBOUND03":z2457.SizeQtyOutbound03 = Children(i).Data
   Case "SIZEQTYOUTBOUND04":z2457.SizeQtyOutbound04 = Children(i).Data
   Case "SIZEQTYOUTBOUND05":z2457.SizeQtyOutbound05 = Children(i).Data
   Case "SIZEQTYOUTBOUND06":z2457.SizeQtyOutbound06 = Children(i).Data
   Case "SIZEQTYOUTBOUND07":z2457.SizeQtyOutbound07 = Children(i).Data
   Case "SIZEQTYOUTBOUND08":z2457.SizeQtyOutbound08 = Children(i).Data
   Case "SIZEQTYOUTBOUND09":z2457.SizeQtyOutbound09 = Children(i).Data
   Case "SIZEQTYOUTBOUND10":z2457.SizeQtyOutbound10 = Children(i).Data
   Case "SIZEQTYOUTBOUND11":z2457.SizeQtyOutbound11 = Children(i).Data
   Case "SIZEQTYOUTBOUND12":z2457.SizeQtyOutbound12 = Children(i).Data
   Case "SIZEQTYOUTBOUND13":z2457.SizeQtyOutbound13 = Children(i).Data
   Case "SIZEQTYOUTBOUND14":z2457.SizeQtyOutbound14 = Children(i).Data
   Case "SIZEQTYOUTBOUND15":z2457.SizeQtyOutbound15 = Children(i).Data
   Case "SIZEQTYOUTBOUND16":z2457.SizeQtyOutbound16 = Children(i).Data
   Case "SIZEQTYOUTBOUND17":z2457.SizeQtyOutbound17 = Children(i).Data
   Case "SIZEQTYOUTBOUND18":z2457.SizeQtyOutbound18 = Children(i).Data
   Case "SIZEQTYOUTBOUND19":z2457.SizeQtyOutbound19 = Children(i).Data
   Case "SIZEQTYOUTBOUND20":z2457.SizeQtyOutbound20 = Children(i).Data
   Case "SIZEQTYOUTBOUND21":z2457.SizeQtyOutbound21 = Children(i).Data
   Case "SIZEQTYOUTBOUND22":z2457.SizeQtyOutbound22 = Children(i).Data
   Case "SIZEQTYOUTBOUND23":z2457.SizeQtyOutbound23 = Children(i).Data
   Case "SIZEQTYOUTBOUND24":z2457.SizeQtyOutbound24 = Children(i).Data
   Case "SIZEQTYOUTBOUND25":z2457.SizeQtyOutbound25 = Children(i).Data
   Case "SIZEQTYOUTBOUND26":z2457.SizeQtyOutbound26 = Children(i).Data
   Case "SIZEQTYOUTBOUND27":z2457.SizeQtyOutbound27 = Children(i).Data
   Case "SIZEQTYOUTBOUND28":z2457.SizeQtyOutbound28 = Children(i).Data
   Case "SIZEQTYOUTBOUND29":z2457.SizeQtyOutbound29 = Children(i).Data
   Case "SIZEQTYOUTBOUND30":z2457.SizeQtyOutbound30 = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K2457_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K2457_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z2457 As T2457_AREA, Job as String, CheckClear as Boolean, PRODUCTOUTBOUNDNO AS String, PRODUCTOUTBOUNDSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K2457_MOVE = False

Try
    If READ_PFK2457(PRODUCTOUTBOUNDNO, PRODUCTOUTBOUNDSEQ) = True Then
                z2457 = D2457
		K2457_MOVE = True
		else
	If CheckClear  = True then z2457 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2457")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PRODUCTOUTBOUNDNO":z2457.ProductOutboundNo = Children(i).Code
   Case "PRODUCTOUTBOUNDSEQ":z2457.ProductOutboundSeq = Children(i).Code
   Case "SIZEQTYOUTBOUND01":z2457.SizeQtyOutbound01 = Children(i).Code
   Case "SIZEQTYOUTBOUND02":z2457.SizeQtyOutbound02 = Children(i).Code
   Case "SIZEQTYOUTBOUND03":z2457.SizeQtyOutbound03 = Children(i).Code
   Case "SIZEQTYOUTBOUND04":z2457.SizeQtyOutbound04 = Children(i).Code
   Case "SIZEQTYOUTBOUND05":z2457.SizeQtyOutbound05 = Children(i).Code
   Case "SIZEQTYOUTBOUND06":z2457.SizeQtyOutbound06 = Children(i).Code
   Case "SIZEQTYOUTBOUND07":z2457.SizeQtyOutbound07 = Children(i).Code
   Case "SIZEQTYOUTBOUND08":z2457.SizeQtyOutbound08 = Children(i).Code
   Case "SIZEQTYOUTBOUND09":z2457.SizeQtyOutbound09 = Children(i).Code
   Case "SIZEQTYOUTBOUND10":z2457.SizeQtyOutbound10 = Children(i).Code
   Case "SIZEQTYOUTBOUND11":z2457.SizeQtyOutbound11 = Children(i).Code
   Case "SIZEQTYOUTBOUND12":z2457.SizeQtyOutbound12 = Children(i).Code
   Case "SIZEQTYOUTBOUND13":z2457.SizeQtyOutbound13 = Children(i).Code
   Case "SIZEQTYOUTBOUND14":z2457.SizeQtyOutbound14 = Children(i).Code
   Case "SIZEQTYOUTBOUND15":z2457.SizeQtyOutbound15 = Children(i).Code
   Case "SIZEQTYOUTBOUND16":z2457.SizeQtyOutbound16 = Children(i).Code
   Case "SIZEQTYOUTBOUND17":z2457.SizeQtyOutbound17 = Children(i).Code
   Case "SIZEQTYOUTBOUND18":z2457.SizeQtyOutbound18 = Children(i).Code
   Case "SIZEQTYOUTBOUND19":z2457.SizeQtyOutbound19 = Children(i).Code
   Case "SIZEQTYOUTBOUND20":z2457.SizeQtyOutbound20 = Children(i).Code
   Case "SIZEQTYOUTBOUND21":z2457.SizeQtyOutbound21 = Children(i).Code
   Case "SIZEQTYOUTBOUND22":z2457.SizeQtyOutbound22 = Children(i).Code
   Case "SIZEQTYOUTBOUND23":z2457.SizeQtyOutbound23 = Children(i).Code
   Case "SIZEQTYOUTBOUND24":z2457.SizeQtyOutbound24 = Children(i).Code
   Case "SIZEQTYOUTBOUND25":z2457.SizeQtyOutbound25 = Children(i).Code
   Case "SIZEQTYOUTBOUND26":z2457.SizeQtyOutbound26 = Children(i).Code
   Case "SIZEQTYOUTBOUND27":z2457.SizeQtyOutbound27 = Children(i).Code
   Case "SIZEQTYOUTBOUND28":z2457.SizeQtyOutbound28 = Children(i).Code
   Case "SIZEQTYOUTBOUND29":z2457.SizeQtyOutbound29 = Children(i).Code
   Case "SIZEQTYOUTBOUND30":z2457.SizeQtyOutbound30 = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PRODUCTOUTBOUNDNO":z2457.ProductOutboundNo = Children(i).Data
   Case "PRODUCTOUTBOUNDSEQ":z2457.ProductOutboundSeq = Children(i).Data
   Case "SIZEQTYOUTBOUND01":z2457.SizeQtyOutbound01 = Children(i).Data
   Case "SIZEQTYOUTBOUND02":z2457.SizeQtyOutbound02 = Children(i).Data
   Case "SIZEQTYOUTBOUND03":z2457.SizeQtyOutbound03 = Children(i).Data
   Case "SIZEQTYOUTBOUND04":z2457.SizeQtyOutbound04 = Children(i).Data
   Case "SIZEQTYOUTBOUND05":z2457.SizeQtyOutbound05 = Children(i).Data
   Case "SIZEQTYOUTBOUND06":z2457.SizeQtyOutbound06 = Children(i).Data
   Case "SIZEQTYOUTBOUND07":z2457.SizeQtyOutbound07 = Children(i).Data
   Case "SIZEQTYOUTBOUND08":z2457.SizeQtyOutbound08 = Children(i).Data
   Case "SIZEQTYOUTBOUND09":z2457.SizeQtyOutbound09 = Children(i).Data
   Case "SIZEQTYOUTBOUND10":z2457.SizeQtyOutbound10 = Children(i).Data
   Case "SIZEQTYOUTBOUND11":z2457.SizeQtyOutbound11 = Children(i).Data
   Case "SIZEQTYOUTBOUND12":z2457.SizeQtyOutbound12 = Children(i).Data
   Case "SIZEQTYOUTBOUND13":z2457.SizeQtyOutbound13 = Children(i).Data
   Case "SIZEQTYOUTBOUND14":z2457.SizeQtyOutbound14 = Children(i).Data
   Case "SIZEQTYOUTBOUND15":z2457.SizeQtyOutbound15 = Children(i).Data
   Case "SIZEQTYOUTBOUND16":z2457.SizeQtyOutbound16 = Children(i).Data
   Case "SIZEQTYOUTBOUND17":z2457.SizeQtyOutbound17 = Children(i).Data
   Case "SIZEQTYOUTBOUND18":z2457.SizeQtyOutbound18 = Children(i).Data
   Case "SIZEQTYOUTBOUND19":z2457.SizeQtyOutbound19 = Children(i).Data
   Case "SIZEQTYOUTBOUND20":z2457.SizeQtyOutbound20 = Children(i).Data
   Case "SIZEQTYOUTBOUND21":z2457.SizeQtyOutbound21 = Children(i).Data
   Case "SIZEQTYOUTBOUND22":z2457.SizeQtyOutbound22 = Children(i).Data
   Case "SIZEQTYOUTBOUND23":z2457.SizeQtyOutbound23 = Children(i).Data
   Case "SIZEQTYOUTBOUND24":z2457.SizeQtyOutbound24 = Children(i).Data
   Case "SIZEQTYOUTBOUND25":z2457.SizeQtyOutbound25 = Children(i).Data
   Case "SIZEQTYOUTBOUND26":z2457.SizeQtyOutbound26 = Children(i).Data
   Case "SIZEQTYOUTBOUND27":z2457.SizeQtyOutbound27 = Children(i).Data
   Case "SIZEQTYOUTBOUND28":z2457.SizeQtyOutbound28 = Children(i).Data
   Case "SIZEQTYOUTBOUND29":z2457.SizeQtyOutbound29 = Children(i).Data
   Case "SIZEQTYOUTBOUND30":z2457.SizeQtyOutbound30 = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K2457_MOVE",vbCritical)
End Try
End Function 
    
End Module 
