'=========================================================================================================================================================
'   TABLE : (PFK7313)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7313

Structure T7313_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	JobBOMCode	 AS String	'			nvarchar(6)		*
Public 	JobBOMSeq	 AS Double	'			decimal		*
Public 	JobBOMSno	 AS Double	'			decimal		*
Public 	Dseq	 AS Double	'			decimal
Public 	seSpecialProcess	 AS String	'			char(3)
Public 	cdSpecialProcess	 AS String	'			char(3)
Public 	CheckWidth	 AS String	'			char(1)
Public 	Width	 AS String	'			nvarchar(20)
Public 	seUnitMaterial	 AS String	'			char(3)
Public 	cdUnitMaterial	 AS String	'			char(3)
Public 	GroupComponentBOM	 AS String	'			char(6)
Public 	GroupComponentSeq	 AS Double	'			decimal
Public 	seShoesStatus	 AS String	'			char(3)
Public 	cdShoesStatus	 AS String	'			char(3)
Public 	SupplierCode	 AS String	'			char(6)
Public 	Price	 AS Double	'			decimal
Public 	MaterialAMT	 AS Double	'			decimal
Public 	Remark	 AS String	'			nvarchar(100)
'=========================================================================================================================================================
End structure

Public D7313 As T7313_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7313(JOBBOMCODE AS String, JOBBOMSEQ AS Double, JOBBOMSNO AS Double) As Boolean
    READ_PFK7313 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7313 "
    SQL = SQL & " WHERE K7313_JobBOMCode		 = '" & JobBOMCode & "' " 
    SQL = SQL & "   AND K7313_JobBOMSeq		 =  " & JobBOMSeq & "  " 
    SQL = SQL & "   AND K7313_JobBOMSno		 =  " & JobBOMSno & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7313_CLEAR: GoTo SKIP_READ_PFK7313
                
    Call K7313_MOVE(rd)
    READ_PFK7313 = True

