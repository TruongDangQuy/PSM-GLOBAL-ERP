'=========================================================================================================================================================
'   TABLE : (PFK9919)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K9919

Structure T9919_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	ProgramNo	 AS String	'			varchar(100)		*
Public 	ItemCode	 AS String	'			char(6)		*
Public 	ItemName	 AS String	'			nvarchar(100)
Public 	ItemNameSimply	 AS String	'			nvarchar(50)
Public 	ItemNameForeign1	 AS String	'			nvarchar(50)
Public 	ItemNameForeign2	 AS String	'			nvarchar(50)
Public 	ProdjectName	 AS String	'			nvarchar(10)
Public 	DataType	 AS String	'			nvarchar(50)
Public 	DataSize	 AS Double	'			decimal
Public 	DataDecimal	 AS Double	'			decimal
Public 	TextAlign	 AS String	'			nvarchar(10)
Public 	HorizontalAlignment	 AS String	'			nvarchar(20)
Public 	VerticalAlignment	 AS String	'			nvarchar(20)
Public 	SizeWidth	 AS Double	'			decimal
Public 	SizeHeight	 AS Double	'			decimal
Public 	BackColot	 AS String	'			nvarchar(50)
Public 	ForeColor	 AS String	'			nvarchar(50)
Public 	FontName	 AS String	'			nvarchar(100)
Public 	FontSize	 AS Double	'			decimal
Public 	FontBold	 AS String	'			nvarchar(10)
Public 	Lock	 AS String	'			nvarchar(10)
Public 	Hidden	 AS String	'			nvarchar(10)
Public 	CheckMerge	 AS String	'			char(1)
Public 	CheckMergePolicy	 AS String	'			char(1)
Public 	CheckHead	 AS String	'			char(1)
Public 	CheckHeadType	 AS String	'			char(1)
Public 	CheckDev	 AS String	'			char(1)
Public 	REMK	 AS String	'			nvarchar(300)
'=========================================================================================================================================================
End structure

Public D9919 As T9919_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK9919(PROGRAMNO AS String, ITEMCODE AS String) As Boolean
    READ_PFK9919 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9919 "
    SQL = SQL & " WHERE K9919_ProgramNo		 = '" & ProgramNo & "' " 
    SQL = SQL & "   AND K9919_ItemCode		 = '" & ItemCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D9919_CLEAR: GoTo SKIP_READ_PFK9919
                
    Call K9919_MOVE(rd)
    READ_PFK9919 = True

