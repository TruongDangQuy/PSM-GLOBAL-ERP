'=========================================================================================================================================================
'   TABLE : (PFK7309)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7309

Structure T7309_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	JobBOMCode	 AS String	'			nvarchar(6)		*
Public 	JobBOMSeq	 AS Double	'			decimal		*
Public 	ProcessBOMCode	 AS String	'			nvarchar(6)
Public 	ProcessBOMSeq	 AS Double	'			decimal
Public 	Dseq	 AS Double	'			decimal
Public 	seGroupJobProcess	 AS String	'			char(3)
Public 	cdGroupJobProcess	 AS String	'			char(3)
Public 	cdJobProcess	 AS String	'			char(3)
Public 	tpJobProcess	 AS String	'			char(6)
Public 	PositionName	 AS String	'			nvarchar(20)
Public 	Description	 AS String	'			nvarchar(100)
Public 	MaterialCode	 AS String	'			char(6)
Public 	SupplierCode	 AS String	'			char(6)
Public 	Standard1	 AS String	'			nvarchar(20)
Public 	Standard2	 AS String	'			nvarchar(20)
Public 	Standard3	 AS String	'			nvarchar(20)
Public 	Standard4	 AS String	'			nvarchar(20)
Public 	Standard5	 AS String	'			nvarchar(20)
Public 	Standard6	 AS String	'			nvarchar(20)
Public 	Standard7	 AS String	'			nvarchar(20)
Public 	Standard8	 AS String	'			nvarchar(20)
Public 	Standard9	 AS String	'			nvarchar(20)
Public 	Standard10	 AS String	'			nvarchar(20)
Public 	Remark	 AS String	'			nvarchar(100)
'=========================================================================================================================================================
End structure

Public D7309 As T7309_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7309(JOBBOMCODE AS String, JOBBOMSEQ AS Double) As Boolean
    READ_PFK7309 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7309 "
    SQL = SQL & " WHERE K7309_JobBOMCode		 = '" & JobBOMCode & "' " 
    SQL = SQL & "   AND K7309_JobBOMSeq		 =  " & JobBOMSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7309_CLEAR: GoTo SKIP_READ_PFK7309
                
    Call K7309_MOVE(rd)
    READ_PFK7309 = True

