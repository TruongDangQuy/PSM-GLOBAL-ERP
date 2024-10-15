'=========================================================================================================================================================
'   TABLE : (PFK2652)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K2652

Structure T2652_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	ProductInBoundNo	 AS String	'			char(9)		*
Public 	ProductInBoundSeq	 AS String	'			char(3)		*
        Public SizeQtyInbound01 As Double  '			decimal
        Public SizeQtyInbound02 As Double  '			decimal
        Public SizeQtyInbound03 As Double  '			decimal
        Public SizeQtyInbound04 As Double  '			decimal
        Public SizeQtyInbound05 As Double  '			decimal
        Public SizeQtyInbound06 As Double  '			decimal
        Public SizeQtyInbound07 As Double  '			decimal
        Public SizeQtyInbound08 As Double  '			decimal
        Public SizeQtyInbound09 As Double  '			decimal
        Public SizeQtyInbound10 As Double  '			decimal
        Public SizeQtyInbound11 As Double  '			decimal
        Public SizeQtyInbound12 As Double  '			decimal
        Public SizeQtyInbound13 As Double  '			decimal
        Public SizeQtyInbound14 As Double  '			decimal
        Public SizeQtyInbound15 As Double  '			decimal
        Public SizeQtyInbound16 As Double  '			decimal
        Public SizeQtyInbound17 As Double  '			decimal
        Public SizeQtyInbound18 As Double  '			decimal
        Public SizeQtyInbound19 As Double  '			decimal
        Public SizeQtyInbound20 As Double  '			decimal
        Public SizeQtyInbound21 As Double  '			decimal
        Public SizeQtyInbound22 As Double  '			decimal
        Public SizeQtyInbound23 As Double  '			decimal
        Public SizeQtyInbound24 As Double  '			decimal
        Public SizeQtyInbound25 As Double  '			decimal
        Public SizeQtyInbound26 As Double  '			decimal
        Public SizeQtyInbound27 As Double  '			decimal
        Public SizeQtyInbound28 As Double  '			decimal
        Public SizeQtyInbound29 As Double  '			decimal
        Public SizeQtyInbound30 As Double  '			decimal
        Public SizeQtyOutbound01 As Double  '			decimal
        Public SizeQtyOutbound02 As Double  '			decimal
        Public SizeQtyOutbound03 As Double  '			decimal
        Public SizeQtyOutbound04 As Double  '			decimal
        Public SizeQtyOutbound05 As Double  '			decimal
        Public SizeQtyOutbound06 As Double  '			decimal
        Public SizeQtyOutbound07 As Double  '			decimal
        Public SizeQtyOutbound08 As Double  '			decimal
        Public SizeQtyOutbound09 As Double  '			decimal
        Public SizeQtyOutbound10 As Double  '			decimal
        Public SizeQtyOutbound11 As Double  '			decimal
        Public SizeQtyOutbound12 As Double  '			decimal
        Public SizeQtyOutbound13 As Double  '			decimal
        Public SizeQtyOutbound14 As Double  '			decimal
        Public SizeQtyOutbound15 As Double  '			decimal
        Public SizeQtyOutbound16 As Double  '			decimal
        Public SizeQtyOutbound17 As Double  '			decimal
        Public SizeQtyOutbound18 As Double  '			decimal
        Public SizeQtyOutbound19 As Double  '			decimal
        Public SizeQtyOutbound20 As Double  '			decimal
        Public SizeQtyOutbound21 As Double  '			decimal
        Public SizeQtyOutbound22 As Double  '			decimal
        Public SizeQtyOutbound23 As Double  '			decimal
        Public SizeQtyOutbound24 As Double  '			decimal
        Public SizeQtyOutbound25 As Double  '			decimal
        Public SizeQtyOutbound26 As Double  '			decimal
        Public SizeQtyOutbound27 As Double  '			decimal
        Public SizeQtyOutbound28 As Double  '			decimal
        Public SizeQtyOutbound29 As Double  '			decimal
        Public SizeQtyOutbound30 As Double  '			decimal
        '=========================================================================================================================================================
    End Structure

    Public D2652 As T2652_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK2652(PRODUCTINBOUNDNO As String, PRODUCTINBOUNDSEQ As String) As Boolean
        READ_PFK2652 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK2652 "
            SQL = SQL & " WHERE K2652_ProductInBoundNo		 = '" & ProductInBoundNo & "' "
            SQL = SQL & "   AND K2652_ProductInBoundSeq		 = '" & ProductInBoundSeq & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D2652_CLEAR() : GoTo SKIP_READ_PFK2652

            Call K2652_MOVE(rd)
            READ_PFK2652 = True