SKIP_READ_PFK7313:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7313",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7313(JOBBOMCODE AS String, JOBBOMSEQ AS Double, JOBBOMSNO AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7313 "
    SQL = SQL & " WHERE K7313_JobBOMCode		 = '" & JobBOMCode & "' " 
    SQL = SQL & "   AND K7313_JobBOMSeq		 =  " & JobBOMSeq & "  " 
    SQL = SQL & "   AND K7313_JobBOMSno		 =  " & JobBOMSno & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7313",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7313(z7313 As T7313_AREA) As Boolean
    WRITE_PFK7313 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7313)
 
    SQL = " INSERT INTO PFK7313 "
    SQL = SQL & " ( "
    SQL = SQL & " K7313_JobBOMCode," 
    SQL = SQL & " K7313_JobBOMSeq," 
    SQL = SQL & " K7313_JobBOMSno," 
    SQL = SQL & " K7313_Dseq," 
    SQL = SQL & " K7313_seSpecialProcess," 
    SQL = SQL & " K7313_cdSpecialProcess," 
    SQL = SQL & " K7313_CheckWidth," 
    SQL = SQL & " K7313_Width," 
    SQL = SQL & " K7313_seUnitMaterial," 
    SQL = SQL & " K7313_cdUnitMaterial," 
    SQL = SQL & " K7313_GroupComponentBOM," 
    SQL = SQL & " K7313_GroupComponentSeq," 
    SQL = SQL & " K7313_seShoesStatus," 
    SQL = SQL & " K7313_cdShoesStatus," 
    SQL = SQL & " K7313_SupplierCode," 
    SQL = SQL & " K7313_Price," 
    SQL = SQL & " K7313_MaterialAMT," 
    SQL = SQL & " K7313_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7313.JobBOMCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z7313.JobBOMSeq) & ", "  
    SQL = SQL & "   " & FormatSQL(z7313.JobBOMSno) & ", "  
    SQL = SQL & "   " & FormatSQL(z7313.Dseq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7313.seSpecialProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7313.cdSpecialProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7313.CheckWidth) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7313.Width) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7313.seUnitMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7313.cdUnitMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7313.GroupComponentBOM) & "', "  
    SQL = SQL & "   " & FormatSQL(z7313.GroupComponentSeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7313.seShoesStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7313.cdShoesStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7313.SupplierCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z7313.Price) & ", "  
    SQL = SQL & "   " & FormatSQL(z7313.MaterialAMT) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7313.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7313 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7313",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7313(z7313 As T7313_AREA) As Boolean
    REWRITE_PFK7313 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7313)
   
    SQL = " UPDATE PFK7313 SET "
    SQL = SQL & "    K7313_Dseq      =  " & FormatSQL(z7313.Dseq) & ", " 
    SQL = SQL & "    K7313_seSpecialProcess      = N'" & FormatSQL(z7313.seSpecialProcess) & "', " 
    SQL = SQL & "    K7313_cdSpecialProcess      = N'" & FormatSQL(z7313.cdSpecialProcess) & "', " 
    SQL = SQL & "    K7313_CheckWidth      = N'" & FormatSQL(z7313.CheckWidth) & "', " 
    SQL = SQL & "    K7313_Width      = N'" & FormatSQL(z7313.Width) & "', " 
    SQL = SQL & "    K7313_seUnitMaterial      = N'" & FormatSQL(z7313.seUnitMaterial) & "', " 
    SQL = SQL & "    K7313_cdUnitMaterial      = N'" & FormatSQL(z7313.cdUnitMaterial) & "', " 
    SQL = SQL & "    K7313_GroupComponentBOM      = N'" & FormatSQL(z7313.GroupComponentBOM) & "', " 
    SQL = SQL & "    K7313_GroupComponentSeq      =  " & FormatSQL(z7313.GroupComponentSeq) & ", " 
    SQL = SQL & "    K7313_seShoesStatus      = N'" & FormatSQL(z7313.seShoesStatus) & "', " 
    SQL = SQL & "    K7313_cdShoesStatus      = N'" & FormatSQL(z7313.cdShoesStatus) & "', " 
    SQL = SQL & "    K7313_SupplierCode      = N'" & FormatSQL(z7313.SupplierCode) & "', " 
    SQL = SQL & "    K7313_Price      =  " & FormatSQL(z7313.Price) & ", " 
    SQL = SQL & "    K7313_MaterialAMT      =  " & FormatSQL(z7313.MaterialAMT) & ", " 
    SQL = SQL & "    K7313_Remark      = N'" & FormatSQL(z7313.Remark) & "'  " 
    SQL = SQL & " WHERE K7313_JobBOMCode		 = '" & z7313.JobBOMCode & "' " 
    SQL = SQL & "   AND K7313_JobBOMSeq		 =  " & z7313.JobBOMSeq & "  " 
    SQL = SQL & "   AND K7313_JobBOMSno		 =  " & z7313.JobBOMSno & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7313 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7313",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7313(z7313 As T7313_AREA) As Boolean
    DELETE_PFK7313 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7313 "
    SQL = SQL & " WHERE K7313_JobBOMCode		 = '" & z7313.JobBOMCode & "' " 
    SQL = SQL & "   AND K7313_JobBOMSeq		 =  " & z7313.JobBOMSeq & "  " 
    SQL = SQL & "   AND K7313_JobBOMSno		 =  " & z7313.JobBOMSno & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7313 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7313",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7313_CLEAR()
Try
    
   D7313.JobBOMCode = ""
    D7313.JobBOMSeq = 0 
    D7313.JobBOMSno = 0 
    D7313.Dseq = 0 
   D7313.seSpecialProcess = ""
   D7313.cdSpecialProcess = ""
   D7313.CheckWidth = ""
   D7313.Width = ""
   D7313.seUnitMaterial = ""
   D7313.cdUnitMaterial = ""
   D7313.GroupComponentBOM = ""
    D7313.GroupComponentSeq = 0 
   D7313.seShoesStatus = ""
   D7313.cdShoesStatus = ""
   D7313.SupplierCode = ""
    D7313.Price = 0 
    D7313.MaterialAMT = 0 
   D7313.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7313_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7313 As T7313_AREA)
