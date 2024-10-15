'=========================================================================================================================================================
'   TABLE : (PFK7210)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7210

Structure T7210_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	CartonCode	 AS String	'			char(6)		*
Public 	CartonType	 AS String	'			nvarchar(10)
Public 	CBM	 AS Double	'			decimal
Public 	CustomerCode	 AS String	'			char(6)
Public 	CTHeight	 AS Double	'			decimal
Public 	CTLength	 AS Double	'			decimal
Public 	CTNetWeight	 AS Double	'			decimal
Public 	CTWidth	 AS Double	'			decimal
Public 	InchargeCarton	 AS String	'			char(8)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	CheckUse	 AS String	'			char(1)
Public 	CheckComplete	 AS String	'			char(1)
Public 	Remark	 AS String	'			nvarchar(50)
'=========================================================================================================================================================
End structure

Public D7210 As T7210_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7210(CARTONCODE AS String) As Boolean
    READ_PFK7210 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7210 "
    SQL = SQL & " WHERE K7210_CartonCode		 = '" & CartonCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7210_CLEAR: GoTo SKIP_READ_PFK7210
                
    Call K7210_MOVE(rd)
    READ_PFK7210 = True

SKIP_READ_PFK7210:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7210",vbCritical)
 End Try
    End Function


    Public Function READ_PFK7210_NAME(CARTONNAME As String) As Boolean
        READ_PFK7210_NAME = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7210 "
            SQL = SQL & " WHERE  K7210_CartonType		 = '" & CARTONNAME & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7210_CLEAR() : GoTo SKIP_READ_PFK7210

            Call K7210_MOVE(rd)
            READ_PFK7210_NAME = True

SKIP_READ_PFK7210:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7210_NAME", vbCritical)
        End Try
    End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7210(CARTONCODE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7210 "
    SQL = SQL & " WHERE K7210_CartonCode		 = '" & CartonCode & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7210",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7210(z7210 As T7210_AREA) As Boolean
    WRITE_PFK7210 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7210)
 
    SQL = " INSERT INTO PFK7210 "
    SQL = SQL & " ( "
    SQL = SQL & " K7210_CartonCode," 
    SQL = SQL & " K7210_CartonType," 
    SQL = SQL & " K7210_CBM," 
    SQL = SQL & " K7210_CustomerCode," 
    SQL = SQL & " K7210_CTHeight," 
    SQL = SQL & " K7210_CTLength," 
    SQL = SQL & " K7210_CTNetWeight," 
    SQL = SQL & " K7210_CTWidth," 
    SQL = SQL & " K7210_InchargeCarton," 
    SQL = SQL & " K7210_DateInsert," 
    SQL = SQL & " K7210_DateUpdate," 
    SQL = SQL & " K7210_InchargeInsert," 
    SQL = SQL & " K7210_InchargeUpdate," 
    SQL = SQL & " K7210_CheckUse," 
    SQL = SQL & " K7210_CheckComplete," 
    SQL = SQL & " K7210_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7210.CartonCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7210.CartonType) & "', "  
    SQL = SQL & "   " & FormatSQL(z7210.CBM) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7210.CustomerCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z7210.CTHeight) & ", "  
    SQL = SQL & "   " & FormatSQL(z7210.CTLength) & ", "  
    SQL = SQL & "   " & FormatSQL(z7210.CTNetWeight) & ", "  
    SQL = SQL & "   " & FormatSQL(z7210.CTWidth) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7210.InchargeCarton) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7210.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7210.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7210.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7210.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7210.CheckUse) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7210.CheckComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7210.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7210 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7210",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7210(z7210 As T7210_AREA) As Boolean
    REWRITE_PFK7210 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7210)
   
    SQL = " UPDATE PFK7210 SET "
    SQL = SQL & "    K7210_CartonType      = N'" & FormatSQL(z7210.CartonType) & "', " 
    SQL = SQL & "    K7210_CBM      =  " & FormatSQL(z7210.CBM) & ", " 
    SQL = SQL & "    K7210_CustomerCode      = N'" & FormatSQL(z7210.CustomerCode) & "', " 
    SQL = SQL & "    K7210_CTHeight      =  " & FormatSQL(z7210.CTHeight) & ", " 
    SQL = SQL & "    K7210_CTLength      =  " & FormatSQL(z7210.CTLength) & ", " 
    SQL = SQL & "    K7210_CTNetWeight      =  " & FormatSQL(z7210.CTNetWeight) & ", " 
    SQL = SQL & "    K7210_CTWidth      =  " & FormatSQL(z7210.CTWidth) & ", " 
    SQL = SQL & "    K7210_InchargeCarton      = N'" & FormatSQL(z7210.InchargeCarton) & "', " 
    SQL = SQL & "    K7210_DateInsert      = N'" & FormatSQL(z7210.DateInsert) & "', " 
    SQL = SQL & "    K7210_DateUpdate      = N'" & FormatSQL(z7210.DateUpdate) & "', " 
    SQL = SQL & "    K7210_InchargeInsert      = N'" & FormatSQL(z7210.InchargeInsert) & "', " 
    SQL = SQL & "    K7210_InchargeUpdate      = N'" & FormatSQL(z7210.InchargeUpdate) & "', " 
    SQL = SQL & "    K7210_CheckUse      = N'" & FormatSQL(z7210.CheckUse) & "', " 
    SQL = SQL & "    K7210_CheckComplete      = N'" & FormatSQL(z7210.CheckComplete) & "', " 
    SQL = SQL & "    K7210_Remark      = N'" & FormatSQL(z7210.Remark) & "'  " 
    SQL = SQL & " WHERE K7210_CartonCode		 = '" & z7210.CartonCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7210 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7210",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7210(z7210 As T7210_AREA) As Boolean
    DELETE_PFK7210 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7210 "
    SQL = SQL & " WHERE K7210_CartonCode		 = '" & z7210.CartonCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7210 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7210",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7210_CLEAR()
