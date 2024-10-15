'=========================================================================================================================================================
'   TABLE : (PFK4065)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K4065

Structure T4065_AREA
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

Public D4065 As T4065_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK4065(AUTOKEY AS Double) As Boolean
    READ_PFK4065 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4065 "
    SQL = SQL & " WHERE K4065_Autokey		 =  " & Autokey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D4065_CLEAR: GoTo SKIP_READ_PFK4065
                
    Call K4065_MOVE(rd)
    READ_PFK4065 = True

SKIP_READ_PFK4065:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK4065",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK4065(AUTOKEY AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4065 "
    SQL = SQL & " WHERE K4065_Autokey		 =  " & Autokey & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK4065",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK4065(z4065 As T4065_AREA) As Boolean
    WRITE_PFK4065 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z4065)
 
    SQL = " INSERT INTO PFK4065 "
    SQL = SQL & " ( "
            SQL = SQL & " K4065_seMainProcess,"
    SQL = SQL & " K4065_cdMainProcess," 
    SQL = SQL & " K4065_SealMaster," 
    SQL = SQL & " K4065_seFactory," 
    SQL = SQL & " K4065_cdFactory," 
    SQL = SQL & " K4065_CustomerCode," 
    SQL = SQL & " K4065_seLineProd," 
    SQL = SQL & " K4065_cdLineProd," 
    SQL = SQL & " K4065_MachineCode," 
    SQL = SQL & " K4065_QtyPlan," 
    SQL = SQL & " K4065_QtyProd," 
    SQL = SQL & " K4065_InchargePlan," 
    SQL = SQL & " K4065_DateInsert," 
    SQL = SQL & " K4065_InchargeInsert," 
    SQL = SQL & " K4065_DateUpdate," 
    SQL = SQL & " K4065_InchargeUpdate," 
    SQL = SQL & " K4065_Remark " 
    SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z4065.seMainProcess) & "', "
    SQL = SQL & "  N'" & FormatSQL(z4065.cdMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4065.SealMaster) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4065.seFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4065.cdFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4065.CustomerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4065.seLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4065.cdLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4065.MachineCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z4065.QtyPlan) & ", "  
    SQL = SQL & "   " & FormatSQL(z4065.QtyProd) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4065.InchargePlan) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4065.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4065.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4065.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4065.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4065.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK4065 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK4065",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK4065(z4065 As T4065_AREA) As Boolean
    REWRITE_PFK4065 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z4065)
   
    SQL = " UPDATE PFK4065 SET "
    SQL = SQL & "    K4065_seMainProcess      = N'" & FormatSQL(z4065.seMainProcess) & "', " 
    SQL = SQL & "    K4065_cdMainProcess      = N'" & FormatSQL(z4065.cdMainProcess) & "', " 
    SQL = SQL & "    K4065_SealMaster      = N'" & FormatSQL(z4065.SealMaster) & "', " 
    SQL = SQL & "    K4065_seFactory      = N'" & FormatSQL(z4065.seFactory) & "', " 
    SQL = SQL & "    K4065_cdFactory      = N'" & FormatSQL(z4065.cdFactory) & "', " 
    SQL = SQL & "    K4065_CustomerCode      = N'" & FormatSQL(z4065.CustomerCode) & "', " 
    SQL = SQL & "    K4065_seLineProd      = N'" & FormatSQL(z4065.seLineProd) & "', " 
    SQL = SQL & "    K4065_cdLineProd      = N'" & FormatSQL(z4065.cdLineProd) & "', " 
    SQL = SQL & "    K4065_MachineCode      = N'" & FormatSQL(z4065.MachineCode) & "', " 
    SQL = SQL & "    K4065_QtyPlan      =  " & FormatSQL(z4065.QtyPlan) & ", " 
    SQL = SQL & "    K4065_QtyProd      =  " & FormatSQL(z4065.QtyProd) & ", " 
    SQL = SQL & "    K4065_InchargePlan      = N'" & FormatSQL(z4065.InchargePlan) & "', " 
    SQL = SQL & "    K4065_DateInsert      = N'" & FormatSQL(z4065.DateInsert) & "', " 
    SQL = SQL & "    K4065_InchargeInsert      = N'" & FormatSQL(z4065.InchargeInsert) & "', " 
    SQL = SQL & "    K4065_DateUpdate      = N'" & FormatSQL(z4065.DateUpdate) & "', " 
    SQL = SQL & "    K4065_InchargeUpdate      = N'" & FormatSQL(z4065.InchargeUpdate) & "', " 
    SQL = SQL & "    K4065_Remark      = N'" & FormatSQL(z4065.Remark) & "'  " 
    SQL = SQL & " WHERE K4065_Autokey		 =  " & z4065.Autokey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK4065 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK4065",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK4065(z4065 As T4065_AREA) As Boolean
    DELETE_PFK4065 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK4065 "
    SQL = SQL & " WHERE K4065_Autokey		 =  " & z4065.Autokey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK4065 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK4065",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D4065_CLEAR()
