'=========================================================================================================================================================
'   TABLE : (PFK9272)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K9272

Structure T9272_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	BasicSel	 AS String	'			char(3)		*
Public 	BasicCode	 AS String	'			char(3)		*
Public 	SEQ	 AS Double	'			decimal		*
Public 	CustomName	 AS String	'			nvarchar(200)
Public 	FileName	 AS String	'			nvarchar(200)

Public 	FileType	 AS String	'			nvarchar(10)
Public 	AttachDate	 AS String	'			char(8)
Public 	AttachIncharge	 AS String	'			char(8)
Public 	Time	 AS String	'			nvarchar(20)
'=========================================================================================================================================================
End structure

Public D9272 As T9272_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK9272(BASICSEL AS String, BASICCODE AS String, SEQ AS Double) As Boolean
    READ_PFK9272 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9272 "
    SQL = SQL & " WHERE K9272_BasicSel		 = '" & BasicSel & "' " 
    SQL = SQL & "   AND K9272_BasicCode		 = '" & BasicCode & "' " 
    SQL = SQL & "   AND K9272_SEQ		 =  " & SEQ & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D9272_CLEAR: GoTo SKIP_READ_PFK9272
                
    Call K9272_MOVE(rd)
    READ_PFK9272 = True

SKIP_READ_PFK9272:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK9272",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK9272(BASICSEL AS String, BASICCODE AS String, SEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9272 "
    SQL = SQL & " WHERE K9272_BasicSel		 = '" & BasicSel & "' " 
    SQL = SQL & "   AND K9272_BasicCode		 = '" & BasicCode & "' " 
    SQL = SQL & "   AND K9272_SEQ		 =  " & SEQ & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK9272",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK9272(z9272 As T9272_AREA) As Boolean
    WRITE_PFK9272 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z9272)
 
    SQL = " INSERT INTO PFK9272 "
    SQL = SQL & " ( "
    SQL = SQL & " K9272_BasicSel," 
    SQL = SQL & " K9272_BasicCode," 
    SQL = SQL & " K9272_SEQ," 
    SQL = SQL & " K9272_CustomName," 
    SQL = SQL & " K9272_FileName," 
            SQL = SQL & " K9272_FileType,"
    SQL = SQL & " K9272_AttachDate," 
    SQL = SQL & " K9272_AttachIncharge," 
    SQL = SQL & " K9272_Time " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z9272.BasicSel) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9272.BasicCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z9272.SEQ) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z9272.CustomName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9272.FileName) & "', "  
            SQL = SQL & "  N'" & FormatSQL(z9272.FileType) & "', "
    SQL = SQL & "  N'" & FormatSQL(z9272.AttachDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9272.AttachIncharge) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9272.Time) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK9272 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK9272",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK9272(z9272 As T9272_AREA) As Boolean
    REWRITE_PFK9272 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z9272)
   
    SQL = " UPDATE PFK9272 SET "
    SQL = SQL & "    K9272_CustomName      = N'" & FormatSQL(z9272.CustomName) & "', " 
    SQL = SQL & "    K9272_FileName      = N'" & FormatSQL(z9272.FileName) & "', " 
            SQL = SQL & "    K9272_FileType      = N'" & FormatSQL(z9272.FileType) & "', "
    SQL = SQL & "    K9272_AttachDate      = N'" & FormatSQL(z9272.AttachDate) & "', " 
    SQL = SQL & "    K9272_AttachIncharge      = N'" & FormatSQL(z9272.AttachIncharge) & "', " 
    SQL = SQL & "    K9272_Time      = N'" & FormatSQL(z9272.Time) & "'  " 
    SQL = SQL & " WHERE K9272_BasicSel		 = '" & z9272.BasicSel & "' " 
    SQL = SQL & "   AND K9272_BasicCode		 = '" & z9272.BasicCode & "' " 
    SQL = SQL & "   AND K9272_SEQ		 =  " & z9272.SEQ & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK9272 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK9272",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK9272(z9272 As T9272_AREA) As Boolean
    DELETE_PFK9272 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK9272 "
    SQL = SQL & " WHERE K9272_BasicSel		 = '" & z9272.BasicSel & "' " 
    SQL = SQL & "   AND K9272_BasicCode		 = '" & z9272.BasicCode & "' " 
    SQL = SQL & "   AND K9272_SEQ		 =  " & z9272.SEQ & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK9272 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK9272",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D9272_CLEAR()
