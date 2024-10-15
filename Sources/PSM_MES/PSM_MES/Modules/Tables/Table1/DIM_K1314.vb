'=========================================================================================================================================================
'   TABLE : (PFK1314)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K1314

    Structure T1314_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public OrderNo As String  '			char(9)		*
        Public OrderNoSeq As String  '			char(3)		*
        Public ProcessOrder As Double  '			decimal		*
        Public seOrderProcess As String  '			char(3)
        Public cdOrderProcess As String  '			char(3)
        Public seProcessState As String  '			char(3)
        Public cdProcessState As String  '			char(3)
        Public SizeQty01 As Double  '			decimal
        Public SizeQty02 As Double  '			decimal
        Public SizeQty03 As Double  '			decimal
        Public SizeQty04 As Double  '			decimal
        Public SizeQty05 As Double  '			decimal
        Public SizeQty06 As Double  '			decimal
        Public SizeQty07 As Double  '			decimal
        Public SizeQty08 As Double  '			decimal
        Public SizeQty09 As Double  '			decimal
        Public SizeQty10 As Double  '			decimal
        Public SizeQty11 As Double  '			decimal
        Public SizeQty12 As Double  '			decimal
        Public SizeQty13 As Double  '			decimal
        Public SizeQty14 As Double  '			decimal
        Public SizeQty15 As Double  '			decimal
        Public SizeQty16 As Double  '			decimal
        Public SizeQty17 As Double  '			decimal
        Public SizeQty18 As Double  '			decimal
        Public SizeQty19 As Double  '			decimal
        Public SizeQty20 As Double  '			decimal
        Public SizeQty21 As Double  '			decimal
        Public SizeQty22 As Double  '			decimal
        Public SizeQty23 As Double  '			decimal
        Public SizeQty24 As Double  '			decimal
        Public SizeQty25 As Double  '			decimal
        Public SizeQty26 As Double  '			decimal
        Public SizeQty27 As Double  '			decimal
        Public SizeQty28 As Double  '			decimal
        Public SizeQty29 As Double  '			decimal
        Public SizeQty30 As Double  '			decimal
        Public Remark As String  '			nvarchar(500)
        '=========================================================================================================================================================
    End Structure

    Public D1314 As T1314_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK1314(ORDERNO As String, ORDERNOSEQ As String, PROCESSORDER As Double) As Boolean
        READ_PFK1314 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK1314 "
            SQL = SQL & " WHERE K1314_OrderNo		 = '" & OrderNo & "' "
            SQL = SQL & "   AND K1314_OrderNoSeq		 = '" & OrderNoSeq & "' "
            SQL = SQL & "   AND K1314_ProcessOrder		 =  " & ProcessOrder & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D1314_CLEAR() : GoTo SKIP_READ_PFK1314

            Call K1314_MOVE(rd)
            READ_PFK1314 = True

