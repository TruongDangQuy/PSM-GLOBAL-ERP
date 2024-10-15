'=========================================================================================================================================================
'   TABLE : (PFK4066)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K4066

Structure T4066_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	Autokey	 AS Double	'			decimal		*
Public 	seMainProcess	 AS String	'			char(3)
Public 	cdMainProcess	 AS String	'			char(3)
Public 	SealMaster	 AS String	'			char(10)
Public 	seFactory	 AS String	'			char(3)
Public 	cdFactory	 AS String	'			char(3)
Public 	CustomerCode	 AS String	'			char(6)
Public 	seLineProd	 AS String	'			char(3)
Public 	cdLineProd	 AS String	'			char(3)
Public 	MachineCode	 AS String	'			char(6)
Public 	DatePlan	 AS String	'			char(8)
Public 	DateFinish	 AS String	'			char(8)
Public 	Description	 AS String	'			nvarchar(50)
Public 	QtyPlan	 AS Double	'			decimal
Public 	QtyProd	 AS Double	'			decimal
Public 	InchargePlan	 AS String	'			char(8)
Public 	DateInsert	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(6)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(6)
Public 	Remark	 AS String	'			nvarchar(50)
'=========================================================================================================================================================
End structure

Public D4066 As T4066_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK4066(AUTOKEY AS Double) As Boolean
    READ_PFK4066 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4066 "
    SQL = SQL & " WHERE K4066_Autokey		 =  " & Autokey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D4066_CLEAR: GoTo SKIP_READ_PFK4066
                
    Call K4066_MOVE(rd)
    READ_PFK4066 = True

