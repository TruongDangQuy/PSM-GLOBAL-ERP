'=========================================================================================================================================================
'   TABLE : (PFK9912)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K9912

    Structure T9912_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public ProdjectName As String  '			nvarchar(10)		*
        Public ProgramNo As String  '			varchar(100)		*
        Public SheetName As String  '			varchar(10)		*
        Public ProgramSeq As Double  '			decimal		*
        Public ProgramDSeq As Double  '			decimal
        Public ItemCode As String  '			char(6)
        Public ItemNameSimply As String  '			nvarchar(50)
        Public ItemNameForeign1 As String  '			nvarchar(50)
        Public ItemNameForeign2 As String  '			nvarchar(50)
        Public DataType As String  '			nvarchar(50)
        Public DataSize As Double  '			decimal
        Public DataDecimal As Double  '			decimal
        Public TextAlign As String  '			nvarchar(10)
        Public HorizontalAlignment As String  '			nvarchar(20)
        Public VerticalAlignment As String  '			nvarchar(20)
        Public SizeWidth As Double  '			decimal
        Public SizeHeight As Double  '			decimal
        Public BackColot As String  '			nvarchar(50)
        Public ForeColor As String  '			nvarchar(50)
        Public FontName As String  '			nvarchar(100)
        Public FontSize As Double  '			decimal
        Public FontBold As String  '			nvarchar(10)
        Public CheckMerge As String  '			char(1)
        Public CheckMergePolicy As String  '			char(1)
        Public CheckHead As String  '			char(1)
        Public CheckHeadType As String  '			char(1)
        Public CheckDev As String  '			char(1)
        Public Lock As String  '			varchar(10)
        Public Hidden As String  '			varchar(10)
        Public REMK As String  '			nvarchar(100)
        '=========================================================================================================================================================
    End Structure

    Public D9912 As T9912_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK9912(PRODJECTNAME As String, PROGRAMNO As String, SHEETNAME As String) As Boolean
        READ_PFK9912 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9912 "
            SQL = SQL & " WHERE K9912_ProdjectName		 = '" & PRODJECTNAME & "' "
            SQL = SQL & "   AND K9912_ProgramNo		 = '" & PROGRAMNO & "' "
            SQL = SQL & "   AND K9912_SheetName		 = '" & SHEETNAME & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9912_CLEAR() : GoTo SKIP_READ_PFK9912

            Call K9912_MOVE(rd)
            READ_PFK9912 = True

SKIP_READ_PFK9912:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK9912", vbCritical)
        End Try
    End Function
    Public Function READ_PFK9912(PRODJECTNAME As String, PROGRAMNO As String, SHEETNAME As String, PROGRAMSEQ As Double) As Boolean
        READ_PFK9912 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9912 "
            SQL = SQL & " WHERE K9912_ProdjectName		 = '" & PRODJECTNAME & "' "
            SQL = SQL & "   AND K9912_ProgramNo		 = '" & PROGRAMNO & "' "
            SQL = SQL & "   AND K9912_SheetName		 = '" & SHEETNAME & "' "
            SQL = SQL & "   AND K9912_ProgramSeq		 =  " & PROGRAMSEQ & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9912_CLEAR() : GoTo SKIP_READ_PFK9912

            Call K9912_MOVE(rd)
            READ_PFK9912 = True

