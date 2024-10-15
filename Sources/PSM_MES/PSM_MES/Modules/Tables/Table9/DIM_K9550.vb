'=========================================================================================================================================================
'   TABLE : (PFK9550)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K9550

Structure T9550_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	cdWorkFlow	 AS String	'			char(3)		*
Public 	AutoKey_PFK9500_S	 AS Double	'			decimal		*
Public 	AutoKey_PFK9500_E	 AS Double	'			decimal
Public 	Dseq	 AS Double	'			decimal
Public 	DseqName	 AS String	'			nvarchar(50)
Public 	DseqTo	 AS Double	'			decimal
Public 	seWorkFlow	 AS String	'			char(3)
Public 	seCheckFlow	 AS String	'			char(3)
Public 	cdCheckFlow	 AS String	'			char(3)
Public 	Seq	 AS String	'			nvarchar(50)
Public 	DateAccept	 AS String	'			char(8)
Public 	seDepartment	 AS String	'			char(3)
Public 	cdDepartment	 AS String	'			char(3)
Public 	cdDepartmentName	 AS String	'			nvarchar(-1)
Public 	cdTeamName	 AS String	'			nvarchar(-1)
Public 	cdResponName	 AS String	'			nvarchar(-1)
Public 	sePosition	 AS String	'			char(3)
Public 	cdPosition	 AS String	'			char(3)
Public 	cdPositionName	 AS String	'			nvarchar(-1)
Public 	seIncharge	 AS String	'			char(3)
Public 	cdIncharge	 AS String	'			char(3)
Public 	IDNOName	 AS String	'			nvarchar(-1)
Public 	ID	 AS String	'			nvarchar(50)
Public 	CheckSC	 AS String	'			nvarchar(50)
Public 	CheckCP	 AS String	'			nvarchar(50)
Public 	seFrequency	 AS String	'			char(3)
Public 	cdFrequency	 AS String	'			char(3)
Public 	cdFrequencyName	 AS String	'			nvarchar(-1)
Public 	Purpose	 AS String	'			nvarchar(-1)
Public 	ActionName	 AS String	'			nvarchar(-1)
Public 	Description	 AS String	'			nvarchar(-1)
Public 	Receiver	 AS String	'			nvarchar(-1)
Public 	MinJob	 AS String	'			nvarchar(-1)
Public 	MaxJob	 AS String	'			nvarchar(-1)
Public 	AvgJob	 AS String	'			nvarchar(-1)
Public 	TimeJob	 AS String	'			nvarchar(-1)
Public 	Portion	 AS String	'			nvarchar(-1)
Public 	FilesName	 AS String	'			nvarchar(-1)
Public 	JobCardList	 AS String	'			nvarchar(-1)
Public 	ReportList	 AS String	'			char(8)
Public 	ISOList	 AS String	'			char(8)
Public 	WFList	 AS String	'			char(8)
Public 	MenuList	 AS String	'			char(8)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(6)
Public 	InchargeUpdate	 AS String	'			char(6)
Public 	CheckUse	 AS String	'			char(1)
Public 	DateActive	 AS String	'			char(8)
Public 	DateDeactive	 AS String	'			char(8)
Public 	CheckActive	 AS String	'			char(1)
Public 	Remark	 AS String	'			nvarchar(500)
'=========================================================================================================================================================
End structure

Public D9550 As T9550_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK9550(CDWORKFLOW AS String, AUTOKEY_PFK9500_S AS Double) As Boolean
    READ_PFK9550 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9550 "
    SQL = SQL & " WHERE K9550_cdWorkFlow		 = '" & cdWorkFlow & "' " 
    SQL = SQL & "   AND K9550_AutoKey_PFK9500_S		 =  " & AutoKey_PFK9500_S & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D9550_CLEAR: GoTo SKIP_READ_PFK9550
                
    Call K9550_MOVE(rd)
    READ_PFK9550 = True

