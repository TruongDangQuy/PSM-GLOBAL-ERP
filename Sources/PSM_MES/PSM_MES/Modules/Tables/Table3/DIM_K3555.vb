'=========================================================================================================================================================
'   TABLE : (PFK3555)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K3555

Structure T3555_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	LABNo	 AS String	'			char(9)		*
Public 	LABNoSeq	 AS String	'			char(3)		*
Public 	TestStatus	 AS String	'			char(1)
Public 	DateInspect	 AS String	'			char(8)
Public 	TimeInspect	 AS String	'			char(14)
Public 	InchargeInspect	 AS String	'			char(6)
Public 	QtyTest	 AS Double	'			decimal
Public 	QtyPass	 AS Double	'			decimal
Public 	QtyFail	 AS Double	'			decimal
Public 	seDefect01	 AS String	'			char(3)
Public 	cdDefect01	 AS String	'			char(3)
Public 	seDefect02	 AS String	'			char(3)
Public 	cdDefect02	 AS String	'			char(3)
Public 	seDefect03	 AS String	'			char(3)
Public 	cdDefect03	 AS String	'			char(3)
Public 	seDefect04	 AS String	'			char(3)
Public 	cdDefect04	 AS String	'			char(3)
Public 	seDefect05	 AS String	'			char(3)
Public 	cdDefect05	 AS String	'			char(3)
Public 	DateInsert	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(6)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(6)
Public 	Remark	 AS String	'			nvarchar(500)
'=========================================================================================================================================================
End structure

Public D3555 As T3555_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK3555(LABNO AS String, LABNOSEQ AS String) As Boolean
    READ_PFK3555 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3555 "
    SQL = SQL & " WHERE K3555_LABNo		 = '" & LABNo & "' " 
    SQL = SQL & "   AND K3555_LABNoSeq		 = '" & LABNoSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D3555_CLEAR: GoTo SKIP_READ_PFK3555
                
    Call K3555_MOVE(rd)
    READ_PFK3555 = True

