'=========================================================================================================================================================
'   TABLE : (PFK7356)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7356

Structure T7356_AREA
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

Public D7356 As T7356_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7356(PROCESSBOMCODE AS String, PROCESSBOMSEQ AS Double) As Boolean
    READ_PFK7356 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7356 "
    SQL = SQL & " WHERE K7356_ProcessBOMCode		 = '" & ProcessBOMCode & "' " 
    SQL = SQL & "   AND K7356_ProcessBOMSeq		 =  " & ProcessBOMSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7356_CLEAR: GoTo SKIP_READ_PFK7356
                
    Call K7356_MOVE(rd)
    READ_PFK7356 = True

SKIP_READ_PFK7356:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7356",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7356(PROCESSBOMCODE AS String, PROCESSBOMSEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7356 "
    SQL = SQL & " WHERE K7356_ProcessBOMCode		 = '" & ProcessBOMCode & "' " 
    SQL = SQL & "   AND K7356_ProcessBOMSeq		 =  " & ProcessBOMSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7356",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7356(z7356 As T7356_AREA) As Boolean
    WRITE_PFK7356 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7356)
 
    SQL = " INSERT INTO PFK7356 "
    SQL = SQL & " ( "
    SQL = SQL & " K7356_ProcessBOMCode," 
    SQL = SQL & " K7356_ProcessBOMSeq," 
    SQL = SQL & " K7356_Dseq," 
    SQL = SQL & " K7356_seMainProcess," 
    SQL = SQL & " K7356_cdMainProcess," 
    SQL = SQL & " K7356_seSubProcess," 
    SQL = SQL & " K7356_cdSubProcess," 
    SQL = SQL & " K7356_Description," 
    SQL = SQL & " K7356_Loss," 
    SQL = SQL & " K7356_QtyDateStandard," 
    SQL = SQL & " K7356_QtyDateMin," 
    SQL = SQL & " K7356_QtyDateMax," 
    SQL = SQL & " K7356_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7356.ProcessBOMCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z7356.ProcessBOMSeq) & ", "  
    SQL = SQL & "   " & FormatSQL(z7356.Dseq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7356.seMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7356.cdMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7356.seSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7356.cdSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7356.Description) & "', "  
    SQL = SQL & "   " & FormatSQL(z7356.Loss) & ", "  
    SQL = SQL & "   " & FormatSQL(z7356.QtyDateStandard) & ", "  
    SQL = SQL & "   " & FormatSQL(z7356.QtyDateMin) & ", "  
    SQL = SQL & "   " & FormatSQL(z7356.QtyDateMax) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7356.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7356 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7356",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7356(z7356 As T7356_AREA) As Boolean
    REWRITE_PFK7356 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7356)
   
    SQL = " UPDATE PFK7356 SET "
    SQL = SQL & "    K7356_Dseq      =  " & FormatSQL(z7356.Dseq) & ", " 
    SQL = SQL & "    K7356_seMainProcess      = N'" & FormatSQL(z7356.seMainProcess) & "', " 
    SQL = SQL & "    K7356_cdMainProcess      = N'" & FormatSQL(z7356.cdMainProcess) & "', " 
    SQL = SQL & "    K7356_seSubProcess      = N'" & FormatSQL(z7356.seSubProcess) & "', " 
    SQL = SQL & "    K7356_cdSubProcess      = N'" & FormatSQL(z7356.cdSubProcess) & "', " 
    SQL = SQL & "    K7356_Description      = N'" & FormatSQL(z7356.Description) & "', " 
    SQL = SQL & "    K7356_Loss      =  " & FormatSQL(z7356.Loss) & ", " 
    SQL = SQL & "    K7356_QtyDateStandard      =  " & FormatSQL(z7356.QtyDateStandard) & ", " 
    SQL = SQL & "    K7356_QtyDateMin      =  " & FormatSQL(z7356.QtyDateMin) & ", " 
    SQL = SQL & "    K7356_QtyDateMax      =  " & FormatSQL(z7356.QtyDateMax) & ", " 
    SQL = SQL & "    K7356_Remark      = N'" & FormatSQL(z7356.Remark) & "'  " 
    SQL = SQL & " WHERE K7356_ProcessBOMCode		 = '" & z7356.ProcessBOMCode & "' " 
    SQL = SQL & "   AND K7356_ProcessBOMSeq		 =  " & z7356.ProcessBOMSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7356 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7356",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7356(z7356 As T7356_AREA) As Boolean
    DELETE_PFK7356 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7356 "
    SQL = SQL & " WHERE K7356_ProcessBOMCode		 = '" & z7356.ProcessBOMCode & "' " 
    SQL = SQL & "   AND K7356_ProcessBOMSeq		 =  " & z7356.ProcessBOMSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7356 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7356",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7356_CLEAR()
