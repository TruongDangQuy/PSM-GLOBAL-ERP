'=========================================================================================================================================================
'   TABLE : (PFK3113)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K3113

Structure T3113_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	RequestPurchasingNo	 AS String	'			nvarchar(9)		*
Public 	RequestPurchasingSeq	 AS Double	'			decimal		*
Public 	Dseq	 AS Double	'			decimal
Public 	YarnCode	 AS String	'			char(8)
Public 	WgtCone	 AS Double	'			decimal
Public 	ConeBox	 AS Double	'			decimal
Public 	WgtBox	 AS Double	'			decimal
Public 	cdUnitPricePurchasing	 AS String	'			char(3)
Public 	PricePurchasing	 AS Double	'			decimal
Public 	PriceExchange	 AS Double	'			decimal
Public 	DateExchange	 AS String	'			char(8)
Public 	PricePurchasingUSD	 AS Double	'			decimal
Public 	PricePurchasingVND	 AS Double	'			decimal
Public 	AmountOrderUSD	 AS Double	'			decimal
Public 	AmountOrderVND	 AS Double	'			decimal
Public 	AmountYarnInboundUSD	 AS Double	'			decimal
Public 	AmountYarnInboundVND	 AS Double	'			decimal
Public 	BoxRequestPurchasing	 AS Double	'			decimal
Public 	ConeRequestPurchasing	 AS Double	'			decimal
Public 	WgtRequestPurchasing	 AS Double	'			decimal
Public 	BoxGrossInboundYarn	 AS Double	'			decimal
Public 	ConeGrossInboundYarn	 AS Double	'			decimal
Public 	WgtGrossInboundYarn	 AS Double	'			decimal
Public 	ConeNetInboundYarn	 AS Double	'			decimal
Public 	BoxNetInboundYarn	 AS Double	'			decimal
Public 	WgtNetInboundYarn	 AS Double	'			decimal
Public 	CheckRequestPurchasing	 AS String	'			char(1)
Public 	DateRequestPurchasing	 AS String	'			char(8)
Public 	DateCompletePurchasing	 AS String	'			char(8)
Public 	DateApprovalPurchasing	 AS String	'			char(8)
Public 	DateCancelPurchasing	 AS String	'			char(8)
Public 	CheckCpmplete	 AS String	'			char(1)
Public 	Remark	 AS String	'			nvarchar(-1)
'=========================================================================================================================================================
End structure

Public D3113 As T3113_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK3113(REQUESTPURCHASINGNO AS String, REQUESTPURCHASINGSEQ AS Double) As Boolean
    READ_PFK3113 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3113 "
    SQL = SQL & " WHERE K3113_RequestPurchasingNo		 = '" & RequestPurchasingNo & "' " 
    SQL = SQL & "   AND K3113_RequestPurchasingSeq		 =  " & RequestPurchasingSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D3113_CLEAR: GoTo SKIP_READ_PFK3113
                
    Call K3113_MOVE(rd)
    READ_PFK3113 = True

