'=========================================================================================================================================================
'   TABLE : (PFK7329)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7329

Structure T7329_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	JobBOMCode	 AS String	'			nvarchar(6)		*
Public 	JobBOMSeq	 AS Double	'			decimal		*
Public 	Dseq	 AS Double	'			decimal
Public 	seGroupJobProcess	 AS String	'			char(3)
Public 	cdGroupJobProcess	 AS String	'			char(3)
Public 	cdJobProcess	 AS String	'			char(3)
Public 	tpJobProcess	 AS String	'			char(6)
Public 	sePosition	 AS String	'			char(3)
Public 	PositionName	 AS String	'			nvarchar(20)
Public 	Description	 AS String	'			nvarchar(100)
Public 	MaterialCode	 AS String	'			char(6)
Public 	SupplierCode	 AS String	'			char(6)
Public 	SecCT	 AS Double	'			decimal
Public 	SecMin	 AS Double	'			decimal
Public 	SecMax	 AS Double	'			decimal
Public 	Rating	 AS Double	'			decimal
Public 	SecCTAdj	 AS Double	'			decimal
Public 	ManPower	 AS Double	'			decimal
Public 	ManActual	 AS Double	'			decimal
Public 	ManStandard	 AS Double	'			decimal
Public 	Tolarance	 AS Double	'			decimal
Public 	SecBalance	 AS Double	'			decimal
Public 	SecMaxPut	 AS Double	'			decimal
Public 	SecOpt1	 AS Double	'			decimal
Public 	SecOpt2	 AS Double	'			decimal
Public 	SecOpt3	 AS Double	'			decimal
Public 	SecOpt4	 AS Double	'			decimal
Public 	SecOpt5	 AS Double	'			decimal
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

Public D7329 As T7329_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7329(JOBBOMCODE AS String, JOBBOMSEQ AS Double) As Boolean
    READ_PFK7329 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7329 "
    SQL = SQL & " WHERE K7329_JobBOMCode		 = '" & JobBOMCode & "' " 
    SQL = SQL & "   AND K7329_JobBOMSeq		 =  " & JobBOMSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7329_CLEAR: GoTo SKIP_READ_PFK7329
                
    Call K7329_MOVE(rd)
    READ_PFK7329 = True