SKIP_READ_PFK9919:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK9919",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK9919(PROGRAMNO AS String, ITEMCODE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9919 "
    SQL = SQL & " WHERE K9919_ProgramNo		 = '" & ProgramNo & "' " 
    SQL = SQL & "   AND K9919_ItemCode		 = '" & ItemCode & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK9919",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK9919(z9919 As T9919_AREA) As Boolean
    WRITE_PFK9919 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z9919)
 
    SQL = " INSERT INTO PFK9919 "
    SQL = SQL & " ( "
    SQL = SQL & " K9919_ProgramNo," 
    SQL = SQL & " K9919_ItemCode," 
    SQL = SQL & " K9919_ItemName," 
    SQL = SQL & " K9919_ItemNameSimply," 
    SQL = SQL & " K9919_ItemNameForeign1," 
    SQL = SQL & " K9919_ItemNameForeign2," 
    SQL = SQL & " K9919_ProdjectName," 
    SQL = SQL & " K9919_DataType," 
    SQL = SQL & " K9919_DataSize," 
    SQL = SQL & " K9919_DataDecimal," 
    SQL = SQL & " K9919_TextAlign," 
    SQL = SQL & " K9919_HorizontalAlignment," 
    SQL = SQL & " K9919_VerticalAlignment," 
    SQL = SQL & " K9919_SizeWidth," 
    SQL = SQL & " K9919_SizeHeight," 
    SQL = SQL & " K9919_BackColot," 
    SQL = SQL & " K9919_ForeColor," 
    SQL = SQL & " K9919_FontName," 
    SQL = SQL & " K9919_FontSize," 
    SQL = SQL & " K9919_FontBold," 
    SQL = SQL & " K9919_Lock," 
    SQL = SQL & " K9919_Hidden," 
    SQL = SQL & " K9919_CheckMerge," 
    SQL = SQL & " K9919_CheckMergePolicy," 
    SQL = SQL & " K9919_CheckHead," 
    SQL = SQL & " K9919_CheckHeadType," 
    SQL = SQL & " K9919_CheckDev," 
    SQL = SQL & " K9919_REMK " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z9919.ProgramNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9919.ItemCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9919.ItemName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9919.ItemNameSimply) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9919.ItemNameForeign1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9919.ItemNameForeign2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9919.ProdjectName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9919.DataType) & "', "  
    SQL = SQL & "   " & FormatSQL(z9919.DataSize) & ", "  
    SQL = SQL & "   " & FormatSQL(z9919.DataDecimal) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z9919.TextAlign) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9919.HorizontalAlignment) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9919.VerticalAlignment) & "', "  
    SQL = SQL & "   " & FormatSQL(z9919.SizeWidth) & ", "  
    SQL = SQL & "   " & FormatSQL(z9919.SizeHeight) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z9919.BackColot) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9919.ForeColor) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9919.FontName) & "', "  
    SQL = SQL & "   " & FormatSQL(z9919.FontSize) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z9919.FontBold) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9919.Lock) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9919.Hidden) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9919.CheckMerge) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9919.CheckMergePolicy) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9919.CheckHead) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9919.CheckHeadType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9919.CheckDev) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9919.REMK) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK9919 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK9919",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK9919(z9919 As T9919_AREA) As Boolean
    REWRITE_PFK9919 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z9919)
   
    SQL = " UPDATE PFK9919 SET "
    SQL = SQL & "    K9919_ItemName      = N'" & FormatSQL(z9919.ItemName) & "', " 
    SQL = SQL & "    K9919_ItemNameSimply      = N'" & FormatSQL(z9919.ItemNameSimply) & "', " 
    SQL = SQL & "    K9919_ItemNameForeign1      = N'" & FormatSQL(z9919.ItemNameForeign1) & "', " 
    SQL = SQL & "    K9919_ItemNameForeign2      = N'" & FormatSQL(z9919.ItemNameForeign2) & "', " 
    SQL = SQL & "    K9919_ProdjectName      = N'" & FormatSQL(z9919.ProdjectName) & "', " 
    SQL = SQL & "    K9919_DataType      = N'" & FormatSQL(z9919.DataType) & "', " 
    SQL = SQL & "    K9919_DataSize      =  " & FormatSQL(z9919.DataSize) & ", " 
    SQL = SQL & "    K9919_DataDecimal      =  " & FormatSQL(z9919.DataDecimal) & ", " 
    SQL = SQL & "    K9919_TextAlign      = N'" & FormatSQL(z9919.TextAlign) & "', " 
    SQL = SQL & "    K9919_HorizontalAlignment      = N'" & FormatSQL(z9919.HorizontalAlignment) & "', " 
    SQL = SQL & "    K9919_VerticalAlignment      = N'" & FormatSQL(z9919.VerticalAlignment) & "', " 
    SQL = SQL & "    K9919_SizeWidth      =  " & FormatSQL(z9919.SizeWidth) & ", " 
    SQL = SQL & "    K9919_SizeHeight      =  " & FormatSQL(z9919.SizeHeight) & ", " 
    SQL = SQL & "    K9919_BackColot      = N'" & FormatSQL(z9919.BackColot) & "', " 
    SQL = SQL & "    K9919_ForeColor      = N'" & FormatSQL(z9919.ForeColor) & "', " 
    SQL = SQL & "    K9919_FontName      = N'" & FormatSQL(z9919.FontName) & "', " 
    SQL = SQL & "    K9919_FontSize      =  " & FormatSQL(z9919.FontSize) & ", " 
    SQL = SQL & "    K9919_FontBold      = N'" & FormatSQL(z9919.FontBold) & "', " 
    SQL = SQL & "    K9919_Lock      = N'" & FormatSQL(z9919.Lock) & "', " 
    SQL = SQL & "    K9919_Hidden      = N'" & FormatSQL(z9919.Hidden) & "', " 
    SQL = SQL & "    K9919_CheckMerge      = N'" & FormatSQL(z9919.CheckMerge) & "', " 
    SQL = SQL & "    K9919_CheckMergePolicy      = N'" & FormatSQL(z9919.CheckMergePolicy) & "', " 
    SQL = SQL & "    K9919_CheckHead      = N'" & FormatSQL(z9919.CheckHead) & "', " 
    SQL = SQL & "    K9919_CheckHeadType      = N'" & FormatSQL(z9919.CheckHeadType) & "', " 
    SQL = SQL & "    K9919_CheckDev      = N'" & FormatSQL(z9919.CheckDev) & "', " 
    SQL = SQL & "    K9919_REMK      = N'" & FormatSQL(z9919.REMK) & "'  " 
    SQL = SQL & " WHERE K9919_ProgramNo		 = '" & z9919.ProgramNo & "' " 
    SQL = SQL & "   AND K9919_ItemCode		 = '" & z9919.ItemCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK9919 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK9919",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK9919(z9919 As T9919_AREA) As Boolean
    DELETE_PFK9919 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK9919 "
    SQL = SQL & " WHERE K9919_ProgramNo		 = '" & z9919.ProgramNo & "' " 
    SQL = SQL & "   AND K9919_ItemCode		 = '" & z9919.ItemCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK9919 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK9919",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D9919_CLEAR()
Try
    
   D9919.ProgramNo = ""
   D9919.ItemCode = ""
   D9919.ItemName = ""
   D9919.ItemNameSimply = ""
   D9919.ItemNameForeign1 = ""
   D9919.ItemNameForeign2 = ""
   D9919.ProdjectName = ""
   D9919.DataType = ""
    D9919.DataSize = 0 
    D9919.DataDecimal = 0 
   D9919.TextAlign = ""
   D9919.HorizontalAlignment = ""
   D9919.VerticalAlignment = ""
    D9919.SizeWidth = 0 
    D9919.SizeHeight = 0 
   D9919.BackColot = ""
   D9919.ForeColor = ""
   D9919.FontName = ""
    D9919.FontSize = 0 
   D9919.FontBold = ""
   D9919.Lock = ""
   D9919.Hidden = ""
   D9919.CheckMerge = ""
   D9919.CheckMergePolicy = ""
   D9919.CheckHead = ""
   D9919.CheckHeadType = ""
   D9919.CheckDev = ""
   D9919.REMK = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D9919_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x9919 As T9919_AREA)
