'=========================================================================================================================================================
'   TABLE : (PFK0512)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K0512

Structure T0512_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	ProdDate	 AS String	'			char(8)		*
Public 	ProdSeq	 AS String	'			char(5)		*
Public 	ProdSzno	 AS String	'			char(2)		*
Public 	QtyProduction	 AS Double	'			decimal
Public 	QtyProductionA	 AS Double	'			decimal
Public 	QtyProductionX	 AS Double	'			decimal
Public 	QtyProductionXP	 AS Double	'			decimal
Public 	QtyProductionXD	 AS Double	'			decimal
Public 	QtyProductionXR	 AS Double	'			decimal
Public 	QtyOutProduction	 AS Double	'			decimal
Public 	QtyBLOut	 AS Double	'			decimal
Public 	QtyBLIn	 AS Double	'			decimal
Public 	CheckL	 AS String	'			char(1)
Public 	CheckR	 AS String	'			char(1)
Public 	ISUD	 AS String	'			char(4)
Public 	CheckComplete	 AS String	'			char(1)
Public 	CheckTrigger	 AS String	'			nvarchar(10)
Public 	Remark	 AS String	'			nvarchar(100)
'=========================================================================================================================================================
End structure

Public D0512 As T0512_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK0512(PRODDATE AS String, PRODSEQ AS String, PRODSZNO AS String) As Boolean
    READ_PFK0512 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0512 "
    SQL = SQL & " WHERE K0512_ProdDate		 = '" & ProdDate & "' " 
    SQL = SQL & "   AND K0512_ProdSeq		 = '" & ProdSeq & "' " 
    SQL = SQL & "   AND K0512_ProdSzno		 = '" & ProdSzno & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D0512_CLEAR: GoTo SKIP_READ_PFK0512
                
    Call K0512_MOVE(rd)
    READ_PFK0512 = True

