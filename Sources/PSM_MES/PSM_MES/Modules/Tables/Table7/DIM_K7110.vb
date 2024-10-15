'=========================================================================================================================================================
'   TABLE : (PFK7110)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7110

Structure T7110_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	BaseComponentBOM	 AS String	'			char(6)		*
Public 	ShoesCode	 AS String	'			char(6)		*
Public 	BaseName	 AS String	'			nvarchar(50)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	CheckUse	 AS String	'			char(1)
Public 	Remark	 AS String	'			nvarchar(200)
'=========================================================================================================================================================
End structure

Public D7110 As T7110_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7110(BASECOMPONENTBOM AS String, SHOESCODE AS String) As Boolean
    READ_PFK7110 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7110 "
    SQL = SQL & " WHERE K7110_BaseComponentBOM		 = '" & BaseComponentBOM & "' " 
    SQL = SQL & "   AND K7110_ShoesCode		 = '" & ShoesCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7110_CLEAR: GoTo SKIP_READ_PFK7110
                
    Call K7110_MOVE(rd)
    READ_PFK7110 = True

SKIP_READ_PFK7110:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7110",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7110(BASECOMPONENTBOM AS String, SHOESCODE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7110 "
    SQL = SQL & " WHERE K7110_BaseComponentBOM		 = '" & BaseComponentBOM & "' " 
    SQL = SQL & "   AND K7110_ShoesCode		 = '" & ShoesCode & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7110",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7110(z7110 As T7110_AREA) As Boolean
    WRITE_PFK7110 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7110)
 
    SQL = " INSERT INTO PFK7110 "
    SQL = SQL & " ( "
    SQL = SQL & " K7110_BaseComponentBOM," 
    SQL = SQL & " K7110_ShoesCode," 
    SQL = SQL & " K7110_BaseName," 
    SQL = SQL & " K7110_DateInsert," 
    SQL = SQL & " K7110_DateUpdate," 
    SQL = SQL & " K7110_InchargeInsert," 
    SQL = SQL & " K7110_InchargeUpdate," 
    SQL = SQL & " K7110_CheckUse," 
    SQL = SQL & " K7110_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7110.BaseComponentBOM) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7110.ShoesCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7110.BaseName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7110.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7110.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7110.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7110.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7110.CheckUse) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7110.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7110 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7110",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7110(z7110 As T7110_AREA) As Boolean
    REWRITE_PFK7110 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7110)
   
    SQL = " UPDATE PFK7110 SET "
    SQL = SQL & "    K7110_BaseName      = N'" & FormatSQL(z7110.BaseName) & "', " 
    SQL = SQL & "    K7110_DateInsert      = N'" & FormatSQL(z7110.DateInsert) & "', " 
    SQL = SQL & "    K7110_DateUpdate      = N'" & FormatSQL(z7110.DateUpdate) & "', " 
    SQL = SQL & "    K7110_InchargeInsert      = N'" & FormatSQL(z7110.InchargeInsert) & "', " 
    SQL = SQL & "    K7110_InchargeUpdate      = N'" & FormatSQL(z7110.InchargeUpdate) & "', " 
    SQL = SQL & "    K7110_CheckUse      = N'" & FormatSQL(z7110.CheckUse) & "', " 
    SQL = SQL & "    K7110_Remark      = N'" & FormatSQL(z7110.Remark) & "'  " 
    SQL = SQL & " WHERE K7110_BaseComponentBOM		 = '" & z7110.BaseComponentBOM & "' " 
    SQL = SQL & "   AND K7110_ShoesCode		 = '" & z7110.ShoesCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7110 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7110",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7110(z7110 As T7110_AREA) As Boolean
    DELETE_PFK7110 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7110 "
    SQL = SQL & " WHERE K7110_BaseComponentBOM		 = '" & z7110.BaseComponentBOM & "' " 
    SQL = SQL & "   AND K7110_ShoesCode		 = '" & z7110.ShoesCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7110 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7110",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7110_CLEAR()
Try
    
   D7110.BaseComponentBOM = ""
   D7110.ShoesCode = ""
   D7110.BaseName = ""
   D7110.DateInsert = ""
   D7110.DateUpdate = ""
   D7110.InchargeInsert = ""
   D7110.InchargeUpdate = ""
   D7110.CheckUse = ""
   D7110.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7110_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7110 As T7110_AREA)
