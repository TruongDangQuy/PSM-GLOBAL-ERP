'=========================================================================================================================================================
'   TABLE : (PFK7700)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7700

Structure T7700_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	Autokey	 AS Double	'			decimal		*
Public 	seMainProcess	 AS String	'			char(3)
Public 	cdMainProcess	 AS String	'			char(3)
Public 	seFactory	 AS String	'			char(6)
Public 	cdFactory	 AS String	'			char(8)
Public 	CustomerCode	 AS String	'			char(6)
Public 	seOSLineProd	 AS String	'			char(6)
Public 	cdOSLineProd	 AS String	'			char(8)
Public 	MachineCode	 AS String	'			char(6)
Public 	DateTarget	 AS String	'			char(8)
Public 	HourTarget	 AS Double	'			decimal
Public 	OTTarget	 AS Double	'			decimal
Public 	WorkerTarget	 AS Double	'			decimal
Public 	QtyTarget	 AS Double	'			decimal
Public 	PPHTarget	 AS Double	'			decimal
Public 	PPHMTarget	 AS Double	'			decimal
Public 	HourActual	 AS Double	'			decimal
Public 	OTActual	 AS Double	'			decimal
Public 	WorkerActual	 AS Double	'			decimal
Public 	QtyProd	 AS Double	'			decimal
Public 	PPHActual	 AS Double	'			decimal
Public 	PPHMActual	 AS Double	'			decimal
Public 	InchargePlan	 AS String	'			char(8)
Public 	DateInsert	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(6)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(6)
Public 	Remark	 AS String	'			nvarchar(50)
'=========================================================================================================================================================
End structure

Public D7700 As T7700_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7700(AUTOKEY AS Double) As Boolean
    READ_PFK7700 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7700 "
    SQL = SQL & " WHERE K7700_Autokey		 =  " & Autokey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7700_CLEAR: GoTo SKIP_READ_PFK7700
                
    Call K7700_MOVE(rd)
    READ_PFK7700 = True