SKIP_READ_PFK9912:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK9912", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK9912(PRODJECTNAME As String, PROGRAMNO As String, SHEETNAME As String, PROGRAMSEQ As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9912 "
            SQL = SQL & " WHERE K9912_ProdjectName		 = '" & ProdjectName & "' "
            SQL = SQL & "   AND K9912_ProgramNo		 = '" & ProgramNo & "' "
            SQL = SQL & "   AND K9912_SheetName		 = '" & SheetName & "' "
            SQL = SQL & "   AND K9912_ProgramSeq		 =  " & ProgramSeq & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK9912", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK9912(z9912 As T9912_AREA) As Boolean
        WRITE_PFK9912 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z9912)

            SQL = " INSERT INTO PFK9912 "
            SQL = SQL & " ( "
            SQL = SQL & " K9912_ProdjectName,"
            SQL = SQL & " K9912_ProgramNo,"
            SQL = SQL & " K9912_SheetName,"
            SQL = SQL & " K9912_ProgramSeq,"
            SQL = SQL & " K9912_ProgramDSeq,"
            SQL = SQL & " K9912_ItemCode,"
            SQL = SQL & " K9912_ItemNameSimply,"
            SQL = SQL & " K9912_ItemNameForeign1,"
            SQL = SQL & " K9912_ItemNameForeign2,"
            SQL = SQL & " K9912_DataType,"
            SQL = SQL & " K9912_DataSize,"
            SQL = SQL & " K9912_DataDecimal,"
            SQL = SQL & " K9912_TextAlign,"
            SQL = SQL & " K9912_HorizontalAlignment,"
            SQL = SQL & " K9912_VerticalAlignment,"
            SQL = SQL & " K9912_SizeWidth,"
            SQL = SQL & " K9912_SizeHeight,"
            SQL = SQL & " K9912_BackColot,"
            SQL = SQL & " K9912_ForeColor,"
            SQL = SQL & " K9912_FontName,"
            SQL = SQL & " K9912_FontSize,"
            SQL = SQL & " K9912_FontBold,"
            SQL = SQL & " K9912_CheckMerge,"
            SQL = SQL & " K9912_CheckMergePolicy,"
            SQL = SQL & " K9912_CheckHead,"
            SQL = SQL & " K9912_CheckHeadType,"
            SQL = SQL & " K9912_CheckDev,"
            SQL = SQL & " K9912_Lock,"
            SQL = SQL & " K9912_Hidden,"
            SQL = SQL & " K9912_REMK "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z9912.ProdjectName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9912.ProgramNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9912.SheetName) & "', "
            SQL = SQL & "   " & FormatSQL(z9912.ProgramSeq) & ", "
            SQL = SQL & "   " & FormatSQL(z9912.ProgramDSeq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z9912.ItemCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9912.ItemNameSimply) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9912.ItemNameForeign1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9912.ItemNameForeign2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9912.DataType) & "', "
            SQL = SQL & "   " & FormatSQL(z9912.DataSize) & ", "
            SQL = SQL & "   " & FormatSQL(z9912.DataDecimal) & ", "
            SQL = SQL & "  N'" & FormatSQL(z9912.TextAlign) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9912.HorizontalAlignment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9912.VerticalAlignment) & "', "
            SQL = SQL & "   " & FormatSQL(z9912.SizeWidth) & ", "
            SQL = SQL & "   " & FormatSQL(z9912.SizeHeight) & ", "
            SQL = SQL & "  N'" & FormatSQL(z9912.BackColot) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9912.ForeColor) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9912.FontName) & "', "
            SQL = SQL & "   " & FormatSQL(z9912.FontSize) & ", "
            SQL = SQL & "  N'" & FormatSQL(z9912.FontBold) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9912.CheckMerge) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9912.CheckMergePolicy) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9912.CheckHead) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9912.CheckHeadType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9912.CheckDev) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9912.Lock) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9912.Hidden) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9912.REMK) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK9912 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK9912", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK9912(z9912 As T9912_AREA) As Boolean
        REWRITE_PFK9912 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z9912)

            SQL = " UPDATE PFK9912 SET "
            SQL = SQL & "    K9912_ProgramDSeq      =  " & FormatSQL(z9912.ProgramDSeq) & ", "
            SQL = SQL & "    K9912_ItemCode      = N'" & FormatSQL(z9912.ItemCode) & "', "
            SQL = SQL & "    K9912_ItemNameSimply      = N'" & FormatSQL(z9912.ItemNameSimply) & "', "
            SQL = SQL & "    K9912_ItemNameForeign1      = N'" & FormatSQL(z9912.ItemNameForeign1) & "', "
            SQL = SQL & "    K9912_ItemNameForeign2      = N'" & FormatSQL(z9912.ItemNameForeign2) & "', "
            SQL = SQL & "    K9912_DataType      = N'" & FormatSQL(z9912.DataType) & "', "
            SQL = SQL & "    K9912_DataSize      =  " & FormatSQL(z9912.DataSize) & ", "
            SQL = SQL & "    K9912_DataDecimal      =  " & FormatSQL(z9912.DataDecimal) & ", "
            SQL = SQL & "    K9912_TextAlign      = N'" & FormatSQL(z9912.TextAlign) & "', "
            SQL = SQL & "    K9912_HorizontalAlignment      = N'" & FormatSQL(z9912.HorizontalAlignment) & "', "
            SQL = SQL & "    K9912_VerticalAlignment      = N'" & FormatSQL(z9912.VerticalAlignment) & "', "
            SQL = SQL & "    K9912_SizeWidth      =  " & FormatSQL(z9912.SizeWidth) & ", "
            SQL = SQL & "    K9912_SizeHeight      =  " & FormatSQL(z9912.SizeHeight) & ", "
            SQL = SQL & "    K9912_BackColot      = N'" & FormatSQL(z9912.BackColot) & "', "
            SQL = SQL & "    K9912_ForeColor      = N'" & FormatSQL(z9912.ForeColor) & "', "
            SQL = SQL & "    K9912_FontName      = N'" & FormatSQL(z9912.FontName) & "', "
            SQL = SQL & "    K9912_FontSize      =  " & FormatSQL(z9912.FontSize) & ", "
            SQL = SQL & "    K9912_FontBold      = N'" & FormatSQL(z9912.FontBold) & "', "
            SQL = SQL & "    K9912_CheckMerge      = N'" & FormatSQL(z9912.CheckMerge) & "', "
            SQL = SQL & "    K9912_CheckMergePolicy      = N'" & FormatSQL(z9912.CheckMergePolicy) & "', "
            SQL = SQL & "    K9912_CheckHead      = N'" & FormatSQL(z9912.CheckHead) & "', "
            SQL = SQL & "    K9912_CheckHeadType      = N'" & FormatSQL(z9912.CheckHeadType) & "', "
            SQL = SQL & "    K9912_CheckDev      = N'" & FormatSQL(z9912.CheckDev) & "', "
            SQL = SQL & "    K9912_Lock      = N'" & FormatSQL(z9912.Lock) & "', "
            SQL = SQL & "    K9912_Hidden      = N'" & FormatSQL(z9912.Hidden) & "', "
            SQL = SQL & "    K9912_REMK      = N'" & FormatSQL(z9912.REMK) & "'  "
            SQL = SQL & " WHERE K9912_ProdjectName		 = '" & z9912.ProdjectName & "' "
            SQL = SQL & "   AND K9912_ProgramNo		 = '" & z9912.ProgramNo & "' "
            SQL = SQL & "   AND K9912_SheetName		 = '" & z9912.SheetName & "' "
            SQL = SQL & "   AND K9912_ProgramSeq		 =  " & z9912.ProgramSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK9912 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK9912", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK9912(z9912 As T9912_AREA) As Boolean
        DELETE_PFK9912 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK9912 "
            SQL = SQL & " WHERE K9912_ProdjectName		 = '" & z9912.ProdjectName & "' "
            SQL = SQL & "   AND K9912_ProgramNo		 = '" & z9912.ProgramNo & "' "
            SQL = SQL & "   AND K9912_SheetName		 = '" & z9912.SheetName & "' "
            SQL = SQL & "   AND K9912_ProgramSeq		 =  " & z9912.ProgramSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK9912 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK9912", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D9912_CLEAR()
        Try

            D9912.ProdjectName = ""
            D9912.ProgramNo = ""
            D9912.SheetName = ""
            D9912.ProgramSeq = 0
            D9912.ProgramDSeq = 0
            D9912.ItemCode = ""
            D9912.ItemNameSimply = ""
            D9912.ItemNameForeign1 = ""
            D9912.ItemNameForeign2 = ""
            D9912.DataType = ""
            D9912.DataSize = 0
            D9912.DataDecimal = 0
            D9912.TextAlign = ""
            D9912.HorizontalAlignment = ""
            D9912.VerticalAlignment = ""
            D9912.SizeWidth = 0
            D9912.SizeHeight = 0
            D9912.BackColot = ""
            D9912.ForeColor = ""
            D9912.FontName = ""
            D9912.FontSize = 0
            D9912.FontBold = ""
            D9912.CheckMerge = ""
            D9912.CheckMergePolicy = ""
            D9912.CheckHead = ""
            D9912.CheckHeadType = ""
            D9912.CheckDev = ""
            D9912.Lock = ""
            D9912.Hidden = ""
            D9912.REMK = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D9912_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x9912 As T9912_AREA)
        Try

            x9912.ProdjectName = trim$(x9912.ProdjectName)
            x9912.ProgramNo = trim$(x9912.ProgramNo)
            x9912.SheetName = trim$(x9912.SheetName)
            x9912.ProgramSeq = trim$(x9912.ProgramSeq)
            x9912.ProgramDSeq = trim$(x9912.ProgramDSeq)
            x9912.ItemCode = trim$(x9912.ItemCode)
            x9912.ItemNameSimply = trim$(x9912.ItemNameSimply)
            x9912.ItemNameForeign1 = trim$(x9912.ItemNameForeign1)
            x9912.ItemNameForeign2 = trim$(x9912.ItemNameForeign2)
            x9912.DataType = trim$(x9912.DataType)
            x9912.DataSize = trim$(x9912.DataSize)
            x9912.DataDecimal = trim$(x9912.DataDecimal)
            x9912.TextAlign = trim$(x9912.TextAlign)
            x9912.HorizontalAlignment = trim$(x9912.HorizontalAlignment)
            x9912.VerticalAlignment = trim$(x9912.VerticalAlignment)
            x9912.SizeWidth = trim$(x9912.SizeWidth)
            x9912.SizeHeight = trim$(x9912.SizeHeight)
            x9912.BackColot = trim$(x9912.BackColot)
            x9912.ForeColor = trim$(x9912.ForeColor)
            x9912.FontName = trim$(x9912.FontName)
            x9912.FontSize = trim$(x9912.FontSize)
            x9912.FontBold = trim$(x9912.FontBold)
            x9912.CheckMerge = trim$(x9912.CheckMerge)
            x9912.CheckMergePolicy = trim$(x9912.CheckMergePolicy)
            x9912.CheckHead = trim$(x9912.CheckHead)
            x9912.CheckHeadType = trim$(x9912.CheckHeadType)
            x9912.CheckDev = trim$(x9912.CheckDev)
            x9912.Lock = trim$(x9912.Lock)
            x9912.Hidden = trim$(x9912.Hidden)
            x9912.REMK = trim$(x9912.REMK)

            If trim$(x9912.ProdjectName) = "" Then x9912.ProdjectName = Space(1)
            If trim$(x9912.ProgramNo) = "" Then x9912.ProgramNo = Space(1)
            If trim$(x9912.SheetName) = "" Then x9912.SheetName = Space(1)
            If trim$(x9912.ProgramSeq) = "" Then x9912.ProgramSeq = 0
            If trim$(x9912.ProgramDSeq) = "" Then x9912.ProgramDSeq = 0
            If trim$(x9912.ItemCode) = "" Then x9912.ItemCode = Space(1)
            If trim$(x9912.ItemNameSimply) = "" Then x9912.ItemNameSimply = Space(1)
            If trim$(x9912.ItemNameForeign1) = "" Then x9912.ItemNameForeign1 = Space(1)
            If trim$(x9912.ItemNameForeign2) = "" Then x9912.ItemNameForeign2 = Space(1)
            If trim$(x9912.DataType) = "" Then x9912.DataType = Space(1)
            If trim$(x9912.DataSize) = "" Then x9912.DataSize = 0
            If trim$(x9912.DataDecimal) = "" Then x9912.DataDecimal = 0
            If trim$(x9912.TextAlign) = "" Then x9912.TextAlign = Space(1)
            If trim$(x9912.HorizontalAlignment) = "" Then x9912.HorizontalAlignment = Space(1)
            If trim$(x9912.VerticalAlignment) = "" Then x9912.VerticalAlignment = Space(1)
            If trim$(x9912.SizeWidth) = "" Then x9912.SizeWidth = 0
            If trim$(x9912.SizeHeight) = "" Then x9912.SizeHeight = 0
            If trim$(x9912.BackColot) = "" Then x9912.BackColot = Space(1)
            If trim$(x9912.ForeColor) = "" Then x9912.ForeColor = Space(1)
            If trim$(x9912.FontName) = "" Then x9912.FontName = Space(1)
            If trim$(x9912.FontSize) = "" Then x9912.FontSize = 0
            If trim$(x9912.FontBold) = "" Then x9912.FontBold = Space(1)
            If trim$(x9912.CheckMerge) = "" Then x9912.CheckMerge = Space(1)
            If trim$(x9912.CheckMergePolicy) = "" Then x9912.CheckMergePolicy = Space(1)
            If trim$(x9912.CheckHead) = "" Then x9912.CheckHead = Space(1)
            If trim$(x9912.CheckHeadType) = "" Then x9912.CheckHeadType = Space(1)
            If trim$(x9912.CheckDev) = "" Then x9912.CheckDev = Space(1)
            If trim$(x9912.Lock) = "" Then x9912.Lock = Space(1)
            If trim$(x9912.Hidden) = "" Then x9912.Hidden = Space(1)
            If trim$(x9912.REMK) = "" Then x9912.REMK = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K9912_MOVE(rs9912 As SqlClient.SqlDataReader)
        Try

            Call D9912_CLEAR()

            If IsdbNull(rs9912!K9912_ProdjectName) = False Then D9912.ProdjectName = Trim$(rs9912!K9912_ProdjectName)
            If IsdbNull(rs9912!K9912_ProgramNo) = False Then D9912.ProgramNo = Trim$(rs9912!K9912_ProgramNo)
            If IsdbNull(rs9912!K9912_SheetName) = False Then D9912.SheetName = Trim$(rs9912!K9912_SheetName)
            If IsdbNull(rs9912!K9912_ProgramSeq) = False Then D9912.ProgramSeq = Trim$(rs9912!K9912_ProgramSeq)
            If IsdbNull(rs9912!K9912_ProgramDSeq) = False Then D9912.ProgramDSeq = Trim$(rs9912!K9912_ProgramDSeq)
            If IsdbNull(rs9912!K9912_ItemCode) = False Then D9912.ItemCode = Trim$(rs9912!K9912_ItemCode)
            If IsdbNull(rs9912!K9912_ItemNameSimply) = False Then D9912.ItemNameSimply = Trim$(rs9912!K9912_ItemNameSimply)
            If IsdbNull(rs9912!K9912_ItemNameForeign1) = False Then D9912.ItemNameForeign1 = Trim$(rs9912!K9912_ItemNameForeign1)
            If IsdbNull(rs9912!K9912_ItemNameForeign2) = False Then D9912.ItemNameForeign2 = Trim$(rs9912!K9912_ItemNameForeign2)
            If IsdbNull(rs9912!K9912_DataType) = False Then D9912.DataType = Trim$(rs9912!K9912_DataType)
            If IsdbNull(rs9912!K9912_DataSize) = False Then D9912.DataSize = Trim$(rs9912!K9912_DataSize)
            If IsdbNull(rs9912!K9912_DataDecimal) = False Then D9912.DataDecimal = Trim$(rs9912!K9912_DataDecimal)
            If IsdbNull(rs9912!K9912_TextAlign) = False Then D9912.TextAlign = Trim$(rs9912!K9912_TextAlign)
            If IsdbNull(rs9912!K9912_HorizontalAlignment) = False Then D9912.HorizontalAlignment = Trim$(rs9912!K9912_HorizontalAlignment)
            If IsdbNull(rs9912!K9912_VerticalAlignment) = False Then D9912.VerticalAlignment = Trim$(rs9912!K9912_VerticalAlignment)
            If IsdbNull(rs9912!K9912_SizeWidth) = False Then D9912.SizeWidth = Trim$(rs9912!K9912_SizeWidth)
            If IsdbNull(rs9912!K9912_SizeHeight) = False Then D9912.SizeHeight = Trim$(rs9912!K9912_SizeHeight)
            If IsdbNull(rs9912!K9912_BackColot) = False Then D9912.BackColot = Trim$(rs9912!K9912_BackColot)
            If IsdbNull(rs9912!K9912_ForeColor) = False Then D9912.ForeColor = Trim$(rs9912!K9912_ForeColor)
            If IsdbNull(rs9912!K9912_FontName) = False Then D9912.FontName = Trim$(rs9912!K9912_FontName)
            If IsdbNull(rs9912!K9912_FontSize) = False Then D9912.FontSize = Trim$(rs9912!K9912_FontSize)
            If IsdbNull(rs9912!K9912_FontBold) = False Then D9912.FontBold = Trim$(rs9912!K9912_FontBold)
            If IsdbNull(rs9912!K9912_CheckMerge) = False Then D9912.CheckMerge = Trim$(rs9912!K9912_CheckMerge)
            If IsdbNull(rs9912!K9912_CheckMergePolicy) = False Then D9912.CheckMergePolicy = Trim$(rs9912!K9912_CheckMergePolicy)
            If IsdbNull(rs9912!K9912_CheckHead) = False Then D9912.CheckHead = Trim$(rs9912!K9912_CheckHead)
            If IsdbNull(rs9912!K9912_CheckHeadType) = False Then D9912.CheckHeadType = Trim$(rs9912!K9912_CheckHeadType)
            If IsdbNull(rs9912!K9912_CheckDev) = False Then D9912.CheckDev = Trim$(rs9912!K9912_CheckDev)
            If IsdbNull(rs9912!K9912_Lock) = False Then D9912.Lock = Trim$(rs9912!K9912_Lock)
            If IsdbNull(rs9912!K9912_Hidden) = False Then D9912.Hidden = Trim$(rs9912!K9912_Hidden)
            If IsdbNull(rs9912!K9912_REMK) = False Then D9912.REMK = Trim$(rs9912!K9912_REMK)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K9912_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K9912_MOVE(rs9912 As DataRow)
        Try

            Call D9912_CLEAR()

            If IsdbNull(rs9912!K9912_ProdjectName) = False Then D9912.ProdjectName = Trim$(rs9912!K9912_ProdjectName)
            If IsdbNull(rs9912!K9912_ProgramNo) = False Then D9912.ProgramNo = Trim$(rs9912!K9912_ProgramNo)
            If IsdbNull(rs9912!K9912_SheetName) = False Then D9912.SheetName = Trim$(rs9912!K9912_SheetName)
            If IsdbNull(rs9912!K9912_ProgramSeq) = False Then D9912.ProgramSeq = Trim$(rs9912!K9912_ProgramSeq)
            If IsdbNull(rs9912!K9912_ProgramDSeq) = False Then D9912.ProgramDSeq = Trim$(rs9912!K9912_ProgramDSeq)
            If IsdbNull(rs9912!K9912_ItemCode) = False Then D9912.ItemCode = Trim$(rs9912!K9912_ItemCode)
            If IsdbNull(rs9912!K9912_ItemNameSimply) = False Then D9912.ItemNameSimply = Trim$(rs9912!K9912_ItemNameSimply)
            If IsdbNull(rs9912!K9912_ItemNameForeign1) = False Then D9912.ItemNameForeign1 = Trim$(rs9912!K9912_ItemNameForeign1)
            If IsdbNull(rs9912!K9912_ItemNameForeign2) = False Then D9912.ItemNameForeign2 = Trim$(rs9912!K9912_ItemNameForeign2)
            If IsdbNull(rs9912!K9912_DataType) = False Then D9912.DataType = Trim$(rs9912!K9912_DataType)
            If IsdbNull(rs9912!K9912_DataSize) = False Then D9912.DataSize = Trim$(rs9912!K9912_DataSize)
            If IsdbNull(rs9912!K9912_DataDecimal) = False Then D9912.DataDecimal = Trim$(rs9912!K9912_DataDecimal)
            If IsdbNull(rs9912!K9912_TextAlign) = False Then D9912.TextAlign = Trim$(rs9912!K9912_TextAlign)
            If IsdbNull(rs9912!K9912_HorizontalAlignment) = False Then D9912.HorizontalAlignment = Trim$(rs9912!K9912_HorizontalAlignment)
            If IsdbNull(rs9912!K9912_VerticalAlignment) = False Then D9912.VerticalAlignment = Trim$(rs9912!K9912_VerticalAlignment)
            If IsdbNull(rs9912!K9912_SizeWidth) = False Then D9912.SizeWidth = Trim$(rs9912!K9912_SizeWidth)
            If IsdbNull(rs9912!K9912_SizeHeight) = False Then D9912.SizeHeight = Trim$(rs9912!K9912_SizeHeight)
            If IsdbNull(rs9912!K9912_BackColot) = False Then D9912.BackColot = Trim$(rs9912!K9912_BackColot)
            If IsdbNull(rs9912!K9912_ForeColor) = False Then D9912.ForeColor = Trim$(rs9912!K9912_ForeColor)
            If IsdbNull(rs9912!K9912_FontName) = False Then D9912.FontName = Trim$(rs9912!K9912_FontName)
            If IsdbNull(rs9912!K9912_FontSize) = False Then D9912.FontSize = Trim$(rs9912!K9912_FontSize)
            If IsdbNull(rs9912!K9912_FontBold) = False Then D9912.FontBold = Trim$(rs9912!K9912_FontBold)
            If IsdbNull(rs9912!K9912_CheckMerge) = False Then D9912.CheckMerge = Trim$(rs9912!K9912_CheckMerge)
            If IsdbNull(rs9912!K9912_CheckMergePolicy) = False Then D9912.CheckMergePolicy = Trim$(rs9912!K9912_CheckMergePolicy)
            If IsdbNull(rs9912!K9912_CheckHead) = False Then D9912.CheckHead = Trim$(rs9912!K9912_CheckHead)
            If IsdbNull(rs9912!K9912_CheckHeadType) = False Then D9912.CheckHeadType = Trim$(rs9912!K9912_CheckHeadType)
            If IsdbNull(rs9912!K9912_CheckDev) = False Then D9912.CheckDev = Trim$(rs9912!K9912_CheckDev)
            If IsdbNull(rs9912!K9912_Lock) = False Then D9912.Lock = Trim$(rs9912!K9912_Lock)
            If IsdbNull(rs9912!K9912_Hidden) = False Then D9912.Hidden = Trim$(rs9912!K9912_Hidden)
            If IsdbNull(rs9912!K9912_REMK) = False Then D9912.REMK = Trim$(rs9912!K9912_REMK)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K9912_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K9912_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z9912 As T9912_AREA, PRODJECTNAME As String, PROGRAMNO As String, SHEETNAME As String, PROGRAMSEQ As Double) As Boolean

        K9912_MOVE = False

        Try
            If READ_PFK9912(PRODJECTNAME, PROGRAMNO, SHEETNAME, PROGRAMSEQ) = True Then
                z9912 = D9912
                K9912_MOVE = True
            Else
                z9912 = Nothing
            End If

            If getColumIndex(spr, "ProdjectName") > -1 Then z9912.ProdjectName = getDataM(spr, getColumIndex(spr, "ProdjectName"), xRow)
            If getColumIndex(spr, "ProgramNo") > -1 Then z9912.ProgramNo = getDataM(spr, getColumIndex(spr, "ProgramNo"), xRow)
            If getColumIndex(spr, "SheetName") > -1 Then z9912.SheetName = getDataM(spr, getColumIndex(spr, "SheetName"), xRow)
            If getColumIndex(spr, "ProgramSeq") > -1 Then z9912.ProgramSeq = getDataM(spr, getColumIndex(spr, "ProgramSeq"), xRow)
            If getColumIndex(spr, "ProgramDSeq") > -1 Then z9912.ProgramDSeq = getDataM(spr, getColumIndex(spr, "ProgramDSeq"), xRow)
            If getColumIndex(spr, "ItemCode") > -1 Then z9912.ItemCode = getDataM(spr, getColumIndex(spr, "ItemCode"), xRow)
            If getColumIndex(spr, "ItemNameSimply") > -1 Then z9912.ItemNameSimply = getDataM(spr, getColumIndex(spr, "ItemNameSimply"), xRow)
            If getColumIndex(spr, "ItemNameForeign1") > -1 Then z9912.ItemNameForeign1 = getDataM(spr, getColumIndex(spr, "ItemNameForeign1"), xRow)
            If getColumIndex(spr, "ItemNameForeign2") > -1 Then z9912.ItemNameForeign2 = getDataM(spr, getColumIndex(spr, "ItemNameForeign2"), xRow)
            If getColumIndex(spr, "DataType") > -1 Then z9912.DataType = getDataM(spr, getColumIndex(spr, "DataType"), xRow)
            If getColumIndex(spr, "DataSize") > -1 Then z9912.DataSize = getDataM(spr, getColumIndex(spr, "DataSize"), xRow)
            If getColumIndex(spr, "DataDecimal") > -1 Then z9912.DataDecimal = getDataM(spr, getColumIndex(spr, "DataDecimal"), xRow)
            If getColumIndex(spr, "TextAlign") > -1 Then z9912.TextAlign = getDataM(spr, getColumIndex(spr, "TextAlign"), xRow)
            If getColumIndex(spr, "HorizontalAlignment") > -1 Then z9912.HorizontalAlignment = getDataM(spr, getColumIndex(spr, "HorizontalAlignment"), xRow)
            If getColumIndex(spr, "VerticalAlignment") > -1 Then z9912.VerticalAlignment = getDataM(spr, getColumIndex(spr, "VerticalAlignment"), xRow)
            If getColumIndex(spr, "SizeWidth") > -1 Then z9912.SizeWidth = getDataM(spr, getColumIndex(spr, "SizeWidth"), xRow)
            If getColumIndex(spr, "SizeHeight") > -1 Then z9912.SizeHeight = getDataM(spr, getColumIndex(spr, "SizeHeight"), xRow)
            If getColumIndex(spr, "BackColot") > -1 Then z9912.BackColot = getDataM(spr, getColumIndex(spr, "BackColot"), xRow)
            If getColumIndex(spr, "ForeColor") > -1 Then z9912.ForeColor = getDataM(spr, getColumIndex(spr, "ForeColor"), xRow)
            If getColumIndex(spr, "FontName") > -1 Then z9912.FontName = getDataM(spr, getColumIndex(spr, "FontName"), xRow)
            If getColumIndex(spr, "FontSize") > -1 Then z9912.FontSize = getDataM(spr, getColumIndex(spr, "FontSize"), xRow)
            If getColumIndex(spr, "FontBold") > -1 Then z9912.FontBold = getDataM(spr, getColumIndex(spr, "FontBold"), xRow)
            If getColumIndex(spr, "CheckMerge") > -1 Then z9912.CheckMerge = getDataM(spr, getColumIndex(spr, "CheckMerge"), xRow)
            If getColumIndex(spr, "CheckMergePolicy") > -1 Then z9912.CheckMergePolicy = getDataM(spr, getColumIndex(spr, "CheckMergePolicy"), xRow)
            If getColumIndex(spr, "CheckHead") > -1 Then z9912.CheckHead = getDataM(spr, getColumIndex(spr, "CheckHead"), xRow)
            If getColumIndex(spr, "CheckHeadType") > -1 Then z9912.CheckHeadType = getDataM(spr, getColumIndex(spr, "CheckHeadType"), xRow)
            If getColumIndex(spr, "CheckDev") > -1 Then z9912.CheckDev = getDataM(spr, getColumIndex(spr, "CheckDev"), xRow)
            If getColumIndex(spr, "Lock") > -1 Then z9912.Lock = getDataM(spr, getColumIndex(spr, "Lock"), xRow)
            If getColumIndex(spr, "Hidden") > -1 Then z9912.Hidden = getDataM(spr, getColumIndex(spr, "Hidden"), xRow)
            If getColumIndex(spr, "REMK") > -1 Then z9912.REMK = getDataM(spr, getColumIndex(spr, "REMK"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9912_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K9912_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z9912 As T9912_AREA, CheckClear As Boolean, PRODJECTNAME As String, PROGRAMNO As String, SHEETNAME As String, PROGRAMSEQ As Double) As Boolean

        K9912_MOVE = False

        Try
            If READ_PFK9912(PRODJECTNAME, PROGRAMNO, SHEETNAME, PROGRAMSEQ) = True Then
                z9912 = D9912
                K9912_MOVE = True
            Else
                If CheckClear = True Then z9912 = Nothing
            End If

            If getColumIndex(spr, "ProdjectName") > -1 Then z9912.ProdjectName = getDataM(spr, getColumIndex(spr, "ProdjectName"), xRow)
            If getColumIndex(spr, "ProgramNo") > -1 Then z9912.ProgramNo = getDataM(spr, getColumIndex(spr, "ProgramNo"), xRow)
            If getColumIndex(spr, "SheetName") > -1 Then z9912.SheetName = getDataM(spr, getColumIndex(spr, "SheetName"), xRow)
            If getColumIndex(spr, "ProgramSeq") > -1 Then z9912.ProgramSeq = getDataM(spr, getColumIndex(spr, "ProgramSeq"), xRow)
            If getColumIndex(spr, "ProgramDSeq") > -1 Then z9912.ProgramDSeq = getDataM(spr, getColumIndex(spr, "ProgramDSeq"), xRow)
            If getColumIndex(spr, "ItemCode") > -1 Then z9912.ItemCode = getDataM(spr, getColumIndex(spr, "ItemCode"), xRow)
            If getColumIndex(spr, "ItemNameSimply") > -1 Then z9912.ItemNameSimply = getDataM(spr, getColumIndex(spr, "ItemNameSimply"), xRow)
            If getColumIndex(spr, "ItemNameForeign1") > -1 Then z9912.ItemNameForeign1 = getDataM(spr, getColumIndex(spr, "ItemNameForeign1"), xRow)
            If getColumIndex(spr, "ItemNameForeign2") > -1 Then z9912.ItemNameForeign2 = getDataM(spr, getColumIndex(spr, "ItemNameForeign2"), xRow)
            If getColumIndex(spr, "DataType") > -1 Then z9912.DataType = getDataM(spr, getColumIndex(spr, "DataType"), xRow)
            If getColumIndex(spr, "DataSize") > -1 Then z9912.DataSize = getDataM(spr, getColumIndex(spr, "DataSize"), xRow)
            If getColumIndex(spr, "DataDecimal") > -1 Then z9912.DataDecimal = getDataM(spr, getColumIndex(spr, "DataDecimal"), xRow)
            If getColumIndex(spr, "TextAlign") > -1 Then z9912.TextAlign = getDataM(spr, getColumIndex(spr, "TextAlign"), xRow)
            If getColumIndex(spr, "HorizontalAlignment") > -1 Then z9912.HorizontalAlignment = getDataM(spr, getColumIndex(spr, "HorizontalAlignment"), xRow)
            If getColumIndex(spr, "VerticalAlignment") > -1 Then z9912.VerticalAlignment = getDataM(spr, getColumIndex(spr, "VerticalAlignment"), xRow)
            If getColumIndex(spr, "SizeWidth") > -1 Then z9912.SizeWidth = getDataM(spr, getColumIndex(spr, "SizeWidth"), xRow)
            If getColumIndex(spr, "SizeHeight") > -1 Then z9912.SizeHeight = getDataM(spr, getColumIndex(spr, "SizeHeight"), xRow)
            If getColumIndex(spr, "BackColot") > -1 Then z9912.BackColot = getDataM(spr, getColumIndex(spr, "BackColot"), xRow)
            If getColumIndex(spr, "ForeColor") > -1 Then z9912.ForeColor = getDataM(spr, getColumIndex(spr, "ForeColor"), xRow)
            If getColumIndex(spr, "FontName") > -1 Then z9912.FontName = getDataM(spr, getColumIndex(spr, "FontName"), xRow)
            If getColumIndex(spr, "FontSize") > -1 Then z9912.FontSize = getDataM(spr, getColumIndex(spr, "FontSize"), xRow)
            If getColumIndex(spr, "FontBold") > -1 Then z9912.FontBold = getDataM(spr, getColumIndex(spr, "FontBold"), xRow)
            If getColumIndex(spr, "CheckMerge") > -1 Then z9912.CheckMerge = getDataM(spr, getColumIndex(spr, "CheckMerge"), xRow)
            If getColumIndex(spr, "CheckMergePolicy") > -1 Then z9912.CheckMergePolicy = getDataM(spr, getColumIndex(spr, "CheckMergePolicy"), xRow)
            If getColumIndex(spr, "CheckHead") > -1 Then z9912.CheckHead = getDataM(spr, getColumIndex(spr, "CheckHead"), xRow)
            If getColumIndex(spr, "CheckHeadType") > -1 Then z9912.CheckHeadType = getDataM(spr, getColumIndex(spr, "CheckHeadType"), xRow)
            If getColumIndex(spr, "CheckDev") > -1 Then z9912.CheckDev = getDataM(spr, getColumIndex(spr, "CheckDev"), xRow)
            If getColumIndex(spr, "Lock") > -1 Then z9912.Lock = getDataM(spr, getColumIndex(spr, "Lock"), xRow)
            If getColumIndex(spr, "Hidden") > -1 Then z9912.Hidden = getDataM(spr, getColumIndex(spr, "Hidden"), xRow)
            If getColumIndex(spr, "REMK") > -1 Then z9912.REMK = getDataM(spr, getColumIndex(spr, "REMK"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9912_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K9912_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z9912 As T9912_AREA, Job As String, PRODJECTNAME As String, PROGRAMNO As String, SHEETNAME As String, PROGRAMSEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K9912_MOVE = False

        Try
            If READ_PFK9912(PRODJECTNAME, PROGRAMNO, SHEETNAME, PROGRAMSEQ) = True Then
                z9912 = D9912
                K9912_MOVE = True
            Else
                z9912 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9912")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "PRODJECTNAME" : z9912.ProdjectName = Children(i).Code
                                Case "PROGRAMNO" : z9912.ProgramNo = Children(i).Code
                                Case "SHEETNAME" : z9912.SheetName = Children(i).Code
                                Case "PROGRAMSEQ" : z9912.ProgramSeq = Children(i).Code
                                Case "PROGRAMDSEQ" : z9912.ProgramDSeq = Children(i).Code
                                Case "ITEMCODE" : z9912.ItemCode = Children(i).Code
                                Case "ITEMNAMESIMPLY" : z9912.ItemNameSimply = Children(i).Code
                                Case "ITEMNAMEFOREIGN1" : z9912.ItemNameForeign1 = Children(i).Code
                                Case "ITEMNAMEFOREIGN2" : z9912.ItemNameForeign2 = Children(i).Code
                                Case "DATATYPE" : z9912.DataType = Children(i).Code
                                Case "DATASIZE" : z9912.DataSize = Children(i).Code
                                Case "DATADECIMAL" : z9912.DataDecimal = Children(i).Code
                                Case "TEXTALIGN" : z9912.TextAlign = Children(i).Code
                                Case "HORIZONTALALIGNMENT" : z9912.HorizontalAlignment = Children(i).Code
                                Case "VERTICALALIGNMENT" : z9912.VerticalAlignment = Children(i).Code
                                Case "SIZEWIDTH" : z9912.SizeWidth = Children(i).Code
                                Case "SIZEHEIGHT" : z9912.SizeHeight = Children(i).Code
                                Case "BACKCOLOT" : z9912.BackColot = Children(i).Code
                                Case "FORECOLOR" : z9912.ForeColor = Children(i).Code
                                Case "FONTNAME" : z9912.FontName = Children(i).Code
                                Case "FONTSIZE" : z9912.FontSize = Children(i).Code
                                Case "FONTBOLD" : z9912.FontBold = Children(i).Code
                                Case "CHECKMERGE" : z9912.CheckMerge = Children(i).Code
                                Case "CHECKMERGEPOLICY" : z9912.CheckMergePolicy = Children(i).Code
                                Case "CHECKHEAD" : z9912.CheckHead = Children(i).Code
                                Case "CHECKHEADTYPE" : z9912.CheckHeadType = Children(i).Code
                                Case "CHECKDEV" : z9912.CheckDev = Children(i).Code
                                Case "LOCK" : z9912.Lock = Children(i).Code
                                Case "HIDDEN" : z9912.Hidden = Children(i).Code
                                Case "REMK" : z9912.REMK = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "PRODJECTNAME" : z9912.ProdjectName = Children(i).Data
                                Case "PROGRAMNO" : z9912.ProgramNo = Children(i).Data
                                Case "SHEETNAME" : z9912.SheetName = Children(i).Data
                                Case "PROGRAMSEQ" : z9912.ProgramSeq = Children(i).Data
                                Case "PROGRAMDSEQ" : z9912.ProgramDSeq = Children(i).Data
                                Case "ITEMCODE" : z9912.ItemCode = Children(i).Data
                                Case "ITEMNAMESIMPLY" : z9912.ItemNameSimply = Children(i).Data
                                Case "ITEMNAMEFOREIGN1" : z9912.ItemNameForeign1 = Children(i).Data
                                Case "ITEMNAMEFOREIGN2" : z9912.ItemNameForeign2 = Children(i).Data
                                Case "DATATYPE" : z9912.DataType = Children(i).Data
                                Case "DATASIZE" : z9912.DataSize = Children(i).Data
                                Case "DATADECIMAL" : z9912.DataDecimal = Children(i).Data
                                Case "TEXTALIGN" : z9912.TextAlign = Children(i).Data
                                Case "HORIZONTALALIGNMENT" : z9912.HorizontalAlignment = Children(i).Data
                                Case "VERTICALALIGNMENT" : z9912.VerticalAlignment = Children(i).Data
                                Case "SIZEWIDTH" : z9912.SizeWidth = Children(i).Data
                                Case "SIZEHEIGHT" : z9912.SizeHeight = Children(i).Data
                                Case "BACKCOLOT" : z9912.BackColot = Children(i).Data
                                Case "FORECOLOR" : z9912.ForeColor = Children(i).Data
                                Case "FONTNAME" : z9912.FontName = Children(i).Data
                                Case "FONTSIZE" : z9912.FontSize = Children(i).Data
                                Case "FONTBOLD" : z9912.FontBold = Children(i).Data
                                Case "CHECKMERGE" : z9912.CheckMerge = Children(i).Data
                                Case "CHECKMERGEPOLICY" : z9912.CheckMergePolicy = Children(i).Data
                                Case "CHECKHEAD" : z9912.CheckHead = Children(i).Data
                                Case "CHECKHEADTYPE" : z9912.CheckHeadType = Children(i).Data
                                Case "CHECKDEV" : z9912.CheckDev = Children(i).Data
                                Case "LOCK" : z9912.Lock = Children(i).Data
                                Case "HIDDEN" : z9912.Hidden = Children(i).Data
                                Case "REMK" : z9912.REMK = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9912_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K9912_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z9912 As T9912_AREA, Job As String, CheckClear As Boolean, PRODJECTNAME As String, PROGRAMNO As String, SHEETNAME As String, PROGRAMSEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K9912_MOVE = False

        Try
            If READ_PFK9912(PRODJECTNAME, PROGRAMNO, SHEETNAME, PROGRAMSEQ) = True Then
                z9912 = D9912
                K9912_MOVE = True
            Else
                If CheckClear = True Then z9912 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9912")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "PRODJECTNAME" : z9912.ProdjectName = Children(i).Code
                                Case "PROGRAMNO" : z9912.ProgramNo = Children(i).Code
                                Case "SHEETNAME" : z9912.SheetName = Children(i).Code
                                Case "PROGRAMSEQ" : z9912.ProgramSeq = Children(i).Code
                                Case "PROGRAMDSEQ" : z9912.ProgramDSeq = Children(i).Code
                                Case "ITEMCODE" : z9912.ItemCode = Children(i).Code
                                Case "ITEMNAMESIMPLY" : z9912.ItemNameSimply = Children(i).Code
                                Case "ITEMNAMEFOREIGN1" : z9912.ItemNameForeign1 = Children(i).Code
                                Case "ITEMNAMEFOREIGN2" : z9912.ItemNameForeign2 = Children(i).Code
                                Case "DATATYPE" : z9912.DataType = Children(i).Code
                                Case "DATASIZE" : z9912.DataSize = Children(i).Code
                                Case "DATADECIMAL" : z9912.DataDecimal = Children(i).Code
                                Case "TEXTALIGN" : z9912.TextAlign = Children(i).Code
                                Case "HORIZONTALALIGNMENT" : z9912.HorizontalAlignment = Children(i).Code
                                Case "VERTICALALIGNMENT" : z9912.VerticalAlignment = Children(i).Code
                                Case "SIZEWIDTH" : z9912.SizeWidth = Children(i).Code
                                Case "SIZEHEIGHT" : z9912.SizeHeight = Children(i).Code
                                Case "BACKCOLOT" : z9912.BackColot = Children(i).Code
                                Case "FORECOLOR" : z9912.ForeColor = Children(i).Code
                                Case "FONTNAME" : z9912.FontName = Children(i).Code
                                Case "FONTSIZE" : z9912.FontSize = Children(i).Code
                                Case "FONTBOLD" : z9912.FontBold = Children(i).Code
                                Case "CHECKMERGE" : z9912.CheckMerge = Children(i).Code
                                Case "CHECKMERGEPOLICY" : z9912.CheckMergePolicy = Children(i).Code
                                Case "CHECKHEAD" : z9912.CheckHead = Children(i).Code
                                Case "CHECKHEADTYPE" : z9912.CheckHeadType = Children(i).Code
                                Case "CHECKDEV" : z9912.CheckDev = Children(i).Code
                                Case "LOCK" : z9912.Lock = Children(i).Code
                                Case "HIDDEN" : z9912.Hidden = Children(i).Code
                                Case "REMK" : z9912.REMK = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "PRODJECTNAME" : z9912.ProdjectName = Children(i).Data
                                Case "PROGRAMNO" : z9912.ProgramNo = Children(i).Data
                                Case "SHEETNAME" : z9912.SheetName = Children(i).Data
                                Case "PROGRAMSEQ" : z9912.ProgramSeq = Children(i).Data
                                Case "PROGRAMDSEQ" : z9912.ProgramDSeq = Children(i).Data
                                Case "ITEMCODE" : z9912.ItemCode = Children(i).Data
                                Case "ITEMNAMESIMPLY" : z9912.ItemNameSimply = Children(i).Data
                                Case "ITEMNAMEFOREIGN1" : z9912.ItemNameForeign1 = Children(i).Data
                                Case "ITEMNAMEFOREIGN2" : z9912.ItemNameForeign2 = Children(i).Data
                                Case "DATATYPE" : z9912.DataType = Children(i).Data
                                Case "DATASIZE" : z9912.DataSize = Children(i).Data
                                Case "DATADECIMAL" : z9912.DataDecimal = Children(i).Data
                                Case "TEXTALIGN" : z9912.TextAlign = Children(i).Data
                                Case "HORIZONTALALIGNMENT" : z9912.HorizontalAlignment = Children(i).Data
                                Case "VERTICALALIGNMENT" : z9912.VerticalAlignment = Children(i).Data
                                Case "SIZEWIDTH" : z9912.SizeWidth = Children(i).Data
                                Case "SIZEHEIGHT" : z9912.SizeHeight = Children(i).Data
                                Case "BACKCOLOT" : z9912.BackColot = Children(i).Data
                                Case "FORECOLOR" : z9912.ForeColor = Children(i).Data
                                Case "FONTNAME" : z9912.FontName = Children(i).Data
                                Case "FONTSIZE" : z9912.FontSize = Children(i).Data
                                Case "FONTBOLD" : z9912.FontBold = Children(i).Data
                                Case "CHECKMERGE" : z9912.CheckMerge = Children(i).Data
                                Case "CHECKMERGEPOLICY" : z9912.CheckMergePolicy = Children(i).Data
                                Case "CHECKHEAD" : z9912.CheckHead = Children(i).Data
                                Case "CHECKHEADTYPE" : z9912.CheckHeadType = Children(i).Data
                                Case "CHECKDEV" : z9912.CheckDev = Children(i).Data
                                Case "LOCK" : z9912.Lock = Children(i).Data
                                Case "HIDDEN" : z9912.Hidden = Children(i).Data
                                Case "REMK" : z9912.REMK = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9912_MOVE", vbCritical)
        End Try
    End Function

End Module
