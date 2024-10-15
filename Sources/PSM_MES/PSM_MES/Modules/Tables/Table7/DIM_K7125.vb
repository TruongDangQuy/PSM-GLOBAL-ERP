'=========================================================================================================================================================
'   TABLE : (PFK7125)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7125

Structure T7125_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	SBOMCode	 AS String	'			char(6)		*
Public 	seLargeGroupMaterial	 AS String	'			char(3)
Public 	cdLargeGroupMaterial	 AS String	'			char(3)
Public 	seSemiGroupMaterial	 AS String	'			char(3)
Public 	cdSemiGroupMaterial	 AS String	'			char(3)
Public 	seDetailGroupMaterial	 AS String	'			char(3)
Public 	cdDetailGroupMaterial	 AS String	'			char(3)
Public 	CheckUse	 AS String	'			char(1)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	Remark	 AS String	'			nvarchar(100)
'=========================================================================================================================================================
End structure

Public D7125 As T7125_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7125(SBOMCODE AS String) As Boolean
    READ_PFK7125 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7125 "
    SQL = SQL & " WHERE K7125_SBOMCode		 = '" & SBOMCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7125_CLEAR: GoTo SKIP_READ_PFK7125
                
    Call K7125_MOVE(rd)
    READ_PFK7125 = True

SKIP_READ_PFK7125:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7125",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7125(SBOMCODE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7125 "
    SQL = SQL & " WHERE K7125_SBOMCode		 = '" & SBOMCode & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7125",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7125(z7125 As T7125_AREA) As Boolean
    WRITE_PFK7125 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7125)
 
    SQL = " INSERT INTO PFK7125 "
    SQL = SQL & " ( "
    SQL = SQL & " K7125_SBOMCode," 
    SQL = SQL & " K7125_seLargeGroupMaterial," 
    SQL = SQL & " K7125_cdLargeGroupMaterial," 
    SQL = SQL & " K7125_seSemiGroupMaterial," 
    SQL = SQL & " K7125_cdSemiGroupMaterial," 
    SQL = SQL & " K7125_seDetailGroupMaterial," 
    SQL = SQL & " K7125_cdDetailGroupMaterial," 
    SQL = SQL & " K7125_CheckUse," 
    SQL = SQL & " K7125_DateInsert," 
    SQL = SQL & " K7125_DateUpdate," 
    SQL = SQL & " K7125_InchargeInsert," 
    SQL = SQL & " K7125_InchargeUpdate," 
    SQL = SQL & " K7125_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7125.SBOMCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7125.seLargeGroupMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7125.cdLargeGroupMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7125.seSemiGroupMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7125.cdSemiGroupMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7125.seDetailGroupMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7125.cdDetailGroupMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7125.CheckUse) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7125.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7125.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7125.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7125.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7125.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7125 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7125",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7125(z7125 As T7125_AREA) As Boolean
    REWRITE_PFK7125 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7125)
   
    SQL = " UPDATE PFK7125 SET "
    SQL = SQL & "    K7125_seLargeGroupMaterial      = N'" & FormatSQL(z7125.seLargeGroupMaterial) & "', " 
    SQL = SQL & "    K7125_cdLargeGroupMaterial      = N'" & FormatSQL(z7125.cdLargeGroupMaterial) & "', " 
    SQL = SQL & "    K7125_seSemiGroupMaterial      = N'" & FormatSQL(z7125.seSemiGroupMaterial) & "', " 
    SQL = SQL & "    K7125_cdSemiGroupMaterial      = N'" & FormatSQL(z7125.cdSemiGroupMaterial) & "', " 
    SQL = SQL & "    K7125_seDetailGroupMaterial      = N'" & FormatSQL(z7125.seDetailGroupMaterial) & "', " 
    SQL = SQL & "    K7125_cdDetailGroupMaterial      = N'" & FormatSQL(z7125.cdDetailGroupMaterial) & "', " 
    SQL = SQL & "    K7125_CheckUse      = N'" & FormatSQL(z7125.CheckUse) & "', " 
    SQL = SQL & "    K7125_DateInsert      = N'" & FormatSQL(z7125.DateInsert) & "', " 
    SQL = SQL & "    K7125_DateUpdate      = N'" & FormatSQL(z7125.DateUpdate) & "', " 
    SQL = SQL & "    K7125_InchargeInsert      = N'" & FormatSQL(z7125.InchargeInsert) & "', " 
    SQL = SQL & "    K7125_InchargeUpdate      = N'" & FormatSQL(z7125.InchargeUpdate) & "', " 
    SQL = SQL & "    K7125_Remark      = N'" & FormatSQL(z7125.Remark) & "'  " 
    SQL = SQL & " WHERE K7125_SBOMCode		 = '" & z7125.SBOMCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7125 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7125",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7125(z7125 As T7125_AREA) As Boolean
    DELETE_PFK7125 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7125 "
    SQL = SQL & " WHERE K7125_SBOMCode		 = '" & z7125.SBOMCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7125 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7125",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7125_CLEAR()
