'=========================================================================================================================================================
'   TABLE : (PFK7574)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7574

Structure T7574_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	DevelopmentCode	 AS String	'			nvarchar(5)		*
Public 	AccountCode	 AS String	'			nvarchar(15)		*
Public 	DateClosing	 AS String	'			char(8)		*
Public 	DateCreate	 AS String	'			char(8)
Public 	PurchaseAmountVND	 AS Double	'			decimal
Public 	PaidAmountVND	 AS Double	'			decimal
Public 	PurchaseAmountUSD	 AS Double	'			decimal
Public 	PaidAmountUSD	 AS Double	'			decimal
Public 	Check1	 AS String	'			char(1)
Public 	Check2	 AS String	'			char(1)
Public 	Check3	 AS String	'			char(1)
Public 	Check4	 AS String	'			char(1)
Public 	Check5	 AS String	'			char(1)
Public 	Remark	 AS String	'			nvarchar(300)
'=========================================================================================================================================================
End structure

Public D7574 As T7574_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7574(DEVELOPMENTCODE AS String, ACCOUNTCODE AS String, DATECLOSING AS String) As Boolean
    READ_PFK7574 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7574 "
    SQL = SQL & " WHERE K7574_DevelopmentCode		 = '" & DevelopmentCode & "' " 
    SQL = SQL & "   AND K7574_AccountCode		 = '" & AccountCode & "' " 
    SQL = SQL & "   AND K7574_DateClosing		 = '" & DateClosing & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7574_CLEAR: GoTo SKIP_READ_PFK7574
                
    Call K7574_MOVE(rd)
    READ_PFK7574 = True

SKIP_READ_PFK7574:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7574",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7574(DEVELOPMENTCODE AS String, ACCOUNTCODE AS String, DATECLOSING AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7574 "
    SQL = SQL & " WHERE K7574_DevelopmentCode		 = '" & DevelopmentCode & "' " 
    SQL = SQL & "   AND K7574_AccountCode		 = '" & AccountCode & "' " 
    SQL = SQL & "   AND K7574_DateClosing		 = '" & DateClosing & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7574",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7574(z7574 As T7574_AREA) As Boolean
    WRITE_PFK7574 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7574)
 
    SQL = " INSERT INTO PFK7574 "
    SQL = SQL & " ( "
    SQL = SQL & " K7574_DevelopmentCode," 
    SQL = SQL & " K7574_AccountCode," 
    SQL = SQL & " K7574_DateClosing," 
    SQL = SQL & " K7574_DateCreate," 
    SQL = SQL & " K7574_PurchaseAmountVND," 
    SQL = SQL & " K7574_PaidAmountVND," 
    SQL = SQL & " K7574_PurchaseAmountUSD," 
    SQL = SQL & " K7574_PaidAmountUSD," 
    SQL = SQL & " K7574_Check1," 
    SQL = SQL & " K7574_Check2," 
    SQL = SQL & " K7574_Check3," 
    SQL = SQL & " K7574_Check4," 
    SQL = SQL & " K7574_Check5," 
    SQL = SQL & " K7574_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & z7574.DevelopmentCode & "', "  
    SQL = SQL & "  N'" & z7574.AccountCode & "', "  
    SQL = SQL & "  N'" & z7574.DateClosing & "', "  
    SQL = SQL & "  N'" & z7574.DateCreate & "', "  
    SQL = SQL & "   " & z7574.PurchaseAmountVND & ", "  
    SQL = SQL & "   " & z7574.PaidAmountVND & ", "  
    SQL = SQL & "   " & z7574.PurchaseAmountUSD & ", "  
    SQL = SQL & "   " & z7574.PaidAmountUSD & ", "  
    SQL = SQL & "  N'" & z7574.Check1 & "', "  
    SQL = SQL & "  N'" & z7574.Check2 & "', "  
    SQL = SQL & "  N'" & z7574.Check3 & "', "  
    SQL = SQL & "  N'" & z7574.Check4 & "', "  
    SQL = SQL & "  N'" & z7574.Check5 & "', "  
    SQL = SQL & "  N'" & z7574.Remark & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7574 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7574",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7574(z7574 As T7574_AREA) As Boolean
    REWRITE_PFK7574 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7574)
   
    SQL = " UPDATE PFK7574 SET "
    SQL = SQL & "    K7574_DateCreate      = N'" & z7574.DateCreate & "', " 
    SQL = SQL & "    K7574_PurchaseAmountVND      =  " & z7574.PurchaseAmountVND & ", " 
    SQL = SQL & "    K7574_PaidAmountVND      =  " & z7574.PaidAmountVND & ", " 
    SQL = SQL & "    K7574_PurchaseAmountUSD      =  " & z7574.PurchaseAmountUSD & ", " 
    SQL = SQL & "    K7574_PaidAmountUSD      =  " & z7574.PaidAmountUSD & ", " 
    SQL = SQL & "    K7574_Check1      = N'" & z7574.Check1 & "', " 
    SQL = SQL & "    K7574_Check2      = N'" & z7574.Check2 & "', " 
    SQL = SQL & "    K7574_Check3      = N'" & z7574.Check3 & "', " 
    SQL = SQL & "    K7574_Check4      = N'" & z7574.Check4 & "', " 
    SQL = SQL & "    K7574_Check5      = N'" & z7574.Check5 & "', " 
    SQL = SQL & "    K7574_Remark      = N'" & z7574.Remark & "'  " 
    SQL = SQL & " WHERE K7574_DevelopmentCode		 = '" & z7574.DevelopmentCode & "' " 
    SQL = SQL & "   AND K7574_AccountCode		 = '" & z7574.AccountCode & "' " 
    SQL = SQL & "   AND K7574_DateClosing		 = '" & z7574.DateClosing & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7574 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7574",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7574(z7574 As T7574_AREA) As Boolean
    DELETE_PFK7574 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7574 "
    SQL = SQL & " WHERE K7574_DevelopmentCode		 = '" & z7574.DevelopmentCode & "' " 
    SQL = SQL & "   AND K7574_AccountCode		 = '" & z7574.AccountCode & "' " 
    SQL = SQL & "   AND K7574_DateClosing		 = '" & z7574.DateClosing & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7574 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7574",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7574_CLEAR()
