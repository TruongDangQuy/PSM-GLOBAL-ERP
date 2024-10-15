'=========================================================================================================================================================
'   TABLE : (PFK7308)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7308

Structure T7308_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	JobBOMCode	 AS String	'			nvarchar(6)		*
Public 	ProcessBOMCode	 AS String	'			nvarchar(6)
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
Public 	LevelName	 AS String	'			nvarchar(20)
Public 	Article	 AS String	'			nvarchar(50)
Public 	Line	 AS String	'			nvarchar(50)
Public 	ProductionTimeRate	 AS String	'			nvarchar(20)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(6)
Public 	InchargeUpdate	 AS String	'			char(6)
Public 	CheckUse	 AS String	'			char(1)
Public 	AttachID	 AS String	'			char(6)
Public 	Remark	 AS String	'			nvarchar(100)
'=========================================================================================================================================================
End structure

Public D7308 As T7308_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7308(JOBBOMCODE AS String) As Boolean
    READ_PFK7308 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7308 "
    SQL = SQL & " WHERE K7308_JobBOMCode		 = '" & JobBOMCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7308_CLEAR: GoTo SKIP_READ_PFK7308
                
    Call K7308_MOVE(rd)
    READ_PFK7308 = True

SKIP_READ_PFK7308:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7308",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7308(JOBBOMCODE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7308 "
    SQL = SQL & " WHERE K7308_JobBOMCode		 = '" & JobBOMCode & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7308",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7308(z7308 As T7308_AREA) As Boolean
    WRITE_PFK7308 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7308)
 
    SQL = " INSERT INTO PFK7308 "
    SQL = SQL & " ( "
    SQL = SQL & " K7308_JobBOMCode," 
    SQL = SQL & " K7308_ProcessBOMCode," 
    SQL = SQL & " K7308_JobBOMName," 
    SQL = SQL & " K7308_CustomerCode," 
    SQL = SQL & " K7308_seSeason," 
    SQL = SQL & " K7308_cdSeason," 
    SQL = SQL & " K7308_seOrderGroup," 
    SQL = SQL & " K7308_cdOrderGroup," 
    SQL = SQL & " K7308_seShoesKind," 
    SQL = SQL & " K7308_cdShoesKind," 
    SQL = SQL & " K7308_seShoesType," 
    SQL = SQL & " K7308_cdShoesType," 
    SQL = SQL & " K7308_seSoleKind," 
    SQL = SQL & " K7308_cdSoleKind," 
    SQL = SQL & " K7308_seMainProcess," 
    SQL = SQL & " K7308_cdMainProcess," 
    SQL = SQL & " K7308_LevelName," 
    SQL = SQL & " K7308_Article," 
    SQL = SQL & " K7308_Line," 
    SQL = SQL & " K7308_ProductionTimeRate," 
    SQL = SQL & " K7308_DateInsert," 
    SQL = SQL & " K7308_DateUpdate," 
    SQL = SQL & " K7308_InchargeInsert," 
    SQL = SQL & " K7308_InchargeUpdate," 
    SQL = SQL & " K7308_CheckUse," 
    SQL = SQL & " K7308_AttachID," 
    SQL = SQL & " K7308_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7308.JobBOMCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7308.ProcessBOMCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7308.JobBOMName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7308.CustomerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7308.seSeason) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7308.cdSeason) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7308.seOrderGroup) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7308.cdOrderGroup) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7308.seShoesKind) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7308.cdShoesKind) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7308.seShoesType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7308.cdShoesType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7308.seSoleKind) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7308.cdSoleKind) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7308.seMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7308.cdMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7308.LevelName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7308.Article) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7308.Line) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7308.ProductionTimeRate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7308.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7308.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7308.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7308.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7308.CheckUse) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7308.AttachID) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7308.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7308 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7308",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7308(z7308 As T7308_AREA) As Boolean
    REWRITE_PFK7308 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7308)
   
    SQL = " UPDATE PFK7308 SET "
    SQL = SQL & "    K7308_ProcessBOMCode      = N'" & FormatSQL(z7308.ProcessBOMCode) & "', " 
    SQL = SQL & "    K7308_JobBOMName      = N'" & FormatSQL(z7308.JobBOMName) & "', " 
    SQL = SQL & "    K7308_CustomerCode      = N'" & FormatSQL(z7308.CustomerCode) & "', " 
    SQL = SQL & "    K7308_seSeason      = N'" & FormatSQL(z7308.seSeason) & "', " 
    SQL = SQL & "    K7308_cdSeason      = N'" & FormatSQL(z7308.cdSeason) & "', " 
    SQL = SQL & "    K7308_seOrderGroup      = N'" & FormatSQL(z7308.seOrderGroup) & "', " 
    SQL = SQL & "    K7308_cdOrderGroup      = N'" & FormatSQL(z7308.cdOrderGroup) & "', " 
    SQL = SQL & "    K7308_seShoesKind      = N'" & FormatSQL(z7308.seShoesKind) & "', " 
    SQL = SQL & "    K7308_cdShoesKind      = N'" & FormatSQL(z7308.cdShoesKind) & "', " 
    SQL = SQL & "    K7308_seShoesType      = N'" & FormatSQL(z7308.seShoesType) & "', " 
    SQL = SQL & "    K7308_cdShoesType      = N'" & FormatSQL(z7308.cdShoesType) & "', " 
    SQL = SQL & "    K7308_seSoleKind      = N'" & FormatSQL(z7308.seSoleKind) & "', " 
    SQL = SQL & "    K7308_cdSoleKind      = N'" & FormatSQL(z7308.cdSoleKind) & "', " 
    SQL = SQL & "    K7308_seMainProcess      = N'" & FormatSQL(z7308.seMainProcess) & "', " 
    SQL = SQL & "    K7308_cdMainProcess      = N'" & FormatSQL(z7308.cdMainProcess) & "', " 
    SQL = SQL & "    K7308_LevelName      = N'" & FormatSQL(z7308.LevelName) & "', " 
    SQL = SQL & "    K7308_Article      = N'" & FormatSQL(z7308.Article) & "', " 
    SQL = SQL & "    K7308_Line      = N'" & FormatSQL(z7308.Line) & "', " 
    SQL = SQL & "    K7308_ProductionTimeRate      = N'" & FormatSQL(z7308.ProductionTimeRate) & "', " 
    SQL = SQL & "    K7308_DateInsert      = N'" & FormatSQL(z7308.DateInsert) & "', " 
    SQL = SQL & "    K7308_DateUpdate      = N'" & FormatSQL(z7308.DateUpdate) & "', " 
    SQL = SQL & "    K7308_InchargeInsert      = N'" & FormatSQL(z7308.InchargeInsert) & "', " 
    SQL = SQL & "    K7308_InchargeUpdate      = N'" & FormatSQL(z7308.InchargeUpdate) & "', " 
    SQL = SQL & "    K7308_CheckUse      = N'" & FormatSQL(z7308.CheckUse) & "', " 
    SQL = SQL & "    K7308_AttachID      = N'" & FormatSQL(z7308.AttachID) & "', " 
    SQL = SQL & "    K7308_Remark      = N'" & FormatSQL(z7308.Remark) & "'  " 
    SQL = SQL & " WHERE K7308_JobBOMCode		 = '" & z7308.JobBOMCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7308 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7308",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7308(z7308 As T7308_AREA) As Boolean
    DELETE_PFK7308 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7308 "
    SQL = SQL & " WHERE K7308_JobBOMCode		 = '" & z7308.JobBOMCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7308 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7308",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7308_CLEAR()
