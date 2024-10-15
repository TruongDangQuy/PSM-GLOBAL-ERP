'=========================================================================================================================================================
'   TABLE : (PFK7328)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7328

Structure T7328_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	JobBOMCode	 AS String	'			nvarchar(6)		*
Public 	JobBOMName	 AS String	'			nvarchar(50)
Public 	CustomerCode	 AS String	'			char(6)
Public 	seSeason	 AS String	'			char(3)
Public 	cdSeason	 AS String	'			char(3)
Public 	seOrderGroup	 AS String	'			char(3)
Public 	cdOrderGroup	 AS String	'			char(3)
Public 	seShoesKind	 AS String	'			char(3)
Public 	cdShoesKind	 AS String	'			char(3)
Public 	seShoesType	 AS String	'			char(3)
Public 	cdShoesType	 AS String	'			char(3)
Public 	seSoleKind	 AS String	'			char(3)
Public 	cdSoleKind	 AS String	'			char(3)
Public 	seMainProcess	 AS String	'			char(3)
Public 	cdMainProcess	 AS String	'			char(3)
Public 	seSubProcess	 AS String	'			char(3)
Public 	cdSubProcess	 AS String	'			char(3)
Public 	LevelName	 AS String	'			nvarchar(20)
Public 	Article	 AS String	'			nvarchar(100)
Public 	Line	 AS String	'			nvarchar(100)
Public 	ProductionTimeRate	 AS String	'			nvarchar(20)
Public 	ExpLOB	 AS Double	'			decimal
Public 	ExpPPH	 AS Double	'			decimal
Public 	TaktTime	 AS Double	'			decimal
Public 	TargetOut1H	 AS Double	'			decimal
Public 	TargetOut8H	 AS Double	'			decimal
Public 	ActualMan	 AS Double	'			decimal
Public 	ExpOpt1	 AS Double	'			decimal
Public 	ExpOpt2	 AS Double	'			decimal
Public 	ExpOpt3	 AS Double	'			decimal
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(6)
Public 	InchargeUpdate	 AS String	'			char(6)
Public 	CheckUse	 AS String	'			char(1)
Public 	AttachID	 AS String	'			char(6)
Public 	Remark	 AS String	'			nvarchar(100)
'=========================================================================================================================================================
End structure

Public D7328 As T7328_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7328(JOBBOMCODE AS String) As Boolean
    READ_PFK7328 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7328 "
    SQL = SQL & " WHERE K7328_JobBOMCode		 = '" & JobBOMCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7328_CLEAR: GoTo SKIP_READ_PFK7328
                
    Call K7328_MOVE(rd)
    READ_PFK7328 = True

