'=========================================================================================================================================================
'   TABLE : (PFK7401)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7401

Structure T7401_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	IDNO	 AS String	'			char(8)		*
Public 	SpecNo	 AS String	'			char(9)		*
Public 	SpecNoSeq	 AS String	'			char(3)		*
Public 	DateConfirm	 AS String	'			char(8)
Public 	TimeConfirm	 AS String	'			char(14)
Public 	CheckConfirm	 AS String	'			char(1)
'=========================================================================================================================================================
End structure

Public D7401 As T7401_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7401(IDNO AS String, SPECNO AS String, SPECNOSEQ AS String) As Boolean
    READ_PFK7401 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7401 "
    SQL = SQL & " WHERE K7401_IDNO		 = '" & IDNO & "' " 
    SQL = SQL & "   AND K7401_SpecNo		 = '" & SpecNo & "' " 
    SQL = SQL & "   AND K7401_SpecNoSeq		 = '" & SpecNoSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7401_CLEAR: GoTo SKIP_READ_PFK7401
                
    Call K7401_MOVE(rd)
    READ_PFK7401 = True

SKIP_READ_PFK7401:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7401",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7401(IDNO AS String, SPECNO AS String, SPECNOSEQ AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7401 "
    SQL = SQL & " WHERE K7401_IDNO		 = '" & IDNO & "' " 
    SQL = SQL & "   AND K7401_SpecNo		 = '" & SpecNo & "' " 
    SQL = SQL & "   AND K7401_SpecNoSeq		 = '" & SpecNoSeq & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7401",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7401(z7401 As T7401_AREA) As Boolean
    WRITE_PFK7401 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7401)
 
    SQL = " INSERT INTO PFK7401 "
    SQL = SQL & " ( "
    SQL = SQL & " K7401_IDNO," 
    SQL = SQL & " K7401_SpecNo," 
    SQL = SQL & " K7401_SpecNoSeq," 
    SQL = SQL & " K7401_DateConfirm," 
    SQL = SQL & " K7401_TimeConfirm," 
    SQL = SQL & " K7401_CheckConfirm " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7401.IDNO) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7401.SpecNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7401.SpecNoSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7401.DateConfirm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7401.TimeConfirm) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7401.CheckConfirm) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7401 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7401",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7401(z7401 As T7401_AREA) As Boolean
    REWRITE_PFK7401 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7401)
   
    SQL = " UPDATE PFK7401 SET "
    SQL = SQL & "    K7401_DateConfirm      = N'" & FormatSQL(z7401.DateConfirm) & "', " 
    SQL = SQL & "    K7401_TimeConfirm      = N'" & FormatSQL(z7401.TimeConfirm) & "', " 
    SQL = SQL & "    K7401_CheckConfirm      = N'" & FormatSQL(z7401.CheckConfirm) & "'  " 
    SQL = SQL & " WHERE K7401_IDNO		 = '" & z7401.IDNO & "' " 
    SQL = SQL & "   AND K7401_SpecNo		 = '" & z7401.SpecNo & "' " 
    SQL = SQL & "   AND K7401_SpecNoSeq		 = '" & z7401.SpecNoSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7401 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7401",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7401(z7401 As T7401_AREA) As Boolean
    DELETE_PFK7401 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7401 "
    SQL = SQL & " WHERE K7401_IDNO		 = '" & z7401.IDNO & "' " 
    SQL = SQL & "   AND K7401_SpecNo		 = '" & z7401.SpecNo & "' " 
    SQL = SQL & "   AND K7401_SpecNoSeq		 = '" & z7401.SpecNoSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7401 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7401",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7401_CLEAR()
Try
    
   D7401.IDNO = ""
   D7401.SpecNo = ""
   D7401.SpecNoSeq = ""
   D7401.DateConfirm = ""
   D7401.TimeConfirm = ""
   D7401.CheckConfirm = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7401_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7401 As T7401_AREA)
