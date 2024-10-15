'=========================================================================================================================================================
'   TABLE : (PFK0000)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K0000

Structure T0000_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
        Public Autokey As Double  '			decimal		*
        Public PackingBatch As String  '			nvarchar(20)
        Public ENTE40 As String  '			nvarchar(255)
        Public SAOI40 As Double  '			decimal
        Public NROI40 As Double  '			decimal
        Public MACO40 As String  '			nvarchar(255)
        Public SSCO40 As Double  '			decimal
        Public AACO40 As Double  '			decimal
        Public NUCO40 As String  '			nvarchar(255)
        Public INCO40 As String  '			nvarchar(255)
        Public NULA40 As Double  '			decimal
        Public TQQT40 As Double  '			decimal
        Public QT0140 As Double  '			decimal
        Public TG0140 As String  '			nvarchar(255)
        Public QT0240 As Double  '			decimal
        Public TG0240 As String  '			nvarchar(255)
        Public QT0340 As Double  '			decimal
        Public TG0340 As String  '			nvarchar(255)
        Public QT0440 As Double  '			decimal
        Public TG0440 As String  '			nvarchar(255)
        Public QT0540 As Double  '			decimal
        Public TG0540 As String  '			nvarchar(255)
        Public QT0640 As Double  '			decimal
        Public TG0640 As String  '			nvarchar(255)
        Public QT0740 As Double  '			decimal
        Public TG0740 As String  '			nvarchar(255)
        Public QT0840 As Double  '			decimal
        Public TG0840 As String  '			nvarchar(255)
        Public QT0940 As Double  '			decimal
        Public TG0940 As String  '			nvarchar(255)
        Public QT1040 As Double  '			decimal
        Public TG1040 As String  '			nvarchar(255)
        Public QT1140 As Double  '			decimal
        Public TG1140 As String  '			nvarchar(255)
        Public QT1240 As Double  '			decimal
        Public TG1240 As String  '			nvarchar(255)
        Public QT1340 As Double  '			decimal
        Public TG1340 As String  '			nvarchar(255)
        Public QT1440 As Double  '			decimal
        Public TG1440 As String  '			nvarchar(255)
        Public QT1540 As Double  '			decimal
        Public TG1540 As String  '			nvarchar(255)
        Public QT1640 As Double  '			decimal
        Public TG1640 As String  '			nvarchar(255)
        Public QT1740 As Double  '			decimal
        Public TG1740 As String  '			nvarchar(255)
        Public QT1840 As Double  '			decimal
        Public TG1840 As String  '			nvarchar(255)
        Public QT1940 As Double  '			decimal
        Public TG1940 As String  '			nvarchar(255)
        Public QT2040 As Double  '			decimal
        Public TG2040 As String  '			nvarchar(255)
        Public QT2140 As Double  '			decimal
        Public TG2140 As String  '			nvarchar(255)
        Public QT2240 As Double  '			decimal
        Public TG2240 As String  '			nvarchar(255)
        Public QT2340 As Double  '			decimal
        Public TG2340 As String  '			nvarchar(255)
        Public QT2440 As Double  '			decimal
        Public TG2440 As String  '			nvarchar(255)
        Public QT2540 As Double  '			decimal
        Public TG2540 As String  '			nvarchar(255)
        Public QT2640 As Double  '			decimal
        Public TG2640 As String  '			nvarchar(255)
        Public TPKO40 As String  '			nvarchar(255)
        Public DTPK40 As String  '			nvarchar(255)
        '=========================================================================================================================================================
    End Structure

    Public D0000 As T0000_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK0000(AUTOKEY As Double) As Boolean
        READ_PFK0000 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK0000 "
            SQL = SQL & " WHERE K0000_Autokey		 =  " & Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D0000_CLEAR() : GoTo SKIP_READ_PFK0000

            Call K0000_MOVE(rd)
            READ_PFK0000 = True