SKIP_READ_PFK7329:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7329",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7329(JOBBOMCODE AS String, JOBBOMSEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7329 "
    SQL = SQL & " WHERE K7329_JobBOMCode		 = '" & JobBOMCode & "' " 
    SQL = SQL & "   AND K7329_JobBOMSeq		 =  " & JobBOMSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7329",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7329(z7329 As T7329_AREA) As Boolean
    WRITE_PFK7329 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7329)
 
    SQL = " INSERT INTO PFK7329 "
    SQL = SQL & " ( "
    SQL = SQL & " K7329_JobBOMCode," 
    SQL = SQL & " K7329_JobBOMSeq," 
    SQL = SQL & " K7329_Dseq," 
    SQL = SQL & " K7329_seGroupJobProcess," 
    SQL = SQL & " K7329_cdGroupJobProcess," 
    SQL = SQL & " K7329_cdJobProcess," 
    SQL = SQL & " K7329_tpJobProcess," 
    SQL = SQL & " K7329_sePosition," 
    SQL = SQL & " K7329_PositionName," 
    SQL = SQL & " K7329_Description," 
    SQL = SQL & " K7329_MaterialCode," 
    SQL = SQL & " K7329_SupplierCode," 
    SQL = SQL & " K7329_SecCT," 
    SQL = SQL & " K7329_SecMin," 
    SQL = SQL & " K7329_SecMax," 
    SQL = SQL & " K7329_Rating," 
    SQL = SQL & " K7329_SecCTAdj," 
    SQL = SQL & " K7329_ManPower," 
    SQL = SQL & " K7329_ManActual," 
    SQL = SQL & " K7329_ManStandard," 
    SQL = SQL & " K7329_Tolarance," 
    SQL = SQL & " K7329_SecBalance," 
    SQL = SQL & " K7329_SecMaxPut," 
    SQL = SQL & " K7329_SecOpt1," 
    SQL = SQL & " K7329_SecOpt2," 
    SQL = SQL & " K7329_SecOpt3," 
    SQL = SQL & " K7329_SecOpt4," 
    SQL = SQL & " K7329_SecOpt5," 
    SQL = SQL & " K7329_Standard1," 
    SQL = SQL & " K7329_Standard2," 
    SQL = SQL & " K7329_Standard3," 
    SQL = SQL & " K7329_Standard4," 
    SQL = SQL & " K7329_Standard5," 
    SQL = SQL & " K7329_Standard6," 
    SQL = SQL & " K7329_Standard7," 
    SQL = SQL & " K7329_Standard8," 
    SQL = SQL & " K7329_Standard9," 
    SQL = SQL & " K7329_Standard10," 
    SQL = SQL & " K7329_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7329.JobBOMCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z7329.JobBOMSeq) & ", "  
    SQL = SQL & "   " & FormatSQL(z7329.Dseq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7329.seGroupJobProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7329.cdGroupJobProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7329.cdJobProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7329.tpJobProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7329.sePosition) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7329.PositionName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7329.Description) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7329.MaterialCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7329.SupplierCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z7329.SecCT) & ", "  
    SQL = SQL & "   " & FormatSQL(z7329.SecMin) & ", "  
    SQL = SQL & "   " & FormatSQL(z7329.SecMax) & ", "  
    SQL = SQL & "   " & FormatSQL(z7329.Rating) & ", "  
    SQL = SQL & "   " & FormatSQL(z7329.SecCTAdj) & ", "  
    SQL = SQL & "   " & FormatSQL(z7329.ManPower) & ", "  
    SQL = SQL & "   " & FormatSQL(z7329.ManActual) & ", "  
    SQL = SQL & "   " & FormatSQL(z7329.ManStandard) & ", "  
    SQL = SQL & "   " & FormatSQL(z7329.Tolarance) & ", "  
    SQL = SQL & "   " & FormatSQL(z7329.SecBalance) & ", "  
    SQL = SQL & "   " & FormatSQL(z7329.SecMaxPut) & ", "  
    SQL = SQL & "   " & FormatSQL(z7329.SecOpt1) & ", "  
    SQL = SQL & "   " & FormatSQL(z7329.SecOpt2) & ", "  
    SQL = SQL & "   " & FormatSQL(z7329.SecOpt3) & ", "  
    SQL = SQL & "   " & FormatSQL(z7329.SecOpt4) & ", "  
    SQL = SQL & "   " & FormatSQL(z7329.SecOpt5) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7329.Standard1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7329.Standard2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7329.Standard3) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7329.Standard4) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7329.Standard5) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7329.Standard6) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7329.Standard7) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7329.Standard8) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7329.Standard9) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7329.Standard10) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7329.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7329 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7329",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7329(z7329 As T7329_AREA) As Boolean
    REWRITE_PFK7329 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7329)
   
    SQL = " UPDATE PFK7329 SET "
    SQL = SQL & "    K7329_Dseq      =  " & FormatSQL(z7329.Dseq) & ", " 
    SQL = SQL & "    K7329_seGroupJobProcess      = N'" & FormatSQL(z7329.seGroupJobProcess) & "', " 
    SQL = SQL & "    K7329_cdGroupJobProcess      = N'" & FormatSQL(z7329.cdGroupJobProcess) & "', " 
    SQL = SQL & "    K7329_cdJobProcess      = N'" & FormatSQL(z7329.cdJobProcess) & "', " 
    SQL = SQL & "    K7329_tpJobProcess      = N'" & FormatSQL(z7329.tpJobProcess) & "', " 
    SQL = SQL & "    K7329_sePosition      = N'" & FormatSQL(z7329.sePosition) & "', " 
    SQL = SQL & "    K7329_PositionName      = N'" & FormatSQL(z7329.PositionName) & "', " 
    SQL = SQL & "    K7329_Description      = N'" & FormatSQL(z7329.Description) & "', " 
    SQL = SQL & "    K7329_MaterialCode      = N'" & FormatSQL(z7329.MaterialCode) & "', " 
    SQL = SQL & "    K7329_SupplierCode      = N'" & FormatSQL(z7329.SupplierCode) & "', " 
    SQL = SQL & "    K7329_SecCT      =  " & FormatSQL(z7329.SecCT) & ", " 
    SQL = SQL & "    K7329_SecMin      =  " & FormatSQL(z7329.SecMin) & ", " 
    SQL = SQL & "    K7329_SecMax      =  " & FormatSQL(z7329.SecMax) & ", " 
    SQL = SQL & "    K7329_Rating      =  " & FormatSQL(z7329.Rating) & ", " 
    SQL = SQL & "    K7329_SecCTAdj      =  " & FormatSQL(z7329.SecCTAdj) & ", " 
    SQL = SQL & "    K7329_ManPower      =  " & FormatSQL(z7329.ManPower) & ", " 
    SQL = SQL & "    K7329_ManActual      =  " & FormatSQL(z7329.ManActual) & ", " 
    SQL = SQL & "    K7329_ManStandard      =  " & FormatSQL(z7329.ManStandard) & ", " 
    SQL = SQL & "    K7329_Tolarance      =  " & FormatSQL(z7329.Tolarance) & ", " 
    SQL = SQL & "    K7329_SecBalance      =  " & FormatSQL(z7329.SecBalance) & ", " 
    SQL = SQL & "    K7329_SecMaxPut      =  " & FormatSQL(z7329.SecMaxPut) & ", " 
    SQL = SQL & "    K7329_SecOpt1      =  " & FormatSQL(z7329.SecOpt1) & ", " 
    SQL = SQL & "    K7329_SecOpt2      =  " & FormatSQL(z7329.SecOpt2) & ", " 
    SQL = SQL & "    K7329_SecOpt3      =  " & FormatSQL(z7329.SecOpt3) & ", " 
    SQL = SQL & "    K7329_SecOpt4      =  " & FormatSQL(z7329.SecOpt4) & ", " 
    SQL = SQL & "    K7329_SecOpt5      =  " & FormatSQL(z7329.SecOpt5) & ", " 
    SQL = SQL & "    K7329_Standard1      = N'" & FormatSQL(z7329.Standard1) & "', " 
    SQL = SQL & "    K7329_Standard2      = N'" & FormatSQL(z7329.Standard2) & "', " 
    SQL = SQL & "    K7329_Standard3      = N'" & FormatSQL(z7329.Standard3) & "', " 
    SQL = SQL & "    K7329_Standard4      = N'" & FormatSQL(z7329.Standard4) & "', " 
    SQL = SQL & "    K7329_Standard5      = N'" & FormatSQL(z7329.Standard5) & "', " 
    SQL = SQL & "    K7329_Standard6      = N'" & FormatSQL(z7329.Standard6) & "', " 
    SQL = SQL & "    K7329_Standard7      = N'" & FormatSQL(z7329.Standard7) & "', " 
    SQL = SQL & "    K7329_Standard8      = N'" & FormatSQL(z7329.Standard8) & "', " 
    SQL = SQL & "    K7329_Standard9      = N'" & FormatSQL(z7329.Standard9) & "', " 
    SQL = SQL & "    K7329_Standard10      = N'" & FormatSQL(z7329.Standard10) & "', " 
    SQL = SQL & "    K7329_Remark      = N'" & FormatSQL(z7329.Remark) & "'  " 
    SQL = SQL & " WHERE K7329_JobBOMCode		 = '" & z7329.JobBOMCode & "' " 
    SQL = SQL & "   AND K7329_JobBOMSeq		 =  " & z7329.JobBOMSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7329 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7329",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7329(z7329 As T7329_AREA) As Boolean
    DELETE_PFK7329 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7329 "
    SQL = SQL & " WHERE K7329_JobBOMCode		 = '" & z7329.JobBOMCode & "' " 
    SQL = SQL & "   AND K7329_JobBOMSeq		 =  " & z7329.JobBOMSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7329 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7329",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7329_CLEAR()
Try
    
   D7329.JobBOMCode = ""
    D7329.JobBOMSeq = 0 
    D7329.Dseq = 0 
   D7329.seGroupJobProcess = ""
   D7329.cdGroupJobProcess = ""
   D7329.cdJobProcess = ""
   D7329.tpJobProcess = ""
   D7329.sePosition = ""
   D7329.PositionName = ""
   D7329.Description = ""
   D7329.MaterialCode = ""
   D7329.SupplierCode = ""
    D7329.SecCT = 0 
    D7329.SecMin = 0 
    D7329.SecMax = 0 
    D7329.Rating = 0 
    D7329.SecCTAdj = 0 
    D7329.ManPower = 0 
    D7329.ManActual = 0 
    D7329.ManStandard = 0 
    D7329.Tolarance = 0 
    D7329.SecBalance = 0 
    D7329.SecMaxPut = 0 
    D7329.SecOpt1 = 0 
    D7329.SecOpt2 = 0 
    D7329.SecOpt3 = 0 
    D7329.SecOpt4 = 0 
    D7329.SecOpt5 = 0 
   D7329.Standard1 = ""
   D7329.Standard2 = ""
   D7329.Standard3 = ""
   D7329.Standard4 = ""
   D7329.Standard5 = ""
   D7329.Standard6 = ""
   D7329.Standard7 = ""
   D7329.Standard8 = ""
   D7329.Standard9 = ""
   D7329.Standard10 = ""
   D7329.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7329_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7329 As T7329_AREA)
