'=========================================================================================================================================================
'   TABLE : (PFK2354)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K2354

Structure T2354_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	MaterialInBoundNo	 AS String	'			char(9)		*
Public 	MaterialInBoundSeq	 AS String	'			char(3)		*
Public 	MaterialInBoundQno	 AS Double	'			decimal		*
Public 	MaterialInBoundSno	 AS Double	'			decimal
Public 	MaterialInBoundDseq	 AS Double	'			decimal
Public 	PackInBound	 AS Double	'			decimal
Public 	QtyInBound	 AS Double	'			decimal
Public 	PackQC	 AS Double	'			decimal
Public 	QtyQC	 AS Double	'			decimal
Public 	seDefectMaterial	 AS String	'			char(3)
Public 	cdDefectMaterial	 AS String	'			char(3)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	Grade	 AS String	'			char(1)
Public 	CheckComplete	 AS String	'			char(1)
Public 	InchargeQC	 AS String	'			char(8)
Public 	CheckQC	 AS String	'			char(1)
Public 	TimeQC	 AS String	'			nvarchar(20)
Public 	Remark	 AS String	'			nvarchar(100)
'=========================================================================================================================================================
End structure

Public D2354 As T2354_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK2354(MATERIALINBOUNDNO AS String, MATERIALINBOUNDSEQ AS String, MATERIALINBOUNDQNO AS Double) As Boolean
    READ_PFK2354 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK2354 "
    SQL = SQL & " WHERE K2354_MaterialInBoundNo		 = '" & MaterialInBoundNo & "' " 
    SQL = SQL & "   AND K2354_MaterialInBoundSeq		 = '" & MaterialInBoundSeq & "' " 
    SQL = SQL & "   AND K2354_MaterialInBoundQno		 =  " & MaterialInBoundQno & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D2354_CLEAR: GoTo SKIP_READ_PFK2354
                
    Call K2354_MOVE(rd)
    READ_PFK2354 = True

