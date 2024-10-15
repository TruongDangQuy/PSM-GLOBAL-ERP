'=========================================================================================================================================================
'   TABLE : (PFK7173)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7173

    Structure T7173_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public BankCode As String  '			nvarchar(5)		*
        Public AccountCode As String  '			nvarchar(15)
        Public BasicName As String  '			nvarchar(100)
        Public ForeignName1 As String  '			nvarchar(100)
        Public ForeignName2 As String  '			nvarchar(100)
        Public NameSimply As String  '			nvarchar(100)
        Public Check1 As String  '			char(1)
        Public Check2 As String  '			char(1)
        Public Check3 As String  '			char(1)
        Public Check4 As String  '			char(1)
        Public Check5 As String  '			char(1)
        Public Check6 As String  '			nvarchar(10)
        Public Check7 As String  '			nvarchar(10)
        Public Check8 As String  '			nvarchar(10)
        Public Check9 As String  '			nvarchar(10)
        Public Check10 As String  '			nvarchar(10)
        Public CheckName1 As String  '			varchar(100)
        Public CheckName2 As String  '			varchar(100)
        Public CheckName3 As String  '			varchar(100)
        Public CheckName4 As String  '			varchar(100)
        Public CheckName5 As String  '			varchar(100)
        Public CheckName6 As String  '			varchar(100)
        Public CheckName7 As String  '			varchar(100)
        Public CheckName8 As String  '			varchar(100)
        Public CheckName9 As String  '			varchar(100)
        Public CheckName10 As String  '			varchar(100)
        Public Remark As String  '			nvarchar(200)
        Public UseCheck As String  '			char(1)
        Public DisplaySeq As String  '			char(5)
        '=========================================================================================================================================================
    End Structure

    Public D7173 As T7173_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK7173(BANKCODE As String) As Boolean
        READ_PFK7173 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7173 "
            SQL = SQL & " WHERE K7173_BankCode		 = '" & BankCode & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7173_CLEAR() : GoTo SKIP_READ_PFK7173

            Call K7173_MOVE(rd)
            READ_PFK7173 = True

