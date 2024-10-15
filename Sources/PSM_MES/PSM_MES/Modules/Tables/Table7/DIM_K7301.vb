'=========================================================================================================================================================
'   TABLE : (PFK7301)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7301

Structure T7301_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	MaterialBOMCode	 AS String	'			nvarchar(6)		*
Public 	MaterialBOMName	 AS String	'			nvarchar(200)
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
Public 	Remark	 AS String	'			nvarchar(100)
'=========================================================================================================================================================
End structure

Public D7301 As T7301_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7301(MATERIALBOMCODE AS String) As Boolean
    READ_PFK7301 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7301 "
    SQL = SQL & " WHERE K7301_MaterialBOMCode		 = '" & MaterialBOMCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7301_CLEAR: GoTo SKIP_READ_PFK7301
                
    Call K7301_MOVE(rd)
    READ_PFK7301 = True

SKIP_READ_PFK7301:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7301",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7301(MATERIALBOMCODE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7301 "
    SQL = SQL & " WHERE K7301_MaterialBOMCode		 = '" & MaterialBOMCode & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7301",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7301(z7301 As T7301_AREA) As Boolean
    WRITE_PFK7301 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7301)
 
    SQL = " INSERT INTO PFK7301 "
    SQL = SQL & " ( "
    SQL = SQL & " K7301_MaterialBOMCode," 
    SQL = SQL & " K7301_MaterialBOMName," 
    SQL = SQL & " K7301_CustomerCode," 
    SQL = SQL & " K7301_seSeason," 
    SQL = SQL & " K7301_cdSeason," 
    SQL = SQL & " K7301_seOrderGroup," 
    SQL = SQL & " K7301_cdOrderGroup," 
    SQL = SQL & " K7301_seShoesKind," 
    SQL = SQL & " K7301_cdShoesKind," 
    SQL = SQL & " K7301_seShoesType," 
    SQL = SQL & " K7301_cdShoesType," 
    SQL = SQL & " K7301_Article," 
    SQL = SQL & " K7301_Line," 
    SQL = SQL & " K7301_DateInsert," 
    SQL = SQL & " K7301_DateUpdate," 
    SQL = SQL & " K7301_InchargeInsert," 
    SQL = SQL & " K7301_InchargeUpdate," 
    SQL = SQL & " K7301_CheckUse," 
    SQL = SQL & " K7301_DateActive," 
    SQL = SQL & " K7301_DateDeactive," 
    SQL = SQL & " K7301_CheckActive," 
    SQL = SQL & " K7301_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7301.MaterialBOMCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7301.MaterialBOMName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7301.CustomerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7301.seSeason) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7301.cdSeason) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7301.seOrderGroup) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7301.cdOrderGroup) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7301.seShoesKind) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7301.cdShoesKind) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7301.seShoesType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7301.cdShoesType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7301.Article) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7301.Line) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7301.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7301.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7301.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7301.InchargeUpdate) & "', "  
        SQL = SQL & "  N'1', "  
    SQL = SQL & "  N'" & FormatSQL(z7301.DateActive) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7301.DateDeactive) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7301.CheckActive) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7301.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7301 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7301",vbCritical)