SKIP_READ_PFK2354:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK2354",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK2354(MATERIALINBOUNDNO AS String, MATERIALINBOUNDSEQ AS String, MATERIALINBOUNDQNO AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK2354 "
    SQL = SQL & " WHERE K2354_MaterialInBoundNo		 = '" & MaterialInBoundNo & "' " 
    SQL = SQL & "   AND K2354_MaterialInBoundSeq		 = '" & MaterialInBoundSeq & "' " 
    SQL = SQL & "   AND K2354_MaterialInBoundQno		 =  " & MaterialInBoundQno & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK2354",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK2354(z2354 As T2354_AREA) As Boolean
    WRITE_PFK2354 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z2354)
 
    SQL = " INSERT INTO PFK2354 "
    SQL = SQL & " ( "
    SQL = SQL & " K2354_MaterialInBoundNo," 
    SQL = SQL & " K2354_MaterialInBoundSeq," 
    SQL = SQL & " K2354_MaterialInBoundQno," 
    SQL = SQL & " K2354_MaterialInBoundSno," 
    SQL = SQL & " K2354_MaterialInBoundDseq," 
    SQL = SQL & " K2354_PackInBound," 
    SQL = SQL & " K2354_QtyInBound," 
    SQL = SQL & " K2354_PackQC," 
    SQL = SQL & " K2354_QtyQC," 
    SQL = SQL & " K2354_seDefectMaterial," 
    SQL = SQL & " K2354_cdDefectMaterial," 
    SQL = SQL & " K2354_DateInsert," 
    SQL = SQL & " K2354_DateUpdate," 
    SQL = SQL & " K2354_InchargeInsert," 
    SQL = SQL & " K2354_InchargeUpdate," 
    SQL = SQL & " K2354_Grade," 
    SQL = SQL & " K2354_CheckComplete," 
    SQL = SQL & " K2354_InchargeQC," 
    SQL = SQL & " K2354_CheckQC," 
    SQL = SQL & " K2354_TimeQC," 
    SQL = SQL & " K2354_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z2354.MaterialInBoundNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2354.MaterialInBoundSeq) & "', "  
    SQL = SQL & "   " & FormatSQL(z2354.MaterialInBoundQno) & ", "  
    SQL = SQL & "   " & FormatSQL(z2354.MaterialInBoundSno) & ", "  
    SQL = SQL & "   " & FormatSQL(z2354.MaterialInBoundDseq) & ", "  
    SQL = SQL & "   " & FormatSQL(z2354.PackInBound) & ", "  
    SQL = SQL & "   " & FormatSQL(z2354.QtyInBound) & ", "  
    SQL = SQL & "   " & FormatSQL(z2354.PackQC) & ", "  
    SQL = SQL & "   " & FormatSQL(z2354.QtyQC) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z2354.seDefectMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2354.cdDefectMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2354.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2354.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2354.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2354.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2354.Grade) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2354.CheckComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2354.InchargeQC) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2354.CheckQC) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2354.TimeQC) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2354.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK2354 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK2354",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK2354(z2354 As T2354_AREA) As Boolean
    REWRITE_PFK2354 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z2354)
   
    SQL = " UPDATE PFK2354 SET "
    SQL = SQL & "    K2354_MaterialInBoundSno      =  " & FormatSQL(z2354.MaterialInBoundSno) & ", " 
    SQL = SQL & "    K2354_MaterialInBoundDseq      =  " & FormatSQL(z2354.MaterialInBoundDseq) & ", " 
    SQL = SQL & "    K2354_PackInBound      =  " & FormatSQL(z2354.PackInBound) & ", " 
    SQL = SQL & "    K2354_QtyInBound      =  " & FormatSQL(z2354.QtyInBound) & ", " 
    SQL = SQL & "    K2354_PackQC      =  " & FormatSQL(z2354.PackQC) & ", " 
    SQL = SQL & "    K2354_QtyQC      =  " & FormatSQL(z2354.QtyQC) & ", " 
    SQL = SQL & "    K2354_seDefectMaterial      = N'" & FormatSQL(z2354.seDefectMaterial) & "', " 
    SQL = SQL & "    K2354_cdDefectMaterial      = N'" & FormatSQL(z2354.cdDefectMaterial) & "', " 
    SQL = SQL & "    K2354_DateInsert      = N'" & FormatSQL(z2354.DateInsert) & "', " 
    SQL = SQL & "    K2354_DateUpdate      = N'" & FormatSQL(z2354.DateUpdate) & "', " 
    SQL = SQL & "    K2354_InchargeInsert      = N'" & FormatSQL(z2354.InchargeInsert) & "', " 
    SQL = SQL & "    K2354_InchargeUpdate      = N'" & FormatSQL(z2354.InchargeUpdate) & "', " 
    SQL = SQL & "    K2354_Grade      = N'" & FormatSQL(z2354.Grade) & "', " 
    SQL = SQL & "    K2354_CheckComplete      = N'" & FormatSQL(z2354.CheckComplete) & "', " 
    SQL = SQL & "    K2354_InchargeQC      = N'" & FormatSQL(z2354.InchargeQC) & "', " 
    SQL = SQL & "    K2354_CheckQC      = N'" & FormatSQL(z2354.CheckQC) & "', " 
    SQL = SQL & "    K2354_TimeQC      = N'" & FormatSQL(z2354.TimeQC) & "', " 
    SQL = SQL & "    K2354_Remark      = N'" & FormatSQL(z2354.Remark) & "'  " 
    SQL = SQL & " WHERE K2354_MaterialInBoundNo		 = '" & z2354.MaterialInBoundNo & "' " 
    SQL = SQL & "   AND K2354_MaterialInBoundSeq		 = '" & z2354.MaterialInBoundSeq & "' " 
    SQL = SQL & "   AND K2354_MaterialInBoundQno		 =  " & z2354.MaterialInBoundQno & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK2354 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK2354",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK2354(z2354 As T2354_AREA) As Boolean
    DELETE_PFK2354 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK2354 "
    SQL = SQL & " WHERE K2354_MaterialInBoundNo		 = '" & z2354.MaterialInBoundNo & "' " 
    SQL = SQL & "   AND K2354_MaterialInBoundSeq		 = '" & z2354.MaterialInBoundSeq & "' " 
    SQL = SQL & "   AND K2354_MaterialInBoundQno		 =  " & z2354.MaterialInBoundQno & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK2354 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK2354",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D2354_CLEAR()
