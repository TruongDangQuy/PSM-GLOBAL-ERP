'=========================================================================================================================================================
'   TABLE : (PFK7121)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7121

Structure T7121_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	ColorCode	 AS String	'			nvarchar(50)		*
        Public ColorName As String  '			nvarchar(200)
        Public ColorNameS1 As String  '			nvarchar(200)
        Public ColorNameS2 As String  '			nvarchar(200)
Public 	ColorNameSimple	 AS String	'			nvarchar(20)
Public 	CustomerCode	 AS String	'			char(6)
Public 	seColorBase	 AS String	'			char(3)
Public 	cdColorBase	 AS String	'			char(3)
Public 	seColorCategory	 AS String	'			char(3)
Public 	cdColorCategory	 AS String	'			char(3)
Public 	ColorPosition	 AS String	'			nvarchar(50)
Public 	CheckBase	 AS String	'			char(1)
Public 	CheckUse	 AS String	'			char(1)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	Remark	 AS String	'			nvarchar(100)
'=========================================================================================================================================================
End structure

Public D7121 As T7121_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7121(COLORCODE AS String) As Boolean
    READ_PFK7121 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7121 "
    SQL = SQL & " WHERE K7121_ColorCode		 = '" & ColorCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7121_CLEAR: GoTo SKIP_READ_PFK7121
                
    Call K7121_MOVE(rd)
    READ_PFK7121 = True

SKIP_READ_PFK7121:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7121",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7121(COLORCODE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7121 "
    SQL = SQL & " WHERE K7121_ColorCode		 = '" & ColorCode & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7121",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7121(z7121 As T7121_AREA) As Boolean
    WRITE_PFK7121 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7121)
 
    SQL = " INSERT INTO PFK7121 "
    SQL = SQL & " ( "
    SQL = SQL & " K7121_ColorCode," 
            SQL = SQL & " K7121_ColorName,"
            SQL = SQL & " K7121_ColorNameS1,"
            SQL = SQL & " K7121_ColorNameS2,"
    SQL = SQL & " K7121_ColorNameSimple," 
    SQL = SQL & " K7121_CustomerCode," 
    SQL = SQL & " K7121_seColorBase," 
    SQL = SQL & " K7121_cdColorBase," 
    SQL = SQL & " K7121_seColorCategory," 
    SQL = SQL & " K7121_cdColorCategory," 
    SQL = SQL & " K7121_ColorPosition," 
    SQL = SQL & " K7121_CheckBase," 
    SQL = SQL & " K7121_CheckUse," 
    SQL = SQL & " K7121_DateInsert," 
    SQL = SQL & " K7121_DateUpdate," 
    SQL = SQL & " K7121_InchargeInsert," 
    SQL = SQL & " K7121_InchargeUpdate," 
    SQL = SQL & " K7121_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7121.ColorCode) & "', "  
            SQL = SQL & "  N'" & FormatSQL(z7121.ColorName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7121.ColorNameS1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7121.ColorNameS2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7121.ColorNameSimple) & "', "
    SQL = SQL & "  N'" & FormatSQL(z7121.CustomerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7121.seColorBase) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7121.cdColorBase) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7121.seColorCategory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7121.cdColorCategory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7121.ColorPosition) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7121.CheckBase) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7121.CheckUse) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7121.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7121.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7121.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7121.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7121.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7121 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7121",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7121(z7121 As T7121_AREA) As Boolean
    REWRITE_PFK7121 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7121)
   
    SQL = " UPDATE PFK7121 SET "
            SQL = SQL & "    K7121_ColorName      = N'" & FormatSQL(z7121.ColorName) & "', "
            SQL = SQL & "    K7121_ColorNameS1      = N'" & FormatSQL(z7121.ColorNameS1) & "', "
            SQL = SQL & "    K7121_ColorNameS2      = N'" & FormatSQL(z7121.ColorNameS2) & "', "
    SQL = SQL & "    K7121_ColorNameSimple      = N'" & FormatSQL(z7121.ColorNameSimple) & "', " 
    SQL = SQL & "    K7121_CustomerCode      = N'" & FormatSQL(z7121.CustomerCode) & "', " 
    SQL = SQL & "    K7121_seColorBase      = N'" & FormatSQL(z7121.seColorBase) & "', " 
    SQL = SQL & "    K7121_cdColorBase      = N'" & FormatSQL(z7121.cdColorBase) & "', " 
    SQL = SQL & "    K7121_seColorCategory      = N'" & FormatSQL(z7121.seColorCategory) & "', " 
    SQL = SQL & "    K7121_cdColorCategory      = N'" & FormatSQL(z7121.cdColorCategory) & "', " 
    SQL = SQL & "    K7121_ColorPosition      = N'" & FormatSQL(z7121.ColorPosition) & "', " 
    SQL = SQL & "    K7121_CheckBase      = N'" & FormatSQL(z7121.CheckBase) & "', " 
    SQL = SQL & "    K7121_CheckUse      = N'" & FormatSQL(z7121.CheckUse) & "', " 
    SQL = SQL & "    K7121_DateInsert      = N'" & FormatSQL(z7121.DateInsert) & "', " 
    SQL = SQL & "    K7121_DateUpdate      = N'" & FormatSQL(z7121.DateUpdate) & "', " 
    SQL = SQL & "    K7121_InchargeInsert      = N'" & FormatSQL(z7121.InchargeInsert) & "', " 
    SQL = SQL & "    K7121_InchargeUpdate      = N'" & FormatSQL(z7121.InchargeUpdate) & "', " 
    SQL = SQL & "    K7121_Remark      = N'" & FormatSQL(z7121.Remark) & "'  " 
    SQL = SQL & " WHERE K7121_ColorCode		 = '" & z7121.ColorCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7121 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7121",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7121(z7121 As T7121_AREA) As Boolean
    DELETE_PFK7121 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7121 "
    SQL = SQL & " WHERE K7121_ColorCode		 = '" & z7121.ColorCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7121 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7121",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7121_CLEAR()