Try
    
   D7574.DevelopmentCode = ""
   D7574.AccountCode = ""
   D7574.DateClosing = ""
   D7574.DateCreate = ""
    D7574.PurchaseAmountVND = 0 
    D7574.PaidAmountVND = 0 
    D7574.PurchaseAmountUSD = 0 
    D7574.PaidAmountUSD = 0 
   D7574.Check1 = ""
   D7574.Check2 = ""
   D7574.Check3 = ""
   D7574.Check4 = ""
   D7574.Check5 = ""
   D7574.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7574_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7574 As T7574_AREA)
Try
    
    x7574.DevelopmentCode = trim$(  x7574.DevelopmentCode)
    x7574.AccountCode = trim$(  x7574.AccountCode)
    x7574.DateClosing = trim$(  x7574.DateClosing)
    x7574.DateCreate = trim$(  x7574.DateCreate)
    x7574.PurchaseAmountVND = trim$(  x7574.PurchaseAmountVND)
    x7574.PaidAmountVND = trim$(  x7574.PaidAmountVND)
    x7574.PurchaseAmountUSD = trim$(  x7574.PurchaseAmountUSD)
    x7574.PaidAmountUSD = trim$(  x7574.PaidAmountUSD)
    x7574.Check1 = trim$(  x7574.Check1)
    x7574.Check2 = trim$(  x7574.Check2)
    x7574.Check3 = trim$(  x7574.Check3)
    x7574.Check4 = trim$(  x7574.Check4)
    x7574.Check5 = trim$(  x7574.Check5)
    x7574.Remark = trim$(  x7574.Remark)
     
    If trim$( x7574.DevelopmentCode ) = "" Then x7574.DevelopmentCode = Space(1) 
    If trim$( x7574.AccountCode ) = "" Then x7574.AccountCode = Space(1) 
    If trim$( x7574.DateClosing ) = "" Then x7574.DateClosing = Space(1) 
    If trim$( x7574.DateCreate ) = "" Then x7574.DateCreate = Space(1) 
    If trim$( x7574.PurchaseAmountVND ) = "" Then x7574.PurchaseAmountVND = 0 
    If trim$( x7574.PaidAmountVND ) = "" Then x7574.PaidAmountVND = 0 
    If trim$( x7574.PurchaseAmountUSD ) = "" Then x7574.PurchaseAmountUSD = 0 
    If trim$( x7574.PaidAmountUSD ) = "" Then x7574.PaidAmountUSD = 0 
    If trim$( x7574.Check1 ) = "" Then x7574.Check1 = Space(1) 
    If trim$( x7574.Check2 ) = "" Then x7574.Check2 = Space(1) 
    If trim$( x7574.Check3 ) = "" Then x7574.Check3 = Space(1) 
    If trim$( x7574.Check4 ) = "" Then x7574.Check4 = Space(1) 
    If trim$( x7574.Check5 ) = "" Then x7574.Check5 = Space(1) 
    If trim$( x7574.Remark ) = "" Then x7574.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7574_MOVE(rs7574 As SqlClient.SqlDataReader)