Try
    
   D7125.SBOMCode = ""
   D7125.seLargeGroupMaterial = ""
   D7125.cdLargeGroupMaterial = ""
   D7125.seSemiGroupMaterial = ""
   D7125.cdSemiGroupMaterial = ""
   D7125.seDetailGroupMaterial = ""
   D7125.cdDetailGroupMaterial = ""
   D7125.CheckUse = ""
   D7125.DateInsert = ""
   D7125.DateUpdate = ""
   D7125.InchargeInsert = ""
   D7125.InchargeUpdate = ""
   D7125.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7125_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7125 As T7125_AREA)
Try
    
    x7125.SBOMCode = trim$(  x7125.SBOMCode)
    x7125.seLargeGroupMaterial = trim$(  x7125.seLargeGroupMaterial)
    x7125.cdLargeGroupMaterial = trim$(  x7125.cdLargeGroupMaterial)
    x7125.seSemiGroupMaterial = trim$(  x7125.seSemiGroupMaterial)
    x7125.cdSemiGroupMaterial = trim$(  x7125.cdSemiGroupMaterial)
    x7125.seDetailGroupMaterial = trim$(  x7125.seDetailGroupMaterial)
    x7125.cdDetailGroupMaterial = trim$(  x7125.cdDetailGroupMaterial)
    x7125.CheckUse = trim$(  x7125.CheckUse)
    x7125.DateInsert = trim$(  x7125.DateInsert)
    x7125.DateUpdate = trim$(  x7125.DateUpdate)
    x7125.InchargeInsert = trim$(  x7125.InchargeInsert)
    x7125.InchargeUpdate = trim$(  x7125.InchargeUpdate)
    x7125.Remark = trim$(  x7125.Remark)
     
    If trim$( x7125.SBOMCode ) = "" Then x7125.SBOMCode = Space(1) 
    If trim$( x7125.seLargeGroupMaterial ) = "" Then x7125.seLargeGroupMaterial = Space(1) 
    If trim$( x7125.cdLargeGroupMaterial ) = "" Then x7125.cdLargeGroupMaterial = Space(1) 
    If trim$( x7125.seSemiGroupMaterial ) = "" Then x7125.seSemiGroupMaterial = Space(1) 
    If trim$( x7125.cdSemiGroupMaterial ) = "" Then x7125.cdSemiGroupMaterial = Space(1) 
    If trim$( x7125.seDetailGroupMaterial ) = "" Then x7125.seDetailGroupMaterial = Space(1) 
    If trim$( x7125.cdDetailGroupMaterial ) = "" Then x7125.cdDetailGroupMaterial = Space(1) 
    If trim$( x7125.CheckUse ) = "" Then x7125.CheckUse = Space(1) 
    If trim$( x7125.DateInsert ) = "" Then x7125.DateInsert = Space(1) 
    If trim$( x7125.DateUpdate ) = "" Then x7125.DateUpdate = Space(1) 
    If trim$( x7125.InchargeInsert ) = "" Then x7125.InchargeInsert = Space(1) 
    If trim$( x7125.InchargeUpdate ) = "" Then x7125.InchargeUpdate = Space(1) 
    If trim$( x7125.Remark ) = "" Then x7125.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7125_MOVE(rs7125 As SqlClient.SqlDataReader)
