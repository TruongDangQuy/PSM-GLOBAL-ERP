'=========================================================================================================================================================
'   TABLE : (PFK9916)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K9916

    Structure T9916_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public ProgramNo As String  '			varchar(100)		*
        Public ItemCode As String  '			char(6)		*
        Public ItemName As String  '			nvarchar(100)		*
        Public ItemNameSimply As String  '			nvarchar(50)
        Public ItemNameForeign1 As String  '			nvarchar(50)
        Public ItemNameForeign2 As String  '			nvarchar(50)
        Public ProdjectName As String  '			nvarchar(10)
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
        Public Lock As String  '			nvarchar(10)
        Public Hidden As String  '			nvarchar(10)
        Public CheckMerge As String  '			char(1)
        Public CheckMergePolicy As String  '			char(1)
        Public CheckHead As String  '			char(1)
        Public CheckHeadType As String  '			char(1)
        Public CheckDev As String  '			char(1)
        Public REMK As String  '			nvarchar(300)
        '=========================================================================================================================================================
    End Structure

    Public D9916 As T9916_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK9916(PROGRAMNO As String, ITEMCODE As String, ITEMNAME As String) As Boolean
        READ_PFK9916 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9916 "
            SQL = SQL & " WHERE K9916_ProgramNo		 = '" & ProgramNo & "' "
            SQL = SQL & "   AND K9916_ItemCode		 = '" & ItemCode & "' "
            SQL = SQL & "   AND K9916_ItemName		 = '" & ItemName & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9916_CLEAR() : GoTo SKIP_READ_PFK9916

            Call K9916_MOVE(rd)
            READ_PFK9916 = True

