'=========================================================================================================================================================
'   TABLE : (PFK4903)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K4903

Structure T4903_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	ShippingWorkOrder	 AS String	'			char(9)		*
Public 	ShippingWorkOrderSeq	 AS String	'			char(3)		*
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
Public 	Remark	 AS String	'			nvarchar(500)
'=========================================================================================================================================================
End structure

Public D4903 As T4903_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK4903(SHIPPINGWORKORDER AS String, SHIPPINGWORKORDERSEQ AS String) As Boolean
    READ_PFK4903 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4903 "
    SQL = SQL & " WHERE K4903_ShippingWorkOrder		 = '" & ShippingWorkOrder & "' " 
    SQL = SQL & "   AND K4903_ShippingWorkOrderSeq		 = '" & ShippingWorkOrderSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D4903_CLEAR: GoTo SKIP_READ_PFK4903
                
    Call K4903_MOVE(rd)
    READ_PFK4903 = True

SKIP_READ_PFK4903:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK4903",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK4903(SHIPPINGWORKORDER AS String, SHIPPINGWORKORDERSEQ AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4903 "
    SQL = SQL & " WHERE K4903_ShippingWorkOrder		 = '" & ShippingWorkOrder & "' " 
    SQL = SQL & "   AND K4903_ShippingWorkOrderSeq		 = '" & ShippingWorkOrderSeq & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK4903",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK4903(z4903 As T4903_AREA) As Boolean
    WRITE_PFK4903 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z4903)
 
    SQL = " INSERT INTO PFK4903 "
    SQL = SQL & " ( "
    SQL = SQL & " K4903_ShippingWorkOrder," 
    SQL = SQL & " K4903_ShippingWorkOrderSeq," 
    SQL = SQL & " K4903_SizeQty01," 
    SQL = SQL & " K4903_SizeQty02," 
    SQL = SQL & " K4903_SizeQty03," 
    SQL = SQL & " K4903_SizeQty04," 
    SQL = SQL & " K4903_SizeQty05," 
    SQL = SQL & " K4903_SizeQty06," 
    SQL = SQL & " K4903_SizeQty07," 
    SQL = SQL & " K4903_SizeQty08," 
    SQL = SQL & " K4903_SizeQty09," 
    SQL = SQL & " K4903_SizeQty10," 
    SQL = SQL & " K4903_SizeQty11," 
    SQL = SQL & " K4903_SizeQty12," 
    SQL = SQL & " K4903_SizeQty13," 
    SQL = SQL & " K4903_SizeQty14," 
    SQL = SQL & " K4903_SizeQty15," 
    SQL = SQL & " K4903_SizeQty16," 
    SQL = SQL & " K4903_SizeQty17," 
    SQL = SQL & " K4903_SizeQty18," 
    SQL = SQL & " K4903_SizeQty19," 
    SQL = SQL & " K4903_SizeQty20," 
    SQL = SQL & " K4903_SizeQty21," 
    SQL = SQL & " K4903_SizeQty22," 
    SQL = SQL & " K4903_SizeQty23," 
    SQL = SQL & " K4903_SizeQty24," 
    SQL = SQL & " K4903_SizeQty25," 
    SQL = SQL & " K4903_SizeQty26," 
    SQL = SQL & " K4903_SizeQty27," 
    SQL = SQL & " K4903_SizeQty28," 
    SQL = SQL & " K4903_SizeQty29," 
    SQL = SQL & " K4903_SizeQty30," 
    SQL = SQL & " K4903_PriceS01," 
    SQL = SQL & " K4903_PriceS02," 
    SQL = SQL & " K4903_PriceS03," 
    SQL = SQL & " K4903_PriceS04," 
    SQL = SQL & " K4903_PriceS05," 
    SQL = SQL & " K4903_PriceS06," 
    SQL = SQL & " K4903_PriceS07," 
    SQL = SQL & " K4903_PriceS08," 
    SQL = SQL & " K4903_PriceS09," 
    SQL = SQL & " K4903_PriceS10," 
    SQL = SQL & " K4903_PriceS11," 
    SQL = SQL & " K4903_PriceS12," 
    SQL = SQL & " K4903_PriceS13," 
    SQL = SQL & " K4903_PriceS14," 
    SQL = SQL & " K4903_PriceS15," 
    SQL = SQL & " K4903_PriceS16," 
    SQL = SQL & " K4903_PriceS17," 
    SQL = SQL & " K4903_PriceS18," 
    SQL = SQL & " K4903_PriceS19," 
    SQL = SQL & " K4903_PriceS20," 
    SQL = SQL & " K4903_PriceS21," 
    SQL = SQL & " K4903_PriceS22," 
    SQL = SQL & " K4903_PriceS23," 
    SQL = SQL & " K4903_PriceS24," 
    SQL = SQL & " K4903_PriceS25," 
    SQL = SQL & " K4903_PriceS26," 
    SQL = SQL & " K4903_PriceS27," 
    SQL = SQL & " K4903_PriceS28," 
    SQL = SQL & " K4903_PriceS29," 
    SQL = SQL & " K4903_PriceS30," 
    SQL = SQL & " K4903_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z4903.ShippingWorkOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4903.ShippingWorkOrderSeq) & "', "  
    SQL = SQL & "   " & FormatSQL(z4903.SizeQty01) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.SizeQty02) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.SizeQty03) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.SizeQty04) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.SizeQty05) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.SizeQty06) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.SizeQty07) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.SizeQty08) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.SizeQty09) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.SizeQty10) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.SizeQty11) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.SizeQty12) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.SizeQty13) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.SizeQty14) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.SizeQty15) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.SizeQty16) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.SizeQty17) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.SizeQty18) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.SizeQty19) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.SizeQty20) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.SizeQty21) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.SizeQty22) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.SizeQty23) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.SizeQty24) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.SizeQty25) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.SizeQty26) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.SizeQty27) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.SizeQty28) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.SizeQty29) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.SizeQty30) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.PriceS01) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.PriceS02) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.PriceS03) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.PriceS04) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.PriceS05) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.PriceS06) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.PriceS07) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.PriceS08) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.PriceS09) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.PriceS10) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.PriceS11) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.PriceS12) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.PriceS13) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.PriceS14) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.PriceS15) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.PriceS16) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.PriceS17) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.PriceS18) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.PriceS19) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.PriceS20) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.PriceS21) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.PriceS22) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.PriceS23) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.PriceS24) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.PriceS25) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.PriceS26) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.PriceS27) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.PriceS28) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.PriceS29) & ", "  
    SQL = SQL & "   " & FormatSQL(z4903.PriceS30) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4903.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK4903 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK4903",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK4903(z4903 As T4903_AREA) As Boolean
    REWRITE_PFK4903 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z4903)
   
    SQL = " UPDATE PFK4903 SET "
    SQL = SQL & "    K4903_SizeQty01      =  " & FormatSQL(z4903.SizeQty01) & ", " 
    SQL = SQL & "    K4903_SizeQty02      =  " & FormatSQL(z4903.SizeQty02) & ", " 
    SQL = SQL & "    K4903_SizeQty03      =  " & FormatSQL(z4903.SizeQty03) & ", " 
    SQL = SQL & "    K4903_SizeQty04      =  " & FormatSQL(z4903.SizeQty04) & ", " 
    SQL = SQL & "    K4903_SizeQty05      =  " & FormatSQL(z4903.SizeQty05) & ", " 
    SQL = SQL & "    K4903_SizeQty06      =  " & FormatSQL(z4903.SizeQty06) & ", " 
    SQL = SQL & "    K4903_SizeQty07      =  " & FormatSQL(z4903.SizeQty07) & ", " 
    SQL = SQL & "    K4903_SizeQty08      =  " & FormatSQL(z4903.SizeQty08) & ", " 
    SQL = SQL & "    K4903_SizeQty09      =  " & FormatSQL(z4903.SizeQty09) & ", " 
    SQL = SQL & "    K4903_SizeQty10      =  " & FormatSQL(z4903.SizeQty10) & ", " 
    SQL = SQL & "    K4903_SizeQty11      =  " & FormatSQL(z4903.SizeQty11) & ", " 
    SQL = SQL & "    K4903_SizeQty12      =  " & FormatSQL(z4903.SizeQty12) & ", " 
    SQL = SQL & "    K4903_SizeQty13      =  " & FormatSQL(z4903.SizeQty13) & ", " 
    SQL = SQL & "    K4903_SizeQty14      =  " & FormatSQL(z4903.SizeQty14) & ", " 
    SQL = SQL & "    K4903_SizeQty15      =  " & FormatSQL(z4903.SizeQty15) & ", " 
    SQL = SQL & "    K4903_SizeQty16      =  " & FormatSQL(z4903.SizeQty16) & ", " 
    SQL = SQL & "    K4903_SizeQty17      =  " & FormatSQL(z4903.SizeQty17) & ", " 
    SQL = SQL & "    K4903_SizeQty18      =  " & FormatSQL(z4903.SizeQty18) & ", " 
    SQL = SQL & "    K4903_SizeQty19      =  " & FormatSQL(z4903.SizeQty19) & ", " 
    SQL = SQL & "    K4903_SizeQty20      =  " & FormatSQL(z4903.SizeQty20) & ", " 
    SQL = SQL & "    K4903_SizeQty21      =  " & FormatSQL(z4903.SizeQty21) & ", " 
    SQL = SQL & "    K4903_SizeQty22      =  " & FormatSQL(z4903.SizeQty22) & ", " 
    SQL = SQL & "    K4903_SizeQty23      =  " & FormatSQL(z4903.SizeQty23) & ", " 
    SQL = SQL & "    K4903_SizeQty24      =  " & FormatSQL(z4903.SizeQty24) & ", " 
    SQL = SQL & "    K4903_SizeQty25      =  " & FormatSQL(z4903.SizeQty25) & ", " 
    SQL = SQL & "    K4903_SizeQty26      =  " & FormatSQL(z4903.SizeQty26) & ", " 
    SQL = SQL & "    K4903_SizeQty27      =  " & FormatSQL(z4903.SizeQty27) & ", " 
    SQL = SQL & "    K4903_SizeQty28      =  " & FormatSQL(z4903.SizeQty28) & ", " 
    SQL = SQL & "    K4903_SizeQty29      =  " & FormatSQL(z4903.SizeQty29) & ", " 
    SQL = SQL & "    K4903_SizeQty30      =  " & FormatSQL(z4903.SizeQty30) & ", " 
    SQL = SQL & "    K4903_PriceS01      =  " & FormatSQL(z4903.PriceS01) & ", " 
    SQL = SQL & "    K4903_PriceS02      =  " & FormatSQL(z4903.PriceS02) & ", " 
    SQL = SQL & "    K4903_PriceS03      =  " & FormatSQL(z4903.PriceS03) & ", " 
    SQL = SQL & "    K4903_PriceS04      =  " & FormatSQL(z4903.PriceS04) & ", " 
    SQL = SQL & "    K4903_PriceS05      =  " & FormatSQL(z4903.PriceS05) & ", " 
    SQL = SQL & "    K4903_PriceS06      =  " & FormatSQL(z4903.PriceS06) & ", " 
    SQL = SQL & "    K4903_PriceS07      =  " & FormatSQL(z4903.PriceS07) & ", " 
    SQL = SQL & "    K4903_PriceS08      =  " & FormatSQL(z4903.PriceS08) & ", " 
    SQL = SQL & "    K4903_PriceS09      =  " & FormatSQL(z4903.PriceS09) & ", " 
    SQL = SQL & "    K4903_PriceS10      =  " & FormatSQL(z4903.PriceS10) & ", " 
    SQL = SQL & "    K4903_PriceS11      =  " & FormatSQL(z4903.PriceS11) & ", " 
    SQL = SQL & "    K4903_PriceS12      =  " & FormatSQL(z4903.PriceS12) & ", " 
    SQL = SQL & "    K4903_PriceS13      =  " & FormatSQL(z4903.PriceS13) & ", " 
    SQL = SQL & "    K4903_PriceS14      =  " & FormatSQL(z4903.PriceS14) & ", " 
    SQL = SQL & "    K4903_PriceS15      =  " & FormatSQL(z4903.PriceS15) & ", " 
    SQL = SQL & "    K4903_PriceS16      =  " & FormatSQL(z4903.PriceS16) & ", " 
    SQL = SQL & "    K4903_PriceS17      =  " & FormatSQL(z4903.PriceS17) & ", " 
    SQL = SQL & "    K4903_PriceS18      =  " & FormatSQL(z4903.PriceS18) & ", " 
    SQL = SQL & "    K4903_PriceS19      =  " & FormatSQL(z4903.PriceS19) & ", " 
    SQL = SQL & "    K4903_PriceS20      =  " & FormatSQL(z4903.PriceS20) & ", " 
    SQL = SQL & "    K4903_PriceS21      =  " & FormatSQL(z4903.PriceS21) & ", " 
    SQL = SQL & "    K4903_PriceS22      =  " & FormatSQL(z4903.PriceS22) & ", " 
    SQL = SQL & "    K4903_PriceS23      =  " & FormatSQL(z4903.PriceS23) & ", " 
    SQL = SQL & "    K4903_PriceS24      =  " & FormatSQL(z4903.PriceS24) & ", " 
    SQL = SQL & "    K4903_PriceS25      =  " & FormatSQL(z4903.PriceS25) & ", " 
    SQL = SQL & "    K4903_PriceS26      =  " & FormatSQL(z4903.PriceS26) & ", " 
    SQL = SQL & "    K4903_PriceS27      =  " & FormatSQL(z4903.PriceS27) & ", " 
    SQL = SQL & "    K4903_PriceS28      =  " & FormatSQL(z4903.PriceS28) & ", " 
    SQL = SQL & "    K4903_PriceS29      =  " & FormatSQL(z4903.PriceS29) & ", " 
    SQL = SQL & "    K4903_PriceS30      =  " & FormatSQL(z4903.PriceS30) & ", " 
    SQL = SQL & "    K4903_Remark      = N'" & FormatSQL(z4903.Remark) & "'  " 
    SQL = SQL & " WHERE K4903_ShippingWorkOrder		 = '" & z4903.ShippingWorkOrder & "' " 
    SQL = SQL & "   AND K4903_ShippingWorkOrderSeq		 = '" & z4903.ShippingWorkOrderSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK4903 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK4903",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK4903(z4903 As T4903_AREA) As Boolean
    DELETE_PFK4903 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK4903 "
    SQL = SQL & " WHERE K4903_ShippingWorkOrder		 = '" & z4903.ShippingWorkOrder & "' " 
    SQL = SQL & "   AND K4903_ShippingWorkOrderSeq		 = '" & z4903.ShippingWorkOrderSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK4903 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK4903",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D4903_CLEAR()
