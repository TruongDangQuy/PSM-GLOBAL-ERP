'=========================================================================================================================================================
'   TABLE : (PFK9603)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K9603

Structure T9603_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	seFactory	 AS String	'			char(3)		*
Public 	cdFactory	 AS String	'			char(3)		*
Public 	seSubProcess	 AS String	'			char(3)		*
Public 	cdSubProcess	 AS String	'			char(3)		*
Public 	seLineProd	 AS String	'			char(3)		*
Public 	cdLineProd	 AS String	'			char(3)		*
        Public DateTarget As String  '			char(8)		*
Public 	QtyTarget	 AS Double	'			decimal
Public 	QtyActual	 AS Double	'			decimal
Public 	AmtTaget	 AS Double	'			decimal
Public 	AmtActual	 AS Double	'			decimal
Public 	PersonTO	 AS Double	'			decimal
Public 	lineInformation	 AS Double	'			decimal
Public 	PersonActualDirect	 AS Double	'			decimal
Public 	ABSENT	 AS Double	'			decimal
'=========================================================================================================================================================
End structure

Public D9603 As T9603_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK9603(SEFACTORY AS String, CDFACTORY AS String, SESUBPROCESS AS String, CDSUBPROCESS AS String, SELINEPROD AS String, CDLINEPROD AS String, DATETARGET AS String) As Boolean
    READ_PFK9603 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9603 "
    SQL = SQL & " WHERE K9603_seFactory		 = '" & seFactory & "' " 
    SQL = SQL & "   AND K9603_cdFactory		 = '" & cdFactory & "' " 
    SQL = SQL & "   AND K9603_seSubProcess		 = '" & seSubProcess & "' " 
    SQL = SQL & "   AND K9603_cdSubProcess		 = '" & cdSubProcess & "' " 
    SQL = SQL & "   AND K9603_seLineProd		 = '" & seLineProd & "' " 
    SQL = SQL & "   AND K9603_cdLineProd		 = '" & cdLineProd & "' " 
    SQL = SQL & "   AND K9603_DateTarget		 = '" & DateTarget & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D9603_CLEAR: GoTo SKIP_READ_PFK9603
                
    Call K9603_MOVE(rd)
    READ_PFK9603 = True

