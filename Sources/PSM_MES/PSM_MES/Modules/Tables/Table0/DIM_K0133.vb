'=========================================================================================================================================================
'   TABLE : (PFK0133)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K0133

Structure T0133_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	SpecNo	 AS String	'			char(9)		*
Public 	SpecNoSeq	 AS String	'			char(3)		*
Public 	OverCostSeq	 AS Double	'			decimal		*
Public 	DSeq	 AS Double	'			decimal
Public 	Status	 AS String	'			char(1)
Public 	seOverheadCost	 AS String	'			char(3)
Public 	cdOverheadCost	 AS String	'			char(3)
Public 	PriceOutsole	 AS Double	'			decimal
Public 	PriceCutting	 AS Double	'			decimal
Public 	PriceStitching	 AS Double	'			decimal
Public 	PriceStockfit	 AS Double	'			decimal
Public 	PriceAssembly	 AS Double	'			decimal
Public 	PriceSubprocess	 AS Double	'			decimal
Public 	PriceOutsource	 AS Double	'			decimal
Public 	ExpenseAMT	 AS Double	'			decimal
Public 	InsertDate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(6)
Public 	UpdateDate	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(6)
Public 	AttachID	 AS String	'			char(6)
Public 	Remark	 AS String	'			nvarchar(50)
'=========================================================================================================================================================
End structure

Public D0133 As T0133_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK0133(SPECNO AS String, SPECNOSEQ AS String, OVERCOSTSEQ AS Double) As Boolean
    READ_PFK0133 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0133 "
    SQL = SQL & " WHERE K0133_SpecNo		 = '" & SpecNo & "' " 
    SQL = SQL & "   AND K0133_SpecNoSeq		 = '" & SpecNoSeq & "' " 
    SQL = SQL & "   AND K0133_OverCostSeq		 =  " & OverCostSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D0133_CLEAR: GoTo SKIP_READ_PFK0133
                
    Call K0133_MOVE(rd)
    READ_PFK0133 = True

