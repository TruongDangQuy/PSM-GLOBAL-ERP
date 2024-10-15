'=========================================================================================================================================================
'   TABLE : (PFK7172)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7172

Structure T7172_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	AccCode	 AS String	'			char(3)		*
Public 	AccSeq	 AS String	'			char(1)		*
Public 	AccSel	 AS String	'			char(1)		*
Public 	DevelopmentCode	 AS String	'			char(5)
Public 	BasicName	 AS String	'			nvarchar(100)
Public 	ForeignName1	 AS String	'			nvarchar(100)
Public 	ForeignName2	 AS String	'			nvarchar(100)
Public 	NameSimply	 AS String	'			nvarchar(100)
Public 	Check1	 AS String	'			char(1)
Public 	Check2	 AS String	'			char(1)
Public 	Check3	 AS String	'			char(1)
Public 	Check4	 AS String	'			char(1)
Public 	Check5	 AS String	'			char(1)
Public 	Check6	 AS String	'			nvarchar(10)
Public 	Check7	 AS String	'			nvarchar(10)
Public 	Check8	 AS String	'			nvarchar(10)
Public 	Check9	 AS String	'			nvarchar(10)
Public 	Check10	 AS String	'			nvarchar(10)
Public 	CheckName1	 AS String	'			varchar(100)
Public 	CheckName2	 AS String	'			varchar(100)
Public 	CheckName3	 AS String	'			varchar(100)
Public 	CheckName4	 AS String	'			varchar(100)
Public 	CheckName5	 AS String	'			varchar(100)
Public 	CheckName6	 AS String	'			varchar(100)
Public 	CheckName7	 AS String	'			varchar(100)
Public 	CheckName8	 AS String	'			varchar(100)
Public 	CheckName9	 AS String	'			varchar(100)
Public 	CheckName10	 AS String	'			varchar(100)
Public 	Remark	 AS String	'			nvarchar(200)
Public 	UseCheck	 AS String	'			char(1)
Public 	DisplaySeq	 AS String	'			char(5)
'=========================================================================================================================================================
End structure

Public D7172 As T7172_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7172(ACCCODE AS String, ACCSEQ AS String, ACCSEL AS String) As Boolean
    READ_PFK7172 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7172 "
    SQL = SQL & " WHERE K7172_AccCode		 = '" & AccCode & "' " 
    SQL = SQL & "   AND K7172_AccSeq		 = '" & AccSeq & "' " 
    SQL = SQL & "   AND K7172_AccSel		 = '" & AccSel & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7172_CLEAR: GoTo SKIP_READ_PFK7172
                
    Call K7172_MOVE(rd)
    READ_PFK7172 = True

SKIP_READ_PFK7172:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7172",vbCritical)
 End Try
End Function



    Public Function READ_PFK7172_DEV(ACCCODE As String) As Boolean
        READ_PFK7172_DEV = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK7172 "
            SQL = SQL & " WHERE K7172_DevelopmentCode		 = '" & ACCCODE & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7172_CLEAR() : GoTo SKIP_READ_PFK7172

            Call K7172_MOVE(rd)
            READ_PFK7172_DEV = True