SKIP_READ_PFK7309:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7309",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7309(JOBBOMCODE AS String, JOBBOMSEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7309 "
    SQL = SQL & " WHERE K7309_JobBOMCode		 = '" & JobBOMCode & "' " 
    SQL = SQL & "   AND K7309_JobBOMSeq		 =  " & JobBOMSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7309",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7309(z7309 As T7309_AREA) As Boolean
    WRITE_PFK7309 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7309)
 
    SQL = " INSERT INTO PFK7309 "
    SQL = SQL & " ( "
    SQL = SQL & " K7309_JobBOMCode," 
    SQL = SQL & " K7309_JobBOMSeq," 
    SQL = SQL & " K7309_ProcessBOMCode," 
    SQL = SQL & " K7309_ProcessBOMSeq," 
    SQL = SQL & " K7309_Dseq," 
    SQL = SQL & " K7309_seGroupJobProcess," 
    SQL = SQL & " K7309_cdGroupJobProcess," 
    SQL = SQL & " K7309_cdJobProcess," 
    SQL = SQL & " K7309_tpJobProcess," 
    SQL = SQL & " K7309_PositionName," 
    SQL = SQL & " K7309_Description," 
    SQL = SQL & " K7309_MaterialCode," 
    SQL = SQL & " K7309_SupplierCode," 
    SQL = SQL & " K7309_Standard1," 
    SQL = SQL & " K7309_Standard2," 
    SQL = SQL & " K7309_Standard3," 
    SQL = SQL & " K7309_Standard4," 
    SQL = SQL & " K7309_Standard5," 
    SQL = SQL & " K7309_Standard6," 
    SQL = SQL & " K7309_Standard7," 
    SQL = SQL & " K7309_Standard8," 
    SQL = SQL & " K7309_Standard9," 
    SQL = SQL & " K7309_Standard10," 
    SQL = SQL & " K7309_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7309.JobBOMCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z7309.JobBOMSeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7309.ProcessBOMCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z7309.ProcessBOMSeq) & ", "  
    SQL = SQL & "   " & FormatSQL(z7309.Dseq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7309.seGroupJobProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7309.cdGroupJobProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7309.cdJobProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7309.tpJobProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7309.PositionName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7309.Description) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7309.MaterialCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7309.SupplierCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7309.Standard1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7309.Standard2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7309.Standard3) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7309.Standard4) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7309.Standard5) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7309.Standard6) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7309.Standard7) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7309.Standard8) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7309.Standard9) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7309.Standard10) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7309.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7309 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7309",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7309(z7309 As T7309_AREA) As Boolean
    REWRITE_PFK7309 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7309)
   
    SQL = " UPDATE PFK7309 SET "
    SQL = SQL & "    K7309_ProcessBOMCode      = N'" & FormatSQL(z7309.ProcessBOMCode) & "', " 
    SQL = SQL & "    K7309_ProcessBOMSeq      =  " & FormatSQL(z7309.ProcessBOMSeq) & ", " 
    SQL = SQL & "    K7309_Dseq      =  " & FormatSQL(z7309.Dseq) & ", " 
    SQL = SQL & "    K7309_seGroupJobProcess      = N'" & FormatSQL(z7309.seGroupJobProcess) & "', " 
    SQL = SQL & "    K7309_cdGroupJobProcess      = N'" & FormatSQL(z7309.cdGroupJobProcess) & "', " 
    SQL = SQL & "    K7309_cdJobProcess      = N'" & FormatSQL(z7309.cdJobProcess) & "', " 
    SQL = SQL & "    K7309_tpJobProcess      = N'" & FormatSQL(z7309.tpJobProcess) & "', " 
    SQL = SQL & "    K7309_PositionName      = N'" & FormatSQL(z7309.PositionName) & "', " 
    SQL = SQL & "    K7309_Description      = N'" & FormatSQL(z7309.Description) & "', " 
    SQL = SQL & "    K7309_MaterialCode      = N'" & FormatSQL(z7309.MaterialCode) & "', " 
    SQL = SQL & "    K7309_SupplierCode      = N'" & FormatSQL(z7309.SupplierCode) & "', " 
    SQL = SQL & "    K7309_Standard1      = N'" & FormatSQL(z7309.Standard1) & "', " 
    SQL = SQL & "    K7309_Standard2      = N'" & FormatSQL(z7309.Standard2) & "', " 
    SQL = SQL & "    K7309_Standard3      = N'" & FormatSQL(z7309.Standard3) & "', " 
    SQL = SQL & "    K7309_Standard4      = N'" & FormatSQL(z7309.Standard4) & "', " 
    SQL = SQL & "    K7309_Standard5      = N'" & FormatSQL(z7309.Standard5) & "', " 
    SQL = SQL & "    K7309_Standard6      = N'" & FormatSQL(z7309.Standard6) & "', " 
    SQL = SQL & "    K7309_Standard7      = N'" & FormatSQL(z7309.Standard7) & "', " 
    SQL = SQL & "    K7309_Standard8      = N'" & FormatSQL(z7309.Standard8) & "', " 
    SQL = SQL & "    K7309_Standard9      = N'" & FormatSQL(z7309.Standard9) & "', " 
    SQL = SQL & "    K7309_Standard10      = N'" & FormatSQL(z7309.Standard10) & "', " 
    SQL = SQL & "    K7309_Remark      = N'" & FormatSQL(z7309.Remark) & "'  " 
    SQL = SQL & " WHERE K7309_JobBOMCode		 = '" & z7309.JobBOMCode & "' " 
    SQL = SQL & "   AND K7309_JobBOMSeq		 =  " & z7309.JobBOMSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7309 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7309",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7309(z7309 As T7309_AREA) As Boolean
    DELETE_PFK7309 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7309 "
    SQL = SQL & " WHERE K7309_JobBOMCode		 = '" & z7309.JobBOMCode & "' " 
    SQL = SQL & "   AND K7309_JobBOMSeq		 =  " & z7309.JobBOMSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7309 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7309",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7309_CLEAR()
Try
    
   D7309.JobBOMCode = ""
    D7309.JobBOMSeq = 0 
   D7309.ProcessBOMCode = ""
    D7309.ProcessBOMSeq = 0 
    D7309.Dseq = 0 
   D7309.seGroupJobProcess = ""
   D7309.cdGroupJobProcess = ""
   D7309.cdJobProcess = ""
   D7309.tpJobProcess = ""
   D7309.PositionName = ""
   D7309.Description = ""
   D7309.MaterialCode = ""
   D7309.SupplierCode = ""
   D7309.Standard1 = ""
   D7309.Standard2 = ""
   D7309.Standard3 = ""
   D7309.Standard4 = ""
   D7309.Standard5 = ""
   D7309.Standard6 = ""
   D7309.Standard7 = ""
   D7309.Standard8 = ""
   D7309.Standard9 = ""
   D7309.Standard10 = ""
   D7309.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7309_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7309 As T7309_AREA)