Finally
        Call GetFullInformation("PFK7301", "I", SQL)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7301(z7301 As T7301_AREA) As Boolean
    REWRITE_PFK7301 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7301)
   
    SQL = " UPDATE PFK7301 SET "
    SQL = SQL & "    K7301_MaterialBOMName      = N'" & FormatSQL(z7301.MaterialBOMName) & "', " 
    SQL = SQL & "    K7301_CustomerCode      = N'" & FormatSQL(z7301.CustomerCode) & "', " 
    SQL = SQL & "    K7301_seSeason      = N'" & FormatSQL(z7301.seSeason) & "', " 
    SQL = SQL & "    K7301_cdSeason      = N'" & FormatSQL(z7301.cdSeason) & "', " 
    SQL = SQL & "    K7301_seOrderGroup      = N'" & FormatSQL(z7301.seOrderGroup) & "', " 
    SQL = SQL & "    K7301_cdOrderGroup      = N'" & FormatSQL(z7301.cdOrderGroup) & "', " 
    SQL = SQL & "    K7301_seShoesKind      = N'" & FormatSQL(z7301.seShoesKind) & "', " 
    SQL = SQL & "    K7301_cdShoesKind      = N'" & FormatSQL(z7301.cdShoesKind) & "', " 
    SQL = SQL & "    K7301_seShoesType      = N'" & FormatSQL(z7301.seShoesType) & "', " 
    SQL = SQL & "    K7301_cdShoesType      = N'" & FormatSQL(z7301.cdShoesType) & "', " 
    SQL = SQL & "    K7301_Article      = N'" & FormatSQL(z7301.Article) & "', " 
    SQL = SQL & "    K7301_Line      = N'" & FormatSQL(z7301.Line) & "', " 
    SQL = SQL & "    K7301_DateInsert      = N'" & FormatSQL(z7301.DateInsert) & "', " 
    SQL = SQL & "    K7301_DateUpdate      = N'" & FormatSQL(z7301.DateUpdate) & "', " 
    SQL = SQL & "    K7301_InchargeInsert      = N'" & FormatSQL(z7301.InchargeInsert) & "', " 
    SQL = SQL & "    K7301_InchargeUpdate      = N'" & FormatSQL(z7301.InchargeUpdate) & "', " 
    SQL = SQL & "    K7301_CheckUse      = N'" & FormatSQL(z7301.CheckUse) & "', " 
    SQL = SQL & "    K7301_DateActive      = N'" & FormatSQL(z7301.DateActive) & "', " 
    SQL = SQL & "    K7301_DateDeactive      = N'" & FormatSQL(z7301.DateDeactive) & "', " 
    SQL = SQL & "    K7301_CheckActive      = N'" & FormatSQL(z7301.CheckActive) & "', " 
    SQL = SQL & "    K7301_Remark      = N'" & FormatSQL(z7301.Remark) & "'  " 
    SQL = SQL & " WHERE K7301_MaterialBOMCode		 = '" & z7301.MaterialBOMCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
	REWRITE_PFK7301 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7301",vbCritical)
Finally
        Call GetFullInformation("PFK7301", "U", SQL)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7301(z7301 As T7301_AREA) As Boolean
    DELETE_PFK7301 = False

   Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7301)
      
        SQL = " DELETE FROM PFK7301  "
    SQL = SQL & " WHERE K7301_MaterialBOMCode		 = '" & z7301.MaterialBOMCode & "' " 

    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7301 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7301",vbCritical)
Finally
        Call GetFullInformation("PFK7301", "U", SQL)
  End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7301_CLEAR()
Try
    
   D7301.MaterialBOMCode = ""
   D7301.MaterialBOMName = ""
   D7301.CustomerCode = ""
   D7301.seSeason = ""
   D7301.cdSeason = ""
   D7301.seOrderGroup = ""
   D7301.cdOrderGroup = ""
   D7301.seShoesKind = ""
   D7301.cdShoesKind = ""
   D7301.seShoesType = ""
   D7301.cdShoesType = ""
   D7301.Article = ""
   D7301.Line = ""
   D7301.DateInsert = ""
   D7301.DateUpdate = ""
   D7301.InchargeInsert = ""
   D7301.InchargeUpdate = ""
   D7301.CheckUse = ""
   D7301.DateActive = ""
   D7301.DateDeactive = ""
   D7301.CheckActive = ""
   D7301.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7301_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7301 As T7301_AREA)
