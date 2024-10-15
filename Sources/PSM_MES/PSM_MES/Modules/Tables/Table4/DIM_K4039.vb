'=========================================================================================================================================================
'   TABLE : (PFK4039)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K4039

Structure T4039_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	WorkOrder	 AS String	'			char(9)		*
Public 	WorkOrderSeq	 AS String	'			char(3)		*
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

Public D4039 As T4039_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK4039(WORKORDER AS String, WORKORDERSEQ AS String, COMMENTSEQ AS Double) As Boolean
    READ_PFK4039 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4039 "
    SQL = SQL & " WHERE K4039_WorkOrder		 = '" & WorkOrder & "' " 
    SQL = SQL & "   AND K4039_WorkOrderSeq		 = '" & WorkOrderSeq & "' " 
    SQL = SQL & "   AND K4039_CommentSeq		 =  " & CommentSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D4039_CLEAR: GoTo SKIP_READ_PFK4039
                
    Call K4039_MOVE(rd)
    READ_PFK4039 = True

SKIP_READ_PFK4039:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK4039",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK4039(WORKORDER AS String, WORKORDERSEQ AS String, COMMENTSEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4039 "
    SQL = SQL & " WHERE K4039_WorkOrder		 = '" & WorkOrder & "' " 
    SQL = SQL & "   AND K4039_WorkOrderSeq		 = '" & WorkOrderSeq & "' " 
    SQL = SQL & "   AND K4039_CommentSeq		 =  " & CommentSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK4039",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK4039(z4039 As T4039_AREA) As Boolean
    WRITE_PFK4039 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z4039)
 
    SQL = " INSERT INTO PFK4039 "
    SQL = SQL & " ( "
    SQL = SQL & " K4039_WorkOrder," 
    SQL = SQL & " K4039_WorkOrderSeq," 
    SQL = SQL & " K4039_CommentSeq," 
    SQL = SQL & " K4039_Dseq," 
    SQL = SQL & " K4039_seFieldRemark," 
    SQL = SQL & " K4039_cdFieldRemark," 
    SQL = SQL & " K4039_DateRnD," 
    SQL = SQL & " K4039_DateSent," 
    SQL = SQL & " K4039_DateReceived," 
    SQL = SQL & " K4039_DateResults," 
    SQL = SQL & " K4039_Results," 
    SQL = SQL & " K4039_Comment1," 
    SQL = SQL & " K4039_Comment2," 
    SQL = SQL & " K4039_Comment3," 
    SQL = SQL & " K4039_Comment4," 
    SQL = SQL & " K4039_Comment5," 
    SQL = SQL & " K4039_ProductionNote," 
    SQL = SQL & " K4039_Active," 
    SQL = SQL & " K4039_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z4039.WorkOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4039.WorkOrderSeq) & "', "  
    SQL = SQL & "   " & FormatSQL(z4039.CommentSeq) & ", "  
    SQL = SQL & "   " & FormatSQL(z4039.Dseq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4039.seFieldRemark) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4039.cdFieldRemark) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4039.DateRnD) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4039.DateSent) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4039.DateReceived) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4039.DateResults) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4039.Results) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4039.Comment1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4039.Comment2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4039.Comment3) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4039.Comment4) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4039.Comment5) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4039.ProductionNote) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4039.Active) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4039.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK4039 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK4039",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK4039(z4039 As T4039_AREA) As Boolean
    REWRITE_PFK4039 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z4039)
   
    SQL = " UPDATE PFK4039 SET "
    SQL = SQL & "    K4039_Dseq      =  " & FormatSQL(z4039.Dseq) & ", " 
    SQL = SQL & "    K4039_seFieldRemark      = N'" & FormatSQL(z4039.seFieldRemark) & "', " 
    SQL = SQL & "    K4039_cdFieldRemark      = N'" & FormatSQL(z4039.cdFieldRemark) & "', " 
    SQL = SQL & "    K4039_DateRnD      = N'" & FormatSQL(z4039.DateRnD) & "', " 
    SQL = SQL & "    K4039_DateSent      = N'" & FormatSQL(z4039.DateSent) & "', " 
    SQL = SQL & "    K4039_DateReceived      = N'" & FormatSQL(z4039.DateReceived) & "', " 
    SQL = SQL & "    K4039_DateResults      = N'" & FormatSQL(z4039.DateResults) & "', " 
    SQL = SQL & "    K4039_Results      = N'" & FormatSQL(z4039.Results) & "', " 
    SQL = SQL & "    K4039_Comment1      = N'" & FormatSQL(z4039.Comment1) & "', " 
    SQL = SQL & "    K4039_Comment2      = N'" & FormatSQL(z4039.Comment2) & "', " 
    SQL = SQL & "    K4039_Comment3      = N'" & FormatSQL(z4039.Comment3) & "', " 
    SQL = SQL & "    K4039_Comment4      = N'" & FormatSQL(z4039.Comment4) & "', " 
    SQL = SQL & "    K4039_Comment5      = N'" & FormatSQL(z4039.Comment5) & "', " 
    SQL = SQL & "    K4039_ProductionNote      = N'" & FormatSQL(z4039.ProductionNote) & "', " 
    SQL = SQL & "    K4039_Active      = N'" & FormatSQL(z4039.Active) & "', " 
    SQL = SQL & "    K4039_Remark      = N'" & FormatSQL(z4039.Remark) & "'  " 
    SQL = SQL & " WHERE K4039_WorkOrder		 = '" & z4039.WorkOrder & "' " 
    SQL = SQL & "   AND K4039_WorkOrderSeq		 = '" & z4039.WorkOrderSeq & "' " 
    SQL = SQL & "   AND K4039_CommentSeq		 =  " & z4039.CommentSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK4039 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK4039",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK4039(z4039 As T4039_AREA) As Boolean
    DELETE_PFK4039 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK4039 "
    SQL = SQL & " WHERE K4039_WorkOrder		 = '" & z4039.WorkOrder & "' " 
    SQL = SQL & "   AND K4039_WorkOrderSeq		 = '" & z4039.WorkOrderSeq & "' " 
    SQL = SQL & "   AND K4039_CommentSeq		 =  " & z4039.CommentSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK4039 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK4039",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D4039_CLEAR()
