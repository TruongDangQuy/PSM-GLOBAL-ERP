'=========================================================================================================================================================
'   TABLE : (PFK3424)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K3424

Structure T3424_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	FactOrderNo	 AS String	'			char(9)		*
Public 	FactOrderSeq	 AS Double	'			decimal		*
Public 	SizeQty01	 AS Double	'			decimal
Public 	SizeQty02	 AS Double	'			decimal
Public 	SizeQty03	 AS Double	'			decimal
Public 	SizeQty04	 AS Double	'			decimal
Public 	SizeQty05	 AS Double	'			decimal
Public 	SizeQty06	 AS Double	'			decimal
Public 	SizeQty07	 AS Double	'			decimal
Public 	SizeQty08	 AS Double	'			decimal
Public 	SizeQty09	 AS Double	'			decimal
Public 	SizeQty10	 AS Double	'			decimal
Public 	SizeQty11	 AS Double	'			decimal
Public 	SizeQty12	 AS Double	'			decimal
Public 	SizeQty13	 AS Double	'			decimal
Public 	SizeQty14	 AS Double	'			decimal
Public 	SizeQty15	 AS Double	'			decimal
Public 	SizeQty16	 AS Double	'			decimal
Public 	SizeQty17	 AS Double	'			decimal
Public 	SizeQty18	 AS Double	'			decimal
Public 	SizeQty19	 AS Double	'			decimal
Public 	SizeQty20	 AS Double	'			decimal
Public 	SizeQty21	 AS Double	'			decimal
Public 	SizeQty22	 AS Double	'			decimal
Public 	SizeQty23	 AS Double	'			decimal
Public 	SizeQty24	 AS Double	'			decimal
Public 	SizeQty25	 AS Double	'			decimal
Public 	SizeQty26	 AS Double	'			decimal
Public 	SizeQty27	 AS Double	'			decimal
Public 	SizeQty28	 AS Double	'			decimal
Public 	SizeQty29	 AS Double	'			decimal
Public 	SizeQty30	 AS Double	'			decimal
Public 	Remark	 AS String	'			nvarchar(500)
'=========================================================================================================================================================
End structure

Public D3424 As T3424_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK3424(FACTORDERNO AS String, FACTORDERSEQ AS Double) As Boolean
    READ_PFK3424 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3424 "
    SQL = SQL & " WHERE K3424_FactOrderNo		 = '" & FactOrderNo & "' " 
    SQL = SQL & "   AND K3424_FactOrderSeq		 =  " & FactOrderSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D3424_CLEAR: GoTo SKIP_READ_PFK3424
                
    Call K3424_MOVE(rd)
    READ_PFK3424 = True

