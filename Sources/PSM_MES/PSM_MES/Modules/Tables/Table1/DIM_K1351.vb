'=========================================================================================================================================================
'   TABLE : (PFK1351)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K1351

Structure T1351_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	PINo	 AS String	'			char(15)		*
Public 	PINoSeq	 AS String	'			char(3)		*
Public 	OrderNo	 AS String	'			char(9)
Public 	OrderNoSeq	 AS String	'			char(3)
Public 	PKO	 AS String	'			nvarchar(50)
Public 	Article	 AS String	'			nvarchar(100)
Public 	Line	 AS String	'			nvarchar(100)
Public 	Color	 AS String	'			nvarchar(100)
Public 	MaterialCode	 AS String	'			char(6)
Public 	MoldCode	 AS String	'			char(8)
Public 	SizeRange	 AS String	'			char(6)
Public 	SpecificSize	 AS String	'			varchar(50)
Public 	DateExchangePrice	 AS String	'			char(8)
Public 	PriceOrder	 AS Double	'			decimal
Public 	UnitPrice	 AS String	'			char(3)
Public 	QtyOrder	 AS Double	'			decimal
Public 	InchargeSales	 AS String	'			char(8)
Public 	InchargePPC	 AS String	'			char(8)
Public 	TotalQty	 AS Double	'			decimal
Public 	TotalAMT	 AS Double	'			decimal
Public 	AcceptedPI	 AS String	'			char(1)
Public 	Destination	 AS String	'			nvarchar(500)
Public 	RemarkOrder	 AS String	'			nvarchar(500)
'=========================================================================================================================================================
End structure

Public D1351 As T1351_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK1351(PINO AS String, PINOSEQ AS String) As Boolean
    READ_PFK1351 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK1351 "
    SQL = SQL & " WHERE K1351_PINo		 = '" & PINo & "' " 
    SQL = SQL & "   AND K1351_PINoSeq		 = '" & PINoSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D1351_CLEAR: GoTo SKIP_READ_PFK1351
                
    Call K1351_MOVE(rd)
    READ_PFK1351 = True

