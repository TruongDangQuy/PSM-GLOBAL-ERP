'=========================================================================================================================================================
'   TABLE : (PFK3111)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K3111

Structure T3111_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	RequestPurchasingNo	 AS String	'			nvarchar(9)		*
Public 	cdFactory	 AS String	'			nvarchar(3)
Public 	DateRequestPurchasing	 AS String	'			char(8)
Public 	CheckProcessPurchsing	 AS String	'			char(1)
Public 	CheckMarketType	 AS String	'			char(1)
Public 	CustomerPurchasing	 AS String	'			char(6)
Public 	cdPaymentCondition	 AS String	'			char(3)
Public 	InchargePurcharsing	 AS String	'			char(8)
Public 	BoxRequestPurchasing	 AS Double	'			decimal
Public 	ConeRequestPurchasing	 AS Double	'			decimal
Public 	WgtRequestPurchasing	 AS Double	'			decimal
Public 	BoxGrossInboundYarn	 AS Double	'			decimal
Public 	ConeGrossInboundYarn	 AS Double	'			decimal
Public 	WgtGrossInboundYarn	 AS Double	'			decimal
Public 	BoxNetInboundYarn	 AS Double	'			decimal
Public 	ConeNetInboundYarn	 AS Double	'			decimal
Public 	WgtNetInboundYarn	 AS Double	'			decimal
Public 	DateDelivery	 AS String	'			char(8)
Public 	DateSart	 AS String	'			char(8)
Public 	DateFinish	 AS String	'			char(8)
Public 	CheckCpmplete	 AS String	'			char(1)
Public 	Remark	 AS String	'			nvarchar(-1)
'=========================================================================================================================================================
End structure

Public D3111 As T3111_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK3111(REQUESTPURCHASINGNO AS String) As Boolean
    READ_PFK3111 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3111 "
    SQL = SQL & " WHERE K3111_RequestPurchasingNo		 = '" & RequestPurchasingNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D3111_CLEAR: GoTo SKIP_READ_PFK3111
                
    Call K3111_MOVE(rd)
    READ_PFK3111 = True