SKIP_READ_PFK4066:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK4066",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK4066(AUTOKEY AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4066 "
    SQL = SQL & " WHERE K4066_Autokey		 =  " & Autokey & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK4066",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK4066(z4066 As T4066_AREA) As Boolean
    WRITE_PFK4066 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z4066)
 
    SQL = " INSERT INTO PFK4066 "
    SQL = SQL & " ( "
            SQL = SQL & " K4066_seMainProcess,"
    SQL = SQL & " K4066_cdMainProcess," 
    SQL = SQL & " K4066_SealMaster," 
    SQL = SQL & " K4066_seFactory," 
    SQL = SQL & " K4066_cdFactory," 
    SQL = SQL & " K4066_CustomerCode," 
    SQL = SQL & " K4066_seLineProd," 
    SQL = SQL & " K4066_cdLineProd," 
    SQL = SQL & " K4066_MachineCode," 
    SQL = SQL & " K4066_DatePlan," 
    SQL = SQL & " K4066_DateFinish," 
    SQL = SQL & " K4066_Description," 
    SQL = SQL & " K4066_QtyPlan," 
    SQL = SQL & " K4066_QtyProd," 
    SQL = SQL & " K4066_InchargePlan," 
    SQL = SQL & " K4066_DateInsert," 
    SQL = SQL & " K4066_InchargeInsert," 
    SQL = SQL & " K4066_DateUpdate," 
    SQL = SQL & " K4066_InchargeUpdate," 
    SQL = SQL & " K4066_Remark " 
    SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z4066.seMainProcess) & "', "
    SQL = SQL & "  N'" & FormatSQL(z4066.cdMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4066.SealMaster) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4066.seFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4066.cdFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4066.CustomerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4066.seLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4066.cdLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4066.MachineCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4066.DatePlan) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4066.DateFinish) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4066.Description) & "', "  
    SQL = SQL & "   " & FormatSQL(z4066.QtyPlan) & ", "  
    SQL = SQL & "   " & FormatSQL(z4066.QtyProd) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4066.InchargePlan) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4066.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4066.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4066.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4066.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4066.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK4066 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK4066",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK4066(z4066 As T4066_AREA) As Boolean
    REWRITE_PFK4066 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z4066)
   
    SQL = " UPDATE PFK4066 SET "
    SQL = SQL & "    K4066_seMainProcess      = N'" & FormatSQL(z4066.seMainProcess) & "', " 
    SQL = SQL & "    K4066_cdMainProcess      = N'" & FormatSQL(z4066.cdMainProcess) & "', " 
    SQL = SQL & "    K4066_SealMaster      = N'" & FormatSQL(z4066.SealMaster) & "', " 
    SQL = SQL & "    K4066_seFactory      = N'" & FormatSQL(z4066.seFactory) & "', " 
    SQL = SQL & "    K4066_cdFactory      = N'" & FormatSQL(z4066.cdFactory) & "', " 
    SQL = SQL & "    K4066_CustomerCode      = N'" & FormatSQL(z4066.CustomerCode) & "', " 
    SQL = SQL & "    K4066_seLineProd      = N'" & FormatSQL(z4066.seLineProd) & "', " 
    SQL = SQL & "    K4066_cdLineProd      = N'" & FormatSQL(z4066.cdLineProd) & "', " 
    SQL = SQL & "    K4066_MachineCode      = N'" & FormatSQL(z4066.MachineCode) & "', " 
    SQL = SQL & "    K4066_DatePlan      = N'" & FormatSQL(z4066.DatePlan) & "', " 
    SQL = SQL & "    K4066_DateFinish      = N'" & FormatSQL(z4066.DateFinish) & "', " 
    SQL = SQL & "    K4066_Description      = N'" & FormatSQL(z4066.Description) & "', " 
    SQL = SQL & "    K4066_QtyPlan      =  " & FormatSQL(z4066.QtyPlan) & ", " 
    SQL = SQL & "    K4066_QtyProd      =  " & FormatSQL(z4066.QtyProd) & ", " 
    SQL = SQL & "    K4066_InchargePlan      = N'" & FormatSQL(z4066.InchargePlan) & "', " 
    SQL = SQL & "    K4066_DateInsert      = N'" & FormatSQL(z4066.DateInsert) & "', " 
    SQL = SQL & "    K4066_InchargeInsert      = N'" & FormatSQL(z4066.InchargeInsert) & "', " 
    SQL = SQL & "    K4066_DateUpdate      = N'" & FormatSQL(z4066.DateUpdate) & "', " 
    SQL = SQL & "    K4066_InchargeUpdate      = N'" & FormatSQL(z4066.InchargeUpdate) & "', " 
    SQL = SQL & "    K4066_Remark      = N'" & FormatSQL(z4066.Remark) & "'  " 
    SQL = SQL & " WHERE K4066_Autokey		 =  " & z4066.Autokey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK4066 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK4066",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK4066(z4066 As T4066_AREA) As Boolean
    DELETE_PFK4066 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK4066 "
    SQL = SQL & " WHERE K4066_Autokey		 =  " & z4066.Autokey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK4066 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK4066",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D4066_CLEAR()
Try
    
    D4066.Autokey = 0 
   D4066.seMainProcess = ""
   D4066.cdMainProcess = ""
   D4066.SealMaster = ""
   D4066.seFactory = ""
   D4066.cdFactory = ""
   D4066.CustomerCode = ""
   D4066.seLineProd = ""
   D4066.cdLineProd = ""
   D4066.MachineCode = ""
   D4066.DatePlan = ""
   D4066.DateFinish = ""
   D4066.Description = ""
    D4066.QtyPlan = 0 
    D4066.QtyProd = 0 
   D4066.InchargePlan = ""
   D4066.DateInsert = ""
   D4066.InchargeInsert = ""
   D4066.DateUpdate = ""
   D4066.InchargeUpdate = ""
   D4066.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D4066_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x4066 As T4066_AREA)
