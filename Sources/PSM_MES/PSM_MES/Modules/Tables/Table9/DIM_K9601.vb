'=========================================================================================================================================================
'   TABLE : (PFK9601)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K9601

Structure T9601_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	seFactory	 AS String	'			char(3)		*
Public 	cdFactory	 AS String	'			char(3)		*
Public 	seSubProcess	 AS String	'			char(3)		*
Public 	cdSubProcess	 AS String	'			char(3)		*
Public 	DateTarget	 AS String	'			char(6)		*
Public 	QtyTarget	 AS Double	'			decimal
Public 	QtyActual	 AS Double	'			decimal
Public 	AmtTarget	 AS Double	'			decimal
Public 	AmtActual	 AS Double	'			decimal
'=========================================================================================================================================================
End structure

Public D9601 As T9601_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK9601(SEFACTORY AS String, CDFACTORY AS String, SESUBPROCESS AS String, CDSUBPROCESS AS String, DATETARGET AS String) As Boolean
    READ_PFK9601 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9601 "
    SQL = SQL & " WHERE K9601_seFactory		 = '" & seFactory & "' " 
    SQL = SQL & "   AND K9601_cdFactory		 = '" & cdFactory & "' " 
    SQL = SQL & "   AND K9601_seSubProcess		 = '" & seSubProcess & "' " 
    SQL = SQL & "   AND K9601_cdSubProcess		 = '" & cdSubProcess & "' " 
    SQL = SQL & "   AND K9601_DateTarget		 = '" & DateTarget & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D9601_CLEAR: GoTo SKIP_READ_PFK9601
                
    Call K9601_MOVE(rd)
    READ_PFK9601 = True

SKIP_READ_PFK9601:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK9601",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK9601(SEFACTORY AS String, CDFACTORY AS String, SESUBPROCESS AS String, CDSUBPROCESS AS String, DATETARGET AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9601 "
    SQL = SQL & " WHERE K9601_seFactory		 = '" & seFactory & "' " 
    SQL = SQL & "   AND K9601_cdFactory		 = '" & cdFactory & "' " 
    SQL = SQL & "   AND K9601_seSubProcess		 = '" & seSubProcess & "' " 
    SQL = SQL & "   AND K9601_cdSubProcess		 = '" & cdSubProcess & "' " 
    SQL = SQL & "   AND K9601_DateTarget		 = '" & DateTarget & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK9601",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK9601(z9601 As T9601_AREA) As Boolean
    WRITE_PFK9601 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z9601)
 
    SQL = " INSERT INTO PFK9601 "
    SQL = SQL & " ( "
    SQL = SQL & " K9601_seFactory," 
    SQL = SQL & " K9601_cdFactory," 
    SQL = SQL & " K9601_seSubProcess," 
    SQL = SQL & " K9601_cdSubProcess," 
    SQL = SQL & " K9601_DateTarget," 
    SQL = SQL & " K9601_QtyTarget," 
    SQL = SQL & " K9601_QtyActual," 
    SQL = SQL & " K9601_AmtTarget," 
    SQL = SQL & " K9601_AmtActual " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z9601.seFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9601.cdFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9601.seSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9601.cdSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9601.DateTarget) & "', "  
    SQL = SQL & "   " & FormatSQL(z9601.QtyTarget) & ", "  
    SQL = SQL & "   " & FormatSQL(z9601.QtyActual) & ", "  
    SQL = SQL & "   " & FormatSQL(z9601.AmtTarget) & ", "  
    SQL = SQL & "   " & FormatSQL(z9601.AmtActual) & "  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK9601 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK9601",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK9601(z9601 As T9601_AREA) As Boolean
    REWRITE_PFK9601 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z9601)
   
    SQL = " UPDATE PFK9601 SET "
    SQL = SQL & "    K9601_QtyTarget      =  " & FormatSQL(z9601.QtyTarget) & ", " 
    SQL = SQL & "    K9601_QtyActual      =  " & FormatSQL(z9601.QtyActual) & ", " 
    SQL = SQL & "    K9601_AmtTarget      =  " & FormatSQL(z9601.AmtTarget) & ", " 
    SQL = SQL & "    K9601_AmtActual      =  " & FormatSQL(z9601.AmtActual) & "  " 
    SQL = SQL & " WHERE K9601_seFactory		 = '" & z9601.seFactory & "' " 
    SQL = SQL & "   AND K9601_cdFactory		 = '" & z9601.cdFactory & "' " 
    SQL = SQL & "   AND K9601_seSubProcess		 = '" & z9601.seSubProcess & "' " 
    SQL = SQL & "   AND K9601_cdSubProcess		 = '" & z9601.cdSubProcess & "' " 
    SQL = SQL & "   AND K9601_DateTarget		 = '" & z9601.DateTarget & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK9601 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK9601",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK9601(z9601 As T9601_AREA) As Boolean
    DELETE_PFK9601 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK9601 "
    SQL = SQL & " WHERE K9601_seFactory		 = '" & z9601.seFactory & "' " 
    SQL = SQL & "   AND K9601_cdFactory		 = '" & z9601.cdFactory & "' " 
    SQL = SQL & "   AND K9601_seSubProcess		 = '" & z9601.seSubProcess & "' " 
    SQL = SQL & "   AND K9601_cdSubProcess		 = '" & z9601.cdSubProcess & "' " 
    SQL = SQL & "   AND K9601_DateTarget		 = '" & z9601.DateTarget & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK9601 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK9601",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D9601_CLEAR()