Try
    
   D4903.ShippingWorkOrder = ""
   D4903.ShippingWorkOrderSeq = ""
    D4903.SizeQty01 = 0 
    D4903.SizeQty02 = 0 
    D4903.SizeQty03 = 0 
    D4903.SizeQty04 = 0 
    D4903.SizeQty05 = 0 
    D4903.SizeQty06 = 0 
    D4903.SizeQty07 = 0 
    D4903.SizeQty08 = 0 
    D4903.SizeQty09 = 0 
    D4903.SizeQty10 = 0 
    D4903.SizeQty11 = 0 
    D4903.SizeQty12 = 0 
    D4903.SizeQty13 = 0 
    D4903.SizeQty14 = 0 
    D4903.SizeQty15 = 0 
    D4903.SizeQty16 = 0 
    D4903.SizeQty17 = 0 
    D4903.SizeQty18 = 0 
    D4903.SizeQty19 = 0 
    D4903.SizeQty20 = 0 
    D4903.SizeQty21 = 0 
    D4903.SizeQty22 = 0 
    D4903.SizeQty23 = 0 
    D4903.SizeQty24 = 0 
    D4903.SizeQty25 = 0 
    D4903.SizeQty26 = 0 
    D4903.SizeQty27 = 0 
    D4903.SizeQty28 = 0 
    D4903.SizeQty29 = 0 
    D4903.SizeQty30 = 0 
    D4903.PriceS01 = 0 
    D4903.PriceS02 = 0 
    D4903.PriceS03 = 0 
    D4903.PriceS04 = 0 
    D4903.PriceS05 = 0 
    D4903.PriceS06 = 0 
    D4903.PriceS07 = 0 
    D4903.PriceS08 = 0 
    D4903.PriceS09 = 0 
    D4903.PriceS10 = 0 
    D4903.PriceS11 = 0 
    D4903.PriceS12 = 0 
    D4903.PriceS13 = 0 
    D4903.PriceS14 = 0 
    D4903.PriceS15 = 0 
    D4903.PriceS16 = 0 
    D4903.PriceS17 = 0 
    D4903.PriceS18 = 0 
    D4903.PriceS19 = 0 
    D4903.PriceS20 = 0 
    D4903.PriceS21 = 0 
    D4903.PriceS22 = 0 
    D4903.PriceS23 = 0 
    D4903.PriceS24 = 0 
    D4903.PriceS25 = 0 
    D4903.PriceS26 = 0 
    D4903.PriceS27 = 0 
    D4903.PriceS28 = 0 
    D4903.PriceS29 = 0 
    D4903.PriceS30 = 0 
   D4903.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D4903_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x4903 As T4903_AREA)
