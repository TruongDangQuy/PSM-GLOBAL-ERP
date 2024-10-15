'=========================================================================================================================================================
'   TABLE : (PFK9917)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K9917

Structure T9917_AREA
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

Public D9917 As T9917_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK9917(PROGRAMNO AS String) As Boolean
    READ_PFK9917 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9917 "
    SQL = SQL & " WHERE K9917_ProgramNo		 = '" & ProgramNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D9917_CLEAR: GoTo SKIP_READ_PFK9917
                
    Call K9917_MOVE(rd)
    READ_PFK9917 = True

SKIP_READ_PFK9917:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK9917",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK9917(PROGRAMNO AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9917 "
    SQL = SQL & " WHERE K9917_ProgramNo		 = '" & ProgramNo & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK9917",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK9917(z9917 As T9917_AREA) As Boolean
    WRITE_PFK9917 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z9917)
 
    SQL = " INSERT INTO PFK9917 "
    SQL = SQL & " ( "
    SQL = SQL & " K9917_ProgramNo," 
    SQL = SQL & " K9917_Table," 
    SQL = SQL & " K9917_Table1," 
    SQL = SQL & " K9917_Table2," 
    SQL = SQL & " K9917_Table3," 
    SQL = SQL & " K9917_Table4," 
    SQL = SQL & " K9917_Table5," 
    SQL = SQL & " K9917_Table6," 
    SQL = SQL & " K9917_Table7," 
    SQL = SQL & " K9917_Table8," 
    SQL = SQL & " K9917_Table9," 
    SQL = SQL & " K9917_Table10," 
    SQL = SQL & " K9917_Table11," 
    SQL = SQL & " K9917_Table12," 
    SQL = SQL & " K9917_Table13," 
    SQL = SQL & " K9917_Table14," 
    SQL = SQL & " K9917_Table15," 
    SQL = SQL & " K9917_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  '" & z9917.ProgramNo & "', "  
    SQL = SQL & "  '" & z9917.Table & "', "  
    SQL = SQL & "  '" & z9917.Table1 & "', "  
    SQL = SQL & "  '" & z9917.Table2 & "', "  
    SQL = SQL & "  '" & z9917.Table3 & "', "  
    SQL = SQL & "  '" & z9917.Table4 & "', "  
    SQL = SQL & "  '" & z9917.Table5 & "', "  
    SQL = SQL & "  '" & z9917.Table6 & "', "  
    SQL = SQL & "  '" & z9917.Table7 & "', "  
    SQL = SQL & "  '" & z9917.Table8 & "', "  
    SQL = SQL & "  '" & z9917.Table9 & "', "  
    SQL = SQL & "  '" & z9917.Table10 & "', "  
    SQL = SQL & "  '" & z9917.Table11 & "', "  
    SQL = SQL & "  '" & z9917.Table12 & "', "  
    SQL = SQL & "  '" & z9917.Table13 & "', "  
    SQL = SQL & "  '" & z9917.Table14 & "', "  
    SQL = SQL & "  '" & z9917.Table15 & "', "  
    SQL = SQL & "  '" & z9917.Remark & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK9917 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK9917",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK9917(z9917 As T9917_AREA) As Boolean
    REWRITE_PFK9917 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z9917)
   
    SQL = " UPDATE PFK9917 SET "
    SQL = SQL & "    K9917_Table      = '" & z9917.Table & "', " 
    SQL = SQL & "    K9917_Table1      = '" & z9917.Table1 & "', " 
    SQL = SQL & "    K9917_Table2      = '" & z9917.Table2 & "', " 
    SQL = SQL & "    K9917_Table3      = '" & z9917.Table3 & "', " 
    SQL = SQL & "    K9917_Table4      = '" & z9917.Table4 & "', " 
    SQL = SQL & "    K9917_Table5      = '" & z9917.Table5 & "', " 
    SQL = SQL & "    K9917_Table6      = '" & z9917.Table6 & "', " 
    SQL = SQL & "    K9917_Table7      = '" & z9917.Table7 & "', " 
    SQL = SQL & "    K9917_Table8      = '" & z9917.Table8 & "', " 
    SQL = SQL & "    K9917_Table9      = '" & z9917.Table9 & "', " 
    SQL = SQL & "    K9917_Table10      = '" & z9917.Table10 & "', " 
    SQL = SQL & "    K9917_Table11      = '" & z9917.Table11 & "', " 
    SQL = SQL & "    K9917_Table12      = '" & z9917.Table12 & "', " 
    SQL = SQL & "    K9917_Table13      = '" & z9917.Table13 & "', " 
    SQL = SQL & "    K9917_Table14      = '" & z9917.Table14 & "', " 
    SQL = SQL & "    K9917_Table15      = '" & z9917.Table15 & "', " 
    SQL = SQL & "    K9917_Remark      = '" & z9917.Remark & "'  " 
    SQL = SQL & " WHERE K9917_ProgramNo		 = '" & z9917.ProgramNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK9917 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK9917",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK9917(z9917 As T9917_AREA) As Boolean
    DELETE_PFK9917 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK9917 "
    SQL = SQL & " WHERE K9917_ProgramNo		 = '" & z9917.ProgramNo & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK9917 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK9917",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D9917_CLEAR()
