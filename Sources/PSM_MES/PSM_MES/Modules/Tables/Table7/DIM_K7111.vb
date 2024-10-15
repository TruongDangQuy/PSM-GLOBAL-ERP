'=========================================================================================================================================================
'   TABLE : (PFK7111)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7111

Structure T7111_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
        Public ShoesCode As String  '			char(6)		*
Public 	MaterialSeq	 AS Double	'			decimal		*
Public 	DSeq	 AS Double	'			decimal
Public 	QtyComponent	 AS Double	'			decimal
Public 	CSizeQty01	 AS Double	'			decimal
Public 	CSizeQty02	 AS Double	'			decimal
Public 	CSizeQty03	 AS Double	'			decimal
Public 	CSizeQty04	 AS Double	'			decimal
Public 	CSizeQty05	 AS Double	'			decimal
Public 	CSizeQty06	 AS Double	'			decimal
Public 	CSizeQty07	 AS Double	'			decimal
Public 	CSizeQty08	 AS Double	'			decimal
Public 	CSizeQty09	 AS Double	'			decimal
Public 	CSizeQty10	 AS Double	'			decimal
Public 	CSizeQty11	 AS Double	'			decimal
Public 	CSizeQty12	 AS Double	'			decimal
Public 	CSizeQty13	 AS Double	'			decimal
Public 	CSizeQty14	 AS Double	'			decimal
Public 	CSizeQty15	 AS Double	'			decimal
Public 	CSizeQty16	 AS Double	'			decimal
Public 	CSizeQty17	 AS Double	'			decimal
Public 	CSizeQty18	 AS Double	'			decimal
Public 	CSizeQty19	 AS Double	'			decimal
Public 	CSizeQty20	 AS Double	'			decimal
Public 	CSizeQty21	 AS Double	'			decimal
Public 	CSizeQty22	 AS Double	'			decimal
Public 	CSizeQty23	 AS Double	'			decimal
Public 	CSizeQty24	 AS Double	'			decimal
Public 	CSizeQty25	 AS Double	'			decimal
Public 	CSizeQty26	 AS Double	'			decimal
Public 	CSizeQty27	 AS Double	'			decimal
Public 	CSizeQty28	 AS Double	'			decimal
Public 	CSizeQty29	 AS Double	'			decimal
Public 	CSizeQty30	 AS Double	'			decimal
Public 	Remark	 AS String	'			nvarchar(50)
'=========================================================================================================================================================
End structure

Public D7111 As T7111_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
    Public Function READ_PFK7111(SHOESCODE As String, MATERIALSEQ As Double) As Boolean
        READ_PFK7111 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7111 "
            SQL = SQL & " WHERE K7111_ShoesCode		 = '" & SHOESCODE & "' "
            SQL = SQL & "   AND K7111_MaterialSeq		 =  " & MATERIALSEQ & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7111_CLEAR() : GoTo SKIP_READ_PFK7111

            Call K7111_MOVE(rd)
            READ_PFK7111 = True