Try
    
    x4903.ShippingWorkOrder = trim$(  x4903.ShippingWorkOrder)
    x4903.ShippingWorkOrderSeq = trim$(  x4903.ShippingWorkOrderSeq)
    x4903.SizeQty01 = trim$(  x4903.SizeQty01)
    x4903.SizeQty02 = trim$(  x4903.SizeQty02)
    x4903.SizeQty03 = trim$(  x4903.SizeQty03)
    x4903.SizeQty04 = trim$(  x4903.SizeQty04)
    x4903.SizeQty05 = trim$(  x4903.SizeQty05)
    x4903.SizeQty06 = trim$(  x4903.SizeQty06)
    x4903.SizeQty07 = trim$(  x4903.SizeQty07)
    x4903.SizeQty08 = trim$(  x4903.SizeQty08)
    x4903.SizeQty09 = trim$(  x4903.SizeQty09)
    x4903.SizeQty10 = trim$(  x4903.SizeQty10)
    x4903.SizeQty11 = trim$(  x4903.SizeQty11)
    x4903.SizeQty12 = trim$(  x4903.SizeQty12)
    x4903.SizeQty13 = trim$(  x4903.SizeQty13)
    x4903.SizeQty14 = trim$(  x4903.SizeQty14)
    x4903.SizeQty15 = trim$(  x4903.SizeQty15)
    x4903.SizeQty16 = trim$(  x4903.SizeQty16)
    x4903.SizeQty17 = trim$(  x4903.SizeQty17)
    x4903.SizeQty18 = trim$(  x4903.SizeQty18)
    x4903.SizeQty19 = trim$(  x4903.SizeQty19)
    x4903.SizeQty20 = trim$(  x4903.SizeQty20)
    x4903.SizeQty21 = trim$(  x4903.SizeQty21)
    x4903.SizeQty22 = trim$(  x4903.SizeQty22)
    x4903.SizeQty23 = trim$(  x4903.SizeQty23)
    x4903.SizeQty24 = trim$(  x4903.SizeQty24)
    x4903.SizeQty25 = trim$(  x4903.SizeQty25)
    x4903.SizeQty26 = trim$(  x4903.SizeQty26)
    x4903.SizeQty27 = trim$(  x4903.SizeQty27)
    x4903.SizeQty28 = trim$(  x4903.SizeQty28)
    x4903.SizeQty29 = trim$(  x4903.SizeQty29)
    x4903.SizeQty30 = trim$(  x4903.SizeQty30)
    x4903.PriceS01 = trim$(  x4903.PriceS01)
    x4903.PriceS02 = trim$(  x4903.PriceS02)
    x4903.PriceS03 = trim$(  x4903.PriceS03)
    x4903.PriceS04 = trim$(  x4903.PriceS04)
    x4903.PriceS05 = trim$(  x4903.PriceS05)
    x4903.PriceS06 = trim$(  x4903.PriceS06)
    x4903.PriceS07 = trim$(  x4903.PriceS07)
    x4903.PriceS08 = trim$(  x4903.PriceS08)
    x4903.PriceS09 = trim$(  x4903.PriceS09)
    x4903.PriceS10 = trim$(  x4903.PriceS10)
    x4903.PriceS11 = trim$(  x4903.PriceS11)
    x4903.PriceS12 = trim$(  x4903.PriceS12)
    x4903.PriceS13 = trim$(  x4903.PriceS13)
    x4903.PriceS14 = trim$(  x4903.PriceS14)
    x4903.PriceS15 = trim$(  x4903.PriceS15)
    x4903.PriceS16 = trim$(  x4903.PriceS16)
    x4903.PriceS17 = trim$(  x4903.PriceS17)
    x4903.PriceS18 = trim$(  x4903.PriceS18)
    x4903.PriceS19 = trim$(  x4903.PriceS19)
    x4903.PriceS20 = trim$(  x4903.PriceS20)
    x4903.PriceS21 = trim$(  x4903.PriceS21)
    x4903.PriceS22 = trim$(  x4903.PriceS22)
    x4903.PriceS23 = trim$(  x4903.PriceS23)
    x4903.PriceS24 = trim$(  x4903.PriceS24)
    x4903.PriceS25 = trim$(  x4903.PriceS25)
    x4903.PriceS26 = trim$(  x4903.PriceS26)
    x4903.PriceS27 = trim$(  x4903.PriceS27)
    x4903.PriceS28 = trim$(  x4903.PriceS28)
    x4903.PriceS29 = trim$(  x4903.PriceS29)
    x4903.PriceS30 = trim$(  x4903.PriceS30)
    x4903.Remark = trim$(  x4903.Remark)
     
    If trim$( x4903.ShippingWorkOrder ) = "" Then x4903.ShippingWorkOrder = Space(1) 
    If trim$( x4903.ShippingWorkOrderSeq ) = "" Then x4903.ShippingWorkOrderSeq = Space(1) 
    If trim$( x4903.SizeQty01 ) = "" Then x4903.SizeQty01 = 0 
    If trim$( x4903.SizeQty02 ) = "" Then x4903.SizeQty02 = 0 
    If trim$( x4903.SizeQty03 ) = "" Then x4903.SizeQty03 = 0 
    If trim$( x4903.SizeQty04 ) = "" Then x4903.SizeQty04 = 0 
    If trim$( x4903.SizeQty05 ) = "" Then x4903.SizeQty05 = 0 
    If trim$( x4903.SizeQty06 ) = "" Then x4903.SizeQty06 = 0 
    If trim$( x4903.SizeQty07 ) = "" Then x4903.SizeQty07 = 0 
    If trim$( x4903.SizeQty08 ) = "" Then x4903.SizeQty08 = 0 
    If trim$( x4903.SizeQty09 ) = "" Then x4903.SizeQty09 = 0 
    If trim$( x4903.SizeQty10 ) = "" Then x4903.SizeQty10 = 0 
    If trim$( x4903.SizeQty11 ) = "" Then x4903.SizeQty11 = 0 
    If trim$( x4903.SizeQty12 ) = "" Then x4903.SizeQty12 = 0 
    If trim$( x4903.SizeQty13 ) = "" Then x4903.SizeQty13 = 0 
    If trim$( x4903.SizeQty14 ) = "" Then x4903.SizeQty14 = 0 
    If trim$( x4903.SizeQty15 ) = "" Then x4903.SizeQty15 = 0 
    If trim$( x4903.SizeQty16 ) = "" Then x4903.SizeQty16 = 0 
    If trim$( x4903.SizeQty17 ) = "" Then x4903.SizeQty17 = 0 
    If trim$( x4903.SizeQty18 ) = "" Then x4903.SizeQty18 = 0 
    If trim$( x4903.SizeQty19 ) = "" Then x4903.SizeQty19 = 0 
    If trim$( x4903.SizeQty20 ) = "" Then x4903.SizeQty20 = 0 
    If trim$( x4903.SizeQty21 ) = "" Then x4903.SizeQty21 = 0 
    If trim$( x4903.SizeQty22 ) = "" Then x4903.SizeQty22 = 0 
    If trim$( x4903.SizeQty23 ) = "" Then x4903.SizeQty23 = 0 
    If trim$( x4903.SizeQty24 ) = "" Then x4903.SizeQty24 = 0 
    If trim$( x4903.SizeQty25 ) = "" Then x4903.SizeQty25 = 0 
    If trim$( x4903.SizeQty26 ) = "" Then x4903.SizeQty26 = 0 
    If trim$( x4903.SizeQty27 ) = "" Then x4903.SizeQty27 = 0 
    If trim$( x4903.SizeQty28 ) = "" Then x4903.SizeQty28 = 0 
    If trim$( x4903.SizeQty29 ) = "" Then x4903.SizeQty29 = 0 
    If trim$( x4903.SizeQty30 ) = "" Then x4903.SizeQty30 = 0 
    If trim$( x4903.PriceS01 ) = "" Then x4903.PriceS01 = 0 
    If trim$( x4903.PriceS02 ) = "" Then x4903.PriceS02 = 0 
    If trim$( x4903.PriceS03 ) = "" Then x4903.PriceS03 = 0 
    If trim$( x4903.PriceS04 ) = "" Then x4903.PriceS04 = 0 
    If trim$( x4903.PriceS05 ) = "" Then x4903.PriceS05 = 0 
    If trim$( x4903.PriceS06 ) = "" Then x4903.PriceS06 = 0 
    If trim$( x4903.PriceS07 ) = "" Then x4903.PriceS07 = 0 
    If trim$( x4903.PriceS08 ) = "" Then x4903.PriceS08 = 0 
    If trim$( x4903.PriceS09 ) = "" Then x4903.PriceS09 = 0 
    If trim$( x4903.PriceS10 ) = "" Then x4903.PriceS10 = 0 
    If trim$( x4903.PriceS11 ) = "" Then x4903.PriceS11 = 0 
    If trim$( x4903.PriceS12 ) = "" Then x4903.PriceS12 = 0 
    If trim$( x4903.PriceS13 ) = "" Then x4903.PriceS13 = 0 
    If trim$( x4903.PriceS14 ) = "" Then x4903.PriceS14 = 0 
    If trim$( x4903.PriceS15 ) = "" Then x4903.PriceS15 = 0 
    If trim$( x4903.PriceS16 ) = "" Then x4903.PriceS16 = 0 
    If trim$( x4903.PriceS17 ) = "" Then x4903.PriceS17 = 0 
    If trim$( x4903.PriceS18 ) = "" Then x4903.PriceS18 = 0 
    If trim$( x4903.PriceS19 ) = "" Then x4903.PriceS19 = 0 
    If trim$( x4903.PriceS20 ) = "" Then x4903.PriceS20 = 0 
    If trim$( x4903.PriceS21 ) = "" Then x4903.PriceS21 = 0 
    If trim$( x4903.PriceS22 ) = "" Then x4903.PriceS22 = 0 
    If trim$( x4903.PriceS23 ) = "" Then x4903.PriceS23 = 0 
    If trim$( x4903.PriceS24 ) = "" Then x4903.PriceS24 = 0 
    If trim$( x4903.PriceS25 ) = "" Then x4903.PriceS25 = 0 
    If trim$( x4903.PriceS26 ) = "" Then x4903.PriceS26 = 0 
    If trim$( x4903.PriceS27 ) = "" Then x4903.PriceS27 = 0 
    If trim$( x4903.PriceS28 ) = "" Then x4903.PriceS28 = 0 
    If trim$( x4903.PriceS29 ) = "" Then x4903.PriceS29 = 0 
    If trim$( x4903.PriceS30 ) = "" Then x4903.PriceS30 = 0 
    If trim$( x4903.Remark ) = "" Then x4903.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K4903_MOVE(rs4903 As SqlClient.SqlDataReader)
