'=========================================================================================================================================================
'   TABLE : (PFK7156)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7156

Structure T7156_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	ToolCode	 AS String	'			char(8)		*
Public 	ToolNo	 AS String	'			char(6)
Public 	SizeNo	 AS String	'			char(2)
Public 	seToolGroup	 AS String	'			char(3)
Public 	cdToolGroup	 AS String	'			char(3)
Public 	BarcodeTool	 AS String	'			nvarchar(50)
Public 	MaterialCode	 AS String	'			char(6)
Public 	PurchasingOrderNo	 AS String	'			char(9)
Public 	PurchasingOrderSeq	 AS Double	'			decimal
Public 	ToolName	 AS String	'			nvarchar(100)
Public 	ToolNameSimply	 AS String	'			nvarchar(100)
Public 	ToolGroup	 AS String	'			nvarchar(100)
Public 	ToolWidth	 AS String	'			nvarchar(50)
Public 	ToolWeight	 AS String	'			nvarchar(50)
Public 	ToolSize	 AS String	'			nvarchar(50)
Public 	DateTool	 AS String	'			char(10)
Public 	JobCard	 AS String	'			char(10)
Public 	seProcessProduction	 AS String	'			char(3)
Public 	cdProcessProduction	 AS String	'			char(3)
Public 	DateProduction	 AS String	'			char(8)
Public 	DateAccept	 AS String	'			char(8)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(6)
Public 	InchargeUpdate	 AS String	'			char(6)
Public 	CheckUse	 AS String	'			char(1)
Public 	Remark	 AS String	'			nvarchar(200)
'=========================================================================================================================================================
End structure

Public D7156 As T7156_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7156(TOOLCODE AS String) As Boolean
    READ_PFK7156 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7156 "
    SQL = SQL & " WHERE K7156_ToolCode		 = '" & ToolCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7156_CLEAR: GoTo SKIP_READ_PFK7156
                
    Call K7156_MOVE(rd)
    READ_PFK7156 = True