Try
    
    x9919.ProgramNo = trim$(  x9919.ProgramNo)
    x9919.ItemCode = trim$(  x9919.ItemCode)
    x9919.ItemName = trim$(  x9919.ItemName)
    x9919.ItemNameSimply = trim$(  x9919.ItemNameSimply)
    x9919.ItemNameForeign1 = trim$(  x9919.ItemNameForeign1)
    x9919.ItemNameForeign2 = trim$(  x9919.ItemNameForeign2)
    x9919.ProdjectName = trim$(  x9919.ProdjectName)
    x9919.DataType = trim$(  x9919.DataType)
    x9919.DataSize = trim$(  x9919.DataSize)
    x9919.DataDecimal = trim$(  x9919.DataDecimal)
    x9919.TextAlign = trim$(  x9919.TextAlign)
    x9919.HorizontalAlignment = trim$(  x9919.HorizontalAlignment)
    x9919.VerticalAlignment = trim$(  x9919.VerticalAlignment)
    x9919.SizeWidth = trim$(  x9919.SizeWidth)
    x9919.SizeHeight = trim$(  x9919.SizeHeight)
    x9919.BackColot = trim$(  x9919.BackColot)
    x9919.ForeColor = trim$(  x9919.ForeColor)
    x9919.FontName = trim$(  x9919.FontName)
    x9919.FontSize = trim$(  x9919.FontSize)
    x9919.FontBold = trim$(  x9919.FontBold)
    x9919.Lock = trim$(  x9919.Lock)
    x9919.Hidden = trim$(  x9919.Hidden)
    x9919.CheckMerge = trim$(  x9919.CheckMerge)
    x9919.CheckMergePolicy = trim$(  x9919.CheckMergePolicy)
    x9919.CheckHead = trim$(  x9919.CheckHead)
    x9919.CheckHeadType = trim$(  x9919.CheckHeadType)
    x9919.CheckDev = trim$(  x9919.CheckDev)
    x9919.REMK = trim$(  x9919.REMK)
     
    If trim$( x9919.ProgramNo ) = "" Then x9919.ProgramNo = Space(1) 
    If trim$( x9919.ItemCode ) = "" Then x9919.ItemCode = Space(1) 
    If trim$( x9919.ItemName ) = "" Then x9919.ItemName = Space(1) 
    If trim$( x9919.ItemNameSimply ) = "" Then x9919.ItemNameSimply = Space(1) 
    If trim$( x9919.ItemNameForeign1 ) = "" Then x9919.ItemNameForeign1 = Space(1) 
    If trim$( x9919.ItemNameForeign2 ) = "" Then x9919.ItemNameForeign2 = Space(1) 
    If trim$( x9919.ProdjectName ) = "" Then x9919.ProdjectName = Space(1) 
    If trim$( x9919.DataType ) = "" Then x9919.DataType = Space(1) 
    If trim$( x9919.DataSize ) = "" Then x9919.DataSize = 0 
    If trim$( x9919.DataDecimal ) = "" Then x9919.DataDecimal = 0 
    If trim$( x9919.TextAlign ) = "" Then x9919.TextAlign = Space(1) 
    If trim$( x9919.HorizontalAlignment ) = "" Then x9919.HorizontalAlignment = Space(1) 
    If trim$( x9919.VerticalAlignment ) = "" Then x9919.VerticalAlignment = Space(1) 
    If trim$( x9919.SizeWidth ) = "" Then x9919.SizeWidth = 0 
    If trim$( x9919.SizeHeight ) = "" Then x9919.SizeHeight = 0 
    If trim$( x9919.BackColot ) = "" Then x9919.BackColot = Space(1) 
    If trim$( x9919.ForeColor ) = "" Then x9919.ForeColor = Space(1) 
    If trim$( x9919.FontName ) = "" Then x9919.FontName = Space(1) 
    If trim$( x9919.FontSize ) = "" Then x9919.FontSize = 0 
    If trim$( x9919.FontBold ) = "" Then x9919.FontBold = Space(1) 
    If trim$( x9919.Lock ) = "" Then x9919.Lock = Space(1) 
    If trim$( x9919.Hidden ) = "" Then x9919.Hidden = Space(1) 
    If trim$( x9919.CheckMerge ) = "" Then x9919.CheckMerge = Space(1) 
    If trim$( x9919.CheckMergePolicy ) = "" Then x9919.CheckMergePolicy = Space(1) 
    If trim$( x9919.CheckHead ) = "" Then x9919.CheckHead = Space(1) 
    If trim$( x9919.CheckHeadType ) = "" Then x9919.CheckHeadType = Space(1) 
    If trim$( x9919.CheckDev ) = "" Then x9919.CheckDev = Space(1) 
    If trim$( x9919.REMK ) = "" Then x9919.REMK = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K9919_MOVE(rs9919 As SqlClient.SqlDataReader)