SKIP_READ_PFK7328:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7328",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7328(JOBBOMCODE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7328 "
    SQL = SQL & " WHERE K7328_JobBOMCode		 = '" & JobBOMCode & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7328",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7328(z7328 As T7328_AREA) As Boolean
    WRITE_PFK7328 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7328)
 
    SQL = " INSERT INTO PFK7328 "
    SQL = SQL & " ( "
    SQL = SQL & " K7328_JobBOMCode," 
    SQL = SQL & " K7328_JobBOMName," 
    SQL = SQL & " K7328_CustomerCode," 
    SQL = SQL & " K7328_seSeason," 
    SQL = SQL & " K7328_cdSeason," 
    SQL = SQL & " K7328_seOrderGroup," 
    SQL = SQL & " K7328_cdOrderGroup," 
    SQL = SQL & " K7328_seShoesKind," 
    SQL = SQL & " K7328_cdShoesKind," 
    SQL = SQL & " K7328_seShoesType," 
    SQL = SQL & " K7328_cdShoesType," 
    SQL = SQL & " K7328_seSoleKind," 
    SQL = SQL & " K7328_cdSoleKind," 
    SQL = SQL & " K7328_seMainProcess," 
    SQL = SQL & " K7328_cdMainProcess," 
    SQL = SQL & " K7328_seSubProcess," 
    SQL = SQL & " K7328_cdSubProcess," 
    SQL = SQL & " K7328_LevelName," 
    SQL = SQL & " K7328_Article," 
    SQL = SQL & " K7328_Line," 
    SQL = SQL & " K7328_ProductionTimeRate," 
    SQL = SQL & " K7328_ExpLOB," 
    SQL = SQL & " K7328_ExpPPH," 
    SQL = SQL & " K7328_TaktTime," 
    SQL = SQL & " K7328_TargetOut1H," 
    SQL = SQL & " K7328_TargetOut8H," 
    SQL = SQL & " K7328_ActualMan," 
    SQL = SQL & " K7328_ExpOpt1," 
    SQL = SQL & " K7328_ExpOpt2," 
    SQL = SQL & " K7328_ExpOpt3," 
    SQL = SQL & " K7328_DateInsert," 
    SQL = SQL & " K7328_DateUpdate," 
    SQL = SQL & " K7328_InchargeInsert," 
    SQL = SQL & " K7328_InchargeUpdate," 
    SQL = SQL & " K7328_CheckUse," 
    SQL = SQL & " K7328_AttachID," 
    SQL = SQL & " K7328_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7328.JobBOMCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7328.JobBOMName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7328.CustomerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7328.seSeason) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7328.cdSeason) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7328.seOrderGroup) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7328.cdOrderGroup) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7328.seShoesKind) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7328.cdShoesKind) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7328.seShoesType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7328.cdShoesType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7328.seSoleKind) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7328.cdSoleKind) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7328.seMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7328.cdMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7328.seSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7328.cdSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7328.LevelName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7328.Article) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7328.Line) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7328.ProductionTimeRate) & "', "  
    SQL = SQL & "   " & FormatSQL(z7328.ExpLOB) & ", "  
    SQL = SQL & "   " & FormatSQL(z7328.ExpPPH) & ", "  
    SQL = SQL & "   " & FormatSQL(z7328.TaktTime) & ", "  
    SQL = SQL & "   " & FormatSQL(z7328.TargetOut1H) & ", "  
    SQL = SQL & "   " & FormatSQL(z7328.TargetOut8H) & ", "  
    SQL = SQL & "   " & FormatSQL(z7328.ActualMan) & ", "  
    SQL = SQL & "   " & FormatSQL(z7328.ExpOpt1) & ", "  
    SQL = SQL & "   " & FormatSQL(z7328.ExpOpt2) & ", "  
    SQL = SQL & "   " & FormatSQL(z7328.ExpOpt3) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7328.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7328.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7328.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7328.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7328.CheckUse) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7328.AttachID) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7328.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7328 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7328",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7328(z7328 As T7328_AREA) As Boolean
    REWRITE_PFK7328 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7328)
   
    SQL = " UPDATE PFK7328 SET "
    SQL = SQL & "    K7328_JobBOMName      = N'" & FormatSQL(z7328.JobBOMName) & "', " 
    SQL = SQL & "    K7328_CustomerCode      = N'" & FormatSQL(z7328.CustomerCode) & "', " 
    SQL = SQL & "    K7328_seSeason      = N'" & FormatSQL(z7328.seSeason) & "', " 
    SQL = SQL & "    K7328_cdSeason      = N'" & FormatSQL(z7328.cdSeason) & "', " 
    SQL = SQL & "    K7328_seOrderGroup      = N'" & FormatSQL(z7328.seOrderGroup) & "', " 
    SQL = SQL & "    K7328_cdOrderGroup      = N'" & FormatSQL(z7328.cdOrderGroup) & "', " 
    SQL = SQL & "    K7328_seShoesKind      = N'" & FormatSQL(z7328.seShoesKind) & "', " 
    SQL = SQL & "    K7328_cdShoesKind      = N'" & FormatSQL(z7328.cdShoesKind) & "', " 
    SQL = SQL & "    K7328_seShoesType      = N'" & FormatSQL(z7328.seShoesType) & "', " 
    SQL = SQL & "    K7328_cdShoesType      = N'" & FormatSQL(z7328.cdShoesType) & "', " 
    SQL = SQL & "    K7328_seSoleKind      = N'" & FormatSQL(z7328.seSoleKind) & "', " 
    SQL = SQL & "    K7328_cdSoleKind      = N'" & FormatSQL(z7328.cdSoleKind) & "', " 
    SQL = SQL & "    K7328_seMainProcess      = N'" & FormatSQL(z7328.seMainProcess) & "', " 
    SQL = SQL & "    K7328_cdMainProcess      = N'" & FormatSQL(z7328.cdMainProcess) & "', " 
    SQL = SQL & "    K7328_seSubProcess      = N'" & FormatSQL(z7328.seSubProcess) & "', " 
    SQL = SQL & "    K7328_cdSubProcess      = N'" & FormatSQL(z7328.cdSubProcess) & "', " 
    SQL = SQL & "    K7328_LevelName      = N'" & FormatSQL(z7328.LevelName) & "', " 
    SQL = SQL & "    K7328_Article      = N'" & FormatSQL(z7328.Article) & "', " 
    SQL = SQL & "    K7328_Line      = N'" & FormatSQL(z7328.Line) & "', " 
    SQL = SQL & "    K7328_ProductionTimeRate      = N'" & FormatSQL(z7328.ProductionTimeRate) & "', " 
    SQL = SQL & "    K7328_ExpLOB      =  " & FormatSQL(z7328.ExpLOB) & ", " 
    SQL = SQL & "    K7328_ExpPPH      =  " & FormatSQL(z7328.ExpPPH) & ", " 
    SQL = SQL & "    K7328_TaktTime      =  " & FormatSQL(z7328.TaktTime) & ", " 
    SQL = SQL & "    K7328_TargetOut1H      =  " & FormatSQL(z7328.TargetOut1H) & ", " 
    SQL = SQL & "    K7328_TargetOut8H      =  " & FormatSQL(z7328.TargetOut8H) & ", " 
    SQL = SQL & "    K7328_ActualMan      =  " & FormatSQL(z7328.ActualMan) & ", " 
    SQL = SQL & "    K7328_ExpOpt1      =  " & FormatSQL(z7328.ExpOpt1) & ", " 
    SQL = SQL & "    K7328_ExpOpt2      =  " & FormatSQL(z7328.ExpOpt2) & ", " 
    SQL = SQL & "    K7328_ExpOpt3      =  " & FormatSQL(z7328.ExpOpt3) & ", " 
    SQL = SQL & "    K7328_DateInsert      = N'" & FormatSQL(z7328.DateInsert) & "', " 
    SQL = SQL & "    K7328_DateUpdate      = N'" & FormatSQL(z7328.DateUpdate) & "', " 
    SQL = SQL & "    K7328_InchargeInsert      = N'" & FormatSQL(z7328.InchargeInsert) & "', " 
    SQL = SQL & "    K7328_InchargeUpdate      = N'" & FormatSQL(z7328.InchargeUpdate) & "', " 
    SQL = SQL & "    K7328_CheckUse      = N'" & FormatSQL(z7328.CheckUse) & "', " 
    SQL = SQL & "    K7328_AttachID      = N'" & FormatSQL(z7328.AttachID) & "', " 
    SQL = SQL & "    K7328_Remark      = N'" & FormatSQL(z7328.Remark) & "'  " 
    SQL = SQL & " WHERE K7328_JobBOMCode		 = '" & z7328.JobBOMCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7328 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7328",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7328(z7328 As T7328_AREA) As Boolean
    DELETE_PFK7328 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7328 "
    SQL = SQL & " WHERE K7328_JobBOMCode		 = '" & z7328.JobBOMCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7328 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7328",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7328_CLEAR()
Try
    
   D7328.JobBOMCode = ""
   D7328.JobBOMName = ""
   D7328.CustomerCode = ""
   D7328.seSeason = ""
   D7328.cdSeason = ""
   D7328.seOrderGroup = ""
   D7328.cdOrderGroup = ""
   D7328.seShoesKind = ""
   D7328.cdShoesKind = ""
   D7328.seShoesType = ""
   D7328.cdShoesType = ""
   D7328.seSoleKind = ""
   D7328.cdSoleKind = ""
   D7328.seMainProcess = ""
   D7328.cdMainProcess = ""
   D7328.seSubProcess = ""
   D7328.cdSubProcess = ""
   D7328.LevelName = ""
   D7328.Article = ""
   D7328.Line = ""
   D7328.ProductionTimeRate = ""
    D7328.ExpLOB = 0 
    D7328.ExpPPH = 0 
    D7328.TaktTime = 0 
    D7328.TargetOut1H = 0 
    D7328.TargetOut8H = 0 
    D7328.ActualMan = 0 
    D7328.ExpOpt1 = 0 
    D7328.ExpOpt2 = 0 
    D7328.ExpOpt3 = 0 
   D7328.DateInsert = ""
   D7328.DateUpdate = ""
   D7328.InchargeInsert = ""
   D7328.InchargeUpdate = ""
   D7328.CheckUse = ""
   D7328.AttachID = ""
   D7328.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7328_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7328 As T7328_AREA)
