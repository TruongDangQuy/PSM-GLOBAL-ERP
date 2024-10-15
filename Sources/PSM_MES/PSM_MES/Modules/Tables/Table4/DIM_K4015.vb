'=========================================================================================================================================================
'   TABLE : (PFK4015)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K4015

Structure T4015_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	JobCard	 AS String	'			char(9)		*
Public 	BarcodeSeq	 AS Double	'			decimal		*
Public 	SizeNo	 AS String	'			char(2)
Public 	Barcode	 AS String	'			char(11)
Public 	BarcodeScan	 AS String	'			char(11)
Public 	DateStitching	 AS String	'			char(8)
Public 	DateStitchingPosted	 AS String	'			char(8)
Public 	CheckStitchingL	 AS String	'			char(1)
Public 	CheckStitchingR	 AS String	'			char(1)
Public 	CheckCompleteStitching	 AS String	'			char(1)
Public 	QtyStitching	 AS Double	'			decimal
Public 	QtyStitchingA	 AS Double	'			decimal
Public 	QtyStitchingX	 AS Double	'			decimal
Public 	QtyStitchingBLOut	 AS Double	'			decimal
Public 	QtyStitchingBLIn	 AS Double	'			decimal
Public 	DateAssembly	 AS String	'			char(8)
Public 	DateAssemblyPosted	 AS String	'			char(8)
Public 	CheckAssemblyL	 AS String	'			char(1)
Public 	CheckAssemblyR	 AS String	'			char(1)
Public 	CheckCompleteAssembly	 AS String	'			char(1)
Public 	QtyAssembly	 AS Double	'			decimal
Public 	QtyAssemblyA	 AS Double	'			decimal
Public 	QtyAssemblyX	 AS Double	'			decimal
Public 	QtyAssemblyBLOut	 AS Double	'			decimal
Public 	QtyAssemblyBLIn	 AS Double	'			decimal
Public 	DatePacking	 AS String	'			char(8)
Public 	DatePackingPosted	 AS String	'			char(8)
Public 	CheckPackingL	 AS String	'			char(1)
Public 	CheckPackingR	 AS String	'			char(1)
Public 	CheckCompletePacking	 AS String	'			char(1)
Public 	QtyPacking	 AS Double	'			decimal
Public 	QtyPackingA	 AS Double	'			decimal
Public 	QtyPackingX	 AS Double	'			decimal
Public 	QtyPackingBLOut	 AS Double	'			decimal
Public 	QtyPackingBLIn	 AS Double	'			decimal
Public 	DateInsert	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(6)
Public 	DateUpdate	 AS String	'			char(8)
Public 	Remark	 AS String	'			nvarchar(50)
'=========================================================================================================================================================
End structure

Public D4015 As T4015_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK4015(JOBCARD AS String, BARCODESEQ AS Double) As Boolean
    READ_PFK4015 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4015 "
    SQL = SQL & " WHERE K4015_JobCard		 = '" & JobCard & "' " 
    SQL = SQL & "   AND K4015_BarcodeSeq		 =  " & BarcodeSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D4015_CLEAR: GoTo SKIP_READ_PFK4015
                
    Call K4015_MOVE(rd)
    READ_PFK4015 = True

