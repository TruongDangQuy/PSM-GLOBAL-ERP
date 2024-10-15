'=========================================================================================================================================================
'   TABLE : (PFK2368)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K2368

Structure T2368_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	Autokey	 AS Double	'			decimal		*
Public 	JobCardWorking	 AS String	'			char(9)
Public 	DateOutBoundMaterial	 AS String	'			char(8)
Public 	SeqOutBoundMaterial	 AS String	'			char(3)
Public 	SnoOutBoundMaterial	 AS Double	'			decimal
Public 	MaterialInBoundNo	 AS String	'			char(9)
Public 	MaterialInBoundSeq	 AS String	'			char(3)
Public 	MaterialInBoundSno	 AS Double	'			decimal
Public 	FactOrderNo	 AS String	'			char(9)
Public 	FactOrderSeq	 AS Double	'			decimal
Public 	cdDepartment	 AS String	'			char(3)
Public 	cdLineProd	 AS String	'			char(3)
Public 	cdSubProcess	 AS String	'			char(3)
Public 	InchargeReceipt	 AS String	'			char(8)
Public 	TimeReceipt	 AS String	'			nvarchar(20)
Public 	DateRecept	 AS String	'			char(8)
Public 	QtyOutbound	 AS Double	'			decimal
Public 	QtyReceipt	 AS Double	'			decimal
Public 	QtyProduction	 AS Double	'			decimal
Public 	Remark	 AS String	'			nvarchar(250)
'=========================================================================================================================================================
End structure

Public D2368 As T2368_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK2368(AUTOKEY AS Double) As Boolean
    READ_PFK2368 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK2368 "
    SQL = SQL & " WHERE K2368_Autokey		 =  " & Autokey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D2368_CLEAR: GoTo SKIP_READ_PFK2368
                
    Call K2368_MOVE(rd)
    READ_PFK2368 = True