Try
    
    x7328.JobBOMCode = trim$(  x7328.JobBOMCode)
    x7328.JobBOMName = trim$(  x7328.JobBOMName)
    x7328.CustomerCode = trim$(  x7328.CustomerCode)
    x7328.seSeason = trim$(  x7328.seSeason)
    x7328.cdSeason = trim$(  x7328.cdSeason)
    x7328.seOrderGroup = trim$(  x7328.seOrderGroup)
    x7328.cdOrderGroup = trim$(  x7328.cdOrderGroup)
    x7328.seShoesKind = trim$(  x7328.seShoesKind)
    x7328.cdShoesKind = trim$(  x7328.cdShoesKind)
    x7328.seShoesType = trim$(  x7328.seShoesType)
    x7328.cdShoesType = trim$(  x7328.cdShoesType)
    x7328.seSoleKind = trim$(  x7328.seSoleKind)
    x7328.cdSoleKind = trim$(  x7328.cdSoleKind)
    x7328.seMainProcess = trim$(  x7328.seMainProcess)
    x7328.cdMainProcess = trim$(  x7328.cdMainProcess)
    x7328.seSubProcess = trim$(  x7328.seSubProcess)
    x7328.cdSubProcess = trim$(  x7328.cdSubProcess)
    x7328.LevelName = trim$(  x7328.LevelName)
    x7328.Article = trim$(  x7328.Article)
    x7328.Line = trim$(  x7328.Line)
    x7328.ProductionTimeRate = trim$(  x7328.ProductionTimeRate)
    x7328.ExpLOB = trim$(  x7328.ExpLOB)
    x7328.ExpPPH = trim$(  x7328.ExpPPH)
    x7328.TaktTime = trim$(  x7328.TaktTime)
    x7328.TargetOut1H = trim$(  x7328.TargetOut1H)
    x7328.TargetOut8H = trim$(  x7328.TargetOut8H)
    x7328.ActualMan = trim$(  x7328.ActualMan)
    x7328.ExpOpt1 = trim$(  x7328.ExpOpt1)
    x7328.ExpOpt2 = trim$(  x7328.ExpOpt2)
    x7328.ExpOpt3 = trim$(  x7328.ExpOpt3)
    x7328.DateInsert = trim$(  x7328.DateInsert)
    x7328.DateUpdate = trim$(  x7328.DateUpdate)
    x7328.InchargeInsert = trim$(  x7328.InchargeInsert)
    x7328.InchargeUpdate = trim$(  x7328.InchargeUpdate)
    x7328.CheckUse = trim$(  x7328.CheckUse)
    x7328.AttachID = trim$(  x7328.AttachID)
    x7328.Remark = trim$(  x7328.Remark)
     
    If trim$( x7328.JobBOMCode ) = "" Then x7328.JobBOMCode = Space(1) 
    If trim$( x7328.JobBOMName ) = "" Then x7328.JobBOMName = Space(1) 
    If trim$( x7328.CustomerCode ) = "" Then x7328.CustomerCode = Space(1) 
    If trim$( x7328.seSeason ) = "" Then x7328.seSeason = Space(1) 
    If trim$( x7328.cdSeason ) = "" Then x7328.cdSeason = Space(1) 
    If trim$( x7328.seOrderGroup ) = "" Then x7328.seOrderGroup = Space(1) 
    If trim$( x7328.cdOrderGroup ) = "" Then x7328.cdOrderGroup = Space(1) 
    If trim$( x7328.seShoesKind ) = "" Then x7328.seShoesKind = Space(1) 
    If trim$( x7328.cdShoesKind ) = "" Then x7328.cdShoesKind = Space(1) 
    If trim$( x7328.seShoesType ) = "" Then x7328.seShoesType = Space(1) 
    If trim$( x7328.cdShoesType ) = "" Then x7328.cdShoesType = Space(1) 
    If trim$( x7328.seSoleKind ) = "" Then x7328.seSoleKind = Space(1) 
    If trim$( x7328.cdSoleKind ) = "" Then x7328.cdSoleKind = Space(1) 
    If trim$( x7328.seMainProcess ) = "" Then x7328.seMainProcess = Space(1) 
    If trim$( x7328.cdMainProcess ) = "" Then x7328.cdMainProcess = Space(1) 
    If trim$( x7328.seSubProcess ) = "" Then x7328.seSubProcess = Space(1) 
    If trim$( x7328.cdSubProcess ) = "" Then x7328.cdSubProcess = Space(1) 
    If trim$( x7328.LevelName ) = "" Then x7328.LevelName = Space(1) 
    If trim$( x7328.Article ) = "" Then x7328.Article = Space(1) 
    If trim$( x7328.Line ) = "" Then x7328.Line = Space(1) 
    If trim$( x7328.ProductionTimeRate ) = "" Then x7328.ProductionTimeRate = Space(1) 
    If trim$( x7328.ExpLOB ) = "" Then x7328.ExpLOB = 0 
    If trim$( x7328.ExpPPH ) = "" Then x7328.ExpPPH = 0 
    If trim$( x7328.TaktTime ) = "" Then x7328.TaktTime = 0 
    If trim$( x7328.TargetOut1H ) = "" Then x7328.TargetOut1H = 0 
    If trim$( x7328.TargetOut8H ) = "" Then x7328.TargetOut8H = 0 
    If trim$( x7328.ActualMan ) = "" Then x7328.ActualMan = 0 
    If trim$( x7328.ExpOpt1 ) = "" Then x7328.ExpOpt1 = 0 
    If trim$( x7328.ExpOpt2 ) = "" Then x7328.ExpOpt2 = 0 
    If trim$( x7328.ExpOpt3 ) = "" Then x7328.ExpOpt3 = 0 
    If trim$( x7328.DateInsert ) = "" Then x7328.DateInsert = Space(1) 
    If trim$( x7328.DateUpdate ) = "" Then x7328.DateUpdate = Space(1) 
    If trim$( x7328.InchargeInsert ) = "" Then x7328.InchargeInsert = Space(1) 
    If trim$( x7328.InchargeUpdate ) = "" Then x7328.InchargeUpdate = Space(1) 
    If trim$( x7328.CheckUse ) = "" Then x7328.CheckUse = Space(1) 
    If trim$( x7328.AttachID ) = "" Then x7328.AttachID = Space(1) 
    If trim$( x7328.Remark ) = "" Then x7328.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7328_MOVE(rs7328 As SqlClient.SqlDataReader)
