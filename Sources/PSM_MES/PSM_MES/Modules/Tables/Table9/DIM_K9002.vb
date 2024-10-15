'=========================================================================================================================================================
'   TABLE : (PFK9002)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K9002

Structure T9002_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	MappingNo	 AS String	'			char(6)		*
Public 	MappingSeq	 AS String	'			char(3)		*
Public 	ItemCode	 AS String	'			char(6)
Public 	RowBegin	 AS Double	'			decimal
Public 	RowEnd	 AS Double	'			decimal
Public 	ColBegin	 AS Double	'			decimal
Public 	ColEnd	 AS Double	'			decimal
Public 	RowCount	 AS Double	'			decimal
Public 	ColCount	 AS Double	'			decimal
Public 	Remark	 AS String	'			nvarchar(50)
'=========================================================================================================================================================
End structure

Public D9002 As T9002_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK9002(MAPPINGNO AS String, MAPPINGSEQ AS String) As Boolean
    READ_PFK9002 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9002 "
    SQL = SQL & " WHERE K9002_MappingNo		 = '" & MappingNo & "' " 
    SQL = SQL & "   AND K9002_MappingSeq		 = '" & MappingSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D9002_CLEAR: GoTo SKIP_READ_PFK9002
                
    Call K9002_MOVE(rd)
    READ_PFK9002 = True

SKIP_READ_PFK9002:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK9002",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK9002(MAPPINGNO AS String, MAPPINGSEQ AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9002 "
    SQL = SQL & " WHERE K9002_MappingNo		 = '" & MappingNo & "' " 
    SQL = SQL & "   AND K9002_MappingSeq		 = '" & MappingSeq & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK9002",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK9002(z9002 As T9002_AREA) As Boolean
    WRITE_PFK9002 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z9002)
 
    SQL = " INSERT INTO PFK9002 "
    SQL = SQL & " ( "
    SQL = SQL & " K9002_MappingNo," 
    SQL = SQL & " K9002_MappingSeq," 
    SQL = SQL & " K9002_ItemCode," 
    SQL = SQL & " K9002_RowBegin," 
    SQL = SQL & " K9002_RowEnd," 
    SQL = SQL & " K9002_ColBegin," 
    SQL = SQL & " K9002_ColEnd," 
    SQL = SQL & " K9002_RowCount," 
    SQL = SQL & " K9002_ColCount," 
    SQL = SQL & " K9002_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z9002.MappingNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9002.MappingSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9002.ItemCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z9002.RowBegin) & ", "  
    SQL = SQL & "   " & FormatSQL(z9002.RowEnd) & ", "  
    SQL = SQL & "   " & FormatSQL(z9002.ColBegin) & ", "  
    SQL = SQL & "   " & FormatSQL(z9002.ColEnd) & ", "  
    SQL = SQL & "   " & FormatSQL(z9002.RowCount) & ", "  
    SQL = SQL & "   " & FormatSQL(z9002.ColCount) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z9002.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK9002 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK9002",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK9002(z9002 As T9002_AREA) As Boolean
    REWRITE_PFK9002 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z9002)
   
    SQL = " UPDATE PFK9002 SET "
    SQL = SQL & "    K9002_ItemCode      = N'" & FormatSQL(z9002.ItemCode) & "', " 
    SQL = SQL & "    K9002_RowBegin      =  " & FormatSQL(z9002.RowBegin) & ", " 
    SQL = SQL & "    K9002_RowEnd      =  " & FormatSQL(z9002.RowEnd) & ", " 
    SQL = SQL & "    K9002_ColBegin      =  " & FormatSQL(z9002.ColBegin) & ", " 
    SQL = SQL & "    K9002_ColEnd      =  " & FormatSQL(z9002.ColEnd) & ", " 
    SQL = SQL & "    K9002_RowCount      =  " & FormatSQL(z9002.RowCount) & ", " 
    SQL = SQL & "    K9002_ColCount      =  " & FormatSQL(z9002.ColCount) & ", " 
    SQL = SQL & "    K9002_Remark      = N'" & FormatSQL(z9002.Remark) & "'  " 
    SQL = SQL & " WHERE K9002_MappingNo		 = '" & z9002.MappingNo & "' " 
    SQL = SQL & "   AND K9002_MappingSeq		 = '" & z9002.MappingSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK9002 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK9002",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK9002(z9002 As T9002_AREA) As Boolean
    DELETE_PFK9002 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK9002 "
    SQL = SQL & " WHERE K9002_MappingNo		 = '" & z9002.MappingNo & "' " 
    SQL = SQL & "   AND K9002_MappingSeq		 = '" & z9002.MappingSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK9002 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK9002",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D9002_CLEAR()