SKIP_READ_PFK7156:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7156",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7156(TOOLCODE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7156 "
    SQL = SQL & " WHERE K7156_ToolCode		 = '" & ToolCode & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7156",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7156(z7156 As T7156_AREA) As Boolean
    WRITE_PFK7156 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7156)
 
    SQL = " INSERT INTO PFK7156 "
    SQL = SQL & " ( "
    SQL = SQL & " K7156_ToolCode," 
    SQL = SQL & " K7156_ToolNo," 
    SQL = SQL & " K7156_SizeNo," 
    SQL = SQL & " K7156_seToolGroup," 
    SQL = SQL & " K7156_cdToolGroup," 
    SQL = SQL & " K7156_BarcodeTool," 
    SQL = SQL & " K7156_MaterialCode," 
    SQL = SQL & " K7156_PurchasingOrderNo," 
    SQL = SQL & " K7156_PurchasingOrderSeq," 
    SQL = SQL & " K7156_ToolName," 
    SQL = SQL & " K7156_ToolNameSimply," 
    SQL = SQL & " K7156_ToolGroup," 
    SQL = SQL & " K7156_ToolWidth," 
    SQL = SQL & " K7156_ToolWeight," 
    SQL = SQL & " K7156_ToolSize," 
    SQL = SQL & " K7156_DateTool," 
    SQL = SQL & " K7156_JobCard," 
    SQL = SQL & " K7156_seProcessProduction," 
    SQL = SQL & " K7156_cdProcessProduction," 
    SQL = SQL & " K7156_DateProduction," 
    SQL = SQL & " K7156_DateAccept," 
    SQL = SQL & " K7156_DateInsert," 
    SQL = SQL & " K7156_DateUpdate," 
    SQL = SQL & " K7156_InchargeInsert," 
    SQL = SQL & " K7156_InchargeUpdate," 
    SQL = SQL & " K7156_CheckUse," 
    SQL = SQL & " K7156_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7156.ToolCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7156.ToolNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7156.SizeNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7156.seToolGroup) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7156.cdToolGroup) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7156.BarcodeTool) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7156.MaterialCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7156.PurchasingOrderNo) & "', "  
    SQL = SQL & "   " & FormatSQL(z7156.PurchasingOrderSeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7156.ToolName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7156.ToolNameSimply) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7156.ToolGroup) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7156.ToolWidth) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7156.ToolWeight) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7156.ToolSize) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7156.DateTool) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7156.JobCard) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7156.seProcessProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7156.cdProcessProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7156.DateProduction) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7156.DateAccept) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7156.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7156.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7156.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7156.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7156.CheckUse) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7156.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7156 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7156",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7156(z7156 As T7156_AREA) As Boolean
    REWRITE_PFK7156 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7156)
   
    SQL = " UPDATE PFK7156 SET "
    SQL = SQL & "    K7156_ToolNo      = N'" & FormatSQL(z7156.ToolNo) & "', " 
    SQL = SQL & "    K7156_SizeNo      = N'" & FormatSQL(z7156.SizeNo) & "', " 
    SQL = SQL & "    K7156_seToolGroup      = N'" & FormatSQL(z7156.seToolGroup) & "', " 
    SQL = SQL & "    K7156_cdToolGroup      = N'" & FormatSQL(z7156.cdToolGroup) & "', " 
    SQL = SQL & "    K7156_BarcodeTool      = N'" & FormatSQL(z7156.BarcodeTool) & "', " 
    SQL = SQL & "    K7156_MaterialCode      = N'" & FormatSQL(z7156.MaterialCode) & "', " 
    SQL = SQL & "    K7156_PurchasingOrderNo      = N'" & FormatSQL(z7156.PurchasingOrderNo) & "', " 
    SQL = SQL & "    K7156_PurchasingOrderSeq      =  " & FormatSQL(z7156.PurchasingOrderSeq) & ", " 
    SQL = SQL & "    K7156_ToolName      = N'" & FormatSQL(z7156.ToolName) & "', " 
    SQL = SQL & "    K7156_ToolNameSimply      = N'" & FormatSQL(z7156.ToolNameSimply) & "', " 
    SQL = SQL & "    K7156_ToolGroup      = N'" & FormatSQL(z7156.ToolGroup) & "', " 
    SQL = SQL & "    K7156_ToolWidth      = N'" & FormatSQL(z7156.ToolWidth) & "', " 
    SQL = SQL & "    K7156_ToolWeight      = N'" & FormatSQL(z7156.ToolWeight) & "', " 
    SQL = SQL & "    K7156_ToolSize      = N'" & FormatSQL(z7156.ToolSize) & "', " 
    SQL = SQL & "    K7156_DateTool      = N'" & FormatSQL(z7156.DateTool) & "', " 
    SQL = SQL & "    K7156_JobCard      = N'" & FormatSQL(z7156.JobCard) & "', " 
    SQL = SQL & "    K7156_seProcessProduction      = N'" & FormatSQL(z7156.seProcessProduction) & "', " 
    SQL = SQL & "    K7156_cdProcessProduction      = N'" & FormatSQL(z7156.cdProcessProduction) & "', " 
    SQL = SQL & "    K7156_DateProduction      = N'" & FormatSQL(z7156.DateProduction) & "', " 
    SQL = SQL & "    K7156_DateAccept      = N'" & FormatSQL(z7156.DateAccept) & "', " 
    SQL = SQL & "    K7156_DateInsert      = N'" & FormatSQL(z7156.DateInsert) & "', " 
    SQL = SQL & "    K7156_DateUpdate      = N'" & FormatSQL(z7156.DateUpdate) & "', " 
    SQL = SQL & "    K7156_InchargeInsert      = N'" & FormatSQL(z7156.InchargeInsert) & "', " 
    SQL = SQL & "    K7156_InchargeUpdate      = N'" & FormatSQL(z7156.InchargeUpdate) & "', " 
    SQL = SQL & "    K7156_CheckUse      = N'" & FormatSQL(z7156.CheckUse) & "', " 
    SQL = SQL & "    K7156_Remark      = N'" & FormatSQL(z7156.Remark) & "'  " 
    SQL = SQL & " WHERE K7156_ToolCode		 = '" & z7156.ToolCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7156 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7156",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7156(z7156 As T7156_AREA) As Boolean
    DELETE_PFK7156 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7156 "
    SQL = SQL & " WHERE K7156_ToolCode		 = '" & z7156.ToolCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7156 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7156",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7156_CLEAR()
Try
    
   D7156.ToolCode = ""
   D7156.ToolNo = ""
   D7156.SizeNo = ""
   D7156.seToolGroup = ""
   D7156.cdToolGroup = ""
   D7156.BarcodeTool = ""
   D7156.MaterialCode = ""
   D7156.PurchasingOrderNo = ""
    D7156.PurchasingOrderSeq = 0 
   D7156.ToolName = ""
   D7156.ToolNameSimply = ""
   D7156.ToolGroup = ""
   D7156.ToolWidth = ""
   D7156.ToolWeight = ""
   D7156.ToolSize = ""
   D7156.DateTool = ""
   D7156.JobCard = ""
   D7156.seProcessProduction = ""
   D7156.cdProcessProduction = ""
   D7156.DateProduction = ""
   D7156.DateAccept = ""
   D7156.DateInsert = ""
   D7156.DateUpdate = ""
   D7156.InchargeInsert = ""
   D7156.InchargeUpdate = ""
   D7156.CheckUse = ""
   D7156.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7156_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7156 As T7156_AREA)