Try

    call D9919_CLEAR()   

    If IsdbNull(rs9919!K9919_ProgramNo) = False Then D9919.ProgramNo = Trim$(rs9919!K9919_ProgramNo)
    If IsdbNull(rs9919!K9919_ItemCode) = False Then D9919.ItemCode = Trim$(rs9919!K9919_ItemCode)
    If IsdbNull(rs9919!K9919_ItemName) = False Then D9919.ItemName = Trim$(rs9919!K9919_ItemName)
    If IsdbNull(rs9919!K9919_ItemNameSimply) = False Then D9919.ItemNameSimply = Trim$(rs9919!K9919_ItemNameSimply)
    If IsdbNull(rs9919!K9919_ItemNameForeign1) = False Then D9919.ItemNameForeign1 = Trim$(rs9919!K9919_ItemNameForeign1)
    If IsdbNull(rs9919!K9919_ItemNameForeign2) = False Then D9919.ItemNameForeign2 = Trim$(rs9919!K9919_ItemNameForeign2)
    If IsdbNull(rs9919!K9919_ProdjectName) = False Then D9919.ProdjectName = Trim$(rs9919!K9919_ProdjectName)
    If IsdbNull(rs9919!K9919_DataType) = False Then D9919.DataType = Trim$(rs9919!K9919_DataType)
    If IsdbNull(rs9919!K9919_DataSize) = False Then D9919.DataSize = Trim$(rs9919!K9919_DataSize)
    If IsdbNull(rs9919!K9919_DataDecimal) = False Then D9919.DataDecimal = Trim$(rs9919!K9919_DataDecimal)
    If IsdbNull(rs9919!K9919_TextAlign) = False Then D9919.TextAlign = Trim$(rs9919!K9919_TextAlign)
    If IsdbNull(rs9919!K9919_HorizontalAlignment) = False Then D9919.HorizontalAlignment = Trim$(rs9919!K9919_HorizontalAlignment)
    If IsdbNull(rs9919!K9919_VerticalAlignment) = False Then D9919.VerticalAlignment = Trim$(rs9919!K9919_VerticalAlignment)
    If IsdbNull(rs9919!K9919_SizeWidth) = False Then D9919.SizeWidth = Trim$(rs9919!K9919_SizeWidth)
    If IsdbNull(rs9919!K9919_SizeHeight) = False Then D9919.SizeHeight = Trim$(rs9919!K9919_SizeHeight)
    If IsdbNull(rs9919!K9919_BackColot) = False Then D9919.BackColot = Trim$(rs9919!K9919_BackColot)
    If IsdbNull(rs9919!K9919_ForeColor) = False Then D9919.ForeColor = Trim$(rs9919!K9919_ForeColor)
    If IsdbNull(rs9919!K9919_FontName) = False Then D9919.FontName = Trim$(rs9919!K9919_FontName)
    If IsdbNull(rs9919!K9919_FontSize) = False Then D9919.FontSize = Trim$(rs9919!K9919_FontSize)
    If IsdbNull(rs9919!K9919_FontBold) = False Then D9919.FontBold = Trim$(rs9919!K9919_FontBold)
    If IsdbNull(rs9919!K9919_Lock) = False Then D9919.Lock = Trim$(rs9919!K9919_Lock)
    If IsdbNull(rs9919!K9919_Hidden) = False Then D9919.Hidden = Trim$(rs9919!K9919_Hidden)
    If IsdbNull(rs9919!K9919_CheckMerge) = False Then D9919.CheckMerge = Trim$(rs9919!K9919_CheckMerge)
    If IsdbNull(rs9919!K9919_CheckMergePolicy) = False Then D9919.CheckMergePolicy = Trim$(rs9919!K9919_CheckMergePolicy)
    If IsdbNull(rs9919!K9919_CheckHead) = False Then D9919.CheckHead = Trim$(rs9919!K9919_CheckHead)
    If IsdbNull(rs9919!K9919_CheckHeadType) = False Then D9919.CheckHeadType = Trim$(rs9919!K9919_CheckHeadType)
    If IsdbNull(rs9919!K9919_CheckDev) = False Then D9919.CheckDev = Trim$(rs9919!K9919_CheckDev)
    If IsdbNull(rs9919!K9919_REMK) = False Then D9919.REMK = Trim$(rs9919!K9919_REMK)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9919_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K9919_MOVE(rs9919 As DataRow)