SKIP_READ_PFK7700:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7700",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7700(AUTOKEY AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7700 "
    SQL = SQL & " WHERE K7700_Autokey		 =  " & Autokey & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7700",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7700(z7700 As T7700_AREA) As Boolean
    WRITE_PFK7700 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7700)
 
    SQL = " INSERT INTO PFK7700 "
    SQL = SQL & " ( "
            SQL = SQL & " K7700_seMainProcess,"
    SQL = SQL & " K7700_cdMainProcess," 
    SQL = SQL & " K7700_seFactory," 
    SQL = SQL & " K7700_cdFactory," 
    SQL = SQL & " K7700_CustomerCode," 
    SQL = SQL & " K7700_seOSLineProd," 
    SQL = SQL & " K7700_cdOSLineProd," 
    SQL = SQL & " K7700_MachineCode," 
    SQL = SQL & " K7700_DateTarget," 
    SQL = SQL & " K7700_HourTarget," 
    SQL = SQL & " K7700_OTTarget," 
    SQL = SQL & " K7700_WorkerTarget," 
    SQL = SQL & " K7700_QtyTarget," 
    SQL = SQL & " K7700_PPHTarget," 
    SQL = SQL & " K7700_PPHMTarget," 
    SQL = SQL & " K7700_HourActual," 
    SQL = SQL & " K7700_OTActual," 
    SQL = SQL & " K7700_WorkerActual," 
    SQL = SQL & " K7700_QtyProd," 
    SQL = SQL & " K7700_PPHActual," 
    SQL = SQL & " K7700_PPHMActual," 
    SQL = SQL & " K7700_InchargePlan," 
    SQL = SQL & " K7700_DateInsert," 
    SQL = SQL & " K7700_InchargeInsert," 
    SQL = SQL & " K7700_DateUpdate," 
    SQL = SQL & " K7700_InchargeUpdate," 
    SQL = SQL & " K7700_Remark " 
    SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z7700.seMainProcess) & "', "
    SQL = SQL & "  N'" & FormatSQL(z7700.cdMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7700.seFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7700.cdFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7700.CustomerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7700.seOSLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7700.cdOSLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7700.MachineCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7700.DateTarget) & "', "  
    SQL = SQL & "   " & FormatSQL(z7700.HourTarget) & ", "  
    SQL = SQL & "   " & FormatSQL(z7700.OTTarget) & ", "  
    SQL = SQL & "   " & FormatSQL(z7700.WorkerTarget) & ", "  
    SQL = SQL & "   " & FormatSQL(z7700.QtyTarget) & ", "  
    SQL = SQL & "   " & FormatSQL(z7700.PPHTarget) & ", "  
    SQL = SQL & "   " & FormatSQL(z7700.PPHMTarget) & ", "  
    SQL = SQL & "   " & FormatSQL(z7700.HourActual) & ", "  
    SQL = SQL & "   " & FormatSQL(z7700.OTActual) & ", "  
    SQL = SQL & "   " & FormatSQL(z7700.WorkerActual) & ", "  
    SQL = SQL & "   " & FormatSQL(z7700.QtyProd) & ", "  
    SQL = SQL & "   " & FormatSQL(z7700.PPHActual) & ", "  
    SQL = SQL & "   " & FormatSQL(z7700.PPHMActual) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7700.InchargePlan) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7700.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7700.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7700.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7700.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7700.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7700 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7700",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7700(z7700 As T7700_AREA) As Boolean
    REWRITE_PFK7700 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7700)
   
    SQL = " UPDATE PFK7700 SET "
    SQL = SQL & "    K7700_seMainProcess      = N'" & FormatSQL(z7700.seMainProcess) & "', " 
    SQL = SQL & "    K7700_cdMainProcess      = N'" & FormatSQL(z7700.cdMainProcess) & "', " 
    SQL = SQL & "    K7700_seFactory      = N'" & FormatSQL(z7700.seFactory) & "', " 
    SQL = SQL & "    K7700_cdFactory      = N'" & FormatSQL(z7700.cdFactory) & "', " 
    SQL = SQL & "    K7700_CustomerCode      = N'" & FormatSQL(z7700.CustomerCode) & "', " 
    SQL = SQL & "    K7700_seOSLineProd      = N'" & FormatSQL(z7700.seOSLineProd) & "', " 
    SQL = SQL & "    K7700_cdOSLineProd      = N'" & FormatSQL(z7700.cdOSLineProd) & "', " 
    SQL = SQL & "    K7700_MachineCode      = N'" & FormatSQL(z7700.MachineCode) & "', " 
    SQL = SQL & "    K7700_DateTarget      = N'" & FormatSQL(z7700.DateTarget) & "', " 
    SQL = SQL & "    K7700_HourTarget      =  " & FormatSQL(z7700.HourTarget) & ", " 
    SQL = SQL & "    K7700_OTTarget      =  " & FormatSQL(z7700.OTTarget) & ", " 
    SQL = SQL & "    K7700_WorkerTarget      =  " & FormatSQL(z7700.WorkerTarget) & ", " 
    SQL = SQL & "    K7700_QtyTarget      =  " & FormatSQL(z7700.QtyTarget) & ", " 
    SQL = SQL & "    K7700_PPHTarget      =  " & FormatSQL(z7700.PPHTarget) & ", " 
    SQL = SQL & "    K7700_PPHMTarget      =  " & FormatSQL(z7700.PPHMTarget) & ", " 
    SQL = SQL & "    K7700_HourActual      =  " & FormatSQL(z7700.HourActual) & ", " 
    SQL = SQL & "    K7700_OTActual      =  " & FormatSQL(z7700.OTActual) & ", " 
    SQL = SQL & "    K7700_WorkerActual      =  " & FormatSQL(z7700.WorkerActual) & ", " 
    SQL = SQL & "    K7700_QtyProd      =  " & FormatSQL(z7700.QtyProd) & ", " 
    SQL = SQL & "    K7700_PPHActual      =  " & FormatSQL(z7700.PPHActual) & ", " 
    SQL = SQL & "    K7700_PPHMActual      =  " & FormatSQL(z7700.PPHMActual) & ", " 
    SQL = SQL & "    K7700_InchargePlan      = N'" & FormatSQL(z7700.InchargePlan) & "', " 
    SQL = SQL & "    K7700_DateInsert      = N'" & FormatSQL(z7700.DateInsert) & "', " 
    SQL = SQL & "    K7700_InchargeInsert      = N'" & FormatSQL(z7700.InchargeInsert) & "', " 
    SQL = SQL & "    K7700_DateUpdate      = N'" & FormatSQL(z7700.DateUpdate) & "', " 
    SQL = SQL & "    K7700_InchargeUpdate      = N'" & FormatSQL(z7700.InchargeUpdate) & "', " 
    SQL = SQL & "    K7700_Remark      = N'" & FormatSQL(z7700.Remark) & "'  " 
    SQL = SQL & " WHERE K7700_Autokey		 =  " & z7700.Autokey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7700 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7700",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7700(z7700 As T7700_AREA) As Boolean
    DELETE_PFK7700 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7700 "
    SQL = SQL & " WHERE K7700_Autokey		 =  " & z7700.Autokey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7700 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7700",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7700_CLEAR()
Try
    
    D7700.Autokey = 0 
   D7700.seMainProcess = ""
   D7700.cdMainProcess = ""
   D7700.seFactory = ""
   D7700.cdFactory = ""
   D7700.CustomerCode = ""
   D7700.seOSLineProd = ""
   D7700.cdOSLineProd = ""
   D7700.MachineCode = ""
   D7700.DateTarget = ""
    D7700.HourTarget = 0 
    D7700.OTTarget = 0 
    D7700.WorkerTarget = 0 
    D7700.QtyTarget = 0 
    D7700.PPHTarget = 0 
    D7700.PPHMTarget = 0 
    D7700.HourActual = 0 
    D7700.OTActual = 0 
    D7700.WorkerActual = 0 
    D7700.QtyProd = 0 
    D7700.PPHActual = 0 
    D7700.PPHMActual = 0 
   D7700.InchargePlan = ""
   D7700.DateInsert = ""
   D7700.InchargeInsert = ""
   D7700.DateUpdate = ""
   D7700.InchargeUpdate = ""
   D7700.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7700_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7700 As T7700_AREA)
