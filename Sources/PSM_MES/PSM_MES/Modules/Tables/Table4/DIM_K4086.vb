'=========================================================================================================================================================
'   TABLE : (PFK4086)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K4086

Structure T4086_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	AutoKey	 AS Double	'			decimal		*
Public 	seFactory	 AS String	'			char(3)
Public 	cdFactory	 AS String	'			char(3)
Public 	seQCProcess	 AS String	'			char(3)
Public 	cdQCProcess	 AS String	'			char(3)
Public 	seDefect	 AS String	'			char(3)
Public 	cdDefect	 AS String	'			char(3)
Public 	seLineProd	 AS String	'			char(3)
Public 	cdLineProd	 AS String	'			char(3)
Public 	DateAccept	 AS String	'			char(8)
Public 	InchargeQC	 AS String	'			char(8)
Public 	QtyHour01	 AS Double	'			decimal
Public 	QtyHour02	 AS Double	'			decimal
Public 	QtyHour03	 AS Double	'			decimal
Public 	QtyHour04	 AS Double	'			decimal
Public 	QtyHour05	 AS Double	'			decimal
Public 	QtyHour06	 AS Double	'			decimal
Public 	QtyHour07	 AS Double	'			decimal
Public 	QtyHour08	 AS Double	'			decimal
Public 	QtyHour09	 AS Double	'			decimal
Public 	QtyHour10	 AS Double	'			decimal
Public 	QtyHour11	 AS Double	'			decimal
Public 	QtyHour12	 AS Double	'			decimal
Public 	QtyHour13	 AS Double	'			decimal
Public 	QtyHour14	 AS Double	'			decimal
Public 	QtyHour15	 AS Double	'			decimal
Public 	QtyHour16	 AS Double	'			decimal
Public 	QtyHour17	 AS Double	'			decimal
Public 	QtyHour18	 AS Double	'			decimal
Public 	QtyHour19	 AS Double	'			decimal
Public 	QtyHour20	 AS Double	'			decimal
Public 	QtyTotal	 AS Double	'			decimal
Public 	Remark	 AS String	'			nvarchar(50)
'=========================================================================================================================================================
End structure

Public D4086 As T4086_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK4086(AUTOKEY AS Double) As Boolean
    READ_PFK4086 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4086 "
    SQL = SQL & " WHERE K4086_AutoKey		 =  " & AutoKey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D4086_CLEAR: GoTo SKIP_READ_PFK4086
                
    Call K4086_MOVE(rd)
    READ_PFK4086 = True

SKIP_READ_PFK4086:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK4086",vbCritical)
 End Try
    End Function

    Public Function READ_PFK4086_1(cdFactory As String, cdQCProcess As String, seDefect As String, cdDefect As String, cdLineProd As String, DateAccept As String) As Boolean
        READ_PFK4086_1 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4086 "
            SQL = SQL & " WHERE K4086_cdFactory		 =  '" & cdFactory & "'  "
            SQL = SQL & " AND K4086_cdQCProcess		 =  '" & cdQCProcess & "'  "
            SQL = SQL & " AND K4086_seDefect		 =  '" & seDefect & "'  "
            SQL = SQL & " AND K4086_cdDefect		 =  '" & cdDefect & "'  "
            SQL = SQL & " AND K4086_cdLineProd		 =  '" & cdLineProd & "'  "
            SQL = SQL & " AND K4086_DateAccept		 =  '" & DateAccept & "'  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4086_CLEAR() : GoTo SKIP_READ_PFK4086

            Call K4086_MOVE(rd)
            READ_PFK4086_1 = True