Try

    call D9919_CLEAR()   

    If IsdbNull(rs9919!K9919_ProgramNo) = False Then D9919.ProgramNo = Trim$(rs9919!K9919_ProgramNo)
    If IsdbNull(rs9919!K9919_ItemCode) = False Then D9919.ItemCode = Trim$(rs9919!K9919_ItemCode)
    If IsdbNull(rs9919!K9919_ItemName) = False Then D9919.ItemName = Trim$(rs9919!K9919_ItemName)
    If IsdbNull(rs9919!K9919_ItemNameSimply) = False Then D9919.ItemNameSimply = Trim$(rs9919!K9919_ItemNameSimply)
    If IsdbNull(rs9919!K9919_ItemNameForeign1) = False Then D9919.ItemNameForeign1 = Trim$(rs9919!K9919_ItemNameForeign1)
    If IsdbNull(rs9919!K9919_ItemNameForeign2) = False Then D9919.ItemNameForeign2 = Trim$(rs9919!K9919_ItemNameForeign2)
    If IsdbNull(rs9919!K9919_ProdjectName) = False Then D9919.ProdjectName = Trim$(rs9919!K9919_ProdjectName)
    If IsdbNull(rs9919!K9919_DataType) = False Then D9919.DataType = Trim$(rs9919!K9919_DataType)
    If IsdbNull(rs9919!K9919_DataSize) = False Then D9919.DataSize = Trim$(rs9919!K9919_DataSize)
    If IsdbNull(rs9919!K9919_DataDecimal) = False Then D9919.DataDecimal = Trim$(rs9919!K9919_DataDecimal)
    If IsdbNull(rs9919!K9919_TextAlign) = False Then D9919.TextAlign = Trim$(rs9919!K9919_TextAlign)
    If IsdbNull(rs9919!K9919_HorizontalAlignment) = False Then D9919.HorizontalAlignment = Trim$(rs9919!K9919_HorizontalAlignment)
    If IsdbNull(rs9919!K9919_VerticalAlignment) = False Then D9919.VerticalAlignment = Trim$(rs9919!K9919_VerticalAlignment)
    If IsdbNull(rs9919!K9919_SizeWidth) = False Then D9919.SizeWidth = Trim$(rs9919!K9919_SizeWidth)
    If IsdbNull(rs9919!K9919_SizeHeight) = False Then D9919.SizeHeight = Trim$(rs9919!K9919_SizeHeight)
    If IsdbNull(rs9919!K9919_BackColot) = False Then D9919.BackColot = Trim$(rs9919!K9919_BackColot)
    If IsdbNull(rs9919!K9919_ForeColor) = False Then D9919.ForeColor = Trim$(rs9919!K9919_ForeColor)
    If IsdbNull(rs9919!K9919_FontName) = False Then D9919.FontName = Trim$(rs9919!K9919_FontName)
    If IsdbNull(rs9919!K9919_FontSize) = False Then D9919.FontSize = Trim$(rs9919!K9919_FontSize)
    If IsdbNull(rs9919!K9919_FontBold) = False Then D9919.FontBold = Trim$(rs9919!K9919_FontBold)
    If IsdbNull(rs9919!K9919_Lock) = False Then D9919.Lock = Trim$(rs9919!K9919_Lock)
    If IsdbNull(rs9919!K9919_Hidden) = False Then D9919.Hidden = Trim$(rs9919!K9919_Hidden)
    If IsdbNull(rs9919!K9919_CheckMerge) = False Then D9919.CheckMerge = Trim$(rs9919!K9919_CheckMerge)
    If IsdbNull(rs9919!K9919_CheckMergePolicy) = False Then D9919.CheckMergePolicy = Trim$(rs9919!K9919_CheckMergePolicy)
    If IsdbNull(rs9919!K9919_CheckHead) = False Then D9919.CheckHead = Trim$(rs9919!K9919_CheckHead)
    If IsdbNull(rs9919!K9919_CheckHeadType) = False Then D9919.CheckHeadType = Trim$(rs9919!K9919_CheckHeadType)
    If IsdbNull(rs9919!K9919_CheckDev) = False Then D9919.CheckDev = Trim$(rs9919!K9919_CheckDev)
    If IsdbNull(rs9919!K9919_REMK) = False Then D9919.REMK = Trim$(rs9919!K9919_REMK)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9919_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K9919_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9919 As T9919_AREA, PROGRAMNO AS String, ITEMCODE AS String) as Boolean

K9919_MOVE = False

