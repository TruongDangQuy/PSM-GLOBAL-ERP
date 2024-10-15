'=========================================================================================================================================================
'   TABLE : (PFK2367)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K2367

Structure T2367_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	Autokey	 AS Double	'			decimal		*
Public 	JobCardWorking	 AS String	'			char(9)
Public 	MaterialCode	 AS String	'			char(6)
Public 	cdDepartment	 AS String	'			char(3)
Public 	cdLineProd	 AS String	'			char(3)
Public 	cdSubProcess	 AS String	'			char(3)
Public 	InchargeReceipt	 AS String	'			char(8)
Public 	TimeReceipt	 AS String	'			nvarchar(20)
Public 	DateRecept	 AS String	'			char(8)
Public 	QtyOutbound	 AS Double	'			decimal
Public 	QtyReceipt	 AS Double	'			decimal
Public 	QtyProduction	 AS Double	'			decimal
Public 	Remark	 AS String	'			nvarchar(250)
'=========================================================================================================================================================
End structure

Public D2367 As T2367_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK2367(AUTOKEY AS Double) As Boolean
    READ_PFK2367 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK2367 "
    SQL = SQL & " WHERE K2367_Autokey		 =  " & Autokey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D2367_CLEAR: GoTo SKIP_READ_PFK2367
                
    Call K2367_MOVE(rd)
    READ_PFK2367 = True

SKIP_READ_PFK2367:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK2367",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK2367(AUTOKEY AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK2367 "
    SQL = SQL & " WHERE K2367_Autokey		 =  " & Autokey & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK2367",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK2367(z2367 As T2367_AREA) As Boolean
    WRITE_PFK2367 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z2367)
 
    SQL = " INSERT INTO PFK2367 "
    SQL = SQL & " ( "
    SQL = SQL & " K2367_Autokey," 
    SQL = SQL & " K2367_JobCardWorking," 
    SQL = SQL & " K2367_MaterialCode," 
    SQL = SQL & " K2367_cdDepartment," 
    SQL = SQL & " K2367_cdLineProd," 
    SQL = SQL & " K2367_cdSubProcess," 
    SQL = SQL & " K2367_InchargeReceipt," 
    SQL = SQL & " K2367_TimeReceipt," 
    SQL = SQL & " K2367_DateRecept," 
    SQL = SQL & " K2367_QtyOutbound," 
    SQL = SQL & " K2367_QtyReceipt," 
    SQL = SQL & " K2367_QtyProduction," 
    SQL = SQL & " K2367_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "   " & FormatSQL(z2367.Autokey) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z2367.JobCardWorking) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2367.MaterialCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2367.cdDepartment) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2367.cdLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2367.cdSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2367.InchargeReceipt) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2367.TimeReceipt) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2367.DateRecept) & "', "  
    SQL = SQL & "   " & FormatSQL(z2367.QtyOutbound) & ", "  
    SQL = SQL & "   " & FormatSQL(z2367.QtyReceipt) & ", "  
    SQL = SQL & "   " & FormatSQL(z2367.QtyProduction) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z2367.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK2367 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK2367",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK2367(z2367 As T2367_AREA) As Boolean
    REWRITE_PFK2367 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z2367)
   
    SQL = " UPDATE PFK2367 SET "
    SQL = SQL & "    K2367_JobCardWorking      = N'" & FormatSQL(z2367.JobCardWorking) & "', " 
    SQL = SQL & "    K2367_MaterialCode      = N'" & FormatSQL(z2367.MaterialCode) & "', " 
    SQL = SQL & "    K2367_cdDepartment      = N'" & FormatSQL(z2367.cdDepartment) & "', " 
    SQL = SQL & "    K2367_cdLineProd      = N'" & FormatSQL(z2367.cdLineProd) & "', " 
    SQL = SQL & "    K2367_cdSubProcess      = N'" & FormatSQL(z2367.cdSubProcess) & "', " 
    SQL = SQL & "    K2367_InchargeReceipt      = N'" & FormatSQL(z2367.InchargeReceipt) & "', " 
    SQL = SQL & "    K2367_TimeReceipt      = N'" & FormatSQL(z2367.TimeReceipt) & "', " 
    SQL = SQL & "    K2367_DateRecept      = N'" & FormatSQL(z2367.DateRecept) & "', " 
    SQL = SQL & "    K2367_QtyOutbound      =  " & FormatSQL(z2367.QtyOutbound) & ", " 
    SQL = SQL & "    K2367_QtyReceipt      =  " & FormatSQL(z2367.QtyReceipt) & ", " 
    SQL = SQL & "    K2367_QtyProduction      =  " & FormatSQL(z2367.QtyProduction) & ", " 
    SQL = SQL & "    K2367_Remark      = N'" & FormatSQL(z2367.Remark) & "'  " 
    SQL = SQL & " WHERE K2367_Autokey		 =  " & z2367.Autokey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK2367 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK2367",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK2367(z2367 As T2367_AREA) As Boolean
    DELETE_PFK2367 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK2367 "
    SQL = SQL & " WHERE K2367_Autokey		 =  " & z2367.Autokey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK2367 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK2367",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D2367_CLEAR()
