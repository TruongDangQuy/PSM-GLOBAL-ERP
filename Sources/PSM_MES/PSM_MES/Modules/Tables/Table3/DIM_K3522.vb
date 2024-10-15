'=========================================================================================================================================================
'   TABLE : (PFK3522)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K3522

Structure T3522_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	MachineTestOrder	 AS String	'			char(9)		*
Public 	MachineTestOrderSeq	 AS String	'			char(3)		*
Public 	Dseq	 AS Double	'			decimal
Public 	MachineCode	 AS String	'			char(6)
Public 	MCStandardCode	 AS String	'			char(6)
Public 	MCStandardCodeSeq	 AS Double	'			decimal
Public 	TValue1	 AS String	'			nvarchar(20)
Public 	TValue2	 AS String	'			nvarchar(20)
Public 	TValue3	 AS String	'			nvarchar(20)
Public 	TValue4	 AS String	'			nvarchar(20)
Public 	TValue5	 AS String	'			nvarchar(20)
Public 	InsertDate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(6)
Public 	UpdateDate	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(6)
Public 	Remark	 AS String	'			nvarchar(100)
'=========================================================================================================================================================
End structure

Public D3522 As T3522_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK3522(MACHINETESTORDER AS String, MACHINETESTORDERSEQ AS String) As Boolean
    READ_PFK3522 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3522 "
    SQL = SQL & " WHERE K3522_MachineTestOrder		 = '" & MachineTestOrder & "' " 
    SQL = SQL & "   AND K3522_MachineTestOrderSeq		 = '" & MachineTestOrderSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D3522_CLEAR: GoTo SKIP_READ_PFK3522
                
    Call K3522_MOVE(rd)
    READ_PFK3522 = True

SKIP_READ_PFK3522:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK3522",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK3522(MACHINETESTORDER AS String, MACHINETESTORDERSEQ AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3522 "
    SQL = SQL & " WHERE K3522_MachineTestOrder		 = '" & MachineTestOrder & "' " 
    SQL = SQL & "   AND K3522_MachineTestOrderSeq		 = '" & MachineTestOrderSeq & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK3522",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK3522(z3522 As T3522_AREA) As Boolean
    WRITE_PFK3522 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z3522)
 
    SQL = " INSERT INTO PFK3522 "
    SQL = SQL & " ( "
    SQL = SQL & " K3522_MachineTestOrder," 
    SQL = SQL & " K3522_MachineTestOrderSeq," 
    SQL = SQL & " K3522_Dseq," 
    SQL = SQL & " K3522_MachineCode," 
    SQL = SQL & " K3522_MCStandardCode," 
    SQL = SQL & " K3522_MCStandardCodeSeq," 
    SQL = SQL & " K3522_TValue1," 
    SQL = SQL & " K3522_TValue2," 
    SQL = SQL & " K3522_TValue3," 
    SQL = SQL & " K3522_TValue4," 
    SQL = SQL & " K3522_TValue5," 
    SQL = SQL & " K3522_InsertDate," 
    SQL = SQL & " K3522_InchargeInsert," 
    SQL = SQL & " K3522_UpdateDate," 
    SQL = SQL & " K3522_InchargeUpdate," 
    SQL = SQL & " K3522_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z3522.MachineTestOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3522.MachineTestOrderSeq) & "', "  
    SQL = SQL & "   " & FormatSQL(z3522.Dseq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3522.MachineCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3522.MCStandardCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z3522.MCStandardCodeSeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3522.TValue1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3522.TValue2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3522.TValue3) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3522.TValue4) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3522.TValue5) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3522.InsertDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3522.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3522.UpdateDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3522.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3522.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK3522 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK3522",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK3522(z3522 As T3522_AREA) As Boolean
    REWRITE_PFK3522 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z3522)
   
    SQL = " UPDATE PFK3522 SET "
    SQL = SQL & "    K3522_Dseq      =  " & FormatSQL(z3522.Dseq) & ", " 
    SQL = SQL & "    K3522_MachineCode      = N'" & FormatSQL(z3522.MachineCode) & "', " 
    SQL = SQL & "    K3522_MCStandardCode      = N'" & FormatSQL(z3522.MCStandardCode) & "', " 
    SQL = SQL & "    K3522_MCStandardCodeSeq      =  " & FormatSQL(z3522.MCStandardCodeSeq) & ", " 
    SQL = SQL & "    K3522_TValue1      = N'" & FormatSQL(z3522.TValue1) & "', " 
    SQL = SQL & "    K3522_TValue2      = N'" & FormatSQL(z3522.TValue2) & "', " 
    SQL = SQL & "    K3522_TValue3      = N'" & FormatSQL(z3522.TValue3) & "', " 
    SQL = SQL & "    K3522_TValue4      = N'" & FormatSQL(z3522.TValue4) & "', " 
    SQL = SQL & "    K3522_TValue5      = N'" & FormatSQL(z3522.TValue5) & "', " 
    SQL = SQL & "    K3522_InsertDate      = N'" & FormatSQL(z3522.InsertDate) & "', " 
    SQL = SQL & "    K3522_InchargeInsert      = N'" & FormatSQL(z3522.InchargeInsert) & "', " 
    SQL = SQL & "    K3522_UpdateDate      = N'" & FormatSQL(z3522.UpdateDate) & "', " 
    SQL = SQL & "    K3522_InchargeUpdate      = N'" & FormatSQL(z3522.InchargeUpdate) & "', " 
    SQL = SQL & "    K3522_Remark      = N'" & FormatSQL(z3522.Remark) & "'  " 
    SQL = SQL & " WHERE K3522_MachineTestOrder		 = '" & z3522.MachineTestOrder & "' " 
    SQL = SQL & "   AND K3522_MachineTestOrderSeq		 = '" & z3522.MachineTestOrderSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK3522 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK3522",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK3522(z3522 As T3522_AREA) As Boolean
    DELETE_PFK3522 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK3522 "
    SQL = SQL & " WHERE K3522_MachineTestOrder		 = '" & z3522.MachineTestOrder & "' " 
    SQL = SQL & "   AND K3522_MachineTestOrderSeq		 = '" & z3522.MachineTestOrderSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK3522 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK3522",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D3522_CLEAR()