Try
    
   D9002.MappingNo = ""
   D9002.MappingSeq = ""
   D9002.ItemCode = ""
    D9002.RowBegin = 0 
    D9002.RowEnd = 0 
    D9002.ColBegin = 0 
    D9002.ColEnd = 0 
    D9002.RowCount = 0 
    D9002.ColCount = 0 
   D9002.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D9002_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x9002 As T9002_AREA)
Try
    
    x9002.MappingNo = trim$(  x9002.MappingNo)
    x9002.MappingSeq = trim$(  x9002.MappingSeq)
    x9002.ItemCode = trim$(  x9002.ItemCode)
    x9002.RowBegin = trim$(  x9002.RowBegin)
    x9002.RowEnd = trim$(  x9002.RowEnd)
    x9002.ColBegin = trim$(  x9002.ColBegin)
    x9002.ColEnd = trim$(  x9002.ColEnd)
    x9002.RowCount = trim$(  x9002.RowCount)
    x9002.ColCount = trim$(  x9002.ColCount)
    x9002.Remark = trim$(  x9002.Remark)
     
    If trim$( x9002.MappingNo ) = "" Then x9002.MappingNo = Space(1) 
    If trim$( x9002.MappingSeq ) = "" Then x9002.MappingSeq = Space(1) 
    If trim$( x9002.ItemCode ) = "" Then x9002.ItemCode = Space(1) 
    If trim$( x9002.RowBegin ) = "" Then x9002.RowBegin = 0 
    If trim$( x9002.RowEnd ) = "" Then x9002.RowEnd = 0 
    If trim$( x9002.ColBegin ) = "" Then x9002.ColBegin = 0 
    If trim$( x9002.ColEnd ) = "" Then x9002.ColEnd = 0 
    If trim$( x9002.RowCount ) = "" Then x9002.RowCount = 0 
    If trim$( x9002.ColCount ) = "" Then x9002.ColCount = 0 
    If trim$( x9002.Remark ) = "" Then x9002.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K9002_MOVE(rs9002 As SqlClient.SqlDataReader)
