'=========================================================================================================================================================
'   TABLE : (PFK7326)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7326

Structure T7326_AREA
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
Public 	Cost	 AS Double	'			decimal
Public 	Loss	 AS Double	'			decimal
Public 	Remark	 AS String	'			nvarchar(500)
'=========================================================================================================================================================
End structure

Public D7326 As T7326_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7326(PROCESSBOMCODE AS String, PROCESSBOMSEQ AS Double) As Boolean
    READ_PFK7326 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7326 "
    SQL = SQL & " WHERE K7326_ProcessBOMCode		 = '" & ProcessBOMCode & "' " 
    SQL = SQL & "   AND K7326_ProcessBOMSeq		 =  " & ProcessBOMSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7326_CLEAR: GoTo SKIP_READ_PFK7326
                
    Call K7326_MOVE(rd)
    READ_PFK7326 = True

SKIP_READ_PFK7326:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7326",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7326(PROCESSBOMCODE AS String, PROCESSBOMSEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7326 "
    SQL = SQL & " WHERE K7326_ProcessBOMCode		 = '" & ProcessBOMCode & "' " 
    SQL = SQL & "   AND K7326_ProcessBOMSeq		 =  " & ProcessBOMSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7326",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7326(z7326 As T7326_AREA) As Boolean
    WRITE_PFK7326 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7326)
 
    SQL = " INSERT INTO PFK7326 "
    SQL = SQL & " ( "
    SQL = SQL & " K7326_ProcessBOMCode," 
    SQL = SQL & " K7326_ProcessBOMSeq," 
    SQL = SQL & " K7326_Dseq," 
    SQL = SQL & " K7326_seMainProcess," 
    SQL = SQL & " K7326_cdMainProcess," 
    SQL = SQL & " K7326_seSubProcess," 
    SQL = SQL & " K7326_cdSubProcess," 
    SQL = SQL & " K7326_Description," 
    SQL = SQL & " K7326_Cost," 
    SQL = SQL & " K7326_Loss," 
    SQL = SQL & " K7326_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7326.ProcessBOMCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z7326.ProcessBOMSeq) & ", "  
    SQL = SQL & "   " & FormatSQL(z7326.Dseq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7326.seMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7326.cdMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7326.seSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7326.cdSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7326.Description) & "', "  
    SQL = SQL & "   " & FormatSQL(z7326.Cost) & ", "  
    SQL = SQL & "   " & FormatSQL(z7326.Loss) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7326.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7326 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7326",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7326(z7326 As T7326_AREA) As Boolean
    REWRITE_PFK7326 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7326)
   
    SQL = " UPDATE PFK7326 SET "
    SQL = SQL & "    K7326_Dseq      =  " & FormatSQL(z7326.Dseq) & ", " 
    SQL = SQL & "    K7326_seMainProcess      = N'" & FormatSQL(z7326.seMainProcess) & "', " 
    SQL = SQL & "    K7326_cdMainProcess      = N'" & FormatSQL(z7326.cdMainProcess) & "', " 
    SQL = SQL & "    K7326_seSubProcess      = N'" & FormatSQL(z7326.seSubProcess) & "', " 
    SQL = SQL & "    K7326_cdSubProcess      = N'" & FormatSQL(z7326.cdSubProcess) & "', " 
    SQL = SQL & "    K7326_Description      = N'" & FormatSQL(z7326.Description) & "', " 
    SQL = SQL & "    K7326_Cost      =  " & FormatSQL(z7326.Cost) & ", " 
    SQL = SQL & "    K7326_Loss      =  " & FormatSQL(z7326.Loss) & ", " 
    SQL = SQL & "    K7326_Remark      = N'" & FormatSQL(z7326.Remark) & "'  " 
    SQL = SQL & " WHERE K7326_ProcessBOMCode		 = '" & z7326.ProcessBOMCode & "' " 
    SQL = SQL & "   AND K7326_ProcessBOMSeq		 =  " & z7326.ProcessBOMSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7326 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7326",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7326(z7326 As T7326_AREA) As Boolean
    DELETE_PFK7326 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7326 "
    SQL = SQL & " WHERE K7326_ProcessBOMCode		 = '" & z7326.ProcessBOMCode & "' " 
    SQL = SQL & "   AND K7326_ProcessBOMSeq		 =  " & z7326.ProcessBOMSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7326 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7326",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7326_CLEAR()
