'=========================================================================================================================================================
'   TABLE : (PFK7102)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7102

Structure T7102_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	BankCode	 AS String	'			char(6)		*
Public 	CustomerCode	 AS String	'			char(6)
Public 	cdBank	 AS String	'			char(3)
Public 	NameBank	 AS String	'			nchar(50)
Public 	AccountBankVND	 AS String	'			nvarchar(20)
Public 	AccountBankUSD	 AS String	'			nvarchar(20)
Public 	DebitAmountVND	 AS Double	'			decimal
Public 	DebitAmountUSD	 AS Double	'			decimal
Public 	CreditAmountVND	 AS Double	'			decimal
Public 	CreditAmountUSD	 AS Double	'			decimal
Public 	StatementStatus	 AS String	'			char(1)
Public 	UseCheck	 AS String	'			char(1)
Public 	KindCustomer	 AS String	'			char(1)
Public 	VinaCode	 AS String	'			nvarchar(20)
Public 	Remark	 AS String	'			nvarchar(200)
'=========================================================================================================================================================
End structure

Public D7102 As T7102_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7102(BANKCODE AS String) As Boolean
    READ_PFK7102 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7102 "
    SQL = SQL & " WHERE K7102_BankCode		 = '" & BankCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7102_CLEAR: GoTo SKIP_READ_PFK7102
                
    Call K7102_MOVE(rd)
    READ_PFK7102 = True

SKIP_READ_PFK7102:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7102",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7102(BANKCODE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7102 "
    SQL = SQL & " WHERE K7102_BankCode		 = '" & BankCode & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7102",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7102(z7102 As T7102_AREA) As Boolean
    WRITE_PFK7102 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7102)
 
    SQL = " INSERT INTO PFK7102 "
    SQL = SQL & " ( "
    SQL = SQL & " K7102_BankCode," 
    SQL = SQL & " K7102_CustomerCode," 
    SQL = SQL & " K7102_cdBank," 
    SQL = SQL & " K7102_NameBank," 
    SQL = SQL & " K7102_AccountBankVND," 
    SQL = SQL & " K7102_AccountBankUSD," 
    SQL = SQL & " K7102_DebitAmountVND," 
    SQL = SQL & " K7102_DebitAmountUSD," 
    SQL = SQL & " K7102_CreditAmountVND," 
    SQL = SQL & " K7102_CreditAmountUSD," 
    SQL = SQL & " K7102_StatementStatus," 
    SQL = SQL & " K7102_UseCheck," 
    SQL = SQL & " K7102_KindCustomer," 
    SQL = SQL & " K7102_VinaCode," 
    SQL = SQL & " K7102_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & z7102.BankCode & "', "  
    SQL = SQL & "  N'" & z7102.CustomerCode & "', "  
    SQL = SQL & "  N'" & z7102.cdBank & "', "  
    SQL = SQL & "  N'" & z7102.NameBank & "', "  
    SQL = SQL & "  N'" & z7102.AccountBankVND & "', "  
    SQL = SQL & "  N'" & z7102.AccountBankUSD & "', "  
    SQL = SQL & "   " & z7102.DebitAmountVND & ", "  
    SQL = SQL & "   " & z7102.DebitAmountUSD & ", "  
    SQL = SQL & "   " & z7102.CreditAmountVND & ", "  
    SQL = SQL & "   " & z7102.CreditAmountUSD & ", "  
    SQL = SQL & "  N'" & z7102.StatementStatus & "', "  
    SQL = SQL & "  N'" & z7102.UseCheck & "', "  
    SQL = SQL & "  N'" & z7102.KindCustomer & "', "  
    SQL = SQL & "  N'" & z7102.VinaCode & "', "  
    SQL = SQL & "  N'" & z7102.Remark & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7102 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7102",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7102(z7102 As T7102_AREA) As Boolean
    REWRITE_PFK7102 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7102)
   
    SQL = " UPDATE PFK7102 SET "
    SQL = SQL & "    K7102_CustomerCode      = N'" & z7102.CustomerCode & "', " 
    SQL = SQL & "    K7102_cdBank      = N'" & z7102.cdBank & "', " 
    SQL = SQL & "    K7102_NameBank      = N'" & z7102.NameBank & "', " 
    SQL = SQL & "    K7102_AccountBankVND      = N'" & z7102.AccountBankVND & "', " 
    SQL = SQL & "    K7102_AccountBankUSD      = N'" & z7102.AccountBankUSD & "', " 
    SQL = SQL & "    K7102_DebitAmountVND      =  " & z7102.DebitAmountVND & ", " 
    SQL = SQL & "    K7102_DebitAmountUSD      =  " & z7102.DebitAmountUSD & ", " 
    SQL = SQL & "    K7102_CreditAmountVND      =  " & z7102.CreditAmountVND & ", " 
    SQL = SQL & "    K7102_CreditAmountUSD      =  " & z7102.CreditAmountUSD & ", " 
    SQL = SQL & "    K7102_StatementStatus      = N'" & z7102.StatementStatus & "', " 
    SQL = SQL & "    K7102_UseCheck      = N'" & z7102.UseCheck & "', " 
    SQL = SQL & "    K7102_KindCustomer      = N'" & z7102.KindCustomer & "', " 
    SQL = SQL & "    K7102_VinaCode      = N'" & z7102.VinaCode & "', " 
    SQL = SQL & "    K7102_Remark      = N'" & z7102.Remark & "'  " 
    SQL = SQL & " WHERE K7102_BankCode		 = '" & z7102.BankCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7102 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7102",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7102(z7102 As T7102_AREA) As Boolean
    DELETE_PFK7102 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7102 "
    SQL = SQL & " WHERE K7102_BankCode		 = '" & z7102.BankCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7102 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7102",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7102_CLEAR()
