'=========================================================================================================================================================
'   TABLE : (PFK0113)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K0113

Structure T0113_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	UploadNo	 AS String	'			char(9)		*
Public 	UploadSeq	 AS Double	'			decimal		*
Public 	NameUpload	 AS String	'			nvarchar(50)
Public 	DateUpload	 AS String	'			char(8)
Public 	InchargeUpload	 AS String	'			char(8)
Public 	ComponentName	 AS String	'			nvarchar(50)
Public 	cdTypeCode	 AS String	'			char(3)
Public 	TypeCode	 AS String	'			char(6)
Public 	TypeName	 AS String	'			nvarchar(50)
Public 	Specification	 AS String	'			nvarchar(20)
Public 	Spec1	 AS String	'			nvarchar(20)
Public 	Spec2	 AS String	'			nvarchar(20)
Public 	Spec3	 AS String	'			nvarchar(20)
Public 	Spec4	 AS String	'			nvarchar(20)
Public 	Width	 AS String	'			nvarchar(20)
Public 	Height	 AS String	'			nvarchar(20)
Public 	seMainProcess	 AS String	'			char(3)
Public 	cdMainProcess	 AS String	'			char(3)
Public 	seSubProcess	 AS String	'			char(3)
Public 	cdSubProcess	 AS String	'			char(3)
Public 	SpecNo	 AS String	'			char(9)
Public 	SpecNoSeq	 AS String	'			char(3)
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

Public D0113 As T0113_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK0113(UPLOADNO AS String, UPLOADSEQ AS Double) As Boolean
    READ_PFK0113 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0113 "
    SQL = SQL & " WHERE K0113_UploadNo		 = '" & UploadNo & "' " 
    SQL = SQL & "   AND K0113_UploadSeq		 =  " & UploadSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D0113_CLEAR: GoTo SKIP_READ_PFK0113
                
    Call K0113_MOVE(rd)
    READ_PFK0113 = True

SKIP_READ_PFK0113:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK0113",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK0113(UPLOADNO AS String, UPLOADSEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0113 "
    SQL = SQL & " WHERE K0113_UploadNo		 = '" & UploadNo & "' " 
    SQL = SQL & "   AND K0113_UploadSeq		 =  " & UploadSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK0113",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK0113(z0113 As T0113_AREA) As Boolean
    WRITE_PFK0113 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z0113)
 
    SQL = " INSERT INTO PFK0113 "
    SQL = SQL & " ( "
    SQL = SQL & " K0113_UploadNo," 
    SQL = SQL & " K0113_UploadSeq," 
    SQL = SQL & " K0113_NameUpload," 
    SQL = SQL & " K0113_DateUpload," 
    SQL = SQL & " K0113_InchargeUpload," 
    SQL = SQL & " K0113_ComponentName," 
    SQL = SQL & " K0113_cdTypeCode," 
    SQL = SQL & " K0113_TypeCode," 
    SQL = SQL & " K0113_TypeName," 
    SQL = SQL & " K0113_Specification," 
    SQL = SQL & " K0113_Spec1," 
    SQL = SQL & " K0113_Spec2," 
    SQL = SQL & " K0113_Spec3," 
    SQL = SQL & " K0113_Spec4," 
    SQL = SQL & " K0113_Width," 
    SQL = SQL & " K0113_Height," 
    SQL = SQL & " K0113_seMainProcess," 
    SQL = SQL & " K0113_cdMainProcess," 
    SQL = SQL & " K0113_seSubProcess," 
    SQL = SQL & " K0113_cdSubProcess," 
    SQL = SQL & " K0113_SpecNo," 
    SQL = SQL & " K0113_SpecNoSeq," 
    SQL = SQL & " K0113_DSeq," 
    SQL = SQL & " K0113_QtyComponent," 
    SQL = SQL & " K0113_CSizeQty01," 
    SQL = SQL & " K0113_CSizeQty02," 
    SQL = SQL & " K0113_CSizeQty03," 
    SQL = SQL & " K0113_CSizeQty04," 
    SQL = SQL & " K0113_CSizeQty05," 
    SQL = SQL & " K0113_CSizeQty06," 
    SQL = SQL & " K0113_CSizeQty07," 
    SQL = SQL & " K0113_CSizeQty08," 
    SQL = SQL & " K0113_CSizeQty09," 
    SQL = SQL & " K0113_CSizeQty10," 
    SQL = SQL & " K0113_CSizeQty11," 
    SQL = SQL & " K0113_CSizeQty12," 
    SQL = SQL & " K0113_CSizeQty13," 
    SQL = SQL & " K0113_CSizeQty14," 
    SQL = SQL & " K0113_CSizeQty15," 
    SQL = SQL & " K0113_CSizeQty16," 
    SQL = SQL & " K0113_CSizeQty17," 
    SQL = SQL & " K0113_CSizeQty18," 
    SQL = SQL & " K0113_CSizeQty19," 
    SQL = SQL & " K0113_CSizeQty20," 
    SQL = SQL & " K0113_CSizeQty21," 
    SQL = SQL & " K0113_CSizeQty22," 
    SQL = SQL & " K0113_CSizeQty23," 
    SQL = SQL & " K0113_CSizeQty24," 
    SQL = SQL & " K0113_CSizeQty25," 
    SQL = SQL & " K0113_CSizeQty26," 
    SQL = SQL & " K0113_CSizeQty27," 
    SQL = SQL & " K0113_CSizeQty28," 
    SQL = SQL & " K0113_CSizeQty29," 
    SQL = SQL & " K0113_CSizeQty30," 
    SQL = SQL & " K0113_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z0113.UploadNo) & "', "  
    SQL = SQL & "   " & FormatSQL(z0113.UploadSeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z0113.NameUpload) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0113.DateUpload) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0113.InchargeUpload) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0113.ComponentName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0113.cdTypeCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0113.TypeCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0113.TypeName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0113.Specification) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0113.Spec1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0113.Spec2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0113.Spec3) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0113.Spec4) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0113.Width) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0113.Height) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0113.seMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0113.cdMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0113.seSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0113.cdSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0113.SpecNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0113.SpecNoSeq) & "', "  
    SQL = SQL & "   " & FormatSQL(z0113.DSeq) & ", "  
    SQL = SQL & "   " & FormatSQL(z0113.QtyComponent) & ", "  
    SQL = SQL & "   " & FormatSQL(z0113.CSizeQty01) & ", "  
    SQL = SQL & "   " & FormatSQL(z0113.CSizeQty02) & ", "  
    SQL = SQL & "   " & FormatSQL(z0113.CSizeQty03) & ", "  
    SQL = SQL & "   " & FormatSQL(z0113.CSizeQty04) & ", "  
    SQL = SQL & "   " & FormatSQL(z0113.CSizeQty05) & ", "  
    SQL = SQL & "   " & FormatSQL(z0113.CSizeQty06) & ", "  
    SQL = SQL & "   " & FormatSQL(z0113.CSizeQty07) & ", "  
    SQL = SQL & "   " & FormatSQL(z0113.CSizeQty08) & ", "  
    SQL = SQL & "   " & FormatSQL(z0113.CSizeQty09) & ", "  
    SQL = SQL & "   " & FormatSQL(z0113.CSizeQty10) & ", "  
    SQL = SQL & "   " & FormatSQL(z0113.CSizeQty11) & ", "  
    SQL = SQL & "   " & FormatSQL(z0113.CSizeQty12) & ", "  
    SQL = SQL & "   " & FormatSQL(z0113.CSizeQty13) & ", "  
    SQL = SQL & "   " & FormatSQL(z0113.CSizeQty14) & ", "  
    SQL = SQL & "   " & FormatSQL(z0113.CSizeQty15) & ", "  
    SQL = SQL & "   " & FormatSQL(z0113.CSizeQty16) & ", "  
    SQL = SQL & "   " & FormatSQL(z0113.CSizeQty17) & ", "  
    SQL = SQL & "   " & FormatSQL(z0113.CSizeQty18) & ", "  
    SQL = SQL & "   " & FormatSQL(z0113.CSizeQty19) & ", "  
    SQL = SQL & "   " & FormatSQL(z0113.CSizeQty20) & ", "  
    SQL = SQL & "   " & FormatSQL(z0113.CSizeQty21) & ", "  
    SQL = SQL & "   " & FormatSQL(z0113.CSizeQty22) & ", "  
    SQL = SQL & "   " & FormatSQL(z0113.CSizeQty23) & ", "  
    SQL = SQL & "   " & FormatSQL(z0113.CSizeQty24) & ", "  
    SQL = SQL & "   " & FormatSQL(z0113.CSizeQty25) & ", "  
    SQL = SQL & "   " & FormatSQL(z0113.CSizeQty26) & ", "  
    SQL = SQL & "   " & FormatSQL(z0113.CSizeQty27) & ", "  
    SQL = SQL & "   " & FormatSQL(z0113.CSizeQty28) & ", "  
    SQL = SQL & "   " & FormatSQL(z0113.CSizeQty29) & ", "  
    SQL = SQL & "   " & FormatSQL(z0113.CSizeQty30) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z0113.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK0113 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK0113",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK0113(z0113 As T0113_AREA) As Boolean
    REWRITE_PFK0113 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z0113)
   
    SQL = " UPDATE PFK0113 SET "
    SQL = SQL & "    K0113_NameUpload      = N'" & FormatSQL(z0113.NameUpload) & "', " 
    SQL = SQL & "    K0113_DateUpload      = N'" & FormatSQL(z0113.DateUpload) & "', " 
    SQL = SQL & "    K0113_InchargeUpload      = N'" & FormatSQL(z0113.InchargeUpload) & "', " 
    SQL = SQL & "    K0113_ComponentName      = N'" & FormatSQL(z0113.ComponentName) & "', " 
    SQL = SQL & "    K0113_cdTypeCode      = N'" & FormatSQL(z0113.cdTypeCode) & "', " 
    SQL = SQL & "    K0113_TypeCode      = N'" & FormatSQL(z0113.TypeCode) & "', " 
    SQL = SQL & "    K0113_TypeName      = N'" & FormatSQL(z0113.TypeName) & "', " 
    SQL = SQL & "    K0113_Specification      = N'" & FormatSQL(z0113.Specification) & "', " 
    SQL = SQL & "    K0113_Spec1      = N'" & FormatSQL(z0113.Spec1) & "', " 
    SQL = SQL & "    K0113_Spec2      = N'" & FormatSQL(z0113.Spec2) & "', " 
    SQL = SQL & "    K0113_Spec3      = N'" & FormatSQL(z0113.Spec3) & "', " 
    SQL = SQL & "    K0113_Spec4      = N'" & FormatSQL(z0113.Spec4) & "', " 
    SQL = SQL & "    K0113_Width      = N'" & FormatSQL(z0113.Width) & "', " 
    SQL = SQL & "    K0113_Height      = N'" & FormatSQL(z0113.Height) & "', " 
    SQL = SQL & "    K0113_seMainProcess      = N'" & FormatSQL(z0113.seMainProcess) & "', " 
    SQL = SQL & "    K0113_cdMainProcess      = N'" & FormatSQL(z0113.cdMainProcess) & "', " 
    SQL = SQL & "    K0113_seSubProcess      = N'" & FormatSQL(z0113.seSubProcess) & "', " 
    SQL = SQL & "    K0113_cdSubProcess      = N'" & FormatSQL(z0113.cdSubProcess) & "', " 
    SQL = SQL & "    K0113_SpecNo      = N'" & FormatSQL(z0113.SpecNo) & "', " 
    SQL = SQL & "    K0113_SpecNoSeq      = N'" & FormatSQL(z0113.SpecNoSeq) & "', " 
    SQL = SQL & "    K0113_DSeq      =  " & FormatSQL(z0113.DSeq) & ", " 
    SQL = SQL & "    K0113_QtyComponent      =  " & FormatSQL(z0113.QtyComponent) & ", " 
    SQL = SQL & "    K0113_CSizeQty01      =  " & FormatSQL(z0113.CSizeQty01) & ", " 
    SQL = SQL & "    K0113_CSizeQty02      =  " & FormatSQL(z0113.CSizeQty02) & ", " 
    SQL = SQL & "    K0113_CSizeQty03      =  " & FormatSQL(z0113.CSizeQty03) & ", " 
    SQL = SQL & "    K0113_CSizeQty04      =  " & FormatSQL(z0113.CSizeQty04) & ", " 
    SQL = SQL & "    K0113_CSizeQty05      =  " & FormatSQL(z0113.CSizeQty05) & ", " 
    SQL = SQL & "    K0113_CSizeQty06      =  " & FormatSQL(z0113.CSizeQty06) & ", " 
    SQL = SQL & "    K0113_CSizeQty07      =  " & FormatSQL(z0113.CSizeQty07) & ", " 
    SQL = SQL & "    K0113_CSizeQty08      =  " & FormatSQL(z0113.CSizeQty08) & ", " 
    SQL = SQL & "    K0113_CSizeQty09      =  " & FormatSQL(z0113.CSizeQty09) & ", " 
    SQL = SQL & "    K0113_CSizeQty10      =  " & FormatSQL(z0113.CSizeQty10) & ", " 
    SQL = SQL & "    K0113_CSizeQty11      =  " & FormatSQL(z0113.CSizeQty11) & ", " 
    SQL = SQL & "    K0113_CSizeQty12      =  " & FormatSQL(z0113.CSizeQty12) & ", " 
    SQL = SQL & "    K0113_CSizeQty13      =  " & FormatSQL(z0113.CSizeQty13) & ", " 
    SQL = SQL & "    K0113_CSizeQty14      =  " & FormatSQL(z0113.CSizeQty14) & ", " 
    SQL = SQL & "    K0113_CSizeQty15      =  " & FormatSQL(z0113.CSizeQty15) & ", " 
    SQL = SQL & "    K0113_CSizeQty16      =  " & FormatSQL(z0113.CSizeQty16) & ", " 
    SQL = SQL & "    K0113_CSizeQty17      =  " & FormatSQL(z0113.CSizeQty17) & ", " 
    SQL = SQL & "    K0113_CSizeQty18      =  " & FormatSQL(z0113.CSizeQty18) & ", " 
    SQL = SQL & "    K0113_CSizeQty19      =  " & FormatSQL(z0113.CSizeQty19) & ", " 
    SQL = SQL & "    K0113_CSizeQty20      =  " & FormatSQL(z0113.CSizeQty20) & ", " 
    SQL = SQL & "    K0113_CSizeQty21      =  " & FormatSQL(z0113.CSizeQty21) & ", " 
    SQL = SQL & "    K0113_CSizeQty22      =  " & FormatSQL(z0113.CSizeQty22) & ", " 
    SQL = SQL & "    K0113_CSizeQty23      =  " & FormatSQL(z0113.CSizeQty23) & ", " 
    SQL = SQL & "    K0113_CSizeQty24      =  " & FormatSQL(z0113.CSizeQty24) & ", " 
    SQL = SQL & "    K0113_CSizeQty25      =  " & FormatSQL(z0113.CSizeQty25) & ", " 
    SQL = SQL & "    K0113_CSizeQty26      =  " & FormatSQL(z0113.CSizeQty26) & ", " 
    SQL = SQL & "    K0113_CSizeQty27      =  " & FormatSQL(z0113.CSizeQty27) & ", " 
    SQL = SQL & "    K0113_CSizeQty28      =  " & FormatSQL(z0113.CSizeQty28) & ", " 
    SQL = SQL & "    K0113_CSizeQty29      =  " & FormatSQL(z0113.CSizeQty29) & ", " 
    SQL = SQL & "    K0113_CSizeQty30      =  " & FormatSQL(z0113.CSizeQty30) & ", " 
    SQL = SQL & "    K0113_Remark      = N'" & FormatSQL(z0113.Remark) & "'  " 
    SQL = SQL & " WHERE K0113_UploadNo		 = '" & z0113.UploadNo & "' " 
    SQL = SQL & "   AND K0113_UploadSeq		 =  " & z0113.UploadSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK0113 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK0113",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK0113(z0113 As T0113_AREA) As Boolean
    DELETE_PFK0113 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK0113 "
    SQL = SQL & " WHERE K0113_UploadNo		 = '" & z0113.UploadNo & "' " 
    SQL = SQL & "   AND K0113_UploadSeq		 =  " & z0113.UploadSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK0113 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK0113",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D0113_CLEAR()
