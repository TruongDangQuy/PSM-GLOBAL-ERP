'=========================================================================================================================================================
'   TABLE : (PFK9915)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K9915

Structure T9915_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	ProdjectName	 AS String	'			nvarchar(10)		*
Public 	ProgramNo	 AS String	'			varchar(100)		*
Public 	SheetName	 AS String	'			varchar(10)		*
Public 	ColumnSpanID	 AS Double	'			decimal		*
Public 	ColumnSpanSeq	 AS Double	'			decimal		*
Public 	Title	 AS String	'			nvarchar(100)
Public 	ForeignName1	 AS String	'			nvarchar(100)
Public 	ForeignName2	 AS String	'			nvarchar(100)
Public 	BeginColumn	 AS Double	'			decimal
Public 	EndColumn	 AS Double	'			decimal
Public 	Remark	 AS String	'			nvarchar(100)
'=========================================================================================================================================================
End structure

Public D9915 As T9915_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK9915(PRODJECTNAME AS String, PROGRAMNO AS String, SHEETNAME AS String, COLUMNSPANID AS Double, COLUMNSPANSEQ AS Double) As Boolean
    READ_PFK9915 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9915 "
    SQL = SQL & " WHERE K9915_ProdjectName		 = '" & ProdjectName & "' " 
    SQL = SQL & "   AND K9915_ProgramNo		 = '" & ProgramNo & "' " 
    SQL = SQL & "   AND K9915_SheetName		 = '" & SheetName & "' " 
    SQL = SQL & "   AND K9915_ColumnSpanID		 =  " & ColumnSpanID & "  " 
    SQL = SQL & "   AND K9915_ColumnSpanSeq		 =  " & ColumnSpanSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D9915_CLEAR: GoTo SKIP_READ_PFK9915
                
    Call K9915_MOVE(rd)
    READ_PFK9915 = True

SKIP_READ_PFK9915:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK9915",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK9915(PRODJECTNAME AS String, PROGRAMNO AS String, SHEETNAME AS String, COLUMNSPANID AS Double, COLUMNSPANSEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9915 "
    SQL = SQL & " WHERE K9915_ProdjectName		 = '" & ProdjectName & "' " 
    SQL = SQL & "   AND K9915_ProgramNo		 = '" & ProgramNo & "' " 
    SQL = SQL & "   AND K9915_SheetName		 = '" & SheetName & "' " 
    SQL = SQL & "   AND K9915_ColumnSpanID		 =  " & ColumnSpanID & "  " 
    SQL = SQL & "   AND K9915_ColumnSpanSeq		 =  " & ColumnSpanSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK9915",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK9915(z9915 As T9915_AREA) As Boolean
    WRITE_PFK9915 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z9915)
 
    SQL = " INSERT INTO PFK9915 "
    SQL = SQL & " ( "
    SQL = SQL & " K9915_ProdjectName," 
    SQL = SQL & " K9915_ProgramNo," 
    SQL = SQL & " K9915_SheetName," 
    SQL = SQL & " K9915_ColumnSpanID," 
    SQL = SQL & " K9915_ColumnSpanSeq," 
    SQL = SQL & " K9915_Title," 
    SQL = SQL & " K9915_ForeignName1," 
    SQL = SQL & " K9915_ForeignName2," 
    SQL = SQL & " K9915_BeginColumn," 
    SQL = SQL & " K9915_EndColumn," 
    SQL = SQL & " K9915_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z9915.ProdjectName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9915.ProgramNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9915.SheetName) & "', "  
    SQL = SQL & "   " & FormatSQL(z9915.ColumnSpanID) & ", "  
    SQL = SQL & "   " & FormatSQL(z9915.ColumnSpanSeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z9915.Title) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9915.ForeignName1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9915.ForeignName2) & "', "  
    SQL = SQL & "   " & FormatSQL(z9915.BeginColumn) & ", "  
    SQL = SQL & "   " & FormatSQL(z9915.EndColumn) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z9915.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK9915 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK9915",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK9915(z9915 As T9915_AREA) As Boolean
    REWRITE_PFK9915 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z9915)
   
    SQL = " UPDATE PFK9915 SET "
    SQL = SQL & "    K9915_Title      = N'" & FormatSQL(z9915.Title) & "', " 
    SQL = SQL & "    K9915_ForeignName1      = N'" & FormatSQL(z9915.ForeignName1) & "', " 
    SQL = SQL & "    K9915_ForeignName2      = N'" & FormatSQL(z9915.ForeignName2) & "', " 
    SQL = SQL & "    K9915_BeginColumn      =  " & FormatSQL(z9915.BeginColumn) & ", " 
    SQL = SQL & "    K9915_EndColumn      =  " & FormatSQL(z9915.EndColumn) & ", " 
    SQL = SQL & "    K9915_Remark      = N'" & FormatSQL(z9915.Remark) & "'  " 
    SQL = SQL & " WHERE K9915_ProdjectName		 = '" & z9915.ProdjectName & "' " 
    SQL = SQL & "   AND K9915_ProgramNo		 = '" & z9915.ProgramNo & "' " 
    SQL = SQL & "   AND K9915_SheetName		 = '" & z9915.SheetName & "' " 
    SQL = SQL & "   AND K9915_ColumnSpanID		 =  " & z9915.ColumnSpanID & "  " 
    SQL = SQL & "   AND K9915_ColumnSpanSeq		 =  " & z9915.ColumnSpanSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK9915 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK9915",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK9915(z9915 As T9915_AREA) As Boolean
    DELETE_PFK9915 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK9915 "
    SQL = SQL & " WHERE K9915_ProdjectName		 = '" & z9915.ProdjectName & "' " 
    SQL = SQL & "   AND K9915_ProgramNo		 = '" & z9915.ProgramNo & "' " 
    SQL = SQL & "   AND K9915_SheetName		 = '" & z9915.SheetName & "' " 
    SQL = SQL & "   AND K9915_ColumnSpanID		 =  " & z9915.ColumnSpanID & "  " 
    SQL = SQL & "   AND K9915_ColumnSpanSeq		 =  " & z9915.ColumnSpanSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK9915 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK9915",vbCritical)
