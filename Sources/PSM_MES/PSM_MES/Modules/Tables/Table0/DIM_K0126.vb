'=========================================================================================================================================================
'   TABLE : (PFK0126)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K0126

Structure T0126_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	SpecNo	 AS String	'			char(9)		*
Public 	SpecNoSeq	 AS String	'			char(3)		*
Public 	ProcessSeq	 AS String	'			char(3)		*
Public 	MatchingSeq	 AS Double	'			decimal		*
Public 	Status	 AS String	'			char(1)
Public 	seMainProcess	 AS String	'			char(3)
Public 	cdMainProcess	 AS String	'			char(3)
Public 	seSubProcess	 AS String	'			char(3)
Public 	cdSubProcess	 AS String	'			char(3)
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
Public 	SizeQty20	 AS Double	'			decimal
Public 	SizeQty19	 AS Double	'			decimal
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

Public D0126 As T0126_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK0126(SPECNO AS String, SPECNOSEQ AS String, PROCESSSEQ AS String, MATCHINGSEQ AS Double) As Boolean
    READ_PFK0126 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0126 "
    SQL = SQL & " WHERE K0126_SpecNo		 = '" & SpecNo & "' " 
    SQL = SQL & "   AND K0126_SpecNoSeq		 = '" & SpecNoSeq & "' " 
    SQL = SQL & "   AND K0126_ProcessSeq		 = '" & ProcessSeq & "' " 
    SQL = SQL & "   AND K0126_MatchingSeq		 =  " & MatchingSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D0126_CLEAR: GoTo SKIP_READ_PFK0126
                
    Call K0126_MOVE(rd)
    READ_PFK0126 = True