SKIP_READ_PFK2652:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK2652", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK2652(PRODUCTINBOUNDNO As String, PRODUCTINBOUNDSEQ As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK2652 "
            SQL = SQL & " WHERE K2652_ProductInBoundNo		 = '" & ProductInBoundNo & "' "
            SQL = SQL & "   AND K2652_ProductInBoundSeq		 = '" & ProductInBoundSeq & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK2652", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK2652(z2652 As T2652_AREA) As Boolean
        WRITE_PFK2652 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z2652)

            SQL = " INSERT INTO PFK2652 "
            SQL = SQL & " ( "
            SQL = SQL & " K2652_ProductInBoundNo,"
            SQL = SQL & " K2652_ProductInBoundSeq,"
            SQL = SQL & " K2652_SizeQtyInbound01,"
            SQL = SQL & " K2652_SizeQtyInbound02,"
            SQL = SQL & " K2652_SizeQtyInbound03,"
            SQL = SQL & " K2652_SizeQtyInbound04,"
            SQL = SQL & " K2652_SizeQtyInbound05,"
            SQL = SQL & " K2652_SizeQtyInbound06,"
            SQL = SQL & " K2652_SizeQtyInbound07,"
            SQL = SQL & " K2652_SizeQtyInbound08,"
            SQL = SQL & " K2652_SizeQtyInbound09,"
            SQL = SQL & " K2652_SizeQtyInbound10,"
            SQL = SQL & " K2652_SizeQtyInbound11,"
            SQL = SQL & " K2652_SizeQtyInbound12,"
            SQL = SQL & " K2652_SizeQtyInbound13,"
            SQL = SQL & " K2652_SizeQtyInbound14,"
            SQL = SQL & " K2652_SizeQtyInbound15,"
            SQL = SQL & " K2652_SizeQtyInbound16,"
            SQL = SQL & " K2652_SizeQtyInbound17,"
            SQL = SQL & " K2652_SizeQtyInbound18,"
            SQL = SQL & " K2652_SizeQtyInbound19,"
            SQL = SQL & " K2652_SizeQtyInbound20,"
            SQL = SQL & " K2652_SizeQtyInbound21,"
            SQL = SQL & " K2652_SizeQtyInbound22,"
            SQL = SQL & " K2652_SizeQtyInbound23,"
            SQL = SQL & " K2652_SizeQtyInbound24,"
            SQL = SQL & " K2652_SizeQtyInbound25,"
            SQL = SQL & " K2652_SizeQtyInbound26,"
            SQL = SQL & " K2652_SizeQtyInbound27,"
            SQL = SQL & " K2652_SizeQtyInbound28,"
            SQL = SQL & " K2652_SizeQtyInbound29,"
            SQL = SQL & " K2652_SizeQtyInbound30,"
            SQL = SQL & " K2652_SizeQtyOutbound01,"
            SQL = SQL & " K2652_SizeQtyOutbound02,"
            SQL = SQL & " K2652_SizeQtyOutbound03,"
            SQL = SQL & " K2652_SizeQtyOutbound04,"
            SQL = SQL & " K2652_SizeQtyOutbound05,"
            SQL = SQL & " K2652_SizeQtyOutbound06,"
            SQL = SQL & " K2652_SizeQtyOutbound07,"
            SQL = SQL & " K2652_SizeQtyOutbound08,"
            SQL = SQL & " K2652_SizeQtyOutbound09,"
            SQL = SQL & " K2652_SizeQtyOutbound10,"
            SQL = SQL & " K2652_SizeQtyOutbound11,"
            SQL = SQL & " K2652_SizeQtyOutbound12,"
            SQL = SQL & " K2652_SizeQtyOutbound13,"
            SQL = SQL & " K2652_SizeQtyOutbound14,"
            SQL = SQL & " K2652_SizeQtyOutbound15,"
            SQL = SQL & " K2652_SizeQtyOutbound16,"
            SQL = SQL & " K2652_SizeQtyOutbound17,"
            SQL = SQL & " K2652_SizeQtyOutbound18,"
            SQL = SQL & " K2652_SizeQtyOutbound19,"
            SQL = SQL & " K2652_SizeQtyOutbound20,"
            SQL = SQL & " K2652_SizeQtyOutbound21,"
            SQL = SQL & " K2652_SizeQtyOutbound22,"
            SQL = SQL & " K2652_SizeQtyOutbound23,"
            SQL = SQL & " K2652_SizeQtyOutbound24,"
            SQL = SQL & " K2652_SizeQtyOutbound25,"
            SQL = SQL & " K2652_SizeQtyOutbound26,"
            SQL = SQL & " K2652_SizeQtyOutbound27,"
            SQL = SQL & " K2652_SizeQtyOutbound28,"
            SQL = SQL & " K2652_SizeQtyOutbound29,"
            SQL = SQL & " K2652_SizeQtyOutbound30 "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z2652.ProductInBoundNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2652.ProductInBoundSeq) & "', "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyInbound01) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyInbound02) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyInbound03) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyInbound04) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyInbound05) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyInbound06) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyInbound07) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyInbound08) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyInbound09) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyInbound10) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyInbound11) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyInbound12) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyInbound13) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyInbound14) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyInbound15) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyInbound16) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyInbound17) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyInbound18) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyInbound19) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyInbound20) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyInbound21) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyInbound22) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyInbound23) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyInbound24) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyInbound25) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyInbound26) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyInbound27) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyInbound28) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyInbound29) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyInbound30) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyOutbound01) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyOutbound02) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyOutbound03) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyOutbound04) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyOutbound05) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyOutbound06) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyOutbound07) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyOutbound08) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyOutbound09) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyOutbound10) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyOutbound11) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyOutbound12) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyOutbound13) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyOutbound14) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyOutbound15) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyOutbound16) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyOutbound17) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyOutbound18) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyOutbound19) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyOutbound20) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyOutbound21) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyOutbound22) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyOutbound23) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyOutbound24) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyOutbound25) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyOutbound26) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyOutbound27) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyOutbound28) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyOutbound29) & ", "
            SQL = SQL & "   " & FormatSQL(z2652.SizeQtyOutbound30) & "  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK2652 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK2652", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK2652(z2652 As T2652_AREA) As Boolean
        REWRITE_PFK2652 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z2652)

            SQL = " UPDATE PFK2652 SET "
            SQL = SQL & "    K2652_SizeQtyInbound01      =  " & FormatSQL(z2652.SizeQtyInbound01) & ", "
            SQL = SQL & "    K2652_SizeQtyInbound02      =  " & FormatSQL(z2652.SizeQtyInbound02) & ", "
            SQL = SQL & "    K2652_SizeQtyInbound03      =  " & FormatSQL(z2652.SizeQtyInbound03) & ", "
            SQL = SQL & "    K2652_SizeQtyInbound04      =  " & FormatSQL(z2652.SizeQtyInbound04) & ", "
            SQL = SQL & "    K2652_SizeQtyInbound05      =  " & FormatSQL(z2652.SizeQtyInbound05) & ", "
            SQL = SQL & "    K2652_SizeQtyInbound06      =  " & FormatSQL(z2652.SizeQtyInbound06) & ", "
            SQL = SQL & "    K2652_SizeQtyInbound07      =  " & FormatSQL(z2652.SizeQtyInbound07) & ", "
            SQL = SQL & "    K2652_SizeQtyInbound08      =  " & FormatSQL(z2652.SizeQtyInbound08) & ", "
            SQL = SQL & "    K2652_SizeQtyInbound09      =  " & FormatSQL(z2652.SizeQtyInbound09) & ", "
            SQL = SQL & "    K2652_SizeQtyInbound10      =  " & FormatSQL(z2652.SizeQtyInbound10) & ", "
            SQL = SQL & "    K2652_SizeQtyInbound11      =  " & FormatSQL(z2652.SizeQtyInbound11) & ", "
            SQL = SQL & "    K2652_SizeQtyInbound12      =  " & FormatSQL(z2652.SizeQtyInbound12) & ", "
            SQL = SQL & "    K2652_SizeQtyInbound13      =  " & FormatSQL(z2652.SizeQtyInbound13) & ", "
            SQL = SQL & "    K2652_SizeQtyInbound14      =  " & FormatSQL(z2652.SizeQtyInbound14) & ", "
            SQL = SQL & "    K2652_SizeQtyInbound15      =  " & FormatSQL(z2652.SizeQtyInbound15) & ", "
            SQL = SQL & "    K2652_SizeQtyInbound16      =  " & FormatSQL(z2652.SizeQtyInbound16) & ", "
            SQL = SQL & "    K2652_SizeQtyInbound17      =  " & FormatSQL(z2652.SizeQtyInbound17) & ", "
            SQL = SQL & "    K2652_SizeQtyInbound18      =  " & FormatSQL(z2652.SizeQtyInbound18) & ", "
            SQL = SQL & "    K2652_SizeQtyInbound19      =  " & FormatSQL(z2652.SizeQtyInbound19) & ", "
            SQL = SQL & "    K2652_SizeQtyInbound20      =  " & FormatSQL(z2652.SizeQtyInbound20) & ", "
            SQL = SQL & "    K2652_SizeQtyInbound21      =  " & FormatSQL(z2652.SizeQtyInbound21) & ", "
            SQL = SQL & "    K2652_SizeQtyInbound22      =  " & FormatSQL(z2652.SizeQtyInbound22) & ", "
            SQL = SQL & "    K2652_SizeQtyInbound23      =  " & FormatSQL(z2652.SizeQtyInbound23) & ", "
            SQL = SQL & "    K2652_SizeQtyInbound24      =  " & FormatSQL(z2652.SizeQtyInbound24) & ", "
            SQL = SQL & "    K2652_SizeQtyInbound25      =  " & FormatSQL(z2652.SizeQtyInbound25) & ", "
            SQL = SQL & "    K2652_SizeQtyInbound26      =  " & FormatSQL(z2652.SizeQtyInbound26) & ", "
            SQL = SQL & "    K2652_SizeQtyInbound27      =  " & FormatSQL(z2652.SizeQtyInbound27) & ", "
            SQL = SQL & "    K2652_SizeQtyInbound28      =  " & FormatSQL(z2652.SizeQtyInbound28) & ", "
            SQL = SQL & "    K2652_SizeQtyInbound29      =  " & FormatSQL(z2652.SizeQtyInbound29) & ", "
            SQL = SQL & "    K2652_SizeQtyInbound30      =  " & FormatSQL(z2652.SizeQtyInbound30) & ", "
            SQL = SQL & "    K2652_SizeQtyOutbound01      =  " & FormatSQL(z2652.SizeQtyOutbound01) & ", "
            SQL = SQL & "    K2652_SizeQtyOutbound02      =  " & FormatSQL(z2652.SizeQtyOutbound02) & ", "
            SQL = SQL & "    K2652_SizeQtyOutbound03      =  " & FormatSQL(z2652.SizeQtyOutbound03) & ", "
            SQL = SQL & "    K2652_SizeQtyOutbound04      =  " & FormatSQL(z2652.SizeQtyOutbound04) & ", "
            SQL = SQL & "    K2652_SizeQtyOutbound05      =  " & FormatSQL(z2652.SizeQtyOutbound05) & ", "
            SQL = SQL & "    K2652_SizeQtyOutbound06      =  " & FormatSQL(z2652.SizeQtyOutbound06) & ", "
            SQL = SQL & "    K2652_SizeQtyOutbound07      =  " & FormatSQL(z2652.SizeQtyOutbound07) & ", "
            SQL = SQL & "    K2652_SizeQtyOutbound08      =  " & FormatSQL(z2652.SizeQtyOutbound08) & ", "
            SQL = SQL & "    K2652_SizeQtyOutbound09      =  " & FormatSQL(z2652.SizeQtyOutbound09) & ", "
            SQL = SQL & "    K2652_SizeQtyOutbound10      =  " & FormatSQL(z2652.SizeQtyOutbound10) & ", "
            SQL = SQL & "    K2652_SizeQtyOutbound11      =  " & FormatSQL(z2652.SizeQtyOutbound11) & ", "
            SQL = SQL & "    K2652_SizeQtyOutbound12      =  " & FormatSQL(z2652.SizeQtyOutbound12) & ", "
            SQL = SQL & "    K2652_SizeQtyOutbound13      =  " & FormatSQL(z2652.SizeQtyOutbound13) & ", "
            SQL = SQL & "    K2652_SizeQtyOutbound14      =  " & FormatSQL(z2652.SizeQtyOutbound14) & ", "
            SQL = SQL & "    K2652_SizeQtyOutbound15      =  " & FormatSQL(z2652.SizeQtyOutbound15) & ", "
            SQL = SQL & "    K2652_SizeQtyOutbound16      =  " & FormatSQL(z2652.SizeQtyOutbound16) & ", "
            SQL = SQL & "    K2652_SizeQtyOutbound17      =  " & FormatSQL(z2652.SizeQtyOutbound17) & ", "
            SQL = SQL & "    K2652_SizeQtyOutbound18      =  " & FormatSQL(z2652.SizeQtyOutbound18) & ", "
            SQL = SQL & "    K2652_SizeQtyOutbound19      =  " & FormatSQL(z2652.SizeQtyOutbound19) & ", "
            SQL = SQL & "    K2652_SizeQtyOutbound20      =  " & FormatSQL(z2652.SizeQtyOutbound20) & ", "
            SQL = SQL & "    K2652_SizeQtyOutbound21      =  " & FormatSQL(z2652.SizeQtyOutbound21) & ", "
            SQL = SQL & "    K2652_SizeQtyOutbound22      =  " & FormatSQL(z2652.SizeQtyOutbound22) & ", "
            SQL = SQL & "    K2652_SizeQtyOutbound23      =  " & FormatSQL(z2652.SizeQtyOutbound23) & ", "
            SQL = SQL & "    K2652_SizeQtyOutbound24      =  " & FormatSQL(z2652.SizeQtyOutbound24) & ", "
            SQL = SQL & "    K2652_SizeQtyOutbound25      =  " & FormatSQL(z2652.SizeQtyOutbound25) & ", "
            SQL = SQL & "    K2652_SizeQtyOutbound26      =  " & FormatSQL(z2652.SizeQtyOutbound26) & ", "
            SQL = SQL & "    K2652_SizeQtyOutbound27      =  " & FormatSQL(z2652.SizeQtyOutbound27) & ", "
            SQL = SQL & "    K2652_SizeQtyOutbound28      =  " & FormatSQL(z2652.SizeQtyOutbound28) & ", "
            SQL = SQL & "    K2652_SizeQtyOutbound29      =  " & FormatSQL(z2652.SizeQtyOutbound29) & ", "
            SQL = SQL & "    K2652_SizeQtyOutbound30      =  " & FormatSQL(z2652.SizeQtyOutbound30) & "  "
            SQL = SQL & " WHERE K2652_ProductInBoundNo		 = '" & z2652.ProductInBoundNo & "' "
            SQL = SQL & "   AND K2652_ProductInBoundSeq		 = '" & z2652.ProductInBoundSeq & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK2652 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK2652", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK2652(z2652 As T2652_AREA) As Boolean
        DELETE_PFK2652 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK2652 "
            SQL = SQL & " WHERE K2652_ProductInBoundNo		 = '" & z2652.ProductInBoundNo & "' "
            SQL = SQL & "   AND K2652_ProductInBoundSeq		 = '" & z2652.ProductInBoundSeq & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK2652 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK2652", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D2652_CLEAR()
        Try

            D2652.ProductInBoundNo = ""
            D2652.ProductInBoundSeq = ""
            D2652.SizeQtyInbound01 = 0
            D2652.SizeQtyInbound02 = 0
            D2652.SizeQtyInbound03 = 0
            D2652.SizeQtyInbound04 = 0
            D2652.SizeQtyInbound05 = 0
            D2652.SizeQtyInbound06 = 0
            D2652.SizeQtyInbound07 = 0
            D2652.SizeQtyInbound08 = 0
            D2652.SizeQtyInbound09 = 0
            D2652.SizeQtyInbound10 = 0
            D2652.SizeQtyInbound11 = 0
            D2652.SizeQtyInbound12 = 0
            D2652.SizeQtyInbound13 = 0
            D2652.SizeQtyInbound14 = 0
            D2652.SizeQtyInbound15 = 0
            D2652.SizeQtyInbound16 = 0
            D2652.SizeQtyInbound17 = 0
            D2652.SizeQtyInbound18 = 0
            D2652.SizeQtyInbound19 = 0
            D2652.SizeQtyInbound20 = 0
            D2652.SizeQtyInbound21 = 0
            D2652.SizeQtyInbound22 = 0
            D2652.SizeQtyInbound23 = 0
            D2652.SizeQtyInbound24 = 0
            D2652.SizeQtyInbound25 = 0
            D2652.SizeQtyInbound26 = 0
            D2652.SizeQtyInbound27 = 0
            D2652.SizeQtyInbound28 = 0
            D2652.SizeQtyInbound29 = 0
            D2652.SizeQtyInbound30 = 0
            D2652.SizeQtyOutbound01 = 0
            D2652.SizeQtyOutbound02 = 0
            D2652.SizeQtyOutbound03 = 0
            D2652.SizeQtyOutbound04 = 0
            D2652.SizeQtyOutbound05 = 0
            D2652.SizeQtyOutbound06 = 0
            D2652.SizeQtyOutbound07 = 0
            D2652.SizeQtyOutbound08 = 0
            D2652.SizeQtyOutbound09 = 0
            D2652.SizeQtyOutbound10 = 0
            D2652.SizeQtyOutbound11 = 0
            D2652.SizeQtyOutbound12 = 0
            D2652.SizeQtyOutbound13 = 0
            D2652.SizeQtyOutbound14 = 0
            D2652.SizeQtyOutbound15 = 0
            D2652.SizeQtyOutbound16 = 0
            D2652.SizeQtyOutbound17 = 0
            D2652.SizeQtyOutbound18 = 0
            D2652.SizeQtyOutbound19 = 0
            D2652.SizeQtyOutbound20 = 0
            D2652.SizeQtyOutbound21 = 0
            D2652.SizeQtyOutbound22 = 0
            D2652.SizeQtyOutbound23 = 0
            D2652.SizeQtyOutbound24 = 0
            D2652.SizeQtyOutbound25 = 0
            D2652.SizeQtyOutbound26 = 0
            D2652.SizeQtyOutbound27 = 0
            D2652.SizeQtyOutbound28 = 0
            D2652.SizeQtyOutbound29 = 0
            D2652.SizeQtyOutbound30 = 0


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D2652_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x2652 As T2652_AREA)
        Try

            x2652.ProductInBoundNo = trim$(x2652.ProductInBoundNo)
            x2652.ProductInBoundSeq = trim$(x2652.ProductInBoundSeq)
            x2652.SizeQtyInbound01 = trim$(x2652.SizeQtyInbound01)
            x2652.SizeQtyInbound02 = trim$(x2652.SizeQtyInbound02)
            x2652.SizeQtyInbound03 = trim$(x2652.SizeQtyInbound03)
            x2652.SizeQtyInbound04 = trim$(x2652.SizeQtyInbound04)
            x2652.SizeQtyInbound05 = trim$(x2652.SizeQtyInbound05)
            x2652.SizeQtyInbound06 = trim$(x2652.SizeQtyInbound06)
            x2652.SizeQtyInbound07 = trim$(x2652.SizeQtyInbound07)
            x2652.SizeQtyInbound08 = trim$(x2652.SizeQtyInbound08)
            x2652.SizeQtyInbound09 = trim$(x2652.SizeQtyInbound09)
            x2652.SizeQtyInbound10 = trim$(x2652.SizeQtyInbound10)
            x2652.SizeQtyInbound11 = trim$(x2652.SizeQtyInbound11)
            x2652.SizeQtyInbound12 = trim$(x2652.SizeQtyInbound12)
            x2652.SizeQtyInbound13 = trim$(x2652.SizeQtyInbound13)
            x2652.SizeQtyInbound14 = trim$(x2652.SizeQtyInbound14)
            x2652.SizeQtyInbound15 = trim$(x2652.SizeQtyInbound15)
            x2652.SizeQtyInbound16 = trim$(x2652.SizeQtyInbound16)
            x2652.SizeQtyInbound17 = trim$(x2652.SizeQtyInbound17)
            x2652.SizeQtyInbound18 = trim$(x2652.SizeQtyInbound18)
            x2652.SizeQtyInbound19 = trim$(x2652.SizeQtyInbound19)
            x2652.SizeQtyInbound20 = trim$(x2652.SizeQtyInbound20)
            x2652.SizeQtyInbound21 = trim$(x2652.SizeQtyInbound21)
            x2652.SizeQtyInbound22 = trim$(x2652.SizeQtyInbound22)
            x2652.SizeQtyInbound23 = trim$(x2652.SizeQtyInbound23)
            x2652.SizeQtyInbound24 = trim$(x2652.SizeQtyInbound24)
            x2652.SizeQtyInbound25 = trim$(x2652.SizeQtyInbound25)
            x2652.SizeQtyInbound26 = trim$(x2652.SizeQtyInbound26)
            x2652.SizeQtyInbound27 = trim$(x2652.SizeQtyInbound27)
            x2652.SizeQtyInbound28 = trim$(x2652.SizeQtyInbound28)
            x2652.SizeQtyInbound29 = trim$(x2652.SizeQtyInbound29)
            x2652.SizeQtyInbound30 = trim$(x2652.SizeQtyInbound30)
            x2652.SizeQtyOutbound01 = trim$(x2652.SizeQtyOutbound01)
            x2652.SizeQtyOutbound02 = trim$(x2652.SizeQtyOutbound02)
            x2652.SizeQtyOutbound03 = trim$(x2652.SizeQtyOutbound03)
            x2652.SizeQtyOutbound04 = trim$(x2652.SizeQtyOutbound04)
            x2652.SizeQtyOutbound05 = trim$(x2652.SizeQtyOutbound05)
            x2652.SizeQtyOutbound06 = trim$(x2652.SizeQtyOutbound06)
            x2652.SizeQtyOutbound07 = trim$(x2652.SizeQtyOutbound07)
            x2652.SizeQtyOutbound08 = trim$(x2652.SizeQtyOutbound08)
            x2652.SizeQtyOutbound09 = trim$(x2652.SizeQtyOutbound09)
            x2652.SizeQtyOutbound10 = trim$(x2652.SizeQtyOutbound10)
            x2652.SizeQtyOutbound11 = trim$(x2652.SizeQtyOutbound11)
            x2652.SizeQtyOutbound12 = trim$(x2652.SizeQtyOutbound12)
            x2652.SizeQtyOutbound13 = trim$(x2652.SizeQtyOutbound13)
            x2652.SizeQtyOutbound14 = trim$(x2652.SizeQtyOutbound14)
            x2652.SizeQtyOutbound15 = trim$(x2652.SizeQtyOutbound15)
            x2652.SizeQtyOutbound16 = trim$(x2652.SizeQtyOutbound16)
            x2652.SizeQtyOutbound17 = trim$(x2652.SizeQtyOutbound17)
            x2652.SizeQtyOutbound18 = trim$(x2652.SizeQtyOutbound18)
            x2652.SizeQtyOutbound19 = trim$(x2652.SizeQtyOutbound19)
            x2652.SizeQtyOutbound20 = trim$(x2652.SizeQtyOutbound20)
            x2652.SizeQtyOutbound21 = trim$(x2652.SizeQtyOutbound21)
            x2652.SizeQtyOutbound22 = trim$(x2652.SizeQtyOutbound22)
            x2652.SizeQtyOutbound23 = trim$(x2652.SizeQtyOutbound23)
            x2652.SizeQtyOutbound24 = trim$(x2652.SizeQtyOutbound24)
            x2652.SizeQtyOutbound25 = trim$(x2652.SizeQtyOutbound25)
            x2652.SizeQtyOutbound26 = trim$(x2652.SizeQtyOutbound26)
            x2652.SizeQtyOutbound27 = trim$(x2652.SizeQtyOutbound27)
            x2652.SizeQtyOutbound28 = trim$(x2652.SizeQtyOutbound28)
            x2652.SizeQtyOutbound29 = trim$(x2652.SizeQtyOutbound29)
            x2652.SizeQtyOutbound30 = trim$(x2652.SizeQtyOutbound30)

            If trim$(x2652.ProductInBoundNo) = "" Then x2652.ProductInBoundNo = Space(1)
            If trim$(x2652.ProductInBoundSeq) = "" Then x2652.ProductInBoundSeq = Space(1)
            If trim$(x2652.SizeQtyInbound01) = "" Then x2652.SizeQtyInbound01 = 0
            If trim$(x2652.SizeQtyInbound02) = "" Then x2652.SizeQtyInbound02 = 0
            If trim$(x2652.SizeQtyInbound03) = "" Then x2652.SizeQtyInbound03 = 0
            If trim$(x2652.SizeQtyInbound04) = "" Then x2652.SizeQtyInbound04 = 0
            If trim$(x2652.SizeQtyInbound05) = "" Then x2652.SizeQtyInbound05 = 0
            If trim$(x2652.SizeQtyInbound06) = "" Then x2652.SizeQtyInbound06 = 0
            If trim$(x2652.SizeQtyInbound07) = "" Then x2652.SizeQtyInbound07 = 0
            If trim$(x2652.SizeQtyInbound08) = "" Then x2652.SizeQtyInbound08 = 0
            If trim$(x2652.SizeQtyInbound09) = "" Then x2652.SizeQtyInbound09 = 0
            If trim$(x2652.SizeQtyInbound10) = "" Then x2652.SizeQtyInbound10 = 0
            If trim$(x2652.SizeQtyInbound11) = "" Then x2652.SizeQtyInbound11 = 0
            If trim$(x2652.SizeQtyInbound12) = "" Then x2652.SizeQtyInbound12 = 0
            If trim$(x2652.SizeQtyInbound13) = "" Then x2652.SizeQtyInbound13 = 0
            If trim$(x2652.SizeQtyInbound14) = "" Then x2652.SizeQtyInbound14 = 0
            If trim$(x2652.SizeQtyInbound15) = "" Then x2652.SizeQtyInbound15 = 0
            If trim$(x2652.SizeQtyInbound16) = "" Then x2652.SizeQtyInbound16 = 0
            If trim$(x2652.SizeQtyInbound17) = "" Then x2652.SizeQtyInbound17 = 0
            If trim$(x2652.SizeQtyInbound18) = "" Then x2652.SizeQtyInbound18 = 0
            If trim$(x2652.SizeQtyInbound19) = "" Then x2652.SizeQtyInbound19 = 0
            If trim$(x2652.SizeQtyInbound20) = "" Then x2652.SizeQtyInbound20 = 0
            If trim$(x2652.SizeQtyInbound21) = "" Then x2652.SizeQtyInbound21 = 0
            If trim$(x2652.SizeQtyInbound22) = "" Then x2652.SizeQtyInbound22 = 0
            If trim$(x2652.SizeQtyInbound23) = "" Then x2652.SizeQtyInbound23 = 0
            If trim$(x2652.SizeQtyInbound24) = "" Then x2652.SizeQtyInbound24 = 0
            If trim$(x2652.SizeQtyInbound25) = "" Then x2652.SizeQtyInbound25 = 0
            If trim$(x2652.SizeQtyInbound26) = "" Then x2652.SizeQtyInbound26 = 0
            If trim$(x2652.SizeQtyInbound27) = "" Then x2652.SizeQtyInbound27 = 0
            If trim$(x2652.SizeQtyInbound28) = "" Then x2652.SizeQtyInbound28 = 0
            If trim$(x2652.SizeQtyInbound29) = "" Then x2652.SizeQtyInbound29 = 0
            If trim$(x2652.SizeQtyInbound30) = "" Then x2652.SizeQtyInbound30 = 0
            If trim$(x2652.SizeQtyOutbound01) = "" Then x2652.SizeQtyOutbound01 = 0
            If trim$(x2652.SizeQtyOutbound02) = "" Then x2652.SizeQtyOutbound02 = 0
            If trim$(x2652.SizeQtyOutbound03) = "" Then x2652.SizeQtyOutbound03 = 0
            If trim$(x2652.SizeQtyOutbound04) = "" Then x2652.SizeQtyOutbound04 = 0
            If trim$(x2652.SizeQtyOutbound05) = "" Then x2652.SizeQtyOutbound05 = 0
            If trim$(x2652.SizeQtyOutbound06) = "" Then x2652.SizeQtyOutbound06 = 0
            If trim$(x2652.SizeQtyOutbound07) = "" Then x2652.SizeQtyOutbound07 = 0
            If trim$(x2652.SizeQtyOutbound08) = "" Then x2652.SizeQtyOutbound08 = 0
            If trim$(x2652.SizeQtyOutbound09) = "" Then x2652.SizeQtyOutbound09 = 0
            If trim$(x2652.SizeQtyOutbound10) = "" Then x2652.SizeQtyOutbound10 = 0
            If trim$(x2652.SizeQtyOutbound11) = "" Then x2652.SizeQtyOutbound11 = 0
            If trim$(x2652.SizeQtyOutbound12) = "" Then x2652.SizeQtyOutbound12 = 0
            If trim$(x2652.SizeQtyOutbound13) = "" Then x2652.SizeQtyOutbound13 = 0
            If trim$(x2652.SizeQtyOutbound14) = "" Then x2652.SizeQtyOutbound14 = 0
            If trim$(x2652.SizeQtyOutbound15) = "" Then x2652.SizeQtyOutbound15 = 0
            If trim$(x2652.SizeQtyOutbound16) = "" Then x2652.SizeQtyOutbound16 = 0
            If trim$(x2652.SizeQtyOutbound17) = "" Then x2652.SizeQtyOutbound17 = 0
            If trim$(x2652.SizeQtyOutbound18) = "" Then x2652.SizeQtyOutbound18 = 0
            If trim$(x2652.SizeQtyOutbound19) = "" Then x2652.SizeQtyOutbound19 = 0
            If trim$(x2652.SizeQtyOutbound20) = "" Then x2652.SizeQtyOutbound20 = 0
            If trim$(x2652.SizeQtyOutbound21) = "" Then x2652.SizeQtyOutbound21 = 0
            If trim$(x2652.SizeQtyOutbound22) = "" Then x2652.SizeQtyOutbound22 = 0
            If trim$(x2652.SizeQtyOutbound23) = "" Then x2652.SizeQtyOutbound23 = 0
            If trim$(x2652.SizeQtyOutbound24) = "" Then x2652.SizeQtyOutbound24 = 0
            If trim$(x2652.SizeQtyOutbound25) = "" Then x2652.SizeQtyOutbound25 = 0
            If trim$(x2652.SizeQtyOutbound26) = "" Then x2652.SizeQtyOutbound26 = 0
            If trim$(x2652.SizeQtyOutbound27) = "" Then x2652.SizeQtyOutbound27 = 0
            If trim$(x2652.SizeQtyOutbound28) = "" Then x2652.SizeQtyOutbound28 = 0
            If trim$(x2652.SizeQtyOutbound29) = "" Then x2652.SizeQtyOutbound29 = 0
            If trim$(x2652.SizeQtyOutbound30) = "" Then x2652.SizeQtyOutbound30 = 0


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K2652_MOVE(rs2652 As SqlClient.SqlDataReader)
        Try

            Call D2652_CLEAR()

            If IsdbNull(rs2652!K2652_ProductInBoundNo) = False Then D2652.ProductInBoundNo = Trim$(rs2652!K2652_ProductInBoundNo)
            If IsdbNull(rs2652!K2652_ProductInBoundSeq) = False Then D2652.ProductInBoundSeq = Trim$(rs2652!K2652_ProductInBoundSeq)
            If IsdbNull(rs2652!K2652_SizeQtyInbound01) = False Then D2652.SizeQtyInbound01 = Trim$(rs2652!K2652_SizeQtyInbound01)
            If IsdbNull(rs2652!K2652_SizeQtyInbound02) = False Then D2652.SizeQtyInbound02 = Trim$(rs2652!K2652_SizeQtyInbound02)
            If IsdbNull(rs2652!K2652_SizeQtyInbound03) = False Then D2652.SizeQtyInbound03 = Trim$(rs2652!K2652_SizeQtyInbound03)
            If IsdbNull(rs2652!K2652_SizeQtyInbound04) = False Then D2652.SizeQtyInbound04 = Trim$(rs2652!K2652_SizeQtyInbound04)
            If IsdbNull(rs2652!K2652_SizeQtyInbound05) = False Then D2652.SizeQtyInbound05 = Trim$(rs2652!K2652_SizeQtyInbound05)
            If IsdbNull(rs2652!K2652_SizeQtyInbound06) = False Then D2652.SizeQtyInbound06 = Trim$(rs2652!K2652_SizeQtyInbound06)
            If IsdbNull(rs2652!K2652_SizeQtyInbound07) = False Then D2652.SizeQtyInbound07 = Trim$(rs2652!K2652_SizeQtyInbound07)
            If IsdbNull(rs2652!K2652_SizeQtyInbound08) = False Then D2652.SizeQtyInbound08 = Trim$(rs2652!K2652_SizeQtyInbound08)
            If IsdbNull(rs2652!K2652_SizeQtyInbound09) = False Then D2652.SizeQtyInbound09 = Trim$(rs2652!K2652_SizeQtyInbound09)
            If IsdbNull(rs2652!K2652_SizeQtyInbound10) = False Then D2652.SizeQtyInbound10 = Trim$(rs2652!K2652_SizeQtyInbound10)
            If IsdbNull(rs2652!K2652_SizeQtyInbound11) = False Then D2652.SizeQtyInbound11 = Trim$(rs2652!K2652_SizeQtyInbound11)
            If IsdbNull(rs2652!K2652_SizeQtyInbound12) = False Then D2652.SizeQtyInbound12 = Trim$(rs2652!K2652_SizeQtyInbound12)
            If IsdbNull(rs2652!K2652_SizeQtyInbound13) = False Then D2652.SizeQtyInbound13 = Trim$(rs2652!K2652_SizeQtyInbound13)
            If IsdbNull(rs2652!K2652_SizeQtyInbound14) = False Then D2652.SizeQtyInbound14 = Trim$(rs2652!K2652_SizeQtyInbound14)
            If IsdbNull(rs2652!K2652_SizeQtyInbound15) = False Then D2652.SizeQtyInbound15 = Trim$(rs2652!K2652_SizeQtyInbound15)
            If IsdbNull(rs2652!K2652_SizeQtyInbound16) = False Then D2652.SizeQtyInbound16 = Trim$(rs2652!K2652_SizeQtyInbound16)
            If IsdbNull(rs2652!K2652_SizeQtyInbound17) = False Then D2652.SizeQtyInbound17 = Trim$(rs2652!K2652_SizeQtyInbound17)
            If IsdbNull(rs2652!K2652_SizeQtyInbound18) = False Then D2652.SizeQtyInbound18 = Trim$(rs2652!K2652_SizeQtyInbound18)
            If IsdbNull(rs2652!K2652_SizeQtyInbound19) = False Then D2652.SizeQtyInbound19 = Trim$(rs2652!K2652_SizeQtyInbound19)
            If IsdbNull(rs2652!K2652_SizeQtyInbound20) = False Then D2652.SizeQtyInbound20 = Trim$(rs2652!K2652_SizeQtyInbound20)
            If IsdbNull(rs2652!K2652_SizeQtyInbound21) = False Then D2652.SizeQtyInbound21 = Trim$(rs2652!K2652_SizeQtyInbound21)
            If IsdbNull(rs2652!K2652_SizeQtyInbound22) = False Then D2652.SizeQtyInbound22 = Trim$(rs2652!K2652_SizeQtyInbound22)
            If IsdbNull(rs2652!K2652_SizeQtyInbound23) = False Then D2652.SizeQtyInbound23 = Trim$(rs2652!K2652_SizeQtyInbound23)
            If IsdbNull(rs2652!K2652_SizeQtyInbound24) = False Then D2652.SizeQtyInbound24 = Trim$(rs2652!K2652_SizeQtyInbound24)
            If IsdbNull(rs2652!K2652_SizeQtyInbound25) = False Then D2652.SizeQtyInbound25 = Trim$(rs2652!K2652_SizeQtyInbound25)
            If IsdbNull(rs2652!K2652_SizeQtyInbound26) = False Then D2652.SizeQtyInbound26 = Trim$(rs2652!K2652_SizeQtyInbound26)
            If IsdbNull(rs2652!K2652_SizeQtyInbound27) = False Then D2652.SizeQtyInbound27 = Trim$(rs2652!K2652_SizeQtyInbound27)
            If IsdbNull(rs2652!K2652_SizeQtyInbound28) = False Then D2652.SizeQtyInbound28 = Trim$(rs2652!K2652_SizeQtyInbound28)
            If IsdbNull(rs2652!K2652_SizeQtyInbound29) = False Then D2652.SizeQtyInbound29 = Trim$(rs2652!K2652_SizeQtyInbound29)
            If IsdbNull(rs2652!K2652_SizeQtyInbound30) = False Then D2652.SizeQtyInbound30 = Trim$(rs2652!K2652_SizeQtyInbound30)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound01) = False Then D2652.SizeQtyOutbound01 = Trim$(rs2652!K2652_SizeQtyOutbound01)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound02) = False Then D2652.SizeQtyOutbound02 = Trim$(rs2652!K2652_SizeQtyOutbound02)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound03) = False Then D2652.SizeQtyOutbound03 = Trim$(rs2652!K2652_SizeQtyOutbound03)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound04) = False Then D2652.SizeQtyOutbound04 = Trim$(rs2652!K2652_SizeQtyOutbound04)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound05) = False Then D2652.SizeQtyOutbound05 = Trim$(rs2652!K2652_SizeQtyOutbound05)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound06) = False Then D2652.SizeQtyOutbound06 = Trim$(rs2652!K2652_SizeQtyOutbound06)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound07) = False Then D2652.SizeQtyOutbound07 = Trim$(rs2652!K2652_SizeQtyOutbound07)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound08) = False Then D2652.SizeQtyOutbound08 = Trim$(rs2652!K2652_SizeQtyOutbound08)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound09) = False Then D2652.SizeQtyOutbound09 = Trim$(rs2652!K2652_SizeQtyOutbound09)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound10) = False Then D2652.SizeQtyOutbound10 = Trim$(rs2652!K2652_SizeQtyOutbound10)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound11) = False Then D2652.SizeQtyOutbound11 = Trim$(rs2652!K2652_SizeQtyOutbound11)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound12) = False Then D2652.SizeQtyOutbound12 = Trim$(rs2652!K2652_SizeQtyOutbound12)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound13) = False Then D2652.SizeQtyOutbound13 = Trim$(rs2652!K2652_SizeQtyOutbound13)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound14) = False Then D2652.SizeQtyOutbound14 = Trim$(rs2652!K2652_SizeQtyOutbound14)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound15) = False Then D2652.SizeQtyOutbound15 = Trim$(rs2652!K2652_SizeQtyOutbound15)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound16) = False Then D2652.SizeQtyOutbound16 = Trim$(rs2652!K2652_SizeQtyOutbound16)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound17) = False Then D2652.SizeQtyOutbound17 = Trim$(rs2652!K2652_SizeQtyOutbound17)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound18) = False Then D2652.SizeQtyOutbound18 = Trim$(rs2652!K2652_SizeQtyOutbound18)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound19) = False Then D2652.SizeQtyOutbound19 = Trim$(rs2652!K2652_SizeQtyOutbound19)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound20) = False Then D2652.SizeQtyOutbound20 = Trim$(rs2652!K2652_SizeQtyOutbound20)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound21) = False Then D2652.SizeQtyOutbound21 = Trim$(rs2652!K2652_SizeQtyOutbound21)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound22) = False Then D2652.SizeQtyOutbound22 = Trim$(rs2652!K2652_SizeQtyOutbound22)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound23) = False Then D2652.SizeQtyOutbound23 = Trim$(rs2652!K2652_SizeQtyOutbound23)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound24) = False Then D2652.SizeQtyOutbound24 = Trim$(rs2652!K2652_SizeQtyOutbound24)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound25) = False Then D2652.SizeQtyOutbound25 = Trim$(rs2652!K2652_SizeQtyOutbound25)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound26) = False Then D2652.SizeQtyOutbound26 = Trim$(rs2652!K2652_SizeQtyOutbound26)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound27) = False Then D2652.SizeQtyOutbound27 = Trim$(rs2652!K2652_SizeQtyOutbound27)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound28) = False Then D2652.SizeQtyOutbound28 = Trim$(rs2652!K2652_SizeQtyOutbound28)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound29) = False Then D2652.SizeQtyOutbound29 = Trim$(rs2652!K2652_SizeQtyOutbound29)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound30) = False Then D2652.SizeQtyOutbound30 = Trim$(rs2652!K2652_SizeQtyOutbound30)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K2652_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K2652_MOVE(rs2652 As DataRow)
        Try

            Call D2652_CLEAR()

            If IsdbNull(rs2652!K2652_ProductInBoundNo) = False Then D2652.ProductInBoundNo = Trim$(rs2652!K2652_ProductInBoundNo)
            If IsdbNull(rs2652!K2652_ProductInBoundSeq) = False Then D2652.ProductInBoundSeq = Trim$(rs2652!K2652_ProductInBoundSeq)
            If IsdbNull(rs2652!K2652_SizeQtyInbound01) = False Then D2652.SizeQtyInbound01 = Trim$(rs2652!K2652_SizeQtyInbound01)
            If IsdbNull(rs2652!K2652_SizeQtyInbound02) = False Then D2652.SizeQtyInbound02 = Trim$(rs2652!K2652_SizeQtyInbound02)
            If IsdbNull(rs2652!K2652_SizeQtyInbound03) = False Then D2652.SizeQtyInbound03 = Trim$(rs2652!K2652_SizeQtyInbound03)
            If IsdbNull(rs2652!K2652_SizeQtyInbound04) = False Then D2652.SizeQtyInbound04 = Trim$(rs2652!K2652_SizeQtyInbound04)
            If IsdbNull(rs2652!K2652_SizeQtyInbound05) = False Then D2652.SizeQtyInbound05 = Trim$(rs2652!K2652_SizeQtyInbound05)
            If IsdbNull(rs2652!K2652_SizeQtyInbound06) = False Then D2652.SizeQtyInbound06 = Trim$(rs2652!K2652_SizeQtyInbound06)
            If IsdbNull(rs2652!K2652_SizeQtyInbound07) = False Then D2652.SizeQtyInbound07 = Trim$(rs2652!K2652_SizeQtyInbound07)
            If IsdbNull(rs2652!K2652_SizeQtyInbound08) = False Then D2652.SizeQtyInbound08 = Trim$(rs2652!K2652_SizeQtyInbound08)
            If IsdbNull(rs2652!K2652_SizeQtyInbound09) = False Then D2652.SizeQtyInbound09 = Trim$(rs2652!K2652_SizeQtyInbound09)
            If IsdbNull(rs2652!K2652_SizeQtyInbound10) = False Then D2652.SizeQtyInbound10 = Trim$(rs2652!K2652_SizeQtyInbound10)
            If IsdbNull(rs2652!K2652_SizeQtyInbound11) = False Then D2652.SizeQtyInbound11 = Trim$(rs2652!K2652_SizeQtyInbound11)
            If IsdbNull(rs2652!K2652_SizeQtyInbound12) = False Then D2652.SizeQtyInbound12 = Trim$(rs2652!K2652_SizeQtyInbound12)
            If IsdbNull(rs2652!K2652_SizeQtyInbound13) = False Then D2652.SizeQtyInbound13 = Trim$(rs2652!K2652_SizeQtyInbound13)
            If IsdbNull(rs2652!K2652_SizeQtyInbound14) = False Then D2652.SizeQtyInbound14 = Trim$(rs2652!K2652_SizeQtyInbound14)
            If IsdbNull(rs2652!K2652_SizeQtyInbound15) = False Then D2652.SizeQtyInbound15 = Trim$(rs2652!K2652_SizeQtyInbound15)
            If IsdbNull(rs2652!K2652_SizeQtyInbound16) = False Then D2652.SizeQtyInbound16 = Trim$(rs2652!K2652_SizeQtyInbound16)
            If IsdbNull(rs2652!K2652_SizeQtyInbound17) = False Then D2652.SizeQtyInbound17 = Trim$(rs2652!K2652_SizeQtyInbound17)
            If IsdbNull(rs2652!K2652_SizeQtyInbound18) = False Then D2652.SizeQtyInbound18 = Trim$(rs2652!K2652_SizeQtyInbound18)
            If IsdbNull(rs2652!K2652_SizeQtyInbound19) = False Then D2652.SizeQtyInbound19 = Trim$(rs2652!K2652_SizeQtyInbound19)
            If IsdbNull(rs2652!K2652_SizeQtyInbound20) = False Then D2652.SizeQtyInbound20 = Trim$(rs2652!K2652_SizeQtyInbound20)
            If IsdbNull(rs2652!K2652_SizeQtyInbound21) = False Then D2652.SizeQtyInbound21 = Trim$(rs2652!K2652_SizeQtyInbound21)
            If IsdbNull(rs2652!K2652_SizeQtyInbound22) = False Then D2652.SizeQtyInbound22 = Trim$(rs2652!K2652_SizeQtyInbound22)
            If IsdbNull(rs2652!K2652_SizeQtyInbound23) = False Then D2652.SizeQtyInbound23 = Trim$(rs2652!K2652_SizeQtyInbound23)
            If IsdbNull(rs2652!K2652_SizeQtyInbound24) = False Then D2652.SizeQtyInbound24 = Trim$(rs2652!K2652_SizeQtyInbound24)
            If IsdbNull(rs2652!K2652_SizeQtyInbound25) = False Then D2652.SizeQtyInbound25 = Trim$(rs2652!K2652_SizeQtyInbound25)
            If IsdbNull(rs2652!K2652_SizeQtyInbound26) = False Then D2652.SizeQtyInbound26 = Trim$(rs2652!K2652_SizeQtyInbound26)
            If IsdbNull(rs2652!K2652_SizeQtyInbound27) = False Then D2652.SizeQtyInbound27 = Trim$(rs2652!K2652_SizeQtyInbound27)
            If IsdbNull(rs2652!K2652_SizeQtyInbound28) = False Then D2652.SizeQtyInbound28 = Trim$(rs2652!K2652_SizeQtyInbound28)
            If IsdbNull(rs2652!K2652_SizeQtyInbound29) = False Then D2652.SizeQtyInbound29 = Trim$(rs2652!K2652_SizeQtyInbound29)
            If IsdbNull(rs2652!K2652_SizeQtyInbound30) = False Then D2652.SizeQtyInbound30 = Trim$(rs2652!K2652_SizeQtyInbound30)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound01) = False Then D2652.SizeQtyOutbound01 = Trim$(rs2652!K2652_SizeQtyOutbound01)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound02) = False Then D2652.SizeQtyOutbound02 = Trim$(rs2652!K2652_SizeQtyOutbound02)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound03) = False Then D2652.SizeQtyOutbound03 = Trim$(rs2652!K2652_SizeQtyOutbound03)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound04) = False Then D2652.SizeQtyOutbound04 = Trim$(rs2652!K2652_SizeQtyOutbound04)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound05) = False Then D2652.SizeQtyOutbound05 = Trim$(rs2652!K2652_SizeQtyOutbound05)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound06) = False Then D2652.SizeQtyOutbound06 = Trim$(rs2652!K2652_SizeQtyOutbound06)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound07) = False Then D2652.SizeQtyOutbound07 = Trim$(rs2652!K2652_SizeQtyOutbound07)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound08) = False Then D2652.SizeQtyOutbound08 = Trim$(rs2652!K2652_SizeQtyOutbound08)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound09) = False Then D2652.SizeQtyOutbound09 = Trim$(rs2652!K2652_SizeQtyOutbound09)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound10) = False Then D2652.SizeQtyOutbound10 = Trim$(rs2652!K2652_SizeQtyOutbound10)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound11) = False Then D2652.SizeQtyOutbound11 = Trim$(rs2652!K2652_SizeQtyOutbound11)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound12) = False Then D2652.SizeQtyOutbound12 = Trim$(rs2652!K2652_SizeQtyOutbound12)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound13) = False Then D2652.SizeQtyOutbound13 = Trim$(rs2652!K2652_SizeQtyOutbound13)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound14) = False Then D2652.SizeQtyOutbound14 = Trim$(rs2652!K2652_SizeQtyOutbound14)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound15) = False Then D2652.SizeQtyOutbound15 = Trim$(rs2652!K2652_SizeQtyOutbound15)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound16) = False Then D2652.SizeQtyOutbound16 = Trim$(rs2652!K2652_SizeQtyOutbound16)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound17) = False Then D2652.SizeQtyOutbound17 = Trim$(rs2652!K2652_SizeQtyOutbound17)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound18) = False Then D2652.SizeQtyOutbound18 = Trim$(rs2652!K2652_SizeQtyOutbound18)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound19) = False Then D2652.SizeQtyOutbound19 = Trim$(rs2652!K2652_SizeQtyOutbound19)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound20) = False Then D2652.SizeQtyOutbound20 = Trim$(rs2652!K2652_SizeQtyOutbound20)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound21) = False Then D2652.SizeQtyOutbound21 = Trim$(rs2652!K2652_SizeQtyOutbound21)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound22) = False Then D2652.SizeQtyOutbound22 = Trim$(rs2652!K2652_SizeQtyOutbound22)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound23) = False Then D2652.SizeQtyOutbound23 = Trim$(rs2652!K2652_SizeQtyOutbound23)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound24) = False Then D2652.SizeQtyOutbound24 = Trim$(rs2652!K2652_SizeQtyOutbound24)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound25) = False Then D2652.SizeQtyOutbound25 = Trim$(rs2652!K2652_SizeQtyOutbound25)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound26) = False Then D2652.SizeQtyOutbound26 = Trim$(rs2652!K2652_SizeQtyOutbound26)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound27) = False Then D2652.SizeQtyOutbound27 = Trim$(rs2652!K2652_SizeQtyOutbound27)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound28) = False Then D2652.SizeQtyOutbound28 = Trim$(rs2652!K2652_SizeQtyOutbound28)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound29) = False Then D2652.SizeQtyOutbound29 = Trim$(rs2652!K2652_SizeQtyOutbound29)
            If IsdbNull(rs2652!K2652_SizeQtyOutbound30) = False Then D2652.SizeQtyOutbound30 = Trim$(rs2652!K2652_SizeQtyOutbound30)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K2652_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K2652_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z2652 As T2652_AREA, PRODUCTINBOUNDNO As String, PRODUCTINBOUNDSEQ As String) As Boolean

        K2652_MOVE = False

        Try
            If READ_PFK2652(PRODUCTINBOUNDNO, PRODUCTINBOUNDSEQ) = True Then
                z2652 = D2652
                K2652_MOVE = True
            Else
                z2652 = Nothing
            End If

            If getColumIndex(spr, "ProductInBoundNo") > -1 Then z2652.ProductInBoundNo = getDataM(spr, getColumIndex(spr, "ProductInBoundNo"), xRow)
            If getColumIndex(spr, "ProductInBoundSeq") > -1 Then z2652.ProductInBoundSeq = getDataM(spr, getColumIndex(spr, "ProductInBoundSeq"), xRow)
            If getColumIndex(spr, "SizeQtyInbound01") > -1 Then z2652.SizeQtyInbound01 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound01"), xRow)
            If getColumIndex(spr, "SizeQtyInbound02") > -1 Then z2652.SizeQtyInbound02 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound02"), xRow)
            If getColumIndex(spr, "SizeQtyInbound03") > -1 Then z2652.SizeQtyInbound03 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound03"), xRow)
            If getColumIndex(spr, "SizeQtyInbound04") > -1 Then z2652.SizeQtyInbound04 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound04"), xRow)
            If getColumIndex(spr, "SizeQtyInbound05") > -1 Then z2652.SizeQtyInbound05 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound05"), xRow)
            If getColumIndex(spr, "SizeQtyInbound06") > -1 Then z2652.SizeQtyInbound06 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound06"), xRow)
            If getColumIndex(spr, "SizeQtyInbound07") > -1 Then z2652.SizeQtyInbound07 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound07"), xRow)
            If getColumIndex(spr, "SizeQtyInbound08") > -1 Then z2652.SizeQtyInbound08 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound08"), xRow)
            If getColumIndex(spr, "SizeQtyInbound09") > -1 Then z2652.SizeQtyInbound09 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound09"), xRow)
            If getColumIndex(spr, "SizeQtyInbound10") > -1 Then z2652.SizeQtyInbound10 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound10"), xRow)
            If getColumIndex(spr, "SizeQtyInbound11") > -1 Then z2652.SizeQtyInbound11 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound11"), xRow)
            If getColumIndex(spr, "SizeQtyInbound12") > -1 Then z2652.SizeQtyInbound12 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound12"), xRow)
            If getColumIndex(spr, "SizeQtyInbound13") > -1 Then z2652.SizeQtyInbound13 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound13"), xRow)
            If getColumIndex(spr, "SizeQtyInbound14") > -1 Then z2652.SizeQtyInbound14 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound14"), xRow)
            If getColumIndex(spr, "SizeQtyInbound15") > -1 Then z2652.SizeQtyInbound15 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound15"), xRow)
            If getColumIndex(spr, "SizeQtyInbound16") > -1 Then z2652.SizeQtyInbound16 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound16"), xRow)
            If getColumIndex(spr, "SizeQtyInbound17") > -1 Then z2652.SizeQtyInbound17 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound17"), xRow)
            If getColumIndex(spr, "SizeQtyInbound18") > -1 Then z2652.SizeQtyInbound18 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound18"), xRow)
            If getColumIndex(spr, "SizeQtyInbound19") > -1 Then z2652.SizeQtyInbound19 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound19"), xRow)
            If getColumIndex(spr, "SizeQtyInbound20") > -1 Then z2652.SizeQtyInbound20 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound20"), xRow)
            If getColumIndex(spr, "SizeQtyInbound21") > -1 Then z2652.SizeQtyInbound21 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound21"), xRow)
            If getColumIndex(spr, "SizeQtyInbound22") > -1 Then z2652.SizeQtyInbound22 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound22"), xRow)
            If getColumIndex(spr, "SizeQtyInbound23") > -1 Then z2652.SizeQtyInbound23 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound23"), xRow)
            If getColumIndex(spr, "SizeQtyInbound24") > -1 Then z2652.SizeQtyInbound24 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound24"), xRow)
            If getColumIndex(spr, "SizeQtyInbound25") > -1 Then z2652.SizeQtyInbound25 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound25"), xRow)
            If getColumIndex(spr, "SizeQtyInbound26") > -1 Then z2652.SizeQtyInbound26 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound26"), xRow)
            If getColumIndex(spr, "SizeQtyInbound27") > -1 Then z2652.SizeQtyInbound27 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound27"), xRow)
            If getColumIndex(spr, "SizeQtyInbound28") > -1 Then z2652.SizeQtyInbound28 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound28"), xRow)
            If getColumIndex(spr, "SizeQtyInbound29") > -1 Then z2652.SizeQtyInbound29 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound29"), xRow)
            If getColumIndex(spr, "SizeQtyInbound30") > -1 Then z2652.SizeQtyInbound30 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound30"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound01") > -1 Then z2652.SizeQtyOutbound01 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound01"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound02") > -1 Then z2652.SizeQtyOutbound02 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound02"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound03") > -1 Then z2652.SizeQtyOutbound03 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound03"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound04") > -1 Then z2652.SizeQtyOutbound04 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound04"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound05") > -1 Then z2652.SizeQtyOutbound05 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound05"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound06") > -1 Then z2652.SizeQtyOutbound06 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound06"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound07") > -1 Then z2652.SizeQtyOutbound07 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound07"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound08") > -1 Then z2652.SizeQtyOutbound08 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound08"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound09") > -1 Then z2652.SizeQtyOutbound09 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound09"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound10") > -1 Then z2652.SizeQtyOutbound10 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound10"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound11") > -1 Then z2652.SizeQtyOutbound11 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound11"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound12") > -1 Then z2652.SizeQtyOutbound12 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound12"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound13") > -1 Then z2652.SizeQtyOutbound13 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound13"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound14") > -1 Then z2652.SizeQtyOutbound14 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound14"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound15") > -1 Then z2652.SizeQtyOutbound15 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound15"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound16") > -1 Then z2652.SizeQtyOutbound16 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound16"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound17") > -1 Then z2652.SizeQtyOutbound17 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound17"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound18") > -1 Then z2652.SizeQtyOutbound18 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound18"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound19") > -1 Then z2652.SizeQtyOutbound19 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound19"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound20") > -1 Then z2652.SizeQtyOutbound20 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound20"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound21") > -1 Then z2652.SizeQtyOutbound21 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound21"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound22") > -1 Then z2652.SizeQtyOutbound22 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound22"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound23") > -1 Then z2652.SizeQtyOutbound23 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound23"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound24") > -1 Then z2652.SizeQtyOutbound24 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound24"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound25") > -1 Then z2652.SizeQtyOutbound25 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound25"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound26") > -1 Then z2652.SizeQtyOutbound26 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound26"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound27") > -1 Then z2652.SizeQtyOutbound27 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound27"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound28") > -1 Then z2652.SizeQtyOutbound28 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound28"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound29") > -1 Then z2652.SizeQtyOutbound29 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound29"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound30") > -1 Then z2652.SizeQtyOutbound30 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound30"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2652_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K2652_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z2652 As T2652_AREA, CheckClear As Boolean, PRODUCTINBOUNDNO As String, PRODUCTINBOUNDSEQ As String) As Boolean

        K2652_MOVE = False

        Try
            If READ_PFK2652(PRODUCTINBOUNDNO, PRODUCTINBOUNDSEQ) = True Then
                z2652 = D2652
                K2652_MOVE = True
            Else
                If CheckClear = True Then z2652 = Nothing
            End If

            If getColumIndex(spr, "ProductInBoundNo") > -1 Then z2652.ProductInBoundNo = getDataM(spr, getColumIndex(spr, "ProductInBoundNo"), xRow)
            If getColumIndex(spr, "ProductInBoundSeq") > -1 Then z2652.ProductInBoundSeq = getDataM(spr, getColumIndex(spr, "ProductInBoundSeq"), xRow)
            If getColumIndex(spr, "SizeQtyInbound01") > -1 Then z2652.SizeQtyInbound01 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound01"), xRow)
            If getColumIndex(spr, "SizeQtyInbound02") > -1 Then z2652.SizeQtyInbound02 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound02"), xRow)
            If getColumIndex(spr, "SizeQtyInbound03") > -1 Then z2652.SizeQtyInbound03 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound03"), xRow)
            If getColumIndex(spr, "SizeQtyInbound04") > -1 Then z2652.SizeQtyInbound04 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound04"), xRow)
            If getColumIndex(spr, "SizeQtyInbound05") > -1 Then z2652.SizeQtyInbound05 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound05"), xRow)
            If getColumIndex(spr, "SizeQtyInbound06") > -1 Then z2652.SizeQtyInbound06 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound06"), xRow)
            If getColumIndex(spr, "SizeQtyInbound07") > -1 Then z2652.SizeQtyInbound07 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound07"), xRow)
            If getColumIndex(spr, "SizeQtyInbound08") > -1 Then z2652.SizeQtyInbound08 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound08"), xRow)
            If getColumIndex(spr, "SizeQtyInbound09") > -1 Then z2652.SizeQtyInbound09 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound09"), xRow)
            If getColumIndex(spr, "SizeQtyInbound10") > -1 Then z2652.SizeQtyInbound10 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound10"), xRow)
            If getColumIndex(spr, "SizeQtyInbound11") > -1 Then z2652.SizeQtyInbound11 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound11"), xRow)
            If getColumIndex(spr, "SizeQtyInbound12") > -1 Then z2652.SizeQtyInbound12 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound12"), xRow)
            If getColumIndex(spr, "SizeQtyInbound13") > -1 Then z2652.SizeQtyInbound13 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound13"), xRow)
            If getColumIndex(spr, "SizeQtyInbound14") > -1 Then z2652.SizeQtyInbound14 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound14"), xRow)
            If getColumIndex(spr, "SizeQtyInbound15") > -1 Then z2652.SizeQtyInbound15 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound15"), xRow)
            If getColumIndex(spr, "SizeQtyInbound16") > -1 Then z2652.SizeQtyInbound16 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound16"), xRow)
            If getColumIndex(spr, "SizeQtyInbound17") > -1 Then z2652.SizeQtyInbound17 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound17"), xRow)
            If getColumIndex(spr, "SizeQtyInbound18") > -1 Then z2652.SizeQtyInbound18 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound18"), xRow)
            If getColumIndex(spr, "SizeQtyInbound19") > -1 Then z2652.SizeQtyInbound19 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound19"), xRow)
            If getColumIndex(spr, "SizeQtyInbound20") > -1 Then z2652.SizeQtyInbound20 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound20"), xRow)
            If getColumIndex(spr, "SizeQtyInbound21") > -1 Then z2652.SizeQtyInbound21 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound21"), xRow)
            If getColumIndex(spr, "SizeQtyInbound22") > -1 Then z2652.SizeQtyInbound22 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound22"), xRow)
            If getColumIndex(spr, "SizeQtyInbound23") > -1 Then z2652.SizeQtyInbound23 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound23"), xRow)
            If getColumIndex(spr, "SizeQtyInbound24") > -1 Then z2652.SizeQtyInbound24 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound24"), xRow)
            If getColumIndex(spr, "SizeQtyInbound25") > -1 Then z2652.SizeQtyInbound25 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound25"), xRow)
            If getColumIndex(spr, "SizeQtyInbound26") > -1 Then z2652.SizeQtyInbound26 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound26"), xRow)
            If getColumIndex(spr, "SizeQtyInbound27") > -1 Then z2652.SizeQtyInbound27 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound27"), xRow)
            If getColumIndex(spr, "SizeQtyInbound28") > -1 Then z2652.SizeQtyInbound28 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound28"), xRow)
            If getColumIndex(spr, "SizeQtyInbound29") > -1 Then z2652.SizeQtyInbound29 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound29"), xRow)
            If getColumIndex(spr, "SizeQtyInbound30") > -1 Then z2652.SizeQtyInbound30 = getDataM(spr, getColumIndex(spr, "SizeQtyInbound30"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound01") > -1 Then z2652.SizeQtyOutbound01 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound01"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound02") > -1 Then z2652.SizeQtyOutbound02 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound02"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound03") > -1 Then z2652.SizeQtyOutbound03 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound03"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound04") > -1 Then z2652.SizeQtyOutbound04 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound04"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound05") > -1 Then z2652.SizeQtyOutbound05 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound05"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound06") > -1 Then z2652.SizeQtyOutbound06 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound06"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound07") > -1 Then z2652.SizeQtyOutbound07 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound07"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound08") > -1 Then z2652.SizeQtyOutbound08 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound08"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound09") > -1 Then z2652.SizeQtyOutbound09 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound09"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound10") > -1 Then z2652.SizeQtyOutbound10 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound10"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound11") > -1 Then z2652.SizeQtyOutbound11 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound11"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound12") > -1 Then z2652.SizeQtyOutbound12 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound12"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound13") > -1 Then z2652.SizeQtyOutbound13 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound13"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound14") > -1 Then z2652.SizeQtyOutbound14 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound14"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound15") > -1 Then z2652.SizeQtyOutbound15 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound15"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound16") > -1 Then z2652.SizeQtyOutbound16 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound16"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound17") > -1 Then z2652.SizeQtyOutbound17 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound17"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound18") > -1 Then z2652.SizeQtyOutbound18 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound18"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound19") > -1 Then z2652.SizeQtyOutbound19 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound19"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound20") > -1 Then z2652.SizeQtyOutbound20 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound20"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound21") > -1 Then z2652.SizeQtyOutbound21 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound21"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound22") > -1 Then z2652.SizeQtyOutbound22 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound22"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound23") > -1 Then z2652.SizeQtyOutbound23 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound23"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound24") > -1 Then z2652.SizeQtyOutbound24 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound24"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound25") > -1 Then z2652.SizeQtyOutbound25 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound25"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound26") > -1 Then z2652.SizeQtyOutbound26 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound26"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound27") > -1 Then z2652.SizeQtyOutbound27 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound27"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound28") > -1 Then z2652.SizeQtyOutbound28 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound28"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound29") > -1 Then z2652.SizeQtyOutbound29 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound29"), xRow)
            If getColumIndex(spr, "SizeQtyOutbound30") > -1 Then z2652.SizeQtyOutbound30 = getDataM(spr, getColumIndex(spr, "SizeQtyOutbound30"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2652_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K2652_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z2652 As T2652_AREA, Job As String, PRODUCTINBOUNDNO As String, PRODUCTINBOUNDSEQ As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K2652_MOVE = False

        Try
            If READ_PFK2652(PRODUCTINBOUNDNO, PRODUCTINBOUNDSEQ) = True Then
                z2652 = D2652
                K2652_MOVE = True
            Else
                z2652 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2652")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "PRODUCTINBOUNDNO" : z2652.ProductInBoundNo = Children(i).Code
                                Case "PRODUCTINBOUNDSEQ" : z2652.ProductInBoundSeq = Children(i).Code
                                Case "SIZEQTYINBOUND01" : z2652.SizeQtyInbound01 = Children(i).Code
                                Case "SIZEQTYINBOUND02" : z2652.SizeQtyInbound02 = Children(i).Code
                                Case "SIZEQTYINBOUND03" : z2652.SizeQtyInbound03 = Children(i).Code
                                Case "SIZEQTYINBOUND04" : z2652.SizeQtyInbound04 = Children(i).Code
                                Case "SIZEQTYINBOUND05" : z2652.SizeQtyInbound05 = Children(i).Code
                                Case "SIZEQTYINBOUND06" : z2652.SizeQtyInbound06 = Children(i).Code
                                Case "SIZEQTYINBOUND07" : z2652.SizeQtyInbound07 = Children(i).Code
                                Case "SIZEQTYINBOUND08" : z2652.SizeQtyInbound08 = Children(i).Code
                                Case "SIZEQTYINBOUND09" : z2652.SizeQtyInbound09 = Children(i).Code
                                Case "SIZEQTYINBOUND10" : z2652.SizeQtyInbound10 = Children(i).Code
                                Case "SIZEQTYINBOUND11" : z2652.SizeQtyInbound11 = Children(i).Code
                                Case "SIZEQTYINBOUND12" : z2652.SizeQtyInbound12 = Children(i).Code
                                Case "SIZEQTYINBOUND13" : z2652.SizeQtyInbound13 = Children(i).Code
                                Case "SIZEQTYINBOUND14" : z2652.SizeQtyInbound14 = Children(i).Code
                                Case "SIZEQTYINBOUND15" : z2652.SizeQtyInbound15 = Children(i).Code
                                Case "SIZEQTYINBOUND16" : z2652.SizeQtyInbound16 = Children(i).Code
                                Case "SIZEQTYINBOUND17" : z2652.SizeQtyInbound17 = Children(i).Code
                                Case "SIZEQTYINBOUND18" : z2652.SizeQtyInbound18 = Children(i).Code
                                Case "SIZEQTYINBOUND19" : z2652.SizeQtyInbound19 = Children(i).Code
                                Case "SIZEQTYINBOUND20" : z2652.SizeQtyInbound20 = Children(i).Code
                                Case "SIZEQTYINBOUND21" : z2652.SizeQtyInbound21 = Children(i).Code
                                Case "SIZEQTYINBOUND22" : z2652.SizeQtyInbound22 = Children(i).Code
                                Case "SIZEQTYINBOUND23" : z2652.SizeQtyInbound23 = Children(i).Code
                                Case "SIZEQTYINBOUND24" : z2652.SizeQtyInbound24 = Children(i).Code
                                Case "SIZEQTYINBOUND25" : z2652.SizeQtyInbound25 = Children(i).Code
                                Case "SIZEQTYINBOUND26" : z2652.SizeQtyInbound26 = Children(i).Code
                                Case "SIZEQTYINBOUND27" : z2652.SizeQtyInbound27 = Children(i).Code
                                Case "SIZEQTYINBOUND28" : z2652.SizeQtyInbound28 = Children(i).Code
                                Case "SIZEQTYINBOUND29" : z2652.SizeQtyInbound29 = Children(i).Code
                                Case "SIZEQTYINBOUND30" : z2652.SizeQtyInbound30 = Children(i).Code
                                Case "SIZEQTYOUTBOUND01" : z2652.SizeQtyOutbound01 = Children(i).Code
                                Case "SIZEQTYOUTBOUND02" : z2652.SizeQtyOutbound02 = Children(i).Code
                                Case "SIZEQTYOUTBOUND03" : z2652.SizeQtyOutbound03 = Children(i).Code
                                Case "SIZEQTYOUTBOUND04" : z2652.SizeQtyOutbound04 = Children(i).Code
                                Case "SIZEQTYOUTBOUND05" : z2652.SizeQtyOutbound05 = Children(i).Code
                                Case "SIZEQTYOUTBOUND06" : z2652.SizeQtyOutbound06 = Children(i).Code
                                Case "SIZEQTYOUTBOUND07" : z2652.SizeQtyOutbound07 = Children(i).Code
                                Case "SIZEQTYOUTBOUND08" : z2652.SizeQtyOutbound08 = Children(i).Code
                                Case "SIZEQTYOUTBOUND09" : z2652.SizeQtyOutbound09 = Children(i).Code
                                Case "SIZEQTYOUTBOUND10" : z2652.SizeQtyOutbound10 = Children(i).Code
                                Case "SIZEQTYOUTBOUND11" : z2652.SizeQtyOutbound11 = Children(i).Code
                                Case "SIZEQTYOUTBOUND12" : z2652.SizeQtyOutbound12 = Children(i).Code
                                Case "SIZEQTYOUTBOUND13" : z2652.SizeQtyOutbound13 = Children(i).Code
                                Case "SIZEQTYOUTBOUND14" : z2652.SizeQtyOutbound14 = Children(i).Code
                                Case "SIZEQTYOUTBOUND15" : z2652.SizeQtyOutbound15 = Children(i).Code
                                Case "SIZEQTYOUTBOUND16" : z2652.SizeQtyOutbound16 = Children(i).Code
                                Case "SIZEQTYOUTBOUND17" : z2652.SizeQtyOutbound17 = Children(i).Code
                                Case "SIZEQTYOUTBOUND18" : z2652.SizeQtyOutbound18 = Children(i).Code
                                Case "SIZEQTYOUTBOUND19" : z2652.SizeQtyOutbound19 = Children(i).Code
                                Case "SIZEQTYOUTBOUND20" : z2652.SizeQtyOutbound20 = Children(i).Code
                                Case "SIZEQTYOUTBOUND21" : z2652.SizeQtyOutbound21 = Children(i).Code
                                Case "SIZEQTYOUTBOUND22" : z2652.SizeQtyOutbound22 = Children(i).Code
                                Case "SIZEQTYOUTBOUND23" : z2652.SizeQtyOutbound23 = Children(i).Code
                                Case "SIZEQTYOUTBOUND24" : z2652.SizeQtyOutbound24 = Children(i).Code
                                Case "SIZEQTYOUTBOUND25" : z2652.SizeQtyOutbound25 = Children(i).Code
                                Case "SIZEQTYOUTBOUND26" : z2652.SizeQtyOutbound26 = Children(i).Code
                                Case "SIZEQTYOUTBOUND27" : z2652.SizeQtyOutbound27 = Children(i).Code
                                Case "SIZEQTYOUTBOUND28" : z2652.SizeQtyOutbound28 = Children(i).Code
                                Case "SIZEQTYOUTBOUND29" : z2652.SizeQtyOutbound29 = Children(i).Code
                                Case "SIZEQTYOUTBOUND30" : z2652.SizeQtyOutbound30 = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "PRODUCTINBOUNDNO" : z2652.ProductInBoundNo = Children(i).Data
                                Case "PRODUCTINBOUNDSEQ" : z2652.ProductInBoundSeq = Children(i).Data
                                Case "SIZEQTYINBOUND01" : z2652.SizeQtyInbound01 = Children(i).Data
                                Case "SIZEQTYINBOUND02" : z2652.SizeQtyInbound02 = Children(i).Data
                                Case "SIZEQTYINBOUND03" : z2652.SizeQtyInbound03 = Children(i).Data
                                Case "SIZEQTYINBOUND04" : z2652.SizeQtyInbound04 = Children(i).Data
                                Case "SIZEQTYINBOUND05" : z2652.SizeQtyInbound05 = Children(i).Data
                                Case "SIZEQTYINBOUND06" : z2652.SizeQtyInbound06 = Children(i).Data
                                Case "SIZEQTYINBOUND07" : z2652.SizeQtyInbound07 = Children(i).Data
                                Case "SIZEQTYINBOUND08" : z2652.SizeQtyInbound08 = Children(i).Data
                                Case "SIZEQTYINBOUND09" : z2652.SizeQtyInbound09 = Children(i).Data
                                Case "SIZEQTYINBOUND10" : z2652.SizeQtyInbound10 = Children(i).Data
                                Case "SIZEQTYINBOUND11" : z2652.SizeQtyInbound11 = Children(i).Data
                                Case "SIZEQTYINBOUND12" : z2652.SizeQtyInbound12 = Children(i).Data
                                Case "SIZEQTYINBOUND13" : z2652.SizeQtyInbound13 = Children(i).Data
                                Case "SIZEQTYINBOUND14" : z2652.SizeQtyInbound14 = Children(i).Data
                                Case "SIZEQTYINBOUND15" : z2652.SizeQtyInbound15 = Children(i).Data
                                Case "SIZEQTYINBOUND16" : z2652.SizeQtyInbound16 = Children(i).Data
                                Case "SIZEQTYINBOUND17" : z2652.SizeQtyInbound17 = Children(i).Data
                                Case "SIZEQTYINBOUND18" : z2652.SizeQtyInbound18 = Children(i).Data
                                Case "SIZEQTYINBOUND19" : z2652.SizeQtyInbound19 = Children(i).Data
                                Case "SIZEQTYINBOUND20" : z2652.SizeQtyInbound20 = Children(i).Data
                                Case "SIZEQTYINBOUND21" : z2652.SizeQtyInbound21 = Children(i).Data
                                Case "SIZEQTYINBOUND22" : z2652.SizeQtyInbound22 = Children(i).Data
                                Case "SIZEQTYINBOUND23" : z2652.SizeQtyInbound23 = Children(i).Data
                                Case "SIZEQTYINBOUND24" : z2652.SizeQtyInbound24 = Children(i).Data
                                Case "SIZEQTYINBOUND25" : z2652.SizeQtyInbound25 = Children(i).Data
                                Case "SIZEQTYINBOUND26" : z2652.SizeQtyInbound26 = Children(i).Data
                                Case "SIZEQTYINBOUND27" : z2652.SizeQtyInbound27 = Children(i).Data
                                Case "SIZEQTYINBOUND28" : z2652.SizeQtyInbound28 = Children(i).Data
                                Case "SIZEQTYINBOUND29" : z2652.SizeQtyInbound29 = Children(i).Data
                                Case "SIZEQTYINBOUND30" : z2652.SizeQtyInbound30 = Children(i).Data
                                Case "SIZEQTYOUTBOUND01" : z2652.SizeQtyOutbound01 = Children(i).Data
                                Case "SIZEQTYOUTBOUND02" : z2652.SizeQtyOutbound02 = Children(i).Data
                                Case "SIZEQTYOUTBOUND03" : z2652.SizeQtyOutbound03 = Children(i).Data
                                Case "SIZEQTYOUTBOUND04" : z2652.SizeQtyOutbound04 = Children(i).Data
                                Case "SIZEQTYOUTBOUND05" : z2652.SizeQtyOutbound05 = Children(i).Data
                                Case "SIZEQTYOUTBOUND06" : z2652.SizeQtyOutbound06 = Children(i).Data
                                Case "SIZEQTYOUTBOUND07" : z2652.SizeQtyOutbound07 = Children(i).Data
                                Case "SIZEQTYOUTBOUND08" : z2652.SizeQtyOutbound08 = Children(i).Data
                                Case "SIZEQTYOUTBOUND09" : z2652.SizeQtyOutbound09 = Children(i).Data
                                Case "SIZEQTYOUTBOUND10" : z2652.SizeQtyOutbound10 = Children(i).Data
                                Case "SIZEQTYOUTBOUND11" : z2652.SizeQtyOutbound11 = Children(i).Data
                                Case "SIZEQTYOUTBOUND12" : z2652.SizeQtyOutbound12 = Children(i).Data
                                Case "SIZEQTYOUTBOUND13" : z2652.SizeQtyOutbound13 = Children(i).Data
                                Case "SIZEQTYOUTBOUND14" : z2652.SizeQtyOutbound14 = Children(i).Data
                                Case "SIZEQTYOUTBOUND15" : z2652.SizeQtyOutbound15 = Children(i).Data
                                Case "SIZEQTYOUTBOUND16" : z2652.SizeQtyOutbound16 = Children(i).Data
                                Case "SIZEQTYOUTBOUND17" : z2652.SizeQtyOutbound17 = Children(i).Data
                                Case "SIZEQTYOUTBOUND18" : z2652.SizeQtyOutbound18 = Children(i).Data
                                Case "SIZEQTYOUTBOUND19" : z2652.SizeQtyOutbound19 = Children(i).Data
                                Case "SIZEQTYOUTBOUND20" : z2652.SizeQtyOutbound20 = Children(i).Data
                                Case "SIZEQTYOUTBOUND21" : z2652.SizeQtyOutbound21 = Children(i).Data
                                Case "SIZEQTYOUTBOUND22" : z2652.SizeQtyOutbound22 = Children(i).Data
                                Case "SIZEQTYOUTBOUND23" : z2652.SizeQtyOutbound23 = Children(i).Data
                                Case "SIZEQTYOUTBOUND24" : z2652.SizeQtyOutbound24 = Children(i).Data
                                Case "SIZEQTYOUTBOUND25" : z2652.SizeQtyOutbound25 = Children(i).Data
                                Case "SIZEQTYOUTBOUND26" : z2652.SizeQtyOutbound26 = Children(i).Data
                                Case "SIZEQTYOUTBOUND27" : z2652.SizeQtyOutbound27 = Children(i).Data
                                Case "SIZEQTYOUTBOUND28" : z2652.SizeQtyOutbound28 = Children(i).Data
                                Case "SIZEQTYOUTBOUND29" : z2652.SizeQtyOutbound29 = Children(i).Data
                                Case "SIZEQTYOUTBOUND30" : z2652.SizeQtyOutbound30 = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2652_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K2652_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z2652 As T2652_AREA, Job As String, CheckClear As Boolean, PRODUCTINBOUNDNO As String, PRODUCTINBOUNDSEQ As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K2652_MOVE = False

        Try
            If READ_PFK2652(PRODUCTINBOUNDNO, PRODUCTINBOUNDSEQ) = True Then
                z2652 = D2652
                K2652_MOVE = True
            Else
                If CheckClear = True Then z2652 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2652")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "PRODUCTINBOUNDNO" : z2652.ProductInBoundNo = Children(i).Code
                                Case "PRODUCTINBOUNDSEQ" : z2652.ProductInBoundSeq = Children(i).Code
                                Case "SIZEQTYINBOUND01" : z2652.SizeQtyInbound01 = Children(i).Code
                                Case "SIZEQTYINBOUND02" : z2652.SizeQtyInbound02 = Children(i).Code
                                Case "SIZEQTYINBOUND03" : z2652.SizeQtyInbound03 = Children(i).Code
                                Case "SIZEQTYINBOUND04" : z2652.SizeQtyInbound04 = Children(i).Code
                                Case "SIZEQTYINBOUND05" : z2652.SizeQtyInbound05 = Children(i).Code
                                Case "SIZEQTYINBOUND06" : z2652.SizeQtyInbound06 = Children(i).Code
                                Case "SIZEQTYINBOUND07" : z2652.SizeQtyInbound07 = Children(i).Code
                                Case "SIZEQTYINBOUND08" : z2652.SizeQtyInbound08 = Children(i).Code
                                Case "SIZEQTYINBOUND09" : z2652.SizeQtyInbound09 = Children(i).Code
                                Case "SIZEQTYINBOUND10" : z2652.SizeQtyInbound10 = Children(i).Code
                                Case "SIZEQTYINBOUND11" : z2652.SizeQtyInbound11 = Children(i).Code
                                Case "SIZEQTYINBOUND12" : z2652.SizeQtyInbound12 = Children(i).Code
                                Case "SIZEQTYINBOUND13" : z2652.SizeQtyInbound13 = Children(i).Code
                                Case "SIZEQTYINBOUND14" : z2652.SizeQtyInbound14 = Children(i).Code
                                Case "SIZEQTYINBOUND15" : z2652.SizeQtyInbound15 = Children(i).Code
                                Case "SIZEQTYINBOUND16" : z2652.SizeQtyInbound16 = Children(i).Code
                                Case "SIZEQTYINBOUND17" : z2652.SizeQtyInbound17 = Children(i).Code
                                Case "SIZEQTYINBOUND18" : z2652.SizeQtyInbound18 = Children(i).Code
                                Case "SIZEQTYINBOUND19" : z2652.SizeQtyInbound19 = Children(i).Code
                                Case "SIZEQTYINBOUND20" : z2652.SizeQtyInbound20 = Children(i).Code
                                Case "SIZEQTYINBOUND21" : z2652.SizeQtyInbound21 = Children(i).Code
                                Case "SIZEQTYINBOUND22" : z2652.SizeQtyInbound22 = Children(i).Code
                                Case "SIZEQTYINBOUND23" : z2652.SizeQtyInbound23 = Children(i).Code
                                Case "SIZEQTYINBOUND24" : z2652.SizeQtyInbound24 = Children(i).Code
                                Case "SIZEQTYINBOUND25" : z2652.SizeQtyInbound25 = Children(i).Code
                                Case "SIZEQTYINBOUND26" : z2652.SizeQtyInbound26 = Children(i).Code
                                Case "SIZEQTYINBOUND27" : z2652.SizeQtyInbound27 = Children(i).Code
                                Case "SIZEQTYINBOUND28" : z2652.SizeQtyInbound28 = Children(i).Code
                                Case "SIZEQTYINBOUND29" : z2652.SizeQtyInbound29 = Children(i).Code
                                Case "SIZEQTYINBOUND30" : z2652.SizeQtyInbound30 = Children(i).Code
                                Case "SIZEQTYOUTBOUND01" : z2652.SizeQtyOutbound01 = Children(i).Code
                                Case "SIZEQTYOUTBOUND02" : z2652.SizeQtyOutbound02 = Children(i).Code
                                Case "SIZEQTYOUTBOUND03" : z2652.SizeQtyOutbound03 = Children(i).Code
                                Case "SIZEQTYOUTBOUND04" : z2652.SizeQtyOutbound04 = Children(i).Code
                                Case "SIZEQTYOUTBOUND05" : z2652.SizeQtyOutbound05 = Children(i).Code
                                Case "SIZEQTYOUTBOUND06" : z2652.SizeQtyOutbound06 = Children(i).Code
                                Case "SIZEQTYOUTBOUND07" : z2652.SizeQtyOutbound07 = Children(i).Code
                                Case "SIZEQTYOUTBOUND08" : z2652.SizeQtyOutbound08 = Children(i).Code
                                Case "SIZEQTYOUTBOUND09" : z2652.SizeQtyOutbound09 = Children(i).Code
                                Case "SIZEQTYOUTBOUND10" : z2652.SizeQtyOutbound10 = Children(i).Code
                                Case "SIZEQTYOUTBOUND11" : z2652.SizeQtyOutbound11 = Children(i).Code
                                Case "SIZEQTYOUTBOUND12" : z2652.SizeQtyOutbound12 = Children(i).Code
                                Case "SIZEQTYOUTBOUND13" : z2652.SizeQtyOutbound13 = Children(i).Code
                                Case "SIZEQTYOUTBOUND14" : z2652.SizeQtyOutbound14 = Children(i).Code
                                Case "SIZEQTYOUTBOUND15" : z2652.SizeQtyOutbound15 = Children(i).Code
                                Case "SIZEQTYOUTBOUND16" : z2652.SizeQtyOutbound16 = Children(i).Code
                                Case "SIZEQTYOUTBOUND17" : z2652.SizeQtyOutbound17 = Children(i).Code
                                Case "SIZEQTYOUTBOUND18" : z2652.SizeQtyOutbound18 = Children(i).Code
                                Case "SIZEQTYOUTBOUND19" : z2652.SizeQtyOutbound19 = Children(i).Code
                                Case "SIZEQTYOUTBOUND20" : z2652.SizeQtyOutbound20 = Children(i).Code
                                Case "SIZEQTYOUTBOUND21" : z2652.SizeQtyOutbound21 = Children(i).Code
                                Case "SIZEQTYOUTBOUND22" : z2652.SizeQtyOutbound22 = Children(i).Code
                                Case "SIZEQTYOUTBOUND23" : z2652.SizeQtyOutbound23 = Children(i).Code
                                Case "SIZEQTYOUTBOUND24" : z2652.SizeQtyOutbound24 = Children(i).Code
                                Case "SIZEQTYOUTBOUND25" : z2652.SizeQtyOutbound25 = Children(i).Code
                                Case "SIZEQTYOUTBOUND26" : z2652.SizeQtyOutbound26 = Children(i).Code
                                Case "SIZEQTYOUTBOUND27" : z2652.SizeQtyOutbound27 = Children(i).Code
                                Case "SIZEQTYOUTBOUND28" : z2652.SizeQtyOutbound28 = Children(i).Code
                                Case "SIZEQTYOUTBOUND29" : z2652.SizeQtyOutbound29 = Children(i).Code
                                Case "SIZEQTYOUTBOUND30" : z2652.SizeQtyOutbound30 = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "PRODUCTINBOUNDNO" : z2652.ProductInBoundNo = Children(i).Data
                                Case "PRODUCTINBOUNDSEQ" : z2652.ProductInBoundSeq = Children(i).Data
                                Case "SIZEQTYINBOUND01" : z2652.SizeQtyInbound01 = Children(i).Data
                                Case "SIZEQTYINBOUND02" : z2652.SizeQtyInbound02 = Children(i).Data
                                Case "SIZEQTYINBOUND03" : z2652.SizeQtyInbound03 = Children(i).Data
                                Case "SIZEQTYINBOUND04" : z2652.SizeQtyInbound04 = Children(i).Data
                                Case "SIZEQTYINBOUND05" : z2652.SizeQtyInbound05 = Children(i).Data
                                Case "SIZEQTYINBOUND06" : z2652.SizeQtyInbound06 = Children(i).Data
                                Case "SIZEQTYINBOUND07" : z2652.SizeQtyInbound07 = Children(i).Data
                                Case "SIZEQTYINBOUND08" : z2652.SizeQtyInbound08 = Children(i).Data
                                Case "SIZEQTYINBOUND09" : z2652.SizeQtyInbound09 = Children(i).Data
                                Case "SIZEQTYINBOUND10" : z2652.SizeQtyInbound10 = Children(i).Data
                                Case "SIZEQTYINBOUND11" : z2652.SizeQtyInbound11 = Children(i).Data
                                Case "SIZEQTYINBOUND12" : z2652.SizeQtyInbound12 = Children(i).Data
                                Case "SIZEQTYINBOUND13" : z2652.SizeQtyInbound13 = Children(i).Data
                                Case "SIZEQTYINBOUND14" : z2652.SizeQtyInbound14 = Children(i).Data
                                Case "SIZEQTYINBOUND15" : z2652.SizeQtyInbound15 = Children(i).Data
                                Case "SIZEQTYINBOUND16" : z2652.SizeQtyInbound16 = Children(i).Data
                                Case "SIZEQTYINBOUND17" : z2652.SizeQtyInbound17 = Children(i).Data
                                Case "SIZEQTYINBOUND18" : z2652.SizeQtyInbound18 = Children(i).Data
                                Case "SIZEQTYINBOUND19" : z2652.SizeQtyInbound19 = Children(i).Data
                                Case "SIZEQTYINBOUND20" : z2652.SizeQtyInbound20 = Children(i).Data
                                Case "SIZEQTYINBOUND21" : z2652.SizeQtyInbound21 = Children(i).Data
                                Case "SIZEQTYINBOUND22" : z2652.SizeQtyInbound22 = Children(i).Data
                                Case "SIZEQTYINBOUND23" : z2652.SizeQtyInbound23 = Children(i).Data
                                Case "SIZEQTYINBOUND24" : z2652.SizeQtyInbound24 = Children(i).Data
                                Case "SIZEQTYINBOUND25" : z2652.SizeQtyInbound25 = Children(i).Data
                                Case "SIZEQTYINBOUND26" : z2652.SizeQtyInbound26 = Children(i).Data
                                Case "SIZEQTYINBOUND27" : z2652.SizeQtyInbound27 = Children(i).Data
                                Case "SIZEQTYINBOUND28" : z2652.SizeQtyInbound28 = Children(i).Data
                                Case "SIZEQTYINBOUND29" : z2652.SizeQtyInbound29 = Children(i).Data
                                Case "SIZEQTYINBOUND30" : z2652.SizeQtyInbound30 = Children(i).Data
                                Case "SIZEQTYOUTBOUND01" : z2652.SizeQtyOutbound01 = Children(i).Data
                                Case "SIZEQTYOUTBOUND02" : z2652.SizeQtyOutbound02 = Children(i).Data
                                Case "SIZEQTYOUTBOUND03" : z2652.SizeQtyOutbound03 = Children(i).Data
                                Case "SIZEQTYOUTBOUND04" : z2652.SizeQtyOutbound04 = Children(i).Data
                                Case "SIZEQTYOUTBOUND05" : z2652.SizeQtyOutbound05 = Children(i).Data
                                Case "SIZEQTYOUTBOUND06" : z2652.SizeQtyOutbound06 = Children(i).Data
                                Case "SIZEQTYOUTBOUND07" : z2652.SizeQtyOutbound07 = Children(i).Data
                                Case "SIZEQTYOUTBOUND08" : z2652.SizeQtyOutbound08 = Children(i).Data
                                Case "SIZEQTYOUTBOUND09" : z2652.SizeQtyOutbound09 = Children(i).Data
                                Case "SIZEQTYOUTBOUND10" : z2652.SizeQtyOutbound10 = Children(i).Data
                                Case "SIZEQTYOUTBOUND11" : z2652.SizeQtyOutbound11 = Children(i).Data
                                Case "SIZEQTYOUTBOUND12" : z2652.SizeQtyOutbound12 = Children(i).Data
                                Case "SIZEQTYOUTBOUND13" : z2652.SizeQtyOutbound13 = Children(i).Data
                                Case "SIZEQTYOUTBOUND14" : z2652.SizeQtyOutbound14 = Children(i).Data
                                Case "SIZEQTYOUTBOUND15" : z2652.SizeQtyOutbound15 = Children(i).Data
                                Case "SIZEQTYOUTBOUND16" : z2652.SizeQtyOutbound16 = Children(i).Data
                                Case "SIZEQTYOUTBOUND17" : z2652.SizeQtyOutbound17 = Children(i).Data
                                Case "SIZEQTYOUTBOUND18" : z2652.SizeQtyOutbound18 = Children(i).Data
                                Case "SIZEQTYOUTBOUND19" : z2652.SizeQtyOutbound19 = Children(i).Data
                                Case "SIZEQTYOUTBOUND20" : z2652.SizeQtyOutbound20 = Children(i).Data
                                Case "SIZEQTYOUTBOUND21" : z2652.SizeQtyOutbound21 = Children(i).Data
                                Case "SIZEQTYOUTBOUND22" : z2652.SizeQtyOutbound22 = Children(i).Data
                                Case "SIZEQTYOUTBOUND23" : z2652.SizeQtyOutbound23 = Children(i).Data
                                Case "SIZEQTYOUTBOUND24" : z2652.SizeQtyOutbound24 = Children(i).Data
                                Case "SIZEQTYOUTBOUND25" : z2652.SizeQtyOutbound25 = Children(i).Data
                                Case "SIZEQTYOUTBOUND26" : z2652.SizeQtyOutbound26 = Children(i).Data
                                Case "SIZEQTYOUTBOUND27" : z2652.SizeQtyOutbound27 = Children(i).Data
                                Case "SIZEQTYOUTBOUND28" : z2652.SizeQtyOutbound28 = Children(i).Data
                                Case "SIZEQTYOUTBOUND29" : z2652.SizeQtyOutbound29 = Children(i).Data
                                Case "SIZEQTYOUTBOUND30" : z2652.SizeQtyOutbound30 = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K2652_MOVE",vbCritical)
End Try
End Function 
    
End Module 
