'=========================================================================================================================================================
'   TABLE : (PFK9703)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K9703

Structure T9703_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	ProgramNo	 AS String	'			varchar(100)		*
Public 	Table	 AS String	'			nvarchar(50)
Public 	Table1	 AS String	'			nvarchar(50)
Public 	Table2	 AS String	'			nvarchar(50)
Public 	Table3	 AS String	'			nvarchar(50)
Public 	Table4	 AS String	'			nvarchar(50)
Public 	Table5	 AS String	'			nvarchar(50)
Public 	Table6	 AS String	'			nvarchar(50)
Public 	Table7	 AS String	'			nvarchar(50)
Public 	Table8	 AS String	'			nvarchar(50)
Public 	Table9	 AS String	'			nvarchar(50)
Public 	Table10	 AS String	'			nvarchar(50)
Public 	Table11	 AS String	'			nvarchar(50)
Public 	Table12	 AS String	'			nvarchar(50)
Public 	Table13	 AS String	'			nvarchar(50)
Public 	Table14	 AS String	'			nvarchar(50)
Public 	Table15	 AS String	'			nvarchar(50)
Public 	Remark	 AS String	'			nvarchar(300)
'=========================================================================================================================================================
End structure

Public D9703 As T9703_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK9703(PROGRAMNO AS String) As Boolean
    READ_PFK9703 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9703 "
    SQL = SQL & " WHERE K9703_ProgramNo		 = '" & ProgramNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D9703_CLEAR: GoTo SKIP_READ_PFK9703
                
    Call K9703_MOVE(rd)
    READ_PFK9703 = True

SKIP_READ_PFK9703:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK9703",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK9703(PROGRAMNO AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9703 "
    SQL = SQL & " WHERE K9703_ProgramNo		 = '" & ProgramNo & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK9703",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK9703(z9703 As T9703_AREA) As Boolean
    WRITE_PFK9703 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z9703)
 
    SQL = " INSERT INTO PFK9703 "
    SQL = SQL & " ( "
    SQL = SQL & " K9703_ProgramNo," 
    SQL = SQL & " K9703_Table," 
    SQL = SQL & " K9703_Table1," 
    SQL = SQL & " K9703_Table2," 
    SQL = SQL & " K9703_Table3," 
    SQL = SQL & " K9703_Table4," 
    SQL = SQL & " K9703_Table5," 
    SQL = SQL & " K9703_Table6," 
    SQL = SQL & " K9703_Table7," 
    SQL = SQL & " K9703_Table8," 
    SQL = SQL & " K9703_Table9," 
    SQL = SQL & " K9703_Table10," 
    SQL = SQL & " K9703_Table11," 
    SQL = SQL & " K9703_Table12," 
    SQL = SQL & " K9703_Table13," 
    SQL = SQL & " K9703_Table14," 
    SQL = SQL & " K9703_Table15," 
    SQL = SQL & " K9703_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z9703.ProgramNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9703.Table) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9703.Table1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9703.Table2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9703.Table3) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9703.Table4) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9703.Table5) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9703.Table6) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9703.Table7) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9703.Table8) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9703.Table9) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9703.Table10) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9703.Table11) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9703.Table12) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9703.Table13) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9703.Table14) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9703.Table15) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9703.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK9703 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK9703",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK9703(z9703 As T9703_AREA) As Boolean
    REWRITE_PFK9703 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z9703)
   
    SQL = " UPDATE PFK9703 SET "
    SQL = SQL & "    K9703_Table      = N'" & FormatSQL(z9703.Table) & "', " 
    SQL = SQL & "    K9703_Table1      = N'" & FormatSQL(z9703.Table1) & "', " 
    SQL = SQL & "    K9703_Table2      = N'" & FormatSQL(z9703.Table2) & "', " 
    SQL = SQL & "    K9703_Table3      = N'" & FormatSQL(z9703.Table3) & "', " 
    SQL = SQL & "    K9703_Table4      = N'" & FormatSQL(z9703.Table4) & "', " 
    SQL = SQL & "    K9703_Table5      = N'" & FormatSQL(z9703.Table5) & "', " 
    SQL = SQL & "    K9703_Table6      = N'" & FormatSQL(z9703.Table6) & "', " 
    SQL = SQL & "    K9703_Table7      = N'" & FormatSQL(z9703.Table7) & "', " 
    SQL = SQL & "    K9703_Table8      = N'" & FormatSQL(z9703.Table8) & "', " 
    SQL = SQL & "    K9703_Table9      = N'" & FormatSQL(z9703.Table9) & "', " 
    SQL = SQL & "    K9703_Table10      = N'" & FormatSQL(z9703.Table10) & "', " 
    SQL = SQL & "    K9703_Table11      = N'" & FormatSQL(z9703.Table11) & "', " 
    SQL = SQL & "    K9703_Table12      = N'" & FormatSQL(z9703.Table12) & "', " 
    SQL = SQL & "    K9703_Table13      = N'" & FormatSQL(z9703.Table13) & "', " 
    SQL = SQL & "    K9703_Table14      = N'" & FormatSQL(z9703.Table14) & "', " 
    SQL = SQL & "    K9703_Table15      = N'" & FormatSQL(z9703.Table15) & "', " 
    SQL = SQL & "    K9703_Remark      = N'" & FormatSQL(z9703.Remark) & "'  " 
    SQL = SQL & " WHERE K9703_ProgramNo		 = '" & z9703.ProgramNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK9703 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK9703",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK9703(z9703 As T9703_AREA) As Boolean
    DELETE_PFK9703 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK9703 "
    SQL = SQL & " WHERE K9703_ProgramNo		 = '" & z9703.ProgramNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK9703 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK9703",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D9703_CLEAR()
