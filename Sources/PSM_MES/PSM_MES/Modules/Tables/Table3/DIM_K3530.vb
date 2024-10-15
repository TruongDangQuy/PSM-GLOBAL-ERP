'=========================================================================================================================================================
'   TABLE : (PFK3530)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K3530

Structure T3530_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	MCStandardCode	 AS String	'			char(6)		*
Public 	MCStandardName	 AS String	'			nvarchar(200)
Public 	seMachineType	 AS String	'			char(3)
Public 	cdMachineType	 AS String	'			char(3)
Public 	InsertDate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(6)
Public 	UpdateDate	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(6)
Public 	CheckUse	 AS String	'			char(1)
Public 	Remark	 AS String	'			nvarchar(100)
'=========================================================================================================================================================
End structure

Public D3530 As T3530_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK3530(MCSTANDARDCODE AS String) As Boolean
    READ_PFK3530 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3530 "
    SQL = SQL & " WHERE K3530_MCStandardCode		 = '" & MCStandardCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D3530_CLEAR: GoTo SKIP_READ_PFK3530
                
    Call K3530_MOVE(rd)
    READ_PFK3530 = True

SKIP_READ_PFK3530:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK3530",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK3530(MCSTANDARDCODE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3530 "
    SQL = SQL & " WHERE K3530_MCStandardCode		 = '" & MCStandardCode & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK3530",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK3530(z3530 As T3530_AREA) As Boolean
    WRITE_PFK3530 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z3530)
 
    SQL = " INSERT INTO PFK3530 "
    SQL = SQL & " ( "
    SQL = SQL & " K3530_MCStandardCode," 
    SQL = SQL & " K3530_MCStandardName," 
    SQL = SQL & " K3530_seMachineType," 
    SQL = SQL & " K3530_cdMachineType," 
    SQL = SQL & " K3530_InsertDate," 
    SQL = SQL & " K3530_InchargeInsert," 
    SQL = SQL & " K3530_UpdateDate," 
    SQL = SQL & " K3530_InchargeUpdate," 
    SQL = SQL & " K3530_CheckUse," 
    SQL = SQL & " K3530_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z3530.MCStandardCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3530.MCStandardName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3530.seMachineType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3530.cdMachineType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3530.InsertDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3530.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3530.UpdateDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3530.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3530.CheckUse) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3530.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK3530 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK3530",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK3530(z3530 As T3530_AREA) As Boolean
    REWRITE_PFK3530 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z3530)
   
    SQL = " UPDATE PFK3530 SET "
    SQL = SQL & "    K3530_MCStandardName      = N'" & FormatSQL(z3530.MCStandardName) & "', " 
    SQL = SQL & "    K3530_seMachineType      = N'" & FormatSQL(z3530.seMachineType) & "', " 
    SQL = SQL & "    K3530_cdMachineType      = N'" & FormatSQL(z3530.cdMachineType) & "', " 
    SQL = SQL & "    K3530_InsertDate      = N'" & FormatSQL(z3530.InsertDate) & "', " 
    SQL = SQL & "    K3530_InchargeInsert      = N'" & FormatSQL(z3530.InchargeInsert) & "', " 
    SQL = SQL & "    K3530_UpdateDate      = N'" & FormatSQL(z3530.UpdateDate) & "', " 
    SQL = SQL & "    K3530_InchargeUpdate      = N'" & FormatSQL(z3530.InchargeUpdate) & "', " 
    SQL = SQL & "    K3530_CheckUse      = N'" & FormatSQL(z3530.CheckUse) & "', " 
    SQL = SQL & "    K3530_Remark      = N'" & FormatSQL(z3530.Remark) & "'  " 
    SQL = SQL & " WHERE K3530_MCStandardCode		 = '" & z3530.MCStandardCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK3530 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK3530",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK3530(z3530 As T3530_AREA) As Boolean
    DELETE_PFK3530 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK3530 "
    SQL = SQL & " WHERE K3530_MCStandardCode		 = '" & z3530.MCStandardCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK3530 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK3530",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D3530_CLEAR()
Try
    
   D3530.MCStandardCode = ""
   D3530.MCStandardName = ""
   D3530.seMachineType = ""
   D3530.cdMachineType = ""
   D3530.InsertDate = ""
   D3530.InchargeInsert = ""
   D3530.UpdateDate = ""
   D3530.InchargeUpdate = ""
   D3530.CheckUse = ""
   D3530.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D3530_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x3530 As T3530_AREA)