SKIP_READ_PFK0512:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK0512",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK0512(PRODDATE AS String, PRODSEQ AS String, PRODSZNO AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK0512 "
    SQL = SQL & " WHERE K0512_ProdDate		 = '" & ProdDate & "' " 
    SQL = SQL & "   AND K0512_ProdSeq		 = '" & ProdSeq & "' " 
    SQL = SQL & "   AND K0512_ProdSzno		 = '" & ProdSzno & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK0512",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK0512(z0512 As T0512_AREA) As Boolean
    WRITE_PFK0512 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z0512)
 
    SQL = " INSERT INTO PFK0512 "
    SQL = SQL & " ( "
    SQL = SQL & " K0512_ProdDate," 
    SQL = SQL & " K0512_ProdSeq," 
    SQL = SQL & " K0512_ProdSzno," 
    SQL = SQL & " K0512_QtyProduction," 
    SQL = SQL & " K0512_QtyProductionA," 
    SQL = SQL & " K0512_QtyProductionX," 
    SQL = SQL & " K0512_QtyProductionXP," 
    SQL = SQL & " K0512_QtyProductionXD," 
    SQL = SQL & " K0512_QtyProductionXR," 
    SQL = SQL & " K0512_QtyOutProduction," 
    SQL = SQL & " K0512_QtyBLOut," 
    SQL = SQL & " K0512_QtyBLIn," 
    SQL = SQL & " K0512_CheckL," 
    SQL = SQL & " K0512_CheckR," 
    SQL = SQL & " K0512_ISUD," 
    SQL = SQL & " K0512_CheckComplete," 
    SQL = SQL & " K0512_CheckTrigger," 
    SQL = SQL & " K0512_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z0512.ProdDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0512.ProdSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0512.ProdSzno) & "', "  
    SQL = SQL & "   " & FormatSQL(z0512.QtyProduction) & ", "  
    SQL = SQL & "   " & FormatSQL(z0512.QtyProductionA) & ", "  
    SQL = SQL & "   " & FormatSQL(z0512.QtyProductionX) & ", "  
    SQL = SQL & "   " & FormatSQL(z0512.QtyProductionXP) & ", "  
    SQL = SQL & "   " & FormatSQL(z0512.QtyProductionXD) & ", "  
    SQL = SQL & "   " & FormatSQL(z0512.QtyProductionXR) & ", "  
    SQL = SQL & "   " & FormatSQL(z0512.QtyOutProduction) & ", "  
    SQL = SQL & "   " & FormatSQL(z0512.QtyBLOut) & ", "  
    SQL = SQL & "   " & FormatSQL(z0512.QtyBLIn) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z0512.CheckL) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0512.CheckR) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0512.ISUD) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0512.CheckComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0512.CheckTrigger) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z0512.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK0512 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK0512",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK0512(z0512 As T0512_AREA) As Boolean
    REWRITE_PFK0512 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z0512)
   
    SQL = " UPDATE PFK0512 SET "
    SQL = SQL & "    K0512_QtyProduction      =  " & FormatSQL(z0512.QtyProduction) & ", " 
    SQL = SQL & "    K0512_QtyProductionA      =  " & FormatSQL(z0512.QtyProductionA) & ", " 
    SQL = SQL & "    K0512_QtyProductionX      =  " & FormatSQL(z0512.QtyProductionX) & ", " 
    SQL = SQL & "    K0512_QtyProductionXP      =  " & FormatSQL(z0512.QtyProductionXP) & ", " 
    SQL = SQL & "    K0512_QtyProductionXD      =  " & FormatSQL(z0512.QtyProductionXD) & ", " 
    SQL = SQL & "    K0512_QtyProductionXR      =  " & FormatSQL(z0512.QtyProductionXR) & ", " 
    SQL = SQL & "    K0512_QtyOutProduction      =  " & FormatSQL(z0512.QtyOutProduction) & ", " 
    SQL = SQL & "    K0512_QtyBLOut      =  " & FormatSQL(z0512.QtyBLOut) & ", " 
    SQL = SQL & "    K0512_QtyBLIn      =  " & FormatSQL(z0512.QtyBLIn) & ", " 
    SQL = SQL & "    K0512_CheckL      = N'" & FormatSQL(z0512.CheckL) & "', " 
    SQL = SQL & "    K0512_CheckR      = N'" & FormatSQL(z0512.CheckR) & "', " 
    SQL = SQL & "    K0512_ISUD      = N'" & FormatSQL(z0512.ISUD) & "', " 
    SQL = SQL & "    K0512_CheckComplete      = N'" & FormatSQL(z0512.CheckComplete) & "', " 
    SQL = SQL & "    K0512_CheckTrigger      = N'" & FormatSQL(z0512.CheckTrigger) & "', " 
    SQL = SQL & "    K0512_Remark      = N'" & FormatSQL(z0512.Remark) & "'  " 
    SQL = SQL & " WHERE K0512_ProdDate		 = '" & z0512.ProdDate & "' " 
    SQL = SQL & "   AND K0512_ProdSeq		 = '" & z0512.ProdSeq & "' " 
    SQL = SQL & "   AND K0512_ProdSzno		 = '" & z0512.ProdSzno & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK0512 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK0512",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK0512(z0512 As T0512_AREA) As Boolean
    DELETE_PFK0512 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK0512 "
    SQL = SQL & " WHERE K0512_ProdDate		 = '" & z0512.ProdDate & "' " 
    SQL = SQL & "   AND K0512_ProdSeq		 = '" & z0512.ProdSeq & "' " 
    SQL = SQL & "   AND K0512_ProdSzno		 = '" & z0512.ProdSzno & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK0512 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK0512",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D0512_CLEAR()
Try
    
   D0512.ProdDate = ""
   D0512.ProdSeq = ""
   D0512.ProdSzno = ""
    D0512.QtyProduction = 0 
    D0512.QtyProductionA = 0 
    D0512.QtyProductionX = 0 
    D0512.QtyProductionXP = 0 
    D0512.QtyProductionXD = 0 
    D0512.QtyProductionXR = 0 
    D0512.QtyOutProduction = 0 
    D0512.QtyBLOut = 0 
    D0512.QtyBLIn = 0 
   D0512.CheckL = ""
   D0512.CheckR = ""
   D0512.ISUD = ""
   D0512.CheckComplete = ""
   D0512.CheckTrigger = ""
   D0512.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D0512_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x0512 As T0512_AREA)