Try
    
    D4065.Autokey = 0 
   D4065.seMainProcess = ""
   D4065.cdMainProcess = ""
   D4065.SealMaster = ""
   D4065.seFactory = ""
   D4065.cdFactory = ""
   D4065.CustomerCode = ""
   D4065.seLineProd = ""
   D4065.cdLineProd = ""
   D4065.MachineCode = ""
    D4065.QtyPlan = 0 
    D4065.QtyProd = 0 
   D4065.InchargePlan = ""
   D4065.DateInsert = ""
   D4065.InchargeInsert = ""
   D4065.DateUpdate = ""
   D4065.InchargeUpdate = ""
   D4065.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D4065_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x4065 As T4065_AREA)
Try
    
    x4065.Autokey = trim$(  x4065.Autokey)
    x4065.seMainProcess = trim$(  x4065.seMainProcess)
    x4065.cdMainProcess = trim$(  x4065.cdMainProcess)
    x4065.SealMaster = trim$(  x4065.SealMaster)
    x4065.seFactory = trim$(  x4065.seFactory)
    x4065.cdFactory = trim$(  x4065.cdFactory)
    x4065.CustomerCode = trim$(  x4065.CustomerCode)
    x4065.seLineProd = trim$(  x4065.seLineProd)
    x4065.cdLineProd = trim$(  x4065.cdLineProd)
    x4065.MachineCode = trim$(  x4065.MachineCode)
    x4065.QtyPlan = trim$(  x4065.QtyPlan)
    x4065.QtyProd = trim$(  x4065.QtyProd)
    x4065.InchargePlan = trim$(  x4065.InchargePlan)
    x4065.DateInsert = trim$(  x4065.DateInsert)
    x4065.InchargeInsert = trim$(  x4065.InchargeInsert)
    x4065.DateUpdate = trim$(  x4065.DateUpdate)
    x4065.InchargeUpdate = trim$(  x4065.InchargeUpdate)
    x4065.Remark = trim$(  x4065.Remark)
     
    If trim$( x4065.Autokey ) = "" Then x4065.Autokey = 0 
    If trim$( x4065.seMainProcess ) = "" Then x4065.seMainProcess = Space(1) 
    If trim$( x4065.cdMainProcess ) = "" Then x4065.cdMainProcess = Space(1) 
    If trim$( x4065.SealMaster ) = "" Then x4065.SealMaster = Space(1) 
    If trim$( x4065.seFactory ) = "" Then x4065.seFactory = Space(1) 
    If trim$( x4065.cdFactory ) = "" Then x4065.cdFactory = Space(1) 
    If trim$( x4065.CustomerCode ) = "" Then x4065.CustomerCode = Space(1) 
    If trim$( x4065.seLineProd ) = "" Then x4065.seLineProd = Space(1) 
    If trim$( x4065.cdLineProd ) = "" Then x4065.cdLineProd = Space(1) 
    If trim$( x4065.MachineCode ) = "" Then x4065.MachineCode = Space(1) 
    If trim$( x4065.QtyPlan ) = "" Then x4065.QtyPlan = 0 
    If trim$( x4065.QtyProd ) = "" Then x4065.QtyProd = 0 
    If trim$( x4065.InchargePlan ) = "" Then x4065.InchargePlan = Space(1) 
    If trim$( x4065.DateInsert ) = "" Then x4065.DateInsert = Space(1) 
    If trim$( x4065.InchargeInsert ) = "" Then x4065.InchargeInsert = Space(1) 
    If trim$( x4065.DateUpdate ) = "" Then x4065.DateUpdate = Space(1) 
    If trim$( x4065.InchargeUpdate ) = "" Then x4065.InchargeUpdate = Space(1) 
    If trim$( x4065.Remark ) = "" Then x4065.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K4065_MOVE(rs4065 As SqlClient.SqlDataReader)