Try
    
    x3530.MCStandardCode = trim$(  x3530.MCStandardCode)
    x3530.MCStandardName = trim$(  x3530.MCStandardName)
    x3530.seMachineType = trim$(  x3530.seMachineType)
    x3530.cdMachineType = trim$(  x3530.cdMachineType)
    x3530.InsertDate = trim$(  x3530.InsertDate)
    x3530.InchargeInsert = trim$(  x3530.InchargeInsert)
    x3530.UpdateDate = trim$(  x3530.UpdateDate)
    x3530.InchargeUpdate = trim$(  x3530.InchargeUpdate)
    x3530.CheckUse = trim$(  x3530.CheckUse)
    x3530.Remark = trim$(  x3530.Remark)
     
    If trim$( x3530.MCStandardCode ) = "" Then x3530.MCStandardCode = Space(1) 
    If trim$( x3530.MCStandardName ) = "" Then x3530.MCStandardName = Space(1) 
    If trim$( x3530.seMachineType ) = "" Then x3530.seMachineType = Space(1) 
    If trim$( x3530.cdMachineType ) = "" Then x3530.cdMachineType = Space(1) 
    If trim$( x3530.InsertDate ) = "" Then x3530.InsertDate = Space(1) 
    If trim$( x3530.InchargeInsert ) = "" Then x3530.InchargeInsert = Space(1) 
    If trim$( x3530.UpdateDate ) = "" Then x3530.UpdateDate = Space(1) 
    If trim$( x3530.InchargeUpdate ) = "" Then x3530.InchargeUpdate = Space(1) 
    If trim$( x3530.CheckUse ) = "" Then x3530.CheckUse = Space(1) 
    If trim$( x3530.Remark ) = "" Then x3530.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K3530_MOVE(rs3530 As SqlClient.SqlDataReader)
