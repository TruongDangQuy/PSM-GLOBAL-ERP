'=========================================================================================================================================================
'   TABLE : (PFK9911)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K9911

    Structure T9911_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public ItemCode As String  '			char(6)		*
        Public ItemName As String  '			nvarchar(100)
        Public ItemNameSimply As String  '			nvarchar(50)
        Public ItemNameForeign1 As String  '			nvarchar(50)
        Public ItemNameForeign2 As String  '			nvarchar(50)
        Public ProdjectName As String  '			nvarchar(10)
        Public FormType As String  '			char(1)
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
        Public CheckDevValue As String  '			nvarchar(50)
        Public REMK As String  '			nvarchar(300)
        '=========================================================================================================================================================
    End Structure

    Public D9911 As T9911_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================

    Public Function READ_PFK9911(ITEMCODE As String, ITEMNAME As String) As Boolean
        READ_PFK9911 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9911 "
            SQL = SQL & " WHERE K9911_ItemCode		 = '" & ItemCode & "' "
            SQL = SQL & "   AND K9911_ItemName		 = '" & ItemName & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9911_CLEAR() : GoTo SKIP_READ_PFK9911

            Call K9911_MOVE(rd)
            READ_PFK9911 = True

SKIP_READ_PFK9911:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK9911", vbCritical)
        End Try
    End Function


    Public Function READ_PFK9911(ITEMNAME As String) As Boolean
        READ_PFK9911 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9911 "
            SQL = SQL & "   WHERE K9911_ItemName		 = '" & ITEMNAME & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9911_CLEAR() : GoTo SKIP_READ_PFK9911

            Call K9911_MOVE(rd)
            READ_PFK9911 = True

