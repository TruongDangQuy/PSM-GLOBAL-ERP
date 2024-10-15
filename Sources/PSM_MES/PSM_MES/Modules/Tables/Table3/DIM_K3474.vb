'=========================================================================================================================================================
'   TABLE : (PFK3474)
'
'      WORKER : PSM GLOBAL ., LTD
'       WORK DATE : 2019 NEW
'       DEVELOPER    : MRNLV
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K3474

Structure T3474_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	Autokey	 AS Double	'			decimal		*
Public 	LiquidNo	 AS String	'			char(9)
Public 	LiquidSeq	 AS String	'			char(4)
Public 	CheckKindMain	 AS String	'			char(1)
Public 	TradingCode	 AS String	'			nvarchar(50)
Public 	GrossUsage	 AS Double	'			decimal
Public 	QtyOrder	 AS Double	'			decimal
Public 	QtyDemand	 AS Double	'			decimal
Public 	QtyInbound	 AS Double	'			decimal
Public 	InvoinceIn	 AS String	'			nvarchar(200)
Public 	QtyOutbound	 AS Double	'			decimal
Public 	InvoinceOut	 AS String	'			nvarchar(200)
Public 	Remark	 AS String	'			nvarchar(100)
Public 	TimeInsert	 AS String	'			char(14)
Public 	TimeUpdate	 AS String	'			char(14)
Public 	DateUpdate	 AS String	'			char(8)
Public 	DateInsert	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
'=========================================================================================================================================================
End structure

Public D3474 As T3474_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK3474(AUTOKEY AS Double) As Boolean
    READ_PFK3474 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3474 "
    SQL = SQL & " WHERE K3474_Autokey		 =  " & Autokey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D3474_CLEAR: GoTo SKIP_READ_PFK3474
                
    Call K3474_MOVE(rd)
    READ_PFK3474 = True

