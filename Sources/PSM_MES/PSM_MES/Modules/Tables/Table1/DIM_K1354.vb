'=========================================================================================================================================================
'   TABLE : (PFK1354)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K1354

Structure T1354_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	OrderNo	 AS String	'			char(9)		*
Public 	OrderNoSeq	 AS String	'			char(3)		*
Public 	CheckS01	 AS String	'			char(1)
Public 	CheckS02	 AS String	'			char(1)
Public 	CheckS03	 AS String	'			char(1)
Public 	CheckS04	 AS String	'			char(1)
Public 	CheckS05	 AS String	'			char(1)
Public 	CheckS06	 AS String	'			char(1)
Public 	CheckS07	 AS String	'			char(1)
Public 	CheckS08	 AS String	'			char(1)
Public 	CheckS09	 AS String	'			char(1)
Public 	CheckS10	 AS String	'			char(1)
Public 	CheckS11	 AS String	'			char(1)
Public 	CheckS12	 AS String	'			char(1)
Public 	CheckS13	 AS String	'			char(1)
Public 	CheckS14	 AS String	'			char(1)
Public 	CheckS15	 AS String	'			char(1)
Public 	CheckS16	 AS String	'			char(1)
Public 	CheckS17	 AS String	'			char(1)
Public 	CheckS18	 AS String	'			char(1)
Public 	CheckS19	 AS String	'			char(1)
Public 	CheckS20	 AS String	'			char(1)
Public 	CheckS21	 AS String	'			char(1)
Public 	CheckS22	 AS String	'			char(1)
Public 	CheckS23	 AS String	'			char(1)
Public 	CheckS24	 AS String	'			char(1)
Public 	CheckS25	 AS String	'			char(1)
Public 	CheckS26	 AS String	'			char(1)
Public 	CheckS27	 AS String	'			char(1)
Public 	CheckS28	 AS String	'			char(1)
Public 	CheckS29	 AS String	'			char(1)
Public 	CheckS30	 AS String	'			char(1)
Public 	PSizeQty01	 AS Double	'			decimal
Public 	PSizeQty02	 AS Double	'			decimal
Public 	PSizeQty03	 AS Double	'			decimal
Public 	PSizeQty04	 AS Double	'			decimal
Public 	PSizeQty05	 AS Double	'			decimal
Public 	PSizeQty06	 AS Double	'			decimal
Public 	PSizeQty07	 AS Double	'			decimal
Public 	PSizeQty08	 AS Double	'			decimal
Public 	PSizeQty09	 AS Double	'			decimal
Public 	PSizeQty10	 AS Double	'			decimal
Public 	PSizeQty11	 AS Double	'			decimal
Public 	PSizeQty12	 AS Double	'			decimal
Public 	PSizeQty13	 AS Double	'			decimal
Public 	PSizeQty14	 AS Double	'			decimal
Public 	PSizeQty15	 AS Double	'			decimal
Public 	PSizeQty16	 AS Double	'			decimal
Public 	PSizeQty17	 AS Double	'			decimal
Public 	PSizeQty18	 AS Double	'			decimal
Public 	PSizeQty19	 AS Double	'			decimal
Public 	PSizeQty20	 AS Double	'			decimal
Public 	PSizeQty21	 AS Double	'			decimal
Public 	PSizeQty22	 AS Double	'			decimal
Public 	PSizeQty23	 AS Double	'			decimal
Public 	PSizeQty24	 AS Double	'			decimal
Public 	PSizeQty25	 AS Double	'			decimal
Public 	PSizeQty26	 AS Double	'			decimal
Public 	PSizeQty27	 AS Double	'			decimal
Public 	PSizeQty28	 AS Double	'			decimal
Public 	PSizeQty29	 AS Double	'			decimal
Public 	PSizeQty30	 AS Double	'			decimal
Public 	AmtSizeQty01	 AS Double	'			decimal
Public 	AmtSizeQty02	 AS Double	'			decimal
Public 	AmtSizeQty03	 AS Double	'			decimal
Public 	AmtSizeQty04	 AS Double	'			decimal
Public 	AmtSizeQty05	 AS Double	'			decimal
Public 	AmtSizeQty06	 AS Double	'			decimal
Public 	AmtSizeQty07	 AS Double	'			decimal
Public 	AmtSizeQty08	 AS Double	'			decimal
Public 	AmtSizeQty09	 AS Double	'			decimal
Public 	AmtSizeQty10	 AS Double	'			decimal
Public 	AmtSizeQty11	 AS Double	'			decimal
Public 	AmtSizeQty12	 AS Double	'			decimal
Public 	AmtSizeQty13	 AS Double	'			decimal
Public 	AmtSizeQty14	 AS Double	'			decimal
Public 	AmtSizeQty15	 AS Double	'			decimal
Public 	AmtSizeQty16	 AS Double	'			decimal
Public 	AmtSizeQty17	 AS Double	'			decimal
Public 	AmtSizeQty18	 AS Double	'			decimal
Public 	AmtSizeQty19	 AS Double	'			decimal
Public 	AmtSizeQty20	 AS Double	'			decimal
Public 	AmtSizeQty21	 AS Double	'			decimal
Public 	AmtSizeQty22	 AS Double	'			decimal
Public 	AmtSizeQty23	 AS Double	'			decimal
Public 	AmtSizeQty24	 AS Double	'			decimal
Public 	AmtSizeQty25	 AS Double	'			decimal
Public 	AmtSizeQty26	 AS Double	'			decimal
Public 	AmtSizeQty27	 AS Double	'			decimal
Public 	AmtSizeQty28	 AS Double	'			decimal
Public 	AmtSizeQty29	 AS Double	'			decimal
Public 	AmtSizeQty30	 AS Double	'			decimal
Public 	Remark	 AS String	'			nvarchar(500)
'=========================================================================================================================================================
End structure

Public D1354 As T1354_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK1354(ORDERNO AS String, ORDERNOSEQ AS String) As Boolean
    READ_PFK1354 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK1354 "
    SQL = SQL & " WHERE K1354_OrderNo		 = '" & OrderNo & "' " 
    SQL = SQL & "   AND K1354_OrderNoSeq		 = '" & OrderNoSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D1354_CLEAR: GoTo SKIP_READ_PFK1354
                
    Call K1354_MOVE(rd)
    READ_PFK1354 = True

SKIP_READ_PFK1354:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK1354",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK1354(ORDERNO AS String, ORDERNOSEQ AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK1354 "
    SQL = SQL & " WHERE K1354_OrderNo		 = '" & OrderNo & "' " 
    SQL = SQL & "   AND K1354_OrderNoSeq		 = '" & OrderNoSeq & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK1354",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK1354(z1354 As T1354_AREA) As Boolean
    WRITE_PFK1354 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z1354)
 
    SQL = " INSERT INTO PFK1354 "
    SQL = SQL & " ( "
    SQL = SQL & " K1354_OrderNo," 
    SQL = SQL & " K1354_OrderNoSeq," 
    SQL = SQL & " K1354_CheckS01," 
    SQL = SQL & " K1354_CheckS02," 
    SQL = SQL & " K1354_CheckS03," 
    SQL = SQL & " K1354_CheckS04," 
    SQL = SQL & " K1354_CheckS05," 
    SQL = SQL & " K1354_CheckS06," 
    SQL = SQL & " K1354_CheckS07," 
    SQL = SQL & " K1354_CheckS08," 
    SQL = SQL & " K1354_CheckS09," 
    SQL = SQL & " K1354_CheckS10," 
    SQL = SQL & " K1354_CheckS11," 
    SQL = SQL & " K1354_CheckS12," 
    SQL = SQL & " K1354_CheckS13," 
    SQL = SQL & " K1354_CheckS14," 
    SQL = SQL & " K1354_CheckS15," 
    SQL = SQL & " K1354_CheckS16," 
    SQL = SQL & " K1354_CheckS17," 
    SQL = SQL & " K1354_CheckS18," 
    SQL = SQL & " K1354_CheckS19," 
    SQL = SQL & " K1354_CheckS20," 
    SQL = SQL & " K1354_CheckS21," 
    SQL = SQL & " K1354_CheckS22," 
    SQL = SQL & " K1354_CheckS23," 
    SQL = SQL & " K1354_CheckS24," 
    SQL = SQL & " K1354_CheckS25," 
    SQL = SQL & " K1354_CheckS26," 
    SQL = SQL & " K1354_CheckS27," 
    SQL = SQL & " K1354_CheckS28," 
    SQL = SQL & " K1354_CheckS29," 
    SQL = SQL & " K1354_CheckS30," 
    SQL = SQL & " K1354_PSizeQty01," 
    SQL = SQL & " K1354_PSizeQty02," 
    SQL = SQL & " K1354_PSizeQty03," 
    SQL = SQL & " K1354_PSizeQty04," 
    SQL = SQL & " K1354_PSizeQty05," 
    SQL = SQL & " K1354_PSizeQty06," 
    SQL = SQL & " K1354_PSizeQty07," 
    SQL = SQL & " K1354_PSizeQty08," 
    SQL = SQL & " K1354_PSizeQty09," 
    SQL = SQL & " K1354_PSizeQty10," 
    SQL = SQL & " K1354_PSizeQty11," 
    SQL = SQL & " K1354_PSizeQty12," 
    SQL = SQL & " K1354_PSizeQty13," 
    SQL = SQL & " K1354_PSizeQty14," 
    SQL = SQL & " K1354_PSizeQty15," 
    SQL = SQL & " K1354_PSizeQty16," 
    SQL = SQL & " K1354_PSizeQty17," 
    SQL = SQL & " K1354_PSizeQty18," 
    SQL = SQL & " K1354_PSizeQty19," 
    SQL = SQL & " K1354_PSizeQty20," 
    SQL = SQL & " K1354_PSizeQty21," 
    SQL = SQL & " K1354_PSizeQty22," 
    SQL = SQL & " K1354_PSizeQty23," 
    SQL = SQL & " K1354_PSizeQty24," 
    SQL = SQL & " K1354_PSizeQty25," 
    SQL = SQL & " K1354_PSizeQty26," 
    SQL = SQL & " K1354_PSizeQty27," 
    SQL = SQL & " K1354_PSizeQty28," 
    SQL = SQL & " K1354_PSizeQty29," 
    SQL = SQL & " K1354_PSizeQty30," 
    SQL = SQL & " K1354_AmtSizeQty01," 
    SQL = SQL & " K1354_AmtSizeQty02," 
    SQL = SQL & " K1354_AmtSizeQty03," 
    SQL = SQL & " K1354_AmtSizeQty04," 
    SQL = SQL & " K1354_AmtSizeQty05," 
    SQL = SQL & " K1354_AmtSizeQty06," 
    SQL = SQL & " K1354_AmtSizeQty07," 
    SQL = SQL & " K1354_AmtSizeQty08," 
    SQL = SQL & " K1354_AmtSizeQty09," 
    SQL = SQL & " K1354_AmtSizeQty10," 
    SQL = SQL & " K1354_AmtSizeQty11," 
    SQL = SQL & " K1354_AmtSizeQty12," 
    SQL = SQL & " K1354_AmtSizeQty13," 
    SQL = SQL & " K1354_AmtSizeQty14," 
    SQL = SQL & " K1354_AmtSizeQty15," 
    SQL = SQL & " K1354_AmtSizeQty16," 
    SQL = SQL & " K1354_AmtSizeQty17," 
    SQL = SQL & " K1354_AmtSizeQty18," 
    SQL = SQL & " K1354_AmtSizeQty19," 
    SQL = SQL & " K1354_AmtSizeQty20," 
    SQL = SQL & " K1354_AmtSizeQty21," 
    SQL = SQL & " K1354_AmtSizeQty22," 
    SQL = SQL & " K1354_AmtSizeQty23," 
    SQL = SQL & " K1354_AmtSizeQty24," 
    SQL = SQL & " K1354_AmtSizeQty25," 
    SQL = SQL & " K1354_AmtSizeQty26," 
    SQL = SQL & " K1354_AmtSizeQty27," 
    SQL = SQL & " K1354_AmtSizeQty28," 
    SQL = SQL & " K1354_AmtSizeQty29," 
    SQL = SQL & " K1354_AmtSizeQty30," 
    SQL = SQL & " K1354_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z1354.OrderNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1354.OrderNoSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1354.CheckS01) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1354.CheckS02) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1354.CheckS03) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1354.CheckS04) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1354.CheckS05) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1354.CheckS06) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1354.CheckS07) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1354.CheckS08) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1354.CheckS09) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1354.CheckS10) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1354.CheckS11) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1354.CheckS12) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1354.CheckS13) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1354.CheckS14) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1354.CheckS15) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1354.CheckS16) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1354.CheckS17) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1354.CheckS18) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1354.CheckS19) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1354.CheckS20) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1354.CheckS21) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1354.CheckS22) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1354.CheckS23) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1354.CheckS24) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1354.CheckS25) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1354.CheckS26) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1354.CheckS27) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1354.CheckS28) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1354.CheckS29) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1354.CheckS30) & "', "  
    SQL = SQL & "   " & FormatSQL(z1354.PSizeQty01) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.PSizeQty02) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.PSizeQty03) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.PSizeQty04) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.PSizeQty05) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.PSizeQty06) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.PSizeQty07) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.PSizeQty08) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.PSizeQty09) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.PSizeQty10) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.PSizeQty11) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.PSizeQty12) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.PSizeQty13) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.PSizeQty14) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.PSizeQty15) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.PSizeQty16) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.PSizeQty17) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.PSizeQty18) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.PSizeQty19) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.PSizeQty20) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.PSizeQty21) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.PSizeQty22) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.PSizeQty23) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.PSizeQty24) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.PSizeQty25) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.PSizeQty26) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.PSizeQty27) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.PSizeQty28) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.PSizeQty29) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.PSizeQty30) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.AmtSizeQty01) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.AmtSizeQty02) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.AmtSizeQty03) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.AmtSizeQty04) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.AmtSizeQty05) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.AmtSizeQty06) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.AmtSizeQty07) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.AmtSizeQty08) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.AmtSizeQty09) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.AmtSizeQty10) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.AmtSizeQty11) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.AmtSizeQty12) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.AmtSizeQty13) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.AmtSizeQty14) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.AmtSizeQty15) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.AmtSizeQty16) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.AmtSizeQty17) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.AmtSizeQty18) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.AmtSizeQty19) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.AmtSizeQty20) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.AmtSizeQty21) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.AmtSizeQty22) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.AmtSizeQty23) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.AmtSizeQty24) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.AmtSizeQty25) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.AmtSizeQty26) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.AmtSizeQty27) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.AmtSizeQty28) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.AmtSizeQty29) & ", "  
    SQL = SQL & "   " & FormatSQL(z1354.AmtSizeQty30) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z1354.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK1354 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK1354",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK1354(z1354 As T1354_AREA) As Boolean
    REWRITE_PFK1354 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z1354)
   
    SQL = " UPDATE PFK1354 SET "
    SQL = SQL & "    K1354_CheckS01      = N'" & FormatSQL(z1354.CheckS01) & "', " 
    SQL = SQL & "    K1354_CheckS02      = N'" & FormatSQL(z1354.CheckS02) & "', " 
    SQL = SQL & "    K1354_CheckS03      = N'" & FormatSQL(z1354.CheckS03) & "', " 
    SQL = SQL & "    K1354_CheckS04      = N'" & FormatSQL(z1354.CheckS04) & "', " 
    SQL = SQL & "    K1354_CheckS05      = N'" & FormatSQL(z1354.CheckS05) & "', " 
    SQL = SQL & "    K1354_CheckS06      = N'" & FormatSQL(z1354.CheckS06) & "', " 
    SQL = SQL & "    K1354_CheckS07      = N'" & FormatSQL(z1354.CheckS07) & "', " 
    SQL = SQL & "    K1354_CheckS08      = N'" & FormatSQL(z1354.CheckS08) & "', " 
    SQL = SQL & "    K1354_CheckS09      = N'" & FormatSQL(z1354.CheckS09) & "', " 
    SQL = SQL & "    K1354_CheckS10      = N'" & FormatSQL(z1354.CheckS10) & "', " 
    SQL = SQL & "    K1354_CheckS11      = N'" & FormatSQL(z1354.CheckS11) & "', " 
    SQL = SQL & "    K1354_CheckS12      = N'" & FormatSQL(z1354.CheckS12) & "', " 
    SQL = SQL & "    K1354_CheckS13      = N'" & FormatSQL(z1354.CheckS13) & "', " 
    SQL = SQL & "    K1354_CheckS14      = N'" & FormatSQL(z1354.CheckS14) & "', " 
    SQL = SQL & "    K1354_CheckS15      = N'" & FormatSQL(z1354.CheckS15) & "', " 
    SQL = SQL & "    K1354_CheckS16      = N'" & FormatSQL(z1354.CheckS16) & "', " 
    SQL = SQL & "    K1354_CheckS17      = N'" & FormatSQL(z1354.CheckS17) & "', " 
    SQL = SQL & "    K1354_CheckS18      = N'" & FormatSQL(z1354.CheckS18) & "', " 
    SQL = SQL & "    K1354_CheckS19      = N'" & FormatSQL(z1354.CheckS19) & "', " 
    SQL = SQL & "    K1354_CheckS20      = N'" & FormatSQL(z1354.CheckS20) & "', " 
    SQL = SQL & "    K1354_CheckS21      = N'" & FormatSQL(z1354.CheckS21) & "', " 
    SQL = SQL & "    K1354_CheckS22      = N'" & FormatSQL(z1354.CheckS22) & "', " 
    SQL = SQL & "    K1354_CheckS23      = N'" & FormatSQL(z1354.CheckS23) & "', " 
    SQL = SQL & "    K1354_CheckS24      = N'" & FormatSQL(z1354.CheckS24) & "', " 
    SQL = SQL & "    K1354_CheckS25      = N'" & FormatSQL(z1354.CheckS25) & "', " 
    SQL = SQL & "    K1354_CheckS26      = N'" & FormatSQL(z1354.CheckS26) & "', " 
    SQL = SQL & "    K1354_CheckS27      = N'" & FormatSQL(z1354.CheckS27) & "', " 
    SQL = SQL & "    K1354_CheckS28      = N'" & FormatSQL(z1354.CheckS28) & "', " 
    SQL = SQL & "    K1354_CheckS29      = N'" & FormatSQL(z1354.CheckS29) & "', " 
    SQL = SQL & "    K1354_CheckS30      = N'" & FormatSQL(z1354.CheckS30) & "', " 
    SQL = SQL & "    K1354_PSizeQty01      =  " & FormatSQL(z1354.PSizeQty01) & ", " 
    SQL = SQL & "    K1354_PSizeQty02      =  " & FormatSQL(z1354.PSizeQty02) & ", " 
    SQL = SQL & "    K1354_PSizeQty03      =  " & FormatSQL(z1354.PSizeQty03) & ", " 
    SQL = SQL & "    K1354_PSizeQty04      =  " & FormatSQL(z1354.PSizeQty04) & ", " 
    SQL = SQL & "    K1354_PSizeQty05      =  " & FormatSQL(z1354.PSizeQty05) & ", " 
    SQL = SQL & "    K1354_PSizeQty06      =  " & FormatSQL(z1354.PSizeQty06) & ", " 
    SQL = SQL & "    K1354_PSizeQty07      =  " & FormatSQL(z1354.PSizeQty07) & ", " 
    SQL = SQL & "    K1354_PSizeQty08      =  " & FormatSQL(z1354.PSizeQty08) & ", " 
    SQL = SQL & "    K1354_PSizeQty09      =  " & FormatSQL(z1354.PSizeQty09) & ", " 
    SQL = SQL & "    K1354_PSizeQty10      =  " & FormatSQL(z1354.PSizeQty10) & ", " 
    SQL = SQL & "    K1354_PSizeQty11      =  " & FormatSQL(z1354.PSizeQty11) & ", " 
    SQL = SQL & "    K1354_PSizeQty12      =  " & FormatSQL(z1354.PSizeQty12) & ", " 
    SQL = SQL & "    K1354_PSizeQty13      =  " & FormatSQL(z1354.PSizeQty13) & ", " 
    SQL = SQL & "    K1354_PSizeQty14      =  " & FormatSQL(z1354.PSizeQty14) & ", " 
    SQL = SQL & "    K1354_PSizeQty15      =  " & FormatSQL(z1354.PSizeQty15) & ", " 
    SQL = SQL & "    K1354_PSizeQty16      =  " & FormatSQL(z1354.PSizeQty16) & ", " 
    SQL = SQL & "    K1354_PSizeQty17      =  " & FormatSQL(z1354.PSizeQty17) & ", " 
    SQL = SQL & "    K1354_PSizeQty18      =  " & FormatSQL(z1354.PSizeQty18) & ", " 
    SQL = SQL & "    K1354_PSizeQty19      =  " & FormatSQL(z1354.PSizeQty19) & ", " 
    SQL = SQL & "    K1354_PSizeQty20      =  " & FormatSQL(z1354.PSizeQty20) & ", " 
    SQL = SQL & "    K1354_PSizeQty21      =  " & FormatSQL(z1354.PSizeQty21) & ", " 
    SQL = SQL & "    K1354_PSizeQty22      =  " & FormatSQL(z1354.PSizeQty22) & ", " 
    SQL = SQL & "    K1354_PSizeQty23      =  " & FormatSQL(z1354.PSizeQty23) & ", " 
    SQL = SQL & "    K1354_PSizeQty24      =  " & FormatSQL(z1354.PSizeQty24) & ", " 
    SQL = SQL & "    K1354_PSizeQty25      =  " & FormatSQL(z1354.PSizeQty25) & ", " 
    SQL = SQL & "    K1354_PSizeQty26      =  " & FormatSQL(z1354.PSizeQty26) & ", " 
    SQL = SQL & "    K1354_PSizeQty27      =  " & FormatSQL(z1354.PSizeQty27) & ", " 
    SQL = SQL & "    K1354_PSizeQty28      =  " & FormatSQL(z1354.PSizeQty28) & ", " 
    SQL = SQL & "    K1354_PSizeQty29      =  " & FormatSQL(z1354.PSizeQty29) & ", " 
    SQL = SQL & "    K1354_PSizeQty30      =  " & FormatSQL(z1354.PSizeQty30) & ", " 
    SQL = SQL & "    K1354_AmtSizeQty01      =  " & FormatSQL(z1354.AmtSizeQty01) & ", " 
    SQL = SQL & "    K1354_AmtSizeQty02      =  " & FormatSQL(z1354.AmtSizeQty02) & ", " 
    SQL = SQL & "    K1354_AmtSizeQty03      =  " & FormatSQL(z1354.AmtSizeQty03) & ", " 
    SQL = SQL & "    K1354_AmtSizeQty04      =  " & FormatSQL(z1354.AmtSizeQty04) & ", " 
    SQL = SQL & "    K1354_AmtSizeQty05      =  " & FormatSQL(z1354.AmtSizeQty05) & ", " 
    SQL = SQL & "    K1354_AmtSizeQty06      =  " & FormatSQL(z1354.AmtSizeQty06) & ", " 
    SQL = SQL & "    K1354_AmtSizeQty07      =  " & FormatSQL(z1354.AmtSizeQty07) & ", " 
    SQL = SQL & "    K1354_AmtSizeQty08      =  " & FormatSQL(z1354.AmtSizeQty08) & ", " 
    SQL = SQL & "    K1354_AmtSizeQty09      =  " & FormatSQL(z1354.AmtSizeQty09) & ", " 
    SQL = SQL & "    K1354_AmtSizeQty10      =  " & FormatSQL(z1354.AmtSizeQty10) & ", " 
    SQL = SQL & "    K1354_AmtSizeQty11      =  " & FormatSQL(z1354.AmtSizeQty11) & ", " 
    SQL = SQL & "    K1354_AmtSizeQty12      =  " & FormatSQL(z1354.AmtSizeQty12) & ", " 
    SQL = SQL & "    K1354_AmtSizeQty13      =  " & FormatSQL(z1354.AmtSizeQty13) & ", " 
    SQL = SQL & "    K1354_AmtSizeQty14      =  " & FormatSQL(z1354.AmtSizeQty14) & ", " 
    SQL = SQL & "    K1354_AmtSizeQty15      =  " & FormatSQL(z1354.AmtSizeQty15) & ", " 
    SQL = SQL & "    K1354_AmtSizeQty16      =  " & FormatSQL(z1354.AmtSizeQty16) & ", " 
    SQL = SQL & "    K1354_AmtSizeQty17      =  " & FormatSQL(z1354.AmtSizeQty17) & ", " 
    SQL = SQL & "    K1354_AmtSizeQty18      =  " & FormatSQL(z1354.AmtSizeQty18) & ", " 
    SQL = SQL & "    K1354_AmtSizeQty19      =  " & FormatSQL(z1354.AmtSizeQty19) & ", " 
    SQL = SQL & "    K1354_AmtSizeQty20      =  " & FormatSQL(z1354.AmtSizeQty20) & ", " 
    SQL = SQL & "    K1354_AmtSizeQty21      =  " & FormatSQL(z1354.AmtSizeQty21) & ", " 
    SQL = SQL & "    K1354_AmtSizeQty22      =  " & FormatSQL(z1354.AmtSizeQty22) & ", " 
    SQL = SQL & "    K1354_AmtSizeQty23      =  " & FormatSQL(z1354.AmtSizeQty23) & ", " 
    SQL = SQL & "    K1354_AmtSizeQty24      =  " & FormatSQL(z1354.AmtSizeQty24) & ", " 
    SQL = SQL & "    K1354_AmtSizeQty25      =  " & FormatSQL(z1354.AmtSizeQty25) & ", " 
    SQL = SQL & "    K1354_AmtSizeQty26      =  " & FormatSQL(z1354.AmtSizeQty26) & ", " 
    SQL = SQL & "    K1354_AmtSizeQty27      =  " & FormatSQL(z1354.AmtSizeQty27) & ", " 
    SQL = SQL & "    K1354_AmtSizeQty28      =  " & FormatSQL(z1354.AmtSizeQty28) & ", " 
    SQL = SQL & "    K1354_AmtSizeQty29      =  " & FormatSQL(z1354.AmtSizeQty29) & ", " 
    SQL = SQL & "    K1354_AmtSizeQty30      =  " & FormatSQL(z1354.AmtSizeQty30) & ", " 
    SQL = SQL & "    K1354_Remark      = N'" & FormatSQL(z1354.Remark) & "'  " 
    SQL = SQL & " WHERE K1354_OrderNo		 = '" & z1354.OrderNo & "' " 
    SQL = SQL & "   AND K1354_OrderNoSeq		 = '" & z1354.OrderNoSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK1354 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK1354",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK1354(z1354 As T1354_AREA) As Boolean
    DELETE_PFK1354 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK1354 "
    SQL = SQL & " WHERE K1354_OrderNo		 = '" & z1354.OrderNo & "' " 
    SQL = SQL & "   AND K1354_OrderNoSeq		 = '" & z1354.OrderNoSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK1354 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK1354",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D1354_CLEAR()
