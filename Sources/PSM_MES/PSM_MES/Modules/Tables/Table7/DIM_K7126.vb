'=========================================================================================================================================================
'   TABLE : (PFK7126)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7126

Structure T7126_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	SBOMCode	 AS String	'			char(6)		*
Public 	SBOMSeq	 AS Double	'			decimal		*
Public 	CustomerCode	 AS String	'			char(6)
Public 	CheckUse	 AS String	'			char(1)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	Remark	 AS String	'			nvarchar(100)
'=========================================================================================================================================================
End structure

Public D7126 As T7126_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7126(SBOMCODE AS String, SBOMSEQ AS Double) As Boolean
    READ_PFK7126 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7126 "
    SQL = SQL & " WHERE K7126_SBOMCode		 = '" & SBOMCode & "' " 
    SQL = SQL & "   AND K7126_SBOMSeq		 =  " & SBOMSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7126_CLEAR: GoTo SKIP_READ_PFK7126
                
    Call K7126_MOVE(rd)
    READ_PFK7126 = True

SKIP_READ_PFK7126:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7126",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7126(SBOMCODE AS String, SBOMSEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7126 "
    SQL = SQL & " WHERE K7126_SBOMCode		 = '" & SBOMCode & "' " 
    SQL = SQL & "   AND K7126_SBOMSeq		 =  " & SBOMSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7126",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7126(z7126 As T7126_AREA) As Boolean
    WRITE_PFK7126 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7126)
 
    SQL = " INSERT INTO PFK7126 "
    SQL = SQL & " ( "
    SQL = SQL & " K7126_SBOMCode," 
    SQL = SQL & " K7126_SBOMSeq," 
    SQL = SQL & " K7126_CustomerCode," 
    SQL = SQL & " K7126_CheckUse," 
    SQL = SQL & " K7126_DateInsert," 
    SQL = SQL & " K7126_DateUpdate," 
    SQL = SQL & " K7126_InchargeInsert," 
    SQL = SQL & " K7126_InchargeUpdate," 
    SQL = SQL & " K7126_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7126.SBOMCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z7126.SBOMSeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7126.CustomerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7126.CheckUse) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7126.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7126.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7126.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7126.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7126.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7126 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7126",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7126(z7126 As T7126_AREA) As Boolean
    REWRITE_PFK7126 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7126)
   
    SQL = " UPDATE PFK7126 SET "
    SQL = SQL & "    K7126_CustomerCode      = N'" & FormatSQL(z7126.CustomerCode) & "', " 
    SQL = SQL & "    K7126_CheckUse      = N'" & FormatSQL(z7126.CheckUse) & "', " 
    SQL = SQL & "    K7126_DateInsert      = N'" & FormatSQL(z7126.DateInsert) & "', " 
    SQL = SQL & "    K7126_DateUpdate      = N'" & FormatSQL(z7126.DateUpdate) & "', " 
    SQL = SQL & "    K7126_InchargeInsert      = N'" & FormatSQL(z7126.InchargeInsert) & "', " 
    SQL = SQL & "    K7126_InchargeUpdate      = N'" & FormatSQL(z7126.InchargeUpdate) & "', " 
    SQL = SQL & "    K7126_Remark      = N'" & FormatSQL(z7126.Remark) & "'  " 
    SQL = SQL & " WHERE K7126_SBOMCode		 = '" & z7126.SBOMCode & "' " 
    SQL = SQL & "   AND K7126_SBOMSeq		 =  " & z7126.SBOMSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7126 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7126",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7126(z7126 As T7126_AREA) As Boolean
    DELETE_PFK7126 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7126 "
    SQL = SQL & " WHERE K7126_SBOMCode		 = '" & z7126.SBOMCode & "' " 
    SQL = SQL & "   AND K7126_SBOMSeq		 =  " & z7126.SBOMSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7126 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7126",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7126_CLEAR()
Try
    
   D7126.SBOMCode = ""
    D7126.SBOMSeq = 0 
   D7126.CustomerCode = ""
   D7126.CheckUse = ""
   D7126.DateInsert = ""
   D7126.DateUpdate = ""
   D7126.InchargeInsert = ""
   D7126.InchargeUpdate = ""
   D7126.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7126_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7126 As T7126_AREA)
