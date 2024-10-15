'=========================================================================================================================================================
'   TABLE : (PFK7312)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7312

Structure T7312_AREA
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

Public D7312 As T7312_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7312(JOBBOMCODE AS String, JOBBOMSEQ AS Double) As Boolean
    READ_PFK7312 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7312 "
    SQL = SQL & " WHERE K7312_JobBOMCode		 = '" & JobBOMCode & "' " 
    SQL = SQL & "   AND K7312_JobBOMSeq		 =  " & JobBOMSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7312_CLEAR: GoTo SKIP_READ_PFK7312
                
    Call K7312_MOVE(rd)
    READ_PFK7312 = True

SKIP_READ_PFK7312:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7312",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7312(JOBBOMCODE AS String, JOBBOMSEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7312 "
    SQL = SQL & " WHERE K7312_JobBOMCode		 = '" & JobBOMCode & "' " 
    SQL = SQL & "   AND K7312_JobBOMSeq		 =  " & JobBOMSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7312",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7312(z7312 As T7312_AREA) As Boolean
    WRITE_PFK7312 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7312)
 
    SQL = " INSERT INTO PFK7312 "
    SQL = SQL & " ( "
    SQL = SQL & " K7312_JobBOMCode," 
    SQL = SQL & " K7312_JobBOMSeq," 
    SQL = SQL & " K7312_ProcessBOMCode," 
    SQL = SQL & " K7312_ProcessBOMSeq," 
    SQL = SQL & " K7312_Dseq," 
    SQL = SQL & " K7312_seGroupJobProcess," 
    SQL = SQL & " K7312_cdGroupJobProcess," 
    SQL = SQL & " K7312_cdJobProcess," 
    SQL = SQL & " K7312_tpJobProcess," 
    SQL = SQL & " K7312_PositionName," 
    SQL = SQL & " K7312_Description," 
    SQL = SQL & " K7312_MaterialCode," 
    SQL = SQL & " K7312_SupplierCode," 
    SQL = SQL & " K7312_Standard1," 
    SQL = SQL & " K7312_Standard2," 
    SQL = SQL & " K7312_Standard3," 
    SQL = SQL & " K7312_Standard4," 
    SQL = SQL & " K7312_Standard5," 
    SQL = SQL & " K7312_Standard6," 
    SQL = SQL & " K7312_Standard7," 
    SQL = SQL & " K7312_Standard8," 
    SQL = SQL & " K7312_Standard9," 
    SQL = SQL & " K7312_Standard10," 
    SQL = SQL & " K7312_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7312.JobBOMCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z7312.JobBOMSeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7312.ProcessBOMCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z7312.ProcessBOMSeq) & ", "  
    SQL = SQL & "   " & FormatSQL(z7312.Dseq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7312.seGroupJobProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7312.cdGroupJobProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7312.cdJobProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7312.tpJobProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7312.PositionName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7312.Description) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7312.MaterialCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7312.SupplierCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7312.Standard1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7312.Standard2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7312.Standard3) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7312.Standard4) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7312.Standard5) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7312.Standard6) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7312.Standard7) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7312.Standard8) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7312.Standard9) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7312.Standard10) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7312.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7312 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7312",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7312(z7312 As T7312_AREA) As Boolean
    REWRITE_PFK7312 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7312)
   
    SQL = " UPDATE PFK7312 SET "
    SQL = SQL & "    K7312_ProcessBOMCode      = N'" & FormatSQL(z7312.ProcessBOMCode) & "', " 
    SQL = SQL & "    K7312_ProcessBOMSeq      =  " & FormatSQL(z7312.ProcessBOMSeq) & ", " 
    SQL = SQL & "    K7312_Dseq      =  " & FormatSQL(z7312.Dseq) & ", " 
    SQL = SQL & "    K7312_seGroupJobProcess      = N'" & FormatSQL(z7312.seGroupJobProcess) & "', " 
    SQL = SQL & "    K7312_cdGroupJobProcess      = N'" & FormatSQL(z7312.cdGroupJobProcess) & "', " 
    SQL = SQL & "    K7312_cdJobProcess      = N'" & FormatSQL(z7312.cdJobProcess) & "', " 
    SQL = SQL & "    K7312_tpJobProcess      = N'" & FormatSQL(z7312.tpJobProcess) & "', " 
    SQL = SQL & "    K7312_PositionName      = N'" & FormatSQL(z7312.PositionName) & "', " 
    SQL = SQL & "    K7312_Description      = N'" & FormatSQL(z7312.Description) & "', " 
    SQL = SQL & "    K7312_MaterialCode      = N'" & FormatSQL(z7312.MaterialCode) & "', " 
    SQL = SQL & "    K7312_SupplierCode      = N'" & FormatSQL(z7312.SupplierCode) & "', " 
    SQL = SQL & "    K7312_Standard1      = N'" & FormatSQL(z7312.Standard1) & "', " 
    SQL = SQL & "    K7312_Standard2      = N'" & FormatSQL(z7312.Standard2) & "', " 
    SQL = SQL & "    K7312_Standard3      = N'" & FormatSQL(z7312.Standard3) & "', " 
    SQL = SQL & "    K7312_Standard4      = N'" & FormatSQL(z7312.Standard4) & "', " 
    SQL = SQL & "    K7312_Standard5      = N'" & FormatSQL(z7312.Standard5) & "', " 
    SQL = SQL & "    K7312_Standard6      = N'" & FormatSQL(z7312.Standard6) & "', " 
    SQL = SQL & "    K7312_Standard7      = N'" & FormatSQL(z7312.Standard7) & "', " 
    SQL = SQL & "    K7312_Standard8      = N'" & FormatSQL(z7312.Standard8) & "', " 
    SQL = SQL & "    K7312_Standard9      = N'" & FormatSQL(z7312.Standard9) & "', " 
    SQL = SQL & "    K7312_Standard10      = N'" & FormatSQL(z7312.Standard10) & "', " 
    SQL = SQL & "    K7312_Remark      = N'" & FormatSQL(z7312.Remark) & "'  " 
    SQL = SQL & " WHERE K7312_JobBOMCode		 = '" & z7312.JobBOMCode & "' " 
    SQL = SQL & "   AND K7312_JobBOMSeq		 =  " & z7312.JobBOMSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7312 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7312",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7312(z7312 As T7312_AREA) As Boolean
    DELETE_PFK7312 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7312 "
    SQL = SQL & " WHERE K7312_JobBOMCode		 = '" & z7312.JobBOMCode & "' " 
    SQL = SQL & "   AND K7312_JobBOMSeq		 =  " & z7312.JobBOMSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7312 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7312",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7312_CLEAR()