SKIP_READ_PFK1351:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK1351",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK1351(PINO AS String, PINOSEQ AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK1351 "
    SQL = SQL & " WHERE K1351_PINo		 = '" & PINo & "' " 
    SQL = SQL & "   AND K1351_PINoSeq		 = '" & PINoSeq & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK1351",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK1351(z1351 As T1351_AREA) As Boolean
    WRITE_PFK1351 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z1351)
 
    SQL = " INSERT INTO PFK1351 "
    SQL = SQL & " ( "
    SQL = SQL & " K1351_PINo," 
    SQL = SQL & " K1351_PINoSeq," 
    SQL = SQL & " K1351_OrderNo," 
    SQL = SQL & " K1351_OrderNoSeq," 
    SQL = SQL & " K1351_PKO," 
    SQL = SQL & " K1351_Article," 
    SQL = SQL & " K1351_Line," 
    SQL = SQL & " K1351_Color," 
    SQL = SQL & " K1351_MaterialCode," 
    SQL = SQL & " K1351_MoldCode," 
    SQL = SQL & " K1351_SizeRange," 
    SQL = SQL & " K1351_SpecificSize," 
    SQL = SQL & " K1351_DateExchangePrice," 
    SQL = SQL & " K1351_PriceOrder," 
    SQL = SQL & " K1351_UnitPrice," 
    SQL = SQL & " K1351_QtyOrder," 
    SQL = SQL & " K1351_InchargeSales," 
    SQL = SQL & " K1351_InchargePPC," 
    SQL = SQL & " K1351_TotalQty," 
    SQL = SQL & " K1351_TotalAMT," 
    SQL = SQL & " K1351_AcceptedPI," 
    SQL = SQL & " K1351_Destination," 
    SQL = SQL & " K1351_RemarkOrder " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z1351.PINo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1351.PINoSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1351.OrderNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1351.OrderNoSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1351.PKO) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1351.Article) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1351.Line) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1351.Color) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1351.MaterialCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1351.MoldCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1351.SizeRange) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1351.SpecificSize) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1351.DateExchangePrice) & "', "  
    SQL = SQL & "   " & FormatSQL(z1351.PriceOrder) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z1351.UnitPrice) & "', "  
    SQL = SQL & "   " & FormatSQL(z1351.QtyOrder) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z1351.InchargeSales) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1351.InchargePPC) & "', "  
    SQL = SQL & "   " & FormatSQL(z1351.TotalQty) & ", "  
    SQL = SQL & "   " & FormatSQL(z1351.TotalAMT) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z1351.AcceptedPI) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1351.Destination) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z1351.RemarkOrder) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK1351 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK1351",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK1351(z1351 As T1351_AREA) As Boolean
    REWRITE_PFK1351 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z1351)
   
    SQL = " UPDATE PFK1351 SET "
    SQL = SQL & "    K1351_OrderNo      = N'" & FormatSQL(z1351.OrderNo) & "', " 
    SQL = SQL & "    K1351_OrderNoSeq      = N'" & FormatSQL(z1351.OrderNoSeq) & "', " 
    SQL = SQL & "    K1351_PKO      = N'" & FormatSQL(z1351.PKO) & "', " 
    SQL = SQL & "    K1351_Article      = N'" & FormatSQL(z1351.Article) & "', " 
    SQL = SQL & "    K1351_Line      = N'" & FormatSQL(z1351.Line) & "', " 
    SQL = SQL & "    K1351_Color      = N'" & FormatSQL(z1351.Color) & "', " 
    SQL = SQL & "    K1351_MaterialCode      = N'" & FormatSQL(z1351.MaterialCode) & "', " 
    SQL = SQL & "    K1351_MoldCode      = N'" & FormatSQL(z1351.MoldCode) & "', " 
    SQL = SQL & "    K1351_SizeRange      = N'" & FormatSQL(z1351.SizeRange) & "', " 
    SQL = SQL & "    K1351_SpecificSize      = N'" & FormatSQL(z1351.SpecificSize) & "', " 
    SQL = SQL & "    K1351_DateExchangePrice      = N'" & FormatSQL(z1351.DateExchangePrice) & "', " 
    SQL = SQL & "    K1351_PriceOrder      =  " & FormatSQL(z1351.PriceOrder) & ", " 
    SQL = SQL & "    K1351_UnitPrice      = N'" & FormatSQL(z1351.UnitPrice) & "', " 
    SQL = SQL & "    K1351_QtyOrder      =  " & FormatSQL(z1351.QtyOrder) & ", " 
    SQL = SQL & "    K1351_InchargeSales      = N'" & FormatSQL(z1351.InchargeSales) & "', " 
    SQL = SQL & "    K1351_InchargePPC      = N'" & FormatSQL(z1351.InchargePPC) & "', " 
    SQL = SQL & "    K1351_TotalQty      =  " & FormatSQL(z1351.TotalQty) & ", " 
    SQL = SQL & "    K1351_TotalAMT      =  " & FormatSQL(z1351.TotalAMT) & ", " 
    SQL = SQL & "    K1351_AcceptedPI      = N'" & FormatSQL(z1351.AcceptedPI) & "', " 
    SQL = SQL & "    K1351_Destination      = N'" & FormatSQL(z1351.Destination) & "', " 
    SQL = SQL & "    K1351_RemarkOrder      = N'" & FormatSQL(z1351.RemarkOrder) & "'  " 
    SQL = SQL & " WHERE K1351_PINo		 = '" & z1351.PINo & "' " 
    SQL = SQL & "   AND K1351_PINoSeq		 = '" & z1351.PINoSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK1351 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK1351",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK1351(z1351 As T1351_AREA) As Boolean
    DELETE_PFK1351 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK1351 "
    SQL = SQL & " WHERE K1351_PINo		 = '" & z1351.PINo & "' " 
    SQL = SQL & "   AND K1351_PINoSeq		 = '" & z1351.PINoSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK1351 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK1351",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D1351_CLEAR()
Try
    
   D1351.PINo = ""
   D1351.PINoSeq = ""
   D1351.OrderNo = ""
   D1351.OrderNoSeq = ""
   D1351.PKO = ""
   D1351.Article = ""
   D1351.Line = ""
   D1351.Color = ""
   D1351.MaterialCode = ""
   D1351.MoldCode = ""
   D1351.SizeRange = ""
   D1351.SpecificSize = ""
   D1351.DateExchangePrice = ""
    D1351.PriceOrder = 0 
   D1351.UnitPrice = ""
    D1351.QtyOrder = 0 
   D1351.InchargeSales = ""
   D1351.InchargePPC = ""
    D1351.TotalQty = 0 
    D1351.TotalAMT = 0 
   D1351.AcceptedPI = ""
   D1351.Destination = ""
   D1351.RemarkOrder = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D1351_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x1351 As T1351_AREA)