Try
    
    x7126.SBOMCode = trim$(  x7126.SBOMCode)
    x7126.SBOMSeq = trim$(  x7126.SBOMSeq)
    x7126.CustomerCode = trim$(  x7126.CustomerCode)
    x7126.CheckUse = trim$(  x7126.CheckUse)
    x7126.DateInsert = trim$(  x7126.DateInsert)
    x7126.DateUpdate = trim$(  x7126.DateUpdate)
    x7126.InchargeInsert = trim$(  x7126.InchargeInsert)
    x7126.InchargeUpdate = trim$(  x7126.InchargeUpdate)
    x7126.Remark = trim$(  x7126.Remark)
     
    If trim$( x7126.SBOMCode ) = "" Then x7126.SBOMCode = Space(1) 
    If trim$( x7126.SBOMSeq ) = "" Then x7126.SBOMSeq = 0 
    If trim$( x7126.CustomerCode ) = "" Then x7126.CustomerCode = Space(1) 
    If trim$( x7126.CheckUse ) = "" Then x7126.CheckUse = Space(1) 
    If trim$( x7126.DateInsert ) = "" Then x7126.DateInsert = Space(1) 
    If trim$( x7126.DateUpdate ) = "" Then x7126.DateUpdate = Space(1) 
    If trim$( x7126.InchargeInsert ) = "" Then x7126.InchargeInsert = Space(1) 
    If trim$( x7126.InchargeUpdate ) = "" Then x7126.InchargeUpdate = Space(1) 
    If trim$( x7126.Remark ) = "" Then x7126.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7126_MOVE(rs7126 As SqlClient.SqlDataReader)