Try
    
   D0113.UploadNo = ""
    D0113.UploadSeq = 0 
   D0113.NameUpload = ""
   D0113.DateUpload = ""
   D0113.InchargeUpload = ""
   D0113.ComponentName = ""
   D0113.cdTypeCode = ""
   D0113.TypeCode = ""
   D0113.TypeName = ""
   D0113.Specification = ""
   D0113.Spec1 = ""
   D0113.Spec2 = ""
   D0113.Spec3 = ""
   D0113.Spec4 = ""
   D0113.Width = ""
   D0113.Height = ""
   D0113.seMainProcess = ""
   D0113.cdMainProcess = ""
   D0113.seSubProcess = ""
   D0113.cdSubProcess = ""
   D0113.SpecNo = ""
   D0113.SpecNoSeq = ""
    D0113.DSeq = 0 
    D0113.QtyComponent = 0 
    D0113.CSizeQty01 = 0 
    D0113.CSizeQty02 = 0 
    D0113.CSizeQty03 = 0 
    D0113.CSizeQty04 = 0 
    D0113.CSizeQty05 = 0 
    D0113.CSizeQty06 = 0 
    D0113.CSizeQty07 = 0 
    D0113.CSizeQty08 = 0 
    D0113.CSizeQty09 = 0 
    D0113.CSizeQty10 = 0 
    D0113.CSizeQty11 = 0 
    D0113.CSizeQty12 = 0 
    D0113.CSizeQty13 = 0 
    D0113.CSizeQty14 = 0 
    D0113.CSizeQty15 = 0 
    D0113.CSizeQty16 = 0 
    D0113.CSizeQty17 = 0 
    D0113.CSizeQty18 = 0 
    D0113.CSizeQty19 = 0 
    D0113.CSizeQty20 = 0 
    D0113.CSizeQty21 = 0 
    D0113.CSizeQty22 = 0 
    D0113.CSizeQty23 = 0 
    D0113.CSizeQty24 = 0 
    D0113.CSizeQty25 = 0 
    D0113.CSizeQty26 = 0 
    D0113.CSizeQty27 = 0 
    D0113.CSizeQty28 = 0 
    D0113.CSizeQty29 = 0 
    D0113.CSizeQty30 = 0 
   D0113.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D0113_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x0113 As T0113_AREA)