Try
    
   D7210.CartonCode = ""
   D7210.CartonType = ""
    D7210.CBM = 0 
   D7210.CustomerCode = ""
    D7210.CTHeight = 0 
    D7210.CTLength = 0 
    D7210.CTNetWeight = 0 
    D7210.CTWidth = 0 
   D7210.InchargeCarton = ""
   D7210.DateInsert = ""
   D7210.DateUpdate = ""
   D7210.InchargeInsert = ""
   D7210.InchargeUpdate = ""
   D7210.CheckUse = ""
   D7210.CheckComplete = ""
   D7210.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7210_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7210 As T7210_AREA)
Try
    
    x7210.CartonCode = trim$(  x7210.CartonCode)
    x7210.CartonType = trim$(  x7210.CartonType)
    x7210.CBM = trim$(  x7210.CBM)
    x7210.CustomerCode = trim$(  x7210.CustomerCode)
    x7210.CTHeight = trim$(  x7210.CTHeight)
    x7210.CTLength = trim$(  x7210.CTLength)
    x7210.CTNetWeight = trim$(  x7210.CTNetWeight)
    x7210.CTWidth = trim$(  x7210.CTWidth)
    x7210.InchargeCarton = trim$(  x7210.InchargeCarton)
    x7210.DateInsert = trim$(  x7210.DateInsert)
    x7210.DateUpdate = trim$(  x7210.DateUpdate)
    x7210.InchargeInsert = trim$(  x7210.InchargeInsert)
    x7210.InchargeUpdate = trim$(  x7210.InchargeUpdate)
    x7210.CheckUse = trim$(  x7210.CheckUse)
    x7210.CheckComplete = trim$(  x7210.CheckComplete)
    x7210.Remark = trim$(  x7210.Remark)
     
    If trim$( x7210.CartonCode ) = "" Then x7210.CartonCode = Space(1) 
    If trim$( x7210.CartonType ) = "" Then x7210.CartonType = Space(1) 
    If trim$( x7210.CBM ) = "" Then x7210.CBM = 0 
    If trim$( x7210.CustomerCode ) = "" Then x7210.CustomerCode = Space(1) 
    If trim$( x7210.CTHeight ) = "" Then x7210.CTHeight = 0 
    If trim$( x7210.CTLength ) = "" Then x7210.CTLength = 0 
    If trim$( x7210.CTNetWeight ) = "" Then x7210.CTNetWeight = 0 
    If trim$( x7210.CTWidth ) = "" Then x7210.CTWidth = 0 
    If trim$( x7210.InchargeCarton ) = "" Then x7210.InchargeCarton = Space(1) 
    If trim$( x7210.DateInsert ) = "" Then x7210.DateInsert = Space(1) 
    If trim$( x7210.DateUpdate ) = "" Then x7210.DateUpdate = Space(1) 
    If trim$( x7210.InchargeInsert ) = "" Then x7210.InchargeInsert = Space(1) 
    If trim$( x7210.InchargeUpdate ) = "" Then x7210.InchargeUpdate = Space(1) 
    If trim$( x7210.CheckUse ) = "" Then x7210.CheckUse = Space(1) 
    If trim$( x7210.CheckComplete ) = "" Then x7210.CheckComplete = Space(1) 
    If trim$( x7210.Remark ) = "" Then x7210.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7210_MOVE(rs7210 As SqlClient.SqlDataReader)