Try
    
   D7356.ProcessBOMCode = ""
    D7356.ProcessBOMSeq = 0 
    D7356.Dseq = 0 
   D7356.seMainProcess = ""
   D7356.cdMainProcess = ""
   D7356.seSubProcess = ""
   D7356.cdSubProcess = ""
   D7356.Description = ""
    D7356.Loss = 0 
    D7356.QtyDateStandard = 0 
    D7356.QtyDateMin = 0 
    D7356.QtyDateMax = 0 
   D7356.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7356_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7356 As T7356_AREA)
Try
    
    x7356.ProcessBOMCode = trim$(  x7356.ProcessBOMCode)
    x7356.ProcessBOMSeq = trim$(  x7356.ProcessBOMSeq)
    x7356.Dseq = trim$(  x7356.Dseq)
    x7356.seMainProcess = trim$(  x7356.seMainProcess)
    x7356.cdMainProcess = trim$(  x7356.cdMainProcess)
    x7356.seSubProcess = trim$(  x7356.seSubProcess)
    x7356.cdSubProcess = trim$(  x7356.cdSubProcess)
    x7356.Description = trim$(  x7356.Description)
    x7356.Loss = trim$(  x7356.Loss)
    x7356.QtyDateStandard = trim$(  x7356.QtyDateStandard)
    x7356.QtyDateMin = trim$(  x7356.QtyDateMin)
    x7356.QtyDateMax = trim$(  x7356.QtyDateMax)
    x7356.Remark = trim$(  x7356.Remark)
     
    If trim$( x7356.ProcessBOMCode ) = "" Then x7356.ProcessBOMCode = Space(1) 
    If trim$( x7356.ProcessBOMSeq ) = "" Then x7356.ProcessBOMSeq = 0 
    If trim$( x7356.Dseq ) = "" Then x7356.Dseq = 0 
    If trim$( x7356.seMainProcess ) = "" Then x7356.seMainProcess = Space(1) 
    If trim$( x7356.cdMainProcess ) = "" Then x7356.cdMainProcess = Space(1) 
    If trim$( x7356.seSubProcess ) = "" Then x7356.seSubProcess = Space(1) 
    If trim$( x7356.cdSubProcess ) = "" Then x7356.cdSubProcess = Space(1) 
    If trim$( x7356.Description ) = "" Then x7356.Description = Space(1) 
    If trim$( x7356.Loss ) = "" Then x7356.Loss = 0 
    If trim$( x7356.QtyDateStandard ) = "" Then x7356.QtyDateStandard = 0 
    If trim$( x7356.QtyDateMin ) = "" Then x7356.QtyDateMin = 0 
    If trim$( x7356.QtyDateMax ) = "" Then x7356.QtyDateMax = 0 
    If trim$( x7356.Remark ) = "" Then x7356.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7356_MOVE(rs7356 As SqlClient.SqlDataReader)