SKIP_READ_PFK3113:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK3113",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK3113(REQUESTPURCHASINGNO AS String, REQUESTPURCHASINGSEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3113 "
    SQL = SQL & " WHERE K3113_RequestPurchasingNo		 = '" & RequestPurchasingNo & "' " 
    SQL = SQL & "   AND K3113_RequestPurchasingSeq		 =  " & RequestPurchasingSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK3113",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK3113(z3113 As T3113_AREA) As Boolean
    WRITE_PFK3113 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z3113)
 
    SQL = " INSERT INTO PFK3113 "
    SQL = SQL & " ( "
    SQL = SQL & " K3113_RequestPurchasingNo," 
    SQL = SQL & " K3113_RequestPurchasingSeq," 
    SQL = SQL & " K3113_Dseq," 
    SQL = SQL & " K3113_YarnCode," 
    SQL = SQL & " K3113_WgtCone," 
    SQL = SQL & " K3113_ConeBox," 
    SQL = SQL & " K3113_WgtBox," 
    SQL = SQL & " K3113_cdUnitPricePurchasing," 
    SQL = SQL & " K3113_PricePurchasing," 
    SQL = SQL & " K3113_PriceExchange," 
    SQL = SQL & " K3113_DateExchange," 
    SQL = SQL & " K3113_PricePurchasingUSD," 
    SQL = SQL & " K3113_PricePurchasingVND," 
    SQL = SQL & " K3113_AmountOrderUSD," 
    SQL = SQL & " K3113_AmountOrderVND," 
    SQL = SQL & " K3113_AmountYarnInboundUSD," 
    SQL = SQL & " K3113_AmountYarnInboundVND," 
    SQL = SQL & " K3113_BoxRequestPurchasing," 
    SQL = SQL & " K3113_ConeRequestPurchasing," 
    SQL = SQL & " K3113_WgtRequestPurchasing," 
    SQL = SQL & " K3113_BoxGrossInboundYarn," 
    SQL = SQL & " K3113_ConeGrossInboundYarn," 
    SQL = SQL & " K3113_WgtGrossInboundYarn," 
    SQL = SQL & " K3113_ConeNetInboundYarn," 
    SQL = SQL & " K3113_BoxNetInboundYarn," 
    SQL = SQL & " K3113_WgtNetInboundYarn," 
    SQL = SQL & " K3113_CheckRequestPurchasing," 
    SQL = SQL & " K3113_DateRequestPurchasing," 
    SQL = SQL & " K3113_DateCompletePurchasing," 
    SQL = SQL & " K3113_DateApprovalPurchasing," 
    SQL = SQL & " K3113_DateCancelPurchasing," 
    SQL = SQL & " K3113_CheckCpmplete," 
    SQL = SQL & " K3113_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  '" & z3113.RequestPurchasingNo & "', "  
    SQL = SQL & "   " & z3113.RequestPurchasingSeq & " , "  
    SQL = SQL & "   " & z3113.Dseq & " , "  
    SQL = SQL & "  '" & z3113.YarnCode & "', "  
    SQL = SQL & "   " & z3113.WgtCone & " , "  
    SQL = SQL & "   " & z3113.ConeBox & " , "  
    SQL = SQL & "   " & z3113.WgtBox & " , "  
    SQL = SQL & "  '" & z3113.cdUnitPricePurchasing & "', "  
    SQL = SQL & "   " & z3113.PricePurchasing & " , "  
    SQL = SQL & "   " & z3113.PriceExchange & " , "  
    SQL = SQL & "  '" & z3113.DateExchange & "', "  
    SQL = SQL & "   " & z3113.PricePurchasingUSD & " , "  
    SQL = SQL & "   " & z3113.PricePurchasingVND & " , "  
    SQL = SQL & "   " & z3113.AmountOrderUSD & " , "  
    SQL = SQL & "   " & z3113.AmountOrderVND & " , "  
    SQL = SQL & "   " & z3113.AmountYarnInboundUSD & " , "  
    SQL = SQL & "   " & z3113.AmountYarnInboundVND & " , "  
    SQL = SQL & "   " & z3113.BoxRequestPurchasing & " , "  
    SQL = SQL & "   " & z3113.ConeRequestPurchasing & " , "  
    SQL = SQL & "   " & z3113.WgtRequestPurchasing & " , "  
    SQL = SQL & "   " & z3113.BoxGrossInboundYarn & " , "  
    SQL = SQL & "   " & z3113.ConeGrossInboundYarn & " , "  
    SQL = SQL & "   " & z3113.WgtGrossInboundYarn & " , "  
    SQL = SQL & "   " & z3113.ConeNetInboundYarn & " , "  
    SQL = SQL & "   " & z3113.BoxNetInboundYarn & " , "  
    SQL = SQL & "   " & z3113.WgtNetInboundYarn & " , "  
    SQL = SQL & "  '" & z3113.CheckRequestPurchasing & "', "  
    SQL = SQL & "  '" & z3113.DateRequestPurchasing & "', "  
    SQL = SQL & "  '" & z3113.DateCompletePurchasing & "', "  
    SQL = SQL & "  '" & z3113.DateApprovalPurchasing & "', "  
    SQL = SQL & "  '" & z3113.DateCancelPurchasing & "', "  
    SQL = SQL & "  '" & z3113.CheckCpmplete & "', "  
    SQL = SQL & "  '" & z3113.Remark & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK3113 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK3113",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK3113(z3113 As T3113_AREA) As Boolean
    REWRITE_PFK3113 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z3113)
   
    SQL = " UPDATE PFK3113 SET "
    SQL = SQL & "    K3113_Dseq      =  " & z3113.Dseq & " , " 
    SQL = SQL & "    K3113_YarnCode      = '" & z3113.YarnCode & "', " 
    SQL = SQL & "    K3113_WgtCone      =  " & z3113.WgtCone & " , " 
    SQL = SQL & "    K3113_ConeBox      =  " & z3113.ConeBox & " , " 
    SQL = SQL & "    K3113_WgtBox      =  " & z3113.WgtBox & " , " 
    SQL = SQL & "    K3113_cdUnitPricePurchasing      = '" & z3113.cdUnitPricePurchasing & "', " 
    SQL = SQL & "    K3113_PricePurchasing      =  " & z3113.PricePurchasing & " , " 
    SQL = SQL & "    K3113_PriceExchange      =  " & z3113.PriceExchange & " , " 
    SQL = SQL & "    K3113_DateExchange      = '" & z3113.DateExchange & "', " 
    SQL = SQL & "    K3113_PricePurchasingUSD      =  " & z3113.PricePurchasingUSD & " , " 
    SQL = SQL & "    K3113_PricePurchasingVND      =  " & z3113.PricePurchasingVND & " , " 
    SQL = SQL & "    K3113_AmountOrderUSD      =  " & z3113.AmountOrderUSD & " , " 
    SQL = SQL & "    K3113_AmountOrderVND      =  " & z3113.AmountOrderVND & " , " 
    SQL = SQL & "    K3113_AmountYarnInboundUSD      =  " & z3113.AmountYarnInboundUSD & " , " 
    SQL = SQL & "    K3113_AmountYarnInboundVND      =  " & z3113.AmountYarnInboundVND & " , " 
    SQL = SQL & "    K3113_BoxRequestPurchasing      =  " & z3113.BoxRequestPurchasing & " , " 
    SQL = SQL & "    K3113_ConeRequestPurchasing      =  " & z3113.ConeRequestPurchasing & " , " 
    SQL = SQL & "    K3113_WgtRequestPurchasing      =  " & z3113.WgtRequestPurchasing & " , " 
    SQL = SQL & "    K3113_BoxGrossInboundYarn      =  " & z3113.BoxGrossInboundYarn & " , " 
    SQL = SQL & "    K3113_ConeGrossInboundYarn      =  " & z3113.ConeGrossInboundYarn & " , " 
    SQL = SQL & "    K3113_WgtGrossInboundYarn      =  " & z3113.WgtGrossInboundYarn & " , " 
    SQL = SQL & "    K3113_ConeNetInboundYarn      =  " & z3113.ConeNetInboundYarn & " , " 
    SQL = SQL & "    K3113_BoxNetInboundYarn      =  " & z3113.BoxNetInboundYarn & " , " 
    SQL = SQL & "    K3113_WgtNetInboundYarn      =  " & z3113.WgtNetInboundYarn & " , " 
    SQL = SQL & "    K3113_CheckRequestPurchasing      = '" & z3113.CheckRequestPurchasing & "', " 
    SQL = SQL & "    K3113_DateRequestPurchasing      = '" & z3113.DateRequestPurchasing & "', " 
    SQL = SQL & "    K3113_DateCompletePurchasing      = '" & z3113.DateCompletePurchasing & "', " 
    SQL = SQL & "    K3113_DateApprovalPurchasing      = '" & z3113.DateApprovalPurchasing & "', " 
    SQL = SQL & "    K3113_DateCancelPurchasing      = '" & z3113.DateCancelPurchasing & "', " 
    SQL = SQL & "    K3113_CheckCpmplete      = '" & z3113.CheckCpmplete & "', " 
    SQL = SQL & "    K3113_Remark      = '" & z3113.Remark & "'  " 
    SQL = SQL & " WHERE K3113_RequestPurchasingNo		 = '" & z3113.RequestPurchasingNo & "' " 
    SQL = SQL & "   AND K3113_RequestPurchasingSeq		 =  " & z3113.RequestPurchasingSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK3113 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK3113",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK3113(z3113 As T3113_AREA) As Boolean
    DELETE_PFK3113 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK3113 "
    SQL = SQL & " WHERE K3113_RequestPurchasingNo		 = '" & z3113.RequestPurchasingNo & "' " 
    SQL = SQL & "   AND K3113_RequestPurchasingSeq		 =  " & z3113.RequestPurchasingSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK3113 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK3113",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D3113_CLEAR()
