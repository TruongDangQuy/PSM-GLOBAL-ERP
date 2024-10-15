'=========================================================================================================================================================
'   TABLE : (PFK7271)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7271

Structure T7271_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	cdWarehouseGroup	 AS String	'			char(3)		*
Public 	cdWarehouseCode	 AS String	'			char(3)		*
Public 	WarehousePositionCode	 AS String	'			char(5)		*
Public 	WarehousePositionName	 AS String	'			nvarchar(100)
Public 	WarehousePositionNameSimply	 AS String	'			nvarchar(50)
Public 	WarehousePositionEname	 AS String	'			nvarchar(100)
Public 	GroupPosition	 AS Double	'			decimal
Public 	HorizontalPosition	 AS Double	'			decimal
Public 	VerticalPosition	 AS Double	'			decimal
Public 	UnitBase	 AS String	'			char(3)
Public 	QtyMaxBase	 AS Double	'			decimal
Public 	RollRemainder	 AS Double	'			decimal
Public 	WgtRemainder	 AS Double	'			decimal
Public 	MtsRemainder	 AS Double	'			decimal
Public 	YdsRemainder	 AS Double	'			decimal
Public 	DisplaySeq	 AS String	'			char(5)
Public 	checkUse	 AS String	'			char(4)
Public 	DevelopmentCode	 AS String	'			char(5)
Public 	Remark	 AS String	'			nvarchar(100)
'=========================================================================================================================================================
End structure

Public D7271 As T7271_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7271(CDWAREHOUSEGROUP AS String, CDWAREHOUSECODE AS String, WAREHOUSEPOSITIONCODE AS String) As Boolean
    READ_PFK7271 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7271 "
    SQL = SQL & " WHERE K7271_cdWarehouseGroup		 = '" & cdWarehouseGroup & "' " 
    SQL = SQL & "   AND K7271_cdWarehouseCode		 = '" & cdWarehouseCode & "' " 
    SQL = SQL & "   AND K7271_WarehousePositionCode		 = '" & WarehousePositionCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7271_CLEAR: GoTo SKIP_READ_PFK7271
                
    Call K7271_MOVE(rd)
    READ_PFK7271 = True