Try

    call D7356_CLEAR()   

    If IsdbNull(rs7356!K7356_ProcessBOMCode) = False Then D7356.ProcessBOMCode = Trim$(rs7356!K7356_ProcessBOMCode)
    If IsdbNull(rs7356!K7356_ProcessBOMSeq) = False Then D7356.ProcessBOMSeq = Trim$(rs7356!K7356_ProcessBOMSeq)
    If IsdbNull(rs7356!K7356_Dseq) = False Then D7356.Dseq = Trim$(rs7356!K7356_Dseq)
    If IsdbNull(rs7356!K7356_seMainProcess) = False Then D7356.seMainProcess = Trim$(rs7356!K7356_seMainProcess)
    If IsdbNull(rs7356!K7356_cdMainProcess) = False Then D7356.cdMainProcess = Trim$(rs7356!K7356_cdMainProcess)
    If IsdbNull(rs7356!K7356_seSubProcess) = False Then D7356.seSubProcess = Trim$(rs7356!K7356_seSubProcess)
    If IsdbNull(rs7356!K7356_cdSubProcess) = False Then D7356.cdSubProcess = Trim$(rs7356!K7356_cdSubProcess)
    If IsdbNull(rs7356!K7356_Description) = False Then D7356.Description = Trim$(rs7356!K7356_Description)
    If IsdbNull(rs7356!K7356_Loss) = False Then D7356.Loss = Trim$(rs7356!K7356_Loss)
    If IsdbNull(rs7356!K7356_QtyDateStandard) = False Then D7356.QtyDateStandard = Trim$(rs7356!K7356_QtyDateStandard)
    If IsdbNull(rs7356!K7356_QtyDateMin) = False Then D7356.QtyDateMin = Trim$(rs7356!K7356_QtyDateMin)
    If IsdbNull(rs7356!K7356_QtyDateMax) = False Then D7356.QtyDateMax = Trim$(rs7356!K7356_QtyDateMax)
    If IsdbNull(rs7356!K7356_Remark) = False Then D7356.Remark = Trim$(rs7356!K7356_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7356_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7356_MOVE(rs7356 As DataRow)
Try

    call D7356_CLEAR()   

    If IsdbNull(rs7356!K7356_ProcessBOMCode) = False Then D7356.ProcessBOMCode = Trim$(rs7356!K7356_ProcessBOMCode)
    If IsdbNull(rs7356!K7356_ProcessBOMSeq) = False Then D7356.ProcessBOMSeq = Trim$(rs7356!K7356_ProcessBOMSeq)
    If IsdbNull(rs7356!K7356_Dseq) = False Then D7356.Dseq = Trim$(rs7356!K7356_Dseq)
    If IsdbNull(rs7356!K7356_seMainProcess) = False Then D7356.seMainProcess = Trim$(rs7356!K7356_seMainProcess)
    If IsdbNull(rs7356!K7356_cdMainProcess) = False Then D7356.cdMainProcess = Trim$(rs7356!K7356_cdMainProcess)
    If IsdbNull(rs7356!K7356_seSubProcess) = False Then D7356.seSubProcess = Trim$(rs7356!K7356_seSubProcess)
    If IsdbNull(rs7356!K7356_cdSubProcess) = False Then D7356.cdSubProcess = Trim$(rs7356!K7356_cdSubProcess)
    If IsdbNull(rs7356!K7356_Description) = False Then D7356.Description = Trim$(rs7356!K7356_Description)
    If IsdbNull(rs7356!K7356_Loss) = False Then D7356.Loss = Trim$(rs7356!K7356_Loss)
    If IsdbNull(rs7356!K7356_QtyDateStandard) = False Then D7356.QtyDateStandard = Trim$(rs7356!K7356_QtyDateStandard)
    If IsdbNull(rs7356!K7356_QtyDateMin) = False Then D7356.QtyDateMin = Trim$(rs7356!K7356_QtyDateMin)
    If IsdbNull(rs7356!K7356_QtyDateMax) = False Then D7356.QtyDateMax = Trim$(rs7356!K7356_QtyDateMax)
    If IsdbNull(rs7356!K7356_Remark) = False Then D7356.Remark = Trim$(rs7356!K7356_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7356_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7356_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7356 As T7356_AREA, PROCESSBOMCODE AS String, PROCESSBOMSEQ AS Double) as Boolean

K7356_MOVE = False

Try
    If READ_PFK7356(PROCESSBOMCODE, PROCESSBOMSEQ) = True Then
                z7356 = D7356
		K7356_MOVE = True
		else
	z7356 = nothing
     End If

     If  getColumIndex(spr,"ProcessBOMCode") > -1 then z7356.ProcessBOMCode = getDataM(spr, getColumIndex(spr,"ProcessBOMCode"), xRow)
     If  getColumIndex(spr,"ProcessBOMSeq") > -1 then z7356.ProcessBOMSeq = getDataM(spr, getColumIndex(spr,"ProcessBOMSeq"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z7356.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z7356.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z7356.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z7356.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z7356.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z7356.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"Loss") > -1 then z7356.Loss = getDataM(spr, getColumIndex(spr,"Loss"), xRow)
     If  getColumIndex(spr,"QtyDateStandard") > -1 then z7356.QtyDateStandard = getDataM(spr, getColumIndex(spr,"QtyDateStandard"), xRow)
     If  getColumIndex(spr,"QtyDateMin") > -1 then z7356.QtyDateMin = getDataM(spr, getColumIndex(spr,"QtyDateMin"), xRow)
     If  getColumIndex(spr,"QtyDateMax") > -1 then z7356.QtyDateMax = getDataM(spr, getColumIndex(spr,"QtyDateMax"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7356.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7356_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7356_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7356 As T7356_AREA,CheckClear as Boolean,PROCESSBOMCODE AS String, PROCESSBOMSEQ AS Double) as Boolean

K7356_MOVE = False

Try
    If READ_PFK7356(PROCESSBOMCODE, PROCESSBOMSEQ) = True Then
                z7356 = D7356
		K7356_MOVE = True
		else
	If CheckClear  = True then z7356 = nothing
     End If

     If  getColumIndex(spr,"ProcessBOMCode") > -1 then z7356.ProcessBOMCode = getDataM(spr, getColumIndex(spr,"ProcessBOMCode"), xRow)
     If  getColumIndex(spr,"ProcessBOMSeq") > -1 then z7356.ProcessBOMSeq = getDataM(spr, getColumIndex(spr,"ProcessBOMSeq"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z7356.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z7356.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z7356.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z7356.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z7356.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z7356.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"Loss") > -1 then z7356.Loss = getDataM(spr, getColumIndex(spr,"Loss"), xRow)
     If  getColumIndex(spr,"QtyDateStandard") > -1 then z7356.QtyDateStandard = getDataM(spr, getColumIndex(spr,"QtyDateStandard"), xRow)
     If  getColumIndex(spr,"QtyDateMin") > -1 then z7356.QtyDateMin = getDataM(spr, getColumIndex(spr,"QtyDateMin"), xRow)
     If  getColumIndex(spr,"QtyDateMax") > -1 then z7356.QtyDateMax = getDataM(spr, getColumIndex(spr,"QtyDateMax"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7356.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7356_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7356_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7356 As T7356_AREA, Job as String, PROCESSBOMCODE AS String, PROCESSBOMSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7356_MOVE = False

Try
    If READ_PFK7356(PROCESSBOMCODE, PROCESSBOMSEQ) = True Then
                z7356 = D7356
		K7356_MOVE = True
		else
	z7356 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7356")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PROCESSBOMCODE":z7356.ProcessBOMCode = Children(i).Code
   Case "PROCESSBOMSEQ":z7356.ProcessBOMSeq = Children(i).Code
   Case "DSEQ":z7356.Dseq = Children(i).Code
   Case "SEMAINPROCESS":z7356.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z7356.cdMainProcess = Children(i).Code
   Case "SESUBPROCESS":z7356.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z7356.cdSubProcess = Children(i).Code
   Case "DESCRIPTION":z7356.Description = Children(i).Code
   Case "LOSS":z7356.Loss = Children(i).Code
   Case "QTYDATESTANDARD":z7356.QtyDateStandard = Children(i).Code
   Case "QTYDATEMIN":z7356.QtyDateMin = Children(i).Code
   Case "QTYDATEMAX":z7356.QtyDateMax = Children(i).Code
   Case "REMARK":z7356.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PROCESSBOMCODE":z7356.ProcessBOMCode = Children(i).Data
   Case "PROCESSBOMSEQ":z7356.ProcessBOMSeq = Children(i).Data
   Case "DSEQ":z7356.Dseq = Children(i).Data
   Case "SEMAINPROCESS":z7356.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z7356.cdMainProcess = Children(i).Data
   Case "SESUBPROCESS":z7356.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z7356.cdSubProcess = Children(i).Data
   Case "DESCRIPTION":z7356.Description = Children(i).Data
   Case "LOSS":z7356.Loss = Children(i).Data
   Case "QTYDATESTANDARD":z7356.QtyDateStandard = Children(i).Data
   Case "QTYDATEMIN":z7356.QtyDateMin = Children(i).Data
   Case "QTYDATEMAX":z7356.QtyDateMax = Children(i).Data
   Case "REMARK":z7356.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7356_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7356_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7356 As T7356_AREA, Job as String, CheckClear as Boolean, PROCESSBOMCODE AS String, PROCESSBOMSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7356_MOVE = False

Try
    If READ_PFK7356(PROCESSBOMCODE, PROCESSBOMSEQ) = True Then
                z7356 = D7356
		K7356_MOVE = True
		else
	If CheckClear  = True then z7356 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7356")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PROCESSBOMCODE":z7356.ProcessBOMCode = Children(i).Code
   Case "PROCESSBOMSEQ":z7356.ProcessBOMSeq = Children(i).Code
   Case "DSEQ":z7356.Dseq = Children(i).Code
   Case "SEMAINPROCESS":z7356.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z7356.cdMainProcess = Children(i).Code
   Case "SESUBPROCESS":z7356.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z7356.cdSubProcess = Children(i).Code
   Case "DESCRIPTION":z7356.Description = Children(i).Code
   Case "LOSS":z7356.Loss = Children(i).Code
   Case "QTYDATESTANDARD":z7356.QtyDateStandard = Children(i).Code
   Case "QTYDATEMIN":z7356.QtyDateMin = Children(i).Code
   Case "QTYDATEMAX":z7356.QtyDateMax = Children(i).Code
   Case "REMARK":z7356.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PROCESSBOMCODE":z7356.ProcessBOMCode = Children(i).Data
   Case "PROCESSBOMSEQ":z7356.ProcessBOMSeq = Children(i).Data
   Case "DSEQ":z7356.Dseq = Children(i).Data
   Case "SEMAINPROCESS":z7356.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z7356.cdMainProcess = Children(i).Data
   Case "SESUBPROCESS":z7356.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z7356.cdSubProcess = Children(i).Data
   Case "DESCRIPTION":z7356.Description = Children(i).Data
   Case "LOSS":z7356.Loss = Children(i).Data
   Case "QTYDATESTANDARD":z7356.QtyDateStandard = Children(i).Data
   Case "QTYDATEMIN":z7356.QtyDateMin = Children(i).Data
   Case "QTYDATEMAX":z7356.QtyDateMax = Children(i).Data
   Case "REMARK":z7356.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7356_MOVE",vbCritical)
End Try
End Function 
    
End Module 