End Try
End Function


    Public Function DELETE_PFK9915(z9915 As T9915_AREA, NoSeq As Boolean) As Boolean
        DELETE_PFK9915 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK9915 "
            SQL = SQL & " WHERE K9915_ProdjectName		 = '" & z9915.ProdjectName & "' "
            SQL = SQL & "   AND K9915_ProgramNo		 = '" & z9915.ProgramNo & "' "
            SQL = SQL & "   AND K9915_SheetName		 = '" & z9915.SheetName & "' "
            SQL = SQL & "   AND K9915_ColumnSpanID		 =  " & z9915.ColumnSpanID & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK9915 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK9915", vbCritical)
        End Try
    End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D9915_CLEAR()
Try
    
   D9915.ProdjectName = ""
   D9915.ProgramNo = ""
   D9915.SheetName = ""
    D9915.ColumnSpanID = 0 
    D9915.ColumnSpanSeq = 0 
   D9915.Title = ""
   D9915.ForeignName1 = ""
   D9915.ForeignName2 = ""
    D9915.BeginColumn = 0 
    D9915.EndColumn = 0 
   D9915.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D9915_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x9915 As T9915_AREA)
Try
    
    x9915.ProdjectName = trim$(  x9915.ProdjectName)
    x9915.ProgramNo = trim$(  x9915.ProgramNo)
    x9915.SheetName = trim$(  x9915.SheetName)
    x9915.ColumnSpanID = trim$(  x9915.ColumnSpanID)
    x9915.ColumnSpanSeq = trim$(  x9915.ColumnSpanSeq)
    x9915.Title = trim$(  x9915.Title)
    x9915.ForeignName1 = trim$(  x9915.ForeignName1)
    x9915.ForeignName2 = trim$(  x9915.ForeignName2)
    x9915.BeginColumn = trim$(  x9915.BeginColumn)
    x9915.EndColumn = trim$(  x9915.EndColumn)
    x9915.Remark = trim$(  x9915.Remark)
     
    If trim$( x9915.ProdjectName ) = "" Then x9915.ProdjectName = Space(1) 
    If trim$( x9915.ProgramNo ) = "" Then x9915.ProgramNo = Space(1) 
    If trim$( x9915.SheetName ) = "" Then x9915.SheetName = Space(1) 
    If trim$( x9915.ColumnSpanID ) = "" Then x9915.ColumnSpanID = 0 
    If trim$( x9915.ColumnSpanSeq ) = "" Then x9915.ColumnSpanSeq = 0 
    If trim$( x9915.Title ) = "" Then x9915.Title = Space(1) 
    If trim$( x9915.ForeignName1 ) = "" Then x9915.ForeignName1 = Space(1) 
    If trim$( x9915.ForeignName2 ) = "" Then x9915.ForeignName2 = Space(1) 
    If trim$( x9915.BeginColumn ) = "" Then x9915.BeginColumn = 0 
    If trim$( x9915.EndColumn ) = "" Then x9915.EndColumn = 0 
    If trim$( x9915.Remark ) = "" Then x9915.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K9915_MOVE(rs9915 As SqlClient.SqlDataReader)