SKIP_READ_PFK9603:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK9603",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK9603(SEFACTORY AS String, CDFACTORY AS String, SESUBPROCESS AS String, CDSUBPROCESS AS String, SELINEPROD AS String, CDLINEPROD AS String, DATETARGET AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9603 "
    SQL = SQL & " WHERE K9603_seFactory		 = '" & seFactory & "' " 
    SQL = SQL & "   AND K9603_cdFactory		 = '" & cdFactory & "' " 
    SQL = SQL & "   AND K9603_seSubProcess		 = '" & seSubProcess & "' " 
    SQL = SQL & "   AND K9603_cdSubProcess		 = '" & cdSubProcess & "' " 
    SQL = SQL & "   AND K9603_seLineProd		 = '" & seLineProd & "' " 
    SQL = SQL & "   AND K9603_cdLineProd		 = '" & cdLineProd & "' " 
    SQL = SQL & "   AND K9603_DateTarget		 = '" & DateTarget & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK9603",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK9603(z9603 As T9603_AREA) As Boolean
    WRITE_PFK9603 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z9603)
 
    SQL = " INSERT INTO PFK9603 "
    SQL = SQL & " ( "
    SQL = SQL & " K9603_seFactory," 
    SQL = SQL & " K9603_cdFactory," 
    SQL = SQL & " K9603_seSubProcess," 
    SQL = SQL & " K9603_cdSubProcess," 
    SQL = SQL & " K9603_seLineProd," 
    SQL = SQL & " K9603_cdLineProd," 
    SQL = SQL & " K9603_DateTarget," 
    SQL = SQL & " K9603_QtyTarget," 
    SQL = SQL & " K9603_QtyActual," 
    SQL = SQL & " K9603_AmtTaget," 
    SQL = SQL & " K9603_AmtActual," 
    SQL = SQL & " K9603_PersonTO," 
    SQL = SQL & " K9603_lineInformation," 
    SQL = SQL & " K9603_PersonActualDirect," 
    SQL = SQL & " K9603_ABSENT " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z9603.seFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9603.cdFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9603.seSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9603.cdSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9603.seLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9603.cdLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9603.DateTarget) & "', "  
    SQL = SQL & "   " & FormatSQL(z9603.QtyTarget) & ", "  
    SQL = SQL & "   " & FormatSQL(z9603.QtyActual) & ", "  
    SQL = SQL & "   " & FormatSQL(z9603.AmtTaget) & ", "  
    SQL = SQL & "   " & FormatSQL(z9603.AmtActual) & ", "  
    SQL = SQL & "   " & FormatSQL(z9603.PersonTO) & ", "  
    SQL = SQL & "   " & FormatSQL(z9603.lineInformation) & ", "  
    SQL = SQL & "   " & FormatSQL(z9603.PersonActualDirect) & ", "  
    SQL = SQL & "   " & FormatSQL(z9603.ABSENT) & "  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK9603 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK9603",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK9603(z9603 As T9603_AREA) As Boolean
    REWRITE_PFK9603 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z9603)
   
    SQL = " UPDATE PFK9603 SET "
    SQL = SQL & "    K9603_QtyTarget      =  " & FormatSQL(z9603.QtyTarget) & ", " 
    SQL = SQL & "    K9603_QtyActual      =  " & FormatSQL(z9603.QtyActual) & ", " 
    SQL = SQL & "    K9603_AmtTaget      =  " & FormatSQL(z9603.AmtTaget) & ", " 
    SQL = SQL & "    K9603_AmtActual      =  " & FormatSQL(z9603.AmtActual) & ", " 
    SQL = SQL & "    K9603_PersonTO      =  " & FormatSQL(z9603.PersonTO) & ", " 
    SQL = SQL & "    K9603_lineInformation      =  " & FormatSQL(z9603.lineInformation) & ", " 
    SQL = SQL & "    K9603_PersonActualDirect      =  " & FormatSQL(z9603.PersonActualDirect) & ", " 
    SQL = SQL & "    K9603_ABSENT      =  " & FormatSQL(z9603.ABSENT) & "  " 
    SQL = SQL & " WHERE K9603_seFactory		 = '" & z9603.seFactory & "' " 
    SQL = SQL & "   AND K9603_cdFactory		 = '" & z9603.cdFactory & "' " 
    SQL = SQL & "   AND K9603_seSubProcess		 = '" & z9603.seSubProcess & "' " 
    SQL = SQL & "   AND K9603_cdSubProcess		 = '" & z9603.cdSubProcess & "' " 
    SQL = SQL & "   AND K9603_seLineProd		 = '" & z9603.seLineProd & "' " 
    SQL = SQL & "   AND K9603_cdLineProd		 = '" & z9603.cdLineProd & "' " 
    SQL = SQL & "   AND K9603_DateTarget		 = '" & z9603.DateTarget & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK9603 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK9603",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK9603(z9603 As T9603_AREA) As Boolean
    DELETE_PFK9603 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK9603 "
    SQL = SQL & " WHERE K9603_seFactory		 = '" & z9603.seFactory & "' " 
    SQL = SQL & "   AND K9603_cdFactory		 = '" & z9603.cdFactory & "' " 
    SQL = SQL & "   AND K9603_seSubProcess		 = '" & z9603.seSubProcess & "' " 
    SQL = SQL & "   AND K9603_cdSubProcess		 = '" & z9603.cdSubProcess & "' " 
    SQL = SQL & "   AND K9603_seLineProd		 = '" & z9603.seLineProd & "' " 
    SQL = SQL & "   AND K9603_cdLineProd		 = '" & z9603.cdLineProd & "' " 
    SQL = SQL & "   AND K9603_DateTarget		 = '" & z9603.DateTarget & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK9603 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK9603",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D9603_CLEAR()
