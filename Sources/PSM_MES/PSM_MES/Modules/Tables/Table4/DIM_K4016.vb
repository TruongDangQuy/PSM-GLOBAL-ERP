'=========================================================================================================================================================
'   TABLE : (PFK4016)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K4016

Structure T4016_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	JobCard	 AS String	'			char(10)		*
Public 	JobCardSeq	 AS String	'			char(3)		*
Public 	seMainProcess	 AS String	'			char(3)
Public 	cdMainProcess	 AS String	'			char(3)
Public 	seSubProcess	 AS String	'			char(3)
Public 	cdSubProcess	 AS String	'			char(3)
Public 	Description	 AS String	'			nvarchar(100)
Public 	QtyDateStandard	 AS Double	'			decimal
Public 	QtyDateMin	 AS Double	'			decimal
Public 	QtyDateMax	 AS Double	'			decimal
Public 	MasterModelDateProcess	 AS String	'			char(8)
Public 	MasterPlanDateProcess	 AS String	'			char(8)
Public 	MasterSalesDateProcess	 AS String	'			char(8)
Public 	MasterDateProcess_1	 AS String	'			char(8)
Public 	MasterDateProcess_2	 AS String	'			char(8)
Public 	MasterDateProcess_3	 AS String	'			char(8)
Public 	MasterDateProcess_4	 AS String	'			char(8)
Public 	MasterDateProcess_5	 AS String	'			char(8)
Public 	InchargePlan1	 AS String	'			char(8)
Public 	InchargePlan2	 AS String	'			char(8)
Public 	InchargePlan3	 AS String	'			char(8)
Public 	InchargePlan4	 AS String	'			char(8)
Public 	InchargePlan5	 AS String	'			char(8)
Public 	DateInsert	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(6)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(6)
Public 	RemarkPlan1	 AS String	'			nvarchar(50)
Public 	RemarkPlan2	 AS String	'			nvarchar(50)
Public 	RemarkPlan3	 AS String	'			nvarchar(50)
Public 	RemarkPlan4	 AS String	'			nvarchar(50)
Public 	RemarkPlan5	 AS String	'			nvarchar(50)
'=========================================================================================================================================================
End structure

Public D4016 As T4016_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK4016(JOBCARD AS String, JOBCARDSEQ AS String) As Boolean
    READ_PFK4016 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4016 "
    SQL = SQL & " WHERE K4016_JobCard		 = '" & JobCard & "' " 
    SQL = SQL & "   AND K4016_JobCardSeq		 = '" & JobCardSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D4016_CLEAR: GoTo SKIP_READ_PFK4016
                
    Call K4016_MOVE(rd)
    READ_PFK4016 = True