Try
    
   D7121.ColorCode = ""
            D7121.ColorName = ""
            D7121.ColorNameS1 = ""
            D7121.ColorNameS2 = ""
   D7121.ColorNameSimple = ""
   D7121.CustomerCode = ""
   D7121.seColorBase = ""
   D7121.cdColorBase = ""
   D7121.seColorCategory = ""
   D7121.cdColorCategory = ""
   D7121.ColorPosition = ""
   D7121.CheckBase = ""
   D7121.CheckUse = ""
   D7121.DateInsert = ""
   D7121.DateUpdate = ""
   D7121.InchargeInsert = ""
   D7121.InchargeUpdate = ""
   D7121.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7121_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7121 As T7121_AREA)
Try
    
    x7121.ColorCode = trim$(  x7121.ColorCode)
            x7121.ColorName = Trim$(x7121.ColorName)
            x7121.ColorNameS1 = Trim$(x7121.ColorNameS1)
            x7121.ColorNameS2 = Trim$(x7121.ColorNameS2)
    x7121.ColorNameSimple = trim$(  x7121.ColorNameSimple)
    x7121.CustomerCode = trim$(  x7121.CustomerCode)
    x7121.seColorBase = trim$(  x7121.seColorBase)
    x7121.cdColorBase = trim$(  x7121.cdColorBase)
    x7121.seColorCategory = trim$(  x7121.seColorCategory)
    x7121.cdColorCategory = trim$(  x7121.cdColorCategory)
    x7121.ColorPosition = trim$(  x7121.ColorPosition)
    x7121.CheckBase = trim$(  x7121.CheckBase)
    x7121.CheckUse = trim$(  x7121.CheckUse)
    x7121.DateInsert = trim$(  x7121.DateInsert)
    x7121.DateUpdate = trim$(  x7121.DateUpdate)
    x7121.InchargeInsert = trim$(  x7121.InchargeInsert)
    x7121.InchargeUpdate = trim$(  x7121.InchargeUpdate)
    x7121.Remark = trim$(  x7121.Remark)
     
    If trim$( x7121.ColorCode ) = "" Then x7121.ColorCode = Space(1) 
            If Trim$(x7121.ColorName) = "" Then x7121.ColorName = Space(1)
            If Trim$(x7121.ColorNameS1) = "" Then x7121.ColorNameS1 = Space(1)
            If Trim$(x7121.ColorNameS2) = "" Then x7121.ColorNameS2 = Space(1)
    If trim$( x7121.ColorNameSimple ) = "" Then x7121.ColorNameSimple = Space(1) 
    If trim$( x7121.CustomerCode ) = "" Then x7121.CustomerCode = Space(1) 
    If trim$( x7121.seColorBase ) = "" Then x7121.seColorBase = Space(1) 
    If trim$( x7121.cdColorBase ) = "" Then x7121.cdColorBase = Space(1) 
    If trim$( x7121.seColorCategory ) = "" Then x7121.seColorCategory = Space(1) 
    If trim$( x7121.cdColorCategory ) = "" Then x7121.cdColorCategory = Space(1) 
    If trim$( x7121.ColorPosition ) = "" Then x7121.ColorPosition = Space(1) 
    If trim$( x7121.CheckBase ) = "" Then x7121.CheckBase = Space(1) 
    If trim$( x7121.CheckUse ) = "" Then x7121.CheckUse = Space(1) 
    If trim$( x7121.DateInsert ) = "" Then x7121.DateInsert = Space(1) 
    If trim$( x7121.DateUpdate ) = "" Then x7121.DateUpdate = Space(1) 
    If trim$( x7121.InchargeInsert ) = "" Then x7121.InchargeInsert = Space(1) 
    If trim$( x7121.InchargeUpdate ) = "" Then x7121.InchargeUpdate = Space(1) 
    If trim$( x7121.Remark ) = "" Then x7121.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7121_MOVE(rs7121 As SqlClient.SqlDataReader)