Try
    
   D9603.seFactory = ""
   D9603.cdFactory = ""
   D9603.seSubProcess = ""
   D9603.cdSubProcess = ""
   D9603.seLineProd = ""
   D9603.cdLineProd = ""
   D9603.DateTarget = ""
    D9603.QtyTarget = 0 
    D9603.QtyActual = 0 
    D9603.AmtTaget = 0 
    D9603.AmtActual = 0 
    D9603.PersonTO = 0 
    D9603.lineInformation = 0 
    D9603.PersonActualDirect = 0 
    D9603.ABSENT = 0 

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D9603_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x9603 As T9603_AREA)
Try
    
    x9603.seFactory = trim$(  x9603.seFactory)
    x9603.cdFactory = trim$(  x9603.cdFactory)
    x9603.seSubProcess = trim$(  x9603.seSubProcess)
    x9603.cdSubProcess = trim$(  x9603.cdSubProcess)
    x9603.seLineProd = trim$(  x9603.seLineProd)
    x9603.cdLineProd = trim$(  x9603.cdLineProd)
    x9603.DateTarget = trim$(  x9603.DateTarget)
    x9603.QtyTarget = trim$(  x9603.QtyTarget)
    x9603.QtyActual = trim$(  x9603.QtyActual)
    x9603.AmtTaget = trim$(  x9603.AmtTaget)
    x9603.AmtActual = trim$(  x9603.AmtActual)
    x9603.PersonTO = trim$(  x9603.PersonTO)
    x9603.lineInformation = trim$(  x9603.lineInformation)
    x9603.PersonActualDirect = trim$(  x9603.PersonActualDirect)
    x9603.ABSENT = trim$(  x9603.ABSENT)
     
    If trim$( x9603.seFactory ) = "" Then x9603.seFactory = Space(1) 
    If trim$( x9603.cdFactory ) = "" Then x9603.cdFactory = Space(1) 
    If trim$( x9603.seSubProcess ) = "" Then x9603.seSubProcess = Space(1) 
    If trim$( x9603.cdSubProcess ) = "" Then x9603.cdSubProcess = Space(1) 
    If trim$( x9603.seLineProd ) = "" Then x9603.seLineProd = Space(1) 
    If trim$( x9603.cdLineProd ) = "" Then x9603.cdLineProd = Space(1) 
    If trim$( x9603.DateTarget ) = "" Then x9603.DateTarget = Space(1) 
    If trim$( x9603.QtyTarget ) = "" Then x9603.QtyTarget = 0 
    If trim$( x9603.QtyActual ) = "" Then x9603.QtyActual = 0 
    If trim$( x9603.AmtTaget ) = "" Then x9603.AmtTaget = 0 
    If trim$( x9603.AmtActual ) = "" Then x9603.AmtActual = 0 
    If trim$( x9603.PersonTO ) = "" Then x9603.PersonTO = 0 
    If trim$( x9603.lineInformation ) = "" Then x9603.lineInformation = 0 
    If trim$( x9603.PersonActualDirect ) = "" Then x9603.PersonActualDirect = 0 
    If trim$( x9603.ABSENT ) = "" Then x9603.ABSENT = 0 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K9603_MOVE(rs9603 As SqlClient.SqlDataReader)
Try

    call D9603_CLEAR()   

    If IsdbNull(rs9603!K9603_seFactory) = False Then D9603.seFactory = Trim$(rs9603!K9603_seFactory)
    If IsdbNull(rs9603!K9603_cdFactory) = False Then D9603.cdFactory = Trim$(rs9603!K9603_cdFactory)
    If IsdbNull(rs9603!K9603_seSubProcess) = False Then D9603.seSubProcess = Trim$(rs9603!K9603_seSubProcess)
    If IsdbNull(rs9603!K9603_cdSubProcess) = False Then D9603.cdSubProcess = Trim$(rs9603!K9603_cdSubProcess)
    If IsdbNull(rs9603!K9603_seLineProd) = False Then D9603.seLineProd = Trim$(rs9603!K9603_seLineProd)
    If IsdbNull(rs9603!K9603_cdLineProd) = False Then D9603.cdLineProd = Trim$(rs9603!K9603_cdLineProd)
    If IsdbNull(rs9603!K9603_DateTarget) = False Then D9603.DateTarget = Trim$(rs9603!K9603_DateTarget)
    If IsdbNull(rs9603!K9603_QtyTarget) = False Then D9603.QtyTarget = Trim$(rs9603!K9603_QtyTarget)
    If IsdbNull(rs9603!K9603_QtyActual) = False Then D9603.QtyActual = Trim$(rs9603!K9603_QtyActual)
    If IsdbNull(rs9603!K9603_AmtTaget) = False Then D9603.AmtTaget = Trim$(rs9603!K9603_AmtTaget)
    If IsdbNull(rs9603!K9603_AmtActual) = False Then D9603.AmtActual = Trim$(rs9603!K9603_AmtActual)
    If IsdbNull(rs9603!K9603_PersonTO) = False Then D9603.PersonTO = Trim$(rs9603!K9603_PersonTO)
    If IsdbNull(rs9603!K9603_lineInformation) = False Then D9603.lineInformation = Trim$(rs9603!K9603_lineInformation)
    If IsdbNull(rs9603!K9603_PersonActualDirect) = False Then D9603.PersonActualDirect = Trim$(rs9603!K9603_PersonActualDirect)
    If IsdbNull(rs9603!K9603_ABSENT) = False Then D9603.ABSENT = Trim$(rs9603!K9603_ABSENT)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9603_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K9603_MOVE(rs9603 As DataRow)
