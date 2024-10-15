'=========================================================================================================================================================
'   TABLE : (PFK7213)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7213

Structure T7213_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	Autokey	 AS Double	'			decimal		*
Public 	Article	 AS String	'			nvarchar(50)
Public 	CartonCode	 AS String	'			char(6)
Public 	CartonCode_Mix	 AS String	'			char(6)
Public 	CustomerCode	 AS String	'			char(6)
Public 	FromSize	 AS Double	'			decimal
Public 	ToSize	 AS Double	'			decimal
Public 	CTQty	 AS Double	'			decimal
Public 	CTQty_Mix	 AS Double	'			decimal
Public 	ArtWeight	 AS Double	'			decimal
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	CheckUse	 AS String	'			char(1)
Public 	CheckComplete	 AS String	'			char(1)
Public 	Remark	 AS String	'			nvarchar(50)
'=========================================================================================================================================================
End structure

Public D7213 As T7213_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7213(AUTOKEY AS Double) As Boolean
    READ_PFK7213 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7213 "
    SQL = SQL & " WHERE K7213_Autokey		 =  " & Autokey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7213_CLEAR: GoTo SKIP_READ_PFK7213
                
    Call K7213_MOVE(rd)
    READ_PFK7213 = True

SKIP_READ_PFK7213:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7213",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7213(AUTOKEY AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7213 "
    SQL = SQL & " WHERE K7213_Autokey		 =  " & Autokey & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7213",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7213(z7213 As T7213_AREA) As Boolean
    WRITE_PFK7213 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7213)
 
    SQL = " INSERT INTO PFK7213 "
    SQL = SQL & " ( "
    SQL = SQL & " K7213_Article," 
    SQL = SQL & " K7213_CartonCode," 
    SQL = SQL & " K7213_CartonCode_Mix," 
    SQL = SQL & " K7213_CustomerCode," 
    SQL = SQL & " K7213_FromSize," 
    SQL = SQL & " K7213_ToSize," 
    SQL = SQL & " K7213_CTQty," 
    SQL = SQL & " K7213_CTQty_Mix," 
    SQL = SQL & " K7213_ArtWeight," 
    SQL = SQL & " K7213_DateInsert," 
    SQL = SQL & " K7213_DateUpdate," 
    SQL = SQL & " K7213_InchargeInsert," 
    SQL = SQL & " K7213_InchargeUpdate," 
    SQL = SQL & " K7213_CheckUse," 
    SQL = SQL & " K7213_CheckComplete," 
    SQL = SQL & " K7213_Remark " 
    SQL = SQL & " ) VALUES ( " 
    SQL = SQL & "  N'" & FormatSQL(z7213.Article) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7213.CartonCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7213.CartonCode_Mix) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7213.CustomerCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z7213.FromSize) & ", "  
    SQL = SQL & "   " & FormatSQL(z7213.ToSize) & ", "  
    SQL = SQL & "   " & FormatSQL(z7213.CTQty) & ", "  
    SQL = SQL & "   " & FormatSQL(z7213.CTQty_Mix) & ", "  
    SQL = SQL & "   " & FormatSQL(z7213.ArtWeight) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7213.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7213.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7213.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7213.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7213.CheckUse) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7213.CheckComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7213.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7213 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7213",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7213(z7213 As T7213_AREA) As Boolean
    REWRITE_PFK7213 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7213)
   
    SQL = " UPDATE PFK7213 SET "
    SQL = SQL & "    K7213_Article      = N'" & FormatSQL(z7213.Article) & "', " 
    SQL = SQL & "    K7213_CartonCode      = N'" & FormatSQL(z7213.CartonCode) & "', " 
    SQL = SQL & "    K7213_CartonCode_Mix      = N'" & FormatSQL(z7213.CartonCode_Mix) & "', " 
    SQL = SQL & "    K7213_CustomerCode      = N'" & FormatSQL(z7213.CustomerCode) & "', " 
    SQL = SQL & "    K7213_FromSize      =  " & FormatSQL(z7213.FromSize) & ", " 
    SQL = SQL & "    K7213_ToSize      =  " & FormatSQL(z7213.ToSize) & ", " 
    SQL = SQL & "    K7213_CTQty      =  " & FormatSQL(z7213.CTQty) & ", " 
    SQL = SQL & "    K7213_CTQty_Mix      =  " & FormatSQL(z7213.CTQty_Mix) & ", " 
    SQL = SQL & "    K7213_ArtWeight      =  " & FormatSQL(z7213.ArtWeight) & ", " 
    SQL = SQL & "    K7213_DateInsert      = N'" & FormatSQL(z7213.DateInsert) & "', " 
    SQL = SQL & "    K7213_DateUpdate      = N'" & FormatSQL(z7213.DateUpdate) & "', " 
    SQL = SQL & "    K7213_InchargeInsert      = N'" & FormatSQL(z7213.InchargeInsert) & "', " 
    SQL = SQL & "    K7213_InchargeUpdate      = N'" & FormatSQL(z7213.InchargeUpdate) & "', " 
    SQL = SQL & "    K7213_CheckUse      = N'" & FormatSQL(z7213.CheckUse) & "', " 
    SQL = SQL & "    K7213_CheckComplete      = N'" & FormatSQL(z7213.CheckComplete) & "', " 
    SQL = SQL & "    K7213_Remark      = N'" & FormatSQL(z7213.Remark) & "'  " 
    SQL = SQL & " WHERE K7213_Autokey		 =  " & z7213.Autokey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7213 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7213",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7213(z7213 As T7213_AREA) As Boolean
    DELETE_PFK7213 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7213 "
    SQL = SQL & " WHERE K7213_Autokey		 =  " & z7213.Autokey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7213 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7213",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7213_CLEAR()