Try
    
   D9272.BasicSel = ""
   D9272.BasicCode = ""
    D9272.SEQ = 0 
   D9272.CustomName = ""
   D9272.FileName = ""
            D9272.FileType = ""
   D9272.AttachDate = ""
   D9272.AttachIncharge = ""
   D9272.Time = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D9272_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x9272 As T9272_AREA)
Try
    
    x9272.BasicSel = trim$(  x9272.BasicSel)
    x9272.BasicCode = trim$(  x9272.BasicCode)
    x9272.SEQ = trim$(  x9272.SEQ)
    x9272.CustomName = trim$(  x9272.CustomName)
    x9272.FileName = trim$(  x9272.FileName)

    x9272.FileType = trim$(  x9272.FileType)
    x9272.AttachDate = trim$(  x9272.AttachDate)
    x9272.AttachIncharge = trim$(  x9272.AttachIncharge)
    x9272.Time = trim$(  x9272.Time)
     
    If trim$( x9272.BasicSel ) = "" Then x9272.BasicSel = Space(1) 
    If trim$( x9272.BasicCode ) = "" Then x9272.BasicCode = Space(1) 
    If trim$( x9272.SEQ ) = "" Then x9272.SEQ = 0 
    If trim$( x9272.CustomName ) = "" Then x9272.CustomName = Space(1) 
    If trim$( x9272.FileName ) = "" Then x9272.FileName = Space(1) 
            If Trim$(x9272.FileType) = "" Then x9272.FileType = Space(1)
    If trim$( x9272.AttachDate ) = "" Then x9272.AttachDate = Space(1) 
    If trim$( x9272.AttachIncharge ) = "" Then x9272.AttachIncharge = Space(1) 
    If trim$( x9272.Time ) = "" Then x9272.Time = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K9272_MOVE(rs9272 As SqlClient.SqlDataReader)
Try

    call D9272_CLEAR()   

    If IsdbNull(rs9272!K9272_BasicSel) = False Then D9272.BasicSel = Trim$(rs9272!K9272_BasicSel)
    If IsdbNull(rs9272!K9272_BasicCode) = False Then D9272.BasicCode = Trim$(rs9272!K9272_BasicCode)
    If IsdbNull(rs9272!K9272_SEQ) = False Then D9272.SEQ = Trim$(rs9272!K9272_SEQ)
    If IsdbNull(rs9272!K9272_CustomName) = False Then D9272.CustomName = Trim$(rs9272!K9272_CustomName)
    If IsdbNull(rs9272!K9272_FileName) = False Then D9272.FileName = Trim$(rs9272!K9272_FileName)
            If IsDBNull(rs9272!K9272_FileType) = False Then D9272.FileType = Trim$(rs9272!K9272_FileType)
    If IsdbNull(rs9272!K9272_AttachDate) = False Then D9272.AttachDate = Trim$(rs9272!K9272_AttachDate)
    If IsdbNull(rs9272!K9272_AttachIncharge) = False Then D9272.AttachIncharge = Trim$(rs9272!K9272_AttachIncharge)
    If IsdbNull(rs9272!K9272_Time) = False Then D9272.Time = Trim$(rs9272!K9272_Time)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9272_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K9272_MOVE(rs9272 As DataRow)