SKIP_READ_PFK3111:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK3111",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK3111(REQUESTPURCHASINGNO AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3111 "
    SQL = SQL & " WHERE K3111_RequestPurchasingNo		 = '" & RequestPurchasingNo & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK3111",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK3111(z3111 As T3111_AREA) As Boolean
    WRITE_PFK3111 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z3111)
 
    SQL = " INSERT INTO PFK3111 "
    SQL = SQL & " ( "
    SQL = SQL & " K3111_RequestPurchasingNo," 
    SQL = SQL & " K3111_cdFactory," 
    SQL = SQL & " K3111_DateRequestPurchasing," 
    SQL = SQL & " K3111_CheckProcessPurchsing," 
    SQL = SQL & " K3111_CheckMarketType," 
    SQL = SQL & " K3111_CustomerPurchasing," 
    SQL = SQL & " K3111_cdPaymentCondition," 
    SQL = SQL & " K3111_InchargePurcharsing," 
    SQL = SQL & " K3111_BoxRequestPurchasing," 
    SQL = SQL & " K3111_ConeRequestPurchasing," 
    SQL = SQL & " K3111_WgtRequestPurchasing," 
    SQL = SQL & " K3111_BoxGrossInboundYarn," 
    SQL = SQL & " K3111_ConeGrossInboundYarn," 
    SQL = SQL & " K3111_WgtGrossInboundYarn," 
    SQL = SQL & " K3111_BoxNetInboundYarn," 
    SQL = SQL & " K3111_ConeNetInboundYarn," 
    SQL = SQL & " K3111_WgtNetInboundYarn," 
    SQL = SQL & " K3111_DateDelivery," 
    SQL = SQL & " K3111_DateSart," 
    SQL = SQL & " K3111_DateFinish," 
    SQL = SQL & " K3111_CheckCpmplete," 
    SQL = SQL & " K3111_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  '" & z3111.RequestPurchasingNo & "', "  
    SQL = SQL & "  '" & z3111.cdFactory & "', "  
    SQL = SQL & "  '" & z3111.DateRequestPurchasing & "', "  
    SQL = SQL & "  '" & z3111.CheckProcessPurchsing & "', "  
    SQL = SQL & "  '" & z3111.CheckMarketType & "', "  
    SQL = SQL & "  '" & z3111.CustomerPurchasing & "', "  
    SQL = SQL & "  '" & z3111.cdPaymentCondition & "', "  
    SQL = SQL & "  '" & z3111.InchargePurcharsing & "', "  
    SQL = SQL & "   " & z3111.BoxRequestPurchasing & " , "  
    SQL = SQL & "   " & z3111.ConeRequestPurchasing & " , "  
    SQL = SQL & "   " & z3111.WgtRequestPurchasing & " , "  
    SQL = SQL & "   " & z3111.BoxGrossInboundYarn & " , "  
    SQL = SQL & "   " & z3111.ConeGrossInboundYarn & " , "  
    SQL = SQL & "   " & z3111.WgtGrossInboundYarn & " , "  
    SQL = SQL & "   " & z3111.BoxNetInboundYarn & " , "  
    SQL = SQL & "   " & z3111.ConeNetInboundYarn & " , "  
    SQL = SQL & "   " & z3111.WgtNetInboundYarn & " , "  
    SQL = SQL & "  '" & z3111.DateDelivery & "', "  
    SQL = SQL & "  '" & z3111.DateSart & "', "  
    SQL = SQL & "  '" & z3111.DateFinish & "', "  
    SQL = SQL & "  '" & z3111.CheckCpmplete & "', "  
    SQL = SQL & "  '" & z3111.Remark & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK3111 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK3111",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK3111(z3111 As T3111_AREA) As Boolean
    REWRITE_PFK3111 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z3111)
   
    SQL = " UPDATE PFK3111 SET "
    SQL = SQL & "    K3111_cdFactory      = '" & z3111.cdFactory & "', " 
    SQL = SQL & "    K3111_DateRequestPurchasing      = '" & z3111.DateRequestPurchasing & "', " 
    SQL = SQL & "    K3111_CheckProcessPurchsing      = '" & z3111.CheckProcessPurchsing & "', " 
    SQL = SQL & "    K3111_CheckMarketType      = '" & z3111.CheckMarketType & "', " 
    SQL = SQL & "    K3111_CustomerPurchasing      = '" & z3111.CustomerPurchasing & "', " 
    SQL = SQL & "    K3111_cdPaymentCondition      = '" & z3111.cdPaymentCondition & "', " 
    SQL = SQL & "    K3111_InchargePurcharsing      = '" & z3111.InchargePurcharsing & "', " 
    SQL = SQL & "    K3111_BoxRequestPurchasing      =  " & z3111.BoxRequestPurchasing & " , " 
    SQL = SQL & "    K3111_ConeRequestPurchasing      =  " & z3111.ConeRequestPurchasing & " , " 
    SQL = SQL & "    K3111_WgtRequestPurchasing      =  " & z3111.WgtRequestPurchasing & " , " 
    SQL = SQL & "    K3111_BoxGrossInboundYarn      =  " & z3111.BoxGrossInboundYarn & " , " 
    SQL = SQL & "    K3111_ConeGrossInboundYarn      =  " & z3111.ConeGrossInboundYarn & " , " 
    SQL = SQL & "    K3111_WgtGrossInboundYarn      =  " & z3111.WgtGrossInboundYarn & " , " 
    SQL = SQL & "    K3111_BoxNetInboundYarn      =  " & z3111.BoxNetInboundYarn & " , " 
    SQL = SQL & "    K3111_ConeNetInboundYarn      =  " & z3111.ConeNetInboundYarn & " , " 
    SQL = SQL & "    K3111_WgtNetInboundYarn      =  " & z3111.WgtNetInboundYarn & " , " 
    SQL = SQL & "    K3111_DateDelivery      = '" & z3111.DateDelivery & "', " 
    SQL = SQL & "    K3111_DateSart      = '" & z3111.DateSart & "', " 
    SQL = SQL & "    K3111_DateFinish      = '" & z3111.DateFinish & "', " 
    SQL = SQL & "    K3111_CheckCpmplete      = '" & z3111.CheckCpmplete & "', " 
    SQL = SQL & "    K3111_Remark      = '" & z3111.Remark & "'  " 
    SQL = SQL & " WHERE K3111_RequestPurchasingNo		 = '" & z3111.RequestPurchasingNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK3111 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK3111",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK3111(z3111 As T3111_AREA) As Boolean
    DELETE_PFK3111 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK3111 "
    SQL = SQL & " WHERE K3111_RequestPurchasingNo		 = '" & z3111.RequestPurchasingNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK3111 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK3111",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D3111_CLEAR()