Try
    
    D2367.Autokey = 0 
   D2367.JobCardWorking = ""
   D2367.MaterialCode = ""
   D2367.cdDepartment = ""
   D2367.cdLineProd = ""
   D2367.cdSubProcess = ""
   D2367.InchargeReceipt = ""
   D2367.TimeReceipt = ""
   D2367.DateRecept = ""
    D2367.QtyOutbound = 0 
    D2367.QtyReceipt = 0 
    D2367.QtyProduction = 0 
   D2367.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D2367_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x2367 As T2367_AREA)
Try
    
    x2367.Autokey = trim$(  x2367.Autokey)
    x2367.JobCardWorking = trim$(  x2367.JobCardWorking)
    x2367.MaterialCode = trim$(  x2367.MaterialCode)
    x2367.cdDepartment = trim$(  x2367.cdDepartment)
    x2367.cdLineProd = trim$(  x2367.cdLineProd)
    x2367.cdSubProcess = trim$(  x2367.cdSubProcess)
    x2367.InchargeReceipt = trim$(  x2367.InchargeReceipt)
    x2367.TimeReceipt = trim$(  x2367.TimeReceipt)
    x2367.DateRecept = trim$(  x2367.DateRecept)
    x2367.QtyOutbound = trim$(  x2367.QtyOutbound)
    x2367.QtyReceipt = trim$(  x2367.QtyReceipt)
    x2367.QtyProduction = trim$(  x2367.QtyProduction)
    x2367.Remark = trim$(  x2367.Remark)
     
    If trim$( x2367.Autokey ) = "" Then x2367.Autokey = 0 
    If trim$( x2367.JobCardWorking ) = "" Then x2367.JobCardWorking = Space(1) 
    If trim$( x2367.MaterialCode ) = "" Then x2367.MaterialCode = Space(1) 
    If trim$( x2367.cdDepartment ) = "" Then x2367.cdDepartment = Space(1) 
    If trim$( x2367.cdLineProd ) = "" Then x2367.cdLineProd = Space(1) 
    If trim$( x2367.cdSubProcess ) = "" Then x2367.cdSubProcess = Space(1) 
    If trim$( x2367.InchargeReceipt ) = "" Then x2367.InchargeReceipt = Space(1) 
    If trim$( x2367.TimeReceipt ) = "" Then x2367.TimeReceipt = Space(1) 
    If trim$( x2367.DateRecept ) = "" Then x2367.DateRecept = Space(1) 
    If trim$( x2367.QtyOutbound ) = "" Then x2367.QtyOutbound = 0 
    If trim$( x2367.QtyReceipt ) = "" Then x2367.QtyReceipt = 0 
    If trim$( x2367.QtyProduction ) = "" Then x2367.QtyProduction = 0 
    If trim$( x2367.Remark ) = "" Then x2367.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K2367_MOVE(rs2367 As SqlClient.SqlDataReader)