SKIP_READ_PFK0133:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK0133",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK0133(SPECNO AS String, SPECNOSEQ AS String, OVERCOSTSEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0133 "
    SQL = SQL & " WHERE K0133_SpecNo		 = '" & SpecNo & "' " 
    SQL = SQL & "   AND K0133_SpecNoSeq		 = '" & SpecNoSeq & "' " 
    SQL = SQL & "   AND K0133_OverCostSeq		 =  " & OverCostSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK0133",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK0133(z0133 As T0133_AREA) As Boolean
    WRITE_PFK0133 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z0133)
 
    SQL = " INSERT INTO PFK0133 "
    SQL = SQL & " ( "
    SQL = SQL & " K0133_SpecNo," 
    SQL = SQL & " K0133_SpecNoSeq," 
    SQL = SQL & " K0133_OverCostSeq," 
    SQL = SQL & " K0133_DSeq," 
    SQL = SQL & " K0133_Status," 
    SQL = SQL & " K0133_seOverheadCost," 
    SQL = SQL & " K0133_cdOverheadCost," 
    SQL = SQL & " K0133_PriceOutsole," 
    SQL = SQL & " K0133_PriceCutting," 
    SQL = SQL & " K0133_PriceStitching," 
    SQL = SQL & " K0133_PriceStockfit," 
    SQL = SQL & " K0133_PriceAssembly," 
    SQL = SQL & " K0133_PriceSubprocess," 
    SQL = SQL & " K0133_PriceOutsource," 
    SQL = SQL & " K0133_ExpenseAMT," 
    SQL = SQL & " K0133_InsertDate," 
    SQL = SQL & " K0133_InchargeInsert," 
    SQL = SQL & " K0133_UpdateDate," 
    SQL = SQL & " K0133_InchargeUpdate," 
    SQL = SQL & " K0133_AttachID," 
    SQL = SQL & " K0133_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z0133.SpecNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0133.SpecNoSeq) & "', "  
    SQL = SQL & "   " & FormatSQL(z0133.OverCostSeq) & ", "  
    SQL = SQL & "   " & FormatSQL(z0133.DSeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z0133.Status) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0133.seOverheadCost) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0133.cdOverheadCost) & "', "  
    SQL = SQL & "   " & FormatSQL(z0133.PriceOutsole) & ", "  
    SQL = SQL & "   " & FormatSQL(z0133.PriceCutting) & ", "  
    SQL = SQL & "   " & FormatSQL(z0133.PriceStitching) & ", "  
    SQL = SQL & "   " & FormatSQL(z0133.PriceStockfit) & ", "  
    SQL = SQL & "   " & FormatSQL(z0133.PriceAssembly) & ", "  
    SQL = SQL & "   " & FormatSQL(z0133.PriceSubprocess) & ", "  
    SQL = SQL & "   " & FormatSQL(z0133.PriceOutsource) & ", "  
    SQL = SQL & "   " & FormatSQL(z0133.ExpenseAMT) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z0133.InsertDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0133.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0133.UpdateDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0133.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0133.AttachID) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0133.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK0133 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK0133",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK0133(z0133 As T0133_AREA) As Boolean
    REWRITE_PFK0133 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z0133)
   
    SQL = " UPDATE PFK0133 SET "
    SQL = SQL & "    K0133_DSeq      =  " & FormatSQL(z0133.DSeq) & ", " 
    SQL = SQL & "    K0133_Status      = N'" & FormatSQL(z0133.Status) & "', " 
    SQL = SQL & "    K0133_seOverheadCost      = N'" & FormatSQL(z0133.seOverheadCost) & "', " 
    SQL = SQL & "    K0133_cdOverheadCost      = N'" & FormatSQL(z0133.cdOverheadCost) & "', " 
    SQL = SQL & "    K0133_PriceOutsole      =  " & FormatSQL(z0133.PriceOutsole) & ", " 
    SQL = SQL & "    K0133_PriceCutting      =  " & FormatSQL(z0133.PriceCutting) & ", " 
    SQL = SQL & "    K0133_PriceStitching      =  " & FormatSQL(z0133.PriceStitching) & ", " 
    SQL = SQL & "    K0133_PriceStockfit      =  " & FormatSQL(z0133.PriceStockfit) & ", " 
    SQL = SQL & "    K0133_PriceAssembly      =  " & FormatSQL(z0133.PriceAssembly) & ", " 
    SQL = SQL & "    K0133_PriceSubprocess      =  " & FormatSQL(z0133.PriceSubprocess) & ", " 
    SQL = SQL & "    K0133_PriceOutsource      =  " & FormatSQL(z0133.PriceOutsource) & ", " 
    SQL = SQL & "    K0133_ExpenseAMT      =  " & FormatSQL(z0133.ExpenseAMT) & ", " 
    SQL = SQL & "    K0133_InsertDate      = N'" & FormatSQL(z0133.InsertDate) & "', " 
    SQL = SQL & "    K0133_InchargeInsert      = N'" & FormatSQL(z0133.InchargeInsert) & "', " 
    SQL = SQL & "    K0133_UpdateDate      = N'" & FormatSQL(z0133.UpdateDate) & "', " 
    SQL = SQL & "    K0133_InchargeUpdate      = N'" & FormatSQL(z0133.InchargeUpdate) & "', " 
    SQL = SQL & "    K0133_AttachID      = N'" & FormatSQL(z0133.AttachID) & "', " 
    SQL = SQL & "    K0133_Remark      = N'" & FormatSQL(z0133.Remark) & "'  " 
    SQL = SQL & " WHERE K0133_SpecNo		 = '" & z0133.SpecNo & "' " 
    SQL = SQL & "   AND K0133_SpecNoSeq		 = '" & z0133.SpecNoSeq & "' " 
    SQL = SQL & "   AND K0133_OverCostSeq		 =  " & z0133.OverCostSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK0133 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK0133",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK0133(z0133 As T0133_AREA) As Boolean
    DELETE_PFK0133 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK0133 "
    SQL = SQL & " WHERE K0133_SpecNo		 = '" & z0133.SpecNo & "' " 
    SQL = SQL & "   AND K0133_SpecNoSeq		 = '" & z0133.SpecNoSeq & "' " 
    SQL = SQL & "   AND K0133_OverCostSeq		 =  " & z0133.OverCostSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK0133 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK0133",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D0133_CLEAR()