SKIP_READ_PFK7173:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7173", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK7173(BANKCODE As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7173 "
            SQL = SQL & " WHERE K7173_BankCode		 = '" & BankCode & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK7173", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK7173(z7173 As T7173_AREA) As Boolean
        WRITE_PFK7173 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7173)

            SQL = " INSERT INTO PFK7173 "
            SQL = SQL & " ( "
            SQL = SQL & " K7173_BankCode,"
            SQL = SQL & " K7173_AccountCode,"
            SQL = SQL & " K7173_BasicName,"
            SQL = SQL & " K7173_ForeignName1,"
            SQL = SQL & " K7173_ForeignName2,"
            SQL = SQL & " K7173_NameSimply,"
            SQL = SQL & " K7173_Check1,"
            SQL = SQL & " K7173_Check2,"
            SQL = SQL & " K7173_Check3,"
            SQL = SQL & " K7173_Check4,"
            SQL = SQL & " K7173_Check5,"
            SQL = SQL & " K7173_Check6,"
            SQL = SQL & " K7173_Check7,"
            SQL = SQL & " K7173_Check8,"
            SQL = SQL & " K7173_Check9,"
            SQL = SQL & " K7173_Check10,"
            SQL = SQL & " K7173_CheckName1,"
            SQL = SQL & " K7173_CheckName2,"
            SQL = SQL & " K7173_CheckName3,"
            SQL = SQL & " K7173_CheckName4,"
            SQL = SQL & " K7173_CheckName5,"
            SQL = SQL & " K7173_CheckName6,"
            SQL = SQL & " K7173_CheckName7,"
            SQL = SQL & " K7173_CheckName8,"
            SQL = SQL & " K7173_CheckName9,"
            SQL = SQL & " K7173_CheckName10,"
            SQL = SQL & " K7173_Remark,"
            SQL = SQL & " K7173_UseCheck,"
            SQL = SQL & " K7173_DisplaySeq "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z7173.BankCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7173.AccountCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7173.BasicName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7173.ForeignName1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7173.ForeignName2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7173.NameSimply) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7173.Check1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7173.Check2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7173.Check3) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7173.Check4) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7173.Check5) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7173.Check6) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7173.Check7) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7173.Check8) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7173.Check9) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7173.Check10) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7173.CheckName1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7173.CheckName2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7173.CheckName3) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7173.CheckName4) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7173.CheckName5) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7173.CheckName6) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7173.CheckName7) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7173.CheckName8) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7173.CheckName9) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7173.CheckName10) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7173.Remark) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7173.UseCheck) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7173.DisplaySeq) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK7173 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK7173", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK7173(z7173 As T7173_AREA) As Boolean
        REWRITE_PFK7173 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7173)

            SQL = " UPDATE PFK7173 SET "
            SQL = SQL & "    K7173_AccountCode      = N'" & FormatSQL(z7173.AccountCode) & "', "
            SQL = SQL & "    K7173_BasicName      = N'" & FormatSQL(z7173.BasicName) & "', "
            SQL = SQL & "    K7173_ForeignName1      = N'" & FormatSQL(z7173.ForeignName1) & "', "
            SQL = SQL & "    K7173_ForeignName2      = N'" & FormatSQL(z7173.ForeignName2) & "', "
            SQL = SQL & "    K7173_NameSimply      = N'" & FormatSQL(z7173.NameSimply) & "', "
            SQL = SQL & "    K7173_Check1      = N'" & FormatSQL(z7173.Check1) & "', "
            SQL = SQL & "    K7173_Check2      = N'" & FormatSQL(z7173.Check2) & "', "
            SQL = SQL & "    K7173_Check3      = N'" & FormatSQL(z7173.Check3) & "', "
            SQL = SQL & "    K7173_Check4      = N'" & FormatSQL(z7173.Check4) & "', "
            SQL = SQL & "    K7173_Check5      = N'" & FormatSQL(z7173.Check5) & "', "
            SQL = SQL & "    K7173_Check6      = N'" & FormatSQL(z7173.Check6) & "', "
            SQL = SQL & "    K7173_Check7      = N'" & FormatSQL(z7173.Check7) & "', "
            SQL = SQL & "    K7173_Check8      = N'" & FormatSQL(z7173.Check8) & "', "
            SQL = SQL & "    K7173_Check9      = N'" & FormatSQL(z7173.Check9) & "', "
            SQL = SQL & "    K7173_Check10      = N'" & FormatSQL(z7173.Check10) & "', "
            SQL = SQL & "    K7173_CheckName1      = N'" & FormatSQL(z7173.CheckName1) & "', "
            SQL = SQL & "    K7173_CheckName2      = N'" & FormatSQL(z7173.CheckName2) & "', "
            SQL = SQL & "    K7173_CheckName3      = N'" & FormatSQL(z7173.CheckName3) & "', "
            SQL = SQL & "    K7173_CheckName4      = N'" & FormatSQL(z7173.CheckName4) & "', "
            SQL = SQL & "    K7173_CheckName5      = N'" & FormatSQL(z7173.CheckName5) & "', "
            SQL = SQL & "    K7173_CheckName6      = N'" & FormatSQL(z7173.CheckName6) & "', "
            SQL = SQL & "    K7173_CheckName7      = N'" & FormatSQL(z7173.CheckName7) & "', "
            SQL = SQL & "    K7173_CheckName8      = N'" & FormatSQL(z7173.CheckName8) & "', "
            SQL = SQL & "    K7173_CheckName9      = N'" & FormatSQL(z7173.CheckName9) & "', "
            SQL = SQL & "    K7173_CheckName10      = N'" & FormatSQL(z7173.CheckName10) & "', "
            SQL = SQL & "    K7173_Remark      = N'" & FormatSQL(z7173.Remark) & "', "
            SQL = SQL & "    K7173_UseCheck      = N'" & FormatSQL(z7173.UseCheck) & "', "
            SQL = SQL & "    K7173_DisplaySeq      = N'" & FormatSQL(z7173.DisplaySeq) & "'  "
            SQL = SQL & " WHERE K7173_BankCode		 = '" & z7173.BankCode & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK7173 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK7173", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK7173(z7173 As T7173_AREA) As Boolean
        DELETE_PFK7173 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK7173 "
            SQL = SQL & " WHERE K7173_BankCode		 = '" & z7173.BankCode & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK7173 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK7173", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D7173_CLEAR()
        Try

            D7173.BankCode = ""
            D7173.AccountCode = ""
            D7173.BasicName = ""
            D7173.ForeignName1 = ""
            D7173.ForeignName2 = ""
            D7173.NameSimply = ""
            D7173.Check1 = ""
            D7173.Check2 = ""
            D7173.Check3 = ""
            D7173.Check4 = ""
            D7173.Check5 = ""
            D7173.Check6 = ""
            D7173.Check7 = ""
            D7173.Check8 = ""
            D7173.Check9 = ""
            D7173.Check10 = ""
            D7173.CheckName1 = ""
            D7173.CheckName2 = ""
            D7173.CheckName3 = ""
            D7173.CheckName4 = ""
            D7173.CheckName5 = ""
            D7173.CheckName6 = ""
            D7173.CheckName7 = ""
            D7173.CheckName8 = ""
            D7173.CheckName9 = ""
            D7173.CheckName10 = ""
            D7173.Remark = ""
            D7173.UseCheck = ""
            D7173.DisplaySeq = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D7173_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x7173 As T7173_AREA)
        Try

            x7173.BankCode = trim$(x7173.BankCode)
            x7173.AccountCode = trim$(x7173.AccountCode)
            x7173.BasicName = trim$(x7173.BasicName)
            x7173.ForeignName1 = trim$(x7173.ForeignName1)
            x7173.ForeignName2 = trim$(x7173.ForeignName2)
            x7173.NameSimply = trim$(x7173.NameSimply)
            x7173.Check1 = trim$(x7173.Check1)
            x7173.Check2 = trim$(x7173.Check2)
            x7173.Check3 = trim$(x7173.Check3)
            x7173.Check4 = trim$(x7173.Check4)
            x7173.Check5 = trim$(x7173.Check5)
            x7173.Check6 = trim$(x7173.Check6)
            x7173.Check7 = trim$(x7173.Check7)
            x7173.Check8 = trim$(x7173.Check8)
            x7173.Check9 = trim$(x7173.Check9)
            x7173.Check10 = trim$(x7173.Check10)
            x7173.CheckName1 = trim$(x7173.CheckName1)
            x7173.CheckName2 = trim$(x7173.CheckName2)
            x7173.CheckName3 = trim$(x7173.CheckName3)
            x7173.CheckName4 = trim$(x7173.CheckName4)
            x7173.CheckName5 = trim$(x7173.CheckName5)
            x7173.CheckName6 = trim$(x7173.CheckName6)
            x7173.CheckName7 = trim$(x7173.CheckName7)
            x7173.CheckName8 = trim$(x7173.CheckName8)
            x7173.CheckName9 = trim$(x7173.CheckName9)
            x7173.CheckName10 = trim$(x7173.CheckName10)
            x7173.Remark = trim$(x7173.Remark)
            x7173.UseCheck = trim$(x7173.UseCheck)
            x7173.DisplaySeq = trim$(x7173.DisplaySeq)

            If trim$(x7173.BankCode) = "" Then x7173.BankCode = Space(1)
            If trim$(x7173.AccountCode) = "" Then x7173.AccountCode = Space(1)
            If trim$(x7173.BasicName) = "" Then x7173.BasicName = Space(1)
            If trim$(x7173.ForeignName1) = "" Then x7173.ForeignName1 = Space(1)
            If trim$(x7173.ForeignName2) = "" Then x7173.ForeignName2 = Space(1)
            If trim$(x7173.NameSimply) = "" Then x7173.NameSimply = Space(1)
            If trim$(x7173.Check1) = "" Then x7173.Check1 = Space(1)
            If trim$(x7173.Check2) = "" Then x7173.Check2 = Space(1)
            If trim$(x7173.Check3) = "" Then x7173.Check3 = Space(1)
            If trim$(x7173.Check4) = "" Then x7173.Check4 = Space(1)
            If trim$(x7173.Check5) = "" Then x7173.Check5 = Space(1)
            If trim$(x7173.Check6) = "" Then x7173.Check6 = Space(1)
            If trim$(x7173.Check7) = "" Then x7173.Check7 = Space(1)
            If trim$(x7173.Check8) = "" Then x7173.Check8 = Space(1)
            If trim$(x7173.Check9) = "" Then x7173.Check9 = Space(1)
            If trim$(x7173.Check10) = "" Then x7173.Check10 = Space(1)
            If trim$(x7173.CheckName1) = "" Then x7173.CheckName1 = Space(1)
            If trim$(x7173.CheckName2) = "" Then x7173.CheckName2 = Space(1)
            If trim$(x7173.CheckName3) = "" Then x7173.CheckName3 = Space(1)
            If trim$(x7173.CheckName4) = "" Then x7173.CheckName4 = Space(1)
            If trim$(x7173.CheckName5) = "" Then x7173.CheckName5 = Space(1)
            If trim$(x7173.CheckName6) = "" Then x7173.CheckName6 = Space(1)
            If trim$(x7173.CheckName7) = "" Then x7173.CheckName7 = Space(1)
            If trim$(x7173.CheckName8) = "" Then x7173.CheckName8 = Space(1)
            If trim$(x7173.CheckName9) = "" Then x7173.CheckName9 = Space(1)
            If trim$(x7173.CheckName10) = "" Then x7173.CheckName10 = Space(1)
            If trim$(x7173.Remark) = "" Then x7173.Remark = Space(1)
            If trim$(x7173.UseCheck) = "" Then x7173.UseCheck = Space(1)
            If trim$(x7173.DisplaySeq) = "" Then x7173.DisplaySeq = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K7173_MOVE(rs7173 As SqlClient.SqlDataReader)
        Try

            Call D7173_CLEAR()

            If IsdbNull(rs7173!K7173_BankCode) = False Then D7173.BankCode = Trim$(rs7173!K7173_BankCode)
            If IsdbNull(rs7173!K7173_AccountCode) = False Then D7173.AccountCode = Trim$(rs7173!K7173_AccountCode)
            If IsdbNull(rs7173!K7173_BasicName) = False Then D7173.BasicName = Trim$(rs7173!K7173_BasicName)
            If IsdbNull(rs7173!K7173_ForeignName1) = False Then D7173.ForeignName1 = Trim$(rs7173!K7173_ForeignName1)
            If IsdbNull(rs7173!K7173_ForeignName2) = False Then D7173.ForeignName2 = Trim$(rs7173!K7173_ForeignName2)
            If IsdbNull(rs7173!K7173_NameSimply) = False Then D7173.NameSimply = Trim$(rs7173!K7173_NameSimply)
            If IsdbNull(rs7173!K7173_Check1) = False Then D7173.Check1 = Trim$(rs7173!K7173_Check1)
            If IsdbNull(rs7173!K7173_Check2) = False Then D7173.Check2 = Trim$(rs7173!K7173_Check2)
            If IsdbNull(rs7173!K7173_Check3) = False Then D7173.Check3 = Trim$(rs7173!K7173_Check3)
            If IsdbNull(rs7173!K7173_Check4) = False Then D7173.Check4 = Trim$(rs7173!K7173_Check4)
            If IsdbNull(rs7173!K7173_Check5) = False Then D7173.Check5 = Trim$(rs7173!K7173_Check5)
            If IsdbNull(rs7173!K7173_Check6) = False Then D7173.Check6 = Trim$(rs7173!K7173_Check6)
            If IsdbNull(rs7173!K7173_Check7) = False Then D7173.Check7 = Trim$(rs7173!K7173_Check7)
            If IsdbNull(rs7173!K7173_Check8) = False Then D7173.Check8 = Trim$(rs7173!K7173_Check8)
            If IsdbNull(rs7173!K7173_Check9) = False Then D7173.Check9 = Trim$(rs7173!K7173_Check9)
            If IsdbNull(rs7173!K7173_Check10) = False Then D7173.Check10 = Trim$(rs7173!K7173_Check10)
            If IsdbNull(rs7173!K7173_CheckName1) = False Then D7173.CheckName1 = Trim$(rs7173!K7173_CheckName1)
            If IsdbNull(rs7173!K7173_CheckName2) = False Then D7173.CheckName2 = Trim$(rs7173!K7173_CheckName2)
            If IsdbNull(rs7173!K7173_CheckName3) = False Then D7173.CheckName3 = Trim$(rs7173!K7173_CheckName3)
            If IsdbNull(rs7173!K7173_CheckName4) = False Then D7173.CheckName4 = Trim$(rs7173!K7173_CheckName4)
            If IsdbNull(rs7173!K7173_CheckName5) = False Then D7173.CheckName5 = Trim$(rs7173!K7173_CheckName5)
            If IsdbNull(rs7173!K7173_CheckName6) = False Then D7173.CheckName6 = Trim$(rs7173!K7173_CheckName6)
            If IsdbNull(rs7173!K7173_CheckName7) = False Then D7173.CheckName7 = Trim$(rs7173!K7173_CheckName7)
            If IsdbNull(rs7173!K7173_CheckName8) = False Then D7173.CheckName8 = Trim$(rs7173!K7173_CheckName8)
            If IsdbNull(rs7173!K7173_CheckName9) = False Then D7173.CheckName9 = Trim$(rs7173!K7173_CheckName9)
            If IsdbNull(rs7173!K7173_CheckName10) = False Then D7173.CheckName10 = Trim$(rs7173!K7173_CheckName10)
            If IsdbNull(rs7173!K7173_Remark) = False Then D7173.Remark = Trim$(rs7173!K7173_Remark)
            If IsdbNull(rs7173!K7173_UseCheck) = False Then D7173.UseCheck = Trim$(rs7173!K7173_UseCheck)
            If IsdbNull(rs7173!K7173_DisplaySeq) = False Then D7173.DisplaySeq = Trim$(rs7173!K7173_DisplaySeq)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7173_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K7173_MOVE(rs7173 As DataRow)
        Try

            Call D7173_CLEAR()

            If IsdbNull(rs7173!K7173_BankCode) = False Then D7173.BankCode = Trim$(rs7173!K7173_BankCode)
            If IsdbNull(rs7173!K7173_AccountCode) = False Then D7173.AccountCode = Trim$(rs7173!K7173_AccountCode)
            If IsdbNull(rs7173!K7173_BasicName) = False Then D7173.BasicName = Trim$(rs7173!K7173_BasicName)
            If IsdbNull(rs7173!K7173_ForeignName1) = False Then D7173.ForeignName1 = Trim$(rs7173!K7173_ForeignName1)
            If IsdbNull(rs7173!K7173_ForeignName2) = False Then D7173.ForeignName2 = Trim$(rs7173!K7173_ForeignName2)
            If IsdbNull(rs7173!K7173_NameSimply) = False Then D7173.NameSimply = Trim$(rs7173!K7173_NameSimply)
            If IsdbNull(rs7173!K7173_Check1) = False Then D7173.Check1 = Trim$(rs7173!K7173_Check1)
            If IsdbNull(rs7173!K7173_Check2) = False Then D7173.Check2 = Trim$(rs7173!K7173_Check2)
            If IsdbNull(rs7173!K7173_Check3) = False Then D7173.Check3 = Trim$(rs7173!K7173_Check3)
            If IsdbNull(rs7173!K7173_Check4) = False Then D7173.Check4 = Trim$(rs7173!K7173_Check4)
            If IsdbNull(rs7173!K7173_Check5) = False Then D7173.Check5 = Trim$(rs7173!K7173_Check5)
            If IsdbNull(rs7173!K7173_Check6) = False Then D7173.Check6 = Trim$(rs7173!K7173_Check6)
            If IsdbNull(rs7173!K7173_Check7) = False Then D7173.Check7 = Trim$(rs7173!K7173_Check7)
            If IsdbNull(rs7173!K7173_Check8) = False Then D7173.Check8 = Trim$(rs7173!K7173_Check8)
            If IsdbNull(rs7173!K7173_Check9) = False Then D7173.Check9 = Trim$(rs7173!K7173_Check9)
            If IsdbNull(rs7173!K7173_Check10) = False Then D7173.Check10 = Trim$(rs7173!K7173_Check10)
            If IsdbNull(rs7173!K7173_CheckName1) = False Then D7173.CheckName1 = Trim$(rs7173!K7173_CheckName1)
            If IsdbNull(rs7173!K7173_CheckName2) = False Then D7173.CheckName2 = Trim$(rs7173!K7173_CheckName2)
            If IsdbNull(rs7173!K7173_CheckName3) = False Then D7173.CheckName3 = Trim$(rs7173!K7173_CheckName3)
            If IsdbNull(rs7173!K7173_CheckName4) = False Then D7173.CheckName4 = Trim$(rs7173!K7173_CheckName4)
            If IsdbNull(rs7173!K7173_CheckName5) = False Then D7173.CheckName5 = Trim$(rs7173!K7173_CheckName5)
            If IsdbNull(rs7173!K7173_CheckName6) = False Then D7173.CheckName6 = Trim$(rs7173!K7173_CheckName6)
            If IsdbNull(rs7173!K7173_CheckName7) = False Then D7173.CheckName7 = Trim$(rs7173!K7173_CheckName7)
            If IsdbNull(rs7173!K7173_CheckName8) = False Then D7173.CheckName8 = Trim$(rs7173!K7173_CheckName8)
            If IsdbNull(rs7173!K7173_CheckName9) = False Then D7173.CheckName9 = Trim$(rs7173!K7173_CheckName9)
            If IsdbNull(rs7173!K7173_CheckName10) = False Then D7173.CheckName10 = Trim$(rs7173!K7173_CheckName10)
            If IsdbNull(rs7173!K7173_Remark) = False Then D7173.Remark = Trim$(rs7173!K7173_Remark)
            If IsdbNull(rs7173!K7173_UseCheck) = False Then D7173.UseCheck = Trim$(rs7173!K7173_UseCheck)
            If IsdbNull(rs7173!K7173_DisplaySeq) = False Then D7173.DisplaySeq = Trim$(rs7173!K7173_DisplaySeq)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7173_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K7173_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7173 As T7173_AREA, BANKCODE As String) As Boolean

        K7173_MOVE = False

        Try
            If READ_PFK7173(BANKCODE) = True Then
                z7173 = D7173
                K7173_MOVE = True
            Else
                z7173 = Nothing
            End If

            If getColumIndex(spr, "BankCode") > -1 Then z7173.BankCode = getDataM(spr, getColumIndex(spr, "BankCode"), xRow)
            If getColumIndex(spr, "AccountCode") > -1 Then z7173.AccountCode = getDataM(spr, getColumIndex(spr, "AccountCode"), xRow)
            If getColumIndex(spr, "BasicName") > -1 Then z7173.BasicName = getDataM(spr, getColumIndex(spr, "BasicName"), xRow)
            If getColumIndex(spr, "ForeignName1") > -1 Then z7173.ForeignName1 = getDataM(spr, getColumIndex(spr, "ForeignName1"), xRow)
            If getColumIndex(spr, "ForeignName2") > -1 Then z7173.ForeignName2 = getDataM(spr, getColumIndex(spr, "ForeignName2"), xRow)
            If getColumIndex(spr, "NameSimply") > -1 Then z7173.NameSimply = getDataM(spr, getColumIndex(spr, "NameSimply"), xRow)
            If getColumIndex(spr, "Check1") > -1 Then z7173.Check1 = getDataM(spr, getColumIndex(spr, "Check1"), xRow)
            If getColumIndex(spr, "Check2") > -1 Then z7173.Check2 = getDataM(spr, getColumIndex(spr, "Check2"), xRow)
            If getColumIndex(spr, "Check3") > -1 Then z7173.Check3 = getDataM(spr, getColumIndex(spr, "Check3"), xRow)
            If getColumIndex(spr, "Check4") > -1 Then z7173.Check4 = getDataM(spr, getColumIndex(spr, "Check4"), xRow)
            If getColumIndex(spr, "Check5") > -1 Then z7173.Check5 = getDataM(spr, getColumIndex(spr, "Check5"), xRow)
            If getColumIndex(spr, "Check6") > -1 Then z7173.Check6 = getDataM(spr, getColumIndex(spr, "Check6"), xRow)
            If getColumIndex(spr, "Check7") > -1 Then z7173.Check7 = getDataM(spr, getColumIndex(spr, "Check7"), xRow)
            If getColumIndex(spr, "Check8") > -1 Then z7173.Check8 = getDataM(spr, getColumIndex(spr, "Check8"), xRow)
            If getColumIndex(spr, "Check9") > -1 Then z7173.Check9 = getDataM(spr, getColumIndex(spr, "Check9"), xRow)
            If getColumIndex(spr, "Check10") > -1 Then z7173.Check10 = getDataM(spr, getColumIndex(spr, "Check10"), xRow)
            If getColumIndex(spr, "CheckName1") > -1 Then z7173.CheckName1 = getDataM(spr, getColumIndex(spr, "CheckName1"), xRow)
            If getColumIndex(spr, "CheckName2") > -1 Then z7173.CheckName2 = getDataM(spr, getColumIndex(spr, "CheckName2"), xRow)
            If getColumIndex(spr, "CheckName3") > -1 Then z7173.CheckName3 = getDataM(spr, getColumIndex(spr, "CheckName3"), xRow)
            If getColumIndex(spr, "CheckName4") > -1 Then z7173.CheckName4 = getDataM(spr, getColumIndex(spr, "CheckName4"), xRow)
            If getColumIndex(spr, "CheckName5") > -1 Then z7173.CheckName5 = getDataM(spr, getColumIndex(spr, "CheckName5"), xRow)
            If getColumIndex(spr, "CheckName6") > -1 Then z7173.CheckName6 = getDataM(spr, getColumIndex(spr, "CheckName6"), xRow)
            If getColumIndex(spr, "CheckName7") > -1 Then z7173.CheckName7 = getDataM(spr, getColumIndex(spr, "CheckName7"), xRow)
            If getColumIndex(spr, "CheckName8") > -1 Then z7173.CheckName8 = getDataM(spr, getColumIndex(spr, "CheckName8"), xRow)
            If getColumIndex(spr, "CheckName9") > -1 Then z7173.CheckName9 = getDataM(spr, getColumIndex(spr, "CheckName9"), xRow)
            If getColumIndex(spr, "CheckName10") > -1 Then z7173.CheckName10 = getDataM(spr, getColumIndex(spr, "CheckName10"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z7173.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)
            If getColumIndex(spr, "UseCheck") > -1 Then z7173.UseCheck = getDataM(spr, getColumIndex(spr, "UseCheck"), xRow)
            If getColumIndex(spr, "DisplaySeq") > -1 Then z7173.DisplaySeq = getDataM(spr, getColumIndex(spr, "DisplaySeq"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7173_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K7173_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7173 As T7173_AREA, CheckClear As Boolean, BANKCODE As String) As Boolean

        K7173_MOVE = False

        Try
            If READ_PFK7173(BANKCODE) = True Then
                z7173 = D7173
                K7173_MOVE = True
            Else
                If CheckClear = True Then z7173 = Nothing
            End If

            If getColumIndex(spr, "BankCode") > -1 Then z7173.BankCode = getDataM(spr, getColumIndex(spr, "BankCode"), xRow)
            If getColumIndex(spr, "AccountCode") > -1 Then z7173.AccountCode = getDataM(spr, getColumIndex(spr, "AccountCode"), xRow)
            If getColumIndex(spr, "BasicName") > -1 Then z7173.BasicName = getDataM(spr, getColumIndex(spr, "BasicName"), xRow)
            If getColumIndex(spr, "ForeignName1") > -1 Then z7173.ForeignName1 = getDataM(spr, getColumIndex(spr, "ForeignName1"), xRow)
            If getColumIndex(spr, "ForeignName2") > -1 Then z7173.ForeignName2 = getDataM(spr, getColumIndex(spr, "ForeignName2"), xRow)
            If getColumIndex(spr, "NameSimply") > -1 Then z7173.NameSimply = getDataM(spr, getColumIndex(spr, "NameSimply"), xRow)
            If getColumIndex(spr, "Check1") > -1 Then z7173.Check1 = getDataM(spr, getColumIndex(spr, "Check1"), xRow)
            If getColumIndex(spr, "Check2") > -1 Then z7173.Check2 = getDataM(spr, getColumIndex(spr, "Check2"), xRow)
            If getColumIndex(spr, "Check3") > -1 Then z7173.Check3 = getDataM(spr, getColumIndex(spr, "Check3"), xRow)
            If getColumIndex(spr, "Check4") > -1 Then z7173.Check4 = getDataM(spr, getColumIndex(spr, "Check4"), xRow)
            If getColumIndex(spr, "Check5") > -1 Then z7173.Check5 = getDataM(spr, getColumIndex(spr, "Check5"), xRow)
            If getColumIndex(spr, "Check6") > -1 Then z7173.Check6 = getDataM(spr, getColumIndex(spr, "Check6"), xRow)
            If getColumIndex(spr, "Check7") > -1 Then z7173.Check7 = getDataM(spr, getColumIndex(spr, "Check7"), xRow)
            If getColumIndex(spr, "Check8") > -1 Then z7173.Check8 = getDataM(spr, getColumIndex(spr, "Check8"), xRow)
            If getColumIndex(spr, "Check9") > -1 Then z7173.Check9 = getDataM(spr, getColumIndex(spr, "Check9"), xRow)
            If getColumIndex(spr, "Check10") > -1 Then z7173.Check10 = getDataM(spr, getColumIndex(spr, "Check10"), xRow)
            If getColumIndex(spr, "CheckName1") > -1 Then z7173.CheckName1 = getDataM(spr, getColumIndex(spr, "CheckName1"), xRow)
            If getColumIndex(spr, "CheckName2") > -1 Then z7173.CheckName2 = getDataM(spr, getColumIndex(spr, "CheckName2"), xRow)
            If getColumIndex(spr, "CheckName3") > -1 Then z7173.CheckName3 = getDataM(spr, getColumIndex(spr, "CheckName3"), xRow)
            If getColumIndex(spr, "CheckName4") > -1 Then z7173.CheckName4 = getDataM(spr, getColumIndex(spr, "CheckName4"), xRow)
            If getColumIndex(spr, "CheckName5") > -1 Then z7173.CheckName5 = getDataM(spr, getColumIndex(spr, "CheckName5"), xRow)
            If getColumIndex(spr, "CheckName6") > -1 Then z7173.CheckName6 = getDataM(spr, getColumIndex(spr, "CheckName6"), xRow)
            If getColumIndex(spr, "CheckName7") > -1 Then z7173.CheckName7 = getDataM(spr, getColumIndex(spr, "CheckName7"), xRow)
            If getColumIndex(spr, "CheckName8") > -1 Then z7173.CheckName8 = getDataM(spr, getColumIndex(spr, "CheckName8"), xRow)
            If getColumIndex(spr, "CheckName9") > -1 Then z7173.CheckName9 = getDataM(spr, getColumIndex(spr, "CheckName9"), xRow)
            If getColumIndex(spr, "CheckName10") > -1 Then z7173.CheckName10 = getDataM(spr, getColumIndex(spr, "CheckName10"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z7173.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)
            If getColumIndex(spr, "UseCheck") > -1 Then z7173.UseCheck = getDataM(spr, getColumIndex(spr, "UseCheck"), xRow)
            If getColumIndex(spr, "DisplaySeq") > -1 Then z7173.DisplaySeq = getDataM(spr, getColumIndex(spr, "DisplaySeq"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7173_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K7173_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7173 As T7173_AREA, Job As String, BANKCODE As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7173_MOVE = False

        Try
            If READ_PFK7173(BANKCODE) = True Then
                z7173 = D7173
                K7173_MOVE = True
            Else
                z7173 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7173")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "BANKCODE" : z7173.BankCode = Children(i).Code
                                Case "ACCOUNTCODE" : z7173.AccountCode = Children(i).Code
                                Case "BASICNAME" : z7173.BasicName = Children(i).Code
                                Case "FOREIGNNAME1" : z7173.ForeignName1 = Children(i).Code
                                Case "FOREIGNNAME2" : z7173.ForeignName2 = Children(i).Code
                                Case "NAMESIMPLY" : z7173.NameSimply = Children(i).Code
                                Case "CHECK1" : z7173.Check1 = Children(i).Code
                                Case "CHECK2" : z7173.Check2 = Children(i).Code
                                Case "CHECK3" : z7173.Check3 = Children(i).Code
                                Case "CHECK4" : z7173.Check4 = Children(i).Code
                                Case "CHECK5" : z7173.Check5 = Children(i).Code
                                Case "CHECK6" : z7173.Check6 = Children(i).Code
                                Case "CHECK7" : z7173.Check7 = Children(i).Code
                                Case "CHECK8" : z7173.Check8 = Children(i).Code
                                Case "CHECK9" : z7173.Check9 = Children(i).Code
                                Case "CHECK10" : z7173.Check10 = Children(i).Code
                                Case "CHECKNAME1" : z7173.CheckName1 = Children(i).Code
                                Case "CHECKNAME2" : z7173.CheckName2 = Children(i).Code
                                Case "CHECKNAME3" : z7173.CheckName3 = Children(i).Code
                                Case "CHECKNAME4" : z7173.CheckName4 = Children(i).Code
                                Case "CHECKNAME5" : z7173.CheckName5 = Children(i).Code
                                Case "CHECKNAME6" : z7173.CheckName6 = Children(i).Code
                                Case "CHECKNAME7" : z7173.CheckName7 = Children(i).Code
                                Case "CHECKNAME8" : z7173.CheckName8 = Children(i).Code
                                Case "CHECKNAME9" : z7173.CheckName9 = Children(i).Code
                                Case "CHECKNAME10" : z7173.CheckName10 = Children(i).Code
                                Case "REMARK" : z7173.Remark = Children(i).Code
                                Case "USECHECK" : z7173.UseCheck = Children(i).Code
                                Case "DISPLAYSEQ" : z7173.DisplaySeq = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "BANKCODE" : z7173.BankCode = Children(i).Data
                                Case "ACCOUNTCODE" : z7173.AccountCode = Children(i).Data
                                Case "BASICNAME" : z7173.BasicName = Children(i).Data
                                Case "FOREIGNNAME1" : z7173.ForeignName1 = Children(i).Data
                                Case "FOREIGNNAME2" : z7173.ForeignName2 = Children(i).Data
                                Case "NAMESIMPLY" : z7173.NameSimply = Children(i).Data
                                Case "CHECK1" : z7173.Check1 = Children(i).Data
                                Case "CHECK2" : z7173.Check2 = Children(i).Data
                                Case "CHECK3" : z7173.Check3 = Children(i).Data
                                Case "CHECK4" : z7173.Check4 = Children(i).Data
                                Case "CHECK5" : z7173.Check5 = Children(i).Data
                                Case "CHECK6" : z7173.Check6 = Children(i).Data
                                Case "CHECK7" : z7173.Check7 = Children(i).Data
                                Case "CHECK8" : z7173.Check8 = Children(i).Data
                                Case "CHECK9" : z7173.Check9 = Children(i).Data
                                Case "CHECK10" : z7173.Check10 = Children(i).Data
                                Case "CHECKNAME1" : z7173.CheckName1 = Children(i).Data
                                Case "CHECKNAME2" : z7173.CheckName2 = Children(i).Data
                                Case "CHECKNAME3" : z7173.CheckName3 = Children(i).Data
                                Case "CHECKNAME4" : z7173.CheckName4 = Children(i).Data
                                Case "CHECKNAME5" : z7173.CheckName5 = Children(i).Data
                                Case "CHECKNAME6" : z7173.CheckName6 = Children(i).Data
                                Case "CHECKNAME7" : z7173.CheckName7 = Children(i).Data
                                Case "CHECKNAME8" : z7173.CheckName8 = Children(i).Data
                                Case "CHECKNAME9" : z7173.CheckName9 = Children(i).Data
                                Case "CHECKNAME10" : z7173.CheckName10 = Children(i).Data
                                Case "REMARK" : z7173.Remark = Children(i).Data
                                Case "USECHECK" : z7173.UseCheck = Children(i).Data
                                Case "DISPLAYSEQ" : z7173.DisplaySeq = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7173_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K7173_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7173 As T7173_AREA, Job As String, CheckClear As Boolean, BANKCODE As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7173_MOVE = False

        Try
            If READ_PFK7173(BANKCODE) = True Then
                z7173 = D7173
                K7173_MOVE = True
            Else
                If CheckClear = True Then z7173 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7173")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "BANKCODE" : z7173.BankCode = Children(i).Code
                                Case "ACCOUNTCODE" : z7173.AccountCode = Children(i).Code
                                Case "BASICNAME" : z7173.BasicName = Children(i).Code
                                Case "FOREIGNNAME1" : z7173.ForeignName1 = Children(i).Code
                                Case "FOREIGNNAME2" : z7173.ForeignName2 = Children(i).Code
                                Case "NAMESIMPLY" : z7173.NameSimply = Children(i).Code
                                Case "CHECK1" : z7173.Check1 = Children(i).Code
                                Case "CHECK2" : z7173.Check2 = Children(i).Code
                                Case "CHECK3" : z7173.Check3 = Children(i).Code
                                Case "CHECK4" : z7173.Check4 = Children(i).Code
                                Case "CHECK5" : z7173.Check5 = Children(i).Code
                                Case "CHECK6" : z7173.Check6 = Children(i).Code
                                Case "CHECK7" : z7173.Check7 = Children(i).Code
                                Case "CHECK8" : z7173.Check8 = Children(i).Code
                                Case "CHECK9" : z7173.Check9 = Children(i).Code
                                Case "CHECK10" : z7173.Check10 = Children(i).Code
                                Case "CHECKNAME1" : z7173.CheckName1 = Children(i).Code
                                Case "CHECKNAME2" : z7173.CheckName2 = Children(i).Code
                                Case "CHECKNAME3" : z7173.CheckName3 = Children(i).Code
                                Case "CHECKNAME4" : z7173.CheckName4 = Children(i).Code
                                Case "CHECKNAME5" : z7173.CheckName5 = Children(i).Code
                                Case "CHECKNAME6" : z7173.CheckName6 = Children(i).Code
                                Case "CHECKNAME7" : z7173.CheckName7 = Children(i).Code
                                Case "CHECKNAME8" : z7173.CheckName8 = Children(i).Code
                                Case "CHECKNAME9" : z7173.CheckName9 = Children(i).Code
                                Case "CHECKNAME10" : z7173.CheckName10 = Children(i).Code
                                Case "REMARK" : z7173.Remark = Children(i).Code
                                Case "USECHECK" : z7173.UseCheck = Children(i).Code
                                Case "DISPLAYSEQ" : z7173.DisplaySeq = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "BANKCODE" : z7173.BankCode = Children(i).Data
                                Case "ACCOUNTCODE" : z7173.AccountCode = Children(i).Data
                                Case "BASICNAME" : z7173.BasicName = Children(i).Data
                                Case "FOREIGNNAME1" : z7173.ForeignName1 = Children(i).Data
                                Case "FOREIGNNAME2" : z7173.ForeignName2 = Children(i).Data
                                Case "NAMESIMPLY" : z7173.NameSimply = Children(i).Data
                                Case "CHECK1" : z7173.Check1 = Children(i).Data
                                Case "CHECK2" : z7173.Check2 = Children(i).Data
                                Case "CHECK3" : z7173.Check3 = Children(i).Data
                                Case "CHECK4" : z7173.Check4 = Children(i).Data
                                Case "CHECK5" : z7173.Check5 = Children(i).Data
                                Case "CHECK6" : z7173.Check6 = Children(i).Data
                                Case "CHECK7" : z7173.Check7 = Children(i).Data
                                Case "CHECK8" : z7173.Check8 = Children(i).Data
                                Case "CHECK9" : z7173.Check9 = Children(i).Data
                                Case "CHECK10" : z7173.Check10 = Children(i).Data
                                Case "CHECKNAME1" : z7173.CheckName1 = Children(i).Data
                                Case "CHECKNAME2" : z7173.CheckName2 = Children(i).Data
                                Case "CHECKNAME3" : z7173.CheckName3 = Children(i).Data
                                Case "CHECKNAME4" : z7173.CheckName4 = Children(i).Data
                                Case "CHECKNAME5" : z7173.CheckName5 = Children(i).Data
                                Case "CHECKNAME6" : z7173.CheckName6 = Children(i).Data
                                Case "CHECKNAME7" : z7173.CheckName7 = Children(i).Data
                                Case "CHECKNAME8" : z7173.CheckName8 = Children(i).Data
                                Case "CHECKNAME9" : z7173.CheckName9 = Children(i).Data
                                Case "CHECKNAME10" : z7173.CheckName10 = Children(i).Data
                                Case "REMARK" : z7173.Remark = Children(i).Data
                                Case "USECHECK" : z7173.UseCheck = Children(i).Data
                                Case "DISPLAYSEQ" : z7173.DisplaySeq = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7173_MOVE", vbCritical)
        End Try
    End Function

End Module