Try
    
    x7329.JobBOMCode = trim$(  x7329.JobBOMCode)
    x7329.JobBOMSeq = trim$(  x7329.JobBOMSeq)
    x7329.Dseq = trim$(  x7329.Dseq)
    x7329.seGroupJobProcess = trim$(  x7329.seGroupJobProcess)
    x7329.cdGroupJobProcess = trim$(  x7329.cdGroupJobProcess)
    x7329.cdJobProcess = trim$(  x7329.cdJobProcess)
    x7329.tpJobProcess = trim$(  x7329.tpJobProcess)
    x7329.sePosition = trim$(  x7329.sePosition)
    x7329.PositionName = trim$(  x7329.PositionName)
    x7329.Description = trim$(  x7329.Description)
    x7329.MaterialCode = trim$(  x7329.MaterialCode)
    x7329.SupplierCode = trim$(  x7329.SupplierCode)
    x7329.SecCT = trim$(  x7329.SecCT)
    x7329.SecMin = trim$(  x7329.SecMin)
    x7329.SecMax = trim$(  x7329.SecMax)
    x7329.Rating = trim$(  x7329.Rating)
    x7329.SecCTAdj = trim$(  x7329.SecCTAdj)
    x7329.ManPower = trim$(  x7329.ManPower)
    x7329.ManActual = trim$(  x7329.ManActual)
    x7329.ManStandard = trim$(  x7329.ManStandard)
    x7329.Tolarance = trim$(  x7329.Tolarance)
    x7329.SecBalance = trim$(  x7329.SecBalance)
    x7329.SecMaxPut = trim$(  x7329.SecMaxPut)
    x7329.SecOpt1 = trim$(  x7329.SecOpt1)
    x7329.SecOpt2 = trim$(  x7329.SecOpt2)
    x7329.SecOpt3 = trim$(  x7329.SecOpt3)
    x7329.SecOpt4 = trim$(  x7329.SecOpt4)
    x7329.SecOpt5 = trim$(  x7329.SecOpt5)
    x7329.Standard1 = trim$(  x7329.Standard1)
    x7329.Standard2 = trim$(  x7329.Standard2)
    x7329.Standard3 = trim$(  x7329.Standard3)
    x7329.Standard4 = trim$(  x7329.Standard4)
    x7329.Standard5 = trim$(  x7329.Standard5)
    x7329.Standard6 = trim$(  x7329.Standard6)
    x7329.Standard7 = trim$(  x7329.Standard7)
    x7329.Standard8 = trim$(  x7329.Standard8)
    x7329.Standard9 = trim$(  x7329.Standard9)
    x7329.Standard10 = trim$(  x7329.Standard10)
    x7329.Remark = trim$(  x7329.Remark)
     
    If trim$( x7329.JobBOMCode ) = "" Then x7329.JobBOMCode = Space(1) 
    If trim$( x7329.JobBOMSeq ) = "" Then x7329.JobBOMSeq = 0 
    If trim$( x7329.Dseq ) = "" Then x7329.Dseq = 0 
    If trim$( x7329.seGroupJobProcess ) = "" Then x7329.seGroupJobProcess = Space(1) 
    If trim$( x7329.cdGroupJobProcess ) = "" Then x7329.cdGroupJobProcess = Space(1) 
    If trim$( x7329.cdJobProcess ) = "" Then x7329.cdJobProcess = Space(1) 
    If trim$( x7329.tpJobProcess ) = "" Then x7329.tpJobProcess = Space(1) 
    If trim$( x7329.sePosition ) = "" Then x7329.sePosition = Space(1) 
    If trim$( x7329.PositionName ) = "" Then x7329.PositionName = Space(1) 
    If trim$( x7329.Description ) = "" Then x7329.Description = Space(1) 
    If trim$( x7329.MaterialCode ) = "" Then x7329.MaterialCode = Space(1) 
    If trim$( x7329.SupplierCode ) = "" Then x7329.SupplierCode = Space(1) 
    If trim$( x7329.SecCT ) = "" Then x7329.SecCT = 0 
    If trim$( x7329.SecMin ) = "" Then x7329.SecMin = 0 
    If trim$( x7329.SecMax ) = "" Then x7329.SecMax = 0 
    If trim$( x7329.Rating ) = "" Then x7329.Rating = 0 
    If trim$( x7329.SecCTAdj ) = "" Then x7329.SecCTAdj = 0 
    If trim$( x7329.ManPower ) = "" Then x7329.ManPower = 0 
    If trim$( x7329.ManActual ) = "" Then x7329.ManActual = 0 
    If trim$( x7329.ManStandard ) = "" Then x7329.ManStandard = 0 
    If trim$( x7329.Tolarance ) = "" Then x7329.Tolarance = 0 
    If trim$( x7329.SecBalance ) = "" Then x7329.SecBalance = 0 
    If trim$( x7329.SecMaxPut ) = "" Then x7329.SecMaxPut = 0 
    If trim$( x7329.SecOpt1 ) = "" Then x7329.SecOpt1 = 0 
    If trim$( x7329.SecOpt2 ) = "" Then x7329.SecOpt2 = 0 
    If trim$( x7329.SecOpt3 ) = "" Then x7329.SecOpt3 = 0 
    If trim$( x7329.SecOpt4 ) = "" Then x7329.SecOpt4 = 0 
    If trim$( x7329.SecOpt5 ) = "" Then x7329.SecOpt5 = 0 
    If trim$( x7329.Standard1 ) = "" Then x7329.Standard1 = Space(1) 
    If trim$( x7329.Standard2 ) = "" Then x7329.Standard2 = Space(1) 
    If trim$( x7329.Standard3 ) = "" Then x7329.Standard3 = Space(1) 
    If trim$( x7329.Standard4 ) = "" Then x7329.Standard4 = Space(1) 
    If trim$( x7329.Standard5 ) = "" Then x7329.Standard5 = Space(1) 
    If trim$( x7329.Standard6 ) = "" Then x7329.Standard6 = Space(1) 
    If trim$( x7329.Standard7 ) = "" Then x7329.Standard7 = Space(1) 
    If trim$( x7329.Standard8 ) = "" Then x7329.Standard8 = Space(1) 
    If trim$( x7329.Standard9 ) = "" Then x7329.Standard9 = Space(1) 
    If trim$( x7329.Standard10 ) = "" Then x7329.Standard10 = Space(1) 
    If trim$( x7329.Remark ) = "" Then x7329.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7329_MOVE(rs7329 As SqlClient.SqlDataReader)