Try

    call D4065_CLEAR()   

    If IsdbNull(rs4065!K4065_Autokey) = False Then D4065.Autokey = Trim$(rs4065!K4065_Autokey)
    If IsdbNull(rs4065!K4065_seMainProcess) = False Then D4065.seMainProcess = Trim$(rs4065!K4065_seMainProcess)
    If IsdbNull(rs4065!K4065_cdMainProcess) = False Then D4065.cdMainProcess = Trim$(rs4065!K4065_cdMainProcess)
    If IsdbNull(rs4065!K4065_SealMaster) = False Then D4065.SealMaster = Trim$(rs4065!K4065_SealMaster)
    If IsdbNull(rs4065!K4065_seFactory) = False Then D4065.seFactory = Trim$(rs4065!K4065_seFactory)
    If IsdbNull(rs4065!K4065_cdFactory) = False Then D4065.cdFactory = Trim$(rs4065!K4065_cdFactory)
    If IsdbNull(rs4065!K4065_CustomerCode) = False Then D4065.CustomerCode = Trim$(rs4065!K4065_CustomerCode)
    If IsdbNull(rs4065!K4065_seLineProd) = False Then D4065.seLineProd = Trim$(rs4065!K4065_seLineProd)
    If IsdbNull(rs4065!K4065_cdLineProd) = False Then D4065.cdLineProd = Trim$(rs4065!K4065_cdLineProd)
    If IsdbNull(rs4065!K4065_MachineCode) = False Then D4065.MachineCode = Trim$(rs4065!K4065_MachineCode)
    If IsdbNull(rs4065!K4065_QtyPlan) = False Then D4065.QtyPlan = Trim$(rs4065!K4065_QtyPlan)
    If IsdbNull(rs4065!K4065_QtyProd) = False Then D4065.QtyProd = Trim$(rs4065!K4065_QtyProd)
    If IsdbNull(rs4065!K4065_InchargePlan) = False Then D4065.InchargePlan = Trim$(rs4065!K4065_InchargePlan)
    If IsdbNull(rs4065!K4065_DateInsert) = False Then D4065.DateInsert = Trim$(rs4065!K4065_DateInsert)
    If IsdbNull(rs4065!K4065_InchargeInsert) = False Then D4065.InchargeInsert = Trim$(rs4065!K4065_InchargeInsert)
    If IsdbNull(rs4065!K4065_DateUpdate) = False Then D4065.DateUpdate = Trim$(rs4065!K4065_DateUpdate)
    If IsdbNull(rs4065!K4065_InchargeUpdate) = False Then D4065.InchargeUpdate = Trim$(rs4065!K4065_InchargeUpdate)
    If IsdbNull(rs4065!K4065_Remark) = False Then D4065.Remark = Trim$(rs4065!K4065_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4065_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K4065_MOVE(rs4065 As DataRow)
Try

    call D4065_CLEAR()   

    If IsdbNull(rs4065!K4065_Autokey) = False Then D4065.Autokey = Trim$(rs4065!K4065_Autokey)
    If IsdbNull(rs4065!K4065_seMainProcess) = False Then D4065.seMainProcess = Trim$(rs4065!K4065_seMainProcess)
    If IsdbNull(rs4065!K4065_cdMainProcess) = False Then D4065.cdMainProcess = Trim$(rs4065!K4065_cdMainProcess)
    If IsdbNull(rs4065!K4065_SealMaster) = False Then D4065.SealMaster = Trim$(rs4065!K4065_SealMaster)
    If IsdbNull(rs4065!K4065_seFactory) = False Then D4065.seFactory = Trim$(rs4065!K4065_seFactory)
    If IsdbNull(rs4065!K4065_cdFactory) = False Then D4065.cdFactory = Trim$(rs4065!K4065_cdFactory)
    If IsdbNull(rs4065!K4065_CustomerCode) = False Then D4065.CustomerCode = Trim$(rs4065!K4065_CustomerCode)
    If IsdbNull(rs4065!K4065_seLineProd) = False Then D4065.seLineProd = Trim$(rs4065!K4065_seLineProd)
    If IsdbNull(rs4065!K4065_cdLineProd) = False Then D4065.cdLineProd = Trim$(rs4065!K4065_cdLineProd)
    If IsdbNull(rs4065!K4065_MachineCode) = False Then D4065.MachineCode = Trim$(rs4065!K4065_MachineCode)
    If IsdbNull(rs4065!K4065_QtyPlan) = False Then D4065.QtyPlan = Trim$(rs4065!K4065_QtyPlan)
    If IsdbNull(rs4065!K4065_QtyProd) = False Then D4065.QtyProd = Trim$(rs4065!K4065_QtyProd)
    If IsdbNull(rs4065!K4065_InchargePlan) = False Then D4065.InchargePlan = Trim$(rs4065!K4065_InchargePlan)
    If IsdbNull(rs4065!K4065_DateInsert) = False Then D4065.DateInsert = Trim$(rs4065!K4065_DateInsert)
    If IsdbNull(rs4065!K4065_InchargeInsert) = False Then D4065.InchargeInsert = Trim$(rs4065!K4065_InchargeInsert)
    If IsdbNull(rs4065!K4065_DateUpdate) = False Then D4065.DateUpdate = Trim$(rs4065!K4065_DateUpdate)
    If IsdbNull(rs4065!K4065_InchargeUpdate) = False Then D4065.InchargeUpdate = Trim$(rs4065!K4065_InchargeUpdate)
    If IsdbNull(rs4065!K4065_Remark) = False Then D4065.Remark = Trim$(rs4065!K4065_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4065_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K4065_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4065 As T4065_AREA, AUTOKEY AS Double) as Boolean

K4065_MOVE = False

Try
    If READ_PFK4065(AUTOKEY) = True Then
                z4065 = D4065
		K4065_MOVE = True
		else
	z4065 = nothing
     End If

     If  getColumIndex(spr,"Autokey") > -1 then z4065.Autokey = getDataM(spr, getColumIndex(spr,"Autokey"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z4065.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z4065.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"SealMaster") > -1 then z4065.SealMaster = getDataM(spr, getColumIndex(spr,"SealMaster"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z4065.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"cdFactory") > -1 then z4065.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z4065.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"seLineProd") > -1 then z4065.seLineProd = getDataM(spr, getColumIndex(spr,"seLineProd"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z4065.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"MachineCode") > -1 then z4065.MachineCode = getDataM(spr, getColumIndex(spr,"MachineCode"), xRow)
     If  getColumIndex(spr,"QtyPlan") > -1 then z4065.QtyPlan = getDataM(spr, getColumIndex(spr,"QtyPlan"), xRow)
     If  getColumIndex(spr,"QtyProd") > -1 then z4065.QtyProd = getDataM(spr, getColumIndex(spr,"QtyProd"), xRow)
     If  getColumIndex(spr,"InchargePlan") > -1 then z4065.InchargePlan = getDataM(spr, getColumIndex(spr,"InchargePlan"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z4065.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z4065.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z4065.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z4065.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4065.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4065_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K4065_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4065 As T4065_AREA,CheckClear as Boolean,AUTOKEY AS Double) as Boolean

K4065_MOVE = False

Try
    If READ_PFK4065(AUTOKEY) = True Then
                z4065 = D4065
		K4065_MOVE = True
		else
	If CheckClear  = True then z4065 = nothing
     End If

     If  getColumIndex(spr,"Autokey") > -1 then z4065.Autokey = getDataM(spr, getColumIndex(spr,"Autokey"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z4065.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z4065.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"SealMaster") > -1 then z4065.SealMaster = getDataM(spr, getColumIndex(spr,"SealMaster"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z4065.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"cdFactory") > -1 then z4065.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z4065.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"seLineProd") > -1 then z4065.seLineProd = getDataM(spr, getColumIndex(spr,"seLineProd"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z4065.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"MachineCode") > -1 then z4065.MachineCode = getDataM(spr, getColumIndex(spr,"MachineCode"), xRow)
     If  getColumIndex(spr,"QtyPlan") > -1 then z4065.QtyPlan = getDataM(spr, getColumIndex(spr,"QtyPlan"), xRow)
     If  getColumIndex(spr,"QtyProd") > -1 then z4065.QtyProd = getDataM(spr, getColumIndex(spr,"QtyProd"), xRow)
     If  getColumIndex(spr,"InchargePlan") > -1 then z4065.InchargePlan = getDataM(spr, getColumIndex(spr,"InchargePlan"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z4065.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z4065.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z4065.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z4065.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4065.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4065_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K4065_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4065 As T4065_AREA, Job as String, AUTOKEY AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4065_MOVE = False

Try
    If READ_PFK4065(AUTOKEY) = True Then
                z4065 = D4065
		K4065_MOVE = True
		else
	z4065 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4065")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z4065.Autokey = Children(i).Code
   Case "SEMAINPROCESS":z4065.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z4065.cdMainProcess = Children(i).Code
   Case "SEALMASTER":z4065.SealMaster = Children(i).Code
   Case "SEFACTORY":z4065.seFactory = Children(i).Code
   Case "CDFACTORY":z4065.cdFactory = Children(i).Code
   Case "CUSTOMERCODE":z4065.CustomerCode = Children(i).Code
   Case "SELINEPROD":z4065.seLineProd = Children(i).Code
   Case "CDLINEPROD":z4065.cdLineProd = Children(i).Code
   Case "MACHINECODE":z4065.MachineCode = Children(i).Code
   Case "QTYPLAN":z4065.QtyPlan = Children(i).Code
   Case "QTYPROD":z4065.QtyProd = Children(i).Code
   Case "INCHARGEPLAN":z4065.InchargePlan = Children(i).Code
   Case "DATEINSERT":z4065.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z4065.InchargeInsert = Children(i).Code
   Case "DATEUPDATE":z4065.DateUpdate = Children(i).Code
   Case "INCHARGEUPDATE":z4065.InchargeUpdate = Children(i).Code
   Case "REMARK":z4065.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z4065.Autokey = Children(i).Data
   Case "SEMAINPROCESS":z4065.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z4065.cdMainProcess = Children(i).Data
   Case "SEALMASTER":z4065.SealMaster = Children(i).Data
   Case "SEFACTORY":z4065.seFactory = Children(i).Data
   Case "CDFACTORY":z4065.cdFactory = Children(i).Data
   Case "CUSTOMERCODE":z4065.CustomerCode = Children(i).Data
   Case "SELINEPROD":z4065.seLineProd = Children(i).Data
   Case "CDLINEPROD":z4065.cdLineProd = Children(i).Data
   Case "MACHINECODE":z4065.MachineCode = Children(i).Data
   Case "QTYPLAN":z4065.QtyPlan = Children(i).Data
   Case "QTYPROD":z4065.QtyProd = Children(i).Data
   Case "INCHARGEPLAN":z4065.InchargePlan = Children(i).Data
   Case "DATEINSERT":z4065.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z4065.InchargeInsert = Children(i).Data
   Case "DATEUPDATE":z4065.DateUpdate = Children(i).Data
   Case "INCHARGEUPDATE":z4065.InchargeUpdate = Children(i).Data
   Case "REMARK":z4065.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4065_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K4065_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4065 As T4065_AREA, Job as String, CheckClear as Boolean, AUTOKEY AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4065_MOVE = False

Try
    If READ_PFK4065(AUTOKEY) = True Then
                z4065 = D4065
		K4065_MOVE = True
		else
	If CheckClear  = True then z4065 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4065")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z4065.Autokey = Children(i).Code
   Case "SEMAINPROCESS":z4065.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z4065.cdMainProcess = Children(i).Code
   Case "SEALMASTER":z4065.SealMaster = Children(i).Code
   Case "SEFACTORY":z4065.seFactory = Children(i).Code
   Case "CDFACTORY":z4065.cdFactory = Children(i).Code
   Case "CUSTOMERCODE":z4065.CustomerCode = Children(i).Code
   Case "SELINEPROD":z4065.seLineProd = Children(i).Code
   Case "CDLINEPROD":z4065.cdLineProd = Children(i).Code
   Case "MACHINECODE":z4065.MachineCode = Children(i).Code
   Case "QTYPLAN":z4065.QtyPlan = Children(i).Code
   Case "QTYPROD":z4065.QtyProd = Children(i).Code
   Case "INCHARGEPLAN":z4065.InchargePlan = Children(i).Code
   Case "DATEINSERT":z4065.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z4065.InchargeInsert = Children(i).Code
   Case "DATEUPDATE":z4065.DateUpdate = Children(i).Code
   Case "INCHARGEUPDATE":z4065.InchargeUpdate = Children(i).Code
   Case "REMARK":z4065.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z4065.Autokey = Children(i).Data
   Case "SEMAINPROCESS":z4065.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z4065.cdMainProcess = Children(i).Data
   Case "SEALMASTER":z4065.SealMaster = Children(i).Data
   Case "SEFACTORY":z4065.seFactory = Children(i).Data
   Case "CDFACTORY":z4065.cdFactory = Children(i).Data
   Case "CUSTOMERCODE":z4065.CustomerCode = Children(i).Data
   Case "SELINEPROD":z4065.seLineProd = Children(i).Data
   Case "CDLINEPROD":z4065.cdLineProd = Children(i).Data
   Case "MACHINECODE":z4065.MachineCode = Children(i).Data
   Case "QTYPLAN":z4065.QtyPlan = Children(i).Data
   Case "QTYPROD":z4065.QtyProd = Children(i).Data
   Case "INCHARGEPLAN":z4065.InchargePlan = Children(i).Data
   Case "DATEINSERT":z4065.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z4065.InchargeInsert = Children(i).Data
   Case "DATEUPDATE":z4065.DateUpdate = Children(i).Data
   Case "INCHARGEUPDATE":z4065.InchargeUpdate = Children(i).Data
   Case "REMARK":z4065.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4065_MOVE",vbCritical)
End Try
End Function 
    
End Module 
