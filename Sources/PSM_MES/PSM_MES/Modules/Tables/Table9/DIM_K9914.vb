'=========================================================================================================================================================
'   TABLE : (PFK9914)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K9914

    Structure T9914_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public ProdjectName As String  '			nvarchar(10)		*
        Public ProgramNo As String  '			varchar(100)		*
        Public SheetName As String  '			varchar(10)		*
        Public ColsFrozen As Double  '			decimal
        Public RowsFrozen As Double  '			decimal
        Public MaxRows As Double  '			decimal
        Public OperationMode As String  '			char(1)
        Public Lock As String  '			char(1)
        Public DefaultRowHeight As String  '			char(1)
        Public HeaderTextMode As String  '			char(1)
        Public RetainSelectionBlock As String  '			char(1)
        Public AutoClip As String  '			char(1)
        Public Header As String  '			char(1)
        Public HeaderColumn As String  '			char(1)
        Public HeaderRow As String  '			char(1)
        Public Separate As String  '			char(1)
        Public TotalSeparate As String  '			char(1)
        Public ColumnBase As String  '			varchar(200)
        Public ColumnCal As String  '			varchar(200)
        Public Merge As String  '			char(1)
        Public MergeColumn As String  '			varchar(50)
        Public MergeRetrict As String  '			varchar(50)
        Public BackColorCheck As String  '			char(1)
        Public BackColor As String  '			nvarchar(50)
        Public AreaColorCheck As String  '			char(1)
        Public AreaColor As String  '			nvarchar(50)
        Public Fontsize As Double  '			decimal

        Public FixSize As String  '			nvarchar(50)
        Public ZoomSize As Double  '			decimal

        Public Rowheight As Double  '			decimal
        Public CheckColumnSpan As String  '			char(1)
        Public ColHeader1 As Double  '			decimal
        Public ColHeader2 As Double  '			decimal
        Public ColumnSpanID As Double  '			decimal
        Public Footer As String  '			char(1)
        Public Chart As String  '			char(1)
        Public ChartType As String  '			char(1)
        Public ChartVisible As String  '			char(1)
        Public MoveColumn As String  '			char(1)
        Public MoveRow As String  '			char(1)
        Public NameChart As String  '			nvarchar(50)
        Public Line As String  '			nvarchar(10)
        Public LineBase As String  '			nvarchar(50)
        Public BarBase As String  '			nvarchar(50)
        Public PieBase As String  '			nvarchar(50)
        Public REMK As String  '			nvarchar(100)
        '=========================================================================================================================================================
    End Structure

    Public D9914 As T9914_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK9914(PRODJECTNAME As String, PROGRAMNO As String, SHEETNAME As String) As Boolean
        READ_PFK9914 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9914 "
            SQL = SQL & " WHERE K9914_ProdjectName		 = '" & ProdjectName & "' "
            SQL = SQL & "   AND K9914_ProgramNo		 = '" & ProgramNo & "' "
            SQL = SQL & "   AND K9914_SheetName		 = '" & SheetName & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9914_CLEAR() : GoTo SKIP_READ_PFK9914

            Call K9914_MOVE(rd)
            READ_PFK9914 = True

