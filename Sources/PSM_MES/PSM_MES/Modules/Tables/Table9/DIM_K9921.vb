'=========================================================================================================================================================
'   TABLE : (PFK9921)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K9921

Structure T9921_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	ProgramNo	 AS String	'			nvarchar(100)		*
Public 	SplitName	 AS String	'			nvarchar(100)		*
Public 	Distance	 AS Double	'			decimal
'=========================================================================================================================================================
End structure

Public D9921 As T9921_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK9921(PROGRAMNO AS String, SPLITNAME AS String) As Boolean
    READ_PFK9921 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9921 "
    SQL = SQL & " WHERE K9921_ProgramNo		 = '" & ProgramNo & "' " 
    SQL = SQL & "   AND K9921_SplitName		 = '" & SplitName & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D9921_CLEAR: GoTo SKIP_READ_PFK9921
                
    Call K9921_MOVE(rd)
    READ_PFK9921 = True

SKIP_READ_PFK9921:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK9921",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK9921(PROGRAMNO AS String, SPLITNAME AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9921 "
    SQL = SQL & " WHERE K9921_ProgramNo		 = '" & ProgramNo & "' " 
    SQL = SQL & "   AND K9921_SplitName		 = '" & SplitName & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK9921",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK9921(z9921 As T9921_AREA) As Boolean
    WRITE_PFK9921 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z9921)
 
    SQL = " INSERT INTO PFK9921 "
    SQL = SQL & " ( "
    SQL = SQL & " K9921_ProgramNo," 
    SQL = SQL & " K9921_SplitName," 
    SQL = SQL & " K9921_Distance " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z9921.ProgramNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9921.SplitName) & "', "  
    SQL = SQL & "   " & FormatSQL(z9921.Distance) & "  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK9921 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK9921",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK9921(z9921 As T9921_AREA) As Boolean
    REWRITE_PFK9921 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z9921)
   
    SQL = " UPDATE PFK9921 SET "
    SQL = SQL & "    K9921_Distance      =  " & FormatSQL(z9921.Distance) & "  " 
    SQL = SQL & " WHERE K9921_ProgramNo		 = '" & z9921.ProgramNo & "' " 
    SQL = SQL & "   AND K9921_SplitName		 = '" & z9921.SplitName & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK9921 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK9921",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK9921(z9921 As T9921_AREA) As Boolean
    DELETE_PFK9921 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK9921 "
    SQL = SQL & " WHERE K9921_ProgramNo		 = '" & z9921.ProgramNo & "' " 
    SQL = SQL & "   AND K9921_SplitName		 = '" & z9921.SplitName & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK9921 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK9921",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D9921_CLEAR()
Try
    
   D9921.ProgramNo = ""
   D9921.SplitName = ""
    D9921.Distance = 0 

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D9921_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x9921 As T9921_AREA)
Try
    
    x9921.ProgramNo = trim$(  x9921.ProgramNo)
    x9921.SplitName = trim$(  x9921.SplitName)
    x9921.Distance = trim$(  x9921.Distance)
     
    If trim$( x9921.ProgramNo ) = "" Then x9921.ProgramNo = Space(1) 
    If trim$( x9921.SplitName ) = "" Then x9921.SplitName = Space(1) 
    If trim$( x9921.Distance ) = "" Then x9921.Distance = 0 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K9921_MOVE(rs9921 As SqlClient.SqlDataReader)
Try

    call D9921_CLEAR()   

    If IsdbNull(rs9921!K9921_ProgramNo) = False Then D9921.ProgramNo = Trim$(rs9921!K9921_ProgramNo)
    If IsdbNull(rs9921!K9921_SplitName) = False Then D9921.SplitName = Trim$(rs9921!K9921_SplitName)
    If IsdbNull(rs9921!K9921_Distance) = False Then D9921.Distance = Trim$(rs9921!K9921_Distance)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9921_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K9921_MOVE(rs9921 As DataRow)
Try

    call D9921_CLEAR()   

    If IsdbNull(rs9921!K9921_ProgramNo) = False Then D9921.ProgramNo = Trim$(rs9921!K9921_ProgramNo)
    If IsdbNull(rs9921!K9921_SplitName) = False Then D9921.SplitName = Trim$(rs9921!K9921_SplitName)
    If IsdbNull(rs9921!K9921_Distance) = False Then D9921.Distance = Trim$(rs9921!K9921_Distance)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9921_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K9921_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9921 As T9921_AREA, PROGRAMNO AS String, SPLITNAME AS String) as Boolean

K9921_MOVE = False

Try
    If READ_PFK9921(PROGRAMNO, SPLITNAME) = True Then
                z9921 = D9921
		K9921_MOVE = True
		else
	z9921 = nothing
     End If

     If  getColumIndex(spr,"ProgramNo") > -1 then z9921.ProgramNo = getDataM(spr, getColumIndex(spr,"ProgramNo"), xRow)
     If  getColumIndex(spr,"SplitName") > -1 then z9921.SplitName = getDataM(spr, getColumIndex(spr,"SplitName"), xRow)
     If  getColumIndex(spr,"Distance") > -1 then z9921.Distance = getDataM(spr, getColumIndex(spr,"Distance"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K9921_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K9921_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9921 As T9921_AREA,CheckClear as Boolean,PROGRAMNO AS String, SPLITNAME AS String) as Boolean

K9921_MOVE = False

Try
    If READ_PFK9921(PROGRAMNO, SPLITNAME) = True Then
                z9921 = D9921
		K9921_MOVE = True
		else
	If CheckClear  = True then z9921 = nothing
     End If

     If  getColumIndex(spr,"ProgramNo") > -1 then z9921.ProgramNo = getDataM(spr, getColumIndex(spr,"ProgramNo"), xRow)
     If  getColumIndex(spr,"SplitName") > -1 then z9921.SplitName = getDataM(spr, getColumIndex(spr,"SplitName"), xRow)
     If  getColumIndex(spr,"Distance") > -1 then z9921.Distance = getDataM(spr, getColumIndex(spr,"Distance"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K9921_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K9921_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9921 As T9921_AREA, Job as String, PROGRAMNO AS String, SPLITNAME AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9921_MOVE = False

Try
    If READ_PFK9921(PROGRAMNO, SPLITNAME) = True Then
                z9921 = D9921
		K9921_MOVE = True
		else
	z9921 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9921")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PROGRAMNO":z9921.ProgramNo = Children(i).Code
   Case "SPLITNAME":z9921.SplitName = Children(i).Code
   Case "DISTANCE":z9921.Distance = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PROGRAMNO":z9921.ProgramNo = Children(i).Data
   Case "SPLITNAME":z9921.SplitName = Children(i).Data
   Case "DISTANCE":z9921.Distance = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K9921_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K9921_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9921 As T9921_AREA, Job as String, CheckClear as Boolean, PROGRAMNO AS String, SPLITNAME AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9921_MOVE = False

Try
    If READ_PFK9921(PROGRAMNO, SPLITNAME) = True Then
                z9921 = D9921
		K9921_MOVE = True
		else
	If CheckClear  = True then z9921 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9921")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PROGRAMNO":z9921.ProgramNo = Children(i).Code
   Case "SPLITNAME":z9921.SplitName = Children(i).Code
   Case "DISTANCE":z9921.Distance = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PROGRAMNO":z9921.ProgramNo = Children(i).Data
   Case "SPLITNAME":z9921.SplitName = Children(i).Data
   Case "DISTANCE":z9921.Distance = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K9921_MOVE",vbCritical)
End Try
End Function 
    
End Module 
