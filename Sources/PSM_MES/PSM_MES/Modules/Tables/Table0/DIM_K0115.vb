'=========================================================================================================================================================
'   TABLE : (PFK0115)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K0115

Structure T0115_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	SpecNo	 AS String	'			char(9)		*
Public 	SpecNoSeq	 AS String	'			char(3)		*
Public 	MaterialSeq	 AS Double	'			decimal		*
Public 	MaterialSno	 AS Double	'			decimal		*
Public 	DSeq	 AS Double	'			decimal
Public 	Status	 AS String	'			char(1)
Public 	MaterialCode	 AS String	'			char(6)
Public 	Qty	 AS Double	'			decimal
Public 	Loss	 AS Double	'			decimal
Public 	PriceMaterial	 AS Double	'			decimal
Public 	AMTMaterial	 AS Double	'			decimal
Public 	InsertDate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(6)
Public 	UpdateDate	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(6)
Public 	Remark	 AS String	'			nvarchar(50)
'=========================================================================================================================================================
End structure

Public D0115 As T0115_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK0115(SPECNO AS String, SPECNOSEQ AS String, MATERIALSEQ AS Double, MATERIALSNO AS Double) As Boolean
    READ_PFK0115 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0115 "
    SQL = SQL & " WHERE K0115_SpecNo		 = '" & SpecNo & "' " 
    SQL = SQL & "   AND K0115_SpecNoSeq		 = '" & SpecNoSeq & "' " 
    SQL = SQL & "   AND K0115_MaterialSeq		 =  " & MaterialSeq & "  " 
    SQL = SQL & "   AND K0115_MaterialSno		 =  " & MaterialSno & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D0115_CLEAR: GoTo SKIP_READ_PFK0115
                
    Call K0115_MOVE(rd)
    READ_PFK0115 = True