Try
    
    x7301.MaterialBOMCode = trim$(  x7301.MaterialBOMCode)
    x7301.MaterialBOMName = trim$(  x7301.MaterialBOMName)
    x7301.CustomerCode = trim$(  x7301.CustomerCode)
    x7301.seSeason = trim$(  x7301.seSeason)
    x7301.cdSeason = trim$(  x7301.cdSeason)
    x7301.seOrderGroup = trim$(  x7301.seOrderGroup)
    x7301.cdOrderGroup = trim$(  x7301.cdOrderGroup)
    x7301.seShoesKind = trim$(  x7301.seShoesKind)
    x7301.cdShoesKind = trim$(  x7301.cdShoesKind)
    x7301.seShoesType = trim$(  x7301.seShoesType)
    x7301.cdShoesType = trim$(  x7301.cdShoesType)
    x7301.Article = trim$(  x7301.Article)
    x7301.Line = trim$(  x7301.Line)
    x7301.DateInsert = trim$(  x7301.DateInsert)
    x7301.DateUpdate = trim$(  x7301.DateUpdate)
    x7301.InchargeInsert = trim$(  x7301.InchargeInsert)
    x7301.InchargeUpdate = trim$(  x7301.InchargeUpdate)
    x7301.CheckUse = trim$(  x7301.CheckUse)
    x7301.DateActive = trim$(  x7301.DateActive)
    x7301.DateDeactive = trim$(  x7301.DateDeactive)
    x7301.CheckActive = trim$(  x7301.CheckActive)
    x7301.Remark = trim$(  x7301.Remark)
     
    If trim$( x7301.MaterialBOMCode ) = "" Then x7301.MaterialBOMCode = Space(1) 
    If trim$( x7301.MaterialBOMName ) = "" Then x7301.MaterialBOMName = Space(1) 
    If trim$( x7301.CustomerCode ) = "" Then x7301.CustomerCode = Space(1) 
    If trim$( x7301.seSeason ) = "" Then x7301.seSeason = Space(1) 
    If trim$( x7301.cdSeason ) = "" Then x7301.cdSeason = Space(1) 
    If trim$( x7301.seOrderGroup ) = "" Then x7301.seOrderGroup = Space(1) 
    If trim$( x7301.cdOrderGroup ) = "" Then x7301.cdOrderGroup = Space(1) 
    If trim$( x7301.seShoesKind ) = "" Then x7301.seShoesKind = Space(1) 
    If trim$( x7301.cdShoesKind ) = "" Then x7301.cdShoesKind = Space(1) 
    If trim$( x7301.seShoesType ) = "" Then x7301.seShoesType = Space(1) 
    If trim$( x7301.cdShoesType ) = "" Then x7301.cdShoesType = Space(1) 
    If trim$( x7301.Article ) = "" Then x7301.Article = Space(1) 
    If trim$( x7301.Line ) = "" Then x7301.Line = Space(1) 
    If trim$( x7301.DateInsert ) = "" Then x7301.DateInsert = Space(1) 
    If trim$( x7301.DateUpdate ) = "" Then x7301.DateUpdate = Space(1) 
    If trim$( x7301.InchargeInsert ) = "" Then x7301.InchargeInsert = Space(1) 
    If trim$( x7301.InchargeUpdate ) = "" Then x7301.InchargeUpdate = Space(1) 
    If trim$( x7301.CheckUse ) = "" Then x7301.CheckUse = Space(1) 
    If trim$( x7301.DateActive ) = "" Then x7301.DateActive = Space(1) 
    If trim$( x7301.DateDeactive ) = "" Then x7301.DateDeactive = Space(1) 
    If trim$( x7301.CheckActive ) = "" Then x7301.CheckActive = Space(1) 
    If trim$( x7301.Remark ) = "" Then x7301.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7301_MOVE(rs7301 As SqlClient.SqlDataReader)
