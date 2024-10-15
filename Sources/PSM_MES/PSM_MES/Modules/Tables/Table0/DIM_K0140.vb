'=========================================================================================================================================================
'   TABLE : (PFK0140)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K0140

Structure T0140_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	SpecNo	 AS String	'			char(9)		*
Public 	SpecNoSeq	 AS String	'			char(3)		*
Public 	CommentSeq	 AS Double	'			decimal		*
Public 	Dseq	 AS Double	'			decimal
Public 	seFieldRemark	 AS String	'			char(3)
Public 	cdFieldRemark	 AS String	'			char(3)
Public 	DateRnD	 AS String	'			char(8)
Public 	DateSent	 AS String	'			char(8)
Public 	DateReceived	 AS String	'			char(8)
Public 	DateResults	 AS String	'			char(8)
Public 	Results	 AS String	'			char(1)
Public 	Comment1	 AS String	'			nvarchar(100)
Public 	Comment2	 AS String	'			nvarchar(100)
Public 	Comment3	 AS String	'			nvarchar(100)
Public 	Comment4	 AS String	'			nvarchar(100)
Public 	Comment5	 AS String	'			nvarchar(100)
Public 	ProductionNote	 AS String	'			nvarchar(100)
Public 	Active	 AS String	'			char(1)
Public 	Remark	 AS String	'			nvarchar(50)
'=========================================================================================================================================================
End structure

Public D0140 As T0140_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK0140(SPECNO AS String, SPECNOSEQ AS String, COMMENTSEQ AS Double) As Boolean
    READ_PFK0140 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0140 "
    SQL = SQL & " WHERE K0140_SpecNo		 = '" & SpecNo & "' " 
    SQL = SQL & "   AND K0140_SpecNoSeq		 = '" & SpecNoSeq & "' " 
    SQL = SQL & "   AND K0140_CommentSeq		 =  " & CommentSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D0140_CLEAR: GoTo SKIP_READ_PFK0140
                
    Call K0140_MOVE(rd)
    READ_PFK0140 = True