SKIP_READ_PFK9550:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK9550",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK9550(CDWORKFLOW AS String, AUTOKEY_PFK9500_S AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9550 "
    SQL = SQL & " WHERE K9550_cdWorkFlow		 = '" & cdWorkFlow & "' " 
    SQL = SQL & "   AND K9550_AutoKey_PFK9500_S		 =  " & AutoKey_PFK9500_S & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK9550",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK9550(z9550 As T9550_AREA) As Boolean
    WRITE_PFK9550 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z9550)
 
    SQL = " INSERT INTO PFK9550 "
    SQL = SQL & " ( "
    SQL = SQL & " K9550_cdWorkFlow," 
    SQL = SQL & " K9550_AutoKey_PFK9500_S," 
    SQL = SQL & " K9550_AutoKey_PFK9500_E," 
    SQL = SQL & " K9550_Dseq," 
    SQL = SQL & " K9550_DseqName," 
    SQL = SQL & " K9550_DseqTo," 
    SQL = SQL & " K9550_seWorkFlow," 
    SQL = SQL & " K9550_seCheckFlow," 
    SQL = SQL & " K9550_cdCheckFlow," 
    SQL = SQL & " K9550_Seq," 
    SQL = SQL & " K9550_DateAccept," 
    SQL = SQL & " K9550_seDepartment," 
    SQL = SQL & " K9550_cdDepartment," 
    SQL = SQL & " K9550_cdDepartmentName," 
    SQL = SQL & " K9550_cdTeamName," 
    SQL = SQL & " K9550_cdResponName," 
    SQL = SQL & " K9550_sePosition," 
    SQL = SQL & " K9550_cdPosition," 
    SQL = SQL & " K9550_cdPositionName," 
    SQL = SQL & " K9550_seIncharge," 
    SQL = SQL & " K9550_cdIncharge," 
    SQL = SQL & " K9550_IDNOName," 
    SQL = SQL & " K9550_ID," 
    SQL = SQL & " K9550_CheckSC," 
    SQL = SQL & " K9550_CheckCP," 
    SQL = SQL & " K9550_seFrequency," 
    SQL = SQL & " K9550_cdFrequency," 
    SQL = SQL & " K9550_cdFrequencyName," 
    SQL = SQL & " K9550_Purpose," 
    SQL = SQL & " K9550_ActionName," 
    SQL = SQL & " K9550_Description," 
    SQL = SQL & " K9550_Receiver," 
    SQL = SQL & " K9550_MinJob," 
    SQL = SQL & " K9550_MaxJob," 
    SQL = SQL & " K9550_AvgJob," 
    SQL = SQL & " K9550_TimeJob," 
    SQL = SQL & " K9550_Portion," 
    SQL = SQL & " K9550_FilesName," 
    SQL = SQL & " K9550_JobCardList," 
    SQL = SQL & " K9550_ReportList," 
    SQL = SQL & " K9550_ISOList," 
    SQL = SQL & " K9550_WFList," 
    SQL = SQL & " K9550_MenuList," 
    SQL = SQL & " K9550_DateInsert," 
    SQL = SQL & " K9550_DateUpdate," 
    SQL = SQL & " K9550_InchargeInsert," 
    SQL = SQL & " K9550_InchargeUpdate," 
    SQL = SQL & " K9550_CheckUse," 
    SQL = SQL & " K9550_DateActive," 
    SQL = SQL & " K9550_DateDeactive," 
    SQL = SQL & " K9550_CheckActive," 
    SQL = SQL & " K9550_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z9550.cdWorkFlow) & "', "  
    SQL = SQL & "   " & FormatSQL(z9550.AutoKey_PFK9500_S) & ", "  
    SQL = SQL & "   " & FormatSQL(z9550.AutoKey_PFK9500_E) & ", "  
    SQL = SQL & "   " & FormatSQL(z9550.Dseq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z9550.DseqName) & "', "  
    SQL = SQL & "   " & FormatSQL(z9550.DseqTo) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z9550.seWorkFlow) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.seCheckFlow) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.cdCheckFlow) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.Seq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.DateAccept) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.seDepartment) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.cdDepartment) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.cdDepartmentName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.cdTeamName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.cdResponName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.sePosition) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.cdPosition) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.cdPositionName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.seIncharge) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.cdIncharge) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.IDNOName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.ID) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.CheckSC) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.CheckCP) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.seFrequency) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.cdFrequency) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.cdFrequencyName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.Purpose) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.ActionName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.Description) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.Receiver) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.MinJob) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.MaxJob) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.AvgJob) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.TimeJob) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.Portion) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.FilesName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.JobCardList) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.ReportList) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.ISOList) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.WFList) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.MenuList) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.CheckUse) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.DateActive) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.DateDeactive) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.CheckActive) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9550.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK9550 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK9550",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK9550(z9550 As T9550_AREA) As Boolean
    REWRITE_PFK9550 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z9550)
   
    SQL = " UPDATE PFK9550 SET "
    SQL = SQL & "    K9550_AutoKey_PFK9500_E      =  " & FormatSQL(z9550.AutoKey_PFK9500_E) & ", " 
    SQL = SQL & "    K9550_Dseq      =  " & FormatSQL(z9550.Dseq) & ", " 
    SQL = SQL & "    K9550_DseqName      = N'" & FormatSQL(z9550.DseqName) & "', " 
    SQL = SQL & "    K9550_DseqTo      =  " & FormatSQL(z9550.DseqTo) & ", " 
    SQL = SQL & "    K9550_seWorkFlow      = N'" & FormatSQL(z9550.seWorkFlow) & "', " 
    SQL = SQL & "    K9550_seCheckFlow      = N'" & FormatSQL(z9550.seCheckFlow) & "', " 
    SQL = SQL & "    K9550_cdCheckFlow      = N'" & FormatSQL(z9550.cdCheckFlow) & "', " 
    SQL = SQL & "    K9550_Seq      = N'" & FormatSQL(z9550.Seq) & "', " 
    SQL = SQL & "    K9550_DateAccept      = N'" & FormatSQL(z9550.DateAccept) & "', " 
    SQL = SQL & "    K9550_seDepartment      = N'" & FormatSQL(z9550.seDepartment) & "', " 
    SQL = SQL & "    K9550_cdDepartment      = N'" & FormatSQL(z9550.cdDepartment) & "', " 
    SQL = SQL & "    K9550_cdDepartmentName      = N'" & FormatSQL(z9550.cdDepartmentName) & "', " 
    SQL = SQL & "    K9550_cdTeamName      = N'" & FormatSQL(z9550.cdTeamName) & "', " 
    SQL = SQL & "    K9550_cdResponName      = N'" & FormatSQL(z9550.cdResponName) & "', " 
    SQL = SQL & "    K9550_sePosition      = N'" & FormatSQL(z9550.sePosition) & "', " 
    SQL = SQL & "    K9550_cdPosition      = N'" & FormatSQL(z9550.cdPosition) & "', " 
    SQL = SQL & "    K9550_cdPositionName      = N'" & FormatSQL(z9550.cdPositionName) & "', " 
    SQL = SQL & "    K9550_seIncharge      = N'" & FormatSQL(z9550.seIncharge) & "', " 
    SQL = SQL & "    K9550_cdIncharge      = N'" & FormatSQL(z9550.cdIncharge) & "', " 
    SQL = SQL & "    K9550_IDNOName      = N'" & FormatSQL(z9550.IDNOName) & "', " 
    SQL = SQL & "    K9550_ID      = N'" & FormatSQL(z9550.ID) & "', " 
    SQL = SQL & "    K9550_CheckSC      = N'" & FormatSQL(z9550.CheckSC) & "', " 
    SQL = SQL & "    K9550_CheckCP      = N'" & FormatSQL(z9550.CheckCP) & "', " 
    SQL = SQL & "    K9550_seFrequency      = N'" & FormatSQL(z9550.seFrequency) & "', " 
    SQL = SQL & "    K9550_cdFrequency      = N'" & FormatSQL(z9550.cdFrequency) & "', " 
    SQL = SQL & "    K9550_cdFrequencyName      = N'" & FormatSQL(z9550.cdFrequencyName) & "', " 
    SQL = SQL & "    K9550_Purpose      = N'" & FormatSQL(z9550.Purpose) & "', " 
    SQL = SQL & "    K9550_ActionName      = N'" & FormatSQL(z9550.ActionName) & "', " 
    SQL = SQL & "    K9550_Description      = N'" & FormatSQL(z9550.Description) & "', " 
    SQL = SQL & "    K9550_Receiver      = N'" & FormatSQL(z9550.Receiver) & "', " 
    SQL = SQL & "    K9550_MinJob      = N'" & FormatSQL(z9550.MinJob) & "', " 
    SQL = SQL & "    K9550_MaxJob      = N'" & FormatSQL(z9550.MaxJob) & "', " 
    SQL = SQL & "    K9550_AvgJob      = N'" & FormatSQL(z9550.AvgJob) & "', " 
    SQL = SQL & "    K9550_TimeJob      = N'" & FormatSQL(z9550.TimeJob) & "', " 
    SQL = SQL & "    K9550_Portion      = N'" & FormatSQL(z9550.Portion) & "', " 
    SQL = SQL & "    K9550_FilesName      = N'" & FormatSQL(z9550.FilesName) & "', " 
    SQL = SQL & "    K9550_JobCardList      = N'" & FormatSQL(z9550.JobCardList) & "', " 
    SQL = SQL & "    K9550_ReportList      = N'" & FormatSQL(z9550.ReportList) & "', " 
    SQL = SQL & "    K9550_ISOList      = N'" & FormatSQL(z9550.ISOList) & "', " 
    SQL = SQL & "    K9550_WFList      = N'" & FormatSQL(z9550.WFList) & "', " 
    SQL = SQL & "    K9550_MenuList      = N'" & FormatSQL(z9550.MenuList) & "', " 
    SQL = SQL & "    K9550_DateInsert      = N'" & FormatSQL(z9550.DateInsert) & "', " 
    SQL = SQL & "    K9550_DateUpdate      = N'" & FormatSQL(z9550.DateUpdate) & "', " 
    SQL = SQL & "    K9550_InchargeInsert      = N'" & FormatSQL(z9550.InchargeInsert) & "', " 
    SQL = SQL & "    K9550_InchargeUpdate      = N'" & FormatSQL(z9550.InchargeUpdate) & "', " 
    SQL = SQL & "    K9550_CheckUse      = N'" & FormatSQL(z9550.CheckUse) & "', " 
    SQL = SQL & "    K9550_DateActive      = N'" & FormatSQL(z9550.DateActive) & "', " 
    SQL = SQL & "    K9550_DateDeactive      = N'" & FormatSQL(z9550.DateDeactive) & "', " 
    SQL = SQL & "    K9550_CheckActive      = N'" & FormatSQL(z9550.CheckActive) & "', " 
    SQL = SQL & "    K9550_Remark      = N'" & FormatSQL(z9550.Remark) & "'  " 
    SQL = SQL & " WHERE K9550_cdWorkFlow		 = '" & z9550.cdWorkFlow & "' " 
    SQL = SQL & "   AND K9550_AutoKey_PFK9500_S		 =  " & z9550.AutoKey_PFK9500_S & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK9550 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK9550",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK9550(z9550 As T9550_AREA) As Boolean
    DELETE_PFK9550 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK9550 "
    SQL = SQL & " WHERE K9550_cdWorkFlow		 = '" & z9550.cdWorkFlow & "' " 
    SQL = SQL & "   AND K9550_AutoKey_PFK9500_S		 =  " & z9550.AutoKey_PFK9500_S & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK9550 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK9550",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D9550_CLEAR()
Try
    
   D9550.cdWorkFlow = ""
    D9550.AutoKey_PFK9500_S = 0 
    D9550.AutoKey_PFK9500_E = 0 
    D9550.Dseq = 0 
   D9550.DseqName = ""
    D9550.DseqTo = 0 
   D9550.seWorkFlow = ""
   D9550.seCheckFlow = ""
   D9550.cdCheckFlow = ""
   D9550.Seq = ""
   D9550.DateAccept = ""
   D9550.seDepartment = ""
   D9550.cdDepartment = ""
   D9550.cdDepartmentName = ""
   D9550.cdTeamName = ""
   D9550.cdResponName = ""
   D9550.sePosition = ""
   D9550.cdPosition = ""
   D9550.cdPositionName = ""
   D9550.seIncharge = ""
   D9550.cdIncharge = ""
   D9550.IDNOName = ""
   D9550.ID = ""
   D9550.CheckSC = ""
   D9550.CheckCP = ""
   D9550.seFrequency = ""
   D9550.cdFrequency = ""
   D9550.cdFrequencyName = ""
   D9550.Purpose = ""
   D9550.ActionName = ""
   D9550.Description = ""
   D9550.Receiver = ""
   D9550.MinJob = ""
   D9550.MaxJob = ""
   D9550.AvgJob = ""
   D9550.TimeJob = ""
   D9550.Portion = ""
   D9550.FilesName = ""
   D9550.JobCardList = ""
   D9550.ReportList = ""
   D9550.ISOList = ""
   D9550.WFList = ""
   D9550.MenuList = ""
   D9550.DateInsert = ""
   D9550.DateUpdate = ""
   D9550.InchargeInsert = ""
   D9550.InchargeUpdate = ""
   D9550.CheckUse = ""
   D9550.DateActive = ""
   D9550.DateDeactive = ""
   D9550.CheckActive = ""
   D9550.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D9550_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x9550 As T9550_AREA)
