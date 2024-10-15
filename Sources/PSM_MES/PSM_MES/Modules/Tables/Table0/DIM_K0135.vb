'=========================================================================================================================================================
'   TABLE : (PFK0135)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K0135

Structure T0135_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	SpecNo	 AS String	'			char(9)		*
Public 	SpecNoSeq	 AS String	'			char(3)		*
Public 	SalesCostSeq	 AS Double	'			decimal		*
Public 	Dseq	 AS Double	'			decimal
Public 	Status	 AS String	'			char(1)
Public 	seSalesCost	 AS String	'			char(3)
Public 	cdSalesCost	 AS String	'			char(3)
Public 	seCostingType	 AS String	'			char(3)
Public 	cdCostingType	 AS String	'			char(3)
Public 	Price	 AS Double	'			decimal
Public 	QtySales	 AS Double	'			decimal
Public 	SalesAMT	 AS Double	'			decimal
Public 	InsertDate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(6)
Public 	UpdateDate	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(6)
Public 	Remark	 AS String	'			nvarchar(50)
'=========================================================================================================================================================
End structure

Public D0135 As T0135_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK0135(SPECNO AS String, SPECNOSEQ AS String, SALESCOSTSEQ AS Double) As Boolean
    READ_PFK0135 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0135 "
    SQL = SQL & " WHERE K0135_SpecNo		 = '" & SpecNo & "' " 
    SQL = SQL & "   AND K0135_SpecNoSeq		 = '" & SpecNoSeq & "' " 
    SQL = SQL & "   AND K0135_SalesCostSeq		 =  " & SalesCostSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D0135_CLEAR: GoTo SKIP_READ_PFK0135
                
    Call K0135_MOVE(rd)
    READ_PFK0135 = True