Try
    
   D9601.seFactory = ""
   D9601.cdFactory = ""
   D9601.seSubProcess = ""
   D9601.cdSubProcess = ""
   D9601.DateTarget = ""
    D9601.QtyTarget = 0 
    D9601.QtyActual = 0 
    D9601.AmtTarget = 0 
    D9601.AmtActual = 0 

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D9601_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x9601 As T9601_AREA)
Try
    
    x9601.seFactory = trim$(  x9601.seFactory)
    x9601.cdFactory = trim$(  x9601.cdFactory)
    x9601.seSubProcess = trim$(  x9601.seSubProcess)
    x9601.cdSubProcess = trim$(  x9601.cdSubProcess)
    x9601.DateTarget = trim$(  x9601.DateTarget)
    x9601.QtyTarget = trim$(  x9601.QtyTarget)
    x9601.QtyActual = trim$(  x9601.QtyActual)
    x9601.AmtTarget = trim$(  x9601.AmtTarget)
    x9601.AmtActual = trim$(  x9601.AmtActual)
     
    If trim$( x9601.seFactory ) = "" Then x9601.seFactory = Space(1) 
    If trim$( x9601.cdFactory ) = "" Then x9601.cdFactory = Space(1) 
    If trim$( x9601.seSubProcess ) = "" Then x9601.seSubProcess = Space(1) 
    If trim$( x9601.cdSubProcess ) = "" Then x9601.cdSubProcess = Space(1) 
    If trim$( x9601.DateTarget ) = "" Then x9601.DateTarget = Space(1) 
    If trim$( x9601.QtyTarget ) = "" Then x9601.QtyTarget = 0 
    If trim$( x9601.QtyActual ) = "" Then x9601.QtyActual = 0 
    If trim$( x9601.AmtTarget ) = "" Then x9601.AmtTarget = 0 
    If trim$( x9601.AmtActual ) = "" Then x9601.AmtActual = 0 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K9601_MOVE(rs9601 As SqlClient.SqlDataReader)
Try

    call D9601_CLEAR()   

    If IsdbNull(rs9601!K9601_seFactory) = False Then D9601.seFactory = Trim$(rs9601!K9601_seFactory)
    If IsdbNull(rs9601!K9601_cdFactory) = False Then D9601.cdFactory = Trim$(rs9601!K9601_cdFactory)
    If IsdbNull(rs9601!K9601_seSubProcess) = False Then D9601.seSubProcess = Trim$(rs9601!K9601_seSubProcess)
    If IsdbNull(rs9601!K9601_cdSubProcess) = False Then D9601.cdSubProcess = Trim$(rs9601!K9601_cdSubProcess)
    If IsdbNull(rs9601!K9601_DateTarget) = False Then D9601.DateTarget = Trim$(rs9601!K9601_DateTarget)
    If IsdbNull(rs9601!K9601_QtyTarget) = False Then D9601.QtyTarget = Trim$(rs9601!K9601_QtyTarget)
    If IsdbNull(rs9601!K9601_QtyActual) = False Then D9601.QtyActual = Trim$(rs9601!K9601_QtyActual)
    If IsdbNull(rs9601!K9601_AmtTarget) = False Then D9601.AmtTarget = Trim$(rs9601!K9601_AmtTarget)
    If IsdbNull(rs9601!K9601_AmtActual) = False Then D9601.AmtActual = Trim$(rs9601!K9601_AmtActual)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9601_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K9601_MOVE(rs9601 As DataRow)