Try
    
   D3113.RequestPurchasingNo = ""
    D3113.RequestPurchasingSeq = 0 
    D3113.Dseq = 0 
   D3113.YarnCode = ""
    D3113.WgtCone = 0 
    D3113.ConeBox = 0 
    D3113.WgtBox = 0 
   D3113.cdUnitPricePurchasing = ""
    D3113.PricePurchasing = 0 
    D3113.PriceExchange = 0 
   D3113.DateExchange = ""
    D3113.PricePurchasingUSD = 0 
    D3113.PricePurchasingVND = 0 
    D3113.AmountOrderUSD = 0 
    D3113.AmountOrderVND = 0 
    D3113.AmountYarnInboundUSD = 0 
    D3113.AmountYarnInboundVND = 0 
    D3113.BoxRequestPurchasing = 0 
    D3113.ConeRequestPurchasing = 0 
    D3113.WgtRequestPurchasing = 0 
    D3113.BoxGrossInboundYarn = 0 
    D3113.ConeGrossInboundYarn = 0 
    D3113.WgtGrossInboundYarn = 0 
    D3113.ConeNetInboundYarn = 0 
    D3113.BoxNetInboundYarn = 0 
    D3113.WgtNetInboundYarn = 0 
   D3113.CheckRequestPurchasing = ""
   D3113.DateRequestPurchasing = ""
   D3113.DateCompletePurchasing = ""
   D3113.DateApprovalPurchasing = ""
   D3113.DateCancelPurchasing = ""
   D3113.CheckCpmplete = ""
   D3113.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D3113_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x3113 As T3113_AREA)