Try
    
   D3111.RequestPurchasingNo = ""
   D3111.cdFactory = ""
   D3111.DateRequestPurchasing = ""
   D3111.CheckProcessPurchsing = ""
   D3111.CheckMarketType = ""
   D3111.CustomerPurchasing = ""
   D3111.cdPaymentCondition = ""
   D3111.InchargePurcharsing = ""
    D3111.BoxRequestPurchasing = 0 
    D3111.ConeRequestPurchasing = 0 
    D3111.WgtRequestPurchasing = 0 
    D3111.BoxGrossInboundYarn = 0 
    D3111.ConeGrossInboundYarn = 0 
    D3111.WgtGrossInboundYarn = 0 
    D3111.BoxNetInboundYarn = 0 
    D3111.ConeNetInboundYarn = 0 
    D3111.WgtNetInboundYarn = 0 
   D3111.DateDelivery = ""
   D3111.DateSart = ""
   D3111.DateFinish = ""
   D3111.CheckCpmplete = ""
   D3111.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D3111_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x3111 As T3111_AREA)
Try
    
    x3111.RequestPurchasingNo = trim$(  x3111.RequestPurchasingNo)
    x3111.cdFactory = trim$(  x3111.cdFactory)
    x3111.DateRequestPurchasing = trim$(  x3111.DateRequestPurchasing)
    x3111.CheckProcessPurchsing = trim$(  x3111.CheckProcessPurchsing)
    x3111.CheckMarketType = trim$(  x3111.CheckMarketType)
    x3111.CustomerPurchasing = trim$(  x3111.CustomerPurchasing)
    x3111.cdPaymentCondition = trim$(  x3111.cdPaymentCondition)
    x3111.InchargePurcharsing = trim$(  x3111.InchargePurcharsing)
    x3111.BoxRequestPurchasing = trim$(  x3111.BoxRequestPurchasing)
    x3111.ConeRequestPurchasing = trim$(  x3111.ConeRequestPurchasing)
    x3111.WgtRequestPurchasing = trim$(  x3111.WgtRequestPurchasing)
    x3111.BoxGrossInboundYarn = trim$(  x3111.BoxGrossInboundYarn)
    x3111.ConeGrossInboundYarn = trim$(  x3111.ConeGrossInboundYarn)
    x3111.WgtGrossInboundYarn = trim$(  x3111.WgtGrossInboundYarn)
    x3111.BoxNetInboundYarn = trim$(  x3111.BoxNetInboundYarn)
    x3111.ConeNetInboundYarn = trim$(  x3111.ConeNetInboundYarn)
    x3111.WgtNetInboundYarn = trim$(  x3111.WgtNetInboundYarn)
    x3111.DateDelivery = trim$(  x3111.DateDelivery)
    x3111.DateSart = trim$(  x3111.DateSart)
    x3111.DateFinish = trim$(  x3111.DateFinish)
    x3111.CheckCpmplete = trim$(  x3111.CheckCpmplete)
    x3111.Remark = trim$(  x3111.Remark)
     
    If trim$( x3111.RequestPurchasingNo ) = "" Then x3111.RequestPurchasingNo = Space(1) 
    If trim$( x3111.cdFactory ) = "" Then x3111.cdFactory = Space(1) 
    If trim$( x3111.DateRequestPurchasing ) = "" Then x3111.DateRequestPurchasing = Space(1) 
    If trim$( x3111.CheckProcessPurchsing ) = "" Then x3111.CheckProcessPurchsing = Space(1) 
    If trim$( x3111.CheckMarketType ) = "" Then x3111.CheckMarketType = Space(1) 
    If trim$( x3111.CustomerPurchasing ) = "" Then x3111.CustomerPurchasing = Space(1) 
    If trim$( x3111.cdPaymentCondition ) = "" Then x3111.cdPaymentCondition = Space(1) 
    If trim$( x3111.InchargePurcharsing ) = "" Then x3111.InchargePurcharsing = Space(1) 
    If trim$( x3111.BoxRequestPurchasing ) = "" Then x3111.BoxRequestPurchasing = 0 
    If trim$( x3111.ConeRequestPurchasing ) = "" Then x3111.ConeRequestPurchasing = 0 
    If trim$( x3111.WgtRequestPurchasing ) = "" Then x3111.WgtRequestPurchasing = 0 
    If trim$( x3111.BoxGrossInboundYarn ) = "" Then x3111.BoxGrossInboundYarn = 0 
    If trim$( x3111.ConeGrossInboundYarn ) = "" Then x3111.ConeGrossInboundYarn = 0 
    If trim$( x3111.WgtGrossInboundYarn ) = "" Then x3111.WgtGrossInboundYarn = 0 
    If trim$( x3111.BoxNetInboundYarn ) = "" Then x3111.BoxNetInboundYarn = 0 
    If trim$( x3111.ConeNetInboundYarn ) = "" Then x3111.ConeNetInboundYarn = 0 
    If trim$( x3111.WgtNetInboundYarn ) = "" Then x3111.WgtNetInboundYarn = 0 
    If trim$( x3111.DateDelivery ) = "" Then x3111.DateDelivery = Space(1) 
    If trim$( x3111.DateSart ) = "" Then x3111.DateSart = Space(1) 
    If trim$( x3111.DateFinish ) = "" Then x3111.DateFinish = Space(1) 
    If trim$( x3111.CheckCpmplete ) = "" Then x3111.CheckCpmplete = Space(1) 
    If trim$( x3111.Remark ) = "" Then x3111.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K3111_MOVE(rs3111 As SqlClient.SqlDataReader)
