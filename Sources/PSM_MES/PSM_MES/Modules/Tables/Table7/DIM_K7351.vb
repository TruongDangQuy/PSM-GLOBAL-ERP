'=========================================================================================================================================================
'   TABLE : (PFK7351)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7351

Structure T7351_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	ProcessBOMCode	 AS String	'			nvarchar(6)		*
Public 	ProcessBOMSeq	 AS Double	'			decimal		*
Public 	Dseq	 AS Double	'			decimal
Public 	seMainProcess	 AS String	'			char(3)
Public 	cdMainProcess	 AS String	'			char(3)
Public 	seSubProcess	 AS String	'			char(3)
Public 	cdSubProcess	 AS String	'			char(3)
Public 	Description	 AS String	'			nvarchar(200)
Public 	Loss	 AS Double	'			decimal
Public 	QtyDateStandard	 AS Double	'			decimal
Public 	QtyDateMin	 AS Double	'			decimal
Public 	QtyDateMax	 AS Double	'			decimal
Public 	Remark	 AS String	'			nvarchar(100)
'=========================================================================================================================================================
End structure

Public D7351 As T7351_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7351(PROCESSBOMCODE AS String, PROCESSBOMSEQ AS Double) As Boolean
    READ_PFK7351 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7351 "
    SQL = SQL & " WHERE K7351_ProcessBOMCode		 = '" & ProcessBOMCode & "' " 
    SQL = SQL & "   AND K7351_ProcessBOMSeq		 =  " & ProcessBOMSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7351_CLEAR: GoTo SKIP_READ_PFK7351
                
    Call K7351_MOVE(rd)
    READ_PFK7351 = True

SKIP_READ_PFK7351:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7351",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7351(PROCESSBOMCODE AS String, PROCESSBOMSEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7351 "
    SQL = SQL & " WHERE K7351_ProcessBOMCode		 = '" & ProcessBOMCode & "' " 
    SQL = SQL & "   AND K7351_ProcessBOMSeq		 =  " & ProcessBOMSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7351",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7351(z7351 As T7351_AREA) As Boolean
    WRITE_PFK7351 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7351)
 
    SQL = " INSERT INTO PFK7351 "
    SQL = SQL & " ( "
    SQL = SQL & " K7351_ProcessBOMCode," 
    SQL = SQL & " K7351_ProcessBOMSeq," 
    SQL = SQL & " K7351_Dseq," 
    SQL = SQL & " K7351_seMainProcess," 
    SQL = SQL & " K7351_cdMainProcess," 
    SQL = SQL & " K7351_seSubProcess," 
    SQL = SQL & " K7351_cdSubProcess," 
    SQL = SQL & " K7351_Description," 
    SQL = SQL & " K7351_Loss," 
    SQL = SQL & " K7351_QtyDateStandard," 
    SQL = SQL & " K7351_QtyDateMin," 
    SQL = SQL & " K7351_QtyDateMax," 
    SQL = SQL & " K7351_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7351.ProcessBOMCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z7351.ProcessBOMSeq) & ", "  
    SQL = SQL & "   " & FormatSQL(z7351.Dseq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7351.seMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7351.cdMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7351.seSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7351.cdSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7351.Description) & "', "  
    SQL = SQL & "   " & FormatSQL(z7351.Loss) & ", "  
    SQL = SQL & "   " & FormatSQL(z7351.QtyDateStandard) & ", "  
    SQL = SQL & "   " & FormatSQL(z7351.QtyDateMin) & ", "  
    SQL = SQL & "   " & FormatSQL(z7351.QtyDateMax) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7351.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7351 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7351",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7351(z7351 As T7351_AREA) As Boolean
    REWRITE_PFK7351 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7351)
   
    SQL = " UPDATE PFK7351 SET "
    SQL = SQL & "    K7351_Dseq      =  " & FormatSQL(z7351.Dseq) & ", " 
    SQL = SQL & "    K7351_seMainProcess      = N'" & FormatSQL(z7351.seMainProcess) & "', " 
    SQL = SQL & "    K7351_cdMainProcess      = N'" & FormatSQL(z7351.cdMainProcess) & "', " 
    SQL = SQL & "    K7351_seSubProcess      = N'" & FormatSQL(z7351.seSubProcess) & "', " 
    SQL = SQL & "    K7351_cdSubProcess      = N'" & FormatSQL(z7351.cdSubProcess) & "', " 
    SQL = SQL & "    K7351_Description      = N'" & FormatSQL(z7351.Description) & "', " 
    SQL = SQL & "    K7351_Loss      =  " & FormatSQL(z7351.Loss) & ", " 
    SQL = SQL & "    K7351_QtyDateStandard      =  " & FormatSQL(z7351.QtyDateStandard) & ", " 
    SQL = SQL & "    K7351_QtyDateMin      =  " & FormatSQL(z7351.QtyDateMin) & ", " 
    SQL = SQL & "    K7351_QtyDateMax      =  " & FormatSQL(z7351.QtyDateMax) & ", " 
    SQL = SQL & "    K7351_Remark      = N'" & FormatSQL(z7351.Remark) & "'  " 
    SQL = SQL & " WHERE K7351_ProcessBOMCode		 = '" & z7351.ProcessBOMCode & "' " 
    SQL = SQL & "   AND K7351_ProcessBOMSeq		 =  " & z7351.ProcessBOMSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7351 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7351",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7351(z7351 As T7351_AREA) As Boolean
    DELETE_PFK7351 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7351 "
    SQL = SQL & " WHERE K7351_ProcessBOMCode		 = '" & z7351.ProcessBOMCode & "' " 
    SQL = SQL & "   AND K7351_ProcessBOMSeq		 =  " & z7351.ProcessBOMSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7351 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7351",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7351_CLEAR()