Try
    
    x3113.RequestPurchasingNo = trim$(  x3113.RequestPurchasingNo)
    x3113.RequestPurchasingSeq = trim$(  x3113.RequestPurchasingSeq)
    x3113.Dseq = trim$(  x3113.Dseq)
    x3113.YarnCode = trim$(  x3113.YarnCode)
    x3113.WgtCone = trim$(  x3113.WgtCone)
    x3113.ConeBox = trim$(  x3113.ConeBox)
    x3113.WgtBox = trim$(  x3113.WgtBox)
    x3113.cdUnitPricePurchasing = trim$(  x3113.cdUnitPricePurchasing)
    x3113.PricePurchasing = trim$(  x3113.PricePurchasing)
    x3113.PriceExchange = trim$(  x3113.PriceExchange)
    x3113.DateExchange = trim$(  x3113.DateExchange)
    x3113.PricePurchasingUSD = trim$(  x3113.PricePurchasingUSD)
    x3113.PricePurchasingVND = trim$(  x3113.PricePurchasingVND)
    x3113.AmountOrderUSD = trim$(  x3113.AmountOrderUSD)
    x3113.AmountOrderVND = trim$(  x3113.AmountOrderVND)
    x3113.AmountYarnInboundUSD = trim$(  x3113.AmountYarnInboundUSD)
    x3113.AmountYarnInboundVND = trim$(  x3113.AmountYarnInboundVND)
    x3113.BoxRequestPurchasing = trim$(  x3113.BoxRequestPurchasing)
    x3113.ConeRequestPurchasing = trim$(  x3113.ConeRequestPurchasing)
    x3113.WgtRequestPurchasing = trim$(  x3113.WgtRequestPurchasing)
    x3113.BoxGrossInboundYarn = trim$(  x3113.BoxGrossInboundYarn)
    x3113.ConeGrossInboundYarn = trim$(  x3113.ConeGrossInboundYarn)
    x3113.WgtGrossInboundYarn = trim$(  x3113.WgtGrossInboundYarn)
    x3113.ConeNetInboundYarn = trim$(  x3113.ConeNetInboundYarn)
    x3113.BoxNetInboundYarn = trim$(  x3113.BoxNetInboundYarn)
    x3113.WgtNetInboundYarn = trim$(  x3113.WgtNetInboundYarn)
    x3113.CheckRequestPurchasing = trim$(  x3113.CheckRequestPurchasing)
    x3113.DateRequestPurchasing = trim$(  x3113.DateRequestPurchasing)
    x3113.DateCompletePurchasing = trim$(  x3113.DateCompletePurchasing)
    x3113.DateApprovalPurchasing = trim$(  x3113.DateApprovalPurchasing)
    x3113.DateCancelPurchasing = trim$(  x3113.DateCancelPurchasing)
    x3113.CheckCpmplete = trim$(  x3113.CheckCpmplete)
    x3113.Remark = trim$(  x3113.Remark)
     
    If trim$( x3113.RequestPurchasingNo ) = "" Then x3113.RequestPurchasingNo = Space(1) 
    If trim$( x3113.RequestPurchasingSeq ) = "" Then x3113.RequestPurchasingSeq = 0 
    If trim$( x3113.Dseq ) = "" Then x3113.Dseq = 0 
    If trim$( x3113.YarnCode ) = "" Then x3113.YarnCode = Space(1) 
    If trim$( x3113.WgtCone ) = "" Then x3113.WgtCone = 0 
    If trim$( x3113.ConeBox ) = "" Then x3113.ConeBox = 0 
    If trim$( x3113.WgtBox ) = "" Then x3113.WgtBox = 0 
    If trim$( x3113.cdUnitPricePurchasing ) = "" Then x3113.cdUnitPricePurchasing = Space(1) 
    If trim$( x3113.PricePurchasing ) = "" Then x3113.PricePurchasing = 0 
    If trim$( x3113.PriceExchange ) = "" Then x3113.PriceExchange = 0 
    If trim$( x3113.DateExchange ) = "" Then x3113.DateExchange = Space(1) 
    If trim$( x3113.PricePurchasingUSD ) = "" Then x3113.PricePurchasingUSD = 0 
    If trim$( x3113.PricePurchasingVND ) = "" Then x3113.PricePurchasingVND = 0 
    If trim$( x3113.AmountOrderUSD ) = "" Then x3113.AmountOrderUSD = 0 
    If trim$( x3113.AmountOrderVND ) = "" Then x3113.AmountOrderVND = 0 
    If trim$( x3113.AmountYarnInboundUSD ) = "" Then x3113.AmountYarnInboundUSD = 0 
    If trim$( x3113.AmountYarnInboundVND ) = "" Then x3113.AmountYarnInboundVND = 0 
    If trim$( x3113.BoxRequestPurchasing ) = "" Then x3113.BoxRequestPurchasing = 0 
    If trim$( x3113.ConeRequestPurchasing ) = "" Then x3113.ConeRequestPurchasing = 0 
    If trim$( x3113.WgtRequestPurchasing ) = "" Then x3113.WgtRequestPurchasing = 0 
    If trim$( x3113.BoxGrossInboundYarn ) = "" Then x3113.BoxGrossInboundYarn = 0 
    If trim$( x3113.ConeGrossInboundYarn ) = "" Then x3113.ConeGrossInboundYarn = 0 
    If trim$( x3113.WgtGrossInboundYarn ) = "" Then x3113.WgtGrossInboundYarn = 0 
    If trim$( x3113.ConeNetInboundYarn ) = "" Then x3113.ConeNetInboundYarn = 0 
    If trim$( x3113.BoxNetInboundYarn ) = "" Then x3113.BoxNetInboundYarn = 0 
    If trim$( x3113.WgtNetInboundYarn ) = "" Then x3113.WgtNetInboundYarn = 0 
    If trim$( x3113.CheckRequestPurchasing ) = "" Then x3113.CheckRequestPurchasing = Space(1) 
    If trim$( x3113.DateRequestPurchasing ) = "" Then x3113.DateRequestPurchasing = Space(1) 
    If trim$( x3113.DateCompletePurchasing ) = "" Then x3113.DateCompletePurchasing = Space(1) 
    If trim$( x3113.DateApprovalPurchasing ) = "" Then x3113.DateApprovalPurchasing = Space(1) 
    If trim$( x3113.DateCancelPurchasing ) = "" Then x3113.DateCancelPurchasing = Space(1) 
    If trim$( x3113.CheckCpmplete ) = "" Then x3113.CheckCpmplete = Space(1) 
    If trim$( x3113.Remark ) = "" Then x3113.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K3113_MOVE(rs3113 As SqlClient.SqlDataReader)