Try
    
    x7700.Autokey = trim$(  x7700.Autokey)
    x7700.seMainProcess = trim$(  x7700.seMainProcess)
    x7700.cdMainProcess = trim$(  x7700.cdMainProcess)
    x7700.seFactory = trim$(  x7700.seFactory)
    x7700.cdFactory = trim$(  x7700.cdFactory)
    x7700.CustomerCode = trim$(  x7700.CustomerCode)
    x7700.seOSLineProd = trim$(  x7700.seOSLineProd)
    x7700.cdOSLineProd = trim$(  x7700.cdOSLineProd)
    x7700.MachineCode = trim$(  x7700.MachineCode)
    x7700.DateTarget = trim$(  x7700.DateTarget)
    x7700.HourTarget = trim$(  x7700.HourTarget)
    x7700.OTTarget = trim$(  x7700.OTTarget)
    x7700.WorkerTarget = trim$(  x7700.WorkerTarget)
    x7700.QtyTarget = trim$(  x7700.QtyTarget)
    x7700.PPHTarget = trim$(  x7700.PPHTarget)
    x7700.PPHMTarget = trim$(  x7700.PPHMTarget)
    x7700.HourActual = trim$(  x7700.HourActual)
    x7700.OTActual = trim$(  x7700.OTActual)
    x7700.WorkerActual = trim$(  x7700.WorkerActual)
    x7700.QtyProd = trim$(  x7700.QtyProd)
    x7700.PPHActual = trim$(  x7700.PPHActual)
    x7700.PPHMActual = trim$(  x7700.PPHMActual)
    x7700.InchargePlan = trim$(  x7700.InchargePlan)
    x7700.DateInsert = trim$(  x7700.DateInsert)
    x7700.InchargeInsert = trim$(  x7700.InchargeInsert)
    x7700.DateUpdate = trim$(  x7700.DateUpdate)
    x7700.InchargeUpdate = trim$(  x7700.InchargeUpdate)
    x7700.Remark = trim$(  x7700.Remark)
     
    If trim$( x7700.Autokey ) = "" Then x7700.Autokey = 0 
    If trim$( x7700.seMainProcess ) = "" Then x7700.seMainProcess = Space(1) 
    If trim$( x7700.cdMainProcess ) = "" Then x7700.cdMainProcess = Space(1) 
    If trim$( x7700.seFactory ) = "" Then x7700.seFactory = Space(1) 
    If trim$( x7700.cdFactory ) = "" Then x7700.cdFactory = Space(1) 
    If trim$( x7700.CustomerCode ) = "" Then x7700.CustomerCode = Space(1) 
    If trim$( x7700.seOSLineProd ) = "" Then x7700.seOSLineProd = Space(1) 
    If trim$( x7700.cdOSLineProd ) = "" Then x7700.cdOSLineProd = Space(1) 
    If trim$( x7700.MachineCode ) = "" Then x7700.MachineCode = Space(1) 
    If trim$( x7700.DateTarget ) = "" Then x7700.DateTarget = Space(1) 
    If trim$( x7700.HourTarget ) = "" Then x7700.HourTarget = 0 
    If trim$( x7700.OTTarget ) = "" Then x7700.OTTarget = 0 
    If trim$( x7700.WorkerTarget ) = "" Then x7700.WorkerTarget = 0 
    If trim$( x7700.QtyTarget ) = "" Then x7700.QtyTarget = 0 
    If trim$( x7700.PPHTarget ) = "" Then x7700.PPHTarget = 0 
    If trim$( x7700.PPHMTarget ) = "" Then x7700.PPHMTarget = 0 
    If trim$( x7700.HourActual ) = "" Then x7700.HourActual = 0 
    If trim$( x7700.OTActual ) = "" Then x7700.OTActual = 0 
    If trim$( x7700.WorkerActual ) = "" Then x7700.WorkerActual = 0 
    If trim$( x7700.QtyProd ) = "" Then x7700.QtyProd = 0 
    If trim$( x7700.PPHActual ) = "" Then x7700.PPHActual = 0 
    If trim$( x7700.PPHMActual ) = "" Then x7700.PPHMActual = 0 
    If trim$( x7700.InchargePlan ) = "" Then x7700.InchargePlan = Space(1) 
    If trim$( x7700.DateInsert ) = "" Then x7700.DateInsert = Space(1) 
    If trim$( x7700.InchargeInsert ) = "" Then x7700.InchargeInsert = Space(1) 
    If trim$( x7700.DateUpdate ) = "" Then x7700.DateUpdate = Space(1) 
    If trim$( x7700.InchargeUpdate ) = "" Then x7700.InchargeUpdate = Space(1) 
    If trim$( x7700.Remark ) = "" Then x7700.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7700_MOVE(rs7700 As SqlClient.SqlDataReader)