Try

    call D4903_CLEAR()   

    If IsdbNull(rs4903!K4903_ShippingWorkOrder) = False Then D4903.ShippingWorkOrder = Trim$(rs4903!K4903_ShippingWorkOrder)
    If IsdbNull(rs4903!K4903_ShippingWorkOrderSeq) = False Then D4903.ShippingWorkOrderSeq = Trim$(rs4903!K4903_ShippingWorkOrderSeq)
    If IsdbNull(rs4903!K4903_SizeQty01) = False Then D4903.SizeQty01 = Trim$(rs4903!K4903_SizeQty01)
    If IsdbNull(rs4903!K4903_SizeQty02) = False Then D4903.SizeQty02 = Trim$(rs4903!K4903_SizeQty02)
    If IsdbNull(rs4903!K4903_SizeQty03) = False Then D4903.SizeQty03 = Trim$(rs4903!K4903_SizeQty03)
    If IsdbNull(rs4903!K4903_SizeQty04) = False Then D4903.SizeQty04 = Trim$(rs4903!K4903_SizeQty04)
    If IsdbNull(rs4903!K4903_SizeQty05) = False Then D4903.SizeQty05 = Trim$(rs4903!K4903_SizeQty05)
    If IsdbNull(rs4903!K4903_SizeQty06) = False Then D4903.SizeQty06 = Trim$(rs4903!K4903_SizeQty06)
    If IsdbNull(rs4903!K4903_SizeQty07) = False Then D4903.SizeQty07 = Trim$(rs4903!K4903_SizeQty07)
    If IsdbNull(rs4903!K4903_SizeQty08) = False Then D4903.SizeQty08 = Trim$(rs4903!K4903_SizeQty08)
    If IsdbNull(rs4903!K4903_SizeQty09) = False Then D4903.SizeQty09 = Trim$(rs4903!K4903_SizeQty09)
    If IsdbNull(rs4903!K4903_SizeQty10) = False Then D4903.SizeQty10 = Trim$(rs4903!K4903_SizeQty10)
    If IsdbNull(rs4903!K4903_SizeQty11) = False Then D4903.SizeQty11 = Trim$(rs4903!K4903_SizeQty11)
    If IsdbNull(rs4903!K4903_SizeQty12) = False Then D4903.SizeQty12 = Trim$(rs4903!K4903_SizeQty12)
    If IsdbNull(rs4903!K4903_SizeQty13) = False Then D4903.SizeQty13 = Trim$(rs4903!K4903_SizeQty13)
    If IsdbNull(rs4903!K4903_SizeQty14) = False Then D4903.SizeQty14 = Trim$(rs4903!K4903_SizeQty14)
    If IsdbNull(rs4903!K4903_SizeQty15) = False Then D4903.SizeQty15 = Trim$(rs4903!K4903_SizeQty15)
    If IsdbNull(rs4903!K4903_SizeQty16) = False Then D4903.SizeQty16 = Trim$(rs4903!K4903_SizeQty16)
    If IsdbNull(rs4903!K4903_SizeQty17) = False Then D4903.SizeQty17 = Trim$(rs4903!K4903_SizeQty17)
    If IsdbNull(rs4903!K4903_SizeQty18) = False Then D4903.SizeQty18 = Trim$(rs4903!K4903_SizeQty18)
    If IsdbNull(rs4903!K4903_SizeQty19) = False Then D4903.SizeQty19 = Trim$(rs4903!K4903_SizeQty19)
    If IsdbNull(rs4903!K4903_SizeQty20) = False Then D4903.SizeQty20 = Trim$(rs4903!K4903_SizeQty20)
    If IsdbNull(rs4903!K4903_SizeQty21) = False Then D4903.SizeQty21 = Trim$(rs4903!K4903_SizeQty21)
    If IsdbNull(rs4903!K4903_SizeQty22) = False Then D4903.SizeQty22 = Trim$(rs4903!K4903_SizeQty22)
    If IsdbNull(rs4903!K4903_SizeQty23) = False Then D4903.SizeQty23 = Trim$(rs4903!K4903_SizeQty23)
    If IsdbNull(rs4903!K4903_SizeQty24) = False Then D4903.SizeQty24 = Trim$(rs4903!K4903_SizeQty24)
    If IsdbNull(rs4903!K4903_SizeQty25) = False Then D4903.SizeQty25 = Trim$(rs4903!K4903_SizeQty25)
    If IsdbNull(rs4903!K4903_SizeQty26) = False Then D4903.SizeQty26 = Trim$(rs4903!K4903_SizeQty26)
    If IsdbNull(rs4903!K4903_SizeQty27) = False Then D4903.SizeQty27 = Trim$(rs4903!K4903_SizeQty27)
    If IsdbNull(rs4903!K4903_SizeQty28) = False Then D4903.SizeQty28 = Trim$(rs4903!K4903_SizeQty28)
    If IsdbNull(rs4903!K4903_SizeQty29) = False Then D4903.SizeQty29 = Trim$(rs4903!K4903_SizeQty29)
    If IsdbNull(rs4903!K4903_SizeQty30) = False Then D4903.SizeQty30 = Trim$(rs4903!K4903_SizeQty30)
    If IsdbNull(rs4903!K4903_PriceS01) = False Then D4903.PriceS01 = Trim$(rs4903!K4903_PriceS01)
    If IsdbNull(rs4903!K4903_PriceS02) = False Then D4903.PriceS02 = Trim$(rs4903!K4903_PriceS02)
    If IsdbNull(rs4903!K4903_PriceS03) = False Then D4903.PriceS03 = Trim$(rs4903!K4903_PriceS03)
    If IsdbNull(rs4903!K4903_PriceS04) = False Then D4903.PriceS04 = Trim$(rs4903!K4903_PriceS04)
    If IsdbNull(rs4903!K4903_PriceS05) = False Then D4903.PriceS05 = Trim$(rs4903!K4903_PriceS05)
    If IsdbNull(rs4903!K4903_PriceS06) = False Then D4903.PriceS06 = Trim$(rs4903!K4903_PriceS06)
    If IsdbNull(rs4903!K4903_PriceS07) = False Then D4903.PriceS07 = Trim$(rs4903!K4903_PriceS07)
    If IsdbNull(rs4903!K4903_PriceS08) = False Then D4903.PriceS08 = Trim$(rs4903!K4903_PriceS08)
    If IsdbNull(rs4903!K4903_PriceS09) = False Then D4903.PriceS09 = Trim$(rs4903!K4903_PriceS09)
    If IsdbNull(rs4903!K4903_PriceS10) = False Then D4903.PriceS10 = Trim$(rs4903!K4903_PriceS10)
    If IsdbNull(rs4903!K4903_PriceS11) = False Then D4903.PriceS11 = Trim$(rs4903!K4903_PriceS11)
    If IsdbNull(rs4903!K4903_PriceS12) = False Then D4903.PriceS12 = Trim$(rs4903!K4903_PriceS12)
    If IsdbNull(rs4903!K4903_PriceS13) = False Then D4903.PriceS13 = Trim$(rs4903!K4903_PriceS13)
    If IsdbNull(rs4903!K4903_PriceS14) = False Then D4903.PriceS14 = Trim$(rs4903!K4903_PriceS14)
    If IsdbNull(rs4903!K4903_PriceS15) = False Then D4903.PriceS15 = Trim$(rs4903!K4903_PriceS15)
    If IsdbNull(rs4903!K4903_PriceS16) = False Then D4903.PriceS16 = Trim$(rs4903!K4903_PriceS16)
    If IsdbNull(rs4903!K4903_PriceS17) = False Then D4903.PriceS17 = Trim$(rs4903!K4903_PriceS17)
    If IsdbNull(rs4903!K4903_PriceS18) = False Then D4903.PriceS18 = Trim$(rs4903!K4903_PriceS18)
    If IsdbNull(rs4903!K4903_PriceS19) = False Then D4903.PriceS19 = Trim$(rs4903!K4903_PriceS19)
    If IsdbNull(rs4903!K4903_PriceS20) = False Then D4903.PriceS20 = Trim$(rs4903!K4903_PriceS20)
    If IsdbNull(rs4903!K4903_PriceS21) = False Then D4903.PriceS21 = Trim$(rs4903!K4903_PriceS21)
    If IsdbNull(rs4903!K4903_PriceS22) = False Then D4903.PriceS22 = Trim$(rs4903!K4903_PriceS22)
    If IsdbNull(rs4903!K4903_PriceS23) = False Then D4903.PriceS23 = Trim$(rs4903!K4903_PriceS23)
    If IsdbNull(rs4903!K4903_PriceS24) = False Then D4903.PriceS24 = Trim$(rs4903!K4903_PriceS24)
    If IsdbNull(rs4903!K4903_PriceS25) = False Then D4903.PriceS25 = Trim$(rs4903!K4903_PriceS25)
    If IsdbNull(rs4903!K4903_PriceS26) = False Then D4903.PriceS26 = Trim$(rs4903!K4903_PriceS26)
    If IsdbNull(rs4903!K4903_PriceS27) = False Then D4903.PriceS27 = Trim$(rs4903!K4903_PriceS27)
    If IsdbNull(rs4903!K4903_PriceS28) = False Then D4903.PriceS28 = Trim$(rs4903!K4903_PriceS28)
    If IsdbNull(rs4903!K4903_PriceS29) = False Then D4903.PriceS29 = Trim$(rs4903!K4903_PriceS29)
    If IsdbNull(rs4903!K4903_PriceS30) = False Then D4903.PriceS30 = Trim$(rs4903!K4903_PriceS30)
    If IsdbNull(rs4903!K4903_Remark) = False Then D4903.Remark = Trim$(rs4903!K4903_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4903_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K4903_MOVE(rs4903 As DataRow)
Try

    call D4903_CLEAR()   

    If IsdbNull(rs4903!K4903_ShippingWorkOrder) = False Then D4903.ShippingWorkOrder = Trim$(rs4903!K4903_ShippingWorkOrder)
    If IsdbNull(rs4903!K4903_ShippingWorkOrderSeq) = False Then D4903.ShippingWorkOrderSeq = Trim$(rs4903!K4903_ShippingWorkOrderSeq)
    If IsdbNull(rs4903!K4903_SizeQty01) = False Then D4903.SizeQty01 = Trim$(rs4903!K4903_SizeQty01)
    If IsdbNull(rs4903!K4903_SizeQty02) = False Then D4903.SizeQty02 = Trim$(rs4903!K4903_SizeQty02)
    If IsdbNull(rs4903!K4903_SizeQty03) = False Then D4903.SizeQty03 = Trim$(rs4903!K4903_SizeQty03)
    If IsdbNull(rs4903!K4903_SizeQty04) = False Then D4903.SizeQty04 = Trim$(rs4903!K4903_SizeQty04)
    If IsdbNull(rs4903!K4903_SizeQty05) = False Then D4903.SizeQty05 = Trim$(rs4903!K4903_SizeQty05)
    If IsdbNull(rs4903!K4903_SizeQty06) = False Then D4903.SizeQty06 = Trim$(rs4903!K4903_SizeQty06)
    If IsdbNull(rs4903!K4903_SizeQty07) = False Then D4903.SizeQty07 = Trim$(rs4903!K4903_SizeQty07)
    If IsdbNull(rs4903!K4903_SizeQty08) = False Then D4903.SizeQty08 = Trim$(rs4903!K4903_SizeQty08)
    If IsdbNull(rs4903!K4903_SizeQty09) = False Then D4903.SizeQty09 = Trim$(rs4903!K4903_SizeQty09)
    If IsdbNull(rs4903!K4903_SizeQty10) = False Then D4903.SizeQty10 = Trim$(rs4903!K4903_SizeQty10)
    If IsdbNull(rs4903!K4903_SizeQty11) = False Then D4903.SizeQty11 = Trim$(rs4903!K4903_SizeQty11)
    If IsdbNull(rs4903!K4903_SizeQty12) = False Then D4903.SizeQty12 = Trim$(rs4903!K4903_SizeQty12)
    If IsdbNull(rs4903!K4903_SizeQty13) = False Then D4903.SizeQty13 = Trim$(rs4903!K4903_SizeQty13)
    If IsdbNull(rs4903!K4903_SizeQty14) = False Then D4903.SizeQty14 = Trim$(rs4903!K4903_SizeQty14)
    If IsdbNull(rs4903!K4903_SizeQty15) = False Then D4903.SizeQty15 = Trim$(rs4903!K4903_SizeQty15)
    If IsdbNull(rs4903!K4903_SizeQty16) = False Then D4903.SizeQty16 = Trim$(rs4903!K4903_SizeQty16)
    If IsdbNull(rs4903!K4903_SizeQty17) = False Then D4903.SizeQty17 = Trim$(rs4903!K4903_SizeQty17)
    If IsdbNull(rs4903!K4903_SizeQty18) = False Then D4903.SizeQty18 = Trim$(rs4903!K4903_SizeQty18)
    If IsdbNull(rs4903!K4903_SizeQty19) = False Then D4903.SizeQty19 = Trim$(rs4903!K4903_SizeQty19)
    If IsdbNull(rs4903!K4903_SizeQty20) = False Then D4903.SizeQty20 = Trim$(rs4903!K4903_SizeQty20)
    If IsdbNull(rs4903!K4903_SizeQty21) = False Then D4903.SizeQty21 = Trim$(rs4903!K4903_SizeQty21)
    If IsdbNull(rs4903!K4903_SizeQty22) = False Then D4903.SizeQty22 = Trim$(rs4903!K4903_SizeQty22)
    If IsdbNull(rs4903!K4903_SizeQty23) = False Then D4903.SizeQty23 = Trim$(rs4903!K4903_SizeQty23)
    If IsdbNull(rs4903!K4903_SizeQty24) = False Then D4903.SizeQty24 = Trim$(rs4903!K4903_SizeQty24)
    If IsdbNull(rs4903!K4903_SizeQty25) = False Then D4903.SizeQty25 = Trim$(rs4903!K4903_SizeQty25)
    If IsdbNull(rs4903!K4903_SizeQty26) = False Then D4903.SizeQty26 = Trim$(rs4903!K4903_SizeQty26)
    If IsdbNull(rs4903!K4903_SizeQty27) = False Then D4903.SizeQty27 = Trim$(rs4903!K4903_SizeQty27)
    If IsdbNull(rs4903!K4903_SizeQty28) = False Then D4903.SizeQty28 = Trim$(rs4903!K4903_SizeQty28)
    If IsdbNull(rs4903!K4903_SizeQty29) = False Then D4903.SizeQty29 = Trim$(rs4903!K4903_SizeQty29)
    If IsdbNull(rs4903!K4903_SizeQty30) = False Then D4903.SizeQty30 = Trim$(rs4903!K4903_SizeQty30)
    If IsdbNull(rs4903!K4903_PriceS01) = False Then D4903.PriceS01 = Trim$(rs4903!K4903_PriceS01)
    If IsdbNull(rs4903!K4903_PriceS02) = False Then D4903.PriceS02 = Trim$(rs4903!K4903_PriceS02)
    If IsdbNull(rs4903!K4903_PriceS03) = False Then D4903.PriceS03 = Trim$(rs4903!K4903_PriceS03)
    If IsdbNull(rs4903!K4903_PriceS04) = False Then D4903.PriceS04 = Trim$(rs4903!K4903_PriceS04)
    If IsdbNull(rs4903!K4903_PriceS05) = False Then D4903.PriceS05 = Trim$(rs4903!K4903_PriceS05)
    If IsdbNull(rs4903!K4903_PriceS06) = False Then D4903.PriceS06 = Trim$(rs4903!K4903_PriceS06)
    If IsdbNull(rs4903!K4903_PriceS07) = False Then D4903.PriceS07 = Trim$(rs4903!K4903_PriceS07)
    If IsdbNull(rs4903!K4903_PriceS08) = False Then D4903.PriceS08 = Trim$(rs4903!K4903_PriceS08)
    If IsdbNull(rs4903!K4903_PriceS09) = False Then D4903.PriceS09 = Trim$(rs4903!K4903_PriceS09)
    If IsdbNull(rs4903!K4903_PriceS10) = False Then D4903.PriceS10 = Trim$(rs4903!K4903_PriceS10)
    If IsdbNull(rs4903!K4903_PriceS11) = False Then D4903.PriceS11 = Trim$(rs4903!K4903_PriceS11)
    If IsdbNull(rs4903!K4903_PriceS12) = False Then D4903.PriceS12 = Trim$(rs4903!K4903_PriceS12)
    If IsdbNull(rs4903!K4903_PriceS13) = False Then D4903.PriceS13 = Trim$(rs4903!K4903_PriceS13)
    If IsdbNull(rs4903!K4903_PriceS14) = False Then D4903.PriceS14 = Trim$(rs4903!K4903_PriceS14)
    If IsdbNull(rs4903!K4903_PriceS15) = False Then D4903.PriceS15 = Trim$(rs4903!K4903_PriceS15)
    If IsdbNull(rs4903!K4903_PriceS16) = False Then D4903.PriceS16 = Trim$(rs4903!K4903_PriceS16)
    If IsdbNull(rs4903!K4903_PriceS17) = False Then D4903.PriceS17 = Trim$(rs4903!K4903_PriceS17)
    If IsdbNull(rs4903!K4903_PriceS18) = False Then D4903.PriceS18 = Trim$(rs4903!K4903_PriceS18)
    If IsdbNull(rs4903!K4903_PriceS19) = False Then D4903.PriceS19 = Trim$(rs4903!K4903_PriceS19)
    If IsdbNull(rs4903!K4903_PriceS20) = False Then D4903.PriceS20 = Trim$(rs4903!K4903_PriceS20)
    If IsdbNull(rs4903!K4903_PriceS21) = False Then D4903.PriceS21 = Trim$(rs4903!K4903_PriceS21)
    If IsdbNull(rs4903!K4903_PriceS22) = False Then D4903.PriceS22 = Trim$(rs4903!K4903_PriceS22)
    If IsdbNull(rs4903!K4903_PriceS23) = False Then D4903.PriceS23 = Trim$(rs4903!K4903_PriceS23)
    If IsdbNull(rs4903!K4903_PriceS24) = False Then D4903.PriceS24 = Trim$(rs4903!K4903_PriceS24)
    If IsdbNull(rs4903!K4903_PriceS25) = False Then D4903.PriceS25 = Trim$(rs4903!K4903_PriceS25)
    If IsdbNull(rs4903!K4903_PriceS26) = False Then D4903.PriceS26 = Trim$(rs4903!K4903_PriceS26)
    If IsdbNull(rs4903!K4903_PriceS27) = False Then D4903.PriceS27 = Trim$(rs4903!K4903_PriceS27)
    If IsdbNull(rs4903!K4903_PriceS28) = False Then D4903.PriceS28 = Trim$(rs4903!K4903_PriceS28)
    If IsdbNull(rs4903!K4903_PriceS29) = False Then D4903.PriceS29 = Trim$(rs4903!K4903_PriceS29)
    If IsdbNull(rs4903!K4903_PriceS30) = False Then D4903.PriceS30 = Trim$(rs4903!K4903_PriceS30)
    If IsdbNull(rs4903!K4903_Remark) = False Then D4903.Remark = Trim$(rs4903!K4903_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4903_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K4903_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4903 As T4903_AREA, SHIPPINGWORKORDER AS String, SHIPPINGWORKORDERSEQ AS String) as Boolean

K4903_MOVE = False

Try
    If READ_PFK4903(SHIPPINGWORKORDER, SHIPPINGWORKORDERSEQ) = True Then
                z4903 = D4903
		K4903_MOVE = True
		else
	z4903 = nothing
     End If

     If  getColumIndex(spr,"ShippingWorkOrder") > -1 then z4903.ShippingWorkOrder = getDataM(spr, getColumIndex(spr,"ShippingWorkOrder"), xRow)
     If  getColumIndex(spr,"ShippingWorkOrderSeq") > -1 then z4903.ShippingWorkOrderSeq = getDataM(spr, getColumIndex(spr,"ShippingWorkOrderSeq"), xRow)
     If  getColumIndex(spr,"SizeQty01") > -1 then z4903.SizeQty01 = getDataM(spr, getColumIndex(spr,"SizeQty01"), xRow)
     If  getColumIndex(spr,"SizeQty02") > -1 then z4903.SizeQty02 = getDataM(spr, getColumIndex(spr,"SizeQty02"), xRow)
     If  getColumIndex(spr,"SizeQty03") > -1 then z4903.SizeQty03 = getDataM(spr, getColumIndex(spr,"SizeQty03"), xRow)
     If  getColumIndex(spr,"SizeQty04") > -1 then z4903.SizeQty04 = getDataM(spr, getColumIndex(spr,"SizeQty04"), xRow)
     If  getColumIndex(spr,"SizeQty05") > -1 then z4903.SizeQty05 = getDataM(spr, getColumIndex(spr,"SizeQty05"), xRow)
     If  getColumIndex(spr,"SizeQty06") > -1 then z4903.SizeQty06 = getDataM(spr, getColumIndex(spr,"SizeQty06"), xRow)
     If  getColumIndex(spr,"SizeQty07") > -1 then z4903.SizeQty07 = getDataM(spr, getColumIndex(spr,"SizeQty07"), xRow)
     If  getColumIndex(spr,"SizeQty08") > -1 then z4903.SizeQty08 = getDataM(spr, getColumIndex(spr,"SizeQty08"), xRow)
     If  getColumIndex(spr,"SizeQty09") > -1 then z4903.SizeQty09 = getDataM(spr, getColumIndex(spr,"SizeQty09"), xRow)
     If  getColumIndex(spr,"SizeQty10") > -1 then z4903.SizeQty10 = getDataM(spr, getColumIndex(spr,"SizeQty10"), xRow)
     If  getColumIndex(spr,"SizeQty11") > -1 then z4903.SizeQty11 = getDataM(spr, getColumIndex(spr,"SizeQty11"), xRow)
     If  getColumIndex(spr,"SizeQty12") > -1 then z4903.SizeQty12 = getDataM(spr, getColumIndex(spr,"SizeQty12"), xRow)
     If  getColumIndex(spr,"SizeQty13") > -1 then z4903.SizeQty13 = getDataM(spr, getColumIndex(spr,"SizeQty13"), xRow)
     If  getColumIndex(spr,"SizeQty14") > -1 then z4903.SizeQty14 = getDataM(spr, getColumIndex(spr,"SizeQty14"), xRow)
     If  getColumIndex(spr,"SizeQty15") > -1 then z4903.SizeQty15 = getDataM(spr, getColumIndex(spr,"SizeQty15"), xRow)
     If  getColumIndex(spr,"SizeQty16") > -1 then z4903.SizeQty16 = getDataM(spr, getColumIndex(spr,"SizeQty16"), xRow)
     If  getColumIndex(spr,"SizeQty17") > -1 then z4903.SizeQty17 = getDataM(spr, getColumIndex(spr,"SizeQty17"), xRow)
     If  getColumIndex(spr,"SizeQty18") > -1 then z4903.SizeQty18 = getDataM(spr, getColumIndex(spr,"SizeQty18"), xRow)
     If  getColumIndex(spr,"SizeQty19") > -1 then z4903.SizeQty19 = getDataM(spr, getColumIndex(spr,"SizeQty19"), xRow)
     If  getColumIndex(spr,"SizeQty20") > -1 then z4903.SizeQty20 = getDataM(spr, getColumIndex(spr,"SizeQty20"), xRow)
     If  getColumIndex(spr,"SizeQty21") > -1 then z4903.SizeQty21 = getDataM(spr, getColumIndex(spr,"SizeQty21"), xRow)
     If  getColumIndex(spr,"SizeQty22") > -1 then z4903.SizeQty22 = getDataM(spr, getColumIndex(spr,"SizeQty22"), xRow)
     If  getColumIndex(spr,"SizeQty23") > -1 then z4903.SizeQty23 = getDataM(spr, getColumIndex(spr,"SizeQty23"), xRow)
     If  getColumIndex(spr,"SizeQty24") > -1 then z4903.SizeQty24 = getDataM(spr, getColumIndex(spr,"SizeQty24"), xRow)
     If  getColumIndex(spr,"SizeQty25") > -1 then z4903.SizeQty25 = getDataM(spr, getColumIndex(spr,"SizeQty25"), xRow)
     If  getColumIndex(spr,"SizeQty26") > -1 then z4903.SizeQty26 = getDataM(spr, getColumIndex(spr,"SizeQty26"), xRow)
     If  getColumIndex(spr,"SizeQty27") > -1 then z4903.SizeQty27 = getDataM(spr, getColumIndex(spr,"SizeQty27"), xRow)
     If  getColumIndex(spr,"SizeQty28") > -1 then z4903.SizeQty28 = getDataM(spr, getColumIndex(spr,"SizeQty28"), xRow)
     If  getColumIndex(spr,"SizeQty29") > -1 then z4903.SizeQty29 = getDataM(spr, getColumIndex(spr,"SizeQty29"), xRow)
     If  getColumIndex(spr,"SizeQty30") > -1 then z4903.SizeQty30 = getDataM(spr, getColumIndex(spr,"SizeQty30"), xRow)
     If  getColumIndex(spr,"PriceS01") > -1 then z4903.PriceS01 = getDataM(spr, getColumIndex(spr,"PriceS01"), xRow)
     If  getColumIndex(spr,"PriceS02") > -1 then z4903.PriceS02 = getDataM(spr, getColumIndex(spr,"PriceS02"), xRow)
     If  getColumIndex(spr,"PriceS03") > -1 then z4903.PriceS03 = getDataM(spr, getColumIndex(spr,"PriceS03"), xRow)
     If  getColumIndex(spr,"PriceS04") > -1 then z4903.PriceS04 = getDataM(spr, getColumIndex(spr,"PriceS04"), xRow)
     If  getColumIndex(spr,"PriceS05") > -1 then z4903.PriceS05 = getDataM(spr, getColumIndex(spr,"PriceS05"), xRow)
     If  getColumIndex(spr,"PriceS06") > -1 then z4903.PriceS06 = getDataM(spr, getColumIndex(spr,"PriceS06"), xRow)
     If  getColumIndex(spr,"PriceS07") > -1 then z4903.PriceS07 = getDataM(spr, getColumIndex(spr,"PriceS07"), xRow)
     If  getColumIndex(spr,"PriceS08") > -1 then z4903.PriceS08 = getDataM(spr, getColumIndex(spr,"PriceS08"), xRow)
     If  getColumIndex(spr,"PriceS09") > -1 then z4903.PriceS09 = getDataM(spr, getColumIndex(spr,"PriceS09"), xRow)
     If  getColumIndex(spr,"PriceS10") > -1 then z4903.PriceS10 = getDataM(spr, getColumIndex(spr,"PriceS10"), xRow)
     If  getColumIndex(spr,"PriceS11") > -1 then z4903.PriceS11 = getDataM(spr, getColumIndex(spr,"PriceS11"), xRow)
     If  getColumIndex(spr,"PriceS12") > -1 then z4903.PriceS12 = getDataM(spr, getColumIndex(spr,"PriceS12"), xRow)
     If  getColumIndex(spr,"PriceS13") > -1 then z4903.PriceS13 = getDataM(spr, getColumIndex(spr,"PriceS13"), xRow)
     If  getColumIndex(spr,"PriceS14") > -1 then z4903.PriceS14 = getDataM(spr, getColumIndex(spr,"PriceS14"), xRow)
     If  getColumIndex(spr,"PriceS15") > -1 then z4903.PriceS15 = getDataM(spr, getColumIndex(spr,"PriceS15"), xRow)
     If  getColumIndex(spr,"PriceS16") > -1 then z4903.PriceS16 = getDataM(spr, getColumIndex(spr,"PriceS16"), xRow)
     If  getColumIndex(spr,"PriceS17") > -1 then z4903.PriceS17 = getDataM(spr, getColumIndex(spr,"PriceS17"), xRow)
     If  getColumIndex(spr,"PriceS18") > -1 then z4903.PriceS18 = getDataM(spr, getColumIndex(spr,"PriceS18"), xRow)
     If  getColumIndex(spr,"PriceS19") > -1 then z4903.PriceS19 = getDataM(spr, getColumIndex(spr,"PriceS19"), xRow)
     If  getColumIndex(spr,"PriceS20") > -1 then z4903.PriceS20 = getDataM(spr, getColumIndex(spr,"PriceS20"), xRow)
     If  getColumIndex(spr,"PriceS21") > -1 then z4903.PriceS21 = getDataM(spr, getColumIndex(spr,"PriceS21"), xRow)
     If  getColumIndex(spr,"PriceS22") > -1 then z4903.PriceS22 = getDataM(spr, getColumIndex(spr,"PriceS22"), xRow)
     If  getColumIndex(spr,"PriceS23") > -1 then z4903.PriceS23 = getDataM(spr, getColumIndex(spr,"PriceS23"), xRow)
     If  getColumIndex(spr,"PriceS24") > -1 then z4903.PriceS24 = getDataM(spr, getColumIndex(spr,"PriceS24"), xRow)
     If  getColumIndex(spr,"PriceS25") > -1 then z4903.PriceS25 = getDataM(spr, getColumIndex(spr,"PriceS25"), xRow)
     If  getColumIndex(spr,"PriceS26") > -1 then z4903.PriceS26 = getDataM(spr, getColumIndex(spr,"PriceS26"), xRow)
     If  getColumIndex(spr,"PriceS27") > -1 then z4903.PriceS27 = getDataM(spr, getColumIndex(spr,"PriceS27"), xRow)
     If  getColumIndex(spr,"PriceS28") > -1 then z4903.PriceS28 = getDataM(spr, getColumIndex(spr,"PriceS28"), xRow)
     If  getColumIndex(spr,"PriceS29") > -1 then z4903.PriceS29 = getDataM(spr, getColumIndex(spr,"PriceS29"), xRow)
     If  getColumIndex(spr,"PriceS30") > -1 then z4903.PriceS30 = getDataM(spr, getColumIndex(spr,"PriceS30"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4903.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4903_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K4903_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4903 As T4903_AREA,CheckClear as Boolean,SHIPPINGWORKORDER AS String, SHIPPINGWORKORDERSEQ AS String) as Boolean

K4903_MOVE = False

Try
    If READ_PFK4903(SHIPPINGWORKORDER, SHIPPINGWORKORDERSEQ) = True Then
                z4903 = D4903
		K4903_MOVE = True
		else
	If CheckClear  = True then z4903 = nothing
     End If

     If  getColumIndex(spr,"ShippingWorkOrder") > -1 then z4903.ShippingWorkOrder = getDataM(spr, getColumIndex(spr,"ShippingWorkOrder"), xRow)
     If  getColumIndex(spr,"ShippingWorkOrderSeq") > -1 then z4903.ShippingWorkOrderSeq = getDataM(spr, getColumIndex(spr,"ShippingWorkOrderSeq"), xRow)
     If  getColumIndex(spr,"SizeQty01") > -1 then z4903.SizeQty01 = getDataM(spr, getColumIndex(spr,"SizeQty01"), xRow)
     If  getColumIndex(spr,"SizeQty02") > -1 then z4903.SizeQty02 = getDataM(spr, getColumIndex(spr,"SizeQty02"), xRow)
     If  getColumIndex(spr,"SizeQty03") > -1 then z4903.SizeQty03 = getDataM(spr, getColumIndex(spr,"SizeQty03"), xRow)
     If  getColumIndex(spr,"SizeQty04") > -1 then z4903.SizeQty04 = getDataM(spr, getColumIndex(spr,"SizeQty04"), xRow)
     If  getColumIndex(spr,"SizeQty05") > -1 then z4903.SizeQty05 = getDataM(spr, getColumIndex(spr,"SizeQty05"), xRow)
     If  getColumIndex(spr,"SizeQty06") > -1 then z4903.SizeQty06 = getDataM(spr, getColumIndex(spr,"SizeQty06"), xRow)
     If  getColumIndex(spr,"SizeQty07") > -1 then z4903.SizeQty07 = getDataM(spr, getColumIndex(spr,"SizeQty07"), xRow)
     If  getColumIndex(spr,"SizeQty08") > -1 then z4903.SizeQty08 = getDataM(spr, getColumIndex(spr,"SizeQty08"), xRow)
     If  getColumIndex(spr,"SizeQty09") > -1 then z4903.SizeQty09 = getDataM(spr, getColumIndex(spr,"SizeQty09"), xRow)
     If  getColumIndex(spr,"SizeQty10") > -1 then z4903.SizeQty10 = getDataM(spr, getColumIndex(spr,"SizeQty10"), xRow)
     If  getColumIndex(spr,"SizeQty11") > -1 then z4903.SizeQty11 = getDataM(spr, getColumIndex(spr,"SizeQty11"), xRow)
     If  getColumIndex(spr,"SizeQty12") > -1 then z4903.SizeQty12 = getDataM(spr, getColumIndex(spr,"SizeQty12"), xRow)
     If  getColumIndex(spr,"SizeQty13") > -1 then z4903.SizeQty13 = getDataM(spr, getColumIndex(spr,"SizeQty13"), xRow)
     If  getColumIndex(spr,"SizeQty14") > -1 then z4903.SizeQty14 = getDataM(spr, getColumIndex(spr,"SizeQty14"), xRow)
     If  getColumIndex(spr,"SizeQty15") > -1 then z4903.SizeQty15 = getDataM(spr, getColumIndex(spr,"SizeQty15"), xRow)
     If  getColumIndex(spr,"SizeQty16") > -1 then z4903.SizeQty16 = getDataM(spr, getColumIndex(spr,"SizeQty16"), xRow)
     If  getColumIndex(spr,"SizeQty17") > -1 then z4903.SizeQty17 = getDataM(spr, getColumIndex(spr,"SizeQty17"), xRow)
     If  getColumIndex(spr,"SizeQty18") > -1 then z4903.SizeQty18 = getDataM(spr, getColumIndex(spr,"SizeQty18"), xRow)
     If  getColumIndex(spr,"SizeQty19") > -1 then z4903.SizeQty19 = getDataM(spr, getColumIndex(spr,"SizeQty19"), xRow)
     If  getColumIndex(spr,"SizeQty20") > -1 then z4903.SizeQty20 = getDataM(spr, getColumIndex(spr,"SizeQty20"), xRow)
     If  getColumIndex(spr,"SizeQty21") > -1 then z4903.SizeQty21 = getDataM(spr, getColumIndex(spr,"SizeQty21"), xRow)
     If  getColumIndex(spr,"SizeQty22") > -1 then z4903.SizeQty22 = getDataM(spr, getColumIndex(spr,"SizeQty22"), xRow)
     If  getColumIndex(spr,"SizeQty23") > -1 then z4903.SizeQty23 = getDataM(spr, getColumIndex(spr,"SizeQty23"), xRow)
     If  getColumIndex(spr,"SizeQty24") > -1 then z4903.SizeQty24 = getDataM(spr, getColumIndex(spr,"SizeQty24"), xRow)
     If  getColumIndex(spr,"SizeQty25") > -1 then z4903.SizeQty25 = getDataM(spr, getColumIndex(spr,"SizeQty25"), xRow)
     If  getColumIndex(spr,"SizeQty26") > -1 then z4903.SizeQty26 = getDataM(spr, getColumIndex(spr,"SizeQty26"), xRow)
     If  getColumIndex(spr,"SizeQty27") > -1 then z4903.SizeQty27 = getDataM(spr, getColumIndex(spr,"SizeQty27"), xRow)
     If  getColumIndex(spr,"SizeQty28") > -1 then z4903.SizeQty28 = getDataM(spr, getColumIndex(spr,"SizeQty28"), xRow)
     If  getColumIndex(spr,"SizeQty29") > -1 then z4903.SizeQty29 = getDataM(spr, getColumIndex(spr,"SizeQty29"), xRow)
     If  getColumIndex(spr,"SizeQty30") > -1 then z4903.SizeQty30 = getDataM(spr, getColumIndex(spr,"SizeQty30"), xRow)
     If  getColumIndex(spr,"PriceS01") > -1 then z4903.PriceS01 = getDataM(spr, getColumIndex(spr,"PriceS01"), xRow)
     If  getColumIndex(spr,"PriceS02") > -1 then z4903.PriceS02 = getDataM(spr, getColumIndex(spr,"PriceS02"), xRow)
     If  getColumIndex(spr,"PriceS03") > -1 then z4903.PriceS03 = getDataM(spr, getColumIndex(spr,"PriceS03"), xRow)
     If  getColumIndex(spr,"PriceS04") > -1 then z4903.PriceS04 = getDataM(spr, getColumIndex(spr,"PriceS04"), xRow)
     If  getColumIndex(spr,"PriceS05") > -1 then z4903.PriceS05 = getDataM(spr, getColumIndex(spr,"PriceS05"), xRow)
     If  getColumIndex(spr,"PriceS06") > -1 then z4903.PriceS06 = getDataM(spr, getColumIndex(spr,"PriceS06"), xRow)
     If  getColumIndex(spr,"PriceS07") > -1 then z4903.PriceS07 = getDataM(spr, getColumIndex(spr,"PriceS07"), xRow)
     If  getColumIndex(spr,"PriceS08") > -1 then z4903.PriceS08 = getDataM(spr, getColumIndex(spr,"PriceS08"), xRow)
     If  getColumIndex(spr,"PriceS09") > -1 then z4903.PriceS09 = getDataM(spr, getColumIndex(spr,"PriceS09"), xRow)
     If  getColumIndex(spr,"PriceS10") > -1 then z4903.PriceS10 = getDataM(spr, getColumIndex(spr,"PriceS10"), xRow)
     If  getColumIndex(spr,"PriceS11") > -1 then z4903.PriceS11 = getDataM(spr, getColumIndex(spr,"PriceS11"), xRow)
     If  getColumIndex(spr,"PriceS12") > -1 then z4903.PriceS12 = getDataM(spr, getColumIndex(spr,"PriceS12"), xRow)
     If  getColumIndex(spr,"PriceS13") > -1 then z4903.PriceS13 = getDataM(spr, getColumIndex(spr,"PriceS13"), xRow)
     If  getColumIndex(spr,"PriceS14") > -1 then z4903.PriceS14 = getDataM(spr, getColumIndex(spr,"PriceS14"), xRow)
     If  getColumIndex(spr,"PriceS15") > -1 then z4903.PriceS15 = getDataM(spr, getColumIndex(spr,"PriceS15"), xRow)
     If  getColumIndex(spr,"PriceS16") > -1 then z4903.PriceS16 = getDataM(spr, getColumIndex(spr,"PriceS16"), xRow)
     If  getColumIndex(spr,"PriceS17") > -1 then z4903.PriceS17 = getDataM(spr, getColumIndex(spr,"PriceS17"), xRow)
     If  getColumIndex(spr,"PriceS18") > -1 then z4903.PriceS18 = getDataM(spr, getColumIndex(spr,"PriceS18"), xRow)
     If  getColumIndex(spr,"PriceS19") > -1 then z4903.PriceS19 = getDataM(spr, getColumIndex(spr,"PriceS19"), xRow)
     If  getColumIndex(spr,"PriceS20") > -1 then z4903.PriceS20 = getDataM(spr, getColumIndex(spr,"PriceS20"), xRow)
     If  getColumIndex(spr,"PriceS21") > -1 then z4903.PriceS21 = getDataM(spr, getColumIndex(spr,"PriceS21"), xRow)
     If  getColumIndex(spr,"PriceS22") > -1 then z4903.PriceS22 = getDataM(spr, getColumIndex(spr,"PriceS22"), xRow)
     If  getColumIndex(spr,"PriceS23") > -1 then z4903.PriceS23 = getDataM(spr, getColumIndex(spr,"PriceS23"), xRow)
     If  getColumIndex(spr,"PriceS24") > -1 then z4903.PriceS24 = getDataM(spr, getColumIndex(spr,"PriceS24"), xRow)
     If  getColumIndex(spr,"PriceS25") > -1 then z4903.PriceS25 = getDataM(spr, getColumIndex(spr,"PriceS25"), xRow)
     If  getColumIndex(spr,"PriceS26") > -1 then z4903.PriceS26 = getDataM(spr, getColumIndex(spr,"PriceS26"), xRow)
     If  getColumIndex(spr,"PriceS27") > -1 then z4903.PriceS27 = getDataM(spr, getColumIndex(spr,"PriceS27"), xRow)
     If  getColumIndex(spr,"PriceS28") > -1 then z4903.PriceS28 = getDataM(spr, getColumIndex(spr,"PriceS28"), xRow)
     If  getColumIndex(spr,"PriceS29") > -1 then z4903.PriceS29 = getDataM(spr, getColumIndex(spr,"PriceS29"), xRow)
     If  getColumIndex(spr,"PriceS30") > -1 then z4903.PriceS30 = getDataM(spr, getColumIndex(spr,"PriceS30"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4903.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4903_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K4903_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4903 As T4903_AREA, Job as String, SHIPPINGWORKORDER AS String, SHIPPINGWORKORDERSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4903_MOVE = False

Try
    If READ_PFK4903(SHIPPINGWORKORDER, SHIPPINGWORKORDERSEQ) = True Then
                z4903 = D4903
		K4903_MOVE = True
		else
	z4903 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4903")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SHIPPINGWORKORDER":z4903.ShippingWorkOrder = Children(i).Code
   Case "SHIPPINGWORKORDERSEQ":z4903.ShippingWorkOrderSeq = Children(i).Code
   Case "SIZEQTY01":z4903.SizeQty01 = Children(i).Code
   Case "SIZEQTY02":z4903.SizeQty02 = Children(i).Code
   Case "SIZEQTY03":z4903.SizeQty03 = Children(i).Code
   Case "SIZEQTY04":z4903.SizeQty04 = Children(i).Code
   Case "SIZEQTY05":z4903.SizeQty05 = Children(i).Code
   Case "SIZEQTY06":z4903.SizeQty06 = Children(i).Code
   Case "SIZEQTY07":z4903.SizeQty07 = Children(i).Code
   Case "SIZEQTY08":z4903.SizeQty08 = Children(i).Code
   Case "SIZEQTY09":z4903.SizeQty09 = Children(i).Code
   Case "SIZEQTY10":z4903.SizeQty10 = Children(i).Code
   Case "SIZEQTY11":z4903.SizeQty11 = Children(i).Code
   Case "SIZEQTY12":z4903.SizeQty12 = Children(i).Code
   Case "SIZEQTY13":z4903.SizeQty13 = Children(i).Code
   Case "SIZEQTY14":z4903.SizeQty14 = Children(i).Code
   Case "SIZEQTY15":z4903.SizeQty15 = Children(i).Code
   Case "SIZEQTY16":z4903.SizeQty16 = Children(i).Code
   Case "SIZEQTY17":z4903.SizeQty17 = Children(i).Code
   Case "SIZEQTY18":z4903.SizeQty18 = Children(i).Code
   Case "SIZEQTY19":z4903.SizeQty19 = Children(i).Code
   Case "SIZEQTY20":z4903.SizeQty20 = Children(i).Code
   Case "SIZEQTY21":z4903.SizeQty21 = Children(i).Code
   Case "SIZEQTY22":z4903.SizeQty22 = Children(i).Code
   Case "SIZEQTY23":z4903.SizeQty23 = Children(i).Code
   Case "SIZEQTY24":z4903.SizeQty24 = Children(i).Code
   Case "SIZEQTY25":z4903.SizeQty25 = Children(i).Code
   Case "SIZEQTY26":z4903.SizeQty26 = Children(i).Code
   Case "SIZEQTY27":z4903.SizeQty27 = Children(i).Code
   Case "SIZEQTY28":z4903.SizeQty28 = Children(i).Code
   Case "SIZEQTY29":z4903.SizeQty29 = Children(i).Code
   Case "SIZEQTY30":z4903.SizeQty30 = Children(i).Code
   Case "PRICES01":z4903.PriceS01 = Children(i).Code
   Case "PRICES02":z4903.PriceS02 = Children(i).Code
   Case "PRICES03":z4903.PriceS03 = Children(i).Code
   Case "PRICES04":z4903.PriceS04 = Children(i).Code
   Case "PRICES05":z4903.PriceS05 = Children(i).Code
   Case "PRICES06":z4903.PriceS06 = Children(i).Code
   Case "PRICES07":z4903.PriceS07 = Children(i).Code
   Case "PRICES08":z4903.PriceS08 = Children(i).Code
   Case "PRICES09":z4903.PriceS09 = Children(i).Code
   Case "PRICES10":z4903.PriceS10 = Children(i).Code
   Case "PRICES11":z4903.PriceS11 = Children(i).Code
   Case "PRICES12":z4903.PriceS12 = Children(i).Code
   Case "PRICES13":z4903.PriceS13 = Children(i).Code
   Case "PRICES14":z4903.PriceS14 = Children(i).Code
   Case "PRICES15":z4903.PriceS15 = Children(i).Code
   Case "PRICES16":z4903.PriceS16 = Children(i).Code
   Case "PRICES17":z4903.PriceS17 = Children(i).Code
   Case "PRICES18":z4903.PriceS18 = Children(i).Code
   Case "PRICES19":z4903.PriceS19 = Children(i).Code
   Case "PRICES20":z4903.PriceS20 = Children(i).Code
   Case "PRICES21":z4903.PriceS21 = Children(i).Code
   Case "PRICES22":z4903.PriceS22 = Children(i).Code
   Case "PRICES23":z4903.PriceS23 = Children(i).Code
   Case "PRICES24":z4903.PriceS24 = Children(i).Code
   Case "PRICES25":z4903.PriceS25 = Children(i).Code
   Case "PRICES26":z4903.PriceS26 = Children(i).Code
   Case "PRICES27":z4903.PriceS27 = Children(i).Code
   Case "PRICES28":z4903.PriceS28 = Children(i).Code
   Case "PRICES29":z4903.PriceS29 = Children(i).Code
   Case "PRICES30":z4903.PriceS30 = Children(i).Code
   Case "REMARK":z4903.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SHIPPINGWORKORDER":z4903.ShippingWorkOrder = Children(i).Data
   Case "SHIPPINGWORKORDERSEQ":z4903.ShippingWorkOrderSeq = Children(i).Data
   Case "SIZEQTY01":z4903.SizeQty01 = Children(i).Data
   Case "SIZEQTY02":z4903.SizeQty02 = Children(i).Data
   Case "SIZEQTY03":z4903.SizeQty03 = Children(i).Data
   Case "SIZEQTY04":z4903.SizeQty04 = Children(i).Data
   Case "SIZEQTY05":z4903.SizeQty05 = Children(i).Data
   Case "SIZEQTY06":z4903.SizeQty06 = Children(i).Data
   Case "SIZEQTY07":z4903.SizeQty07 = Children(i).Data
   Case "SIZEQTY08":z4903.SizeQty08 = Children(i).Data
   Case "SIZEQTY09":z4903.SizeQty09 = Children(i).Data
   Case "SIZEQTY10":z4903.SizeQty10 = Children(i).Data
   Case "SIZEQTY11":z4903.SizeQty11 = Children(i).Data
   Case "SIZEQTY12":z4903.SizeQty12 = Children(i).Data
   Case "SIZEQTY13":z4903.SizeQty13 = Children(i).Data
   Case "SIZEQTY14":z4903.SizeQty14 = Children(i).Data
   Case "SIZEQTY15":z4903.SizeQty15 = Children(i).Data
   Case "SIZEQTY16":z4903.SizeQty16 = Children(i).Data
   Case "SIZEQTY17":z4903.SizeQty17 = Children(i).Data
   Case "SIZEQTY18":z4903.SizeQty18 = Children(i).Data
   Case "SIZEQTY19":z4903.SizeQty19 = Children(i).Data
   Case "SIZEQTY20":z4903.SizeQty20 = Children(i).Data
   Case "SIZEQTY21":z4903.SizeQty21 = Children(i).Data
   Case "SIZEQTY22":z4903.SizeQty22 = Children(i).Data
   Case "SIZEQTY23":z4903.SizeQty23 = Children(i).Data
   Case "SIZEQTY24":z4903.SizeQty24 = Children(i).Data
   Case "SIZEQTY25":z4903.SizeQty25 = Children(i).Data
   Case "SIZEQTY26":z4903.SizeQty26 = Children(i).Data
   Case "SIZEQTY27":z4903.SizeQty27 = Children(i).Data
   Case "SIZEQTY28":z4903.SizeQty28 = Children(i).Data
   Case "SIZEQTY29":z4903.SizeQty29 = Children(i).Data
   Case "SIZEQTY30":z4903.SizeQty30 = Children(i).Data
   Case "PRICES01":z4903.PriceS01 = Children(i).Data
   Case "PRICES02":z4903.PriceS02 = Children(i).Data
   Case "PRICES03":z4903.PriceS03 = Children(i).Data
   Case "PRICES04":z4903.PriceS04 = Children(i).Data
   Case "PRICES05":z4903.PriceS05 = Children(i).Data
   Case "PRICES06":z4903.PriceS06 = Children(i).Data
   Case "PRICES07":z4903.PriceS07 = Children(i).Data
   Case "PRICES08":z4903.PriceS08 = Children(i).Data
   Case "PRICES09":z4903.PriceS09 = Children(i).Data
   Case "PRICES10":z4903.PriceS10 = Children(i).Data
   Case "PRICES11":z4903.PriceS11 = Children(i).Data
   Case "PRICES12":z4903.PriceS12 = Children(i).Data
   Case "PRICES13":z4903.PriceS13 = Children(i).Data
   Case "PRICES14":z4903.PriceS14 = Children(i).Data
   Case "PRICES15":z4903.PriceS15 = Children(i).Data
   Case "PRICES16":z4903.PriceS16 = Children(i).Data
   Case "PRICES17":z4903.PriceS17 = Children(i).Data
   Case "PRICES18":z4903.PriceS18 = Children(i).Data
   Case "PRICES19":z4903.PriceS19 = Children(i).Data
   Case "PRICES20":z4903.PriceS20 = Children(i).Data
   Case "PRICES21":z4903.PriceS21 = Children(i).Data
   Case "PRICES22":z4903.PriceS22 = Children(i).Data
   Case "PRICES23":z4903.PriceS23 = Children(i).Data
   Case "PRICES24":z4903.PriceS24 = Children(i).Data
   Case "PRICES25":z4903.PriceS25 = Children(i).Data
   Case "PRICES26":z4903.PriceS26 = Children(i).Data
   Case "PRICES27":z4903.PriceS27 = Children(i).Data
   Case "PRICES28":z4903.PriceS28 = Children(i).Data
   Case "PRICES29":z4903.PriceS29 = Children(i).Data
   Case "PRICES30":z4903.PriceS30 = Children(i).Data
   Case "REMARK":z4903.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4903_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K4903_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4903 As T4903_AREA, Job as String, CheckClear as Boolean, SHIPPINGWORKORDER AS String, SHIPPINGWORKORDERSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4903_MOVE = False

Try
    If READ_PFK4903(SHIPPINGWORKORDER, SHIPPINGWORKORDERSEQ) = True Then
                z4903 = D4903
		K4903_MOVE = True
		else
	If CheckClear  = True then z4903 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4903")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SHIPPINGWORKORDER":z4903.ShippingWorkOrder = Children(i).Code
   Case "SHIPPINGWORKORDERSEQ":z4903.ShippingWorkOrderSeq = Children(i).Code
   Case "SIZEQTY01":z4903.SizeQty01 = Children(i).Code
   Case "SIZEQTY02":z4903.SizeQty02 = Children(i).Code
   Case "SIZEQTY03":z4903.SizeQty03 = Children(i).Code
   Case "SIZEQTY04":z4903.SizeQty04 = Children(i).Code
   Case "SIZEQTY05":z4903.SizeQty05 = Children(i).Code
   Case "SIZEQTY06":z4903.SizeQty06 = Children(i).Code
   Case "SIZEQTY07":z4903.SizeQty07 = Children(i).Code
   Case "SIZEQTY08":z4903.SizeQty08 = Children(i).Code
   Case "SIZEQTY09":z4903.SizeQty09 = Children(i).Code
   Case "SIZEQTY10":z4903.SizeQty10 = Children(i).Code
   Case "SIZEQTY11":z4903.SizeQty11 = Children(i).Code
   Case "SIZEQTY12":z4903.SizeQty12 = Children(i).Code
   Case "SIZEQTY13":z4903.SizeQty13 = Children(i).Code
   Case "SIZEQTY14":z4903.SizeQty14 = Children(i).Code
   Case "SIZEQTY15":z4903.SizeQty15 = Children(i).Code
   Case "SIZEQTY16":z4903.SizeQty16 = Children(i).Code
   Case "SIZEQTY17":z4903.SizeQty17 = Children(i).Code
   Case "SIZEQTY18":z4903.SizeQty18 = Children(i).Code
   Case "SIZEQTY19":z4903.SizeQty19 = Children(i).Code
   Case "SIZEQTY20":z4903.SizeQty20 = Children(i).Code
   Case "SIZEQTY21":z4903.SizeQty21 = Children(i).Code
   Case "SIZEQTY22":z4903.SizeQty22 = Children(i).Code
   Case "SIZEQTY23":z4903.SizeQty23 = Children(i).Code
   Case "SIZEQTY24":z4903.SizeQty24 = Children(i).Code
   Case "SIZEQTY25":z4903.SizeQty25 = Children(i).Code
   Case "SIZEQTY26":z4903.SizeQty26 = Children(i).Code
   Case "SIZEQTY27":z4903.SizeQty27 = Children(i).Code
   Case "SIZEQTY28":z4903.SizeQty28 = Children(i).Code
   Case "SIZEQTY29":z4903.SizeQty29 = Children(i).Code
   Case "SIZEQTY30":z4903.SizeQty30 = Children(i).Code
   Case "PRICES01":z4903.PriceS01 = Children(i).Code
   Case "PRICES02":z4903.PriceS02 = Children(i).Code
   Case "PRICES03":z4903.PriceS03 = Children(i).Code
   Case "PRICES04":z4903.PriceS04 = Children(i).Code
   Case "PRICES05":z4903.PriceS05 = Children(i).Code
   Case "PRICES06":z4903.PriceS06 = Children(i).Code
   Case "PRICES07":z4903.PriceS07 = Children(i).Code
   Case "PRICES08":z4903.PriceS08 = Children(i).Code
   Case "PRICES09":z4903.PriceS09 = Children(i).Code
   Case "PRICES10":z4903.PriceS10 = Children(i).Code
   Case "PRICES11":z4903.PriceS11 = Children(i).Code
   Case "PRICES12":z4903.PriceS12 = Children(i).Code
   Case "PRICES13":z4903.PriceS13 = Children(i).Code
   Case "PRICES14":z4903.PriceS14 = Children(i).Code
   Case "PRICES15":z4903.PriceS15 = Children(i).Code
   Case "PRICES16":z4903.PriceS16 = Children(i).Code
   Case "PRICES17":z4903.PriceS17 = Children(i).Code
   Case "PRICES18":z4903.PriceS18 = Children(i).Code
   Case "PRICES19":z4903.PriceS19 = Children(i).Code
   Case "PRICES20":z4903.PriceS20 = Children(i).Code
   Case "PRICES21":z4903.PriceS21 = Children(i).Code
   Case "PRICES22":z4903.PriceS22 = Children(i).Code
   Case "PRICES23":z4903.PriceS23 = Children(i).Code
   Case "PRICES24":z4903.PriceS24 = Children(i).Code
   Case "PRICES25":z4903.PriceS25 = Children(i).Code
   Case "PRICES26":z4903.PriceS26 = Children(i).Code
   Case "PRICES27":z4903.PriceS27 = Children(i).Code
   Case "PRICES28":z4903.PriceS28 = Children(i).Code
   Case "PRICES29":z4903.PriceS29 = Children(i).Code
   Case "PRICES30":z4903.PriceS30 = Children(i).Code
   Case "REMARK":z4903.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SHIPPINGWORKORDER":z4903.ShippingWorkOrder = Children(i).Data
   Case "SHIPPINGWORKORDERSEQ":z4903.ShippingWorkOrderSeq = Children(i).Data
   Case "SIZEQTY01":z4903.SizeQty01 = Children(i).Data
   Case "SIZEQTY02":z4903.SizeQty02 = Children(i).Data
   Case "SIZEQTY03":z4903.SizeQty03 = Children(i).Data
   Case "SIZEQTY04":z4903.SizeQty04 = Children(i).Data
   Case "SIZEQTY05":z4903.SizeQty05 = Children(i).Data
   Case "SIZEQTY06":z4903.SizeQty06 = Children(i).Data
   Case "SIZEQTY07":z4903.SizeQty07 = Children(i).Data
   Case "SIZEQTY08":z4903.SizeQty08 = Children(i).Data
   Case "SIZEQTY09":z4903.SizeQty09 = Children(i).Data
   Case "SIZEQTY10":z4903.SizeQty10 = Children(i).Data
   Case "SIZEQTY11":z4903.SizeQty11 = Children(i).Data
   Case "SIZEQTY12":z4903.SizeQty12 = Children(i).Data
   Case "SIZEQTY13":z4903.SizeQty13 = Children(i).Data
   Case "SIZEQTY14":z4903.SizeQty14 = Children(i).Data
   Case "SIZEQTY15":z4903.SizeQty15 = Children(i).Data
   Case "SIZEQTY16":z4903.SizeQty16 = Children(i).Data
   Case "SIZEQTY17":z4903.SizeQty17 = Children(i).Data
   Case "SIZEQTY18":z4903.SizeQty18 = Children(i).Data
   Case "SIZEQTY19":z4903.SizeQty19 = Children(i).Data
   Case "SIZEQTY20":z4903.SizeQty20 = Children(i).Data
   Case "SIZEQTY21":z4903.SizeQty21 = Children(i).Data
   Case "SIZEQTY22":z4903.SizeQty22 = Children(i).Data
   Case "SIZEQTY23":z4903.SizeQty23 = Children(i).Data
   Case "SIZEQTY24":z4903.SizeQty24 = Children(i).Data
   Case "SIZEQTY25":z4903.SizeQty25 = Children(i).Data
   Case "SIZEQTY26":z4903.SizeQty26 = Children(i).Data
   Case "SIZEQTY27":z4903.SizeQty27 = Children(i).Data
   Case "SIZEQTY28":z4903.SizeQty28 = Children(i).Data
   Case "SIZEQTY29":z4903.SizeQty29 = Children(i).Data
   Case "SIZEQTY30":z4903.SizeQty30 = Children(i).Data
   Case "PRICES01":z4903.PriceS01 = Children(i).Data
   Case "PRICES02":z4903.PriceS02 = Children(i).Data
   Case "PRICES03":z4903.PriceS03 = Children(i).Data
   Case "PRICES04":z4903.PriceS04 = Children(i).Data
   Case "PRICES05":z4903.PriceS05 = Children(i).Data
   Case "PRICES06":z4903.PriceS06 = Children(i).Data
   Case "PRICES07":z4903.PriceS07 = Children(i).Data
   Case "PRICES08":z4903.PriceS08 = Children(i).Data
   Case "PRICES09":z4903.PriceS09 = Children(i).Data
   Case "PRICES10":z4903.PriceS10 = Children(i).Data
   Case "PRICES11":z4903.PriceS11 = Children(i).Data
   Case "PRICES12":z4903.PriceS12 = Children(i).Data
   Case "PRICES13":z4903.PriceS13 = Children(i).Data
   Case "PRICES14":z4903.PriceS14 = Children(i).Data
   Case "PRICES15":z4903.PriceS15 = Children(i).Data
   Case "PRICES16":z4903.PriceS16 = Children(i).Data
   Case "PRICES17":z4903.PriceS17 = Children(i).Data
   Case "PRICES18":z4903.PriceS18 = Children(i).Data
   Case "PRICES19":z4903.PriceS19 = Children(i).Data
   Case "PRICES20":z4903.PriceS20 = Children(i).Data
   Case "PRICES21":z4903.PriceS21 = Children(i).Data
   Case "PRICES22":z4903.PriceS22 = Children(i).Data
   Case "PRICES23":z4903.PriceS23 = Children(i).Data
   Case "PRICES24":z4903.PriceS24 = Children(i).Data
   Case "PRICES25":z4903.PriceS25 = Children(i).Data
   Case "PRICES26":z4903.PriceS26 = Children(i).Data
   Case "PRICES27":z4903.PriceS27 = Children(i).Data
   Case "PRICES28":z4903.PriceS28 = Children(i).Data
   Case "PRICES29":z4903.PriceS29 = Children(i).Data
   Case "PRICES30":z4903.PriceS30 = Children(i).Data
   Case "REMARK":z4903.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4903_MOVE",vbCritical)
End Try
End Function 
    
End Module 
