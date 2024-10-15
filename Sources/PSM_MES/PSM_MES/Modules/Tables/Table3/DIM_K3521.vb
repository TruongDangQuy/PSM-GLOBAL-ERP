'=========================================================================================================================================================
'   TABLE : (PFK3521)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K3521

Structure T3521_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	MachineTestOrder	 AS String	'			char(9)		*
Public 	MCStandardCode	 AS String	'			char(6)
Public 	DateTest	 AS String	'			char(8)
Public 	InchargeTest	 AS String	'			char(6)
Public 	DateInsert	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(6)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(6)
Public 	Remark	 AS String	'			nvarchar(100)
'=========================================================================================================================================================
End structure

Public D3521 As T3521_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK3521(MACHINETESTORDER AS String) As Boolean
    READ_PFK3521 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3521 "
    SQL = SQL & " WHERE K3521_MachineTestOrder		 = '" & MachineTestOrder & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D3521_CLEAR: GoTo SKIP_READ_PFK3521
                
    Call K3521_MOVE(rd)
    READ_PFK3521 = True

SKIP_READ_PFK3521:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK3521",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK3521(MACHINETESTORDER AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3521 "
    SQL = SQL & " WHERE K3521_MachineTestOrder		 = '" & MachineTestOrder & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK3521",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK3521(z3521 As T3521_AREA) As Boolean
    WRITE_PFK3521 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z3521)
 
    SQL = " INSERT INTO PFK3521 "
    SQL = SQL & " ( "
    SQL = SQL & " K3521_MachineTestOrder," 
    SQL = SQL & " K3521_MCStandardCode," 
    SQL = SQL & " K3521_DateTest," 
    SQL = SQL & " K3521_InchargeTest," 
    SQL = SQL & " K3521_DateInsert," 
    SQL = SQL & " K3521_InchargeInsert," 
    SQL = SQL & " K3521_DateUpdate," 
    SQL = SQL & " K3521_InchargeUpdate," 
    SQL = SQL & " K3521_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z3521.MachineTestOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3521.MCStandardCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3521.DateTest) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3521.InchargeTest) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3521.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3521.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3521.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3521.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3521.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK3521 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK3521",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK3521(z3521 As T3521_AREA) As Boolean
    REWRITE_PFK3521 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z3521)
   
    SQL = " UPDATE PFK3521 SET "
    SQL = SQL & "    K3521_MCStandardCode      = N'" & FormatSQL(z3521.MCStandardCode) & "', " 
    SQL = SQL & "    K3521_DateTest      = N'" & FormatSQL(z3521.DateTest) & "', " 
    SQL = SQL & "    K3521_InchargeTest      = N'" & FormatSQL(z3521.InchargeTest) & "', " 
    SQL = SQL & "    K3521_DateInsert      = N'" & FormatSQL(z3521.DateInsert) & "', " 
    SQL = SQL & "    K3521_InchargeInsert      = N'" & FormatSQL(z3521.InchargeInsert) & "', " 
    SQL = SQL & "    K3521_DateUpdate      = N'" & FormatSQL(z3521.DateUpdate) & "', " 
    SQL = SQL & "    K3521_InchargeUpdate      = N'" & FormatSQL(z3521.InchargeUpdate) & "', " 
    SQL = SQL & "    K3521_Remark      = N'" & FormatSQL(z3521.Remark) & "'  " 
    SQL = SQL & " WHERE K3521_MachineTestOrder		 = '" & z3521.MachineTestOrder & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK3521 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK3521",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK3521(z3521 As T3521_AREA) As Boolean
    DELETE_PFK3521 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK3521 "
    SQL = SQL & " WHERE K3521_MachineTestOrder		 = '" & z3521.MachineTestOrder & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK3521 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK3521",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D3521_CLEAR()
Try
    
   D3521.MachineTestOrder = ""
   D3521.MCStandardCode = ""
   D3521.DateTest = ""
   D3521.InchargeTest = ""
   D3521.DateInsert = ""
   D3521.InchargeInsert = ""
   D3521.DateUpdate = ""
   D3521.InchargeUpdate = ""
   D3521.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D3521_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x3521 As T3521_AREA)