Try
    
    x4066.Autokey = trim$(  x4066.Autokey)
    x4066.seMainProcess = trim$(  x4066.seMainProcess)
    x4066.cdMainProcess = trim$(  x4066.cdMainProcess)
    x4066.SealMaster = trim$(  x4066.SealMaster)
    x4066.seFactory = trim$(  x4066.seFactory)
    x4066.cdFactory = trim$(  x4066.cdFactory)
    x4066.CustomerCode = trim$(  x4066.CustomerCode)
    x4066.seLineProd = trim$(  x4066.seLineProd)
    x4066.cdLineProd = trim$(  x4066.cdLineProd)
    x4066.MachineCode = trim$(  x4066.MachineCode)
    x4066.DatePlan = trim$(  x4066.DatePlan)
    x4066.DateFinish = trim$(  x4066.DateFinish)
    x4066.Description = trim$(  x4066.Description)
    x4066.QtyPlan = trim$(  x4066.QtyPlan)
    x4066.QtyProd = trim$(  x4066.QtyProd)
    x4066.InchargePlan = trim$(  x4066.InchargePlan)
    x4066.DateInsert = trim$(  x4066.DateInsert)
    x4066.InchargeInsert = trim$(  x4066.InchargeInsert)
    x4066.DateUpdate = trim$(  x4066.DateUpdate)
    x4066.InchargeUpdate = trim$(  x4066.InchargeUpdate)
    x4066.Remark = trim$(  x4066.Remark)
     
    If trim$( x4066.Autokey ) = "" Then x4066.Autokey = 0 
    If trim$( x4066.seMainProcess ) = "" Then x4066.seMainProcess = Space(1) 
    If trim$( x4066.cdMainProcess ) = "" Then x4066.cdMainProcess = Space(1) 
    If trim$( x4066.SealMaster ) = "" Then x4066.SealMaster = Space(1) 
    If trim$( x4066.seFactory ) = "" Then x4066.seFactory = Space(1) 
    If trim$( x4066.cdFactory ) = "" Then x4066.cdFactory = Space(1) 
    If trim$( x4066.CustomerCode ) = "" Then x4066.CustomerCode = Space(1) 
    If trim$( x4066.seLineProd ) = "" Then x4066.seLineProd = Space(1) 
    If trim$( x4066.cdLineProd ) = "" Then x4066.cdLineProd = Space(1) 
    If trim$( x4066.MachineCode ) = "" Then x4066.MachineCode = Space(1) 
    If trim$( x4066.DatePlan ) = "" Then x4066.DatePlan = Space(1) 
    If trim$( x4066.DateFinish ) = "" Then x4066.DateFinish = Space(1) 
    If trim$( x4066.Description ) = "" Then x4066.Description = Space(1) 
    If trim$( x4066.QtyPlan ) = "" Then x4066.QtyPlan = 0 
    If trim$( x4066.QtyProd ) = "" Then x4066.QtyProd = 0 
    If trim$( x4066.InchargePlan ) = "" Then x4066.InchargePlan = Space(1) 
    If trim$( x4066.DateInsert ) = "" Then x4066.DateInsert = Space(1) 
    If trim$( x4066.InchargeInsert ) = "" Then x4066.InchargeInsert = Space(1) 
    If trim$( x4066.DateUpdate ) = "" Then x4066.DateUpdate = Space(1) 
    If trim$( x4066.InchargeUpdate ) = "" Then x4066.InchargeUpdate = Space(1) 
    If trim$( x4066.Remark ) = "" Then x4066.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K4066_MOVE(rs4066 As SqlClient.SqlDataReader)