Try
    
   D0133.SpecNo = ""
   D0133.SpecNoSeq = ""
    D0133.OverCostSeq = 0 
    D0133.DSeq = 0 
   D0133.Status = ""
   D0133.seOverheadCost = ""
   D0133.cdOverheadCost = ""
    D0133.PriceOutsole = 0 
    D0133.PriceCutting = 0 
    D0133.PriceStitching = 0 
    D0133.PriceStockfit = 0 
    D0133.PriceAssembly = 0 
    D0133.PriceSubprocess = 0 
    D0133.PriceOutsource = 0 
    D0133.ExpenseAMT = 0 
   D0133.InsertDate = ""
   D0133.InchargeInsert = ""
   D0133.UpdateDate = ""
   D0133.InchargeUpdate = ""
   D0133.AttachID = ""
   D0133.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D0133_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x0133 As T0133_AREA)
Try
    
    x0133.SpecNo = trim$(  x0133.SpecNo)
    x0133.SpecNoSeq = trim$(  x0133.SpecNoSeq)
    x0133.OverCostSeq = trim$(  x0133.OverCostSeq)
    x0133.DSeq = trim$(  x0133.DSeq)
    x0133.Status = trim$(  x0133.Status)
    x0133.seOverheadCost = trim$(  x0133.seOverheadCost)
    x0133.cdOverheadCost = trim$(  x0133.cdOverheadCost)
    x0133.PriceOutsole = trim$(  x0133.PriceOutsole)
    x0133.PriceCutting = trim$(  x0133.PriceCutting)
    x0133.PriceStitching = trim$(  x0133.PriceStitching)
    x0133.PriceStockfit = trim$(  x0133.PriceStockfit)
    x0133.PriceAssembly = trim$(  x0133.PriceAssembly)
    x0133.PriceSubprocess = trim$(  x0133.PriceSubprocess)
    x0133.PriceOutsource = trim$(  x0133.PriceOutsource)
    x0133.ExpenseAMT = trim$(  x0133.ExpenseAMT)
    x0133.InsertDate = trim$(  x0133.InsertDate)
    x0133.InchargeInsert = trim$(  x0133.InchargeInsert)
    x0133.UpdateDate = trim$(  x0133.UpdateDate)
    x0133.InchargeUpdate = trim$(  x0133.InchargeUpdate)
    x0133.AttachID = trim$(  x0133.AttachID)
    x0133.Remark = trim$(  x0133.Remark)
     
    If trim$( x0133.SpecNo ) = "" Then x0133.SpecNo = Space(1) 
    If trim$( x0133.SpecNoSeq ) = "" Then x0133.SpecNoSeq = Space(1) 
    If trim$( x0133.OverCostSeq ) = "" Then x0133.OverCostSeq = 0 
    If trim$( x0133.DSeq ) = "" Then x0133.DSeq = 0 
    If trim$( x0133.Status ) = "" Then x0133.Status = Space(1) 
    If trim$( x0133.seOverheadCost ) = "" Then x0133.seOverheadCost = Space(1) 
    If trim$( x0133.cdOverheadCost ) = "" Then x0133.cdOverheadCost = Space(1) 
    If trim$( x0133.PriceOutsole ) = "" Then x0133.PriceOutsole = 0 
    If trim$( x0133.PriceCutting ) = "" Then x0133.PriceCutting = 0 
    If trim$( x0133.PriceStitching ) = "" Then x0133.PriceStitching = 0 
    If trim$( x0133.PriceStockfit ) = "" Then x0133.PriceStockfit = 0 
    If trim$( x0133.PriceAssembly ) = "" Then x0133.PriceAssembly = 0 
    If trim$( x0133.PriceSubprocess ) = "" Then x0133.PriceSubprocess = 0 
    If trim$( x0133.PriceOutsource ) = "" Then x0133.PriceOutsource = 0 
    If trim$( x0133.ExpenseAMT ) = "" Then x0133.ExpenseAMT = 0 
    If trim$( x0133.InsertDate ) = "" Then x0133.InsertDate = Space(1) 
    If trim$( x0133.InchargeInsert ) = "" Then x0133.InchargeInsert = Space(1) 
    If trim$( x0133.UpdateDate ) = "" Then x0133.UpdateDate = Space(1) 
    If trim$( x0133.InchargeUpdate ) = "" Then x0133.InchargeUpdate = Space(1) 
    If trim$( x0133.AttachID ) = "" Then x0133.AttachID = Space(1) 
    If trim$( x0133.Remark ) = "" Then x0133.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K0133_MOVE(rs0133 As SqlClient.SqlDataReader)
