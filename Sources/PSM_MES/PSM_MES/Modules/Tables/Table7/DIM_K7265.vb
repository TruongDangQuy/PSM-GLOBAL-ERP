'=========================================================================================================================================================
'   TABLE : (PFK7265)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7265

Structure T7265_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	ShoesCode	 AS String	'			char(6)		*
Public 	PriceS01	 AS Double	'			decimal
Public 	PriceS02	 AS Double	'			decimal
Public 	PriceS03	 AS Double	'			decimal
Public 	PriceS04	 AS Double	'			decimal
Public 	PriceS05	 AS Double	'			decimal
Public 	PriceS06	 AS Double	'			decimal
Public 	PriceS07	 AS Double	'			decimal
Public 	PriceS08	 AS Double	'			decimal
Public 	PriceS09	 AS Double	'			decimal
Public 	PriceS10	 AS Double	'			decimal
Public 	PriceS11	 AS Double	'			decimal
Public 	PriceS12	 AS Double	'			decimal
Public 	PriceS13	 AS Double	'			decimal
Public 	PriceS14	 AS Double	'			decimal
Public 	PriceS15	 AS Double	'			decimal
Public 	PriceS16	 AS Double	'			decimal
Public 	PriceS17	 AS Double	'			decimal
Public 	PriceS18	 AS Double	'			decimal
Public 	PriceS19	 AS Double	'			decimal
Public 	PriceS20	 AS Double	'			decimal
Public 	PriceS21	 AS Double	'			decimal
Public 	PriceS22	 AS Double	'			decimal
Public 	PriceS23	 AS Double	'			decimal
Public 	PriceS24	 AS Double	'			decimal
Public 	PriceS25	 AS Double	'			decimal
Public 	PriceS26	 AS Double	'			decimal
Public 	PriceS27	 AS Double	'			decimal
Public 	PriceS28	 AS Double	'			decimal
Public 	PriceS29	 AS Double	'			decimal
Public 	PriceS30	 AS Double	'			decimal
Public 	Remark	 AS String	'			nvarchar(50)
'=========================================================================================================================================================
End structure

Public D7265 As T7265_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7265(SHOESCODE AS String) As Boolean
    READ_PFK7265 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7265 "
    SQL = SQL & " WHERE K7265_ShoesCode		 = '" & ShoesCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7265_CLEAR: GoTo SKIP_READ_PFK7265
                
    Call K7265_MOVE(rd)
    READ_PFK7265 = True