Try
    
   D7102.BankCode = ""
   D7102.CustomerCode = ""
   D7102.cdBank = ""
   D7102.NameBank = ""
   D7102.AccountBankVND = ""
   D7102.AccountBankUSD = ""
    D7102.DebitAmountVND = 0 
    D7102.DebitAmountUSD = 0 
    D7102.CreditAmountVND = 0 
    D7102.CreditAmountUSD = 0 
   D7102.StatementStatus = ""
   D7102.UseCheck = ""
   D7102.KindCustomer = ""
   D7102.VinaCode = ""
   D7102.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7102_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7102 As T7102_AREA)
Try
    
    x7102.BankCode = trim$(  x7102.BankCode)
    x7102.CustomerCode = trim$(  x7102.CustomerCode)
    x7102.cdBank = trim$(  x7102.cdBank)
    x7102.NameBank = trim$(  x7102.NameBank)
    x7102.AccountBankVND = trim$(  x7102.AccountBankVND)
    x7102.AccountBankUSD = trim$(  x7102.AccountBankUSD)
    x7102.DebitAmountVND = trim$(  x7102.DebitAmountVND)
    x7102.DebitAmountUSD = trim$(  x7102.DebitAmountUSD)
    x7102.CreditAmountVND = trim$(  x7102.CreditAmountVND)
    x7102.CreditAmountUSD = trim$(  x7102.CreditAmountUSD)
    x7102.StatementStatus = trim$(  x7102.StatementStatus)
    x7102.UseCheck = trim$(  x7102.UseCheck)
    x7102.KindCustomer = trim$(  x7102.KindCustomer)
    x7102.VinaCode = trim$(  x7102.VinaCode)
    x7102.Remark = trim$(  x7102.Remark)
     
    If trim$( x7102.BankCode ) = "" Then x7102.BankCode = Space(1) 
    If trim$( x7102.CustomerCode ) = "" Then x7102.CustomerCode = Space(1) 
    If trim$( x7102.cdBank ) = "" Then x7102.cdBank = Space(1) 
    If trim$( x7102.NameBank ) = "" Then x7102.NameBank = Space(1) 
    If trim$( x7102.AccountBankVND ) = "" Then x7102.AccountBankVND = Space(1) 
    If trim$( x7102.AccountBankUSD ) = "" Then x7102.AccountBankUSD = Space(1) 
    If trim$( x7102.DebitAmountVND ) = "" Then x7102.DebitAmountVND = 0 
    If trim$( x7102.DebitAmountUSD ) = "" Then x7102.DebitAmountUSD = 0 
    If trim$( x7102.CreditAmountVND ) = "" Then x7102.CreditAmountVND = 0 
    If trim$( x7102.CreditAmountUSD ) = "" Then x7102.CreditAmountUSD = 0 
    If trim$( x7102.StatementStatus ) = "" Then x7102.StatementStatus = Space(1) 
    If trim$( x7102.UseCheck ) = "" Then x7102.UseCheck = Space(1) 
    If trim$( x7102.KindCustomer ) = "" Then x7102.KindCustomer = Space(1) 
    If trim$( x7102.VinaCode ) = "" Then x7102.VinaCode = Space(1) 
    If trim$( x7102.Remark ) = "" Then x7102.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7102_MOVE(rs7102 As SqlClient.SqlDataReader)