Try
    
    x7401.IDNO = trim$(  x7401.IDNO)
    x7401.SpecNo = trim$(  x7401.SpecNo)
    x7401.SpecNoSeq = trim$(  x7401.SpecNoSeq)
    x7401.DateConfirm = trim$(  x7401.DateConfirm)
    x7401.TimeConfirm = trim$(  x7401.TimeConfirm)
    x7401.CheckConfirm = trim$(  x7401.CheckConfirm)
     
    If trim$( x7401.IDNO ) = "" Then x7401.IDNO = Space(1) 
    If trim$( x7401.SpecNo ) = "" Then x7401.SpecNo = Space(1) 
    If trim$( x7401.SpecNoSeq ) = "" Then x7401.SpecNoSeq = Space(1) 
    If trim$( x7401.DateConfirm ) = "" Then x7401.DateConfirm = Space(1) 
    If trim$( x7401.TimeConfirm ) = "" Then x7401.TimeConfirm = Space(1) 
    If trim$( x7401.CheckConfirm ) = "" Then x7401.CheckConfirm = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7401_MOVE(rs7401 As SqlClient.SqlDataReader)
Try

    call D7401_CLEAR()   

    If IsdbNull(rs7401!K7401_IDNO) = False Then D7401.IDNO = Trim$(rs7401!K7401_IDNO)
    If IsdbNull(rs7401!K7401_SpecNo) = False Then D7401.SpecNo = Trim$(rs7401!K7401_SpecNo)
    If IsdbNull(rs7401!K7401_SpecNoSeq) = False Then D7401.SpecNoSeq = Trim$(rs7401!K7401_SpecNoSeq)
    If IsdbNull(rs7401!K7401_DateConfirm) = False Then D7401.DateConfirm = Trim$(rs7401!K7401_DateConfirm)
    If IsdbNull(rs7401!K7401_TimeConfirm) = False Then D7401.TimeConfirm = Trim$(rs7401!K7401_TimeConfirm)
    If IsdbNull(rs7401!K7401_CheckConfirm) = False Then D7401.CheckConfirm = Trim$(rs7401!K7401_CheckConfirm)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7401_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7401_MOVE(rs7401 As DataRow)
Try

    call D7401_CLEAR()   

    If IsdbNull(rs7401!K7401_IDNO) = False Then D7401.IDNO = Trim$(rs7401!K7401_IDNO)
    If IsdbNull(rs7401!K7401_SpecNo) = False Then D7401.SpecNo = Trim$(rs7401!K7401_SpecNo)
    If IsdbNull(rs7401!K7401_SpecNoSeq) = False Then D7401.SpecNoSeq = Trim$(rs7401!K7401_SpecNoSeq)
    If IsdbNull(rs7401!K7401_DateConfirm) = False Then D7401.DateConfirm = Trim$(rs7401!K7401_DateConfirm)
    If IsdbNull(rs7401!K7401_TimeConfirm) = False Then D7401.TimeConfirm = Trim$(rs7401!K7401_TimeConfirm)
    If IsdbNull(rs7401!K7401_CheckConfirm) = False Then D7401.CheckConfirm = Trim$(rs7401!K7401_CheckConfirm)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7401_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7401_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7401 As T7401_AREA, IDNO AS String, SPECNO AS String, SPECNOSEQ AS String) as Boolean

K7401_MOVE = False

