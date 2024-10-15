'=========================================================================================================================================================
'   TABLE : (PFK0001)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K0001

    Structure T0001_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public Autokey As Double  '			decimal		*
        Public PackingBatch As String  '			nvarchar(20)
        Public ENTE30 As String  '			nvarchar(255)
        Public SAOI30 As Double  '			decimal
        Public NROI30 As Double  '			decimal
        Public RGOI30 As Double  '			decimal
        Public TIVE30 As Double  '			decimal
        Public DTIV30 As String  '			nvarchar(255)
        Public DTEX30 As Double  '			decimal
        Public MDPR30 As String  '			nvarchar(255)
        Public CPAR30 As String  '			nvarchar(255)
        Public COL530 As String  '			nvarchar(255)
        Public ASSO30 As String  '			nvarchar(255)
        Public TQQT30 As Double  '			decimal
        Public QT0130 As Double  '			decimal
        Public TG0130 As String  '			nvarchar(255)
        Public QT0230 As Double  '			decimal
        Public TG0230 As String  '			nvarchar(255)
        Public QT0330 As Double  '			decimal
        Public TG0330 As String  '			nvarchar(255)
        Public QT0430 As Double  '			decimal
        Public TG0430 As String  '			nvarchar(255)
        Public QT0530 As Double  '			decimal
        Public TG0530 As String  '			nvarchar(255)
        Public QT0630 As Double  '			decimal
        Public TG0630 As String  '			nvarchar(255)
        Public QT0730 As Double  '			decimal
        Public TG0730 As String  '			nvarchar(255)
        Public QT0830 As Double  '			decimal
        Public TG0830 As String  '			nvarchar(255)
        Public QT0930 As Double  '			decimal
        Public TG0930 As String  '			nvarchar(255)
        Public QT1030 As Double  '			decimal
        Public TG1030 As String  '			nvarchar(255)
        Public QT1130 As Double  '			decimal
        Public TG1130 As String  '			nvarchar(255)
        Public QT1230 As Double  '			decimal
        Public TG1230 As String  '			nvarchar(255)
        Public QT1330 As Double  '			decimal
        Public TG1330 As String  '			nvarchar(255)
        Public QT1430 As Double  '			decimal
        Public TG1430 As String  '			nvarchar(255)
        Public QT1530 As Double  '			decimal
        Public TG1530 As String  '			nvarchar(255)
        Public QT1630 As Double  '			decimal
        Public TG1630 As String  '			nvarchar(255)
        Public QT1730 As Double  '			decimal
        Public TG1730 As String  '			nvarchar(255)
        Public QT1830 As Double  '			decimal
        Public TG1830 As String  '			nvarchar(255)
        Public QT1930 As Double  '			decimal
        Public TG1930 As String  '			nvarchar(255)
        Public QT2030 As Double  '			decimal
        Public TG2030 As String  '			nvarchar(255)
        Public QT2130 As Double  '			decimal
        Public TG2130 As String  '			nvarchar(255)
        Public QT2230 As Double  '			decimal
        Public TG2230 As String  '			nvarchar(255)
        Public QT2330 As Double  '			decimal
        Public TG2330 As String  '			nvarchar(255)
        Public QT2430 As Double  '			decimal
        Public TG2430 As String  '			nvarchar(255)
        Public QT2530 As Double  '			decimal
        Public TG2530 As String  '			nvarchar(255)
        Public QT2630 As Double  '			decimal
        Public TG2630 As String  '			nvarchar(255)
        Public TPKO30 As String  '			nvarchar(255)
        Public DTPK30 As String  '			nvarchar(255)
        Public CPC130 As String  '			nvarchar(255)
        Public CPCR30 As String  '			nvarchar(255)
        '=========================================================================================================================================================
    End Structure

    Public D0001 As T0001_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK0001(AUTOKEY As Double) As Boolean
        READ_PFK0001 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK0001 "
            SQL = SQL & " WHERE K0001_Autokey		 =  " & Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D0001_CLEAR() : GoTo SKIP_READ_PFK0001

            Call K0001_MOVE(rd)
            READ_PFK0001 = True

