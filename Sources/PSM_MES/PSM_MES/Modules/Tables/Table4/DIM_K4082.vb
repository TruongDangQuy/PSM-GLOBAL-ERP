'=========================================================================================================================================================
'   TABLE : (PFK4082)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K4082

Structure T4082_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	ProdDate	 AS String	'			char(8)		*
Public 	ProdSeq	 AS String	'			char(5)		*
Public 	ProdSzno	 AS String	'			char(2)		*
Public 	QtyProduction	 AS Double	'			decimal
Public 	QtyProductionA	 AS Double	'			decimal
Public 	QtyProductionX	 AS Double	'			decimal
Public 	QtyProductionXP	 AS Double	'			decimal
Public 	QtyProductionXD	 AS Double	'			decimal
Public 	QtyOutProduction	 AS Double	'			decimal
Public 	ISUD	 AS String	'			char(4)
Public 	CheckComplete	 AS String	'			char(1)
Public 	CheckTrigger	 AS String	'			nvarchar(10)
Public 	Remark	 AS String	'			nvarchar(100)
'=========================================================================================================================================================
End structure

Public D4082 As T4082_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK4082(PRODDATE AS String, PRODSEQ AS String, PRODSZNO AS String) As Boolean
    READ_PFK4082 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4082 "
    SQL = SQL & " WHERE K4082_ProdDate		 = '" & ProdDate & "' " 
    SQL = SQL & "   AND K4082_ProdSeq		 = '" & ProdSeq & "' " 
    SQL = SQL & "   AND K4082_ProdSzno		 = '" & ProdSzno & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D4082_CLEAR: GoTo SKIP_READ_PFK4082
                
    Call K4082_MOVE(rd)
    READ_PFK4082 = True

SKIP_READ_PFK4082:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK4082",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK4082(PRODDATE AS String, PRODSEQ AS String, PRODSZNO AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4082 "
    SQL = SQL & " WHERE K4082_ProdDate		 = '" & ProdDate & "' " 
    SQL = SQL & "   AND K4082_ProdSeq		 = '" & ProdSeq & "' " 
    SQL = SQL & "   AND K4082_ProdSzno		 = '" & ProdSzno & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK4082",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK4082(z4082 As T4082_AREA) As Boolean
    WRITE_PFK4082 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z4082)
 
    SQL = " INSERT INTO PFK4082 "
    SQL = SQL & " ( "
    SQL = SQL & " K4082_ProdDate," 
    SQL = SQL & " K4082_ProdSeq," 
    SQL = SQL & " K4082_ProdSzno," 
    SQL = SQL & " K4082_QtyProduction," 
    SQL = SQL & " K4082_QtyProductionA," 
    SQL = SQL & " K4082_QtyProductionX," 
    SQL = SQL & " K4082_QtyProductionXP," 
    SQL = SQL & " K4082_QtyProductionXD," 
    SQL = SQL & " K4082_QtyOutProduction," 
    SQL = SQL & " K4082_ISUD," 
    SQL = SQL & " K4082_CheckComplete," 
    SQL = SQL & " K4082_CheckTrigger," 
    SQL = SQL & " K4082_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z4082.ProdDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4082.ProdSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4082.ProdSzno) & "', "  
    SQL = SQL & "   " & FormatSQL(z4082.QtyProduction) & ", "  
    SQL = SQL & "   " & FormatSQL(z4082.QtyProductionA) & ", "  
    SQL = SQL & "   " & FormatSQL(z4082.QtyProductionX) & ", "  
    SQL = SQL & "   " & FormatSQL(z4082.QtyProductionXP) & ", "  
    SQL = SQL & "   " & FormatSQL(z4082.QtyProductionXD) & ", "  
    SQL = SQL & "   " & FormatSQL(z4082.QtyOutProduction) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4082.ISUD) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4082.CheckComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4082.CheckTrigger) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4082.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK4082 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK4082",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK4082(z4082 As T4082_AREA) As Boolean
    REWRITE_PFK4082 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z4082)
   
    SQL = " UPDATE PFK4082 SET "
    SQL = SQL & "    K4082_QtyProduction      =  " & FormatSQL(z4082.QtyProduction) & ", " 
    SQL = SQL & "    K4082_QtyProductionA      =  " & FormatSQL(z4082.QtyProductionA) & ", " 
    SQL = SQL & "    K4082_QtyProductionX      =  " & FormatSQL(z4082.QtyProductionX) & ", " 
    SQL = SQL & "    K4082_QtyProductionXP      =  " & FormatSQL(z4082.QtyProductionXP) & ", " 
    SQL = SQL & "    K4082_QtyProductionXD      =  " & FormatSQL(z4082.QtyProductionXD) & ", " 
    SQL = SQL & "    K4082_QtyOutProduction      =  " & FormatSQL(z4082.QtyOutProduction) & ", " 
    SQL = SQL & "    K4082_ISUD      = N'" & FormatSQL(z4082.ISUD) & "', " 
    SQL = SQL & "    K4082_CheckComplete      = N'" & FormatSQL(z4082.CheckComplete) & "', " 
    SQL = SQL & "    K4082_CheckTrigger      = N'" & FormatSQL(z4082.CheckTrigger) & "', " 
    SQL = SQL & "    K4082_Remark      = N'" & FormatSQL(z4082.Remark) & "'  " 
    SQL = SQL & " WHERE K4082_ProdDate		 = '" & z4082.ProdDate & "' " 
    SQL = SQL & "   AND K4082_ProdSeq		 = '" & z4082.ProdSeq & "' " 
    SQL = SQL & "   AND K4082_ProdSzno		 = '" & z4082.ProdSzno & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK4082 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK4082",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK4082(z4082 As T4082_AREA) As Boolean
    DELETE_PFK4082 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK4082 "
    SQL = SQL & " WHERE K4082_ProdDate		 = '" & z4082.ProdDate & "' " 
    SQL = SQL & "   AND K4082_ProdSeq		 = '" & z4082.ProdSeq & "' " 
    SQL = SQL & "   AND K4082_ProdSzno		 = '" & z4082.ProdSzno & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK4082 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK4082",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D4082_CLEAR()