Try
    
    x0113.UploadNo = trim$(  x0113.UploadNo)
    x0113.UploadSeq = trim$(  x0113.UploadSeq)
    x0113.NameUpload = trim$(  x0113.NameUpload)
    x0113.DateUpload = trim$(  x0113.DateUpload)
    x0113.InchargeUpload = trim$(  x0113.InchargeUpload)
    x0113.ComponentName = trim$(  x0113.ComponentName)
    x0113.cdTypeCode = trim$(  x0113.cdTypeCode)
    x0113.TypeCode = trim$(  x0113.TypeCode)
    x0113.TypeName = trim$(  x0113.TypeName)
    x0113.Specification = trim$(  x0113.Specification)
    x0113.Spec1 = trim$(  x0113.Spec1)
    x0113.Spec2 = trim$(  x0113.Spec2)
    x0113.Spec3 = trim$(  x0113.Spec3)
    x0113.Spec4 = trim$(  x0113.Spec4)
    x0113.Width = trim$(  x0113.Width)
    x0113.Height = trim$(  x0113.Height)
    x0113.seMainProcess = trim$(  x0113.seMainProcess)
    x0113.cdMainProcess = trim$(  x0113.cdMainProcess)
    x0113.seSubProcess = trim$(  x0113.seSubProcess)
    x0113.cdSubProcess = trim$(  x0113.cdSubProcess)
    x0113.SpecNo = trim$(  x0113.SpecNo)
    x0113.SpecNoSeq = trim$(  x0113.SpecNoSeq)
    x0113.DSeq = trim$(  x0113.DSeq)
    x0113.QtyComponent = trim$(  x0113.QtyComponent)
    x0113.CSizeQty01 = trim$(  x0113.CSizeQty01)
    x0113.CSizeQty02 = trim$(  x0113.CSizeQty02)
    x0113.CSizeQty03 = trim$(  x0113.CSizeQty03)
    x0113.CSizeQty04 = trim$(  x0113.CSizeQty04)
    x0113.CSizeQty05 = trim$(  x0113.CSizeQty05)
    x0113.CSizeQty06 = trim$(  x0113.CSizeQty06)
    x0113.CSizeQty07 = trim$(  x0113.CSizeQty07)
    x0113.CSizeQty08 = trim$(  x0113.CSizeQty08)
    x0113.CSizeQty09 = trim$(  x0113.CSizeQty09)
    x0113.CSizeQty10 = trim$(  x0113.CSizeQty10)
    x0113.CSizeQty11 = trim$(  x0113.CSizeQty11)
    x0113.CSizeQty12 = trim$(  x0113.CSizeQty12)
    x0113.CSizeQty13 = trim$(  x0113.CSizeQty13)
    x0113.CSizeQty14 = trim$(  x0113.CSizeQty14)
    x0113.CSizeQty15 = trim$(  x0113.CSizeQty15)
    x0113.CSizeQty16 = trim$(  x0113.CSizeQty16)
    x0113.CSizeQty17 = trim$(  x0113.CSizeQty17)
    x0113.CSizeQty18 = trim$(  x0113.CSizeQty18)
    x0113.CSizeQty19 = trim$(  x0113.CSizeQty19)
    x0113.CSizeQty20 = trim$(  x0113.CSizeQty20)
    x0113.CSizeQty21 = trim$(  x0113.CSizeQty21)
    x0113.CSizeQty22 = trim$(  x0113.CSizeQty22)
    x0113.CSizeQty23 = trim$(  x0113.CSizeQty23)
    x0113.CSizeQty24 = trim$(  x0113.CSizeQty24)
    x0113.CSizeQty25 = trim$(  x0113.CSizeQty25)
    x0113.CSizeQty26 = trim$(  x0113.CSizeQty26)
    x0113.CSizeQty27 = trim$(  x0113.CSizeQty27)
    x0113.CSizeQty28 = trim$(  x0113.CSizeQty28)
    x0113.CSizeQty29 = trim$(  x0113.CSizeQty29)
    x0113.CSizeQty30 = trim$(  x0113.CSizeQty30)
    x0113.Remark = trim$(  x0113.Remark)
     
    If trim$( x0113.UploadNo ) = "" Then x0113.UploadNo = Space(1) 
    If trim$( x0113.UploadSeq ) = "" Then x0113.UploadSeq = 0 
    If trim$( x0113.NameUpload ) = "" Then x0113.NameUpload = Space(1) 
    If trim$( x0113.DateUpload ) = "" Then x0113.DateUpload = Space(1) 
    If trim$( x0113.InchargeUpload ) = "" Then x0113.InchargeUpload = Space(1) 
    If trim$( x0113.ComponentName ) = "" Then x0113.ComponentName = Space(1) 
    If trim$( x0113.cdTypeCode ) = "" Then x0113.cdTypeCode = Space(1) 
    If trim$( x0113.TypeCode ) = "" Then x0113.TypeCode = Space(1) 
    If trim$( x0113.TypeName ) = "" Then x0113.TypeName = Space(1) 
    If trim$( x0113.Specification ) = "" Then x0113.Specification = Space(1) 
    If trim$( x0113.Spec1 ) = "" Then x0113.Spec1 = Space(1) 
    If trim$( x0113.Spec2 ) = "" Then x0113.Spec2 = Space(1) 
    If trim$( x0113.Spec3 ) = "" Then x0113.Spec3 = Space(1) 
    If trim$( x0113.Spec4 ) = "" Then x0113.Spec4 = Space(1) 
    If trim$( x0113.Width ) = "" Then x0113.Width = Space(1) 
    If trim$( x0113.Height ) = "" Then x0113.Height = Space(1) 
    If trim$( x0113.seMainProcess ) = "" Then x0113.seMainProcess = Space(1) 
    If trim$( x0113.cdMainProcess ) = "" Then x0113.cdMainProcess = Space(1) 
    If trim$( x0113.seSubProcess ) = "" Then x0113.seSubProcess = Space(1) 
    If trim$( x0113.cdSubProcess ) = "" Then x0113.cdSubProcess = Space(1) 
    If trim$( x0113.SpecNo ) = "" Then x0113.SpecNo = Space(1) 
    If trim$( x0113.SpecNoSeq ) = "" Then x0113.SpecNoSeq = Space(1) 
    If trim$( x0113.DSeq ) = "" Then x0113.DSeq = 0 
    If trim$( x0113.QtyComponent ) = "" Then x0113.QtyComponent = 0 
    If trim$( x0113.CSizeQty01 ) = "" Then x0113.CSizeQty01 = 0 
    If trim$( x0113.CSizeQty02 ) = "" Then x0113.CSizeQty02 = 0 
    If trim$( x0113.CSizeQty03 ) = "" Then x0113.CSizeQty03 = 0 
    If trim$( x0113.CSizeQty04 ) = "" Then x0113.CSizeQty04 = 0 
    If trim$( x0113.CSizeQty05 ) = "" Then x0113.CSizeQty05 = 0 
    If trim$( x0113.CSizeQty06 ) = "" Then x0113.CSizeQty06 = 0 
    If trim$( x0113.CSizeQty07 ) = "" Then x0113.CSizeQty07 = 0 
    If trim$( x0113.CSizeQty08 ) = "" Then x0113.CSizeQty08 = 0 
    If trim$( x0113.CSizeQty09 ) = "" Then x0113.CSizeQty09 = 0 
    If trim$( x0113.CSizeQty10 ) = "" Then x0113.CSizeQty10 = 0 
    If trim$( x0113.CSizeQty11 ) = "" Then x0113.CSizeQty11 = 0 
    If trim$( x0113.CSizeQty12 ) = "" Then x0113.CSizeQty12 = 0 
    If trim$( x0113.CSizeQty13 ) = "" Then x0113.CSizeQty13 = 0 
    If trim$( x0113.CSizeQty14 ) = "" Then x0113.CSizeQty14 = 0 
    If trim$( x0113.CSizeQty15 ) = "" Then x0113.CSizeQty15 = 0 
    If trim$( x0113.CSizeQty16 ) = "" Then x0113.CSizeQty16 = 0 
    If trim$( x0113.CSizeQty17 ) = "" Then x0113.CSizeQty17 = 0 
    If trim$( x0113.CSizeQty18 ) = "" Then x0113.CSizeQty18 = 0 
    If trim$( x0113.CSizeQty19 ) = "" Then x0113.CSizeQty19 = 0 
    If trim$( x0113.CSizeQty20 ) = "" Then x0113.CSizeQty20 = 0 
    If trim$( x0113.CSizeQty21 ) = "" Then x0113.CSizeQty21 = 0 
    If trim$( x0113.CSizeQty22 ) = "" Then x0113.CSizeQty22 = 0 
    If trim$( x0113.CSizeQty23 ) = "" Then x0113.CSizeQty23 = 0 
    If trim$( x0113.CSizeQty24 ) = "" Then x0113.CSizeQty24 = 0 
    If trim$( x0113.CSizeQty25 ) = "" Then x0113.CSizeQty25 = 0 
    If trim$( x0113.CSizeQty26 ) = "" Then x0113.CSizeQty26 = 0 
    If trim$( x0113.CSizeQty27 ) = "" Then x0113.CSizeQty27 = 0 
    If trim$( x0113.CSizeQty28 ) = "" Then x0113.CSizeQty28 = 0 
    If trim$( x0113.CSizeQty29 ) = "" Then x0113.CSizeQty29 = 0 
    If trim$( x0113.CSizeQty30 ) = "" Then x0113.CSizeQty30 = 0 
    If trim$( x0113.Remark ) = "" Then x0113.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K0113_MOVE(rs0113 As SqlClient.SqlDataReader)