SKIP_READ_PFK0135:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK0135",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK0135(SPECNO AS String, SPECNOSEQ AS String, SALESCOSTSEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0135 "
    SQL = SQL & " WHERE K0135_SpecNo		 = '" & SpecNo & "' " 
    SQL = SQL & "   AND K0135_SpecNoSeq		 = '" & SpecNoSeq & "' " 
    SQL = SQL & "   AND K0135_SalesCostSeq		 =  " & SalesCostSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK0135",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK0135(z0135 As T0135_AREA) As Boolean
    WRITE_PFK0135 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z0135)
 
    SQL = " INSERT INTO PFK0135 "
    SQL = SQL & " ( "
    SQL = SQL & " K0135_SpecNo," 
    SQL = SQL & " K0135_SpecNoSeq," 
    SQL = SQL & " K0135_SalesCostSeq," 
    SQL = SQL & " K0135_Dseq," 
    SQL = SQL & " K0135_Status," 
    SQL = SQL & " K0135_seSalesCost," 
    SQL = SQL & " K0135_cdSalesCost," 
    SQL = SQL & " K0135_seCostingType," 
    SQL = SQL & " K0135_cdCostingType," 
    SQL = SQL & " K0135_Price," 
    SQL = SQL & " K0135_QtySales," 
    SQL = SQL & " K0135_SalesAMT," 
    SQL = SQL & " K0135_InsertDate," 
    SQL = SQL & " K0135_InchargeInsert," 
    SQL = SQL & " K0135_UpdateDate," 
    SQL = SQL & " K0135_InchargeUpdate," 
    SQL = SQL & " K0135_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z0135.SpecNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0135.SpecNoSeq) & "', "  
    SQL = SQL & "   " & FormatSQL(z0135.SalesCostSeq) & ", "  
    SQL = SQL & "   " & FormatSQL(z0135.Dseq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z0135.Status) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0135.seSalesCost) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0135.cdSalesCost) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0135.seCostingType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0135.cdCostingType) & "', "  
    SQL = SQL & "   " & FormatSQL(z0135.Price) & ", "  
    SQL = SQL & "   " & FormatSQL(z0135.QtySales) & ", "  
    SQL = SQL & "   " & FormatSQL(z0135.SalesAMT) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z0135.InsertDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0135.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0135.UpdateDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0135.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0135.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK0135 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK0135",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK0135(z0135 As T0135_AREA) As Boolean
    REWRITE_PFK0135 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z0135)
   
    SQL = " UPDATE PFK0135 SET "
    SQL = SQL & "    K0135_Dseq      =  " & FormatSQL(z0135.Dseq) & ", " 
    SQL = SQL & "    K0135_Status      = N'" & FormatSQL(z0135.Status) & "', " 
    SQL = SQL & "    K0135_seSalesCost      = N'" & FormatSQL(z0135.seSalesCost) & "', " 
    SQL = SQL & "    K0135_cdSalesCost      = N'" & FormatSQL(z0135.cdSalesCost) & "', " 
    SQL = SQL & "    K0135_seCostingType      = N'" & FormatSQL(z0135.seCostingType) & "', " 
    SQL = SQL & "    K0135_cdCostingType      = N'" & FormatSQL(z0135.cdCostingType) & "', " 
    SQL = SQL & "    K0135_Price      =  " & FormatSQL(z0135.Price) & ", " 
    SQL = SQL & "    K0135_QtySales      =  " & FormatSQL(z0135.QtySales) & ", " 
    SQL = SQL & "    K0135_SalesAMT      =  " & FormatSQL(z0135.SalesAMT) & ", " 
    SQL = SQL & "    K0135_InsertDate      = N'" & FormatSQL(z0135.InsertDate) & "', " 
    SQL = SQL & "    K0135_InchargeInsert      = N'" & FormatSQL(z0135.InchargeInsert) & "', " 
    SQL = SQL & "    K0135_UpdateDate      = N'" & FormatSQL(z0135.UpdateDate) & "', " 
    SQL = SQL & "    K0135_InchargeUpdate      = N'" & FormatSQL(z0135.InchargeUpdate) & "', " 
    SQL = SQL & "    K0135_Remark      = N'" & FormatSQL(z0135.Remark) & "'  " 
    SQL = SQL & " WHERE K0135_SpecNo		 = '" & z0135.SpecNo & "' " 
    SQL = SQL & "   AND K0135_SpecNoSeq		 = '" & z0135.SpecNoSeq & "' " 
    SQL = SQL & "   AND K0135_SalesCostSeq		 =  " & z0135.SalesCostSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK0135 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK0135",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK0135(z0135 As T0135_AREA) As Boolean
    DELETE_PFK0135 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK0135 "
    SQL = SQL & " WHERE K0135_SpecNo		 = '" & z0135.SpecNo & "' " 
    SQL = SQL & "   AND K0135_SpecNoSeq		 = '" & z0135.SpecNoSeq & "' " 
    SQL = SQL & "   AND K0135_SalesCostSeq		 =  " & z0135.SalesCostSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK0135 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK0135",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D0135_CLEAR()
Try
    
   D0135.SpecNo = ""
   D0135.SpecNoSeq = ""
    D0135.SalesCostSeq = 0 
    D0135.Dseq = 0 
   D0135.Status = ""
   D0135.seSalesCost = ""
   D0135.cdSalesCost = ""
   D0135.seCostingType = ""
   D0135.cdCostingType = ""
    D0135.Price = 0 
    D0135.QtySales = 0 
    D0135.SalesAMT = 0 
   D0135.InsertDate = ""
   D0135.InchargeInsert = ""
   D0135.UpdateDate = ""
   D0135.InchargeUpdate = ""
   D0135.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D0135_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x0135 As T0135_AREA)
