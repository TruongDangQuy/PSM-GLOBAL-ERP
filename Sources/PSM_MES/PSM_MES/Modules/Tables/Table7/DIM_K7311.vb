'=========================================================================================================================================================
'   TABLE : (PFK7311)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7311

Structure T7311_AREA
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

Public D7311 As T7311_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7311(JOBBOMCODE AS String) As Boolean
    READ_PFK7311 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7311 "
    SQL = SQL & " WHERE K7311_JobBOMCode		 = '" & JobBOMCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7311_CLEAR: GoTo SKIP_READ_PFK7311
                
    Call K7311_MOVE(rd)
    READ_PFK7311 = True

SKIP_READ_PFK7311:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7311",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7311(JOBBOMCODE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7311 "
    SQL = SQL & " WHERE K7311_JobBOMCode		 = '" & JobBOMCode & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7311",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7311(z7311 As T7311_AREA) As Boolean
    WRITE_PFK7311 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7311)
 
    SQL = " INSERT INTO PFK7311 "
    SQL = SQL & " ( "
    SQL = SQL & " K7311_JobBOMCode," 
    SQL = SQL & " K7311_ProcessBOMCode," 
    SQL = SQL & " K7311_JobBOMName," 
    SQL = SQL & " K7311_CustomerCode," 
    SQL = SQL & " K7311_seSeason," 
    SQL = SQL & " K7311_cdSeason," 
    SQL = SQL & " K7311_seOrderGroup," 
    SQL = SQL & " K7311_cdOrderGroup," 
    SQL = SQL & " K7311_seShoesKind," 
    SQL = SQL & " K7311_cdShoesKind," 
    SQL = SQL & " K7311_seShoesType," 
    SQL = SQL & " K7311_cdShoesType," 
    SQL = SQL & " K7311_seSoleKind," 
    SQL = SQL & " K7311_cdSoleKind," 
    SQL = SQL & " K7311_LevelName," 
    SQL = SQL & " K7311_Article," 
    SQL = SQL & " K7311_Line," 
    SQL = SQL & " K7311_ProductionTimeRate," 
    SQL = SQL & " K7311_DateInsert," 
    SQL = SQL & " K7311_DateUpdate," 
    SQL = SQL & " K7311_InchargeInsert," 
    SQL = SQL & " K7311_InchargeUpdate," 
    SQL = SQL & " K7311_CheckUse," 
    SQL = SQL & " K7311_AttachID," 
    SQL = SQL & " K7311_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7311.JobBOMCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7311.ProcessBOMCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7311.JobBOMName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7311.CustomerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7311.seSeason) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7311.cdSeason) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7311.seOrderGroup) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7311.cdOrderGroup) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7311.seShoesKind) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7311.cdShoesKind) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7311.seShoesType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7311.cdShoesType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7311.seSoleKind) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7311.cdSoleKind) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7311.LevelName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7311.Article) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7311.Line) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7311.ProductionTimeRate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7311.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7311.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7311.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7311.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7311.CheckUse) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7311.AttachID) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7311.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7311 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7311",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7311(z7311 As T7311_AREA) As Boolean
    REWRITE_PFK7311 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7311)
   
    SQL = " UPDATE PFK7311 SET "
    SQL = SQL & "    K7311_ProcessBOMCode      = N'" & FormatSQL(z7311.ProcessBOMCode) & "', " 
    SQL = SQL & "    K7311_JobBOMName      = N'" & FormatSQL(z7311.JobBOMName) & "', " 
    SQL = SQL & "    K7311_CustomerCode      = N'" & FormatSQL(z7311.CustomerCode) & "', " 
    SQL = SQL & "    K7311_seSeason      = N'" & FormatSQL(z7311.seSeason) & "', " 
    SQL = SQL & "    K7311_cdSeason      = N'" & FormatSQL(z7311.cdSeason) & "', " 
    SQL = SQL & "    K7311_seOrderGroup      = N'" & FormatSQL(z7311.seOrderGroup) & "', " 
    SQL = SQL & "    K7311_cdOrderGroup      = N'" & FormatSQL(z7311.cdOrderGroup) & "', " 
    SQL = SQL & "    K7311_seShoesKind      = N'" & FormatSQL(z7311.seShoesKind) & "', " 
    SQL = SQL & "    K7311_cdShoesKind      = N'" & FormatSQL(z7311.cdShoesKind) & "', " 
    SQL = SQL & "    K7311_seShoesType      = N'" & FormatSQL(z7311.seShoesType) & "', " 
    SQL = SQL & "    K7311_cdShoesType      = N'" & FormatSQL(z7311.cdShoesType) & "', " 
    SQL = SQL & "    K7311_seSoleKind      = N'" & FormatSQL(z7311.seSoleKind) & "', " 
    SQL = SQL & "    K7311_cdSoleKind      = N'" & FormatSQL(z7311.cdSoleKind) & "', " 
    SQL = SQL & "    K7311_LevelName      = N'" & FormatSQL(z7311.LevelName) & "', " 
    SQL = SQL & "    K7311_Article      = N'" & FormatSQL(z7311.Article) & "', " 
    SQL = SQL & "    K7311_Line      = N'" & FormatSQL(z7311.Line) & "', " 
    SQL = SQL & "    K7311_ProductionTimeRate      = N'" & FormatSQL(z7311.ProductionTimeRate) & "', " 
    SQL = SQL & "    K7311_DateInsert      = N'" & FormatSQL(z7311.DateInsert) & "', " 
    SQL = SQL & "    K7311_DateUpdate      = N'" & FormatSQL(z7311.DateUpdate) & "', " 
    SQL = SQL & "    K7311_InchargeInsert      = N'" & FormatSQL(z7311.InchargeInsert) & "', " 
    SQL = SQL & "    K7311_InchargeUpdate      = N'" & FormatSQL(z7311.InchargeUpdate) & "', " 
    SQL = SQL & "    K7311_CheckUse      = N'" & FormatSQL(z7311.CheckUse) & "', " 
    SQL = SQL & "    K7311_AttachID      = N'" & FormatSQL(z7311.AttachID) & "', " 
    SQL = SQL & "    K7311_Remark      = N'" & FormatSQL(z7311.Remark) & "'  " 
    SQL = SQL & " WHERE K7311_JobBOMCode		 = '" & z7311.JobBOMCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7311 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7311",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7311(z7311 As T7311_AREA) As Boolean
    DELETE_PFK7311 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7311 "
    SQL = SQL & " WHERE K7311_JobBOMCode		 = '" & z7311.JobBOMCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7311 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7311",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7311_CLEAR()