Try
    If READ_PFK7401(IDNO, SPECNO, SPECNOSEQ) = True Then
                z7401 = D7401
		K7401_MOVE = True
		else
	z7401 = nothing
     End If

     If  getColumIndex(spr,"IDNO") > -1 then z7401.IDNO = getDataM(spr, getColumIndex(spr,"IDNO"), xRow)
     If  getColumIndex(spr,"SpecNo") > -1 then z7401.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z7401.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"DateConfirm") > -1 then z7401.DateConfirm = getDataM(spr, getColumIndex(spr,"DateConfirm"), xRow)
     If  getColumIndex(spr,"TimeConfirm") > -1 then z7401.TimeConfirm = getDataM(spr, getColumIndex(spr,"TimeConfirm"), xRow)
     If  getColumIndex(spr,"CheckConfirm") > -1 then z7401.CheckConfirm = getDataM(spr, getColumIndex(spr,"CheckConfirm"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7401_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7401_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7401 As T7401_AREA,CheckClear as Boolean,IDNO AS String, SPECNO AS String, SPECNOSEQ AS String) as Boolean

K7401_MOVE = False

Try
    If READ_PFK7401(IDNO, SPECNO, SPECNOSEQ) = True Then
                z7401 = D7401
		K7401_MOVE = True
		else
	If CheckClear  = True then z7401 = nothing
     End If

     If  getColumIndex(spr,"IDNO") > -1 then z7401.IDNO = getDataM(spr, getColumIndex(spr,"IDNO"), xRow)
     If  getColumIndex(spr,"SpecNo") > -1 then z7401.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z7401.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"DateConfirm") > -1 then z7401.DateConfirm = getDataM(spr, getColumIndex(spr,"DateConfirm"), xRow)
     If  getColumIndex(spr,"TimeConfirm") > -1 then z7401.TimeConfirm = getDataM(spr, getColumIndex(spr,"TimeConfirm"), xRow)
     If  getColumIndex(spr,"CheckConfirm") > -1 then z7401.CheckConfirm = getDataM(spr, getColumIndex(spr,"CheckConfirm"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7401_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7401_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7401 As T7401_AREA, Job as String, IDNO AS String, SPECNO AS String, SPECNOSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7401_MOVE = False

Try
    If READ_PFK7401(IDNO, SPECNO, SPECNOSEQ) = True Then
                z7401 = D7401
		K7401_MOVE = True
		else
	z7401 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7401")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "IDNO":z7401.IDNO = Children(i).Code
   Case "SPECNO":z7401.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z7401.SpecNoSeq = Children(i).Code
   Case "DATECONFIRM":z7401.DateConfirm = Children(i).Code
   Case "TIMECONFIRM":z7401.TimeConfirm = Children(i).Code
   Case "CHECKCONFIRM":z7401.CheckConfirm = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "IDNO":z7401.IDNO = Children(i).Data
   Case "SPECNO":z7401.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z7401.SpecNoSeq = Children(i).Data
   Case "DATECONFIRM":z7401.DateConfirm = Children(i).Data
   Case "TIMECONFIRM":z7401.TimeConfirm = Children(i).Data
   Case "CHECKCONFIRM":z7401.CheckConfirm = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7401_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7401_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7401 As T7401_AREA, Job as String, CheckClear as Boolean, IDNO AS String, SPECNO AS String, SPECNOSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7401_MOVE = False

Try
    If READ_PFK7401(IDNO, SPECNO, SPECNOSEQ) = True Then
                z7401 = D7401
		K7401_MOVE = True
		else
	If CheckClear  = True then z7401 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7401")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "IDNO":z7401.IDNO = Children(i).Code
   Case "SPECNO":z7401.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z7401.SpecNoSeq = Children(i).Code
   Case "DATECONFIRM":z7401.DateConfirm = Children(i).Code
   Case "TIMECONFIRM":z7401.TimeConfirm = Children(i).Code
   Case "CHECKCONFIRM":z7401.CheckConfirm = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "IDNO":z7401.IDNO = Children(i).Data
   Case "SPECNO":z7401.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z7401.SpecNoSeq = Children(i).Data
   Case "DATECONFIRM":z7401.DateConfirm = Children(i).Data
   Case "TIMECONFIRM":z7401.TimeConfirm = Children(i).Data
   Case "CHECKCONFIRM":z7401.CheckConfirm = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7401_MOVE",vbCritical)
End Try
End Function 
    
End Module 