SKIP_READ_PFK0126:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK0126",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK0126(SPECNO AS String, SPECNOSEQ AS String, PROCESSSEQ AS String, MATCHINGSEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0126 "
    SQL = SQL & " WHERE K0126_SpecNo		 = '" & SpecNo & "' " 
    SQL = SQL & "   AND K0126_SpecNoSeq		 = '" & SpecNoSeq & "' " 
    SQL = SQL & "   AND K0126_ProcessSeq		 = '" & ProcessSeq & "' " 
    SQL = SQL & "   AND K0126_MatchingSeq		 =  " & MatchingSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK0126",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK0126(z0126 As T0126_AREA) As Boolean
    WRITE_PFK0126 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z0126)
 
    SQL = " INSERT INTO PFK0126 "
    SQL = SQL & " ( "
    SQL = SQL & " K0126_SpecNo," 
    SQL = SQL & " K0126_SpecNoSeq," 
    SQL = SQL & " K0126_ProcessSeq," 
    SQL = SQL & " K0126_MatchingSeq," 
    SQL = SQL & " K0126_Status," 
    SQL = SQL & " K0126_seMainProcess," 
    SQL = SQL & " K0126_cdMainProcess," 
    SQL = SQL & " K0126_seSubProcess," 
    SQL = SQL & " K0126_cdSubProcess," 
    SQL = SQL & " K0126_SizeQty01," 
    SQL = SQL & " K0126_SizeQty02," 
    SQL = SQL & " K0126_SizeQty03," 
    SQL = SQL & " K0126_SizeQty04," 
    SQL = SQL & " K0126_SizeQty05," 
    SQL = SQL & " K0126_SizeQty06," 
    SQL = SQL & " K0126_SizeQty07," 
    SQL = SQL & " K0126_SizeQty08," 
    SQL = SQL & " K0126_SizeQty09," 
    SQL = SQL & " K0126_SizeQty10," 
    SQL = SQL & " K0126_SizeQty11," 
    SQL = SQL & " K0126_SizeQty12," 
    SQL = SQL & " K0126_SizeQty13," 
    SQL = SQL & " K0126_SizeQty14," 
    SQL = SQL & " K0126_SizeQty15," 
    SQL = SQL & " K0126_SizeQty16," 
    SQL = SQL & " K0126_SizeQty17," 
    SQL = SQL & " K0126_SizeQty18," 
    SQL = SQL & " K0126_SizeQty20," 
    SQL = SQL & " K0126_SizeQty19," 
    SQL = SQL & " K0126_SizeQty21," 
    SQL = SQL & " K0126_SizeQty22," 
    SQL = SQL & " K0126_SizeQty23," 
    SQL = SQL & " K0126_SizeQty24," 
    SQL = SQL & " K0126_SizeQty25," 
    SQL = SQL & " K0126_SizeQty26," 
    SQL = SQL & " K0126_SizeQty27," 
    SQL = SQL & " K0126_SizeQty28," 
    SQL = SQL & " K0126_SizeQty29," 
    SQL = SQL & " K0126_SizeQty30," 
    SQL = SQL & " K0126_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z0126.SpecNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0126.SpecNoSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0126.ProcessSeq) & "', "  
    SQL = SQL & "   " & FormatSQL(z0126.MatchingSeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z0126.Status) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0126.seMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0126.cdMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0126.seSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0126.cdSubProcess) & "', "  
    SQL = SQL & "   " & FormatSQL(z0126.SizeQty01) & ", "  
    SQL = SQL & "   " & FormatSQL(z0126.SizeQty02) & ", "  
    SQL = SQL & "   " & FormatSQL(z0126.SizeQty03) & ", "  
    SQL = SQL & "   " & FormatSQL(z0126.SizeQty04) & ", "  
    SQL = SQL & "   " & FormatSQL(z0126.SizeQty05) & ", "  
    SQL = SQL & "   " & FormatSQL(z0126.SizeQty06) & ", "  
    SQL = SQL & "   " & FormatSQL(z0126.SizeQty07) & ", "  
    SQL = SQL & "   " & FormatSQL(z0126.SizeQty08) & ", "  
    SQL = SQL & "   " & FormatSQL(z0126.SizeQty09) & ", "  
    SQL = SQL & "   " & FormatSQL(z0126.SizeQty10) & ", "  
    SQL = SQL & "   " & FormatSQL(z0126.SizeQty11) & ", "  
    SQL = SQL & "   " & FormatSQL(z0126.SizeQty12) & ", "  
    SQL = SQL & "   " & FormatSQL(z0126.SizeQty13) & ", "  
    SQL = SQL & "   " & FormatSQL(z0126.SizeQty14) & ", "  
    SQL = SQL & "   " & FormatSQL(z0126.SizeQty15) & ", "  
    SQL = SQL & "   " & FormatSQL(z0126.SizeQty16) & ", "  
    SQL = SQL & "   " & FormatSQL(z0126.SizeQty17) & ", "  
    SQL = SQL & "   " & FormatSQL(z0126.SizeQty18) & ", "  
    SQL = SQL & "   " & FormatSQL(z0126.SizeQty20) & ", "  
    SQL = SQL & "   " & FormatSQL(z0126.SizeQty19) & ", "  
    SQL = SQL & "   " & FormatSQL(z0126.SizeQty21) & ", "  
    SQL = SQL & "   " & FormatSQL(z0126.SizeQty22) & ", "  
    SQL = SQL & "   " & FormatSQL(z0126.SizeQty23) & ", "  
    SQL = SQL & "   " & FormatSQL(z0126.SizeQty24) & ", "  
    SQL = SQL & "   " & FormatSQL(z0126.SizeQty25) & ", "  
    SQL = SQL & "   " & FormatSQL(z0126.SizeQty26) & ", "  
    SQL = SQL & "   " & FormatSQL(z0126.SizeQty27) & ", "  
    SQL = SQL & "   " & FormatSQL(z0126.SizeQty28) & ", "  
    SQL = SQL & "   " & FormatSQL(z0126.SizeQty29) & ", "  
    SQL = SQL & "   " & FormatSQL(z0126.SizeQty30) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z0126.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK0126 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK0126",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK0126(z0126 As T0126_AREA) As Boolean
    REWRITE_PFK0126 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z0126)
   
    SQL = " UPDATE PFK0126 SET "
    SQL = SQL & "    K0126_Status      = N'" & FormatSQL(z0126.Status) & "', " 
    SQL = SQL & "    K0126_seMainProcess      = N'" & FormatSQL(z0126.seMainProcess) & "', " 
    SQL = SQL & "    K0126_cdMainProcess      = N'" & FormatSQL(z0126.cdMainProcess) & "', " 
    SQL = SQL & "    K0126_seSubProcess      = N'" & FormatSQL(z0126.seSubProcess) & "', " 
    SQL = SQL & "    K0126_cdSubProcess      = N'" & FormatSQL(z0126.cdSubProcess) & "', " 
    SQL = SQL & "    K0126_SizeQty01      =  " & FormatSQL(z0126.SizeQty01) & ", " 
    SQL = SQL & "    K0126_SizeQty02      =  " & FormatSQL(z0126.SizeQty02) & ", " 
    SQL = SQL & "    K0126_SizeQty03      =  " & FormatSQL(z0126.SizeQty03) & ", " 
    SQL = SQL & "    K0126_SizeQty04      =  " & FormatSQL(z0126.SizeQty04) & ", " 
    SQL = SQL & "    K0126_SizeQty05      =  " & FormatSQL(z0126.SizeQty05) & ", " 
    SQL = SQL & "    K0126_SizeQty06      =  " & FormatSQL(z0126.SizeQty06) & ", " 
    SQL = SQL & "    K0126_SizeQty07      =  " & FormatSQL(z0126.SizeQty07) & ", " 
    SQL = SQL & "    K0126_SizeQty08      =  " & FormatSQL(z0126.SizeQty08) & ", " 
    SQL = SQL & "    K0126_SizeQty09      =  " & FormatSQL(z0126.SizeQty09) & ", " 
    SQL = SQL & "    K0126_SizeQty10      =  " & FormatSQL(z0126.SizeQty10) & ", " 
    SQL = SQL & "    K0126_SizeQty11      =  " & FormatSQL(z0126.SizeQty11) & ", " 
    SQL = SQL & "    K0126_SizeQty12      =  " & FormatSQL(z0126.SizeQty12) & ", " 
    SQL = SQL & "    K0126_SizeQty13      =  " & FormatSQL(z0126.SizeQty13) & ", " 
    SQL = SQL & "    K0126_SizeQty14      =  " & FormatSQL(z0126.SizeQty14) & ", " 
    SQL = SQL & "    K0126_SizeQty15      =  " & FormatSQL(z0126.SizeQty15) & ", " 
    SQL = SQL & "    K0126_SizeQty16      =  " & FormatSQL(z0126.SizeQty16) & ", " 
    SQL = SQL & "    K0126_SizeQty17      =  " & FormatSQL(z0126.SizeQty17) & ", " 
    SQL = SQL & "    K0126_SizeQty18      =  " & FormatSQL(z0126.SizeQty18) & ", " 
    SQL = SQL & "    K0126_SizeQty20      =  " & FormatSQL(z0126.SizeQty20) & ", " 
    SQL = SQL & "    K0126_SizeQty19      =  " & FormatSQL(z0126.SizeQty19) & ", " 
    SQL = SQL & "    K0126_SizeQty21      =  " & FormatSQL(z0126.SizeQty21) & ", " 
    SQL = SQL & "    K0126_SizeQty22      =  " & FormatSQL(z0126.SizeQty22) & ", " 
    SQL = SQL & "    K0126_SizeQty23      =  " & FormatSQL(z0126.SizeQty23) & ", " 
    SQL = SQL & "    K0126_SizeQty24      =  " & FormatSQL(z0126.SizeQty24) & ", " 
    SQL = SQL & "    K0126_SizeQty25      =  " & FormatSQL(z0126.SizeQty25) & ", " 
    SQL = SQL & "    K0126_SizeQty26      =  " & FormatSQL(z0126.SizeQty26) & ", " 
    SQL = SQL & "    K0126_SizeQty27      =  " & FormatSQL(z0126.SizeQty27) & ", " 
    SQL = SQL & "    K0126_SizeQty28      =  " & FormatSQL(z0126.SizeQty28) & ", " 
    SQL = SQL & "    K0126_SizeQty29      =  " & FormatSQL(z0126.SizeQty29) & ", " 
    SQL = SQL & "    K0126_SizeQty30      =  " & FormatSQL(z0126.SizeQty30) & ", " 
    SQL = SQL & "    K0126_Remark      = N'" & FormatSQL(z0126.Remark) & "'  " 
    SQL = SQL & " WHERE K0126_SpecNo		 = '" & z0126.SpecNo & "' " 
    SQL = SQL & "   AND K0126_SpecNoSeq		 = '" & z0126.SpecNoSeq & "' " 
    SQL = SQL & "   AND K0126_ProcessSeq		 = '" & z0126.ProcessSeq & "' " 
    SQL = SQL & "   AND K0126_MatchingSeq		 =  " & z0126.MatchingSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK0126 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK0126",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK0126(z0126 As T0126_AREA) As Boolean
    DELETE_PFK0126 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK0126 "
    SQL = SQL & " WHERE K0126_SpecNo		 = '" & z0126.SpecNo & "' " 
    SQL = SQL & "   AND K0126_SpecNoSeq		 = '" & z0126.SpecNoSeq & "' " 
    SQL = SQL & "   AND K0126_ProcessSeq		 = '" & z0126.ProcessSeq & "' " 
    SQL = SQL & "   AND K0126_MatchingSeq		 =  " & z0126.MatchingSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK0126 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK0126",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D0126_CLEAR()
Try
    
   D0126.SpecNo = ""
   D0126.SpecNoSeq = ""
   D0126.ProcessSeq = ""
    D0126.MatchingSeq = 0 
   D0126.Status = ""
   D0126.seMainProcess = ""
   D0126.cdMainProcess = ""
   D0126.seSubProcess = ""
   D0126.cdSubProcess = ""
    D0126.SizeQty01 = 0 
    D0126.SizeQty02 = 0 
    D0126.SizeQty03 = 0 
    D0126.SizeQty04 = 0 
    D0126.SizeQty05 = 0 
    D0126.SizeQty06 = 0 
    D0126.SizeQty07 = 0 
    D0126.SizeQty08 = 0 
    D0126.SizeQty09 = 0 
    D0126.SizeQty10 = 0 
    D0126.SizeQty11 = 0 
    D0126.SizeQty12 = 0 
    D0126.SizeQty13 = 0 
    D0126.SizeQty14 = 0 
    D0126.SizeQty15 = 0 
    D0126.SizeQty16 = 0 
    D0126.SizeQty17 = 0 
    D0126.SizeQty18 = 0 
    D0126.SizeQty20 = 0 
    D0126.SizeQty19 = 0 
    D0126.SizeQty21 = 0 
    D0126.SizeQty22 = 0 
    D0126.SizeQty23 = 0 
    D0126.SizeQty24 = 0 
    D0126.SizeQty25 = 0 
    D0126.SizeQty26 = 0 
    D0126.SizeQty27 = 0 
    D0126.SizeQty28 = 0 
    D0126.SizeQty29 = 0 
    D0126.SizeQty30 = 0 
   D0126.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D0126_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x0126 As T0126_AREA)