Try
    
   D7326.ProcessBOMCode = ""
    D7326.ProcessBOMSeq = 0 
    D7326.Dseq = 0 
   D7326.seMainProcess = ""
   D7326.cdMainProcess = ""
   D7326.seSubProcess = ""
   D7326.cdSubProcess = ""
   D7326.Description = ""
    D7326.Cost = 0 
    D7326.Loss = 0 
   D7326.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7326_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7326 As T7326_AREA)
Try
    
    x7326.ProcessBOMCode = trim$(  x7326.ProcessBOMCode)
    x7326.ProcessBOMSeq = trim$(  x7326.ProcessBOMSeq)
    x7326.Dseq = trim$(  x7326.Dseq)
    x7326.seMainProcess = trim$(  x7326.seMainProcess)
    x7326.cdMainProcess = trim$(  x7326.cdMainProcess)
    x7326.seSubProcess = trim$(  x7326.seSubProcess)
    x7326.cdSubProcess = trim$(  x7326.cdSubProcess)
    x7326.Description = trim$(  x7326.Description)
    x7326.Cost = trim$(  x7326.Cost)
    x7326.Loss = trim$(  x7326.Loss)
    x7326.Remark = trim$(  x7326.Remark)
     
    If trim$( x7326.ProcessBOMCode ) = "" Then x7326.ProcessBOMCode = Space(1) 
    If trim$( x7326.ProcessBOMSeq ) = "" Then x7326.ProcessBOMSeq = 0 
    If trim$( x7326.Dseq ) = "" Then x7326.Dseq = 0 
    If trim$( x7326.seMainProcess ) = "" Then x7326.seMainProcess = Space(1) 
    If trim$( x7326.cdMainProcess ) = "" Then x7326.cdMainProcess = Space(1) 
    If trim$( x7326.seSubProcess ) = "" Then x7326.seSubProcess = Space(1) 
    If trim$( x7326.cdSubProcess ) = "" Then x7326.cdSubProcess = Space(1) 
    If trim$( x7326.Description ) = "" Then x7326.Description = Space(1) 
    If trim$( x7326.Cost ) = "" Then x7326.Cost = 0 
    If trim$( x7326.Loss ) = "" Then x7326.Loss = 0 
    If trim$( x7326.Remark ) = "" Then x7326.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7326_MOVE(rs7326 As SqlClient.SqlDataReader)