Try

    call D3111_CLEAR()   

    If IsdbNull(rs3111!K3111_RequestPurchasingNo) = False Then D3111.RequestPurchasingNo = Trim$(rs3111!K3111_RequestPurchasingNo)
    If IsdbNull(rs3111!K3111_cdFactory) = False Then D3111.cdFactory = Trim$(rs3111!K3111_cdFactory)
    If IsdbNull(rs3111!K3111_DateRequestPurchasing) = False Then D3111.DateRequestPurchasing = Trim$(rs3111!K3111_DateRequestPurchasing)
    If IsdbNull(rs3111!K3111_CheckProcessPurchsing) = False Then D3111.CheckProcessPurchsing = Trim$(rs3111!K3111_CheckProcessPurchsing)
    If IsdbNull(rs3111!K3111_CheckMarketType) = False Then D3111.CheckMarketType = Trim$(rs3111!K3111_CheckMarketType)
    If IsdbNull(rs3111!K3111_CustomerPurchasing) = False Then D3111.CustomerPurchasing = Trim$(rs3111!K3111_CustomerPurchasing)
    If IsdbNull(rs3111!K3111_cdPaymentCondition) = False Then D3111.cdPaymentCondition = Trim$(rs3111!K3111_cdPaymentCondition)
    If IsdbNull(rs3111!K3111_InchargePurcharsing) = False Then D3111.InchargePurcharsing = Trim$(rs3111!K3111_InchargePurcharsing)
    If IsdbNull(rs3111!K3111_BoxRequestPurchasing) = False Then D3111.BoxRequestPurchasing = Trim$(rs3111!K3111_BoxRequestPurchasing)
    If IsdbNull(rs3111!K3111_ConeRequestPurchasing) = False Then D3111.ConeRequestPurchasing = Trim$(rs3111!K3111_ConeRequestPurchasing)
    If IsdbNull(rs3111!K3111_WgtRequestPurchasing) = False Then D3111.WgtRequestPurchasing = Trim$(rs3111!K3111_WgtRequestPurchasing)
    If IsdbNull(rs3111!K3111_BoxGrossInboundYarn) = False Then D3111.BoxGrossInboundYarn = Trim$(rs3111!K3111_BoxGrossInboundYarn)
    If IsdbNull(rs3111!K3111_ConeGrossInboundYarn) = False Then D3111.ConeGrossInboundYarn = Trim$(rs3111!K3111_ConeGrossInboundYarn)
    If IsdbNull(rs3111!K3111_WgtGrossInboundYarn) = False Then D3111.WgtGrossInboundYarn = Trim$(rs3111!K3111_WgtGrossInboundYarn)
    If IsdbNull(rs3111!K3111_BoxNetInboundYarn) = False Then D3111.BoxNetInboundYarn = Trim$(rs3111!K3111_BoxNetInboundYarn)
    If IsdbNull(rs3111!K3111_ConeNetInboundYarn) = False Then D3111.ConeNetInboundYarn = Trim$(rs3111!K3111_ConeNetInboundYarn)
    If IsdbNull(rs3111!K3111_WgtNetInboundYarn) = False Then D3111.WgtNetInboundYarn = Trim$(rs3111!K3111_WgtNetInboundYarn)
    If IsdbNull(rs3111!K3111_DateDelivery) = False Then D3111.DateDelivery = Trim$(rs3111!K3111_DateDelivery)
    If IsdbNull(rs3111!K3111_DateSart) = False Then D3111.DateSart = Trim$(rs3111!K3111_DateSart)
    If IsdbNull(rs3111!K3111_DateFinish) = False Then D3111.DateFinish = Trim$(rs3111!K3111_DateFinish)
    If IsdbNull(rs3111!K3111_CheckCpmplete) = False Then D3111.CheckCpmplete = Trim$(rs3111!K3111_CheckCpmplete)
    If IsdbNull(rs3111!K3111_Remark) = False Then D3111.Remark = Trim$(rs3111!K3111_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3111_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K3111_MOVE(rs3111 As DataRow)
Try

    call D3111_CLEAR()   

    If IsdbNull(rs3111!K3111_RequestPurchasingNo) = False Then D3111.RequestPurchasingNo = Trim$(rs3111!K3111_RequestPurchasingNo)
    If IsdbNull(rs3111!K3111_cdFactory) = False Then D3111.cdFactory = Trim$(rs3111!K3111_cdFactory)
    If IsdbNull(rs3111!K3111_DateRequestPurchasing) = False Then D3111.DateRequestPurchasing = Trim$(rs3111!K3111_DateRequestPurchasing)
    If IsdbNull(rs3111!K3111_CheckProcessPurchsing) = False Then D3111.CheckProcessPurchsing = Trim$(rs3111!K3111_CheckProcessPurchsing)
    If IsdbNull(rs3111!K3111_CheckMarketType) = False Then D3111.CheckMarketType = Trim$(rs3111!K3111_CheckMarketType)
    If IsdbNull(rs3111!K3111_CustomerPurchasing) = False Then D3111.CustomerPurchasing = Trim$(rs3111!K3111_CustomerPurchasing)
    If IsdbNull(rs3111!K3111_cdPaymentCondition) = False Then D3111.cdPaymentCondition = Trim$(rs3111!K3111_cdPaymentCondition)
    If IsdbNull(rs3111!K3111_InchargePurcharsing) = False Then D3111.InchargePurcharsing = Trim$(rs3111!K3111_InchargePurcharsing)
    If IsdbNull(rs3111!K3111_BoxRequestPurchasing) = False Then D3111.BoxRequestPurchasing = Trim$(rs3111!K3111_BoxRequestPurchasing)
    If IsdbNull(rs3111!K3111_ConeRequestPurchasing) = False Then D3111.ConeRequestPurchasing = Trim$(rs3111!K3111_ConeRequestPurchasing)
    If IsdbNull(rs3111!K3111_WgtRequestPurchasing) = False Then D3111.WgtRequestPurchasing = Trim$(rs3111!K3111_WgtRequestPurchasing)
    If IsdbNull(rs3111!K3111_BoxGrossInboundYarn) = False Then D3111.BoxGrossInboundYarn = Trim$(rs3111!K3111_BoxGrossInboundYarn)
    If IsdbNull(rs3111!K3111_ConeGrossInboundYarn) = False Then D3111.ConeGrossInboundYarn = Trim$(rs3111!K3111_ConeGrossInboundYarn)
    If IsdbNull(rs3111!K3111_WgtGrossInboundYarn) = False Then D3111.WgtGrossInboundYarn = Trim$(rs3111!K3111_WgtGrossInboundYarn)
    If IsdbNull(rs3111!K3111_BoxNetInboundYarn) = False Then D3111.BoxNetInboundYarn = Trim$(rs3111!K3111_BoxNetInboundYarn)
    If IsdbNull(rs3111!K3111_ConeNetInboundYarn) = False Then D3111.ConeNetInboundYarn = Trim$(rs3111!K3111_ConeNetInboundYarn)
    If IsdbNull(rs3111!K3111_WgtNetInboundYarn) = False Then D3111.WgtNetInboundYarn = Trim$(rs3111!K3111_WgtNetInboundYarn)
    If IsdbNull(rs3111!K3111_DateDelivery) = False Then D3111.DateDelivery = Trim$(rs3111!K3111_DateDelivery)
    If IsdbNull(rs3111!K3111_DateSart) = False Then D3111.DateSart = Trim$(rs3111!K3111_DateSart)
    If IsdbNull(rs3111!K3111_DateFinish) = False Then D3111.DateFinish = Trim$(rs3111!K3111_DateFinish)
    If IsdbNull(rs3111!K3111_CheckCpmplete) = False Then D3111.CheckCpmplete = Trim$(rs3111!K3111_CheckCpmplete)
    If IsdbNull(rs3111!K3111_Remark) = False Then D3111.Remark = Trim$(rs3111!K3111_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3111_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K3111_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3111 As T3111_AREA,REQUESTPURCHASINGNO AS String) as Boolean

K3111_MOVE = False

Try
    If READ_PFK3111(REQUESTPURCHASINGNO) = True Then
                z3111 = D3111
		K3111_MOVE = True
            End If

   z3111.RequestPurchasingNo = getDataM(spr, getColumIndex(spr,"RequestPurchasingNo"), xRow)
   z3111.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
   z3111.DateRequestPurchasing = getDataM(spr, getColumIndex(spr,"DateRequestPurchasing"), xRow)
   z3111.CheckProcessPurchsing = getDataM(spr, getColumIndex(spr,"CheckProcessPurchsing"), xRow)
   z3111.CheckMarketType = getDataM(spr, getColumIndex(spr,"CheckMarketType"), xRow)
   z3111.CustomerPurchasing = getDataM(spr, getColumIndex(spr,"CustomerPurchasing"), xRow)
   z3111.cdPaymentCondition = getDataM(spr, getColumIndex(spr,"cdPaymentCondition"), xRow)
   z3111.InchargePurcharsing = getDataM(spr, getColumIndex(spr,"InchargePurcharsing"), xRow)
   z3111.BoxRequestPurchasing = getDataM(spr, getColumIndex(spr,"BoxRequestPurchasing"), xRow)
   z3111.ConeRequestPurchasing = getDataM(spr, getColumIndex(spr,"ConeRequestPurchasing"), xRow)
   z3111.WgtRequestPurchasing = getDataM(spr, getColumIndex(spr,"WgtRequestPurchasing"), xRow)
   z3111.BoxGrossInboundYarn = getDataM(spr, getColumIndex(spr,"BoxGrossInboundYarn"), xRow)
   z3111.ConeGrossInboundYarn = getDataM(spr, getColumIndex(spr,"ConeGrossInboundYarn"), xRow)
   z3111.WgtGrossInboundYarn = getDataM(spr, getColumIndex(spr,"WgtGrossInboundYarn"), xRow)
   z3111.BoxNetInboundYarn = getDataM(spr, getColumIndex(spr,"BoxNetInboundYarn"), xRow)
   z3111.ConeNetInboundYarn = getDataM(spr, getColumIndex(spr,"ConeNetInboundYarn"), xRow)
   z3111.WgtNetInboundYarn = getDataM(spr, getColumIndex(spr,"WgtNetInboundYarn"), xRow)
   z3111.DateDelivery = getDataM(spr, getColumIndex(spr,"DateDelivery"), xRow)
   z3111.DateSart = getDataM(spr, getColumIndex(spr,"DateSart"), xRow)
   z3111.DateFinish = getDataM(spr, getColumIndex(spr,"DateFinish"), xRow)
   z3111.CheckCpmplete = getDataM(spr, getColumIndex(spr,"CheckCpmplete"), xRow)
   z3111.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3111_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K3111_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3111 As T3111_AREA, Job as String,REQUESTPURCHASINGNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3111_MOVE = False

Try
    If READ_PFK3111(REQUESTPURCHASINGNO) = True Then
                z3111 = D3111
		K3111_MOVE = True

    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3111")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "RequestPurchasingNo":z3111.RequestPurchasingNo = Children(i).Code
   Case "cdFactory":z3111.cdFactory = Children(i).Code
   Case "DateRequestPurchasing":z3111.DateRequestPurchasing = Children(i).Code
   Case "CheckProcessPurchsing":z3111.CheckProcessPurchsing = Children(i).Code
   Case "CheckMarketType":z3111.CheckMarketType = Children(i).Code
   Case "CustomerPurchasing":z3111.CustomerPurchasing = Children(i).Code
   Case "cdPaymentCondition":z3111.cdPaymentCondition = Children(i).Code
   Case "InchargePurcharsing":z3111.InchargePurcharsing = Children(i).Code
   Case "BoxRequestPurchasing":z3111.BoxRequestPurchasing = Children(i).Code
   Case "ConeRequestPurchasing":z3111.ConeRequestPurchasing = Children(i).Code
   Case "WgtRequestPurchasing":z3111.WgtRequestPurchasing = Children(i).Code
   Case "BoxGrossInboundYarn":z3111.BoxGrossInboundYarn = Children(i).Code
   Case "ConeGrossInboundYarn":z3111.ConeGrossInboundYarn = Children(i).Code
   Case "WgtGrossInboundYarn":z3111.WgtGrossInboundYarn = Children(i).Code
   Case "BoxNetInboundYarn":z3111.BoxNetInboundYarn = Children(i).Code
   Case "ConeNetInboundYarn":z3111.ConeNetInboundYarn = Children(i).Code
   Case "WgtNetInboundYarn":z3111.WgtNetInboundYarn = Children(i).Code
   Case "DateDelivery":z3111.DateDelivery = Children(i).Code
   Case "DateSart":z3111.DateSart = Children(i).Code
   Case "DateFinish":z3111.DateFinish = Children(i).Code
   Case "CheckCpmplete":z3111.CheckCpmplete = Children(i).Code
   Case "Remark":z3111.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "RequestPurchasingNo":z3111.RequestPurchasingNo = Children(i).Data
   Case "cdFactory":z3111.cdFactory = Children(i).Data
   Case "DateRequestPurchasing":z3111.DateRequestPurchasing = Children(i).Data
   Case "CheckProcessPurchsing":z3111.CheckProcessPurchsing = Children(i).Data
   Case "CheckMarketType":z3111.CheckMarketType = Children(i).Data
   Case "CustomerPurchasing":z3111.CustomerPurchasing = Children(i).Data
   Case "cdPaymentCondition":z3111.cdPaymentCondition = Children(i).Data
   Case "InchargePurcharsing":z3111.InchargePurcharsing = Children(i).Data
   Case "BoxRequestPurchasing":z3111.BoxRequestPurchasing = Children(i).Data
   Case "ConeRequestPurchasing":z3111.ConeRequestPurchasing = Children(i).Data
   Case "WgtRequestPurchasing":z3111.WgtRequestPurchasing = Children(i).Data
   Case "BoxGrossInboundYarn":z3111.BoxGrossInboundYarn = Children(i).Data
   Case "ConeGrossInboundYarn":z3111.ConeGrossInboundYarn = Children(i).Data
   Case "WgtGrossInboundYarn":z3111.WgtGrossInboundYarn = Children(i).Data
   Case "BoxNetInboundYarn":z3111.BoxNetInboundYarn = Children(i).Data
   Case "ConeNetInboundYarn":z3111.ConeNetInboundYarn = Children(i).Data
   Case "WgtNetInboundYarn":z3111.WgtNetInboundYarn = Children(i).Data
   Case "DateDelivery":z3111.DateDelivery = Children(i).Data
   Case "DateSart":z3111.DateSart = Children(i).Data
   Case "DateFinish":z3111.DateFinish = Children(i).Data
   Case "CheckCpmplete":z3111.CheckCpmplete = Children(i).Data
   Case "Remark":z3111.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3111_MOVE",vbCritical)
End Try
End Function 
    
End Module 