Try

    call D9603_CLEAR()   

    If IsdbNull(rs9603!K9603_seFactory) = False Then D9603.seFactory = Trim$(rs9603!K9603_seFactory)
    If IsdbNull(rs9603!K9603_cdFactory) = False Then D9603.cdFactory = Trim$(rs9603!K9603_cdFactory)
    If IsdbNull(rs9603!K9603_seSubProcess) = False Then D9603.seSubProcess = Trim$(rs9603!K9603_seSubProcess)
    If IsdbNull(rs9603!K9603_cdSubProcess) = False Then D9603.cdSubProcess = Trim$(rs9603!K9603_cdSubProcess)
    If IsdbNull(rs9603!K9603_seLineProd) = False Then D9603.seLineProd = Trim$(rs9603!K9603_seLineProd)
    If IsdbNull(rs9603!K9603_cdLineProd) = False Then D9603.cdLineProd = Trim$(rs9603!K9603_cdLineProd)
    If IsdbNull(rs9603!K9603_DateTarget) = False Then D9603.DateTarget = Trim$(rs9603!K9603_DateTarget)
    If IsdbNull(rs9603!K9603_QtyTarget) = False Then D9603.QtyTarget = Trim$(rs9603!K9603_QtyTarget)
    If IsdbNull(rs9603!K9603_QtyActual) = False Then D9603.QtyActual = Trim$(rs9603!K9603_QtyActual)
    If IsdbNull(rs9603!K9603_AmtTaget) = False Then D9603.AmtTaget = Trim$(rs9603!K9603_AmtTaget)
    If IsdbNull(rs9603!K9603_AmtActual) = False Then D9603.AmtActual = Trim$(rs9603!K9603_AmtActual)
    If IsdbNull(rs9603!K9603_PersonTO) = False Then D9603.PersonTO = Trim$(rs9603!K9603_PersonTO)
    If IsdbNull(rs9603!K9603_lineInformation) = False Then D9603.lineInformation = Trim$(rs9603!K9603_lineInformation)
    If IsdbNull(rs9603!K9603_PersonActualDirect) = False Then D9603.PersonActualDirect = Trim$(rs9603!K9603_PersonActualDirect)
    If IsdbNull(rs9603!K9603_ABSENT) = False Then D9603.ABSENT = Trim$(rs9603!K9603_ABSENT)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9603_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K9603_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9603 As T9603_AREA, SEFACTORY AS String, CDFACTORY AS String, SESUBPROCESS AS String, CDSUBPROCESS AS String, SELINEPROD AS String, CDLINEPROD AS String, DATETARGET AS String) as Boolean

K9603_MOVE = False