Try
    
   D7308.JobBOMCode = ""
   D7308.ProcessBOMCode = ""
   D7308.JobBOMName = ""
   D7308.CustomerCode = ""
   D7308.seSeason = ""
   D7308.cdSeason = ""
   D7308.seOrderGroup = ""
   D7308.cdOrderGroup = ""
   D7308.seShoesKind = ""
   D7308.cdShoesKind = ""
   D7308.seShoesType = ""
   D7308.cdShoesType = ""
   D7308.seSoleKind = ""
   D7308.cdSoleKind = ""
   D7308.seMainProcess = ""
   D7308.cdMainProcess = ""
   D7308.LevelName = ""
   D7308.Article = ""
   D7308.Line = ""
   D7308.ProductionTimeRate = ""
   D7308.DateInsert = ""
   D7308.DateUpdate = ""
   D7308.InchargeInsert = ""
   D7308.InchargeUpdate = ""
   D7308.CheckUse = ""
   D7308.AttachID = ""
   D7308.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7308_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7308 As T7308_AREA)
Try
    
    x7308.JobBOMCode = trim$(  x7308.JobBOMCode)
    x7308.ProcessBOMCode = trim$(  x7308.ProcessBOMCode)
    x7308.JobBOMName = trim$(  x7308.JobBOMName)
    x7308.CustomerCode = trim$(  x7308.CustomerCode)
    x7308.seSeason = trim$(  x7308.seSeason)
    x7308.cdSeason = trim$(  x7308.cdSeason)
    x7308.seOrderGroup = trim$(  x7308.seOrderGroup)
    x7308.cdOrderGroup = trim$(  x7308.cdOrderGroup)
    x7308.seShoesKind = trim$(  x7308.seShoesKind)
    x7308.cdShoesKind = trim$(  x7308.cdShoesKind)
    x7308.seShoesType = trim$(  x7308.seShoesType)
    x7308.cdShoesType = trim$(  x7308.cdShoesType)
    x7308.seSoleKind = trim$(  x7308.seSoleKind)
    x7308.cdSoleKind = trim$(  x7308.cdSoleKind)
    x7308.seMainProcess = trim$(  x7308.seMainProcess)
    x7308.cdMainProcess = trim$(  x7308.cdMainProcess)
    x7308.LevelName = trim$(  x7308.LevelName)
    x7308.Article = trim$(  x7308.Article)
    x7308.Line = trim$(  x7308.Line)
    x7308.ProductionTimeRate = trim$(  x7308.ProductionTimeRate)
    x7308.DateInsert = trim$(  x7308.DateInsert)
    x7308.DateUpdate = trim$(  x7308.DateUpdate)
    x7308.InchargeInsert = trim$(  x7308.InchargeInsert)
    x7308.InchargeUpdate = trim$(  x7308.InchargeUpdate)
    x7308.CheckUse = trim$(  x7308.CheckUse)
    x7308.AttachID = trim$(  x7308.AttachID)
    x7308.Remark = trim$(  x7308.Remark)
     
    If trim$( x7308.JobBOMCode ) = "" Then x7308.JobBOMCode = Space(1) 
    If trim$( x7308.ProcessBOMCode ) = "" Then x7308.ProcessBOMCode = Space(1) 
    If trim$( x7308.JobBOMName ) = "" Then x7308.JobBOMName = Space(1) 
    If trim$( x7308.CustomerCode ) = "" Then x7308.CustomerCode = Space(1) 
    If trim$( x7308.seSeason ) = "" Then x7308.seSeason = Space(1) 
    If trim$( x7308.cdSeason ) = "" Then x7308.cdSeason = Space(1) 
    If trim$( x7308.seOrderGroup ) = "" Then x7308.seOrderGroup = Space(1) 
    If trim$( x7308.cdOrderGroup ) = "" Then x7308.cdOrderGroup = Space(1) 
    If trim$( x7308.seShoesKind ) = "" Then x7308.seShoesKind = Space(1) 
    If trim$( x7308.cdShoesKind ) = "" Then x7308.cdShoesKind = Space(1) 
    If trim$( x7308.seShoesType ) = "" Then x7308.seShoesType = Space(1) 
    If trim$( x7308.cdShoesType ) = "" Then x7308.cdShoesType = Space(1) 
    If trim$( x7308.seSoleKind ) = "" Then x7308.seSoleKind = Space(1) 
    If trim$( x7308.cdSoleKind ) = "" Then x7308.cdSoleKind = Space(1) 
    If trim$( x7308.seMainProcess ) = "" Then x7308.seMainProcess = Space(1) 
    If trim$( x7308.cdMainProcess ) = "" Then x7308.cdMainProcess = Space(1) 
    If trim$( x7308.LevelName ) = "" Then x7308.LevelName = Space(1) 
    If trim$( x7308.Article ) = "" Then x7308.Article = Space(1) 
    If trim$( x7308.Line ) = "" Then x7308.Line = Space(1) 
    If trim$( x7308.ProductionTimeRate ) = "" Then x7308.ProductionTimeRate = Space(1) 
    If trim$( x7308.DateInsert ) = "" Then x7308.DateInsert = Space(1) 
    If trim$( x7308.DateUpdate ) = "" Then x7308.DateUpdate = Space(1) 
    If trim$( x7308.InchargeInsert ) = "" Then x7308.InchargeInsert = Space(1) 
    If trim$( x7308.InchargeUpdate ) = "" Then x7308.InchargeUpdate = Space(1) 
    If trim$( x7308.CheckUse ) = "" Then x7308.CheckUse = Space(1) 
    If trim$( x7308.AttachID ) = "" Then x7308.AttachID = Space(1) 
    If trim$( x7308.Remark ) = "" Then x7308.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7308_MOVE(rs7308 As SqlClient.SqlDataReader)