SKIP_READ_PFK2368:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK2368",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK2368(AUTOKEY AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK2368 "
    SQL = SQL & " WHERE K2368_Autokey		 =  " & Autokey & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK2368",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK2368(z2368 As T2368_AREA) As Boolean
    WRITE_PFK2368 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z2368)
 
    SQL = " INSERT INTO PFK2368 "
    SQL = SQL & " ( "
    SQL = SQL & " K2368_Autokey," 
    SQL = SQL & " K2368_JobCardWorking," 
    SQL = SQL & " K2368_DateOutBoundMaterial," 
    SQL = SQL & " K2368_SeqOutBoundMaterial," 
    SQL = SQL & " K2368_SnoOutBoundMaterial," 
    SQL = SQL & " K2368_MaterialInBoundNo," 
    SQL = SQL & " K2368_MaterialInBoundSeq," 
    SQL = SQL & " K2368_MaterialInBoundSno," 
    SQL = SQL & " K2368_FactOrderNo," 
    SQL = SQL & " K2368_FactOrderSeq," 
    SQL = SQL & " K2368_cdDepartment," 
    SQL = SQL & " K2368_cdLineProd," 
    SQL = SQL & " K2368_cdSubProcess," 
    SQL = SQL & " K2368_InchargeReceipt," 
    SQL = SQL & " K2368_TimeReceipt," 
    SQL = SQL & " K2368_DateRecept," 
    SQL = SQL & " K2368_QtyOutbound," 
    SQL = SQL & " K2368_QtyReceipt," 
    SQL = SQL & " K2368_QtyProduction," 
    SQL = SQL & " K2368_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "   " & FormatSQL(z2368.Autokey) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z2368.JobCardWorking) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2368.DateOutBoundMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2368.SeqOutBoundMaterial) & "', "  
    SQL = SQL & "   " & FormatSQL(z2368.SnoOutBoundMaterial) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z2368.MaterialInBoundNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2368.MaterialInBoundSeq) & "', "  
    SQL = SQL & "   " & FormatSQL(z2368.MaterialInBoundSno) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z2368.FactOrderNo) & "', "  
    SQL = SQL & "   " & FormatSQL(z2368.FactOrderSeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z2368.cdDepartment) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2368.cdLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2368.cdSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2368.InchargeReceipt) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2368.TimeReceipt) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2368.DateRecept) & "', "  
    SQL = SQL & "   " & FormatSQL(z2368.QtyOutbound) & ", "  
    SQL = SQL & "   " & FormatSQL(z2368.QtyReceipt) & ", "  
    SQL = SQL & "   " & FormatSQL(z2368.QtyProduction) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z2368.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK2368 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK2368",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK2368(z2368 As T2368_AREA) As Boolean
    REWRITE_PFK2368 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z2368)
   
    SQL = " UPDATE PFK2368 SET "
    SQL = SQL & "    K2368_JobCardWorking      = N'" & FormatSQL(z2368.JobCardWorking) & "', " 
    SQL = SQL & "    K2368_DateOutBoundMaterial      = N'" & FormatSQL(z2368.DateOutBoundMaterial) & "', " 
    SQL = SQL & "    K2368_SeqOutBoundMaterial      = N'" & FormatSQL(z2368.SeqOutBoundMaterial) & "', " 
    SQL = SQL & "    K2368_SnoOutBoundMaterial      =  " & FormatSQL(z2368.SnoOutBoundMaterial) & ", " 
    SQL = SQL & "    K2368_MaterialInBoundNo      = N'" & FormatSQL(z2368.MaterialInBoundNo) & "', " 
    SQL = SQL & "    K2368_MaterialInBoundSeq      = N'" & FormatSQL(z2368.MaterialInBoundSeq) & "', " 
    SQL = SQL & "    K2368_MaterialInBoundSno      =  " & FormatSQL(z2368.MaterialInBoundSno) & ", " 
    SQL = SQL & "    K2368_FactOrderNo      = N'" & FormatSQL(z2368.FactOrderNo) & "', " 
    SQL = SQL & "    K2368_FactOrderSeq      =  " & FormatSQL(z2368.FactOrderSeq) & ", " 
    SQL = SQL & "    K2368_cdDepartment      = N'" & FormatSQL(z2368.cdDepartment) & "', " 
    SQL = SQL & "    K2368_cdLineProd      = N'" & FormatSQL(z2368.cdLineProd) & "', " 
    SQL = SQL & "    K2368_cdSubProcess      = N'" & FormatSQL(z2368.cdSubProcess) & "', " 
    SQL = SQL & "    K2368_InchargeReceipt      = N'" & FormatSQL(z2368.InchargeReceipt) & "', " 
    SQL = SQL & "    K2368_TimeReceipt      = N'" & FormatSQL(z2368.TimeReceipt) & "', " 
    SQL = SQL & "    K2368_DateRecept      = N'" & FormatSQL(z2368.DateRecept) & "', " 
    SQL = SQL & "    K2368_QtyOutbound      =  " & FormatSQL(z2368.QtyOutbound) & ", " 
    SQL = SQL & "    K2368_QtyReceipt      =  " & FormatSQL(z2368.QtyReceipt) & ", " 
    SQL = SQL & "    K2368_QtyProduction      =  " & FormatSQL(z2368.QtyProduction) & ", " 
    SQL = SQL & "    K2368_Remark      = N'" & FormatSQL(z2368.Remark) & "'  " 
    SQL = SQL & " WHERE K2368_Autokey		 =  " & z2368.Autokey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK2368 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK2368",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK2368(z2368 As T2368_AREA) As Boolean
    DELETE_PFK2368 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK2368 "
    SQL = SQL & " WHERE K2368_Autokey		 =  " & z2368.Autokey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK2368 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK2368",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D2368_CLEAR()
Try
    
    D2368.Autokey = 0 
   D2368.JobCardWorking = ""
   D2368.DateOutBoundMaterial = ""
   D2368.SeqOutBoundMaterial = ""
    D2368.SnoOutBoundMaterial = 0 
   D2368.MaterialInBoundNo = ""
   D2368.MaterialInBoundSeq = ""
    D2368.MaterialInBoundSno = 0 
   D2368.FactOrderNo = ""
    D2368.FactOrderSeq = 0 
   D2368.cdDepartment = ""
   D2368.cdLineProd = ""
   D2368.cdSubProcess = ""
   D2368.InchargeReceipt = ""
   D2368.TimeReceipt = ""
   D2368.DateRecept = ""
    D2368.QtyOutbound = 0 
    D2368.QtyReceipt = 0 
    D2368.QtyProduction = 0 
   D2368.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D2368_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x2368 As T2368_AREA)