SKIP_READ_PFK0000:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK0000", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK0000(AUTOKEY As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK0000 "
            SQL = SQL & " WHERE K0000_Autokey		 =  " & Autokey & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK0000", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK0000(z0000 As T0000_AREA) As Boolean
        WRITE_PFK0000 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z0000)

            SQL = " INSERT INTO PFK0000 "
            SQL = SQL & " ( "
            SQL = SQL & " K0000_PackingBatch,"
            SQL = SQL & " K0000_ENTE40,"
            SQL = SQL & " K0000_SAOI40,"
            SQL = SQL & " K0000_NROI40,"
            SQL = SQL & " K0000_MACO40,"
            SQL = SQL & " K0000_SSCO40,"
            SQL = SQL & " K0000_AACO40,"
            SQL = SQL & " K0000_NUCO40,"
            SQL = SQL & " K0000_INCO40,"
            SQL = SQL & " K0000_NULA40,"
            SQL = SQL & " K0000_TQQT40,"
            SQL = SQL & " K0000_QT0140,"
            SQL = SQL & " K0000_TG0140,"
            SQL = SQL & " K0000_QT0240,"
            SQL = SQL & " K0000_TG0240,"
            SQL = SQL & " K0000_QT0340,"
            SQL = SQL & " K0000_TG0340,"
            SQL = SQL & " K0000_QT0440,"
            SQL = SQL & " K0000_TG0440,"
            SQL = SQL & " K0000_QT0540,"
            SQL = SQL & " K0000_TG0540,"
            SQL = SQL & " K0000_QT0640,"
            SQL = SQL & " K0000_TG0640,"
            SQL = SQL & " K0000_QT0740,"
            SQL = SQL & " K0000_TG0740,"
            SQL = SQL & " K0000_QT0840,"
            SQL = SQL & " K0000_TG0840,"
            SQL = SQL & " K0000_QT0940,"
            SQL = SQL & " K0000_TG0940,"
            SQL = SQL & " K0000_QT1040,"
            SQL = SQL & " K0000_TG1040,"
            SQL = SQL & " K0000_QT1140,"
            SQL = SQL & " K0000_TG1140,"
            SQL = SQL & " K0000_QT1240,"
            SQL = SQL & " K0000_TG1240,"
            SQL = SQL & " K0000_QT1340,"
            SQL = SQL & " K0000_TG1340,"
            SQL = SQL & " K0000_QT1440,"
            SQL = SQL & " K0000_TG1440,"
            SQL = SQL & " K0000_QT1540,"
            SQL = SQL & " K0000_TG1540,"
            SQL = SQL & " K0000_QT1640,"
            SQL = SQL & " K0000_TG1640,"
            SQL = SQL & " K0000_QT1740,"
            SQL = SQL & " K0000_TG1740,"
            SQL = SQL & " K0000_QT1840,"
            SQL = SQL & " K0000_TG1840,"
            SQL = SQL & " K0000_QT1940,"
            SQL = SQL & " K0000_TG1940,"
            SQL = SQL & " K0000_QT2040,"
            SQL = SQL & " K0000_TG2040,"
            SQL = SQL & " K0000_QT2140,"
            SQL = SQL & " K0000_TG2140,"
            SQL = SQL & " K0000_QT2240,"
            SQL = SQL & " K0000_TG2240,"
            SQL = SQL & " K0000_QT2340,"
            SQL = SQL & " K0000_TG2340,"
            SQL = SQL & " K0000_QT2440,"
            SQL = SQL & " K0000_TG2440,"
            SQL = SQL & " K0000_QT2540,"
            SQL = SQL & " K0000_TG2540,"
            SQL = SQL & " K0000_QT2640,"
            SQL = SQL & " K0000_TG2640,"
            SQL = SQL & " K0000_TPKO40,"
            SQL = SQL & " K0000_DTPK40 "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z0000.PackingBatch) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0000.ENTE40) & "', "
            SQL = SQL & "   " & FormatSQL(z0000.SAOI40) & ", "
            SQL = SQL & "   " & FormatSQL(z0000.NROI40) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0000.MACO40) & "', "
            SQL = SQL & "   " & FormatSQL(z0000.SSCO40) & ", "
            SQL = SQL & "   " & FormatSQL(z0000.AACO40) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0000.NUCO40) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0000.INCO40) & "', "
            SQL = SQL & "   " & FormatSQL(z0000.NULA40) & ", "
            SQL = SQL & "   " & FormatSQL(z0000.TQQT40) & ", "
            SQL = SQL & "   " & FormatSQL(z0000.QT0140) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0000.TG0140) & "', "
            SQL = SQL & "   " & FormatSQL(z0000.QT0240) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0000.TG0240) & "', "
            SQL = SQL & "   " & FormatSQL(z0000.QT0340) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0000.TG0340) & "', "
            SQL = SQL & "   " & FormatSQL(z0000.QT0440) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0000.TG0440) & "', "
            SQL = SQL & "   " & FormatSQL(z0000.QT0540) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0000.TG0540) & "', "
            SQL = SQL & "   " & FormatSQL(z0000.QT0640) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0000.TG0640) & "', "
            SQL = SQL & "   " & FormatSQL(z0000.QT0740) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0000.TG0740) & "', "
            SQL = SQL & "   " & FormatSQL(z0000.QT0840) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0000.TG0840) & "', "
            SQL = SQL & "   " & FormatSQL(z0000.QT0940) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0000.TG0940) & "', "
            SQL = SQL & "   " & FormatSQL(z0000.QT1040) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0000.TG1040) & "', "
            SQL = SQL & "   " & FormatSQL(z0000.QT1140) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0000.TG1140) & "', "
            SQL = SQL & "   " & FormatSQL(z0000.QT1240) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0000.TG1240) & "', "
            SQL = SQL & "   " & FormatSQL(z0000.QT1340) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0000.TG1340) & "', "
            SQL = SQL & "   " & FormatSQL(z0000.QT1440) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0000.TG1440) & "', "
            SQL = SQL & "   " & FormatSQL(z0000.QT1540) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0000.TG1540) & "', "
            SQL = SQL & "   " & FormatSQL(z0000.QT1640) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0000.TG1640) & "', "
            SQL = SQL & "   " & FormatSQL(z0000.QT1740) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0000.TG1740) & "', "
            SQL = SQL & "   " & FormatSQL(z0000.QT1840) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0000.TG1840) & "', "
            SQL = SQL & "   " & FormatSQL(z0000.QT1940) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0000.TG1940) & "', "
            SQL = SQL & "   " & FormatSQL(z0000.QT2040) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0000.TG2040) & "', "
            SQL = SQL & "   " & FormatSQL(z0000.QT2140) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0000.TG2140) & "', "
            SQL = SQL & "   " & FormatSQL(z0000.QT2240) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0000.TG2240) & "', "
            SQL = SQL & "   " & FormatSQL(z0000.QT2340) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0000.TG2340) & "', "
            SQL = SQL & "   " & FormatSQL(z0000.QT2440) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0000.TG2440) & "', "
            SQL = SQL & "   " & FormatSQL(z0000.QT2540) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0000.TG2540) & "', "
            SQL = SQL & "   " & FormatSQL(z0000.QT2640) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0000.TG2640) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0000.TPKO40) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0000.DTPK40) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK0000 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK0000", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK0000(z0000 As T0000_AREA) As Boolean
        REWRITE_PFK0000 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z0000)

            SQL = " UPDATE PFK0000 SET "
            SQL = SQL & "    K0000_PackingBatch      = N'" & FormatSQL(z0000.PackingBatch) & "', "
            SQL = SQL & "    K0000_ENTE40      = N'" & FormatSQL(z0000.ENTE40) & "', "
            SQL = SQL & "    K0000_SAOI40      =  " & FormatSQL(z0000.SAOI40) & ", "
            SQL = SQL & "    K0000_NROI40      =  " & FormatSQL(z0000.NROI40) & ", "
            SQL = SQL & "    K0000_MACO40      = N'" & FormatSQL(z0000.MACO40) & "', "
            SQL = SQL & "    K0000_SSCO40      =  " & FormatSQL(z0000.SSCO40) & ", "
            SQL = SQL & "    K0000_AACO40      =  " & FormatSQL(z0000.AACO40) & ", "
            SQL = SQL & "    K0000_NUCO40      = N'" & FormatSQL(z0000.NUCO40) & "', "
            SQL = SQL & "    K0000_INCO40      = N'" & FormatSQL(z0000.INCO40) & "', "
            SQL = SQL & "    K0000_NULA40      =  " & FormatSQL(z0000.NULA40) & ", "
            SQL = SQL & "    K0000_TQQT40      =  " & FormatSQL(z0000.TQQT40) & ", "
            SQL = SQL & "    K0000_QT0140      =  " & FormatSQL(z0000.QT0140) & ", "
            SQL = SQL & "    K0000_TG0140      = N'" & FormatSQL(z0000.TG0140) & "', "
            SQL = SQL & "    K0000_QT0240      =  " & FormatSQL(z0000.QT0240) & ", "
            SQL = SQL & "    K0000_TG0240      = N'" & FormatSQL(z0000.TG0240) & "', "
            SQL = SQL & "    K0000_QT0340      =  " & FormatSQL(z0000.QT0340) & ", "
            SQL = SQL & "    K0000_TG0340      = N'" & FormatSQL(z0000.TG0340) & "', "
            SQL = SQL & "    K0000_QT0440      =  " & FormatSQL(z0000.QT0440) & ", "
            SQL = SQL & "    K0000_TG0440      = N'" & FormatSQL(z0000.TG0440) & "', "
            SQL = SQL & "    K0000_QT0540      =  " & FormatSQL(z0000.QT0540) & ", "
            SQL = SQL & "    K0000_TG0540      = N'" & FormatSQL(z0000.TG0540) & "', "
            SQL = SQL & "    K0000_QT0640      =  " & FormatSQL(z0000.QT0640) & ", "
            SQL = SQL & "    K0000_TG0640      = N'" & FormatSQL(z0000.TG0640) & "', "
            SQL = SQL & "    K0000_QT0740      =  " & FormatSQL(z0000.QT0740) & ", "
            SQL = SQL & "    K0000_TG0740      = N'" & FormatSQL(z0000.TG0740) & "', "
            SQL = SQL & "    K0000_QT0840      =  " & FormatSQL(z0000.QT0840) & ", "
            SQL = SQL & "    K0000_TG0840      = N'" & FormatSQL(z0000.TG0840) & "', "
            SQL = SQL & "    K0000_QT0940      =  " & FormatSQL(z0000.QT0940) & ", "
            SQL = SQL & "    K0000_TG0940      = N'" & FormatSQL(z0000.TG0940) & "', "
            SQL = SQL & "    K0000_QT1040      =  " & FormatSQL(z0000.QT1040) & ", "
            SQL = SQL & "    K0000_TG1040      = N'" & FormatSQL(z0000.TG1040) & "', "
            SQL = SQL & "    K0000_QT1140      =  " & FormatSQL(z0000.QT1140) & ", "
            SQL = SQL & "    K0000_TG1140      = N'" & FormatSQL(z0000.TG1140) & "', "
            SQL = SQL & "    K0000_QT1240      =  " & FormatSQL(z0000.QT1240) & ", "
            SQL = SQL & "    K0000_TG1240      = N'" & FormatSQL(z0000.TG1240) & "', "
            SQL = SQL & "    K0000_QT1340      =  " & FormatSQL(z0000.QT1340) & ", "
            SQL = SQL & "    K0000_TG1340      = N'" & FormatSQL(z0000.TG1340) & "', "
            SQL = SQL & "    K0000_QT1440      =  " & FormatSQL(z0000.QT1440) & ", "
            SQL = SQL & "    K0000_TG1440      = N'" & FormatSQL(z0000.TG1440) & "', "
            SQL = SQL & "    K0000_QT1540      =  " & FormatSQL(z0000.QT1540) & ", "
            SQL = SQL & "    K0000_TG1540      = N'" & FormatSQL(z0000.TG1540) & "', "
            SQL = SQL & "    K0000_QT1640      =  " & FormatSQL(z0000.QT1640) & ", "
            SQL = SQL & "    K0000_TG1640      = N'" & FormatSQL(z0000.TG1640) & "', "
            SQL = SQL & "    K0000_QT1740      =  " & FormatSQL(z0000.QT1740) & ", "
            SQL = SQL & "    K0000_TG1740      = N'" & FormatSQL(z0000.TG1740) & "', "
            SQL = SQL & "    K0000_QT1840      =  " & FormatSQL(z0000.QT1840) & ", "
            SQL = SQL & "    K0000_TG1840      = N'" & FormatSQL(z0000.TG1840) & "', "
            SQL = SQL & "    K0000_QT1940      =  " & FormatSQL(z0000.QT1940) & ", "
            SQL = SQL & "    K0000_TG1940      = N'" & FormatSQL(z0000.TG1940) & "', "
            SQL = SQL & "    K0000_QT2040      =  " & FormatSQL(z0000.QT2040) & ", "
            SQL = SQL & "    K0000_TG2040      = N'" & FormatSQL(z0000.TG2040) & "', "
            SQL = SQL & "    K0000_QT2140      =  " & FormatSQL(z0000.QT2140) & ", "
            SQL = SQL & "    K0000_TG2140      = N'" & FormatSQL(z0000.TG2140) & "', "
            SQL = SQL & "    K0000_QT2240      =  " & FormatSQL(z0000.QT2240) & ", "
            SQL = SQL & "    K0000_TG2240      = N'" & FormatSQL(z0000.TG2240) & "', "
            SQL = SQL & "    K0000_QT2340      =  " & FormatSQL(z0000.QT2340) & ", "
            SQL = SQL & "    K0000_TG2340      = N'" & FormatSQL(z0000.TG2340) & "', "
            SQL = SQL & "    K0000_QT2440      =  " & FormatSQL(z0000.QT2440) & ", "
            SQL = SQL & "    K0000_TG2440      = N'" & FormatSQL(z0000.TG2440) & "', "
            SQL = SQL & "    K0000_QT2540      =  " & FormatSQL(z0000.QT2540) & ", "
            SQL = SQL & "    K0000_TG2540      = N'" & FormatSQL(z0000.TG2540) & "', "
            SQL = SQL & "    K0000_QT2640      =  " & FormatSQL(z0000.QT2640) & ", "
            SQL = SQL & "    K0000_TG2640      = N'" & FormatSQL(z0000.TG2640) & "', "
            SQL = SQL & "    K0000_TPKO40      = N'" & FormatSQL(z0000.TPKO40) & "', "
            SQL = SQL & "    K0000_DTPK40      = N'" & FormatSQL(z0000.DTPK40) & "'  "
            SQL = SQL & " WHERE K0000_Autokey		 =  " & z0000.Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK0000 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK0000", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK0000(z0000 As T0000_AREA) As Boolean
        DELETE_PFK0000 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK0000 "
            SQL = SQL & " WHERE K0000_Autokey		 =  " & z0000.Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK0000 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK0000", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D0000_CLEAR()
        Try

            D0000.Autokey = 0
            D0000.PackingBatch = ""
            D0000.ENTE40 = ""
            D0000.SAOI40 = 0
            D0000.NROI40 = 0
            D0000.MACO40 = ""
            D0000.SSCO40 = 0
            D0000.AACO40 = 0
            D0000.NUCO40 = ""
            D0000.INCO40 = ""
            D0000.NULA40 = 0
            D0000.TQQT40 = 0
            D0000.QT0140 = 0
            D0000.TG0140 = ""
            D0000.QT0240 = 0
            D0000.TG0240 = ""
            D0000.QT0340 = 0
            D0000.TG0340 = ""
            D0000.QT0440 = 0
            D0000.TG0440 = ""
            D0000.QT0540 = 0
            D0000.TG0540 = ""
            D0000.QT0640 = 0
            D0000.TG0640 = ""
            D0000.QT0740 = 0
            D0000.TG0740 = ""
            D0000.QT0840 = 0
            D0000.TG0840 = ""
            D0000.QT0940 = 0
            D0000.TG0940 = ""
            D0000.QT1040 = 0
            D0000.TG1040 = ""
            D0000.QT1140 = 0
            D0000.TG1140 = ""
            D0000.QT1240 = 0
            D0000.TG1240 = ""
            D0000.QT1340 = 0
            D0000.TG1340 = ""
            D0000.QT1440 = 0
            D0000.TG1440 = ""
            D0000.QT1540 = 0
            D0000.TG1540 = ""
            D0000.QT1640 = 0
            D0000.TG1640 = ""
            D0000.QT1740 = 0
            D0000.TG1740 = ""
            D0000.QT1840 = 0
            D0000.TG1840 = ""
            D0000.QT1940 = 0
            D0000.TG1940 = ""
            D0000.QT2040 = 0
            D0000.TG2040 = ""
            D0000.QT2140 = 0
            D0000.TG2140 = ""
            D0000.QT2240 = 0
            D0000.TG2240 = ""
            D0000.QT2340 = 0
            D0000.TG2340 = ""
            D0000.QT2440 = 0
            D0000.TG2440 = ""
            D0000.QT2540 = 0
            D0000.TG2540 = ""
            D0000.QT2640 = 0
            D0000.TG2640 = ""
            D0000.TPKO40 = ""
            D0000.DTPK40 = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D0000_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x0000 As T0000_AREA)
        Try

            x0000.Autokey = trim$(x0000.Autokey)
            x0000.PackingBatch = trim$(x0000.PackingBatch)
            x0000.ENTE40 = trim$(x0000.ENTE40)
            x0000.SAOI40 = trim$(x0000.SAOI40)
            x0000.NROI40 = trim$(x0000.NROI40)
            x0000.MACO40 = trim$(x0000.MACO40)
            x0000.SSCO40 = trim$(x0000.SSCO40)
            x0000.AACO40 = trim$(x0000.AACO40)
            x0000.NUCO40 = trim$(x0000.NUCO40)
            x0000.INCO40 = trim$(x0000.INCO40)
            x0000.NULA40 = trim$(x0000.NULA40)
            x0000.TQQT40 = trim$(x0000.TQQT40)
            x0000.QT0140 = trim$(x0000.QT0140)
            x0000.TG0140 = trim$(x0000.TG0140)
            x0000.QT0240 = trim$(x0000.QT0240)
            x0000.TG0240 = trim$(x0000.TG0240)
            x0000.QT0340 = trim$(x0000.QT0340)
            x0000.TG0340 = trim$(x0000.TG0340)
            x0000.QT0440 = trim$(x0000.QT0440)
            x0000.TG0440 = trim$(x0000.TG0440)
            x0000.QT0540 = trim$(x0000.QT0540)
            x0000.TG0540 = trim$(x0000.TG0540)
            x0000.QT0640 = trim$(x0000.QT0640)
            x0000.TG0640 = trim$(x0000.TG0640)
            x0000.QT0740 = trim$(x0000.QT0740)
            x0000.TG0740 = trim$(x0000.TG0740)
            x0000.QT0840 = trim$(x0000.QT0840)
            x0000.TG0840 = trim$(x0000.TG0840)
            x0000.QT0940 = trim$(x0000.QT0940)
            x0000.TG0940 = trim$(x0000.TG0940)
            x0000.QT1040 = trim$(x0000.QT1040)
            x0000.TG1040 = trim$(x0000.TG1040)
            x0000.QT1140 = trim$(x0000.QT1140)
            x0000.TG1140 = trim$(x0000.TG1140)
            x0000.QT1240 = trim$(x0000.QT1240)
            x0000.TG1240 = trim$(x0000.TG1240)
            x0000.QT1340 = trim$(x0000.QT1340)
            x0000.TG1340 = trim$(x0000.TG1340)
            x0000.QT1440 = trim$(x0000.QT1440)
            x0000.TG1440 = trim$(x0000.TG1440)
            x0000.QT1540 = trim$(x0000.QT1540)
            x0000.TG1540 = trim$(x0000.TG1540)
            x0000.QT1640 = trim$(x0000.QT1640)
            x0000.TG1640 = trim$(x0000.TG1640)
            x0000.QT1740 = trim$(x0000.QT1740)
            x0000.TG1740 = trim$(x0000.TG1740)
            x0000.QT1840 = trim$(x0000.QT1840)
            x0000.TG1840 = trim$(x0000.TG1840)
            x0000.QT1940 = trim$(x0000.QT1940)
            x0000.TG1940 = trim$(x0000.TG1940)
            x0000.QT2040 = trim$(x0000.QT2040)
            x0000.TG2040 = trim$(x0000.TG2040)
            x0000.QT2140 = trim$(x0000.QT2140)
            x0000.TG2140 = trim$(x0000.TG2140)
            x0000.QT2240 = trim$(x0000.QT2240)
            x0000.TG2240 = trim$(x0000.TG2240)
            x0000.QT2340 = trim$(x0000.QT2340)
            x0000.TG2340 = trim$(x0000.TG2340)
            x0000.QT2440 = trim$(x0000.QT2440)
            x0000.TG2440 = trim$(x0000.TG2440)
            x0000.QT2540 = trim$(x0000.QT2540)
            x0000.TG2540 = trim$(x0000.TG2540)
            x0000.QT2640 = trim$(x0000.QT2640)
            x0000.TG2640 = trim$(x0000.TG2640)
            x0000.TPKO40 = trim$(x0000.TPKO40)
            x0000.DTPK40 = trim$(x0000.DTPK40)

            If trim$(x0000.Autokey) = "" Then x0000.Autokey = 0
            If trim$(x0000.PackingBatch) = "" Then x0000.PackingBatch = Space(1)
            If trim$(x0000.ENTE40) = "" Then x0000.ENTE40 = Space(1)
            If trim$(x0000.SAOI40) = "" Then x0000.SAOI40 = 0
            If trim$(x0000.NROI40) = "" Then x0000.NROI40 = 0
            If trim$(x0000.MACO40) = "" Then x0000.MACO40 = Space(1)
            If trim$(x0000.SSCO40) = "" Then x0000.SSCO40 = 0
            If trim$(x0000.AACO40) = "" Then x0000.AACO40 = 0
            If trim$(x0000.NUCO40) = "" Then x0000.NUCO40 = Space(1)
            If trim$(x0000.INCO40) = "" Then x0000.INCO40 = Space(1)
            If trim$(x0000.NULA40) = "" Then x0000.NULA40 = 0
            If trim$(x0000.TQQT40) = "" Then x0000.TQQT40 = 0
            If trim$(x0000.QT0140) = "" Then x0000.QT0140 = 0
            If trim$(x0000.TG0140) = "" Then x0000.TG0140 = Space(1)
            If trim$(x0000.QT0240) = "" Then x0000.QT0240 = 0
            If trim$(x0000.TG0240) = "" Then x0000.TG0240 = Space(1)
            If trim$(x0000.QT0340) = "" Then x0000.QT0340 = 0
            If trim$(x0000.TG0340) = "" Then x0000.TG0340 = Space(1)
            If trim$(x0000.QT0440) = "" Then x0000.QT0440 = 0
            If trim$(x0000.TG0440) = "" Then x0000.TG0440 = Space(1)
            If trim$(x0000.QT0540) = "" Then x0000.QT0540 = 0
            If trim$(x0000.TG0540) = "" Then x0000.TG0540 = Space(1)
            If trim$(x0000.QT0640) = "" Then x0000.QT0640 = 0
            If trim$(x0000.TG0640) = "" Then x0000.TG0640 = Space(1)
            If trim$(x0000.QT0740) = "" Then x0000.QT0740 = 0
            If trim$(x0000.TG0740) = "" Then x0000.TG0740 = Space(1)
            If trim$(x0000.QT0840) = "" Then x0000.QT0840 = 0
            If trim$(x0000.TG0840) = "" Then x0000.TG0840 = Space(1)
            If trim$(x0000.QT0940) = "" Then x0000.QT0940 = 0
            If trim$(x0000.TG0940) = "" Then x0000.TG0940 = Space(1)
            If trim$(x0000.QT1040) = "" Then x0000.QT1040 = 0
            If trim$(x0000.TG1040) = "" Then x0000.TG1040 = Space(1)
            If trim$(x0000.QT1140) = "" Then x0000.QT1140 = 0
            If trim$(x0000.TG1140) = "" Then x0000.TG1140 = Space(1)
            If trim$(x0000.QT1240) = "" Then x0000.QT1240 = 0
            If trim$(x0000.TG1240) = "" Then x0000.TG1240 = Space(1)
            If trim$(x0000.QT1340) = "" Then x0000.QT1340 = 0
            If trim$(x0000.TG1340) = "" Then x0000.TG1340 = Space(1)
            If trim$(x0000.QT1440) = "" Then x0000.QT1440 = 0
            If trim$(x0000.TG1440) = "" Then x0000.TG1440 = Space(1)
            If trim$(x0000.QT1540) = "" Then x0000.QT1540 = 0
            If trim$(x0000.TG1540) = "" Then x0000.TG1540 = Space(1)
            If trim$(x0000.QT1640) = "" Then x0000.QT1640 = 0
            If trim$(x0000.TG1640) = "" Then x0000.TG1640 = Space(1)
            If trim$(x0000.QT1740) = "" Then x0000.QT1740 = 0
            If trim$(x0000.TG1740) = "" Then x0000.TG1740 = Space(1)
            If trim$(x0000.QT1840) = "" Then x0000.QT1840 = 0
            If trim$(x0000.TG1840) = "" Then x0000.TG1840 = Space(1)
            If trim$(x0000.QT1940) = "" Then x0000.QT1940 = 0
            If trim$(x0000.TG1940) = "" Then x0000.TG1940 = Space(1)
            If trim$(x0000.QT2040) = "" Then x0000.QT2040 = 0
            If trim$(x0000.TG2040) = "" Then x0000.TG2040 = Space(1)
            If trim$(x0000.QT2140) = "" Then x0000.QT2140 = 0
            If trim$(x0000.TG2140) = "" Then x0000.TG2140 = Space(1)
            If trim$(x0000.QT2240) = "" Then x0000.QT2240 = 0
            If trim$(x0000.TG2240) = "" Then x0000.TG2240 = Space(1)
            If trim$(x0000.QT2340) = "" Then x0000.QT2340 = 0
            If trim$(x0000.TG2340) = "" Then x0000.TG2340 = Space(1)
            If trim$(x0000.QT2440) = "" Then x0000.QT2440 = 0
            If trim$(x0000.TG2440) = "" Then x0000.TG2440 = Space(1)
            If trim$(x0000.QT2540) = "" Then x0000.QT2540 = 0
            If trim$(x0000.TG2540) = "" Then x0000.TG2540 = Space(1)
            If trim$(x0000.QT2640) = "" Then x0000.QT2640 = 0
            If trim$(x0000.TG2640) = "" Then x0000.TG2640 = Space(1)
            If trim$(x0000.TPKO40) = "" Then x0000.TPKO40 = Space(1)
            If trim$(x0000.DTPK40) = "" Then x0000.DTPK40 = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K0000_MOVE(rs0000 As SqlClient.SqlDataReader)
        Try

            Call D0000_CLEAR()

            If IsdbNull(rs0000!K0000_Autokey) = False Then D0000.Autokey = Trim$(rs0000!K0000_Autokey)
            If IsdbNull(rs0000!K0000_PackingBatch) = False Then D0000.PackingBatch = Trim$(rs0000!K0000_PackingBatch)
            If IsdbNull(rs0000!K0000_ENTE40) = False Then D0000.ENTE40 = Trim$(rs0000!K0000_ENTE40)
            If IsdbNull(rs0000!K0000_SAOI40) = False Then D0000.SAOI40 = Trim$(rs0000!K0000_SAOI40)
            If IsdbNull(rs0000!K0000_NROI40) = False Then D0000.NROI40 = Trim$(rs0000!K0000_NROI40)
            If IsdbNull(rs0000!K0000_MACO40) = False Then D0000.MACO40 = Trim$(rs0000!K0000_MACO40)
            If IsdbNull(rs0000!K0000_SSCO40) = False Then D0000.SSCO40 = Trim$(rs0000!K0000_SSCO40)
            If IsdbNull(rs0000!K0000_AACO40) = False Then D0000.AACO40 = Trim$(rs0000!K0000_AACO40)
            If IsdbNull(rs0000!K0000_NUCO40) = False Then D0000.NUCO40 = Trim$(rs0000!K0000_NUCO40)
            If IsdbNull(rs0000!K0000_INCO40) = False Then D0000.INCO40 = Trim$(rs0000!K0000_INCO40)
            If IsdbNull(rs0000!K0000_NULA40) = False Then D0000.NULA40 = Trim$(rs0000!K0000_NULA40)
            If IsdbNull(rs0000!K0000_TQQT40) = False Then D0000.TQQT40 = Trim$(rs0000!K0000_TQQT40)
            If IsdbNull(rs0000!K0000_QT0140) = False Then D0000.QT0140 = Trim$(rs0000!K0000_QT0140)
            If IsdbNull(rs0000!K0000_TG0140) = False Then D0000.TG0140 = Trim$(rs0000!K0000_TG0140)
            If IsdbNull(rs0000!K0000_QT0240) = False Then D0000.QT0240 = Trim$(rs0000!K0000_QT0240)
            If IsdbNull(rs0000!K0000_TG0240) = False Then D0000.TG0240 = Trim$(rs0000!K0000_TG0240)
            If IsdbNull(rs0000!K0000_QT0340) = False Then D0000.QT0340 = Trim$(rs0000!K0000_QT0340)
            If IsdbNull(rs0000!K0000_TG0340) = False Then D0000.TG0340 = Trim$(rs0000!K0000_TG0340)
            If IsdbNull(rs0000!K0000_QT0440) = False Then D0000.QT0440 = Trim$(rs0000!K0000_QT0440)
            If IsdbNull(rs0000!K0000_TG0440) = False Then D0000.TG0440 = Trim$(rs0000!K0000_TG0440)
            If IsdbNull(rs0000!K0000_QT0540) = False Then D0000.QT0540 = Trim$(rs0000!K0000_QT0540)
            If IsdbNull(rs0000!K0000_TG0540) = False Then D0000.TG0540 = Trim$(rs0000!K0000_TG0540)
            If IsdbNull(rs0000!K0000_QT0640) = False Then D0000.QT0640 = Trim$(rs0000!K0000_QT0640)
            If IsdbNull(rs0000!K0000_TG0640) = False Then D0000.TG0640 = Trim$(rs0000!K0000_TG0640)
            If IsdbNull(rs0000!K0000_QT0740) = False Then D0000.QT0740 = Trim$(rs0000!K0000_QT0740)
            If IsdbNull(rs0000!K0000_TG0740) = False Then D0000.TG0740 = Trim$(rs0000!K0000_TG0740)
            If IsdbNull(rs0000!K0000_QT0840) = False Then D0000.QT0840 = Trim$(rs0000!K0000_QT0840)
            If IsdbNull(rs0000!K0000_TG0840) = False Then D0000.TG0840 = Trim$(rs0000!K0000_TG0840)
            If IsdbNull(rs0000!K0000_QT0940) = False Then D0000.QT0940 = Trim$(rs0000!K0000_QT0940)
            If IsdbNull(rs0000!K0000_TG0940) = False Then D0000.TG0940 = Trim$(rs0000!K0000_TG0940)
            If IsdbNull(rs0000!K0000_QT1040) = False Then D0000.QT1040 = Trim$(rs0000!K0000_QT1040)
            If IsdbNull(rs0000!K0000_TG1040) = False Then D0000.TG1040 = Trim$(rs0000!K0000_TG1040)
            If IsdbNull(rs0000!K0000_QT1140) = False Then D0000.QT1140 = Trim$(rs0000!K0000_QT1140)
            If IsdbNull(rs0000!K0000_TG1140) = False Then D0000.TG1140 = Trim$(rs0000!K0000_TG1140)
            If IsdbNull(rs0000!K0000_QT1240) = False Then D0000.QT1240 = Trim$(rs0000!K0000_QT1240)
            If IsdbNull(rs0000!K0000_TG1240) = False Then D0000.TG1240 = Trim$(rs0000!K0000_TG1240)
            If IsdbNull(rs0000!K0000_QT1340) = False Then D0000.QT1340 = Trim$(rs0000!K0000_QT1340)
            If IsdbNull(rs0000!K0000_TG1340) = False Then D0000.TG1340 = Trim$(rs0000!K0000_TG1340)
            If IsdbNull(rs0000!K0000_QT1440) = False Then D0000.QT1440 = Trim$(rs0000!K0000_QT1440)
            If IsdbNull(rs0000!K0000_TG1440) = False Then D0000.TG1440 = Trim$(rs0000!K0000_TG1440)
            If IsdbNull(rs0000!K0000_QT1540) = False Then D0000.QT1540 = Trim$(rs0000!K0000_QT1540)
            If IsdbNull(rs0000!K0000_TG1540) = False Then D0000.TG1540 = Trim$(rs0000!K0000_TG1540)
            If IsdbNull(rs0000!K0000_QT1640) = False Then D0000.QT1640 = Trim$(rs0000!K0000_QT1640)
            If IsdbNull(rs0000!K0000_TG1640) = False Then D0000.TG1640 = Trim$(rs0000!K0000_TG1640)
            If IsdbNull(rs0000!K0000_QT1740) = False Then D0000.QT1740 = Trim$(rs0000!K0000_QT1740)
            If IsdbNull(rs0000!K0000_TG1740) = False Then D0000.TG1740 = Trim$(rs0000!K0000_TG1740)
            If IsdbNull(rs0000!K0000_QT1840) = False Then D0000.QT1840 = Trim$(rs0000!K0000_QT1840)
            If IsdbNull(rs0000!K0000_TG1840) = False Then D0000.TG1840 = Trim$(rs0000!K0000_TG1840)
            If IsdbNull(rs0000!K0000_QT1940) = False Then D0000.QT1940 = Trim$(rs0000!K0000_QT1940)
            If IsdbNull(rs0000!K0000_TG1940) = False Then D0000.TG1940 = Trim$(rs0000!K0000_TG1940)
            If IsdbNull(rs0000!K0000_QT2040) = False Then D0000.QT2040 = Trim$(rs0000!K0000_QT2040)
            If IsdbNull(rs0000!K0000_TG2040) = False Then D0000.TG2040 = Trim$(rs0000!K0000_TG2040)
            If IsdbNull(rs0000!K0000_QT2140) = False Then D0000.QT2140 = Trim$(rs0000!K0000_QT2140)
            If IsdbNull(rs0000!K0000_TG2140) = False Then D0000.TG2140 = Trim$(rs0000!K0000_TG2140)
            If IsdbNull(rs0000!K0000_QT2240) = False Then D0000.QT2240 = Trim$(rs0000!K0000_QT2240)
            If IsdbNull(rs0000!K0000_TG2240) = False Then D0000.TG2240 = Trim$(rs0000!K0000_TG2240)
            If IsdbNull(rs0000!K0000_QT2340) = False Then D0000.QT2340 = Trim$(rs0000!K0000_QT2340)
            If IsdbNull(rs0000!K0000_TG2340) = False Then D0000.TG2340 = Trim$(rs0000!K0000_TG2340)
            If IsdbNull(rs0000!K0000_QT2440) = False Then D0000.QT2440 = Trim$(rs0000!K0000_QT2440)
            If IsdbNull(rs0000!K0000_TG2440) = False Then D0000.TG2440 = Trim$(rs0000!K0000_TG2440)
            If IsdbNull(rs0000!K0000_QT2540) = False Then D0000.QT2540 = Trim$(rs0000!K0000_QT2540)
            If IsdbNull(rs0000!K0000_TG2540) = False Then D0000.TG2540 = Trim$(rs0000!K0000_TG2540)
            If IsdbNull(rs0000!K0000_QT2640) = False Then D0000.QT2640 = Trim$(rs0000!K0000_QT2640)
            If IsdbNull(rs0000!K0000_TG2640) = False Then D0000.TG2640 = Trim$(rs0000!K0000_TG2640)
            If IsdbNull(rs0000!K0000_TPKO40) = False Then D0000.TPKO40 = Trim$(rs0000!K0000_TPKO40)
            If IsdbNull(rs0000!K0000_DTPK40) = False Then D0000.DTPK40 = Trim$(rs0000!K0000_DTPK40)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K0000_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K0000_MOVE(rs0000 As DataRow)
        Try

            Call D0000_CLEAR()

            If IsdbNull(rs0000!K0000_Autokey) = False Then D0000.Autokey = Trim$(rs0000!K0000_Autokey)
            If IsdbNull(rs0000!K0000_PackingBatch) = False Then D0000.PackingBatch = Trim$(rs0000!K0000_PackingBatch)
            If IsdbNull(rs0000!K0000_ENTE40) = False Then D0000.ENTE40 = Trim$(rs0000!K0000_ENTE40)
            If IsdbNull(rs0000!K0000_SAOI40) = False Then D0000.SAOI40 = Trim$(rs0000!K0000_SAOI40)
            If IsdbNull(rs0000!K0000_NROI40) = False Then D0000.NROI40 = Trim$(rs0000!K0000_NROI40)
            If IsdbNull(rs0000!K0000_MACO40) = False Then D0000.MACO40 = Trim$(rs0000!K0000_MACO40)
            If IsdbNull(rs0000!K0000_SSCO40) = False Then D0000.SSCO40 = Trim$(rs0000!K0000_SSCO40)
            If IsdbNull(rs0000!K0000_AACO40) = False Then D0000.AACO40 = Trim$(rs0000!K0000_AACO40)
            If IsdbNull(rs0000!K0000_NUCO40) = False Then D0000.NUCO40 = Trim$(rs0000!K0000_NUCO40)
            If IsdbNull(rs0000!K0000_INCO40) = False Then D0000.INCO40 = Trim$(rs0000!K0000_INCO40)
            If IsdbNull(rs0000!K0000_NULA40) = False Then D0000.NULA40 = Trim$(rs0000!K0000_NULA40)
            If IsdbNull(rs0000!K0000_TQQT40) = False Then D0000.TQQT40 = Trim$(rs0000!K0000_TQQT40)
            If IsdbNull(rs0000!K0000_QT0140) = False Then D0000.QT0140 = Trim$(rs0000!K0000_QT0140)
            If IsdbNull(rs0000!K0000_TG0140) = False Then D0000.TG0140 = Trim$(rs0000!K0000_TG0140)
            If IsdbNull(rs0000!K0000_QT0240) = False Then D0000.QT0240 = Trim$(rs0000!K0000_QT0240)
            If IsdbNull(rs0000!K0000_TG0240) = False Then D0000.TG0240 = Trim$(rs0000!K0000_TG0240)
            If IsdbNull(rs0000!K0000_QT0340) = False Then D0000.QT0340 = Trim$(rs0000!K0000_QT0340)
            If IsdbNull(rs0000!K0000_TG0340) = False Then D0000.TG0340 = Trim$(rs0000!K0000_TG0340)
            If IsdbNull(rs0000!K0000_QT0440) = False Then D0000.QT0440 = Trim$(rs0000!K0000_QT0440)
            If IsdbNull(rs0000!K0000_TG0440) = False Then D0000.TG0440 = Trim$(rs0000!K0000_TG0440)
            If IsdbNull(rs0000!K0000_QT0540) = False Then D0000.QT0540 = Trim$(rs0000!K0000_QT0540)
            If IsdbNull(rs0000!K0000_TG0540) = False Then D0000.TG0540 = Trim$(rs0000!K0000_TG0540)
            If IsdbNull(rs0000!K0000_QT0640) = False Then D0000.QT0640 = Trim$(rs0000!K0000_QT0640)
            If IsdbNull(rs0000!K0000_TG0640) = False Then D0000.TG0640 = Trim$(rs0000!K0000_TG0640)
            If IsdbNull(rs0000!K0000_QT0740) = False Then D0000.QT0740 = Trim$(rs0000!K0000_QT0740)
            If IsdbNull(rs0000!K0000_TG0740) = False Then D0000.TG0740 = Trim$(rs0000!K0000_TG0740)
            If IsdbNull(rs0000!K0000_QT0840) = False Then D0000.QT0840 = Trim$(rs0000!K0000_QT0840)
            If IsdbNull(rs0000!K0000_TG0840) = False Then D0000.TG0840 = Trim$(rs0000!K0000_TG0840)
            If IsdbNull(rs0000!K0000_QT0940) = False Then D0000.QT0940 = Trim$(rs0000!K0000_QT0940)
            If IsdbNull(rs0000!K0000_TG0940) = False Then D0000.TG0940 = Trim$(rs0000!K0000_TG0940)
            If IsdbNull(rs0000!K0000_QT1040) = False Then D0000.QT1040 = Trim$(rs0000!K0000_QT1040)
            If IsdbNull(rs0000!K0000_TG1040) = False Then D0000.TG1040 = Trim$(rs0000!K0000_TG1040)
            If IsdbNull(rs0000!K0000_QT1140) = False Then D0000.QT1140 = Trim$(rs0000!K0000_QT1140)
            If IsdbNull(rs0000!K0000_TG1140) = False Then D0000.TG1140 = Trim$(rs0000!K0000_TG1140)
            If IsdbNull(rs0000!K0000_QT1240) = False Then D0000.QT1240 = Trim$(rs0000!K0000_QT1240)
            If IsdbNull(rs0000!K0000_TG1240) = False Then D0000.TG1240 = Trim$(rs0000!K0000_TG1240)
            If IsdbNull(rs0000!K0000_QT1340) = False Then D0000.QT1340 = Trim$(rs0000!K0000_QT1340)
            If IsdbNull(rs0000!K0000_TG1340) = False Then D0000.TG1340 = Trim$(rs0000!K0000_TG1340)
            If IsdbNull(rs0000!K0000_QT1440) = False Then D0000.QT1440 = Trim$(rs0000!K0000_QT1440)
            If IsdbNull(rs0000!K0000_TG1440) = False Then D0000.TG1440 = Trim$(rs0000!K0000_TG1440)
            If IsdbNull(rs0000!K0000_QT1540) = False Then D0000.QT1540 = Trim$(rs0000!K0000_QT1540)
            If IsdbNull(rs0000!K0000_TG1540) = False Then D0000.TG1540 = Trim$(rs0000!K0000_TG1540)
            If IsdbNull(rs0000!K0000_QT1640) = False Then D0000.QT1640 = Trim$(rs0000!K0000_QT1640)
            If IsdbNull(rs0000!K0000_TG1640) = False Then D0000.TG1640 = Trim$(rs0000!K0000_TG1640)
            If IsdbNull(rs0000!K0000_QT1740) = False Then D0000.QT1740 = Trim$(rs0000!K0000_QT1740)
            If IsdbNull(rs0000!K0000_TG1740) = False Then D0000.TG1740 = Trim$(rs0000!K0000_TG1740)
            If IsdbNull(rs0000!K0000_QT1840) = False Then D0000.QT1840 = Trim$(rs0000!K0000_QT1840)
            If IsdbNull(rs0000!K0000_TG1840) = False Then D0000.TG1840 = Trim$(rs0000!K0000_TG1840)
            If IsdbNull(rs0000!K0000_QT1940) = False Then D0000.QT1940 = Trim$(rs0000!K0000_QT1940)
            If IsdbNull(rs0000!K0000_TG1940) = False Then D0000.TG1940 = Trim$(rs0000!K0000_TG1940)
            If IsdbNull(rs0000!K0000_QT2040) = False Then D0000.QT2040 = Trim$(rs0000!K0000_QT2040)
            If IsdbNull(rs0000!K0000_TG2040) = False Then D0000.TG2040 = Trim$(rs0000!K0000_TG2040)
            If IsdbNull(rs0000!K0000_QT2140) = False Then D0000.QT2140 = Trim$(rs0000!K0000_QT2140)
            If IsdbNull(rs0000!K0000_TG2140) = False Then D0000.TG2140 = Trim$(rs0000!K0000_TG2140)
            If IsdbNull(rs0000!K0000_QT2240) = False Then D0000.QT2240 = Trim$(rs0000!K0000_QT2240)
            If IsdbNull(rs0000!K0000_TG2240) = False Then D0000.TG2240 = Trim$(rs0000!K0000_TG2240)
            If IsdbNull(rs0000!K0000_QT2340) = False Then D0000.QT2340 = Trim$(rs0000!K0000_QT2340)
            If IsdbNull(rs0000!K0000_TG2340) = False Then D0000.TG2340 = Trim$(rs0000!K0000_TG2340)
            If IsdbNull(rs0000!K0000_QT2440) = False Then D0000.QT2440 = Trim$(rs0000!K0000_QT2440)
            If IsdbNull(rs0000!K0000_TG2440) = False Then D0000.TG2440 = Trim$(rs0000!K0000_TG2440)
            If IsdbNull(rs0000!K0000_QT2540) = False Then D0000.QT2540 = Trim$(rs0000!K0000_QT2540)
            If IsdbNull(rs0000!K0000_TG2540) = False Then D0000.TG2540 = Trim$(rs0000!K0000_TG2540)
            If IsdbNull(rs0000!K0000_QT2640) = False Then D0000.QT2640 = Trim$(rs0000!K0000_QT2640)
            If IsdbNull(rs0000!K0000_TG2640) = False Then D0000.TG2640 = Trim$(rs0000!K0000_TG2640)
            If IsdbNull(rs0000!K0000_TPKO40) = False Then D0000.TPKO40 = Trim$(rs0000!K0000_TPKO40)
            If IsdbNull(rs0000!K0000_DTPK40) = False Then D0000.DTPK40 = Trim$(rs0000!K0000_DTPK40)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K0000_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
  
    
End Module 