Try
    
    x9550.cdWorkFlow = trim$(  x9550.cdWorkFlow)
    x9550.AutoKey_PFK9500_S = trim$(  x9550.AutoKey_PFK9500_S)
    x9550.AutoKey_PFK9500_E = trim$(  x9550.AutoKey_PFK9500_E)
    x9550.Dseq = trim$(  x9550.Dseq)
    x9550.DseqName = trim$(  x9550.DseqName)
    x9550.DseqTo = trim$(  x9550.DseqTo)
    x9550.seWorkFlow = trim$(  x9550.seWorkFlow)
    x9550.seCheckFlow = trim$(  x9550.seCheckFlow)
    x9550.cdCheckFlow = trim$(  x9550.cdCheckFlow)
    x9550.Seq = trim$(  x9550.Seq)
    x9550.DateAccept = trim$(  x9550.DateAccept)
    x9550.seDepartment = trim$(  x9550.seDepartment)
    x9550.cdDepartment = trim$(  x9550.cdDepartment)
    x9550.cdDepartmentName = trim$(  x9550.cdDepartmentName)
    x9550.cdTeamName = trim$(  x9550.cdTeamName)
    x9550.cdResponName = trim$(  x9550.cdResponName)
    x9550.sePosition = trim$(  x9550.sePosition)
    x9550.cdPosition = trim$(  x9550.cdPosition)
    x9550.cdPositionName = trim$(  x9550.cdPositionName)
    x9550.seIncharge = trim$(  x9550.seIncharge)
    x9550.cdIncharge = trim$(  x9550.cdIncharge)
    x9550.IDNOName = trim$(  x9550.IDNOName)
    x9550.ID = trim$(  x9550.ID)
    x9550.CheckSC = trim$(  x9550.CheckSC)
    x9550.CheckCP = trim$(  x9550.CheckCP)
    x9550.seFrequency = trim$(  x9550.seFrequency)
    x9550.cdFrequency = trim$(  x9550.cdFrequency)
    x9550.cdFrequencyName = trim$(  x9550.cdFrequencyName)
    x9550.Purpose = trim$(  x9550.Purpose)
    x9550.ActionName = trim$(  x9550.ActionName)
    x9550.Description = trim$(  x9550.Description)
    x9550.Receiver = trim$(  x9550.Receiver)
    x9550.MinJob = trim$(  x9550.MinJob)
    x9550.MaxJob = trim$(  x9550.MaxJob)
    x9550.AvgJob = trim$(  x9550.AvgJob)
    x9550.TimeJob = trim$(  x9550.TimeJob)
    x9550.Portion = trim$(  x9550.Portion)
    x9550.FilesName = trim$(  x9550.FilesName)
    x9550.JobCardList = trim$(  x9550.JobCardList)
    x9550.ReportList = trim$(  x9550.ReportList)
    x9550.ISOList = trim$(  x9550.ISOList)
    x9550.WFList = trim$(  x9550.WFList)
    x9550.MenuList = trim$(  x9550.MenuList)
    x9550.DateInsert = trim$(  x9550.DateInsert)
    x9550.DateUpdate = trim$(  x9550.DateUpdate)
    x9550.InchargeInsert = trim$(  x9550.InchargeInsert)
    x9550.InchargeUpdate = trim$(  x9550.InchargeUpdate)
    x9550.CheckUse = trim$(  x9550.CheckUse)
    x9550.DateActive = trim$(  x9550.DateActive)
    x9550.DateDeactive = trim$(  x9550.DateDeactive)
    x9550.CheckActive = trim$(  x9550.CheckActive)
    x9550.Remark = trim$(  x9550.Remark)
     
    If trim$( x9550.cdWorkFlow ) = "" Then x9550.cdWorkFlow = Space(1) 
    If trim$( x9550.AutoKey_PFK9500_S ) = "" Then x9550.AutoKey_PFK9500_S = 0 
    If trim$( x9550.AutoKey_PFK9500_E ) = "" Then x9550.AutoKey_PFK9500_E = 0 
    If trim$( x9550.Dseq ) = "" Then x9550.Dseq = 0 
    If trim$( x9550.DseqName ) = "" Then x9550.DseqName = Space(1) 
    If trim$( x9550.DseqTo ) = "" Then x9550.DseqTo = 0 
    If trim$( x9550.seWorkFlow ) = "" Then x9550.seWorkFlow = Space(1) 
    If trim$( x9550.seCheckFlow ) = "" Then x9550.seCheckFlow = Space(1) 
    If trim$( x9550.cdCheckFlow ) = "" Then x9550.cdCheckFlow = Space(1) 
    If trim$( x9550.Seq ) = "" Then x9550.Seq = Space(1) 
    If trim$( x9550.DateAccept ) = "" Then x9550.DateAccept = Space(1) 
    If trim$( x9550.seDepartment ) = "" Then x9550.seDepartment = Space(1) 
    If trim$( x9550.cdDepartment ) = "" Then x9550.cdDepartment = Space(1) 
    If trim$( x9550.cdDepartmentName ) = "" Then x9550.cdDepartmentName = Space(1) 
    If trim$( x9550.cdTeamName ) = "" Then x9550.cdTeamName = Space(1) 
    If trim$( x9550.cdResponName ) = "" Then x9550.cdResponName = Space(1) 
    If trim$( x9550.sePosition ) = "" Then x9550.sePosition = Space(1) 
    If trim$( x9550.cdPosition ) = "" Then x9550.cdPosition = Space(1) 
    If trim$( x9550.cdPositionName ) = "" Then x9550.cdPositionName = Space(1) 
    If trim$( x9550.seIncharge ) = "" Then x9550.seIncharge = Space(1) 
    If trim$( x9550.cdIncharge ) = "" Then x9550.cdIncharge = Space(1) 
    If trim$( x9550.IDNOName ) = "" Then x9550.IDNOName = Space(1) 
    If trim$( x9550.ID ) = "" Then x9550.ID = Space(1) 
    If trim$( x9550.CheckSC ) = "" Then x9550.CheckSC = Space(1) 
    If trim$( x9550.CheckCP ) = "" Then x9550.CheckCP = Space(1) 
    If trim$( x9550.seFrequency ) = "" Then x9550.seFrequency = Space(1) 
    If trim$( x9550.cdFrequency ) = "" Then x9550.cdFrequency = Space(1) 
    If trim$( x9550.cdFrequencyName ) = "" Then x9550.cdFrequencyName = Space(1) 
    If trim$( x9550.Purpose ) = "" Then x9550.Purpose = Space(1) 
    If trim$( x9550.ActionName ) = "" Then x9550.ActionName = Space(1) 
    If trim$( x9550.Description ) = "" Then x9550.Description = Space(1) 
    If trim$( x9550.Receiver ) = "" Then x9550.Receiver = Space(1) 
    If trim$( x9550.MinJob ) = "" Then x9550.MinJob = Space(1) 
    If trim$( x9550.MaxJob ) = "" Then x9550.MaxJob = Space(1) 
    If trim$( x9550.AvgJob ) = "" Then x9550.AvgJob = Space(1) 
    If trim$( x9550.TimeJob ) = "" Then x9550.TimeJob = Space(1) 
    If trim$( x9550.Portion ) = "" Then x9550.Portion = Space(1) 
    If trim$( x9550.FilesName ) = "" Then x9550.FilesName = Space(1) 
    If trim$( x9550.JobCardList ) = "" Then x9550.JobCardList = Space(1) 
    If trim$( x9550.ReportList ) = "" Then x9550.ReportList = Space(1) 
    If trim$( x9550.ISOList ) = "" Then x9550.ISOList = Space(1) 
    If trim$( x9550.WFList ) = "" Then x9550.WFList = Space(1) 
    If trim$( x9550.MenuList ) = "" Then x9550.MenuList = Space(1) 
    If trim$( x9550.DateInsert ) = "" Then x9550.DateInsert = Space(1) 
    If trim$( x9550.DateUpdate ) = "" Then x9550.DateUpdate = Space(1) 
    If trim$( x9550.InchargeInsert ) = "" Then x9550.InchargeInsert = Space(1) 
    If trim$( x9550.InchargeUpdate ) = "" Then x9550.InchargeUpdate = Space(1) 
    If trim$( x9550.CheckUse ) = "" Then x9550.CheckUse = Space(1) 
    If trim$( x9550.DateActive ) = "" Then x9550.DateActive = Space(1) 
    If trim$( x9550.DateDeactive ) = "" Then x9550.DateDeactive = Space(1) 
    If trim$( x9550.CheckActive ) = "" Then x9550.CheckActive = Space(1) 
    If trim$( x9550.Remark ) = "" Then x9550.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K9550_MOVE(rs9550 As SqlClient.SqlDataReader)