SKIP_READ_PFK7111:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7111", vbCritical)
        End Try
    End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
    Public Function READ_PFK7111(SHOESCODE As String, MATERIALSEQ As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7111 "
            SQL = SQL & " WHERE K7111_ShoesCode		 = '" & SHOESCODE & "' "
            SQL = SQL & "   AND K7111_MaterialSeq		 =  " & MATERIALSEQ & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK7111", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7111(z7111 As T7111_AREA) As Boolean
    WRITE_PFK7111 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7111)
 
    SQL = " INSERT INTO PFK7111 "
    SQL = SQL & " ( "
    SQL = SQL & " K7111_ShoesCode," 
    SQL = SQL & " K7111_MaterialSeq," 
    SQL = SQL & " K7111_DSeq," 
    SQL = SQL & " K7111_QtyComponent," 
    SQL = SQL & " K7111_CSizeQty01," 
    SQL = SQL & " K7111_CSizeQty02," 
    SQL = SQL & " K7111_CSizeQty03," 
    SQL = SQL & " K7111_CSizeQty04," 
    SQL = SQL & " K7111_CSizeQty05," 
    SQL = SQL & " K7111_CSizeQty06," 
    SQL = SQL & " K7111_CSizeQty07," 
    SQL = SQL & " K7111_CSizeQty08," 
    SQL = SQL & " K7111_CSizeQty09," 
    SQL = SQL & " K7111_CSizeQty10," 
    SQL = SQL & " K7111_CSizeQty11," 
    SQL = SQL & " K7111_CSizeQty12," 
    SQL = SQL & " K7111_CSizeQty13," 
    SQL = SQL & " K7111_CSizeQty14," 
    SQL = SQL & " K7111_CSizeQty15," 
    SQL = SQL & " K7111_CSizeQty16," 
    SQL = SQL & " K7111_CSizeQty17," 
    SQL = SQL & " K7111_CSizeQty18," 
    SQL = SQL & " K7111_CSizeQty19," 
    SQL = SQL & " K7111_CSizeQty20," 
    SQL = SQL & " K7111_CSizeQty21," 
    SQL = SQL & " K7111_CSizeQty22," 
    SQL = SQL & " K7111_CSizeQty23," 
    SQL = SQL & " K7111_CSizeQty24," 
    SQL = SQL & " K7111_CSizeQty25," 
    SQL = SQL & " K7111_CSizeQty26," 
    SQL = SQL & " K7111_CSizeQty27," 
    SQL = SQL & " K7111_CSizeQty28," 
    SQL = SQL & " K7111_CSizeQty29," 
    SQL = SQL & " K7111_CSizeQty30," 
    SQL = SQL & " K7111_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7111.ShoesCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z7111.MaterialSeq) & ", "  
    SQL = SQL & "   " & FormatSQL(z7111.DSeq) & ", "  
    SQL = SQL & "   " & FormatSQL(z7111.QtyComponent) & ", "  
    SQL = SQL & "   " & FormatSQL(z7111.CSizeQty01) & ", "  
    SQL = SQL & "   " & FormatSQL(z7111.CSizeQty02) & ", "  
    SQL = SQL & "   " & FormatSQL(z7111.CSizeQty03) & ", "  
    SQL = SQL & "   " & FormatSQL(z7111.CSizeQty04) & ", "  
    SQL = SQL & "   " & FormatSQL(z7111.CSizeQty05) & ", "  
    SQL = SQL & "   " & FormatSQL(z7111.CSizeQty06) & ", "  
    SQL = SQL & "   " & FormatSQL(z7111.CSizeQty07) & ", "  
    SQL = SQL & "   " & FormatSQL(z7111.CSizeQty08) & ", "  
    SQL = SQL & "   " & FormatSQL(z7111.CSizeQty09) & ", "  
    SQL = SQL & "   " & FormatSQL(z7111.CSizeQty10) & ", "  
    SQL = SQL & "   " & FormatSQL(z7111.CSizeQty11) & ", "  
    SQL = SQL & "   " & FormatSQL(z7111.CSizeQty12) & ", "  
    SQL = SQL & "   " & FormatSQL(z7111.CSizeQty13) & ", "  
    SQL = SQL & "   " & FormatSQL(z7111.CSizeQty14) & ", "  
    SQL = SQL & "   " & FormatSQL(z7111.CSizeQty15) & ", "  
    SQL = SQL & "   " & FormatSQL(z7111.CSizeQty16) & ", "  
    SQL = SQL & "   " & FormatSQL(z7111.CSizeQty17) & ", "  
    SQL = SQL & "   " & FormatSQL(z7111.CSizeQty18) & ", "  
    SQL = SQL & "   " & FormatSQL(z7111.CSizeQty19) & ", "  
    SQL = SQL & "   " & FormatSQL(z7111.CSizeQty20) & ", "  
    SQL = SQL & "   " & FormatSQL(z7111.CSizeQty21) & ", "  
    SQL = SQL & "   " & FormatSQL(z7111.CSizeQty22) & ", "  
    SQL = SQL & "   " & FormatSQL(z7111.CSizeQty23) & ", "  
    SQL = SQL & "   " & FormatSQL(z7111.CSizeQty24) & ", "  
    SQL = SQL & "   " & FormatSQL(z7111.CSizeQty25) & ", "  
    SQL = SQL & "   " & FormatSQL(z7111.CSizeQty26) & ", "  
    SQL = SQL & "   " & FormatSQL(z7111.CSizeQty27) & ", "  
    SQL = SQL & "   " & FormatSQL(z7111.CSizeQty28) & ", "  
    SQL = SQL & "   " & FormatSQL(z7111.CSizeQty29) & ", "  
    SQL = SQL & "   " & FormatSQL(z7111.CSizeQty30) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7111.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7111 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7111",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7111(z7111 As T7111_AREA) As Boolean
    REWRITE_PFK7111 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7111)
   
    SQL = " UPDATE PFK7111 SET "
    SQL = SQL & "    K7111_DSeq      =  " & FormatSQL(z7111.DSeq) & ", " 
    SQL = SQL & "    K7111_QtyComponent      =  " & FormatSQL(z7111.QtyComponent) & ", " 
    SQL = SQL & "    K7111_CSizeQty01      =  " & FormatSQL(z7111.CSizeQty01) & ", " 
    SQL = SQL & "    K7111_CSizeQty02      =  " & FormatSQL(z7111.CSizeQty02) & ", " 
    SQL = SQL & "    K7111_CSizeQty03      =  " & FormatSQL(z7111.CSizeQty03) & ", " 
    SQL = SQL & "    K7111_CSizeQty04      =  " & FormatSQL(z7111.CSizeQty04) & ", " 
    SQL = SQL & "    K7111_CSizeQty05      =  " & FormatSQL(z7111.CSizeQty05) & ", " 
    SQL = SQL & "    K7111_CSizeQty06      =  " & FormatSQL(z7111.CSizeQty06) & ", " 
    SQL = SQL & "    K7111_CSizeQty07      =  " & FormatSQL(z7111.CSizeQty07) & ", " 
    SQL = SQL & "    K7111_CSizeQty08      =  " & FormatSQL(z7111.CSizeQty08) & ", " 
    SQL = SQL & "    K7111_CSizeQty09      =  " & FormatSQL(z7111.CSizeQty09) & ", " 
    SQL = SQL & "    K7111_CSizeQty10      =  " & FormatSQL(z7111.CSizeQty10) & ", " 
    SQL = SQL & "    K7111_CSizeQty11      =  " & FormatSQL(z7111.CSizeQty11) & ", " 
    SQL = SQL & "    K7111_CSizeQty12      =  " & FormatSQL(z7111.CSizeQty12) & ", " 
    SQL = SQL & "    K7111_CSizeQty13      =  " & FormatSQL(z7111.CSizeQty13) & ", " 
    SQL = SQL & "    K7111_CSizeQty14      =  " & FormatSQL(z7111.CSizeQty14) & ", " 
    SQL = SQL & "    K7111_CSizeQty15      =  " & FormatSQL(z7111.CSizeQty15) & ", " 
    SQL = SQL & "    K7111_CSizeQty16      =  " & FormatSQL(z7111.CSizeQty16) & ", " 
    SQL = SQL & "    K7111_CSizeQty17      =  " & FormatSQL(z7111.CSizeQty17) & ", " 
    SQL = SQL & "    K7111_CSizeQty18      =  " & FormatSQL(z7111.CSizeQty18) & ", " 
    SQL = SQL & "    K7111_CSizeQty19      =  " & FormatSQL(z7111.CSizeQty19) & ", " 
    SQL = SQL & "    K7111_CSizeQty20      =  " & FormatSQL(z7111.CSizeQty20) & ", " 
    SQL = SQL & "    K7111_CSizeQty21      =  " & FormatSQL(z7111.CSizeQty21) & ", " 
    SQL = SQL & "    K7111_CSizeQty22      =  " & FormatSQL(z7111.CSizeQty22) & ", " 
    SQL = SQL & "    K7111_CSizeQty23      =  " & FormatSQL(z7111.CSizeQty23) & ", " 
    SQL = SQL & "    K7111_CSizeQty24      =  " & FormatSQL(z7111.CSizeQty24) & ", " 
    SQL = SQL & "    K7111_CSizeQty25      =  " & FormatSQL(z7111.CSizeQty25) & ", " 
    SQL = SQL & "    K7111_CSizeQty26      =  " & FormatSQL(z7111.CSizeQty26) & ", " 
    SQL = SQL & "    K7111_CSizeQty27      =  " & FormatSQL(z7111.CSizeQty27) & ", " 
    SQL = SQL & "    K7111_CSizeQty28      =  " & FormatSQL(z7111.CSizeQty28) & ", " 
    SQL = SQL & "    K7111_CSizeQty29      =  " & FormatSQL(z7111.CSizeQty29) & ", " 
    SQL = SQL & "    K7111_CSizeQty30      =  " & FormatSQL(z7111.CSizeQty30) & ", " 
    SQL = SQL & "    K7111_Remark      = N'" & FormatSQL(z7111.Remark) & "'  " 
    SQL = SQL & " WHERE K7111_ShoesCode		 = '" & z7111.ShoesCode & "' " 
    SQL = SQL & "   AND K7111_MaterialSeq		 =  " & z7111.MaterialSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7111 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7111",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7111(z7111 As T7111_AREA) As Boolean
    DELETE_PFK7111 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7111 "
    SQL = SQL & " WHERE K7111_ShoesCode		 = '" & z7111.ShoesCode & "' " 
    SQL = SQL & "   AND K7111_MaterialSeq		 =  " & z7111.MaterialSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7111 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7111",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7111_CLEAR()
Try
    
            D7111.ShoesCode = ""
    D7111.MaterialSeq = 0 
    D7111.DSeq = 0 
    D7111.QtyComponent = 0 
    D7111.CSizeQty01 = 0 
    D7111.CSizeQty02 = 0 
    D7111.CSizeQty03 = 0 
    D7111.CSizeQty04 = 0 
    D7111.CSizeQty05 = 0 
    D7111.CSizeQty06 = 0 
    D7111.CSizeQty07 = 0 
    D7111.CSizeQty08 = 0 
    D7111.CSizeQty09 = 0 
    D7111.CSizeQty10 = 0 
    D7111.CSizeQty11 = 0 
    D7111.CSizeQty12 = 0 
    D7111.CSizeQty13 = 0 
    D7111.CSizeQty14 = 0 
    D7111.CSizeQty15 = 0 
    D7111.CSizeQty16 = 0 
    D7111.CSizeQty17 = 0 
    D7111.CSizeQty18 = 0 
    D7111.CSizeQty19 = 0 
    D7111.CSizeQty20 = 0 
    D7111.CSizeQty21 = 0 
    D7111.CSizeQty22 = 0 
    D7111.CSizeQty23 = 0 
    D7111.CSizeQty24 = 0 
    D7111.CSizeQty25 = 0 
    D7111.CSizeQty26 = 0 
    D7111.CSizeQty27 = 0 
    D7111.CSizeQty28 = 0 
    D7111.CSizeQty29 = 0 
    D7111.CSizeQty30 = 0 
   D7111.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7111_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7111 As T7111_AREA)