SKIP_READ_PFK3424:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK3424",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK3424(FACTORDERNO AS String, FACTORDERSEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3424 "
    SQL = SQL & " WHERE K3424_FactOrderNo		 = '" & FactOrderNo & "' " 
    SQL = SQL & "   AND K3424_FactOrderSeq		 =  " & FactOrderSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK3424",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK3424(z3424 As T3424_AREA) As Boolean
    WRITE_PFK3424 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z3424)
 
    SQL = " INSERT INTO PFK3424 "
    SQL = SQL & " ( "
    SQL = SQL & " K3424_FactOrderNo," 
    SQL = SQL & " K3424_FactOrderSeq," 
    SQL = SQL & " K3424_SizeQty01," 
    SQL = SQL & " K3424_SizeQty02," 
    SQL = SQL & " K3424_SizeQty03," 
    SQL = SQL & " K3424_SizeQty04," 
    SQL = SQL & " K3424_SizeQty05," 
    SQL = SQL & " K3424_SizeQty06," 
    SQL = SQL & " K3424_SizeQty07," 
    SQL = SQL & " K3424_SizeQty08," 
    SQL = SQL & " K3424_SizeQty09," 
    SQL = SQL & " K3424_SizeQty10," 
    SQL = SQL & " K3424_SizeQty11," 
    SQL = SQL & " K3424_SizeQty12," 
    SQL = SQL & " K3424_SizeQty13," 
    SQL = SQL & " K3424_SizeQty14," 
    SQL = SQL & " K3424_SizeQty15," 
    SQL = SQL & " K3424_SizeQty16," 
    SQL = SQL & " K3424_SizeQty17," 
    SQL = SQL & " K3424_SizeQty18," 
    SQL = SQL & " K3424_SizeQty19," 
    SQL = SQL & " K3424_SizeQty20," 
    SQL = SQL & " K3424_SizeQty21," 
    SQL = SQL & " K3424_SizeQty22," 
    SQL = SQL & " K3424_SizeQty23," 
    SQL = SQL & " K3424_SizeQty24," 
    SQL = SQL & " K3424_SizeQty25," 
    SQL = SQL & " K3424_SizeQty26," 
    SQL = SQL & " K3424_SizeQty27," 
    SQL = SQL & " K3424_SizeQty28," 
    SQL = SQL & " K3424_SizeQty29," 
    SQL = SQL & " K3424_SizeQty30," 
    SQL = SQL & " K3424_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z3424.FactOrderNo) & "', "  
    SQL = SQL & "   " & FormatSQL(z3424.FactOrderSeq) & ", "  
    SQL = SQL & "   " & FormatSQL(z3424.SizeQty01) & ", "  
    SQL = SQL & "   " & FormatSQL(z3424.SizeQty02) & ", "  
    SQL = SQL & "   " & FormatSQL(z3424.SizeQty03) & ", "  
    SQL = SQL & "   " & FormatSQL(z3424.SizeQty04) & ", "  
    SQL = SQL & "   " & FormatSQL(z3424.SizeQty05) & ", "  
    SQL = SQL & "   " & FormatSQL(z3424.SizeQty06) & ", "  
    SQL = SQL & "   " & FormatSQL(z3424.SizeQty07) & ", "  
    SQL = SQL & "   " & FormatSQL(z3424.SizeQty08) & ", "  
    SQL = SQL & "   " & FormatSQL(z3424.SizeQty09) & ", "  
    SQL = SQL & "   " & FormatSQL(z3424.SizeQty10) & ", "  
    SQL = SQL & "   " & FormatSQL(z3424.SizeQty11) & ", "  
    SQL = SQL & "   " & FormatSQL(z3424.SizeQty12) & ", "  
    SQL = SQL & "   " & FormatSQL(z3424.SizeQty13) & ", "  
    SQL = SQL & "   " & FormatSQL(z3424.SizeQty14) & ", "  
    SQL = SQL & "   " & FormatSQL(z3424.SizeQty15) & ", "  
    SQL = SQL & "   " & FormatSQL(z3424.SizeQty16) & ", "  
    SQL = SQL & "   " & FormatSQL(z3424.SizeQty17) & ", "  
    SQL = SQL & "   " & FormatSQL(z3424.SizeQty18) & ", "  
    SQL = SQL & "   " & FormatSQL(z3424.SizeQty19) & ", "  
    SQL = SQL & "   " & FormatSQL(z3424.SizeQty20) & ", "  
    SQL = SQL & "   " & FormatSQL(z3424.SizeQty21) & ", "  
    SQL = SQL & "   " & FormatSQL(z3424.SizeQty22) & ", "  
    SQL = SQL & "   " & FormatSQL(z3424.SizeQty23) & ", "  
    SQL = SQL & "   " & FormatSQL(z3424.SizeQty24) & ", "  
    SQL = SQL & "   " & FormatSQL(z3424.SizeQty25) & ", "  
    SQL = SQL & "   " & FormatSQL(z3424.SizeQty26) & ", "  
    SQL = SQL & "   " & FormatSQL(z3424.SizeQty27) & ", "  
    SQL = SQL & "   " & FormatSQL(z3424.SizeQty28) & ", "  
    SQL = SQL & "   " & FormatSQL(z3424.SizeQty29) & ", "  
    SQL = SQL & "   " & FormatSQL(z3424.SizeQty30) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3424.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK3424 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK3424",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK3424(z3424 As T3424_AREA) As Boolean
    REWRITE_PFK3424 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z3424)
   
    SQL = " UPDATE PFK3424 SET "
    SQL = SQL & "    K3424_SizeQty01      =  " & FormatSQL(z3424.SizeQty01) & ", " 
    SQL = SQL & "    K3424_SizeQty02      =  " & FormatSQL(z3424.SizeQty02) & ", " 
    SQL = SQL & "    K3424_SizeQty03      =  " & FormatSQL(z3424.SizeQty03) & ", " 
    SQL = SQL & "    K3424_SizeQty04      =  " & FormatSQL(z3424.SizeQty04) & ", " 
    SQL = SQL & "    K3424_SizeQty05      =  " & FormatSQL(z3424.SizeQty05) & ", " 
    SQL = SQL & "    K3424_SizeQty06      =  " & FormatSQL(z3424.SizeQty06) & ", " 
    SQL = SQL & "    K3424_SizeQty07      =  " & FormatSQL(z3424.SizeQty07) & ", " 
    SQL = SQL & "    K3424_SizeQty08      =  " & FormatSQL(z3424.SizeQty08) & ", " 
    SQL = SQL & "    K3424_SizeQty09      =  " & FormatSQL(z3424.SizeQty09) & ", " 
    SQL = SQL & "    K3424_SizeQty10      =  " & FormatSQL(z3424.SizeQty10) & ", " 
    SQL = SQL & "    K3424_SizeQty11      =  " & FormatSQL(z3424.SizeQty11) & ", " 
    SQL = SQL & "    K3424_SizeQty12      =  " & FormatSQL(z3424.SizeQty12) & ", " 
    SQL = SQL & "    K3424_SizeQty13      =  " & FormatSQL(z3424.SizeQty13) & ", " 
    SQL = SQL & "    K3424_SizeQty14      =  " & FormatSQL(z3424.SizeQty14) & ", " 
    SQL = SQL & "    K3424_SizeQty15      =  " & FormatSQL(z3424.SizeQty15) & ", " 
    SQL = SQL & "    K3424_SizeQty16      =  " & FormatSQL(z3424.SizeQty16) & ", " 
    SQL = SQL & "    K3424_SizeQty17      =  " & FormatSQL(z3424.SizeQty17) & ", " 
    SQL = SQL & "    K3424_SizeQty18      =  " & FormatSQL(z3424.SizeQty18) & ", " 
    SQL = SQL & "    K3424_SizeQty19      =  " & FormatSQL(z3424.SizeQty19) & ", " 
    SQL = SQL & "    K3424_SizeQty20      =  " & FormatSQL(z3424.SizeQty20) & ", " 
    SQL = SQL & "    K3424_SizeQty21      =  " & FormatSQL(z3424.SizeQty21) & ", " 
    SQL = SQL & "    K3424_SizeQty22      =  " & FormatSQL(z3424.SizeQty22) & ", " 
    SQL = SQL & "    K3424_SizeQty23      =  " & FormatSQL(z3424.SizeQty23) & ", " 
    SQL = SQL & "    K3424_SizeQty24      =  " & FormatSQL(z3424.SizeQty24) & ", " 
    SQL = SQL & "    K3424_SizeQty25      =  " & FormatSQL(z3424.SizeQty25) & ", " 
    SQL = SQL & "    K3424_SizeQty26      =  " & FormatSQL(z3424.SizeQty26) & ", " 
    SQL = SQL & "    K3424_SizeQty27      =  " & FormatSQL(z3424.SizeQty27) & ", " 
    SQL = SQL & "    K3424_SizeQty28      =  " & FormatSQL(z3424.SizeQty28) & ", " 
    SQL = SQL & "    K3424_SizeQty29      =  " & FormatSQL(z3424.SizeQty29) & ", " 
    SQL = SQL & "    K3424_SizeQty30      =  " & FormatSQL(z3424.SizeQty30) & ", " 
    SQL = SQL & "    K3424_Remark      = N'" & FormatSQL(z3424.Remark) & "'  " 
    SQL = SQL & " WHERE K3424_FactOrderNo		 = '" & z3424.FactOrderNo & "' " 
    SQL = SQL & "   AND K3424_FactOrderSeq		 =  " & z3424.FactOrderSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK3424 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK3424",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK3424(z3424 As T3424_AREA) As Boolean
    DELETE_PFK3424 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK3424 "
    SQL = SQL & " WHERE K3424_FactOrderNo		 = '" & z3424.FactOrderNo & "' " 
    SQL = SQL & "   AND K3424_FactOrderSeq		 =  " & z3424.FactOrderSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK3424 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK3424",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D3424_CLEAR()
Try
    
   D3424.FactOrderNo = ""
    D3424.FactOrderSeq = 0 
    D3424.SizeQty01 = 0 
    D3424.SizeQty02 = 0 
    D3424.SizeQty03 = 0 
    D3424.SizeQty04 = 0 
    D3424.SizeQty05 = 0 
    D3424.SizeQty06 = 0 
    D3424.SizeQty07 = 0 
    D3424.SizeQty08 = 0 
    D3424.SizeQty09 = 0 
    D3424.SizeQty10 = 0 
    D3424.SizeQty11 = 0 
    D3424.SizeQty12 = 0 
    D3424.SizeQty13 = 0 
    D3424.SizeQty14 = 0 
    D3424.SizeQty15 = 0 
    D3424.SizeQty16 = 0 
    D3424.SizeQty17 = 0 
    D3424.SizeQty18 = 0 
    D3424.SizeQty19 = 0 
    D3424.SizeQty20 = 0 
    D3424.SizeQty21 = 0 
    D3424.SizeQty22 = 0 
    D3424.SizeQty23 = 0 
    D3424.SizeQty24 = 0 
    D3424.SizeQty25 = 0 
    D3424.SizeQty26 = 0 
    D3424.SizeQty27 = 0 
    D3424.SizeQty28 = 0 
    D3424.SizeQty29 = 0 
    D3424.SizeQty30 = 0 
   D3424.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D3424_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x3424 As T3424_AREA)