Try
    
   D1354.OrderNo = ""
   D1354.OrderNoSeq = ""
   D1354.CheckS01 = ""
   D1354.CheckS02 = ""
   D1354.CheckS03 = ""
   D1354.CheckS04 = ""
   D1354.CheckS05 = ""
   D1354.CheckS06 = ""
   D1354.CheckS07 = ""
   D1354.CheckS08 = ""
   D1354.CheckS09 = ""
   D1354.CheckS10 = ""
   D1354.CheckS11 = ""
   D1354.CheckS12 = ""
   D1354.CheckS13 = ""
   D1354.CheckS14 = ""
   D1354.CheckS15 = ""
   D1354.CheckS16 = ""
   D1354.CheckS17 = ""
   D1354.CheckS18 = ""
   D1354.CheckS19 = ""
   D1354.CheckS20 = ""
   D1354.CheckS21 = ""
   D1354.CheckS22 = ""
   D1354.CheckS23 = ""
   D1354.CheckS24 = ""
   D1354.CheckS25 = ""
   D1354.CheckS26 = ""
   D1354.CheckS27 = ""
   D1354.CheckS28 = ""
   D1354.CheckS29 = ""
   D1354.CheckS30 = ""
    D1354.PSizeQty01 = 0 
    D1354.PSizeQty02 = 0 
    D1354.PSizeQty03 = 0 
    D1354.PSizeQty04 = 0 
    D1354.PSizeQty05 = 0 
    D1354.PSizeQty06 = 0 
    D1354.PSizeQty07 = 0 
    D1354.PSizeQty08 = 0 
    D1354.PSizeQty09 = 0 
    D1354.PSizeQty10 = 0 
    D1354.PSizeQty11 = 0 
    D1354.PSizeQty12 = 0 
    D1354.PSizeQty13 = 0 
    D1354.PSizeQty14 = 0 
    D1354.PSizeQty15 = 0 
    D1354.PSizeQty16 = 0 
    D1354.PSizeQty17 = 0 
    D1354.PSizeQty18 = 0 
    D1354.PSizeQty19 = 0 
    D1354.PSizeQty20 = 0 
    D1354.PSizeQty21 = 0 
    D1354.PSizeQty22 = 0 
    D1354.PSizeQty23 = 0 
    D1354.PSizeQty24 = 0 
    D1354.PSizeQty25 = 0 
    D1354.PSizeQty26 = 0 
    D1354.PSizeQty27 = 0 
    D1354.PSizeQty28 = 0 
    D1354.PSizeQty29 = 0 
    D1354.PSizeQty30 = 0 
    D1354.AmtSizeQty01 = 0 
    D1354.AmtSizeQty02 = 0 
    D1354.AmtSizeQty03 = 0 
    D1354.AmtSizeQty04 = 0 
    D1354.AmtSizeQty05 = 0 
    D1354.AmtSizeQty06 = 0 
    D1354.AmtSizeQty07 = 0 
    D1354.AmtSizeQty08 = 0 
    D1354.AmtSizeQty09 = 0 
    D1354.AmtSizeQty10 = 0 
    D1354.AmtSizeQty11 = 0 
    D1354.AmtSizeQty12 = 0 
    D1354.AmtSizeQty13 = 0 
    D1354.AmtSizeQty14 = 0 
    D1354.AmtSizeQty15 = 0 
    D1354.AmtSizeQty16 = 0 
    D1354.AmtSizeQty17 = 0 
    D1354.AmtSizeQty18 = 0 
    D1354.AmtSizeQty19 = 0 
    D1354.AmtSizeQty20 = 0 
    D1354.AmtSizeQty21 = 0 
    D1354.AmtSizeQty22 = 0 
    D1354.AmtSizeQty23 = 0 
    D1354.AmtSizeQty24 = 0 
    D1354.AmtSizeQty25 = 0 
    D1354.AmtSizeQty26 = 0 
    D1354.AmtSizeQty27 = 0 
    D1354.AmtSizeQty28 = 0 
    D1354.AmtSizeQty29 = 0 
    D1354.AmtSizeQty30 = 0 
   D1354.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D1354_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x1354 As T1354_AREA)
