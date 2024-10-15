'=========================================================================================================================================================
'   TABLE : (PFK3456)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K3456

Structure T3456_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	Autokey	 AS Double	'			decimal		*
Public 	Autokey_PFK3452	 AS Double	'			decimal
Public 	sePackagePosition	 AS String	'			char(3)
Public 	cdPackagePosition	 AS String	'			char(3)
Public 	sePackagePart	 AS String	'			char(3)
Public 	cdPackagePart	 AS String	'			char(3)
Public 	sePackageType	 AS String	'			char(3)
Public 	cdPackageType	 AS String	'			char(3)
Public 	Content1	 AS String	'			nvarchar(50)
Public 	Content2	 AS String	'			nvarchar(50)
Public 	Content3	 AS String	'			nvarchar(50)
Public 	Content4	 AS String	'			nvarchar(50)
Public 	Content5	 AS String	'			nvarchar(50)
Public 	QtyContent1	 AS Double	'			decimal
Public 	QtyContent2	 AS Double	'			decimal
Public 	QtyContent3	 AS Double	'			decimal
Public 	QtyContent4	 AS Double	'			decimal
Public 	QtyContent5	 AS Double	'			decimal
Public 	DateInsert	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	Remark	 AS String	'			nvarchar(200)
'=========================================================================================================================================================
End structure

Public D3456 As T3456_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK3456(AUTOKEY AS Double) As Boolean
    READ_PFK3456 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3456 "
    SQL = SQL & " WHERE K3456_Autokey		 =  " & Autokey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D3456_CLEAR: GoTo SKIP_READ_PFK3456
                
    Call K3456_MOVE(rd)
    READ_PFK3456 = True

SKIP_READ_PFK3456:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK3456",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK3456(AUTOKEY AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3456 "
    SQL = SQL & " WHERE K3456_Autokey		 =  " & Autokey & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK3456",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK3456(z3456 As T3456_AREA) As Boolean
    WRITE_PFK3456 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z3456)
 
    SQL = " INSERT INTO PFK3456 "
    SQL = SQL & " ( "
    SQL = SQL & " K3456_Autokey_PFK3452," 
    SQL = SQL & " K3456_sePackagePosition," 
    SQL = SQL & " K3456_cdPackagePosition," 
    SQL = SQL & " K3456_sePackagePart," 
    SQL = SQL & " K3456_cdPackagePart," 
    SQL = SQL & " K3456_sePackageType," 
    SQL = SQL & " K3456_cdPackageType," 
    SQL = SQL & " K3456_Content1," 
    SQL = SQL & " K3456_Content2," 
    SQL = SQL & " K3456_Content3," 
    SQL = SQL & " K3456_Content4," 
    SQL = SQL & " K3456_Content5," 
    SQL = SQL & " K3456_QtyContent1," 
    SQL = SQL & " K3456_QtyContent2," 
    SQL = SQL & " K3456_QtyContent3," 
    SQL = SQL & " K3456_QtyContent4," 
    SQL = SQL & " K3456_QtyContent5," 
    SQL = SQL & " K3456_DateInsert," 
    SQL = SQL & " K3456_InchargeInsert," 
    SQL = SQL & " K3456_DateUpdate," 
    SQL = SQL & " K3456_InchargeUpdate," 
    SQL = SQL & " K3456_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "   " & FormatSQL(z3456.Autokey_PFK3452) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3456.sePackagePosition) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3456.cdPackagePosition) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3456.sePackagePart) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3456.cdPackagePart) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3456.sePackageType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3456.cdPackageType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3456.Content1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3456.Content2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3456.Content3) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3456.Content4) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3456.Content5) & "', "  
    SQL = SQL & "   " & FormatSQL(z3456.QtyContent1) & ", "  
    SQL = SQL & "   " & FormatSQL(z3456.QtyContent2) & ", "  
    SQL = SQL & "   " & FormatSQL(z3456.QtyContent3) & ", "  
    SQL = SQL & "   " & FormatSQL(z3456.QtyContent4) & ", "  
    SQL = SQL & "   " & FormatSQL(z3456.QtyContent5) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z3456.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3456.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3456.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3456.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3456.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK3456 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK3456",vbCritical)