SKIP_READ_PFK3474:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK3474",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK3474(AUTOKEY AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3474 "
    SQL = SQL & " WHERE K3474_Autokey		 =  " & Autokey & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK3474",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK3474(z3474 As T3474_AREA) As Boolean
    WRITE_PFK3474 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z3474)
 
    SQL = " INSERT INTO PFK3474 "
    SQL = SQL & " ( "
    SQL = SQL & " K3474_Autokey," 
    SQL = SQL & " K3474_LiquidNo," 
    SQL = SQL & " K3474_LiquidSeq," 
    SQL = SQL & " K3474_CheckKindMain," 
    SQL = SQL & " K3474_TradingCode," 
    SQL = SQL & " K3474_GrossUsage," 
    SQL = SQL & " K3474_QtyOrder," 
    SQL = SQL & " K3474_QtyDemand," 
    SQL = SQL & " K3474_QtyInbound," 
    SQL = SQL & " K3474_InvoinceIn," 
    SQL = SQL & " K3474_QtyOutbound," 
    SQL = SQL & " K3474_InvoinceOut," 
    SQL = SQL & " K3474_Remark," 
    SQL = SQL & " K3474_TimeInsert," 
    SQL = SQL & " K3474_TimeUpdate," 
    SQL = SQL & " K3474_DateUpdate," 
    SQL = SQL & " K3474_DateInsert," 
    SQL = SQL & " K3474_InchargeInsert," 
    SQL = SQL & " K3474_InchargeUpdate " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "   " & FormatSQL(z3474.Autokey) & ", "  
    If Trim$(z3474.LiquidNo) = "" Then
        SQL = SQL & "  NULL , "
    Else
        SQL = SQL & "  N'" & FormatSQL(z3474.LiquidNo) & "', "  
    End If
    If Trim$(z3474.LiquidSeq) = "" Then
        SQL = SQL & "  NULL , "
    Else
        SQL = SQL & "  N'" & FormatSQL(z3474.LiquidSeq) & "', "  
    End If
    SQL = SQL & "  N'" & FormatSQL(z3474.CheckKindMain) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3474.TradingCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z3474.GrossUsage) & ", "  
    SQL = SQL & "   " & FormatSQL(z3474.QtyOrder) & ", "  
    SQL = SQL & "   " & FormatSQL(z3474.QtyDemand) & ", "  
    SQL = SQL & "   " & FormatSQL(z3474.QtyInbound) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3474.InvoinceIn) & "', "  
    SQL = SQL & "   " & FormatSQL(z3474.QtyOutbound) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3474.InvoinceOut) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3474.Remark) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.TIME) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3474.TimeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3474.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.DAT) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.SAW) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3474.InchargeUpdate) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK3474 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK3474",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK3474(z3474 As T3474_AREA) As Boolean
    REWRITE_PFK3474 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z3474)
   
    SQL = " UPDATE PFK3474 SET "
    If Trim$(z3474.LiquidNo) = "" Then
        SQL = SQL & " K3474_LiquidNo      =  NULL , "
    Else
        SQL = SQL & "    K3474_LiquidNo      =  N'" & FormatSQL(z3474.LiquidNo) & "', " 
    End If
    If Trim$(z3474.LiquidSeq) = "" Then
        SQL = SQL & " K3474_LiquidSeq      =  NULL , "
    Else
        SQL = SQL & "    K3474_LiquidSeq      =  N'" & FormatSQL(z3474.LiquidSeq) & "', " 
    End If
    SQL = SQL & "    K3474_CheckKindMain      = N'" & FormatSQL(z3474.CheckKindMain) & "', " 
    SQL = SQL & "    K3474_TradingCode      = N'" & FormatSQL(z3474.TradingCode) & "', " 
    SQL = SQL & "    K3474_GrossUsage      =  " & FormatSQL(z3474.GrossUsage) & ", " 
    SQL = SQL & "    K3474_QtyOrder      =  " & FormatSQL(z3474.QtyOrder) & ", " 
    SQL = SQL & "    K3474_QtyDemand      =  " & FormatSQL(z3474.QtyDemand) & ", " 
    SQL = SQL & "    K3474_QtyInbound      =  " & FormatSQL(z3474.QtyInbound) & ", " 
    SQL = SQL & "    K3474_InvoinceIn      = N'" & FormatSQL(z3474.InvoinceIn) & "', " 
    SQL = SQL & "    K3474_QtyOutbound      =  " & FormatSQL(z3474.QtyOutbound) & ", " 
    SQL = SQL & "    K3474_InvoinceOut      = N'" & FormatSQL(z3474.InvoinceOut) & "', " 
    SQL = SQL & "    K3474_Remark      = N'" & FormatSQL(z3474.Remark) & "', " 
    SQL = SQL & "    K3474_TimeInsert      = N'" & FormatSQL(z3474.TimeInsert) & "', " 
    SQL = SQL & "    K3474_TimeUpdate      = N'" & FormatSQL(PUB.TIME) & "', " 
    SQL = SQL & "    K3474_DateUpdate      = N'" & FormatSQL(PUB.DAT) & "', " 
    SQL = SQL & "    K3474_DateInsert      = N'" & FormatSQL(z3474.DateInsert) & "', " 
    SQL = SQL & "    K3474_InchargeInsert      = N'" & FormatSQL(z3474.InchargeInsert) & "', " 
    SQL = SQL & "    K3474_InchargeUpdate      = N'" & FormatSQL(PUB.SAW) & "'  " 
    SQL = SQL & " WHERE K3474_Autokey		 =  " & z3474.Autokey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  

    REWRITE_PFK3474 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK3474",vbCritical)

  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK3474(z3474 As T3474_AREA) As Boolean
    DELETE_PFK3474 = False

   Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z3474)
      
        SQL = " DELETE FROM PFK3474  "
    SQL = SQL & " WHERE K3474_Autokey		 =  " & z3474.Autokey & "  " 

    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK3474 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK3474",vbCritical)
Finally
        Call GetFullInformation("PFK3474", "D", SQL)
  End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D3474_CLEAR()