Try
    
    x1354.OrderNo = trim$(  x1354.OrderNo)
    x1354.OrderNoSeq = trim$(  x1354.OrderNoSeq)
    x1354.CheckS01 = trim$(  x1354.CheckS01)
    x1354.CheckS02 = trim$(  x1354.CheckS02)
    x1354.CheckS03 = trim$(  x1354.CheckS03)
    x1354.CheckS04 = trim$(  x1354.CheckS04)
    x1354.CheckS05 = trim$(  x1354.CheckS05)
    x1354.CheckS06 = trim$(  x1354.CheckS06)
    x1354.CheckS07 = trim$(  x1354.CheckS07)
    x1354.CheckS08 = trim$(  x1354.CheckS08)
    x1354.CheckS09 = trim$(  x1354.CheckS09)
    x1354.CheckS10 = trim$(  x1354.CheckS10)
    x1354.CheckS11 = trim$(  x1354.CheckS11)
    x1354.CheckS12 = trim$(  x1354.CheckS12)
    x1354.CheckS13 = trim$(  x1354.CheckS13)
    x1354.CheckS14 = trim$(  x1354.CheckS14)
    x1354.CheckS15 = trim$(  x1354.CheckS15)
    x1354.CheckS16 = trim$(  x1354.CheckS16)
    x1354.CheckS17 = trim$(  x1354.CheckS17)
    x1354.CheckS18 = trim$(  x1354.CheckS18)
    x1354.CheckS19 = trim$(  x1354.CheckS19)
    x1354.CheckS20 = trim$(  x1354.CheckS20)
    x1354.CheckS21 = trim$(  x1354.CheckS21)
    x1354.CheckS22 = trim$(  x1354.CheckS22)
    x1354.CheckS23 = trim$(  x1354.CheckS23)
    x1354.CheckS24 = trim$(  x1354.CheckS24)
    x1354.CheckS25 = trim$(  x1354.CheckS25)
    x1354.CheckS26 = trim$(  x1354.CheckS26)
    x1354.CheckS27 = trim$(  x1354.CheckS27)
    x1354.CheckS28 = trim$(  x1354.CheckS28)
    x1354.CheckS29 = trim$(  x1354.CheckS29)
    x1354.CheckS30 = trim$(  x1354.CheckS30)
    x1354.PSizeQty01 = trim$(  x1354.PSizeQty01)
    x1354.PSizeQty02 = trim$(  x1354.PSizeQty02)
    x1354.PSizeQty03 = trim$(  x1354.PSizeQty03)
    x1354.PSizeQty04 = trim$(  x1354.PSizeQty04)
    x1354.PSizeQty05 = trim$(  x1354.PSizeQty05)
    x1354.PSizeQty06 = trim$(  x1354.PSizeQty06)
    x1354.PSizeQty07 = trim$(  x1354.PSizeQty07)
    x1354.PSizeQty08 = trim$(  x1354.PSizeQty08)
    x1354.PSizeQty09 = trim$(  x1354.PSizeQty09)
    x1354.PSizeQty10 = trim$(  x1354.PSizeQty10)
    x1354.PSizeQty11 = trim$(  x1354.PSizeQty11)
    x1354.PSizeQty12 = trim$(  x1354.PSizeQty12)
    x1354.PSizeQty13 = trim$(  x1354.PSizeQty13)
    x1354.PSizeQty14 = trim$(  x1354.PSizeQty14)
    x1354.PSizeQty15 = trim$(  x1354.PSizeQty15)
    x1354.PSizeQty16 = trim$(  x1354.PSizeQty16)
    x1354.PSizeQty17 = trim$(  x1354.PSizeQty17)
    x1354.PSizeQty18 = trim$(  x1354.PSizeQty18)
    x1354.PSizeQty19 = trim$(  x1354.PSizeQty19)
    x1354.PSizeQty20 = trim$(  x1354.PSizeQty20)
    x1354.PSizeQty21 = trim$(  x1354.PSizeQty21)
    x1354.PSizeQty22 = trim$(  x1354.PSizeQty22)
    x1354.PSizeQty23 = trim$(  x1354.PSizeQty23)
    x1354.PSizeQty24 = trim$(  x1354.PSizeQty24)
    x1354.PSizeQty25 = trim$(  x1354.PSizeQty25)
    x1354.PSizeQty26 = trim$(  x1354.PSizeQty26)
    x1354.PSizeQty27 = trim$(  x1354.PSizeQty27)
    x1354.PSizeQty28 = trim$(  x1354.PSizeQty28)
    x1354.PSizeQty29 = trim$(  x1354.PSizeQty29)
    x1354.PSizeQty30 = trim$(  x1354.PSizeQty30)
    x1354.AmtSizeQty01 = trim$(  x1354.AmtSizeQty01)
    x1354.AmtSizeQty02 = trim$(  x1354.AmtSizeQty02)
    x1354.AmtSizeQty03 = trim$(  x1354.AmtSizeQty03)
    x1354.AmtSizeQty04 = trim$(  x1354.AmtSizeQty04)
    x1354.AmtSizeQty05 = trim$(  x1354.AmtSizeQty05)
    x1354.AmtSizeQty06 = trim$(  x1354.AmtSizeQty06)
    x1354.AmtSizeQty07 = trim$(  x1354.AmtSizeQty07)
    x1354.AmtSizeQty08 = trim$(  x1354.AmtSizeQty08)
    x1354.AmtSizeQty09 = trim$(  x1354.AmtSizeQty09)
    x1354.AmtSizeQty10 = trim$(  x1354.AmtSizeQty10)
    x1354.AmtSizeQty11 = trim$(  x1354.AmtSizeQty11)
    x1354.AmtSizeQty12 = trim$(  x1354.AmtSizeQty12)
    x1354.AmtSizeQty13 = trim$(  x1354.AmtSizeQty13)
    x1354.AmtSizeQty14 = trim$(  x1354.AmtSizeQty14)
    x1354.AmtSizeQty15 = trim$(  x1354.AmtSizeQty15)
    x1354.AmtSizeQty16 = trim$(  x1354.AmtSizeQty16)
    x1354.AmtSizeQty17 = trim$(  x1354.AmtSizeQty17)
    x1354.AmtSizeQty18 = trim$(  x1354.AmtSizeQty18)
    x1354.AmtSizeQty19 = trim$(  x1354.AmtSizeQty19)
    x1354.AmtSizeQty20 = trim$(  x1354.AmtSizeQty20)
    x1354.AmtSizeQty21 = trim$(  x1354.AmtSizeQty21)
    x1354.AmtSizeQty22 = trim$(  x1354.AmtSizeQty22)
    x1354.AmtSizeQty23 = trim$(  x1354.AmtSizeQty23)
    x1354.AmtSizeQty24 = trim$(  x1354.AmtSizeQty24)
    x1354.AmtSizeQty25 = trim$(  x1354.AmtSizeQty25)
    x1354.AmtSizeQty26 = trim$(  x1354.AmtSizeQty26)
    x1354.AmtSizeQty27 = trim$(  x1354.AmtSizeQty27)
    x1354.AmtSizeQty28 = trim$(  x1354.AmtSizeQty28)
    x1354.AmtSizeQty29 = trim$(  x1354.AmtSizeQty29)
    x1354.AmtSizeQty30 = trim$(  x1354.AmtSizeQty30)
    x1354.Remark = trim$(  x1354.Remark)
     
    If trim$( x1354.OrderNo ) = "" Then x1354.OrderNo = Space(1) 
    If trim$( x1354.OrderNoSeq ) = "" Then x1354.OrderNoSeq = Space(1) 
    If trim$( x1354.CheckS01 ) = "" Then x1354.CheckS01 = Space(1) 
    If trim$( x1354.CheckS02 ) = "" Then x1354.CheckS02 = Space(1) 
    If trim$( x1354.CheckS03 ) = "" Then x1354.CheckS03 = Space(1) 
    If trim$( x1354.CheckS04 ) = "" Then x1354.CheckS04 = Space(1) 
    If trim$( x1354.CheckS05 ) = "" Then x1354.CheckS05 = Space(1) 
    If trim$( x1354.CheckS06 ) = "" Then x1354.CheckS06 = Space(1) 
    If trim$( x1354.CheckS07 ) = "" Then x1354.CheckS07 = Space(1) 
    If trim$( x1354.CheckS08 ) = "" Then x1354.CheckS08 = Space(1) 
    If trim$( x1354.CheckS09 ) = "" Then x1354.CheckS09 = Space(1) 
    If trim$( x1354.CheckS10 ) = "" Then x1354.CheckS10 = Space(1) 
    If trim$( x1354.CheckS11 ) = "" Then x1354.CheckS11 = Space(1) 
    If trim$( x1354.CheckS12 ) = "" Then x1354.CheckS12 = Space(1) 
    If trim$( x1354.CheckS13 ) = "" Then x1354.CheckS13 = Space(1) 
    If trim$( x1354.CheckS14 ) = "" Then x1354.CheckS14 = Space(1) 
    If trim$( x1354.CheckS15 ) = "" Then x1354.CheckS15 = Space(1) 
    If trim$( x1354.CheckS16 ) = "" Then x1354.CheckS16 = Space(1) 
    If trim$( x1354.CheckS17 ) = "" Then x1354.CheckS17 = Space(1) 
    If trim$( x1354.CheckS18 ) = "" Then x1354.CheckS18 = Space(1) 
    If trim$( x1354.CheckS19 ) = "" Then x1354.CheckS19 = Space(1) 
    If trim$( x1354.CheckS20 ) = "" Then x1354.CheckS20 = Space(1) 
    If trim$( x1354.CheckS21 ) = "" Then x1354.CheckS21 = Space(1) 
    If trim$( x1354.CheckS22 ) = "" Then x1354.CheckS22 = Space(1) 
    If trim$( x1354.CheckS23 ) = "" Then x1354.CheckS23 = Space(1) 
    If trim$( x1354.CheckS24 ) = "" Then x1354.CheckS24 = Space(1) 
    If trim$( x1354.CheckS25 ) = "" Then x1354.CheckS25 = Space(1) 
    If trim$( x1354.CheckS26 ) = "" Then x1354.CheckS26 = Space(1) 
    If trim$( x1354.CheckS27 ) = "" Then x1354.CheckS27 = Space(1) 
    If trim$( x1354.CheckS28 ) = "" Then x1354.CheckS28 = Space(1) 
    If trim$( x1354.CheckS29 ) = "" Then x1354.CheckS29 = Space(1) 
    If trim$( x1354.CheckS30 ) = "" Then x1354.CheckS30 = Space(1) 
    If trim$( x1354.PSizeQty01 ) = "" Then x1354.PSizeQty01 = 0 
    If trim$( x1354.PSizeQty02 ) = "" Then x1354.PSizeQty02 = 0 
    If trim$( x1354.PSizeQty03 ) = "" Then x1354.PSizeQty03 = 0 
    If trim$( x1354.PSizeQty04 ) = "" Then x1354.PSizeQty04 = 0 
    If trim$( x1354.PSizeQty05 ) = "" Then x1354.PSizeQty05 = 0 
    If trim$( x1354.PSizeQty06 ) = "" Then x1354.PSizeQty06 = 0 
    If trim$( x1354.PSizeQty07 ) = "" Then x1354.PSizeQty07 = 0 
    If trim$( x1354.PSizeQty08 ) = "" Then x1354.PSizeQty08 = 0 
    If trim$( x1354.PSizeQty09 ) = "" Then x1354.PSizeQty09 = 0 
    If trim$( x1354.PSizeQty10 ) = "" Then x1354.PSizeQty10 = 0 
    If trim$( x1354.PSizeQty11 ) = "" Then x1354.PSizeQty11 = 0 
    If trim$( x1354.PSizeQty12 ) = "" Then x1354.PSizeQty12 = 0 
    If trim$( x1354.PSizeQty13 ) = "" Then x1354.PSizeQty13 = 0 
    If trim$( x1354.PSizeQty14 ) = "" Then x1354.PSizeQty14 = 0 
    If trim$( x1354.PSizeQty15 ) = "" Then x1354.PSizeQty15 = 0 
    If trim$( x1354.PSizeQty16 ) = "" Then x1354.PSizeQty16 = 0 
    If trim$( x1354.PSizeQty17 ) = "" Then x1354.PSizeQty17 = 0 
    If trim$( x1354.PSizeQty18 ) = "" Then x1354.PSizeQty18 = 0 
    If trim$( x1354.PSizeQty19 ) = "" Then x1354.PSizeQty19 = 0 
    If trim$( x1354.PSizeQty20 ) = "" Then x1354.PSizeQty20 = 0 
    If trim$( x1354.PSizeQty21 ) = "" Then x1354.PSizeQty21 = 0 
    If trim$( x1354.PSizeQty22 ) = "" Then x1354.PSizeQty22 = 0 
    If trim$( x1354.PSizeQty23 ) = "" Then x1354.PSizeQty23 = 0 
    If trim$( x1354.PSizeQty24 ) = "" Then x1354.PSizeQty24 = 0 
    If trim$( x1354.PSizeQty25 ) = "" Then x1354.PSizeQty25 = 0 
    If trim$( x1354.PSizeQty26 ) = "" Then x1354.PSizeQty26 = 0 
    If trim$( x1354.PSizeQty27 ) = "" Then x1354.PSizeQty27 = 0 
    If trim$( x1354.PSizeQty28 ) = "" Then x1354.PSizeQty28 = 0 
    If trim$( x1354.PSizeQty29 ) = "" Then x1354.PSizeQty29 = 0 
    If trim$( x1354.PSizeQty30 ) = "" Then x1354.PSizeQty30 = 0 
    If trim$( x1354.AmtSizeQty01 ) = "" Then x1354.AmtSizeQty01 = 0 
    If trim$( x1354.AmtSizeQty02 ) = "" Then x1354.AmtSizeQty02 = 0 
    If trim$( x1354.AmtSizeQty03 ) = "" Then x1354.AmtSizeQty03 = 0 
    If trim$( x1354.AmtSizeQty04 ) = "" Then x1354.AmtSizeQty04 = 0 
    If trim$( x1354.AmtSizeQty05 ) = "" Then x1354.AmtSizeQty05 = 0 
    If trim$( x1354.AmtSizeQty06 ) = "" Then x1354.AmtSizeQty06 = 0 
    If trim$( x1354.AmtSizeQty07 ) = "" Then x1354.AmtSizeQty07 = 0 
    If trim$( x1354.AmtSizeQty08 ) = "" Then x1354.AmtSizeQty08 = 0 
    If trim$( x1354.AmtSizeQty09 ) = "" Then x1354.AmtSizeQty09 = 0 
    If trim$( x1354.AmtSizeQty10 ) = "" Then x1354.AmtSizeQty10 = 0 
    If trim$( x1354.AmtSizeQty11 ) = "" Then x1354.AmtSizeQty11 = 0 
    If trim$( x1354.AmtSizeQty12 ) = "" Then x1354.AmtSizeQty12 = 0 
    If trim$( x1354.AmtSizeQty13 ) = "" Then x1354.AmtSizeQty13 = 0 
    If trim$( x1354.AmtSizeQty14 ) = "" Then x1354.AmtSizeQty14 = 0 
    If trim$( x1354.AmtSizeQty15 ) = "" Then x1354.AmtSizeQty15 = 0 
    If trim$( x1354.AmtSizeQty16 ) = "" Then x1354.AmtSizeQty16 = 0 
    If trim$( x1354.AmtSizeQty17 ) = "" Then x1354.AmtSizeQty17 = 0 
    If trim$( x1354.AmtSizeQty18 ) = "" Then x1354.AmtSizeQty18 = 0 
    If trim$( x1354.AmtSizeQty19 ) = "" Then x1354.AmtSizeQty19 = 0 
    If trim$( x1354.AmtSizeQty20 ) = "" Then x1354.AmtSizeQty20 = 0 
    If trim$( x1354.AmtSizeQty21 ) = "" Then x1354.AmtSizeQty21 = 0 
    If trim$( x1354.AmtSizeQty22 ) = "" Then x1354.AmtSizeQty22 = 0 
    If trim$( x1354.AmtSizeQty23 ) = "" Then x1354.AmtSizeQty23 = 0 
    If trim$( x1354.AmtSizeQty24 ) = "" Then x1354.AmtSizeQty24 = 0 
    If trim$( x1354.AmtSizeQty25 ) = "" Then x1354.AmtSizeQty25 = 0 
    If trim$( x1354.AmtSizeQty26 ) = "" Then x1354.AmtSizeQty26 = 0 
    If trim$( x1354.AmtSizeQty27 ) = "" Then x1354.AmtSizeQty27 = 0 
    If trim$( x1354.AmtSizeQty28 ) = "" Then x1354.AmtSizeQty28 = 0 
    If trim$( x1354.AmtSizeQty29 ) = "" Then x1354.AmtSizeQty29 = 0 
    If trim$( x1354.AmtSizeQty30 ) = "" Then x1354.AmtSizeQty30 = 0 
    If trim$( x1354.Remark ) = "" Then x1354.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K1354_MOVE(rs1354 As SqlClient.SqlDataReader)