Try

    call D0133_CLEAR()   

    If IsdbNull(rs0133!K0133_SpecNo) = False Then D0133.SpecNo = Trim$(rs0133!K0133_SpecNo)
    If IsdbNull(rs0133!K0133_SpecNoSeq) = False Then D0133.SpecNoSeq = Trim$(rs0133!K0133_SpecNoSeq)
    If IsdbNull(rs0133!K0133_OverCostSeq) = False Then D0133.OverCostSeq = Trim$(rs0133!K0133_OverCostSeq)
    If IsdbNull(rs0133!K0133_DSeq) = False Then D0133.DSeq = Trim$(rs0133!K0133_DSeq)
    If IsdbNull(rs0133!K0133_Status) = False Then D0133.Status = Trim$(rs0133!K0133_Status)
    If IsdbNull(rs0133!K0133_seOverheadCost) = False Then D0133.seOverheadCost = Trim$(rs0133!K0133_seOverheadCost)
    If IsdbNull(rs0133!K0133_cdOverheadCost) = False Then D0133.cdOverheadCost = Trim$(rs0133!K0133_cdOverheadCost)
    If IsdbNull(rs0133!K0133_PriceOutsole) = False Then D0133.PriceOutsole = Trim$(rs0133!K0133_PriceOutsole)
    If IsdbNull(rs0133!K0133_PriceCutting) = False Then D0133.PriceCutting = Trim$(rs0133!K0133_PriceCutting)
    If IsdbNull(rs0133!K0133_PriceStitching) = False Then D0133.PriceStitching = Trim$(rs0133!K0133_PriceStitching)
    If IsdbNull(rs0133!K0133_PriceStockfit) = False Then D0133.PriceStockfit = Trim$(rs0133!K0133_PriceStockfit)
    If IsdbNull(rs0133!K0133_PriceAssembly) = False Then D0133.PriceAssembly = Trim$(rs0133!K0133_PriceAssembly)
    If IsdbNull(rs0133!K0133_PriceSubprocess) = False Then D0133.PriceSubprocess = Trim$(rs0133!K0133_PriceSubprocess)
    If IsdbNull(rs0133!K0133_PriceOutsource) = False Then D0133.PriceOutsource = Trim$(rs0133!K0133_PriceOutsource)
    If IsdbNull(rs0133!K0133_ExpenseAMT) = False Then D0133.ExpenseAMT = Trim$(rs0133!K0133_ExpenseAMT)
    If IsdbNull(rs0133!K0133_InsertDate) = False Then D0133.InsertDate = Trim$(rs0133!K0133_InsertDate)
    If IsdbNull(rs0133!K0133_InchargeInsert) = False Then D0133.InchargeInsert = Trim$(rs0133!K0133_InchargeInsert)
    If IsdbNull(rs0133!K0133_UpdateDate) = False Then D0133.UpdateDate = Trim$(rs0133!K0133_UpdateDate)
    If IsdbNull(rs0133!K0133_InchargeUpdate) = False Then D0133.InchargeUpdate = Trim$(rs0133!K0133_InchargeUpdate)
    If IsdbNull(rs0133!K0133_AttachID) = False Then D0133.AttachID = Trim$(rs0133!K0133_AttachID)
    If IsdbNull(rs0133!K0133_Remark) = False Then D0133.Remark = Trim$(rs0133!K0133_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0133_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K0133_MOVE(rs0133 As DataRow)
Try

    call D0133_CLEAR()   

    If IsdbNull(rs0133!K0133_SpecNo) = False Then D0133.SpecNo = Trim$(rs0133!K0133_SpecNo)
    If IsdbNull(rs0133!K0133_SpecNoSeq) = False Then D0133.SpecNoSeq = Trim$(rs0133!K0133_SpecNoSeq)
    If IsdbNull(rs0133!K0133_OverCostSeq) = False Then D0133.OverCostSeq = Trim$(rs0133!K0133_OverCostSeq)
    If IsdbNull(rs0133!K0133_DSeq) = False Then D0133.DSeq = Trim$(rs0133!K0133_DSeq)
    If IsdbNull(rs0133!K0133_Status) = False Then D0133.Status = Trim$(rs0133!K0133_Status)
    If IsdbNull(rs0133!K0133_seOverheadCost) = False Then D0133.seOverheadCost = Trim$(rs0133!K0133_seOverheadCost)
    If IsdbNull(rs0133!K0133_cdOverheadCost) = False Then D0133.cdOverheadCost = Trim$(rs0133!K0133_cdOverheadCost)
    If IsdbNull(rs0133!K0133_PriceOutsole) = False Then D0133.PriceOutsole = Trim$(rs0133!K0133_PriceOutsole)
    If IsdbNull(rs0133!K0133_PriceCutting) = False Then D0133.PriceCutting = Trim$(rs0133!K0133_PriceCutting)
    If IsdbNull(rs0133!K0133_PriceStitching) = False Then D0133.PriceStitching = Trim$(rs0133!K0133_PriceStitching)
    If IsdbNull(rs0133!K0133_PriceStockfit) = False Then D0133.PriceStockfit = Trim$(rs0133!K0133_PriceStockfit)
    If IsdbNull(rs0133!K0133_PriceAssembly) = False Then D0133.PriceAssembly = Trim$(rs0133!K0133_PriceAssembly)
    If IsdbNull(rs0133!K0133_PriceSubprocess) = False Then D0133.PriceSubprocess = Trim$(rs0133!K0133_PriceSubprocess)
    If IsdbNull(rs0133!K0133_PriceOutsource) = False Then D0133.PriceOutsource = Trim$(rs0133!K0133_PriceOutsource)
    If IsdbNull(rs0133!K0133_ExpenseAMT) = False Then D0133.ExpenseAMT = Trim$(rs0133!K0133_ExpenseAMT)
    If IsdbNull(rs0133!K0133_InsertDate) = False Then D0133.InsertDate = Trim$(rs0133!K0133_InsertDate)
    If IsdbNull(rs0133!K0133_InchargeInsert) = False Then D0133.InchargeInsert = Trim$(rs0133!K0133_InchargeInsert)
    If IsdbNull(rs0133!K0133_UpdateDate) = False Then D0133.UpdateDate = Trim$(rs0133!K0133_UpdateDate)
    If IsdbNull(rs0133!K0133_InchargeUpdate) = False Then D0133.InchargeUpdate = Trim$(rs0133!K0133_InchargeUpdate)
    If IsdbNull(rs0133!K0133_AttachID) = False Then D0133.AttachID = Trim$(rs0133!K0133_AttachID)
    If IsdbNull(rs0133!K0133_Remark) = False Then D0133.Remark = Trim$(rs0133!K0133_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0133_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K0133_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0133 As T0133_AREA, SPECNO AS String, SPECNOSEQ AS String, OVERCOSTSEQ AS Double) as Boolean

K0133_MOVE = False

Try
    If READ_PFK0133(SPECNO, SPECNOSEQ, OVERCOSTSEQ) = True Then
                z0133 = D0133
		K0133_MOVE = True
		else
	z0133 = nothing
     End If

     If  getColumIndex(spr,"SpecNo") > -1 then z0133.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z0133.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"OverCostSeq") > -1 then z0133.OverCostSeq = getDataM(spr, getColumIndex(spr,"OverCostSeq"), xRow)
     If  getColumIndex(spr,"DSeq") > -1 then z0133.DSeq = getDataM(spr, getColumIndex(spr,"DSeq"), xRow)
     If  getColumIndex(spr,"Status") > -1 then z0133.Status = getDataM(spr, getColumIndex(spr,"Status"), xRow)
     If  getColumIndex(spr,"seOverheadCost") > -1 then z0133.seOverheadCost = getDataM(spr, getColumIndex(spr,"seOverheadCost"), xRow)
     If  getColumIndex(spr,"cdOverheadCost") > -1 then z0133.cdOverheadCost = getDataM(spr, getColumIndex(spr,"cdOverheadCost"), xRow)
     If  getColumIndex(spr,"PriceOutsole") > -1 then z0133.PriceOutsole = getDataM(spr, getColumIndex(spr,"PriceOutsole"), xRow)
     If  getColumIndex(spr,"PriceCutting") > -1 then z0133.PriceCutting = getDataM(spr, getColumIndex(spr,"PriceCutting"), xRow)
     If  getColumIndex(spr,"PriceStitching") > -1 then z0133.PriceStitching = getDataM(spr, getColumIndex(spr,"PriceStitching"), xRow)
     If  getColumIndex(spr,"PriceStockfit") > -1 then z0133.PriceStockfit = getDataM(spr, getColumIndex(spr,"PriceStockfit"), xRow)
     If  getColumIndex(spr,"PriceAssembly") > -1 then z0133.PriceAssembly = getDataM(spr, getColumIndex(spr,"PriceAssembly"), xRow)
     If  getColumIndex(spr,"PriceSubprocess") > -1 then z0133.PriceSubprocess = getDataM(spr, getColumIndex(spr,"PriceSubprocess"), xRow)
     If  getColumIndex(spr,"PriceOutsource") > -1 then z0133.PriceOutsource = getDataM(spr, getColumIndex(spr,"PriceOutsource"), xRow)
     If  getColumIndex(spr,"ExpenseAMT") > -1 then z0133.ExpenseAMT = getDataM(spr, getColumIndex(spr,"ExpenseAMT"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z0133.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z0133.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z0133.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z0133.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z0133.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0133.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0133_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K0133_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0133 As T0133_AREA,CheckClear as Boolean,SPECNO AS String, SPECNOSEQ AS String, OVERCOSTSEQ AS Double) as Boolean

K0133_MOVE = False

Try
    If READ_PFK0133(SPECNO, SPECNOSEQ, OVERCOSTSEQ) = True Then
                z0133 = D0133
		K0133_MOVE = True
		else
	If CheckClear  = True then z0133 = nothing
     End If

     If  getColumIndex(spr,"SpecNo") > -1 then z0133.SpecNo = getDataM(spr, getColumIndex(spr,"SpecNo"), xRow)
     If  getColumIndex(spr,"SpecNoSeq") > -1 then z0133.SpecNoSeq = getDataM(spr, getColumIndex(spr,"SpecNoSeq"), xRow)
     If  getColumIndex(spr,"OverCostSeq") > -1 then z0133.OverCostSeq = getDataM(spr, getColumIndex(spr,"OverCostSeq"), xRow)
     If  getColumIndex(spr,"DSeq") > -1 then z0133.DSeq = getDataM(spr, getColumIndex(spr,"DSeq"), xRow)
     If  getColumIndex(spr,"Status") > -1 then z0133.Status = getDataM(spr, getColumIndex(spr,"Status"), xRow)
     If  getColumIndex(spr,"seOverheadCost") > -1 then z0133.seOverheadCost = getDataM(spr, getColumIndex(spr,"seOverheadCost"), xRow)
     If  getColumIndex(spr,"cdOverheadCost") > -1 then z0133.cdOverheadCost = getDataM(spr, getColumIndex(spr,"cdOverheadCost"), xRow)
     If  getColumIndex(spr,"PriceOutsole") > -1 then z0133.PriceOutsole = getDataM(spr, getColumIndex(spr,"PriceOutsole"), xRow)
     If  getColumIndex(spr,"PriceCutting") > -1 then z0133.PriceCutting = getDataM(spr, getColumIndex(spr,"PriceCutting"), xRow)
     If  getColumIndex(spr,"PriceStitching") > -1 then z0133.PriceStitching = getDataM(spr, getColumIndex(spr,"PriceStitching"), xRow)
     If  getColumIndex(spr,"PriceStockfit") > -1 then z0133.PriceStockfit = getDataM(spr, getColumIndex(spr,"PriceStockfit"), xRow)
     If  getColumIndex(spr,"PriceAssembly") > -1 then z0133.PriceAssembly = getDataM(spr, getColumIndex(spr,"PriceAssembly"), xRow)
     If  getColumIndex(spr,"PriceSubprocess") > -1 then z0133.PriceSubprocess = getDataM(spr, getColumIndex(spr,"PriceSubprocess"), xRow)
     If  getColumIndex(spr,"PriceOutsource") > -1 then z0133.PriceOutsource = getDataM(spr, getColumIndex(spr,"PriceOutsource"), xRow)
     If  getColumIndex(spr,"ExpenseAMT") > -1 then z0133.ExpenseAMT = getDataM(spr, getColumIndex(spr,"ExpenseAMT"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z0133.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z0133.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z0133.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z0133.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"AttachID") > -1 then z0133.AttachID = getDataM(spr, getColumIndex(spr,"AttachID"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0133.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0133_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K0133_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0133 As T0133_AREA, Job as String, SPECNO AS String, SPECNOSEQ AS String, OVERCOSTSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0133_MOVE = False

Try
    If READ_PFK0133(SPECNO, SPECNOSEQ, OVERCOSTSEQ) = True Then
                z0133 = D0133
		K0133_MOVE = True
		else
	z0133 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0133")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SPECNO":z0133.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z0133.SpecNoSeq = Children(i).Code
   Case "OVERCOSTSEQ":z0133.OverCostSeq = Children(i).Code
   Case "DSEQ":z0133.DSeq = Children(i).Code
   Case "STATUS":z0133.Status = Children(i).Code
   Case "SEOVERHEADCOST":z0133.seOverheadCost = Children(i).Code
   Case "CDOVERHEADCOST":z0133.cdOverheadCost = Children(i).Code
   Case "PRICEOUTSOLE":z0133.PriceOutsole = Children(i).Code
   Case "PRICECUTTING":z0133.PriceCutting = Children(i).Code
   Case "PRICESTITCHING":z0133.PriceStitching = Children(i).Code
   Case "PRICESTOCKFIT":z0133.PriceStockfit = Children(i).Code
   Case "PRICEASSEMBLY":z0133.PriceAssembly = Children(i).Code
   Case "PRICESUBPROCESS":z0133.PriceSubprocess = Children(i).Code
   Case "PRICEOUTSOURCE":z0133.PriceOutsource = Children(i).Code
   Case "EXPENSEAMT":z0133.ExpenseAMT = Children(i).Code
   Case "INSERTDATE":z0133.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z0133.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z0133.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z0133.InchargeUpdate = Children(i).Code
   Case "ATTACHID":z0133.AttachID = Children(i).Code
   Case "REMARK":z0133.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SPECNO":z0133.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z0133.SpecNoSeq = Children(i).Data
   Case "OVERCOSTSEQ":z0133.OverCostSeq = Children(i).Data
   Case "DSEQ":z0133.DSeq = Children(i).Data
   Case "STATUS":z0133.Status = Children(i).Data
   Case "SEOVERHEADCOST":z0133.seOverheadCost = Children(i).Data
   Case "CDOVERHEADCOST":z0133.cdOverheadCost = Children(i).Data
   Case "PRICEOUTSOLE":z0133.PriceOutsole = Children(i).Data
   Case "PRICECUTTING":z0133.PriceCutting = Children(i).Data
   Case "PRICESTITCHING":z0133.PriceStitching = Children(i).Data
   Case "PRICESTOCKFIT":z0133.PriceStockfit = Children(i).Data
   Case "PRICEASSEMBLY":z0133.PriceAssembly = Children(i).Data
   Case "PRICESUBPROCESS":z0133.PriceSubprocess = Children(i).Data
   Case "PRICEOUTSOURCE":z0133.PriceOutsource = Children(i).Data
   Case "EXPENSEAMT":z0133.ExpenseAMT = Children(i).Data
   Case "INSERTDATE":z0133.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z0133.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z0133.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z0133.InchargeUpdate = Children(i).Data
   Case "ATTACHID":z0133.AttachID = Children(i).Data
   Case "REMARK":z0133.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0133_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K0133_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0133 As T0133_AREA, Job as String, CheckClear as Boolean, SPECNO AS String, SPECNOSEQ AS String, OVERCOSTSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0133_MOVE = False

Try
    If READ_PFK0133(SPECNO, SPECNOSEQ, OVERCOSTSEQ) = True Then
                z0133 = D0133
		K0133_MOVE = True
		else
	If CheckClear  = True then z0133 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0133")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SPECNO":z0133.SpecNo = Children(i).Code
   Case "SPECNOSEQ":z0133.SpecNoSeq = Children(i).Code
   Case "OVERCOSTSEQ":z0133.OverCostSeq = Children(i).Code
   Case "DSEQ":z0133.DSeq = Children(i).Code
   Case "STATUS":z0133.Status = Children(i).Code
   Case "SEOVERHEADCOST":z0133.seOverheadCost = Children(i).Code
   Case "CDOVERHEADCOST":z0133.cdOverheadCost = Children(i).Code
   Case "PRICEOUTSOLE":z0133.PriceOutsole = Children(i).Code
   Case "PRICECUTTING":z0133.PriceCutting = Children(i).Code
   Case "PRICESTITCHING":z0133.PriceStitching = Children(i).Code
   Case "PRICESTOCKFIT":z0133.PriceStockfit = Children(i).Code
   Case "PRICEASSEMBLY":z0133.PriceAssembly = Children(i).Code
   Case "PRICESUBPROCESS":z0133.PriceSubprocess = Children(i).Code
   Case "PRICEOUTSOURCE":z0133.PriceOutsource = Children(i).Code
   Case "EXPENSEAMT":z0133.ExpenseAMT = Children(i).Code
   Case "INSERTDATE":z0133.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z0133.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z0133.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z0133.InchargeUpdate = Children(i).Code
   Case "ATTACHID":z0133.AttachID = Children(i).Code
   Case "REMARK":z0133.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SPECNO":z0133.SpecNo = Children(i).Data
   Case "SPECNOSEQ":z0133.SpecNoSeq = Children(i).Data
   Case "OVERCOSTSEQ":z0133.OverCostSeq = Children(i).Data
   Case "DSEQ":z0133.DSeq = Children(i).Data
   Case "STATUS":z0133.Status = Children(i).Data
   Case "SEOVERHEADCOST":z0133.seOverheadCost = Children(i).Data
   Case "CDOVERHEADCOST":z0133.cdOverheadCost = Children(i).Data
   Case "PRICEOUTSOLE":z0133.PriceOutsole = Children(i).Data
   Case "PRICECUTTING":z0133.PriceCutting = Children(i).Data
   Case "PRICESTITCHING":z0133.PriceStitching = Children(i).Data
   Case "PRICESTOCKFIT":z0133.PriceStockfit = Children(i).Data
   Case "PRICEASSEMBLY":z0133.PriceAssembly = Children(i).Data
   Case "PRICESUBPROCESS":z0133.PriceSubprocess = Children(i).Data
   Case "PRICEOUTSOURCE":z0133.PriceOutsource = Children(i).Data
   Case "EXPENSEAMT":z0133.ExpenseAMT = Children(i).Data
   Case "INSERTDATE":z0133.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z0133.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z0133.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z0133.InchargeUpdate = Children(i).Data
   Case "ATTACHID":z0133.AttachID = Children(i).Data
   Case "REMARK":z0133.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0133_MOVE",vbCritical)
End Try
End Function 
    
End Module 