SKIP_READ_PFK7172:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7172", vbCritical)
        End Try
    End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7172(ACCCODE AS String, ACCSEQ AS String, ACCSEL AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7172 "
    SQL = SQL & " WHERE K7172_AccCode		 = '" & AccCode & "' " 
    SQL = SQL & "   AND K7172_AccSeq		 = '" & AccSeq & "' " 
    SQL = SQL & "   AND K7172_AccSel		 = '" & AccSel & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7172",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7172(z7172 As T7172_AREA) As Boolean
    WRITE_PFK7172 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7172)
 
    SQL = " INSERT INTO PFK7172 "
    SQL = SQL & " ( "
    SQL = SQL & " K7172_AccCode," 
    SQL = SQL & " K7172_AccSeq," 
    SQL = SQL & " K7172_AccSel," 
    SQL = SQL & " K7172_DevelopmentCode," 
    SQL = SQL & " K7172_BasicName," 
    SQL = SQL & " K7172_ForeignName1," 
    SQL = SQL & " K7172_ForeignName2," 
    SQL = SQL & " K7172_NameSimply," 
    SQL = SQL & " K7172_Check1," 
    SQL = SQL & " K7172_Check2," 
    SQL = SQL & " K7172_Check3," 
    SQL = SQL & " K7172_Check4," 
    SQL = SQL & " K7172_Check5," 
    SQL = SQL & " K7172_Check6," 
    SQL = SQL & " K7172_Check7," 
    SQL = SQL & " K7172_Check8," 
    SQL = SQL & " K7172_Check9," 
    SQL = SQL & " K7172_Check10," 
    SQL = SQL & " K7172_CheckName1," 
    SQL = SQL & " K7172_CheckName2," 
    SQL = SQL & " K7172_CheckName3," 
    SQL = SQL & " K7172_CheckName4," 
    SQL = SQL & " K7172_CheckName5," 
    SQL = SQL & " K7172_CheckName6," 
    SQL = SQL & " K7172_CheckName7," 
    SQL = SQL & " K7172_CheckName8," 
    SQL = SQL & " K7172_CheckName9," 
    SQL = SQL & " K7172_CheckName10," 
    SQL = SQL & " K7172_Remark," 
    SQL = SQL & " K7172_UseCheck," 
    SQL = SQL & " K7172_DisplaySeq " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & z7172.AccCode & "', "  
    SQL = SQL & "  N'" & z7172.AccSeq & "', "  
    SQL = SQL & "  N'" & z7172.AccSel & "', "  
    SQL = SQL & "  N'" & z7172.DevelopmentCode & "', "  
    SQL = SQL & "  N'" & z7172.BasicName & "', "  
    SQL = SQL & "  N'" & z7172.ForeignName1 & "', "  
    SQL = SQL & "  N'" & z7172.ForeignName2 & "', "  
    SQL = SQL & "  N'" & z7172.NameSimply & "', "  
    SQL = SQL & "  N'" & z7172.Check1 & "', "  
    SQL = SQL & "  N'" & z7172.Check2 & "', "  
    SQL = SQL & "  N'" & z7172.Check3 & "', "  
    SQL = SQL & "  N'" & z7172.Check4 & "', "  
    SQL = SQL & "  N'" & z7172.Check5 & "', "  
    SQL = SQL & "  N'" & z7172.Check6 & "', "  
    SQL = SQL & "  N'" & z7172.Check7 & "', "  
    SQL = SQL & "  N'" & z7172.Check8 & "', "  
    SQL = SQL & "  N'" & z7172.Check9 & "', "  
    SQL = SQL & "  N'" & z7172.Check10 & "', "  
    SQL = SQL & "  N'" & z7172.CheckName1 & "', "  
    SQL = SQL & "  N'" & z7172.CheckName2 & "', "  
    SQL = SQL & "  N'" & z7172.CheckName3 & "', "  
    SQL = SQL & "  N'" & z7172.CheckName4 & "', "  
    SQL = SQL & "  N'" & z7172.CheckName5 & "', "  
    SQL = SQL & "  N'" & z7172.CheckName6 & "', "  
    SQL = SQL & "  N'" & z7172.CheckName7 & "', "  
    SQL = SQL & "  N'" & z7172.CheckName8 & "', "  
    SQL = SQL & "  N'" & z7172.CheckName9 & "', "  
    SQL = SQL & "  N'" & z7172.CheckName10 & "', "  
    SQL = SQL & "  N'" & z7172.Remark & "', "  
    SQL = SQL & "  N'" & z7172.UseCheck & "', "  
    SQL = SQL & "  N'" & z7172.DisplaySeq & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7172 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7172",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7172(z7172 As T7172_AREA) As Boolean
    REWRITE_PFK7172 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7172)
   
    SQL = " UPDATE PFK7172 SET "
    SQL = SQL & "    K7172_DevelopmentCode      = N'" & z7172.DevelopmentCode & "', " 
    SQL = SQL & "    K7172_BasicName      = N'" & z7172.BasicName & "', " 
    SQL = SQL & "    K7172_ForeignName1      = N'" & z7172.ForeignName1 & "', " 
    SQL = SQL & "    K7172_ForeignName2      = N'" & z7172.ForeignName2 & "', " 
    SQL = SQL & "    K7172_NameSimply      = N'" & z7172.NameSimply & "', " 
    SQL = SQL & "    K7172_Check1      = N'" & z7172.Check1 & "', " 
    SQL = SQL & "    K7172_Check2      = N'" & z7172.Check2 & "', " 
    SQL = SQL & "    K7172_Check3      = N'" & z7172.Check3 & "', " 
    SQL = SQL & "    K7172_Check4      = N'" & z7172.Check4 & "', " 
    SQL = SQL & "    K7172_Check5      = N'" & z7172.Check5 & "', " 
    SQL = SQL & "    K7172_Check6      = N'" & z7172.Check6 & "', " 
    SQL = SQL & "    K7172_Check7      = N'" & z7172.Check7 & "', " 
    SQL = SQL & "    K7172_Check8      = N'" & z7172.Check8 & "', " 
    SQL = SQL & "    K7172_Check9      = N'" & z7172.Check9 & "', " 
    SQL = SQL & "    K7172_Check10      = N'" & z7172.Check10 & "', " 
    SQL = SQL & "    K7172_CheckName1      = N'" & z7172.CheckName1 & "', " 
    SQL = SQL & "    K7172_CheckName2      = N'" & z7172.CheckName2 & "', " 
    SQL = SQL & "    K7172_CheckName3      = N'" & z7172.CheckName3 & "', " 
    SQL = SQL & "    K7172_CheckName4      = N'" & z7172.CheckName4 & "', " 
    SQL = SQL & "    K7172_CheckName5      = N'" & z7172.CheckName5 & "', " 
    SQL = SQL & "    K7172_CheckName6      = N'" & z7172.CheckName6 & "', " 
    SQL = SQL & "    K7172_CheckName7      = N'" & z7172.CheckName7 & "', " 
    SQL = SQL & "    K7172_CheckName8      = N'" & z7172.CheckName8 & "', " 
    SQL = SQL & "    K7172_CheckName9      = N'" & z7172.CheckName9 & "', " 
    SQL = SQL & "    K7172_CheckName10      = N'" & z7172.CheckName10 & "', " 
    SQL = SQL & "    K7172_Remark      = N'" & z7172.Remark & "', " 
    SQL = SQL & "    K7172_UseCheck      = N'" & z7172.UseCheck & "', " 
    SQL = SQL & "    K7172_DisplaySeq      = N'" & z7172.DisplaySeq & "'  " 
    SQL = SQL & " WHERE K7172_AccCode		 = '" & z7172.AccCode & "' " 
    SQL = SQL & "   AND K7172_AccSeq		 = '" & z7172.AccSeq & "' " 
    SQL = SQL & "   AND K7172_AccSel		 = '" & z7172.AccSel & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7172 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7172",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7172(z7172 As T7172_AREA) As Boolean
    DELETE_PFK7172 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7172 "
    SQL = SQL & " WHERE K7172_AccCode		 = '" & z7172.AccCode & "' " 
    SQL = SQL & "   AND K7172_AccSeq		 = '" & z7172.AccSeq & "' " 
    SQL = SQL & "   AND K7172_AccSel		 = '" & z7172.AccSel & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7172 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7172",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7172_CLEAR()