Try

    call D0113_CLEAR()   

    If IsdbNull(rs0113!K0113_UploadNo) = False Then D0113.UploadNo = Trim$(rs0113!K0113_UploadNo)
    If IsdbNull(rs0113!K0113_UploadSeq) = False Then D0113.UploadSeq = Trim$(rs0113!K0113_UploadSeq)
    If IsdbNull(rs0113!K0113_NameUpload) = False Then D0113.NameUpload = Trim$(rs0113!K0113_NameUpload)
    If IsdbNull(rs0113!K0113_DateUpload) = False Then D0113.DateUpload = Trim$(rs0113!K0113_DateUpload)
    If IsdbNull(rs0113!K0113_InchargeUpload) = False Then D0113.InchargeUpload = Trim$(rs0113!K0113_InchargeUpload)
    If IsdbNull(rs0113!K0113_ComponentName) = False Then D0113.ComponentName = Trim$(rs0113!K0113_ComponentName)
    If IsdbNull(rs0113!K0113_cdTypeCode) = False Then D0113.cdTypeCode = Trim$(rs0113!K0113_cdTypeCode)
    If IsdbNull(rs0113!K0113_TypeCode) = False Then D0113.TypeCode = Trim$(rs0113!K0113_TypeCode)
    If IsdbNull(rs0113!K0113_TypeName) = False Then D0113.TypeName = Trim$(rs0113!K0113_TypeName)
    If IsdbNull(rs0113!K0113_Specification) = False Then D0113.Specification = Trim$(rs0113!K0113_Specification)
    If IsdbNull(rs0113!K0113_Spec1) = False Then D0113.Spec1 = Trim$(rs0113!K0113_Spec1)
    If IsdbNull(rs0113!K0113_Spec2) = False Then D0113.Spec2 = Trim$(rs0113!K0113_Spec2)
    If IsdbNull(rs0113!K0113_Spec3) = False Then D0113.Spec3 = Trim$(rs0113!K0113_Spec3)
    If IsdbNull(rs0113!K0113_Spec4) = False Then D0113.Spec4 = Trim$(rs0113!K0113_Spec4)
    If IsdbNull(rs0113!K0113_Width) = False Then D0113.Width = Trim$(rs0113!K0113_Width)
    If IsdbNull(rs0113!K0113_Height) = False Then D0113.Height = Trim$(rs0113!K0113_Height)
    If IsdbNull(rs0113!K0113_seMainProcess) = False Then D0113.seMainProcess = Trim$(rs0113!K0113_seMainProcess)
    If IsdbNull(rs0113!K0113_cdMainProcess) = False Then D0113.cdMainProcess = Trim$(rs0113!K0113_cdMainProcess)
    If IsdbNull(rs0113!K0113_seSubProcess) = False Then D0113.seSubProcess = Trim$(rs0113!K0113_seSubProcess)
    If IsdbNull(rs0113!K0113_cdSubProcess) = False Then D0113.cdSubProcess = Trim$(rs0113!K0113_cdSubProcess)
    If IsdbNull(rs0113!K0113_SpecNo) = False Then D0113.SpecNo = Trim$(rs0113!K0113_SpecNo)
    If IsdbNull(rs0113!K0113_SpecNoSeq) = False Then D0113.SpecNoSeq = Trim$(rs0113!K0113_SpecNoSeq)
    If IsdbNull(rs0113!K0113_DSeq) = False Then D0113.DSeq = Trim$(rs0113!K0113_DSeq)
    If IsdbNull(rs0113!K0113_QtyComponent) = False Then D0113.QtyComponent = Trim$(rs0113!K0113_QtyComponent)
    If IsdbNull(rs0113!K0113_CSizeQty01) = False Then D0113.CSizeQty01 = Trim$(rs0113!K0113_CSizeQty01)
    If IsdbNull(rs0113!K0113_CSizeQty02) = False Then D0113.CSizeQty02 = Trim$(rs0113!K0113_CSizeQty02)
    If IsdbNull(rs0113!K0113_CSizeQty03) = False Then D0113.CSizeQty03 = Trim$(rs0113!K0113_CSizeQty03)
    If IsdbNull(rs0113!K0113_CSizeQty04) = False Then D0113.CSizeQty04 = Trim$(rs0113!K0113_CSizeQty04)
    If IsdbNull(rs0113!K0113_CSizeQty05) = False Then D0113.CSizeQty05 = Trim$(rs0113!K0113_CSizeQty05)
    If IsdbNull(rs0113!K0113_CSizeQty06) = False Then D0113.CSizeQty06 = Trim$(rs0113!K0113_CSizeQty06)
    If IsdbNull(rs0113!K0113_CSizeQty07) = False Then D0113.CSizeQty07 = Trim$(rs0113!K0113_CSizeQty07)
    If IsdbNull(rs0113!K0113_CSizeQty08) = False Then D0113.CSizeQty08 = Trim$(rs0113!K0113_CSizeQty08)
    If IsdbNull(rs0113!K0113_CSizeQty09) = False Then D0113.CSizeQty09 = Trim$(rs0113!K0113_CSizeQty09)
    If IsdbNull(rs0113!K0113_CSizeQty10) = False Then D0113.CSizeQty10 = Trim$(rs0113!K0113_CSizeQty10)
    If IsdbNull(rs0113!K0113_CSizeQty11) = False Then D0113.CSizeQty11 = Trim$(rs0113!K0113_CSizeQty11)
    If IsdbNull(rs0113!K0113_CSizeQty12) = False Then D0113.CSizeQty12 = Trim$(rs0113!K0113_CSizeQty12)
    If IsdbNull(rs0113!K0113_CSizeQty13) = False Then D0113.CSizeQty13 = Trim$(rs0113!K0113_CSizeQty13)
    If IsdbNull(rs0113!K0113_CSizeQty14) = False Then D0113.CSizeQty14 = Trim$(rs0113!K0113_CSizeQty14)
    If IsdbNull(rs0113!K0113_CSizeQty15) = False Then D0113.CSizeQty15 = Trim$(rs0113!K0113_CSizeQty15)
    If IsdbNull(rs0113!K0113_CSizeQty16) = False Then D0113.CSizeQty16 = Trim$(rs0113!K0113_CSizeQty16)
    If IsdbNull(rs0113!K0113_CSizeQty17) = False Then D0113.CSizeQty17 = Trim$(rs0113!K0113_CSizeQty17)
    If IsdbNull(rs0113!K0113_CSizeQty18) = False Then D0113.CSizeQty18 = Trim$(rs0113!K0113_CSizeQty18)
    If IsdbNull(rs0113!K0113_CSizeQty19) = False Then D0113.CSizeQty19 = Trim$(rs0113!K0113_CSizeQty19)
    If IsdbNull(rs0113!K0113_CSizeQty20) = False Then D0113.CSizeQty20 = Trim$(rs0113!K0113_CSizeQty20)
    If IsdbNull(rs0113!K0113_CSizeQty21) = False Then D0113.CSizeQty21 = Trim$(rs0113!K0113_CSizeQty21)
    If IsdbNull(rs0113!K0113_CSizeQty22) = False Then D0113.CSizeQty22 = Trim$(rs0113!K0113_CSizeQty22)
    If IsdbNull(rs0113!K0113_CSizeQty23) = False Then D0113.CSizeQty23 = Trim$(rs0113!K0113_CSizeQty23)
    If IsdbNull(rs0113!K0113_CSizeQty24) = False Then D0113.CSizeQty24 = Trim$(rs0113!K0113_CSizeQty24)
    If IsdbNull(rs0113!K0113_CSizeQty25) = False Then D0113.CSizeQty25 = Trim$(rs0113!K0113_CSizeQty25)
    If IsdbNull(rs0113!K0113_CSizeQty26) = False Then D0113.CSizeQty26 = Trim$(rs0113!K0113_CSizeQty26)
    If IsdbNull(rs0113!K0113_CSizeQty27) = False Then D0113.CSizeQty27 = Trim$(rs0113!K0113_CSizeQty27)
    If IsdbNull(rs0113!K0113_CSizeQty28) = False Then D0113.CSizeQty28 = Trim$(rs0113!K0113_CSizeQty28)
    If IsdbNull(rs0113!K0113_CSizeQty29) = False Then D0113.CSizeQty29 = Trim$(rs0113!K0113_CSizeQty29)
    If IsdbNull(rs0113!K0113_CSizeQty30) = False Then D0113.CSizeQty30 = Trim$(rs0113!K0113_CSizeQty30)
    If IsdbNull(rs0113!K0113_Remark) = False Then D0113.Remark = Trim$(rs0113!K0113_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0113_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K0113_MOVE(rs0113 As DataRow)
Try

    call D0113_CLEAR()   

    If IsdbNull(rs0113!K0113_UploadNo) = False Then D0113.UploadNo = Trim$(rs0113!K0113_UploadNo)
    If IsdbNull(rs0113!K0113_UploadSeq) = False Then D0113.UploadSeq = Trim$(rs0113!K0113_UploadSeq)
    If IsdbNull(rs0113!K0113_NameUpload) = False Then D0113.NameUpload = Trim$(rs0113!K0113_NameUpload)
    If IsdbNull(rs0113!K0113_DateUpload) = False Then D0113.DateUpload = Trim$(rs0113!K0113_DateUpload)
    If IsdbNull(rs0113!K0113_InchargeUpload) = False Then D0113.InchargeUpload = Trim$(rs0113!K0113_InchargeUpload)
    If IsdbNull(rs0113!K0113_ComponentName) = False Then D0113.ComponentName = Trim$(rs0113!K0113_ComponentName)
    If IsdbNull(rs0113!K0113_cdTypeCode) = False Then D0113.cdTypeCode = Trim$(rs0113!K0113_cdTypeCode)
    If IsdbNull(rs0113!K0113_TypeCode) = False Then D0113.TypeCode = Trim$(rs0113!K0113_TypeCode)
    If IsdbNull(rs0113!K0113_TypeName) = False Then D0113.TypeName = Trim$(rs0113!K0113_TypeName)
    If IsdbNull(rs0113!K0113_Specification) = False Then D0113.Specification = Trim$(rs0113!K0113_Specification)
    If IsdbNull(rs0113!K0113_Spec1) = False Then D0113.Spec1 = Trim$(rs0113!K0113_Spec1)
    If IsdbNull(rs0113!K0113_Spec2) = False Then D0113.Spec2 = Trim$(rs0113!K0113_Spec2)
    If IsdbNull(rs0113!K0113_Spec3) = False Then D0113.Spec3 = Trim$(rs0113!K0113_Spec3)
    If IsdbNull(rs0113!K0113_Spec4) = False Then D0113.Spec4 = Trim$(rs0113!K0113_Spec4)
    If IsdbNull(rs0113!K0113_Width) = False Then D0113.Width = Trim$(rs0113!K0113_Width)
    If IsdbNull(rs0113!K0113_Height) = False Then D0113.Height = Trim$(rs0113!K0113_Height)
    If IsdbNull(rs0113!K0113_seMainProcess) = False Then D0113.seMainProcess = Trim$(rs0113!K0113_seMainProcess)
    If IsdbNull(rs0113!K0113_cdMainProcess) = False Then D0113.cdMainProcess = Trim$(rs0113!K0113_cdMainProcess)
    If IsdbNull(rs0113!K0113_seSubProcess) = False Then D0113.seSubProcess = Trim$(rs0113!K0113_seSubProcess)
    If IsdbNull(rs0113!K0113_cdSubProcess) = False Then D0113.cdSubProcess = Trim$(rs0113!K0113_cdSubProcess)
    If IsdbNull(rs0113!K0113_SpecNo) = False Then D0113.SpecNo = Trim$(rs0113!K0113_SpecNo)
    If IsdbNull(rs0113!K0113_SpecNoSeq) = False Then D0113.SpecNoSeq = Trim$(rs0113!K0113_SpecNoSeq)
    If IsdbNull(rs0113!K0113_DSeq) = False Then D0113.DSeq = Trim$(rs0113!K0113_DSeq)
    If IsdbNull(rs0113!K0113_QtyComponent) = False Then D0113.QtyComponent = Trim$(rs0113!K0113_QtyComponent)
    If IsdbNull(rs0113!K0113_CSizeQty01) = False Then D0113.CSizeQty01 = Trim$(rs0113!K0113_CSizeQty01)
    If IsdbNull(rs0113!K0113_CSizeQty02) = False Then D0113.CSizeQty02 = Trim$(rs0113!K0113_CSizeQty02)
    If IsdbNull(rs0113!K0113_CSizeQty03) = False Then D0113.CSizeQty03 = Trim$(rs0113!K0113_CSizeQty03)
    If IsdbNull(rs0113!K0113_CSizeQty04) = False Then D0113.CSizeQty04 = Trim$(rs0113!K0113_CSizeQty04)
    If IsdbNull(rs0113!K0113_CSizeQty05) = False Then D0113.CSizeQty05 = Trim$(rs0113!K0113_CSizeQty05)
    If IsdbNull(rs0113!K0113_CSizeQty06) = False Then D0113.CSizeQty06 = Trim$(rs0113!K0113_CSizeQty06)
    If IsdbNull(rs0113!K0113_CSizeQty07) = False Then D0113.CSizeQty07 = Trim$(rs0113!K0113_CSizeQty07)
    If IsdbNull(rs0113!K0113_CSizeQty08) = False Then D0113.CSizeQty08 = Trim$(rs0113!K0113_CSizeQty08)
    If IsdbNull(rs0113!K0113_CSizeQty09) = False Then D0113.CSizeQty09 = Trim$(rs0113!K0113_CSizeQty09)
    If IsdbNull(rs0113!K0113_CSizeQty10) = False Then D0113.CSizeQty10 = Trim$(rs0113!K0113_CSizeQty10)
    If IsdbNull(rs0113!K0113_CSizeQty11) = False Then D0113.CSizeQty11 = Trim$(rs0113!K0113_CSizeQty11)
    If IsdbNull(rs0113!K0113_CSizeQty12) = False Then D0113.CSizeQty12 = Trim$(rs0113!K0113_CSizeQty12)
    If IsdbNull(rs0113!K0113_CSizeQty13) = False Then D0113.CSizeQty13 = Trim$(rs0113!K0113_CSizeQty13)
    If IsdbNull(rs0113!K0113_CSizeQty14) = False Then D0113.CSizeQty14 = Trim$(rs0113!K0113_CSizeQty14)
    If IsdbNull(rs0113!K0113_CSizeQty15) = False Then D0113.CSizeQty15 = Trim$(rs0113!K0113_CSizeQty15)
    If IsdbNull(rs0113!K0113_CSizeQty16) = False Then D0113.CSizeQty16 = Trim$(rs0113!K0113_CSizeQty16)
    If IsdbNull(rs0113!K0113_CSizeQty17) = False Then D0113.CSizeQty17 = Trim$(rs0113!K0113_CSizeQty17)
    If IsdbNull(rs0113!K0113_CSizeQty18) = False Then D0113.CSizeQty18 = Trim$(rs0113!K0113_CSizeQty18)
    If IsdbNull(rs0113!K0113_CSizeQty19) = False Then D0113.CSizeQty19 = Trim$(rs0113!K0113_CSizeQty19)
    If IsdbNull(rs0113!K0113_CSizeQty20) = False Then D0113.CSizeQty20 = Trim$(rs0113!K0113_CSizeQty20)
    If IsdbNull(rs0113!K0113_CSizeQty21) = False Then D0113.CSizeQty21 = Trim$(rs0113!K0113_CSizeQty21)
    If IsdbNull(rs0113!K0113_CSizeQty22) = False Then D0113.CSizeQty22 = Trim$(rs0113!K0113_CSizeQty22)
    If IsdbNull(rs0113!K0113_CSizeQty23) = False Then D0113.CSizeQty23 = Trim$(rs0113!K0113_CSizeQty23)
    If IsdbNull(rs0113!K0113_CSizeQty24) = False Then D0113.CSizeQty24 = Trim$(rs0113!K0113_CSizeQty24)
    If IsdbNull(rs0113!K0113_CSizeQty25) = False Then D0113.CSizeQty25 = Trim$(rs0113!K0113_CSizeQty25)
    If IsdbNull(rs0113!K0113_CSizeQty26) = False Then D0113.CSizeQty26 = Trim$(rs0113!K0113_CSizeQty26)
    If IsdbNull(rs0113!K0113_CSizeQty27) = False Then D0113.CSizeQty27 = Trim$(rs0113!K0113_CSizeQty27)
    If IsdbNull(rs0113!K0113_CSizeQty28) = False Then D0113.CSizeQty28 = Trim$(rs0113!K0113_CSizeQty28)
    If IsdbNull(rs0113!K0113_CSizeQty29) = False Then D0113.CSizeQty29 = Trim$(rs0113!K0113_CSizeQty29)
    If IsdbNull(rs0113!K0113_CSizeQty30) = False Then D0113.CSizeQty30 = Trim$(rs0113!K0113_CSizeQty30)
    If IsdbNull(rs0113!K0113_Remark) = False Then D0113.Remark = Trim$(rs0113!K0113_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0113_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K0113_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0113 As T0113_AREA, UPLOADNO AS String, UPLOADSEQ AS Double) as Boolean

K0113_MOVE = False

Try
    If READ_PFK0113(UPLOADNO, UPLOADSEQ) = True Then
                z0113 = D0113
		K0113_MOVE = True
		else
	z0113 = nothing
     End If

     If  getColumIndex(spr,"UploadNo") > -1 then z0113.UploadNo = getDataM(spr, getColumIndex(spr,"UploadNo"), xRow)
     If  getColumIndex(spr,"UploadSeq") > -1 then z0113.UploadSeq = getDataM(spr, getColumIndex(spr,"UploadSeq"), xRow)
     If  getColumIndex(spr,"NameUpload") > -1 then z0113.NameUpload = getDataM(spr, getColumIndex(spr,"NameUpload"), xRow)
     If  getColumIndex(spr,"DateUpload") > -1 then z0113.DateUpload = getDataM(spr, getColumIndex(spr,"DateUpload"), xRow)
     If  getColumIndex(spr,"InchargeUpload") > -1 then z0113.InchargeUpload = getDataM(spr, getColumIndex(spr,"InchargeUpload"), xRow)
     If  getColumIndex(spr,"ComponentName") > -1 then z0113.ComponentName = getDataM(spr, getColumIndex(spr,"ComponentName"), xRow)
     If  getColumIndex(spr,"cdTypeCode") > -1 then z0113.cdTypeCode = getDataM(spr, getColumIndex(spr,"cdTypeCode"), xRow)
     If  getColumIndex(spr,"TypeCode") > -1 then z0113.TypeCode = getDataM(spr, getColumIndex(spr,"TypeCode"), xRow)
     If  getColumIndex(spr,"TypeName") > -1 then z0113.TypeName = getDataM(spr, getColumIndex(spr,"TypeName"), xRow)
     If  getColumIndex(spr,"Specification") > -1 then z0113.Specification = getDataM(spr, getColumIndex(spr,"Specification"), xRow)
     If  getColumIndex(spr,"Spec1") > -1 then z0113.Spec1 = getDataM(spr, getColumIndex(spr,"Spec1"), xRow)
     If  getColumIndex(spr,"Spec2") > -1 then z0113.Spec2 = getDataM(spr, getColumIndex(spr,"Spec2"), xRow)
     If  getColumIndex(spr,"Spec3") > -1 then z0113.Spec3 = getDataM(spr, getColumIndex(spr,"Spec3"), xRow)
     If  getColumIndex(spr,"Spec4") > -1 then z0113.Spec4 = getDataM(spr, getColumIndex(spr,"Spec4"), xRow)
     If  getColumIndex(spr,"Width") > -1 then z0113.Width = getDataM(spr, getColumIndex(spr,"Width"), xRow)
     If  getColumIndex(spr,"Height") > -1 then z0113.Height = getDataM(spr, getColumIndex(spr,"Height"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z0113.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z0113.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z0113.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z0113.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"SpecNo") > -1 then z0113.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z0113.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"DSeq") > -1 then z0113.DSeq = getDataM(spr, getColumIndex(spr,"DSeq"), xRow)
     If  getColumIndex(spr,"QtyComponent") > -1 then z0113.QtyComponent = getDataM(spr, getColumIndex(spr,"QtyComponent"), xRow)
     If  getColumIndex(spr,"CSizeQty01") > -1 then z0113.CSizeQty01 = getDataM(spr, getColumIndex(spr,"CSizeQty01"), xRow)
     If  getColumIndex(spr,"CSizeQty02") > -1 then z0113.CSizeQty02 = getDataM(spr, getColumIndex(spr,"CSizeQty02"), xRow)
     If  getColumIndex(spr,"CSizeQty03") > -1 then z0113.CSizeQty03 = getDataM(spr, getColumIndex(spr,"CSizeQty03"), xRow)
     If  getColumIndex(spr,"CSizeQty04") > -1 then z0113.CSizeQty04 = getDataM(spr, getColumIndex(spr,"CSizeQty04"), xRow)
     If  getColumIndex(spr,"CSizeQty05") > -1 then z0113.CSizeQty05 = getDataM(spr, getColumIndex(spr,"CSizeQty05"), xRow)
     If  getColumIndex(spr,"CSizeQty06") > -1 then z0113.CSizeQty06 = getDataM(spr, getColumIndex(spr,"CSizeQty06"), xRow)
     If  getColumIndex(spr,"CSizeQty07") > -1 then z0113.CSizeQty07 = getDataM(spr, getColumIndex(spr,"CSizeQty07"), xRow)
     If  getColumIndex(spr,"CSizeQty08") > -1 then z0113.CSizeQty08 = getDataM(spr, getColumIndex(spr,"CSizeQty08"), xRow)
     If  getColumIndex(spr,"CSizeQty09") > -1 then z0113.CSizeQty09 = getDataM(spr, getColumIndex(spr,"CSizeQty09"), xRow)
     If  getColumIndex(spr,"CSizeQty10") > -1 then z0113.CSizeQty10 = getDataM(spr, getColumIndex(spr,"CSizeQty10"), xRow)
     If  getColumIndex(spr,"CSizeQty11") > -1 then z0113.CSizeQty11 = getDataM(spr, getColumIndex(spr,"CSizeQty11"), xRow)
     If  getColumIndex(spr,"CSizeQty12") > -1 then z0113.CSizeQty12 = getDataM(spr, getColumIndex(spr,"CSizeQty12"), xRow)
     If  getColumIndex(spr,"CSizeQty13") > -1 then z0113.CSizeQty13 = getDataM(spr, getColumIndex(spr,"CSizeQty13"), xRow)
     If  getColumIndex(spr,"CSizeQty14") > -1 then z0113.CSizeQty14 = getDataM(spr, getColumIndex(spr,"CSizeQty14"), xRow)
     If  getColumIndex(spr,"CSizeQty15") > -1 then z0113.CSizeQty15 = getDataM(spr, getColumIndex(spr,"CSizeQty15"), xRow)
     If  getColumIndex(spr,"CSizeQty16") > -1 then z0113.CSizeQty16 = getDataM(spr, getColumIndex(spr,"CSizeQty16"), xRow)
     If  getColumIndex(spr,"CSizeQty17") > -1 then z0113.CSizeQty17 = getDataM(spr, getColumIndex(spr,"CSizeQty17"), xRow)
     If  getColumIndex(spr,"CSizeQty18") > -1 then z0113.CSizeQty18 = getDataM(spr, getColumIndex(spr,"CSizeQty18"), xRow)
     If  getColumIndex(spr,"CSizeQty19") > -1 then z0113.CSizeQty19 = getDataM(spr, getColumIndex(spr,"CSizeQty19"), xRow)
     If  getColumIndex(spr,"CSizeQty20") > -1 then z0113.CSizeQty20 = getDataM(spr, getColumIndex(spr,"CSizeQty20"), xRow)
     If  getColumIndex(spr,"CSizeQty21") > -1 then z0113.CSizeQty21 = getDataM(spr, getColumIndex(spr,"CSizeQty21"), xRow)
     If  getColumIndex(spr,"CSizeQty22") > -1 then z0113.CSizeQty22 = getDataM(spr, getColumIndex(spr,"CSizeQty22"), xRow)
     If  getColumIndex(spr,"CSizeQty23") > -1 then z0113.CSizeQty23 = getDataM(spr, getColumIndex(spr,"CSizeQty23"), xRow)
     If  getColumIndex(spr,"CSizeQty24") > -1 then z0113.CSizeQty24 = getDataM(spr, getColumIndex(spr,"CSizeQty24"), xRow)
     If  getColumIndex(spr,"CSizeQty25") > -1 then z0113.CSizeQty25 = getDataM(spr, getColumIndex(spr,"CSizeQty25"), xRow)
     If  getColumIndex(spr,"CSizeQty26") > -1 then z0113.CSizeQty26 = getDataM(spr, getColumIndex(spr,"CSizeQty26"), xRow)
     If  getColumIndex(spr,"CSizeQty27") > -1 then z0113.CSizeQty27 = getDataM(spr, getColumIndex(spr,"CSizeQty27"), xRow)
     If  getColumIndex(spr,"CSizeQty28") > -1 then z0113.CSizeQty28 = getDataM(spr, getColumIndex(spr,"CSizeQty28"), xRow)
     If  getColumIndex(spr,"CSizeQty29") > -1 then z0113.CSizeQty29 = getDataM(spr, getColumIndex(spr,"CSizeQty29"), xRow)
     If  getColumIndex(spr,"CSizeQty30") > -1 then z0113.CSizeQty30 = getDataM(spr, getColumIndex(spr,"CSizeQty30"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0113.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0113_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K0113_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0113 As T0113_AREA,CheckClear as Boolean,UPLOADNO AS String, UPLOADSEQ AS Double) as Boolean

K0113_MOVE = False

Try
    If READ_PFK0113(UPLOADNO, UPLOADSEQ) = True Then
                z0113 = D0113
		K0113_MOVE = True
		else
	If CheckClear  = True then z0113 = nothing
     End If

     If  getColumIndex(spr,"UploadNo") > -1 then z0113.UploadNo = getDataM(spr, getColumIndex(spr,"UploadNo"), xRow)
     If  getColumIndex(spr,"UploadSeq") > -1 then z0113.UploadSeq = getDataM(spr, getColumIndex(spr,"UploadSeq"), xRow)
     If  getColumIndex(spr,"NameUpload") > -1 then z0113.NameUpload = getDataM(spr, getColumIndex(spr,"NameUpload"), xRow)
     If  getColumIndex(spr,"DateUpload") > -1 then z0113.DateUpload = getDataM(spr, getColumIndex(spr,"DateUpload"), xRow)
     If  getColumIndex(spr,"InchargeUpload") > -1 then z0113.InchargeUpload = getDataM(spr, getColumIndex(spr,"InchargeUpload"), xRow)
     If  getColumIndex(spr,"ComponentName") > -1 then z0113.ComponentName = getDataM(spr, getColumIndex(spr,"ComponentName"), xRow)
     If  getColumIndex(spr,"cdTypeCode") > -1 then z0113.cdTypeCode = getDataM(spr, getColumIndex(spr,"cdTypeCode"), xRow)
     If  getColumIndex(spr,"TypeCode") > -1 then z0113.TypeCode = getDataM(spr, getColumIndex(spr,"TypeCode"), xRow)
     If  getColumIndex(spr,"TypeName") > -1 then z0113.TypeName = getDataM(spr, getColumIndex(spr,"TypeName"), xRow)
     If  getColumIndex(spr,"Specification") > -1 then z0113.Specification = getDataM(spr, getColumIndex(spr,"Specification"), xRow)
     If  getColumIndex(spr,"Spec1") > -1 then z0113.Spec1 = getDataM(spr, getColumIndex(spr,"Spec1"), xRow)
     If  getColumIndex(spr,"Spec2") > -1 then z0113.Spec2 = getDataM(spr, getColumIndex(spr,"Spec2"), xRow)
     If  getColumIndex(spr,"Spec3") > -1 then z0113.Spec3 = getDataM(spr, getColumIndex(spr,"Spec3"), xRow)
     If  getColumIndex(spr,"Spec4") > -1 then z0113.Spec4 = getDataM(spr, getColumIndex(spr,"Spec4"), xRow)
     If  getColumIndex(spr,"Width") > -1 then z0113.Width = getDataM(spr, getColumIndex(spr,"Width"), xRow)
     If  getColumIndex(spr,"Height") > -1 then z0113.Height = getDataM(spr, getColumIndex(spr,"Height"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z0113.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z0113.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z0113.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z0113.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"SpecNo") > -1 then z0113.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z0113.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"DSeq") > -1 then z0113.DSeq = getDataM(spr, getColumIndex(spr,"DSeq"), xRow)
     If  getColumIndex(spr,"QtyComponent") > -1 then z0113.QtyComponent = getDataM(spr, getColumIndex(spr,"QtyComponent"), xRow)
     If  getColumIndex(spr,"CSizeQty01") > -1 then z0113.CSizeQty01 = getDataM(spr, getColumIndex(spr,"CSizeQty01"), xRow)
     If  getColumIndex(spr,"CSizeQty02") > -1 then z0113.CSizeQty02 = getDataM(spr, getColumIndex(spr,"CSizeQty02"), xRow)
     If  getColumIndex(spr,"CSizeQty03") > -1 then z0113.CSizeQty03 = getDataM(spr, getColumIndex(spr,"CSizeQty03"), xRow)
     If  getColumIndex(spr,"CSizeQty04") > -1 then z0113.CSizeQty04 = getDataM(spr, getColumIndex(spr,"CSizeQty04"), xRow)
     If  getColumIndex(spr,"CSizeQty05") > -1 then z0113.CSizeQty05 = getDataM(spr, getColumIndex(spr,"CSizeQty05"), xRow)
     If  getColumIndex(spr,"CSizeQty06") > -1 then z0113.CSizeQty06 = getDataM(spr, getColumIndex(spr,"CSizeQty06"), xRow)
     If  getColumIndex(spr,"CSizeQty07") > -1 then z0113.CSizeQty07 = getDataM(spr, getColumIndex(spr,"CSizeQty07"), xRow)
     If  getColumIndex(spr,"CSizeQty08") > -1 then z0113.CSizeQty08 = getDataM(spr, getColumIndex(spr,"CSizeQty08"), xRow)
     If  getColumIndex(spr,"CSizeQty09") > -1 then z0113.CSizeQty09 = getDataM(spr, getColumIndex(spr,"CSizeQty09"), xRow)
     If  getColumIndex(spr,"CSizeQty10") > -1 then z0113.CSizeQty10 = getDataM(spr, getColumIndex(spr,"CSizeQty10"), xRow)
     If  getColumIndex(spr,"CSizeQty11") > -1 then z0113.CSizeQty11 = getDataM(spr, getColumIndex(spr,"CSizeQty11"), xRow)
     If  getColumIndex(spr,"CSizeQty12") > -1 then z0113.CSizeQty12 = getDataM(spr, getColumIndex(spr,"CSizeQty12"), xRow)
     If  getColumIndex(spr,"CSizeQty13") > -1 then z0113.CSizeQty13 = getDataM(spr, getColumIndex(spr,"CSizeQty13"), xRow)
     If  getColumIndex(spr,"CSizeQty14") > -1 then z0113.CSizeQty14 = getDataM(spr, getColumIndex(spr,"CSizeQty14"), xRow)
     If  getColumIndex(spr,"CSizeQty15") > -1 then z0113.CSizeQty15 = getDataM(spr, getColumIndex(spr,"CSizeQty15"), xRow)
     If  getColumIndex(spr,"CSizeQty16") > -1 then z0113.CSizeQty16 = getDataM(spr, getColumIndex(spr,"CSizeQty16"), xRow)
     If  getColumIndex(spr,"CSizeQty17") > -1 then z0113.CSizeQty17 = getDataM(spr, getColumIndex(spr,"CSizeQty17"), xRow)
     If  getColumIndex(spr,"CSizeQty18") > -1 then z0113.CSizeQty18 = getDataM(spr, getColumIndex(spr,"CSizeQty18"), xRow)
     If  getColumIndex(spr,"CSizeQty19") > -1 then z0113.CSizeQty19 = getDataM(spr, getColumIndex(spr,"CSizeQty19"), xRow)
     If  getColumIndex(spr,"CSizeQty20") > -1 then z0113.CSizeQty20 = getDataM(spr, getColumIndex(spr,"CSizeQty20"), xRow)
     If  getColumIndex(spr,"CSizeQty21") > -1 then z0113.CSizeQty21 = getDataM(spr, getColumIndex(spr,"CSizeQty21"), xRow)
     If  getColumIndex(spr,"CSizeQty22") > -1 then z0113.CSizeQty22 = getDataM(spr, getColumIndex(spr,"CSizeQty22"), xRow)
     If  getColumIndex(spr,"CSizeQty23") > -1 then z0113.CSizeQty23 = getDataM(spr, getColumIndex(spr,"CSizeQty23"), xRow)
     If  getColumIndex(spr,"CSizeQty24") > -1 then z0113.CSizeQty24 = getDataM(spr, getColumIndex(spr,"CSizeQty24"), xRow)
     If  getColumIndex(spr,"CSizeQty25") > -1 then z0113.CSizeQty25 = getDataM(spr, getColumIndex(spr,"CSizeQty25"), xRow)
     If  getColumIndex(spr,"CSizeQty26") > -1 then z0113.CSizeQty26 = getDataM(spr, getColumIndex(spr,"CSizeQty26"), xRow)
     If  getColumIndex(spr,"CSizeQty27") > -1 then z0113.CSizeQty27 = getDataM(spr, getColumIndex(spr,"CSizeQty27"), xRow)
     If  getColumIndex(spr,"CSizeQty28") > -1 then z0113.CSizeQty28 = getDataM(spr, getColumIndex(spr,"CSizeQty28"), xRow)
     If  getColumIndex(spr,"CSizeQty29") > -1 then z0113.CSizeQty29 = getDataM(spr, getColumIndex(spr,"CSizeQty29"), xRow)
     If  getColumIndex(spr,"CSizeQty30") > -1 then z0113.CSizeQty30 = getDataM(spr, getColumIndex(spr,"CSizeQty30"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0113.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0113_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K0113_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0113 As T0113_AREA, Job as String, UPLOADNO AS String, UPLOADSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0113_MOVE = False

Try
    If READ_PFK0113(UPLOADNO, UPLOADSEQ) = True Then
                z0113 = D0113
		K0113_MOVE = True
		else
	z0113 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0113")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "UPLOADNO":z0113.UploadNo = Children(i).Code
   Case "UPLOADSEQ":z0113.UploadSeq = Children(i).Code
   Case "NAMEUPLOAD":z0113.NameUpload = Children(i).Code
   Case "DATEUPLOAD":z0113.DateUpload = Children(i).Code
   Case "INCHARGEUPLOAD":z0113.InchargeUpload = Children(i).Code
   Case "COMPONENTNAME":z0113.ComponentName = Children(i).Code
   Case "CDTYPECODE":z0113.cdTypeCode = Children(i).Code
   Case "TYPECODE":z0113.TypeCode = Children(i).Code
   Case "TYPENAME":z0113.TypeName = Children(i).Code
   Case "SPECIFICATION":z0113.Specification = Children(i).Code
   Case "SPEC1":z0113.Spec1 = Children(i).Code
   Case "SPEC2":z0113.Spec2 = Children(i).Code
   Case "SPEC3":z0113.Spec3 = Children(i).Code
   Case "SPEC4":z0113.Spec4 = Children(i).Code
   Case "WIDTH":z0113.Width = Children(i).Code
   Case "HEIGHT":z0113.Height = Children(i).Code
   Case "SEMAINPROCESS":z0113.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z0113.cdMainProcess = Children(i).Code
   Case "SESUBPROCESS":z0113.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z0113.cdSubProcess = Children(i).Code
   Case "SPECNO":z0113.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z0113.SpecNoSeq = Children(i).Code
   Case "DSEQ":z0113.DSeq = Children(i).Code
   Case "QTYCOMPONENT":z0113.QtyComponent = Children(i).Code
   Case "CSIZEQTY01":z0113.CSizeQty01 = Children(i).Code
   Case "CSIZEQTY02":z0113.CSizeQty02 = Children(i).Code
   Case "CSIZEQTY03":z0113.CSizeQty03 = Children(i).Code
   Case "CSIZEQTY04":z0113.CSizeQty04 = Children(i).Code
   Case "CSIZEQTY05":z0113.CSizeQty05 = Children(i).Code
   Case "CSIZEQTY06":z0113.CSizeQty06 = Children(i).Code
   Case "CSIZEQTY07":z0113.CSizeQty07 = Children(i).Code
   Case "CSIZEQTY08":z0113.CSizeQty08 = Children(i).Code
   Case "CSIZEQTY09":z0113.CSizeQty09 = Children(i).Code
   Case "CSIZEQTY10":z0113.CSizeQty10 = Children(i).Code
   Case "CSIZEQTY11":z0113.CSizeQty11 = Children(i).Code
   Case "CSIZEQTY12":z0113.CSizeQty12 = Children(i).Code
   Case "CSIZEQTY13":z0113.CSizeQty13 = Children(i).Code
   Case "CSIZEQTY14":z0113.CSizeQty14 = Children(i).Code
   Case "CSIZEQTY15":z0113.CSizeQty15 = Children(i).Code
   Case "CSIZEQTY16":z0113.CSizeQty16 = Children(i).Code
   Case "CSIZEQTY17":z0113.CSizeQty17 = Children(i).Code
   Case "CSIZEQTY18":z0113.CSizeQty18 = Children(i).Code
   Case "CSIZEQTY19":z0113.CSizeQty19 = Children(i).Code
   Case "CSIZEQTY20":z0113.CSizeQty20 = Children(i).Code
   Case "CSIZEQTY21":z0113.CSizeQty21 = Children(i).Code
   Case "CSIZEQTY22":z0113.CSizeQty22 = Children(i).Code
   Case "CSIZEQTY23":z0113.CSizeQty23 = Children(i).Code
   Case "CSIZEQTY24":z0113.CSizeQty24 = Children(i).Code
   Case "CSIZEQTY25":z0113.CSizeQty25 = Children(i).Code
   Case "CSIZEQTY26":z0113.CSizeQty26 = Children(i).Code
   Case "CSIZEQTY27":z0113.CSizeQty27 = Children(i).Code
   Case "CSIZEQTY28":z0113.CSizeQty28 = Children(i).Code
   Case "CSIZEQTY29":z0113.CSizeQty29 = Children(i).Code
   Case "CSIZEQTY30":z0113.CSizeQty30 = Children(i).Code
   Case "REMARK":z0113.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "UPLOADNO":z0113.UploadNo = Children(i).Data
   Case "UPLOADSEQ":z0113.UploadSeq = Children(i).Data
   Case "NAMEUPLOAD":z0113.NameUpload = Children(i).Data
   Case "DATEUPLOAD":z0113.DateUpload = Children(i).Data
   Case "INCHARGEUPLOAD":z0113.InchargeUpload = Children(i).Data
   Case "COMPONENTNAME":z0113.ComponentName = Children(i).Data
   Case "CDTYPECODE":z0113.cdTypeCode = Children(i).Data
   Case "TYPECODE":z0113.TypeCode = Children(i).Data
   Case "TYPENAME":z0113.TypeName = Children(i).Data
   Case "SPECIFICATION":z0113.Specification = Children(i).Data
   Case "SPEC1":z0113.Spec1 = Children(i).Data
   Case "SPEC2":z0113.Spec2 = Children(i).Data
   Case "SPEC3":z0113.Spec3 = Children(i).Data
   Case "SPEC4":z0113.Spec4 = Children(i).Data
   Case "WIDTH":z0113.Width = Children(i).Data
   Case "HEIGHT":z0113.Height = Children(i).Data
   Case "SEMAINPROCESS":z0113.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z0113.cdMainProcess = Children(i).Data
   Case "SESUBPROCESS":z0113.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z0113.cdSubProcess = Children(i).Data
   Case "SPECNO":z0113.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z0113.SpecNoSeq = Children(i).Data
   Case "DSEQ":z0113.DSeq = Children(i).Data
   Case "QTYCOMPONENT":z0113.QtyComponent = Children(i).Data
   Case "CSIZEQTY01":z0113.CSizeQty01 = Children(i).Data
   Case "CSIZEQTY02":z0113.CSizeQty02 = Children(i).Data
   Case "CSIZEQTY03":z0113.CSizeQty03 = Children(i).Data
   Case "CSIZEQTY04":z0113.CSizeQty04 = Children(i).Data
   Case "CSIZEQTY05":z0113.CSizeQty05 = Children(i).Data
   Case "CSIZEQTY06":z0113.CSizeQty06 = Children(i).Data
   Case "CSIZEQTY07":z0113.CSizeQty07 = Children(i).Data
   Case "CSIZEQTY08":z0113.CSizeQty08 = Children(i).Data
   Case "CSIZEQTY09":z0113.CSizeQty09 = Children(i).Data
   Case "CSIZEQTY10":z0113.CSizeQty10 = Children(i).Data
   Case "CSIZEQTY11":z0113.CSizeQty11 = Children(i).Data
   Case "CSIZEQTY12":z0113.CSizeQty12 = Children(i).Data
   Case "CSIZEQTY13":z0113.CSizeQty13 = Children(i).Data
   Case "CSIZEQTY14":z0113.CSizeQty14 = Children(i).Data
   Case "CSIZEQTY15":z0113.CSizeQty15 = Children(i).Data
   Case "CSIZEQTY16":z0113.CSizeQty16 = Children(i).Data
   Case "CSIZEQTY17":z0113.CSizeQty17 = Children(i).Data
   Case "CSIZEQTY18":z0113.CSizeQty18 = Children(i).Data
   Case "CSIZEQTY19":z0113.CSizeQty19 = Children(i).Data
   Case "CSIZEQTY20":z0113.CSizeQty20 = Children(i).Data
   Case "CSIZEQTY21":z0113.CSizeQty21 = Children(i).Data
   Case "CSIZEQTY22":z0113.CSizeQty22 = Children(i).Data
   Case "CSIZEQTY23":z0113.CSizeQty23 = Children(i).Data
   Case "CSIZEQTY24":z0113.CSizeQty24 = Children(i).Data
   Case "CSIZEQTY25":z0113.CSizeQty25 = Children(i).Data
   Case "CSIZEQTY26":z0113.CSizeQty26 = Children(i).Data
   Case "CSIZEQTY27":z0113.CSizeQty27 = Children(i).Data
   Case "CSIZEQTY28":z0113.CSizeQty28 = Children(i).Data
   Case "CSIZEQTY29":z0113.CSizeQty29 = Children(i).Data
   Case "CSIZEQTY30":z0113.CSizeQty30 = Children(i).Data
   Case "REMARK":z0113.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0113_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K0113_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0113 As T0113_AREA, Job as String, CheckClear as Boolean, UPLOADNO AS String, UPLOADSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0113_MOVE = False

Try
    If READ_PFK0113(UPLOADNO, UPLOADSEQ) = True Then
                z0113 = D0113
		K0113_MOVE = True
		else
	If CheckClear  = True then z0113 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0113")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "UPLOADNO":z0113.UploadNo = Children(i).Code
   Case "UPLOADSEQ":z0113.UploadSeq = Children(i).Code
   Case "NAMEUPLOAD":z0113.NameUpload = Children(i).Code
   Case "DATEUPLOAD":z0113.DateUpload = Children(i).Code
   Case "INCHARGEUPLOAD":z0113.InchargeUpload = Children(i).Code
   Case "COMPONENTNAME":z0113.ComponentName = Children(i).Code
   Case "CDTYPECODE":z0113.cdTypeCode = Children(i).Code
   Case "TYPECODE":z0113.TypeCode = Children(i).Code
   Case "TYPENAME":z0113.TypeName = Children(i).Code
   Case "SPECIFICATION":z0113.Specification = Children(i).Code
   Case "SPEC1":z0113.Spec1 = Children(i).Code
   Case "SPEC2":z0113.Spec2 = Children(i).Code
   Case "SPEC3":z0113.Spec3 = Children(i).Code
   Case "SPEC4":z0113.Spec4 = Children(i).Code
   Case "WIDTH":z0113.Width = Children(i).Code
   Case "HEIGHT":z0113.Height = Children(i).Code
   Case "SEMAINPROCESS":z0113.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z0113.cdMainProcess = Children(i).Code
   Case "SESUBPROCESS":z0113.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z0113.cdSubProcess = Children(i).Code
   Case "SPECNO":z0113.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z0113.SpecNoSeq = Children(i).Code
   Case "DSEQ":z0113.DSeq = Children(i).Code
   Case "QTYCOMPONENT":z0113.QtyComponent = Children(i).Code
   Case "CSIZEQTY01":z0113.CSizeQty01 = Children(i).Code
   Case "CSIZEQTY02":z0113.CSizeQty02 = Children(i).Code
   Case "CSIZEQTY03":z0113.CSizeQty03 = Children(i).Code
   Case "CSIZEQTY04":z0113.CSizeQty04 = Children(i).Code
   Case "CSIZEQTY05":z0113.CSizeQty05 = Children(i).Code
   Case "CSIZEQTY06":z0113.CSizeQty06 = Children(i).Code
   Case "CSIZEQTY07":z0113.CSizeQty07 = Children(i).Code
   Case "CSIZEQTY08":z0113.CSizeQty08 = Children(i).Code
   Case "CSIZEQTY09":z0113.CSizeQty09 = Children(i).Code
   Case "CSIZEQTY10":z0113.CSizeQty10 = Children(i).Code
   Case "CSIZEQTY11":z0113.CSizeQty11 = Children(i).Code
   Case "CSIZEQTY12":z0113.CSizeQty12 = Children(i).Code
   Case "CSIZEQTY13":z0113.CSizeQty13 = Children(i).Code
   Case "CSIZEQTY14":z0113.CSizeQty14 = Children(i).Code
   Case "CSIZEQTY15":z0113.CSizeQty15 = Children(i).Code
   Case "CSIZEQTY16":z0113.CSizeQty16 = Children(i).Code
   Case "CSIZEQTY17":z0113.CSizeQty17 = Children(i).Code
   Case "CSIZEQTY18":z0113.CSizeQty18 = Children(i).Code
   Case "CSIZEQTY19":z0113.CSizeQty19 = Children(i).Code
   Case "CSIZEQTY20":z0113.CSizeQty20 = Children(i).Code
   Case "CSIZEQTY21":z0113.CSizeQty21 = Children(i).Code
   Case "CSIZEQTY22":z0113.CSizeQty22 = Children(i).Code
   Case "CSIZEQTY23":z0113.CSizeQty23 = Children(i).Code
   Case "CSIZEQTY24":z0113.CSizeQty24 = Children(i).Code
   Case "CSIZEQTY25":z0113.CSizeQty25 = Children(i).Code
   Case "CSIZEQTY26":z0113.CSizeQty26 = Children(i).Code
   Case "CSIZEQTY27":z0113.CSizeQty27 = Children(i).Code
   Case "CSIZEQTY28":z0113.CSizeQty28 = Children(i).Code
   Case "CSIZEQTY29":z0113.CSizeQty29 = Children(i).Code
   Case "CSIZEQTY30":z0113.CSizeQty30 = Children(i).Code
   Case "REMARK":z0113.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "UPLOADNO":z0113.UploadNo = Children(i).Data
   Case "UPLOADSEQ":z0113.UploadSeq = Children(i).Data
   Case "NAMEUPLOAD":z0113.NameUpload = Children(i).Data
   Case "DATEUPLOAD":z0113.DateUpload = Children(i).Data
   Case "INCHARGEUPLOAD":z0113.InchargeUpload = Children(i).Data
   Case "COMPONENTNAME":z0113.ComponentName = Children(i).Data
   Case "CDTYPECODE":z0113.cdTypeCode = Children(i).Data
   Case "TYPECODE":z0113.TypeCode = Children(i).Data
   Case "TYPENAME":z0113.TypeName = Children(i).Data
   Case "SPECIFICATION":z0113.Specification = Children(i).Data
   Case "SPEC1":z0113.Spec1 = Children(i).Data
   Case "SPEC2":z0113.Spec2 = Children(i).Data
   Case "SPEC3":z0113.Spec3 = Children(i).Data
   Case "SPEC4":z0113.Spec4 = Children(i).Data
   Case "WIDTH":z0113.Width = Children(i).Data
   Case "HEIGHT":z0113.Height = Children(i).Data
   Case "SEMAINPROCESS":z0113.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z0113.cdMainProcess = Children(i).Data
   Case "SESUBPROCESS":z0113.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z0113.cdSubProcess = Children(i).Data
   Case "SPECNO":z0113.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z0113.SpecNoSeq = Children(i).Data
   Case "DSEQ":z0113.DSeq = Children(i).Data
   Case "QTYCOMPONENT":z0113.QtyComponent = Children(i).Data
   Case "CSIZEQTY01":z0113.CSizeQty01 = Children(i).Data
   Case "CSIZEQTY02":z0113.CSizeQty02 = Children(i).Data
   Case "CSIZEQTY03":z0113.CSizeQty03 = Children(i).Data
   Case "CSIZEQTY04":z0113.CSizeQty04 = Children(i).Data
   Case "CSIZEQTY05":z0113.CSizeQty05 = Children(i).Data
   Case "CSIZEQTY06":z0113.CSizeQty06 = Children(i).Data
   Case "CSIZEQTY07":z0113.CSizeQty07 = Children(i).Data
   Case "CSIZEQTY08":z0113.CSizeQty08 = Children(i).Data
   Case "CSIZEQTY09":z0113.CSizeQty09 = Children(i).Data
   Case "CSIZEQTY10":z0113.CSizeQty10 = Children(i).Data
   Case "CSIZEQTY11":z0113.CSizeQty11 = Children(i).Data
   Case "CSIZEQTY12":z0113.CSizeQty12 = Children(i).Data
   Case "CSIZEQTY13":z0113.CSizeQty13 = Children(i).Data
   Case "CSIZEQTY14":z0113.CSizeQty14 = Children(i).Data
   Case "CSIZEQTY15":z0113.CSizeQty15 = Children(i).Data
   Case "CSIZEQTY16":z0113.CSizeQty16 = Children(i).Data
   Case "CSIZEQTY17":z0113.CSizeQty17 = Children(i).Data
   Case "CSIZEQTY18":z0113.CSizeQty18 = Children(i).Data
   Case "CSIZEQTY19":z0113.CSizeQty19 = Children(i).Data
   Case "CSIZEQTY20":z0113.CSizeQty20 = Children(i).Data
   Case "CSIZEQTY21":z0113.CSizeQty21 = Children(i).Data
   Case "CSIZEQTY22":z0113.CSizeQty22 = Children(i).Data
   Case "CSIZEQTY23":z0113.CSizeQty23 = Children(i).Data
   Case "CSIZEQTY24":z0113.CSizeQty24 = Children(i).Data
   Case "CSIZEQTY25":z0113.CSizeQty25 = Children(i).Data
   Case "CSIZEQTY26":z0113.CSizeQty26 = Children(i).Data
   Case "CSIZEQTY27":z0113.CSizeQty27 = Children(i).Data
   Case "CSIZEQTY28":z0113.CSizeQty28 = Children(i).Data
   Case "CSIZEQTY29":z0113.CSizeQty29 = Children(i).Data
   Case "CSIZEQTY30":z0113.CSizeQty30 = Children(i).Data
   Case "REMARK":z0113.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0113_MOVE",vbCritical)
End Try
End Function 
    
End Module 