Try
    
    D7213.Autokey = 0 
   D7213.Article = ""
   D7213.CartonCode = ""
   D7213.CartonCode_Mix = ""
   D7213.CustomerCode = ""
    D7213.FromSize = 0 
    D7213.ToSize = 0 
    D7213.CTQty = 0 
    D7213.CTQty_Mix = 0 
    D7213.ArtWeight = 0 
   D7213.DateInsert = ""
   D7213.DateUpdate = ""
   D7213.InchargeInsert = ""
   D7213.InchargeUpdate = ""
   D7213.CheckUse = ""
   D7213.CheckComplete = ""
   D7213.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7213_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7213 As T7213_AREA)
Try
    
    x7213.Autokey = trim$(  x7213.Autokey)
    x7213.Article = trim$(  x7213.Article)
    x7213.CartonCode = trim$(  x7213.CartonCode)
    x7213.CartonCode_Mix = trim$(  x7213.CartonCode_Mix)
    x7213.CustomerCode = trim$(  x7213.CustomerCode)
    x7213.FromSize = trim$(  x7213.FromSize)
    x7213.ToSize = trim$(  x7213.ToSize)
    x7213.CTQty = trim$(  x7213.CTQty)
    x7213.CTQty_Mix = trim$(  x7213.CTQty_Mix)
    x7213.ArtWeight = trim$(  x7213.ArtWeight)
    x7213.DateInsert = trim$(  x7213.DateInsert)
    x7213.DateUpdate = trim$(  x7213.DateUpdate)
    x7213.InchargeInsert = trim$(  x7213.InchargeInsert)
    x7213.InchargeUpdate = trim$(  x7213.InchargeUpdate)
    x7213.CheckUse = trim$(  x7213.CheckUse)
    x7213.CheckComplete = trim$(  x7213.CheckComplete)
    x7213.Remark = trim$(  x7213.Remark)
     
    If trim$( x7213.Autokey ) = "" Then x7213.Autokey = 0 
    If trim$( x7213.Article ) = "" Then x7213.Article = Space(1) 
    If trim$( x7213.CartonCode ) = "" Then x7213.CartonCode = Space(1) 
    If trim$( x7213.CartonCode_Mix ) = "" Then x7213.CartonCode_Mix = Space(1) 
    If trim$( x7213.CustomerCode ) = "" Then x7213.CustomerCode = Space(1) 
    If trim$( x7213.FromSize ) = "" Then x7213.FromSize = 0 
    If trim$( x7213.ToSize ) = "" Then x7213.ToSize = 0 
    If trim$( x7213.CTQty ) = "" Then x7213.CTQty = 0 
    If trim$( x7213.CTQty_Mix ) = "" Then x7213.CTQty_Mix = 0 
    If trim$( x7213.ArtWeight ) = "" Then x7213.ArtWeight = 0 
    If trim$( x7213.DateInsert ) = "" Then x7213.DateInsert = Space(1) 
    If trim$( x7213.DateUpdate ) = "" Then x7213.DateUpdate = Space(1) 
    If trim$( x7213.InchargeInsert ) = "" Then x7213.InchargeInsert = Space(1) 
    If trim$( x7213.InchargeUpdate ) = "" Then x7213.InchargeUpdate = Space(1) 
    If trim$( x7213.CheckUse ) = "" Then x7213.CheckUse = Space(1) 
    If trim$( x7213.CheckComplete ) = "" Then x7213.CheckComplete = Space(1) 
    If trim$( x7213.Remark ) = "" Then x7213.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7213_MOVE(rs7213 As SqlClient.SqlDataReader)