Try
    
            x7111.ShoesCode = Trim$(x7111.ShoesCode)
    x7111.MaterialSeq = trim$(  x7111.MaterialSeq)
    x7111.DSeq = trim$(  x7111.DSeq)
    x7111.QtyComponent = trim$(  x7111.QtyComponent)
    x7111.CSizeQty01 = trim$(  x7111.CSizeQty01)
    x7111.CSizeQty02 = trim$(  x7111.CSizeQty02)
    x7111.CSizeQty03 = trim$(  x7111.CSizeQty03)
    x7111.CSizeQty04 = trim$(  x7111.CSizeQty04)
    x7111.CSizeQty05 = trim$(  x7111.CSizeQty05)
    x7111.CSizeQty06 = trim$(  x7111.CSizeQty06)
    x7111.CSizeQty07 = trim$(  x7111.CSizeQty07)
    x7111.CSizeQty08 = trim$(  x7111.CSizeQty08)
    x7111.CSizeQty09 = trim$(  x7111.CSizeQty09)
    x7111.CSizeQty10 = trim$(  x7111.CSizeQty10)
    x7111.CSizeQty11 = trim$(  x7111.CSizeQty11)
    x7111.CSizeQty12 = trim$(  x7111.CSizeQty12)
    x7111.CSizeQty13 = trim$(  x7111.CSizeQty13)
    x7111.CSizeQty14 = trim$(  x7111.CSizeQty14)
    x7111.CSizeQty15 = trim$(  x7111.CSizeQty15)
    x7111.CSizeQty16 = trim$(  x7111.CSizeQty16)
    x7111.CSizeQty17 = trim$(  x7111.CSizeQty17)
    x7111.CSizeQty18 = trim$(  x7111.CSizeQty18)
    x7111.CSizeQty19 = trim$(  x7111.CSizeQty19)
    x7111.CSizeQty20 = trim$(  x7111.CSizeQty20)
    x7111.CSizeQty21 = trim$(  x7111.CSizeQty21)
    x7111.CSizeQty22 = trim$(  x7111.CSizeQty22)
    x7111.CSizeQty23 = trim$(  x7111.CSizeQty23)
    x7111.CSizeQty24 = trim$(  x7111.CSizeQty24)
    x7111.CSizeQty25 = trim$(  x7111.CSizeQty25)
    x7111.CSizeQty26 = trim$(  x7111.CSizeQty26)
    x7111.CSizeQty27 = trim$(  x7111.CSizeQty27)
    x7111.CSizeQty28 = trim$(  x7111.CSizeQty28)
    x7111.CSizeQty29 = trim$(  x7111.CSizeQty29)
    x7111.CSizeQty30 = trim$(  x7111.CSizeQty30)
    x7111.Remark = trim$(  x7111.Remark)
     
            If Trim$(x7111.ShoesCode) = "" Then x7111.ShoesCode = Space(1)
    If trim$( x7111.MaterialSeq ) = "" Then x7111.MaterialSeq = 0 
    If trim$( x7111.DSeq ) = "" Then x7111.DSeq = 0 
    If trim$( x7111.QtyComponent ) = "" Then x7111.QtyComponent = 0 
    If trim$( x7111.CSizeQty01 ) = "" Then x7111.CSizeQty01 = 0 
    If trim$( x7111.CSizeQty02 ) = "" Then x7111.CSizeQty02 = 0 
    If trim$( x7111.CSizeQty03 ) = "" Then x7111.CSizeQty03 = 0 
    If trim$( x7111.CSizeQty04 ) = "" Then x7111.CSizeQty04 = 0 
    If trim$( x7111.CSizeQty05 ) = "" Then x7111.CSizeQty05 = 0 
    If trim$( x7111.CSizeQty06 ) = "" Then x7111.CSizeQty06 = 0 
    If trim$( x7111.CSizeQty07 ) = "" Then x7111.CSizeQty07 = 0 
    If trim$( x7111.CSizeQty08 ) = "" Then x7111.CSizeQty08 = 0 
    If trim$( x7111.CSizeQty09 ) = "" Then x7111.CSizeQty09 = 0 
    If trim$( x7111.CSizeQty10 ) = "" Then x7111.CSizeQty10 = 0 
    If trim$( x7111.CSizeQty11 ) = "" Then x7111.CSizeQty11 = 0 
    If trim$( x7111.CSizeQty12 ) = "" Then x7111.CSizeQty12 = 0 
    If trim$( x7111.CSizeQty13 ) = "" Then x7111.CSizeQty13 = 0 
    If trim$( x7111.CSizeQty14 ) = "" Then x7111.CSizeQty14 = 0 
    If trim$( x7111.CSizeQty15 ) = "" Then x7111.CSizeQty15 = 0 
    If trim$( x7111.CSizeQty16 ) = "" Then x7111.CSizeQty16 = 0 
    If trim$( x7111.CSizeQty17 ) = "" Then x7111.CSizeQty17 = 0 
    If trim$( x7111.CSizeQty18 ) = "" Then x7111.CSizeQty18 = 0 
    If trim$( x7111.CSizeQty19 ) = "" Then x7111.CSizeQty19 = 0 
    If trim$( x7111.CSizeQty20 ) = "" Then x7111.CSizeQty20 = 0 
    If trim$( x7111.CSizeQty21 ) = "" Then x7111.CSizeQty21 = 0 
    If trim$( x7111.CSizeQty22 ) = "" Then x7111.CSizeQty22 = 0 
    If trim$( x7111.CSizeQty23 ) = "" Then x7111.CSizeQty23 = 0 
    If trim$( x7111.CSizeQty24 ) = "" Then x7111.CSizeQty24 = 0 
    If trim$( x7111.CSizeQty25 ) = "" Then x7111.CSizeQty25 = 0 
    If trim$( x7111.CSizeQty26 ) = "" Then x7111.CSizeQty26 = 0 
    If trim$( x7111.CSizeQty27 ) = "" Then x7111.CSizeQty27 = 0 
    If trim$( x7111.CSizeQty28 ) = "" Then x7111.CSizeQty28 = 0 
    If trim$( x7111.CSizeQty29 ) = "" Then x7111.CSizeQty29 = 0 
    If trim$( x7111.CSizeQty30 ) = "" Then x7111.CSizeQty30 = 0 
    If trim$( x7111.Remark ) = "" Then x7111.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7111_MOVE(rs7111 As SqlClient.SqlDataReader)