Try

    call D9915_CLEAR()   

    If IsdbNull(rs9915!K9915_ProdjectName) = False Then D9915.ProdjectName = Trim$(rs9915!K9915_ProdjectName)
    If IsdbNull(rs9915!K9915_ProgramNo) = False Then D9915.ProgramNo = Trim$(rs9915!K9915_ProgramNo)
    If IsdbNull(rs9915!K9915_SheetName) = False Then D9915.SheetName = Trim$(rs9915!K9915_SheetName)
    If IsdbNull(rs9915!K9915_ColumnSpanID) = False Then D9915.ColumnSpanID = Trim$(rs9915!K9915_ColumnSpanID)
    If IsdbNull(rs9915!K9915_ColumnSpanSeq) = False Then D9915.ColumnSpanSeq = Trim$(rs9915!K9915_ColumnSpanSeq)
    If IsdbNull(rs9915!K9915_Title) = False Then D9915.Title = Trim$(rs9915!K9915_Title)
    If IsdbNull(rs9915!K9915_ForeignName1) = False Then D9915.ForeignName1 = Trim$(rs9915!K9915_ForeignName1)
    If IsdbNull(rs9915!K9915_ForeignName2) = False Then D9915.ForeignName2 = Trim$(rs9915!K9915_ForeignName2)
    If IsdbNull(rs9915!K9915_BeginColumn) = False Then D9915.BeginColumn = Trim$(rs9915!K9915_BeginColumn)
    If IsdbNull(rs9915!K9915_EndColumn) = False Then D9915.EndColumn = Trim$(rs9915!K9915_EndColumn)
    If IsdbNull(rs9915!K9915_Remark) = False Then D9915.Remark = Trim$(rs9915!K9915_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9915_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K9915_MOVE(rs9915 As DataRow)
Try

    call D9915_CLEAR()   

    If IsdbNull(rs9915!K9915_ProdjectName) = False Then D9915.ProdjectName = Trim$(rs9915!K9915_ProdjectName)
    If IsdbNull(rs9915!K9915_ProgramNo) = False Then D9915.ProgramNo = Trim$(rs9915!K9915_ProgramNo)
    If IsdbNull(rs9915!K9915_SheetName) = False Then D9915.SheetName = Trim$(rs9915!K9915_SheetName)
    If IsdbNull(rs9915!K9915_ColumnSpanID) = False Then D9915.ColumnSpanID = Trim$(rs9915!K9915_ColumnSpanID)
    If IsdbNull(rs9915!K9915_ColumnSpanSeq) = False Then D9915.ColumnSpanSeq = Trim$(rs9915!K9915_ColumnSpanSeq)
    If IsdbNull(rs9915!K9915_Title) = False Then D9915.Title = Trim$(rs9915!K9915_Title)
    If IsdbNull(rs9915!K9915_ForeignName1) = False Then D9915.ForeignName1 = Trim$(rs9915!K9915_ForeignName1)
    If IsdbNull(rs9915!K9915_ForeignName2) = False Then D9915.ForeignName2 = Trim$(rs9915!K9915_ForeignName2)
    If IsdbNull(rs9915!K9915_BeginColumn) = False Then D9915.BeginColumn = Trim$(rs9915!K9915_BeginColumn)
    If IsdbNull(rs9915!K9915_EndColumn) = False Then D9915.EndColumn = Trim$(rs9915!K9915_EndColumn)
    If IsdbNull(rs9915!K9915_Remark) = False Then D9915.Remark = Trim$(rs9915!K9915_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9915_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K9915_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9915 As T9915_AREA, PRODJECTNAME AS String, PROGRAMNO AS String, SHEETNAME AS String, COLUMNSPANID AS Double, COLUMNSPANSEQ AS Double) as Boolean

K9915_MOVE = False

Try
    If READ_PFK9915(PRODJECTNAME, PROGRAMNO, SHEETNAME, COLUMNSPANID, COLUMNSPANSEQ) = True Then
                z9915 = D9915
		K9915_MOVE = True
		else
	z9915 = nothing
     End If

     If  getColumIndex(spr,"ProdjectName") > -1 then z9915.ProdjectName = getDataM(spr, getColumIndex(spr,"ProdjectName"), xRow)
     If  getColumIndex(spr,"ProgramNo") > -1 then z9915.ProgramNo = getDataM(spr, getColumIndex(spr,"ProgramNo"), xRow)
     If  getColumIndex(spr,"SheetName") > -1 then z9915.SheetName = getDataM(spr, getColumIndex(spr,"SheetName"), xRow)
     If  getColumIndex(spr,"ColumnSpanID") > -1 then z9915.ColumnSpanID = getDataM(spr, getColumIndex(spr,"ColumnSpanID"), xRow)
     If  getColumIndex(spr,"ColumnSpanSeq") > -1 then z9915.ColumnSpanSeq = getDataM(spr, getColumIndex(spr,"ColumnSpanSeq"), xRow)
     If  getColumIndex(spr,"Title") > -1 then z9915.Title = getDataM(spr, getColumIndex(spr,"Title"), xRow)
     If  getColumIndex(spr,"ForeignName1") > -1 then z9915.ForeignName1 = getDataM(spr, getColumIndex(spr,"ForeignName1"), xRow)
     If  getColumIndex(spr,"ForeignName2") > -1 then z9915.ForeignName2 = getDataM(spr, getColumIndex(spr,"ForeignName2"), xRow)
     If  getColumIndex(spr,"BeginColumn") > -1 then z9915.BeginColumn = getDataM(spr, getColumIndex(spr,"BeginColumn"), xRow)
     If  getColumIndex(spr,"EndColumn") > -1 then z9915.EndColumn = getDataM(spr, getColumIndex(spr,"EndColumn"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z9915.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K9915_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K9915_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9915 As T9915_AREA,CheckClear as Boolean,PRODJECTNAME AS String, PROGRAMNO AS String, SHEETNAME AS String, COLUMNSPANID AS Double, COLUMNSPANSEQ AS Double) as Boolean

K9915_MOVE = False

Try
    If READ_PFK9915(PRODJECTNAME, PROGRAMNO, SHEETNAME, COLUMNSPANID, COLUMNSPANSEQ) = True Then
                z9915 = D9915
		K9915_MOVE = True
		else
	If CheckClear  = True then z9915 = nothing
     End If

     If  getColumIndex(spr,"ProdjectName") > -1 then z9915.ProdjectName = getDataM(spr, getColumIndex(spr,"ProdjectName"), xRow)
     If  getColumIndex(spr,"ProgramNo") > -1 then z9915.ProgramNo = getDataM(spr, getColumIndex(spr,"ProgramNo"), xRow)
     If  getColumIndex(spr,"SheetName") > -1 then z9915.SheetName = getDataM(spr, getColumIndex(spr,"SheetName"), xRow)
     If  getColumIndex(spr,"ColumnSpanID") > -1 then z9915.ColumnSpanID = getDataM(spr, getColumIndex(spr,"ColumnSpanID"), xRow)
     If  getColumIndex(spr,"ColumnSpanSeq") > -1 then z9915.ColumnSpanSeq = getDataM(spr, getColumIndex(spr,"ColumnSpanSeq"), xRow)
     If  getColumIndex(spr,"Title") > -1 then z9915.Title = getDataM(spr, getColumIndex(spr,"Title"), xRow)
     If  getColumIndex(spr,"ForeignName1") > -1 then z9915.ForeignName1 = getDataM(spr, getColumIndex(spr,"ForeignName1"), xRow)
     If  getColumIndex(spr,"ForeignName2") > -1 then z9915.ForeignName2 = getDataM(spr, getColumIndex(spr,"ForeignName2"), xRow)
     If  getColumIndex(spr,"BeginColumn") > -1 then z9915.BeginColumn = getDataM(spr, getColumIndex(spr,"BeginColumn"), xRow)
     If  getColumIndex(spr,"EndColumn") > -1 then z9915.EndColumn = getDataM(spr, getColumIndex(spr,"EndColumn"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z9915.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K9915_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K9915_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9915 As T9915_AREA, Job as String, PRODJECTNAME AS String, PROGRAMNO AS String, SHEETNAME AS String, COLUMNSPANID AS Double, COLUMNSPANSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9915_MOVE = False

Try
    If READ_PFK9915(PRODJECTNAME, PROGRAMNO, SHEETNAME, COLUMNSPANID, COLUMNSPANSEQ) = True Then
                z9915 = D9915
		K9915_MOVE = True
		else
	z9915 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9915")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PRODJECTNAME":z9915.ProdjectName = Children(i).Code
   Case "PROGRAMNO":z9915.ProgramNo = Children(i).Code
   Case "SHEETNAME":z9915.SheetName = Children(i).Code
   Case "COLUMNSPANID":z9915.ColumnSpanID = Children(i).Code
   Case "COLUMNSPANSEQ":z9915.ColumnSpanSeq = Children(i).Code
   Case "TITLE":z9915.Title = Children(i).Code
   Case "FOREIGNNAME1":z9915.ForeignName1 = Children(i).Code
   Case "FOREIGNNAME2":z9915.ForeignName2 = Children(i).Code
   Case "BEGINCOLUMN":z9915.BeginColumn = Children(i).Code
   Case "ENDCOLUMN":z9915.EndColumn = Children(i).Code
   Case "REMARK":z9915.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PRODJECTNAME":z9915.ProdjectName = Children(i).Data
   Case "PROGRAMNO":z9915.ProgramNo = Children(i).Data
   Case "SHEETNAME":z9915.SheetName = Children(i).Data
   Case "COLUMNSPANID":z9915.ColumnSpanID = Children(i).Data
   Case "COLUMNSPANSEQ":z9915.ColumnSpanSeq = Children(i).Data
   Case "TITLE":z9915.Title = Children(i).Data
   Case "FOREIGNNAME1":z9915.ForeignName1 = Children(i).Data
   Case "FOREIGNNAME2":z9915.ForeignName2 = Children(i).Data
   Case "BEGINCOLUMN":z9915.BeginColumn = Children(i).Data
   Case "ENDCOLUMN":z9915.EndColumn = Children(i).Data
   Case "REMARK":z9915.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K9915_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K9915_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9915 As T9915_AREA, Job as String, CheckClear as Boolean, PRODJECTNAME AS String, PROGRAMNO AS String, SHEETNAME AS String, COLUMNSPANID AS Double, COLUMNSPANSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9915_MOVE = False

Try
    If READ_PFK9915(PRODJECTNAME, PROGRAMNO, SHEETNAME, COLUMNSPANID, COLUMNSPANSEQ) = True Then
                z9915 = D9915
		K9915_MOVE = True
		else
	If CheckClear  = True then z9915 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9915")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PRODJECTNAME":z9915.ProdjectName = Children(i).Code
   Case "PROGRAMNO":z9915.ProgramNo = Children(i).Code
   Case "SHEETNAME":z9915.SheetName = Children(i).Code
   Case "COLUMNSPANID":z9915.ColumnSpanID = Children(i).Code
   Case "COLUMNSPANSEQ":z9915.ColumnSpanSeq = Children(i).Code
   Case "TITLE":z9915.Title = Children(i).Code
   Case "FOREIGNNAME1":z9915.ForeignName1 = Children(i).Code
   Case "FOREIGNNAME2":z9915.ForeignName2 = Children(i).Code
   Case "BEGINCOLUMN":z9915.BeginColumn = Children(i).Code
   Case "ENDCOLUMN":z9915.EndColumn = Children(i).Code
   Case "REMARK":z9915.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PRODJECTNAME":z9915.ProdjectName = Children(i).Data
   Case "PROGRAMNO":z9915.ProgramNo = Children(i).Data
   Case "SHEETNAME":z9915.SheetName = Children(i).Data
   Case "COLUMNSPANID":z9915.ColumnSpanID = Children(i).Data
   Case "COLUMNSPANSEQ":z9915.ColumnSpanSeq = Children(i).Data
   Case "TITLE":z9915.Title = Children(i).Data
   Case "FOREIGNNAME1":z9915.ForeignName1 = Children(i).Data
   Case "FOREIGNNAME2":z9915.ForeignName2 = Children(i).Data
   Case "BEGINCOLUMN":z9915.BeginColumn = Children(i).Data
   Case "ENDCOLUMN":z9915.EndColumn = Children(i).Data
   Case "REMARK":z9915.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K9915_MOVE",vbCritical)
End Try
End Function 
    
End Module 