Try
    
   D7172.AccCode = ""
   D7172.AccSeq = ""
   D7172.AccSel = ""
   D7172.DevelopmentCode = ""
   D7172.BasicName = ""
   D7172.ForeignName1 = ""
   D7172.ForeignName2 = ""
   D7172.NameSimply = ""
   D7172.Check1 = ""
   D7172.Check2 = ""
   D7172.Check3 = ""
   D7172.Check4 = ""
   D7172.Check5 = ""
   D7172.Check6 = ""
   D7172.Check7 = ""
   D7172.Check8 = ""
   D7172.Check9 = ""
   D7172.Check10 = ""
   D7172.CheckName1 = ""
   D7172.CheckName2 = ""
   D7172.CheckName3 = ""
   D7172.CheckName4 = ""
   D7172.CheckName5 = ""
   D7172.CheckName6 = ""
   D7172.CheckName7 = ""
   D7172.CheckName8 = ""
   D7172.CheckName9 = ""
   D7172.CheckName10 = ""
   D7172.Remark = ""
   D7172.UseCheck = ""
   D7172.DisplaySeq = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7172_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7172 As T7172_AREA)
Try
    
    x7172.AccCode = trim$(  x7172.AccCode)
    x7172.AccSeq = trim$(  x7172.AccSeq)
    x7172.AccSel = trim$(  x7172.AccSel)
    x7172.DevelopmentCode = trim$(  x7172.DevelopmentCode)
    x7172.BasicName = trim$(  x7172.BasicName)
    x7172.ForeignName1 = trim$(  x7172.ForeignName1)
    x7172.ForeignName2 = trim$(  x7172.ForeignName2)
    x7172.NameSimply = trim$(  x7172.NameSimply)
    x7172.Check1 = trim$(  x7172.Check1)
    x7172.Check2 = trim$(  x7172.Check2)
    x7172.Check3 = trim$(  x7172.Check3)
    x7172.Check4 = trim$(  x7172.Check4)
    x7172.Check5 = trim$(  x7172.Check5)
    x7172.Check6 = trim$(  x7172.Check6)
    x7172.Check7 = trim$(  x7172.Check7)
    x7172.Check8 = trim$(  x7172.Check8)
    x7172.Check9 = trim$(  x7172.Check9)
    x7172.Check10 = trim$(  x7172.Check10)
    x7172.CheckName1 = trim$(  x7172.CheckName1)
    x7172.CheckName2 = trim$(  x7172.CheckName2)
    x7172.CheckName3 = trim$(  x7172.CheckName3)
    x7172.CheckName4 = trim$(  x7172.CheckName4)
    x7172.CheckName5 = trim$(  x7172.CheckName5)
    x7172.CheckName6 = trim$(  x7172.CheckName6)
    x7172.CheckName7 = trim$(  x7172.CheckName7)
    x7172.CheckName8 = trim$(  x7172.CheckName8)
    x7172.CheckName9 = trim$(  x7172.CheckName9)
    x7172.CheckName10 = trim$(  x7172.CheckName10)
    x7172.Remark = trim$(  x7172.Remark)
    x7172.UseCheck = trim$(  x7172.UseCheck)
    x7172.DisplaySeq = trim$(  x7172.DisplaySeq)
     
    If trim$( x7172.AccCode ) = "" Then x7172.AccCode = Space(1) 
    If trim$( x7172.AccSeq ) = "" Then x7172.AccSeq = Space(1) 
    If trim$( x7172.AccSel ) = "" Then x7172.AccSel = Space(1) 
    If trim$( x7172.DevelopmentCode ) = "" Then x7172.DevelopmentCode = Space(1) 
    If trim$( x7172.BasicName ) = "" Then x7172.BasicName = Space(1) 
    If trim$( x7172.ForeignName1 ) = "" Then x7172.ForeignName1 = Space(1) 
    If trim$( x7172.ForeignName2 ) = "" Then x7172.ForeignName2 = Space(1) 
    If trim$( x7172.NameSimply ) = "" Then x7172.NameSimply = Space(1) 
    If trim$( x7172.Check1 ) = "" Then x7172.Check1 = Space(1) 
    If trim$( x7172.Check2 ) = "" Then x7172.Check2 = Space(1) 
    If trim$( x7172.Check3 ) = "" Then x7172.Check3 = Space(1) 
    If trim$( x7172.Check4 ) = "" Then x7172.Check4 = Space(1) 
    If trim$( x7172.Check5 ) = "" Then x7172.Check5 = Space(1) 
    If trim$( x7172.Check6 ) = "" Then x7172.Check6 = Space(1) 
    If trim$( x7172.Check7 ) = "" Then x7172.Check7 = Space(1) 
    If trim$( x7172.Check8 ) = "" Then x7172.Check8 = Space(1) 
    If trim$( x7172.Check9 ) = "" Then x7172.Check9 = Space(1) 
    If trim$( x7172.Check10 ) = "" Then x7172.Check10 = Space(1) 
    If trim$( x7172.CheckName1 ) = "" Then x7172.CheckName1 = Space(1) 
    If trim$( x7172.CheckName2 ) = "" Then x7172.CheckName2 = Space(1) 
    If trim$( x7172.CheckName3 ) = "" Then x7172.CheckName3 = Space(1) 
    If trim$( x7172.CheckName4 ) = "" Then x7172.CheckName4 = Space(1) 
    If trim$( x7172.CheckName5 ) = "" Then x7172.CheckName5 = Space(1) 
    If trim$( x7172.CheckName6 ) = "" Then x7172.CheckName6 = Space(1) 
    If trim$( x7172.CheckName7 ) = "" Then x7172.CheckName7 = Space(1) 
    If trim$( x7172.CheckName8 ) = "" Then x7172.CheckName8 = Space(1) 
    If trim$( x7172.CheckName9 ) = "" Then x7172.CheckName9 = Space(1) 
    If trim$( x7172.CheckName10 ) = "" Then x7172.CheckName10 = Space(1) 
    If trim$( x7172.Remark ) = "" Then x7172.Remark = Space(1) 
    If trim$( x7172.UseCheck ) = "" Then x7172.UseCheck = Space(1) 
    If trim$( x7172.DisplaySeq ) = "" Then x7172.DisplaySeq = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7172_MOVE(rs7172 As SqlClient.SqlDataReader)