SKIP_READ_PFK7265:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7265",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7265(SHOESCODE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7265 "
    SQL = SQL & " WHERE K7265_ShoesCode		 = '" & ShoesCode & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7265",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7265(z7265 As T7265_AREA) As Boolean
    WRITE_PFK7265 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7265)
 
    SQL = " INSERT INTO PFK7265 "
    SQL = SQL & " ( "
    SQL = SQL & " K7265_ShoesCode," 
    SQL = SQL & " K7265_PriceS01," 
    SQL = SQL & " K7265_PriceS02," 
    SQL = SQL & " K7265_PriceS03," 
    SQL = SQL & " K7265_PriceS04," 
    SQL = SQL & " K7265_PriceS05," 
    SQL = SQL & " K7265_PriceS06," 
    SQL = SQL & " K7265_PriceS07," 
    SQL = SQL & " K7265_PriceS08," 
    SQL = SQL & " K7265_PriceS09," 
    SQL = SQL & " K7265_PriceS10," 
    SQL = SQL & " K7265_PriceS11," 
    SQL = SQL & " K7265_PriceS12," 
    SQL = SQL & " K7265_PriceS13," 
    SQL = SQL & " K7265_PriceS14," 
    SQL = SQL & " K7265_PriceS15," 
    SQL = SQL & " K7265_PriceS16," 
    SQL = SQL & " K7265_PriceS17," 
    SQL = SQL & " K7265_PriceS18," 
    SQL = SQL & " K7265_PriceS19," 
    SQL = SQL & " K7265_PriceS20," 
    SQL = SQL & " K7265_PriceS21," 
    SQL = SQL & " K7265_PriceS22," 
    SQL = SQL & " K7265_PriceS23," 
    SQL = SQL & " K7265_PriceS24," 
    SQL = SQL & " K7265_PriceS25," 
    SQL = SQL & " K7265_PriceS26," 
    SQL = SQL & " K7265_PriceS27," 
    SQL = SQL & " K7265_PriceS28," 
    SQL = SQL & " K7265_PriceS29," 
    SQL = SQL & " K7265_PriceS30," 
    SQL = SQL & " K7265_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7265.ShoesCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z7265.PriceS01) & ", "  
    SQL = SQL & "   " & FormatSQL(z7265.PriceS02) & ", "  
    SQL = SQL & "   " & FormatSQL(z7265.PriceS03) & ", "  
    SQL = SQL & "   " & FormatSQL(z7265.PriceS04) & ", "  
    SQL = SQL & "   " & FormatSQL(z7265.PriceS05) & ", "  
    SQL = SQL & "   " & FormatSQL(z7265.PriceS06) & ", "  
    SQL = SQL & "   " & FormatSQL(z7265.PriceS07) & ", "  
    SQL = SQL & "   " & FormatSQL(z7265.PriceS08) & ", "  
    SQL = SQL & "   " & FormatSQL(z7265.PriceS09) & ", "  
    SQL = SQL & "   " & FormatSQL(z7265.PriceS10) & ", "  
    SQL = SQL & "   " & FormatSQL(z7265.PriceS11) & ", "  
    SQL = SQL & "   " & FormatSQL(z7265.PriceS12) & ", "  
    SQL = SQL & "   " & FormatSQL(z7265.PriceS13) & ", "  
    SQL = SQL & "   " & FormatSQL(z7265.PriceS14) & ", "  
    SQL = SQL & "   " & FormatSQL(z7265.PriceS15) & ", "  
    SQL = SQL & "   " & FormatSQL(z7265.PriceS16) & ", "  
    SQL = SQL & "   " & FormatSQL(z7265.PriceS17) & ", "  
    SQL = SQL & "   " & FormatSQL(z7265.PriceS18) & ", "  
    SQL = SQL & "   " & FormatSQL(z7265.PriceS19) & ", "  
    SQL = SQL & "   " & FormatSQL(z7265.PriceS20) & ", "  
    SQL = SQL & "   " & FormatSQL(z7265.PriceS21) & ", "  
    SQL = SQL & "   " & FormatSQL(z7265.PriceS22) & ", "  
    SQL = SQL & "   " & FormatSQL(z7265.PriceS23) & ", "  
    SQL = SQL & "   " & FormatSQL(z7265.PriceS24) & ", "  
    SQL = SQL & "   " & FormatSQL(z7265.PriceS25) & ", "  
    SQL = SQL & "   " & FormatSQL(z7265.PriceS26) & ", "  
    SQL = SQL & "   " & FormatSQL(z7265.PriceS27) & ", "  
    SQL = SQL & "   " & FormatSQL(z7265.PriceS28) & ", "  
    SQL = SQL & "   " & FormatSQL(z7265.PriceS29) & ", "  
    SQL = SQL & "   " & FormatSQL(z7265.PriceS30) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7265.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7265 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7265",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7265(z7265 As T7265_AREA) As Boolean
    REWRITE_PFK7265 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7265)
   
    SQL = " UPDATE PFK7265 SET "
    SQL = SQL & "    K7265_PriceS01      =  " & FormatSQL(z7265.PriceS01) & ", " 
    SQL = SQL & "    K7265_PriceS02      =  " & FormatSQL(z7265.PriceS02) & ", " 
    SQL = SQL & "    K7265_PriceS03      =  " & FormatSQL(z7265.PriceS03) & ", " 
    SQL = SQL & "    K7265_PriceS04      =  " & FormatSQL(z7265.PriceS04) & ", " 
    SQL = SQL & "    K7265_PriceS05      =  " & FormatSQL(z7265.PriceS05) & ", " 
    SQL = SQL & "    K7265_PriceS06      =  " & FormatSQL(z7265.PriceS06) & ", " 
    SQL = SQL & "    K7265_PriceS07      =  " & FormatSQL(z7265.PriceS07) & ", " 
    SQL = SQL & "    K7265_PriceS08      =  " & FormatSQL(z7265.PriceS08) & ", " 
    SQL = SQL & "    K7265_PriceS09      =  " & FormatSQL(z7265.PriceS09) & ", " 
    SQL = SQL & "    K7265_PriceS10      =  " & FormatSQL(z7265.PriceS10) & ", " 
    SQL = SQL & "    K7265_PriceS11      =  " & FormatSQL(z7265.PriceS11) & ", " 
    SQL = SQL & "    K7265_PriceS12      =  " & FormatSQL(z7265.PriceS12) & ", " 
    SQL = SQL & "    K7265_PriceS13      =  " & FormatSQL(z7265.PriceS13) & ", " 
    SQL = SQL & "    K7265_PriceS14      =  " & FormatSQL(z7265.PriceS14) & ", " 
    SQL = SQL & "    K7265_PriceS15      =  " & FormatSQL(z7265.PriceS15) & ", " 
    SQL = SQL & "    K7265_PriceS16      =  " & FormatSQL(z7265.PriceS16) & ", " 
    SQL = SQL & "    K7265_PriceS17      =  " & FormatSQL(z7265.PriceS17) & ", " 
    SQL = SQL & "    K7265_PriceS18      =  " & FormatSQL(z7265.PriceS18) & ", " 
    SQL = SQL & "    K7265_PriceS19      =  " & FormatSQL(z7265.PriceS19) & ", " 
    SQL = SQL & "    K7265_PriceS20      =  " & FormatSQL(z7265.PriceS20) & ", " 
    SQL = SQL & "    K7265_PriceS21      =  " & FormatSQL(z7265.PriceS21) & ", " 
    SQL = SQL & "    K7265_PriceS22      =  " & FormatSQL(z7265.PriceS22) & ", " 
    SQL = SQL & "    K7265_PriceS23      =  " & FormatSQL(z7265.PriceS23) & ", " 
    SQL = SQL & "    K7265_PriceS24      =  " & FormatSQL(z7265.PriceS24) & ", " 
    SQL = SQL & "    K7265_PriceS25      =  " & FormatSQL(z7265.PriceS25) & ", " 
    SQL = SQL & "    K7265_PriceS26      =  " & FormatSQL(z7265.PriceS26) & ", " 
    SQL = SQL & "    K7265_PriceS27      =  " & FormatSQL(z7265.PriceS27) & ", " 
    SQL = SQL & "    K7265_PriceS28      =  " & FormatSQL(z7265.PriceS28) & ", " 
    SQL = SQL & "    K7265_PriceS29      =  " & FormatSQL(z7265.PriceS29) & ", " 
    SQL = SQL & "    K7265_PriceS30      =  " & FormatSQL(z7265.PriceS30) & ", " 
    SQL = SQL & "    K7265_Remark      = N'" & FormatSQL(z7265.Remark) & "'  " 
    SQL = SQL & " WHERE K7265_ShoesCode		 = '" & z7265.ShoesCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7265 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7265",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7265(z7265 As T7265_AREA) As Boolean
    DELETE_PFK7265 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7265 "
    SQL = SQL & " WHERE K7265_ShoesCode		 = '" & z7265.ShoesCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7265 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7265",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7265_CLEAR()
Try
    
   D7265.ShoesCode = ""
    D7265.PriceS01 = 0 
    D7265.PriceS02 = 0 
    D7265.PriceS03 = 0 
    D7265.PriceS04 = 0 
    D7265.PriceS05 = 0 
    D7265.PriceS06 = 0 
    D7265.PriceS07 = 0 
    D7265.PriceS08 = 0 
    D7265.PriceS09 = 0 
    D7265.PriceS10 = 0 
    D7265.PriceS11 = 0 
    D7265.PriceS12 = 0 
    D7265.PriceS13 = 0 
    D7265.PriceS14 = 0 
    D7265.PriceS15 = 0 
    D7265.PriceS16 = 0 
    D7265.PriceS17 = 0 
    D7265.PriceS18 = 0 
    D7265.PriceS19 = 0 
    D7265.PriceS20 = 0 
    D7265.PriceS21 = 0 
    D7265.PriceS22 = 0 
    D7265.PriceS23 = 0 
    D7265.PriceS24 = 0 
    D7265.PriceS25 = 0 
    D7265.PriceS26 = 0 
    D7265.PriceS27 = 0 
    D7265.PriceS28 = 0 
    D7265.PriceS29 = 0 
    D7265.PriceS30 = 0 
   D7265.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7265_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7265 As T7265_AREA)