Try
    
   D7311.JobBOMCode = ""
   D7311.ProcessBOMCode = ""
   D7311.JobBOMName = ""
   D7311.CustomerCode = ""
   D7311.seSeason = ""
   D7311.cdSeason = ""
   D7311.seOrderGroup = ""
   D7311.cdOrderGroup = ""
   D7311.seShoesKind = ""
   D7311.cdShoesKind = ""
   D7311.seShoesType = ""
   D7311.cdShoesType = ""
   D7311.seSoleKind = ""
   D7311.cdSoleKind = ""
   D7311.LevelName = ""
   D7311.Article = ""
   D7311.Line = ""
   D7311.ProductionTimeRate = ""
   D7311.DateInsert = ""
   D7311.DateUpdate = ""
   D7311.InchargeInsert = ""
   D7311.InchargeUpdate = ""
   D7311.CheckUse = ""
   D7311.AttachID = ""
   D7311.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7311_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7311 As T7311_AREA)
Try
    
    x7311.JobBOMCode = trim$(  x7311.JobBOMCode)
    x7311.ProcessBOMCode = trim$(  x7311.ProcessBOMCode)
    x7311.JobBOMName = trim$(  x7311.JobBOMName)
    x7311.CustomerCode = trim$(  x7311.CustomerCode)
    x7311.seSeason = trim$(  x7311.seSeason)
    x7311.cdSeason = trim$(  x7311.cdSeason)
    x7311.seOrderGroup = trim$(  x7311.seOrderGroup)
    x7311.cdOrderGroup = trim$(  x7311.cdOrderGroup)
    x7311.seShoesKind = trim$(  x7311.seShoesKind)
    x7311.cdShoesKind = trim$(  x7311.cdShoesKind)
    x7311.seShoesType = trim$(  x7311.seShoesType)
    x7311.cdShoesType = trim$(  x7311.cdShoesType)
    x7311.seSoleKind = trim$(  x7311.seSoleKind)
    x7311.cdSoleKind = trim$(  x7311.cdSoleKind)
    x7311.LevelName = trim$(  x7311.LevelName)
    x7311.Article = trim$(  x7311.Article)
    x7311.Line = trim$(  x7311.Line)
    x7311.ProductionTimeRate = trim$(  x7311.ProductionTimeRate)
    x7311.DateInsert = trim$(  x7311.DateInsert)
    x7311.DateUpdate = trim$(  x7311.DateUpdate)
    x7311.InchargeInsert = trim$(  x7311.InchargeInsert)
    x7311.InchargeUpdate = trim$(  x7311.InchargeUpdate)
    x7311.CheckUse = trim$(  x7311.CheckUse)
    x7311.AttachID = trim$(  x7311.AttachID)
    x7311.Remark = trim$(  x7311.Remark)
     
    If trim$( x7311.JobBOMCode ) = "" Then x7311.JobBOMCode = Space(1) 
    If trim$( x7311.ProcessBOMCode ) = "" Then x7311.ProcessBOMCode = Space(1) 
    If trim$( x7311.JobBOMName ) = "" Then x7311.JobBOMName = Space(1) 
    If trim$( x7311.CustomerCode ) = "" Then x7311.CustomerCode = Space(1) 
    If trim$( x7311.seSeason ) = "" Then x7311.seSeason = Space(1) 
    If trim$( x7311.cdSeason ) = "" Then x7311.cdSeason = Space(1) 
    If trim$( x7311.seOrderGroup ) = "" Then x7311.seOrderGroup = Space(1) 
    If trim$( x7311.cdOrderGroup ) = "" Then x7311.cdOrderGroup = Space(1) 
    If trim$( x7311.seShoesKind ) = "" Then x7311.seShoesKind = Space(1) 
    If trim$( x7311.cdShoesKind ) = "" Then x7311.cdShoesKind = Space(1) 
    If trim$( x7311.seShoesType ) = "" Then x7311.seShoesType = Space(1) 
    If trim$( x7311.cdShoesType ) = "" Then x7311.cdShoesType = Space(1) 
    If trim$( x7311.seSoleKind ) = "" Then x7311.seSoleKind = Space(1) 
    If trim$( x7311.cdSoleKind ) = "" Then x7311.cdSoleKind = Space(1) 
    If trim$( x7311.LevelName ) = "" Then x7311.LevelName = Space(1) 
    If trim$( x7311.Article ) = "" Then x7311.Article = Space(1) 
    If trim$( x7311.Line ) = "" Then x7311.Line = Space(1) 
    If trim$( x7311.ProductionTimeRate ) = "" Then x7311.ProductionTimeRate = Space(1) 
    If trim$( x7311.DateInsert ) = "" Then x7311.DateInsert = Space(1) 
    If trim$( x7311.DateUpdate ) = "" Then x7311.DateUpdate = Space(1) 
    If trim$( x7311.InchargeInsert ) = "" Then x7311.InchargeInsert = Space(1) 
    If trim$( x7311.InchargeUpdate ) = "" Then x7311.InchargeUpdate = Space(1) 
    If trim$( x7311.CheckUse ) = "" Then x7311.CheckUse = Space(1) 
    If trim$( x7311.AttachID ) = "" Then x7311.AttachID = Space(1) 
    If trim$( x7311.Remark ) = "" Then x7311.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7311_MOVE(rs7311 As SqlClient.SqlDataReader)