Try
    
    x3521.MachineTestOrder = trim$(  x3521.MachineTestOrder)
    x3521.MCStandardCode = trim$(  x3521.MCStandardCode)
    x3521.DateTest = trim$(  x3521.DateTest)
    x3521.InchargeTest = trim$(  x3521.InchargeTest)
    x3521.DateInsert = trim$(  x3521.DateInsert)
    x3521.InchargeInsert = trim$(  x3521.InchargeInsert)
    x3521.DateUpdate = trim$(  x3521.DateUpdate)
    x3521.InchargeUpdate = trim$(  x3521.InchargeUpdate)
    x3521.Remark = trim$(  x3521.Remark)
     
    If trim$( x3521.MachineTestOrder ) = "" Then x3521.MachineTestOrder = Space(1) 
    If trim$( x3521.MCStandardCode ) = "" Then x3521.MCStandardCode = Space(1) 
    If trim$( x3521.DateTest ) = "" Then x3521.DateTest = Space(1) 
    If trim$( x3521.InchargeTest ) = "" Then x3521.InchargeTest = Space(1) 
    If trim$( x3521.DateInsert ) = "" Then x3521.DateInsert = Space(1) 
    If trim$( x3521.InchargeInsert ) = "" Then x3521.InchargeInsert = Space(1) 
    If trim$( x3521.DateUpdate ) = "" Then x3521.DateUpdate = Space(1) 
    If trim$( x3521.InchargeUpdate ) = "" Then x3521.InchargeUpdate = Space(1) 
    If trim$( x3521.Remark ) = "" Then x3521.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K3521_MOVE(rs3521 As SqlClient.SqlDataReader)