SKIP_READ_PFK0115:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK0115",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK0115(SPECNO AS String, SPECNOSEQ AS String, MATERIALSEQ AS Double, MATERIALSNO AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0115 "
    SQL = SQL & " WHERE K0115_SpecNo		 = '" & SpecNo & "' " 
    SQL = SQL & "   AND K0115_SpecNoSeq		 = '" & SpecNoSeq & "' " 
    SQL = SQL & "   AND K0115_MaterialSeq		 =  " & MaterialSeq & "  " 
    SQL = SQL & "   AND K0115_MaterialSno		 =  " & MaterialSno & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK0115",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK0115(z0115 As T0115_AREA) As Boolean
    WRITE_PFK0115 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z0115)
 
    SQL = " INSERT INTO PFK0115 "
    SQL = SQL & " ( "
    SQL = SQL & " K0115_SpecNo," 
    SQL = SQL & " K0115_SpecNoSeq," 
    SQL = SQL & " K0115_MaterialSeq," 
    SQL = SQL & " K0115_MaterialSno," 
    SQL = SQL & " K0115_DSeq," 
    SQL = SQL & " K0115_Status," 
    SQL = SQL & " K0115_MaterialCode," 
    SQL = SQL & " K0115_Qty," 
    SQL = SQL & " K0115_Loss," 
    SQL = SQL & " K0115_PriceMaterial," 
    SQL = SQL & " K0115_AMTMaterial," 
    SQL = SQL & " K0115_InsertDate," 
    SQL = SQL & " K0115_InchargeInsert," 
    SQL = SQL & " K0115_UpdateDate," 
    SQL = SQL & " K0115_InchargeUpdate," 
    SQL = SQL & " K0115_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z0115.SpecNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0115.SpecNoSeq) & "', "  
    SQL = SQL & "   " & FormatSQL(z0115.MaterialSeq) & ", "  
    SQL = SQL & "   " & FormatSQL(z0115.MaterialSno) & ", "  
    SQL = SQL & "   " & FormatSQL(z0115.DSeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z0115.Status) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0115.MaterialCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z0115.Qty) & ", "  
    SQL = SQL & "   " & FormatSQL(z0115.Loss) & ", "  
    SQL = SQL & "   " & FormatSQL(z0115.PriceMaterial) & ", "  
    SQL = SQL & "   " & FormatSQL(z0115.AMTMaterial) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z0115.InsertDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0115.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0115.UpdateDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0115.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0115.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK0115 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK0115",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK0115(z0115 As T0115_AREA) As Boolean
    REWRITE_PFK0115 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z0115)
   
    SQL = " UPDATE PFK0115 SET "
    SQL = SQL & "    K0115_DSeq      =  " & FormatSQL(z0115.DSeq) & ", " 
    SQL = SQL & "    K0115_Status      = N'" & FormatSQL(z0115.Status) & "', " 
    SQL = SQL & "    K0115_MaterialCode      = N'" & FormatSQL(z0115.MaterialCode) & "', " 
    SQL = SQL & "    K0115_Qty      =  " & FormatSQL(z0115.Qty) & ", " 
    SQL = SQL & "    K0115_Loss      =  " & FormatSQL(z0115.Loss) & ", " 
    SQL = SQL & "    K0115_PriceMaterial      =  " & FormatSQL(z0115.PriceMaterial) & ", " 
    SQL = SQL & "    K0115_AMTMaterial      =  " & FormatSQL(z0115.AMTMaterial) & ", " 
    SQL = SQL & "    K0115_InsertDate      = N'" & FormatSQL(z0115.InsertDate) & "', " 
    SQL = SQL & "    K0115_InchargeInsert      = N'" & FormatSQL(z0115.InchargeInsert) & "', " 
    SQL = SQL & "    K0115_UpdateDate      = N'" & FormatSQL(z0115.UpdateDate) & "', " 
    SQL = SQL & "    K0115_InchargeUpdate      = N'" & FormatSQL(z0115.InchargeUpdate) & "', " 
    SQL = SQL & "    K0115_Remark      = N'" & FormatSQL(z0115.Remark) & "'  " 
    SQL = SQL & " WHERE K0115_SpecNo		 = '" & z0115.SpecNo & "' " 
    SQL = SQL & "   AND K0115_SpecNoSeq		 = '" & z0115.SpecNoSeq & "' " 
    SQL = SQL & "   AND K0115_MaterialSeq		 =  " & z0115.MaterialSeq & "  " 
    SQL = SQL & "   AND K0115_MaterialSno		 =  " & z0115.MaterialSno & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK0115 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK0115",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK0115(z0115 As T0115_AREA) As Boolean
    DELETE_PFK0115 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK0115 "
    SQL = SQL & " WHERE K0115_SpecNo		 = '" & z0115.SpecNo & "' " 
    SQL = SQL & "   AND K0115_SpecNoSeq		 = '" & z0115.SpecNoSeq & "' " 
    SQL = SQL & "   AND K0115_MaterialSeq		 =  " & z0115.MaterialSeq & "  " 
    SQL = SQL & "   AND K0115_MaterialSno		 =  " & z0115.MaterialSno & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK0115 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK0115",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D0115_CLEAR()
Try
    
   D0115.SpecNo = ""
   D0115.SpecNoSeq = ""
    D0115.MaterialSeq = 0 
    D0115.MaterialSno = 0 
    D0115.DSeq = 0 
   D0115.Status = ""
   D0115.MaterialCode = ""
    D0115.Qty = 0 
    D0115.Loss = 0 
    D0115.PriceMaterial = 0 
    D0115.AMTMaterial = 0 
   D0115.InsertDate = ""
   D0115.InchargeInsert = ""
   D0115.UpdateDate = ""
   D0115.InchargeUpdate = ""
   D0115.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D0115_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x0115 As T0115_AREA)