Try
    
    x0135.SpecNo = trim$(  x0135.SpecNo)
    x0135.SpecNoSeq = trim$(  x0135.SpecNoSeq)
    x0135.SalesCostSeq = trim$(  x0135.SalesCostSeq)
    x0135.Dseq = trim$(  x0135.Dseq)
    x0135.Status = trim$(  x0135.Status)
    x0135.seSalesCost = trim$(  x0135.seSalesCost)
    x0135.cdSalesCost = trim$(  x0135.cdSalesCost)
    x0135.seCostingType = trim$(  x0135.seCostingType)
    x0135.cdCostingType = trim$(  x0135.cdCostingType)
    x0135.Price = trim$(  x0135.Price)
    x0135.QtySales = trim$(  x0135.QtySales)
    x0135.SalesAMT = trim$(  x0135.SalesAMT)
    x0135.InsertDate = trim$(  x0135.InsertDate)
    x0135.InchargeInsert = trim$(  x0135.InchargeInsert)
    x0135.UpdateDate = trim$(  x0135.UpdateDate)
    x0135.InchargeUpdate = trim$(  x0135.InchargeUpdate)
    x0135.Remark = trim$(  x0135.Remark)
     
    If trim$( x0135.SpecNo ) = "" Then x0135.SpecNo = Space(1) 
    If trim$( x0135.SpecNoSeq ) = "" Then x0135.SpecNoSeq = Space(1) 
    If trim$( x0135.SalesCostSeq ) = "" Then x0135.SalesCostSeq = 0 
    If trim$( x0135.Dseq ) = "" Then x0135.Dseq = 0 
    If trim$( x0135.Status ) = "" Then x0135.Status = Space(1) 
    If trim$( x0135.seSalesCost ) = "" Then x0135.seSalesCost = Space(1) 
    If trim$( x0135.cdSalesCost ) = "" Then x0135.cdSalesCost = Space(1) 
    If trim$( x0135.seCostingType ) = "" Then x0135.seCostingType = Space(1) 
    If trim$( x0135.cdCostingType ) = "" Then x0135.cdCostingType = Space(1) 
    If trim$( x0135.Price ) = "" Then x0135.Price = 0 
    If trim$( x0135.QtySales ) = "" Then x0135.QtySales = 0 
    If trim$( x0135.SalesAMT ) = "" Then x0135.SalesAMT = 0 
    If trim$( x0135.InsertDate ) = "" Then x0135.InsertDate = Space(1) 
    If trim$( x0135.InchargeInsert ) = "" Then x0135.InchargeInsert = Space(1) 
    If trim$( x0135.UpdateDate ) = "" Then x0135.UpdateDate = Space(1) 
    If trim$( x0135.InchargeUpdate ) = "" Then x0135.InchargeUpdate = Space(1) 
    If trim$( x0135.Remark ) = "" Then x0135.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K0135_MOVE(rs0135 As SqlClient.SqlDataReader)