Try
    
   D9917.ProgramNo = ""
   D9917.Table = ""
   D9917.Table1 = ""
   D9917.Table2 = ""
   D9917.Table3 = ""
   D9917.Table4 = ""
   D9917.Table5 = ""
   D9917.Table6 = ""
   D9917.Table7 = ""
   D9917.Table8 = ""
   D9917.Table9 = ""
   D9917.Table10 = ""
   D9917.Table11 = ""
   D9917.Table12 = ""
   D9917.Table13 = ""
   D9917.Table14 = ""
   D9917.Table15 = ""
   D9917.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D9917_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x9917 As T9917_AREA)
Try
    
    x9917.ProgramNo = trim$(  x9917.ProgramNo)
    x9917.Table = trim$(  x9917.Table)
    x9917.Table1 = trim$(  x9917.Table1)
    x9917.Table2 = trim$(  x9917.Table2)
    x9917.Table3 = trim$(  x9917.Table3)
    x9917.Table4 = trim$(  x9917.Table4)
    x9917.Table5 = trim$(  x9917.Table5)
    x9917.Table6 = trim$(  x9917.Table6)
    x9917.Table7 = trim$(  x9917.Table7)
    x9917.Table8 = trim$(  x9917.Table8)
    x9917.Table9 = trim$(  x9917.Table9)
    x9917.Table10 = trim$(  x9917.Table10)
    x9917.Table11 = trim$(  x9917.Table11)
    x9917.Table12 = trim$(  x9917.Table12)
    x9917.Table13 = trim$(  x9917.Table13)
    x9917.Table14 = trim$(  x9917.Table14)
    x9917.Table15 = trim$(  x9917.Table15)
    x9917.Remark = trim$(  x9917.Remark)
     
    If trim$( x9917.ProgramNo ) = "" Then x9917.ProgramNo = Space(1) 
    If trim$( x9917.Table ) = "" Then x9917.Table = Space(1) 
    If trim$( x9917.Table1 ) = "" Then x9917.Table1 = Space(1) 
    If trim$( x9917.Table2 ) = "" Then x9917.Table2 = Space(1) 
    If trim$( x9917.Table3 ) = "" Then x9917.Table3 = Space(1) 
    If trim$( x9917.Table4 ) = "" Then x9917.Table4 = Space(1) 
    If trim$( x9917.Table5 ) = "" Then x9917.Table5 = Space(1) 
    If trim$( x9917.Table6 ) = "" Then x9917.Table6 = Space(1) 
    If trim$( x9917.Table7 ) = "" Then x9917.Table7 = Space(1) 
    If trim$( x9917.Table8 ) = "" Then x9917.Table8 = Space(1) 
    If trim$( x9917.Table9 ) = "" Then x9917.Table9 = Space(1) 
    If trim$( x9917.Table10 ) = "" Then x9917.Table10 = Space(1) 
    If trim$( x9917.Table11 ) = "" Then x9917.Table11 = Space(1) 
    If trim$( x9917.Table12 ) = "" Then x9917.Table12 = Space(1) 
    If trim$( x9917.Table13 ) = "" Then x9917.Table13 = Space(1) 
    If trim$( x9917.Table14 ) = "" Then x9917.Table14 = Space(1) 
    If trim$( x9917.Table15 ) = "" Then x9917.Table15 = Space(1) 
    If trim$( x9917.Remark ) = "" Then x9917.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K9917_MOVE(rs9917 As SqlClient.SqlDataReader)