Try
    
    x0512.ProdDate = trim$(  x0512.ProdDate)
    x0512.ProdSeq = trim$(  x0512.ProdSeq)
    x0512.ProdSzno = trim$(  x0512.ProdSzno)
    x0512.QtyProduction = trim$(  x0512.QtyProduction)
    x0512.QtyProductionA = trim$(  x0512.QtyProductionA)
    x0512.QtyProductionX = trim$(  x0512.QtyProductionX)
    x0512.QtyProductionXP = trim$(  x0512.QtyProductionXP)
    x0512.QtyProductionXD = trim$(  x0512.QtyProductionXD)
    x0512.QtyProductionXR = trim$(  x0512.QtyProductionXR)
    x0512.QtyOutProduction = trim$(  x0512.QtyOutProduction)
    x0512.QtyBLOut = trim$(  x0512.QtyBLOut)
    x0512.QtyBLIn = trim$(  x0512.QtyBLIn)
    x0512.CheckL = trim$(  x0512.CheckL)
    x0512.CheckR = trim$(  x0512.CheckR)
    x0512.ISUD = trim$(  x0512.ISUD)
    x0512.CheckComplete = trim$(  x0512.CheckComplete)
    x0512.CheckTrigger = trim$(  x0512.CheckTrigger)
    x0512.Remark = trim$(  x0512.Remark)
     
    If trim$( x0512.ProdDate ) = "" Then x0512.ProdDate = Space(1) 
    If trim$( x0512.ProdSeq ) = "" Then x0512.ProdSeq = Space(1) 
    If trim$( x0512.ProdSzno ) = "" Then x0512.ProdSzno = Space(1) 
    If trim$( x0512.QtyProduction ) = "" Then x0512.QtyProduction = 0 
    If trim$( x0512.QtyProductionA ) = "" Then x0512.QtyProductionA = 0 
    If trim$( x0512.QtyProductionX ) = "" Then x0512.QtyProductionX = 0 
    If trim$( x0512.QtyProductionXP ) = "" Then x0512.QtyProductionXP = 0 
    If trim$( x0512.QtyProductionXD ) = "" Then x0512.QtyProductionXD = 0 
    If trim$( x0512.QtyProductionXR ) = "" Then x0512.QtyProductionXR = 0 
    If trim$( x0512.QtyOutProduction ) = "" Then x0512.QtyOutProduction = 0 
    If trim$( x0512.QtyBLOut ) = "" Then x0512.QtyBLOut = 0 
    If trim$( x0512.QtyBLIn ) = "" Then x0512.QtyBLIn = 0 
    If trim$( x0512.CheckL ) = "" Then x0512.CheckL = Space(1) 
    If trim$( x0512.CheckR ) = "" Then x0512.CheckR = Space(1) 
    If trim$( x0512.ISUD ) = "" Then x0512.ISUD = Space(1) 
    If trim$( x0512.CheckComplete ) = "" Then x0512.CheckComplete = Space(1) 
    If trim$( x0512.CheckTrigger ) = "" Then x0512.CheckTrigger = Space(1) 
    If trim$( x0512.Remark ) = "" Then x0512.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K0512_MOVE(rs0512 As SqlClient.SqlDataReader)