SKIP_READ_PFK3555:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK3555",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK3555(LABNO AS String, LABNOSEQ AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3555 "
    SQL = SQL & " WHERE K3555_LABNo		 = '" & LABNo & "' " 
    SQL = SQL & "   AND K3555_LABNoSeq		 = '" & LABNoSeq & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK3555",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK3555(z3555 As T3555_AREA) As Boolean
    WRITE_PFK3555 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z3555)
 
    SQL = " INSERT INTO PFK3555 "
    SQL = SQL & " ( "
    SQL = SQL & " K3555_LABNo," 
    SQL = SQL & " K3555_LABNoSeq," 
    SQL = SQL & " K3555_TestStatus," 
    SQL = SQL & " K3555_DateInspect," 
    SQL = SQL & " K3555_TimeInspect," 
    SQL = SQL & " K3555_InchargeInspect," 
    SQL = SQL & " K3555_QtyTest," 
    SQL = SQL & " K3555_QtyPass," 
    SQL = SQL & " K3555_QtyFail," 
    SQL = SQL & " K3555_seDefect01," 
    SQL = SQL & " K3555_cdDefect01," 
    SQL = SQL & " K3555_seDefect02," 
    SQL = SQL & " K3555_cdDefect02," 
    SQL = SQL & " K3555_seDefect03," 
    SQL = SQL & " K3555_cdDefect03," 
    SQL = SQL & " K3555_seDefect04," 
    SQL = SQL & " K3555_cdDefect04," 
    SQL = SQL & " K3555_seDefect05," 
    SQL = SQL & " K3555_cdDefect05," 
    SQL = SQL & " K3555_DateInsert," 
    SQL = SQL & " K3555_InchargeInsert," 
    SQL = SQL & " K3555_DateUpdate," 
    SQL = SQL & " K3555_InchargeUpdate," 
    SQL = SQL & " K3555_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z3555.LABNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3555.LABNoSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3555.TestStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3555.DateInspect) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3555.TimeInspect) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3555.InchargeInspect) & "', "  
    SQL = SQL & "   " & FormatSQL(z3555.QtyTest) & ", "  
    SQL = SQL & "   " & FormatSQL(z3555.QtyPass) & ", "  
    SQL = SQL & "   " & FormatSQL(z3555.QtyFail) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3555.seDefect01) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3555.cdDefect01) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3555.seDefect02) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3555.cdDefect02) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3555.seDefect03) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3555.cdDefect03) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3555.seDefect04) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3555.cdDefect04) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3555.seDefect05) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3555.cdDefect05) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3555.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3555.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3555.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3555.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3555.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK3555 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK3555",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK3555(z3555 As T3555_AREA) As Boolean
    REWRITE_PFK3555 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z3555)
   
    SQL = " UPDATE PFK3555 SET "
    SQL = SQL & "    K3555_TestStatus      = N'" & FormatSQL(z3555.TestStatus) & "', " 
    SQL = SQL & "    K3555_DateInspect      = N'" & FormatSQL(z3555.DateInspect) & "', " 
    SQL = SQL & "    K3555_TimeInspect      = N'" & FormatSQL(z3555.TimeInspect) & "', " 
    SQL = SQL & "    K3555_InchargeInspect      = N'" & FormatSQL(z3555.InchargeInspect) & "', " 
    SQL = SQL & "    K3555_QtyTest      =  " & FormatSQL(z3555.QtyTest) & ", " 
    SQL = SQL & "    K3555_QtyPass      =  " & FormatSQL(z3555.QtyPass) & ", " 
    SQL = SQL & "    K3555_QtyFail      =  " & FormatSQL(z3555.QtyFail) & ", " 
    SQL = SQL & "    K3555_seDefect01      = N'" & FormatSQL(z3555.seDefect01) & "', " 
    SQL = SQL & "    K3555_cdDefect01      = N'" & FormatSQL(z3555.cdDefect01) & "', " 
    SQL = SQL & "    K3555_seDefect02      = N'" & FormatSQL(z3555.seDefect02) & "', " 
    SQL = SQL & "    K3555_cdDefect02      = N'" & FormatSQL(z3555.cdDefect02) & "', " 
    SQL = SQL & "    K3555_seDefect03      = N'" & FormatSQL(z3555.seDefect03) & "', " 
    SQL = SQL & "    K3555_cdDefect03      = N'" & FormatSQL(z3555.cdDefect03) & "', " 
    SQL = SQL & "    K3555_seDefect04      = N'" & FormatSQL(z3555.seDefect04) & "', " 
    SQL = SQL & "    K3555_cdDefect04      = N'" & FormatSQL(z3555.cdDefect04) & "', " 
    SQL = SQL & "    K3555_seDefect05      = N'" & FormatSQL(z3555.seDefect05) & "', " 
    SQL = SQL & "    K3555_cdDefect05      = N'" & FormatSQL(z3555.cdDefect05) & "', " 
    SQL = SQL & "    K3555_DateInsert      = N'" & FormatSQL(z3555.DateInsert) & "', " 
    SQL = SQL & "    K3555_InchargeInsert      = N'" & FormatSQL(z3555.InchargeInsert) & "', " 
    SQL = SQL & "    K3555_DateUpdate      = N'" & FormatSQL(z3555.DateUpdate) & "', " 
    SQL = SQL & "    K3555_InchargeUpdate      = N'" & FormatSQL(z3555.InchargeUpdate) & "', " 
    SQL = SQL & "    K3555_Remark      = N'" & FormatSQL(z3555.Remark) & "'  " 
    SQL = SQL & " WHERE K3555_LABNo		 = '" & z3555.LABNo & "' " 
    SQL = SQL & "   AND K3555_LABNoSeq		 = '" & z3555.LABNoSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK3555 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK3555",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK3555(z3555 As T3555_AREA) As Boolean
    DELETE_PFK3555 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK3555 "
    SQL = SQL & " WHERE K3555_LABNo		 = '" & z3555.LABNo & "' " 
    SQL = SQL & "   AND K3555_LABNoSeq		 = '" & z3555.LABNoSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK3555 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK3555",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D3555_CLEAR()
Try
    
   D3555.LABNo = ""
   D3555.LABNoSeq = ""
   D3555.TestStatus = ""
   D3555.DateInspect = ""
   D3555.TimeInspect = ""
   D3555.InchargeInspect = ""
    D3555.QtyTest = 0 
    D3555.QtyPass = 0 
    D3555.QtyFail = 0 
   D3555.seDefect01 = ""
   D3555.cdDefect01 = ""
   D3555.seDefect02 = ""
   D3555.cdDefect02 = ""
   D3555.seDefect03 = ""
   D3555.cdDefect03 = ""
   D3555.seDefect04 = ""
   D3555.cdDefect04 = ""
   D3555.seDefect05 = ""
   D3555.cdDefect05 = ""
   D3555.DateInsert = ""
   D3555.InchargeInsert = ""
   D3555.DateUpdate = ""
   D3555.InchargeUpdate = ""
   D3555.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D3555_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x3555 As T3555_AREA)
