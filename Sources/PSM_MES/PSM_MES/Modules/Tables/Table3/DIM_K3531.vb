'=========================================================================================================================================================
'   TABLE : (PFK3531)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K3531

Structure T3531_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	MCStandardCode	 AS String	'			char(6)		*
Public 	MCStandardCodeSeq	 AS Double	'			decimal		*
Public 	Dseq	 AS Double	'			decimal
Public 	seStandardMC	 AS String	'			char(3)
Public 	cdStandardMC	 AS String	'			char(3)
Public 	Value1	 AS String	'			nvarchar(20)
Public 	Value2	 AS String	'			nvarchar(20)
Public 	Value3	 AS String	'			nvarchar(20)
Public 	Value4	 AS String	'			nvarchar(20)
Public 	Value5	 AS String	'			nvarchar(20)
Public 	InsertDate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(6)
Public 	UpdateDate	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(6)
Public 	Remark	 AS String	'			nvarchar(100)
'=========================================================================================================================================================
End structure

Public D3531 As T3531_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK3531(MCSTANDARDCODE AS String, MCSTANDARDCODESEQ AS Double) As Boolean
    READ_PFK3531 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3531 "
    SQL = SQL & " WHERE K3531_MCStandardCode		 = '" & MCStandardCode & "' " 
    SQL = SQL & "   AND K3531_MCStandardCodeSeq		 =  " & MCStandardCodeSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D3531_CLEAR: GoTo SKIP_READ_PFK3531
                
    Call K3531_MOVE(rd)
    READ_PFK3531 = True

SKIP_READ_PFK3531:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK3531",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK3531(MCSTANDARDCODE AS String, MCSTANDARDCODESEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3531 "
    SQL = SQL & " WHERE K3531_MCStandardCode		 = '" & MCStandardCode & "' " 
    SQL = SQL & "   AND K3531_MCStandardCodeSeq		 =  " & MCStandardCodeSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK3531",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK3531(z3531 As T3531_AREA) As Boolean
    WRITE_PFK3531 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z3531)
 
    SQL = " INSERT INTO PFK3531 "
    SQL = SQL & " ( "
    SQL = SQL & " K3531_MCStandardCode," 
    SQL = SQL & " K3531_MCStandardCodeSeq," 
    SQL = SQL & " K3531_Dseq," 
    SQL = SQL & " K3531_seStandardMC," 
    SQL = SQL & " K3531_cdStandardMC," 
    SQL = SQL & " K3531_Value1," 
    SQL = SQL & " K3531_Value2," 
    SQL = SQL & " K3531_Value3," 
    SQL = SQL & " K3531_Value4," 
    SQL = SQL & " K3531_Value5," 
    SQL = SQL & " K3531_InsertDate," 
    SQL = SQL & " K3531_InchargeInsert," 
    SQL = SQL & " K3531_UpdateDate," 
    SQL = SQL & " K3531_InchargeUpdate," 
    SQL = SQL & " K3531_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z3531.MCStandardCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z3531.MCStandardCodeSeq) & ", "  
    SQL = SQL & "   " & FormatSQL(z3531.Dseq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3531.seStandardMC) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3531.cdStandardMC) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3531.Value1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3531.Value2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3531.Value3) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3531.Value4) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3531.Value5) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3531.InsertDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3531.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3531.UpdateDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3531.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3531.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK3531 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK3531",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK3531(z3531 As T3531_AREA) As Boolean
    REWRITE_PFK3531 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z3531)
   
    SQL = " UPDATE PFK3531 SET "
    SQL = SQL & "    K3531_Dseq      =  " & FormatSQL(z3531.Dseq) & ", " 
    SQL = SQL & "    K3531_seStandardMC      = N'" & FormatSQL(z3531.seStandardMC) & "', " 
    SQL = SQL & "    K3531_cdStandardMC      = N'" & FormatSQL(z3531.cdStandardMC) & "', " 
    SQL = SQL & "    K3531_Value1      = N'" & FormatSQL(z3531.Value1) & "', " 
    SQL = SQL & "    K3531_Value2      = N'" & FormatSQL(z3531.Value2) & "', " 
    SQL = SQL & "    K3531_Value3      = N'" & FormatSQL(z3531.Value3) & "', " 
    SQL = SQL & "    K3531_Value4      = N'" & FormatSQL(z3531.Value4) & "', " 
    SQL = SQL & "    K3531_Value5      = N'" & FormatSQL(z3531.Value5) & "', " 
    SQL = SQL & "    K3531_InsertDate      = N'" & FormatSQL(z3531.InsertDate) & "', " 
    SQL = SQL & "    K3531_InchargeInsert      = N'" & FormatSQL(z3531.InchargeInsert) & "', " 
    SQL = SQL & "    K3531_UpdateDate      = N'" & FormatSQL(z3531.UpdateDate) & "', " 
    SQL = SQL & "    K3531_InchargeUpdate      = N'" & FormatSQL(z3531.InchargeUpdate) & "', " 
    SQL = SQL & "    K3531_Remark      = N'" & FormatSQL(z3531.Remark) & "'  " 
    SQL = SQL & " WHERE K3531_MCStandardCode		 = '" & z3531.MCStandardCode & "' " 
    SQL = SQL & "   AND K3531_MCStandardCodeSeq		 =  " & z3531.MCStandardCodeSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK3531 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK3531",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK3531(z3531 As T3531_AREA) As Boolean
    DELETE_PFK3531 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK3531 "
    SQL = SQL & " WHERE K3531_MCStandardCode		 = '" & z3531.MCStandardCode & "' " 
    SQL = SQL & "   AND K3531_MCStandardCodeSeq		 =  " & z3531.MCStandardCodeSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK3531 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK3531",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D3531_CLEAR()
