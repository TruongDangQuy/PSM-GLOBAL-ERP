'=========================================================================================================================================================
'   TABLE : (PFK0130)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K0130

Structure T0130_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	SpecNo	 AS String	'			char(9)		*
Public 	SpecNoSeq	 AS String	'			char(3)		*
Public 	AddCostSeq	 AS Double	'			decimal		*
Public 	Dseq	 AS Double	'			decimal
Public 	Status	 AS String	'			char(1)
Public 	seAdditionalCost	 AS String	'			char(3)
Public 	cdAdditionalCost	 AS String	'			char(3)
Public 	seCostingType	 AS String	'			char(3)
Public 	cdCostingType	 AS String	'			char(3)
Public 	Price	 AS Double	'			decimal
Public 	QtyAdditional	 AS Double	'			decimal
Public 	AdditionalAMT	 AS Double	'			decimal
Public 	InsertDate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(6)
Public 	UpdateDate	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	AttachID	 AS String	'			char(6)
Public 	Remark	 AS String	'			nvarchar(50)
'=========================================================================================================================================================
End structure

Public D0130 As T0130_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK0130(SPECNO AS String, SPECNOSEQ AS String, ADDCOSTSEQ AS Double) As Boolean
    READ_PFK0130 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0130 "
    SQL = SQL & " WHERE K0130_SpecNo		 = '" & SpecNo & "' " 
    SQL = SQL & "   AND K0130_SpecNoSeq		 = '" & SpecNoSeq & "' " 
    SQL = SQL & "   AND K0130_AddCostSeq		 =  " & AddCostSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D0130_CLEAR: GoTo SKIP_READ_PFK0130
                
    Call K0130_MOVE(rd)
    READ_PFK0130 = True