Try

    call D7111_CLEAR()   

            If IsDBNull(rs7111!K7111_ShoesCode) = False Then D7111.ShoesCode = Trim$(rs7111!K7111_ShoesCode)
    If IsdbNull(rs7111!K7111_MaterialSeq) = False Then D7111.MaterialSeq = Trim$(rs7111!K7111_MaterialSeq)
    If IsdbNull(rs7111!K7111_DSeq) = False Then D7111.DSeq = Trim$(rs7111!K7111_DSeq)
    If IsdbNull(rs7111!K7111_QtyComponent) = False Then D7111.QtyComponent = Trim$(rs7111!K7111_QtyComponent)
    If IsdbNull(rs7111!K7111_CSizeQty01) = False Then D7111.CSizeQty01 = Trim$(rs7111!K7111_CSizeQty01)
    If IsdbNull(rs7111!K7111_CSizeQty02) = False Then D7111.CSizeQty02 = Trim$(rs7111!K7111_CSizeQty02)
    If IsdbNull(rs7111!K7111_CSizeQty03) = False Then D7111.CSizeQty03 = Trim$(rs7111!K7111_CSizeQty03)
    If IsdbNull(rs7111!K7111_CSizeQty04) = False Then D7111.CSizeQty04 = Trim$(rs7111!K7111_CSizeQty04)
    If IsdbNull(rs7111!K7111_CSizeQty05) = False Then D7111.CSizeQty05 = Trim$(rs7111!K7111_CSizeQty05)
    If IsdbNull(rs7111!K7111_CSizeQty06) = False Then D7111.CSizeQty06 = Trim$(rs7111!K7111_CSizeQty06)
    If IsdbNull(rs7111!K7111_CSizeQty07) = False Then D7111.CSizeQty07 = Trim$(rs7111!K7111_CSizeQty07)
    If IsdbNull(rs7111!K7111_CSizeQty08) = False Then D7111.CSizeQty08 = Trim$(rs7111!K7111_CSizeQty08)
    If IsdbNull(rs7111!K7111_CSizeQty09) = False Then D7111.CSizeQty09 = Trim$(rs7111!K7111_CSizeQty09)
    If IsdbNull(rs7111!K7111_CSizeQty10) = False Then D7111.CSizeQty10 = Trim$(rs7111!K7111_CSizeQty10)
    If IsdbNull(rs7111!K7111_CSizeQty11) = False Then D7111.CSizeQty11 = Trim$(rs7111!K7111_CSizeQty11)
    If IsdbNull(rs7111!K7111_CSizeQty12) = False Then D7111.CSizeQty12 = Trim$(rs7111!K7111_CSizeQty12)
    If IsdbNull(rs7111!K7111_CSizeQty13) = False Then D7111.CSizeQty13 = Trim$(rs7111!K7111_CSizeQty13)
    If IsdbNull(rs7111!K7111_CSizeQty14) = False Then D7111.CSizeQty14 = Trim$(rs7111!K7111_CSizeQty14)
    If IsdbNull(rs7111!K7111_CSizeQty15) = False Then D7111.CSizeQty15 = Trim$(rs7111!K7111_CSizeQty15)
    If IsdbNull(rs7111!K7111_CSizeQty16) = False Then D7111.CSizeQty16 = Trim$(rs7111!K7111_CSizeQty16)
    If IsdbNull(rs7111!K7111_CSizeQty17) = False Then D7111.CSizeQty17 = Trim$(rs7111!K7111_CSizeQty17)
    If IsdbNull(rs7111!K7111_CSizeQty18) = False Then D7111.CSizeQty18 = Trim$(rs7111!K7111_CSizeQty18)
    If IsdbNull(rs7111!K7111_CSizeQty19) = False Then D7111.CSizeQty19 = Trim$(rs7111!K7111_CSizeQty19)
    If IsdbNull(rs7111!K7111_CSizeQty20) = False Then D7111.CSizeQty20 = Trim$(rs7111!K7111_CSizeQty20)
    If IsdbNull(rs7111!K7111_CSizeQty21) = False Then D7111.CSizeQty21 = Trim$(rs7111!K7111_CSizeQty21)
    If IsdbNull(rs7111!K7111_CSizeQty22) = False Then D7111.CSizeQty22 = Trim$(rs7111!K7111_CSizeQty22)
    If IsdbNull(rs7111!K7111_CSizeQty23) = False Then D7111.CSizeQty23 = Trim$(rs7111!K7111_CSizeQty23)
    If IsdbNull(rs7111!K7111_CSizeQty24) = False Then D7111.CSizeQty24 = Trim$(rs7111!K7111_CSizeQty24)
    If IsdbNull(rs7111!K7111_CSizeQty25) = False Then D7111.CSizeQty25 = Trim$(rs7111!K7111_CSizeQty25)
    If IsdbNull(rs7111!K7111_CSizeQty26) = False Then D7111.CSizeQty26 = Trim$(rs7111!K7111_CSizeQty26)
    If IsdbNull(rs7111!K7111_CSizeQty27) = False Then D7111.CSizeQty27 = Trim$(rs7111!K7111_CSizeQty27)
    If IsdbNull(rs7111!K7111_CSizeQty28) = False Then D7111.CSizeQty28 = Trim$(rs7111!K7111_CSizeQty28)
    If IsdbNull(rs7111!K7111_CSizeQty29) = False Then D7111.CSizeQty29 = Trim$(rs7111!K7111_CSizeQty29)
    If IsdbNull(rs7111!K7111_CSizeQty30) = False Then D7111.CSizeQty30 = Trim$(rs7111!K7111_CSizeQty30)
    If IsdbNull(rs7111!K7111_Remark) = False Then D7111.Remark = Trim$(rs7111!K7111_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7111_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7111_MOVE(rs7111 As DataRow)
Try

    call D7111_CLEAR()   

            If IsDBNull(rs7111!K7111_ShoesCode) = False Then D7111.ShoesCode = Trim$(rs7111!K7111_ShoesCode)
    If IsdbNull(rs7111!K7111_MaterialSeq) = False Then D7111.MaterialSeq = Trim$(rs7111!K7111_MaterialSeq)
    If IsdbNull(rs7111!K7111_DSeq) = False Then D7111.DSeq = Trim$(rs7111!K7111_DSeq)
    If IsdbNull(rs7111!K7111_QtyComponent) = False Then D7111.QtyComponent = Trim$(rs7111!K7111_QtyComponent)
    If IsdbNull(rs7111!K7111_CSizeQty01) = False Then D7111.CSizeQty01 = Trim$(rs7111!K7111_CSizeQty01)
    If IsdbNull(rs7111!K7111_CSizeQty02) = False Then D7111.CSizeQty02 = Trim$(rs7111!K7111_CSizeQty02)
    If IsdbNull(rs7111!K7111_CSizeQty03) = False Then D7111.CSizeQty03 = Trim$(rs7111!K7111_CSizeQty03)
    If IsdbNull(rs7111!K7111_CSizeQty04) = False Then D7111.CSizeQty04 = Trim$(rs7111!K7111_CSizeQty04)
    If IsdbNull(rs7111!K7111_CSizeQty05) = False Then D7111.CSizeQty05 = Trim$(rs7111!K7111_CSizeQty05)
    If IsdbNull(rs7111!K7111_CSizeQty06) = False Then D7111.CSizeQty06 = Trim$(rs7111!K7111_CSizeQty06)
    If IsdbNull(rs7111!K7111_CSizeQty07) = False Then D7111.CSizeQty07 = Trim$(rs7111!K7111_CSizeQty07)
    If IsdbNull(rs7111!K7111_CSizeQty08) = False Then D7111.CSizeQty08 = Trim$(rs7111!K7111_CSizeQty08)
    If IsdbNull(rs7111!K7111_CSizeQty09) = False Then D7111.CSizeQty09 = Trim$(rs7111!K7111_CSizeQty09)
    If IsdbNull(rs7111!K7111_CSizeQty10) = False Then D7111.CSizeQty10 = Trim$(rs7111!K7111_CSizeQty10)
    If IsdbNull(rs7111!K7111_CSizeQty11) = False Then D7111.CSizeQty11 = Trim$(rs7111!K7111_CSizeQty11)
    If IsdbNull(rs7111!K7111_CSizeQty12) = False Then D7111.CSizeQty12 = Trim$(rs7111!K7111_CSizeQty12)
    If IsdbNull(rs7111!K7111_CSizeQty13) = False Then D7111.CSizeQty13 = Trim$(rs7111!K7111_CSizeQty13)
    If IsdbNull(rs7111!K7111_CSizeQty14) = False Then D7111.CSizeQty14 = Trim$(rs7111!K7111_CSizeQty14)
    If IsdbNull(rs7111!K7111_CSizeQty15) = False Then D7111.CSizeQty15 = Trim$(rs7111!K7111_CSizeQty15)
    If IsdbNull(rs7111!K7111_CSizeQty16) = False Then D7111.CSizeQty16 = Trim$(rs7111!K7111_CSizeQty16)
    If IsdbNull(rs7111!K7111_CSizeQty17) = False Then D7111.CSizeQty17 = Trim$(rs7111!K7111_CSizeQty17)
    If IsdbNull(rs7111!K7111_CSizeQty18) = False Then D7111.CSizeQty18 = Trim$(rs7111!K7111_CSizeQty18)
    If IsdbNull(rs7111!K7111_CSizeQty19) = False Then D7111.CSizeQty19 = Trim$(rs7111!K7111_CSizeQty19)
    If IsdbNull(rs7111!K7111_CSizeQty20) = False Then D7111.CSizeQty20 = Trim$(rs7111!K7111_CSizeQty20)
    If IsdbNull(rs7111!K7111_CSizeQty21) = False Then D7111.CSizeQty21 = Trim$(rs7111!K7111_CSizeQty21)
    If IsdbNull(rs7111!K7111_CSizeQty22) = False Then D7111.CSizeQty22 = Trim$(rs7111!K7111_CSizeQty22)
    If IsdbNull(rs7111!K7111_CSizeQty23) = False Then D7111.CSizeQty23 = Trim$(rs7111!K7111_CSizeQty23)
    If IsdbNull(rs7111!K7111_CSizeQty24) = False Then D7111.CSizeQty24 = Trim$(rs7111!K7111_CSizeQty24)
    If IsdbNull(rs7111!K7111_CSizeQty25) = False Then D7111.CSizeQty25 = Trim$(rs7111!K7111_CSizeQty25)
    If IsdbNull(rs7111!K7111_CSizeQty26) = False Then D7111.CSizeQty26 = Trim$(rs7111!K7111_CSizeQty26)
    If IsdbNull(rs7111!K7111_CSizeQty27) = False Then D7111.CSizeQty27 = Trim$(rs7111!K7111_CSizeQty27)
    If IsdbNull(rs7111!K7111_CSizeQty28) = False Then D7111.CSizeQty28 = Trim$(rs7111!K7111_CSizeQty28)
    If IsdbNull(rs7111!K7111_CSizeQty29) = False Then D7111.CSizeQty29 = Trim$(rs7111!K7111_CSizeQty29)
    If IsdbNull(rs7111!K7111_CSizeQty30) = False Then D7111.CSizeQty30 = Trim$(rs7111!K7111_CSizeQty30)
    If IsdbNull(rs7111!K7111_Remark) = False Then D7111.Remark = Trim$(rs7111!K7111_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7111_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
    Public Function K7111_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7111 As T7111_AREA, SHOESCODE As String, MATERIALSEQ As Double) As Boolean

        K7111_MOVE = False

        Try
            If READ_PFK7111(SHOESCODE, MATERIALSEQ) = True Then
                z7111 = D7111
                K7111_MOVE = True
            Else
                z7111 = Nothing
            End If

            If getColumIndex(spr, "ShoesCode") > -1 Then z7111.ShoesCode = getDataM(spr, getColumIndex(spr, "ShoesCode"), xRow)
            If getColumIndex(spr, "MaterialSeq") > -1 Then z7111.MaterialSeq = getDataM(spr, getColumIndex(spr, "MaterialSeq"), xRow)
            If getColumIndex(spr, "DSeq") > -1 Then z7111.DSeq = getDataM(spr, getColumIndex(spr, "DSeq"), xRow)
            If getColumIndex(spr, "QtyComponent") > -1 Then z7111.QtyComponent = getDataM(spr, getColumIndex(spr, "QtyComponent"), xRow)
            If getColumIndex(spr, "CSizeQty01") > -1 Then z7111.CSizeQty01 = getDataM(spr, getColumIndex(spr, "CSizeQty01"), xRow)
            If getColumIndex(spr, "CSizeQty02") > -1 Then z7111.CSizeQty02 = getDataM(spr, getColumIndex(spr, "CSizeQty02"), xRow)
            If getColumIndex(spr, "CSizeQty03") > -1 Then z7111.CSizeQty03 = getDataM(spr, getColumIndex(spr, "CSizeQty03"), xRow)
            If getColumIndex(spr, "CSizeQty04") > -1 Then z7111.CSizeQty04 = getDataM(spr, getColumIndex(spr, "CSizeQty04"), xRow)
            If getColumIndex(spr, "CSizeQty05") > -1 Then z7111.CSizeQty05 = getDataM(spr, getColumIndex(spr, "CSizeQty05"), xRow)
            If getColumIndex(spr, "CSizeQty06") > -1 Then z7111.CSizeQty06 = getDataM(spr, getColumIndex(spr, "CSizeQty06"), xRow)
            If getColumIndex(spr, "CSizeQty07") > -1 Then z7111.CSizeQty07 = getDataM(spr, getColumIndex(spr, "CSizeQty07"), xRow)
            If getColumIndex(spr, "CSizeQty08") > -1 Then z7111.CSizeQty08 = getDataM(spr, getColumIndex(spr, "CSizeQty08"), xRow)
            If getColumIndex(spr, "CSizeQty09") > -1 Then z7111.CSizeQty09 = getDataM(spr, getColumIndex(spr, "CSizeQty09"), xRow)
            If getColumIndex(spr, "CSizeQty10") > -1 Then z7111.CSizeQty10 = getDataM(spr, getColumIndex(spr, "CSizeQty10"), xRow)
            If getColumIndex(spr, "CSizeQty11") > -1 Then z7111.CSizeQty11 = getDataM(spr, getColumIndex(spr, "CSizeQty11"), xRow)
            If getColumIndex(spr, "CSizeQty12") > -1 Then z7111.CSizeQty12 = getDataM(spr, getColumIndex(spr, "CSizeQty12"), xRow)
            If getColumIndex(spr, "CSizeQty13") > -1 Then z7111.CSizeQty13 = getDataM(spr, getColumIndex(spr, "CSizeQty13"), xRow)
            If getColumIndex(spr, "CSizeQty14") > -1 Then z7111.CSizeQty14 = getDataM(spr, getColumIndex(spr, "CSizeQty14"), xRow)
            If getColumIndex(spr, "CSizeQty15") > -1 Then z7111.CSizeQty15 = getDataM(spr, getColumIndex(spr, "CSizeQty15"), xRow)
            If getColumIndex(spr, "CSizeQty16") > -1 Then z7111.CSizeQty16 = getDataM(spr, getColumIndex(spr, "CSizeQty16"), xRow)
            If getColumIndex(spr, "CSizeQty17") > -1 Then z7111.CSizeQty17 = getDataM(spr, getColumIndex(spr, "CSizeQty17"), xRow)
            If getColumIndex(spr, "CSizeQty18") > -1 Then z7111.CSizeQty18 = getDataM(spr, getColumIndex(spr, "CSizeQty18"), xRow)
            If getColumIndex(spr, "CSizeQty19") > -1 Then z7111.CSizeQty19 = getDataM(spr, getColumIndex(spr, "CSizeQty19"), xRow)
            If getColumIndex(spr, "CSizeQty20") > -1 Then z7111.CSizeQty20 = getDataM(spr, getColumIndex(spr, "CSizeQty20"), xRow)
            If getColumIndex(spr, "CSizeQty21") > -1 Then z7111.CSizeQty21 = getDataM(spr, getColumIndex(spr, "CSizeQty21"), xRow)
            If getColumIndex(spr, "CSizeQty22") > -1 Then z7111.CSizeQty22 = getDataM(spr, getColumIndex(spr, "CSizeQty22"), xRow)
            If getColumIndex(spr, "CSizeQty23") > -1 Then z7111.CSizeQty23 = getDataM(spr, getColumIndex(spr, "CSizeQty23"), xRow)
            If getColumIndex(spr, "CSizeQty24") > -1 Then z7111.CSizeQty24 = getDataM(spr, getColumIndex(spr, "CSizeQty24"), xRow)
            If getColumIndex(spr, "CSizeQty25") > -1 Then z7111.CSizeQty25 = getDataM(spr, getColumIndex(spr, "CSizeQty25"), xRow)
            If getColumIndex(spr, "CSizeQty26") > -1 Then z7111.CSizeQty26 = getDataM(spr, getColumIndex(spr, "CSizeQty26"), xRow)
            If getColumIndex(spr, "CSizeQty27") > -1 Then z7111.CSizeQty27 = getDataM(spr, getColumIndex(spr, "CSizeQty27"), xRow)
            If getColumIndex(spr, "CSizeQty28") > -1 Then z7111.CSizeQty28 = getDataM(spr, getColumIndex(spr, "CSizeQty28"), xRow)
            If getColumIndex(spr, "CSizeQty29") > -1 Then z7111.CSizeQty29 = getDataM(spr, getColumIndex(spr, "CSizeQty29"), xRow)
            If getColumIndex(spr, "CSizeQty30") > -1 Then z7111.CSizeQty30 = getDataM(spr, getColumIndex(spr, "CSizeQty30"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z7111.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7111_MOVE", vbCritical)
        End Try
    End Function


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
    Public Function K7111_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7111 As T7111_AREA, CheckClear As Boolean, SHOESCODE As String, MATERIALSEQ As Double) As Boolean

        K7111_MOVE = False

        Try
            If READ_PFK7111(SHOESCODE, MATERIALSEQ) = True Then
                z7111 = D7111
                K7111_MOVE = True
            Else
                If CheckClear = True Then z7111 = Nothing
            End If

            If getColumIndex(spr, "ShoesCode") > -1 Then z7111.ShoesCode = getDataM(spr, getColumIndex(spr, "ShoesCode"), xRow)
            If getColumIndex(spr, "MaterialSeq") > -1 Then z7111.MaterialSeq = getDataM(spr, getColumIndex(spr, "MaterialSeq"), xRow)
            If getColumIndex(spr, "DSeq") > -1 Then z7111.DSeq = getDataM(spr, getColumIndex(spr, "DSeq"), xRow)
            If getColumIndex(spr, "QtyComponent") > -1 Then z7111.QtyComponent = getDataM(spr, getColumIndex(spr, "QtyComponent"), xRow)
            If getColumIndex(spr, "CSizeQty01") > -1 Then z7111.CSizeQty01 = getDataM(spr, getColumIndex(spr, "CSizeQty01"), xRow)
            If getColumIndex(spr, "CSizeQty02") > -1 Then z7111.CSizeQty02 = getDataM(spr, getColumIndex(spr, "CSizeQty02"), xRow)
            If getColumIndex(spr, "CSizeQty03") > -1 Then z7111.CSizeQty03 = getDataM(spr, getColumIndex(spr, "CSizeQty03"), xRow)
            If getColumIndex(spr, "CSizeQty04") > -1 Then z7111.CSizeQty04 = getDataM(spr, getColumIndex(spr, "CSizeQty04"), xRow)
            If getColumIndex(spr, "CSizeQty05") > -1 Then z7111.CSizeQty05 = getDataM(spr, getColumIndex(spr, "CSizeQty05"), xRow)
            If getColumIndex(spr, "CSizeQty06") > -1 Then z7111.CSizeQty06 = getDataM(spr, getColumIndex(spr, "CSizeQty06"), xRow)
            If getColumIndex(spr, "CSizeQty07") > -1 Then z7111.CSizeQty07 = getDataM(spr, getColumIndex(spr, "CSizeQty07"), xRow)
            If getColumIndex(spr, "CSizeQty08") > -1 Then z7111.CSizeQty08 = getDataM(spr, getColumIndex(spr, "CSizeQty08"), xRow)
            If getColumIndex(spr, "CSizeQty09") > -1 Then z7111.CSizeQty09 = getDataM(spr, getColumIndex(spr, "CSizeQty09"), xRow)
            If getColumIndex(spr, "CSizeQty10") > -1 Then z7111.CSizeQty10 = getDataM(spr, getColumIndex(spr, "CSizeQty10"), xRow)
            If getColumIndex(spr, "CSizeQty11") > -1 Then z7111.CSizeQty11 = getDataM(spr, getColumIndex(spr, "CSizeQty11"), xRow)
            If getColumIndex(spr, "CSizeQty12") > -1 Then z7111.CSizeQty12 = getDataM(spr, getColumIndex(spr, "CSizeQty12"), xRow)
            If getColumIndex(spr, "CSizeQty13") > -1 Then z7111.CSizeQty13 = getDataM(spr, getColumIndex(spr, "CSizeQty13"), xRow)
            If getColumIndex(spr, "CSizeQty14") > -1 Then z7111.CSizeQty14 = getDataM(spr, getColumIndex(spr, "CSizeQty14"), xRow)
            If getColumIndex(spr, "CSizeQty15") > -1 Then z7111.CSizeQty15 = getDataM(spr, getColumIndex(spr, "CSizeQty15"), xRow)
            If getColumIndex(spr, "CSizeQty16") > -1 Then z7111.CSizeQty16 = getDataM(spr, getColumIndex(spr, "CSizeQty16"), xRow)
            If getColumIndex(spr, "CSizeQty17") > -1 Then z7111.CSizeQty17 = getDataM(spr, getColumIndex(spr, "CSizeQty17"), xRow)
            If getColumIndex(spr, "CSizeQty18") > -1 Then z7111.CSizeQty18 = getDataM(spr, getColumIndex(spr, "CSizeQty18"), xRow)
            If getColumIndex(spr, "CSizeQty19") > -1 Then z7111.CSizeQty19 = getDataM(spr, getColumIndex(spr, "CSizeQty19"), xRow)
            If getColumIndex(spr, "CSizeQty20") > -1 Then z7111.CSizeQty20 = getDataM(spr, getColumIndex(spr, "CSizeQty20"), xRow)
            If getColumIndex(spr, "CSizeQty21") > -1 Then z7111.CSizeQty21 = getDataM(spr, getColumIndex(spr, "CSizeQty21"), xRow)
            If getColumIndex(spr, "CSizeQty22") > -1 Then z7111.CSizeQty22 = getDataM(spr, getColumIndex(spr, "CSizeQty22"), xRow)
            If getColumIndex(spr, "CSizeQty23") > -1 Then z7111.CSizeQty23 = getDataM(spr, getColumIndex(spr, "CSizeQty23"), xRow)
            If getColumIndex(spr, "CSizeQty24") > -1 Then z7111.CSizeQty24 = getDataM(spr, getColumIndex(spr, "CSizeQty24"), xRow)
            If getColumIndex(spr, "CSizeQty25") > -1 Then z7111.CSizeQty25 = getDataM(spr, getColumIndex(spr, "CSizeQty25"), xRow)
            If getColumIndex(spr, "CSizeQty26") > -1 Then z7111.CSizeQty26 = getDataM(spr, getColumIndex(spr, "CSizeQty26"), xRow)
            If getColumIndex(spr, "CSizeQty27") > -1 Then z7111.CSizeQty27 = getDataM(spr, getColumIndex(spr, "CSizeQty27"), xRow)
            If getColumIndex(spr, "CSizeQty28") > -1 Then z7111.CSizeQty28 = getDataM(spr, getColumIndex(spr, "CSizeQty28"), xRow)
            If getColumIndex(spr, "CSizeQty29") > -1 Then z7111.CSizeQty29 = getDataM(spr, getColumIndex(spr, "CSizeQty29"), xRow)
            If getColumIndex(spr, "CSizeQty30") > -1 Then z7111.CSizeQty30 = getDataM(spr, getColumIndex(spr, "CSizeQty30"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z7111.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7111_MOVE", vbCritical)
        End Try
    End Function

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
    Public Function K7111_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7111 As T7111_AREA, Job As String, SHOESCODE As String, MATERIALSEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7111_MOVE = False

        Try
            If READ_PFK7111(SHOESCODE, MATERIALSEQ) = True Then
                z7111 = D7111
                K7111_MOVE = True
            Else
                z7111 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7111")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "SHOESCODE" : z7111.ShoesCode = Children(i).Code
                                Case "MATERIALSEQ" : z7111.MaterialSeq = Children(i).Code
                                Case "DSEQ" : z7111.DSeq = Children(i).Code
                                Case "QTYCOMPONENT" : z7111.QtyComponent = Children(i).Code
                                Case "CSIZEQTY01" : z7111.CSizeQty01 = Children(i).Code
                                Case "CSIZEQTY02" : z7111.CSizeQty02 = Children(i).Code
                                Case "CSIZEQTY03" : z7111.CSizeQty03 = Children(i).Code
                                Case "CSIZEQTY04" : z7111.CSizeQty04 = Children(i).Code
                                Case "CSIZEQTY05" : z7111.CSizeQty05 = Children(i).Code
                                Case "CSIZEQTY06" : z7111.CSizeQty06 = Children(i).Code
                                Case "CSIZEQTY07" : z7111.CSizeQty07 = Children(i).Code
                                Case "CSIZEQTY08" : z7111.CSizeQty08 = Children(i).Code
                                Case "CSIZEQTY09" : z7111.CSizeQty09 = Children(i).Code
                                Case "CSIZEQTY10" : z7111.CSizeQty10 = Children(i).Code
                                Case "CSIZEQTY11" : z7111.CSizeQty11 = Children(i).Code
                                Case "CSIZEQTY12" : z7111.CSizeQty12 = Children(i).Code
                                Case "CSIZEQTY13" : z7111.CSizeQty13 = Children(i).Code
                                Case "CSIZEQTY14" : z7111.CSizeQty14 = Children(i).Code
                                Case "CSIZEQTY15" : z7111.CSizeQty15 = Children(i).Code
                                Case "CSIZEQTY16" : z7111.CSizeQty16 = Children(i).Code
                                Case "CSIZEQTY17" : z7111.CSizeQty17 = Children(i).Code
                                Case "CSIZEQTY18" : z7111.CSizeQty18 = Children(i).Code
                                Case "CSIZEQTY19" : z7111.CSizeQty19 = Children(i).Code
                                Case "CSIZEQTY20" : z7111.CSizeQty20 = Children(i).Code
                                Case "CSIZEQTY21" : z7111.CSizeQty21 = Children(i).Code
                                Case "CSIZEQTY22" : z7111.CSizeQty22 = Children(i).Code
                                Case "CSIZEQTY23" : z7111.CSizeQty23 = Children(i).Code
                                Case "CSIZEQTY24" : z7111.CSizeQty24 = Children(i).Code
                                Case "CSIZEQTY25" : z7111.CSizeQty25 = Children(i).Code
                                Case "CSIZEQTY26" : z7111.CSizeQty26 = Children(i).Code
                                Case "CSIZEQTY27" : z7111.CSizeQty27 = Children(i).Code
                                Case "CSIZEQTY28" : z7111.CSizeQty28 = Children(i).Code
                                Case "CSIZEQTY29" : z7111.CSizeQty29 = Children(i).Code
                                Case "CSIZEQTY30" : z7111.CSizeQty30 = Children(i).Code
                                Case "REMARK" : z7111.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "SHOESCODE" : z7111.ShoesCode = Children(i).Data
                                Case "MATERIALSEQ" : z7111.MaterialSeq = Children(i).Data
                                Case "DSEQ" : z7111.DSeq = Children(i).Data
                                Case "QTYCOMPONENT" : z7111.QtyComponent = Children(i).Data
                                Case "CSIZEQTY01" : z7111.CSizeQty01 = Children(i).Data
                                Case "CSIZEQTY02" : z7111.CSizeQty02 = Children(i).Data
                                Case "CSIZEQTY03" : z7111.CSizeQty03 = Children(i).Data
                                Case "CSIZEQTY04" : z7111.CSizeQty04 = Children(i).Data
                                Case "CSIZEQTY05" : z7111.CSizeQty05 = Children(i).Data
                                Case "CSIZEQTY06" : z7111.CSizeQty06 = Children(i).Data
                                Case "CSIZEQTY07" : z7111.CSizeQty07 = Children(i).Data
                                Case "CSIZEQTY08" : z7111.CSizeQty08 = Children(i).Data
                                Case "CSIZEQTY09" : z7111.CSizeQty09 = Children(i).Data
                                Case "CSIZEQTY10" : z7111.CSizeQty10 = Children(i).Data
                                Case "CSIZEQTY11" : z7111.CSizeQty11 = Children(i).Data
                                Case "CSIZEQTY12" : z7111.CSizeQty12 = Children(i).Data
                                Case "CSIZEQTY13" : z7111.CSizeQty13 = Children(i).Data
                                Case "CSIZEQTY14" : z7111.CSizeQty14 = Children(i).Data
                                Case "CSIZEQTY15" : z7111.CSizeQty15 = Children(i).Data
                                Case "CSIZEQTY16" : z7111.CSizeQty16 = Children(i).Data
                                Case "CSIZEQTY17" : z7111.CSizeQty17 = Children(i).Data
                                Case "CSIZEQTY18" : z7111.CSizeQty18 = Children(i).Data
                                Case "CSIZEQTY19" : z7111.CSizeQty19 = Children(i).Data
                                Case "CSIZEQTY20" : z7111.CSizeQty20 = Children(i).Data
                                Case "CSIZEQTY21" : z7111.CSizeQty21 = Children(i).Data
                                Case "CSIZEQTY22" : z7111.CSizeQty22 = Children(i).Data
                                Case "CSIZEQTY23" : z7111.CSizeQty23 = Children(i).Data
                                Case "CSIZEQTY24" : z7111.CSizeQty24 = Children(i).Data
                                Case "CSIZEQTY25" : z7111.CSizeQty25 = Children(i).Data
                                Case "CSIZEQTY26" : z7111.CSizeQty26 = Children(i).Data
                                Case "CSIZEQTY27" : z7111.CSizeQty27 = Children(i).Data
                                Case "CSIZEQTY28" : z7111.CSizeQty28 = Children(i).Data
                                Case "CSIZEQTY29" : z7111.CSizeQty29 = Children(i).Data
                                Case "CSIZEQTY30" : z7111.CSizeQty30 = Children(i).Data
                                Case "REMARK" : z7111.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7111_MOVE", vbCritical)
        End Try
    End Function

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
    Public Function K7111_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7111 As T7111_AREA, Job As String, CheckClear As Boolean, SHOESCODE As String, MATERIALSEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7111_MOVE = False

        Try
            If READ_PFK7111(SHOESCODE, MATERIALSEQ) = True Then
                z7111 = D7111
                K7111_MOVE = True
            Else
                If CheckClear = True Then z7111 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7111")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "SHOESCODE" : z7111.ShoesCode = Children(i).Code
                                Case "MATERIALSEQ" : z7111.MaterialSeq = Children(i).Code
                                Case "DSEQ" : z7111.DSeq = Children(i).Code
                                Case "QTYCOMPONENT" : z7111.QtyComponent = Children(i).Code
                                Case "CSIZEQTY01" : z7111.CSizeQty01 = Children(i).Code
                                Case "CSIZEQTY02" : z7111.CSizeQty02 = Children(i).Code
                                Case "CSIZEQTY03" : z7111.CSizeQty03 = Children(i).Code
                                Case "CSIZEQTY04" : z7111.CSizeQty04 = Children(i).Code
                                Case "CSIZEQTY05" : z7111.CSizeQty05 = Children(i).Code
                                Case "CSIZEQTY06" : z7111.CSizeQty06 = Children(i).Code
                                Case "CSIZEQTY07" : z7111.CSizeQty07 = Children(i).Code
                                Case "CSIZEQTY08" : z7111.CSizeQty08 = Children(i).Code
                                Case "CSIZEQTY09" : z7111.CSizeQty09 = Children(i).Code
                                Case "CSIZEQTY10" : z7111.CSizeQty10 = Children(i).Code
                                Case "CSIZEQTY11" : z7111.CSizeQty11 = Children(i).Code
                                Case "CSIZEQTY12" : z7111.CSizeQty12 = Children(i).Code
                                Case "CSIZEQTY13" : z7111.CSizeQty13 = Children(i).Code
                                Case "CSIZEQTY14" : z7111.CSizeQty14 = Children(i).Code
                                Case "CSIZEQTY15" : z7111.CSizeQty15 = Children(i).Code
                                Case "CSIZEQTY16" : z7111.CSizeQty16 = Children(i).Code
                                Case "CSIZEQTY17" : z7111.CSizeQty17 = Children(i).Code
                                Case "CSIZEQTY18" : z7111.CSizeQty18 = Children(i).Code
                                Case "CSIZEQTY19" : z7111.CSizeQty19 = Children(i).Code
                                Case "CSIZEQTY20" : z7111.CSizeQty20 = Children(i).Code
                                Case "CSIZEQTY21" : z7111.CSizeQty21 = Children(i).Code
                                Case "CSIZEQTY22" : z7111.CSizeQty22 = Children(i).Code
                                Case "CSIZEQTY23" : z7111.CSizeQty23 = Children(i).Code
                                Case "CSIZEQTY24" : z7111.CSizeQty24 = Children(i).Code
                                Case "CSIZEQTY25" : z7111.CSizeQty25 = Children(i).Code
                                Case "CSIZEQTY26" : z7111.CSizeQty26 = Children(i).Code
                                Case "CSIZEQTY27" : z7111.CSizeQty27 = Children(i).Code
                                Case "CSIZEQTY28" : z7111.CSizeQty28 = Children(i).Code
                                Case "CSIZEQTY29" : z7111.CSizeQty29 = Children(i).Code
                                Case "CSIZEQTY30" : z7111.CSizeQty30 = Children(i).Code
                                Case "REMARK" : z7111.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "SHOESCODE" : z7111.ShoesCode = Children(i).Data
                                Case "MATERIALSEQ" : z7111.MaterialSeq = Children(i).Data
                                Case "DSEQ" : z7111.DSeq = Children(i).Data
                                Case "QTYCOMPONENT" : z7111.QtyComponent = Children(i).Data
                                Case "CSIZEQTY01" : z7111.CSizeQty01 = Children(i).Data
                                Case "CSIZEQTY02" : z7111.CSizeQty02 = Children(i).Data
                                Case "CSIZEQTY03" : z7111.CSizeQty03 = Children(i).Data
                                Case "CSIZEQTY04" : z7111.CSizeQty04 = Children(i).Data
                                Case "CSIZEQTY05" : z7111.CSizeQty05 = Children(i).Data
                                Case "CSIZEQTY06" : z7111.CSizeQty06 = Children(i).Data
                                Case "CSIZEQTY07" : z7111.CSizeQty07 = Children(i).Data
                                Case "CSIZEQTY08" : z7111.CSizeQty08 = Children(i).Data
                                Case "CSIZEQTY09" : z7111.CSizeQty09 = Children(i).Data
                                Case "CSIZEQTY10" : z7111.CSizeQty10 = Children(i).Data
                                Case "CSIZEQTY11" : z7111.CSizeQty11 = Children(i).Data
                                Case "CSIZEQTY12" : z7111.CSizeQty12 = Children(i).Data
                                Case "CSIZEQTY13" : z7111.CSizeQty13 = Children(i).Data
                                Case "CSIZEQTY14" : z7111.CSizeQty14 = Children(i).Data
                                Case "CSIZEQTY15" : z7111.CSizeQty15 = Children(i).Data
                                Case "CSIZEQTY16" : z7111.CSizeQty16 = Children(i).Data
                                Case "CSIZEQTY17" : z7111.CSizeQty17 = Children(i).Data
                                Case "CSIZEQTY18" : z7111.CSizeQty18 = Children(i).Data
                                Case "CSIZEQTY19" : z7111.CSizeQty19 = Children(i).Data
                                Case "CSIZEQTY20" : z7111.CSizeQty20 = Children(i).Data
                                Case "CSIZEQTY21" : z7111.CSizeQty21 = Children(i).Data
                                Case "CSIZEQTY22" : z7111.CSizeQty22 = Children(i).Data
                                Case "CSIZEQTY23" : z7111.CSizeQty23 = Children(i).Data
                                Case "CSIZEQTY24" : z7111.CSizeQty24 = Children(i).Data
                                Case "CSIZEQTY25" : z7111.CSizeQty25 = Children(i).Data
                                Case "CSIZEQTY26" : z7111.CSizeQty26 = Children(i).Data
                                Case "CSIZEQTY27" : z7111.CSizeQty27 = Children(i).Data
                                Case "CSIZEQTY28" : z7111.CSizeQty28 = Children(i).Data
                                Case "CSIZEQTY29" : z7111.CSizeQty29 = Children(i).Data
                                Case "CSIZEQTY30" : z7111.CSizeQty30 = Children(i).Data
                                Case "REMARK" : z7111.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7111_MOVE", vbCritical)
        End Try
    End Function
    
End Module 