Try
    
    x7313.JobBOMCode = trim$(  x7313.JobBOMCode)
    x7313.JobBOMSeq = trim$(  x7313.JobBOMSeq)
    x7313.JobBOMSno = trim$(  x7313.JobBOMSno)
    x7313.Dseq = trim$(  x7313.Dseq)
    x7313.seSpecialProcess = trim$(  x7313.seSpecialProcess)
    x7313.cdSpecialProcess = trim$(  x7313.cdSpecialProcess)
    x7313.CheckWidth = trim$(  x7313.CheckWidth)
    x7313.Width = trim$(  x7313.Width)
    x7313.seUnitMaterial = trim$(  x7313.seUnitMaterial)
    x7313.cdUnitMaterial = trim$(  x7313.cdUnitMaterial)
    x7313.GroupComponentBOM = trim$(  x7313.GroupComponentBOM)
    x7313.GroupComponentSeq = trim$(  x7313.GroupComponentSeq)
    x7313.seShoesStatus = trim$(  x7313.seShoesStatus)
    x7313.cdShoesStatus = trim$(  x7313.cdShoesStatus)
    x7313.SupplierCode = trim$(  x7313.SupplierCode)
    x7313.Price = trim$(  x7313.Price)
    x7313.MaterialAMT = trim$(  x7313.MaterialAMT)
    x7313.Remark = trim$(  x7313.Remark)
     
    If trim$( x7313.JobBOMCode ) = "" Then x7313.JobBOMCode = Space(1) 
    If trim$( x7313.JobBOMSeq ) = "" Then x7313.JobBOMSeq = 0 
    If trim$( x7313.JobBOMSno ) = "" Then x7313.JobBOMSno = 0 
    If trim$( x7313.Dseq ) = "" Then x7313.Dseq = 0 
    If trim$( x7313.seSpecialProcess ) = "" Then x7313.seSpecialProcess = Space(1) 
    If trim$( x7313.cdSpecialProcess ) = "" Then x7313.cdSpecialProcess = Space(1) 
    If trim$( x7313.CheckWidth ) = "" Then x7313.CheckWidth = Space(1) 
    If trim$( x7313.Width ) = "" Then x7313.Width = Space(1) 
    If trim$( x7313.seUnitMaterial ) = "" Then x7313.seUnitMaterial = Space(1) 
    If trim$( x7313.cdUnitMaterial ) = "" Then x7313.cdUnitMaterial = Space(1) 
    If trim$( x7313.GroupComponentBOM ) = "" Then x7313.GroupComponentBOM = Space(1) 
    If trim$( x7313.GroupComponentSeq ) = "" Then x7313.GroupComponentSeq = 0 
    If trim$( x7313.seShoesStatus ) = "" Then x7313.seShoesStatus = Space(1) 
    If trim$( x7313.cdShoesStatus ) = "" Then x7313.cdShoesStatus = Space(1) 
    If trim$( x7313.SupplierCode ) = "" Then x7313.SupplierCode = Space(1) 
    If trim$( x7313.Price ) = "" Then x7313.Price = 0 
    If trim$( x7313.MaterialAMT ) = "" Then x7313.MaterialAMT = 0 
    If trim$( x7313.Remark ) = "" Then x7313.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7313_MOVE(rs7313 As SqlClient.SqlDataReader)