SKIP_READ_PFK4086:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4086", vbCritical)
        End Try
    End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK4086(AUTOKEY AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4086 "
    SQL = SQL & " WHERE K4086_AutoKey		 =  " & AutoKey & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK4086",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK4086(z4086 As T4086_AREA) As Boolean
    WRITE_PFK4086 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z4086)
 
    SQL = " INSERT INTO PFK4086 "
    SQL = SQL & " ( "
    SQL = SQL & " K4086_seFactory," 
    SQL = SQL & " K4086_cdFactory," 
    SQL = SQL & " K4086_seQCProcess," 
    SQL = SQL & " K4086_cdQCProcess," 
    SQL = SQL & " K4086_seDefect," 
    SQL = SQL & " K4086_cdDefect," 
    SQL = SQL & " K4086_seLineProd," 
    SQL = SQL & " K4086_cdLineProd," 
    SQL = SQL & " K4086_DateAccept," 
    SQL = SQL & " K4086_InchargeQC," 
    SQL = SQL & " K4086_QtyHour01," 
    SQL = SQL & " K4086_QtyHour02," 
    SQL = SQL & " K4086_QtyHour03," 
    SQL = SQL & " K4086_QtyHour04," 
    SQL = SQL & " K4086_QtyHour05," 
    SQL = SQL & " K4086_QtyHour06," 
    SQL = SQL & " K4086_QtyHour07," 
    SQL = SQL & " K4086_QtyHour08," 
    SQL = SQL & " K4086_QtyHour09," 
    SQL = SQL & " K4086_QtyHour10," 
    SQL = SQL & " K4086_QtyHour11," 
    SQL = SQL & " K4086_QtyHour12," 
    SQL = SQL & " K4086_QtyHour13," 
    SQL = SQL & " K4086_QtyHour14," 
    SQL = SQL & " K4086_QtyHour15," 
    SQL = SQL & " K4086_QtyHour16," 
    SQL = SQL & " K4086_QtyHour17," 
    SQL = SQL & " K4086_QtyHour18," 
    SQL = SQL & " K4086_QtyHour19," 
    SQL = SQL & " K4086_QtyHour20," 
    SQL = SQL & " K4086_QtyTotal," 
    SQL = SQL & " K4086_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z4086.seFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4086.cdFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4086.seQCProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4086.cdQCProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4086.seDefect) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4086.cdDefect) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4086.seLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4086.cdLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4086.DateAccept) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4086.InchargeQC) & "', "  
    SQL = SQL & "   " & FormatSQL(z4086.QtyHour01) & ", "  
    SQL = SQL & "   " & FormatSQL(z4086.QtyHour02) & ", "  
    SQL = SQL & "   " & FormatSQL(z4086.QtyHour03) & ", "  
    SQL = SQL & "   " & FormatSQL(z4086.QtyHour04) & ", "  
    SQL = SQL & "   " & FormatSQL(z4086.QtyHour05) & ", "  
    SQL = SQL & "   " & FormatSQL(z4086.QtyHour06) & ", "  
    SQL = SQL & "   " & FormatSQL(z4086.QtyHour07) & ", "  
    SQL = SQL & "   " & FormatSQL(z4086.QtyHour08) & ", "  
    SQL = SQL & "   " & FormatSQL(z4086.QtyHour09) & ", "  
    SQL = SQL & "   " & FormatSQL(z4086.QtyHour10) & ", "  
    SQL = SQL & "   " & FormatSQL(z4086.QtyHour11) & ", "  
    SQL = SQL & "   " & FormatSQL(z4086.QtyHour12) & ", "  
    SQL = SQL & "   " & FormatSQL(z4086.QtyHour13) & ", "  
    SQL = SQL & "   " & FormatSQL(z4086.QtyHour14) & ", "  
    SQL = SQL & "   " & FormatSQL(z4086.QtyHour15) & ", "  
    SQL = SQL & "   " & FormatSQL(z4086.QtyHour16) & ", "  
    SQL = SQL & "   " & FormatSQL(z4086.QtyHour17) & ", "  
    SQL = SQL & "   " & FormatSQL(z4086.QtyHour18) & ", "  
    SQL = SQL & "   " & FormatSQL(z4086.QtyHour19) & ", "  
    SQL = SQL & "   " & FormatSQL(z4086.QtyHour20) & ", "  
    SQL = SQL & "   " & FormatSQL(z4086.QtyTotal) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4086.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK4086 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK4086",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK4086(z4086 As T4086_AREA) As Boolean
    REWRITE_PFK4086 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z4086)
   
    SQL = " UPDATE PFK4086 SET "
    SQL = SQL & "    K4086_seFactory      = N'" & FormatSQL(z4086.seFactory) & "', " 
    SQL = SQL & "    K4086_cdFactory      = N'" & FormatSQL(z4086.cdFactory) & "', " 
    SQL = SQL & "    K4086_seQCProcess      = N'" & FormatSQL(z4086.seQCProcess) & "', " 
    SQL = SQL & "    K4086_cdQCProcess      = N'" & FormatSQL(z4086.cdQCProcess) & "', " 
    SQL = SQL & "    K4086_seDefect      = N'" & FormatSQL(z4086.seDefect) & "', " 
    SQL = SQL & "    K4086_cdDefect      = N'" & FormatSQL(z4086.cdDefect) & "', " 
    SQL = SQL & "    K4086_seLineProd      = N'" & FormatSQL(z4086.seLineProd) & "', " 
    SQL = SQL & "    K4086_cdLineProd      = N'" & FormatSQL(z4086.cdLineProd) & "', " 
    SQL = SQL & "    K4086_DateAccept      = N'" & FormatSQL(z4086.DateAccept) & "', " 
    SQL = SQL & "    K4086_InchargeQC      = N'" & FormatSQL(z4086.InchargeQC) & "', " 
    SQL = SQL & "    K4086_QtyHour01      =  " & FormatSQL(z4086.QtyHour01) & ", " 
    SQL = SQL & "    K4086_QtyHour02      =  " & FormatSQL(z4086.QtyHour02) & ", " 
    SQL = SQL & "    K4086_QtyHour03      =  " & FormatSQL(z4086.QtyHour03) & ", " 
    SQL = SQL & "    K4086_QtyHour04      =  " & FormatSQL(z4086.QtyHour04) & ", " 
    SQL = SQL & "    K4086_QtyHour05      =  " & FormatSQL(z4086.QtyHour05) & ", " 
    SQL = SQL & "    K4086_QtyHour06      =  " & FormatSQL(z4086.QtyHour06) & ", " 
    SQL = SQL & "    K4086_QtyHour07      =  " & FormatSQL(z4086.QtyHour07) & ", " 
    SQL = SQL & "    K4086_QtyHour08      =  " & FormatSQL(z4086.QtyHour08) & ", " 
    SQL = SQL & "    K4086_QtyHour09      =  " & FormatSQL(z4086.QtyHour09) & ", " 
    SQL = SQL & "    K4086_QtyHour10      =  " & FormatSQL(z4086.QtyHour10) & ", " 
    SQL = SQL & "    K4086_QtyHour11      =  " & FormatSQL(z4086.QtyHour11) & ", " 
    SQL = SQL & "    K4086_QtyHour12      =  " & FormatSQL(z4086.QtyHour12) & ", " 
    SQL = SQL & "    K4086_QtyHour13      =  " & FormatSQL(z4086.QtyHour13) & ", " 
    SQL = SQL & "    K4086_QtyHour14      =  " & FormatSQL(z4086.QtyHour14) & ", " 
    SQL = SQL & "    K4086_QtyHour15      =  " & FormatSQL(z4086.QtyHour15) & ", " 
    SQL = SQL & "    K4086_QtyHour16      =  " & FormatSQL(z4086.QtyHour16) & ", " 
    SQL = SQL & "    K4086_QtyHour17      =  " & FormatSQL(z4086.QtyHour17) & ", " 
    SQL = SQL & "    K4086_QtyHour18      =  " & FormatSQL(z4086.QtyHour18) & ", " 
    SQL = SQL & "    K4086_QtyHour19      =  " & FormatSQL(z4086.QtyHour19) & ", " 
    SQL = SQL & "    K4086_QtyHour20      =  " & FormatSQL(z4086.QtyHour20) & ", " 
    SQL = SQL & "    K4086_QtyTotal      =  " & FormatSQL(z4086.QtyTotal) & ", " 
    SQL = SQL & "    K4086_Remark      = N'" & FormatSQL(z4086.Remark) & "'  " 
    SQL = SQL & " WHERE K4086_AutoKey		 =  " & z4086.AutoKey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK4086 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK4086",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK4086(z4086 As T4086_AREA) As Boolean
    DELETE_PFK4086 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK4086 "
    SQL = SQL & " WHERE K4086_AutoKey		 =  " & z4086.AutoKey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK4086 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK4086",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D4086_CLEAR()
Try
    
    D4086.AutoKey = 0 
   D4086.seFactory = ""
   D4086.cdFactory = ""
   D4086.seQCProcess = ""
   D4086.cdQCProcess = ""
   D4086.seDefect = ""
   D4086.cdDefect = ""
   D4086.seLineProd = ""
   D4086.cdLineProd = ""
   D4086.DateAccept = ""
   D4086.InchargeQC = ""
    D4086.QtyHour01 = 0 
    D4086.QtyHour02 = 0 
    D4086.QtyHour03 = 0 
    D4086.QtyHour04 = 0 
    D4086.QtyHour05 = 0 
    D4086.QtyHour06 = 0 
    D4086.QtyHour07 = 0 
    D4086.QtyHour08 = 0 
    D4086.QtyHour09 = 0 
    D4086.QtyHour10 = 0 
    D4086.QtyHour11 = 0 
    D4086.QtyHour12 = 0 
    D4086.QtyHour13 = 0 
    D4086.QtyHour14 = 0 
    D4086.QtyHour15 = 0 
    D4086.QtyHour16 = 0 
    D4086.QtyHour17 = 0 
    D4086.QtyHour18 = 0 
    D4086.QtyHour19 = 0 
    D4086.QtyHour20 = 0 
    D4086.QtyTotal = 0 
   D4086.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D4086_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x4086 As T4086_AREA)