Try

    call D7172_CLEAR()   

    If IsdbNull(rs7172!K7172_AccCode) = False Then D7172.AccCode = Trim$(rs7172!K7172_AccCode)
    If IsdbNull(rs7172!K7172_AccSeq) = False Then D7172.AccSeq = Trim$(rs7172!K7172_AccSeq)
    If IsdbNull(rs7172!K7172_AccSel) = False Then D7172.AccSel = Trim$(rs7172!K7172_AccSel)
    If IsdbNull(rs7172!K7172_DevelopmentCode) = False Then D7172.DevelopmentCode = Trim$(rs7172!K7172_DevelopmentCode)
    If IsdbNull(rs7172!K7172_BasicName) = False Then D7172.BasicName = Trim$(rs7172!K7172_BasicName)
    If IsdbNull(rs7172!K7172_ForeignName1) = False Then D7172.ForeignName1 = Trim$(rs7172!K7172_ForeignName1)
    If IsdbNull(rs7172!K7172_ForeignName2) = False Then D7172.ForeignName2 = Trim$(rs7172!K7172_ForeignName2)
    If IsdbNull(rs7172!K7172_NameSimply) = False Then D7172.NameSimply = Trim$(rs7172!K7172_NameSimply)
    If IsdbNull(rs7172!K7172_Check1) = False Then D7172.Check1 = Trim$(rs7172!K7172_Check1)
    If IsdbNull(rs7172!K7172_Check2) = False Then D7172.Check2 = Trim$(rs7172!K7172_Check2)
    If IsdbNull(rs7172!K7172_Check3) = False Then D7172.Check3 = Trim$(rs7172!K7172_Check3)
    If IsdbNull(rs7172!K7172_Check4) = False Then D7172.Check4 = Trim$(rs7172!K7172_Check4)
    If IsdbNull(rs7172!K7172_Check5) = False Then D7172.Check5 = Trim$(rs7172!K7172_Check5)
    If IsdbNull(rs7172!K7172_Check6) = False Then D7172.Check6 = Trim$(rs7172!K7172_Check6)
    If IsdbNull(rs7172!K7172_Check7) = False Then D7172.Check7 = Trim$(rs7172!K7172_Check7)
    If IsdbNull(rs7172!K7172_Check8) = False Then D7172.Check8 = Trim$(rs7172!K7172_Check8)
    If IsdbNull(rs7172!K7172_Check9) = False Then D7172.Check9 = Trim$(rs7172!K7172_Check9)
    If IsdbNull(rs7172!K7172_Check10) = False Then D7172.Check10 = Trim$(rs7172!K7172_Check10)
    If IsdbNull(rs7172!K7172_CheckName1) = False Then D7172.CheckName1 = Trim$(rs7172!K7172_CheckName1)
    If IsdbNull(rs7172!K7172_CheckName2) = False Then D7172.CheckName2 = Trim$(rs7172!K7172_CheckName2)
    If IsdbNull(rs7172!K7172_CheckName3) = False Then D7172.CheckName3 = Trim$(rs7172!K7172_CheckName3)
    If IsdbNull(rs7172!K7172_CheckName4) = False Then D7172.CheckName4 = Trim$(rs7172!K7172_CheckName4)
    If IsdbNull(rs7172!K7172_CheckName5) = False Then D7172.CheckName5 = Trim$(rs7172!K7172_CheckName5)
    If IsdbNull(rs7172!K7172_CheckName6) = False Then D7172.CheckName6 = Trim$(rs7172!K7172_CheckName6)
    If IsdbNull(rs7172!K7172_CheckName7) = False Then D7172.CheckName7 = Trim$(rs7172!K7172_CheckName7)
    If IsdbNull(rs7172!K7172_CheckName8) = False Then D7172.CheckName8 = Trim$(rs7172!K7172_CheckName8)
    If IsdbNull(rs7172!K7172_CheckName9) = False Then D7172.CheckName9 = Trim$(rs7172!K7172_CheckName9)
    If IsdbNull(rs7172!K7172_CheckName10) = False Then D7172.CheckName10 = Trim$(rs7172!K7172_CheckName10)
    If IsdbNull(rs7172!K7172_Remark) = False Then D7172.Remark = Trim$(rs7172!K7172_Remark)
    If IsdbNull(rs7172!K7172_UseCheck) = False Then D7172.UseCheck = Trim$(rs7172!K7172_UseCheck)
    If IsdbNull(rs7172!K7172_DisplaySeq) = False Then D7172.DisplaySeq = Trim$(rs7172!K7172_DisplaySeq)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7172_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7172_MOVE(rs7172 As DataRow)