Try
    
    x7309.JobBOMCode = trim$(  x7309.JobBOMCode)
    x7309.JobBOMSeq = trim$(  x7309.JobBOMSeq)
    x7309.ProcessBOMCode = trim$(  x7309.ProcessBOMCode)
    x7309.ProcessBOMSeq = trim$(  x7309.ProcessBOMSeq)
    x7309.Dseq = trim$(  x7309.Dseq)
    x7309.seGroupJobProcess = trim$(  x7309.seGroupJobProcess)
    x7309.cdGroupJobProcess = trim$(  x7309.cdGroupJobProcess)
    x7309.cdJobProcess = trim$(  x7309.cdJobProcess)
    x7309.tpJobProcess = trim$(  x7309.tpJobProcess)
    x7309.PositionName = trim$(  x7309.PositionName)
    x7309.Description = trim$(  x7309.Description)
    x7309.MaterialCode = trim$(  x7309.MaterialCode)
    x7309.SupplierCode = trim$(  x7309.SupplierCode)
    x7309.Standard1 = trim$(  x7309.Standard1)
    x7309.Standard2 = trim$(  x7309.Standard2)
    x7309.Standard3 = trim$(  x7309.Standard3)
    x7309.Standard4 = trim$(  x7309.Standard4)
    x7309.Standard5 = trim$(  x7309.Standard5)
    x7309.Standard6 = trim$(  x7309.Standard6)
    x7309.Standard7 = trim$(  x7309.Standard7)
    x7309.Standard8 = trim$(  x7309.Standard8)
    x7309.Standard9 = trim$(  x7309.Standard9)
    x7309.Standard10 = trim$(  x7309.Standard10)
    x7309.Remark = trim$(  x7309.Remark)
     
    If trim$( x7309.JobBOMCode ) = "" Then x7309.JobBOMCode = Space(1) 
    If trim$( x7309.JobBOMSeq ) = "" Then x7309.JobBOMSeq = 0 
    If trim$( x7309.ProcessBOMCode ) = "" Then x7309.ProcessBOMCode = Space(1) 
    If trim$( x7309.ProcessBOMSeq ) = "" Then x7309.ProcessBOMSeq = 0 
    If trim$( x7309.Dseq ) = "" Then x7309.Dseq = 0 
    If trim$( x7309.seGroupJobProcess ) = "" Then x7309.seGroupJobProcess = Space(1) 
    If trim$( x7309.cdGroupJobProcess ) = "" Then x7309.cdGroupJobProcess = Space(1) 
    If trim$( x7309.cdJobProcess ) = "" Then x7309.cdJobProcess = Space(1) 
    If trim$( x7309.tpJobProcess ) = "" Then x7309.tpJobProcess = Space(1) 
    If trim$( x7309.PositionName ) = "" Then x7309.PositionName = Space(1) 
    If trim$( x7309.Description ) = "" Then x7309.Description = Space(1) 
    If trim$( x7309.MaterialCode ) = "" Then x7309.MaterialCode = Space(1) 
    If trim$( x7309.SupplierCode ) = "" Then x7309.SupplierCode = Space(1) 
    If trim$( x7309.Standard1 ) = "" Then x7309.Standard1 = Space(1) 
    If trim$( x7309.Standard2 ) = "" Then x7309.Standard2 = Space(1) 
    If trim$( x7309.Standard3 ) = "" Then x7309.Standard3 = Space(1) 
    If trim$( x7309.Standard4 ) = "" Then x7309.Standard4 = Space(1) 
    If trim$( x7309.Standard5 ) = "" Then x7309.Standard5 = Space(1) 
    If trim$( x7309.Standard6 ) = "" Then x7309.Standard6 = Space(1) 
    If trim$( x7309.Standard7 ) = "" Then x7309.Standard7 = Space(1) 
    If trim$( x7309.Standard8 ) = "" Then x7309.Standard8 = Space(1) 
    If trim$( x7309.Standard9 ) = "" Then x7309.Standard9 = Space(1) 
    If trim$( x7309.Standard10 ) = "" Then x7309.Standard10 = Space(1) 
    If trim$( x7309.Remark ) = "" Then x7309.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7309_MOVE(rs7309 As SqlClient.SqlDataReader)