Try
    
   D7351.ProcessBOMCode = ""
    D7351.ProcessBOMSeq = 0 
    D7351.Dseq = 0 
   D7351.seMainProcess = ""
   D7351.cdMainProcess = ""
   D7351.seSubProcess = ""
   D7351.cdSubProcess = ""
   D7351.Description = ""
    D7351.Loss = 0 
    D7351.QtyDateStandard = 0 
    D7351.QtyDateMin = 0 
    D7351.QtyDateMax = 0 
   D7351.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7351_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7351 As T7351_AREA)
Try
    
    x7351.ProcessBOMCode = trim$(  x7351.ProcessBOMCode)
    x7351.ProcessBOMSeq = trim$(  x7351.ProcessBOMSeq)
    x7351.Dseq = trim$(  x7351.Dseq)
    x7351.seMainProcess = trim$(  x7351.seMainProcess)
    x7351.cdMainProcess = trim$(  x7351.cdMainProcess)
    x7351.seSubProcess = trim$(  x7351.seSubProcess)
    x7351.cdSubProcess = trim$(  x7351.cdSubProcess)
    x7351.Description = trim$(  x7351.Description)
    x7351.Loss = trim$(  x7351.Loss)
    x7351.QtyDateStandard = trim$(  x7351.QtyDateStandard)
    x7351.QtyDateMin = trim$(  x7351.QtyDateMin)
    x7351.QtyDateMax = trim$(  x7351.QtyDateMax)
    x7351.Remark = trim$(  x7351.Remark)
     
    If trim$( x7351.ProcessBOMCode ) = "" Then x7351.ProcessBOMCode = Space(1) 
    If trim$( x7351.ProcessBOMSeq ) = "" Then x7351.ProcessBOMSeq = 0 
    If trim$( x7351.Dseq ) = "" Then x7351.Dseq = 0 
    If trim$( x7351.seMainProcess ) = "" Then x7351.seMainProcess = Space(1) 
    If trim$( x7351.cdMainProcess ) = "" Then x7351.cdMainProcess = Space(1) 
    If trim$( x7351.seSubProcess ) = "" Then x7351.seSubProcess = Space(1) 
    If trim$( x7351.cdSubProcess ) = "" Then x7351.cdSubProcess = Space(1) 
    If trim$( x7351.Description ) = "" Then x7351.Description = Space(1) 
    If trim$( x7351.Loss ) = "" Then x7351.Loss = 0 
    If trim$( x7351.QtyDateStandard ) = "" Then x7351.QtyDateStandard = 0 
    If trim$( x7351.QtyDateMin ) = "" Then x7351.QtyDateMin = 0 
    If trim$( x7351.QtyDateMax ) = "" Then x7351.QtyDateMax = 0 
    If trim$( x7351.Remark ) = "" Then x7351.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7351_MOVE(rs7351 As SqlClient.SqlDataReader)