SKIP_READ_PFK9914:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK9914", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK9914(PRODJECTNAME As String, PROGRAMNO As String, SHEETNAME As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9914 "
            SQL = SQL & " WHERE K9914_ProdjectName		 = '" & ProdjectName & "' "
            SQL = SQL & "   AND K9914_ProgramNo		 = '" & ProgramNo & "' "
            SQL = SQL & "   AND K9914_SheetName		 = '" & SheetName & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK9914", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK9914(z9914 As T9914_AREA) As Boolean
        WRITE_PFK9914 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z9914)

            SQL = " INSERT INTO PFK9914 "
            SQL = SQL & " ( "
            SQL = SQL & " K9914_ProdjectName,"
            SQL = SQL & " K9914_ProgramNo,"
            SQL = SQL & " K9914_SheetName,"
            SQL = SQL & " K9914_ColsFrozen,"
            SQL = SQL & " K9914_RowsFrozen,"
            SQL = SQL & " K9914_MaxRows,"
            SQL = SQL & " K9914_OperationMode,"
            SQL = SQL & " K9914_Lock,"
            SQL = SQL & " K9914_DefaultRowHeight,"
            SQL = SQL & " K9914_HeaderTextMode,"
            SQL = SQL & " K9914_RetainSelectionBlock,"
            SQL = SQL & " K9914_AutoClip,"
            SQL = SQL & " K9914_Header,"
            SQL = SQL & " K9914_HeaderColumn,"
            SQL = SQL & " K9914_HeaderRow,"
            SQL = SQL & " K9914_Separate,"
            SQL = SQL & " K9914_TotalSeparate,"
            SQL = SQL & " K9914_ColumnBase,"
            SQL = SQL & " K9914_ColumnCal,"
            SQL = SQL & " K9914_Merge,"
            SQL = SQL & " K9914_MergeColumn,"
            SQL = SQL & " K9914_MergeRetrict,"
            SQL = SQL & " K9914_BackColorCheck,"
            SQL = SQL & " K9914_BackColor,"
            SQL = SQL & " K9914_AreaColorCheck,"
            SQL = SQL & " K9914_AreaColor,"
            SQL = SQL & " K9914_Fontsize,"

            SQL = SQL & " K9914_FixSize,"
            SQL = SQL & " K9914_ZoomSize,"

            SQL = SQL & " K9914_Rowheight,"
            SQL = SQL & " K9914_CheckColumnSpan,"
            SQL = SQL & " K9914_ColHeader1,"
            SQL = SQL & " K9914_ColHeader2,"
            SQL = SQL & " K9914_ColumnSpanID,"
            SQL = SQL & " K9914_Footer,"
            SQL = SQL & " K9914_Chart,"
            SQL = SQL & " K9914_ChartType,"
            SQL = SQL & " K9914_ChartVisible,"
            SQL = SQL & " K9914_MoveColumn,"
            SQL = SQL & " K9914_MoveRow,"
            SQL = SQL & " K9914_NameChart,"
            SQL = SQL & " K9914_Line,"
            SQL = SQL & " K9914_LineBase,"
            SQL = SQL & " K9914_BarBase,"
            SQL = SQL & " K9914_PieBase,"
            SQL = SQL & " K9914_REMK "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z9914.ProdjectName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9914.ProgramNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9914.SheetName) & "', "
            SQL = SQL & "   " & FormatSQL(z9914.ColsFrozen) & ", "
            SQL = SQL & "   " & FormatSQL(z9914.RowsFrozen) & ", "
            SQL = SQL & "   " & FormatSQL(z9914.MaxRows) & ", "
            SQL = SQL & "  N'" & FormatSQL(z9914.OperationMode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9914.Lock) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9914.DefaultRowHeight) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9914.HeaderTextMode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9914.RetainSelectionBlock) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9914.AutoClip) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9914.Header) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9914.HeaderColumn) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9914.HeaderRow) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9914.Separate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9914.TotalSeparate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9914.ColumnBase) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9914.ColumnCal) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9914.Merge) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9914.MergeColumn) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9914.MergeRetrict) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9914.BackColorCheck) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9914.BackColor) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9914.AreaColorCheck) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9914.AreaColor) & "', "
            SQL = SQL & "   " & FormatSQL(z9914.Fontsize) & ", "

            SQL = SQL & "  N'" & FormatSQL(z9914.FixSize) & "', "
            SQL = SQL & "   " & FormatSQL(z9914.ZoomSize) & ", "

            SQL = SQL & "   " & FormatSQL(z9914.Rowheight) & ", "
            SQL = SQL & "  N'" & FormatSQL(z9914.CheckColumnSpan) & "', "
            SQL = SQL & "   " & FormatSQL(z9914.ColHeader1) & ", "
            SQL = SQL & "   " & FormatSQL(z9914.ColHeader2) & ", "
            SQL = SQL & "   " & FormatSQL(z9914.ColumnSpanID) & ", "
            SQL = SQL & "  N'" & FormatSQL(z9914.Footer) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9914.Chart) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9914.ChartType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9914.ChartVisible) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9914.MoveColumn) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9914.MoveRow) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9914.NameChart) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9914.Line) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9914.LineBase) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9914.BarBase) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9914.PieBase) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9914.REMK) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK9914 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK9914", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK9914(z9914 As T9914_AREA) As Boolean
        REWRITE_PFK9914 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z9914)

            SQL = " UPDATE PFK9914 SET "
            SQL = SQL & "    K9914_ColsFrozen      =  " & FormatSQL(z9914.ColsFrozen) & ", "
            SQL = SQL & "    K9914_RowsFrozen      =  " & FormatSQL(z9914.RowsFrozen) & ", "
            SQL = SQL & "    K9914_MaxRows      =  " & FormatSQL(z9914.MaxRows) & ", "
            SQL = SQL & "    K9914_OperationMode      = N'" & FormatSQL(z9914.OperationMode) & "', "
            SQL = SQL & "    K9914_Lock      = N'" & FormatSQL(z9914.Lock) & "', "
            SQL = SQL & "    K9914_DefaultRowHeight      = N'" & FormatSQL(z9914.DefaultRowHeight) & "', "
            SQL = SQL & "    K9914_HeaderTextMode      = N'" & FormatSQL(z9914.HeaderTextMode) & "', "
            SQL = SQL & "    K9914_RetainSelectionBlock      = N'" & FormatSQL(z9914.RetainSelectionBlock) & "', "
            SQL = SQL & "    K9914_AutoClip      = N'" & FormatSQL(z9914.AutoClip) & "', "
            SQL = SQL & "    K9914_Header      = N'" & FormatSQL(z9914.Header) & "', "
            SQL = SQL & "    K9914_HeaderColumn      = N'" & FormatSQL(z9914.HeaderColumn) & "', "
            SQL = SQL & "    K9914_HeaderRow      = N'" & FormatSQL(z9914.HeaderRow) & "', "
            SQL = SQL & "    K9914_Separate      = N'" & FormatSQL(z9914.Separate) & "', "
            SQL = SQL & "    K9914_TotalSeparate      = N'" & FormatSQL(z9914.TotalSeparate) & "', "
            SQL = SQL & "    K9914_ColumnBase      = N'" & FormatSQL(z9914.ColumnBase) & "', "
            SQL = SQL & "    K9914_ColumnCal      = N'" & FormatSQL(z9914.ColumnCal) & "', "
            SQL = SQL & "    K9914_Merge      = N'" & FormatSQL(z9914.Merge) & "', "
            SQL = SQL & "    K9914_MergeColumn      = N'" & FormatSQL(z9914.MergeColumn) & "', "
            SQL = SQL & "    K9914_MergeRetrict      = N'" & FormatSQL(z9914.MergeRetrict) & "', "
            SQL = SQL & "    K9914_BackColorCheck      = N'" & FormatSQL(z9914.BackColorCheck) & "', "
            SQL = SQL & "    K9914_BackColor      = N'" & FormatSQL(z9914.BackColor) & "', "
            SQL = SQL & "    K9914_AreaColorCheck      = N'" & FormatSQL(z9914.AreaColorCheck) & "', "
            SQL = SQL & "    K9914_AreaColor      = N'" & FormatSQL(z9914.AreaColor) & "', "
            SQL = SQL & "    K9914_Fontsize      =  " & FormatSQL(z9914.Fontsize) & ", "

            SQL = SQL & "    K9914_FixSize      = N'" & FormatSQL(z9914.FixSize) & "', "
            SQL = SQL & "    K9914_ZoomSize      =  " & FormatSQL(z9914.ZoomSize) & ", "

            SQL = SQL & "    K9914_Rowheight      =  " & FormatSQL(z9914.Rowheight) & ", "
            SQL = SQL & "    K9914_CheckColumnSpan      = N'" & FormatSQL(z9914.CheckColumnSpan) & "', "
            SQL = SQL & "    K9914_ColHeader1      =  " & FormatSQL(z9914.ColHeader1) & ", "
            SQL = SQL & "    K9914_ColHeader2      =  " & FormatSQL(z9914.ColHeader2) & ", "
            SQL = SQL & "    K9914_ColumnSpanID      =  " & FormatSQL(z9914.ColumnSpanID) & ", "
            SQL = SQL & "    K9914_Footer      = N'" & FormatSQL(z9914.Footer) & "', "
            SQL = SQL & "    K9914_Chart      = N'" & FormatSQL(z9914.Chart) & "', "
            SQL = SQL & "    K9914_ChartType      = N'" & FormatSQL(z9914.ChartType) & "', "
            SQL = SQL & "    K9914_ChartVisible      = N'" & FormatSQL(z9914.ChartVisible) & "', "
            SQL = SQL & "    K9914_MoveColumn      = N'" & FormatSQL(z9914.MoveColumn) & "', "
            SQL = SQL & "    K9914_MoveRow      = N'" & FormatSQL(z9914.MoveRow) & "', "
            SQL = SQL & "    K9914_NameChart      = N'" & FormatSQL(z9914.NameChart) & "', "
            SQL = SQL & "    K9914_Line      = N'" & FormatSQL(z9914.Line) & "', "
            SQL = SQL & "    K9914_LineBase      = N'" & FormatSQL(z9914.LineBase) & "', "
            SQL = SQL & "    K9914_BarBase      = N'" & FormatSQL(z9914.BarBase) & "', "
            SQL = SQL & "    K9914_PieBase      = N'" & FormatSQL(z9914.PieBase) & "', "
            SQL = SQL & "    K9914_REMK      = N'" & FormatSQL(z9914.REMK) & "'  "
            SQL = SQL & " WHERE K9914_ProdjectName		 = '" & z9914.ProdjectName & "' "
            SQL = SQL & "   AND K9914_ProgramNo		 = '" & z9914.ProgramNo & "' "
            SQL = SQL & "   AND K9914_SheetName		 = '" & z9914.SheetName & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK9914 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK9914", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK9914(z9914 As T9914_AREA) As Boolean
        DELETE_PFK9914 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK9914 "
            SQL = SQL & " WHERE K9914_ProdjectName		 = '" & z9914.ProdjectName & "' "
            SQL = SQL & "   AND K9914_ProgramNo		 = '" & z9914.ProgramNo & "' "
            SQL = SQL & "   AND K9914_SheetName		 = '" & z9914.SheetName & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK9914 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK9914", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D9914_CLEAR()
        Try

            D9914.ProdjectName = ""
            D9914.ProgramNo = ""
            D9914.SheetName = ""
            D9914.ColsFrozen = 0
            D9914.RowsFrozen = 0
            D9914.MaxRows = 0
            D9914.OperationMode = ""
            D9914.Lock = ""
            D9914.DefaultRowHeight = ""
            D9914.HeaderTextMode = ""
            D9914.RetainSelectionBlock = ""
            D9914.AutoClip = ""
            D9914.Header = ""
            D9914.HeaderColumn = ""
            D9914.HeaderRow = ""
            D9914.Separate = ""
            D9914.TotalSeparate = ""
            D9914.ColumnBase = ""
            D9914.ColumnCal = ""
            D9914.Merge = ""
            D9914.MergeColumn = ""
            D9914.MergeRetrict = ""
            D9914.BackColorCheck = ""
            D9914.BackColor = ""
            D9914.AreaColorCheck = ""
            D9914.AreaColor = ""
            D9914.Fontsize = 0

            D9914.FixSize = ""
            D9914.ZoomSize = 0

            D9914.Rowheight = 0
            D9914.CheckColumnSpan = ""
            D9914.ColHeader1 = 0
            D9914.ColHeader2 = 0
            D9914.ColumnSpanID = 0
            D9914.Footer = ""
            D9914.Chart = ""
            D9914.ChartType = ""
            D9914.ChartVisible = ""
            D9914.MoveColumn = ""
            D9914.MoveRow = ""
            D9914.NameChart = ""
            D9914.Line = ""
            D9914.LineBase = ""
            D9914.BarBase = ""
            D9914.PieBase = ""
            D9914.REMK = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D9914_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x9914 As T9914_AREA)
        Try

            x9914.ProdjectName = trim$(x9914.ProdjectName)
            x9914.ProgramNo = trim$(x9914.ProgramNo)
            x9914.SheetName = trim$(x9914.SheetName)
            x9914.ColsFrozen = trim$(x9914.ColsFrozen)
            x9914.RowsFrozen = trim$(x9914.RowsFrozen)
            x9914.MaxRows = trim$(x9914.MaxRows)
            x9914.OperationMode = trim$(x9914.OperationMode)
            x9914.Lock = trim$(x9914.Lock)
            x9914.DefaultRowHeight = trim$(x9914.DefaultRowHeight)
            x9914.HeaderTextMode = trim$(x9914.HeaderTextMode)
            x9914.RetainSelectionBlock = trim$(x9914.RetainSelectionBlock)
            x9914.AutoClip = trim$(x9914.AutoClip)
            x9914.Header = trim$(x9914.Header)
            x9914.HeaderColumn = trim$(x9914.HeaderColumn)
            x9914.HeaderRow = trim$(x9914.HeaderRow)
            x9914.Separate = trim$(x9914.Separate)
            x9914.TotalSeparate = trim$(x9914.TotalSeparate)
            x9914.ColumnBase = trim$(x9914.ColumnBase)
            x9914.ColumnCal = trim$(x9914.ColumnCal)
            x9914.Merge = trim$(x9914.Merge)
            x9914.MergeColumn = trim$(x9914.MergeColumn)
            x9914.MergeRetrict = trim$(x9914.MergeRetrict)
            x9914.BackColorCheck = trim$(x9914.BackColorCheck)
            x9914.BackColor = trim$(x9914.BackColor)
            x9914.AreaColorCheck = trim$(x9914.AreaColorCheck)
            x9914.AreaColor = trim$(x9914.AreaColor)
            x9914.Fontsize = Trim$(x9914.Fontsize)

            x9914.FixSize = Trim$(x9914.FixSize)
            x9914.ZoomSize = Trim$(x9914.ZoomSize)

            x9914.Rowheight = trim$(x9914.Rowheight)
            x9914.CheckColumnSpan = trim$(x9914.CheckColumnSpan)
            x9914.ColHeader1 = trim$(x9914.ColHeader1)
            x9914.ColHeader2 = trim$(x9914.ColHeader2)
            x9914.ColumnSpanID = trim$(x9914.ColumnSpanID)
            x9914.Footer = trim$(x9914.Footer)
            x9914.Chart = trim$(x9914.Chart)
            x9914.ChartType = trim$(x9914.ChartType)
            x9914.ChartVisible = trim$(x9914.ChartVisible)
            x9914.MoveColumn = trim$(x9914.MoveColumn)
            x9914.MoveRow = trim$(x9914.MoveRow)
            x9914.NameChart = trim$(x9914.NameChart)
            x9914.Line = trim$(x9914.Line)
            x9914.LineBase = trim$(x9914.LineBase)
            x9914.BarBase = trim$(x9914.BarBase)
            x9914.PieBase = trim$(x9914.PieBase)
            x9914.REMK = trim$(x9914.REMK)

            If trim$(x9914.ProdjectName) = "" Then x9914.ProdjectName = Space(1)
            If trim$(x9914.ProgramNo) = "" Then x9914.ProgramNo = Space(1)
            If trim$(x9914.SheetName) = "" Then x9914.SheetName = Space(1)
            If trim$(x9914.ColsFrozen) = "" Then x9914.ColsFrozen = 0
            If trim$(x9914.RowsFrozen) = "" Then x9914.RowsFrozen = 0
            If trim$(x9914.MaxRows) = "" Then x9914.MaxRows = 0
            If trim$(x9914.OperationMode) = "" Then x9914.OperationMode = Space(1)
            If trim$(x9914.Lock) = "" Then x9914.Lock = Space(1)
            If trim$(x9914.DefaultRowHeight) = "" Then x9914.DefaultRowHeight = Space(1)
            If trim$(x9914.HeaderTextMode) = "" Then x9914.HeaderTextMode = Space(1)
            If trim$(x9914.RetainSelectionBlock) = "" Then x9914.RetainSelectionBlock = Space(1)
            If trim$(x9914.AutoClip) = "" Then x9914.AutoClip = Space(1)
            If trim$(x9914.Header) = "" Then x9914.Header = Space(1)
            If trim$(x9914.HeaderColumn) = "" Then x9914.HeaderColumn = Space(1)
            If trim$(x9914.HeaderRow) = "" Then x9914.HeaderRow = Space(1)
            If trim$(x9914.Separate) = "" Then x9914.Separate = Space(1)
            If trim$(x9914.TotalSeparate) = "" Then x9914.TotalSeparate = Space(1)
            If trim$(x9914.ColumnBase) = "" Then x9914.ColumnBase = Space(1)
            If trim$(x9914.ColumnCal) = "" Then x9914.ColumnCal = Space(1)
            If trim$(x9914.Merge) = "" Then x9914.Merge = Space(1)
            If trim$(x9914.MergeColumn) = "" Then x9914.MergeColumn = Space(1)
            If trim$(x9914.MergeRetrict) = "" Then x9914.MergeRetrict = Space(1)
            If trim$(x9914.BackColorCheck) = "" Then x9914.BackColorCheck = Space(1)
            If trim$(x9914.BackColor) = "" Then x9914.BackColor = Space(1)
            If trim$(x9914.AreaColorCheck) = "" Then x9914.AreaColorCheck = Space(1)
            If trim$(x9914.AreaColor) = "" Then x9914.AreaColor = Space(1)
            If Trim$(x9914.Fontsize) = "" Then x9914.Fontsize = 0

            If Trim$(x9914.FixSize) = "" Then x9914.FixSize = Space(1)
            If Trim$(x9914.ZoomSize) = "" Then x9914.ZoomSize = 0

            If trim$(x9914.Rowheight) = "" Then x9914.Rowheight = 0
            If trim$(x9914.CheckColumnSpan) = "" Then x9914.CheckColumnSpan = Space(1)
            If trim$(x9914.ColHeader1) = "" Then x9914.ColHeader1 = 0
            If trim$(x9914.ColHeader2) = "" Then x9914.ColHeader2 = 0
            If trim$(x9914.ColumnSpanID) = "" Then x9914.ColumnSpanID = 0
            If trim$(x9914.Footer) = "" Then x9914.Footer = Space(1)
            If trim$(x9914.Chart) = "" Then x9914.Chart = Space(1)
            If trim$(x9914.ChartType) = "" Then x9914.ChartType = Space(1)
            If trim$(x9914.ChartVisible) = "" Then x9914.ChartVisible = Space(1)
            If trim$(x9914.MoveColumn) = "" Then x9914.MoveColumn = Space(1)
            If trim$(x9914.MoveRow) = "" Then x9914.MoveRow = Space(1)
            If trim$(x9914.NameChart) = "" Then x9914.NameChart = Space(1)
            If trim$(x9914.Line) = "" Then x9914.Line = Space(1)
            If trim$(x9914.LineBase) = "" Then x9914.LineBase = Space(1)
            If trim$(x9914.BarBase) = "" Then x9914.BarBase = Space(1)
            If trim$(x9914.PieBase) = "" Then x9914.PieBase = Space(1)
            If trim$(x9914.REMK) = "" Then x9914.REMK = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K9914_MOVE(rs9914 As SqlClient.SqlDataReader)
        Try

            Call D9914_CLEAR()

            If IsdbNull(rs9914!K9914_ProdjectName) = False Then D9914.ProdjectName = Trim$(rs9914!K9914_ProdjectName)
            If IsdbNull(rs9914!K9914_ProgramNo) = False Then D9914.ProgramNo = Trim$(rs9914!K9914_ProgramNo)
            If IsdbNull(rs9914!K9914_SheetName) = False Then D9914.SheetName = Trim$(rs9914!K9914_SheetName)
            If IsdbNull(rs9914!K9914_ColsFrozen) = False Then D9914.ColsFrozen = Trim$(rs9914!K9914_ColsFrozen)
            If IsdbNull(rs9914!K9914_RowsFrozen) = False Then D9914.RowsFrozen = Trim$(rs9914!K9914_RowsFrozen)
            If IsdbNull(rs9914!K9914_MaxRows) = False Then D9914.MaxRows = Trim$(rs9914!K9914_MaxRows)
            If IsdbNull(rs9914!K9914_OperationMode) = False Then D9914.OperationMode = Trim$(rs9914!K9914_OperationMode)
            If IsdbNull(rs9914!K9914_Lock) = False Then D9914.Lock = Trim$(rs9914!K9914_Lock)
            If IsdbNull(rs9914!K9914_DefaultRowHeight) = False Then D9914.DefaultRowHeight = Trim$(rs9914!K9914_DefaultRowHeight)
            If IsdbNull(rs9914!K9914_HeaderTextMode) = False Then D9914.HeaderTextMode = Trim$(rs9914!K9914_HeaderTextMode)
            If IsdbNull(rs9914!K9914_RetainSelectionBlock) = False Then D9914.RetainSelectionBlock = Trim$(rs9914!K9914_RetainSelectionBlock)
            If IsdbNull(rs9914!K9914_AutoClip) = False Then D9914.AutoClip = Trim$(rs9914!K9914_AutoClip)
            If IsdbNull(rs9914!K9914_Header) = False Then D9914.Header = Trim$(rs9914!K9914_Header)
            If IsdbNull(rs9914!K9914_HeaderColumn) = False Then D9914.HeaderColumn = Trim$(rs9914!K9914_HeaderColumn)
            If IsdbNull(rs9914!K9914_HeaderRow) = False Then D9914.HeaderRow = Trim$(rs9914!K9914_HeaderRow)
            If IsdbNull(rs9914!K9914_Separate) = False Then D9914.Separate = Trim$(rs9914!K9914_Separate)
            If IsdbNull(rs9914!K9914_TotalSeparate) = False Then D9914.TotalSeparate = Trim$(rs9914!K9914_TotalSeparate)
            If IsdbNull(rs9914!K9914_ColumnBase) = False Then D9914.ColumnBase = Trim$(rs9914!K9914_ColumnBase)
            If IsdbNull(rs9914!K9914_ColumnCal) = False Then D9914.ColumnCal = Trim$(rs9914!K9914_ColumnCal)
            If IsdbNull(rs9914!K9914_Merge) = False Then D9914.Merge = Trim$(rs9914!K9914_Merge)
            If IsdbNull(rs9914!K9914_MergeColumn) = False Then D9914.MergeColumn = Trim$(rs9914!K9914_MergeColumn)
            If IsdbNull(rs9914!K9914_MergeRetrict) = False Then D9914.MergeRetrict = Trim$(rs9914!K9914_MergeRetrict)
            If IsdbNull(rs9914!K9914_BackColorCheck) = False Then D9914.BackColorCheck = Trim$(rs9914!K9914_BackColorCheck)
            If IsdbNull(rs9914!K9914_BackColor) = False Then D9914.BackColor = Trim$(rs9914!K9914_BackColor)
            If IsdbNull(rs9914!K9914_AreaColorCheck) = False Then D9914.AreaColorCheck = Trim$(rs9914!K9914_AreaColorCheck)
            If IsdbNull(rs9914!K9914_AreaColor) = False Then D9914.AreaColor = Trim$(rs9914!K9914_AreaColor)
            If IsDBNull(rs9914!K9914_Fontsize) = False Then D9914.Fontsize = Trim$(rs9914!K9914_Fontsize)

            If IsDBNull(rs9914!K9914_FixSize) = False Then D9914.FixSize = Trim$(rs9914!K9914_FixSize)
            If IsDBNull(rs9914!K9914_ZoomSize) = False Then D9914.ZoomSize = Trim$(rs9914!K9914_ZoomSize)

            If IsdbNull(rs9914!K9914_Rowheight) = False Then D9914.Rowheight = Trim$(rs9914!K9914_Rowheight)
            If IsdbNull(rs9914!K9914_CheckColumnSpan) = False Then D9914.CheckColumnSpan = Trim$(rs9914!K9914_CheckColumnSpan)
            If IsdbNull(rs9914!K9914_ColHeader1) = False Then D9914.ColHeader1 = Trim$(rs9914!K9914_ColHeader1)
            If IsdbNull(rs9914!K9914_ColHeader2) = False Then D9914.ColHeader2 = Trim$(rs9914!K9914_ColHeader2)
            If IsdbNull(rs9914!K9914_ColumnSpanID) = False Then D9914.ColumnSpanID = Trim$(rs9914!K9914_ColumnSpanID)
            If IsdbNull(rs9914!K9914_Footer) = False Then D9914.Footer = Trim$(rs9914!K9914_Footer)
            If IsdbNull(rs9914!K9914_Chart) = False Then D9914.Chart = Trim$(rs9914!K9914_Chart)
            If IsdbNull(rs9914!K9914_ChartType) = False Then D9914.ChartType = Trim$(rs9914!K9914_ChartType)
            If IsdbNull(rs9914!K9914_ChartVisible) = False Then D9914.ChartVisible = Trim$(rs9914!K9914_ChartVisible)
            If IsdbNull(rs9914!K9914_MoveColumn) = False Then D9914.MoveColumn = Trim$(rs9914!K9914_MoveColumn)
            If IsdbNull(rs9914!K9914_MoveRow) = False Then D9914.MoveRow = Trim$(rs9914!K9914_MoveRow)
            If IsdbNull(rs9914!K9914_NameChart) = False Then D9914.NameChart = Trim$(rs9914!K9914_NameChart)
            If IsdbNull(rs9914!K9914_Line) = False Then D9914.Line = Trim$(rs9914!K9914_Line)
            If IsdbNull(rs9914!K9914_LineBase) = False Then D9914.LineBase = Trim$(rs9914!K9914_LineBase)
            If IsdbNull(rs9914!K9914_BarBase) = False Then D9914.BarBase = Trim$(rs9914!K9914_BarBase)
            If IsdbNull(rs9914!K9914_PieBase) = False Then D9914.PieBase = Trim$(rs9914!K9914_PieBase)
            If IsdbNull(rs9914!K9914_REMK) = False Then D9914.REMK = Trim$(rs9914!K9914_REMK)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K9914_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K9914_MOVE(rs9914 As DataRow)
        Try

            Call D9914_CLEAR()

            If IsdbNull(rs9914!K9914_ProdjectName) = False Then D9914.ProdjectName = Trim$(rs9914!K9914_ProdjectName)
            If IsdbNull(rs9914!K9914_ProgramNo) = False Then D9914.ProgramNo = Trim$(rs9914!K9914_ProgramNo)
            If IsdbNull(rs9914!K9914_SheetName) = False Then D9914.SheetName = Trim$(rs9914!K9914_SheetName)
            If IsdbNull(rs9914!K9914_ColsFrozen) = False Then D9914.ColsFrozen = Trim$(rs9914!K9914_ColsFrozen)
            If IsdbNull(rs9914!K9914_RowsFrozen) = False Then D9914.RowsFrozen = Trim$(rs9914!K9914_RowsFrozen)
            If IsdbNull(rs9914!K9914_MaxRows) = False Then D9914.MaxRows = Trim$(rs9914!K9914_MaxRows)
            If IsdbNull(rs9914!K9914_OperationMode) = False Then D9914.OperationMode = Trim$(rs9914!K9914_OperationMode)
            If IsdbNull(rs9914!K9914_Lock) = False Then D9914.Lock = Trim$(rs9914!K9914_Lock)
            If IsdbNull(rs9914!K9914_DefaultRowHeight) = False Then D9914.DefaultRowHeight = Trim$(rs9914!K9914_DefaultRowHeight)
            If IsdbNull(rs9914!K9914_HeaderTextMode) = False Then D9914.HeaderTextMode = Trim$(rs9914!K9914_HeaderTextMode)
            If IsdbNull(rs9914!K9914_RetainSelectionBlock) = False Then D9914.RetainSelectionBlock = Trim$(rs9914!K9914_RetainSelectionBlock)
            If IsdbNull(rs9914!K9914_AutoClip) = False Then D9914.AutoClip = Trim$(rs9914!K9914_AutoClip)
            If IsdbNull(rs9914!K9914_Header) = False Then D9914.Header = Trim$(rs9914!K9914_Header)
            If IsdbNull(rs9914!K9914_HeaderColumn) = False Then D9914.HeaderColumn = Trim$(rs9914!K9914_HeaderColumn)
            If IsdbNull(rs9914!K9914_HeaderRow) = False Then D9914.HeaderRow = Trim$(rs9914!K9914_HeaderRow)
            If IsdbNull(rs9914!K9914_Separate) = False Then D9914.Separate = Trim$(rs9914!K9914_Separate)
            If IsdbNull(rs9914!K9914_TotalSeparate) = False Then D9914.TotalSeparate = Trim$(rs9914!K9914_TotalSeparate)
            If IsdbNull(rs9914!K9914_ColumnBase) = False Then D9914.ColumnBase = Trim$(rs9914!K9914_ColumnBase)
            If IsdbNull(rs9914!K9914_ColumnCal) = False Then D9914.ColumnCal = Trim$(rs9914!K9914_ColumnCal)
            If IsdbNull(rs9914!K9914_Merge) = False Then D9914.Merge = Trim$(rs9914!K9914_Merge)
            If IsdbNull(rs9914!K9914_MergeColumn) = False Then D9914.MergeColumn = Trim$(rs9914!K9914_MergeColumn)
            If IsdbNull(rs9914!K9914_MergeRetrict) = False Then D9914.MergeRetrict = Trim$(rs9914!K9914_MergeRetrict)
            If IsdbNull(rs9914!K9914_BackColorCheck) = False Then D9914.BackColorCheck = Trim$(rs9914!K9914_BackColorCheck)
            If IsdbNull(rs9914!K9914_BackColor) = False Then D9914.BackColor = Trim$(rs9914!K9914_BackColor)
            If IsdbNull(rs9914!K9914_AreaColorCheck) = False Then D9914.AreaColorCheck = Trim$(rs9914!K9914_AreaColorCheck)
            If IsdbNull(rs9914!K9914_AreaColor) = False Then D9914.AreaColor = Trim$(rs9914!K9914_AreaColor)
            If IsDBNull(rs9914!K9914_Fontsize) = False Then D9914.Fontsize = Trim$(rs9914!K9914_Fontsize)

            If IsDBNull(rs9914!K9914_FixSize) = False Then D9914.FixSize = Trim$(rs9914!K9914_FixSize)
            If IsDBNull(rs9914!K9914_ZoomSize) = False Then D9914.ZoomSize = Trim$(rs9914!K9914_ZoomSize)

            If IsdbNull(rs9914!K9914_Rowheight) = False Then D9914.Rowheight = Trim$(rs9914!K9914_Rowheight)
            If IsdbNull(rs9914!K9914_CheckColumnSpan) = False Then D9914.CheckColumnSpan = Trim$(rs9914!K9914_CheckColumnSpan)
            If IsdbNull(rs9914!K9914_ColHeader1) = False Then D9914.ColHeader1 = Trim$(rs9914!K9914_ColHeader1)
            If IsdbNull(rs9914!K9914_ColHeader2) = False Then D9914.ColHeader2 = Trim$(rs9914!K9914_ColHeader2)
            If IsdbNull(rs9914!K9914_ColumnSpanID) = False Then D9914.ColumnSpanID = Trim$(rs9914!K9914_ColumnSpanID)
            If IsdbNull(rs9914!K9914_Footer) = False Then D9914.Footer = Trim$(rs9914!K9914_Footer)
            If IsdbNull(rs9914!K9914_Chart) = False Then D9914.Chart = Trim$(rs9914!K9914_Chart)
            If IsdbNull(rs9914!K9914_ChartType) = False Then D9914.ChartType = Trim$(rs9914!K9914_ChartType)
            If IsdbNull(rs9914!K9914_ChartVisible) = False Then D9914.ChartVisible = Trim$(rs9914!K9914_ChartVisible)
            If IsdbNull(rs9914!K9914_MoveColumn) = False Then D9914.MoveColumn = Trim$(rs9914!K9914_MoveColumn)
            If IsdbNull(rs9914!K9914_MoveRow) = False Then D9914.MoveRow = Trim$(rs9914!K9914_MoveRow)
            If IsdbNull(rs9914!K9914_NameChart) = False Then D9914.NameChart = Trim$(rs9914!K9914_NameChart)
            If IsdbNull(rs9914!K9914_Line) = False Then D9914.Line = Trim$(rs9914!K9914_Line)
            If IsdbNull(rs9914!K9914_LineBase) = False Then D9914.LineBase = Trim$(rs9914!K9914_LineBase)
            If IsdbNull(rs9914!K9914_BarBase) = False Then D9914.BarBase = Trim$(rs9914!K9914_BarBase)
            If IsdbNull(rs9914!K9914_PieBase) = False Then D9914.PieBase = Trim$(rs9914!K9914_PieBase)
            If IsdbNull(rs9914!K9914_REMK) = False Then D9914.REMK = Trim$(rs9914!K9914_REMK)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K9914_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K9914_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z9914 As T9914_AREA, PRODJECTNAME As String, PROGRAMNO As String, SHEETNAME As String) As Boolean

        K9914_MOVE = False

        Try
            If READ_PFK9914(PRODJECTNAME, PROGRAMNO, SHEETNAME) = True Then
                z9914 = D9914
                K9914_MOVE = True
            Else
                z9914 = Nothing
            End If

            If getColumIndex(spr, "ProdjectName") > -1 Then z9914.ProdjectName = getDataM(spr, getColumIndex(spr, "ProdjectName"), xRow)
            If getColumIndex(spr, "ProgramNo") > -1 Then z9914.ProgramNo = getDataM(spr, getColumIndex(spr, "ProgramNo"), xRow)
            If getColumIndex(spr, "SheetName") > -1 Then z9914.SheetName = getDataM(spr, getColumIndex(spr, "SheetName"), xRow)
            If getColumIndex(spr, "ColsFrozen") > -1 Then z9914.ColsFrozen = getDataM(spr, getColumIndex(spr, "ColsFrozen"), xRow)
            If getColumIndex(spr, "RowsFrozen") > -1 Then z9914.RowsFrozen = getDataM(spr, getColumIndex(spr, "RowsFrozen"), xRow)
            If getColumIndex(spr, "MaxRows") > -1 Then z9914.MaxRows = getDataM(spr, getColumIndex(spr, "MaxRows"), xRow)
            If getColumIndex(spr, "OperationMode") > -1 Then z9914.OperationMode = getDataM(spr, getColumIndex(spr, "OperationMode"), xRow)
            If getColumIndex(spr, "Lock") > -1 Then z9914.Lock = getDataM(spr, getColumIndex(spr, "Lock"), xRow)
            If getColumIndex(spr, "DefaultRowHeight") > -1 Then z9914.DefaultRowHeight = getDataM(spr, getColumIndex(spr, "DefaultRowHeight"), xRow)
            If getColumIndex(spr, "HeaderTextMode") > -1 Then z9914.HeaderTextMode = getDataM(spr, getColumIndex(spr, "HeaderTextMode"), xRow)
            If getColumIndex(spr, "RetainSelectionBlock") > -1 Then z9914.RetainSelectionBlock = getDataM(spr, getColumIndex(spr, "RetainSelectionBlock"), xRow)
            If getColumIndex(spr, "AutoClip") > -1 Then z9914.AutoClip = getDataM(spr, getColumIndex(spr, "AutoClip"), xRow)
            If getColumIndex(spr, "Header") > -1 Then z9914.Header = getDataM(spr, getColumIndex(spr, "Header"), xRow)
            If getColumIndex(spr, "HeaderColumn") > -1 Then z9914.HeaderColumn = getDataM(spr, getColumIndex(spr, "HeaderColumn"), xRow)
            If getColumIndex(spr, "HeaderRow") > -1 Then z9914.HeaderRow = getDataM(spr, getColumIndex(spr, "HeaderRow"), xRow)
            If getColumIndex(spr, "Separate") > -1 Then z9914.Separate = getDataM(spr, getColumIndex(spr, "Separate"), xRow)
            If getColumIndex(spr, "TotalSeparate") > -1 Then z9914.TotalSeparate = getDataM(spr, getColumIndex(spr, "TotalSeparate"), xRow)
            If getColumIndex(spr, "ColumnBase") > -1 Then z9914.ColumnBase = getDataM(spr, getColumIndex(spr, "ColumnBase"), xRow)
            If getColumIndex(spr, "ColumnCal") > -1 Then z9914.ColumnCal = getDataM(spr, getColumIndex(spr, "ColumnCal"), xRow)
            If getColumIndex(spr, "Merge") > -1 Then z9914.Merge = getDataM(spr, getColumIndex(spr, "Merge"), xRow)
            If getColumIndex(spr, "MergeColumn") > -1 Then z9914.MergeColumn = getDataM(spr, getColumIndex(spr, "MergeColumn"), xRow)
            If getColumIndex(spr, "MergeRetrict") > -1 Then z9914.MergeRetrict = getDataM(spr, getColumIndex(spr, "MergeRetrict"), xRow)
            If getColumIndex(spr, "BackColorCheck") > -1 Then z9914.BackColorCheck = getDataM(spr, getColumIndex(spr, "BackColorCheck"), xRow)
            If getColumIndex(spr, "BackColor") > -1 Then z9914.BackColor = getDataM(spr, getColumIndex(spr, "BackColor"), xRow)
            If getColumIndex(spr, "AreaColorCheck") > -1 Then z9914.AreaColorCheck = getDataM(spr, getColumIndex(spr, "AreaColorCheck"), xRow)
            If getColumIndex(spr, "AreaColor") > -1 Then z9914.AreaColor = getDataM(spr, getColumIndex(spr, "AreaColor"), xRow)
            If getColumIndex(spr, "Fontsize") > -1 Then z9914.Fontsize = getDataM(spr, getColumIndex(spr, "Fontsize"), xRow)

            If getColumIndex(spr, "FixSize") > -1 Then z9914.FixSize = getDataM(spr, getColumIndex(spr, "FixSize"), xRow)
            If getColumIndex(spr, "ZoomSize") > -1 Then z9914.ZoomSize = getDataM(spr, getColumIndex(spr, "ZoomSize"), xRow)

            If getColumIndex(spr, "Rowheight") > -1 Then z9914.Rowheight = getDataM(spr, getColumIndex(spr, "Rowheight"), xRow)
            If getColumIndex(spr, "CheckColumnSpan") > -1 Then z9914.CheckColumnSpan = getDataM(spr, getColumIndex(spr, "CheckColumnSpan"), xRow)
            If getColumIndex(spr, "ColHeader1") > -1 Then z9914.ColHeader1 = getDataM(spr, getColumIndex(spr, "ColHeader1"), xRow)
            If getColumIndex(spr, "ColHeader2") > -1 Then z9914.ColHeader2 = getDataM(spr, getColumIndex(spr, "ColHeader2"), xRow)
            If getColumIndex(spr, "ColumnSpanID") > -1 Then z9914.ColumnSpanID = getDataM(spr, getColumIndex(spr, "ColumnSpanID"), xRow)
            If getColumIndex(spr, "Footer") > -1 Then z9914.Footer = getDataM(spr, getColumIndex(spr, "Footer"), xRow)
            If getColumIndex(spr, "Chart") > -1 Then z9914.Chart = getDataM(spr, getColumIndex(spr, "Chart"), xRow)
            If getColumIndex(spr, "ChartType") > -1 Then z9914.ChartType = getDataM(spr, getColumIndex(spr, "ChartType"), xRow)
            If getColumIndex(spr, "ChartVisible") > -1 Then z9914.ChartVisible = getDataM(spr, getColumIndex(spr, "ChartVisible"), xRow)
            If getColumIndex(spr, "MoveColumn") > -1 Then z9914.MoveColumn = getDataM(spr, getColumIndex(spr, "MoveColumn"), xRow)
            If getColumIndex(spr, "MoveRow") > -1 Then z9914.MoveRow = getDataM(spr, getColumIndex(spr, "MoveRow"), xRow)
            If getColumIndex(spr, "NameChart") > -1 Then z9914.NameChart = getDataM(spr, getColumIndex(spr, "NameChart"), xRow)
            If getColumIndex(spr, "Line") > -1 Then z9914.Line = getDataM(spr, getColumIndex(spr, "Line"), xRow)
            If getColumIndex(spr, "LineBase") > -1 Then z9914.LineBase = getDataM(spr, getColumIndex(spr, "LineBase"), xRow)
            If getColumIndex(spr, "BarBase") > -1 Then z9914.BarBase = getDataM(spr, getColumIndex(spr, "BarBase"), xRow)
            If getColumIndex(spr, "PieBase") > -1 Then z9914.PieBase = getDataM(spr, getColumIndex(spr, "PieBase"), xRow)
            If getColumIndex(spr, "REMK") > -1 Then z9914.REMK = getDataM(spr, getColumIndex(spr, "REMK"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9914_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K9914_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z9914 As T9914_AREA, CheckClear As Boolean, PRODJECTNAME As String, PROGRAMNO As String, SHEETNAME As String) As Boolean

        K9914_MOVE = False

        Try
            If READ_PFK9914(PRODJECTNAME, PROGRAMNO, SHEETNAME) = True Then
                z9914 = D9914
                K9914_MOVE = True
            Else
                If CheckClear = True Then z9914 = Nothing
            End If

            If getColumIndex(spr, "ProdjectName") > -1 Then z9914.ProdjectName = getDataM(spr, getColumIndex(spr, "ProdjectName"), xRow)
            If getColumIndex(spr, "ProgramNo") > -1 Then z9914.ProgramNo = getDataM(spr, getColumIndex(spr, "ProgramNo"), xRow)
            If getColumIndex(spr, "SheetName") > -1 Then z9914.SheetName = getDataM(spr, getColumIndex(spr, "SheetName"), xRow)
            If getColumIndex(spr, "ColsFrozen") > -1 Then z9914.ColsFrozen = getDataM(spr, getColumIndex(spr, "ColsFrozen"), xRow)
            If getColumIndex(spr, "RowsFrozen") > -1 Then z9914.RowsFrozen = getDataM(spr, getColumIndex(spr, "RowsFrozen"), xRow)
            If getColumIndex(spr, "MaxRows") > -1 Then z9914.MaxRows = getDataM(spr, getColumIndex(spr, "MaxRows"), xRow)
            If getColumIndex(spr, "OperationMode") > -1 Then z9914.OperationMode = getDataM(spr, getColumIndex(spr, "OperationMode"), xRow)
            If getColumIndex(spr, "Lock") > -1 Then z9914.Lock = getDataM(spr, getColumIndex(spr, "Lock"), xRow)
            If getColumIndex(spr, "DefaultRowHeight") > -1 Then z9914.DefaultRowHeight = getDataM(spr, getColumIndex(spr, "DefaultRowHeight"), xRow)
            If getColumIndex(spr, "HeaderTextMode") > -1 Then z9914.HeaderTextMode = getDataM(spr, getColumIndex(spr, "HeaderTextMode"), xRow)
            If getColumIndex(spr, "RetainSelectionBlock") > -1 Then z9914.RetainSelectionBlock = getDataM(spr, getColumIndex(spr, "RetainSelectionBlock"), xRow)
            If getColumIndex(spr, "AutoClip") > -1 Then z9914.AutoClip = getDataM(spr, getColumIndex(spr, "AutoClip"), xRow)
            If getColumIndex(spr, "Header") > -1 Then z9914.Header = getDataM(spr, getColumIndex(spr, "Header"), xRow)
            If getColumIndex(spr, "HeaderColumn") > -1 Then z9914.HeaderColumn = getDataM(spr, getColumIndex(spr, "HeaderColumn"), xRow)
            If getColumIndex(spr, "HeaderRow") > -1 Then z9914.HeaderRow = getDataM(spr, getColumIndex(spr, "HeaderRow"), xRow)
            If getColumIndex(spr, "Separate") > -1 Then z9914.Separate = getDataM(spr, getColumIndex(spr, "Separate"), xRow)
            If getColumIndex(spr, "TotalSeparate") > -1 Then z9914.TotalSeparate = getDataM(spr, getColumIndex(spr, "TotalSeparate"), xRow)
            If getColumIndex(spr, "ColumnBase") > -1 Then z9914.ColumnBase = getDataM(spr, getColumIndex(spr, "ColumnBase"), xRow)
            If getColumIndex(spr, "ColumnCal") > -1 Then z9914.ColumnCal = getDataM(spr, getColumIndex(spr, "ColumnCal"), xRow)
            If getColumIndex(spr, "Merge") > -1 Then z9914.Merge = getDataM(spr, getColumIndex(spr, "Merge"), xRow)
            If getColumIndex(spr, "MergeColumn") > -1 Then z9914.MergeColumn = getDataM(spr, getColumIndex(spr, "MergeColumn"), xRow)
            If getColumIndex(spr, "MergeRetrict") > -1 Then z9914.MergeRetrict = getDataM(spr, getColumIndex(spr, "MergeRetrict"), xRow)
            If getColumIndex(spr, "BackColorCheck") > -1 Then z9914.BackColorCheck = getDataM(spr, getColumIndex(spr, "BackColorCheck"), xRow)
            If getColumIndex(spr, "BackColor") > -1 Then z9914.BackColor = getDataM(spr, getColumIndex(spr, "BackColor"), xRow)
            If getColumIndex(spr, "AreaColorCheck") > -1 Then z9914.AreaColorCheck = getDataM(spr, getColumIndex(spr, "AreaColorCheck"), xRow)
            If getColumIndex(spr, "AreaColor") > -1 Then z9914.AreaColor = getDataM(spr, getColumIndex(spr, "AreaColor"), xRow)
            If getColumIndex(spr, "Fontsize") > -1 Then z9914.Fontsize = getDataM(spr, getColumIndex(spr, "Fontsize"), xRow)

            If getColumIndex(spr, "FixSize") > -1 Then z9914.FixSize = getDataM(spr, getColumIndex(spr, "FixSize"), xRow)
            If getColumIndex(spr, "ZoomSize") > -1 Then z9914.ZoomSize = getDataM(spr, getColumIndex(spr, "ZoomSize"), xRow)

            If getColumIndex(spr, "Rowheight") > -1 Then z9914.Rowheight = getDataM(spr, getColumIndex(spr, "Rowheight"), xRow)
            If getColumIndex(spr, "CheckColumnSpan") > -1 Then z9914.CheckColumnSpan = getDataM(spr, getColumIndex(spr, "CheckColumnSpan"), xRow)
            If getColumIndex(spr, "ColHeader1") > -1 Then z9914.ColHeader1 = getDataM(spr, getColumIndex(spr, "ColHeader1"), xRow)
            If getColumIndex(spr, "ColHeader2") > -1 Then z9914.ColHeader2 = getDataM(spr, getColumIndex(spr, "ColHeader2"), xRow)
            If getColumIndex(spr, "ColumnSpanID") > -1 Then z9914.ColumnSpanID = getDataM(spr, getColumIndex(spr, "ColumnSpanID"), xRow)
            If getColumIndex(spr, "Footer") > -1 Then z9914.Footer = getDataM(spr, getColumIndex(spr, "Footer"), xRow)
            If getColumIndex(spr, "Chart") > -1 Then z9914.Chart = getDataM(spr, getColumIndex(spr, "Chart"), xRow)
            If getColumIndex(spr, "ChartType") > -1 Then z9914.ChartType = getDataM(spr, getColumIndex(spr, "ChartType"), xRow)
            If getColumIndex(spr, "ChartVisible") > -1 Then z9914.ChartVisible = getDataM(spr, getColumIndex(spr, "ChartVisible"), xRow)
            If getColumIndex(spr, "MoveColumn") > -1 Then z9914.MoveColumn = getDataM(spr, getColumIndex(spr, "MoveColumn"), xRow)
            If getColumIndex(spr, "MoveRow") > -1 Then z9914.MoveRow = getDataM(spr, getColumIndex(spr, "MoveRow"), xRow)
            If getColumIndex(spr, "NameChart") > -1 Then z9914.NameChart = getDataM(spr, getColumIndex(spr, "NameChart"), xRow)
            If getColumIndex(spr, "Line") > -1 Then z9914.Line = getDataM(spr, getColumIndex(spr, "Line"), xRow)
            If getColumIndex(spr, "LineBase") > -1 Then z9914.LineBase = getDataM(spr, getColumIndex(spr, "LineBase"), xRow)
            If getColumIndex(spr, "BarBase") > -1 Then z9914.BarBase = getDataM(spr, getColumIndex(spr, "BarBase"), xRow)
            If getColumIndex(spr, "PieBase") > -1 Then z9914.PieBase = getDataM(spr, getColumIndex(spr, "PieBase"), xRow)
            If getColumIndex(spr, "REMK") > -1 Then z9914.REMK = getDataM(spr, getColumIndex(spr, "REMK"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9914_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K9914_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z9914 As T9914_AREA, Job As String, PRODJECTNAME As String, PROGRAMNO As String, SHEETNAME As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K9914_MOVE = False

        Try
            If READ_PFK9914(PRODJECTNAME, PROGRAMNO, SHEETNAME) = True Then
                z9914 = D9914
                K9914_MOVE = True
            Else
                z9914 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9914")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "PRODJECTNAME" : z9914.ProdjectName = Children(i).Code
                                Case "PROGRAMNO" : z9914.ProgramNo = Children(i).Code
                                Case "SHEETNAME" : z9914.SheetName = Children(i).Code
                                Case "COLSFROZEN" : z9914.ColsFrozen = Children(i).Code
                                Case "ROWSFROZEN" : z9914.RowsFrozen = Children(i).Code
                                Case "MAXROWS" : z9914.MaxRows = Children(i).Code
                                Case "OPERATIONMODE" : z9914.OperationMode = Children(i).Code
                                Case "LOCK" : z9914.Lock = Children(i).Code
                                Case "DEFAULTROWHEIGHT" : z9914.DefaultRowHeight = Children(i).Code
                                Case "HEADERTEXTMODE" : z9914.HeaderTextMode = Children(i).Code
                                Case "RETAINSELECTIONBLOCK" : z9914.RetainSelectionBlock = Children(i).Code
                                Case "AUTOCLIP" : z9914.AutoClip = Children(i).Code
                                Case "HEADER" : z9914.Header = Children(i).Code
                                Case "HEADERCOLUMN" : z9914.HeaderColumn = Children(i).Code
                                Case "HEADERROW" : z9914.HeaderRow = Children(i).Code
                                Case "SEPARATE" : z9914.Separate = Children(i).Code
                                Case "TOTALSEPARATE" : z9914.TotalSeparate = Children(i).Code
                                Case "COLUMNBASE" : z9914.ColumnBase = Children(i).Code
                                Case "COLUMNCAL" : z9914.ColumnCal = Children(i).Code
                                Case "MERGE" : z9914.Merge = Children(i).Code
                                Case "MERGECOLUMN" : z9914.MergeColumn = Children(i).Code
                                Case "MERGERETRICT" : z9914.MergeRetrict = Children(i).Code
                                Case "BACKCOLORCHECK" : z9914.BackColorCheck = Children(i).Code
                                Case "BACKCOLOR" : z9914.BackColor = Children(i).Code
                                Case "AREACOLORCHECK" : z9914.AreaColorCheck = Children(i).Code
                                Case "AREACOLOR" : z9914.AreaColor = Children(i).Code
                                Case "FONTSIZE" : z9914.Fontsize = Children(i).Code

                                Case "FixSize" : z9914.FixSize = Children(i).Code
                                Case "ZoomSize" : z9914.ZoomSize = Children(i).Code

                                Case "ROWHEIGHT" : z9914.Rowheight = Children(i).Code
                                Case "CHECKCOLUMNSPAN" : z9914.CheckColumnSpan = Children(i).Code
                                Case "COLHEADER1" : z9914.ColHeader1 = Children(i).Code
                                Case "COLHEADER2" : z9914.ColHeader2 = Children(i).Code
                                Case "COLUMNSPANID" : z9914.ColumnSpanID = Children(i).Code
                                Case "FOOTER" : z9914.Footer = Children(i).Code
                                Case "CHART" : z9914.Chart = Children(i).Code
                                Case "CHARTTYPE" : z9914.ChartType = Children(i).Code
                                Case "CHARTVISIBLE" : z9914.ChartVisible = Children(i).Code
                                Case "MOVECOLUMN" : z9914.MoveColumn = Children(i).Code
                                Case "MOVEROW" : z9914.MoveRow = Children(i).Code
                                Case "NAMECHART" : z9914.NameChart = Children(i).Code
                                Case "LINE" : z9914.Line = Children(i).Code
                                Case "LINEBASE" : z9914.LineBase = Children(i).Code
                                Case "BARBASE" : z9914.BarBase = Children(i).Code
                                Case "PIEBASE" : z9914.PieBase = Children(i).Code
                                Case "REMK" : z9914.REMK = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "PRODJECTNAME" : z9914.ProdjectName = Children(i).Data
                                Case "PROGRAMNO" : z9914.ProgramNo = Children(i).Data
                                Case "SHEETNAME" : z9914.SheetName = Children(i).Data
                                Case "COLSFROZEN" : z9914.ColsFrozen = Children(i).Data
                                Case "ROWSFROZEN" : z9914.RowsFrozen = Children(i).Data
                                Case "MAXROWS" : z9914.MaxRows = Children(i).Data
                                Case "OPERATIONMODE" : z9914.OperationMode = Children(i).Data
                                Case "LOCK" : z9914.Lock = Children(i).Data
                                Case "DEFAULTROWHEIGHT" : z9914.DefaultRowHeight = Children(i).Data
                                Case "HEADERTEXTMODE" : z9914.HeaderTextMode = Children(i).Data
                                Case "RETAINSELECTIONBLOCK" : z9914.RetainSelectionBlock = Children(i).Data
                                Case "AUTOCLIP" : z9914.AutoClip = Children(i).Data
                                Case "HEADER" : z9914.Header = Children(i).Data
                                Case "HEADERCOLUMN" : z9914.HeaderColumn = Children(i).Data
                                Case "HEADERROW" : z9914.HeaderRow = Children(i).Data
                                Case "SEPARATE" : z9914.Separate = Children(i).Data
                                Case "TOTALSEPARATE" : z9914.TotalSeparate = Children(i).Data
                                Case "COLUMNBASE" : z9914.ColumnBase = Children(i).Data
                                Case "COLUMNCAL" : z9914.ColumnCal = Children(i).Data
                                Case "MERGE" : z9914.Merge = Children(i).Data
                                Case "MERGECOLUMN" : z9914.MergeColumn = Children(i).Data
                                Case "MERGERETRICT" : z9914.MergeRetrict = Children(i).Data
                                Case "BACKCOLORCHECK" : z9914.BackColorCheck = Children(i).Data
                                Case "BACKCOLOR" : z9914.BackColor = Children(i).Data
                                Case "AREACOLORCHECK" : z9914.AreaColorCheck = Children(i).Data
                                Case "AREACOLOR" : z9914.AreaColor = Children(i).Data
                                Case "FONTSIZE" : z9914.Fontsize = Children(i).Data

                                Case "FixSize" : z9914.FixSize = Children(i).Data
                                Case "ZoomSize" : z9914.ZoomSize = Children(i).Data

                                Case "ROWHEIGHT" : z9914.Rowheight = Children(i).Data
                                Case "CHECKCOLUMNSPAN" : z9914.CheckColumnSpan = Children(i).Data
                                Case "COLHEADER1" : z9914.ColHeader1 = Children(i).Data
                                Case "COLHEADER2" : z9914.ColHeader2 = Children(i).Data
                                Case "COLUMNSPANID" : z9914.ColumnSpanID = Children(i).Data
                                Case "FOOTER" : z9914.Footer = Children(i).Data
                                Case "CHART" : z9914.Chart = Children(i).Data
                                Case "CHARTTYPE" : z9914.ChartType = Children(i).Data
                                Case "CHARTVISIBLE" : z9914.ChartVisible = Children(i).Data
                                Case "MOVECOLUMN" : z9914.MoveColumn = Children(i).Data
                                Case "MOVEROW" : z9914.MoveRow = Children(i).Data
                                Case "NAMECHART" : z9914.NameChart = Children(i).Data
                                Case "LINE" : z9914.Line = Children(i).Data
                                Case "LINEBASE" : z9914.LineBase = Children(i).Data
                                Case "BARBASE" : z9914.BarBase = Children(i).Data
                                Case "PIEBASE" : z9914.PieBase = Children(i).Data
                                Case "REMK" : z9914.REMK = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9914_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K9914_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z9914 As T9914_AREA, Job As String, CheckClear As Boolean, PRODJECTNAME As String, PROGRAMNO As String, SHEETNAME As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K9914_MOVE = False

        Try
            If READ_PFK9914(PRODJECTNAME, PROGRAMNO, SHEETNAME) = True Then
                z9914 = D9914
                K9914_MOVE = True
            Else
                If CheckClear = True Then z9914 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9914")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "PRODJECTNAME" : z9914.ProdjectName = Children(i).Code
                                Case "PROGRAMNO" : z9914.ProgramNo = Children(i).Code
                                Case "SHEETNAME" : z9914.SheetName = Children(i).Code
                                Case "COLSFROZEN" : z9914.ColsFrozen = Children(i).Code
                                Case "ROWSFROZEN" : z9914.RowsFrozen = Children(i).Code
                                Case "MAXROWS" : z9914.MaxRows = Children(i).Code
                                Case "OPERATIONMODE" : z9914.OperationMode = Children(i).Code
                                Case "LOCK" : z9914.Lock = Children(i).Code
                                Case "DEFAULTROWHEIGHT" : z9914.DefaultRowHeight = Children(i).Code
                                Case "HEADERTEXTMODE" : z9914.HeaderTextMode = Children(i).Code
                                Case "RETAINSELECTIONBLOCK" : z9914.RetainSelectionBlock = Children(i).Code
                                Case "AUTOCLIP" : z9914.AutoClip = Children(i).Code
                                Case "HEADER" : z9914.Header = Children(i).Code
                                Case "HEADERCOLUMN" : z9914.HeaderColumn = Children(i).Code
                                Case "HEADERROW" : z9914.HeaderRow = Children(i).Code
                                Case "SEPARATE" : z9914.Separate = Children(i).Code
                                Case "TOTALSEPARATE" : z9914.TotalSeparate = Children(i).Code
                                Case "COLUMNBASE" : z9914.ColumnBase = Children(i).Code
                                Case "COLUMNCAL" : z9914.ColumnCal = Children(i).Code
                                Case "MERGE" : z9914.Merge = Children(i).Code
                                Case "MERGECOLUMN" : z9914.MergeColumn = Children(i).Code
                                Case "MERGERETRICT" : z9914.MergeRetrict = Children(i).Code
                                Case "BACKCOLORCHECK" : z9914.BackColorCheck = Children(i).Code
                                Case "BACKCOLOR" : z9914.BackColor = Children(i).Code
                                Case "AREACOLORCHECK" : z9914.AreaColorCheck = Children(i).Code
                                Case "AREACOLOR" : z9914.AreaColor = Children(i).Code
                                Case "FONTSIZE" : z9914.Fontsize = Children(i).Code

                                Case "FixSize" : z9914.FixSize = Children(i).Code
                                Case "ZoomSize" : z9914.ZoomSize = Children(i).Code

                                Case "ROWHEIGHT" : z9914.Rowheight = Children(i).Code
                                Case "CHECKCOLUMNSPAN" : z9914.CheckColumnSpan = Children(i).Code
                                Case "COLHEADER1" : z9914.ColHeader1 = Children(i).Code
                                Case "COLHEADER2" : z9914.ColHeader2 = Children(i).Code
                                Case "COLUMNSPANID" : z9914.ColumnSpanID = Children(i).Code
                                Case "FOOTER" : z9914.Footer = Children(i).Code
                                Case "CHART" : z9914.Chart = Children(i).Code
                                Case "CHARTTYPE" : z9914.ChartType = Children(i).Code
                                Case "CHARTVISIBLE" : z9914.ChartVisible = Children(i).Code
                                Case "MOVECOLUMN" : z9914.MoveColumn = Children(i).Code
                                Case "MOVEROW" : z9914.MoveRow = Children(i).Code
                                Case "NAMECHART" : z9914.NameChart = Children(i).Code
                                Case "LINE" : z9914.Line = Children(i).Code
                                Case "LINEBASE" : z9914.LineBase = Children(i).Code
                                Case "BARBASE" : z9914.BarBase = Children(i).Code
                                Case "PIEBASE" : z9914.PieBase = Children(i).Code
                                Case "REMK" : z9914.REMK = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "PRODJECTNAME" : z9914.ProdjectName = Children(i).Data
                                Case "PROGRAMNO" : z9914.ProgramNo = Children(i).Data
                                Case "SHEETNAME" : z9914.SheetName = Children(i).Data
                                Case "COLSFROZEN" : z9914.ColsFrozen = Children(i).Data
                                Case "ROWSFROZEN" : z9914.RowsFrozen = Children(i).Data
                                Case "MAXROWS" : z9914.MaxRows = Children(i).Data
                                Case "OPERATIONMODE" : z9914.OperationMode = Children(i).Data
                                Case "LOCK" : z9914.Lock = Children(i).Data
                                Case "DEFAULTROWHEIGHT" : z9914.DefaultRowHeight = Children(i).Data
                                Case "HEADERTEXTMODE" : z9914.HeaderTextMode = Children(i).Data
                                Case "RETAINSELECTIONBLOCK" : z9914.RetainSelectionBlock = Children(i).Data
                                Case "AUTOCLIP" : z9914.AutoClip = Children(i).Data
                                Case "HEADER" : z9914.Header = Children(i).Data
                                Case "HEADERCOLUMN" : z9914.HeaderColumn = Children(i).Data
                                Case "HEADERROW" : z9914.HeaderRow = Children(i).Data
                                Case "SEPARATE" : z9914.Separate = Children(i).Data
                                Case "TOTALSEPARATE" : z9914.TotalSeparate = Children(i).Data
                                Case "COLUMNBASE" : z9914.ColumnBase = Children(i).Data
                                Case "COLUMNCAL" : z9914.ColumnCal = Children(i).Data
                                Case "MERGE" : z9914.Merge = Children(i).Data
                                Case "MERGECOLUMN" : z9914.MergeColumn = Children(i).Data
                                Case "MERGERETRICT" : z9914.MergeRetrict = Children(i).Data
                                Case "BACKCOLORCHECK" : z9914.BackColorCheck = Children(i).Data
                                Case "BACKCOLOR" : z9914.BackColor = Children(i).Data
                                Case "AREACOLORCHECK" : z9914.AreaColorCheck = Children(i).Data
                                Case "AREACOLOR" : z9914.AreaColor = Children(i).Data
                                Case "FONTSIZE" : z9914.Fontsize = Children(i).Data

                                Case "FixSize" : z9914.FixSize = Children(i).Data
                                Case "ZoomSize" : z9914.ZoomSize = Children(i).Data

                                Case "ROWHEIGHT" : z9914.Rowheight = Children(i).Data
                                Case "CHECKCOLUMNSPAN" : z9914.CheckColumnSpan = Children(i).Data
                                Case "COLHEADER1" : z9914.ColHeader1 = Children(i).Data
                                Case "COLHEADER2" : z9914.ColHeader2 = Children(i).Data
                                Case "COLUMNSPANID" : z9914.ColumnSpanID = Children(i).Data
                                Case "FOOTER" : z9914.Footer = Children(i).Data
                                Case "CHART" : z9914.Chart = Children(i).Data
                                Case "CHARTTYPE" : z9914.ChartType = Children(i).Data
                                Case "CHARTVISIBLE" : z9914.ChartVisible = Children(i).Data
                                Case "MOVECOLUMN" : z9914.MoveColumn = Children(i).Data
                                Case "MOVEROW" : z9914.MoveRow = Children(i).Data
                                Case "NAMECHART" : z9914.NameChart = Children(i).Data
                                Case "LINE" : z9914.Line = Children(i).Data
                                Case "LINEBASE" : z9914.LineBase = Children(i).Data
                                Case "BARBASE" : z9914.BarBase = Children(i).Data
                                Case "PIEBASE" : z9914.PieBase = Children(i).Data
                                Case "REMK" : z9914.REMK = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9914_MOVE", vbCritical)
        End Try
    End Function

End Module