SKIP_READ_PFK1314:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK1314", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK1314(ORDERNO As String, ORDERNOSEQ As String, PROCESSORDER As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK1314 "
            SQL = SQL & " WHERE K1314_OrderNo		 = '" & OrderNo & "' "
            SQL = SQL & "   AND K1314_OrderNoSeq		 = '" & OrderNoSeq & "' "
            SQL = SQL & "   AND K1314_ProcessOrder		 =  " & ProcessOrder & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK1314", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK1314(z1314 As T1314_AREA) As Boolean
        WRITE_PFK1314 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z1314)

            SQL = " INSERT INTO PFK1314 "
            SQL = SQL & " ( "
            SQL = SQL & " K1314_OrderNo,"
            SQL = SQL & " K1314_OrderNoSeq,"
            SQL = SQL & " K1314_ProcessOrder,"
            SQL = SQL & " K1314_seOrderProcess,"
            SQL = SQL & " K1314_cdOrderProcess,"
            SQL = SQL & " K1314_seProcessState,"
            SQL = SQL & " K1314_cdProcessState,"
            SQL = SQL & " K1314_SizeQty01,"
            SQL = SQL & " K1314_SizeQty02,"
            SQL = SQL & " K1314_SizeQty03,"
            SQL = SQL & " K1314_SizeQty04,"
            SQL = SQL & " K1314_SizeQty05,"
            SQL = SQL & " K1314_SizeQty06,"
            SQL = SQL & " K1314_SizeQty07,"
            SQL = SQL & " K1314_SizeQty08,"
            SQL = SQL & " K1314_SizeQty09,"
            SQL = SQL & " K1314_SizeQty10,"
            SQL = SQL & " K1314_SizeQty11,"
            SQL = SQL & " K1314_SizeQty12,"
            SQL = SQL & " K1314_SizeQty13,"
            SQL = SQL & " K1314_SizeQty14,"
            SQL = SQL & " K1314_SizeQty15,"
            SQL = SQL & " K1314_SizeQty16,"
            SQL = SQL & " K1314_SizeQty17,"
            SQL = SQL & " K1314_SizeQty18,"
            SQL = SQL & " K1314_SizeQty19,"
            SQL = SQL & " K1314_SizeQty20,"
            SQL = SQL & " K1314_SizeQty21,"
            SQL = SQL & " K1314_SizeQty22,"
            SQL = SQL & " K1314_SizeQty23,"
            SQL = SQL & " K1314_SizeQty24,"
            SQL = SQL & " K1314_SizeQty25,"
            SQL = SQL & " K1314_SizeQty26,"
            SQL = SQL & " K1314_SizeQty27,"
            SQL = SQL & " K1314_SizeQty28,"
            SQL = SQL & " K1314_SizeQty29,"
            SQL = SQL & " K1314_SizeQty30,"
            SQL = SQL & " K1314_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z1314.OrderNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1314.OrderNoSeq) & "', "
            SQL = SQL & "   " & FormatSQL(z1314.ProcessOrder) & ", "
            SQL = SQL & "  N'" & FormatSQL(z1314.seOrderProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1314.cdOrderProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1314.seProcessState) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1314.cdProcessState) & "', "
            SQL = SQL & "   " & FormatSQL(z1314.SizeQty01) & ", "
            SQL = SQL & "   " & FormatSQL(z1314.SizeQty02) & ", "
            SQL = SQL & "   " & FormatSQL(z1314.SizeQty03) & ", "
            SQL = SQL & "   " & FormatSQL(z1314.SizeQty04) & ", "
            SQL = SQL & "   " & FormatSQL(z1314.SizeQty05) & ", "
            SQL = SQL & "   " & FormatSQL(z1314.SizeQty06) & ", "
            SQL = SQL & "   " & FormatSQL(z1314.SizeQty07) & ", "
            SQL = SQL & "   " & FormatSQL(z1314.SizeQty08) & ", "
            SQL = SQL & "   " & FormatSQL(z1314.SizeQty09) & ", "
            SQL = SQL & "   " & FormatSQL(z1314.SizeQty10) & ", "
            SQL = SQL & "   " & FormatSQL(z1314.SizeQty11) & ", "
            SQL = SQL & "   " & FormatSQL(z1314.SizeQty12) & ", "
            SQL = SQL & "   " & FormatSQL(z1314.SizeQty13) & ", "
            SQL = SQL & "   " & FormatSQL(z1314.SizeQty14) & ", "
            SQL = SQL & "   " & FormatSQL(z1314.SizeQty15) & ", "
            SQL = SQL & "   " & FormatSQL(z1314.SizeQty16) & ", "
            SQL = SQL & "   " & FormatSQL(z1314.SizeQty17) & ", "
            SQL = SQL & "   " & FormatSQL(z1314.SizeQty18) & ", "
            SQL = SQL & "   " & FormatSQL(z1314.SizeQty19) & ", "
            SQL = SQL & "   " & FormatSQL(z1314.SizeQty20) & ", "
            SQL = SQL & "   " & FormatSQL(z1314.SizeQty21) & ", "
            SQL = SQL & "   " & FormatSQL(z1314.SizeQty22) & ", "
            SQL = SQL & "   " & FormatSQL(z1314.SizeQty23) & ", "
            SQL = SQL & "   " & FormatSQL(z1314.SizeQty24) & ", "
            SQL = SQL & "   " & FormatSQL(z1314.SizeQty25) & ", "
            SQL = SQL & "   " & FormatSQL(z1314.SizeQty26) & ", "
            SQL = SQL & "   " & FormatSQL(z1314.SizeQty27) & ", "
            SQL = SQL & "   " & FormatSQL(z1314.SizeQty28) & ", "
            SQL = SQL & "   " & FormatSQL(z1314.SizeQty29) & ", "
            SQL = SQL & "   " & FormatSQL(z1314.SizeQty30) & ", "
            SQL = SQL & "  N'" & FormatSQL(z1314.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK1314 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK1314", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK1314(z1314 As T1314_AREA) As Boolean
        REWRITE_PFK1314 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z1314)

            SQL = " UPDATE PFK1314 SET "
            SQL = SQL & "    K1314_seOrderProcess      = N'" & FormatSQL(z1314.seOrderProcess) & "', "
            SQL = SQL & "    K1314_cdOrderProcess      = N'" & FormatSQL(z1314.cdOrderProcess) & "', "
            SQL = SQL & "    K1314_seProcessState      = N'" & FormatSQL(z1314.seProcessState) & "', "
            SQL = SQL & "    K1314_cdProcessState      = N'" & FormatSQL(z1314.cdProcessState) & "', "
            SQL = SQL & "    K1314_SizeQty01      =  " & FormatSQL(z1314.SizeQty01) & ", "
            SQL = SQL & "    K1314_SizeQty02      =  " & FormatSQL(z1314.SizeQty02) & ", "
            SQL = SQL & "    K1314_SizeQty03      =  " & FormatSQL(z1314.SizeQty03) & ", "
            SQL = SQL & "    K1314_SizeQty04      =  " & FormatSQL(z1314.SizeQty04) & ", "
            SQL = SQL & "    K1314_SizeQty05      =  " & FormatSQL(z1314.SizeQty05) & ", "
            SQL = SQL & "    K1314_SizeQty06      =  " & FormatSQL(z1314.SizeQty06) & ", "
            SQL = SQL & "    K1314_SizeQty07      =  " & FormatSQL(z1314.SizeQty07) & ", "
            SQL = SQL & "    K1314_SizeQty08      =  " & FormatSQL(z1314.SizeQty08) & ", "
            SQL = SQL & "    K1314_SizeQty09      =  " & FormatSQL(z1314.SizeQty09) & ", "
            SQL = SQL & "    K1314_SizeQty10      =  " & FormatSQL(z1314.SizeQty10) & ", "
            SQL = SQL & "    K1314_SizeQty11      =  " & FormatSQL(z1314.SizeQty11) & ", "
            SQL = SQL & "    K1314_SizeQty12      =  " & FormatSQL(z1314.SizeQty12) & ", "
            SQL = SQL & "    K1314_SizeQty13      =  " & FormatSQL(z1314.SizeQty13) & ", "
            SQL = SQL & "    K1314_SizeQty14      =  " & FormatSQL(z1314.SizeQty14) & ", "
            SQL = SQL & "    K1314_SizeQty15      =  " & FormatSQL(z1314.SizeQty15) & ", "
            SQL = SQL & "    K1314_SizeQty16      =  " & FormatSQL(z1314.SizeQty16) & ", "
            SQL = SQL & "    K1314_SizeQty17      =  " & FormatSQL(z1314.SizeQty17) & ", "
            SQL = SQL & "    K1314_SizeQty18      =  " & FormatSQL(z1314.SizeQty18) & ", "
            SQL = SQL & "    K1314_SizeQty19      =  " & FormatSQL(z1314.SizeQty19) & ", "
            SQL = SQL & "    K1314_SizeQty20      =  " & FormatSQL(z1314.SizeQty20) & ", "
            SQL = SQL & "    K1314_SizeQty21      =  " & FormatSQL(z1314.SizeQty21) & ", "
            SQL = SQL & "    K1314_SizeQty22      =  " & FormatSQL(z1314.SizeQty22) & ", "
            SQL = SQL & "    K1314_SizeQty23      =  " & FormatSQL(z1314.SizeQty23) & ", "
            SQL = SQL & "    K1314_SizeQty24      =  " & FormatSQL(z1314.SizeQty24) & ", "
            SQL = SQL & "    K1314_SizeQty25      =  " & FormatSQL(z1314.SizeQty25) & ", "
            SQL = SQL & "    K1314_SizeQty26      =  " & FormatSQL(z1314.SizeQty26) & ", "
            SQL = SQL & "    K1314_SizeQty27      =  " & FormatSQL(z1314.SizeQty27) & ", "
            SQL = SQL & "    K1314_SizeQty28      =  " & FormatSQL(z1314.SizeQty28) & ", "
            SQL = SQL & "    K1314_SizeQty29      =  " & FormatSQL(z1314.SizeQty29) & ", "
            SQL = SQL & "    K1314_SizeQty30      =  " & FormatSQL(z1314.SizeQty30) & ", "
            SQL = SQL & "    K1314_Remark      = N'" & FormatSQL(z1314.Remark) & "'  "
            SQL = SQL & " WHERE K1314_OrderNo		 = '" & z1314.OrderNo & "' "
            SQL = SQL & "   AND K1314_OrderNoSeq		 = '" & z1314.OrderNoSeq & "' "
            SQL = SQL & "   AND K1314_ProcessOrder		 =  " & z1314.ProcessOrder & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK1314 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK1314", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK1314(z1314 As T1314_AREA) As Boolean
        DELETE_PFK1314 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK1314 "
            SQL = SQL & " WHERE K1314_OrderNo		 = '" & z1314.OrderNo & "' "
            SQL = SQL & "   AND K1314_OrderNoSeq		 = '" & z1314.OrderNoSeq & "' "
            SQL = SQL & "   AND K1314_ProcessOrder		 =  " & z1314.ProcessOrder & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK1314 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK1314", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D1314_CLEAR()
        Try

            D1314.OrderNo = ""
            D1314.OrderNoSeq = ""
            D1314.ProcessOrder = 0
            D1314.seOrderProcess = ""
            D1314.cdOrderProcess = ""
            D1314.seProcessState = ""
            D1314.cdProcessState = ""
            D1314.SizeQty01 = 0
            D1314.SizeQty02 = 0
            D1314.SizeQty03 = 0
            D1314.SizeQty04 = 0
            D1314.SizeQty05 = 0
            D1314.SizeQty06 = 0
            D1314.SizeQty07 = 0
            D1314.SizeQty08 = 0
            D1314.SizeQty09 = 0
            D1314.SizeQty10 = 0
            D1314.SizeQty11 = 0
            D1314.SizeQty12 = 0
            D1314.SizeQty13 = 0
            D1314.SizeQty14 = 0
            D1314.SizeQty15 = 0
            D1314.SizeQty16 = 0
            D1314.SizeQty17 = 0
            D1314.SizeQty18 = 0
            D1314.SizeQty19 = 0
            D1314.SizeQty20 = 0
            D1314.SizeQty21 = 0
            D1314.SizeQty22 = 0
            D1314.SizeQty23 = 0
            D1314.SizeQty24 = 0
            D1314.SizeQty25 = 0
            D1314.SizeQty26 = 0
            D1314.SizeQty27 = 0
            D1314.SizeQty28 = 0
            D1314.SizeQty29 = 0
            D1314.SizeQty30 = 0
            D1314.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D1314_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x1314 As T1314_AREA)
        Try

            x1314.OrderNo = trim$(x1314.OrderNo)
            x1314.OrderNoSeq = trim$(x1314.OrderNoSeq)
            x1314.ProcessOrder = trim$(x1314.ProcessOrder)
            x1314.seOrderProcess = trim$(x1314.seOrderProcess)
            x1314.cdOrderProcess = trim$(x1314.cdOrderProcess)
            x1314.seProcessState = trim$(x1314.seProcessState)
            x1314.cdProcessState = trim$(x1314.cdProcessState)
            x1314.SizeQty01 = trim$(x1314.SizeQty01)
            x1314.SizeQty02 = trim$(x1314.SizeQty02)
            x1314.SizeQty03 = trim$(x1314.SizeQty03)
            x1314.SizeQty04 = trim$(x1314.SizeQty04)
            x1314.SizeQty05 = trim$(x1314.SizeQty05)
            x1314.SizeQty06 = trim$(x1314.SizeQty06)
            x1314.SizeQty07 = trim$(x1314.SizeQty07)
            x1314.SizeQty08 = trim$(x1314.SizeQty08)
            x1314.SizeQty09 = trim$(x1314.SizeQty09)
            x1314.SizeQty10 = trim$(x1314.SizeQty10)
            x1314.SizeQty11 = trim$(x1314.SizeQty11)
            x1314.SizeQty12 = trim$(x1314.SizeQty12)
            x1314.SizeQty13 = trim$(x1314.SizeQty13)
            x1314.SizeQty14 = trim$(x1314.SizeQty14)
            x1314.SizeQty15 = trim$(x1314.SizeQty15)
            x1314.SizeQty16 = trim$(x1314.SizeQty16)
            x1314.SizeQty17 = trim$(x1314.SizeQty17)
            x1314.SizeQty18 = trim$(x1314.SizeQty18)
            x1314.SizeQty19 = trim$(x1314.SizeQty19)
            x1314.SizeQty20 = trim$(x1314.SizeQty20)
            x1314.SizeQty21 = trim$(x1314.SizeQty21)
            x1314.SizeQty22 = trim$(x1314.SizeQty22)
            x1314.SizeQty23 = trim$(x1314.SizeQty23)
            x1314.SizeQty24 = trim$(x1314.SizeQty24)
            x1314.SizeQty25 = trim$(x1314.SizeQty25)
            x1314.SizeQty26 = trim$(x1314.SizeQty26)
            x1314.SizeQty27 = trim$(x1314.SizeQty27)
            x1314.SizeQty28 = trim$(x1314.SizeQty28)
            x1314.SizeQty29 = trim$(x1314.SizeQty29)
            x1314.SizeQty30 = trim$(x1314.SizeQty30)
            x1314.Remark = trim$(x1314.Remark)

            If trim$(x1314.OrderNo) = "" Then x1314.OrderNo = Space(1)
            If trim$(x1314.OrderNoSeq) = "" Then x1314.OrderNoSeq = Space(1)
            If trim$(x1314.ProcessOrder) = "" Then x1314.ProcessOrder = 0
            If trim$(x1314.seOrderProcess) = "" Then x1314.seOrderProcess = Space(1)
            If trim$(x1314.cdOrderProcess) = "" Then x1314.cdOrderProcess = Space(1)
            If trim$(x1314.seProcessState) = "" Then x1314.seProcessState = Space(1)
            If trim$(x1314.cdProcessState) = "" Then x1314.cdProcessState = Space(1)
            If trim$(x1314.SizeQty01) = "" Then x1314.SizeQty01 = 0
            If trim$(x1314.SizeQty02) = "" Then x1314.SizeQty02 = 0
            If trim$(x1314.SizeQty03) = "" Then x1314.SizeQty03 = 0
            If trim$(x1314.SizeQty04) = "" Then x1314.SizeQty04 = 0
            If trim$(x1314.SizeQty05) = "" Then x1314.SizeQty05 = 0
            If trim$(x1314.SizeQty06) = "" Then x1314.SizeQty06 = 0
            If trim$(x1314.SizeQty07) = "" Then x1314.SizeQty07 = 0
            If trim$(x1314.SizeQty08) = "" Then x1314.SizeQty08 = 0
            If trim$(x1314.SizeQty09) = "" Then x1314.SizeQty09 = 0
            If trim$(x1314.SizeQty10) = "" Then x1314.SizeQty10 = 0
            If trim$(x1314.SizeQty11) = "" Then x1314.SizeQty11 = 0
            If trim$(x1314.SizeQty12) = "" Then x1314.SizeQty12 = 0
            If trim$(x1314.SizeQty13) = "" Then x1314.SizeQty13 = 0
            If trim$(x1314.SizeQty14) = "" Then x1314.SizeQty14 = 0
            If trim$(x1314.SizeQty15) = "" Then x1314.SizeQty15 = 0
            If trim$(x1314.SizeQty16) = "" Then x1314.SizeQty16 = 0
            If trim$(x1314.SizeQty17) = "" Then x1314.SizeQty17 = 0
            If trim$(x1314.SizeQty18) = "" Then x1314.SizeQty18 = 0
            If trim$(x1314.SizeQty19) = "" Then x1314.SizeQty19 = 0
            If trim$(x1314.SizeQty20) = "" Then x1314.SizeQty20 = 0
            If trim$(x1314.SizeQty21) = "" Then x1314.SizeQty21 = 0
            If trim$(x1314.SizeQty22) = "" Then x1314.SizeQty22 = 0
            If trim$(x1314.SizeQty23) = "" Then x1314.SizeQty23 = 0
            If trim$(x1314.SizeQty24) = "" Then x1314.SizeQty24 = 0
            If trim$(x1314.SizeQty25) = "" Then x1314.SizeQty25 = 0
            If trim$(x1314.SizeQty26) = "" Then x1314.SizeQty26 = 0
            If trim$(x1314.SizeQty27) = "" Then x1314.SizeQty27 = 0
            If trim$(x1314.SizeQty28) = "" Then x1314.SizeQty28 = 0
            If trim$(x1314.SizeQty29) = "" Then x1314.SizeQty29 = 0
            If trim$(x1314.SizeQty30) = "" Then x1314.SizeQty30 = 0
            If trim$(x1314.Remark) = "" Then x1314.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K1314_MOVE(rs1314 As SqlClient.SqlDataReader)
        Try

            Call D1314_CLEAR()

            If IsdbNull(rs1314!K1314_OrderNo) = False Then D1314.OrderNo = Trim$(rs1314!K1314_OrderNo)
            If IsdbNull(rs1314!K1314_OrderNoSeq) = False Then D1314.OrderNoSeq = Trim$(rs1314!K1314_OrderNoSeq)
            If IsdbNull(rs1314!K1314_ProcessOrder) = False Then D1314.ProcessOrder = Trim$(rs1314!K1314_ProcessOrder)
            If IsdbNull(rs1314!K1314_seOrderProcess) = False Then D1314.seOrderProcess = Trim$(rs1314!K1314_seOrderProcess)
            If IsdbNull(rs1314!K1314_cdOrderProcess) = False Then D1314.cdOrderProcess = Trim$(rs1314!K1314_cdOrderProcess)
            If IsdbNull(rs1314!K1314_seProcessState) = False Then D1314.seProcessState = Trim$(rs1314!K1314_seProcessState)
            If IsdbNull(rs1314!K1314_cdProcessState) = False Then D1314.cdProcessState = Trim$(rs1314!K1314_cdProcessState)
            If IsdbNull(rs1314!K1314_SizeQty01) = False Then D1314.SizeQty01 = Trim$(rs1314!K1314_SizeQty01)
            If IsdbNull(rs1314!K1314_SizeQty02) = False Then D1314.SizeQty02 = Trim$(rs1314!K1314_SizeQty02)
            If IsdbNull(rs1314!K1314_SizeQty03) = False Then D1314.SizeQty03 = Trim$(rs1314!K1314_SizeQty03)
            If IsdbNull(rs1314!K1314_SizeQty04) = False Then D1314.SizeQty04 = Trim$(rs1314!K1314_SizeQty04)
            If IsdbNull(rs1314!K1314_SizeQty05) = False Then D1314.SizeQty05 = Trim$(rs1314!K1314_SizeQty05)
            If IsdbNull(rs1314!K1314_SizeQty06) = False Then D1314.SizeQty06 = Trim$(rs1314!K1314_SizeQty06)
            If IsdbNull(rs1314!K1314_SizeQty07) = False Then D1314.SizeQty07 = Trim$(rs1314!K1314_SizeQty07)
            If IsdbNull(rs1314!K1314_SizeQty08) = False Then D1314.SizeQty08 = Trim$(rs1314!K1314_SizeQty08)
            If IsdbNull(rs1314!K1314_SizeQty09) = False Then D1314.SizeQty09 = Trim$(rs1314!K1314_SizeQty09)
            If IsdbNull(rs1314!K1314_SizeQty10) = False Then D1314.SizeQty10 = Trim$(rs1314!K1314_SizeQty10)
            If IsdbNull(rs1314!K1314_SizeQty11) = False Then D1314.SizeQty11 = Trim$(rs1314!K1314_SizeQty11)
            If IsdbNull(rs1314!K1314_SizeQty12) = False Then D1314.SizeQty12 = Trim$(rs1314!K1314_SizeQty12)
            If IsdbNull(rs1314!K1314_SizeQty13) = False Then D1314.SizeQty13 = Trim$(rs1314!K1314_SizeQty13)
            If IsdbNull(rs1314!K1314_SizeQty14) = False Then D1314.SizeQty14 = Trim$(rs1314!K1314_SizeQty14)
            If IsdbNull(rs1314!K1314_SizeQty15) = False Then D1314.SizeQty15 = Trim$(rs1314!K1314_SizeQty15)
            If IsdbNull(rs1314!K1314_SizeQty16) = False Then D1314.SizeQty16 = Trim$(rs1314!K1314_SizeQty16)
            If IsdbNull(rs1314!K1314_SizeQty17) = False Then D1314.SizeQty17 = Trim$(rs1314!K1314_SizeQty17)
            If IsdbNull(rs1314!K1314_SizeQty18) = False Then D1314.SizeQty18 = Trim$(rs1314!K1314_SizeQty18)
            If IsdbNull(rs1314!K1314_SizeQty19) = False Then D1314.SizeQty19 = Trim$(rs1314!K1314_SizeQty19)
            If IsdbNull(rs1314!K1314_SizeQty20) = False Then D1314.SizeQty20 = Trim$(rs1314!K1314_SizeQty20)
            If IsdbNull(rs1314!K1314_SizeQty21) = False Then D1314.SizeQty21 = Trim$(rs1314!K1314_SizeQty21)
            If IsdbNull(rs1314!K1314_SizeQty22) = False Then D1314.SizeQty22 = Trim$(rs1314!K1314_SizeQty22)
            If IsdbNull(rs1314!K1314_SizeQty23) = False Then D1314.SizeQty23 = Trim$(rs1314!K1314_SizeQty23)
            If IsdbNull(rs1314!K1314_SizeQty24) = False Then D1314.SizeQty24 = Trim$(rs1314!K1314_SizeQty24)
            If IsdbNull(rs1314!K1314_SizeQty25) = False Then D1314.SizeQty25 = Trim$(rs1314!K1314_SizeQty25)
            If IsdbNull(rs1314!K1314_SizeQty26) = False Then D1314.SizeQty26 = Trim$(rs1314!K1314_SizeQty26)
            If IsdbNull(rs1314!K1314_SizeQty27) = False Then D1314.SizeQty27 = Trim$(rs1314!K1314_SizeQty27)
            If IsdbNull(rs1314!K1314_SizeQty28) = False Then D1314.SizeQty28 = Trim$(rs1314!K1314_SizeQty28)
            If IsdbNull(rs1314!K1314_SizeQty29) = False Then D1314.SizeQty29 = Trim$(rs1314!K1314_SizeQty29)
            If IsdbNull(rs1314!K1314_SizeQty30) = False Then D1314.SizeQty30 = Trim$(rs1314!K1314_SizeQty30)
            If IsdbNull(rs1314!K1314_Remark) = False Then D1314.Remark = Trim$(rs1314!K1314_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K1314_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K1314_MOVE(rs1314 As DataRow)
        Try

            Call D1314_CLEAR()

            If IsdbNull(rs1314!K1314_OrderNo) = False Then D1314.OrderNo = Trim$(rs1314!K1314_OrderNo)
            If IsdbNull(rs1314!K1314_OrderNoSeq) = False Then D1314.OrderNoSeq = Trim$(rs1314!K1314_OrderNoSeq)
            If IsdbNull(rs1314!K1314_ProcessOrder) = False Then D1314.ProcessOrder = Trim$(rs1314!K1314_ProcessOrder)
            If IsdbNull(rs1314!K1314_seOrderProcess) = False Then D1314.seOrderProcess = Trim$(rs1314!K1314_seOrderProcess)
            If IsdbNull(rs1314!K1314_cdOrderProcess) = False Then D1314.cdOrderProcess = Trim$(rs1314!K1314_cdOrderProcess)
            If IsdbNull(rs1314!K1314_seProcessState) = False Then D1314.seProcessState = Trim$(rs1314!K1314_seProcessState)
            If IsdbNull(rs1314!K1314_cdProcessState) = False Then D1314.cdProcessState = Trim$(rs1314!K1314_cdProcessState)
            If IsdbNull(rs1314!K1314_SizeQty01) = False Then D1314.SizeQty01 = Trim$(rs1314!K1314_SizeQty01)
            If IsdbNull(rs1314!K1314_SizeQty02) = False Then D1314.SizeQty02 = Trim$(rs1314!K1314_SizeQty02)
            If IsdbNull(rs1314!K1314_SizeQty03) = False Then D1314.SizeQty03 = Trim$(rs1314!K1314_SizeQty03)
            If IsdbNull(rs1314!K1314_SizeQty04) = False Then D1314.SizeQty04 = Trim$(rs1314!K1314_SizeQty04)
            If IsdbNull(rs1314!K1314_SizeQty05) = False Then D1314.SizeQty05 = Trim$(rs1314!K1314_SizeQty05)
            If IsdbNull(rs1314!K1314_SizeQty06) = False Then D1314.SizeQty06 = Trim$(rs1314!K1314_SizeQty06)
            If IsdbNull(rs1314!K1314_SizeQty07) = False Then D1314.SizeQty07 = Trim$(rs1314!K1314_SizeQty07)
            If IsdbNull(rs1314!K1314_SizeQty08) = False Then D1314.SizeQty08 = Trim$(rs1314!K1314_SizeQty08)
            If IsdbNull(rs1314!K1314_SizeQty09) = False Then D1314.SizeQty09 = Trim$(rs1314!K1314_SizeQty09)
            If IsdbNull(rs1314!K1314_SizeQty10) = False Then D1314.SizeQty10 = Trim$(rs1314!K1314_SizeQty10)
            If IsdbNull(rs1314!K1314_SizeQty11) = False Then D1314.SizeQty11 = Trim$(rs1314!K1314_SizeQty11)
            If IsdbNull(rs1314!K1314_SizeQty12) = False Then D1314.SizeQty12 = Trim$(rs1314!K1314_SizeQty12)
            If IsdbNull(rs1314!K1314_SizeQty13) = False Then D1314.SizeQty13 = Trim$(rs1314!K1314_SizeQty13)
            If IsdbNull(rs1314!K1314_SizeQty14) = False Then D1314.SizeQty14 = Trim$(rs1314!K1314_SizeQty14)
            If IsdbNull(rs1314!K1314_SizeQty15) = False Then D1314.SizeQty15 = Trim$(rs1314!K1314_SizeQty15)
            If IsdbNull(rs1314!K1314_SizeQty16) = False Then D1314.SizeQty16 = Trim$(rs1314!K1314_SizeQty16)
            If IsdbNull(rs1314!K1314_SizeQty17) = False Then D1314.SizeQty17 = Trim$(rs1314!K1314_SizeQty17)
            If IsdbNull(rs1314!K1314_SizeQty18) = False Then D1314.SizeQty18 = Trim$(rs1314!K1314_SizeQty18)
            If IsdbNull(rs1314!K1314_SizeQty19) = False Then D1314.SizeQty19 = Trim$(rs1314!K1314_SizeQty19)
            If IsdbNull(rs1314!K1314_SizeQty20) = False Then D1314.SizeQty20 = Trim$(rs1314!K1314_SizeQty20)
            If IsdbNull(rs1314!K1314_SizeQty21) = False Then D1314.SizeQty21 = Trim$(rs1314!K1314_SizeQty21)
            If IsdbNull(rs1314!K1314_SizeQty22) = False Then D1314.SizeQty22 = Trim$(rs1314!K1314_SizeQty22)
            If IsdbNull(rs1314!K1314_SizeQty23) = False Then D1314.SizeQty23 = Trim$(rs1314!K1314_SizeQty23)
            If IsdbNull(rs1314!K1314_SizeQty24) = False Then D1314.SizeQty24 = Trim$(rs1314!K1314_SizeQty24)
            If IsdbNull(rs1314!K1314_SizeQty25) = False Then D1314.SizeQty25 = Trim$(rs1314!K1314_SizeQty25)
            If IsdbNull(rs1314!K1314_SizeQty26) = False Then D1314.SizeQty26 = Trim$(rs1314!K1314_SizeQty26)
            If IsdbNull(rs1314!K1314_SizeQty27) = False Then D1314.SizeQty27 = Trim$(rs1314!K1314_SizeQty27)
            If IsdbNull(rs1314!K1314_SizeQty28) = False Then D1314.SizeQty28 = Trim$(rs1314!K1314_SizeQty28)
            If IsdbNull(rs1314!K1314_SizeQty29) = False Then D1314.SizeQty29 = Trim$(rs1314!K1314_SizeQty29)
            If IsdbNull(rs1314!K1314_SizeQty30) = False Then D1314.SizeQty30 = Trim$(rs1314!K1314_SizeQty30)
            If IsdbNull(rs1314!K1314_Remark) = False Then D1314.Remark = Trim$(rs1314!K1314_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K1314_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K1314_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z1314 As T1314_AREA, ORDERNO As String, ORDERNOSEQ As String, PROCESSORDER As Double) As Boolean

        K1314_MOVE = False

        Try
            If READ_PFK1314(ORDERNO, ORDERNOSEQ, PROCESSORDER) = True Then
                z1314 = D1314
                K1314_MOVE = True
            Else
                z1314 = Nothing
            End If

            If getColumIndex(spr, "OrderNo") > -1 Then z1314.OrderNo = getDataM(spr, getColumIndex(spr, "OrderNo"), xRow)
            If getColumIndex(spr, "OrderNoSeq") > -1 Then z1314.OrderNoSeq = getDataM(spr, getColumIndex(spr, "OrderNoSeq"), xRow)
            If getColumIndex(spr, "ProcessOrder") > -1 Then z1314.ProcessOrder = getDataM(spr, getColumIndex(spr, "ProcessOrder"), xRow)
            If getColumIndex(spr, "seOrderProcess") > -1 Then z1314.seOrderProcess = getDataM(spr, getColumIndex(spr, "seOrderProcess"), xRow)
            If getColumIndex(spr, "cdOrderProcess") > -1 Then z1314.cdOrderProcess = getDataM(spr, getColumIndex(spr, "cdOrderProcess"), xRow)
            If getColumIndex(spr, "seProcessState") > -1 Then z1314.seProcessState = getDataM(spr, getColumIndex(spr, "seProcessState"), xRow)
            If getColumIndex(spr, "cdProcessState") > -1 Then z1314.cdProcessState = getDataM(spr, getColumIndex(spr, "cdProcessState"), xRow)
            If getColumIndex(spr, "SizeQty01") > -1 Then z1314.SizeQty01 = getDataM(spr, getColumIndex(spr, "SizeQty01"), xRow)
            If getColumIndex(spr, "SizeQty02") > -1 Then z1314.SizeQty02 = getDataM(spr, getColumIndex(spr, "SizeQty02"), xRow)
            If getColumIndex(spr, "SizeQty03") > -1 Then z1314.SizeQty03 = getDataM(spr, getColumIndex(spr, "SizeQty03"), xRow)
            If getColumIndex(spr, "SizeQty04") > -1 Then z1314.SizeQty04 = getDataM(spr, getColumIndex(spr, "SizeQty04"), xRow)
            If getColumIndex(spr, "SizeQty05") > -1 Then z1314.SizeQty05 = getDataM(spr, getColumIndex(spr, "SizeQty05"), xRow)
            If getColumIndex(spr, "SizeQty06") > -1 Then z1314.SizeQty06 = getDataM(spr, getColumIndex(spr, "SizeQty06"), xRow)
            If getColumIndex(spr, "SizeQty07") > -1 Then z1314.SizeQty07 = getDataM(spr, getColumIndex(spr, "SizeQty07"), xRow)
            If getColumIndex(spr, "SizeQty08") > -1 Then z1314.SizeQty08 = getDataM(spr, getColumIndex(spr, "SizeQty08"), xRow)
            If getColumIndex(spr, "SizeQty09") > -1 Then z1314.SizeQty09 = getDataM(spr, getColumIndex(spr, "SizeQty09"), xRow)
            If getColumIndex(spr, "SizeQty10") > -1 Then z1314.SizeQty10 = getDataM(spr, getColumIndex(spr, "SizeQty10"), xRow)
            If getColumIndex(spr, "SizeQty11") > -1 Then z1314.SizeQty11 = getDataM(spr, getColumIndex(spr, "SizeQty11"), xRow)
            If getColumIndex(spr, "SizeQty12") > -1 Then z1314.SizeQty12 = getDataM(spr, getColumIndex(spr, "SizeQty12"), xRow)
            If getColumIndex(spr, "SizeQty13") > -1 Then z1314.SizeQty13 = getDataM(spr, getColumIndex(spr, "SizeQty13"), xRow)
            If getColumIndex(spr, "SizeQty14") > -1 Then z1314.SizeQty14 = getDataM(spr, getColumIndex(spr, "SizeQty14"), xRow)
            If getColumIndex(spr, "SizeQty15") > -1 Then z1314.SizeQty15 = getDataM(spr, getColumIndex(spr, "SizeQty15"), xRow)
            If getColumIndex(spr, "SizeQty16") > -1 Then z1314.SizeQty16 = getDataM(spr, getColumIndex(spr, "SizeQty16"), xRow)
            If getColumIndex(spr, "SizeQty17") > -1 Then z1314.SizeQty17 = getDataM(spr, getColumIndex(spr, "SizeQty17"), xRow)
            If getColumIndex(spr, "SizeQty18") > -1 Then z1314.SizeQty18 = getDataM(spr, getColumIndex(spr, "SizeQty18"), xRow)
            If getColumIndex(spr, "SizeQty19") > -1 Then z1314.SizeQty19 = getDataM(spr, getColumIndex(spr, "SizeQty19"), xRow)
            If getColumIndex(spr, "SizeQty20") > -1 Then z1314.SizeQty20 = getDataM(spr, getColumIndex(spr, "SizeQty20"), xRow)
            If getColumIndex(spr, "SizeQty21") > -1 Then z1314.SizeQty21 = getDataM(spr, getColumIndex(spr, "SizeQty21"), xRow)
            If getColumIndex(spr, "SizeQty22") > -1 Then z1314.SizeQty22 = getDataM(spr, getColumIndex(spr, "SizeQty22"), xRow)
            If getColumIndex(spr, "SizeQty23") > -1 Then z1314.SizeQty23 = getDataM(spr, getColumIndex(spr, "SizeQty23"), xRow)
            If getColumIndex(spr, "SizeQty24") > -1 Then z1314.SizeQty24 = getDataM(spr, getColumIndex(spr, "SizeQty24"), xRow)
            If getColumIndex(spr, "SizeQty25") > -1 Then z1314.SizeQty25 = getDataM(spr, getColumIndex(spr, "SizeQty25"), xRow)
            If getColumIndex(spr, "SizeQty26") > -1 Then z1314.SizeQty26 = getDataM(spr, getColumIndex(spr, "SizeQty26"), xRow)
            If getColumIndex(spr, "SizeQty27") > -1 Then z1314.SizeQty27 = getDataM(spr, getColumIndex(spr, "SizeQty27"), xRow)
            If getColumIndex(spr, "SizeQty28") > -1 Then z1314.SizeQty28 = getDataM(spr, getColumIndex(spr, "SizeQty28"), xRow)
            If getColumIndex(spr, "SizeQty29") > -1 Then z1314.SizeQty29 = getDataM(spr, getColumIndex(spr, "SizeQty29"), xRow)
            If getColumIndex(spr, "SizeQty30") > -1 Then z1314.SizeQty30 = getDataM(spr, getColumIndex(spr, "SizeQty30"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z1314.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K1314_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K1314_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z1314 As T1314_AREA, CheckClear As Boolean, ORDERNO As String, ORDERNOSEQ As String, PROCESSORDER As Double) As Boolean

        K1314_MOVE = False

        Try
            If READ_PFK1314(ORDERNO, ORDERNOSEQ, PROCESSORDER) = True Then
                z1314 = D1314
                K1314_MOVE = True
            Else
                If CheckClear = True Then z1314 = Nothing
            End If

            If getColumIndex(spr, "OrderNo") > -1 Then z1314.OrderNo = getDataM(spr, getColumIndex(spr, "OrderNo"), xRow)
            If getColumIndex(spr, "OrderNoSeq") > -1 Then z1314.OrderNoSeq = getDataM(spr, getColumIndex(spr, "OrderNoSeq"), xRow)
            If getColumIndex(spr, "ProcessOrder") > -1 Then z1314.ProcessOrder = getDataM(spr, getColumIndex(spr, "ProcessOrder"), xRow)
            If getColumIndex(spr, "seOrderProcess") > -1 Then z1314.seOrderProcess = getDataM(spr, getColumIndex(spr, "seOrderProcess"), xRow)
            If getColumIndex(spr, "cdOrderProcess") > -1 Then z1314.cdOrderProcess = getDataM(spr, getColumIndex(spr, "cdOrderProcess"), xRow)
            If getColumIndex(spr, "seProcessState") > -1 Then z1314.seProcessState = getDataM(spr, getColumIndex(spr, "seProcessState"), xRow)
            If getColumIndex(spr, "cdProcessState") > -1 Then z1314.cdProcessState = getDataM(spr, getColumIndex(spr, "cdProcessState"), xRow)
            If getColumIndex(spr, "SizeQty01") > -1 Then z1314.SizeQty01 = getDataM(spr, getColumIndex(spr, "SizeQty01"), xRow)
            If getColumIndex(spr, "SizeQty02") > -1 Then z1314.SizeQty02 = getDataM(spr, getColumIndex(spr, "SizeQty02"), xRow)
            If getColumIndex(spr, "SizeQty03") > -1 Then z1314.SizeQty03 = getDataM(spr, getColumIndex(spr, "SizeQty03"), xRow)
            If getColumIndex(spr, "SizeQty04") > -1 Then z1314.SizeQty04 = getDataM(spr, getColumIndex(spr, "SizeQty04"), xRow)
            If getColumIndex(spr, "SizeQty05") > -1 Then z1314.SizeQty05 = getDataM(spr, getColumIndex(spr, "SizeQty05"), xRow)
            If getColumIndex(spr, "SizeQty06") > -1 Then z1314.SizeQty06 = getDataM(spr, getColumIndex(spr, "SizeQty06"), xRow)
            If getColumIndex(spr, "SizeQty07") > -1 Then z1314.SizeQty07 = getDataM(spr, getColumIndex(spr, "SizeQty07"), xRow)
            If getColumIndex(spr, "SizeQty08") > -1 Then z1314.SizeQty08 = getDataM(spr, getColumIndex(spr, "SizeQty08"), xRow)
            If getColumIndex(spr, "SizeQty09") > -1 Then z1314.SizeQty09 = getDataM(spr, getColumIndex(spr, "SizeQty09"), xRow)
            If getColumIndex(spr, "SizeQty10") > -1 Then z1314.SizeQty10 = getDataM(spr, getColumIndex(spr, "SizeQty10"), xRow)
            If getColumIndex(spr, "SizeQty11") > -1 Then z1314.SizeQty11 = getDataM(spr, getColumIndex(spr, "SizeQty11"), xRow)
            If getColumIndex(spr, "SizeQty12") > -1 Then z1314.SizeQty12 = getDataM(spr, getColumIndex(spr, "SizeQty12"), xRow)
            If getColumIndex(spr, "SizeQty13") > -1 Then z1314.SizeQty13 = getDataM(spr, getColumIndex(spr, "SizeQty13"), xRow)
            If getColumIndex(spr, "SizeQty14") > -1 Then z1314.SizeQty14 = getDataM(spr, getColumIndex(spr, "SizeQty14"), xRow)
            If getColumIndex(spr, "SizeQty15") > -1 Then z1314.SizeQty15 = getDataM(spr, getColumIndex(spr, "SizeQty15"), xRow)
            If getColumIndex(spr, "SizeQty16") > -1 Then z1314.SizeQty16 = getDataM(spr, getColumIndex(spr, "SizeQty16"), xRow)
            If getColumIndex(spr, "SizeQty17") > -1 Then z1314.SizeQty17 = getDataM(spr, getColumIndex(spr, "SizeQty17"), xRow)
            If getColumIndex(spr, "SizeQty18") > -1 Then z1314.SizeQty18 = getDataM(spr, getColumIndex(spr, "SizeQty18"), xRow)
            If getColumIndex(spr, "SizeQty19") > -1 Then z1314.SizeQty19 = getDataM(spr, getColumIndex(spr, "SizeQty19"), xRow)
            If getColumIndex(spr, "SizeQty20") > -1 Then z1314.SizeQty20 = getDataM(spr, getColumIndex(spr, "SizeQty20"), xRow)
            If getColumIndex(spr, "SizeQty21") > -1 Then z1314.SizeQty21 = getDataM(spr, getColumIndex(spr, "SizeQty21"), xRow)
            If getColumIndex(spr, "SizeQty22") > -1 Then z1314.SizeQty22 = getDataM(spr, getColumIndex(spr, "SizeQty22"), xRow)
            If getColumIndex(spr, "SizeQty23") > -1 Then z1314.SizeQty23 = getDataM(spr, getColumIndex(spr, "SizeQty23"), xRow)
            If getColumIndex(spr, "SizeQty24") > -1 Then z1314.SizeQty24 = getDataM(spr, getColumIndex(spr, "SizeQty24"), xRow)
            If getColumIndex(spr, "SizeQty25") > -1 Then z1314.SizeQty25 = getDataM(spr, getColumIndex(spr, "SizeQty25"), xRow)
            If getColumIndex(spr, "SizeQty26") > -1 Then z1314.SizeQty26 = getDataM(spr, getColumIndex(spr, "SizeQty26"), xRow)
            If getColumIndex(spr, "SizeQty27") > -1 Then z1314.SizeQty27 = getDataM(spr, getColumIndex(spr, "SizeQty27"), xRow)
            If getColumIndex(spr, "SizeQty28") > -1 Then z1314.SizeQty28 = getDataM(spr, getColumIndex(spr, "SizeQty28"), xRow)
            If getColumIndex(spr, "SizeQty29") > -1 Then z1314.SizeQty29 = getDataM(spr, getColumIndex(spr, "SizeQty29"), xRow)
            If getColumIndex(spr, "SizeQty30") > -1 Then z1314.SizeQty30 = getDataM(spr, getColumIndex(spr, "SizeQty30"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z1314.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K1314_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K1314_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z1314 As T1314_AREA, Job As String, ORDERNO As String, ORDERNOSEQ As String, PROCESSORDER As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K1314_MOVE = False

        Try
            If READ_PFK1314(ORDERNO, ORDERNOSEQ, PROCESSORDER) = True Then
                z1314 = D1314
                K1314_MOVE = True
            Else
                z1314 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1314")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "ORDERNO" : z1314.OrderNo = Children(i).Code
                                Case "ORDERNOSEQ" : z1314.OrderNoSeq = Children(i).Code
                                Case "PROCESSORDER" : z1314.ProcessOrder = Children(i).Code
                                Case "SEORDERPROCESS" : z1314.seOrderProcess = Children(i).Code
                                Case "CDORDERPROCESS" : z1314.cdOrderProcess = Children(i).Code
                                Case "SEPROCESSSTATE" : z1314.seProcessState = Children(i).Code
                                Case "CDPROCESSSTATE" : z1314.cdProcessState = Children(i).Code
                                Case "SIZEQTY01" : z1314.SizeQty01 = Children(i).Code
                                Case "SIZEQTY02" : z1314.SizeQty02 = Children(i).Code
                                Case "SIZEQTY03" : z1314.SizeQty03 = Children(i).Code
                                Case "SIZEQTY04" : z1314.SizeQty04 = Children(i).Code
                                Case "SIZEQTY05" : z1314.SizeQty05 = Children(i).Code
                                Case "SIZEQTY06" : z1314.SizeQty06 = Children(i).Code
                                Case "SIZEQTY07" : z1314.SizeQty07 = Children(i).Code
                                Case "SIZEQTY08" : z1314.SizeQty08 = Children(i).Code
                                Case "SIZEQTY09" : z1314.SizeQty09 = Children(i).Code
                                Case "SIZEQTY10" : z1314.SizeQty10 = Children(i).Code
                                Case "SIZEQTY11" : z1314.SizeQty11 = Children(i).Code
                                Case "SIZEQTY12" : z1314.SizeQty12 = Children(i).Code
                                Case "SIZEQTY13" : z1314.SizeQty13 = Children(i).Code
                                Case "SIZEQTY14" : z1314.SizeQty14 = Children(i).Code
                                Case "SIZEQTY15" : z1314.SizeQty15 = Children(i).Code
                                Case "SIZEQTY16" : z1314.SizeQty16 = Children(i).Code
                                Case "SIZEQTY17" : z1314.SizeQty17 = Children(i).Code
                                Case "SIZEQTY18" : z1314.SizeQty18 = Children(i).Code
                                Case "SIZEQTY19" : z1314.SizeQty19 = Children(i).Code
                                Case "SIZEQTY20" : z1314.SizeQty20 = Children(i).Code
                                Case "SIZEQTY21" : z1314.SizeQty21 = Children(i).Code
                                Case "SIZEQTY22" : z1314.SizeQty22 = Children(i).Code
                                Case "SIZEQTY23" : z1314.SizeQty23 = Children(i).Code
                                Case "SIZEQTY24" : z1314.SizeQty24 = Children(i).Code
                                Case "SIZEQTY25" : z1314.SizeQty25 = Children(i).Code
                                Case "SIZEQTY26" : z1314.SizeQty26 = Children(i).Code
                                Case "SIZEQTY27" : z1314.SizeQty27 = Children(i).Code
                                Case "SIZEQTY28" : z1314.SizeQty28 = Children(i).Code
                                Case "SIZEQTY29" : z1314.SizeQty29 = Children(i).Code
                                Case "SIZEQTY30" : z1314.SizeQty30 = Children(i).Code
                                Case "REMARK" : z1314.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "ORDERNO" : z1314.OrderNo = Children(i).Data
                                Case "ORDERNOSEQ" : z1314.OrderNoSeq = Children(i).Data
                                Case "PROCESSORDER" : z1314.ProcessOrder = Children(i).Data
                                Case "SEORDERPROCESS" : z1314.seOrderProcess = Children(i).Data
                                Case "CDORDERPROCESS" : z1314.cdOrderProcess = Children(i).Data
                                Case "SEPROCESSSTATE" : z1314.seProcessState = Children(i).Data
                                Case "CDPROCESSSTATE" : z1314.cdProcessState = Children(i).Data
                                Case "SIZEQTY01" : z1314.SizeQty01 = Children(i).Data
                                Case "SIZEQTY02" : z1314.SizeQty02 = Children(i).Data
                                Case "SIZEQTY03" : z1314.SizeQty03 = Children(i).Data
                                Case "SIZEQTY04" : z1314.SizeQty04 = Children(i).Data
                                Case "SIZEQTY05" : z1314.SizeQty05 = Children(i).Data
                                Case "SIZEQTY06" : z1314.SizeQty06 = Children(i).Data
                                Case "SIZEQTY07" : z1314.SizeQty07 = Children(i).Data
                                Case "SIZEQTY08" : z1314.SizeQty08 = Children(i).Data
                                Case "SIZEQTY09" : z1314.SizeQty09 = Children(i).Data
                                Case "SIZEQTY10" : z1314.SizeQty10 = Children(i).Data
                                Case "SIZEQTY11" : z1314.SizeQty11 = Children(i).Data
                                Case "SIZEQTY12" : z1314.SizeQty12 = Children(i).Data
                                Case "SIZEQTY13" : z1314.SizeQty13 = Children(i).Data
                                Case "SIZEQTY14" : z1314.SizeQty14 = Children(i).Data
                                Case "SIZEQTY15" : z1314.SizeQty15 = Children(i).Data
                                Case "SIZEQTY16" : z1314.SizeQty16 = Children(i).Data
                                Case "SIZEQTY17" : z1314.SizeQty17 = Children(i).Data
                                Case "SIZEQTY18" : z1314.SizeQty18 = Children(i).Data
                                Case "SIZEQTY19" : z1314.SizeQty19 = Children(i).Data
                                Case "SIZEQTY20" : z1314.SizeQty20 = Children(i).Data
                                Case "SIZEQTY21" : z1314.SizeQty21 = Children(i).Data
                                Case "SIZEQTY22" : z1314.SizeQty22 = Children(i).Data
                                Case "SIZEQTY23" : z1314.SizeQty23 = Children(i).Data
                                Case "SIZEQTY24" : z1314.SizeQty24 = Children(i).Data
                                Case "SIZEQTY25" : z1314.SizeQty25 = Children(i).Data
                                Case "SIZEQTY26" : z1314.SizeQty26 = Children(i).Data
                                Case "SIZEQTY27" : z1314.SizeQty27 = Children(i).Data
                                Case "SIZEQTY28" : z1314.SizeQty28 = Children(i).Data
                                Case "SIZEQTY29" : z1314.SizeQty29 = Children(i).Data
                                Case "SIZEQTY30" : z1314.SizeQty30 = Children(i).Data
                                Case "REMARK" : z1314.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K1314_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K1314_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z1314 As T1314_AREA, Job As String, CheckClear As Boolean, ORDERNO As String, ORDERNOSEQ As String, PROCESSORDER As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K1314_MOVE = False

        Try
            If READ_PFK1314(ORDERNO, ORDERNOSEQ, PROCESSORDER) = True Then
                z1314 = D1314
                K1314_MOVE = True
            Else
                If CheckClear = True Then z1314 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1314")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "ORDERNO" : z1314.OrderNo = Children(i).Code
                                Case "ORDERNOSEQ" : z1314.OrderNoSeq = Children(i).Code
                                Case "PROCESSORDER" : z1314.ProcessOrder = Children(i).Code
                                Case "SEORDERPROCESS" : z1314.seOrderProcess = Children(i).Code
                                Case "CDORDERPROCESS" : z1314.cdOrderProcess = Children(i).Code
                                Case "SEPROCESSSTATE" : z1314.seProcessState = Children(i).Code
                                Case "CDPROCESSSTATE" : z1314.cdProcessState = Children(i).Code
                                Case "SIZEQTY01" : z1314.SizeQty01 = Children(i).Code
                                Case "SIZEQTY02" : z1314.SizeQty02 = Children(i).Code
                                Case "SIZEQTY03" : z1314.SizeQty03 = Children(i).Code
                                Case "SIZEQTY04" : z1314.SizeQty04 = Children(i).Code
                                Case "SIZEQTY05" : z1314.SizeQty05 = Children(i).Code
                                Case "SIZEQTY06" : z1314.SizeQty06 = Children(i).Code
                                Case "SIZEQTY07" : z1314.SizeQty07 = Children(i).Code
                                Case "SIZEQTY08" : z1314.SizeQty08 = Children(i).Code
                                Case "SIZEQTY09" : z1314.SizeQty09 = Children(i).Code
                                Case "SIZEQTY10" : z1314.SizeQty10 = Children(i).Code
                                Case "SIZEQTY11" : z1314.SizeQty11 = Children(i).Code
                                Case "SIZEQTY12" : z1314.SizeQty12 = Children(i).Code
                                Case "SIZEQTY13" : z1314.SizeQty13 = Children(i).Code
                                Case "SIZEQTY14" : z1314.SizeQty14 = Children(i).Code
                                Case "SIZEQTY15" : z1314.SizeQty15 = Children(i).Code
                                Case "SIZEQTY16" : z1314.SizeQty16 = Children(i).Code
                                Case "SIZEQTY17" : z1314.SizeQty17 = Children(i).Code
                                Case "SIZEQTY18" : z1314.SizeQty18 = Children(i).Code
                                Case "SIZEQTY19" : z1314.SizeQty19 = Children(i).Code
                                Case "SIZEQTY20" : z1314.SizeQty20 = Children(i).Code
                                Case "SIZEQTY21" : z1314.SizeQty21 = Children(i).Code
                                Case "SIZEQTY22" : z1314.SizeQty22 = Children(i).Code
                                Case "SIZEQTY23" : z1314.SizeQty23 = Children(i).Code
                                Case "SIZEQTY24" : z1314.SizeQty24 = Children(i).Code
                                Case "SIZEQTY25" : z1314.SizeQty25 = Children(i).Code
                                Case "SIZEQTY26" : z1314.SizeQty26 = Children(i).Code
                                Case "SIZEQTY27" : z1314.SizeQty27 = Children(i).Code
                                Case "SIZEQTY28" : z1314.SizeQty28 = Children(i).Code
                                Case "SIZEQTY29" : z1314.SizeQty29 = Children(i).Code
                                Case "SIZEQTY30" : z1314.SizeQty30 = Children(i).Code
                                Case "REMARK" : z1314.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "ORDERNO" : z1314.OrderNo = Children(i).Data
                                Case "ORDERNOSEQ" : z1314.OrderNoSeq = Children(i).Data
                                Case "PROCESSORDER" : z1314.ProcessOrder = Children(i).Data
                                Case "SEORDERPROCESS" : z1314.seOrderProcess = Children(i).Data
                                Case "CDORDERPROCESS" : z1314.cdOrderProcess = Children(i).Data
                                Case "SEPROCESSSTATE" : z1314.seProcessState = Children(i).Data
                                Case "CDPROCESSSTATE" : z1314.cdProcessState = Children(i).Data
                                Case "SIZEQTY01" : z1314.SizeQty01 = Children(i).Data
                                Case "SIZEQTY02" : z1314.SizeQty02 = Children(i).Data
                                Case "SIZEQTY03" : z1314.SizeQty03 = Children(i).Data
                                Case "SIZEQTY04" : z1314.SizeQty04 = Children(i).Data
                                Case "SIZEQTY05" : z1314.SizeQty05 = Children(i).Data
                                Case "SIZEQTY06" : z1314.SizeQty06 = Children(i).Data
                                Case "SIZEQTY07" : z1314.SizeQty07 = Children(i).Data
                                Case "SIZEQTY08" : z1314.SizeQty08 = Children(i).Data
                                Case "SIZEQTY09" : z1314.SizeQty09 = Children(i).Data
                                Case "SIZEQTY10" : z1314.SizeQty10 = Children(i).Data
                                Case "SIZEQTY11" : z1314.SizeQty11 = Children(i).Data
                                Case "SIZEQTY12" : z1314.SizeQty12 = Children(i).Data
                                Case "SIZEQTY13" : z1314.SizeQty13 = Children(i).Data
                                Case "SIZEQTY14" : z1314.SizeQty14 = Children(i).Data
                                Case "SIZEQTY15" : z1314.SizeQty15 = Children(i).Data
                                Case "SIZEQTY16" : z1314.SizeQty16 = Children(i).Data
                                Case "SIZEQTY17" : z1314.SizeQty17 = Children(i).Data
                                Case "SIZEQTY18" : z1314.SizeQty18 = Children(i).Data
                                Case "SIZEQTY19" : z1314.SizeQty19 = Children(i).Data
                                Case "SIZEQTY20" : z1314.SizeQty20 = Children(i).Data
                                Case "SIZEQTY21" : z1314.SizeQty21 = Children(i).Data
                                Case "SIZEQTY22" : z1314.SizeQty22 = Children(i).Data
                                Case "SIZEQTY23" : z1314.SizeQty23 = Children(i).Data
                                Case "SIZEQTY24" : z1314.SizeQty24 = Children(i).Data
                                Case "SIZEQTY25" : z1314.SizeQty25 = Children(i).Data
                                Case "SIZEQTY26" : z1314.SizeQty26 = Children(i).Data
                                Case "SIZEQTY27" : z1314.SizeQty27 = Children(i).Data
                                Case "SIZEQTY28" : z1314.SizeQty28 = Children(i).Data
                                Case "SIZEQTY29" : z1314.SizeQty29 = Children(i).Data
                                Case "SIZEQTY30" : z1314.SizeQty30 = Children(i).Data
                                Case "REMARK" : z1314.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K1314_MOVE", vbCritical)
        End Try
    End Function

End Module