Try
    
    x2368.Autokey = trim$(  x2368.Autokey)
    x2368.JobCardWorking = trim$(  x2368.JobCardWorking)
    x2368.DateOutBoundMaterial = trim$(  x2368.DateOutBoundMaterial)
    x2368.SeqOutBoundMaterial = trim$(  x2368.SeqOutBoundMaterial)
    x2368.SnoOutBoundMaterial = trim$(  x2368.SnoOutBoundMaterial)
    x2368.MaterialInBoundNo = trim$(  x2368.MaterialInBoundNo)
    x2368.MaterialInBoundSeq = trim$(  x2368.MaterialInBoundSeq)
    x2368.MaterialInBoundSno = trim$(  x2368.MaterialInBoundSno)
    x2368.FactOrderNo = trim$(  x2368.FactOrderNo)
    x2368.FactOrderSeq = trim$(  x2368.FactOrderSeq)
    x2368.cdDepartment = trim$(  x2368.cdDepartment)
    x2368.cdLineProd = trim$(  x2368.cdLineProd)
    x2368.cdSubProcess = trim$(  x2368.cdSubProcess)
    x2368.InchargeReceipt = trim$(  x2368.InchargeReceipt)
    x2368.TimeReceipt = trim$(  x2368.TimeReceipt)
    x2368.DateRecept = trim$(  x2368.DateRecept)
    x2368.QtyOutbound = trim$(  x2368.QtyOutbound)
    x2368.QtyReceipt = trim$(  x2368.QtyReceipt)
    x2368.QtyProduction = trim$(  x2368.QtyProduction)
    x2368.Remark = trim$(  x2368.Remark)
     
    If trim$( x2368.Autokey ) = "" Then x2368.Autokey = 0 
    If trim$( x2368.JobCardWorking ) = "" Then x2368.JobCardWorking = Space(1) 
    If trim$( x2368.DateOutBoundMaterial ) = "" Then x2368.DateOutBoundMaterial = Space(1) 
    If trim$( x2368.SeqOutBoundMaterial ) = "" Then x2368.SeqOutBoundMaterial = Space(1) 
    If trim$( x2368.SnoOutBoundMaterial ) = "" Then x2368.SnoOutBoundMaterial = 0 
    If trim$( x2368.MaterialInBoundNo ) = "" Then x2368.MaterialInBoundNo = Space(1) 
    If trim$( x2368.MaterialInBoundSeq ) = "" Then x2368.MaterialInBoundSeq = Space(1) 
    If trim$( x2368.MaterialInBoundSno ) = "" Then x2368.MaterialInBoundSno = 0 
    If trim$( x2368.FactOrderNo ) = "" Then x2368.FactOrderNo = Space(1) 
    If trim$( x2368.FactOrderSeq ) = "" Then x2368.FactOrderSeq = 0 
    If trim$( x2368.cdDepartment ) = "" Then x2368.cdDepartment = Space(1) 
    If trim$( x2368.cdLineProd ) = "" Then x2368.cdLineProd = Space(1) 
    If trim$( x2368.cdSubProcess ) = "" Then x2368.cdSubProcess = Space(1) 
    If trim$( x2368.InchargeReceipt ) = "" Then x2368.InchargeReceipt = Space(1) 
    If trim$( x2368.TimeReceipt ) = "" Then x2368.TimeReceipt = Space(1) 
    If trim$( x2368.DateRecept ) = "" Then x2368.DateRecept = Space(1) 
    If trim$( x2368.QtyOutbound ) = "" Then x2368.QtyOutbound = 0 
    If trim$( x2368.QtyReceipt ) = "" Then x2368.QtyReceipt = 0 
    If trim$( x2368.QtyProduction ) = "" Then x2368.QtyProduction = 0 
    If trim$( x2368.Remark ) = "" Then x2368.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K2368_MOVE(rs2368 As SqlClient.SqlDataReader)