Try

    call D7329_CLEAR()   

    If IsdbNull(rs7329!K7329_JobBOMCode) = False Then D7329.JobBOMCode = Trim$(rs7329!K7329_JobBOMCode)
    If IsdbNull(rs7329!K7329_JobBOMSeq) = False Then D7329.JobBOMSeq = Trim$(rs7329!K7329_JobBOMSeq)
    If IsdbNull(rs7329!K7329_Dseq) = False Then D7329.Dseq = Trim$(rs7329!K7329_Dseq)
    If IsdbNull(rs7329!K7329_seGroupJobProcess) = False Then D7329.seGroupJobProcess = Trim$(rs7329!K7329_seGroupJobProcess)
    If IsdbNull(rs7329!K7329_cdGroupJobProcess) = False Then D7329.cdGroupJobProcess = Trim$(rs7329!K7329_cdGroupJobProcess)
    If IsdbNull(rs7329!K7329_cdJobProcess) = False Then D7329.cdJobProcess = Trim$(rs7329!K7329_cdJobProcess)
    If IsdbNull(rs7329!K7329_tpJobProcess) = False Then D7329.tpJobProcess = Trim$(rs7329!K7329_tpJobProcess)
    If IsdbNull(rs7329!K7329_sePosition) = False Then D7329.sePosition = Trim$(rs7329!K7329_sePosition)
    If IsdbNull(rs7329!K7329_PositionName) = False Then D7329.PositionName = Trim$(rs7329!K7329_PositionName)
    If IsdbNull(rs7329!K7329_Description) = False Then D7329.Description = Trim$(rs7329!K7329_Description)
    If IsdbNull(rs7329!K7329_MaterialCode) = False Then D7329.MaterialCode = Trim$(rs7329!K7329_MaterialCode)
    If IsdbNull(rs7329!K7329_SupplierCode) = False Then D7329.SupplierCode = Trim$(rs7329!K7329_SupplierCode)
    If IsdbNull(rs7329!K7329_SecCT) = False Then D7329.SecCT = Trim$(rs7329!K7329_SecCT)
    If IsdbNull(rs7329!K7329_SecMin) = False Then D7329.SecMin = Trim$(rs7329!K7329_SecMin)
    If IsdbNull(rs7329!K7329_SecMax) = False Then D7329.SecMax = Trim$(rs7329!K7329_SecMax)
    If IsdbNull(rs7329!K7329_Rating) = False Then D7329.Rating = Trim$(rs7329!K7329_Rating)
    If IsdbNull(rs7329!K7329_SecCTAdj) = False Then D7329.SecCTAdj = Trim$(rs7329!K7329_SecCTAdj)
    If IsdbNull(rs7329!K7329_ManPower) = False Then D7329.ManPower = Trim$(rs7329!K7329_ManPower)
    If IsdbNull(rs7329!K7329_ManActual) = False Then D7329.ManActual = Trim$(rs7329!K7329_ManActual)
    If IsdbNull(rs7329!K7329_ManStandard) = False Then D7329.ManStandard = Trim$(rs7329!K7329_ManStandard)
    If IsdbNull(rs7329!K7329_Tolarance) = False Then D7329.Tolarance = Trim$(rs7329!K7329_Tolarance)
    If IsdbNull(rs7329!K7329_SecBalance) = False Then D7329.SecBalance = Trim$(rs7329!K7329_SecBalance)
    If IsdbNull(rs7329!K7329_SecMaxPut) = False Then D7329.SecMaxPut = Trim$(rs7329!K7329_SecMaxPut)
    If IsdbNull(rs7329!K7329_SecOpt1) = False Then D7329.SecOpt1 = Trim$(rs7329!K7329_SecOpt1)
    If IsdbNull(rs7329!K7329_SecOpt2) = False Then D7329.SecOpt2 = Trim$(rs7329!K7329_SecOpt2)
    If IsdbNull(rs7329!K7329_SecOpt3) = False Then D7329.SecOpt3 = Trim$(rs7329!K7329_SecOpt3)
    If IsdbNull(rs7329!K7329_SecOpt4) = False Then D7329.SecOpt4 = Trim$(rs7329!K7329_SecOpt4)
    If IsdbNull(rs7329!K7329_SecOpt5) = False Then D7329.SecOpt5 = Trim$(rs7329!K7329_SecOpt5)
    If IsdbNull(rs7329!K7329_Standard1) = False Then D7329.Standard1 = Trim$(rs7329!K7329_Standard1)
    If IsdbNull(rs7329!K7329_Standard2) = False Then D7329.Standard2 = Trim$(rs7329!K7329_Standard2)
    If IsdbNull(rs7329!K7329_Standard3) = False Then D7329.Standard3 = Trim$(rs7329!K7329_Standard3)
    If IsdbNull(rs7329!K7329_Standard4) = False Then D7329.Standard4 = Trim$(rs7329!K7329_Standard4)
    If IsdbNull(rs7329!K7329_Standard5) = False Then D7329.Standard5 = Trim$(rs7329!K7329_Standard5)
    If IsdbNull(rs7329!K7329_Standard6) = False Then D7329.Standard6 = Trim$(rs7329!K7329_Standard6)
    If IsdbNull(rs7329!K7329_Standard7) = False Then D7329.Standard7 = Trim$(rs7329!K7329_Standard7)
    If IsdbNull(rs7329!K7329_Standard8) = False Then D7329.Standard8 = Trim$(rs7329!K7329_Standard8)
    If IsdbNull(rs7329!K7329_Standard9) = False Then D7329.Standard9 = Trim$(rs7329!K7329_Standard9)
    If IsdbNull(rs7329!K7329_Standard10) = False Then D7329.Standard10 = Trim$(rs7329!K7329_Standard10)
    If IsdbNull(rs7329!K7329_Remark) = False Then D7329.Remark = Trim$(rs7329!K7329_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7329_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7329_MOVE(rs7329 As DataRow)
Try

    call D7329_CLEAR()   

    If IsdbNull(rs7329!K7329_JobBOMCode) = False Then D7329.JobBOMCode = Trim$(rs7329!K7329_JobBOMCode)
    If IsdbNull(rs7329!K7329_JobBOMSeq) = False Then D7329.JobBOMSeq = Trim$(rs7329!K7329_JobBOMSeq)
    If IsdbNull(rs7329!K7329_Dseq) = False Then D7329.Dseq = Trim$(rs7329!K7329_Dseq)
    If IsdbNull(rs7329!K7329_seGroupJobProcess) = False Then D7329.seGroupJobProcess = Trim$(rs7329!K7329_seGroupJobProcess)
    If IsdbNull(rs7329!K7329_cdGroupJobProcess) = False Then D7329.cdGroupJobProcess = Trim$(rs7329!K7329_cdGroupJobProcess)
    If IsdbNull(rs7329!K7329_cdJobProcess) = False Then D7329.cdJobProcess = Trim$(rs7329!K7329_cdJobProcess)
    If IsdbNull(rs7329!K7329_tpJobProcess) = False Then D7329.tpJobProcess = Trim$(rs7329!K7329_tpJobProcess)
    If IsdbNull(rs7329!K7329_sePosition) = False Then D7329.sePosition = Trim$(rs7329!K7329_sePosition)
    If IsdbNull(rs7329!K7329_PositionName) = False Then D7329.PositionName = Trim$(rs7329!K7329_PositionName)
    If IsdbNull(rs7329!K7329_Description) = False Then D7329.Description = Trim$(rs7329!K7329_Description)
    If IsdbNull(rs7329!K7329_MaterialCode) = False Then D7329.MaterialCode = Trim$(rs7329!K7329_MaterialCode)
    If IsdbNull(rs7329!K7329_SupplierCode) = False Then D7329.SupplierCode = Trim$(rs7329!K7329_SupplierCode)
    If IsdbNull(rs7329!K7329_SecCT) = False Then D7329.SecCT = Trim$(rs7329!K7329_SecCT)
    If IsdbNull(rs7329!K7329_SecMin) = False Then D7329.SecMin = Trim$(rs7329!K7329_SecMin)
    If IsdbNull(rs7329!K7329_SecMax) = False Then D7329.SecMax = Trim$(rs7329!K7329_SecMax)
    If IsdbNull(rs7329!K7329_Rating) = False Then D7329.Rating = Trim$(rs7329!K7329_Rating)
    If IsdbNull(rs7329!K7329_SecCTAdj) = False Then D7329.SecCTAdj = Trim$(rs7329!K7329_SecCTAdj)
    If IsdbNull(rs7329!K7329_ManPower) = False Then D7329.ManPower = Trim$(rs7329!K7329_ManPower)
    If IsdbNull(rs7329!K7329_ManActual) = False Then D7329.ManActual = Trim$(rs7329!K7329_ManActual)
    If IsdbNull(rs7329!K7329_ManStandard) = False Then D7329.ManStandard = Trim$(rs7329!K7329_ManStandard)
    If IsdbNull(rs7329!K7329_Tolarance) = False Then D7329.Tolarance = Trim$(rs7329!K7329_Tolarance)
    If IsdbNull(rs7329!K7329_SecBalance) = False Then D7329.SecBalance = Trim$(rs7329!K7329_SecBalance)
    If IsdbNull(rs7329!K7329_SecMaxPut) = False Then D7329.SecMaxPut = Trim$(rs7329!K7329_SecMaxPut)
    If IsdbNull(rs7329!K7329_SecOpt1) = False Then D7329.SecOpt1 = Trim$(rs7329!K7329_SecOpt1)
    If IsdbNull(rs7329!K7329_SecOpt2) = False Then D7329.SecOpt2 = Trim$(rs7329!K7329_SecOpt2)
    If IsdbNull(rs7329!K7329_SecOpt3) = False Then D7329.SecOpt3 = Trim$(rs7329!K7329_SecOpt3)
    If IsdbNull(rs7329!K7329_SecOpt4) = False Then D7329.SecOpt4 = Trim$(rs7329!K7329_SecOpt4)
    If IsdbNull(rs7329!K7329_SecOpt5) = False Then D7329.SecOpt5 = Trim$(rs7329!K7329_SecOpt5)
    If IsdbNull(rs7329!K7329_Standard1) = False Then D7329.Standard1 = Trim$(rs7329!K7329_Standard1)
    If IsdbNull(rs7329!K7329_Standard2) = False Then D7329.Standard2 = Trim$(rs7329!K7329_Standard2)
    If IsdbNull(rs7329!K7329_Standard3) = False Then D7329.Standard3 = Trim$(rs7329!K7329_Standard3)
    If IsdbNull(rs7329!K7329_Standard4) = False Then D7329.Standard4 = Trim$(rs7329!K7329_Standard4)
    If IsdbNull(rs7329!K7329_Standard5) = False Then D7329.Standard5 = Trim$(rs7329!K7329_Standard5)
    If IsdbNull(rs7329!K7329_Standard6) = False Then D7329.Standard6 = Trim$(rs7329!K7329_Standard6)
    If IsdbNull(rs7329!K7329_Standard7) = False Then D7329.Standard7 = Trim$(rs7329!K7329_Standard7)
    If IsdbNull(rs7329!K7329_Standard8) = False Then D7329.Standard8 = Trim$(rs7329!K7329_Standard8)
    If IsdbNull(rs7329!K7329_Standard9) = False Then D7329.Standard9 = Trim$(rs7329!K7329_Standard9)
    If IsdbNull(rs7329!K7329_Standard10) = False Then D7329.Standard10 = Trim$(rs7329!K7329_Standard10)
    If IsdbNull(rs7329!K7329_Remark) = False Then D7329.Remark = Trim$(rs7329!K7329_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7329_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7329_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7329 As T7329_AREA, JOBBOMCODE AS String, JOBBOMSEQ AS Double) as Boolean

K7329_MOVE = False

Try
    If READ_PFK7329(JOBBOMCODE, JOBBOMSEQ) = True Then
                z7329 = D7329
		K7329_MOVE = True
		else
	z7329 = nothing
     End If

     If  getColumIndex(spr,"JobBOMCode") > -1 then z7329.JobBOMCode = getDataM(spr, getColumIndex(spr,"JobBOMCode"), xRow)
     If  getColumIndex(spr,"JobBOMSeq") > -1 then z7329.JobBOMSeq = getDataM(spr, getColumIndex(spr,"JobBOMSeq"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z7329.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"seGroupJobProcess") > -1 then z7329.seGroupJobProcess = getDataM(spr, getColumIndex(spr,"seGroupJobProcess"), xRow)
     If  getColumIndex(spr,"cdGroupJobProcess") > -1 then z7329.cdGroupJobProcess = getDataM(spr, getColumIndex(spr,"cdGroupJobProcess"), xRow)
     If  getColumIndex(spr,"cdJobProcess") > -1 then z7329.cdJobProcess = getDataM(spr, getColumIndex(spr,"cdJobProcess"), xRow)
     If  getColumIndex(spr,"tpJobProcess") > -1 then z7329.tpJobProcess = getDataM(spr, getColumIndex(spr,"tpJobProcess"), xRow)
     If  getColumIndex(spr,"sePosition") > -1 then z7329.sePosition = getDataM(spr, getColumIndex(spr,"sePosition"), xRow)
     If  getColumIndex(spr,"PositionName") > -1 then z7329.PositionName = getDataM(spr, getColumIndex(spr,"PositionName"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z7329.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z7329.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z7329.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"SecCT") > -1 then z7329.SecCT = getDataM(spr, getColumIndex(spr,"SecCT"), xRow)
     If  getColumIndex(spr,"SecMin") > -1 then z7329.SecMin = getDataM(spr, getColumIndex(spr,"SecMin"), xRow)
     If  getColumIndex(spr,"SecMax") > -1 then z7329.SecMax = getDataM(spr, getColumIndex(spr,"SecMax"), xRow)
     If  getColumIndex(spr,"Rating") > -1 then z7329.Rating = getDataM(spr, getColumIndex(spr,"Rating"), xRow)
     If  getColumIndex(spr,"SecCTAdj") > -1 then z7329.SecCTAdj = getDataM(spr, getColumIndex(spr,"SecCTAdj"), xRow)
     If  getColumIndex(spr,"ManPower") > -1 then z7329.ManPower = getDataM(spr, getColumIndex(spr,"ManPower"), xRow)
     If  getColumIndex(spr,"ManActual") > -1 then z7329.ManActual = getDataM(spr, getColumIndex(spr,"ManActual"), xRow)
     If  getColumIndex(spr,"ManStandard") > -1 then z7329.ManStandard = getDataM(spr, getColumIndex(spr,"ManStandard"), xRow)
     If  getColumIndex(spr,"Tolarance") > -1 then z7329.Tolarance = getDataM(spr, getColumIndex(spr,"Tolarance"), xRow)
     If  getColumIndex(spr,"SecBalance") > -1 then z7329.SecBalance = getDataM(spr, getColumIndex(spr,"SecBalance"), xRow)
     If  getColumIndex(spr,"SecMaxPut") > -1 then z7329.SecMaxPut = getDataM(spr, getColumIndex(spr,"SecMaxPut"), xRow)
     If  getColumIndex(spr,"SecOpt1") > -1 then z7329.SecOpt1 = getDataM(spr, getColumIndex(spr,"SecOpt1"), xRow)
     If  getColumIndex(spr,"SecOpt2") > -1 then z7329.SecOpt2 = getDataM(spr, getColumIndex(spr,"SecOpt2"), xRow)
     If  getColumIndex(spr,"SecOpt3") > -1 then z7329.SecOpt3 = getDataM(spr, getColumIndex(spr,"SecOpt3"), xRow)
     If  getColumIndex(spr,"SecOpt4") > -1 then z7329.SecOpt4 = getDataM(spr, getColumIndex(spr,"SecOpt4"), xRow)
     If  getColumIndex(spr,"SecOpt5") > -1 then z7329.SecOpt5 = getDataM(spr, getColumIndex(spr,"SecOpt5"), xRow)
     If  getColumIndex(spr,"Standard1") > -1 then z7329.Standard1 = getDataM(spr, getColumIndex(spr,"Standard1"), xRow)
     If  getColumIndex(spr,"Standard2") > -1 then z7329.Standard2 = getDataM(spr, getColumIndex(spr,"Standard2"), xRow)
     If  getColumIndex(spr,"Standard3") > -1 then z7329.Standard3 = getDataM(spr, getColumIndex(spr,"Standard3"), xRow)
     If  getColumIndex(spr,"Standard4") > -1 then z7329.Standard4 = getDataM(spr, getColumIndex(spr,"Standard4"), xRow)
     If  getColumIndex(spr,"Standard5") > -1 then z7329.Standard5 = getDataM(spr, getColumIndex(spr,"Standard5"), xRow)
     If  getColumIndex(spr,"Standard6") > -1 then z7329.Standard6 = getDataM(spr, getColumIndex(spr,"Standard6"), xRow)
     If  getColumIndex(spr,"Standard7") > -1 then z7329.Standard7 = getDataM(spr, getColumIndex(spr,"Standard7"), xRow)
     If  getColumIndex(spr,"Standard8") > -1 then z7329.Standard8 = getDataM(spr, getColumIndex(spr,"Standard8"), xRow)
     If  getColumIndex(spr,"Standard9") > -1 then z7329.Standard9 = getDataM(spr, getColumIndex(spr,"Standard9"), xRow)
     If  getColumIndex(spr,"Standard10") > -1 then z7329.Standard10 = getDataM(spr, getColumIndex(spr,"Standard10"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7329.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7329_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7329_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7329 As T7329_AREA,CheckClear as Boolean,JOBBOMCODE AS String, JOBBOMSEQ AS Double) as Boolean

K7329_MOVE = False

Try
    If READ_PFK7329(JOBBOMCODE, JOBBOMSEQ) = True Then
                z7329 = D7329
		K7329_MOVE = True
		else
	If CheckClear  = True then z7329 = nothing
     End If

     If  getColumIndex(spr,"JobBOMCode") > -1 then z7329.JobBOMCode = getDataM(spr, getColumIndex(spr,"JobBOMCode"), xRow)
     If  getColumIndex(spr,"JobBOMSeq") > -1 then z7329.JobBOMSeq = getDataM(spr, getColumIndex(spr,"JobBOMSeq"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z7329.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"seGroupJobProcess") > -1 then z7329.seGroupJobProcess = getDataM(spr, getColumIndex(spr,"seGroupJobProcess"), xRow)
     If  getColumIndex(spr,"cdGroupJobProcess") > -1 then z7329.cdGroupJobProcess = getDataM(spr, getColumIndex(spr,"cdGroupJobProcess"), xRow)
     If  getColumIndex(spr,"cdJobProcess") > -1 then z7329.cdJobProcess = getDataM(spr, getColumIndex(spr,"cdJobProcess"), xRow)
     If  getColumIndex(spr,"tpJobProcess") > -1 then z7329.tpJobProcess = getDataM(spr, getColumIndex(spr,"tpJobProcess"), xRow)
     If  getColumIndex(spr,"sePosition") > -1 then z7329.sePosition = getDataM(spr, getColumIndex(spr,"sePosition"), xRow)
     If  getColumIndex(spr,"PositionName") > -1 then z7329.PositionName = getDataM(spr, getColumIndex(spr,"PositionName"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z7329.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z7329.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z7329.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"SecCT") > -1 then z7329.SecCT = getDataM(spr, getColumIndex(spr,"SecCT"), xRow)
     If  getColumIndex(spr,"SecMin") > -1 then z7329.SecMin = getDataM(spr, getColumIndex(spr,"SecMin"), xRow)
     If  getColumIndex(spr,"SecMax") > -1 then z7329.SecMax = getDataM(spr, getColumIndex(spr,"SecMax"), xRow)
     If  getColumIndex(spr,"Rating") > -1 then z7329.Rating = getDataM(spr, getColumIndex(spr,"Rating"), xRow)
     If  getColumIndex(spr,"SecCTAdj") > -1 then z7329.SecCTAdj = getDataM(spr, getColumIndex(spr,"SecCTAdj"), xRow)
     If  getColumIndex(spr,"ManPower") > -1 then z7329.ManPower = getDataM(spr, getColumIndex(spr,"ManPower"), xRow)
     If  getColumIndex(spr,"ManActual") > -1 then z7329.ManActual = getDataM(spr, getColumIndex(spr,"ManActual"), xRow)
     If  getColumIndex(spr,"ManStandard") > -1 then z7329.ManStandard = getDataM(spr, getColumIndex(spr,"ManStandard"), xRow)
     If  getColumIndex(spr,"Tolarance") > -1 then z7329.Tolarance = getDataM(spr, getColumIndex(spr,"Tolarance"), xRow)
     If  getColumIndex(spr,"SecBalance") > -1 then z7329.SecBalance = getDataM(spr, getColumIndex(spr,"SecBalance"), xRow)
     If  getColumIndex(spr,"SecMaxPut") > -1 then z7329.SecMaxPut = getDataM(spr, getColumIndex(spr,"SecMaxPut"), xRow)
     If  getColumIndex(spr,"SecOpt1") > -1 then z7329.SecOpt1 = getDataM(spr, getColumIndex(spr,"SecOpt1"), xRow)
     If  getColumIndex(spr,"SecOpt2") > -1 then z7329.SecOpt2 = getDataM(spr, getColumIndex(spr,"SecOpt2"), xRow)
     If  getColumIndex(spr,"SecOpt3") > -1 then z7329.SecOpt3 = getDataM(spr, getColumIndex(spr,"SecOpt3"), xRow)
     If  getColumIndex(spr,"SecOpt4") > -1 then z7329.SecOpt4 = getDataM(spr, getColumIndex(spr,"SecOpt4"), xRow)
     If  getColumIndex(spr,"SecOpt5") > -1 then z7329.SecOpt5 = getDataM(spr, getColumIndex(spr,"SecOpt5"), xRow)
     If  getColumIndex(spr,"Standard1") > -1 then z7329.Standard1 = getDataM(spr, getColumIndex(spr,"Standard1"), xRow)
     If  getColumIndex(spr,"Standard2") > -1 then z7329.Standard2 = getDataM(spr, getColumIndex(spr,"Standard2"), xRow)
     If  getColumIndex(spr,"Standard3") > -1 then z7329.Standard3 = getDataM(spr, getColumIndex(spr,"Standard3"), xRow)
     If  getColumIndex(spr,"Standard4") > -1 then z7329.Standard4 = getDataM(spr, getColumIndex(spr,"Standard4"), xRow)
     If  getColumIndex(spr,"Standard5") > -1 then z7329.Standard5 = getDataM(spr, getColumIndex(spr,"Standard5"), xRow)
     If  getColumIndex(spr,"Standard6") > -1 then z7329.Standard6 = getDataM(spr, getColumIndex(spr,"Standard6"), xRow)
     If  getColumIndex(spr,"Standard7") > -1 then z7329.Standard7 = getDataM(spr, getColumIndex(spr,"Standard7"), xRow)
     If  getColumIndex(spr,"Standard8") > -1 then z7329.Standard8 = getDataM(spr, getColumIndex(spr,"Standard8"), xRow)
     If  getColumIndex(spr,"Standard9") > -1 then z7329.Standard9 = getDataM(spr, getColumIndex(spr,"Standard9"), xRow)
     If  getColumIndex(spr,"Standard10") > -1 then z7329.Standard10 = getDataM(spr, getColumIndex(spr,"Standard10"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7329.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7329_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7329_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7329 As T7329_AREA, Job as String, JOBBOMCODE AS String, JOBBOMSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7329_MOVE = False

Try
    If READ_PFK7329(JOBBOMCODE, JOBBOMSEQ) = True Then
                z7329 = D7329
		K7329_MOVE = True
		else
	z7329 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7329")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "JOBBOMCODE":z7329.JobBOMCode = Children(i).Code
   Case "JOBBOMSEQ":z7329.JobBOMSeq = Children(i).Code
   Case "DSEQ":z7329.Dseq = Children(i).Code
   Case "SEGROUPJOBPROCESS":z7329.seGroupJobProcess = Children(i).Code
   Case "CDGROUPJOBPROCESS":z7329.cdGroupJobProcess = Children(i).Code
   Case "CDJOBPROCESS":z7329.cdJobProcess = Children(i).Code
   Case "TPJOBPROCESS":z7329.tpJobProcess = Children(i).Code
   Case "SEPOSITION":z7329.sePosition = Children(i).Code
   Case "POSITIONNAME":z7329.PositionName = Children(i).Code
   Case "DESCRIPTION":z7329.Description = Children(i).Code
   Case "MATERIALCODE":z7329.MaterialCode = Children(i).Code
   Case "SUPPLIERCODE":z7329.SupplierCode = Children(i).Code
   Case "SECCT":z7329.SecCT = Children(i).Code
   Case "SECMIN":z7329.SecMin = Children(i).Code
   Case "SECMAX":z7329.SecMax = Children(i).Code
   Case "RATING":z7329.Rating = Children(i).Code
   Case "SECCTADJ":z7329.SecCTAdj = Children(i).Code
   Case "MANPOWER":z7329.ManPower = Children(i).Code
   Case "MANACTUAL":z7329.ManActual = Children(i).Code
   Case "MANSTANDARD":z7329.ManStandard = Children(i).Code
   Case "TOLARANCE":z7329.Tolarance = Children(i).Code
   Case "SECBALANCE":z7329.SecBalance = Children(i).Code
   Case "SECMAXPUT":z7329.SecMaxPut = Children(i).Code
   Case "SECOPT1":z7329.SecOpt1 = Children(i).Code
   Case "SECOPT2":z7329.SecOpt2 = Children(i).Code
   Case "SECOPT3":z7329.SecOpt3 = Children(i).Code
   Case "SECOPT4":z7329.SecOpt4 = Children(i).Code
   Case "SECOPT5":z7329.SecOpt5 = Children(i).Code
   Case "STANDARD1":z7329.Standard1 = Children(i).Code
   Case "STANDARD2":z7329.Standard2 = Children(i).Code
   Case "STANDARD3":z7329.Standard3 = Children(i).Code
   Case "STANDARD4":z7329.Standard4 = Children(i).Code
   Case "STANDARD5":z7329.Standard5 = Children(i).Code
   Case "STANDARD6":z7329.Standard6 = Children(i).Code
   Case "STANDARD7":z7329.Standard7 = Children(i).Code
   Case "STANDARD8":z7329.Standard8 = Children(i).Code
   Case "STANDARD9":z7329.Standard9 = Children(i).Code
   Case "STANDARD10":z7329.Standard10 = Children(i).Code
   Case "REMARK":z7329.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "JOBBOMCODE":z7329.JobBOMCode = Children(i).Data
   Case "JOBBOMSEQ":z7329.JobBOMSeq = Children(i).Data
   Case "DSEQ":z7329.Dseq = Children(i).Data
   Case "SEGROUPJOBPROCESS":z7329.seGroupJobProcess = Children(i).Data
   Case "CDGROUPJOBPROCESS":z7329.cdGroupJobProcess = Children(i).Data
   Case "CDJOBPROCESS":z7329.cdJobProcess = Children(i).Data
   Case "TPJOBPROCESS":z7329.tpJobProcess = Children(i).Data
   Case "SEPOSITION":z7329.sePosition = Children(i).Data
   Case "POSITIONNAME":z7329.PositionName = Children(i).Data
   Case "DESCRIPTION":z7329.Description = Children(i).Data
   Case "MATERIALCODE":z7329.MaterialCode = Children(i).Data
   Case "SUPPLIERCODE":z7329.SupplierCode = Children(i).Data
   Case "SECCT":z7329.SecCT = Children(i).Data
   Case "SECMIN":z7329.SecMin = Children(i).Data
   Case "SECMAX":z7329.SecMax = Children(i).Data
   Case "RATING":z7329.Rating = Children(i).Data
   Case "SECCTADJ":z7329.SecCTAdj = Children(i).Data
   Case "MANPOWER":z7329.ManPower = Children(i).Data
   Case "MANACTUAL":z7329.ManActual = Children(i).Data
   Case "MANSTANDARD":z7329.ManStandard = Children(i).Data
   Case "TOLARANCE":z7329.Tolarance = Children(i).Data
   Case "SECBALANCE":z7329.SecBalance = Children(i).Data
   Case "SECMAXPUT":z7329.SecMaxPut = Children(i).Data
   Case "SECOPT1":z7329.SecOpt1 = Children(i).Data
   Case "SECOPT2":z7329.SecOpt2 = Children(i).Data
   Case "SECOPT3":z7329.SecOpt3 = Children(i).Data
   Case "SECOPT4":z7329.SecOpt4 = Children(i).Data
   Case "SECOPT5":z7329.SecOpt5 = Children(i).Data
   Case "STANDARD1":z7329.Standard1 = Children(i).Data
   Case "STANDARD2":z7329.Standard2 = Children(i).Data
   Case "STANDARD3":z7329.Standard3 = Children(i).Data
   Case "STANDARD4":z7329.Standard4 = Children(i).Data
   Case "STANDARD5":z7329.Standard5 = Children(i).Data
   Case "STANDARD6":z7329.Standard6 = Children(i).Data
   Case "STANDARD7":z7329.Standard7 = Children(i).Data
   Case "STANDARD8":z7329.Standard8 = Children(i).Data
   Case "STANDARD9":z7329.Standard9 = Children(i).Data
   Case "STANDARD10":z7329.Standard10 = Children(i).Data
   Case "REMARK":z7329.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7329_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7329_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7329 As T7329_AREA, Job as String, CheckClear as Boolean, JOBBOMCODE AS String, JOBBOMSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7329_MOVE = False

Try
    If READ_PFK7329(JOBBOMCODE, JOBBOMSEQ) = True Then
                z7329 = D7329
		K7329_MOVE = True
		else
	If CheckClear  = True then z7329 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7329")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "JOBBOMCODE":z7329.JobBOMCode = Children(i).Code
   Case "JOBBOMSEQ":z7329.JobBOMSeq = Children(i).Code
   Case "DSEQ":z7329.Dseq = Children(i).Code
   Case "SEGROUPJOBPROCESS":z7329.seGroupJobProcess = Children(i).Code
   Case "CDGROUPJOBPROCESS":z7329.cdGroupJobProcess = Children(i).Code
   Case "CDJOBPROCESS":z7329.cdJobProcess = Children(i).Code
   Case "TPJOBPROCESS":z7329.tpJobProcess = Children(i).Code
   Case "SEPOSITION":z7329.sePosition = Children(i).Code
   Case "POSITIONNAME":z7329.PositionName = Children(i).Code
   Case "DESCRIPTION":z7329.Description = Children(i).Code
   Case "MATERIALCODE":z7329.MaterialCode = Children(i).Code
   Case "SUPPLIERCODE":z7329.SupplierCode = Children(i).Code
   Case "SECCT":z7329.SecCT = Children(i).Code
   Case "SECMIN":z7329.SecMin = Children(i).Code
   Case "SECMAX":z7329.SecMax = Children(i).Code
   Case "RATING":z7329.Rating = Children(i).Code
   Case "SECCTADJ":z7329.SecCTAdj = Children(i).Code
   Case "MANPOWER":z7329.ManPower = Children(i).Code
   Case "MANACTUAL":z7329.ManActual = Children(i).Code
   Case "MANSTANDARD":z7329.ManStandard = Children(i).Code
   Case "TOLARANCE":z7329.Tolarance = Children(i).Code
   Case "SECBALANCE":z7329.SecBalance = Children(i).Code
   Case "SECMAXPUT":z7329.SecMaxPut = Children(i).Code
   Case "SECOPT1":z7329.SecOpt1 = Children(i).Code
   Case "SECOPT2":z7329.SecOpt2 = Children(i).Code
   Case "SECOPT3":z7329.SecOpt3 = Children(i).Code
   Case "SECOPT4":z7329.SecOpt4 = Children(i).Code
   Case "SECOPT5":z7329.SecOpt5 = Children(i).Code
   Case "STANDARD1":z7329.Standard1 = Children(i).Code
   Case "STANDARD2":z7329.Standard2 = Children(i).Code
   Case "STANDARD3":z7329.Standard3 = Children(i).Code
   Case "STANDARD4":z7329.Standard4 = Children(i).Code
   Case "STANDARD5":z7329.Standard5 = Children(i).Code
   Case "STANDARD6":z7329.Standard6 = Children(i).Code
   Case "STANDARD7":z7329.Standard7 = Children(i).Code
   Case "STANDARD8":z7329.Standard8 = Children(i).Code
   Case "STANDARD9":z7329.Standard9 = Children(i).Code
   Case "STANDARD10":z7329.Standard10 = Children(i).Code
   Case "REMARK":z7329.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "JOBBOMCODE":z7329.JobBOMCode = Children(i).Data
   Case "JOBBOMSEQ":z7329.JobBOMSeq = Children(i).Data
   Case "DSEQ":z7329.Dseq = Children(i).Data
   Case "SEGROUPJOBPROCESS":z7329.seGroupJobProcess = Children(i).Data
   Case "CDGROUPJOBPROCESS":z7329.cdGroupJobProcess = Children(i).Data
   Case "CDJOBPROCESS":z7329.cdJobProcess = Children(i).Data
   Case "TPJOBPROCESS":z7329.tpJobProcess = Children(i).Data
   Case "SEPOSITION":z7329.sePosition = Children(i).Data
   Case "POSITIONNAME":z7329.PositionName = Children(i).Data
   Case "DESCRIPTION":z7329.Description = Children(i).Data
   Case "MATERIALCODE":z7329.MaterialCode = Children(i).Data
   Case "SUPPLIERCODE":z7329.SupplierCode = Children(i).Data
   Case "SECCT":z7329.SecCT = Children(i).Data
   Case "SECMIN":z7329.SecMin = Children(i).Data
   Case "SECMAX":z7329.SecMax = Children(i).Data
   Case "RATING":z7329.Rating = Children(i).Data
   Case "SECCTADJ":z7329.SecCTAdj = Children(i).Data
   Case "MANPOWER":z7329.ManPower = Children(i).Data
   Case "MANACTUAL":z7329.ManActual = Children(i).Data
   Case "MANSTANDARD":z7329.ManStandard = Children(i).Data
   Case "TOLARANCE":z7329.Tolarance = Children(i).Data
   Case "SECBALANCE":z7329.SecBalance = Children(i).Data
   Case "SECMAXPUT":z7329.SecMaxPut = Children(i).Data
   Case "SECOPT1":z7329.SecOpt1 = Children(i).Data
   Case "SECOPT2":z7329.SecOpt2 = Children(i).Data
   Case "SECOPT3":z7329.SecOpt3 = Children(i).Data
   Case "SECOPT4":z7329.SecOpt4 = Children(i).Data
   Case "SECOPT5":z7329.SecOpt5 = Children(i).Data
   Case "STANDARD1":z7329.Standard1 = Children(i).Data
   Case "STANDARD2":z7329.Standard2 = Children(i).Data
   Case "STANDARD3":z7329.Standard3 = Children(i).Data
   Case "STANDARD4":z7329.Standard4 = Children(i).Data
   Case "STANDARD5":z7329.Standard5 = Children(i).Data
   Case "STANDARD6":z7329.Standard6 = Children(i).Data
   Case "STANDARD7":z7329.Standard7 = Children(i).Data
   Case "STANDARD8":z7329.Standard8 = Children(i).Data
   Case "STANDARD9":z7329.Standard9 = Children(i).Data
   Case "STANDARD10":z7329.Standard10 = Children(i).Data
   Case "REMARK":z7329.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7329_MOVE",vbCritical)
End Try
End Function 
    
End Module 