Try
    
    x7110.BaseComponentBOM = trim$(  x7110.BaseComponentBOM)
    x7110.ShoesCode = trim$(  x7110.ShoesCode)
    x7110.BaseName = trim$(  x7110.BaseName)
    x7110.DateInsert = trim$(  x7110.DateInsert)
    x7110.DateUpdate = trim$(  x7110.DateUpdate)
    x7110.InchargeInsert = trim$(  x7110.InchargeInsert)
    x7110.InchargeUpdate = trim$(  x7110.InchargeUpdate)
    x7110.CheckUse = trim$(  x7110.CheckUse)
    x7110.Remark = trim$(  x7110.Remark)
     
    If trim$( x7110.BaseComponentBOM ) = "" Then x7110.BaseComponentBOM = Space(1) 
    If trim$( x7110.ShoesCode ) = "" Then x7110.ShoesCode = Space(1) 
    If trim$( x7110.BaseName ) = "" Then x7110.BaseName = Space(1) 
    If trim$( x7110.DateInsert ) = "" Then x7110.DateInsert = Space(1) 
    If trim$( x7110.DateUpdate ) = "" Then x7110.DateUpdate = Space(1) 
    If trim$( x7110.InchargeInsert ) = "" Then x7110.InchargeInsert = Space(1) 
    If trim$( x7110.InchargeUpdate ) = "" Then x7110.InchargeUpdate = Space(1) 
    If trim$( x7110.CheckUse ) = "" Then x7110.CheckUse = Space(1) 
    If trim$( x7110.Remark ) = "" Then x7110.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7110_MOVE(rs7110 As SqlClient.SqlDataReader)