Try
    
   D4039.WorkOrder = ""
   D4039.WorkOrderSeq = ""
    D4039.CommentSeq = 0 
    D4039.Dseq = 0 
   D4039.seFieldRemark = ""
   D4039.cdFieldRemark = ""
   D4039.DateRnD = ""
   D4039.DateSent = ""
   D4039.DateReceived = ""
   D4039.DateResults = ""
   D4039.Results = ""
   D4039.Comment1 = ""
   D4039.Comment2 = ""
   D4039.Comment3 = ""
   D4039.Comment4 = ""
   D4039.Comment5 = ""
   D4039.ProductionNote = ""
   D4039.Active = ""
   D4039.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D4039_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x4039 As T4039_AREA)
Try
    
    x4039.WorkOrder = trim$(  x4039.WorkOrder)
    x4039.WorkOrderSeq = trim$(  x4039.WorkOrderSeq)
    x4039.CommentSeq = trim$(  x4039.CommentSeq)
    x4039.Dseq = trim$(  x4039.Dseq)
    x4039.seFieldRemark = trim$(  x4039.seFieldRemark)
    x4039.cdFieldRemark = trim$(  x4039.cdFieldRemark)
    x4039.DateRnD = trim$(  x4039.DateRnD)
    x4039.DateSent = trim$(  x4039.DateSent)
    x4039.DateReceived = trim$(  x4039.DateReceived)
    x4039.DateResults = trim$(  x4039.DateResults)
    x4039.Results = trim$(  x4039.Results)
    x4039.Comment1 = trim$(  x4039.Comment1)
    x4039.Comment2 = trim$(  x4039.Comment2)
    x4039.Comment3 = trim$(  x4039.Comment3)
    x4039.Comment4 = trim$(  x4039.Comment4)
    x4039.Comment5 = trim$(  x4039.Comment5)
    x4039.ProductionNote = trim$(  x4039.ProductionNote)
    x4039.Active = trim$(  x4039.Active)
    x4039.Remark = trim$(  x4039.Remark)
     
    If trim$( x4039.WorkOrder ) = "" Then x4039.WorkOrder = Space(1) 
    If trim$( x4039.WorkOrderSeq ) = "" Then x4039.WorkOrderSeq = Space(1) 
    If trim$( x4039.CommentSeq ) = "" Then x4039.CommentSeq = 0 
    If trim$( x4039.Dseq ) = "" Then x4039.Dseq = 0 
    If trim$( x4039.seFieldRemark ) = "" Then x4039.seFieldRemark = Space(1) 
    If trim$( x4039.cdFieldRemark ) = "" Then x4039.cdFieldRemark = Space(1) 
    If trim$( x4039.DateRnD ) = "" Then x4039.DateRnD = Space(1) 
    If trim$( x4039.DateSent ) = "" Then x4039.DateSent = Space(1) 
    If trim$( x4039.DateReceived ) = "" Then x4039.DateReceived = Space(1) 
    If trim$( x4039.DateResults ) = "" Then x4039.DateResults = Space(1) 
    If trim$( x4039.Results ) = "" Then x4039.Results = Space(1) 
    If trim$( x4039.Comment1 ) = "" Then x4039.Comment1 = Space(1) 
    If trim$( x4039.Comment2 ) = "" Then x4039.Comment2 = Space(1) 
    If trim$( x4039.Comment3 ) = "" Then x4039.Comment3 = Space(1) 
    If trim$( x4039.Comment4 ) = "" Then x4039.Comment4 = Space(1) 
    If trim$( x4039.Comment5 ) = "" Then x4039.Comment5 = Space(1) 
    If trim$( x4039.ProductionNote ) = "" Then x4039.ProductionNote = Space(1) 
    If trim$( x4039.Active ) = "" Then x4039.Active = Space(1) 
    If trim$( x4039.Remark ) = "" Then x4039.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K4039_MOVE(rs4039 As SqlClient.SqlDataReader)