Try
    
   D7312.JobBOMCode = ""
    D7312.JobBOMSeq = 0 
   D7312.ProcessBOMCode = ""
    D7312.ProcessBOMSeq = 0 
    D7312.Dseq = 0 
   D7312.seGroupJobProcess = ""
   D7312.cdGroupJobProcess = ""
   D7312.cdJobProcess = ""
   D7312.tpJobProcess = ""
   D7312.PositionName = ""
   D7312.Description = ""
   D7312.MaterialCode = ""
   D7312.SupplierCode = ""
   D7312.Standard1 = ""
   D7312.Standard2 = ""
   D7312.Standard3 = ""
   D7312.Standard4 = ""
   D7312.Standard5 = ""
   D7312.Standard6 = ""
   D7312.Standard7 = ""
   D7312.Standard8 = ""
   D7312.Standard9 = ""
   D7312.Standard10 = ""
   D7312.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7312_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7312 As T7312_AREA)
Try
    
    x7312.JobBOMCode = trim$(  x7312.JobBOMCode)
    x7312.JobBOMSeq = trim$(  x7312.JobBOMSeq)
    x7312.ProcessBOMCode = trim$(  x7312.ProcessBOMCode)
    x7312.ProcessBOMSeq = trim$(  x7312.ProcessBOMSeq)
    x7312.Dseq = trim$(  x7312.Dseq)
    x7312.seGroupJobProcess = trim$(  x7312.seGroupJobProcess)
    x7312.cdGroupJobProcess = trim$(  x7312.cdGroupJobProcess)
    x7312.cdJobProcess = trim$(  x7312.cdJobProcess)
    x7312.tpJobProcess = trim$(  x7312.tpJobProcess)
    x7312.PositionName = trim$(  x7312.PositionName)
    x7312.Description = trim$(  x7312.Description)
    x7312.MaterialCode = trim$(  x7312.MaterialCode)
    x7312.SupplierCode = trim$(  x7312.SupplierCode)
    x7312.Standard1 = trim$(  x7312.Standard1)
    x7312.Standard2 = trim$(  x7312.Standard2)
    x7312.Standard3 = trim$(  x7312.Standard3)
    x7312.Standard4 = trim$(  x7312.Standard4)
    x7312.Standard5 = trim$(  x7312.Standard5)
    x7312.Standard6 = trim$(  x7312.Standard6)
    x7312.Standard7 = trim$(  x7312.Standard7)
    x7312.Standard8 = trim$(  x7312.Standard8)
    x7312.Standard9 = trim$(  x7312.Standard9)
    x7312.Standard10 = trim$(  x7312.Standard10)
    x7312.Remark = trim$(  x7312.Remark)
     
    If trim$( x7312.JobBOMCode ) = "" Then x7312.JobBOMCode = Space(1) 
    If trim$( x7312.JobBOMSeq ) = "" Then x7312.JobBOMSeq = 0 
    If trim$( x7312.ProcessBOMCode ) = "" Then x7312.ProcessBOMCode = Space(1) 
    If trim$( x7312.ProcessBOMSeq ) = "" Then x7312.ProcessBOMSeq = 0 
    If trim$( x7312.Dseq ) = "" Then x7312.Dseq = 0 
    If trim$( x7312.seGroupJobProcess ) = "" Then x7312.seGroupJobProcess = Space(1) 
    If trim$( x7312.cdGroupJobProcess ) = "" Then x7312.cdGroupJobProcess = Space(1) 
    If trim$( x7312.cdJobProcess ) = "" Then x7312.cdJobProcess = Space(1) 
    If trim$( x7312.tpJobProcess ) = "" Then x7312.tpJobProcess = Space(1) 
    If trim$( x7312.PositionName ) = "" Then x7312.PositionName = Space(1) 
    If trim$( x7312.Description ) = "" Then x7312.Description = Space(1) 
    If trim$( x7312.MaterialCode ) = "" Then x7312.MaterialCode = Space(1) 
    If trim$( x7312.SupplierCode ) = "" Then x7312.SupplierCode = Space(1) 
    If trim$( x7312.Standard1 ) = "" Then x7312.Standard1 = Space(1) 
    If trim$( x7312.Standard2 ) = "" Then x7312.Standard2 = Space(1) 
    If trim$( x7312.Standard3 ) = "" Then x7312.Standard3 = Space(1) 
    If trim$( x7312.Standard4 ) = "" Then x7312.Standard4 = Space(1) 
    If trim$( x7312.Standard5 ) = "" Then x7312.Standard5 = Space(1) 
    If trim$( x7312.Standard6 ) = "" Then x7312.Standard6 = Space(1) 
    If trim$( x7312.Standard7 ) = "" Then x7312.Standard7 = Space(1) 
    If trim$( x7312.Standard8 ) = "" Then x7312.Standard8 = Space(1) 
    If trim$( x7312.Standard9 ) = "" Then x7312.Standard9 = Space(1) 
    If trim$( x7312.Standard10 ) = "" Then x7312.Standard10 = Space(1) 
    If trim$( x7312.Remark ) = "" Then x7312.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7312_MOVE(rs7312 As SqlClient.SqlDataReader)