Try
    
   D3522.MachineTestOrder = ""
   D3522.MachineTestOrderSeq = ""
    D3522.Dseq = 0 
   D3522.MachineCode = ""
   D3522.MCStandardCode = ""
    D3522.MCStandardCodeSeq = 0 
   D3522.TValue1 = ""
   D3522.TValue2 = ""
   D3522.TValue3 = ""
   D3522.TValue4 = ""
   D3522.TValue5 = ""
   D3522.InsertDate = ""
   D3522.InchargeInsert = ""
   D3522.UpdateDate = ""
   D3522.InchargeUpdate = ""
   D3522.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D3522_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x3522 As T3522_AREA)
Try
    
    x3522.MachineTestOrder = trim$(  x3522.MachineTestOrder)
    x3522.MachineTestOrderSeq = trim$(  x3522.MachineTestOrderSeq)
    x3522.Dseq = trim$(  x3522.Dseq)
    x3522.MachineCode = trim$(  x3522.MachineCode)
    x3522.MCStandardCode = trim$(  x3522.MCStandardCode)
    x3522.MCStandardCodeSeq = trim$(  x3522.MCStandardCodeSeq)
    x3522.TValue1 = trim$(  x3522.TValue1)
    x3522.TValue2 = trim$(  x3522.TValue2)
    x3522.TValue3 = trim$(  x3522.TValue3)
    x3522.TValue4 = trim$(  x3522.TValue4)
    x3522.TValue5 = trim$(  x3522.TValue5)
    x3522.InsertDate = trim$(  x3522.InsertDate)
    x3522.InchargeInsert = trim$(  x3522.InchargeInsert)
    x3522.UpdateDate = trim$(  x3522.UpdateDate)
    x3522.InchargeUpdate = trim$(  x3522.InchargeUpdate)
    x3522.Remark = trim$(  x3522.Remark)
     
    If trim$( x3522.MachineTestOrder ) = "" Then x3522.MachineTestOrder = Space(1) 
    If trim$( x3522.MachineTestOrderSeq ) = "" Then x3522.MachineTestOrderSeq = Space(1) 
    If trim$( x3522.Dseq ) = "" Then x3522.Dseq = 0 
    If trim$( x3522.MachineCode ) = "" Then x3522.MachineCode = Space(1) 
    If trim$( x3522.MCStandardCode ) = "" Then x3522.MCStandardCode = Space(1) 
    If trim$( x3522.MCStandardCodeSeq ) = "" Then x3522.MCStandardCodeSeq = 0 
    If trim$( x3522.TValue1 ) = "" Then x3522.TValue1 = Space(1) 
    If trim$( x3522.TValue2 ) = "" Then x3522.TValue2 = Space(1) 
    If trim$( x3522.TValue3 ) = "" Then x3522.TValue3 = Space(1) 
    If trim$( x3522.TValue4 ) = "" Then x3522.TValue4 = Space(1) 
    If trim$( x3522.TValue5 ) = "" Then x3522.TValue5 = Space(1) 
    If trim$( x3522.InsertDate ) = "" Then x3522.InsertDate = Space(1) 
    If trim$( x3522.InchargeInsert ) = "" Then x3522.InchargeInsert = Space(1) 
    If trim$( x3522.UpdateDate ) = "" Then x3522.UpdateDate = Space(1) 
    If trim$( x3522.InchargeUpdate ) = "" Then x3522.InchargeUpdate = Space(1) 
    If trim$( x3522.Remark ) = "" Then x3522.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K3522_MOVE(rs3522 As SqlClient.SqlDataReader)