Try

    call D3521_CLEAR()   

    If IsdbNull(rs3521!K3521_MachineTestOrder) = False Then D3521.MachineTestOrder = Trim$(rs3521!K3521_MachineTestOrder)
    If IsdbNull(rs3521!K3521_MCStandardCode) = False Then D3521.MCStandardCode = Trim$(rs3521!K3521_MCStandardCode)
    If IsdbNull(rs3521!K3521_DateTest) = False Then D3521.DateTest = Trim$(rs3521!K3521_DateTest)
    If IsdbNull(rs3521!K3521_InchargeTest) = False Then D3521.InchargeTest = Trim$(rs3521!K3521_InchargeTest)
    If IsdbNull(rs3521!K3521_DateInsert) = False Then D3521.DateInsert = Trim$(rs3521!K3521_DateInsert)
    If IsdbNull(rs3521!K3521_InchargeInsert) = False Then D3521.InchargeInsert = Trim$(rs3521!K3521_InchargeInsert)
    If IsdbNull(rs3521!K3521_DateUpdate) = False Then D3521.DateUpdate = Trim$(rs3521!K3521_DateUpdate)
    If IsdbNull(rs3521!K3521_InchargeUpdate) = False Then D3521.InchargeUpdate = Trim$(rs3521!K3521_InchargeUpdate)
    If IsdbNull(rs3521!K3521_Remark) = False Then D3521.Remark = Trim$(rs3521!K3521_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3521_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K3521_MOVE(rs3521 As DataRow)
Try

    call D3521_CLEAR()   

    If IsdbNull(rs3521!K3521_MachineTestOrder) = False Then D3521.MachineTestOrder = Trim$(rs3521!K3521_MachineTestOrder)
    If IsdbNull(rs3521!K3521_MCStandardCode) = False Then D3521.MCStandardCode = Trim$(rs3521!K3521_MCStandardCode)
    If IsdbNull(rs3521!K3521_DateTest) = False Then D3521.DateTest = Trim$(rs3521!K3521_DateTest)
    If IsdbNull(rs3521!K3521_InchargeTest) = False Then D3521.InchargeTest = Trim$(rs3521!K3521_InchargeTest)
    If IsdbNull(rs3521!K3521_DateInsert) = False Then D3521.DateInsert = Trim$(rs3521!K3521_DateInsert)
    If IsdbNull(rs3521!K3521_InchargeInsert) = False Then D3521.InchargeInsert = Trim$(rs3521!K3521_InchargeInsert)
    If IsdbNull(rs3521!K3521_DateUpdate) = False Then D3521.DateUpdate = Trim$(rs3521!K3521_DateUpdate)
    If IsdbNull(rs3521!K3521_InchargeUpdate) = False Then D3521.InchargeUpdate = Trim$(rs3521!K3521_InchargeUpdate)
    If IsdbNull(rs3521!K3521_Remark) = False Then D3521.Remark = Trim$(rs3521!K3521_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3521_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K3521_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3521 As T3521_AREA, MACHINETESTORDER AS String) as Boolean

K3521_MOVE = False

Try
    If READ_PFK3521(MACHINETESTORDER) = True Then
                z3521 = D3521
		K3521_MOVE = True
		else
	z3521 = nothing
     End If

     If  getColumIndex(spr,"MachineTestOrder") > -1 then z3521.MachineTestOrder = getDataM(spr, getColumIndex(spr,"MachineTestOrder"), xRow)
     If  getColumIndex(spr,"MCStandardCode") > -1 then z3521.MCStandardCode = getDataM(spr, getColumIndex(spr,"MCStandardCode"), xRow)
     If  getColumIndex(spr,"DateTest") > -1 then z3521.DateTest = getDataM(spr, getColumIndex(spr,"DateTest"), xRow)
     If  getColumIndex(spr,"InchargeTest") > -1 then z3521.InchargeTest = getDataM(spr, getColumIndex(spr,"InchargeTest"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z3521.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z3521.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z3521.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z3521.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z3521.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3521_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K3521_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3521 As T3521_AREA,CheckClear as Boolean,MACHINETESTORDER AS String) as Boolean

K3521_MOVE = False

Try
    If READ_PFK3521(MACHINETESTORDER) = True Then
                z3521 = D3521
		K3521_MOVE = True
		else
	If CheckClear  = True then z3521 = nothing
     End If

     If  getColumIndex(spr,"MachineTestOrder") > -1 then z3521.MachineTestOrder = getDataM(spr, getColumIndex(spr,"MachineTestOrder"), xRow)
     If  getColumIndex(spr,"MCStandardCode") > -1 then z3521.MCStandardCode = getDataM(spr, getColumIndex(spr,"MCStandardCode"), xRow)
     If  getColumIndex(spr,"DateTest") > -1 then z3521.DateTest = getDataM(spr, getColumIndex(spr,"DateTest"), xRow)
     If  getColumIndex(spr,"InchargeTest") > -1 then z3521.InchargeTest = getDataM(spr, getColumIndex(spr,"InchargeTest"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z3521.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z3521.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z3521.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z3521.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z3521.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3521_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K3521_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3521 As T3521_AREA, Job as String, MACHINETESTORDER AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3521_MOVE = False

Try
    If READ_PFK3521(MACHINETESTORDER) = True Then
                z3521 = D3521
		K3521_MOVE = True
		else
	z3521 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3521")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "MACHINETESTORDER":z3521.MachineTestOrder = Children(i).Code
   Case "MCSTANDARDCODE":z3521.MCStandardCode = Children(i).Code
   Case "DATETEST":z3521.DateTest = Children(i).Code
   Case "INCHARGETEST":z3521.InchargeTest = Children(i).Code
   Case "DATEINSERT":z3521.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z3521.InchargeInsert = Children(i).Code
   Case "DATEUPDATE":z3521.DateUpdate = Children(i).Code
   Case "INCHARGEUPDATE":z3521.InchargeUpdate = Children(i).Code
   Case "REMARK":z3521.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "MACHINETESTORDER":z3521.MachineTestOrder = Children(i).Data
   Case "MCSTANDARDCODE":z3521.MCStandardCode = Children(i).Data
   Case "DATETEST":z3521.DateTest = Children(i).Data
   Case "INCHARGETEST":z3521.InchargeTest = Children(i).Data
   Case "DATEINSERT":z3521.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z3521.InchargeInsert = Children(i).Data
   Case "DATEUPDATE":z3521.DateUpdate = Children(i).Data
   Case "INCHARGEUPDATE":z3521.InchargeUpdate = Children(i).Data
   Case "REMARK":z3521.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3521_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K3521_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3521 As T3521_AREA, Job as String, CheckClear as Boolean, MACHINETESTORDER AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3521_MOVE = False

Try
    If READ_PFK3521(MACHINETESTORDER) = True Then
                z3521 = D3521
		K3521_MOVE = True
		else
	If CheckClear  = True then z3521 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3521")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "MACHINETESTORDER":z3521.MachineTestOrder = Children(i).Code
   Case "MCSTANDARDCODE":z3521.MCStandardCode = Children(i).Code
   Case "DATETEST":z3521.DateTest = Children(i).Code
   Case "INCHARGETEST":z3521.InchargeTest = Children(i).Code
   Case "DATEINSERT":z3521.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z3521.InchargeInsert = Children(i).Code
   Case "DATEUPDATE":z3521.DateUpdate = Children(i).Code
   Case "INCHARGEUPDATE":z3521.InchargeUpdate = Children(i).Code
   Case "REMARK":z3521.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "MACHINETESTORDER":z3521.MachineTestOrder = Children(i).Data
   Case "MCSTANDARDCODE":z3521.MCStandardCode = Children(i).Data
   Case "DATETEST":z3521.DateTest = Children(i).Data
   Case "INCHARGETEST":z3521.InchargeTest = Children(i).Data
   Case "DATEINSERT":z3521.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z3521.InchargeInsert = Children(i).Data
   Case "DATEUPDATE":z3521.DateUpdate = Children(i).Data
   Case "INCHARGEUPDATE":z3521.InchargeUpdate = Children(i).Data
   Case "REMARK":z3521.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3521_MOVE",vbCritical)
End Try
End Function 
    
End Module 