Try
    
    D3474.Autokey = 0 
   D3474.LiquidNo = ""
   D3474.LiquidSeq = ""
   D3474.CheckKindMain = ""
   D3474.TradingCode = ""
    D3474.GrossUsage = 0 
    D3474.QtyOrder = 0 
    D3474.QtyDemand = 0 
    D3474.QtyInbound = 0 
   D3474.InvoinceIn = ""
    D3474.QtyOutbound = 0 
   D3474.InvoinceOut = ""
   D3474.Remark = ""
   D3474.TimeInsert = ""
   D3474.TimeUpdate = ""
   D3474.DateUpdate = ""
   D3474.DateInsert = ""
   D3474.InchargeInsert = ""
   D3474.InchargeUpdate = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D3474_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x3474 As T3474_AREA)
Try
    
    x3474.Autokey = trim$(  x3474.Autokey)
    x3474.LiquidNo = trim$(  x3474.LiquidNo)
    x3474.LiquidSeq = trim$(  x3474.LiquidSeq)
    x3474.CheckKindMain = trim$(  x3474.CheckKindMain)
    x3474.TradingCode = trim$(  x3474.TradingCode)
    x3474.GrossUsage = trim$(  x3474.GrossUsage)
    x3474.QtyOrder = trim$(  x3474.QtyOrder)
    x3474.QtyDemand = trim$(  x3474.QtyDemand)
    x3474.QtyInbound = trim$(  x3474.QtyInbound)
    x3474.InvoinceIn = trim$(  x3474.InvoinceIn)
    x3474.QtyOutbound = trim$(  x3474.QtyOutbound)
    x3474.InvoinceOut = trim$(  x3474.InvoinceOut)
    x3474.Remark = trim$(  x3474.Remark)
    x3474.TimeInsert = trim$(  x3474.TimeInsert)
    x3474.TimeUpdate = trim$(  x3474.TimeUpdate)
    x3474.DateUpdate = trim$(  x3474.DateUpdate)
    x3474.DateInsert = trim$(  x3474.DateInsert)
    x3474.InchargeInsert = trim$(  x3474.InchargeInsert)
    x3474.InchargeUpdate = trim$(  x3474.InchargeUpdate)
     
    If trim$( x3474.Autokey ) = "" Then x3474.Autokey = 0 
    If trim$( x3474.LiquidNo ) = "" Then x3474.LiquidNo = Space(1) 
    If trim$( x3474.LiquidSeq ) = "" Then x3474.LiquidSeq = Space(1) 
    If trim$( x3474.CheckKindMain ) = "" Then x3474.CheckKindMain = Space(1) 
    If trim$( x3474.TradingCode ) = "" Then x3474.TradingCode = Space(1) 
    If trim$( x3474.GrossUsage ) = "" Then x3474.GrossUsage = 0 
    If trim$( x3474.QtyOrder ) = "" Then x3474.QtyOrder = 0 
    If trim$( x3474.QtyDemand ) = "" Then x3474.QtyDemand = 0 
    If trim$( x3474.QtyInbound ) = "" Then x3474.QtyInbound = 0 
    If trim$( x3474.InvoinceIn ) = "" Then x3474.InvoinceIn = Space(1) 
    If trim$( x3474.QtyOutbound ) = "" Then x3474.QtyOutbound = 0 
    If trim$( x3474.InvoinceOut ) = "" Then x3474.InvoinceOut = Space(1) 
    If trim$( x3474.Remark ) = "" Then x3474.Remark = Space(1) 
    If trim$( x3474.TimeInsert ) = "" Then x3474.TimeInsert = Space(1) 
    If trim$( x3474.TimeUpdate ) = "" Then x3474.TimeUpdate = Space(1) 
    If trim$( x3474.DateUpdate ) = "" Then x3474.DateUpdate = Space(1) 
    If trim$( x3474.DateInsert ) = "" Then x3474.DateInsert = Space(1) 
    If trim$( x3474.InchargeInsert ) = "" Then x3474.InchargeInsert = Space(1) 
    If trim$( x3474.InchargeUpdate ) = "" Then x3474.InchargeUpdate = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K3474_MOVE(rs3474 As SqlClient.SqlDataReader)