SKIP_READ_PFK4015:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK4015",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK4015(JOBCARD AS String, BARCODESEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4015 "
    SQL = SQL & " WHERE K4015_JobCard		 = '" & JobCard & "' " 
    SQL = SQL & "   AND K4015_BarcodeSeq		 =  " & BarcodeSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK4015",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK4015(z4015 As T4015_AREA) As Boolean
    WRITE_PFK4015 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z4015)
 
    SQL = " INSERT INTO PFK4015 "
    SQL = SQL & " ( "
    SQL = SQL & " K4015_JobCard," 
    SQL = SQL & " K4015_BarcodeSeq," 
    SQL = SQL & " K4015_SizeNo," 
    SQL = SQL & " K4015_Barcode," 
    SQL = SQL & " K4015_BarcodeScan," 
    SQL = SQL & " K4015_DateStitching," 
    SQL = SQL & " K4015_DateStitchingPosted," 
    SQL = SQL & " K4015_CheckStitchingL," 
    SQL = SQL & " K4015_CheckStitchingR," 
    SQL = SQL & " K4015_CheckCompleteStitching," 
    SQL = SQL & " K4015_QtyStitching," 
    SQL = SQL & " K4015_QtyStitchingA," 
    SQL = SQL & " K4015_QtyStitchingX," 
    SQL = SQL & " K4015_QtyStitchingBLOut," 
    SQL = SQL & " K4015_QtyStitchingBLIn," 
    SQL = SQL & " K4015_DateAssembly," 
    SQL = SQL & " K4015_DateAssemblyPosted," 
    SQL = SQL & " K4015_CheckAssemblyL," 
    SQL = SQL & " K4015_CheckAssemblyR," 
    SQL = SQL & " K4015_CheckCompleteAssembly," 
    SQL = SQL & " K4015_QtyAssembly," 
    SQL = SQL & " K4015_QtyAssemblyA," 
    SQL = SQL & " K4015_QtyAssemblyX," 
    SQL = SQL & " K4015_QtyAssemblyBLOut," 
    SQL = SQL & " K4015_QtyAssemblyBLIn," 
    SQL = SQL & " K4015_DatePacking," 
    SQL = SQL & " K4015_DatePackingPosted," 
    SQL = SQL & " K4015_CheckPackingL," 
    SQL = SQL & " K4015_CheckPackingR," 
    SQL = SQL & " K4015_CheckCompletePacking," 
    SQL = SQL & " K4015_QtyPacking," 
    SQL = SQL & " K4015_QtyPackingA," 
    SQL = SQL & " K4015_QtyPackingX," 
    SQL = SQL & " K4015_QtyPackingBLOut," 
    SQL = SQL & " K4015_QtyPackingBLIn," 
    SQL = SQL & " K4015_DateInsert," 
    SQL = SQL & " K4015_InchargeInsert," 
    SQL = SQL & " K4015_DateUpdate," 
    SQL = SQL & " K4015_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z4015.JobCard) & "', "  
    SQL = SQL & "   " & FormatSQL(z4015.BarcodeSeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4015.SizeNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4015.Barcode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4015.BarcodeScan) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4015.DateStitching) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4015.DateStitchingPosted) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4015.CheckStitchingL) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4015.CheckStitchingR) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4015.CheckCompleteStitching) & "', "  
    SQL = SQL & "   " & FormatSQL(z4015.QtyStitching) & ", "  
    SQL = SQL & "   " & FormatSQL(z4015.QtyStitchingA) & ", "  
    SQL = SQL & "   " & FormatSQL(z4015.QtyStitchingX) & ", "  
    SQL = SQL & "   " & FormatSQL(z4015.QtyStitchingBLOut) & ", "  
    SQL = SQL & "   " & FormatSQL(z4015.QtyStitchingBLIn) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4015.DateAssembly) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4015.DateAssemblyPosted) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4015.CheckAssemblyL) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4015.CheckAssemblyR) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4015.CheckCompleteAssembly) & "', "  
    SQL = SQL & "   " & FormatSQL(z4015.QtyAssembly) & ", "  
    SQL = SQL & "   " & FormatSQL(z4015.QtyAssemblyA) & ", "  
    SQL = SQL & "   " & FormatSQL(z4015.QtyAssemblyX) & ", "  
    SQL = SQL & "   " & FormatSQL(z4015.QtyAssemblyBLOut) & ", "  
    SQL = SQL & "   " & FormatSQL(z4015.QtyAssemblyBLIn) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4015.DatePacking) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4015.DatePackingPosted) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4015.CheckPackingL) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4015.CheckPackingR) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4015.CheckCompletePacking) & "', "  
    SQL = SQL & "   " & FormatSQL(z4015.QtyPacking) & ", "  
    SQL = SQL & "   " & FormatSQL(z4015.QtyPackingA) & ", "  
    SQL = SQL & "   " & FormatSQL(z4015.QtyPackingX) & ", "  
    SQL = SQL & "   " & FormatSQL(z4015.QtyPackingBLOut) & ", "  
    SQL = SQL & "   " & FormatSQL(z4015.QtyPackingBLIn) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4015.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4015.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4015.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4015.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK4015 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK4015",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK4015(z4015 As T4015_AREA) As Boolean
    REWRITE_PFK4015 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z4015)
   
    SQL = " UPDATE PFK4015 SET "
    SQL = SQL & "    K4015_SizeNo      = N'" & FormatSQL(z4015.SizeNo) & "', " 
    SQL = SQL & "    K4015_Barcode      = N'" & FormatSQL(z4015.Barcode) & "', " 
    SQL = SQL & "    K4015_BarcodeScan      = N'" & FormatSQL(z4015.BarcodeScan) & "', " 
    SQL = SQL & "    K4015_DateStitching      = N'" & FormatSQL(z4015.DateStitching) & "', " 
    SQL = SQL & "    K4015_DateStitchingPosted      = N'" & FormatSQL(z4015.DateStitchingPosted) & "', " 
    SQL = SQL & "    K4015_CheckStitchingL      = N'" & FormatSQL(z4015.CheckStitchingL) & "', " 
    SQL = SQL & "    K4015_CheckStitchingR      = N'" & FormatSQL(z4015.CheckStitchingR) & "', " 
    SQL = SQL & "    K4015_CheckCompleteStitching      = N'" & FormatSQL(z4015.CheckCompleteStitching) & "', " 
    SQL = SQL & "    K4015_QtyStitching      =  " & FormatSQL(z4015.QtyStitching) & ", " 
    SQL = SQL & "    K4015_QtyStitchingA      =  " & FormatSQL(z4015.QtyStitchingA) & ", " 
    SQL = SQL & "    K4015_QtyStitchingX      =  " & FormatSQL(z4015.QtyStitchingX) & ", " 
    SQL = SQL & "    K4015_QtyStitchingBLOut      =  " & FormatSQL(z4015.QtyStitchingBLOut) & ", " 
    SQL = SQL & "    K4015_QtyStitchingBLIn      =  " & FormatSQL(z4015.QtyStitchingBLIn) & ", " 
    SQL = SQL & "    K4015_DateAssembly      = N'" & FormatSQL(z4015.DateAssembly) & "', " 
    SQL = SQL & "    K4015_DateAssemblyPosted      = N'" & FormatSQL(z4015.DateAssemblyPosted) & "', " 
    SQL = SQL & "    K4015_CheckAssemblyL      = N'" & FormatSQL(z4015.CheckAssemblyL) & "', " 
    SQL = SQL & "    K4015_CheckAssemblyR      = N'" & FormatSQL(z4015.CheckAssemblyR) & "', " 
    SQL = SQL & "    K4015_CheckCompleteAssembly      = N'" & FormatSQL(z4015.CheckCompleteAssembly) & "', " 
    SQL = SQL & "    K4015_QtyAssembly      =  " & FormatSQL(z4015.QtyAssembly) & ", " 
    SQL = SQL & "    K4015_QtyAssemblyA      =  " & FormatSQL(z4015.QtyAssemblyA) & ", " 
    SQL = SQL & "    K4015_QtyAssemblyX      =  " & FormatSQL(z4015.QtyAssemblyX) & ", " 
    SQL = SQL & "    K4015_QtyAssemblyBLOut      =  " & FormatSQL(z4015.QtyAssemblyBLOut) & ", " 
    SQL = SQL & "    K4015_QtyAssemblyBLIn      =  " & FormatSQL(z4015.QtyAssemblyBLIn) & ", " 
    SQL = SQL & "    K4015_DatePacking      = N'" & FormatSQL(z4015.DatePacking) & "', " 
    SQL = SQL & "    K4015_DatePackingPosted      = N'" & FormatSQL(z4015.DatePackingPosted) & "', " 
    SQL = SQL & "    K4015_CheckPackingL      = N'" & FormatSQL(z4015.CheckPackingL) & "', " 
    SQL = SQL & "    K4015_CheckPackingR      = N'" & FormatSQL(z4015.CheckPackingR) & "', " 
    SQL = SQL & "    K4015_CheckCompletePacking      = N'" & FormatSQL(z4015.CheckCompletePacking) & "', " 
    SQL = SQL & "    K4015_QtyPacking      =  " & FormatSQL(z4015.QtyPacking) & ", " 
    SQL = SQL & "    K4015_QtyPackingA      =  " & FormatSQL(z4015.QtyPackingA) & ", " 
    SQL = SQL & "    K4015_QtyPackingX      =  " & FormatSQL(z4015.QtyPackingX) & ", " 
    SQL = SQL & "    K4015_QtyPackingBLOut      =  " & FormatSQL(z4015.QtyPackingBLOut) & ", " 
    SQL = SQL & "    K4015_QtyPackingBLIn      =  " & FormatSQL(z4015.QtyPackingBLIn) & ", " 
    SQL = SQL & "    K4015_DateInsert      = N'" & FormatSQL(z4015.DateInsert) & "', " 
    SQL = SQL & "    K4015_InchargeInsert      = N'" & FormatSQL(z4015.InchargeInsert) & "', " 
    SQL = SQL & "    K4015_DateUpdate      = N'" & FormatSQL(z4015.DateUpdate) & "', " 
    SQL = SQL & "    K4015_Remark      = N'" & FormatSQL(z4015.Remark) & "'  " 
    SQL = SQL & " WHERE K4015_JobCard		 = '" & z4015.JobCard & "' " 
    SQL = SQL & "   AND K4015_BarcodeSeq		 =  " & z4015.BarcodeSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK4015 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK4015",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK4015(z4015 As T4015_AREA) As Boolean
    DELETE_PFK4015 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK4015 "
    SQL = SQL & " WHERE K4015_JobCard		 = '" & z4015.JobCard & "' " 
    SQL = SQL & "   AND K4015_BarcodeSeq		 =  " & z4015.BarcodeSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK4015 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK4015",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D4015_CLEAR()
Try
    
   D4015.JobCard = ""
    D4015.BarcodeSeq = 0 
   D4015.SizeNo = ""
   D4015.Barcode = ""
   D4015.BarcodeScan = ""
   D4015.DateStitching = ""
   D4015.DateStitchingPosted = ""
   D4015.CheckStitchingL = ""
   D4015.CheckStitchingR = ""
   D4015.CheckCompleteStitching = ""
    D4015.QtyStitching = 0 
    D4015.QtyStitchingA = 0 
    D4015.QtyStitchingX = 0 
    D4015.QtyStitchingBLOut = 0 
    D4015.QtyStitchingBLIn = 0 
   D4015.DateAssembly = ""
   D4015.DateAssemblyPosted = ""
   D4015.CheckAssemblyL = ""
   D4015.CheckAssemblyR = ""
   D4015.CheckCompleteAssembly = ""
    D4015.QtyAssembly = 0 
    D4015.QtyAssemblyA = 0 
    D4015.QtyAssemblyX = 0 
    D4015.QtyAssemblyBLOut = 0 
    D4015.QtyAssemblyBLIn = 0 
   D4015.DatePacking = ""
   D4015.DatePackingPosted = ""
   D4015.CheckPackingL = ""
   D4015.CheckPackingR = ""
   D4015.CheckCompletePacking = ""
    D4015.QtyPacking = 0 
    D4015.QtyPackingA = 0 
    D4015.QtyPackingX = 0 
    D4015.QtyPackingBLOut = 0 
    D4015.QtyPackingBLIn = 0 
   D4015.DateInsert = ""
   D4015.InchargeInsert = ""
   D4015.DateUpdate = ""
   D4015.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D4015_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x4015 As T4015_AREA)