Try
    
    x4086.AutoKey = trim$(  x4086.AutoKey)
    x4086.seFactory = trim$(  x4086.seFactory)
    x4086.cdFactory = trim$(  x4086.cdFactory)
    x4086.seQCProcess = trim$(  x4086.seQCProcess)
    x4086.cdQCProcess = trim$(  x4086.cdQCProcess)
    x4086.seDefect = trim$(  x4086.seDefect)
    x4086.cdDefect = trim$(  x4086.cdDefect)
    x4086.seLineProd = trim$(  x4086.seLineProd)
    x4086.cdLineProd = trim$(  x4086.cdLineProd)
    x4086.DateAccept = trim$(  x4086.DateAccept)
    x4086.InchargeQC = trim$(  x4086.InchargeQC)
    x4086.QtyHour01 = trim$(  x4086.QtyHour01)
    x4086.QtyHour02 = trim$(  x4086.QtyHour02)
    x4086.QtyHour03 = trim$(  x4086.QtyHour03)
    x4086.QtyHour04 = trim$(  x4086.QtyHour04)
    x4086.QtyHour05 = trim$(  x4086.QtyHour05)
    x4086.QtyHour06 = trim$(  x4086.QtyHour06)
    x4086.QtyHour07 = trim$(  x4086.QtyHour07)
    x4086.QtyHour08 = trim$(  x4086.QtyHour08)
    x4086.QtyHour09 = trim$(  x4086.QtyHour09)
    x4086.QtyHour10 = trim$(  x4086.QtyHour10)
    x4086.QtyHour11 = trim$(  x4086.QtyHour11)
    x4086.QtyHour12 = trim$(  x4086.QtyHour12)
    x4086.QtyHour13 = trim$(  x4086.QtyHour13)
    x4086.QtyHour14 = trim$(  x4086.QtyHour14)
    x4086.QtyHour15 = trim$(  x4086.QtyHour15)
    x4086.QtyHour16 = trim$(  x4086.QtyHour16)
    x4086.QtyHour17 = trim$(  x4086.QtyHour17)
    x4086.QtyHour18 = trim$(  x4086.QtyHour18)
    x4086.QtyHour19 = trim$(  x4086.QtyHour19)
    x4086.QtyHour20 = trim$(  x4086.QtyHour20)
    x4086.QtyTotal = trim$(  x4086.QtyTotal)
    x4086.Remark = trim$(  x4086.Remark)
     
    If trim$( x4086.AutoKey ) = "" Then x4086.AutoKey = 0 
    If trim$( x4086.seFactory ) = "" Then x4086.seFactory = Space(1) 
    If trim$( x4086.cdFactory ) = "" Then x4086.cdFactory = Space(1) 
    If trim$( x4086.seQCProcess ) = "" Then x4086.seQCProcess = Space(1) 
    If trim$( x4086.cdQCProcess ) = "" Then x4086.cdQCProcess = Space(1) 
    If trim$( x4086.seDefect ) = "" Then x4086.seDefect = Space(1) 
    If trim$( x4086.cdDefect ) = "" Then x4086.cdDefect = Space(1) 
    If trim$( x4086.seLineProd ) = "" Then x4086.seLineProd = Space(1) 
    If trim$( x4086.cdLineProd ) = "" Then x4086.cdLineProd = Space(1) 
    If trim$( x4086.DateAccept ) = "" Then x4086.DateAccept = Space(1) 
    If trim$( x4086.InchargeQC ) = "" Then x4086.InchargeQC = Space(1) 
    If trim$( x4086.QtyHour01 ) = "" Then x4086.QtyHour01 = 0 
    If trim$( x4086.QtyHour02 ) = "" Then x4086.QtyHour02 = 0 
    If trim$( x4086.QtyHour03 ) = "" Then x4086.QtyHour03 = 0 
    If trim$( x4086.QtyHour04 ) = "" Then x4086.QtyHour04 = 0 
    If trim$( x4086.QtyHour05 ) = "" Then x4086.QtyHour05 = 0 
    If trim$( x4086.QtyHour06 ) = "" Then x4086.QtyHour06 = 0 
    If trim$( x4086.QtyHour07 ) = "" Then x4086.QtyHour07 = 0 
    If trim$( x4086.QtyHour08 ) = "" Then x4086.QtyHour08 = 0 
    If trim$( x4086.QtyHour09 ) = "" Then x4086.QtyHour09 = 0 
    If trim$( x4086.QtyHour10 ) = "" Then x4086.QtyHour10 = 0 
    If trim$( x4086.QtyHour11 ) = "" Then x4086.QtyHour11 = 0 
    If trim$( x4086.QtyHour12 ) = "" Then x4086.QtyHour12 = 0 
    If trim$( x4086.QtyHour13 ) = "" Then x4086.QtyHour13 = 0 
    If trim$( x4086.QtyHour14 ) = "" Then x4086.QtyHour14 = 0 
    If trim$( x4086.QtyHour15 ) = "" Then x4086.QtyHour15 = 0 
    If trim$( x4086.QtyHour16 ) = "" Then x4086.QtyHour16 = 0 
    If trim$( x4086.QtyHour17 ) = "" Then x4086.QtyHour17 = 0 
    If trim$( x4086.QtyHour18 ) = "" Then x4086.QtyHour18 = 0 
    If trim$( x4086.QtyHour19 ) = "" Then x4086.QtyHour19 = 0 
    If trim$( x4086.QtyHour20 ) = "" Then x4086.QtyHour20 = 0 
    If trim$( x4086.QtyTotal ) = "" Then x4086.QtyTotal = 0 
    If trim$( x4086.Remark ) = "" Then x4086.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K4086_MOVE(rs4086 As SqlClient.SqlDataReader)