Try
    
   D9703.ProgramNo = ""
   D9703.Table = ""
   D9703.Table1 = ""
   D9703.Table2 = ""
   D9703.Table3 = ""
   D9703.Table4 = ""
   D9703.Table5 = ""
   D9703.Table6 = ""
   D9703.Table7 = ""
   D9703.Table8 = ""
   D9703.Table9 = ""
   D9703.Table10 = ""
   D9703.Table11 = ""
   D9703.Table12 = ""
   D9703.Table13 = ""
   D9703.Table14 = ""
   D9703.Table15 = ""
   D9703.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D9703_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x9703 As T9703_AREA)
Try
    
    x9703.ProgramNo = trim$(  x9703.ProgramNo)
    x9703.Table = trim$(  x9703.Table)
    x9703.Table1 = trim$(  x9703.Table1)
    x9703.Table2 = trim$(  x9703.Table2)
    x9703.Table3 = trim$(  x9703.Table3)
    x9703.Table4 = trim$(  x9703.Table4)
    x9703.Table5 = trim$(  x9703.Table5)
    x9703.Table6 = trim$(  x9703.Table6)
    x9703.Table7 = trim$(  x9703.Table7)
    x9703.Table8 = trim$(  x9703.Table8)
    x9703.Table9 = trim$(  x9703.Table9)
    x9703.Table10 = trim$(  x9703.Table10)
    x9703.Table11 = trim$(  x9703.Table11)
    x9703.Table12 = trim$(  x9703.Table12)
    x9703.Table13 = trim$(  x9703.Table13)
    x9703.Table14 = trim$(  x9703.Table14)
    x9703.Table15 = trim$(  x9703.Table15)
    x9703.Remark = trim$(  x9703.Remark)
     
    If trim$( x9703.ProgramNo ) = "" Then x9703.ProgramNo = Space(1) 
    If trim$( x9703.Table ) = "" Then x9703.Table = Space(1) 
    If trim$( x9703.Table1 ) = "" Then x9703.Table1 = Space(1) 
    If trim$( x9703.Table2 ) = "" Then x9703.Table2 = Space(1) 
    If trim$( x9703.Table3 ) = "" Then x9703.Table3 = Space(1) 
    If trim$( x9703.Table4 ) = "" Then x9703.Table4 = Space(1) 
    If trim$( x9703.Table5 ) = "" Then x9703.Table5 = Space(1) 
    If trim$( x9703.Table6 ) = "" Then x9703.Table6 = Space(1) 
    If trim$( x9703.Table7 ) = "" Then x9703.Table7 = Space(1) 
    If trim$( x9703.Table8 ) = "" Then x9703.Table8 = Space(1) 
    If trim$( x9703.Table9 ) = "" Then x9703.Table9 = Space(1) 
    If trim$( x9703.Table10 ) = "" Then x9703.Table10 = Space(1) 
    If trim$( x9703.Table11 ) = "" Then x9703.Table11 = Space(1) 
    If trim$( x9703.Table12 ) = "" Then x9703.Table12 = Space(1) 
    If trim$( x9703.Table13 ) = "" Then x9703.Table13 = Space(1) 
    If trim$( x9703.Table14 ) = "" Then x9703.Table14 = Space(1) 
    If trim$( x9703.Table15 ) = "" Then x9703.Table15 = Space(1) 
    If trim$( x9703.Remark ) = "" Then x9703.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K9703_MOVE(rs9703 As SqlClient.SqlDataReader)
