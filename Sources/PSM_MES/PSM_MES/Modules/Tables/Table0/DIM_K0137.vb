'=========================================================================================================================================================
'   TABLE : (PFK0137)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K0137

Structure T0137_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	SpecNo	 AS String	'			char(9)		*
Public 	SpecNoSeq	 AS String	'			char(3)		*
Public 	CostSeq	 AS Double	'			decimal		*
Public 	CostType	 AS String	'			char(1)		*
Public 	Dseq	 AS Double	'			decimal
Public 	seCBDCost	 AS String	'			char(3)
Public 	cdCBDCost	 AS String	'			char(3)
Public 	seCostingType	 AS String	'			char(3)
Public 	cdCostingType	 AS String	'			char(3)
Public 	Price	 AS Double	'			decimal
Public 	QtyCost	 AS Double	'			decimal
Public 	AMTCost	 AS Double	'			decimal
Public 	InsertDate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	UpdateDate	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	AttachID	 AS String	'			char(6)
Public 	Remark	 AS String	'			nvarchar(50)
'=========================================================================================================================================================
End structure

Public D0137 As T0137_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK0137(SPECNO AS String, SPECNOSEQ AS String, COSTSEQ AS Double, COSTTYPE AS String) As Boolean
    READ_PFK0137 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0137 "
    SQL = SQL & " WHERE K0137_SpecNo		 = '" & SpecNo & "' " 
    SQL = SQL & "   AND K0137_SpecNoSeq		 = '" & SpecNoSeq & "' " 
    SQL = SQL & "   AND K0137_CostSeq		 =  " & CostSeq & "  " 
    SQL = SQL & "   AND K0137_CostType		 = '" & CostType & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D0137_CLEAR: GoTo SKIP_READ_PFK0137
                
    Call K0137_MOVE(rd)
    READ_PFK0137 = True