Try

    call D7351_CLEAR()   

    If IsdbNull(rs7351!K7351_ProcessBOMCode) = False Then D7351.ProcessBOMCode = Trim$(rs7351!K7351_ProcessBOMCode)
    If IsdbNull(rs7351!K7351_ProcessBOMSeq) = False Then D7351.ProcessBOMSeq = Trim$(rs7351!K7351_ProcessBOMSeq)
    If IsdbNull(rs7351!K7351_Dseq) = False Then D7351.Dseq = Trim$(rs7351!K7351_Dseq)
    If IsdbNull(rs7351!K7351_seMainProcess) = False Then D7351.seMainProcess = Trim$(rs7351!K7351_seMainProcess)
    If IsdbNull(rs7351!K7351_cdMainProcess) = False Then D7351.cdMainProcess = Trim$(rs7351!K7351_cdMainProcess)
    If IsdbNull(rs7351!K7351_seSubProcess) = False Then D7351.seSubProcess = Trim$(rs7351!K7351_seSubProcess)
    If IsdbNull(rs7351!K7351_cdSubProcess) = False Then D7351.cdSubProcess = Trim$(rs7351!K7351_cdSubProcess)
    If IsdbNull(rs7351!K7351_Description) = False Then D7351.Description = Trim$(rs7351!K7351_Description)
    If IsdbNull(rs7351!K7351_Loss) = False Then D7351.Loss = Trim$(rs7351!K7351_Loss)
    If IsdbNull(rs7351!K7351_QtyDateStandard) = False Then D7351.QtyDateStandard = Trim$(rs7351!K7351_QtyDateStandard)
    If IsdbNull(rs7351!K7351_QtyDateMin) = False Then D7351.QtyDateMin = Trim$(rs7351!K7351_QtyDateMin)
    If IsdbNull(rs7351!K7351_QtyDateMax) = False Then D7351.QtyDateMax = Trim$(rs7351!K7351_QtyDateMax)
    If IsdbNull(rs7351!K7351_Remark) = False Then D7351.Remark = Trim$(rs7351!K7351_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7351_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7351_MOVE(rs7351 As DataRow)
Try

    call D7351_CLEAR()   

    If IsdbNull(rs7351!K7351_ProcessBOMCode) = False Then D7351.ProcessBOMCode = Trim$(rs7351!K7351_ProcessBOMCode)
    If IsdbNull(rs7351!K7351_ProcessBOMSeq) = False Then D7351.ProcessBOMSeq = Trim$(rs7351!K7351_ProcessBOMSeq)
    If IsdbNull(rs7351!K7351_Dseq) = False Then D7351.Dseq = Trim$(rs7351!K7351_Dseq)
    If IsdbNull(rs7351!K7351_seMainProcess) = False Then D7351.seMainProcess = Trim$(rs7351!K7351_seMainProcess)
    If IsdbNull(rs7351!K7351_cdMainProcess) = False Then D7351.cdMainProcess = Trim$(rs7351!K7351_cdMainProcess)
    If IsdbNull(rs7351!K7351_seSubProcess) = False Then D7351.seSubProcess = Trim$(rs7351!K7351_seSubProcess)
    If IsdbNull(rs7351!K7351_cdSubProcess) = False Then D7351.cdSubProcess = Trim$(rs7351!K7351_cdSubProcess)
    If IsdbNull(rs7351!K7351_Description) = False Then D7351.Description = Trim$(rs7351!K7351_Description)
    If IsdbNull(rs7351!K7351_Loss) = False Then D7351.Loss = Trim$(rs7351!K7351_Loss)
    If IsdbNull(rs7351!K7351_QtyDateStandard) = False Then D7351.QtyDateStandard = Trim$(rs7351!K7351_QtyDateStandard)
    If IsdbNull(rs7351!K7351_QtyDateMin) = False Then D7351.QtyDateMin = Trim$(rs7351!K7351_QtyDateMin)
    If IsdbNull(rs7351!K7351_QtyDateMax) = False Then D7351.QtyDateMax = Trim$(rs7351!K7351_QtyDateMax)
    If IsdbNull(rs7351!K7351_Remark) = False Then D7351.Remark = Trim$(rs7351!K7351_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7351_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7351_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7351 As T7351_AREA, PROCESSBOMCODE AS String, PROCESSBOMSEQ AS Double) as Boolean

K7351_MOVE = False

Try
    If READ_PFK7351(PROCESSBOMCODE, PROCESSBOMSEQ) = True Then
                z7351 = D7351
		K7351_MOVE = True
		else
	z7351 = nothing
     End If

     If  getColumIndex(spr,"ProcessBOMCode") > -1 then z7351.ProcessBOMCode = getDataM(spr, getColumIndex(spr,"ProcessBOMCode"), xRow)
     If  getColumIndex(spr,"ProcessBOMSeq") > -1 then z7351.ProcessBOMSeq = getDataM(spr, getColumIndex(spr,"ProcessBOMSeq"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z7351.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z7351.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z7351.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z7351.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z7351.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z7351.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"Loss") > -1 then z7351.Loss = getDataM(spr, getColumIndex(spr,"Loss"), xRow)
     If  getColumIndex(spr,"QtyDateStandard") > -1 then z7351.QtyDateStandard = getDataM(spr, getColumIndex(spr,"QtyDateStandard"), xRow)
     If  getColumIndex(spr,"QtyDateMin") > -1 then z7351.QtyDateMin = getDataM(spr, getColumIndex(spr,"QtyDateMin"), xRow)
     If  getColumIndex(spr,"QtyDateMax") > -1 then z7351.QtyDateMax = getDataM(spr, getColumIndex(spr,"QtyDateMax"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7351.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7351_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7351_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7351 As T7351_AREA,CheckClear as Boolean,PROCESSBOMCODE AS String, PROCESSBOMSEQ AS Double) as Boolean

K7351_MOVE = False

Try
    If READ_PFK7351(PROCESSBOMCODE, PROCESSBOMSEQ) = True Then
                z7351 = D7351
		K7351_MOVE = True
		else
	If CheckClear  = True then z7351 = nothing
     End If

     If  getColumIndex(spr,"ProcessBOMCode") > -1 then z7351.ProcessBOMCode = getDataM(spr, getColumIndex(spr,"ProcessBOMCode"), xRow)
     If  getColumIndex(spr,"ProcessBOMSeq") > -1 then z7351.ProcessBOMSeq = getDataM(spr, getColumIndex(spr,"ProcessBOMSeq"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z7351.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z7351.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z7351.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z7351.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z7351.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z7351.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"Loss") > -1 then z7351.Loss = getDataM(spr, getColumIndex(spr,"Loss"), xRow)
     If  getColumIndex(spr,"QtyDateStandard") > -1 then z7351.QtyDateStandard = getDataM(spr, getColumIndex(spr,"QtyDateStandard"), xRow)
     If  getColumIndex(spr,"QtyDateMin") > -1 then z7351.QtyDateMin = getDataM(spr, getColumIndex(spr,"QtyDateMin"), xRow)
     If  getColumIndex(spr,"QtyDateMax") > -1 then z7351.QtyDateMax = getDataM(spr, getColumIndex(spr,"QtyDateMax"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7351.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7351_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7351_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7351 As T7351_AREA, Job as String, PROCESSBOMCODE AS String, PROCESSBOMSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7351_MOVE = False

Try
    If READ_PFK7351(PROCESSBOMCODE, PROCESSBOMSEQ) = True Then
                z7351 = D7351
		K7351_MOVE = True
		else
	z7351 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7351")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PROCESSBOMCODE":z7351.ProcessBOMCode = Children(i).Code
   Case "PROCESSBOMSEQ":z7351.ProcessBOMSeq = Children(i).Code
   Case "DSEQ":z7351.Dseq = Children(i).Code
   Case "SEMAINPROCESS":z7351.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z7351.cdMainProcess = Children(i).Code
   Case "SESUBPROCESS":z7351.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z7351.cdSubProcess = Children(i).Code
   Case "DESCRIPTION":z7351.Description = Children(i).Code
   Case "LOSS":z7351.Loss = Children(i).Code
   Case "QTYDATESTANDARD":z7351.QtyDateStandard = Children(i).Code
   Case "QTYDATEMIN":z7351.QtyDateMin = Children(i).Code
   Case "QTYDATEMAX":z7351.QtyDateMax = Children(i).Code
   Case "REMARK":z7351.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PROCESSBOMCODE":z7351.ProcessBOMCode = Children(i).Data
   Case "PROCESSBOMSEQ":z7351.ProcessBOMSeq = Children(i).Data
   Case "DSEQ":z7351.Dseq = Children(i).Data
   Case "SEMAINPROCESS":z7351.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z7351.cdMainProcess = Children(i).Data
   Case "SESUBPROCESS":z7351.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z7351.cdSubProcess = Children(i).Data
   Case "DESCRIPTION":z7351.Description = Children(i).Data
   Case "LOSS":z7351.Loss = Children(i).Data
   Case "QTYDATESTANDARD":z7351.QtyDateStandard = Children(i).Data
   Case "QTYDATEMIN":z7351.QtyDateMin = Children(i).Data
   Case "QTYDATEMAX":z7351.QtyDateMax = Children(i).Data
   Case "REMARK":z7351.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7351_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7351_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7351 As T7351_AREA, Job as String, CheckClear as Boolean, PROCESSBOMCODE AS String, PROCESSBOMSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7351_MOVE = False

Try
    If READ_PFK7351(PROCESSBOMCODE, PROCESSBOMSEQ) = True Then
                z7351 = D7351
		K7351_MOVE = True
		else
	If CheckClear  = True then z7351 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7351")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PROCESSBOMCODE":z7351.ProcessBOMCode = Children(i).Code
   Case "PROCESSBOMSEQ":z7351.ProcessBOMSeq = Children(i).Code
   Case "DSEQ":z7351.Dseq = Children(i).Code
   Case "SEMAINPROCESS":z7351.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z7351.cdMainProcess = Children(i).Code
   Case "SESUBPROCESS":z7351.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z7351.cdSubProcess = Children(i).Code
   Case "DESCRIPTION":z7351.Description = Children(i).Code
   Case "LOSS":z7351.Loss = Children(i).Code
   Case "QTYDATESTANDARD":z7351.QtyDateStandard = Children(i).Code
   Case "QTYDATEMIN":z7351.QtyDateMin = Children(i).Code
   Case "QTYDATEMAX":z7351.QtyDateMax = Children(i).Code
   Case "REMARK":z7351.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PROCESSBOMCODE":z7351.ProcessBOMCode = Children(i).Data
   Case "PROCESSBOMSEQ":z7351.ProcessBOMSeq = Children(i).Data
   Case "DSEQ":z7351.Dseq = Children(i).Data
   Case "SEMAINPROCESS":z7351.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z7351.cdMainProcess = Children(i).Data
   Case "SESUBPROCESS":z7351.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z7351.cdSubProcess = Children(i).Data
   Case "DESCRIPTION":z7351.Description = Children(i).Data
   Case "LOSS":z7351.Loss = Children(i).Data
   Case "QTYDATESTANDARD":z7351.QtyDateStandard = Children(i).Data
   Case "QTYDATEMIN":z7351.QtyDateMin = Children(i).Data
   Case "QTYDATEMAX":z7351.QtyDateMax = Children(i).Data
   Case "REMARK":z7351.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7351_MOVE",vbCritical)
End Try
End Function 
    
End Module 