Try

    call D9917_CLEAR()   

    If IsdbNull(rs9917!K9917_ProgramNo) = False Then D9917.ProgramNo = Trim$(rs9917!K9917_ProgramNo)
    If IsdbNull(rs9917!K9917_Table) = False Then D9917.Table = Trim$(rs9917!K9917_Table)
    If IsdbNull(rs9917!K9917_Table1) = False Then D9917.Table1 = Trim$(rs9917!K9917_Table1)
    If IsdbNull(rs9917!K9917_Table2) = False Then D9917.Table2 = Trim$(rs9917!K9917_Table2)
    If IsdbNull(rs9917!K9917_Table3) = False Then D9917.Table3 = Trim$(rs9917!K9917_Table3)
    If IsdbNull(rs9917!K9917_Table4) = False Then D9917.Table4 = Trim$(rs9917!K9917_Table4)
    If IsdbNull(rs9917!K9917_Table5) = False Then D9917.Table5 = Trim$(rs9917!K9917_Table5)
    If IsdbNull(rs9917!K9917_Table6) = False Then D9917.Table6 = Trim$(rs9917!K9917_Table6)
    If IsdbNull(rs9917!K9917_Table7) = False Then D9917.Table7 = Trim$(rs9917!K9917_Table7)
    If IsdbNull(rs9917!K9917_Table8) = False Then D9917.Table8 = Trim$(rs9917!K9917_Table8)
    If IsdbNull(rs9917!K9917_Table9) = False Then D9917.Table9 = Trim$(rs9917!K9917_Table9)
    If IsdbNull(rs9917!K9917_Table10) = False Then D9917.Table10 = Trim$(rs9917!K9917_Table10)
    If IsdbNull(rs9917!K9917_Table11) = False Then D9917.Table11 = Trim$(rs9917!K9917_Table11)
    If IsdbNull(rs9917!K9917_Table12) = False Then D9917.Table12 = Trim$(rs9917!K9917_Table12)
    If IsdbNull(rs9917!K9917_Table13) = False Then D9917.Table13 = Trim$(rs9917!K9917_Table13)
    If IsdbNull(rs9917!K9917_Table14) = False Then D9917.Table14 = Trim$(rs9917!K9917_Table14)
    If IsdbNull(rs9917!K9917_Table15) = False Then D9917.Table15 = Trim$(rs9917!K9917_Table15)
    If IsdbNull(rs9917!K9917_Remark) = False Then D9917.Remark = Trim$(rs9917!K9917_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9917_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K9917_MOVE(rs9917 As DataRow)
Try

    call D9917_CLEAR()   

    If IsdbNull(rs9917!K9917_ProgramNo) = False Then D9917.ProgramNo = Trim$(rs9917!K9917_ProgramNo)
    If IsdbNull(rs9917!K9917_Table) = False Then D9917.Table = Trim$(rs9917!K9917_Table)
    If IsdbNull(rs9917!K9917_Table1) = False Then D9917.Table1 = Trim$(rs9917!K9917_Table1)
    If IsdbNull(rs9917!K9917_Table2) = False Then D9917.Table2 = Trim$(rs9917!K9917_Table2)
    If IsdbNull(rs9917!K9917_Table3) = False Then D9917.Table3 = Trim$(rs9917!K9917_Table3)
    If IsdbNull(rs9917!K9917_Table4) = False Then D9917.Table4 = Trim$(rs9917!K9917_Table4)
    If IsdbNull(rs9917!K9917_Table5) = False Then D9917.Table5 = Trim$(rs9917!K9917_Table5)
    If IsdbNull(rs9917!K9917_Table6) = False Then D9917.Table6 = Trim$(rs9917!K9917_Table6)
    If IsdbNull(rs9917!K9917_Table7) = False Then D9917.Table7 = Trim$(rs9917!K9917_Table7)
    If IsdbNull(rs9917!K9917_Table8) = False Then D9917.Table8 = Trim$(rs9917!K9917_Table8)
    If IsdbNull(rs9917!K9917_Table9) = False Then D9917.Table9 = Trim$(rs9917!K9917_Table9)
    If IsdbNull(rs9917!K9917_Table10) = False Then D9917.Table10 = Trim$(rs9917!K9917_Table10)
    If IsdbNull(rs9917!K9917_Table11) = False Then D9917.Table11 = Trim$(rs9917!K9917_Table11)
    If IsdbNull(rs9917!K9917_Table12) = False Then D9917.Table12 = Trim$(rs9917!K9917_Table12)
    If IsdbNull(rs9917!K9917_Table13) = False Then D9917.Table13 = Trim$(rs9917!K9917_Table13)
    If IsdbNull(rs9917!K9917_Table14) = False Then D9917.Table14 = Trim$(rs9917!K9917_Table14)
    If IsdbNull(rs9917!K9917_Table15) = False Then D9917.Table15 = Trim$(rs9917!K9917_Table15)
    If IsdbNull(rs9917!K9917_Remark) = False Then D9917.Remark = Trim$(rs9917!K9917_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9917_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K9917_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9917 As T9917_AREA, PROGRAMNO AS String) as Boolean

K9917_MOVE = False

Try
    If READ_PFK9917(PROGRAMNO) = True Then
                z9917 = D9917
		K9917_MOVE = True
		else
	z9917 = nothing
     End If

     If  getColumIndex(spr,"ProgramNo") > -1 then z9917.ProgramNo = getDataM(spr, getColumIndex(spr,"ProgramNo"), xRow)
     If  getColumIndex(spr,"Table") > -1 then z9917.Table = getDataM(spr, getColumIndex(spr,"Table"), xRow)
     If  getColumIndex(spr,"Table1") > -1 then z9917.Table1 = getDataM(spr, getColumIndex(spr,"Table1"), xRow)
     If  getColumIndex(spr,"Table2") > -1 then z9917.Table2 = getDataM(spr, getColumIndex(spr,"Table2"), xRow)
     If  getColumIndex(spr,"Table3") > -1 then z9917.Table3 = getDataM(spr, getColumIndex(spr,"Table3"), xRow)
     If  getColumIndex(spr,"Table4") > -1 then z9917.Table4 = getDataM(spr, getColumIndex(spr,"Table4"), xRow)
     If  getColumIndex(spr,"Table5") > -1 then z9917.Table5 = getDataM(spr, getColumIndex(spr,"Table5"), xRow)
     If  getColumIndex(spr,"Table6") > -1 then z9917.Table6 = getDataM(spr, getColumIndex(spr,"Table6"), xRow)
     If  getColumIndex(spr,"Table7") > -1 then z9917.Table7 = getDataM(spr, getColumIndex(spr,"Table7"), xRow)
     If  getColumIndex(spr,"Table8") > -1 then z9917.Table8 = getDataM(spr, getColumIndex(spr,"Table8"), xRow)
     If  getColumIndex(spr,"Table9") > -1 then z9917.Table9 = getDataM(spr, getColumIndex(spr,"Table9"), xRow)
     If  getColumIndex(spr,"Table10") > -1 then z9917.Table10 = getDataM(spr, getColumIndex(spr,"Table10"), xRow)
     If  getColumIndex(spr,"Table11") > -1 then z9917.Table11 = getDataM(spr, getColumIndex(spr,"Table11"), xRow)
     If  getColumIndex(spr,"Table12") > -1 then z9917.Table12 = getDataM(spr, getColumIndex(spr,"Table12"), xRow)
     If  getColumIndex(spr,"Table13") > -1 then z9917.Table13 = getDataM(spr, getColumIndex(spr,"Table13"), xRow)
     If  getColumIndex(spr,"Table14") > -1 then z9917.Table14 = getDataM(spr, getColumIndex(spr,"Table14"), xRow)
     If  getColumIndex(spr,"Table15") > -1 then z9917.Table15 = getDataM(spr, getColumIndex(spr,"Table15"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z9917.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K9917_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K9917_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9917 As T9917_AREA,CheckClear as Boolean,PROGRAMNO AS String) as Boolean

K9917_MOVE = False

Try
    If READ_PFK9917(PROGRAMNO) = True Then
                z9917 = D9917
		K9917_MOVE = True
		else
	If CheckClear  = True then z9917 = nothing
     End If

     If  getColumIndex(spr,"ProgramNo") > -1 then z9917.ProgramNo = getDataM(spr, getColumIndex(spr,"ProgramNo"), xRow)
     If  getColumIndex(spr,"Table") > -1 then z9917.Table = getDataM(spr, getColumIndex(spr,"Table"), xRow)
     If  getColumIndex(spr,"Table1") > -1 then z9917.Table1 = getDataM(spr, getColumIndex(spr,"Table1"), xRow)
     If  getColumIndex(spr,"Table2") > -1 then z9917.Table2 = getDataM(spr, getColumIndex(spr,"Table2"), xRow)
     If  getColumIndex(spr,"Table3") > -1 then z9917.Table3 = getDataM(spr, getColumIndex(spr,"Table3"), xRow)
     If  getColumIndex(spr,"Table4") > -1 then z9917.Table4 = getDataM(spr, getColumIndex(spr,"Table4"), xRow)
     If  getColumIndex(spr,"Table5") > -1 then z9917.Table5 = getDataM(spr, getColumIndex(spr,"Table5"), xRow)
     If  getColumIndex(spr,"Table6") > -1 then z9917.Table6 = getDataM(spr, getColumIndex(spr,"Table6"), xRow)
     If  getColumIndex(spr,"Table7") > -1 then z9917.Table7 = getDataM(spr, getColumIndex(spr,"Table7"), xRow)
     If  getColumIndex(spr,"Table8") > -1 then z9917.Table8 = getDataM(spr, getColumIndex(spr,"Table8"), xRow)
     If  getColumIndex(spr,"Table9") > -1 then z9917.Table9 = getDataM(spr, getColumIndex(spr,"Table9"), xRow)
     If  getColumIndex(spr,"Table10") > -1 then z9917.Table10 = getDataM(spr, getColumIndex(spr,"Table10"), xRow)
     If  getColumIndex(spr,"Table11") > -1 then z9917.Table11 = getDataM(spr, getColumIndex(spr,"Table11"), xRow)
     If  getColumIndex(spr,"Table12") > -1 then z9917.Table12 = getDataM(spr, getColumIndex(spr,"Table12"), xRow)
     If  getColumIndex(spr,"Table13") > -1 then z9917.Table13 = getDataM(spr, getColumIndex(spr,"Table13"), xRow)
     If  getColumIndex(spr,"Table14") > -1 then z9917.Table14 = getDataM(spr, getColumIndex(spr,"Table14"), xRow)
     If  getColumIndex(spr,"Table15") > -1 then z9917.Table15 = getDataM(spr, getColumIndex(spr,"Table15"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z9917.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K9917_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K9917_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9917 As T9917_AREA, Job as String, PROGRAMNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9917_MOVE = False

Try
    If READ_PFK9917(PROGRAMNO) = True Then
                z9917 = D9917
		K9917_MOVE = True
		else
	z9917 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9917")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "ProgramNo":z9917.ProgramNo = Children(i).Code
   Case "Table":z9917.Table = Children(i).Code
   Case "Table1":z9917.Table1 = Children(i).Code
   Case "Table2":z9917.Table2 = Children(i).Code
   Case "Table3":z9917.Table3 = Children(i).Code
   Case "Table4":z9917.Table4 = Children(i).Code
   Case "Table5":z9917.Table5 = Children(i).Code
   Case "Table6":z9917.Table6 = Children(i).Code
   Case "Table7":z9917.Table7 = Children(i).Code
   Case "Table8":z9917.Table8 = Children(i).Code
   Case "Table9":z9917.Table9 = Children(i).Code
   Case "Table10":z9917.Table10 = Children(i).Code
   Case "Table11":z9917.Table11 = Children(i).Code
   Case "Table12":z9917.Table12 = Children(i).Code
   Case "Table13":z9917.Table13 = Children(i).Code
   Case "Table14":z9917.Table14 = Children(i).Code
   Case "Table15":z9917.Table15 = Children(i).Code
   Case "Remark":z9917.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "ProgramNo":z9917.ProgramNo = Children(i).Data
   Case "Table":z9917.Table = Children(i).Data
   Case "Table1":z9917.Table1 = Children(i).Data
   Case "Table2":z9917.Table2 = Children(i).Data
   Case "Table3":z9917.Table3 = Children(i).Data
   Case "Table4":z9917.Table4 = Children(i).Data
   Case "Table5":z9917.Table5 = Children(i).Data
   Case "Table6":z9917.Table6 = Children(i).Data
   Case "Table7":z9917.Table7 = Children(i).Data
   Case "Table8":z9917.Table8 = Children(i).Data
   Case "Table9":z9917.Table9 = Children(i).Data
   Case "Table10":z9917.Table10 = Children(i).Data
   Case "Table11":z9917.Table11 = Children(i).Data
   Case "Table12":z9917.Table12 = Children(i).Data
   Case "Table13":z9917.Table13 = Children(i).Data
   Case "Table14":z9917.Table14 = Children(i).Data
   Case "Table15":z9917.Table15 = Children(i).Data
   Case "Remark":z9917.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K9917_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K9917_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9917 As T9917_AREA, Job as String, CheckClear as Boolean, PROGRAMNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9917_MOVE = False

Try
    If READ_PFK9917(PROGRAMNO) = True Then
                z9917 = D9917
		K9917_MOVE = True
		else
	If CheckClear  = True then z9917 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9917")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "ProgramNo":z9917.ProgramNo = Children(i).Code
   Case "Table":z9917.Table = Children(i).Code
   Case "Table1":z9917.Table1 = Children(i).Code
   Case "Table2":z9917.Table2 = Children(i).Code
   Case "Table3":z9917.Table3 = Children(i).Code
   Case "Table4":z9917.Table4 = Children(i).Code
   Case "Table5":z9917.Table5 = Children(i).Code
   Case "Table6":z9917.Table6 = Children(i).Code
   Case "Table7":z9917.Table7 = Children(i).Code
   Case "Table8":z9917.Table8 = Children(i).Code
   Case "Table9":z9917.Table9 = Children(i).Code
   Case "Table10":z9917.Table10 = Children(i).Code
   Case "Table11":z9917.Table11 = Children(i).Code
   Case "Table12":z9917.Table12 = Children(i).Code
   Case "Table13":z9917.Table13 = Children(i).Code
   Case "Table14":z9917.Table14 = Children(i).Code
   Case "Table15":z9917.Table15 = Children(i).Code
   Case "Remark":z9917.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "ProgramNo":z9917.ProgramNo = Children(i).Data
   Case "Table":z9917.Table = Children(i).Data
   Case "Table1":z9917.Table1 = Children(i).Data
   Case "Table2":z9917.Table2 = Children(i).Data
   Case "Table3":z9917.Table3 = Children(i).Data
   Case "Table4":z9917.Table4 = Children(i).Data
   Case "Table5":z9917.Table5 = Children(i).Data
   Case "Table6":z9917.Table6 = Children(i).Data
   Case "Table7":z9917.Table7 = Children(i).Data
   Case "Table8":z9917.Table8 = Children(i).Data
   Case "Table9":z9917.Table9 = Children(i).Data
   Case "Table10":z9917.Table10 = Children(i).Data
   Case "Table11":z9917.Table11 = Children(i).Data
   Case "Table12":z9917.Table12 = Children(i).Data
   Case "Table13":z9917.Table13 = Children(i).Data
   Case "Table14":z9917.Table14 = Children(i).Data
   Case "Table15":z9917.Table15 = Children(i).Data
   Case "Remark":z9917.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K9917_MOVE",vbCritical)
End Try
End Function 
    
End Module 