SKIP_READ_PFK0137:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK0137",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK0137(SPECNO AS String, SPECNOSEQ AS String, COSTSEQ AS Double, COSTTYPE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0137 "
    SQL = SQL & " WHERE K0137_SpecNo		 = '" & SpecNo & "' " 
    SQL = SQL & "   AND K0137_SpecNoSeq		 = '" & SpecNoSeq & "' " 
    SQL = SQL & "   AND K0137_CostSeq		 =  " & CostSeq & "  " 
    SQL = SQL & "   AND K0137_CostType		 = '" & CostType & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK0137",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK0137(z0137 As T0137_AREA) As Boolean
    WRITE_PFK0137 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z0137)
 
    SQL = " INSERT INTO PFK0137 "
    SQL = SQL & " ( "
    SQL = SQL & " K0137_SpecNo," 
    SQL = SQL & " K0137_SpecNoSeq," 
    SQL = SQL & " K0137_CostSeq," 
    SQL = SQL & " K0137_CostType," 
    SQL = SQL & " K0137_Dseq," 
    SQL = SQL & " K0137_seCBDCost," 
    SQL = SQL & " K0137_cdCBDCost," 
    SQL = SQL & " K0137_seCostingType," 
    SQL = SQL & " K0137_cdCostingType," 
    SQL = SQL & " K0137_Price," 
    SQL = SQL & " K0137_QtyCost," 
    SQL = SQL & " K0137_AMTCost," 
    SQL = SQL & " K0137_InsertDate," 
    SQL = SQL & " K0137_InchargeInsert," 
    SQL = SQL & " K0137_UpdateDate," 
    SQL = SQL & " K0137_InchargeUpdate," 
    SQL = SQL & " K0137_AttachID," 
    SQL = SQL & " K0137_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z0137.SpecNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0137.SpecNoSeq) & "', "  
    SQL = SQL & "   " & FormatSQL(z0137.CostSeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z0137.CostType) & "', "  
    SQL = SQL & "   " & FormatSQL(z0137.Dseq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z0137.seCBDCost) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0137.cdCBDCost) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0137.seCostingType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0137.cdCostingType) & "', "  
    SQL = SQL & "   " & FormatSQL(z0137.Price) & ", "  
    SQL = SQL & "   " & FormatSQL(z0137.QtyCost) & ", "  
    SQL = SQL & "   " & FormatSQL(z0137.AMTCost) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z0137.InsertDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0137.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0137.UpdateDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0137.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0137.AttachID) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0137.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK0137 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK0137",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK0137(z0137 As T0137_AREA) As Boolean
    REWRITE_PFK0137 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z0137)
   
    SQL = " UPDATE PFK0137 SET "
    SQL = SQL & "    K0137_Dseq      =  " & FormatSQL(z0137.Dseq) & ", " 
    SQL = SQL & "    K0137_seCBDCost      = N'" & FormatSQL(z0137.seCBDCost) & "', " 
    SQL = SQL & "    K0137_cdCBDCost      = N'" & FormatSQL(z0137.cdCBDCost) & "', " 
    SQL = SQL & "    K0137_seCostingType      = N'" & FormatSQL(z0137.seCostingType) & "', " 
    SQL = SQL & "    K0137_cdCostingType      = N'" & FormatSQL(z0137.cdCostingType) & "', " 
    SQL = SQL & "    K0137_Price      =  " & FormatSQL(z0137.Price) & ", " 
    SQL = SQL & "    K0137_QtyCost      =  " & FormatSQL(z0137.QtyCost) & ", " 
    SQL = SQL & "    K0137_AMTCost      =  " & FormatSQL(z0137.AMTCost) & ", " 
    SQL = SQL & "    K0137_InsertDate      = N'" & FormatSQL(z0137.InsertDate) & "', " 
    SQL = SQL & "    K0137_InchargeInsert      = N'" & FormatSQL(z0137.InchargeInsert) & "', " 
    SQL = SQL & "    K0137_UpdateDate      = N'" & FormatSQL(z0137.UpdateDate) & "', " 
    SQL = SQL & "    K0137_InchargeUpdate      = N'" & FormatSQL(z0137.InchargeUpdate) & "', " 
    SQL = SQL & "    K0137_AttachID      = N'" & FormatSQL(z0137.AttachID) & "', " 
    SQL = SQL & "    K0137_Remark      = N'" & FormatSQL(z0137.Remark) & "'  " 
    SQL = SQL & " WHERE K0137_SpecNo		 = '" & z0137.SpecNo & "' " 
    SQL = SQL & "   AND K0137_SpecNoSeq		 = '" & z0137.SpecNoSeq & "' " 
    SQL = SQL & "   AND K0137_CostSeq		 =  " & z0137.CostSeq & "  " 
    SQL = SQL & "   AND K0137_CostType		 = '" & z0137.CostType & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK0137 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK0137",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK0137(z0137 As T0137_AREA) As Boolean
    DELETE_PFK0137 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK0137 "
    SQL = SQL & " WHERE K0137_SpecNo		 = '" & z0137.SpecNo & "' " 
    SQL = SQL & "   AND K0137_SpecNoSeq		 = '" & z0137.SpecNoSeq & "' " 
    SQL = SQL & "   AND K0137_CostSeq		 =  " & z0137.CostSeq & "  " 
    SQL = SQL & "   AND K0137_CostType		 = '" & z0137.CostType & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK0137 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK0137",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D0137_CLEAR()
Try
    
   D0137.SpecNo = ""
   D0137.SpecNoSeq = ""
    D0137.CostSeq = 0 
   D0137.CostType = ""
    D0137.Dseq = 0 
   D0137.seCBDCost = ""
   D0137.cdCBDCost = ""
   D0137.seCostingType = ""
   D0137.cdCostingType = ""
    D0137.Price = 0 
    D0137.QtyCost = 0 
    D0137.AMTCost = 0 
   D0137.InsertDate = ""
   D0137.InchargeInsert = ""
   D0137.UpdateDate = ""
   D0137.InchargeUpdate = ""
   D0137.AttachID = ""
   D0137.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D0137_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x0137 As T0137_AREA)