SKIP_READ_PFK0001:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK0001", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK0001(AUTOKEY As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK0001 "
            SQL = SQL & " WHERE K0001_Autokey		 =  " & Autokey & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK0001", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK0001(z0001 As T0001_AREA) As Boolean
        WRITE_PFK0001 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z0001)

            SQL = " INSERT INTO PFK0001 "
            SQL = SQL & " ( "
            SQL = SQL & " K0001_PackingBatch,"
            SQL = SQL & " K0001_ENTE30,"
            SQL = SQL & " K0001_SAOI30,"
            SQL = SQL & " K0001_NROI30,"
            SQL = SQL & " K0001_RGOI30,"
            SQL = SQL & " K0001_TIVE30,"
            SQL = SQL & " K0001_DTIV30,"
            SQL = SQL & " K0001_DTEX30,"
            SQL = SQL & " K0001_MDPR30,"
            SQL = SQL & " K0001_CPAR30,"
            SQL = SQL & " K0001_COL530,"
            SQL = SQL & " K0001_ASSO30,"
            SQL = SQL & " K0001_TQQT30,"
            SQL = SQL & " K0001_QT0130,"
            SQL = SQL & " K0001_TG0130,"
            SQL = SQL & " K0001_QT0230,"
            SQL = SQL & " K0001_TG0230,"
            SQL = SQL & " K0001_QT0330,"
            SQL = SQL & " K0001_TG0330,"
            SQL = SQL & " K0001_QT0430,"
            SQL = SQL & " K0001_TG0430,"
            SQL = SQL & " K0001_QT0530,"
            SQL = SQL & " K0001_TG0530,"
            SQL = SQL & " K0001_QT0630,"
            SQL = SQL & " K0001_TG0630,"
            SQL = SQL & " K0001_QT0730,"
            SQL = SQL & " K0001_TG0730,"
            SQL = SQL & " K0001_QT0830,"
            SQL = SQL & " K0001_TG0830,"
            SQL = SQL & " K0001_QT0930,"
            SQL = SQL & " K0001_TG0930,"
            SQL = SQL & " K0001_QT1030,"
            SQL = SQL & " K0001_TG1030,"
            SQL = SQL & " K0001_QT1130,"
            SQL = SQL & " K0001_TG1130,"
            SQL = SQL & " K0001_QT1230,"
            SQL = SQL & " K0001_TG1230,"
            SQL = SQL & " K0001_QT1330,"
            SQL = SQL & " K0001_TG1330,"
            SQL = SQL & " K0001_QT1430,"
            SQL = SQL & " K0001_TG1430,"
            SQL = SQL & " K0001_QT1530,"
            SQL = SQL & " K0001_TG1530,"
            SQL = SQL & " K0001_QT1630,"
            SQL = SQL & " K0001_TG1630,"
            SQL = SQL & " K0001_QT1730,"
            SQL = SQL & " K0001_TG1730,"
            SQL = SQL & " K0001_QT1830,"
            SQL = SQL & " K0001_TG1830,"
            SQL = SQL & " K0001_QT1930,"
            SQL = SQL & " K0001_TG1930,"
            SQL = SQL & " K0001_QT2030,"
            SQL = SQL & " K0001_TG2030,"
            SQL = SQL & " K0001_QT2130,"
            SQL = SQL & " K0001_TG2130,"
            SQL = SQL & " K0001_QT2230,"
            SQL = SQL & " K0001_TG2230,"
            SQL = SQL & " K0001_QT2330,"
            SQL = SQL & " K0001_TG2330,"
            SQL = SQL & " K0001_QT2430,"
            SQL = SQL & " K0001_TG2430,"
            SQL = SQL & " K0001_QT2530,"
            SQL = SQL & " K0001_TG2530,"
            SQL = SQL & " K0001_QT2630,"
            SQL = SQL & " K0001_TG2630,"
            SQL = SQL & " K0001_TPKO30,"
            SQL = SQL & " K0001_DTPK30,"
            SQL = SQL & " K0001_CPC130,"
            SQL = SQL & " K0001_CPCR30 "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z0001.PackingBatch) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0001.ENTE30) & "', "
            SQL = SQL & "   " & FormatSQL(z0001.SAOI30) & ", "
            SQL = SQL & "   " & FormatSQL(z0001.NROI30) & ", "
            SQL = SQL & "   " & FormatSQL(z0001.RGOI30) & ", "
            SQL = SQL & "   " & FormatSQL(z0001.TIVE30) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0001.DTIV30) & "', "
            SQL = SQL & "   " & FormatSQL(z0001.DTEX30) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0001.MDPR30) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0001.CPAR30) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0001.COL530) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0001.ASSO30) & "', "
            SQL = SQL & "   " & FormatSQL(z0001.TQQT30) & ", "
            SQL = SQL & "   " & FormatSQL(z0001.QT0130) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0001.TG0130) & "', "
            SQL = SQL & "   " & FormatSQL(z0001.QT0230) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0001.TG0230) & "', "
            SQL = SQL & "   " & FormatSQL(z0001.QT0330) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0001.TG0330) & "', "
            SQL = SQL & "   " & FormatSQL(z0001.QT0430) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0001.TG0430) & "', "
            SQL = SQL & "   " & FormatSQL(z0001.QT0530) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0001.TG0530) & "', "
            SQL = SQL & "   " & FormatSQL(z0001.QT0630) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0001.TG0630) & "', "
            SQL = SQL & "   " & FormatSQL(z0001.QT0730) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0001.TG0730) & "', "
            SQL = SQL & "   " & FormatSQL(z0001.QT0830) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0001.TG0830) & "', "
            SQL = SQL & "   " & FormatSQL(z0001.QT0930) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0001.TG0930) & "', "
            SQL = SQL & "   " & FormatSQL(z0001.QT1030) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0001.TG1030) & "', "
            SQL = SQL & "   " & FormatSQL(z0001.QT1130) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0001.TG1130) & "', "
            SQL = SQL & "   " & FormatSQL(z0001.QT1230) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0001.TG1230) & "', "
            SQL = SQL & "   " & FormatSQL(z0001.QT1330) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0001.TG1330) & "', "
            SQL = SQL & "   " & FormatSQL(z0001.QT1430) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0001.TG1430) & "', "
            SQL = SQL & "   " & FormatSQL(z0001.QT1530) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0001.TG1530) & "', "
            SQL = SQL & "   " & FormatSQL(z0001.QT1630) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0001.TG1630) & "', "
            SQL = SQL & "   " & FormatSQL(z0001.QT1730) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0001.TG1730) & "', "
            SQL = SQL & "   " & FormatSQL(z0001.QT1830) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0001.TG1830) & "', "
            SQL = SQL & "   " & FormatSQL(z0001.QT1930) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0001.TG1930) & "', "
            SQL = SQL & "   " & FormatSQL(z0001.QT2030) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0001.TG2030) & "', "
            SQL = SQL & "   " & FormatSQL(z0001.QT2130) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0001.TG2130) & "', "
            SQL = SQL & "   " & FormatSQL(z0001.QT2230) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0001.TG2230) & "', "
            SQL = SQL & "   " & FormatSQL(z0001.QT2330) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0001.TG2330) & "', "
            SQL = SQL & "   " & FormatSQL(z0001.QT2430) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0001.TG2430) & "', "
            SQL = SQL & "   " & FormatSQL(z0001.QT2530) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0001.TG2530) & "', "
            SQL = SQL & "   " & FormatSQL(z0001.QT2630) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0001.TG2630) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0001.TPKO30) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0001.DTPK30) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0001.CPC130) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0001.CPCR30) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK0001 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK0001", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK0001(z0001 As T0001_AREA) As Boolean
        REWRITE_PFK0001 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z0001)

            SQL = " UPDATE PFK0001 SET "
            SQL = SQL & "    K0001_PackingBatch      = N'" & FormatSQL(z0001.PackingBatch) & "', "
            SQL = SQL & "    K0001_ENTE30      = N'" & FormatSQL(z0001.ENTE30) & "', "
            SQL = SQL & "    K0001_SAOI30      =  " & FormatSQL(z0001.SAOI30) & ", "
            SQL = SQL & "    K0001_NROI30      =  " & FormatSQL(z0001.NROI30) & ", "
            SQL = SQL & "    K0001_RGOI30      =  " & FormatSQL(z0001.RGOI30) & ", "
            SQL = SQL & "    K0001_TIVE30      =  " & FormatSQL(z0001.TIVE30) & ", "
            SQL = SQL & "    K0001_DTIV30      = N'" & FormatSQL(z0001.DTIV30) & "', "
            SQL = SQL & "    K0001_DTEX30      =  " & FormatSQL(z0001.DTEX30) & ", "
            SQL = SQL & "    K0001_MDPR30      = N'" & FormatSQL(z0001.MDPR30) & "', "
            SQL = SQL & "    K0001_CPAR30      = N'" & FormatSQL(z0001.CPAR30) & "', "
            SQL = SQL & "    K0001_COL530      = N'" & FormatSQL(z0001.COL530) & "', "
            SQL = SQL & "    K0001_ASSO30      = N'" & FormatSQL(z0001.ASSO30) & "', "
            SQL = SQL & "    K0001_TQQT30      =  " & FormatSQL(z0001.TQQT30) & ", "
            SQL = SQL & "    K0001_QT0130      =  " & FormatSQL(z0001.QT0130) & ", "
            SQL = SQL & "    K0001_TG0130      = N'" & FormatSQL(z0001.TG0130) & "', "
            SQL = SQL & "    K0001_QT0230      =  " & FormatSQL(z0001.QT0230) & ", "
            SQL = SQL & "    K0001_TG0230      = N'" & FormatSQL(z0001.TG0230) & "', "
            SQL = SQL & "    K0001_QT0330      =  " & FormatSQL(z0001.QT0330) & ", "
            SQL = SQL & "    K0001_TG0330      = N'" & FormatSQL(z0001.TG0330) & "', "
            SQL = SQL & "    K0001_QT0430      =  " & FormatSQL(z0001.QT0430) & ", "
            SQL = SQL & "    K0001_TG0430      = N'" & FormatSQL(z0001.TG0430) & "', "
            SQL = SQL & "    K0001_QT0530      =  " & FormatSQL(z0001.QT0530) & ", "
            SQL = SQL & "    K0001_TG0530      = N'" & FormatSQL(z0001.TG0530) & "', "
            SQL = SQL & "    K0001_QT0630      =  " & FormatSQL(z0001.QT0630) & ", "
            SQL = SQL & "    K0001_TG0630      = N'" & FormatSQL(z0001.TG0630) & "', "
            SQL = SQL & "    K0001_QT0730      =  " & FormatSQL(z0001.QT0730) & ", "
            SQL = SQL & "    K0001_TG0730      = N'" & FormatSQL(z0001.TG0730) & "', "
            SQL = SQL & "    K0001_QT0830      =  " & FormatSQL(z0001.QT0830) & ", "
            SQL = SQL & "    K0001_TG0830      = N'" & FormatSQL(z0001.TG0830) & "', "
            SQL = SQL & "    K0001_QT0930      =  " & FormatSQL(z0001.QT0930) & ", "
            SQL = SQL & "    K0001_TG0930      = N'" & FormatSQL(z0001.TG0930) & "', "
            SQL = SQL & "    K0001_QT1030      =  " & FormatSQL(z0001.QT1030) & ", "
            SQL = SQL & "    K0001_TG1030      = N'" & FormatSQL(z0001.TG1030) & "', "
            SQL = SQL & "    K0001_QT1130      =  " & FormatSQL(z0001.QT1130) & ", "
            SQL = SQL & "    K0001_TG1130      = N'" & FormatSQL(z0001.TG1130) & "', "
            SQL = SQL & "    K0001_QT1230      =  " & FormatSQL(z0001.QT1230) & ", "
            SQL = SQL & "    K0001_TG1230      = N'" & FormatSQL(z0001.TG1230) & "', "
            SQL = SQL & "    K0001_QT1330      =  " & FormatSQL(z0001.QT1330) & ", "
            SQL = SQL & "    K0001_TG1330      = N'" & FormatSQL(z0001.TG1330) & "', "
            SQL = SQL & "    K0001_QT1430      =  " & FormatSQL(z0001.QT1430) & ", "
            SQL = SQL & "    K0001_TG1430      = N'" & FormatSQL(z0001.TG1430) & "', "
            SQL = SQL & "    K0001_QT1530      =  " & FormatSQL(z0001.QT1530) & ", "
            SQL = SQL & "    K0001_TG1530      = N'" & FormatSQL(z0001.TG1530) & "', "
            SQL = SQL & "    K0001_QT1630      =  " & FormatSQL(z0001.QT1630) & ", "
            SQL = SQL & "    K0001_TG1630      = N'" & FormatSQL(z0001.TG1630) & "', "
            SQL = SQL & "    K0001_QT1730      =  " & FormatSQL(z0001.QT1730) & ", "
            SQL = SQL & "    K0001_TG1730      = N'" & FormatSQL(z0001.TG1730) & "', "
            SQL = SQL & "    K0001_QT1830      =  " & FormatSQL(z0001.QT1830) & ", "
            SQL = SQL & "    K0001_TG1830      = N'" & FormatSQL(z0001.TG1830) & "', "
            SQL = SQL & "    K0001_QT1930      =  " & FormatSQL(z0001.QT1930) & ", "
            SQL = SQL & "    K0001_TG1930      = N'" & FormatSQL(z0001.TG1930) & "', "
            SQL = SQL & "    K0001_QT2030      =  " & FormatSQL(z0001.QT2030) & ", "
            SQL = SQL & "    K0001_TG2030      = N'" & FormatSQL(z0001.TG2030) & "', "
            SQL = SQL & "    K0001_QT2130      =  " & FormatSQL(z0001.QT2130) & ", "
            SQL = SQL & "    K0001_TG2130      = N'" & FormatSQL(z0001.TG2130) & "', "
            SQL = SQL & "    K0001_QT2230      =  " & FormatSQL(z0001.QT2230) & ", "
            SQL = SQL & "    K0001_TG2230      = N'" & FormatSQL(z0001.TG2230) & "', "
            SQL = SQL & "    K0001_QT2330      =  " & FormatSQL(z0001.QT2330) & ", "
            SQL = SQL & "    K0001_TG2330      = N'" & FormatSQL(z0001.TG2330) & "', "
            SQL = SQL & "    K0001_QT2430      =  " & FormatSQL(z0001.QT2430) & ", "
            SQL = SQL & "    K0001_TG2430      = N'" & FormatSQL(z0001.TG2430) & "', "
            SQL = SQL & "    K0001_QT2530      =  " & FormatSQL(z0001.QT2530) & ", "
            SQL = SQL & "    K0001_TG2530      = N'" & FormatSQL(z0001.TG2530) & "', "
            SQL = SQL & "    K0001_QT2630      =  " & FormatSQL(z0001.QT2630) & ", "
            SQL = SQL & "    K0001_TG2630      = N'" & FormatSQL(z0001.TG2630) & "', "
            SQL = SQL & "    K0001_TPKO30      = N'" & FormatSQL(z0001.TPKO30) & "', "
            SQL = SQL & "    K0001_DTPK30      = N'" & FormatSQL(z0001.DTPK30) & "', "
            SQL = SQL & "    K0001_CPC130      = N'" & FormatSQL(z0001.CPC130) & "', "
            SQL = SQL & "    K0001_CPCR30      = N'" & FormatSQL(z0001.CPCR30) & "'  "
            SQL = SQL & " WHERE K0001_Autokey		 =  " & z0001.Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK0001 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK0001", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK0001(z0001 As T0001_AREA) As Boolean
        DELETE_PFK0001 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK0001 "
            SQL = SQL & " WHERE K0001_Autokey		 =  " & z0001.Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK0001 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK0001", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D0001_CLEAR()
        Try

            D0001.Autokey = 0
            D0001.PackingBatch = ""
            D0001.ENTE30 = ""
            D0001.SAOI30 = 0
            D0001.NROI30 = 0
            D0001.RGOI30 = 0
            D0001.TIVE30 = 0
            D0001.DTIV30 = ""
            D0001.DTEX30 = 0
            D0001.MDPR30 = ""
            D0001.CPAR30 = ""
            D0001.COL530 = ""
            D0001.ASSO30 = ""
            D0001.TQQT30 = 0
            D0001.QT0130 = 0
            D0001.TG0130 = ""
            D0001.QT0230 = 0
            D0001.TG0230 = ""
            D0001.QT0330 = 0
            D0001.TG0330 = ""
            D0001.QT0430 = 0
            D0001.TG0430 = ""
            D0001.QT0530 = 0
            D0001.TG0530 = ""
            D0001.QT0630 = 0
            D0001.TG0630 = ""
            D0001.QT0730 = 0
            D0001.TG0730 = ""
            D0001.QT0830 = 0
            D0001.TG0830 = ""
            D0001.QT0930 = 0
            D0001.TG0930 = ""
            D0001.QT1030 = 0
            D0001.TG1030 = ""
            D0001.QT1130 = 0
            D0001.TG1130 = ""
            D0001.QT1230 = 0
            D0001.TG1230 = ""
            D0001.QT1330 = 0
            D0001.TG1330 = ""
            D0001.QT1430 = 0
            D0001.TG1430 = ""
            D0001.QT1530 = 0
            D0001.TG1530 = ""
            D0001.QT1630 = 0
            D0001.TG1630 = ""
            D0001.QT1730 = 0
            D0001.TG1730 = ""
            D0001.QT1830 = 0
            D0001.TG1830 = ""
            D0001.QT1930 = 0
            D0001.TG1930 = ""
            D0001.QT2030 = 0
            D0001.TG2030 = ""
            D0001.QT2130 = 0
            D0001.TG2130 = ""
            D0001.QT2230 = 0
            D0001.TG2230 = ""
            D0001.QT2330 = 0
            D0001.TG2330 = ""
            D0001.QT2430 = 0
            D0001.TG2430 = ""
            D0001.QT2530 = 0
            D0001.TG2530 = ""
            D0001.QT2630 = 0
            D0001.TG2630 = ""
            D0001.TPKO30 = ""
            D0001.DTPK30 = ""
            D0001.CPC130 = ""
            D0001.CPCR30 = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D0001_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x0001 As T0001_AREA)
        Try

            x0001.Autokey = trim$(x0001.Autokey)
            x0001.PackingBatch = trim$(x0001.PackingBatch)
            x0001.ENTE30 = trim$(x0001.ENTE30)
            x0001.SAOI30 = trim$(x0001.SAOI30)
            x0001.NROI30 = trim$(x0001.NROI30)
            x0001.RGOI30 = trim$(x0001.RGOI30)
            x0001.TIVE30 = trim$(x0001.TIVE30)
            x0001.DTIV30 = trim$(x0001.DTIV30)
            x0001.DTEX30 = trim$(x0001.DTEX30)
            x0001.MDPR30 = trim$(x0001.MDPR30)
            x0001.CPAR30 = trim$(x0001.CPAR30)
            x0001.COL530 = trim$(x0001.COL530)
            x0001.ASSO30 = trim$(x0001.ASSO30)
            x0001.TQQT30 = trim$(x0001.TQQT30)
            x0001.QT0130 = trim$(x0001.QT0130)
            x0001.TG0130 = trim$(x0001.TG0130)
            x0001.QT0230 = trim$(x0001.QT0230)
            x0001.TG0230 = trim$(x0001.TG0230)
            x0001.QT0330 = trim$(x0001.QT0330)
            x0001.TG0330 = trim$(x0001.TG0330)
            x0001.QT0430 = trim$(x0001.QT0430)
            x0001.TG0430 = trim$(x0001.TG0430)
            x0001.QT0530 = trim$(x0001.QT0530)
            x0001.TG0530 = trim$(x0001.TG0530)
            x0001.QT0630 = trim$(x0001.QT0630)
            x0001.TG0630 = trim$(x0001.TG0630)
            x0001.QT0730 = trim$(x0001.QT0730)
            x0001.TG0730 = trim$(x0001.TG0730)
            x0001.QT0830 = trim$(x0001.QT0830)
            x0001.TG0830 = trim$(x0001.TG0830)
            x0001.QT0930 = trim$(x0001.QT0930)
            x0001.TG0930 = trim$(x0001.TG0930)
            x0001.QT1030 = trim$(x0001.QT1030)
            x0001.TG1030 = trim$(x0001.TG1030)
            x0001.QT1130 = trim$(x0001.QT1130)
            x0001.TG1130 = trim$(x0001.TG1130)
            x0001.QT1230 = trim$(x0001.QT1230)
            x0001.TG1230 = trim$(x0001.TG1230)
            x0001.QT1330 = trim$(x0001.QT1330)
            x0001.TG1330 = trim$(x0001.TG1330)
            x0001.QT1430 = trim$(x0001.QT1430)
            x0001.TG1430 = trim$(x0001.TG1430)
            x0001.QT1530 = trim$(x0001.QT1530)
            x0001.TG1530 = trim$(x0001.TG1530)
            x0001.QT1630 = trim$(x0001.QT1630)
            x0001.TG1630 = trim$(x0001.TG1630)
            x0001.QT1730 = trim$(x0001.QT1730)
            x0001.TG1730 = trim$(x0001.TG1730)
            x0001.QT1830 = trim$(x0001.QT1830)
            x0001.TG1830 = trim$(x0001.TG1830)
            x0001.QT1930 = trim$(x0001.QT1930)
            x0001.TG1930 = trim$(x0001.TG1930)
            x0001.QT2030 = trim$(x0001.QT2030)
            x0001.TG2030 = trim$(x0001.TG2030)
            x0001.QT2130 = trim$(x0001.QT2130)
            x0001.TG2130 = trim$(x0001.TG2130)
            x0001.QT2230 = trim$(x0001.QT2230)
            x0001.TG2230 = trim$(x0001.TG2230)
            x0001.QT2330 = trim$(x0001.QT2330)
            x0001.TG2330 = trim$(x0001.TG2330)
            x0001.QT2430 = trim$(x0001.QT2430)
            x0001.TG2430 = trim$(x0001.TG2430)
            x0001.QT2530 = trim$(x0001.QT2530)
            x0001.TG2530 = trim$(x0001.TG2530)
            x0001.QT2630 = trim$(x0001.QT2630)
            x0001.TG2630 = trim$(x0001.TG2630)
            x0001.TPKO30 = trim$(x0001.TPKO30)
            x0001.DTPK30 = trim$(x0001.DTPK30)
            x0001.CPC130 = trim$(x0001.CPC130)
            x0001.CPCR30 = trim$(x0001.CPCR30)

            If trim$(x0001.Autokey) = "" Then x0001.Autokey = 0
            If trim$(x0001.PackingBatch) = "" Then x0001.PackingBatch = Space(1)
            If trim$(x0001.ENTE30) = "" Then x0001.ENTE30 = Space(1)
            If trim$(x0001.SAOI30) = "" Then x0001.SAOI30 = 0
            If trim$(x0001.NROI30) = "" Then x0001.NROI30 = 0
            If trim$(x0001.RGOI30) = "" Then x0001.RGOI30 = 0
            If trim$(x0001.TIVE30) = "" Then x0001.TIVE30 = 0
            If trim$(x0001.DTIV30) = "" Then x0001.DTIV30 = Space(1)
            If trim$(x0001.DTEX30) = "" Then x0001.DTEX30 = 0
            If trim$(x0001.MDPR30) = "" Then x0001.MDPR30 = Space(1)
            If trim$(x0001.CPAR30) = "" Then x0001.CPAR30 = Space(1)
            If trim$(x0001.COL530) = "" Then x0001.COL530 = Space(1)
            If trim$(x0001.ASSO30) = "" Then x0001.ASSO30 = Space(1)
            If trim$(x0001.TQQT30) = "" Then x0001.TQQT30 = 0
            If trim$(x0001.QT0130) = "" Then x0001.QT0130 = 0
            If trim$(x0001.TG0130) = "" Then x0001.TG0130 = Space(1)
            If trim$(x0001.QT0230) = "" Then x0001.QT0230 = 0
            If trim$(x0001.TG0230) = "" Then x0001.TG0230 = Space(1)
            If trim$(x0001.QT0330) = "" Then x0001.QT0330 = 0
            If trim$(x0001.TG0330) = "" Then x0001.TG0330 = Space(1)
            If trim$(x0001.QT0430) = "" Then x0001.QT0430 = 0
            If trim$(x0001.TG0430) = "" Then x0001.TG0430 = Space(1)
            If trim$(x0001.QT0530) = "" Then x0001.QT0530 = 0
            If trim$(x0001.TG0530) = "" Then x0001.TG0530 = Space(1)
            If trim$(x0001.QT0630) = "" Then x0001.QT0630 = 0
            If trim$(x0001.TG0630) = "" Then x0001.TG0630 = Space(1)
            If trim$(x0001.QT0730) = "" Then x0001.QT0730 = 0
            If trim$(x0001.TG0730) = "" Then x0001.TG0730 = Space(1)
            If trim$(x0001.QT0830) = "" Then x0001.QT0830 = 0
            If trim$(x0001.TG0830) = "" Then x0001.TG0830 = Space(1)
            If trim$(x0001.QT0930) = "" Then x0001.QT0930 = 0
            If trim$(x0001.TG0930) = "" Then x0001.TG0930 = Space(1)
            If trim$(x0001.QT1030) = "" Then x0001.QT1030 = 0
            If trim$(x0001.TG1030) = "" Then x0001.TG1030 = Space(1)
            If trim$(x0001.QT1130) = "" Then x0001.QT1130 = 0
            If trim$(x0001.TG1130) = "" Then x0001.TG1130 = Space(1)
            If trim$(x0001.QT1230) = "" Then x0001.QT1230 = 0
            If trim$(x0001.TG1230) = "" Then x0001.TG1230 = Space(1)
            If trim$(x0001.QT1330) = "" Then x0001.QT1330 = 0
            If trim$(x0001.TG1330) = "" Then x0001.TG1330 = Space(1)
            If trim$(x0001.QT1430) = "" Then x0001.QT1430 = 0
            If trim$(x0001.TG1430) = "" Then x0001.TG1430 = Space(1)
            If trim$(x0001.QT1530) = "" Then x0001.QT1530 = 0
            If trim$(x0001.TG1530) = "" Then x0001.TG1530 = Space(1)
            If trim$(x0001.QT1630) = "" Then x0001.QT1630 = 0
            If trim$(x0001.TG1630) = "" Then x0001.TG1630 = Space(1)
            If trim$(x0001.QT1730) = "" Then x0001.QT1730 = 0
            If trim$(x0001.TG1730) = "" Then x0001.TG1730 = Space(1)
            If trim$(x0001.QT1830) = "" Then x0001.QT1830 = 0
            If trim$(x0001.TG1830) = "" Then x0001.TG1830 = Space(1)
            If trim$(x0001.QT1930) = "" Then x0001.QT1930 = 0
            If trim$(x0001.TG1930) = "" Then x0001.TG1930 = Space(1)
            If trim$(x0001.QT2030) = "" Then x0001.QT2030 = 0
            If trim$(x0001.TG2030) = "" Then x0001.TG2030 = Space(1)
            If trim$(x0001.QT2130) = "" Then x0001.QT2130 = 0
            If trim$(x0001.TG2130) = "" Then x0001.TG2130 = Space(1)
            If trim$(x0001.QT2230) = "" Then x0001.QT2230 = 0
            If trim$(x0001.TG2230) = "" Then x0001.TG2230 = Space(1)
            If trim$(x0001.QT2330) = "" Then x0001.QT2330 = 0
            If trim$(x0001.TG2330) = "" Then x0001.TG2330 = Space(1)
            If trim$(x0001.QT2430) = "" Then x0001.QT2430 = 0
            If trim$(x0001.TG2430) = "" Then x0001.TG2430 = Space(1)
            If trim$(x0001.QT2530) = "" Then x0001.QT2530 = 0
            If trim$(x0001.TG2530) = "" Then x0001.TG2530 = Space(1)
            If trim$(x0001.QT2630) = "" Then x0001.QT2630 = 0
            If trim$(x0001.TG2630) = "" Then x0001.TG2630 = Space(1)
            If trim$(x0001.TPKO30) = "" Then x0001.TPKO30 = Space(1)
            If trim$(x0001.DTPK30) = "" Then x0001.DTPK30 = Space(1)
            If trim$(x0001.CPC130) = "" Then x0001.CPC130 = Space(1)
            If trim$(x0001.CPCR30) = "" Then x0001.CPCR30 = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K0001_MOVE(rs0001 As SqlClient.SqlDataReader)
        Try

            Call D0001_CLEAR()

            If IsdbNull(rs0001!K0001_Autokey) = False Then D0001.Autokey = Trim$(rs0001!K0001_Autokey)
            If IsdbNull(rs0001!K0001_PackingBatch) = False Then D0001.PackingBatch = Trim$(rs0001!K0001_PackingBatch)
            If IsdbNull(rs0001!K0001_ENTE30) = False Then D0001.ENTE30 = Trim$(rs0001!K0001_ENTE30)
            If IsdbNull(rs0001!K0001_SAOI30) = False Then D0001.SAOI30 = Trim$(rs0001!K0001_SAOI30)
            If IsdbNull(rs0001!K0001_NROI30) = False Then D0001.NROI30 = Trim$(rs0001!K0001_NROI30)
            If IsdbNull(rs0001!K0001_RGOI30) = False Then D0001.RGOI30 = Trim$(rs0001!K0001_RGOI30)
            If IsdbNull(rs0001!K0001_TIVE30) = False Then D0001.TIVE30 = Trim$(rs0001!K0001_TIVE30)
            If IsdbNull(rs0001!K0001_DTIV30) = False Then D0001.DTIV30 = Trim$(rs0001!K0001_DTIV30)
            If IsdbNull(rs0001!K0001_DTEX30) = False Then D0001.DTEX30 = Trim$(rs0001!K0001_DTEX30)
            If IsdbNull(rs0001!K0001_MDPR30) = False Then D0001.MDPR30 = Trim$(rs0001!K0001_MDPR30)
            If IsdbNull(rs0001!K0001_CPAR30) = False Then D0001.CPAR30 = Trim$(rs0001!K0001_CPAR30)
            If IsdbNull(rs0001!K0001_COL530) = False Then D0001.COL530 = Trim$(rs0001!K0001_COL530)
            If IsdbNull(rs0001!K0001_ASSO30) = False Then D0001.ASSO30 = Trim$(rs0001!K0001_ASSO30)
            If IsdbNull(rs0001!K0001_TQQT30) = False Then D0001.TQQT30 = Trim$(rs0001!K0001_TQQT30)
            If IsdbNull(rs0001!K0001_QT0130) = False Then D0001.QT0130 = Trim$(rs0001!K0001_QT0130)
            If IsdbNull(rs0001!K0001_TG0130) = False Then D0001.TG0130 = Trim$(rs0001!K0001_TG0130)
            If IsdbNull(rs0001!K0001_QT0230) = False Then D0001.QT0230 = Trim$(rs0001!K0001_QT0230)
            If IsdbNull(rs0001!K0001_TG0230) = False Then D0001.TG0230 = Trim$(rs0001!K0001_TG0230)
            If IsdbNull(rs0001!K0001_QT0330) = False Then D0001.QT0330 = Trim$(rs0001!K0001_QT0330)
            If IsdbNull(rs0001!K0001_TG0330) = False Then D0001.TG0330 = Trim$(rs0001!K0001_TG0330)
            If IsdbNull(rs0001!K0001_QT0430) = False Then D0001.QT0430 = Trim$(rs0001!K0001_QT0430)
            If IsdbNull(rs0001!K0001_TG0430) = False Then D0001.TG0430 = Trim$(rs0001!K0001_TG0430)
            If IsdbNull(rs0001!K0001_QT0530) = False Then D0001.QT0530 = Trim$(rs0001!K0001_QT0530)
            If IsdbNull(rs0001!K0001_TG0530) = False Then D0001.TG0530 = Trim$(rs0001!K0001_TG0530)
            If IsdbNull(rs0001!K0001_QT0630) = False Then D0001.QT0630 = Trim$(rs0001!K0001_QT0630)
            If IsdbNull(rs0001!K0001_TG0630) = False Then D0001.TG0630 = Trim$(rs0001!K0001_TG0630)
            If IsdbNull(rs0001!K0001_QT0730) = False Then D0001.QT0730 = Trim$(rs0001!K0001_QT0730)
            If IsdbNull(rs0001!K0001_TG0730) = False Then D0001.TG0730 = Trim$(rs0001!K0001_TG0730)
            If IsdbNull(rs0001!K0001_QT0830) = False Then D0001.QT0830 = Trim$(rs0001!K0001_QT0830)
            If IsdbNull(rs0001!K0001_TG0830) = False Then D0001.TG0830 = Trim$(rs0001!K0001_TG0830)
            If IsdbNull(rs0001!K0001_QT0930) = False Then D0001.QT0930 = Trim$(rs0001!K0001_QT0930)
            If IsdbNull(rs0001!K0001_TG0930) = False Then D0001.TG0930 = Trim$(rs0001!K0001_TG0930)
            If IsdbNull(rs0001!K0001_QT1030) = False Then D0001.QT1030 = Trim$(rs0001!K0001_QT1030)
            If IsdbNull(rs0001!K0001_TG1030) = False Then D0001.TG1030 = Trim$(rs0001!K0001_TG1030)
            If IsdbNull(rs0001!K0001_QT1130) = False Then D0001.QT1130 = Trim$(rs0001!K0001_QT1130)
            If IsdbNull(rs0001!K0001_TG1130) = False Then D0001.TG1130 = Trim$(rs0001!K0001_TG1130)
            If IsdbNull(rs0001!K0001_QT1230) = False Then D0001.QT1230 = Trim$(rs0001!K0001_QT1230)
            If IsdbNull(rs0001!K0001_TG1230) = False Then D0001.TG1230 = Trim$(rs0001!K0001_TG1230)
            If IsdbNull(rs0001!K0001_QT1330) = False Then D0001.QT1330 = Trim$(rs0001!K0001_QT1330)
            If IsdbNull(rs0001!K0001_TG1330) = False Then D0001.TG1330 = Trim$(rs0001!K0001_TG1330)
            If IsdbNull(rs0001!K0001_QT1430) = False Then D0001.QT1430 = Trim$(rs0001!K0001_QT1430)
            If IsdbNull(rs0001!K0001_TG1430) = False Then D0001.TG1430 = Trim$(rs0001!K0001_TG1430)
            If IsdbNull(rs0001!K0001_QT1530) = False Then D0001.QT1530 = Trim$(rs0001!K0001_QT1530)
            If IsdbNull(rs0001!K0001_TG1530) = False Then D0001.TG1530 = Trim$(rs0001!K0001_TG1530)
            If IsdbNull(rs0001!K0001_QT1630) = False Then D0001.QT1630 = Trim$(rs0001!K0001_QT1630)
            If IsdbNull(rs0001!K0001_TG1630) = False Then D0001.TG1630 = Trim$(rs0001!K0001_TG1630)
            If IsdbNull(rs0001!K0001_QT1730) = False Then D0001.QT1730 = Trim$(rs0001!K0001_QT1730)
            If IsdbNull(rs0001!K0001_TG1730) = False Then D0001.TG1730 = Trim$(rs0001!K0001_TG1730)
            If IsdbNull(rs0001!K0001_QT1830) = False Then D0001.QT1830 = Trim$(rs0001!K0001_QT1830)
            If IsdbNull(rs0001!K0001_TG1830) = False Then D0001.TG1830 = Trim$(rs0001!K0001_TG1830)
            If IsdbNull(rs0001!K0001_QT1930) = False Then D0001.QT1930 = Trim$(rs0001!K0001_QT1930)
            If IsdbNull(rs0001!K0001_TG1930) = False Then D0001.TG1930 = Trim$(rs0001!K0001_TG1930)
            If IsdbNull(rs0001!K0001_QT2030) = False Then D0001.QT2030 = Trim$(rs0001!K0001_QT2030)
            If IsdbNull(rs0001!K0001_TG2030) = False Then D0001.TG2030 = Trim$(rs0001!K0001_TG2030)
            If IsdbNull(rs0001!K0001_QT2130) = False Then D0001.QT2130 = Trim$(rs0001!K0001_QT2130)
            If IsdbNull(rs0001!K0001_TG2130) = False Then D0001.TG2130 = Trim$(rs0001!K0001_TG2130)
            If IsdbNull(rs0001!K0001_QT2230) = False Then D0001.QT2230 = Trim$(rs0001!K0001_QT2230)
            If IsdbNull(rs0001!K0001_TG2230) = False Then D0001.TG2230 = Trim$(rs0001!K0001_TG2230)
            If IsdbNull(rs0001!K0001_QT2330) = False Then D0001.QT2330 = Trim$(rs0001!K0001_QT2330)
            If IsdbNull(rs0001!K0001_TG2330) = False Then D0001.TG2330 = Trim$(rs0001!K0001_TG2330)
            If IsdbNull(rs0001!K0001_QT2430) = False Then D0001.QT2430 = Trim$(rs0001!K0001_QT2430)
            If IsdbNull(rs0001!K0001_TG2430) = False Then D0001.TG2430 = Trim$(rs0001!K0001_TG2430)
            If IsdbNull(rs0001!K0001_QT2530) = False Then D0001.QT2530 = Trim$(rs0001!K0001_QT2530)
            If IsdbNull(rs0001!K0001_TG2530) = False Then D0001.TG2530 = Trim$(rs0001!K0001_TG2530)
            If IsdbNull(rs0001!K0001_QT2630) = False Then D0001.QT2630 = Trim$(rs0001!K0001_QT2630)
            If IsdbNull(rs0001!K0001_TG2630) = False Then D0001.TG2630 = Trim$(rs0001!K0001_TG2630)
            If IsdbNull(rs0001!K0001_TPKO30) = False Then D0001.TPKO30 = Trim$(rs0001!K0001_TPKO30)
            If IsdbNull(rs0001!K0001_DTPK30) = False Then D0001.DTPK30 = Trim$(rs0001!K0001_DTPK30)
            If IsdbNull(rs0001!K0001_CPC130) = False Then D0001.CPC130 = Trim$(rs0001!K0001_CPC130)
            If IsdbNull(rs0001!K0001_CPCR30) = False Then D0001.CPCR30 = Trim$(rs0001!K0001_CPCR30)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K0001_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K0001_MOVE(rs0001 As DataRow)
        Try

            Call D0001_CLEAR()

            If IsdbNull(rs0001!K0001_Autokey) = False Then D0001.Autokey = Trim$(rs0001!K0001_Autokey)
            If IsdbNull(rs0001!K0001_PackingBatch) = False Then D0001.PackingBatch = Trim$(rs0001!K0001_PackingBatch)
            If IsdbNull(rs0001!K0001_ENTE30) = False Then D0001.ENTE30 = Trim$(rs0001!K0001_ENTE30)
            If IsdbNull(rs0001!K0001_SAOI30) = False Then D0001.SAOI30 = Trim$(rs0001!K0001_SAOI30)
            If IsdbNull(rs0001!K0001_NROI30) = False Then D0001.NROI30 = Trim$(rs0001!K0001_NROI30)
            If IsdbNull(rs0001!K0001_RGOI30) = False Then D0001.RGOI30 = Trim$(rs0001!K0001_RGOI30)
            If IsdbNull(rs0001!K0001_TIVE30) = False Then D0001.TIVE30 = Trim$(rs0001!K0001_TIVE30)
            If IsdbNull(rs0001!K0001_DTIV30) = False Then D0001.DTIV30 = Trim$(rs0001!K0001_DTIV30)
            If IsdbNull(rs0001!K0001_DTEX30) = False Then D0001.DTEX30 = Trim$(rs0001!K0001_DTEX30)
            If IsdbNull(rs0001!K0001_MDPR30) = False Then D0001.MDPR30 = Trim$(rs0001!K0001_MDPR30)
            If IsdbNull(rs0001!K0001_CPAR30) = False Then D0001.CPAR30 = Trim$(rs0001!K0001_CPAR30)
            If IsdbNull(rs0001!K0001_COL530) = False Then D0001.COL530 = Trim$(rs0001!K0001_COL530)
            If IsdbNull(rs0001!K0001_ASSO30) = False Then D0001.ASSO30 = Trim$(rs0001!K0001_ASSO30)
            If IsdbNull(rs0001!K0001_TQQT30) = False Then D0001.TQQT30 = Trim$(rs0001!K0001_TQQT30)
            If IsdbNull(rs0001!K0001_QT0130) = False Then D0001.QT0130 = Trim$(rs0001!K0001_QT0130)
            If IsdbNull(rs0001!K0001_TG0130) = False Then D0001.TG0130 = Trim$(rs0001!K0001_TG0130)
            If IsdbNull(rs0001!K0001_QT0230) = False Then D0001.QT0230 = Trim$(rs0001!K0001_QT0230)
            If IsdbNull(rs0001!K0001_TG0230) = False Then D0001.TG0230 = Trim$(rs0001!K0001_TG0230)
            If IsdbNull(rs0001!K0001_QT0330) = False Then D0001.QT0330 = Trim$(rs0001!K0001_QT0330)
            If IsdbNull(rs0001!K0001_TG0330) = False Then D0001.TG0330 = Trim$(rs0001!K0001_TG0330)
            If IsdbNull(rs0001!K0001_QT0430) = False Then D0001.QT0430 = Trim$(rs0001!K0001_QT0430)
            If IsdbNull(rs0001!K0001_TG0430) = False Then D0001.TG0430 = Trim$(rs0001!K0001_TG0430)
            If IsdbNull(rs0001!K0001_QT0530) = False Then D0001.QT0530 = Trim$(rs0001!K0001_QT0530)
            If IsdbNull(rs0001!K0001_TG0530) = False Then D0001.TG0530 = Trim$(rs0001!K0001_TG0530)
            If IsdbNull(rs0001!K0001_QT0630) = False Then D0001.QT0630 = Trim$(rs0001!K0001_QT0630)
            If IsdbNull(rs0001!K0001_TG0630) = False Then D0001.TG0630 = Trim$(rs0001!K0001_TG0630)
            If IsdbNull(rs0001!K0001_QT0730) = False Then D0001.QT0730 = Trim$(rs0001!K0001_QT0730)
            If IsdbNull(rs0001!K0001_TG0730) = False Then D0001.TG0730 = Trim$(rs0001!K0001_TG0730)
            If IsdbNull(rs0001!K0001_QT0830) = False Then D0001.QT0830 = Trim$(rs0001!K0001_QT0830)
            If IsdbNull(rs0001!K0001_TG0830) = False Then D0001.TG0830 = Trim$(rs0001!K0001_TG0830)
            If IsdbNull(rs0001!K0001_QT0930) = False Then D0001.QT0930 = Trim$(rs0001!K0001_QT0930)
            If IsdbNull(rs0001!K0001_TG0930) = False Then D0001.TG0930 = Trim$(rs0001!K0001_TG0930)
            If IsdbNull(rs0001!K0001_QT1030) = False Then D0001.QT1030 = Trim$(rs0001!K0001_QT1030)
            If IsdbNull(rs0001!K0001_TG1030) = False Then D0001.TG1030 = Trim$(rs0001!K0001_TG1030)
            If IsdbNull(rs0001!K0001_QT1130) = False Then D0001.QT1130 = Trim$(rs0001!K0001_QT1130)
            If IsdbNull(rs0001!K0001_TG1130) = False Then D0001.TG1130 = Trim$(rs0001!K0001_TG1130)
            If IsdbNull(rs0001!K0001_QT1230) = False Then D0001.QT1230 = Trim$(rs0001!K0001_QT1230)
            If IsdbNull(rs0001!K0001_TG1230) = False Then D0001.TG1230 = Trim$(rs0001!K0001_TG1230)
            If IsdbNull(rs0001!K0001_QT1330) = False Then D0001.QT1330 = Trim$(rs0001!K0001_QT1330)
            If IsdbNull(rs0001!K0001_TG1330) = False Then D0001.TG1330 = Trim$(rs0001!K0001_TG1330)
            If IsdbNull(rs0001!K0001_QT1430) = False Then D0001.QT1430 = Trim$(rs0001!K0001_QT1430)
            If IsdbNull(rs0001!K0001_TG1430) = False Then D0001.TG1430 = Trim$(rs0001!K0001_TG1430)
            If IsdbNull(rs0001!K0001_QT1530) = False Then D0001.QT1530 = Trim$(rs0001!K0001_QT1530)
            If IsdbNull(rs0001!K0001_TG1530) = False Then D0001.TG1530 = Trim$(rs0001!K0001_TG1530)
            If IsdbNull(rs0001!K0001_QT1630) = False Then D0001.QT1630 = Trim$(rs0001!K0001_QT1630)
            If IsdbNull(rs0001!K0001_TG1630) = False Then D0001.TG1630 = Trim$(rs0001!K0001_TG1630)
            If IsdbNull(rs0001!K0001_QT1730) = False Then D0001.QT1730 = Trim$(rs0001!K0001_QT1730)
            If IsdbNull(rs0001!K0001_TG1730) = False Then D0001.TG1730 = Trim$(rs0001!K0001_TG1730)
            If IsdbNull(rs0001!K0001_QT1830) = False Then D0001.QT1830 = Trim$(rs0001!K0001_QT1830)
            If IsdbNull(rs0001!K0001_TG1830) = False Then D0001.TG1830 = Trim$(rs0001!K0001_TG1830)
            If IsdbNull(rs0001!K0001_QT1930) = False Then D0001.QT1930 = Trim$(rs0001!K0001_QT1930)
            If IsdbNull(rs0001!K0001_TG1930) = False Then D0001.TG1930 = Trim$(rs0001!K0001_TG1930)
            If IsdbNull(rs0001!K0001_QT2030) = False Then D0001.QT2030 = Trim$(rs0001!K0001_QT2030)
            If IsdbNull(rs0001!K0001_TG2030) = False Then D0001.TG2030 = Trim$(rs0001!K0001_TG2030)
            If IsdbNull(rs0001!K0001_QT2130) = False Then D0001.QT2130 = Trim$(rs0001!K0001_QT2130)
            If IsdbNull(rs0001!K0001_TG2130) = False Then D0001.TG2130 = Trim$(rs0001!K0001_TG2130)
            If IsdbNull(rs0001!K0001_QT2230) = False Then D0001.QT2230 = Trim$(rs0001!K0001_QT2230)
            If IsdbNull(rs0001!K0001_TG2230) = False Then D0001.TG2230 = Trim$(rs0001!K0001_TG2230)
            If IsdbNull(rs0001!K0001_QT2330) = False Then D0001.QT2330 = Trim$(rs0001!K0001_QT2330)
            If IsdbNull(rs0001!K0001_TG2330) = False Then D0001.TG2330 = Trim$(rs0001!K0001_TG2330)
            If IsdbNull(rs0001!K0001_QT2430) = False Then D0001.QT2430 = Trim$(rs0001!K0001_QT2430)
            If IsdbNull(rs0001!K0001_TG2430) = False Then D0001.TG2430 = Trim$(rs0001!K0001_TG2430)
            If IsdbNull(rs0001!K0001_QT2530) = False Then D0001.QT2530 = Trim$(rs0001!K0001_QT2530)
            If IsdbNull(rs0001!K0001_TG2530) = False Then D0001.TG2530 = Trim$(rs0001!K0001_TG2530)
            If IsdbNull(rs0001!K0001_QT2630) = False Then D0001.QT2630 = Trim$(rs0001!K0001_QT2630)
            If IsdbNull(rs0001!K0001_TG2630) = False Then D0001.TG2630 = Trim$(rs0001!K0001_TG2630)
            If IsdbNull(rs0001!K0001_TPKO30) = False Then D0001.TPKO30 = Trim$(rs0001!K0001_TPKO30)
            If IsdbNull(rs0001!K0001_DTPK30) = False Then D0001.DTPK30 = Trim$(rs0001!K0001_DTPK30)
            If IsdbNull(rs0001!K0001_CPC130) = False Then D0001.CPC130 = Trim$(rs0001!K0001_CPC130)
            If IsdbNull(rs0001!K0001_CPCR30) = False Then D0001.CPCR30 = Trim$(rs0001!K0001_CPCR30)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K0001_MOVE", vbCritical)
        End Try
    End Sub


End Module