Try
    
   D4082.ProdDate = ""
   D4082.ProdSeq = ""
   D4082.ProdSzno = ""
    D4082.QtyProduction = 0 
    D4082.QtyProductionA = 0 
    D4082.QtyProductionX = 0 
    D4082.QtyProductionXP = 0 
    D4082.QtyProductionXD = 0 
    D4082.QtyOutProduction = 0 
   D4082.ISUD = ""
   D4082.CheckComplete = ""
   D4082.CheckTrigger = ""
   D4082.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D4082_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x4082 As T4082_AREA)
Try
    
    x4082.ProdDate = trim$(  x4082.ProdDate)
    x4082.ProdSeq = trim$(  x4082.ProdSeq)
    x4082.ProdSzno = trim$(  x4082.ProdSzno)
    x4082.QtyProduction = trim$(  x4082.QtyProduction)
    x4082.QtyProductionA = trim$(  x4082.QtyProductionA)
    x4082.QtyProductionX = trim$(  x4082.QtyProductionX)
    x4082.QtyProductionXP = trim$(  x4082.QtyProductionXP)
    x4082.QtyProductionXD = trim$(  x4082.QtyProductionXD)
    x4082.QtyOutProduction = trim$(  x4082.QtyOutProduction)
    x4082.ISUD = trim$(  x4082.ISUD)
    x4082.CheckComplete = trim$(  x4082.CheckComplete)
    x4082.CheckTrigger = trim$(  x4082.CheckTrigger)
    x4082.Remark = trim$(  x4082.Remark)
     
    If trim$( x4082.ProdDate ) = "" Then x4082.ProdDate = Space(1) 
    If trim$( x4082.ProdSeq ) = "" Then x4082.ProdSeq = Space(1) 
    If trim$( x4082.ProdSzno ) = "" Then x4082.ProdSzno = Space(1) 
    If trim$( x4082.QtyProduction ) = "" Then x4082.QtyProduction = 0 
    If trim$( x4082.QtyProductionA ) = "" Then x4082.QtyProductionA = 0 
    If trim$( x4082.QtyProductionX ) = "" Then x4082.QtyProductionX = 0 
    If trim$( x4082.QtyProductionXP ) = "" Then x4082.QtyProductionXP = 0 
    If trim$( x4082.QtyProductionXD ) = "" Then x4082.QtyProductionXD = 0 
    If trim$( x4082.QtyOutProduction ) = "" Then x4082.QtyOutProduction = 0 
    If trim$( x4082.ISUD ) = "" Then x4082.ISUD = Space(1) 
    If trim$( x4082.CheckComplete ) = "" Then x4082.CheckComplete = Space(1) 
    If trim$( x4082.CheckTrigger ) = "" Then x4082.CheckTrigger = Space(1) 
    If trim$( x4082.Remark ) = "" Then x4082.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K4082_MOVE(rs4082 As SqlClient.SqlDataReader)