Try

    call D7125_CLEAR()   

    If IsdbNull(rs7125!K7125_SBOMCode) = False Then D7125.SBOMCode = Trim$(rs7125!K7125_SBOMCode)
    If IsdbNull(rs7125!K7125_seLargeGroupMaterial) = False Then D7125.seLargeGroupMaterial = Trim$(rs7125!K7125_seLargeGroupMaterial)
    If IsdbNull(rs7125!K7125_cdLargeGroupMaterial) = False Then D7125.cdLargeGroupMaterial = Trim$(rs7125!K7125_cdLargeGroupMaterial)
    If IsdbNull(rs7125!K7125_seSemiGroupMaterial) = False Then D7125.seSemiGroupMaterial = Trim$(rs7125!K7125_seSemiGroupMaterial)
    If IsdbNull(rs7125!K7125_cdSemiGroupMaterial) = False Then D7125.cdSemiGroupMaterial = Trim$(rs7125!K7125_cdSemiGroupMaterial)
    If IsdbNull(rs7125!K7125_seDetailGroupMaterial) = False Then D7125.seDetailGroupMaterial = Trim$(rs7125!K7125_seDetailGroupMaterial)
    If IsdbNull(rs7125!K7125_cdDetailGroupMaterial) = False Then D7125.cdDetailGroupMaterial = Trim$(rs7125!K7125_cdDetailGroupMaterial)
    If IsdbNull(rs7125!K7125_CheckUse) = False Then D7125.CheckUse = Trim$(rs7125!K7125_CheckUse)
    If IsdbNull(rs7125!K7125_DateInsert) = False Then D7125.DateInsert = Trim$(rs7125!K7125_DateInsert)
    If IsdbNull(rs7125!K7125_DateUpdate) = False Then D7125.DateUpdate = Trim$(rs7125!K7125_DateUpdate)
    If IsdbNull(rs7125!K7125_InchargeInsert) = False Then D7125.InchargeInsert = Trim$(rs7125!K7125_InchargeInsert)
    If IsdbNull(rs7125!K7125_InchargeUpdate) = False Then D7125.InchargeUpdate = Trim$(rs7125!K7125_InchargeUpdate)
    If IsdbNull(rs7125!K7125_Remark) = False Then D7125.Remark = Trim$(rs7125!K7125_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7125_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7125_MOVE(rs7125 As DataRow)
Try

    call D7125_CLEAR()   

    If IsdbNull(rs7125!K7125_SBOMCode) = False Then D7125.SBOMCode = Trim$(rs7125!K7125_SBOMCode)
    If IsdbNull(rs7125!K7125_seLargeGroupMaterial) = False Then D7125.seLargeGroupMaterial = Trim$(rs7125!K7125_seLargeGroupMaterial)
    If IsdbNull(rs7125!K7125_cdLargeGroupMaterial) = False Then D7125.cdLargeGroupMaterial = Trim$(rs7125!K7125_cdLargeGroupMaterial)
    If IsdbNull(rs7125!K7125_seSemiGroupMaterial) = False Then D7125.seSemiGroupMaterial = Trim$(rs7125!K7125_seSemiGroupMaterial)
    If IsdbNull(rs7125!K7125_cdSemiGroupMaterial) = False Then D7125.cdSemiGroupMaterial = Trim$(rs7125!K7125_cdSemiGroupMaterial)
    If IsdbNull(rs7125!K7125_seDetailGroupMaterial) = False Then D7125.seDetailGroupMaterial = Trim$(rs7125!K7125_seDetailGroupMaterial)
    If IsdbNull(rs7125!K7125_cdDetailGroupMaterial) = False Then D7125.cdDetailGroupMaterial = Trim$(rs7125!K7125_cdDetailGroupMaterial)
    If IsdbNull(rs7125!K7125_CheckUse) = False Then D7125.CheckUse = Trim$(rs7125!K7125_CheckUse)
    If IsdbNull(rs7125!K7125_DateInsert) = False Then D7125.DateInsert = Trim$(rs7125!K7125_DateInsert)
    If IsdbNull(rs7125!K7125_DateUpdate) = False Then D7125.DateUpdate = Trim$(rs7125!K7125_DateUpdate)
    If IsdbNull(rs7125!K7125_InchargeInsert) = False Then D7125.InchargeInsert = Trim$(rs7125!K7125_InchargeInsert)
    If IsdbNull(rs7125!K7125_InchargeUpdate) = False Then D7125.InchargeUpdate = Trim$(rs7125!K7125_InchargeUpdate)
    If IsdbNull(rs7125!K7125_Remark) = False Then D7125.Remark = Trim$(rs7125!K7125_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7125_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7125_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7125 As T7125_AREA, SBOMCODE AS String) as Boolean

K7125_MOVE = False

Try
    If READ_PFK7125(SBOMCODE) = True Then
                z7125 = D7125
		K7125_MOVE = True
		else
	z7125 = nothing
     End If

     If  getColumIndex(spr,"SBOMCode") > -1 then z7125.SBOMCode = getDataM(spr, getColumIndex(spr,"SBOMCode"), xRow)
     If  getColumIndex(spr,"seLargeGroupMaterial") > -1 then z7125.seLargeGroupMaterial = getDataM(spr, getColumIndex(spr,"seLargeGroupMaterial"), xRow)
     If  getColumIndex(spr,"cdLargeGroupMaterial") > -1 then z7125.cdLargeGroupMaterial = getDataM(spr, getColumIndex(spr,"cdLargeGroupMaterial"), xRow)
     If  getColumIndex(spr,"seSemiGroupMaterial") > -1 then z7125.seSemiGroupMaterial = getDataM(spr, getColumIndex(spr,"seSemiGroupMaterial"), xRow)
     If  getColumIndex(spr,"cdSemiGroupMaterial") > -1 then z7125.cdSemiGroupMaterial = getDataM(spr, getColumIndex(spr,"cdSemiGroupMaterial"), xRow)
     If  getColumIndex(spr,"seDetailGroupMaterial") > -1 then z7125.seDetailGroupMaterial = getDataM(spr, getColumIndex(spr,"seDetailGroupMaterial"), xRow)
     If  getColumIndex(spr,"cdDetailGroupMaterial") > -1 then z7125.cdDetailGroupMaterial = getDataM(spr, getColumIndex(spr,"cdDetailGroupMaterial"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7125.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7125.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7125.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7125.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7125.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7125.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7125_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7125_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7125 As T7125_AREA,CheckClear as Boolean,SBOMCODE AS String) as Boolean

K7125_MOVE = False

Try
    If READ_PFK7125(SBOMCODE) = True Then
                z7125 = D7125
		K7125_MOVE = True
		else
	If CheckClear  = True then z7125 = nothing
     End If

     If  getColumIndex(spr,"SBOMCode") > -1 then z7125.SBOMCode = getDataM(spr, getColumIndex(spr,"SBOMCode"), xRow)
     If  getColumIndex(spr,"seLargeGroupMaterial") > -1 then z7125.seLargeGroupMaterial = getDataM(spr, getColumIndex(spr,"seLargeGroupMaterial"), xRow)
     If  getColumIndex(spr,"cdLargeGroupMaterial") > -1 then z7125.cdLargeGroupMaterial = getDataM(spr, getColumIndex(spr,"cdLargeGroupMaterial"), xRow)
     If  getColumIndex(spr,"seSemiGroupMaterial") > -1 then z7125.seSemiGroupMaterial = getDataM(spr, getColumIndex(spr,"seSemiGroupMaterial"), xRow)
     If  getColumIndex(spr,"cdSemiGroupMaterial") > -1 then z7125.cdSemiGroupMaterial = getDataM(spr, getColumIndex(spr,"cdSemiGroupMaterial"), xRow)
     If  getColumIndex(spr,"seDetailGroupMaterial") > -1 then z7125.seDetailGroupMaterial = getDataM(spr, getColumIndex(spr,"seDetailGroupMaterial"), xRow)
     If  getColumIndex(spr,"cdDetailGroupMaterial") > -1 then z7125.cdDetailGroupMaterial = getDataM(spr, getColumIndex(spr,"cdDetailGroupMaterial"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7125.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7125.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7125.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7125.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7125.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7125.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7125_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7125_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7125 As T7125_AREA, Job as String, SBOMCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7125_MOVE = False

Try
    If READ_PFK7125(SBOMCODE) = True Then
                z7125 = D7125
		K7125_MOVE = True
		else
	z7125 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7125")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SBOMCODE":z7125.SBOMCode = Children(i).Code
   Case "SELARGEGROUPMATERIAL":z7125.seLargeGroupMaterial = Children(i).Code
   Case "CDLARGEGROUPMATERIAL":z7125.cdLargeGroupMaterial = Children(i).Code
   Case "SESEMIGROUPMATERIAL":z7125.seSemiGroupMaterial = Children(i).Code
   Case "CDSEMIGROUPMATERIAL":z7125.cdSemiGroupMaterial = Children(i).Code
   Case "SEDETAILGROUPMATERIAL":z7125.seDetailGroupMaterial = Children(i).Code
   Case "CDDETAILGROUPMATERIAL":z7125.cdDetailGroupMaterial = Children(i).Code
   Case "CHECKUSE":z7125.CheckUse = Children(i).Code
   Case "DATEINSERT":z7125.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7125.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7125.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7125.InchargeUpdate = Children(i).Code
   Case "REMARK":z7125.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SBOMCODE":z7125.SBOMCode = Children(i).Data
   Case "SELARGEGROUPMATERIAL":z7125.seLargeGroupMaterial = Children(i).Data
   Case "CDLARGEGROUPMATERIAL":z7125.cdLargeGroupMaterial = Children(i).Data
   Case "SESEMIGROUPMATERIAL":z7125.seSemiGroupMaterial = Children(i).Data
   Case "CDSEMIGROUPMATERIAL":z7125.cdSemiGroupMaterial = Children(i).Data
   Case "SEDETAILGROUPMATERIAL":z7125.seDetailGroupMaterial = Children(i).Data
   Case "CDDETAILGROUPMATERIAL":z7125.cdDetailGroupMaterial = Children(i).Data
   Case "CHECKUSE":z7125.CheckUse = Children(i).Data
   Case "DATEINSERT":z7125.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7125.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7125.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7125.InchargeUpdate = Children(i).Data
   Case "REMARK":z7125.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7125_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7125_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7125 As T7125_AREA, Job as String, CheckClear as Boolean, SBOMCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7125_MOVE = False

Try
    If READ_PFK7125(SBOMCODE) = True Then
                z7125 = D7125
		K7125_MOVE = True
		else
	If CheckClear  = True then z7125 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7125")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SBOMCODE":z7125.SBOMCode = Children(i).Code
   Case "SELARGEGROUPMATERIAL":z7125.seLargeGroupMaterial = Children(i).Code
   Case "CDLARGEGROUPMATERIAL":z7125.cdLargeGroupMaterial = Children(i).Code
   Case "SESEMIGROUPMATERIAL":z7125.seSemiGroupMaterial = Children(i).Code
   Case "CDSEMIGROUPMATERIAL":z7125.cdSemiGroupMaterial = Children(i).Code
   Case "SEDETAILGROUPMATERIAL":z7125.seDetailGroupMaterial = Children(i).Code
   Case "CDDETAILGROUPMATERIAL":z7125.cdDetailGroupMaterial = Children(i).Code
   Case "CHECKUSE":z7125.CheckUse = Children(i).Code
   Case "DATEINSERT":z7125.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7125.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7125.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7125.InchargeUpdate = Children(i).Code
   Case "REMARK":z7125.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SBOMCODE":z7125.SBOMCode = Children(i).Data
   Case "SELARGEGROUPMATERIAL":z7125.seLargeGroupMaterial = Children(i).Data
   Case "CDLARGEGROUPMATERIAL":z7125.cdLargeGroupMaterial = Children(i).Data
   Case "SESEMIGROUPMATERIAL":z7125.seSemiGroupMaterial = Children(i).Data
   Case "CDSEMIGROUPMATERIAL":z7125.cdSemiGroupMaterial = Children(i).Data
   Case "SEDETAILGROUPMATERIAL":z7125.seDetailGroupMaterial = Children(i).Data
   Case "CDDETAILGROUPMATERIAL":z7125.cdDetailGroupMaterial = Children(i).Data
   Case "CHECKUSE":z7125.CheckUse = Children(i).Data
   Case "DATEINSERT":z7125.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7125.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7125.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7125.InchargeUpdate = Children(i).Data
   Case "REMARK":z7125.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7125_MOVE",vbCritical)
End Try
End Function 
    
End Module 