Try
    
    x3555.LABNo = trim$(  x3555.LABNo)
    x3555.LABNoSeq = trim$(  x3555.LABNoSeq)
    x3555.TestStatus = trim$(  x3555.TestStatus)
    x3555.DateInspect = trim$(  x3555.DateInspect)
    x3555.TimeInspect = trim$(  x3555.TimeInspect)
    x3555.InchargeInspect = trim$(  x3555.InchargeInspect)
    x3555.QtyTest = trim$(  x3555.QtyTest)
    x3555.QtyPass = trim$(  x3555.QtyPass)
    x3555.QtyFail = trim$(  x3555.QtyFail)
    x3555.seDefect01 = trim$(  x3555.seDefect01)
    x3555.cdDefect01 = trim$(  x3555.cdDefect01)
    x3555.seDefect02 = trim$(  x3555.seDefect02)
    x3555.cdDefect02 = trim$(  x3555.cdDefect02)
    x3555.seDefect03 = trim$(  x3555.seDefect03)
    x3555.cdDefect03 = trim$(  x3555.cdDefect03)
    x3555.seDefect04 = trim$(  x3555.seDefect04)
    x3555.cdDefect04 = trim$(  x3555.cdDefect04)
    x3555.seDefect05 = trim$(  x3555.seDefect05)
    x3555.cdDefect05 = trim$(  x3555.cdDefect05)
    x3555.DateInsert = trim$(  x3555.DateInsert)
    x3555.InchargeInsert = trim$(  x3555.InchargeInsert)
    x3555.DateUpdate = trim$(  x3555.DateUpdate)
    x3555.InchargeUpdate = trim$(  x3555.InchargeUpdate)
    x3555.Remark = trim$(  x3555.Remark)
     
    If trim$( x3555.LABNo ) = "" Then x3555.LABNo = Space(1) 
    If trim$( x3555.LABNoSeq ) = "" Then x3555.LABNoSeq = Space(1) 
    If trim$( x3555.TestStatus ) = "" Then x3555.TestStatus = Space(1) 
    If trim$( x3555.DateInspect ) = "" Then x3555.DateInspect = Space(1) 
    If trim$( x3555.TimeInspect ) = "" Then x3555.TimeInspect = Space(1) 
    If trim$( x3555.InchargeInspect ) = "" Then x3555.InchargeInspect = Space(1) 
    If trim$( x3555.QtyTest ) = "" Then x3555.QtyTest = 0 
    If trim$( x3555.QtyPass ) = "" Then x3555.QtyPass = 0 
    If trim$( x3555.QtyFail ) = "" Then x3555.QtyFail = 0 
    If trim$( x3555.seDefect01 ) = "" Then x3555.seDefect01 = Space(1) 
    If trim$( x3555.cdDefect01 ) = "" Then x3555.cdDefect01 = Space(1) 
    If trim$( x3555.seDefect02 ) = "" Then x3555.seDefect02 = Space(1) 
    If trim$( x3555.cdDefect02 ) = "" Then x3555.cdDefect02 = Space(1) 
    If trim$( x3555.seDefect03 ) = "" Then x3555.seDefect03 = Space(1) 
    If trim$( x3555.cdDefect03 ) = "" Then x3555.cdDefect03 = Space(1) 
    If trim$( x3555.seDefect04 ) = "" Then x3555.seDefect04 = Space(1) 
    If trim$( x3555.cdDefect04 ) = "" Then x3555.cdDefect04 = Space(1) 
    If trim$( x3555.seDefect05 ) = "" Then x3555.seDefect05 = Space(1) 
    If trim$( x3555.cdDefect05 ) = "" Then x3555.cdDefect05 = Space(1) 
    If trim$( x3555.DateInsert ) = "" Then x3555.DateInsert = Space(1) 
    If trim$( x3555.InchargeInsert ) = "" Then x3555.InchargeInsert = Space(1) 
    If trim$( x3555.DateUpdate ) = "" Then x3555.DateUpdate = Space(1) 
    If trim$( x3555.InchargeUpdate ) = "" Then x3555.InchargeUpdate = Space(1) 
    If trim$( x3555.Remark ) = "" Then x3555.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K3555_MOVE(rs3555 As SqlClient.SqlDataReader)
