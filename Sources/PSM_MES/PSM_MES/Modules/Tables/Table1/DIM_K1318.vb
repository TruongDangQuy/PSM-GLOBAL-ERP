'=========================================================================================================================================================
'   TABLE : (PFK1318)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K1318

Structure T1318_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	OrderNo	 AS String	'			char(9)		*
Public 	OrderNoSeq	 AS String	'			char(3)		*
Public 	ShoesCode	 AS String	'			char(6)
Public 	SizeRange	 AS String	'			char(6)
Public 	Barcode01	 AS String	'			nvarchar(50)
Public 	Barcode02	 AS String	'			nvarchar(50)
Public 	Barcode03	 AS String	'			nvarchar(50)
Public 	Barcode04	 AS String	'			nvarchar(50)
Public 	Barcode05	 AS String	'			nvarchar(50)
Public 	Barcode06	 AS String	'			nvarchar(50)
Public 	Barcode07	 AS String	'			nvarchar(50)
Public 	Barcode08	 AS String	'			nvarchar(50)
Public 	Barcode09	 AS String	'			nvarchar(50)
Public 	Barcode10	 AS String	'			nvarchar(50)
Public 	Barcode11	 AS String	'			nvarchar(50)
Public 	Barcode12	 AS String	'			nvarchar(50)
Public 	Barcode13	 AS String	'			nvarchar(50)
Public 	Barcode14	 AS String	'			nvarchar(50)
Public 	Barcode15	 AS String	'			nvarchar(50)
Public 	Barcode16	 AS String	'			nvarchar(50)
Public 	Barcode17	 AS String	'			nvarchar(50)
Public 	Barcode18	 AS String	'			nvarchar(50)
Public 	Barcode19	 AS String	'			nvarchar(50)
Public 	Barcode20	 AS String	'			nvarchar(50)
Public 	Barcode21	 AS String	'			nvarchar(50)
Public 	Barcode22	 AS String	'			nvarchar(50)
Public 	Barcode23	 AS String	'			nvarchar(50)
Public 	Barcode24	 AS String	'			nvarchar(50)
Public 	Barcode25	 AS String	'			nvarchar(50)
Public 	Barcode26	 AS String	'			nvarchar(50)
Public 	Barcode27	 AS String	'			nvarchar(50)
Public 	Barcode28	 AS String	'			nvarchar(50)
Public 	Barcode29	 AS String	'			nvarchar(50)
Public 	Barcode30	 AS String	'			nvarchar(50)
Public 	Size01	 AS Double	'			decimal
Public 	Size02	 AS Double	'			decimal
Public 	Size03	 AS Double	'			decimal
Public 	Size04	 AS Double	'			decimal
Public 	Size05	 AS Double	'			decimal
Public 	Size06	 AS Double	'			decimal
Public 	Size07	 AS Double	'			decimal
Public 	Size08	 AS Double	'			decimal
Public 	Size09	 AS Double	'			decimal
Public 	Size10	 AS Double	'			decimal
Public 	Size11	 AS Double	'			decimal
Public 	Size12	 AS Double	'			decimal
Public 	Size13	 AS Double	'			decimal
Public 	Size14	 AS Double	'			decimal
Public 	Size15	 AS Double	'			decimal
Public 	Size16	 AS Double	'			decimal
Public 	Size17	 AS Double	'			decimal
Public 	Size18	 AS Double	'			decimal
Public 	Size19	 AS Double	'			decimal
Public 	Size20	 AS Double	'			decimal
Public 	Size21	 AS Double	'			decimal
Public 	Size22	 AS Double	'			decimal
Public 	Size23	 AS Double	'			decimal
Public 	Size24	 AS Double	'			decimal
Public 	Size25	 AS Double	'			decimal
Public 	Size26	 AS Double	'			decimal
Public 	Size27	 AS Double	'			decimal
Public 	Size28	 AS Double	'			decimal
Public 	Size29	 AS Double	'			decimal
Public 	Size30	 AS Double	'			decimal
Public 	DateInsert	 AS Double	'			decimal
        Public InsertDate As String  '			char(8)
        Public InchargeInsert As String  '			char(8)
        Public Dateupdate As String  '			char(8)
        Public InchargeUpdate As String  '			char(8)
        '=========================================================================================================================================================
    End Structure

    Public D1318 As T1318_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK1318(ORDERNO As String, ORDERNOSEQ As String) As Boolean
        READ_PFK1318 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK1318 "
            SQL = SQL & " WHERE K1318_OrderNo		 = '" & OrderNo & "' "
            SQL = SQL & "   AND K1318_OrderNoSeq		 = '" & OrderNoSeq & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D1318_CLEAR() : GoTo SKIP_READ_PFK1318

            Call K1318_MOVE(rd)
            READ_PFK1318 = True

SKIP_READ_PFK1318:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK1318", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' READ BARCODE
    '=========================================================================================================================================================
    Public Function READ_PFK1318_BARCODE(BARCODE As String) As Boolean

        READ_PFK1318_BARCODE = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK1318 "

            SQL = SQL & " WHERE K1318_Barcode01		= '" & BARCODE & "' "
            SQL = SQL & "   OR K1318_Barcode02      = '" & BARCODE & "' "
            SQL = SQL & "   OR K1318_Barcode03      = '" & BARCODE & "' "
            SQL = SQL & "   OR K1318_Barcode04      = '" & BARCODE & "' "
            SQL = SQL & "   OR K1318_Barcode05      = '" & BARCODE & "' "
            SQL = SQL & "   OR K1318_Barcode06      = '" & BARCODE & "' "
            SQL = SQL & "   OR K1318_Barcode07      = '" & BARCODE & "' "
            SQL = SQL & "   OR K1318_Barcode08      = '" & BARCODE & "' "
            SQL = SQL & "   OR K1318_Barcode09      = '" & BARCODE & "' "
            SQL = SQL & "   OR K1318_Barcode10      = '" & BARCODE & "' "
            SQL = SQL & "   OR K1318_Barcode11      = '" & BARCODE & "' "
            SQL = SQL & "   OR K1318_Barcode12      = '" & BARCODE & "' "
            SQL = SQL & "   OR K1318_Barcode13      = '" & BARCODE & "' "
            SQL = SQL & "   OR K1318_Barcode14      = '" & BARCODE & "' "
            SQL = SQL & "   OR K1318_Barcode15      = '" & BARCODE & "' "
            SQL = SQL & "   OR K1318_Barcode16      = '" & BARCODE & "' "
            SQL = SQL & "   OR K1318_Barcode17      = '" & BARCODE & "' "
            SQL = SQL & "   OR K1318_Barcode18      = '" & BARCODE & "' "
            SQL = SQL & "   OR K1318_Barcode19      = '" & BARCODE & "' "
            SQL = SQL & "   OR K1318_Barcode20      = '" & BARCODE & "' "
            SQL = SQL & "   OR K1318_Barcode21      = '" & BARCODE & "' "
            SQL = SQL & "   OR K1318_Barcode22      = '" & BARCODE & "' "
            SQL = SQL & "   OR K1318_Barcode23      = '" & BARCODE & "' "
            SQL = SQL & "   OR K1318_Barcode24      = '" & BARCODE & "' "
            SQL = SQL & "   OR K1318_Barcode25      = '" & BARCODE & "' "
            SQL = SQL & "   OR K1318_Barcode26      = '" & BARCODE & "' "
            SQL = SQL & "   OR K1318_Barcode27      = '" & BARCODE & "' "
            SQL = SQL & "   OR K1318_Barcode28      = '" & BARCODE & "' "
            SQL = SQL & "   OR K1318_Barcode29      = '" & BARCODE & "' "
            SQL = SQL & "   OR K1318_Barcode30      = '" & BARCODE & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D1318_CLEAR() : GoTo SKIP_READ_PFK1318_BARCODE

            Call K1318_MOVE(rd)

            READ_PFK1318_BARCODE = True