Try
    
    x0137.SpecNo = trim$(  x0137.SpecNo)
    x0137.SpecNoSeq = trim$(  x0137.SpecNoSeq)
    x0137.CostSeq = trim$(  x0137.CostSeq)
    x0137.CostType = trim$(  x0137.CostType)
    x0137.Dseq = trim$(  x0137.Dseq)
    x0137.seCBDCost = trim$(  x0137.seCBDCost)
    x0137.cdCBDCost = trim$(  x0137.cdCBDCost)
    x0137.seCostingType = trim$(  x0137.seCostingType)
    x0137.cdCostingType = trim$(  x0137.cdCostingType)
    x0137.Price = trim$(  x0137.Price)
    x0137.QtyCost = trim$(  x0137.QtyCost)
    x0137.AMTCost = trim$(  x0137.AMTCost)
    x0137.InsertDate = trim$(  x0137.InsertDate)
    x0137.InchargeInsert = trim$(  x0137.InchargeInsert)
    x0137.UpdateDate = trim$(  x0137.UpdateDate)
    x0137.InchargeUpdate = trim$(  x0137.InchargeUpdate)
    x0137.AttachID = trim$(  x0137.AttachID)
    x0137.Remark = trim$(  x0137.Remark)
     
    If trim$( x0137.SpecNo ) = "" Then x0137.SpecNo = Space(1) 
    If trim$( x0137.SpecNoSeq ) = "" Then x0137.SpecNoSeq = Space(1) 
    If trim$( x0137.CostSeq ) = "" Then x0137.CostSeq = 0 
    If trim$( x0137.CostType ) = "" Then x0137.CostType = Space(1) 
    If trim$( x0137.Dseq ) = "" Then x0137.Dseq = 0 
    If trim$( x0137.seCBDCost ) = "" Then x0137.seCBDCost = Space(1) 
    If trim$( x0137.cdCBDCost ) = "" Then x0137.cdCBDCost = Space(1) 
    If trim$( x0137.seCostingType ) = "" Then x0137.seCostingType = Space(1) 
    If trim$( x0137.cdCostingType ) = "" Then x0137.cdCostingType = Space(1) 
    If trim$( x0137.Price ) = "" Then x0137.Price = 0 
    If trim$( x0137.QtyCost ) = "" Then x0137.QtyCost = 0 
    If trim$( x0137.AMTCost ) = "" Then x0137.AMTCost = 0 
    If trim$( x0137.InsertDate ) = "" Then x0137.InsertDate = Space(1) 
    If trim$( x0137.InchargeInsert ) = "" Then x0137.InchargeInsert = Space(1) 
    If trim$( x0137.UpdateDate ) = "" Then x0137.UpdateDate = Space(1) 
    If trim$( x0137.InchargeUpdate ) = "" Then x0137.InchargeUpdate = Space(1) 
    If trim$( x0137.AttachID ) = "" Then x0137.AttachID = Space(1) 
    If trim$( x0137.Remark ) = "" Then x0137.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K0137_MOVE(rs0137 As SqlClient.SqlDataReader)