Try

    call D3474_CLEAR()   

    If IsdbNull(rs3474!K3474_Autokey) = False Then D3474.Autokey = Trim$(rs3474!K3474_Autokey)
    If IsdbNull(rs3474!K3474_LiquidNo) = False Then D3474.LiquidNo = Trim$(rs3474!K3474_LiquidNo)
    If IsdbNull(rs3474!K3474_LiquidSeq) = False Then D3474.LiquidSeq = Trim$(rs3474!K3474_LiquidSeq)
    If IsdbNull(rs3474!K3474_CheckKindMain) = False Then D3474.CheckKindMain = Trim$(rs3474!K3474_CheckKindMain)
    If IsdbNull(rs3474!K3474_TradingCode) = False Then D3474.TradingCode = Trim$(rs3474!K3474_TradingCode)
    If IsdbNull(rs3474!K3474_GrossUsage) = False Then D3474.GrossUsage = Trim$(rs3474!K3474_GrossUsage)
    If IsdbNull(rs3474!K3474_QtyOrder) = False Then D3474.QtyOrder = Trim$(rs3474!K3474_QtyOrder)
    If IsdbNull(rs3474!K3474_QtyDemand) = False Then D3474.QtyDemand = Trim$(rs3474!K3474_QtyDemand)
    If IsdbNull(rs3474!K3474_QtyInbound) = False Then D3474.QtyInbound = Trim$(rs3474!K3474_QtyInbound)
    If IsdbNull(rs3474!K3474_InvoinceIn) = False Then D3474.InvoinceIn = Trim$(rs3474!K3474_InvoinceIn)
    If IsdbNull(rs3474!K3474_QtyOutbound) = False Then D3474.QtyOutbound = Trim$(rs3474!K3474_QtyOutbound)
    If IsdbNull(rs3474!K3474_InvoinceOut) = False Then D3474.InvoinceOut = Trim$(rs3474!K3474_InvoinceOut)
    If IsdbNull(rs3474!K3474_Remark) = False Then D3474.Remark = Trim$(rs3474!K3474_Remark)
    If IsdbNull(rs3474!K3474_TimeInsert) = False Then D3474.TimeInsert = Trim$(rs3474!K3474_TimeInsert)
    If IsdbNull(rs3474!K3474_TimeUpdate) = False Then D3474.TimeUpdate = Trim$(rs3474!K3474_TimeUpdate)
    If IsdbNull(rs3474!K3474_DateUpdate) = False Then D3474.DateUpdate = Trim$(rs3474!K3474_DateUpdate)
    If IsdbNull(rs3474!K3474_DateInsert) = False Then D3474.DateInsert = Trim$(rs3474!K3474_DateInsert)
    If IsdbNull(rs3474!K3474_InchargeInsert) = False Then D3474.InchargeInsert = Trim$(rs3474!K3474_InchargeInsert)
    If IsdbNull(rs3474!K3474_InchargeUpdate) = False Then D3474.InchargeUpdate = Trim$(rs3474!K3474_InchargeUpdate)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3474_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K3474_MOVE(rs3474 As DataRow)