Try

    call D7311_CLEAR()   

    If IsdbNull(rs7311!K7311_JobBOMCode) = False Then D7311.JobBOMCode = Trim$(rs7311!K7311_JobBOMCode)
    If IsdbNull(rs7311!K7311_ProcessBOMCode) = False Then D7311.ProcessBOMCode = Trim$(rs7311!K7311_ProcessBOMCode)
    If IsdbNull(rs7311!K7311_JobBOMName) = False Then D7311.JobBOMName = Trim$(rs7311!K7311_JobBOMName)
    If IsdbNull(rs7311!K7311_CustomerCode) = False Then D7311.CustomerCode = Trim$(rs7311!K7311_CustomerCode)
    If IsdbNull(rs7311!K7311_seSeason) = False Then D7311.seSeason = Trim$(rs7311!K7311_seSeason)
    If IsdbNull(rs7311!K7311_cdSeason) = False Then D7311.cdSeason = Trim$(rs7311!K7311_cdSeason)
    If IsdbNull(rs7311!K7311_seOrderGroup) = False Then D7311.seOrderGroup = Trim$(rs7311!K7311_seOrderGroup)
    If IsdbNull(rs7311!K7311_cdOrderGroup) = False Then D7311.cdOrderGroup = Trim$(rs7311!K7311_cdOrderGroup)
    If IsdbNull(rs7311!K7311_seShoesKind) = False Then D7311.seShoesKind = Trim$(rs7311!K7311_seShoesKind)
    If IsdbNull(rs7311!K7311_cdShoesKind) = False Then D7311.cdShoesKind = Trim$(rs7311!K7311_cdShoesKind)
    If IsdbNull(rs7311!K7311_seShoesType) = False Then D7311.seShoesType = Trim$(rs7311!K7311_seShoesType)
    If IsdbNull(rs7311!K7311_cdShoesType) = False Then D7311.cdShoesType = Trim$(rs7311!K7311_cdShoesType)
    If IsdbNull(rs7311!K7311_seSoleKind) = False Then D7311.seSoleKind = Trim$(rs7311!K7311_seSoleKind)
    If IsdbNull(rs7311!K7311_cdSoleKind) = False Then D7311.cdSoleKind = Trim$(rs7311!K7311_cdSoleKind)
    If IsdbNull(rs7311!K7311_LevelName) = False Then D7311.LevelName = Trim$(rs7311!K7311_LevelName)
    If IsdbNull(rs7311!K7311_Article) = False Then D7311.Article = Trim$(rs7311!K7311_Article)
    If IsdbNull(rs7311!K7311_Line) = False Then D7311.Line = Trim$(rs7311!K7311_Line)
    If IsdbNull(rs7311!K7311_ProductionTimeRate) = False Then D7311.ProductionTimeRate = Trim$(rs7311!K7311_ProductionTimeRate)
    If IsdbNull(rs7311!K7311_DateInsert) = False Then D7311.DateInsert = Trim$(rs7311!K7311_DateInsert)
    If IsdbNull(rs7311!K7311_DateUpdate) = False Then D7311.DateUpdate = Trim$(rs7311!K7311_DateUpdate)
    If IsdbNull(rs7311!K7311_InchargeInsert) = False Then D7311.InchargeInsert = Trim$(rs7311!K7311_InchargeInsert)
    If IsdbNull(rs7311!K7311_InchargeUpdate) = False Then D7311.InchargeUpdate = Trim$(rs7311!K7311_InchargeUpdate)
    If IsdbNull(rs7311!K7311_CheckUse) = False Then D7311.CheckUse = Trim$(rs7311!K7311_CheckUse)
    If IsdbNull(rs7311!K7311_AttachID) = False Then D7311.AttachID = Trim$(rs7311!K7311_AttachID)
    If IsdbNull(rs7311!K7311_Remark) = False Then D7311.Remark = Trim$(rs7311!K7311_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7311_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7311_MOVE(rs7311 As DataRow)
Try

    call D7311_CLEAR()   

    If IsdbNull(rs7311!K7311_JobBOMCode) = False Then D7311.JobBOMCode = Trim$(rs7311!K7311_JobBOMCode)
    If IsdbNull(rs7311!K7311_ProcessBOMCode) = False Then D7311.ProcessBOMCode = Trim$(rs7311!K7311_ProcessBOMCode)
    If IsdbNull(rs7311!K7311_JobBOMName) = False Then D7311.JobBOMName = Trim$(rs7311!K7311_JobBOMName)
    If IsdbNull(rs7311!K7311_CustomerCode) = False Then D7311.CustomerCode = Trim$(rs7311!K7311_CustomerCode)
    If IsdbNull(rs7311!K7311_seSeason) = False Then D7311.seSeason = Trim$(rs7311!K7311_seSeason)
    If IsdbNull(rs7311!K7311_cdSeason) = False Then D7311.cdSeason = Trim$(rs7311!K7311_cdSeason)
    If IsdbNull(rs7311!K7311_seOrderGroup) = False Then D7311.seOrderGroup = Trim$(rs7311!K7311_seOrderGroup)
    If IsdbNull(rs7311!K7311_cdOrderGroup) = False Then D7311.cdOrderGroup = Trim$(rs7311!K7311_cdOrderGroup)
    If IsdbNull(rs7311!K7311_seShoesKind) = False Then D7311.seShoesKind = Trim$(rs7311!K7311_seShoesKind)
    If IsdbNull(rs7311!K7311_cdShoesKind) = False Then D7311.cdShoesKind = Trim$(rs7311!K7311_cdShoesKind)
    If IsdbNull(rs7311!K7311_seShoesType) = False Then D7311.seShoesType = Trim$(rs7311!K7311_seShoesType)
    If IsdbNull(rs7311!K7311_cdShoesType) = False Then D7311.cdShoesType = Trim$(rs7311!K7311_cdShoesType)
    If IsdbNull(rs7311!K7311_seSoleKind) = False Then D7311.seSoleKind = Trim$(rs7311!K7311_seSoleKind)
    If IsdbNull(rs7311!K7311_cdSoleKind) = False Then D7311.cdSoleKind = Trim$(rs7311!K7311_cdSoleKind)
    If IsdbNull(rs7311!K7311_LevelName) = False Then D7311.LevelName = Trim$(rs7311!K7311_LevelName)
    If IsdbNull(rs7311!K7311_Article) = False Then D7311.Article = Trim$(rs7311!K7311_Article)
    If IsdbNull(rs7311!K7311_Line) = False Then D7311.Line = Trim$(rs7311!K7311_Line)
    If IsdbNull(rs7311!K7311_ProductionTimeRate) = False Then D7311.ProductionTimeRate = Trim$(rs7311!K7311_ProductionTimeRate)
    If IsdbNull(rs7311!K7311_DateInsert) = False Then D7311.DateInsert = Trim$(rs7311!K7311_DateInsert)
    If IsdbNull(rs7311!K7311_DateUpdate) = False Then D7311.DateUpdate = Trim$(rs7311!K7311_DateUpdate)
    If IsdbNull(rs7311!K7311_InchargeInsert) = False Then D7311.InchargeInsert = Trim$(rs7311!K7311_InchargeInsert)
    If IsdbNull(rs7311!K7311_InchargeUpdate) = False Then D7311.InchargeUpdate = Trim$(rs7311!K7311_InchargeUpdate)
    If IsdbNull(rs7311!K7311_CheckUse) = False Then D7311.CheckUse = Trim$(rs7311!K7311_CheckUse)
    If IsdbNull(rs7311!K7311_AttachID) = False Then D7311.AttachID = Trim$(rs7311!K7311_AttachID)
    If IsdbNull(rs7311!K7311_Remark) = False Then D7311.Remark = Trim$(rs7311!K7311_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7311_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7311_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7311 As T7311_AREA, JOBBOMCODE AS String) as Boolean

K7311_MOVE = False

Try
    If READ_PFK7311(JOBBOMCODE) = True Then
                z7311 = D7311
		K7311_MOVE = True
		else
	z7311 = nothing
     End If

     If  getColumIndex(spr,"JobBOMCode") > -1 then z7311.JobBOMCode = getDataM(spr, getColumIndex(spr,"JobBOMCode"), xRow)
     If  getColumIndex(spr,"ProcessBOMCode") > -1 then z7311.ProcessBOMCode = getDataM(spr, getColumIndex(spr,"ProcessBOMCode"), xRow)
     If  getColumIndex(spr,"JobBOMName") > -1 then z7311.JobBOMName = getDataM(spr, getColumIndex(spr,"JobBOMName"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z7311.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"seSeason") > -1 then z7311.seSeason = getDataM(spr, getColumIndex(spr,"seSeason"), xRow)
     If  getColumIndex(spr,"cdSeason") > -1 then z7311.cdSeason = getDataM(spr, getColumIndex(spr,"cdSeason"), xRow)
     If  getColumIndex(spr,"seOrderGroup") > -1 then z7311.seOrderGroup = getDataM(spr, getColumIndex(spr,"seOrderGroup"), xRow)
     If  getColumIndex(spr,"cdOrderGroup") > -1 then z7311.cdOrderGroup = getDataM(spr, getColumIndex(spr,"cdOrderGroup"), xRow)
     If  getColumIndex(spr,"seShoesKind") > -1 then z7311.seShoesKind = getDataM(spr, getColumIndex(spr,"seShoesKind"), xRow)
     If  getColumIndex(spr,"cdShoesKind") > -1 then z7311.cdShoesKind = getDataM(spr, getColumIndex(spr,"cdShoesKind"), xRow)
     If  getColumIndex(spr,"seShoesType") > -1 then z7311.seShoesType = getDataM(spr, getColumIndex(spr,"seShoesType"), xRow)
     If  getColumIndex(spr,"cdShoesType") > -1 then z7311.cdShoesType = getDataM(spr, getColumIndex(spr,"cdShoesType"), xRow)
     If  getColumIndex(spr,"seSoleKind") > -1 then z7311.seSoleKind = getDataM(spr, getColumIndex(spr,"seSoleKind"), xRow)
     If  getColumIndex(spr,"cdSoleKind") > -1 then z7311.cdSoleKind = getDataM(spr, getColumIndex(spr,"cdSoleKind"), xRow)
     If  getColumIndex(spr,"LevelName") > -1 then z7311.LevelName = getDataM(spr, getColumIndex(spr,"LevelName"), xRow)
     If  getColumIndex(spr,"Article") > -1 then z7311.Article = getDataM(spr, getColumIndex(spr,"Article"), xRow)
     If  getColumIndex(spr,"Line") > -1 then z7311.Line = getDataM(spr, getColumIndex(spr,"Line"), xRow)
     If  getColumIndex(spr,"ProductionTimeRate") > -1 then z7311.ProductionTimeRate = getDataM(spr, getColumIndex(spr,"ProductionTimeRate"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7311.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7311.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7311.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7311.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7311.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z7311.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7311.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7311_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7311_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7311 As T7311_AREA,CheckClear as Boolean,JOBBOMCODE AS String) as Boolean

K7311_MOVE = False

Try
    If READ_PFK7311(JOBBOMCODE) = True Then
                z7311 = D7311
		K7311_MOVE = True
		else
	If CheckClear  = True then z7311 = nothing
     End If

     If  getColumIndex(spr,"JobBOMCode") > -1 then z7311.JobBOMCode = getDataM(spr, getColumIndex(spr,"JobBOMCode"), xRow)
     If  getColumIndex(spr,"ProcessBOMCode") > -1 then z7311.ProcessBOMCode = getDataM(spr, getColumIndex(spr,"ProcessBOMCode"), xRow)
     If  getColumIndex(spr,"JobBOMName") > -1 then z7311.JobBOMName = getDataM(spr, getColumIndex(spr,"JobBOMName"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z7311.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"seSeason") > -1 then z7311.seSeason = getDataM(spr, getColumIndex(spr,"seSeason"), xRow)
     If  getColumIndex(spr,"cdSeason") > -1 then z7311.cdSeason = getDataM(spr, getColumIndex(spr,"cdSeason"), xRow)
     If  getColumIndex(spr,"seOrderGroup") > -1 then z7311.seOrderGroup = getDataM(spr, getColumIndex(spr,"seOrderGroup"), xRow)
     If  getColumIndex(spr,"cdOrderGroup") > -1 then z7311.cdOrderGroup = getDataM(spr, getColumIndex(spr,"cdOrderGroup"), xRow)
     If  getColumIndex(spr,"seShoesKind") > -1 then z7311.seShoesKind = getDataM(spr, getColumIndex(spr,"seShoesKind"), xRow)
     If  getColumIndex(spr,"cdShoesKind") > -1 then z7311.cdShoesKind = getDataM(spr, getColumIndex(spr,"cdShoesKind"), xRow)
     If  getColumIndex(spr,"seShoesType") > -1 then z7311.seShoesType = getDataM(spr, getColumIndex(spr,"seShoesType"), xRow)
     If  getColumIndex(spr,"cdShoesType") > -1 then z7311.cdShoesType = getDataM(spr, getColumIndex(spr,"cdShoesType"), xRow)
     If  getColumIndex(spr,"seSoleKind") > -1 then z7311.seSoleKind = getDataM(spr, getColumIndex(spr,"seSoleKind"), xRow)
     If  getColumIndex(spr,"cdSoleKind") > -1 then z7311.cdSoleKind = getDataM(spr, getColumIndex(spr,"cdSoleKind"), xRow)
     If  getColumIndex(spr,"LevelName") > -1 then z7311.LevelName = getDataM(spr, getColumIndex(spr,"LevelName"), xRow)
     If  getColumIndex(spr,"Article") > -1 then z7311.Article = getDataM(spr, getColumIndex(spr,"Article"), xRow)
     If  getColumIndex(spr,"Line") > -1 then z7311.Line = getDataM(spr, getColumIndex(spr,"Line"), xRow)
     If  getColumIndex(spr,"ProductionTimeRate") > -1 then z7311.ProductionTimeRate = getDataM(spr, getColumIndex(spr,"ProductionTimeRate"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7311.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7311.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7311.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7311.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7311.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z7311.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7311.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7311_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7311_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7311 As T7311_AREA, Job as String, JOBBOMCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7311_MOVE = False

Try
    If READ_PFK7311(JOBBOMCODE) = True Then
                z7311 = D7311
		K7311_MOVE = True
		else
	z7311 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7311")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "JOBBOMCODE":z7311.JobBOMCode = Children(i).Code
   Case "PROCESSBOMCODE":z7311.ProcessBOMCode = Children(i).Code
   Case "JOBBOMNAME":z7311.JobBOMName = Children(i).Code
   Case "CUSTOMERCODE":z7311.CustomerCode = Children(i).Code
   Case "SESEASON":z7311.seSeason = Children(i).Code
   Case "CDSEASON":z7311.cdSeason = Children(i).Code
   Case "SEORDERGROUP":z7311.seOrderGroup = Children(i).Code
   Case "CDORDERGROUP":z7311.cdOrderGroup = Children(i).Code
   Case "SESHOESKIND":z7311.seShoesKind = Children(i).Code
   Case "CDSHOESKIND":z7311.cdShoesKind = Children(i).Code
   Case "SESHOESTYPE":z7311.seShoesType = Children(i).Code
   Case "CDSHOESTYPE":z7311.cdShoesType = Children(i).Code
   Case "SESOLEKIND":z7311.seSoleKind = Children(i).Code
   Case "CDSOLEKIND":z7311.cdSoleKind = Children(i).Code
   Case "LEVELNAME":z7311.LevelName = Children(i).Code
   Case "ARTICLE":z7311.Article = Children(i).Code
   Case "LINE":z7311.Line = Children(i).Code
   Case "PRODUCTIONTIMERATE":z7311.ProductionTimeRate = Children(i).Code
   Case "DATEINSERT":z7311.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7311.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7311.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7311.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7311.CheckUse = Children(i).Code
   Case "ATTACHID":z7311.AttachID = Children(i).Code
   Case "REMARK":z7311.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "JOBBOMCODE":z7311.JobBOMCode = Children(i).Data
   Case "PROCESSBOMCODE":z7311.ProcessBOMCode = Children(i).Data
   Case "JOBBOMNAME":z7311.JobBOMName = Children(i).Data
   Case "CUSTOMERCODE":z7311.CustomerCode = Children(i).Data
   Case "SESEASON":z7311.seSeason = Children(i).Data
   Case "CDSEASON":z7311.cdSeason = Children(i).Data
   Case "SEORDERGROUP":z7311.seOrderGroup = Children(i).Data
   Case "CDORDERGROUP":z7311.cdOrderGroup = Children(i).Data
   Case "SESHOESKIND":z7311.seShoesKind = Children(i).Data
   Case "CDSHOESKIND":z7311.cdShoesKind = Children(i).Data
   Case "SESHOESTYPE":z7311.seShoesType = Children(i).Data
   Case "CDSHOESTYPE":z7311.cdShoesType = Children(i).Data
   Case "SESOLEKIND":z7311.seSoleKind = Children(i).Data
   Case "CDSOLEKIND":z7311.cdSoleKind = Children(i).Data
   Case "LEVELNAME":z7311.LevelName = Children(i).Data
   Case "ARTICLE":z7311.Article = Children(i).Data
   Case "LINE":z7311.Line = Children(i).Data
   Case "PRODUCTIONTIMERATE":z7311.ProductionTimeRate = Children(i).Data
   Case "DATEINSERT":z7311.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7311.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7311.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7311.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7311.CheckUse = Children(i).Data
   Case "ATTACHID":z7311.AttachID = Children(i).Data
   Case "REMARK":z7311.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7311_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7311_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7311 As T7311_AREA, Job as String, CheckClear as Boolean, JOBBOMCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7311_MOVE = False

Try
    If READ_PFK7311(JOBBOMCODE) = True Then
                z7311 = D7311
		K7311_MOVE = True
		else
	If CheckClear  = True then z7311 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7311")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "JOBBOMCODE":z7311.JobBOMCode = Children(i).Code
   Case "PROCESSBOMCODE":z7311.ProcessBOMCode = Children(i).Code
   Case "JOBBOMNAME":z7311.JobBOMName = Children(i).Code
   Case "CUSTOMERCODE":z7311.CustomerCode = Children(i).Code
   Case "SESEASON":z7311.seSeason = Children(i).Code
   Case "CDSEASON":z7311.cdSeason = Children(i).Code
   Case "SEORDERGROUP":z7311.seOrderGroup = Children(i).Code
   Case "CDORDERGROUP":z7311.cdOrderGroup = Children(i).Code
   Case "SESHOESKIND":z7311.seShoesKind = Children(i).Code
   Case "CDSHOESKIND":z7311.cdShoesKind = Children(i).Code
   Case "SESHOESTYPE":z7311.seShoesType = Children(i).Code
   Case "CDSHOESTYPE":z7311.cdShoesType = Children(i).Code
   Case "SESOLEKIND":z7311.seSoleKind = Children(i).Code
   Case "CDSOLEKIND":z7311.cdSoleKind = Children(i).Code
   Case "LEVELNAME":z7311.LevelName = Children(i).Code
   Case "ARTICLE":z7311.Article = Children(i).Code
   Case "LINE":z7311.Line = Children(i).Code
   Case "PRODUCTIONTIMERATE":z7311.ProductionTimeRate = Children(i).Code
   Case "DATEINSERT":z7311.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7311.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7311.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7311.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7311.CheckUse = Children(i).Code
   Case "ATTACHID":z7311.AttachID = Children(i).Code
   Case "REMARK":z7311.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "JOBBOMCODE":z7311.JobBOMCode = Children(i).Data
   Case "PROCESSBOMCODE":z7311.ProcessBOMCode = Children(i).Data
   Case "JOBBOMNAME":z7311.JobBOMName = Children(i).Data
   Case "CUSTOMERCODE":z7311.CustomerCode = Children(i).Data
   Case "SESEASON":z7311.seSeason = Children(i).Data
   Case "CDSEASON":z7311.cdSeason = Children(i).Data
   Case "SEORDERGROUP":z7311.seOrderGroup = Children(i).Data
   Case "CDORDERGROUP":z7311.cdOrderGroup = Children(i).Data
   Case "SESHOESKIND":z7311.seShoesKind = Children(i).Data
   Case "CDSHOESKIND":z7311.cdShoesKind = Children(i).Data
   Case "SESHOESTYPE":z7311.seShoesType = Children(i).Data
   Case "CDSHOESTYPE":z7311.cdShoesType = Children(i).Data
   Case "SESOLEKIND":z7311.seSoleKind = Children(i).Data
   Case "CDSOLEKIND":z7311.cdSoleKind = Children(i).Data
   Case "LEVELNAME":z7311.LevelName = Children(i).Data
   Case "ARTICLE":z7311.Article = Children(i).Data
   Case "LINE":z7311.Line = Children(i).Data
   Case "PRODUCTIONTIMERATE":z7311.ProductionTimeRate = Children(i).Data
   Case "DATEINSERT":z7311.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7311.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7311.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7311.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7311.CheckUse = Children(i).Data
   Case "ATTACHID":z7311.AttachID = Children(i).Data
   Case "REMARK":z7311.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7311_MOVE",vbCritical)
End Try
End Function 
    
End Module 
