'=========================================================================================================================================================
'   TABLE : (PFK0112)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K0112

    Structure T0112_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public SpecNo As String  '			char(9)		*
        Public SpecNoSeq As String  '			char(3)		*
        Public MaterialSeq As Double  '			decimal		*
        Public ComponentName As String  '			nvarchar(50)		*
        Public DSeq As Double  '			decimal
        Public Specification As String  '			nvarchar(20)
        Public Width As String  '			nvarchar(20)
        Public Height As String  '			nvarchar(20)
        Public QtyComponent As Double  '			decimal
        Public CSizeQty01 As Double  '			decimal
        Public CSizeQty02 As Double  '			decimal
        Public CSizeQty03 As Double  '			decimal
        Public CSizeQty04 As Double  '			decimal
        Public CSizeQty05 As Double  '			decimal
        Public CSizeQty06 As Double  '			decimal
        Public CSizeQty07 As Double  '			decimal
        Public CSizeQty08 As Double  '			decimal
        Public CSizeQty09 As Double  '			decimal
        Public CSizeQty10 As Double  '			decimal
        Public CSizeQty11 As Double  '			decimal
        Public CSizeQty12 As Double  '			decimal
        Public CSizeQty13 As Double  '			decimal
        Public CSizeQty14 As Double  '			decimal
        Public CSizeQty15 As Double  '			decimal
        Public CSizeQty16 As Double  '			decimal
        Public CSizeQty17 As Double  '			decimal
        Public CSizeQty18 As Double  '			decimal
        Public CSizeQty19 As Double  '			decimal
        Public CSizeQty20 As Double  '			decimal
        Public CSizeQty21 As Double  '			decimal
        Public CSizeQty22 As Double  '			decimal
        Public CSizeQty23 As Double  '			decimal
        Public CSizeQty24 As Double  '			decimal
        Public CSizeQty25 As Double  '			decimal
        Public CSizeQty26 As Double  '			decimal
        Public CSizeQty27 As Double  '			decimal
        Public CSizeQty28 As Double  '			decimal
        Public CSizeQty29 As Double  '			decimal
        Public CSizeQty30 As Double  '			decimal
        Public Remark As String  '			nvarchar(50)
        '=========================================================================================================================================================
    End Structure

    Public D0112 As T0112_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK0112(SPECNO As String, SPECNOSEQ As String, MATERIALSEQ As Double, COMPONENTNAME As String) As Boolean
        READ_PFK0112 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK0112 "
            SQL = SQL & " WHERE K0112_SpecNo		 = '" & SpecNo & "' "
            SQL = SQL & "   AND K0112_SpecNoSeq		 = '" & SpecNoSeq & "' "
            SQL = SQL & "   AND K0112_MaterialSeq		 =  " & MaterialSeq & "  "
            SQL = SQL & "   AND K0112_ComponentName		 = '" & FormatSQL(COMPONENTNAME) & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D0112_CLEAR() : GoTo SKIP_READ_PFK0112

            Call K0112_MOVE(rd)
            READ_PFK0112 = True