Try

    call D9601_CLEAR()   

    If IsdbNull(rs9601!K9601_seFactory) = False Then D9601.seFactory = Trim$(rs9601!K9601_seFactory)
    If IsdbNull(rs9601!K9601_cdFactory) = False Then D9601.cdFactory = Trim$(rs9601!K9601_cdFactory)
    If IsdbNull(rs9601!K9601_seSubProcess) = False Then D9601.seSubProcess = Trim$(rs9601!K9601_seSubProcess)
    If IsdbNull(rs9601!K9601_cdSubProcess) = False Then D9601.cdSubProcess = Trim$(rs9601!K9601_cdSubProcess)
    If IsdbNull(rs9601!K9601_DateTarget) = False Then D9601.DateTarget = Trim$(rs9601!K9601_DateTarget)
    If IsdbNull(rs9601!K9601_QtyTarget) = False Then D9601.QtyTarget = Trim$(rs9601!K9601_QtyTarget)
    If IsdbNull(rs9601!K9601_QtyActual) = False Then D9601.QtyActual = Trim$(rs9601!K9601_QtyActual)
    If IsdbNull(rs9601!K9601_AmtTarget) = False Then D9601.AmtTarget = Trim$(rs9601!K9601_AmtTarget)
    If IsdbNull(rs9601!K9601_AmtActual) = False Then D9601.AmtActual = Trim$(rs9601!K9601_AmtActual)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9601_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K9601_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9601 As T9601_AREA, SEFACTORY AS String, CDFACTORY AS String, SESUBPROCESS AS String, CDSUBPROCESS AS String, DATETARGET AS String) as Boolean

K9601_MOVE = False