Try
    
    x3424.FactOrderNo = trim$(  x3424.FactOrderNo)
    x3424.FactOrderSeq = trim$(  x3424.FactOrderSeq)
    x3424.SizeQty01 = trim$(  x3424.SizeQty01)
    x3424.SizeQty02 = trim$(  x3424.SizeQty02)
    x3424.SizeQty03 = trim$(  x3424.SizeQty03)
    x3424.SizeQty04 = trim$(  x3424.SizeQty04)
    x3424.SizeQty05 = trim$(  x3424.SizeQty05)
    x3424.SizeQty06 = trim$(  x3424.SizeQty06)
    x3424.SizeQty07 = trim$(  x3424.SizeQty07)
    x3424.SizeQty08 = trim$(  x3424.SizeQty08)
    x3424.SizeQty09 = trim$(  x3424.SizeQty09)
    x3424.SizeQty10 = trim$(  x3424.SizeQty10)
    x3424.SizeQty11 = trim$(  x3424.SizeQty11)
    x3424.SizeQty12 = trim$(  x3424.SizeQty12)
    x3424.SizeQty13 = trim$(  x3424.SizeQty13)
    x3424.SizeQty14 = trim$(  x3424.SizeQty14)
    x3424.SizeQty15 = trim$(  x3424.SizeQty15)
    x3424.SizeQty16 = trim$(  x3424.SizeQty16)
    x3424.SizeQty17 = trim$(  x3424.SizeQty17)
    x3424.SizeQty18 = trim$(  x3424.SizeQty18)
    x3424.SizeQty19 = trim$(  x3424.SizeQty19)
    x3424.SizeQty20 = trim$(  x3424.SizeQty20)
    x3424.SizeQty21 = trim$(  x3424.SizeQty21)
    x3424.SizeQty22 = trim$(  x3424.SizeQty22)
    x3424.SizeQty23 = trim$(  x3424.SizeQty23)
    x3424.SizeQty24 = trim$(  x3424.SizeQty24)
    x3424.SizeQty25 = trim$(  x3424.SizeQty25)
    x3424.SizeQty26 = trim$(  x3424.SizeQty26)
    x3424.SizeQty27 = trim$(  x3424.SizeQty27)
    x3424.SizeQty28 = trim$(  x3424.SizeQty28)
    x3424.SizeQty29 = trim$(  x3424.SizeQty29)
    x3424.SizeQty30 = trim$(  x3424.SizeQty30)
    x3424.Remark = trim$(  x3424.Remark)
     
    If trim$( x3424.FactOrderNo ) = "" Then x3424.FactOrderNo = Space(1) 
    If trim$( x3424.FactOrderSeq ) = "" Then x3424.FactOrderSeq = 0 
    If trim$( x3424.SizeQty01 ) = "" Then x3424.SizeQty01 = 0 
    If trim$( x3424.SizeQty02 ) = "" Then x3424.SizeQty02 = 0 
    If trim$( x3424.SizeQty03 ) = "" Then x3424.SizeQty03 = 0 
    If trim$( x3424.SizeQty04 ) = "" Then x3424.SizeQty04 = 0 
    If trim$( x3424.SizeQty05 ) = "" Then x3424.SizeQty05 = 0 
    If trim$( x3424.SizeQty06 ) = "" Then x3424.SizeQty06 = 0 
    If trim$( x3424.SizeQty07 ) = "" Then x3424.SizeQty07 = 0 
    If trim$( x3424.SizeQty08 ) = "" Then x3424.SizeQty08 = 0 
    If trim$( x3424.SizeQty09 ) = "" Then x3424.SizeQty09 = 0 
    If trim$( x3424.SizeQty10 ) = "" Then x3424.SizeQty10 = 0 
    If trim$( x3424.SizeQty11 ) = "" Then x3424.SizeQty11 = 0 
    If trim$( x3424.SizeQty12 ) = "" Then x3424.SizeQty12 = 0 
    If trim$( x3424.SizeQty13 ) = "" Then x3424.SizeQty13 = 0 
    If trim$( x3424.SizeQty14 ) = "" Then x3424.SizeQty14 = 0 
    If trim$( x3424.SizeQty15 ) = "" Then x3424.SizeQty15 = 0 
    If trim$( x3424.SizeQty16 ) = "" Then x3424.SizeQty16 = 0 
    If trim$( x3424.SizeQty17 ) = "" Then x3424.SizeQty17 = 0 
    If trim$( x3424.SizeQty18 ) = "" Then x3424.SizeQty18 = 0 
    If trim$( x3424.SizeQty19 ) = "" Then x3424.SizeQty19 = 0 
    If trim$( x3424.SizeQty20 ) = "" Then x3424.SizeQty20 = 0 
    If trim$( x3424.SizeQty21 ) = "" Then x3424.SizeQty21 = 0 
    If trim$( x3424.SizeQty22 ) = "" Then x3424.SizeQty22 = 0 
    If trim$( x3424.SizeQty23 ) = "" Then x3424.SizeQty23 = 0 
    If trim$( x3424.SizeQty24 ) = "" Then x3424.SizeQty24 = 0 
    If trim$( x3424.SizeQty25 ) = "" Then x3424.SizeQty25 = 0 
    If trim$( x3424.SizeQty26 ) = "" Then x3424.SizeQty26 = 0 
    If trim$( x3424.SizeQty27 ) = "" Then x3424.SizeQty27 = 0 
    If trim$( x3424.SizeQty28 ) = "" Then x3424.SizeQty28 = 0 
    If trim$( x3424.SizeQty29 ) = "" Then x3424.SizeQty29 = 0 
    If trim$( x3424.SizeQty30 ) = "" Then x3424.SizeQty30 = 0 
    If trim$( x3424.Remark ) = "" Then x3424.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K3424_MOVE(rs3424 As SqlClient.SqlDataReader)