Try

    call D7700_CLEAR()   

    If IsdbNull(rs7700!K7700_Autokey) = False Then D7700.Autokey = Trim$(rs7700!K7700_Autokey)
    If IsdbNull(rs7700!K7700_seMainProcess) = False Then D7700.seMainProcess = Trim$(rs7700!K7700_seMainProcess)
    If IsdbNull(rs7700!K7700_cdMainProcess) = False Then D7700.cdMainProcess = Trim$(rs7700!K7700_cdMainProcess)
    If IsdbNull(rs7700!K7700_seFactory) = False Then D7700.seFactory = Trim$(rs7700!K7700_seFactory)
    If IsdbNull(rs7700!K7700_cdFactory) = False Then D7700.cdFactory = Trim$(rs7700!K7700_cdFactory)
    If IsdbNull(rs7700!K7700_CustomerCode) = False Then D7700.CustomerCode = Trim$(rs7700!K7700_CustomerCode)
    If IsdbNull(rs7700!K7700_seOSLineProd) = False Then D7700.seOSLineProd = Trim$(rs7700!K7700_seOSLineProd)
    If IsdbNull(rs7700!K7700_cdOSLineProd) = False Then D7700.cdOSLineProd = Trim$(rs7700!K7700_cdOSLineProd)
    If IsdbNull(rs7700!K7700_MachineCode) = False Then D7700.MachineCode = Trim$(rs7700!K7700_MachineCode)
    If IsdbNull(rs7700!K7700_DateTarget) = False Then D7700.DateTarget = Trim$(rs7700!K7700_DateTarget)
    If IsdbNull(rs7700!K7700_HourTarget) = False Then D7700.HourTarget = Trim$(rs7700!K7700_HourTarget)
    If IsdbNull(rs7700!K7700_OTTarget) = False Then D7700.OTTarget = Trim$(rs7700!K7700_OTTarget)
    If IsdbNull(rs7700!K7700_WorkerTarget) = False Then D7700.WorkerTarget = Trim$(rs7700!K7700_WorkerTarget)
    If IsdbNull(rs7700!K7700_QtyTarget) = False Then D7700.QtyTarget = Trim$(rs7700!K7700_QtyTarget)
    If IsdbNull(rs7700!K7700_PPHTarget) = False Then D7700.PPHTarget = Trim$(rs7700!K7700_PPHTarget)
    If IsdbNull(rs7700!K7700_PPHMTarget) = False Then D7700.PPHMTarget = Trim$(rs7700!K7700_PPHMTarget)
    If IsdbNull(rs7700!K7700_HourActual) = False Then D7700.HourActual = Trim$(rs7700!K7700_HourActual)
    If IsdbNull(rs7700!K7700_OTActual) = False Then D7700.OTActual = Trim$(rs7700!K7700_OTActual)
    If IsdbNull(rs7700!K7700_WorkerActual) = False Then D7700.WorkerActual = Trim$(rs7700!K7700_WorkerActual)
    If IsdbNull(rs7700!K7700_QtyProd) = False Then D7700.QtyProd = Trim$(rs7700!K7700_QtyProd)
    If IsdbNull(rs7700!K7700_PPHActual) = False Then D7700.PPHActual = Trim$(rs7700!K7700_PPHActual)
    If IsdbNull(rs7700!K7700_PPHMActual) = False Then D7700.PPHMActual = Trim$(rs7700!K7700_PPHMActual)
    If IsdbNull(rs7700!K7700_InchargePlan) = False Then D7700.InchargePlan = Trim$(rs7700!K7700_InchargePlan)
    If IsdbNull(rs7700!K7700_DateInsert) = False Then D7700.DateInsert = Trim$(rs7700!K7700_DateInsert)
    If IsdbNull(rs7700!K7700_InchargeInsert) = False Then D7700.InchargeInsert = Trim$(rs7700!K7700_InchargeInsert)
    If IsdbNull(rs7700!K7700_DateUpdate) = False Then D7700.DateUpdate = Trim$(rs7700!K7700_DateUpdate)
    If IsdbNull(rs7700!K7700_InchargeUpdate) = False Then D7700.InchargeUpdate = Trim$(rs7700!K7700_InchargeUpdate)
    If IsdbNull(rs7700!K7700_Remark) = False Then D7700.Remark = Trim$(rs7700!K7700_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7700_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7700_MOVE(rs7700 As DataRow)
Try

    call D7700_CLEAR()   

    If IsdbNull(rs7700!K7700_Autokey) = False Then D7700.Autokey = Trim$(rs7700!K7700_Autokey)
    If IsdbNull(rs7700!K7700_seMainProcess) = False Then D7700.seMainProcess = Trim$(rs7700!K7700_seMainProcess)
    If IsdbNull(rs7700!K7700_cdMainProcess) = False Then D7700.cdMainProcess = Trim$(rs7700!K7700_cdMainProcess)
    If IsdbNull(rs7700!K7700_seFactory) = False Then D7700.seFactory = Trim$(rs7700!K7700_seFactory)
    If IsdbNull(rs7700!K7700_cdFactory) = False Then D7700.cdFactory = Trim$(rs7700!K7700_cdFactory)
    If IsdbNull(rs7700!K7700_CustomerCode) = False Then D7700.CustomerCode = Trim$(rs7700!K7700_CustomerCode)
    If IsdbNull(rs7700!K7700_seOSLineProd) = False Then D7700.seOSLineProd = Trim$(rs7700!K7700_seOSLineProd)
    If IsdbNull(rs7700!K7700_cdOSLineProd) = False Then D7700.cdOSLineProd = Trim$(rs7700!K7700_cdOSLineProd)
    If IsdbNull(rs7700!K7700_MachineCode) = False Then D7700.MachineCode = Trim$(rs7700!K7700_MachineCode)
    If IsdbNull(rs7700!K7700_DateTarget) = False Then D7700.DateTarget = Trim$(rs7700!K7700_DateTarget)
    If IsdbNull(rs7700!K7700_HourTarget) = False Then D7700.HourTarget = Trim$(rs7700!K7700_HourTarget)
    If IsdbNull(rs7700!K7700_OTTarget) = False Then D7700.OTTarget = Trim$(rs7700!K7700_OTTarget)
    If IsdbNull(rs7700!K7700_WorkerTarget) = False Then D7700.WorkerTarget = Trim$(rs7700!K7700_WorkerTarget)
    If IsdbNull(rs7700!K7700_QtyTarget) = False Then D7700.QtyTarget = Trim$(rs7700!K7700_QtyTarget)
    If IsdbNull(rs7700!K7700_PPHTarget) = False Then D7700.PPHTarget = Trim$(rs7700!K7700_PPHTarget)
    If IsdbNull(rs7700!K7700_PPHMTarget) = False Then D7700.PPHMTarget = Trim$(rs7700!K7700_PPHMTarget)
    If IsdbNull(rs7700!K7700_HourActual) = False Then D7700.HourActual = Trim$(rs7700!K7700_HourActual)
    If IsdbNull(rs7700!K7700_OTActual) = False Then D7700.OTActual = Trim$(rs7700!K7700_OTActual)
    If IsdbNull(rs7700!K7700_WorkerActual) = False Then D7700.WorkerActual = Trim$(rs7700!K7700_WorkerActual)
    If IsdbNull(rs7700!K7700_QtyProd) = False Then D7700.QtyProd = Trim$(rs7700!K7700_QtyProd)
    If IsdbNull(rs7700!K7700_PPHActual) = False Then D7700.PPHActual = Trim$(rs7700!K7700_PPHActual)
    If IsdbNull(rs7700!K7700_PPHMActual) = False Then D7700.PPHMActual = Trim$(rs7700!K7700_PPHMActual)
    If IsdbNull(rs7700!K7700_InchargePlan) = False Then D7700.InchargePlan = Trim$(rs7700!K7700_InchargePlan)
    If IsdbNull(rs7700!K7700_DateInsert) = False Then D7700.DateInsert = Trim$(rs7700!K7700_DateInsert)
    If IsdbNull(rs7700!K7700_InchargeInsert) = False Then D7700.InchargeInsert = Trim$(rs7700!K7700_InchargeInsert)
    If IsdbNull(rs7700!K7700_DateUpdate) = False Then D7700.DateUpdate = Trim$(rs7700!K7700_DateUpdate)
    If IsdbNull(rs7700!K7700_InchargeUpdate) = False Then D7700.InchargeUpdate = Trim$(rs7700!K7700_InchargeUpdate)
    If IsdbNull(rs7700!K7700_Remark) = False Then D7700.Remark = Trim$(rs7700!K7700_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7700_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7700_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7700 As T7700_AREA, AUTOKEY AS Double) as Boolean

K7700_MOVE = False

Try
    If READ_PFK7700(AUTOKEY) = True Then
                z7700 = D7700
		K7700_MOVE = True
		else
	z7700 = nothing
     End If

     If  getColumIndex(spr,"Autokey") > -1 then z7700.Autokey = getDataM(spr, getColumIndex(spr,"Autokey"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z7700.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z7700.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z7700.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"cdFactory") > -1 then z7700.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z7700.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"seOSLineProd") > -1 then z7700.seOSLineProd = getDataM(spr, getColumIndex(spr,"seOSLineProd"), xRow)
     If  getColumIndex(spr,"cdOSLineProd") > -1 then z7700.cdOSLineProd = getDataM(spr, getColumIndex(spr,"cdOSLineProd"), xRow)
     If  getColumIndex(spr,"MachineCode") > -1 then z7700.MachineCode = getDataM(spr, getColumIndex(spr,"MachineCode"), xRow)
     If  getColumIndex(spr,"DateTarget") > -1 then z7700.DateTarget = getDataM(spr, getColumIndex(spr,"DateTarget"), xRow)
     If  getColumIndex(spr,"HourTarget") > -1 then z7700.HourTarget = getDataM(spr, getColumIndex(spr,"HourTarget"), xRow)
     If  getColumIndex(spr,"OTTarget") > -1 then z7700.OTTarget = getDataM(spr, getColumIndex(spr,"OTTarget"), xRow)
     If  getColumIndex(spr,"WorkerTarget") > -1 then z7700.WorkerTarget = getDataM(spr, getColumIndex(spr,"WorkerTarget"), xRow)
     If  getColumIndex(spr,"QtyTarget") > -1 then z7700.QtyTarget = getDataM(spr, getColumIndex(spr,"QtyTarget"), xRow)
     If  getColumIndex(spr,"PPHTarget") > -1 then z7700.PPHTarget = getDataM(spr, getColumIndex(spr,"PPHTarget"), xRow)
     If  getColumIndex(spr,"PPHMTarget") > -1 then z7700.PPHMTarget = getDataM(spr, getColumIndex(spr,"PPHMTarget"), xRow)
     If  getColumIndex(spr,"HourActual") > -1 then z7700.HourActual = getDataM(spr, getColumIndex(spr,"HourActual"), xRow)
     If  getColumIndex(spr,"OTActual") > -1 then z7700.OTActual = getDataM(spr, getColumIndex(spr,"OTActual"), xRow)
     If  getColumIndex(spr,"WorkerActual") > -1 then z7700.WorkerActual = getDataM(spr, getColumIndex(spr,"WorkerActual"), xRow)
     If  getColumIndex(spr,"QtyProd") > -1 then z7700.QtyProd = getDataM(spr, getColumIndex(spr,"QtyProd"), xRow)
     If  getColumIndex(spr,"PPHActual") > -1 then z7700.PPHActual = getDataM(spr, getColumIndex(spr,"PPHActual"), xRow)
     If  getColumIndex(spr,"PPHMActual") > -1 then z7700.PPHMActual = getDataM(spr, getColumIndex(spr,"PPHMActual"), xRow)
     If  getColumIndex(spr,"InchargePlan") > -1 then z7700.InchargePlan = getDataM(spr, getColumIndex(spr,"InchargePlan"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7700.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7700.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7700.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7700.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7700.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7700_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7700_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7700 As T7700_AREA,CheckClear as Boolean,AUTOKEY AS Double) as Boolean

K7700_MOVE = False

Try
    If READ_PFK7700(AUTOKEY) = True Then
                z7700 = D7700
		K7700_MOVE = True
		else
	If CheckClear  = True then z7700 = nothing
     End If

     If  getColumIndex(spr,"Autokey") > -1 then z7700.Autokey = getDataM(spr, getColumIndex(spr,"Autokey"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z7700.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z7700.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z7700.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"cdFactory") > -1 then z7700.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z7700.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"seOSLineProd") > -1 then z7700.seOSLineProd = getDataM(spr, getColumIndex(spr,"seOSLineProd"), xRow)
     If  getColumIndex(spr,"cdOSLineProd") > -1 then z7700.cdOSLineProd = getDataM(spr, getColumIndex(spr,"cdOSLineProd"), xRow)
     If  getColumIndex(spr,"MachineCode") > -1 then z7700.MachineCode = getDataM(spr, getColumIndex(spr,"MachineCode"), xRow)
     If  getColumIndex(spr,"DateTarget") > -1 then z7700.DateTarget = getDataM(spr, getColumIndex(spr,"DateTarget"), xRow)
     If  getColumIndex(spr,"HourTarget") > -1 then z7700.HourTarget = getDataM(spr, getColumIndex(spr,"HourTarget"), xRow)
     If  getColumIndex(spr,"OTTarget") > -1 then z7700.OTTarget = getDataM(spr, getColumIndex(spr,"OTTarget"), xRow)
     If  getColumIndex(spr,"WorkerTarget") > -1 then z7700.WorkerTarget = getDataM(spr, getColumIndex(spr,"WorkerTarget"), xRow)
     If  getColumIndex(spr,"QtyTarget") > -1 then z7700.QtyTarget = getDataM(spr, getColumIndex(spr,"QtyTarget"), xRow)
     If  getColumIndex(spr,"PPHTarget") > -1 then z7700.PPHTarget = getDataM(spr, getColumIndex(spr,"PPHTarget"), xRow)
     If  getColumIndex(spr,"PPHMTarget") > -1 then z7700.PPHMTarget = getDataM(spr, getColumIndex(spr,"PPHMTarget"), xRow)
     If  getColumIndex(spr,"HourActual") > -1 then z7700.HourActual = getDataM(spr, getColumIndex(spr,"HourActual"), xRow)
     If  getColumIndex(spr,"OTActual") > -1 then z7700.OTActual = getDataM(spr, getColumIndex(spr,"OTActual"), xRow)
     If  getColumIndex(spr,"WorkerActual") > -1 then z7700.WorkerActual = getDataM(spr, getColumIndex(spr,"WorkerActual"), xRow)
     If  getColumIndex(spr,"QtyProd") > -1 then z7700.QtyProd = getDataM(spr, getColumIndex(spr,"QtyProd"), xRow)
     If  getColumIndex(spr,"PPHActual") > -1 then z7700.PPHActual = getDataM(spr, getColumIndex(spr,"PPHActual"), xRow)
     If  getColumIndex(spr,"PPHMActual") > -1 then z7700.PPHMActual = getDataM(spr, getColumIndex(spr,"PPHMActual"), xRow)
     If  getColumIndex(spr,"InchargePlan") > -1 then z7700.InchargePlan = getDataM(spr, getColumIndex(spr,"InchargePlan"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7700.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7700.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7700.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7700.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7700.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7700_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7700_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7700 As T7700_AREA, Job as String, AUTOKEY AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7700_MOVE = False

Try
    If READ_PFK7700(AUTOKEY) = True Then
                z7700 = D7700
		K7700_MOVE = True
		else
	z7700 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7700")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z7700.Autokey = Children(i).Code
   Case "SEMAINPROCESS":z7700.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z7700.cdMainProcess = Children(i).Code
   Case "SEFACTORY":z7700.seFactory = Children(i).Code
   Case "CDFACTORY":z7700.cdFactory = Children(i).Code
   Case "CUSTOMERCODE":z7700.CustomerCode = Children(i).Code
   Case "SEOSLINEPROD":z7700.seOSLineProd = Children(i).Code
   Case "CDOSLINEPROD":z7700.cdOSLineProd = Children(i).Code
   Case "MACHINECODE":z7700.MachineCode = Children(i).Code
   Case "DATETARGET":z7700.DateTarget = Children(i).Code
   Case "HOURTARGET":z7700.HourTarget = Children(i).Code
   Case "OTTARGET":z7700.OTTarget = Children(i).Code
   Case "WORKERTARGET":z7700.WorkerTarget = Children(i).Code
   Case "QTYTARGET":z7700.QtyTarget = Children(i).Code
   Case "PPHTARGET":z7700.PPHTarget = Children(i).Code
   Case "PPHMTARGET":z7700.PPHMTarget = Children(i).Code
   Case "HOURACTUAL":z7700.HourActual = Children(i).Code
   Case "OTACTUAL":z7700.OTActual = Children(i).Code
   Case "WORKERACTUAL":z7700.WorkerActual = Children(i).Code
   Case "QTYPROD":z7700.QtyProd = Children(i).Code
   Case "PPHACTUAL":z7700.PPHActual = Children(i).Code
   Case "PPHMACTUAL":z7700.PPHMActual = Children(i).Code
   Case "INCHARGEPLAN":z7700.InchargePlan = Children(i).Code
   Case "DATEINSERT":z7700.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z7700.InchargeInsert = Children(i).Code
   Case "DATEUPDATE":z7700.DateUpdate = Children(i).Code
   Case "INCHARGEUPDATE":z7700.InchargeUpdate = Children(i).Code
   Case "REMARK":z7700.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z7700.Autokey = Children(i).Data
   Case "SEMAINPROCESS":z7700.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z7700.cdMainProcess = Children(i).Data
   Case "SEFACTORY":z7700.seFactory = Children(i).Data
   Case "CDFACTORY":z7700.cdFactory = Children(i).Data
   Case "CUSTOMERCODE":z7700.CustomerCode = Children(i).Data
   Case "SEOSLINEPROD":z7700.seOSLineProd = Children(i).Data
   Case "CDOSLINEPROD":z7700.cdOSLineProd = Children(i).Data
   Case "MACHINECODE":z7700.MachineCode = Children(i).Data
   Case "DATETARGET":z7700.DateTarget = Children(i).Data
   Case "HOURTARGET":z7700.HourTarget = Children(i).Data
   Case "OTTARGET":z7700.OTTarget = Children(i).Data
   Case "WORKERTARGET":z7700.WorkerTarget = Children(i).Data
   Case "QTYTARGET":z7700.QtyTarget = Children(i).Data
   Case "PPHTARGET":z7700.PPHTarget = Children(i).Data
   Case "PPHMTARGET":z7700.PPHMTarget = Children(i).Data
   Case "HOURACTUAL":z7700.HourActual = Children(i).Data
   Case "OTACTUAL":z7700.OTActual = Children(i).Data
   Case "WORKERACTUAL":z7700.WorkerActual = Children(i).Data
   Case "QTYPROD":z7700.QtyProd = Children(i).Data
   Case "PPHACTUAL":z7700.PPHActual = Children(i).Data
   Case "PPHMACTUAL":z7700.PPHMActual = Children(i).Data
   Case "INCHARGEPLAN":z7700.InchargePlan = Children(i).Data
   Case "DATEINSERT":z7700.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z7700.InchargeInsert = Children(i).Data
   Case "DATEUPDATE":z7700.DateUpdate = Children(i).Data
   Case "INCHARGEUPDATE":z7700.InchargeUpdate = Children(i).Data
   Case "REMARK":z7700.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7700_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7700_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7700 As T7700_AREA, Job as String, CheckClear as Boolean, AUTOKEY AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7700_MOVE = False

Try
    If READ_PFK7700(AUTOKEY) = True Then
                z7700 = D7700
		K7700_MOVE = True
		else
	If CheckClear  = True then z7700 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7700")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z7700.Autokey = Children(i).Code
   Case "SEMAINPROCESS":z7700.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z7700.cdMainProcess = Children(i).Code
   Case "SEFACTORY":z7700.seFactory = Children(i).Code
   Case "CDFACTORY":z7700.cdFactory = Children(i).Code
   Case "CUSTOMERCODE":z7700.CustomerCode = Children(i).Code
   Case "SEOSLINEPROD":z7700.seOSLineProd = Children(i).Code
   Case "CDOSLINEPROD":z7700.cdOSLineProd = Children(i).Code
   Case "MACHINECODE":z7700.MachineCode = Children(i).Code
   Case "DATETARGET":z7700.DateTarget = Children(i).Code
   Case "HOURTARGET":z7700.HourTarget = Children(i).Code
   Case "OTTARGET":z7700.OTTarget = Children(i).Code
   Case "WORKERTARGET":z7700.WorkerTarget = Children(i).Code
   Case "QTYTARGET":z7700.QtyTarget = Children(i).Code
   Case "PPHTARGET":z7700.PPHTarget = Children(i).Code
   Case "PPHMTARGET":z7700.PPHMTarget = Children(i).Code
   Case "HOURACTUAL":z7700.HourActual = Children(i).Code
   Case "OTACTUAL":z7700.OTActual = Children(i).Code
   Case "WORKERACTUAL":z7700.WorkerActual = Children(i).Code
   Case "QTYPROD":z7700.QtyProd = Children(i).Code
   Case "PPHACTUAL":z7700.PPHActual = Children(i).Code
   Case "PPHMACTUAL":z7700.PPHMActual = Children(i).Code
   Case "INCHARGEPLAN":z7700.InchargePlan = Children(i).Code
   Case "DATEINSERT":z7700.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z7700.InchargeInsert = Children(i).Code
   Case "DATEUPDATE":z7700.DateUpdate = Children(i).Code
   Case "INCHARGEUPDATE":z7700.InchargeUpdate = Children(i).Code
   Case "REMARK":z7700.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z7700.Autokey = Children(i).Data
   Case "SEMAINPROCESS":z7700.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z7700.cdMainProcess = Children(i).Data
   Case "SEFACTORY":z7700.seFactory = Children(i).Data
   Case "CDFACTORY":z7700.cdFactory = Children(i).Data
   Case "CUSTOMERCODE":z7700.CustomerCode = Children(i).Data
   Case "SEOSLINEPROD":z7700.seOSLineProd = Children(i).Data
   Case "CDOSLINEPROD":z7700.cdOSLineProd = Children(i).Data
   Case "MACHINECODE":z7700.MachineCode = Children(i).Data
   Case "DATETARGET":z7700.DateTarget = Children(i).Data
   Case "HOURTARGET":z7700.HourTarget = Children(i).Data
   Case "OTTARGET":z7700.OTTarget = Children(i).Data
   Case "WORKERTARGET":z7700.WorkerTarget = Children(i).Data
   Case "QTYTARGET":z7700.QtyTarget = Children(i).Data
   Case "PPHTARGET":z7700.PPHTarget = Children(i).Data
   Case "PPHMTARGET":z7700.PPHMTarget = Children(i).Data
   Case "HOURACTUAL":z7700.HourActual = Children(i).Data
   Case "OTACTUAL":z7700.OTActual = Children(i).Data
   Case "WORKERACTUAL":z7700.WorkerActual = Children(i).Data
   Case "QTYPROD":z7700.QtyProd = Children(i).Data
   Case "PPHACTUAL":z7700.PPHActual = Children(i).Data
   Case "PPHMACTUAL":z7700.PPHMActual = Children(i).Data
   Case "INCHARGEPLAN":z7700.InchargePlan = Children(i).Data
   Case "DATEINSERT":z7700.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z7700.InchargeInsert = Children(i).Data
   Case "DATEUPDATE":z7700.DateUpdate = Children(i).Data
   Case "INCHARGEUPDATE":z7700.InchargeUpdate = Children(i).Data
   Case "REMARK":z7700.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7700_MOVE",vbCritical)
End Try
End Function 
    
End Module 