SKIP_READ_PFK4016:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK4016",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK4016(JOBCARD AS String, JOBCARDSEQ AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4016 "
    SQL = SQL & " WHERE K4016_JobCard		 = '" & JobCard & "' " 
    SQL = SQL & "   AND K4016_JobCardSeq		 = '" & JobCardSeq & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK4016",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK4016(z4016 As T4016_AREA) As Boolean
    WRITE_PFK4016 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z4016)
 
    SQL = " INSERT INTO PFK4016 "
    SQL = SQL & " ( "
    SQL = SQL & " K4016_JobCard," 
    SQL = SQL & " K4016_JobCardSeq," 
    SQL = SQL & " K4016_seMainProcess," 
    SQL = SQL & " K4016_cdMainProcess," 
    SQL = SQL & " K4016_seSubProcess," 
    SQL = SQL & " K4016_cdSubProcess," 
    SQL = SQL & " K4016_Description," 
    SQL = SQL & " K4016_QtyDateStandard," 
    SQL = SQL & " K4016_QtyDateMin," 
    SQL = SQL & " K4016_QtyDateMax," 
    SQL = SQL & " K4016_MasterModelDateProcess," 
    SQL = SQL & " K4016_MasterPlanDateProcess," 
    SQL = SQL & " K4016_MasterSalesDateProcess," 
    SQL = SQL & " K4016_MasterDateProcess_1," 
    SQL = SQL & " K4016_MasterDateProcess_2," 
    SQL = SQL & " K4016_MasterDateProcess_3," 
    SQL = SQL & " K4016_MasterDateProcess_4," 
    SQL = SQL & " K4016_MasterDateProcess_5," 
    SQL = SQL & " K4016_InchargePlan1," 
    SQL = SQL & " K4016_InchargePlan2," 
    SQL = SQL & " K4016_InchargePlan3," 
    SQL = SQL & " K4016_InchargePlan4," 
    SQL = SQL & " K4016_InchargePlan5," 
    SQL = SQL & " K4016_DateInsert," 
    SQL = SQL & " K4016_InchargeInsert," 
    SQL = SQL & " K4016_DateUpdate," 
    SQL = SQL & " K4016_InchargeUpdate," 
    SQL = SQL & " K4016_RemarkPlan1," 
    SQL = SQL & " K4016_RemarkPlan2," 
    SQL = SQL & " K4016_RemarkPlan3," 
    SQL = SQL & " K4016_RemarkPlan4," 
    SQL = SQL & " K4016_RemarkPlan5 " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z4016.JobCard) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4016.JobCardSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4016.seMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4016.cdMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4016.seSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4016.cdSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4016.Description) & "', "  
    SQL = SQL & "   " & FormatSQL(z4016.QtyDateStandard) & ", "  
    SQL = SQL & "   " & FormatSQL(z4016.QtyDateMin) & ", "  
    SQL = SQL & "   " & FormatSQL(z4016.QtyDateMax) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4016.MasterModelDateProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4016.MasterPlanDateProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4016.MasterSalesDateProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4016.MasterDateProcess_1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4016.MasterDateProcess_2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4016.MasterDateProcess_3) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4016.MasterDateProcess_4) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4016.MasterDateProcess_5) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4016.InchargePlan1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4016.InchargePlan2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4016.InchargePlan3) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4016.InchargePlan4) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4016.InchargePlan5) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4016.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4016.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4016.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4016.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4016.RemarkPlan1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4016.RemarkPlan2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4016.RemarkPlan3) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4016.RemarkPlan4) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4016.RemarkPlan5) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK4016 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK4016",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK4016(z4016 As T4016_AREA) As Boolean
    REWRITE_PFK4016 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z4016)
   
    SQL = " UPDATE PFK4016 SET "
    SQL = SQL & "    K4016_seMainProcess      = N'" & FormatSQL(z4016.seMainProcess) & "', " 
    SQL = SQL & "    K4016_cdMainProcess      = N'" & FormatSQL(z4016.cdMainProcess) & "', " 
    SQL = SQL & "    K4016_seSubProcess      = N'" & FormatSQL(z4016.seSubProcess) & "', " 
    SQL = SQL & "    K4016_cdSubProcess      = N'" & FormatSQL(z4016.cdSubProcess) & "', " 
    SQL = SQL & "    K4016_Description      = N'" & FormatSQL(z4016.Description) & "', " 
    SQL = SQL & "    K4016_QtyDateStandard      =  " & FormatSQL(z4016.QtyDateStandard) & ", " 
    SQL = SQL & "    K4016_QtyDateMin      =  " & FormatSQL(z4016.QtyDateMin) & ", " 
    SQL = SQL & "    K4016_QtyDateMax      =  " & FormatSQL(z4016.QtyDateMax) & ", " 
    SQL = SQL & "    K4016_MasterModelDateProcess      = N'" & FormatSQL(z4016.MasterModelDateProcess) & "', " 
    SQL = SQL & "    K4016_MasterPlanDateProcess      = N'" & FormatSQL(z4016.MasterPlanDateProcess) & "', " 
    SQL = SQL & "    K4016_MasterSalesDateProcess      = N'" & FormatSQL(z4016.MasterSalesDateProcess) & "', " 
    SQL = SQL & "    K4016_MasterDateProcess_1      = N'" & FormatSQL(z4016.MasterDateProcess_1) & "', " 
    SQL = SQL & "    K4016_MasterDateProcess_2      = N'" & FormatSQL(z4016.MasterDateProcess_2) & "', " 
    SQL = SQL & "    K4016_MasterDateProcess_3      = N'" & FormatSQL(z4016.MasterDateProcess_3) & "', " 
    SQL = SQL & "    K4016_MasterDateProcess_4      = N'" & FormatSQL(z4016.MasterDateProcess_4) & "', " 
    SQL = SQL & "    K4016_MasterDateProcess_5      = N'" & FormatSQL(z4016.MasterDateProcess_5) & "', " 
    SQL = SQL & "    K4016_InchargePlan1      = N'" & FormatSQL(z4016.InchargePlan1) & "', " 
    SQL = SQL & "    K4016_InchargePlan2      = N'" & FormatSQL(z4016.InchargePlan2) & "', " 
    SQL = SQL & "    K4016_InchargePlan3      = N'" & FormatSQL(z4016.InchargePlan3) & "', " 
    SQL = SQL & "    K4016_InchargePlan4      = N'" & FormatSQL(z4016.InchargePlan4) & "', " 
    SQL = SQL & "    K4016_InchargePlan5      = N'" & FormatSQL(z4016.InchargePlan5) & "', " 
    SQL = SQL & "    K4016_DateInsert      = N'" & FormatSQL(z4016.DateInsert) & "', " 
    SQL = SQL & "    K4016_InchargeInsert      = N'" & FormatSQL(z4016.InchargeInsert) & "', " 
    SQL = SQL & "    K4016_DateUpdate      = N'" & FormatSQL(z4016.DateUpdate) & "', " 
    SQL = SQL & "    K4016_InchargeUpdate      = N'" & FormatSQL(z4016.InchargeUpdate) & "', " 
    SQL = SQL & "    K4016_RemarkPlan1      = N'" & FormatSQL(z4016.RemarkPlan1) & "', " 
    SQL = SQL & "    K4016_RemarkPlan2      = N'" & FormatSQL(z4016.RemarkPlan2) & "', " 
    SQL = SQL & "    K4016_RemarkPlan3      = N'" & FormatSQL(z4016.RemarkPlan3) & "', " 
    SQL = SQL & "    K4016_RemarkPlan4      = N'" & FormatSQL(z4016.RemarkPlan4) & "', " 
    SQL = SQL & "    K4016_RemarkPlan5      = N'" & FormatSQL(z4016.RemarkPlan5) & "'  " 
    SQL = SQL & " WHERE K4016_JobCard		 = '" & z4016.JobCard & "' " 
    SQL = SQL & "   AND K4016_JobCardSeq		 = '" & z4016.JobCardSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK4016 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK4016",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK4016(z4016 As T4016_AREA) As Boolean
    DELETE_PFK4016 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK4016 "
    SQL = SQL & " WHERE K4016_JobCard		 = '" & z4016.JobCard & "' " 
    SQL = SQL & "   AND K4016_JobCardSeq		 = '" & z4016.JobCardSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK4016 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK4016",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D4016_CLEAR()
Try
    
   D4016.JobCard = ""
   D4016.JobCardSeq = ""
   D4016.seMainProcess = ""
   D4016.cdMainProcess = ""
   D4016.seSubProcess = ""
   D4016.cdSubProcess = ""
   D4016.Description = ""
    D4016.QtyDateStandard = 0 
    D4016.QtyDateMin = 0 
    D4016.QtyDateMax = 0 
   D4016.MasterModelDateProcess = ""
   D4016.MasterPlanDateProcess = ""
   D4016.MasterSalesDateProcess = ""
   D4016.MasterDateProcess_1 = ""
   D4016.MasterDateProcess_2 = ""
   D4016.MasterDateProcess_3 = ""
   D4016.MasterDateProcess_4 = ""
   D4016.MasterDateProcess_5 = ""
   D4016.InchargePlan1 = ""
   D4016.InchargePlan2 = ""
   D4016.InchargePlan3 = ""
   D4016.InchargePlan4 = ""
   D4016.InchargePlan5 = ""
   D4016.DateInsert = ""
   D4016.InchargeInsert = ""
   D4016.DateUpdate = ""
   D4016.InchargeUpdate = ""
   D4016.RemarkPlan1 = ""
   D4016.RemarkPlan2 = ""
   D4016.RemarkPlan3 = ""
   D4016.RemarkPlan4 = ""
   D4016.RemarkPlan5 = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D4016_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x4016 As T4016_AREA)