Try

    call D3530_CLEAR()   

    If IsdbNull(rs3530!K3530_MCStandardCode) = False Then D3530.MCStandardCode = Trim$(rs3530!K3530_MCStandardCode)
    If IsdbNull(rs3530!K3530_MCStandardName) = False Then D3530.MCStandardName = Trim$(rs3530!K3530_MCStandardName)
    If IsdbNull(rs3530!K3530_seMachineType) = False Then D3530.seMachineType = Trim$(rs3530!K3530_seMachineType)
    If IsdbNull(rs3530!K3530_cdMachineType) = False Then D3530.cdMachineType = Trim$(rs3530!K3530_cdMachineType)
    If IsdbNull(rs3530!K3530_InsertDate) = False Then D3530.InsertDate = Trim$(rs3530!K3530_InsertDate)
    If IsdbNull(rs3530!K3530_InchargeInsert) = False Then D3530.InchargeInsert = Trim$(rs3530!K3530_InchargeInsert)
    If IsdbNull(rs3530!K3530_UpdateDate) = False Then D3530.UpdateDate = Trim$(rs3530!K3530_UpdateDate)
    If IsdbNull(rs3530!K3530_InchargeUpdate) = False Then D3530.InchargeUpdate = Trim$(rs3530!K3530_InchargeUpdate)
    If IsdbNull(rs3530!K3530_CheckUse) = False Then D3530.CheckUse = Trim$(rs3530!K3530_CheckUse)
    If IsdbNull(rs3530!K3530_Remark) = False Then D3530.Remark = Trim$(rs3530!K3530_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3530_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K3530_MOVE(rs3530 As DataRow)
Try

    call D3530_CLEAR()   

    If IsdbNull(rs3530!K3530_MCStandardCode) = False Then D3530.MCStandardCode = Trim$(rs3530!K3530_MCStandardCode)
    If IsdbNull(rs3530!K3530_MCStandardName) = False Then D3530.MCStandardName = Trim$(rs3530!K3530_MCStandardName)
    If IsdbNull(rs3530!K3530_seMachineType) = False Then D3530.seMachineType = Trim$(rs3530!K3530_seMachineType)
    If IsdbNull(rs3530!K3530_cdMachineType) = False Then D3530.cdMachineType = Trim$(rs3530!K3530_cdMachineType)
    If IsdbNull(rs3530!K3530_InsertDate) = False Then D3530.InsertDate = Trim$(rs3530!K3530_InsertDate)
    If IsdbNull(rs3530!K3530_InchargeInsert) = False Then D3530.InchargeInsert = Trim$(rs3530!K3530_InchargeInsert)
    If IsdbNull(rs3530!K3530_UpdateDate) = False Then D3530.UpdateDate = Trim$(rs3530!K3530_UpdateDate)
    If IsdbNull(rs3530!K3530_InchargeUpdate) = False Then D3530.InchargeUpdate = Trim$(rs3530!K3530_InchargeUpdate)
    If IsdbNull(rs3530!K3530_CheckUse) = False Then D3530.CheckUse = Trim$(rs3530!K3530_CheckUse)
    If IsdbNull(rs3530!K3530_Remark) = False Then D3530.Remark = Trim$(rs3530!K3530_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3530_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K3530_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3530 As T3530_AREA, MCSTANDARDCODE AS String) as Boolean

K3530_MOVE = False

Try
    If READ_PFK3530(MCSTANDARDCODE) = True Then
                z3530 = D3530
		K3530_MOVE = True
		else
	z3530 = nothing
     End If

     If  getColumIndex(spr,"MCStandardCode") > -1 then z3530.MCStandardCode = getDataM(spr, getColumIndex(spr,"MCStandardCode"), xRow)
     If  getColumIndex(spr,"MCStandardName") > -1 then z3530.MCStandardName = getDataM(spr, getColumIndex(spr,"MCStandardName"), xRow)
     If  getColumIndex(spr,"seMachineType") > -1 then z3530.seMachineType = getDataM(spr, getColumIndex(spr,"seMachineType"), xRow)
     If  getColumIndex(spr,"cdMachineType") > -1 then z3530.cdMachineType = getDataM(spr, getColumIndex(spr,"cdMachineType"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z3530.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z3530.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z3530.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z3530.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z3530.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z3530.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3530_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K3530_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3530 As T3530_AREA,CheckClear as Boolean,MCSTANDARDCODE AS String) as Boolean

K3530_MOVE = False

Try
    If READ_PFK3530(MCSTANDARDCODE) = True Then
                z3530 = D3530
		K3530_MOVE = True
		else
	If CheckClear  = True then z3530 = nothing
     End If

     If  getColumIndex(spr,"MCStandardCode") > -1 then z3530.MCStandardCode = getDataM(spr, getColumIndex(spr,"MCStandardCode"), xRow)
     If  getColumIndex(spr,"MCStandardName") > -1 then z3530.MCStandardName = getDataM(spr, getColumIndex(spr,"MCStandardName"), xRow)
     If  getColumIndex(spr,"seMachineType") > -1 then z3530.seMachineType = getDataM(spr, getColumIndex(spr,"seMachineType"), xRow)
     If  getColumIndex(spr,"cdMachineType") > -1 then z3530.cdMachineType = getDataM(spr, getColumIndex(spr,"cdMachineType"), xRow)
     If  getColumIndex(spr,"InsertDate") > -1 then z3530.InsertDate = getDataM(spr, getColumIndex(spr,"InsertDate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z3530.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"UpdateDate") > -1 then z3530.UpdateDate = getDataM(spr, getColumIndex(spr,"UpdateDate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z3530.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z3530.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z3530.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3530_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K3530_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3530 As T3530_AREA, Job as String, MCSTANDARDCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3530_MOVE = False

Try
    If READ_PFK3530(MCSTANDARDCODE) = True Then
                z3530 = D3530
		K3530_MOVE = True
		else
	z3530 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3530")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "MCSTANDARDCODE":z3530.MCStandardCode = Children(i).Code
   Case "MCSTANDARDNAME":z3530.MCStandardName = Children(i).Code
   Case "SEMACHINETYPE":z3530.seMachineType = Children(i).Code
   Case "CDMACHINETYPE":z3530.cdMachineType = Children(i).Code
   Case "INSERTDATE":z3530.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z3530.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z3530.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z3530.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z3530.CheckUse = Children(i).Code
   Case "REMARK":z3530.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "MCSTANDARDCODE":z3530.MCStandardCode = Children(i).Data
   Case "MCSTANDARDNAME":z3530.MCStandardName = Children(i).Data
   Case "SEMACHINETYPE":z3530.seMachineType = Children(i).Data
   Case "CDMACHINETYPE":z3530.cdMachineType = Children(i).Data
   Case "INSERTDATE":z3530.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z3530.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z3530.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z3530.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z3530.CheckUse = Children(i).Data
   Case "REMARK":z3530.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3530_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K3530_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3530 As T3530_AREA, Job as String, CheckClear as Boolean, MCSTANDARDCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3530_MOVE = False

Try
    If READ_PFK3530(MCSTANDARDCODE) = True Then
                z3530 = D3530
		K3530_MOVE = True
		else
	If CheckClear  = True then z3530 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3530")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "MCSTANDARDCODE":z3530.MCStandardCode = Children(i).Code
   Case "MCSTANDARDNAME":z3530.MCStandardName = Children(i).Code
   Case "SEMACHINETYPE":z3530.seMachineType = Children(i).Code
   Case "CDMACHINETYPE":z3530.cdMachineType = Children(i).Code
   Case "INSERTDATE":z3530.InsertDate = Children(i).Code
   Case "INCHARGEINSERT":z3530.InchargeInsert = Children(i).Code
   Case "UPDATEDATE":z3530.UpdateDate = Children(i).Code
   Case "INCHARGEUPDATE":z3530.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z3530.CheckUse = Children(i).Code
   Case "REMARK":z3530.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "MCSTANDARDCODE":z3530.MCStandardCode = Children(i).Data
   Case "MCSTANDARDNAME":z3530.MCStandardName = Children(i).Data
   Case "SEMACHINETYPE":z3530.seMachineType = Children(i).Data
   Case "CDMACHINETYPE":z3530.cdMachineType = Children(i).Data
   Case "INSERTDATE":z3530.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z3530.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z3530.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z3530.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z3530.CheckUse = Children(i).Data
   Case "REMARK":z3530.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3530_MOVE",vbCritical)
End Try
End Function 
    
End Module 