Try

    call D3555_CLEAR()   

    If IsdbNull(rs3555!K3555_LABNo) = False Then D3555.LABNo = Trim$(rs3555!K3555_LABNo)
    If IsdbNull(rs3555!K3555_LABNoSeq) = False Then D3555.LABNoSeq = Trim$(rs3555!K3555_LABNoSeq)
    If IsdbNull(rs3555!K3555_TestStatus) = False Then D3555.TestStatus = Trim$(rs3555!K3555_TestStatus)
    If IsdbNull(rs3555!K3555_DateInspect) = False Then D3555.DateInspect = Trim$(rs3555!K3555_DateInspect)
    If IsdbNull(rs3555!K3555_TimeInspect) = False Then D3555.TimeInspect = Trim$(rs3555!K3555_TimeInspect)
    If IsdbNull(rs3555!K3555_InchargeInspect) = False Then D3555.InchargeInspect = Trim$(rs3555!K3555_InchargeInspect)
    If IsdbNull(rs3555!K3555_QtyTest) = False Then D3555.QtyTest = Trim$(rs3555!K3555_QtyTest)
    If IsdbNull(rs3555!K3555_QtyPass) = False Then D3555.QtyPass = Trim$(rs3555!K3555_QtyPass)
    If IsdbNull(rs3555!K3555_QtyFail) = False Then D3555.QtyFail = Trim$(rs3555!K3555_QtyFail)
    If IsdbNull(rs3555!K3555_seDefect01) = False Then D3555.seDefect01 = Trim$(rs3555!K3555_seDefect01)
    If IsdbNull(rs3555!K3555_cdDefect01) = False Then D3555.cdDefect01 = Trim$(rs3555!K3555_cdDefect01)
    If IsdbNull(rs3555!K3555_seDefect02) = False Then D3555.seDefect02 = Trim$(rs3555!K3555_seDefect02)
    If IsdbNull(rs3555!K3555_cdDefect02) = False Then D3555.cdDefect02 = Trim$(rs3555!K3555_cdDefect02)
    If IsdbNull(rs3555!K3555_seDefect03) = False Then D3555.seDefect03 = Trim$(rs3555!K3555_seDefect03)
    If IsdbNull(rs3555!K3555_cdDefect03) = False Then D3555.cdDefect03 = Trim$(rs3555!K3555_cdDefect03)
    If IsdbNull(rs3555!K3555_seDefect04) = False Then D3555.seDefect04 = Trim$(rs3555!K3555_seDefect04)
    If IsdbNull(rs3555!K3555_cdDefect04) = False Then D3555.cdDefect04 = Trim$(rs3555!K3555_cdDefect04)
    If IsdbNull(rs3555!K3555_seDefect05) = False Then D3555.seDefect05 = Trim$(rs3555!K3555_seDefect05)
    If IsdbNull(rs3555!K3555_cdDefect05) = False Then D3555.cdDefect05 = Trim$(rs3555!K3555_cdDefect05)
    If IsdbNull(rs3555!K3555_DateInsert) = False Then D3555.DateInsert = Trim$(rs3555!K3555_DateInsert)
    If IsdbNull(rs3555!K3555_InchargeInsert) = False Then D3555.InchargeInsert = Trim$(rs3555!K3555_InchargeInsert)
    If IsdbNull(rs3555!K3555_DateUpdate) = False Then D3555.DateUpdate = Trim$(rs3555!K3555_DateUpdate)
    If IsdbNull(rs3555!K3555_InchargeUpdate) = False Then D3555.InchargeUpdate = Trim$(rs3555!K3555_InchargeUpdate)
    If IsdbNull(rs3555!K3555_Remark) = False Then D3555.Remark = Trim$(rs3555!K3555_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3555_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K3555_MOVE(rs3555 As DataRow)
Try

    call D3555_CLEAR()   

    If IsdbNull(rs3555!K3555_LABNo) = False Then D3555.LABNo = Trim$(rs3555!K3555_LABNo)
    If IsdbNull(rs3555!K3555_LABNoSeq) = False Then D3555.LABNoSeq = Trim$(rs3555!K3555_LABNoSeq)
    If IsdbNull(rs3555!K3555_TestStatus) = False Then D3555.TestStatus = Trim$(rs3555!K3555_TestStatus)
    If IsdbNull(rs3555!K3555_DateInspect) = False Then D3555.DateInspect = Trim$(rs3555!K3555_DateInspect)
    If IsdbNull(rs3555!K3555_TimeInspect) = False Then D3555.TimeInspect = Trim$(rs3555!K3555_TimeInspect)
    If IsdbNull(rs3555!K3555_InchargeInspect) = False Then D3555.InchargeInspect = Trim$(rs3555!K3555_InchargeInspect)
    If IsdbNull(rs3555!K3555_QtyTest) = False Then D3555.QtyTest = Trim$(rs3555!K3555_QtyTest)
    If IsdbNull(rs3555!K3555_QtyPass) = False Then D3555.QtyPass = Trim$(rs3555!K3555_QtyPass)
    If IsdbNull(rs3555!K3555_QtyFail) = False Then D3555.QtyFail = Trim$(rs3555!K3555_QtyFail)
    If IsdbNull(rs3555!K3555_seDefect01) = False Then D3555.seDefect01 = Trim$(rs3555!K3555_seDefect01)
    If IsdbNull(rs3555!K3555_cdDefect01) = False Then D3555.cdDefect01 = Trim$(rs3555!K3555_cdDefect01)
    If IsdbNull(rs3555!K3555_seDefect02) = False Then D3555.seDefect02 = Trim$(rs3555!K3555_seDefect02)
    If IsdbNull(rs3555!K3555_cdDefect02) = False Then D3555.cdDefect02 = Trim$(rs3555!K3555_cdDefect02)
    If IsdbNull(rs3555!K3555_seDefect03) = False Then D3555.seDefect03 = Trim$(rs3555!K3555_seDefect03)
    If IsdbNull(rs3555!K3555_cdDefect03) = False Then D3555.cdDefect03 = Trim$(rs3555!K3555_cdDefect03)
    If IsdbNull(rs3555!K3555_seDefect04) = False Then D3555.seDefect04 = Trim$(rs3555!K3555_seDefect04)
    If IsdbNull(rs3555!K3555_cdDefect04) = False Then D3555.cdDefect04 = Trim$(rs3555!K3555_cdDefect04)
    If IsdbNull(rs3555!K3555_seDefect05) = False Then D3555.seDefect05 = Trim$(rs3555!K3555_seDefect05)
    If IsdbNull(rs3555!K3555_cdDefect05) = False Then D3555.cdDefect05 = Trim$(rs3555!K3555_cdDefect05)
    If IsdbNull(rs3555!K3555_DateInsert) = False Then D3555.DateInsert = Trim$(rs3555!K3555_DateInsert)
    If IsdbNull(rs3555!K3555_InchargeInsert) = False Then D3555.InchargeInsert = Trim$(rs3555!K3555_InchargeInsert)
    If IsdbNull(rs3555!K3555_DateUpdate) = False Then D3555.DateUpdate = Trim$(rs3555!K3555_DateUpdate)
    If IsdbNull(rs3555!K3555_InchargeUpdate) = False Then D3555.InchargeUpdate = Trim$(rs3555!K3555_InchargeUpdate)
    If IsdbNull(rs3555!K3555_Remark) = False Then D3555.Remark = Trim$(rs3555!K3555_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3555_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K3555_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3555 As T3555_AREA, LABNO AS String, LABNOSEQ AS String) as Boolean

K3555_MOVE = False

Try
    If READ_PFK3555(LABNO, LABNOSEQ) = True Then
                z3555 = D3555
		K3555_MOVE = True
		else
	z3555 = nothing
     End If

     If  getColumIndex(spr,"LABNo") > -1 then z3555.LABNo = getDataM(spr, getColumIndex(spr,"LABNo"), xRow)
     If  getColumIndex(spr,"LABNoSeq") > -1 then z3555.LABNoSeq = getDataM(spr, getColumIndex(spr,"LABNoSeq"), xRow)
     If  getColumIndex(spr,"TestStatus") > -1 then z3555.TestStatus = getDataM(spr, getColumIndex(spr,"TestStatus"), xRow)
     If  getColumIndex(spr,"DateInspect") > -1 then z3555.DateInspect = getDataM(spr, getColumIndex(spr,"DateInspect"), xRow)
     If  getColumIndex(spr,"TimeInspect") > -1 then z3555.TimeInspect = getDataM(spr, getColumIndex(spr,"TimeInspect"), xRow)
     If  getColumIndex(spr,"InchargeInspect") > -1 then z3555.InchargeInspect = getDataM(spr, getColumIndex(spr,"InchargeInspect"), xRow)
     If  getColumIndex(spr,"QtyTest") > -1 then z3555.QtyTest = getDataM(spr, getColumIndex(spr,"QtyTest"), xRow)
     If  getColumIndex(spr,"QtyPass") > -1 then z3555.QtyPass = getDataM(spr, getColumIndex(spr,"QtyPass"), xRow)
     If  getColumIndex(spr,"QtyFail") > -1 then z3555.QtyFail = getDataM(spr, getColumIndex(spr,"QtyFail"), xRow)
     If  getColumIndex(spr,"seDefect01") > -1 then z3555.seDefect01 = getDataM(spr, getColumIndex(spr,"seDefect01"), xRow)
     If  getColumIndex(spr,"cdDefect01") > -1 then z3555.cdDefect01 = getDataM(spr, getColumIndex(spr,"cdDefect01"), xRow)
     If  getColumIndex(spr,"seDefect02") > -1 then z3555.seDefect02 = getDataM(spr, getColumIndex(spr,"seDefect02"), xRow)
     If  getColumIndex(spr,"cdDefect02") > -1 then z3555.cdDefect02 = getDataM(spr, getColumIndex(spr,"cdDefect02"), xRow)
     If  getColumIndex(spr,"seDefect03") > -1 then z3555.seDefect03 = getDataM(spr, getColumIndex(spr,"seDefect03"), xRow)
     If  getColumIndex(spr,"cdDefect03") > -1 then z3555.cdDefect03 = getDataM(spr, getColumIndex(spr,"cdDefect03"), xRow)
     If  getColumIndex(spr,"seDefect04") > -1 then z3555.seDefect04 = getDataM(spr, getColumIndex(spr,"seDefect04"), xRow)
     If  getColumIndex(spr,"cdDefect04") > -1 then z3555.cdDefect04 = getDataM(spr, getColumIndex(spr,"cdDefect04"), xRow)
     If  getColumIndex(spr,"seDefect05") > -1 then z3555.seDefect05 = getDataM(spr, getColumIndex(spr,"seDefect05"), xRow)
     If  getColumIndex(spr,"cdDefect05") > -1 then z3555.cdDefect05 = getDataM(spr, getColumIndex(spr,"cdDefect05"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z3555.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z3555.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z3555.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z3555.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z3555.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3555_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K3555_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3555 As T3555_AREA,CheckClear as Boolean,LABNO AS String, LABNOSEQ AS String) as Boolean

K3555_MOVE = False

Try
    If READ_PFK3555(LABNO, LABNOSEQ) = True Then
                z3555 = D3555
		K3555_MOVE = True
		else
	If CheckClear  = True then z3555 = nothing
     End If

     If  getColumIndex(spr,"LABNo") > -1 then z3555.LABNo = getDataM(spr, getColumIndex(spr,"LABNo"), xRow)
     If  getColumIndex(spr,"LABNoSeq") > -1 then z3555.LABNoSeq = getDataM(spr, getColumIndex(spr,"LABNoSeq"), xRow)
     If  getColumIndex(spr,"TestStatus") > -1 then z3555.TestStatus = getDataM(spr, getColumIndex(spr,"TestStatus"), xRow)
     If  getColumIndex(spr,"DateInspect") > -1 then z3555.DateInspect = getDataM(spr, getColumIndex(spr,"DateInspect"), xRow)
     If  getColumIndex(spr,"TimeInspect") > -1 then z3555.TimeInspect = getDataM(spr, getColumIndex(spr,"TimeInspect"), xRow)
     If  getColumIndex(spr,"InchargeInspect") > -1 then z3555.InchargeInspect = getDataM(spr, getColumIndex(spr,"InchargeInspect"), xRow)
     If  getColumIndex(spr,"QtyTest") > -1 then z3555.QtyTest = getDataM(spr, getColumIndex(spr,"QtyTest"), xRow)
     If  getColumIndex(spr,"QtyPass") > -1 then z3555.QtyPass = getDataM(spr, getColumIndex(spr,"QtyPass"), xRow)
     If  getColumIndex(spr,"QtyFail") > -1 then z3555.QtyFail = getDataM(spr, getColumIndex(spr,"QtyFail"), xRow)
     If  getColumIndex(spr,"seDefect01") > -1 then z3555.seDefect01 = getDataM(spr, getColumIndex(spr,"seDefect01"), xRow)
     If  getColumIndex(spr,"cdDefect01") > -1 then z3555.cdDefect01 = getDataM(spr, getColumIndex(spr,"cdDefect01"), xRow)
     If  getColumIndex(spr,"seDefect02") > -1 then z3555.seDefect02 = getDataM(spr, getColumIndex(spr,"seDefect02"), xRow)
     If  getColumIndex(spr,"cdDefect02") > -1 then z3555.cdDefect02 = getDataM(spr, getColumIndex(spr,"cdDefect02"), xRow)
     If  getColumIndex(spr,"seDefect03") > -1 then z3555.seDefect03 = getDataM(spr, getColumIndex(spr,"seDefect03"), xRow)
     If  getColumIndex(spr,"cdDefect03") > -1 then z3555.cdDefect03 = getDataM(spr, getColumIndex(spr,"cdDefect03"), xRow)
     If  getColumIndex(spr,"seDefect04") > -1 then z3555.seDefect04 = getDataM(spr, getColumIndex(spr,"seDefect04"), xRow)
     If  getColumIndex(spr,"cdDefect04") > -1 then z3555.cdDefect04 = getDataM(spr, getColumIndex(spr,"cdDefect04"), xRow)
     If  getColumIndex(spr,"seDefect05") > -1 then z3555.seDefect05 = getDataM(spr, getColumIndex(spr,"seDefect05"), xRow)
     If  getColumIndex(spr,"cdDefect05") > -1 then z3555.cdDefect05 = getDataM(spr, getColumIndex(spr,"cdDefect05"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z3555.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z3555.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z3555.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z3555.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z3555.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3555_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K3555_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3555 As T3555_AREA, Job as String, LABNO AS String, LABNOSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3555_MOVE = False

Try
    If READ_PFK3555(LABNO, LABNOSEQ) = True Then
                z3555 = D3555
		K3555_MOVE = True
		else
	z3555 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3555")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "LABNO":z3555.LABNo = Children(i).Code
   Case "LABNOSEQ":z3555.LABNoSeq = Children(i).Code
   Case "TESTSTATUS":z3555.TestStatus = Children(i).Code
   Case "DATEINSPECT":z3555.DateInspect = Children(i).Code
   Case "TIMEINSPECT":z3555.TimeInspect = Children(i).Code
   Case "INCHARGEINSPECT":z3555.InchargeInspect = Children(i).Code
   Case "QTYTEST":z3555.QtyTest = Children(i).Code
   Case "QTYPASS":z3555.QtyPass = Children(i).Code
   Case "QTYFAIL":z3555.QtyFail = Children(i).Code
   Case "SEDEFECT01":z3555.seDefect01 = Children(i).Code
   Case "CDDEFECT01":z3555.cdDefect01 = Children(i).Code
   Case "SEDEFECT02":z3555.seDefect02 = Children(i).Code
   Case "CDDEFECT02":z3555.cdDefect02 = Children(i).Code
   Case "SEDEFECT03":z3555.seDefect03 = Children(i).Code
   Case "CDDEFECT03":z3555.cdDefect03 = Children(i).Code
   Case "SEDEFECT04":z3555.seDefect04 = Children(i).Code
   Case "CDDEFECT04":z3555.cdDefect04 = Children(i).Code
   Case "SEDEFECT05":z3555.seDefect05 = Children(i).Code
   Case "CDDEFECT05":z3555.cdDefect05 = Children(i).Code
   Case "DATEINSERT":z3555.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z3555.InchargeInsert = Children(i).Code
   Case "DATEUPDATE":z3555.DateUpdate = Children(i).Code
   Case "INCHARGEUPDATE":z3555.InchargeUpdate = Children(i).Code
   Case "REMARK":z3555.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "LABNO":z3555.LABNo = Children(i).Data
   Case "LABNOSEQ":z3555.LABNoSeq = Children(i).Data
   Case "TESTSTATUS":z3555.TestStatus = Children(i).Data
   Case "DATEINSPECT":z3555.DateInspect = Children(i).Data
   Case "TIMEINSPECT":z3555.TimeInspect = Children(i).Data
   Case "INCHARGEINSPECT":z3555.InchargeInspect = Children(i).Data
   Case "QTYTEST":z3555.QtyTest = Children(i).Data
   Case "QTYPASS":z3555.QtyPass = Children(i).Data
   Case "QTYFAIL":z3555.QtyFail = Children(i).Data
   Case "SEDEFECT01":z3555.seDefect01 = Children(i).Data
   Case "CDDEFECT01":z3555.cdDefect01 = Children(i).Data
   Case "SEDEFECT02":z3555.seDefect02 = Children(i).Data
   Case "CDDEFECT02":z3555.cdDefect02 = Children(i).Data
   Case "SEDEFECT03":z3555.seDefect03 = Children(i).Data
   Case "CDDEFECT03":z3555.cdDefect03 = Children(i).Data
   Case "SEDEFECT04":z3555.seDefect04 = Children(i).Data
   Case "CDDEFECT04":z3555.cdDefect04 = Children(i).Data
   Case "SEDEFECT05":z3555.seDefect05 = Children(i).Data
   Case "CDDEFECT05":z3555.cdDefect05 = Children(i).Data
   Case "DATEINSERT":z3555.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z3555.InchargeInsert = Children(i).Data
   Case "DATEUPDATE":z3555.DateUpdate = Children(i).Data
   Case "INCHARGEUPDATE":z3555.InchargeUpdate = Children(i).Data
   Case "REMARK":z3555.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3555_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K3555_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3555 As T3555_AREA, Job as String, CheckClear as Boolean, LABNO AS String, LABNOSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3555_MOVE = False

Try
    If READ_PFK3555(LABNO, LABNOSEQ) = True Then
                z3555 = D3555
		K3555_MOVE = True
		else
	If CheckClear  = True then z3555 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3555")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "LABNO":z3555.LABNo = Children(i).Code
   Case "LABNOSEQ":z3555.LABNoSeq = Children(i).Code
   Case "TESTSTATUS":z3555.TestStatus = Children(i).Code
   Case "DATEINSPECT":z3555.DateInspect = Children(i).Code
   Case "TIMEINSPECT":z3555.TimeInspect = Children(i).Code
   Case "INCHARGEINSPECT":z3555.InchargeInspect = Children(i).Code
   Case "QTYTEST":z3555.QtyTest = Children(i).Code
   Case "QTYPASS":z3555.QtyPass = Children(i).Code
   Case "QTYFAIL":z3555.QtyFail = Children(i).Code
   Case "SEDEFECT01":z3555.seDefect01 = Children(i).Code
   Case "CDDEFECT01":z3555.cdDefect01 = Children(i).Code
   Case "SEDEFECT02":z3555.seDefect02 = Children(i).Code
   Case "CDDEFECT02":z3555.cdDefect02 = Children(i).Code
   Case "SEDEFECT03":z3555.seDefect03 = Children(i).Code
   Case "CDDEFECT03":z3555.cdDefect03 = Children(i).Code
   Case "SEDEFECT04":z3555.seDefect04 = Children(i).Code
   Case "CDDEFECT04":z3555.cdDefect04 = Children(i).Code
   Case "SEDEFECT05":z3555.seDefect05 = Children(i).Code
   Case "CDDEFECT05":z3555.cdDefect05 = Children(i).Code
   Case "DATEINSERT":z3555.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z3555.InchargeInsert = Children(i).Code
   Case "DATEUPDATE":z3555.DateUpdate = Children(i).Code
   Case "INCHARGEUPDATE":z3555.InchargeUpdate = Children(i).Code
   Case "REMARK":z3555.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "LABNO":z3555.LABNo = Children(i).Data
   Case "LABNOSEQ":z3555.LABNoSeq = Children(i).Data
   Case "TESTSTATUS":z3555.TestStatus = Children(i).Data
   Case "DATEINSPECT":z3555.DateInspect = Children(i).Data
   Case "TIMEINSPECT":z3555.TimeInspect = Children(i).Data
   Case "INCHARGEINSPECT":z3555.InchargeInspect = Children(i).Data
   Case "QTYTEST":z3555.QtyTest = Children(i).Data
   Case "QTYPASS":z3555.QtyPass = Children(i).Data
   Case "QTYFAIL":z3555.QtyFail = Children(i).Data
   Case "SEDEFECT01":z3555.seDefect01 = Children(i).Data
   Case "CDDEFECT01":z3555.cdDefect01 = Children(i).Data
   Case "SEDEFECT02":z3555.seDefect02 = Children(i).Data
   Case "CDDEFECT02":z3555.cdDefect02 = Children(i).Data
   Case "SEDEFECT03":z3555.seDefect03 = Children(i).Data
   Case "CDDEFECT03":z3555.cdDefect03 = Children(i).Data
   Case "SEDEFECT04":z3555.seDefect04 = Children(i).Data
   Case "CDDEFECT04":z3555.cdDefect04 = Children(i).Data
   Case "SEDEFECT05":z3555.seDefect05 = Children(i).Data
   Case "CDDEFECT05":z3555.cdDefect05 = Children(i).Data
   Case "DATEINSERT":z3555.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z3555.InchargeInsert = Children(i).Data
   Case "DATEUPDATE":z3555.DateUpdate = Children(i).Data
   Case "INCHARGEUPDATE":z3555.InchargeUpdate = Children(i).Data
   Case "REMARK":z3555.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3555_MOVE",vbCritical)
End Try
End Function 
    
End Module 