Try

    call D4066_CLEAR()   

    If IsdbNull(rs4066!K4066_Autokey) = False Then D4066.Autokey = Trim$(rs4066!K4066_Autokey)
    If IsdbNull(rs4066!K4066_seMainProcess) = False Then D4066.seMainProcess = Trim$(rs4066!K4066_seMainProcess)
    If IsdbNull(rs4066!K4066_cdMainProcess) = False Then D4066.cdMainProcess = Trim$(rs4066!K4066_cdMainProcess)
    If IsdbNull(rs4066!K4066_SealMaster) = False Then D4066.SealMaster = Trim$(rs4066!K4066_SealMaster)
    If IsdbNull(rs4066!K4066_seFactory) = False Then D4066.seFactory = Trim$(rs4066!K4066_seFactory)
    If IsdbNull(rs4066!K4066_cdFactory) = False Then D4066.cdFactory = Trim$(rs4066!K4066_cdFactory)
    If IsdbNull(rs4066!K4066_CustomerCode) = False Then D4066.CustomerCode = Trim$(rs4066!K4066_CustomerCode)
    If IsdbNull(rs4066!K4066_seLineProd) = False Then D4066.seLineProd = Trim$(rs4066!K4066_seLineProd)
    If IsdbNull(rs4066!K4066_cdLineProd) = False Then D4066.cdLineProd = Trim$(rs4066!K4066_cdLineProd)
    If IsdbNull(rs4066!K4066_MachineCode) = False Then D4066.MachineCode = Trim$(rs4066!K4066_MachineCode)
    If IsdbNull(rs4066!K4066_DatePlan) = False Then D4066.DatePlan = Trim$(rs4066!K4066_DatePlan)
    If IsdbNull(rs4066!K4066_DateFinish) = False Then D4066.DateFinish = Trim$(rs4066!K4066_DateFinish)
    If IsdbNull(rs4066!K4066_Description) = False Then D4066.Description = Trim$(rs4066!K4066_Description)
    If IsdbNull(rs4066!K4066_QtyPlan) = False Then D4066.QtyPlan = Trim$(rs4066!K4066_QtyPlan)
    If IsdbNull(rs4066!K4066_QtyProd) = False Then D4066.QtyProd = Trim$(rs4066!K4066_QtyProd)
    If IsdbNull(rs4066!K4066_InchargePlan) = False Then D4066.InchargePlan = Trim$(rs4066!K4066_InchargePlan)
    If IsdbNull(rs4066!K4066_DateInsert) = False Then D4066.DateInsert = Trim$(rs4066!K4066_DateInsert)
    If IsdbNull(rs4066!K4066_InchargeInsert) = False Then D4066.InchargeInsert = Trim$(rs4066!K4066_InchargeInsert)
    If IsdbNull(rs4066!K4066_DateUpdate) = False Then D4066.DateUpdate = Trim$(rs4066!K4066_DateUpdate)
    If IsdbNull(rs4066!K4066_InchargeUpdate) = False Then D4066.InchargeUpdate = Trim$(rs4066!K4066_InchargeUpdate)
    If IsdbNull(rs4066!K4066_Remark) = False Then D4066.Remark = Trim$(rs4066!K4066_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4066_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K4066_MOVE(rs4066 As DataRow)
Try

    call D4066_CLEAR()   

    If IsdbNull(rs4066!K4066_Autokey) = False Then D4066.Autokey = Trim$(rs4066!K4066_Autokey)
    If IsdbNull(rs4066!K4066_seMainProcess) = False Then D4066.seMainProcess = Trim$(rs4066!K4066_seMainProcess)
    If IsdbNull(rs4066!K4066_cdMainProcess) = False Then D4066.cdMainProcess = Trim$(rs4066!K4066_cdMainProcess)
    If IsdbNull(rs4066!K4066_SealMaster) = False Then D4066.SealMaster = Trim$(rs4066!K4066_SealMaster)
    If IsdbNull(rs4066!K4066_seFactory) = False Then D4066.seFactory = Trim$(rs4066!K4066_seFactory)
    If IsdbNull(rs4066!K4066_cdFactory) = False Then D4066.cdFactory = Trim$(rs4066!K4066_cdFactory)
    If IsdbNull(rs4066!K4066_CustomerCode) = False Then D4066.CustomerCode = Trim$(rs4066!K4066_CustomerCode)
    If IsdbNull(rs4066!K4066_seLineProd) = False Then D4066.seLineProd = Trim$(rs4066!K4066_seLineProd)
    If IsdbNull(rs4066!K4066_cdLineProd) = False Then D4066.cdLineProd = Trim$(rs4066!K4066_cdLineProd)
    If IsdbNull(rs4066!K4066_MachineCode) = False Then D4066.MachineCode = Trim$(rs4066!K4066_MachineCode)
    If IsdbNull(rs4066!K4066_DatePlan) = False Then D4066.DatePlan = Trim$(rs4066!K4066_DatePlan)
    If IsdbNull(rs4066!K4066_DateFinish) = False Then D4066.DateFinish = Trim$(rs4066!K4066_DateFinish)
    If IsdbNull(rs4066!K4066_Description) = False Then D4066.Description = Trim$(rs4066!K4066_Description)
    If IsdbNull(rs4066!K4066_QtyPlan) = False Then D4066.QtyPlan = Trim$(rs4066!K4066_QtyPlan)
    If IsdbNull(rs4066!K4066_QtyProd) = False Then D4066.QtyProd = Trim$(rs4066!K4066_QtyProd)
    If IsdbNull(rs4066!K4066_InchargePlan) = False Then D4066.InchargePlan = Trim$(rs4066!K4066_InchargePlan)
    If IsdbNull(rs4066!K4066_DateInsert) = False Then D4066.DateInsert = Trim$(rs4066!K4066_DateInsert)
    If IsdbNull(rs4066!K4066_InchargeInsert) = False Then D4066.InchargeInsert = Trim$(rs4066!K4066_InchargeInsert)
    If IsdbNull(rs4066!K4066_DateUpdate) = False Then D4066.DateUpdate = Trim$(rs4066!K4066_DateUpdate)
    If IsdbNull(rs4066!K4066_InchargeUpdate) = False Then D4066.InchargeUpdate = Trim$(rs4066!K4066_InchargeUpdate)
    If IsdbNull(rs4066!K4066_Remark) = False Then D4066.Remark = Trim$(rs4066!K4066_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4066_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K4066_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4066 As T4066_AREA, AUTOKEY AS Double) as Boolean

K4066_MOVE = False

Try
    If READ_PFK4066(AUTOKEY) = True Then
                z4066 = D4066
		K4066_MOVE = True
		else
	z4066 = nothing
     End If

     If  getColumIndex(spr,"Autokey") > -1 then z4066.Autokey = getDataM(spr, getColumIndex(spr,"Autokey"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z4066.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z4066.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"SealMaster") > -1 then z4066.SealMaster = getDataM(spr, getColumIndex(spr,"SealMaster"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z4066.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"cdFactory") > -1 then z4066.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z4066.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"seLineProd") > -1 then z4066.seLineProd = getDataM(spr, getColumIndex(spr,"seLineProd"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z4066.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"MachineCode") > -1 then z4066.MachineCode = getDataM(spr, getColumIndex(spr,"MachineCode"), xRow)
     If  getColumIndex(spr,"DatePlan") > -1 then z4066.DatePlan = getDataM(spr, getColumIndex(spr,"DatePlan"), xRow)
     If  getColumIndex(spr,"DateFinish") > -1 then z4066.DateFinish = getDataM(spr, getColumIndex(spr,"DateFinish"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z4066.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"QtyPlan") > -1 then z4066.QtyPlan = getDataM(spr, getColumIndex(spr,"QtyPlan"), xRow)
     If  getColumIndex(spr,"QtyProd") > -1 then z4066.QtyProd = getDataM(spr, getColumIndex(spr,"QtyProd"), xRow)
     If  getColumIndex(spr,"InchargePlan") > -1 then z4066.InchargePlan = getDataM(spr, getColumIndex(spr,"InchargePlan"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z4066.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z4066.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z4066.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z4066.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4066.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4066_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K4066_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4066 As T4066_AREA,CheckClear as Boolean,AUTOKEY AS Double) as Boolean

K4066_MOVE = False

Try
    If READ_PFK4066(AUTOKEY) = True Then
                z4066 = D4066
		K4066_MOVE = True
		else
	If CheckClear  = True then z4066 = nothing
     End If

     If  getColumIndex(spr,"Autokey") > -1 then z4066.Autokey = getDataM(spr, getColumIndex(spr,"Autokey"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z4066.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z4066.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"SealMaster") > -1 then z4066.SealMaster = getDataM(spr, getColumIndex(spr,"SealMaster"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z4066.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"cdFactory") > -1 then z4066.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z4066.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"seLineProd") > -1 then z4066.seLineProd = getDataM(spr, getColumIndex(spr,"seLineProd"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z4066.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"MachineCode") > -1 then z4066.MachineCode = getDataM(spr, getColumIndex(spr,"MachineCode"), xRow)
     If  getColumIndex(spr,"DatePlan") > -1 then z4066.DatePlan = getDataM(spr, getColumIndex(spr,"DatePlan"), xRow)
     If  getColumIndex(spr,"DateFinish") > -1 then z4066.DateFinish = getDataM(spr, getColumIndex(spr,"DateFinish"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z4066.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"QtyPlan") > -1 then z4066.QtyPlan = getDataM(spr, getColumIndex(spr,"QtyPlan"), xRow)
     If  getColumIndex(spr,"QtyProd") > -1 then z4066.QtyProd = getDataM(spr, getColumIndex(spr,"QtyProd"), xRow)
     If  getColumIndex(spr,"InchargePlan") > -1 then z4066.InchargePlan = getDataM(spr, getColumIndex(spr,"InchargePlan"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z4066.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z4066.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z4066.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z4066.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4066.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4066_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K4066_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4066 As T4066_AREA, Job as String, AUTOKEY AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4066_MOVE = False

Try
    If READ_PFK4066(AUTOKEY) = True Then
                z4066 = D4066
		K4066_MOVE = True
		else
	z4066 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4066")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z4066.Autokey = Children(i).Code
   Case "SEMAINPROCESS":z4066.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z4066.cdMainProcess = Children(i).Code
   Case "SEALMASTER":z4066.SealMaster = Children(i).Code
   Case "SEFACTORY":z4066.seFactory = Children(i).Code
   Case "CDFACTORY":z4066.cdFactory = Children(i).Code
   Case "CUSTOMERCODE":z4066.CustomerCode = Children(i).Code
   Case "SELINEPROD":z4066.seLineProd = Children(i).Code
   Case "CDLINEPROD":z4066.cdLineProd = Children(i).Code
   Case "MACHINECODE":z4066.MachineCode = Children(i).Code
   Case "DATEPLAN":z4066.DatePlan = Children(i).Code
   Case "DATEFINISH":z4066.DateFinish = Children(i).Code
   Case "DESCRIPTION":z4066.Description = Children(i).Code
   Case "QTYPLAN":z4066.QtyPlan = Children(i).Code
   Case "QTYPROD":z4066.QtyProd = Children(i).Code
   Case "INCHARGEPLAN":z4066.InchargePlan = Children(i).Code
   Case "DATEINSERT":z4066.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z4066.InchargeInsert = Children(i).Code
   Case "DATEUPDATE":z4066.DateUpdate = Children(i).Code
   Case "INCHARGEUPDATE":z4066.InchargeUpdate = Children(i).Code
   Case "REMARK":z4066.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z4066.Autokey = Children(i).Data
   Case "SEMAINPROCESS":z4066.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z4066.cdMainProcess = Children(i).Data
   Case "SEALMASTER":z4066.SealMaster = Children(i).Data
   Case "SEFACTORY":z4066.seFactory = Children(i).Data
   Case "CDFACTORY":z4066.cdFactory = Children(i).Data
   Case "CUSTOMERCODE":z4066.CustomerCode = Children(i).Data
   Case "SELINEPROD":z4066.seLineProd = Children(i).Data
   Case "CDLINEPROD":z4066.cdLineProd = Children(i).Data
   Case "MACHINECODE":z4066.MachineCode = Children(i).Data
   Case "DATEPLAN":z4066.DatePlan = Children(i).Data
   Case "DATEFINISH":z4066.DateFinish = Children(i).Data
   Case "DESCRIPTION":z4066.Description = Children(i).Data
   Case "QTYPLAN":z4066.QtyPlan = Children(i).Data
   Case "QTYPROD":z4066.QtyProd = Children(i).Data
   Case "INCHARGEPLAN":z4066.InchargePlan = Children(i).Data
   Case "DATEINSERT":z4066.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z4066.InchargeInsert = Children(i).Data
   Case "DATEUPDATE":z4066.DateUpdate = Children(i).Data
   Case "INCHARGEUPDATE":z4066.InchargeUpdate = Children(i).Data
   Case "REMARK":z4066.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4066_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K4066_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4066 As T4066_AREA, Job as String, CheckClear as Boolean, AUTOKEY AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4066_MOVE = False

Try
    If READ_PFK4066(AUTOKEY) = True Then
                z4066 = D4066
		K4066_MOVE = True
		else
	If CheckClear  = True then z4066 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4066")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z4066.Autokey = Children(i).Code
   Case "SEMAINPROCESS":z4066.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z4066.cdMainProcess = Children(i).Code
   Case "SEALMASTER":z4066.SealMaster = Children(i).Code
   Case "SEFACTORY":z4066.seFactory = Children(i).Code
   Case "CDFACTORY":z4066.cdFactory = Children(i).Code
   Case "CUSTOMERCODE":z4066.CustomerCode = Children(i).Code
   Case "SELINEPROD":z4066.seLineProd = Children(i).Code
   Case "CDLINEPROD":z4066.cdLineProd = Children(i).Code
   Case "MACHINECODE":z4066.MachineCode = Children(i).Code
   Case "DATEPLAN":z4066.DatePlan = Children(i).Code
   Case "DATEFINISH":z4066.DateFinish = Children(i).Code
   Case "DESCRIPTION":z4066.Description = Children(i).Code
   Case "QTYPLAN":z4066.QtyPlan = Children(i).Code
   Case "QTYPROD":z4066.QtyProd = Children(i).Code
   Case "INCHARGEPLAN":z4066.InchargePlan = Children(i).Code
   Case "DATEINSERT":z4066.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z4066.InchargeInsert = Children(i).Code
   Case "DATEUPDATE":z4066.DateUpdate = Children(i).Code
   Case "INCHARGEUPDATE":z4066.InchargeUpdate = Children(i).Code
   Case "REMARK":z4066.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z4066.Autokey = Children(i).Data
   Case "SEMAINPROCESS":z4066.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z4066.cdMainProcess = Children(i).Data
   Case "SEALMASTER":z4066.SealMaster = Children(i).Data
   Case "SEFACTORY":z4066.seFactory = Children(i).Data
   Case "CDFACTORY":z4066.cdFactory = Children(i).Data
   Case "CUSTOMERCODE":z4066.CustomerCode = Children(i).Data
   Case "SELINEPROD":z4066.seLineProd = Children(i).Data
   Case "CDLINEPROD":z4066.cdLineProd = Children(i).Data
   Case "MACHINECODE":z4066.MachineCode = Children(i).Data
   Case "DATEPLAN":z4066.DatePlan = Children(i).Data
   Case "DATEFINISH":z4066.DateFinish = Children(i).Data
   Case "DESCRIPTION":z4066.Description = Children(i).Data
   Case "QTYPLAN":z4066.QtyPlan = Children(i).Data
   Case "QTYPROD":z4066.QtyProd = Children(i).Data
   Case "INCHARGEPLAN":z4066.InchargePlan = Children(i).Data
   Case "DATEINSERT":z4066.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z4066.InchargeInsert = Children(i).Data
   Case "DATEUPDATE":z4066.DateUpdate = Children(i).Data
   Case "INCHARGEUPDATE":z4066.InchargeUpdate = Children(i).Data
   Case "REMARK":z4066.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4066_MOVE",vbCritical)
End Try
End Function 
    
End Module 