SKIP_READ_PFK0140:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK0140",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK0140(SPECNO AS String, SPECNOSEQ AS String, COMMENTSEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0140 "
    SQL = SQL & " WHERE K0140_SpecNo		 = '" & SpecNo & "' " 
    SQL = SQL & "   AND K0140_SpecNoSeq		 = '" & SpecNoSeq & "' " 
    SQL = SQL & "   AND K0140_CommentSeq		 =  " & CommentSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK0140",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK0140(z0140 As T0140_AREA) As Boolean
    WRITE_PFK0140 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z0140)
 
    SQL = " INSERT INTO PFK0140 "
    SQL = SQL & " ( "
    SQL = SQL & " K0140_SpecNo," 
    SQL = SQL & " K0140_SpecNoSeq," 
    SQL = SQL & " K0140_CommentSeq," 
    SQL = SQL & " K0140_Dseq," 
    SQL = SQL & " K0140_seFieldRemark," 
    SQL = SQL & " K0140_cdFieldRemark," 
    SQL = SQL & " K0140_DateRnD," 
    SQL = SQL & " K0140_DateSent," 
    SQL = SQL & " K0140_DateReceived," 
    SQL = SQL & " K0140_DateResults," 
    SQL = SQL & " K0140_Results," 
    SQL = SQL & " K0140_Comment1," 
    SQL = SQL & " K0140_Comment2," 
    SQL = SQL & " K0140_Comment3," 
    SQL = SQL & " K0140_Comment4," 
    SQL = SQL & " K0140_Comment5," 
    SQL = SQL & " K0140_ProductionNote," 
    SQL = SQL & " K0140_Active," 
    SQL = SQL & " K0140_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z0140.SpecNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0140.SpecNoSeq) & "', "  
    SQL = SQL & "   " & FormatSQL(z0140.CommentSeq) & ", "  
    SQL = SQL & "   " & FormatSQL(z0140.Dseq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z0140.seFieldRemark) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0140.cdFieldRemark) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0140.DateRnD) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0140.DateSent) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0140.DateReceived) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0140.DateResults) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0140.Results) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0140.Comment1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0140.Comment2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0140.Comment3) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0140.Comment4) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0140.Comment5) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0140.ProductionNote) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0140.Active) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0140.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK0140 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK0140",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK0140(z0140 As T0140_AREA) As Boolean
    REWRITE_PFK0140 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z0140)
   
    SQL = " UPDATE PFK0140 SET "
    SQL = SQL & "    K0140_Dseq      =  " & FormatSQL(z0140.Dseq) & ", " 
    SQL = SQL & "    K0140_seFieldRemark      = N'" & FormatSQL(z0140.seFieldRemark) & "', " 
    SQL = SQL & "    K0140_cdFieldRemark      = N'" & FormatSQL(z0140.cdFieldRemark) & "', " 
    SQL = SQL & "    K0140_DateRnD      = N'" & FormatSQL(z0140.DateRnD) & "', " 
    SQL = SQL & "    K0140_DateSent      = N'" & FormatSQL(z0140.DateSent) & "', " 
    SQL = SQL & "    K0140_DateReceived      = N'" & FormatSQL(z0140.DateReceived) & "', " 
    SQL = SQL & "    K0140_DateResults      = N'" & FormatSQL(z0140.DateResults) & "', " 
    SQL = SQL & "    K0140_Results      = N'" & FormatSQL(z0140.Results) & "', " 
    SQL = SQL & "    K0140_Comment1      = N'" & FormatSQL(z0140.Comment1) & "', " 
    SQL = SQL & "    K0140_Comment2      = N'" & FormatSQL(z0140.Comment2) & "', " 
    SQL = SQL & "    K0140_Comment3      = N'" & FormatSQL(z0140.Comment3) & "', " 
    SQL = SQL & "    K0140_Comment4      = N'" & FormatSQL(z0140.Comment4) & "', " 
    SQL = SQL & "    K0140_Comment5      = N'" & FormatSQL(z0140.Comment5) & "', " 
    SQL = SQL & "    K0140_ProductionNote      = N'" & FormatSQL(z0140.ProductionNote) & "', " 
    SQL = SQL & "    K0140_Active      = N'" & FormatSQL(z0140.Active) & "', " 
    SQL = SQL & "    K0140_Remark      = N'" & FormatSQL(z0140.Remark) & "'  " 
    SQL = SQL & " WHERE K0140_SpecNo		 = '" & z0140.SpecNo & "' " 
    SQL = SQL & "   AND K0140_SpecNoSeq		 = '" & z0140.SpecNoSeq & "' " 
    SQL = SQL & "   AND K0140_CommentSeq		 =  " & z0140.CommentSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK0140 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK0140",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK0140(z0140 As T0140_AREA) As Boolean
    DELETE_PFK0140 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK0140 "
    SQL = SQL & " WHERE K0140_SpecNo		 = '" & z0140.SpecNo & "' " 
    SQL = SQL & "   AND K0140_SpecNoSeq		 = '" & z0140.SpecNoSeq & "' " 
    SQL = SQL & "   AND K0140_CommentSeq		 =  " & z0140.CommentSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK0140 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK0140",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D0140_CLEAR()
Try
    
   D0140.SpecNo = ""
   D0140.SpecNoSeq = ""
    D0140.CommentSeq = 0 
    D0140.Dseq = 0 
   D0140.seFieldRemark = ""
   D0140.cdFieldRemark = ""
   D0140.DateRnD = ""
   D0140.DateSent = ""
   D0140.DateReceived = ""
   D0140.DateResults = ""
   D0140.Results = ""
   D0140.Comment1 = ""
   D0140.Comment2 = ""
   D0140.Comment3 = ""
   D0140.Comment4 = ""
   D0140.Comment5 = ""
   D0140.ProductionNote = ""
   D0140.Active = ""
   D0140.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D0140_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x0140 As T0140_AREA)