Try

    call D7326_CLEAR()   

    If IsdbNull(rs7326!K7326_ProcessBOMCode) = False Then D7326.ProcessBOMCode = Trim$(rs7326!K7326_ProcessBOMCode)
    If IsdbNull(rs7326!K7326_ProcessBOMSeq) = False Then D7326.ProcessBOMSeq = Trim$(rs7326!K7326_ProcessBOMSeq)
    If IsdbNull(rs7326!K7326_Dseq) = False Then D7326.Dseq = Trim$(rs7326!K7326_Dseq)
    If IsdbNull(rs7326!K7326_seMainProcess) = False Then D7326.seMainProcess = Trim$(rs7326!K7326_seMainProcess)
    If IsdbNull(rs7326!K7326_cdMainProcess) = False Then D7326.cdMainProcess = Trim$(rs7326!K7326_cdMainProcess)
    If IsdbNull(rs7326!K7326_seSubProcess) = False Then D7326.seSubProcess = Trim$(rs7326!K7326_seSubProcess)
    If IsdbNull(rs7326!K7326_cdSubProcess) = False Then D7326.cdSubProcess = Trim$(rs7326!K7326_cdSubProcess)
    If IsdbNull(rs7326!K7326_Description) = False Then D7326.Description = Trim$(rs7326!K7326_Description)
    If IsdbNull(rs7326!K7326_Cost) = False Then D7326.Cost = Trim$(rs7326!K7326_Cost)
    If IsdbNull(rs7326!K7326_Loss) = False Then D7326.Loss = Trim$(rs7326!K7326_Loss)
    If IsdbNull(rs7326!K7326_Remark) = False Then D7326.Remark = Trim$(rs7326!K7326_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7326_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7326_MOVE(rs7326 As DataRow)
Try

    call D7326_CLEAR()   

    If IsdbNull(rs7326!K7326_ProcessBOMCode) = False Then D7326.ProcessBOMCode = Trim$(rs7326!K7326_ProcessBOMCode)
    If IsdbNull(rs7326!K7326_ProcessBOMSeq) = False Then D7326.ProcessBOMSeq = Trim$(rs7326!K7326_ProcessBOMSeq)
    If IsdbNull(rs7326!K7326_Dseq) = False Then D7326.Dseq = Trim$(rs7326!K7326_Dseq)
    If IsdbNull(rs7326!K7326_seMainProcess) = False Then D7326.seMainProcess = Trim$(rs7326!K7326_seMainProcess)
    If IsdbNull(rs7326!K7326_cdMainProcess) = False Then D7326.cdMainProcess = Trim$(rs7326!K7326_cdMainProcess)
    If IsdbNull(rs7326!K7326_seSubProcess) = False Then D7326.seSubProcess = Trim$(rs7326!K7326_seSubProcess)
    If IsdbNull(rs7326!K7326_cdSubProcess) = False Then D7326.cdSubProcess = Trim$(rs7326!K7326_cdSubProcess)
    If IsdbNull(rs7326!K7326_Description) = False Then D7326.Description = Trim$(rs7326!K7326_Description)
    If IsdbNull(rs7326!K7326_Cost) = False Then D7326.Cost = Trim$(rs7326!K7326_Cost)
    If IsdbNull(rs7326!K7326_Loss) = False Then D7326.Loss = Trim$(rs7326!K7326_Loss)
    If IsdbNull(rs7326!K7326_Remark) = False Then D7326.Remark = Trim$(rs7326!K7326_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7326_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7326_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7326 As T7326_AREA, PROCESSBOMCODE AS String, PROCESSBOMSEQ AS Double) as Boolean

K7326_MOVE = False

Try
    If READ_PFK7326(PROCESSBOMCODE, PROCESSBOMSEQ) = True Then
                z7326 = D7326
		K7326_MOVE = True
		else
	z7326 = nothing
     End If

     If  getColumIndex(spr,"ProcessBOMCode") > -1 then z7326.ProcessBOMCode = getDataM(spr, getColumIndex(spr,"ProcessBOMCode"), xRow)
     If  getColumIndex(spr,"ProcessBOMSeq") > -1 then z7326.ProcessBOMSeq = getDataM(spr, getColumIndex(spr,"ProcessBOMSeq"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z7326.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z7326.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z7326.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z7326.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z7326.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z7326.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"Cost") > -1 then z7326.Cost = getDataM(spr, getColumIndex(spr,"Cost"), xRow)
     If  getColumIndex(spr,"Loss") > -1 then z7326.Loss = getDataM(spr, getColumIndex(spr,"Loss"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7326.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7326_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7326_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7326 As T7326_AREA,CheckClear as Boolean,PROCESSBOMCODE AS String, PROCESSBOMSEQ AS Double) as Boolean

K7326_MOVE = False

Try
    If READ_PFK7326(PROCESSBOMCODE, PROCESSBOMSEQ) = True Then
                z7326 = D7326
		K7326_MOVE = True
		else
	If CheckClear  = True then z7326 = nothing
     End If

     If  getColumIndex(spr,"ProcessBOMCode") > -1 then z7326.ProcessBOMCode = getDataM(spr, getColumIndex(spr,"ProcessBOMCode"), xRow)
     If  getColumIndex(spr,"ProcessBOMSeq") > -1 then z7326.ProcessBOMSeq = getDataM(spr, getColumIndex(spr,"ProcessBOMSeq"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z7326.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z7326.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z7326.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z7326.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z7326.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"Description") > -1 then z7326.Description = getDataM(spr, getColumIndex(spr,"Description"), xRow)
     If  getColumIndex(spr,"Cost") > -1 then z7326.Cost = getDataM(spr, getColumIndex(spr,"Cost"), xRow)
     If  getColumIndex(spr,"Loss") > -1 then z7326.Loss = getDataM(spr, getColumIndex(spr,"Loss"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7326.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7326_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7326_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7326 As T7326_AREA, Job as String, PROCESSBOMCODE AS String, PROCESSBOMSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7326_MOVE = False

Try
    If READ_PFK7326(PROCESSBOMCODE, PROCESSBOMSEQ) = True Then
                z7326 = D7326
		K7326_MOVE = True
		else
	z7326 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7326")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PROCESSBOMCODE":z7326.ProcessBOMCode = Children(i).Code
   Case "PROCESSBOMSEQ":z7326.ProcessBOMSeq = Children(i).Code
   Case "DSEQ":z7326.Dseq = Children(i).Code
   Case "SEMAINPROCESS":z7326.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z7326.cdMainProcess = Children(i).Code
   Case "SESUBPROCESS":z7326.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z7326.cdSubProcess = Children(i).Code
   Case "DESCRIPTION":z7326.Description = Children(i).Code
   Case "COST":z7326.Cost = Children(i).Code
   Case "LOSS":z7326.Loss = Children(i).Code
   Case "REMARK":z7326.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PROCESSBOMCODE":z7326.ProcessBOMCode = Children(i).Data
   Case "PROCESSBOMSEQ":z7326.ProcessBOMSeq = Children(i).Data
   Case "DSEQ":z7326.Dseq = Children(i).Data
   Case "SEMAINPROCESS":z7326.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z7326.cdMainProcess = Children(i).Data
   Case "SESUBPROCESS":z7326.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z7326.cdSubProcess = Children(i).Data
   Case "DESCRIPTION":z7326.Description = Children(i).Data
   Case "COST":z7326.Cost = Children(i).Data
   Case "LOSS":z7326.Loss = Children(i).Data
   Case "REMARK":z7326.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7326_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7326_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7326 As T7326_AREA, Job as String, CheckClear as Boolean, PROCESSBOMCODE AS String, PROCESSBOMSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7326_MOVE = False

Try
    If READ_PFK7326(PROCESSBOMCODE, PROCESSBOMSEQ) = True Then
                z7326 = D7326
		K7326_MOVE = True
		else
	If CheckClear  = True then z7326 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7326")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PROCESSBOMCODE":z7326.ProcessBOMCode = Children(i).Code
   Case "PROCESSBOMSEQ":z7326.ProcessBOMSeq = Children(i).Code
   Case "DSEQ":z7326.Dseq = Children(i).Code
   Case "SEMAINPROCESS":z7326.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z7326.cdMainProcess = Children(i).Code
   Case "SESUBPROCESS":z7326.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z7326.cdSubProcess = Children(i).Code
   Case "DESCRIPTION":z7326.Description = Children(i).Code
   Case "COST":z7326.Cost = Children(i).Code
   Case "LOSS":z7326.Loss = Children(i).Code
   Case "REMARK":z7326.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PROCESSBOMCODE":z7326.ProcessBOMCode = Children(i).Data
   Case "PROCESSBOMSEQ":z7326.ProcessBOMSeq = Children(i).Data
   Case "DSEQ":z7326.Dseq = Children(i).Data
   Case "SEMAINPROCESS":z7326.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z7326.cdMainProcess = Children(i).Data
   Case "SESUBPROCESS":z7326.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z7326.cdSubProcess = Children(i).Data
   Case "DESCRIPTION":z7326.Description = Children(i).Data
   Case "COST":z7326.Cost = Children(i).Data
   Case "LOSS":z7326.Loss = Children(i).Data
   Case "REMARK":z7326.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7326_MOVE",vbCritical)
End Try
End Function 
    
End Module 
