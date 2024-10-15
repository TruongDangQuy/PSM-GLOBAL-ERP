'=========================================================================================================================================================
'   TABLE : (PFK7174)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7174

Structure T7174_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	DevelopmentCode	 AS String	'			nvarchar(15)		*
Public 	AccountCode	 AS String	'			nvarchar(15)		*
Public 	DateClosing	 AS String	'			char(8)		*
Public 	DateCreate	 AS String	'			char(8)
Public 	DebitAmountVND	 AS Double	'			decimal
Public 	CreditAmountVND	 AS Double	'			decimal
Public 	DebitAmountUSD	 AS Double	'			decimal
Public 	CreditAmountUSD	 AS Double	'			decimal
Public 	Check1	 AS String	'			char(1)
Public 	Check2	 AS String	'			char(1)
Public 	Check3	 AS String	'			char(1)
Public 	Check4	 AS String	'			char(1)
Public 	Check5	 AS String	'			char(1)
Public 	CreatedBy	 AS String	'			varchar(50)
Public 	Remark	 AS String	'			nvarchar(300)
'=========================================================================================================================================================
End structure

Public D7174 As T7174_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7174(DEVELOPMENTCODE AS String, ACCOUNTCODE AS String, DATECLOSING AS String) As Boolean
    READ_PFK7174 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7174 "
    SQL = SQL & " WHERE K7174_DevelopmentCode		 = '" & DevelopmentCode & "' " 
    SQL = SQL & "   AND K7174_AccountCode		 = '" & AccountCode & "' " 
    SQL = SQL & "   AND K7174_DateClosing		 = '" & DateClosing & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7174_CLEAR: GoTo SKIP_READ_PFK7174
                
    Call K7174_MOVE(rd)
    READ_PFK7174 = True

SKIP_READ_PFK7174:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7174",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7174(DEVELOPMENTCODE AS String, ACCOUNTCODE AS String, DATECLOSING AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7174 "
    SQL = SQL & " WHERE K7174_DevelopmentCode		 = '" & DevelopmentCode & "' " 
    SQL = SQL & "   AND K7174_AccountCode		 = '" & AccountCode & "' " 
    SQL = SQL & "   AND K7174_DateClosing		 = '" & DateClosing & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7174",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7174(z7174 As T7174_AREA) As Boolean
    WRITE_PFK7174 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7174)
 
    SQL = " INSERT INTO PFK7174 "
    SQL = SQL & " ( "
    SQL = SQL & " K7174_DevelopmentCode," 
    SQL = SQL & " K7174_AccountCode," 
    SQL = SQL & " K7174_DateClosing," 
    SQL = SQL & " K7174_DateCreate," 
    SQL = SQL & " K7174_DebitAmountVND," 
    SQL = SQL & " K7174_CreditAmountVND," 
    SQL = SQL & " K7174_DebitAmountUSD," 
    SQL = SQL & " K7174_CreditAmountUSD," 
    SQL = SQL & " K7174_Check1," 
    SQL = SQL & " K7174_Check2," 
    SQL = SQL & " K7174_Check3," 
    SQL = SQL & " K7174_Check4," 
    SQL = SQL & " K7174_Check5," 
    SQL = SQL & " K7174_CreatedBy," 
    SQL = SQL & " K7174_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7174.DevelopmentCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7174.AccountCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7174.DateClosing) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7174.DateCreate) & "', "  
    SQL = SQL & "   " & FormatSQL(z7174.DebitAmountVND) & ", "  
    SQL = SQL & "   " & FormatSQL(z7174.CreditAmountVND) & ", "  
    SQL = SQL & "   " & FormatSQL(z7174.DebitAmountUSD) & ", "  
    SQL = SQL & "   " & FormatSQL(z7174.CreditAmountUSD) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7174.Check1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7174.Check2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7174.Check3) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7174.Check4) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7174.Check5) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7174.CreatedBy) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7174.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7174 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7174",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7174(z7174 As T7174_AREA) As Boolean
    REWRITE_PFK7174 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7174)
   
    SQL = " UPDATE PFK7174 SET "
    SQL = SQL & "    K7174_DateCreate      = N'" & FormatSQL(z7174.DateCreate) & "', " 
    SQL = SQL & "    K7174_DebitAmountVND      =  " & FormatSQL(z7174.DebitAmountVND) & ", " 
    SQL = SQL & "    K7174_CreditAmountVND      =  " & FormatSQL(z7174.CreditAmountVND) & ", " 
    SQL = SQL & "    K7174_DebitAmountUSD      =  " & FormatSQL(z7174.DebitAmountUSD) & ", " 
    SQL = SQL & "    K7174_CreditAmountUSD      =  " & FormatSQL(z7174.CreditAmountUSD) & ", " 
    SQL = SQL & "    K7174_Check1      = N'" & FormatSQL(z7174.Check1) & "', " 
    SQL = SQL & "    K7174_Check2      = N'" & FormatSQL(z7174.Check2) & "', " 
    SQL = SQL & "    K7174_Check3      = N'" & FormatSQL(z7174.Check3) & "', " 
    SQL = SQL & "    K7174_Check4      = N'" & FormatSQL(z7174.Check4) & "', " 
    SQL = SQL & "    K7174_Check5      = N'" & FormatSQL(z7174.Check5) & "', " 
    SQL = SQL & "    K7174_CreatedBy      = N'" & FormatSQL(z7174.CreatedBy) & "', " 
    SQL = SQL & "    K7174_Remark      = N'" & FormatSQL(z7174.Remark) & "'  " 
    SQL = SQL & " WHERE K7174_DevelopmentCode		 = '" & z7174.DevelopmentCode & "' " 
    SQL = SQL & "   AND K7174_AccountCode		 = '" & z7174.AccountCode & "' " 
    SQL = SQL & "   AND K7174_DateClosing		 = '" & z7174.DateClosing & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7174 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7174",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7174(z7174 As T7174_AREA) As Boolean
    DELETE_PFK7174 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7174 "
    SQL = SQL & " WHERE K7174_DevelopmentCode		 = '" & z7174.DevelopmentCode & "' " 
    SQL = SQL & "   AND K7174_AccountCode		 = '" & z7174.AccountCode & "' " 
    SQL = SQL & "   AND K7174_DateClosing		 = '" & z7174.DateClosing & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7174 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7174",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7174_CLEAR()