Try

    call D3474_CLEAR()   

    If IsdbNull(rs3474!K3474_Autokey) = False Then D3474.Autokey = Trim$(rs3474!K3474_Autokey)
    If IsdbNull(rs3474!K3474_LiquidNo) = False Then D3474.LiquidNo = Trim$(rs3474!K3474_LiquidNo)
    If IsdbNull(rs3474!K3474_LiquidSeq) = False Then D3474.LiquidSeq = Trim$(rs3474!K3474_LiquidSeq)
    If IsdbNull(rs3474!K3474_CheckKindMain) = False Then D3474.CheckKindMain = Trim$(rs3474!K3474_CheckKindMain)
    If IsdbNull(rs3474!K3474_TradingCode) = False Then D3474.TradingCode = Trim$(rs3474!K3474_TradingCode)
    If IsdbNull(rs3474!K3474_GrossUsage) = False Then D3474.GrossUsage = Trim$(rs3474!K3474_GrossUsage)
    If IsdbNull(rs3474!K3474_QtyOrder) = False Then D3474.QtyOrder = Trim$(rs3474!K3474_QtyOrder)
    If IsdbNull(rs3474!K3474_QtyDemand) = False Then D3474.QtyDemand = Trim$(rs3474!K3474_QtyDemand)
    If IsdbNull(rs3474!K3474_QtyInbound) = False Then D3474.QtyInbound = Trim$(rs3474!K3474_QtyInbound)
    If IsdbNull(rs3474!K3474_InvoinceIn) = False Then D3474.InvoinceIn = Trim$(rs3474!K3474_InvoinceIn)
    If IsdbNull(rs3474!K3474_QtyOutbound) = False Then D3474.QtyOutbound = Trim$(rs3474!K3474_QtyOutbound)
    If IsdbNull(rs3474!K3474_InvoinceOut) = False Then D3474.InvoinceOut = Trim$(rs3474!K3474_InvoinceOut)
    If IsdbNull(rs3474!K3474_Remark) = False Then D3474.Remark = Trim$(rs3474!K3474_Remark)
    If IsdbNull(rs3474!K3474_TimeInsert) = False Then D3474.TimeInsert = Trim$(rs3474!K3474_TimeInsert)
    If IsdbNull(rs3474!K3474_TimeUpdate) = False Then D3474.TimeUpdate = Trim$(rs3474!K3474_TimeUpdate)
    If IsdbNull(rs3474!K3474_DateUpdate) = False Then D3474.DateUpdate = Trim$(rs3474!K3474_DateUpdate)
    If IsdbNull(rs3474!K3474_DateInsert) = False Then D3474.DateInsert = Trim$(rs3474!K3474_DateInsert)
    If IsdbNull(rs3474!K3474_InchargeInsert) = False Then D3474.InchargeInsert = Trim$(rs3474!K3474_InchargeInsert)
    If IsdbNull(rs3474!K3474_InchargeUpdate) = False Then D3474.InchargeUpdate = Trim$(rs3474!K3474_InchargeUpdate)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3474_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K3474_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3474 As T3474_AREA, Job as String, AUTOKEY AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3474_MOVE = False