SKIP_READ_PFK9911:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK9911", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK9911(ITEMCODE As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9911 "
            SQL = SQL & " WHERE K9911_ItemCode		 = '" & ItemCode & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK9911", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK9911(z9911 As T9911_AREA) As Boolean
        WRITE_PFK9911 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z9911)

            SQL = " INSERT INTO PFK9911 "
            SQL = SQL & " ( "
            SQL = SQL & " K9911_ItemCode,"
            SQL = SQL & " K9911_ItemName,"
            SQL = SQL & " K9911_ItemNameSimply,"
            SQL = SQL & " K9911_ItemNameForeign1,"
            SQL = SQL & " K9911_ItemNameForeign2,"
            SQL = SQL & " K9911_ProdjectName,"
            SQL = SQL & " K9911_FormType,"
            SQL = SQL & " K9911_DataType,"
            SQL = SQL & " K9911_DataSize,"
            SQL = SQL & " K9911_DataDecimal,"
            SQL = SQL & " K9911_TextAlign,"
            SQL = SQL & " K9911_HorizontalAlignment,"
            SQL = SQL & " K9911_VerticalAlignment,"
            SQL = SQL & " K9911_SizeWidth,"
            SQL = SQL & " K9911_SizeHeight,"
            SQL = SQL & " K9911_BackColot,"
            SQL = SQL & " K9911_ForeColor,"
            SQL = SQL & " K9911_FontName,"
            SQL = SQL & " K9911_FontSize,"
            SQL = SQL & " K9911_FontBold,"
            SQL = SQL & " K9911_Lock,"
            SQL = SQL & " K9911_Hidden,"
            SQL = SQL & " K9911_CheckMerge,"
            SQL = SQL & " K9911_CheckMergePolicy,"
            SQL = SQL & " K9911_CheckHead,"
            SQL = SQL & " K9911_CheckHeadType,"
            SQL = SQL & " K9911_CheckDev,"
            SQL = SQL & " K9911_CheckDevValue,"
            SQL = SQL & " K9911_REMK "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z9911.ItemCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9911.ItemName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9911.ItemNameSimply) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9911.ItemNameForeign1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9911.ItemNameForeign2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9911.ProdjectName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9911.FormType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9911.DataType) & "', "
            SQL = SQL & "   " & FormatSQL(z9911.DataSize) & ", "
            SQL = SQL & "   " & FormatSQL(z9911.DataDecimal) & ", "
            SQL = SQL & "  N'" & FormatSQL(z9911.TextAlign) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9911.HorizontalAlignment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9911.VerticalAlignment) & "', "
            SQL = SQL & "   " & FormatSQL(z9911.SizeWidth) & ", "
            SQL = SQL & "   " & FormatSQL(z9911.SizeHeight) & ", "
            SQL = SQL & "  N'" & FormatSQL(z9911.BackColot) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9911.ForeColor) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9911.FontName) & "', "
            SQL = SQL & "   " & FormatSQL(z9911.FontSize) & ", "
            SQL = SQL & "  N'" & FormatSQL(z9911.FontBold) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9911.Lock) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9911.Hidden) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9911.CheckMerge) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9911.CheckMergePolicy) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9911.CheckHead) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9911.CheckHeadType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9911.CheckDev) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9911.CheckDevValue) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9911.REMK) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK9911 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK9911", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK9911(z9911 As T9911_AREA) As Boolean
        REWRITE_PFK9911 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z9911)

            SQL = " UPDATE PFK9911 SET "
            SQL = SQL & "    K9911_ItemName      = N'" & FormatSQL(z9911.ItemName) & "', "
            SQL = SQL & "    K9911_ItemNameSimply      = N'" & FormatSQL(z9911.ItemNameSimply) & "', "
            SQL = SQL & "    K9911_ItemNameForeign1      = N'" & FormatSQL(z9911.ItemNameForeign1) & "', "
            SQL = SQL & "    K9911_ItemNameForeign2      = N'" & FormatSQL(z9911.ItemNameForeign2) & "', "
            SQL = SQL & "    K9911_ProdjectName      = N'" & FormatSQL(z9911.ProdjectName) & "', "
            SQL = SQL & "    K9911_FormType      = N'" & FormatSQL(z9911.FormType) & "', "
            SQL = SQL & "    K9911_DataType      = N'" & FormatSQL(z9911.DataType) & "', "
            SQL = SQL & "    K9911_DataSize      =  " & FormatSQL(z9911.DataSize) & ", "
            SQL = SQL & "    K9911_DataDecimal      =  " & FormatSQL(z9911.DataDecimal) & ", "
            SQL = SQL & "    K9911_TextAlign      = N'" & FormatSQL(z9911.TextAlign) & "', "
            SQL = SQL & "    K9911_HorizontalAlignment      = N'" & FormatSQL(z9911.HorizontalAlignment) & "', "
            SQL = SQL & "    K9911_VerticalAlignment      = N'" & FormatSQL(z9911.VerticalAlignment) & "', "
            SQL = SQL & "    K9911_SizeWidth      =  " & FormatSQL(z9911.SizeWidth) & ", "
            SQL = SQL & "    K9911_SizeHeight      =  " & FormatSQL(z9911.SizeHeight) & ", "
            SQL = SQL & "    K9911_BackColot      = N'" & FormatSQL(z9911.BackColot) & "', "
            SQL = SQL & "    K9911_ForeColor      = N'" & FormatSQL(z9911.ForeColor) & "', "
            SQL = SQL & "    K9911_FontName      = N'" & FormatSQL(z9911.FontName) & "', "
            SQL = SQL & "    K9911_FontSize      =  " & FormatSQL(z9911.FontSize) & ", "
            SQL = SQL & "    K9911_FontBold      = N'" & FormatSQL(z9911.FontBold) & "', "
            SQL = SQL & "    K9911_Lock      = N'" & FormatSQL(z9911.Lock) & "', "
            SQL = SQL & "    K9911_Hidden      = N'" & FormatSQL(z9911.Hidden) & "', "
            SQL = SQL & "    K9911_CheckMerge      = N'" & FormatSQL(z9911.CheckMerge) & "', "
            SQL = SQL & "    K9911_CheckMergePolicy      = N'" & FormatSQL(z9911.CheckMergePolicy) & "', "
            SQL = SQL & "    K9911_CheckHead      = N'" & FormatSQL(z9911.CheckHead) & "', "
            SQL = SQL & "    K9911_CheckHeadType      = N'" & FormatSQL(z9911.CheckHeadType) & "', "
            SQL = SQL & "    K9911_CheckDev      = N'" & FormatSQL(z9911.CheckDev) & "', "
            SQL = SQL & "    K9911_CheckDevValue      = N'" & FormatSQL(z9911.CheckDevValue) & "', "
            SQL = SQL & "    K9911_REMK      = N'" & FormatSQL(z9911.REMK) & "'  "
            SQL = SQL & " WHERE K9911_ItemCode		 = '" & z9911.ItemCode & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK9911 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK9911", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK9911(z9911 As T9911_AREA) As Boolean
        DELETE_PFK9911 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK9911 "
            SQL = SQL & " WHERE K9911_ItemCode		 = '" & z9911.ItemCode & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK9911 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK9911", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D9911_CLEAR()
        Try

            D9911.ItemCode = ""
            D9911.ItemName = ""
            D9911.ItemNameSimply = ""
            D9911.ItemNameForeign1 = ""
            D9911.ItemNameForeign2 = ""
            D9911.ProdjectName = ""
            D9911.FormType = ""
            D9911.DataType = ""
            D9911.DataSize = 0
            D9911.DataDecimal = 0
            D9911.TextAlign = ""
            D9911.HorizontalAlignment = ""
            D9911.VerticalAlignment = ""
            D9911.SizeWidth = 0
            D9911.SizeHeight = 0
            D9911.BackColot = ""
            D9911.ForeColor = ""
            D9911.FontName = ""
            D9911.FontSize = 0
            D9911.FontBold = ""
            D9911.Lock = ""
            D9911.Hidden = ""
            D9911.CheckMerge = ""
            D9911.CheckMergePolicy = ""
            D9911.CheckHead = ""
            D9911.CheckHeadType = ""
            D9911.CheckDev = ""
            D9911.CheckDevValue = ""
            D9911.REMK = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D9911_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x9911 As T9911_AREA)
        Try

            x9911.ItemCode = trim$(x9911.ItemCode)
            x9911.ItemName = trim$(x9911.ItemName)
            x9911.ItemNameSimply = trim$(x9911.ItemNameSimply)
            x9911.ItemNameForeign1 = trim$(x9911.ItemNameForeign1)
            x9911.ItemNameForeign2 = trim$(x9911.ItemNameForeign2)
            x9911.ProdjectName = trim$(x9911.ProdjectName)
            x9911.FormType = trim$(x9911.FormType)
            x9911.DataType = trim$(x9911.DataType)
            x9911.DataSize = trim$(x9911.DataSize)
            x9911.DataDecimal = trim$(x9911.DataDecimal)
            x9911.TextAlign = trim$(x9911.TextAlign)
            x9911.HorizontalAlignment = trim$(x9911.HorizontalAlignment)
            x9911.VerticalAlignment = trim$(x9911.VerticalAlignment)
            x9911.SizeWidth = trim$(x9911.SizeWidth)
            x9911.SizeHeight = trim$(x9911.SizeHeight)
            x9911.BackColot = trim$(x9911.BackColot)
            x9911.ForeColor = trim$(x9911.ForeColor)
            x9911.FontName = trim$(x9911.FontName)
            x9911.FontSize = trim$(x9911.FontSize)
            x9911.FontBold = trim$(x9911.FontBold)
            x9911.Lock = trim$(x9911.Lock)
            x9911.Hidden = trim$(x9911.Hidden)
            x9911.CheckMerge = trim$(x9911.CheckMerge)
            x9911.CheckMergePolicy = trim$(x9911.CheckMergePolicy)
            x9911.CheckHead = trim$(x9911.CheckHead)
            x9911.CheckHeadType = trim$(x9911.CheckHeadType)
            x9911.CheckDev = trim$(x9911.CheckDev)
            x9911.CheckDevValue = trim$(x9911.CheckDevValue)
            x9911.REMK = trim$(x9911.REMK)

            If trim$(x9911.ItemCode) = "" Then x9911.ItemCode = Space(1)
            If trim$(x9911.ItemName) = "" Then x9911.ItemName = Space(1)
            If trim$(x9911.ItemNameSimply) = "" Then x9911.ItemNameSimply = Space(1)
            If trim$(x9911.ItemNameForeign1) = "" Then x9911.ItemNameForeign1 = Space(1)
            If trim$(x9911.ItemNameForeign2) = "" Then x9911.ItemNameForeign2 = Space(1)
            If trim$(x9911.ProdjectName) = "" Then x9911.ProdjectName = Space(1)
            If trim$(x9911.FormType) = "" Then x9911.FormType = Space(1)
            If trim$(x9911.DataType) = "" Then x9911.DataType = Space(1)
            If trim$(x9911.DataSize) = "" Then x9911.DataSize = 0
            If trim$(x9911.DataDecimal) = "" Then x9911.DataDecimal = 0
            If trim$(x9911.TextAlign) = "" Then x9911.TextAlign = Space(1)
            If trim$(x9911.HorizontalAlignment) = "" Then x9911.HorizontalAlignment = Space(1)
            If trim$(x9911.VerticalAlignment) = "" Then x9911.VerticalAlignment = Space(1)
            If trim$(x9911.SizeWidth) = "" Then x9911.SizeWidth = 0
            If trim$(x9911.SizeHeight) = "" Then x9911.SizeHeight = 0
            If trim$(x9911.BackColot) = "" Then x9911.BackColot = Space(1)
            If trim$(x9911.ForeColor) = "" Then x9911.ForeColor = Space(1)
            If trim$(x9911.FontName) = "" Then x9911.FontName = Space(1)
            If trim$(x9911.FontSize) = "" Then x9911.FontSize = 0
            If trim$(x9911.FontBold) = "" Then x9911.FontBold = Space(1)
            If trim$(x9911.Lock) = "" Then x9911.Lock = Space(1)
            If trim$(x9911.Hidden) = "" Then x9911.Hidden = Space(1)
            If trim$(x9911.CheckMerge) = "" Then x9911.CheckMerge = Space(1)
            If trim$(x9911.CheckMergePolicy) = "" Then x9911.CheckMergePolicy = Space(1)
            If trim$(x9911.CheckHead) = "" Then x9911.CheckHead = Space(1)
            If trim$(x9911.CheckHeadType) = "" Then x9911.CheckHeadType = Space(1)
            If trim$(x9911.CheckDev) = "" Then x9911.CheckDev = Space(1)
            If trim$(x9911.CheckDevValue) = "" Then x9911.CheckDevValue = Space(1)
            If trim$(x9911.REMK) = "" Then x9911.REMK = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K9911_MOVE(rs9911 As SqlClient.SqlDataReader)
        Try

            Call D9911_CLEAR()

            If IsdbNull(rs9911!K9911_ItemCode) = False Then D9911.ItemCode = Trim$(rs9911!K9911_ItemCode)
            If IsdbNull(rs9911!K9911_ItemName) = False Then D9911.ItemName = Trim$(rs9911!K9911_ItemName)
            If IsdbNull(rs9911!K9911_ItemNameSimply) = False Then D9911.ItemNameSimply = Trim$(rs9911!K9911_ItemNameSimply)
            If IsdbNull(rs9911!K9911_ItemNameForeign1) = False Then D9911.ItemNameForeign1 = Trim$(rs9911!K9911_ItemNameForeign1)
            If IsdbNull(rs9911!K9911_ItemNameForeign2) = False Then D9911.ItemNameForeign2 = Trim$(rs9911!K9911_ItemNameForeign2)
            If IsdbNull(rs9911!K9911_ProdjectName) = False Then D9911.ProdjectName = Trim$(rs9911!K9911_ProdjectName)
            If IsdbNull(rs9911!K9911_FormType) = False Then D9911.FormType = Trim$(rs9911!K9911_FormType)
            If IsdbNull(rs9911!K9911_DataType) = False Then D9911.DataType = Trim$(rs9911!K9911_DataType)
            If IsdbNull(rs9911!K9911_DataSize) = False Then D9911.DataSize = Trim$(rs9911!K9911_DataSize)
            If IsdbNull(rs9911!K9911_DataDecimal) = False Then D9911.DataDecimal = Trim$(rs9911!K9911_DataDecimal)
            If IsdbNull(rs9911!K9911_TextAlign) = False Then D9911.TextAlign = Trim$(rs9911!K9911_TextAlign)
            If IsdbNull(rs9911!K9911_HorizontalAlignment) = False Then D9911.HorizontalAlignment = Trim$(rs9911!K9911_HorizontalAlignment)
            If IsdbNull(rs9911!K9911_VerticalAlignment) = False Then D9911.VerticalAlignment = Trim$(rs9911!K9911_VerticalAlignment)
            If IsdbNull(rs9911!K9911_SizeWidth) = False Then D9911.SizeWidth = Trim$(rs9911!K9911_SizeWidth)
            If IsdbNull(rs9911!K9911_SizeHeight) = False Then D9911.SizeHeight = Trim$(rs9911!K9911_SizeHeight)
            If IsdbNull(rs9911!K9911_BackColot) = False Then D9911.BackColot = Trim$(rs9911!K9911_BackColot)
            If IsdbNull(rs9911!K9911_ForeColor) = False Then D9911.ForeColor = Trim$(rs9911!K9911_ForeColor)
            If IsdbNull(rs9911!K9911_FontName) = False Then D9911.FontName = Trim$(rs9911!K9911_FontName)
            If IsdbNull(rs9911!K9911_FontSize) = False Then D9911.FontSize = Trim$(rs9911!K9911_FontSize)
            If IsdbNull(rs9911!K9911_FontBold) = False Then D9911.FontBold = Trim$(rs9911!K9911_FontBold)
            If IsdbNull(rs9911!K9911_Lock) = False Then D9911.Lock = Trim$(rs9911!K9911_Lock)
            If IsdbNull(rs9911!K9911_Hidden) = False Then D9911.Hidden = Trim$(rs9911!K9911_Hidden)
            If IsdbNull(rs9911!K9911_CheckMerge) = False Then D9911.CheckMerge = Trim$(rs9911!K9911_CheckMerge)
            If IsdbNull(rs9911!K9911_CheckMergePolicy) = False Then D9911.CheckMergePolicy = Trim$(rs9911!K9911_CheckMergePolicy)
            If IsdbNull(rs9911!K9911_CheckHead) = False Then D9911.CheckHead = Trim$(rs9911!K9911_CheckHead)
            If IsdbNull(rs9911!K9911_CheckHeadType) = False Then D9911.CheckHeadType = Trim$(rs9911!K9911_CheckHeadType)
            If IsdbNull(rs9911!K9911_CheckDev) = False Then D9911.CheckDev = Trim$(rs9911!K9911_CheckDev)
            If IsdbNull(rs9911!K9911_CheckDevValue) = False Then D9911.CheckDevValue = Trim$(rs9911!K9911_CheckDevValue)
            If IsdbNull(rs9911!K9911_REMK) = False Then D9911.REMK = Trim$(rs9911!K9911_REMK)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K9911_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K9911_MOVE(rs9911 As DataRow)
        Try

            Call D9911_CLEAR()

            If IsdbNull(rs9911!K9911_ItemCode) = False Then D9911.ItemCode = Trim$(rs9911!K9911_ItemCode)
            If IsdbNull(rs9911!K9911_ItemName) = False Then D9911.ItemName = Trim$(rs9911!K9911_ItemName)
            If IsdbNull(rs9911!K9911_ItemNameSimply) = False Then D9911.ItemNameSimply = Trim$(rs9911!K9911_ItemNameSimply)
            If IsdbNull(rs9911!K9911_ItemNameForeign1) = False Then D9911.ItemNameForeign1 = Trim$(rs9911!K9911_ItemNameForeign1)
            If IsdbNull(rs9911!K9911_ItemNameForeign2) = False Then D9911.ItemNameForeign2 = Trim$(rs9911!K9911_ItemNameForeign2)
            If IsdbNull(rs9911!K9911_ProdjectName) = False Then D9911.ProdjectName = Trim$(rs9911!K9911_ProdjectName)
            If IsdbNull(rs9911!K9911_FormType) = False Then D9911.FormType = Trim$(rs9911!K9911_FormType)
            If IsdbNull(rs9911!K9911_DataType) = False Then D9911.DataType = Trim$(rs9911!K9911_DataType)
            If IsdbNull(rs9911!K9911_DataSize) = False Then D9911.DataSize = Trim$(rs9911!K9911_DataSize)
            If IsdbNull(rs9911!K9911_DataDecimal) = False Then D9911.DataDecimal = Trim$(rs9911!K9911_DataDecimal)
            If IsdbNull(rs9911!K9911_TextAlign) = False Then D9911.TextAlign = Trim$(rs9911!K9911_TextAlign)
            If IsdbNull(rs9911!K9911_HorizontalAlignment) = False Then D9911.HorizontalAlignment = Trim$(rs9911!K9911_HorizontalAlignment)
            If IsdbNull(rs9911!K9911_VerticalAlignment) = False Then D9911.VerticalAlignment = Trim$(rs9911!K9911_VerticalAlignment)
            If IsdbNull(rs9911!K9911_SizeWidth) = False Then D9911.SizeWidth = Trim$(rs9911!K9911_SizeWidth)
            If IsdbNull(rs9911!K9911_SizeHeight) = False Then D9911.SizeHeight = Trim$(rs9911!K9911_SizeHeight)
            If IsdbNull(rs9911!K9911_BackColot) = False Then D9911.BackColot = Trim$(rs9911!K9911_BackColot)
            If IsdbNull(rs9911!K9911_ForeColor) = False Then D9911.ForeColor = Trim$(rs9911!K9911_ForeColor)
            If IsdbNull(rs9911!K9911_FontName) = False Then D9911.FontName = Trim$(rs9911!K9911_FontName)
            If IsdbNull(rs9911!K9911_FontSize) = False Then D9911.FontSize = Trim$(rs9911!K9911_FontSize)
            If IsdbNull(rs9911!K9911_FontBold) = False Then D9911.FontBold = Trim$(rs9911!K9911_FontBold)
            If IsdbNull(rs9911!K9911_Lock) = False Then D9911.Lock = Trim$(rs9911!K9911_Lock)
            If IsdbNull(rs9911!K9911_Hidden) = False Then D9911.Hidden = Trim$(rs9911!K9911_Hidden)
            If IsdbNull(rs9911!K9911_CheckMerge) = False Then D9911.CheckMerge = Trim$(rs9911!K9911_CheckMerge)
            If IsdbNull(rs9911!K9911_CheckMergePolicy) = False Then D9911.CheckMergePolicy = Trim$(rs9911!K9911_CheckMergePolicy)
            If IsdbNull(rs9911!K9911_CheckHead) = False Then D9911.CheckHead = Trim$(rs9911!K9911_CheckHead)
            If IsdbNull(rs9911!K9911_CheckHeadType) = False Then D9911.CheckHeadType = Trim$(rs9911!K9911_CheckHeadType)
            If IsdbNull(rs9911!K9911_CheckDev) = False Then D9911.CheckDev = Trim$(rs9911!K9911_CheckDev)
            If IsdbNull(rs9911!K9911_CheckDevValue) = False Then D9911.CheckDevValue = Trim$(rs9911!K9911_CheckDevValue)
            If IsdbNull(rs9911!K9911_REMK) = False Then D9911.REMK = Trim$(rs9911!K9911_REMK)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K9911_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K9911_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z9911 As T9911_AREA, ITEMCODE As String) As Boolean

        K9911_MOVE = False

        Try
            If READ_PFK9911(ITEMCODE) = True Then
                z9911 = D9911
                K9911_MOVE = True
            Else
                z9911 = Nothing
            End If

            If getColumIndex(spr, "ItemCode") > -1 Then z9911.ItemCode = getDataM(spr, getColumIndex(spr, "ItemCode"), xRow)
            If getColumIndex(spr, "ItemName") > -1 Then z9911.ItemName = getDataM(spr, getColumIndex(spr, "ItemName"), xRow)
            If getColumIndex(spr, "ItemNameSimply") > -1 Then z9911.ItemNameSimply = getDataM(spr, getColumIndex(spr, "ItemNameSimply"), xRow)
            If getColumIndex(spr, "ItemNameForeign1") > -1 Then z9911.ItemNameForeign1 = getDataM(spr, getColumIndex(spr, "ItemNameForeign1"), xRow)
            If getColumIndex(spr, "ItemNameForeign2") > -1 Then z9911.ItemNameForeign2 = getDataM(spr, getColumIndex(spr, "ItemNameForeign2"), xRow)
            If getColumIndex(spr, "ProdjectName") > -1 Then z9911.ProdjectName = getDataM(spr, getColumIndex(spr, "ProdjectName"), xRow)
            If getColumIndex(spr, "FormType") > -1 Then z9911.FormType = getDataM(spr, getColumIndex(spr, "FormType"), xRow)
            If getColumIndex(spr, "DataType") > -1 Then z9911.DataType = getDataM(spr, getColumIndex(spr, "DataType"), xRow)
            If getColumIndex(spr, "DataSize") > -1 Then z9911.DataSize = getDataM(spr, getColumIndex(spr, "DataSize"), xRow)
            If getColumIndex(spr, "DataDecimal") > -1 Then z9911.DataDecimal = getDataM(spr, getColumIndex(spr, "DataDecimal"), xRow)
            If getColumIndex(spr, "TextAlign") > -1 Then z9911.TextAlign = getDataM(spr, getColumIndex(spr, "TextAlign"), xRow)
            If getColumIndex(spr, "HorizontalAlignment") > -1 Then z9911.HorizontalAlignment = getDataM(spr, getColumIndex(spr, "HorizontalAlignment"), xRow)
            If getColumIndex(spr, "VerticalAlignment") > -1 Then z9911.VerticalAlignment = getDataM(spr, getColumIndex(spr, "VerticalAlignment"), xRow)
            If getColumIndex(spr, "SizeWidth") > -1 Then z9911.SizeWidth = getDataM(spr, getColumIndex(spr, "SizeWidth"), xRow)
            If getColumIndex(spr, "SizeHeight") > -1 Then z9911.SizeHeight = getDataM(spr, getColumIndex(spr, "SizeHeight"), xRow)
            If getColumIndex(spr, "BackColot") > -1 Then z9911.BackColot = getDataM(spr, getColumIndex(spr, "BackColot"), xRow)
            If getColumIndex(spr, "ForeColor") > -1 Then z9911.ForeColor = getDataM(spr, getColumIndex(spr, "ForeColor"), xRow)
            If getColumIndex(spr, "FontName") > -1 Then z9911.FontName = getDataM(spr, getColumIndex(spr, "FontName"), xRow)
            If getColumIndex(spr, "FontSize") > -1 Then z9911.FontSize = getDataM(spr, getColumIndex(spr, "FontSize"), xRow)
            If getColumIndex(spr, "FontBold") > -1 Then z9911.FontBold = getDataM(spr, getColumIndex(spr, "FontBold"), xRow)
            If getColumIndex(spr, "Lock") > -1 Then z9911.Lock = getDataM(spr, getColumIndex(spr, "Lock"), xRow)
            If getColumIndex(spr, "Hidden") > -1 Then z9911.Hidden = getDataM(spr, getColumIndex(spr, "Hidden"), xRow)
            If getColumIndex(spr, "CheckMerge") > -1 Then z9911.CheckMerge = getDataM(spr, getColumIndex(spr, "CheckMerge"), xRow)
            If getColumIndex(spr, "CheckMergePolicy") > -1 Then z9911.CheckMergePolicy = getDataM(spr, getColumIndex(spr, "CheckMergePolicy"), xRow)
            If getColumIndex(spr, "CheckHead") > -1 Then z9911.CheckHead = getDataM(spr, getColumIndex(spr, "CheckHead"), xRow)
            If getColumIndex(spr, "CheckHeadType") > -1 Then z9911.CheckHeadType = getDataM(spr, getColumIndex(spr, "CheckHeadType"), xRow)
            If getColumIndex(spr, "CheckDev") > -1 Then z9911.CheckDev = getDataM(spr, getColumIndex(spr, "CheckDev"), xRow)
            If getColumIndex(spr, "CheckDevValue") > -1 Then z9911.CheckDevValue = getDataM(spr, getColumIndex(spr, "CheckDevValue"), xRow)
            If getColumIndex(spr, "REMK") > -1 Then z9911.REMK = getDataM(spr, getColumIndex(spr, "REMK"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9911_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K9911_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z9911 As T9911_AREA, CheckClear As Boolean, ITEMCODE As String) As Boolean

        K9911_MOVE = False

        Try
            If READ_PFK9911(ITEMCODE) = True Then
                z9911 = D9911
                K9911_MOVE = True
            Else
                If CheckClear = True Then z9911 = Nothing
            End If

            If getColumIndex(spr, "ItemCode") > -1 Then z9911.ItemCode = getDataM(spr, getColumIndex(spr, "ItemCode"), xRow)
            If getColumIndex(spr, "ItemName") > -1 Then z9911.ItemName = getDataM(spr, getColumIndex(spr, "ItemName"), xRow)
            If getColumIndex(spr, "ItemNameSimply") > -1 Then z9911.ItemNameSimply = getDataM(spr, getColumIndex(spr, "ItemNameSimply"), xRow)
            If getColumIndex(spr, "ItemNameForeign1") > -1 Then z9911.ItemNameForeign1 = getDataM(spr, getColumIndex(spr, "ItemNameForeign1"), xRow)
            If getColumIndex(spr, "ItemNameForeign2") > -1 Then z9911.ItemNameForeign2 = getDataM(spr, getColumIndex(spr, "ItemNameForeign2"), xRow)
            If getColumIndex(spr, "ProdjectName") > -1 Then z9911.ProdjectName = getDataM(spr, getColumIndex(spr, "ProdjectName"), xRow)
            If getColumIndex(spr, "FormType") > -1 Then z9911.FormType = getDataM(spr, getColumIndex(spr, "FormType"), xRow)
            If getColumIndex(spr, "DataType") > -1 Then z9911.DataType = getDataM(spr, getColumIndex(spr, "DataType"), xRow)
            If getColumIndex(spr, "DataSize") > -1 Then z9911.DataSize = getDataM(spr, getColumIndex(spr, "DataSize"), xRow)
            If getColumIndex(spr, "DataDecimal") > -1 Then z9911.DataDecimal = getDataM(spr, getColumIndex(spr, "DataDecimal"), xRow)
            If getColumIndex(spr, "TextAlign") > -1 Then z9911.TextAlign = getDataM(spr, getColumIndex(spr, "TextAlign"), xRow)
            If getColumIndex(spr, "HorizontalAlignment") > -1 Then z9911.HorizontalAlignment = getDataM(spr, getColumIndex(spr, "HorizontalAlignment"), xRow)
            If getColumIndex(spr, "VerticalAlignment") > -1 Then z9911.VerticalAlignment = getDataM(spr, getColumIndex(spr, "VerticalAlignment"), xRow)
            If getColumIndex(spr, "SizeWidth") > -1 Then z9911.SizeWidth = getDataM(spr, getColumIndex(spr, "SizeWidth"), xRow)
            If getColumIndex(spr, "SizeHeight") > -1 Then z9911.SizeHeight = getDataM(spr, getColumIndex(spr, "SizeHeight"), xRow)
            If getColumIndex(spr, "BackColot") > -1 Then z9911.BackColot = getDataM(spr, getColumIndex(spr, "BackColot"), xRow)
            If getColumIndex(spr, "ForeColor") > -1 Then z9911.ForeColor = getDataM(spr, getColumIndex(spr, "ForeColor"), xRow)
            If getColumIndex(spr, "FontName") > -1 Then z9911.FontName = getDataM(spr, getColumIndex(spr, "FontName"), xRow)
            If getColumIndex(spr, "FontSize") > -1 Then z9911.FontSize = getDataM(spr, getColumIndex(spr, "FontSize"), xRow)
            If getColumIndex(spr, "FontBold") > -1 Then z9911.FontBold = getDataM(spr, getColumIndex(spr, "FontBold"), xRow)
            If getColumIndex(spr, "Lock") > -1 Then z9911.Lock = getDataM(spr, getColumIndex(spr, "Lock"), xRow)
            If getColumIndex(spr, "Hidden") > -1 Then z9911.Hidden = getDataM(spr, getColumIndex(spr, "Hidden"), xRow)
            If getColumIndex(spr, "CheckMerge") > -1 Then z9911.CheckMerge = getDataM(spr, getColumIndex(spr, "CheckMerge"), xRow)
            If getColumIndex(spr, "CheckMergePolicy") > -1 Then z9911.CheckMergePolicy = getDataM(spr, getColumIndex(spr, "CheckMergePolicy"), xRow)
            If getColumIndex(spr, "CheckHead") > -1 Then z9911.CheckHead = getDataM(spr, getColumIndex(spr, "CheckHead"), xRow)
            If getColumIndex(spr, "CheckHeadType") > -1 Then z9911.CheckHeadType = getDataM(spr, getColumIndex(spr, "CheckHeadType"), xRow)
            If getColumIndex(spr, "CheckDev") > -1 Then z9911.CheckDev = getDataM(spr, getColumIndex(spr, "CheckDev"), xRow)
            If getColumIndex(spr, "CheckDevValue") > -1 Then z9911.CheckDevValue = getDataM(spr, getColumIndex(spr, "CheckDevValue"), xRow)
            If getColumIndex(spr, "REMK") > -1 Then z9911.REMK = getDataM(spr, getColumIndex(spr, "REMK"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9911_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K9911_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z9911 As T9911_AREA, Job As String, ITEMCODE As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K9911_MOVE = False

        Try
            If READ_PFK9911(ITEMCODE) = True Then
                z9911 = D9911
                K9911_MOVE = True
            Else
                z9911 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9911")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "ITEMCODE" : z9911.ItemCode = Children(i).Code
                                Case "ITEMNAME" : z9911.ItemName = Children(i).Code
                                Case "ITEMNAMESIMPLY" : z9911.ItemNameSimply = Children(i).Code
                                Case "ITEMNAMEFOREIGN1" : z9911.ItemNameForeign1 = Children(i).Code
                                Case "ITEMNAMEFOREIGN2" : z9911.ItemNameForeign2 = Children(i).Code
                                Case "PRODJECTNAME" : z9911.ProdjectName = Children(i).Code
                                Case "FORMTYPE" : z9911.FormType = Children(i).Code
                                Case "DATATYPE" : z9911.DataType = Children(i).Code
                                Case "DATASIZE" : z9911.DataSize = Children(i).Code
                                Case "DATADECIMAL" : z9911.DataDecimal = Children(i).Code
                                Case "TEXTALIGN" : z9911.TextAlign = Children(i).Code
                                Case "HORIZONTALALIGNMENT" : z9911.HorizontalAlignment = Children(i).Code
                                Case "VERTICALALIGNMENT" : z9911.VerticalAlignment = Children(i).Code
                                Case "SIZEWIDTH" : z9911.SizeWidth = Children(i).Code
                                Case "SIZEHEIGHT" : z9911.SizeHeight = Children(i).Code
                                Case "BACKCOLOT" : z9911.BackColot = Children(i).Code
                                Case "FORECOLOR" : z9911.ForeColor = Children(i).Code
                                Case "FONTNAME" : z9911.FontName = Children(i).Code
                                Case "FONTSIZE" : z9911.FontSize = Children(i).Code
                                Case "FONTBOLD" : z9911.FontBold = Children(i).Code
                                Case "LOCK" : z9911.Lock = Children(i).Code
                                Case "HIDDEN" : z9911.Hidden = Children(i).Code
                                Case "CHECKMERGE" : z9911.CheckMerge = Children(i).Code
                                Case "CHECKMERGEPOLICY" : z9911.CheckMergePolicy = Children(i).Code
                                Case "CHECKHEAD" : z9911.CheckHead = Children(i).Code
                                Case "CHECKHEADTYPE" : z9911.CheckHeadType = Children(i).Code
                                Case "CHECKDEV" : z9911.CheckDev = Children(i).Code
                                Case "CHECKDEVVALUE" : z9911.CheckDevValue = Children(i).Code
                                Case "REMK" : z9911.REMK = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "ITEMCODE" : z9911.ItemCode = Children(i).Data
                                Case "ITEMNAME" : z9911.ItemName = Children(i).Data
                                Case "ITEMNAMESIMPLY" : z9911.ItemNameSimply = Children(i).Data
                                Case "ITEMNAMEFOREIGN1" : z9911.ItemNameForeign1 = Children(i).Data
                                Case "ITEMNAMEFOREIGN2" : z9911.ItemNameForeign2 = Children(i).Data
                                Case "PRODJECTNAME" : z9911.ProdjectName = Children(i).Data
                                Case "FORMTYPE" : z9911.FormType = Children(i).Data
                                Case "DATATYPE" : z9911.DataType = Children(i).Data
                                Case "DATASIZE" : z9911.DataSize = Children(i).Data
                                Case "DATADECIMAL" : z9911.DataDecimal = Children(i).Data
                                Case "TEXTALIGN" : z9911.TextAlign = Children(i).Data
                                Case "HORIZONTALALIGNMENT" : z9911.HorizontalAlignment = Children(i).Data
                                Case "VERTICALALIGNMENT" : z9911.VerticalAlignment = Children(i).Data
                                Case "SIZEWIDTH" : z9911.SizeWidth = Children(i).Data
                                Case "SIZEHEIGHT" : z9911.SizeHeight = Children(i).Data
                                Case "BACKCOLOT" : z9911.BackColot = Children(i).Data
                                Case "FORECOLOR" : z9911.ForeColor = Children(i).Data
                                Case "FONTNAME" : z9911.FontName = Children(i).Data
                                Case "FONTSIZE" : z9911.FontSize = Children(i).Data
                                Case "FONTBOLD" : z9911.FontBold = Children(i).Data
                                Case "LOCK" : z9911.Lock = Children(i).Data
                                Case "HIDDEN" : z9911.Hidden = Children(i).Data
                                Case "CHECKMERGE" : z9911.CheckMerge = Children(i).Data
                                Case "CHECKMERGEPOLICY" : z9911.CheckMergePolicy = Children(i).Data
                                Case "CHECKHEAD" : z9911.CheckHead = Children(i).Data
                                Case "CHECKHEADTYPE" : z9911.CheckHeadType = Children(i).Data
                                Case "CHECKDEV" : z9911.CheckDev = Children(i).Data
                                Case "CHECKDEVVALUE" : z9911.CheckDevValue = Children(i).Data
                                Case "REMK" : z9911.REMK = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9911_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K9911_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z9911 As T9911_AREA, Job As String, CheckClear As Boolean, ITEMCODE As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K9911_MOVE = False

        Try
            If READ_PFK9911(ITEMCODE) = True Then
                z9911 = D9911
                K9911_MOVE = True
            Else
                If CheckClear = True Then z9911 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9911")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "ITEMCODE" : z9911.ItemCode = Children(i).Code
                                Case "ITEMNAME" : z9911.ItemName = Children(i).Code
                                Case "ITEMNAMESIMPLY" : z9911.ItemNameSimply = Children(i).Code
                                Case "ITEMNAMEFOREIGN1" : z9911.ItemNameForeign1 = Children(i).Code
                                Case "ITEMNAMEFOREIGN2" : z9911.ItemNameForeign2 = Children(i).Code
                                Case "PRODJECTNAME" : z9911.ProdjectName = Children(i).Code
                                Case "FORMTYPE" : z9911.FormType = Children(i).Code
                                Case "DATATYPE" : z9911.DataType = Children(i).Code
                                Case "DATASIZE" : z9911.DataSize = Children(i).Code
                                Case "DATADECIMAL" : z9911.DataDecimal = Children(i).Code
                                Case "TEXTALIGN" : z9911.TextAlign = Children(i).Code
                                Case "HORIZONTALALIGNMENT" : z9911.HorizontalAlignment = Children(i).Code
                                Case "VERTICALALIGNMENT" : z9911.VerticalAlignment = Children(i).Code
                                Case "SIZEWIDTH" : z9911.SizeWidth = Children(i).Code
                                Case "SIZEHEIGHT" : z9911.SizeHeight = Children(i).Code
                                Case "BACKCOLOT" : z9911.BackColot = Children(i).Code
                                Case "FORECOLOR" : z9911.ForeColor = Children(i).Code
                                Case "FONTNAME" : z9911.FontName = Children(i).Code
                                Case "FONTSIZE" : z9911.FontSize = Children(i).Code
                                Case "FONTBOLD" : z9911.FontBold = Children(i).Code
                                Case "LOCK" : z9911.Lock = Children(i).Code
                                Case "HIDDEN" : z9911.Hidden = Children(i).Code
                                Case "CHECKMERGE" : z9911.CheckMerge = Children(i).Code
                                Case "CHECKMERGEPOLICY" : z9911.CheckMergePolicy = Children(i).Code
                                Case "CHECKHEAD" : z9911.CheckHead = Children(i).Code
                                Case "CHECKHEADTYPE" : z9911.CheckHeadType = Children(i).Code
                                Case "CHECKDEV" : z9911.CheckDev = Children(i).Code
                                Case "CHECKDEVVALUE" : z9911.CheckDevValue = Children(i).Code
                                Case "REMK" : z9911.REMK = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "ITEMCODE" : z9911.ItemCode = Children(i).Data
                                Case "ITEMNAME" : z9911.ItemName = Children(i).Data
                                Case "ITEMNAMESIMPLY" : z9911.ItemNameSimply = Children(i).Data
                                Case "ITEMNAMEFOREIGN1" : z9911.ItemNameForeign1 = Children(i).Data
                                Case "ITEMNAMEFOREIGN2" : z9911.ItemNameForeign2 = Children(i).Data
                                Case "PRODJECTNAME" : z9911.ProdjectName = Children(i).Data
                                Case "FORMTYPE" : z9911.FormType = Children(i).Data
                                Case "DATATYPE" : z9911.DataType = Children(i).Data
                                Case "DATASIZE" : z9911.DataSize = Children(i).Data
                                Case "DATADECIMAL" : z9911.DataDecimal = Children(i).Data
                                Case "TEXTALIGN" : z9911.TextAlign = Children(i).Data
                                Case "HORIZONTALALIGNMENT" : z9911.HorizontalAlignment = Children(i).Data
                                Case "VERTICALALIGNMENT" : z9911.VerticalAlignment = Children(i).Data
                                Case "SIZEWIDTH" : z9911.SizeWidth = Children(i).Data
                                Case "SIZEHEIGHT" : z9911.SizeHeight = Children(i).Data
                                Case "BACKCOLOT" : z9911.BackColot = Children(i).Data
                                Case "FORECOLOR" : z9911.ForeColor = Children(i).Data
                                Case "FONTNAME" : z9911.FontName = Children(i).Data
                                Case "FONTSIZE" : z9911.FontSize = Children(i).Data
                                Case "FONTBOLD" : z9911.FontBold = Children(i).Data
                                Case "LOCK" : z9911.Lock = Children(i).Data
                                Case "HIDDEN" : z9911.Hidden = Children(i).Data
                                Case "CHECKMERGE" : z9911.CheckMerge = Children(i).Data
                                Case "CHECKMERGEPOLICY" : z9911.CheckMergePolicy = Children(i).Data
                                Case "CHECKHEAD" : z9911.CheckHead = Children(i).Data
                                Case "CHECKHEADTYPE" : z9911.CheckHeadType = Children(i).Data
                                Case "CHECKDEV" : z9911.CheckDev = Children(i).Data
                                Case "CHECKDEVVALUE" : z9911.CheckDevValue = Children(i).Data
                                Case "REMK" : z9911.REMK = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9911_MOVE", vbCritical)
        End Try
    End Function

End Module