Try
    
   D7174.DevelopmentCode = ""
   D7174.AccountCode = ""
   D7174.DateClosing = ""
   D7174.DateCreate = ""
    D7174.DebitAmountVND = 0 
    D7174.CreditAmountVND = 0 
    D7174.DebitAmountUSD = 0 
    D7174.CreditAmountUSD = 0 
   D7174.Check1 = ""
   D7174.Check2 = ""
   D7174.Check3 = ""
   D7174.Check4 = ""
   D7174.Check5 = ""
   D7174.CreatedBy = ""
   D7174.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7174_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7174 As T7174_AREA)
Try
    
    x7174.DevelopmentCode = trim$(  x7174.DevelopmentCode)
    x7174.AccountCode = trim$(  x7174.AccountCode)
    x7174.DateClosing = trim$(  x7174.DateClosing)
    x7174.DateCreate = trim$(  x7174.DateCreate)
    x7174.DebitAmountVND = trim$(  x7174.DebitAmountVND)
    x7174.CreditAmountVND = trim$(  x7174.CreditAmountVND)
    x7174.DebitAmountUSD = trim$(  x7174.DebitAmountUSD)
    x7174.CreditAmountUSD = trim$(  x7174.CreditAmountUSD)
    x7174.Check1 = trim$(  x7174.Check1)
    x7174.Check2 = trim$(  x7174.Check2)
    x7174.Check3 = trim$(  x7174.Check3)
    x7174.Check4 = trim$(  x7174.Check4)
    x7174.Check5 = trim$(  x7174.Check5)
    x7174.CreatedBy = trim$(  x7174.CreatedBy)
    x7174.Remark = trim$(  x7174.Remark)
     
    If trim$( x7174.DevelopmentCode ) = "" Then x7174.DevelopmentCode = Space(1) 
    If trim$( x7174.AccountCode ) = "" Then x7174.AccountCode = Space(1) 
    If trim$( x7174.DateClosing ) = "" Then x7174.DateClosing = Space(1) 
    If trim$( x7174.DateCreate ) = "" Then x7174.DateCreate = Space(1) 
    If trim$( x7174.DebitAmountVND ) = "" Then x7174.DebitAmountVND = 0 
    If trim$( x7174.CreditAmountVND ) = "" Then x7174.CreditAmountVND = 0 
    If trim$( x7174.DebitAmountUSD ) = "" Then x7174.DebitAmountUSD = 0 
    If trim$( x7174.CreditAmountUSD ) = "" Then x7174.CreditAmountUSD = 0 
    If trim$( x7174.Check1 ) = "" Then x7174.Check1 = Space(1) 
    If trim$( x7174.Check2 ) = "" Then x7174.Check2 = Space(1) 
    If trim$( x7174.Check3 ) = "" Then x7174.Check3 = Space(1) 
    If trim$( x7174.Check4 ) = "" Then x7174.Check4 = Space(1) 
    If trim$( x7174.Check5 ) = "" Then x7174.Check5 = Space(1) 
    If trim$( x7174.CreatedBy ) = "" Then x7174.CreatedBy = Space(1) 
    If trim$( x7174.Remark ) = "" Then x7174.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7174_MOVE(rs7174 As SqlClient.SqlDataReader)