Finally
        Call GetFullInformation("PFK3456", "I", SQL)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK3456(z3456 As T3456_AREA) As Boolean
    REWRITE_PFK3456 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z3456)
   
    SQL = " UPDATE PFK3456 SET "
    SQL = SQL & "    K3456_Autokey_PFK3452      =  " & FormatSQL(z3456.Autokey_PFK3452) & ", " 
    SQL = SQL & "    K3456_sePackagePosition      = N'" & FormatSQL(z3456.sePackagePosition) & "', " 
    SQL = SQL & "    K3456_cdPackagePosition      = N'" & FormatSQL(z3456.cdPackagePosition) & "', " 
    SQL = SQL & "    K3456_sePackagePart      = N'" & FormatSQL(z3456.sePackagePart) & "', " 
    SQL = SQL & "    K3456_cdPackagePart      = N'" & FormatSQL(z3456.cdPackagePart) & "', " 
    SQL = SQL & "    K3456_sePackageType      = N'" & FormatSQL(z3456.sePackageType) & "', " 
    SQL = SQL & "    K3456_cdPackageType      = N'" & FormatSQL(z3456.cdPackageType) & "', " 
    SQL = SQL & "    K3456_Content1      = N'" & FormatSQL(z3456.Content1) & "', " 
    SQL = SQL & "    K3456_Content2      = N'" & FormatSQL(z3456.Content2) & "', " 
    SQL = SQL & "    K3456_Content3      = N'" & FormatSQL(z3456.Content3) & "', " 
    SQL = SQL & "    K3456_Content4      = N'" & FormatSQL(z3456.Content4) & "', " 
    SQL = SQL & "    K3456_Content5      = N'" & FormatSQL(z3456.Content5) & "', " 
    SQL = SQL & "    K3456_QtyContent1      =  " & FormatSQL(z3456.QtyContent1) & ", " 
    SQL = SQL & "    K3456_QtyContent2      =  " & FormatSQL(z3456.QtyContent2) & ", " 
    SQL = SQL & "    K3456_QtyContent3      =  " & FormatSQL(z3456.QtyContent3) & ", " 
    SQL = SQL & "    K3456_QtyContent4      =  " & FormatSQL(z3456.QtyContent4) & ", " 
    SQL = SQL & "    K3456_QtyContent5      =  " & FormatSQL(z3456.QtyContent5) & ", " 
    SQL = SQL & "    K3456_DateInsert      = N'" & FormatSQL(z3456.DateInsert) & "', " 
    SQL = SQL & "    K3456_InchargeInsert      = N'" & FormatSQL(z3456.InchargeInsert) & "', " 
    SQL = SQL & "    K3456_DateUpdate      = N'" & FormatSQL(z3456.DateUpdate) & "', " 
    SQL = SQL & "    K3456_InchargeUpdate      = N'" & FormatSQL(z3456.InchargeUpdate) & "', " 
    SQL = SQL & "    K3456_Remark      = N'" & FormatSQL(z3456.Remark) & "'  " 
    SQL = SQL & " WHERE K3456_Autokey		 =  " & z3456.Autokey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
	REWRITE_PFK3456 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK3456",vbCritical)
Finally
        Call GetFullInformation("PFK3456", "U", SQL)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK3456(z3456 As T3456_AREA) As Boolean
    DELETE_PFK3456 = False

   Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z3456)
      
        SQL = " DELETE FROM PFK3456  "
    SQL = SQL & " WHERE K3456_Autokey		 =  " & z3456.Autokey & "  " 

    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK3456 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK3456",vbCritical)
Finally
        Call GetFullInformation("PFK3456", "U", SQL)
  End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D3456_CLEAR()
Try
    
    D3456.Autokey = 0 
    D3456.Autokey_PFK3452 = 0 
   D3456.sePackagePosition = ""
   D3456.cdPackagePosition = ""
   D3456.sePackagePart = ""
   D3456.cdPackagePart = ""
   D3456.sePackageType = ""
   D3456.cdPackageType = ""
   D3456.Content1 = ""
   D3456.Content2 = ""
   D3456.Content3 = ""
   D3456.Content4 = ""
   D3456.Content5 = ""
    D3456.QtyContent1 = 0 
    D3456.QtyContent2 = 0 
    D3456.QtyContent3 = 0 
    D3456.QtyContent4 = 0 
    D3456.QtyContent5 = 0 
   D3456.DateInsert = ""
   D3456.InchargeInsert = ""
   D3456.DateUpdate = ""
   D3456.InchargeUpdate = ""
   D3456.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D3456_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x3456 As T3456_AREA)