Try
    
    x4016.JobCard = trim$(  x4016.JobCard)
    x4016.JobCardSeq = trim$(  x4016.JobCardSeq)
    x4016.seMainProcess = trim$(  x4016.seMainProcess)
    x4016.cdMainProcess = trim$(  x4016.cdMainProcess)
    x4016.seSubProcess = trim$(  x4016.seSubProcess)
    x4016.cdSubProcess = trim$(  x4016.cdSubProcess)
    x4016.Description = trim$(  x4016.Description)
    x4016.QtyDateStandard = trim$(  x4016.QtyDateStandard)
    x4016.QtyDateMin = trim$(  x4016.QtyDateMin)
    x4016.QtyDateMax = trim$(  x4016.QtyDateMax)
    x4016.MasterModelDateProcess = trim$(  x4016.MasterModelDateProcess)
    x4016.MasterPlanDateProcess = trim$(  x4016.MasterPlanDateProcess)
    x4016.MasterSalesDateProcess = trim$(  x4016.MasterSalesDateProcess)
    x4016.MasterDateProcess_1 = trim$(  x4016.MasterDateProcess_1)
    x4016.MasterDateProcess_2 = trim$(  x4016.MasterDateProcess_2)
    x4016.MasterDateProcess_3 = trim$(  x4016.MasterDateProcess_3)
    x4016.MasterDateProcess_4 = trim$(  x4016.MasterDateProcess_4)
    x4016.MasterDateProcess_5 = trim$(  x4016.MasterDateProcess_5)
    x4016.InchargePlan1 = trim$(  x4016.InchargePlan1)
    x4016.InchargePlan2 = trim$(  x4016.InchargePlan2)
    x4016.InchargePlan3 = trim$(  x4016.InchargePlan3)
    x4016.InchargePlan4 = trim$(  x4016.InchargePlan4)
    x4016.InchargePlan5 = trim$(  x4016.InchargePlan5)
    x4016.DateInsert = trim$(  x4016.DateInsert)
    x4016.InchargeInsert = trim$(  x4016.InchargeInsert)
    x4016.DateUpdate = trim$(  x4016.DateUpdate)
    x4016.InchargeUpdate = trim$(  x4016.InchargeUpdate)
    x4016.RemarkPlan1 = trim$(  x4016.RemarkPlan1)
    x4016.RemarkPlan2 = trim$(  x4016.RemarkPlan2)
    x4016.RemarkPlan3 = trim$(  x4016.RemarkPlan3)
    x4016.RemarkPlan4 = trim$(  x4016.RemarkPlan4)
    x4016.RemarkPlan5 = trim$(  x4016.RemarkPlan5)
     
    If trim$( x4016.JobCard ) = "" Then x4016.JobCard = Space(1) 
    If trim$( x4016.JobCardSeq ) = "" Then x4016.JobCardSeq = Space(1) 
    If trim$( x4016.seMainProcess ) = "" Then x4016.seMainProcess = Space(1) 
    If trim$( x4016.cdMainProcess ) = "" Then x4016.cdMainProcess = Space(1) 
    If trim$( x4016.seSubProcess ) = "" Then x4016.seSubProcess = Space(1) 
    If trim$( x4016.cdSubProcess ) = "" Then x4016.cdSubProcess = Space(1) 
    If trim$( x4016.Description ) = "" Then x4016.Description = Space(1) 
    If trim$( x4016.QtyDateStandard ) = "" Then x4016.QtyDateStandard = 0 
    If trim$( x4016.QtyDateMin ) = "" Then x4016.QtyDateMin = 0 
    If trim$( x4016.QtyDateMax ) = "" Then x4016.QtyDateMax = 0 
    If trim$( x4016.MasterModelDateProcess ) = "" Then x4016.MasterModelDateProcess = Space(1) 
    If trim$( x4016.MasterPlanDateProcess ) = "" Then x4016.MasterPlanDateProcess = Space(1) 
    If trim$( x4016.MasterSalesDateProcess ) = "" Then x4016.MasterSalesDateProcess = Space(1) 
    If trim$( x4016.MasterDateProcess_1 ) = "" Then x4016.MasterDateProcess_1 = Space(1) 
    If trim$( x4016.MasterDateProcess_2 ) = "" Then x4016.MasterDateProcess_2 = Space(1) 
    If trim$( x4016.MasterDateProcess_3 ) = "" Then x4016.MasterDateProcess_3 = Space(1) 
    If trim$( x4016.MasterDateProcess_4 ) = "" Then x4016.MasterDateProcess_4 = Space(1) 
    If trim$( x4016.MasterDateProcess_5 ) = "" Then x4016.MasterDateProcess_5 = Space(1) 
    If trim$( x4016.InchargePlan1 ) = "" Then x4016.InchargePlan1 = Space(1) 
    If trim$( x4016.InchargePlan2 ) = "" Then x4016.InchargePlan2 = Space(1) 
    If trim$( x4016.InchargePlan3 ) = "" Then x4016.InchargePlan3 = Space(1) 
    If trim$( x4016.InchargePlan4 ) = "" Then x4016.InchargePlan4 = Space(1) 
    If trim$( x4016.InchargePlan5 ) = "" Then x4016.InchargePlan5 = Space(1) 
    If trim$( x4016.DateInsert ) = "" Then x4016.DateInsert = Space(1) 
    If trim$( x4016.InchargeInsert ) = "" Then x4016.InchargeInsert = Space(1) 
    If trim$( x4016.DateUpdate ) = "" Then x4016.DateUpdate = Space(1) 
    If trim$( x4016.InchargeUpdate ) = "" Then x4016.InchargeUpdate = Space(1) 
    If trim$( x4016.RemarkPlan1 ) = "" Then x4016.RemarkPlan1 = Space(1) 
    If trim$( x4016.RemarkPlan2 ) = "" Then x4016.RemarkPlan2 = Space(1) 
    If trim$( x4016.RemarkPlan3 ) = "" Then x4016.RemarkPlan3 = Space(1) 
    If trim$( x4016.RemarkPlan4 ) = "" Then x4016.RemarkPlan4 = Space(1) 
    If trim$( x4016.RemarkPlan5 ) = "" Then x4016.RemarkPlan5 = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K4016_MOVE(rs4016 As SqlClient.SqlDataReader)