Try

    call D0137_CLEAR()   

    If IsdbNull(rs0137!K0137_SpecNo) = False Then D0137.SpecNo = Trim$(rs0137!K0137_SpecNo)
    If IsdbNull(rs0137!K0137_SpecNoSeq) = False Then D0137.SpecNoSeq = Trim$(rs0137!K0137_SpecNoSeq)
    If IsdbNull(rs0137!K0137_CostSeq) = False Then D0137.CostSeq = Trim$(rs0137!K0137_CostSeq)
    If IsdbNull(rs0137!K0137_CostType) = False Then D0137.CostType = Trim$(rs0137!K0137_CostType)
    If IsdbNull(rs0137!K0137_Dseq) = False Then D0137.Dseq = Trim$(rs0137!K0137_Dseq)
    If IsdbNull(rs0137!K0137_seCBDCost) = False Then D0137.seCBDCost = Trim$(rs0137!K0137_seCBDCost)
    If IsdbNull(rs0137!K0137_cdCBDCost) = False Then D0137.cdCBDCost = Trim$(rs0137!K0137_cdCBDCost)
    If IsdbNull(rs0137!K0137_seCostingType) = False Then D0137.seCostingType = Trim$(rs0137!K0137_seCostingType)
    If IsdbNull(rs0137!K0137_cdCostingType) = False Then D0137.cdCostingType = Trim$(rs0137!K0137_cdCostingType)
    If IsdbNull(rs0137!K0137_Price) = False Then D0137.Price = Trim$(rs0137!K0137_Price)
    If IsdbNull(rs0137!K0137_QtyCost) = False Then D0137.QtyCost = Trim$(rs0137!K0137_QtyCost)
    If IsdbNull(rs0137!K0137_AMTCost) = False Then D0137.AMTCost = Trim$(rs0137!K0137_AMTCost)
    If IsdbNull(rs0137!K0137_InsertDate) = False Then D0137.InsertDate = Trim$(rs0137!K0137_InsertDate)
    If IsdbNull(rs0137!K0137_InchargeInsert) = False Then D0137.InchargeInsert = Trim$(rs0137!K0137_InchargeInsert)
    If IsdbNull(rs0137!K0137_UpdateDate) = False Then D0137.UpdateDate = Trim$(rs0137!K0137_UpdateDate)
    If IsdbNull(rs0137!K0137_InchargeUpdate) = False Then D0137.InchargeUpdate = Trim$(rs0137!K0137_InchargeUpdate)
    If IsdbNull(rs0137!K0137_AttachID) = False Then D0137.AttachID = Trim$(rs0137!K0137_AttachID)
    If IsdbNull(rs0137!K0137_Remark) = False Then D0137.Remark = Trim$(rs0137!K0137_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0137_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K0137_MOVE(rs0137 As DataRow)
Try

    call D0137_CLEAR()   

    If IsdbNull(rs0137!K0137_SpecNo) = False Then D0137.SpecNo = Trim$(rs0137!K0137_SpecNo)
    If IsdbNull(rs0137!K0137_SpecNoSeq) = False Then D0137.SpecNoSeq = Trim$(rs0137!K0137_SpecNoSeq)
    If IsdbNull(rs0137!K0137_CostSeq) = False Then D0137.CostSeq = Trim$(rs0137!K0137_CostSeq)
    If IsdbNull(rs0137!K0137_CostType) = False Then D0137.CostType = Trim$(rs0137!K0137_CostType)
    If IsdbNull(rs0137!K0137_Dseq) = False Then D0137.Dseq = Trim$(rs0137!K0137_Dseq)
    If IsdbNull(rs0137!K0137_seCBDCost) = False Then D0137.seCBDCost = Trim$(rs0137!K0137_seCBDCost)
    If IsdbNull(rs0137!K0137_cdCBDCost) = False Then D0137.cdCBDCost = Trim$(rs0137!K0137_cdCBDCost)
    If IsdbNull(rs0137!K0137_seCostingType) = False Then D0137.seCostingType = Trim$(rs0137!K0137_seCostingType)
    If IsdbNull(rs0137!K0137_cdCostingType) = False Then D0137.cdCostingType = Trim$(rs0137!K0137_cdCostingType)
    If IsdbNull(rs0137!K0137_Price) = False Then D0137.Price = Trim$(rs0137!K0137_Price)
    If IsdbNull(rs0137!K0137_QtyCost) = False Then D0137.QtyCost = Trim$(rs0137!K0137_QtyCost)
    If IsdbNull(rs0137!K0137_AMTCost) = False Then D0137.AMTCost = Trim$(rs0137!K0137_AMTCost)
    If IsdbNull(rs0137!K0137_InsertDate) = False Then D0137.InsertDate = Trim$(rs0137!K0137_InsertDate)
    If IsdbNull(rs0137!K0137_InchargeInsert) = False Then D0137.InchargeInsert = Trim$(rs0137!K0137_InchargeInsert)
    If IsdbNull(rs0137!K0137_UpdateDate) = False Then D0137.UpdateDate = Trim$(rs0137!K0137_UpdateDate)
    If IsdbNull(rs0137!K0137_InchargeUpdate) = False Then D0137.InchargeUpdate = Trim$(rs0137!K0137_InchargeUpdate)
    If IsdbNull(rs0137!K0137_AttachID) = False Then D0137.AttachID = Trim$(rs0137!K0137_AttachID)
    If IsdbNull(rs0137!K0137_Remark) = False Then D0137.Remark = Trim$(rs0137!K0137_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0137_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K0137_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0137 As T0137_AREA, SPECNO AS String, SPECNOSEQ AS String, COSTSEQ AS Double, COSTTYPE AS String) as Boolean

K0137_MOVE = False

Try
    If READ_PFK0137(SPECNO, SPECNOSEQ, COSTSEQ, COSTTYPE) = True Then
                z0137 = D0137
		K0137_MOVE = True
		else
	z0137 = nothing
     End If

     If  getColumIndex(spr,"SpecNo") > -1 then z0137.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z0137.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"CostSeq") > -1 then z0137.CostSeq = getDataM(spr, getColumIndex(spr,"CostSeq"), xRow)
     If  getColumIndex(spr,"CostType") > -1 then z0137.CostType = getDataM(spr, getColumIndex(spr,"CostType"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z0137.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"seCBDCost") > -1 then z0137.seCBDCost = getDataM(spr, getColumIndex(spr,"seCBDCost"), xRow)
     If  getColumIndex(spr,"cdCBDCost") > -1 then z0137.cdCBDCost = getDataM(spr, getColumIndex(spr,"cdCBDCost"), xRow)
     If  getColumIndex(spr,"seCostingType") > -1 then z0137.seCostingType = getDataM(spr, getColumIndex(spr,"seCostingType"), xRow)
     If  getColumIndex(spr,"cdCostingType") > -1 then z0137.cdCostingType = getDataM(spr, getColumIndex(spr,"cdCostingType"), xRow)
     If  getColumIndex(spr,"Price") > -1 then z0137.Price = getDataM(spr, getColumIndex(spr,"Price"), xRow)
     If  getColumIndex(spr,"QtyCost") > -1 then z0137.QtyCost = getDataM(spr, getColumIndex(spr,"QtyCost"), xRow)
     If  getColumIndex(spr,"AMTCost") > -1 then z0137.AMTCost = getDataM(spr, getColumIndex(spr,"AMTCost"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z0137.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z0137.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z0137.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z0137.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z0137.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0137.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0137_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K0137_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0137 As T0137_AREA,CheckClear as Boolean,SPECNO AS String, SPECNOSEQ AS String, COSTSEQ AS Double, COSTTYPE AS String) as Boolean

K0137_MOVE = False

Try
    If READ_PFK0137(SPECNO, SPECNOSEQ, COSTSEQ, COSTTYPE) = True Then
                z0137 = D0137
		K0137_MOVE = True
		else
	If CheckClear  = True then z0137 = nothing
     End If

     If  getColumIndex(spr,"SpecNo") > -1 then z0137.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z0137.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"CostSeq") > -1 then z0137.CostSeq = getDataM(spr, getColumIndex(spr,"CostSeq"), xRow)
     If  getColumIndex(spr,"CostType") > -1 then z0137.CostType = getDataM(spr, getColumIndex(spr,"CostType"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z0137.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"seCBDCost") > -1 then z0137.seCBDCost = getDataM(spr, getColumIndex(spr,"seCBDCost"), xRow)
     If  getColumIndex(spr,"cdCBDCost") > -1 then z0137.cdCBDCost = getDataM(spr, getColumIndex(spr,"cdCBDCost"), xRow)
     If  getColumIndex(spr,"seCostingType") > -1 then z0137.seCostingType = getDataM(spr, getColumIndex(spr,"seCostingType"), xRow)
     If  getColumIndex(spr,"cdCostingType") > -1 then z0137.cdCostingType = getDataM(spr, getColumIndex(spr,"cdCostingType"), xRow)
     If  getColumIndex(spr,"Price") > -1 then z0137.Price = getDataM(spr, getColumIndex(spr,"Price"), xRow)
     If  getColumIndex(spr,"QtyCost") > -1 then z0137.QtyCost = getDataM(spr, getColumIndex(spr,"QtyCost"), xRow)
     If  getColumIndex(spr,"AMTCost") > -1 then z0137.AMTCost = getDataM(spr, getColumIndex(spr,"AMTCost"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z0137.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z0137.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z0137.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z0137.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z0137.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0137.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0137_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K0137_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0137 As T0137_AREA, Job as String, SPECNO AS String, SPECNOSEQ AS String, COSTSEQ AS Double, COSTTYPE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0137_MOVE = False

Try
    If READ_PFK0137(SPECNO, SPECNOSEQ, COSTSEQ, COSTTYPE) = True Then
                z0137 = D0137
		K0137_MOVE = True
		else
	z0137 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0137")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SPECNO":z0137.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z0137.SpecNoSeq = Children(i).Code
   Case "COSTSEQ":z0137.CostSeq = Children(i).Code
   Case "COSTTYPE":z0137.CostType = Children(i).Code
   Case "DSEQ":z0137.Dseq = Children(i).Code
   Case "SECBDCOST":z0137.seCBDCost = Children(i).Code
   Case "CDCBDCOST":z0137.cdCBDCost = Children(i).Code
   Case "SECOSTINGTYPE":z0137.seCostingType = Children(i).Code
   Case "CDCOSTINGTYPE":z0137.cdCostingType = Children(i).Code
   Case "PRICE":z0137.Price = Children(i).Code
   Case "QTYCOST":z0137.QtyCost = Children(i).Code
   Case "AMTCOST":z0137.AMTCost = Children(i).Code
   Case "INSERTDATE":z0137.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z0137.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z0137.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z0137.InchargeUpdate = Children(i).Code
   Case "ATTACHID":z0137.AttachID = Children(i).Code
   Case "REMARK":z0137.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SPECNO":z0137.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z0137.SpecNoSeq = Children(i).Data
   Case "COSTSEQ":z0137.CostSeq = Children(i).Data
   Case "COSTTYPE":z0137.CostType = Children(i).Data
   Case "DSEQ":z0137.Dseq = Children(i).Data
   Case "SECBDCOST":z0137.seCBDCost = Children(i).Data
   Case "CDCBDCOST":z0137.cdCBDCost = Children(i).Data
   Case "SECOSTINGTYPE":z0137.seCostingType = Children(i).Data
   Case "CDCOSTINGTYPE":z0137.cdCostingType = Children(i).Data
   Case "PRICE":z0137.Price = Children(i).Data
   Case "QTYCOST":z0137.QtyCost = Children(i).Data
   Case "AMTCOST":z0137.AMTCost = Children(i).Data
   Case "INSERTDATE":z0137.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z0137.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z0137.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z0137.InchargeUpdate = Children(i).Data
   Case "ATTACHID":z0137.AttachID = Children(i).Data
   Case "REMARK":z0137.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0137_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K0137_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0137 As T0137_AREA, Job as String, CheckClear as Boolean, SPECNO AS String, SPECNOSEQ AS String, COSTSEQ AS Double, COSTTYPE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0137_MOVE = False

Try
    If READ_PFK0137(SPECNO, SPECNOSEQ, COSTSEQ, COSTTYPE) = True Then
                z0137 = D0137
		K0137_MOVE = True
		else
	If CheckClear  = True then z0137 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0137")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SPECNO":z0137.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z0137.SpecNoSeq = Children(i).Code
   Case "COSTSEQ":z0137.CostSeq = Children(i).Code
   Case "COSTTYPE":z0137.CostType = Children(i).Code
   Case "DSEQ":z0137.Dseq = Children(i).Code
   Case "SECBDCOST":z0137.seCBDCost = Children(i).Code
   Case "CDCBDCOST":z0137.cdCBDCost = Children(i).Code
   Case "SECOSTINGTYPE":z0137.seCostingType = Children(i).Code
   Case "CDCOSTINGTYPE":z0137.cdCostingType = Children(i).Code
   Case "PRICE":z0137.Price = Children(i).Code
   Case "QTYCOST":z0137.QtyCost = Children(i).Code
   Case "AMTCOST":z0137.AMTCost = Children(i).Code
   Case "INSERTDATE":z0137.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z0137.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z0137.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z0137.InchargeUpdate = Children(i).Code
   Case "ATTACHID":z0137.AttachID = Children(i).Code
   Case "REMARK":z0137.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SPECNO":z0137.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z0137.SpecNoSeq = Children(i).Data
   Case "COSTSEQ":z0137.CostSeq = Children(i).Data
   Case "COSTTYPE":z0137.CostType = Children(i).Data
   Case "DSEQ":z0137.Dseq = Children(i).Data
   Case "SECBDCOST":z0137.seCBDCost = Children(i).Data
   Case "CDCBDCOST":z0137.cdCBDCost = Children(i).Data
   Case "SECOSTINGTYPE":z0137.seCostingType = Children(i).Data
   Case "CDCOSTINGTYPE":z0137.cdCostingType = Children(i).Data
   Case "PRICE":z0137.Price = Children(i).Data
   Case "QTYCOST":z0137.QtyCost = Children(i).Data
   Case "AMTCOST":z0137.AMTCost = Children(i).Data
   Case "INSERTDATE":z0137.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z0137.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z0137.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z0137.InchargeUpdate = Children(i).Data
   Case "ATTACHID":z0137.AttachID = Children(i).Data
   Case "REMARK":z0137.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0137_MOVE",vbCritical)
End Try
End Function 
    
End Module 