Try
    
    x7156.ToolCode = trim$(  x7156.ToolCode)
    x7156.ToolNo = trim$(  x7156.ToolNo)
    x7156.SizeNo = trim$(  x7156.SizeNo)
    x7156.seToolGroup = trim$(  x7156.seToolGroup)
    x7156.cdToolGroup = trim$(  x7156.cdToolGroup)
    x7156.BarcodeTool = trim$(  x7156.BarcodeTool)
    x7156.MaterialCode = trim$(  x7156.MaterialCode)
    x7156.PurchasingOrderNo = trim$(  x7156.PurchasingOrderNo)
    x7156.PurchasingOrderSeq = trim$(  x7156.PurchasingOrderSeq)
    x7156.ToolName = trim$(  x7156.ToolName)
    x7156.ToolNameSimply = trim$(  x7156.ToolNameSimply)
    x7156.ToolGroup = trim$(  x7156.ToolGroup)
    x7156.ToolWidth = trim$(  x7156.ToolWidth)
    x7156.ToolWeight = trim$(  x7156.ToolWeight)
    x7156.ToolSize = trim$(  x7156.ToolSize)
    x7156.DateTool = trim$(  x7156.DateTool)
    x7156.JobCard = trim$(  x7156.JobCard)
    x7156.seProcessProduction = trim$(  x7156.seProcessProduction)
    x7156.cdProcessProduction = trim$(  x7156.cdProcessProduction)
    x7156.DateProduction = trim$(  x7156.DateProduction)
    x7156.DateAccept = trim$(  x7156.DateAccept)
    x7156.DateInsert = trim$(  x7156.DateInsert)
    x7156.DateUpdate = trim$(  x7156.DateUpdate)
    x7156.InchargeInsert = trim$(  x7156.InchargeInsert)
    x7156.InchargeUpdate = trim$(  x7156.InchargeUpdate)
    x7156.CheckUse = trim$(  x7156.CheckUse)
    x7156.Remark = trim$(  x7156.Remark)
     
    If trim$( x7156.ToolCode ) = "" Then x7156.ToolCode = Space(1) 
    If trim$( x7156.ToolNo ) = "" Then x7156.ToolNo = Space(1) 
    If trim$( x7156.SizeNo ) = "" Then x7156.SizeNo = Space(1) 
    If trim$( x7156.seToolGroup ) = "" Then x7156.seToolGroup = Space(1) 
    If trim$( x7156.cdToolGroup ) = "" Then x7156.cdToolGroup = Space(1) 
    If trim$( x7156.BarcodeTool ) = "" Then x7156.BarcodeTool = Space(1) 
    If trim$( x7156.MaterialCode ) = "" Then x7156.MaterialCode = Space(1) 
    If trim$( x7156.PurchasingOrderNo ) = "" Then x7156.PurchasingOrderNo = Space(1) 
    If trim$( x7156.PurchasingOrderSeq ) = "" Then x7156.PurchasingOrderSeq = 0 
    If trim$( x7156.ToolName ) = "" Then x7156.ToolName = Space(1) 
    If trim$( x7156.ToolNameSimply ) = "" Then x7156.ToolNameSimply = Space(1) 
    If trim$( x7156.ToolGroup ) = "" Then x7156.ToolGroup = Space(1) 
    If trim$( x7156.ToolWidth ) = "" Then x7156.ToolWidth = Space(1) 
    If trim$( x7156.ToolWeight ) = "" Then x7156.ToolWeight = Space(1) 
    If trim$( x7156.ToolSize ) = "" Then x7156.ToolSize = Space(1) 
    If trim$( x7156.DateTool ) = "" Then x7156.DateTool = Space(1) 
    If trim$( x7156.JobCard ) = "" Then x7156.JobCard = Space(1) 
    If trim$( x7156.seProcessProduction ) = "" Then x7156.seProcessProduction = Space(1) 
    If trim$( x7156.cdProcessProduction ) = "" Then x7156.cdProcessProduction = Space(1) 
    If trim$( x7156.DateProduction ) = "" Then x7156.DateProduction = Space(1) 
    If trim$( x7156.DateAccept ) = "" Then x7156.DateAccept = Space(1) 
    If trim$( x7156.DateInsert ) = "" Then x7156.DateInsert = Space(1) 
    If trim$( x7156.DateUpdate ) = "" Then x7156.DateUpdate = Space(1) 
    If trim$( x7156.InchargeInsert ) = "" Then x7156.InchargeInsert = Space(1) 
    If trim$( x7156.InchargeUpdate ) = "" Then x7156.InchargeUpdate = Space(1) 
    If trim$( x7156.CheckUse ) = "" Then x7156.CheckUse = Space(1) 
    If trim$( x7156.Remark ) = "" Then x7156.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7156_MOVE(rs7156 As SqlClient.SqlDataReader)