Try
    
   D2354.MaterialInBoundNo = ""
   D2354.MaterialInBoundSeq = ""
    D2354.MaterialInBoundQno = 0 
    D2354.MaterialInBoundSno = 0 
    D2354.MaterialInBoundDseq = 0 
    D2354.PackInBound = 0 
    D2354.QtyInBound = 0 
    D2354.PackQC = 0 
    D2354.QtyQC = 0 
   D2354.seDefectMaterial = ""
   D2354.cdDefectMaterial = ""
   D2354.DateInsert = ""
   D2354.DateUpdate = ""
   D2354.InchargeInsert = ""
   D2354.InchargeUpdate = ""
   D2354.Grade = ""
   D2354.CheckComplete = ""
   D2354.InchargeQC = ""
   D2354.CheckQC = ""
   D2354.TimeQC = ""
   D2354.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D2354_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x2354 As T2354_AREA)
Try
    
    x2354.MaterialInBoundNo = trim$(  x2354.MaterialInBoundNo)
    x2354.MaterialInBoundSeq = trim$(  x2354.MaterialInBoundSeq)
    x2354.MaterialInBoundQno = trim$(  x2354.MaterialInBoundQno)
    x2354.MaterialInBoundSno = trim$(  x2354.MaterialInBoundSno)
    x2354.MaterialInBoundDseq = trim$(  x2354.MaterialInBoundDseq)
    x2354.PackInBound = trim$(  x2354.PackInBound)
    x2354.QtyInBound = trim$(  x2354.QtyInBound)
    x2354.PackQC = trim$(  x2354.PackQC)
    x2354.QtyQC = trim$(  x2354.QtyQC)
    x2354.seDefectMaterial = trim$(  x2354.seDefectMaterial)
    x2354.cdDefectMaterial = trim$(  x2354.cdDefectMaterial)
    x2354.DateInsert = trim$(  x2354.DateInsert)
    x2354.DateUpdate = trim$(  x2354.DateUpdate)
    x2354.InchargeInsert = trim$(  x2354.InchargeInsert)
    x2354.InchargeUpdate = trim$(  x2354.InchargeUpdate)
    x2354.Grade = trim$(  x2354.Grade)
    x2354.CheckComplete = trim$(  x2354.CheckComplete)
    x2354.InchargeQC = trim$(  x2354.InchargeQC)
    x2354.CheckQC = trim$(  x2354.CheckQC)
    x2354.TimeQC = trim$(  x2354.TimeQC)
    x2354.Remark = trim$(  x2354.Remark)
     
    If trim$( x2354.MaterialInBoundNo ) = "" Then x2354.MaterialInBoundNo = Space(1) 
    If trim$( x2354.MaterialInBoundSeq ) = "" Then x2354.MaterialInBoundSeq = Space(1) 
    If trim$( x2354.MaterialInBoundQno ) = "" Then x2354.MaterialInBoundQno = 0 
    If trim$( x2354.MaterialInBoundSno ) = "" Then x2354.MaterialInBoundSno = 0 
    If trim$( x2354.MaterialInBoundDseq ) = "" Then x2354.MaterialInBoundDseq = 0 
    If trim$( x2354.PackInBound ) = "" Then x2354.PackInBound = 0 
    If trim$( x2354.QtyInBound ) = "" Then x2354.QtyInBound = 0 
    If trim$( x2354.PackQC ) = "" Then x2354.PackQC = 0 
    If trim$( x2354.QtyQC ) = "" Then x2354.QtyQC = 0 
    If trim$( x2354.seDefectMaterial ) = "" Then x2354.seDefectMaterial = Space(1) 
    If trim$( x2354.cdDefectMaterial ) = "" Then x2354.cdDefectMaterial = Space(1) 
    If trim$( x2354.DateInsert ) = "" Then x2354.DateInsert = Space(1) 
    If trim$( x2354.DateUpdate ) = "" Then x2354.DateUpdate = Space(1) 
    If trim$( x2354.InchargeInsert ) = "" Then x2354.InchargeInsert = Space(1) 
    If trim$( x2354.InchargeUpdate ) = "" Then x2354.InchargeUpdate = Space(1) 
    If trim$( x2354.Grade ) = "" Then x2354.Grade = Space(1) 
    If trim$( x2354.CheckComplete ) = "" Then x2354.CheckComplete = Space(1) 
    If trim$( x2354.InchargeQC ) = "" Then x2354.InchargeQC = Space(1) 
    If trim$( x2354.CheckQC ) = "" Then x2354.CheckQC = Space(1) 
    If trim$( x2354.TimeQC ) = "" Then x2354.TimeQC = Space(1) 
    If trim$( x2354.Remark ) = "" Then x2354.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K2354_MOVE(rs2354 As SqlClient.SqlDataReader)