Try

    call D7574_CLEAR()   

    If IsdbNull(rs7574!K7574_DevelopmentCode) = False Then D7574.DevelopmentCode = Trim$(rs7574!K7574_DevelopmentCode)
    If IsdbNull(rs7574!K7574_AccountCode) = False Then D7574.AccountCode = Trim$(rs7574!K7574_AccountCode)
    If IsdbNull(rs7574!K7574_DateClosing) = False Then D7574.DateClosing = Trim$(rs7574!K7574_DateClosing)
    If IsdbNull(rs7574!K7574_DateCreate) = False Then D7574.DateCreate = Trim$(rs7574!K7574_DateCreate)
    If IsdbNull(rs7574!K7574_PurchaseAmountVND) = False Then D7574.PurchaseAmountVND = Trim$(rs7574!K7574_PurchaseAmountVND)
    If IsdbNull(rs7574!K7574_PaidAmountVND) = False Then D7574.PaidAmountVND = Trim$(rs7574!K7574_PaidAmountVND)
    If IsdbNull(rs7574!K7574_PurchaseAmountUSD) = False Then D7574.PurchaseAmountUSD = Trim$(rs7574!K7574_PurchaseAmountUSD)
    If IsdbNull(rs7574!K7574_PaidAmountUSD) = False Then D7574.PaidAmountUSD = Trim$(rs7574!K7574_PaidAmountUSD)
    If IsdbNull(rs7574!K7574_Check1) = False Then D7574.Check1 = Trim$(rs7574!K7574_Check1)
    If IsdbNull(rs7574!K7574_Check2) = False Then D7574.Check2 = Trim$(rs7574!K7574_Check2)
    If IsdbNull(rs7574!K7574_Check3) = False Then D7574.Check3 = Trim$(rs7574!K7574_Check3)
    If IsdbNull(rs7574!K7574_Check4) = False Then D7574.Check4 = Trim$(rs7574!K7574_Check4)
    If IsdbNull(rs7574!K7574_Check5) = False Then D7574.Check5 = Trim$(rs7574!K7574_Check5)
    If IsdbNull(rs7574!K7574_Remark) = False Then D7574.Remark = Trim$(rs7574!K7574_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7574_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7574_MOVE(rs7574 As DataRow)
Try

    call D7574_CLEAR()   

    If IsdbNull(rs7574!K7574_DevelopmentCode) = False Then D7574.DevelopmentCode = Trim$(rs7574!K7574_DevelopmentCode)
    If IsdbNull(rs7574!K7574_AccountCode) = False Then D7574.AccountCode = Trim$(rs7574!K7574_AccountCode)
    If IsdbNull(rs7574!K7574_DateClosing) = False Then D7574.DateClosing = Trim$(rs7574!K7574_DateClosing)
    If IsdbNull(rs7574!K7574_DateCreate) = False Then D7574.DateCreate = Trim$(rs7574!K7574_DateCreate)
    If IsdbNull(rs7574!K7574_PurchaseAmountVND) = False Then D7574.PurchaseAmountVND = Trim$(rs7574!K7574_PurchaseAmountVND)
    If IsdbNull(rs7574!K7574_PaidAmountVND) = False Then D7574.PaidAmountVND = Trim$(rs7574!K7574_PaidAmountVND)
    If IsdbNull(rs7574!K7574_PurchaseAmountUSD) = False Then D7574.PurchaseAmountUSD = Trim$(rs7574!K7574_PurchaseAmountUSD)
    If IsdbNull(rs7574!K7574_PaidAmountUSD) = False Then D7574.PaidAmountUSD = Trim$(rs7574!K7574_PaidAmountUSD)
    If IsdbNull(rs7574!K7574_Check1) = False Then D7574.Check1 = Trim$(rs7574!K7574_Check1)
    If IsdbNull(rs7574!K7574_Check2) = False Then D7574.Check2 = Trim$(rs7574!K7574_Check2)
    If IsdbNull(rs7574!K7574_Check3) = False Then D7574.Check3 = Trim$(rs7574!K7574_Check3)
    If IsdbNull(rs7574!K7574_Check4) = False Then D7574.Check4 = Trim$(rs7574!K7574_Check4)
    If IsdbNull(rs7574!K7574_Check5) = False Then D7574.Check5 = Trim$(rs7574!K7574_Check5)
    If IsdbNull(rs7574!K7574_Remark) = False Then D7574.Remark = Trim$(rs7574!K7574_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7574_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7574_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7574 As T7574_AREA,DEVELOPMENTCODE AS String, ACCOUNTCODE AS String, DATECLOSING AS String) as Boolean

K7574_MOVE = False

Try
    If READ_PFK7574(DEVELOPMENTCODE, ACCOUNTCODE, DATECLOSING) = True Then
                z7574 = D7574
		K7574_MOVE = True
		else
		 z7574 = nothing
     End If

     If  getColumIndex(spr,"DevelopmentCode") > -1 then z7574.DevelopmentCode = getDataM(spr, getColumIndex(spr,"DevelopmentCode"), xRow)
     If  getColumIndex(spr,"AccountCode") > -1 then z7574.AccountCode = getDataM(spr, getColumIndex(spr,"AccountCode"), xRow)
     If  getColumIndex(spr,"DateClosing") > -1 then z7574.DateClosing = getDataM(spr, getColumIndex(spr,"DateClosing"), xRow)
     If  getColumIndex(spr,"DateCreate") > -1 then z7574.DateCreate = getDataM(spr, getColumIndex(spr,"DateCreate"), xRow)
     If  getColumIndex(spr,"PurchaseAmountVND") > -1 then z7574.PurchaseAmountVND = getDataM(spr, getColumIndex(spr,"PurchaseAmountVND"), xRow)
     If  getColumIndex(spr,"PaidAmountVND") > -1 then z7574.PaidAmountVND = getDataM(spr, getColumIndex(spr,"PaidAmountVND"), xRow)
     If  getColumIndex(spr,"PurchaseAmountUSD") > -1 then z7574.PurchaseAmountUSD = getDataM(spr, getColumIndex(spr,"PurchaseAmountUSD"), xRow)
     If  getColumIndex(spr,"PaidAmountUSD") > -1 then z7574.PaidAmountUSD = getDataM(spr, getColumIndex(spr,"PaidAmountUSD"), xRow)
     If  getColumIndex(spr,"Check1") > -1 then z7574.Check1 = getDataM(spr, getColumIndex(spr,"Check1"), xRow)
     If  getColumIndex(spr,"Check2") > -1 then z7574.Check2 = getDataM(spr, getColumIndex(spr,"Check2"), xRow)
     If  getColumIndex(spr,"Check3") > -1 then z7574.Check3 = getDataM(spr, getColumIndex(spr,"Check3"), xRow)
     If  getColumIndex(spr,"Check4") > -1 then z7574.Check4 = getDataM(spr, getColumIndex(spr,"Check4"), xRow)
     If  getColumIndex(spr,"Check5") > -1 then z7574.Check5 = getDataM(spr, getColumIndex(spr,"Check5"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7574.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7574_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7574_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7574 As T7574_AREA, Job as String,DEVELOPMENTCODE AS String, ACCOUNTCODE AS String, DATECLOSING AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7574_MOVE = False

Try
    If READ_PFK7574(DEVELOPMENTCODE, ACCOUNTCODE, DATECLOSING) = True Then
                z7574 = D7574
		K7574_MOVE = True
		else
		 z7574 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7574")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "DevelopmentCode":z7574.DevelopmentCode = Children(i).Code
   Case "AccountCode":z7574.AccountCode = Children(i).Code
   Case "DateClosing":z7574.DateClosing = Children(i).Code
   Case "DateCreate":z7574.DateCreate = Children(i).Code
   Case "PurchaseAmountVND":z7574.PurchaseAmountVND = Children(i).Code
   Case "PaidAmountVND":z7574.PaidAmountVND = Children(i).Code
   Case "PurchaseAmountUSD":z7574.PurchaseAmountUSD = Children(i).Code
   Case "PaidAmountUSD":z7574.PaidAmountUSD = Children(i).Code
   Case "Check1":z7574.Check1 = Children(i).Code
   Case "Check2":z7574.Check2 = Children(i).Code
   Case "Check3":z7574.Check3 = Children(i).Code
   Case "Check4":z7574.Check4 = Children(i).Code
   Case "Check5":z7574.Check5 = Children(i).Code
   Case "Remark":z7574.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "DevelopmentCode":z7574.DevelopmentCode = Children(i).Data
   Case "AccountCode":z7574.AccountCode = Children(i).Data
   Case "DateClosing":z7574.DateClosing = Children(i).Data
   Case "DateCreate":z7574.DateCreate = Children(i).Data
   Case "PurchaseAmountVND":z7574.PurchaseAmountVND = Children(i).Data
   Case "PaidAmountVND":z7574.PaidAmountVND = Children(i).Data
   Case "PurchaseAmountUSD":z7574.PurchaseAmountUSD = Children(i).Data
   Case "PaidAmountUSD":z7574.PaidAmountUSD = Children(i).Data
   Case "Check1":z7574.Check1 = Children(i).Data
   Case "Check2":z7574.Check2 = Children(i).Data
   Case "Check3":z7574.Check3 = Children(i).Data
   Case "Check4":z7574.Check4 = Children(i).Data
   Case "Check5":z7574.Check5 = Children(i).Data
   Case "Remark":z7574.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7574_MOVE",vbCritical)
End Try
End Function 
    
End Module 