Try
    If READ_PFK9919(PROGRAMNO, ITEMCODE) = True Then
                z9919 = D9919
		K9919_MOVE = True
		else
	z9919 = nothing
     End If

     If  getColumIndex(spr,"ProgramNo") > -1 then z9919.ProgramNo = getDataM(spr, getColumIndex(spr,"ProgramNo"), xRow)
     If  getColumIndex(spr,"ItemCode") > -1 then z9919.ItemCode = getDataM(spr, getColumIndex(spr,"ItemCode"), xRow)
     If  getColumIndex(spr,"ItemName") > -1 then z9919.ItemName = getDataM(spr, getColumIndex(spr,"ItemName"), xRow)
     If  getColumIndex(spr,"ItemNameSimply") > -1 then z9919.ItemNameSimply = getDataM(spr, getColumIndex(spr,"ItemNameSimply"), xRow)
     If  getColumIndex(spr,"ItemNameForeign1") > -1 then z9919.ItemNameForeign1 = getDataM(spr, getColumIndex(spr,"ItemNameForeign1"), xRow)
     If  getColumIndex(spr,"ItemNameForeign2") > -1 then z9919.ItemNameForeign2 = getDataM(spr, getColumIndex(spr,"ItemNameForeign2"), xRow)
     If  getColumIndex(spr,"ProdjectName") > -1 then z9919.ProdjectName = getDataM(spr, getColumIndex(spr,"ProdjectName"), xRow)
     If  getColumIndex(spr,"DataType") > -1 then z9919.DataType = getDataM(spr, getColumIndex(spr,"DataType"), xRow)
     If  getColumIndex(spr,"DataSize") > -1 then z9919.DataSize = getDataM(spr, getColumIndex(spr,"DataSize"), xRow)
     If  getColumIndex(spr,"DataDecimal") > -1 then z9919.DataDecimal = getDataM(spr, getColumIndex(spr,"DataDecimal"), xRow)
     If  getColumIndex(spr,"TextAlign") > -1 then z9919.TextAlign = getDataM(spr, getColumIndex(spr,"TextAlign"), xRow)
     If  getColumIndex(spr,"HorizontalAlignment") > -1 then z9919.HorizontalAlignment = getDataM(spr, getColumIndex(spr,"HorizontalAlignment"), xRow)
     If  getColumIndex(spr,"VerticalAlignment") > -1 then z9919.VerticalAlignment = getDataM(spr, getColumIndex(spr,"VerticalAlignment"), xRow)
     If  getColumIndex(spr,"SizeWidth") > -1 then z9919.SizeWidth = getDataM(spr, getColumIndex(spr,"SizeWidth"), xRow)
     If  getColumIndex(spr,"SizeHeight") > -1 then z9919.SizeHeight = getDataM(spr, getColumIndex(spr,"SizeHeight"), xRow)
     If  getColumIndex(spr,"BackColot") > -1 then z9919.BackColot = getDataM(spr, getColumIndex(spr,"BackColot"), xRow)
     If  getColumIndex(spr,"ForeColor") > -1 then z9919.ForeColor = getDataM(spr, getColumIndex(spr,"ForeColor"), xRow)
     If  getColumIndex(spr,"FontName") > -1 then z9919.FontName = getDataM(spr, getColumIndex(spr,"FontName"), xRow)
     If  getColumIndex(spr,"FontSize") > -1 then z9919.FontSize = getDataM(spr, getColumIndex(spr,"FontSize"), xRow)
     If  getColumIndex(spr,"FontBold") > -1 then z9919.FontBold = getDataM(spr, getColumIndex(spr,"FontBold"), xRow)
     If  getColumIndex(spr,"Lock") > -1 then z9919.Lock = getDataM(spr, getColumIndex(spr,"Lock"), xRow)
     If  getColumIndex(spr,"Hidden") > -1 then z9919.Hidden = getDataM(spr, getColumIndex(spr,"Hidden"), xRow)
     If  getColumIndex(spr,"CheckMerge") > -1 then z9919.CheckMerge = getDataM(spr, getColumIndex(spr,"CheckMerge"), xRow)
     If  getColumIndex(spr,"CheckMergePolicy") > -1 then z9919.CheckMergePolicy = getDataM(spr, getColumIndex(spr,"CheckMergePolicy"), xRow)
     If  getColumIndex(spr,"CheckHead") > -1 then z9919.CheckHead = getDataM(spr, getColumIndex(spr,"CheckHead"), xRow)
     If  getColumIndex(spr,"CheckHeadType") > -1 then z9919.CheckHeadType = getDataM(spr, getColumIndex(spr,"CheckHeadType"), xRow)
     If  getColumIndex(spr,"CheckDev") > -1 then z9919.CheckDev = getDataM(spr, getColumIndex(spr,"CheckDev"), xRow)
     If  getColumIndex(spr,"REMK") > -1 then z9919.REMK = getDataM(spr, getColumIndex(spr,"REMK"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K9919_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K9919_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9919 As T9919_AREA,CheckClear as Boolean,PROGRAMNO AS String, ITEMCODE AS String) as Boolean

K9919_MOVE = False

Try
    If READ_PFK9919(PROGRAMNO, ITEMCODE) = True Then
                z9919 = D9919
		K9919_MOVE = True
		else
	If CheckClear  = True then z9919 = nothing
     End If

     If  getColumIndex(spr,"ProgramNo") > -1 then z9919.ProgramNo = getDataM(spr, getColumIndex(spr,"ProgramNo"), xRow)
     If  getColumIndex(spr,"ItemCode") > -1 then z9919.ItemCode = getDataM(spr, getColumIndex(spr,"ItemCode"), xRow)
     If  getColumIndex(spr,"ItemName") > -1 then z9919.ItemName = getDataM(spr, getColumIndex(spr,"ItemName"), xRow)
     If  getColumIndex(spr,"ItemNameSimply") > -1 then z9919.ItemNameSimply = getDataM(spr, getColumIndex(spr,"ItemNameSimply"), xRow)
     If  getColumIndex(spr,"ItemNameForeign1") > -1 then z9919.ItemNameForeign1 = getDataM(spr, getColumIndex(spr,"ItemNameForeign1"), xRow)
     If  getColumIndex(spr,"ItemNameForeign2") > -1 then z9919.ItemNameForeign2 = getDataM(spr, getColumIndex(spr,"ItemNameForeign2"), xRow)
     If  getColumIndex(spr,"ProdjectName") > -1 then z9919.ProdjectName = getDataM(spr, getColumIndex(spr,"ProdjectName"), xRow)
     If  getColumIndex(spr,"DataType") > -1 then z9919.DataType = getDataM(spr, getColumIndex(spr,"DataType"), xRow)
     If  getColumIndex(spr,"DataSize") > -1 then z9919.DataSize = getDataM(spr, getColumIndex(spr,"DataSize"), xRow)
     If  getColumIndex(spr,"DataDecimal") > -1 then z9919.DataDecimal = getDataM(spr, getColumIndex(spr,"DataDecimal"), xRow)
     If  getColumIndex(spr,"TextAlign") > -1 then z9919.TextAlign = getDataM(spr, getColumIndex(spr,"TextAlign"), xRow)
     If  getColumIndex(spr,"HorizontalAlignment") > -1 then z9919.HorizontalAlignment = getDataM(spr, getColumIndex(spr,"HorizontalAlignment"), xRow)
     If  getColumIndex(spr,"VerticalAlignment") > -1 then z9919.VerticalAlignment = getDataM(spr, getColumIndex(spr,"VerticalAlignment"), xRow)
     If  getColumIndex(spr,"SizeWidth") > -1 then z9919.SizeWidth = getDataM(spr, getColumIndex(spr,"SizeWidth"), xRow)
     If  getColumIndex(spr,"SizeHeight") > -1 then z9919.SizeHeight = getDataM(spr, getColumIndex(spr,"SizeHeight"), xRow)
     If  getColumIndex(spr,"BackColot") > -1 then z9919.BackColot = getDataM(spr, getColumIndex(spr,"BackColot"), xRow)
     If  getColumIndex(spr,"ForeColor") > -1 then z9919.ForeColor = getDataM(spr, getColumIndex(spr,"ForeColor"), xRow)
     If  getColumIndex(spr,"FontName") > -1 then z9919.FontName = getDataM(spr, getColumIndex(spr,"FontName"), xRow)
     If  getColumIndex(spr,"FontSize") > -1 then z9919.FontSize = getDataM(spr, getColumIndex(spr,"FontSize"), xRow)
     If  getColumIndex(spr,"FontBold") > -1 then z9919.FontBold = getDataM(spr, getColumIndex(spr,"FontBold"), xRow)
     If  getColumIndex(spr,"Lock") > -1 then z9919.Lock = getDataM(spr, getColumIndex(spr,"Lock"), xRow)
     If  getColumIndex(spr,"Hidden") > -1 then z9919.Hidden = getDataM(spr, getColumIndex(spr,"Hidden"), xRow)
     If  getColumIndex(spr,"CheckMerge") > -1 then z9919.CheckMerge = getDataM(spr, getColumIndex(spr,"CheckMerge"), xRow)
     If  getColumIndex(spr,"CheckMergePolicy") > -1 then z9919.CheckMergePolicy = getDataM(spr, getColumIndex(spr,"CheckMergePolicy"), xRow)
     If  getColumIndex(spr,"CheckHead") > -1 then z9919.CheckHead = getDataM(spr, getColumIndex(spr,"CheckHead"), xRow)
     If  getColumIndex(spr,"CheckHeadType") > -1 then z9919.CheckHeadType = getDataM(spr, getColumIndex(spr,"CheckHeadType"), xRow)
     If  getColumIndex(spr,"CheckDev") > -1 then z9919.CheckDev = getDataM(spr, getColumIndex(spr,"CheckDev"), xRow)
     If  getColumIndex(spr,"REMK") > -1 then z9919.REMK = getDataM(spr, getColumIndex(spr,"REMK"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K9919_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K9919_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9919 As T9919_AREA, Job as String, PROGRAMNO AS String, ITEMCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9919_MOVE = False

Try
    If READ_PFK9919(PROGRAMNO, ITEMCODE) = True Then
                z9919 = D9919
		K9919_MOVE = True
		else
	z9919 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9919")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PROGRAMNO":z9919.ProgramNo = Children(i).Code
   Case "ITEMCODE":z9919.ItemCode = Children(i).Code
   Case "ITEMNAME":z9919.ItemName = Children(i).Code
   Case "ITEMNAMESIMPLY":z9919.ItemNameSimply = Children(i).Code
   Case "ITEMNAMEFOREIGN1":z9919.ItemNameForeign1 = Children(i).Code
   Case "ITEMNAMEFOREIGN2":z9919.ItemNameForeign2 = Children(i).Code
   Case "PRODJECTNAME":z9919.ProdjectName = Children(i).Code
   Case "DATATYPE":z9919.DataType = Children(i).Code
   Case "DATASIZE":z9919.DataSize = Children(i).Code
   Case "DATADECIMAL":z9919.DataDecimal = Children(i).Code
   Case "TEXTALIGN":z9919.TextAlign = Children(i).Code
   Case "HORIZONTALALIGNMENT":z9919.HorizontalAlignment = Children(i).Code
   Case "VERTICALALIGNMENT":z9919.VerticalAlignment = Children(i).Code
   Case "SIZEWIDTH":z9919.SizeWidth = Children(i).Code
   Case "SIZEHEIGHT":z9919.SizeHeight = Children(i).Code
   Case "BACKCOLOT":z9919.BackColot = Children(i).Code
   Case "FORECOLOR":z9919.ForeColor = Children(i).Code
   Case "FONTNAME":z9919.FontName = Children(i).Code
   Case "FONTSIZE":z9919.FontSize = Children(i).Code
   Case "FONTBOLD":z9919.FontBold = Children(i).Code
   Case "LOCK":z9919.Lock = Children(i).Code
   Case "HIDDEN":z9919.Hidden = Children(i).Code
   Case "CHECKMERGE":z9919.CheckMerge = Children(i).Code
   Case "CHECKMERGEPOLICY":z9919.CheckMergePolicy = Children(i).Code
   Case "CHECKHEAD":z9919.CheckHead = Children(i).Code
   Case "CHECKHEADTYPE":z9919.CheckHeadType = Children(i).Code
   Case "CHECKDEV":z9919.CheckDev = Children(i).Code
   Case "REMK":z9919.REMK = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PROGRAMNO":z9919.ProgramNo = Children(i).Data
   Case "ITEMCODE":z9919.ItemCode = Children(i).Data
   Case "ITEMNAME":z9919.ItemName = Children(i).Data
   Case "ITEMNAMESIMPLY":z9919.ItemNameSimply = Children(i).Data
   Case "ITEMNAMEFOREIGN1":z9919.ItemNameForeign1 = Children(i).Data
   Case "ITEMNAMEFOREIGN2":z9919.ItemNameForeign2 = Children(i).Data
   Case "PRODJECTNAME":z9919.ProdjectName = Children(i).Data
   Case "DATATYPE":z9919.DataType = Children(i).Data
   Case "DATASIZE":z9919.DataSize = Children(i).Data
   Case "DATADECIMAL":z9919.DataDecimal = Children(i).Data
   Case "TEXTALIGN":z9919.TextAlign = Children(i).Data
   Case "HORIZONTALALIGNMENT":z9919.HorizontalAlignment = Children(i).Data
   Case "VERTICALALIGNMENT":z9919.VerticalAlignment = Children(i).Data
   Case "SIZEWIDTH":z9919.SizeWidth = Children(i).Data
   Case "SIZEHEIGHT":z9919.SizeHeight = Children(i).Data
   Case "BACKCOLOT":z9919.BackColot = Children(i).Data
   Case "FORECOLOR":z9919.ForeColor = Children(i).Data
   Case "FONTNAME":z9919.FontName = Children(i).Data
   Case "FONTSIZE":z9919.FontSize = Children(i).Data
   Case "FONTBOLD":z9919.FontBold = Children(i).Data
   Case "LOCK":z9919.Lock = Children(i).Data
   Case "HIDDEN":z9919.Hidden = Children(i).Data
   Case "CHECKMERGE":z9919.CheckMerge = Children(i).Data
   Case "CHECKMERGEPOLICY":z9919.CheckMergePolicy = Children(i).Data
   Case "CHECKHEAD":z9919.CheckHead = Children(i).Data
   Case "CHECKHEADTYPE":z9919.CheckHeadType = Children(i).Data
   Case "CHECKDEV":z9919.CheckDev = Children(i).Data
   Case "REMK":z9919.REMK = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K9919_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K9919_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9919 As T9919_AREA, Job as String, CheckClear as Boolean, PROGRAMNO AS String, ITEMCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9919_MOVE = False

Try
    If READ_PFK9919(PROGRAMNO, ITEMCODE) = True Then
                z9919 = D9919
		K9919_MOVE = True
		else
	If CheckClear  = True then z9919 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9919")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PROGRAMNO":z9919.ProgramNo = Children(i).Code
   Case "ITEMCODE":z9919.ItemCode = Children(i).Code
   Case "ITEMNAME":z9919.ItemName = Children(i).Code
   Case "ITEMNAMESIMPLY":z9919.ItemNameSimply = Children(i).Code
   Case "ITEMNAMEFOREIGN1":z9919.ItemNameForeign1 = Children(i).Code
   Case "ITEMNAMEFOREIGN2":z9919.ItemNameForeign2 = Children(i).Code
   Case "PRODJECTNAME":z9919.ProdjectName = Children(i).Code
   Case "DATATYPE":z9919.DataType = Children(i).Code
   Case "DATASIZE":z9919.DataSize = Children(i).Code
   Case "DATADECIMAL":z9919.DataDecimal = Children(i).Code
   Case "TEXTALIGN":z9919.TextAlign = Children(i).Code
   Case "HORIZONTALALIGNMENT":z9919.HorizontalAlignment = Children(i).Code
   Case "VERTICALALIGNMENT":z9919.VerticalAlignment = Children(i).Code
   Case "SIZEWIDTH":z9919.SizeWidth = Children(i).Code
   Case "SIZEHEIGHT":z9919.SizeHeight = Children(i).Code
   Case "BACKCOLOT":z9919.BackColot = Children(i).Code
   Case "FORECOLOR":z9919.ForeColor = Children(i).Code
   Case "FONTNAME":z9919.FontName = Children(i).Code
   Case "FONTSIZE":z9919.FontSize = Children(i).Code
   Case "FONTBOLD":z9919.FontBold = Children(i).Code
   Case "LOCK":z9919.Lock = Children(i).Code
   Case "HIDDEN":z9919.Hidden = Children(i).Code
   Case "CHECKMERGE":z9919.CheckMerge = Children(i).Code
   Case "CHECKMERGEPOLICY":z9919.CheckMergePolicy = Children(i).Code
   Case "CHECKHEAD":z9919.CheckHead = Children(i).Code
   Case "CHECKHEADTYPE":z9919.CheckHeadType = Children(i).Code
   Case "CHECKDEV":z9919.CheckDev = Children(i).Code
   Case "REMK":z9919.REMK = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PROGRAMNO":z9919.ProgramNo = Children(i).Data
   Case "ITEMCODE":z9919.ItemCode = Children(i).Data
   Case "ITEMNAME":z9919.ItemName = Children(i).Data
   Case "ITEMNAMESIMPLY":z9919.ItemNameSimply = Children(i).Data
   Case "ITEMNAMEFOREIGN1":z9919.ItemNameForeign1 = Children(i).Data
   Case "ITEMNAMEFOREIGN2":z9919.ItemNameForeign2 = Children(i).Data
   Case "PRODJECTNAME":z9919.ProdjectName = Children(i).Data
   Case "DATATYPE":z9919.DataType = Children(i).Data
   Case "DATASIZE":z9919.DataSize = Children(i).Data
   Case "DATADECIMAL":z9919.DataDecimal = Children(i).Data
   Case "TEXTALIGN":z9919.TextAlign = Children(i).Data
   Case "HORIZONTALALIGNMENT":z9919.HorizontalAlignment = Children(i).Data
   Case "VERTICALALIGNMENT":z9919.VerticalAlignment = Children(i).Data
   Case "SIZEWIDTH":z9919.SizeWidth = Children(i).Data
   Case "SIZEHEIGHT":z9919.SizeHeight = Children(i).Data
   Case "BACKCOLOT":z9919.BackColot = Children(i).Data
   Case "FORECOLOR":z9919.ForeColor = Children(i).Data
   Case "FONTNAME":z9919.FontName = Children(i).Data
   Case "FONTSIZE":z9919.FontSize = Children(i).Data
   Case "FONTBOLD":z9919.FontBold = Children(i).Data
   Case "LOCK":z9919.Lock = Children(i).Data
   Case "HIDDEN":z9919.Hidden = Children(i).Data
   Case "CHECKMERGE":z9919.CheckMerge = Children(i).Data
   Case "CHECKMERGEPOLICY":z9919.CheckMergePolicy = Children(i).Data
   Case "CHECKHEAD":z9919.CheckHead = Children(i).Data
   Case "CHECKHEADTYPE":z9919.CheckHeadType = Children(i).Data
   Case "CHECKDEV":z9919.CheckDev = Children(i).Data
   Case "REMK":z9919.REMK = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K9919_MOVE",vbCritical)
End Try
End Function 
    
End Module 