Try

    call D7110_CLEAR()   

    If IsdbNull(rs7110!K7110_BaseComponentBOM) = False Then D7110.BaseComponentBOM = Trim$(rs7110!K7110_BaseComponentBOM)
    If IsdbNull(rs7110!K7110_ShoesCode) = False Then D7110.ShoesCode = Trim$(rs7110!K7110_ShoesCode)
    If IsdbNull(rs7110!K7110_BaseName) = False Then D7110.BaseName = Trim$(rs7110!K7110_BaseName)
    If IsdbNull(rs7110!K7110_DateInsert) = False Then D7110.DateInsert = Trim$(rs7110!K7110_DateInsert)
    If IsdbNull(rs7110!K7110_DateUpdate) = False Then D7110.DateUpdate = Trim$(rs7110!K7110_DateUpdate)
    If IsdbNull(rs7110!K7110_InchargeInsert) = False Then D7110.InchargeInsert = Trim$(rs7110!K7110_InchargeInsert)
    If IsdbNull(rs7110!K7110_InchargeUpdate) = False Then D7110.InchargeUpdate = Trim$(rs7110!K7110_InchargeUpdate)
    If IsdbNull(rs7110!K7110_CheckUse) = False Then D7110.CheckUse = Trim$(rs7110!K7110_CheckUse)
    If IsdbNull(rs7110!K7110_Remark) = False Then D7110.Remark = Trim$(rs7110!K7110_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7110_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7110_MOVE(rs7110 As DataRow)
Try

    call D7110_CLEAR()   

    If IsdbNull(rs7110!K7110_BaseComponentBOM) = False Then D7110.BaseComponentBOM = Trim$(rs7110!K7110_BaseComponentBOM)
    If IsdbNull(rs7110!K7110_ShoesCode) = False Then D7110.ShoesCode = Trim$(rs7110!K7110_ShoesCode)
    If IsdbNull(rs7110!K7110_BaseName) = False Then D7110.BaseName = Trim$(rs7110!K7110_BaseName)
    If IsdbNull(rs7110!K7110_DateInsert) = False Then D7110.DateInsert = Trim$(rs7110!K7110_DateInsert)
    If IsdbNull(rs7110!K7110_DateUpdate) = False Then D7110.DateUpdate = Trim$(rs7110!K7110_DateUpdate)
    If IsdbNull(rs7110!K7110_InchargeInsert) = False Then D7110.InchargeInsert = Trim$(rs7110!K7110_InchargeInsert)
    If IsdbNull(rs7110!K7110_InchargeUpdate) = False Then D7110.InchargeUpdate = Trim$(rs7110!K7110_InchargeUpdate)
    If IsdbNull(rs7110!K7110_CheckUse) = False Then D7110.CheckUse = Trim$(rs7110!K7110_CheckUse)
    If IsdbNull(rs7110!K7110_Remark) = False Then D7110.Remark = Trim$(rs7110!K7110_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7110_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7110_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7110 As T7110_AREA, BASECOMPONENTBOM AS String, SHOESCODE AS String) as Boolean

K7110_MOVE = False

Try
    If READ_PFK7110(BASECOMPONENTBOM, SHOESCODE) = True Then
                z7110 = D7110
		K7110_MOVE = True
		else
	z7110 = nothing
     End If

     If  getColumIndex(spr,"BaseComponentBOM") > -1 then z7110.BaseComponentBOM = getDataM(spr, getColumIndex(spr,"BaseComponentBOM"), xRow)
     If  getColumIndex(spr,"ShoesCode") > -1 then z7110.ShoesCode = getDataM(spr, getColumIndex(spr,"ShoesCode"), xRow)
     If  getColumIndex(spr,"BaseName") > -1 then z7110.BaseName = getDataM(spr, getColumIndex(spr,"BaseName"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7110.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7110.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7110.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7110.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7110.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7110.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7110_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7110_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7110 As T7110_AREA,CheckClear as Boolean,BASECOMPONENTBOM AS String, SHOESCODE AS String) as Boolean

K7110_MOVE = False

Try
    If READ_PFK7110(BASECOMPONENTBOM, SHOESCODE) = True Then
                z7110 = D7110
		K7110_MOVE = True
		else
	If CheckClear  = True then z7110 = nothing
     End If

     If  getColumIndex(spr,"BaseComponentBOM") > -1 then z7110.BaseComponentBOM = getDataM(spr, getColumIndex(spr,"BaseComponentBOM"), xRow)
     If  getColumIndex(spr,"ShoesCode") > -1 then z7110.ShoesCode = getDataM(spr, getColumIndex(spr,"ShoesCode"), xRow)
     If  getColumIndex(spr,"BaseName") > -1 then z7110.BaseName = getDataM(spr, getColumIndex(spr,"BaseName"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7110.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7110.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7110.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7110.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7110.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7110.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7110_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7110_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7110 As T7110_AREA, Job as String, BASECOMPONENTBOM AS String, SHOESCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7110_MOVE = False

Try
    If READ_PFK7110(BASECOMPONENTBOM, SHOESCODE) = True Then
                z7110 = D7110
		K7110_MOVE = True
		else
	z7110 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7110")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "BASECOMPONENTBOM":z7110.BaseComponentBOM = Children(i).Code
   Case "SHOESCODE":z7110.ShoesCode = Children(i).Code
   Case "BASENAME":z7110.BaseName = Children(i).Code
   Case "DATEINSERT":z7110.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7110.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7110.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7110.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7110.CheckUse = Children(i).Code
   Case "REMARK":z7110.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "BASECOMPONENTBOM":z7110.BaseComponentBOM = Children(i).Data
   Case "SHOESCODE":z7110.ShoesCode = Children(i).Data
   Case "BASENAME":z7110.BaseName = Children(i).Data
   Case "DATEINSERT":z7110.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7110.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7110.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7110.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7110.CheckUse = Children(i).Data
   Case "REMARK":z7110.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7110_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7110_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7110 As T7110_AREA, Job as String, CheckClear as Boolean, BASECOMPONENTBOM AS String, SHOESCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7110_MOVE = False

Try
    If READ_PFK7110(BASECOMPONENTBOM, SHOESCODE) = True Then
                z7110 = D7110
		K7110_MOVE = True
		else
	If CheckClear  = True then z7110 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7110")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "BASECOMPONENTBOM":z7110.BaseComponentBOM = Children(i).Code
   Case "SHOESCODE":z7110.ShoesCode = Children(i).Code
   Case "BASENAME":z7110.BaseName = Children(i).Code
   Case "DATEINSERT":z7110.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7110.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7110.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7110.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7110.CheckUse = Children(i).Code
   Case "REMARK":z7110.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "BASECOMPONENTBOM":z7110.BaseComponentBOM = Children(i).Data
   Case "SHOESCODE":z7110.ShoesCode = Children(i).Data
   Case "BASENAME":z7110.BaseName = Children(i).Data
   Case "DATEINSERT":z7110.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7110.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7110.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7110.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7110.CheckUse = Children(i).Data
   Case "REMARK":z7110.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7110_MOVE",vbCritical)
End Try
End Function 
    
End Module 