Try

    call D3113_CLEAR()   

    If IsdbNull(rs3113!K3113_RequestPurchasingNo) = False Then D3113.RequestPurchasingNo = Trim$(rs3113!K3113_RequestPurchasingNo)
    If IsdbNull(rs3113!K3113_RequestPurchasingSeq) = False Then D3113.RequestPurchasingSeq = Trim$(rs3113!K3113_RequestPurchasingSeq)
    If IsdbNull(rs3113!K3113_Dseq) = False Then D3113.Dseq = Trim$(rs3113!K3113_Dseq)
    If IsdbNull(rs3113!K3113_YarnCode) = False Then D3113.YarnCode = Trim$(rs3113!K3113_YarnCode)
    If IsdbNull(rs3113!K3113_WgtCone) = False Then D3113.WgtCone = Trim$(rs3113!K3113_WgtCone)
    If IsdbNull(rs3113!K3113_ConeBox) = False Then D3113.ConeBox = Trim$(rs3113!K3113_ConeBox)
    If IsdbNull(rs3113!K3113_WgtBox) = False Then D3113.WgtBox = Trim$(rs3113!K3113_WgtBox)
    If IsdbNull(rs3113!K3113_cdUnitPricePurchasing) = False Then D3113.cdUnitPricePurchasing = Trim$(rs3113!K3113_cdUnitPricePurchasing)
    If IsdbNull(rs3113!K3113_PricePurchasing) = False Then D3113.PricePurchasing = Trim$(rs3113!K3113_PricePurchasing)
    If IsdbNull(rs3113!K3113_PriceExchange) = False Then D3113.PriceExchange = Trim$(rs3113!K3113_PriceExchange)
    If IsdbNull(rs3113!K3113_DateExchange) = False Then D3113.DateExchange = Trim$(rs3113!K3113_DateExchange)
    If IsdbNull(rs3113!K3113_PricePurchasingUSD) = False Then D3113.PricePurchasingUSD = Trim$(rs3113!K3113_PricePurchasingUSD)
    If IsdbNull(rs3113!K3113_PricePurchasingVND) = False Then D3113.PricePurchasingVND = Trim$(rs3113!K3113_PricePurchasingVND)
    If IsdbNull(rs3113!K3113_AmountOrderUSD) = False Then D3113.AmountOrderUSD = Trim$(rs3113!K3113_AmountOrderUSD)
    If IsdbNull(rs3113!K3113_AmountOrderVND) = False Then D3113.AmountOrderVND = Trim$(rs3113!K3113_AmountOrderVND)
    If IsdbNull(rs3113!K3113_AmountYarnInboundUSD) = False Then D3113.AmountYarnInboundUSD = Trim$(rs3113!K3113_AmountYarnInboundUSD)
    If IsdbNull(rs3113!K3113_AmountYarnInboundVND) = False Then D3113.AmountYarnInboundVND = Trim$(rs3113!K3113_AmountYarnInboundVND)
    If IsdbNull(rs3113!K3113_BoxRequestPurchasing) = False Then D3113.BoxRequestPurchasing = Trim$(rs3113!K3113_BoxRequestPurchasing)
    If IsdbNull(rs3113!K3113_ConeRequestPurchasing) = False Then D3113.ConeRequestPurchasing = Trim$(rs3113!K3113_ConeRequestPurchasing)
    If IsdbNull(rs3113!K3113_WgtRequestPurchasing) = False Then D3113.WgtRequestPurchasing = Trim$(rs3113!K3113_WgtRequestPurchasing)
    If IsdbNull(rs3113!K3113_BoxGrossInboundYarn) = False Then D3113.BoxGrossInboundYarn = Trim$(rs3113!K3113_BoxGrossInboundYarn)
    If IsdbNull(rs3113!K3113_ConeGrossInboundYarn) = False Then D3113.ConeGrossInboundYarn = Trim$(rs3113!K3113_ConeGrossInboundYarn)
    If IsdbNull(rs3113!K3113_WgtGrossInboundYarn) = False Then D3113.WgtGrossInboundYarn = Trim$(rs3113!K3113_WgtGrossInboundYarn)
    If IsdbNull(rs3113!K3113_ConeNetInboundYarn) = False Then D3113.ConeNetInboundYarn = Trim$(rs3113!K3113_ConeNetInboundYarn)
    If IsdbNull(rs3113!K3113_BoxNetInboundYarn) = False Then D3113.BoxNetInboundYarn = Trim$(rs3113!K3113_BoxNetInboundYarn)
    If IsdbNull(rs3113!K3113_WgtNetInboundYarn) = False Then D3113.WgtNetInboundYarn = Trim$(rs3113!K3113_WgtNetInboundYarn)
    If IsdbNull(rs3113!K3113_CheckRequestPurchasing) = False Then D3113.CheckRequestPurchasing = Trim$(rs3113!K3113_CheckRequestPurchasing)
    If IsdbNull(rs3113!K3113_DateRequestPurchasing) = False Then D3113.DateRequestPurchasing = Trim$(rs3113!K3113_DateRequestPurchasing)
    If IsdbNull(rs3113!K3113_DateCompletePurchasing) = False Then D3113.DateCompletePurchasing = Trim$(rs3113!K3113_DateCompletePurchasing)
    If IsdbNull(rs3113!K3113_DateApprovalPurchasing) = False Then D3113.DateApprovalPurchasing = Trim$(rs3113!K3113_DateApprovalPurchasing)
    If IsdbNull(rs3113!K3113_DateCancelPurchasing) = False Then D3113.DateCancelPurchasing = Trim$(rs3113!K3113_DateCancelPurchasing)
    If IsdbNull(rs3113!K3113_CheckCpmplete) = False Then D3113.CheckCpmplete = Trim$(rs3113!K3113_CheckCpmplete)
    If IsdbNull(rs3113!K3113_Remark) = False Then D3113.Remark = Trim$(rs3113!K3113_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3113_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K3113_MOVE(rs3113 As DataRow)
Try

    call D3113_CLEAR()   

    If IsdbNull(rs3113!K3113_RequestPurchasingNo) = False Then D3113.RequestPurchasingNo = Trim$(rs3113!K3113_RequestPurchasingNo)
    If IsdbNull(rs3113!K3113_RequestPurchasingSeq) = False Then D3113.RequestPurchasingSeq = Trim$(rs3113!K3113_RequestPurchasingSeq)
    If IsdbNull(rs3113!K3113_Dseq) = False Then D3113.Dseq = Trim$(rs3113!K3113_Dseq)
    If IsdbNull(rs3113!K3113_YarnCode) = False Then D3113.YarnCode = Trim$(rs3113!K3113_YarnCode)
    If IsdbNull(rs3113!K3113_WgtCone) = False Then D3113.WgtCone = Trim$(rs3113!K3113_WgtCone)
    If IsdbNull(rs3113!K3113_ConeBox) = False Then D3113.ConeBox = Trim$(rs3113!K3113_ConeBox)
    If IsdbNull(rs3113!K3113_WgtBox) = False Then D3113.WgtBox = Trim$(rs3113!K3113_WgtBox)
    If IsdbNull(rs3113!K3113_cdUnitPricePurchasing) = False Then D3113.cdUnitPricePurchasing = Trim$(rs3113!K3113_cdUnitPricePurchasing)
    If IsdbNull(rs3113!K3113_PricePurchasing) = False Then D3113.PricePurchasing = Trim$(rs3113!K3113_PricePurchasing)
    If IsdbNull(rs3113!K3113_PriceExchange) = False Then D3113.PriceExchange = Trim$(rs3113!K3113_PriceExchange)
    If IsdbNull(rs3113!K3113_DateExchange) = False Then D3113.DateExchange = Trim$(rs3113!K3113_DateExchange)
    If IsdbNull(rs3113!K3113_PricePurchasingUSD) = False Then D3113.PricePurchasingUSD = Trim$(rs3113!K3113_PricePurchasingUSD)
    If IsdbNull(rs3113!K3113_PricePurchasingVND) = False Then D3113.PricePurchasingVND = Trim$(rs3113!K3113_PricePurchasingVND)
    If IsdbNull(rs3113!K3113_AmountOrderUSD) = False Then D3113.AmountOrderUSD = Trim$(rs3113!K3113_AmountOrderUSD)
    If IsdbNull(rs3113!K3113_AmountOrderVND) = False Then D3113.AmountOrderVND = Trim$(rs3113!K3113_AmountOrderVND)
    If IsdbNull(rs3113!K3113_AmountYarnInboundUSD) = False Then D3113.AmountYarnInboundUSD = Trim$(rs3113!K3113_AmountYarnInboundUSD)
    If IsdbNull(rs3113!K3113_AmountYarnInboundVND) = False Then D3113.AmountYarnInboundVND = Trim$(rs3113!K3113_AmountYarnInboundVND)
    If IsdbNull(rs3113!K3113_BoxRequestPurchasing) = False Then D3113.BoxRequestPurchasing = Trim$(rs3113!K3113_BoxRequestPurchasing)
    If IsdbNull(rs3113!K3113_ConeRequestPurchasing) = False Then D3113.ConeRequestPurchasing = Trim$(rs3113!K3113_ConeRequestPurchasing)
    If IsdbNull(rs3113!K3113_WgtRequestPurchasing) = False Then D3113.WgtRequestPurchasing = Trim$(rs3113!K3113_WgtRequestPurchasing)
    If IsdbNull(rs3113!K3113_BoxGrossInboundYarn) = False Then D3113.BoxGrossInboundYarn = Trim$(rs3113!K3113_BoxGrossInboundYarn)
    If IsdbNull(rs3113!K3113_ConeGrossInboundYarn) = False Then D3113.ConeGrossInboundYarn = Trim$(rs3113!K3113_ConeGrossInboundYarn)
    If IsdbNull(rs3113!K3113_WgtGrossInboundYarn) = False Then D3113.WgtGrossInboundYarn = Trim$(rs3113!K3113_WgtGrossInboundYarn)
    If IsdbNull(rs3113!K3113_ConeNetInboundYarn) = False Then D3113.ConeNetInboundYarn = Trim$(rs3113!K3113_ConeNetInboundYarn)
    If IsdbNull(rs3113!K3113_BoxNetInboundYarn) = False Then D3113.BoxNetInboundYarn = Trim$(rs3113!K3113_BoxNetInboundYarn)
    If IsdbNull(rs3113!K3113_WgtNetInboundYarn) = False Then D3113.WgtNetInboundYarn = Trim$(rs3113!K3113_WgtNetInboundYarn)
    If IsdbNull(rs3113!K3113_CheckRequestPurchasing) = False Then D3113.CheckRequestPurchasing = Trim$(rs3113!K3113_CheckRequestPurchasing)
    If IsdbNull(rs3113!K3113_DateRequestPurchasing) = False Then D3113.DateRequestPurchasing = Trim$(rs3113!K3113_DateRequestPurchasing)
    If IsdbNull(rs3113!K3113_DateCompletePurchasing) = False Then D3113.DateCompletePurchasing = Trim$(rs3113!K3113_DateCompletePurchasing)
    If IsdbNull(rs3113!K3113_DateApprovalPurchasing) = False Then D3113.DateApprovalPurchasing = Trim$(rs3113!K3113_DateApprovalPurchasing)
    If IsdbNull(rs3113!K3113_DateCancelPurchasing) = False Then D3113.DateCancelPurchasing = Trim$(rs3113!K3113_DateCancelPurchasing)
    If IsdbNull(rs3113!K3113_CheckCpmplete) = False Then D3113.CheckCpmplete = Trim$(rs3113!K3113_CheckCpmplete)
    If IsdbNull(rs3113!K3113_Remark) = False Then D3113.Remark = Trim$(rs3113!K3113_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3113_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K3113_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3113 As T3113_AREA,REQUESTPURCHASINGNO AS String, REQUESTPURCHASINGSEQ AS Double) as Boolean

K3113_MOVE = False

Try
    If READ_PFK3113(REQUESTPURCHASINGNO, REQUESTPURCHASINGSEQ) = True Then
                z3113 = D3113
		K3113_MOVE = True
            End If

   z3113.RequestPurchasingNo = getDataM(spr, getColumIndex(spr,"RequestPurchasingNo"), xRow)
   z3113.RequestPurchasingSeq = getDataM(spr, getColumIndex(spr,"RequestPurchasingSeq"), xRow)
   z3113.Dseq = getDataM(spr, getColumIndex(spr,"Dseq"), xRow)
   z3113.YarnCode = getDataM(spr, getColumIndex(spr,"YarnCode"), xRow)
   z3113.WgtCone = getDataM(spr, getColumIndex(spr,"WgtCone"), xRow)
   z3113.ConeBox = getDataM(spr, getColumIndex(spr,"ConeBox"), xRow)
   z3113.WgtBox = getDataM(spr, getColumIndex(spr,"WgtBox"), xRow)
   z3113.cdUnitPricePurchasing = getDataM(spr, getColumIndex(spr,"cdUnitPricePurchasing"), xRow)
   z3113.PricePurchasing = getDataM(spr, getColumIndex(spr,"PricePurchasing"), xRow)
   z3113.PriceExchange = getDataM(spr, getColumIndex(spr,"PriceExchange"), xRow)
   z3113.DateExchange = getDataM(spr, getColumIndex(spr,"DateExchange"), xRow)
   z3113.PricePurchasingUSD = getDataM(spr, getColumIndex(spr,"PricePurchasingUSD"), xRow)
   z3113.PricePurchasingVND = getDataM(spr, getColumIndex(spr,"PricePurchasingVND"), xRow)
   z3113.AmountOrderUSD = getDataM(spr, getColumIndex(spr,"AmountOrderUSD"), xRow)
   z3113.AmountOrderVND = getDataM(spr, getColumIndex(spr,"AmountOrderVND"), xRow)
   z3113.AmountYarnInboundUSD = getDataM(spr, getColumIndex(spr,"AmountYarnInboundUSD"), xRow)
   z3113.AmountYarnInboundVND = getDataM(spr, getColumIndex(spr,"AmountYarnInboundVND"), xRow)
   z3113.BoxRequestPurchasing = getDataM(spr, getColumIndex(spr,"BoxRequestPurchasing"), xRow)
   z3113.ConeRequestPurchasing = getDataM(spr, getColumIndex(spr,"ConeRequestPurchasing"), xRow)
   z3113.WgtRequestPurchasing = getDataM(spr, getColumIndex(spr,"WgtRequestPurchasing"), xRow)
   z3113.BoxGrossInboundYarn = getDataM(spr, getColumIndex(spr,"BoxGrossInboundYarn"), xRow)
   z3113.ConeGrossInboundYarn = getDataM(spr, getColumIndex(spr,"ConeGrossInboundYarn"), xRow)
   z3113.WgtGrossInboundYarn = getDataM(spr, getColumIndex(spr,"WgtGrossInboundYarn"), xRow)
   z3113.ConeNetInboundYarn = getDataM(spr, getColumIndex(spr,"ConeNetInboundYarn"), xRow)
   z3113.BoxNetInboundYarn = getDataM(spr, getColumIndex(spr,"BoxNetInboundYarn"), xRow)
   z3113.WgtNetInboundYarn = getDataM(spr, getColumIndex(spr,"WgtNetInboundYarn"), xRow)
   z3113.CheckRequestPurchasing = getDataM(spr, getColumIndex(spr,"CheckRequestPurchasing"), xRow)
   z3113.DateRequestPurchasing = getDataM(spr, getColumIndex(spr,"DateRequestPurchasing"), xRow)
   z3113.DateCompletePurchasing = getDataM(spr, getColumIndex(spr,"DateCompletePurchasing"), xRow)
   z3113.DateApprovalPurchasing = getDataM(spr, getColumIndex(spr,"DateApprovalPurchasing"), xRow)
   z3113.DateCancelPurchasing = getDataM(spr, getColumIndex(spr,"DateCancelPurchasing"), xRow)
   z3113.CheckCpmplete = getDataM(spr, getColumIndex(spr,"CheckCpmplete"), xRow)
   z3113.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3113_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K3113_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3113 As T3113_AREA, Job as String,REQUESTPURCHASINGNO AS String, REQUESTPURCHASINGSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3113_MOVE = False

Try
    If READ_PFK3113(REQUESTPURCHASINGNO, REQUESTPURCHASINGSEQ) = True Then
                z3113 = D3113
		K3113_MOVE = True

    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3113")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "RequestPurchasingNo":z3113.RequestPurchasingNo = Children(i).Code
   Case "RequestPurchasingSeq":z3113.RequestPurchasingSeq = Children(i).Code
   Case "Dseq":z3113.Dseq = Children(i).Code
   Case "YarnCode":z3113.YarnCode = Children(i).Code
   Case "WgtCone":z3113.WgtCone = Children(i).Code
   Case "ConeBox":z3113.ConeBox = Children(i).Code
   Case "WgtBox":z3113.WgtBox = Children(i).Code
   Case "cdUnitPricePurchasing":z3113.cdUnitPricePurchasing = Children(i).Code
   Case "PricePurchasing":z3113.PricePurchasing = Children(i).Code
   Case "PriceExchange":z3113.PriceExchange = Children(i).Code
   Case "DateExchange":z3113.DateExchange = Children(i).Code
   Case "PricePurchasingUSD":z3113.PricePurchasingUSD = Children(i).Code
   Case "PricePurchasingVND":z3113.PricePurchasingVND = Children(i).Code
   Case "AmountOrderUSD":z3113.AmountOrderUSD = Children(i).Code
   Case "AmountOrderVND":z3113.AmountOrderVND = Children(i).Code
   Case "AmountYarnInboundUSD":z3113.AmountYarnInboundUSD = Children(i).Code
   Case "AmountYarnInboundVND":z3113.AmountYarnInboundVND = Children(i).Code
   Case "BoxRequestPurchasing":z3113.BoxRequestPurchasing = Children(i).Code
   Case "ConeRequestPurchasing":z3113.ConeRequestPurchasing = Children(i).Code
   Case "WgtRequestPurchasing":z3113.WgtRequestPurchasing = Children(i).Code
   Case "BoxGrossInboundYarn":z3113.BoxGrossInboundYarn = Children(i).Code
   Case "ConeGrossInboundYarn":z3113.ConeGrossInboundYarn = Children(i).Code
   Case "WgtGrossInboundYarn":z3113.WgtGrossInboundYarn = Children(i).Code
   Case "ConeNetInboundYarn":z3113.ConeNetInboundYarn = Children(i).Code
   Case "BoxNetInboundYarn":z3113.BoxNetInboundYarn = Children(i).Code
   Case "WgtNetInboundYarn":z3113.WgtNetInboundYarn = Children(i).Code
   Case "CheckRequestPurchasing":z3113.CheckRequestPurchasing = Children(i).Code
   Case "DateRequestPurchasing":z3113.DateRequestPurchasing = Children(i).Code
   Case "DateCompletePurchasing":z3113.DateCompletePurchasing = Children(i).Code
   Case "DateApprovalPurchasing":z3113.DateApprovalPurchasing = Children(i).Code
   Case "DateCancelPurchasing":z3113.DateCancelPurchasing = Children(i).Code
   Case "CheckCpmplete":z3113.CheckCpmplete = Children(i).Code
   Case "Remark":z3113.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "RequestPurchasingNo":z3113.RequestPurchasingNo = Children(i).Data
   Case "RequestPurchasingSeq":z3113.RequestPurchasingSeq = Children(i).Data
   Case "Dseq":z3113.Dseq = Children(i).Data
   Case "YarnCode":z3113.YarnCode = Children(i).Data
   Case "WgtCone":z3113.WgtCone = Children(i).Data
   Case "ConeBox":z3113.ConeBox = Children(i).Data
   Case "WgtBox":z3113.WgtBox = Children(i).Data
   Case "cdUnitPricePurchasing":z3113.cdUnitPricePurchasing = Children(i).Data
   Case "PricePurchasing":z3113.PricePurchasing = Children(i).Data
   Case "PriceExchange":z3113.PriceExchange = Children(i).Data
   Case "DateExchange":z3113.DateExchange = Children(i).Data
   Case "PricePurchasingUSD":z3113.PricePurchasingUSD = Children(i).Data
   Case "PricePurchasingVND":z3113.PricePurchasingVND = Children(i).Data
   Case "AmountOrderUSD":z3113.AmountOrderUSD = Children(i).Data
   Case "AmountOrderVND":z3113.AmountOrderVND = Children(i).Data
   Case "AmountYarnInboundUSD":z3113.AmountYarnInboundUSD = Children(i).Data
   Case "AmountYarnInboundVND":z3113.AmountYarnInboundVND = Children(i).Data
   Case "BoxRequestPurchasing":z3113.BoxRequestPurchasing = Children(i).Data
   Case "ConeRequestPurchasing":z3113.ConeRequestPurchasing = Children(i).Data
   Case "WgtRequestPurchasing":z3113.WgtRequestPurchasing = Children(i).Data
   Case "BoxGrossInboundYarn":z3113.BoxGrossInboundYarn = Children(i).Data
   Case "ConeGrossInboundYarn":z3113.ConeGrossInboundYarn = Children(i).Data
   Case "WgtGrossInboundYarn":z3113.WgtGrossInboundYarn = Children(i).Data
   Case "ConeNetInboundYarn":z3113.ConeNetInboundYarn = Children(i).Data
   Case "BoxNetInboundYarn":z3113.BoxNetInboundYarn = Children(i).Data
   Case "WgtNetInboundYarn":z3113.WgtNetInboundYarn = Children(i).Data
   Case "CheckRequestPurchasing":z3113.CheckRequestPurchasing = Children(i).Data
   Case "DateRequestPurchasing":z3113.DateRequestPurchasing = Children(i).Data
   Case "DateCompletePurchasing":z3113.DateCompletePurchasing = Children(i).Data
   Case "DateApprovalPurchasing":z3113.DateApprovalPurchasing = Children(i).Data
   Case "DateCancelPurchasing":z3113.DateCancelPurchasing = Children(i).Data
   Case "CheckCpmplete":z3113.CheckCpmplete = Children(i).Data
   Case "Remark":z3113.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3113_MOVE",vbCritical)
End Try
End Function 
    
End Module 