Try
    
    x0115.SpecNo = trim$(  x0115.SpecNo)
    x0115.SpecNoSeq = trim$(  x0115.SpecNoSeq)
    x0115.MaterialSeq = trim$(  x0115.MaterialSeq)
    x0115.MaterialSno = trim$(  x0115.MaterialSno)
    x0115.DSeq = trim$(  x0115.DSeq)
    x0115.Status = trim$(  x0115.Status)
    x0115.MaterialCode = trim$(  x0115.MaterialCode)
    x0115.Qty = trim$(  x0115.Qty)
    x0115.Loss = trim$(  x0115.Loss)
    x0115.PriceMaterial = trim$(  x0115.PriceMaterial)
    x0115.AMTMaterial = trim$(  x0115.AMTMaterial)
    x0115.InsertDate = trim$(  x0115.InsertDate)
    x0115.InchargeInsert = trim$(  x0115.InchargeInsert)
    x0115.UpdateDate = trim$(  x0115.UpdateDate)
    x0115.InchargeUpdate = trim$(  x0115.InchargeUpdate)
    x0115.Remark = trim$(  x0115.Remark)
     
    If trim$( x0115.SpecNo ) = "" Then x0115.SpecNo = Space(1) 
    If trim$( x0115.SpecNoSeq ) = "" Then x0115.SpecNoSeq = Space(1) 
    If trim$( x0115.MaterialSeq ) = "" Then x0115.MaterialSeq = 0 
    If trim$( x0115.MaterialSno ) = "" Then x0115.MaterialSno = 0 
    If trim$( x0115.DSeq ) = "" Then x0115.DSeq = 0 
    If trim$( x0115.Status ) = "" Then x0115.Status = Space(1) 
    If trim$( x0115.MaterialCode ) = "" Then x0115.MaterialCode = Space(1) 
    If trim$( x0115.Qty ) = "" Then x0115.Qty = 0 
    If trim$( x0115.Loss ) = "" Then x0115.Loss = 0 
    If trim$( x0115.PriceMaterial ) = "" Then x0115.PriceMaterial = 0 
    If trim$( x0115.AMTMaterial ) = "" Then x0115.AMTMaterial = 0 
    If trim$( x0115.InsertDate ) = "" Then x0115.InsertDate = Space(1) 
    If trim$( x0115.InchargeInsert ) = "" Then x0115.InchargeInsert = Space(1) 
    If trim$( x0115.UpdateDate ) = "" Then x0115.UpdateDate = Space(1) 
    If trim$( x0115.InchargeUpdate ) = "" Then x0115.InchargeUpdate = Space(1) 
    If trim$( x0115.Remark ) = "" Then x0115.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K0115_MOVE(rs0115 As SqlClient.SqlDataReader)