Try

    call D2367_CLEAR()   

    If IsdbNull(rs2367!K2367_Autokey) = False Then D2367.Autokey = Trim$(rs2367!K2367_Autokey)
    If IsdbNull(rs2367!K2367_JobCardWorking) = False Then D2367.JobCardWorking = Trim$(rs2367!K2367_JobCardWorking)
    If IsdbNull(rs2367!K2367_MaterialCode) = False Then D2367.MaterialCode = Trim$(rs2367!K2367_MaterialCode)
    If IsdbNull(rs2367!K2367_cdDepartment) = False Then D2367.cdDepartment = Trim$(rs2367!K2367_cdDepartment)
    If IsdbNull(rs2367!K2367_cdLineProd) = False Then D2367.cdLineProd = Trim$(rs2367!K2367_cdLineProd)
    If IsdbNull(rs2367!K2367_cdSubProcess) = False Then D2367.cdSubProcess = Trim$(rs2367!K2367_cdSubProcess)
    If IsdbNull(rs2367!K2367_InchargeReceipt) = False Then D2367.InchargeReceipt = Trim$(rs2367!K2367_InchargeReceipt)
    If IsdbNull(rs2367!K2367_TimeReceipt) = False Then D2367.TimeReceipt = Trim$(rs2367!K2367_TimeReceipt)
    If IsdbNull(rs2367!K2367_DateRecept) = False Then D2367.DateRecept = Trim$(rs2367!K2367_DateRecept)
    If IsdbNull(rs2367!K2367_QtyOutbound) = False Then D2367.QtyOutbound = Trim$(rs2367!K2367_QtyOutbound)
    If IsdbNull(rs2367!K2367_QtyReceipt) = False Then D2367.QtyReceipt = Trim$(rs2367!K2367_QtyReceipt)
    If IsdbNull(rs2367!K2367_QtyProduction) = False Then D2367.QtyProduction = Trim$(rs2367!K2367_QtyProduction)
    If IsdbNull(rs2367!K2367_Remark) = False Then D2367.Remark = Trim$(rs2367!K2367_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K2367_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K2367_MOVE(rs2367 As DataRow)
Try

    call D2367_CLEAR()   

    If IsdbNull(rs2367!K2367_Autokey) = False Then D2367.Autokey = Trim$(rs2367!K2367_Autokey)
    If IsdbNull(rs2367!K2367_JobCardWorking) = False Then D2367.JobCardWorking = Trim$(rs2367!K2367_JobCardWorking)
    If IsdbNull(rs2367!K2367_MaterialCode) = False Then D2367.MaterialCode = Trim$(rs2367!K2367_MaterialCode)
    If IsdbNull(rs2367!K2367_cdDepartment) = False Then D2367.cdDepartment = Trim$(rs2367!K2367_cdDepartment)
    If IsdbNull(rs2367!K2367_cdLineProd) = False Then D2367.cdLineProd = Trim$(rs2367!K2367_cdLineProd)
    If IsdbNull(rs2367!K2367_cdSubProcess) = False Then D2367.cdSubProcess = Trim$(rs2367!K2367_cdSubProcess)
    If IsdbNull(rs2367!K2367_InchargeReceipt) = False Then D2367.InchargeReceipt = Trim$(rs2367!K2367_InchargeReceipt)
    If IsdbNull(rs2367!K2367_TimeReceipt) = False Then D2367.TimeReceipt = Trim$(rs2367!K2367_TimeReceipt)
    If IsdbNull(rs2367!K2367_DateRecept) = False Then D2367.DateRecept = Trim$(rs2367!K2367_DateRecept)
    If IsdbNull(rs2367!K2367_QtyOutbound) = False Then D2367.QtyOutbound = Trim$(rs2367!K2367_QtyOutbound)
    If IsdbNull(rs2367!K2367_QtyReceipt) = False Then D2367.QtyReceipt = Trim$(rs2367!K2367_QtyReceipt)
    If IsdbNull(rs2367!K2367_QtyProduction) = False Then D2367.QtyProduction = Trim$(rs2367!K2367_QtyProduction)
    If IsdbNull(rs2367!K2367_Remark) = False Then D2367.Remark = Trim$(rs2367!K2367_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K2367_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K2367_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z2367 As T2367_AREA, AUTOKEY AS Double) as Boolean

K2367_MOVE = False

Try
    If READ_PFK2367(AUTOKEY) = True Then
                z2367 = D2367
		K2367_MOVE = True
		else
	z2367 = nothing
     End If

     If  getColumIndex(spr,"Autokey") > -1 then z2367.Autokey = getDataM(spr, getColumIndex(spr,"Autokey"), xRow)
     If  getColumIndex(spr,"JobCardWorking") > -1 then z2367.JobCardWorking = getDataM(spr, getColumIndex(spr,"JobCardWorking"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z2367.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"cdDepartment") > -1 then z2367.cdDepartment = getDataM(spr, getColumIndex(spr,"cdDepartment"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z2367.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z2367.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"InchargeReceipt") > -1 then z2367.InchargeReceipt = getDataM(spr, getColumIndex(spr,"InchargeReceipt"), xRow)
     If  getColumIndex(spr,"TimeReceipt") > -1 then z2367.TimeReceipt = getDataM(spr, getColumIndex(spr,"TimeReceipt"), xRow)
     If  getColumIndex(spr,"DateRecept") > -1 then z2367.DateRecept = getDataM(spr, getColumIndex(spr,"DateRecept"), xRow)
     If  getColumIndex(spr,"QtyOutbound") > -1 then z2367.QtyOutbound = getDataM(spr, getColumIndex(spr,"QtyOutbound"), xRow)
     If  getColumIndex(spr,"QtyReceipt") > -1 then z2367.QtyReceipt = getDataM(spr, getColumIndex(spr,"QtyReceipt"), xRow)
     If  getColumIndex(spr,"QtyProduction") > -1 then z2367.QtyProduction = getDataM(spr, getColumIndex(spr,"QtyProduction"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z2367.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K2367_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K2367_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z2367 As T2367_AREA,CheckClear as Boolean,AUTOKEY AS Double) as Boolean

K2367_MOVE = False

Try
    If READ_PFK2367(AUTOKEY) = True Then
                z2367 = D2367
		K2367_MOVE = True
		else
	If CheckClear  = True then z2367 = nothing
     End If

     If  getColumIndex(spr,"Autokey") > -1 then z2367.Autokey = getDataM(spr, getColumIndex(spr,"Autokey"), xRow)
     If  getColumIndex(spr,"JobCardWorking") > -1 then z2367.JobCardWorking = getDataM(spr, getColumIndex(spr,"JobCardWorking"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z2367.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"cdDepartment") > -1 then z2367.cdDepartment = getDataM(spr, getColumIndex(spr,"cdDepartment"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z2367.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z2367.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"InchargeReceipt") > -1 then z2367.InchargeReceipt = getDataM(spr, getColumIndex(spr,"InchargeReceipt"), xRow)
     If  getColumIndex(spr,"TimeReceipt") > -1 then z2367.TimeReceipt = getDataM(spr, getColumIndex(spr,"TimeReceipt"), xRow)
     If  getColumIndex(spr,"DateRecept") > -1 then z2367.DateRecept = getDataM(spr, getColumIndex(spr,"DateRecept"), xRow)
     If  getColumIndex(spr,"QtyOutbound") > -1 then z2367.QtyOutbound = getDataM(spr, getColumIndex(spr,"QtyOutbound"), xRow)
     If  getColumIndex(spr,"QtyReceipt") > -1 then z2367.QtyReceipt = getDataM(spr, getColumIndex(spr,"QtyReceipt"), xRow)
     If  getColumIndex(spr,"QtyProduction") > -1 then z2367.QtyProduction = getDataM(spr, getColumIndex(spr,"QtyProduction"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z2367.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K2367_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K2367_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z2367 As T2367_AREA, Job as String, AUTOKEY AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K2367_MOVE = False

Try
    If READ_PFK2367(AUTOKEY) = True Then
                z2367 = D2367
		K2367_MOVE = True
		else
	z2367 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2367")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z2367.Autokey = Children(i).Code
   Case "JOBCARDWORKING":z2367.JobCardWorking = Children(i).Code
   Case "MATERIALCODE":z2367.MaterialCode = Children(i).Code
   Case "CDDEPARTMENT":z2367.cdDepartment = Children(i).Code
   Case "CDLINEPROD":z2367.cdLineProd = Children(i).Code
   Case "CDSUBPROCESS":z2367.cdSubProcess = Children(i).Code
   Case "INCHARGERECEIPT":z2367.InchargeReceipt = Children(i).Code
   Case "TIMERECEIPT":z2367.TimeReceipt = Children(i).Code
   Case "DATERECEPT":z2367.DateRecept = Children(i).Code
   Case "QTYOUTBOUND":z2367.QtyOutbound = Children(i).Code
   Case "QTYRECEIPT":z2367.QtyReceipt = Children(i).Code
   Case "QTYPRODUCTION":z2367.QtyProduction = Children(i).Code
   Case "REMARK":z2367.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z2367.Autokey = Children(i).Data
   Case "JOBCARDWORKING":z2367.JobCardWorking = Children(i).Data
   Case "MATERIALCODE":z2367.MaterialCode = Children(i).Data
   Case "CDDEPARTMENT":z2367.cdDepartment = Children(i).Data
   Case "CDLINEPROD":z2367.cdLineProd = Children(i).Data
   Case "CDSUBPROCESS":z2367.cdSubProcess = Children(i).Data
   Case "INCHARGERECEIPT":z2367.InchargeReceipt = Children(i).Data
   Case "TIMERECEIPT":z2367.TimeReceipt = Children(i).Data
   Case "DATERECEPT":z2367.DateRecept = Children(i).Data
   Case "QTYOUTBOUND":z2367.QtyOutbound = Children(i).Data
   Case "QTYRECEIPT":z2367.QtyReceipt = Children(i).Data
   Case "QTYPRODUCTION":z2367.QtyProduction = Children(i).Data
   Case "REMARK":z2367.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K2367_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K2367_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z2367 As T2367_AREA, Job as String, CheckClear as Boolean, AUTOKEY AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K2367_MOVE = False

Try
    If READ_PFK2367(AUTOKEY) = True Then
                z2367 = D2367
		K2367_MOVE = True
		else
	If CheckClear  = True then z2367 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2367")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z2367.Autokey = Children(i).Code
   Case "JOBCARDWORKING":z2367.JobCardWorking = Children(i).Code
   Case "MATERIALCODE":z2367.MaterialCode = Children(i).Code
   Case "CDDEPARTMENT":z2367.cdDepartment = Children(i).Code
   Case "CDLINEPROD":z2367.cdLineProd = Children(i).Code
   Case "CDSUBPROCESS":z2367.cdSubProcess = Children(i).Code
   Case "INCHARGERECEIPT":z2367.InchargeReceipt = Children(i).Code
   Case "TIMERECEIPT":z2367.TimeReceipt = Children(i).Code
   Case "DATERECEPT":z2367.DateRecept = Children(i).Code
   Case "QTYOUTBOUND":z2367.QtyOutbound = Children(i).Code
   Case "QTYRECEIPT":z2367.QtyReceipt = Children(i).Code
   Case "QTYPRODUCTION":z2367.QtyProduction = Children(i).Code
   Case "REMARK":z2367.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z2367.Autokey = Children(i).Data
   Case "JOBCARDWORKING":z2367.JobCardWorking = Children(i).Data
   Case "MATERIALCODE":z2367.MaterialCode = Children(i).Data
   Case "CDDEPARTMENT":z2367.cdDepartment = Children(i).Data
   Case "CDLINEPROD":z2367.cdLineProd = Children(i).Data
   Case "CDSUBPROCESS":z2367.cdSubProcess = Children(i).Data
   Case "INCHARGERECEIPT":z2367.InchargeReceipt = Children(i).Data
   Case "TIMERECEIPT":z2367.TimeReceipt = Children(i).Data
   Case "DATERECEPT":z2367.DateRecept = Children(i).Data
   Case "QTYOUTBOUND":z2367.QtyOutbound = Children(i).Data
   Case "QTYRECEIPT":z2367.QtyReceipt = Children(i).Data
   Case "QTYPRODUCTION":z2367.QtyProduction = Children(i).Data
   Case "REMARK":z2367.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K2367_MOVE",vbCritical)
End Try
End Function 
    
End Module 