Try

    call D0512_CLEAR()   

    If IsdbNull(rs0512!K0512_ProdDate) = False Then D0512.ProdDate = Trim$(rs0512!K0512_ProdDate)
    If IsdbNull(rs0512!K0512_ProdSeq) = False Then D0512.ProdSeq = Trim$(rs0512!K0512_ProdSeq)
    If IsdbNull(rs0512!K0512_ProdSzno) = False Then D0512.ProdSzno = Trim$(rs0512!K0512_ProdSzno)
    If IsdbNull(rs0512!K0512_QtyProduction) = False Then D0512.QtyProduction = Trim$(rs0512!K0512_QtyProduction)
    If IsdbNull(rs0512!K0512_QtyProductionA) = False Then D0512.QtyProductionA = Trim$(rs0512!K0512_QtyProductionA)
    If IsdbNull(rs0512!K0512_QtyProductionX) = False Then D0512.QtyProductionX = Trim$(rs0512!K0512_QtyProductionX)
    If IsdbNull(rs0512!K0512_QtyProductionXP) = False Then D0512.QtyProductionXP = Trim$(rs0512!K0512_QtyProductionXP)
    If IsdbNull(rs0512!K0512_QtyProductionXD) = False Then D0512.QtyProductionXD = Trim$(rs0512!K0512_QtyProductionXD)
    If IsdbNull(rs0512!K0512_QtyProductionXR) = False Then D0512.QtyProductionXR = Trim$(rs0512!K0512_QtyProductionXR)
    If IsdbNull(rs0512!K0512_QtyOutProduction) = False Then D0512.QtyOutProduction = Trim$(rs0512!K0512_QtyOutProduction)
    If IsdbNull(rs0512!K0512_QtyBLOut) = False Then D0512.QtyBLOut = Trim$(rs0512!K0512_QtyBLOut)
    If IsdbNull(rs0512!K0512_QtyBLIn) = False Then D0512.QtyBLIn = Trim$(rs0512!K0512_QtyBLIn)
    If IsdbNull(rs0512!K0512_CheckL) = False Then D0512.CheckL = Trim$(rs0512!K0512_CheckL)
    If IsdbNull(rs0512!K0512_CheckR) = False Then D0512.CheckR = Trim$(rs0512!K0512_CheckR)
    If IsdbNull(rs0512!K0512_ISUD) = False Then D0512.ISUD = Trim$(rs0512!K0512_ISUD)
    If IsdbNull(rs0512!K0512_CheckComplete) = False Then D0512.CheckComplete = Trim$(rs0512!K0512_CheckComplete)
    If IsdbNull(rs0512!K0512_CheckTrigger) = False Then D0512.CheckTrigger = Trim$(rs0512!K0512_CheckTrigger)
    If IsdbNull(rs0512!K0512_Remark) = False Then D0512.Remark = Trim$(rs0512!K0512_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0512_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K0512_MOVE(rs0512 As DataRow)
Try

    call D0512_CLEAR()   

    If IsdbNull(rs0512!K0512_ProdDate) = False Then D0512.ProdDate = Trim$(rs0512!K0512_ProdDate)
    If IsdbNull(rs0512!K0512_ProdSeq) = False Then D0512.ProdSeq = Trim$(rs0512!K0512_ProdSeq)
    If IsdbNull(rs0512!K0512_ProdSzno) = False Then D0512.ProdSzno = Trim$(rs0512!K0512_ProdSzno)
    If IsdbNull(rs0512!K0512_QtyProduction) = False Then D0512.QtyProduction = Trim$(rs0512!K0512_QtyProduction)
    If IsdbNull(rs0512!K0512_QtyProductionA) = False Then D0512.QtyProductionA = Trim$(rs0512!K0512_QtyProductionA)
    If IsdbNull(rs0512!K0512_QtyProductionX) = False Then D0512.QtyProductionX = Trim$(rs0512!K0512_QtyProductionX)
    If IsdbNull(rs0512!K0512_QtyProductionXP) = False Then D0512.QtyProductionXP = Trim$(rs0512!K0512_QtyProductionXP)
    If IsdbNull(rs0512!K0512_QtyProductionXD) = False Then D0512.QtyProductionXD = Trim$(rs0512!K0512_QtyProductionXD)
    If IsdbNull(rs0512!K0512_QtyProductionXR) = False Then D0512.QtyProductionXR = Trim$(rs0512!K0512_QtyProductionXR)
    If IsdbNull(rs0512!K0512_QtyOutProduction) = False Then D0512.QtyOutProduction = Trim$(rs0512!K0512_QtyOutProduction)
    If IsdbNull(rs0512!K0512_QtyBLOut) = False Then D0512.QtyBLOut = Trim$(rs0512!K0512_QtyBLOut)
    If IsdbNull(rs0512!K0512_QtyBLIn) = False Then D0512.QtyBLIn = Trim$(rs0512!K0512_QtyBLIn)
    If IsdbNull(rs0512!K0512_CheckL) = False Then D0512.CheckL = Trim$(rs0512!K0512_CheckL)
    If IsdbNull(rs0512!K0512_CheckR) = False Then D0512.CheckR = Trim$(rs0512!K0512_CheckR)
    If IsdbNull(rs0512!K0512_ISUD) = False Then D0512.ISUD = Trim$(rs0512!K0512_ISUD)
    If IsdbNull(rs0512!K0512_CheckComplete) = False Then D0512.CheckComplete = Trim$(rs0512!K0512_CheckComplete)
    If IsdbNull(rs0512!K0512_CheckTrigger) = False Then D0512.CheckTrigger = Trim$(rs0512!K0512_CheckTrigger)
    If IsdbNull(rs0512!K0512_Remark) = False Then D0512.Remark = Trim$(rs0512!K0512_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K0512_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K0512_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0512 As T0512_AREA, PRODDATE AS String, PRODSEQ AS String, PRODSZNO AS String) as Boolean

K0512_MOVE = False

Try
    If READ_PFK0512(PRODDATE, PRODSEQ, PRODSZNO) = True Then
                z0512 = D0512
		K0512_MOVE = True
		else
	z0512 = nothing
     End If

     If  getColumIndex(spr,"ProdDate") > -1 then z0512.ProdDate = getDataM(spr, getColumIndex(spr,"ProdDate"), xRow)
     If  getColumIndex(spr,"ProdSeq") > -1 then z0512.ProdSeq = getDataM(spr, getColumIndex(spr,"ProdSeq"), xRow)
     If  getColumIndex(spr,"ProdSzno") > -1 then z0512.ProdSzno = getDataM(spr, getColumIndex(spr,"ProdSzno"), xRow)
     If  getColumIndex(spr,"QtyProduction") > -1 then z0512.QtyProduction = getDataM(spr, getColumIndex(spr,"QtyProduction"), xRow)
     If  getColumIndex(spr,"QtyProductionA") > -1 then z0512.QtyProductionA = getDataM(spr, getColumIndex(spr,"QtyProductionA"), xRow)
     If  getColumIndex(spr,"QtyProductionX") > -1 then z0512.QtyProductionX = getDataM(spr, getColumIndex(spr,"QtyProductionX"), xRow)
     If  getColumIndex(spr,"QtyProductionXP") > -1 then z0512.QtyProductionXP = getDataM(spr, getColumIndex(spr,"QtyProductionXP"), xRow)
     If  getColumIndex(spr,"QtyProductionXD") > -1 then z0512.QtyProductionXD = getDataM(spr, getColumIndex(spr,"QtyProductionXD"), xRow)
     If  getColumIndex(spr,"QtyProductionXR") > -1 then z0512.QtyProductionXR = getDataM(spr, getColumIndex(spr,"QtyProductionXR"), xRow)
     If  getColumIndex(spr,"QtyOutProduction") > -1 then z0512.QtyOutProduction = getDataM(spr, getColumIndex(spr,"QtyOutProduction"), xRow)
     If  getColumIndex(spr,"QtyBLOut") > -1 then z0512.QtyBLOut = getDataM(spr, getColumIndex(spr,"QtyBLOut"), xRow)
     If  getColumIndex(spr,"QtyBLIn") > -1 then z0512.QtyBLIn = getDataM(spr, getColumIndex(spr,"QtyBLIn"), xRow)
     If  getColumIndex(spr,"CheckL") > -1 then z0512.CheckL = getDataM(spr, getColumIndex(spr,"CheckL"), xRow)
     If  getColumIndex(spr,"CheckR") > -1 then z0512.CheckR = getDataM(spr, getColumIndex(spr,"CheckR"), xRow)
     If  getColumIndex(spr,"ISUD") > -1 then z0512.ISUD = getDataM(spr, getColumIndex(spr,"ISUD"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z0512.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"CheckTrigger") > -1 then z0512.CheckTrigger = getDataM(spr, getColumIndex(spr,"CheckTrigger"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0512.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0512_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K0512_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z0512 As T0512_AREA,CheckClear as Boolean,PRODDATE AS String, PRODSEQ AS String, PRODSZNO AS String) as Boolean

K0512_MOVE = False

Try
    If READ_PFK0512(PRODDATE, PRODSEQ, PRODSZNO) = True Then
                z0512 = D0512
		K0512_MOVE = True
		else
	If CheckClear  = True then z0512 = nothing
     End If

     If  getColumIndex(spr,"ProdDate") > -1 then z0512.ProdDate = getDataM(spr, getColumIndex(spr,"ProdDate"), xRow)
     If  getColumIndex(spr,"ProdSeq") > -1 then z0512.ProdSeq = getDataM(spr, getColumIndex(spr,"ProdSeq"), xRow)
     If  getColumIndex(spr,"ProdSzno") > -1 then z0512.ProdSzno = getDataM(spr, getColumIndex(spr,"ProdSzno"), xRow)
     If  getColumIndex(spr,"QtyProduction") > -1 then z0512.QtyProduction = getDataM(spr, getColumIndex(spr,"QtyProduction"), xRow)
     If  getColumIndex(spr,"QtyProductionA") > -1 then z0512.QtyProductionA = getDataM(spr, getColumIndex(spr,"QtyProductionA"), xRow)
     If  getColumIndex(spr,"QtyProductionX") > -1 then z0512.QtyProductionX = getDataM(spr, getColumIndex(spr,"QtyProductionX"), xRow)
     If  getColumIndex(spr,"QtyProductionXP") > -1 then z0512.QtyProductionXP = getDataM(spr, getColumIndex(spr,"QtyProductionXP"), xRow)
     If  getColumIndex(spr,"QtyProductionXD") > -1 then z0512.QtyProductionXD = getDataM(spr, getColumIndex(spr,"QtyProductionXD"), xRow)
     If  getColumIndex(spr,"QtyProductionXR") > -1 then z0512.QtyProductionXR = getDataM(spr, getColumIndex(spr,"QtyProductionXR"), xRow)
     If  getColumIndex(spr,"QtyOutProduction") > -1 then z0512.QtyOutProduction = getDataM(spr, getColumIndex(spr,"QtyOutProduction"), xRow)
     If  getColumIndex(spr,"QtyBLOut") > -1 then z0512.QtyBLOut = getDataM(spr, getColumIndex(spr,"QtyBLOut"), xRow)
     If  getColumIndex(spr,"QtyBLIn") > -1 then z0512.QtyBLIn = getDataM(spr, getColumIndex(spr,"QtyBLIn"), xRow)
     If  getColumIndex(spr,"CheckL") > -1 then z0512.CheckL = getDataM(spr, getColumIndex(spr,"CheckL"), xRow)
     If  getColumIndex(spr,"CheckR") > -1 then z0512.CheckR = getDataM(spr, getColumIndex(spr,"CheckR"), xRow)
     If  getColumIndex(spr,"ISUD") > -1 then z0512.ISUD = getDataM(spr, getColumIndex(spr,"ISUD"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z0512.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"CheckTrigger") > -1 then z0512.CheckTrigger = getDataM(spr, getColumIndex(spr,"CheckTrigger"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z0512.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K0512_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K0512_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0512 As T0512_AREA, Job as String, PRODDATE AS String, PRODSEQ AS String, PRODSZNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0512_MOVE = False

Try
    If READ_PFK0512(PRODDATE, PRODSEQ, PRODSZNO) = True Then
                z0512 = D0512
		K0512_MOVE = True
		else
	z0512 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0512")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PRODDATE":z0512.ProdDate = Children(i).Code
   Case "PRODSEQ":z0512.ProdSeq = Children(i).Code
   Case "PRODSZNO":z0512.ProdSzno = Children(i).Code
   Case "QTYPRODUCTION":z0512.QtyProduction = Children(i).Code
   Case "QTYPRODUCTIONA":z0512.QtyProductionA = Children(i).Code
   Case "QTYPRODUCTIONX":z0512.QtyProductionX = Children(i).Code
   Case "QTYPRODUCTIONXP":z0512.QtyProductionXP = Children(i).Code
   Case "QTYPRODUCTIONXD":z0512.QtyProductionXD = Children(i).Code
   Case "QTYPRODUCTIONXR":z0512.QtyProductionXR = Children(i).Code
   Case "QTYOUTPRODUCTION":z0512.QtyOutProduction = Children(i).Code
   Case "QTYBLOUT":z0512.QtyBLOut = Children(i).Code
   Case "QTYBLIN":z0512.QtyBLIn = Children(i).Code
   Case "CHECKL":z0512.CheckL = Children(i).Code
   Case "CHECKR":z0512.CheckR = Children(i).Code
   Case "ISUD":z0512.ISUD = Children(i).Code
   Case "CHECKCOMPLETE":z0512.CheckComplete = Children(i).Code
   Case "CHECKTRIGGER":z0512.CheckTrigger = Children(i).Code
   Case "REMARK":z0512.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PRODDATE":z0512.ProdDate = Children(i).Data
   Case "PRODSEQ":z0512.ProdSeq = Children(i).Data
   Case "PRODSZNO":z0512.ProdSzno = Children(i).Data
   Case "QTYPRODUCTION":z0512.QtyProduction = Children(i).Data
   Case "QTYPRODUCTIONA":z0512.QtyProductionA = Children(i).Data
   Case "QTYPRODUCTIONX":z0512.QtyProductionX = Children(i).Data
   Case "QTYPRODUCTIONXP":z0512.QtyProductionXP = Children(i).Data
   Case "QTYPRODUCTIONXD":z0512.QtyProductionXD = Children(i).Data
   Case "QTYPRODUCTIONXR":z0512.QtyProductionXR = Children(i).Data
   Case "QTYOUTPRODUCTION":z0512.QtyOutProduction = Children(i).Data
   Case "QTYBLOUT":z0512.QtyBLOut = Children(i).Data
   Case "QTYBLIN":z0512.QtyBLIn = Children(i).Data
   Case "CHECKL":z0512.CheckL = Children(i).Data
   Case "CHECKR":z0512.CheckR = Children(i).Data
   Case "ISUD":z0512.ISUD = Children(i).Data
   Case "CHECKCOMPLETE":z0512.CheckComplete = Children(i).Data
   Case "CHECKTRIGGER":z0512.CheckTrigger = Children(i).Data
   Case "REMARK":z0512.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0512_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K0512_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z0512 As T0512_AREA, Job as String, CheckClear as Boolean, PRODDATE AS String, PRODSEQ AS String, PRODSZNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K0512_MOVE = False

Try
    If READ_PFK0512(PRODDATE, PRODSEQ, PRODSZNO) = True Then
                z0512 = D0512
		K0512_MOVE = True
		else
	If CheckClear  = True then z0512 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0512")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PRODDATE":z0512.ProdDate = Children(i).Code
   Case "PRODSEQ":z0512.ProdSeq = Children(i).Code
   Case "PRODSZNO":z0512.ProdSzno = Children(i).Code
   Case "QTYPRODUCTION":z0512.QtyProduction = Children(i).Code
   Case "QTYPRODUCTIONA":z0512.QtyProductionA = Children(i).Code
   Case "QTYPRODUCTIONX":z0512.QtyProductionX = Children(i).Code
   Case "QTYPRODUCTIONXP":z0512.QtyProductionXP = Children(i).Code
   Case "QTYPRODUCTIONXD":z0512.QtyProductionXD = Children(i).Code
   Case "QTYPRODUCTIONXR":z0512.QtyProductionXR = Children(i).Code
   Case "QTYOUTPRODUCTION":z0512.QtyOutProduction = Children(i).Code
   Case "QTYBLOUT":z0512.QtyBLOut = Children(i).Code
   Case "QTYBLIN":z0512.QtyBLIn = Children(i).Code
   Case "CHECKL":z0512.CheckL = Children(i).Code
   Case "CHECKR":z0512.CheckR = Children(i).Code
   Case "ISUD":z0512.ISUD = Children(i).Code
   Case "CHECKCOMPLETE":z0512.CheckComplete = Children(i).Code
   Case "CHECKTRIGGER":z0512.CheckTrigger = Children(i).Code
   Case "REMARK":z0512.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PRODDATE":z0512.ProdDate = Children(i).Data
   Case "PRODSEQ":z0512.ProdSeq = Children(i).Data
   Case "PRODSZNO":z0512.ProdSzno = Children(i).Data
   Case "QTYPRODUCTION":z0512.QtyProduction = Children(i).Data
   Case "QTYPRODUCTIONA":z0512.QtyProductionA = Children(i).Data
   Case "QTYPRODUCTIONX":z0512.QtyProductionX = Children(i).Data
   Case "QTYPRODUCTIONXP":z0512.QtyProductionXP = Children(i).Data
   Case "QTYPRODUCTIONXD":z0512.QtyProductionXD = Children(i).Data
   Case "QTYPRODUCTIONXR":z0512.QtyProductionXR = Children(i).Data
   Case "QTYOUTPRODUCTION":z0512.QtyOutProduction = Children(i).Data
   Case "QTYBLOUT":z0512.QtyBLOut = Children(i).Data
   Case "QTYBLIN":z0512.QtyBLIn = Children(i).Data
   Case "CHECKL":z0512.CheckL = Children(i).Data
   Case "CHECKR":z0512.CheckR = Children(i).Data
   Case "ISUD":z0512.ISUD = Children(i).Data
   Case "CHECKCOMPLETE":z0512.CheckComplete = Children(i).Data
   Case "CHECKTRIGGER":z0512.CheckTrigger = Children(i).Data
   Case "REMARK":z0512.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K0512_MOVE",vbCritical)
End Try
End Function 
    
End Module 