Try

    call D1354_CLEAR()   

    If IsdbNull(rs1354!K1354_OrderNo) = False Then D1354.OrderNo = Trim$(rs1354!K1354_OrderNo)
    If IsdbNull(rs1354!K1354_OrderNoSeq) = False Then D1354.OrderNoSeq = Trim$(rs1354!K1354_OrderNoSeq)
    If IsdbNull(rs1354!K1354_CheckS01) = False Then D1354.CheckS01 = Trim$(rs1354!K1354_CheckS01)
    If IsdbNull(rs1354!K1354_CheckS02) = False Then D1354.CheckS02 = Trim$(rs1354!K1354_CheckS02)
    If IsdbNull(rs1354!K1354_CheckS03) = False Then D1354.CheckS03 = Trim$(rs1354!K1354_CheckS03)
    If IsdbNull(rs1354!K1354_CheckS04) = False Then D1354.CheckS04 = Trim$(rs1354!K1354_CheckS04)
    If IsdbNull(rs1354!K1354_CheckS05) = False Then D1354.CheckS05 = Trim$(rs1354!K1354_CheckS05)
    If IsdbNull(rs1354!K1354_CheckS06) = False Then D1354.CheckS06 = Trim$(rs1354!K1354_CheckS06)
    If IsdbNull(rs1354!K1354_CheckS07) = False Then D1354.CheckS07 = Trim$(rs1354!K1354_CheckS07)
    If IsdbNull(rs1354!K1354_CheckS08) = False Then D1354.CheckS08 = Trim$(rs1354!K1354_CheckS08)
    If IsdbNull(rs1354!K1354_CheckS09) = False Then D1354.CheckS09 = Trim$(rs1354!K1354_CheckS09)
    If IsdbNull(rs1354!K1354_CheckS10) = False Then D1354.CheckS10 = Trim$(rs1354!K1354_CheckS10)
    If IsdbNull(rs1354!K1354_CheckS11) = False Then D1354.CheckS11 = Trim$(rs1354!K1354_CheckS11)
    If IsdbNull(rs1354!K1354_CheckS12) = False Then D1354.CheckS12 = Trim$(rs1354!K1354_CheckS12)
    If IsdbNull(rs1354!K1354_CheckS13) = False Then D1354.CheckS13 = Trim$(rs1354!K1354_CheckS13)
    If IsdbNull(rs1354!K1354_CheckS14) = False Then D1354.CheckS14 = Trim$(rs1354!K1354_CheckS14)
    If IsdbNull(rs1354!K1354_CheckS15) = False Then D1354.CheckS15 = Trim$(rs1354!K1354_CheckS15)
    If IsdbNull(rs1354!K1354_CheckS16) = False Then D1354.CheckS16 = Trim$(rs1354!K1354_CheckS16)
    If IsdbNull(rs1354!K1354_CheckS17) = False Then D1354.CheckS17 = Trim$(rs1354!K1354_CheckS17)
    If IsdbNull(rs1354!K1354_CheckS18) = False Then D1354.CheckS18 = Trim$(rs1354!K1354_CheckS18)
    If IsdbNull(rs1354!K1354_CheckS19) = False Then D1354.CheckS19 = Trim$(rs1354!K1354_CheckS19)
    If IsdbNull(rs1354!K1354_CheckS20) = False Then D1354.CheckS20 = Trim$(rs1354!K1354_CheckS20)
    If IsdbNull(rs1354!K1354_CheckS21) = False Then D1354.CheckS21 = Trim$(rs1354!K1354_CheckS21)
    If IsdbNull(rs1354!K1354_CheckS22) = False Then D1354.CheckS22 = Trim$(rs1354!K1354_CheckS22)
    If IsdbNull(rs1354!K1354_CheckS23) = False Then D1354.CheckS23 = Trim$(rs1354!K1354_CheckS23)
    If IsdbNull(rs1354!K1354_CheckS24) = False Then D1354.CheckS24 = Trim$(rs1354!K1354_CheckS24)
    If IsdbNull(rs1354!K1354_CheckS25) = False Then D1354.CheckS25 = Trim$(rs1354!K1354_CheckS25)
    If IsdbNull(rs1354!K1354_CheckS26) = False Then D1354.CheckS26 = Trim$(rs1354!K1354_CheckS26)
    If IsdbNull(rs1354!K1354_CheckS27) = False Then D1354.CheckS27 = Trim$(rs1354!K1354_CheckS27)
    If IsdbNull(rs1354!K1354_CheckS28) = False Then D1354.CheckS28 = Trim$(rs1354!K1354_CheckS28)
    If IsdbNull(rs1354!K1354_CheckS29) = False Then D1354.CheckS29 = Trim$(rs1354!K1354_CheckS29)
    If IsdbNull(rs1354!K1354_CheckS30) = False Then D1354.CheckS30 = Trim$(rs1354!K1354_CheckS30)
    If IsdbNull(rs1354!K1354_PSizeQty01) = False Then D1354.PSizeQty01 = Trim$(rs1354!K1354_PSizeQty01)
    If IsdbNull(rs1354!K1354_PSizeQty02) = False Then D1354.PSizeQty02 = Trim$(rs1354!K1354_PSizeQty02)
    If IsdbNull(rs1354!K1354_PSizeQty03) = False Then D1354.PSizeQty03 = Trim$(rs1354!K1354_PSizeQty03)
    If IsdbNull(rs1354!K1354_PSizeQty04) = False Then D1354.PSizeQty04 = Trim$(rs1354!K1354_PSizeQty04)
    If IsdbNull(rs1354!K1354_PSizeQty05) = False Then D1354.PSizeQty05 = Trim$(rs1354!K1354_PSizeQty05)
    If IsdbNull(rs1354!K1354_PSizeQty06) = False Then D1354.PSizeQty06 = Trim$(rs1354!K1354_PSizeQty06)
    If IsdbNull(rs1354!K1354_PSizeQty07) = False Then D1354.PSizeQty07 = Trim$(rs1354!K1354_PSizeQty07)
    If IsdbNull(rs1354!K1354_PSizeQty08) = False Then D1354.PSizeQty08 = Trim$(rs1354!K1354_PSizeQty08)
    If IsdbNull(rs1354!K1354_PSizeQty09) = False Then D1354.PSizeQty09 = Trim$(rs1354!K1354_PSizeQty09)
    If IsdbNull(rs1354!K1354_PSizeQty10) = False Then D1354.PSizeQty10 = Trim$(rs1354!K1354_PSizeQty10)
    If IsdbNull(rs1354!K1354_PSizeQty11) = False Then D1354.PSizeQty11 = Trim$(rs1354!K1354_PSizeQty11)
    If IsdbNull(rs1354!K1354_PSizeQty12) = False Then D1354.PSizeQty12 = Trim$(rs1354!K1354_PSizeQty12)
    If IsdbNull(rs1354!K1354_PSizeQty13) = False Then D1354.PSizeQty13 = Trim$(rs1354!K1354_PSizeQty13)
    If IsdbNull(rs1354!K1354_PSizeQty14) = False Then D1354.PSizeQty14 = Trim$(rs1354!K1354_PSizeQty14)
    If IsdbNull(rs1354!K1354_PSizeQty15) = False Then D1354.PSizeQty15 = Trim$(rs1354!K1354_PSizeQty15)
    If IsdbNull(rs1354!K1354_PSizeQty16) = False Then D1354.PSizeQty16 = Trim$(rs1354!K1354_PSizeQty16)
    If IsdbNull(rs1354!K1354_PSizeQty17) = False Then D1354.PSizeQty17 = Trim$(rs1354!K1354_PSizeQty17)
    If IsdbNull(rs1354!K1354_PSizeQty18) = False Then D1354.PSizeQty18 = Trim$(rs1354!K1354_PSizeQty18)
    If IsdbNull(rs1354!K1354_PSizeQty19) = False Then D1354.PSizeQty19 = Trim$(rs1354!K1354_PSizeQty19)
    If IsdbNull(rs1354!K1354_PSizeQty20) = False Then D1354.PSizeQty20 = Trim$(rs1354!K1354_PSizeQty20)
    If IsdbNull(rs1354!K1354_PSizeQty21) = False Then D1354.PSizeQty21 = Trim$(rs1354!K1354_PSizeQty21)
    If IsdbNull(rs1354!K1354_PSizeQty22) = False Then D1354.PSizeQty22 = Trim$(rs1354!K1354_PSizeQty22)
    If IsdbNull(rs1354!K1354_PSizeQty23) = False Then D1354.PSizeQty23 = Trim$(rs1354!K1354_PSizeQty23)
    If IsdbNull(rs1354!K1354_PSizeQty24) = False Then D1354.PSizeQty24 = Trim$(rs1354!K1354_PSizeQty24)
    If IsdbNull(rs1354!K1354_PSizeQty25) = False Then D1354.PSizeQty25 = Trim$(rs1354!K1354_PSizeQty25)
    If IsdbNull(rs1354!K1354_PSizeQty26) = False Then D1354.PSizeQty26 = Trim$(rs1354!K1354_PSizeQty26)
    If IsdbNull(rs1354!K1354_PSizeQty27) = False Then D1354.PSizeQty27 = Trim$(rs1354!K1354_PSizeQty27)
    If IsdbNull(rs1354!K1354_PSizeQty28) = False Then D1354.PSizeQty28 = Trim$(rs1354!K1354_PSizeQty28)
    If IsdbNull(rs1354!K1354_PSizeQty29) = False Then D1354.PSizeQty29 = Trim$(rs1354!K1354_PSizeQty29)
    If IsdbNull(rs1354!K1354_PSizeQty30) = False Then D1354.PSizeQty30 = Trim$(rs1354!K1354_PSizeQty30)
    If IsdbNull(rs1354!K1354_AmtSizeQty01) = False Then D1354.AmtSizeQty01 = Trim$(rs1354!K1354_AmtSizeQty01)
    If IsdbNull(rs1354!K1354_AmtSizeQty02) = False Then D1354.AmtSizeQty02 = Trim$(rs1354!K1354_AmtSizeQty02)
    If IsdbNull(rs1354!K1354_AmtSizeQty03) = False Then D1354.AmtSizeQty03 = Trim$(rs1354!K1354_AmtSizeQty03)
    If IsdbNull(rs1354!K1354_AmtSizeQty04) = False Then D1354.AmtSizeQty04 = Trim$(rs1354!K1354_AmtSizeQty04)
    If IsdbNull(rs1354!K1354_AmtSizeQty05) = False Then D1354.AmtSizeQty05 = Trim$(rs1354!K1354_AmtSizeQty05)
    If IsdbNull(rs1354!K1354_AmtSizeQty06) = False Then D1354.AmtSizeQty06 = Trim$(rs1354!K1354_AmtSizeQty06)
    If IsdbNull(rs1354!K1354_AmtSizeQty07) = False Then D1354.AmtSizeQty07 = Trim$(rs1354!K1354_AmtSizeQty07)
    If IsdbNull(rs1354!K1354_AmtSizeQty08) = False Then D1354.AmtSizeQty08 = Trim$(rs1354!K1354_AmtSizeQty08)
    If IsdbNull(rs1354!K1354_AmtSizeQty09) = False Then D1354.AmtSizeQty09 = Trim$(rs1354!K1354_AmtSizeQty09)
    If IsdbNull(rs1354!K1354_AmtSizeQty10) = False Then D1354.AmtSizeQty10 = Trim$(rs1354!K1354_AmtSizeQty10)
    If IsdbNull(rs1354!K1354_AmtSizeQty11) = False Then D1354.AmtSizeQty11 = Trim$(rs1354!K1354_AmtSizeQty11)
    If IsdbNull(rs1354!K1354_AmtSizeQty12) = False Then D1354.AmtSizeQty12 = Trim$(rs1354!K1354_AmtSizeQty12)
    If IsdbNull(rs1354!K1354_AmtSizeQty13) = False Then D1354.AmtSizeQty13 = Trim$(rs1354!K1354_AmtSizeQty13)
    If IsdbNull(rs1354!K1354_AmtSizeQty14) = False Then D1354.AmtSizeQty14 = Trim$(rs1354!K1354_AmtSizeQty14)
    If IsdbNull(rs1354!K1354_AmtSizeQty15) = False Then D1354.AmtSizeQty15 = Trim$(rs1354!K1354_AmtSizeQty15)
    If IsdbNull(rs1354!K1354_AmtSizeQty16) = False Then D1354.AmtSizeQty16 = Trim$(rs1354!K1354_AmtSizeQty16)
    If IsdbNull(rs1354!K1354_AmtSizeQty17) = False Then D1354.AmtSizeQty17 = Trim$(rs1354!K1354_AmtSizeQty17)
    If IsdbNull(rs1354!K1354_AmtSizeQty18) = False Then D1354.AmtSizeQty18 = Trim$(rs1354!K1354_AmtSizeQty18)
    If IsdbNull(rs1354!K1354_AmtSizeQty19) = False Then D1354.AmtSizeQty19 = Trim$(rs1354!K1354_AmtSizeQty19)
    If IsdbNull(rs1354!K1354_AmtSizeQty20) = False Then D1354.AmtSizeQty20 = Trim$(rs1354!K1354_AmtSizeQty20)
    If IsdbNull(rs1354!K1354_AmtSizeQty21) = False Then D1354.AmtSizeQty21 = Trim$(rs1354!K1354_AmtSizeQty21)
    If IsdbNull(rs1354!K1354_AmtSizeQty22) = False Then D1354.AmtSizeQty22 = Trim$(rs1354!K1354_AmtSizeQty22)
    If IsdbNull(rs1354!K1354_AmtSizeQty23) = False Then D1354.AmtSizeQty23 = Trim$(rs1354!K1354_AmtSizeQty23)
    If IsdbNull(rs1354!K1354_AmtSizeQty24) = False Then D1354.AmtSizeQty24 = Trim$(rs1354!K1354_AmtSizeQty24)
    If IsdbNull(rs1354!K1354_AmtSizeQty25) = False Then D1354.AmtSizeQty25 = Trim$(rs1354!K1354_AmtSizeQty25)
    If IsdbNull(rs1354!K1354_AmtSizeQty26) = False Then D1354.AmtSizeQty26 = Trim$(rs1354!K1354_AmtSizeQty26)
    If IsdbNull(rs1354!K1354_AmtSizeQty27) = False Then D1354.AmtSizeQty27 = Trim$(rs1354!K1354_AmtSizeQty27)
    If IsdbNull(rs1354!K1354_AmtSizeQty28) = False Then D1354.AmtSizeQty28 = Trim$(rs1354!K1354_AmtSizeQty28)
    If IsdbNull(rs1354!K1354_AmtSizeQty29) = False Then D1354.AmtSizeQty29 = Trim$(rs1354!K1354_AmtSizeQty29)
    If IsdbNull(rs1354!K1354_AmtSizeQty30) = False Then D1354.AmtSizeQty30 = Trim$(rs1354!K1354_AmtSizeQty30)
    If IsdbNull(rs1354!K1354_Remark) = False Then D1354.Remark = Trim$(rs1354!K1354_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K1354_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K1354_MOVE(rs1354 As DataRow)
Try

    call D1354_CLEAR()   

    If IsdbNull(rs1354!K1354_OrderNo) = False Then D1354.OrderNo = Trim$(rs1354!K1354_OrderNo)
    If IsdbNull(rs1354!K1354_OrderNoSeq) = False Then D1354.OrderNoSeq = Trim$(rs1354!K1354_OrderNoSeq)
    If IsdbNull(rs1354!K1354_CheckS01) = False Then D1354.CheckS01 = Trim$(rs1354!K1354_CheckS01)
    If IsdbNull(rs1354!K1354_CheckS02) = False Then D1354.CheckS02 = Trim$(rs1354!K1354_CheckS02)
    If IsdbNull(rs1354!K1354_CheckS03) = False Then D1354.CheckS03 = Trim$(rs1354!K1354_CheckS03)
    If IsdbNull(rs1354!K1354_CheckS04) = False Then D1354.CheckS04 = Trim$(rs1354!K1354_CheckS04)
    If IsdbNull(rs1354!K1354_CheckS05) = False Then D1354.CheckS05 = Trim$(rs1354!K1354_CheckS05)
    If IsdbNull(rs1354!K1354_CheckS06) = False Then D1354.CheckS06 = Trim$(rs1354!K1354_CheckS06)
    If IsdbNull(rs1354!K1354_CheckS07) = False Then D1354.CheckS07 = Trim$(rs1354!K1354_CheckS07)
    If IsdbNull(rs1354!K1354_CheckS08) = False Then D1354.CheckS08 = Trim$(rs1354!K1354_CheckS08)
    If IsdbNull(rs1354!K1354_CheckS09) = False Then D1354.CheckS09 = Trim$(rs1354!K1354_CheckS09)
    If IsdbNull(rs1354!K1354_CheckS10) = False Then D1354.CheckS10 = Trim$(rs1354!K1354_CheckS10)
    If IsdbNull(rs1354!K1354_CheckS11) = False Then D1354.CheckS11 = Trim$(rs1354!K1354_CheckS11)
    If IsdbNull(rs1354!K1354_CheckS12) = False Then D1354.CheckS12 = Trim$(rs1354!K1354_CheckS12)
    If IsdbNull(rs1354!K1354_CheckS13) = False Then D1354.CheckS13 = Trim$(rs1354!K1354_CheckS13)
    If IsdbNull(rs1354!K1354_CheckS14) = False Then D1354.CheckS14 = Trim$(rs1354!K1354_CheckS14)
    If IsdbNull(rs1354!K1354_CheckS15) = False Then D1354.CheckS15 = Trim$(rs1354!K1354_CheckS15)
    If IsdbNull(rs1354!K1354_CheckS16) = False Then D1354.CheckS16 = Trim$(rs1354!K1354_CheckS16)
    If IsdbNull(rs1354!K1354_CheckS17) = False Then D1354.CheckS17 = Trim$(rs1354!K1354_CheckS17)
    If IsdbNull(rs1354!K1354_CheckS18) = False Then D1354.CheckS18 = Trim$(rs1354!K1354_CheckS18)
    If IsdbNull(rs1354!K1354_CheckS19) = False Then D1354.CheckS19 = Trim$(rs1354!K1354_CheckS19)
    If IsdbNull(rs1354!K1354_CheckS20) = False Then D1354.CheckS20 = Trim$(rs1354!K1354_CheckS20)
    If IsdbNull(rs1354!K1354_CheckS21) = False Then D1354.CheckS21 = Trim$(rs1354!K1354_CheckS21)
    If IsdbNull(rs1354!K1354_CheckS22) = False Then D1354.CheckS22 = Trim$(rs1354!K1354_CheckS22)
    If IsdbNull(rs1354!K1354_CheckS23) = False Then D1354.CheckS23 = Trim$(rs1354!K1354_CheckS23)
    If IsdbNull(rs1354!K1354_CheckS24) = False Then D1354.CheckS24 = Trim$(rs1354!K1354_CheckS24)
    If IsdbNull(rs1354!K1354_CheckS25) = False Then D1354.CheckS25 = Trim$(rs1354!K1354_CheckS25)
    If IsdbNull(rs1354!K1354_CheckS26) = False Then D1354.CheckS26 = Trim$(rs1354!K1354_CheckS26)
    If IsdbNull(rs1354!K1354_CheckS27) = False Then D1354.CheckS27 = Trim$(rs1354!K1354_CheckS27)
    If IsdbNull(rs1354!K1354_CheckS28) = False Then D1354.CheckS28 = Trim$(rs1354!K1354_CheckS28)
    If IsdbNull(rs1354!K1354_CheckS29) = False Then D1354.CheckS29 = Trim$(rs1354!K1354_CheckS29)
    If IsdbNull(rs1354!K1354_CheckS30) = False Then D1354.CheckS30 = Trim$(rs1354!K1354_CheckS30)
    If IsdbNull(rs1354!K1354_PSizeQty01) = False Then D1354.PSizeQty01 = Trim$(rs1354!K1354_PSizeQty01)
    If IsdbNull(rs1354!K1354_PSizeQty02) = False Then D1354.PSizeQty02 = Trim$(rs1354!K1354_PSizeQty02)
    If IsdbNull(rs1354!K1354_PSizeQty03) = False Then D1354.PSizeQty03 = Trim$(rs1354!K1354_PSizeQty03)
    If IsdbNull(rs1354!K1354_PSizeQty04) = False Then D1354.PSizeQty04 = Trim$(rs1354!K1354_PSizeQty04)
    If IsdbNull(rs1354!K1354_PSizeQty05) = False Then D1354.PSizeQty05 = Trim$(rs1354!K1354_PSizeQty05)
    If IsdbNull(rs1354!K1354_PSizeQty06) = False Then D1354.PSizeQty06 = Trim$(rs1354!K1354_PSizeQty06)
    If IsdbNull(rs1354!K1354_PSizeQty07) = False Then D1354.PSizeQty07 = Trim$(rs1354!K1354_PSizeQty07)
    If IsdbNull(rs1354!K1354_PSizeQty08) = False Then D1354.PSizeQty08 = Trim$(rs1354!K1354_PSizeQty08)
    If IsdbNull(rs1354!K1354_PSizeQty09) = False Then D1354.PSizeQty09 = Trim$(rs1354!K1354_PSizeQty09)
    If IsdbNull(rs1354!K1354_PSizeQty10) = False Then D1354.PSizeQty10 = Trim$(rs1354!K1354_PSizeQty10)
    If IsdbNull(rs1354!K1354_PSizeQty11) = False Then D1354.PSizeQty11 = Trim$(rs1354!K1354_PSizeQty11)
    If IsdbNull(rs1354!K1354_PSizeQty12) = False Then D1354.PSizeQty12 = Trim$(rs1354!K1354_PSizeQty12)
    If IsdbNull(rs1354!K1354_PSizeQty13) = False Then D1354.PSizeQty13 = Trim$(rs1354!K1354_PSizeQty13)
    If IsdbNull(rs1354!K1354_PSizeQty14) = False Then D1354.PSizeQty14 = Trim$(rs1354!K1354_PSizeQty14)
    If IsdbNull(rs1354!K1354_PSizeQty15) = False Then D1354.PSizeQty15 = Trim$(rs1354!K1354_PSizeQty15)
    If IsdbNull(rs1354!K1354_PSizeQty16) = False Then D1354.PSizeQty16 = Trim$(rs1354!K1354_PSizeQty16)
    If IsdbNull(rs1354!K1354_PSizeQty17) = False Then D1354.PSizeQty17 = Trim$(rs1354!K1354_PSizeQty17)
    If IsdbNull(rs1354!K1354_PSizeQty18) = False Then D1354.PSizeQty18 = Trim$(rs1354!K1354_PSizeQty18)
    If IsdbNull(rs1354!K1354_PSizeQty19) = False Then D1354.PSizeQty19 = Trim$(rs1354!K1354_PSizeQty19)
    If IsdbNull(rs1354!K1354_PSizeQty20) = False Then D1354.PSizeQty20 = Trim$(rs1354!K1354_PSizeQty20)
    If IsdbNull(rs1354!K1354_PSizeQty21) = False Then D1354.PSizeQty21 = Trim$(rs1354!K1354_PSizeQty21)
    If IsdbNull(rs1354!K1354_PSizeQty22) = False Then D1354.PSizeQty22 = Trim$(rs1354!K1354_PSizeQty22)
    If IsdbNull(rs1354!K1354_PSizeQty23) = False Then D1354.PSizeQty23 = Trim$(rs1354!K1354_PSizeQty23)
    If IsdbNull(rs1354!K1354_PSizeQty24) = False Then D1354.PSizeQty24 = Trim$(rs1354!K1354_PSizeQty24)
    If IsdbNull(rs1354!K1354_PSizeQty25) = False Then D1354.PSizeQty25 = Trim$(rs1354!K1354_PSizeQty25)
    If IsdbNull(rs1354!K1354_PSizeQty26) = False Then D1354.PSizeQty26 = Trim$(rs1354!K1354_PSizeQty26)
    If IsdbNull(rs1354!K1354_PSizeQty27) = False Then D1354.PSizeQty27 = Trim$(rs1354!K1354_PSizeQty27)
    If IsdbNull(rs1354!K1354_PSizeQty28) = False Then D1354.PSizeQty28 = Trim$(rs1354!K1354_PSizeQty28)
    If IsdbNull(rs1354!K1354_PSizeQty29) = False Then D1354.PSizeQty29 = Trim$(rs1354!K1354_PSizeQty29)
    If IsdbNull(rs1354!K1354_PSizeQty30) = False Then D1354.PSizeQty30 = Trim$(rs1354!K1354_PSizeQty30)
    If IsdbNull(rs1354!K1354_AmtSizeQty01) = False Then D1354.AmtSizeQty01 = Trim$(rs1354!K1354_AmtSizeQty01)
    If IsdbNull(rs1354!K1354_AmtSizeQty02) = False Then D1354.AmtSizeQty02 = Trim$(rs1354!K1354_AmtSizeQty02)
    If IsdbNull(rs1354!K1354_AmtSizeQty03) = False Then D1354.AmtSizeQty03 = Trim$(rs1354!K1354_AmtSizeQty03)
    If IsdbNull(rs1354!K1354_AmtSizeQty04) = False Then D1354.AmtSizeQty04 = Trim$(rs1354!K1354_AmtSizeQty04)
    If IsdbNull(rs1354!K1354_AmtSizeQty05) = False Then D1354.AmtSizeQty05 = Trim$(rs1354!K1354_AmtSizeQty05)
    If IsdbNull(rs1354!K1354_AmtSizeQty06) = False Then D1354.AmtSizeQty06 = Trim$(rs1354!K1354_AmtSizeQty06)
    If IsdbNull(rs1354!K1354_AmtSizeQty07) = False Then D1354.AmtSizeQty07 = Trim$(rs1354!K1354_AmtSizeQty07)
    If IsdbNull(rs1354!K1354_AmtSizeQty08) = False Then D1354.AmtSizeQty08 = Trim$(rs1354!K1354_AmtSizeQty08)
    If IsdbNull(rs1354!K1354_AmtSizeQty09) = False Then D1354.AmtSizeQty09 = Trim$(rs1354!K1354_AmtSizeQty09)
    If IsdbNull(rs1354!K1354_AmtSizeQty10) = False Then D1354.AmtSizeQty10 = Trim$(rs1354!K1354_AmtSizeQty10)
    If IsdbNull(rs1354!K1354_AmtSizeQty11) = False Then D1354.AmtSizeQty11 = Trim$(rs1354!K1354_AmtSizeQty11)
    If IsdbNull(rs1354!K1354_AmtSizeQty12) = False Then D1354.AmtSizeQty12 = Trim$(rs1354!K1354_AmtSizeQty12)
    If IsdbNull(rs1354!K1354_AmtSizeQty13) = False Then D1354.AmtSizeQty13 = Trim$(rs1354!K1354_AmtSizeQty13)
    If IsdbNull(rs1354!K1354_AmtSizeQty14) = False Then D1354.AmtSizeQty14 = Trim$(rs1354!K1354_AmtSizeQty14)
    If IsdbNull(rs1354!K1354_AmtSizeQty15) = False Then D1354.AmtSizeQty15 = Trim$(rs1354!K1354_AmtSizeQty15)
    If IsdbNull(rs1354!K1354_AmtSizeQty16) = False Then D1354.AmtSizeQty16 = Trim$(rs1354!K1354_AmtSizeQty16)
    If IsdbNull(rs1354!K1354_AmtSizeQty17) = False Then D1354.AmtSizeQty17 = Trim$(rs1354!K1354_AmtSizeQty17)
    If IsdbNull(rs1354!K1354_AmtSizeQty18) = False Then D1354.AmtSizeQty18 = Trim$(rs1354!K1354_AmtSizeQty18)
    If IsdbNull(rs1354!K1354_AmtSizeQty19) = False Then D1354.AmtSizeQty19 = Trim$(rs1354!K1354_AmtSizeQty19)
    If IsdbNull(rs1354!K1354_AmtSizeQty20) = False Then D1354.AmtSizeQty20 = Trim$(rs1354!K1354_AmtSizeQty20)
    If IsdbNull(rs1354!K1354_AmtSizeQty21) = False Then D1354.AmtSizeQty21 = Trim$(rs1354!K1354_AmtSizeQty21)
    If IsdbNull(rs1354!K1354_AmtSizeQty22) = False Then D1354.AmtSizeQty22 = Trim$(rs1354!K1354_AmtSizeQty22)
    If IsdbNull(rs1354!K1354_AmtSizeQty23) = False Then D1354.AmtSizeQty23 = Trim$(rs1354!K1354_AmtSizeQty23)
    If IsdbNull(rs1354!K1354_AmtSizeQty24) = False Then D1354.AmtSizeQty24 = Trim$(rs1354!K1354_AmtSizeQty24)
    If IsdbNull(rs1354!K1354_AmtSizeQty25) = False Then D1354.AmtSizeQty25 = Trim$(rs1354!K1354_AmtSizeQty25)
    If IsdbNull(rs1354!K1354_AmtSizeQty26) = False Then D1354.AmtSizeQty26 = Trim$(rs1354!K1354_AmtSizeQty26)
    If IsdbNull(rs1354!K1354_AmtSizeQty27) = False Then D1354.AmtSizeQty27 = Trim$(rs1354!K1354_AmtSizeQty27)
    If IsdbNull(rs1354!K1354_AmtSizeQty28) = False Then D1354.AmtSizeQty28 = Trim$(rs1354!K1354_AmtSizeQty28)
    If IsdbNull(rs1354!K1354_AmtSizeQty29) = False Then D1354.AmtSizeQty29 = Trim$(rs1354!K1354_AmtSizeQty29)
    If IsdbNull(rs1354!K1354_AmtSizeQty30) = False Then D1354.AmtSizeQty30 = Trim$(rs1354!K1354_AmtSizeQty30)
    If IsdbNull(rs1354!K1354_Remark) = False Then D1354.Remark = Trim$(rs1354!K1354_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K1354_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K1354_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z1354 As T1354_AREA, ORDERNO AS String, ORDERNOSEQ AS String) as Boolean

K1354_MOVE = False

Try
    If READ_PFK1354(ORDERNO, ORDERNOSEQ) = True Then
                z1354 = D1354
		K1354_MOVE = True
		else
	z1354 = nothing
     End If

     If  getColumIndex(spr,"OrderNo") > -1 then z1354.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"OrderNoSeq") > -1 then z1354.OrderNoSeq = getDataM(spr, getColumIndex(spr,"OrderNoSeq"), xRow)
     If  getColumIndex(spr,"CheckS01") > -1 then z1354.CheckS01 = getDataM(spr, getColumIndex(spr,"CheckS01"), xRow)
     If  getColumIndex(spr,"CheckS02") > -1 then z1354.CheckS02 = getDataM(spr, getColumIndex(spr,"CheckS02"), xRow)
     If  getColumIndex(spr,"CheckS03") > -1 then z1354.CheckS03 = getDataM(spr, getColumIndex(spr,"CheckS03"), xRow)
     If  getColumIndex(spr,"CheckS04") > -1 then z1354.CheckS04 = getDataM(spr, getColumIndex(spr,"CheckS04"), xRow)
     If  getColumIndex(spr,"CheckS05") > -1 then z1354.CheckS05 = getDataM(spr, getColumIndex(spr,"CheckS05"), xRow)
     If  getColumIndex(spr,"CheckS06") > -1 then z1354.CheckS06 = getDataM(spr, getColumIndex(spr,"CheckS06"), xRow)
     If  getColumIndex(spr,"CheckS07") > -1 then z1354.CheckS07 = getDataM(spr, getColumIndex(spr,"CheckS07"), xRow)
     If  getColumIndex(spr,"CheckS08") > -1 then z1354.CheckS08 = getDataM(spr, getColumIndex(spr,"CheckS08"), xRow)
     If  getColumIndex(spr,"CheckS09") > -1 then z1354.CheckS09 = getDataM(spr, getColumIndex(spr,"CheckS09"), xRow)
     If  getColumIndex(spr,"CheckS10") > -1 then z1354.CheckS10 = getDataM(spr, getColumIndex(spr,"CheckS10"), xRow)
     If  getColumIndex(spr,"CheckS11") > -1 then z1354.CheckS11 = getDataM(spr, getColumIndex(spr,"CheckS11"), xRow)
     If  getColumIndex(spr,"CheckS12") > -1 then z1354.CheckS12 = getDataM(spr, getColumIndex(spr,"CheckS12"), xRow)
     If  getColumIndex(spr,"CheckS13") > -1 then z1354.CheckS13 = getDataM(spr, getColumIndex(spr,"CheckS13"), xRow)
     If  getColumIndex(spr,"CheckS14") > -1 then z1354.CheckS14 = getDataM(spr, getColumIndex(spr,"CheckS14"), xRow)
     If  getColumIndex(spr,"CheckS15") > -1 then z1354.CheckS15 = getDataM(spr, getColumIndex(spr,"CheckS15"), xRow)
     If  getColumIndex(spr,"CheckS16") > -1 then z1354.CheckS16 = getDataM(spr, getColumIndex(spr,"CheckS16"), xRow)
     If  getColumIndex(spr,"CheckS17") > -1 then z1354.CheckS17 = getDataM(spr, getColumIndex(spr,"CheckS17"), xRow)
     If  getColumIndex(spr,"CheckS18") > -1 then z1354.CheckS18 = getDataM(spr, getColumIndex(spr,"CheckS18"), xRow)
     If  getColumIndex(spr,"CheckS19") > -1 then z1354.CheckS19 = getDataM(spr, getColumIndex(spr,"CheckS19"), xRow)
     If  getColumIndex(spr,"CheckS20") > -1 then z1354.CheckS20 = getDataM(spr, getColumIndex(spr,"CheckS20"), xRow)
     If  getColumIndex(spr,"CheckS21") > -1 then z1354.CheckS21 = getDataM(spr, getColumIndex(spr,"CheckS21"), xRow)
     If  getColumIndex(spr,"CheckS22") > -1 then z1354.CheckS22 = getDataM(spr, getColumIndex(spr,"CheckS22"), xRow)
     If  getColumIndex(spr,"CheckS23") > -1 then z1354.CheckS23 = getDataM(spr, getColumIndex(spr,"CheckS23"), xRow)
     If  getColumIndex(spr,"CheckS24") > -1 then z1354.CheckS24 = getDataM(spr, getColumIndex(spr,"CheckS24"), xRow)
     If  getColumIndex(spr,"CheckS25") > -1 then z1354.CheckS25 = getDataM(spr, getColumIndex(spr,"CheckS25"), xRow)
     If  getColumIndex(spr,"CheckS26") > -1 then z1354.CheckS26 = getDataM(spr, getColumIndex(spr,"CheckS26"), xRow)
     If  getColumIndex(spr,"CheckS27") > -1 then z1354.CheckS27 = getDataM(spr, getColumIndex(spr,"CheckS27"), xRow)
     If  getColumIndex(spr,"CheckS28") > -1 then z1354.CheckS28 = getDataM(spr, getColumIndex(spr,"CheckS28"), xRow)
     If  getColumIndex(spr,"CheckS29") > -1 then z1354.CheckS29 = getDataM(spr, getColumIndex(spr,"CheckS29"), xRow)
     If  getColumIndex(spr,"CheckS30") > -1 then z1354.CheckS30 = getDataM(spr, getColumIndex(spr,"CheckS30"), xRow)
     If  getColumIndex(spr,"PSizeQty01") > -1 then z1354.PSizeQty01 = getDataM(spr, getColumIndex(spr,"PSizeQty01"), xRow)
     If  getColumIndex(spr,"PSizeQty02") > -1 then z1354.PSizeQty02 = getDataM(spr, getColumIndex(spr,"PSizeQty02"), xRow)
     If  getColumIndex(spr,"PSizeQty03") > -1 then z1354.PSizeQty03 = getDataM(spr, getColumIndex(spr,"PSizeQty03"), xRow)
     If  getColumIndex(spr,"PSizeQty04") > -1 then z1354.PSizeQty04 = getDataM(spr, getColumIndex(spr,"PSizeQty04"), xRow)
     If  getColumIndex(spr,"PSizeQty05") > -1 then z1354.PSizeQty05 = getDataM(spr, getColumIndex(spr,"PSizeQty05"), xRow)
     If  getColumIndex(spr,"PSizeQty06") > -1 then z1354.PSizeQty06 = getDataM(spr, getColumIndex(spr,"PSizeQty06"), xRow)
     If  getColumIndex(spr,"PSizeQty07") > -1 then z1354.PSizeQty07 = getDataM(spr, getColumIndex(spr,"PSizeQty07"), xRow)
     If  getColumIndex(spr,"PSizeQty08") > -1 then z1354.PSizeQty08 = getDataM(spr, getColumIndex(spr,"PSizeQty08"), xRow)
     If  getColumIndex(spr,"PSizeQty09") > -1 then z1354.PSizeQty09 = getDataM(spr, getColumIndex(spr,"PSizeQty09"), xRow)
     If  getColumIndex(spr,"PSizeQty10") > -1 then z1354.PSizeQty10 = getDataM(spr, getColumIndex(spr,"PSizeQty10"), xRow)
     If  getColumIndex(spr,"PSizeQty11") > -1 then z1354.PSizeQty11 = getDataM(spr, getColumIndex(spr,"PSizeQty11"), xRow)
     If  getColumIndex(spr,"PSizeQty12") > -1 then z1354.PSizeQty12 = getDataM(spr, getColumIndex(spr,"PSizeQty12"), xRow)
     If  getColumIndex(spr,"PSizeQty13") > -1 then z1354.PSizeQty13 = getDataM(spr, getColumIndex(spr,"PSizeQty13"), xRow)
     If  getColumIndex(spr,"PSizeQty14") > -1 then z1354.PSizeQty14 = getDataM(spr, getColumIndex(spr,"PSizeQty14"), xRow)
     If  getColumIndex(spr,"PSizeQty15") > -1 then z1354.PSizeQty15 = getDataM(spr, getColumIndex(spr,"PSizeQty15"), xRow)
     If  getColumIndex(spr,"PSizeQty16") > -1 then z1354.PSizeQty16 = getDataM(spr, getColumIndex(spr,"PSizeQty16"), xRow)
     If  getColumIndex(spr,"PSizeQty17") > -1 then z1354.PSizeQty17 = getDataM(spr, getColumIndex(spr,"PSizeQty17"), xRow)
     If  getColumIndex(spr,"PSizeQty18") > -1 then z1354.PSizeQty18 = getDataM(spr, getColumIndex(spr,"PSizeQty18"), xRow)
     If  getColumIndex(spr,"PSizeQty19") > -1 then z1354.PSizeQty19 = getDataM(spr, getColumIndex(spr,"PSizeQty19"), xRow)
     If  getColumIndex(spr,"PSizeQty20") > -1 then z1354.PSizeQty20 = getDataM(spr, getColumIndex(spr,"PSizeQty20"), xRow)
     If  getColumIndex(spr,"PSizeQty21") > -1 then z1354.PSizeQty21 = getDataM(spr, getColumIndex(spr,"PSizeQty21"), xRow)
     If  getColumIndex(spr,"PSizeQty22") > -1 then z1354.PSizeQty22 = getDataM(spr, getColumIndex(spr,"PSizeQty22"), xRow)
     If  getColumIndex(spr,"PSizeQty23") > -1 then z1354.PSizeQty23 = getDataM(spr, getColumIndex(spr,"PSizeQty23"), xRow)
     If  getColumIndex(spr,"PSizeQty24") > -1 then z1354.PSizeQty24 = getDataM(spr, getColumIndex(spr,"PSizeQty24"), xRow)
     If  getColumIndex(spr,"PSizeQty25") > -1 then z1354.PSizeQty25 = getDataM(spr, getColumIndex(spr,"PSizeQty25"), xRow)
     If  getColumIndex(spr,"PSizeQty26") > -1 then z1354.PSizeQty26 = getDataM(spr, getColumIndex(spr,"PSizeQty26"), xRow)
     If  getColumIndex(spr,"PSizeQty27") > -1 then z1354.PSizeQty27 = getDataM(spr, getColumIndex(spr,"PSizeQty27"), xRow)
     If  getColumIndex(spr,"PSizeQty28") > -1 then z1354.PSizeQty28 = getDataM(spr, getColumIndex(spr,"PSizeQty28"), xRow)
     If  getColumIndex(spr,"PSizeQty29") > -1 then z1354.PSizeQty29 = getDataM(spr, getColumIndex(spr,"PSizeQty29"), xRow)
     If  getColumIndex(spr,"PSizeQty30") > -1 then z1354.PSizeQty30 = getDataM(spr, getColumIndex(spr,"PSizeQty30"), xRow)
     If  getColumIndex(spr,"AmtSizeQty01") > -1 then z1354.AmtSizeQty01 = getDataM(spr, getColumIndex(spr,"AmtSizeQty01"), xRow)
     If  getColumIndex(spr,"AmtSizeQty02") > -1 then z1354.AmtSizeQty02 = getDataM(spr, getColumIndex(spr,"AmtSizeQty02"), xRow)
     If  getColumIndex(spr,"AmtSizeQty03") > -1 then z1354.AmtSizeQty03 = getDataM(spr, getColumIndex(spr,"AmtSizeQty03"), xRow)
     If  getColumIndex(spr,"AmtSizeQty04") > -1 then z1354.AmtSizeQty04 = getDataM(spr, getColumIndex(spr,"AmtSizeQty04"), xRow)
     If  getColumIndex(spr,"AmtSizeQty05") > -1 then z1354.AmtSizeQty05 = getDataM(spr, getColumIndex(spr,"AmtSizeQty05"), xRow)
     If  getColumIndex(spr,"AmtSizeQty06") > -1 then z1354.AmtSizeQty06 = getDataM(spr, getColumIndex(spr,"AmtSizeQty06"), xRow)
     If  getColumIndex(spr,"AmtSizeQty07") > -1 then z1354.AmtSizeQty07 = getDataM(spr, getColumIndex(spr,"AmtSizeQty07"), xRow)
     If  getColumIndex(spr,"AmtSizeQty08") > -1 then z1354.AmtSizeQty08 = getDataM(spr, getColumIndex(spr,"AmtSizeQty08"), xRow)
     If  getColumIndex(spr,"AmtSizeQty09") > -1 then z1354.AmtSizeQty09 = getDataM(spr, getColumIndex(spr,"AmtSizeQty09"), xRow)
     If  getColumIndex(spr,"AmtSizeQty10") > -1 then z1354.AmtSizeQty10 = getDataM(spr, getColumIndex(spr,"AmtSizeQty10"), xRow)
     If  getColumIndex(spr,"AmtSizeQty11") > -1 then z1354.AmtSizeQty11 = getDataM(spr, getColumIndex(spr,"AmtSizeQty11"), xRow)
     If  getColumIndex(spr,"AmtSizeQty12") > -1 then z1354.AmtSizeQty12 = getDataM(spr, getColumIndex(spr,"AmtSizeQty12"), xRow)
     If  getColumIndex(spr,"AmtSizeQty13") > -1 then z1354.AmtSizeQty13 = getDataM(spr, getColumIndex(spr,"AmtSizeQty13"), xRow)
     If  getColumIndex(spr,"AmtSizeQty14") > -1 then z1354.AmtSizeQty14 = getDataM(spr, getColumIndex(spr,"AmtSizeQty14"), xRow)
     If  getColumIndex(spr,"AmtSizeQty15") > -1 then z1354.AmtSizeQty15 = getDataM(spr, getColumIndex(spr,"AmtSizeQty15"), xRow)
     If  getColumIndex(spr,"AmtSizeQty16") > -1 then z1354.AmtSizeQty16 = getDataM(spr, getColumIndex(spr,"AmtSizeQty16"), xRow)
     If  getColumIndex(spr,"AmtSizeQty17") > -1 then z1354.AmtSizeQty17 = getDataM(spr, getColumIndex(spr,"AmtSizeQty17"), xRow)
     If  getColumIndex(spr,"AmtSizeQty18") > -1 then z1354.AmtSizeQty18 = getDataM(spr, getColumIndex(spr,"AmtSizeQty18"), xRow)
     If  getColumIndex(spr,"AmtSizeQty19") > -1 then z1354.AmtSizeQty19 = getDataM(spr, getColumIndex(spr,"AmtSizeQty19"), xRow)
     If  getColumIndex(spr,"AmtSizeQty20") > -1 then z1354.AmtSizeQty20 = getDataM(spr, getColumIndex(spr,"AmtSizeQty20"), xRow)
     If  getColumIndex(spr,"AmtSizeQty21") > -1 then z1354.AmtSizeQty21 = getDataM(spr, getColumIndex(spr,"AmtSizeQty21"), xRow)
     If  getColumIndex(spr,"AmtSizeQty22") > -1 then z1354.AmtSizeQty22 = getDataM(spr, getColumIndex(spr,"AmtSizeQty22"), xRow)
     If  getColumIndex(spr,"AmtSizeQty23") > -1 then z1354.AmtSizeQty23 = getDataM(spr, getColumIndex(spr,"AmtSizeQty23"), xRow)
     If  getColumIndex(spr,"AmtSizeQty24") > -1 then z1354.AmtSizeQty24 = getDataM(spr, getColumIndex(spr,"AmtSizeQty24"), xRow)
     If  getColumIndex(spr,"AmtSizeQty25") > -1 then z1354.AmtSizeQty25 = getDataM(spr, getColumIndex(spr,"AmtSizeQty25"), xRow)
     If  getColumIndex(spr,"AmtSizeQty26") > -1 then z1354.AmtSizeQty26 = getDataM(spr, getColumIndex(spr,"AmtSizeQty26"), xRow)
     If  getColumIndex(spr,"AmtSizeQty27") > -1 then z1354.AmtSizeQty27 = getDataM(spr, getColumIndex(spr,"AmtSizeQty27"), xRow)
     If  getColumIndex(spr,"AmtSizeQty28") > -1 then z1354.AmtSizeQty28 = getDataM(spr, getColumIndex(spr,"AmtSizeQty28"), xRow)
     If  getColumIndex(spr,"AmtSizeQty29") > -1 then z1354.AmtSizeQty29 = getDataM(spr, getColumIndex(spr,"AmtSizeQty29"), xRow)
     If  getColumIndex(spr,"AmtSizeQty30") > -1 then z1354.AmtSizeQty30 = getDataM(spr, getColumIndex(spr,"AmtSizeQty30"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z1354.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K1354_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K1354_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z1354 As T1354_AREA,CheckClear as Boolean,ORDERNO AS String, ORDERNOSEQ AS String) as Boolean

K1354_MOVE = False

Try
    If READ_PFK1354(ORDERNO, ORDERNOSEQ) = True Then
                z1354 = D1354
		K1354_MOVE = True
		else
	If CheckClear  = True then z1354 = nothing
     End If

     If  getColumIndex(spr,"OrderNo") > -1 then z1354.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"OrderNoSeq") > -1 then z1354.OrderNoSeq = getDataM(spr, getColumIndex(spr,"OrderNoSeq"), xRow)
     If  getColumIndex(spr,"CheckS01") > -1 then z1354.CheckS01 = getDataM(spr, getColumIndex(spr,"CheckS01"), xRow)
     If  getColumIndex(spr,"CheckS02") > -1 then z1354.CheckS02 = getDataM(spr, getColumIndex(spr,"CheckS02"), xRow)
     If  getColumIndex(spr,"CheckS03") > -1 then z1354.CheckS03 = getDataM(spr, getColumIndex(spr,"CheckS03"), xRow)
     If  getColumIndex(spr,"CheckS04") > -1 then z1354.CheckS04 = getDataM(spr, getColumIndex(spr,"CheckS04"), xRow)
     If  getColumIndex(spr,"CheckS05") > -1 then z1354.CheckS05 = getDataM(spr, getColumIndex(spr,"CheckS05"), xRow)
     If  getColumIndex(spr,"CheckS06") > -1 then z1354.CheckS06 = getDataM(spr, getColumIndex(spr,"CheckS06"), xRow)
     If  getColumIndex(spr,"CheckS07") > -1 then z1354.CheckS07 = getDataM(spr, getColumIndex(spr,"CheckS07"), xRow)
     If  getColumIndex(spr,"CheckS08") > -1 then z1354.CheckS08 = getDataM(spr, getColumIndex(spr,"CheckS08"), xRow)
     If  getColumIndex(spr,"CheckS09") > -1 then z1354.CheckS09 = getDataM(spr, getColumIndex(spr,"CheckS09"), xRow)
     If  getColumIndex(spr,"CheckS10") > -1 then z1354.CheckS10 = getDataM(spr, getColumIndex(spr,"CheckS10"), xRow)
     If  getColumIndex(spr,"CheckS11") > -1 then z1354.CheckS11 = getDataM(spr, getColumIndex(spr,"CheckS11"), xRow)
     If  getColumIndex(spr,"CheckS12") > -1 then z1354.CheckS12 = getDataM(spr, getColumIndex(spr,"CheckS12"), xRow)
     If  getColumIndex(spr,"CheckS13") > -1 then z1354.CheckS13 = getDataM(spr, getColumIndex(spr,"CheckS13"), xRow)
     If  getColumIndex(spr,"CheckS14") > -1 then z1354.CheckS14 = getDataM(spr, getColumIndex(spr,"CheckS14"), xRow)
     If  getColumIndex(spr,"CheckS15") > -1 then z1354.CheckS15 = getDataM(spr, getColumIndex(spr,"CheckS15"), xRow)
     If  getColumIndex(spr,"CheckS16") > -1 then z1354.CheckS16 = getDataM(spr, getColumIndex(spr,"CheckS16"), xRow)
     If  getColumIndex(spr,"CheckS17") > -1 then z1354.CheckS17 = getDataM(spr, getColumIndex(spr,"CheckS17"), xRow)
     If  getColumIndex(spr,"CheckS18") > -1 then z1354.CheckS18 = getDataM(spr, getColumIndex(spr,"CheckS18"), xRow)
     If  getColumIndex(spr,"CheckS19") > -1 then z1354.CheckS19 = getDataM(spr, getColumIndex(spr,"CheckS19"), xRow)
     If  getColumIndex(spr,"CheckS20") > -1 then z1354.CheckS20 = getDataM(spr, getColumIndex(spr,"CheckS20"), xRow)
     If  getColumIndex(spr,"CheckS21") > -1 then z1354.CheckS21 = getDataM(spr, getColumIndex(spr,"CheckS21"), xRow)
     If  getColumIndex(spr,"CheckS22") > -1 then z1354.CheckS22 = getDataM(spr, getColumIndex(spr,"CheckS22"), xRow)
     If  getColumIndex(spr,"CheckS23") > -1 then z1354.CheckS23 = getDataM(spr, getColumIndex(spr,"CheckS23"), xRow)
     If  getColumIndex(spr,"CheckS24") > -1 then z1354.CheckS24 = getDataM(spr, getColumIndex(spr,"CheckS24"), xRow)
     If  getColumIndex(spr,"CheckS25") > -1 then z1354.CheckS25 = getDataM(spr, getColumIndex(spr,"CheckS25"), xRow)
     If  getColumIndex(spr,"CheckS26") > -1 then z1354.CheckS26 = getDataM(spr, getColumIndex(spr,"CheckS26"), xRow)
     If  getColumIndex(spr,"CheckS27") > -1 then z1354.CheckS27 = getDataM(spr, getColumIndex(spr,"CheckS27"), xRow)
     If  getColumIndex(spr,"CheckS28") > -1 then z1354.CheckS28 = getDataM(spr, getColumIndex(spr,"CheckS28"), xRow)
     If  getColumIndex(spr,"CheckS29") > -1 then z1354.CheckS29 = getDataM(spr, getColumIndex(spr,"CheckS29"), xRow)
     If  getColumIndex(spr,"CheckS30") > -1 then z1354.CheckS30 = getDataM(spr, getColumIndex(spr,"CheckS30"), xRow)
     If  getColumIndex(spr,"PSizeQty01") > -1 then z1354.PSizeQty01 = getDataM(spr, getColumIndex(spr,"PSizeQty01"), xRow)
     If  getColumIndex(spr,"PSizeQty02") > -1 then z1354.PSizeQty02 = getDataM(spr, getColumIndex(spr,"PSizeQty02"), xRow)
     If  getColumIndex(spr,"PSizeQty03") > -1 then z1354.PSizeQty03 = getDataM(spr, getColumIndex(spr,"PSizeQty03"), xRow)
     If  getColumIndex(spr,"PSizeQty04") > -1 then z1354.PSizeQty04 = getDataM(spr, getColumIndex(spr,"PSizeQty04"), xRow)
     If  getColumIndex(spr,"PSizeQty05") > -1 then z1354.PSizeQty05 = getDataM(spr, getColumIndex(spr,"PSizeQty05"), xRow)
     If  getColumIndex(spr,"PSizeQty06") > -1 then z1354.PSizeQty06 = getDataM(spr, getColumIndex(spr,"PSizeQty06"), xRow)
     If  getColumIndex(spr,"PSizeQty07") > -1 then z1354.PSizeQty07 = getDataM(spr, getColumIndex(spr,"PSizeQty07"), xRow)
     If  getColumIndex(spr,"PSizeQty08") > -1 then z1354.PSizeQty08 = getDataM(spr, getColumIndex(spr,"PSizeQty08"), xRow)
     If  getColumIndex(spr,"PSizeQty09") > -1 then z1354.PSizeQty09 = getDataM(spr, getColumIndex(spr,"PSizeQty09"), xRow)
     If  getColumIndex(spr,"PSizeQty10") > -1 then z1354.PSizeQty10 = getDataM(spr, getColumIndex(spr,"PSizeQty10"), xRow)
     If  getColumIndex(spr,"PSizeQty11") > -1 then z1354.PSizeQty11 = getDataM(spr, getColumIndex(spr,"PSizeQty11"), xRow)
     If  getColumIndex(spr,"PSizeQty12") > -1 then z1354.PSizeQty12 = getDataM(spr, getColumIndex(spr,"PSizeQty12"), xRow)
     If  getColumIndex(spr,"PSizeQty13") > -1 then z1354.PSizeQty13 = getDataM(spr, getColumIndex(spr,"PSizeQty13"), xRow)
     If  getColumIndex(spr,"PSizeQty14") > -1 then z1354.PSizeQty14 = getDataM(spr, getColumIndex(spr,"PSizeQty14"), xRow)
     If  getColumIndex(spr,"PSizeQty15") > -1 then z1354.PSizeQty15 = getDataM(spr, getColumIndex(spr,"PSizeQty15"), xRow)
     If  getColumIndex(spr,"PSizeQty16") > -1 then z1354.PSizeQty16 = getDataM(spr, getColumIndex(spr,"PSizeQty16"), xRow)
     If  getColumIndex(spr,"PSizeQty17") > -1 then z1354.PSizeQty17 = getDataM(spr, getColumIndex(spr,"PSizeQty17"), xRow)
     If  getColumIndex(spr,"PSizeQty18") > -1 then z1354.PSizeQty18 = getDataM(spr, getColumIndex(spr,"PSizeQty18"), xRow)
     If  getColumIndex(spr,"PSizeQty19") > -1 then z1354.PSizeQty19 = getDataM(spr, getColumIndex(spr,"PSizeQty19"), xRow)
     If  getColumIndex(spr,"PSizeQty20") > -1 then z1354.PSizeQty20 = getDataM(spr, getColumIndex(spr,"PSizeQty20"), xRow)
     If  getColumIndex(spr,"PSizeQty21") > -1 then z1354.PSizeQty21 = getDataM(spr, getColumIndex(spr,"PSizeQty21"), xRow)
     If  getColumIndex(spr,"PSizeQty22") > -1 then z1354.PSizeQty22 = getDataM(spr, getColumIndex(spr,"PSizeQty22"), xRow)
     If  getColumIndex(spr,"PSizeQty23") > -1 then z1354.PSizeQty23 = getDataM(spr, getColumIndex(spr,"PSizeQty23"), xRow)
     If  getColumIndex(spr,"PSizeQty24") > -1 then z1354.PSizeQty24 = getDataM(spr, getColumIndex(spr,"PSizeQty24"), xRow)
     If  getColumIndex(spr,"PSizeQty25") > -1 then z1354.PSizeQty25 = getDataM(spr, getColumIndex(spr,"PSizeQty25"), xRow)
     If  getColumIndex(spr,"PSizeQty26") > -1 then z1354.PSizeQty26 = getDataM(spr, getColumIndex(spr,"PSizeQty26"), xRow)
     If  getColumIndex(spr,"PSizeQty27") > -1 then z1354.PSizeQty27 = getDataM(spr, getColumIndex(spr,"PSizeQty27"), xRow)
     If  getColumIndex(spr,"PSizeQty28") > -1 then z1354.PSizeQty28 = getDataM(spr, getColumIndex(spr,"PSizeQty28"), xRow)
     If  getColumIndex(spr,"PSizeQty29") > -1 then z1354.PSizeQty29 = getDataM(spr, getColumIndex(spr,"PSizeQty29"), xRow)
     If  getColumIndex(spr,"PSizeQty30") > -1 then z1354.PSizeQty30 = getDataM(spr, getColumIndex(spr,"PSizeQty30"), xRow)
     If  getColumIndex(spr,"AmtSizeQty01") > -1 then z1354.AmtSizeQty01 = getDataM(spr, getColumIndex(spr,"AmtSizeQty01"), xRow)
     If  getColumIndex(spr,"AmtSizeQty02") > -1 then z1354.AmtSizeQty02 = getDataM(spr, getColumIndex(spr,"AmtSizeQty02"), xRow)
     If  getColumIndex(spr,"AmtSizeQty03") > -1 then z1354.AmtSizeQty03 = getDataM(spr, getColumIndex(spr,"AmtSizeQty03"), xRow)
     If  getColumIndex(spr,"AmtSizeQty04") > -1 then z1354.AmtSizeQty04 = getDataM(spr, getColumIndex(spr,"AmtSizeQty04"), xRow)
     If  getColumIndex(spr,"AmtSizeQty05") > -1 then z1354.AmtSizeQty05 = getDataM(spr, getColumIndex(spr,"AmtSizeQty05"), xRow)
     If  getColumIndex(spr,"AmtSizeQty06") > -1 then z1354.AmtSizeQty06 = getDataM(spr, getColumIndex(spr,"AmtSizeQty06"), xRow)
     If  getColumIndex(spr,"AmtSizeQty07") > -1 then z1354.AmtSizeQty07 = getDataM(spr, getColumIndex(spr,"AmtSizeQty07"), xRow)
     If  getColumIndex(spr,"AmtSizeQty08") > -1 then z1354.AmtSizeQty08 = getDataM(spr, getColumIndex(spr,"AmtSizeQty08"), xRow)
     If  getColumIndex(spr,"AmtSizeQty09") > -1 then z1354.AmtSizeQty09 = getDataM(spr, getColumIndex(spr,"AmtSizeQty09"), xRow)
     If  getColumIndex(spr,"AmtSizeQty10") > -1 then z1354.AmtSizeQty10 = getDataM(spr, getColumIndex(spr,"AmtSizeQty10"), xRow)
     If  getColumIndex(spr,"AmtSizeQty11") > -1 then z1354.AmtSizeQty11 = getDataM(spr, getColumIndex(spr,"AmtSizeQty11"), xRow)
     If  getColumIndex(spr,"AmtSizeQty12") > -1 then z1354.AmtSizeQty12 = getDataM(spr, getColumIndex(spr,"AmtSizeQty12"), xRow)
     If  getColumIndex(spr,"AmtSizeQty13") > -1 then z1354.AmtSizeQty13 = getDataM(spr, getColumIndex(spr,"AmtSizeQty13"), xRow)
     If  getColumIndex(spr,"AmtSizeQty14") > -1 then z1354.AmtSizeQty14 = getDataM(spr, getColumIndex(spr,"AmtSizeQty14"), xRow)
     If  getColumIndex(spr,"AmtSizeQty15") > -1 then z1354.AmtSizeQty15 = getDataM(spr, getColumIndex(spr,"AmtSizeQty15"), xRow)
     If  getColumIndex(spr,"AmtSizeQty16") > -1 then z1354.AmtSizeQty16 = getDataM(spr, getColumIndex(spr,"AmtSizeQty16"), xRow)
     If  getColumIndex(spr,"AmtSizeQty17") > -1 then z1354.AmtSizeQty17 = getDataM(spr, getColumIndex(spr,"AmtSizeQty17"), xRow)
     If  getColumIndex(spr,"AmtSizeQty18") > -1 then z1354.AmtSizeQty18 = getDataM(spr, getColumIndex(spr,"AmtSizeQty18"), xRow)
     If  getColumIndex(spr,"AmtSizeQty19") > -1 then z1354.AmtSizeQty19 = getDataM(spr, getColumIndex(spr,"AmtSizeQty19"), xRow)
     If  getColumIndex(spr,"AmtSizeQty20") > -1 then z1354.AmtSizeQty20 = getDataM(spr, getColumIndex(spr,"AmtSizeQty20"), xRow)
     If  getColumIndex(spr,"AmtSizeQty21") > -1 then z1354.AmtSizeQty21 = getDataM(spr, getColumIndex(spr,"AmtSizeQty21"), xRow)
     If  getColumIndex(spr,"AmtSizeQty22") > -1 then z1354.AmtSizeQty22 = getDataM(spr, getColumIndex(spr,"AmtSizeQty22"), xRow)
     If  getColumIndex(spr,"AmtSizeQty23") > -1 then z1354.AmtSizeQty23 = getDataM(spr, getColumIndex(spr,"AmtSizeQty23"), xRow)
     If  getColumIndex(spr,"AmtSizeQty24") > -1 then z1354.AmtSizeQty24 = getDataM(spr, getColumIndex(spr,"AmtSizeQty24"), xRow)
     If  getColumIndex(spr,"AmtSizeQty25") > -1 then z1354.AmtSizeQty25 = getDataM(spr, getColumIndex(spr,"AmtSizeQty25"), xRow)
     If  getColumIndex(spr,"AmtSizeQty26") > -1 then z1354.AmtSizeQty26 = getDataM(spr, getColumIndex(spr,"AmtSizeQty26"), xRow)
     If  getColumIndex(spr,"AmtSizeQty27") > -1 then z1354.AmtSizeQty27 = getDataM(spr, getColumIndex(spr,"AmtSizeQty27"), xRow)
     If  getColumIndex(spr,"AmtSizeQty28") > -1 then z1354.AmtSizeQty28 = getDataM(spr, getColumIndex(spr,"AmtSizeQty28"), xRow)
     If  getColumIndex(spr,"AmtSizeQty29") > -1 then z1354.AmtSizeQty29 = getDataM(spr, getColumIndex(spr,"AmtSizeQty29"), xRow)
     If  getColumIndex(spr,"AmtSizeQty30") > -1 then z1354.AmtSizeQty30 = getDataM(spr, getColumIndex(spr,"AmtSizeQty30"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z1354.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K1354_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K1354_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z1354 As T1354_AREA, Job as String, ORDERNO AS String, ORDERNOSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K1354_MOVE = False

Try
    If READ_PFK1354(ORDERNO, ORDERNOSEQ) = True Then
                z1354 = D1354
		K1354_MOVE = True
		else
	z1354 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1354")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "ORDERNO":z1354.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z1354.OrderNoSeq = Children(i).Code
   Case "CHECKS01":z1354.CheckS01 = Children(i).Code
   Case "CHECKS02":z1354.CheckS02 = Children(i).Code
   Case "CHECKS03":z1354.CheckS03 = Children(i).Code
   Case "CHECKS04":z1354.CheckS04 = Children(i).Code
   Case "CHECKS05":z1354.CheckS05 = Children(i).Code
   Case "CHECKS06":z1354.CheckS06 = Children(i).Code
   Case "CHECKS07":z1354.CheckS07 = Children(i).Code
   Case "CHECKS08":z1354.CheckS08 = Children(i).Code
   Case "CHECKS09":z1354.CheckS09 = Children(i).Code
   Case "CHECKS10":z1354.CheckS10 = Children(i).Code
   Case "CHECKS11":z1354.CheckS11 = Children(i).Code
   Case "CHECKS12":z1354.CheckS12 = Children(i).Code
   Case "CHECKS13":z1354.CheckS13 = Children(i).Code
   Case "CHECKS14":z1354.CheckS14 = Children(i).Code
   Case "CHECKS15":z1354.CheckS15 = Children(i).Code
   Case "CHECKS16":z1354.CheckS16 = Children(i).Code
   Case "CHECKS17":z1354.CheckS17 = Children(i).Code
   Case "CHECKS18":z1354.CheckS18 = Children(i).Code
   Case "CHECKS19":z1354.CheckS19 = Children(i).Code
   Case "CHECKS20":z1354.CheckS20 = Children(i).Code
   Case "CHECKS21":z1354.CheckS21 = Children(i).Code
   Case "CHECKS22":z1354.CheckS22 = Children(i).Code
   Case "CHECKS23":z1354.CheckS23 = Children(i).Code
   Case "CHECKS24":z1354.CheckS24 = Children(i).Code
   Case "CHECKS25":z1354.CheckS25 = Children(i).Code
   Case "CHECKS26":z1354.CheckS26 = Children(i).Code
   Case "CHECKS27":z1354.CheckS27 = Children(i).Code
   Case "CHECKS28":z1354.CheckS28 = Children(i).Code
   Case "CHECKS29":z1354.CheckS29 = Children(i).Code
   Case "CHECKS30":z1354.CheckS30 = Children(i).Code
   Case "PSIZEQTY01":z1354.PSizeQty01 = Children(i).Code
   Case "PSIZEQTY02":z1354.PSizeQty02 = Children(i).Code
   Case "PSIZEQTY03":z1354.PSizeQty03 = Children(i).Code
   Case "PSIZEQTY04":z1354.PSizeQty04 = Children(i).Code
   Case "PSIZEQTY05":z1354.PSizeQty05 = Children(i).Code
   Case "PSIZEQTY06":z1354.PSizeQty06 = Children(i).Code
   Case "PSIZEQTY07":z1354.PSizeQty07 = Children(i).Code
   Case "PSIZEQTY08":z1354.PSizeQty08 = Children(i).Code
   Case "PSIZEQTY09":z1354.PSizeQty09 = Children(i).Code
   Case "PSIZEQTY10":z1354.PSizeQty10 = Children(i).Code
   Case "PSIZEQTY11":z1354.PSizeQty11 = Children(i).Code
   Case "PSIZEQTY12":z1354.PSizeQty12 = Children(i).Code
   Case "PSIZEQTY13":z1354.PSizeQty13 = Children(i).Code
   Case "PSIZEQTY14":z1354.PSizeQty14 = Children(i).Code
   Case "PSIZEQTY15":z1354.PSizeQty15 = Children(i).Code
   Case "PSIZEQTY16":z1354.PSizeQty16 = Children(i).Code
   Case "PSIZEQTY17":z1354.PSizeQty17 = Children(i).Code
   Case "PSIZEQTY18":z1354.PSizeQty18 = Children(i).Code
   Case "PSIZEQTY19":z1354.PSizeQty19 = Children(i).Code
   Case "PSIZEQTY20":z1354.PSizeQty20 = Children(i).Code
   Case "PSIZEQTY21":z1354.PSizeQty21 = Children(i).Code
   Case "PSIZEQTY22":z1354.PSizeQty22 = Children(i).Code
   Case "PSIZEQTY23":z1354.PSizeQty23 = Children(i).Code
   Case "PSIZEQTY24":z1354.PSizeQty24 = Children(i).Code
   Case "PSIZEQTY25":z1354.PSizeQty25 = Children(i).Code
   Case "PSIZEQTY26":z1354.PSizeQty26 = Children(i).Code
   Case "PSIZEQTY27":z1354.PSizeQty27 = Children(i).Code
   Case "PSIZEQTY28":z1354.PSizeQty28 = Children(i).Code
   Case "PSIZEQTY29":z1354.PSizeQty29 = Children(i).Code
   Case "PSIZEQTY30":z1354.PSizeQty30 = Children(i).Code
   Case "AMTSIZEQTY01":z1354.AmtSizeQty01 = Children(i).Code
   Case "AMTSIZEQTY02":z1354.AmtSizeQty02 = Children(i).Code
   Case "AMTSIZEQTY03":z1354.AmtSizeQty03 = Children(i).Code
   Case "AMTSIZEQTY04":z1354.AmtSizeQty04 = Children(i).Code
   Case "AMTSIZEQTY05":z1354.AmtSizeQty05 = Children(i).Code
   Case "AMTSIZEQTY06":z1354.AmtSizeQty06 = Children(i).Code
   Case "AMTSIZEQTY07":z1354.AmtSizeQty07 = Children(i).Code
   Case "AMTSIZEQTY08":z1354.AmtSizeQty08 = Children(i).Code
   Case "AMTSIZEQTY09":z1354.AmtSizeQty09 = Children(i).Code
   Case "AMTSIZEQTY10":z1354.AmtSizeQty10 = Children(i).Code
   Case "AMTSIZEQTY11":z1354.AmtSizeQty11 = Children(i).Code
   Case "AMTSIZEQTY12":z1354.AmtSizeQty12 = Children(i).Code
   Case "AMTSIZEQTY13":z1354.AmtSizeQty13 = Children(i).Code
   Case "AMTSIZEQTY14":z1354.AmtSizeQty14 = Children(i).Code
   Case "AMTSIZEQTY15":z1354.AmtSizeQty15 = Children(i).Code
   Case "AMTSIZEQTY16":z1354.AmtSizeQty16 = Children(i).Code
   Case "AMTSIZEQTY17":z1354.AmtSizeQty17 = Children(i).Code
   Case "AMTSIZEQTY18":z1354.AmtSizeQty18 = Children(i).Code
   Case "AMTSIZEQTY19":z1354.AmtSizeQty19 = Children(i).Code
   Case "AMTSIZEQTY20":z1354.AmtSizeQty20 = Children(i).Code
   Case "AMTSIZEQTY21":z1354.AmtSizeQty21 = Children(i).Code
   Case "AMTSIZEQTY22":z1354.AmtSizeQty22 = Children(i).Code
   Case "AMTSIZEQTY23":z1354.AmtSizeQty23 = Children(i).Code
   Case "AMTSIZEQTY24":z1354.AmtSizeQty24 = Children(i).Code
   Case "AMTSIZEQTY25":z1354.AmtSizeQty25 = Children(i).Code
   Case "AMTSIZEQTY26":z1354.AmtSizeQty26 = Children(i).Code
   Case "AMTSIZEQTY27":z1354.AmtSizeQty27 = Children(i).Code
   Case "AMTSIZEQTY28":z1354.AmtSizeQty28 = Children(i).Code
   Case "AMTSIZEQTY29":z1354.AmtSizeQty29 = Children(i).Code
   Case "AMTSIZEQTY30":z1354.AmtSizeQty30 = Children(i).Code
   Case "REMARK":z1354.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "ORDERNO":z1354.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z1354.OrderNoSeq = Children(i).Data
   Case "CHECKS01":z1354.CheckS01 = Children(i).Data
   Case "CHECKS02":z1354.CheckS02 = Children(i).Data
   Case "CHECKS03":z1354.CheckS03 = Children(i).Data
   Case "CHECKS04":z1354.CheckS04 = Children(i).Data
   Case "CHECKS05":z1354.CheckS05 = Children(i).Data
   Case "CHECKS06":z1354.CheckS06 = Children(i).Data
   Case "CHECKS07":z1354.CheckS07 = Children(i).Data
   Case "CHECKS08":z1354.CheckS08 = Children(i).Data
   Case "CHECKS09":z1354.CheckS09 = Children(i).Data
   Case "CHECKS10":z1354.CheckS10 = Children(i).Data
   Case "CHECKS11":z1354.CheckS11 = Children(i).Data
   Case "CHECKS12":z1354.CheckS12 = Children(i).Data
   Case "CHECKS13":z1354.CheckS13 = Children(i).Data
   Case "CHECKS14":z1354.CheckS14 = Children(i).Data
   Case "CHECKS15":z1354.CheckS15 = Children(i).Data
   Case "CHECKS16":z1354.CheckS16 = Children(i).Data
   Case "CHECKS17":z1354.CheckS17 = Children(i).Data
   Case "CHECKS18":z1354.CheckS18 = Children(i).Data
   Case "CHECKS19":z1354.CheckS19 = Children(i).Data
   Case "CHECKS20":z1354.CheckS20 = Children(i).Data
   Case "CHECKS21":z1354.CheckS21 = Children(i).Data
   Case "CHECKS22":z1354.CheckS22 = Children(i).Data
   Case "CHECKS23":z1354.CheckS23 = Children(i).Data
   Case "CHECKS24":z1354.CheckS24 = Children(i).Data
   Case "CHECKS25":z1354.CheckS25 = Children(i).Data
   Case "CHECKS26":z1354.CheckS26 = Children(i).Data
   Case "CHECKS27":z1354.CheckS27 = Children(i).Data
   Case "CHECKS28":z1354.CheckS28 = Children(i).Data
   Case "CHECKS29":z1354.CheckS29 = Children(i).Data
   Case "CHECKS30":z1354.CheckS30 = Children(i).Data
   Case "PSIZEQTY01":z1354.PSizeQty01 = Children(i).Data
   Case "PSIZEQTY02":z1354.PSizeQty02 = Children(i).Data
   Case "PSIZEQTY03":z1354.PSizeQty03 = Children(i).Data
   Case "PSIZEQTY04":z1354.PSizeQty04 = Children(i).Data
   Case "PSIZEQTY05":z1354.PSizeQty05 = Children(i).Data
   Case "PSIZEQTY06":z1354.PSizeQty06 = Children(i).Data
   Case "PSIZEQTY07":z1354.PSizeQty07 = Children(i).Data
   Case "PSIZEQTY08":z1354.PSizeQty08 = Children(i).Data
   Case "PSIZEQTY09":z1354.PSizeQty09 = Children(i).Data
   Case "PSIZEQTY10":z1354.PSizeQty10 = Children(i).Data
   Case "PSIZEQTY11":z1354.PSizeQty11 = Children(i).Data
   Case "PSIZEQTY12":z1354.PSizeQty12 = Children(i).Data
   Case "PSIZEQTY13":z1354.PSizeQty13 = Children(i).Data
   Case "PSIZEQTY14":z1354.PSizeQty14 = Children(i).Data
   Case "PSIZEQTY15":z1354.PSizeQty15 = Children(i).Data
   Case "PSIZEQTY16":z1354.PSizeQty16 = Children(i).Data
   Case "PSIZEQTY17":z1354.PSizeQty17 = Children(i).Data
   Case "PSIZEQTY18":z1354.PSizeQty18 = Children(i).Data
   Case "PSIZEQTY19":z1354.PSizeQty19 = Children(i).Data
   Case "PSIZEQTY20":z1354.PSizeQty20 = Children(i).Data
   Case "PSIZEQTY21":z1354.PSizeQty21 = Children(i).Data
   Case "PSIZEQTY22":z1354.PSizeQty22 = Children(i).Data
   Case "PSIZEQTY23":z1354.PSizeQty23 = Children(i).Data
   Case "PSIZEQTY24":z1354.PSizeQty24 = Children(i).Data
   Case "PSIZEQTY25":z1354.PSizeQty25 = Children(i).Data
   Case "PSIZEQTY26":z1354.PSizeQty26 = Children(i).Data
   Case "PSIZEQTY27":z1354.PSizeQty27 = Children(i).Data
   Case "PSIZEQTY28":z1354.PSizeQty28 = Children(i).Data
   Case "PSIZEQTY29":z1354.PSizeQty29 = Children(i).Data
   Case "PSIZEQTY30":z1354.PSizeQty30 = Children(i).Data
   Case "AMTSIZEQTY01":z1354.AmtSizeQty01 = Children(i).Data
   Case "AMTSIZEQTY02":z1354.AmtSizeQty02 = Children(i).Data
   Case "AMTSIZEQTY03":z1354.AmtSizeQty03 = Children(i).Data
   Case "AMTSIZEQTY04":z1354.AmtSizeQty04 = Children(i).Data
   Case "AMTSIZEQTY05":z1354.AmtSizeQty05 = Children(i).Data
   Case "AMTSIZEQTY06":z1354.AmtSizeQty06 = Children(i).Data
   Case "AMTSIZEQTY07":z1354.AmtSizeQty07 = Children(i).Data
   Case "AMTSIZEQTY08":z1354.AmtSizeQty08 = Children(i).Data
   Case "AMTSIZEQTY09":z1354.AmtSizeQty09 = Children(i).Data
   Case "AMTSIZEQTY10":z1354.AmtSizeQty10 = Children(i).Data
   Case "AMTSIZEQTY11":z1354.AmtSizeQty11 = Children(i).Data
   Case "AMTSIZEQTY12":z1354.AmtSizeQty12 = Children(i).Data
   Case "AMTSIZEQTY13":z1354.AmtSizeQty13 = Children(i).Data
   Case "AMTSIZEQTY14":z1354.AmtSizeQty14 = Children(i).Data
   Case "AMTSIZEQTY15":z1354.AmtSizeQty15 = Children(i).Data
   Case "AMTSIZEQTY16":z1354.AmtSizeQty16 = Children(i).Data
   Case "AMTSIZEQTY17":z1354.AmtSizeQty17 = Children(i).Data
   Case "AMTSIZEQTY18":z1354.AmtSizeQty18 = Children(i).Data
   Case "AMTSIZEQTY19":z1354.AmtSizeQty19 = Children(i).Data
   Case "AMTSIZEQTY20":z1354.AmtSizeQty20 = Children(i).Data
   Case "AMTSIZEQTY21":z1354.AmtSizeQty21 = Children(i).Data
   Case "AMTSIZEQTY22":z1354.AmtSizeQty22 = Children(i).Data
   Case "AMTSIZEQTY23":z1354.AmtSizeQty23 = Children(i).Data
   Case "AMTSIZEQTY24":z1354.AmtSizeQty24 = Children(i).Data
   Case "AMTSIZEQTY25":z1354.AmtSizeQty25 = Children(i).Data
   Case "AMTSIZEQTY26":z1354.AmtSizeQty26 = Children(i).Data
   Case "AMTSIZEQTY27":z1354.AmtSizeQty27 = Children(i).Data
   Case "AMTSIZEQTY28":z1354.AmtSizeQty28 = Children(i).Data
   Case "AMTSIZEQTY29":z1354.AmtSizeQty29 = Children(i).Data
   Case "AMTSIZEQTY30":z1354.AmtSizeQty30 = Children(i).Data
   Case "REMARK":z1354.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K1354_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K1354_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z1354 As T1354_AREA, Job as String, CheckClear as Boolean, ORDERNO AS String, ORDERNOSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K1354_MOVE = False

Try
    If READ_PFK1354(ORDERNO, ORDERNOSEQ) = True Then
                z1354 = D1354
		K1354_MOVE = True
		else
	If CheckClear  = True then z1354 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1354")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "ORDERNO":z1354.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z1354.OrderNoSeq = Children(i).Code
   Case "CHECKS01":z1354.CheckS01 = Children(i).Code
   Case "CHECKS02":z1354.CheckS02 = Children(i).Code
   Case "CHECKS03":z1354.CheckS03 = Children(i).Code
   Case "CHECKS04":z1354.CheckS04 = Children(i).Code
   Case "CHECKS05":z1354.CheckS05 = Children(i).Code
   Case "CHECKS06":z1354.CheckS06 = Children(i).Code
   Case "CHECKS07":z1354.CheckS07 = Children(i).Code
   Case "CHECKS08":z1354.CheckS08 = Children(i).Code
   Case "CHECKS09":z1354.CheckS09 = Children(i).Code
   Case "CHECKS10":z1354.CheckS10 = Children(i).Code
   Case "CHECKS11":z1354.CheckS11 = Children(i).Code
   Case "CHECKS12":z1354.CheckS12 = Children(i).Code
   Case "CHECKS13":z1354.CheckS13 = Children(i).Code
   Case "CHECKS14":z1354.CheckS14 = Children(i).Code
   Case "CHECKS15":z1354.CheckS15 = Children(i).Code
   Case "CHECKS16":z1354.CheckS16 = Children(i).Code
   Case "CHECKS17":z1354.CheckS17 = Children(i).Code
   Case "CHECKS18":z1354.CheckS18 = Children(i).Code
   Case "CHECKS19":z1354.CheckS19 = Children(i).Code
   Case "CHECKS20":z1354.CheckS20 = Children(i).Code
   Case "CHECKS21":z1354.CheckS21 = Children(i).Code
   Case "CHECKS22":z1354.CheckS22 = Children(i).Code
   Case "CHECKS23":z1354.CheckS23 = Children(i).Code
   Case "CHECKS24":z1354.CheckS24 = Children(i).Code
   Case "CHECKS25":z1354.CheckS25 = Children(i).Code
   Case "CHECKS26":z1354.CheckS26 = Children(i).Code
   Case "CHECKS27":z1354.CheckS27 = Children(i).Code
   Case "CHECKS28":z1354.CheckS28 = Children(i).Code
   Case "CHECKS29":z1354.CheckS29 = Children(i).Code
   Case "CHECKS30":z1354.CheckS30 = Children(i).Code
   Case "PSIZEQTY01":z1354.PSizeQty01 = Children(i).Code
   Case "PSIZEQTY02":z1354.PSizeQty02 = Children(i).Code
   Case "PSIZEQTY03":z1354.PSizeQty03 = Children(i).Code
   Case "PSIZEQTY04":z1354.PSizeQty04 = Children(i).Code
   Case "PSIZEQTY05":z1354.PSizeQty05 = Children(i).Code
   Case "PSIZEQTY06":z1354.PSizeQty06 = Children(i).Code
   Case "PSIZEQTY07":z1354.PSizeQty07 = Children(i).Code
   Case "PSIZEQTY08":z1354.PSizeQty08 = Children(i).Code
   Case "PSIZEQTY09":z1354.PSizeQty09 = Children(i).Code
   Case "PSIZEQTY10":z1354.PSizeQty10 = Children(i).Code
   Case "PSIZEQTY11":z1354.PSizeQty11 = Children(i).Code
   Case "PSIZEQTY12":z1354.PSizeQty12 = Children(i).Code
   Case "PSIZEQTY13":z1354.PSizeQty13 = Children(i).Code
   Case "PSIZEQTY14":z1354.PSizeQty14 = Children(i).Code
   Case "PSIZEQTY15":z1354.PSizeQty15 = Children(i).Code
   Case "PSIZEQTY16":z1354.PSizeQty16 = Children(i).Code
   Case "PSIZEQTY17":z1354.PSizeQty17 = Children(i).Code
   Case "PSIZEQTY18":z1354.PSizeQty18 = Children(i).Code
   Case "PSIZEQTY19":z1354.PSizeQty19 = Children(i).Code
   Case "PSIZEQTY20":z1354.PSizeQty20 = Children(i).Code
   Case "PSIZEQTY21":z1354.PSizeQty21 = Children(i).Code
   Case "PSIZEQTY22":z1354.PSizeQty22 = Children(i).Code
   Case "PSIZEQTY23":z1354.PSizeQty23 = Children(i).Code
   Case "PSIZEQTY24":z1354.PSizeQty24 = Children(i).Code
   Case "PSIZEQTY25":z1354.PSizeQty25 = Children(i).Code
   Case "PSIZEQTY26":z1354.PSizeQty26 = Children(i).Code
   Case "PSIZEQTY27":z1354.PSizeQty27 = Children(i).Code
   Case "PSIZEQTY28":z1354.PSizeQty28 = Children(i).Code
   Case "PSIZEQTY29":z1354.PSizeQty29 = Children(i).Code
   Case "PSIZEQTY30":z1354.PSizeQty30 = Children(i).Code
   Case "AMTSIZEQTY01":z1354.AmtSizeQty01 = Children(i).Code
   Case "AMTSIZEQTY02":z1354.AmtSizeQty02 = Children(i).Code
   Case "AMTSIZEQTY03":z1354.AmtSizeQty03 = Children(i).Code
   Case "AMTSIZEQTY04":z1354.AmtSizeQty04 = Children(i).Code
   Case "AMTSIZEQTY05":z1354.AmtSizeQty05 = Children(i).Code
   Case "AMTSIZEQTY06":z1354.AmtSizeQty06 = Children(i).Code
   Case "AMTSIZEQTY07":z1354.AmtSizeQty07 = Children(i).Code
   Case "AMTSIZEQTY08":z1354.AmtSizeQty08 = Children(i).Code
   Case "AMTSIZEQTY09":z1354.AmtSizeQty09 = Children(i).Code
   Case "AMTSIZEQTY10":z1354.AmtSizeQty10 = Children(i).Code
   Case "AMTSIZEQTY11":z1354.AmtSizeQty11 = Children(i).Code
   Case "AMTSIZEQTY12":z1354.AmtSizeQty12 = Children(i).Code
   Case "AMTSIZEQTY13":z1354.AmtSizeQty13 = Children(i).Code
   Case "AMTSIZEQTY14":z1354.AmtSizeQty14 = Children(i).Code
   Case "AMTSIZEQTY15":z1354.AmtSizeQty15 = Children(i).Code
   Case "AMTSIZEQTY16":z1354.AmtSizeQty16 = Children(i).Code
   Case "AMTSIZEQTY17":z1354.AmtSizeQty17 = Children(i).Code
   Case "AMTSIZEQTY18":z1354.AmtSizeQty18 = Children(i).Code
   Case "AMTSIZEQTY19":z1354.AmtSizeQty19 = Children(i).Code
   Case "AMTSIZEQTY20":z1354.AmtSizeQty20 = Children(i).Code
   Case "AMTSIZEQTY21":z1354.AmtSizeQty21 = Children(i).Code
   Case "AMTSIZEQTY22":z1354.AmtSizeQty22 = Children(i).Code
   Case "AMTSIZEQTY23":z1354.AmtSizeQty23 = Children(i).Code
   Case "AMTSIZEQTY24":z1354.AmtSizeQty24 = Children(i).Code
   Case "AMTSIZEQTY25":z1354.AmtSizeQty25 = Children(i).Code
   Case "AMTSIZEQTY26":z1354.AmtSizeQty26 = Children(i).Code
   Case "AMTSIZEQTY27":z1354.AmtSizeQty27 = Children(i).Code
   Case "AMTSIZEQTY28":z1354.AmtSizeQty28 = Children(i).Code
   Case "AMTSIZEQTY29":z1354.AmtSizeQty29 = Children(i).Code
   Case "AMTSIZEQTY30":z1354.AmtSizeQty30 = Children(i).Code
   Case "REMARK":z1354.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "ORDERNO":z1354.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z1354.OrderNoSeq = Children(i).Data
   Case "CHECKS01":z1354.CheckS01 = Children(i).Data
   Case "CHECKS02":z1354.CheckS02 = Children(i).Data
   Case "CHECKS03":z1354.CheckS03 = Children(i).Data
   Case "CHECKS04":z1354.CheckS04 = Children(i).Data
   Case "CHECKS05":z1354.CheckS05 = Children(i).Data
   Case "CHECKS06":z1354.CheckS06 = Children(i).Data
   Case "CHECKS07":z1354.CheckS07 = Children(i).Data
   Case "CHECKS08":z1354.CheckS08 = Children(i).Data
   Case "CHECKS09":z1354.CheckS09 = Children(i).Data
   Case "CHECKS10":z1354.CheckS10 = Children(i).Data
   Case "CHECKS11":z1354.CheckS11 = Children(i).Data
   Case "CHECKS12":z1354.CheckS12 = Children(i).Data
   Case "CHECKS13":z1354.CheckS13 = Children(i).Data
   Case "CHECKS14":z1354.CheckS14 = Children(i).Data
   Case "CHECKS15":z1354.CheckS15 = Children(i).Data
   Case "CHECKS16":z1354.CheckS16 = Children(i).Data
   Case "CHECKS17":z1354.CheckS17 = Children(i).Data
   Case "CHECKS18":z1354.CheckS18 = Children(i).Data
   Case "CHECKS19":z1354.CheckS19 = Children(i).Data
   Case "CHECKS20":z1354.CheckS20 = Children(i).Data
   Case "CHECKS21":z1354.CheckS21 = Children(i).Data
   Case "CHECKS22":z1354.CheckS22 = Children(i).Data
   Case "CHECKS23":z1354.CheckS23 = Children(i).Data
   Case "CHECKS24":z1354.CheckS24 = Children(i).Data
   Case "CHECKS25":z1354.CheckS25 = Children(i).Data
   Case "CHECKS26":z1354.CheckS26 = Children(i).Data
   Case "CHECKS27":z1354.CheckS27 = Children(i).Data
   Case "CHECKS28":z1354.CheckS28 = Children(i).Data
   Case "CHECKS29":z1354.CheckS29 = Children(i).Data
   Case "CHECKS30":z1354.CheckS30 = Children(i).Data
   Case "PSIZEQTY01":z1354.PSizeQty01 = Children(i).Data
   Case "PSIZEQTY02":z1354.PSizeQty02 = Children(i).Data
   Case "PSIZEQTY03":z1354.PSizeQty03 = Children(i).Data
   Case "PSIZEQTY04":z1354.PSizeQty04 = Children(i).Data
   Case "PSIZEQTY05":z1354.PSizeQty05 = Children(i).Data
   Case "PSIZEQTY06":z1354.PSizeQty06 = Children(i).Data
   Case "PSIZEQTY07":z1354.PSizeQty07 = Children(i).Data
   Case "PSIZEQTY08":z1354.PSizeQty08 = Children(i).Data
   Case "PSIZEQTY09":z1354.PSizeQty09 = Children(i).Data
   Case "PSIZEQTY10":z1354.PSizeQty10 = Children(i).Data
   Case "PSIZEQTY11":z1354.PSizeQty11 = Children(i).Data
   Case "PSIZEQTY12":z1354.PSizeQty12 = Children(i).Data
   Case "PSIZEQTY13":z1354.PSizeQty13 = Children(i).Data
   Case "PSIZEQTY14":z1354.PSizeQty14 = Children(i).Data
   Case "PSIZEQTY15":z1354.PSizeQty15 = Children(i).Data
   Case "PSIZEQTY16":z1354.PSizeQty16 = Children(i).Data
   Case "PSIZEQTY17":z1354.PSizeQty17 = Children(i).Data
   Case "PSIZEQTY18":z1354.PSizeQty18 = Children(i).Data
   Case "PSIZEQTY19":z1354.PSizeQty19 = Children(i).Data
   Case "PSIZEQTY20":z1354.PSizeQty20 = Children(i).Data
   Case "PSIZEQTY21":z1354.PSizeQty21 = Children(i).Data
   Case "PSIZEQTY22":z1354.PSizeQty22 = Children(i).Data
   Case "PSIZEQTY23":z1354.PSizeQty23 = Children(i).Data
   Case "PSIZEQTY24":z1354.PSizeQty24 = Children(i).Data
   Case "PSIZEQTY25":z1354.PSizeQty25 = Children(i).Data
   Case "PSIZEQTY26":z1354.PSizeQty26 = Children(i).Data
   Case "PSIZEQTY27":z1354.PSizeQty27 = Children(i).Data
   Case "PSIZEQTY28":z1354.PSizeQty28 = Children(i).Data
   Case "PSIZEQTY29":z1354.PSizeQty29 = Children(i).Data
   Case "PSIZEQTY30":z1354.PSizeQty30 = Children(i).Data
   Case "AMTSIZEQTY01":z1354.AmtSizeQty01 = Children(i).Data
   Case "AMTSIZEQTY02":z1354.AmtSizeQty02 = Children(i).Data
   Case "AMTSIZEQTY03":z1354.AmtSizeQty03 = Children(i).Data
   Case "AMTSIZEQTY04":z1354.AmtSizeQty04 = Children(i).Data
   Case "AMTSIZEQTY05":z1354.AmtSizeQty05 = Children(i).Data
   Case "AMTSIZEQTY06":z1354.AmtSizeQty06 = Children(i).Data
   Case "AMTSIZEQTY07":z1354.AmtSizeQty07 = Children(i).Data
   Case "AMTSIZEQTY08":z1354.AmtSizeQty08 = Children(i).Data
   Case "AMTSIZEQTY09":z1354.AmtSizeQty09 = Children(i).Data
   Case "AMTSIZEQTY10":z1354.AmtSizeQty10 = Children(i).Data
   Case "AMTSIZEQTY11":z1354.AmtSizeQty11 = Children(i).Data
   Case "AMTSIZEQTY12":z1354.AmtSizeQty12 = Children(i).Data
   Case "AMTSIZEQTY13":z1354.AmtSizeQty13 = Children(i).Data
   Case "AMTSIZEQTY14":z1354.AmtSizeQty14 = Children(i).Data
   Case "AMTSIZEQTY15":z1354.AmtSizeQty15 = Children(i).Data
   Case "AMTSIZEQTY16":z1354.AmtSizeQty16 = Children(i).Data
   Case "AMTSIZEQTY17":z1354.AmtSizeQty17 = Children(i).Data
   Case "AMTSIZEQTY18":z1354.AmtSizeQty18 = Children(i).Data
   Case "AMTSIZEQTY19":z1354.AmtSizeQty19 = Children(i).Data
   Case "AMTSIZEQTY20":z1354.AmtSizeQty20 = Children(i).Data
   Case "AMTSIZEQTY21":z1354.AmtSizeQty21 = Children(i).Data
   Case "AMTSIZEQTY22":z1354.AmtSizeQty22 = Children(i).Data
   Case "AMTSIZEQTY23":z1354.AmtSizeQty23 = Children(i).Data
   Case "AMTSIZEQTY24":z1354.AmtSizeQty24 = Children(i).Data
   Case "AMTSIZEQTY25":z1354.AmtSizeQty25 = Children(i).Data
   Case "AMTSIZEQTY26":z1354.AmtSizeQty26 = Children(i).Data
   Case "AMTSIZEQTY27":z1354.AmtSizeQty27 = Children(i).Data
   Case "AMTSIZEQTY28":z1354.AmtSizeQty28 = Children(i).Data
   Case "AMTSIZEQTY29":z1354.AmtSizeQty29 = Children(i).Data
   Case "AMTSIZEQTY30":z1354.AmtSizeQty30 = Children(i).Data
   Case "REMARK":z1354.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K1354_MOVE",vbCritical)
End Try
End Function 
    
End Module 