Try
    
    x3456.Autokey = trim$(  x3456.Autokey)
    x3456.Autokey_PFK3452 = trim$(  x3456.Autokey_PFK3452)
    x3456.sePackagePosition = trim$(  x3456.sePackagePosition)
    x3456.cdPackagePosition = trim$(  x3456.cdPackagePosition)
    x3456.sePackagePart = trim$(  x3456.sePackagePart)
    x3456.cdPackagePart = trim$(  x3456.cdPackagePart)
    x3456.sePackageType = trim$(  x3456.sePackageType)
    x3456.cdPackageType = trim$(  x3456.cdPackageType)
    x3456.Content1 = trim$(  x3456.Content1)
    x3456.Content2 = trim$(  x3456.Content2)
    x3456.Content3 = trim$(  x3456.Content3)
    x3456.Content4 = trim$(  x3456.Content4)
    x3456.Content5 = trim$(  x3456.Content5)
    x3456.QtyContent1 = trim$(  x3456.QtyContent1)
    x3456.QtyContent2 = trim$(  x3456.QtyContent2)
    x3456.QtyContent3 = trim$(  x3456.QtyContent3)
    x3456.QtyContent4 = trim$(  x3456.QtyContent4)
    x3456.QtyContent5 = trim$(  x3456.QtyContent5)
    x3456.DateInsert = trim$(  x3456.DateInsert)
    x3456.InchargeInsert = trim$(  x3456.InchargeInsert)
    x3456.DateUpdate = trim$(  x3456.DateUpdate)
    x3456.InchargeUpdate = trim$(  x3456.InchargeUpdate)
    x3456.Remark = trim$(  x3456.Remark)
     
    If trim$( x3456.Autokey ) = "" Then x3456.Autokey = 0 
    If trim$( x3456.Autokey_PFK3452 ) = "" Then x3456.Autokey_PFK3452 = 0 
    If trim$( x3456.sePackagePosition ) = "" Then x3456.sePackagePosition = Space(1) 
    If trim$( x3456.cdPackagePosition ) = "" Then x3456.cdPackagePosition = Space(1) 
    If trim$( x3456.sePackagePart ) = "" Then x3456.sePackagePart = Space(1) 
    If trim$( x3456.cdPackagePart ) = "" Then x3456.cdPackagePart = Space(1) 
    If trim$( x3456.sePackageType ) = "" Then x3456.sePackageType = Space(1) 
    If trim$( x3456.cdPackageType ) = "" Then x3456.cdPackageType = Space(1) 
    If trim$( x3456.Content1 ) = "" Then x3456.Content1 = Space(1) 
    If trim$( x3456.Content2 ) = "" Then x3456.Content2 = Space(1) 
    If trim$( x3456.Content3 ) = "" Then x3456.Content3 = Space(1) 
    If trim$( x3456.Content4 ) = "" Then x3456.Content4 = Space(1) 
    If trim$( x3456.Content5 ) = "" Then x3456.Content5 = Space(1) 
    If trim$( x3456.QtyContent1 ) = "" Then x3456.QtyContent1 = 0 
    If trim$( x3456.QtyContent2 ) = "" Then x3456.QtyContent2 = 0 
    If trim$( x3456.QtyContent3 ) = "" Then x3456.QtyContent3 = 0 
    If trim$( x3456.QtyContent4 ) = "" Then x3456.QtyContent4 = 0 
    If trim$( x3456.QtyContent5 ) = "" Then x3456.QtyContent5 = 0 
    If trim$( x3456.DateInsert ) = "" Then x3456.DateInsert = Space(1) 
    If trim$( x3456.InchargeInsert ) = "" Then x3456.InchargeInsert = Space(1) 
    If trim$( x3456.DateUpdate ) = "" Then x3456.DateUpdate = Space(1) 
    If trim$( x3456.InchargeUpdate ) = "" Then x3456.InchargeUpdate = Space(1) 
    If trim$( x3456.Remark ) = "" Then x3456.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K3456_MOVE(rs3456 As SqlClient.SqlDataReader)