Try

    call D9703_CLEAR()   

    If IsdbNull(rs9703!K9703_ProgramNo) = False Then D9703.ProgramNo = Trim$(rs9703!K9703_ProgramNo)
    If IsdbNull(rs9703!K9703_Table) = False Then D9703.Table = Trim$(rs9703!K9703_Table)
    If IsdbNull(rs9703!K9703_Table1) = False Then D9703.Table1 = Trim$(rs9703!K9703_Table1)
    If IsdbNull(rs9703!K9703_Table2) = False Then D9703.Table2 = Trim$(rs9703!K9703_Table2)
    If IsdbNull(rs9703!K9703_Table3) = False Then D9703.Table3 = Trim$(rs9703!K9703_Table3)
    If IsdbNull(rs9703!K9703_Table4) = False Then D9703.Table4 = Trim$(rs9703!K9703_Table4)
    If IsdbNull(rs9703!K9703_Table5) = False Then D9703.Table5 = Trim$(rs9703!K9703_Table5)
    If IsdbNull(rs9703!K9703_Table6) = False Then D9703.Table6 = Trim$(rs9703!K9703_Table6)
    If IsdbNull(rs9703!K9703_Table7) = False Then D9703.Table7 = Trim$(rs9703!K9703_Table7)
    If IsdbNull(rs9703!K9703_Table8) = False Then D9703.Table8 = Trim$(rs9703!K9703_Table8)
    If IsdbNull(rs9703!K9703_Table9) = False Then D9703.Table9 = Trim$(rs9703!K9703_Table9)
    If IsdbNull(rs9703!K9703_Table10) = False Then D9703.Table10 = Trim$(rs9703!K9703_Table10)
    If IsdbNull(rs9703!K9703_Table11) = False Then D9703.Table11 = Trim$(rs9703!K9703_Table11)
    If IsdbNull(rs9703!K9703_Table12) = False Then D9703.Table12 = Trim$(rs9703!K9703_Table12)
    If IsdbNull(rs9703!K9703_Table13) = False Then D9703.Table13 = Trim$(rs9703!K9703_Table13)
    If IsdbNull(rs9703!K9703_Table14) = False Then D9703.Table14 = Trim$(rs9703!K9703_Table14)
    If IsdbNull(rs9703!K9703_Table15) = False Then D9703.Table15 = Trim$(rs9703!K9703_Table15)
    If IsdbNull(rs9703!K9703_Remark) = False Then D9703.Remark = Trim$(rs9703!K9703_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9703_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K9703_MOVE(rs9703 As DataRow)
Try

    call D9703_CLEAR()   

    If IsdbNull(rs9703!K9703_ProgramNo) = False Then D9703.ProgramNo = Trim$(rs9703!K9703_ProgramNo)
    If IsdbNull(rs9703!K9703_Table) = False Then D9703.Table = Trim$(rs9703!K9703_Table)
    If IsdbNull(rs9703!K9703_Table1) = False Then D9703.Table1 = Trim$(rs9703!K9703_Table1)
    If IsdbNull(rs9703!K9703_Table2) = False Then D9703.Table2 = Trim$(rs9703!K9703_Table2)
    If IsdbNull(rs9703!K9703_Table3) = False Then D9703.Table3 = Trim$(rs9703!K9703_Table3)
    If IsdbNull(rs9703!K9703_Table4) = False Then D9703.Table4 = Trim$(rs9703!K9703_Table4)
    If IsdbNull(rs9703!K9703_Table5) = False Then D9703.Table5 = Trim$(rs9703!K9703_Table5)
    If IsdbNull(rs9703!K9703_Table6) = False Then D9703.Table6 = Trim$(rs9703!K9703_Table6)
    If IsdbNull(rs9703!K9703_Table7) = False Then D9703.Table7 = Trim$(rs9703!K9703_Table7)
    If IsdbNull(rs9703!K9703_Table8) = False Then D9703.Table8 = Trim$(rs9703!K9703_Table8)
    If IsdbNull(rs9703!K9703_Table9) = False Then D9703.Table9 = Trim$(rs9703!K9703_Table9)
    If IsdbNull(rs9703!K9703_Table10) = False Then D9703.Table10 = Trim$(rs9703!K9703_Table10)
    If IsdbNull(rs9703!K9703_Table11) = False Then D9703.Table11 = Trim$(rs9703!K9703_Table11)
    If IsdbNull(rs9703!K9703_Table12) = False Then D9703.Table12 = Trim$(rs9703!K9703_Table12)
    If IsdbNull(rs9703!K9703_Table13) = False Then D9703.Table13 = Trim$(rs9703!K9703_Table13)
    If IsdbNull(rs9703!K9703_Table14) = False Then D9703.Table14 = Trim$(rs9703!K9703_Table14)
    If IsdbNull(rs9703!K9703_Table15) = False Then D9703.Table15 = Trim$(rs9703!K9703_Table15)
    If IsdbNull(rs9703!K9703_Remark) = False Then D9703.Remark = Trim$(rs9703!K9703_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9703_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K9703_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9703 As T9703_AREA, PROGRAMNO AS String) as Boolean

K9703_MOVE = False

Try
    If READ_PFK9703(PROGRAMNO) = True Then
                z9703 = D9703
		K9703_MOVE = True
		else
	z9703 = nothing
     End If

     If  getColumIndex(spr,"ProgramNo") > -1 then z9703.ProgramNo = getDataM(spr, getColumIndex(spr,"ProgramNo"), xRow)
     If  getColumIndex(spr,"Table") > -1 then z9703.Table = getDataM(spr, getColumIndex(spr,"Table"), xRow)
     If  getColumIndex(spr,"Table1") > -1 then z9703.Table1 = getDataM(spr, getColumIndex(spr,"Table1"), xRow)
     If  getColumIndex(spr,"Table2") > -1 then z9703.Table2 = getDataM(spr, getColumIndex(spr,"Table2"), xRow)
     If  getColumIndex(spr,"Table3") > -1 then z9703.Table3 = getDataM(spr, getColumIndex(spr,"Table3"), xRow)
     If  getColumIndex(spr,"Table4") > -1 then z9703.Table4 = getDataM(spr, getColumIndex(spr,"Table4"), xRow)
     If  getColumIndex(spr,"Table5") > -1 then z9703.Table5 = getDataM(spr, getColumIndex(spr,"Table5"), xRow)
     If  getColumIndex(spr,"Table6") > -1 then z9703.Table6 = getDataM(spr, getColumIndex(spr,"Table6"), xRow)
     If  getColumIndex(spr,"Table7") > -1 then z9703.Table7 = getDataM(spr, getColumIndex(spr,"Table7"), xRow)
     If  getColumIndex(spr,"Table8") > -1 then z9703.Table8 = getDataM(spr, getColumIndex(spr,"Table8"), xRow)
     If  getColumIndex(spr,"Table9") > -1 then z9703.Table9 = getDataM(spr, getColumIndex(spr,"Table9"), xRow)
     If  getColumIndex(spr,"Table10") > -1 then z9703.Table10 = getDataM(spr, getColumIndex(spr,"Table10"), xRow)
     If  getColumIndex(spr,"Table11") > -1 then z9703.Table11 = getDataM(spr, getColumIndex(spr,"Table11"), xRow)
     If  getColumIndex(spr,"Table12") > -1 then z9703.Table12 = getDataM(spr, getColumIndex(spr,"Table12"), xRow)
     If  getColumIndex(spr,"Table13") > -1 then z9703.Table13 = getDataM(spr, getColumIndex(spr,"Table13"), xRow)
     If  getColumIndex(spr,"Table14") > -1 then z9703.Table14 = getDataM(spr, getColumIndex(spr,"Table14"), xRow)
     If  getColumIndex(spr,"Table15") > -1 then z9703.Table15 = getDataM(spr, getColumIndex(spr,"Table15"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z9703.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K9703_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K9703_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9703 As T9703_AREA,CheckClear as Boolean,PROGRAMNO AS String) as Boolean

K9703_MOVE = False

Try
    If READ_PFK9703(PROGRAMNO) = True Then
                z9703 = D9703
		K9703_MOVE = True
		else
	If CheckClear  = True then z9703 = nothing
     End If

     If  getColumIndex(spr,"ProgramNo") > -1 then z9703.ProgramNo = getDataM(spr, getColumIndex(spr,"ProgramNo"), xRow)
     If  getColumIndex(spr,"Table") > -1 then z9703.Table = getDataM(spr, getColumIndex(spr,"Table"), xRow)
     If  getColumIndex(spr,"Table1") > -1 then z9703.Table1 = getDataM(spr, getColumIndex(spr,"Table1"), xRow)
     If  getColumIndex(spr,"Table2") > -1 then z9703.Table2 = getDataM(spr, getColumIndex(spr,"Table2"), xRow)
     If  getColumIndex(spr,"Table3") > -1 then z9703.Table3 = getDataM(spr, getColumIndex(spr,"Table3"), xRow)
     If  getColumIndex(spr,"Table4") > -1 then z9703.Table4 = getDataM(spr, getColumIndex(spr,"Table4"), xRow)
     If  getColumIndex(spr,"Table5") > -1 then z9703.Table5 = getDataM(spr, getColumIndex(spr,"Table5"), xRow)
     If  getColumIndex(spr,"Table6") > -1 then z9703.Table6 = getDataM(spr, getColumIndex(spr,"Table6"), xRow)
     If  getColumIndex(spr,"Table7") > -1 then z9703.Table7 = getDataM(spr, getColumIndex(spr,"Table7"), xRow)
     If  getColumIndex(spr,"Table8") > -1 then z9703.Table8 = getDataM(spr, getColumIndex(spr,"Table8"), xRow)
     If  getColumIndex(spr,"Table9") > -1 then z9703.Table9 = getDataM(spr, getColumIndex(spr,"Table9"), xRow)
     If  getColumIndex(spr,"Table10") > -1 then z9703.Table10 = getDataM(spr, getColumIndex(spr,"Table10"), xRow)
     If  getColumIndex(spr,"Table11") > -1 then z9703.Table11 = getDataM(spr, getColumIndex(spr,"Table11"), xRow)
     If  getColumIndex(spr,"Table12") > -1 then z9703.Table12 = getDataM(spr, getColumIndex(spr,"Table12"), xRow)
     If  getColumIndex(spr,"Table13") > -1 then z9703.Table13 = getDataM(spr, getColumIndex(spr,"Table13"), xRow)
     If  getColumIndex(spr,"Table14") > -1 then z9703.Table14 = getDataM(spr, getColumIndex(spr,"Table14"), xRow)
     If  getColumIndex(spr,"Table15") > -1 then z9703.Table15 = getDataM(spr, getColumIndex(spr,"Table15"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z9703.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K9703_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K9703_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9703 As T9703_AREA, Job as String, PROGRAMNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9703_MOVE = False

Try
    If READ_PFK9703(PROGRAMNO) = True Then
                z9703 = D9703
		K9703_MOVE = True
		else
	z9703 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9703")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PROGRAMNO":z9703.ProgramNo = Children(i).Code
   Case "TABLE":z9703.Table = Children(i).Code
   Case "TABLE1":z9703.Table1 = Children(i).Code
   Case "TABLE2":z9703.Table2 = Children(i).Code
   Case "TABLE3":z9703.Table3 = Children(i).Code
   Case "TABLE4":z9703.Table4 = Children(i).Code
   Case "TABLE5":z9703.Table5 = Children(i).Code
   Case "TABLE6":z9703.Table6 = Children(i).Code
   Case "TABLE7":z9703.Table7 = Children(i).Code
   Case "TABLE8":z9703.Table8 = Children(i).Code
   Case "TABLE9":z9703.Table9 = Children(i).Code
   Case "TABLE10":z9703.Table10 = Children(i).Code
   Case "TABLE11":z9703.Table11 = Children(i).Code
   Case "TABLE12":z9703.Table12 = Children(i).Code
   Case "TABLE13":z9703.Table13 = Children(i).Code
   Case "TABLE14":z9703.Table14 = Children(i).Code
   Case "TABLE15":z9703.Table15 = Children(i).Code
   Case "REMARK":z9703.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PROGRAMNO":z9703.ProgramNo = Children(i).Data
   Case "TABLE":z9703.Table = Children(i).Data
   Case "TABLE1":z9703.Table1 = Children(i).Data
   Case "TABLE2":z9703.Table2 = Children(i).Data
   Case "TABLE3":z9703.Table3 = Children(i).Data
   Case "TABLE4":z9703.Table4 = Children(i).Data
   Case "TABLE5":z9703.Table5 = Children(i).Data
   Case "TABLE6":z9703.Table6 = Children(i).Data
   Case "TABLE7":z9703.Table7 = Children(i).Data
   Case "TABLE8":z9703.Table8 = Children(i).Data
   Case "TABLE9":z9703.Table9 = Children(i).Data
   Case "TABLE10":z9703.Table10 = Children(i).Data
   Case "TABLE11":z9703.Table11 = Children(i).Data
   Case "TABLE12":z9703.Table12 = Children(i).Data
   Case "TABLE13":z9703.Table13 = Children(i).Data
   Case "TABLE14":z9703.Table14 = Children(i).Data
   Case "TABLE15":z9703.Table15 = Children(i).Data
   Case "REMARK":z9703.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K9703_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K9703_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9703 As T9703_AREA, Job as String, CheckClear as Boolean, PROGRAMNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9703_MOVE = False

Try
    If READ_PFK9703(PROGRAMNO) = True Then
                z9703 = D9703
		K9703_MOVE = True
		else
	If CheckClear  = True then z9703 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9703")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "PROGRAMNO":z9703.ProgramNo = Children(i).Code
   Case "TABLE":z9703.Table = Children(i).Code
   Case "TABLE1":z9703.Table1 = Children(i).Code
   Case "TABLE2":z9703.Table2 = Children(i).Code
   Case "TABLE3":z9703.Table3 = Children(i).Code
   Case "TABLE4":z9703.Table4 = Children(i).Code
   Case "TABLE5":z9703.Table5 = Children(i).Code
   Case "TABLE6":z9703.Table6 = Children(i).Code
   Case "TABLE7":z9703.Table7 = Children(i).Code
   Case "TABLE8":z9703.Table8 = Children(i).Code
   Case "TABLE9":z9703.Table9 = Children(i).Code
   Case "TABLE10":z9703.Table10 = Children(i).Code
   Case "TABLE11":z9703.Table11 = Children(i).Code
   Case "TABLE12":z9703.Table12 = Children(i).Code
   Case "TABLE13":z9703.Table13 = Children(i).Code
   Case "TABLE14":z9703.Table14 = Children(i).Code
   Case "TABLE15":z9703.Table15 = Children(i).Code
   Case "REMARK":z9703.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "PROGRAMNO":z9703.ProgramNo = Children(i).Data
   Case "TABLE":z9703.Table = Children(i).Data
   Case "TABLE1":z9703.Table1 = Children(i).Data
   Case "TABLE2":z9703.Table2 = Children(i).Data
   Case "TABLE3":z9703.Table3 = Children(i).Data
   Case "TABLE4":z9703.Table4 = Children(i).Data
   Case "TABLE5":z9703.Table5 = Children(i).Data
   Case "TABLE6":z9703.Table6 = Children(i).Data
   Case "TABLE7":z9703.Table7 = Children(i).Data
   Case "TABLE8":z9703.Table8 = Children(i).Data
   Case "TABLE9":z9703.Table9 = Children(i).Data
   Case "TABLE10":z9703.Table10 = Children(i).Data
   Case "TABLE11":z9703.Table11 = Children(i).Data
   Case "TABLE12":z9703.Table12 = Children(i).Data
   Case "TABLE13":z9703.Table13 = Children(i).Data
   Case "TABLE14":z9703.Table14 = Children(i).Data
   Case "TABLE15":z9703.Table15 = Children(i).Data
   Case "REMARK":z9703.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K9703_MOVE",vbCritical)
End Try
End Function 
    
End Module 