Try

    call D4016_CLEAR()   

    If IsdbNull(rs4016!K4016_JobCard) = False Then D4016.JobCard = Trim$(rs4016!K4016_JobCard)
    If IsdbNull(rs4016!K4016_JobCardSeq) = False Then D4016.JobCardSeq = Trim$(rs4016!K4016_JobCardSeq)
    If IsdbNull(rs4016!K4016_seMainProcess) = False Then D4016.seMainProcess = Trim$(rs4016!K4016_seMainProcess)
    If IsdbNull(rs4016!K4016_cdMainProcess) = False Then D4016.cdMainProcess = Trim$(rs4016!K4016_cdMainProcess)
    If IsdbNull(rs4016!K4016_seSubProcess) = False Then D4016.seSubProcess = Trim$(rs4016!K4016_seSubProcess)
    If IsdbNull(rs4016!K4016_cdSubProcess) = False Then D4016.cdSubProcess = Trim$(rs4016!K4016_cdSubProcess)
    If IsdbNull(rs4016!K4016_Description) = False Then D4016.Description = Trim$(rs4016!K4016_Description)
    If IsdbNull(rs4016!K4016_QtyDateStandard) = False Then D4016.QtyDateStandard = Trim$(rs4016!K4016_QtyDateStandard)
    If IsdbNull(rs4016!K4016_QtyDateMin) = False Then D4016.QtyDateMin = Trim$(rs4016!K4016_QtyDateMin)
    If IsdbNull(rs4016!K4016_QtyDateMax) = False Then D4016.QtyDateMax = Trim$(rs4016!K4016_QtyDateMax)
    If IsdbNull(rs4016!K4016_MasterModelDateProcess) = False Then D4016.MasterModelDateProcess = Trim$(rs4016!K4016_MasterModelDateProcess)
    If IsdbNull(rs4016!K4016_MasterPlanDateProcess) = False Then D4016.MasterPlanDateProcess = Trim$(rs4016!K4016_MasterPlanDateProcess)
    If IsdbNull(rs4016!K4016_MasterSalesDateProcess) = False Then D4016.MasterSalesDateProcess = Trim$(rs4016!K4016_MasterSalesDateProcess)
    If IsdbNull(rs4016!K4016_MasterDateProcess_1) = False Then D4016.MasterDateProcess_1 = Trim$(rs4016!K4016_MasterDateProcess_1)
    If IsdbNull(rs4016!K4016_MasterDateProcess_2) = False Then D4016.MasterDateProcess_2 = Trim$(rs4016!K4016_MasterDateProcess_2)
    If IsdbNull(rs4016!K4016_MasterDateProcess_3) = False Then D4016.MasterDateProcess_3 = Trim$(rs4016!K4016_MasterDateProcess_3)
    If IsdbNull(rs4016!K4016_MasterDateProcess_4) = False Then D4016.MasterDateProcess_4 = Trim$(rs4016!K4016_MasterDateProcess_4)
    If IsdbNull(rs4016!K4016_MasterDateProcess_5) = False Then D4016.MasterDateProcess_5 = Trim$(rs4016!K4016_MasterDateProcess_5)
    If IsdbNull(rs4016!K4016_InchargePlan1) = False Then D4016.InchargePlan1 = Trim$(rs4016!K4016_InchargePlan1)
    If IsdbNull(rs4016!K4016_InchargePlan2) = False Then D4016.InchargePlan2 = Trim$(rs4016!K4016_InchargePlan2)
    If IsdbNull(rs4016!K4016_InchargePlan3) = False Then D4016.InchargePlan3 = Trim$(rs4016!K4016_InchargePlan3)
    If IsdbNull(rs4016!K4016_InchargePlan4) = False Then D4016.InchargePlan4 = Trim$(rs4016!K4016_InchargePlan4)
    If IsdbNull(rs4016!K4016_InchargePlan5) = False Then D4016.InchargePlan5 = Trim$(rs4016!K4016_InchargePlan5)
    If IsdbNull(rs4016!K4016_DateInsert) = False Then D4016.DateInsert = Trim$(rs4016!K4016_DateInsert)
    If IsdbNull(rs4016!K4016_InchargeInsert) = False Then D4016.InchargeInsert = Trim$(rs4016!K4016_InchargeInsert)
    If IsdbNull(rs4016!K4016_DateUpdate) = False Then D4016.DateUpdate = Trim$(rs4016!K4016_DateUpdate)
    If IsdbNull(rs4016!K4016_InchargeUpdate) = False Then D4016.InchargeUpdate = Trim$(rs4016!K4016_InchargeUpdate)
    If IsdbNull(rs4016!K4016_RemarkPlan1) = False Then D4016.RemarkPlan1 = Trim$(rs4016!K4016_RemarkPlan1)
    If IsdbNull(rs4016!K4016_RemarkPlan2) = False Then D4016.RemarkPlan2 = Trim$(rs4016!K4016_RemarkPlan2)
    If IsdbNull(rs4016!K4016_RemarkPlan3) = False Then D4016.RemarkPlan3 = Trim$(rs4016!K4016_RemarkPlan3)
    If IsdbNull(rs4016!K4016_RemarkPlan4) = False Then D4016.RemarkPlan4 = Trim$(rs4016!K4016_RemarkPlan4)
    If IsdbNull(rs4016!K4016_RemarkPlan5) = False Then D4016.RemarkPlan5 = Trim$(rs4016!K4016_RemarkPlan5)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4016_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K4016_MOVE(rs4016 As DataRow)