Try
    
    x0126.SpecNo = trim$(  x0126.SpecNo)
    x0126.SpecNoSeq = trim$(  x0126.SpecNoSeq)
    x0126.ProcessSeq = trim$(  x0126.ProcessSeq)
    x0126.MatchingSeq = trim$(  x0126.MatchingSeq)
    x0126.Status = trim$(  x0126.Status)
    x0126.seMainProcess = trim$(  x0126.seMainProcess)
    x0126.cdMainProcess = trim$(  x0126.cdMainProcess)
    x0126.seSubProcess = trim$(  x0126.seSubProcess)
    x0126.cdSubProcess = trim$(  x0126.cdSubProcess)
    x0126.SizeQty01 = trim$(  x0126.SizeQty01)
    x0126.SizeQty02 = trim$(  x0126.SizeQty02)
    x0126.SizeQty03 = trim$(  x0126.SizeQty03)
    x0126.SizeQty04 = trim$(  x0126.SizeQty04)
    x0126.SizeQty05 = trim$(  x0126.SizeQty05)
    x0126.SizeQty06 = trim$(  x0126.SizeQty06)
    x0126.SizeQty07 = trim$(  x0126.SizeQty07)
    x0126.SizeQty08 = trim$(  x0126.SizeQty08)
    x0126.SizeQty09 = trim$(  x0126.SizeQty09)
    x0126.SizeQty10 = trim$(  x0126.SizeQty10)
    x0126.SizeQty11 = trim$(  x0126.SizeQty11)
    x0126.SizeQty12 = trim$(  x0126.SizeQty12)
    x0126.SizeQty13 = trim$(  x0126.SizeQty13)
    x0126.SizeQty14 = trim$(  x0126.SizeQty14)
    x0126.SizeQty15 = trim$(  x0126.SizeQty15)
    x0126.SizeQty16 = trim$(  x0126.SizeQty16)
    x0126.SizeQty17 = trim$(  x0126.SizeQty17)
    x0126.SizeQty18 = trim$(  x0126.SizeQty18)
    x0126.SizeQty20 = trim$(  x0126.SizeQty20)
    x0126.SizeQty19 = trim$(  x0126.SizeQty19)
    x0126.SizeQty21 = trim$(  x0126.SizeQty21)
    x0126.SizeQty22 = trim$(  x0126.SizeQty22)
    x0126.SizeQty23 = trim$(  x0126.SizeQty23)
    x0126.SizeQty24 = trim$(  x0126.SizeQty24)
    x0126.SizeQty25 = trim$(  x0126.SizeQty25)
    x0126.SizeQty26 = trim$(  x0126.SizeQty26)
    x0126.SizeQty27 = trim$(  x0126.SizeQty27)
    x0126.SizeQty28 = trim$(  x0126.SizeQty28)
    x0126.SizeQty29 = trim$(  x0126.SizeQty29)
    x0126.SizeQty30 = trim$(  x0126.SizeQty30)
    x0126.Remark = trim$(  x0126.Remark)
     
    If trim$( x0126.SpecNo ) = "" Then x0126.SpecNo = Space(1) 
    If trim$( x0126.SpecNoSeq ) = "" Then x0126.SpecNoSeq = Space(1) 
    If trim$( x0126.ProcessSeq ) = "" Then x0126.ProcessSeq = Space(1) 
    If trim$( x0126.MatchingSeq ) = "" Then x0126.MatchingSeq = 0 
    If trim$( x0126.Status ) = "" Then x0126.Status = Space(1) 
    If trim$( x0126.seMainProcess ) = "" Then x0126.seMainProcess = Space(1) 
    If trim$( x0126.cdMainProcess ) = "" Then x0126.cdMainProcess = Space(1) 
    If trim$( x0126.seSubProcess ) = "" Then x0126.seSubProcess = Space(1) 
    If trim$( x0126.cdSubProcess ) = "" Then x0126.cdSubProcess = Space(1) 
    If trim$( x0126.SizeQty01 ) = "" Then x0126.SizeQty01 = 0 
    If trim$( x0126.SizeQty02 ) = "" Then x0126.SizeQty02 = 0 
    If trim$( x0126.SizeQty03 ) = "" Then x0126.SizeQty03 = 0 
    If trim$( x0126.SizeQty04 ) = "" Then x0126.SizeQty04 = 0 
    If trim$( x0126.SizeQty05 ) = "" Then x0126.SizeQty05 = 0 
    If trim$( x0126.SizeQty06 ) = "" Then x0126.SizeQty06 = 0 
    If trim$( x0126.SizeQty07 ) = "" Then x0126.SizeQty07 = 0 
    If trim$( x0126.SizeQty08 ) = "" Then x0126.SizeQty08 = 0 
    If trim$( x0126.SizeQty09 ) = "" Then x0126.SizeQty09 = 0 
    If trim$( x0126.SizeQty10 ) = "" Then x0126.SizeQty10 = 0 
    If trim$( x0126.SizeQty11 ) = "" Then x0126.SizeQty11 = 0 
    If trim$( x0126.SizeQty12 ) = "" Then x0126.SizeQty12 = 0 
    If trim$( x0126.SizeQty13 ) = "" Then x0126.SizeQty13 = 0 
    If trim$( x0126.SizeQty14 ) = "" Then x0126.SizeQty14 = 0 
    If trim$( x0126.SizeQty15 ) = "" Then x0126.SizeQty15 = 0 
    If trim$( x0126.SizeQty16 ) = "" Then x0126.SizeQty16 = 0 
    If trim$( x0126.SizeQty17 ) = "" Then x0126.SizeQty17 = 0 
    If trim$( x0126.SizeQty18 ) = "" Then x0126.SizeQty18 = 0 
    If trim$( x0126.SizeQty20 ) = "" Then x0126.SizeQty20 = 0 
    If trim$( x0126.SizeQty19 ) = "" Then x0126.SizeQty19 = 0 
    If trim$( x0126.SizeQty21 ) = "" Then x0126.SizeQty21 = 0 
    If trim$( x0126.SizeQty22 ) = "" Then x0126.SizeQty22 = 0 
    If trim$( x0126.SizeQty23 ) = "" Then x0126.SizeQty23 = 0 
    If trim$( x0126.SizeQty24 ) = "" Then x0126.SizeQty24 = 0 
    If trim$( x0126.SizeQty25 ) = "" Then x0126.SizeQty25 = 0 
    If trim$( x0126.SizeQty26 ) = "" Then x0126.SizeQty26 = 0 
    If trim$( x0126.SizeQty27 ) = "" Then x0126.SizeQty27 = 0 
    If trim$( x0126.SizeQty28 ) = "" Then x0126.SizeQty28 = 0 
    If trim$( x0126.SizeQty29 ) = "" Then x0126.SizeQty29 = 0 
    If trim$( x0126.SizeQty30 ) = "" Then x0126.SizeQty30 = 0 
    If trim$( x0126.Remark ) = "" Then x0126.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K0126_MOVE(rs0126 As SqlClient.SqlDataReader)