Try

    call D7121_CLEAR()   

    If IsdbNull(rs7121!K7121_ColorCode) = False Then D7121.ColorCode = Trim$(rs7121!K7121_ColorCode)
            If IsDBNull(rs7121!K7121_ColorName) = False Then D7121.ColorName = Trim$(rs7121!K7121_ColorName)
            If IsDBNull(rs7121!K7121_ColorNameS1) = False Then D7121.ColorNameS1 = Trim$(rs7121!K7121_ColorNameS1)
            If IsDBNull(rs7121!K7121_ColorNameS2) = False Then D7121.ColorNameS2 = Trim$(rs7121!K7121_ColorNameS2)
    If IsdbNull(rs7121!K7121_ColorNameSimple) = False Then D7121.ColorNameSimple = Trim$(rs7121!K7121_ColorNameSimple)
    If IsdbNull(rs7121!K7121_CustomerCode) = False Then D7121.CustomerCode = Trim$(rs7121!K7121_CustomerCode)
    If IsdbNull(rs7121!K7121_seColorBase) = False Then D7121.seColorBase = Trim$(rs7121!K7121_seColorBase)
    If IsdbNull(rs7121!K7121_cdColorBase) = False Then D7121.cdColorBase = Trim$(rs7121!K7121_cdColorBase)
    If IsdbNull(rs7121!K7121_seColorCategory) = False Then D7121.seColorCategory = Trim$(rs7121!K7121_seColorCategory)
    If IsdbNull(rs7121!K7121_cdColorCategory) = False Then D7121.cdColorCategory = Trim$(rs7121!K7121_cdColorCategory)
    If IsdbNull(rs7121!K7121_ColorPosition) = False Then D7121.ColorPosition = Trim$(rs7121!K7121_ColorPosition)
    If IsdbNull(rs7121!K7121_CheckBase) = False Then D7121.CheckBase = Trim$(rs7121!K7121_CheckBase)
    If IsdbNull(rs7121!K7121_CheckUse) = False Then D7121.CheckUse = Trim$(rs7121!K7121_CheckUse)
    If IsdbNull(rs7121!K7121_DateInsert) = False Then D7121.DateInsert = Trim$(rs7121!K7121_DateInsert)
    If IsdbNull(rs7121!K7121_DateUpdate) = False Then D7121.DateUpdate = Trim$(rs7121!K7121_DateUpdate)
    If IsdbNull(rs7121!K7121_InchargeInsert) = False Then D7121.InchargeInsert = Trim$(rs7121!K7121_InchargeInsert)
    If IsdbNull(rs7121!K7121_InchargeUpdate) = False Then D7121.InchargeUpdate = Trim$(rs7121!K7121_InchargeUpdate)
    If IsdbNull(rs7121!K7121_Remark) = False Then D7121.Remark = Trim$(rs7121!K7121_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7121_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7121_MOVE(rs7121 As DataRow)
Try

    call D7121_CLEAR()   

    If IsdbNull(rs7121!K7121_ColorCode) = False Then D7121.ColorCode = Trim$(rs7121!K7121_ColorCode)
            If IsDBNull(rs7121!K7121_ColorName) = False Then D7121.ColorName = Trim$(rs7121!K7121_ColorName)
            If IsDBNull(rs7121!K7121_ColorNameS1) = False Then D7121.ColorNameS1 = Trim$(rs7121!K7121_ColorNameS1)
            If IsDBNull(rs7121!K7121_ColorNameS2) = False Then D7121.ColorNameS2 = Trim$(rs7121!K7121_ColorNameS2)
    If IsdbNull(rs7121!K7121_ColorNameSimple) = False Then D7121.ColorNameSimple = Trim$(rs7121!K7121_ColorNameSimple)
    If IsdbNull(rs7121!K7121_CustomerCode) = False Then D7121.CustomerCode = Trim$(rs7121!K7121_CustomerCode)
    If IsdbNull(rs7121!K7121_seColorBase) = False Then D7121.seColorBase = Trim$(rs7121!K7121_seColorBase)
    If IsdbNull(rs7121!K7121_cdColorBase) = False Then D7121.cdColorBase = Trim$(rs7121!K7121_cdColorBase)
    If IsdbNull(rs7121!K7121_seColorCategory) = False Then D7121.seColorCategory = Trim$(rs7121!K7121_seColorCategory)
    If IsdbNull(rs7121!K7121_cdColorCategory) = False Then D7121.cdColorCategory = Trim$(rs7121!K7121_cdColorCategory)
    If IsdbNull(rs7121!K7121_ColorPosition) = False Then D7121.ColorPosition = Trim$(rs7121!K7121_ColorPosition)
    If IsdbNull(rs7121!K7121_CheckBase) = False Then D7121.CheckBase = Trim$(rs7121!K7121_CheckBase)
    If IsdbNull(rs7121!K7121_CheckUse) = False Then D7121.CheckUse = Trim$(rs7121!K7121_CheckUse)
    If IsdbNull(rs7121!K7121_DateInsert) = False Then D7121.DateInsert = Trim$(rs7121!K7121_DateInsert)
    If IsdbNull(rs7121!K7121_DateUpdate) = False Then D7121.DateUpdate = Trim$(rs7121!K7121_DateUpdate)
    If IsdbNull(rs7121!K7121_InchargeInsert) = False Then D7121.InchargeInsert = Trim$(rs7121!K7121_InchargeInsert)
    If IsdbNull(rs7121!K7121_InchargeUpdate) = False Then D7121.InchargeUpdate = Trim$(rs7121!K7121_InchargeUpdate)
    If IsdbNull(rs7121!K7121_Remark) = False Then D7121.Remark = Trim$(rs7121!K7121_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7121_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7121_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7121 As T7121_AREA, COLORCODE AS String) as Boolean

K7121_MOVE = False

Try
    If READ_PFK7121(COLORCODE) = True Then
                z7121 = D7121
		K7121_MOVE = True
		else
	z7121 = nothing
     End If

     If  getColumIndex(spr,"ColorCode") > -1 then z7121.ColorCode = getDataM(spr, getColumIndex(spr,"ColorCode"), xRow)
            If getColumIndex(spr, "ColorName") > -1 Then z7121.ColorName = getDataM(spr, getColumIndex(spr, "ColorName"), xRow)
            If getColumIndex(spr, "ColorNameS1") > -1 Then z7121.ColorNameS1 = getDataM(spr, getColumIndex(spr, "ColorNameS1"), xRow)
            If getColumIndex(spr, "ColorNameS2") > -1 Then z7121.ColorNameS2 = getDataM(spr, getColumIndex(spr, "ColorNameS2"), xRow)
     If  getColumIndex(spr,"ColorNameSimple") > -1 then z7121.ColorNameSimple = getDataM(spr, getColumIndex(spr,"ColorNameSimple"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z7121.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"seColorBase") > -1 then z7121.seColorBase = getDataM(spr, getColumIndex(spr,"seColorBase"), xRow)
     If  getColumIndex(spr,"cdColorBase") > -1 then z7121.cdColorBase = getDataM(spr, getColumIndex(spr,"cdColorBase"), xRow)
     If  getColumIndex(spr,"seColorCategory") > -1 then z7121.seColorCategory = getDataM(spr, getColumIndex(spr,"seColorCategory"), xRow)
     If  getColumIndex(spr,"cdColorCategory") > -1 then z7121.cdColorCategory = getDataM(spr, getColumIndex(spr,"cdColorCategory"), xRow)
     If  getColumIndex(spr,"ColorPosition") > -1 then z7121.ColorPosition = getDataM(spr, getColumIndex(spr,"ColorPosition"), xRow)
     If  getColumIndex(spr,"CheckBase") > -1 then z7121.CheckBase = getDataM(spr, getColumIndex(spr,"CheckBase"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7121.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7121.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7121.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7121.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7121.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7121.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7121_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7121_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7121 As T7121_AREA,CheckClear as Boolean,COLORCODE AS String) as Boolean

K7121_MOVE = False

Try
    If READ_PFK7121(COLORCODE) = True Then
                z7121 = D7121
		K7121_MOVE = True
		else
	If CheckClear  = True then z7121 = nothing
     End If

     If  getColumIndex(spr,"ColorCode") > -1 then z7121.ColorCode = getDataM(spr, getColumIndex(spr,"ColorCode"), xRow)
            If getColumIndex(spr, "ColorName") > -1 Then z7121.ColorName = getDataM(spr, getColumIndex(spr, "ColorName"), xRow)
            If getColumIndex(spr, "ColorNameS1") > -1 Then z7121.ColorNameS1 = getDataM(spr, getColumIndex(spr, "ColorNameS1"), xRow)
            If getColumIndex(spr, "ColorNameS2") > -1 Then z7121.ColorNameS2 = getDataM(spr, getColumIndex(spr, "ColorNameS2"), xRow)
     If  getColumIndex(spr,"ColorNameSimple") > -1 then z7121.ColorNameSimple = getDataM(spr, getColumIndex(spr,"ColorNameSimple"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z7121.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"seColorBase") > -1 then z7121.seColorBase = getDataM(spr, getColumIndex(spr,"seColorBase"), xRow)
     If  getColumIndex(spr,"cdColorBase") > -1 then z7121.cdColorBase = getDataM(spr, getColumIndex(spr,"cdColorBase"), xRow)
     If  getColumIndex(spr,"seColorCategory") > -1 then z7121.seColorCategory = getDataM(spr, getColumIndex(spr,"seColorCategory"), xRow)
     If  getColumIndex(spr,"cdColorCategory") > -1 then z7121.cdColorCategory = getDataM(spr, getColumIndex(spr,"cdColorCategory"), xRow)
     If  getColumIndex(spr,"ColorPosition") > -1 then z7121.ColorPosition = getDataM(spr, getColumIndex(spr,"ColorPosition"), xRow)
     If  getColumIndex(spr,"CheckBase") > -1 then z7121.CheckBase = getDataM(spr, getColumIndex(spr,"CheckBase"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7121.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7121.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7121.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7121.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7121.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7121.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7121_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7121_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7121 As T7121_AREA, Job as String, COLORCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7121_MOVE = False

Try
    If READ_PFK7121(COLORCODE) = True Then
                z7121 = D7121
		K7121_MOVE = True
		else
	z7121 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7121")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "COLORCODE":z7121.ColorCode = Children(i).Code
   Case "COLORNAME":z7121.ColorName = Children(i).Code
   Case "COLORNAMESIMPLE":z7121.ColorNameSimple = Children(i).Code
   Case "CUSTOMERCODE":z7121.CustomerCode = Children(i).Code
   Case "SECOLORBASE":z7121.seColorBase = Children(i).Code
   Case "CDCOLORBASE":z7121.cdColorBase = Children(i).Code
   Case "SECOLORCATEGORY":z7121.seColorCategory = Children(i).Code
   Case "CDCOLORCATEGORY":z7121.cdColorCategory = Children(i).Code
   Case "COLORPOSITION":z7121.ColorPosition = Children(i).Code
   Case "CHECKBASE":z7121.CheckBase = Children(i).Code
   Case "CHECKUSE":z7121.CheckUse = Children(i).Code
   Case "DATEINSERT":z7121.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7121.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7121.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7121.InchargeUpdate = Children(i).Code
   Case "REMARK":z7121.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "COLORCODE":z7121.ColorCode = Children(i).Data
   Case "COLORNAME":z7121.ColorName = Children(i).Data
   Case "COLORNAMESIMPLE":z7121.ColorNameSimple = Children(i).Data
   Case "CUSTOMERCODE":z7121.CustomerCode = Children(i).Data
   Case "SECOLORBASE":z7121.seColorBase = Children(i).Data
   Case "CDCOLORBASE":z7121.cdColorBase = Children(i).Data
   Case "SECOLORCATEGORY":z7121.seColorCategory = Children(i).Data
   Case "CDCOLORCATEGORY":z7121.cdColorCategory = Children(i).Data
   Case "COLORPOSITION":z7121.ColorPosition = Children(i).Data
   Case "CHECKBASE":z7121.CheckBase = Children(i).Data
   Case "CHECKUSE":z7121.CheckUse = Children(i).Data
   Case "DATEINSERT":z7121.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7121.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7121.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7121.InchargeUpdate = Children(i).Data
   Case "REMARK":z7121.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7121_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7121_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7121 As T7121_AREA, Job as String, CheckClear as Boolean, COLORCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7121_MOVE = False

Try
    If READ_PFK7121(COLORCODE) = True Then
                z7121 = D7121
		K7121_MOVE = True
		else
	If CheckClear  = True then z7121 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7121")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "COLORCODE":z7121.ColorCode = Children(i).Code
   Case "COLORNAME":z7121.ColorName = Children(i).Code
   Case "COLORNAMESIMPLE":z7121.ColorNameSimple = Children(i).Code
   Case "CUSTOMERCODE":z7121.CustomerCode = Children(i).Code
   Case "SECOLORBASE":z7121.seColorBase = Children(i).Code
   Case "CDCOLORBASE":z7121.cdColorBase = Children(i).Code
   Case "SECOLORCATEGORY":z7121.seColorCategory = Children(i).Code
   Case "CDCOLORCATEGORY":z7121.cdColorCategory = Children(i).Code
   Case "COLORPOSITION":z7121.ColorPosition = Children(i).Code
   Case "CHECKBASE":z7121.CheckBase = Children(i).Code
   Case "CHECKUSE":z7121.CheckUse = Children(i).Code
   Case "DATEINSERT":z7121.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7121.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7121.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7121.InchargeUpdate = Children(i).Code
   Case "REMARK":z7121.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "COLORCODE":z7121.ColorCode = Children(i).Data
   Case "COLORNAME":z7121.ColorName = Children(i).Data
   Case "COLORNAMESIMPLE":z7121.ColorNameSimple = Children(i).Data
   Case "CUSTOMERCODE":z7121.CustomerCode = Children(i).Data
   Case "SECOLORBASE":z7121.seColorBase = Children(i).Data
   Case "CDCOLORBASE":z7121.cdColorBase = Children(i).Data
   Case "SECOLORCATEGORY":z7121.seColorCategory = Children(i).Data
   Case "CDCOLORCATEGORY":z7121.cdColorCategory = Children(i).Data
   Case "COLORPOSITION":z7121.ColorPosition = Children(i).Data
   Case "CHECKBASE":z7121.CheckBase = Children(i).Data
   Case "CHECKUSE":z7121.CheckUse = Children(i).Data
   Case "DATEINSERT":z7121.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7121.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7121.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7121.InchargeUpdate = Children(i).Data
   Case "REMARK":z7121.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7121_MOVE",vbCritical)
End Try
End Function 
    
End Module 