Try
    
    x4015.JobCard = trim$(  x4015.JobCard)
    x4015.BarcodeSeq = trim$(  x4015.BarcodeSeq)
    x4015.SizeNo = trim$(  x4015.SizeNo)
    x4015.Barcode = trim$(  x4015.Barcode)
    x4015.BarcodeScan = trim$(  x4015.BarcodeScan)
    x4015.DateStitching = trim$(  x4015.DateStitching)
    x4015.DateStitchingPosted = trim$(  x4015.DateStitchingPosted)
    x4015.CheckStitchingL = trim$(  x4015.CheckStitchingL)
    x4015.CheckStitchingR = trim$(  x4015.CheckStitchingR)
    x4015.CheckCompleteStitching = trim$(  x4015.CheckCompleteStitching)
    x4015.QtyStitching = trim$(  x4015.QtyStitching)
    x4015.QtyStitchingA = trim$(  x4015.QtyStitchingA)
    x4015.QtyStitchingX = trim$(  x4015.QtyStitchingX)
    x4015.QtyStitchingBLOut = trim$(  x4015.QtyStitchingBLOut)
    x4015.QtyStitchingBLIn = trim$(  x4015.QtyStitchingBLIn)
    x4015.DateAssembly = trim$(  x4015.DateAssembly)
    x4015.DateAssemblyPosted = trim$(  x4015.DateAssemblyPosted)
    x4015.CheckAssemblyL = trim$(  x4015.CheckAssemblyL)
    x4015.CheckAssemblyR = trim$(  x4015.CheckAssemblyR)
    x4015.CheckCompleteAssembly = trim$(  x4015.CheckCompleteAssembly)
    x4015.QtyAssembly = trim$(  x4015.QtyAssembly)
    x4015.QtyAssemblyA = trim$(  x4015.QtyAssemblyA)
    x4015.QtyAssemblyX = trim$(  x4015.QtyAssemblyX)
    x4015.QtyAssemblyBLOut = trim$(  x4015.QtyAssemblyBLOut)
    x4015.QtyAssemblyBLIn = trim$(  x4015.QtyAssemblyBLIn)
    x4015.DatePacking = trim$(  x4015.DatePacking)
    x4015.DatePackingPosted = trim$(  x4015.DatePackingPosted)
    x4015.CheckPackingL = trim$(  x4015.CheckPackingL)
    x4015.CheckPackingR = trim$(  x4015.CheckPackingR)
    x4015.CheckCompletePacking = trim$(  x4015.CheckCompletePacking)
    x4015.QtyPacking = trim$(  x4015.QtyPacking)
    x4015.QtyPackingA = trim$(  x4015.QtyPackingA)
    x4015.QtyPackingX = trim$(  x4015.QtyPackingX)
    x4015.QtyPackingBLOut = trim$(  x4015.QtyPackingBLOut)
    x4015.QtyPackingBLIn = trim$(  x4015.QtyPackingBLIn)
    x4015.DateInsert = trim$(  x4015.DateInsert)
    x4015.InchargeInsert = trim$(  x4015.InchargeInsert)
    x4015.DateUpdate = trim$(  x4015.DateUpdate)
    x4015.Remark = trim$(  x4015.Remark)
     
    If trim$( x4015.JobCard ) = "" Then x4015.JobCard = Space(1) 
    If trim$( x4015.BarcodeSeq ) = "" Then x4015.BarcodeSeq = 0 
    If trim$( x4015.SizeNo ) = "" Then x4015.SizeNo = Space(1) 
    If trim$( x4015.Barcode ) = "" Then x4015.Barcode = Space(1) 
    If trim$( x4015.BarcodeScan ) = "" Then x4015.BarcodeScan = Space(1) 
    If trim$( x4015.DateStitching ) = "" Then x4015.DateStitching = Space(1) 
    If trim$( x4015.DateStitchingPosted ) = "" Then x4015.DateStitchingPosted = Space(1) 
    If trim$( x4015.CheckStitchingL ) = "" Then x4015.CheckStitchingL = Space(1) 
    If trim$( x4015.CheckStitchingR ) = "" Then x4015.CheckStitchingR = Space(1) 
    If trim$( x4015.CheckCompleteStitching ) = "" Then x4015.CheckCompleteStitching = Space(1) 
    If trim$( x4015.QtyStitching ) = "" Then x4015.QtyStitching = 0 
    If trim$( x4015.QtyStitchingA ) = "" Then x4015.QtyStitchingA = 0 
    If trim$( x4015.QtyStitchingX ) = "" Then x4015.QtyStitchingX = 0 
    If trim$( x4015.QtyStitchingBLOut ) = "" Then x4015.QtyStitchingBLOut = 0 
    If trim$( x4015.QtyStitchingBLIn ) = "" Then x4015.QtyStitchingBLIn = 0 
    If trim$( x4015.DateAssembly ) = "" Then x4015.DateAssembly = Space(1) 
    If trim$( x4015.DateAssemblyPosted ) = "" Then x4015.DateAssemblyPosted = Space(1) 
    If trim$( x4015.CheckAssemblyL ) = "" Then x4015.CheckAssemblyL = Space(1) 
    If trim$( x4015.CheckAssemblyR ) = "" Then x4015.CheckAssemblyR = Space(1) 
    If trim$( x4015.CheckCompleteAssembly ) = "" Then x4015.CheckCompleteAssembly = Space(1) 
    If trim$( x4015.QtyAssembly ) = "" Then x4015.QtyAssembly = 0 
    If trim$( x4015.QtyAssemblyA ) = "" Then x4015.QtyAssemblyA = 0 
    If trim$( x4015.QtyAssemblyX ) = "" Then x4015.QtyAssemblyX = 0 
    If trim$( x4015.QtyAssemblyBLOut ) = "" Then x4015.QtyAssemblyBLOut = 0 
    If trim$( x4015.QtyAssemblyBLIn ) = "" Then x4015.QtyAssemblyBLIn = 0 
    If trim$( x4015.DatePacking ) = "" Then x4015.DatePacking = Space(1) 
    If trim$( x4015.DatePackingPosted ) = "" Then x4015.DatePackingPosted = Space(1) 
    If trim$( x4015.CheckPackingL ) = "" Then x4015.CheckPackingL = Space(1) 
    If trim$( x4015.CheckPackingR ) = "" Then x4015.CheckPackingR = Space(1) 
    If trim$( x4015.CheckCompletePacking ) = "" Then x4015.CheckCompletePacking = Space(1) 
    If trim$( x4015.QtyPacking ) = "" Then x4015.QtyPacking = 0 
    If trim$( x4015.QtyPackingA ) = "" Then x4015.QtyPackingA = 0 
    If trim$( x4015.QtyPackingX ) = "" Then x4015.QtyPackingX = 0 
    If trim$( x4015.QtyPackingBLOut ) = "" Then x4015.QtyPackingBLOut = 0 
    If trim$( x4015.QtyPackingBLIn ) = "" Then x4015.QtyPackingBLIn = 0 
    If trim$( x4015.DateInsert ) = "" Then x4015.DateInsert = Space(1) 
    If trim$( x4015.InchargeInsert ) = "" Then x4015.InchargeInsert = Space(1) 
    If trim$( x4015.DateUpdate ) = "" Then x4015.DateUpdate = Space(1) 
    If trim$( x4015.Remark ) = "" Then x4015.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K4015_MOVE(rs4015 As SqlClient.SqlDataReader)