Try

    call D0126_CLEAR()   

    If IsdbNull(rs0126!K0126_SpecNo) = False Then D0126.SpecNo = Trim$(rs0126!K0126_SpecNo)
    If IsdbNull(rs0126!K0126_SpecNoSeq) = False Then D0126.SpecNoSeq = Trim$(rs0126!K0126_SpecNoSeq)
    If IsdbNull(rs0126!K0126_ProcessSeq) = False Then D0126.ProcessSeq = Trim$(rs0126!K0126_ProcessSeq)
    If IsdbNull(rs0126!K0126_MatchingSeq) = False Then D0126.MatchingSeq = Trim$(rs0126!K0126_MatchingSeq)
    If IsdbNull(rs0126!K0126_Status) = False Then D0126.Status = Trim$(rs0126!K0126_Status)
    If IsdbNull(rs0126!K0126_seMainProcess) = False Then D0126.seMainProcess = Trim$(rs0126!K0126_seMainProcess)
    If IsdbNull(rs0126!K0126_cdMainProcess) = False Then D0126.cdMainProcess = Trim$(rs0126!K0126_cdMainProcess)
    If IsdbNull(rs0126!K0126_seSubProcess) = False Then D0126.seSubProcess = Trim$(rs0126!K0126_seSubProcess)
    If IsdbNull(rs0126!K0126_cdSubProcess) = False Then D0126.cdSubProcess = Trim$(rs0126!K0126_cdSubProcess)
    If IsdbNull(rs0126!K0126_SizeQty01) = False Then D0126.SizeQty01 = Trim$(rs0126!K0126_SizeQty01)
    If IsdbNull(rs0126!K0126_SizeQty02) = False Then D0126.SizeQty02 = Trim$(rs0126!K0126_SizeQty02)
    If IsdbNull(rs0126!K0126_SizeQty03) = False Then D0126.SizeQty03 = Trim$(rs0126!K0126_SizeQty03)
    If IsdbNull(rs0126!K0126_SizeQty04) = False Then D0126.SizeQty04 = Trim$(rs0126!K0126_SizeQty04)
    If IsdbNull(rs0126!K0126_SizeQty05) = False Then D0126.SizeQty05 = Trim$(rs0126!K0126_SizeQty05)
    If IsdbNull(rs0126!K0126_SizeQty06) = False Then D0126.SizeQty06 = Trim$(rs0126!K0126_SizeQty06)
    If IsdbNull(rs0126!K0126_SizeQty07) = False Then D0126.SizeQty07 = Trim$(rs0126!K0126_SizeQty07)
    If IsdbNull(rs0126!K0126_SizeQty08) = False Then D0126.SizeQty08 = Trim$(rs0126!K0126_SizeQty08)
    If IsdbNull(rs0126!K0126_SizeQty09) = False Then D0126.SizeQty09 = Trim$(rs0126!K0126_SizeQty09)
    If IsdbNull(rs0126!K0126_SizeQty10) = False Then D0126.SizeQty10 = Trim$(rs0126!K0126_SizeQty10)
    If IsdbNull(rs0126!K0126_SizeQty11) = False Then D0126.SizeQty11 = Trim$(rs0126!K0126_SizeQty11)
    If IsdbNull(rs0126!K0126_SizeQty12) = False Then D0126.SizeQty12 = Trim$(rs0126!K0126_SizeQty12)
    If IsdbNull(rs0126!K0126_SizeQty13) = False Then D0126.SizeQty13 = Trim$(rs0126!K0126_SizeQty13)
    If IsdbNull(rs0126!K0126_SizeQty14) = False Then D0126.SizeQty14 = Trim$(rs0126!K0126_SizeQty14)
    If IsdbNull(rs0126!K0126_SizeQty15) = False Then D0126.SizeQty15 = Trim$(rs0126!K0126_SizeQty15)
    If IsdbNull(rs0126!K0126_SizeQty16) = False Then D0126.SizeQty16 = Trim$(rs0126!K0126_SizeQty16)
    If IsdbNull(rs0126!K0126_SizeQty17) = False Then D0126.SizeQty17 = Trim$(rs0126!K0126_SizeQty17)
    If IsdbNull(rs0126!K0126_SizeQty18) = False Then D0126.SizeQty18 = Trim$(rs0126!K0126_SizeQty18)
    If IsdbNull(rs0126!K0126_SizeQty20) = False Then D0126.SizeQty20 = Trim$(rs0126!K0126_SizeQty20)
    If IsdbNull(rs0126!K0126_SizeQty19) = False Then D0126.SizeQty19 = Trim$(rs0126!K0126_SizeQty19)
    If IsdbNull(rs0126!K0126_SizeQty21) = False Then D0126.SizeQty21 = Trim$(rs0126!K0126_SizeQty21)
    If IsdbNull(rs0126!K0126_SizeQty22) = False Then D0126.SizeQty22 = Trim$(rs0126!K0126_SizeQty22)
    If IsdbNull(rs0126!K0126_SizeQty23) = False Then D0126.SizeQty23 = Trim$(rs0126!K0126_SizeQty23)
    If IsdbNull(rs0126!K0126_SizeQty24) = False Then D0126.SizeQty24 = Trim$(rs0126!K0126_SizeQty24)
    If IsdbNull(rs0126!K0126_SizeQty25) = False Then D0126.SizeQty25 = Trim$(rs0126!K0126_SizeQty25)
    If IsdbNull(rs0126!K0126_SizeQty26) = False Then D0126.SizeQty26 = Trim$(rs0126!K0126_SizeQty26)
    If IsdbNull(rs0126!K0126_SizeQty27) = False Then D0126.SizeQty27 = Trim$(rs0126!K0126_SizeQty27)
    If IsdbNull(rs0126!K0126_SizeQty28) = False Then D0126.SizeQty28 = Trim$(rs0126!K0126_SizeQty28)
    If IsdbNull(rs0126!K0126_SizeQty29) = False Then D0126.SizeQty29 = Trim$(rs0126!K0126_SizeQty29)
    If IsdbNull(rs0126!K0126_SizeQty30) = False Then D0126.SizeQty30 = Trim$(rs0126!K0126_SizeQty30)
    If IsdbNull(rs0126!K0126_Remark) = False Then D0126.Remark = Trim$(rs0126!K0126_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0126_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K0126_MOVE(rs0126 As DataRow)
Try

    call D0126_CLEAR()   

    If IsdbNull(rs0126!K0126_SpecNo) = False Then D0126.SpecNo = Trim$(rs0126!K0126_SpecNo)
    If IsdbNull(rs0126!K0126_SpecNoSeq) = False Then D0126.SpecNoSeq = Trim$(rs0126!K0126_SpecNoSeq)
    If IsdbNull(rs0126!K0126_ProcessSeq) = False Then D0126.ProcessSeq = Trim$(rs0126!K0126_ProcessSeq)
    If IsdbNull(rs0126!K0126_MatchingSeq) = False Then D0126.MatchingSeq = Trim$(rs0126!K0126_MatchingSeq)
    If IsdbNull(rs0126!K0126_Status) = False Then D0126.Status = Trim$(rs0126!K0126_Status)
    If IsdbNull(rs0126!K0126_seMainProcess) = False Then D0126.seMainProcess = Trim$(rs0126!K0126_seMainProcess)
    If IsdbNull(rs0126!K0126_cdMainProcess) = False Then D0126.cdMainProcess = Trim$(rs0126!K0126_cdMainProcess)
    If IsdbNull(rs0126!K0126_seSubProcess) = False Then D0126.seSubProcess = Trim$(rs0126!K0126_seSubProcess)
    If IsdbNull(rs0126!K0126_cdSubProcess) = False Then D0126.cdSubProcess = Trim$(rs0126!K0126_cdSubProcess)
    If IsdbNull(rs0126!K0126_SizeQty01) = False Then D0126.SizeQty01 = Trim$(rs0126!K0126_SizeQty01)
    If IsdbNull(rs0126!K0126_SizeQty02) = False Then D0126.SizeQty02 = Trim$(rs0126!K0126_SizeQty02)
    If IsdbNull(rs0126!K0126_SizeQty03) = False Then D0126.SizeQty03 = Trim$(rs0126!K0126_SizeQty03)
    If IsdbNull(rs0126!K0126_SizeQty04) = False Then D0126.SizeQty04 = Trim$(rs0126!K0126_SizeQty04)
    If IsdbNull(rs0126!K0126_SizeQty05) = False Then D0126.SizeQty05 = Trim$(rs0126!K0126_SizeQty05)
    If IsdbNull(rs0126!K0126_SizeQty06) = False Then D0126.SizeQty06 = Trim$(rs0126!K0126_SizeQty06)
    If IsdbNull(rs0126!K0126_SizeQty07) = False Then D0126.SizeQty07 = Trim$(rs0126!K0126_SizeQty07)
    If IsdbNull(rs0126!K0126_SizeQty08) = False Then D0126.SizeQty08 = Trim$(rs0126!K0126_SizeQty08)
    If IsdbNull(rs0126!K0126_SizeQty09) = False Then D0126.SizeQty09 = Trim$(rs0126!K0126_SizeQty09)
    If IsdbNull(rs0126!K0126_SizeQty10) = False Then D0126.SizeQty10 = Trim$(rs0126!K0126_SizeQty10)
    If IsdbNull(rs0126!K0126_SizeQty11) = False Then D0126.SizeQty11 = Trim$(rs0126!K0126_SizeQty11)
    If IsdbNull(rs0126!K0126_SizeQty12) = False Then D0126.SizeQty12 = Trim$(rs0126!K0126_SizeQty12)
    If IsdbNull(rs0126!K0126_SizeQty13) = False Then D0126.SizeQty13 = Trim$(rs0126!K0126_SizeQty13)
    If IsdbNull(rs0126!K0126_SizeQty14) = False Then D0126.SizeQty14 = Trim$(rs0126!K0126_SizeQty14)
    If IsdbNull(rs0126!K0126_SizeQty15) = False Then D0126.SizeQty15 = Trim$(rs0126!K0126_SizeQty15)
    If IsdbNull(rs0126!K0126_SizeQty16) = False Then D0126.SizeQty16 = Trim$(rs0126!K0126_SizeQty16)
    If IsdbNull(rs0126!K0126_SizeQty17) = False Then D0126.SizeQty17 = Trim$(rs0126!K0126_SizeQty17)
    If IsdbNull(rs0126!K0126_SizeQty18) = False Then D0126.SizeQty18 = Trim$(rs0126!K0126_SizeQty18)
    If IsdbNull(rs0126!K0126_SizeQty20) = False Then D0126.SizeQty20 = Trim$(rs0126!K0126_SizeQty20)
    If IsdbNull(rs0126!K0126_SizeQty19) = False Then D0126.SizeQty19 = Trim$(rs0126!K0126_SizeQty19)
    If IsdbNull(rs0126!K0126_SizeQty21) = False Then D0126.SizeQty21 = Trim$(rs0126!K0126_SizeQty21)
    If IsdbNull(rs0126!K0126_SizeQty22) = False Then D0126.SizeQty22 = Trim$(rs0126!K0126_SizeQty22)
    If IsdbNull(rs0126!K0126_SizeQty23) = False Then D0126.SizeQty23 = Trim$(rs0126!K0126_SizeQty23)
    If IsdbNull(rs0126!K0126_SizeQty24) = False Then D0126.SizeQty24 = Trim$(rs0126!K0126_SizeQty24)
    If IsdbNull(rs0126!K0126_SizeQty25) = False Then D0126.SizeQty25 = Trim$(rs0126!K0126_SizeQty25)
    If IsdbNull(rs0126!K0126_SizeQty26) = False Then D0126.SizeQty26 = Trim$(rs0126!K0126_SizeQty26)
    If IsdbNull(rs0126!K0126_SizeQty27) = False Then D0126.SizeQty27 = Trim$(rs0126!K0126_SizeQty27)
    If IsdbNull(rs0126!K0126_SizeQty28) = False Then D0126.SizeQty28 = Trim$(rs0126!K0126_SizeQty28)
    If IsdbNull(rs0126!K0126_SizeQty29) = False Then D0126.SizeQty29 = Trim$(rs0126!K0126_SizeQty29)
    If IsdbNull(rs0126!K0126_SizeQty30) = False Then D0126.SizeQty30 = Trim$(rs0126!K0126_SizeQty30)
    If IsdbNull(rs0126!K0126_Remark) = False Then D0126.Remark = Trim$(rs0126!K0126_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0126_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K0126_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0126 As T0126_AREA, SPECNO AS String, SPECNOSEQ AS String, PROCESSSEQ AS String, MATCHINGSEQ AS Double) as Boolean

K0126_MOVE = False

Try
    If READ_PFK0126(SPECNO, SPECNOSEQ, PROCESSSEQ, MATCHINGSEQ) = True Then
                z0126 = D0126
		K0126_MOVE = True
		else
	z0126 = nothing
     End If

     If  getColumIndex(spr,"SpecNo") > -1 then z0126.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z0126.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"ProcessSeq") > -1 then z0126.ProcessSeq = getDataM(spr, getColumIndex(spr,"ProcessSeq"), xRow)
     If  getColumIndex(spr,"MatchingSeq") > -1 then z0126.MatchingSeq = getDataM(spr, getColumIndex(spr,"MatchingSeq"), xRow)
     If  getColumIndex(spr,"Status") > -1 then z0126.Status = getDataM(spr, getColumIndex(spr,"Status"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z0126.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z0126.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z0126.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z0126.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"SizeQty01") > -1 then z0126.SizeQty01 = getDataM(spr, getColumIndex(spr,"SizeQty01"), xRow)
     If  getColumIndex(spr,"SizeQty02") > -1 then z0126.SizeQty02 = getDataM(spr, getColumIndex(spr,"SizeQty02"), xRow)
     If  getColumIndex(spr,"SizeQty03") > -1 then z0126.SizeQty03 = getDataM(spr, getColumIndex(spr,"SizeQty03"), xRow)
     If  getColumIndex(spr,"SizeQty04") > -1 then z0126.SizeQty04 = getDataM(spr, getColumIndex(spr,"SizeQty04"), xRow)
     If  getColumIndex(spr,"SizeQty05") > -1 then z0126.SizeQty05 = getDataM(spr, getColumIndex(spr,"SizeQty05"), xRow)
     If  getColumIndex(spr,"SizeQty06") > -1 then z0126.SizeQty06 = getDataM(spr, getColumIndex(spr,"SizeQty06"), xRow)
     If  getColumIndex(spr,"SizeQty07") > -1 then z0126.SizeQty07 = getDataM(spr, getColumIndex(spr,"SizeQty07"), xRow)
     If  getColumIndex(spr,"SizeQty08") > -1 then z0126.SizeQty08 = getDataM(spr, getColumIndex(spr,"SizeQty08"), xRow)
     If  getColumIndex(spr,"SizeQty09") > -1 then z0126.SizeQty09 = getDataM(spr, getColumIndex(spr,"SizeQty09"), xRow)
     If  getColumIndex(spr,"SizeQty10") > -1 then z0126.SizeQty10 = getDataM(spr, getColumIndex(spr,"SizeQty10"), xRow)
     If  getColumIndex(spr,"SizeQty11") > -1 then z0126.SizeQty11 = getDataM(spr, getColumIndex(spr,"SizeQty11"), xRow)
     If  getColumIndex(spr,"SizeQty12") > -1 then z0126.SizeQty12 = getDataM(spr, getColumIndex(spr,"SizeQty12"), xRow)
     If  getColumIndex(spr,"SizeQty13") > -1 then z0126.SizeQty13 = getDataM(spr, getColumIndex(spr,"SizeQty13"), xRow)
     If  getColumIndex(spr,"SizeQty14") > -1 then z0126.SizeQty14 = getDataM(spr, getColumIndex(spr,"SizeQty14"), xRow)
     If  getColumIndex(spr,"SizeQty15") > -1 then z0126.SizeQty15 = getDataM(spr, getColumIndex(spr,"SizeQty15"), xRow)
     If  getColumIndex(spr,"SizeQty16") > -1 then z0126.SizeQty16 = getDataM(spr, getColumIndex(spr,"SizeQty16"), xRow)
     If  getColumIndex(spr,"SizeQty17") > -1 then z0126.SizeQty17 = getDataM(spr, getColumIndex(spr,"SizeQty17"), xRow)
     If  getColumIndex(spr,"SizeQty18") > -1 then z0126.SizeQty18 = getDataM(spr, getColumIndex(spr,"SizeQty18"), xRow)
     If  getColumIndex(spr,"SizeQty20") > -1 then z0126.SizeQty20 = getDataM(spr, getColumIndex(spr,"SizeQty20"), xRow)
     If  getColumIndex(spr,"SizeQty19") > -1 then z0126.SizeQty19 = getDataM(spr, getColumIndex(spr,"SizeQty19"), xRow)
     If  getColumIndex(spr,"SizeQty21") > -1 then z0126.SizeQty21 = getDataM(spr, getColumIndex(spr,"SizeQty21"), xRow)
     If  getColumIndex(spr,"SizeQty22") > -1 then z0126.SizeQty22 = getDataM(spr, getColumIndex(spr,"SizeQty22"), xRow)
     If  getColumIndex(spr,"SizeQty23") > -1 then z0126.SizeQty23 = getDataM(spr, getColumIndex(spr,"SizeQty23"), xRow)
     If  getColumIndex(spr,"SizeQty24") > -1 then z0126.SizeQty24 = getDataM(spr, getColumIndex(spr,"SizeQty24"), xRow)
     If  getColumIndex(spr,"SizeQty25") > -1 then z0126.SizeQty25 = getDataM(spr, getColumIndex(spr,"SizeQty25"), xRow)
     If  getColumIndex(spr,"SizeQty26") > -1 then z0126.SizeQty26 = getDataM(spr, getColumIndex(spr,"SizeQty26"), xRow)
     If  getColumIndex(spr,"SizeQty27") > -1 then z0126.SizeQty27 = getDataM(spr, getColumIndex(spr,"SizeQty27"), xRow)
     If  getColumIndex(spr,"SizeQty28") > -1 then z0126.SizeQty28 = getDataM(spr, getColumIndex(spr,"SizeQty28"), xRow)
     If  getColumIndex(spr,"SizeQty29") > -1 then z0126.SizeQty29 = getDataM(spr, getColumIndex(spr,"SizeQty29"), xRow)
     If  getColumIndex(spr,"SizeQty30") > -1 then z0126.SizeQty30 = getDataM(spr, getColumIndex(spr,"SizeQty30"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0126.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0126_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K0126_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0126 As T0126_AREA,CheckClear as Boolean,SPECNO AS String, SPECNOSEQ AS String, PROCESSSEQ AS String, MATCHINGSEQ AS Double) as Boolean

K0126_MOVE = False

Try
    If READ_PFK0126(SPECNO, SPECNOSEQ, PROCESSSEQ, MATCHINGSEQ) = True Then
                z0126 = D0126
		K0126_MOVE = True
		else
	If CheckClear  = True then z0126 = nothing
     End If

     If  getColumIndex(spr,"SpecNo") > -1 then z0126.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z0126.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"ProcessSeq") > -1 then z0126.ProcessSeq = getDataM(spr, getColumIndex(spr,"ProcessSeq"), xRow)
     If  getColumIndex(spr,"MatchingSeq") > -1 then z0126.MatchingSeq = getDataM(spr, getColumIndex(spr,"MatchingSeq"), xRow)
     If  getColumIndex(spr,"Status") > -1 then z0126.Status = getDataM(spr, getColumIndex(spr,"Status"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z0126.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z0126.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z0126.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z0126.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"SizeQty01") > -1 then z0126.SizeQty01 = getDataM(spr, getColumIndex(spr,"SizeQty01"), xRow)
     If  getColumIndex(spr,"SizeQty02") > -1 then z0126.SizeQty02 = getDataM(spr, getColumIndex(spr,"SizeQty02"), xRow)
     If  getColumIndex(spr,"SizeQty03") > -1 then z0126.SizeQty03 = getDataM(spr, getColumIndex(spr,"SizeQty03"), xRow)
     If  getColumIndex(spr,"SizeQty04") > -1 then z0126.SizeQty04 = getDataM(spr, getColumIndex(spr,"SizeQty04"), xRow)
     If  getColumIndex(spr,"SizeQty05") > -1 then z0126.SizeQty05 = getDataM(spr, getColumIndex(spr,"SizeQty05"), xRow)
     If  getColumIndex(spr,"SizeQty06") > -1 then z0126.SizeQty06 = getDataM(spr, getColumIndex(spr,"SizeQty06"), xRow)
     If  getColumIndex(spr,"SizeQty07") > -1 then z0126.SizeQty07 = getDataM(spr, getColumIndex(spr,"SizeQty07"), xRow)
     If  getColumIndex(spr,"SizeQty08") > -1 then z0126.SizeQty08 = getDataM(spr, getColumIndex(spr,"SizeQty08"), xRow)
     If  getColumIndex(spr,"SizeQty09") > -1 then z0126.SizeQty09 = getDataM(spr, getColumIndex(spr,"SizeQty09"), xRow)
     If  getColumIndex(spr,"SizeQty10") > -1 then z0126.SizeQty10 = getDataM(spr, getColumIndex(spr,"SizeQty10"), xRow)
     If  getColumIndex(spr,"SizeQty11") > -1 then z0126.SizeQty11 = getDataM(spr, getColumIndex(spr,"SizeQty11"), xRow)
     If  getColumIndex(spr,"SizeQty12") > -1 then z0126.SizeQty12 = getDataM(spr, getColumIndex(spr,"SizeQty12"), xRow)
     If  getColumIndex(spr,"SizeQty13") > -1 then z0126.SizeQty13 = getDataM(spr, getColumIndex(spr,"SizeQty13"), xRow)
     If  getColumIndex(spr,"SizeQty14") > -1 then z0126.SizeQty14 = getDataM(spr, getColumIndex(spr,"SizeQty14"), xRow)
     If  getColumIndex(spr,"SizeQty15") > -1 then z0126.SizeQty15 = getDataM(spr, getColumIndex(spr,"SizeQty15"), xRow)
     If  getColumIndex(spr,"SizeQty16") > -1 then z0126.SizeQty16 = getDataM(spr, getColumIndex(spr,"SizeQty16"), xRow)
     If  getColumIndex(spr,"SizeQty17") > -1 then z0126.SizeQty17 = getDataM(spr, getColumIndex(spr,"SizeQty17"), xRow)
     If  getColumIndex(spr,"SizeQty18") > -1 then z0126.SizeQty18 = getDataM(spr, getColumIndex(spr,"SizeQty18"), xRow)
     If  getColumIndex(spr,"SizeQty20") > -1 then z0126.SizeQty20 = getDataM(spr, getColumIndex(spr,"SizeQty20"), xRow)
     If  getColumIndex(spr,"SizeQty19") > -1 then z0126.SizeQty19 = getDataM(spr, getColumIndex(spr,"SizeQty19"), xRow)
     If  getColumIndex(spr,"SizeQty21") > -1 then z0126.SizeQty21 = getDataM(spr, getColumIndex(spr,"SizeQty21"), xRow)
     If  getColumIndex(spr,"SizeQty22") > -1 then z0126.SizeQty22 = getDataM(spr, getColumIndex(spr,"SizeQty22"), xRow)
     If  getColumIndex(spr,"SizeQty23") > -1 then z0126.SizeQty23 = getDataM(spr, getColumIndex(spr,"SizeQty23"), xRow)
     If  getColumIndex(spr,"SizeQty24") > -1 then z0126.SizeQty24 = getDataM(spr, getColumIndex(spr,"SizeQty24"), xRow)
     If  getColumIndex(spr,"SizeQty25") > -1 then z0126.SizeQty25 = getDataM(spr, getColumIndex(spr,"SizeQty25"), xRow)
     If  getColumIndex(spr,"SizeQty26") > -1 then z0126.SizeQty26 = getDataM(spr, getColumIndex(spr,"SizeQty26"), xRow)
     If  getColumIndex(spr,"SizeQty27") > -1 then z0126.SizeQty27 = getDataM(spr, getColumIndex(spr,"SizeQty27"), xRow)
     If  getColumIndex(spr,"SizeQty28") > -1 then z0126.SizeQty28 = getDataM(spr, getColumIndex(spr,"SizeQty28"), xRow)
     If  getColumIndex(spr,"SizeQty29") > -1 then z0126.SizeQty29 = getDataM(spr, getColumIndex(spr,"SizeQty29"), xRow)
     If  getColumIndex(spr,"SizeQty30") > -1 then z0126.SizeQty30 = getDataM(spr, getColumIndex(spr,"SizeQty30"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0126.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0126_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K0126_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0126 As T0126_AREA, Job as String, SPECNO AS String, SPECNOSEQ AS String, PROCESSSEQ AS String, MATCHINGSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0126_MOVE = False

Try
    If READ_PFK0126(SPECNO, SPECNOSEQ, PROCESSSEQ, MATCHINGSEQ) = True Then
                z0126 = D0126
		K0126_MOVE = True
		else
	z0126 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0126")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SPECNO":z0126.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z0126.SpecNoSeq = Children(i).Code
   Case "PROCESSSEQ":z0126.ProcessSeq = Children(i).Code
   Case "MATCHINGSEQ":z0126.MatchingSeq = Children(i).Code
   Case "STATUS":z0126.Status = Children(i).Code
   Case "SEMAINPROCESS":z0126.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z0126.cdMainProcess = Children(i).Code
   Case "SESUBPROCESS":z0126.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z0126.cdSubProcess = Children(i).Code
   Case "SIZEQTY01":z0126.SizeQty01 = Children(i).Code
   Case "SIZEQTY02":z0126.SizeQty02 = Children(i).Code
   Case "SIZEQTY03":z0126.SizeQty03 = Children(i).Code
   Case "SIZEQTY04":z0126.SizeQty04 = Children(i).Code
   Case "SIZEQTY05":z0126.SizeQty05 = Children(i).Code
   Case "SIZEQTY06":z0126.SizeQty06 = Children(i).Code
   Case "SIZEQTY07":z0126.SizeQty07 = Children(i).Code
   Case "SIZEQTY08":z0126.SizeQty08 = Children(i).Code
   Case "SIZEQTY09":z0126.SizeQty09 = Children(i).Code
   Case "SIZEQTY10":z0126.SizeQty10 = Children(i).Code
   Case "SIZEQTY11":z0126.SizeQty11 = Children(i).Code
   Case "SIZEQTY12":z0126.SizeQty12 = Children(i).Code
   Case "SIZEQTY13":z0126.SizeQty13 = Children(i).Code
   Case "SIZEQTY14":z0126.SizeQty14 = Children(i).Code
   Case "SIZEQTY15":z0126.SizeQty15 = Children(i).Code
   Case "SIZEQTY16":z0126.SizeQty16 = Children(i).Code
   Case "SIZEQTY17":z0126.SizeQty17 = Children(i).Code
   Case "SIZEQTY18":z0126.SizeQty18 = Children(i).Code
   Case "SIZEQTY20":z0126.SizeQty20 = Children(i).Code
   Case "SIZEQTY19":z0126.SizeQty19 = Children(i).Code
   Case "SIZEQTY21":z0126.SizeQty21 = Children(i).Code
   Case "SIZEQTY22":z0126.SizeQty22 = Children(i).Code
   Case "SIZEQTY23":z0126.SizeQty23 = Children(i).Code
   Case "SIZEQTY24":z0126.SizeQty24 = Children(i).Code
   Case "SIZEQTY25":z0126.SizeQty25 = Children(i).Code
   Case "SIZEQTY26":z0126.SizeQty26 = Children(i).Code
   Case "SIZEQTY27":z0126.SizeQty27 = Children(i).Code
   Case "SIZEQTY28":z0126.SizeQty28 = Children(i).Code
   Case "SIZEQTY29":z0126.SizeQty29 = Children(i).Code
   Case "SIZEQTY30":z0126.SizeQty30 = Children(i).Code
   Case "REMARK":z0126.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SPECNO":z0126.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z0126.SpecNoSeq = Children(i).Data
   Case "PROCESSSEQ":z0126.ProcessSeq = Children(i).Data
   Case "MATCHINGSEQ":z0126.MatchingSeq = Children(i).Data
   Case "STATUS":z0126.Status = Children(i).Data
   Case "SEMAINPROCESS":z0126.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z0126.cdMainProcess = Children(i).Data
   Case "SESUBPROCESS":z0126.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z0126.cdSubProcess = Children(i).Data
   Case "SIZEQTY01":z0126.SizeQty01 = Children(i).Data
   Case "SIZEQTY02":z0126.SizeQty02 = Children(i).Data
   Case "SIZEQTY03":z0126.SizeQty03 = Children(i).Data
   Case "SIZEQTY04":z0126.SizeQty04 = Children(i).Data
   Case "SIZEQTY05":z0126.SizeQty05 = Children(i).Data
   Case "SIZEQTY06":z0126.SizeQty06 = Children(i).Data
   Case "SIZEQTY07":z0126.SizeQty07 = Children(i).Data
   Case "SIZEQTY08":z0126.SizeQty08 = Children(i).Data
   Case "SIZEQTY09":z0126.SizeQty09 = Children(i).Data
   Case "SIZEQTY10":z0126.SizeQty10 = Children(i).Data
   Case "SIZEQTY11":z0126.SizeQty11 = Children(i).Data
   Case "SIZEQTY12":z0126.SizeQty12 = Children(i).Data
   Case "SIZEQTY13":z0126.SizeQty13 = Children(i).Data
   Case "SIZEQTY14":z0126.SizeQty14 = Children(i).Data
   Case "SIZEQTY15":z0126.SizeQty15 = Children(i).Data
   Case "SIZEQTY16":z0126.SizeQty16 = Children(i).Data
   Case "SIZEQTY17":z0126.SizeQty17 = Children(i).Data
   Case "SIZEQTY18":z0126.SizeQty18 = Children(i).Data
   Case "SIZEQTY20":z0126.SizeQty20 = Children(i).Data
   Case "SIZEQTY19":z0126.SizeQty19 = Children(i).Data
   Case "SIZEQTY21":z0126.SizeQty21 = Children(i).Data
   Case "SIZEQTY22":z0126.SizeQty22 = Children(i).Data
   Case "SIZEQTY23":z0126.SizeQty23 = Children(i).Data
   Case "SIZEQTY24":z0126.SizeQty24 = Children(i).Data
   Case "SIZEQTY25":z0126.SizeQty25 = Children(i).Data
   Case "SIZEQTY26":z0126.SizeQty26 = Children(i).Data
   Case "SIZEQTY27":z0126.SizeQty27 = Children(i).Data
   Case "SIZEQTY28":z0126.SizeQty28 = Children(i).Data
   Case "SIZEQTY29":z0126.SizeQty29 = Children(i).Data
   Case "SIZEQTY30":z0126.SizeQty30 = Children(i).Data
   Case "REMARK":z0126.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0126_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K0126_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0126 As T0126_AREA, Job as String, CheckClear as Boolean, SPECNO AS String, SPECNOSEQ AS String, PROCESSSEQ AS String, MATCHINGSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0126_MOVE = False

Try
    If READ_PFK0126(SPECNO, SPECNOSEQ, PROCESSSEQ, MATCHINGSEQ) = True Then
                z0126 = D0126
		K0126_MOVE = True
		else
	If CheckClear  = True then z0126 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0126")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SPECNO":z0126.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z0126.SpecNoSeq = Children(i).Code
   Case "PROCESSSEQ":z0126.ProcessSeq = Children(i).Code
   Case "MATCHINGSEQ":z0126.MatchingSeq = Children(i).Code
   Case "STATUS":z0126.Status = Children(i).Code
   Case "SEMAINPROCESS":z0126.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z0126.cdMainProcess = Children(i).Code
   Case "SESUBPROCESS":z0126.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z0126.cdSubProcess = Children(i).Code
   Case "SIZEQTY01":z0126.SizeQty01 = Children(i).Code
   Case "SIZEQTY02":z0126.SizeQty02 = Children(i).Code
   Case "SIZEQTY03":z0126.SizeQty03 = Children(i).Code
   Case "SIZEQTY04":z0126.SizeQty04 = Children(i).Code
   Case "SIZEQTY05":z0126.SizeQty05 = Children(i).Code
   Case "SIZEQTY06":z0126.SizeQty06 = Children(i).Code
   Case "SIZEQTY07":z0126.SizeQty07 = Children(i).Code
   Case "SIZEQTY08":z0126.SizeQty08 = Children(i).Code
   Case "SIZEQTY09":z0126.SizeQty09 = Children(i).Code
   Case "SIZEQTY10":z0126.SizeQty10 = Children(i).Code
   Case "SIZEQTY11":z0126.SizeQty11 = Children(i).Code
   Case "SIZEQTY12":z0126.SizeQty12 = Children(i).Code
   Case "SIZEQTY13":z0126.SizeQty13 = Children(i).Code
   Case "SIZEQTY14":z0126.SizeQty14 = Children(i).Code
   Case "SIZEQTY15":z0126.SizeQty15 = Children(i).Code
   Case "SIZEQTY16":z0126.SizeQty16 = Children(i).Code
   Case "SIZEQTY17":z0126.SizeQty17 = Children(i).Code
   Case "SIZEQTY18":z0126.SizeQty18 = Children(i).Code
   Case "SIZEQTY20":z0126.SizeQty20 = Children(i).Code
   Case "SIZEQTY19":z0126.SizeQty19 = Children(i).Code
   Case "SIZEQTY21":z0126.SizeQty21 = Children(i).Code
   Case "SIZEQTY22":z0126.SizeQty22 = Children(i).Code
   Case "SIZEQTY23":z0126.SizeQty23 = Children(i).Code
   Case "SIZEQTY24":z0126.SizeQty24 = Children(i).Code
   Case "SIZEQTY25":z0126.SizeQty25 = Children(i).Code
   Case "SIZEQTY26":z0126.SizeQty26 = Children(i).Code
   Case "SIZEQTY27":z0126.SizeQty27 = Children(i).Code
   Case "SIZEQTY28":z0126.SizeQty28 = Children(i).Code
   Case "SIZEQTY29":z0126.SizeQty29 = Children(i).Code
   Case "SIZEQTY30":z0126.SizeQty30 = Children(i).Code
   Case "REMARK":z0126.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SPECNO":z0126.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z0126.SpecNoSeq = Children(i).Data
   Case "PROCESSSEQ":z0126.ProcessSeq = Children(i).Data
   Case "MATCHINGSEQ":z0126.MatchingSeq = Children(i).Data
   Case "STATUS":z0126.Status = Children(i).Data
   Case "SEMAINPROCESS":z0126.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z0126.cdMainProcess = Children(i).Data
   Case "SESUBPROCESS":z0126.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z0126.cdSubProcess = Children(i).Data
   Case "SIZEQTY01":z0126.SizeQty01 = Children(i).Data
   Case "SIZEQTY02":z0126.SizeQty02 = Children(i).Data
   Case "SIZEQTY03":z0126.SizeQty03 = Children(i).Data
   Case "SIZEQTY04":z0126.SizeQty04 = Children(i).Data
   Case "SIZEQTY05":z0126.SizeQty05 = Children(i).Data
   Case "SIZEQTY06":z0126.SizeQty06 = Children(i).Data
   Case "SIZEQTY07":z0126.SizeQty07 = Children(i).Data
   Case "SIZEQTY08":z0126.SizeQty08 = Children(i).Data
   Case "SIZEQTY09":z0126.SizeQty09 = Children(i).Data
   Case "SIZEQTY10":z0126.SizeQty10 = Children(i).Data
   Case "SIZEQTY11":z0126.SizeQty11 = Children(i).Data
   Case "SIZEQTY12":z0126.SizeQty12 = Children(i).Data
   Case "SIZEQTY13":z0126.SizeQty13 = Children(i).Data
   Case "SIZEQTY14":z0126.SizeQty14 = Children(i).Data
   Case "SIZEQTY15":z0126.SizeQty15 = Children(i).Data
   Case "SIZEQTY16":z0126.SizeQty16 = Children(i).Data
   Case "SIZEQTY17":z0126.SizeQty17 = Children(i).Data
   Case "SIZEQTY18":z0126.SizeQty18 = Children(i).Data
   Case "SIZEQTY20":z0126.SizeQty20 = Children(i).Data
   Case "SIZEQTY19":z0126.SizeQty19 = Children(i).Data
   Case "SIZEQTY21":z0126.SizeQty21 = Children(i).Data
   Case "SIZEQTY22":z0126.SizeQty22 = Children(i).Data
   Case "SIZEQTY23":z0126.SizeQty23 = Children(i).Data
   Case "SIZEQTY24":z0126.SizeQty24 = Children(i).Data
   Case "SIZEQTY25":z0126.SizeQty25 = Children(i).Data
   Case "SIZEQTY26":z0126.SizeQty26 = Children(i).Data
   Case "SIZEQTY27":z0126.SizeQty27 = Children(i).Data
   Case "SIZEQTY28":z0126.SizeQty28 = Children(i).Data
   Case "SIZEQTY29":z0126.SizeQty29 = Children(i).Data
   Case "SIZEQTY30":z0126.SizeQty30 = Children(i).Data
   Case "REMARK":z0126.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0126_MOVE",vbCritical)
End Try
End Function 
    
End Module 
