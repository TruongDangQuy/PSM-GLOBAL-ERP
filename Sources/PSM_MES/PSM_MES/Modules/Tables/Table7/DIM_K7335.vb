'=========================================================================================================================================================
'   TABLE : (PFK7335)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7335

Structure T7335_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	ProcessBOMCode	 AS String	'			nvarchar(6)		*
Public 	ProcessBOMName	 AS String	'			nvarchar(200)
Public 	CustomerCode	 AS String	'			char(6)
Public 	seSeason	 AS String	'			char(3)
Public 	cdSeason	 AS String	'			char(3)
Public 	seOrderGroup	 AS String	'			char(3)
Public 	cdOrderGroup	 AS String	'			char(3)
Public 	seShoesKind	 AS String	'			char(3)
Public 	cdShoesKind	 AS String	'			char(3)
Public 	seShoesType	 AS String	'			char(3)
Public 	cdShoesType	 AS String	'			char(3)
Public 	Article	 AS String	'			nvarchar(100)
Public 	Line	 AS String	'			nvarchar(100)
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

Public D7335 As T7335_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7335(PROCESSBOMCODE AS String) As Boolean
    READ_PFK7335 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7335 "
    SQL = SQL & " WHERE K7335_ProcessBOMCode		 = '" & ProcessBOMCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7335_CLEAR: GoTo SKIP_READ_PFK7335
                
    Call K7335_MOVE(rd)
    READ_PFK7335 = True

SKIP_READ_PFK7335:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7335",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7335(PROCESSBOMCODE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7335 "
    SQL = SQL & " WHERE K7335_ProcessBOMCode		 = '" & ProcessBOMCode & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7335",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7335(z7335 As T7335_AREA) As Boolean
    WRITE_PFK7335 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7335)
 
    SQL = " INSERT INTO PFK7335 "
    SQL = SQL & " ( "
    SQL = SQL & " K7335_ProcessBOMCode," 
    SQL = SQL & " K7335_ProcessBOMName," 
    SQL = SQL & " K7335_CustomerCode," 
    SQL = SQL & " K7335_seSeason," 
    SQL = SQL & " K7335_cdSeason," 
    SQL = SQL & " K7335_seOrderGroup," 
    SQL = SQL & " K7335_cdOrderGroup," 
    SQL = SQL & " K7335_seShoesKind," 
    SQL = SQL & " K7335_cdShoesKind," 
    SQL = SQL & " K7335_seShoesType," 
    SQL = SQL & " K7335_cdShoesType," 
    SQL = SQL & " K7335_Article," 
    SQL = SQL & " K7335_Line," 
    SQL = SQL & " K7335_DateInsert," 
    SQL = SQL & " K7335_DateUpdate," 
    SQL = SQL & " K7335_InchargeInsert," 
    SQL = SQL & " K7335_InchargeUpdate," 
    SQL = SQL & " K7335_CheckUse," 
    SQL = SQL & " K7335_DateActive," 
    SQL = SQL & " K7335_DateDeactive," 
    SQL = SQL & " K7335_CheckActive," 
    SQL = SQL & " K7335_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7335.ProcessBOMCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7335.ProcessBOMName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7335.CustomerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7335.seSeason) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7335.cdSeason) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7335.seOrderGroup) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7335.cdOrderGroup) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7335.seShoesKind) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7335.cdShoesKind) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7335.seShoesType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7335.cdShoesType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7335.Article) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7335.Line) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7335.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7335.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7335.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7335.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7335.CheckUse) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7335.DateActive) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7335.DateDeactive) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7335.CheckActive) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7335.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7335 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7335",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7335(z7335 As T7335_AREA) As Boolean
    REWRITE_PFK7335 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7335)
   
    SQL = " UPDATE PFK7335 SET "
    SQL = SQL & "    K7335_ProcessBOMName      = N'" & FormatSQL(z7335.ProcessBOMName) & "', " 
    SQL = SQL & "    K7335_CustomerCode      = N'" & FormatSQL(z7335.CustomerCode) & "', " 
    SQL = SQL & "    K7335_seSeason      = N'" & FormatSQL(z7335.seSeason) & "', " 
    SQL = SQL & "    K7335_cdSeason      = N'" & FormatSQL(z7335.cdSeason) & "', " 
    SQL = SQL & "    K7335_seOrderGroup      = N'" & FormatSQL(z7335.seOrderGroup) & "', " 
    SQL = SQL & "    K7335_cdOrderGroup      = N'" & FormatSQL(z7335.cdOrderGroup) & "', " 
    SQL = SQL & "    K7335_seShoesKind      = N'" & FormatSQL(z7335.seShoesKind) & "', " 
    SQL = SQL & "    K7335_cdShoesKind      = N'" & FormatSQL(z7335.cdShoesKind) & "', " 
    SQL = SQL & "    K7335_seShoesType      = N'" & FormatSQL(z7335.seShoesType) & "', " 
    SQL = SQL & "    K7335_cdShoesType      = N'" & FormatSQL(z7335.cdShoesType) & "', " 
    SQL = SQL & "    K7335_Article      = N'" & FormatSQL(z7335.Article) & "', " 
    SQL = SQL & "    K7335_Line      = N'" & FormatSQL(z7335.Line) & "', " 
    SQL = SQL & "    K7335_DateInsert      = N'" & FormatSQL(z7335.DateInsert) & "', " 
    SQL = SQL & "    K7335_DateUpdate      = N'" & FormatSQL(z7335.DateUpdate) & "', " 
    SQL = SQL & "    K7335_InchargeInsert      = N'" & FormatSQL(z7335.InchargeInsert) & "', " 
    SQL = SQL & "    K7335_InchargeUpdate      = N'" & FormatSQL(z7335.InchargeUpdate) & "', " 
    SQL = SQL & "    K7335_CheckUse      = N'" & FormatSQL(z7335.CheckUse) & "', " 
    SQL = SQL & "    K7335_DateActive      = N'" & FormatSQL(z7335.DateActive) & "', " 
    SQL = SQL & "    K7335_DateDeactive      = N'" & FormatSQL(z7335.DateDeactive) & "', " 
    SQL = SQL & "    K7335_CheckActive      = N'" & FormatSQL(z7335.CheckActive) & "', " 
    SQL = SQL & "    K7335_Remark      = N'" & FormatSQL(z7335.Remark) & "'  " 
    SQL = SQL & " WHERE K7335_ProcessBOMCode		 = '" & z7335.ProcessBOMCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7335 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7335",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7335(z7335 As T7335_AREA) As Boolean
    DELETE_PFK7335 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7335 "
    SQL = SQL & " WHERE K7335_ProcessBOMCode		 = '" & z7335.ProcessBOMCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7335 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7335",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7335_CLEAR()