Try

    call D7328_CLEAR()   

    If IsdbNull(rs7328!K7328_JobBOMCode) = False Then D7328.JobBOMCode = Trim$(rs7328!K7328_JobBOMCode)
    If IsdbNull(rs7328!K7328_JobBOMName) = False Then D7328.JobBOMName = Trim$(rs7328!K7328_JobBOMName)
    If IsdbNull(rs7328!K7328_CustomerCode) = False Then D7328.CustomerCode = Trim$(rs7328!K7328_CustomerCode)
    If IsdbNull(rs7328!K7328_seSeason) = False Then D7328.seSeason = Trim$(rs7328!K7328_seSeason)
    If IsdbNull(rs7328!K7328_cdSeason) = False Then D7328.cdSeason = Trim$(rs7328!K7328_cdSeason)
    If IsdbNull(rs7328!K7328_seOrderGroup) = False Then D7328.seOrderGroup = Trim$(rs7328!K7328_seOrderGroup)
    If IsdbNull(rs7328!K7328_cdOrderGroup) = False Then D7328.cdOrderGroup = Trim$(rs7328!K7328_cdOrderGroup)
    If IsdbNull(rs7328!K7328_seShoesKind) = False Then D7328.seShoesKind = Trim$(rs7328!K7328_seShoesKind)
    If IsdbNull(rs7328!K7328_cdShoesKind) = False Then D7328.cdShoesKind = Trim$(rs7328!K7328_cdShoesKind)
    If IsdbNull(rs7328!K7328_seShoesType) = False Then D7328.seShoesType = Trim$(rs7328!K7328_seShoesType)
    If IsdbNull(rs7328!K7328_cdShoesType) = False Then D7328.cdShoesType = Trim$(rs7328!K7328_cdShoesType)
    If IsdbNull(rs7328!K7328_seSoleKind) = False Then D7328.seSoleKind = Trim$(rs7328!K7328_seSoleKind)
    If IsdbNull(rs7328!K7328_cdSoleKind) = False Then D7328.cdSoleKind = Trim$(rs7328!K7328_cdSoleKind)
    If IsdbNull(rs7328!K7328_seMainProcess) = False Then D7328.seMainProcess = Trim$(rs7328!K7328_seMainProcess)
    If IsdbNull(rs7328!K7328_cdMainProcess) = False Then D7328.cdMainProcess = Trim$(rs7328!K7328_cdMainProcess)
    If IsdbNull(rs7328!K7328_seSubProcess) = False Then D7328.seSubProcess = Trim$(rs7328!K7328_seSubProcess)
    If IsdbNull(rs7328!K7328_cdSubProcess) = False Then D7328.cdSubProcess = Trim$(rs7328!K7328_cdSubProcess)
    If IsdbNull(rs7328!K7328_LevelName) = False Then D7328.LevelName = Trim$(rs7328!K7328_LevelName)
    If IsdbNull(rs7328!K7328_Article) = False Then D7328.Article = Trim$(rs7328!K7328_Article)
    If IsdbNull(rs7328!K7328_Line) = False Then D7328.Line = Trim$(rs7328!K7328_Line)
    If IsdbNull(rs7328!K7328_ProductionTimeRate) = False Then D7328.ProductionTimeRate = Trim$(rs7328!K7328_ProductionTimeRate)
    If IsdbNull(rs7328!K7328_ExpLOB) = False Then D7328.ExpLOB = Trim$(rs7328!K7328_ExpLOB)
    If IsdbNull(rs7328!K7328_ExpPPH) = False Then D7328.ExpPPH = Trim$(rs7328!K7328_ExpPPH)
    If IsdbNull(rs7328!K7328_TaktTime) = False Then D7328.TaktTime = Trim$(rs7328!K7328_TaktTime)
    If IsdbNull(rs7328!K7328_TargetOut1H) = False Then D7328.TargetOut1H = Trim$(rs7328!K7328_TargetOut1H)
    If IsdbNull(rs7328!K7328_TargetOut8H) = False Then D7328.TargetOut8H = Trim$(rs7328!K7328_TargetOut8H)
    If IsdbNull(rs7328!K7328_ActualMan) = False Then D7328.ActualMan = Trim$(rs7328!K7328_ActualMan)
    If IsdbNull(rs7328!K7328_ExpOpt1) = False Then D7328.ExpOpt1 = Trim$(rs7328!K7328_ExpOpt1)
    If IsdbNull(rs7328!K7328_ExpOpt2) = False Then D7328.ExpOpt2 = Trim$(rs7328!K7328_ExpOpt2)
    If IsdbNull(rs7328!K7328_ExpOpt3) = False Then D7328.ExpOpt3 = Trim$(rs7328!K7328_ExpOpt3)
    If IsdbNull(rs7328!K7328_DateInsert) = False Then D7328.DateInsert = Trim$(rs7328!K7328_DateInsert)
    If IsdbNull(rs7328!K7328_DateUpdate) = False Then D7328.DateUpdate = Trim$(rs7328!K7328_DateUpdate)
    If IsdbNull(rs7328!K7328_InchargeInsert) = False Then D7328.InchargeInsert = Trim$(rs7328!K7328_InchargeInsert)
    If IsdbNull(rs7328!K7328_InchargeUpdate) = False Then D7328.InchargeUpdate = Trim$(rs7328!K7328_InchargeUpdate)
    If IsdbNull(rs7328!K7328_CheckUse) = False Then D7328.CheckUse = Trim$(rs7328!K7328_CheckUse)
    If IsdbNull(rs7328!K7328_AttachID) = False Then D7328.AttachID = Trim$(rs7328!K7328_AttachID)
    If IsdbNull(rs7328!K7328_Remark) = False Then D7328.Remark = Trim$(rs7328!K7328_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7328_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7328_MOVE(rs7328 As DataRow)
Try

    call D7328_CLEAR()   

    If IsdbNull(rs7328!K7328_JobBOMCode) = False Then D7328.JobBOMCode = Trim$(rs7328!K7328_JobBOMCode)
    If IsdbNull(rs7328!K7328_JobBOMName) = False Then D7328.JobBOMName = Trim$(rs7328!K7328_JobBOMName)
    If IsdbNull(rs7328!K7328_CustomerCode) = False Then D7328.CustomerCode = Trim$(rs7328!K7328_CustomerCode)
    If IsdbNull(rs7328!K7328_seSeason) = False Then D7328.seSeason = Trim$(rs7328!K7328_seSeason)
    If IsdbNull(rs7328!K7328_cdSeason) = False Then D7328.cdSeason = Trim$(rs7328!K7328_cdSeason)
    If IsdbNull(rs7328!K7328_seOrderGroup) = False Then D7328.seOrderGroup = Trim$(rs7328!K7328_seOrderGroup)
    If IsdbNull(rs7328!K7328_cdOrderGroup) = False Then D7328.cdOrderGroup = Trim$(rs7328!K7328_cdOrderGroup)
    If IsdbNull(rs7328!K7328_seShoesKind) = False Then D7328.seShoesKind = Trim$(rs7328!K7328_seShoesKind)
    If IsdbNull(rs7328!K7328_cdShoesKind) = False Then D7328.cdShoesKind = Trim$(rs7328!K7328_cdShoesKind)
    If IsdbNull(rs7328!K7328_seShoesType) = False Then D7328.seShoesType = Trim$(rs7328!K7328_seShoesType)
    If IsdbNull(rs7328!K7328_cdShoesType) = False Then D7328.cdShoesType = Trim$(rs7328!K7328_cdShoesType)
    If IsdbNull(rs7328!K7328_seSoleKind) = False Then D7328.seSoleKind = Trim$(rs7328!K7328_seSoleKind)
    If IsdbNull(rs7328!K7328_cdSoleKind) = False Then D7328.cdSoleKind = Trim$(rs7328!K7328_cdSoleKind)
    If IsdbNull(rs7328!K7328_seMainProcess) = False Then D7328.seMainProcess = Trim$(rs7328!K7328_seMainProcess)
    If IsdbNull(rs7328!K7328_cdMainProcess) = False Then D7328.cdMainProcess = Trim$(rs7328!K7328_cdMainProcess)
    If IsdbNull(rs7328!K7328_seSubProcess) = False Then D7328.seSubProcess = Trim$(rs7328!K7328_seSubProcess)
    If IsdbNull(rs7328!K7328_cdSubProcess) = False Then D7328.cdSubProcess = Trim$(rs7328!K7328_cdSubProcess)
    If IsdbNull(rs7328!K7328_LevelName) = False Then D7328.LevelName = Trim$(rs7328!K7328_LevelName)
    If IsdbNull(rs7328!K7328_Article) = False Then D7328.Article = Trim$(rs7328!K7328_Article)
    If IsdbNull(rs7328!K7328_Line) = False Then D7328.Line = Trim$(rs7328!K7328_Line)
    If IsdbNull(rs7328!K7328_ProductionTimeRate) = False Then D7328.ProductionTimeRate = Trim$(rs7328!K7328_ProductionTimeRate)
    If IsdbNull(rs7328!K7328_ExpLOB) = False Then D7328.ExpLOB = Trim$(rs7328!K7328_ExpLOB)
    If IsdbNull(rs7328!K7328_ExpPPH) = False Then D7328.ExpPPH = Trim$(rs7328!K7328_ExpPPH)
    If IsdbNull(rs7328!K7328_TaktTime) = False Then D7328.TaktTime = Trim$(rs7328!K7328_TaktTime)
    If IsdbNull(rs7328!K7328_TargetOut1H) = False Then D7328.TargetOut1H = Trim$(rs7328!K7328_TargetOut1H)
    If IsdbNull(rs7328!K7328_TargetOut8H) = False Then D7328.TargetOut8H = Trim$(rs7328!K7328_TargetOut8H)
    If IsdbNull(rs7328!K7328_ActualMan) = False Then D7328.ActualMan = Trim$(rs7328!K7328_ActualMan)
    If IsdbNull(rs7328!K7328_ExpOpt1) = False Then D7328.ExpOpt1 = Trim$(rs7328!K7328_ExpOpt1)
    If IsdbNull(rs7328!K7328_ExpOpt2) = False Then D7328.ExpOpt2 = Trim$(rs7328!K7328_ExpOpt2)
    If IsdbNull(rs7328!K7328_ExpOpt3) = False Then D7328.ExpOpt3 = Trim$(rs7328!K7328_ExpOpt3)
    If IsdbNull(rs7328!K7328_DateInsert) = False Then D7328.DateInsert = Trim$(rs7328!K7328_DateInsert)
    If IsdbNull(rs7328!K7328_DateUpdate) = False Then D7328.DateUpdate = Trim$(rs7328!K7328_DateUpdate)
    If IsdbNull(rs7328!K7328_InchargeInsert) = False Then D7328.InchargeInsert = Trim$(rs7328!K7328_InchargeInsert)
    If IsdbNull(rs7328!K7328_InchargeUpdate) = False Then D7328.InchargeUpdate = Trim$(rs7328!K7328_InchargeUpdate)
    If IsdbNull(rs7328!K7328_CheckUse) = False Then D7328.CheckUse = Trim$(rs7328!K7328_CheckUse)
    If IsdbNull(rs7328!K7328_AttachID) = False Then D7328.AttachID = Trim$(rs7328!K7328_AttachID)
    If IsdbNull(rs7328!K7328_Remark) = False Then D7328.Remark = Trim$(rs7328!K7328_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7328_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7328_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7328 As T7328_AREA, JOBBOMCODE AS String) as Boolean

K7328_MOVE = False

Try
    If READ_PFK7328(JOBBOMCODE) = True Then
                z7328 = D7328
		K7328_MOVE = True
		else
	z7328 = nothing
     End If

     If  getColumIndex(spr,"JobBOMCode") > -1 then z7328.JobBOMCode = getDataM(spr, getColumIndex(spr,"JobBOMCode"), xRow)
     If  getColumIndex(spr,"JobBOMName") > -1 then z7328.JobBOMName = getDataM(spr, getColumIndex(spr,"JobBOMName"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z7328.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"seSeason") > -1 then z7328.seSeason = getDataM(spr, getColumIndex(spr,"seSeason"), xRow)
     If  getColumIndex(spr,"cdSeason") > -1 then z7328.cdSeason = getDataM(spr, getColumIndex(spr,"cdSeason"), xRow)
     If  getColumIndex(spr,"seOrderGroup") > -1 then z7328.seOrderGroup = getDataM(spr, getColumIndex(spr,"seOrderGroup"), xRow)
     If  getColumIndex(spr,"cdOrderGroup") > -1 then z7328.cdOrderGroup = getDataM(spr, getColumIndex(spr,"cdOrderGroup"), xRow)
     If  getColumIndex(spr,"seShoesKind") > -1 then z7328.seShoesKind = getDataM(spr, getColumIndex(spr,"seShoesKind"), xRow)
     If  getColumIndex(spr,"cdShoesKind") > -1 then z7328.cdShoesKind = getDataM(spr, getColumIndex(spr,"cdShoesKind"), xRow)
     If  getColumIndex(spr,"seShoesType") > -1 then z7328.seShoesType = getDataM(spr, getColumIndex(spr,"seShoesType"), xRow)
     If  getColumIndex(spr,"cdShoesType") > -1 then z7328.cdShoesType = getDataM(spr, getColumIndex(spr,"cdShoesType"), xRow)
     If  getColumIndex(spr,"seSoleKind") > -1 then z7328.seSoleKind = getDataM(spr, getColumIndex(spr,"seSoleKind"), xRow)
     If  getColumIndex(spr,"cdSoleKind") > -1 then z7328.cdSoleKind = getDataM(spr, getColumIndex(spr,"cdSoleKind"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z7328.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z7328.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z7328.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z7328.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"LevelName") > -1 then z7328.LevelName = getDataM(spr, getColumIndex(spr,"LevelName"), xRow)
     If  getColumIndex(spr,"Article") > -1 then z7328.Article = getDataM(spr, getColumIndex(spr,"Article"), xRow)
     If  getColumIndex(spr,"Line") > -1 then z7328.Line = getDataM(spr, getColumIndex(spr,"Line"), xRow)
     If  getColumIndex(spr,"ProductionTimeRate") > -1 then z7328.ProductionTimeRate = getDataM(spr, getColumIndex(spr,"ProductionTimeRate"), xRow)
     If  getColumIndex(spr,"ExpLOB") > -1 then z7328.ExpLOB = getDataM(spr, getColumIndex(spr,"ExpLOB"), xRow)
     If  getColumIndex(spr,"ExpPPH") > -1 then z7328.ExpPPH = getDataM(spr, getColumIndex(spr,"ExpPPH"), xRow)
     If  getColumIndex(spr,"TaktTime") > -1 then z7328.TaktTime = getDataM(spr, getColumIndex(spr,"TaktTime"), xRow)
     If  getColumIndex(spr,"TargetOut1H") > -1 then z7328.TargetOut1H = getDataM(spr, getColumIndex(spr,"TargetOut1H"), xRow)
     If  getColumIndex(spr,"TargetOut8H") > -1 then z7328.TargetOut8H = getDataM(spr, getColumIndex(spr,"TargetOut8H"), xRow)
     If  getColumIndex(spr,"ActualMan") > -1 then z7328.ActualMan = getDataM(spr, getColumIndex(spr,"ActualMan"), xRow)
     If  getColumIndex(spr,"ExpOpt1") > -1 then z7328.ExpOpt1 = getDataM(spr, getColumIndex(spr,"ExpOpt1"), xRow)
     If  getColumIndex(spr,"ExpOpt2") > -1 then z7328.ExpOpt2 = getDataM(spr, getColumIndex(spr,"ExpOpt2"), xRow)
     If  getColumIndex(spr,"ExpOpt3") > -1 then z7328.ExpOpt3 = getDataM(spr, getColumIndex(spr,"ExpOpt3"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7328.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7328.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7328.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7328.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7328.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z7328.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7328.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7328_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7328_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7328 As T7328_AREA,CheckClear as Boolean,JOBBOMCODE AS String) as Boolean

K7328_MOVE = False

Try
    If READ_PFK7328(JOBBOMCODE) = True Then
                z7328 = D7328
		K7328_MOVE = True
		else
	If CheckClear  = True then z7328 = nothing
     End If

     If  getColumIndex(spr,"JobBOMCode") > -1 then z7328.JobBOMCode = getDataM(spr, getColumIndex(spr,"JobBOMCode"), xRow)
     If  getColumIndex(spr,"JobBOMName") > -1 then z7328.JobBOMName = getDataM(spr, getColumIndex(spr,"JobBOMName"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z7328.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"seSeason") > -1 then z7328.seSeason = getDataM(spr, getColumIndex(spr,"seSeason"), xRow)
     If  getColumIndex(spr,"cdSeason") > -1 then z7328.cdSeason = getDataM(spr, getColumIndex(spr,"cdSeason"), xRow)
     If  getColumIndex(spr,"seOrderGroup") > -1 then z7328.seOrderGroup = getDataM(spr, getColumIndex(spr,"seOrderGroup"), xRow)
     If  getColumIndex(spr,"cdOrderGroup") > -1 then z7328.cdOrderGroup = getDataM(spr, getColumIndex(spr,"cdOrderGroup"), xRow)
     If  getColumIndex(spr,"seShoesKind") > -1 then z7328.seShoesKind = getDataM(spr, getColumIndex(spr,"seShoesKind"), xRow)
     If  getColumIndex(spr,"cdShoesKind") > -1 then z7328.cdShoesKind = getDataM(spr, getColumIndex(spr,"cdShoesKind"), xRow)
     If  getColumIndex(spr,"seShoesType") > -1 then z7328.seShoesType = getDataM(spr, getColumIndex(spr,"seShoesType"), xRow)
     If  getColumIndex(spr,"cdShoesType") > -1 then z7328.cdShoesType = getDataM(spr, getColumIndex(spr,"cdShoesType"), xRow)
     If  getColumIndex(spr,"seSoleKind") > -1 then z7328.seSoleKind = getDataM(spr, getColumIndex(spr,"seSoleKind"), xRow)
     If  getColumIndex(spr,"cdSoleKind") > -1 then z7328.cdSoleKind = getDataM(spr, getColumIndex(spr,"cdSoleKind"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z7328.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z7328.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z7328.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z7328.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"LevelName") > -1 then z7328.LevelName = getDataM(spr, getColumIndex(spr,"LevelName"), xRow)
     If  getColumIndex(spr,"Article") > -1 then z7328.Article = getDataM(spr, getColumIndex(spr,"Article"), xRow)
     If  getColumIndex(spr,"Line") > -1 then z7328.Line = getDataM(spr, getColumIndex(spr,"Line"), xRow)
     If  getColumIndex(spr,"ProductionTimeRate") > -1 then z7328.ProductionTimeRate = getDataM(spr, getColumIndex(spr,"ProductionTimeRate"), xRow)
     If  getColumIndex(spr,"ExpLOB") > -1 then z7328.ExpLOB = getDataM(spr, getColumIndex(spr,"ExpLOB"), xRow)
     If  getColumIndex(spr,"ExpPPH") > -1 then z7328.ExpPPH = getDataM(spr, getColumIndex(spr,"ExpPPH"), xRow)
     If  getColumIndex(spr,"TaktTime") > -1 then z7328.TaktTime = getDataM(spr, getColumIndex(spr,"TaktTime"), xRow)
     If  getColumIndex(spr,"TargetOut1H") > -1 then z7328.TargetOut1H = getDataM(spr, getColumIndex(spr,"TargetOut1H"), xRow)
     If  getColumIndex(spr,"TargetOut8H") > -1 then z7328.TargetOut8H = getDataM(spr, getColumIndex(spr,"TargetOut8H"), xRow)
     If  getColumIndex(spr,"ActualMan") > -1 then z7328.ActualMan = getDataM(spr, getColumIndex(spr,"ActualMan"), xRow)
     If  getColumIndex(spr,"ExpOpt1") > -1 then z7328.ExpOpt1 = getDataM(spr, getColumIndex(spr,"ExpOpt1"), xRow)
     If  getColumIndex(spr,"ExpOpt2") > -1 then z7328.ExpOpt2 = getDataM(spr, getColumIndex(spr,"ExpOpt2"), xRow)
     If  getColumIndex(spr,"ExpOpt3") > -1 then z7328.ExpOpt3 = getDataM(spr, getColumIndex(spr,"ExpOpt3"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7328.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7328.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7328.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7328.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7328.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z7328.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7328.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7328_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7328_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7328 As T7328_AREA, Job as String, JOBBOMCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7328_MOVE = False

Try
    If READ_PFK7328(JOBBOMCODE) = True Then
                z7328 = D7328
		K7328_MOVE = True
		else
	z7328 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7328")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "JOBBOMCODE":z7328.JobBOMCode = Children(i).Code
   Case "JOBBOMNAME":z7328.JobBOMName = Children(i).Code
   Case "CUSTOMERCODE":z7328.CustomerCode = Children(i).Code
   Case "SESEASON":z7328.seSeason = Children(i).Code
   Case "CDSEASON":z7328.cdSeason = Children(i).Code
   Case "SEORDERGROUP":z7328.seOrderGroup = Children(i).Code
   Case "CDORDERGROUP":z7328.cdOrderGroup = Children(i).Code
   Case "SESHOESKIND":z7328.seShoesKind = Children(i).Code
   Case "CDSHOESKIND":z7328.cdShoesKind = Children(i).Code
   Case "SESHOESTYPE":z7328.seShoesType = Children(i).Code
   Case "CDSHOESTYPE":z7328.cdShoesType = Children(i).Code
   Case "SESOLEKIND":z7328.seSoleKind = Children(i).Code
   Case "CDSOLEKIND":z7328.cdSoleKind = Children(i).Code
   Case "SEMAINPROCESS":z7328.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z7328.cdMainProcess = Children(i).Code
   Case "SESUBPROCESS":z7328.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z7328.cdSubProcess = Children(i).Code
   Case "LEVELNAME":z7328.LevelName = Children(i).Code
   Case "ARTICLE":z7328.Article = Children(i).Code
   Case "LINE":z7328.Line = Children(i).Code
   Case "PRODUCTIONTIMERATE":z7328.ProductionTimeRate = Children(i).Code
   Case "EXPLOB":z7328.ExpLOB = Children(i).Code
   Case "EXPPPH":z7328.ExpPPH = Children(i).Code
   Case "TAKTTIME":z7328.TaktTime = Children(i).Code
   Case "TARGETOUT1H":z7328.TargetOut1H = Children(i).Code
   Case "TARGETOUT8H":z7328.TargetOut8H = Children(i).Code
   Case "ACTUALMAN":z7328.ActualMan = Children(i).Code
   Case "EXPOPT1":z7328.ExpOpt1 = Children(i).Code
   Case "EXPOPT2":z7328.ExpOpt2 = Children(i).Code
   Case "EXPOPT3":z7328.ExpOpt3 = Children(i).Code
   Case "DATEINSERT":z7328.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7328.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7328.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7328.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7328.CheckUse = Children(i).Code
   Case "ATTACHID":z7328.AttachID = Children(i).Code
   Case "REMARK":z7328.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "JOBBOMCODE":z7328.JobBOMCode = Children(i).Data
   Case "JOBBOMNAME":z7328.JobBOMName = Children(i).Data
   Case "CUSTOMERCODE":z7328.CustomerCode = Children(i).Data
   Case "SESEASON":z7328.seSeason = Children(i).Data
   Case "CDSEASON":z7328.cdSeason = Children(i).Data
   Case "SEORDERGROUP":z7328.seOrderGroup = Children(i).Data
   Case "CDORDERGROUP":z7328.cdOrderGroup = Children(i).Data
   Case "SESHOESKIND":z7328.seShoesKind = Children(i).Data
   Case "CDSHOESKIND":z7328.cdShoesKind = Children(i).Data
   Case "SESHOESTYPE":z7328.seShoesType = Children(i).Data
   Case "CDSHOESTYPE":z7328.cdShoesType = Children(i).Data
   Case "SESOLEKIND":z7328.seSoleKind = Children(i).Data
   Case "CDSOLEKIND":z7328.cdSoleKind = Children(i).Data
   Case "SEMAINPROCESS":z7328.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z7328.cdMainProcess = Children(i).Data
   Case "SESUBPROCESS":z7328.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z7328.cdSubProcess = Children(i).Data
   Case "LEVELNAME":z7328.LevelName = Children(i).Data
   Case "ARTICLE":z7328.Article = Children(i).Data
   Case "LINE":z7328.Line = Children(i).Data
   Case "PRODUCTIONTIMERATE":z7328.ProductionTimeRate = Children(i).Data
   Case "EXPLOB":z7328.ExpLOB = Children(i).Data
   Case "EXPPPH":z7328.ExpPPH = Children(i).Data
   Case "TAKTTIME":z7328.TaktTime = Children(i).Data
   Case "TARGETOUT1H":z7328.TargetOut1H = Children(i).Data
   Case "TARGETOUT8H":z7328.TargetOut8H = Children(i).Data
   Case "ACTUALMAN":z7328.ActualMan = Children(i).Data
   Case "EXPOPT1":z7328.ExpOpt1 = Children(i).Data
   Case "EXPOPT2":z7328.ExpOpt2 = Children(i).Data
   Case "EXPOPT3":z7328.ExpOpt3 = Children(i).Data
   Case "DATEINSERT":z7328.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7328.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7328.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7328.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7328.CheckUse = Children(i).Data
   Case "ATTACHID":z7328.AttachID = Children(i).Data
   Case "REMARK":z7328.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7328_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7328_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7328 As T7328_AREA, Job as String, CheckClear as Boolean, JOBBOMCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7328_MOVE = False

Try
    If READ_PFK7328(JOBBOMCODE) = True Then
                z7328 = D7328
		K7328_MOVE = True
		else
	If CheckClear  = True then z7328 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7328")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "JOBBOMCODE":z7328.JobBOMCode = Children(i).Code
   Case "JOBBOMNAME":z7328.JobBOMName = Children(i).Code
   Case "CUSTOMERCODE":z7328.CustomerCode = Children(i).Code
   Case "SESEASON":z7328.seSeason = Children(i).Code
   Case "CDSEASON":z7328.cdSeason = Children(i).Code
   Case "SEORDERGROUP":z7328.seOrderGroup = Children(i).Code
   Case "CDORDERGROUP":z7328.cdOrderGroup = Children(i).Code
   Case "SESHOESKIND":z7328.seShoesKind = Children(i).Code
   Case "CDSHOESKIND":z7328.cdShoesKind = Children(i).Code
   Case "SESHOESTYPE":z7328.seShoesType = Children(i).Code
   Case "CDSHOESTYPE":z7328.cdShoesType = Children(i).Code
   Case "SESOLEKIND":z7328.seSoleKind = Children(i).Code
   Case "CDSOLEKIND":z7328.cdSoleKind = Children(i).Code
   Case "SEMAINPROCESS":z7328.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z7328.cdMainProcess = Children(i).Code
   Case "SESUBPROCESS":z7328.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z7328.cdSubProcess = Children(i).Code
   Case "LEVELNAME":z7328.LevelName = Children(i).Code
   Case "ARTICLE":z7328.Article = Children(i).Code
   Case "LINE":z7328.Line = Children(i).Code
   Case "PRODUCTIONTIMERATE":z7328.ProductionTimeRate = Children(i).Code
   Case "EXPLOB":z7328.ExpLOB = Children(i).Code
   Case "EXPPPH":z7328.ExpPPH = Children(i).Code
   Case "TAKTTIME":z7328.TaktTime = Children(i).Code
   Case "TARGETOUT1H":z7328.TargetOut1H = Children(i).Code
   Case "TARGETOUT8H":z7328.TargetOut8H = Children(i).Code
   Case "ACTUALMAN":z7328.ActualMan = Children(i).Code
   Case "EXPOPT1":z7328.ExpOpt1 = Children(i).Code
   Case "EXPOPT2":z7328.ExpOpt2 = Children(i).Code
   Case "EXPOPT3":z7328.ExpOpt3 = Children(i).Code
   Case "DATEINSERT":z7328.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7328.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7328.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7328.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7328.CheckUse = Children(i).Code
   Case "ATTACHID":z7328.AttachID = Children(i).Code
   Case "REMARK":z7328.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "JOBBOMCODE":z7328.JobBOMCode = Children(i).Data
   Case "JOBBOMNAME":z7328.JobBOMName = Children(i).Data
   Case "CUSTOMERCODE":z7328.CustomerCode = Children(i).Data
   Case "SESEASON":z7328.seSeason = Children(i).Data
   Case "CDSEASON":z7328.cdSeason = Children(i).Data
   Case "SEORDERGROUP":z7328.seOrderGroup = Children(i).Data
   Case "CDORDERGROUP":z7328.cdOrderGroup = Children(i).Data
   Case "SESHOESKIND":z7328.seShoesKind = Children(i).Data
   Case "CDSHOESKIND":z7328.cdShoesKind = Children(i).Data
   Case "SESHOESTYPE":z7328.seShoesType = Children(i).Data
   Case "CDSHOESTYPE":z7328.cdShoesType = Children(i).Data
   Case "SESOLEKIND":z7328.seSoleKind = Children(i).Data
   Case "CDSOLEKIND":z7328.cdSoleKind = Children(i).Data
   Case "SEMAINPROCESS":z7328.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z7328.cdMainProcess = Children(i).Data
   Case "SESUBPROCESS":z7328.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z7328.cdSubProcess = Children(i).Data
   Case "LEVELNAME":z7328.LevelName = Children(i).Data
   Case "ARTICLE":z7328.Article = Children(i).Data
   Case "LINE":z7328.Line = Children(i).Data
   Case "PRODUCTIONTIMERATE":z7328.ProductionTimeRate = Children(i).Data
   Case "EXPLOB":z7328.ExpLOB = Children(i).Data
   Case "EXPPPH":z7328.ExpPPH = Children(i).Data
   Case "TAKTTIME":z7328.TaktTime = Children(i).Data
   Case "TARGETOUT1H":z7328.TargetOut1H = Children(i).Data
   Case "TARGETOUT8H":z7328.TargetOut8H = Children(i).Data
   Case "ACTUALMAN":z7328.ActualMan = Children(i).Data
   Case "EXPOPT1":z7328.ExpOpt1 = Children(i).Data
   Case "EXPOPT2":z7328.ExpOpt2 = Children(i).Data
   Case "EXPOPT3":z7328.ExpOpt3 = Children(i).Data
   Case "DATEINSERT":z7328.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7328.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7328.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7328.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7328.CheckUse = Children(i).Data
   Case "ATTACHID":z7328.AttachID = Children(i).Data
   Case "REMARK":z7328.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7328_MOVE",vbCritical)
End Try
End Function 
    
End Module 