Try

    call D7308_CLEAR()   

    If IsdbNull(rs7308!K7308_JobBOMCode) = False Then D7308.JobBOMCode = Trim$(rs7308!K7308_JobBOMCode)
    If IsdbNull(rs7308!K7308_ProcessBOMCode) = False Then D7308.ProcessBOMCode = Trim$(rs7308!K7308_ProcessBOMCode)
    If IsdbNull(rs7308!K7308_JobBOMName) = False Then D7308.JobBOMName = Trim$(rs7308!K7308_JobBOMName)
    If IsdbNull(rs7308!K7308_CustomerCode) = False Then D7308.CustomerCode = Trim$(rs7308!K7308_CustomerCode)
    If IsdbNull(rs7308!K7308_seSeason) = False Then D7308.seSeason = Trim$(rs7308!K7308_seSeason)
    If IsdbNull(rs7308!K7308_cdSeason) = False Then D7308.cdSeason = Trim$(rs7308!K7308_cdSeason)
    If IsdbNull(rs7308!K7308_seOrderGroup) = False Then D7308.seOrderGroup = Trim$(rs7308!K7308_seOrderGroup)
    If IsdbNull(rs7308!K7308_cdOrderGroup) = False Then D7308.cdOrderGroup = Trim$(rs7308!K7308_cdOrderGroup)
    If IsdbNull(rs7308!K7308_seShoesKind) = False Then D7308.seShoesKind = Trim$(rs7308!K7308_seShoesKind)
    If IsdbNull(rs7308!K7308_cdShoesKind) = False Then D7308.cdShoesKind = Trim$(rs7308!K7308_cdShoesKind)
    If IsdbNull(rs7308!K7308_seShoesType) = False Then D7308.seShoesType = Trim$(rs7308!K7308_seShoesType)
    If IsdbNull(rs7308!K7308_cdShoesType) = False Then D7308.cdShoesType = Trim$(rs7308!K7308_cdShoesType)
    If IsdbNull(rs7308!K7308_seSoleKind) = False Then D7308.seSoleKind = Trim$(rs7308!K7308_seSoleKind)
    If IsdbNull(rs7308!K7308_cdSoleKind) = False Then D7308.cdSoleKind = Trim$(rs7308!K7308_cdSoleKind)
    If IsdbNull(rs7308!K7308_seMainProcess) = False Then D7308.seMainProcess = Trim$(rs7308!K7308_seMainProcess)
    If IsdbNull(rs7308!K7308_cdMainProcess) = False Then D7308.cdMainProcess = Trim$(rs7308!K7308_cdMainProcess)
    If IsdbNull(rs7308!K7308_LevelName) = False Then D7308.LevelName = Trim$(rs7308!K7308_LevelName)
    If IsdbNull(rs7308!K7308_Article) = False Then D7308.Article = Trim$(rs7308!K7308_Article)
    If IsdbNull(rs7308!K7308_Line) = False Then D7308.Line = Trim$(rs7308!K7308_Line)
    If IsdbNull(rs7308!K7308_ProductionTimeRate) = False Then D7308.ProductionTimeRate = Trim$(rs7308!K7308_ProductionTimeRate)
    If IsdbNull(rs7308!K7308_DateInsert) = False Then D7308.DateInsert = Trim$(rs7308!K7308_DateInsert)
    If IsdbNull(rs7308!K7308_DateUpdate) = False Then D7308.DateUpdate = Trim$(rs7308!K7308_DateUpdate)
    If IsdbNull(rs7308!K7308_InchargeInsert) = False Then D7308.InchargeInsert = Trim$(rs7308!K7308_InchargeInsert)
    If IsdbNull(rs7308!K7308_InchargeUpdate) = False Then D7308.InchargeUpdate = Trim$(rs7308!K7308_InchargeUpdate)
    If IsdbNull(rs7308!K7308_CheckUse) = False Then D7308.CheckUse = Trim$(rs7308!K7308_CheckUse)
    If IsdbNull(rs7308!K7308_AttachID) = False Then D7308.AttachID = Trim$(rs7308!K7308_AttachID)
    If IsdbNull(rs7308!K7308_Remark) = False Then D7308.Remark = Trim$(rs7308!K7308_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7308_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7308_MOVE(rs7308 As DataRow)
Try

    call D7308_CLEAR()   

    If IsdbNull(rs7308!K7308_JobBOMCode) = False Then D7308.JobBOMCode = Trim$(rs7308!K7308_JobBOMCode)
    If IsdbNull(rs7308!K7308_ProcessBOMCode) = False Then D7308.ProcessBOMCode = Trim$(rs7308!K7308_ProcessBOMCode)
    If IsdbNull(rs7308!K7308_JobBOMName) = False Then D7308.JobBOMName = Trim$(rs7308!K7308_JobBOMName)
    If IsdbNull(rs7308!K7308_CustomerCode) = False Then D7308.CustomerCode = Trim$(rs7308!K7308_CustomerCode)
    If IsdbNull(rs7308!K7308_seSeason) = False Then D7308.seSeason = Trim$(rs7308!K7308_seSeason)
    If IsdbNull(rs7308!K7308_cdSeason) = False Then D7308.cdSeason = Trim$(rs7308!K7308_cdSeason)
    If IsdbNull(rs7308!K7308_seOrderGroup) = False Then D7308.seOrderGroup = Trim$(rs7308!K7308_seOrderGroup)
    If IsdbNull(rs7308!K7308_cdOrderGroup) = False Then D7308.cdOrderGroup = Trim$(rs7308!K7308_cdOrderGroup)
    If IsdbNull(rs7308!K7308_seShoesKind) = False Then D7308.seShoesKind = Trim$(rs7308!K7308_seShoesKind)
    If IsdbNull(rs7308!K7308_cdShoesKind) = False Then D7308.cdShoesKind = Trim$(rs7308!K7308_cdShoesKind)
    If IsdbNull(rs7308!K7308_seShoesType) = False Then D7308.seShoesType = Trim$(rs7308!K7308_seShoesType)
    If IsdbNull(rs7308!K7308_cdShoesType) = False Then D7308.cdShoesType = Trim$(rs7308!K7308_cdShoesType)
    If IsdbNull(rs7308!K7308_seSoleKind) = False Then D7308.seSoleKind = Trim$(rs7308!K7308_seSoleKind)
    If IsdbNull(rs7308!K7308_cdSoleKind) = False Then D7308.cdSoleKind = Trim$(rs7308!K7308_cdSoleKind)
    If IsdbNull(rs7308!K7308_seMainProcess) = False Then D7308.seMainProcess = Trim$(rs7308!K7308_seMainProcess)
    If IsdbNull(rs7308!K7308_cdMainProcess) = False Then D7308.cdMainProcess = Trim$(rs7308!K7308_cdMainProcess)
    If IsdbNull(rs7308!K7308_LevelName) = False Then D7308.LevelName = Trim$(rs7308!K7308_LevelName)
    If IsdbNull(rs7308!K7308_Article) = False Then D7308.Article = Trim$(rs7308!K7308_Article)
    If IsdbNull(rs7308!K7308_Line) = False Then D7308.Line = Trim$(rs7308!K7308_Line)
    If IsdbNull(rs7308!K7308_ProductionTimeRate) = False Then D7308.ProductionTimeRate = Trim$(rs7308!K7308_ProductionTimeRate)
    If IsdbNull(rs7308!K7308_DateInsert) = False Then D7308.DateInsert = Trim$(rs7308!K7308_DateInsert)
    If IsdbNull(rs7308!K7308_DateUpdate) = False Then D7308.DateUpdate = Trim$(rs7308!K7308_DateUpdate)
    If IsdbNull(rs7308!K7308_InchargeInsert) = False Then D7308.InchargeInsert = Trim$(rs7308!K7308_InchargeInsert)
    If IsdbNull(rs7308!K7308_InchargeUpdate) = False Then D7308.InchargeUpdate = Trim$(rs7308!K7308_InchargeUpdate)
    If IsdbNull(rs7308!K7308_CheckUse) = False Then D7308.CheckUse = Trim$(rs7308!K7308_CheckUse)
    If IsdbNull(rs7308!K7308_AttachID) = False Then D7308.AttachID = Trim$(rs7308!K7308_AttachID)
    If IsdbNull(rs7308!K7308_Remark) = False Then D7308.Remark = Trim$(rs7308!K7308_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7308_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7308_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7308 As T7308_AREA, JOBBOMCODE AS String) as Boolean

K7308_MOVE = False

Try
    If READ_PFK7308(JOBBOMCODE) = True Then
                z7308 = D7308
		K7308_MOVE = True
		else
	z7308 = nothing
     End If

     If  getColumIndex(spr,"JobBOMCode") > -1 then z7308.JobBOMCode = getDataM(spr, getColumIndex(spr,"JobBOMCode"), xRow)
     If  getColumIndex(spr,"ProcessBOMCode") > -1 then z7308.ProcessBOMCode = getDataM(spr, getColumIndex(spr,"ProcessBOMCode"), xRow)
     If  getColumIndex(spr,"JobBOMName") > -1 then z7308.JobBOMName = getDataM(spr, getColumIndex(spr,"JobBOMName"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z7308.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"seSeason") > -1 then z7308.seSeason = getDataM(spr, getColumIndex(spr,"seSeason"), xRow)
     If  getColumIndex(spr,"cdSeason") > -1 then z7308.cdSeason = getDataM(spr, getColumIndex(spr,"cdSeason"), xRow)
     If  getColumIndex(spr,"seOrderGroup") > -1 then z7308.seOrderGroup = getDataM(spr, getColumIndex(spr,"seOrderGroup"), xRow)
     If  getColumIndex(spr,"cdOrderGroup") > -1 then z7308.cdOrderGroup = getDataM(spr, getColumIndex(spr,"cdOrderGroup"), xRow)
     If  getColumIndex(spr,"seShoesKind") > -1 then z7308.seShoesKind = getDataM(spr, getColumIndex(spr,"seShoesKind"), xRow)
     If  getColumIndex(spr,"cdShoesKind") > -1 then z7308.cdShoesKind = getDataM(spr, getColumIndex(spr,"cdShoesKind"), xRow)
     If  getColumIndex(spr,"seShoesType") > -1 then z7308.seShoesType = getDataM(spr, getColumIndex(spr,"seShoesType"), xRow)
     If  getColumIndex(spr,"cdShoesType") > -1 then z7308.cdShoesType = getDataM(spr, getColumIndex(spr,"cdShoesType"), xRow)
     If  getColumIndex(spr,"seSoleKind") > -1 then z7308.seSoleKind = getDataM(spr, getColumIndex(spr,"seSoleKind"), xRow)
     If  getColumIndex(spr,"cdSoleKind") > -1 then z7308.cdSoleKind = getDataM(spr, getColumIndex(spr,"cdSoleKind"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z7308.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z7308.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"LevelName") > -1 then z7308.LevelName = getDataM(spr, getColumIndex(spr,"LevelName"), xRow)
     If  getColumIndex(spr,"Article") > -1 then z7308.Article = getDataM(spr, getColumIndex(spr,"Article"), xRow)
     If  getColumIndex(spr,"Line") > -1 then z7308.Line = getDataM(spr, getColumIndex(spr,"Line"), xRow)
     If  getColumIndex(spr,"ProductionTimeRate") > -1 then z7308.ProductionTimeRate = getDataM(spr, getColumIndex(spr,"ProductionTimeRate"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7308.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7308.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7308.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7308.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7308.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z7308.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7308.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7308_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7308_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7308 As T7308_AREA,CheckClear as Boolean,JOBBOMCODE AS String) as Boolean

K7308_MOVE = False

Try
    If READ_PFK7308(JOBBOMCODE) = True Then
                z7308 = D7308
		K7308_MOVE = True
		else
	If CheckClear  = True then z7308 = nothing
     End If

     If  getColumIndex(spr,"JobBOMCode") > -1 then z7308.JobBOMCode = getDataM(spr, getColumIndex(spr,"JobBOMCode"), xRow)
     If  getColumIndex(spr,"ProcessBOMCode") > -1 then z7308.ProcessBOMCode = getDataM(spr, getColumIndex(spr,"ProcessBOMCode"), xRow)
     If  getColumIndex(spr,"JobBOMName") > -1 then z7308.JobBOMName = getDataM(spr, getColumIndex(spr,"JobBOMName"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z7308.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"seSeason") > -1 then z7308.seSeason = getDataM(spr, getColumIndex(spr,"seSeason"), xRow)
     If  getColumIndex(spr,"cdSeason") > -1 then z7308.cdSeason = getDataM(spr, getColumIndex(spr,"cdSeason"), xRow)
     If  getColumIndex(spr,"seOrderGroup") > -1 then z7308.seOrderGroup = getDataM(spr, getColumIndex(spr,"seOrderGroup"), xRow)
     If  getColumIndex(spr,"cdOrderGroup") > -1 then z7308.cdOrderGroup = getDataM(spr, getColumIndex(spr,"cdOrderGroup"), xRow)
     If  getColumIndex(spr,"seShoesKind") > -1 then z7308.seShoesKind = getDataM(spr, getColumIndex(spr,"seShoesKind"), xRow)
     If  getColumIndex(spr,"cdShoesKind") > -1 then z7308.cdShoesKind = getDataM(spr, getColumIndex(spr,"cdShoesKind"), xRow)
     If  getColumIndex(spr,"seShoesType") > -1 then z7308.seShoesType = getDataM(spr, getColumIndex(spr,"seShoesType"), xRow)
     If  getColumIndex(spr,"cdShoesType") > -1 then z7308.cdShoesType = getDataM(spr, getColumIndex(spr,"cdShoesType"), xRow)
     If  getColumIndex(spr,"seSoleKind") > -1 then z7308.seSoleKind = getDataM(spr, getColumIndex(spr,"seSoleKind"), xRow)
     If  getColumIndex(spr,"cdSoleKind") > -1 then z7308.cdSoleKind = getDataM(spr, getColumIndex(spr,"cdSoleKind"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z7308.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z7308.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"LevelName") > -1 then z7308.LevelName = getDataM(spr, getColumIndex(spr,"LevelName"), xRow)
     If  getColumIndex(spr,"Article") > -1 then z7308.Article = getDataM(spr, getColumIndex(spr,"Article"), xRow)
     If  getColumIndex(spr,"Line") > -1 then z7308.Line = getDataM(spr, getColumIndex(spr,"Line"), xRow)
     If  getColumIndex(spr,"ProductionTimeRate") > -1 then z7308.ProductionTimeRate = getDataM(spr, getColumIndex(spr,"ProductionTimeRate"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7308.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7308.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7308.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7308.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7308.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z7308.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7308.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7308_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7308_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7308 As T7308_AREA, Job as String, JOBBOMCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7308_MOVE = False

Try
    If READ_PFK7308(JOBBOMCODE) = True Then
                z7308 = D7308
		K7308_MOVE = True
		else
	z7308 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7308")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "JOBBOMCODE":z7308.JobBOMCode = Children(i).Code
   Case "PROCESSBOMCODE":z7308.ProcessBOMCode = Children(i).Code
   Case "JOBBOMNAME":z7308.JobBOMName = Children(i).Code
   Case "CUSTOMERCODE":z7308.CustomerCode = Children(i).Code
   Case "SESEASON":z7308.seSeason = Children(i).Code
   Case "CDSEASON":z7308.cdSeason = Children(i).Code
   Case "SEORDERGROUP":z7308.seOrderGroup = Children(i).Code
   Case "CDORDERGROUP":z7308.cdOrderGroup = Children(i).Code
   Case "SESHOESKIND":z7308.seShoesKind = Children(i).Code
   Case "CDSHOESKIND":z7308.cdShoesKind = Children(i).Code
   Case "SESHOESTYPE":z7308.seShoesType = Children(i).Code
   Case "CDSHOESTYPE":z7308.cdShoesType = Children(i).Code
   Case "SESOLEKIND":z7308.seSoleKind = Children(i).Code
   Case "CDSOLEKIND":z7308.cdSoleKind = Children(i).Code
   Case "SEMAINPROCESS":z7308.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z7308.cdMainProcess = Children(i).Code
   Case "LEVELNAME":z7308.LevelName = Children(i).Code
   Case "ARTICLE":z7308.Article = Children(i).Code
   Case "LINE":z7308.Line = Children(i).Code
   Case "PRODUCTIONTIMERATE":z7308.ProductionTimeRate = Children(i).Code
   Case "DATEINSERT":z7308.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7308.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7308.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7308.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7308.CheckUse = Children(i).Code
   Case "ATTACHID":z7308.AttachID = Children(i).Code
   Case "REMARK":z7308.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "JOBBOMCODE":z7308.JobBOMCode = Children(i).Data
   Case "PROCESSBOMCODE":z7308.ProcessBOMCode = Children(i).Data
   Case "JOBBOMNAME":z7308.JobBOMName = Children(i).Data
   Case "CUSTOMERCODE":z7308.CustomerCode = Children(i).Data
   Case "SESEASON":z7308.seSeason = Children(i).Data
   Case "CDSEASON":z7308.cdSeason = Children(i).Data
   Case "SEORDERGROUP":z7308.seOrderGroup = Children(i).Data
   Case "CDORDERGROUP":z7308.cdOrderGroup = Children(i).Data
   Case "SESHOESKIND":z7308.seShoesKind = Children(i).Data
   Case "CDSHOESKIND":z7308.cdShoesKind = Children(i).Data
   Case "SESHOESTYPE":z7308.seShoesType = Children(i).Data
   Case "CDSHOESTYPE":z7308.cdShoesType = Children(i).Data
   Case "SESOLEKIND":z7308.seSoleKind = Children(i).Data
   Case "CDSOLEKIND":z7308.cdSoleKind = Children(i).Data
   Case "SEMAINPROCESS":z7308.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z7308.cdMainProcess = Children(i).Data
   Case "LEVELNAME":z7308.LevelName = Children(i).Data
   Case "ARTICLE":z7308.Article = Children(i).Data
   Case "LINE":z7308.Line = Children(i).Data
   Case "PRODUCTIONTIMERATE":z7308.ProductionTimeRate = Children(i).Data
   Case "DATEINSERT":z7308.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7308.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7308.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7308.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7308.CheckUse = Children(i).Data
   Case "ATTACHID":z7308.AttachID = Children(i).Data
   Case "REMARK":z7308.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7308_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7308_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7308 As T7308_AREA, Job as String, CheckClear as Boolean, JOBBOMCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7308_MOVE = False

Try
    If READ_PFK7308(JOBBOMCODE) = True Then
                z7308 = D7308
		K7308_MOVE = True
		else
	If CheckClear  = True then z7308 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7308")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "JOBBOMCODE":z7308.JobBOMCode = Children(i).Code
   Case "PROCESSBOMCODE":z7308.ProcessBOMCode = Children(i).Code
   Case "JOBBOMNAME":z7308.JobBOMName = Children(i).Code
   Case "CUSTOMERCODE":z7308.CustomerCode = Children(i).Code
   Case "SESEASON":z7308.seSeason = Children(i).Code
   Case "CDSEASON":z7308.cdSeason = Children(i).Code
   Case "SEORDERGROUP":z7308.seOrderGroup = Children(i).Code
   Case "CDORDERGROUP":z7308.cdOrderGroup = Children(i).Code
   Case "SESHOESKIND":z7308.seShoesKind = Children(i).Code
   Case "CDSHOESKIND":z7308.cdShoesKind = Children(i).Code
   Case "SESHOESTYPE":z7308.seShoesType = Children(i).Code
   Case "CDSHOESTYPE":z7308.cdShoesType = Children(i).Code
   Case "SESOLEKIND":z7308.seSoleKind = Children(i).Code
   Case "CDSOLEKIND":z7308.cdSoleKind = Children(i).Code
   Case "SEMAINPROCESS":z7308.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z7308.cdMainProcess = Children(i).Code
   Case "LEVELNAME":z7308.LevelName = Children(i).Code
   Case "ARTICLE":z7308.Article = Children(i).Code
   Case "LINE":z7308.Line = Children(i).Code
   Case "PRODUCTIONTIMERATE":z7308.ProductionTimeRate = Children(i).Code
   Case "DATEINSERT":z7308.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7308.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7308.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7308.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7308.CheckUse = Children(i).Code
   Case "ATTACHID":z7308.AttachID = Children(i).Code
   Case "REMARK":z7308.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "JOBBOMCODE":z7308.JobBOMCode = Children(i).Data
   Case "PROCESSBOMCODE":z7308.ProcessBOMCode = Children(i).Data
   Case "JOBBOMNAME":z7308.JobBOMName = Children(i).Data
   Case "CUSTOMERCODE":z7308.CustomerCode = Children(i).Data
   Case "SESEASON":z7308.seSeason = Children(i).Data
   Case "CDSEASON":z7308.cdSeason = Children(i).Data
   Case "SEORDERGROUP":z7308.seOrderGroup = Children(i).Data
   Case "CDORDERGROUP":z7308.cdOrderGroup = Children(i).Data
   Case "SESHOESKIND":z7308.seShoesKind = Children(i).Data
   Case "CDSHOESKIND":z7308.cdShoesKind = Children(i).Data
   Case "SESHOESTYPE":z7308.seShoesType = Children(i).Data
   Case "CDSHOESTYPE":z7308.cdShoesType = Children(i).Data
   Case "SESOLEKIND":z7308.seSoleKind = Children(i).Data
   Case "CDSOLEKIND":z7308.cdSoleKind = Children(i).Data
   Case "SEMAINPROCESS":z7308.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z7308.cdMainProcess = Children(i).Data
   Case "LEVELNAME":z7308.LevelName = Children(i).Data
   Case "ARTICLE":z7308.Article = Children(i).Data
   Case "LINE":z7308.Line = Children(i).Data
   Case "PRODUCTIONTIMERATE":z7308.ProductionTimeRate = Children(i).Data
   Case "DATEINSERT":z7308.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7308.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7308.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7308.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7308.CheckUse = Children(i).Data
   Case "ATTACHID":z7308.AttachID = Children(i).Data
   Case "REMARK":z7308.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7308_MOVE",vbCritical)
End Try
End Function 
    
End Module 