Try

    call D7102_CLEAR()   

    If IsdbNull(rs7102!K7102_BankCode) = False Then D7102.BankCode = Trim$(rs7102!K7102_BankCode)
    If IsdbNull(rs7102!K7102_CustomerCode) = False Then D7102.CustomerCode = Trim$(rs7102!K7102_CustomerCode)
    If IsdbNull(rs7102!K7102_cdBank) = False Then D7102.cdBank = Trim$(rs7102!K7102_cdBank)
    If IsdbNull(rs7102!K7102_NameBank) = False Then D7102.NameBank = Trim$(rs7102!K7102_NameBank)
    If IsdbNull(rs7102!K7102_AccountBankVND) = False Then D7102.AccountBankVND = Trim$(rs7102!K7102_AccountBankVND)
    If IsdbNull(rs7102!K7102_AccountBankUSD) = False Then D7102.AccountBankUSD = Trim$(rs7102!K7102_AccountBankUSD)
    If IsdbNull(rs7102!K7102_DebitAmountVND) = False Then D7102.DebitAmountVND = Trim$(rs7102!K7102_DebitAmountVND)
    If IsdbNull(rs7102!K7102_DebitAmountUSD) = False Then D7102.DebitAmountUSD = Trim$(rs7102!K7102_DebitAmountUSD)
    If IsdbNull(rs7102!K7102_CreditAmountVND) = False Then D7102.CreditAmountVND = Trim$(rs7102!K7102_CreditAmountVND)
    If IsdbNull(rs7102!K7102_CreditAmountUSD) = False Then D7102.CreditAmountUSD = Trim$(rs7102!K7102_CreditAmountUSD)
    If IsdbNull(rs7102!K7102_StatementStatus) = False Then D7102.StatementStatus = Trim$(rs7102!K7102_StatementStatus)
    If IsdbNull(rs7102!K7102_UseCheck) = False Then D7102.UseCheck = Trim$(rs7102!K7102_UseCheck)
    If IsdbNull(rs7102!K7102_KindCustomer) = False Then D7102.KindCustomer = Trim$(rs7102!K7102_KindCustomer)
    If IsdbNull(rs7102!K7102_VinaCode) = False Then D7102.VinaCode = Trim$(rs7102!K7102_VinaCode)
    If IsdbNull(rs7102!K7102_Remark) = False Then D7102.Remark = Trim$(rs7102!K7102_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7102_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7102_MOVE(rs7102 As DataRow)
Try

    call D7102_CLEAR()   

    If IsdbNull(rs7102!K7102_BankCode) = False Then D7102.BankCode = Trim$(rs7102!K7102_BankCode)
    If IsdbNull(rs7102!K7102_CustomerCode) = False Then D7102.CustomerCode = Trim$(rs7102!K7102_CustomerCode)
    If IsdbNull(rs7102!K7102_cdBank) = False Then D7102.cdBank = Trim$(rs7102!K7102_cdBank)
    If IsdbNull(rs7102!K7102_NameBank) = False Then D7102.NameBank = Trim$(rs7102!K7102_NameBank)
    If IsdbNull(rs7102!K7102_AccountBankVND) = False Then D7102.AccountBankVND = Trim$(rs7102!K7102_AccountBankVND)
    If IsdbNull(rs7102!K7102_AccountBankUSD) = False Then D7102.AccountBankUSD = Trim$(rs7102!K7102_AccountBankUSD)
    If IsdbNull(rs7102!K7102_DebitAmountVND) = False Then D7102.DebitAmountVND = Trim$(rs7102!K7102_DebitAmountVND)
    If IsdbNull(rs7102!K7102_DebitAmountUSD) = False Then D7102.DebitAmountUSD = Trim$(rs7102!K7102_DebitAmountUSD)
    If IsdbNull(rs7102!K7102_CreditAmountVND) = False Then D7102.CreditAmountVND = Trim$(rs7102!K7102_CreditAmountVND)
    If IsdbNull(rs7102!K7102_CreditAmountUSD) = False Then D7102.CreditAmountUSD = Trim$(rs7102!K7102_CreditAmountUSD)
    If IsdbNull(rs7102!K7102_StatementStatus) = False Then D7102.StatementStatus = Trim$(rs7102!K7102_StatementStatus)
    If IsdbNull(rs7102!K7102_UseCheck) = False Then D7102.UseCheck = Trim$(rs7102!K7102_UseCheck)
    If IsdbNull(rs7102!K7102_KindCustomer) = False Then D7102.KindCustomer = Trim$(rs7102!K7102_KindCustomer)
    If IsdbNull(rs7102!K7102_VinaCode) = False Then D7102.VinaCode = Trim$(rs7102!K7102_VinaCode)
    If IsdbNull(rs7102!K7102_Remark) = False Then D7102.Remark = Trim$(rs7102!K7102_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7102_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7102_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7102 As T7102_AREA,BANKCODE AS String) as Boolean

K7102_MOVE = False

Try
    If READ_PFK7102(BANKCODE) = True Then
                z7102 = D7102
		K7102_MOVE = True
		else
		 z7102 = nothing
     End If

     If  getColumIndex(spr,"BankCode") > -1 then z7102.BankCode = getDataM(spr, getColumIndex(spr,"BankCode"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z7102.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"cdBank") > -1 then z7102.cdBank = getDataM(spr, getColumIndex(spr,"cdBank"), xRow)
     If  getColumIndex(spr,"NameBank") > -1 then z7102.NameBank = getDataM(spr, getColumIndex(spr,"NameBank"), xRow)
     If  getColumIndex(spr,"AccountBankVND") > -1 then z7102.AccountBankVND = getDataM(spr, getColumIndex(spr,"AccountBankVND"), xRow)
     If  getColumIndex(spr,"AccountBankUSD") > -1 then z7102.AccountBankUSD = getDataM(spr, getColumIndex(spr,"AccountBankUSD"), xRow)
     If  getColumIndex(spr,"DebitAmountVND") > -1 then z7102.DebitAmountVND = getDataM(spr, getColumIndex(spr,"DebitAmountVND"), xRow)
     If  getColumIndex(spr,"DebitAmountUSD") > -1 then z7102.DebitAmountUSD = getDataM(spr, getColumIndex(spr,"DebitAmountUSD"), xRow)
     If  getColumIndex(spr,"CreditAmountVND") > -1 then z7102.CreditAmountVND = getDataM(spr, getColumIndex(spr,"CreditAmountVND"), xRow)
     If  getColumIndex(spr,"CreditAmountUSD") > -1 then z7102.CreditAmountUSD = getDataM(spr, getColumIndex(spr,"CreditAmountUSD"), xRow)
     If  getColumIndex(spr,"StatementStatus") > -1 then z7102.StatementStatus = getDataM(spr, getColumIndex(spr,"StatementStatus"), xRow)
     If  getColumIndex(spr,"UseCheck") > -1 then z7102.UseCheck = getDataM(spr, getColumIndex(spr,"UseCheck"), xRow)
     If  getColumIndex(spr,"KindCustomer") > -1 then z7102.KindCustomer = getDataM(spr, getColumIndex(spr,"KindCustomer"), xRow)
     If  getColumIndex(spr,"VinaCode") > -1 then z7102.VinaCode = getDataM(spr, getColumIndex(spr,"VinaCode"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7102.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7102_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7102_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7102 As T7102_AREA, Job as String,BANKCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7102_MOVE = False

Try
    If READ_PFK7102(BANKCODE) = True Then
                z7102 = D7102
		K7102_MOVE = True
		else
		 z7102 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7102")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "BankCode":z7102.BankCode = Children(i).Code
   Case "CustomerCode":z7102.CustomerCode = Children(i).Code
   Case "cdBank":z7102.cdBank = Children(i).Code
   Case "NameBank":z7102.NameBank = Children(i).Code
   Case "AccountBankVND":z7102.AccountBankVND = Children(i).Code
   Case "AccountBankUSD":z7102.AccountBankUSD = Children(i).Code
   Case "DebitAmountVND":z7102.DebitAmountVND = Children(i).Code
   Case "DebitAmountUSD":z7102.DebitAmountUSD = Children(i).Code
   Case "CreditAmountVND":z7102.CreditAmountVND = Children(i).Code
   Case "CreditAmountUSD":z7102.CreditAmountUSD = Children(i).Code
   Case "StatementStatus":z7102.StatementStatus = Children(i).Code
   Case "UseCheck":z7102.UseCheck = Children(i).Code
   Case "KindCustomer":z7102.KindCustomer = Children(i).Code
   Case "VinaCode":z7102.VinaCode = Children(i).Code
   Case "Remark":z7102.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "BankCode":z7102.BankCode = Children(i).Data
   Case "CustomerCode":z7102.CustomerCode = Children(i).Data
   Case "cdBank":z7102.cdBank = Children(i).Data
   Case "NameBank":z7102.NameBank = Children(i).Data
   Case "AccountBankVND":z7102.AccountBankVND = Children(i).Data
   Case "AccountBankUSD":z7102.AccountBankUSD = Children(i).Data
   Case "DebitAmountVND":z7102.DebitAmountVND = Children(i).Data
   Case "DebitAmountUSD":z7102.DebitAmountUSD = Children(i).Data
   Case "CreditAmountVND":z7102.CreditAmountVND = Children(i).Data
   Case "CreditAmountUSD":z7102.CreditAmountUSD = Children(i).Data
   Case "StatementStatus":z7102.StatementStatus = Children(i).Data
   Case "UseCheck":z7102.UseCheck = Children(i).Data
   Case "KindCustomer":z7102.KindCustomer = Children(i).Data
   Case "VinaCode":z7102.VinaCode = Children(i).Data
   Case "Remark":z7102.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7102_MOVE",vbCritical)
End Try
End Function 
    
End Module 