Try
    
    x1351.PINo = trim$(  x1351.PINo)
    x1351.PINoSeq = trim$(  x1351.PINoSeq)
    x1351.OrderNo = trim$(  x1351.OrderNo)
    x1351.OrderNoSeq = trim$(  x1351.OrderNoSeq)
    x1351.PKO = trim$(  x1351.PKO)
    x1351.Article = trim$(  x1351.Article)
    x1351.Line = trim$(  x1351.Line)
    x1351.Color = trim$(  x1351.Color)
    x1351.MaterialCode = trim$(  x1351.MaterialCode)
    x1351.MoldCode = trim$(  x1351.MoldCode)
    x1351.SizeRange = trim$(  x1351.SizeRange)
    x1351.SpecificSize = trim$(  x1351.SpecificSize)
    x1351.DateExchangePrice = trim$(  x1351.DateExchangePrice)
    x1351.PriceOrder = trim$(  x1351.PriceOrder)
    x1351.UnitPrice = trim$(  x1351.UnitPrice)
    x1351.QtyOrder = trim$(  x1351.QtyOrder)
    x1351.InchargeSales = trim$(  x1351.InchargeSales)
    x1351.InchargePPC = trim$(  x1351.InchargePPC)
    x1351.TotalQty = trim$(  x1351.TotalQty)
    x1351.TotalAMT = trim$(  x1351.TotalAMT)
    x1351.AcceptedPI = trim$(  x1351.AcceptedPI)
    x1351.Destination = trim$(  x1351.Destination)
    x1351.RemarkOrder = trim$(  x1351.RemarkOrder)
     
    If trim$( x1351.PINo ) = "" Then x1351.PINo = Space(1) 
    If trim$( x1351.PINoSeq ) = "" Then x1351.PINoSeq = Space(1) 
    If trim$( x1351.OrderNo ) = "" Then x1351.OrderNo = Space(1) 
    If trim$( x1351.OrderNoSeq ) = "" Then x1351.OrderNoSeq = Space(1) 
    If trim$( x1351.PKO ) = "" Then x1351.PKO = Space(1) 
    If trim$( x1351.Article ) = "" Then x1351.Article = Space(1) 
    If trim$( x1351.Line ) = "" Then x1351.Line = Space(1) 
    If trim$( x1351.Color ) = "" Then x1351.Color = Space(1) 
    If trim$( x1351.MaterialCode ) = "" Then x1351.MaterialCode = Space(1) 
    If trim$( x1351.MoldCode ) = "" Then x1351.MoldCode = Space(1) 
    If trim$( x1351.SizeRange ) = "" Then x1351.SizeRange = Space(1) 
    If trim$( x1351.SpecificSize ) = "" Then x1351.SpecificSize = Space(1) 
    If trim$( x1351.DateExchangePrice ) = "" Then x1351.DateExchangePrice = Space(1) 
    If trim$( x1351.PriceOrder ) = "" Then x1351.PriceOrder = 0 
    If trim$( x1351.UnitPrice ) = "" Then x1351.UnitPrice = Space(1) 
    If trim$( x1351.QtyOrder ) = "" Then x1351.QtyOrder = 0 
    If trim$( x1351.InchargeSales ) = "" Then x1351.InchargeSales = Space(1) 
    If trim$( x1351.InchargePPC ) = "" Then x1351.InchargePPC = Space(1) 
    If trim$( x1351.TotalQty ) = "" Then x1351.TotalQty = 0 
    If trim$( x1351.TotalAMT ) = "" Then x1351.TotalAMT = 0 
    If trim$( x1351.AcceptedPI ) = "" Then x1351.AcceptedPI = Space(1) 
    If trim$( x1351.Destination ) = "" Then x1351.Destination = Space(1) 
    If trim$( x1351.RemarkOrder ) = "" Then x1351.RemarkOrder = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K1351_MOVE(rs1351 As SqlClient.SqlDataReader)