Try
    If READ_PFK3474(AUTOKEY) = True Then
                z3474 = D3474
		K3474_MOVE = True
		else
	z3474 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3474")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z3474.Autokey = Children(i).Code
   Case "LIQUIDNO":z3474.LiquidNo = Children(i).Code
   Case "LIQUIDSEQ":z3474.LiquidSeq = Children(i).Code
   Case "CHECKKINDMAIN":z3474.CheckKindMain = Children(i).Code
   Case "TRADINGCODE":z3474.TradingCode = Children(i).Code
   Case "GROSSUSAGE":z3474.GrossUsage = Children(i).Code
   Case "QTYORDER":z3474.QtyOrder = Children(i).Code
   Case "QTYDEMAND":z3474.QtyDemand = Children(i).Code
   Case "QTYINBOUND":z3474.QtyInbound = Children(i).Code
   Case "INVOINCEIN":z3474.InvoinceIn = Children(i).Code
   Case "QTYOUTBOUND":z3474.QtyOutbound = Children(i).Code
   Case "INVOINCEOUT":z3474.InvoinceOut = Children(i).Code
   Case "REMARK":z3474.Remark = Children(i).Code
   Case "TIMEINSERT":z3474.TimeInsert = Children(i).Code
   Case "TIMEUPDATE":z3474.TimeUpdate = Children(i).Code
   Case "DATEUPDATE":z3474.DateUpdate = Children(i).Code
   Case "DATEINSERT":z3474.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z3474.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z3474.InchargeUpdate = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z3474.Autokey = Cdecp(Children(i).Data)
   Case "LIQUIDNO":z3474.LiquidNo = Children(i).Data
   Case "LIQUIDSEQ":z3474.LiquidSeq = Children(i).Data
   Case "CHECKKINDMAIN":z3474.CheckKindMain = Children(i).Data
   Case "TRADINGCODE":z3474.TradingCode = Children(i).Data
   Case "GROSSUSAGE":z3474.GrossUsage = Cdecp(Children(i).Data)
   Case "QTYORDER":z3474.QtyOrder = Cdecp(Children(i).Data)
   Case "QTYDEMAND":z3474.QtyDemand = Cdecp(Children(i).Data)
   Case "QTYINBOUND":z3474.QtyInbound = Cdecp(Children(i).Data)
   Case "INVOINCEIN":z3474.InvoinceIn = Children(i).Data
   Case "QTYOUTBOUND":z3474.QtyOutbound = Cdecp(Children(i).Data)
   Case "INVOINCEOUT":z3474.InvoinceOut = Children(i).Data
   Case "REMARK":z3474.Remark = Children(i).Data
   Case "TIMEINSERT":z3474.TimeInsert = Children(i).Data
   Case "TIMEUPDATE":z3474.TimeUpdate = Children(i).Data
   Case "DATEUPDATE":z3474.DateUpdate = Children(i).Data
   Case "DATEINSERT":z3474.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z3474.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z3474.InchargeUpdate = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3474_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K3474_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3474 As T3474_AREA, Job as String, CheckClear as Boolean, AUTOKEY AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3474_MOVE = False

Try
    If READ_PFK3474(AUTOKEY) = True Then
                z3474 = D3474
		K3474_MOVE = True
		else
	If CheckClear  = True then z3474 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3474")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z3474.Autokey = Children(i).Code
   Case "LIQUIDNO":z3474.LiquidNo = Children(i).Code
   Case "LIQUIDSEQ":z3474.LiquidSeq = Children(i).Code
   Case "CHECKKINDMAIN":z3474.CheckKindMain = Children(i).Code
   Case "TRADINGCODE":z3474.TradingCode = Children(i).Code
   Case "GROSSUSAGE":z3474.GrossUsage = Children(i).Code
   Case "QTYORDER":z3474.QtyOrder = Children(i).Code
   Case "QTYDEMAND":z3474.QtyDemand = Children(i).Code
   Case "QTYINBOUND":z3474.QtyInbound = Children(i).Code
   Case "INVOINCEIN":z3474.InvoinceIn = Children(i).Code
   Case "QTYOUTBOUND":z3474.QtyOutbound = Children(i).Code
   Case "INVOINCEOUT":z3474.InvoinceOut = Children(i).Code
   Case "REMARK":z3474.Remark = Children(i).Code
   Case "TIMEINSERT":z3474.TimeInsert = Children(i).Code
   Case "TIMEUPDATE":z3474.TimeUpdate = Children(i).Code
   Case "DATEUPDATE":z3474.DateUpdate = Children(i).Code
   Case "DATEINSERT":z3474.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z3474.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z3474.InchargeUpdate = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z3474.Autokey = Cdecp(Children(i).Data)
   Case "LIQUIDNO":z3474.LiquidNo = Children(i).Data
   Case "LIQUIDSEQ":z3474.LiquidSeq = Children(i).Data
   Case "CHECKKINDMAIN":z3474.CheckKindMain = Children(i).Data
   Case "TRADINGCODE":z3474.TradingCode = Children(i).Data
   Case "GROSSUSAGE":z3474.GrossUsage = Cdecp(Children(i).Data)
   Case "QTYORDER":z3474.QtyOrder = Cdecp(Children(i).Data)
   Case "QTYDEMAND":z3474.QtyDemand = Cdecp(Children(i).Data)
   Case "QTYINBOUND":z3474.QtyInbound = Cdecp(Children(i).Data)
   Case "INVOINCEIN":z3474.InvoinceIn = Children(i).Data
   Case "QTYOUTBOUND":z3474.QtyOutbound = Cdecp(Children(i).Data)
   Case "INVOINCEOUT":z3474.InvoinceOut = Children(i).Data
   Case "REMARK":z3474.Remark = Children(i).Data
   Case "TIMEINSERT":z3474.TimeInsert = Children(i).Data
   Case "TIMEUPDATE":z3474.TimeUpdate = Children(i).Data
   Case "DATEUPDATE":z3474.DateUpdate = Children(i).Data
   Case "DATEINSERT":z3474.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z3474.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z3474.InchargeUpdate = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3474_MOVE",vbCritical)