Try

    call D7174_CLEAR()   

    If IsdbNull(rs7174!K7174_DevelopmentCode) = False Then D7174.DevelopmentCode = Trim$(rs7174!K7174_DevelopmentCode)
    If IsdbNull(rs7174!K7174_AccountCode) = False Then D7174.AccountCode = Trim$(rs7174!K7174_AccountCode)
    If IsdbNull(rs7174!K7174_DateClosing) = False Then D7174.DateClosing = Trim$(rs7174!K7174_DateClosing)
    If IsdbNull(rs7174!K7174_DateCreate) = False Then D7174.DateCreate = Trim$(rs7174!K7174_DateCreate)
    If IsdbNull(rs7174!K7174_DebitAmountVND) = False Then D7174.DebitAmountVND = Trim$(rs7174!K7174_DebitAmountVND)
    If IsdbNull(rs7174!K7174_CreditAmountVND) = False Then D7174.CreditAmountVND = Trim$(rs7174!K7174_CreditAmountVND)
    If IsdbNull(rs7174!K7174_DebitAmountUSD) = False Then D7174.DebitAmountUSD = Trim$(rs7174!K7174_DebitAmountUSD)
    If IsdbNull(rs7174!K7174_CreditAmountUSD) = False Then D7174.CreditAmountUSD = Trim$(rs7174!K7174_CreditAmountUSD)
    If IsdbNull(rs7174!K7174_Check1) = False Then D7174.Check1 = Trim$(rs7174!K7174_Check1)
    If IsdbNull(rs7174!K7174_Check2) = False Then D7174.Check2 = Trim$(rs7174!K7174_Check2)
    If IsdbNull(rs7174!K7174_Check3) = False Then D7174.Check3 = Trim$(rs7174!K7174_Check3)
    If IsdbNull(rs7174!K7174_Check4) = False Then D7174.Check4 = Trim$(rs7174!K7174_Check4)
    If IsdbNull(rs7174!K7174_Check5) = False Then D7174.Check5 = Trim$(rs7174!K7174_Check5)
    If IsdbNull(rs7174!K7174_CreatedBy) = False Then D7174.CreatedBy = Trim$(rs7174!K7174_CreatedBy)
    If IsdbNull(rs7174!K7174_Remark) = False Then D7174.Remark = Trim$(rs7174!K7174_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7174_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7174_MOVE(rs7174 As DataRow)
Try

    call D7174_CLEAR()   

    If IsdbNull(rs7174!K7174_DevelopmentCode) = False Then D7174.DevelopmentCode = Trim$(rs7174!K7174_DevelopmentCode)
    If IsdbNull(rs7174!K7174_AccountCode) = False Then D7174.AccountCode = Trim$(rs7174!K7174_AccountCode)
    If IsdbNull(rs7174!K7174_DateClosing) = False Then D7174.DateClosing = Trim$(rs7174!K7174_DateClosing)
    If IsdbNull(rs7174!K7174_DateCreate) = False Then D7174.DateCreate = Trim$(rs7174!K7174_DateCreate)
    If IsdbNull(rs7174!K7174_DebitAmountVND) = False Then D7174.DebitAmountVND = Trim$(rs7174!K7174_DebitAmountVND)
    If IsdbNull(rs7174!K7174_CreditAmountVND) = False Then D7174.CreditAmountVND = Trim$(rs7174!K7174_CreditAmountVND)
    If IsdbNull(rs7174!K7174_DebitAmountUSD) = False Then D7174.DebitAmountUSD = Trim$(rs7174!K7174_DebitAmountUSD)
    If IsdbNull(rs7174!K7174_CreditAmountUSD) = False Then D7174.CreditAmountUSD = Trim$(rs7174!K7174_CreditAmountUSD)
    If IsdbNull(rs7174!K7174_Check1) = False Then D7174.Check1 = Trim$(rs7174!K7174_Check1)
    If IsdbNull(rs7174!K7174_Check2) = False Then D7174.Check2 = Trim$(rs7174!K7174_Check2)
    If IsdbNull(rs7174!K7174_Check3) = False Then D7174.Check3 = Trim$(rs7174!K7174_Check3)
    If IsdbNull(rs7174!K7174_Check4) = False Then D7174.Check4 = Trim$(rs7174!K7174_Check4)
    If IsdbNull(rs7174!K7174_Check5) = False Then D7174.Check5 = Trim$(rs7174!K7174_Check5)
    If IsdbNull(rs7174!K7174_CreatedBy) = False Then D7174.CreatedBy = Trim$(rs7174!K7174_CreatedBy)
    If IsdbNull(rs7174!K7174_Remark) = False Then D7174.Remark = Trim$(rs7174!K7174_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7174_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7174_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7174 As T7174_AREA, DEVELOPMENTCODE AS String, ACCOUNTCODE AS String, DATECLOSING AS String) as Boolean

K7174_MOVE = False

Try
    If READ_PFK7174(DEVELOPMENTCODE, ACCOUNTCODE, DATECLOSING) = True Then
                z7174 = D7174
		K7174_MOVE = True
		else
	z7174 = nothing
     End If

     If  getColumIndex(spr,"DevelopmentCode") > -1 then z7174.DevelopmentCode = getDataM(spr, getColumIndex(spr,"DevelopmentCode"), xRow)
     If  getColumIndex(spr,"AccountCode") > -1 then z7174.AccountCode = getDataM(spr, getColumIndex(spr,"AccountCode"), xRow)
     If  getColumIndex(spr,"DateClosing") > -1 then z7174.DateClosing = getDataM(spr, getColumIndex(spr,"DateClosing"), xRow)
     If  getColumIndex(spr,"DateCreate") > -1 then z7174.DateCreate = getDataM(spr, getColumIndex(spr,"DateCreate"), xRow)
     If  getColumIndex(spr,"DebitAmountVND") > -1 then z7174.DebitAmountVND = getDataM(spr, getColumIndex(spr,"DebitAmountVND"), xRow)
     If  getColumIndex(spr,"CreditAmountVND") > -1 then z7174.CreditAmountVND = getDataM(spr, getColumIndex(spr,"CreditAmountVND"), xRow)
     If  getColumIndex(spr,"DebitAmountUSD") > -1 then z7174.DebitAmountUSD = getDataM(spr, getColumIndex(spr,"DebitAmountUSD"), xRow)
     If  getColumIndex(spr,"CreditAmountUSD") > -1 then z7174.CreditAmountUSD = getDataM(spr, getColumIndex(spr,"CreditAmountUSD"), xRow)
     If  getColumIndex(spr,"Check1") > -1 then z7174.Check1 = getDataM(spr, getColumIndex(spr,"Check1"), xRow)
     If  getColumIndex(spr,"Check2") > -1 then z7174.Check2 = getDataM(spr, getColumIndex(spr,"Check2"), xRow)
     If  getColumIndex(spr,"Check3") > -1 then z7174.Check3 = getDataM(spr, getColumIndex(spr,"Check3"), xRow)
     If  getColumIndex(spr,"Check4") > -1 then z7174.Check4 = getDataM(spr, getColumIndex(spr,"Check4"), xRow)
     If  getColumIndex(spr,"Check5") > -1 then z7174.Check5 = getDataM(spr, getColumIndex(spr,"Check5"), xRow)
     If  getColumIndex(spr,"CreatedBy") > -1 then z7174.CreatedBy = getDataM(spr, getColumIndex(spr,"CreatedBy"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7174.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7174_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7174_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7174 As T7174_AREA,CheckClear as Boolean,DEVELOPMENTCODE AS String, ACCOUNTCODE AS String, DATECLOSING AS String) as Boolean

K7174_MOVE = False

Try
    If READ_PFK7174(DEVELOPMENTCODE, ACCOUNTCODE, DATECLOSING) = True Then
                z7174 = D7174
		K7174_MOVE = True
		else
	If CheckClear  = True then z7174 = nothing
     End If

     If  getColumIndex(spr,"DevelopmentCode") > -1 then z7174.DevelopmentCode = getDataM(spr, getColumIndex(spr,"DevelopmentCode"), xRow)
     If  getColumIndex(spr,"AccountCode") > -1 then z7174.AccountCode = getDataM(spr, getColumIndex(spr,"AccountCode"), xRow)
     If  getColumIndex(spr,"DateClosing") > -1 then z7174.DateClosing = getDataM(spr, getColumIndex(spr,"DateClosing"), xRow)
     If  getColumIndex(spr,"DateCreate") > -1 then z7174.DateCreate = getDataM(spr, getColumIndex(spr,"DateCreate"), xRow)
     If  getColumIndex(spr,"DebitAmountVND") > -1 then z7174.DebitAmountVND = getDataM(spr, getColumIndex(spr,"DebitAmountVND"), xRow)
     If  getColumIndex(spr,"CreditAmountVND") > -1 then z7174.CreditAmountVND = getDataM(spr, getColumIndex(spr,"CreditAmountVND"), xRow)
     If  getColumIndex(spr,"DebitAmountUSD") > -1 then z7174.DebitAmountUSD = getDataM(spr, getColumIndex(spr,"DebitAmountUSD"), xRow)
     If  getColumIndex(spr,"CreditAmountUSD") > -1 then z7174.CreditAmountUSD = getDataM(spr, getColumIndex(spr,"CreditAmountUSD"), xRow)
     If  getColumIndex(spr,"Check1") > -1 then z7174.Check1 = getDataM(spr, getColumIndex(spr,"Check1"), xRow)
     If  getColumIndex(spr,"Check2") > -1 then z7174.Check2 = getDataM(spr, getColumIndex(spr,"Check2"), xRow)
     If  getColumIndex(spr,"Check3") > -1 then z7174.Check3 = getDataM(spr, getColumIndex(spr,"Check3"), xRow)
     If  getColumIndex(spr,"Check4") > -1 then z7174.Check4 = getDataM(spr, getColumIndex(spr,"Check4"), xRow)
     If  getColumIndex(spr,"Check5") > -1 then z7174.Check5 = getDataM(spr, getColumIndex(spr,"Check5"), xRow)
     If  getColumIndex(spr,"CreatedBy") > -1 then z7174.CreatedBy = getDataM(spr, getColumIndex(spr,"CreatedBy"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7174.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7174_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7174_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7174 As T7174_AREA, Job as String, DEVELOPMENTCODE AS String, ACCOUNTCODE AS String, DATECLOSING AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7174_MOVE = False

Try
    If READ_PFK7174(DEVELOPMENTCODE, ACCOUNTCODE, DATECLOSING) = True Then
                z7174 = D7174
		K7174_MOVE = True
		else
	z7174 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7174")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "DEVELOPMENTCODE":z7174.DevelopmentCode = Children(i).Code
   Case "ACCOUNTCODE":z7174.AccountCode = Children(i).Code
   Case "DATECLOSING":z7174.DateClosing = Children(i).Code
   Case "DATECREATE":z7174.DateCreate = Children(i).Code
   Case "DEBITAMOUNTVND":z7174.DebitAmountVND = Children(i).Code
   Case "CREDITAMOUNTVND":z7174.CreditAmountVND = Children(i).Code
   Case "DEBITAMOUNTUSD":z7174.DebitAmountUSD = Children(i).Code
   Case "CREDITAMOUNTUSD":z7174.CreditAmountUSD = Children(i).Code
   Case "CHECK1":z7174.Check1 = Children(i).Code
   Case "CHECK2":z7174.Check2 = Children(i).Code
   Case "CHECK3":z7174.Check3 = Children(i).Code
   Case "CHECK4":z7174.Check4 = Children(i).Code
   Case "CHECK5":z7174.Check5 = Children(i).Code
   Case "CREATEDBY":z7174.CreatedBy = Children(i).Code
   Case "REMARK":z7174.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "DEVELOPMENTCODE":z7174.DevelopmentCode = Children(i).Data
   Case "ACCOUNTCODE":z7174.AccountCode = Children(i).Data
   Case "DATECLOSING":z7174.DateClosing = Children(i).Data
   Case "DATECREATE":z7174.DateCreate = Children(i).Data
   Case "DEBITAMOUNTVND":z7174.DebitAmountVND = Children(i).Data
   Case "CREDITAMOUNTVND":z7174.CreditAmountVND = Children(i).Data
   Case "DEBITAMOUNTUSD":z7174.DebitAmountUSD = Children(i).Data
   Case "CREDITAMOUNTUSD":z7174.CreditAmountUSD = Children(i).Data
   Case "CHECK1":z7174.Check1 = Children(i).Data
   Case "CHECK2":z7174.Check2 = Children(i).Data
   Case "CHECK3":z7174.Check3 = Children(i).Data
   Case "CHECK4":z7174.Check4 = Children(i).Data
   Case "CHECK5":z7174.Check5 = Children(i).Data
   Case "CREATEDBY":z7174.CreatedBy = Children(i).Data
   Case "REMARK":z7174.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7174_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7174_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7174 As T7174_AREA, Job as String, CheckClear as Boolean, DEVELOPMENTCODE AS String, ACCOUNTCODE AS String, DATECLOSING AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7174_MOVE = False

Try
    If READ_PFK7174(DEVELOPMENTCODE, ACCOUNTCODE, DATECLOSING) = True Then
                z7174 = D7174
		K7174_MOVE = True
		else
	If CheckClear  = True then z7174 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7174")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "DEVELOPMENTCODE":z7174.DevelopmentCode = Children(i).Code
   Case "ACCOUNTCODE":z7174.AccountCode = Children(i).Code
   Case "DATECLOSING":z7174.DateClosing = Children(i).Code
   Case "DATECREATE":z7174.DateCreate = Children(i).Code
   Case "DEBITAMOUNTVND":z7174.DebitAmountVND = Children(i).Code
   Case "CREDITAMOUNTVND":z7174.CreditAmountVND = Children(i).Code
   Case "DEBITAMOUNTUSD":z7174.DebitAmountUSD = Children(i).Code
   Case "CREDITAMOUNTUSD":z7174.CreditAmountUSD = Children(i).Code
   Case "CHECK1":z7174.Check1 = Children(i).Code
   Case "CHECK2":z7174.Check2 = Children(i).Code
   Case "CHECK3":z7174.Check3 = Children(i).Code
   Case "CHECK4":z7174.Check4 = Children(i).Code
   Case "CHECK5":z7174.Check5 = Children(i).Code
   Case "CREATEDBY":z7174.CreatedBy = Children(i).Code
   Case "REMARK":z7174.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "DEVELOPMENTCODE":z7174.DevelopmentCode = Children(i).Data
   Case "ACCOUNTCODE":z7174.AccountCode = Children(i).Data
   Case "DATECLOSING":z7174.DateClosing = Children(i).Data
   Case "DATECREATE":z7174.DateCreate = Children(i).Data
   Case "DEBITAMOUNTVND":z7174.DebitAmountVND = Children(i).Data
   Case "CREDITAMOUNTVND":z7174.CreditAmountVND = Children(i).Data
   Case "DEBITAMOUNTUSD":z7174.DebitAmountUSD = Children(i).Data
   Case "CREDITAMOUNTUSD":z7174.CreditAmountUSD = Children(i).Data
   Case "CHECK1":z7174.Check1 = Children(i).Data
   Case "CHECK2":z7174.Check2 = Children(i).Data
   Case "CHECK3":z7174.Check3 = Children(i).Data
   Case "CHECK4":z7174.Check4 = Children(i).Data
   Case "CHECK5":z7174.Check5 = Children(i).Data
   Case "CREATEDBY":z7174.CreatedBy = Children(i).Data
   Case "REMARK":z7174.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7174_MOVE",vbCritical)
End Try
End Function 
    
End Module 