Try

    call D7126_CLEAR()   

    If IsdbNull(rs7126!K7126_SBOMCode) = False Then D7126.SBOMCode = Trim$(rs7126!K7126_SBOMCode)
    If IsdbNull(rs7126!K7126_SBOMSeq) = False Then D7126.SBOMSeq = Trim$(rs7126!K7126_SBOMSeq)
    If IsdbNull(rs7126!K7126_CustomerCode) = False Then D7126.CustomerCode = Trim$(rs7126!K7126_CustomerCode)
    If IsdbNull(rs7126!K7126_CheckUse) = False Then D7126.CheckUse = Trim$(rs7126!K7126_CheckUse)
    If IsdbNull(rs7126!K7126_DateInsert) = False Then D7126.DateInsert = Trim$(rs7126!K7126_DateInsert)
    If IsdbNull(rs7126!K7126_DateUpdate) = False Then D7126.DateUpdate = Trim$(rs7126!K7126_DateUpdate)
    If IsdbNull(rs7126!K7126_InchargeInsert) = False Then D7126.InchargeInsert = Trim$(rs7126!K7126_InchargeInsert)
    If IsdbNull(rs7126!K7126_InchargeUpdate) = False Then D7126.InchargeUpdate = Trim$(rs7126!K7126_InchargeUpdate)
    If IsdbNull(rs7126!K7126_Remark) = False Then D7126.Remark = Trim$(rs7126!K7126_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7126_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7126_MOVE(rs7126 As DataRow)
Try

    call D7126_CLEAR()   

    If IsdbNull(rs7126!K7126_SBOMCode) = False Then D7126.SBOMCode = Trim$(rs7126!K7126_SBOMCode)
    If IsdbNull(rs7126!K7126_SBOMSeq) = False Then D7126.SBOMSeq = Trim$(rs7126!K7126_SBOMSeq)
    If IsdbNull(rs7126!K7126_CustomerCode) = False Then D7126.CustomerCode = Trim$(rs7126!K7126_CustomerCode)
    If IsdbNull(rs7126!K7126_CheckUse) = False Then D7126.CheckUse = Trim$(rs7126!K7126_CheckUse)
    If IsdbNull(rs7126!K7126_DateInsert) = False Then D7126.DateInsert = Trim$(rs7126!K7126_DateInsert)
    If IsdbNull(rs7126!K7126_DateUpdate) = False Then D7126.DateUpdate = Trim$(rs7126!K7126_DateUpdate)
    If IsdbNull(rs7126!K7126_InchargeInsert) = False Then D7126.InchargeInsert = Trim$(rs7126!K7126_InchargeInsert)
    If IsdbNull(rs7126!K7126_InchargeUpdate) = False Then D7126.InchargeUpdate = Trim$(rs7126!K7126_InchargeUpdate)
    If IsdbNull(rs7126!K7126_Remark) = False Then D7126.Remark = Trim$(rs7126!K7126_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7126_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7126_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7126 As T7126_AREA, SBOMCODE AS String, SBOMSEQ AS Double) as Boolean

K7126_MOVE = False

Try
    If READ_PFK7126(SBOMCODE, SBOMSEQ) = True Then
                z7126 = D7126
		K7126_MOVE = True
		else
	z7126 = nothing
     End If

     If  getColumIndex(spr,"SBOMCode") > -1 then z7126.SBOMCode = getDataM(spr, getColumIndex(spr,"SBOMCode"), xRow)
     If  getColumIndex(spr,"SBOMSeq") > -1 then z7126.SBOMSeq = getDataM(spr, getColumIndex(spr,"SBOMSeq"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z7126.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7126.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7126.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7126.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7126.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7126.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7126.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7126_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7126_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7126 As T7126_AREA,CheckClear as Boolean,SBOMCODE AS String, SBOMSEQ AS Double) as Boolean

K7126_MOVE = False

Try
    If READ_PFK7126(SBOMCODE, SBOMSEQ) = True Then
                z7126 = D7126
		K7126_MOVE = True
		else
	If CheckClear  = True then z7126 = nothing
     End If

     If  getColumIndex(spr,"SBOMCode") > -1 then z7126.SBOMCode = getDataM(spr, getColumIndex(spr,"SBOMCode"), xRow)
     If  getColumIndex(spr,"SBOMSeq") > -1 then z7126.SBOMSeq = getDataM(spr, getColumIndex(spr,"SBOMSeq"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z7126.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7126.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7126.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7126.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7126.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7126.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7126.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7126_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7126_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7126 As T7126_AREA, Job as String, SBOMCODE AS String, SBOMSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7126_MOVE = False

Try
    If READ_PFK7126(SBOMCODE, SBOMSEQ) = True Then
                z7126 = D7126
		K7126_MOVE = True
		else
	z7126 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7126")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SBOMCODE":z7126.SBOMCode = Children(i).Code
   Case "SBOMSEQ":z7126.SBOMSeq = Children(i).Code
   Case "CUSTOMERCODE":z7126.CustomerCode = Children(i).Code
   Case "CHECKUSE":z7126.CheckUse = Children(i).Code
   Case "DATEINSERT":z7126.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7126.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7126.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7126.InchargeUpdate = Children(i).Code
   Case "REMARK":z7126.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SBOMCODE":z7126.SBOMCode = Children(i).Data
   Case "SBOMSEQ":z7126.SBOMSeq = Children(i).Data
   Case "CUSTOMERCODE":z7126.CustomerCode = Children(i).Data
   Case "CHECKUSE":z7126.CheckUse = Children(i).Data
   Case "DATEINSERT":z7126.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7126.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7126.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7126.InchargeUpdate = Children(i).Data
   Case "REMARK":z7126.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7126_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7126_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7126 As T7126_AREA, Job as String, CheckClear as Boolean, SBOMCODE AS String, SBOMSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7126_MOVE = False

Try
    If READ_PFK7126(SBOMCODE, SBOMSEQ) = True Then
                z7126 = D7126
		K7126_MOVE = True
		else
	If CheckClear  = True then z7126 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7126")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SBOMCODE":z7126.SBOMCode = Children(i).Code
   Case "SBOMSEQ":z7126.SBOMSeq = Children(i).Code
   Case "CUSTOMERCODE":z7126.CustomerCode = Children(i).Code
   Case "CHECKUSE":z7126.CheckUse = Children(i).Code
   Case "DATEINSERT":z7126.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7126.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7126.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7126.InchargeUpdate = Children(i).Code
   Case "REMARK":z7126.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SBOMCODE":z7126.SBOMCode = Children(i).Data
   Case "SBOMSEQ":z7126.SBOMSeq = Children(i).Data
   Case "CUSTOMERCODE":z7126.CustomerCode = Children(i).Data
   Case "CHECKUSE":z7126.CheckUse = Children(i).Data
   Case "DATEINSERT":z7126.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7126.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7126.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7126.InchargeUpdate = Children(i).Data
   Case "REMARK":z7126.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7126_MOVE",vbCritical)
End Try
End Function 
    
End Module 