Try

    call D9272_CLEAR()   

    If IsdbNull(rs9272!K9272_BasicSel) = False Then D9272.BasicSel = Trim$(rs9272!K9272_BasicSel)
    If IsdbNull(rs9272!K9272_BasicCode) = False Then D9272.BasicCode = Trim$(rs9272!K9272_BasicCode)
    If IsdbNull(rs9272!K9272_SEQ) = False Then D9272.SEQ = Trim$(rs9272!K9272_SEQ)
    If IsdbNull(rs9272!K9272_CustomName) = False Then D9272.CustomName = Trim$(rs9272!K9272_CustomName)
    If IsdbNull(rs9272!K9272_FileName) = False Then D9272.FileName = Trim$(rs9272!K9272_FileName)
            If IsDBNull(rs9272!K9272_FileType) = False Then D9272.FileType = Trim$(rs9272!K9272_FileType)
    If IsdbNull(rs9272!K9272_AttachDate) = False Then D9272.AttachDate = Trim$(rs9272!K9272_AttachDate)
    If IsdbNull(rs9272!K9272_AttachIncharge) = False Then D9272.AttachIncharge = Trim$(rs9272!K9272_AttachIncharge)
    If IsdbNull(rs9272!K9272_Time) = False Then D9272.Time = Trim$(rs9272!K9272_Time)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9272_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K9272_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9272 As T9272_AREA, BASICSEL AS String, BASICCODE AS String, SEQ AS Double) as Boolean

K9272_MOVE = False