Try

    call D3456_CLEAR()   

    If IsdbNull(rs3456!K3456_Autokey) = False Then D3456.Autokey = Trim$(rs3456!K3456_Autokey)
    If IsdbNull(rs3456!K3456_Autokey_PFK3452) = False Then D3456.Autokey_PFK3452 = Trim$(rs3456!K3456_Autokey_PFK3452)
    If IsdbNull(rs3456!K3456_sePackagePosition) = False Then D3456.sePackagePosition = Trim$(rs3456!K3456_sePackagePosition)
    If IsdbNull(rs3456!K3456_cdPackagePosition) = False Then D3456.cdPackagePosition = Trim$(rs3456!K3456_cdPackagePosition)
    If IsdbNull(rs3456!K3456_sePackagePart) = False Then D3456.sePackagePart = Trim$(rs3456!K3456_sePackagePart)
    If IsdbNull(rs3456!K3456_cdPackagePart) = False Then D3456.cdPackagePart = Trim$(rs3456!K3456_cdPackagePart)
    If IsdbNull(rs3456!K3456_sePackageType) = False Then D3456.sePackageType = Trim$(rs3456!K3456_sePackageType)
    If IsdbNull(rs3456!K3456_cdPackageType) = False Then D3456.cdPackageType = Trim$(rs3456!K3456_cdPackageType)
    If IsdbNull(rs3456!K3456_Content1) = False Then D3456.Content1 = Trim$(rs3456!K3456_Content1)
    If IsdbNull(rs3456!K3456_Content2) = False Then D3456.Content2 = Trim$(rs3456!K3456_Content2)
    If IsdbNull(rs3456!K3456_Content3) = False Then D3456.Content3 = Trim$(rs3456!K3456_Content3)
    If IsdbNull(rs3456!K3456_Content4) = False Then D3456.Content4 = Trim$(rs3456!K3456_Content4)
    If IsdbNull(rs3456!K3456_Content5) = False Then D3456.Content5 = Trim$(rs3456!K3456_Content5)
    If IsdbNull(rs3456!K3456_QtyContent1) = False Then D3456.QtyContent1 = Trim$(rs3456!K3456_QtyContent1)
    If IsdbNull(rs3456!K3456_QtyContent2) = False Then D3456.QtyContent2 = Trim$(rs3456!K3456_QtyContent2)
    If IsdbNull(rs3456!K3456_QtyContent3) = False Then D3456.QtyContent3 = Trim$(rs3456!K3456_QtyContent3)
    If IsdbNull(rs3456!K3456_QtyContent4) = False Then D3456.QtyContent4 = Trim$(rs3456!K3456_QtyContent4)
    If IsdbNull(rs3456!K3456_QtyContent5) = False Then D3456.QtyContent5 = Trim$(rs3456!K3456_QtyContent5)
    If IsdbNull(rs3456!K3456_DateInsert) = False Then D3456.DateInsert = Trim$(rs3456!K3456_DateInsert)
    If IsdbNull(rs3456!K3456_InchargeInsert) = False Then D3456.InchargeInsert = Trim$(rs3456!K3456_InchargeInsert)
    If IsdbNull(rs3456!K3456_DateUpdate) = False Then D3456.DateUpdate = Trim$(rs3456!K3456_DateUpdate)
    If IsdbNull(rs3456!K3456_InchargeUpdate) = False Then D3456.InchargeUpdate = Trim$(rs3456!K3456_InchargeUpdate)
    If IsdbNull(rs3456!K3456_Remark) = False Then D3456.Remark = Trim$(rs3456!K3456_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3456_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K3456_MOVE(rs3456 As DataRow)
Try

    call D3456_CLEAR()   

    If IsdbNull(rs3456!K3456_Autokey) = False Then D3456.Autokey = Trim$(rs3456!K3456_Autokey)
    If IsdbNull(rs3456!K3456_Autokey_PFK3452) = False Then D3456.Autokey_PFK3452 = Trim$(rs3456!K3456_Autokey_PFK3452)
    If IsdbNull(rs3456!K3456_sePackagePosition) = False Then D3456.sePackagePosition = Trim$(rs3456!K3456_sePackagePosition)
    If IsdbNull(rs3456!K3456_cdPackagePosition) = False Then D3456.cdPackagePosition = Trim$(rs3456!K3456_cdPackagePosition)
    If IsdbNull(rs3456!K3456_sePackagePart) = False Then D3456.sePackagePart = Trim$(rs3456!K3456_sePackagePart)
    If IsdbNull(rs3456!K3456_cdPackagePart) = False Then D3456.cdPackagePart = Trim$(rs3456!K3456_cdPackagePart)
    If IsdbNull(rs3456!K3456_sePackageType) = False Then D3456.sePackageType = Trim$(rs3456!K3456_sePackageType)
    If IsdbNull(rs3456!K3456_cdPackageType) = False Then D3456.cdPackageType = Trim$(rs3456!K3456_cdPackageType)
    If IsdbNull(rs3456!K3456_Content1) = False Then D3456.Content1 = Trim$(rs3456!K3456_Content1)
    If IsdbNull(rs3456!K3456_Content2) = False Then D3456.Content2 = Trim$(rs3456!K3456_Content2)
    If IsdbNull(rs3456!K3456_Content3) = False Then D3456.Content3 = Trim$(rs3456!K3456_Content3)
    If IsdbNull(rs3456!K3456_Content4) = False Then D3456.Content4 = Trim$(rs3456!K3456_Content4)
    If IsdbNull(rs3456!K3456_Content5) = False Then D3456.Content5 = Trim$(rs3456!K3456_Content5)
    If IsdbNull(rs3456!K3456_QtyContent1) = False Then D3456.QtyContent1 = Trim$(rs3456!K3456_QtyContent1)
    If IsdbNull(rs3456!K3456_QtyContent2) = False Then D3456.QtyContent2 = Trim$(rs3456!K3456_QtyContent2)
    If IsdbNull(rs3456!K3456_QtyContent3) = False Then D3456.QtyContent3 = Trim$(rs3456!K3456_QtyContent3)
    If IsdbNull(rs3456!K3456_QtyContent4) = False Then D3456.QtyContent4 = Trim$(rs3456!K3456_QtyContent4)
    If IsdbNull(rs3456!K3456_QtyContent5) = False Then D3456.QtyContent5 = Trim$(rs3456!K3456_QtyContent5)
    If IsdbNull(rs3456!K3456_DateInsert) = False Then D3456.DateInsert = Trim$(rs3456!K3456_DateInsert)
    If IsdbNull(rs3456!K3456_InchargeInsert) = False Then D3456.InchargeInsert = Trim$(rs3456!K3456_InchargeInsert)
    If IsdbNull(rs3456!K3456_DateUpdate) = False Then D3456.DateUpdate = Trim$(rs3456!K3456_DateUpdate)
    If IsdbNull(rs3456!K3456_InchargeUpdate) = False Then D3456.InchargeUpdate = Trim$(rs3456!K3456_InchargeUpdate)
    If IsdbNull(rs3456!K3456_Remark) = False Then D3456.Remark = Trim$(rs3456!K3456_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3456_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K3456_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3456 As T3456_AREA, AUTOKEY AS Double) as Boolean

K3456_MOVE = False

Try
    If READ_PFK3456(AUTOKEY) = True Then
                z3456 = D3456
		K3456_MOVE = True
		else
	z3456 = nothing
     End If

     If  getColumnIndex(spr,"Autokey") > -1 then z3456.Autokey = getDataM(spr, getColumnIndex(spr,"Autokey"), xRow)
     If  getColumnIndex(spr,"Autokey_PFK3452") > -1 then z3456.Autokey_PFK3452 = getDataM(spr, getColumnIndex(spr,"Autokey_PFK3452"), xRow)
     If  getColumnIndex(spr,"sePackagePosition") > -1 then z3456.sePackagePosition = getDataM(spr, getColumnIndex(spr,"sePackagePosition"), xRow)
     If  getColumnIndex(spr,"cdPackagePosition") > -1 then z3456.cdPackagePosition = getDataM(spr, getColumnIndex(spr,"cdPackagePosition"), xRow)
     If  getColumnIndex(spr,"sePackagePart") > -1 then z3456.sePackagePart = getDataM(spr, getColumnIndex(spr,"sePackagePart"), xRow)
     If  getColumnIndex(spr,"cdPackagePart") > -1 then z3456.cdPackagePart = getDataM(spr, getColumnIndex(spr,"cdPackagePart"), xRow)
     If  getColumnIndex(spr,"sePackageType") > -1 then z3456.sePackageType = getDataM(spr, getColumnIndex(spr,"sePackageType"), xRow)
     If  getColumnIndex(spr,"cdPackageType") > -1 then z3456.cdPackageType = getDataM(spr, getColumnIndex(spr,"cdPackageType"), xRow)
     If  getColumnIndex(spr,"Content1") > -1 then z3456.Content1 = getDataM(spr, getColumnIndex(spr,"Content1"), xRow)
     If  getColumnIndex(spr,"Content2") > -1 then z3456.Content2 = getDataM(spr, getColumnIndex(spr,"Content2"), xRow)
     If  getColumnIndex(spr,"Content3") > -1 then z3456.Content3 = getDataM(spr, getColumnIndex(spr,"Content3"), xRow)
     If  getColumnIndex(spr,"Content4") > -1 then z3456.Content4 = getDataM(spr, getColumnIndex(spr,"Content4"), xRow)
     If  getColumnIndex(spr,"Content5") > -1 then z3456.Content5 = getDataM(spr, getColumnIndex(spr,"Content5"), xRow)
     If  getColumnIndex(spr,"QtyContent1") > -1 then z3456.QtyContent1 = getDataM(spr, getColumnIndex(spr,"QtyContent1"), xRow)
     If  getColumnIndex(spr,"QtyContent2") > -1 then z3456.QtyContent2 = getDataM(spr, getColumnIndex(spr,"QtyContent2"), xRow)
     If  getColumnIndex(spr,"QtyContent3") > -1 then z3456.QtyContent3 = getDataM(spr, getColumnIndex(spr,"QtyContent3"), xRow)
     If  getColumnIndex(spr,"QtyContent4") > -1 then z3456.QtyContent4 = getDataM(spr, getColumnIndex(spr,"QtyContent4"), xRow)
     If  getColumnIndex(spr,"QtyContent5") > -1 then z3456.QtyContent5 = getDataM(spr, getColumnIndex(spr,"QtyContent5"), xRow)
     If  getColumnIndex(spr,"DateInsert") > -1 then z3456.DateInsert = getDataM(spr, getColumnIndex(spr,"DateInsert"), xRow)
     If  getColumnIndex(spr,"InchargeInsert") > -1 then z3456.InchargeInsert = getDataM(spr, getColumnIndex(spr,"InchargeInsert"), xRow)
     If  getColumnIndex(spr,"DateUpdate") > -1 then z3456.DateUpdate = getDataM(spr, getColumnIndex(spr,"DateUpdate"), xRow)
     If  getColumnIndex(spr,"InchargeUpdate") > -1 then z3456.InchargeUpdate = getDataM(spr, getColumnIndex(spr,"InchargeUpdate"), xRow)
     If  getColumnIndex(spr,"Remark") > -1 then z3456.Remark = getDataM(spr, getColumnIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3456_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K3456_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3456 As T3456_AREA,CheckClear as Boolean,AUTOKEY AS Double) as Boolean

K3456_MOVE = False

Try
    If READ_PFK3456(AUTOKEY) = True Then
                z3456 = D3456
		K3456_MOVE = True
		else
	If CheckClear  = True then z3456 = nothing
     End If

     If  getColumnIndex(spr,"Autokey") > -1 then z3456.Autokey = getDataM(spr, getColumnIndex(spr,"Autokey"), xRow)
     If  getColumnIndex(spr,"Autokey_PFK3452") > -1 then z3456.Autokey_PFK3452 = getDataM(spr, getColumnIndex(spr,"Autokey_PFK3452"), xRow)
     If  getColumnIndex(spr,"sePackagePosition") > -1 then z3456.sePackagePosition = getDataM(spr, getColumnIndex(spr,"sePackagePosition"), xRow)
     If  getColumnIndex(spr,"cdPackagePosition") > -1 then z3456.cdPackagePosition = getDataM(spr, getColumnIndex(spr,"cdPackagePosition"), xRow)
     If  getColumnIndex(spr,"sePackagePart") > -1 then z3456.sePackagePart = getDataM(spr, getColumnIndex(spr,"sePackagePart"), xRow)
     If  getColumnIndex(spr,"cdPackagePart") > -1 then z3456.cdPackagePart = getDataM(spr, getColumnIndex(spr,"cdPackagePart"), xRow)
     If  getColumnIndex(spr,"sePackageType") > -1 then z3456.sePackageType = getDataM(spr, getColumnIndex(spr,"sePackageType"), xRow)
     If  getColumnIndex(spr,"cdPackageType") > -1 then z3456.cdPackageType = getDataM(spr, getColumnIndex(spr,"cdPackageType"), xRow)
     If  getColumnIndex(spr,"Content1") > -1 then z3456.Content1 = getDataM(spr, getColumnIndex(spr,"Content1"), xRow)
     If  getColumnIndex(spr,"Content2") > -1 then z3456.Content2 = getDataM(spr, getColumnIndex(spr,"Content2"), xRow)
     If  getColumnIndex(spr,"Content3") > -1 then z3456.Content3 = getDataM(spr, getColumnIndex(spr,"Content3"), xRow)
     If  getColumnIndex(spr,"Content4") > -1 then z3456.Content4 = getDataM(spr, getColumnIndex(spr,"Content4"), xRow)
     If  getColumnIndex(spr,"Content5") > -1 then z3456.Content5 = getDataM(spr, getColumnIndex(spr,"Content5"), xRow)
     If  getColumnIndex(spr,"QtyContent1") > -1 then z3456.QtyContent1 = getDataM(spr, getColumnIndex(spr,"QtyContent1"), xRow)
     If  getColumnIndex(spr,"QtyContent2") > -1 then z3456.QtyContent2 = getDataM(spr, getColumnIndex(spr,"QtyContent2"), xRow)
     If  getColumnIndex(spr,"QtyContent3") > -1 then z3456.QtyContent3 = getDataM(spr, getColumnIndex(spr,"QtyContent3"), xRow)
     If  getColumnIndex(spr,"QtyContent4") > -1 then z3456.QtyContent4 = getDataM(spr, getColumnIndex(spr,"QtyContent4"), xRow)
     If  getColumnIndex(spr,"QtyContent5") > -1 then z3456.QtyContent5 = getDataM(spr, getColumnIndex(spr,"QtyContent5"), xRow)
     If  getColumnIndex(spr,"DateInsert") > -1 then z3456.DateInsert = getDataM(spr, getColumnIndex(spr,"DateInsert"), xRow)
     If  getColumnIndex(spr,"InchargeInsert") > -1 then z3456.InchargeInsert = getDataM(spr, getColumnIndex(spr,"InchargeInsert"), xRow)
     If  getColumnIndex(spr,"DateUpdate") > -1 then z3456.DateUpdate = getDataM(spr, getColumnIndex(spr,"DateUpdate"), xRow)
     If  getColumnIndex(spr,"InchargeUpdate") > -1 then z3456.InchargeUpdate = getDataM(spr, getColumnIndex(spr,"InchargeUpdate"), xRow)
     If  getColumnIndex(spr,"Remark") > -1 then z3456.Remark = getDataM(spr, getColumnIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3456_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K3456_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3456 As T3456_AREA, Job as String, AUTOKEY AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3456_MOVE = False

Try
    If READ_PFK3456(AUTOKEY) = True Then
                z3456 = D3456
		K3456_MOVE = True
		else
	z3456 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3456")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z3456.Autokey = Children(i).Code
   Case "AUTOKEY_PFK3452":z3456.Autokey_PFK3452 = Children(i).Code
   Case "SEPACKAGEPOSITION":z3456.sePackagePosition = Children(i).Code
   Case "CDPACKAGEPOSITION":z3456.cdPackagePosition = Children(i).Code
   Case "SEPACKAGEPART":z3456.sePackagePart = Children(i).Code
   Case "CDPACKAGEPART":z3456.cdPackagePart = Children(i).Code
   Case "SEPACKAGETYPE":z3456.sePackageType = Children(i).Code
   Case "CDPACKAGETYPE":z3456.cdPackageType = Children(i).Code
   Case "CONTENT1":z3456.Content1 = Children(i).Code
   Case "CONTENT2":z3456.Content2 = Children(i).Code
   Case "CONTENT3":z3456.Content3 = Children(i).Code
   Case "CONTENT4":z3456.Content4 = Children(i).Code
   Case "CONTENT5":z3456.Content5 = Children(i).Code
   Case "QTYCONTENT1":z3456.QtyContent1 = Children(i).Code
   Case "QTYCONTENT2":z3456.QtyContent2 = Children(i).Code
   Case "QTYCONTENT3":z3456.QtyContent3 = Children(i).Code
   Case "QTYCONTENT4":z3456.QtyContent4 = Children(i).Code
   Case "QTYCONTENT5":z3456.QtyContent5 = Children(i).Code
   Case "DATEINSERT":z3456.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z3456.InchargeInsert = Children(i).Code
   Case "DATEUPDATE":z3456.DateUpdate = Children(i).Code
   Case "INCHARGEUPDATE":z3456.InchargeUpdate = Children(i).Code
   Case "REMARK":z3456.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z3456.Autokey = Children(i).Data
   Case "AUTOKEY_PFK3452":z3456.Autokey_PFK3452 = Children(i).Data
   Case "SEPACKAGEPOSITION":z3456.sePackagePosition = Children(i).Data
   Case "CDPACKAGEPOSITION":z3456.cdPackagePosition = Children(i).Data
   Case "SEPACKAGEPART":z3456.sePackagePart = Children(i).Data
   Case "CDPACKAGEPART":z3456.cdPackagePart = Children(i).Data
   Case "SEPACKAGETYPE":z3456.sePackageType = Children(i).Data
   Case "CDPACKAGETYPE":z3456.cdPackageType = Children(i).Data
   Case "CONTENT1":z3456.Content1 = Children(i).Data
   Case "CONTENT2":z3456.Content2 = Children(i).Data
   Case "CONTENT3":z3456.Content3 = Children(i).Data
   Case "CONTENT4":z3456.Content4 = Children(i).Data
   Case "CONTENT5":z3456.Content5 = Children(i).Data
   Case "QTYCONTENT1":z3456.QtyContent1 = Children(i).Data
   Case "QTYCONTENT2":z3456.QtyContent2 = Children(i).Data
   Case "QTYCONTENT3":z3456.QtyContent3 = Children(i).Data
   Case "QTYCONTENT4":z3456.QtyContent4 = Children(i).Data
   Case "QTYCONTENT5":z3456.QtyContent5 = Children(i).Data
   Case "DATEINSERT":z3456.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z3456.InchargeInsert = Children(i).Data
   Case "DATEUPDATE":z3456.DateUpdate = Children(i).Data
   Case "INCHARGEUPDATE":z3456.InchargeUpdate = Children(i).Data
   Case "REMARK":z3456.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3456_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K3456_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3456 As T3456_AREA, Job as String, CheckClear as Boolean, AUTOKEY AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3456_MOVE = False

Try
    If READ_PFK3456(AUTOKEY) = True Then
                z3456 = D3456
		K3456_MOVE = True
		else
	If CheckClear  = True then z3456 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3456")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z3456.Autokey = Children(i).Code
   Case "AUTOKEY_PFK3452":z3456.Autokey_PFK3452 = Children(i).Code
   Case "SEPACKAGEPOSITION":z3456.sePackagePosition = Children(i).Code
   Case "CDPACKAGEPOSITION":z3456.cdPackagePosition = Children(i).Code
   Case "SEPACKAGEPART":z3456.sePackagePart = Children(i).Code
   Case "CDPACKAGEPART":z3456.cdPackagePart = Children(i).Code
   Case "SEPACKAGETYPE":z3456.sePackageType = Children(i).Code
   Case "CDPACKAGETYPE":z3456.cdPackageType = Children(i).Code
   Case "CONTENT1":z3456.Content1 = Children(i).Code
   Case "CONTENT2":z3456.Content2 = Children(i).Code
   Case "CONTENT3":z3456.Content3 = Children(i).Code
   Case "CONTENT4":z3456.Content4 = Children(i).Code
   Case "CONTENT5":z3456.Content5 = Children(i).Code
   Case "QTYCONTENT1":z3456.QtyContent1 = Children(i).Code
   Case "QTYCONTENT2":z3456.QtyContent2 = Children(i).Code
   Case "QTYCONTENT3":z3456.QtyContent3 = Children(i).Code
   Case "QTYCONTENT4":z3456.QtyContent4 = Children(i).Code
   Case "QTYCONTENT5":z3456.QtyContent5 = Children(i).Code
   Case "DATEINSERT":z3456.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z3456.InchargeInsert = Children(i).Code
   Case "DATEUPDATE":z3456.DateUpdate = Children(i).Code
   Case "INCHARGEUPDATE":z3456.InchargeUpdate = Children(i).Code
   Case "REMARK":z3456.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z3456.Autokey = Children(i).Data
   Case "AUTOKEY_PFK3452":z3456.Autokey_PFK3452 = Children(i).Data
   Case "SEPACKAGEPOSITION":z3456.sePackagePosition = Children(i).Data
   Case "CDPACKAGEPOSITION":z3456.cdPackagePosition = Children(i).Data
   Case "SEPACKAGEPART":z3456.sePackagePart = Children(i).Data
   Case "CDPACKAGEPART":z3456.cdPackagePart = Children(i).Data
   Case "SEPACKAGETYPE":z3456.sePackageType = Children(i).Data
   Case "CDPACKAGETYPE":z3456.cdPackageType = Children(i).Data
   Case "CONTENT1":z3456.Content1 = Children(i).Data
   Case "CONTENT2":z3456.Content2 = Children(i).Data
   Case "CONTENT3":z3456.Content3 = Children(i).Data
   Case "CONTENT4":z3456.Content4 = Children(i).Data
   Case "CONTENT5":z3456.Content5 = Children(i).Data
   Case "QTYCONTENT1":z3456.QtyContent1 = Children(i).Data
   Case "QTYCONTENT2":z3456.QtyContent2 = Children(i).Data
   Case "QTYCONTENT3":z3456.QtyContent3 = Children(i).Data
   Case "QTYCONTENT4":z3456.QtyContent4 = Children(i).Data
   Case "QTYCONTENT5":z3456.QtyContent5 = Children(i).Data
   Case "DATEINSERT":z3456.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z3456.InchargeInsert = Children(i).Data
   Case "DATEUPDATE":z3456.DateUpdate = Children(i).Data
   Case "INCHARGEUPDATE":z3456.InchargeUpdate = Children(i).Data
   Case "REMARK":z3456.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3456_MOVE",vbCritical)
End Try
End Function 
    

'=========================================================================================================================================================
' DATA MOVE FORM NEW AREA
'=========================================================================================================================================================
Public Sub K3456_MOVE(ByRef a3456 As T3456_AREA, ByRef b3456 As T3456_AREA) 
Try
If trim$( a3456.Autokey ) = "" Then b3456.Autokey = ""  Else b3456.Autokey=a3456.Autokey
If trim$( a3456.Autokey_PFK3452 ) = "" Then b3456.Autokey_PFK3452 = ""  Else b3456.Autokey_PFK3452=a3456.Autokey_PFK3452
If trim$( a3456.sePackagePosition ) = "" Then b3456.sePackagePosition = ""  Else b3456.sePackagePosition=a3456.sePackagePosition
If trim$( a3456.cdPackagePosition ) = "" Then b3456.cdPackagePosition = ""  Else b3456.cdPackagePosition=a3456.cdPackagePosition
If trim$( a3456.sePackagePart ) = "" Then b3456.sePackagePart = ""  Else b3456.sePackagePart=a3456.sePackagePart
If trim$( a3456.cdPackagePart ) = "" Then b3456.cdPackagePart = ""  Else b3456.cdPackagePart=a3456.cdPackagePart
If trim$( a3456.sePackageType ) = "" Then b3456.sePackageType = ""  Else b3456.sePackageType=a3456.sePackageType
If trim$( a3456.cdPackageType ) = "" Then b3456.cdPackageType = ""  Else b3456.cdPackageType=a3456.cdPackageType
If trim$( a3456.Content1 ) = "" Then b3456.Content1 = ""  Else b3456.Content1=a3456.Content1
If trim$( a3456.Content2 ) = "" Then b3456.Content2 = ""  Else b3456.Content2=a3456.Content2
If trim$( a3456.Content3 ) = "" Then b3456.Content3 = ""  Else b3456.Content3=a3456.Content3
If trim$( a3456.Content4 ) = "" Then b3456.Content4 = ""  Else b3456.Content4=a3456.Content4
If trim$( a3456.Content5 ) = "" Then b3456.Content5 = ""  Else b3456.Content5=a3456.Content5
If trim$( a3456.QtyContent1 ) = "" Then b3456.QtyContent1 = ""  Else b3456.QtyContent1=a3456.QtyContent1
If trim$( a3456.QtyContent2 ) = "" Then b3456.QtyContent2 = ""  Else b3456.QtyContent2=a3456.QtyContent2
If trim$( a3456.QtyContent3 ) = "" Then b3456.QtyContent3 = ""  Else b3456.QtyContent3=a3456.QtyContent3
If trim$( a3456.QtyContent4 ) = "" Then b3456.QtyContent4 = ""  Else b3456.QtyContent4=a3456.QtyContent4
If trim$( a3456.QtyContent5 ) = "" Then b3456.QtyContent5 = ""  Else b3456.QtyContent5=a3456.QtyContent5
If trim$( a3456.DateInsert ) = "" Then b3456.DateInsert = ""  Else b3456.DateInsert=a3456.DateInsert
If trim$( a3456.InchargeInsert ) = "" Then b3456.InchargeInsert = ""  Else b3456.InchargeInsert=a3456.InchargeInsert
If trim$( a3456.DateUpdate ) = "" Then b3456.DateUpdate = ""  Else b3456.DateUpdate=a3456.DateUpdate
If trim$( a3456.InchargeUpdate ) = "" Then b3456.InchargeUpdate = ""  Else b3456.InchargeUpdate=a3456.InchargeUpdate
If trim$( a3456.Remark ) = "" Then b3456.Remark = ""  Else b3456.Remark=a3456.Remark
Catch ex As Exception
      Call MsgBoxP("K3456_MOVE",vbCritical)
End Try
End Sub 


End Module 