Try
    
    x7265.ShoesCode = trim$(  x7265.ShoesCode)
    x7265.PriceS01 = trim$(  x7265.PriceS01)
    x7265.PriceS02 = trim$(  x7265.PriceS02)
    x7265.PriceS03 = trim$(  x7265.PriceS03)
    x7265.PriceS04 = trim$(  x7265.PriceS04)
    x7265.PriceS05 = trim$(  x7265.PriceS05)
    x7265.PriceS06 = trim$(  x7265.PriceS06)
    x7265.PriceS07 = trim$(  x7265.PriceS07)
    x7265.PriceS08 = trim$(  x7265.PriceS08)
    x7265.PriceS09 = trim$(  x7265.PriceS09)
    x7265.PriceS10 = trim$(  x7265.PriceS10)
    x7265.PriceS11 = trim$(  x7265.PriceS11)
    x7265.PriceS12 = trim$(  x7265.PriceS12)
    x7265.PriceS13 = trim$(  x7265.PriceS13)
    x7265.PriceS14 = trim$(  x7265.PriceS14)
    x7265.PriceS15 = trim$(  x7265.PriceS15)
    x7265.PriceS16 = trim$(  x7265.PriceS16)
    x7265.PriceS17 = trim$(  x7265.PriceS17)
    x7265.PriceS18 = trim$(  x7265.PriceS18)
    x7265.PriceS19 = trim$(  x7265.PriceS19)
    x7265.PriceS20 = trim$(  x7265.PriceS20)
    x7265.PriceS21 = trim$(  x7265.PriceS21)
    x7265.PriceS22 = trim$(  x7265.PriceS22)
    x7265.PriceS23 = trim$(  x7265.PriceS23)
    x7265.PriceS24 = trim$(  x7265.PriceS24)
    x7265.PriceS25 = trim$(  x7265.PriceS25)
    x7265.PriceS26 = trim$(  x7265.PriceS26)
    x7265.PriceS27 = trim$(  x7265.PriceS27)
    x7265.PriceS28 = trim$(  x7265.PriceS28)
    x7265.PriceS29 = trim$(  x7265.PriceS29)
    x7265.PriceS30 = trim$(  x7265.PriceS30)
    x7265.Remark = trim$(  x7265.Remark)
     
    If trim$( x7265.ShoesCode ) = "" Then x7265.ShoesCode = Space(1) 
    If trim$( x7265.PriceS01 ) = "" Then x7265.PriceS01 = 0 
    If trim$( x7265.PriceS02 ) = "" Then x7265.PriceS02 = 0 
    If trim$( x7265.PriceS03 ) = "" Then x7265.PriceS03 = 0 
    If trim$( x7265.PriceS04 ) = "" Then x7265.PriceS04 = 0 
    If trim$( x7265.PriceS05 ) = "" Then x7265.PriceS05 = 0 
    If trim$( x7265.PriceS06 ) = "" Then x7265.PriceS06 = 0 
    If trim$( x7265.PriceS07 ) = "" Then x7265.PriceS07 = 0 
    If trim$( x7265.PriceS08 ) = "" Then x7265.PriceS08 = 0 
    If trim$( x7265.PriceS09 ) = "" Then x7265.PriceS09 = 0 
    If trim$( x7265.PriceS10 ) = "" Then x7265.PriceS10 = 0 
    If trim$( x7265.PriceS11 ) = "" Then x7265.PriceS11 = 0 
    If trim$( x7265.PriceS12 ) = "" Then x7265.PriceS12 = 0 
    If trim$( x7265.PriceS13 ) = "" Then x7265.PriceS13 = 0 
    If trim$( x7265.PriceS14 ) = "" Then x7265.PriceS14 = 0 
    If trim$( x7265.PriceS15 ) = "" Then x7265.PriceS15 = 0 
    If trim$( x7265.PriceS16 ) = "" Then x7265.PriceS16 = 0 
    If trim$( x7265.PriceS17 ) = "" Then x7265.PriceS17 = 0 
    If trim$( x7265.PriceS18 ) = "" Then x7265.PriceS18 = 0 
    If trim$( x7265.PriceS19 ) = "" Then x7265.PriceS19 = 0 
    If trim$( x7265.PriceS20 ) = "" Then x7265.PriceS20 = 0 
    If trim$( x7265.PriceS21 ) = "" Then x7265.PriceS21 = 0 
    If trim$( x7265.PriceS22 ) = "" Then x7265.PriceS22 = 0 
    If trim$( x7265.PriceS23 ) = "" Then x7265.PriceS23 = 0 
    If trim$( x7265.PriceS24 ) = "" Then x7265.PriceS24 = 0 
    If trim$( x7265.PriceS25 ) = "" Then x7265.PriceS25 = 0 
    If trim$( x7265.PriceS26 ) = "" Then x7265.PriceS26 = 0 
    If trim$( x7265.PriceS27 ) = "" Then x7265.PriceS27 = 0 
    If trim$( x7265.PriceS28 ) = "" Then x7265.PriceS28 = 0 
    If trim$( x7265.PriceS29 ) = "" Then x7265.PriceS29 = 0 
    If trim$( x7265.PriceS30 ) = "" Then x7265.PriceS30 = 0 
    If trim$( x7265.Remark ) = "" Then x7265.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7265_MOVE(rs7265 As SqlClient.SqlDataReader)