SKIP_READ_PFK1318_BARCODE:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK1318", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK1318(ORDERNO As String, ORDERNOSEQ As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK1318 "
            SQL = SQL & " WHERE K1318_OrderNo		 = '" & OrderNo & "' "
            SQL = SQL & "   AND K1318_OrderNoSeq		 = '" & OrderNoSeq & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK1318", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK1318(z1318 As T1318_AREA) As Boolean
        WRITE_PFK1318 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z1318)

            SQL = " INSERT INTO PFK1318 "
            SQL = SQL & " ( "
            SQL = SQL & " K1318_OrderNo,"
            SQL = SQL & " K1318_OrderNoSeq,"
            SQL = SQL & " K1318_ShoesCode,"
            SQL = SQL & " K1318_SizeRange,"
            SQL = SQL & " K1318_Barcode01,"
            SQL = SQL & " K1318_Barcode02,"
            SQL = SQL & " K1318_Barcode03,"
            SQL = SQL & " K1318_Barcode04,"
            SQL = SQL & " K1318_Barcode05,"
            SQL = SQL & " K1318_Barcode06,"
            SQL = SQL & " K1318_Barcode07,"
            SQL = SQL & " K1318_Barcode08,"
            SQL = SQL & " K1318_Barcode09,"
            SQL = SQL & " K1318_Barcode10,"
            SQL = SQL & " K1318_Barcode11,"
            SQL = SQL & " K1318_Barcode12,"
            SQL = SQL & " K1318_Barcode13,"
            SQL = SQL & " K1318_Barcode14,"
            SQL = SQL & " K1318_Barcode15,"
            SQL = SQL & " K1318_Barcode16,"
            SQL = SQL & " K1318_Barcode17,"
            SQL = SQL & " K1318_Barcode18,"
            SQL = SQL & " K1318_Barcode19,"
            SQL = SQL & " K1318_Barcode20,"
            SQL = SQL & " K1318_Barcode21,"
            SQL = SQL & " K1318_Barcode22,"
            SQL = SQL & " K1318_Barcode23,"
            SQL = SQL & " K1318_Barcode24,"
            SQL = SQL & " K1318_Barcode25,"
            SQL = SQL & " K1318_Barcode26,"
            SQL = SQL & " K1318_Barcode27,"
            SQL = SQL & " K1318_Barcode28,"
            SQL = SQL & " K1318_Barcode29,"
            SQL = SQL & " K1318_Barcode30,"
            SQL = SQL & " K1318_Size01,"
            SQL = SQL & " K1318_Size02,"
            SQL = SQL & " K1318_Size03,"
            SQL = SQL & " K1318_Size04,"
            SQL = SQL & " K1318_Size05,"
            SQL = SQL & " K1318_Size06,"
            SQL = SQL & " K1318_Size07,"
            SQL = SQL & " K1318_Size08,"
            SQL = SQL & " K1318_Size09,"
            SQL = SQL & " K1318_Size10,"
            SQL = SQL & " K1318_Size11,"
            SQL = SQL & " K1318_Size12,"
            SQL = SQL & " K1318_Size13,"
            SQL = SQL & " K1318_Size14,"
            SQL = SQL & " K1318_Size15,"
            SQL = SQL & " K1318_Size16,"
            SQL = SQL & " K1318_Size17,"
            SQL = SQL & " K1318_Size18,"
            SQL = SQL & " K1318_Size19,"
            SQL = SQL & " K1318_Size20,"
            SQL = SQL & " K1318_Size21,"
            SQL = SQL & " K1318_Size22,"
            SQL = SQL & " K1318_Size23,"
            SQL = SQL & " K1318_Size24,"
            SQL = SQL & " K1318_Size25,"
            SQL = SQL & " K1318_Size26,"
            SQL = SQL & " K1318_Size27,"
            SQL = SQL & " K1318_Size28,"
            SQL = SQL & " K1318_Size29,"
            SQL = SQL & " K1318_Size30,"
            SQL = SQL & " K1318_DateInsert,"
            SQL = SQL & " K1318_InsertDate,"
            SQL = SQL & " K1318_InchargeInsert,"
            SQL = SQL & " K1318_Dateupdate,"
            SQL = SQL & " k1318_InchargeUpdate "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z1318.OrderNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1318.OrderNoSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1318.ShoesCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1318.SizeRange) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1318.Barcode01) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1318.Barcode02) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1318.Barcode03) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1318.Barcode04) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1318.Barcode05) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1318.Barcode06) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1318.Barcode07) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1318.Barcode08) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1318.Barcode09) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1318.Barcode10) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1318.Barcode11) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1318.Barcode12) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1318.Barcode13) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1318.Barcode14) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1318.Barcode15) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1318.Barcode16) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1318.Barcode17) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1318.Barcode18) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1318.Barcode19) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1318.Barcode20) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1318.Barcode21) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1318.Barcode22) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1318.Barcode23) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1318.Barcode24) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1318.Barcode25) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1318.Barcode26) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1318.Barcode27) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1318.Barcode28) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1318.Barcode29) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1318.Barcode30) & "', "
            SQL = SQL & "   " & FormatSQL(z1318.Size01) & ", "
            SQL = SQL & "   " & FormatSQL(z1318.Size02) & ", "
            SQL = SQL & "   " & FormatSQL(z1318.Size03) & ", "
            SQL = SQL & "   " & FormatSQL(z1318.Size04) & ", "
            SQL = SQL & "   " & FormatSQL(z1318.Size05) & ", "
            SQL = SQL & "   " & FormatSQL(z1318.Size06) & ", "
            SQL = SQL & "   " & FormatSQL(z1318.Size07) & ", "
            SQL = SQL & "   " & FormatSQL(z1318.Size08) & ", "
            SQL = SQL & "   " & FormatSQL(z1318.Size09) & ", "
            SQL = SQL & "   " & FormatSQL(z1318.Size10) & ", "
            SQL = SQL & "   " & FormatSQL(z1318.Size11) & ", "
            SQL = SQL & "   " & FormatSQL(z1318.Size12) & ", "
            SQL = SQL & "   " & FormatSQL(z1318.Size13) & ", "
            SQL = SQL & "   " & FormatSQL(z1318.Size14) & ", "
            SQL = SQL & "   " & FormatSQL(z1318.Size15) & ", "
            SQL = SQL & "   " & FormatSQL(z1318.Size16) & ", "
            SQL = SQL & "   " & FormatSQL(z1318.Size17) & ", "
            SQL = SQL & "   " & FormatSQL(z1318.Size18) & ", "
            SQL = SQL & "   " & FormatSQL(z1318.Size19) & ", "
            SQL = SQL & "   " & FormatSQL(z1318.Size20) & ", "
            SQL = SQL & "   " & FormatSQL(z1318.Size21) & ", "
            SQL = SQL & "   " & FormatSQL(z1318.Size22) & ", "
            SQL = SQL & "   " & FormatSQL(z1318.Size23) & ", "
            SQL = SQL & "   " & FormatSQL(z1318.Size24) & ", "
            SQL = SQL & "   " & FormatSQL(z1318.Size25) & ", "
            SQL = SQL & "   " & FormatSQL(z1318.Size26) & ", "
            SQL = SQL & "   " & FormatSQL(z1318.Size27) & ", "
            SQL = SQL & "   " & FormatSQL(z1318.Size28) & ", "
            SQL = SQL & "   " & FormatSQL(z1318.Size29) & ", "
            SQL = SQL & "   " & FormatSQL(z1318.Size30) & ", "
            SQL = SQL & "   " & FormatSQL(z1318.DateInsert) & ", "
            SQL = SQL & "  N'" & FormatSQL(z1318.InsertDate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1318.InchargeInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1318.Dateupdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1318.InchargeUpdate) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK1318 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK1318", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK1318(z1318 As T1318_AREA) As Boolean
        REWRITE_PFK1318 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z1318)

            SQL = " UPDATE PFK1318 SET "
            SQL = SQL & "    K1318_ShoesCode      = N'" & FormatSQL(z1318.ShoesCode) & "', "
            SQL = SQL & "    K1318_SizeRange      = N'" & FormatSQL(z1318.SizeRange) & "', "
            SQL = SQL & "    K1318_Barcode01      = N'" & FormatSQL(z1318.Barcode01) & "', "
            SQL = SQL & "    K1318_Barcode02      = N'" & FormatSQL(z1318.Barcode02) & "', "
            SQL = SQL & "    K1318_Barcode03      = N'" & FormatSQL(z1318.Barcode03) & "', "
            SQL = SQL & "    K1318_Barcode04      = N'" & FormatSQL(z1318.Barcode04) & "', "
            SQL = SQL & "    K1318_Barcode05      = N'" & FormatSQL(z1318.Barcode05) & "', "
            SQL = SQL & "    K1318_Barcode06      = N'" & FormatSQL(z1318.Barcode06) & "', "
            SQL = SQL & "    K1318_Barcode07      = N'" & FormatSQL(z1318.Barcode07) & "', "
            SQL = SQL & "    K1318_Barcode08      = N'" & FormatSQL(z1318.Barcode08) & "', "
            SQL = SQL & "    K1318_Barcode09      = N'" & FormatSQL(z1318.Barcode09) & "', "
            SQL = SQL & "    K1318_Barcode10      = N'" & FormatSQL(z1318.Barcode10) & "', "
            SQL = SQL & "    K1318_Barcode11      = N'" & FormatSQL(z1318.Barcode11) & "', "
            SQL = SQL & "    K1318_Barcode12      = N'" & FormatSQL(z1318.Barcode12) & "', "
            SQL = SQL & "    K1318_Barcode13      = N'" & FormatSQL(z1318.Barcode13) & "', "
            SQL = SQL & "    K1318_Barcode14      = N'" & FormatSQL(z1318.Barcode14) & "', "
            SQL = SQL & "    K1318_Barcode15      = N'" & FormatSQL(z1318.Barcode15) & "', "
            SQL = SQL & "    K1318_Barcode16      = N'" & FormatSQL(z1318.Barcode16) & "', "
            SQL = SQL & "    K1318_Barcode17      = N'" & FormatSQL(z1318.Barcode17) & "', "
            SQL = SQL & "    K1318_Barcode18      = N'" & FormatSQL(z1318.Barcode18) & "', "
            SQL = SQL & "    K1318_Barcode19      = N'" & FormatSQL(z1318.Barcode19) & "', "
            SQL = SQL & "    K1318_Barcode20      = N'" & FormatSQL(z1318.Barcode20) & "', "
            SQL = SQL & "    K1318_Barcode21      = N'" & FormatSQL(z1318.Barcode21) & "', "
            SQL = SQL & "    K1318_Barcode22      = N'" & FormatSQL(z1318.Barcode22) & "', "
            SQL = SQL & "    K1318_Barcode23      = N'" & FormatSQL(z1318.Barcode23) & "', "
            SQL = SQL & "    K1318_Barcode24      = N'" & FormatSQL(z1318.Barcode24) & "', "
            SQL = SQL & "    K1318_Barcode25      = N'" & FormatSQL(z1318.Barcode25) & "', "
            SQL = SQL & "    K1318_Barcode26      = N'" & FormatSQL(z1318.Barcode26) & "', "
            SQL = SQL & "    K1318_Barcode27      = N'" & FormatSQL(z1318.Barcode27) & "', "
            SQL = SQL & "    K1318_Barcode28      = N'" & FormatSQL(z1318.Barcode28) & "', "
            SQL = SQL & "    K1318_Barcode29      = N'" & FormatSQL(z1318.Barcode29) & "', "
            SQL = SQL & "    K1318_Barcode30      = N'" & FormatSQL(z1318.Barcode30) & "', "
            SQL = SQL & "    K1318_Size01      =  " & FormatSQL(z1318.Size01) & ", "
            SQL = SQL & "    K1318_Size02      =  " & FormatSQL(z1318.Size02) & ", "
            SQL = SQL & "    K1318_Size03      =  " & FormatSQL(z1318.Size03) & ", "
            SQL = SQL & "    K1318_Size04      =  " & FormatSQL(z1318.Size04) & ", "
            SQL = SQL & "    K1318_Size05      =  " & FormatSQL(z1318.Size05) & ", "
            SQL = SQL & "    K1318_Size06      =  " & FormatSQL(z1318.Size06) & ", "
            SQL = SQL & "    K1318_Size07      =  " & FormatSQL(z1318.Size07) & ", "
            SQL = SQL & "    K1318_Size08      =  " & FormatSQL(z1318.Size08) & ", "
            SQL = SQL & "    K1318_Size09      =  " & FormatSQL(z1318.Size09) & ", "
            SQL = SQL & "    K1318_Size10      =  " & FormatSQL(z1318.Size10) & ", "
            SQL = SQL & "    K1318_Size11      =  " & FormatSQL(z1318.Size11) & ", "
            SQL = SQL & "    K1318_Size12      =  " & FormatSQL(z1318.Size12) & ", "
            SQL = SQL & "    K1318_Size13      =  " & FormatSQL(z1318.Size13) & ", "
            SQL = SQL & "    K1318_Size14      =  " & FormatSQL(z1318.Size14) & ", "
            SQL = SQL & "    K1318_Size15      =  " & FormatSQL(z1318.Size15) & ", "
            SQL = SQL & "    K1318_Size16      =  " & FormatSQL(z1318.Size16) & ", "
            SQL = SQL & "    K1318_Size17      =  " & FormatSQL(z1318.Size17) & ", "
            SQL = SQL & "    K1318_Size18      =  " & FormatSQL(z1318.Size18) & ", "
            SQL = SQL & "    K1318_Size19      =  " & FormatSQL(z1318.Size19) & ", "
            SQL = SQL & "    K1318_Size20      =  " & FormatSQL(z1318.Size20) & ", "
            SQL = SQL & "    K1318_Size21      =  " & FormatSQL(z1318.Size21) & ", "
            SQL = SQL & "    K1318_Size22      =  " & FormatSQL(z1318.Size22) & ", "
            SQL = SQL & "    K1318_Size23      =  " & FormatSQL(z1318.Size23) & ", "
            SQL = SQL & "    K1318_Size24      =  " & FormatSQL(z1318.Size24) & ", "
            SQL = SQL & "    K1318_Size25      =  " & FormatSQL(z1318.Size25) & ", "
            SQL = SQL & "    K1318_Size26      =  " & FormatSQL(z1318.Size26) & ", "
            SQL = SQL & "    K1318_Size27      =  " & FormatSQL(z1318.Size27) & ", "
            SQL = SQL & "    K1318_Size28      =  " & FormatSQL(z1318.Size28) & ", "
            SQL = SQL & "    K1318_Size29      =  " & FormatSQL(z1318.Size29) & ", "
            SQL = SQL & "    K1318_Size30      =  " & FormatSQL(z1318.Size30) & ", "
            SQL = SQL & "    K1318_DateInsert      =  " & FormatSQL(z1318.DateInsert) & ", "
            SQL = SQL & "    K1318_InsertDate      = N'" & FormatSQL(z1318.InsertDate) & "', "
            SQL = SQL & "    K1318_InchargeInsert      = N'" & FormatSQL(z1318.InchargeInsert) & "', "
            SQL = SQL & "    K1318_Dateupdate      = N'" & FormatSQL(z1318.Dateupdate) & "', "
            SQL = SQL & "    k1318_InchargeUpdate      = N'" & FormatSQL(z1318.InchargeUpdate) & "'  "
            SQL = SQL & " WHERE K1318_OrderNo		 = '" & z1318.OrderNo & "' "
            SQL = SQL & "   AND K1318_OrderNoSeq		 = '" & z1318.OrderNoSeq & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK1318 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK1318", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK1318(z1318 As T1318_AREA) As Boolean
        DELETE_PFK1318 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK1318 "
            SQL = SQL & " WHERE K1318_OrderNo		 = '" & z1318.OrderNo & "' "
            SQL = SQL & "   AND K1318_OrderNoSeq		 = '" & z1318.OrderNoSeq & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK1318 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK1318", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D1318_CLEAR()
        Try

            D1318.OrderNo = ""
            D1318.OrderNoSeq = ""
            D1318.ShoesCode = ""
            D1318.SizeRange = ""
            D1318.Barcode01 = ""
            D1318.Barcode02 = ""
            D1318.Barcode03 = ""
            D1318.Barcode04 = ""
            D1318.Barcode05 = ""
            D1318.Barcode06 = ""
            D1318.Barcode07 = ""
            D1318.Barcode08 = ""
            D1318.Barcode09 = ""
            D1318.Barcode10 = ""
            D1318.Barcode11 = ""
            D1318.Barcode12 = ""
            D1318.Barcode13 = ""
            D1318.Barcode14 = ""
            D1318.Barcode15 = ""
            D1318.Barcode16 = ""
            D1318.Barcode17 = ""
            D1318.Barcode18 = ""
            D1318.Barcode19 = ""
            D1318.Barcode20 = ""
            D1318.Barcode21 = ""
            D1318.Barcode22 = ""
            D1318.Barcode23 = ""
            D1318.Barcode24 = ""
            D1318.Barcode25 = ""
            D1318.Barcode26 = ""
            D1318.Barcode27 = ""
            D1318.Barcode28 = ""
            D1318.Barcode29 = ""
            D1318.Barcode30 = ""
            D1318.Size01 = 0
            D1318.Size02 = 0
            D1318.Size03 = 0
            D1318.Size04 = 0
            D1318.Size05 = 0
            D1318.Size06 = 0
            D1318.Size07 = 0
            D1318.Size08 = 0
            D1318.Size09 = 0
            D1318.Size10 = 0
            D1318.Size11 = 0
            D1318.Size12 = 0
            D1318.Size13 = 0
            D1318.Size14 = 0
            D1318.Size15 = 0
            D1318.Size16 = 0
            D1318.Size17 = 0
            D1318.Size18 = 0
            D1318.Size19 = 0
            D1318.Size20 = 0
            D1318.Size21 = 0
            D1318.Size22 = 0
            D1318.Size23 = 0
            D1318.Size24 = 0
            D1318.Size25 = 0
            D1318.Size26 = 0
            D1318.Size27 = 0
            D1318.Size28 = 0
            D1318.Size29 = 0
            D1318.Size30 = 0
            D1318.DateInsert = 0
            D1318.InsertDate = ""
            D1318.InchargeInsert = ""
            D1318.Dateupdate = ""
            D1318.InchargeUpdate = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D1318_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x1318 As T1318_AREA)
        Try

            x1318.OrderNo = trim$(x1318.OrderNo)
            x1318.OrderNoSeq = trim$(x1318.OrderNoSeq)
            x1318.ShoesCode = trim$(x1318.ShoesCode)
            x1318.SizeRange = trim$(x1318.SizeRange)
            x1318.Barcode01 = trim$(x1318.Barcode01)
            x1318.Barcode02 = trim$(x1318.Barcode02)
            x1318.Barcode03 = trim$(x1318.Barcode03)
            x1318.Barcode04 = trim$(x1318.Barcode04)
            x1318.Barcode05 = trim$(x1318.Barcode05)
            x1318.Barcode06 = trim$(x1318.Barcode06)
            x1318.Barcode07 = trim$(x1318.Barcode07)
            x1318.Barcode08 = trim$(x1318.Barcode08)
            x1318.Barcode09 = trim$(x1318.Barcode09)
            x1318.Barcode10 = trim$(x1318.Barcode10)
            x1318.Barcode11 = trim$(x1318.Barcode11)
            x1318.Barcode12 = trim$(x1318.Barcode12)
            x1318.Barcode13 = trim$(x1318.Barcode13)
            x1318.Barcode14 = trim$(x1318.Barcode14)
            x1318.Barcode15 = trim$(x1318.Barcode15)
            x1318.Barcode16 = trim$(x1318.Barcode16)
            x1318.Barcode17 = trim$(x1318.Barcode17)
            x1318.Barcode18 = trim$(x1318.Barcode18)
            x1318.Barcode19 = trim$(x1318.Barcode19)
            x1318.Barcode20 = trim$(x1318.Barcode20)
            x1318.Barcode21 = trim$(x1318.Barcode21)
            x1318.Barcode22 = trim$(x1318.Barcode22)
            x1318.Barcode23 = trim$(x1318.Barcode23)
            x1318.Barcode24 = trim$(x1318.Barcode24)
            x1318.Barcode25 = trim$(x1318.Barcode25)
            x1318.Barcode26 = trim$(x1318.Barcode26)
            x1318.Barcode27 = trim$(x1318.Barcode27)
            x1318.Barcode28 = trim$(x1318.Barcode28)
            x1318.Barcode29 = trim$(x1318.Barcode29)
            x1318.Barcode30 = trim$(x1318.Barcode30)
            x1318.Size01 = trim$(x1318.Size01)
            x1318.Size02 = trim$(x1318.Size02)
            x1318.Size03 = trim$(x1318.Size03)
            x1318.Size04 = trim$(x1318.Size04)
            x1318.Size05 = trim$(x1318.Size05)
            x1318.Size06 = trim$(x1318.Size06)
            x1318.Size07 = trim$(x1318.Size07)
            x1318.Size08 = trim$(x1318.Size08)
            x1318.Size09 = trim$(x1318.Size09)
            x1318.Size10 = trim$(x1318.Size10)
            x1318.Size11 = trim$(x1318.Size11)
            x1318.Size12 = trim$(x1318.Size12)
            x1318.Size13 = trim$(x1318.Size13)
            x1318.Size14 = trim$(x1318.Size14)
            x1318.Size15 = trim$(x1318.Size15)
            x1318.Size16 = trim$(x1318.Size16)
            x1318.Size17 = trim$(x1318.Size17)
            x1318.Size18 = trim$(x1318.Size18)
            x1318.Size19 = trim$(x1318.Size19)
            x1318.Size20 = trim$(x1318.Size20)
            x1318.Size21 = trim$(x1318.Size21)
            x1318.Size22 = trim$(x1318.Size22)
            x1318.Size23 = trim$(x1318.Size23)
            x1318.Size24 = trim$(x1318.Size24)
            x1318.Size25 = trim$(x1318.Size25)
            x1318.Size26 = trim$(x1318.Size26)
            x1318.Size27 = trim$(x1318.Size27)
            x1318.Size28 = trim$(x1318.Size28)
            x1318.Size29 = trim$(x1318.Size29)
            x1318.Size30 = trim$(x1318.Size30)
            x1318.DateInsert = trim$(x1318.DateInsert)
            x1318.InsertDate = trim$(x1318.InsertDate)
            x1318.InchargeInsert = trim$(x1318.InchargeInsert)
            x1318.Dateupdate = trim$(x1318.Dateupdate)
            x1318.InchargeUpdate = trim$(x1318.InchargeUpdate)

            If trim$(x1318.OrderNo) = "" Then x1318.OrderNo = Space(1)
            If trim$(x1318.OrderNoSeq) = "" Then x1318.OrderNoSeq = Space(1)
            If trim$(x1318.ShoesCode) = "" Then x1318.ShoesCode = Space(1)
            If trim$(x1318.SizeRange) = "" Then x1318.SizeRange = Space(1)
            If trim$(x1318.Barcode01) = "" Then x1318.Barcode01 = Space(1)
            If trim$(x1318.Barcode02) = "" Then x1318.Barcode02 = Space(1)
            If trim$(x1318.Barcode03) = "" Then x1318.Barcode03 = Space(1)
            If trim$(x1318.Barcode04) = "" Then x1318.Barcode04 = Space(1)
            If trim$(x1318.Barcode05) = "" Then x1318.Barcode05 = Space(1)
            If trim$(x1318.Barcode06) = "" Then x1318.Barcode06 = Space(1)
            If trim$(x1318.Barcode07) = "" Then x1318.Barcode07 = Space(1)
            If trim$(x1318.Barcode08) = "" Then x1318.Barcode08 = Space(1)
            If trim$(x1318.Barcode09) = "" Then x1318.Barcode09 = Space(1)
            If trim$(x1318.Barcode10) = "" Then x1318.Barcode10 = Space(1)
            If trim$(x1318.Barcode11) = "" Then x1318.Barcode11 = Space(1)
            If trim$(x1318.Barcode12) = "" Then x1318.Barcode12 = Space(1)
            If trim$(x1318.Barcode13) = "" Then x1318.Barcode13 = Space(1)
            If trim$(x1318.Barcode14) = "" Then x1318.Barcode14 = Space(1)
            If trim$(x1318.Barcode15) = "" Then x1318.Barcode15 = Space(1)
            If trim$(x1318.Barcode16) = "" Then x1318.Barcode16 = Space(1)
            If trim$(x1318.Barcode17) = "" Then x1318.Barcode17 = Space(1)
            If trim$(x1318.Barcode18) = "" Then x1318.Barcode18 = Space(1)
            If trim$(x1318.Barcode19) = "" Then x1318.Barcode19 = Space(1)
            If trim$(x1318.Barcode20) = "" Then x1318.Barcode20 = Space(1)
            If trim$(x1318.Barcode21) = "" Then x1318.Barcode21 = Space(1)
            If trim$(x1318.Barcode22) = "" Then x1318.Barcode22 = Space(1)
            If trim$(x1318.Barcode23) = "" Then x1318.Barcode23 = Space(1)
            If trim$(x1318.Barcode24) = "" Then x1318.Barcode24 = Space(1)
            If trim$(x1318.Barcode25) = "" Then x1318.Barcode25 = Space(1)
            If trim$(x1318.Barcode26) = "" Then x1318.Barcode26 = Space(1)
            If trim$(x1318.Barcode27) = "" Then x1318.Barcode27 = Space(1)
            If trim$(x1318.Barcode28) = "" Then x1318.Barcode28 = Space(1)
            If trim$(x1318.Barcode29) = "" Then x1318.Barcode29 = Space(1)
            If trim$(x1318.Barcode30) = "" Then x1318.Barcode30 = Space(1)
            If trim$(x1318.Size01) = "" Then x1318.Size01 = 0
            If trim$(x1318.Size02) = "" Then x1318.Size02 = 0
            If trim$(x1318.Size03) = "" Then x1318.Size03 = 0
            If trim$(x1318.Size04) = "" Then x1318.Size04 = 0
            If trim$(x1318.Size05) = "" Then x1318.Size05 = 0
            If trim$(x1318.Size06) = "" Then x1318.Size06 = 0
            If trim$(x1318.Size07) = "" Then x1318.Size07 = 0
            If trim$(x1318.Size08) = "" Then x1318.Size08 = 0
            If trim$(x1318.Size09) = "" Then x1318.Size09 = 0
            If trim$(x1318.Size10) = "" Then x1318.Size10 = 0
            If trim$(x1318.Size11) = "" Then x1318.Size11 = 0
            If trim$(x1318.Size12) = "" Then x1318.Size12 = 0
            If trim$(x1318.Size13) = "" Then x1318.Size13 = 0
            If trim$(x1318.Size14) = "" Then x1318.Size14 = 0
            If trim$(x1318.Size15) = "" Then x1318.Size15 = 0
            If trim$(x1318.Size16) = "" Then x1318.Size16 = 0
            If trim$(x1318.Size17) = "" Then x1318.Size17 = 0
            If trim$(x1318.Size18) = "" Then x1318.Size18 = 0
            If trim$(x1318.Size19) = "" Then x1318.Size19 = 0
            If trim$(x1318.Size20) = "" Then x1318.Size20 = 0
            If trim$(x1318.Size21) = "" Then x1318.Size21 = 0
            If trim$(x1318.Size22) = "" Then x1318.Size22 = 0
            If trim$(x1318.Size23) = "" Then x1318.Size23 = 0
            If trim$(x1318.Size24) = "" Then x1318.Size24 = 0
            If trim$(x1318.Size25) = "" Then x1318.Size25 = 0
            If trim$(x1318.Size26) = "" Then x1318.Size26 = 0
            If trim$(x1318.Size27) = "" Then x1318.Size27 = 0
            If trim$(x1318.Size28) = "" Then x1318.Size28 = 0
            If trim$(x1318.Size29) = "" Then x1318.Size29 = 0
            If trim$(x1318.Size30) = "" Then x1318.Size30 = 0
            If trim$(x1318.DateInsert) = "" Then x1318.DateInsert = 0
            If trim$(x1318.InsertDate) = "" Then x1318.InsertDate = Space(1)
            If trim$(x1318.InchargeInsert) = "" Then x1318.InchargeInsert = Space(1)
            If trim$(x1318.Dateupdate) = "" Then x1318.Dateupdate = Space(1)
            If trim$(x1318.InchargeUpdate) = "" Then x1318.InchargeUpdate = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K1318_MOVE(rs1318 As SqlClient.SqlDataReader)
        Try

            Call D1318_CLEAR()

            If IsdbNull(rs1318!K1318_OrderNo) = False Then D1318.OrderNo = Trim$(rs1318!K1318_OrderNo)
            If IsdbNull(rs1318!K1318_OrderNoSeq) = False Then D1318.OrderNoSeq = Trim$(rs1318!K1318_OrderNoSeq)
            If IsdbNull(rs1318!K1318_ShoesCode) = False Then D1318.ShoesCode = Trim$(rs1318!K1318_ShoesCode)
            If IsdbNull(rs1318!K1318_SizeRange) = False Then D1318.SizeRange = Trim$(rs1318!K1318_SizeRange)
            If IsdbNull(rs1318!K1318_Barcode01) = False Then D1318.Barcode01 = Trim$(rs1318!K1318_Barcode01)
            If IsdbNull(rs1318!K1318_Barcode02) = False Then D1318.Barcode02 = Trim$(rs1318!K1318_Barcode02)
            If IsdbNull(rs1318!K1318_Barcode03) = False Then D1318.Barcode03 = Trim$(rs1318!K1318_Barcode03)
            If IsdbNull(rs1318!K1318_Barcode04) = False Then D1318.Barcode04 = Trim$(rs1318!K1318_Barcode04)
            If IsdbNull(rs1318!K1318_Barcode05) = False Then D1318.Barcode05 = Trim$(rs1318!K1318_Barcode05)
            If IsdbNull(rs1318!K1318_Barcode06) = False Then D1318.Barcode06 = Trim$(rs1318!K1318_Barcode06)
            If IsdbNull(rs1318!K1318_Barcode07) = False Then D1318.Barcode07 = Trim$(rs1318!K1318_Barcode07)
            If IsdbNull(rs1318!K1318_Barcode08) = False Then D1318.Barcode08 = Trim$(rs1318!K1318_Barcode08)
            If IsdbNull(rs1318!K1318_Barcode09) = False Then D1318.Barcode09 = Trim$(rs1318!K1318_Barcode09)
            If IsdbNull(rs1318!K1318_Barcode10) = False Then D1318.Barcode10 = Trim$(rs1318!K1318_Barcode10)
            If IsdbNull(rs1318!K1318_Barcode11) = False Then D1318.Barcode11 = Trim$(rs1318!K1318_Barcode11)
            If IsdbNull(rs1318!K1318_Barcode12) = False Then D1318.Barcode12 = Trim$(rs1318!K1318_Barcode12)
            If IsdbNull(rs1318!K1318_Barcode13) = False Then D1318.Barcode13 = Trim$(rs1318!K1318_Barcode13)
            If IsdbNull(rs1318!K1318_Barcode14) = False Then D1318.Barcode14 = Trim$(rs1318!K1318_Barcode14)
            If IsdbNull(rs1318!K1318_Barcode15) = False Then D1318.Barcode15 = Trim$(rs1318!K1318_Barcode15)
            If IsdbNull(rs1318!K1318_Barcode16) = False Then D1318.Barcode16 = Trim$(rs1318!K1318_Barcode16)
            If IsdbNull(rs1318!K1318_Barcode17) = False Then D1318.Barcode17 = Trim$(rs1318!K1318_Barcode17)
            If IsdbNull(rs1318!K1318_Barcode18) = False Then D1318.Barcode18 = Trim$(rs1318!K1318_Barcode18)
            If IsdbNull(rs1318!K1318_Barcode19) = False Then D1318.Barcode19 = Trim$(rs1318!K1318_Barcode19)
            If IsdbNull(rs1318!K1318_Barcode20) = False Then D1318.Barcode20 = Trim$(rs1318!K1318_Barcode20)
            If IsdbNull(rs1318!K1318_Barcode21) = False Then D1318.Barcode21 = Trim$(rs1318!K1318_Barcode21)
            If IsdbNull(rs1318!K1318_Barcode22) = False Then D1318.Barcode22 = Trim$(rs1318!K1318_Barcode22)
            If IsdbNull(rs1318!K1318_Barcode23) = False Then D1318.Barcode23 = Trim$(rs1318!K1318_Barcode23)
            If IsdbNull(rs1318!K1318_Barcode24) = False Then D1318.Barcode24 = Trim$(rs1318!K1318_Barcode24)
            If IsdbNull(rs1318!K1318_Barcode25) = False Then D1318.Barcode25 = Trim$(rs1318!K1318_Barcode25)
            If IsdbNull(rs1318!K1318_Barcode26) = False Then D1318.Barcode26 = Trim$(rs1318!K1318_Barcode26)
            If IsdbNull(rs1318!K1318_Barcode27) = False Then D1318.Barcode27 = Trim$(rs1318!K1318_Barcode27)
            If IsdbNull(rs1318!K1318_Barcode28) = False Then D1318.Barcode28 = Trim$(rs1318!K1318_Barcode28)
            If IsdbNull(rs1318!K1318_Barcode29) = False Then D1318.Barcode29 = Trim$(rs1318!K1318_Barcode29)
            If IsdbNull(rs1318!K1318_Barcode30) = False Then D1318.Barcode30 = Trim$(rs1318!K1318_Barcode30)
            If IsdbNull(rs1318!K1318_Size01) = False Then D1318.Size01 = Trim$(rs1318!K1318_Size01)
            If IsdbNull(rs1318!K1318_Size02) = False Then D1318.Size02 = Trim$(rs1318!K1318_Size02)
            If IsdbNull(rs1318!K1318_Size03) = False Then D1318.Size03 = Trim$(rs1318!K1318_Size03)
            If IsdbNull(rs1318!K1318_Size04) = False Then D1318.Size04 = Trim$(rs1318!K1318_Size04)
            If IsdbNull(rs1318!K1318_Size05) = False Then D1318.Size05 = Trim$(rs1318!K1318_Size05)
            If IsdbNull(rs1318!K1318_Size06) = False Then D1318.Size06 = Trim$(rs1318!K1318_Size06)
            If IsdbNull(rs1318!K1318_Size07) = False Then D1318.Size07 = Trim$(rs1318!K1318_Size07)
            If IsdbNull(rs1318!K1318_Size08) = False Then D1318.Size08 = Trim$(rs1318!K1318_Size08)
            If IsdbNull(rs1318!K1318_Size09) = False Then D1318.Size09 = Trim$(rs1318!K1318_Size09)
            If IsdbNull(rs1318!K1318_Size10) = False Then D1318.Size10 = Trim$(rs1318!K1318_Size10)
            If IsdbNull(rs1318!K1318_Size11) = False Then D1318.Size11 = Trim$(rs1318!K1318_Size11)
            If IsdbNull(rs1318!K1318_Size12) = False Then D1318.Size12 = Trim$(rs1318!K1318_Size12)
            If IsdbNull(rs1318!K1318_Size13) = False Then D1318.Size13 = Trim$(rs1318!K1318_Size13)
            If IsdbNull(rs1318!K1318_Size14) = False Then D1318.Size14 = Trim$(rs1318!K1318_Size14)
            If IsdbNull(rs1318!K1318_Size15) = False Then D1318.Size15 = Trim$(rs1318!K1318_Size15)
            If IsdbNull(rs1318!K1318_Size16) = False Then D1318.Size16 = Trim$(rs1318!K1318_Size16)
            If IsdbNull(rs1318!K1318_Size17) = False Then D1318.Size17 = Trim$(rs1318!K1318_Size17)
            If IsdbNull(rs1318!K1318_Size18) = False Then D1318.Size18 = Trim$(rs1318!K1318_Size18)
            If IsdbNull(rs1318!K1318_Size19) = False Then D1318.Size19 = Trim$(rs1318!K1318_Size19)
            If IsdbNull(rs1318!K1318_Size20) = False Then D1318.Size20 = Trim$(rs1318!K1318_Size20)
            If IsdbNull(rs1318!K1318_Size21) = False Then D1318.Size21 = Trim$(rs1318!K1318_Size21)
            If IsdbNull(rs1318!K1318_Size22) = False Then D1318.Size22 = Trim$(rs1318!K1318_Size22)
            If IsdbNull(rs1318!K1318_Size23) = False Then D1318.Size23 = Trim$(rs1318!K1318_Size23)
            If IsdbNull(rs1318!K1318_Size24) = False Then D1318.Size24 = Trim$(rs1318!K1318_Size24)
            If IsdbNull(rs1318!K1318_Size25) = False Then D1318.Size25 = Trim$(rs1318!K1318_Size25)
            If IsdbNull(rs1318!K1318_Size26) = False Then D1318.Size26 = Trim$(rs1318!K1318_Size26)
            If IsdbNull(rs1318!K1318_Size27) = False Then D1318.Size27 = Trim$(rs1318!K1318_Size27)
            If IsdbNull(rs1318!K1318_Size28) = False Then D1318.Size28 = Trim$(rs1318!K1318_Size28)
            If IsdbNull(rs1318!K1318_Size29) = False Then D1318.Size29 = Trim$(rs1318!K1318_Size29)
            If IsdbNull(rs1318!K1318_Size30) = False Then D1318.Size30 = Trim$(rs1318!K1318_Size30)
            If IsdbNull(rs1318!K1318_DateInsert) = False Then D1318.DateInsert = Trim$(rs1318!K1318_DateInsert)
            If IsdbNull(rs1318!K1318_InsertDate) = False Then D1318.InsertDate = Trim$(rs1318!K1318_InsertDate)
            If IsdbNull(rs1318!K1318_InchargeInsert) = False Then D1318.InchargeInsert = Trim$(rs1318!K1318_InchargeInsert)
            If IsdbNull(rs1318!K1318_Dateupdate) = False Then D1318.Dateupdate = Trim$(rs1318!K1318_Dateupdate)
            If IsdbNull(rs1318!K1318_InchargeUpdate) = False Then D1318.InchargeUpdate = Trim$(rs1318!K1318_InchargeUpdate)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K1318_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K1318_MOVE(rs1318 As DataRow)
        Try

            Call D1318_CLEAR()

            If IsdbNull(rs1318!K1318_OrderNo) = False Then D1318.OrderNo = Trim$(rs1318!K1318_OrderNo)
            If IsdbNull(rs1318!K1318_OrderNoSeq) = False Then D1318.OrderNoSeq = Trim$(rs1318!K1318_OrderNoSeq)
            If IsdbNull(rs1318!K1318_ShoesCode) = False Then D1318.ShoesCode = Trim$(rs1318!K1318_ShoesCode)
            If IsdbNull(rs1318!K1318_SizeRange) = False Then D1318.SizeRange = Trim$(rs1318!K1318_SizeRange)
            If IsdbNull(rs1318!K1318_Barcode01) = False Then D1318.Barcode01 = Trim$(rs1318!K1318_Barcode01)
            If IsdbNull(rs1318!K1318_Barcode02) = False Then D1318.Barcode02 = Trim$(rs1318!K1318_Barcode02)
            If IsdbNull(rs1318!K1318_Barcode03) = False Then D1318.Barcode03 = Trim$(rs1318!K1318_Barcode03)
            If IsdbNull(rs1318!K1318_Barcode04) = False Then D1318.Barcode04 = Trim$(rs1318!K1318_Barcode04)
            If IsdbNull(rs1318!K1318_Barcode05) = False Then D1318.Barcode05 = Trim$(rs1318!K1318_Barcode05)
            If IsdbNull(rs1318!K1318_Barcode06) = False Then D1318.Barcode06 = Trim$(rs1318!K1318_Barcode06)
            If IsdbNull(rs1318!K1318_Barcode07) = False Then D1318.Barcode07 = Trim$(rs1318!K1318_Barcode07)
            If IsdbNull(rs1318!K1318_Barcode08) = False Then D1318.Barcode08 = Trim$(rs1318!K1318_Barcode08)
            If IsdbNull(rs1318!K1318_Barcode09) = False Then D1318.Barcode09 = Trim$(rs1318!K1318_Barcode09)
            If IsdbNull(rs1318!K1318_Barcode10) = False Then D1318.Barcode10 = Trim$(rs1318!K1318_Barcode10)
            If IsdbNull(rs1318!K1318_Barcode11) = False Then D1318.Barcode11 = Trim$(rs1318!K1318_Barcode11)
            If IsdbNull(rs1318!K1318_Barcode12) = False Then D1318.Barcode12 = Trim$(rs1318!K1318_Barcode12)
            If IsdbNull(rs1318!K1318_Barcode13) = False Then D1318.Barcode13 = Trim$(rs1318!K1318_Barcode13)
            If IsdbNull(rs1318!K1318_Barcode14) = False Then D1318.Barcode14 = Trim$(rs1318!K1318_Barcode14)
            If IsdbNull(rs1318!K1318_Barcode15) = False Then D1318.Barcode15 = Trim$(rs1318!K1318_Barcode15)
            If IsdbNull(rs1318!K1318_Barcode16) = False Then D1318.Barcode16 = Trim$(rs1318!K1318_Barcode16)
            If IsdbNull(rs1318!K1318_Barcode17) = False Then D1318.Barcode17 = Trim$(rs1318!K1318_Barcode17)
            If IsdbNull(rs1318!K1318_Barcode18) = False Then D1318.Barcode18 = Trim$(rs1318!K1318_Barcode18)
            If IsdbNull(rs1318!K1318_Barcode19) = False Then D1318.Barcode19 = Trim$(rs1318!K1318_Barcode19)
            If IsdbNull(rs1318!K1318_Barcode20) = False Then D1318.Barcode20 = Trim$(rs1318!K1318_Barcode20)
            If IsdbNull(rs1318!K1318_Barcode21) = False Then D1318.Barcode21 = Trim$(rs1318!K1318_Barcode21)
            If IsdbNull(rs1318!K1318_Barcode22) = False Then D1318.Barcode22 = Trim$(rs1318!K1318_Barcode22)
            If IsdbNull(rs1318!K1318_Barcode23) = False Then D1318.Barcode23 = Trim$(rs1318!K1318_Barcode23)
            If IsdbNull(rs1318!K1318_Barcode24) = False Then D1318.Barcode24 = Trim$(rs1318!K1318_Barcode24)
            If IsdbNull(rs1318!K1318_Barcode25) = False Then D1318.Barcode25 = Trim$(rs1318!K1318_Barcode25)
            If IsdbNull(rs1318!K1318_Barcode26) = False Then D1318.Barcode26 = Trim$(rs1318!K1318_Barcode26)
            If IsdbNull(rs1318!K1318_Barcode27) = False Then D1318.Barcode27 = Trim$(rs1318!K1318_Barcode27)
            If IsdbNull(rs1318!K1318_Barcode28) = False Then D1318.Barcode28 = Trim$(rs1318!K1318_Barcode28)
            If IsdbNull(rs1318!K1318_Barcode29) = False Then D1318.Barcode29 = Trim$(rs1318!K1318_Barcode29)
            If IsdbNull(rs1318!K1318_Barcode30) = False Then D1318.Barcode30 = Trim$(rs1318!K1318_Barcode30)
            If IsdbNull(rs1318!K1318_Size01) = False Then D1318.Size01 = Trim$(rs1318!K1318_Size01)
            If IsdbNull(rs1318!K1318_Size02) = False Then D1318.Size02 = Trim$(rs1318!K1318_Size02)
            If IsdbNull(rs1318!K1318_Size03) = False Then D1318.Size03 = Trim$(rs1318!K1318_Size03)
            If IsdbNull(rs1318!K1318_Size04) = False Then D1318.Size04 = Trim$(rs1318!K1318_Size04)
            If IsdbNull(rs1318!K1318_Size05) = False Then D1318.Size05 = Trim$(rs1318!K1318_Size05)
            If IsdbNull(rs1318!K1318_Size06) = False Then D1318.Size06 = Trim$(rs1318!K1318_Size06)
            If IsdbNull(rs1318!K1318_Size07) = False Then D1318.Size07 = Trim$(rs1318!K1318_Size07)
            If IsdbNull(rs1318!K1318_Size08) = False Then D1318.Size08 = Trim$(rs1318!K1318_Size08)
            If IsdbNull(rs1318!K1318_Size09) = False Then D1318.Size09 = Trim$(rs1318!K1318_Size09)
            If IsdbNull(rs1318!K1318_Size10) = False Then D1318.Size10 = Trim$(rs1318!K1318_Size10)
            If IsdbNull(rs1318!K1318_Size11) = False Then D1318.Size11 = Trim$(rs1318!K1318_Size11)
            If IsdbNull(rs1318!K1318_Size12) = False Then D1318.Size12 = Trim$(rs1318!K1318_Size12)
            If IsdbNull(rs1318!K1318_Size13) = False Then D1318.Size13 = Trim$(rs1318!K1318_Size13)
            If IsdbNull(rs1318!K1318_Size14) = False Then D1318.Size14 = Trim$(rs1318!K1318_Size14)
            If IsdbNull(rs1318!K1318_Size15) = False Then D1318.Size15 = Trim$(rs1318!K1318_Size15)
            If IsdbNull(rs1318!K1318_Size16) = False Then D1318.Size16 = Trim$(rs1318!K1318_Size16)
            If IsdbNull(rs1318!K1318_Size17) = False Then D1318.Size17 = Trim$(rs1318!K1318_Size17)
            If IsdbNull(rs1318!K1318_Size18) = False Then D1318.Size18 = Trim$(rs1318!K1318_Size18)
            If IsdbNull(rs1318!K1318_Size19) = False Then D1318.Size19 = Trim$(rs1318!K1318_Size19)
            If IsdbNull(rs1318!K1318_Size20) = False Then D1318.Size20 = Trim$(rs1318!K1318_Size20)
            If IsdbNull(rs1318!K1318_Size21) = False Then D1318.Size21 = Trim$(rs1318!K1318_Size21)
            If IsdbNull(rs1318!K1318_Size22) = False Then D1318.Size22 = Trim$(rs1318!K1318_Size22)
            If IsdbNull(rs1318!K1318_Size23) = False Then D1318.Size23 = Trim$(rs1318!K1318_Size23)
            If IsdbNull(rs1318!K1318_Size24) = False Then D1318.Size24 = Trim$(rs1318!K1318_Size24)
            If IsdbNull(rs1318!K1318_Size25) = False Then D1318.Size25 = Trim$(rs1318!K1318_Size25)
            If IsdbNull(rs1318!K1318_Size26) = False Then D1318.Size26 = Trim$(rs1318!K1318_Size26)
            If IsdbNull(rs1318!K1318_Size27) = False Then D1318.Size27 = Trim$(rs1318!K1318_Size27)
            If IsdbNull(rs1318!K1318_Size28) = False Then D1318.Size28 = Trim$(rs1318!K1318_Size28)
            If IsdbNull(rs1318!K1318_Size29) = False Then D1318.Size29 = Trim$(rs1318!K1318_Size29)
            If IsdbNull(rs1318!K1318_Size30) = False Then D1318.Size30 = Trim$(rs1318!K1318_Size30)
            If IsdbNull(rs1318!K1318_DateInsert) = False Then D1318.DateInsert = Trim$(rs1318!K1318_DateInsert)
            If IsdbNull(rs1318!K1318_InsertDate) = False Then D1318.InsertDate = Trim$(rs1318!K1318_InsertDate)
            If IsdbNull(rs1318!K1318_InchargeInsert) = False Then D1318.InchargeInsert = Trim$(rs1318!K1318_InchargeInsert)
            If IsdbNull(rs1318!K1318_Dateupdate) = False Then D1318.Dateupdate = Trim$(rs1318!K1318_Dateupdate)
            If IsdbNull(rs1318!K1318_InchargeUpdate) = False Then D1318.InchargeUpdate = Trim$(rs1318!K1318_InchargeUpdate)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K1318_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K1318_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z1318 As T1318_AREA, ORDERNO As String, ORDERNOSEQ As String) As Boolean

        K1318_MOVE = False

        Try
            If READ_PFK1318(ORDERNO, ORDERNOSEQ) = True Then
                z1318 = D1318
                K1318_MOVE = True
            Else
                z1318 = Nothing
            End If

            If getColumIndex(spr, "OrderNo") > -1 Then z1318.OrderNo = getDataM(spr, getColumIndex(spr, "OrderNo"), xRow)
            If getColumIndex(spr, "OrderNoSeq") > -1 Then z1318.OrderNoSeq = getDataM(spr, getColumIndex(spr, "OrderNoSeq"), xRow)
            If getColumIndex(spr, "ShoesCode") > -1 Then z1318.ShoesCode = getDataM(spr, getColumIndex(spr, "ShoesCode"), xRow)
            If getColumIndex(spr, "SizeRange") > -1 Then z1318.SizeRange = getDataM(spr, getColumIndex(spr, "SizeRange"), xRow)
            If getColumIndex(spr, "Barcode01") > -1 Then z1318.Barcode01 = getDataM(spr, getColumIndex(spr, "Barcode01"), xRow)
            If getColumIndex(spr, "Barcode02") > -1 Then z1318.Barcode02 = getDataM(spr, getColumIndex(spr, "Barcode02"), xRow)
            If getColumIndex(spr, "Barcode03") > -1 Then z1318.Barcode03 = getDataM(spr, getColumIndex(spr, "Barcode03"), xRow)
            If getColumIndex(spr, "Barcode04") > -1 Then z1318.Barcode04 = getDataM(spr, getColumIndex(spr, "Barcode04"), xRow)
            If getColumIndex(spr, "Barcode05") > -1 Then z1318.Barcode05 = getDataM(spr, getColumIndex(spr, "Barcode05"), xRow)
            If getColumIndex(spr, "Barcode06") > -1 Then z1318.Barcode06 = getDataM(spr, getColumIndex(spr, "Barcode06"), xRow)
            If getColumIndex(spr, "Barcode07") > -1 Then z1318.Barcode07 = getDataM(spr, getColumIndex(spr, "Barcode07"), xRow)
            If getColumIndex(spr, "Barcode08") > -1 Then z1318.Barcode08 = getDataM(spr, getColumIndex(spr, "Barcode08"), xRow)
            If getColumIndex(spr, "Barcode09") > -1 Then z1318.Barcode09 = getDataM(spr, getColumIndex(spr, "Barcode09"), xRow)
            If getColumIndex(spr, "Barcode10") > -1 Then z1318.Barcode10 = getDataM(spr, getColumIndex(spr, "Barcode10"), xRow)
            If getColumIndex(spr, "Barcode11") > -1 Then z1318.Barcode11 = getDataM(spr, getColumIndex(spr, "Barcode11"), xRow)
            If getColumIndex(spr, "Barcode12") > -1 Then z1318.Barcode12 = getDataM(spr, getColumIndex(spr, "Barcode12"), xRow)
            If getColumIndex(spr, "Barcode13") > -1 Then z1318.Barcode13 = getDataM(spr, getColumIndex(spr, "Barcode13"), xRow)
            If getColumIndex(spr, "Barcode14") > -1 Then z1318.Barcode14 = getDataM(spr, getColumIndex(spr, "Barcode14"), xRow)
            If getColumIndex(spr, "Barcode15") > -1 Then z1318.Barcode15 = getDataM(spr, getColumIndex(spr, "Barcode15"), xRow)
            If getColumIndex(spr, "Barcode16") > -1 Then z1318.Barcode16 = getDataM(spr, getColumIndex(spr, "Barcode16"), xRow)
            If getColumIndex(spr, "Barcode17") > -1 Then z1318.Barcode17 = getDataM(spr, getColumIndex(spr, "Barcode17"), xRow)
            If getColumIndex(spr, "Barcode18") > -1 Then z1318.Barcode18 = getDataM(spr, getColumIndex(spr, "Barcode18"), xRow)
            If getColumIndex(spr, "Barcode19") > -1 Then z1318.Barcode19 = getDataM(spr, getColumIndex(spr, "Barcode19"), xRow)
            If getColumIndex(spr, "Barcode20") > -1 Then z1318.Barcode20 = getDataM(spr, getColumIndex(spr, "Barcode20"), xRow)
            If getColumIndex(spr, "Barcode21") > -1 Then z1318.Barcode21 = getDataM(spr, getColumIndex(spr, "Barcode21"), xRow)
            If getColumIndex(spr, "Barcode22") > -1 Then z1318.Barcode22 = getDataM(spr, getColumIndex(spr, "Barcode22"), xRow)
            If getColumIndex(spr, "Barcode23") > -1 Then z1318.Barcode23 = getDataM(spr, getColumIndex(spr, "Barcode23"), xRow)
            If getColumIndex(spr, "Barcode24") > -1 Then z1318.Barcode24 = getDataM(spr, getColumIndex(spr, "Barcode24"), xRow)
            If getColumIndex(spr, "Barcode25") > -1 Then z1318.Barcode25 = getDataM(spr, getColumIndex(spr, "Barcode25"), xRow)
            If getColumIndex(spr, "Barcode26") > -1 Then z1318.Barcode26 = getDataM(spr, getColumIndex(spr, "Barcode26"), xRow)
            If getColumIndex(spr, "Barcode27") > -1 Then z1318.Barcode27 = getDataM(spr, getColumIndex(spr, "Barcode27"), xRow)
            If getColumIndex(spr, "Barcode28") > -1 Then z1318.Barcode28 = getDataM(spr, getColumIndex(spr, "Barcode28"), xRow)
            If getColumIndex(spr, "Barcode29") > -1 Then z1318.Barcode29 = getDataM(spr, getColumIndex(spr, "Barcode29"), xRow)
            If getColumIndex(spr, "Barcode30") > -1 Then z1318.Barcode30 = getDataM(spr, getColumIndex(spr, "Barcode30"), xRow)
            If getColumIndex(spr, "Size01") > -1 Then z1318.Size01 = getDataM(spr, getColumIndex(spr, "Size01"), xRow)
            If getColumIndex(spr, "Size02") > -1 Then z1318.Size02 = getDataM(spr, getColumIndex(spr, "Size02"), xRow)
            If getColumIndex(spr, "Size03") > -1 Then z1318.Size03 = getDataM(spr, getColumIndex(spr, "Size03"), xRow)
            If getColumIndex(spr, "Size04") > -1 Then z1318.Size04 = getDataM(spr, getColumIndex(spr, "Size04"), xRow)
            If getColumIndex(spr, "Size05") > -1 Then z1318.Size05 = getDataM(spr, getColumIndex(spr, "Size05"), xRow)
            If getColumIndex(spr, "Size06") > -1 Then z1318.Size06 = getDataM(spr, getColumIndex(spr, "Size06"), xRow)
            If getColumIndex(spr, "Size07") > -1 Then z1318.Size07 = getDataM(spr, getColumIndex(spr, "Size07"), xRow)
            If getColumIndex(spr, "Size08") > -1 Then z1318.Size08 = getDataM(spr, getColumIndex(spr, "Size08"), xRow)
            If getColumIndex(spr, "Size09") > -1 Then z1318.Size09 = getDataM(spr, getColumIndex(spr, "Size09"), xRow)
            If getColumIndex(spr, "Size10") > -1 Then z1318.Size10 = getDataM(spr, getColumIndex(spr, "Size10"), xRow)
            If getColumIndex(spr, "Size11") > -1 Then z1318.Size11 = getDataM(spr, getColumIndex(spr, "Size11"), xRow)
            If getColumIndex(spr, "Size12") > -1 Then z1318.Size12 = getDataM(spr, getColumIndex(spr, "Size12"), xRow)
            If getColumIndex(spr, "Size13") > -1 Then z1318.Size13 = getDataM(spr, getColumIndex(spr, "Size13"), xRow)
            If getColumIndex(spr, "Size14") > -1 Then z1318.Size14 = getDataM(spr, getColumIndex(spr, "Size14"), xRow)
            If getColumIndex(spr, "Size15") > -1 Then z1318.Size15 = getDataM(spr, getColumIndex(spr, "Size15"), xRow)
            If getColumIndex(spr, "Size16") > -1 Then z1318.Size16 = getDataM(spr, getColumIndex(spr, "Size16"), xRow)
            If getColumIndex(spr, "Size17") > -1 Then z1318.Size17 = getDataM(spr, getColumIndex(spr, "Size17"), xRow)
            If getColumIndex(spr, "Size18") > -1 Then z1318.Size18 = getDataM(spr, getColumIndex(spr, "Size18"), xRow)
            If getColumIndex(spr, "Size19") > -1 Then z1318.Size19 = getDataM(spr, getColumIndex(spr, "Size19"), xRow)
            If getColumIndex(spr, "Size20") > -1 Then z1318.Size20 = getDataM(spr, getColumIndex(spr, "Size20"), xRow)
            If getColumIndex(spr, "Size21") > -1 Then z1318.Size21 = getDataM(spr, getColumIndex(spr, "Size21"), xRow)
            If getColumIndex(spr, "Size22") > -1 Then z1318.Size22 = getDataM(spr, getColumIndex(spr, "Size22"), xRow)
            If getColumIndex(spr, "Size23") > -1 Then z1318.Size23 = getDataM(spr, getColumIndex(spr, "Size23"), xRow)
            If getColumIndex(spr, "Size24") > -1 Then z1318.Size24 = getDataM(spr, getColumIndex(spr, "Size24"), xRow)
            If getColumIndex(spr, "Size25") > -1 Then z1318.Size25 = getDataM(spr, getColumIndex(spr, "Size25"), xRow)
            If getColumIndex(spr, "Size26") > -1 Then z1318.Size26 = getDataM(spr, getColumIndex(spr, "Size26"), xRow)
            If getColumIndex(spr, "Size27") > -1 Then z1318.Size27 = getDataM(spr, getColumIndex(spr, "Size27"), xRow)
            If getColumIndex(spr, "Size28") > -1 Then z1318.Size28 = getDataM(spr, getColumIndex(spr, "Size28"), xRow)
            If getColumIndex(spr, "Size29") > -1 Then z1318.Size29 = getDataM(spr, getColumIndex(spr, "Size29"), xRow)
            If getColumIndex(spr, "Size30") > -1 Then z1318.Size30 = getDataM(spr, getColumIndex(spr, "Size30"), xRow)
            If getColumIndex(spr, "DateInsert") > -1 Then z1318.DateInsert = getDataM(spr, getColumIndex(spr, "DateInsert"), xRow)
            If getColumIndex(spr, "InsertDate") > -1 Then z1318.InsertDate = getDataM(spr, getColumIndex(spr, "InsertDate"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z1318.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "Dateupdate") > -1 Then z1318.Dateupdate = getDataM(spr, getColumIndex(spr, "Dateupdate"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z1318.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K1318_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K1318_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z1318 As T1318_AREA, CheckClear As Boolean, ORDERNO As String, ORDERNOSEQ As String) As Boolean

        K1318_MOVE = False

        Try
            If READ_PFK1318(ORDERNO, ORDERNOSEQ) = True Then
                z1318 = D1318
                K1318_MOVE = True
            Else
                If CheckClear = True Then z1318 = Nothing
            End If

            If getColumIndex(spr, "OrderNo") > -1 Then z1318.OrderNo = getDataM(spr, getColumIndex(spr, "OrderNo"), xRow)
            If getColumIndex(spr, "OrderNoSeq") > -1 Then z1318.OrderNoSeq = getDataM(spr, getColumIndex(spr, "OrderNoSeq"), xRow)
            If getColumIndex(spr, "ShoesCode") > -1 Then z1318.ShoesCode = getDataM(spr, getColumIndex(spr, "ShoesCode"), xRow)
            If getColumIndex(spr, "SizeRange") > -1 Then z1318.SizeRange = getDataM(spr, getColumIndex(spr, "SizeRange"), xRow)
            If getColumIndex(spr, "Barcode01") > -1 Then z1318.Barcode01 = getDataM(spr, getColumIndex(spr, "Barcode01"), xRow)
            If getColumIndex(spr, "Barcode02") > -1 Then z1318.Barcode02 = getDataM(spr, getColumIndex(spr, "Barcode02"), xRow)
            If getColumIndex(spr, "Barcode03") > -1 Then z1318.Barcode03 = getDataM(spr, getColumIndex(spr, "Barcode03"), xRow)
            If getColumIndex(spr, "Barcode04") > -1 Then z1318.Barcode04 = getDataM(spr, getColumIndex(spr, "Barcode04"), xRow)
            If getColumIndex(spr, "Barcode05") > -1 Then z1318.Barcode05 = getDataM(spr, getColumIndex(spr, "Barcode05"), xRow)
            If getColumIndex(spr, "Barcode06") > -1 Then z1318.Barcode06 = getDataM(spr, getColumIndex(spr, "Barcode06"), xRow)
            If getColumIndex(spr, "Barcode07") > -1 Then z1318.Barcode07 = getDataM(spr, getColumIndex(spr, "Barcode07"), xRow)
            If getColumIndex(spr, "Barcode08") > -1 Then z1318.Barcode08 = getDataM(spr, getColumIndex(spr, "Barcode08"), xRow)
            If getColumIndex(spr, "Barcode09") > -1 Then z1318.Barcode09 = getDataM(spr, getColumIndex(spr, "Barcode09"), xRow)
            If getColumIndex(spr, "Barcode10") > -1 Then z1318.Barcode10 = getDataM(spr, getColumIndex(spr, "Barcode10"), xRow)
            If getColumIndex(spr, "Barcode11") > -1 Then z1318.Barcode11 = getDataM(spr, getColumIndex(spr, "Barcode11"), xRow)
            If getColumIndex(spr, "Barcode12") > -1 Then z1318.Barcode12 = getDataM(spr, getColumIndex(spr, "Barcode12"), xRow)
            If getColumIndex(spr, "Barcode13") > -1 Then z1318.Barcode13 = getDataM(spr, getColumIndex(spr, "Barcode13"), xRow)
            If getColumIndex(spr, "Barcode14") > -1 Then z1318.Barcode14 = getDataM(spr, getColumIndex(spr, "Barcode14"), xRow)
            If getColumIndex(spr, "Barcode15") > -1 Then z1318.Barcode15 = getDataM(spr, getColumIndex(spr, "Barcode15"), xRow)
            If getColumIndex(spr, "Barcode16") > -1 Then z1318.Barcode16 = getDataM(spr, getColumIndex(spr, "Barcode16"), xRow)
            If getColumIndex(spr, "Barcode17") > -1 Then z1318.Barcode17 = getDataM(spr, getColumIndex(spr, "Barcode17"), xRow)
            If getColumIndex(spr, "Barcode18") > -1 Then z1318.Barcode18 = getDataM(spr, getColumIndex(spr, "Barcode18"), xRow)
            If getColumIndex(spr, "Barcode19") > -1 Then z1318.Barcode19 = getDataM(spr, getColumIndex(spr, "Barcode19"), xRow)
            If getColumIndex(spr, "Barcode20") > -1 Then z1318.Barcode20 = getDataM(spr, getColumIndex(spr, "Barcode20"), xRow)
            If getColumIndex(spr, "Barcode21") > -1 Then z1318.Barcode21 = getDataM(spr, getColumIndex(spr, "Barcode21"), xRow)
            If getColumIndex(spr, "Barcode22") > -1 Then z1318.Barcode22 = getDataM(spr, getColumIndex(spr, "Barcode22"), xRow)
            If getColumIndex(spr, "Barcode23") > -1 Then z1318.Barcode23 = getDataM(spr, getColumIndex(spr, "Barcode23"), xRow)
            If getColumIndex(spr, "Barcode24") > -1 Then z1318.Barcode24 = getDataM(spr, getColumIndex(spr, "Barcode24"), xRow)
            If getColumIndex(spr, "Barcode25") > -1 Then z1318.Barcode25 = getDataM(spr, getColumIndex(spr, "Barcode25"), xRow)
            If getColumIndex(spr, "Barcode26") > -1 Then z1318.Barcode26 = getDataM(spr, getColumIndex(spr, "Barcode26"), xRow)
            If getColumIndex(spr, "Barcode27") > -1 Then z1318.Barcode27 = getDataM(spr, getColumIndex(spr, "Barcode27"), xRow)
            If getColumIndex(spr, "Barcode28") > -1 Then z1318.Barcode28 = getDataM(spr, getColumIndex(spr, "Barcode28"), xRow)
            If getColumIndex(spr, "Barcode29") > -1 Then z1318.Barcode29 = getDataM(spr, getColumIndex(spr, "Barcode29"), xRow)
            If getColumIndex(spr, "Barcode30") > -1 Then z1318.Barcode30 = getDataM(spr, getColumIndex(spr, "Barcode30"), xRow)
            If getColumIndex(spr, "Size01") > -1 Then z1318.Size01 = getDataM(spr, getColumIndex(spr, "Size01"), xRow)
            If getColumIndex(spr, "Size02") > -1 Then z1318.Size02 = getDataM(spr, getColumIndex(spr, "Size02"), xRow)
            If getColumIndex(spr, "Size03") > -1 Then z1318.Size03 = getDataM(spr, getColumIndex(spr, "Size03"), xRow)
            If getColumIndex(spr, "Size04") > -1 Then z1318.Size04 = getDataM(spr, getColumIndex(spr, "Size04"), xRow)
            If getColumIndex(spr, "Size05") > -1 Then z1318.Size05 = getDataM(spr, getColumIndex(spr, "Size05"), xRow)
            If getColumIndex(spr, "Size06") > -1 Then z1318.Size06 = getDataM(spr, getColumIndex(spr, "Size06"), xRow)
            If getColumIndex(spr, "Size07") > -1 Then z1318.Size07 = getDataM(spr, getColumIndex(spr, "Size07"), xRow)
            If getColumIndex(spr, "Size08") > -1 Then z1318.Size08 = getDataM(spr, getColumIndex(spr, "Size08"), xRow)
            If getColumIndex(spr, "Size09") > -1 Then z1318.Size09 = getDataM(spr, getColumIndex(spr, "Size09"), xRow)
            If getColumIndex(spr, "Size10") > -1 Then z1318.Size10 = getDataM(spr, getColumIndex(spr, "Size10"), xRow)
            If getColumIndex(spr, "Size11") > -1 Then z1318.Size11 = getDataM(spr, getColumIndex(spr, "Size11"), xRow)
            If getColumIndex(spr, "Size12") > -1 Then z1318.Size12 = getDataM(spr, getColumIndex(spr, "Size12"), xRow)
            If getColumIndex(spr, "Size13") > -1 Then z1318.Size13 = getDataM(spr, getColumIndex(spr, "Size13"), xRow)
            If getColumIndex(spr, "Size14") > -1 Then z1318.Size14 = getDataM(spr, getColumIndex(spr, "Size14"), xRow)
            If getColumIndex(spr, "Size15") > -1 Then z1318.Size15 = getDataM(spr, getColumIndex(spr, "Size15"), xRow)
            If getColumIndex(spr, "Size16") > -1 Then z1318.Size16 = getDataM(spr, getColumIndex(spr, "Size16"), xRow)
            If getColumIndex(spr, "Size17") > -1 Then z1318.Size17 = getDataM(spr, getColumIndex(spr, "Size17"), xRow)
            If getColumIndex(spr, "Size18") > -1 Then z1318.Size18 = getDataM(spr, getColumIndex(spr, "Size18"), xRow)
            If getColumIndex(spr, "Size19") > -1 Then z1318.Size19 = getDataM(spr, getColumIndex(spr, "Size19"), xRow)
            If getColumIndex(spr, "Size20") > -1 Then z1318.Size20 = getDataM(spr, getColumIndex(spr, "Size20"), xRow)
            If getColumIndex(spr, "Size21") > -1 Then z1318.Size21 = getDataM(spr, getColumIndex(spr, "Size21"), xRow)
            If getColumIndex(spr, "Size22") > -1 Then z1318.Size22 = getDataM(spr, getColumIndex(spr, "Size22"), xRow)
            If getColumIndex(spr, "Size23") > -1 Then z1318.Size23 = getDataM(spr, getColumIndex(spr, "Size23"), xRow)
            If getColumIndex(spr, "Size24") > -1 Then z1318.Size24 = getDataM(spr, getColumIndex(spr, "Size24"), xRow)
            If getColumIndex(spr, "Size25") > -1 Then z1318.Size25 = getDataM(spr, getColumIndex(spr, "Size25"), xRow)
            If getColumIndex(spr, "Size26") > -1 Then z1318.Size26 = getDataM(spr, getColumIndex(spr, "Size26"), xRow)
            If getColumIndex(spr, "Size27") > -1 Then z1318.Size27 = getDataM(spr, getColumIndex(spr, "Size27"), xRow)
            If getColumIndex(spr, "Size28") > -1 Then z1318.Size28 = getDataM(spr, getColumIndex(spr, "Size28"), xRow)
            If getColumIndex(spr, "Size29") > -1 Then z1318.Size29 = getDataM(spr, getColumIndex(spr, "Size29"), xRow)
            If getColumIndex(spr, "Size30") > -1 Then z1318.Size30 = getDataM(spr, getColumIndex(spr, "Size30"), xRow)
            If getColumIndex(spr, "DateInsert") > -1 Then z1318.DateInsert = getDataM(spr, getColumIndex(spr, "DateInsert"), xRow)
            If getColumIndex(spr, "InsertDate") > -1 Then z1318.InsertDate = getDataM(spr, getColumIndex(spr, "InsertDate"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z1318.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "Dateupdate") > -1 Then z1318.Dateupdate = getDataM(spr, getColumIndex(spr, "Dateupdate"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z1318.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K1318_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K1318_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z1318 As T1318_AREA, Job As String, ORDERNO As String, ORDERNOSEQ As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K1318_MOVE = False

        Try
            If READ_PFK1318(ORDERNO, ORDERNOSEQ) = True Then
                z1318 = D1318
                K1318_MOVE = True
            Else
                z1318 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1318")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "ORDERNO" : z1318.OrderNo = Children(i).Code
                                Case "ORDERNOSEQ" : z1318.OrderNoSeq = Children(i).Code
                                Case "SHOESCODE" : z1318.ShoesCode = Children(i).Code
                                Case "SIZERANGE" : z1318.SizeRange = Children(i).Code
                                Case "BARCODE01" : z1318.Barcode01 = Children(i).Code
                                Case "BARCODE02" : z1318.Barcode02 = Children(i).Code
                                Case "BARCODE03" : z1318.Barcode03 = Children(i).Code
                                Case "BARCODE04" : z1318.Barcode04 = Children(i).Code
                                Case "BARCODE05" : z1318.Barcode05 = Children(i).Code
                                Case "BARCODE06" : z1318.Barcode06 = Children(i).Code
                                Case "BARCODE07" : z1318.Barcode07 = Children(i).Code
                                Case "BARCODE08" : z1318.Barcode08 = Children(i).Code
                                Case "BARCODE09" : z1318.Barcode09 = Children(i).Code
                                Case "BARCODE10" : z1318.Barcode10 = Children(i).Code
                                Case "BARCODE11" : z1318.Barcode11 = Children(i).Code
                                Case "BARCODE12" : z1318.Barcode12 = Children(i).Code
                                Case "BARCODE13" : z1318.Barcode13 = Children(i).Code
                                Case "BARCODE14" : z1318.Barcode14 = Children(i).Code
                                Case "BARCODE15" : z1318.Barcode15 = Children(i).Code
                                Case "BARCODE16" : z1318.Barcode16 = Children(i).Code
                                Case "BARCODE17" : z1318.Barcode17 = Children(i).Code
                                Case "BARCODE18" : z1318.Barcode18 = Children(i).Code
                                Case "BARCODE19" : z1318.Barcode19 = Children(i).Code
                                Case "BARCODE20" : z1318.Barcode20 = Children(i).Code
                                Case "BARCODE21" : z1318.Barcode21 = Children(i).Code
                                Case "BARCODE22" : z1318.Barcode22 = Children(i).Code
                                Case "BARCODE23" : z1318.Barcode23 = Children(i).Code
                                Case "BARCODE24" : z1318.Barcode24 = Children(i).Code
                                Case "BARCODE25" : z1318.Barcode25 = Children(i).Code
                                Case "BARCODE26" : z1318.Barcode26 = Children(i).Code
                                Case "BARCODE27" : z1318.Barcode27 = Children(i).Code
                                Case "BARCODE28" : z1318.Barcode28 = Children(i).Code
                                Case "BARCODE29" : z1318.Barcode29 = Children(i).Code
                                Case "BARCODE30" : z1318.Barcode30 = Children(i).Code
                                Case "SIZE01" : z1318.Size01 = Children(i).Code
                                Case "SIZE02" : z1318.Size02 = Children(i).Code
                                Case "SIZE03" : z1318.Size03 = Children(i).Code
                                Case "SIZE04" : z1318.Size04 = Children(i).Code
                                Case "SIZE05" : z1318.Size05 = Children(i).Code
                                Case "SIZE06" : z1318.Size06 = Children(i).Code
                                Case "SIZE07" : z1318.Size07 = Children(i).Code
                                Case "SIZE08" : z1318.Size08 = Children(i).Code
                                Case "SIZE09" : z1318.Size09 = Children(i).Code
                                Case "SIZE10" : z1318.Size10 = Children(i).Code
                                Case "SIZE11" : z1318.Size11 = Children(i).Code
                                Case "SIZE12" : z1318.Size12 = Children(i).Code
                                Case "SIZE13" : z1318.Size13 = Children(i).Code
                                Case "SIZE14" : z1318.Size14 = Children(i).Code
                                Case "SIZE15" : z1318.Size15 = Children(i).Code
                                Case "SIZE16" : z1318.Size16 = Children(i).Code
                                Case "SIZE17" : z1318.Size17 = Children(i).Code
                                Case "SIZE18" : z1318.Size18 = Children(i).Code
                                Case "SIZE19" : z1318.Size19 = Children(i).Code
                                Case "SIZE20" : z1318.Size20 = Children(i).Code
                                Case "SIZE21" : z1318.Size21 = Children(i).Code
                                Case "SIZE22" : z1318.Size22 = Children(i).Code
                                Case "SIZE23" : z1318.Size23 = Children(i).Code
                                Case "SIZE24" : z1318.Size24 = Children(i).Code
                                Case "SIZE25" : z1318.Size25 = Children(i).Code
                                Case "SIZE26" : z1318.Size26 = Children(i).Code
                                Case "SIZE27" : z1318.Size27 = Children(i).Code
                                Case "SIZE28" : z1318.Size28 = Children(i).Code
                                Case "SIZE29" : z1318.Size29 = Children(i).Code
                                Case "SIZE30" : z1318.Size30 = Children(i).Code
                                Case "DATEINSERT" : z1318.DateInsert = Children(i).Code
                                Case "INSERTDATE" : z1318.InsertDate = Children(i).Code
                                Case "INCHARGEINSERT" : z1318.InchargeInsert = Children(i).Code
                                Case "DATEUPDATE" : z1318.Dateupdate = Children(i).Code
                                Case "INCHARGEUPDATE" : z1318.InchargeUpdate = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "ORDERNO" : z1318.OrderNo = Children(i).Data
                                Case "ORDERNOSEQ" : z1318.OrderNoSeq = Children(i).Data
                                Case "SHOESCODE" : z1318.ShoesCode = Children(i).Data
                                Case "SIZERANGE" : z1318.SizeRange = Children(i).Data
                                Case "BARCODE01" : z1318.Barcode01 = Children(i).Data
                                Case "BARCODE02" : z1318.Barcode02 = Children(i).Data
                                Case "BARCODE03" : z1318.Barcode03 = Children(i).Data
                                Case "BARCODE04" : z1318.Barcode04 = Children(i).Data
                                Case "BARCODE05" : z1318.Barcode05 = Children(i).Data
                                Case "BARCODE06" : z1318.Barcode06 = Children(i).Data
                                Case "BARCODE07" : z1318.Barcode07 = Children(i).Data
                                Case "BARCODE08" : z1318.Barcode08 = Children(i).Data
                                Case "BARCODE09" : z1318.Barcode09 = Children(i).Data
                                Case "BARCODE10" : z1318.Barcode10 = Children(i).Data
                                Case "BARCODE11" : z1318.Barcode11 = Children(i).Data
                                Case "BARCODE12" : z1318.Barcode12 = Children(i).Data
                                Case "BARCODE13" : z1318.Barcode13 = Children(i).Data
                                Case "BARCODE14" : z1318.Barcode14 = Children(i).Data
                                Case "BARCODE15" : z1318.Barcode15 = Children(i).Data
                                Case "BARCODE16" : z1318.Barcode16 = Children(i).Data
                                Case "BARCODE17" : z1318.Barcode17 = Children(i).Data
                                Case "BARCODE18" : z1318.Barcode18 = Children(i).Data
                                Case "BARCODE19" : z1318.Barcode19 = Children(i).Data
                                Case "BARCODE20" : z1318.Barcode20 = Children(i).Data
                                Case "BARCODE21" : z1318.Barcode21 = Children(i).Data
                                Case "BARCODE22" : z1318.Barcode22 = Children(i).Data
                                Case "BARCODE23" : z1318.Barcode23 = Children(i).Data
                                Case "BARCODE24" : z1318.Barcode24 = Children(i).Data
                                Case "BARCODE25" : z1318.Barcode25 = Children(i).Data
                                Case "BARCODE26" : z1318.Barcode26 = Children(i).Data
                                Case "BARCODE27" : z1318.Barcode27 = Children(i).Data
                                Case "BARCODE28" : z1318.Barcode28 = Children(i).Data
                                Case "BARCODE29" : z1318.Barcode29 = Children(i).Data
                                Case "BARCODE30" : z1318.Barcode30 = Children(i).Data
                                Case "SIZE01" : z1318.Size01 = Children(i).Data
                                Case "SIZE02" : z1318.Size02 = Children(i).Data
                                Case "SIZE03" : z1318.Size03 = Children(i).Data
                                Case "SIZE04" : z1318.Size04 = Children(i).Data
                                Case "SIZE05" : z1318.Size05 = Children(i).Data
                                Case "SIZE06" : z1318.Size06 = Children(i).Data
                                Case "SIZE07" : z1318.Size07 = Children(i).Data
                                Case "SIZE08" : z1318.Size08 = Children(i).Data
                                Case "SIZE09" : z1318.Size09 = Children(i).Data
                                Case "SIZE10" : z1318.Size10 = Children(i).Data
                                Case "SIZE11" : z1318.Size11 = Children(i).Data
                                Case "SIZE12" : z1318.Size12 = Children(i).Data
                                Case "SIZE13" : z1318.Size13 = Children(i).Data
                                Case "SIZE14" : z1318.Size14 = Children(i).Data
                                Case "SIZE15" : z1318.Size15 = Children(i).Data
                                Case "SIZE16" : z1318.Size16 = Children(i).Data
                                Case "SIZE17" : z1318.Size17 = Children(i).Data
                                Case "SIZE18" : z1318.Size18 = Children(i).Data
                                Case "SIZE19" : z1318.Size19 = Children(i).Data
                                Case "SIZE20" : z1318.Size20 = Children(i).Data
                                Case "SIZE21" : z1318.Size21 = Children(i).Data
                                Case "SIZE22" : z1318.Size22 = Children(i).Data
                                Case "SIZE23" : z1318.Size23 = Children(i).Data
                                Case "SIZE24" : z1318.Size24 = Children(i).Data
                                Case "SIZE25" : z1318.Size25 = Children(i).Data
                                Case "SIZE26" : z1318.Size26 = Children(i).Data
                                Case "SIZE27" : z1318.Size27 = Children(i).Data
                                Case "SIZE28" : z1318.Size28 = Children(i).Data
                                Case "SIZE29" : z1318.Size29 = Children(i).Data
                                Case "SIZE30" : z1318.Size30 = Children(i).Data
                                Case "DATEINSERT" : z1318.DateInsert = Children(i).Data
                                Case "INSERTDATE" : z1318.InsertDate = Children(i).Data
                                Case "INCHARGEINSERT" : z1318.InchargeInsert = Children(i).Data
                                Case "DATEUPDATE" : z1318.Dateupdate = Children(i).Data
                                Case "INCHARGEUPDATE" : z1318.InchargeUpdate = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K1318_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K1318_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z1318 As T1318_AREA, Job As String, CheckClear As Boolean, ORDERNO As String, ORDERNOSEQ As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K1318_MOVE = False

        Try
            If READ_PFK1318(ORDERNO, ORDERNOSEQ) = True Then
                z1318 = D1318
                K1318_MOVE = True
            Else
                If CheckClear = True Then z1318 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1318")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "ORDERNO" : z1318.OrderNo = Children(i).Code
                                Case "ORDERNOSEQ" : z1318.OrderNoSeq = Children(i).Code
                                Case "SHOESCODE" : z1318.ShoesCode = Children(i).Code
                                Case "SIZERANGE" : z1318.SizeRange = Children(i).Code
                                Case "BARCODE01" : z1318.Barcode01 = Children(i).Code
                                Case "BARCODE02" : z1318.Barcode02 = Children(i).Code
                                Case "BARCODE03" : z1318.Barcode03 = Children(i).Code
                                Case "BARCODE04" : z1318.Barcode04 = Children(i).Code
                                Case "BARCODE05" : z1318.Barcode05 = Children(i).Code
                                Case "BARCODE06" : z1318.Barcode06 = Children(i).Code
                                Case "BARCODE07" : z1318.Barcode07 = Children(i).Code
                                Case "BARCODE08" : z1318.Barcode08 = Children(i).Code
                                Case "BARCODE09" : z1318.Barcode09 = Children(i).Code
                                Case "BARCODE10" : z1318.Barcode10 = Children(i).Code
                                Case "BARCODE11" : z1318.Barcode11 = Children(i).Code
                                Case "BARCODE12" : z1318.Barcode12 = Children(i).Code
                                Case "BARCODE13" : z1318.Barcode13 = Children(i).Code
                                Case "BARCODE14" : z1318.Barcode14 = Children(i).Code
                                Case "BARCODE15" : z1318.Barcode15 = Children(i).Code
                                Case "BARCODE16" : z1318.Barcode16 = Children(i).Code
                                Case "BARCODE17" : z1318.Barcode17 = Children(i).Code
                                Case "BARCODE18" : z1318.Barcode18 = Children(i).Code
                                Case "BARCODE19" : z1318.Barcode19 = Children(i).Code
                                Case "BARCODE20" : z1318.Barcode20 = Children(i).Code
                                Case "BARCODE21" : z1318.Barcode21 = Children(i).Code
                                Case "BARCODE22" : z1318.Barcode22 = Children(i).Code
                                Case "BARCODE23" : z1318.Barcode23 = Children(i).Code
                                Case "BARCODE24" : z1318.Barcode24 = Children(i).Code
                                Case "BARCODE25" : z1318.Barcode25 = Children(i).Code
                                Case "BARCODE26" : z1318.Barcode26 = Children(i).Code
                                Case "BARCODE27" : z1318.Barcode27 = Children(i).Code
                                Case "BARCODE28" : z1318.Barcode28 = Children(i).Code
                                Case "BARCODE29" : z1318.Barcode29 = Children(i).Code
                                Case "BARCODE30" : z1318.Barcode30 = Children(i).Code
                                Case "SIZE01" : z1318.Size01 = Children(i).Code
                                Case "SIZE02" : z1318.Size02 = Children(i).Code
                                Case "SIZE03" : z1318.Size03 = Children(i).Code
                                Case "SIZE04" : z1318.Size04 = Children(i).Code
                                Case "SIZE05" : z1318.Size05 = Children(i).Code
                                Case "SIZE06" : z1318.Size06 = Children(i).Code
                                Case "SIZE07" : z1318.Size07 = Children(i).Code
                                Case "SIZE08" : z1318.Size08 = Children(i).Code
                                Case "SIZE09" : z1318.Size09 = Children(i).Code
                                Case "SIZE10" : z1318.Size10 = Children(i).Code
                                Case "SIZE11" : z1318.Size11 = Children(i).Code
                                Case "SIZE12" : z1318.Size12 = Children(i).Code
                                Case "SIZE13" : z1318.Size13 = Children(i).Code
                                Case "SIZE14" : z1318.Size14 = Children(i).Code
                                Case "SIZE15" : z1318.Size15 = Children(i).Code
                                Case "SIZE16" : z1318.Size16 = Children(i).Code
                                Case "SIZE17" : z1318.Size17 = Children(i).Code
                                Case "SIZE18" : z1318.Size18 = Children(i).Code
                                Case "SIZE19" : z1318.Size19 = Children(i).Code
                                Case "SIZE20" : z1318.Size20 = Children(i).Code
                                Case "SIZE21" : z1318.Size21 = Children(i).Code
                                Case "SIZE22" : z1318.Size22 = Children(i).Code
                                Case "SIZE23" : z1318.Size23 = Children(i).Code
                                Case "SIZE24" : z1318.Size24 = Children(i).Code
                                Case "SIZE25" : z1318.Size25 = Children(i).Code
                                Case "SIZE26" : z1318.Size26 = Children(i).Code
                                Case "SIZE27" : z1318.Size27 = Children(i).Code
                                Case "SIZE28" : z1318.Size28 = Children(i).Code
                                Case "SIZE29" : z1318.Size29 = Children(i).Code
                                Case "SIZE30" : z1318.Size30 = Children(i).Code
                                Case "DATEINSERT" : z1318.DateInsert = Children(i).Code
                                Case "INSERTDATE" : z1318.InsertDate = Children(i).Code
                                Case "INCHARGEINSERT" : z1318.InchargeInsert = Children(i).Code
                                Case "DATEUPDATE" : z1318.Dateupdate = Children(i).Code
                                Case "INCHARGEUPDATE" : z1318.InchargeUpdate = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "ORDERNO" : z1318.OrderNo = Children(i).Data
                                Case "ORDERNOSEQ" : z1318.OrderNoSeq = Children(i).Data
                                Case "SHOESCODE" : z1318.ShoesCode = Children(i).Data
                                Case "SIZERANGE" : z1318.SizeRange = Children(i).Data
                                Case "BARCODE01" : z1318.Barcode01 = Children(i).Data
                                Case "BARCODE02" : z1318.Barcode02 = Children(i).Data
                                Case "BARCODE03" : z1318.Barcode03 = Children(i).Data
                                Case "BARCODE04" : z1318.Barcode04 = Children(i).Data
                                Case "BARCODE05" : z1318.Barcode05 = Children(i).Data
                                Case "BARCODE06" : z1318.Barcode06 = Children(i).Data
                                Case "BARCODE07" : z1318.Barcode07 = Children(i).Data
                                Case "BARCODE08" : z1318.Barcode08 = Children(i).Data
                                Case "BARCODE09" : z1318.Barcode09 = Children(i).Data
                                Case "BARCODE10" : z1318.Barcode10 = Children(i).Data
                                Case "BARCODE11" : z1318.Barcode11 = Children(i).Data
                                Case "BARCODE12" : z1318.Barcode12 = Children(i).Data
                                Case "BARCODE13" : z1318.Barcode13 = Children(i).Data
                                Case "BARCODE14" : z1318.Barcode14 = Children(i).Data
                                Case "BARCODE15" : z1318.Barcode15 = Children(i).Data
                                Case "BARCODE16" : z1318.Barcode16 = Children(i).Data
                                Case "BARCODE17" : z1318.Barcode17 = Children(i).Data
                                Case "BARCODE18" : z1318.Barcode18 = Children(i).Data
                                Case "BARCODE19" : z1318.Barcode19 = Children(i).Data
                                Case "BARCODE20" : z1318.Barcode20 = Children(i).Data
                                Case "BARCODE21" : z1318.Barcode21 = Children(i).Data
                                Case "BARCODE22" : z1318.Barcode22 = Children(i).Data
                                Case "BARCODE23" : z1318.Barcode23 = Children(i).Data
                                Case "BARCODE24" : z1318.Barcode24 = Children(i).Data
                                Case "BARCODE25" : z1318.Barcode25 = Children(i).Data
                                Case "BARCODE26" : z1318.Barcode26 = Children(i).Data
                                Case "BARCODE27" : z1318.Barcode27 = Children(i).Data
                                Case "BARCODE28" : z1318.Barcode28 = Children(i).Data
                                Case "BARCODE29" : z1318.Barcode29 = Children(i).Data
                                Case "BARCODE30" : z1318.Barcode30 = Children(i).Data
                                Case "SIZE01" : z1318.Size01 = Children(i).Data
                                Case "SIZE02" : z1318.Size02 = Children(i).Data
                                Case "SIZE03" : z1318.Size03 = Children(i).Data
                                Case "SIZE04" : z1318.Size04 = Children(i).Data
                                Case "SIZE05" : z1318.Size05 = Children(i).Data
                                Case "SIZE06" : z1318.Size06 = Children(i).Data
                                Case "SIZE07" : z1318.Size07 = Children(i).Data
                                Case "SIZE08" : z1318.Size08 = Children(i).Data
                                Case "SIZE09" : z1318.Size09 = Children(i).Data
                                Case "SIZE10" : z1318.Size10 = Children(i).Data
                                Case "SIZE11" : z1318.Size11 = Children(i).Data
                                Case "SIZE12" : z1318.Size12 = Children(i).Data
                                Case "SIZE13" : z1318.Size13 = Children(i).Data
                                Case "SIZE14" : z1318.Size14 = Children(i).Data
                                Case "SIZE15" : z1318.Size15 = Children(i).Data
                                Case "SIZE16" : z1318.Size16 = Children(i).Data
                                Case "SIZE17" : z1318.Size17 = Children(i).Data
                                Case "SIZE18" : z1318.Size18 = Children(i).Data
                                Case "SIZE19" : z1318.Size19 = Children(i).Data
                                Case "SIZE20" : z1318.Size20 = Children(i).Data
                                Case "SIZE21" : z1318.Size21 = Children(i).Data
                                Case "SIZE22" : z1318.Size22 = Children(i).Data
                                Case "SIZE23" : z1318.Size23 = Children(i).Data
                                Case "SIZE24" : z1318.Size24 = Children(i).Data
                                Case "SIZE25" : z1318.Size25 = Children(i).Data
                                Case "SIZE26" : z1318.Size26 = Children(i).Data
                                Case "SIZE27" : z1318.Size27 = Children(i).Data
                                Case "SIZE28" : z1318.Size28 = Children(i).Data
                                Case "SIZE29" : z1318.Size29 = Children(i).Data
                                Case "SIZE30" : z1318.Size30 = Children(i).Data
                                Case "DATEINSERT" : z1318.DateInsert = Children(i).Data
                                Case "INSERTDATE" : z1318.InsertDate = Children(i).Data
                                Case "INCHARGEINSERT" : z1318.InchargeInsert = Children(i).Data
                                Case "DATEUPDATE" : z1318.Dateupdate = Children(i).Data
                                Case "INCHARGEUPDATE" : z1318.InchargeUpdate = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K1318_MOVE", vbCritical)
        End Try
    End Function
    
End Module 