SKIP_READ_PFK7271:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7271",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7271(CDWAREHOUSEGROUP AS String, CDWAREHOUSECODE AS String, WAREHOUSEPOSITIONCODE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7271 "
    SQL = SQL & " WHERE K7271_cdWarehouseGroup		 = '" & cdWarehouseGroup & "' " 
    SQL = SQL & "   AND K7271_cdWarehouseCode		 = '" & cdWarehouseCode & "' " 
    SQL = SQL & "   AND K7271_WarehousePositionCode		 = '" & WarehousePositionCode & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7271",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7271(z7271 As T7271_AREA) As Boolean
    WRITE_PFK7271 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7271)
 
    SQL = " INSERT INTO PFK7271 "
    SQL = SQL & " ( "
    SQL = SQL & " K7271_cdWarehouseGroup," 
    SQL = SQL & " K7271_cdWarehouseCode," 
    SQL = SQL & " K7271_WarehousePositionCode," 
    SQL = SQL & " K7271_WarehousePositionName," 
    SQL = SQL & " K7271_WarehousePositionNameSimply," 
    SQL = SQL & " K7271_WarehousePositionEname," 
    SQL = SQL & " K7271_GroupPosition," 
    SQL = SQL & " K7271_HorizontalPosition," 
    SQL = SQL & " K7271_VerticalPosition," 
    SQL = SQL & " K7271_UnitBase," 
    SQL = SQL & " K7271_QtyMaxBase," 
    SQL = SQL & " K7271_RollRemainder," 
    SQL = SQL & " K7271_WgtRemainder," 
    SQL = SQL & " K7271_MtsRemainder," 
    SQL = SQL & " K7271_YdsRemainder," 
    SQL = SQL & " K7271_DisplaySeq," 
    SQL = SQL & " K7271_checkUse," 
    SQL = SQL & " K7271_DevelopmentCode," 
    SQL = SQL & " K7271_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  '" & z7271.cdWarehouseGroup & "', "  
    SQL = SQL & "  '" & z7271.cdWarehouseCode & "', "  
    SQL = SQL & "  '" & z7271.WarehousePositionCode & "', "  
    SQL = SQL & "  '" & z7271.WarehousePositionName & "', "  
    SQL = SQL & "  '" & z7271.WarehousePositionNameSimply & "', "  
    SQL = SQL & "  '" & z7271.WarehousePositionEname & "', "  
    SQL = SQL & "   " & z7271.GroupPosition & " , "  
    SQL = SQL & "   " & z7271.HorizontalPosition & " , "  
    SQL = SQL & "   " & z7271.VerticalPosition & " , "  
    SQL = SQL & "  '" & z7271.UnitBase & "', "  
    SQL = SQL & "   " & z7271.QtyMaxBase & " , "  
    SQL = SQL & "   " & z7271.RollRemainder & " , "  
    SQL = SQL & "   " & z7271.WgtRemainder & " , "  
    SQL = SQL & "   " & z7271.MtsRemainder & " , "  
    SQL = SQL & "   " & z7271.YdsRemainder & " , "  
    SQL = SQL & "  '" & z7271.DisplaySeq & "', "  
    SQL = SQL & "  '" & z7271.checkUse & "', "  
    SQL = SQL & "  '" & z7271.DevelopmentCode & "', "  
    SQL = SQL & "  '" & z7271.Remark & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7271 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7271",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7271(z7271 As T7271_AREA) As Boolean
    REWRITE_PFK7271 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7271)
   
    SQL = " UPDATE PFK7271 SET "
    SQL = SQL & "    K7271_WarehousePositionName      = '" & z7271.WarehousePositionName & "', " 
    SQL = SQL & "    K7271_WarehousePositionNameSimply      = '" & z7271.WarehousePositionNameSimply & "', " 
    SQL = SQL & "    K7271_WarehousePositionEname      = '" & z7271.WarehousePositionEname & "', " 
    SQL = SQL & "    K7271_GroupPosition      =  " & z7271.GroupPosition & " , " 
    SQL = SQL & "    K7271_HorizontalPosition      =  " & z7271.HorizontalPosition & " , " 
    SQL = SQL & "    K7271_VerticalPosition      =  " & z7271.VerticalPosition & " , " 
    SQL = SQL & "    K7271_UnitBase      = '" & z7271.UnitBase & "', " 
    SQL = SQL & "    K7271_QtyMaxBase      =  " & z7271.QtyMaxBase & " , " 
    SQL = SQL & "    K7271_RollRemainder      =  " & z7271.RollRemainder & " , " 
    SQL = SQL & "    K7271_WgtRemainder      =  " & z7271.WgtRemainder & " , " 
    SQL = SQL & "    K7271_MtsRemainder      =  " & z7271.MtsRemainder & " , " 
    SQL = SQL & "    K7271_YdsRemainder      =  " & z7271.YdsRemainder & " , " 
    SQL = SQL & "    K7271_DisplaySeq      = '" & z7271.DisplaySeq & "', " 
    SQL = SQL & "    K7271_checkUse      = '" & z7271.checkUse & "', " 
    SQL = SQL & "    K7271_DevelopmentCode      = '" & z7271.DevelopmentCode & "', " 
    SQL = SQL & "    K7271_Remark      = '" & z7271.Remark & "'  " 
    SQL = SQL & " WHERE K7271_cdWarehouseGroup		 = '" & z7271.cdWarehouseGroup & "' " 
    SQL = SQL & "   AND K7271_cdWarehouseCode		 = '" & z7271.cdWarehouseCode & "' " 
    SQL = SQL & "   AND K7271_WarehousePositionCode		 = '" & z7271.WarehousePositionCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7271 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7271",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7271(z7271 As T7271_AREA) As Boolean
    DELETE_PFK7271 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7271 "
    SQL = SQL & " WHERE K7271_cdWarehouseGroup		 = '" & z7271.cdWarehouseGroup & "' " 
    SQL = SQL & "   AND K7271_cdWarehouseCode		 = '" & z7271.cdWarehouseCode & "' " 
    SQL = SQL & "   AND K7271_WarehousePositionCode		 = '" & z7271.WarehousePositionCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7271 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7271",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7271_CLEAR()