Try

    call D2368_CLEAR()   

    If IsdbNull(rs2368!K2368_Autokey) = False Then D2368.Autokey = Trim$(rs2368!K2368_Autokey)
    If IsdbNull(rs2368!K2368_JobCardWorking) = False Then D2368.JobCardWorking = Trim$(rs2368!K2368_JobCardWorking)
    If IsdbNull(rs2368!K2368_DateOutBoundMaterial) = False Then D2368.DateOutBoundMaterial = Trim$(rs2368!K2368_DateOutBoundMaterial)
    If IsdbNull(rs2368!K2368_SeqOutBoundMaterial) = False Then D2368.SeqOutBoundMaterial = Trim$(rs2368!K2368_SeqOutBoundMaterial)
    If IsdbNull(rs2368!K2368_SnoOutBoundMaterial) = False Then D2368.SnoOutBoundMaterial = Trim$(rs2368!K2368_SnoOutBoundMaterial)
    If IsdbNull(rs2368!K2368_MaterialInBoundNo) = False Then D2368.MaterialInBoundNo = Trim$(rs2368!K2368_MaterialInBoundNo)
    If IsdbNull(rs2368!K2368_MaterialInBoundSeq) = False Then D2368.MaterialInBoundSeq = Trim$(rs2368!K2368_MaterialInBoundSeq)
    If IsdbNull(rs2368!K2368_MaterialInBoundSno) = False Then D2368.MaterialInBoundSno = Trim$(rs2368!K2368_MaterialInBoundSno)
    If IsdbNull(rs2368!K2368_FactOrderNo) = False Then D2368.FactOrderNo = Trim$(rs2368!K2368_FactOrderNo)
    If IsdbNull(rs2368!K2368_FactOrderSeq) = False Then D2368.FactOrderSeq = Trim$(rs2368!K2368_FactOrderSeq)
    If IsdbNull(rs2368!K2368_cdDepartment) = False Then D2368.cdDepartment = Trim$(rs2368!K2368_cdDepartment)
    If IsdbNull(rs2368!K2368_cdLineProd) = False Then D2368.cdLineProd = Trim$(rs2368!K2368_cdLineProd)
    If IsdbNull(rs2368!K2368_cdSubProcess) = False Then D2368.cdSubProcess = Trim$(rs2368!K2368_cdSubProcess)
    If IsdbNull(rs2368!K2368_InchargeReceipt) = False Then D2368.InchargeReceipt = Trim$(rs2368!K2368_InchargeReceipt)
    If IsdbNull(rs2368!K2368_TimeReceipt) = False Then D2368.TimeReceipt = Trim$(rs2368!K2368_TimeReceipt)
    If IsdbNull(rs2368!K2368_DateRecept) = False Then D2368.DateRecept = Trim$(rs2368!K2368_DateRecept)
    If IsdbNull(rs2368!K2368_QtyOutbound) = False Then D2368.QtyOutbound = Trim$(rs2368!K2368_QtyOutbound)
    If IsdbNull(rs2368!K2368_QtyReceipt) = False Then D2368.QtyReceipt = Trim$(rs2368!K2368_QtyReceipt)
    If IsdbNull(rs2368!K2368_QtyProduction) = False Then D2368.QtyProduction = Trim$(rs2368!K2368_QtyProduction)
    If IsdbNull(rs2368!K2368_Remark) = False Then D2368.Remark = Trim$(rs2368!K2368_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K2368_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K2368_MOVE(rs2368 As DataRow)
Try

    call D2368_CLEAR()   

    If IsdbNull(rs2368!K2368_Autokey) = False Then D2368.Autokey = Trim$(rs2368!K2368_Autokey)
    If IsdbNull(rs2368!K2368_JobCardWorking) = False Then D2368.JobCardWorking = Trim$(rs2368!K2368_JobCardWorking)
    If IsdbNull(rs2368!K2368_DateOutBoundMaterial) = False Then D2368.DateOutBoundMaterial = Trim$(rs2368!K2368_DateOutBoundMaterial)
    If IsdbNull(rs2368!K2368_SeqOutBoundMaterial) = False Then D2368.SeqOutBoundMaterial = Trim$(rs2368!K2368_SeqOutBoundMaterial)
    If IsdbNull(rs2368!K2368_SnoOutBoundMaterial) = False Then D2368.SnoOutBoundMaterial = Trim$(rs2368!K2368_SnoOutBoundMaterial)
    If IsdbNull(rs2368!K2368_MaterialInBoundNo) = False Then D2368.MaterialInBoundNo = Trim$(rs2368!K2368_MaterialInBoundNo)
    If IsdbNull(rs2368!K2368_MaterialInBoundSeq) = False Then D2368.MaterialInBoundSeq = Trim$(rs2368!K2368_MaterialInBoundSeq)
    If IsdbNull(rs2368!K2368_MaterialInBoundSno) = False Then D2368.MaterialInBoundSno = Trim$(rs2368!K2368_MaterialInBoundSno)
    If IsdbNull(rs2368!K2368_FactOrderNo) = False Then D2368.FactOrderNo = Trim$(rs2368!K2368_FactOrderNo)
    If IsdbNull(rs2368!K2368_FactOrderSeq) = False Then D2368.FactOrderSeq = Trim$(rs2368!K2368_FactOrderSeq)
    If IsdbNull(rs2368!K2368_cdDepartment) = False Then D2368.cdDepartment = Trim$(rs2368!K2368_cdDepartment)
    If IsdbNull(rs2368!K2368_cdLineProd) = False Then D2368.cdLineProd = Trim$(rs2368!K2368_cdLineProd)
    If IsdbNull(rs2368!K2368_cdSubProcess) = False Then D2368.cdSubProcess = Trim$(rs2368!K2368_cdSubProcess)
    If IsdbNull(rs2368!K2368_InchargeReceipt) = False Then D2368.InchargeReceipt = Trim$(rs2368!K2368_InchargeReceipt)
    If IsdbNull(rs2368!K2368_TimeReceipt) = False Then D2368.TimeReceipt = Trim$(rs2368!K2368_TimeReceipt)
    If IsdbNull(rs2368!K2368_DateRecept) = False Then D2368.DateRecept = Trim$(rs2368!K2368_DateRecept)
    If IsdbNull(rs2368!K2368_QtyOutbound) = False Then D2368.QtyOutbound = Trim$(rs2368!K2368_QtyOutbound)
    If IsdbNull(rs2368!K2368_QtyReceipt) = False Then D2368.QtyReceipt = Trim$(rs2368!K2368_QtyReceipt)
    If IsdbNull(rs2368!K2368_QtyProduction) = False Then D2368.QtyProduction = Trim$(rs2368!K2368_QtyProduction)
    If IsdbNull(rs2368!K2368_Remark) = False Then D2368.Remark = Trim$(rs2368!K2368_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K2368_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K2368_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z2368 As T2368_AREA, AUTOKEY AS Double) as Boolean

K2368_MOVE = False

Try
    If READ_PFK2368(AUTOKEY) = True Then
                z2368 = D2368
		K2368_MOVE = True
		else
	z2368 = nothing
     End If

     If  getColumIndex(spr,"Autokey") > -1 then z2368.Autokey = getDataM(spr, getColumIndex(spr,"Autokey"), xRow)
     If  getColumIndex(spr,"JobCardWorking") > -1 then z2368.JobCardWorking = getDataM(spr, getColumIndex(spr,"JobCardWorking"), xRow)
     If  getColumIndex(spr,"DateOutBoundMaterial") > -1 then z2368.DateOutBoundMaterial = getDataM(spr, getColumIndex(spr,"DateOutBoundMaterial"), xRow)
     If  getColumIndex(spr,"SeqOutBoundMaterial") > -1 then z2368.SeqOutBoundMaterial = getDataM(spr, getColumIndex(spr,"SeqOutBoundMaterial"), xRow)
     If  getColumIndex(spr,"SnoOutBoundMaterial") > -1 then z2368.SnoOutBoundMaterial = getDataM(spr, getColumIndex(spr,"SnoOutBoundMaterial"), xRow)
     If  getColumIndex(spr,"MaterialInBoundNo") > -1 then z2368.MaterialInBoundNo = getDataM(spr, getColumIndex(spr,"MaterialInBoundNo"), xRow)
     If  getColumIndex(spr,"MaterialInBoundSeq") > -1 then z2368.MaterialInBoundSeq = getDataM(spr, getColumIndex(spr,"MaterialInBoundSeq"), xRow)
     If  getColumIndex(spr,"MaterialInBoundSno") > -1 then z2368.MaterialInBoundSno = getDataM(spr, getColumIndex(spr,"MaterialInBoundSno"), xRow)
     If  getColumIndex(spr,"FactOrderNo") > -1 then z2368.FactOrderNo = getDataM(spr, getColumIndex(spr,"FactOrderNo"), xRow)
     If  getColumIndex(spr,"FactOrderSeq") > -1 then z2368.FactOrderSeq = getDataM(spr, getColumIndex(spr,"FactOrderSeq"), xRow)
     If  getColumIndex(spr,"cdDepartment") > -1 then z2368.cdDepartment = getDataM(spr, getColumIndex(spr,"cdDepartment"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z2368.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z2368.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"InchargeReceipt") > -1 then z2368.InchargeReceipt = getDataM(spr, getColumIndex(spr,"InchargeReceipt"), xRow)
     If  getColumIndex(spr,"TimeReceipt") > -1 then z2368.TimeReceipt = getDataM(spr, getColumIndex(spr,"TimeReceipt"), xRow)
     If  getColumIndex(spr,"DateRecept") > -1 then z2368.DateRecept = getDataM(spr, getColumIndex(spr,"DateRecept"), xRow)
     If  getColumIndex(spr,"QtyOutbound") > -1 then z2368.QtyOutbound = getDataM(spr, getColumIndex(spr,"QtyOutbound"), xRow)
     If  getColumIndex(spr,"QtyReceipt") > -1 then z2368.QtyReceipt = getDataM(spr, getColumIndex(spr,"QtyReceipt"), xRow)
     If  getColumIndex(spr,"QtyProduction") > -1 then z2368.QtyProduction = getDataM(spr, getColumIndex(spr,"QtyProduction"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z2368.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K2368_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K2368_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z2368 As T2368_AREA,CheckClear as Boolean,AUTOKEY AS Double) as Boolean

K2368_MOVE = False

Try
    If READ_PFK2368(AUTOKEY) = True Then
                z2368 = D2368
		K2368_MOVE = True
		else
	If CheckClear  = True then z2368 = nothing
     End If

     If  getColumIndex(spr,"Autokey") > -1 then z2368.Autokey = getDataM(spr, getColumIndex(spr,"Autokey"), xRow)
     If  getColumIndex(spr,"JobCardWorking") > -1 then z2368.JobCardWorking = getDataM(spr, getColumIndex(spr,"JobCardWorking"), xRow)
     If  getColumIndex(spr,"DateOutBoundMaterial") > -1 then z2368.DateOutBoundMaterial = getDataM(spr, getColumIndex(spr,"DateOutBoundMaterial"), xRow)
     If  getColumIndex(spr,"SeqOutBoundMaterial") > -1 then z2368.SeqOutBoundMaterial = getDataM(spr, getColumIndex(spr,"SeqOutBoundMaterial"), xRow)
     If  getColumIndex(spr,"SnoOutBoundMaterial") > -1 then z2368.SnoOutBoundMaterial = getDataM(spr, getColumIndex(spr,"SnoOutBoundMaterial"), xRow)
     If  getColumIndex(spr,"MaterialInBoundNo") > -1 then z2368.MaterialInBoundNo = getDataM(spr, getColumIndex(spr,"MaterialInBoundNo"), xRow)
     If  getColumIndex(spr,"MaterialInBoundSeq") > -1 then z2368.MaterialInBoundSeq = getDataM(spr, getColumIndex(spr,"MaterialInBoundSeq"), xRow)
     If  getColumIndex(spr,"MaterialInBoundSno") > -1 then z2368.MaterialInBoundSno = getDataM(spr, getColumIndex(spr,"MaterialInBoundSno"), xRow)
     If  getColumIndex(spr,"FactOrderNo") > -1 then z2368.FactOrderNo = getDataM(spr, getColumIndex(spr,"FactOrderNo"), xRow)
     If  getColumIndex(spr,"FactOrderSeq") > -1 then z2368.FactOrderSeq = getDataM(spr, getColumIndex(spr,"FactOrderSeq"), xRow)
     If  getColumIndex(spr,"cdDepartment") > -1 then z2368.cdDepartment = getDataM(spr, getColumIndex(spr,"cdDepartment"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z2368.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z2368.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"InchargeReceipt") > -1 then z2368.InchargeReceipt = getDataM(spr, getColumIndex(spr,"InchargeReceipt"), xRow)
     If  getColumIndex(spr,"TimeReceipt") > -1 then z2368.TimeReceipt = getDataM(spr, getColumIndex(spr,"TimeReceipt"), xRow)
     If  getColumIndex(spr,"DateRecept") > -1 then z2368.DateRecept = getDataM(spr, getColumIndex(spr,"DateRecept"), xRow)
     If  getColumIndex(spr,"QtyOutbound") > -1 then z2368.QtyOutbound = getDataM(spr, getColumIndex(spr,"QtyOutbound"), xRow)
     If  getColumIndex(spr,"QtyReceipt") > -1 then z2368.QtyReceipt = getDataM(spr, getColumIndex(spr,"QtyReceipt"), xRow)
     If  getColumIndex(spr,"QtyProduction") > -1 then z2368.QtyProduction = getDataM(spr, getColumIndex(spr,"QtyProduction"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z2368.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K2368_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K2368_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z2368 As T2368_AREA, Job as String, AUTOKEY AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K2368_MOVE = False

Try
    If READ_PFK2368(AUTOKEY) = True Then
                z2368 = D2368
		K2368_MOVE = True
		else
	z2368 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2368")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z2368.Autokey = Children(i).Code
   Case "JOBCARDWORKING":z2368.JobCardWorking = Children(i).Code
   Case "DATEOUTBOUNDMATERIAL":z2368.DateOutBoundMaterial = Children(i).Code
   Case "SEQOUTBOUNDMATERIAL":z2368.SeqOutBoundMaterial = Children(i).Code
   Case "SNOOUTBOUNDMATERIAL":z2368.SnoOutBoundMaterial = Children(i).Code
   Case "MATERIALINBOUNDNO":z2368.MaterialInBoundNo = Children(i).Code
   Case "MATERIALINBOUNDSEQ":z2368.MaterialInBoundSeq = Children(i).Code
   Case "MATERIALINBOUNDSNO":z2368.MaterialInBoundSno = Children(i).Code
   Case "FACTORDERNO":z2368.FactOrderNo = Children(i).Code
   Case "FACTORDERSEQ":z2368.FactOrderSeq = Children(i).Code
   Case "CDDEPARTMENT":z2368.cdDepartment = Children(i).Code
   Case "CDLINEPROD":z2368.cdLineProd = Children(i).Code
   Case "CDSUBPROCESS":z2368.cdSubProcess = Children(i).Code
   Case "INCHARGERECEIPT":z2368.InchargeReceipt = Children(i).Code
   Case "TIMERECEIPT":z2368.TimeReceipt = Children(i).Code
   Case "DATERECEPT":z2368.DateRecept = Children(i).Code
   Case "QTYOUTBOUND":z2368.QtyOutbound = Children(i).Code
   Case "QTYRECEIPT":z2368.QtyReceipt = Children(i).Code
   Case "QTYPRODUCTION":z2368.QtyProduction = Children(i).Code
   Case "REMARK":z2368.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z2368.Autokey = Children(i).Data
   Case "JOBCARDWORKING":z2368.JobCardWorking = Children(i).Data
   Case "DATEOUTBOUNDMATERIAL":z2368.DateOutBoundMaterial = Children(i).Data
   Case "SEQOUTBOUNDMATERIAL":z2368.SeqOutBoundMaterial = Children(i).Data
   Case "SNOOUTBOUNDMATERIAL":z2368.SnoOutBoundMaterial = Children(i).Data
   Case "MATERIALINBOUNDNO":z2368.MaterialInBoundNo = Children(i).Data
   Case "MATERIALINBOUNDSEQ":z2368.MaterialInBoundSeq = Children(i).Data
   Case "MATERIALINBOUNDSNO":z2368.MaterialInBoundSno = Children(i).Data
   Case "FACTORDERNO":z2368.FactOrderNo = Children(i).Data
   Case "FACTORDERSEQ":z2368.FactOrderSeq = Children(i).Data
   Case "CDDEPARTMENT":z2368.cdDepartment = Children(i).Data
   Case "CDLINEPROD":z2368.cdLineProd = Children(i).Data
   Case "CDSUBPROCESS":z2368.cdSubProcess = Children(i).Data
   Case "INCHARGERECEIPT":z2368.InchargeReceipt = Children(i).Data
   Case "TIMERECEIPT":z2368.TimeReceipt = Children(i).Data
   Case "DATERECEPT":z2368.DateRecept = Children(i).Data
   Case "QTYOUTBOUND":z2368.QtyOutbound = Children(i).Data
   Case "QTYRECEIPT":z2368.QtyReceipt = Children(i).Data
   Case "QTYPRODUCTION":z2368.QtyProduction = Children(i).Data
   Case "REMARK":z2368.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K2368_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K2368_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z2368 As T2368_AREA, Job as String, CheckClear as Boolean, AUTOKEY AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K2368_MOVE = False

Try
    If READ_PFK2368(AUTOKEY) = True Then
                z2368 = D2368
		K2368_MOVE = True
		else
	If CheckClear  = True then z2368 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2368")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z2368.Autokey = Children(i).Code
   Case "JOBCARDWORKING":z2368.JobCardWorking = Children(i).Code
   Case "DATEOUTBOUNDMATERIAL":z2368.DateOutBoundMaterial = Children(i).Code
   Case "SEQOUTBOUNDMATERIAL":z2368.SeqOutBoundMaterial = Children(i).Code
   Case "SNOOUTBOUNDMATERIAL":z2368.SnoOutBoundMaterial = Children(i).Code
   Case "MATERIALINBOUNDNO":z2368.MaterialInBoundNo = Children(i).Code
   Case "MATERIALINBOUNDSEQ":z2368.MaterialInBoundSeq = Children(i).Code
   Case "MATERIALINBOUNDSNO":z2368.MaterialInBoundSno = Children(i).Code
   Case "FACTORDERNO":z2368.FactOrderNo = Children(i).Code
   Case "FACTORDERSEQ":z2368.FactOrderSeq = Children(i).Code
   Case "CDDEPARTMENT":z2368.cdDepartment = Children(i).Code
   Case "CDLINEPROD":z2368.cdLineProd = Children(i).Code
   Case "CDSUBPROCESS":z2368.cdSubProcess = Children(i).Code
   Case "INCHARGERECEIPT":z2368.InchargeReceipt = Children(i).Code
   Case "TIMERECEIPT":z2368.TimeReceipt = Children(i).Code
   Case "DATERECEPT":z2368.DateRecept = Children(i).Code
   Case "QTYOUTBOUND":z2368.QtyOutbound = Children(i).Code
   Case "QTYRECEIPT":z2368.QtyReceipt = Children(i).Code
   Case "QTYPRODUCTION":z2368.QtyProduction = Children(i).Code
   Case "REMARK":z2368.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z2368.Autokey = Children(i).Data
   Case "JOBCARDWORKING":z2368.JobCardWorking = Children(i).Data
   Case "DATEOUTBOUNDMATERIAL":z2368.DateOutBoundMaterial = Children(i).Data
   Case "SEQOUTBOUNDMATERIAL":z2368.SeqOutBoundMaterial = Children(i).Data
   Case "SNOOUTBOUNDMATERIAL":z2368.SnoOutBoundMaterial = Children(i).Data
   Case "MATERIALINBOUNDNO":z2368.MaterialInBoundNo = Children(i).Data
   Case "MATERIALINBOUNDSEQ":z2368.MaterialInBoundSeq = Children(i).Data
   Case "MATERIALINBOUNDSNO":z2368.MaterialInBoundSno = Children(i).Data
   Case "FACTORDERNO":z2368.FactOrderNo = Children(i).Data
   Case "FACTORDERSEQ":z2368.FactOrderSeq = Children(i).Data
   Case "CDDEPARTMENT":z2368.cdDepartment = Children(i).Data
   Case "CDLINEPROD":z2368.cdLineProd = Children(i).Data
   Case "CDSUBPROCESS":z2368.cdSubProcess = Children(i).Data
   Case "INCHARGERECEIPT":z2368.InchargeReceipt = Children(i).Data
   Case "TIMERECEIPT":z2368.TimeReceipt = Children(i).Data
   Case "DATERECEPT":z2368.DateRecept = Children(i).Data
   Case "QTYOUTBOUND":z2368.QtyOutbound = Children(i).Data
   Case "QTYRECEIPT":z2368.QtyReceipt = Children(i).Data
   Case "QTYPRODUCTION":z2368.QtyProduction = Children(i).Data
   Case "REMARK":z2368.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K2368_MOVE",vbCritical)
End Try
End Function 
    
End Module 