Try

    call D7210_CLEAR()   

    If IsdbNull(rs7210!K7210_CartonCode) = False Then D7210.CartonCode = Trim$(rs7210!K7210_CartonCode)
    If IsdbNull(rs7210!K7210_CartonType) = False Then D7210.CartonType = Trim$(rs7210!K7210_CartonType)
    If IsdbNull(rs7210!K7210_CBM) = False Then D7210.CBM = Trim$(rs7210!K7210_CBM)
    If IsdbNull(rs7210!K7210_CustomerCode) = False Then D7210.CustomerCode = Trim$(rs7210!K7210_CustomerCode)
    If IsdbNull(rs7210!K7210_CTHeight) = False Then D7210.CTHeight = Trim$(rs7210!K7210_CTHeight)
    If IsdbNull(rs7210!K7210_CTLength) = False Then D7210.CTLength = Trim$(rs7210!K7210_CTLength)
    If IsdbNull(rs7210!K7210_CTNetWeight) = False Then D7210.CTNetWeight = Trim$(rs7210!K7210_CTNetWeight)
    If IsdbNull(rs7210!K7210_CTWidth) = False Then D7210.CTWidth = Trim$(rs7210!K7210_CTWidth)
    If IsdbNull(rs7210!K7210_InchargeCarton) = False Then D7210.InchargeCarton = Trim$(rs7210!K7210_InchargeCarton)
    If IsdbNull(rs7210!K7210_DateInsert) = False Then D7210.DateInsert = Trim$(rs7210!K7210_DateInsert)
    If IsdbNull(rs7210!K7210_DateUpdate) = False Then D7210.DateUpdate = Trim$(rs7210!K7210_DateUpdate)
    If IsdbNull(rs7210!K7210_InchargeInsert) = False Then D7210.InchargeInsert = Trim$(rs7210!K7210_InchargeInsert)
    If IsdbNull(rs7210!K7210_InchargeUpdate) = False Then D7210.InchargeUpdate = Trim$(rs7210!K7210_InchargeUpdate)
    If IsdbNull(rs7210!K7210_CheckUse) = False Then D7210.CheckUse = Trim$(rs7210!K7210_CheckUse)
    If IsdbNull(rs7210!K7210_CheckComplete) = False Then D7210.CheckComplete = Trim$(rs7210!K7210_CheckComplete)
    If IsdbNull(rs7210!K7210_Remark) = False Then D7210.Remark = Trim$(rs7210!K7210_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7210_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7210_MOVE(rs7210 As DataRow)
Try

    call D7210_CLEAR()   

    If IsdbNull(rs7210!K7210_CartonCode) = False Then D7210.CartonCode = Trim$(rs7210!K7210_CartonCode)
    If IsdbNull(rs7210!K7210_CartonType) = False Then D7210.CartonType = Trim$(rs7210!K7210_CartonType)
    If IsdbNull(rs7210!K7210_CBM) = False Then D7210.CBM = Trim$(rs7210!K7210_CBM)
    If IsdbNull(rs7210!K7210_CustomerCode) = False Then D7210.CustomerCode = Trim$(rs7210!K7210_CustomerCode)
    If IsdbNull(rs7210!K7210_CTHeight) = False Then D7210.CTHeight = Trim$(rs7210!K7210_CTHeight)
    If IsdbNull(rs7210!K7210_CTLength) = False Then D7210.CTLength = Trim$(rs7210!K7210_CTLength)
    If IsdbNull(rs7210!K7210_CTNetWeight) = False Then D7210.CTNetWeight = Trim$(rs7210!K7210_CTNetWeight)
    If IsdbNull(rs7210!K7210_CTWidth) = False Then D7210.CTWidth = Trim$(rs7210!K7210_CTWidth)
    If IsdbNull(rs7210!K7210_InchargeCarton) = False Then D7210.InchargeCarton = Trim$(rs7210!K7210_InchargeCarton)
    If IsdbNull(rs7210!K7210_DateInsert) = False Then D7210.DateInsert = Trim$(rs7210!K7210_DateInsert)
    If IsdbNull(rs7210!K7210_DateUpdate) = False Then D7210.DateUpdate = Trim$(rs7210!K7210_DateUpdate)
    If IsdbNull(rs7210!K7210_InchargeInsert) = False Then D7210.InchargeInsert = Trim$(rs7210!K7210_InchargeInsert)
    If IsdbNull(rs7210!K7210_InchargeUpdate) = False Then D7210.InchargeUpdate = Trim$(rs7210!K7210_InchargeUpdate)
    If IsdbNull(rs7210!K7210_CheckUse) = False Then D7210.CheckUse = Trim$(rs7210!K7210_CheckUse)
    If IsdbNull(rs7210!K7210_CheckComplete) = False Then D7210.CheckComplete = Trim$(rs7210!K7210_CheckComplete)
    If IsdbNull(rs7210!K7210_Remark) = False Then D7210.Remark = Trim$(rs7210!K7210_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7210_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7210_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7210 As T7210_AREA, CARTONCODE AS String) as Boolean

K7210_MOVE = False

Try
    If READ_PFK7210(CARTONCODE) = True Then
                z7210 = D7210
		K7210_MOVE = True
		else
	z7210 = nothing
     End If

     If  getColumIndex(spr,"CartonCode") > -1 then z7210.CartonCode = getDataM(spr, getColumIndex(spr,"CartonCode"), xRow)
     If  getColumIndex(spr,"CartonType") > -1 then z7210.CartonType = getDataM(spr, getColumIndex(spr,"CartonType"), xRow)
     If  getColumIndex(spr,"CBM") > -1 then z7210.CBM = getDataM(spr, getColumIndex(spr,"CBM"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z7210.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"CTHeight") > -1 then z7210.CTHeight = getDataM(spr, getColumIndex(spr,"CTHeight"), xRow)
     If  getColumIndex(spr,"CTLength") > -1 then z7210.CTLength = getDataM(spr, getColumIndex(spr,"CTLength"), xRow)
     If  getColumIndex(spr,"CTNetWeight") > -1 then z7210.CTNetWeight = getDataM(spr, getColumIndex(spr,"CTNetWeight"), xRow)
     If  getColumIndex(spr,"CTWidth") > -1 then z7210.CTWidth = getDataM(spr, getColumIndex(spr,"CTWidth"), xRow)
     If  getColumIndex(spr,"InchargeCarton") > -1 then z7210.InchargeCarton = getDataM(spr, getColumIndex(spr,"InchargeCarton"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7210.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7210.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7210.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7210.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7210.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z7210.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7210.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7210_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7210_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7210 As T7210_AREA,CheckClear as Boolean,CARTONCODE AS String) as Boolean

K7210_MOVE = False

Try
    If READ_PFK7210(CARTONCODE) = True Then
                z7210 = D7210
		K7210_MOVE = True
		else
	If CheckClear  = True then z7210 = nothing
     End If

     If  getColumIndex(spr,"CartonCode") > -1 then z7210.CartonCode = getDataM(spr, getColumIndex(spr,"CartonCode"), xRow)
     If  getColumIndex(spr,"CartonType") > -1 then z7210.CartonType = getDataM(spr, getColumIndex(spr,"CartonType"), xRow)
     If  getColumIndex(spr,"CBM") > -1 then z7210.CBM = getDataM(spr, getColumIndex(spr,"CBM"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z7210.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"CTHeight") > -1 then z7210.CTHeight = getDataM(spr, getColumIndex(spr,"CTHeight"), xRow)
     If  getColumIndex(spr,"CTLength") > -1 then z7210.CTLength = getDataM(spr, getColumIndex(spr,"CTLength"), xRow)
     If  getColumIndex(spr,"CTNetWeight") > -1 then z7210.CTNetWeight = getDataM(spr, getColumIndex(spr,"CTNetWeight"), xRow)
     If  getColumIndex(spr,"CTWidth") > -1 then z7210.CTWidth = getDataM(spr, getColumIndex(spr,"CTWidth"), xRow)
     If  getColumIndex(spr,"InchargeCarton") > -1 then z7210.InchargeCarton = getDataM(spr, getColumIndex(spr,"InchargeCarton"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7210.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7210.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7210.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7210.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7210.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z7210.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7210.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7210_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7210_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7210 As T7210_AREA, Job as String, CARTONCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7210_MOVE = False

Try
    If READ_PFK7210(CARTONCODE) = True Then
                z7210 = D7210
		K7210_MOVE = True
		else
	z7210 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7210")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "CARTONCODE":z7210.CartonCode = Children(i).Code
   Case "CARTONTYPE":z7210.CartonType = Children(i).Code
   Case "CBM":z7210.CBM = Children(i).Code
   Case "CUSTOMERCODE":z7210.CustomerCode = Children(i).Code
   Case "CTHEIGHT":z7210.CTHeight = Children(i).Code
   Case "CTLENGTH":z7210.CTLength = Children(i).Code
   Case "CTNETWEIGHT":z7210.CTNetWeight = Children(i).Code
   Case "CTWIDTH":z7210.CTWidth = Children(i).Code
   Case "INCHARGECARTON":z7210.InchargeCarton = Children(i).Code
   Case "DATEINSERT":z7210.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7210.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7210.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7210.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7210.CheckUse = Children(i).Code
   Case "CHECKCOMPLETE":z7210.CheckComplete = Children(i).Code
   Case "REMARK":z7210.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "CARTONCODE":z7210.CartonCode = Children(i).Data
   Case "CARTONTYPE":z7210.CartonType = Children(i).Data
   Case "CBM":z7210.CBM = Children(i).Data
   Case "CUSTOMERCODE":z7210.CustomerCode = Children(i).Data
   Case "CTHEIGHT":z7210.CTHeight = Children(i).Data
   Case "CTLENGTH":z7210.CTLength = Children(i).Data
   Case "CTNETWEIGHT":z7210.CTNetWeight = Children(i).Data
   Case "CTWIDTH":z7210.CTWidth = Children(i).Data
   Case "INCHARGECARTON":z7210.InchargeCarton = Children(i).Data
   Case "DATEINSERT":z7210.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7210.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7210.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7210.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7210.CheckUse = Children(i).Data
   Case "CHECKCOMPLETE":z7210.CheckComplete = Children(i).Data
   Case "REMARK":z7210.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7210_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7210_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7210 As T7210_AREA, Job as String, CheckClear as Boolean, CARTONCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7210_MOVE = False

Try
    If READ_PFK7210(CARTONCODE) = True Then
                z7210 = D7210
		K7210_MOVE = True
		else
	If CheckClear  = True then z7210 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7210")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "CARTONCODE":z7210.CartonCode = Children(i).Code
   Case "CARTONTYPE":z7210.CartonType = Children(i).Code
   Case "CBM":z7210.CBM = Children(i).Code
   Case "CUSTOMERCODE":z7210.CustomerCode = Children(i).Code
   Case "CTHEIGHT":z7210.CTHeight = Children(i).Code
   Case "CTLENGTH":z7210.CTLength = Children(i).Code
   Case "CTNETWEIGHT":z7210.CTNetWeight = Children(i).Code
   Case "CTWIDTH":z7210.CTWidth = Children(i).Code
   Case "INCHARGECARTON":z7210.InchargeCarton = Children(i).Code
   Case "DATEINSERT":z7210.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7210.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7210.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7210.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7210.CheckUse = Children(i).Code
   Case "CHECKCOMPLETE":z7210.CheckComplete = Children(i).Code
   Case "REMARK":z7210.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "CARTONCODE":z7210.CartonCode = Children(i).Data
   Case "CARTONTYPE":z7210.CartonType = Children(i).Data
   Case "CBM":z7210.CBM = Children(i).Data
   Case "CUSTOMERCODE":z7210.CustomerCode = Children(i).Data
   Case "CTHEIGHT":z7210.CTHeight = Children(i).Data
   Case "CTLENGTH":z7210.CTLength = Children(i).Data
   Case "CTNETWEIGHT":z7210.CTNetWeight = Children(i).Data
   Case "CTWIDTH":z7210.CTWidth = Children(i).Data
   Case "INCHARGECARTON":z7210.InchargeCarton = Children(i).Data
   Case "DATEINSERT":z7210.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7210.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7210.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7210.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7210.CheckUse = Children(i).Data
   Case "CHECKCOMPLETE":z7210.CheckComplete = Children(i).Data
   Case "REMARK":z7210.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7210_MOVE",vbCritical)
End Try
End Function 
    
End Module 