Try

    call D7213_CLEAR()   

    If IsdbNull(rs7213!K7213_Autokey) = False Then D7213.Autokey = Trim$(rs7213!K7213_Autokey)
    If IsdbNull(rs7213!K7213_Article) = False Then D7213.Article = Trim$(rs7213!K7213_Article)
    If IsdbNull(rs7213!K7213_CartonCode) = False Then D7213.CartonCode = Trim$(rs7213!K7213_CartonCode)
    If IsdbNull(rs7213!K7213_CartonCode_Mix) = False Then D7213.CartonCode_Mix = Trim$(rs7213!K7213_CartonCode_Mix)
    If IsdbNull(rs7213!K7213_CustomerCode) = False Then D7213.CustomerCode = Trim$(rs7213!K7213_CustomerCode)
    If IsdbNull(rs7213!K7213_FromSize) = False Then D7213.FromSize = Trim$(rs7213!K7213_FromSize)
    If IsdbNull(rs7213!K7213_ToSize) = False Then D7213.ToSize = Trim$(rs7213!K7213_ToSize)
    If IsdbNull(rs7213!K7213_CTQty) = False Then D7213.CTQty = Trim$(rs7213!K7213_CTQty)
    If IsdbNull(rs7213!K7213_CTQty_Mix) = False Then D7213.CTQty_Mix = Trim$(rs7213!K7213_CTQty_Mix)
    If IsdbNull(rs7213!K7213_ArtWeight) = False Then D7213.ArtWeight = Trim$(rs7213!K7213_ArtWeight)
    If IsdbNull(rs7213!K7213_DateInsert) = False Then D7213.DateInsert = Trim$(rs7213!K7213_DateInsert)
    If IsdbNull(rs7213!K7213_DateUpdate) = False Then D7213.DateUpdate = Trim$(rs7213!K7213_DateUpdate)
    If IsdbNull(rs7213!K7213_InchargeInsert) = False Then D7213.InchargeInsert = Trim$(rs7213!K7213_InchargeInsert)
    If IsdbNull(rs7213!K7213_InchargeUpdate) = False Then D7213.InchargeUpdate = Trim$(rs7213!K7213_InchargeUpdate)
    If IsdbNull(rs7213!K7213_CheckUse) = False Then D7213.CheckUse = Trim$(rs7213!K7213_CheckUse)
    If IsdbNull(rs7213!K7213_CheckComplete) = False Then D7213.CheckComplete = Trim$(rs7213!K7213_CheckComplete)
    If IsdbNull(rs7213!K7213_Remark) = False Then D7213.Remark = Trim$(rs7213!K7213_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7213_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7213_MOVE(rs7213 As DataRow)
Try

    call D7213_CLEAR()   

    If IsdbNull(rs7213!K7213_Autokey) = False Then D7213.Autokey = Trim$(rs7213!K7213_Autokey)
    If IsdbNull(rs7213!K7213_Article) = False Then D7213.Article = Trim$(rs7213!K7213_Article)
    If IsdbNull(rs7213!K7213_CartonCode) = False Then D7213.CartonCode = Trim$(rs7213!K7213_CartonCode)
    If IsdbNull(rs7213!K7213_CartonCode_Mix) = False Then D7213.CartonCode_Mix = Trim$(rs7213!K7213_CartonCode_Mix)
    If IsdbNull(rs7213!K7213_CustomerCode) = False Then D7213.CustomerCode = Trim$(rs7213!K7213_CustomerCode)
    If IsdbNull(rs7213!K7213_FromSize) = False Then D7213.FromSize = Trim$(rs7213!K7213_FromSize)
    If IsdbNull(rs7213!K7213_ToSize) = False Then D7213.ToSize = Trim$(rs7213!K7213_ToSize)
    If IsdbNull(rs7213!K7213_CTQty) = False Then D7213.CTQty = Trim$(rs7213!K7213_CTQty)
    If IsdbNull(rs7213!K7213_CTQty_Mix) = False Then D7213.CTQty_Mix = Trim$(rs7213!K7213_CTQty_Mix)
    If IsdbNull(rs7213!K7213_ArtWeight) = False Then D7213.ArtWeight = Trim$(rs7213!K7213_ArtWeight)
    If IsdbNull(rs7213!K7213_DateInsert) = False Then D7213.DateInsert = Trim$(rs7213!K7213_DateInsert)
    If IsdbNull(rs7213!K7213_DateUpdate) = False Then D7213.DateUpdate = Trim$(rs7213!K7213_DateUpdate)
    If IsdbNull(rs7213!K7213_InchargeInsert) = False Then D7213.InchargeInsert = Trim$(rs7213!K7213_InchargeInsert)
    If IsdbNull(rs7213!K7213_InchargeUpdate) = False Then D7213.InchargeUpdate = Trim$(rs7213!K7213_InchargeUpdate)
    If IsdbNull(rs7213!K7213_CheckUse) = False Then D7213.CheckUse = Trim$(rs7213!K7213_CheckUse)
    If IsdbNull(rs7213!K7213_CheckComplete) = False Then D7213.CheckComplete = Trim$(rs7213!K7213_CheckComplete)
    If IsdbNull(rs7213!K7213_Remark) = False Then D7213.Remark = Trim$(rs7213!K7213_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7213_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7213_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7213 As T7213_AREA, AUTOKEY AS Double) as Boolean

K7213_MOVE = False

Try
    If READ_PFK7213(AUTOKEY) = True Then
                z7213 = D7213
		K7213_MOVE = True
		else
	z7213 = nothing
     End If

     If  getColumIndex(spr,"Autokey") > -1 then z7213.Autokey = getDataM(spr, getColumIndex(spr,"Autokey"), xRow)
     If  getColumIndex(spr,"Article") > -1 then z7213.Article = getDataM(spr, getColumIndex(spr,"Article"), xRow)
     If  getColumIndex(spr,"CartonCode") > -1 then z7213.CartonCode = getDataM(spr, getColumIndex(spr,"CartonCode"), xRow)
     If  getColumIndex(spr,"CartonCode_Mix") > -1 then z7213.CartonCode_Mix = getDataM(spr, getColumIndex(spr,"CartonCode_Mix"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z7213.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"FromSize") > -1 then z7213.FromSize = getDataM(spr, getColumIndex(spr,"FromSize"), xRow)
     If  getColumIndex(spr,"ToSize") > -1 then z7213.ToSize = getDataM(spr, getColumIndex(spr,"ToSize"), xRow)
     If  getColumIndex(spr,"CTQty") > -1 then z7213.CTQty = getDataM(spr, getColumIndex(spr,"CTQty"), xRow)
     If  getColumIndex(spr,"CTQty_Mix") > -1 then z7213.CTQty_Mix = getDataM(spr, getColumIndex(spr,"CTQty_Mix"), xRow)
     If  getColumIndex(spr,"ArtWeight") > -1 then z7213.ArtWeight = getDataM(spr, getColumIndex(spr,"ArtWeight"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7213.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7213.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7213.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7213.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7213.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z7213.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7213.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7213_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7213_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7213 As T7213_AREA,CheckClear as Boolean,AUTOKEY AS Double) as Boolean

K7213_MOVE = False

Try
    If READ_PFK7213(AUTOKEY) = True Then
                z7213 = D7213
		K7213_MOVE = True
		else
	If CheckClear  = True then z7213 = nothing
     End If

     If  getColumIndex(spr,"Autokey") > -1 then z7213.Autokey = getDataM(spr, getColumIndex(spr,"Autokey"), xRow)
     If  getColumIndex(spr,"Article") > -1 then z7213.Article = getDataM(spr, getColumIndex(spr,"Article"), xRow)
     If  getColumIndex(spr,"CartonCode") > -1 then z7213.CartonCode = getDataM(spr, getColumIndex(spr,"CartonCode"), xRow)
     If  getColumIndex(spr,"CartonCode_Mix") > -1 then z7213.CartonCode_Mix = getDataM(spr, getColumIndex(spr,"CartonCode_Mix"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z7213.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"FromSize") > -1 then z7213.FromSize = getDataM(spr, getColumIndex(spr,"FromSize"), xRow)
     If  getColumIndex(spr,"ToSize") > -1 then z7213.ToSize = getDataM(spr, getColumIndex(spr,"ToSize"), xRow)
     If  getColumIndex(spr,"CTQty") > -1 then z7213.CTQty = getDataM(spr, getColumIndex(spr,"CTQty"), xRow)
     If  getColumIndex(spr,"CTQty_Mix") > -1 then z7213.CTQty_Mix = getDataM(spr, getColumIndex(spr,"CTQty_Mix"), xRow)
     If  getColumIndex(spr,"ArtWeight") > -1 then z7213.ArtWeight = getDataM(spr, getColumIndex(spr,"ArtWeight"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7213.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7213.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7213.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7213.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7213.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z7213.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7213.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7213_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7213_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7213 As T7213_AREA, Job as String, AUTOKEY AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7213_MOVE = False

Try
    If READ_PFK7213(AUTOKEY) = True Then
                z7213 = D7213
		K7213_MOVE = True
		else
	z7213 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7213")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z7213.Autokey = Children(i).Code
   Case "ARTICLE":z7213.Article = Children(i).Code
   Case "CARTONCODE":z7213.CartonCode = Children(i).Code
   Case "CARTONCODE_MIX":z7213.CartonCode_Mix = Children(i).Code
   Case "CUSTOMERCODE":z7213.CustomerCode = Children(i).Code
   Case "FROMSIZE":z7213.FromSize = Children(i).Code
   Case "TOSIZE":z7213.ToSize = Children(i).Code
   Case "CTQTY":z7213.CTQty = Children(i).Code
   Case "CTQTY_MIX":z7213.CTQty_Mix = Children(i).Code
   Case "ARTWEIGHT":z7213.ArtWeight = Children(i).Code
   Case "DATEINSERT":z7213.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7213.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7213.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7213.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7213.CheckUse = Children(i).Code
   Case "CHECKCOMPLETE":z7213.CheckComplete = Children(i).Code
   Case "REMARK":z7213.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z7213.Autokey = Children(i).Data
   Case "ARTICLE":z7213.Article = Children(i).Data
   Case "CARTONCODE":z7213.CartonCode = Children(i).Data
   Case "CARTONCODE_MIX":z7213.CartonCode_Mix = Children(i).Data
   Case "CUSTOMERCODE":z7213.CustomerCode = Children(i).Data
   Case "FROMSIZE":z7213.FromSize = Children(i).Data
   Case "TOSIZE":z7213.ToSize = Children(i).Data
   Case "CTQTY":z7213.CTQty = Children(i).Data
   Case "CTQTY_MIX":z7213.CTQty_Mix = Children(i).Data
   Case "ARTWEIGHT":z7213.ArtWeight = Children(i).Data
   Case "DATEINSERT":z7213.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7213.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7213.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7213.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7213.CheckUse = Children(i).Data
   Case "CHECKCOMPLETE":z7213.CheckComplete = Children(i).Data
   Case "REMARK":z7213.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7213_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7213_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7213 As T7213_AREA, Job as String, CheckClear as Boolean, AUTOKEY AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7213_MOVE = False

Try
    If READ_PFK7213(AUTOKEY) = True Then
                z7213 = D7213
		K7213_MOVE = True
		else
	If CheckClear  = True then z7213 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7213")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z7213.Autokey = Children(i).Code
   Case "ARTICLE":z7213.Article = Children(i).Code
   Case "CARTONCODE":z7213.CartonCode = Children(i).Code
   Case "CARTONCODE_MIX":z7213.CartonCode_Mix = Children(i).Code
   Case "CUSTOMERCODE":z7213.CustomerCode = Children(i).Code
   Case "FROMSIZE":z7213.FromSize = Children(i).Code
   Case "TOSIZE":z7213.ToSize = Children(i).Code
   Case "CTQTY":z7213.CTQty = Children(i).Code
   Case "CTQTY_MIX":z7213.CTQty_Mix = Children(i).Code
   Case "ARTWEIGHT":z7213.ArtWeight = Children(i).Code
   Case "DATEINSERT":z7213.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7213.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7213.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7213.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7213.CheckUse = Children(i).Code
   Case "CHECKCOMPLETE":z7213.CheckComplete = Children(i).Code
   Case "REMARK":z7213.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z7213.Autokey = Children(i).Data
   Case "ARTICLE":z7213.Article = Children(i).Data
   Case "CARTONCODE":z7213.CartonCode = Children(i).Data
   Case "CARTONCODE_MIX":z7213.CartonCode_Mix = Children(i).Data
   Case "CUSTOMERCODE":z7213.CustomerCode = Children(i).Data
   Case "FROMSIZE":z7213.FromSize = Children(i).Data
   Case "TOSIZE":z7213.ToSize = Children(i).Data
   Case "CTQTY":z7213.CTQty = Children(i).Data
   Case "CTQTY_MIX":z7213.CTQty_Mix = Children(i).Data
   Case "ARTWEIGHT":z7213.ArtWeight = Children(i).Data
   Case "DATEINSERT":z7213.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7213.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7213.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7213.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7213.CheckUse = Children(i).Data
   Case "CHECKCOMPLETE":z7213.CheckComplete = Children(i).Data
   Case "REMARK":z7213.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7213_MOVE",vbCritical)
End Try
End Function 
    
End Module 