SKIP_READ_PFK9916:
            rd.Close()
            Exit Function
        Catch ex As Exception

        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK9916(PROGRAMNO As String, ITEMCODE As String, ITEMNAME As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9916 "
            SQL = SQL & " WHERE K9916_ProgramNo		 = '" & ProgramNo & "' "
            SQL = SQL & "   AND K9916_ItemCode		 = '" & ItemCode & "' "
            SQL = SQL & "   AND K9916_ItemName		 = '" & ItemName & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception

            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function


    Public Function READ_PFK9916_3(ITEMNAME As String) As Boolean
        READ_PFK9916_3 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK9916 "
            SQL = SQL & " WHERE K9916_ItemName		 = '" & ITEMNAME & "' "
            SQL = SQL & " AND K9916_CheckDev		 = '1' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9916_CLEAR() : GoTo SKIP_READ_PFK9916

            Call K9916_MOVE(rd)
            READ_PFK9916_3 = True

SKIP_READ_PFK9916:
            rd.Close()
            Exit Function
        Catch ex As Exception

        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK9916(z9916 As T9916_AREA) As Boolean
        WRITE_PFK9916 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z9916)

            SQL = " INSERT INTO PFK9916 "
            SQL = SQL & " ( "
            SQL = SQL & " K9916_ProgramNo,"
            SQL = SQL & " K9916_ItemCode,"
            SQL = SQL & " K9916_ItemName,"
            SQL = SQL & " K9916_ItemNameSimply,"
            SQL = SQL & " K9916_ItemNameForeign1,"
            SQL = SQL & " K9916_ItemNameForeign2,"
            SQL = SQL & " K9916_ProdjectName,"
            SQL = SQL & " K9916_DataType,"
            SQL = SQL & " K9916_DataSize,"
            SQL = SQL & " K9916_DataDecimal,"
            SQL = SQL & " K9916_TextAlign,"
            SQL = SQL & " K9916_HorizontalAlignment,"
            SQL = SQL & " K9916_VerticalAlignment,"
            SQL = SQL & " K9916_SizeWidth,"
            SQL = SQL & " K9916_SizeHeight,"
            SQL = SQL & " K9916_BackColot,"
            SQL = SQL & " K9916_ForeColor,"
            SQL = SQL & " K9916_FontName,"
            SQL = SQL & " K9916_FontSize,"
            SQL = SQL & " K9916_FontBold,"
            SQL = SQL & " K9916_Lock,"
            SQL = SQL & " K9916_Hidden,"
            SQL = SQL & " K9916_CheckMerge,"
            SQL = SQL & " K9916_CheckMergePolicy,"
            SQL = SQL & " K9916_CheckHead,"
            SQL = SQL & " K9916_CheckHeadType,"
            SQL = SQL & " K9916_CheckDev,"
            SQL = SQL & " K9916_REMK "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z9916.ProgramNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9916.ItemCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9916.ItemName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9916.ItemNameSimply) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9916.ItemNameForeign1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9916.ItemNameForeign2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9916.ProdjectName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9916.DataType) & "', "
            SQL = SQL & "   " & FormatSQL(z9916.DataSize) & ", "
            SQL = SQL & "   " & FormatSQL(z9916.DataDecimal) & ", "
            SQL = SQL & "  N'" & FormatSQL(z9916.TextAlign) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9916.HorizontalAlignment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9916.VerticalAlignment) & "', "
            SQL = SQL & "   " & FormatSQL(z9916.SizeWidth) & ", "
            SQL = SQL & "   " & FormatSQL(z9916.SizeHeight) & ", "
            SQL = SQL & "  N'" & FormatSQL(z9916.BackColot) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9916.ForeColor) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9916.FontName) & "', "
            SQL = SQL & "   " & FormatSQL(z9916.FontSize) & ", "
            SQL = SQL & "  N'" & FormatSQL(z9916.FontBold) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9916.Lock) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9916.Hidden) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9916.CheckMerge) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9916.CheckMergePolicy) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9916.CheckHead) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9916.CheckHeadType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9916.CheckDev) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9916.REMK) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK9916 = True
            Exit Function
        Catch ex As Exception

        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK9916(z9916 As T9916_AREA) As Boolean
        REWRITE_PFK9916 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z9916)

            SQL = " UPDATE PFK9916 SET "
            SQL = SQL & "    K9916_ItemNameSimply      = N'" & FormatSQL(z9916.ItemNameSimply) & "', "
            SQL = SQL & "    K9916_ItemNameForeign1      = N'" & FormatSQL(z9916.ItemNameForeign1) & "', "
            SQL = SQL & "    K9916_ItemNameForeign2      = N'" & FormatSQL(z9916.ItemNameForeign2) & "', "
            SQL = SQL & "    K9916_ProdjectName      = N'" & FormatSQL(z9916.ProdjectName) & "', "
            SQL = SQL & "    K9916_DataType      = N'" & FormatSQL(z9916.DataType) & "', "
            SQL = SQL & "    K9916_DataSize      =  " & FormatSQL(z9916.DataSize) & ", "
            SQL = SQL & "    K9916_DataDecimal      =  " & FormatSQL(z9916.DataDecimal) & ", "
            SQL = SQL & "    K9916_TextAlign      = N'" & FormatSQL(z9916.TextAlign) & "', "
            SQL = SQL & "    K9916_HorizontalAlignment      = N'" & FormatSQL(z9916.HorizontalAlignment) & "', "
            SQL = SQL & "    K9916_VerticalAlignment      = N'" & FormatSQL(z9916.VerticalAlignment) & "', "
            SQL = SQL & "    K9916_SizeWidth      =  " & FormatSQL(z9916.SizeWidth) & ", "
            SQL = SQL & "    K9916_SizeHeight      =  " & FormatSQL(z9916.SizeHeight) & ", "
            SQL = SQL & "    K9916_BackColot      = N'" & FormatSQL(z9916.BackColot) & "', "
            SQL = SQL & "    K9916_ForeColor      = N'" & FormatSQL(z9916.ForeColor) & "', "
            SQL = SQL & "    K9916_FontName      = N'" & FormatSQL(z9916.FontName) & "', "
            SQL = SQL & "    K9916_FontSize      =  " & FormatSQL(z9916.FontSize) & ", "
            SQL = SQL & "    K9916_FontBold      = N'" & FormatSQL(z9916.FontBold) & "', "
            SQL = SQL & "    K9916_Lock      = N'" & FormatSQL(z9916.Lock) & "', "
            SQL = SQL & "    K9916_Hidden      = N'" & FormatSQL(z9916.Hidden) & "', "
            SQL = SQL & "    K9916_CheckMerge      = N'" & FormatSQL(z9916.CheckMerge) & "', "
            SQL = SQL & "    K9916_CheckMergePolicy      = N'" & FormatSQL(z9916.CheckMergePolicy) & "', "
            SQL = SQL & "    K9916_CheckHead      = N'" & FormatSQL(z9916.CheckHead) & "', "
            SQL = SQL & "    K9916_CheckHeadType      = N'" & FormatSQL(z9916.CheckHeadType) & "', "
            SQL = SQL & "    K9916_CheckDev      = N'" & FormatSQL(z9916.CheckDev) & "', "
            SQL = SQL & "    K9916_REMK      = N'" & FormatSQL(z9916.REMK) & "'  "
            SQL = SQL & " WHERE K9916_ProgramNo		 = '" & z9916.ProgramNo & "' "
            SQL = SQL & "   AND K9916_ItemCode		 = '" & z9916.ItemCode & "' "
            SQL = SQL & "   AND K9916_ItemName		 = '" & z9916.ItemName & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK9916 = True

            Exit Function
        Catch ex As Exception

        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK9916(z9916 As T9916_AREA) As Boolean
        DELETE_PFK9916 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK9916 "
            SQL = SQL & " WHERE K9916_ProgramNo		 = '" & z9916.ProgramNo & "' "
            SQL = SQL & "   AND K9916_ItemCode		 = '" & z9916.ItemCode & "' "
            SQL = SQL & "   AND K9916_ItemName		 = '" & z9916.ItemName & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK9916 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK9916", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D9916_CLEAR()
        Try

            D9916.ProgramNo = ""
            D9916.ItemCode = ""
            D9916.ItemName = ""
            D9916.ItemNameSimply = ""
            D9916.ItemNameForeign1 = ""
            D9916.ItemNameForeign2 = ""
            D9916.ProdjectName = ""
            D9916.DataType = ""
            D9916.DataSize = 0
            D9916.DataDecimal = 0
            D9916.TextAlign = ""
            D9916.HorizontalAlignment = ""
            D9916.VerticalAlignment = ""
            D9916.SizeWidth = 0
            D9916.SizeHeight = 0
            D9916.BackColot = ""
            D9916.ForeColor = ""
            D9916.FontName = ""
            D9916.FontSize = 0
            D9916.FontBold = ""
            D9916.Lock = ""
            D9916.Hidden = ""
            D9916.CheckMerge = ""
            D9916.CheckMergePolicy = ""
            D9916.CheckHead = ""
            D9916.CheckHeadType = ""
            D9916.CheckDev = ""
            D9916.REMK = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D9916_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x9916 As T9916_AREA)
        Try

            x9916.ProgramNo = trim$(x9916.ProgramNo)
            x9916.ItemCode = trim$(x9916.ItemCode)
            x9916.ItemName = trim$(x9916.ItemName)
            x9916.ItemNameSimply = trim$(x9916.ItemNameSimply)
            x9916.ItemNameForeign1 = trim$(x9916.ItemNameForeign1)
            x9916.ItemNameForeign2 = trim$(x9916.ItemNameForeign2)
            x9916.ProdjectName = trim$(x9916.ProdjectName)
            x9916.DataType = trim$(x9916.DataType)
            x9916.DataSize = trim$(x9916.DataSize)
            x9916.DataDecimal = trim$(x9916.DataDecimal)
            x9916.TextAlign = trim$(x9916.TextAlign)
            x9916.HorizontalAlignment = trim$(x9916.HorizontalAlignment)
            x9916.VerticalAlignment = trim$(x9916.VerticalAlignment)
            x9916.SizeWidth = trim$(x9916.SizeWidth)
            x9916.SizeHeight = trim$(x9916.SizeHeight)
            x9916.BackColot = trim$(x9916.BackColot)
            x9916.ForeColor = trim$(x9916.ForeColor)
            x9916.FontName = trim$(x9916.FontName)
            x9916.FontSize = trim$(x9916.FontSize)
            x9916.FontBold = trim$(x9916.FontBold)
            x9916.Lock = trim$(x9916.Lock)
            x9916.Hidden = trim$(x9916.Hidden)
            x9916.CheckMerge = trim$(x9916.CheckMerge)
            x9916.CheckMergePolicy = trim$(x9916.CheckMergePolicy)
            x9916.CheckHead = trim$(x9916.CheckHead)
            x9916.CheckHeadType = trim$(x9916.CheckHeadType)
            x9916.CheckDev = trim$(x9916.CheckDev)
            x9916.REMK = trim$(x9916.REMK)

            If trim$(x9916.ProgramNo) = "" Then x9916.ProgramNo = Space(1)
            If trim$(x9916.ItemCode) = "" Then x9916.ItemCode = Space(1)
            If trim$(x9916.ItemName) = "" Then x9916.ItemName = Space(1)
            If trim$(x9916.ItemNameSimply) = "" Then x9916.ItemNameSimply = Space(1)
            If trim$(x9916.ItemNameForeign1) = "" Then x9916.ItemNameForeign1 = Space(1)
            If trim$(x9916.ItemNameForeign2) = "" Then x9916.ItemNameForeign2 = Space(1)
            If trim$(x9916.ProdjectName) = "" Then x9916.ProdjectName = Space(1)
            If trim$(x9916.DataType) = "" Then x9916.DataType = Space(1)
            If trim$(x9916.DataSize) = "" Then x9916.DataSize = 0
            If trim$(x9916.DataDecimal) = "" Then x9916.DataDecimal = 0
            If trim$(x9916.TextAlign) = "" Then x9916.TextAlign = Space(1)
            If trim$(x9916.HorizontalAlignment) = "" Then x9916.HorizontalAlignment = Space(1)
            If trim$(x9916.VerticalAlignment) = "" Then x9916.VerticalAlignment = Space(1)
            If trim$(x9916.SizeWidth) = "" Then x9916.SizeWidth = 0
            If trim$(x9916.SizeHeight) = "" Then x9916.SizeHeight = 0
            If trim$(x9916.BackColot) = "" Then x9916.BackColot = Space(1)
            If trim$(x9916.ForeColor) = "" Then x9916.ForeColor = Space(1)
            If trim$(x9916.FontName) = "" Then x9916.FontName = Space(1)
            If trim$(x9916.FontSize) = "" Then x9916.FontSize = 0
            If trim$(x9916.FontBold) = "" Then x9916.FontBold = Space(1)
            If trim$(x9916.Lock) = "" Then x9916.Lock = Space(1)
            If trim$(x9916.Hidden) = "" Then x9916.Hidden = Space(1)
            If trim$(x9916.CheckMerge) = "" Then x9916.CheckMerge = Space(1)
            If trim$(x9916.CheckMergePolicy) = "" Then x9916.CheckMergePolicy = Space(1)
            If trim$(x9916.CheckHead) = "" Then x9916.CheckHead = Space(1)
            If trim$(x9916.CheckHeadType) = "" Then x9916.CheckHeadType = Space(1)
            If trim$(x9916.CheckDev) = "" Then x9916.CheckDev = Space(1)
            If trim$(x9916.REMK) = "" Then x9916.REMK = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K9916_MOVE(rs9916 As SqlClient.SqlDataReader)
        Try

            Call D9916_CLEAR()

            If IsdbNull(rs9916!K9916_ProgramNo) = False Then D9916.ProgramNo = Trim$(rs9916!K9916_ProgramNo)
            If IsdbNull(rs9916!K9916_ItemCode) = False Then D9916.ItemCode = Trim$(rs9916!K9916_ItemCode)
            If IsdbNull(rs9916!K9916_ItemName) = False Then D9916.ItemName = Trim$(rs9916!K9916_ItemName)
            If IsdbNull(rs9916!K9916_ItemNameSimply) = False Then D9916.ItemNameSimply = Trim$(rs9916!K9916_ItemNameSimply)
            If IsdbNull(rs9916!K9916_ItemNameForeign1) = False Then D9916.ItemNameForeign1 = Trim$(rs9916!K9916_ItemNameForeign1)
            If IsdbNull(rs9916!K9916_ItemNameForeign2) = False Then D9916.ItemNameForeign2 = Trim$(rs9916!K9916_ItemNameForeign2)
            If IsdbNull(rs9916!K9916_ProdjectName) = False Then D9916.ProdjectName = Trim$(rs9916!K9916_ProdjectName)
            If IsdbNull(rs9916!K9916_DataType) = False Then D9916.DataType = Trim$(rs9916!K9916_DataType)
            If IsdbNull(rs9916!K9916_DataSize) = False Then D9916.DataSize = Trim$(rs9916!K9916_DataSize)
            If IsdbNull(rs9916!K9916_DataDecimal) = False Then D9916.DataDecimal = Trim$(rs9916!K9916_DataDecimal)
            If IsdbNull(rs9916!K9916_TextAlign) = False Then D9916.TextAlign = Trim$(rs9916!K9916_TextAlign)
            If IsdbNull(rs9916!K9916_HorizontalAlignment) = False Then D9916.HorizontalAlignment = Trim$(rs9916!K9916_HorizontalAlignment)
            If IsdbNull(rs9916!K9916_VerticalAlignment) = False Then D9916.VerticalAlignment = Trim$(rs9916!K9916_VerticalAlignment)
            If IsdbNull(rs9916!K9916_SizeWidth) = False Then D9916.SizeWidth = Trim$(rs9916!K9916_SizeWidth)
            If IsdbNull(rs9916!K9916_SizeHeight) = False Then D9916.SizeHeight = Trim$(rs9916!K9916_SizeHeight)
            If IsdbNull(rs9916!K9916_BackColot) = False Then D9916.BackColot = Trim$(rs9916!K9916_BackColot)
            If IsdbNull(rs9916!K9916_ForeColor) = False Then D9916.ForeColor = Trim$(rs9916!K9916_ForeColor)
            If IsdbNull(rs9916!K9916_FontName) = False Then D9916.FontName = Trim$(rs9916!K9916_FontName)
            If IsdbNull(rs9916!K9916_FontSize) = False Then D9916.FontSize = Trim$(rs9916!K9916_FontSize)
            If IsdbNull(rs9916!K9916_FontBold) = False Then D9916.FontBold = Trim$(rs9916!K9916_FontBold)
            If IsdbNull(rs9916!K9916_Lock) = False Then D9916.Lock = Trim$(rs9916!K9916_Lock)
            If IsdbNull(rs9916!K9916_Hidden) = False Then D9916.Hidden = Trim$(rs9916!K9916_Hidden)
            If IsdbNull(rs9916!K9916_CheckMerge) = False Then D9916.CheckMerge = Trim$(rs9916!K9916_CheckMerge)
            If IsdbNull(rs9916!K9916_CheckMergePolicy) = False Then D9916.CheckMergePolicy = Trim$(rs9916!K9916_CheckMergePolicy)
            If IsdbNull(rs9916!K9916_CheckHead) = False Then D9916.CheckHead = Trim$(rs9916!K9916_CheckHead)
            If IsdbNull(rs9916!K9916_CheckHeadType) = False Then D9916.CheckHeadType = Trim$(rs9916!K9916_CheckHeadType)
            If IsdbNull(rs9916!K9916_CheckDev) = False Then D9916.CheckDev = Trim$(rs9916!K9916_CheckDev)
            If IsdbNull(rs9916!K9916_REMK) = False Then D9916.REMK = Trim$(rs9916!K9916_REMK)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K9916_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K9916_MOVE(rs9916 As DataRow)
        Try

            Call D9916_CLEAR()

            If IsdbNull(rs9916!K9916_ProgramNo) = False Then D9916.ProgramNo = Trim$(rs9916!K9916_ProgramNo)
            If IsdbNull(rs9916!K9916_ItemCode) = False Then D9916.ItemCode = Trim$(rs9916!K9916_ItemCode)
            If IsdbNull(rs9916!K9916_ItemName) = False Then D9916.ItemName = Trim$(rs9916!K9916_ItemName)
            If IsdbNull(rs9916!K9916_ItemNameSimply) = False Then D9916.ItemNameSimply = Trim$(rs9916!K9916_ItemNameSimply)
            If IsdbNull(rs9916!K9916_ItemNameForeign1) = False Then D9916.ItemNameForeign1 = Trim$(rs9916!K9916_ItemNameForeign1)
            If IsdbNull(rs9916!K9916_ItemNameForeign2) = False Then D9916.ItemNameForeign2 = Trim$(rs9916!K9916_ItemNameForeign2)
            If IsdbNull(rs9916!K9916_ProdjectName) = False Then D9916.ProdjectName = Trim$(rs9916!K9916_ProdjectName)
            If IsdbNull(rs9916!K9916_DataType) = False Then D9916.DataType = Trim$(rs9916!K9916_DataType)
            If IsdbNull(rs9916!K9916_DataSize) = False Then D9916.DataSize = Trim$(rs9916!K9916_DataSize)
            If IsdbNull(rs9916!K9916_DataDecimal) = False Then D9916.DataDecimal = Trim$(rs9916!K9916_DataDecimal)
            If IsdbNull(rs9916!K9916_TextAlign) = False Then D9916.TextAlign = Trim$(rs9916!K9916_TextAlign)
            If IsdbNull(rs9916!K9916_HorizontalAlignment) = False Then D9916.HorizontalAlignment = Trim$(rs9916!K9916_HorizontalAlignment)
            If IsdbNull(rs9916!K9916_VerticalAlignment) = False Then D9916.VerticalAlignment = Trim$(rs9916!K9916_VerticalAlignment)
            If IsdbNull(rs9916!K9916_SizeWidth) = False Then D9916.SizeWidth = Trim$(rs9916!K9916_SizeWidth)
            If IsdbNull(rs9916!K9916_SizeHeight) = False Then D9916.SizeHeight = Trim$(rs9916!K9916_SizeHeight)
            If IsdbNull(rs9916!K9916_BackColot) = False Then D9916.BackColot = Trim$(rs9916!K9916_BackColot)
            If IsdbNull(rs9916!K9916_ForeColor) = False Then D9916.ForeColor = Trim$(rs9916!K9916_ForeColor)
            If IsdbNull(rs9916!K9916_FontName) = False Then D9916.FontName = Trim$(rs9916!K9916_FontName)
            If IsdbNull(rs9916!K9916_FontSize) = False Then D9916.FontSize = Trim$(rs9916!K9916_FontSize)
            If IsdbNull(rs9916!K9916_FontBold) = False Then D9916.FontBold = Trim$(rs9916!K9916_FontBold)
            If IsdbNull(rs9916!K9916_Lock) = False Then D9916.Lock = Trim$(rs9916!K9916_Lock)
            If IsdbNull(rs9916!K9916_Hidden) = False Then D9916.Hidden = Trim$(rs9916!K9916_Hidden)
            If IsdbNull(rs9916!K9916_CheckMerge) = False Then D9916.CheckMerge = Trim$(rs9916!K9916_CheckMerge)
            If IsdbNull(rs9916!K9916_CheckMergePolicy) = False Then D9916.CheckMergePolicy = Trim$(rs9916!K9916_CheckMergePolicy)
            If IsdbNull(rs9916!K9916_CheckHead) = False Then D9916.CheckHead = Trim$(rs9916!K9916_CheckHead)
            If IsdbNull(rs9916!K9916_CheckHeadType) = False Then D9916.CheckHeadType = Trim$(rs9916!K9916_CheckHeadType)
            If IsdbNull(rs9916!K9916_CheckDev) = False Then D9916.CheckDev = Trim$(rs9916!K9916_CheckDev)
            If IsdbNull(rs9916!K9916_REMK) = False Then D9916.REMK = Trim$(rs9916!K9916_REMK)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K9916_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K9916_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z9916 As T9916_AREA, PROGRAMNO As String, ITEMCODE As String, ITEMNAME As String) As Boolean

        K9916_MOVE = False

        Try
            If READ_PFK9916(PROGRAMNO, ITEMCODE, ITEMNAME) = True Then
                z9916 = D9916
                K9916_MOVE = True
            Else
                z9916 = Nothing
            End If

            If getColumIndex(spr, "ProgramNo") > -1 Then z9916.ProgramNo = getDataM(spr, getColumIndex(spr, "ProgramNo"), xRow)
            If getColumIndex(spr, "ItemCode") > -1 Then z9916.ItemCode = getDataM(spr, getColumIndex(spr, "ItemCode"), xRow)
            If getColumIndex(spr, "ItemName") > -1 Then z9916.ItemName = getDataM(spr, getColumIndex(spr, "ItemName"), xRow)
            If getColumIndex(spr, "ItemNameSimply") > -1 Then z9916.ItemNameSimply = getDataM(spr, getColumIndex(spr, "ItemNameSimply"), xRow)
            If getColumIndex(spr, "ItemNameForeign1") > -1 Then z9916.ItemNameForeign1 = getDataM(spr, getColumIndex(spr, "ItemNameForeign1"), xRow)
            If getColumIndex(spr, "ItemNameForeign2") > -1 Then z9916.ItemNameForeign2 = getDataM(spr, getColumIndex(spr, "ItemNameForeign2"), xRow)
            If getColumIndex(spr, "ProdjectName") > -1 Then z9916.ProdjectName = getDataM(spr, getColumIndex(spr, "ProdjectName"), xRow)
            If getColumIndex(spr, "DataType") > -1 Then z9916.DataType = getDataM(spr, getColumIndex(spr, "DataType"), xRow)
            If getColumIndex(spr, "DataSize") > -1 Then z9916.DataSize = getDataM(spr, getColumIndex(spr, "DataSize"), xRow)
            If getColumIndex(spr, "DataDecimal") > -1 Then z9916.DataDecimal = getDataM(spr, getColumIndex(spr, "DataDecimal"), xRow)
            If getColumIndex(spr, "TextAlign") > -1 Then z9916.TextAlign = getDataM(spr, getColumIndex(spr, "TextAlign"), xRow)
            If getColumIndex(spr, "HorizontalAlignment") > -1 Then z9916.HorizontalAlignment = getDataM(spr, getColumIndex(spr, "HorizontalAlignment"), xRow)
            If getColumIndex(spr, "VerticalAlignment") > -1 Then z9916.VerticalAlignment = getDataM(spr, getColumIndex(spr, "VerticalAlignment"), xRow)
            If getColumIndex(spr, "SizeWidth") > -1 Then z9916.SizeWidth = getDataM(spr, getColumIndex(spr, "SizeWidth"), xRow)
            If getColumIndex(spr, "SizeHeight") > -1 Then z9916.SizeHeight = getDataM(spr, getColumIndex(spr, "SizeHeight"), xRow)
            If getColumIndex(spr, "BackColot") > -1 Then z9916.BackColot = getDataM(spr, getColumIndex(spr, "BackColot"), xRow)
            If getColumIndex(spr, "ForeColor") > -1 Then z9916.ForeColor = getDataM(spr, getColumIndex(spr, "ForeColor"), xRow)
            If getColumIndex(spr, "FontName") > -1 Then z9916.FontName = getDataM(spr, getColumIndex(spr, "FontName"), xRow)
            If getColumIndex(spr, "FontSize") > -1 Then z9916.FontSize = getDataM(spr, getColumIndex(spr, "FontSize"), xRow)
            If getColumIndex(spr, "FontBold") > -1 Then z9916.FontBold = getDataM(spr, getColumIndex(spr, "FontBold"), xRow)
            If getColumIndex(spr, "Lock") > -1 Then z9916.Lock = getDataM(spr, getColumIndex(spr, "Lock"), xRow)
            If getColumIndex(spr, "Hidden") > -1 Then z9916.Hidden = getDataM(spr, getColumIndex(spr, "Hidden"), xRow)
            If getColumIndex(spr, "CheckMerge") > -1 Then z9916.CheckMerge = getDataM(spr, getColumIndex(spr, "CheckMerge"), xRow)
            If getColumIndex(spr, "CheckMergePolicy") > -1 Then z9916.CheckMergePolicy = getDataM(spr, getColumIndex(spr, "CheckMergePolicy"), xRow)
            If getColumIndex(spr, "CheckHead") > -1 Then z9916.CheckHead = getDataM(spr, getColumIndex(spr, "CheckHead"), xRow)
            If getColumIndex(spr, "CheckHeadType") > -1 Then z9916.CheckHeadType = getDataM(spr, getColumIndex(spr, "CheckHeadType"), xRow)
            If getColumIndex(spr, "CheckDev") > -1 Then z9916.CheckDev = getDataM(spr, getColumIndex(spr, "CheckDev"), xRow)
            If getColumIndex(spr, "REMK") > -1 Then z9916.REMK = getDataM(spr, getColumIndex(spr, "REMK"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9916_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K9916_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z9916 As T9916_AREA, CheckClear As Boolean, PROGRAMNO As String, ITEMCODE As String, ITEMNAME As String) As Boolean

        K9916_MOVE = False

        Try
            If READ_PFK9916(PROGRAMNO, ITEMCODE, ITEMNAME) = True Then
                z9916 = D9916
                K9916_MOVE = True
            Else
                If CheckClear = True Then z9916 = Nothing
            End If

            If getColumIndex(spr, "ProgramNo") > -1 Then z9916.ProgramNo = getDataM(spr, getColumIndex(spr, "ProgramNo"), xRow)
            If getColumIndex(spr, "ItemCode") > -1 Then z9916.ItemCode = getDataM(spr, getColumIndex(spr, "ItemCode"), xRow)
            If getColumIndex(spr, "ItemName") > -1 Then z9916.ItemName = getDataM(spr, getColumIndex(spr, "ItemName"), xRow)
            If getColumIndex(spr, "ItemNameSimply") > -1 Then z9916.ItemNameSimply = getDataM(spr, getColumIndex(spr, "ItemNameSimply"), xRow)
            If getColumIndex(spr, "ItemNameForeign1") > -1 Then z9916.ItemNameForeign1 = getDataM(spr, getColumIndex(spr, "ItemNameForeign1"), xRow)
            If getColumIndex(spr, "ItemNameForeign2") > -1 Then z9916.ItemNameForeign2 = getDataM(spr, getColumIndex(spr, "ItemNameForeign2"), xRow)
            If getColumIndex(spr, "ProdjectName") > -1 Then z9916.ProdjectName = getDataM(spr, getColumIndex(spr, "ProdjectName"), xRow)
            If getColumIndex(spr, "DataType") > -1 Then z9916.DataType = getDataM(spr, getColumIndex(spr, "DataType"), xRow)
            If getColumIndex(spr, "DataSize") > -1 Then z9916.DataSize = getDataM(spr, getColumIndex(spr, "DataSize"), xRow)
            If getColumIndex(spr, "DataDecimal") > -1 Then z9916.DataDecimal = getDataM(spr, getColumIndex(spr, "DataDecimal"), xRow)
            If getColumIndex(spr, "TextAlign") > -1 Then z9916.TextAlign = getDataM(spr, getColumIndex(spr, "TextAlign"), xRow)
            If getColumIndex(spr, "HorizontalAlignment") > -1 Then z9916.HorizontalAlignment = getDataM(spr, getColumIndex(spr, "HorizontalAlignment"), xRow)
            If getColumIndex(spr, "VerticalAlignment") > -1 Then z9916.VerticalAlignment = getDataM(spr, getColumIndex(spr, "VerticalAlignment"), xRow)
            If getColumIndex(spr, "SizeWidth") > -1 Then z9916.SizeWidth = getDataM(spr, getColumIndex(spr, "SizeWidth"), xRow)
            If getColumIndex(spr, "SizeHeight") > -1 Then z9916.SizeHeight = getDataM(spr, getColumIndex(spr, "SizeHeight"), xRow)
            If getColumIndex(spr, "BackColot") > -1 Then z9916.BackColot = getDataM(spr, getColumIndex(spr, "BackColot"), xRow)
            If getColumIndex(spr, "ForeColor") > -1 Then z9916.ForeColor = getDataM(spr, getColumIndex(spr, "ForeColor"), xRow)
            If getColumIndex(spr, "FontName") > -1 Then z9916.FontName = getDataM(spr, getColumIndex(spr, "FontName"), xRow)
            If getColumIndex(spr, "FontSize") > -1 Then z9916.FontSize = getDataM(spr, getColumIndex(spr, "FontSize"), xRow)
            If getColumIndex(spr, "FontBold") > -1 Then z9916.FontBold = getDataM(spr, getColumIndex(spr, "FontBold"), xRow)
            If getColumIndex(spr, "Lock") > -1 Then z9916.Lock = getDataM(spr, getColumIndex(spr, "Lock"), xRow)
            If getColumIndex(spr, "Hidden") > -1 Then z9916.Hidden = getDataM(spr, getColumIndex(spr, "Hidden"), xRow)
            If getColumIndex(spr, "CheckMerge") > -1 Then z9916.CheckMerge = getDataM(spr, getColumIndex(spr, "CheckMerge"), xRow)
            If getColumIndex(spr, "CheckMergePolicy") > -1 Then z9916.CheckMergePolicy = getDataM(spr, getColumIndex(spr, "CheckMergePolicy"), xRow)
            If getColumIndex(spr, "CheckHead") > -1 Then z9916.CheckHead = getDataM(spr, getColumIndex(spr, "CheckHead"), xRow)
            If getColumIndex(spr, "CheckHeadType") > -1 Then z9916.CheckHeadType = getDataM(spr, getColumIndex(spr, "CheckHeadType"), xRow)
            If getColumIndex(spr, "CheckDev") > -1 Then z9916.CheckDev = getDataM(spr, getColumIndex(spr, "CheckDev"), xRow)
            If getColumIndex(spr, "REMK") > -1 Then z9916.REMK = getDataM(spr, getColumIndex(spr, "REMK"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9916_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K9916_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z9916 As T9916_AREA, Job As String, PROGRAMNO As String, ITEMCODE As String, ITEMNAME As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K9916_MOVE = False

        Try
            If READ_PFK9916(PROGRAMNO, ITEMCODE, ITEMNAME) = True Then
                z9916 = D9916
                K9916_MOVE = True
            Else
                z9916 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9916")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "PROGRAMNO" : z9916.ProgramNo = Children(i).Code
                                Case "ITEMCODE" : z9916.ItemCode = Children(i).Code
                                Case "ITEMNAME" : z9916.ItemName = Children(i).Code
                                Case "ITEMNAMESIMPLY" : z9916.ItemNameSimply = Children(i).Code
                                Case "ITEMNAMEFOREIGN1" : z9916.ItemNameForeign1 = Children(i).Code
                                Case "ITEMNAMEFOREIGN2" : z9916.ItemNameForeign2 = Children(i).Code
                                Case "PRODJECTNAME" : z9916.ProdjectName = Children(i).Code
                                Case "DATATYPE" : z9916.DataType = Children(i).Code
                                Case "DATASIZE" : z9916.DataSize = Children(i).Code
                                Case "DATADECIMAL" : z9916.DataDecimal = Children(i).Code
                                Case "TEXTALIGN" : z9916.TextAlign = Children(i).Code
                                Case "HORIZONTALALIGNMENT" : z9916.HorizontalAlignment = Children(i).Code
                                Case "VERTICALALIGNMENT" : z9916.VerticalAlignment = Children(i).Code
                                Case "SIZEWIDTH" : z9916.SizeWidth = Children(i).Code
                                Case "SIZEHEIGHT" : z9916.SizeHeight = Children(i).Code
                                Case "BACKCOLOT" : z9916.BackColot = Children(i).Code
                                Case "FORECOLOR" : z9916.ForeColor = Children(i).Code
                                Case "FONTNAME" : z9916.FontName = Children(i).Code
                                Case "FONTSIZE" : z9916.FontSize = Children(i).Code
                                Case "FONTBOLD" : z9916.FontBold = Children(i).Code
                                Case "LOCK" : z9916.Lock = Children(i).Code
                                Case "HIDDEN" : z9916.Hidden = Children(i).Code
                                Case "CHECKMERGE" : z9916.CheckMerge = Children(i).Code
                                Case "CHECKMERGEPOLICY" : z9916.CheckMergePolicy = Children(i).Code
                                Case "CHECKHEAD" : z9916.CheckHead = Children(i).Code
                                Case "CHECKHEADTYPE" : z9916.CheckHeadType = Children(i).Code
                                Case "CHECKDEV" : z9916.CheckDev = Children(i).Code
                                Case "REMK" : z9916.REMK = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "PROGRAMNO" : z9916.ProgramNo = Children(i).Data
                                Case "ITEMCODE" : z9916.ItemCode = Children(i).Data
                                Case "ITEMNAME" : z9916.ItemName = Children(i).Data
                                Case "ITEMNAMESIMPLY" : z9916.ItemNameSimply = Children(i).Data
                                Case "ITEMNAMEFOREIGN1" : z9916.ItemNameForeign1 = Children(i).Data
                                Case "ITEMNAMEFOREIGN2" : z9916.ItemNameForeign2 = Children(i).Data
                                Case "PRODJECTNAME" : z9916.ProdjectName = Children(i).Data
                                Case "DATATYPE" : z9916.DataType = Children(i).Data
                                Case "DATASIZE" : z9916.DataSize = Children(i).Data
                                Case "DATADECIMAL" : z9916.DataDecimal = Children(i).Data
                                Case "TEXTALIGN" : z9916.TextAlign = Children(i).Data
                                Case "HORIZONTALALIGNMENT" : z9916.HorizontalAlignment = Children(i).Data
                                Case "VERTICALALIGNMENT" : z9916.VerticalAlignment = Children(i).Data
                                Case "SIZEWIDTH" : z9916.SizeWidth = Children(i).Data
                                Case "SIZEHEIGHT" : z9916.SizeHeight = Children(i).Data
                                Case "BACKCOLOT" : z9916.BackColot = Children(i).Data
                                Case "FORECOLOR" : z9916.ForeColor = Children(i).Data
                                Case "FONTNAME" : z9916.FontName = Children(i).Data
                                Case "FONTSIZE" : z9916.FontSize = Children(i).Data
                                Case "FONTBOLD" : z9916.FontBold = Children(i).Data
                                Case "LOCK" : z9916.Lock = Children(i).Data
                                Case "HIDDEN" : z9916.Hidden = Children(i).Data
                                Case "CHECKMERGE" : z9916.CheckMerge = Children(i).Data
                                Case "CHECKMERGEPOLICY" : z9916.CheckMergePolicy = Children(i).Data
                                Case "CHECKHEAD" : z9916.CheckHead = Children(i).Data
                                Case "CHECKHEADTYPE" : z9916.CheckHeadType = Children(i).Data
                                Case "CHECKDEV" : z9916.CheckDev = Children(i).Data
                                Case "REMK" : z9916.REMK = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9916_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K9916_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z9916 As T9916_AREA, Job As String, CheckClear As Boolean, PROGRAMNO As String, ITEMCODE As String, ITEMNAME As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K9916_MOVE = False

        Try
            If READ_PFK9916(PROGRAMNO, ITEMCODE, ITEMNAME) = True Then
                z9916 = D9916
                K9916_MOVE = True
            Else
                If CheckClear = True Then z9916 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9916")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "PROGRAMNO" : z9916.ProgramNo = Children(i).Code
                                Case "ITEMCODE" : z9916.ItemCode = Children(i).Code
                                Case "ITEMNAME" : z9916.ItemName = Children(i).Code
                                Case "ITEMNAMESIMPLY" : z9916.ItemNameSimply = Children(i).Code
                                Case "ITEMNAMEFOREIGN1" : z9916.ItemNameForeign1 = Children(i).Code
                                Case "ITEMNAMEFOREIGN2" : z9916.ItemNameForeign2 = Children(i).Code
                                Case "PRODJECTNAME" : z9916.ProdjectName = Children(i).Code
                                Case "DATATYPE" : z9916.DataType = Children(i).Code
                                Case "DATASIZE" : z9916.DataSize = Children(i).Code
                                Case "DATADECIMAL" : z9916.DataDecimal = Children(i).Code
                                Case "TEXTALIGN" : z9916.TextAlign = Children(i).Code
                                Case "HORIZONTALALIGNMENT" : z9916.HorizontalAlignment = Children(i).Code
                                Case "VERTICALALIGNMENT" : z9916.VerticalAlignment = Children(i).Code
                                Case "SIZEWIDTH" : z9916.SizeWidth = Children(i).Code
                                Case "SIZEHEIGHT" : z9916.SizeHeight = Children(i).Code
                                Case "BACKCOLOT" : z9916.BackColot = Children(i).Code
                                Case "FORECOLOR" : z9916.ForeColor = Children(i).Code
                                Case "FONTNAME" : z9916.FontName = Children(i).Code
                                Case "FONTSIZE" : z9916.FontSize = Children(i).Code
                                Case "FONTBOLD" : z9916.FontBold = Children(i).Code
                                Case "LOCK" : z9916.Lock = Children(i).Code
                                Case "HIDDEN" : z9916.Hidden = Children(i).Code
                                Case "CHECKMERGE" : z9916.CheckMerge = Children(i).Code
                                Case "CHECKMERGEPOLICY" : z9916.CheckMergePolicy = Children(i).Code
                                Case "CHECKHEAD" : z9916.CheckHead = Children(i).Code
                                Case "CHECKHEADTYPE" : z9916.CheckHeadType = Children(i).Code
                                Case "CHECKDEV" : z9916.CheckDev = Children(i).Code
                                Case "REMK" : z9916.REMK = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "PROGRAMNO" : z9916.ProgramNo = Children(i).Data
                                Case "ITEMCODE" : z9916.ItemCode = Children(i).Data
                                Case "ITEMNAME" : z9916.ItemName = Children(i).Data
                                Case "ITEMNAMESIMPLY" : z9916.ItemNameSimply = Children(i).Data
                                Case "ITEMNAMEFOREIGN1" : z9916.ItemNameForeign1 = Children(i).Data
                                Case "ITEMNAMEFOREIGN2" : z9916.ItemNameForeign2 = Children(i).Data
                                Case "PRODJECTNAME" : z9916.ProdjectName = Children(i).Data
                                Case "DATATYPE" : z9916.DataType = Children(i).Data
                                Case "DATASIZE" : z9916.DataSize = Children(i).Data
                                Case "DATADECIMAL" : z9916.DataDecimal = Children(i).Data
                                Case "TEXTALIGN" : z9916.TextAlign = Children(i).Data
                                Case "HORIZONTALALIGNMENT" : z9916.HorizontalAlignment = Children(i).Data
                                Case "VERTICALALIGNMENT" : z9916.VerticalAlignment = Children(i).Data
                                Case "SIZEWIDTH" : z9916.SizeWidth = Children(i).Data
                                Case "SIZEHEIGHT" : z9916.SizeHeight = Children(i).Data
                                Case "BACKCOLOT" : z9916.BackColot = Children(i).Data
                                Case "FORECOLOR" : z9916.ForeColor = Children(i).Data
                                Case "FONTNAME" : z9916.FontName = Children(i).Data
                                Case "FONTSIZE" : z9916.FontSize = Children(i).Data
                                Case "FONTBOLD" : z9916.FontBold = Children(i).Data
                                Case "LOCK" : z9916.Lock = Children(i).Data
                                Case "HIDDEN" : z9916.Hidden = Children(i).Data
                                Case "CHECKMERGE" : z9916.CheckMerge = Children(i).Data
                                Case "CHECKMERGEPOLICY" : z9916.CheckMergePolicy = Children(i).Data
                                Case "CHECKHEAD" : z9916.CheckHead = Children(i).Data
                                Case "CHECKHEADTYPE" : z9916.CheckHeadType = Children(i).Data
                                Case "CHECKDEV" : z9916.CheckDev = Children(i).Data
                                Case "REMK" : z9916.REMK = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9916_MOVE", vbCritical)
        End Try
    End Function

End Module