SKIP_READ_PFK0130:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK0130",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK0130(SPECNO AS String, SPECNOSEQ AS String, ADDCOSTSEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0130 "
    SQL = SQL & " WHERE K0130_SpecNo		 = '" & SpecNo & "' " 
    SQL = SQL & "   AND K0130_SpecNoSeq		 = '" & SpecNoSeq & "' " 
    SQL = SQL & "   AND K0130_AddCostSeq		 =  " & AddCostSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK0130",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK0130(z0130 As T0130_AREA) As Boolean
    WRITE_PFK0130 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z0130)
 
    SQL = " INSERT INTO PFK0130 "
    SQL = SQL & " ( "
    SQL = SQL & " K0130_SpecNo," 
    SQL = SQL & " K0130_SpecNoSeq," 
    SQL = SQL & " K0130_AddCostSeq," 
    SQL = SQL & " K0130_Dseq," 
    SQL = SQL & " K0130_Status," 
    SQL = SQL & " K0130_seAdditionalCost," 
    SQL = SQL & " K0130_cdAdditionalCost," 
    SQL = SQL & " K0130_seCostingType," 
    SQL = SQL & " K0130_cdCostingType," 
    SQL = SQL & " K0130_Price," 
    SQL = SQL & " K0130_QtyAdditional," 
    SQL = SQL & " K0130_AdditionalAMT," 
    SQL = SQL & " K0130_InsertDate," 
    SQL = SQL & " K0130_InchargeInsert," 
    SQL = SQL & " K0130_UpdateDate," 
    SQL = SQL & " K0130_InchargeUpdate," 
    SQL = SQL & " K0130_AttachID," 
    SQL = SQL & " K0130_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z0130.SpecNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0130.SpecNoSeq) & "', "  
    SQL = SQL & "   " & FormatSQL(z0130.AddCostSeq) & ", "  
    SQL = SQL & "   " & FormatSQL(z0130.Dseq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z0130.Status) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0130.seAdditionalCost) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0130.cdAdditionalCost) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0130.seCostingType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0130.cdCostingType) & "', "  
    SQL = SQL & "   " & FormatSQL(z0130.Price) & ", "  
    SQL = SQL & "   " & FormatSQL(z0130.QtyAdditional) & ", "  
    SQL = SQL & "   " & FormatSQL(z0130.AdditionalAMT) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z0130.InsertDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0130.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0130.UpdateDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0130.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0130.AttachID) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0130.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK0130 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK0130",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK0130(z0130 As T0130_AREA) As Boolean
    REWRITE_PFK0130 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z0130)
   
    SQL = " UPDATE PFK0130 SET "
    SQL = SQL & "    K0130_Dseq      =  " & FormatSQL(z0130.Dseq) & ", " 
    SQL = SQL & "    K0130_Status      = N'" & FormatSQL(z0130.Status) & "', " 
    SQL = SQL & "    K0130_seAdditionalCost      = N'" & FormatSQL(z0130.seAdditionalCost) & "', " 
    SQL = SQL & "    K0130_cdAdditionalCost      = N'" & FormatSQL(z0130.cdAdditionalCost) & "', " 
    SQL = SQL & "    K0130_seCostingType      = N'" & FormatSQL(z0130.seCostingType) & "', " 
    SQL = SQL & "    K0130_cdCostingType      = N'" & FormatSQL(z0130.cdCostingType) & "', " 
    SQL = SQL & "    K0130_Price      =  " & FormatSQL(z0130.Price) & ", " 
    SQL = SQL & "    K0130_QtyAdditional      =  " & FormatSQL(z0130.QtyAdditional) & ", " 
    SQL = SQL & "    K0130_AdditionalAMT      =  " & FormatSQL(z0130.AdditionalAMT) & ", " 
    SQL = SQL & "    K0130_InsertDate      = N'" & FormatSQL(z0130.InsertDate) & "', " 
    SQL = SQL & "    K0130_InchargeInsert      = N'" & FormatSQL(z0130.InchargeInsert) & "', " 
    SQL = SQL & "    K0130_UpdateDate      = N'" & FormatSQL(z0130.UpdateDate) & "', " 
    SQL = SQL & "    K0130_InchargeUpdate      = N'" & FormatSQL(z0130.InchargeUpdate) & "', " 
    SQL = SQL & "    K0130_AttachID      = N'" & FormatSQL(z0130.AttachID) & "', " 
    SQL = SQL & "    K0130_Remark      = N'" & FormatSQL(z0130.Remark) & "'  " 
    SQL = SQL & " WHERE K0130_SpecNo		 = '" & z0130.SpecNo & "' " 
    SQL = SQL & "   AND K0130_SpecNoSeq		 = '" & z0130.SpecNoSeq & "' " 
    SQL = SQL & "   AND K0130_AddCostSeq		 =  " & z0130.AddCostSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK0130 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK0130",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK0130(z0130 As T0130_AREA) As Boolean
    DELETE_PFK0130 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK0130 "
    SQL = SQL & " WHERE K0130_SpecNo		 = '" & z0130.SpecNo & "' " 
    SQL = SQL & "   AND K0130_SpecNoSeq		 = '" & z0130.SpecNoSeq & "' " 
    SQL = SQL & "   AND K0130_AddCostSeq		 =  " & z0130.AddCostSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK0130 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK0130",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D0130_CLEAR()
Try
    
   D0130.SpecNo = ""
   D0130.SpecNoSeq = ""
    D0130.AddCostSeq = 0 
    D0130.Dseq = 0 
   D0130.Status = ""
   D0130.seAdditionalCost = ""
   D0130.cdAdditionalCost = ""
   D0130.seCostingType = ""
   D0130.cdCostingType = ""
    D0130.Price = 0 
    D0130.QtyAdditional = 0 
    D0130.AdditionalAMT = 0 
   D0130.InsertDate = ""
   D0130.InchargeInsert = ""
   D0130.UpdateDate = ""
   D0130.InchargeUpdate = ""
   D0130.AttachID = ""
   D0130.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D0130_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x0130 As T0130_AREA)