Try
    
   D7271.cdWarehouseGroup = ""
   D7271.cdWarehouseCode = ""
   D7271.WarehousePositionCode = ""
   D7271.WarehousePositionName = ""
   D7271.WarehousePositionNameSimply = ""
   D7271.WarehousePositionEname = ""
    D7271.GroupPosition = 0 
    D7271.HorizontalPosition = 0 
    D7271.VerticalPosition = 0 
   D7271.UnitBase = ""
    D7271.QtyMaxBase = 0 
    D7271.RollRemainder = 0 
    D7271.WgtRemainder = 0 
    D7271.MtsRemainder = 0 
    D7271.YdsRemainder = 0 
   D7271.DisplaySeq = ""
   D7271.checkUse = ""
   D7271.DevelopmentCode = ""
   D7271.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7271_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7271 As T7271_AREA)
Try
    
    x7271.cdWarehouseGroup = trim$(  x7271.cdWarehouseGroup)
    x7271.cdWarehouseCode = trim$(  x7271.cdWarehouseCode)
    x7271.WarehousePositionCode = trim$(  x7271.WarehousePositionCode)
    x7271.WarehousePositionName = trim$(  x7271.WarehousePositionName)
    x7271.WarehousePositionNameSimply = trim$(  x7271.WarehousePositionNameSimply)
    x7271.WarehousePositionEname = trim$(  x7271.WarehousePositionEname)
    x7271.GroupPosition = trim$(  x7271.GroupPosition)
    x7271.HorizontalPosition = trim$(  x7271.HorizontalPosition)
    x7271.VerticalPosition = trim$(  x7271.VerticalPosition)
    x7271.UnitBase = trim$(  x7271.UnitBase)
    x7271.QtyMaxBase = trim$(  x7271.QtyMaxBase)
    x7271.RollRemainder = trim$(  x7271.RollRemainder)
    x7271.WgtRemainder = trim$(  x7271.WgtRemainder)
    x7271.MtsRemainder = trim$(  x7271.MtsRemainder)
    x7271.YdsRemainder = trim$(  x7271.YdsRemainder)
    x7271.DisplaySeq = trim$(  x7271.DisplaySeq)
    x7271.checkUse = trim$(  x7271.checkUse)
    x7271.DevelopmentCode = trim$(  x7271.DevelopmentCode)
    x7271.Remark = trim$(  x7271.Remark)
     
    If trim$( x7271.cdWarehouseGroup ) = "" Then x7271.cdWarehouseGroup = Space(1) 
    If trim$( x7271.cdWarehouseCode ) = "" Then x7271.cdWarehouseCode = Space(1) 
    If trim$( x7271.WarehousePositionCode ) = "" Then x7271.WarehousePositionCode = Space(1) 
    If trim$( x7271.WarehousePositionName ) = "" Then x7271.WarehousePositionName = Space(1) 
    If trim$( x7271.WarehousePositionNameSimply ) = "" Then x7271.WarehousePositionNameSimply = Space(1) 
    If trim$( x7271.WarehousePositionEname ) = "" Then x7271.WarehousePositionEname = Space(1) 
    If trim$( x7271.GroupPosition ) = "" Then x7271.GroupPosition = 0 
    If trim$( x7271.HorizontalPosition ) = "" Then x7271.HorizontalPosition = 0 
    If trim$( x7271.VerticalPosition ) = "" Then x7271.VerticalPosition = 0 
    If trim$( x7271.UnitBase ) = "" Then x7271.UnitBase = Space(1) 
    If trim$( x7271.QtyMaxBase ) = "" Then x7271.QtyMaxBase = 0 
    If trim$( x7271.RollRemainder ) = "" Then x7271.RollRemainder = 0 
    If trim$( x7271.WgtRemainder ) = "" Then x7271.WgtRemainder = 0 
    If trim$( x7271.MtsRemainder ) = "" Then x7271.MtsRemainder = 0 
    If trim$( x7271.YdsRemainder ) = "" Then x7271.YdsRemainder = 0 
    If trim$( x7271.DisplaySeq ) = "" Then x7271.DisplaySeq = Space(1) 
    If trim$( x7271.checkUse ) = "" Then x7271.checkUse = Space(1) 
    If trim$( x7271.DevelopmentCode ) = "" Then x7271.DevelopmentCode = Space(1) 
    If trim$( x7271.Remark ) = "" Then x7271.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7271_MOVE(rs7271 As SqlClient.SqlDataReader)