Try

    call D4016_CLEAR()   

    If IsdbNull(rs4016!K4016_JobCard) = False Then D4016.JobCard = Trim$(rs4016!K4016_JobCard)
    If IsdbNull(rs4016!K4016_JobCardSeq) = False Then D4016.JobCardSeq = Trim$(rs4016!K4016_JobCardSeq)
    If IsdbNull(rs4016!K4016_seMainProcess) = False Then D4016.seMainProcess = Trim$(rs4016!K4016_seMainProcess)
    If IsdbNull(rs4016!K4016_cdMainProcess) = False Then D4016.cdMainProcess = Trim$(rs4016!K4016_cdMainProcess)
    If IsdbNull(rs4016!K4016_seSubProcess) = False Then D4016.seSubProcess = Trim$(rs4016!K4016_seSubProcess)
    If IsdbNull(rs4016!K4016_cdSubProcess) = False Then D4016.cdSubProcess = Trim$(rs4016!K4016_cdSubProcess)
    If IsdbNull(rs4016!K4016_Description) = False Then D4016.Description = Trim$(rs4016!K4016_Description)
    If IsdbNull(rs4016!K4016_QtyDateStandard) = False Then D4016.QtyDateStandard = Trim$(rs4016!K4016_QtyDateStandard)
    If IsdbNull(rs4016!K4016_QtyDateMin) = False Then D4016.QtyDateMin = Trim$(rs4016!K4016_QtyDateMin)
    If IsdbNull(rs4016!K4016_QtyDateMax) = False Then D4016.QtyDateMax = Trim$(rs4016!K4016_QtyDateMax)
    If IsdbNull(rs4016!K4016_MasterModelDateProcess) = False Then D4016.MasterModelDateProcess = Trim$(rs4016!K4016_MasterModelDateProcess)
    If IsdbNull(rs4016!K4016_MasterPlanDateProcess) = False Then D4016.MasterPlanDateProcess = Trim$(rs4016!K4016_MasterPlanDateProcess)
    If IsdbNull(rs4016!K4016_MasterSalesDateProcess) = False Then D4016.MasterSalesDateProcess = Trim$(rs4016!K4016_MasterSalesDateProcess)
    If IsdbNull(rs4016!K4016_MasterDateProcess_1) = False Then D4016.MasterDateProcess_1 = Trim$(rs4016!K4016_MasterDateProcess_1)
    If IsdbNull(rs4016!K4016_MasterDateProcess_2) = False Then D4016.MasterDateProcess_2 = Trim$(rs4016!K4016_MasterDateProcess_2)
    If IsdbNull(rs4016!K4016_MasterDateProcess_3) = False Then D4016.MasterDateProcess_3 = Trim$(rs4016!K4016_MasterDateProcess_3)
    If IsdbNull(rs4016!K4016_MasterDateProcess_4) = False Then D4016.MasterDateProcess_4 = Trim$(rs4016!K4016_MasterDateProcess_4)
    If IsdbNull(rs4016!K4016_MasterDateProcess_5) = False Then D4016.MasterDateProcess_5 = Trim$(rs4016!K4016_MasterDateProcess_5)
    If IsdbNull(rs4016!K4016_InchargePlan1) = False Then D4016.InchargePlan1 = Trim$(rs4016!K4016_InchargePlan1)
    If IsdbNull(rs4016!K4016_InchargePlan2) = False Then D4016.InchargePlan2 = Trim$(rs4016!K4016_InchargePlan2)
    If IsdbNull(rs4016!K4016_InchargePlan3) = False Then D4016.InchargePlan3 = Trim$(rs4016!K4016_InchargePlan3)
    If IsdbNull(rs4016!K4016_InchargePlan4) = False Then D4016.InchargePlan4 = Trim$(rs4016!K4016_InchargePlan4)
    If IsdbNull(rs4016!K4016_InchargePlan5) = False Then D4016.InchargePlan5 = Trim$(rs4016!K4016_InchargePlan5)
    If IsdbNull(rs4016!K4016_DateInsert) = False Then D4016.DateInsert = Trim$(rs4016!K4016_DateInsert)
    If IsdbNull(rs4016!K4016_InchargeInsert) = False Then D4016.InchargeInsert = Trim$(rs4016!K4016_InchargeInsert)
    If IsdbNull(rs4016!K4016_DateUpdate) = False Then D4016.DateUpdate = Trim$(rs4016!K4016_DateUpdate)
    If IsdbNull(rs4016!K4016_InchargeUpdate) = False Then D4016.InchargeUpdate = Trim$(rs4016!K4016_InchargeUpdate)
    If IsdbNull(rs4016!K4016_RemarkPlan1) = False Then D4016.RemarkPlan1 = Trim$(rs4016!K4016_RemarkPlan1)
    If IsdbNull(rs4016!K4016_RemarkPlan2) = False Then D4016.RemarkPlan2 = Trim$(rs4016!K4016_RemarkPlan2)
    If IsdbNull(rs4016!K4016_RemarkPlan3) = False Then D4016.RemarkPlan3 = Trim$(rs4016!K4016_RemarkPlan3)
    If IsdbNull(rs4016!K4016_RemarkPlan4) = False Then D4016.RemarkPlan4 = Trim$(rs4016!K4016_RemarkPlan4)
    If IsdbNull(rs4016!K4016_RemarkPlan5) = False Then D4016.RemarkPlan5 = Trim$(rs4016!K4016_RemarkPlan5)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4016_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K4016_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4016 As T4016_AREA, JOBCARD AS String, JOBCARDSEQ AS String) as Boolean

K4016_MOVE = False