Try

    call D1351_CLEAR()   

    If IsdbNull(rs1351!K1351_PINo) = False Then D1351.PINo = Trim$(rs1351!K1351_PINo)
    If IsdbNull(rs1351!K1351_PINoSeq) = False Then D1351.PINoSeq = Trim$(rs1351!K1351_PINoSeq)
    If IsdbNull(rs1351!K1351_OrderNo) = False Then D1351.OrderNo = Trim$(rs1351!K1351_OrderNo)
    If IsdbNull(rs1351!K1351_OrderNoSeq) = False Then D1351.OrderNoSeq = Trim$(rs1351!K1351_OrderNoSeq)
    If IsdbNull(rs1351!K1351_PKO) = False Then D1351.PKO = Trim$(rs1351!K1351_PKO)
    If IsdbNull(rs1351!K1351_Article) = False Then D1351.Article = Trim$(rs1351!K1351_Article)
    If IsdbNull(rs1351!K1351_Line) = False Then D1351.Line = Trim$(rs1351!K1351_Line)
    If IsdbNull(rs1351!K1351_Color) = False Then D1351.Color = Trim$(rs1351!K1351_Color)
    If IsdbNull(rs1351!K1351_MaterialCode) = False Then D1351.MaterialCode = Trim$(rs1351!K1351_MaterialCode)
    If IsdbNull(rs1351!K1351_MoldCode) = False Then D1351.MoldCode = Trim$(rs1351!K1351_MoldCode)
    If IsdbNull(rs1351!K1351_SizeRange) = False Then D1351.SizeRange = Trim$(rs1351!K1351_SizeRange)
    If IsdbNull(rs1351!K1351_SpecificSize) = False Then D1351.SpecificSize = Trim$(rs1351!K1351_SpecificSize)
    If IsdbNull(rs1351!K1351_DateExchangePrice) = False Then D1351.DateExchangePrice = Trim$(rs1351!K1351_DateExchangePrice)
    If IsdbNull(rs1351!K1351_PriceOrder) = False Then D1351.PriceOrder = Trim$(rs1351!K1351_PriceOrder)
    If IsdbNull(rs1351!K1351_UnitPrice) = False Then D1351.UnitPrice = Trim$(rs1351!K1351_UnitPrice)
    If IsdbNull(rs1351!K1351_QtyOrder) = False Then D1351.QtyOrder = Trim$(rs1351!K1351_QtyOrder)
    If IsdbNull(rs1351!K1351_InchargeSales) = False Then D1351.InchargeSales = Trim$(rs1351!K1351_InchargeSales)
    If IsdbNull(rs1351!K1351_InchargePPC) = False Then D1351.InchargePPC = Trim$(rs1351!K1351_InchargePPC)
    If IsdbNull(rs1351!K1351_TotalQty) = False Then D1351.TotalQty = Trim$(rs1351!K1351_TotalQty)
    If IsdbNull(rs1351!K1351_TotalAMT) = False Then D1351.TotalAMT = Trim$(rs1351!K1351_TotalAMT)
    If IsdbNull(rs1351!K1351_AcceptedPI) = False Then D1351.AcceptedPI = Trim$(rs1351!K1351_AcceptedPI)
    If IsdbNull(rs1351!K1351_Destination) = False Then D1351.Destination = Trim$(rs1351!K1351_Destination)
    If IsdbNull(rs1351!K1351_RemarkOrder) = False Then D1351.RemarkOrder = Trim$(rs1351!K1351_RemarkOrder)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K1351_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K1351_MOVE(rs1351 As DataRow)
