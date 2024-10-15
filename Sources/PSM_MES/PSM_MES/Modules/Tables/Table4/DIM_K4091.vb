'=========================================================================================================================================================
'   TABLE : (PFK4091)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K4091

Structure T4091_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	ProdDate	 AS String	'			char(8)		*
Public 	ProdSeq	 AS String	'			char(5)		*
Public 	ProdSno	 AS String	'			char(2)		*
Public 	QtyProductionX	 AS Double	'			decimal
Public 	seDefect	 AS Double	'			decimal
Public 	cdDefect	 AS String	'			nvarchar(30)
Public 	Remark	 AS String	'			nvarchar(100)
'=========================================================================================================================================================
End structure

Public D4091 As T4091_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK4091(PRODDATE AS String, PRODSEQ AS String, PRODSNO AS String) As Boolean
    READ_PFK4091 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4091 "
    SQL = SQL & " WHERE K4091_ProdDate		 = '" & ProdDate & "' " 
    SQL = SQL & "   AND K4091_ProdSeq		 = '" & ProdSeq & "' " 
    SQL = SQL & "   AND K4091_ProdSno		 = '" & ProdSno & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D4091_CLEAR: GoTo SKIP_READ_PFK4091
                
    Call K4091_MOVE(rd)
    READ_PFK4091 = True

SKIP_READ_PFK4091:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK4091",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK4091(PRODDATE AS String, PRODSEQ AS String, PRODSNO AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4091 "
    SQL = SQL & " WHERE K4091_ProdDate		 = '" & ProdDate & "' " 
    SQL = SQL & "   AND K4091_ProdSeq		 = '" & ProdSeq & "' " 
    SQL = SQL & "   AND K4091_ProdSno		 = '" & ProdSno & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK4091",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK4091(z4091 As T4091_AREA) As Boolean
    WRITE_PFK4091 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z4091)
 
    SQL = " INSERT INTO PFK4091 "
    SQL = SQL & " ( "
    SQL = SQL & " K4091_ProdDate," 
    SQL = SQL & " K4091_ProdSeq," 
    SQL = SQL & " K4091_ProdSno," 
    SQL = SQL & " K4091_QtyProductionX," 
    SQL = SQL & " K4091_seDefect," 
    SQL = SQL & " K4091_cdDefect," 
    SQL = SQL & " K4091_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z4091.ProdDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4091.ProdSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4091.ProdSno) & "', "  
    SQL = SQL & "   " & FormatSQL(z4091.QtyProductionX) & ", "  
    SQL = SQL & "   " & FormatSQL(z4091.seDefect) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4091.cdDefect) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4091.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK4091 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK4091",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK4091(z4091 As T4091_AREA) As Boolean
    REWRITE_PFK4091 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z4091)
   
    SQL = " UPDATE PFK4091 SET "
    SQL = SQL & "    K4091_QtyProductionX      =  " & FormatSQL(z4091.QtyProductionX) & ", " 
    SQL = SQL & "    K4091_seDefect      =  " & FormatSQL(z4091.seDefect) & ", " 
    SQL = SQL & "    K4091_cdDefect      = N'" & FormatSQL(z4091.cdDefect) & "', " 
    SQL = SQL & "    K4091_Remark      = N'" & FormatSQL(z4091.Remark) & "'  " 
    SQL = SQL & " WHERE K4091_ProdDate		 = '" & z4091.ProdDate & "' " 
    SQL = SQL & "   AND K4091_ProdSeq		 = '" & z4091.ProdSeq & "' " 
    SQL = SQL & "   AND K4091_ProdSno		 = '" & z4091.ProdSno & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK4091 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK4091",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK4091(z4091 As T4091_AREA) As Boolean
    DELETE_PFK4091 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK4091 "
    SQL = SQL & " WHERE K4091_ProdDate		 = '" & z4091.ProdDate & "' " 
    SQL = SQL & "   AND K4091_ProdSeq		 = '" & z4091.ProdSeq & "' " 
    SQL = SQL & "   AND K4091_ProdSno		 = '" & z4091.ProdSno & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK4091 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK4091",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D4091_CLEAR()
Try
    
   D4091.ProdDate = ""
   D4091.ProdSeq = ""
   D4091.ProdSno = ""
    D4091.QtyProductionX = 0 
    D4091.seDefect = 0 
   D4091.cdDefect = ""
   D4091.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D4091_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x4091 As T4091_AREA)