Try

    call D7156_CLEAR()   

    If IsdbNull(rs7156!K7156_ToolCode) = False Then D7156.ToolCode = Trim$(rs7156!K7156_ToolCode)
    If IsdbNull(rs7156!K7156_ToolNo) = False Then D7156.ToolNo = Trim$(rs7156!K7156_ToolNo)
    If IsdbNull(rs7156!K7156_SizeNo) = False Then D7156.SizeNo = Trim$(rs7156!K7156_SizeNo)
    If IsdbNull(rs7156!K7156_seToolGroup) = False Then D7156.seToolGroup = Trim$(rs7156!K7156_seToolGroup)
    If IsdbNull(rs7156!K7156_cdToolGroup) = False Then D7156.cdToolGroup = Trim$(rs7156!K7156_cdToolGroup)
    If IsdbNull(rs7156!K7156_BarcodeTool) = False Then D7156.BarcodeTool = Trim$(rs7156!K7156_BarcodeTool)
    If IsdbNull(rs7156!K7156_MaterialCode) = False Then D7156.MaterialCode = Trim$(rs7156!K7156_MaterialCode)
    If IsdbNull(rs7156!K7156_PurchasingOrderNo) = False Then D7156.PurchasingOrderNo = Trim$(rs7156!K7156_PurchasingOrderNo)
    If IsdbNull(rs7156!K7156_PurchasingOrderSeq) = False Then D7156.PurchasingOrderSeq = Trim$(rs7156!K7156_PurchasingOrderSeq)
    If IsdbNull(rs7156!K7156_ToolName) = False Then D7156.ToolName = Trim$(rs7156!K7156_ToolName)
    If IsdbNull(rs7156!K7156_ToolNameSimply) = False Then D7156.ToolNameSimply = Trim$(rs7156!K7156_ToolNameSimply)
    If IsdbNull(rs7156!K7156_ToolGroup) = False Then D7156.ToolGroup = Trim$(rs7156!K7156_ToolGroup)
    If IsdbNull(rs7156!K7156_ToolWidth) = False Then D7156.ToolWidth = Trim$(rs7156!K7156_ToolWidth)
    If IsdbNull(rs7156!K7156_ToolWeight) = False Then D7156.ToolWeight = Trim$(rs7156!K7156_ToolWeight)
    If IsdbNull(rs7156!K7156_ToolSize) = False Then D7156.ToolSize = Trim$(rs7156!K7156_ToolSize)
    If IsdbNull(rs7156!K7156_DateTool) = False Then D7156.DateTool = Trim$(rs7156!K7156_DateTool)
    If IsdbNull(rs7156!K7156_JobCard) = False Then D7156.JobCard = Trim$(rs7156!K7156_JobCard)
    If IsdbNull(rs7156!K7156_seProcessProduction) = False Then D7156.seProcessProduction = Trim$(rs7156!K7156_seProcessProduction)
    If IsdbNull(rs7156!K7156_cdProcessProduction) = False Then D7156.cdProcessProduction = Trim$(rs7156!K7156_cdProcessProduction)
    If IsdbNull(rs7156!K7156_DateProduction) = False Then D7156.DateProduction = Trim$(rs7156!K7156_DateProduction)
    If IsdbNull(rs7156!K7156_DateAccept) = False Then D7156.DateAccept = Trim$(rs7156!K7156_DateAccept)
    If IsdbNull(rs7156!K7156_DateInsert) = False Then D7156.DateInsert = Trim$(rs7156!K7156_DateInsert)
    If IsdbNull(rs7156!K7156_DateUpdate) = False Then D7156.DateUpdate = Trim$(rs7156!K7156_DateUpdate)
    If IsdbNull(rs7156!K7156_InchargeInsert) = False Then D7156.InchargeInsert = Trim$(rs7156!K7156_InchargeInsert)
    If IsdbNull(rs7156!K7156_InchargeUpdate) = False Then D7156.InchargeUpdate = Trim$(rs7156!K7156_InchargeUpdate)
    If IsdbNull(rs7156!K7156_CheckUse) = False Then D7156.CheckUse = Trim$(rs7156!K7156_CheckUse)
    If IsdbNull(rs7156!K7156_Remark) = False Then D7156.Remark = Trim$(rs7156!K7156_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7156_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7156_MOVE(rs7156 As DataRow)
Try

    call D7156_CLEAR()   

    If IsdbNull(rs7156!K7156_ToolCode) = False Then D7156.ToolCode = Trim$(rs7156!K7156_ToolCode)
    If IsdbNull(rs7156!K7156_ToolNo) = False Then D7156.ToolNo = Trim$(rs7156!K7156_ToolNo)
    If IsdbNull(rs7156!K7156_SizeNo) = False Then D7156.SizeNo = Trim$(rs7156!K7156_SizeNo)
    If IsdbNull(rs7156!K7156_seToolGroup) = False Then D7156.seToolGroup = Trim$(rs7156!K7156_seToolGroup)
    If IsdbNull(rs7156!K7156_cdToolGroup) = False Then D7156.cdToolGroup = Trim$(rs7156!K7156_cdToolGroup)
    If IsdbNull(rs7156!K7156_BarcodeTool) = False Then D7156.BarcodeTool = Trim$(rs7156!K7156_BarcodeTool)
    If IsdbNull(rs7156!K7156_MaterialCode) = False Then D7156.MaterialCode = Trim$(rs7156!K7156_MaterialCode)
    If IsdbNull(rs7156!K7156_PurchasingOrderNo) = False Then D7156.PurchasingOrderNo = Trim$(rs7156!K7156_PurchasingOrderNo)
    If IsdbNull(rs7156!K7156_PurchasingOrderSeq) = False Then D7156.PurchasingOrderSeq = Trim$(rs7156!K7156_PurchasingOrderSeq)
    If IsdbNull(rs7156!K7156_ToolName) = False Then D7156.ToolName = Trim$(rs7156!K7156_ToolName)
    If IsdbNull(rs7156!K7156_ToolNameSimply) = False Then D7156.ToolNameSimply = Trim$(rs7156!K7156_ToolNameSimply)
    If IsdbNull(rs7156!K7156_ToolGroup) = False Then D7156.ToolGroup = Trim$(rs7156!K7156_ToolGroup)
    If IsdbNull(rs7156!K7156_ToolWidth) = False Then D7156.ToolWidth = Trim$(rs7156!K7156_ToolWidth)
    If IsdbNull(rs7156!K7156_ToolWeight) = False Then D7156.ToolWeight = Trim$(rs7156!K7156_ToolWeight)
    If IsdbNull(rs7156!K7156_ToolSize) = False Then D7156.ToolSize = Trim$(rs7156!K7156_ToolSize)
    If IsdbNull(rs7156!K7156_DateTool) = False Then D7156.DateTool = Trim$(rs7156!K7156_DateTool)
    If IsdbNull(rs7156!K7156_JobCard) = False Then D7156.JobCard = Trim$(rs7156!K7156_JobCard)
    If IsdbNull(rs7156!K7156_seProcessProduction) = False Then D7156.seProcessProduction = Trim$(rs7156!K7156_seProcessProduction)
    If IsdbNull(rs7156!K7156_cdProcessProduction) = False Then D7156.cdProcessProduction = Trim$(rs7156!K7156_cdProcessProduction)
    If IsdbNull(rs7156!K7156_DateProduction) = False Then D7156.DateProduction = Trim$(rs7156!K7156_DateProduction)
    If IsdbNull(rs7156!K7156_DateAccept) = False Then D7156.DateAccept = Trim$(rs7156!K7156_DateAccept)
    If IsdbNull(rs7156!K7156_DateInsert) = False Then D7156.DateInsert = Trim$(rs7156!K7156_DateInsert)
    If IsdbNull(rs7156!K7156_DateUpdate) = False Then D7156.DateUpdate = Trim$(rs7156!K7156_DateUpdate)
    If IsdbNull(rs7156!K7156_InchargeInsert) = False Then D7156.InchargeInsert = Trim$(rs7156!K7156_InchargeInsert)
    If IsdbNull(rs7156!K7156_InchargeUpdate) = False Then D7156.InchargeUpdate = Trim$(rs7156!K7156_InchargeUpdate)
    If IsdbNull(rs7156!K7156_CheckUse) = False Then D7156.CheckUse = Trim$(rs7156!K7156_CheckUse)
    If IsdbNull(rs7156!K7156_Remark) = False Then D7156.Remark = Trim$(rs7156!K7156_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7156_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7156_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7156 As T7156_AREA, TOOLCODE AS String) as Boolean

K7156_MOVE = False

Try
    If READ_PFK7156(TOOLCODE) = True Then
                z7156 = D7156
		K7156_MOVE = True
		else
	z7156 = nothing
     End If

     If  getColumIndex(spr,"ToolCode") > -1 then z7156.ToolCode = getDataM(spr, getColumIndex(spr,"ToolCode"), xRow)
     If  getColumIndex(spr,"ToolNo") > -1 then z7156.ToolNo = getDataM(spr, getColumIndex(spr,"ToolNo"), xRow)
     If  getColumIndex(spr,"SizeNo") > -1 then z7156.SizeNo = getDataM(spr, getColumIndex(spr,"SizeNo"), xRow)
     If  getColumIndex(spr,"seToolGroup") > -1 then z7156.seToolGroup = getDataM(spr, getColumIndex(spr,"seToolGroup"), xRow)
     If  getColumIndex(spr,"cdToolGroup") > -1 then z7156.cdToolGroup = getDataM(spr, getColumIndex(spr,"cdToolGroup"), xRow)
     If  getColumIndex(spr,"BarcodeTool") > -1 then z7156.BarcodeTool = getDataM(spr, getColumIndex(spr,"BarcodeTool"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z7156.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"PurchasingOrderNo") > -1 then z7156.PurchasingOrderNo = getDataM(spr, getColumIndex(spr,"PurchasingOrderNo"), xRow)
     If  getColumIndex(spr,"PurchasingOrderSeq") > -1 then z7156.PurchasingOrderSeq = getDataM(spr, getColumIndex(spr,"PurchasingOrderSeq"), xRow)
     If  getColumIndex(spr,"ToolName") > -1 then z7156.ToolName = getDataM(spr, getColumIndex(spr,"ToolName"), xRow)
     If  getColumIndex(spr,"ToolNameSimply") > -1 then z7156.ToolNameSimply = getDataM(spr, getColumIndex(spr,"ToolNameSimply"), xRow)
     If  getColumIndex(spr,"ToolGroup") > -1 then z7156.ToolGroup = getDataM(spr, getColumIndex(spr,"ToolGroup"), xRow)
     If  getColumIndex(spr,"ToolWidth") > -1 then z7156.ToolWidth = getDataM(spr, getColumIndex(spr,"ToolWidth"), xRow)
     If  getColumIndex(spr,"ToolWeight") > -1 then z7156.ToolWeight = getDataM(spr, getColumIndex(spr,"ToolWeight"), xRow)
     If  getColumIndex(spr,"ToolSize") > -1 then z7156.ToolSize = getDataM(spr, getColumIndex(spr,"ToolSize"), xRow)
     If  getColumIndex(spr,"DateTool") > -1 then z7156.DateTool = getDataM(spr, getColumIndex(spr,"DateTool"), xRow)
     If  getColumIndex(spr,"JobCard") > -1 then z7156.JobCard = getDataM(spr, getColumIndex(spr,"JobCard"), xRow)
     If  getColumIndex(spr,"seProcessProduction") > -1 then z7156.seProcessProduction = getDataM(spr, getColumIndex(spr,"seProcessProduction"), xRow)
     If  getColumIndex(spr,"cdProcessProduction") > -1 then z7156.cdProcessProduction = getDataM(spr, getColumIndex(spr,"cdProcessProduction"), xRow)
     If  getColumIndex(spr,"DateProduction") > -1 then z7156.DateProduction = getDataM(spr, getColumIndex(spr,"DateProduction"), xRow)
     If  getColumIndex(spr,"DateAccept") > -1 then z7156.DateAccept = getDataM(spr, getColumIndex(spr,"DateAccept"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7156.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7156.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7156.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7156.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7156.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7156.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7156_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7156_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7156 As T7156_AREA,CheckClear as Boolean,TOOLCODE AS String) as Boolean

K7156_MOVE = False

Try
    If READ_PFK7156(TOOLCODE) = True Then
                z7156 = D7156
		K7156_MOVE = True
		else
	If CheckClear  = True then z7156 = nothing
     End If

     If  getColumIndex(spr,"ToolCode") > -1 then z7156.ToolCode = getDataM(spr, getColumIndex(spr,"ToolCode"), xRow)
     If  getColumIndex(spr,"ToolNo") > -1 then z7156.ToolNo = getDataM(spr, getColumIndex(spr,"ToolNo"), xRow)
     If  getColumIndex(spr,"SizeNo") > -1 then z7156.SizeNo = getDataM(spr, getColumIndex(spr,"SizeNo"), xRow)
     If  getColumIndex(spr,"seToolGroup") > -1 then z7156.seToolGroup = getDataM(spr, getColumIndex(spr,"seToolGroup"), xRow)
     If  getColumIndex(spr,"cdToolGroup") > -1 then z7156.cdToolGroup = getDataM(spr, getColumIndex(spr,"cdToolGroup"), xRow)
     If  getColumIndex(spr,"BarcodeTool") > -1 then z7156.BarcodeTool = getDataM(spr, getColumIndex(spr,"BarcodeTool"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z7156.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"PurchasingOrderNo") > -1 then z7156.PurchasingOrderNo = getDataM(spr, getColumIndex(spr,"PurchasingOrderNo"), xRow)
     If  getColumIndex(spr,"PurchasingOrderSeq") > -1 then z7156.PurchasingOrderSeq = getDataM(spr, getColumIndex(spr,"PurchasingOrderSeq"), xRow)
     If  getColumIndex(spr,"ToolName") > -1 then z7156.ToolName = getDataM(spr, getColumIndex(spr,"ToolName"), xRow)
     If  getColumIndex(spr,"ToolNameSimply") > -1 then z7156.ToolNameSimply = getDataM(spr, getColumIndex(spr,"ToolNameSimply"), xRow)
     If  getColumIndex(spr,"ToolGroup") > -1 then z7156.ToolGroup = getDataM(spr, getColumIndex(spr,"ToolGroup"), xRow)
     If  getColumIndex(spr,"ToolWidth") > -1 then z7156.ToolWidth = getDataM(spr, getColumIndex(spr,"ToolWidth"), xRow)
     If  getColumIndex(spr,"ToolWeight") > -1 then z7156.ToolWeight = getDataM(spr, getColumIndex(spr,"ToolWeight"), xRow)
     If  getColumIndex(spr,"ToolSize") > -1 then z7156.ToolSize = getDataM(spr, getColumIndex(spr,"ToolSize"), xRow)
     If  getColumIndex(spr,"DateTool") > -1 then z7156.DateTool = getDataM(spr, getColumIndex(spr,"DateTool"), xRow)
     If  getColumIndex(spr,"JobCard") > -1 then z7156.JobCard = getDataM(spr, getColumIndex(spr,"JobCard"), xRow)
     If  getColumIndex(spr,"seProcessProduction") > -1 then z7156.seProcessProduction = getDataM(spr, getColumIndex(spr,"seProcessProduction"), xRow)
     If  getColumIndex(spr,"cdProcessProduction") > -1 then z7156.cdProcessProduction = getDataM(spr, getColumIndex(spr,"cdProcessProduction"), xRow)
     If  getColumIndex(spr,"DateProduction") > -1 then z7156.DateProduction = getDataM(spr, getColumIndex(spr,"DateProduction"), xRow)
     If  getColumIndex(spr,"DateAccept") > -1 then z7156.DateAccept = getDataM(spr, getColumIndex(spr,"DateAccept"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7156.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7156.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7156.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7156.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7156.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7156.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7156_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7156_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7156 As T7156_AREA, Job as String, TOOLCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7156_MOVE = False

Try
    If READ_PFK7156(TOOLCODE) = True Then
                z7156 = D7156
		K7156_MOVE = True
		else
	z7156 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7156")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "TOOLCODE":z7156.ToolCode = Children(i).Code
   Case "TOOLNO":z7156.ToolNo = Children(i).Code
   Case "SIZENO":z7156.SizeNo = Children(i).Code
   Case "SETOOLGROUP":z7156.seToolGroup = Children(i).Code
   Case "CDTOOLGROUP":z7156.cdToolGroup = Children(i).Code
   Case "BARCODETOOL":z7156.BarcodeTool = Children(i).Code
   Case "MATERIALCODE":z7156.MaterialCode = Children(i).Code
   Case "PURCHASINGORDERNO":z7156.PurchasingOrderNo = Children(i).Code
   Case "PURCHASINGORDERSEQ":z7156.PurchasingOrderSeq = Children(i).Code
   Case "TOOLNAME":z7156.ToolName = Children(i).Code
   Case "TOOLNAMESIMPLY":z7156.ToolNameSimply = Children(i).Code
   Case "TOOLGROUP":z7156.ToolGroup = Children(i).Code
   Case "TOOLWIDTH":z7156.ToolWidth = Children(i).Code
   Case "TOOLWEIGHT":z7156.ToolWeight = Children(i).Code
   Case "TOOLSIZE":z7156.ToolSize = Children(i).Code
   Case "DATETOOL":z7156.DateTool = Children(i).Code
   Case "JOBCARD":z7156.JobCard = Children(i).Code
   Case "SEPROCESSPRODUCTION":z7156.seProcessProduction = Children(i).Code
   Case "CDPROCESSPRODUCTION":z7156.cdProcessProduction = Children(i).Code
   Case "DATEPRODUCTION":z7156.DateProduction = Children(i).Code
   Case "DATEACCEPT":z7156.DateAccept = Children(i).Code
   Case "DATEINSERT":z7156.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7156.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7156.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7156.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7156.CheckUse = Children(i).Code
   Case "REMARK":z7156.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "TOOLCODE":z7156.ToolCode = Children(i).Data
   Case "TOOLNO":z7156.ToolNo = Children(i).Data
   Case "SIZENO":z7156.SizeNo = Children(i).Data
   Case "SETOOLGROUP":z7156.seToolGroup = Children(i).Data
   Case "CDTOOLGROUP":z7156.cdToolGroup = Children(i).Data
   Case "BARCODETOOL":z7156.BarcodeTool = Children(i).Data
   Case "MATERIALCODE":z7156.MaterialCode = Children(i).Data
   Case "PURCHASINGORDERNO":z7156.PurchasingOrderNo = Children(i).Data
   Case "PURCHASINGORDERSEQ":z7156.PurchasingOrderSeq = Children(i).Data
   Case "TOOLNAME":z7156.ToolName = Children(i).Data
   Case "TOOLNAMESIMPLY":z7156.ToolNameSimply = Children(i).Data
   Case "TOOLGROUP":z7156.ToolGroup = Children(i).Data
   Case "TOOLWIDTH":z7156.ToolWidth = Children(i).Data
   Case "TOOLWEIGHT":z7156.ToolWeight = Children(i).Data
   Case "TOOLSIZE":z7156.ToolSize = Children(i).Data
   Case "DATETOOL":z7156.DateTool = Children(i).Data
   Case "JOBCARD":z7156.JobCard = Children(i).Data
   Case "SEPROCESSPRODUCTION":z7156.seProcessProduction = Children(i).Data
   Case "CDPROCESSPRODUCTION":z7156.cdProcessProduction = Children(i).Data
   Case "DATEPRODUCTION":z7156.DateProduction = Children(i).Data
   Case "DATEACCEPT":z7156.DateAccept = Children(i).Data
   Case "DATEINSERT":z7156.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7156.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7156.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7156.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7156.CheckUse = Children(i).Data
   Case "REMARK":z7156.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7156_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7156_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7156 As T7156_AREA, Job as String, CheckClear as Boolean, TOOLCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7156_MOVE = False

Try
    If READ_PFK7156(TOOLCODE) = True Then
                z7156 = D7156
		K7156_MOVE = True
		else
	If CheckClear  = True then z7156 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7156")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "TOOLCODE":z7156.ToolCode = Children(i).Code
   Case "TOOLNO":z7156.ToolNo = Children(i).Code
   Case "SIZENO":z7156.SizeNo = Children(i).Code
   Case "SETOOLGROUP":z7156.seToolGroup = Children(i).Code
   Case "CDTOOLGROUP":z7156.cdToolGroup = Children(i).Code
   Case "BARCODETOOL":z7156.BarcodeTool = Children(i).Code
   Case "MATERIALCODE":z7156.MaterialCode = Children(i).Code
   Case "PURCHASINGORDERNO":z7156.PurchasingOrderNo = Children(i).Code
   Case "PURCHASINGORDERSEQ":z7156.PurchasingOrderSeq = Children(i).Code
   Case "TOOLNAME":z7156.ToolName = Children(i).Code
   Case "TOOLNAMESIMPLY":z7156.ToolNameSimply = Children(i).Code
   Case "TOOLGROUP":z7156.ToolGroup = Children(i).Code
   Case "TOOLWIDTH":z7156.ToolWidth = Children(i).Code
   Case "TOOLWEIGHT":z7156.ToolWeight = Children(i).Code
   Case "TOOLSIZE":z7156.ToolSize = Children(i).Code
   Case "DATETOOL":z7156.DateTool = Children(i).Code
   Case "JOBCARD":z7156.JobCard = Children(i).Code
   Case "SEPROCESSPRODUCTION":z7156.seProcessProduction = Children(i).Code
   Case "CDPROCESSPRODUCTION":z7156.cdProcessProduction = Children(i).Code
   Case "DATEPRODUCTION":z7156.DateProduction = Children(i).Code
   Case "DATEACCEPT":z7156.DateAccept = Children(i).Code
   Case "DATEINSERT":z7156.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7156.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7156.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7156.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7156.CheckUse = Children(i).Code
   Case "REMARK":z7156.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "TOOLCODE":z7156.ToolCode = Children(i).Data
   Case "TOOLNO":z7156.ToolNo = Children(i).Data
   Case "SIZENO":z7156.SizeNo = Children(i).Data
   Case "SETOOLGROUP":z7156.seToolGroup = Children(i).Data
   Case "CDTOOLGROUP":z7156.cdToolGroup = Children(i).Data
   Case "BARCODETOOL":z7156.BarcodeTool = Children(i).Data
   Case "MATERIALCODE":z7156.MaterialCode = Children(i).Data
   Case "PURCHASINGORDERNO":z7156.PurchasingOrderNo = Children(i).Data
   Case "PURCHASINGORDERSEQ":z7156.PurchasingOrderSeq = Children(i).Data
   Case "TOOLNAME":z7156.ToolName = Children(i).Data
   Case "TOOLNAMESIMPLY":z7156.ToolNameSimply = Children(i).Data
   Case "TOOLGROUP":z7156.ToolGroup = Children(i).Data
   Case "TOOLWIDTH":z7156.ToolWidth = Children(i).Data
   Case "TOOLWEIGHT":z7156.ToolWeight = Children(i).Data
   Case "TOOLSIZE":z7156.ToolSize = Children(i).Data
   Case "DATETOOL":z7156.DateTool = Children(i).Data
   Case "JOBCARD":z7156.JobCard = Children(i).Data
   Case "SEPROCESSPRODUCTION":z7156.seProcessProduction = Children(i).Data
   Case "CDPROCESSPRODUCTION":z7156.cdProcessProduction = Children(i).Data
   Case "DATEPRODUCTION":z7156.DateProduction = Children(i).Data
   Case "DATEACCEPT":z7156.DateAccept = Children(i).Data
   Case "DATEINSERT":z7156.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7156.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7156.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7156.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7156.CheckUse = Children(i).Data
   Case "REMARK":z7156.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7156_MOVE",vbCritical)
End Try
End Function 
    
End Module 