Try

    call D7309_CLEAR()   

    If IsdbNull(rs7309!K7309_JobBOMCode) = False Then D7309.JobBOMCode = Trim$(rs7309!K7309_JobBOMCode)
    If IsdbNull(rs7309!K7309_JobBOMSeq) = False Then D7309.JobBOMSeq = Trim$(rs7309!K7309_JobBOMSeq)
    If IsdbNull(rs7309!K7309_ProcessBOMCode) = False Then D7309.ProcessBOMCode = Trim$(rs7309!K7309_ProcessBOMCode)
    If IsdbNull(rs7309!K7309_ProcessBOMSeq) = False Then D7309.ProcessBOMSeq = Trim$(rs7309!K7309_ProcessBOMSeq)
    If IsdbNull(rs7309!K7309_Dseq) = False Then D7309.Dseq = Trim$(rs7309!K7309_Dseq)
    If IsdbNull(rs7309!K7309_seGroupJobProcess) = False Then D7309.seGroupJobProcess = Trim$(rs7309!K7309_seGroupJobProcess)
    If IsdbNull(rs7309!K7309_cdGroupJobProcess) = False Then D7309.cdGroupJobProcess = Trim$(rs7309!K7309_cdGroupJobProcess)
    If IsdbNull(rs7309!K7309_cdJobProcess) = False Then D7309.cdJobProcess = Trim$(rs7309!K7309_cdJobProcess)
    If IsdbNull(rs7309!K7309_tpJobProcess) = False Then D7309.tpJobProcess = Trim$(rs7309!K7309_tpJobProcess)
    If IsdbNull(rs7309!K7309_PositionName) = False Then D7309.PositionName = Trim$(rs7309!K7309_PositionName)
    If IsdbNull(rs7309!K7309_Description) = False Then D7309.Description = Trim$(rs7309!K7309_Description)
    If IsdbNull(rs7309!K7309_MaterialCode) = False Then D7309.MaterialCode = Trim$(rs7309!K7309_MaterialCode)
    If IsdbNull(rs7309!K7309_SupplierCode) = False Then D7309.SupplierCode = Trim$(rs7309!K7309_SupplierCode)
    If IsdbNull(rs7309!K7309_Standard1) = False Then D7309.Standard1 = Trim$(rs7309!K7309_Standard1)
    If IsdbNull(rs7309!K7309_Standard2) = False Then D7309.Standard2 = Trim$(rs7309!K7309_Standard2)
    If IsdbNull(rs7309!K7309_Standard3) = False Then D7309.Standard3 = Trim$(rs7309!K7309_Standard3)
    If IsdbNull(rs7309!K7309_Standard4) = False Then D7309.Standard4 = Trim$(rs7309!K7309_Standard4)
    If IsdbNull(rs7309!K7309_Standard5) = False Then D7309.Standard5 = Trim$(rs7309!K7309_Standard5)
    If IsdbNull(rs7309!K7309_Standard6) = False Then D7309.Standard6 = Trim$(rs7309!K7309_Standard6)
    If IsdbNull(rs7309!K7309_Standard7) = False Then D7309.Standard7 = Trim$(rs7309!K7309_Standard7)
    If IsdbNull(rs7309!K7309_Standard8) = False Then D7309.Standard8 = Trim$(rs7309!K7309_Standard8)
    If IsdbNull(rs7309!K7309_Standard9) = False Then D7309.Standard9 = Trim$(rs7309!K7309_Standard9)
    If IsdbNull(rs7309!K7309_Standard10) = False Then D7309.Standard10 = Trim$(rs7309!K7309_Standard10)
    If IsdbNull(rs7309!K7309_Remark) = False Then D7309.Remark = Trim$(rs7309!K7309_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7309_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7309_MOVE(rs7309 As DataRow)
Try

    call D7309_CLEAR()   

    If IsdbNull(rs7309!K7309_JobBOMCode) = False Then D7309.JobBOMCode = Trim$(rs7309!K7309_JobBOMCode)
    If IsdbNull(rs7309!K7309_JobBOMSeq) = False Then D7309.JobBOMSeq = Trim$(rs7309!K7309_JobBOMSeq)
    If IsdbNull(rs7309!K7309_ProcessBOMCode) = False Then D7309.ProcessBOMCode = Trim$(rs7309!K7309_ProcessBOMCode)
    If IsdbNull(rs7309!K7309_ProcessBOMSeq) = False Then D7309.ProcessBOMSeq = Trim$(rs7309!K7309_ProcessBOMSeq)
    If IsdbNull(rs7309!K7309_Dseq) = False Then D7309.Dseq = Trim$(rs7309!K7309_Dseq)
    If IsdbNull(rs7309!K7309_seGroupJobProcess) = False Then D7309.seGroupJobProcess = Trim$(rs7309!K7309_seGroupJobProcess)
    If IsdbNull(rs7309!K7309_cdGroupJobProcess) = False Then D7309.cdGroupJobProcess = Trim$(rs7309!K7309_cdGroupJobProcess)
    If IsdbNull(rs7309!K7309_cdJobProcess) = False Then D7309.cdJobProcess = Trim$(rs7309!K7309_cdJobProcess)
    If IsdbNull(rs7309!K7309_tpJobProcess) = False Then D7309.tpJobProcess = Trim$(rs7309!K7309_tpJobProcess)
    If IsdbNull(rs7309!K7309_PositionName) = False Then D7309.PositionName = Trim$(rs7309!K7309_PositionName)
    If IsdbNull(rs7309!K7309_Description) = False Then D7309.Description = Trim$(rs7309!K7309_Description)
    If IsdbNull(rs7309!K7309_MaterialCode) = False Then D7309.MaterialCode = Trim$(rs7309!K7309_MaterialCode)
    If IsdbNull(rs7309!K7309_SupplierCode) = False Then D7309.SupplierCode = Trim$(rs7309!K7309_SupplierCode)
    If IsdbNull(rs7309!K7309_Standard1) = False Then D7309.Standard1 = Trim$(rs7309!K7309_Standard1)
    If IsdbNull(rs7309!K7309_Standard2) = False Then D7309.Standard2 = Trim$(rs7309!K7309_Standard2)
    If IsdbNull(rs7309!K7309_Standard3) = False Then D7309.Standard3 = Trim$(rs7309!K7309_Standard3)
    If IsdbNull(rs7309!K7309_Standard4) = False Then D7309.Standard4 = Trim$(rs7309!K7309_Standard4)
    If IsdbNull(rs7309!K7309_Standard5) = False Then D7309.Standard5 = Trim$(rs7309!K7309_Standard5)
    If IsdbNull(rs7309!K7309_Standard6) = False Then D7309.Standard6 = Trim$(rs7309!K7309_Standard6)
    If IsdbNull(rs7309!K7309_Standard7) = False Then D7309.Standard7 = Trim$(rs7309!K7309_Standard7)
    If IsdbNull(rs7309!K7309_Standard8) = False Then D7309.Standard8 = Trim$(rs7309!K7309_Standard8)
    If IsdbNull(rs7309!K7309_Standard9) = False Then D7309.Standard9 = Trim$(rs7309!K7309_Standard9)
    If IsdbNull(rs7309!K7309_Standard10) = False Then D7309.Standard10 = Trim$(rs7309!K7309_Standard10)
    If IsdbNull(rs7309!K7309_Remark) = False Then D7309.Remark = Trim$(rs7309!K7309_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7309_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7309_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7309 As T7309_AREA, JOBBOMCODE AS String, JOBBOMSEQ AS Double) as Boolean

K7309_MOVE = False

Try
    If READ_PFK7309(JOBBOMCODE, JOBBOMSEQ) = True Then
                z7309 = D7309
		K7309_MOVE = True
		else
	z7309 = nothing
     End If

     If  getColumIndex(spr,"JobBOMCode") > -1 then z7309.JobBOMCode = getDataM(spr, getColumIndex(spr,"JobBOMCode"), xRow)
     If  getColumIndex(spr,"JobBOMSeq") > -1 then z7309.JobBOMSeq = getDataM(spr, getColumIndex(spr,"JobBOMSeq"), xRow)
     If  getColumIndex(spr,"ProcessBOMCode") > -1 then z7309.ProcessBOMCode = getDataM(spr, getColumIndex(spr,"ProcessBOMCode"), xRow)
     If  getColumIndex(spr,"ProcessBOMSeq") > -1 then z7309.ProcessBOMSeq = getDataM(spr, getColumIndex(spr,"ProcessBOMSeq"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z7309.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"seGroupJobProcess") > -1 then z7309.seGroupJobProcess = getDataM(spr, getColumIndex(spr,"seGroupJobProcess"), xRow)
     If  getColumIndex(spr,"cdGroupJobProcess") > -1 then z7309.cdGroupJobProcess = getDataM(spr, getColumIndex(spr,"cdGroupJobProcess"), xRow)
     If  getColumIndex(spr,"cdJobProcess") > -1 then z7309.cdJobProcess = getDataM(spr, getColumIndex(spr,"cdJobProcess"), xRow)
     If  getColumIndex(spr,"tpJobProcess") > -1 then z7309.tpJobProcess = getDataM(spr, getColumIndex(spr,"tpJobProcess"), xRow)
     If  getColumIndex(spr,"PositionName") > -1 then z7309.PositionName = getDataM(spr, getColumIndex(spr,"PositionName"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z7309.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z7309.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z7309.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"Standard1") > -1 then z7309.Standard1 = getDataM(spr, getColumIndex(spr,"Standard1"), xRow)
     If  getColumIndex(spr,"Standard2") > -1 then z7309.Standard2 = getDataM(spr, getColumIndex(spr,"Standard2"), xRow)
     If  getColumIndex(spr,"Standard3") > -1 then z7309.Standard3 = getDataM(spr, getColumIndex(spr,"Standard3"), xRow)
     If  getColumIndex(spr,"Standard4") > -1 then z7309.Standard4 = getDataM(spr, getColumIndex(spr,"Standard4"), xRow)
     If  getColumIndex(spr,"Standard5") > -1 then z7309.Standard5 = getDataM(spr, getColumIndex(spr,"Standard5"), xRow)
     If  getColumIndex(spr,"Standard6") > -1 then z7309.Standard6 = getDataM(spr, getColumIndex(spr,"Standard6"), xRow)
     If  getColumIndex(spr,"Standard7") > -1 then z7309.Standard7 = getDataM(spr, getColumIndex(spr,"Standard7"), xRow)
     If  getColumIndex(spr,"Standard8") > -1 then z7309.Standard8 = getDataM(spr, getColumIndex(spr,"Standard8"), xRow)
     If  getColumIndex(spr,"Standard9") > -1 then z7309.Standard9 = getDataM(spr, getColumIndex(spr,"Standard9"), xRow)
     If  getColumIndex(spr,"Standard10") > -1 then z7309.Standard10 = getDataM(spr, getColumIndex(spr,"Standard10"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7309.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7309_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7309_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7309 As T7309_AREA,CheckClear as Boolean,JOBBOMCODE AS String, JOBBOMSEQ AS Double) as Boolean

K7309_MOVE = False

Try
    If READ_PFK7309(JOBBOMCODE, JOBBOMSEQ) = True Then
                z7309 = D7309
		K7309_MOVE = True
		else
	If CheckClear  = True then z7309 = nothing
     End If

     If  getColumIndex(spr,"JobBOMCode") > -1 then z7309.JobBOMCode = getDataM(spr, getColumIndex(spr,"JobBOMCode"), xRow)
     If  getColumIndex(spr,"JobBOMSeq") > -1 then z7309.JobBOMSeq = getDataM(spr, getColumIndex(spr,"JobBOMSeq"), xRow)
     If  getColumIndex(spr,"ProcessBOMCode") > -1 then z7309.ProcessBOMCode = getDataM(spr, getColumIndex(spr,"ProcessBOMCode"), xRow)
     If  getColumIndex(spr,"ProcessBOMSeq") > -1 then z7309.ProcessBOMSeq = getDataM(spr, getColumIndex(spr,"ProcessBOMSeq"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z7309.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"seGroupJobProcess") > -1 then z7309.seGroupJobProcess = getDataM(spr, getColumIndex(spr,"seGroupJobProcess"), xRow)
     If  getColumIndex(spr,"cdGroupJobProcess") > -1 then z7309.cdGroupJobProcess = getDataM(spr, getColumIndex(spr,"cdGroupJobProcess"), xRow)
     If  getColumIndex(spr,"cdJobProcess") > -1 then z7309.cdJobProcess = getDataM(spr, getColumIndex(spr,"cdJobProcess"), xRow)
     If  getColumIndex(spr,"tpJobProcess") > -1 then z7309.tpJobProcess = getDataM(spr, getColumIndex(spr,"tpJobProcess"), xRow)
     If  getColumIndex(spr,"PositionName") > -1 then z7309.PositionName = getDataM(spr, getColumIndex(spr,"PositionName"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z7309.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z7309.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z7309.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"Standard1") > -1 then z7309.Standard1 = getDataM(spr, getColumIndex(spr,"Standard1"), xRow)
     If  getColumIndex(spr,"Standard2") > -1 then z7309.Standard2 = getDataM(spr, getColumIndex(spr,"Standard2"), xRow)
     If  getColumIndex(spr,"Standard3") > -1 then z7309.Standard3 = getDataM(spr, getColumIndex(spr,"Standard3"), xRow)
     If  getColumIndex(spr,"Standard4") > -1 then z7309.Standard4 = getDataM(spr, getColumIndex(spr,"Standard4"), xRow)
     If  getColumIndex(spr,"Standard5") > -1 then z7309.Standard5 = getDataM(spr, getColumIndex(spr,"Standard5"), xRow)
     If  getColumIndex(spr,"Standard6") > -1 then z7309.Standard6 = getDataM(spr, getColumIndex(spr,"Standard6"), xRow)
     If  getColumIndex(spr,"Standard7") > -1 then z7309.Standard7 = getDataM(spr, getColumIndex(spr,"Standard7"), xRow)
     If  getColumIndex(spr,"Standard8") > -1 then z7309.Standard8 = getDataM(spr, getColumIndex(spr,"Standard8"), xRow)
     If  getColumIndex(spr,"Standard9") > -1 then z7309.Standard9 = getDataM(spr, getColumIndex(spr,"Standard9"), xRow)
     If  getColumIndex(spr,"Standard10") > -1 then z7309.Standard10 = getDataM(spr, getColumIndex(spr,"Standard10"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7309.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7309_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7309_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7309 As T7309_AREA, Job as String, JOBBOMCODE AS String, JOBBOMSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7309_MOVE = False

Try
    If READ_PFK7309(JOBBOMCODE, JOBBOMSEQ) = True Then
                z7309 = D7309
		K7309_MOVE = True
		else
	z7309 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7309")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "JOBBOMCODE":z7309.JobBOMCode = Children(i).Code
   Case "JOBBOMSEQ":z7309.JobBOMSeq = Children(i).Code
   Case "PROCESSBOMCODE":z7309.ProcessBOMCode = Children(i).Code
   Case "PROCESSBOMSEQ":z7309.ProcessBOMSeq = Children(i).Code
   Case "DSEQ":z7309.Dseq = Children(i).Code
   Case "SEGROUPJOBPROCESS":z7309.seGroupJobProcess = Children(i).Code
   Case "CDGROUPJOBPROCESS":z7309.cdGroupJobProcess = Children(i).Code
   Case "CDJOBPROCESS":z7309.cdJobProcess = Children(i).Code
   Case "TPJOBPROCESS":z7309.tpJobProcess = Children(i).Code
   Case "POSITIONNAME":z7309.PositionName = Children(i).Code
   Case "DESCRIPTION":z7309.Description = Children(i).Code
   Case "MATERIALCODE":z7309.MaterialCode = Children(i).Code
   Case "SUPPLIERCODE":z7309.SupplierCode = Children(i).Code
   Case "STANDARD1":z7309.Standard1 = Children(i).Code
   Case "STANDARD2":z7309.Standard2 = Children(i).Code
   Case "STANDARD3":z7309.Standard3 = Children(i).Code
   Case "STANDARD4":z7309.Standard4 = Children(i).Code
   Case "STANDARD5":z7309.Standard5 = Children(i).Code
   Case "STANDARD6":z7309.Standard6 = Children(i).Code
   Case "STANDARD7":z7309.Standard7 = Children(i).Code
   Case "STANDARD8":z7309.Standard8 = Children(i).Code
   Case "STANDARD9":z7309.Standard9 = Children(i).Code
   Case "STANDARD10":z7309.Standard10 = Children(i).Code
   Case "REMARK":z7309.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "JOBBOMCODE":z7309.JobBOMCode = Children(i).Data
   Case "JOBBOMSEQ":z7309.JobBOMSeq = Children(i).Data
   Case "PROCESSBOMCODE":z7309.ProcessBOMCode = Children(i).Data
   Case "PROCESSBOMSEQ":z7309.ProcessBOMSeq = Children(i).Data
   Case "DSEQ":z7309.Dseq = Children(i).Data
   Case "SEGROUPJOBPROCESS":z7309.seGroupJobProcess = Children(i).Data
   Case "CDGROUPJOBPROCESS":z7309.cdGroupJobProcess = Children(i).Data
   Case "CDJOBPROCESS":z7309.cdJobProcess = Children(i).Data
   Case "TPJOBPROCESS":z7309.tpJobProcess = Children(i).Data
   Case "POSITIONNAME":z7309.PositionName = Children(i).Data
   Case "DESCRIPTION":z7309.Description = Children(i).Data
   Case "MATERIALCODE":z7309.MaterialCode = Children(i).Data
   Case "SUPPLIERCODE":z7309.SupplierCode = Children(i).Data
   Case "STANDARD1":z7309.Standard1 = Children(i).Data
   Case "STANDARD2":z7309.Standard2 = Children(i).Data
   Case "STANDARD3":z7309.Standard3 = Children(i).Data
   Case "STANDARD4":z7309.Standard4 = Children(i).Data
   Case "STANDARD5":z7309.Standard5 = Children(i).Data
   Case "STANDARD6":z7309.Standard6 = Children(i).Data
   Case "STANDARD7":z7309.Standard7 = Children(i).Data
   Case "STANDARD8":z7309.Standard8 = Children(i).Data
   Case "STANDARD9":z7309.Standard9 = Children(i).Data
   Case "STANDARD10":z7309.Standard10 = Children(i).Data
   Case "REMARK":z7309.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7309_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7309_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7309 As T7309_AREA, Job as String, CheckClear as Boolean, JOBBOMCODE AS String, JOBBOMSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7309_MOVE = False

Try
    If READ_PFK7309(JOBBOMCODE, JOBBOMSEQ) = True Then
                z7309 = D7309
		K7309_MOVE = True
		else
	If CheckClear  = True then z7309 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7309")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "JOBBOMCODE":z7309.JobBOMCode = Children(i).Code
   Case "JOBBOMSEQ":z7309.JobBOMSeq = Children(i).Code
   Case "PROCESSBOMCODE":z7309.ProcessBOMCode = Children(i).Code
   Case "PROCESSBOMSEQ":z7309.ProcessBOMSeq = Children(i).Code
   Case "DSEQ":z7309.Dseq = Children(i).Code
   Case "SEGROUPJOBPROCESS":z7309.seGroupJobProcess = Children(i).Code
   Case "CDGROUPJOBPROCESS":z7309.cdGroupJobProcess = Children(i).Code
   Case "CDJOBPROCESS":z7309.cdJobProcess = Children(i).Code
   Case "TPJOBPROCESS":z7309.tpJobProcess = Children(i).Code
   Case "POSITIONNAME":z7309.PositionName = Children(i).Code
   Case "DESCRIPTION":z7309.Description = Children(i).Code
   Case "MATERIALCODE":z7309.MaterialCode = Children(i).Code
   Case "SUPPLIERCODE":z7309.SupplierCode = Children(i).Code
   Case "STANDARD1":z7309.Standard1 = Children(i).Code
   Case "STANDARD2":z7309.Standard2 = Children(i).Code
   Case "STANDARD3":z7309.Standard3 = Children(i).Code
   Case "STANDARD4":z7309.Standard4 = Children(i).Code
   Case "STANDARD5":z7309.Standard5 = Children(i).Code
   Case "STANDARD6":z7309.Standard6 = Children(i).Code
   Case "STANDARD7":z7309.Standard7 = Children(i).Code
   Case "STANDARD8":z7309.Standard8 = Children(i).Code
   Case "STANDARD9":z7309.Standard9 = Children(i).Code
   Case "STANDARD10":z7309.Standard10 = Children(i).Code
   Case "REMARK":z7309.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "JOBBOMCODE":z7309.JobBOMCode = Children(i).Data
   Case "JOBBOMSEQ":z7309.JobBOMSeq = Children(i).Data
   Case "PROCESSBOMCODE":z7309.ProcessBOMCode = Children(i).Data
   Case "PROCESSBOMSEQ":z7309.ProcessBOMSeq = Children(i).Data
   Case "DSEQ":z7309.Dseq = Children(i).Data
   Case "SEGROUPJOBPROCESS":z7309.seGroupJobProcess = Children(i).Data
   Case "CDGROUPJOBPROCESS":z7309.cdGroupJobProcess = Children(i).Data
   Case "CDJOBPROCESS":z7309.cdJobProcess = Children(i).Data
   Case "TPJOBPROCESS":z7309.tpJobProcess = Children(i).Data
   Case "POSITIONNAME":z7309.PositionName = Children(i).Data
   Case "DESCRIPTION":z7309.Description = Children(i).Data
   Case "MATERIALCODE":z7309.MaterialCode = Children(i).Data
   Case "SUPPLIERCODE":z7309.SupplierCode = Children(i).Data
   Case "STANDARD1":z7309.Standard1 = Children(i).Data
   Case "STANDARD2":z7309.Standard2 = Children(i).Data
   Case "STANDARD3":z7309.Standard3 = Children(i).Data
   Case "STANDARD4":z7309.Standard4 = Children(i).Data
   Case "STANDARD5":z7309.Standard5 = Children(i).Data
   Case "STANDARD6":z7309.Standard6 = Children(i).Data
   Case "STANDARD7":z7309.Standard7 = Children(i).Data
   Case "STANDARD8":z7309.Standard8 = Children(i).Data
   Case "STANDARD9":z7309.Standard9 = Children(i).Data
   Case "STANDARD10":z7309.Standard10 = Children(i).Data
   Case "REMARK":z7309.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7309_MOVE",vbCritical)
End Try
End Function 
    
End Module 