Try
    
    x0140.SpecNo = trim$(  x0140.SpecNo)
    x0140.SpecNoSeq = trim$(  x0140.SpecNoSeq)
    x0140.CommentSeq = trim$(  x0140.CommentSeq)
    x0140.Dseq = trim$(  x0140.Dseq)
    x0140.seFieldRemark = trim$(  x0140.seFieldRemark)
    x0140.cdFieldRemark = trim$(  x0140.cdFieldRemark)
    x0140.DateRnD = trim$(  x0140.DateRnD)
    x0140.DateSent = trim$(  x0140.DateSent)
    x0140.DateReceived = trim$(  x0140.DateReceived)
    x0140.DateResults = trim$(  x0140.DateResults)
    x0140.Results = trim$(  x0140.Results)
    x0140.Comment1 = trim$(  x0140.Comment1)
    x0140.Comment2 = trim$(  x0140.Comment2)
    x0140.Comment3 = trim$(  x0140.Comment3)
    x0140.Comment4 = trim$(  x0140.Comment4)
    x0140.Comment5 = trim$(  x0140.Comment5)
    x0140.ProductionNote = trim$(  x0140.ProductionNote)
    x0140.Active = trim$(  x0140.Active)
    x0140.Remark = trim$(  x0140.Remark)
     
    If trim$( x0140.SpecNo ) = "" Then x0140.SpecNo = Space(1) 
    If trim$( x0140.SpecNoSeq ) = "" Then x0140.SpecNoSeq = Space(1) 
    If trim$( x0140.CommentSeq ) = "" Then x0140.CommentSeq = 0 
    If trim$( x0140.Dseq ) = "" Then x0140.Dseq = 0 
    If trim$( x0140.seFieldRemark ) = "" Then x0140.seFieldRemark = Space(1) 
    If trim$( x0140.cdFieldRemark ) = "" Then x0140.cdFieldRemark = Space(1) 
    If trim$( x0140.DateRnD ) = "" Then x0140.DateRnD = Space(1) 
    If trim$( x0140.DateSent ) = "" Then x0140.DateSent = Space(1) 
    If trim$( x0140.DateReceived ) = "" Then x0140.DateReceived = Space(1) 
    If trim$( x0140.DateResults ) = "" Then x0140.DateResults = Space(1) 
    If trim$( x0140.Results ) = "" Then x0140.Results = Space(1) 
    If trim$( x0140.Comment1 ) = "" Then x0140.Comment1 = Space(1) 
    If trim$( x0140.Comment2 ) = "" Then x0140.Comment2 = Space(1) 
    If trim$( x0140.Comment3 ) = "" Then x0140.Comment3 = Space(1) 
    If trim$( x0140.Comment4 ) = "" Then x0140.Comment4 = Space(1) 
    If trim$( x0140.Comment5 ) = "" Then x0140.Comment5 = Space(1) 
    If trim$( x0140.ProductionNote ) = "" Then x0140.ProductionNote = Space(1) 
    If trim$( x0140.Active ) = "" Then x0140.Active = Space(1) 
    If trim$( x0140.Remark ) = "" Then x0140.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K0140_MOVE(rs0140 As SqlClient.SqlDataReader)