Try

    call D7271_CLEAR()   

    If IsdbNull(rs7271!K7271_cdWarehouseGroup) = False Then D7271.cdWarehouseGroup = Trim$(rs7271!K7271_cdWarehouseGroup)
    If IsdbNull(rs7271!K7271_cdWarehouseCode) = False Then D7271.cdWarehouseCode = Trim$(rs7271!K7271_cdWarehouseCode)
    If IsdbNull(rs7271!K7271_WarehousePositionCode) = False Then D7271.WarehousePositionCode = Trim$(rs7271!K7271_WarehousePositionCode)
    If IsdbNull(rs7271!K7271_WarehousePositionName) = False Then D7271.WarehousePositionName = Trim$(rs7271!K7271_WarehousePositionName)
    If IsdbNull(rs7271!K7271_WarehousePositionNameSimply) = False Then D7271.WarehousePositionNameSimply = Trim$(rs7271!K7271_WarehousePositionNameSimply)
    If IsdbNull(rs7271!K7271_WarehousePositionEname) = False Then D7271.WarehousePositionEname = Trim$(rs7271!K7271_WarehousePositionEname)
    If IsdbNull(rs7271!K7271_GroupPosition) = False Then D7271.GroupPosition = Trim$(rs7271!K7271_GroupPosition)
    If IsdbNull(rs7271!K7271_HorizontalPosition) = False Then D7271.HorizontalPosition = Trim$(rs7271!K7271_HorizontalPosition)
    If IsdbNull(rs7271!K7271_VerticalPosition) = False Then D7271.VerticalPosition = Trim$(rs7271!K7271_VerticalPosition)
    If IsdbNull(rs7271!K7271_UnitBase) = False Then D7271.UnitBase = Trim$(rs7271!K7271_UnitBase)
    If IsdbNull(rs7271!K7271_QtyMaxBase) = False Then D7271.QtyMaxBase = Trim$(rs7271!K7271_QtyMaxBase)
    If IsdbNull(rs7271!K7271_RollRemainder) = False Then D7271.RollRemainder = Trim$(rs7271!K7271_RollRemainder)
    If IsdbNull(rs7271!K7271_WgtRemainder) = False Then D7271.WgtRemainder = Trim$(rs7271!K7271_WgtRemainder)
    If IsdbNull(rs7271!K7271_MtsRemainder) = False Then D7271.MtsRemainder = Trim$(rs7271!K7271_MtsRemainder)
    If IsdbNull(rs7271!K7271_YdsRemainder) = False Then D7271.YdsRemainder = Trim$(rs7271!K7271_YdsRemainder)
    If IsdbNull(rs7271!K7271_DisplaySeq) = False Then D7271.DisplaySeq = Trim$(rs7271!K7271_DisplaySeq)
    If IsdbNull(rs7271!K7271_checkUse) = False Then D7271.checkUse = Trim$(rs7271!K7271_checkUse)
    If IsdbNull(rs7271!K7271_DevelopmentCode) = False Then D7271.DevelopmentCode = Trim$(rs7271!K7271_DevelopmentCode)
    If IsdbNull(rs7271!K7271_Remark) = False Then D7271.Remark = Trim$(rs7271!K7271_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7271_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7271_MOVE(rs7271 As DataRow)
Try

    call D7271_CLEAR()   

    If IsdbNull(rs7271!K7271_cdWarehouseGroup) = False Then D7271.cdWarehouseGroup = Trim$(rs7271!K7271_cdWarehouseGroup)
    If IsdbNull(rs7271!K7271_cdWarehouseCode) = False Then D7271.cdWarehouseCode = Trim$(rs7271!K7271_cdWarehouseCode)
    If IsdbNull(rs7271!K7271_WarehousePositionCode) = False Then D7271.WarehousePositionCode = Trim$(rs7271!K7271_WarehousePositionCode)
    If IsdbNull(rs7271!K7271_WarehousePositionName) = False Then D7271.WarehousePositionName = Trim$(rs7271!K7271_WarehousePositionName)
    If IsdbNull(rs7271!K7271_WarehousePositionNameSimply) = False Then D7271.WarehousePositionNameSimply = Trim$(rs7271!K7271_WarehousePositionNameSimply)
    If IsdbNull(rs7271!K7271_WarehousePositionEname) = False Then D7271.WarehousePositionEname = Trim$(rs7271!K7271_WarehousePositionEname)
    If IsdbNull(rs7271!K7271_GroupPosition) = False Then D7271.GroupPosition = Trim$(rs7271!K7271_GroupPosition)
    If IsdbNull(rs7271!K7271_HorizontalPosition) = False Then D7271.HorizontalPosition = Trim$(rs7271!K7271_HorizontalPosition)
    If IsdbNull(rs7271!K7271_VerticalPosition) = False Then D7271.VerticalPosition = Trim$(rs7271!K7271_VerticalPosition)
    If IsdbNull(rs7271!K7271_UnitBase) = False Then D7271.UnitBase = Trim$(rs7271!K7271_UnitBase)
    If IsdbNull(rs7271!K7271_QtyMaxBase) = False Then D7271.QtyMaxBase = Trim$(rs7271!K7271_QtyMaxBase)
    If IsdbNull(rs7271!K7271_RollRemainder) = False Then D7271.RollRemainder = Trim$(rs7271!K7271_RollRemainder)
    If IsdbNull(rs7271!K7271_WgtRemainder) = False Then D7271.WgtRemainder = Trim$(rs7271!K7271_WgtRemainder)
    If IsdbNull(rs7271!K7271_MtsRemainder) = False Then D7271.MtsRemainder = Trim$(rs7271!K7271_MtsRemainder)
    If IsdbNull(rs7271!K7271_YdsRemainder) = False Then D7271.YdsRemainder = Trim$(rs7271!K7271_YdsRemainder)
    If IsdbNull(rs7271!K7271_DisplaySeq) = False Then D7271.DisplaySeq = Trim$(rs7271!K7271_DisplaySeq)
    If IsdbNull(rs7271!K7271_checkUse) = False Then D7271.checkUse = Trim$(rs7271!K7271_checkUse)
    If IsdbNull(rs7271!K7271_DevelopmentCode) = False Then D7271.DevelopmentCode = Trim$(rs7271!K7271_DevelopmentCode)
    If IsdbNull(rs7271!K7271_Remark) = False Then D7271.Remark = Trim$(rs7271!K7271_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7271_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7271_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7271 As T7271_AREA,CDWAREHOUSEGROUP AS String, CDWAREHOUSECODE AS String, WAREHOUSEPOSITIONCODE AS String) as Boolean

K7271_MOVE = False

Try
    If READ_PFK7271(CDWAREHOUSEGROUP, CDWAREHOUSECODE, WAREHOUSEPOSITIONCODE) = True Then
                z7271 = D7271
		K7271_MOVE = True
            End If

   z7271.cdWarehouseGroup = getDataM(spr, getColumIndex(spr,"cdWarehouseGroup"), xRow)
   z7271.cdWarehouseCode = getDataM(spr, getColumIndex(spr,"cdWarehouseCode"), xRow)
   z7271.WarehousePositionCode = getDataM(spr, getColumIndex(spr,"WarehousePositionCode"), xRow)
   z7271.WarehousePositionName = getDataM(spr, getColumIndex(spr,"WarehousePositionName"), xRow)
   z7271.WarehousePositionNameSimply = getDataM(spr, getColumIndex(spr,"WarehousePositionNameSimply"), xRow)
   z7271.WarehousePositionEname = getDataM(spr, getColumIndex(spr,"WarehousePositionEname"), xRow)
   z7271.GroupPosition = getDataM(spr, getColumIndex(spr,"GroupPosition"), xRow)
   z7271.HorizontalPosition = getDataM(spr, getColumIndex(spr,"HorizontalPosition"), xRow)
   z7271.VerticalPosition = getDataM(spr, getColumIndex(spr,"VerticalPosition"), xRow)
   z7271.UnitBase = getDataM(spr, getColumIndex(spr,"UnitBase"), xRow)
   z7271.QtyMaxBase = getDataM(spr, getColumIndex(spr,"QtyMaxBase"), xRow)
   z7271.RollRemainder = getDataM(spr, getColumIndex(spr,"RollRemainder"), xRow)
   z7271.WgtRemainder = getDataM(spr, getColumIndex(spr,"WgtRemainder"), xRow)
   z7271.MtsRemainder = getDataM(spr, getColumIndex(spr,"MtsRemainder"), xRow)
   z7271.YdsRemainder = getDataM(spr, getColumIndex(spr,"YdsRemainder"), xRow)
   z7271.DisplaySeq = getDataM(spr, getColumIndex(spr,"DisplaySeq"), xRow)
   z7271.checkUse = getDataM(spr, getColumIndex(spr,"checkUse"), xRow)
   z7271.DevelopmentCode = getDataM(spr, getColumIndex(spr,"DevelopmentCode"), xRow)
   z7271.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7271_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7271_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7271 As T7271_AREA, Job as String,CDWAREHOUSEGROUP AS String, CDWAREHOUSECODE AS String, WAREHOUSEPOSITIONCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7271_MOVE = False

Try
    If READ_PFK7271(CDWAREHOUSEGROUP, CDWAREHOUSECODE, WAREHOUSEPOSITIONCODE) = True Then
                z7271 = D7271
		K7271_MOVE = True

    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7271")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "cdWarehouseGroup":z7271.cdWarehouseGroup = Children(i).Code
   Case "cdWarehouseCode":z7271.cdWarehouseCode = Children(i).Code
   Case "WarehousePositionCode":z7271.WarehousePositionCode = Children(i).Code
   Case "WarehousePositionName":z7271.WarehousePositionName = Children(i).Code
   Case "WarehousePositionNameSimply":z7271.WarehousePositionNameSimply = Children(i).Code
   Case "WarehousePositionEname":z7271.WarehousePositionEname = Children(i).Code
   Case "GroupPosition":z7271.GroupPosition = Children(i).Code
   Case "HorizontalPosition":z7271.HorizontalPosition = Children(i).Code
   Case "VerticalPosition":z7271.VerticalPosition = Children(i).Code
   Case "UnitBase":z7271.UnitBase = Children(i).Code
   Case "QtyMaxBase":z7271.QtyMaxBase = Children(i).Code
   Case "RollRemainder":z7271.RollRemainder = Children(i).Code
   Case "WgtRemainder":z7271.WgtRemainder = Children(i).Code
   Case "MtsRemainder":z7271.MtsRemainder = Children(i).Code
   Case "YdsRemainder":z7271.YdsRemainder = Children(i).Code
   Case "DisplaySeq":z7271.DisplaySeq = Children(i).Code
   Case "checkUse":z7271.checkUse = Children(i).Code
   Case "DevelopmentCode":z7271.DevelopmentCode = Children(i).Code
   Case "Remark":z7271.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "cdWarehouseGroup":z7271.cdWarehouseGroup = Children(i).Data
   Case "cdWarehouseCode":z7271.cdWarehouseCode = Children(i).Data
   Case "WarehousePositionCode":z7271.WarehousePositionCode = Children(i).Data
   Case "WarehousePositionName":z7271.WarehousePositionName = Children(i).Data
   Case "WarehousePositionNameSimply":z7271.WarehousePositionNameSimply = Children(i).Data
   Case "WarehousePositionEname":z7271.WarehousePositionEname = Children(i).Data
   Case "GroupPosition":z7271.GroupPosition = Children(i).Data
   Case "HorizontalPosition":z7271.HorizontalPosition = Children(i).Data
   Case "VerticalPosition":z7271.VerticalPosition = Children(i).Data
   Case "UnitBase":z7271.UnitBase = Children(i).Data
   Case "QtyMaxBase":z7271.QtyMaxBase = Children(i).Data
   Case "RollRemainder":z7271.RollRemainder = Children(i).Data
   Case "WgtRemainder":z7271.WgtRemainder = Children(i).Data
   Case "MtsRemainder":z7271.MtsRemainder = Children(i).Data
   Case "YdsRemainder":z7271.YdsRemainder = Children(i).Data
   Case "DisplaySeq":z7271.DisplaySeq = Children(i).Data
   Case "checkUse":z7271.checkUse = Children(i).Data
   Case "DevelopmentCode":z7271.DevelopmentCode = Children(i).Data
   Case "Remark":z7271.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7271_MOVE",vbCritical)
End Try
End Function 
    
End Module 