Try

    call D7172_CLEAR()   

    If IsdbNull(rs7172!K7172_AccCode) = False Then D7172.AccCode = Trim$(rs7172!K7172_AccCode)
    If IsdbNull(rs7172!K7172_AccSeq) = False Then D7172.AccSeq = Trim$(rs7172!K7172_AccSeq)
    If IsdbNull(rs7172!K7172_AccSel) = False Then D7172.AccSel = Trim$(rs7172!K7172_AccSel)
    If IsdbNull(rs7172!K7172_DevelopmentCode) = False Then D7172.DevelopmentCode = Trim$(rs7172!K7172_DevelopmentCode)
    If IsdbNull(rs7172!K7172_BasicName) = False Then D7172.BasicName = Trim$(rs7172!K7172_BasicName)
    If IsdbNull(rs7172!K7172_ForeignName1) = False Then D7172.ForeignName1 = Trim$(rs7172!K7172_ForeignName1)
    If IsdbNull(rs7172!K7172_ForeignName2) = False Then D7172.ForeignName2 = Trim$(rs7172!K7172_ForeignName2)
    If IsdbNull(rs7172!K7172_NameSimply) = False Then D7172.NameSimply = Trim$(rs7172!K7172_NameSimply)
    If IsdbNull(rs7172!K7172_Check1) = False Then D7172.Check1 = Trim$(rs7172!K7172_Check1)
    If IsdbNull(rs7172!K7172_Check2) = False Then D7172.Check2 = Trim$(rs7172!K7172_Check2)
    If IsdbNull(rs7172!K7172_Check3) = False Then D7172.Check3 = Trim$(rs7172!K7172_Check3)
    If IsdbNull(rs7172!K7172_Check4) = False Then D7172.Check4 = Trim$(rs7172!K7172_Check4)
    If IsdbNull(rs7172!K7172_Check5) = False Then D7172.Check5 = Trim$(rs7172!K7172_Check5)
    If IsdbNull(rs7172!K7172_Check6) = False Then D7172.Check6 = Trim$(rs7172!K7172_Check6)
    If IsdbNull(rs7172!K7172_Check7) = False Then D7172.Check7 = Trim$(rs7172!K7172_Check7)
    If IsdbNull(rs7172!K7172_Check8) = False Then D7172.Check8 = Trim$(rs7172!K7172_Check8)
    If IsdbNull(rs7172!K7172_Check9) = False Then D7172.Check9 = Trim$(rs7172!K7172_Check9)
    If IsdbNull(rs7172!K7172_Check10) = False Then D7172.Check10 = Trim$(rs7172!K7172_Check10)
    If IsdbNull(rs7172!K7172_CheckName1) = False Then D7172.CheckName1 = Trim$(rs7172!K7172_CheckName1)
    If IsdbNull(rs7172!K7172_CheckName2) = False Then D7172.CheckName2 = Trim$(rs7172!K7172_CheckName2)
    If IsdbNull(rs7172!K7172_CheckName3) = False Then D7172.CheckName3 = Trim$(rs7172!K7172_CheckName3)
    If IsdbNull(rs7172!K7172_CheckName4) = False Then D7172.CheckName4 = Trim$(rs7172!K7172_CheckName4)
    If IsdbNull(rs7172!K7172_CheckName5) = False Then D7172.CheckName5 = Trim$(rs7172!K7172_CheckName5)
    If IsdbNull(rs7172!K7172_CheckName6) = False Then D7172.CheckName6 = Trim$(rs7172!K7172_CheckName6)
    If IsdbNull(rs7172!K7172_CheckName7) = False Then D7172.CheckName7 = Trim$(rs7172!K7172_CheckName7)
    If IsdbNull(rs7172!K7172_CheckName8) = False Then D7172.CheckName8 = Trim$(rs7172!K7172_CheckName8)
    If IsdbNull(rs7172!K7172_CheckName9) = False Then D7172.CheckName9 = Trim$(rs7172!K7172_CheckName9)
    If IsdbNull(rs7172!K7172_CheckName10) = False Then D7172.CheckName10 = Trim$(rs7172!K7172_CheckName10)
    If IsdbNull(rs7172!K7172_Remark) = False Then D7172.Remark = Trim$(rs7172!K7172_Remark)
    If IsdbNull(rs7172!K7172_UseCheck) = False Then D7172.UseCheck = Trim$(rs7172!K7172_UseCheck)
    If IsdbNull(rs7172!K7172_DisplaySeq) = False Then D7172.DisplaySeq = Trim$(rs7172!K7172_DisplaySeq)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7172_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7172_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7172 As T7172_AREA,ACCCODE AS String, ACCSEQ AS String, ACCSEL AS String) as Boolean