Try

    call D7312_CLEAR()   

    If IsdbNull(rs7312!K7312_JobBOMCode) = False Then D7312.JobBOMCode = Trim$(rs7312!K7312_JobBOMCode)
    If IsdbNull(rs7312!K7312_JobBOMSeq) = False Then D7312.JobBOMSeq = Trim$(rs7312!K7312_JobBOMSeq)
    If IsdbNull(rs7312!K7312_ProcessBOMCode) = False Then D7312.ProcessBOMCode = Trim$(rs7312!K7312_ProcessBOMCode)
    If IsdbNull(rs7312!K7312_ProcessBOMSeq) = False Then D7312.ProcessBOMSeq = Trim$(rs7312!K7312_ProcessBOMSeq)
    If IsdbNull(rs7312!K7312_Dseq) = False Then D7312.Dseq = Trim$(rs7312!K7312_Dseq)
    If IsdbNull(rs7312!K7312_seGroupJobProcess) = False Then D7312.seGroupJobProcess = Trim$(rs7312!K7312_seGroupJobProcess)
    If IsdbNull(rs7312!K7312_cdGroupJobProcess) = False Then D7312.cdGroupJobProcess = Trim$(rs7312!K7312_cdGroupJobProcess)
    If IsdbNull(rs7312!K7312_cdJobProcess) = False Then D7312.cdJobProcess = Trim$(rs7312!K7312_cdJobProcess)
    If IsdbNull(rs7312!K7312_tpJobProcess) = False Then D7312.tpJobProcess = Trim$(rs7312!K7312_tpJobProcess)
    If IsdbNull(rs7312!K7312_PositionName) = False Then D7312.PositionName = Trim$(rs7312!K7312_PositionName)
    If IsdbNull(rs7312!K7312_Description) = False Then D7312.Description = Trim$(rs7312!K7312_Description)
    If IsdbNull(rs7312!K7312_MaterialCode) = False Then D7312.MaterialCode = Trim$(rs7312!K7312_MaterialCode)
    If IsdbNull(rs7312!K7312_SupplierCode) = False Then D7312.SupplierCode = Trim$(rs7312!K7312_SupplierCode)
    If IsdbNull(rs7312!K7312_Standard1) = False Then D7312.Standard1 = Trim$(rs7312!K7312_Standard1)
    If IsdbNull(rs7312!K7312_Standard2) = False Then D7312.Standard2 = Trim$(rs7312!K7312_Standard2)
    If IsdbNull(rs7312!K7312_Standard3) = False Then D7312.Standard3 = Trim$(rs7312!K7312_Standard3)
    If IsdbNull(rs7312!K7312_Standard4) = False Then D7312.Standard4 = Trim$(rs7312!K7312_Standard4)
    If IsdbNull(rs7312!K7312_Standard5) = False Then D7312.Standard5 = Trim$(rs7312!K7312_Standard5)
    If IsdbNull(rs7312!K7312_Standard6) = False Then D7312.Standard6 = Trim$(rs7312!K7312_Standard6)
    If IsdbNull(rs7312!K7312_Standard7) = False Then D7312.Standard7 = Trim$(rs7312!K7312_Standard7)
    If IsdbNull(rs7312!K7312_Standard8) = False Then D7312.Standard8 = Trim$(rs7312!K7312_Standard8)
    If IsdbNull(rs7312!K7312_Standard9) = False Then D7312.Standard9 = Trim$(rs7312!K7312_Standard9)
    If IsdbNull(rs7312!K7312_Standard10) = False Then D7312.Standard10 = Trim$(rs7312!K7312_Standard10)
    If IsdbNull(rs7312!K7312_Remark) = False Then D7312.Remark = Trim$(rs7312!K7312_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7312_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7312_MOVE(rs7312 As DataRow)
Try

    call D7312_CLEAR()   

    If IsdbNull(rs7312!K7312_JobBOMCode) = False Then D7312.JobBOMCode = Trim$(rs7312!K7312_JobBOMCode)
    If IsdbNull(rs7312!K7312_JobBOMSeq) = False Then D7312.JobBOMSeq = Trim$(rs7312!K7312_JobBOMSeq)
    If IsdbNull(rs7312!K7312_ProcessBOMCode) = False Then D7312.ProcessBOMCode = Trim$(rs7312!K7312_ProcessBOMCode)
    If IsdbNull(rs7312!K7312_ProcessBOMSeq) = False Then D7312.ProcessBOMSeq = Trim$(rs7312!K7312_ProcessBOMSeq)
    If IsdbNull(rs7312!K7312_Dseq) = False Then D7312.Dseq = Trim$(rs7312!K7312_Dseq)
    If IsdbNull(rs7312!K7312_seGroupJobProcess) = False Then D7312.seGroupJobProcess = Trim$(rs7312!K7312_seGroupJobProcess)
    If IsdbNull(rs7312!K7312_cdGroupJobProcess) = False Then D7312.cdGroupJobProcess = Trim$(rs7312!K7312_cdGroupJobProcess)
    If IsdbNull(rs7312!K7312_cdJobProcess) = False Then D7312.cdJobProcess = Trim$(rs7312!K7312_cdJobProcess)
    If IsdbNull(rs7312!K7312_tpJobProcess) = False Then D7312.tpJobProcess = Trim$(rs7312!K7312_tpJobProcess)
    If IsdbNull(rs7312!K7312_PositionName) = False Then D7312.PositionName = Trim$(rs7312!K7312_PositionName)
    If IsdbNull(rs7312!K7312_Description) = False Then D7312.Description = Trim$(rs7312!K7312_Description)
    If IsdbNull(rs7312!K7312_MaterialCode) = False Then D7312.MaterialCode = Trim$(rs7312!K7312_MaterialCode)
    If IsdbNull(rs7312!K7312_SupplierCode) = False Then D7312.SupplierCode = Trim$(rs7312!K7312_SupplierCode)
    If IsdbNull(rs7312!K7312_Standard1) = False Then D7312.Standard1 = Trim$(rs7312!K7312_Standard1)
    If IsdbNull(rs7312!K7312_Standard2) = False Then D7312.Standard2 = Trim$(rs7312!K7312_Standard2)
    If IsdbNull(rs7312!K7312_Standard3) = False Then D7312.Standard3 = Trim$(rs7312!K7312_Standard3)
    If IsdbNull(rs7312!K7312_Standard4) = False Then D7312.Standard4 = Trim$(rs7312!K7312_Standard4)
    If IsdbNull(rs7312!K7312_Standard5) = False Then D7312.Standard5 = Trim$(rs7312!K7312_Standard5)
    If IsdbNull(rs7312!K7312_Standard6) = False Then D7312.Standard6 = Trim$(rs7312!K7312_Standard6)
    If IsdbNull(rs7312!K7312_Standard7) = False Then D7312.Standard7 = Trim$(rs7312!K7312_Standard7)
    If IsdbNull(rs7312!K7312_Standard8) = False Then D7312.Standard8 = Trim$(rs7312!K7312_Standard8)
    If IsdbNull(rs7312!K7312_Standard9) = False Then D7312.Standard9 = Trim$(rs7312!K7312_Standard9)
    If IsdbNull(rs7312!K7312_Standard10) = False Then D7312.Standard10 = Trim$(rs7312!K7312_Standard10)
    If IsdbNull(rs7312!K7312_Remark) = False Then D7312.Remark = Trim$(rs7312!K7312_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7312_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7312_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7312 As T7312_AREA, JOBBOMCODE AS String, JOBBOMSEQ AS Double) as Boolean

K7312_MOVE = False

Try
    If READ_PFK7312(JOBBOMCODE, JOBBOMSEQ) = True Then
                z7312 = D7312
		K7312_MOVE = True
		else
	z7312 = nothing
     End If

     If  getColumIndex(spr,"JobBOMCode") > -1 then z7312.JobBOMCode = getDataM(spr, getColumIndex(spr,"JobBOMCode"), xRow)
     If  getColumIndex(spr,"JobBOMSeq") > -1 then z7312.JobBOMSeq = getDataM(spr, getColumIndex(spr,"JobBOMSeq"), xRow)
     If  getColumIndex(spr,"ProcessBOMCode") > -1 then z7312.ProcessBOMCode = getDataM(spr, getColumIndex(spr,"ProcessBOMCode"), xRow)
     If  getColumIndex(spr,"ProcessBOMSeq") > -1 then z7312.ProcessBOMSeq = getDataM(spr, getColumIndex(spr,"ProcessBOMSeq"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z7312.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"seGroupJobProcess") > -1 then z7312.seGroupJobProcess = getDataM(spr, getColumIndex(spr,"seGroupJobProcess"), xRow)
     If  getColumIndex(spr,"cdGroupJobProcess") > -1 then z7312.cdGroupJobProcess = getDataM(spr, getColumIndex(spr,"cdGroupJobProcess"), xRow)
     If  getColumIndex(spr,"cdJobProcess") > -1 then z7312.cdJobProcess = getDataM(spr, getColumIndex(spr,"cdJobProcess"), xRow)
     If  getColumIndex(spr,"tpJobProcess") > -1 then z7312.tpJobProcess = getDataM(spr, getColumIndex(spr,"tpJobProcess"), xRow)
     If  getColumIndex(spr,"PositionName") > -1 then z7312.PositionName = getDataM(spr, getColumIndex(spr,"PositionName"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z7312.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z7312.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z7312.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"Standard1") > -1 then z7312.Standard1 = getDataM(spr, getColumIndex(spr,"Standard1"), xRow)
     If  getColumIndex(spr,"Standard2") > -1 then z7312.Standard2 = getDataM(spr, getColumIndex(spr,"Standard2"), xRow)
     If  getColumIndex(spr,"Standard3") > -1 then z7312.Standard3 = getDataM(spr, getColumIndex(spr,"Standard3"), xRow)
     If  getColumIndex(spr,"Standard4") > -1 then z7312.Standard4 = getDataM(spr, getColumIndex(spr,"Standard4"), xRow)
     If  getColumIndex(spr,"Standard5") > -1 then z7312.Standard5 = getDataM(spr, getColumIndex(spr,"Standard5"), xRow)
     If  getColumIndex(spr,"Standard6") > -1 then z7312.Standard6 = getDataM(spr, getColumIndex(spr,"Standard6"), xRow)
     If  getColumIndex(spr,"Standard7") > -1 then z7312.Standard7 = getDataM(spr, getColumIndex(spr,"Standard7"), xRow)
     If  getColumIndex(spr,"Standard8") > -1 then z7312.Standard8 = getDataM(spr, getColumIndex(spr,"Standard8"), xRow)
     If  getColumIndex(spr,"Standard9") > -1 then z7312.Standard9 = getDataM(spr, getColumIndex(spr,"Standard9"), xRow)
     If  getColumIndex(spr,"Standard10") > -1 then z7312.Standard10 = getDataM(spr, getColumIndex(spr,"Standard10"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7312.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7312_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7312_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7312 As T7312_AREA,CheckClear as Boolean,JOBBOMCODE AS String, JOBBOMSEQ AS Double) as Boolean

K7312_MOVE = False

Try
    If READ_PFK7312(JOBBOMCODE, JOBBOMSEQ) = True Then
                z7312 = D7312
		K7312_MOVE = True
		else
	If CheckClear  = True then z7312 = nothing
     End If

     If  getColumIndex(spr,"JobBOMCode") > -1 then z7312.JobBOMCode = getDataM(spr, getColumIndex(spr,"JobBOMCode"), xRow)
     If  getColumIndex(spr,"JobBOMSeq") > -1 then z7312.JobBOMSeq = getDataM(spr, getColumIndex(spr,"JobBOMSeq"), xRow)
     If  getColumIndex(spr,"ProcessBOMCode") > -1 then z7312.ProcessBOMCode = getDataM(spr, getColumIndex(spr,"ProcessBOMCode"), xRow)
     If  getColumIndex(spr,"ProcessBOMSeq") > -1 then z7312.ProcessBOMSeq = getDataM(spr, getColumIndex(spr,"ProcessBOMSeq"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z7312.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"seGroupJobProcess") > -1 then z7312.seGroupJobProcess = getDataM(spr, getColumIndex(spr,"seGroupJobProcess"), xRow)
     If  getColumIndex(spr,"cdGroupJobProcess") > -1 then z7312.cdGroupJobProcess = getDataM(spr, getColumIndex(spr,"cdGroupJobProcess"), xRow)
     If  getColumIndex(spr,"cdJobProcess") > -1 then z7312.cdJobProcess = getDataM(spr, getColumIndex(spr,"cdJobProcess"), xRow)
     If  getColumIndex(spr,"tpJobProcess") > -1 then z7312.tpJobProcess = getDataM(spr, getColumIndex(spr,"tpJobProcess"), xRow)
     If  getColumIndex(spr,"PositionName") > -1 then z7312.PositionName = getDataM(spr, getColumIndex(spr,"PositionName"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z7312.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z7312.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z7312.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"Standard1") > -1 then z7312.Standard1 = getDataM(spr, getColumIndex(spr,"Standard1"), xRow)
     If  getColumIndex(spr,"Standard2") > -1 then z7312.Standard2 = getDataM(spr, getColumIndex(spr,"Standard2"), xRow)
     If  getColumIndex(spr,"Standard3") > -1 then z7312.Standard3 = getDataM(spr, getColumIndex(spr,"Standard3"), xRow)
     If  getColumIndex(spr,"Standard4") > -1 then z7312.Standard4 = getDataM(spr, getColumIndex(spr,"Standard4"), xRow)
     If  getColumIndex(spr,"Standard5") > -1 then z7312.Standard5 = getDataM(spr, getColumIndex(spr,"Standard5"), xRow)
     If  getColumIndex(spr,"Standard6") > -1 then z7312.Standard6 = getDataM(spr, getColumIndex(spr,"Standard6"), xRow)
     If  getColumIndex(spr,"Standard7") > -1 then z7312.Standard7 = getDataM(spr, getColumIndex(spr,"Standard7"), xRow)
     If  getColumIndex(spr,"Standard8") > -1 then z7312.Standard8 = getDataM(spr, getColumIndex(spr,"Standard8"), xRow)
     If  getColumIndex(spr,"Standard9") > -1 then z7312.Standard9 = getDataM(spr, getColumIndex(spr,"Standard9"), xRow)
     If  getColumIndex(spr,"Standard10") > -1 then z7312.Standard10 = getDataM(spr, getColumIndex(spr,"Standard10"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7312.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7312_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7312_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7312 As T7312_AREA, Job as String, JOBBOMCODE AS String, JOBBOMSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7312_MOVE = False

Try
    If READ_PFK7312(JOBBOMCODE, JOBBOMSEQ) = True Then
                z7312 = D7312
		K7312_MOVE = True
		else
	z7312 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7312")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "JOBBOMCODE":z7312.JobBOMCode = Children(i).Code
   Case "JOBBOMSEQ":z7312.JobBOMSeq = Children(i).Code
   Case "PROCESSBOMCODE":z7312.ProcessBOMCode = Children(i).Code
   Case "PROCESSBOMSEQ":z7312.ProcessBOMSeq = Children(i).Code
   Case "DSEQ":z7312.Dseq = Children(i).Code
   Case "SEGROUPJOBPROCESS":z7312.seGroupJobProcess = Children(i).Code
   Case "CDGROUPJOBPROCESS":z7312.cdGroupJobProcess = Children(i).Code
   Case "CDJOBPROCESS":z7312.cdJobProcess = Children(i).Code
   Case "TPJOBPROCESS":z7312.tpJobProcess = Children(i).Code
   Case "POSITIONNAME":z7312.PositionName = Children(i).Code
   Case "DESCRIPTION":z7312.Description = Children(i).Code
   Case "MATERIALCODE":z7312.MaterialCode = Children(i).Code
   Case "SUPPLIERCODE":z7312.SupplierCode = Children(i).Code
   Case "STANDARD1":z7312.Standard1 = Children(i).Code
   Case "STANDARD2":z7312.Standard2 = Children(i).Code
   Case "STANDARD3":z7312.Standard3 = Children(i).Code
   Case "STANDARD4":z7312.Standard4 = Children(i).Code
   Case "STANDARD5":z7312.Standard5 = Children(i).Code
   Case "STANDARD6":z7312.Standard6 = Children(i).Code
   Case "STANDARD7":z7312.Standard7 = Children(i).Code
   Case "STANDARD8":z7312.Standard8 = Children(i).Code
   Case "STANDARD9":z7312.Standard9 = Children(i).Code
   Case "STANDARD10":z7312.Standard10 = Children(i).Code
   Case "REMARK":z7312.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "JOBBOMCODE":z7312.JobBOMCode = Children(i).Data
   Case "JOBBOMSEQ":z7312.JobBOMSeq = Children(i).Data
   Case "PROCESSBOMCODE":z7312.ProcessBOMCode = Children(i).Data
   Case "PROCESSBOMSEQ":z7312.ProcessBOMSeq = Children(i).Data
   Case "DSEQ":z7312.Dseq = Children(i).Data
   Case "SEGROUPJOBPROCESS":z7312.seGroupJobProcess = Children(i).Data
   Case "CDGROUPJOBPROCESS":z7312.cdGroupJobProcess = Children(i).Data
   Case "CDJOBPROCESS":z7312.cdJobProcess = Children(i).Data
   Case "TPJOBPROCESS":z7312.tpJobProcess = Children(i).Data
   Case "POSITIONNAME":z7312.PositionName = Children(i).Data
   Case "DESCRIPTION":z7312.Description = Children(i).Data
   Case "MATERIALCODE":z7312.MaterialCode = Children(i).Data
   Case "SUPPLIERCODE":z7312.SupplierCode = Children(i).Data
   Case "STANDARD1":z7312.Standard1 = Children(i).Data
   Case "STANDARD2":z7312.Standard2 = Children(i).Data
   Case "STANDARD3":z7312.Standard3 = Children(i).Data
   Case "STANDARD4":z7312.Standard4 = Children(i).Data
   Case "STANDARD5":z7312.Standard5 = Children(i).Data
   Case "STANDARD6":z7312.Standard6 = Children(i).Data
   Case "STANDARD7":z7312.Standard7 = Children(i).Data
   Case "STANDARD8":z7312.Standard8 = Children(i).Data
   Case "STANDARD9":z7312.Standard9 = Children(i).Data
   Case "STANDARD10":z7312.Standard10 = Children(i).Data
   Case "REMARK":z7312.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7312_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7312_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7312 As T7312_AREA, Job as String, CheckClear as Boolean, JOBBOMCODE AS String, JOBBOMSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7312_MOVE = False

Try
    If READ_PFK7312(JOBBOMCODE, JOBBOMSEQ) = True Then
                z7312 = D7312
		K7312_MOVE = True
		else
	If CheckClear  = True then z7312 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7312")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "JOBBOMCODE":z7312.JobBOMCode = Children(i).Code
   Case "JOBBOMSEQ":z7312.JobBOMSeq = Children(i).Code
   Case "PROCESSBOMCODE":z7312.ProcessBOMCode = Children(i).Code
   Case "PROCESSBOMSEQ":z7312.ProcessBOMSeq = Children(i).Code
   Case "DSEQ":z7312.Dseq = Children(i).Code
   Case "SEGROUPJOBPROCESS":z7312.seGroupJobProcess = Children(i).Code
   Case "CDGROUPJOBPROCESS":z7312.cdGroupJobProcess = Children(i).Code
   Case "CDJOBPROCESS":z7312.cdJobProcess = Children(i).Code
   Case "TPJOBPROCESS":z7312.tpJobProcess = Children(i).Code
   Case "POSITIONNAME":z7312.PositionName = Children(i).Code
   Case "DESCRIPTION":z7312.Description = Children(i).Code
   Case "MATERIALCODE":z7312.MaterialCode = Children(i).Code
   Case "SUPPLIERCODE":z7312.SupplierCode = Children(i).Code
   Case "STANDARD1":z7312.Standard1 = Children(i).Code
   Case "STANDARD2":z7312.Standard2 = Children(i).Code
   Case "STANDARD3":z7312.Standard3 = Children(i).Code
   Case "STANDARD4":z7312.Standard4 = Children(i).Code
   Case "STANDARD5":z7312.Standard5 = Children(i).Code
   Case "STANDARD6":z7312.Standard6 = Children(i).Code
   Case "STANDARD7":z7312.Standard7 = Children(i).Code
   Case "STANDARD8":z7312.Standard8 = Children(i).Code
   Case "STANDARD9":z7312.Standard9 = Children(i).Code
   Case "STANDARD10":z7312.Standard10 = Children(i).Code
   Case "REMARK":z7312.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "JOBBOMCODE":z7312.JobBOMCode = Children(i).Data
   Case "JOBBOMSEQ":z7312.JobBOMSeq = Children(i).Data
   Case "PROCESSBOMCODE":z7312.ProcessBOMCode = Children(i).Data
   Case "PROCESSBOMSEQ":z7312.ProcessBOMSeq = Children(i).Data
   Case "DSEQ":z7312.Dseq = Children(i).Data
   Case "SEGROUPJOBPROCESS":z7312.seGroupJobProcess = Children(i).Data
   Case "CDGROUPJOBPROCESS":z7312.cdGroupJobProcess = Children(i).Data
   Case "CDJOBPROCESS":z7312.cdJobProcess = Children(i).Data
   Case "TPJOBPROCESS":z7312.tpJobProcess = Children(i).Data
   Case "POSITIONNAME":z7312.PositionName = Children(i).Data
   Case "DESCRIPTION":z7312.Description = Children(i).Data
   Case "MATERIALCODE":z7312.MaterialCode = Children(i).Data
   Case "SUPPLIERCODE":z7312.SupplierCode = Children(i).Data
   Case "STANDARD1":z7312.Standard1 = Children(i).Data
   Case "STANDARD2":z7312.Standard2 = Children(i).Data
   Case "STANDARD3":z7312.Standard3 = Children(i).Data
   Case "STANDARD4":z7312.Standard4 = Children(i).Data
   Case "STANDARD5":z7312.Standard5 = Children(i).Data
   Case "STANDARD6":z7312.Standard6 = Children(i).Data
   Case "STANDARD7":z7312.Standard7 = Children(i).Data
   Case "STANDARD8":z7312.Standard8 = Children(i).Data
   Case "STANDARD9":z7312.Standard9 = Children(i).Data
   Case "STANDARD10":z7312.Standard10 = Children(i).Data
   Case "REMARK":z7312.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7312_MOVE",vbCritical)
End Try
End Function 
    
End Module 