Try

    call D1351_CLEAR()   

    If IsdbNull(rs1351!K1351_PINo) = False Then D1351.PINo = Trim$(rs1351!K1351_PINo)
    If IsdbNull(rs1351!K1351_PINoSeq) = False Then D1351.PINoSeq = Trim$(rs1351!K1351_PINoSeq)
    If IsdbNull(rs1351!K1351_OrderNo) = False Then D1351.OrderNo = Trim$(rs1351!K1351_OrderNo)
    If IsdbNull(rs1351!K1351_OrderNoSeq) = False Then D1351.OrderNoSeq = Trim$(rs1351!K1351_OrderNoSeq)
    If IsdbNull(rs1351!K1351_PKO) = False Then D1351.PKO = Trim$(rs1351!K1351_PKO)
    If IsdbNull(rs1351!K1351_Article) = False Then D1351.Article = Trim$(rs1351!K1351_Article)
    If IsdbNull(rs1351!K1351_Line) = False Then D1351.Line = Trim$(rs1351!K1351_Line)
    If IsdbNull(rs1351!K1351_Color) = False Then D1351.Color = Trim$(rs1351!K1351_Color)
    If IsdbNull(rs1351!K1351_MaterialCode) = False Then D1351.MaterialCode = Trim$(rs1351!K1351_MaterialCode)
    If IsdbNull(rs1351!K1351_MoldCode) = False Then D1351.MoldCode = Trim$(rs1351!K1351_MoldCode)
    If IsdbNull(rs1351!K1351_SizeRange) = False Then D1351.SizeRange = Trim$(rs1351!K1351_SizeRange)
    If IsdbNull(rs1351!K1351_SpecificSize) = False Then D1351.SpecificSize = Trim$(rs1351!K1351_SpecificSize)
    If IsdbNull(rs1351!K1351_DateExchangePrice) = False Then D1351.DateExchangePrice = Trim$(rs1351!K1351_DateExchangePrice)
    If IsdbNull(rs1351!K1351_PriceOrder) = False Then D1351.PriceOrder = Trim$(rs1351!K1351_PriceOrder)
    If IsdbNull(rs1351!K1351_UnitPrice) = False Then D1351.UnitPrice = Trim$(rs1351!K1351_UnitPrice)
    If IsdbNull(rs1351!K1351_QtyOrder) = False Then D1351.QtyOrder = Trim$(rs1351!K1351_QtyOrder)
    If IsdbNull(rs1351!K1351_InchargeSales) = False Then D1351.InchargeSales = Trim$(rs1351!K1351_InchargeSales)
    If IsdbNull(rs1351!K1351_InchargePPC) = False Then D1351.InchargePPC = Trim$(rs1351!K1351_InchargePPC)
    If IsdbNull(rs1351!K1351_TotalQty) = False Then D1351.TotalQty = Trim$(rs1351!K1351_TotalQty)
    If IsdbNull(rs1351!K1351_TotalAMT) = False Then D1351.TotalAMT = Trim$(rs1351!K1351_TotalAMT)
    If IsdbNull(rs1351!K1351_AcceptedPI) = False Then D1351.AcceptedPI = Trim$(rs1351!K1351_AcceptedPI)
    If IsdbNull(rs1351!K1351_Destination) = False Then D1351.Destination = Trim$(rs1351!K1351_Destination)
    If IsdbNull(rs1351!K1351_RemarkOrder) = False Then D1351.RemarkOrder = Trim$(rs1351!K1351_RemarkOrder)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K1351_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K1351_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z1351 As T1351_AREA, PINO AS String, PINOSEQ AS String) as Boolean

K1351_MOVE = False