End Try
End Function 
    

'=========================================================================================================================================================
' DATA MOVE FORM NEW AREA
'=========================================================================================================================================================
Public Sub K3474_MOVE(ByRef a3474 As T3474_AREA, ByRef b3474 As T3474_AREA) 
Try
If trim$( a3474.Autokey ) = "" Then b3474.Autokey = ""  Else b3474.Autokey=a3474.Autokey
If trim$( a3474.LiquidNo ) = "" Then b3474.LiquidNo = ""  Else b3474.LiquidNo=a3474.LiquidNo
If trim$( a3474.LiquidSeq ) = "" Then b3474.LiquidSeq = ""  Else b3474.LiquidSeq=a3474.LiquidSeq
If trim$( a3474.CheckKindMain ) = "" Then b3474.CheckKindMain = ""  Else b3474.CheckKindMain=a3474.CheckKindMain
If trim$( a3474.TradingCode ) = "" Then b3474.TradingCode = ""  Else b3474.TradingCode=a3474.TradingCode
If trim$( a3474.GrossUsage ) = "" Then b3474.GrossUsage = ""  Else b3474.GrossUsage=a3474.GrossUsage
If trim$( a3474.QtyOrder ) = "" Then b3474.QtyOrder = ""  Else b3474.QtyOrder=a3474.QtyOrder
If trim$( a3474.QtyDemand ) = "" Then b3474.QtyDemand = ""  Else b3474.QtyDemand=a3474.QtyDemand
If trim$( a3474.QtyInbound ) = "" Then b3474.QtyInbound = ""  Else b3474.QtyInbound=a3474.QtyInbound
If trim$( a3474.InvoinceIn ) = "" Then b3474.InvoinceIn = ""  Else b3474.InvoinceIn=a3474.InvoinceIn
If trim$( a3474.QtyOutbound ) = "" Then b3474.QtyOutbound = ""  Else b3474.QtyOutbound=a3474.QtyOutbound
If trim$( a3474.InvoinceOut ) = "" Then b3474.InvoinceOut = ""  Else b3474.InvoinceOut=a3474.InvoinceOut
If trim$( a3474.Remark ) = "" Then b3474.Remark = ""  Else b3474.Remark=a3474.Remark
If trim$( a3474.TimeInsert ) = "" Then b3474.TimeInsert = ""  Else b3474.TimeInsert=a3474.TimeInsert
If trim$( a3474.TimeUpdate ) = "" Then b3474.TimeUpdate = ""  Else b3474.TimeUpdate=a3474.TimeUpdate
If trim$( a3474.DateUpdate ) = "" Then b3474.DateUpdate = ""  Else b3474.DateUpdate=a3474.DateUpdate
If trim$( a3474.DateInsert ) = "" Then b3474.DateInsert = ""  Else b3474.DateInsert=a3474.DateInsert
If trim$( a3474.InchargeInsert ) = "" Then b3474.InchargeInsert = ""  Else b3474.InchargeInsert=a3474.InchargeInsert
If trim$( a3474.InchargeUpdate ) = "" Then b3474.InchargeUpdate = ""  Else b3474.InchargeUpdate=a3474.InchargeUpdate
Catch ex As Exception
      Call MsgBoxP("K3474_MOVE",vbCritical)
End Try
End Sub 


End Module 