Try

    call D7265_CLEAR()   

    If IsdbNull(rs7265!K7265_ShoesCode) = False Then D7265.ShoesCode = Trim$(rs7265!K7265_ShoesCode)
    If IsdbNull(rs7265!K7265_PriceS01) = False Then D7265.PriceS01 = Trim$(rs7265!K7265_PriceS01)
    If IsdbNull(rs7265!K7265_PriceS02) = False Then D7265.PriceS02 = Trim$(rs7265!K7265_PriceS02)
    If IsdbNull(rs7265!K7265_PriceS03) = False Then D7265.PriceS03 = Trim$(rs7265!K7265_PriceS03)
    If IsdbNull(rs7265!K7265_PriceS04) = False Then D7265.PriceS04 = Trim$(rs7265!K7265_PriceS04)
    If IsdbNull(rs7265!K7265_PriceS05) = False Then D7265.PriceS05 = Trim$(rs7265!K7265_PriceS05)
    If IsdbNull(rs7265!K7265_PriceS06) = False Then D7265.PriceS06 = Trim$(rs7265!K7265_PriceS06)
    If IsdbNull(rs7265!K7265_PriceS07) = False Then D7265.PriceS07 = Trim$(rs7265!K7265_PriceS07)
    If IsdbNull(rs7265!K7265_PriceS08) = False Then D7265.PriceS08 = Trim$(rs7265!K7265_PriceS08)
    If IsdbNull(rs7265!K7265_PriceS09) = False Then D7265.PriceS09 = Trim$(rs7265!K7265_PriceS09)
    If IsdbNull(rs7265!K7265_PriceS10) = False Then D7265.PriceS10 = Trim$(rs7265!K7265_PriceS10)
    If IsdbNull(rs7265!K7265_PriceS11) = False Then D7265.PriceS11 = Trim$(rs7265!K7265_PriceS11)
    If IsdbNull(rs7265!K7265_PriceS12) = False Then D7265.PriceS12 = Trim$(rs7265!K7265_PriceS12)
    If IsdbNull(rs7265!K7265_PriceS13) = False Then D7265.PriceS13 = Trim$(rs7265!K7265_PriceS13)
    If IsdbNull(rs7265!K7265_PriceS14) = False Then D7265.PriceS14 = Trim$(rs7265!K7265_PriceS14)
    If IsdbNull(rs7265!K7265_PriceS15) = False Then D7265.PriceS15 = Trim$(rs7265!K7265_PriceS15)
    If IsdbNull(rs7265!K7265_PriceS16) = False Then D7265.PriceS16 = Trim$(rs7265!K7265_PriceS16)
    If IsdbNull(rs7265!K7265_PriceS17) = False Then D7265.PriceS17 = Trim$(rs7265!K7265_PriceS17)
    If IsdbNull(rs7265!K7265_PriceS18) = False Then D7265.PriceS18 = Trim$(rs7265!K7265_PriceS18)
    If IsdbNull(rs7265!K7265_PriceS19) = False Then D7265.PriceS19 = Trim$(rs7265!K7265_PriceS19)
    If IsdbNull(rs7265!K7265_PriceS20) = False Then D7265.PriceS20 = Trim$(rs7265!K7265_PriceS20)
    If IsdbNull(rs7265!K7265_PriceS21) = False Then D7265.PriceS21 = Trim$(rs7265!K7265_PriceS21)
    If IsdbNull(rs7265!K7265_PriceS22) = False Then D7265.PriceS22 = Trim$(rs7265!K7265_PriceS22)
    If IsdbNull(rs7265!K7265_PriceS23) = False Then D7265.PriceS23 = Trim$(rs7265!K7265_PriceS23)
    If IsdbNull(rs7265!K7265_PriceS24) = False Then D7265.PriceS24 = Trim$(rs7265!K7265_PriceS24)
    If IsdbNull(rs7265!K7265_PriceS25) = False Then D7265.PriceS25 = Trim$(rs7265!K7265_PriceS25)
    If IsdbNull(rs7265!K7265_PriceS26) = False Then D7265.PriceS26 = Trim$(rs7265!K7265_PriceS26)
    If IsdbNull(rs7265!K7265_PriceS27) = False Then D7265.PriceS27 = Trim$(rs7265!K7265_PriceS27)
    If IsdbNull(rs7265!K7265_PriceS28) = False Then D7265.PriceS28 = Trim$(rs7265!K7265_PriceS28)
    If IsdbNull(rs7265!K7265_PriceS29) = False Then D7265.PriceS29 = Trim$(rs7265!K7265_PriceS29)
    If IsdbNull(rs7265!K7265_PriceS30) = False Then D7265.PriceS30 = Trim$(rs7265!K7265_PriceS30)
    If IsdbNull(rs7265!K7265_Remark) = False Then D7265.Remark = Trim$(rs7265!K7265_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7265_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7265_MOVE(rs7265 As DataRow)
Try

    call D7265_CLEAR()   

    If IsdbNull(rs7265!K7265_ShoesCode) = False Then D7265.ShoesCode = Trim$(rs7265!K7265_ShoesCode)
    If IsdbNull(rs7265!K7265_PriceS01) = False Then D7265.PriceS01 = Trim$(rs7265!K7265_PriceS01)
    If IsdbNull(rs7265!K7265_PriceS02) = False Then D7265.PriceS02 = Trim$(rs7265!K7265_PriceS02)
    If IsdbNull(rs7265!K7265_PriceS03) = False Then D7265.PriceS03 = Trim$(rs7265!K7265_PriceS03)
    If IsdbNull(rs7265!K7265_PriceS04) = False Then D7265.PriceS04 = Trim$(rs7265!K7265_PriceS04)
    If IsdbNull(rs7265!K7265_PriceS05) = False Then D7265.PriceS05 = Trim$(rs7265!K7265_PriceS05)
    If IsdbNull(rs7265!K7265_PriceS06) = False Then D7265.PriceS06 = Trim$(rs7265!K7265_PriceS06)
    If IsdbNull(rs7265!K7265_PriceS07) = False Then D7265.PriceS07 = Trim$(rs7265!K7265_PriceS07)
    If IsdbNull(rs7265!K7265_PriceS08) = False Then D7265.PriceS08 = Trim$(rs7265!K7265_PriceS08)
    If IsdbNull(rs7265!K7265_PriceS09) = False Then D7265.PriceS09 = Trim$(rs7265!K7265_PriceS09)
    If IsdbNull(rs7265!K7265_PriceS10) = False Then D7265.PriceS10 = Trim$(rs7265!K7265_PriceS10)
    If IsdbNull(rs7265!K7265_PriceS11) = False Then D7265.PriceS11 = Trim$(rs7265!K7265_PriceS11)
    If IsdbNull(rs7265!K7265_PriceS12) = False Then D7265.PriceS12 = Trim$(rs7265!K7265_PriceS12)
    If IsdbNull(rs7265!K7265_PriceS13) = False Then D7265.PriceS13 = Trim$(rs7265!K7265_PriceS13)
    If IsdbNull(rs7265!K7265_PriceS14) = False Then D7265.PriceS14 = Trim$(rs7265!K7265_PriceS14)
    If IsdbNull(rs7265!K7265_PriceS15) = False Then D7265.PriceS15 = Trim$(rs7265!K7265_PriceS15)
    If IsdbNull(rs7265!K7265_PriceS16) = False Then D7265.PriceS16 = Trim$(rs7265!K7265_PriceS16)
    If IsdbNull(rs7265!K7265_PriceS17) = False Then D7265.PriceS17 = Trim$(rs7265!K7265_PriceS17)
    If IsdbNull(rs7265!K7265_PriceS18) = False Then D7265.PriceS18 = Trim$(rs7265!K7265_PriceS18)
    If IsdbNull(rs7265!K7265_PriceS19) = False Then D7265.PriceS19 = Trim$(rs7265!K7265_PriceS19)
    If IsdbNull(rs7265!K7265_PriceS20) = False Then D7265.PriceS20 = Trim$(rs7265!K7265_PriceS20)
    If IsdbNull(rs7265!K7265_PriceS21) = False Then D7265.PriceS21 = Trim$(rs7265!K7265_PriceS21)
    If IsdbNull(rs7265!K7265_PriceS22) = False Then D7265.PriceS22 = Trim$(rs7265!K7265_PriceS22)
    If IsdbNull(rs7265!K7265_PriceS23) = False Then D7265.PriceS23 = Trim$(rs7265!K7265_PriceS23)
    If IsdbNull(rs7265!K7265_PriceS24) = False Then D7265.PriceS24 = Trim$(rs7265!K7265_PriceS24)
    If IsdbNull(rs7265!K7265_PriceS25) = False Then D7265.PriceS25 = Trim$(rs7265!K7265_PriceS25)
    If IsdbNull(rs7265!K7265_PriceS26) = False Then D7265.PriceS26 = Trim$(rs7265!K7265_PriceS26)
    If IsdbNull(rs7265!K7265_PriceS27) = False Then D7265.PriceS27 = Trim$(rs7265!K7265_PriceS27)
    If IsdbNull(rs7265!K7265_PriceS28) = False Then D7265.PriceS28 = Trim$(rs7265!K7265_PriceS28)
    If IsdbNull(rs7265!K7265_PriceS29) = False Then D7265.PriceS29 = Trim$(rs7265!K7265_PriceS29)
    If IsdbNull(rs7265!K7265_PriceS30) = False Then D7265.PriceS30 = Trim$(rs7265!K7265_PriceS30)
    If IsdbNull(rs7265!K7265_Remark) = False Then D7265.Remark = Trim$(rs7265!K7265_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7265_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7265_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7265 As T7265_AREA, SHOESCODE AS String) as Boolean

K7265_MOVE = False

Try
    If READ_PFK7265(SHOESCODE) = True Then
                z7265 = D7265
		K7265_MOVE = True
		else
	z7265 = nothing
     End If

     If  getColumIndex(spr,"ShoesCode") > -1 then z7265.ShoesCode = getDataM(spr, getColumIndex(spr,"ShoesCode"), xRow)
     If  getColumIndex(spr,"PriceS01") > -1 then z7265.PriceS01 = getDataM(spr, getColumIndex(spr,"PriceS01"), xRow)
     If  getColumIndex(spr,"PriceS02") > -1 then z7265.PriceS02 = getDataM(spr, getColumIndex(spr,"PriceS02"), xRow)
     If  getColumIndex(spr,"PriceS03") > -1 then z7265.PriceS03 = getDataM(spr, getColumIndex(spr,"PriceS03"), xRow)
     If  getColumIndex(spr,"PriceS04") > -1 then z7265.PriceS04 = getDataM(spr, getColumIndex(spr,"PriceS04"), xRow)
     If  getColumIndex(spr,"PriceS05") > -1 then z7265.PriceS05 = getDataM(spr, getColumIndex(spr,"PriceS05"), xRow)
     If  getColumIndex(spr,"PriceS06") > -1 then z7265.PriceS06 = getDataM(spr, getColumIndex(spr,"PriceS06"), xRow)
     If  getColumIndex(spr,"PriceS07") > -1 then z7265.PriceS07 = getDataM(spr, getColumIndex(spr,"PriceS07"), xRow)
     If  getColumIndex(spr,"PriceS08") > -1 then z7265.PriceS08 = getDataM(spr, getColumIndex(spr,"PriceS08"), xRow)
     If  getColumIndex(spr,"PriceS09") > -1 then z7265.PriceS09 = getDataM(spr, getColumIndex(spr,"PriceS09"), xRow)
     If  getColumIndex(spr,"PriceS10") > -1 then z7265.PriceS10 = getDataM(spr, getColumIndex(spr,"PriceS10"), xRow)
     If  getColumIndex(spr,"PriceS11") > -1 then z7265.PriceS11 = getDataM(spr, getColumIndex(spr,"PriceS11"), xRow)
     If  getColumIndex(spr,"PriceS12") > -1 then z7265.PriceS12 = getDataM(spr, getColumIndex(spr,"PriceS12"), xRow)
     If  getColumIndex(spr,"PriceS13") > -1 then z7265.PriceS13 = getDataM(spr, getColumIndex(spr,"PriceS13"), xRow)
     If  getColumIndex(spr,"PriceS14") > -1 then z7265.PriceS14 = getDataM(spr, getColumIndex(spr,"PriceS14"), xRow)
     If  getColumIndex(spr,"PriceS15") > -1 then z7265.PriceS15 = getDataM(spr, getColumIndex(spr,"PriceS15"), xRow)
     If  getColumIndex(spr,"PriceS16") > -1 then z7265.PriceS16 = getDataM(spr, getColumIndex(spr,"PriceS16"), xRow)
     If  getColumIndex(spr,"PriceS17") > -1 then z7265.PriceS17 = getDataM(spr, getColumIndex(spr,"PriceS17"), xRow)
     If  getColumIndex(spr,"PriceS18") > -1 then z7265.PriceS18 = getDataM(spr, getColumIndex(spr,"PriceS18"), xRow)
     If  getColumIndex(spr,"PriceS19") > -1 then z7265.PriceS19 = getDataM(spr, getColumIndex(spr,"PriceS19"), xRow)
     If  getColumIndex(spr,"PriceS20") > -1 then z7265.PriceS20 = getDataM(spr, getColumIndex(spr,"PriceS20"), xRow)
     If  getColumIndex(spr,"PriceS21") > -1 then z7265.PriceS21 = getDataM(spr, getColumIndex(spr,"PriceS21"), xRow)
     If  getColumIndex(spr,"PriceS22") > -1 then z7265.PriceS22 = getDataM(spr, getColumIndex(spr,"PriceS22"), xRow)
     If  getColumIndex(spr,"PriceS23") > -1 then z7265.PriceS23 = getDataM(spr, getColumIndex(spr,"PriceS23"), xRow)
     If  getColumIndex(spr,"PriceS24") > -1 then z7265.PriceS24 = getDataM(spr, getColumIndex(spr,"PriceS24"), xRow)
     If  getColumIndex(spr,"PriceS25") > -1 then z7265.PriceS25 = getDataM(spr, getColumIndex(spr,"PriceS25"), xRow)
     If  getColumIndex(spr,"PriceS26") > -1 then z7265.PriceS26 = getDataM(spr, getColumIndex(spr,"PriceS26"), xRow)
     If  getColumIndex(spr,"PriceS27") > -1 then z7265.PriceS27 = getDataM(spr, getColumIndex(spr,"PriceS27"), xRow)
     If  getColumIndex(spr,"PriceS28") > -1 then z7265.PriceS28 = getDataM(spr, getColumIndex(spr,"PriceS28"), xRow)
     If  getColumIndex(spr,"PriceS29") > -1 then z7265.PriceS29 = getDataM(spr, getColumIndex(spr,"PriceS29"), xRow)
     If  getColumIndex(spr,"PriceS30") > -1 then z7265.PriceS30 = getDataM(spr, getColumIndex(spr,"PriceS30"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7265.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7265_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7265_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7265 As T7265_AREA,CheckClear as Boolean,SHOESCODE AS String) as Boolean

K7265_MOVE = False

Try
    If READ_PFK7265(SHOESCODE) = True Then
                z7265 = D7265
		K7265_MOVE = True
		else
	If CheckClear  = True then z7265 = nothing
     End If

     If  getColumIndex(spr,"ShoesCode") > -1 then z7265.ShoesCode = getDataM(spr, getColumIndex(spr,"ShoesCode"), xRow)
     If  getColumIndex(spr,"PriceS01") > -1 then z7265.PriceS01 = getDataM(spr, getColumIndex(spr,"PriceS01"), xRow)
     If  getColumIndex(spr,"PriceS02") > -1 then z7265.PriceS02 = getDataM(spr, getColumIndex(spr,"PriceS02"), xRow)
     If  getColumIndex(spr,"PriceS03") > -1 then z7265.PriceS03 = getDataM(spr, getColumIndex(spr,"PriceS03"), xRow)
     If  getColumIndex(spr,"PriceS04") > -1 then z7265.PriceS04 = getDataM(spr, getColumIndex(spr,"PriceS04"), xRow)
     If  getColumIndex(spr,"PriceS05") > -1 then z7265.PriceS05 = getDataM(spr, getColumIndex(spr,"PriceS05"), xRow)
     If  getColumIndex(spr,"PriceS06") > -1 then z7265.PriceS06 = getDataM(spr, getColumIndex(spr,"PriceS06"), xRow)
     If  getColumIndex(spr,"PriceS07") > -1 then z7265.PriceS07 = getDataM(spr, getColumIndex(spr,"PriceS07"), xRow)
     If  getColumIndex(spr,"PriceS08") > -1 then z7265.PriceS08 = getDataM(spr, getColumIndex(spr,"PriceS08"), xRow)
     If  getColumIndex(spr,"PriceS09") > -1 then z7265.PriceS09 = getDataM(spr, getColumIndex(spr,"PriceS09"), xRow)
     If  getColumIndex(spr,"PriceS10") > -1 then z7265.PriceS10 = getDataM(spr, getColumIndex(spr,"PriceS10"), xRow)
     If  getColumIndex(spr,"PriceS11") > -1 then z7265.PriceS11 = getDataM(spr, getColumIndex(spr,"PriceS11"), xRow)
     If  getColumIndex(spr,"PriceS12") > -1 then z7265.PriceS12 = getDataM(spr, getColumIndex(spr,"PriceS12"), xRow)
     If  getColumIndex(spr,"PriceS13") > -1 then z7265.PriceS13 = getDataM(spr, getColumIndex(spr,"PriceS13"), xRow)
     If  getColumIndex(spr,"PriceS14") > -1 then z7265.PriceS14 = getDataM(spr, getColumIndex(spr,"PriceS14"), xRow)
     If  getColumIndex(spr,"PriceS15") > -1 then z7265.PriceS15 = getDataM(spr, getColumIndex(spr,"PriceS15"), xRow)
     If  getColumIndex(spr,"PriceS16") > -1 then z7265.PriceS16 = getDataM(spr, getColumIndex(spr,"PriceS16"), xRow)
     If  getColumIndex(spr,"PriceS17") > -1 then z7265.PriceS17 = getDataM(spr, getColumIndex(spr,"PriceS17"), xRow)
     If  getColumIndex(spr,"PriceS18") > -1 then z7265.PriceS18 = getDataM(spr, getColumIndex(spr,"PriceS18"), xRow)
     If  getColumIndex(spr,"PriceS19") > -1 then z7265.PriceS19 = getDataM(spr, getColumIndex(spr,"PriceS19"), xRow)
     If  getColumIndex(spr,"PriceS20") > -1 then z7265.PriceS20 = getDataM(spr, getColumIndex(spr,"PriceS20"), xRow)
     If  getColumIndex(spr,"PriceS21") > -1 then z7265.PriceS21 = getDataM(spr, getColumIndex(spr,"PriceS21"), xRow)
     If  getColumIndex(spr,"PriceS22") > -1 then z7265.PriceS22 = getDataM(spr, getColumIndex(spr,"PriceS22"), xRow)
     If  getColumIndex(spr,"PriceS23") > -1 then z7265.PriceS23 = getDataM(spr, getColumIndex(spr,"PriceS23"), xRow)
     If  getColumIndex(spr,"PriceS24") > -1 then z7265.PriceS24 = getDataM(spr, getColumIndex(spr,"PriceS24"), xRow)
     If  getColumIndex(spr,"PriceS25") > -1 then z7265.PriceS25 = getDataM(spr, getColumIndex(spr,"PriceS25"), xRow)
     If  getColumIndex(spr,"PriceS26") > -1 then z7265.PriceS26 = getDataM(spr, getColumIndex(spr,"PriceS26"), xRow)
     If  getColumIndex(spr,"PriceS27") > -1 then z7265.PriceS27 = getDataM(spr, getColumIndex(spr,"PriceS27"), xRow)
     If  getColumIndex(spr,"PriceS28") > -1 then z7265.PriceS28 = getDataM(spr, getColumIndex(spr,"PriceS28"), xRow)
     If  getColumIndex(spr,"PriceS29") > -1 then z7265.PriceS29 = getDataM(spr, getColumIndex(spr,"PriceS29"), xRow)
     If  getColumIndex(spr,"PriceS30") > -1 then z7265.PriceS30 = getDataM(spr, getColumIndex(spr,"PriceS30"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7265.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7265_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7265_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7265 As T7265_AREA, Job as String, SHOESCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7265_MOVE = False

Try
    If READ_PFK7265(SHOESCODE) = True Then
                z7265 = D7265
		K7265_MOVE = True
		else
	z7265 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7265")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SHOESCODE":z7265.ShoesCode = Children(i).Code
   Case "PRICES01":z7265.PriceS01 = Children(i).Code
   Case "PRICES02":z7265.PriceS02 = Children(i).Code
   Case "PRICES03":z7265.PriceS03 = Children(i).Code
   Case "PRICES04":z7265.PriceS04 = Children(i).Code
   Case "PRICES05":z7265.PriceS05 = Children(i).Code
   Case "PRICES06":z7265.PriceS06 = Children(i).Code
   Case "PRICES07":z7265.PriceS07 = Children(i).Code
   Case "PRICES08":z7265.PriceS08 = Children(i).Code
   Case "PRICES09":z7265.PriceS09 = Children(i).Code
   Case "PRICES10":z7265.PriceS10 = Children(i).Code
   Case "PRICES11":z7265.PriceS11 = Children(i).Code
   Case "PRICES12":z7265.PriceS12 = Children(i).Code
   Case "PRICES13":z7265.PriceS13 = Children(i).Code
   Case "PRICES14":z7265.PriceS14 = Children(i).Code
   Case "PRICES15":z7265.PriceS15 = Children(i).Code
   Case "PRICES16":z7265.PriceS16 = Children(i).Code
   Case "PRICES17":z7265.PriceS17 = Children(i).Code
   Case "PRICES18":z7265.PriceS18 = Children(i).Code
   Case "PRICES19":z7265.PriceS19 = Children(i).Code
   Case "PRICES20":z7265.PriceS20 = Children(i).Code
   Case "PRICES21":z7265.PriceS21 = Children(i).Code
   Case "PRICES22":z7265.PriceS22 = Children(i).Code
   Case "PRICES23":z7265.PriceS23 = Children(i).Code
   Case "PRICES24":z7265.PriceS24 = Children(i).Code
   Case "PRICES25":z7265.PriceS25 = Children(i).Code
   Case "PRICES26":z7265.PriceS26 = Children(i).Code
   Case "PRICES27":z7265.PriceS27 = Children(i).Code
   Case "PRICES28":z7265.PriceS28 = Children(i).Code
   Case "PRICES29":z7265.PriceS29 = Children(i).Code
   Case "PRICES30":z7265.PriceS30 = Children(i).Code
   Case "REMARK":z7265.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SHOESCODE":z7265.ShoesCode = Children(i).Data
   Case "PRICES01":z7265.PriceS01 = Children(i).Data
   Case "PRICES02":z7265.PriceS02 = Children(i).Data
   Case "PRICES03":z7265.PriceS03 = Children(i).Data
   Case "PRICES04":z7265.PriceS04 = Children(i).Data
   Case "PRICES05":z7265.PriceS05 = Children(i).Data
   Case "PRICES06":z7265.PriceS06 = Children(i).Data
   Case "PRICES07":z7265.PriceS07 = Children(i).Data
   Case "PRICES08":z7265.PriceS08 = Children(i).Data
   Case "PRICES09":z7265.PriceS09 = Children(i).Data
   Case "PRICES10":z7265.PriceS10 = Children(i).Data
   Case "PRICES11":z7265.PriceS11 = Children(i).Data
   Case "PRICES12":z7265.PriceS12 = Children(i).Data
   Case "PRICES13":z7265.PriceS13 = Children(i).Data
   Case "PRICES14":z7265.PriceS14 = Children(i).Data
   Case "PRICES15":z7265.PriceS15 = Children(i).Data
   Case "PRICES16":z7265.PriceS16 = Children(i).Data
   Case "PRICES17":z7265.PriceS17 = Children(i).Data
   Case "PRICES18":z7265.PriceS18 = Children(i).Data
   Case "PRICES19":z7265.PriceS19 = Children(i).Data
   Case "PRICES20":z7265.PriceS20 = Children(i).Data
   Case "PRICES21":z7265.PriceS21 = Children(i).Data
   Case "PRICES22":z7265.PriceS22 = Children(i).Data
   Case "PRICES23":z7265.PriceS23 = Children(i).Data
   Case "PRICES24":z7265.PriceS24 = Children(i).Data
   Case "PRICES25":z7265.PriceS25 = Children(i).Data
   Case "PRICES26":z7265.PriceS26 = Children(i).Data
   Case "PRICES27":z7265.PriceS27 = Children(i).Data
   Case "PRICES28":z7265.PriceS28 = Children(i).Data
   Case "PRICES29":z7265.PriceS29 = Children(i).Data
   Case "PRICES30":z7265.PriceS30 = Children(i).Data
   Case "REMARK":z7265.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7265_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7265_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7265 As T7265_AREA, Job as String, CheckClear as Boolean, SHOESCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7265_MOVE = False

Try
    If READ_PFK7265(SHOESCODE) = True Then
                z7265 = D7265
		K7265_MOVE = True
		else
	If CheckClear  = True then z7265 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7265")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SHOESCODE":z7265.ShoesCode = Children(i).Code
   Case "PRICES01":z7265.PriceS01 = Children(i).Code
   Case "PRICES02":z7265.PriceS02 = Children(i).Code
   Case "PRICES03":z7265.PriceS03 = Children(i).Code
   Case "PRICES04":z7265.PriceS04 = Children(i).Code
   Case "PRICES05":z7265.PriceS05 = Children(i).Code
   Case "PRICES06":z7265.PriceS06 = Children(i).Code
   Case "PRICES07":z7265.PriceS07 = Children(i).Code
   Case "PRICES08":z7265.PriceS08 = Children(i).Code
   Case "PRICES09":z7265.PriceS09 = Children(i).Code
   Case "PRICES10":z7265.PriceS10 = Children(i).Code
   Case "PRICES11":z7265.PriceS11 = Children(i).Code
   Case "PRICES12":z7265.PriceS12 = Children(i).Code
   Case "PRICES13":z7265.PriceS13 = Children(i).Code
   Case "PRICES14":z7265.PriceS14 = Children(i).Code
   Case "PRICES15":z7265.PriceS15 = Children(i).Code
   Case "PRICES16":z7265.PriceS16 = Children(i).Code
   Case "PRICES17":z7265.PriceS17 = Children(i).Code
   Case "PRICES18":z7265.PriceS18 = Children(i).Code
   Case "PRICES19":z7265.PriceS19 = Children(i).Code
   Case "PRICES20":z7265.PriceS20 = Children(i).Code
   Case "PRICES21":z7265.PriceS21 = Children(i).Code
   Case "PRICES22":z7265.PriceS22 = Children(i).Code
   Case "PRICES23":z7265.PriceS23 = Children(i).Code
   Case "PRICES24":z7265.PriceS24 = Children(i).Code
   Case "PRICES25":z7265.PriceS25 = Children(i).Code
   Case "PRICES26":z7265.PriceS26 = Children(i).Code
   Case "PRICES27":z7265.PriceS27 = Children(i).Code
   Case "PRICES28":z7265.PriceS28 = Children(i).Code
   Case "PRICES29":z7265.PriceS29 = Children(i).Code
   Case "PRICES30":z7265.PriceS30 = Children(i).Code
   Case "REMARK":z7265.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SHOESCODE":z7265.ShoesCode = Children(i).Data
   Case "PRICES01":z7265.PriceS01 = Children(i).Data
   Case "PRICES02":z7265.PriceS02 = Children(i).Data
   Case "PRICES03":z7265.PriceS03 = Children(i).Data
   Case "PRICES04":z7265.PriceS04 = Children(i).Data
   Case "PRICES05":z7265.PriceS05 = Children(i).Data
   Case "PRICES06":z7265.PriceS06 = Children(i).Data
   Case "PRICES07":z7265.PriceS07 = Children(i).Data
   Case "PRICES08":z7265.PriceS08 = Children(i).Data
   Case "PRICES09":z7265.PriceS09 = Children(i).Data
   Case "PRICES10":z7265.PriceS10 = Children(i).Data
   Case "PRICES11":z7265.PriceS11 = Children(i).Data
   Case "PRICES12":z7265.PriceS12 = Children(i).Data
   Case "PRICES13":z7265.PriceS13 = Children(i).Data
   Case "PRICES14":z7265.PriceS14 = Children(i).Data
   Case "PRICES15":z7265.PriceS15 = Children(i).Data
   Case "PRICES16":z7265.PriceS16 = Children(i).Data
   Case "PRICES17":z7265.PriceS17 = Children(i).Data
   Case "PRICES18":z7265.PriceS18 = Children(i).Data
   Case "PRICES19":z7265.PriceS19 = Children(i).Data
   Case "PRICES20":z7265.PriceS20 = Children(i).Data
   Case "PRICES21":z7265.PriceS21 = Children(i).Data
   Case "PRICES22":z7265.PriceS22 = Children(i).Data
   Case "PRICES23":z7265.PriceS23 = Children(i).Data
   Case "PRICES24":z7265.PriceS24 = Children(i).Data
   Case "PRICES25":z7265.PriceS25 = Children(i).Data
   Case "PRICES26":z7265.PriceS26 = Children(i).Data
   Case "PRICES27":z7265.PriceS27 = Children(i).Data
   Case "PRICES28":z7265.PriceS28 = Children(i).Data
   Case "PRICES29":z7265.PriceS29 = Children(i).Data
   Case "PRICES30":z7265.PriceS30 = Children(i).Data
   Case "REMARK":z7265.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7265_MOVE",vbCritical)
End Try
End Function 
    
End Module 