K7172_MOVE = False

Try
    If READ_PFK7172(ACCCODE, ACCSEQ, ACCSEL) = True Then
                z7172 = D7172
		K7172_MOVE = True
		else
		 z7172 = nothing
     End If

     If  getColumIndex(spr,"AccCode") > -1 then z7172.AccCode = getDataM(spr, getColumIndex(spr,"AccCode"), xRow)
     If  getColumIndex(spr,"AccSeq") > -1 then z7172.AccSeq = getDataM(spr, getColumIndex(spr,"AccSeq"), xRow)
     If  getColumIndex(spr,"AccSel") > -1 then z7172.AccSel = getDataM(spr, getColumIndex(spr,"AccSel"), xRow)
     If  getColumIndex(spr,"DevelopmentCode") > -1 then z7172.DevelopmentCode = getDataM(spr, getColumIndex(spr,"DevelopmentCode"), xRow)
     If  getColumIndex(spr,"BasicName") > -1 then z7172.BasicName = getDataM(spr, getColumIndex(spr,"BasicName"), xRow)
     If  getColumIndex(spr,"ForeignName1") > -1 then z7172.ForeignName1 = getDataM(spr, getColumIndex(spr,"ForeignName1"), xRow)
     If  getColumIndex(spr,"ForeignName2") > -1 then z7172.ForeignName2 = getDataM(spr, getColumIndex(spr,"ForeignName2"), xRow)
     If  getColumIndex(spr,"NameSimply") > -1 then z7172.NameSimply = getDataM(spr, getColumIndex(spr,"NameSimply"), xRow)
     If  getColumIndex(spr,"Check1") > -1 then z7172.Check1 = getDataM(spr, getColumIndex(spr,"Check1"), xRow)
     If  getColumIndex(spr,"Check2") > -1 then z7172.Check2 = getDataM(spr, getColumIndex(spr,"Check2"), xRow)
     If  getColumIndex(spr,"Check3") > -1 then z7172.Check3 = getDataM(spr, getColumIndex(spr,"Check3"), xRow)
     If  getColumIndex(spr,"Check4") > -1 then z7172.Check4 = getDataM(spr, getColumIndex(spr,"Check4"), xRow)
     If  getColumIndex(spr,"Check5") > -1 then z7172.Check5 = getDataM(spr, getColumIndex(spr,"Check5"), xRow)
     If  getColumIndex(spr,"Check6") > -1 then z7172.Check6 = getDataM(spr, getColumIndex(spr,"Check6"), xRow)
     If  getColumIndex(spr,"Check7") > -1 then z7172.Check7 = getDataM(spr, getColumIndex(spr,"Check7"), xRow)
     If  getColumIndex(spr,"Check8") > -1 then z7172.Check8 = getDataM(spr, getColumIndex(spr,"Check8"), xRow)
     If  getColumIndex(spr,"Check9") > -1 then z7172.Check9 = getDataM(spr, getColumIndex(spr,"Check9"), xRow)
     If  getColumIndex(spr,"Check10") > -1 then z7172.Check10 = getDataM(spr, getColumIndex(spr,"Check10"), xRow)
     If  getColumIndex(spr,"CheckName1") > -1 then z7172.CheckName1 = getDataM(spr, getColumIndex(spr,"CheckName1"), xRow)
     If  getColumIndex(spr,"CheckName2") > -1 then z7172.CheckName2 = getDataM(spr, getColumIndex(spr,"CheckName2"), xRow)
     If  getColumIndex(spr,"CheckName3") > -1 then z7172.CheckName3 = getDataM(spr, getColumIndex(spr,"CheckName3"), xRow)
     If  getColumIndex(spr,"CheckName4") > -1 then z7172.CheckName4 = getDataM(spr, getColumIndex(spr,"CheckName4"), xRow)
     If  getColumIndex(spr,"CheckName5") > -1 then z7172.CheckName5 = getDataM(spr, getColumIndex(spr,"CheckName5"), xRow)
     If  getColumIndex(spr,"CheckName6") > -1 then z7172.CheckName6 = getDataM(spr, getColumIndex(spr,"CheckName6"), xRow)
     If  getColumIndex(spr,"CheckName7") > -1 then z7172.CheckName7 = getDataM(spr, getColumIndex(spr,"CheckName7"), xRow)
     If  getColumIndex(spr,"CheckName8") > -1 then z7172.CheckName8 = getDataM(spr, getColumIndex(spr,"CheckName8"), xRow)
     If  getColumIndex(spr,"CheckName9") > -1 then z7172.CheckName9 = getDataM(spr, getColumIndex(spr,"CheckName9"), xRow)
     If  getColumIndex(spr,"CheckName10") > -1 then z7172.CheckName10 = getDataM(spr, getColumIndex(spr,"CheckName10"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7172.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)
     If  getColumIndex(spr,"UseCheck") > -1 then z7172.UseCheck = getDataM(spr, getColumIndex(spr,"UseCheck"), xRow)
     If  getColumIndex(spr,"DisplaySeq") > -1 then z7172.DisplaySeq = getDataM(spr, getColumIndex(spr,"DisplaySeq"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7172_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7172_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7172 As T7172_AREA, Job as String,ACCCODE AS String, ACCSEQ AS String, ACCSEL AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7172_MOVE = False

Try
    If READ_PFK7172(ACCCODE, ACCSEQ, ACCSEL) = True Then
                z7172 = D7172
		K7172_MOVE = True
		else
		 z7172 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7172")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AccCode":z7172.AccCode = Children(i).Code
   Case "AccSeq":z7172.AccSeq = Children(i).Code
   Case "AccSel":z7172.AccSel = Children(i).Code
   Case "DevelopmentCode":z7172.DevelopmentCode = Children(i).Code
   Case "BasicName":z7172.BasicName = Children(i).Code
   Case "ForeignName1":z7172.ForeignName1 = Children(i).Code
   Case "ForeignName2":z7172.ForeignName2 = Children(i).Code
   Case "NameSimply":z7172.NameSimply = Children(i).Code
   Case "Check1":z7172.Check1 = Children(i).Code
   Case "Check2":z7172.Check2 = Children(i).Code
   Case "Check3":z7172.Check3 = Children(i).Code
   Case "Check4":z7172.Check4 = Children(i).Code
   Case "Check5":z7172.Check5 = Children(i).Code
   Case "Check6":z7172.Check6 = Children(i).Code
   Case "Check7":z7172.Check7 = Children(i).Code
   Case "Check8":z7172.Check8 = Children(i).Code
   Case "Check9":z7172.Check9 = Children(i).Code
   Case "Check10":z7172.Check10 = Children(i).Code
   Case "CheckName1":z7172.CheckName1 = Children(i).Code
   Case "CheckName2":z7172.CheckName2 = Children(i).Code
   Case "CheckName3":z7172.CheckName3 = Children(i).Code
   Case "CheckName4":z7172.CheckName4 = Children(i).Code
   Case "CheckName5":z7172.CheckName5 = Children(i).Code
   Case "CheckName6":z7172.CheckName6 = Children(i).Code
   Case "CheckName7":z7172.CheckName7 = Children(i).Code
   Case "CheckName8":z7172.CheckName8 = Children(i).Code
   Case "CheckName9":z7172.CheckName9 = Children(i).Code
   Case "CheckName10":z7172.CheckName10 = Children(i).Code
   Case "Remark":z7172.Remark = Children(i).Code
   Case "UseCheck":z7172.UseCheck = Children(i).Code
   Case "DisplaySeq":z7172.DisplaySeq = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AccCode":z7172.AccCode = Children(i).Data
   Case "AccSeq":z7172.AccSeq = Children(i).Data
   Case "AccSel":z7172.AccSel = Children(i).Data
   Case "DevelopmentCode":z7172.DevelopmentCode = Children(i).Data
   Case "BasicName":z7172.BasicName = Children(i).Data
   Case "ForeignName1":z7172.ForeignName1 = Children(i).Data
   Case "ForeignName2":z7172.ForeignName2 = Children(i).Data
   Case "NameSimply":z7172.NameSimply = Children(i).Data
   Case "Check1":z7172.Check1 = Children(i).Data
   Case "Check2":z7172.Check2 = Children(i).Data
   Case "Check3":z7172.Check3 = Children(i).Data
   Case "Check4":z7172.Check4 = Children(i).Data
   Case "Check5":z7172.Check5 = Children(i).Data
   Case "Check6":z7172.Check6 = Children(i).Data
   Case "Check7":z7172.Check7 = Children(i).Data
   Case "Check8":z7172.Check8 = Children(i).Data
   Case "Check9":z7172.Check9 = Children(i).Data
   Case "Check10":z7172.Check10 = Children(i).Data
   Case "CheckName1":z7172.CheckName1 = Children(i).Data
   Case "CheckName2":z7172.CheckName2 = Children(i).Data
   Case "CheckName3":z7172.CheckName3 = Children(i).Data
   Case "CheckName4":z7172.CheckName4 = Children(i).Data
   Case "CheckName5":z7172.CheckName5 = Children(i).Data
   Case "CheckName6":z7172.CheckName6 = Children(i).Data
   Case "CheckName7":z7172.CheckName7 = Children(i).Data
   Case "CheckName8":z7172.CheckName8 = Children(i).Data
   Case "CheckName9":z7172.CheckName9 = Children(i).Data
   Case "CheckName10":z7172.CheckName10 = Children(i).Data
   Case "Remark":z7172.Remark = Children(i).Data
   Case "UseCheck":z7172.UseCheck = Children(i).Data
   Case "DisplaySeq":z7172.DisplaySeq = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7172_MOVE",vbCritical)
End Try
End Function 
    
End Module 