Try

    call D9550_CLEAR()   

    If IsdbNull(rs9550!K9550_cdWorkFlow) = False Then D9550.cdWorkFlow = Trim$(rs9550!K9550_cdWorkFlow)
    If IsdbNull(rs9550!K9550_AutoKey_PFK9500_S) = False Then D9550.AutoKey_PFK9500_S = Trim$(rs9550!K9550_AutoKey_PFK9500_S)
    If IsdbNull(rs9550!K9550_AutoKey_PFK9500_E) = False Then D9550.AutoKey_PFK9500_E = Trim$(rs9550!K9550_AutoKey_PFK9500_E)
    If IsdbNull(rs9550!K9550_Dseq) = False Then D9550.Dseq = Trim$(rs9550!K9550_Dseq)
    If IsdbNull(rs9550!K9550_DseqName) = False Then D9550.DseqName = Trim$(rs9550!K9550_DseqName)
    If IsdbNull(rs9550!K9550_DseqTo) = False Then D9550.DseqTo = Trim$(rs9550!K9550_DseqTo)
    If IsdbNull(rs9550!K9550_seWorkFlow) = False Then D9550.seWorkFlow = Trim$(rs9550!K9550_seWorkFlow)
    If IsdbNull(rs9550!K9550_seCheckFlow) = False Then D9550.seCheckFlow = Trim$(rs9550!K9550_seCheckFlow)
    If IsdbNull(rs9550!K9550_cdCheckFlow) = False Then D9550.cdCheckFlow = Trim$(rs9550!K9550_cdCheckFlow)
    If IsdbNull(rs9550!K9550_Seq) = False Then D9550.Seq = Trim$(rs9550!K9550_Seq)
    If IsdbNull(rs9550!K9550_DateAccept) = False Then D9550.DateAccept = Trim$(rs9550!K9550_DateAccept)
    If IsdbNull(rs9550!K9550_seDepartment) = False Then D9550.seDepartment = Trim$(rs9550!K9550_seDepartment)
    If IsdbNull(rs9550!K9550_cdDepartment) = False Then D9550.cdDepartment = Trim$(rs9550!K9550_cdDepartment)
    If IsdbNull(rs9550!K9550_cdDepartmentName) = False Then D9550.cdDepartmentName = Trim$(rs9550!K9550_cdDepartmentName)
    If IsdbNull(rs9550!K9550_cdTeamName) = False Then D9550.cdTeamName = Trim$(rs9550!K9550_cdTeamName)
    If IsdbNull(rs9550!K9550_cdResponName) = False Then D9550.cdResponName = Trim$(rs9550!K9550_cdResponName)
    If IsdbNull(rs9550!K9550_sePosition) = False Then D9550.sePosition = Trim$(rs9550!K9550_sePosition)
    If IsdbNull(rs9550!K9550_cdPosition) = False Then D9550.cdPosition = Trim$(rs9550!K9550_cdPosition)
    If IsdbNull(rs9550!K9550_cdPositionName) = False Then D9550.cdPositionName = Trim$(rs9550!K9550_cdPositionName)
    If IsdbNull(rs9550!K9550_seIncharge) = False Then D9550.seIncharge = Trim$(rs9550!K9550_seIncharge)
    If IsdbNull(rs9550!K9550_cdIncharge) = False Then D9550.cdIncharge = Trim$(rs9550!K9550_cdIncharge)
    If IsdbNull(rs9550!K9550_IDNOName) = False Then D9550.IDNOName = Trim$(rs9550!K9550_IDNOName)
    If IsdbNull(rs9550!K9550_ID) = False Then D9550.ID = Trim$(rs9550!K9550_ID)
    If IsdbNull(rs9550!K9550_CheckSC) = False Then D9550.CheckSC = Trim$(rs9550!K9550_CheckSC)
    If IsdbNull(rs9550!K9550_CheckCP) = False Then D9550.CheckCP = Trim$(rs9550!K9550_CheckCP)
    If IsdbNull(rs9550!K9550_seFrequency) = False Then D9550.seFrequency = Trim$(rs9550!K9550_seFrequency)
    If IsdbNull(rs9550!K9550_cdFrequency) = False Then D9550.cdFrequency = Trim$(rs9550!K9550_cdFrequency)
    If IsdbNull(rs9550!K9550_cdFrequencyName) = False Then D9550.cdFrequencyName = Trim$(rs9550!K9550_cdFrequencyName)
    If IsdbNull(rs9550!K9550_Purpose) = False Then D9550.Purpose = Trim$(rs9550!K9550_Purpose)
    If IsdbNull(rs9550!K9550_ActionName) = False Then D9550.ActionName = Trim$(rs9550!K9550_ActionName)
    If IsdbNull(rs9550!K9550_Description) = False Then D9550.Description = Trim$(rs9550!K9550_Description)
    If IsdbNull(rs9550!K9550_Receiver) = False Then D9550.Receiver = Trim$(rs9550!K9550_Receiver)
    If IsdbNull(rs9550!K9550_MinJob) = False Then D9550.MinJob = Trim$(rs9550!K9550_MinJob)
    If IsdbNull(rs9550!K9550_MaxJob) = False Then D9550.MaxJob = Trim$(rs9550!K9550_MaxJob)
    If IsdbNull(rs9550!K9550_AvgJob) = False Then D9550.AvgJob = Trim$(rs9550!K9550_AvgJob)
    If IsdbNull(rs9550!K9550_TimeJob) = False Then D9550.TimeJob = Trim$(rs9550!K9550_TimeJob)
    If IsdbNull(rs9550!K9550_Portion) = False Then D9550.Portion = Trim$(rs9550!K9550_Portion)
    If IsdbNull(rs9550!K9550_FilesName) = False Then D9550.FilesName = Trim$(rs9550!K9550_FilesName)
    If IsdbNull(rs9550!K9550_JobCardList) = False Then D9550.JobCardList = Trim$(rs9550!K9550_JobCardList)
    If IsdbNull(rs9550!K9550_ReportList) = False Then D9550.ReportList = Trim$(rs9550!K9550_ReportList)
    If IsdbNull(rs9550!K9550_ISOList) = False Then D9550.ISOList = Trim$(rs9550!K9550_ISOList)
    If IsdbNull(rs9550!K9550_WFList) = False Then D9550.WFList = Trim$(rs9550!K9550_WFList)
    If IsdbNull(rs9550!K9550_MenuList) = False Then D9550.MenuList = Trim$(rs9550!K9550_MenuList)
    If IsdbNull(rs9550!K9550_DateInsert) = False Then D9550.DateInsert = Trim$(rs9550!K9550_DateInsert)
    If IsdbNull(rs9550!K9550_DateUpdate) = False Then D9550.DateUpdate = Trim$(rs9550!K9550_DateUpdate)
    If IsdbNull(rs9550!K9550_InchargeInsert) = False Then D9550.InchargeInsert = Trim$(rs9550!K9550_InchargeInsert)
    If IsdbNull(rs9550!K9550_InchargeUpdate) = False Then D9550.InchargeUpdate = Trim$(rs9550!K9550_InchargeUpdate)
    If IsdbNull(rs9550!K9550_CheckUse) = False Then D9550.CheckUse = Trim$(rs9550!K9550_CheckUse)
    If IsdbNull(rs9550!K9550_DateActive) = False Then D9550.DateActive = Trim$(rs9550!K9550_DateActive)
    If IsdbNull(rs9550!K9550_DateDeactive) = False Then D9550.DateDeactive = Trim$(rs9550!K9550_DateDeactive)
    If IsdbNull(rs9550!K9550_CheckActive) = False Then D9550.CheckActive = Trim$(rs9550!K9550_CheckActive)
    If IsdbNull(rs9550!K9550_Remark) = False Then D9550.Remark = Trim$(rs9550!K9550_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9550_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K9550_MOVE(rs9550 As DataRow)
Try

    call D9550_CLEAR()   

    If IsdbNull(rs9550!K9550_cdWorkFlow) = False Then D9550.cdWorkFlow = Trim$(rs9550!K9550_cdWorkFlow)
    If IsdbNull(rs9550!K9550_AutoKey_PFK9500_S) = False Then D9550.AutoKey_PFK9500_S = Trim$(rs9550!K9550_AutoKey_PFK9500_S)
    If IsdbNull(rs9550!K9550_AutoKey_PFK9500_E) = False Then D9550.AutoKey_PFK9500_E = Trim$(rs9550!K9550_AutoKey_PFK9500_E)
    If IsdbNull(rs9550!K9550_Dseq) = False Then D9550.Dseq = Trim$(rs9550!K9550_Dseq)
    If IsdbNull(rs9550!K9550_DseqName) = False Then D9550.DseqName = Trim$(rs9550!K9550_DseqName)
    If IsdbNull(rs9550!K9550_DseqTo) = False Then D9550.DseqTo = Trim$(rs9550!K9550_DseqTo)
    If IsdbNull(rs9550!K9550_seWorkFlow) = False Then D9550.seWorkFlow = Trim$(rs9550!K9550_seWorkFlow)
    If IsdbNull(rs9550!K9550_seCheckFlow) = False Then D9550.seCheckFlow = Trim$(rs9550!K9550_seCheckFlow)
    If IsdbNull(rs9550!K9550_cdCheckFlow) = False Then D9550.cdCheckFlow = Trim$(rs9550!K9550_cdCheckFlow)
    If IsdbNull(rs9550!K9550_Seq) = False Then D9550.Seq = Trim$(rs9550!K9550_Seq)
    If IsdbNull(rs9550!K9550_DateAccept) = False Then D9550.DateAccept = Trim$(rs9550!K9550_DateAccept)
    If IsdbNull(rs9550!K9550_seDepartment) = False Then D9550.seDepartment = Trim$(rs9550!K9550_seDepartment)
    If IsdbNull(rs9550!K9550_cdDepartment) = False Then D9550.cdDepartment = Trim$(rs9550!K9550_cdDepartment)
    If IsdbNull(rs9550!K9550_cdDepartmentName) = False Then D9550.cdDepartmentName = Trim$(rs9550!K9550_cdDepartmentName)
    If IsdbNull(rs9550!K9550_cdTeamName) = False Then D9550.cdTeamName = Trim$(rs9550!K9550_cdTeamName)
    If IsdbNull(rs9550!K9550_cdResponName) = False Then D9550.cdResponName = Trim$(rs9550!K9550_cdResponName)
    If IsdbNull(rs9550!K9550_sePosition) = False Then D9550.sePosition = Trim$(rs9550!K9550_sePosition)
    If IsdbNull(rs9550!K9550_cdPosition) = False Then D9550.cdPosition = Trim$(rs9550!K9550_cdPosition)
    If IsdbNull(rs9550!K9550_cdPositionName) = False Then D9550.cdPositionName = Trim$(rs9550!K9550_cdPositionName)
    If IsdbNull(rs9550!K9550_seIncharge) = False Then D9550.seIncharge = Trim$(rs9550!K9550_seIncharge)
    If IsdbNull(rs9550!K9550_cdIncharge) = False Then D9550.cdIncharge = Trim$(rs9550!K9550_cdIncharge)
    If IsdbNull(rs9550!K9550_IDNOName) = False Then D9550.IDNOName = Trim$(rs9550!K9550_IDNOName)
    If IsdbNull(rs9550!K9550_ID) = False Then D9550.ID = Trim$(rs9550!K9550_ID)
    If IsdbNull(rs9550!K9550_CheckSC) = False Then D9550.CheckSC = Trim$(rs9550!K9550_CheckSC)
    If IsdbNull(rs9550!K9550_CheckCP) = False Then D9550.CheckCP = Trim$(rs9550!K9550_CheckCP)
    If IsdbNull(rs9550!K9550_seFrequency) = False Then D9550.seFrequency = Trim$(rs9550!K9550_seFrequency)
    If IsdbNull(rs9550!K9550_cdFrequency) = False Then D9550.cdFrequency = Trim$(rs9550!K9550_cdFrequency)
    If IsdbNull(rs9550!K9550_cdFrequencyName) = False Then D9550.cdFrequencyName = Trim$(rs9550!K9550_cdFrequencyName)
    If IsdbNull(rs9550!K9550_Purpose) = False Then D9550.Purpose = Trim$(rs9550!K9550_Purpose)
    If IsdbNull(rs9550!K9550_ActionName) = False Then D9550.ActionName = Trim$(rs9550!K9550_ActionName)
    If IsdbNull(rs9550!K9550_Description) = False Then D9550.Description = Trim$(rs9550!K9550_Description)
    If IsdbNull(rs9550!K9550_Receiver) = False Then D9550.Receiver = Trim$(rs9550!K9550_Receiver)
    If IsdbNull(rs9550!K9550_MinJob) = False Then D9550.MinJob = Trim$(rs9550!K9550_MinJob)
    If IsdbNull(rs9550!K9550_MaxJob) = False Then D9550.MaxJob = Trim$(rs9550!K9550_MaxJob)
    If IsdbNull(rs9550!K9550_AvgJob) = False Then D9550.AvgJob = Trim$(rs9550!K9550_AvgJob)
    If IsdbNull(rs9550!K9550_TimeJob) = False Then D9550.TimeJob = Trim$(rs9550!K9550_TimeJob)
    If IsdbNull(rs9550!K9550_Portion) = False Then D9550.Portion = Trim$(rs9550!K9550_Portion)
    If IsdbNull(rs9550!K9550_FilesName) = False Then D9550.FilesName = Trim$(rs9550!K9550_FilesName)
    If IsdbNull(rs9550!K9550_JobCardList) = False Then D9550.JobCardList = Trim$(rs9550!K9550_JobCardList)
    If IsdbNull(rs9550!K9550_ReportList) = False Then D9550.ReportList = Trim$(rs9550!K9550_ReportList)
    If IsdbNull(rs9550!K9550_ISOList) = False Then D9550.ISOList = Trim$(rs9550!K9550_ISOList)
    If IsdbNull(rs9550!K9550_WFList) = False Then D9550.WFList = Trim$(rs9550!K9550_WFList)
    If IsdbNull(rs9550!K9550_MenuList) = False Then D9550.MenuList = Trim$(rs9550!K9550_MenuList)
    If IsdbNull(rs9550!K9550_DateInsert) = False Then D9550.DateInsert = Trim$(rs9550!K9550_DateInsert)
    If IsdbNull(rs9550!K9550_DateUpdate) = False Then D9550.DateUpdate = Trim$(rs9550!K9550_DateUpdate)
    If IsdbNull(rs9550!K9550_InchargeInsert) = False Then D9550.InchargeInsert = Trim$(rs9550!K9550_InchargeInsert)
    If IsdbNull(rs9550!K9550_InchargeUpdate) = False Then D9550.InchargeUpdate = Trim$(rs9550!K9550_InchargeUpdate)
    If IsdbNull(rs9550!K9550_CheckUse) = False Then D9550.CheckUse = Trim$(rs9550!K9550_CheckUse)
    If IsdbNull(rs9550!K9550_DateActive) = False Then D9550.DateActive = Trim$(rs9550!K9550_DateActive)
    If IsdbNull(rs9550!K9550_DateDeactive) = False Then D9550.DateDeactive = Trim$(rs9550!K9550_DateDeactive)
    If IsdbNull(rs9550!K9550_CheckActive) = False Then D9550.CheckActive = Trim$(rs9550!K9550_CheckActive)
    If IsdbNull(rs9550!K9550_Remark) = False Then D9550.Remark = Trim$(rs9550!K9550_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9550_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K9550_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9550 As T9550_AREA, CDWORKFLOW AS String, AUTOKEY_PFK9500_S AS Double) as Boolean

K9550_MOVE = False

Try
    If READ_PFK9550(CDWORKFLOW, AUTOKEY_PFK9500_S) = True Then
                z9550 = D9550
		K9550_MOVE = True
		else
	z9550 = nothing
     End If

     If  getColumIndex(spr,"cdWorkFlow") > -1 then z9550.cdWorkFlow = getDataM(spr, getColumIndex(spr,"cdWorkFlow"), xRow)
     If  getColumIndex(spr,"AutoKey_PFK9500_S") > -1 then z9550.AutoKey_PFK9500_S = getDataM(spr, getColumIndex(spr,"AutoKey_PFK9500_S"), xRow)
     If  getColumIndex(spr,"AutoKey_PFK9500_E") > -1 then z9550.AutoKey_PFK9500_E = getDataM(spr, getColumIndex(spr,"AutoKey_PFK9500_E"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z9550.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"DseqName") > -1 then z9550.DseqName = getDataM(spr, getColumIndex(spr,"DseqName"), xRow)
     If  getColumIndex(spr,"DseqTo") > -1 then z9550.DseqTo = getDataM(spr, getColumIndex(spr,"DseqTo"), xRow)
     If  getColumIndex(spr,"seWorkFlow") > -1 then z9550.seWorkFlow = getDataM(spr, getColumIndex(spr,"seWorkFlow"), xRow)
     If  getColumIndex(spr,"seCheckFlow") > -1 then z9550.seCheckFlow = getDataM(spr, getColumIndex(spr,"seCheckFlow"), xRow)
     If  getColumIndex(spr,"cdCheckFlow") > -1 then z9550.cdCheckFlow = getDataM(spr, getColumIndex(spr,"cdCheckFlow"), xRow)
     If  getColumIndex(spr,"Seq") > -1 then z9550.Seq = getDataM(spr, getColumIndex(spr,"Seq"), xRow)
     If  getColumIndex(spr,"DateAccept") > -1 then z9550.DateAccept = getDataM(spr, getColumIndex(spr,"DateAccept"), xRow)
     If  getColumIndex(spr,"seDepartment") > -1 then z9550.seDepartment = getDataM(spr, getColumIndex(spr,"seDepartment"), xRow)
     If  getColumIndex(spr,"cdDepartment") > -1 then z9550.cdDepartment = getDataM(spr, getColumIndex(spr,"cdDepartment"), xRow)
     If  getColumIndex(spr,"cdDepartmentName") > -1 then z9550.cdDepartmentName = getDataM(spr, getColumIndex(spr,"cdDepartmentName"), xRow)
     If  getColumIndex(spr,"cdTeamName") > -1 then z9550.cdTeamName = getDataM(spr, getColumIndex(spr,"cdTeamName"), xRow)
     If  getColumIndex(spr,"cdResponName") > -1 then z9550.cdResponName = getDataM(spr, getColumIndex(spr,"cdResponName"), xRow)
     If  getColumIndex(spr,"sePosition") > -1 then z9550.sePosition = getDataM(spr, getColumIndex(spr,"sePosition"), xRow)
     If  getColumIndex(spr,"cdPosition") > -1 then z9550.cdPosition = getDataM(spr, getColumIndex(spr,"cdPosition"), xRow)
     If  getColumIndex(spr,"cdPositionName") > -1 then z9550.cdPositionName = getDataM(spr, getColumIndex(spr,"cdPositionName"), xRow)
     If  getColumIndex(spr,"seIncharge") > -1 then z9550.seIncharge = getDataM(spr, getColumIndex(spr,"seIncharge"), xRow)
     If  getColumIndex(spr,"cdIncharge") > -1 then z9550.cdIncharge = getDataM(spr, getColumIndex(spr,"cdIncharge"), xRow)
     If  getColumIndex(spr,"IDNOName") > -1 then z9550.IDNOName = getDataM(spr, getColumIndex(spr,"IDNOName"), xRow)
     If  getColumIndex(spr,"ID") > -1 then z9550.ID = getDataM(spr, getColumIndex(spr,"ID"), xRow)
     If  getColumIndex(spr,"CheckSC") > -1 then z9550.CheckSC = getDataM(spr, getColumIndex(spr,"CheckSC"), xRow)
     If  getColumIndex(spr,"CheckCP") > -1 then z9550.CheckCP = getDataM(spr, getColumIndex(spr,"CheckCP"), xRow)
     If  getColumIndex(spr,"seFrequency") > -1 then z9550.seFrequency = getDataM(spr, getColumIndex(spr,"seFrequency"), xRow)
     If  getColumIndex(spr,"cdFrequency") > -1 then z9550.cdFrequency = getDataM(spr, getColumIndex(spr,"cdFrequency"), xRow)
     If  getColumIndex(spr,"cdFrequencyName") > -1 then z9550.cdFrequencyName = getDataM(spr, getColumIndex(spr,"cdFrequencyName"), xRow)
     If  getColumIndex(spr,"Purpose") > -1 then z9550.Purpose = getDataM(spr, getColumIndex(spr,"Purpose"), xRow)
     If  getColumIndex(spr,"ActionName") > -1 then z9550.ActionName = getDataM(spr, getColumIndex(spr,"ActionName"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z9550.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"Receiver") > -1 then z9550.Receiver = getDataM(spr, getColumIndex(spr,"Receiver"), xRow)
     If  getColumIndex(spr,"MinJob") > -1 then z9550.MinJob = getDataM(spr, getColumIndex(spr,"MinJob"), xRow)
     If  getColumIndex(spr,"MaxJob") > -1 then z9550.MaxJob = getDataM(spr, getColumIndex(spr,"MaxJob"), xRow)
     If  getColumIndex(spr,"AvgJob") > -1 then z9550.AvgJob = getDataM(spr, getColumIndex(spr,"AvgJob"), xRow)
     If  getColumIndex(spr,"TimeJob") > -1 then z9550.TimeJob = getDataM(spr, getColumIndex(spr,"TimeJob"), xRow)
     If  getColumIndex(spr,"Portion") > -1 then z9550.Portion = getDataM(spr, getColumIndex(spr,"Portion"), xRow)
     If  getColumIndex(spr,"FilesName") > -1 then z9550.FilesName = getDataM(spr, getColumIndex(spr,"FilesName"), xRow)
     If  getColumIndex(spr,"JobCardList") > -1 then z9550.JobCardList = getDataM(spr, getColumIndex(spr,"JobCardList"), xRow)
     If  getColumIndex(spr,"ReportList") > -1 then z9550.ReportList = getDataM(spr, getColumIndex(spr,"ReportList"), xRow)
     If  getColumIndex(spr,"ISOList") > -1 then z9550.ISOList = getDataM(spr, getColumIndex(spr,"ISOList"), xRow)
     If  getColumIndex(spr,"WFList") > -1 then z9550.WFList = getDataM(spr, getColumIndex(spr,"WFList"), xRow)
     If  getColumIndex(spr,"MenuList") > -1 then z9550.MenuList = getDataM(spr, getColumIndex(spr,"MenuList"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z9550.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z9550.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z9550.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z9550.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z9550.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"DateActive") > -1 then z9550.DateActive = getDataM(spr, getColumIndex(spr,"DateActive"), xRow)
     If  getColumIndex(spr,"DateDeactive") > -1 then z9550.DateDeactive = getDataM(spr, getColumIndex(spr,"DateDeactive"), xRow)
     If  getColumIndex(spr,"CheckActive") > -1 then z9550.CheckActive = getDataM(spr, getColumIndex(spr,"CheckActive"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z9550.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K9550_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K9550_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9550 As T9550_AREA,CheckClear as Boolean,CDWORKFLOW AS String, AUTOKEY_PFK9500_S AS Double) as Boolean

K9550_MOVE = False

Try
    If READ_PFK9550(CDWORKFLOW, AUTOKEY_PFK9500_S) = True Then
                z9550 = D9550
		K9550_MOVE = True
		else
	If CheckClear  = True then z9550 = nothing
     End If

     If  getColumIndex(spr,"cdWorkFlow") > -1 then z9550.cdWorkFlow = getDataM(spr, getColumIndex(spr,"cdWorkFlow"), xRow)
     If  getColumIndex(spr,"AutoKey_PFK9500_S") > -1 then z9550.AutoKey_PFK9500_S = getDataM(spr, getColumIndex(spr,"AutoKey_PFK9500_S"), xRow)
     If  getColumIndex(spr,"AutoKey_PFK9500_E") > -1 then z9550.AutoKey_PFK9500_E = getDataM(spr, getColumIndex(spr,"AutoKey_PFK9500_E"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z9550.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"DseqName") > -1 then z9550.DseqName = getDataM(spr, getColumIndex(spr,"DseqName"), xRow)
     If  getColumIndex(spr,"DseqTo") > -1 then z9550.DseqTo = getDataM(spr, getColumIndex(spr,"DseqTo"), xRow)
     If  getColumIndex(spr,"seWorkFlow") > -1 then z9550.seWorkFlow = getDataM(spr, getColumIndex(spr,"seWorkFlow"), xRow)
     If  getColumIndex(spr,"seCheckFlow") > -1 then z9550.seCheckFlow = getDataM(spr, getColumIndex(spr,"seCheckFlow"), xRow)
     If  getColumIndex(spr,"cdCheckFlow") > -1 then z9550.cdCheckFlow = getDataM(spr, getColumIndex(spr,"cdCheckFlow"), xRow)
     If  getColumIndex(spr,"Seq") > -1 then z9550.Seq = getDataM(spr, getColumIndex(spr,"Seq"), xRow)
     If  getColumIndex(spr,"DateAccept") > -1 then z9550.DateAccept = getDataM(spr, getColumIndex(spr,"DateAccept"), xRow)
     If  getColumIndex(spr,"seDepartment") > -1 then z9550.seDepartment = getDataM(spr, getColumIndex(spr,"seDepartment"), xRow)
     If  getColumIndex(spr,"cdDepartment") > -1 then z9550.cdDepartment = getDataM(spr, getColumIndex(spr,"cdDepartment"), xRow)
     If  getColumIndex(spr,"cdDepartmentName") > -1 then z9550.cdDepartmentName = getDataM(spr, getColumIndex(spr,"cdDepartmentName"), xRow)
     If  getColumIndex(spr,"cdTeamName") > -1 then z9550.cdTeamName = getDataM(spr, getColumIndex(spr,"cdTeamName"), xRow)
     If  getColumIndex(spr,"cdResponName") > -1 then z9550.cdResponName = getDataM(spr, getColumIndex(spr,"cdResponName"), xRow)
     If  getColumIndex(spr,"sePosition") > -1 then z9550.sePosition = getDataM(spr, getColumIndex(spr,"sePosition"), xRow)
     If  getColumIndex(spr,"cdPosition") > -1 then z9550.cdPosition = getDataM(spr, getColumIndex(spr,"cdPosition"), xRow)
     If  getColumIndex(spr,"cdPositionName") > -1 then z9550.cdPositionName = getDataM(spr, getColumIndex(spr,"cdPositionName"), xRow)
     If  getColumIndex(spr,"seIncharge") > -1 then z9550.seIncharge = getDataM(spr, getColumIndex(spr,"seIncharge"), xRow)
     If  getColumIndex(spr,"cdIncharge") > -1 then z9550.cdIncharge = getDataM(spr, getColumIndex(spr,"cdIncharge"), xRow)
     If  getColumIndex(spr,"IDNOName") > -1 then z9550.IDNOName = getDataM(spr, getColumIndex(spr,"IDNOName"), xRow)
     If  getColumIndex(spr,"ID") > -1 then z9550.ID = getDataM(spr, getColumIndex(spr,"ID"), xRow)
     If  getColumIndex(spr,"CheckSC") > -1 then z9550.CheckSC = getDataM(spr, getColumIndex(spr,"CheckSC"), xRow)
     If  getColumIndex(spr,"CheckCP") > -1 then z9550.CheckCP = getDataM(spr, getColumIndex(spr,"CheckCP"), xRow)
     If  getColumIndex(spr,"seFrequency") > -1 then z9550.seFrequency = getDataM(spr, getColumIndex(spr,"seFrequency"), xRow)
     If  getColumIndex(spr,"cdFrequency") > -1 then z9550.cdFrequency = getDataM(spr, getColumIndex(spr,"cdFrequency"), xRow)
     If  getColumIndex(spr,"cdFrequencyName") > -1 then z9550.cdFrequencyName = getDataM(spr, getColumIndex(spr,"cdFrequencyName"), xRow)
     If  getColumIndex(spr,"Purpose") > -1 then z9550.Purpose = getDataM(spr, getColumIndex(spr,"Purpose"), xRow)
     If  getColumIndex(spr,"ActionName") > -1 then z9550.ActionName = getDataM(spr, getColumIndex(spr,"ActionName"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z9550.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"Receiver") > -1 then z9550.Receiver = getDataM(spr, getColumIndex(spr,"Receiver"), xRow)
     If  getColumIndex(spr,"MinJob") > -1 then z9550.MinJob = getDataM(spr, getColumIndex(spr,"MinJob"), xRow)
     If  getColumIndex(spr,"MaxJob") > -1 then z9550.MaxJob = getDataM(spr, getColumIndex(spr,"MaxJob"), xRow)
     If  getColumIndex(spr,"AvgJob") > -1 then z9550.AvgJob = getDataM(spr, getColumIndex(spr,"AvgJob"), xRow)
     If  getColumIndex(spr,"TimeJob") > -1 then z9550.TimeJob = getDataM(spr, getColumIndex(spr,"TimeJob"), xRow)
     If  getColumIndex(spr,"Portion") > -1 then z9550.Portion = getDataM(spr, getColumIndex(spr,"Portion"), xRow)
     If  getColumIndex(spr,"FilesName") > -1 then z9550.FilesName = getDataM(spr, getColumIndex(spr,"FilesName"), xRow)
     If  getColumIndex(spr,"JobCardList") > -1 then z9550.JobCardList = getDataM(spr, getColumIndex(spr,"JobCardList"), xRow)
     If  getColumIndex(spr,"ReportList") > -1 then z9550.ReportList = getDataM(spr, getColumIndex(spr,"ReportList"), xRow)
     If  getColumIndex(spr,"ISOList") > -1 then z9550.ISOList = getDataM(spr, getColumIndex(spr,"ISOList"), xRow)
     If  getColumIndex(spr,"WFList") > -1 then z9550.WFList = getDataM(spr, getColumIndex(spr,"WFList"), xRow)
     If  getColumIndex(spr,"MenuList") > -1 then z9550.MenuList = getDataM(spr, getColumIndex(spr,"MenuList"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z9550.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z9550.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z9550.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z9550.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z9550.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"DateActive") > -1 then z9550.DateActive = getDataM(spr, getColumIndex(spr,"DateActive"), xRow)
     If  getColumIndex(spr,"DateDeactive") > -1 then z9550.DateDeactive = getDataM(spr, getColumIndex(spr,"DateDeactive"), xRow)
     If  getColumIndex(spr,"CheckActive") > -1 then z9550.CheckActive = getDataM(spr, getColumIndex(spr,"CheckActive"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z9550.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K9550_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K9550_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9550 As T9550_AREA, Job as String, CDWORKFLOW AS String, AUTOKEY_PFK9500_S AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9550_MOVE = False

Try
    If READ_PFK9550(CDWORKFLOW, AUTOKEY_PFK9500_S) = True Then
                z9550 = D9550
		K9550_MOVE = True
		else
	z9550 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9550")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "CDWORKFLOW":z9550.cdWorkFlow = Children(i).Code
   Case "AUTOKEY_PFK9500_S":z9550.AutoKey_PFK9500_S = Children(i).Code
   Case "AUTOKEY_PFK9500_E":z9550.AutoKey_PFK9500_E = Children(i).Code
   Case "DSEQ":z9550.Dseq = Children(i).Code
   Case "DSEQNAME":z9550.DseqName = Children(i).Code
   Case "DSEQTO":z9550.DseqTo = Children(i).Code
   Case "SEWORKFLOW":z9550.seWorkFlow = Children(i).Code
   Case "SECHECKFLOW":z9550.seCheckFlow = Children(i).Code
   Case "CDCHECKFLOW":z9550.cdCheckFlow = Children(i).Code
   Case "SEQ":z9550.Seq = Children(i).Code
   Case "DATEACCEPT":z9550.DateAccept = Children(i).Code
   Case "SEDEPARTMENT":z9550.seDepartment = Children(i).Code
   Case "CDDEPARTMENT":z9550.cdDepartment = Children(i).Code
   Case "CDDEPARTMENTNAME":z9550.cdDepartmentName = Children(i).Code
   Case "CDTEAMNAME":z9550.cdTeamName = Children(i).Code
   Case "CDRESPONNAME":z9550.cdResponName = Children(i).Code
   Case "SEPOSITION":z9550.sePosition = Children(i).Code
   Case "CDPOSITION":z9550.cdPosition = Children(i).Code
   Case "CDPOSITIONNAME":z9550.cdPositionName = Children(i).Code
   Case "SEINCHARGE":z9550.seIncharge = Children(i).Code
   Case "CDINCHARGE":z9550.cdIncharge = Children(i).Code
   Case "IDNONAME":z9550.IDNOName = Children(i).Code
   Case "ID":z9550.ID = Children(i).Code
   Case "CHECKSC":z9550.CheckSC = Children(i).Code
   Case "CHECKCP":z9550.CheckCP = Children(i).Code
   Case "SEFREQUENCY":z9550.seFrequency = Children(i).Code
   Case "CDFREQUENCY":z9550.cdFrequency = Children(i).Code
   Case "CDFREQUENCYNAME":z9550.cdFrequencyName = Children(i).Code
   Case "PURPOSE":z9550.Purpose = Children(i).Code
   Case "ACTIONNAME":z9550.ActionName = Children(i).Code
   Case "DESCRIPTION":z9550.Description = Children(i).Code
   Case "RECEIVER":z9550.Receiver = Children(i).Code
   Case "MINJOB":z9550.MinJob = Children(i).Code
   Case "MAXJOB":z9550.MaxJob = Children(i).Code
   Case "AVGJOB":z9550.AvgJob = Children(i).Code
   Case "TIMEJOB":z9550.TimeJob = Children(i).Code
   Case "PORTION":z9550.Portion = Children(i).Code
   Case "FILESNAME":z9550.FilesName = Children(i).Code
   Case "JOBCARDLIST":z9550.JobCardList = Children(i).Code
   Case "REPORTLIST":z9550.ReportList = Children(i).Code
   Case "ISOLIST":z9550.ISOList = Children(i).Code
   Case "WFLIST":z9550.WFList = Children(i).Code
   Case "MENULIST":z9550.MenuList = Children(i).Code
   Case "DATEINSERT":z9550.DateInsert = Children(i).Code
   Case "DATEUPDATE":z9550.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z9550.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z9550.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z9550.CheckUse = Children(i).Code
   Case "DATEACTIVE":z9550.DateActive = Children(i).Code
   Case "DATEDEACTIVE":z9550.DateDeactive = Children(i).Code
   Case "CHECKACTIVE":z9550.CheckActive = Children(i).Code
   Case "REMARK":z9550.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "CDWORKFLOW":z9550.cdWorkFlow = Children(i).Data
   Case "AUTOKEY_PFK9500_S":z9550.AutoKey_PFK9500_S = Children(i).Data
   Case "AUTOKEY_PFK9500_E":z9550.AutoKey_PFK9500_E = Children(i).Data
   Case "DSEQ":z9550.Dseq = Children(i).Data
   Case "DSEQNAME":z9550.DseqName = Children(i).Data
   Case "DSEQTO":z9550.DseqTo = Children(i).Data
   Case "SEWORKFLOW":z9550.seWorkFlow = Children(i).Data
   Case "SECHECKFLOW":z9550.seCheckFlow = Children(i).Data
   Case "CDCHECKFLOW":z9550.cdCheckFlow = Children(i).Data
   Case "SEQ":z9550.Seq = Children(i).Data
   Case "DATEACCEPT":z9550.DateAccept = Children(i).Data
   Case "SEDEPARTMENT":z9550.seDepartment = Children(i).Data
   Case "CDDEPARTMENT":z9550.cdDepartment = Children(i).Data
   Case "CDDEPARTMENTNAME":z9550.cdDepartmentName = Children(i).Data
   Case "CDTEAMNAME":z9550.cdTeamName = Children(i).Data
   Case "CDRESPONNAME":z9550.cdResponName = Children(i).Data
   Case "SEPOSITION":z9550.sePosition = Children(i).Data
   Case "CDPOSITION":z9550.cdPosition = Children(i).Data
   Case "CDPOSITIONNAME":z9550.cdPositionName = Children(i).Data
   Case "SEINCHARGE":z9550.seIncharge = Children(i).Data
   Case "CDINCHARGE":z9550.cdIncharge = Children(i).Data
   Case "IDNONAME":z9550.IDNOName = Children(i).Data
   Case "ID":z9550.ID = Children(i).Data
   Case "CHECKSC":z9550.CheckSC = Children(i).Data
   Case "CHECKCP":z9550.CheckCP = Children(i).Data
   Case "SEFREQUENCY":z9550.seFrequency = Children(i).Data
   Case "CDFREQUENCY":z9550.cdFrequency = Children(i).Data
   Case "CDFREQUENCYNAME":z9550.cdFrequencyName = Children(i).Data
   Case "PURPOSE":z9550.Purpose = Children(i).Data
   Case "ACTIONNAME":z9550.ActionName = Children(i).Data
   Case "DESCRIPTION":z9550.Description = Children(i).Data
   Case "RECEIVER":z9550.Receiver = Children(i).Data
   Case "MINJOB":z9550.MinJob = Children(i).Data
   Case "MAXJOB":z9550.MaxJob = Children(i).Data
   Case "AVGJOB":z9550.AvgJob = Children(i).Data
   Case "TIMEJOB":z9550.TimeJob = Children(i).Data
   Case "PORTION":z9550.Portion = Children(i).Data
   Case "FILESNAME":z9550.FilesName = Children(i).Data
   Case "JOBCARDLIST":z9550.JobCardList = Children(i).Data
   Case "REPORTLIST":z9550.ReportList = Children(i).Data
   Case "ISOLIST":z9550.ISOList = Children(i).Data
   Case "WFLIST":z9550.WFList = Children(i).Data
   Case "MENULIST":z9550.MenuList = Children(i).Data
   Case "DATEINSERT":z9550.DateInsert = Children(i).Data
   Case "DATEUPDATE":z9550.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z9550.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z9550.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z9550.CheckUse = Children(i).Data
   Case "DATEACTIVE":z9550.DateActive = Children(i).Data
   Case "DATEDEACTIVE":z9550.DateDeactive = Children(i).Data
   Case "CHECKACTIVE":z9550.CheckActive = Children(i).Data
   Case "REMARK":z9550.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K9550_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K9550_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9550 As T9550_AREA, Job as String, CheckClear as Boolean, CDWORKFLOW AS String, AUTOKEY_PFK9500_S AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9550_MOVE = False

Try
    If READ_PFK9550(CDWORKFLOW, AUTOKEY_PFK9500_S) = True Then
                z9550 = D9550
		K9550_MOVE = True
		else
	If CheckClear  = True then z9550 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9550")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "CDWORKFLOW":z9550.cdWorkFlow = Children(i).Code
   Case "AUTOKEY_PFK9500_S":z9550.AutoKey_PFK9500_S = Children(i).Code
   Case "AUTOKEY_PFK9500_E":z9550.AutoKey_PFK9500_E = Children(i).Code
   Case "DSEQ":z9550.Dseq = Children(i).Code
   Case "DSEQNAME":z9550.DseqName = Children(i).Code
   Case "DSEQTO":z9550.DseqTo = Children(i).Code
   Case "SEWORKFLOW":z9550.seWorkFlow = Children(i).Code
   Case "SECHECKFLOW":z9550.seCheckFlow = Children(i).Code
   Case "CDCHECKFLOW":z9550.cdCheckFlow = Children(i).Code
   Case "SEQ":z9550.Seq = Children(i).Code
   Case "DATEACCEPT":z9550.DateAccept = Children(i).Code
   Case "SEDEPARTMENT":z9550.seDepartment = Children(i).Code
   Case "CDDEPARTMENT":z9550.cdDepartment = Children(i).Code
   Case "CDDEPARTMENTNAME":z9550.cdDepartmentName = Children(i).Code
   Case "CDTEAMNAME":z9550.cdTeamName = Children(i).Code
   Case "CDRESPONNAME":z9550.cdResponName = Children(i).Code
   Case "SEPOSITION":z9550.sePosition = Children(i).Code
   Case "CDPOSITION":z9550.cdPosition = Children(i).Code
   Case "CDPOSITIONNAME":z9550.cdPositionName = Children(i).Code
   Case "SEINCHARGE":z9550.seIncharge = Children(i).Code
   Case "CDINCHARGE":z9550.cdIncharge = Children(i).Code
   Case "IDNONAME":z9550.IDNOName = Children(i).Code
   Case "ID":z9550.ID = Children(i).Code
   Case "CHECKSC":z9550.CheckSC = Children(i).Code
   Case "CHECKCP":z9550.CheckCP = Children(i).Code
   Case "SEFREQUENCY":z9550.seFrequency = Children(i).Code
   Case "CDFREQUENCY":z9550.cdFrequency = Children(i).Code
   Case "CDFREQUENCYNAME":z9550.cdFrequencyName = Children(i).Code
   Case "PURPOSE":z9550.Purpose = Children(i).Code
   Case "ACTIONNAME":z9550.ActionName = Children(i).Code
   Case "DESCRIPTION":z9550.Description = Children(i).Code
   Case "RECEIVER":z9550.Receiver = Children(i).Code
   Case "MINJOB":z9550.MinJob = Children(i).Code
   Case "MAXJOB":z9550.MaxJob = Children(i).Code
   Case "AVGJOB":z9550.AvgJob = Children(i).Code
   Case "TIMEJOB":z9550.TimeJob = Children(i).Code
   Case "PORTION":z9550.Portion = Children(i).Code
   Case "FILESNAME":z9550.FilesName = Children(i).Code
   Case "JOBCARDLIST":z9550.JobCardList = Children(i).Code
   Case "REPORTLIST":z9550.ReportList = Children(i).Code
   Case "ISOLIST":z9550.ISOList = Children(i).Code
   Case "WFLIST":z9550.WFList = Children(i).Code
   Case "MENULIST":z9550.MenuList = Children(i).Code
   Case "DATEINSERT":z9550.DateInsert = Children(i).Code
   Case "DATEUPDATE":z9550.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z9550.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z9550.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z9550.CheckUse = Children(i).Code
   Case "DATEACTIVE":z9550.DateActive = Children(i).Code
   Case "DATEDEACTIVE":z9550.DateDeactive = Children(i).Code
   Case "CHECKACTIVE":z9550.CheckActive = Children(i).Code
   Case "REMARK":z9550.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "CDWORKFLOW":z9550.cdWorkFlow = Children(i).Data
   Case "AUTOKEY_PFK9500_S":z9550.AutoKey_PFK9500_S = Children(i).Data
   Case "AUTOKEY_PFK9500_E":z9550.AutoKey_PFK9500_E = Children(i).Data
   Case "DSEQ":z9550.Dseq = Children(i).Data
   Case "DSEQNAME":z9550.DseqName = Children(i).Data
   Case "DSEQTO":z9550.DseqTo = Children(i).Data
   Case "SEWORKFLOW":z9550.seWorkFlow = Children(i).Data
   Case "SECHECKFLOW":z9550.seCheckFlow = Children(i).Data
   Case "CDCHECKFLOW":z9550.cdCheckFlow = Children(i).Data
   Case "SEQ":z9550.Seq = Children(i).Data
   Case "DATEACCEPT":z9550.DateAccept = Children(i).Data
   Case "SEDEPARTMENT":z9550.seDepartment = Children(i).Data
   Case "CDDEPARTMENT":z9550.cdDepartment = Children(i).Data
   Case "CDDEPARTMENTNAME":z9550.cdDepartmentName = Children(i).Data
   Case "CDTEAMNAME":z9550.cdTeamName = Children(i).Data
   Case "CDRESPONNAME":z9550.cdResponName = Children(i).Data
   Case "SEPOSITION":z9550.sePosition = Children(i).Data
   Case "CDPOSITION":z9550.cdPosition = Children(i).Data
   Case "CDPOSITIONNAME":z9550.cdPositionName = Children(i).Data
   Case "SEINCHARGE":z9550.seIncharge = Children(i).Data
   Case "CDINCHARGE":z9550.cdIncharge = Children(i).Data
   Case "IDNONAME":z9550.IDNOName = Children(i).Data
   Case "ID":z9550.ID = Children(i).Data
   Case "CHECKSC":z9550.CheckSC = Children(i).Data
   Case "CHECKCP":z9550.CheckCP = Children(i).Data
   Case "SEFREQUENCY":z9550.seFrequency = Children(i).Data
   Case "CDFREQUENCY":z9550.cdFrequency = Children(i).Data
   Case "CDFREQUENCYNAME":z9550.cdFrequencyName = Children(i).Data
   Case "PURPOSE":z9550.Purpose = Children(i).Data
   Case "ACTIONNAME":z9550.ActionName = Children(i).Data
   Case "DESCRIPTION":z9550.Description = Children(i).Data
   Case "RECEIVER":z9550.Receiver = Children(i).Data
   Case "MINJOB":z9550.MinJob = Children(i).Data
   Case "MAXJOB":z9550.MaxJob = Children(i).Data
   Case "AVGJOB":z9550.AvgJob = Children(i).Data
   Case "TIMEJOB":z9550.TimeJob = Children(i).Data
   Case "PORTION":z9550.Portion = Children(i).Data
   Case "FILESNAME":z9550.FilesName = Children(i).Data
   Case "JOBCARDLIST":z9550.JobCardList = Children(i).Data
   Case "REPORTLIST":z9550.ReportList = Children(i).Data
   Case "ISOLIST":z9550.ISOList = Children(i).Data
   Case "WFLIST":z9550.WFList = Children(i).Data
   Case "MENULIST":z9550.MenuList = Children(i).Data
   Case "DATEINSERT":z9550.DateInsert = Children(i).Data
   Case "DATEUPDATE":z9550.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z9550.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z9550.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z9550.CheckUse = Children(i).Data
   Case "DATEACTIVE":z9550.DateActive = Children(i).Data
   Case "DATEDEACTIVE":z9550.DateDeactive = Children(i).Data
   Case "CHECKACTIVE":z9550.CheckActive = Children(i).Data
   Case "REMARK":z9550.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K9550_MOVE",vbCritical)
End Try
End Function 
    
End Module 