Try

    call D9002_CLEAR()   

    If IsdbNull(rs9002!K9002_MappingNo) = False Then D9002.MappingNo = Trim$(rs9002!K9002_MappingNo)
    If IsdbNull(rs9002!K9002_MappingSeq) = False Then D9002.MappingSeq = Trim$(rs9002!K9002_MappingSeq)
    If IsdbNull(rs9002!K9002_ItemCode) = False Then D9002.ItemCode = Trim$(rs9002!K9002_ItemCode)
    If IsdbNull(rs9002!K9002_RowBegin) = False Then D9002.RowBegin = Trim$(rs9002!K9002_RowBegin)
    If IsdbNull(rs9002!K9002_RowEnd) = False Then D9002.RowEnd = Trim$(rs9002!K9002_RowEnd)
    If IsdbNull(rs9002!K9002_ColBegin) = False Then D9002.ColBegin = Trim$(rs9002!K9002_ColBegin)
    If IsdbNull(rs9002!K9002_ColEnd) = False Then D9002.ColEnd = Trim$(rs9002!K9002_ColEnd)
    If IsdbNull(rs9002!K9002_RowCount) = False Then D9002.RowCount = Trim$(rs9002!K9002_RowCount)
    If IsdbNull(rs9002!K9002_ColCount) = False Then D9002.ColCount = Trim$(rs9002!K9002_ColCount)
    If IsdbNull(rs9002!K9002_Remark) = False Then D9002.Remark = Trim$(rs9002!K9002_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9002_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K9002_MOVE(rs9002 As DataRow)
Try

    call D9002_CLEAR()   

    If IsdbNull(rs9002!K9002_MappingNo) = False Then D9002.MappingNo = Trim$(rs9002!K9002_MappingNo)
    If IsdbNull(rs9002!K9002_MappingSeq) = False Then D9002.MappingSeq = Trim$(rs9002!K9002_MappingSeq)
    If IsdbNull(rs9002!K9002_ItemCode) = False Then D9002.ItemCode = Trim$(rs9002!K9002_ItemCode)
    If IsdbNull(rs9002!K9002_RowBegin) = False Then D9002.RowBegin = Trim$(rs9002!K9002_RowBegin)
    If IsdbNull(rs9002!K9002_RowEnd) = False Then D9002.RowEnd = Trim$(rs9002!K9002_RowEnd)
    If IsdbNull(rs9002!K9002_ColBegin) = False Then D9002.ColBegin = Trim$(rs9002!K9002_ColBegin)
    If IsdbNull(rs9002!K9002_ColEnd) = False Then D9002.ColEnd = Trim$(rs9002!K9002_ColEnd)
    If IsdbNull(rs9002!K9002_RowCount) = False Then D9002.RowCount = Trim$(rs9002!K9002_RowCount)
    If IsdbNull(rs9002!K9002_ColCount) = False Then D9002.ColCount = Trim$(rs9002!K9002_ColCount)
    If IsdbNull(rs9002!K9002_Remark) = False Then D9002.Remark = Trim$(rs9002!K9002_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9002_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K9002_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9002 As T9002_AREA, MAPPINGNO AS String, MAPPINGSEQ AS String) as Boolean

K9002_MOVE = False

Try
    If READ_PFK9002(MAPPINGNO, MAPPINGSEQ) = True Then
                z9002 = D9002
		K9002_MOVE = True
		else
	z9002 = nothing
     End If

     If  getColumIndex(spr,"MappingNo") > -1 then z9002.MappingNo = getDataM(spr, getColumIndex(spr,"MappingNo"), xRow)
     If  getColumIndex(spr,"MappingSeq") > -1 then z9002.MappingSeq = getDataM(spr, getColumIndex(spr,"MappingSeq"), xRow)
     If  getColumIndex(spr,"ItemCode") > -1 then z9002.ItemCode = getDataM(spr, getColumIndex(spr,"ItemCode"), xRow)
     If  getColumIndex(spr,"RowBegin") > -1 then z9002.RowBegin = getDataM(spr, getColumIndex(spr,"RowBegin"), xRow)
     If  getColumIndex(spr,"RowEnd") > -1 then z9002.RowEnd = getDataM(spr, getColumIndex(spr,"RowEnd"), xRow)
     If  getColumIndex(spr,"ColBegin") > -1 then z9002.ColBegin = getDataM(spr, getColumIndex(spr,"ColBegin"), xRow)
     If  getColumIndex(spr,"ColEnd") > -1 then z9002.ColEnd = getDataM(spr, getColumIndex(spr,"ColEnd"), xRow)
     If  getColumIndex(spr,"RowCount") > -1 then z9002.RowCount = getDataM(spr, getColumIndex(spr,"RowCount"), xRow)
     If  getColumIndex(spr,"ColCount") > -1 then z9002.ColCount = getDataM(spr, getColumIndex(spr,"ColCount"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z9002.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K9002_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K9002_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9002 As T9002_AREA,CheckClear as Boolean,MAPPINGNO AS String, MAPPINGSEQ AS String) as Boolean

K9002_MOVE = False

Try
    If READ_PFK9002(MAPPINGNO, MAPPINGSEQ) = True Then
                z9002 = D9002
		K9002_MOVE = True
		else
	If CheckClear  = True then z9002 = nothing
     End If

     If  getColumIndex(spr,"MappingNo") > -1 then z9002.MappingNo = getDataM(spr, getColumIndex(spr,"MappingNo"), xRow)
     If  getColumIndex(spr,"MappingSeq") > -1 then z9002.MappingSeq = getDataM(spr, getColumIndex(spr,"MappingSeq"), xRow)
     If  getColumIndex(spr,"ItemCode") > -1 then z9002.ItemCode = getDataM(spr, getColumIndex(spr,"ItemCode"), xRow)
     If  getColumIndex(spr,"RowBegin") > -1 then z9002.RowBegin = getDataM(spr, getColumIndex(spr,"RowBegin"), xRow)
     If  getColumIndex(spr,"RowEnd") > -1 then z9002.RowEnd = getDataM(spr, getColumIndex(spr,"RowEnd"), xRow)
     If  getColumIndex(spr,"ColBegin") > -1 then z9002.ColBegin = getDataM(spr, getColumIndex(spr,"ColBegin"), xRow)
     If  getColumIndex(spr,"ColEnd") > -1 then z9002.ColEnd = getDataM(spr, getColumIndex(spr,"ColEnd"), xRow)
     If  getColumIndex(spr,"RowCount") > -1 then z9002.RowCount = getDataM(spr, getColumIndex(spr,"RowCount"), xRow)
     If  getColumIndex(spr,"ColCount") > -1 then z9002.ColCount = getDataM(spr, getColumIndex(spr,"ColCount"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z9002.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K9002_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K9002_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9002 As T9002_AREA, Job as String, MAPPINGNO AS String, MAPPINGSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9002_MOVE = False

Try
    If READ_PFK9002(MAPPINGNO, MAPPINGSEQ) = True Then
                z9002 = D9002
		K9002_MOVE = True
		else
	z9002 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9002")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "MAPPINGNO":z9002.MappingNo = Children(i).Code
   Case "MAPPINGSEQ":z9002.MappingSeq = Children(i).Code
   Case "ITEMCODE":z9002.ItemCode = Children(i).Code
   Case "ROWBEGIN":z9002.RowBegin = Children(i).Code
   Case "ROWEND":z9002.RowEnd = Children(i).Code
   Case "COLBEGIN":z9002.ColBegin = Children(i).Code
   Case "COLEND":z9002.ColEnd = Children(i).Code
   Case "ROWCOUNT":z9002.RowCount = Children(i).Code
   Case "COLCOUNT":z9002.ColCount = Children(i).Code
   Case "REMARK":z9002.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "MAPPINGNO":z9002.MappingNo = Children(i).Data
   Case "MAPPINGSEQ":z9002.MappingSeq = Children(i).Data
   Case "ITEMCODE":z9002.ItemCode = Children(i).Data
   Case "ROWBEGIN":z9002.RowBegin = Children(i).Data
   Case "ROWEND":z9002.RowEnd = Children(i).Data
   Case "COLBEGIN":z9002.ColBegin = Children(i).Data
   Case "COLEND":z9002.ColEnd = Children(i).Data
   Case "ROWCOUNT":z9002.RowCount = Children(i).Data
   Case "COLCOUNT":z9002.ColCount = Children(i).Data
   Case "REMARK":z9002.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K9002_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K9002_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9002 As T9002_AREA, Job as String, CheckClear as Boolean, MAPPINGNO AS String, MAPPINGSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9002_MOVE = False

Try
    If READ_PFK9002(MAPPINGNO, MAPPINGSEQ) = True Then
                z9002 = D9002
		K9002_MOVE = True
		else
	If CheckClear  = True then z9002 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9002")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "MAPPINGNO":z9002.MappingNo = Children(i).Code
   Case "MAPPINGSEQ":z9002.MappingSeq = Children(i).Code
   Case "ITEMCODE":z9002.ItemCode = Children(i).Code
   Case "ROWBEGIN":z9002.RowBegin = Children(i).Code
   Case "ROWEND":z9002.RowEnd = Children(i).Code
   Case "COLBEGIN":z9002.ColBegin = Children(i).Code
   Case "COLEND":z9002.ColEnd = Children(i).Code
   Case "ROWCOUNT":z9002.RowCount = Children(i).Code
   Case "COLCOUNT":z9002.ColCount = Children(i).Code
   Case "REMARK":z9002.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "MAPPINGNO":z9002.MappingNo = Children(i).Data
   Case "MAPPINGSEQ":z9002.MappingSeq = Children(i).Data
   Case "ITEMCODE":z9002.ItemCode = Children(i).Data
   Case "ROWBEGIN":z9002.RowBegin = Children(i).Data
   Case "ROWEND":z9002.RowEnd = Children(i).Data
   Case "COLBEGIN":z9002.ColBegin = Children(i).Data
   Case "COLEND":z9002.ColEnd = Children(i).Data
   Case "ROWCOUNT":z9002.RowCount = Children(i).Data
   Case "COLCOUNT":z9002.ColCount = Children(i).Data
   Case "REMARK":z9002.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K9002_MOVE",vbCritical)
End Try
End Function 
    
End Module 