Try

    call D2354_CLEAR()   

    If IsdbNull(rs2354!K2354_MaterialInBoundNo) = False Then D2354.MaterialInBoundNo = Trim$(rs2354!K2354_MaterialInBoundNo)
    If IsdbNull(rs2354!K2354_MaterialInBoundSeq) = False Then D2354.MaterialInBoundSeq = Trim$(rs2354!K2354_MaterialInBoundSeq)
    If IsdbNull(rs2354!K2354_MaterialInBoundQno) = False Then D2354.MaterialInBoundQno = Trim$(rs2354!K2354_MaterialInBoundQno)
    If IsdbNull(rs2354!K2354_MaterialInBoundSno) = False Then D2354.MaterialInBoundSno = Trim$(rs2354!K2354_MaterialInBoundSno)
    If IsdbNull(rs2354!K2354_MaterialInBoundDseq) = False Then D2354.MaterialInBoundDseq = Trim$(rs2354!K2354_MaterialInBoundDseq)
    If IsdbNull(rs2354!K2354_PackInBound) = False Then D2354.PackInBound = Trim$(rs2354!K2354_PackInBound)
    If IsdbNull(rs2354!K2354_QtyInBound) = False Then D2354.QtyInBound = Trim$(rs2354!K2354_QtyInBound)
    If IsdbNull(rs2354!K2354_PackQC) = False Then D2354.PackQC = Trim$(rs2354!K2354_PackQC)
    If IsdbNull(rs2354!K2354_QtyQC) = False Then D2354.QtyQC = Trim$(rs2354!K2354_QtyQC)
    If IsdbNull(rs2354!K2354_seDefectMaterial) = False Then D2354.seDefectMaterial = Trim$(rs2354!K2354_seDefectMaterial)
    If IsdbNull(rs2354!K2354_cdDefectMaterial) = False Then D2354.cdDefectMaterial = Trim$(rs2354!K2354_cdDefectMaterial)
    If IsdbNull(rs2354!K2354_DateInsert) = False Then D2354.DateInsert = Trim$(rs2354!K2354_DateInsert)
    If IsdbNull(rs2354!K2354_DateUpdate) = False Then D2354.DateUpdate = Trim$(rs2354!K2354_DateUpdate)
    If IsdbNull(rs2354!K2354_InchargeInsert) = False Then D2354.InchargeInsert = Trim$(rs2354!K2354_InchargeInsert)
    If IsdbNull(rs2354!K2354_InchargeUpdate) = False Then D2354.InchargeUpdate = Trim$(rs2354!K2354_InchargeUpdate)
    If IsdbNull(rs2354!K2354_Grade) = False Then D2354.Grade = Trim$(rs2354!K2354_Grade)
    If IsdbNull(rs2354!K2354_CheckComplete) = False Then D2354.CheckComplete = Trim$(rs2354!K2354_CheckComplete)
    If IsdbNull(rs2354!K2354_InchargeQC) = False Then D2354.InchargeQC = Trim$(rs2354!K2354_InchargeQC)
    If IsdbNull(rs2354!K2354_CheckQC) = False Then D2354.CheckQC = Trim$(rs2354!K2354_CheckQC)
    If IsdbNull(rs2354!K2354_TimeQC) = False Then D2354.TimeQC = Trim$(rs2354!K2354_TimeQC)
    If IsdbNull(rs2354!K2354_Remark) = False Then D2354.Remark = Trim$(rs2354!K2354_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K2354_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K2354_MOVE(rs2354 As DataRow)
Try

    call D2354_CLEAR()   

    If IsdbNull(rs2354!K2354_MaterialInBoundNo) = False Then D2354.MaterialInBoundNo = Trim$(rs2354!K2354_MaterialInBoundNo)
    If IsdbNull(rs2354!K2354_MaterialInBoundSeq) = False Then D2354.MaterialInBoundSeq = Trim$(rs2354!K2354_MaterialInBoundSeq)
    If IsdbNull(rs2354!K2354_MaterialInBoundQno) = False Then D2354.MaterialInBoundQno = Trim$(rs2354!K2354_MaterialInBoundQno)
    If IsdbNull(rs2354!K2354_MaterialInBoundSno) = False Then D2354.MaterialInBoundSno = Trim$(rs2354!K2354_MaterialInBoundSno)
    If IsdbNull(rs2354!K2354_MaterialInBoundDseq) = False Then D2354.MaterialInBoundDseq = Trim$(rs2354!K2354_MaterialInBoundDseq)
    If IsdbNull(rs2354!K2354_PackInBound) = False Then D2354.PackInBound = Trim$(rs2354!K2354_PackInBound)
    If IsdbNull(rs2354!K2354_QtyInBound) = False Then D2354.QtyInBound = Trim$(rs2354!K2354_QtyInBound)
    If IsdbNull(rs2354!K2354_PackQC) = False Then D2354.PackQC = Trim$(rs2354!K2354_PackQC)
    If IsdbNull(rs2354!K2354_QtyQC) = False Then D2354.QtyQC = Trim$(rs2354!K2354_QtyQC)
    If IsdbNull(rs2354!K2354_seDefectMaterial) = False Then D2354.seDefectMaterial = Trim$(rs2354!K2354_seDefectMaterial)
    If IsdbNull(rs2354!K2354_cdDefectMaterial) = False Then D2354.cdDefectMaterial = Trim$(rs2354!K2354_cdDefectMaterial)
    If IsdbNull(rs2354!K2354_DateInsert) = False Then D2354.DateInsert = Trim$(rs2354!K2354_DateInsert)
    If IsdbNull(rs2354!K2354_DateUpdate) = False Then D2354.DateUpdate = Trim$(rs2354!K2354_DateUpdate)
    If IsdbNull(rs2354!K2354_InchargeInsert) = False Then D2354.InchargeInsert = Trim$(rs2354!K2354_InchargeInsert)
    If IsdbNull(rs2354!K2354_InchargeUpdate) = False Then D2354.InchargeUpdate = Trim$(rs2354!K2354_InchargeUpdate)
    If IsdbNull(rs2354!K2354_Grade) = False Then D2354.Grade = Trim$(rs2354!K2354_Grade)
    If IsdbNull(rs2354!K2354_CheckComplete) = False Then D2354.CheckComplete = Trim$(rs2354!K2354_CheckComplete)
    If IsdbNull(rs2354!K2354_InchargeQC) = False Then D2354.InchargeQC = Trim$(rs2354!K2354_InchargeQC)
    If IsdbNull(rs2354!K2354_CheckQC) = False Then D2354.CheckQC = Trim$(rs2354!K2354_CheckQC)
    If IsdbNull(rs2354!K2354_TimeQC) = False Then D2354.TimeQC = Trim$(rs2354!K2354_TimeQC)
    If IsdbNull(rs2354!K2354_Remark) = False Then D2354.Remark = Trim$(rs2354!K2354_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K2354_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K2354_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z2354 As T2354_AREA, MATERIALINBOUNDNO AS String, MATERIALINBOUNDSEQ AS String, MATERIALINBOUNDQNO AS Double) as Boolean

K2354_MOVE = False

Try
    If READ_PFK2354(MATERIALINBOUNDNO, MATERIALINBOUNDSEQ, MATERIALINBOUNDQNO) = True Then
                z2354 = D2354
		K2354_MOVE = True
		else
	z2354 = nothing
     End If

     If  getColumIndex(spr,"MaterialInBoundNo") > -1 then z2354.MaterialInBoundNo = getDataM(spr, getColumIndex(spr,"MaterialInBoundNo"), xRow)
     If  getColumIndex(spr,"MaterialInBoundSeq") > -1 then z2354.MaterialInBoundSeq = getDataM(spr, getColumIndex(spr,"MaterialInBoundSeq"), xRow)
     If  getColumIndex(spr,"MaterialInBoundQno") > -1 then z2354.MaterialInBoundQno = getDataM(spr, getColumIndex(spr,"MaterialInBoundQno"), xRow)
     If  getColumIndex(spr,"MaterialInBoundSno") > -1 then z2354.MaterialInBoundSno = getDataM(spr, getColumIndex(spr,"MaterialInBoundSno"), xRow)
     If  getColumIndex(spr,"MaterialInBoundDseq") > -1 then z2354.MaterialInBoundDseq = getDataM(spr, getColumIndex(spr,"MaterialInBoundDseq"), xRow)
     If  getColumIndex(spr,"PackInBound") > -1 then z2354.PackInBound = getDataM(spr, getColumIndex(spr,"PackInBound"), xRow)
     If  getColumIndex(spr,"QtyInBound") > -1 then z2354.QtyInBound = getDataM(spr, getColumIndex(spr,"QtyInBound"), xRow)
     If  getColumIndex(spr,"PackQC") > -1 then z2354.PackQC = getDataM(spr, getColumIndex(spr,"PackQC"), xRow)
     If  getColumIndex(spr,"QtyQC") > -1 then z2354.QtyQC = getDataM(spr, getColumIndex(spr,"QtyQC"), xRow)
     If  getColumIndex(spr,"seDefectMaterial") > -1 then z2354.seDefectMaterial = getDataM(spr, getColumIndex(spr,"seDefectMaterial"), xRow)
     If  getColumIndex(spr,"cdDefectMaterial") > -1 then z2354.cdDefectMaterial = getDataM(spr, getColumIndex(spr,"cdDefectMaterial"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z2354.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z2354.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z2354.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z2354.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"Grade") > -1 then z2354.Grade = getDataM(spr, getColumIndex(spr,"Grade"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z2354.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"InchargeQC") > -1 then z2354.InchargeQC = getDataM(spr, getColumIndex(spr,"InchargeQC"), xRow)
     If  getColumIndex(spr,"CheckQC") > -1 then z2354.CheckQC = getDataM(spr, getColumIndex(spr,"CheckQC"), xRow)
     If  getColumIndex(spr,"TimeQC") > -1 then z2354.TimeQC = getDataM(spr, getColumIndex(spr,"TimeQC"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z2354.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K2354_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K2354_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z2354 As T2354_AREA,CheckClear as Boolean,MATERIALINBOUNDNO AS String, MATERIALINBOUNDSEQ AS String, MATERIALINBOUNDQNO AS Double) as Boolean

K2354_MOVE = False

Try
    If READ_PFK2354(MATERIALINBOUNDNO, MATERIALINBOUNDSEQ, MATERIALINBOUNDQNO) = True Then
                z2354 = D2354
		K2354_MOVE = True
		else
	If CheckClear  = True then z2354 = nothing
     End If

     If  getColumIndex(spr,"MaterialInBoundNo") > -1 then z2354.MaterialInBoundNo = getDataM(spr, getColumIndex(spr,"MaterialInBoundNo"), xRow)
     If  getColumIndex(spr,"MaterialInBoundSeq") > -1 then z2354.MaterialInBoundSeq = getDataM(spr, getColumIndex(spr,"MaterialInBoundSeq"), xRow)
     If  getColumIndex(spr,"MaterialInBoundQno") > -1 then z2354.MaterialInBoundQno = getDataM(spr, getColumIndex(spr,"MaterialInBoundQno"), xRow)
     If  getColumIndex(spr,"MaterialInBoundSno") > -1 then z2354.MaterialInBoundSno = getDataM(spr, getColumIndex(spr,"MaterialInBoundSno"), xRow)
     If  getColumIndex(spr,"MaterialInBoundDseq") > -1 then z2354.MaterialInBoundDseq = getDataM(spr, getColumIndex(spr,"MaterialInBoundDseq"), xRow)
     If  getColumIndex(spr,"PackInBound") > -1 then z2354.PackInBound = getDataM(spr, getColumIndex(spr,"PackInBound"), xRow)
     If  getColumIndex(spr,"QtyInBound") > -1 then z2354.QtyInBound = getDataM(spr, getColumIndex(spr,"QtyInBound"), xRow)
     If  getColumIndex(spr,"PackQC") > -1 then z2354.PackQC = getDataM(spr, getColumIndex(spr,"PackQC"), xRow)
     If  getColumIndex(spr,"QtyQC") > -1 then z2354.QtyQC = getDataM(spr, getColumIndex(spr,"QtyQC"), xRow)
     If  getColumIndex(spr,"seDefectMaterial") > -1 then z2354.seDefectMaterial = getDataM(spr, getColumIndex(spr,"seDefectMaterial"), xRow)
     If  getColumIndex(spr,"cdDefectMaterial") > -1 then z2354.cdDefectMaterial = getDataM(spr, getColumIndex(spr,"cdDefectMaterial"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z2354.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z2354.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z2354.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z2354.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"Grade") > -1 then z2354.Grade = getDataM(spr, getColumIndex(spr,"Grade"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z2354.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"InchargeQC") > -1 then z2354.InchargeQC = getDataM(spr, getColumIndex(spr,"InchargeQC"), xRow)
     If  getColumIndex(spr,"CheckQC") > -1 then z2354.CheckQC = getDataM(spr, getColumIndex(spr,"CheckQC"), xRow)
     If  getColumIndex(spr,"TimeQC") > -1 then z2354.TimeQC = getDataM(spr, getColumIndex(spr,"TimeQC"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z2354.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K2354_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K2354_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z2354 As T2354_AREA, Job as String, MATERIALINBOUNDNO AS String, MATERIALINBOUNDSEQ AS String, MATERIALINBOUNDQNO AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K2354_MOVE = False

Try
    If READ_PFK2354(MATERIALINBOUNDNO, MATERIALINBOUNDSEQ, MATERIALINBOUNDQNO) = True Then
                z2354 = D2354
		K2354_MOVE = True
		else
	z2354 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2354")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "MATERIALINBOUNDNO":z2354.MaterialInBoundNo = Children(i).Code
   Case "MATERIALINBOUNDSEQ":z2354.MaterialInBoundSeq = Children(i).Code
   Case "MATERIALINBOUNDQNO":z2354.MaterialInBoundQno = Children(i).Code
   Case "MATERIALINBOUNDSNO":z2354.MaterialInBoundSno = Children(i).Code
   Case "MATERIALINBOUNDDSEQ":z2354.MaterialInBoundDseq = Children(i).Code
   Case "PACKINBOUND":z2354.PackInBound = Children(i).Code
   Case "QTYINBOUND":z2354.QtyInBound = Children(i).Code
   Case "PACKQC":z2354.PackQC = Children(i).Code
   Case "QTYQC":z2354.QtyQC = Children(i).Code
   Case "SEDEFECTMATERIAL":z2354.seDefectMaterial = Children(i).Code
   Case "CDDEFECTMATERIAL":z2354.cdDefectMaterial = Children(i).Code
   Case "DATEINSERT":z2354.DateInsert = Children(i).Code
   Case "DATEUPDATE":z2354.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z2354.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z2354.InchargeUpdate = Children(i).Code
   Case "GRADE":z2354.Grade = Children(i).Code
   Case "CHECKCOMPLETE":z2354.CheckComplete = Children(i).Code
   Case "INCHARGEQC":z2354.InchargeQC = Children(i).Code
   Case "CHECKQC":z2354.CheckQC = Children(i).Code
   Case "TIMEQC":z2354.TimeQC = Children(i).Code
   Case "REMARK":z2354.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "MATERIALINBOUNDNO":z2354.MaterialInBoundNo = Children(i).Data
   Case "MATERIALINBOUNDSEQ":z2354.MaterialInBoundSeq = Children(i).Data
   Case "MATERIALINBOUNDQNO":z2354.MaterialInBoundQno = Children(i).Data
   Case "MATERIALINBOUNDSNO":z2354.MaterialInBoundSno = Children(i).Data
   Case "MATERIALINBOUNDDSEQ":z2354.MaterialInBoundDseq = Children(i).Data
   Case "PACKINBOUND":z2354.PackInBound = Children(i).Data
   Case "QTYINBOUND":z2354.QtyInBound = Children(i).Data
   Case "PACKQC":z2354.PackQC = Children(i).Data
   Case "QTYQC":z2354.QtyQC = Children(i).Data
   Case "SEDEFECTMATERIAL":z2354.seDefectMaterial = Children(i).Data
   Case "CDDEFECTMATERIAL":z2354.cdDefectMaterial = Children(i).Data
   Case "DATEINSERT":z2354.DateInsert = Children(i).Data
   Case "DATEUPDATE":z2354.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z2354.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z2354.InchargeUpdate = Children(i).Data
   Case "GRADE":z2354.Grade = Children(i).Data
   Case "CHECKCOMPLETE":z2354.CheckComplete = Children(i).Data
   Case "INCHARGEQC":z2354.InchargeQC = Children(i).Data
   Case "CHECKQC":z2354.CheckQC = Children(i).Data
   Case "TIMEQC":z2354.TimeQC = Children(i).Data
   Case "REMARK":z2354.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K2354_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K2354_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z2354 As T2354_AREA, Job as String, CheckClear as Boolean, MATERIALINBOUNDNO AS String, MATERIALINBOUNDSEQ AS String, MATERIALINBOUNDQNO AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K2354_MOVE = False

Try
    If READ_PFK2354(MATERIALINBOUNDNO, MATERIALINBOUNDSEQ, MATERIALINBOUNDQNO) = True Then
                z2354 = D2354
		K2354_MOVE = True
		else
	If CheckClear  = True then z2354 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2354")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "MATERIALINBOUNDNO":z2354.MaterialInBoundNo = Children(i).Code
   Case "MATERIALINBOUNDSEQ":z2354.MaterialInBoundSeq = Children(i).Code
   Case "MATERIALINBOUNDQNO":z2354.MaterialInBoundQno = Children(i).Code
   Case "MATERIALINBOUNDSNO":z2354.MaterialInBoundSno = Children(i).Code
   Case "MATERIALINBOUNDDSEQ":z2354.MaterialInBoundDseq = Children(i).Code
   Case "PACKINBOUND":z2354.PackInBound = Children(i).Code
   Case "QTYINBOUND":z2354.QtyInBound = Children(i).Code
   Case "PACKQC":z2354.PackQC = Children(i).Code
   Case "QTYQC":z2354.QtyQC = Children(i).Code
   Case "SEDEFECTMATERIAL":z2354.seDefectMaterial = Children(i).Code
   Case "CDDEFECTMATERIAL":z2354.cdDefectMaterial = Children(i).Code
   Case "DATEINSERT":z2354.DateInsert = Children(i).Code
   Case "DATEUPDATE":z2354.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z2354.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z2354.InchargeUpdate = Children(i).Code
   Case "GRADE":z2354.Grade = Children(i).Code
   Case "CHECKCOMPLETE":z2354.CheckComplete = Children(i).Code
   Case "INCHARGEQC":z2354.InchargeQC = Children(i).Code
   Case "CHECKQC":z2354.CheckQC = Children(i).Code
   Case "TIMEQC":z2354.TimeQC = Children(i).Code
   Case "REMARK":z2354.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "MATERIALINBOUNDNO":z2354.MaterialInBoundNo = Children(i).Data
   Case "MATERIALINBOUNDSEQ":z2354.MaterialInBoundSeq = Children(i).Data
   Case "MATERIALINBOUNDQNO":z2354.MaterialInBoundQno = Children(i).Data
   Case "MATERIALINBOUNDSNO":z2354.MaterialInBoundSno = Children(i).Data
   Case "MATERIALINBOUNDDSEQ":z2354.MaterialInBoundDseq = Children(i).Data
   Case "PACKINBOUND":z2354.PackInBound = Children(i).Data
   Case "QTYINBOUND":z2354.QtyInBound = Children(i).Data
   Case "PACKQC":z2354.PackQC = Children(i).Data
   Case "QTYQC":z2354.QtyQC = Children(i).Data
   Case "SEDEFECTMATERIAL":z2354.seDefectMaterial = Children(i).Data
   Case "CDDEFECTMATERIAL":z2354.cdDefectMaterial = Children(i).Data
   Case "DATEINSERT":z2354.DateInsert = Children(i).Data
   Case "DATEUPDATE":z2354.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z2354.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z2354.InchargeUpdate = Children(i).Data
   Case "GRADE":z2354.Grade = Children(i).Data
   Case "CHECKCOMPLETE":z2354.CheckComplete = Children(i).Data
   Case "INCHARGEQC":z2354.InchargeQC = Children(i).Data
   Case "CHECKQC":z2354.CheckQC = Children(i).Data
   Case "TIMEQC":z2354.TimeQC = Children(i).Data
   Case "REMARK":z2354.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K2354_MOVE",vbCritical)
End Try
End Function 
    
End Module 