Try

    call D0135_CLEAR()   

    If IsdbNull(rs0135!K0135_SpecNo) = False Then D0135.SpecNo = Trim$(rs0135!K0135_SpecNo)
    If IsdbNull(rs0135!K0135_SpecNoSeq) = False Then D0135.SpecNoSeq = Trim$(rs0135!K0135_SpecNoSeq)
    If IsdbNull(rs0135!K0135_SalesCostSeq) = False Then D0135.SalesCostSeq = Trim$(rs0135!K0135_SalesCostSeq)
    If IsdbNull(rs0135!K0135_Dseq) = False Then D0135.Dseq = Trim$(rs0135!K0135_Dseq)
    If IsdbNull(rs0135!K0135_Status) = False Then D0135.Status = Trim$(rs0135!K0135_Status)
    If IsdbNull(rs0135!K0135_seSalesCost) = False Then D0135.seSalesCost = Trim$(rs0135!K0135_seSalesCost)
    If IsdbNull(rs0135!K0135_cdSalesCost) = False Then D0135.cdSalesCost = Trim$(rs0135!K0135_cdSalesCost)
    If IsdbNull(rs0135!K0135_seCostingType) = False Then D0135.seCostingType = Trim$(rs0135!K0135_seCostingType)
    If IsdbNull(rs0135!K0135_cdCostingType) = False Then D0135.cdCostingType = Trim$(rs0135!K0135_cdCostingType)
    If IsdbNull(rs0135!K0135_Price) = False Then D0135.Price = Trim$(rs0135!K0135_Price)
    If IsdbNull(rs0135!K0135_QtySales) = False Then D0135.QtySales = Trim$(rs0135!K0135_QtySales)
    If IsdbNull(rs0135!K0135_SalesAMT) = False Then D0135.SalesAMT = Trim$(rs0135!K0135_SalesAMT)
    If IsdbNull(rs0135!K0135_InsertDate) = False Then D0135.InsertDate = Trim$(rs0135!K0135_InsertDate)
    If IsdbNull(rs0135!K0135_InchargeInsert) = False Then D0135.InchargeInsert = Trim$(rs0135!K0135_InchargeInsert)
    If IsdbNull(rs0135!K0135_UpdateDate) = False Then D0135.UpdateDate = Trim$(rs0135!K0135_UpdateDate)
    If IsdbNull(rs0135!K0135_InchargeUpdate) = False Then D0135.InchargeUpdate = Trim$(rs0135!K0135_InchargeUpdate)
    If IsdbNull(rs0135!K0135_Remark) = False Then D0135.Remark = Trim$(rs0135!K0135_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0135_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K0135_MOVE(rs0135 As DataRow)
Try

    call D0135_CLEAR()   

    If IsdbNull(rs0135!K0135_SpecNo) = False Then D0135.SpecNo = Trim$(rs0135!K0135_SpecNo)
    If IsdbNull(rs0135!K0135_SpecNoSeq) = False Then D0135.SpecNoSeq = Trim$(rs0135!K0135_SpecNoSeq)
    If IsdbNull(rs0135!K0135_SalesCostSeq) = False Then D0135.SalesCostSeq = Trim$(rs0135!K0135_SalesCostSeq)
    If IsdbNull(rs0135!K0135_Dseq) = False Then D0135.Dseq = Trim$(rs0135!K0135_Dseq)
    If IsdbNull(rs0135!K0135_Status) = False Then D0135.Status = Trim$(rs0135!K0135_Status)
    If IsdbNull(rs0135!K0135_seSalesCost) = False Then D0135.seSalesCost = Trim$(rs0135!K0135_seSalesCost)
    If IsdbNull(rs0135!K0135_cdSalesCost) = False Then D0135.cdSalesCost = Trim$(rs0135!K0135_cdSalesCost)
    If IsdbNull(rs0135!K0135_seCostingType) = False Then D0135.seCostingType = Trim$(rs0135!K0135_seCostingType)
    If IsdbNull(rs0135!K0135_cdCostingType) = False Then D0135.cdCostingType = Trim$(rs0135!K0135_cdCostingType)
    If IsdbNull(rs0135!K0135_Price) = False Then D0135.Price = Trim$(rs0135!K0135_Price)
    If IsdbNull(rs0135!K0135_QtySales) = False Then D0135.QtySales = Trim$(rs0135!K0135_QtySales)
    If IsdbNull(rs0135!K0135_SalesAMT) = False Then D0135.SalesAMT = Trim$(rs0135!K0135_SalesAMT)
    If IsdbNull(rs0135!K0135_InsertDate) = False Then D0135.InsertDate = Trim$(rs0135!K0135_InsertDate)
    If IsdbNull(rs0135!K0135_InchargeInsert) = False Then D0135.InchargeInsert = Trim$(rs0135!K0135_InchargeInsert)
    If IsdbNull(rs0135!K0135_UpdateDate) = False Then D0135.UpdateDate = Trim$(rs0135!K0135_UpdateDate)
    If IsdbNull(rs0135!K0135_InchargeUpdate) = False Then D0135.InchargeUpdate = Trim$(rs0135!K0135_InchargeUpdate)
    If IsdbNull(rs0135!K0135_Remark) = False Then D0135.Remark = Trim$(rs0135!K0135_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0135_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K0135_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0135 As T0135_AREA, SPECNO AS String, SPECNOSEQ AS String, SALESCOSTSEQ AS Double) as Boolean

K0135_MOVE = False

Try
    If READ_PFK0135(SPECNO, SPECNOSEQ, SALESCOSTSEQ) = True Then
                z0135 = D0135
		K0135_MOVE = True
		else
	z0135 = nothing
     End If

     If  getColumIndex(spr,"SpecNo") > -1 then z0135.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z0135.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"SalesCostSeq") > -1 then z0135.SalesCostSeq = getDataM(spr, getColumIndex(spr,"SalesCostSeq"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z0135.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"Status") > -1 then z0135.Status = getDataM(spr, getColumIndex(spr,"Status"), xRow)
     If  getColumIndex(spr,"seSalesCost") > -1 then z0135.seSalesCost = getDataM(spr, getColumIndex(spr,"seSalesCost"), xRow)
     If  getColumIndex(spr,"cdSalesCost") > -1 then z0135.cdSalesCost = getDataM(spr, getColumIndex(spr,"cdSalesCost"), xRow)
     If  getColumIndex(spr,"seCostingType") > -1 then z0135.seCostingType = getDataM(spr, getColumIndex(spr,"seCostingType"), xRow)
     If  getColumIndex(spr,"cdCostingType") > -1 then z0135.cdCostingType = getDataM(spr, getColumIndex(spr,"cdCostingType"), xRow)
     If  getColumIndex(spr,"Price") > -1 then z0135.Price = getDataM(spr, getColumIndex(spr,"Price"), xRow)
     If  getColumIndex(spr,"QtySales") > -1 then z0135.QtySales = getDataM(spr, getColumIndex(spr,"QtySales"), xRow)
     If  getColumIndex(spr,"SalesAMT") > -1 then z0135.SalesAMT = getDataM(spr, getColumIndex(spr,"SalesAMT"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z0135.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z0135.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z0135.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z0135.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0135.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0135_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K0135_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0135 As T0135_AREA,CheckClear as Boolean,SPECNO AS String, SPECNOSEQ AS String, SALESCOSTSEQ AS Double) as Boolean

K0135_MOVE = False

Try
    If READ_PFK0135(SPECNO, SPECNOSEQ, SALESCOSTSEQ) = True Then
                z0135 = D0135
		K0135_MOVE = True
		else
	If CheckClear  = True then z0135 = nothing
     End If

     If  getColumIndex(spr,"SpecNo") > -1 then z0135.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z0135.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"SalesCostSeq") > -1 then z0135.SalesCostSeq = getDataM(spr, getColumIndex(spr,"SalesCostSeq"), xRow)
     If  getColumIndex(spr,"Dseq") > -1 then z0135.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
     If  getColumIndex(spr,"Status") > -1 then z0135.Status = getDataM(spr, getColumIndex(spr,"Status"), xRow)
     If  getColumIndex(spr,"seSalesCost") > -1 then z0135.seSalesCost = getDataM(spr, getColumIndex(spr,"seSalesCost"), xRow)
     If  getColumIndex(spr,"cdSalesCost") > -1 then z0135.cdSalesCost = getDataM(spr, getColumIndex(spr,"cdSalesCost"), xRow)
     If  getColumIndex(spr,"seCostingType") > -1 then z0135.seCostingType = getDataM(spr, getColumIndex(spr,"seCostingType"), xRow)
     If  getColumIndex(spr,"cdCostingType") > -1 then z0135.cdCostingType = getDataM(spr, getColumIndex(spr,"cdCostingType"), xRow)
     If  getColumIndex(spr,"Price") > -1 then z0135.Price = getDataM(spr, getColumIndex(spr,"Price"), xRow)
     If  getColumIndex(spr,"QtySales") > -1 then z0135.QtySales = getDataM(spr, getColumIndex(spr,"QtySales"), xRow)
     If  getColumIndex(spr,"SalesAMT") > -1 then z0135.SalesAMT = getDataM(spr, getColumIndex(spr,"SalesAMT"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z0135.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z0135.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z0135.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z0135.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0135.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0135_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K0135_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0135 As T0135_AREA, Job as String, SPECNO AS String, SPECNOSEQ AS String, SALESCOSTSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0135_MOVE = False

Try
    If READ_PFK0135(SPECNO, SPECNOSEQ, SALESCOSTSEQ) = True Then
                z0135 = D0135
		K0135_MOVE = True
		else
	z0135 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0135")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SPECNO":z0135.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z0135.SpecNoSeq = Children(i).Code
   Case "SALESCOSTSEQ":z0135.SalesCostSeq = Children(i).Code
   Case "DSEQ":z0135.Dseq = Children(i).Code
   Case "STATUS":z0135.Status = Children(i).Code
   Case "SESALESCOST":z0135.seSalesCost = Children(i).Code
   Case "CDSALESCOST":z0135.cdSalesCost = Children(i).Code
   Case "SECOSTINGTYPE":z0135.seCostingType = Children(i).Code
   Case "CDCOSTINGTYPE":z0135.cdCostingType = Children(i).Code
   Case "PRICE":z0135.Price = Children(i).Code
   Case "QTYSALES":z0135.QtySales = Children(i).Code
   Case "SALESAMT":z0135.SalesAMT = Children(i).Code
   Case "INSERTDATE":z0135.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z0135.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z0135.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z0135.InchargeUpdate = Children(i).Code
   Case "REMARK":z0135.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SPECNO":z0135.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z0135.SpecNoSeq = Children(i).Data
   Case "SALESCOSTSEQ":z0135.SalesCostSeq = Children(i).Data
   Case "DSEQ":z0135.Dseq = Children(i).Data
   Case "STATUS":z0135.Status = Children(i).Data
   Case "SESALESCOST":z0135.seSalesCost = Children(i).Data
   Case "CDSALESCOST":z0135.cdSalesCost = Children(i).Data
   Case "SECOSTINGTYPE":z0135.seCostingType = Children(i).Data
   Case "CDCOSTINGTYPE":z0135.cdCostingType = Children(i).Data
   Case "PRICE":z0135.Price = Children(i).Data
   Case "QTYSALES":z0135.QtySales = Children(i).Data
   Case "SALESAMT":z0135.SalesAMT = Children(i).Data
   Case "INSERTDATE":z0135.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z0135.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z0135.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z0135.InchargeUpdate = Children(i).Data
   Case "REMARK":z0135.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0135_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K0135_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0135 As T0135_AREA, Job as String, CheckClear as Boolean, SPECNO AS String, SPECNOSEQ AS String, SALESCOSTSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0135_MOVE = False

Try
    If READ_PFK0135(SPECNO, SPECNOSEQ, SALESCOSTSEQ) = True Then
                z0135 = D0135
		K0135_MOVE = True
		else
	If CheckClear  = True then z0135 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0135")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SPECNO":z0135.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z0135.SpecNoSeq = Children(i).Code
   Case "SALESCOSTSEQ":z0135.SalesCostSeq = Children(i).Code
   Case "DSEQ":z0135.Dseq = Children(i).Code
   Case "STATUS":z0135.Status = Children(i).Code
   Case "SESALESCOST":z0135.seSalesCost = Children(i).Code
   Case "CDSALESCOST":z0135.cdSalesCost = Children(i).Code
   Case "SECOSTINGTYPE":z0135.seCostingType = Children(i).Code
   Case "CDCOSTINGTYPE":z0135.cdCostingType = Children(i).Code
   Case "PRICE":z0135.Price = Children(i).Code
   Case "QTYSALES":z0135.QtySales = Children(i).Code
   Case "SALESAMT":z0135.SalesAMT = Children(i).Code
   Case "INSERTDATE":z0135.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z0135.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z0135.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z0135.InchargeUpdate = Children(i).Code
   Case "REMARK":z0135.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SPECNO":z0135.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z0135.SpecNoSeq = Children(i).Data
   Case "SALESCOSTSEQ":z0135.SalesCostSeq = Children(i).Data
   Case "DSEQ":z0135.Dseq = Children(i).Data
   Case "STATUS":z0135.Status = Children(i).Data
   Case "SESALESCOST":z0135.seSalesCost = Children(i).Data
   Case "CDSALESCOST":z0135.cdSalesCost = Children(i).Data
   Case "SECOSTINGTYPE":z0135.seCostingType = Children(i).Data
   Case "CDCOSTINGTYPE":z0135.cdCostingType = Children(i).Data
   Case "PRICE":z0135.Price = Children(i).Data
   Case "QTYSALES":z0135.QtySales = Children(i).Data
   Case "SALESAMT":z0135.SalesAMT = Children(i).Data
   Case "INSERTDATE":z0135.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z0135.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z0135.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z0135.InchargeUpdate = Children(i).Data
   Case "REMARK":z0135.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0135_MOVE",vbCritical)
End Try
End Function 
    
End Module 