Try
    
    x4091.ProdDate = trim$(  x4091.ProdDate)
    x4091.ProdSeq = trim$(  x4091.ProdSeq)
    x4091.ProdSno = trim$(  x4091.ProdSno)
    x4091.QtyProductionX = trim$(  x4091.QtyProductionX)
    x4091.seDefect = trim$(  x4091.seDefect)
    x4091.cdDefect = trim$(  x4091.cdDefect)
    x4091.Remark = trim$(  x4091.Remark)
     
    If trim$( x4091.ProdDate ) = "" Then x4091.ProdDate = Space(1) 
    If trim$( x4091.ProdSeq ) = "" Then x4091.ProdSeq = Space(1) 
    If trim$( x4091.ProdSno ) = "" Then x4091.ProdSno = Space(1) 
    If trim$( x4091.QtyProductionX ) = "" Then x4091.QtyProductionX = 0 
    If trim$( x4091.seDefect ) = "" Then x4091.seDefect = 0 
    If trim$( x4091.cdDefect ) = "" Then x4091.cdDefect = Space(1) 
    If trim$( x4091.Remark ) = "" Then x4091.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K4091_MOVE(rs4091 As SqlClient.SqlDataReader)
Try

    call D4091_CLEAR()   

    If IsdbNull(rs4091!K4091_ProdDate) = False Then D4091.ProdDate = Trim$(rs4091!K4091_ProdDate)
    If IsdbNull(rs4091!K4091_ProdSeq) = False Then D4091.ProdSeq = Trim$(rs4091!K4091_ProdSeq)
    If IsdbNull(rs4091!K4091_ProdSno) = False Then D4091.ProdSno = Trim$(rs4091!K4091_ProdSno)
    If IsdbNull(rs4091!K4091_QtyProductionX) = False Then D4091.QtyProductionX = Trim$(rs4091!K4091_QtyProductionX)
    If IsdbNull(rs4091!K4091_seDefect) = False Then D4091.seDefect = Trim$(rs4091!K4091_seDefect)
    If IsdbNull(rs4091!K4091_cdDefect) = False Then D4091.cdDefect = Trim$(rs4091!K4091_cdDefect)
    If IsdbNull(rs4091!K4091_Remark) = False Then D4091.Remark = Trim$(rs4091!K4091_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4091_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K4091_MOVE(rs4091 As DataRow)
Try

    call D4091_CLEAR()   

    If IsdbNull(rs4091!K4091_ProdDate) = False Then D4091.ProdDate = Trim$(rs4091!K4091_ProdDate)
    If IsdbNull(rs4091!K4091_ProdSeq) = False Then D4091.ProdSeq = Trim$(rs4091!K4091_ProdSeq)
    If IsdbNull(rs4091!K4091_ProdSno) = False Then D4091.ProdSno = Trim$(rs4091!K4091_ProdSno)
    If IsdbNull(rs4091!K4091_QtyProductionX) = False Then D4091.QtyProductionX = Trim$(rs4091!K4091_QtyProductionX)
    If IsdbNull(rs4091!K4091_seDefect) = False Then D4091.seDefect = Trim$(rs4091!K4091_seDefect)
    If IsdbNull(rs4091!K4091_cdDefect) = False Then D4091.cdDefect = Trim$(rs4091!K4091_cdDefect)
    If IsdbNull(rs4091!K4091_Remark) = False Then D4091.Remark = Trim$(rs4091!K4091_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4091_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K4091_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4091 As T4091_AREA, PRODDATE AS String, PRODSEQ AS String, PRODSNO AS String) as Boolean

K4091_MOVE = False

Try
    If READ_PFK4091(PRODDATE, PRODSEQ, PRODSNO) = True Then
                z4091 = D4091
		K4091_MOVE = True
		else
	z4091 = nothing
     End If

     If  getColumIndex(spr,"ProdDate") > -1 then z4091.ProdDate = getDataM(spr, getColumIndex(spr,"ProdDate"), xRow)
     If  getColumIndex(spr,"ProdSeq") > -1 then z4091.ProdSeq = getDataM(spr, getColumIndex(spr,"ProdSeq"), xRow)
     If  getColumIndex(spr,"ProdSno") > -1 then z4091.ProdSno = getDataM(spr, getColumIndex(spr,"ProdSno"), xRow)
     If  getColumIndex(spr,"QtyProductionX") > -1 then z4091.QtyProductionX = getDataM(spr, getColumIndex(spr,"QtyProductionX"), xRow)
     If  getColumIndex(spr,"seDefect") > -1 then z4091.seDefect = getDataM(spr, getColumIndex(spr,"seDefect"), xRow)
     If  getColumIndex(spr,"cdDefect") > -1 then z4091.cdDefect = getDataM(spr, getColumIndex(spr,"cdDefect"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4091.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4091_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K4091_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4091 As T4091_AREA,CheckClear as Boolean,PRODDATE AS String, PRODSEQ AS String, PRODSNO AS String) as Boolean

K4091_MOVE = False

Try
    If READ_PFK4091(PRODDATE, PRODSEQ, PRODSNO) = True Then
                z4091 = D4091
		K4091_MOVE = True
		else
	If CheckClear  = True then z4091 = nothing
     End If

     If  getColumIndex(spr,"ProdDate") > -1 then z4091.ProdDate = getDataM(spr, getColumIndex(spr,"ProdDate"), xRow)
     If  getColumIndex(spr,"ProdSeq") > -1 then z4091.ProdSeq = getDataM(spr, getColumIndex(spr,"ProdSeq"), xRow)
     If  getColumIndex(spr,"ProdSno") > -1 then z4091.ProdSno = getDataM(spr, getColumIndex(spr,"ProdSno"), xRow)
     If  getColumIndex(spr,"QtyProductionX") > -1 then z4091.QtyProductionX = getDataM(spr, getColumIndex(spr,"QtyProductionX"), xRow)
     If  getColumIndex(spr,"seDefect") > -1 then z4091.seDefect = getDataM(spr, getColumIndex(spr,"seDefect"), xRow)
     If  getColumIndex(spr,"cdDefect") > -1 then z4091.cdDefect = getDataM(spr, getColumIndex(spr,"cdDefect"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4091.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4091_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K4091_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4091 As T4091_AREA, Job as String, PRODDATE AS String, PRODSEQ AS String, PRODSNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4091_MOVE = False

Try
    If READ_PFK4091(PRODDATE, PRODSEQ, PRODSNO) = True Then
                z4091 = D4091
		K4091_MOVE = True
		else
	z4091 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4091")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PRODDATE":z4091.ProdDate = Children(i).Code
   Case "PRODSEQ":z4091.ProdSeq = Children(i).Code
   Case "PRODSNO":z4091.ProdSno = Children(i).Code
   Case "QTYPRODUCTIONX":z4091.QtyProductionX = Children(i).Code
   Case "SEDEFECT":z4091.seDefect = Children(i).Code
   Case "CDDEFECT":z4091.cdDefect = Children(i).Code
   Case "REMARK":z4091.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PRODDATE":z4091.ProdDate = Children(i).Data
   Case "PRODSEQ":z4091.ProdSeq = Children(i).Data
   Case "PRODSNO":z4091.ProdSno = Children(i).Data
   Case "QTYPRODUCTIONX":z4091.QtyProductionX = Children(i).Data
   Case "SEDEFECT":z4091.seDefect = Children(i).Data
   Case "CDDEFECT":z4091.cdDefect = Children(i).Data
   Case "REMARK":z4091.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4091_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K4091_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4091 As T4091_AREA, Job as String, CheckClear as Boolean, PRODDATE AS String, PRODSEQ AS String, PRODSNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4091_MOVE = False

Try
    If READ_PFK4091(PRODDATE, PRODSEQ, PRODSNO) = True Then
                z4091 = D4091
		K4091_MOVE = True
		else
	If CheckClear  = True then z4091 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4091")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PRODDATE":z4091.ProdDate = Children(i).Code
   Case "PRODSEQ":z4091.ProdSeq = Children(i).Code
   Case "PRODSNO":z4091.ProdSno = Children(i).Code
   Case "QTYPRODUCTIONX":z4091.QtyProductionX = Children(i).Code
   Case "SEDEFECT":z4091.seDefect = Children(i).Code
   Case "CDDEFECT":z4091.cdDefect = Children(i).Code
   Case "REMARK":z4091.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PRODDATE":z4091.ProdDate = Children(i).Data
   Case "PRODSEQ":z4091.ProdSeq = Children(i).Data
   Case "PRODSNO":z4091.ProdSno = Children(i).Data
   Case "QTYPRODUCTIONX":z4091.QtyProductionX = Children(i).Data
   Case "SEDEFECT":z4091.seDefect = Children(i).Data
   Case "CDDEFECT":z4091.cdDefect = Children(i).Data
   Case "REMARK":z4091.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4091_MOVE",vbCritical)
End Try
End Function 
    
End Module 