Try
    If READ_PFK4016(JOBCARD, JOBCARDSEQ) = True Then
                z4016 = D4016
		K4016_MOVE = True
		else
	z4016 = nothing
     End If

     If  getColumIndex(spr,"JobCard") > -1 then z4016.JobCard = getDataM(spr, getColumIndex(spr,"JobCard"), xRow)
     If  getColumIndex(spr,"JobCardSeq") > -1 then z4016.JobCardSeq = getDataM(spr, getColumIndex(spr,"JobCardSeq"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z4016.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z4016.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z4016.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z4016.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z4016.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"QtyDateStandard") > -1 then z4016.QtyDateStandard = getDataM(spr, getColumIndex(spr,"QtyDateStandard"), xRow)
     If  getColumIndex(spr,"QtyDateMin") > -1 then z4016.QtyDateMin = getDataM(spr, getColumIndex(spr,"QtyDateMin"), xRow)
     If  getColumIndex(spr,"QtyDateMax") > -1 then z4016.QtyDateMax = getDataM(spr, getColumIndex(spr,"QtyDateMax"), xRow)
     If  getColumIndex(spr,"MasterModelDateProcess") > -1 then z4016.MasterModelDateProcess = getDataM(spr, getColumIndex(spr,"MasterModelDateProcess"), xRow)
     If  getColumIndex(spr,"MasterPlanDateProcess") > -1 then z4016.MasterPlanDateProcess = getDataM(spr, getColumIndex(spr,"MasterPlanDateProcess"), xRow)
     If  getColumIndex(spr,"MasterSalesDateProcess") > -1 then z4016.MasterSalesDateProcess = getDataM(spr, getColumIndex(spr,"MasterSalesDateProcess"), xRow)
     If  getColumIndex(spr,"MasterDateProcess_1") > -1 then z4016.MasterDateProcess_1 = getDataM(spr, getColumIndex(spr,"MasterDateProcess_1"), xRow)
     If  getColumIndex(spr,"MasterDateProcess_2") > -1 then z4016.MasterDateProcess_2 = getDataM(spr, getColumIndex(spr,"MasterDateProcess_2"), xRow)
     If  getColumIndex(spr,"MasterDateProcess_3") > -1 then z4016.MasterDateProcess_3 = getDataM(spr, getColumIndex(spr,"MasterDateProcess_3"), xRow)
     If  getColumIndex(spr,"MasterDateProcess_4") > -1 then z4016.MasterDateProcess_4 = getDataM(spr, getColumIndex(spr,"MasterDateProcess_4"), xRow)
     If  getColumIndex(spr,"MasterDateProcess_5") > -1 then z4016.MasterDateProcess_5 = getDataM(spr, getColumIndex(spr,"MasterDateProcess_5"), xRow)
     If  getColumIndex(spr,"InchargePlan1") > -1 then z4016.InchargePlan1 = getDataM(spr, getColumIndex(spr,"InchargePlan1"), xRow)
     If  getColumIndex(spr,"InchargePlan2") > -1 then z4016.InchargePlan2 = getDataM(spr, getColumIndex(spr,"InchargePlan2"), xRow)
     If  getColumIndex(spr,"InchargePlan3") > -1 then z4016.InchargePlan3 = getDataM(spr, getColumIndex(spr,"InchargePlan3"), xRow)
     If  getColumIndex(spr,"InchargePlan4") > -1 then z4016.InchargePlan4 = getDataM(spr, getColumIndex(spr,"InchargePlan4"), xRow)
     If  getColumIndex(spr,"InchargePlan5") > -1 then z4016.InchargePlan5 = getDataM(spr, getColumIndex(spr,"InchargePlan5"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z4016.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z4016.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z4016.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z4016.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"RemarkPlan1") > -1 then z4016.RemarkPlan1 = getDataM(spr, getColumIndex(spr,"RemarkPlan1"), xRow)
     If  getColumIndex(spr,"RemarkPlan2") > -1 then z4016.RemarkPlan2 = getDataM(spr, getColumIndex(spr,"RemarkPlan2"), xRow)
     If  getColumIndex(spr,"RemarkPlan3") > -1 then z4016.RemarkPlan3 = getDataM(spr, getColumIndex(spr,"RemarkPlan3"), xRow)
     If  getColumIndex(spr,"RemarkPlan4") > -1 then z4016.RemarkPlan4 = getDataM(spr, getColumIndex(spr,"RemarkPlan4"), xRow)
     If  getColumIndex(spr,"RemarkPlan5") > -1 then z4016.RemarkPlan5 = getDataM(spr, getColumIndex(spr,"RemarkPlan5"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4016_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K4016_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4016 As T4016_AREA,CheckClear as Boolean,JOBCARD AS String, JOBCARDSEQ AS String) as Boolean

K4016_MOVE = False

Try
    If READ_PFK4016(JOBCARD, JOBCARDSEQ) = True Then
                z4016 = D4016
		K4016_MOVE = True
		else
	If CheckClear  = True then z4016 = nothing
     End If

     If  getColumIndex(spr,"JobCard") > -1 then z4016.JobCard = getDataM(spr, getColumIndex(spr,"JobCard"), xRow)
     If  getColumIndex(spr,"JobCardSeq") > -1 then z4016.JobCardSeq = getDataM(spr, getColumIndex(spr,"JobCardSeq"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z4016.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z4016.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z4016.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z4016.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z4016.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"QtyDateStandard") > -1 then z4016.QtyDateStandard = getDataM(spr, getColumIndex(spr,"QtyDateStandard"), xRow)
     If  getColumIndex(spr,"QtyDateMin") > -1 then z4016.QtyDateMin = getDataM(spr, getColumIndex(spr,"QtyDateMin"), xRow)
     If  getColumIndex(spr,"QtyDateMax") > -1 then z4016.QtyDateMax = getDataM(spr, getColumIndex(spr,"QtyDateMax"), xRow)
     If  getColumIndex(spr,"MasterModelDateProcess") > -1 then z4016.MasterModelDateProcess = getDataM(spr, getColumIndex(spr,"MasterModelDateProcess"), xRow)
     If  getColumIndex(spr,"MasterPlanDateProcess") > -1 then z4016.MasterPlanDateProcess = getDataM(spr, getColumIndex(spr,"MasterPlanDateProcess"), xRow)
     If  getColumIndex(spr,"MasterSalesDateProcess") > -1 then z4016.MasterSalesDateProcess = getDataM(spr, getColumIndex(spr,"MasterSalesDateProcess"), xRow)
     If  getColumIndex(spr,"MasterDateProcess_1") > -1 then z4016.MasterDateProcess_1 = getDataM(spr, getColumIndex(spr,"MasterDateProcess_1"), xRow)
     If  getColumIndex(spr,"MasterDateProcess_2") > -1 then z4016.MasterDateProcess_2 = getDataM(spr, getColumIndex(spr,"MasterDateProcess_2"), xRow)
     If  getColumIndex(spr,"MasterDateProcess_3") > -1 then z4016.MasterDateProcess_3 = getDataM(spr, getColumIndex(spr,"MasterDateProcess_3"), xRow)
     If  getColumIndex(spr,"MasterDateProcess_4") > -1 then z4016.MasterDateProcess_4 = getDataM(spr, getColumIndex(spr,"MasterDateProcess_4"), xRow)
     If  getColumIndex(spr,"MasterDateProcess_5") > -1 then z4016.MasterDateProcess_5 = getDataM(spr, getColumIndex(spr,"MasterDateProcess_5"), xRow)
     If  getColumIndex(spr,"InchargePlan1") > -1 then z4016.InchargePlan1 = getDataM(spr, getColumIndex(spr,"InchargePlan1"), xRow)
     If  getColumIndex(spr,"InchargePlan2") > -1 then z4016.InchargePlan2 = getDataM(spr, getColumIndex(spr,"InchargePlan2"), xRow)
     If  getColumIndex(spr,"InchargePlan3") > -1 then z4016.InchargePlan3 = getDataM(spr, getColumIndex(spr,"InchargePlan3"), xRow)
     If  getColumIndex(spr,"InchargePlan4") > -1 then z4016.InchargePlan4 = getDataM(spr, getColumIndex(spr,"InchargePlan4"), xRow)
     If  getColumIndex(spr,"InchargePlan5") > -1 then z4016.InchargePlan5 = getDataM(spr, getColumIndex(spr,"InchargePlan5"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z4016.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z4016.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z4016.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z4016.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"RemarkPlan1") > -1 then z4016.RemarkPlan1 = getDataM(spr, getColumIndex(spr,"RemarkPlan1"), xRow)
     If  getColumIndex(spr,"RemarkPlan2") > -1 then z4016.RemarkPlan2 = getDataM(spr, getColumIndex(spr,"RemarkPlan2"), xRow)
     If  getColumIndex(spr,"RemarkPlan3") > -1 then z4016.RemarkPlan3 = getDataM(spr, getColumIndex(spr,"RemarkPlan3"), xRow)
     If  getColumIndex(spr,"RemarkPlan4") > -1 then z4016.RemarkPlan4 = getDataM(spr, getColumIndex(spr,"RemarkPlan4"), xRow)
     If  getColumIndex(spr,"RemarkPlan5") > -1 then z4016.RemarkPlan5 = getDataM(spr, getColumIndex(spr,"RemarkPlan5"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4016_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K4016_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4016 As T4016_AREA, Job as String, JOBCARD AS String, JOBCARDSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4016_MOVE = False

Try
    If READ_PFK4016(JOBCARD, JOBCARDSEQ) = True Then
                z4016 = D4016
		K4016_MOVE = True
		else
	z4016 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4016")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "JOBCARD":z4016.JobCard = Children(i).Code
   Case "JOBCARDSEQ":z4016.JobCardSeq = Children(i).Code
   Case "SEMAINPROCESS":z4016.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z4016.cdMainProcess = Children(i).Code
   Case "SESUBPROCESS":z4016.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z4016.cdSubProcess = Children(i).Code
   Case "DESCRIPTION":z4016.Description = Children(i).Code
   Case "QTYDATESTANDARD":z4016.QtyDateStandard = Children(i).Code
   Case "QTYDATEMIN":z4016.QtyDateMin = Children(i).Code
   Case "QTYDATEMAX":z4016.QtyDateMax = Children(i).Code
   Case "MASTERMODELDATEPROCESS":z4016.MasterModelDateProcess = Children(i).Code
   Case "MASTERPLANDATEPROCESS":z4016.MasterPlanDateProcess = Children(i).Code
   Case "MASTERSALESDATEPROCESS":z4016.MasterSalesDateProcess = Children(i).Code
   Case "MASTERDATEPROCESS_1":z4016.MasterDateProcess_1 = Children(i).Code
   Case "MASTERDATEPROCESS_2":z4016.MasterDateProcess_2 = Children(i).Code
   Case "MASTERDATEPROCESS_3":z4016.MasterDateProcess_3 = Children(i).Code
   Case "MASTERDATEPROCESS_4":z4016.MasterDateProcess_4 = Children(i).Code
   Case "MASTERDATEPROCESS_5":z4016.MasterDateProcess_5 = Children(i).Code
   Case "INCHARGEPLAN1":z4016.InchargePlan1 = Children(i).Code
   Case "INCHARGEPLAN2":z4016.InchargePlan2 = Children(i).Code
   Case "INCHARGEPLAN3":z4016.InchargePlan3 = Children(i).Code
   Case "INCHARGEPLAN4":z4016.InchargePlan4 = Children(i).Code
   Case "INCHARGEPLAN5":z4016.InchargePlan5 = Children(i).Code
   Case "DATEINSERT":z4016.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z4016.InchargeInsert = Children(i).Code
   Case "DATEUPDATE":z4016.DateUpdate = Children(i).Code
   Case "INCHARGEUPDATE":z4016.InchargeUpdate = Children(i).Code
   Case "REMARKPLAN1":z4016.RemarkPlan1 = Children(i).Code
   Case "REMARKPLAN2":z4016.RemarkPlan2 = Children(i).Code
   Case "REMARKPLAN3":z4016.RemarkPlan3 = Children(i).Code
   Case "REMARKPLAN4":z4016.RemarkPlan4 = Children(i).Code
   Case "REMARKPLAN5":z4016.RemarkPlan5 = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "JOBCARD":z4016.JobCard = Children(i).Data
   Case "JOBCARDSEQ":z4016.JobCardSeq = Children(i).Data
   Case "SEMAINPROCESS":z4016.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z4016.cdMainProcess = Children(i).Data
   Case "SESUBPROCESS":z4016.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z4016.cdSubProcess = Children(i).Data
   Case "DESCRIPTION":z4016.Description = Children(i).Data
   Case "QTYDATESTANDARD":z4016.QtyDateStandard = Children(i).Data
   Case "QTYDATEMIN":z4016.QtyDateMin = Children(i).Data
   Case "QTYDATEMAX":z4016.QtyDateMax = Children(i).Data
   Case "MASTERMODELDATEPROCESS":z4016.MasterModelDateProcess = Children(i).Data
   Case "MASTERPLANDATEPROCESS":z4016.MasterPlanDateProcess = Children(i).Data
   Case "MASTERSALESDATEPROCESS":z4016.MasterSalesDateProcess = Children(i).Data
   Case "MASTERDATEPROCESS_1":z4016.MasterDateProcess_1 = Children(i).Data
   Case "MASTERDATEPROCESS_2":z4016.MasterDateProcess_2 = Children(i).Data
   Case "MASTERDATEPROCESS_3":z4016.MasterDateProcess_3 = Children(i).Data
   Case "MASTERDATEPROCESS_4":z4016.MasterDateProcess_4 = Children(i).Data
   Case "MASTERDATEPROCESS_5":z4016.MasterDateProcess_5 = Children(i).Data
   Case "INCHARGEPLAN1":z4016.InchargePlan1 = Children(i).Data
   Case "INCHARGEPLAN2":z4016.InchargePlan2 = Children(i).Data
   Case "INCHARGEPLAN3":z4016.InchargePlan3 = Children(i).Data
   Case "INCHARGEPLAN4":z4016.InchargePlan4 = Children(i).Data
   Case "INCHARGEPLAN5":z4016.InchargePlan5 = Children(i).Data
   Case "DATEINSERT":z4016.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z4016.InchargeInsert = Children(i).Data
   Case "DATEUPDATE":z4016.DateUpdate = Children(i).Data
   Case "INCHARGEUPDATE":z4016.InchargeUpdate = Children(i).Data
   Case "REMARKPLAN1":z4016.RemarkPlan1 = Children(i).Data
   Case "REMARKPLAN2":z4016.RemarkPlan2 = Children(i).Data
   Case "REMARKPLAN3":z4016.RemarkPlan3 = Children(i).Data
   Case "REMARKPLAN4":z4016.RemarkPlan4 = Children(i).Data
   Case "REMARKPLAN5":z4016.RemarkPlan5 = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4016_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K4016_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4016 As T4016_AREA, Job as String, CheckClear as Boolean, JOBCARD AS String, JOBCARDSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4016_MOVE = False

Try
    If READ_PFK4016(JOBCARD, JOBCARDSEQ) = True Then
                z4016 = D4016
		K4016_MOVE = True
		else
	If CheckClear  = True then z4016 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4016")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "JOBCARD":z4016.JobCard = Children(i).Code
   Case "JOBCARDSEQ":z4016.JobCardSeq = Children(i).Code
   Case "SEMAINPROCESS":z4016.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z4016.cdMainProcess = Children(i).Code
   Case "SESUBPROCESS":z4016.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z4016.cdSubProcess = Children(i).Code
   Case "DESCRIPTION":z4016.Description = Children(i).Code
   Case "QTYDATESTANDARD":z4016.QtyDateStandard = Children(i).Code
   Case "QTYDATEMIN":z4016.QtyDateMin = Children(i).Code
   Case "QTYDATEMAX":z4016.QtyDateMax = Children(i).Code
   Case "MASTERMODELDATEPROCESS":z4016.MasterModelDateProcess = Children(i).Code
   Case "MASTERPLANDATEPROCESS":z4016.MasterPlanDateProcess = Children(i).Code
   Case "MASTERSALESDATEPROCESS":z4016.MasterSalesDateProcess = Children(i).Code
   Case "MASTERDATEPROCESS_1":z4016.MasterDateProcess_1 = Children(i).Code
   Case "MASTERDATEPROCESS_2":z4016.MasterDateProcess_2 = Children(i).Code
   Case "MASTERDATEPROCESS_3":z4016.MasterDateProcess_3 = Children(i).Code
   Case "MASTERDATEPROCESS_4":z4016.MasterDateProcess_4 = Children(i).Code
   Case "MASTERDATEPROCESS_5":z4016.MasterDateProcess_5 = Children(i).Code
   Case "INCHARGEPLAN1":z4016.InchargePlan1 = Children(i).Code
   Case "INCHARGEPLAN2":z4016.InchargePlan2 = Children(i).Code
   Case "INCHARGEPLAN3":z4016.InchargePlan3 = Children(i).Code
   Case "INCHARGEPLAN4":z4016.InchargePlan4 = Children(i).Code
   Case "INCHARGEPLAN5":z4016.InchargePlan5 = Children(i).Code
   Case "DATEINSERT":z4016.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z4016.InchargeInsert = Children(i).Code
   Case "DATEUPDATE":z4016.DateUpdate = Children(i).Code
   Case "INCHARGEUPDATE":z4016.InchargeUpdate = Children(i).Code
   Case "REMARKPLAN1":z4016.RemarkPlan1 = Children(i).Code
   Case "REMARKPLAN2":z4016.RemarkPlan2 = Children(i).Code
   Case "REMARKPLAN3":z4016.RemarkPlan3 = Children(i).Code
   Case "REMARKPLAN4":z4016.RemarkPlan4 = Children(i).Code
   Case "REMARKPLAN5":z4016.RemarkPlan5 = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "JOBCARD":z4016.JobCard = Children(i).Data
   Case "JOBCARDSEQ":z4016.JobCardSeq = Children(i).Data
   Case "SEMAINPROCESS":z4016.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z4016.cdMainProcess = Children(i).Data
   Case "SESUBPROCESS":z4016.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z4016.cdSubProcess = Children(i).Data
   Case "DESCRIPTION":z4016.Description = Children(i).Data
   Case "QTYDATESTANDARD":z4016.QtyDateStandard = Children(i).Data
   Case "QTYDATEMIN":z4016.QtyDateMin = Children(i).Data
   Case "QTYDATEMAX":z4016.QtyDateMax = Children(i).Data
   Case "MASTERMODELDATEPROCESS":z4016.MasterModelDateProcess = Children(i).Data
   Case "MASTERPLANDATEPROCESS":z4016.MasterPlanDateProcess = Children(i).Data
   Case "MASTERSALESDATEPROCESS":z4016.MasterSalesDateProcess = Children(i).Data
   Case "MASTERDATEPROCESS_1":z4016.MasterDateProcess_1 = Children(i).Data
   Case "MASTERDATEPROCESS_2":z4016.MasterDateProcess_2 = Children(i).Data
   Case "MASTERDATEPROCESS_3":z4016.MasterDateProcess_3 = Children(i).Data
   Case "MASTERDATEPROCESS_4":z4016.MasterDateProcess_4 = Children(i).Data
   Case "MASTERDATEPROCESS_5":z4016.MasterDateProcess_5 = Children(i).Data
   Case "INCHARGEPLAN1":z4016.InchargePlan1 = Children(i).Data
   Case "INCHARGEPLAN2":z4016.InchargePlan2 = Children(i).Data
   Case "INCHARGEPLAN3":z4016.InchargePlan3 = Children(i).Data
   Case "INCHARGEPLAN4":z4016.InchargePlan4 = Children(i).Data
   Case "INCHARGEPLAN5":z4016.InchargePlan5 = Children(i).Data
   Case "DATEINSERT":z4016.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z4016.InchargeInsert = Children(i).Data
   Case "DATEUPDATE":z4016.DateUpdate = Children(i).Data
   Case "INCHARGEUPDATE":z4016.InchargeUpdate = Children(i).Data
   Case "REMARKPLAN1":z4016.RemarkPlan1 = Children(i).Data
   Case "REMARKPLAN2":z4016.RemarkPlan2 = Children(i).Data
   Case "REMARKPLAN3":z4016.RemarkPlan3 = Children(i).Data
   Case "REMARKPLAN4":z4016.RemarkPlan4 = Children(i).Data
   Case "REMARKPLAN5":z4016.RemarkPlan5 = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4016_MOVE",vbCritical)
End Try
End Function 
    
End Module 