Try

    call D4015_CLEAR()   

    If IsdbNull(rs4015!K4015_JobCard) = False Then D4015.JobCard = Trim$(rs4015!K4015_JobCard)
    If IsdbNull(rs4015!K4015_BarcodeSeq) = False Then D4015.BarcodeSeq = Trim$(rs4015!K4015_BarcodeSeq)
    If IsdbNull(rs4015!K4015_SizeNo) = False Then D4015.SizeNo = Trim$(rs4015!K4015_SizeNo)
    If IsdbNull(rs4015!K4015_Barcode) = False Then D4015.Barcode = Trim$(rs4015!K4015_Barcode)
    If IsdbNull(rs4015!K4015_BarcodeScan) = False Then D4015.BarcodeScan = Trim$(rs4015!K4015_BarcodeScan)
    If IsdbNull(rs4015!K4015_DateStitching) = False Then D4015.DateStitching = Trim$(rs4015!K4015_DateStitching)
    If IsdbNull(rs4015!K4015_DateStitchingPosted) = False Then D4015.DateStitchingPosted = Trim$(rs4015!K4015_DateStitchingPosted)
    If IsdbNull(rs4015!K4015_CheckStitchingL) = False Then D4015.CheckStitchingL = Trim$(rs4015!K4015_CheckStitchingL)
    If IsdbNull(rs4015!K4015_CheckStitchingR) = False Then D4015.CheckStitchingR = Trim$(rs4015!K4015_CheckStitchingR)
    If IsdbNull(rs4015!K4015_CheckCompleteStitching) = False Then D4015.CheckCompleteStitching = Trim$(rs4015!K4015_CheckCompleteStitching)
    If IsdbNull(rs4015!K4015_QtyStitching) = False Then D4015.QtyStitching = Trim$(rs4015!K4015_QtyStitching)
    If IsdbNull(rs4015!K4015_QtyStitchingA) = False Then D4015.QtyStitchingA = Trim$(rs4015!K4015_QtyStitchingA)
    If IsdbNull(rs4015!K4015_QtyStitchingX) = False Then D4015.QtyStitchingX = Trim$(rs4015!K4015_QtyStitchingX)
    If IsdbNull(rs4015!K4015_QtyStitchingBLOut) = False Then D4015.QtyStitchingBLOut = Trim$(rs4015!K4015_QtyStitchingBLOut)
    If IsdbNull(rs4015!K4015_QtyStitchingBLIn) = False Then D4015.QtyStitchingBLIn = Trim$(rs4015!K4015_QtyStitchingBLIn)
    If IsdbNull(rs4015!K4015_DateAssembly) = False Then D4015.DateAssembly = Trim$(rs4015!K4015_DateAssembly)
    If IsdbNull(rs4015!K4015_DateAssemblyPosted) = False Then D4015.DateAssemblyPosted = Trim$(rs4015!K4015_DateAssemblyPosted)
    If IsdbNull(rs4015!K4015_CheckAssemblyL) = False Then D4015.CheckAssemblyL = Trim$(rs4015!K4015_CheckAssemblyL)
    If IsdbNull(rs4015!K4015_CheckAssemblyR) = False Then D4015.CheckAssemblyR = Trim$(rs4015!K4015_CheckAssemblyR)
    If IsdbNull(rs4015!K4015_CheckCompleteAssembly) = False Then D4015.CheckCompleteAssembly = Trim$(rs4015!K4015_CheckCompleteAssembly)
    If IsdbNull(rs4015!K4015_QtyAssembly) = False Then D4015.QtyAssembly = Trim$(rs4015!K4015_QtyAssembly)
    If IsdbNull(rs4015!K4015_QtyAssemblyA) = False Then D4015.QtyAssemblyA = Trim$(rs4015!K4015_QtyAssemblyA)
    If IsdbNull(rs4015!K4015_QtyAssemblyX) = False Then D4015.QtyAssemblyX = Trim$(rs4015!K4015_QtyAssemblyX)
    If IsdbNull(rs4015!K4015_QtyAssemblyBLOut) = False Then D4015.QtyAssemblyBLOut = Trim$(rs4015!K4015_QtyAssemblyBLOut)
    If IsdbNull(rs4015!K4015_QtyAssemblyBLIn) = False Then D4015.QtyAssemblyBLIn = Trim$(rs4015!K4015_QtyAssemblyBLIn)
    If IsdbNull(rs4015!K4015_DatePacking) = False Then D4015.DatePacking = Trim$(rs4015!K4015_DatePacking)
    If IsdbNull(rs4015!K4015_DatePackingPosted) = False Then D4015.DatePackingPosted = Trim$(rs4015!K4015_DatePackingPosted)
    If IsdbNull(rs4015!K4015_CheckPackingL) = False Then D4015.CheckPackingL = Trim$(rs4015!K4015_CheckPackingL)
    If IsdbNull(rs4015!K4015_CheckPackingR) = False Then D4015.CheckPackingR = Trim$(rs4015!K4015_CheckPackingR)
    If IsdbNull(rs4015!K4015_CheckCompletePacking) = False Then D4015.CheckCompletePacking = Trim$(rs4015!K4015_CheckCompletePacking)
    If IsdbNull(rs4015!K4015_QtyPacking) = False Then D4015.QtyPacking = Trim$(rs4015!K4015_QtyPacking)
    If IsdbNull(rs4015!K4015_QtyPackingA) = False Then D4015.QtyPackingA = Trim$(rs4015!K4015_QtyPackingA)
    If IsdbNull(rs4015!K4015_QtyPackingX) = False Then D4015.QtyPackingX = Trim$(rs4015!K4015_QtyPackingX)
    If IsdbNull(rs4015!K4015_QtyPackingBLOut) = False Then D4015.QtyPackingBLOut = Trim$(rs4015!K4015_QtyPackingBLOut)
    If IsdbNull(rs4015!K4015_QtyPackingBLIn) = False Then D4015.QtyPackingBLIn = Trim$(rs4015!K4015_QtyPackingBLIn)
    If IsdbNull(rs4015!K4015_DateInsert) = False Then D4015.DateInsert = Trim$(rs4015!K4015_DateInsert)
    If IsdbNull(rs4015!K4015_InchargeInsert) = False Then D4015.InchargeInsert = Trim$(rs4015!K4015_InchargeInsert)
    If IsdbNull(rs4015!K4015_DateUpdate) = False Then D4015.DateUpdate = Trim$(rs4015!K4015_DateUpdate)
    If IsdbNull(rs4015!K4015_Remark) = False Then D4015.Remark = Trim$(rs4015!K4015_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4015_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K4015_MOVE(rs4015 As DataRow)
Try

    call D4015_CLEAR()   

    If IsdbNull(rs4015!K4015_JobCard) = False Then D4015.JobCard = Trim$(rs4015!K4015_JobCard)
    If IsdbNull(rs4015!K4015_BarcodeSeq) = False Then D4015.BarcodeSeq = Trim$(rs4015!K4015_BarcodeSeq)
    If IsdbNull(rs4015!K4015_SizeNo) = False Then D4015.SizeNo = Trim$(rs4015!K4015_SizeNo)
    If IsdbNull(rs4015!K4015_Barcode) = False Then D4015.Barcode = Trim$(rs4015!K4015_Barcode)
    If IsdbNull(rs4015!K4015_BarcodeScan) = False Then D4015.BarcodeScan = Trim$(rs4015!K4015_BarcodeScan)
    If IsdbNull(rs4015!K4015_DateStitching) = False Then D4015.DateStitching = Trim$(rs4015!K4015_DateStitching)
    If IsdbNull(rs4015!K4015_DateStitchingPosted) = False Then D4015.DateStitchingPosted = Trim$(rs4015!K4015_DateStitchingPosted)
    If IsdbNull(rs4015!K4015_CheckStitchingL) = False Then D4015.CheckStitchingL = Trim$(rs4015!K4015_CheckStitchingL)
    If IsdbNull(rs4015!K4015_CheckStitchingR) = False Then D4015.CheckStitchingR = Trim$(rs4015!K4015_CheckStitchingR)
    If IsdbNull(rs4015!K4015_CheckCompleteStitching) = False Then D4015.CheckCompleteStitching = Trim$(rs4015!K4015_CheckCompleteStitching)
    If IsdbNull(rs4015!K4015_QtyStitching) = False Then D4015.QtyStitching = Trim$(rs4015!K4015_QtyStitching)
    If IsdbNull(rs4015!K4015_QtyStitchingA) = False Then D4015.QtyStitchingA = Trim$(rs4015!K4015_QtyStitchingA)
    If IsdbNull(rs4015!K4015_QtyStitchingX) = False Then D4015.QtyStitchingX = Trim$(rs4015!K4015_QtyStitchingX)
    If IsdbNull(rs4015!K4015_QtyStitchingBLOut) = False Then D4015.QtyStitchingBLOut = Trim$(rs4015!K4015_QtyStitchingBLOut)
    If IsdbNull(rs4015!K4015_QtyStitchingBLIn) = False Then D4015.QtyStitchingBLIn = Trim$(rs4015!K4015_QtyStitchingBLIn)
    If IsdbNull(rs4015!K4015_DateAssembly) = False Then D4015.DateAssembly = Trim$(rs4015!K4015_DateAssembly)
    If IsdbNull(rs4015!K4015_DateAssemblyPosted) = False Then D4015.DateAssemblyPosted = Trim$(rs4015!K4015_DateAssemblyPosted)
    If IsdbNull(rs4015!K4015_CheckAssemblyL) = False Then D4015.CheckAssemblyL = Trim$(rs4015!K4015_CheckAssemblyL)
    If IsdbNull(rs4015!K4015_CheckAssemblyR) = False Then D4015.CheckAssemblyR = Trim$(rs4015!K4015_CheckAssemblyR)
    If IsdbNull(rs4015!K4015_CheckCompleteAssembly) = False Then D4015.CheckCompleteAssembly = Trim$(rs4015!K4015_CheckCompleteAssembly)
    If IsdbNull(rs4015!K4015_QtyAssembly) = False Then D4015.QtyAssembly = Trim$(rs4015!K4015_QtyAssembly)
    If IsdbNull(rs4015!K4015_QtyAssemblyA) = False Then D4015.QtyAssemblyA = Trim$(rs4015!K4015_QtyAssemblyA)
    If IsdbNull(rs4015!K4015_QtyAssemblyX) = False Then D4015.QtyAssemblyX = Trim$(rs4015!K4015_QtyAssemblyX)
    If IsdbNull(rs4015!K4015_QtyAssemblyBLOut) = False Then D4015.QtyAssemblyBLOut = Trim$(rs4015!K4015_QtyAssemblyBLOut)
    If IsdbNull(rs4015!K4015_QtyAssemblyBLIn) = False Then D4015.QtyAssemblyBLIn = Trim$(rs4015!K4015_QtyAssemblyBLIn)
    If IsdbNull(rs4015!K4015_DatePacking) = False Then D4015.DatePacking = Trim$(rs4015!K4015_DatePacking)
    If IsdbNull(rs4015!K4015_DatePackingPosted) = False Then D4015.DatePackingPosted = Trim$(rs4015!K4015_DatePackingPosted)
    If IsdbNull(rs4015!K4015_CheckPackingL) = False Then D4015.CheckPackingL = Trim$(rs4015!K4015_CheckPackingL)
    If IsdbNull(rs4015!K4015_CheckPackingR) = False Then D4015.CheckPackingR = Trim$(rs4015!K4015_CheckPackingR)
    If IsdbNull(rs4015!K4015_CheckCompletePacking) = False Then D4015.CheckCompletePacking = Trim$(rs4015!K4015_CheckCompletePacking)
    If IsdbNull(rs4015!K4015_QtyPacking) = False Then D4015.QtyPacking = Trim$(rs4015!K4015_QtyPacking)
    If IsdbNull(rs4015!K4015_QtyPackingA) = False Then D4015.QtyPackingA = Trim$(rs4015!K4015_QtyPackingA)
    If IsdbNull(rs4015!K4015_QtyPackingX) = False Then D4015.QtyPackingX = Trim$(rs4015!K4015_QtyPackingX)
    If IsdbNull(rs4015!K4015_QtyPackingBLOut) = False Then D4015.QtyPackingBLOut = Trim$(rs4015!K4015_QtyPackingBLOut)
    If IsdbNull(rs4015!K4015_QtyPackingBLIn) = False Then D4015.QtyPackingBLIn = Trim$(rs4015!K4015_QtyPackingBLIn)
    If IsdbNull(rs4015!K4015_DateInsert) = False Then D4015.DateInsert = Trim$(rs4015!K4015_DateInsert)
    If IsdbNull(rs4015!K4015_InchargeInsert) = False Then D4015.InchargeInsert = Trim$(rs4015!K4015_InchargeInsert)
    If IsdbNull(rs4015!K4015_DateUpdate) = False Then D4015.DateUpdate = Trim$(rs4015!K4015_DateUpdate)
    If IsdbNull(rs4015!K4015_Remark) = False Then D4015.Remark = Trim$(rs4015!K4015_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4015_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K4015_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4015 As T4015_AREA, JOBCARD AS String, BARCODESEQ AS Double) as Boolean

K4015_MOVE = False

Try
    If READ_PFK4015(JOBCARD, BARCODESEQ) = True Then
                z4015 = D4015
		K4015_MOVE = True
		else
	z4015 = nothing
     End If

     If  getColumIndex(spr,"JobCard") > -1 then z4015.JobCard = getDataM(spr, getColumIndex(spr,"JobCard"), xRow)
     If  getColumIndex(spr,"BarcodeSeq") > -1 then z4015.BarcodeSeq = getDataM(spr, getColumIndex(spr,"BarcodeSeq"), xRow)
     If  getColumIndex(spr,"SizeNo") > -1 then z4015.SizeNo = getDataM(spr, getColumIndex(spr,"SizeNo"), xRow)
     If  getColumIndex(spr,"Barcode") > -1 then z4015.Barcode = getDataM(spr, getColumIndex(spr,"Barcode"), xRow)
     If  getColumIndex(spr,"BarcodeScan") > -1 then z4015.BarcodeScan = getDataM(spr, getColumIndex(spr,"BarcodeScan"), xRow)
     If  getColumIndex(spr,"DateStitching") > -1 then z4015.DateStitching = getDataM(spr, getColumIndex(spr,"DateStitching"), xRow)
     If  getColumIndex(spr,"DateStitchingPosted") > -1 then z4015.DateStitchingPosted = getDataM(spr, getColumIndex(spr,"DateStitchingPosted"), xRow)
     If  getColumIndex(spr,"CheckStitchingL") > -1 then z4015.CheckStitchingL = getDataM(spr, getColumIndex(spr,"CheckStitchingL"), xRow)
     If  getColumIndex(spr,"CheckStitchingR") > -1 then z4015.CheckStitchingR = getDataM(spr, getColumIndex(spr,"CheckStitchingR"), xRow)
     If  getColumIndex(spr,"CheckCompleteStitching") > -1 then z4015.CheckCompleteStitching = getDataM(spr, getColumIndex(spr,"CheckCompleteStitching"), xRow)
     If  getColumIndex(spr,"QtyStitching") > -1 then z4015.QtyStitching = getDataM(spr, getColumIndex(spr,"QtyStitching"), xRow)
     If  getColumIndex(spr,"QtyStitchingA") > -1 then z4015.QtyStitchingA = getDataM(spr, getColumIndex(spr,"QtyStitchingA"), xRow)
     If  getColumIndex(spr,"QtyStitchingX") > -1 then z4015.QtyStitchingX = getDataM(spr, getColumIndex(spr,"QtyStitchingX"), xRow)
     If  getColumIndex(spr,"QtyStitchingBLOut") > -1 then z4015.QtyStitchingBLOut = getDataM(spr, getColumIndex(spr,"QtyStitchingBLOut"), xRow)
     If  getColumIndex(spr,"QtyStitchingBLIn") > -1 then z4015.QtyStitchingBLIn = getDataM(spr, getColumIndex(spr,"QtyStitchingBLIn"), xRow)
     If  getColumIndex(spr,"DateAssembly") > -1 then z4015.DateAssembly = getDataM(spr, getColumIndex(spr,"DateAssembly"), xRow)
     If  getColumIndex(spr,"DateAssemblyPosted") > -1 then z4015.DateAssemblyPosted = getDataM(spr, getColumIndex(spr,"DateAssemblyPosted"), xRow)
     If  getColumIndex(spr,"CheckAssemblyL") > -1 then z4015.CheckAssemblyL = getDataM(spr, getColumIndex(spr,"CheckAssemblyL"), xRow)
     If  getColumIndex(spr,"CheckAssemblyR") > -1 then z4015.CheckAssemblyR = getDataM(spr, getColumIndex(spr,"CheckAssemblyR"), xRow)
     If  getColumIndex(spr,"CheckCompleteAssembly") > -1 then z4015.CheckCompleteAssembly = getDataM(spr, getColumIndex(spr,"CheckCompleteAssembly"), xRow)
     If  getColumIndex(spr,"QtyAssembly") > -1 then z4015.QtyAssembly = getDataM(spr, getColumIndex(spr,"QtyAssembly"), xRow)
     If  getColumIndex(spr,"QtyAssemblyA") > -1 then z4015.QtyAssemblyA = getDataM(spr, getColumIndex(spr,"QtyAssemblyA"), xRow)
     If  getColumIndex(spr,"QtyAssemblyX") > -1 then z4015.QtyAssemblyX = getDataM(spr, getColumIndex(spr,"QtyAssemblyX"), xRow)
     If  getColumIndex(spr,"QtyAssemblyBLOut") > -1 then z4015.QtyAssemblyBLOut = getDataM(spr, getColumIndex(spr,"QtyAssemblyBLOut"), xRow)
     If  getColumIndex(spr,"QtyAssemblyBLIn") > -1 then z4015.QtyAssemblyBLIn = getDataM(spr, getColumIndex(spr,"QtyAssemblyBLIn"), xRow)
     If  getColumIndex(spr,"DatePacking") > -1 then z4015.DatePacking = getDataM(spr, getColumIndex(spr,"DatePacking"), xRow)
     If  getColumIndex(spr,"DatePackingPosted") > -1 then z4015.DatePackingPosted = getDataM(spr, getColumIndex(spr,"DatePackingPosted"), xRow)
     If  getColumIndex(spr,"CheckPackingL") > -1 then z4015.CheckPackingL = getDataM(spr, getColumIndex(spr,"CheckPackingL"), xRow)
     If  getColumIndex(spr,"CheckPackingR") > -1 then z4015.CheckPackingR = getDataM(spr, getColumIndex(spr,"CheckPackingR"), xRow)
     If  getColumIndex(spr,"CheckCompletePacking") > -1 then z4015.CheckCompletePacking = getDataM(spr, getColumIndex(spr,"CheckCompletePacking"), xRow)
     If  getColumIndex(spr,"QtyPacking") > -1 then z4015.QtyPacking = getDataM(spr, getColumIndex(spr,"QtyPacking"), xRow)
     If  getColumIndex(spr,"QtyPackingA") > -1 then z4015.QtyPackingA = getDataM(spr, getColumIndex(spr,"QtyPackingA"), xRow)
     If  getColumIndex(spr,"QtyPackingX") > -1 then z4015.QtyPackingX = getDataM(spr, getColumIndex(spr,"QtyPackingX"), xRow)
     If  getColumIndex(spr,"QtyPackingBLOut") > -1 then z4015.QtyPackingBLOut = getDataM(spr, getColumIndex(spr,"QtyPackingBLOut"), xRow)
     If  getColumIndex(spr,"QtyPackingBLIn") > -1 then z4015.QtyPackingBLIn = getDataM(spr, getColumIndex(spr,"QtyPackingBLIn"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z4015.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z4015.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z4015.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4015.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4015_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K4015_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4015 As T4015_AREA,CheckClear as Boolean,JOBCARD AS String, BARCODESEQ AS Double) as Boolean

K4015_MOVE = False

Try
    If READ_PFK4015(JOBCARD, BARCODESEQ) = True Then
                z4015 = D4015
		K4015_MOVE = True
		else
	If CheckClear  = True then z4015 = nothing
     End If

     If  getColumIndex(spr,"JobCard") > -1 then z4015.JobCard = getDataM(spr, getColumIndex(spr,"JobCard"), xRow)
     If  getColumIndex(spr,"BarcodeSeq") > -1 then z4015.BarcodeSeq = getDataM(spr, getColumIndex(spr,"BarcodeSeq"), xRow)
     If  getColumIndex(spr,"SizeNo") > -1 then z4015.SizeNo = getDataM(spr, getColumIndex(spr,"SizeNo"), xRow)
     If  getColumIndex(spr,"Barcode") > -1 then z4015.Barcode = getDataM(spr, getColumIndex(spr,"Barcode"), xRow)
     If  getColumIndex(spr,"BarcodeScan") > -1 then z4015.BarcodeScan = getDataM(spr, getColumIndex(spr,"BarcodeScan"), xRow)
     If  getColumIndex(spr,"DateStitching") > -1 then z4015.DateStitching = getDataM(spr, getColumIndex(spr,"DateStitching"), xRow)
     If  getColumIndex(spr,"DateStitchingPosted") > -1 then z4015.DateStitchingPosted = getDataM(spr, getColumIndex(spr,"DateStitchingPosted"), xRow)
     If  getColumIndex(spr,"CheckStitchingL") > -1 then z4015.CheckStitchingL = getDataM(spr, getColumIndex(spr,"CheckStitchingL"), xRow)
     If  getColumIndex(spr,"CheckStitchingR") > -1 then z4015.CheckStitchingR = getDataM(spr, getColumIndex(spr,"CheckStitchingR"), xRow)
     If  getColumIndex(spr,"CheckCompleteStitching") > -1 then z4015.CheckCompleteStitching = getDataM(spr, getColumIndex(spr,"CheckCompleteStitching"), xRow)
     If  getColumIndex(spr,"QtyStitching") > -1 then z4015.QtyStitching = getDataM(spr, getColumIndex(spr,"QtyStitching"), xRow)
     If  getColumIndex(spr,"QtyStitchingA") > -1 then z4015.QtyStitchingA = getDataM(spr, getColumIndex(spr,"QtyStitchingA"), xRow)
     If  getColumIndex(spr,"QtyStitchingX") > -1 then z4015.QtyStitchingX = getDataM(spr, getColumIndex(spr,"QtyStitchingX"), xRow)
     If  getColumIndex(spr,"QtyStitchingBLOut") > -1 then z4015.QtyStitchingBLOut = getDataM(spr, getColumIndex(spr,"QtyStitchingBLOut"), xRow)
     If  getColumIndex(spr,"QtyStitchingBLIn") > -1 then z4015.QtyStitchingBLIn = getDataM(spr, getColumIndex(spr,"QtyStitchingBLIn"), xRow)
     If  getColumIndex(spr,"DateAssembly") > -1 then z4015.DateAssembly = getDataM(spr, getColumIndex(spr,"DateAssembly"), xRow)
     If  getColumIndex(spr,"DateAssemblyPosted") > -1 then z4015.DateAssemblyPosted = getDataM(spr, getColumIndex(spr,"DateAssemblyPosted"), xRow)
     If  getColumIndex(spr,"CheckAssemblyL") > -1 then z4015.CheckAssemblyL = getDataM(spr, getColumIndex(spr,"CheckAssemblyL"), xRow)
     If  getColumIndex(spr,"CheckAssemblyR") > -1 then z4015.CheckAssemblyR = getDataM(spr, getColumIndex(spr,"CheckAssemblyR"), xRow)
     If  getColumIndex(spr,"CheckCompleteAssembly") > -1 then z4015.CheckCompleteAssembly = getDataM(spr, getColumIndex(spr,"CheckCompleteAssembly"), xRow)
     If  getColumIndex(spr,"QtyAssembly") > -1 then z4015.QtyAssembly = getDataM(spr, getColumIndex(spr,"QtyAssembly"), xRow)
     If  getColumIndex(spr,"QtyAssemblyA") > -1 then z4015.QtyAssemblyA = getDataM(spr, getColumIndex(spr,"QtyAssemblyA"), xRow)
     If  getColumIndex(spr,"QtyAssemblyX") > -1 then z4015.QtyAssemblyX = getDataM(spr, getColumIndex(spr,"QtyAssemblyX"), xRow)
     If  getColumIndex(spr,"QtyAssemblyBLOut") > -1 then z4015.QtyAssemblyBLOut = getDataM(spr, getColumIndex(spr,"QtyAssemblyBLOut"), xRow)
     If  getColumIndex(spr,"QtyAssemblyBLIn") > -1 then z4015.QtyAssemblyBLIn = getDataM(spr, getColumIndex(spr,"QtyAssemblyBLIn"), xRow)
     If  getColumIndex(spr,"DatePacking") > -1 then z4015.DatePacking = getDataM(spr, getColumIndex(spr,"DatePacking"), xRow)
     If  getColumIndex(spr,"DatePackingPosted") > -1 then z4015.DatePackingPosted = getDataM(spr, getColumIndex(spr,"DatePackingPosted"), xRow)
     If  getColumIndex(spr,"CheckPackingL") > -1 then z4015.CheckPackingL = getDataM(spr, getColumIndex(spr,"CheckPackingL"), xRow)
     If  getColumIndex(spr,"CheckPackingR") > -1 then z4015.CheckPackingR = getDataM(spr, getColumIndex(spr,"CheckPackingR"), xRow)
     If  getColumIndex(spr,"CheckCompletePacking") > -1 then z4015.CheckCompletePacking = getDataM(spr, getColumIndex(spr,"CheckCompletePacking"), xRow)
     If  getColumIndex(spr,"QtyPacking") > -1 then z4015.QtyPacking = getDataM(spr, getColumIndex(spr,"QtyPacking"), xRow)
     If  getColumIndex(spr,"QtyPackingA") > -1 then z4015.QtyPackingA = getDataM(spr, getColumIndex(spr,"QtyPackingA"), xRow)
     If  getColumIndex(spr,"QtyPackingX") > -1 then z4015.QtyPackingX = getDataM(spr, getColumIndex(spr,"QtyPackingX"), xRow)
     If  getColumIndex(spr,"QtyPackingBLOut") > -1 then z4015.QtyPackingBLOut = getDataM(spr, getColumIndex(spr,"QtyPackingBLOut"), xRow)
     If  getColumIndex(spr,"QtyPackingBLIn") > -1 then z4015.QtyPackingBLIn = getDataM(spr, getColumIndex(spr,"QtyPackingBLIn"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z4015.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z4015.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z4015.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4015.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4015_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K4015_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4015 As T4015_AREA, Job as String, JOBCARD AS String, BARCODESEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4015_MOVE = False

Try
    If READ_PFK4015(JOBCARD, BARCODESEQ) = True Then
                z4015 = D4015
		K4015_MOVE = True
		else
	z4015 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4015")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "JOBCARD":z4015.JobCard = Children(i).Code
   Case "BARCODESEQ":z4015.BarcodeSeq = Children(i).Code
   Case "SIZENO":z4015.SizeNo = Children(i).Code
   Case "BARCODE":z4015.Barcode = Children(i).Code
   Case "BARCODESCAN":z4015.BarcodeScan = Children(i).Code
   Case "DATESTITCHING":z4015.DateStitching = Children(i).Code
   Case "DATESTITCHINGPOSTED":z4015.DateStitchingPosted = Children(i).Code
   Case "CHECKSTITCHINGL":z4015.CheckStitchingL = Children(i).Code
   Case "CHECKSTITCHINGR":z4015.CheckStitchingR = Children(i).Code
   Case "CHECKCOMPLETESTITCHING":z4015.CheckCompleteStitching = Children(i).Code
   Case "QTYSTITCHING":z4015.QtyStitching = Children(i).Code
   Case "QTYSTITCHINGA":z4015.QtyStitchingA = Children(i).Code
   Case "QTYSTITCHINGX":z4015.QtyStitchingX = Children(i).Code
   Case "QTYSTITCHINGBLOUT":z4015.QtyStitchingBLOut = Children(i).Code
   Case "QTYSTITCHINGBLIN":z4015.QtyStitchingBLIn = Children(i).Code
   Case "DATEASSEMBLY":z4015.DateAssembly = Children(i).Code
   Case "DATEASSEMBLYPOSTED":z4015.DateAssemblyPosted = Children(i).Code
   Case "CHECKASSEMBLYL":z4015.CheckAssemblyL = Children(i).Code
   Case "CHECKASSEMBLYR":z4015.CheckAssemblyR = Children(i).Code
   Case "CHECKCOMPLETEASSEMBLY":z4015.CheckCompleteAssembly = Children(i).Code
   Case "QTYASSEMBLY":z4015.QtyAssembly = Children(i).Code
   Case "QTYASSEMBLYA":z4015.QtyAssemblyA = Children(i).Code
   Case "QTYASSEMBLYX":z4015.QtyAssemblyX = Children(i).Code
   Case "QTYASSEMBLYBLOUT":z4015.QtyAssemblyBLOut = Children(i).Code
   Case "QTYASSEMBLYBLIN":z4015.QtyAssemblyBLIn = Children(i).Code
   Case "DATEPACKING":z4015.DatePacking = Children(i).Code
   Case "DATEPACKINGPOSTED":z4015.DatePackingPosted = Children(i).Code
   Case "CHECKPACKINGL":z4015.CheckPackingL = Children(i).Code
   Case "CHECKPACKINGR":z4015.CheckPackingR = Children(i).Code
   Case "CHECKCOMPLETEPACKING":z4015.CheckCompletePacking = Children(i).Code
   Case "QTYPACKING":z4015.QtyPacking = Children(i).Code
   Case "QTYPACKINGA":z4015.QtyPackingA = Children(i).Code
   Case "QTYPACKINGX":z4015.QtyPackingX = Children(i).Code
   Case "QTYPACKINGBLOUT":z4015.QtyPackingBLOut = Children(i).Code
   Case "QTYPACKINGBLIN":z4015.QtyPackingBLIn = Children(i).Code
   Case "DATEINSERT":z4015.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z4015.InchargeInsert = Children(i).Code
   Case "DATEUPDATE":z4015.DateUpdate = Children(i).Code
   Case "REMARK":z4015.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "JOBCARD":z4015.JobCard = Children(i).Data
   Case "BARCODESEQ":z4015.BarcodeSeq = Children(i).Data
   Case "SIZENO":z4015.SizeNo = Children(i).Data
   Case "BARCODE":z4015.Barcode = Children(i).Data
   Case "BARCODESCAN":z4015.BarcodeScan = Children(i).Data
   Case "DATESTITCHING":z4015.DateStitching = Children(i).Data
   Case "DATESTITCHINGPOSTED":z4015.DateStitchingPosted = Children(i).Data
   Case "CHECKSTITCHINGL":z4015.CheckStitchingL = Children(i).Data
   Case "CHECKSTITCHINGR":z4015.CheckStitchingR = Children(i).Data
   Case "CHECKCOMPLETESTITCHING":z4015.CheckCompleteStitching = Children(i).Data
   Case "QTYSTITCHING":z4015.QtyStitching = Children(i).Data
   Case "QTYSTITCHINGA":z4015.QtyStitchingA = Children(i).Data
   Case "QTYSTITCHINGX":z4015.QtyStitchingX = Children(i).Data
   Case "QTYSTITCHINGBLOUT":z4015.QtyStitchingBLOut = Children(i).Data
   Case "QTYSTITCHINGBLIN":z4015.QtyStitchingBLIn = Children(i).Data
   Case "DATEASSEMBLY":z4015.DateAssembly = Children(i).Data
   Case "DATEASSEMBLYPOSTED":z4015.DateAssemblyPosted = Children(i).Data
   Case "CHECKASSEMBLYL":z4015.CheckAssemblyL = Children(i).Data
   Case "CHECKASSEMBLYR":z4015.CheckAssemblyR = Children(i).Data
   Case "CHECKCOMPLETEASSEMBLY":z4015.CheckCompleteAssembly = Children(i).Data
   Case "QTYASSEMBLY":z4015.QtyAssembly = Children(i).Data
   Case "QTYASSEMBLYA":z4015.QtyAssemblyA = Children(i).Data
   Case "QTYASSEMBLYX":z4015.QtyAssemblyX = Children(i).Data
   Case "QTYASSEMBLYBLOUT":z4015.QtyAssemblyBLOut = Children(i).Data
   Case "QTYASSEMBLYBLIN":z4015.QtyAssemblyBLIn = Children(i).Data
   Case "DATEPACKING":z4015.DatePacking = Children(i).Data
   Case "DATEPACKINGPOSTED":z4015.DatePackingPosted = Children(i).Data
   Case "CHECKPACKINGL":z4015.CheckPackingL = Children(i).Data
   Case "CHECKPACKINGR":z4015.CheckPackingR = Children(i).Data
   Case "CHECKCOMPLETEPACKING":z4015.CheckCompletePacking = Children(i).Data
   Case "QTYPACKING":z4015.QtyPacking = Children(i).Data
   Case "QTYPACKINGA":z4015.QtyPackingA = Children(i).Data
   Case "QTYPACKINGX":z4015.QtyPackingX = Children(i).Data
   Case "QTYPACKINGBLOUT":z4015.QtyPackingBLOut = Children(i).Data
   Case "QTYPACKINGBLIN":z4015.QtyPackingBLIn = Children(i).Data
   Case "DATEINSERT":z4015.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z4015.InchargeInsert = Children(i).Data
   Case "DATEUPDATE":z4015.DateUpdate = Children(i).Data
   Case "REMARK":z4015.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4015_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K4015_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4015 As T4015_AREA, Job as String, CheckClear as Boolean, JOBCARD AS String, BARCODESEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4015_MOVE = False

Try
    If READ_PFK4015(JOBCARD, BARCODESEQ) = True Then
                z4015 = D4015
		K4015_MOVE = True
		else
	If CheckClear  = True then z4015 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4015")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "JOBCARD":z4015.JobCard = Children(i).Code
   Case "BARCODESEQ":z4015.BarcodeSeq = Children(i).Code
   Case "SIZENO":z4015.SizeNo = Children(i).Code
   Case "BARCODE":z4015.Barcode = Children(i).Code
   Case "BARCODESCAN":z4015.BarcodeScan = Children(i).Code
   Case "DATESTITCHING":z4015.DateStitching = Children(i).Code
   Case "DATESTITCHINGPOSTED":z4015.DateStitchingPosted = Children(i).Code
   Case "CHECKSTITCHINGL":z4015.CheckStitchingL = Children(i).Code
   Case "CHECKSTITCHINGR":z4015.CheckStitchingR = Children(i).Code
   Case "CHECKCOMPLETESTITCHING":z4015.CheckCompleteStitching = Children(i).Code
   Case "QTYSTITCHING":z4015.QtyStitching = Children(i).Code
   Case "QTYSTITCHINGA":z4015.QtyStitchingA = Children(i).Code
   Case "QTYSTITCHINGX":z4015.QtyStitchingX = Children(i).Code
   Case "QTYSTITCHINGBLOUT":z4015.QtyStitchingBLOut = Children(i).Code
   Case "QTYSTITCHINGBLIN":z4015.QtyStitchingBLIn = Children(i).Code
   Case "DATEASSEMBLY":z4015.DateAssembly = Children(i).Code
   Case "DATEASSEMBLYPOSTED":z4015.DateAssemblyPosted = Children(i).Code
   Case "CHECKASSEMBLYL":z4015.CheckAssemblyL = Children(i).Code
   Case "CHECKASSEMBLYR":z4015.CheckAssemblyR = Children(i).Code
   Case "CHECKCOMPLETEASSEMBLY":z4015.CheckCompleteAssembly = Children(i).Code
   Case "QTYASSEMBLY":z4015.QtyAssembly = Children(i).Code
   Case "QTYASSEMBLYA":z4015.QtyAssemblyA = Children(i).Code
   Case "QTYASSEMBLYX":z4015.QtyAssemblyX = Children(i).Code
   Case "QTYASSEMBLYBLOUT":z4015.QtyAssemblyBLOut = Children(i).Code
   Case "QTYASSEMBLYBLIN":z4015.QtyAssemblyBLIn = Children(i).Code
   Case "DATEPACKING":z4015.DatePacking = Children(i).Code
   Case "DATEPACKINGPOSTED":z4015.DatePackingPosted = Children(i).Code
   Case "CHECKPACKINGL":z4015.CheckPackingL = Children(i).Code
   Case "CHECKPACKINGR":z4015.CheckPackingR = Children(i).Code
   Case "CHECKCOMPLETEPACKING":z4015.CheckCompletePacking = Children(i).Code
   Case "QTYPACKING":z4015.QtyPacking = Children(i).Code
   Case "QTYPACKINGA":z4015.QtyPackingA = Children(i).Code
   Case "QTYPACKINGX":z4015.QtyPackingX = Children(i).Code
   Case "QTYPACKINGBLOUT":z4015.QtyPackingBLOut = Children(i).Code
   Case "QTYPACKINGBLIN":z4015.QtyPackingBLIn = Children(i).Code
   Case "DATEINSERT":z4015.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z4015.InchargeInsert = Children(i).Code
   Case "DATEUPDATE":z4015.DateUpdate = Children(i).Code
   Case "REMARK":z4015.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "JOBCARD":z4015.JobCard = Children(i).Data
   Case "BARCODESEQ":z4015.BarcodeSeq = Children(i).Data
   Case "SIZENO":z4015.SizeNo = Children(i).Data
   Case "BARCODE":z4015.Barcode = Children(i).Data
   Case "BARCODESCAN":z4015.BarcodeScan = Children(i).Data
   Case "DATESTITCHING":z4015.DateStitching = Children(i).Data
   Case "DATESTITCHINGPOSTED":z4015.DateStitchingPosted = Children(i).Data
   Case "CHECKSTITCHINGL":z4015.CheckStitchingL = Children(i).Data
   Case "CHECKSTITCHINGR":z4015.CheckStitchingR = Children(i).Data
   Case "CHECKCOMPLETESTITCHING":z4015.CheckCompleteStitching = Children(i).Data
   Case "QTYSTITCHING":z4015.QtyStitching = Children(i).Data
   Case "QTYSTITCHINGA":z4015.QtyStitchingA = Children(i).Data
   Case "QTYSTITCHINGX":z4015.QtyStitchingX = Children(i).Data
   Case "QTYSTITCHINGBLOUT":z4015.QtyStitchingBLOut = Children(i).Data
   Case "QTYSTITCHINGBLIN":z4015.QtyStitchingBLIn = Children(i).Data
   Case "DATEASSEMBLY":z4015.DateAssembly = Children(i).Data
   Case "DATEASSEMBLYPOSTED":z4015.DateAssemblyPosted = Children(i).Data
   Case "CHECKASSEMBLYL":z4015.CheckAssemblyL = Children(i).Data
   Case "CHECKASSEMBLYR":z4015.CheckAssemblyR = Children(i).Data
   Case "CHECKCOMPLETEASSEMBLY":z4015.CheckCompleteAssembly = Children(i).Data
   Case "QTYASSEMBLY":z4015.QtyAssembly = Children(i).Data
   Case "QTYASSEMBLYA":z4015.QtyAssemblyA = Children(i).Data
   Case "QTYASSEMBLYX":z4015.QtyAssemblyX = Children(i).Data
   Case "QTYASSEMBLYBLOUT":z4015.QtyAssemblyBLOut = Children(i).Data
   Case "QTYASSEMBLYBLIN":z4015.QtyAssemblyBLIn = Children(i).Data
   Case "DATEPACKING":z4015.DatePacking = Children(i).Data
   Case "DATEPACKINGPOSTED":z4015.DatePackingPosted = Children(i).Data
   Case "CHECKPACKINGL":z4015.CheckPackingL = Children(i).Data
   Case "CHECKPACKINGR":z4015.CheckPackingR = Children(i).Data
   Case "CHECKCOMPLETEPACKING":z4015.CheckCompletePacking = Children(i).Data
   Case "QTYPACKING":z4015.QtyPacking = Children(i).Data
   Case "QTYPACKINGA":z4015.QtyPackingA = Children(i).Data
   Case "QTYPACKINGX":z4015.QtyPackingX = Children(i).Data
   Case "QTYPACKINGBLOUT":z4015.QtyPackingBLOut = Children(i).Data
   Case "QTYPACKINGBLIN":z4015.QtyPackingBLIn = Children(i).Data
   Case "DATEINSERT":z4015.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z4015.InchargeInsert = Children(i).Data
   Case "DATEUPDATE":z4015.DateUpdate = Children(i).Data
   Case "REMARK":z4015.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4015_MOVE",vbCritical)
End Try
End Function 
    
End Module 