Try
    If READ_PFK9603(SEFACTORY, CDFACTORY, SESUBPROCESS, CDSUBPROCESS, SELINEPROD, CDLINEPROD, DATETARGET) = True Then
                z9603 = D9603
		K9603_MOVE = True
		else
	z9603 = nothing
     End If

     If  getColumIndex(spr,"seFactory") > -1 then z9603.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"cdFactory") > -1 then z9603.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z9603.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z9603.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"seLineProd") > -1 then z9603.seLineProd = getDataM(spr, getColumIndex(spr,"seLineProd"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z9603.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"DateTarget") > -1 then z9603.DateTarget = getDataM(spr, getColumIndex(spr,"DateTarget"), xRow)
     If  getColumIndex(spr,"QtyTarget") > -1 then z9603.QtyTarget = getDataM(spr, getColumIndex(spr,"QtyTarget"), xRow)
     If  getColumIndex(spr,"QtyActual") > -1 then z9603.QtyActual = getDataM(spr, getColumIndex(spr,"QtyActual"), xRow)
     If  getColumIndex(spr,"AmtTaget") > -1 then z9603.AmtTaget = getDataM(spr, getColumIndex(spr,"AmtTaget"), xRow)
     If  getColumIndex(spr,"AmtActual") > -1 then z9603.AmtActual = getDataM(spr, getColumIndex(spr,"AmtActual"), xRow)
     If  getColumIndex(spr,"PersonTO") > -1 then z9603.PersonTO = getDataM(spr, getColumIndex(spr,"PersonTO"), xRow)
     If  getColumIndex(spr,"lineInformation") > -1 then z9603.lineInformation = getDataM(spr, getColumIndex(spr,"lineInformation"), xRow)
     If  getColumIndex(spr,"PersonActualDirect") > -1 then z9603.PersonActualDirect = getDataM(spr, getColumIndex(spr,"PersonActualDirect"), xRow)
     If  getColumIndex(spr,"ABSENT") > -1 then z9603.ABSENT = getDataM(spr, getColumIndex(spr,"ABSENT"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K9603_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K9603_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9603 As T9603_AREA,CheckClear as Boolean,SEFACTORY AS String, CDFACTORY AS String, SESUBPROCESS AS String, CDSUBPROCESS AS String, SELINEPROD AS String, CDLINEPROD AS String, DATETARGET AS String) as Boolean

K9603_MOVE = False

Try
    If READ_PFK9603(SEFACTORY, CDFACTORY, SESUBPROCESS, CDSUBPROCESS, SELINEPROD, CDLINEPROD, DATETARGET) = True Then
                z9603 = D9603
		K9603_MOVE = True
		else
	If CheckClear  = True then z9603 = nothing
     End If

     If  getColumIndex(spr,"seFactory") > -1 then z9603.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"cdFactory") > -1 then z9603.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z9603.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z9603.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"seLineProd") > -1 then z9603.seLineProd = getDataM(spr, getColumIndex(spr,"seLineProd"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z9603.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"DateTarget") > -1 then z9603.DateTarget = getDataM(spr, getColumIndex(spr,"DateTarget"), xRow)
     If  getColumIndex(spr,"QtyTarget") > -1 then z9603.QtyTarget = getDataM(spr, getColumIndex(spr,"QtyTarget"), xRow)
     If  getColumIndex(spr,"QtyActual") > -1 then z9603.QtyActual = getDataM(spr, getColumIndex(spr,"QtyActual"), xRow)
     If  getColumIndex(spr,"AmtTaget") > -1 then z9603.AmtTaget = getDataM(spr, getColumIndex(spr,"AmtTaget"), xRow)
     If  getColumIndex(spr,"AmtActual") > -1 then z9603.AmtActual = getDataM(spr, getColumIndex(spr,"AmtActual"), xRow)
     If  getColumIndex(spr,"PersonTO") > -1 then z9603.PersonTO = getDataM(spr, getColumIndex(spr,"PersonTO"), xRow)
     If  getColumIndex(spr,"lineInformation") > -1 then z9603.lineInformation = getDataM(spr, getColumIndex(spr,"lineInformation"), xRow)
     If  getColumIndex(spr,"PersonActualDirect") > -1 then z9603.PersonActualDirect = getDataM(spr, getColumIndex(spr,"PersonActualDirect"), xRow)
     If  getColumIndex(spr,"ABSENT") > -1 then z9603.ABSENT = getDataM(spr, getColumIndex(spr,"ABSENT"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K9603_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K9603_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9603 As T9603_AREA, Job as String, SEFACTORY AS String, CDFACTORY AS String, SESUBPROCESS AS String, CDSUBPROCESS AS String, SELINEPROD AS String, CDLINEPROD AS String, DATETARGET AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9603_MOVE = False

Try
    If READ_PFK9603(SEFACTORY, CDFACTORY, SESUBPROCESS, CDSUBPROCESS, SELINEPROD, CDLINEPROD, DATETARGET) = True Then
                z9603 = D9603
		K9603_MOVE = True
		else
	z9603 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9603")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SEFACTORY":z9603.seFactory = Children(i).Code
   Case "CDFACTORY":z9603.cdFactory = Children(i).Code
   Case "SESUBPROCESS":z9603.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z9603.cdSubProcess = Children(i).Code
   Case "SELINEPROD":z9603.seLineProd = Children(i).Code
   Case "CDLINEPROD":z9603.cdLineProd = Children(i).Code
   Case "DATETARGET":z9603.DateTarget = Children(i).Code
   Case "QTYTARGET":z9603.QtyTarget = Children(i).Code
   Case "QTYACTUAL":z9603.QtyActual = Children(i).Code
   Case "AMTTAGET":z9603.AmtTaget = Children(i).Code
   Case "AMTACTUAL":z9603.AmtActual = Children(i).Code
   Case "PERSONTO":z9603.PersonTO = Children(i).Code
   Case "LINEINFORMATION":z9603.lineInformation = Children(i).Code
   Case "PERSONACTUALDIRECT":z9603.PersonActualDirect = Children(i).Code
   Case "ABSENT":z9603.ABSENT = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SEFACTORY":z9603.seFactory = Children(i).Data
   Case "CDFACTORY":z9603.cdFactory = Children(i).Data
   Case "SESUBPROCESS":z9603.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z9603.cdSubProcess = Children(i).Data
   Case "SELINEPROD":z9603.seLineProd = Children(i).Data
   Case "CDLINEPROD":z9603.cdLineProd = Children(i).Data
   Case "DATETARGET":z9603.DateTarget = Children(i).Data
   Case "QTYTARGET":z9603.QtyTarget = Children(i).Data
   Case "QTYACTUAL":z9603.QtyActual = Children(i).Data
   Case "AMTTAGET":z9603.AmtTaget = Children(i).Data
   Case "AMTACTUAL":z9603.AmtActual = Children(i).Data
   Case "PERSONTO":z9603.PersonTO = Children(i).Data
   Case "LINEINFORMATION":z9603.lineInformation = Children(i).Data
   Case "PERSONACTUALDIRECT":z9603.PersonActualDirect = Children(i).Data
   Case "ABSENT":z9603.ABSENT = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K9603_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K9603_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9603 As T9603_AREA, Job as String, CheckClear as Boolean, SEFACTORY AS String, CDFACTORY AS String, SESUBPROCESS AS String, CDSUBPROCESS AS String, SELINEPROD AS String, CDLINEPROD AS String, DATETARGET AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9603_MOVE = False

Try
    If READ_PFK9603(SEFACTORY, CDFACTORY, SESUBPROCESS, CDSUBPROCESS, SELINEPROD, CDLINEPROD, DATETARGET) = True Then
                z9603 = D9603
		K9603_MOVE = True
		else
	If CheckClear  = True then z9603 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9603")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SEFACTORY":z9603.seFactory = Children(i).Code
   Case "CDFACTORY":z9603.cdFactory = Children(i).Code
   Case "SESUBPROCESS":z9603.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z9603.cdSubProcess = Children(i).Code
   Case "SELINEPROD":z9603.seLineProd = Children(i).Code
   Case "CDLINEPROD":z9603.cdLineProd = Children(i).Code
   Case "DATETARGET":z9603.DateTarget = Children(i).Code
   Case "QTYTARGET":z9603.QtyTarget = Children(i).Code
   Case "QTYACTUAL":z9603.QtyActual = Children(i).Code
   Case "AMTTAGET":z9603.AmtTaget = Children(i).Code
   Case "AMTACTUAL":z9603.AmtActual = Children(i).Code
   Case "PERSONTO":z9603.PersonTO = Children(i).Code
   Case "LINEINFORMATION":z9603.lineInformation = Children(i).Code
   Case "PERSONACTUALDIRECT":z9603.PersonActualDirect = Children(i).Code
   Case "ABSENT":z9603.ABSENT = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SEFACTORY":z9603.seFactory = Children(i).Data
   Case "CDFACTORY":z9603.cdFactory = Children(i).Data
   Case "SESUBPROCESS":z9603.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z9603.cdSubProcess = Children(i).Data
   Case "SELINEPROD":z9603.seLineProd = Children(i).Data
   Case "CDLINEPROD":z9603.cdLineProd = Children(i).Data
   Case "DATETARGET":z9603.DateTarget = Children(i).Data
   Case "QTYTARGET":z9603.QtyTarget = Children(i).Data
   Case "QTYACTUAL":z9603.QtyActual = Children(i).Data
   Case "AMTTAGET":z9603.AmtTaget = Children(i).Data
   Case "AMTACTUAL":z9603.AmtActual = Children(i).Data
   Case "PERSONTO":z9603.PersonTO = Children(i).Data
   Case "LINEINFORMATION":z9603.lineInformation = Children(i).Data
   Case "PERSONACTUALDIRECT":z9603.PersonActualDirect = Children(i).Data
   Case "ABSENT":z9603.ABSENT = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K9603_MOVE",vbCritical)
End Try
End Function 
    
End Module 