Try
    If READ_PFK9601(SEFACTORY, CDFACTORY, SESUBPROCESS, CDSUBPROCESS, DATETARGET) = True Then
                z9601 = D9601
		K9601_MOVE = True
		else
	z9601 = nothing
     End If

     If  getColumIndex(spr,"seFactory") > -1 then z9601.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"cdFactory") > -1 then z9601.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z9601.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z9601.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"DateTarget") > -1 then z9601.DateTarget = getDataM(spr, getColumIndex(spr,"DateTarget"), xRow)
     If  getColumIndex(spr,"QtyTarget") > -1 then z9601.QtyTarget = getDataM(spr, getColumIndex(spr,"QtyTarget"), xRow)
     If  getColumIndex(spr,"QtyActual") > -1 then z9601.QtyActual = getDataM(spr, getColumIndex(spr,"QtyActual"), xRow)
     If  getColumIndex(spr,"AmtTarget") > -1 then z9601.AmtTarget = getDataM(spr, getColumIndex(spr,"AmtTarget"), xRow)
     If  getColumIndex(spr,"AmtActual") > -1 then z9601.AmtActual = getDataM(spr, getColumIndex(spr,"AmtActual"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K9601_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K9601_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9601 As T9601_AREA,CheckClear as Boolean,SEFACTORY AS String, CDFACTORY AS String, SESUBPROCESS AS String, CDSUBPROCESS AS String, DATETARGET AS String) as Boolean

K9601_MOVE = False

Try
    If READ_PFK9601(SEFACTORY, CDFACTORY, SESUBPROCESS, CDSUBPROCESS, DATETARGET) = True Then
                z9601 = D9601
		K9601_MOVE = True
		else
	If CheckClear  = True then z9601 = nothing
     End If

     If  getColumIndex(spr,"seFactory") > -1 then z9601.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"cdFactory") > -1 then z9601.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z9601.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z9601.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"DateTarget") > -1 then z9601.DateTarget = getDataM(spr, getColumIndex(spr,"DateTarget"), xRow)
     If  getColumIndex(spr,"QtyTarget") > -1 then z9601.QtyTarget = getDataM(spr, getColumIndex(spr,"QtyTarget"), xRow)
     If  getColumIndex(spr,"QtyActual") > -1 then z9601.QtyActual = getDataM(spr, getColumIndex(spr,"QtyActual"), xRow)
     If  getColumIndex(spr,"AmtTarget") > -1 then z9601.AmtTarget = getDataM(spr, getColumIndex(spr,"AmtTarget"), xRow)
     If  getColumIndex(spr,"AmtActual") > -1 then z9601.AmtActual = getDataM(spr, getColumIndex(spr,"AmtActual"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K9601_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K9601_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9601 As T9601_AREA, Job as String, SEFACTORY AS String, CDFACTORY AS String, SESUBPROCESS AS String, CDSUBPROCESS AS String, DATETARGET AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9601_MOVE = False

Try
    If READ_PFK9601(SEFACTORY, CDFACTORY, SESUBPROCESS, CDSUBPROCESS, DATETARGET) = True Then
                z9601 = D9601
		K9601_MOVE = True
		else
	z9601 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9601")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SEFACTORY":z9601.seFactory = Children(i).Code
   Case "CDFACTORY":z9601.cdFactory = Children(i).Code
   Case "SESUBPROCESS":z9601.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z9601.cdSubProcess = Children(i).Code
   Case "DATETARGET":z9601.DateTarget = Children(i).Code
   Case "QTYTARGET":z9601.QtyTarget = Children(i).Code
   Case "QTYACTUAL":z9601.QtyActual = Children(i).Code
   Case "AMTTARGET":z9601.AmtTarget = Children(i).Code
   Case "AMTACTUAL":z9601.AmtActual = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SEFACTORY":z9601.seFactory = Children(i).Data
   Case "CDFACTORY":z9601.cdFactory = Children(i).Data
   Case "SESUBPROCESS":z9601.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z9601.cdSubProcess = Children(i).Data
   Case "DATETARGET":z9601.DateTarget = Children(i).Data
   Case "QTYTARGET":z9601.QtyTarget = Children(i).Data
   Case "QTYACTUAL":z9601.QtyActual = Children(i).Data
   Case "AMTTARGET":z9601.AmtTarget = Children(i).Data
   Case "AMTACTUAL":z9601.AmtActual = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K9601_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K9601_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9601 As T9601_AREA, Job as String, CheckClear as Boolean, SEFACTORY AS String, CDFACTORY AS String, SESUBPROCESS AS String, CDSUBPROCESS AS String, DATETARGET AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9601_MOVE = False

Try
    If READ_PFK9601(SEFACTORY, CDFACTORY, SESUBPROCESS, CDSUBPROCESS, DATETARGET) = True Then
                z9601 = D9601
		K9601_MOVE = True
		else
	If CheckClear  = True then z9601 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9601")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SEFACTORY":z9601.seFactory = Children(i).Code
   Case "CDFACTORY":z9601.cdFactory = Children(i).Code
   Case "SESUBPROCESS":z9601.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z9601.cdSubProcess = Children(i).Code
   Case "DATETARGET":z9601.DateTarget = Children(i).Code
   Case "QTYTARGET":z9601.QtyTarget = Children(i).Code
   Case "QTYACTUAL":z9601.QtyActual = Children(i).Code
   Case "AMTTARGET":z9601.AmtTarget = Children(i).Code
   Case "AMTACTUAL":z9601.AmtActual = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SEFACTORY":z9601.seFactory = Children(i).Data
   Case "CDFACTORY":z9601.cdFactory = Children(i).Data
   Case "SESUBPROCESS":z9601.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z9601.cdSubProcess = Children(i).Data
   Case "DATETARGET":z9601.DateTarget = Children(i).Data
   Case "QTYTARGET":z9601.QtyTarget = Children(i).Data
   Case "QTYACTUAL":z9601.QtyActual = Children(i).Data
   Case "AMTTARGET":z9601.AmtTarget = Children(i).Data
   Case "AMTACTUAL":z9601.AmtActual = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K9601_MOVE",vbCritical)
End Try
End Function 
    
End Module 