Try

    call D4086_CLEAR()   

    If IsdbNull(rs4086!K4086_AutoKey) = False Then D4086.AutoKey = Trim$(rs4086!K4086_AutoKey)
    If IsdbNull(rs4086!K4086_seFactory) = False Then D4086.seFactory = Trim$(rs4086!K4086_seFactory)
    If IsdbNull(rs4086!K4086_cdFactory) = False Then D4086.cdFactory = Trim$(rs4086!K4086_cdFactory)
    If IsdbNull(rs4086!K4086_seQCProcess) = False Then D4086.seQCProcess = Trim$(rs4086!K4086_seQCProcess)
    If IsdbNull(rs4086!K4086_cdQCProcess) = False Then D4086.cdQCProcess = Trim$(rs4086!K4086_cdQCProcess)
    If IsdbNull(rs4086!K4086_seDefect) = False Then D4086.seDefect = Trim$(rs4086!K4086_seDefect)
    If IsdbNull(rs4086!K4086_cdDefect) = False Then D4086.cdDefect = Trim$(rs4086!K4086_cdDefect)
    If IsdbNull(rs4086!K4086_seLineProd) = False Then D4086.seLineProd = Trim$(rs4086!K4086_seLineProd)
    If IsdbNull(rs4086!K4086_cdLineProd) = False Then D4086.cdLineProd = Trim$(rs4086!K4086_cdLineProd)
    If IsdbNull(rs4086!K4086_DateAccept) = False Then D4086.DateAccept = Trim$(rs4086!K4086_DateAccept)
    If IsdbNull(rs4086!K4086_InchargeQC) = False Then D4086.InchargeQC = Trim$(rs4086!K4086_InchargeQC)
    If IsdbNull(rs4086!K4086_QtyHour01) = False Then D4086.QtyHour01 = Trim$(rs4086!K4086_QtyHour01)
    If IsdbNull(rs4086!K4086_QtyHour02) = False Then D4086.QtyHour02 = Trim$(rs4086!K4086_QtyHour02)
    If IsdbNull(rs4086!K4086_QtyHour03) = False Then D4086.QtyHour03 = Trim$(rs4086!K4086_QtyHour03)
    If IsdbNull(rs4086!K4086_QtyHour04) = False Then D4086.QtyHour04 = Trim$(rs4086!K4086_QtyHour04)
    If IsdbNull(rs4086!K4086_QtyHour05) = False Then D4086.QtyHour05 = Trim$(rs4086!K4086_QtyHour05)
    If IsdbNull(rs4086!K4086_QtyHour06) = False Then D4086.QtyHour06 = Trim$(rs4086!K4086_QtyHour06)
    If IsdbNull(rs4086!K4086_QtyHour07) = False Then D4086.QtyHour07 = Trim$(rs4086!K4086_QtyHour07)
    If IsdbNull(rs4086!K4086_QtyHour08) = False Then D4086.QtyHour08 = Trim$(rs4086!K4086_QtyHour08)
    If IsdbNull(rs4086!K4086_QtyHour09) = False Then D4086.QtyHour09 = Trim$(rs4086!K4086_QtyHour09)
    If IsdbNull(rs4086!K4086_QtyHour10) = False Then D4086.QtyHour10 = Trim$(rs4086!K4086_QtyHour10)
    If IsdbNull(rs4086!K4086_QtyHour11) = False Then D4086.QtyHour11 = Trim$(rs4086!K4086_QtyHour11)
    If IsdbNull(rs4086!K4086_QtyHour12) = False Then D4086.QtyHour12 = Trim$(rs4086!K4086_QtyHour12)
    If IsdbNull(rs4086!K4086_QtyHour13) = False Then D4086.QtyHour13 = Trim$(rs4086!K4086_QtyHour13)
    If IsdbNull(rs4086!K4086_QtyHour14) = False Then D4086.QtyHour14 = Trim$(rs4086!K4086_QtyHour14)
    If IsdbNull(rs4086!K4086_QtyHour15) = False Then D4086.QtyHour15 = Trim$(rs4086!K4086_QtyHour15)
    If IsdbNull(rs4086!K4086_QtyHour16) = False Then D4086.QtyHour16 = Trim$(rs4086!K4086_QtyHour16)
    If IsdbNull(rs4086!K4086_QtyHour17) = False Then D4086.QtyHour17 = Trim$(rs4086!K4086_QtyHour17)
    If IsdbNull(rs4086!K4086_QtyHour18) = False Then D4086.QtyHour18 = Trim$(rs4086!K4086_QtyHour18)
    If IsdbNull(rs4086!K4086_QtyHour19) = False Then D4086.QtyHour19 = Trim$(rs4086!K4086_QtyHour19)
    If IsdbNull(rs4086!K4086_QtyHour20) = False Then D4086.QtyHour20 = Trim$(rs4086!K4086_QtyHour20)
    If IsdbNull(rs4086!K4086_QtyTotal) = False Then D4086.QtyTotal = Trim$(rs4086!K4086_QtyTotal)
    If IsdbNull(rs4086!K4086_Remark) = False Then D4086.Remark = Trim$(rs4086!K4086_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4086_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K4086_MOVE(rs4086 As DataRow)
Try

    call D4086_CLEAR()   

    If IsdbNull(rs4086!K4086_AutoKey) = False Then D4086.AutoKey = Trim$(rs4086!K4086_AutoKey)
    If IsdbNull(rs4086!K4086_seFactory) = False Then D4086.seFactory = Trim$(rs4086!K4086_seFactory)
    If IsdbNull(rs4086!K4086_cdFactory) = False Then D4086.cdFactory = Trim$(rs4086!K4086_cdFactory)
    If IsdbNull(rs4086!K4086_seQCProcess) = False Then D4086.seQCProcess = Trim$(rs4086!K4086_seQCProcess)
    If IsdbNull(rs4086!K4086_cdQCProcess) = False Then D4086.cdQCProcess = Trim$(rs4086!K4086_cdQCProcess)
    If IsdbNull(rs4086!K4086_seDefect) = False Then D4086.seDefect = Trim$(rs4086!K4086_seDefect)
    If IsdbNull(rs4086!K4086_cdDefect) = False Then D4086.cdDefect = Trim$(rs4086!K4086_cdDefect)
    If IsdbNull(rs4086!K4086_seLineProd) = False Then D4086.seLineProd = Trim$(rs4086!K4086_seLineProd)
    If IsdbNull(rs4086!K4086_cdLineProd) = False Then D4086.cdLineProd = Trim$(rs4086!K4086_cdLineProd)
    If IsdbNull(rs4086!K4086_DateAccept) = False Then D4086.DateAccept = Trim$(rs4086!K4086_DateAccept)
    If IsdbNull(rs4086!K4086_InchargeQC) = False Then D4086.InchargeQC = Trim$(rs4086!K4086_InchargeQC)
    If IsdbNull(rs4086!K4086_QtyHour01) = False Then D4086.QtyHour01 = Trim$(rs4086!K4086_QtyHour01)
    If IsdbNull(rs4086!K4086_QtyHour02) = False Then D4086.QtyHour02 = Trim$(rs4086!K4086_QtyHour02)
    If IsdbNull(rs4086!K4086_QtyHour03) = False Then D4086.QtyHour03 = Trim$(rs4086!K4086_QtyHour03)
    If IsdbNull(rs4086!K4086_QtyHour04) = False Then D4086.QtyHour04 = Trim$(rs4086!K4086_QtyHour04)
    If IsdbNull(rs4086!K4086_QtyHour05) = False Then D4086.QtyHour05 = Trim$(rs4086!K4086_QtyHour05)
    If IsdbNull(rs4086!K4086_QtyHour06) = False Then D4086.QtyHour06 = Trim$(rs4086!K4086_QtyHour06)
    If IsdbNull(rs4086!K4086_QtyHour07) = False Then D4086.QtyHour07 = Trim$(rs4086!K4086_QtyHour07)
    If IsdbNull(rs4086!K4086_QtyHour08) = False Then D4086.QtyHour08 = Trim$(rs4086!K4086_QtyHour08)
    If IsdbNull(rs4086!K4086_QtyHour09) = False Then D4086.QtyHour09 = Trim$(rs4086!K4086_QtyHour09)
    If IsdbNull(rs4086!K4086_QtyHour10) = False Then D4086.QtyHour10 = Trim$(rs4086!K4086_QtyHour10)
    If IsdbNull(rs4086!K4086_QtyHour11) = False Then D4086.QtyHour11 = Trim$(rs4086!K4086_QtyHour11)
    If IsdbNull(rs4086!K4086_QtyHour12) = False Then D4086.QtyHour12 = Trim$(rs4086!K4086_QtyHour12)
    If IsdbNull(rs4086!K4086_QtyHour13) = False Then D4086.QtyHour13 = Trim$(rs4086!K4086_QtyHour13)
    If IsdbNull(rs4086!K4086_QtyHour14) = False Then D4086.QtyHour14 = Trim$(rs4086!K4086_QtyHour14)
    If IsdbNull(rs4086!K4086_QtyHour15) = False Then D4086.QtyHour15 = Trim$(rs4086!K4086_QtyHour15)
    If IsdbNull(rs4086!K4086_QtyHour16) = False Then D4086.QtyHour16 = Trim$(rs4086!K4086_QtyHour16)
    If IsdbNull(rs4086!K4086_QtyHour17) = False Then D4086.QtyHour17 = Trim$(rs4086!K4086_QtyHour17)
    If IsdbNull(rs4086!K4086_QtyHour18) = False Then D4086.QtyHour18 = Trim$(rs4086!K4086_QtyHour18)
    If IsdbNull(rs4086!K4086_QtyHour19) = False Then D4086.QtyHour19 = Trim$(rs4086!K4086_QtyHour19)
    If IsdbNull(rs4086!K4086_QtyHour20) = False Then D4086.QtyHour20 = Trim$(rs4086!K4086_QtyHour20)
    If IsdbNull(rs4086!K4086_QtyTotal) = False Then D4086.QtyTotal = Trim$(rs4086!K4086_QtyTotal)
    If IsdbNull(rs4086!K4086_Remark) = False Then D4086.Remark = Trim$(rs4086!K4086_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4086_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
    Public Function K4086_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z4086 As T4086_AREA, AUTOKEY As Double) As Boolean

        K4086_MOVE = False

        Try
            If READ_PFK4086(AUTOKEY) = True Then
                z4086 = D4086
                K4086_MOVE = True
            Else
                z4086 = Nothing
            End If

            If getColumIndex(spr, "AutoKey") > -1 Then z4086.AutoKey = getDataM(spr, getColumIndex(spr, "AutoKey"), xRow)
            If getColumIndex(spr, "seFactory") > -1 Then z4086.seFactory = getDataM(spr, getColumIndex(spr, "seFactory"), xRow)
            If getColumIndex(spr, "cdFactory") > -1 Then z4086.cdFactory = getDataM(spr, getColumIndex(spr, "cdFactory"), xRow)
            If getColumIndex(spr, "seQCProcess") > -1 Then z4086.seQCProcess = getDataM(spr, getColumIndex(spr, "seQCProcess"), xRow)
            If getColumIndex(spr, "cdQCProcess") > -1 Then z4086.cdQCProcess = getDataM(spr, getColumIndex(spr, "cdQCProcess"), xRow)
            If getColumIndex(spr, "seDefect") > -1 Then z4086.seDefect = getDataM(spr, getColumIndex(spr, "seDefect"), xRow)
            If getColumIndex(spr, "cdDefect") > -1 Then z4086.cdDefect = getDataM(spr, getColumIndex(spr, "cdDefect"), xRow)
            If getColumIndex(spr, "seLineProd") > -1 Then z4086.seLineProd = getDataM(spr, getColumIndex(spr, "seLineProd"), xRow)
            If getColumIndex(spr, "cdLineProd") > -1 Then z4086.cdLineProd = getDataM(spr, getColumIndex(spr, "cdLineProd"), xRow)
            If getColumIndex(spr, "DateAccept") > -1 Then z4086.DateAccept = getDataM(spr, getColumIndex(spr, "DateAccept"), xRow)
            If getColumIndex(spr, "InchargeQC") > -1 Then z4086.InchargeQC = getDataM(spr, getColumIndex(spr, "InchargeQC"), xRow)
            If getColumIndex(spr, "QtyHour01") > -1 Then z4086.QtyHour01 = getDataM(spr, getColumIndex(spr, "QtyHour01"), xRow)
            If getColumIndex(spr, "QtyHour02") > -1 Then z4086.QtyHour02 = getDataM(spr, getColumIndex(spr, "QtyHour02"), xRow)
            If getColumIndex(spr, "QtyHour03") > -1 Then z4086.QtyHour03 = getDataM(spr, getColumIndex(spr, "QtyHour03"), xRow)
            If getColumIndex(spr, "QtyHour04") > -1 Then z4086.QtyHour04 = getDataM(spr, getColumIndex(spr, "QtyHour04"), xRow)
            If getColumIndex(spr, "QtyHour05") > -1 Then z4086.QtyHour05 = getDataM(spr, getColumIndex(spr, "QtyHour05"), xRow)
            If getColumIndex(spr, "QtyHour06") > -1 Then z4086.QtyHour06 = getDataM(spr, getColumIndex(spr, "QtyHour06"), xRow)
            If getColumIndex(spr, "QtyHour07") > -1 Then z4086.QtyHour07 = getDataM(spr, getColumIndex(spr, "QtyHour07"), xRow)
            If getColumIndex(spr, "QtyHour08") > -1 Then z4086.QtyHour08 = getDataM(spr, getColumIndex(spr, "QtyHour08"), xRow)
            If getColumIndex(spr, "QtyHour09") > -1 Then z4086.QtyHour09 = getDataM(spr, getColumIndex(spr, "QtyHour09"), xRow)
            If getColumIndex(spr, "QtyHour10") > -1 Then z4086.QtyHour10 = getDataM(spr, getColumIndex(spr, "QtyHour10"), xRow)
            If getColumIndex(spr, "QtyHour11") > -1 Then z4086.QtyHour11 = getDataM(spr, getColumIndex(spr, "QtyHour11"), xRow)
            If getColumIndex(spr, "QtyHour12") > -1 Then z4086.QtyHour12 = getDataM(spr, getColumIndex(spr, "QtyHour12"), xRow)
            If getColumIndex(spr, "QtyHour13") > -1 Then z4086.QtyHour13 = getDataM(spr, getColumIndex(spr, "QtyHour13"), xRow)
            If getColumIndex(spr, "QtyHour14") > -1 Then z4086.QtyHour14 = getDataM(spr, getColumIndex(spr, "QtyHour14"), xRow)
            If getColumIndex(spr, "QtyHour15") > -1 Then z4086.QtyHour15 = getDataM(spr, getColumIndex(spr, "QtyHour15"), xRow)
            If getColumIndex(spr, "QtyHour16") > -1 Then z4086.QtyHour16 = getDataM(spr, getColumIndex(spr, "QtyHour16"), xRow)
            If getColumIndex(spr, "QtyHour17") > -1 Then z4086.QtyHour17 = getDataM(spr, getColumIndex(spr, "QtyHour17"), xRow)
            If getColumIndex(spr, "QtyHour18") > -1 Then z4086.QtyHour18 = getDataM(spr, getColumIndex(spr, "QtyHour18"), xRow)
            If getColumIndex(spr, "QtyHour19") > -1 Then z4086.QtyHour19 = getDataM(spr, getColumIndex(spr, "QtyHour19"), xRow)
            If getColumIndex(spr, "QtyHour20") > -1 Then z4086.QtyHour20 = getDataM(spr, getColumIndex(spr, "QtyHour20"), xRow)
            If getColumIndex(spr, "QtyTotal") > -1 Then z4086.QtyTotal = getDataM(spr, getColumIndex(spr, "QtyTotal"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z4086.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4086_MOVE", vbCritical)
        End Try
    End Function

    Public Function K4086_MOVE_1(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z4086 As T4086_AREA, cdFactory As String, cdQCProcess As String, seDefect As String, cdDefect As String, cdLineProd As String, DateAccept As String) As Boolean

        K4086_MOVE_1 = False

        Try

            If READ_PFK4086_1(cdFactory, cdQCProcess, seDefect, cdDefect, cdLineProd, DateAccept) = True Then
                z4086 = D4086
                K4086_MOVE_1 = True
            Else
                z4086 = Nothing
            End If

            If getColumIndex(spr, "AutoKey") > -1 Then z4086.AutoKey = getDataM(spr, getColumIndex(spr, "AutoKey"), xRow)
            If getColumIndex(spr, "seFactory") > -1 Then z4086.seFactory = getDataM(spr, getColumIndex(spr, "seFactory"), xRow)
            If getColumIndex(spr, "cdFactory") > -1 Then z4086.cdFactory = getDataM(spr, getColumIndex(spr, "cdFactory"), xRow)
            If getColumIndex(spr, "seQCProcess") > -1 Then z4086.seQCProcess = getDataM(spr, getColumIndex(spr, "seQCProcess"), xRow)
            If getColumIndex(spr, "cdQCProcess") > -1 Then z4086.cdQCProcess = getDataM(spr, getColumIndex(spr, "cdQCProcess"), xRow)
            If getColumIndex(spr, "seDefect") > -1 Then z4086.seDefect = getDataM(spr, getColumIndex(spr, "seDefect"), xRow)
            If getColumIndex(spr, "cdDefect") > -1 Then z4086.cdDefect = getDataM(spr, getColumIndex(spr, "cdDefect"), xRow)
            If getColumIndex(spr, "seLineProd") > -1 Then z4086.seLineProd = getDataM(spr, getColumIndex(spr, "seLineProd"), xRow)
            If getColumIndex(spr, "cdLineProd") > -1 Then z4086.cdLineProd = getDataM(spr, getColumIndex(spr, "cdLineProd"), xRow)
            If getColumIndex(spr, "DateAccept") > -1 Then z4086.DateAccept = getDataM(spr, getColumIndex(spr, "DateAccept"), xRow)
            If getColumIndex(spr, "InchargeQC") > -1 Then z4086.InchargeQC = getDataM(spr, getColumIndex(spr, "InchargeQC"), xRow)
            If getColumIndex(spr, "QtyHour01") > -1 Then z4086.QtyHour01 = getDataM(spr, getColumIndex(spr, "QtyHour01"), xRow)
            If getColumIndex(spr, "QtyHour02") > -1 Then z4086.QtyHour02 = getDataM(spr, getColumIndex(spr, "QtyHour02"), xRow)
            If getColumIndex(spr, "QtyHour03") > -1 Then z4086.QtyHour03 = getDataM(spr, getColumIndex(spr, "QtyHour03"), xRow)
            If getColumIndex(spr, "QtyHour04") > -1 Then z4086.QtyHour04 = getDataM(spr, getColumIndex(spr, "QtyHour04"), xRow)
            If getColumIndex(spr, "QtyHour05") > -1 Then z4086.QtyHour05 = getDataM(spr, getColumIndex(spr, "QtyHour05"), xRow)
            If getColumIndex(spr, "QtyHour06") > -1 Then z4086.QtyHour06 = getDataM(spr, getColumIndex(spr, "QtyHour06"), xRow)
            If getColumIndex(spr, "QtyHour07") > -1 Then z4086.QtyHour07 = getDataM(spr, getColumIndex(spr, "QtyHour07"), xRow)
            If getColumIndex(spr, "QtyHour08") > -1 Then z4086.QtyHour08 = getDataM(spr, getColumIndex(spr, "QtyHour08"), xRow)
            If getColumIndex(spr, "QtyHour09") > -1 Then z4086.QtyHour09 = getDataM(spr, getColumIndex(spr, "QtyHour09"), xRow)
            If getColumIndex(spr, "QtyHour10") > -1 Then z4086.QtyHour10 = getDataM(spr, getColumIndex(spr, "QtyHour10"), xRow)
            If getColumIndex(spr, "QtyHour11") > -1 Then z4086.QtyHour11 = getDataM(spr, getColumIndex(spr, "QtyHour11"), xRow)
            If getColumIndex(spr, "QtyHour12") > -1 Then z4086.QtyHour12 = getDataM(spr, getColumIndex(spr, "QtyHour12"), xRow)
            If getColumIndex(spr, "QtyHour13") > -1 Then z4086.QtyHour13 = getDataM(spr, getColumIndex(spr, "QtyHour13"), xRow)
            If getColumIndex(spr, "QtyHour14") > -1 Then z4086.QtyHour14 = getDataM(spr, getColumIndex(spr, "QtyHour14"), xRow)
            If getColumIndex(spr, "QtyHour15") > -1 Then z4086.QtyHour15 = getDataM(spr, getColumIndex(spr, "QtyHour15"), xRow)
            If getColumIndex(spr, "QtyHour16") > -1 Then z4086.QtyHour16 = getDataM(spr, getColumIndex(spr, "QtyHour16"), xRow)
            If getColumIndex(spr, "QtyHour17") > -1 Then z4086.QtyHour17 = getDataM(spr, getColumIndex(spr, "QtyHour17"), xRow)
            If getColumIndex(spr, "QtyHour18") > -1 Then z4086.QtyHour18 = getDataM(spr, getColumIndex(spr, "QtyHour18"), xRow)
            If getColumIndex(spr, "QtyHour19") > -1 Then z4086.QtyHour19 = getDataM(spr, getColumIndex(spr, "QtyHour19"), xRow)
            If getColumIndex(spr, "QtyHour20") > -1 Then z4086.QtyHour20 = getDataM(spr, getColumIndex(spr, "QtyHour20"), xRow)
            If getColumIndex(spr, "QtyTotal") > -1 Then z4086.QtyTotal = getDataM(spr, getColumIndex(spr, "QtyTotal"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z4086.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4086_MOVE", vbCritical)
        End Try
    End Function
'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K4086_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4086 As T4086_AREA,CheckClear as Boolean,AUTOKEY AS Double) as Boolean

K4086_MOVE = False

Try
    If READ_PFK4086(AUTOKEY) = True Then
                z4086 = D4086
		K4086_MOVE = True
		else
	If CheckClear  = True then z4086 = nothing
     End If

     If  getColumIndex(spr,"AutoKey") > -1 then z4086.AutoKey = getDataM(spr, getColumIndex(spr,"AutoKey"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z4086.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"cdFactory") > -1 then z4086.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"seQCProcess") > -1 then z4086.seQCProcess = getDataM(spr, getColumIndex(spr,"seQCProcess"), xRow)
     If  getColumIndex(spr,"cdQCProcess") > -1 then z4086.cdQCProcess = getDataM(spr, getColumIndex(spr,"cdQCProcess"), xRow)
     If  getColumIndex(spr,"seDefect") > -1 then z4086.seDefect = getDataM(spr, getColumIndex(spr,"seDefect"), xRow)
     If  getColumIndex(spr,"cdDefect") > -1 then z4086.cdDefect = getDataM(spr, getColumIndex(spr,"cdDefect"), xRow)
     If  getColumIndex(spr,"seLineProd") > -1 then z4086.seLineProd = getDataM(spr, getColumIndex(spr,"seLineProd"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z4086.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"DateAccept") > -1 then z4086.DateAccept = getDataM(spr, getColumIndex(spr,"DateAccept"), xRow)
     If  getColumIndex(spr,"InchargeQC") > -1 then z4086.InchargeQC = getDataM(spr, getColumIndex(spr,"InchargeQC"), xRow)
     If  getColumIndex(spr,"QtyHour01") > -1 then z4086.QtyHour01 = getDataM(spr, getColumIndex(spr,"QtyHour01"), xRow)
     If  getColumIndex(spr,"QtyHour02") > -1 then z4086.QtyHour02 = getDataM(spr, getColumIndex(spr,"QtyHour02"), xRow)
     If  getColumIndex(spr,"QtyHour03") > -1 then z4086.QtyHour03 = getDataM(spr, getColumIndex(spr,"QtyHour03"), xRow)
     If  getColumIndex(spr,"QtyHour04") > -1 then z4086.QtyHour04 = getDataM(spr, getColumIndex(spr,"QtyHour04"), xRow)
     If  getColumIndex(spr,"QtyHour05") > -1 then z4086.QtyHour05 = getDataM(spr, getColumIndex(spr,"QtyHour05"), xRow)
     If  getColumIndex(spr,"QtyHour06") > -1 then z4086.QtyHour06 = getDataM(spr, getColumIndex(spr,"QtyHour06"), xRow)
     If  getColumIndex(spr,"QtyHour07") > -1 then z4086.QtyHour07 = getDataM(spr, getColumIndex(spr,"QtyHour07"), xRow)
     If  getColumIndex(spr,"QtyHour08") > -1 then z4086.QtyHour08 = getDataM(spr, getColumIndex(spr,"QtyHour08"), xRow)
     If  getColumIndex(spr,"QtyHour09") > -1 then z4086.QtyHour09 = getDataM(spr, getColumIndex(spr,"QtyHour09"), xRow)
     If  getColumIndex(spr,"QtyHour10") > -1 then z4086.QtyHour10 = getDataM(spr, getColumIndex(spr,"QtyHour10"), xRow)
     If  getColumIndex(spr,"QtyHour11") > -1 then z4086.QtyHour11 = getDataM(spr, getColumIndex(spr,"QtyHour11"), xRow)
     If  getColumIndex(spr,"QtyHour12") > -1 then z4086.QtyHour12 = getDataM(spr, getColumIndex(spr,"QtyHour12"), xRow)
     If  getColumIndex(spr,"QtyHour13") > -1 then z4086.QtyHour13 = getDataM(spr, getColumIndex(spr,"QtyHour13"), xRow)
     If  getColumIndex(spr,"QtyHour14") > -1 then z4086.QtyHour14 = getDataM(spr, getColumIndex(spr,"QtyHour14"), xRow)
     If  getColumIndex(spr,"QtyHour15") > -1 then z4086.QtyHour15 = getDataM(spr, getColumIndex(spr,"QtyHour15"), xRow)
     If  getColumIndex(spr,"QtyHour16") > -1 then z4086.QtyHour16 = getDataM(spr, getColumIndex(spr,"QtyHour16"), xRow)
     If  getColumIndex(spr,"QtyHour17") > -1 then z4086.QtyHour17 = getDataM(spr, getColumIndex(spr,"QtyHour17"), xRow)
     If  getColumIndex(spr,"QtyHour18") > -1 then z4086.QtyHour18 = getDataM(spr, getColumIndex(spr,"QtyHour18"), xRow)
     If  getColumIndex(spr,"QtyHour19") > -1 then z4086.QtyHour19 = getDataM(spr, getColumIndex(spr,"QtyHour19"), xRow)
     If  getColumIndex(spr,"QtyHour20") > -1 then z4086.QtyHour20 = getDataM(spr, getColumIndex(spr,"QtyHour20"), xRow)
     If  getColumIndex(spr,"QtyTotal") > -1 then z4086.QtyTotal = getDataM(spr, getColumIndex(spr,"QtyTotal"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z4086.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4086_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K4086_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4086 As T4086_AREA, Job as String, AUTOKEY AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4086_MOVE = False

Try
    If READ_PFK4086(AUTOKEY) = True Then
                z4086 = D4086
		K4086_MOVE = True
		else
	z4086 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4086")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z4086.AutoKey = Children(i).Code
   Case "SEFACTORY":z4086.seFactory = Children(i).Code
   Case "CDFACTORY":z4086.cdFactory = Children(i).Code
   Case "SEQCPROCESS":z4086.seQCProcess = Children(i).Code
   Case "CDQCPROCESS":z4086.cdQCProcess = Children(i).Code
   Case "SEDEFECT":z4086.seDefect = Children(i).Code
   Case "CDDEFECT":z4086.cdDefect = Children(i).Code
   Case "SELINEPROD":z4086.seLineProd = Children(i).Code
   Case "CDLINEPROD":z4086.cdLineProd = Children(i).Code
   Case "DATEACCEPT":z4086.DateAccept = Children(i).Code
   Case "INCHARGEQC":z4086.InchargeQC = Children(i).Code
   Case "QTYHOUR01":z4086.QtyHour01 = Children(i).Code
   Case "QTYHOUR02":z4086.QtyHour02 = Children(i).Code
   Case "QTYHOUR03":z4086.QtyHour03 = Children(i).Code
   Case "QTYHOUR04":z4086.QtyHour04 = Children(i).Code
   Case "QTYHOUR05":z4086.QtyHour05 = Children(i).Code
   Case "QTYHOUR06":z4086.QtyHour06 = Children(i).Code
   Case "QTYHOUR07":z4086.QtyHour07 = Children(i).Code
   Case "QTYHOUR08":z4086.QtyHour08 = Children(i).Code
   Case "QTYHOUR09":z4086.QtyHour09 = Children(i).Code
   Case "QTYHOUR10":z4086.QtyHour10 = Children(i).Code
   Case "QTYHOUR11":z4086.QtyHour11 = Children(i).Code
   Case "QTYHOUR12":z4086.QtyHour12 = Children(i).Code
   Case "QTYHOUR13":z4086.QtyHour13 = Children(i).Code
   Case "QTYHOUR14":z4086.QtyHour14 = Children(i).Code
   Case "QTYHOUR15":z4086.QtyHour15 = Children(i).Code
   Case "QTYHOUR16":z4086.QtyHour16 = Children(i).Code
   Case "QTYHOUR17":z4086.QtyHour17 = Children(i).Code
   Case "QTYHOUR18":z4086.QtyHour18 = Children(i).Code
   Case "QTYHOUR19":z4086.QtyHour19 = Children(i).Code
   Case "QTYHOUR20":z4086.QtyHour20 = Children(i).Code
   Case "QTYTOTAL":z4086.QtyTotal = Children(i).Code
   Case "REMARK":z4086.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z4086.AutoKey = Children(i).Data
   Case "SEFACTORY":z4086.seFactory = Children(i).Data
   Case "CDFACTORY":z4086.cdFactory = Children(i).Data
   Case "SEQCPROCESS":z4086.seQCProcess = Children(i).Data
   Case "CDQCPROCESS":z4086.cdQCProcess = Children(i).Data
   Case "SEDEFECT":z4086.seDefect = Children(i).Data
   Case "CDDEFECT":z4086.cdDefect = Children(i).Data
   Case "SELINEPROD":z4086.seLineProd = Children(i).Data
   Case "CDLINEPROD":z4086.cdLineProd = Children(i).Data
   Case "DATEACCEPT":z4086.DateAccept = Children(i).Data
   Case "INCHARGEQC":z4086.InchargeQC = Children(i).Data
   Case "QTYHOUR01":z4086.QtyHour01 = Children(i).Data
   Case "QTYHOUR02":z4086.QtyHour02 = Children(i).Data
   Case "QTYHOUR03":z4086.QtyHour03 = Children(i).Data
   Case "QTYHOUR04":z4086.QtyHour04 = Children(i).Data
   Case "QTYHOUR05":z4086.QtyHour05 = Children(i).Data
   Case "QTYHOUR06":z4086.QtyHour06 = Children(i).Data
   Case "QTYHOUR07":z4086.QtyHour07 = Children(i).Data
   Case "QTYHOUR08":z4086.QtyHour08 = Children(i).Data
   Case "QTYHOUR09":z4086.QtyHour09 = Children(i).Data
   Case "QTYHOUR10":z4086.QtyHour10 = Children(i).Data
   Case "QTYHOUR11":z4086.QtyHour11 = Children(i).Data
   Case "QTYHOUR12":z4086.QtyHour12 = Children(i).Data
   Case "QTYHOUR13":z4086.QtyHour13 = Children(i).Data
   Case "QTYHOUR14":z4086.QtyHour14 = Children(i).Data
   Case "QTYHOUR15":z4086.QtyHour15 = Children(i).Data
   Case "QTYHOUR16":z4086.QtyHour16 = Children(i).Data
   Case "QTYHOUR17":z4086.QtyHour17 = Children(i).Data
   Case "QTYHOUR18":z4086.QtyHour18 = Children(i).Data
   Case "QTYHOUR19":z4086.QtyHour19 = Children(i).Data
   Case "QTYHOUR20":z4086.QtyHour20 = Children(i).Data
   Case "QTYTOTAL":z4086.QtyTotal = Children(i).Data
   Case "REMARK":z4086.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4086_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K4086_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4086 As T4086_AREA, Job as String, CheckClear as Boolean, AUTOKEY AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4086_MOVE = False

Try
    If READ_PFK4086(AUTOKEY) = True Then
                z4086 = D4086
		K4086_MOVE = True
		else
	If CheckClear  = True then z4086 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4086")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z4086.AutoKey = Children(i).Code
   Case "SEFACTORY":z4086.seFactory = Children(i).Code
   Case "CDFACTORY":z4086.cdFactory = Children(i).Code
   Case "SEQCPROCESS":z4086.seQCProcess = Children(i).Code
   Case "CDQCPROCESS":z4086.cdQCProcess = Children(i).Code
   Case "SEDEFECT":z4086.seDefect = Children(i).Code
   Case "CDDEFECT":z4086.cdDefect = Children(i).Code
   Case "SELINEPROD":z4086.seLineProd = Children(i).Code
   Case "CDLINEPROD":z4086.cdLineProd = Children(i).Code
   Case "DATEACCEPT":z4086.DateAccept = Children(i).Code
   Case "INCHARGEQC":z4086.InchargeQC = Children(i).Code
   Case "QTYHOUR01":z4086.QtyHour01 = Children(i).Code
   Case "QTYHOUR02":z4086.QtyHour02 = Children(i).Code
   Case "QTYHOUR03":z4086.QtyHour03 = Children(i).Code
   Case "QTYHOUR04":z4086.QtyHour04 = Children(i).Code
   Case "QTYHOUR05":z4086.QtyHour05 = Children(i).Code
   Case "QTYHOUR06":z4086.QtyHour06 = Children(i).Code
   Case "QTYHOUR07":z4086.QtyHour07 = Children(i).Code
   Case "QTYHOUR08":z4086.QtyHour08 = Children(i).Code
   Case "QTYHOUR09":z4086.QtyHour09 = Children(i).Code
   Case "QTYHOUR10":z4086.QtyHour10 = Children(i).Code
   Case "QTYHOUR11":z4086.QtyHour11 = Children(i).Code
   Case "QTYHOUR12":z4086.QtyHour12 = Children(i).Code
   Case "QTYHOUR13":z4086.QtyHour13 = Children(i).Code
   Case "QTYHOUR14":z4086.QtyHour14 = Children(i).Code
   Case "QTYHOUR15":z4086.QtyHour15 = Children(i).Code
   Case "QTYHOUR16":z4086.QtyHour16 = Children(i).Code
   Case "QTYHOUR17":z4086.QtyHour17 = Children(i).Code
   Case "QTYHOUR18":z4086.QtyHour18 = Children(i).Code
   Case "QTYHOUR19":z4086.QtyHour19 = Children(i).Code
   Case "QTYHOUR20":z4086.QtyHour20 = Children(i).Code
   Case "QTYTOTAL":z4086.QtyTotal = Children(i).Code
   Case "REMARK":z4086.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z4086.AutoKey = Children(i).Data
   Case "SEFACTORY":z4086.seFactory = Children(i).Data
   Case "CDFACTORY":z4086.cdFactory = Children(i).Data
   Case "SEQCPROCESS":z4086.seQCProcess = Children(i).Data
   Case "CDQCPROCESS":z4086.cdQCProcess = Children(i).Data
   Case "SEDEFECT":z4086.seDefect = Children(i).Data
   Case "CDDEFECT":z4086.cdDefect = Children(i).Data
   Case "SELINEPROD":z4086.seLineProd = Children(i).Data
   Case "CDLINEPROD":z4086.cdLineProd = Children(i).Data
   Case "DATEACCEPT":z4086.DateAccept = Children(i).Data
   Case "INCHARGEQC":z4086.InchargeQC = Children(i).Data
   Case "QTYHOUR01":z4086.QtyHour01 = Children(i).Data
   Case "QTYHOUR02":z4086.QtyHour02 = Children(i).Data
   Case "QTYHOUR03":z4086.QtyHour03 = Children(i).Data
   Case "QTYHOUR04":z4086.QtyHour04 = Children(i).Data
   Case "QTYHOUR05":z4086.QtyHour05 = Children(i).Data
   Case "QTYHOUR06":z4086.QtyHour06 = Children(i).Data
   Case "QTYHOUR07":z4086.QtyHour07 = Children(i).Data
   Case "QTYHOUR08":z4086.QtyHour08 = Children(i).Data
   Case "QTYHOUR09":z4086.QtyHour09 = Children(i).Data
   Case "QTYHOUR10":z4086.QtyHour10 = Children(i).Data
   Case "QTYHOUR11":z4086.QtyHour11 = Children(i).Data
   Case "QTYHOUR12":z4086.QtyHour12 = Children(i).Data
   Case "QTYHOUR13":z4086.QtyHour13 = Children(i).Data
   Case "QTYHOUR14":z4086.QtyHour14 = Children(i).Data
   Case "QTYHOUR15":z4086.QtyHour15 = Children(i).Data
   Case "QTYHOUR16":z4086.QtyHour16 = Children(i).Data
   Case "QTYHOUR17":z4086.QtyHour17 = Children(i).Data
   Case "QTYHOUR18":z4086.QtyHour18 = Children(i).Data
   Case "QTYHOUR19":z4086.QtyHour19 = Children(i).Data
   Case "QTYHOUR20":z4086.QtyHour20 = Children(i).Data
   Case "QTYTOTAL":z4086.QtyTotal = Children(i).Data
   Case "REMARK":z4086.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4086_MOVE",vbCritical)
End Try
End Function 
    
End Module 