Try
    
   D3531.MCStandardCode = ""
    D3531.MCStandardCodeSeq = 0 
    D3531.Dseq = 0 
   D3531.seStandardMC = ""
   D3531.cdStandardMC = ""
   D3531.Value1 = ""
   D3531.Value2 = ""
   D3531.Value3 = ""
   D3531.Value4 = ""
   D3531.Value5 = ""
   D3531.InsertDate = ""
   D3531.InchargeInsert = ""
   D3531.UpdateDate = ""
   D3531.InchargeUpdate = ""
   D3531.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D3531_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x3531 As T3531_AREA)
Try
    
    x3531.MCStandardCode = trim$(  x3531.MCStandardCode)
    x3531.MCStandardCodeSeq = trim$(  x3531.MCStandardCodeSeq)
    x3531.Dseq = trim$(  x3531.Dseq)
    x3531.seStandardMC = trim$(  x3531.seStandardMC)
    x3531.cdStandardMC = trim$(  x3531.cdStandardMC)
    x3531.Value1 = trim$(  x3531.Value1)
    x3531.Value2 = trim$(  x3531.Value2)
    x3531.Value3 = trim$(  x3531.Value3)
    x3531.Value4 = trim$(  x3531.Value4)
    x3531.Value5 = trim$(  x3531.Value5)
    x3531.InsertDate = trim$(  x3531.InsertDate)
    x3531.InchargeInsert = trim$(  x3531.InchargeInsert)
    x3531.UpdateDate = trim$(  x3531.UpdateDate)
    x3531.InchargeUpdate = trim$(  x3531.InchargeUpdate)
    x3531.Remark = trim$(  x3531.Remark)
     
    If trim$( x3531.MCStandardCode ) = "" Then x3531.MCStandardCode = Space(1) 
    If trim$( x3531.MCStandardCodeSeq ) = "" Then x3531.MCStandardCodeSeq = 0 
    If trim$( x3531.Dseq ) = "" Then x3531.Dseq = 0 
    If trim$( x3531.seStandardMC ) = "" Then x3531.seStandardMC = Space(1) 
    If trim$( x3531.cdStandardMC ) = "" Then x3531.cdStandardMC = Space(1) 
    If trim$( x3531.Value1 ) = "" Then x3531.Value1 = Space(1) 
    If trim$( x3531.Value2 ) = "" Then x3531.Value2 = Space(1) 
    If trim$( x3531.Value3 ) = "" Then x3531.Value3 = Space(1) 
    If trim$( x3531.Value4 ) = "" Then x3531.Value4 = Space(1) 
    If trim$( x3531.Value5 ) = "" Then x3531.Value5 = Space(1) 
    If trim$( x3531.InsertDate ) = "" Then x3531.InsertDate = Space(1) 
    If trim$( x3531.InchargeInsert ) = "" Then x3531.InchargeInsert = Space(1) 
    If trim$( x3531.UpdateDate ) = "" Then x3531.UpdateDate = Space(1) 
    If trim$( x3531.InchargeUpdate ) = "" Then x3531.InchargeUpdate = Space(1) 
    If trim$( x3531.Remark ) = "" Then x3531.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K3531_MOVE(rs3531 As SqlClient.SqlDataReader)