Try
    If READ_PFK1351(PINO, PINOSEQ) = True Then
                z1351 = D1351
		K1351_MOVE = True
		else
	z1351 = nothing
     End If

     If  getColumIndex(spr,"PINo") > -1 then z1351.PINo = getDataM(spr, getColumIndex(spr,"PINo"), xRow)
     If  getColumIndex(spr,"PINoSeq") > -1 then z1351.PINoSeq = getDataM(spr, getColumIndex(spr,"PINoSeq"), xRow)
     If  getColumIndex(spr,"OrderNo") > -1 then z1351.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"OrderNoSeq") > -1 then z1351.OrderNoSeq = getDataM(spr, getColumIndex(spr,"OrderNoSeq"), xRow)
     If  getColumIndex(spr,"PKO") > -1 then z1351.PKO = getDataM(spr, getColumIndex(spr,"PKO"), xRow)
     If  getColumIndex(spr,"Article") > -1 then z1351.Article = getDataM(spr, getColumIndex(spr,"Article"), xRow)
     If  getColumIndex(spr,"Line") > -1 then z1351.Line = getDataM(spr, getColumIndex(spr,"Line"), xRow)
     If  getColumIndex(spr,"Color") > -1 then z1351.Color = getDataM(spr, getColumIndex(spr,"Color"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z1351.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"MoldCode") > -1 then z1351.MoldCode = getDataM(spr, getColumIndex(spr,"MoldCode"), xRow)
     If  getColumIndex(spr,"SizeRange") > -1 then z1351.SizeRange = getDataM(spr, getColumIndex(spr,"SizeRange"), xRow)
     If  getColumIndex(spr,"SpecificSize") > -1 then z1351.SpecificSize = getDataM(spr, getColumIndex(spr,"SpecificSize"), xRow)
     If  getColumIndex(spr,"DateExchangePrice") > -1 then z1351.DateExchangePrice = getDataM(spr, getColumIndex(spr,"DateExchangePrice"), xRow)
     If  getColumIndex(spr,"PriceOrder") > -1 then z1351.PriceOrder = getDataM(spr, getColumIndex(spr,"PriceOrder"), xRow)
     If  getColumIndex(spr,"UnitPrice") > -1 then z1351.UnitPrice = getDataM(spr, getColumIndex(spr,"UnitPrice"), xRow)
     If  getColumIndex(spr,"QtyOrder") > -1 then z1351.QtyOrder = getDataM(spr, getColumIndex(spr,"QtyOrder"), xRow)
     If  getColumIndex(spr,"InchargeSales") > -1 then z1351.InchargeSales = getDataM(spr, getColumIndex(spr,"InchargeSales"), xRow)
     If  getColumIndex(spr,"InchargePPC") > -1 then z1351.InchargePPC = getDataM(spr, getColumIndex(spr,"InchargePPC"), xRow)
     If  getColumIndex(spr,"TotalQty") > -1 then z1351.TotalQty = getDataM(spr, getColumIndex(spr,"TotalQty"), xRow)
     If  getColumIndex(spr,"TotalAMT") > -1 then z1351.TotalAMT = getDataM(spr, getColumIndex(spr,"TotalAMT"), xRow)
     If  getColumIndex(spr,"AcceptedPI") > -1 then z1351.AcceptedPI = getDataM(spr, getColumIndex(spr,"AcceptedPI"), xRow)
     If  getColumIndex(spr,"Destination") > -1 then z1351.Destination = getDataM(spr, getColumIndex(spr,"Destination"), xRow)
     If  getColumIndex(spr,"RemarkOrder") > -1 then z1351.RemarkOrder = getDataM(spr, getColumIndex(spr,"RemarkOrder"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K1351_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K1351_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z1351 As T1351_AREA,CheckClear as Boolean,PINO AS String, PINOSEQ AS String) as Boolean

K1351_MOVE = False

Try
    If READ_PFK1351(PINO, PINOSEQ) = True Then
                z1351 = D1351
		K1351_MOVE = True
		else
	If CheckClear  = True then z1351 = nothing
     End If

     If  getColumIndex(spr,"PINo") > -1 then z1351.PINo = getDataM(spr, getColumIndex(spr,"PINo"), xRow)
     If  getColumIndex(spr,"PINoSeq") > -1 then z1351.PINoSeq = getDataM(spr, getColumIndex(spr,"PINoSeq"), xRow)
     If  getColumIndex(spr,"OrderNo") > -1 then z1351.OrderNo = getDataM(spr, getColumIndex(spr,"OrderNo"), xRow)
     If  getColumIndex(spr,"OrderNoSeq") > -1 then z1351.OrderNoSeq = getDataM(spr, getColumIndex(spr,"OrderNoSeq"), xRow)
     If  getColumIndex(spr,"PKO") > -1 then z1351.PKO = getDataM(spr, getColumIndex(spr,"PKO"), xRow)
     If  getColumIndex(spr,"Article") > -1 then z1351.Article = getDataM(spr, getColumIndex(spr,"Article"), xRow)
     If  getColumIndex(spr,"Line") > -1 then z1351.Line = getDataM(spr, getColumIndex(spr,"Line"), xRow)
     If  getColumIndex(spr,"Color") > -1 then z1351.Color = getDataM(spr, getColumIndex(spr,"Color"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z1351.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"MoldCode") > -1 then z1351.MoldCode = getDataM(spr, getColumIndex(spr,"MoldCode"), xRow)
     If  getColumIndex(spr,"SizeRange") > -1 then z1351.SizeRange = getDataM(spr, getColumIndex(spr,"SizeRange"), xRow)
     If  getColumIndex(spr,"SpecificSize") > -1 then z1351.SpecificSize = getDataM(spr, getColumIndex(spr,"SpecificSize"), xRow)
     If  getColumIndex(spr,"DateExchangePrice") > -1 then z1351.DateExchangePrice = getDataM(spr, getColumIndex(spr,"DateExchangePrice"), xRow)
     If  getColumIndex(spr,"PriceOrder") > -1 then z1351.PriceOrder = getDataM(spr, getColumIndex(spr,"PriceOrder"), xRow)
     If  getColumIndex(spr,"UnitPrice") > -1 then z1351.UnitPrice = getDataM(spr, getColumIndex(spr,"UnitPrice"), xRow)
     If  getColumIndex(spr,"QtyOrder") > -1 then z1351.QtyOrder = getDataM(spr, getColumIndex(spr,"QtyOrder"), xRow)
     If  getColumIndex(spr,"InchargeSales") > -1 then z1351.InchargeSales = getDataM(spr, getColumIndex(spr,"InchargeSales"), xRow)
     If  getColumIndex(spr,"InchargePPC") > -1 then z1351.InchargePPC = getDataM(spr, getColumIndex(spr,"InchargePPC"), xRow)
     If  getColumIndex(spr,"TotalQty") > -1 then z1351.TotalQty = getDataM(spr, getColumIndex(spr,"TotalQty"), xRow)
     If  getColumIndex(spr,"TotalAMT") > -1 then z1351.TotalAMT = getDataM(spr, getColumIndex(spr,"TotalAMT"), xRow)
     If  getColumIndex(spr,"AcceptedPI") > -1 then z1351.AcceptedPI = getDataM(spr, getColumIndex(spr,"AcceptedPI"), xRow)
     If  getColumIndex(spr,"Destination") > -1 then z1351.Destination = getDataM(spr, getColumIndex(spr,"Destination"), xRow)
     If  getColumIndex(spr,"RemarkOrder") > -1 then z1351.RemarkOrder = getDataM(spr, getColumIndex(spr,"RemarkOrder"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K1351_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K1351_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z1351 As T1351_AREA, Job as String, PINO AS String, PINOSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K1351_MOVE = False

Try
    If READ_PFK1351(PINO, PINOSEQ) = True Then
                z1351 = D1351
		K1351_MOVE = True
		else
	z1351 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1351")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PINO":z1351.PINo = Children(i).Code
   Case "PINOSEQ":z1351.PINoSeq = Children(i).Code
   Case "ORDERNO":z1351.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z1351.OrderNoSeq = Children(i).Code
   Case "PKO":z1351.PKO = Children(i).Code
   Case "ARTICLE":z1351.Article = Children(i).Code
   Case "LINE":z1351.Line = Children(i).Code
   Case "COLOR":z1351.Color = Children(i).Code
   Case "MATERIALCODE":z1351.MaterialCode = Children(i).Code
   Case "MOLDCODE":z1351.MoldCode = Children(i).Code
   Case "SIZERANGE":z1351.SizeRange = Children(i).Code
   Case "SPECIFICSIZE":z1351.SpecificSize = Children(i).Code
   Case "DATEEXCHANGEPRICE":z1351.DateExchangePrice = Children(i).Code
   Case "PRICEORDER":z1351.PriceOrder = Children(i).Code
   Case "UNITPRICE":z1351.UnitPrice = Children(i).Code
   Case "QTYORDER":z1351.QtyOrder = Children(i).Code
   Case "INCHARGESALES":z1351.InchargeSales = Children(i).Code
   Case "INCHARGEPPC":z1351.InchargePPC = Children(i).Code
   Case "TOTALQTY":z1351.TotalQty = Children(i).Code
   Case "TOTALAMT":z1351.TotalAMT = Children(i).Code
   Case "ACCEPTEDPI":z1351.AcceptedPI = Children(i).Code
   Case "DESTINATION":z1351.Destination = Children(i).Code
   Case "REMARKORDER":z1351.RemarkOrder = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PINO":z1351.PINo = Children(i).Data
   Case "PINOSEQ":z1351.PINoSeq = Children(i).Data
   Case "ORDERNO":z1351.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z1351.OrderNoSeq = Children(i).Data
   Case "PKO":z1351.PKO = Children(i).Data
   Case "ARTICLE":z1351.Article = Children(i).Data
   Case "LINE":z1351.Line = Children(i).Data
   Case "COLOR":z1351.Color = Children(i).Data
   Case "MATERIALCODE":z1351.MaterialCode = Children(i).Data
   Case "MOLDCODE":z1351.MoldCode = Children(i).Data
   Case "SIZERANGE":z1351.SizeRange = Children(i).Data
   Case "SPECIFICSIZE":z1351.SpecificSize = Children(i).Data
   Case "DATEEXCHANGEPRICE":z1351.DateExchangePrice = Children(i).Data
   Case "PRICEORDER":z1351.PriceOrder = Children(i).Data
   Case "UNITPRICE":z1351.UnitPrice = Children(i).Data
   Case "QTYORDER":z1351.QtyOrder = Children(i).Data
   Case "INCHARGESALES":z1351.InchargeSales = Children(i).Data
   Case "INCHARGEPPC":z1351.InchargePPC = Children(i).Data
   Case "TOTALQTY":z1351.TotalQty = Children(i).Data
   Case "TOTALAMT":z1351.TotalAMT = Children(i).Data
   Case "ACCEPTEDPI":z1351.AcceptedPI = Children(i).Data
   Case "DESTINATION":z1351.Destination = Children(i).Data
   Case "REMARKORDER":z1351.RemarkOrder = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K1351_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K1351_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z1351 As T1351_AREA, Job as String, CheckClear as Boolean, PINO AS String, PINOSEQ AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K1351_MOVE = False

Try
    If READ_PFK1351(PINO, PINOSEQ) = True Then
                z1351 = D1351
		K1351_MOVE = True
		else
	If CheckClear  = True then z1351 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1351")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PINO":z1351.PINo = Children(i).Code
   Case "PINOSEQ":z1351.PINoSeq = Children(i).Code
   Case "ORDERNO":z1351.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z1351.OrderNoSeq = Children(i).Code
   Case "PKO":z1351.PKO = Children(i).Code
   Case "ARTICLE":z1351.Article = Children(i).Code
   Case "LINE":z1351.Line = Children(i).Code
   Case "COLOR":z1351.Color = Children(i).Code
   Case "MATERIALCODE":z1351.MaterialCode = Children(i).Code
   Case "MOLDCODE":z1351.MoldCode = Children(i).Code
   Case "SIZERANGE":z1351.SizeRange = Children(i).Code
   Case "SPECIFICSIZE":z1351.SpecificSize = Children(i).Code
   Case "DATEEXCHANGEPRICE":z1351.DateExchangePrice = Children(i).Code
   Case "PRICEORDER":z1351.PriceOrder = Children(i).Code
   Case "UNITPRICE":z1351.UnitPrice = Children(i).Code
   Case "QTYORDER":z1351.QtyOrder = Children(i).Code
   Case "INCHARGESALES":z1351.InchargeSales = Children(i).Code
   Case "INCHARGEPPC":z1351.InchargePPC = Children(i).Code
   Case "TOTALQTY":z1351.TotalQty = Children(i).Code
   Case "TOTALAMT":z1351.TotalAMT = Children(i).Code
   Case "ACCEPTEDPI":z1351.AcceptedPI = Children(i).Code
   Case "DESTINATION":z1351.Destination = Children(i).Code
   Case "REMARKORDER":z1351.RemarkOrder = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PINO":z1351.PINo = Children(i).Data
   Case "PINOSEQ":z1351.PINoSeq = Children(i).Data
   Case "ORDERNO":z1351.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z1351.OrderNoSeq = Children(i).Data
   Case "PKO":z1351.PKO = Children(i).Data
   Case "ARTICLE":z1351.Article = Children(i).Data
   Case "LINE":z1351.Line = Children(i).Data
   Case "COLOR":z1351.Color = Children(i).Data
   Case "MATERIALCODE":z1351.MaterialCode = Children(i).Data
   Case "MOLDCODE":z1351.MoldCode = Children(i).Data
   Case "SIZERANGE":z1351.SizeRange = Children(i).Data
   Case "SPECIFICSIZE":z1351.SpecificSize = Children(i).Data
   Case "DATEEXCHANGEPRICE":z1351.DateExchangePrice = Children(i).Data
   Case "PRICEORDER":z1351.PriceOrder = Children(i).Data
   Case "UNITPRICE":z1351.UnitPrice = Children(i).Data
   Case "QTYORDER":z1351.QtyOrder = Children(i).Data
   Case "INCHARGESALES":z1351.InchargeSales = Children(i).Data
   Case "INCHARGEPPC":z1351.InchargePPC = Children(i).Data
   Case "TOTALQTY":z1351.TotalQty = Children(i).Data
   Case "TOTALAMT":z1351.TotalAMT = Children(i).Data
   Case "ACCEPTEDPI":z1351.AcceptedPI = Children(i).Data
   Case "DESTINATION":z1351.Destination = Children(i).Data
   Case "REMARKORDER":z1351.RemarkOrder = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K1351_MOVE",vbCritical)
End Try
End Function 
    
End Module 