Try
    If READ_PFK9272(BASICSEL, BASICCODE, SEQ) = True Then
                z9272 = D9272
		K9272_MOVE = True
		else
	z9272 = nothing
     End If

     If  getColumIndex(spr,"BasicSel") > -1 then z9272.BasicSel = getDataM(spr, getColumIndex(spr,"BasicSel"), xRow)
     If  getColumIndex(spr,"BasicCode") > -1 then z9272.BasicCode = getDataM(spr, getColumIndex(spr,"BasicCode"), xRow)
     If  getColumIndex(spr,"SEQ") > -1 then z9272.SEQ = getDataM(spr, getColumIndex(spr,"SEQ"), xRow)
     If  getColumIndex(spr,"CustomName") > -1 then z9272.CustomName = getDataM(spr, getColumIndex(spr,"CustomName"), xRow)
     If  getColumIndex(spr,"FileName") > -1 then z9272.FileName = getDataM(spr, getColumIndex(spr,"FileName"), xRow)
            If getColumIndex(spr, "FileType") > -1 Then z9272.FileType = getDataM(spr, getColumIndex(spr, "FileType"), xRow)
     If  getColumIndex(spr,"AttachDate") > -1 then z9272.AttachDate = getDataM(spr, getColumIndex(spr,"AttachDate"), xRow)
     If  getColumIndex(spr,"AttachIncharge") > -1 then z9272.AttachIncharge = getDataM(spr, getColumIndex(spr,"AttachIncharge"), xRow)
     If  getColumIndex(spr,"Time") > -1 then z9272.Time = getDataM(spr, getColumIndex(spr,"Time"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K9272_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K9272_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9272 As T9272_AREA,CheckClear as Boolean,BASICSEL AS String, BASICCODE AS String, SEQ AS Double) as Boolean

K9272_MOVE = False

Try
    If READ_PFK9272(BASICSEL, BASICCODE, SEQ) = True Then
                z9272 = D9272
		K9272_MOVE = True
		else
	If CheckClear  = True then z9272 = nothing
     End If

     If  getColumIndex(spr,"BasicSel") > -1 then z9272.BasicSel = getDataM(spr, getColumIndex(spr,"BasicSel"), xRow)
     If  getColumIndex(spr,"BasicCode") > -1 then z9272.BasicCode = getDataM(spr, getColumIndex(spr,"BasicCode"), xRow)
     If  getColumIndex(spr,"SEQ") > -1 then z9272.SEQ = getDataM(spr, getColumIndex(spr,"SEQ"), xRow)
     If  getColumIndex(spr,"CustomName") > -1 then z9272.CustomName = getDataM(spr, getColumIndex(spr,"CustomName"), xRow)
     If  getColumIndex(spr,"FileName") > -1 then z9272.FileName = getDataM(spr, getColumIndex(spr,"FileName"), xRow)
            If getColumIndex(spr, "FileType") > -1 Then z9272.FileType = getDataM(spr, getColumIndex(spr, "FileType"), xRow)
     If  getColumIndex(spr,"AttachDate") > -1 then z9272.AttachDate = getDataM(spr, getColumIndex(spr,"AttachDate"), xRow)
     If  getColumIndex(spr,"AttachIncharge") > -1 then z9272.AttachIncharge = getDataM(spr, getColumIndex(spr,"AttachIncharge"), xRow)
     If  getColumIndex(spr,"Time") > -1 then z9272.Time = getDataM(spr, getColumIndex(spr,"Time"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K9272_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K9272_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9272 As T9272_AREA, Job as String, BASICSEL AS String, BASICCODE AS String, SEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9272_MOVE = False

Try
    If READ_PFK9272(BASICSEL, BASICCODE, SEQ) = True Then
                z9272 = D9272
		K9272_MOVE = True
		else
	z9272 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9272")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "BASICSEL":z9272.BasicSel = Children(i).Code
   Case "BASICCODE":z9272.BasicCode = Children(i).Code
   Case "SEQ":z9272.SEQ = Children(i).Code
   Case "CUSTOMNAME":z9272.CustomName = Children(i).Code
   Case "FILENAME":z9272.FileName = Children(i).Code
                                Case "FILETYPE" : z9272.FileType = Children(i).Code
   Case "ATTACHDATE":z9272.AttachDate = Children(i).Code
   Case "ATTACHINCHARGE":z9272.AttachIncharge = Children(i).Code
   Case "TIME":z9272.Time = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "BASICSEL":z9272.BasicSel = Children(i).Data
   Case "BASICCODE":z9272.BasicCode = Children(i).Data
   Case "SEQ":z9272.SEQ = Children(i).Data
   Case "CUSTOMNAME":z9272.CustomName = Children(i).Data
   Case "FILENAME":z9272.FileName = Children(i).Data
                                Case "FILETYPE" : z9272.FileType = Children(i).Data
   Case "ATTACHDATE":z9272.AttachDate = Children(i).Data
   Case "ATTACHINCHARGE":z9272.AttachIncharge = Children(i).Data
   Case "TIME":z9272.Time = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K9272_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K9272_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9272 As T9272_AREA, Job as String, CheckClear as Boolean, BASICSEL AS String, BASICCODE AS String, SEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9272_MOVE = False

Try
    If READ_PFK9272(BASICSEL, BASICCODE, SEQ) = True Then
                z9272 = D9272
		K9272_MOVE = True
		else
	If CheckClear  = True then z9272 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9272")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "BASICSEL":z9272.BasicSel = Children(i).Code
   Case "BASICCODE":z9272.BasicCode = Children(i).Code
   Case "SEQ":z9272.SEQ = Children(i).Code
   Case "CUSTOMNAME":z9272.CustomName = Children(i).Code
   Case "FILENAME":z9272.FileName = Children(i).Code
                                Case "FILETYPE" : z9272.FileType = Children(i).Code
   Case "ATTACHDATE":z9272.AttachDate = Children(i).Code
   Case "ATTACHINCHARGE":z9272.AttachIncharge = Children(i).Code
   Case "TIME":z9272.Time = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "BASICSEL":z9272.BasicSel = Children(i).Data
   Case "BASICCODE":z9272.BasicCode = Children(i).Data
   Case "SEQ":z9272.SEQ = Children(i).Data
   Case "CUSTOMNAME":z9272.CustomName = Children(i).Data
   Case "FILENAME":z9272.FileName = Children(i).Data
                                Case "FILETYPE" : z9272.FileType = Children(i).Data
   Case "ATTACHDATE":z9272.AttachDate = Children(i).Data
   Case "ATTACHINCHARGE":z9272.AttachIncharge = Children(i).Data
   Case "TIME":z9272.Time = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K9272_MOVE",vbCritical)
End Try
End Function 
    
End Module 