Try

    call D4082_CLEAR()   

    If IsdbNull(rs4082!K4082_ProdDate) = False Then D4082.ProdDate = Trim$(rs4082!K4082_ProdDate)
    If IsdbNull(rs4082!K4082_ProdSeq) = False Then D4082.ProdSeq = Trim$(rs4082!K4082_ProdSeq)
    If IsdbNull(rs4082!K4082_ProdSzno) = False Then D4082.ProdSzno = Trim$(rs4082!K4082_ProdSzno)
    If IsdbNull(rs4082!K4082_QtyProduction) = False Then D4082.QtyProduction = Trim$(rs4082!K4082_QtyProduction)
    If IsdbNull(rs4082!K4082_QtyProductionA) = False Then D4082.QtyProductionA = Trim$(rs4082!K4082_QtyProductionA)
    If IsdbNull(rs4082!K4082_QtyProductionX) = False Then D4082.QtyProductionX = Trim$(rs4082!K4082_QtyProductionX)
    If IsdbNull(rs4082!K4082_QtyProductionXP) = False Then D4082.QtyProductionXP = Trim$(rs4082!K4082_QtyProductionXP)
    If IsdbNull(rs4082!K4082_QtyProductionXD) = False Then D4082.QtyProductionXD = Trim$(rs4082!K4082_QtyProductionXD)
    If IsdbNull(rs4082!K4082_QtyOutProduction) = False Then D4082.QtyOutProduction = Trim$(rs4082!K4082_QtyOutProduction)
    If IsdbNull(rs4082!K4082_ISUD) = False Then D4082.ISUD = Trim$(rs4082!K4082_ISUD)
    If IsdbNull(rs4082!K4082_CheckComplete) = False Then D4082.CheckComplete = Trim$(rs4082!K4082_CheckComplete)
    If IsdbNull(rs4082!K4082_CheckTrigger) = False Then D4082.CheckTrigger = Trim$(rs4082!K4082_CheckTrigger)
    If IsdbNull(rs4082!K4082_Remark) = False Then D4082.Remark = Trim$(rs4082!K4082_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4082_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K4082_MOVE(rs4082 As DataRow)
Try

    call D4082_CLEAR()   

    If IsdbNull(rs4082!K4082_ProdDate) = False Then D4082.ProdDate = Trim$(rs4082!K4082_ProdDate)
    If IsdbNull(rs4082!K4082_ProdSeq) = False Then D4082.ProdSeq = Trim$(rs4082!K4082_ProdSeq)
    If IsdbNull(rs4082!K4082_ProdSzno) = False Then D4082.ProdSzno = Trim$(rs4082!K4082_ProdSzno)
    If IsdbNull(rs4082!K4082_QtyProduction) = False Then D4082.QtyProduction = Trim$(rs4082!K4082_QtyProduction)
    If IsdbNull(rs4082!K4082_QtyProductionA) = False Then D4082.QtyProductionA = Trim$(rs4082!K4082_QtyProductionA)
    If IsdbNull(rs4082!K4082_QtyProductionX) = False Then D4082.QtyProductionX = Trim$(rs4082!K4082_QtyProductionX)
    If IsdbNull(rs4082!K4082_QtyProductionXP) = False Then D4082.QtyProductionXP = Trim$(rs4082!K4082_QtyProductionXP)
    If IsdbNull(rs4082!K4082_QtyProductionXD) = False Then D4082.QtyProductionXD = Trim$(rs4082!K4082_QtyProductionXD)
    If IsdbNull(rs4082!K4082_QtyOutProduction) = False Then D4082.QtyOutProduction = Trim$(rs4082!K4082_QtyOutProduction)
    If IsdbNull(rs4082!K4082_ISUD) = False Then D4082.ISUD = Trim$(rs4082!K4082_ISUD)
    If IsdbNull(rs4082!K4082_CheckComplete) = False Then D4082.CheckComplete = Trim$(rs4082!K4082_CheckComplete)
    If IsdbNull(rs4082!K4082_CheckTrigger) = False Then D4082.CheckTrigger = Trim$(rs4082!K4082_CheckTrigger)
    If IsdbNull(rs4082!K4082_Remark) = False Then D4082.Remark = Trim$(rs4082!K4082_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4082_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K4082_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4082 As T4082_AREA, PRODDATE AS String, PRODSEQ AS String, PRODSZNO AS String) as Boolean

K4082_MOVE = False

Try
    If READ_PFK4082(PRODDATE, PRODSEQ, PRODSZNO) = True Then
                z4082 = D4082
		K4082_MOVE = True
		else
	z4082 = nothing
     End If

     If  getColumIndex(spr,"ProdDate") > -1 then z4082.ProdDate = getDataM(spr, getColumIndex(spr,"ProdDate"), xRow)
     If  getColumIndex(spr,"ProdSeq") > -1 then z4082.ProdSeq = getDataM(spr, getColumIndex(spr,"ProdSeq"), xRow)
     If  getColumIndex(spr,"ProdSzno") > -1 then z4082.ProdSzno = getDataM(spr, getColumIndex(spr,"ProdSzno"), xRow)
     If  getColumIndex(spr,"QtyProduction") > -1 then z4082.QtyProduction = getDataM(spr, getColumIndex(spr,"QtyProduction"), xRow)
     If  getColumIndex(spr,"QtyProductionA") > -1 then z4082.QtyProductionA = getDataM(spr, getColumIndex(spr,"QtyProductionA"), xRow)
     If  getColumIndex(spr,"QtyProductionX") > -1 then z4082.QtyProductionX = getDataM(spr, getColumIndex(spr,"QtyProductionX"), xRow)
     If  getColumIndex(spr,"QtyProductionXP") > -1 then z4082.QtyProductionXP = getDataM(spr, getColumIndex(spr,"QtyProductionXP"), xRow)
     If  getColumIndex(spr,"QtyProductionXD") > -1 then z4082.QtyProductionXD = getDataM(spr, getColumIndex(spr,"QtyProductionXD"), xRow)
     If  getColumIndex(spr,"QtyOutProduction") > -1 then z4082.QtyOutProduction = getDataM(spr, getColumIndex(spr,"QtyOutProduction"), xRow)
     If  getColumIndex(spr,"ISUD") > -1 then z4082.ISUD = getDataM(spr, getColumIndex(spr,"ISUD"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z4082.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"CheckTrigger") > -1 then z4082.CheckTrigger = getDataM(spr, getColumIndex(spr,"CheckTrigger"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4082.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4082_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K4082_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4082 As T4082_AREA,CheckClear as Boolean,PRODDATE AS String, PRODSEQ AS String, PRODSZNO AS String) as Boolean

K4082_MOVE = False

Try
    If READ_PFK4082(PRODDATE, PRODSEQ, PRODSZNO) = True Then
                z4082 = D4082
		K4082_MOVE = True
		else
	If CheckClear  = True then z4082 = nothing
     End If

     If  getColumIndex(spr,"ProdDate") > -1 then z4082.ProdDate = getDataM(spr, getColumIndex(spr,"ProdDate"), xRow)
     If  getColumIndex(spr,"ProdSeq") > -1 then z4082.ProdSeq = getDataM(spr, getColumIndex(spr,"ProdSeq"), xRow)
     If  getColumIndex(spr,"ProdSzno") > -1 then z4082.ProdSzno = getDataM(spr, getColumIndex(spr,"ProdSzno"), xRow)
     If  getColumIndex(spr,"QtyProduction") > -1 then z4082.QtyProduction = getDataM(spr, getColumIndex(spr,"QtyProduction"), xRow)
     If  getColumIndex(spr,"QtyProductionA") > -1 then z4082.QtyProductionA = getDataM(spr, getColumIndex(spr,"QtyProductionA"), xRow)
     If  getColumIndex(spr,"QtyProductionX") > -1 then z4082.QtyProductionX = getDataM(spr, getColumIndex(spr,"QtyProductionX"), xRow)
     If  getColumIndex(spr,"QtyProductionXP") > -1 then z4082.QtyProductionXP = getDataM(spr, getColumIndex(spr,"QtyProductionXP"), xRow)
     If  getColumIndex(spr,"QtyProductionXD") > -1 then z4082.QtyProductionXD = getDataM(spr, getColumIndex(spr,"QtyProductionXD"), xRow)
     If  getColumIndex(spr,"QtyOutProduction") > -1 then z4082.QtyOutProduction = getDataM(spr, getColumIndex(spr,"QtyOutProduction"), xRow)
     If  getColumIndex(spr,"ISUD") > -1 then z4082.ISUD = getDataM(spr, getColumIndex(spr,"ISUD"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z4082.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"CheckTrigger") > -1 then z4082.CheckTrigger = getDataM(spr, getColumIndex(spr,"CheckTrigger"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4082.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4082_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K4082_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4082 As T4082_AREA, Job as String, PRODDATE AS String, PRODSEQ AS String, PRODSZNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4082_MOVE = False

Try
    If READ_PFK4082(PRODDATE, PRODSEQ, PRODSZNO) = True Then
                z4082 = D4082
		K4082_MOVE = True
		else
	z4082 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4082")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PRODDATE":z4082.ProdDate = Children(i).Code
   Case "PRODSEQ":z4082.ProdSeq = Children(i).Code
   Case "PRODSZNO":z4082.ProdSzno = Children(i).Code
   Case "QTYPRODUCTION":z4082.QtyProduction = Children(i).Code
   Case "QTYPRODUCTIONA":z4082.QtyProductionA = Children(i).Code
   Case "QTYPRODUCTIONX":z4082.QtyProductionX = Children(i).Code
   Case "QTYPRODUCTIONXP":z4082.QtyProductionXP = Children(i).Code
   Case "QTYPRODUCTIONXD":z4082.QtyProductionXD = Children(i).Code
   Case "QTYOUTPRODUCTION":z4082.QtyOutProduction = Children(i).Code
   Case "ISUD":z4082.ISUD = Children(i).Code
   Case "CHECKCOMPLETE":z4082.CheckComplete = Children(i).Code
   Case "CHECKTRIGGER":z4082.CheckTrigger = Children(i).Code
   Case "REMARK":z4082.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PRODDATE":z4082.ProdDate = Children(i).Data
   Case "PRODSEQ":z4082.ProdSeq = Children(i).Data
   Case "PRODSZNO":z4082.ProdSzno = Children(i).Data
   Case "QTYPRODUCTION":z4082.QtyProduction = Children(i).Data
   Case "QTYPRODUCTIONA":z4082.QtyProductionA = Children(i).Data
   Case "QTYPRODUCTIONX":z4082.QtyProductionX = Children(i).Data
   Case "QTYPRODUCTIONXP":z4082.QtyProductionXP = Children(i).Data
   Case "QTYPRODUCTIONXD":z4082.QtyProductionXD = Children(i).Data
   Case "QTYOUTPRODUCTION":z4082.QtyOutProduction = Children(i).Data
   Case "ISUD":z4082.ISUD = Children(i).Data
   Case "CHECKCOMPLETE":z4082.CheckComplete = Children(i).Data
   Case "CHECKTRIGGER":z4082.CheckTrigger = Children(i).Data
   Case "REMARK":z4082.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4082_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K4082_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4082 As T4082_AREA, Job as String, CheckClear as Boolean, PRODDATE AS String, PRODSEQ AS String, PRODSZNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4082_MOVE = False

Try
    If READ_PFK4082(PRODDATE, PRODSEQ, PRODSZNO) = True Then
                z4082 = D4082
		K4082_MOVE = True
		else
	If CheckClear  = True then z4082 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4082")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PRODDATE":z4082.ProdDate = Children(i).Code
   Case "PRODSEQ":z4082.ProdSeq = Children(i).Code
   Case "PRODSZNO":z4082.ProdSzno = Children(i).Code
   Case "QTYPRODUCTION":z4082.QtyProduction = Children(i).Code
   Case "QTYPRODUCTIONA":z4082.QtyProductionA = Children(i).Code
   Case "QTYPRODUCTIONX":z4082.QtyProductionX = Children(i).Code
   Case "QTYPRODUCTIONXP":z4082.QtyProductionXP = Children(i).Code
   Case "QTYPRODUCTIONXD":z4082.QtyProductionXD = Children(i).Code
   Case "QTYOUTPRODUCTION":z4082.QtyOutProduction = Children(i).Code
   Case "ISUD":z4082.ISUD = Children(i).Code
   Case "CHECKCOMPLETE":z4082.CheckComplete = Children(i).Code
   Case "CHECKTRIGGER":z4082.CheckTrigger = Children(i).Code
   Case "REMARK":z4082.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PRODDATE":z4082.ProdDate = Children(i).Data
   Case "PRODSEQ":z4082.ProdSeq = Children(i).Data
   Case "PRODSZNO":z4082.ProdSzno = Children(i).Data
   Case "QTYPRODUCTION":z4082.QtyProduction = Children(i).Data
   Case "QTYPRODUCTIONA":z4082.QtyProductionA = Children(i).Data
   Case "QTYPRODUCTIONX":z4082.QtyProductionX = Children(i).Data
   Case "QTYPRODUCTIONXP":z4082.QtyProductionXP = Children(i).Data
   Case "QTYPRODUCTIONXD":z4082.QtyProductionXD = Children(i).Data
   Case "QTYOUTPRODUCTION":z4082.QtyOutProduction = Children(i).Data
   Case "ISUD":z4082.ISUD = Children(i).Data
   Case "CHECKCOMPLETE":z4082.CheckComplete = Children(i).Data
   Case "CHECKTRIGGER":z4082.CheckTrigger = Children(i).Data
   Case "REMARK":z4082.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4082_MOVE",vbCritical)
End Try
End Function 
    
End Module 