Try

    call D0115_CLEAR()   

    If IsdbNull(rs0115!K0115_SpecNo) = False Then D0115.SpecNo = Trim$(rs0115!K0115_SpecNo)
    If IsdbNull(rs0115!K0115_SpecNoSeq) = False Then D0115.SpecNoSeq = Trim$(rs0115!K0115_SpecNoSeq)
    If IsdbNull(rs0115!K0115_MaterialSeq) = False Then D0115.MaterialSeq = Trim$(rs0115!K0115_MaterialSeq)
    If IsdbNull(rs0115!K0115_MaterialSno) = False Then D0115.MaterialSno = Trim$(rs0115!K0115_MaterialSno)
    If IsdbNull(rs0115!K0115_DSeq) = False Then D0115.DSeq = Trim$(rs0115!K0115_DSeq)
    If IsdbNull(rs0115!K0115_Status) = False Then D0115.Status = Trim$(rs0115!K0115_Status)
    If IsdbNull(rs0115!K0115_MaterialCode) = False Then D0115.MaterialCode = Trim$(rs0115!K0115_MaterialCode)
    If IsdbNull(rs0115!K0115_Qty) = False Then D0115.Qty = Trim$(rs0115!K0115_Qty)
    If IsdbNull(rs0115!K0115_Loss) = False Then D0115.Loss = Trim$(rs0115!K0115_Loss)
    If IsdbNull(rs0115!K0115_PriceMaterial) = False Then D0115.PriceMaterial = Trim$(rs0115!K0115_PriceMaterial)
    If IsdbNull(rs0115!K0115_AMTMaterial) = False Then D0115.AMTMaterial = Trim$(rs0115!K0115_AMTMaterial)
    If IsdbNull(rs0115!K0115_InsertDate) = False Then D0115.InsertDate = Trim$(rs0115!K0115_InsertDate)
    If IsdbNull(rs0115!K0115_InchargeInsert) = False Then D0115.InchargeInsert = Trim$(rs0115!K0115_InchargeInsert)
    If IsdbNull(rs0115!K0115_UpdateDate) = False Then D0115.UpdateDate = Trim$(rs0115!K0115_UpdateDate)
    If IsdbNull(rs0115!K0115_InchargeUpdate) = False Then D0115.InchargeUpdate = Trim$(rs0115!K0115_InchargeUpdate)
    If IsdbNull(rs0115!K0115_Remark) = False Then D0115.Remark = Trim$(rs0115!K0115_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0115_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K0115_MOVE(rs0115 As DataRow)
Try

    call D0115_CLEAR()   

    If IsdbNull(rs0115!K0115_SpecNo) = False Then D0115.SpecNo = Trim$(rs0115!K0115_SpecNo)
    If IsdbNull(rs0115!K0115_SpecNoSeq) = False Then D0115.SpecNoSeq = Trim$(rs0115!K0115_SpecNoSeq)
    If IsdbNull(rs0115!K0115_MaterialSeq) = False Then D0115.MaterialSeq = Trim$(rs0115!K0115_MaterialSeq)
    If IsdbNull(rs0115!K0115_MaterialSno) = False Then D0115.MaterialSno = Trim$(rs0115!K0115_MaterialSno)
    If IsdbNull(rs0115!K0115_DSeq) = False Then D0115.DSeq = Trim$(rs0115!K0115_DSeq)
    If IsdbNull(rs0115!K0115_Status) = False Then D0115.Status = Trim$(rs0115!K0115_Status)
    If IsdbNull(rs0115!K0115_MaterialCode) = False Then D0115.MaterialCode = Trim$(rs0115!K0115_MaterialCode)
    If IsdbNull(rs0115!K0115_Qty) = False Then D0115.Qty = Trim$(rs0115!K0115_Qty)
    If IsdbNull(rs0115!K0115_Loss) = False Then D0115.Loss = Trim$(rs0115!K0115_Loss)
    If IsdbNull(rs0115!K0115_PriceMaterial) = False Then D0115.PriceMaterial = Trim$(rs0115!K0115_PriceMaterial)
    If IsdbNull(rs0115!K0115_AMTMaterial) = False Then D0115.AMTMaterial = Trim$(rs0115!K0115_AMTMaterial)
    If IsdbNull(rs0115!K0115_InsertDate) = False Then D0115.InsertDate = Trim$(rs0115!K0115_InsertDate)
    If IsdbNull(rs0115!K0115_InchargeInsert) = False Then D0115.InchargeInsert = Trim$(rs0115!K0115_InchargeInsert)
    If IsdbNull(rs0115!K0115_UpdateDate) = False Then D0115.UpdateDate = Trim$(rs0115!K0115_UpdateDate)
    If IsdbNull(rs0115!K0115_InchargeUpdate) = False Then D0115.InchargeUpdate = Trim$(rs0115!K0115_InchargeUpdate)
    If IsdbNull(rs0115!K0115_Remark) = False Then D0115.Remark = Trim$(rs0115!K0115_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0115_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K0115_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0115 As T0115_AREA, SPECNO AS String, SPECNOSEQ AS String, MATERIALSEQ AS Double, MATERIALSNO AS Double) as Boolean

K0115_MOVE = False

Try
    If READ_PFK0115(SPECNO, SPECNOSEQ, MATERIALSEQ, MATERIALSNO) = True Then
                z0115 = D0115
		K0115_MOVE = True
		else
	z0115 = nothing
     End If

     If  getColumIndex(spr,"SpecNo") > -1 then z0115.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z0115.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"MaterialSeq") > -1 then z0115.MaterialSeq = getDataM(spr, getColumIndex(spr,"MaterialSeq"), xRow)
     If  getColumIndex(spr,"MaterialSno") > -1 then z0115.MaterialSno = getDataM(spr, getColumIndex(spr,"MaterialSno"), xRow)
     If  getColumIndex(spr,"DSeq") > -1 then z0115.DSeq = getDataM(spr, getColumIndex(spr,"DSeq"), xRow)
     If  getColumIndex(spr,"Status") > -1 then z0115.Status = getDataM(spr, getColumIndex(spr,"Status"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z0115.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"Qty") > -1 then z0115.Qty = getDataM(spr, getColumIndex(spr,"Qty"), xRow)
     If  getColumIndex(spr,"Loss") > -1 then z0115.Loss = getDataM(spr, getColumIndex(spr,"Loss"), xRow)
     If  getColumIndex(spr,"PriceMaterial") > -1 then z0115.PriceMaterial = getDataM(spr, getColumIndex(spr,"PriceMaterial"), xRow)
     If  getColumIndex(spr,"AMTMaterial") > -1 then z0115.AMTMaterial = getDataM(spr, getColumIndex(spr,"AMTMaterial"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z0115.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z0115.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z0115.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z0115.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0115.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0115_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K0115_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0115 As T0115_AREA,CheckClear as Boolean,SPECNO AS String, SPECNOSEQ AS String, MATERIALSEQ AS Double, MATERIALSNO AS Double) as Boolean

K0115_MOVE = False

Try
    If READ_PFK0115(SPECNO, SPECNOSEQ, MATERIALSEQ, MATERIALSNO) = True Then
                z0115 = D0115
		K0115_MOVE = True
		else
	If CheckClear  = True then z0115 = nothing
     End If

     If  getColumIndex(spr,"SpecNo") > -1 then z0115.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z0115.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"MaterialSeq") > -1 then z0115.MaterialSeq = getDataM(spr, getColumIndex(spr,"MaterialSeq"), xRow)
     If  getColumIndex(spr,"MaterialSno") > -1 then z0115.MaterialSno = getDataM(spr, getColumIndex(spr,"MaterialSno"), xRow)
     If  getColumIndex(spr,"DSeq") > -1 then z0115.DSeq = getDataM(spr, getColumIndex(spr,"DSeq"), xRow)
     If  getColumIndex(spr,"Status") > -1 then z0115.Status = getDataM(spr, getColumIndex(spr,"Status"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z0115.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"Qty") > -1 then z0115.Qty = getDataM(spr, getColumIndex(spr,"Qty"), xRow)
     If  getColumIndex(spr,"Loss") > -1 then z0115.Loss = getDataM(spr, getColumIndex(spr,"Loss"), xRow)
     If  getColumIndex(spr,"PriceMaterial") > -1 then z0115.PriceMaterial = getDataM(spr, getColumIndex(spr,"PriceMaterial"), xRow)
     If  getColumIndex(spr,"AMTMaterial") > -1 then z0115.AMTMaterial = getDataM(spr, getColumIndex(spr,"AMTMaterial"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z0115.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z0115.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z0115.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z0115.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0115.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0115_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K0115_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0115 As T0115_AREA, Job as String, SPECNO AS String, SPECNOSEQ AS String, MATERIALSEQ AS Double, MATERIALSNO AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0115_MOVE = False

Try
    If READ_PFK0115(SPECNO, SPECNOSEQ, MATERIALSEQ, MATERIALSNO) = True Then
                z0115 = D0115
		K0115_MOVE = True
		else
	z0115 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0115")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SPECNO":z0115.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z0115.SpecNoSeq = Children(i).Code
   Case "MATERIALSEQ":z0115.MaterialSeq = Children(i).Code
   Case "MATERIALSNO":z0115.MaterialSno = Children(i).Code
   Case "DSEQ":z0115.DSeq = Children(i).Code
   Case "STATUS":z0115.Status = Children(i).Code
   Case "MATERIALCODE":z0115.MaterialCode = Children(i).Code
   Case "QTY":z0115.Qty = Children(i).Code
   Case "LOSS":z0115.Loss = Children(i).Code
   Case "PRICEMATERIAL":z0115.PriceMaterial = Children(i).Code
   Case "AMTMATERIAL":z0115.AMTMaterial = Children(i).Code
   Case "INSERTDATE":z0115.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z0115.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z0115.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z0115.InchargeUpdate = Children(i).Code
   Case "REMARK":z0115.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SPECNO":z0115.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z0115.SpecNoSeq = Children(i).Data
   Case "MATERIALSEQ":z0115.MaterialSeq = Children(i).Data
   Case "MATERIALSNO":z0115.MaterialSno = Children(i).Data
   Case "DSEQ":z0115.DSeq = Children(i).Data
   Case "STATUS":z0115.Status = Children(i).Data
   Case "MATERIALCODE":z0115.MaterialCode = Children(i).Data
   Case "QTY":z0115.Qty = Children(i).Data
   Case "LOSS":z0115.Loss = Children(i).Data
   Case "PRICEMATERIAL":z0115.PriceMaterial = Children(i).Data
   Case "AMTMATERIAL":z0115.AMTMaterial = Children(i).Data
   Case "INSERTDATE":z0115.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z0115.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z0115.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z0115.InchargeUpdate = Children(i).Data
   Case "REMARK":z0115.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0115_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K0115_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0115 As T0115_AREA, Job as String, CheckClear as Boolean, SPECNO AS String, SPECNOSEQ AS String, MATERIALSEQ AS Double, MATERIALSNO AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0115_MOVE = False

Try
    If READ_PFK0115(SPECNO, SPECNOSEQ, MATERIALSEQ, MATERIALSNO) = True Then
                z0115 = D0115
		K0115_MOVE = True
		else
	If CheckClear  = True then z0115 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0115")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SPECNO":z0115.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z0115.SpecNoSeq = Children(i).Code
   Case "MATERIALSEQ":z0115.MaterialSeq = Children(i).Code
   Case "MATERIALSNO":z0115.MaterialSno = Children(i).Code
   Case "DSEQ":z0115.DSeq = Children(i).Code
   Case "STATUS":z0115.Status = Children(i).Code
   Case "MATERIALCODE":z0115.MaterialCode = Children(i).Code
   Case "QTY":z0115.Qty = Children(i).Code
   Case "LOSS":z0115.Loss = Children(i).Code
   Case "PRICEMATERIAL":z0115.PriceMaterial = Children(i).Code
   Case "AMTMATERIAL":z0115.AMTMaterial = Children(i).Code
   Case "INSERTDATE":z0115.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z0115.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z0115.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z0115.InchargeUpdate = Children(i).Code
   Case "REMARK":z0115.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SPECNO":z0115.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z0115.SpecNoSeq = Children(i).Data
   Case "MATERIALSEQ":z0115.MaterialSeq = Children(i).Data
   Case "MATERIALSNO":z0115.MaterialSno = Children(i).Data
   Case "DSEQ":z0115.DSeq = Children(i).Data
   Case "STATUS":z0115.Status = Children(i).Data
   Case "MATERIALCODE":z0115.MaterialCode = Children(i).Data
   Case "QTY":z0115.Qty = Children(i).Data
   Case "LOSS":z0115.Loss = Children(i).Data
   Case "PRICEMATERIAL":z0115.PriceMaterial = Children(i).Data
   Case "AMTMATERIAL":z0115.AMTMaterial = Children(i).Data
   Case "INSERTDATE":z0115.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z0115.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z0115.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z0115.InchargeUpdate = Children(i).Data
   Case "REMARK":z0115.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0115_MOVE",vbCritical)
End Try
End Function 
    
End Module 