Try
    
   D7335.ProcessBOMCode = ""
   D7335.ProcessBOMName = ""
   D7335.CustomerCode = ""
   D7335.seSeason = ""
   D7335.cdSeason = ""
   D7335.seOrderGroup = ""
   D7335.cdOrderGroup = ""
   D7335.seShoesKind = ""
   D7335.cdShoesKind = ""
   D7335.seShoesType = ""
   D7335.cdShoesType = ""
   D7335.Article = ""
   D7335.Line = ""
   D7335.DateInsert = ""
   D7335.DateUpdate = ""
   D7335.InchargeInsert = ""
   D7335.InchargeUpdate = ""
   D7335.CheckUse = ""
   D7335.DateActive = ""
   D7335.DateDeactive = ""
   D7335.CheckActive = ""
   D7335.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7335_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7335 As T7335_AREA)
Try
    
    x7335.ProcessBOMCode = trim$(  x7335.ProcessBOMCode)
    x7335.ProcessBOMName = trim$(  x7335.ProcessBOMName)
    x7335.CustomerCode = trim$(  x7335.CustomerCode)
    x7335.seSeason = trim$(  x7335.seSeason)
    x7335.cdSeason = trim$(  x7335.cdSeason)
    x7335.seOrderGroup = trim$(  x7335.seOrderGroup)
    x7335.cdOrderGroup = trim$(  x7335.cdOrderGroup)
    x7335.seShoesKind = trim$(  x7335.seShoesKind)
    x7335.cdShoesKind = trim$(  x7335.cdShoesKind)
    x7335.seShoesType = trim$(  x7335.seShoesType)
    x7335.cdShoesType = trim$(  x7335.cdShoesType)
    x7335.Article = trim$(  x7335.Article)
    x7335.Line = trim$(  x7335.Line)
    x7335.DateInsert = trim$(  x7335.DateInsert)
    x7335.DateUpdate = trim$(  x7335.DateUpdate)
    x7335.InchargeInsert = trim$(  x7335.InchargeInsert)
    x7335.InchargeUpdate = trim$(  x7335.InchargeUpdate)
    x7335.CheckUse = trim$(  x7335.CheckUse)
    x7335.DateActive = trim$(  x7335.DateActive)
    x7335.DateDeactive = trim$(  x7335.DateDeactive)
    x7335.CheckActive = trim$(  x7335.CheckActive)
    x7335.Remark = trim$(  x7335.Remark)
     
    If trim$( x7335.ProcessBOMCode ) = "" Then x7335.ProcessBOMCode = Space(1) 
    If trim$( x7335.ProcessBOMName ) = "" Then x7335.ProcessBOMName = Space(1) 
    If trim$( x7335.CustomerCode ) = "" Then x7335.CustomerCode = Space(1) 
    If trim$( x7335.seSeason ) = "" Then x7335.seSeason = Space(1) 
    If trim$( x7335.cdSeason ) = "" Then x7335.cdSeason = Space(1) 
    If trim$( x7335.seOrderGroup ) = "" Then x7335.seOrderGroup = Space(1) 
    If trim$( x7335.cdOrderGroup ) = "" Then x7335.cdOrderGroup = Space(1) 
    If trim$( x7335.seShoesKind ) = "" Then x7335.seShoesKind = Space(1) 
    If trim$( x7335.cdShoesKind ) = "" Then x7335.cdShoesKind = Space(1) 
    If trim$( x7335.seShoesType ) = "" Then x7335.seShoesType = Space(1) 
    If trim$( x7335.cdShoesType ) = "" Then x7335.cdShoesType = Space(1) 
    If trim$( x7335.Article ) = "" Then x7335.Article = Space(1) 
    If trim$( x7335.Line ) = "" Then x7335.Line = Space(1) 
    If trim$( x7335.DateInsert ) = "" Then x7335.DateInsert = Space(1) 
    If trim$( x7335.DateUpdate ) = "" Then x7335.DateUpdate = Space(1) 
    If trim$( x7335.InchargeInsert ) = "" Then x7335.InchargeInsert = Space(1) 
    If trim$( x7335.InchargeUpdate ) = "" Then x7335.InchargeUpdate = Space(1) 
    If trim$( x7335.CheckUse ) = "" Then x7335.CheckUse = Space(1) 
    If trim$( x7335.DateActive ) = "" Then x7335.DateActive = Space(1) 
    If trim$( x7335.DateDeactive ) = "" Then x7335.DateDeactive = Space(1) 
    If trim$( x7335.CheckActive ) = "" Then x7335.CheckActive = Space(1) 
    If trim$( x7335.Remark ) = "" Then x7335.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7335_MOVE(rs7335 As SqlClient.SqlDataReader)