Try

    call D3424_CLEAR()   

    If IsdbNull(rs3424!K3424_FactOrderNo) = False Then D3424.FactOrderNo = Trim$(rs3424!K3424_FactOrderNo)
    If IsdbNull(rs3424!K3424_FactOrderSeq) = False Then D3424.FactOrderSeq = Trim$(rs3424!K3424_FactOrderSeq)
    If IsdbNull(rs3424!K3424_SizeQty01) = False Then D3424.SizeQty01 = Trim$(rs3424!K3424_SizeQty01)
    If IsdbNull(rs3424!K3424_SizeQty02) = False Then D3424.SizeQty02 = Trim$(rs3424!K3424_SizeQty02)
    If IsdbNull(rs3424!K3424_SizeQty03) = False Then D3424.SizeQty03 = Trim$(rs3424!K3424_SizeQty03)
    If IsdbNull(rs3424!K3424_SizeQty04) = False Then D3424.SizeQty04 = Trim$(rs3424!K3424_SizeQty04)
    If IsdbNull(rs3424!K3424_SizeQty05) = False Then D3424.SizeQty05 = Trim$(rs3424!K3424_SizeQty05)
    If IsdbNull(rs3424!K3424_SizeQty06) = False Then D3424.SizeQty06 = Trim$(rs3424!K3424_SizeQty06)
    If IsdbNull(rs3424!K3424_SizeQty07) = False Then D3424.SizeQty07 = Trim$(rs3424!K3424_SizeQty07)
    If IsdbNull(rs3424!K3424_SizeQty08) = False Then D3424.SizeQty08 = Trim$(rs3424!K3424_SizeQty08)
    If IsdbNull(rs3424!K3424_SizeQty09) = False Then D3424.SizeQty09 = Trim$(rs3424!K3424_SizeQty09)
    If IsdbNull(rs3424!K3424_SizeQty10) = False Then D3424.SizeQty10 = Trim$(rs3424!K3424_SizeQty10)
    If IsdbNull(rs3424!K3424_SizeQty11) = False Then D3424.SizeQty11 = Trim$(rs3424!K3424_SizeQty11)
    If IsdbNull(rs3424!K3424_SizeQty12) = False Then D3424.SizeQty12 = Trim$(rs3424!K3424_SizeQty12)
    If IsdbNull(rs3424!K3424_SizeQty13) = False Then D3424.SizeQty13 = Trim$(rs3424!K3424_SizeQty13)
    If IsdbNull(rs3424!K3424_SizeQty14) = False Then D3424.SizeQty14 = Trim$(rs3424!K3424_SizeQty14)
    If IsdbNull(rs3424!K3424_SizeQty15) = False Then D3424.SizeQty15 = Trim$(rs3424!K3424_SizeQty15)
    If IsdbNull(rs3424!K3424_SizeQty16) = False Then D3424.SizeQty16 = Trim$(rs3424!K3424_SizeQty16)
    If IsdbNull(rs3424!K3424_SizeQty17) = False Then D3424.SizeQty17 = Trim$(rs3424!K3424_SizeQty17)
    If IsdbNull(rs3424!K3424_SizeQty18) = False Then D3424.SizeQty18 = Trim$(rs3424!K3424_SizeQty18)
    If IsdbNull(rs3424!K3424_SizeQty19) = False Then D3424.SizeQty19 = Trim$(rs3424!K3424_SizeQty19)
    If IsdbNull(rs3424!K3424_SizeQty20) = False Then D3424.SizeQty20 = Trim$(rs3424!K3424_SizeQty20)
    If IsdbNull(rs3424!K3424_SizeQty21) = False Then D3424.SizeQty21 = Trim$(rs3424!K3424_SizeQty21)
    If IsdbNull(rs3424!K3424_SizeQty22) = False Then D3424.SizeQty22 = Trim$(rs3424!K3424_SizeQty22)
    If IsdbNull(rs3424!K3424_SizeQty23) = False Then D3424.SizeQty23 = Trim$(rs3424!K3424_SizeQty23)
    If IsdbNull(rs3424!K3424_SizeQty24) = False Then D3424.SizeQty24 = Trim$(rs3424!K3424_SizeQty24)
    If IsdbNull(rs3424!K3424_SizeQty25) = False Then D3424.SizeQty25 = Trim$(rs3424!K3424_SizeQty25)
    If IsdbNull(rs3424!K3424_SizeQty26) = False Then D3424.SizeQty26 = Trim$(rs3424!K3424_SizeQty26)
    If IsdbNull(rs3424!K3424_SizeQty27) = False Then D3424.SizeQty27 = Trim$(rs3424!K3424_SizeQty27)
    If IsdbNull(rs3424!K3424_SizeQty28) = False Then D3424.SizeQty28 = Trim$(rs3424!K3424_SizeQty28)
    If IsdbNull(rs3424!K3424_SizeQty29) = False Then D3424.SizeQty29 = Trim$(rs3424!K3424_SizeQty29)
    If IsdbNull(rs3424!K3424_SizeQty30) = False Then D3424.SizeQty30 = Trim$(rs3424!K3424_SizeQty30)
    If IsdbNull(rs3424!K3424_Remark) = False Then D3424.Remark = Trim$(rs3424!K3424_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3424_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K3424_MOVE(rs3424 As DataRow)
Try

    call D3424_CLEAR()   

    If IsdbNull(rs3424!K3424_FactOrderNo) = False Then D3424.FactOrderNo = Trim$(rs3424!K3424_FactOrderNo)
    If IsdbNull(rs3424!K3424_FactOrderSeq) = False Then D3424.FactOrderSeq = Trim$(rs3424!K3424_FactOrderSeq)
    If IsdbNull(rs3424!K3424_SizeQty01) = False Then D3424.SizeQty01 = Trim$(rs3424!K3424_SizeQty01)
    If IsdbNull(rs3424!K3424_SizeQty02) = False Then D3424.SizeQty02 = Trim$(rs3424!K3424_SizeQty02)
    If IsdbNull(rs3424!K3424_SizeQty03) = False Then D3424.SizeQty03 = Trim$(rs3424!K3424_SizeQty03)
    If IsdbNull(rs3424!K3424_SizeQty04) = False Then D3424.SizeQty04 = Trim$(rs3424!K3424_SizeQty04)
    If IsdbNull(rs3424!K3424_SizeQty05) = False Then D3424.SizeQty05 = Trim$(rs3424!K3424_SizeQty05)
    If IsdbNull(rs3424!K3424_SizeQty06) = False Then D3424.SizeQty06 = Trim$(rs3424!K3424_SizeQty06)
    If IsdbNull(rs3424!K3424_SizeQty07) = False Then D3424.SizeQty07 = Trim$(rs3424!K3424_SizeQty07)
    If IsdbNull(rs3424!K3424_SizeQty08) = False Then D3424.SizeQty08 = Trim$(rs3424!K3424_SizeQty08)
    If IsdbNull(rs3424!K3424_SizeQty09) = False Then D3424.SizeQty09 = Trim$(rs3424!K3424_SizeQty09)
    If IsdbNull(rs3424!K3424_SizeQty10) = False Then D3424.SizeQty10 = Trim$(rs3424!K3424_SizeQty10)
    If IsdbNull(rs3424!K3424_SizeQty11) = False Then D3424.SizeQty11 = Trim$(rs3424!K3424_SizeQty11)
    If IsdbNull(rs3424!K3424_SizeQty12) = False Then D3424.SizeQty12 = Trim$(rs3424!K3424_SizeQty12)
    If IsdbNull(rs3424!K3424_SizeQty13) = False Then D3424.SizeQty13 = Trim$(rs3424!K3424_SizeQty13)
    If IsdbNull(rs3424!K3424_SizeQty14) = False Then D3424.SizeQty14 = Trim$(rs3424!K3424_SizeQty14)
    If IsdbNull(rs3424!K3424_SizeQty15) = False Then D3424.SizeQty15 = Trim$(rs3424!K3424_SizeQty15)
    If IsdbNull(rs3424!K3424_SizeQty16) = False Then D3424.SizeQty16 = Trim$(rs3424!K3424_SizeQty16)
    If IsdbNull(rs3424!K3424_SizeQty17) = False Then D3424.SizeQty17 = Trim$(rs3424!K3424_SizeQty17)
    If IsdbNull(rs3424!K3424_SizeQty18) = False Then D3424.SizeQty18 = Trim$(rs3424!K3424_SizeQty18)
    If IsdbNull(rs3424!K3424_SizeQty19) = False Then D3424.SizeQty19 = Trim$(rs3424!K3424_SizeQty19)
    If IsdbNull(rs3424!K3424_SizeQty20) = False Then D3424.SizeQty20 = Trim$(rs3424!K3424_SizeQty20)
    If IsdbNull(rs3424!K3424_SizeQty21) = False Then D3424.SizeQty21 = Trim$(rs3424!K3424_SizeQty21)
    If IsdbNull(rs3424!K3424_SizeQty22) = False Then D3424.SizeQty22 = Trim$(rs3424!K3424_SizeQty22)
    If IsdbNull(rs3424!K3424_SizeQty23) = False Then D3424.SizeQty23 = Trim$(rs3424!K3424_SizeQty23)
    If IsdbNull(rs3424!K3424_SizeQty24) = False Then D3424.SizeQty24 = Trim$(rs3424!K3424_SizeQty24)
    If IsdbNull(rs3424!K3424_SizeQty25) = False Then D3424.SizeQty25 = Trim$(rs3424!K3424_SizeQty25)
    If IsdbNull(rs3424!K3424_SizeQty26) = False Then D3424.SizeQty26 = Trim$(rs3424!K3424_SizeQty26)
    If IsdbNull(rs3424!K3424_SizeQty27) = False Then D3424.SizeQty27 = Trim$(rs3424!K3424_SizeQty27)
    If IsdbNull(rs3424!K3424_SizeQty28) = False Then D3424.SizeQty28 = Trim$(rs3424!K3424_SizeQty28)
    If IsdbNull(rs3424!K3424_SizeQty29) = False Then D3424.SizeQty29 = Trim$(rs3424!K3424_SizeQty29)
    If IsdbNull(rs3424!K3424_SizeQty30) = False Then D3424.SizeQty30 = Trim$(rs3424!K3424_SizeQty30)
    If IsdbNull(rs3424!K3424_Remark) = False Then D3424.Remark = Trim$(rs3424!K3424_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3424_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K3424_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3424 As T3424_AREA, FACTORDERNO AS String, FACTORDERSEQ AS Double) as Boolean

K3424_MOVE = False

Try
    If READ_PFK3424(FACTORDERNO, FACTORDERSEQ) = True Then
                z3424 = D3424
		K3424_MOVE = True
		else
	z3424 = nothing
     End If

     If  getColumIndex(spr,"FactOrderNo") > -1 then z3424.FactOrderNo = getDataM(spr, getColumIndex(spr,"FactOrderNo"), xRow)
     If  getColumIndex(spr,"FactOrderSeq") > -1 then z3424.FactOrderSeq = getDataM(spr, getColumIndex(spr,"FactOrderSeq"), xRow)
     If  getColumIndex(spr,"SizeQty01") > -1 then z3424.SizeQty01 = getDataM(spr, getColumIndex(spr,"SizeQty01"), xRow)
     If  getColumIndex(spr,"SizeQty02") > -1 then z3424.SizeQty02 = getDataM(spr, getColumIndex(spr,"SizeQty02"), xRow)
     If  getColumIndex(spr,"SizeQty03") > -1 then z3424.SizeQty03 = getDataM(spr, getColumIndex(spr,"SizeQty03"), xRow)
     If  getColumIndex(spr,"SizeQty04") > -1 then z3424.SizeQty04 = getDataM(spr, getColumIndex(spr,"SizeQty04"), xRow)
     If  getColumIndex(spr,"SizeQty05") > -1 then z3424.SizeQty05 = getDataM(spr, getColumIndex(spr,"SizeQty05"), xRow)
     If  getColumIndex(spr,"SizeQty06") > -1 then z3424.SizeQty06 = getDataM(spr, getColumIndex(spr,"SizeQty06"), xRow)
     If  getColumIndex(spr,"SizeQty07") > -1 then z3424.SizeQty07 = getDataM(spr, getColumIndex(spr,"SizeQty07"), xRow)
     If  getColumIndex(spr,"SizeQty08") > -1 then z3424.SizeQty08 = getDataM(spr, getColumIndex(spr,"SizeQty08"), xRow)
     If  getColumIndex(spr,"SizeQty09") > -1 then z3424.SizeQty09 = getDataM(spr, getColumIndex(spr,"SizeQty09"), xRow)
     If  getColumIndex(spr,"SizeQty10") > -1 then z3424.SizeQty10 = getDataM(spr, getColumIndex(spr,"SizeQty10"), xRow)
     If  getColumIndex(spr,"SizeQty11") > -1 then z3424.SizeQty11 = getDataM(spr, getColumIndex(spr,"SizeQty11"), xRow)
     If  getColumIndex(spr,"SizeQty12") > -1 then z3424.SizeQty12 = getDataM(spr, getColumIndex(spr,"SizeQty12"), xRow)
     If  getColumIndex(spr,"SizeQty13") > -1 then z3424.SizeQty13 = getDataM(spr, getColumIndex(spr,"SizeQty13"), xRow)
     If  getColumIndex(spr,"SizeQty14") > -1 then z3424.SizeQty14 = getDataM(spr, getColumIndex(spr,"SizeQty14"), xRow)
     If  getColumIndex(spr,"SizeQty15") > -1 then z3424.SizeQty15 = getDataM(spr, getColumIndex(spr,"SizeQty15"), xRow)
     If  getColumIndex(spr,"SizeQty16") > -1 then z3424.SizeQty16 = getDataM(spr, getColumIndex(spr,"SizeQty16"), xRow)
     If  getColumIndex(spr,"SizeQty17") > -1 then z3424.SizeQty17 = getDataM(spr, getColumIndex(spr,"SizeQty17"), xRow)
     If  getColumIndex(spr,"SizeQty18") > -1 then z3424.SizeQty18 = getDataM(spr, getColumIndex(spr,"SizeQty18"), xRow)
     If  getColumIndex(spr,"SizeQty19") > -1 then z3424.SizeQty19 = getDataM(spr, getColumIndex(spr,"SizeQty19"), xRow)
     If  getColumIndex(spr,"SizeQty20") > -1 then z3424.SizeQty20 = getDataM(spr, getColumIndex(spr,"SizeQty20"), xRow)
     If  getColumIndex(spr,"SizeQty21") > -1 then z3424.SizeQty21 = getDataM(spr, getColumIndex(spr,"SizeQty21"), xRow)
     If  getColumIndex(spr,"SizeQty22") > -1 then z3424.SizeQty22 = getDataM(spr, getColumIndex(spr,"SizeQty22"), xRow)
     If  getColumIndex(spr,"SizeQty23") > -1 then z3424.SizeQty23 = getDataM(spr, getColumIndex(spr,"SizeQty23"), xRow)
     If  getColumIndex(spr,"SizeQty24") > -1 then z3424.SizeQty24 = getDataM(spr, getColumIndex(spr,"SizeQty24"), xRow)
     If  getColumIndex(spr,"SizeQty25") > -1 then z3424.SizeQty25 = getDataM(spr, getColumIndex(spr,"SizeQty25"), xRow)
     If  getColumIndex(spr,"SizeQty26") > -1 then z3424.SizeQty26 = getDataM(spr, getColumIndex(spr,"SizeQty26"), xRow)
     If  getColumIndex(spr,"SizeQty27") > -1 then z3424.SizeQty27 = getDataM(spr, getColumIndex(spr,"SizeQty27"), xRow)
     If  getColumIndex(spr,"SizeQty28") > -1 then z3424.SizeQty28 = getDataM(spr, getColumIndex(spr,"SizeQty28"), xRow)
     If  getColumIndex(spr,"SizeQty29") > -1 then z3424.SizeQty29 = getDataM(spr, getColumIndex(spr,"SizeQty29"), xRow)
     If  getColumIndex(spr,"SizeQty30") > -1 then z3424.SizeQty30 = getDataM(spr, getColumIndex(spr,"SizeQty30"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z3424.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3424_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K3424_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3424 As T3424_AREA,CheckClear as Boolean,FACTORDERNO AS String, FACTORDERSEQ AS Double) as Boolean

K3424_MOVE = False

Try
    If READ_PFK3424(FACTORDERNO, FACTORDERSEQ) = True Then
                z3424 = D3424
		K3424_MOVE = True
		else
	If CheckClear  = True then z3424 = nothing
     End If

     If  getColumIndex(spr,"FactOrderNo") > -1 then z3424.FactOrderNo = getDataM(spr, getColumIndex(spr,"FactOrderNo"), xRow)
     If  getColumIndex(spr,"FactOrderSeq") > -1 then z3424.FactOrderSeq = getDataM(spr, getColumIndex(spr,"FactOrderSeq"), xRow)
     If  getColumIndex(spr,"SizeQty01") > -1 then z3424.SizeQty01 = getDataM(spr, getColumIndex(spr,"SizeQty01"), xRow)
     If  getColumIndex(spr,"SizeQty02") > -1 then z3424.SizeQty02 = getDataM(spr, getColumIndex(spr,"SizeQty02"), xRow)
     If  getColumIndex(spr,"SizeQty03") > -1 then z3424.SizeQty03 = getDataM(spr, getColumIndex(spr,"SizeQty03"), xRow)
     If  getColumIndex(spr,"SizeQty04") > -1 then z3424.SizeQty04 = getDataM(spr, getColumIndex(spr,"SizeQty04"), xRow)
     If  getColumIndex(spr,"SizeQty05") > -1 then z3424.SizeQty05 = getDataM(spr, getColumIndex(spr,"SizeQty05"), xRow)
     If  getColumIndex(spr,"SizeQty06") > -1 then z3424.SizeQty06 = getDataM(spr, getColumIndex(spr,"SizeQty06"), xRow)
     If  getColumIndex(spr,"SizeQty07") > -1 then z3424.SizeQty07 = getDataM(spr, getColumIndex(spr,"SizeQty07"), xRow)
     If  getColumIndex(spr,"SizeQty08") > -1 then z3424.SizeQty08 = getDataM(spr, getColumIndex(spr,"SizeQty08"), xRow)
     If  getColumIndex(spr,"SizeQty09") > -1 then z3424.SizeQty09 = getDataM(spr, getColumIndex(spr,"SizeQty09"), xRow)
     If  getColumIndex(spr,"SizeQty10") > -1 then z3424.SizeQty10 = getDataM(spr, getColumIndex(spr,"SizeQty10"), xRow)
     If  getColumIndex(spr,"SizeQty11") > -1 then z3424.SizeQty11 = getDataM(spr, getColumIndex(spr,"SizeQty11"), xRow)
     If  getColumIndex(spr,"SizeQty12") > -1 then z3424.SizeQty12 = getDataM(spr, getColumIndex(spr,"SizeQty12"), xRow)
     If  getColumIndex(spr,"SizeQty13") > -1 then z3424.SizeQty13 = getDataM(spr, getColumIndex(spr,"SizeQty13"), xRow)
     If  getColumIndex(spr,"SizeQty14") > -1 then z3424.SizeQty14 = getDataM(spr, getColumIndex(spr,"SizeQty14"), xRow)
     If  getColumIndex(spr,"SizeQty15") > -1 then z3424.SizeQty15 = getDataM(spr, getColumIndex(spr,"SizeQty15"), xRow)
     If  getColumIndex(spr,"SizeQty16") > -1 then z3424.SizeQty16 = getDataM(spr, getColumIndex(spr,"SizeQty16"), xRow)
     If  getColumIndex(spr,"SizeQty17") > -1 then z3424.SizeQty17 = getDataM(spr, getColumIndex(spr,"SizeQty17"), xRow)
     If  getColumIndex(spr,"SizeQty18") > -1 then z3424.SizeQty18 = getDataM(spr, getColumIndex(spr,"SizeQty18"), xRow)
     If  getColumIndex(spr,"SizeQty19") > -1 then z3424.SizeQty19 = getDataM(spr, getColumIndex(spr,"SizeQty19"), xRow)
     If  getColumIndex(spr,"SizeQty20") > -1 then z3424.SizeQty20 = getDataM(spr, getColumIndex(spr,"SizeQty20"), xRow)
     If  getColumIndex(spr,"SizeQty21") > -1 then z3424.SizeQty21 = getDataM(spr, getColumIndex(spr,"SizeQty21"), xRow)
     If  getColumIndex(spr,"SizeQty22") > -1 then z3424.SizeQty22 = getDataM(spr, getColumIndex(spr,"SizeQty22"), xRow)
     If  getColumIndex(spr,"SizeQty23") > -1 then z3424.SizeQty23 = getDataM(spr, getColumIndex(spr,"SizeQty23"), xRow)
     If  getColumIndex(spr,"SizeQty24") > -1 then z3424.SizeQty24 = getDataM(spr, getColumIndex(spr,"SizeQty24"), xRow)
     If  getColumIndex(spr,"SizeQty25") > -1 then z3424.SizeQty25 = getDataM(spr, getColumIndex(spr,"SizeQty25"), xRow)
     If  getColumIndex(spr,"SizeQty26") > -1 then z3424.SizeQty26 = getDataM(spr, getColumIndex(spr,"SizeQty26"), xRow)
     If  getColumIndex(spr,"SizeQty27") > -1 then z3424.SizeQty27 = getDataM(spr, getColumIndex(spr,"SizeQty27"), xRow)
     If  getColumIndex(spr,"SizeQty28") > -1 then z3424.SizeQty28 = getDataM(spr, getColumIndex(spr,"SizeQty28"), xRow)
     If  getColumIndex(spr,"SizeQty29") > -1 then z3424.SizeQty29 = getDataM(spr, getColumIndex(spr,"SizeQty29"), xRow)
     If  getColumIndex(spr,"SizeQty30") > -1 then z3424.SizeQty30 = getDataM(spr, getColumIndex(spr,"SizeQty30"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z3424.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3424_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K3424_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3424 As T3424_AREA, Job as String, FACTORDERNO AS String, FACTORDERSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3424_MOVE = False

Try
    If READ_PFK3424(FACTORDERNO, FACTORDERSEQ) = True Then
                z3424 = D3424
		K3424_MOVE = True
		else
	z3424 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3424")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "FACTORDERNO":z3424.FactOrderNo = Children(i).Code
   Case "FACTORDERSEQ":z3424.FactOrderSeq = Children(i).Code
   Case "SIZEQTY01":z3424.SizeQty01 = Children(i).Code
   Case "SIZEQTY02":z3424.SizeQty02 = Children(i).Code
   Case "SIZEQTY03":z3424.SizeQty03 = Children(i).Code
   Case "SIZEQTY04":z3424.SizeQty04 = Children(i).Code
   Case "SIZEQTY05":z3424.SizeQty05 = Children(i).Code
   Case "SIZEQTY06":z3424.SizeQty06 = Children(i).Code
   Case "SIZEQTY07":z3424.SizeQty07 = Children(i).Code
   Case "SIZEQTY08":z3424.SizeQty08 = Children(i).Code
   Case "SIZEQTY09":z3424.SizeQty09 = Children(i).Code
   Case "SIZEQTY10":z3424.SizeQty10 = Children(i).Code
   Case "SIZEQTY11":z3424.SizeQty11 = Children(i).Code
   Case "SIZEQTY12":z3424.SizeQty12 = Children(i).Code
   Case "SIZEQTY13":z3424.SizeQty13 = Children(i).Code
   Case "SIZEQTY14":z3424.SizeQty14 = Children(i).Code
   Case "SIZEQTY15":z3424.SizeQty15 = Children(i).Code
   Case "SIZEQTY16":z3424.SizeQty16 = Children(i).Code
   Case "SIZEQTY17":z3424.SizeQty17 = Children(i).Code
   Case "SIZEQTY18":z3424.SizeQty18 = Children(i).Code
   Case "SIZEQTY19":z3424.SizeQty19 = Children(i).Code
   Case "SIZEQTY20":z3424.SizeQty20 = Children(i).Code
   Case "SIZEQTY21":z3424.SizeQty21 = Children(i).Code
   Case "SIZEQTY22":z3424.SizeQty22 = Children(i).Code
   Case "SIZEQTY23":z3424.SizeQty23 = Children(i).Code
   Case "SIZEQTY24":z3424.SizeQty24 = Children(i).Code
   Case "SIZEQTY25":z3424.SizeQty25 = Children(i).Code
   Case "SIZEQTY26":z3424.SizeQty26 = Children(i).Code
   Case "SIZEQTY27":z3424.SizeQty27 = Children(i).Code
   Case "SIZEQTY28":z3424.SizeQty28 = Children(i).Code
   Case "SIZEQTY29":z3424.SizeQty29 = Children(i).Code
   Case "SIZEQTY30":z3424.SizeQty30 = Children(i).Code
   Case "REMARK":z3424.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "FACTORDERNO":z3424.FactOrderNo = Children(i).Data
   Case "FACTORDERSEQ":z3424.FactOrderSeq = Children(i).Data
   Case "SIZEQTY01":z3424.SizeQty01 = Children(i).Data
   Case "SIZEQTY02":z3424.SizeQty02 = Children(i).Data
   Case "SIZEQTY03":z3424.SizeQty03 = Children(i).Data
   Case "SIZEQTY04":z3424.SizeQty04 = Children(i).Data
   Case "SIZEQTY05":z3424.SizeQty05 = Children(i).Data
   Case "SIZEQTY06":z3424.SizeQty06 = Children(i).Data
   Case "SIZEQTY07":z3424.SizeQty07 = Children(i).Data
   Case "SIZEQTY08":z3424.SizeQty08 = Children(i).Data
   Case "SIZEQTY09":z3424.SizeQty09 = Children(i).Data
   Case "SIZEQTY10":z3424.SizeQty10 = Children(i).Data
   Case "SIZEQTY11":z3424.SizeQty11 = Children(i).Data
   Case "SIZEQTY12":z3424.SizeQty12 = Children(i).Data
   Case "SIZEQTY13":z3424.SizeQty13 = Children(i).Data
   Case "SIZEQTY14":z3424.SizeQty14 = Children(i).Data
   Case "SIZEQTY15":z3424.SizeQty15 = Children(i).Data
   Case "SIZEQTY16":z3424.SizeQty16 = Children(i).Data
   Case "SIZEQTY17":z3424.SizeQty17 = Children(i).Data
   Case "SIZEQTY18":z3424.SizeQty18 = Children(i).Data
   Case "SIZEQTY19":z3424.SizeQty19 = Children(i).Data
   Case "SIZEQTY20":z3424.SizeQty20 = Children(i).Data
   Case "SIZEQTY21":z3424.SizeQty21 = Children(i).Data
   Case "SIZEQTY22":z3424.SizeQty22 = Children(i).Data
   Case "SIZEQTY23":z3424.SizeQty23 = Children(i).Data
   Case "SIZEQTY24":z3424.SizeQty24 = Children(i).Data
   Case "SIZEQTY25":z3424.SizeQty25 = Children(i).Data
   Case "SIZEQTY26":z3424.SizeQty26 = Children(i).Data
   Case "SIZEQTY27":z3424.SizeQty27 = Children(i).Data
   Case "SIZEQTY28":z3424.SizeQty28 = Children(i).Data
   Case "SIZEQTY29":z3424.SizeQty29 = Children(i).Data
   Case "SIZEQTY30":z3424.SizeQty30 = Children(i).Data
   Case "REMARK":z3424.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3424_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K3424_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3424 As T3424_AREA, Job as String, CheckClear as Boolean, FACTORDERNO AS String, FACTORDERSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3424_MOVE = False

Try
    If READ_PFK3424(FACTORDERNO, FACTORDERSEQ) = True Then
                z3424 = D3424
		K3424_MOVE = True
		else
	If CheckClear  = True then z3424 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3424")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "FACTORDERNO":z3424.FactOrderNo = Children(i).Code
   Case "FACTORDERSEQ":z3424.FactOrderSeq = Children(i).Code
   Case "SIZEQTY01":z3424.SizeQty01 = Children(i).Code
   Case "SIZEQTY02":z3424.SizeQty02 = Children(i).Code
   Case "SIZEQTY03":z3424.SizeQty03 = Children(i).Code
   Case "SIZEQTY04":z3424.SizeQty04 = Children(i).Code
   Case "SIZEQTY05":z3424.SizeQty05 = Children(i).Code
   Case "SIZEQTY06":z3424.SizeQty06 = Children(i).Code
   Case "SIZEQTY07":z3424.SizeQty07 = Children(i).Code
   Case "SIZEQTY08":z3424.SizeQty08 = Children(i).Code
   Case "SIZEQTY09":z3424.SizeQty09 = Children(i).Code
   Case "SIZEQTY10":z3424.SizeQty10 = Children(i).Code
   Case "SIZEQTY11":z3424.SizeQty11 = Children(i).Code
   Case "SIZEQTY12":z3424.SizeQty12 = Children(i).Code
   Case "SIZEQTY13":z3424.SizeQty13 = Children(i).Code
   Case "SIZEQTY14":z3424.SizeQty14 = Children(i).Code
   Case "SIZEQTY15":z3424.SizeQty15 = Children(i).Code
   Case "SIZEQTY16":z3424.SizeQty16 = Children(i).Code
   Case "SIZEQTY17":z3424.SizeQty17 = Children(i).Code
   Case "SIZEQTY18":z3424.SizeQty18 = Children(i).Code
   Case "SIZEQTY19":z3424.SizeQty19 = Children(i).Code
   Case "SIZEQTY20":z3424.SizeQty20 = Children(i).Code
   Case "SIZEQTY21":z3424.SizeQty21 = Children(i).Code
   Case "SIZEQTY22":z3424.SizeQty22 = Children(i).Code
   Case "SIZEQTY23":z3424.SizeQty23 = Children(i).Code
   Case "SIZEQTY24":z3424.SizeQty24 = Children(i).Code
   Case "SIZEQTY25":z3424.SizeQty25 = Children(i).Code
   Case "SIZEQTY26":z3424.SizeQty26 = Children(i).Code
   Case "SIZEQTY27":z3424.SizeQty27 = Children(i).Code
   Case "SIZEQTY28":z3424.SizeQty28 = Children(i).Code
   Case "SIZEQTY29":z3424.SizeQty29 = Children(i).Code
   Case "SIZEQTY30":z3424.SizeQty30 = Children(i).Code
   Case "REMARK":z3424.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "FACTORDERNO":z3424.FactOrderNo = Children(i).Data
   Case "FACTORDERSEQ":z3424.FactOrderSeq = Children(i).Data
   Case "SIZEQTY01":z3424.SizeQty01 = Children(i).Data
   Case "SIZEQTY02":z3424.SizeQty02 = Children(i).Data
   Case "SIZEQTY03":z3424.SizeQty03 = Children(i).Data
   Case "SIZEQTY04":z3424.SizeQty04 = Children(i).Data
   Case "SIZEQTY05":z3424.SizeQty05 = Children(i).Data
   Case "SIZEQTY06":z3424.SizeQty06 = Children(i).Data
   Case "SIZEQTY07":z3424.SizeQty07 = Children(i).Data
   Case "SIZEQTY08":z3424.SizeQty08 = Children(i).Data
   Case "SIZEQTY09":z3424.SizeQty09 = Children(i).Data
   Case "SIZEQTY10":z3424.SizeQty10 = Children(i).Data
   Case "SIZEQTY11":z3424.SizeQty11 = Children(i).Data
   Case "SIZEQTY12":z3424.SizeQty12 = Children(i).Data
   Case "SIZEQTY13":z3424.SizeQty13 = Children(i).Data
   Case "SIZEQTY14":z3424.SizeQty14 = Children(i).Data
   Case "SIZEQTY15":z3424.SizeQty15 = Children(i).Data
   Case "SIZEQTY16":z3424.SizeQty16 = Children(i).Data
   Case "SIZEQTY17":z3424.SizeQty17 = Children(i).Data
   Case "SIZEQTY18":z3424.SizeQty18 = Children(i).Data
   Case "SIZEQTY19":z3424.SizeQty19 = Children(i).Data
   Case "SIZEQTY20":z3424.SizeQty20 = Children(i).Data
   Case "SIZEQTY21":z3424.SizeQty21 = Children(i).Data
   Case "SIZEQTY22":z3424.SizeQty22 = Children(i).Data
   Case "SIZEQTY23":z3424.SizeQty23 = Children(i).Data
   Case "SIZEQTY24":z3424.SizeQty24 = Children(i).Data
   Case "SIZEQTY25":z3424.SizeQty25 = Children(i).Data
   Case "SIZEQTY26":z3424.SizeQty26 = Children(i).Data
   Case "SIZEQTY27":z3424.SizeQty27 = Children(i).Data
   Case "SIZEQTY28":z3424.SizeQty28 = Children(i).Data
   Case "SIZEQTY29":z3424.SizeQty29 = Children(i).Data
   Case "SIZEQTY30":z3424.SizeQty30 = Children(i).Data
   Case "REMARK":z3424.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3424_MOVE",vbCritical)
End Try
End Function 
    
End Module 