Try

    call D3522_CLEAR()   

    If IsdbNull(rs3522!K3522_MachineTestOrder) = False Then D3522.MachineTestOrder = Trim$(rs3522!K3522_MachineTestOrder)
    If IsdbNull(rs3522!K3522_MachineTestOrderSeq) = False Then D3522.MachineTestOrderSeq = Trim$(rs3522!K3522_MachineTestOrderSeq)
    If IsdbNull(rs3522!K3522_Dseq) = False Then D3522.Dseq = Trim$(rs3522!K3522_Dseq)
    If IsdbNull(rs3522!K3522_MachineCode) = False Then D3522.MachineCode = Trim$(rs3522!K3522_MachineCode)
    If IsdbNull(rs3522!K3522_MCStandardCode) = False Then D3522.MCStandardCode = Trim$(rs3522!K3522_MCStandardCode)
    If IsdbNull(rs3522!K3522_MCStandardCodeSeq) = False Then D3522.MCStandardCodeSeq = Trim$(rs3522!K3522_MCStandardCodeSeq)
    If IsdbNull(rs3522!K3522_TValue1) = False Then D3522.TValue1 = Trim$(rs3522!K3522_TValue1)
    If IsdbNull(rs3522!K3522_TValue2) = False Then D3522.TValue2 = Trim$(rs3522!K3522_TValue2)
    If IsdbNull(rs3522!K3522_TValue3) = False Then D3522.TValue3 = Trim$(rs3522!K3522_TValue3)
    If IsdbNull(rs3522!K3522_TValue4) = False Then D3522.TValue4 = Trim$(rs3522!K3522_TValue4)
    If IsdbNull(rs3522!K3522_TValue5) = False Then D3522.TValue5 = Trim$(rs3522!K3522_TValue5)
    If IsdbNull(rs3522!K3522_InsertDate) = False Then D3522.InsertDate = Trim$(rs3522!K3522_InsertDate)
    If IsdbNull(rs3522!K3522_InchargeInsert) = False Then D3522.InchargeInsert = Trim$(rs3522!K3522_InchargeInsert)
    If IsdbNull(rs3522!K3522_UpdateDate) = False Then D3522.UpdateDate = Trim$(rs3522!K3522_UpdateDate)
    If IsdbNull(rs3522!K3522_InchargeUpdate) = False Then D3522.InchargeUpdate = Trim$(rs3522!K3522_InchargeUpdate)
    If IsdbNull(rs3522!K3522_Remark) = False Then D3522.Remark = Trim$(rs3522!K3522_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3522_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K3522_MOVE(rs3522 As DataRow)
Try

    call D3522_CLEAR()   

    If IsdbNull(rs3522!K3522_MachineTestOrder) = False Then D3522.MachineTestOrder = Trim$(rs3522!K3522_MachineTestOrder)
    If IsdbNull(rs3522!K3522_MachineTestOrderSeq) = False Then D3522.MachineTestOrderSeq = Trim$(rs3522!K3522_MachineTestOrderSeq)
    If IsdbNull(rs3522!K3522_Dseq) = False Then D3522.Dseq = Trim$(rs3522!K3522_Dseq)
    If IsdbNull(rs3522!K3522_MachineCode) = False Then D3522.MachineCode = Trim$(rs3522!K3522_MachineCode)
    If IsdbNull(rs3522!K3522_MCStandardCode) = False Then D3522.MCStandardCode = Trim$(rs3522!K3522_MCStandardCode)
    If IsdbNull(rs3522!K3522_MCStandardCodeSeq) = False Then D3522.MCStandardCodeSeq = Trim$(rs3522!K3522_MCStandardCodeSeq)
    If IsdbNull(rs3522!K3522_TValue1) = False Then D3522.TValue1 = Trim$(rs3522!K3522_TValue1)
    If IsdbNull(rs3522!K3522_TValue2) = False Then D3522.TValue2 = Trim$(rs3522!K3522_TValue2)
    If IsdbNull(rs3522!K3522_TValue3) = False Then D3522.TValue3 = Trim$(rs3522!K3522_TValue3)
    If IsdbNull(rs3522!K3522_TValue4) = False Then D3522.TValue4 = Trim$(rs3522!K3522_TValue4)
    If IsdbNull(rs3522!K3522_TValue5) = False Then D3522.TValue5 = Trim$(rs3522!K3522_TValue5)
    If IsdbNull(rs3522!K3522_InsertDate) = False Then D3522.InsertDate = Trim$(rs3522!K3522_InsertDate)
    If IsdbNull(rs3522!K3522_InchargeInsert) = False Then D3522.InchargeInsert = Trim$(rs3522!K3522_InchargeInsert)
    If IsdbNull(rs3522!K3522_UpdateDate) = False Then D3522.UpdateDate = Trim$(rs3522!K3522_UpdateDate)
    If IsdbNull(rs3522!K3522_InchargeUpdate) = False Then D3522.InchargeUpdate = Trim$(rs3522!K3522_InchargeUpdate)
    If IsdbNull(rs3522!K3522_Remark) = False Then D3522.Remark = Trim$(rs3522!K3522_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3522_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K3522_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3522 As T3522_AREA, MACHINETESTORDER AS String, MACHINETESTORDERSEQ AS String) as Boolean

K3522_MOVE = False

Try
    If READ_PFK3522(MACHINETESTORDER, MACHINETESTORDERSEQ) = True Then
                z3522 = D3522
		K3522_MOVE = True
		else
	z3522 = nothing
     End If

     If  getColumIndex(spr,"MachineTestOrder") > -1 then z3522.MachineTestOrder = getDataM(spr, getColumIndex(spr,"MachineTestOrder"), xRow)
     If  getColumIndex(spr,"MachineTestOrderSeq") > -1 then z3522.MachineTestOrderSeq = getDataM(spr, getColumIndex(spr,"MachineTestOrderSeq"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z3522.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"MachineCode") > -1 then z3522.MachineCode = getDataM(spr, getColumIndex(spr,"MachineCode"), xRow)
     If  getColumIndex(spr,"MCStandardCode") > -1 then z3522.MCStandardCode = getDataM(spr, getColumIndex(spr,"MCStandardCode"), xRow)
     If  getColumIndex(spr,"MCStandardCodeSeq") > -1 then z3522.MCStandardCodeSeq = getDataM(spr, getColumIndex(spr,"MCStandardCodeSeq"), xRow)
     If  getColumIndex(spr,"TValue1") > -1 then z3522.TValue1 = getDataM(spr, getColumIndex(spr,"TValue1"), xRow)
     If  getColumIndex(spr,"TValue2") > -1 then z3522.TValue2 = getDataM(spr, getColumIndex(spr,"TValue2"), xRow)
     If  getColumIndex(spr,"TValue3") > -1 then z3522.TValue3 = getDataM(spr, getColumIndex(spr,"TValue3"), xRow)
     If  getColumIndex(spr,"TValue4") > -1 then z3522.TValue4 = getDataM(spr, getColumIndex(spr,"TValue4"), xRow)
     If  getColumIndex(spr,"TValue5") > -1 then z3522.TValue5 = getDataM(spr, getColumIndex(spr,"TValue5"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z3522.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z3522.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z3522.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z3522.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z3522.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3522_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K3522_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3522 As T3522_AREA,CheckClear as Boolean,MACHINETESTORDER AS String, MACHINETESTORDERSEQ AS String) as Boolean

K3522_MOVE = False

Try
    If READ_PFK3522(MACHINETESTORDER, MACHINETESTORDERSEQ) = True Then
                z3522 = D3522
		K3522_MOVE = True
		else
	If CheckClear  = True then z3522 = nothing
     End If

     If  getColumIndex(spr,"MachineTestOrder") > -1 then z3522.MachineTestOrder = getDataM(spr, getColumIndex(spr,"MachineTestOrder"), xRow)
     If  getColumIndex(spr,"MachineTestOrderSeq") > -1 then z3522.MachineTestOrderSeq = getDataM(spr, getColumIndex(spr,"MachineTestOrderSeq"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z3522.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"MachineCode") > -1 then z3522.MachineCode = getDataM(spr, getColumIndex(spr,"MachineCode"), xRow)
     If  getColumIndex(spr,"MCStandardCode") > -1 then z3522.MCStandardCode = getDataM(spr, getColumIndex(spr,"MCStandardCode"), xRow)
     If  getColumIndex(spr,"MCStandardCodeSeq") > -1 then z3522.MCStandardCodeSeq = getDataM(spr, getColumIndex(spr,"MCStandardCodeSeq"), xRow)
     If  getColumIndex(spr,"TValue1") > -1 then z3522.TValue1 = getDataM(spr, getColumIndex(spr,"TValue1"), xRow)
     If  getColumIndex(spr,"TValue2") > -1 then z3522.TValue2 = getDataM(spr, getColumIndex(spr,"TValue2"), xRow)
     If  getColumIndex(spr,"TValue3") > -1 then z3522.TValue3 = getDataM(spr, getColumIndex(spr,"TValue3"), xRow)
     If  getColumIndex(spr,"TValue4") > -1 then z3522.TValue4 = getDataM(spr, getColumIndex(spr,"TValue4"), xRow)
     If  getColumIndex(spr,"TValue5") > -1 then z3522.TValue5 = getDataM(spr, getColumIndex(spr,"TValue5"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z3522.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z3522.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z3522.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z3522.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z3522.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3522_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K3522_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3522 As T3522_AREA, Job as String, MACHINETESTORDER AS String, MACHINETESTORDERSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3522_MOVE = False

Try
    If READ_PFK3522(MACHINETESTORDER, MACHINETESTORDERSEQ) = True Then
                z3522 = D3522
		K3522_MOVE = True
		else
	z3522 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3522")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "MACHINETESTORDER":z3522.MachineTestOrder = Children(i).Code
   Case "MACHINETESTORDERSEQ":z3522.MachineTestOrderSeq = Children(i).Code
   Case "DSEQ":z3522.Dseq = Children(i).Code
   Case "MACHINECODE":z3522.MachineCode = Children(i).Code
   Case "MCSTANDARDCODE":z3522.MCStandardCode = Children(i).Code
   Case "MCSTANDARDCODESEQ":z3522.MCStandardCodeSeq = Children(i).Code
   Case "TVALUE1":z3522.TValue1 = Children(i).Code
   Case "TVALUE2":z3522.TValue2 = Children(i).Code
   Case "TVALUE3":z3522.TValue3 = Children(i).Code
   Case "TVALUE4":z3522.TValue4 = Children(i).Code
   Case "TVALUE5":z3522.TValue5 = Children(i).Code
   Case "INSERTDATE":z3522.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z3522.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z3522.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z3522.InchargeUpdate = Children(i).Code
   Case "REMARK":z3522.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "MACHINETESTORDER":z3522.MachineTestOrder = Children(i).Data
   Case "MACHINETESTORDERSEQ":z3522.MachineTestOrderSeq = Children(i).Data
   Case "DSEQ":z3522.Dseq = Children(i).Data
   Case "MACHINECODE":z3522.MachineCode = Children(i).Data
   Case "MCSTANDARDCODE":z3522.MCStandardCode = Children(i).Data
   Case "MCSTANDARDCODESEQ":z3522.MCStandardCodeSeq = Children(i).Data
   Case "TVALUE1":z3522.TValue1 = Children(i).Data
   Case "TVALUE2":z3522.TValue2 = Children(i).Data
   Case "TVALUE3":z3522.TValue3 = Children(i).Data
   Case "TVALUE4":z3522.TValue4 = Children(i).Data
   Case "TVALUE5":z3522.TValue5 = Children(i).Data
   Case "INSERTDATE":z3522.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z3522.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z3522.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z3522.InchargeUpdate = Children(i).Data
   Case "REMARK":z3522.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3522_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K3522_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3522 As T3522_AREA, Job as String, CheckClear as Boolean, MACHINETESTORDER AS String, MACHINETESTORDERSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3522_MOVE = False

Try
    If READ_PFK3522(MACHINETESTORDER, MACHINETESTORDERSEQ) = True Then
                z3522 = D3522
		K3522_MOVE = True
		else
	If CheckClear  = True then z3522 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3522")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "MACHINETESTORDER":z3522.MachineTestOrder = Children(i).Code
   Case "MACHINETESTORDERSEQ":z3522.MachineTestOrderSeq = Children(i).Code
   Case "DSEQ":z3522.Dseq = Children(i).Code
   Case "MACHINECODE":z3522.MachineCode = Children(i).Code
   Case "MCSTANDARDCODE":z3522.MCStandardCode = Children(i).Code
   Case "MCSTANDARDCODESEQ":z3522.MCStandardCodeSeq = Children(i).Code
   Case "TVALUE1":z3522.TValue1 = Children(i).Code
   Case "TVALUE2":z3522.TValue2 = Children(i).Code
   Case "TVALUE3":z3522.TValue3 = Children(i).Code
   Case "TVALUE4":z3522.TValue4 = Children(i).Code
   Case "TVALUE5":z3522.TValue5 = Children(i).Code
   Case "INSERTDATE":z3522.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z3522.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z3522.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z3522.InchargeUpdate = Children(i).Code
   Case "REMARK":z3522.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "MACHINETESTORDER":z3522.MachineTestOrder = Children(i).Data
   Case "MACHINETESTORDERSEQ":z3522.MachineTestOrderSeq = Children(i).Data
   Case "DSEQ":z3522.Dseq = Children(i).Data
   Case "MACHINECODE":z3522.MachineCode = Children(i).Data
   Case "MCSTANDARDCODE":z3522.MCStandardCode = Children(i).Data
   Case "MCSTANDARDCODESEQ":z3522.MCStandardCodeSeq = Children(i).Data
   Case "TVALUE1":z3522.TValue1 = Children(i).Data
   Case "TVALUE2":z3522.TValue2 = Children(i).Data
   Case "TVALUE3":z3522.TValue3 = Children(i).Data
   Case "TVALUE4":z3522.TValue4 = Children(i).Data
   Case "TVALUE5":z3522.TValue5 = Children(i).Data
   Case "INSERTDATE":z3522.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z3522.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z3522.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z3522.InchargeUpdate = Children(i).Data
   Case "REMARK":z3522.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3522_MOVE",vbCritical)
End Try
End Function 
    
End Module 