Try
    
    x0130.SpecNo = trim$(  x0130.SpecNo)
    x0130.SpecNoSeq = trim$(  x0130.SpecNoSeq)
    x0130.AddCostSeq = trim$(  x0130.AddCostSeq)
    x0130.Dseq = trim$(  x0130.Dseq)
    x0130.Status = trim$(  x0130.Status)
    x0130.seAdditionalCost = trim$(  x0130.seAdditionalCost)
    x0130.cdAdditionalCost = trim$(  x0130.cdAdditionalCost)
    x0130.seCostingType = trim$(  x0130.seCostingType)
    x0130.cdCostingType = trim$(  x0130.cdCostingType)
    x0130.Price = trim$(  x0130.Price)
    x0130.QtyAdditional = trim$(  x0130.QtyAdditional)
    x0130.AdditionalAMT = trim$(  x0130.AdditionalAMT)
    x0130.InsertDate = trim$(  x0130.InsertDate)
    x0130.InchargeInsert = trim$(  x0130.InchargeInsert)
    x0130.UpdateDate = trim$(  x0130.UpdateDate)
    x0130.InchargeUpdate = trim$(  x0130.InchargeUpdate)
    x0130.AttachID = trim$(  x0130.AttachID)
    x0130.Remark = trim$(  x0130.Remark)
     
    If trim$( x0130.SpecNo ) = "" Then x0130.SpecNo = Space(1) 
    If trim$( x0130.SpecNoSeq ) = "" Then x0130.SpecNoSeq = Space(1) 
    If trim$( x0130.AddCostSeq ) = "" Then x0130.AddCostSeq = 0 
    If trim$( x0130.Dseq ) = "" Then x0130.Dseq = 0 
    If trim$( x0130.Status ) = "" Then x0130.Status = Space(1) 
    If trim$( x0130.seAdditionalCost ) = "" Then x0130.seAdditionalCost = Space(1) 
    If trim$( x0130.cdAdditionalCost ) = "" Then x0130.cdAdditionalCost = Space(1) 
    If trim$( x0130.seCostingType ) = "" Then x0130.seCostingType = Space(1) 
    If trim$( x0130.cdCostingType ) = "" Then x0130.cdCostingType = Space(1) 
    If trim$( x0130.Price ) = "" Then x0130.Price = 0 
    If trim$( x0130.QtyAdditional ) = "" Then x0130.QtyAdditional = 0 
    If trim$( x0130.AdditionalAMT ) = "" Then x0130.AdditionalAMT = 0 
    If trim$( x0130.InsertDate ) = "" Then x0130.InsertDate = Space(1) 
    If trim$( x0130.InchargeInsert ) = "" Then x0130.InchargeInsert = Space(1) 
    If trim$( x0130.UpdateDate ) = "" Then x0130.UpdateDate = Space(1) 
    If trim$( x0130.InchargeUpdate ) = "" Then x0130.InchargeUpdate = Space(1) 
    If trim$( x0130.AttachID ) = "" Then x0130.AttachID = Space(1) 
    If trim$( x0130.Remark ) = "" Then x0130.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K0130_MOVE(rs0130 As SqlClient.SqlDataReader)