Try

    call D3531_CLEAR()   

    If IsdbNull(rs3531!K3531_MCStandardCode) = False Then D3531.MCStandardCode = Trim$(rs3531!K3531_MCStandardCode)
    If IsdbNull(rs3531!K3531_MCStandardCodeSeq) = False Then D3531.MCStandardCodeSeq = Trim$(rs3531!K3531_MCStandardCodeSeq)
    If IsdbNull(rs3531!K3531_Dseq) = False Then D3531.Dseq = Trim$(rs3531!K3531_Dseq)
    If IsdbNull(rs3531!K3531_seStandardMC) = False Then D3531.seStandardMC = Trim$(rs3531!K3531_seStandardMC)
    If IsdbNull(rs3531!K3531_cdStandardMC) = False Then D3531.cdStandardMC = Trim$(rs3531!K3531_cdStandardMC)
    If IsdbNull(rs3531!K3531_Value1) = False Then D3531.Value1 = Trim$(rs3531!K3531_Value1)
    If IsdbNull(rs3531!K3531_Value2) = False Then D3531.Value2 = Trim$(rs3531!K3531_Value2)
    If IsdbNull(rs3531!K3531_Value3) = False Then D3531.Value3 = Trim$(rs3531!K3531_Value3)
    If IsdbNull(rs3531!K3531_Value4) = False Then D3531.Value4 = Trim$(rs3531!K3531_Value4)
    If IsdbNull(rs3531!K3531_Value5) = False Then D3531.Value5 = Trim$(rs3531!K3531_Value5)
    If IsdbNull(rs3531!K3531_InsertDate) = False Then D3531.InsertDate = Trim$(rs3531!K3531_InsertDate)
    If IsdbNull(rs3531!K3531_InchargeInsert) = False Then D3531.InchargeInsert = Trim$(rs3531!K3531_InchargeInsert)
    If IsdbNull(rs3531!K3531_UpdateDate) = False Then D3531.UpdateDate = Trim$(rs3531!K3531_UpdateDate)
    If IsdbNull(rs3531!K3531_InchargeUpdate) = False Then D3531.InchargeUpdate = Trim$(rs3531!K3531_InchargeUpdate)
    If IsdbNull(rs3531!K3531_Remark) = False Then D3531.Remark = Trim$(rs3531!K3531_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3531_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K3531_MOVE(rs3531 As DataRow)
Try

    call D3531_CLEAR()   

    If IsdbNull(rs3531!K3531_MCStandardCode) = False Then D3531.MCStandardCode = Trim$(rs3531!K3531_MCStandardCode)
    If IsdbNull(rs3531!K3531_MCStandardCodeSeq) = False Then D3531.MCStandardCodeSeq = Trim$(rs3531!K3531_MCStandardCodeSeq)
    If IsdbNull(rs3531!K3531_Dseq) = False Then D3531.Dseq = Trim$(rs3531!K3531_Dseq)
    If IsdbNull(rs3531!K3531_seStandardMC) = False Then D3531.seStandardMC = Trim$(rs3531!K3531_seStandardMC)
    If IsdbNull(rs3531!K3531_cdStandardMC) = False Then D3531.cdStandardMC = Trim$(rs3531!K3531_cdStandardMC)
    If IsdbNull(rs3531!K3531_Value1) = False Then D3531.Value1 = Trim$(rs3531!K3531_Value1)
    If IsdbNull(rs3531!K3531_Value2) = False Then D3531.Value2 = Trim$(rs3531!K3531_Value2)
    If IsdbNull(rs3531!K3531_Value3) = False Then D3531.Value3 = Trim$(rs3531!K3531_Value3)
    If IsdbNull(rs3531!K3531_Value4) = False Then D3531.Value4 = Trim$(rs3531!K3531_Value4)
    If IsdbNull(rs3531!K3531_Value5) = False Then D3531.Value5 = Trim$(rs3531!K3531_Value5)
    If IsdbNull(rs3531!K3531_InsertDate) = False Then D3531.InsertDate = Trim$(rs3531!K3531_InsertDate)
    If IsdbNull(rs3531!K3531_InchargeInsert) = False Then D3531.InchargeInsert = Trim$(rs3531!K3531_InchargeInsert)
    If IsdbNull(rs3531!K3531_UpdateDate) = False Then D3531.UpdateDate = Trim$(rs3531!K3531_UpdateDate)
    If IsdbNull(rs3531!K3531_InchargeUpdate) = False Then D3531.InchargeUpdate = Trim$(rs3531!K3531_InchargeUpdate)
    If IsdbNull(rs3531!K3531_Remark) = False Then D3531.Remark = Trim$(rs3531!K3531_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3531_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K3531_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3531 As T3531_AREA, MCSTANDARDCODE AS String, MCSTANDARDCODESEQ AS Double) as Boolean

K3531_MOVE = False

Try
    If READ_PFK3531(MCSTANDARDCODE, MCSTANDARDCODESEQ) = True Then
                z3531 = D3531
		K3531_MOVE = True
		else
	z3531 = nothing
     End If

     If  getColumIndex(spr,"MCStandardCode") > -1 then z3531.MCStandardCode = getDataM(spr, getColumIndex(spr,"MCStandardCode"), xRow)
     If  getColumIndex(spr,"MCStandardCodeSeq") > -1 then z3531.MCStandardCodeSeq = getDataM(spr, getColumIndex(spr,"MCStandardCodeSeq"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z3531.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"seStandardMC") > -1 then z3531.seStandardMC = getDataM(spr, getColumIndex(spr,"seStandardMC"), xRow)
     If  getColumIndex(spr,"cdStandardMC") > -1 then z3531.cdStandardMC = getDataM(spr, getColumIndex(spr,"cdStandardMC"), xRow)
     If  getColumIndex(spr,"Value1") > -1 then z3531.Value1 = getDataM(spr, getColumIndex(spr,"Value1"), xRow)
     If  getColumIndex(spr,"Value2") > -1 then z3531.Value2 = getDataM(spr, getColumIndex(spr,"Value2"), xRow)
     If  getColumIndex(spr,"Value3") > -1 then z3531.Value3 = getDataM(spr, getColumIndex(spr,"Value3"), xRow)
     If  getColumIndex(spr,"Value4") > -1 then z3531.Value4 = getDataM(spr, getColumIndex(spr,"Value4"), xRow)
     If  getColumIndex(spr,"Value5") > -1 then z3531.Value5 = getDataM(spr, getColumIndex(spr,"Value5"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z3531.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z3531.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z3531.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z3531.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z3531.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3531_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K3531_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3531 As T3531_AREA,CheckClear as Boolean,MCSTANDARDCODE AS String, MCSTANDARDCODESEQ AS Double) as Boolean

K3531_MOVE = False

Try
    If READ_PFK3531(MCSTANDARDCODE, MCSTANDARDCODESEQ) = True Then
                z3531 = D3531
		K3531_MOVE = True
		else
	If CheckClear  = True then z3531 = nothing
     End If

     If  getColumIndex(spr,"MCStandardCode") > -1 then z3531.MCStandardCode = getDataM(spr, getColumIndex(spr,"MCStandardCode"), xRow)
     If  getColumIndex(spr,"MCStandardCodeSeq") > -1 then z3531.MCStandardCodeSeq = getDataM(spr, getColumIndex(spr,"MCStandardCodeSeq"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z3531.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"seStandardMC") > -1 then z3531.seStandardMC = getDataM(spr, getColumIndex(spr,"seStandardMC"), xRow)
     If  getColumIndex(spr,"cdStandardMC") > -1 then z3531.cdStandardMC = getDataM(spr, getColumIndex(spr,"cdStandardMC"), xRow)
     If  getColumIndex(spr,"Value1") > -1 then z3531.Value1 = getDataM(spr, getColumIndex(spr,"Value1"), xRow)
     If  getColumIndex(spr,"Value2") > -1 then z3531.Value2 = getDataM(spr, getColumIndex(spr,"Value2"), xRow)
     If  getColumIndex(spr,"Value3") > -1 then z3531.Value3 = getDataM(spr, getColumIndex(spr,"Value3"), xRow)
     If  getColumIndex(spr,"Value4") > -1 then z3531.Value4 = getDataM(spr, getColumIndex(spr,"Value4"), xRow)
     If  getColumIndex(spr,"Value5") > -1 then z3531.Value5 = getDataM(spr, getColumIndex(spr,"Value5"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z3531.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z3531.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z3531.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z3531.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z3531.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3531_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K3531_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3531 As T3531_AREA, Job as String, MCSTANDARDCODE AS String, MCSTANDARDCODESEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3531_MOVE = False

Try
    If READ_PFK3531(MCSTANDARDCODE, MCSTANDARDCODESEQ) = True Then
                z3531 = D3531
		K3531_MOVE = True
		else
	z3531 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3531")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "MCSTANDARDCODE":z3531.MCStandardCode = Children(i).Code
   Case "MCSTANDARDCODESEQ":z3531.MCStandardCodeSeq = Children(i).Code
   Case "DSEQ":z3531.Dseq = Children(i).Code
   Case "SESTANDARDMC":z3531.seStandardMC = Children(i).Code
   Case "CDSTANDARDMC":z3531.cdStandardMC = Children(i).Code
   Case "VALUE1":z3531.Value1 = Children(i).Code
   Case "VALUE2":z3531.Value2 = Children(i).Code
   Case "VALUE3":z3531.Value3 = Children(i).Code
   Case "VALUE4":z3531.Value4 = Children(i).Code
   Case "VALUE5":z3531.Value5 = Children(i).Code
   Case "INSERTDATE":z3531.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z3531.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z3531.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z3531.InchargeUpdate = Children(i).Code
   Case "REMARK":z3531.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "MCSTANDARDCODE":z3531.MCStandardCode = Children(i).Data
   Case "MCSTANDARDCODESEQ":z3531.MCStandardCodeSeq = Children(i).Data
   Case "DSEQ":z3531.Dseq = Children(i).Data
   Case "SESTANDARDMC":z3531.seStandardMC = Children(i).Data
   Case "CDSTANDARDMC":z3531.cdStandardMC = Children(i).Data
   Case "VALUE1":z3531.Value1 = Children(i).Data
   Case "VALUE2":z3531.Value2 = Children(i).Data
   Case "VALUE3":z3531.Value3 = Children(i).Data
   Case "VALUE4":z3531.Value4 = Children(i).Data
   Case "VALUE5":z3531.Value5 = Children(i).Data
   Case "INSERTDATE":z3531.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z3531.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z3531.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z3531.InchargeUpdate = Children(i).Data
   Case "REMARK":z3531.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3531_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K3531_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3531 As T3531_AREA, Job as String, CheckClear as Boolean, MCSTANDARDCODE AS String, MCSTANDARDCODESEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3531_MOVE = False

Try
    If READ_PFK3531(MCSTANDARDCODE, MCSTANDARDCODESEQ) = True Then
                z3531 = D3531
		K3531_MOVE = True
		else
	If CheckClear  = True then z3531 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3531")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "MCSTANDARDCODE":z3531.MCStandardCode = Children(i).Code
   Case "MCSTANDARDCODESEQ":z3531.MCStandardCodeSeq = Children(i).Code
   Case "DSEQ":z3531.Dseq = Children(i).Code
   Case "SESTANDARDMC":z3531.seStandardMC = Children(i).Code
   Case "CDSTANDARDMC":z3531.cdStandardMC = Children(i).Code
   Case "VALUE1":z3531.Value1 = Children(i).Code
   Case "VALUE2":z3531.Value2 = Children(i).Code
   Case "VALUE3":z3531.Value3 = Children(i).Code
   Case "VALUE4":z3531.Value4 = Children(i).Code
   Case "VALUE5":z3531.Value5 = Children(i).Code
   Case "INSERTDATE":z3531.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z3531.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z3531.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z3531.InchargeUpdate = Children(i).Code
   Case "REMARK":z3531.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "MCSTANDARDCODE":z3531.MCStandardCode = Children(i).Data
   Case "MCSTANDARDCODESEQ":z3531.MCStandardCodeSeq = Children(i).Data
   Case "DSEQ":z3531.Dseq = Children(i).Data
   Case "SESTANDARDMC":z3531.seStandardMC = Children(i).Data
   Case "CDSTANDARDMC":z3531.cdStandardMC = Children(i).Data
   Case "VALUE1":z3531.Value1 = Children(i).Data
   Case "VALUE2":z3531.Value2 = Children(i).Data
   Case "VALUE3":z3531.Value3 = Children(i).Data
   Case "VALUE4":z3531.Value4 = Children(i).Data
   Case "VALUE5":z3531.Value5 = Children(i).Data
   Case "INSERTDATE":z3531.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z3531.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z3531.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z3531.InchargeUpdate = Children(i).Data
   Case "REMARK":z3531.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3531_MOVE",vbCritical)
End Try
End Function 
    
End Module 