Try

    call D7313_CLEAR()   

    If IsdbNull(rs7313!K7313_JobBOMCode) = False Then D7313.JobBOMCode = Trim$(rs7313!K7313_JobBOMCode)
    If IsdbNull(rs7313!K7313_JobBOMSeq) = False Then D7313.JobBOMSeq = Trim$(rs7313!K7313_JobBOMSeq)
    If IsdbNull(rs7313!K7313_JobBOMSno) = False Then D7313.JobBOMSno = Trim$(rs7313!K7313_JobBOMSno)
    If IsdbNull(rs7313!K7313_Dseq) = False Then D7313.Dseq = Trim$(rs7313!K7313_Dseq)
    If IsdbNull(rs7313!K7313_seSpecialProcess) = False Then D7313.seSpecialProcess = Trim$(rs7313!K7313_seSpecialProcess)
    If IsdbNull(rs7313!K7313_cdSpecialProcess) = False Then D7313.cdSpecialProcess = Trim$(rs7313!K7313_cdSpecialProcess)
    If IsdbNull(rs7313!K7313_CheckWidth) = False Then D7313.CheckWidth = Trim$(rs7313!K7313_CheckWidth)
    If IsdbNull(rs7313!K7313_Width) = False Then D7313.Width = Trim$(rs7313!K7313_Width)
    If IsdbNull(rs7313!K7313_seUnitMaterial) = False Then D7313.seUnitMaterial = Trim$(rs7313!K7313_seUnitMaterial)
    If IsdbNull(rs7313!K7313_cdUnitMaterial) = False Then D7313.cdUnitMaterial = Trim$(rs7313!K7313_cdUnitMaterial)
    If IsdbNull(rs7313!K7313_GroupComponentBOM) = False Then D7313.GroupComponentBOM = Trim$(rs7313!K7313_GroupComponentBOM)
    If IsdbNull(rs7313!K7313_GroupComponentSeq) = False Then D7313.GroupComponentSeq = Trim$(rs7313!K7313_GroupComponentSeq)
    If IsdbNull(rs7313!K7313_seShoesStatus) = False Then D7313.seShoesStatus = Trim$(rs7313!K7313_seShoesStatus)
    If IsdbNull(rs7313!K7313_cdShoesStatus) = False Then D7313.cdShoesStatus = Trim$(rs7313!K7313_cdShoesStatus)
    If IsdbNull(rs7313!K7313_SupplierCode) = False Then D7313.SupplierCode = Trim$(rs7313!K7313_SupplierCode)
    If IsdbNull(rs7313!K7313_Price) = False Then D7313.Price = Trim$(rs7313!K7313_Price)
    If IsdbNull(rs7313!K7313_MaterialAMT) = False Then D7313.MaterialAMT = Trim$(rs7313!K7313_MaterialAMT)
    If IsdbNull(rs7313!K7313_Remark) = False Then D7313.Remark = Trim$(rs7313!K7313_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7313_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7313_MOVE(rs7313 As DataRow)
Try

    call D7313_CLEAR()   

    If IsdbNull(rs7313!K7313_JobBOMCode) = False Then D7313.JobBOMCode = Trim$(rs7313!K7313_JobBOMCode)
    If IsdbNull(rs7313!K7313_JobBOMSeq) = False Then D7313.JobBOMSeq = Trim$(rs7313!K7313_JobBOMSeq)
    If IsdbNull(rs7313!K7313_JobBOMSno) = False Then D7313.JobBOMSno = Trim$(rs7313!K7313_JobBOMSno)
    If IsdbNull(rs7313!K7313_Dseq) = False Then D7313.Dseq = Trim$(rs7313!K7313_Dseq)
    If IsdbNull(rs7313!K7313_seSpecialProcess) = False Then D7313.seSpecialProcess = Trim$(rs7313!K7313_seSpecialProcess)
    If IsdbNull(rs7313!K7313_cdSpecialProcess) = False Then D7313.cdSpecialProcess = Trim$(rs7313!K7313_cdSpecialProcess)
    If IsdbNull(rs7313!K7313_CheckWidth) = False Then D7313.CheckWidth = Trim$(rs7313!K7313_CheckWidth)
    If IsdbNull(rs7313!K7313_Width) = False Then D7313.Width = Trim$(rs7313!K7313_Width)
    If IsdbNull(rs7313!K7313_seUnitMaterial) = False Then D7313.seUnitMaterial = Trim$(rs7313!K7313_seUnitMaterial)
    If IsdbNull(rs7313!K7313_cdUnitMaterial) = False Then D7313.cdUnitMaterial = Trim$(rs7313!K7313_cdUnitMaterial)
    If IsdbNull(rs7313!K7313_GroupComponentBOM) = False Then D7313.GroupComponentBOM = Trim$(rs7313!K7313_GroupComponentBOM)
    If IsdbNull(rs7313!K7313_GroupComponentSeq) = False Then D7313.GroupComponentSeq = Trim$(rs7313!K7313_GroupComponentSeq)
    If IsdbNull(rs7313!K7313_seShoesStatus) = False Then D7313.seShoesStatus = Trim$(rs7313!K7313_seShoesStatus)
    If IsdbNull(rs7313!K7313_cdShoesStatus) = False Then D7313.cdShoesStatus = Trim$(rs7313!K7313_cdShoesStatus)
    If IsdbNull(rs7313!K7313_SupplierCode) = False Then D7313.SupplierCode = Trim$(rs7313!K7313_SupplierCode)
    If IsdbNull(rs7313!K7313_Price) = False Then D7313.Price = Trim$(rs7313!K7313_Price)
    If IsdbNull(rs7313!K7313_MaterialAMT) = False Then D7313.MaterialAMT = Trim$(rs7313!K7313_MaterialAMT)
    If IsdbNull(rs7313!K7313_Remark) = False Then D7313.Remark = Trim$(rs7313!K7313_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7313_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7313_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7313 As T7313_AREA, JOBBOMCODE AS String, JOBBOMSEQ AS Double, JOBBOMSNO AS Double) as Boolean

K7313_MOVE = False

Try
    If READ_PFK7313(JOBBOMCODE, JOBBOMSEQ, JOBBOMSNO) = True Then
                z7313 = D7313
		K7313_MOVE = True
		else
	z7313 = nothing
     End If

     If  getColumIndex(spr,"JobBOMCode") > -1 then z7313.JobBOMCode = getDataM(spr, getColumIndex(spr,"JobBOMCode"), xRow)
     If  getColumIndex(spr,"JobBOMSeq") > -1 then z7313.JobBOMSeq = getDataM(spr, getColumIndex(spr,"JobBOMSeq"), xRow)
     If  getColumIndex(spr,"JobBOMSno") > -1 then z7313.JobBOMSno = getDataM(spr, getColumIndex(spr,"JobBOMSno"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z7313.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"seSpecialProcess") > -1 then z7313.seSpecialProcess = getDataM(spr, getColumIndex(spr,"seSpecialProcess"), xRow)
     If  getColumIndex(spr,"cdSpecialProcess") > -1 then z7313.cdSpecialProcess = getDataM(spr, getColumIndex(spr,"cdSpecialProcess"), xRow)
     If  getColumIndex(spr,"CheckWidth") > -1 then z7313.CheckWidth = getDataM(spr, getColumIndex(spr,"CheckWidth"), xRow)
     If  getColumIndex(spr,"Width") > -1 then z7313.Width = getDataM(spr, getColumIndex(spr,"Width"), xRow)
     If  getColumIndex(spr,"seUnitMaterial") > -1 then z7313.seUnitMaterial = getDataM(spr, getColumIndex(spr,"seUnitMaterial"), xRow)
     If  getColumIndex(spr,"cdUnitMaterial") > -1 then z7313.cdUnitMaterial = getDataM(spr, getColumIndex(spr,"cdUnitMaterial"), xRow)
     If  getColumIndex(spr,"GroupComponentBOM") > -1 then z7313.GroupComponentBOM = getDataM(spr, getColumIndex(spr,"GroupComponentBOM"), xRow)
     If  getColumIndex(spr,"GroupComponentSeq") > -1 then z7313.GroupComponentSeq = getDataM(spr, getColumIndex(spr,"GroupComponentSeq"), xRow)
     If  getColumIndex(spr,"seShoesStatus") > -1 then z7313.seShoesStatus = getDataM(spr, getColumIndex(spr,"seShoesStatus"), xRow)
     If  getColumIndex(spr,"cdShoesStatus") > -1 then z7313.cdShoesStatus = getDataM(spr, getColumIndex(spr,"cdShoesStatus"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z7313.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"Price") > -1 then z7313.Price = getDataM(spr, getColumIndex(spr,"Price"), xRow)
     If  getColumIndex(spr,"MaterialAMT") > -1 then z7313.MaterialAMT = getDataM(spr, getColumIndex(spr,"MaterialAMT"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7313.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7313_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7313_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7313 As T7313_AREA,CheckClear as Boolean,JOBBOMCODE AS String, JOBBOMSEQ AS Double, JOBBOMSNO AS Double) as Boolean

K7313_MOVE = False

Try
    If READ_PFK7313(JOBBOMCODE, JOBBOMSEQ, JOBBOMSNO) = True Then
                z7313 = D7313
		K7313_MOVE = True
		else
	If CheckClear  = True then z7313 = nothing
     End If

     If  getColumIndex(spr,"JobBOMCode") > -1 then z7313.JobBOMCode = getDataM(spr, getColumIndex(spr,"JobBOMCode"), xRow)
     If  getColumIndex(spr,"JobBOMSeq") > -1 then z7313.JobBOMSeq = getDataM(spr, getColumIndex(spr,"JobBOMSeq"), xRow)
     If  getColumIndex(spr,"JobBOMSno") > -1 then z7313.JobBOMSno = getDataM(spr, getColumIndex(spr,"JobBOMSno"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z7313.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"seSpecialProcess") > -1 then z7313.seSpecialProcess = getDataM(spr, getColumIndex(spr,"seSpecialProcess"), xRow)
     If  getColumIndex(spr,"cdSpecialProcess") > -1 then z7313.cdSpecialProcess = getDataM(spr, getColumIndex(spr,"cdSpecialProcess"), xRow)
     If  getColumIndex(spr,"CheckWidth") > -1 then z7313.CheckWidth = getDataM(spr, getColumIndex(spr,"CheckWidth"), xRow)
     If  getColumIndex(spr,"Width") > -1 then z7313.Width = getDataM(spr, getColumIndex(spr,"Width"), xRow)
     If  getColumIndex(spr,"seUnitMaterial") > -1 then z7313.seUnitMaterial = getDataM(spr, getColumIndex(spr,"seUnitMaterial"), xRow)
     If  getColumIndex(spr,"cdUnitMaterial") > -1 then z7313.cdUnitMaterial = getDataM(spr, getColumIndex(spr,"cdUnitMaterial"), xRow)
     If  getColumIndex(spr,"GroupComponentBOM") > -1 then z7313.GroupComponentBOM = getDataM(spr, getColumIndex(spr,"GroupComponentBOM"), xRow)
     If  getColumIndex(spr,"GroupComponentSeq") > -1 then z7313.GroupComponentSeq = getDataM(spr, getColumIndex(spr,"GroupComponentSeq"), xRow)
     If  getColumIndex(spr,"seShoesStatus") > -1 then z7313.seShoesStatus = getDataM(spr, getColumIndex(spr,"seShoesStatus"), xRow)
     If  getColumIndex(spr,"cdShoesStatus") > -1 then z7313.cdShoesStatus = getDataM(spr, getColumIndex(spr,"cdShoesStatus"), xRow)
     If  getColumIndex(spr,"SupplierCode") > -1 then z7313.SupplierCode = getDataM(spr, getColumIndex(spr,"SupplierCode"), xRow)
     If  getColumIndex(spr,"Price") > -1 then z7313.Price = getDataM(spr, getColumIndex(spr,"Price"), xRow)
     If  getColumIndex(spr,"MaterialAMT") > -1 then z7313.MaterialAMT = getDataM(spr, getColumIndex(spr,"MaterialAMT"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7313.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7313_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7313_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7313 As T7313_AREA, Job as String, JOBBOMCODE AS String, JOBBOMSEQ AS Double, JOBBOMSNO AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7313_MOVE = False

Try
    If READ_PFK7313(JOBBOMCODE, JOBBOMSEQ, JOBBOMSNO) = True Then
                z7313 = D7313
		K7313_MOVE = True
		else
	z7313 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7313")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "JOBBOMCODE":z7313.JobBOMCode = Children(i).Code
   Case "JOBBOMSEQ":z7313.JobBOMSeq = Children(i).Code
   Case "JOBBOMSNO":z7313.JobBOMSno = Children(i).Code
   Case "DSEQ":z7313.Dseq = Children(i).Code
   Case "SESPECIALPROCESS":z7313.seSpecialProcess = Children(i).Code
   Case "CDSPECIALPROCESS":z7313.cdSpecialProcess = Children(i).Code
   Case "CHECKWIDTH":z7313.CheckWidth = Children(i).Code
   Case "WIDTH":z7313.Width = Children(i).Code
   Case "SEUNITMATERIAL":z7313.seUnitMaterial = Children(i).Code
   Case "CDUNITMATERIAL":z7313.cdUnitMaterial = Children(i).Code
   Case "GROUPCOMPONENTBOM":z7313.GroupComponentBOM = Children(i).Code
   Case "GROUPCOMPONENTSEQ":z7313.GroupComponentSeq = Children(i).Code
   Case "SESHOESSTATUS":z7313.seShoesStatus = Children(i).Code
   Case "CDSHOESSTATUS":z7313.cdShoesStatus = Children(i).Code
   Case "SUPPLIERCODE":z7313.SupplierCode = Children(i).Code
   Case "PRICE":z7313.Price = Children(i).Code
   Case "MATERIALAMT":z7313.MaterialAMT = Children(i).Code
   Case "REMARK":z7313.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "JOBBOMCODE":z7313.JobBOMCode = Children(i).Data
   Case "JOBBOMSEQ":z7313.JobBOMSeq = Children(i).Data
   Case "JOBBOMSNO":z7313.JobBOMSno = Children(i).Data
   Case "DSEQ":z7313.Dseq = Children(i).Data
   Case "SESPECIALPROCESS":z7313.seSpecialProcess = Children(i).Data
   Case "CDSPECIALPROCESS":z7313.cdSpecialProcess = Children(i).Data
   Case "CHECKWIDTH":z7313.CheckWidth = Children(i).Data
   Case "WIDTH":z7313.Width = Children(i).Data
   Case "SEUNITMATERIAL":z7313.seUnitMaterial = Children(i).Data
   Case "CDUNITMATERIAL":z7313.cdUnitMaterial = Children(i).Data
   Case "GROUPCOMPONENTBOM":z7313.GroupComponentBOM = Children(i).Data
   Case "GROUPCOMPONENTSEQ":z7313.GroupComponentSeq = Children(i).Data
   Case "SESHOESSTATUS":z7313.seShoesStatus = Children(i).Data
   Case "CDSHOESSTATUS":z7313.cdShoesStatus = Children(i).Data
   Case "SUPPLIERCODE":z7313.SupplierCode = Children(i).Data
   Case "PRICE":z7313.Price = Children(i).Data
   Case "MATERIALAMT":z7313.MaterialAMT = Children(i).Data
   Case "REMARK":z7313.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7313_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7313_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7313 As T7313_AREA, Job as String, CheckClear as Boolean, JOBBOMCODE AS String, JOBBOMSEQ AS Double, JOBBOMSNO AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7313_MOVE = False

Try
    If READ_PFK7313(JOBBOMCODE, JOBBOMSEQ, JOBBOMSNO) = True Then
                z7313 = D7313
		K7313_MOVE = True
		else
	If CheckClear  = True then z7313 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7313")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "JOBBOMCODE":z7313.JobBOMCode = Children(i).Code
   Case "JOBBOMSEQ":z7313.JobBOMSeq = Children(i).Code
   Case "JOBBOMSNO":z7313.JobBOMSno = Children(i).Code
   Case "DSEQ":z7313.Dseq = Children(i).Code
   Case "SESPECIALPROCESS":z7313.seSpecialProcess = Children(i).Code
   Case "CDSPECIALPROCESS":z7313.cdSpecialProcess = Children(i).Code
   Case "CHECKWIDTH":z7313.CheckWidth = Children(i).Code
   Case "WIDTH":z7313.Width = Children(i).Code
   Case "SEUNITMATERIAL":z7313.seUnitMaterial = Children(i).Code
   Case "CDUNITMATERIAL":z7313.cdUnitMaterial = Children(i).Code
   Case "GROUPCOMPONENTBOM":z7313.GroupComponentBOM = Children(i).Code
   Case "GROUPCOMPONENTSEQ":z7313.GroupComponentSeq = Children(i).Code
   Case "SESHOESSTATUS":z7313.seShoesStatus = Children(i).Code
   Case "CDSHOESSTATUS":z7313.cdShoesStatus = Children(i).Code
   Case "SUPPLIERCODE":z7313.SupplierCode = Children(i).Code
   Case "PRICE":z7313.Price = Children(i).Code
   Case "MATERIALAMT":z7313.MaterialAMT = Children(i).Code
   Case "REMARK":z7313.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "JOBBOMCODE":z7313.JobBOMCode = Children(i).Data
   Case "JOBBOMSEQ":z7313.JobBOMSeq = Children(i).Data
   Case "JOBBOMSNO":z7313.JobBOMSno = Children(i).Data
   Case "DSEQ":z7313.Dseq = Children(i).Data
   Case "SESPECIALPROCESS":z7313.seSpecialProcess = Children(i).Data
   Case "CDSPECIALPROCESS":z7313.cdSpecialProcess = Children(i).Data
   Case "CHECKWIDTH":z7313.CheckWidth = Children(i).Data
   Case "WIDTH":z7313.Width = Children(i).Data
   Case "SEUNITMATERIAL":z7313.seUnitMaterial = Children(i).Data
   Case "CDUNITMATERIAL":z7313.cdUnitMaterial = Children(i).Data
   Case "GROUPCOMPONENTBOM":z7313.GroupComponentBOM = Children(i).Data
   Case "GROUPCOMPONENTSEQ":z7313.GroupComponentSeq = Children(i).Data
   Case "SESHOESSTATUS":z7313.seShoesStatus = Children(i).Data
   Case "CDSHOESSTATUS":z7313.cdShoesStatus = Children(i).Data
   Case "SUPPLIERCODE":z7313.SupplierCode = Children(i).Data
   Case "PRICE":z7313.Price = Children(i).Data
   Case "MATERIALAMT":z7313.MaterialAMT = Children(i).Data
   Case "REMARK":z7313.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7313_MOVE",vbCritical)
End Try
End Function 
    
End Module 