Try

    call D4039_CLEAR()   

    If IsdbNull(rs4039!K4039_WorkOrder) = False Then D4039.WorkOrder = Trim$(rs4039!K4039_WorkOrder)
    If IsdbNull(rs4039!K4039_WorkOrderSeq) = False Then D4039.WorkOrderSeq = Trim$(rs4039!K4039_WorkOrderSeq)
    If IsdbNull(rs4039!K4039_CommentSeq) = False Then D4039.CommentSeq = Trim$(rs4039!K4039_CommentSeq)
    If IsdbNull(rs4039!K4039_Dseq) = False Then D4039.Dseq = Trim$(rs4039!K4039_Dseq)
    If IsdbNull(rs4039!K4039_seFieldRemark) = False Then D4039.seFieldRemark = Trim$(rs4039!K4039_seFieldRemark)
    If IsdbNull(rs4039!K4039_cdFieldRemark) = False Then D4039.cdFieldRemark = Trim$(rs4039!K4039_cdFieldRemark)
    If IsdbNull(rs4039!K4039_DateRnD) = False Then D4039.DateRnD = Trim$(rs4039!K4039_DateRnD)
    If IsdbNull(rs4039!K4039_DateSent) = False Then D4039.DateSent = Trim$(rs4039!K4039_DateSent)
    If IsdbNull(rs4039!K4039_DateReceived) = False Then D4039.DateReceived = Trim$(rs4039!K4039_DateReceived)
    If IsdbNull(rs4039!K4039_DateResults) = False Then D4039.DateResults = Trim$(rs4039!K4039_DateResults)
    If IsdbNull(rs4039!K4039_Results) = False Then D4039.Results = Trim$(rs4039!K4039_Results)
    If IsdbNull(rs4039!K4039_Comment1) = False Then D4039.Comment1 = Trim$(rs4039!K4039_Comment1)
    If IsdbNull(rs4039!K4039_Comment2) = False Then D4039.Comment2 = Trim$(rs4039!K4039_Comment2)
    If IsdbNull(rs4039!K4039_Comment3) = False Then D4039.Comment3 = Trim$(rs4039!K4039_Comment3)
    If IsdbNull(rs4039!K4039_Comment4) = False Then D4039.Comment4 = Trim$(rs4039!K4039_Comment4)
    If IsdbNull(rs4039!K4039_Comment5) = False Then D4039.Comment5 = Trim$(rs4039!K4039_Comment5)
    If IsdbNull(rs4039!K4039_ProductionNote) = False Then D4039.ProductionNote = Trim$(rs4039!K4039_ProductionNote)
    If IsdbNull(rs4039!K4039_Active) = False Then D4039.Active = Trim$(rs4039!K4039_Active)
    If IsdbNull(rs4039!K4039_Remark) = False Then D4039.Remark = Trim$(rs4039!K4039_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4039_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K4039_MOVE(rs4039 As DataRow)
Try

    call D4039_CLEAR()   

    If IsdbNull(rs4039!K4039_WorkOrder) = False Then D4039.WorkOrder = Trim$(rs4039!K4039_WorkOrder)
    If IsdbNull(rs4039!K4039_WorkOrderSeq) = False Then D4039.WorkOrderSeq = Trim$(rs4039!K4039_WorkOrderSeq)
    If IsdbNull(rs4039!K4039_CommentSeq) = False Then D4039.CommentSeq = Trim$(rs4039!K4039_CommentSeq)
    If IsdbNull(rs4039!K4039_Dseq) = False Then D4039.Dseq = Trim$(rs4039!K4039_Dseq)
    If IsdbNull(rs4039!K4039_seFieldRemark) = False Then D4039.seFieldRemark = Trim$(rs4039!K4039_seFieldRemark)
    If IsdbNull(rs4039!K4039_cdFieldRemark) = False Then D4039.cdFieldRemark = Trim$(rs4039!K4039_cdFieldRemark)
    If IsdbNull(rs4039!K4039_DateRnD) = False Then D4039.DateRnD = Trim$(rs4039!K4039_DateRnD)
    If IsdbNull(rs4039!K4039_DateSent) = False Then D4039.DateSent = Trim$(rs4039!K4039_DateSent)
    If IsdbNull(rs4039!K4039_DateReceived) = False Then D4039.DateReceived = Trim$(rs4039!K4039_DateReceived)
    If IsdbNull(rs4039!K4039_DateResults) = False Then D4039.DateResults = Trim$(rs4039!K4039_DateResults)
    If IsdbNull(rs4039!K4039_Results) = False Then D4039.Results = Trim$(rs4039!K4039_Results)
    If IsdbNull(rs4039!K4039_Comment1) = False Then D4039.Comment1 = Trim$(rs4039!K4039_Comment1)
    If IsdbNull(rs4039!K4039_Comment2) = False Then D4039.Comment2 = Trim$(rs4039!K4039_Comment2)
    If IsdbNull(rs4039!K4039_Comment3) = False Then D4039.Comment3 = Trim$(rs4039!K4039_Comment3)
    If IsdbNull(rs4039!K4039_Comment4) = False Then D4039.Comment4 = Trim$(rs4039!K4039_Comment4)
    If IsdbNull(rs4039!K4039_Comment5) = False Then D4039.Comment5 = Trim$(rs4039!K4039_Comment5)
    If IsdbNull(rs4039!K4039_ProductionNote) = False Then D4039.ProductionNote = Trim$(rs4039!K4039_ProductionNote)
    If IsdbNull(rs4039!K4039_Active) = False Then D4039.Active = Trim$(rs4039!K4039_Active)
    If IsdbNull(rs4039!K4039_Remark) = False Then D4039.Remark = Trim$(rs4039!K4039_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4039_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K4039_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4039 As T4039_AREA, WORKORDER AS String, WORKORDERSEQ AS String, COMMENTSEQ AS Double) as Boolean

K4039_MOVE = False

Try
    If READ_PFK4039(WORKORDER, WORKORDERSEQ, COMMENTSEQ) = True Then
                z4039 = D4039
		K4039_MOVE = True
		else
	z4039 = nothing
     End If

     If  getColumIndex(spr,"WorkOrder") > -1 then z4039.WorkOrder = getDataM(spr, getColumIndex(spr,"WorkOrder"), xRow)
     If  getColumIndex(spr,"WorkOrderSeq") > -1 then z4039.WorkOrderSeq = getDataM(spr, getColumIndex(spr,"WorkOrderSeq"), xRow)
     If  getColumIndex(spr,"CommentSeq") > -1 then z4039.CommentSeq = getDataM(spr, getColumIndex(spr,"CommentSeq"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z4039.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"seFieldRemark") > -1 then z4039.seFieldRemark = getDataM(spr, getColumIndex(spr,"seFieldRemark"), xRow)
     If  getColumIndex(spr,"cdFieldRemark") > -1 then z4039.cdFieldRemark = getDataM(spr, getColumIndex(spr,"cdFieldRemark"), xRow)
     If  getColumIndex(spr,"DateRnD") > -1 then z4039.DateRnD = getDataM(spr, getColumIndex(spr,"DateRnD"), xRow)
     If  getColumIndex(spr,"DateSent") > -1 then z4039.DateSent = getDataM(spr, getColumIndex(spr,"DateSent"), xRow)
     If  getColumIndex(spr,"DateReceived") > -1 then z4039.DateReceived = getDataM(spr, getColumIndex(spr,"DateReceived"), xRow)
     If  getColumIndex(spr,"DateResults") > -1 then z4039.DateResults = getDataM(spr, getColumIndex(spr,"DateResults"), xRow)
     If  getColumIndex(spr,"Results") > -1 then z4039.Results = getDataM(spr, getColumIndex(spr,"Results"), xRow)
     If  getColumIndex(spr,"Comment1") > -1 then z4039.Comment1 = getDataM(spr, getColumIndex(spr,"Comment1"), xRow)
     If  getColumIndex(spr,"Comment2") > -1 then z4039.Comment2 = getDataM(spr, getColumIndex(spr,"Comment2"), xRow)
     If  getColumIndex(spr,"Comment3") > -1 then z4039.Comment3 = getDataM(spr, getColumIndex(spr,"Comment3"), xRow)
     If  getColumIndex(spr,"Comment4") > -1 then z4039.Comment4 = getDataM(spr, getColumIndex(spr,"Comment4"), xRow)
     If  getColumIndex(spr,"Comment5") > -1 then z4039.Comment5 = getDataM(spr, getColumIndex(spr,"Comment5"), xRow)
     If  getColumIndex(spr,"ProductionNote") > -1 then z4039.ProductionNote = getDataM(spr, getColumIndex(spr,"ProductionNote"), xRow)
     If  getColumIndex(spr,"Active") > -1 then z4039.Active = getDataM(spr, getColumIndex(spr,"Active"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4039.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4039_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K4039_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4039 As T4039_AREA,CheckClear as Boolean,WORKORDER AS String, WORKORDERSEQ AS String, COMMENTSEQ AS Double) as Boolean

K4039_MOVE = False

Try
    If READ_PFK4039(WORKORDER, WORKORDERSEQ, COMMENTSEQ) = True Then
                z4039 = D4039
		K4039_MOVE = True
		else
	If CheckClear  = True then z4039 = nothing
     End If

     If  getColumIndex(spr,"WorkOrder") > -1 then z4039.WorkOrder = getDataM(spr, getColumIndex(spr,"WorkOrder"), xRow)
     If  getColumIndex(spr,"WorkOrderSeq") > -1 then z4039.WorkOrderSeq = getDataM(spr, getColumIndex(spr,"WorkOrderSeq"), xRow)
     If  getColumIndex(spr,"CommentSeq") > -1 then z4039.CommentSeq = getDataM(spr, getColumIndex(spr,"CommentSeq"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z4039.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"seFieldRemark") > -1 then z4039.seFieldRemark = getDataM(spr, getColumIndex(spr,"seFieldRemark"), xRow)
     If  getColumIndex(spr,"cdFieldRemark") > -1 then z4039.cdFieldRemark = getDataM(spr, getColumIndex(spr,"cdFieldRemark"), xRow)
     If  getColumIndex(spr,"DateRnD") > -1 then z4039.DateRnD = getDataM(spr, getColumIndex(spr,"DateRnD"), xRow)
     If  getColumIndex(spr,"DateSent") > -1 then z4039.DateSent = getDataM(spr, getColumIndex(spr,"DateSent"), xRow)
     If  getColumIndex(spr,"DateReceived") > -1 then z4039.DateReceived = getDataM(spr, getColumIndex(spr,"DateReceived"), xRow)
     If  getColumIndex(spr,"DateResults") > -1 then z4039.DateResults = getDataM(spr, getColumIndex(spr,"DateResults"), xRow)
     If  getColumIndex(spr,"Results") > -1 then z4039.Results = getDataM(spr, getColumIndex(spr,"Results"), xRow)
     If  getColumIndex(spr,"Comment1") > -1 then z4039.Comment1 = getDataM(spr, getColumIndex(spr,"Comment1"), xRow)
     If  getColumIndex(spr,"Comment2") > -1 then z4039.Comment2 = getDataM(spr, getColumIndex(spr,"Comment2"), xRow)
     If  getColumIndex(spr,"Comment3") > -1 then z4039.Comment3 = getDataM(spr, getColumIndex(spr,"Comment3"), xRow)
     If  getColumIndex(spr,"Comment4") > -1 then z4039.Comment4 = getDataM(spr, getColumIndex(spr,"Comment4"), xRow)
     If  getColumIndex(spr,"Comment5") > -1 then z4039.Comment5 = getDataM(spr, getColumIndex(spr,"Comment5"), xRow)
     If  getColumIndex(spr,"ProductionNote") > -1 then z4039.ProductionNote = getDataM(spr, getColumIndex(spr,"ProductionNote"), xRow)
     If  getColumIndex(spr,"Active") > -1 then z4039.Active = getDataM(spr, getColumIndex(spr,"Active"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4039.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4039_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K4039_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4039 As T4039_AREA, Job as String, WORKORDER AS String, WORKORDERSEQ AS String, COMMENTSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4039_MOVE = False

Try
    If READ_PFK4039(WORKORDER, WORKORDERSEQ, COMMENTSEQ) = True Then
                z4039 = D4039
		K4039_MOVE = True
		else
	z4039 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4039")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "WORKORDER":z4039.WorkOrder = Children(i).Code
   Case "WORKORDERSEQ":z4039.WorkOrderSeq = Children(i).Code
   Case "COMMENTSEQ":z4039.CommentSeq = Children(i).Code
   Case "DSEQ":z4039.Dseq = Children(i).Code
   Case "SEFIELDREMARK":z4039.seFieldRemark = Children(i).Code
   Case "CDFIELDREMARK":z4039.cdFieldRemark = Children(i).Code
   Case "DATERND":z4039.DateRnD = Children(i).Code
   Case "DATESENT":z4039.DateSent = Children(i).Code
   Case "DATERECEIVED":z4039.DateReceived = Children(i).Code
   Case "DATERESULTS":z4039.DateResults = Children(i).Code
   Case "RESULTS":z4039.Results = Children(i).Code
   Case "COMMENT1":z4039.Comment1 = Children(i).Code
   Case "COMMENT2":z4039.Comment2 = Children(i).Code
   Case "COMMENT3":z4039.Comment3 = Children(i).Code
   Case "COMMENT4":z4039.Comment4 = Children(i).Code
   Case "COMMENT5":z4039.Comment5 = Children(i).Code
   Case "PRODUCTIONNOTE":z4039.ProductionNote = Children(i).Code
   Case "ACTIVE":z4039.Active = Children(i).Code
   Case "REMARK":z4039.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "WORKORDER":z4039.WorkOrder = Children(i).Data
   Case "WORKORDERSEQ":z4039.WorkOrderSeq = Children(i).Data
   Case "COMMENTSEQ":z4039.CommentSeq = Children(i).Data
   Case "DSEQ":z4039.Dseq = Children(i).Data
   Case "SEFIELDREMARK":z4039.seFieldRemark = Children(i).Data
   Case "CDFIELDREMARK":z4039.cdFieldRemark = Children(i).Data
   Case "DATERND":z4039.DateRnD = Children(i).Data
   Case "DATESENT":z4039.DateSent = Children(i).Data
   Case "DATERECEIVED":z4039.DateReceived = Children(i).Data
   Case "DATERESULTS":z4039.DateResults = Children(i).Data
   Case "RESULTS":z4039.Results = Children(i).Data
   Case "COMMENT1":z4039.Comment1 = Children(i).Data
   Case "COMMENT2":z4039.Comment2 = Children(i).Data
   Case "COMMENT3":z4039.Comment3 = Children(i).Data
   Case "COMMENT4":z4039.Comment4 = Children(i).Data
   Case "COMMENT5":z4039.Comment5 = Children(i).Data
   Case "PRODUCTIONNOTE":z4039.ProductionNote = Children(i).Data
   Case "ACTIVE":z4039.Active = Children(i).Data
   Case "REMARK":z4039.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4039_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K4039_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4039 As T4039_AREA, Job as String, CheckClear as Boolean, WORKORDER AS String, WORKORDERSEQ AS String, COMMENTSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4039_MOVE = False

Try
    If READ_PFK4039(WORKORDER, WORKORDERSEQ, COMMENTSEQ) = True Then
                z4039 = D4039
		K4039_MOVE = True
		else
	If CheckClear  = True then z4039 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4039")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "WORKORDER":z4039.WorkOrder = Children(i).Code
   Case "WORKORDERSEQ":z4039.WorkOrderSeq = Children(i).Code
   Case "COMMENTSEQ":z4039.CommentSeq = Children(i).Code
   Case "DSEQ":z4039.Dseq = Children(i).Code
   Case "SEFIELDREMARK":z4039.seFieldRemark = Children(i).Code
   Case "CDFIELDREMARK":z4039.cdFieldRemark = Children(i).Code
   Case "DATERND":z4039.DateRnD = Children(i).Code
   Case "DATESENT":z4039.DateSent = Children(i).Code
   Case "DATERECEIVED":z4039.DateReceived = Children(i).Code
   Case "DATERESULTS":z4039.DateResults = Children(i).Code
   Case "RESULTS":z4039.Results = Children(i).Code
   Case "COMMENT1":z4039.Comment1 = Children(i).Code
   Case "COMMENT2":z4039.Comment2 = Children(i).Code
   Case "COMMENT3":z4039.Comment3 = Children(i).Code
   Case "COMMENT4":z4039.Comment4 = Children(i).Code
   Case "COMMENT5":z4039.Comment5 = Children(i).Code
   Case "PRODUCTIONNOTE":z4039.ProductionNote = Children(i).Code
   Case "ACTIVE":z4039.Active = Children(i).Code
   Case "REMARK":z4039.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "WORKORDER":z4039.WorkOrder = Children(i).Data
   Case "WORKORDERSEQ":z4039.WorkOrderSeq = Children(i).Data
   Case "COMMENTSEQ":z4039.CommentSeq = Children(i).Data
   Case "DSEQ":z4039.Dseq = Children(i).Data
   Case "SEFIELDREMARK":z4039.seFieldRemark = Children(i).Data
   Case "CDFIELDREMARK":z4039.cdFieldRemark = Children(i).Data
   Case "DATERND":z4039.DateRnD = Children(i).Data
   Case "DATESENT":z4039.DateSent = Children(i).Data
   Case "DATERECEIVED":z4039.DateReceived = Children(i).Data
   Case "DATERESULTS":z4039.DateResults = Children(i).Data
   Case "RESULTS":z4039.Results = Children(i).Data
   Case "COMMENT1":z4039.Comment1 = Children(i).Data
   Case "COMMENT2":z4039.Comment2 = Children(i).Data
   Case "COMMENT3":z4039.Comment3 = Children(i).Data
   Case "COMMENT4":z4039.Comment4 = Children(i).Data
   Case "COMMENT5":z4039.Comment5 = Children(i).Data
   Case "PRODUCTIONNOTE":z4039.ProductionNote = Children(i).Data
   Case "ACTIVE":z4039.Active = Children(i).Data
   Case "REMARK":z4039.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4039_MOVE",vbCritical)
End Try
End Function 
    
End Module 