Try

    call D7301_CLEAR()   

    If IsdbNull(rs7301!K7301_MaterialBOMCode) = False Then D7301.MaterialBOMCode = Trim$(rs7301!K7301_MaterialBOMCode)
    If IsdbNull(rs7301!K7301_MaterialBOMName) = False Then D7301.MaterialBOMName = Trim$(rs7301!K7301_MaterialBOMName)
    If IsdbNull(rs7301!K7301_CustomerCode) = False Then D7301.CustomerCode = Trim$(rs7301!K7301_CustomerCode)
    If IsdbNull(rs7301!K7301_seSeason) = False Then D7301.seSeason = Trim$(rs7301!K7301_seSeason)
    If IsdbNull(rs7301!K7301_cdSeason) = False Then D7301.cdSeason = Trim$(rs7301!K7301_cdSeason)
    If IsdbNull(rs7301!K7301_seOrderGroup) = False Then D7301.seOrderGroup = Trim$(rs7301!K7301_seOrderGroup)
    If IsdbNull(rs7301!K7301_cdOrderGroup) = False Then D7301.cdOrderGroup = Trim$(rs7301!K7301_cdOrderGroup)
    If IsdbNull(rs7301!K7301_seShoesKind) = False Then D7301.seShoesKind = Trim$(rs7301!K7301_seShoesKind)
    If IsdbNull(rs7301!K7301_cdShoesKind) = False Then D7301.cdShoesKind = Trim$(rs7301!K7301_cdShoesKind)
    If IsdbNull(rs7301!K7301_seShoesType) = False Then D7301.seShoesType = Trim$(rs7301!K7301_seShoesType)
    If IsdbNull(rs7301!K7301_cdShoesType) = False Then D7301.cdShoesType = Trim$(rs7301!K7301_cdShoesType)
    If IsdbNull(rs7301!K7301_Article) = False Then D7301.Article = Trim$(rs7301!K7301_Article)
    If IsdbNull(rs7301!K7301_Line) = False Then D7301.Line = Trim$(rs7301!K7301_Line)
    If IsdbNull(rs7301!K7301_DateInsert) = False Then D7301.DateInsert = Trim$(rs7301!K7301_DateInsert)
    If IsdbNull(rs7301!K7301_DateUpdate) = False Then D7301.DateUpdate = Trim$(rs7301!K7301_DateUpdate)
    If IsdbNull(rs7301!K7301_InchargeInsert) = False Then D7301.InchargeInsert = Trim$(rs7301!K7301_InchargeInsert)
    If IsdbNull(rs7301!K7301_InchargeUpdate) = False Then D7301.InchargeUpdate = Trim$(rs7301!K7301_InchargeUpdate)
    If IsdbNull(rs7301!K7301_CheckUse) = False Then D7301.CheckUse = Trim$(rs7301!K7301_CheckUse)
    If IsdbNull(rs7301!K7301_DateActive) = False Then D7301.DateActive = Trim$(rs7301!K7301_DateActive)
    If IsdbNull(rs7301!K7301_DateDeactive) = False Then D7301.DateDeactive = Trim$(rs7301!K7301_DateDeactive)
    If IsdbNull(rs7301!K7301_CheckActive) = False Then D7301.CheckActive = Trim$(rs7301!K7301_CheckActive)
    If IsdbNull(rs7301!K7301_Remark) = False Then D7301.Remark = Trim$(rs7301!K7301_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7301_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7301_MOVE(rs7301 As DataRow)
Try

    call D7301_CLEAR()   

    If IsdbNull(rs7301!K7301_MaterialBOMCode) = False Then D7301.MaterialBOMCode = Trim$(rs7301!K7301_MaterialBOMCode)
    If IsdbNull(rs7301!K7301_MaterialBOMName) = False Then D7301.MaterialBOMName = Trim$(rs7301!K7301_MaterialBOMName)
    If IsdbNull(rs7301!K7301_CustomerCode) = False Then D7301.CustomerCode = Trim$(rs7301!K7301_CustomerCode)
    If IsdbNull(rs7301!K7301_seSeason) = False Then D7301.seSeason = Trim$(rs7301!K7301_seSeason)
    If IsdbNull(rs7301!K7301_cdSeason) = False Then D7301.cdSeason = Trim$(rs7301!K7301_cdSeason)
    If IsdbNull(rs7301!K7301_seOrderGroup) = False Then D7301.seOrderGroup = Trim$(rs7301!K7301_seOrderGroup)
    If IsdbNull(rs7301!K7301_cdOrderGroup) = False Then D7301.cdOrderGroup = Trim$(rs7301!K7301_cdOrderGroup)
    If IsdbNull(rs7301!K7301_seShoesKind) = False Then D7301.seShoesKind = Trim$(rs7301!K7301_seShoesKind)
    If IsdbNull(rs7301!K7301_cdShoesKind) = False Then D7301.cdShoesKind = Trim$(rs7301!K7301_cdShoesKind)
    If IsdbNull(rs7301!K7301_seShoesType) = False Then D7301.seShoesType = Trim$(rs7301!K7301_seShoesType)
    If IsdbNull(rs7301!K7301_cdShoesType) = False Then D7301.cdShoesType = Trim$(rs7301!K7301_cdShoesType)
    If IsdbNull(rs7301!K7301_Article) = False Then D7301.Article = Trim$(rs7301!K7301_Article)
    If IsdbNull(rs7301!K7301_Line) = False Then D7301.Line = Trim$(rs7301!K7301_Line)
    If IsdbNull(rs7301!K7301_DateInsert) = False Then D7301.DateInsert = Trim$(rs7301!K7301_DateInsert)
    If IsdbNull(rs7301!K7301_DateUpdate) = False Then D7301.DateUpdate = Trim$(rs7301!K7301_DateUpdate)
    If IsdbNull(rs7301!K7301_InchargeInsert) = False Then D7301.InchargeInsert = Trim$(rs7301!K7301_InchargeInsert)
    If IsdbNull(rs7301!K7301_InchargeUpdate) = False Then D7301.InchargeUpdate = Trim$(rs7301!K7301_InchargeUpdate)
    If IsdbNull(rs7301!K7301_CheckUse) = False Then D7301.CheckUse = Trim$(rs7301!K7301_CheckUse)
    If IsdbNull(rs7301!K7301_DateActive) = False Then D7301.DateActive = Trim$(rs7301!K7301_DateActive)
    If IsdbNull(rs7301!K7301_DateDeactive) = False Then D7301.DateDeactive = Trim$(rs7301!K7301_DateDeactive)
    If IsdbNull(rs7301!K7301_CheckActive) = False Then D7301.CheckActive = Trim$(rs7301!K7301_CheckActive)
    If IsdbNull(rs7301!K7301_Remark) = False Then D7301.Remark = Trim$(rs7301!K7301_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7301_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7301_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7301 As T7301_AREA, MATERIALBOMCODE AS String) as Boolean

K7301_MOVE = False

Try
    If READ_PFK7301(MATERIALBOMCODE) = True Then
                z7301 = D7301
		K7301_MOVE = True
		else
	z7301 = nothing
     End If

     If  getColumnIndex(spr,"MaterialBOMCode") > -1 then z7301.MaterialBOMCode = getDataM(spr, getColumnIndex(spr,"MaterialBOMCode"), xRow)
     If  getColumnIndex(spr,"MaterialBOMName") > -1 then z7301.MaterialBOMName = getDataM(spr, getColumnIndex(spr,"MaterialBOMName"), xRow)
     If  getColumnIndex(spr,"CustomerCode") > -1 then z7301.CustomerCode = getDataM(spr, getColumnIndex(spr,"CustomerCode"), xRow)
     If  getColumnIndex(spr,"seSeason") > -1 then z7301.seSeason = getDataM(spr, getColumnIndex(spr,"seSeason"), xRow)
     If  getColumnIndex(spr,"cdSeason") > -1 then z7301.cdSeason = getDataM(spr, getColumnIndex(spr,"cdSeason"), xRow)
     If  getColumnIndex(spr,"seOrderGroup") > -1 then z7301.seOrderGroup = getDataM(spr, getColumnIndex(spr,"seOrderGroup"), xRow)
     If  getColumnIndex(spr,"cdOrderGroup") > -1 then z7301.cdOrderGroup = getDataM(spr, getColumnIndex(spr,"cdOrderGroup"), xRow)
     If  getColumnIndex(spr,"seShoesKind") > -1 then z7301.seShoesKind = getDataM(spr, getColumnIndex(spr,"seShoesKind"), xRow)
     If  getColumnIndex(spr,"cdShoesKind") > -1 then z7301.cdShoesKind = getDataM(spr, getColumnIndex(spr,"cdShoesKind"), xRow)
     If  getColumnIndex(spr,"seShoesType") > -1 then z7301.seShoesType = getDataM(spr, getColumnIndex(spr,"seShoesType"), xRow)
     If  getColumnIndex(spr,"cdShoesType") > -1 then z7301.cdShoesType = getDataM(spr, getColumnIndex(spr,"cdShoesType"), xRow)
     If  getColumnIndex(spr,"Article") > -1 then z7301.Article = getDataM(spr, getColumnIndex(spr,"Article"), xRow)
     If  getColumnIndex(spr,"Line") > -1 then z7301.Line = getDataM(spr, getColumnIndex(spr,"Line"), xRow)
     If  getColumnIndex(spr,"DateInsert") > -1 then z7301.DateInsert = getDataM(spr, getColumnIndex(spr,"DateInsert"), xRow)
     If  getColumnIndex(spr,"DateUpdate") > -1 then z7301.DateUpdate = getDataM(spr, getColumnIndex(spr,"DateUpdate"), xRow)
     If  getColumnIndex(spr,"InchargeInsert") > -1 then z7301.InchargeInsert = getDataM(spr, getColumnIndex(spr,"InchargeInsert"), xRow)
     If  getColumnIndex(spr,"InchargeUpdate") > -1 then z7301.InchargeUpdate = getDataM(spr, getColumnIndex(spr,"InchargeUpdate"), xRow)
     If  getColumnIndex(spr,"CheckUse") > -1 then z7301.CheckUse = getDataM(spr, getColumnIndex(spr,"CheckUse"), xRow)
     If  getColumnIndex(spr,"DateActive") > -1 then z7301.DateActive = getDataM(spr, getColumnIndex(spr,"DateActive"), xRow)
     If  getColumnIndex(spr,"DateDeactive") > -1 then z7301.DateDeactive = getDataM(spr, getColumnIndex(spr,"DateDeactive"), xRow)
     If  getColumnIndex(spr,"CheckActive") > -1 then z7301.CheckActive = getDataM(spr, getColumnIndex(spr,"CheckActive"), xRow)
     If  getColumnIndex(spr,"Remark") > -1 then z7301.Remark = getDataM(spr, getColumnIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7301_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7301_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7301 As T7301_AREA,CheckClear as Boolean,MATERIALBOMCODE AS String) as Boolean

K7301_MOVE = False

Try
    If READ_PFK7301(MATERIALBOMCODE) = True Then
                z7301 = D7301
		K7301_MOVE = True
		else
	If CheckClear  = True then z7301 = nothing
     End If

     If  getColumnIndex(spr,"MaterialBOMCode") > -1 then z7301.MaterialBOMCode = getDataM(spr, getColumnIndex(spr,"MaterialBOMCode"), xRow)
     If  getColumnIndex(spr,"MaterialBOMName") > -1 then z7301.MaterialBOMName = getDataM(spr, getColumnIndex(spr,"MaterialBOMName"), xRow)
     If  getColumnIndex(spr,"CustomerCode") > -1 then z7301.CustomerCode = getDataM(spr, getColumnIndex(spr,"CustomerCode"), xRow)
     If  getColumnIndex(spr,"seSeason") > -1 then z7301.seSeason = getDataM(spr, getColumnIndex(spr,"seSeason"), xRow)
     If  getColumnIndex(spr,"cdSeason") > -1 then z7301.cdSeason = getDataM(spr, getColumnIndex(spr,"cdSeason"), xRow)
     If  getColumnIndex(spr,"seOrderGroup") > -1 then z7301.seOrderGroup = getDataM(spr, getColumnIndex(spr,"seOrderGroup"), xRow)
     If  getColumnIndex(spr,"cdOrderGroup") > -1 then z7301.cdOrderGroup = getDataM(spr, getColumnIndex(spr,"cdOrderGroup"), xRow)
     If  getColumnIndex(spr,"seShoesKind") > -1 then z7301.seShoesKind = getDataM(spr, getColumnIndex(spr,"seShoesKind"), xRow)
     If  getColumnIndex(spr,"cdShoesKind") > -1 then z7301.cdShoesKind = getDataM(spr, getColumnIndex(spr,"cdShoesKind"), xRow)
     If  getColumnIndex(spr,"seShoesType") > -1 then z7301.seShoesType = getDataM(spr, getColumnIndex(spr,"seShoesType"), xRow)
     If  getColumnIndex(spr,"cdShoesType") > -1 then z7301.cdShoesType = getDataM(spr, getColumnIndex(spr,"cdShoesType"), xRow)
     If  getColumnIndex(spr,"Article") > -1 then z7301.Article = getDataM(spr, getColumnIndex(spr,"Article"), xRow)
     If  getColumnIndex(spr,"Line") > -1 then z7301.Line = getDataM(spr, getColumnIndex(spr,"Line"), xRow)
     If  getColumnIndex(spr,"DateInsert") > -1 then z7301.DateInsert = getDataM(spr, getColumnIndex(spr,"DateInsert"), xRow)
     If  getColumnIndex(spr,"DateUpdate") > -1 then z7301.DateUpdate = getDataM(spr, getColumnIndex(spr,"DateUpdate"), xRow)
     If  getColumnIndex(spr,"InchargeInsert") > -1 then z7301.InchargeInsert = getDataM(spr, getColumnIndex(spr,"InchargeInsert"), xRow)
     If  getColumnIndex(spr,"InchargeUpdate") > -1 then z7301.InchargeUpdate = getDataM(spr, getColumnIndex(spr,"InchargeUpdate"), xRow)
     If  getColumnIndex(spr,"CheckUse") > -1 then z7301.CheckUse = getDataM(spr, getColumnIndex(spr,"CheckUse"), xRow)
     If  getColumnIndex(spr,"DateActive") > -1 then z7301.DateActive = getDataM(spr, getColumnIndex(spr,"DateActive"), xRow)
     If  getColumnIndex(spr,"DateDeactive") > -1 then z7301.DateDeactive = getDataM(spr, getColumnIndex(spr,"DateDeactive"), xRow)
     If  getColumnIndex(spr,"CheckActive") > -1 then z7301.CheckActive = getDataM(spr, getColumnIndex(spr,"CheckActive"), xRow)
     If  getColumnIndex(spr,"Remark") > -1 then z7301.Remark = getDataM(spr, getColumnIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7301_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7301_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7301 As T7301_AREA, Job as String, MATERIALBOMCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7301_MOVE = False

Try
    If READ_PFK7301(MATERIALBOMCODE) = True Then
                z7301 = D7301
		K7301_MOVE = True
		else
	z7301 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7301")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "MATERIALBOMCODE":z7301.MaterialBOMCode = Children(i).Code
   Case "MATERIALBOMNAME":z7301.MaterialBOMName = Children(i).Code
   Case "CUSTOMERCODE":z7301.CustomerCode = Children(i).Code
   Case "SESEASON":z7301.seSeason = Children(i).Code
   Case "CDSEASON":z7301.cdSeason = Children(i).Code
   Case "SEORDERGROUP":z7301.seOrderGroup = Children(i).Code
   Case "CDORDERGROUP":z7301.cdOrderGroup = Children(i).Code
   Case "SESHOESKIND":z7301.seShoesKind = Children(i).Code
   Case "CDSHOESKIND":z7301.cdShoesKind = Children(i).Code
   Case "SESHOESTYPE":z7301.seShoesType = Children(i).Code
   Case "CDSHOESTYPE":z7301.cdShoesType = Children(i).Code
   Case "ARTICLE":z7301.Article = Children(i).Code
   Case "LINE":z7301.Line = Children(i).Code
   Case "DATEINSERT":z7301.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7301.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7301.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7301.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7301.CheckUse = Children(i).Code
   Case "DATEACTIVE":z7301.DateActive = Children(i).Code
   Case "DATEDEACTIVE":z7301.DateDeactive = Children(i).Code
   Case "CHECKACTIVE":z7301.CheckActive = Children(i).Code
   Case "REMARK":z7301.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "MATERIALBOMCODE":z7301.MaterialBOMCode = Children(i).Data
   Case "MATERIALBOMNAME":z7301.MaterialBOMName = Children(i).Data
   Case "CUSTOMERCODE":z7301.CustomerCode = Children(i).Data
   Case "SESEASON":z7301.seSeason = Children(i).Data
   Case "CDSEASON":z7301.cdSeason = Children(i).Data
   Case "SEORDERGROUP":z7301.seOrderGroup = Children(i).Data
   Case "CDORDERGROUP":z7301.cdOrderGroup = Children(i).Data
   Case "SESHOESKIND":z7301.seShoesKind = Children(i).Data
   Case "CDSHOESKIND":z7301.cdShoesKind = Children(i).Data
   Case "SESHOESTYPE":z7301.seShoesType = Children(i).Data
   Case "CDSHOESTYPE":z7301.cdShoesType = Children(i).Data
   Case "ARTICLE":z7301.Article = Children(i).Data
   Case "LINE":z7301.Line = Children(i).Data
   Case "DATEINSERT":z7301.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7301.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7301.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7301.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7301.CheckUse = Children(i).Data
   Case "DATEACTIVE":z7301.DateActive = Children(i).Data
   Case "DATEDEACTIVE":z7301.DateDeactive = Children(i).Data
   Case "CHECKACTIVE":z7301.CheckActive = Children(i).Data
   Case "REMARK":z7301.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7301_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7301_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7301 As T7301_AREA, Job as String, CheckClear as Boolean, MATERIALBOMCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7301_MOVE = False

Try
    If READ_PFK7301(MATERIALBOMCODE) = True Then
                z7301 = D7301
		K7301_MOVE = True
		else
	If CheckClear  = True then z7301 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7301")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "MATERIALBOMCODE":z7301.MaterialBOMCode = Children(i).Code
   Case "MATERIALBOMNAME":z7301.MaterialBOMName = Children(i).Code
   Case "CUSTOMERCODE":z7301.CustomerCode = Children(i).Code
   Case "SESEASON":z7301.seSeason = Children(i).Code
   Case "CDSEASON":z7301.cdSeason = Children(i).Code
   Case "SEORDERGROUP":z7301.seOrderGroup = Children(i).Code
   Case "CDORDERGROUP":z7301.cdOrderGroup = Children(i).Code
   Case "SESHOESKIND":z7301.seShoesKind = Children(i).Code
   Case "CDSHOESKIND":z7301.cdShoesKind = Children(i).Code
   Case "SESHOESTYPE":z7301.seShoesType = Children(i).Code
   Case "CDSHOESTYPE":z7301.cdShoesType = Children(i).Code
   Case "ARTICLE":z7301.Article = Children(i).Code
   Case "LINE":z7301.Line = Children(i).Code
   Case "DATEINSERT":z7301.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7301.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7301.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7301.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7301.CheckUse = Children(i).Code
   Case "DATEACTIVE":z7301.DateActive = Children(i).Code
   Case "DATEDEACTIVE":z7301.DateDeactive = Children(i).Code
   Case "CHECKACTIVE":z7301.CheckActive = Children(i).Code
   Case "REMARK":z7301.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "MATERIALBOMCODE":z7301.MaterialBOMCode = Children(i).Data
   Case "MATERIALBOMNAME":z7301.MaterialBOMName = Children(i).Data
   Case "CUSTOMERCODE":z7301.CustomerCode = Children(i).Data
   Case "SESEASON":z7301.seSeason = Children(i).Data
   Case "CDSEASON":z7301.cdSeason = Children(i).Data
   Case "SEORDERGROUP":z7301.seOrderGroup = Children(i).Data
   Case "CDORDERGROUP":z7301.cdOrderGroup = Children(i).Data
   Case "SESHOESKIND":z7301.seShoesKind = Children(i).Data
   Case "CDSHOESKIND":z7301.cdShoesKind = Children(i).Data
   Case "SESHOESTYPE":z7301.seShoesType = Children(i).Data
   Case "CDSHOESTYPE":z7301.cdShoesType = Children(i).Data
   Case "ARTICLE":z7301.Article = Children(i).Data
   Case "LINE":z7301.Line = Children(i).Data
   Case "DATEINSERT":z7301.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7301.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7301.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7301.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7301.CheckUse = Children(i).Data
   Case "DATEACTIVE":z7301.DateActive = Children(i).Data
   Case "DATEDEACTIVE":z7301.DateDeactive = Children(i).Data
   Case "CHECKACTIVE":z7301.CheckActive = Children(i).Data
   Case "REMARK":z7301.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7301_MOVE",vbCritical)
End Try
End Function 
    

'=========================================================================================================================================================
' DATA MOVE FORM NEW AREA
'=========================================================================================================================================================
Public Sub K7301_MOVE(ByRef a7301 As T7301_AREA, ByRef b7301 As T7301_AREA) 
Try
If trim$( a7301.MaterialBOMCode ) = "" Then b7301.MaterialBOMCode = ""  Else b7301.MaterialBOMCode=a7301.MaterialBOMCode
If trim$( a7301.MaterialBOMName ) = "" Then b7301.MaterialBOMName = ""  Else b7301.MaterialBOMName=a7301.MaterialBOMName
If trim$( a7301.CustomerCode ) = "" Then b7301.CustomerCode = ""  Else b7301.CustomerCode=a7301.CustomerCode
If trim$( a7301.seSeason ) = "" Then b7301.seSeason = ""  Else b7301.seSeason=a7301.seSeason
If trim$( a7301.cdSeason ) = "" Then b7301.cdSeason = ""  Else b7301.cdSeason=a7301.cdSeason
If trim$( a7301.seOrderGroup ) = "" Then b7301.seOrderGroup = ""  Else b7301.seOrderGroup=a7301.seOrderGroup
If trim$( a7301.cdOrderGroup ) = "" Then b7301.cdOrderGroup = ""  Else b7301.cdOrderGroup=a7301.cdOrderGroup
If trim$( a7301.seShoesKind ) = "" Then b7301.seShoesKind = ""  Else b7301.seShoesKind=a7301.seShoesKind
If trim$( a7301.cdShoesKind ) = "" Then b7301.cdShoesKind = ""  Else b7301.cdShoesKind=a7301.cdShoesKind
If trim$( a7301.seShoesType ) = "" Then b7301.seShoesType = ""  Else b7301.seShoesType=a7301.seShoesType
If trim$( a7301.cdShoesType ) = "" Then b7301.cdShoesType = ""  Else b7301.cdShoesType=a7301.cdShoesType
If trim$( a7301.Article ) = "" Then b7301.Article = ""  Else b7301.Article=a7301.Article
If trim$( a7301.Line ) = "" Then b7301.Line = ""  Else b7301.Line=a7301.Line
If trim$( a7301.DateInsert ) = "" Then b7301.DateInsert = ""  Else b7301.DateInsert=a7301.DateInsert
If trim$( a7301.DateUpdate ) = "" Then b7301.DateUpdate = ""  Else b7301.DateUpdate=a7301.DateUpdate
If trim$( a7301.InchargeInsert ) = "" Then b7301.InchargeInsert = ""  Else b7301.InchargeInsert=a7301.InchargeInsert
If trim$( a7301.InchargeUpdate ) = "" Then b7301.InchargeUpdate = ""  Else b7301.InchargeUpdate=a7301.InchargeUpdate
If trim$( a7301.CheckUse ) = "" Then b7301.CheckUse = ""  Else b7301.CheckUse=a7301.CheckUse
If trim$( a7301.DateActive ) = "" Then b7301.DateActive = ""  Else b7301.DateActive=a7301.DateActive
If trim$( a7301.DateDeactive ) = "" Then b7301.DateDeactive = ""  Else b7301.DateDeactive=a7301.DateDeactive
If trim$( a7301.CheckActive ) = "" Then b7301.CheckActive = ""  Else b7301.CheckActive=a7301.CheckActive
If trim$( a7301.Remark ) = "" Then b7301.Remark = ""  Else b7301.Remark=a7301.Remark
Catch ex As Exception
      Call MsgBoxP("K7301_MOVE",vbCritical)
End Try
End Sub 


End Module 