Try

    call D7335_CLEAR()   

    If IsdbNull(rs7335!K7335_ProcessBOMCode) = False Then D7335.ProcessBOMCode = Trim$(rs7335!K7335_ProcessBOMCode)
    If IsdbNull(rs7335!K7335_ProcessBOMName) = False Then D7335.ProcessBOMName = Trim$(rs7335!K7335_ProcessBOMName)
    If IsdbNull(rs7335!K7335_CustomerCode) = False Then D7335.CustomerCode = Trim$(rs7335!K7335_CustomerCode)
    If IsdbNull(rs7335!K7335_seSeason) = False Then D7335.seSeason = Trim$(rs7335!K7335_seSeason)
    If IsdbNull(rs7335!K7335_cdSeason) = False Then D7335.cdSeason = Trim$(rs7335!K7335_cdSeason)
    If IsdbNull(rs7335!K7335_seOrderGroup) = False Then D7335.seOrderGroup = Trim$(rs7335!K7335_seOrderGroup)
    If IsdbNull(rs7335!K7335_cdOrderGroup) = False Then D7335.cdOrderGroup = Trim$(rs7335!K7335_cdOrderGroup)
    If IsdbNull(rs7335!K7335_seShoesKind) = False Then D7335.seShoesKind = Trim$(rs7335!K7335_seShoesKind)
    If IsdbNull(rs7335!K7335_cdShoesKind) = False Then D7335.cdShoesKind = Trim$(rs7335!K7335_cdShoesKind)
    If IsdbNull(rs7335!K7335_seShoesType) = False Then D7335.seShoesType = Trim$(rs7335!K7335_seShoesType)
    If IsdbNull(rs7335!K7335_cdShoesType) = False Then D7335.cdShoesType = Trim$(rs7335!K7335_cdShoesType)
    If IsdbNull(rs7335!K7335_Article) = False Then D7335.Article = Trim$(rs7335!K7335_Article)
    If IsdbNull(rs7335!K7335_Line) = False Then D7335.Line = Trim$(rs7335!K7335_Line)
    If IsdbNull(rs7335!K7335_DateInsert) = False Then D7335.DateInsert = Trim$(rs7335!K7335_DateInsert)
    If IsdbNull(rs7335!K7335_DateUpdate) = False Then D7335.DateUpdate = Trim$(rs7335!K7335_DateUpdate)
    If IsdbNull(rs7335!K7335_InchargeInsert) = False Then D7335.InchargeInsert = Trim$(rs7335!K7335_InchargeInsert)
    If IsdbNull(rs7335!K7335_InchargeUpdate) = False Then D7335.InchargeUpdate = Trim$(rs7335!K7335_InchargeUpdate)
    If IsdbNull(rs7335!K7335_CheckUse) = False Then D7335.CheckUse = Trim$(rs7335!K7335_CheckUse)
    If IsdbNull(rs7335!K7335_DateActive) = False Then D7335.DateActive = Trim$(rs7335!K7335_DateActive)
    If IsdbNull(rs7335!K7335_DateDeactive) = False Then D7335.DateDeactive = Trim$(rs7335!K7335_DateDeactive)
    If IsdbNull(rs7335!K7335_CheckActive) = False Then D7335.CheckActive = Trim$(rs7335!K7335_CheckActive)
    If IsdbNull(rs7335!K7335_Remark) = False Then D7335.Remark = Trim$(rs7335!K7335_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7335_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7335_MOVE(rs7335 As DataRow)
Try

    call D7335_CLEAR()   

    If IsdbNull(rs7335!K7335_ProcessBOMCode) = False Then D7335.ProcessBOMCode = Trim$(rs7335!K7335_ProcessBOMCode)
    If IsdbNull(rs7335!K7335_ProcessBOMName) = False Then D7335.ProcessBOMName = Trim$(rs7335!K7335_ProcessBOMName)
    If IsdbNull(rs7335!K7335_CustomerCode) = False Then D7335.CustomerCode = Trim$(rs7335!K7335_CustomerCode)
    If IsdbNull(rs7335!K7335_seSeason) = False Then D7335.seSeason = Trim$(rs7335!K7335_seSeason)
    If IsdbNull(rs7335!K7335_cdSeason) = False Then D7335.cdSeason = Trim$(rs7335!K7335_cdSeason)
    If IsdbNull(rs7335!K7335_seOrderGroup) = False Then D7335.seOrderGroup = Trim$(rs7335!K7335_seOrderGroup)
    If IsdbNull(rs7335!K7335_cdOrderGroup) = False Then D7335.cdOrderGroup = Trim$(rs7335!K7335_cdOrderGroup)
    If IsdbNull(rs7335!K7335_seShoesKind) = False Then D7335.seShoesKind = Trim$(rs7335!K7335_seShoesKind)
    If IsdbNull(rs7335!K7335_cdShoesKind) = False Then D7335.cdShoesKind = Trim$(rs7335!K7335_cdShoesKind)
    If IsdbNull(rs7335!K7335_seShoesType) = False Then D7335.seShoesType = Trim$(rs7335!K7335_seShoesType)
    If IsdbNull(rs7335!K7335_cdShoesType) = False Then D7335.cdShoesType = Trim$(rs7335!K7335_cdShoesType)
    If IsdbNull(rs7335!K7335_Article) = False Then D7335.Article = Trim$(rs7335!K7335_Article)
    If IsdbNull(rs7335!K7335_Line) = False Then D7335.Line = Trim$(rs7335!K7335_Line)
    If IsdbNull(rs7335!K7335_DateInsert) = False Then D7335.DateInsert = Trim$(rs7335!K7335_DateInsert)
    If IsdbNull(rs7335!K7335_DateUpdate) = False Then D7335.DateUpdate = Trim$(rs7335!K7335_DateUpdate)
    If IsdbNull(rs7335!K7335_InchargeInsert) = False Then D7335.InchargeInsert = Trim$(rs7335!K7335_InchargeInsert)
    If IsdbNull(rs7335!K7335_InchargeUpdate) = False Then D7335.InchargeUpdate = Trim$(rs7335!K7335_InchargeUpdate)
    If IsdbNull(rs7335!K7335_CheckUse) = False Then D7335.CheckUse = Trim$(rs7335!K7335_CheckUse)
    If IsdbNull(rs7335!K7335_DateActive) = False Then D7335.DateActive = Trim$(rs7335!K7335_DateActive)
    If IsdbNull(rs7335!K7335_DateDeactive) = False Then D7335.DateDeactive = Trim$(rs7335!K7335_DateDeactive)
    If IsdbNull(rs7335!K7335_CheckActive) = False Then D7335.CheckActive = Trim$(rs7335!K7335_CheckActive)
    If IsdbNull(rs7335!K7335_Remark) = False Then D7335.Remark = Trim$(rs7335!K7335_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7335_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7335_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7335 As T7335_AREA, PROCESSBOMCODE AS String) as Boolean

K7335_MOVE = False

Try
    If READ_PFK7335(PROCESSBOMCODE) = True Then
                z7335 = D7335
		K7335_MOVE = True
		else
	z7335 = nothing
     End If

     If  getColumIndex(spr,"ProcessBOMCode") > -1 then z7335.ProcessBOMCode = getDataM(spr, getColumIndex(spr,"ProcessBOMCode"), xRow)
     If  getColumIndex(spr,"ProcessBOMName") > -1 then z7335.ProcessBOMName = getDataM(spr, getColumIndex(spr,"ProcessBOMName"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z7335.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"seSeason") > -1 then z7335.seSeason = getDataM(spr, getColumIndex(spr,"seSeason"), xRow)
     If  getColumIndex(spr,"cdSeason") > -1 then z7335.cdSeason = getDataM(spr, getColumIndex(spr,"cdSeason"), xRow)
     If  getColumIndex(spr,"seOrderGroup") > -1 then z7335.seOrderGroup = getDataM(spr, getColumIndex(spr,"seOrderGroup"), xRow)
     If  getColumIndex(spr,"cdOrderGroup") > -1 then z7335.cdOrderGroup = getDataM(spr, getColumIndex(spr,"cdOrderGroup"), xRow)
     If  getColumIndex(spr,"seShoesKind") > -1 then z7335.seShoesKind = getDataM(spr, getColumIndex(spr,"seShoesKind"), xRow)
     If  getColumIndex(spr,"cdShoesKind") > -1 then z7335.cdShoesKind = getDataM(spr, getColumIndex(spr,"cdShoesKind"), xRow)
     If  getColumIndex(spr,"seShoesType") > -1 then z7335.seShoesType = getDataM(spr, getColumIndex(spr,"seShoesType"), xRow)
     If  getColumIndex(spr,"cdShoesType") > -1 then z7335.cdShoesType = getDataM(spr, getColumIndex(spr,"cdShoesType"), xRow)
     If  getColumIndex(spr,"Article") > -1 then z7335.Article = getDataM(spr, getColumIndex(spr,"Article"), xRow)
     If  getColumIndex(spr,"Line") > -1 then z7335.Line = getDataM(spr, getColumIndex(spr,"Line"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7335.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7335.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7335.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7335.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7335.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"DateActive") > -1 then z7335.DateActive = getDataM(spr, getColumIndex(spr,"DateActive"), xRow)
     If  getColumIndex(spr,"DateDeactive") > -1 then z7335.DateDeactive = getDataM(spr, getColumIndex(spr,"DateDeactive"), xRow)
     If  getColumIndex(spr,"CheckActive") > -1 then z7335.CheckActive = getDataM(spr, getColumIndex(spr,"CheckActive"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7335.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7335_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7335_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7335 As T7335_AREA,CheckClear as Boolean,PROCESSBOMCODE AS String) as Boolean

K7335_MOVE = False

Try
    If READ_PFK7335(PROCESSBOMCODE) = True Then
                z7335 = D7335
		K7335_MOVE = True
		else
	If CheckClear  = True then z7335 = nothing
     End If

     If  getColumIndex(spr,"ProcessBOMCode") > -1 then z7335.ProcessBOMCode = getDataM(spr, getColumIndex(spr,"ProcessBOMCode"), xRow)
     If  getColumIndex(spr,"ProcessBOMName") > -1 then z7335.ProcessBOMName = getDataM(spr, getColumIndex(spr,"ProcessBOMName"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z7335.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"seSeason") > -1 then z7335.seSeason = getDataM(spr, getColumIndex(spr,"seSeason"), xRow)
     If  getColumIndex(spr,"cdSeason") > -1 then z7335.cdSeason = getDataM(spr, getColumIndex(spr,"cdSeason"), xRow)
     If  getColumIndex(spr,"seOrderGroup") > -1 then z7335.seOrderGroup = getDataM(spr, getColumIndex(spr,"seOrderGroup"), xRow)
     If  getColumIndex(spr,"cdOrderGroup") > -1 then z7335.cdOrderGroup = getDataM(spr, getColumIndex(spr,"cdOrderGroup"), xRow)
     If  getColumIndex(spr,"seShoesKind") > -1 then z7335.seShoesKind = getDataM(spr, getColumIndex(spr,"seShoesKind"), xRow)
     If  getColumIndex(spr,"cdShoesKind") > -1 then z7335.cdShoesKind = getDataM(spr, getColumIndex(spr,"cdShoesKind"), xRow)
     If  getColumIndex(spr,"seShoesType") > -1 then z7335.seShoesType = getDataM(spr, getColumIndex(spr,"seShoesType"), xRow)
     If  getColumIndex(spr,"cdShoesType") > -1 then z7335.cdShoesType = getDataM(spr, getColumIndex(spr,"cdShoesType"), xRow)
     If  getColumIndex(spr,"Article") > -1 then z7335.Article = getDataM(spr, getColumIndex(spr,"Article"), xRow)
     If  getColumIndex(spr,"Line") > -1 then z7335.Line = getDataM(spr, getColumIndex(spr,"Line"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7335.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7335.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7335.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7335.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7335.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"DateActive") > -1 then z7335.DateActive = getDataM(spr, getColumIndex(spr,"DateActive"), xRow)
     If  getColumIndex(spr,"DateDeactive") > -1 then z7335.DateDeactive = getDataM(spr, getColumIndex(spr,"DateDeactive"), xRow)
     If  getColumIndex(spr,"CheckActive") > -1 then z7335.CheckActive = getDataM(spr, getColumIndex(spr,"CheckActive"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7335.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7335_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7335_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7335 As T7335_AREA, Job as String, PROCESSBOMCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7335_MOVE = False

Try
    If READ_PFK7335(PROCESSBOMCODE) = True Then
                z7335 = D7335
		K7335_MOVE = True
		else
	z7335 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7335")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PROCESSBOMCODE":z7335.ProcessBOMCode = Children(i).Code
   Case "PROCESSBOMNAME":z7335.ProcessBOMName = Children(i).Code
   Case "CUSTOMERCODE":z7335.CustomerCode = Children(i).Code
   Case "SESEASON":z7335.seSeason = Children(i).Code
   Case "CDSEASON":z7335.cdSeason = Children(i).Code
   Case "SEORDERGROUP":z7335.seOrderGroup = Children(i).Code
   Case "CDORDERGROUP":z7335.cdOrderGroup = Children(i).Code
   Case "SESHOESKIND":z7335.seShoesKind = Children(i).Code
   Case "CDSHOESKIND":z7335.cdShoesKind = Children(i).Code
   Case "SESHOESTYPE":z7335.seShoesType = Children(i).Code
   Case "CDSHOESTYPE":z7335.cdShoesType = Children(i).Code
   Case "ARTICLE":z7335.Article = Children(i).Code
   Case "LINE":z7335.Line = Children(i).Code
   Case "DATEINSERT":z7335.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7335.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7335.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7335.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7335.CheckUse = Children(i).Code
   Case "DATEACTIVE":z7335.DateActive = Children(i).Code
   Case "DATEDEACTIVE":z7335.DateDeactive = Children(i).Code
   Case "CHECKACTIVE":z7335.CheckActive = Children(i).Code
   Case "REMARK":z7335.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PROCESSBOMCODE":z7335.ProcessBOMCode = Children(i).Data
   Case "PROCESSBOMNAME":z7335.ProcessBOMName = Children(i).Data
   Case "CUSTOMERCODE":z7335.CustomerCode = Children(i).Data
   Case "SESEASON":z7335.seSeason = Children(i).Data
   Case "CDSEASON":z7335.cdSeason = Children(i).Data
   Case "SEORDERGROUP":z7335.seOrderGroup = Children(i).Data
   Case "CDORDERGROUP":z7335.cdOrderGroup = Children(i).Data
   Case "SESHOESKIND":z7335.seShoesKind = Children(i).Data
   Case "CDSHOESKIND":z7335.cdShoesKind = Children(i).Data
   Case "SESHOESTYPE":z7335.seShoesType = Children(i).Data
   Case "CDSHOESTYPE":z7335.cdShoesType = Children(i).Data
   Case "ARTICLE":z7335.Article = Children(i).Data
   Case "LINE":z7335.Line = Children(i).Data
   Case "DATEINSERT":z7335.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7335.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7335.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7335.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7335.CheckUse = Children(i).Data
   Case "DATEACTIVE":z7335.DateActive = Children(i).Data
   Case "DATEDEACTIVE":z7335.DateDeactive = Children(i).Data
   Case "CHECKACTIVE":z7335.CheckActive = Children(i).Data
   Case "REMARK":z7335.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7335_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7335_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7335 As T7335_AREA, Job as String, CheckClear as Boolean, PROCESSBOMCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7335_MOVE = False

Try
    If READ_PFK7335(PROCESSBOMCODE) = True Then
                z7335 = D7335
		K7335_MOVE = True
		else
	If CheckClear  = True then z7335 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7335")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PROCESSBOMCODE":z7335.ProcessBOMCode = Children(i).Code
   Case "PROCESSBOMNAME":z7335.ProcessBOMName = Children(i).Code
   Case "CUSTOMERCODE":z7335.CustomerCode = Children(i).Code
   Case "SESEASON":z7335.seSeason = Children(i).Code
   Case "CDSEASON":z7335.cdSeason = Children(i).Code
   Case "SEORDERGROUP":z7335.seOrderGroup = Children(i).Code
   Case "CDORDERGROUP":z7335.cdOrderGroup = Children(i).Code
   Case "SESHOESKIND":z7335.seShoesKind = Children(i).Code
   Case "CDSHOESKIND":z7335.cdShoesKind = Children(i).Code
   Case "SESHOESTYPE":z7335.seShoesType = Children(i).Code
   Case "CDSHOESTYPE":z7335.cdShoesType = Children(i).Code
   Case "ARTICLE":z7335.Article = Children(i).Code
   Case "LINE":z7335.Line = Children(i).Code
   Case "DATEINSERT":z7335.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7335.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7335.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7335.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7335.CheckUse = Children(i).Code
   Case "DATEACTIVE":z7335.DateActive = Children(i).Code
   Case "DATEDEACTIVE":z7335.DateDeactive = Children(i).Code
   Case "CHECKACTIVE":z7335.CheckActive = Children(i).Code
   Case "REMARK":z7335.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PROCESSBOMCODE":z7335.ProcessBOMCode = Children(i).Data
   Case "PROCESSBOMNAME":z7335.ProcessBOMName = Children(i).Data
   Case "CUSTOMERCODE":z7335.CustomerCode = Children(i).Data
   Case "SESEASON":z7335.seSeason = Children(i).Data
   Case "CDSEASON":z7335.cdSeason = Children(i).Data
   Case "SEORDERGROUP":z7335.seOrderGroup = Children(i).Data
   Case "CDORDERGROUP":z7335.cdOrderGroup = Children(i).Data
   Case "SESHOESKIND":z7335.seShoesKind = Children(i).Data
   Case "CDSHOESKIND":z7335.cdShoesKind = Children(i).Data
   Case "SESHOESTYPE":z7335.seShoesType = Children(i).Data
   Case "CDSHOESTYPE":z7335.cdShoesType = Children(i).Data
   Case "ARTICLE":z7335.Article = Children(i).Data
   Case "LINE":z7335.Line = Children(i).Data
   Case "DATEINSERT":z7335.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7335.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7335.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7335.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7335.CheckUse = Children(i).Data
   Case "DATEACTIVE":z7335.DateActive = Children(i).Data
   Case "DATEDEACTIVE":z7335.DateDeactive = Children(i).Data
   Case "CHECKACTIVE":z7335.CheckActive = Children(i).Data
   Case "REMARK":z7335.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7335_MOVE",vbCritical)
End Try
End Function 
    
End Module 