SKIP_READ_PFK0112:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK0112", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK0112(SPECNO As String, SPECNOSEQ As String, MATERIALSEQ As Double, COMPONENTNAME As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK0112 "
            SQL = SQL & " WHERE K0112_SpecNo		 = '" & SpecNo & "' "
            SQL = SQL & "   AND K0112_SpecNoSeq		 = '" & SpecNoSeq & "' "
            SQL = SQL & "   AND K0112_MaterialSeq		 =  " & MaterialSeq & "  "
            SQL = SQL & "   AND K0112_ComponentName		 = '" & FormatSQL(COMPONENTNAME) & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK0112", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK0112(z0112 As T0112_AREA) As Boolean
        WRITE_PFK0112 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z0112)

            SQL = " INSERT INTO PFK0112 "
            SQL = SQL & " ( "
            SQL = SQL & " K0112_SpecNo,"
            SQL = SQL & " K0112_SpecNoSeq,"
            SQL = SQL & " K0112_MaterialSeq,"
            SQL = SQL & " K0112_ComponentName,"
            SQL = SQL & " K0112_DSeq,"
            SQL = SQL & " K0112_Specification,"
            SQL = SQL & " K0112_Width,"
            SQL = SQL & " K0112_Height,"
            SQL = SQL & " K0112_QtyComponent,"
            SQL = SQL & " K0112_CSizeQty01,"
            SQL = SQL & " K0112_CSizeQty02,"
            SQL = SQL & " K0112_CSizeQty03,"
            SQL = SQL & " K0112_CSizeQty04,"
            SQL = SQL & " K0112_CSizeQty05,"
            SQL = SQL & " K0112_CSizeQty06,"
            SQL = SQL & " K0112_CSizeQty07,"
            SQL = SQL & " K0112_CSizeQty08,"
            SQL = SQL & " K0112_CSizeQty09,"
            SQL = SQL & " K0112_CSizeQty10,"
            SQL = SQL & " K0112_CSizeQty11,"
            SQL = SQL & " K0112_CSizeQty12,"
            SQL = SQL & " K0112_CSizeQty13,"
            SQL = SQL & " K0112_CSizeQty14,"
            SQL = SQL & " K0112_CSizeQty15,"
            SQL = SQL & " K0112_CSizeQty16,"
            SQL = SQL & " K0112_CSizeQty17,"
            SQL = SQL & " K0112_CSizeQty18,"
            SQL = SQL & " K0112_CSizeQty19,"
            SQL = SQL & " K0112_CSizeQty20,"
            SQL = SQL & " K0112_CSizeQty21,"
            SQL = SQL & " K0112_CSizeQty22,"
            SQL = SQL & " K0112_CSizeQty23,"
            SQL = SQL & " K0112_CSizeQty24,"
            SQL = SQL & " K0112_CSizeQty25,"
            SQL = SQL & " K0112_CSizeQty26,"
            SQL = SQL & " K0112_CSizeQty27,"
            SQL = SQL & " K0112_CSizeQty28,"
            SQL = SQL & " K0112_CSizeQty29,"
            SQL = SQL & " K0112_CSizeQty30,"
            SQL = SQL & " K0112_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z0112.SpecNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0112.SpecNoSeq) & "', "
            SQL = SQL & "   " & FormatSQL(z0112.MaterialSeq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0112.ComponentName) & "', "
            SQL = SQL & "   " & FormatSQL(z0112.DSeq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0112.Specification) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0112.Width) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0112.Height) & "', "
            SQL = SQL & "   " & FormatSQL(z0112.QtyComponent) & ", "
            SQL = SQL & "   " & FormatSQL(z0112.CSizeQty01) & ", "
            SQL = SQL & "   " & FormatSQL(z0112.CSizeQty02) & ", "
            SQL = SQL & "   " & FormatSQL(z0112.CSizeQty03) & ", "
            SQL = SQL & "   " & FormatSQL(z0112.CSizeQty04) & ", "
            SQL = SQL & "   " & FormatSQL(z0112.CSizeQty05) & ", "
            SQL = SQL & "   " & FormatSQL(z0112.CSizeQty06) & ", "
            SQL = SQL & "   " & FormatSQL(z0112.CSizeQty07) & ", "
            SQL = SQL & "   " & FormatSQL(z0112.CSizeQty08) & ", "
            SQL = SQL & "   " & FormatSQL(z0112.CSizeQty09) & ", "
            SQL = SQL & "   " & FormatSQL(z0112.CSizeQty10) & ", "
            SQL = SQL & "   " & FormatSQL(z0112.CSizeQty11) & ", "
            SQL = SQL & "   " & FormatSQL(z0112.CSizeQty12) & ", "
            SQL = SQL & "   " & FormatSQL(z0112.CSizeQty13) & ", "
            SQL = SQL & "   " & FormatSQL(z0112.CSizeQty14) & ", "
            SQL = SQL & "   " & FormatSQL(z0112.CSizeQty15) & ", "
            SQL = SQL & "   " & FormatSQL(z0112.CSizeQty16) & ", "
            SQL = SQL & "   " & FormatSQL(z0112.CSizeQty17) & ", "
            SQL = SQL & "   " & FormatSQL(z0112.CSizeQty18) & ", "
            SQL = SQL & "   " & FormatSQL(z0112.CSizeQty19) & ", "
            SQL = SQL & "   " & FormatSQL(z0112.CSizeQty20) & ", "
            SQL = SQL & "   " & FormatSQL(z0112.CSizeQty21) & ", "
            SQL = SQL & "   " & FormatSQL(z0112.CSizeQty22) & ", "
            SQL = SQL & "   " & FormatSQL(z0112.CSizeQty23) & ", "
            SQL = SQL & "   " & FormatSQL(z0112.CSizeQty24) & ", "
            SQL = SQL & "   " & FormatSQL(z0112.CSizeQty25) & ", "
            SQL = SQL & "   " & FormatSQL(z0112.CSizeQty26) & ", "
            SQL = SQL & "   " & FormatSQL(z0112.CSizeQty27) & ", "
            SQL = SQL & "   " & FormatSQL(z0112.CSizeQty28) & ", "
            SQL = SQL & "   " & FormatSQL(z0112.CSizeQty29) & ", "
            SQL = SQL & "   " & FormatSQL(z0112.CSizeQty30) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0112.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK0112 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK0112", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK0112(z0112 As T0112_AREA) As Boolean
        REWRITE_PFK0112 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z0112)

            SQL = " UPDATE PFK0112 SET "
            SQL = SQL & "    K0112_DSeq      =  " & FormatSQL(z0112.DSeq) & ", "
            SQL = SQL & "    K0112_Specification      = N'" & FormatSQL(z0112.Specification) & "', "
            SQL = SQL & "    K0112_Width      = N'" & FormatSQL(z0112.Width) & "', "
            SQL = SQL & "    K0112_Height      = N'" & FormatSQL(z0112.Height) & "', "
            SQL = SQL & "    K0112_QtyComponent      =  " & FormatSQL(z0112.QtyComponent) & ", "
            SQL = SQL & "    K0112_CSizeQty01      =  " & FormatSQL(z0112.CSizeQty01) & ", "
            SQL = SQL & "    K0112_CSizeQty02      =  " & FormatSQL(z0112.CSizeQty02) & ", "
            SQL = SQL & "    K0112_CSizeQty03      =  " & FormatSQL(z0112.CSizeQty03) & ", "
            SQL = SQL & "    K0112_CSizeQty04      =  " & FormatSQL(z0112.CSizeQty04) & ", "
            SQL = SQL & "    K0112_CSizeQty05      =  " & FormatSQL(z0112.CSizeQty05) & ", "
            SQL = SQL & "    K0112_CSizeQty06      =  " & FormatSQL(z0112.CSizeQty06) & ", "
            SQL = SQL & "    K0112_CSizeQty07      =  " & FormatSQL(z0112.CSizeQty07) & ", "
            SQL = SQL & "    K0112_CSizeQty08      =  " & FormatSQL(z0112.CSizeQty08) & ", "
            SQL = SQL & "    K0112_CSizeQty09      =  " & FormatSQL(z0112.CSizeQty09) & ", "
            SQL = SQL & "    K0112_CSizeQty10      =  " & FormatSQL(z0112.CSizeQty10) & ", "
            SQL = SQL & "    K0112_CSizeQty11      =  " & FormatSQL(z0112.CSizeQty11) & ", "
            SQL = SQL & "    K0112_CSizeQty12      =  " & FormatSQL(z0112.CSizeQty12) & ", "
            SQL = SQL & "    K0112_CSizeQty13      =  " & FormatSQL(z0112.CSizeQty13) & ", "
            SQL = SQL & "    K0112_CSizeQty14      =  " & FormatSQL(z0112.CSizeQty14) & ", "
            SQL = SQL & "    K0112_CSizeQty15      =  " & FormatSQL(z0112.CSizeQty15) & ", "
            SQL = SQL & "    K0112_CSizeQty16      =  " & FormatSQL(z0112.CSizeQty16) & ", "
            SQL = SQL & "    K0112_CSizeQty17      =  " & FormatSQL(z0112.CSizeQty17) & ", "
            SQL = SQL & "    K0112_CSizeQty18      =  " & FormatSQL(z0112.CSizeQty18) & ", "
            SQL = SQL & "    K0112_CSizeQty19      =  " & FormatSQL(z0112.CSizeQty19) & ", "
            SQL = SQL & "    K0112_CSizeQty20      =  " & FormatSQL(z0112.CSizeQty20) & ", "
            SQL = SQL & "    K0112_CSizeQty21      =  " & FormatSQL(z0112.CSizeQty21) & ", "
            SQL = SQL & "    K0112_CSizeQty22      =  " & FormatSQL(z0112.CSizeQty22) & ", "
            SQL = SQL & "    K0112_CSizeQty23      =  " & FormatSQL(z0112.CSizeQty23) & ", "
            SQL = SQL & "    K0112_CSizeQty24      =  " & FormatSQL(z0112.CSizeQty24) & ", "
            SQL = SQL & "    K0112_CSizeQty25      =  " & FormatSQL(z0112.CSizeQty25) & ", "
            SQL = SQL & "    K0112_CSizeQty26      =  " & FormatSQL(z0112.CSizeQty26) & ", "
            SQL = SQL & "    K0112_CSizeQty27      =  " & FormatSQL(z0112.CSizeQty27) & ", "
            SQL = SQL & "    K0112_CSizeQty28      =  " & FormatSQL(z0112.CSizeQty28) & ", "
            SQL = SQL & "    K0112_CSizeQty29      =  " & FormatSQL(z0112.CSizeQty29) & ", "
            SQL = SQL & "    K0112_CSizeQty30      =  " & FormatSQL(z0112.CSizeQty30) & ", "
            SQL = SQL & "    K0112_Remark      = N'" & FormatSQL(z0112.Remark) & "'  "
            SQL = SQL & " WHERE K0112_SpecNo		 = '" & z0112.SpecNo & "' "
            SQL = SQL & "   AND K0112_SpecNoSeq		 = '" & z0112.SpecNoSeq & "' "
            SQL = SQL & "   AND K0112_MaterialSeq		 =  " & z0112.MaterialSeq & "  "
            SQL = SQL & "   AND K0112_ComponentName		 = '" & FormatSQL(z0112.ComponentName) & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK0112 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK0112", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK0112(z0112 As T0112_AREA) As Boolean
        DELETE_PFK0112 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK0112 "
            SQL = SQL & " WHERE K0112_SpecNo		 = '" & z0112.SpecNo & "' "
            SQL = SQL & "   AND K0112_SpecNoSeq		 = '" & z0112.SpecNoSeq & "' "
            SQL = SQL & "   AND K0112_MaterialSeq		 =  " & z0112.MaterialSeq & "  "
            SQL = SQL & "   AND K0112_ComponentName		 = '" & z0112.ComponentName & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK0112 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK0112", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D0112_CLEAR()
        Try

            D0112.SpecNo = ""
            D0112.SpecNoSeq = ""
            D0112.MaterialSeq = 0
            D0112.ComponentName = ""
            D0112.DSeq = 0
            D0112.Specification = ""
            D0112.Width = ""
            D0112.Height = ""
            D0112.QtyComponent = 0
            D0112.CSizeQty01 = 0
            D0112.CSizeQty02 = 0
            D0112.CSizeQty03 = 0
            D0112.CSizeQty04 = 0
            D0112.CSizeQty05 = 0
            D0112.CSizeQty06 = 0
            D0112.CSizeQty07 = 0
            D0112.CSizeQty08 = 0
            D0112.CSizeQty09 = 0
            D0112.CSizeQty10 = 0
            D0112.CSizeQty11 = 0
            D0112.CSizeQty12 = 0
            D0112.CSizeQty13 = 0
            D0112.CSizeQty14 = 0
            D0112.CSizeQty15 = 0
            D0112.CSizeQty16 = 0
            D0112.CSizeQty17 = 0
            D0112.CSizeQty18 = 0
            D0112.CSizeQty19 = 0
            D0112.CSizeQty20 = 0
            D0112.CSizeQty21 = 0
            D0112.CSizeQty22 = 0
            D0112.CSizeQty23 = 0
            D0112.CSizeQty24 = 0
            D0112.CSizeQty25 = 0
            D0112.CSizeQty26 = 0
            D0112.CSizeQty27 = 0
            D0112.CSizeQty28 = 0
            D0112.CSizeQty29 = 0
            D0112.CSizeQty30 = 0
            D0112.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D0112_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x0112 As T0112_AREA)
        Try

            x0112.SpecNo = trim$(x0112.SpecNo)
            x0112.SpecNoSeq = trim$(x0112.SpecNoSeq)
            x0112.MaterialSeq = trim$(x0112.MaterialSeq)
            x0112.ComponentName = trim$(x0112.ComponentName)
            x0112.DSeq = trim$(x0112.DSeq)
            x0112.Specification = trim$(x0112.Specification)
            x0112.Width = trim$(x0112.Width)
            x0112.Height = trim$(x0112.Height)
            x0112.QtyComponent = trim$(x0112.QtyComponent)
            x0112.CSizeQty01 = trim$(x0112.CSizeQty01)
            x0112.CSizeQty02 = trim$(x0112.CSizeQty02)
            x0112.CSizeQty03 = trim$(x0112.CSizeQty03)
            x0112.CSizeQty04 = trim$(x0112.CSizeQty04)
            x0112.CSizeQty05 = trim$(x0112.CSizeQty05)
            x0112.CSizeQty06 = trim$(x0112.CSizeQty06)
            x0112.CSizeQty07 = trim$(x0112.CSizeQty07)
            x0112.CSizeQty08 = trim$(x0112.CSizeQty08)
            x0112.CSizeQty09 = trim$(x0112.CSizeQty09)
            x0112.CSizeQty10 = trim$(x0112.CSizeQty10)
            x0112.CSizeQty11 = trim$(x0112.CSizeQty11)
            x0112.CSizeQty12 = trim$(x0112.CSizeQty12)
            x0112.CSizeQty13 = trim$(x0112.CSizeQty13)
            x0112.CSizeQty14 = trim$(x0112.CSizeQty14)
            x0112.CSizeQty15 = trim$(x0112.CSizeQty15)
            x0112.CSizeQty16 = trim$(x0112.CSizeQty16)
            x0112.CSizeQty17 = trim$(x0112.CSizeQty17)
            x0112.CSizeQty18 = trim$(x0112.CSizeQty18)
            x0112.CSizeQty19 = trim$(x0112.CSizeQty19)
            x0112.CSizeQty20 = trim$(x0112.CSizeQty20)
            x0112.CSizeQty21 = trim$(x0112.CSizeQty21)
            x0112.CSizeQty22 = trim$(x0112.CSizeQty22)
            x0112.CSizeQty23 = trim$(x0112.CSizeQty23)
            x0112.CSizeQty24 = trim$(x0112.CSizeQty24)
            x0112.CSizeQty25 = trim$(x0112.CSizeQty25)
            x0112.CSizeQty26 = trim$(x0112.CSizeQty26)
            x0112.CSizeQty27 = trim$(x0112.CSizeQty27)
            x0112.CSizeQty28 = trim$(x0112.CSizeQty28)
            x0112.CSizeQty29 = trim$(x0112.CSizeQty29)
            x0112.CSizeQty30 = trim$(x0112.CSizeQty30)
            x0112.Remark = trim$(x0112.Remark)

            If trim$(x0112.SpecNo) = "" Then x0112.SpecNo = Space(1)
            If trim$(x0112.SpecNoSeq) = "" Then x0112.SpecNoSeq = Space(1)
            If trim$(x0112.MaterialSeq) = "" Then x0112.MaterialSeq = 0
            If trim$(x0112.ComponentName) = "" Then x0112.ComponentName = Space(1)
            If trim$(x0112.DSeq) = "" Then x0112.DSeq = 0
            If trim$(x0112.Specification) = "" Then x0112.Specification = Space(1)
            If trim$(x0112.Width) = "" Then x0112.Width = Space(1)
            If trim$(x0112.Height) = "" Then x0112.Height = Space(1)
            If trim$(x0112.QtyComponent) = "" Then x0112.QtyComponent = 0
            If trim$(x0112.CSizeQty01) = "" Then x0112.CSizeQty01 = 0
            If trim$(x0112.CSizeQty02) = "" Then x0112.CSizeQty02 = 0
            If trim$(x0112.CSizeQty03) = "" Then x0112.CSizeQty03 = 0
            If trim$(x0112.CSizeQty04) = "" Then x0112.CSizeQty04 = 0
            If trim$(x0112.CSizeQty05) = "" Then x0112.CSizeQty05 = 0
            If trim$(x0112.CSizeQty06) = "" Then x0112.CSizeQty06 = 0
            If trim$(x0112.CSizeQty07) = "" Then x0112.CSizeQty07 = 0
            If trim$(x0112.CSizeQty08) = "" Then x0112.CSizeQty08 = 0
            If trim$(x0112.CSizeQty09) = "" Then x0112.CSizeQty09 = 0
            If trim$(x0112.CSizeQty10) = "" Then x0112.CSizeQty10 = 0
            If trim$(x0112.CSizeQty11) = "" Then x0112.CSizeQty11 = 0
            If trim$(x0112.CSizeQty12) = "" Then x0112.CSizeQty12 = 0
            If trim$(x0112.CSizeQty13) = "" Then x0112.CSizeQty13 = 0
            If trim$(x0112.CSizeQty14) = "" Then x0112.CSizeQty14 = 0
            If trim$(x0112.CSizeQty15) = "" Then x0112.CSizeQty15 = 0
            If trim$(x0112.CSizeQty16) = "" Then x0112.CSizeQty16 = 0
            If trim$(x0112.CSizeQty17) = "" Then x0112.CSizeQty17 = 0
            If trim$(x0112.CSizeQty18) = "" Then x0112.CSizeQty18 = 0
            If trim$(x0112.CSizeQty19) = "" Then x0112.CSizeQty19 = 0
            If trim$(x0112.CSizeQty20) = "" Then x0112.CSizeQty20 = 0
            If trim$(x0112.CSizeQty21) = "" Then x0112.CSizeQty21 = 0
            If trim$(x0112.CSizeQty22) = "" Then x0112.CSizeQty22 = 0
            If trim$(x0112.CSizeQty23) = "" Then x0112.CSizeQty23 = 0
            If trim$(x0112.CSizeQty24) = "" Then x0112.CSizeQty24 = 0
            If trim$(x0112.CSizeQty25) = "" Then x0112.CSizeQty25 = 0
            If trim$(x0112.CSizeQty26) = "" Then x0112.CSizeQty26 = 0
            If trim$(x0112.CSizeQty27) = "" Then x0112.CSizeQty27 = 0
            If trim$(x0112.CSizeQty28) = "" Then x0112.CSizeQty28 = 0
            If trim$(x0112.CSizeQty29) = "" Then x0112.CSizeQty29 = 0
            If trim$(x0112.CSizeQty30) = "" Then x0112.CSizeQty30 = 0
            If trim$(x0112.Remark) = "" Then x0112.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K0112_MOVE(rs0112 As SqlClient.SqlDataReader)
        Try

            Call D0112_CLEAR()

            If IsdbNull(rs0112!K0112_SpecNo) = False Then D0112.SpecNo = Trim$(rs0112!K0112_SpecNo)
            If IsdbNull(rs0112!K0112_SpecNoSeq) = False Then D0112.SpecNoSeq = Trim$(rs0112!K0112_SpecNoSeq)
            If IsdbNull(rs0112!K0112_MaterialSeq) = False Then D0112.MaterialSeq = Trim$(rs0112!K0112_MaterialSeq)
            If IsdbNull(rs0112!K0112_ComponentName) = False Then D0112.ComponentName = Trim$(rs0112!K0112_ComponentName)
            If IsdbNull(rs0112!K0112_DSeq) = False Then D0112.DSeq = Trim$(rs0112!K0112_DSeq)
            If IsdbNull(rs0112!K0112_Specification) = False Then D0112.Specification = Trim$(rs0112!K0112_Specification)
            If IsdbNull(rs0112!K0112_Width) = False Then D0112.Width = Trim$(rs0112!K0112_Width)
            If IsdbNull(rs0112!K0112_Height) = False Then D0112.Height = Trim$(rs0112!K0112_Height)
            If IsdbNull(rs0112!K0112_QtyComponent) = False Then D0112.QtyComponent = Trim$(rs0112!K0112_QtyComponent)
            If IsdbNull(rs0112!K0112_CSizeQty01) = False Then D0112.CSizeQty01 = Trim$(rs0112!K0112_CSizeQty01)
            If IsdbNull(rs0112!K0112_CSizeQty02) = False Then D0112.CSizeQty02 = Trim$(rs0112!K0112_CSizeQty02)
            If IsdbNull(rs0112!K0112_CSizeQty03) = False Then D0112.CSizeQty03 = Trim$(rs0112!K0112_CSizeQty03)
            If IsdbNull(rs0112!K0112_CSizeQty04) = False Then D0112.CSizeQty04 = Trim$(rs0112!K0112_CSizeQty04)
            If IsdbNull(rs0112!K0112_CSizeQty05) = False Then D0112.CSizeQty05 = Trim$(rs0112!K0112_CSizeQty05)
            If IsdbNull(rs0112!K0112_CSizeQty06) = False Then D0112.CSizeQty06 = Trim$(rs0112!K0112_CSizeQty06)
            If IsdbNull(rs0112!K0112_CSizeQty07) = False Then D0112.CSizeQty07 = Trim$(rs0112!K0112_CSizeQty07)
            If IsdbNull(rs0112!K0112_CSizeQty08) = False Then D0112.CSizeQty08 = Trim$(rs0112!K0112_CSizeQty08)
            If IsdbNull(rs0112!K0112_CSizeQty09) = False Then D0112.CSizeQty09 = Trim$(rs0112!K0112_CSizeQty09)
            If IsdbNull(rs0112!K0112_CSizeQty10) = False Then D0112.CSizeQty10 = Trim$(rs0112!K0112_CSizeQty10)
            If IsdbNull(rs0112!K0112_CSizeQty11) = False Then D0112.CSizeQty11 = Trim$(rs0112!K0112_CSizeQty11)
            If IsdbNull(rs0112!K0112_CSizeQty12) = False Then D0112.CSizeQty12 = Trim$(rs0112!K0112_CSizeQty12)
            If IsdbNull(rs0112!K0112_CSizeQty13) = False Then D0112.CSizeQty13 = Trim$(rs0112!K0112_CSizeQty13)
            If IsdbNull(rs0112!K0112_CSizeQty14) = False Then D0112.CSizeQty14 = Trim$(rs0112!K0112_CSizeQty14)
            If IsdbNull(rs0112!K0112_CSizeQty15) = False Then D0112.CSizeQty15 = Trim$(rs0112!K0112_CSizeQty15)
            If IsdbNull(rs0112!K0112_CSizeQty16) = False Then D0112.CSizeQty16 = Trim$(rs0112!K0112_CSizeQty16)
            If IsdbNull(rs0112!K0112_CSizeQty17) = False Then D0112.CSizeQty17 = Trim$(rs0112!K0112_CSizeQty17)
            If IsdbNull(rs0112!K0112_CSizeQty18) = False Then D0112.CSizeQty18 = Trim$(rs0112!K0112_CSizeQty18)
            If IsdbNull(rs0112!K0112_CSizeQty19) = False Then D0112.CSizeQty19 = Trim$(rs0112!K0112_CSizeQty19)
            If IsdbNull(rs0112!K0112_CSizeQty20) = False Then D0112.CSizeQty20 = Trim$(rs0112!K0112_CSizeQty20)
            If IsdbNull(rs0112!K0112_CSizeQty21) = False Then D0112.CSizeQty21 = Trim$(rs0112!K0112_CSizeQty21)
            If IsdbNull(rs0112!K0112_CSizeQty22) = False Then D0112.CSizeQty22 = Trim$(rs0112!K0112_CSizeQty22)
            If IsdbNull(rs0112!K0112_CSizeQty23) = False Then D0112.CSizeQty23 = Trim$(rs0112!K0112_CSizeQty23)
            If IsdbNull(rs0112!K0112_CSizeQty24) = False Then D0112.CSizeQty24 = Trim$(rs0112!K0112_CSizeQty24)
            If IsdbNull(rs0112!K0112_CSizeQty25) = False Then D0112.CSizeQty25 = Trim$(rs0112!K0112_CSizeQty25)
            If IsdbNull(rs0112!K0112_CSizeQty26) = False Then D0112.CSizeQty26 = Trim$(rs0112!K0112_CSizeQty26)
            If IsdbNull(rs0112!K0112_CSizeQty27) = False Then D0112.CSizeQty27 = Trim$(rs0112!K0112_CSizeQty27)
            If IsdbNull(rs0112!K0112_CSizeQty28) = False Then D0112.CSizeQty28 = Trim$(rs0112!K0112_CSizeQty28)
            If IsdbNull(rs0112!K0112_CSizeQty29) = False Then D0112.CSizeQty29 = Trim$(rs0112!K0112_CSizeQty29)
            If IsdbNull(rs0112!K0112_CSizeQty30) = False Then D0112.CSizeQty30 = Trim$(rs0112!K0112_CSizeQty30)
            If IsdbNull(rs0112!K0112_Remark) = False Then D0112.Remark = Trim$(rs0112!K0112_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K0112_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K0112_MOVE(rs0112 As DataRow)
        Try

            Call D0112_CLEAR()

            If IsdbNull(rs0112!K0112_SpecNo) = False Then D0112.SpecNo = Trim$(rs0112!K0112_SpecNo)
            If IsdbNull(rs0112!K0112_SpecNoSeq) = False Then D0112.SpecNoSeq = Trim$(rs0112!K0112_SpecNoSeq)
            If IsdbNull(rs0112!K0112_MaterialSeq) = False Then D0112.MaterialSeq = Trim$(rs0112!K0112_MaterialSeq)
            If IsdbNull(rs0112!K0112_ComponentName) = False Then D0112.ComponentName = Trim$(rs0112!K0112_ComponentName)
            If IsdbNull(rs0112!K0112_DSeq) = False Then D0112.DSeq = Trim$(rs0112!K0112_DSeq)
            If IsdbNull(rs0112!K0112_Specification) = False Then D0112.Specification = Trim$(rs0112!K0112_Specification)
            If IsdbNull(rs0112!K0112_Width) = False Then D0112.Width = Trim$(rs0112!K0112_Width)
            If IsdbNull(rs0112!K0112_Height) = False Then D0112.Height = Trim$(rs0112!K0112_Height)
            If IsdbNull(rs0112!K0112_QtyComponent) = False Then D0112.QtyComponent = Trim$(rs0112!K0112_QtyComponent)
            If IsdbNull(rs0112!K0112_CSizeQty01) = False Then D0112.CSizeQty01 = Trim$(rs0112!K0112_CSizeQty01)
            If IsdbNull(rs0112!K0112_CSizeQty02) = False Then D0112.CSizeQty02 = Trim$(rs0112!K0112_CSizeQty02)
            If IsdbNull(rs0112!K0112_CSizeQty03) = False Then D0112.CSizeQty03 = Trim$(rs0112!K0112_CSizeQty03)
            If IsdbNull(rs0112!K0112_CSizeQty04) = False Then D0112.CSizeQty04 = Trim$(rs0112!K0112_CSizeQty04)
            If IsdbNull(rs0112!K0112_CSizeQty05) = False Then D0112.CSizeQty05 = Trim$(rs0112!K0112_CSizeQty05)
            If IsdbNull(rs0112!K0112_CSizeQty06) = False Then D0112.CSizeQty06 = Trim$(rs0112!K0112_CSizeQty06)
            If IsdbNull(rs0112!K0112_CSizeQty07) = False Then D0112.CSizeQty07 = Trim$(rs0112!K0112_CSizeQty07)
            If IsdbNull(rs0112!K0112_CSizeQty08) = False Then D0112.CSizeQty08 = Trim$(rs0112!K0112_CSizeQty08)
            If IsdbNull(rs0112!K0112_CSizeQty09) = False Then D0112.CSizeQty09 = Trim$(rs0112!K0112_CSizeQty09)
            If IsdbNull(rs0112!K0112_CSizeQty10) = False Then D0112.CSizeQty10 = Trim$(rs0112!K0112_CSizeQty10)
            If IsdbNull(rs0112!K0112_CSizeQty11) = False Then D0112.CSizeQty11 = Trim$(rs0112!K0112_CSizeQty11)
            If IsdbNull(rs0112!K0112_CSizeQty12) = False Then D0112.CSizeQty12 = Trim$(rs0112!K0112_CSizeQty12)
            If IsdbNull(rs0112!K0112_CSizeQty13) = False Then D0112.CSizeQty13 = Trim$(rs0112!K0112_CSizeQty13)
            If IsdbNull(rs0112!K0112_CSizeQty14) = False Then D0112.CSizeQty14 = Trim$(rs0112!K0112_CSizeQty14)
            If IsdbNull(rs0112!K0112_CSizeQty15) = False Then D0112.CSizeQty15 = Trim$(rs0112!K0112_CSizeQty15)
            If IsdbNull(rs0112!K0112_CSizeQty16) = False Then D0112.CSizeQty16 = Trim$(rs0112!K0112_CSizeQty16)
            If IsdbNull(rs0112!K0112_CSizeQty17) = False Then D0112.CSizeQty17 = Trim$(rs0112!K0112_CSizeQty17)
            If IsdbNull(rs0112!K0112_CSizeQty18) = False Then D0112.CSizeQty18 = Trim$(rs0112!K0112_CSizeQty18)
            If IsdbNull(rs0112!K0112_CSizeQty19) = False Then D0112.CSizeQty19 = Trim$(rs0112!K0112_CSizeQty19)
            If IsdbNull(rs0112!K0112_CSizeQty20) = False Then D0112.CSizeQty20 = Trim$(rs0112!K0112_CSizeQty20)
            If IsdbNull(rs0112!K0112_CSizeQty21) = False Then D0112.CSizeQty21 = Trim$(rs0112!K0112_CSizeQty21)
            If IsdbNull(rs0112!K0112_CSizeQty22) = False Then D0112.CSizeQty22 = Trim$(rs0112!K0112_CSizeQty22)
            If IsdbNull(rs0112!K0112_CSizeQty23) = False Then D0112.CSizeQty23 = Trim$(rs0112!K0112_CSizeQty23)
            If IsdbNull(rs0112!K0112_CSizeQty24) = False Then D0112.CSizeQty24 = Trim$(rs0112!K0112_CSizeQty24)
            If IsdbNull(rs0112!K0112_CSizeQty25) = False Then D0112.CSizeQty25 = Trim$(rs0112!K0112_CSizeQty25)
            If IsdbNull(rs0112!K0112_CSizeQty26) = False Then D0112.CSizeQty26 = Trim$(rs0112!K0112_CSizeQty26)
            If IsdbNull(rs0112!K0112_CSizeQty27) = False Then D0112.CSizeQty27 = Trim$(rs0112!K0112_CSizeQty27)
            If IsdbNull(rs0112!K0112_CSizeQty28) = False Then D0112.CSizeQty28 = Trim$(rs0112!K0112_CSizeQty28)
            If IsdbNull(rs0112!K0112_CSizeQty29) = False Then D0112.CSizeQty29 = Trim$(rs0112!K0112_CSizeQty29)
            If IsdbNull(rs0112!K0112_CSizeQty30) = False Then D0112.CSizeQty30 = Trim$(rs0112!K0112_CSizeQty30)
            If IsdbNull(rs0112!K0112_Remark) = False Then D0112.Remark = Trim$(rs0112!K0112_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K0112_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K0112_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z0112 As T0112_AREA, SPECNO As String, SPECNOSEQ As String, MATERIALSEQ As Double, COMPONENTNAME As String) As Boolean

        K0112_MOVE = False

        Try
            If READ_PFK0112(SPECNO, SPECNOSEQ, MATERIALSEQ, COMPONENTNAME) = True Then
                z0112 = D0112
                K0112_MOVE = True
            Else
                z0112 = Nothing
            End If

            If getColumIndex(spr, "SpecNo") > -1 Then z0112.SpecNo = getDataM(spr, getColumIndex(spr, "SpecNo"), xRow)
            If getColumIndex(spr, "SpecNoSeq") > -1 Then z0112.SpecNoSeq = getDataM(spr, getColumIndex(spr, "SpecNoSeq"), xRow)
            If getColumIndex(spr, "MaterialSeq") > -1 Then z0112.MaterialSeq = getDataM(spr, getColumIndex(spr, "MaterialSeq"), xRow)
            If getColumIndex(spr, "ComponentName") > -1 Then z0112.ComponentName = getDataM(spr, getColumIndex(spr, "ComponentName"), xRow)
            If getColumIndex(spr, "DSeq") > -1 Then z0112.DSeq = getDataM(spr, getColumIndex(spr, "DSeq"), xRow)
            If getColumIndex(spr, "Specification") > -1 Then z0112.Specification = getDataM(spr, getColumIndex(spr, "Specification"), xRow)
            If getColumIndex(spr, "Width") > -1 Then z0112.Width = getDataM(spr, getColumIndex(spr, "Width"), xRow)
            If getColumIndex(spr, "Height") > -1 Then z0112.Height = getDataM(spr, getColumIndex(spr, "Height"), xRow)
            If getColumIndex(spr, "QtyComponent") > -1 Then z0112.QtyComponent = getDataM(spr, getColumIndex(spr, "QtyComponent"), xRow)
            If getColumIndex(spr, "CSizeQty01") > -1 Then z0112.CSizeQty01 = getDataM(spr, getColumIndex(spr, "CSizeQty01"), xRow)
            If getColumIndex(spr, "CSizeQty02") > -1 Then z0112.CSizeQty02 = getDataM(spr, getColumIndex(spr, "CSizeQty02"), xRow)
            If getColumIndex(spr, "CSizeQty03") > -1 Then z0112.CSizeQty03 = getDataM(spr, getColumIndex(spr, "CSizeQty03"), xRow)
            If getColumIndex(spr, "CSizeQty04") > -1 Then z0112.CSizeQty04 = getDataM(spr, getColumIndex(spr, "CSizeQty04"), xRow)
            If getColumIndex(spr, "CSizeQty05") > -1 Then z0112.CSizeQty05 = getDataM(spr, getColumIndex(spr, "CSizeQty05"), xRow)
            If getColumIndex(spr, "CSizeQty06") > -1 Then z0112.CSizeQty06 = getDataM(spr, getColumIndex(spr, "CSizeQty06"), xRow)
            If getColumIndex(spr, "CSizeQty07") > -1 Then z0112.CSizeQty07 = getDataM(spr, getColumIndex(spr, "CSizeQty07"), xRow)
            If getColumIndex(spr, "CSizeQty08") > -1 Then z0112.CSizeQty08 = getDataM(spr, getColumIndex(spr, "CSizeQty08"), xRow)
            If getColumIndex(spr, "CSizeQty09") > -1 Then z0112.CSizeQty09 = getDataM(spr, getColumIndex(spr, "CSizeQty09"), xRow)
            If getColumIndex(spr, "CSizeQty10") > -1 Then z0112.CSizeQty10 = getDataM(spr, getColumIndex(spr, "CSizeQty10"), xRow)
            If getColumIndex(spr, "CSizeQty11") > -1 Then z0112.CSizeQty11 = getDataM(spr, getColumIndex(spr, "CSizeQty11"), xRow)
            If getColumIndex(spr, "CSizeQty12") > -1 Then z0112.CSizeQty12 = getDataM(spr, getColumIndex(spr, "CSizeQty12"), xRow)
            If getColumIndex(spr, "CSizeQty13") > -1 Then z0112.CSizeQty13 = getDataM(spr, getColumIndex(spr, "CSizeQty13"), xRow)
            If getColumIndex(spr, "CSizeQty14") > -1 Then z0112.CSizeQty14 = getDataM(spr, getColumIndex(spr, "CSizeQty14"), xRow)
            If getColumIndex(spr, "CSizeQty15") > -1 Then z0112.CSizeQty15 = getDataM(spr, getColumIndex(spr, "CSizeQty15"), xRow)
            If getColumIndex(spr, "CSizeQty16") > -1 Then z0112.CSizeQty16 = getDataM(spr, getColumIndex(spr, "CSizeQty16"), xRow)
            If getColumIndex(spr, "CSizeQty17") > -1 Then z0112.CSizeQty17 = getDataM(spr, getColumIndex(spr, "CSizeQty17"), xRow)
            If getColumIndex(spr, "CSizeQty18") > -1 Then z0112.CSizeQty18 = getDataM(spr, getColumIndex(spr, "CSizeQty18"), xRow)
            If getColumIndex(spr, "CSizeQty19") > -1 Then z0112.CSizeQty19 = getDataM(spr, getColumIndex(spr, "CSizeQty19"), xRow)
            If getColumIndex(spr, "CSizeQty20") > -1 Then z0112.CSizeQty20 = getDataM(spr, getColumIndex(spr, "CSizeQty20"), xRow)
            If getColumIndex(spr, "CSizeQty21") > -1 Then z0112.CSizeQty21 = getDataM(spr, getColumIndex(spr, "CSizeQty21"), xRow)
            If getColumIndex(spr, "CSizeQty22") > -1 Then z0112.CSizeQty22 = getDataM(spr, getColumIndex(spr, "CSizeQty22"), xRow)
            If getColumIndex(spr, "CSizeQty23") > -1 Then z0112.CSizeQty23 = getDataM(spr, getColumIndex(spr, "CSizeQty23"), xRow)
            If getColumIndex(spr, "CSizeQty24") > -1 Then z0112.CSizeQty24 = getDataM(spr, getColumIndex(spr, "CSizeQty24"), xRow)
            If getColumIndex(spr, "CSizeQty25") > -1 Then z0112.CSizeQty25 = getDataM(spr, getColumIndex(spr, "CSizeQty25"), xRow)
            If getColumIndex(spr, "CSizeQty26") > -1 Then z0112.CSizeQty26 = getDataM(spr, getColumIndex(spr, "CSizeQty26"), xRow)
            If getColumIndex(spr, "CSizeQty27") > -1 Then z0112.CSizeQty27 = getDataM(spr, getColumIndex(spr, "CSizeQty27"), xRow)
            If getColumIndex(spr, "CSizeQty28") > -1 Then z0112.CSizeQty28 = getDataM(spr, getColumIndex(spr, "CSizeQty28"), xRow)
            If getColumIndex(spr, "CSizeQty29") > -1 Then z0112.CSizeQty29 = getDataM(spr, getColumIndex(spr, "CSizeQty29"), xRow)
            If getColumIndex(spr, "CSizeQty30") > -1 Then z0112.CSizeQty30 = getDataM(spr, getColumIndex(spr, "CSizeQty30"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z0112.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K0112_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K0112_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z0112 As T0112_AREA, CheckClear As Boolean, SPECNO As String, SPECNOSEQ As String, MATERIALSEQ As Double, COMPONENTNAME As String) As Boolean

        K0112_MOVE = False

        Try
            If READ_PFK0112(SPECNO, SPECNOSEQ, MATERIALSEQ, COMPONENTNAME) = True Then
                z0112 = D0112
                K0112_MOVE = True
            Else
                If CheckClear = True Then z0112 = Nothing
            End If

            If getColumIndex(spr, "SpecNo") > -1 Then z0112.SpecNo = getDataM(spr, getColumIndex(spr, "SpecNo"), xRow)
            If getColumIndex(spr, "SpecNoSeq") > -1 Then z0112.SpecNoSeq = getDataM(spr, getColumIndex(spr, "SpecNoSeq"), xRow)
            If getColumIndex(spr, "MaterialSeq") > -1 Then z0112.MaterialSeq = getDataM(spr, getColumIndex(spr, "MaterialSeq"), xRow)
            If getColumIndex(spr, "ComponentName") > -1 Then z0112.ComponentName = getDataM(spr, getColumIndex(spr, "ComponentName"), xRow)
            If getColumIndex(spr, "DSeq") > -1 Then z0112.DSeq = getDataM(spr, getColumIndex(spr, "DSeq"), xRow)
            If getColumIndex(spr, "Specification") > -1 Then z0112.Specification = getDataM(spr, getColumIndex(spr, "Specification"), xRow)
            If getColumIndex(spr, "Width") > -1 Then z0112.Width = getDataM(spr, getColumIndex(spr, "Width"), xRow)
            If getColumIndex(spr, "Height") > -1 Then z0112.Height = getDataM(spr, getColumIndex(spr, "Height"), xRow)
            If getColumIndex(spr, "QtyComponent") > -1 Then z0112.QtyComponent = getDataM(spr, getColumIndex(spr, "QtyComponent"), xRow)
            If getColumIndex(spr, "CSizeQty01") > -1 Then z0112.CSizeQty01 = getDataM(spr, getColumIndex(spr, "CSizeQty01"), xRow)
            If getColumIndex(spr, "CSizeQty02") > -1 Then z0112.CSizeQty02 = getDataM(spr, getColumIndex(spr, "CSizeQty02"), xRow)
            If getColumIndex(spr, "CSizeQty03") > -1 Then z0112.CSizeQty03 = getDataM(spr, getColumIndex(spr, "CSizeQty03"), xRow)
            If getColumIndex(spr, "CSizeQty04") > -1 Then z0112.CSizeQty04 = getDataM(spr, getColumIndex(spr, "CSizeQty04"), xRow)
            If getColumIndex(spr, "CSizeQty05") > -1 Then z0112.CSizeQty05 = getDataM(spr, getColumIndex(spr, "CSizeQty05"), xRow)
            If getColumIndex(spr, "CSizeQty06") > -1 Then z0112.CSizeQty06 = getDataM(spr, getColumIndex(spr, "CSizeQty06"), xRow)
            If getColumIndex(spr, "CSizeQty07") > -1 Then z0112.CSizeQty07 = getDataM(spr, getColumIndex(spr, "CSizeQty07"), xRow)
            If getColumIndex(spr, "CSizeQty08") > -1 Then z0112.CSizeQty08 = getDataM(spr, getColumIndex(spr, "CSizeQty08"), xRow)
            If getColumIndex(spr, "CSizeQty09") > -1 Then z0112.CSizeQty09 = getDataM(spr, getColumIndex(spr, "CSizeQty09"), xRow)
            If getColumIndex(spr, "CSizeQty10") > -1 Then z0112.CSizeQty10 = getDataM(spr, getColumIndex(spr, "CSizeQty10"), xRow)
            If getColumIndex(spr, "CSizeQty11") > -1 Then z0112.CSizeQty11 = getDataM(spr, getColumIndex(spr, "CSizeQty11"), xRow)
            If getColumIndex(spr, "CSizeQty12") > -1 Then z0112.CSizeQty12 = getDataM(spr, getColumIndex(spr, "CSizeQty12"), xRow)
            If getColumIndex(spr, "CSizeQty13") > -1 Then z0112.CSizeQty13 = getDataM(spr, getColumIndex(spr, "CSizeQty13"), xRow)
            If getColumIndex(spr, "CSizeQty14") > -1 Then z0112.CSizeQty14 = getDataM(spr, getColumIndex(spr, "CSizeQty14"), xRow)
            If getColumIndex(spr, "CSizeQty15") > -1 Then z0112.CSizeQty15 = getDataM(spr, getColumIndex(spr, "CSizeQty15"), xRow)
            If getColumIndex(spr, "CSizeQty16") > -1 Then z0112.CSizeQty16 = getDataM(spr, getColumIndex(spr, "CSizeQty16"), xRow)
            If getColumIndex(spr, "CSizeQty17") > -1 Then z0112.CSizeQty17 = getDataM(spr, getColumIndex(spr, "CSizeQty17"), xRow)
            If getColumIndex(spr, "CSizeQty18") > -1 Then z0112.CSizeQty18 = getDataM(spr, getColumIndex(spr, "CSizeQty18"), xRow)
            If getColumIndex(spr, "CSizeQty19") > -1 Then z0112.CSizeQty19 = getDataM(spr, getColumIndex(spr, "CSizeQty19"), xRow)
            If getColumIndex(spr, "CSizeQty20") > -1 Then z0112.CSizeQty20 = getDataM(spr, getColumIndex(spr, "CSizeQty20"), xRow)
            If getColumIndex(spr, "CSizeQty21") > -1 Then z0112.CSizeQty21 = getDataM(spr, getColumIndex(spr, "CSizeQty21"), xRow)
            If getColumIndex(spr, "CSizeQty22") > -1 Then z0112.CSizeQty22 = getDataM(spr, getColumIndex(spr, "CSizeQty22"), xRow)
            If getColumIndex(spr, "CSizeQty23") > -1 Then z0112.CSizeQty23 = getDataM(spr, getColumIndex(spr, "CSizeQty23"), xRow)
            If getColumIndex(spr, "CSizeQty24") > -1 Then z0112.CSizeQty24 = getDataM(spr, getColumIndex(spr, "CSizeQty24"), xRow)
            If getColumIndex(spr, "CSizeQty25") > -1 Then z0112.CSizeQty25 = getDataM(spr, getColumIndex(spr, "CSizeQty25"), xRow)
            If getColumIndex(spr, "CSizeQty26") > -1 Then z0112.CSizeQty26 = getDataM(spr, getColumIndex(spr, "CSizeQty26"), xRow)
            If getColumIndex(spr, "CSizeQty27") > -1 Then z0112.CSizeQty27 = getDataM(spr, getColumIndex(spr, "CSizeQty27"), xRow)
            If getColumIndex(spr, "CSizeQty28") > -1 Then z0112.CSizeQty28 = getDataM(spr, getColumIndex(spr, "CSizeQty28"), xRow)
            If getColumIndex(spr, "CSizeQty29") > -1 Then z0112.CSizeQty29 = getDataM(spr, getColumIndex(spr, "CSizeQty29"), xRow)
            If getColumIndex(spr, "CSizeQty30") > -1 Then z0112.CSizeQty30 = getDataM(spr, getColumIndex(spr, "CSizeQty30"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z0112.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K0112_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K0112_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z0112 As T0112_AREA, Job As String, SPECNO As String, SPECNOSEQ As String, MATERIALSEQ As Double, COMPONENTNAME As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K0112_MOVE = False

        Try
            If READ_PFK0112(SPECNO, SPECNOSEQ, MATERIALSEQ, COMPONENTNAME) = True Then
                z0112 = D0112
                K0112_MOVE = True
            Else
                z0112 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0112")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "SPECNO" : z0112.SpecNo = Children(i).Code
                                Case "SPECNOSEQ" : z0112.SpecNoSeq = Children(i).Code
                                Case "MATERIALSEQ" : z0112.MaterialSeq = Children(i).Code
                                Case "COMPONENTNAME" : z0112.ComponentName = Children(i).Code
                                Case "DSEQ" : z0112.DSeq = Children(i).Code
                                Case "SPECIFICATION" : z0112.Specification = Children(i).Code
                                Case "WIDTH" : z0112.Width = Children(i).Code
                                Case "HEIGHT" : z0112.Height = Children(i).Code
                                Case "QTYCOMPONENT" : z0112.QtyComponent = Children(i).Code
                                Case "CSIZEQTY01" : z0112.CSizeQty01 = Children(i).Code
                                Case "CSIZEQTY02" : z0112.CSizeQty02 = Children(i).Code
                                Case "CSIZEQTY03" : z0112.CSizeQty03 = Children(i).Code
                                Case "CSIZEQTY04" : z0112.CSizeQty04 = Children(i).Code
                                Case "CSIZEQTY05" : z0112.CSizeQty05 = Children(i).Code
                                Case "CSIZEQTY06" : z0112.CSizeQty06 = Children(i).Code
                                Case "CSIZEQTY07" : z0112.CSizeQty07 = Children(i).Code
                                Case "CSIZEQTY08" : z0112.CSizeQty08 = Children(i).Code
                                Case "CSIZEQTY09" : z0112.CSizeQty09 = Children(i).Code
                                Case "CSIZEQTY10" : z0112.CSizeQty10 = Children(i).Code
                                Case "CSIZEQTY11" : z0112.CSizeQty11 = Children(i).Code
                                Case "CSIZEQTY12" : z0112.CSizeQty12 = Children(i).Code
                                Case "CSIZEQTY13" : z0112.CSizeQty13 = Children(i).Code
                                Case "CSIZEQTY14" : z0112.CSizeQty14 = Children(i).Code
                                Case "CSIZEQTY15" : z0112.CSizeQty15 = Children(i).Code
                                Case "CSIZEQTY16" : z0112.CSizeQty16 = Children(i).Code
                                Case "CSIZEQTY17" : z0112.CSizeQty17 = Children(i).Code
                                Case "CSIZEQTY18" : z0112.CSizeQty18 = Children(i).Code
                                Case "CSIZEQTY19" : z0112.CSizeQty19 = Children(i).Code
                                Case "CSIZEQTY20" : z0112.CSizeQty20 = Children(i).Code
                                Case "CSIZEQTY21" : z0112.CSizeQty21 = Children(i).Code
                                Case "CSIZEQTY22" : z0112.CSizeQty22 = Children(i).Code
                                Case "CSIZEQTY23" : z0112.CSizeQty23 = Children(i).Code
                                Case "CSIZEQTY24" : z0112.CSizeQty24 = Children(i).Code
                                Case "CSIZEQTY25" : z0112.CSizeQty25 = Children(i).Code
                                Case "CSIZEQTY26" : z0112.CSizeQty26 = Children(i).Code
                                Case "CSIZEQTY27" : z0112.CSizeQty27 = Children(i).Code
                                Case "CSIZEQTY28" : z0112.CSizeQty28 = Children(i).Code
                                Case "CSIZEQTY29" : z0112.CSizeQty29 = Children(i).Code
                                Case "CSIZEQTY30" : z0112.CSizeQty30 = Children(i).Code
                                Case "REMARK" : z0112.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "SPECNO" : z0112.SpecNo = Children(i).Data
                                Case "SPECNOSEQ" : z0112.SpecNoSeq = Children(i).Data
                                Case "MATERIALSEQ" : z0112.MaterialSeq = Children(i).Data
                                Case "COMPONENTNAME" : z0112.ComponentName = Children(i).Data
                                Case "DSEQ" : z0112.DSeq = Children(i).Data
                                Case "SPECIFICATION" : z0112.Specification = Children(i).Data
                                Case "WIDTH" : z0112.Width = Children(i).Data
                                Case "HEIGHT" : z0112.Height = Children(i).Data
                                Case "QTYCOMPONENT" : z0112.QtyComponent = Children(i).Data
                                Case "CSIZEQTY01" : z0112.CSizeQty01 = Children(i).Data
                                Case "CSIZEQTY02" : z0112.CSizeQty02 = Children(i).Data
                                Case "CSIZEQTY03" : z0112.CSizeQty03 = Children(i).Data
                                Case "CSIZEQTY04" : z0112.CSizeQty04 = Children(i).Data
                                Case "CSIZEQTY05" : z0112.CSizeQty05 = Children(i).Data
                                Case "CSIZEQTY06" : z0112.CSizeQty06 = Children(i).Data
                                Case "CSIZEQTY07" : z0112.CSizeQty07 = Children(i).Data
                                Case "CSIZEQTY08" : z0112.CSizeQty08 = Children(i).Data
                                Case "CSIZEQTY09" : z0112.CSizeQty09 = Children(i).Data
                                Case "CSIZEQTY10" : z0112.CSizeQty10 = Children(i).Data
                                Case "CSIZEQTY11" : z0112.CSizeQty11 = Children(i).Data
                                Case "CSIZEQTY12" : z0112.CSizeQty12 = Children(i).Data
                                Case "CSIZEQTY13" : z0112.CSizeQty13 = Children(i).Data
                                Case "CSIZEQTY14" : z0112.CSizeQty14 = Children(i).Data
                                Case "CSIZEQTY15" : z0112.CSizeQty15 = Children(i).Data
                                Case "CSIZEQTY16" : z0112.CSizeQty16 = Children(i).Data
                                Case "CSIZEQTY17" : z0112.CSizeQty17 = Children(i).Data
                                Case "CSIZEQTY18" : z0112.CSizeQty18 = Children(i).Data
                                Case "CSIZEQTY19" : z0112.CSizeQty19 = Children(i).Data
                                Case "CSIZEQTY20" : z0112.CSizeQty20 = Children(i).Data
                                Case "CSIZEQTY21" : z0112.CSizeQty21 = Children(i).Data
                                Case "CSIZEQTY22" : z0112.CSizeQty22 = Children(i).Data
                                Case "CSIZEQTY23" : z0112.CSizeQty23 = Children(i).Data
                                Case "CSIZEQTY24" : z0112.CSizeQty24 = Children(i).Data
                                Case "CSIZEQTY25" : z0112.CSizeQty25 = Children(i).Data
                                Case "CSIZEQTY26" : z0112.CSizeQty26 = Children(i).Data
                                Case "CSIZEQTY27" : z0112.CSizeQty27 = Children(i).Data
                                Case "CSIZEQTY28" : z0112.CSizeQty28 = Children(i).Data
                                Case "CSIZEQTY29" : z0112.CSizeQty29 = Children(i).Data
                                Case "CSIZEQTY30" : z0112.CSizeQty30 = Children(i).Data
                                Case "REMARK" : z0112.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K0112_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K0112_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z0112 As T0112_AREA, Job As String, CheckClear As Boolean, SPECNO As String, SPECNOSEQ As String, MATERIALSEQ As Double, COMPONENTNAME As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K0112_MOVE = False

        Try
            If READ_PFK0112(SPECNO, SPECNOSEQ, MATERIALSEQ, COMPONENTNAME) = True Then
                z0112 = D0112
                K0112_MOVE = True
            Else
                If CheckClear = True Then z0112 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0112")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "SPECNO" : z0112.SpecNo = Children(i).Code
                                Case "SPECNOSEQ" : z0112.SpecNoSeq = Children(i).Code
                                Case "MATERIALSEQ" : z0112.MaterialSeq = Children(i).Code
                                Case "COMPONENTNAME" : z0112.ComponentName = Children(i).Code
                                Case "DSEQ" : z0112.DSeq = Children(i).Code
                                Case "SPECIFICATION" : z0112.Specification = Children(i).Code
                                Case "WIDTH" : z0112.Width = Children(i).Code
                                Case "HEIGHT" : z0112.Height = Children(i).Code
                                Case "QTYCOMPONENT" : z0112.QtyComponent = Children(i).Code
                                Case "CSIZEQTY01" : z0112.CSizeQty01 = Children(i).Code
                                Case "CSIZEQTY02" : z0112.CSizeQty02 = Children(i).Code
                                Case "CSIZEQTY03" : z0112.CSizeQty03 = Children(i).Code
                                Case "CSIZEQTY04" : z0112.CSizeQty04 = Children(i).Code
                                Case "CSIZEQTY05" : z0112.CSizeQty05 = Children(i).Code
                                Case "CSIZEQTY06" : z0112.CSizeQty06 = Children(i).Code
                                Case "CSIZEQTY07" : z0112.CSizeQty07 = Children(i).Code
                                Case "CSIZEQTY08" : z0112.CSizeQty08 = Children(i).Code
                                Case "CSIZEQTY09" : z0112.CSizeQty09 = Children(i).Code
                                Case "CSIZEQTY10" : z0112.CSizeQty10 = Children(i).Code
                                Case "CSIZEQTY11" : z0112.CSizeQty11 = Children(i).Code
                                Case "CSIZEQTY12" : z0112.CSizeQty12 = Children(i).Code
                                Case "CSIZEQTY13" : z0112.CSizeQty13 = Children(i).Code
                                Case "CSIZEQTY14" : z0112.CSizeQty14 = Children(i).Code
                                Case "CSIZEQTY15" : z0112.CSizeQty15 = Children(i).Code
                                Case "CSIZEQTY16" : z0112.CSizeQty16 = Children(i).Code
                                Case "CSIZEQTY17" : z0112.CSizeQty17 = Children(i).Code
                                Case "CSIZEQTY18" : z0112.CSizeQty18 = Children(i).Code
                                Case "CSIZEQTY19" : z0112.CSizeQty19 = Children(i).Code
                                Case "CSIZEQTY20" : z0112.CSizeQty20 = Children(i).Code
                                Case "CSIZEQTY21" : z0112.CSizeQty21 = Children(i).Code
                                Case "CSIZEQTY22" : z0112.CSizeQty22 = Children(i).Code
                                Case "CSIZEQTY23" : z0112.CSizeQty23 = Children(i).Code
                                Case "CSIZEQTY24" : z0112.CSizeQty24 = Children(i).Code
                                Case "CSIZEQTY25" : z0112.CSizeQty25 = Children(i).Code
                                Case "CSIZEQTY26" : z0112.CSizeQty26 = Children(i).Code
                                Case "CSIZEQTY27" : z0112.CSizeQty27 = Children(i).Code
                                Case "CSIZEQTY28" : z0112.CSizeQty28 = Children(i).Code
                                Case "CSIZEQTY29" : z0112.CSizeQty29 = Children(i).Code
                                Case "CSIZEQTY30" : z0112.CSizeQty30 = Children(i).Code
                                Case "REMARK" : z0112.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "SPECNO" : z0112.SpecNo = Children(i).Data
                                Case "SPECNOSEQ" : z0112.SpecNoSeq = Children(i).Data
                                Case "MATERIALSEQ" : z0112.MaterialSeq = Children(i).Data
                                Case "COMPONENTNAME" : z0112.ComponentName = Children(i).Data
                                Case "DSEQ" : z0112.DSeq = Children(i).Data
                                Case "SPECIFICATION" : z0112.Specification = Children(i).Data
                                Case "WIDTH" : z0112.Width = Children(i).Data
                                Case "HEIGHT" : z0112.Height = Children(i).Data
                                Case "QTYCOMPONENT" : z0112.QtyComponent = Children(i).Data
                                Case "CSIZEQTY01" : z0112.CSizeQty01 = Children(i).Data
                                Case "CSIZEQTY02" : z0112.CSizeQty02 = Children(i).Data
                                Case "CSIZEQTY03" : z0112.CSizeQty03 = Children(i).Data
                                Case "CSIZEQTY04" : z0112.CSizeQty04 = Children(i).Data
                                Case "CSIZEQTY05" : z0112.CSizeQty05 = Children(i).Data
                                Case "CSIZEQTY06" : z0112.CSizeQty06 = Children(i).Data
                                Case "CSIZEQTY07" : z0112.CSizeQty07 = Children(i).Data
                                Case "CSIZEQTY08" : z0112.CSizeQty08 = Children(i).Data
                                Case "CSIZEQTY09" : z0112.CSizeQty09 = Children(i).Data
                                Case "CSIZEQTY10" : z0112.CSizeQty10 = Children(i).Data
                                Case "CSIZEQTY11" : z0112.CSizeQty11 = Children(i).Data
                                Case "CSIZEQTY12" : z0112.CSizeQty12 = Children(i).Data
                                Case "CSIZEQTY13" : z0112.CSizeQty13 = Children(i).Data
                                Case "CSIZEQTY14" : z0112.CSizeQty14 = Children(i).Data
                                Case "CSIZEQTY15" : z0112.CSizeQty15 = Children(i).Data
                                Case "CSIZEQTY16" : z0112.CSizeQty16 = Children(i).Data
                                Case "CSIZEQTY17" : z0112.CSizeQty17 = Children(i).Data
                                Case "CSIZEQTY18" : z0112.CSizeQty18 = Children(i).Data
                                Case "CSIZEQTY19" : z0112.CSizeQty19 = Children(i).Data
                                Case "CSIZEQTY20" : z0112.CSizeQty20 = Children(i).Data
                                Case "CSIZEQTY21" : z0112.CSizeQty21 = Children(i).Data
                                Case "CSIZEQTY22" : z0112.CSizeQty22 = Children(i).Data
                                Case "CSIZEQTY23" : z0112.CSizeQty23 = Children(i).Data
                                Case "CSIZEQTY24" : z0112.CSizeQty24 = Children(i).Data
                                Case "CSIZEQTY25" : z0112.CSizeQty25 = Children(i).Data
                                Case "CSIZEQTY26" : z0112.CSizeQty26 = Children(i).Data
                                Case "CSIZEQTY27" : z0112.CSizeQty27 = Children(i).Data
                                Case "CSIZEQTY28" : z0112.CSizeQty28 = Children(i).Data
                                Case "CSIZEQTY29" : z0112.CSizeQty29 = Children(i).Data
                                Case "CSIZEQTY30" : z0112.CSizeQty30 = Children(i).Data
                                Case "REMARK" : z0112.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K0112_MOVE", vbCritical)
        End Try
    End Function

End Module