Try

    call D0140_CLEAR()   

    If IsdbNull(rs0140!K0140_SpecNo) = False Then D0140.SpecNo = Trim$(rs0140!K0140_SpecNo)
    If IsdbNull(rs0140!K0140_SpecNoSeq) = False Then D0140.SpecNoSeq = Trim$(rs0140!K0140_SpecNoSeq)
    If IsdbNull(rs0140!K0140_CommentSeq) = False Then D0140.CommentSeq = Trim$(rs0140!K0140_CommentSeq)
    If IsdbNull(rs0140!K0140_Dseq) = False Then D0140.Dseq = Trim$(rs0140!K0140_Dseq)
    If IsdbNull(rs0140!K0140_seFieldRemark) = False Then D0140.seFieldRemark = Trim$(rs0140!K0140_seFieldRemark)
    If IsdbNull(rs0140!K0140_cdFieldRemark) = False Then D0140.cdFieldRemark = Trim$(rs0140!K0140_cdFieldRemark)
    If IsdbNull(rs0140!K0140_DateRnD) = False Then D0140.DateRnD = Trim$(rs0140!K0140_DateRnD)
    If IsdbNull(rs0140!K0140_DateSent) = False Then D0140.DateSent = Trim$(rs0140!K0140_DateSent)
    If IsdbNull(rs0140!K0140_DateReceived) = False Then D0140.DateReceived = Trim$(rs0140!K0140_DateReceived)
    If IsdbNull(rs0140!K0140_DateResults) = False Then D0140.DateResults = Trim$(rs0140!K0140_DateResults)
    If IsdbNull(rs0140!K0140_Results) = False Then D0140.Results = Trim$(rs0140!K0140_Results)
    If IsdbNull(rs0140!K0140_Comment1) = False Then D0140.Comment1 = Trim$(rs0140!K0140_Comment1)
    If IsdbNull(rs0140!K0140_Comment2) = False Then D0140.Comment2 = Trim$(rs0140!K0140_Comment2)
    If IsdbNull(rs0140!K0140_Comment3) = False Then D0140.Comment3 = Trim$(rs0140!K0140_Comment3)
    If IsdbNull(rs0140!K0140_Comment4) = False Then D0140.Comment4 = Trim$(rs0140!K0140_Comment4)
    If IsdbNull(rs0140!K0140_Comment5) = False Then D0140.Comment5 = Trim$(rs0140!K0140_Comment5)
    If IsdbNull(rs0140!K0140_ProductionNote) = False Then D0140.ProductionNote = Trim$(rs0140!K0140_ProductionNote)
    If IsdbNull(rs0140!K0140_Active) = False Then D0140.Active = Trim$(rs0140!K0140_Active)
    If IsdbNull(rs0140!K0140_Remark) = False Then D0140.Remark = Trim$(rs0140!K0140_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0140_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K0140_MOVE(rs0140 As DataRow)
Try

    call D0140_CLEAR()   

    If IsdbNull(rs0140!K0140_SpecNo) = False Then D0140.SpecNo = Trim$(rs0140!K0140_SpecNo)
    If IsdbNull(rs0140!K0140_SpecNoSeq) = False Then D0140.SpecNoSeq = Trim$(rs0140!K0140_SpecNoSeq)
    If IsdbNull(rs0140!K0140_CommentSeq) = False Then D0140.CommentSeq = Trim$(rs0140!K0140_CommentSeq)
    If IsdbNull(rs0140!K0140_Dseq) = False Then D0140.Dseq = Trim$(rs0140!K0140_Dseq)
    If IsdbNull(rs0140!K0140_seFieldRemark) = False Then D0140.seFieldRemark = Trim$(rs0140!K0140_seFieldRemark)
    If IsdbNull(rs0140!K0140_cdFieldRemark) = False Then D0140.cdFieldRemark = Trim$(rs0140!K0140_cdFieldRemark)
    If IsdbNull(rs0140!K0140_DateRnD) = False Then D0140.DateRnD = Trim$(rs0140!K0140_DateRnD)
    If IsdbNull(rs0140!K0140_DateSent) = False Then D0140.DateSent = Trim$(rs0140!K0140_DateSent)
    If IsdbNull(rs0140!K0140_DateReceived) = False Then D0140.DateReceived = Trim$(rs0140!K0140_DateReceived)
    If IsdbNull(rs0140!K0140_DateResults) = False Then D0140.DateResults = Trim$(rs0140!K0140_DateResults)
    If IsdbNull(rs0140!K0140_Results) = False Then D0140.Results = Trim$(rs0140!K0140_Results)
    If IsdbNull(rs0140!K0140_Comment1) = False Then D0140.Comment1 = Trim$(rs0140!K0140_Comment1)
    If IsdbNull(rs0140!K0140_Comment2) = False Then D0140.Comment2 = Trim$(rs0140!K0140_Comment2)
    If IsdbNull(rs0140!K0140_Comment3) = False Then D0140.Comment3 = Trim$(rs0140!K0140_Comment3)
    If IsdbNull(rs0140!K0140_Comment4) = False Then D0140.Comment4 = Trim$(rs0140!K0140_Comment4)
    If IsdbNull(rs0140!K0140_Comment5) = False Then D0140.Comment5 = Trim$(rs0140!K0140_Comment5)
    If IsdbNull(rs0140!K0140_ProductionNote) = False Then D0140.ProductionNote = Trim$(rs0140!K0140_ProductionNote)
    If IsdbNull(rs0140!K0140_Active) = False Then D0140.Active = Trim$(rs0140!K0140_Active)
    If IsdbNull(rs0140!K0140_Remark) = False Then D0140.Remark = Trim$(rs0140!K0140_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0140_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K0140_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0140 As T0140_AREA, SPECNO AS String, SPECNOSEQ AS String, COMMENTSEQ AS Double) as Boolean

K0140_MOVE = False

Try
    If READ_PFK0140(SPECNO, SPECNOSEQ, COMMENTSEQ) = True Then
                z0140 = D0140
		K0140_MOVE = True
		else
	z0140 = nothing
     End If

     If  getColumIndex(spr,"SpecNo") > -1 then z0140.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z0140.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"CommentSeq") > -1 then z0140.CommentSeq = getDataM(spr, getColumIndex(spr,"CommentSeq"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z0140.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"seFieldRemark") > -1 then z0140.seFieldRemark = getDataM(spr, getColumIndex(spr,"seFieldRemark"), xRow)
     If  getColumIndex(spr,"cdFieldRemark") > -1 then z0140.cdFieldRemark = getDataM(spr, getColumIndex(spr,"cdFieldRemark"), xRow)
     If  getColumIndex(spr,"DateRnD") > -1 then z0140.DateRnD = getDataM(spr, getColumIndex(spr,"DateRnD"), xRow)
     If  getColumIndex(spr,"DateSent") > -1 then z0140.DateSent = getDataM(spr, getColumIndex(spr,"DateSent"), xRow)
     If  getColumIndex(spr,"DateReceived") > -1 then z0140.DateReceived = getDataM(spr, getColumIndex(spr,"DateReceived"), xRow)
     If  getColumIndex(spr,"DateResults") > -1 then z0140.DateResults = getDataM(spr, getColumIndex(spr,"DateResults"), xRow)
     If  getColumIndex(spr,"Results") > -1 then z0140.Results = getDataM(spr, getColumIndex(spr,"Results"), xRow)
     If  getColumIndex(spr,"Comment1") > -1 then z0140.Comment1 = getDataM(spr, getColumIndex(spr,"Comment1"), xRow)
     If  getColumIndex(spr,"Comment2") > -1 then z0140.Comment2 = getDataM(spr, getColumIndex(spr,"Comment2"), xRow)
     If  getColumIndex(spr,"Comment3") > -1 then z0140.Comment3 = getDataM(spr, getColumIndex(spr,"Comment3"), xRow)
     If  getColumIndex(spr,"Comment4") > -1 then z0140.Comment4 = getDataM(spr, getColumIndex(spr,"Comment4"), xRow)
     If  getColumIndex(spr,"Comment5") > -1 then z0140.Comment5 = getDataM(spr, getColumIndex(spr,"Comment5"), xRow)
     If  getColumIndex(spr,"ProductionNote") > -1 then z0140.ProductionNote = getDataM(spr, getColumIndex(spr,"ProductionNote"), xRow)
     If  getColumIndex(spr,"Active") > -1 then z0140.Active = getDataM(spr, getColumIndex(spr,"Active"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0140.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0140_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K0140_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0140 As T0140_AREA,CheckClear as Boolean,SPECNO AS String, SPECNOSEQ AS String, COMMENTSEQ AS Double) as Boolean

K0140_MOVE = False

Try
    If READ_PFK0140(SPECNO, SPECNOSEQ, COMMENTSEQ) = True Then
                z0140 = D0140
		K0140_MOVE = True
		else
	If CheckClear  = True then z0140 = nothing
     End If

     If  getColumIndex(spr,"SpecNo") > -1 then z0140.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z0140.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"CommentSeq") > -1 then z0140.CommentSeq = getDataM(spr, getColumIndex(spr,"CommentSeq"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z0140.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"seFieldRemark") > -1 then z0140.seFieldRemark = getDataM(spr, getColumIndex(spr,"seFieldRemark"), xRow)
     If  getColumIndex(spr,"cdFieldRemark") > -1 then z0140.cdFieldRemark = getDataM(spr, getColumIndex(spr,"cdFieldRemark"), xRow)
     If  getColumIndex(spr,"DateRnD") > -1 then z0140.DateRnD = getDataM(spr, getColumIndex(spr,"DateRnD"), xRow)
     If  getColumIndex(spr,"DateSent") > -1 then z0140.DateSent = getDataM(spr, getColumIndex(spr,"DateSent"), xRow)
     If  getColumIndex(spr,"DateReceived") > -1 then z0140.DateReceived = getDataM(spr, getColumIndex(spr,"DateReceived"), xRow)
     If  getColumIndex(spr,"DateResults") > -1 then z0140.DateResults = getDataM(spr, getColumIndex(spr,"DateResults"), xRow)
     If  getColumIndex(spr,"Results") > -1 then z0140.Results = getDataM(spr, getColumIndex(spr,"Results"), xRow)
     If  getColumIndex(spr,"Comment1") > -1 then z0140.Comment1 = getDataM(spr, getColumIndex(spr,"Comment1"), xRow)
     If  getColumIndex(spr,"Comment2") > -1 then z0140.Comment2 = getDataM(spr, getColumIndex(spr,"Comment2"), xRow)
     If  getColumIndex(spr,"Comment3") > -1 then z0140.Comment3 = getDataM(spr, getColumIndex(spr,"Comment3"), xRow)
     If  getColumIndex(spr,"Comment4") > -1 then z0140.Comment4 = getDataM(spr, getColumIndex(spr,"Comment4"), xRow)
     If  getColumIndex(spr,"Comment5") > -1 then z0140.Comment5 = getDataM(spr, getColumIndex(spr,"Comment5"), xRow)
     If  getColumIndex(spr,"ProductionNote") > -1 then z0140.ProductionNote = getDataM(spr, getColumIndex(spr,"ProductionNote"), xRow)
     If  getColumIndex(spr,"Active") > -1 then z0140.Active = getDataM(spr, getColumIndex(spr,"Active"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0140.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0140_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K0140_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0140 As T0140_AREA, Job as String, SPECNO AS String, SPECNOSEQ AS String, COMMENTSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0140_MOVE = False

Try
    If READ_PFK0140(SPECNO, SPECNOSEQ, COMMENTSEQ) = True Then
                z0140 = D0140
		K0140_MOVE = True
		else
	z0140 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0140")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SPECNO":z0140.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z0140.SpecNoSeq = Children(i).Code
   Case "COMMENTSEQ":z0140.CommentSeq = Children(i).Code
   Case "DSEQ":z0140.Dseq = Children(i).Code
   Case "SEFIELDREMARK":z0140.seFieldRemark = Children(i).Code
   Case "CDFIELDREMARK":z0140.cdFieldRemark = Children(i).Code
   Case "DATERND":z0140.DateRnD = Children(i).Code
   Case "DATESENT":z0140.DateSent = Children(i).Code
   Case "DATERECEIVED":z0140.DateReceived = Children(i).Code
   Case "DATERESULTS":z0140.DateResults = Children(i).Code
   Case "RESULTS":z0140.Results = Children(i).Code
   Case "COMMENT1":z0140.Comment1 = Children(i).Code
   Case "COMMENT2":z0140.Comment2 = Children(i).Code
   Case "COMMENT3":z0140.Comment3 = Children(i).Code
   Case "COMMENT4":z0140.Comment4 = Children(i).Code
   Case "COMMENT5":z0140.Comment5 = Children(i).Code
   Case "PRODUCTIONNOTE":z0140.ProductionNote = Children(i).Code
   Case "ACTIVE":z0140.Active = Children(i).Code
   Case "REMARK":z0140.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SPECNO":z0140.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z0140.SpecNoSeq = Children(i).Data
   Case "COMMENTSEQ":z0140.CommentSeq = Children(i).Data
   Case "DSEQ":z0140.Dseq = Children(i).Data
   Case "SEFIELDREMARK":z0140.seFieldRemark = Children(i).Data
   Case "CDFIELDREMARK":z0140.cdFieldRemark = Children(i).Data
   Case "DATERND":z0140.DateRnD = Children(i).Data
   Case "DATESENT":z0140.DateSent = Children(i).Data
   Case "DATERECEIVED":z0140.DateReceived = Children(i).Data
   Case "DATERESULTS":z0140.DateResults = Children(i).Data
   Case "RESULTS":z0140.Results = Children(i).Data
   Case "COMMENT1":z0140.Comment1 = Children(i).Data
   Case "COMMENT2":z0140.Comment2 = Children(i).Data
   Case "COMMENT3":z0140.Comment3 = Children(i).Data
   Case "COMMENT4":z0140.Comment4 = Children(i).Data
   Case "COMMENT5":z0140.Comment5 = Children(i).Data
   Case "PRODUCTIONNOTE":z0140.ProductionNote = Children(i).Data
   Case "ACTIVE":z0140.Active = Children(i).Data
   Case "REMARK":z0140.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0140_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K0140_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0140 As T0140_AREA, Job as String, CheckClear as Boolean, SPECNO AS String, SPECNOSEQ AS String, COMMENTSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0140_MOVE = False

Try
    If READ_PFK0140(SPECNO, SPECNOSEQ, COMMENTSEQ) = True Then
                z0140 = D0140
		K0140_MOVE = True
		else
	If CheckClear  = True then z0140 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0140")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SPECNO":z0140.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z0140.SpecNoSeq = Children(i).Code
   Case "COMMENTSEQ":z0140.CommentSeq = Children(i).Code
   Case "DSEQ":z0140.Dseq = Children(i).Code
   Case "SEFIELDREMARK":z0140.seFieldRemark = Children(i).Code
   Case "CDFIELDREMARK":z0140.cdFieldRemark = Children(i).Code
   Case "DATERND":z0140.DateRnD = Children(i).Code
   Case "DATESENT":z0140.DateSent = Children(i).Code
   Case "DATERECEIVED":z0140.DateReceived = Children(i).Code
   Case "DATERESULTS":z0140.DateResults = Children(i).Code
   Case "RESULTS":z0140.Results = Children(i).Code
   Case "COMMENT1":z0140.Comment1 = Children(i).Code
   Case "COMMENT2":z0140.Comment2 = Children(i).Code
   Case "COMMENT3":z0140.Comment3 = Children(i).Code
   Case "COMMENT4":z0140.Comment4 = Children(i).Code
   Case "COMMENT5":z0140.Comment5 = Children(i).Code
   Case "PRODUCTIONNOTE":z0140.ProductionNote = Children(i).Code
   Case "ACTIVE":z0140.Active = Children(i).Code
   Case "REMARK":z0140.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SPECNO":z0140.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z0140.SpecNoSeq = Children(i).Data
   Case "COMMENTSEQ":z0140.CommentSeq = Children(i).Data
   Case "DSEQ":z0140.Dseq = Children(i).Data
   Case "SEFIELDREMARK":z0140.seFieldRemark = Children(i).Data
   Case "CDFIELDREMARK":z0140.cdFieldRemark = Children(i).Data
   Case "DATERND":z0140.DateRnD = Children(i).Data
   Case "DATESENT":z0140.DateSent = Children(i).Data
   Case "DATERECEIVED":z0140.DateReceived = Children(i).Data
   Case "DATERESULTS":z0140.DateResults = Children(i).Data
   Case "RESULTS":z0140.Results = Children(i).Data
   Case "COMMENT1":z0140.Comment1 = Children(i).Data
   Case "COMMENT2":z0140.Comment2 = Children(i).Data
   Case "COMMENT3":z0140.Comment3 = Children(i).Data
   Case "COMMENT4":z0140.Comment4 = Children(i).Data
   Case "COMMENT5":z0140.Comment5 = Children(i).Data
   Case "PRODUCTIONNOTE":z0140.ProductionNote = Children(i).Data
   Case "ACTIVE":z0140.Active = Children(i).Data
   Case "REMARK":z0140.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0140_MOVE",vbCritical)
End Try
End Function 
    
End Module 