Try

    call D0130_CLEAR()   

    If IsdbNull(rs0130!K0130_SpecNo) = False Then D0130.SpecNo = Trim$(rs0130!K0130_SpecNo)
    If IsdbNull(rs0130!K0130_SpecNoSeq) = False Then D0130.SpecNoSeq = Trim$(rs0130!K0130_SpecNoSeq)
    If IsdbNull(rs0130!K0130_AddCostSeq) = False Then D0130.AddCostSeq = Trim$(rs0130!K0130_AddCostSeq)
    If IsdbNull(rs0130!K0130_Dseq) = False Then D0130.Dseq = Trim$(rs0130!K0130_Dseq)
    If IsdbNull(rs0130!K0130_Status) = False Then D0130.Status = Trim$(rs0130!K0130_Status)
    If IsdbNull(rs0130!K0130_seAdditionalCost) = False Then D0130.seAdditionalCost = Trim$(rs0130!K0130_seAdditionalCost)
    If IsdbNull(rs0130!K0130_cdAdditionalCost) = False Then D0130.cdAdditionalCost = Trim$(rs0130!K0130_cdAdditionalCost)
    If IsdbNull(rs0130!K0130_seCostingType) = False Then D0130.seCostingType = Trim$(rs0130!K0130_seCostingType)
    If IsdbNull(rs0130!K0130_cdCostingType) = False Then D0130.cdCostingType = Trim$(rs0130!K0130_cdCostingType)
    If IsdbNull(rs0130!K0130_Price) = False Then D0130.Price = Trim$(rs0130!K0130_Price)
    If IsdbNull(rs0130!K0130_QtyAdditional) = False Then D0130.QtyAdditional = Trim$(rs0130!K0130_QtyAdditional)
    If IsdbNull(rs0130!K0130_AdditionalAMT) = False Then D0130.AdditionalAMT = Trim$(rs0130!K0130_AdditionalAMT)
    If IsdbNull(rs0130!K0130_InsertDate) = False Then D0130.InsertDate = Trim$(rs0130!K0130_InsertDate)
    If IsdbNull(rs0130!K0130_InchargeInsert) = False Then D0130.InchargeInsert = Trim$(rs0130!K0130_InchargeInsert)
    If IsdbNull(rs0130!K0130_UpdateDate) = False Then D0130.UpdateDate = Trim$(rs0130!K0130_UpdateDate)
    If IsdbNull(rs0130!K0130_InchargeUpdate) = False Then D0130.InchargeUpdate = Trim$(rs0130!K0130_InchargeUpdate)
    If IsdbNull(rs0130!K0130_AttachID) = False Then D0130.AttachID = Trim$(rs0130!K0130_AttachID)
    If IsdbNull(rs0130!K0130_Remark) = False Then D0130.Remark = Trim$(rs0130!K0130_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0130_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K0130_MOVE(rs0130 As DataRow)
Try

    call D0130_CLEAR()   

    If IsdbNull(rs0130!K0130_SpecNo) = False Then D0130.SpecNo = Trim$(rs0130!K0130_SpecNo)
    If IsdbNull(rs0130!K0130_SpecNoSeq) = False Then D0130.SpecNoSeq = Trim$(rs0130!K0130_SpecNoSeq)
    If IsdbNull(rs0130!K0130_AddCostSeq) = False Then D0130.AddCostSeq = Trim$(rs0130!K0130_AddCostSeq)
    If IsdbNull(rs0130!K0130_Dseq) = False Then D0130.Dseq = Trim$(rs0130!K0130_Dseq)
    If IsdbNull(rs0130!K0130_Status) = False Then D0130.Status = Trim$(rs0130!K0130_Status)
    If IsdbNull(rs0130!K0130_seAdditionalCost) = False Then D0130.seAdditionalCost = Trim$(rs0130!K0130_seAdditionalCost)
    If IsdbNull(rs0130!K0130_cdAdditionalCost) = False Then D0130.cdAdditionalCost = Trim$(rs0130!K0130_cdAdditionalCost)
    If IsdbNull(rs0130!K0130_seCostingType) = False Then D0130.seCostingType = Trim$(rs0130!K0130_seCostingType)
    If IsdbNull(rs0130!K0130_cdCostingType) = False Then D0130.cdCostingType = Trim$(rs0130!K0130_cdCostingType)
    If IsdbNull(rs0130!K0130_Price) = False Then D0130.Price = Trim$(rs0130!K0130_Price)
    If IsdbNull(rs0130!K0130_QtyAdditional) = False Then D0130.QtyAdditional = Trim$(rs0130!K0130_QtyAdditional)
    If IsdbNull(rs0130!K0130_AdditionalAMT) = False Then D0130.AdditionalAMT = Trim$(rs0130!K0130_AdditionalAMT)
    If IsdbNull(rs0130!K0130_InsertDate) = False Then D0130.InsertDate = Trim$(rs0130!K0130_InsertDate)
    If IsdbNull(rs0130!K0130_InchargeInsert) = False Then D0130.InchargeInsert = Trim$(rs0130!K0130_InchargeInsert)
    If IsdbNull(rs0130!K0130_UpdateDate) = False Then D0130.UpdateDate = Trim$(rs0130!K0130_UpdateDate)
    If IsdbNull(rs0130!K0130_InchargeUpdate) = False Then D0130.InchargeUpdate = Trim$(rs0130!K0130_InchargeUpdate)
    If IsdbNull(rs0130!K0130_AttachID) = False Then D0130.AttachID = Trim$(rs0130!K0130_AttachID)
    If IsdbNull(rs0130!K0130_Remark) = False Then D0130.Remark = Trim$(rs0130!K0130_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0130_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K0130_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0130 As T0130_AREA, SPECNO AS String, SPECNOSEQ AS String, ADDCOSTSEQ AS Double) as Boolean

K0130_MOVE = False

Try
    If READ_PFK0130(SPECNO, SPECNOSEQ, ADDCOSTSEQ) = True Then
                z0130 = D0130
		K0130_MOVE = True
		else
	z0130 = nothing
     End If

     If  getColumIndex(spr,"SpecNo") > -1 then z0130.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z0130.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"AddCostSeq") > -1 then z0130.AddCostSeq = getDataM(spr, getColumIndex(spr,"AddCostSeq"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z0130.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"Status") > -1 then z0130.Status = getDataM(spr, getColumIndex(spr,"Status"), xRow)
     If  getColumIndex(spr,"seAdditionalCost") > -1 then z0130.seAdditionalCost = getDataM(spr, getColumIndex(spr,"seAdditionalCost"), xRow)
     If  getColumIndex(spr,"cdAdditionalCost") > -1 then z0130.cdAdditionalCost = getDataM(spr, getColumIndex(spr,"cdAdditionalCost"), xRow)
     If  getColumIndex(spr,"seCostingType") > -1 then z0130.seCostingType = getDataM(spr, getColumIndex(spr,"seCostingType"), xRow)
     If  getColumIndex(spr,"cdCostingType") > -1 then z0130.cdCostingType = getDataM(spr, getColumIndex(spr,"cdCostingType"), xRow)
     If  getColumIndex(spr,"Price") > -1 then z0130.Price = getDataM(spr, getColumIndex(spr,"Price"), xRow)
     If  getColumIndex(spr,"QtyAdditional") > -1 then z0130.QtyAdditional = getDataM(spr, getColumIndex(spr,"QtyAdditional"), xRow)
     If  getColumIndex(spr,"AdditionalAMT") > -1 then z0130.AdditionalAMT = getDataM(spr, getColumIndex(spr,"AdditionalAMT"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z0130.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z0130.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z0130.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z0130.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z0130.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0130.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0130_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K0130_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0130 As T0130_AREA,CheckClear as Boolean,SPECNO AS String, SPECNOSEQ AS String, ADDCOSTSEQ AS Double) as Boolean

K0130_MOVE = False

Try
    If READ_PFK0130(SPECNO, SPECNOSEQ, ADDCOSTSEQ) = True Then
                z0130 = D0130
		K0130_MOVE = True
		else
	If CheckClear  = True then z0130 = nothing
     End If

     If  getColumIndex(spr,"SpecNo") > -1 then z0130.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z0130.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"AddCostSeq") > -1 then z0130.AddCostSeq = getDataM(spr, getColumIndex(spr,"AddCostSeq"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z0130.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"Status") > -1 then z0130.Status = getDataM(spr, getColumIndex(spr,"Status"), xRow)
     If  getColumIndex(spr,"seAdditionalCost") > -1 then z0130.seAdditionalCost = getDataM(spr, getColumIndex(spr,"seAdditionalCost"), xRow)
     If  getColumIndex(spr,"cdAdditionalCost") > -1 then z0130.cdAdditionalCost = getDataM(spr, getColumIndex(spr,"cdAdditionalCost"), xRow)
     If  getColumIndex(spr,"seCostingType") > -1 then z0130.seCostingType = getDataM(spr, getColumIndex(spr,"seCostingType"), xRow)
     If  getColumIndex(spr,"cdCostingType") > -1 then z0130.cdCostingType = getDataM(spr, getColumIndex(spr,"cdCostingType"), xRow)
     If  getColumIndex(spr,"Price") > -1 then z0130.Price = getDataM(spr, getColumIndex(spr,"Price"), xRow)
     If  getColumIndex(spr,"QtyAdditional") > -1 then z0130.QtyAdditional = getDataM(spr, getColumIndex(spr,"QtyAdditional"), xRow)
     If  getColumIndex(spr,"AdditionalAMT") > -1 then z0130.AdditionalAMT = getDataM(spr, getColumIndex(spr,"AdditionalAMT"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z0130.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z0130.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z0130.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z0130.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z0130.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0130.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0130_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K0130_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0130 As T0130_AREA, Job as String, SPECNO AS String, SPECNOSEQ AS String, ADDCOSTSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0130_MOVE = False

Try
    If READ_PFK0130(SPECNO, SPECNOSEQ, ADDCOSTSEQ) = True Then
                z0130 = D0130
		K0130_MOVE = True
		else
	z0130 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0130")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SPECNO":z0130.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z0130.SpecNoSeq = Children(i).Code
   Case "ADDCOSTSEQ":z0130.AddCostSeq = Children(i).Code
   Case "DSEQ":z0130.Dseq = Children(i).Code
   Case "STATUS":z0130.Status = Children(i).Code
   Case "SEADDITIONALCOST":z0130.seAdditionalCost = Children(i).Code
   Case "CDADDITIONALCOST":z0130.cdAdditionalCost = Children(i).Code
   Case "SECOSTINGTYPE":z0130.seCostingType = Children(i).Code
   Case "CDCOSTINGTYPE":z0130.cdCostingType = Children(i).Code
   Case "PRICE":z0130.Price = Children(i).Code
   Case "QTYADDITIONAL":z0130.QtyAdditional = Children(i).Code
   Case "ADDITIONALAMT":z0130.AdditionalAMT = Children(i).Code
   Case "INSERTDATE":z0130.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z0130.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z0130.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z0130.InchargeUpdate = Children(i).Code
   Case "ATTACHID":z0130.AttachID = Children(i).Code
   Case "REMARK":z0130.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SPECNO":z0130.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z0130.SpecNoSeq = Children(i).Data
   Case "ADDCOSTSEQ":z0130.AddCostSeq = Children(i).Data
   Case "DSEQ":z0130.Dseq = Children(i).Data
   Case "STATUS":z0130.Status = Children(i).Data
   Case "SEADDITIONALCOST":z0130.seAdditionalCost = Children(i).Data
   Case "CDADDITIONALCOST":z0130.cdAdditionalCost = Children(i).Data
   Case "SECOSTINGTYPE":z0130.seCostingType = Children(i).Data
   Case "CDCOSTINGTYPE":z0130.cdCostingType = Children(i).Data
   Case "PRICE":z0130.Price = Children(i).Data
   Case "QTYADDITIONAL":z0130.QtyAdditional = Children(i).Data
   Case "ADDITIONALAMT":z0130.AdditionalAMT = Children(i).Data
   Case "INSERTDATE":z0130.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z0130.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z0130.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z0130.InchargeUpdate = Children(i).Data
   Case "ATTACHID":z0130.AttachID = Children(i).Data
   Case "REMARK":z0130.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0130_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K0130_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0130 As T0130_AREA, Job as String, CheckClear as Boolean, SPECNO AS String, SPECNOSEQ AS String, ADDCOSTSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0130_MOVE = False

Try
    If READ_PFK0130(SPECNO, SPECNOSEQ, ADDCOSTSEQ) = True Then
                z0130 = D0130
		K0130_MOVE = True
		else
	If CheckClear  = True then z0130 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0130")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SPECNO":z0130.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z0130.SpecNoSeq = Children(i).Code
   Case "ADDCOSTSEQ":z0130.AddCostSeq = Children(i).Code
   Case "DSEQ":z0130.Dseq = Children(i).Code
   Case "STATUS":z0130.Status = Children(i).Code
   Case "SEADDITIONALCOST":z0130.seAdditionalCost = Children(i).Code
   Case "CDADDITIONALCOST":z0130.cdAdditionalCost = Children(i).Code
   Case "SECOSTINGTYPE":z0130.seCostingType = Children(i).Code
   Case "CDCOSTINGTYPE":z0130.cdCostingType = Children(i).Code
   Case "PRICE":z0130.Price = Children(i).Code
   Case "QTYADDITIONAL":z0130.QtyAdditional = Children(i).Code
   Case "ADDITIONALAMT":z0130.AdditionalAMT = Children(i).Code
   Case "INSERTDATE":z0130.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z0130.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z0130.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z0130.InchargeUpdate = Children(i).Code
   Case "ATTACHID":z0130.AttachID = Children(i).Code
   Case "REMARK":z0130.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SPECNO":z0130.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z0130.SpecNoSeq = Children(i).Data
   Case "ADDCOSTSEQ":z0130.AddCostSeq = Children(i).Data
   Case "DSEQ":z0130.Dseq = Children(i).Data
   Case "STATUS":z0130.Status = Children(i).Data
   Case "SEADDITIONALCOST":z0130.seAdditionalCost = Children(i).Data
   Case "CDADDITIONALCOST":z0130.cdAdditionalCost = Children(i).Data
   Case "SECOSTINGTYPE":z0130.seCostingType = Children(i).Data
   Case "CDCOSTINGTYPE":z0130.cdCostingType = Children(i).Data
   Case "PRICE":z0130.Price = Children(i).Data
   Case "QTYADDITIONAL":z0130.QtyAdditional = Children(i).Data
   Case "ADDITIONALAMT":z0130.AdditionalAMT = Children(i).Data
   Case "INSERTDATE":z0130.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z0130.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z0130.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z0130.InchargeUpdate = Children(i).Data
   Case "ATTACHID":z0130.AttachID = Children(i).Data
   Case "REMARK":z0130.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0130_MOVE",vbCritical)
End Try
End Function 
    
End Module 
