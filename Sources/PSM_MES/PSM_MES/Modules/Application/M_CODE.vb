Imports System.Data.SqlClient
Imports System.Resources
Imports System.Object

Imports System.IO
Module M_CODE

#Region "Variable"
#Region "ACC"
    Public Const pMa_cty = "001"
    Public NewPACount As String = ""
    Public Const pIsAll = 1
#End Region
    Public Bol_AutoInsert As Boolean = False
    Public PFK4073_CheckTest As Boolean = False
    Public LinkReportName As String = ""

    Public _FileExt As String = ""
    Public chk_PLM As Boolean = False
    Public ProgressBar1 As E_PRG
    Public CheckConnect As Boolean = False
    Public CheckSolution As Boolean = False
    Public ChkCdLarge As Boolean
    Public ValueCdLarge As String

    Public Chk717_CheckProd As Boolean = False
    Public Chk717_CheckAcc As Boolean = False

    Public Chk717_Check1 As Boolean = False
    Public Chk717_Check2 As Boolean = False
    Public Chk717_Check3 As Boolean = False
    Public Chk717_Check4 As Boolean = False
    Public Chk717_Check5 As Boolean = False
    Public Chk717_Check6 As Boolean = False
    Public Chk717_Check7 As Boolean = False
    Public Chk717_Check8 As Boolean = False
    Public Chk717_Check9 As Boolean = False
    Public Chk717_Check10 As Boolean = False

    Public chkLast As Boolean = False
    Public chkMold As Boolean = False
    Public chkCut As Boolean = False
    Public List_Customer As New List(Of String)

    Public language As ResourceManager
#End Region

#Region "Methods"

#Region "System"
    Public Function READ_PFK7120_CODE(ShoesCode As String, MAMaID As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7120 "
            SQL = SQL & " WHERE K7120_ShoesCode		 =  '" & ShoesCode & "'  "
            SQL = SQL & " AND   K7120_MAMaID		 =  '" & MAMaID & "'  "

            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK7120", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    Public Function READ_SHEETPRINT_MATCHING(PROG As String) As Boolean
        READ_SHEETPRINT_MATCHING = False
        Try
            SQL = "SELECT *  FROM [CS_PRINT].[dbo].[A_SHEETPRINT_MATCHING] "
            SQL = SQL + " WHERE [PROG] = '" + PROG + "'"

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = False Then GoTo pass
            READ_SHEETPRINT_MATCHING = True
        Catch ex As Exception

        End Try
pass:
        rd.Close()
    End Function

    Public Function READ_SHEETPRINT_MATCHING_MULTI(PROG As String, SheetReportName As String) As Boolean
        READ_SHEETPRINT_MATCHING_MULTI = False
        Try
            SQL = "SELECT *  FROM [CS_PRINT].[dbo].[A_SHEETPRINT_MATCHING_MULTI] "
            SQL = SQL + " WHERE [PROG]          = '" + PROG + "'"
            SQL = SQL + "   AND [SHEETREPORT]   = '" + SheetReportName + "'"

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = False Then GoTo pass
            READ_SHEETPRINT_MATCHING_MULTI = True
        Catch ex As Exception

        End Try
pass:
        rd.Close()
    End Function
#End Region
#Region "0000"
    Public Function DELETE_PFK0000_PACKINGBATCH(PackingBatch As String) As Boolean
        DELETE_PFK0000_PACKINGBATCH = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK0000 "
            SQL = SQL & " WHERE K0000_PackingBatch		 =  '" & PackingBatch & "'  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK0000_PACKINGBATCH = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK0000", vbCritical)
        End Try
    End Function
    Public Function DELETE_PFK0001_PACKINGBATCH(PackingBatch As String) As Boolean
        DELETE_PFK0001_PACKINGBATCH = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK0001 "
            SQL = SQL & " WHERE K0001_PackingBatch		 =  '" & PackingBatch & "'  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK0001_PACKINGBATCH = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK0001", vbCritical)
        End Try
    End Function
    Public Function READ_PFK0175_BatchShoes(BatchShoes As String, CheckL As String, CheckR As String) As Boolean
        READ_PFK0175_BatchShoes = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK0175 "
            SQL = SQL & " WHERE K0175_BatchShoes		 = '" & BatchShoes & "' "
            SQL = SQL & "   AND K0175_CheckL		 = '" & CheckL & "' "
            SQL = SQL & "   AND K0175_CheckR		 = '" & CheckR & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D0175_CLEAR() : GoTo SKIP_READ_PFK0175

            Call K0175_MOVE(rd)
            READ_PFK0175_BatchShoes = True

SKIP_READ_PFK0175:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK0175", vbCritical)
        End Try
    End Function
    Public Function DELETE_PFK0109_SIZE_TO_SIZE(z0108 As T0108_AREA) As Boolean
        DELETE_PFK0109_SIZE_TO_SIZE = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK0109 "
            SQL = SQL & " WHERE K0109_SpecNo		 =   '" & z0108.SpecNo & "' "
            SQL = SQL & " AND K0109_SpecNoSeq		 =   '" & z0108.SpecNoSeq & "' "
            SQL = SQL & " AND K0109_MaterialSeq	 =   " & z0108.MaterialSeq & ""
            SQL = SQL & " AND K0109_SizeNo		 >=   '" & z0108.SizeBegin & "' "
            SQL = SQL & " AND K0109_SizeNo		 <=   '" & z0108.SizeEnd & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK0109_SIZE_TO_SIZE = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK0109", vbCritical)
        End Try
    End Function
    Public Function READ_PFK0111_COMPONENT(SPECNO As String, SPECNOSEQ As String, COMPONENTNAME As String) As Boolean
        READ_PFK0111_COMPONENT = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK0111 "
            SQL = SQL & " WHERE K0111_SpecNo		 = '" & SPECNO & "' "
            SQL = SQL & "   AND K0111_SpecNoSeq		 = '" & SPECNOSEQ & "' "
            SQL = SQL & "   AND K0111_ComponentName		 = '" & FormatSQL(COMPONENTNAME) & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D0111_CLEAR() : GoTo SKIP_READ_PFK0111

            Call K0111_MOVE(rd)
            READ_PFK0111_COMPONENT = True

SKIP_READ_PFK0111:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK0111", vbCritical)
        End Try
    End Function
    Public Function READ_PFK0101_1(OrderNo As String, OrderNoSeq As String) As Boolean
        READ_PFK0101_1 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK0101 "
            SQL = SQL & " WHERE K0101_OrderNo		 = '" & OrderNo & "' "
            SQL = SQL & " AND K0101_OrderNoSeq		 = '" & OrderNoSeq & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D0101_CLEAR() : GoTo SKIP_READ_PFK0101

            Call K0101_MOVE(rd)
            READ_PFK0101_1 = True

SKIP_READ_PFK0101:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK0101", vbCritical)
        End Try
    End Function
    Public Function READ_PFK0175_BatchNo(BatchNo As String) As Boolean
        READ_PFK0175_BatchNo = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK0175 "
            SQL = SQL & " WHERE K0175_BatchNo		 = '" & BatchNo & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D0175_CLEAR() : GoTo SKIP_READ_PFK0175

            Call K0175_MOVE(rd)
            READ_PFK0175_BatchNo = True

SKIP_READ_PFK0175:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK0175", vbCritical)
        End Try
    End Function
    Public Function READ_PFK0102_1(OrderNo As String, OrderNoSeq As String) As Boolean
        READ_PFK0102_1 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK0102 INNER JOIN PFK0101 ON K0102_SpecNo = K0101_SpecNo "
            SQL = SQL & " WHERE K0101_OrderNo		 = '" & OrderNo & "' "
            SQL = SQL & " AND K0101_OrderNoSeq		 = '" & OrderNoSeq & "' "
            SQL = SQL & " AND K0102_SpecNoSeq		 = '001' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D0102_CLEAR() : GoTo SKIP_READ_PFK0102

            Call K0102_MOVE(rd)
            READ_PFK0102_1 = True

SKIP_READ_PFK0102:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK0102", vbCritical)
        End Try
    End Function
    Public Function READ_PFK0111_SEQ(SPECNO As String, SPECNOSEQ As String, cdGroupComponent As String, ComponentName As String) As Boolean
        READ_PFK0111_SEQ = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK0111 "
            SQL = SQL & " WHERE K0111_SpecNo		    = '" & SPECNO & "' "
            SQL = SQL & "   AND K0111_SpecNoSeq		    = '" & SPECNOSEQ & "' "
            SQL = SQL & "   AND K0111_cdGroupComponent	=  '" & cdGroupComponent & "'  "
            SQL = SQL & "   AND K0111_ComponentName	  =  '" & FormatSQL(Trim(ComponentName)) & "'  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D0111_CLEAR() : GoTo SKIP_READ_PFK0111

            Call K0111_MOVE(rd)
            READ_PFK0111_SEQ = True

SKIP_READ_PFK0111:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK0111", vbCritical)
        End Try
    End Function
    Public Function READ_PFK0102_OrderNo(SPECNO As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK0102 "
            SQL = SQL & " WHERE K0102_SpecNo		 = '" & SPECNO & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK0102_OrderNo", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function
    Public Function READ_PFK0102_SPECNO(OrderNo As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK0102 INNER JOIN PFK0101 ON K0101_SpecNo = K0102_SpecNo"
            SQL = SQL & " WHERE K0101_OrderNo		 = '" & OrderNo & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK0102_OrderNo", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function


#End Region

#Region "1000"
    Public Function FilenameIsOK(ByVal fileName As String) As Boolean
        Dim file As String = Path.GetFileName(fileName)
        Dim directory As String = Path.GetDirectoryName(fileName)

        Return Not (file.Intersect(Path.GetInvalidFileNameChars()).Any() _
                    OrElse _
                    directory.Intersect(Path.GetInvalidPathChars()).Any())
    End Function

    Public Function READ_PFK1312_SEASON(cdSeason As String, SLNo As String) As Boolean
        READ_PFK1312_SEASON = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK1312 INNER JOIN PFK7106 ON K7106_ShoesCode = k1312_ShoesCode"
            SQL = SQL & " WHERE K7106_cdSeason		 = '" & cdSeason & "' "
            SQL = SQL & "   AND K1312_SLNo		 = '" & SLNo & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D1312_CLEAR() : GoTo SKIP_READ_PFK1312

            Call K1312_MOVE(rd)
            READ_PFK1312_SEASON = True

SKIP_READ_PFK1312:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK1312", vbCritical)
        End Try
    End Function
    Public Function READ_PFK1312_SLNO_PONO(ShoesCode As String, PONO As String) As Boolean
        READ_PFK1312_SLNO_PONO = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK1312 INNER JOIN PFK7106 ON K7106_ShoesCode = k1312_ShoesCode"
            SQL = SQL & " WHERE K7106_ShoesCode		 = '" & ShoesCode & "' "
            SQL = SQL & "   AND K1312_PONO		 = '" & FormatCut(PONO) & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D1312_CLEAR() : GoTo SKIP_READ_PFK1312

            Call K1312_MOVE(rd)
            READ_PFK1312_SLNO_PONO = True

SKIP_READ_PFK1312:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK1312", vbCritical)
        End Try
    End Function
    Public Function READ_PFK1315_ORDERNO(ORDERNO As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK1315 "
            SQL = SQL & " WHERE K1315_OrderNo		 = '" & ORDERNO & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK1315", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function
    Public Function READ_PFK1314_ORDERNO(ORDERNO As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK1314 "
            SQL = SQL & " WHERE K1314_OrderNo		 = '" & ORDERNO & "' "
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
    Public Function READ_PFK1317_SUBPROCESS(ORDERNO As String, ORDERNOSEQ As String, cdSubProcess As String) As Boolean
        READ_PFK1317_SUBPROCESS = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK1317 "
            SQL = SQL & " WHERE K1317_OrderNo		 = '" & ORDERNO & "' "
            SQL = SQL & "   AND K1317_OrderNoSeq		 = '" & ORDERNOSEQ & "' "
            SQL = SQL & "   AND K1317_cdSubProcess		  = '" & cdSubProcess & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D1317_CLEAR() : GoTo SKIP_READ_PFK1317

            Call K1317_MOVE(rd)
            READ_PFK1317_SUBPROCESS = True

SKIP_READ_PFK1317:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK1317", vbCritical)
        End Try
    End Function
    Public Function READ_PFK1312_APPROVAL(ORDERNO As String) As Boolean
        READ_PFK1312_APPROVAL = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK1312 "
            SQL = SQL & " WHERE K1312_OrderNo		     = '" & ORDERNO & "' "
            SQL = SQL & "   AND K1312_OrderDetailStatus	 = '3' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D1312_CLEAR() : GoTo SKIP_READ_PFK1312

            READ_PFK1312_APPROVAL = True

SKIP_READ_PFK1312:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK1312", vbCritical)
        End Try
    End Function
    Public Function READ_PFK1412_APPROVAL(ORDERNO As String) As Boolean
        READ_PFK1412_APPROVAL = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK1412 "
            SQL = SQL & " WHERE K1412_OrderNo		     = '" & ORDERNO & "' "
            SQL = SQL & "   AND K1412_OrderDetailStatus	 = '3' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D1412_CLEAR() : GoTo SKIP_READ_PFK1412

            READ_PFK1412_APPROVAL = True

SKIP_READ_PFK1412:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK1412", vbCritical)
        End Try
    End Function
    Public Function READ_PFK1412_COMPLETE(ORDERNO As String) As Boolean
        READ_PFK1412_COMPLETE = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK1412 "
            SQL = SQL & " WHERE K1412_OrderNo		     = '" & ORDERNO & "' "
            SQL = SQL & "   AND K1412_OrderDetailStatus	 = '2' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D1412_CLEAR() : GoTo SKIP_READ_PFK1412

            READ_PFK1412_COMPLETE = True

SKIP_READ_PFK1412:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK1412", vbCritical)
        End Try
    End Function
    Public Function READ_PFK1312_ORDERNO(ORDERNO As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK1312 "
            SQL = SQL & " WHERE K1312_OrderNo		 = '" & ORDERNO & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK1312", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function
    Public Function READ_PFK1313_ORDERNO(ORDERNO As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK1313 "
            SQL = SQL & " WHERE K1313_OrderNo		 = '" & ORDERNO & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK1313", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function
    Public Function READ_PFK1412_ORDERNO(ORDERNO As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK1412 "
            SQL = SQL & " WHERE K1412_OrderNo		 = '" & ORDERNO & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK1412", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function
    Public Function READ_PFK1413_ORDERNO(ORDERNO As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK1413 "
            SQL = SQL & " WHERE K1413_OrderNo		 = '" & ORDERNO & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK1413", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function
    Public Function READ_PFK1316_ORDERNO(ORDERNO As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK1316 "
            SQL = SQL & " WHERE K1316_OrderNo		 = '" & ORDERNO & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK1316", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function
    Public Function READ_PFK1316_ORDERNOSEQ(ORDERNO As String, ORDERNOSEQ As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK1316 "
            SQL = SQL & " WHERE K1316_OrderNo		 = '" & ORDERNO & "' "
            SQL = SQL & " AND K1316_OrderNoSeq		 = '" & ORDERNOSEQ & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK1316", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function
    Public Function READ_PFK1314_ORDERNOSEQ(ORDERNO As String, ORDERNOSEQ As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK1314 "
            SQL = SQL & " WHERE K1314_OrderNo		 = '" & ORDERNO & "' "
            SQL = SQL & "   AND K1314_OrderNoSeq		 = '" & ORDERNOSEQ & "' "
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



#End Region

#Region "2000"
    Public Function READ_PFK2356_JobCardWorking(JobCardWorking As String) As Boolean
        READ_PFK2356_JobCardWorking = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK2356 "
            SQL = SQL & " WHERE K2356_JobCardWorking		 = '" & JobCardWorking & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D2356_CLEAR() : GoTo SKIP_READ_PFK2356

            Call K2356_MOVE(rd)
            READ_PFK2356_JobCardWorking = True

SKIP_READ_PFK2356:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK2356", vbCritical)
        End Try
    End Function


    Public Function READ_PFK2356_TRANSFERVOUCHER(InvoiceNo As String) As Boolean
        READ_PFK2356_TRANSFERVOUCHER = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK2356 "
            SQL = SQL & " WHERE K2356_InvoiceNo		 = '" & InvoiceNo & "' "
            SQL = SQL & " AND    K2356_cdSite		 = '" & Pub.SITE & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D2356_CLEAR() : GoTo SKIP_READ_PFK2356

            Call K2356_MOVE(rd)
            READ_PFK2356_TRANSFERVOUCHER = True

SKIP_READ_PFK2356:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK2356", vbCritical)
        End Try
    End Function

    Public Function READ_PFK2656_BarcodePacking(BarcodePacking As String) As Boolean
        READ_PFK2656_BarcodePacking = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK2656 "
            SQL = SQL & " WHERE K2656_BarcodePacking		 =   '" & BarcodePacking & "'"
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D2656_CLEAR() : GoTo SKIP_READ_PFK2656

            Call K2656_MOVE(rd)
            READ_PFK2656_BarcodePacking = True

SKIP_READ_PFK2656:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7214", vbCritical)
        End Try
    End Function
    Public Function READ_PFK2554_AUTOKEY(MATERIALINBOUNDNO As String, MATERIALINBOUNDSEQ As String, MATERIALINBOUNDSNO As Double) As Boolean
        READ_PFK2554_AUTOKEY = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK2554 "
            SQL = SQL & " WHERE K2352_MaterialInBoundNo   = '" & MATERIALINBOUNDNO & "' "
            SQL = SQL & "   AND K2352_MaterialInBoundSeq   = '" & MATERIALINBOUNDSEQ & "' "
            SQL = SQL & "   AND K2352_MaterialInBoundSno   =  " & MATERIALINBOUNDSNO & "  ORDER BY K2554_Autokey DESC "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D2554_CLEAR() : GoTo SKIP_READ_PFK2554

            Call K2554_MOVE(rd)
            READ_PFK2554_AUTOKEY = True

SKIP_READ_PFK2554:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK2554", vbCritical)
        End Try
    End Function
    Public Function READ_PFK2555_AUTOKEY(MATERIALINBOUNDNO As String, MATERIALINBOUNDSEQ As String, MATERIALINBOUNDSNO As Double) As Boolean
        READ_PFK2555_AUTOKEY = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK2555 "
            SQL = SQL & " WHERE K2352_MaterialInBoundNo   = '" & MATERIALINBOUNDNO & "' "
            SQL = SQL & "   AND K2352_MaterialInBoundSeq   = '" & MATERIALINBOUNDSEQ & "' "
            SQL = SQL & "   AND K2352_MaterialInBoundSno   =  " & MATERIALINBOUNDSNO & "  ORDER BY K2555_Autokey DESC "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D2555_CLEAR() : GoTo SKIP_READ_PFK2555

            Call K2555_MOVE(rd)
            READ_PFK2555_AUTOKEY = True

SKIP_READ_PFK2555:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK2555", vbCritical)
        End Try
    End Function
    Public Function DELETE_PFK2651_Autokey_4958(Autokey_4958 As Double) As Boolean
        DELETE_PFK2651_Autokey_4958 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK2651 "
            SQL = SQL & " WHERE K2651_Autokey_4958		 = '" & Autokey_4958 & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK2651_Autokey_4958 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK2651_Autokey_4958", vbCritical)
        End Try
    End Function
    Public Function READ_PFK2552_AUTOKEY(MATERIALINBOUNDNO As String, MATERIALINBOUNDSEQ As String, MATERIALINBOUNDSNO As Double) As Boolean
        READ_PFK2552_AUTOKEY = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK2552 "
            SQL = SQL & " WHERE K2352_MaterialInBoundNo		 = '" & MATERIALINBOUNDNO & "' "
            SQL = SQL & "   AND K2352_MaterialInBoundSeq		 = '" & MATERIALINBOUNDSEQ & "' "
            SQL = SQL & "   AND K2352_MaterialInBoundSno		 =  " & MATERIALINBOUNDSNO & "  ORDER BY K2552_Autokey DESC "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D2552_CLEAR() : GoTo SKIP_READ_PFK2552

            Call K2552_MOVE(rd)
            READ_PFK2552_AUTOKEY = True

SKIP_READ_PFK2552:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK2552", vbCritical)
        End Try
    End Function
    Public Function READ_PFK2553_AUTOKEY(MATERIALINBOUNDNO As String, MATERIALINBOUNDSEQ As String, MATERIALINBOUNDSNO As Double) As Boolean
        READ_PFK2553_AUTOKEY = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK2553 "
            SQL = SQL & " WHERE K2352_MaterialInBoundNo		 = '" & MATERIALINBOUNDNO & "' "
            SQL = SQL & "   AND K2352_MaterialInBoundSeq		 = '" & MATERIALINBOUNDSEQ & "' "
            SQL = SQL & "   AND K2352_MaterialInBoundSno		 =  " & MATERIALINBOUNDSNO & "  ORDER BY K2553_Autokey DESC "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D2553_CLEAR() : GoTo SKIP_READ_PFK2553

            Call K2553_MOVE(rd)
            READ_PFK2553_AUTOKEY = True

SKIP_READ_PFK2553:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK2553", vbCritical)
        End Try
    End Function
    Public Function READ_PFK2451_1(BatchNo As String) As Boolean
        READ_PFK2451_1 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK2451 "
            SQL = SQL & " WHERE K2451_BatchNo		 = '" & BatchNo & "' "
            SQL = SQL & "   AND K2451_KindProduct	 = '2' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D2451_CLEAR() : GoTo SKIP_READ_PFK2451

            Call K2451_MOVE(rd)
            READ_PFK2451_1 = True

SKIP_READ_PFK2451:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK2451", vbCritical)
        End Try
    End Function
    Public Function READ_PFK2451_1(CheckInBoundWH As String, LotNO As String, LotNoSeq As Double) As Boolean
        READ_PFK2451_1 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK2451 "
            SQL = SQL & " WHERE K2451_LotNO		             = '" & LotNO & "' "
            SQL = SQL & "   AND K2451_LotNoSeq		         =  " & LotNoSeq & "  "

            'SQL = " SELECT * FROM PFK2451 "
            'SQL = SQL & " WHERE K2451_CheckInBoundWH		 = '" & CheckInBoundWH & "' "
            'SQL = SQL & "   AND K2451_LotNO		             = '" & LotNO & "' "
            'SQL = SQL & "   AND K2451_LotNoSeq		         =  " & LotNoSeq & "  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D2451_CLEAR() : GoTo SKIP_READ_PFK2451

            Call K2451_MOVE(rd)
            READ_PFK2451_1 = True

SKIP_READ_PFK2451:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK2451", vbCritical)
        End Try
    End Function
    Public Function READ_PFK2352_1(LotNO As String, LotNoSeq As String) As Boolean
        READ_PFK2352_1 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK2352 "
            SQL = SQL & " WHERE K2352_LotNO		    = '" & LotNO & "' "
            SQL = SQL & "   AND K2352_LotNoSeq		= '" & LotNoSeq & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D2352_CLEAR() : GoTo SKIP_READ_PFK2352

            Call K2352_MOVE(rd)
            READ_PFK2352_1 = True

SKIP_READ_PFK2352:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK2352", vbCritical)
        End Try
    End Function
    Public Function READ_PFK2351_1(LotNo As String) As Boolean
        READ_PFK2351_1 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK2351 "
            SQL = SQL & " WHERE K2351_LotNo		 = '" & LotNo & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D2351_CLEAR() : GoTo SKIP_READ_PFK2351

            Call K2351_MOVE(rd)
            READ_PFK2351_1 = True

SKIP_READ_PFK2351:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK2351", vbCritical)
        End Try
    End Function
    Public Function READ_PFK2456_1(LotNO As String) As Boolean
        READ_PFK2456_1 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK2456 "
            SQL = SQL & " WHERE K2456_LotNO		 = '" & LotNO & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D2456_CLEAR() : GoTo SKIP_READ_PFK2456

            Call K2456_MOVE(rd)
            READ_PFK2456_1 = True

SKIP_READ_PFK2456:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK2456", vbCritical)
        End Try
    End Function



#End Region

#Region "3000"
    Public Function READ_PFK3452_AUTOKEY(AUTOKEY As String) As Boolean
        READ_PFK3452_AUTOKEY = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3452 "
            SQL = SQL & " WHERE K3452_AUTOKEY		 =  " & AUTOKEY & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D3452_CLEAR() : GoTo SKIP_READ_PFK3452

            Call K3452_MOVE(rd)
            READ_PFK3452_AUTOKEY = True

SKIP_READ_PFK3452:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK3452", vbCritical)
        End Try
    End Function
    Public Function READ_PFK3429_TOP1(FactOrderNo As String) As Boolean
        READ_PFK3429_TOP1 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK3429 "
            SQL = SQL & " WHERE K3429_FactOrderNo		 = '" & FactOrderNo & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D3429_CLEAR() : GoTo SKIP_READ_PFK3429

            Call K3429_MOVE(rd)
            READ_PFK3429_TOP1 = True

SKIP_READ_PFK3429:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK3429", vbCritical)
        End Try
    End Function
    Public Function READ_PFK3429_FactOrder(FactOrderNo As String, FactOrderSeq As String)
        READ_PFK3429_FactOrder = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK3429 "
            SQL = SQL & " WHERE K3429_FactOrderNo		 = '" & FactOrderNo & "' "

            If FactOrderSeq <> "" Then
                SQL = SQL & " AND K3429_FactOrderSeq		 = '" & FactOrderSeq & "' "
            End If

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D3429_CLEAR() : GoTo SKIP_READ_PFK3429

            Call K3429_MOVE(rd)
            READ_PFK3429_FactOrder = True

SKIP_READ_PFK3429:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK3429_FactOrder", vbCritical)
        End Try
    End Function
    Public Function READ_PFK3429_MaterialInBoundNo(MaterialInBoundNo As String, MaterialInBoundSeq As String)
        READ_PFK3429_MaterialInBoundNo = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK3429 "
            SQL = SQL & " WHERE K3429_MaterialInBoundNo		 = '" & MaterialInBoundNo & "' "

            If MaterialInBoundSeq <> "" Then
                SQL = SQL & " AND K3429_MaterialInBoundSeq		 = '" & MaterialInBoundSeq & "' "
            End If

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D3429_CLEAR() : GoTo SKIP_READ_PFK3429

            Call K3429_MOVE(rd)
            READ_PFK3429_MaterialInBoundNo = True

SKIP_READ_PFK3429:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK3429_MaterialInBoundNo", vbCritical)
        End Try
    End Function
    Public Function READ_PFK3011_1(PRNO As String) As Boolean
        READ_PFK3011_1 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK3011 "
            SQL = SQL & " WHERE K3011_PRNo		 =  '" & PRNO & "'  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D3011_CLEAR() : GoTo SKIP_READ_PFK3011

            Call K3011_MOVE(rd)
            READ_PFK3011_1 = True

SKIP_READ_PFK3011:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK3011", vbCritical)
        End Try
    End Function

    Public Function READ_PFK3011_ORDERNO(OrderNo As String, OrderNoSeq As String) As Boolean
        READ_PFK3011_ORDERNO = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK3011 "
            SQL = SQL & " WHERE K3011_OrderNo		 =  '" & OrderNo & "'  "
            SQL = SQL & " AND   K3011_OrderNoSeq		 =  '" & OrderNoSeq & "'  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D3011_CLEAR() : GoTo SKIP_READ_PFK3011

            Call K3011_MOVE(rd)
            READ_PFK3011_ORDERNO = True

SKIP_READ_PFK3011:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK3011", vbCritical)
        End Try
    End Function
    Public Function READ_PFK1310_ORDERNO(OrderNo As String, OrderNoSeq As String) As Boolean
        READ_PFK1310_ORDERNO = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK1310 "
            SQL = SQL & " WHERE K1310_OrderNo		 =  '" & OrderNo & "'  "
            SQL = SQL & " AND   K1310_OrderNoSeq		 =  '" & OrderNoSeq & "'  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D1310_CLEAR() : GoTo SKIP_READ_PFK1310

            Call K1310_MOVE(rd)
            READ_PFK1310_ORDERNO = True

SKIP_READ_PFK1310:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK1310", vbCritical)
        End Try
    End Function

    Public Function READ_PFK1310_AUTOKEY(OrderNo As String, OrderNoSeq As String, MaterialCode As String, Specification As String, ColorCode As String, SizeName As String) As Boolean
        READ_PFK1310_AUTOKEY = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK1310 "
            SQL = SQL & " WHERE K1310_OrderNo		 =  N'" & FormatSQL(OrderNo) & "'  "
            SQL = SQL & " AND   K1310_OrderNoSeq		 =  '" & OrderNoSeq & "'  "
            SQL = SQL & " AND   K1310_MaterialCode		 =   N'" & FormatSQL(MaterialCode) & "'  "
            SQL = SQL & " AND   K1310_Specification		 =   N'" & FormatSQL(Specification) & "'  "
            SQL = SQL & " AND   K1310_ColorCode		 =  '" & ColorCode & "'  "
            SQL = SQL & " AND   K1310_SizeName		 =  N'" & FormatSQL(SizeName) & "'  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D1310_CLEAR() : GoTo SKIP_READ_PFK1310

            Call K1310_MOVE(rd)
            READ_PFK1310_AUTOKEY = True

SKIP_READ_PFK1310:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK1310", vbCritical)
        End Try
    End Function

    Public Function READ_PFK3011_1(PRNO As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3011 "
            SQL = SQL & "   WHERE K3011_PRNo		 = '" & PRNO & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK3011", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function
    Public Function READ_PFK3011_LINE(PRNO As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK3011 "
            SQL = SQL & "   WHERE K3011_PRNo		 = '" & PRNO & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK3011", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function
 

    Public Function READ_PFK3412_DELETE(PurchasingOrderNo As String, PurchasingOrderSeq As Double) As Boolean
        READ_PFK3412_DELETE = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3412 "
            SQL = SQL & " WHERE K3412_PurchasingOrderNo		 = '" & PurchasingOrderNo & "' "
            SQL = SQL & "   AND K3412_PurchasingOrderSeq		 =  " & PurchasingOrderSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D3412_CLEAR() : GoTo SKIP_READ_PFK3412

            Call K3412_MOVE(rd)
            READ_PFK3412_DELETE = True

SKIP_READ_PFK3412:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK3412", vbCritical)
        End Try
    End Function
    Public Function READ_PFK3412_1(PurchasingOrderNo As String) As Boolean
        READ_PFK3412_1 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3412 "
            SQL = SQL & "   WHERE K3412_PurchasingOrderNo		 = '" & PurchasingOrderNo & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D3412_CLEAR() : GoTo SKIP_READ_PFK3412

            Call K3412_MOVE(rd)
            READ_PFK3412_1 = True

SKIP_READ_PFK3412:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK3412", vbCritical)
        End Try
    End Function
    Public Function READ_PFK3412_1(PurchasingOrderNo As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3412 "
            SQL = SQL & "   WHERE K3412_PurchasingOrderNo		 = '" & PurchasingOrderNo & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK3412", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    Public Function READ_PFK2346_1(PurchasingOrderNo As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK2346 "
            SQL = SQL & "   WHERE K2346_PurchasingOrderNo		 = '" & PurchasingOrderNo & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK2346", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function
    Public Function READ_PFK3422_1(FactOrderNo As String) As Boolean
        READ_PFK3422_1 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3422 "
            SQL = SQL & "   WHERE K3422_FactOrderNo		 = '" & FactOrderNo & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D3422_CLEAR() : GoTo SKIP_READ_PFK3422

            Call K3422_MOVE(rd)
            READ_PFK3422_1 = True

SKIP_READ_PFK3422:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK3422", vbCritical)
        End Try
    End Function

    Public Function READ_PFK2346_1(FactOrderNo As String) As Boolean
        READ_PFK2346_1 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK2346 "
            SQL = SQL & "   WHERE K2346_FactOrderNo		 = '" & FactOrderNo & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D2346_CLEAR() : GoTo SKIP_READ_PFK2346

            Call K2346_MOVE(rd)
            READ_PFK2346_1 = True

SKIP_READ_PFK2346:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK2346_1", vbCritical)
        End Try
    End Function
    Public Function DELETE_PFK3423_1(FactOrderNo As String) As Boolean
        DELETE_PFK3423_1 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK3423 "
            SQL = SQL & " WHERE K3423_FactOrderNo		 = '" & FactOrderNo & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK3423_1 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK3423_1", vbCritical)
        End Try
    End Function
    Public Function READ_PFK3452_1(FactOrderNo As String) As Boolean
        READ_PFK3452_1 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3452 "
            SQL = SQL & "   WHERE K3452_FactOrderNo		 = '" & FactOrderNo & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D3452_CLEAR() : GoTo SKIP_READ_PFK3452

            Call K3452_MOVE(rd)
            READ_PFK3452_1 = True

SKIP_READ_PFK3452:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK3422", vbCritical)
        End Try
    End Function
    Public Function READ_PFK3452_OrderNo(OrderNo As String, OrderNoSeq As String) As Boolean
        READ_PFK3452_OrderNo = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3452 "
            SQL = SQL & "   WHERE K3452_OrderNo		 = '" & OrderNo & "' "
            SQL = SQL & "   AND  K3452_OrderNoSeq		 = '" & OrderNoSeq & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D3452_CLEAR() : GoTo SKIP_READ_PFK3452

            Call K3452_MOVE(rd)
            READ_PFK3452_OrderNo = True

SKIP_READ_PFK3452:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK3422", vbCritical)
        End Try
    End Function
    Public Function READ_PFK3422_SALESORDER(SalesOrderNo As String, SalesOrderSeq As String, SalesOrderSno As String) As Boolean
        READ_PFK3422_SALESORDER = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3422 "
            SQL = SQL & "   WHERE K3422_SalesOrderNo		 = '" & SalesOrderNo & "' "
            SQL = SQL & "  AND    K3422_SalesOrderSeq		 = '" & SalesOrderSeq & "' "
            SQL = SQL & "  AND    K3422_SalesOrderSno		 = '" & SalesOrderSno & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D3422_CLEAR() : GoTo SKIP_READ_PFK3422

            Call K3422_MOVE(rd)
            READ_PFK3422_SALESORDER = True

SKIP_READ_PFK3422:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK3422", vbCritical)
        End Try
    End Function
    Public Function READ_PFK3422_1(FactOrderNo As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3422 "
            SQL = SQL & "   WHERE K3422_FactOrderNo		 = '" & FactOrderNo & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK3422", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function
    Public Function READ_PFK3422_DELETE(FactOrderNo As String, FactOrderSeq As Double) As Boolean
        READ_PFK3422_DELETE = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3422 "
            SQL = SQL & " WHERE K3422_FactOrderNo		 = '" & FactOrderNo & "' "
            SQL = SQL & "   AND K3422_FactOrderSeq		 =  " & FactOrderSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D3422_CLEAR() : GoTo SKIP_READ_PFK3422

            Call K3422_MOVE(rd)
            READ_PFK3422_DELETE = True

SKIP_READ_PFK3422:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK3422", vbCritical)
        End Try
    End Function
    Public Function REWRITE_PFK3011_MASTER(z3011 As T3011_AREA) As Boolean
        REWRITE_PFK3011_MASTER = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " UPDATE PFK3011 SET "
            SQL = SQL & "    K3011_seDepartment      = N'" & FormatSQL(z3011.seDepartment) & "', "
            SQL = SQL & "    K3011_cdDepartment      = N'" & FormatSQL(z3011.cdDepartment) & "', "
            SQL = SQL & "    K3011_CustomerCode      = N'" & FormatSQL(z3011.CustomerCode) & "', "
            SQL = SQL & "    K3011_InchargeRequest      = N'" & FormatSQL(z3011.InchargeRequest) & "', "
            SQL = SQL & "    K3011_PRName      = N'" & FormatSQL(z3011.PRName) & "' "
            SQL = SQL & " WHERE K3011_PRNo		 =  '" & z3011.PRNo & "'  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK3011_MASTER = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK3011", vbCritical)
        End Try
    End Function
    Public Function READ_PFK3332_1(SalesOrderNo As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3332 "
            SQL = SQL & " WHERE K3332_SalesOrderNo		 = '" & SalesOrderNo & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK3333", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function
    Public Function READ_PFK3003_1(QUOTATIONNO As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3003 "
            SQL = SQL & " WHERE K3003_QuotationNo		 = '" & QUOTATIONNO & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK3003", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function
    Public Function READ_PFK3115_1(RequestPurchasingNo As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3116 "
            SQL = SQL & " WHERE K3116_RequestPurchasingNo		 = '" & RequestPurchasingNo & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK3333", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function
    Public Function READ_PFK3132_1(REQUESTPURCHASINGNO As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3132 "
            SQL = SQL & " WHERE K3132_RequestPurchasingNo		 = '" & REQUESTPURCHASINGNO & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK3132", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function
    Public Function READ_PFK3242_1(RequestSalesNo As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3242 "
            SQL = SQL & " WHERE K3242_RequestSalesNo		 = '" & RequestSalesNo & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK3242", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function
    Public Function READ_PFK3342_1(RequestSalesNo As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3342 "
            SQL = SQL & " WHERE K3342_RequestSalesNo		 = '" & RequestSalesNo & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK3342", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function
    Public Function READ_PFK3142_1(REQUESTPURCHASINGNO As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3142 "
            SQL = SQL & " WHERE K3142_RequestPurchasingNo		 = '" & REQUESTPURCHASINGNO & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK3142", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function
    Public Function READ_PFK3142_1(REQUESTPURCHASINGNO As String) As Boolean
        READ_PFK3142_1 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3142 "
            SQL = SQL & " WHERE K3142_RequestPurchasingNo		 = '" & REQUESTPURCHASINGNO & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D3142_CLEAR() : GoTo SKIP_READ_PFK3142

            Call K3142_MOVE(rd)
            READ_PFK3142_1 = True

SKIP_READ_PFK3142:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK3142", vbCritical)
        End Try
    End Function




#End Region

#Region "4000"
    Public Function READ_PFK4951_AUTOKEY(AUTOKEY As Double) As Boolean
        READ_PFK4951_AUTOKEY = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4951 "
            SQL = SQL & " WHERE K4951_Autokey_4958		 =  " & AUTOKEY & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4951_CLEAR() : GoTo SKIP_READ_PFK4951

            Call K4951_MOVE(rd)
            READ_PFK4951_AUTOKEY = True

SKIP_READ_PFK4951:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4951", vbCritical)
        End Try
    End Function

    Public Function READ_PFK4951_DIS(LOADINGCODE As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT DISTINCT K4958_OrderNo AS  KEY_OrderNo, K4958_OrderNoSeq AS KEY_OrderNoSeq FROM PFK4951  WITH (NOLOCK) INNER JOIN PFK4958 WITH (NOLOCK) ON  K4951_Autokey_4958 = K4958_Autokey "
            SQL = SQL & " WHERE K4951_LoadingCode		 = '" & LOADINGCODE & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK4951_DIS", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function
    Public Function READ_PFK4951_LOADINGCODE(LOADINGCODE As String) As Boolean
        READ_PFK4951_LOADINGCODE = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK4951 "
            SQL = SQL & " WHERE K4951_LoadingCode		 = '" & LOADINGCODE & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4951_CLEAR() : GoTo SKIP_READ_PFK4951

            Call K4951_MOVE(rd)
            READ_PFK4951_LOADINGCODE = True

SKIP_READ_PFK4951:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4951_LOADINGCODE", vbCritical)
        End Try
    End Function
    Public Function READ_PFK4951_LOADINGCODE(LOADINGCODE As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4951 "
            SQL = SQL & " WHERE K4951_LoadingCode		 = '" & LOADINGCODE & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK4951", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function
    Public Function READ_PFK9950_ProgramNo(ProgramNo As String) As Boolean
        READ_PFK9950_ProgramNo = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK9950 "
            SQL = SQL & " WHERE K9950_ProgramNo		 =  '" & ProgramNo & "'  "
            SQL = SQL & " ORDER BY K9950_Autokey DESC  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9950_CLEAR() : GoTo SKIP_READ_PFK9950

            Call K9950_MOVE(rd)
            READ_PFK9950_ProgramNo = True

SKIP_READ_PFK9950:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK9950", vbCritical)
        End Try
    End Function

    Public Function READ_PFK4090_BATCHNO(BatchNo As String) As Boolean
        READ_PFK4090_BATCHNO = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK4090 "
            SQL = SQL & " WHERE K4090_BatchNo		 = '" & BatchNo & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4090_CLEAR() : GoTo SKIP_READ_PFK4090

            Call K4090_MOVE(rd)
            READ_PFK4090_BATCHNO = True

SKIP_READ_PFK4090:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4090", vbCritical)
        End Try
    End Function
    Public Function READ_PFK4075_BARCODE_PRINT(JobCard As String, CDFACTORY As String, CDMAINPROCESS As String, CDLINEPROD As String, LINETNO As String) As Boolean
        READ_PFK4075_BARCODE_PRINT = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK4075 "
            SQL = SQL & " WHERE K4075_cdFactory		 = '" & CDFACTORY & "' "
            SQL = SQL & "   AND K4075_cdMainProcess		 = '" & CDMAINPROCESS & "' "
            SQL = SQL & "   AND K4075_cdLineProd		 = '" & CDLINEPROD & "' "
            SQL = SQL & "   AND K4075_LineTno		 = '" & LINETNO & "' "
            SQL = SQL & "   AND K4075_JobCard		 = '" & JobCard & "' "
            SQL = SQL & "   AND K4075_DatePrint		 <> '' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4075_CLEAR() : GoTo SKIP_READ_PFK4075

            Call K4075_MOVE(rd)
            READ_PFK4075_BARCODE_PRINT = True

SKIP_READ_PFK4075:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4075", vbCritical)
        End Try
    End Function
    Public Function READ_PFK4075_BARCODE_PRINT_DELETE(JobCard As String, CDFACTORY As String, CDMAINPROCESS As String, CDLINEPROD As String, LINETNO As String) As Boolean
        READ_PFK4075_BARCODE_PRINT_DELETE = False
        Exit Function '- 2019/07/03 3:42pm hung

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK4075 "
            SQL = SQL & " WHERE K4075_cdFactory		 = '" & CDFACTORY & "' "
            SQL = SQL & "   AND K4075_cdMainProcess		 = '" & CDMAINPROCESS & "' "
            SQL = SQL & "   AND K4075_cdLineProd		 = '" & CDLINEPROD & "' "
            SQL = SQL & "   AND K4075_LineTno		 = '" & LINETNO & "' "
            SQL = SQL & "   AND K4075_JobCard		 = '" & JobCard & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            READ_PFK4075_BARCODE_PRINT_DELETE = True

SKIP_READ_PFK4075:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4075", vbCritical)
        End Try
    End Function
    Public Function READ_PFK4075_BARCODE_PRODUCTION(JobCard As String, CDFACTORY As String, CDMAINPROCESS As String, CDLINEPROD As String, LINETNO As String) As Boolean
        READ_PFK4075_BARCODE_PRODUCTION = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK4090 INNER JOIN PFK4075 ON K4075_BatchNo = K4090_BatchNo "
            SQL = SQL & " WHERE K4075_cdFactory		 = '" & CDFACTORY & "' "
            SQL = SQL & "   AND K4075_cdMainProcess		 = '" & CDMAINPROCESS & "' "
            SQL = SQL & "   AND K4075_cdLineProd		 = '" & CDLINEPROD & "' "
            SQL = SQL & "   AND K4075_LineTno		 = '" & LINETNO & "' "
            SQL = SQL & "   AND K4075_JobCard		 = '" & JobCard & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4075_CLEAR() : GoTo SKIP_READ_PFK4075

            Call K4075_MOVE(rd)
            READ_PFK4075_BARCODE_PRODUCTION = True

SKIP_READ_PFK4075:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4075", vbCritical)
        End Try
    End Function
    Public Function READ_PFK4073_TOPJOBCARD(CDMAINPROCESS As String, JobCard As String) As Boolean
        READ_PFK4073_TOPJOBCARD = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT top 1 * FROM PFK4073 "
            SQL = SQL & " WHERE K4073_JobCard		 = '" & JobCard & "' "
            SQL = SQL & "   AND K4073_cdMainProcess		 = '" & CDMAINPROCESS & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4073_CLEAR() : GoTo SKIP_READ_PFK4073

            Call K4073_MOVE(rd)
            READ_PFK4073_TOPJOBCARD = True

SKIP_READ_PFK4073:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4073", vbCritical)
        End Try
    End Function
    Public Function REWRITE_PFK4070_TRIGGER(z4070 As T4070_AREA) As Boolean
        REWRITE_PFK4070_TRIGGER = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try

            SQL = " UPDATE PFK4070 SET "
            SQL = SQL & "    K4070_CheckTrigger      = N'" & FormatSQL(z4070.CheckTrigger) & "' "

            SQL = SQL & " WHERE K4070_cdFactory		 = '" & z4070.cdFactory & "' "
            SQL = SQL & "   AND K4070_cdMainProcess		 = '" & z4070.cdMainProcess & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK4070_TRIGGER = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK4070", vbCritical)
        End Try
    End Function
    Public Function READ_PFK4958_MAX_CT(FactOrderNo As String, FactOrderSeq As String, PKONO As String) As Boolean
        READ_PFK4958_MAX_CT = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4958 "
            SQL = SQL & " WHERE K4958_FactOrderNo	 =  '" & FactOrderNo & "'  "
            SQL = SQL & " AND K4958_FactOrderSeq     =  " & FactOrderSeq & "  "
            SQL = SQL & " AND K4958_PKONO		     =  '" & PKONO & "'  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4958_CLEAR() : GoTo SKIP_READ_PFK4958

            Call K4958_MOVE(rd)
            READ_PFK4958_MAX_CT = True

SKIP_READ_PFK4958:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4958", vbCritical)
        End Try
    End Function
    Public Function READ_PFK4958_MAX_CT_KEY3422(KEY_Autokey As String) As Boolean
        READ_PFK4958_MAX_CT_KEY3422 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4958 "
            SQL = SQL & " WHERE K4958_AutoKey_K3422	 =  '" & KEY_Autokey & "'  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4958_CLEAR() : GoTo SKIP_READ_PFK4958

            Call K4958_MOVE(rd)
            READ_PFK4958_MAX_CT_KEY3422 = True

SKIP_READ_PFK4958:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4958", vbCritical)
        End Try
    End Function
    Public Function REWRITE_PFK4075_BATCHNO(z4075 As T4075_AREA) As Boolean
        REWRITE_PFK4075_BATCHNO = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " UPDATE PFK4075 SET "
            SQL = SQL & "    K4075_DatePrint      = N'" & FormatSQL(z4075.DatePrint) & "', "
            SQL = SQL & "    K4075_InchargePrint      = N'" & FormatSQL(z4075.InchargePrint) & "' "

            SQL = SQL & " WHERE K4075_BatchNo		 = '" & z4075.BatchNo & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK4075_BATCHNO = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK4075", vbCritical)
        End Try
    End Function
    Public Function REWRITE_PFK4175_BATCHNO(z4175 As T4175_AREA) As Boolean
        REWRITE_PFK4175_BATCHNO = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " UPDATE PFK4175 SET "
            SQL = SQL & "    K4175_DatePrint      = N'" & FormatSQL(z4175.DatePrint) & "', "
            SQL = SQL & "    K4175_InchargePrint      = N'" & FormatSQL(z4175.InchargePrint) & "' "

            SQL = SQL & " WHERE K4175_BatchNo		 = '" & z4175.BatchNo & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK4175_BATCHNO = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK4175", vbCritical)
        End Try
    End Function
    Public Function DELETE_PFK4075_CANCEL(z4075 As T4075_AREA) As Boolean
        DELETE_PFK4075_CANCEL = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " UPDATE PFK4075 "
            SQL = SQL & "   SET K4075_CheckComplete	 = '3', "
            SQL = SQL & "    K4075_DateUpdate     =  '" & Pub.DAT & "', "
            SQL = SQL & "    K4075_InchargeUpdate     =  '" & Pub.SAW & "' "
            SQL = SQL & " WHERE K4075_BatchNo		 = '" & z4075.BatchNo & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK4075_CANCEL = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK4075", vbCritical)
        End Try
    End Function
    Public Function DELETE_PFK4175_CANCEL(z4175 As T4175_AREA) As Boolean
        DELETE_PFK4175_CANCEL = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE PFK4175 "
            SQL = SQL & "  WHERE K4175_BatchGroup		 = '" & z4175.BatchGroup & "' "
            SQL = SQL & "  AND   K4175_JobCard  		 = '" & z4175.JobCard & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            D9700_CLEAR()
            D9700.ActionName = " DELETE PFK4175 "
            D9700.DateCreate = Pub.DAT
            D9700.UserCode = Pub.SAW
            D9700.FormName = "ISUD4175"
            D9700.Reference = z4175.BatchGroup

            D9700.DeviceName = R9700.DeviceName
            D9700.MACAddress = R9700.MACAddress
            D9700.IPv4Address = R9700.IPv4Address
            D9700.DHCPServer = R9700.DHCPServer
            D9700.IPWan = R9700.IPWan

            D9700.DNSdomain = R9700.DNSdomain
            D9700.DHCPServer = R9700.DHCPServer

            D9700.HDDSerialNo = R9700.HDDSerialNo
            D9700.ComputerName = R9700.ComputerName
            D9700.AccountWin = R9700.AccountWin

            D9700.UserCode = Pub.SAW
            D9700.DateTimeCreate = System_Date_time()

            Call WRITE_PFK9700(D9700)

            DELETE_PFK4175_CANCEL = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK4175", vbCritical)
        End Try
    End Function
    Public Function READ_PFK4075_BatchShoes(BatchShoes As String, CheckL As String, CheckR As String) As Boolean
        READ_PFK4075_BatchShoes = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4075 "
            SQL = SQL & " WHERE K4075_BatchShoes		 = '" & BatchShoes & "' "
            SQL = SQL & "   AND K4075_CheckL		 = '" & CheckL & "' "
            SQL = SQL & "   AND K4075_CheckR		 = '" & CheckR & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4075_CLEAR() : GoTo SKIP_READ_PFK4075

            Call K4075_MOVE(rd)
            READ_PFK4075_BatchShoes = True

SKIP_READ_PFK4075:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4075", vbCritical)
        End Try
    End Function
    Public Function READ_PFK4075_BatchShoes_BatchNo(BatchShoes As String, BatchNo As String) As Boolean
        READ_PFK4075_BatchShoes_BatchNo = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4075 "
            SQL = SQL & " WHERE K4075_BatchShoes		 = '" & BatchShoes & "' "
            SQL = SQL & "   AND K4075_BatchNo		 <> '" & BatchNo & "' "


            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4075_CLEAR() : GoTo SKIP_READ_PFK4075

            Call K4075_MOVE(rd)
            READ_PFK4075_BatchShoes_BatchNo = True

SKIP_READ_PFK4075:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4075", vbCritical)
        End Try
    End Function
    Public Function READ_PFK4175_BatchShoes(BatchShoes As String, CheckL As String, CheckR As String) As Boolean
        READ_PFK4175_BatchShoes = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4175 "
            SQL = SQL & " WHERE K4175_BatchShoes		 = '" & BatchShoes & "' "
            SQL = SQL & "   AND K4175_CheckL		 = '" & CheckL & "' "
            SQL = SQL & "   AND K4175_CheckR		 = '" & CheckR & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4175_CLEAR() : GoTo SKIP_READ_PFK4175

            Call K4175_MOVE(rd)
            READ_PFK4175_BatchShoes = True

SKIP_READ_PFK4175:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4175", vbCritical)
        End Try
    End Function
    Public Function READ_PFK4075_BatchNo(BatchNo As String) As Boolean
        READ_PFK4075_BatchNo = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4075 "
            SQL = SQL & " WHERE K4075_BatchNo		 = '" & BatchNo & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4075_CLEAR() : GoTo SKIP_READ_PFK4075

            Call K4075_MOVE(rd)
            READ_PFK4075_BatchNo = True

SKIP_READ_PFK4075:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4075", vbCritical)
        End Try
    End Function
    Public Function READ_PFK4075_BatchGroup(BatchGroup As String) As Boolean
        READ_PFK4075_BatchGroup = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK4075 "
            SQL = SQL & " WHERE K4075_BatchGroup		 = '" & BatchGroup & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4075_CLEAR() : GoTo SKIP_READ_PFK4075

            Call K4075_MOVE(rd)
            READ_PFK4075_BatchGroup = True

SKIP_READ_PFK4075:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4075", vbCritical)
        End Try
    End Function
    Public Function READ_PFK4175_BatchNo(BatchNo As String) As Boolean
        READ_PFK4175_BatchNo = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT top 1 * FROM PFK4175 "
            SQL = SQL & " WHERE K4175_BatchGroup		 = '" & BatchNo & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4175_CLEAR() : GoTo SKIP_READ_PFK4175

            Call K4175_MOVE(rd)
            READ_PFK4175_BatchNo = True

SKIP_READ_PFK4175:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4175", vbCritical)
        End Try
    End Function
    Public Function READ_PFK4367_BatchGroup(BatchGroup As String) As Boolean
        READ_PFK4367_BatchGroup = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT top 1 * FROM PFK4367 "
            SQL = SQL & " WHERE K4367_BatchGroup		 = '" & BatchGroup & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then GoTo SKIP_READ_PFK4367

            READ_PFK4367_BatchGroup = True

SKIP_READ_PFK4367:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4367", vbCritical)
        End Try
    End Function
    Public Function READ_PFK4175_BatchGroup(BatchGroup As String) As Boolean
        READ_PFK4175_BatchGroup = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK4175 "
            SQL = SQL & " WHERE K4175_BatchGroup		 = '" & BatchGroup & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4175_CLEAR() : GoTo SKIP_READ_PFK4175

            Call K4175_MOVE(rd)
            READ_PFK4175_BatchGroup = True

SKIP_READ_PFK4175:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4175", vbCritical)
        End Try
    End Function


    Public Function READ_PFK4065_1(SealMaster As String, cdFactory As String, cdLineProd As String, cdMainProcess As String) As Boolean
        READ_PFK4065_1 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4065 "
            SQL = SQL & " WHERE K4065_SealMaster		 =  '" & SealMaster & "'  "
            SQL = SQL & " AND K4065_cdFactory		 =  '" & cdFactory & "'  "
            SQL = SQL & " AND K4065_cdLineProd		 =  '" & cdLineProd & "'  "
            SQL = SQL & " AND K4065_cdMainProcess	 =  '" & cdMainProcess & "'  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4065_CLEAR() : GoTo SKIP_READ_PFK4065

            Call K4065_MOVE(rd)
            READ_PFK4065_1 = True

SKIP_READ_PFK4065:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4065", vbCritical)
        End Try
    End Function
    Public Function READ_PFK4066_1(SealMaster As String, DatePlan As String, cdFactory As String, cdLineProd As String, cdMainProcess As String) As Boolean
        READ_PFK4066_1 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4066 "
            SQL = SQL & " WHERE K4066_SealMaster		 =  '" & SealMaster & "'  "
            SQL = SQL & " AND K4066_cdFactory		 =  '" & cdFactory & "'  "
            SQL = SQL & " AND K4066_DatePlan		 =  '" & DatePlan & "'  "
            SQL = SQL & " AND K4066_cdLineProd		 =  '" & cdLineProd & "'  "
            SQL = SQL & " AND K4066_cdMainProcess	 =  '" & cdMainProcess & "'  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4066_CLEAR() : GoTo SKIP_READ_PFK4066

            Call K4066_MOVE(rd)
            READ_PFK4066_1 = True

SKIP_READ_PFK4066:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4066", vbCritical)
        End Try
    End Function
    Public Function READ_PFK4025_WorkingNo(WorkingNo As String, cdMainProcess As String) As Boolean
        READ_PFK4025_WorkingNo = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1* FROM PFK4025 "
            SQL = SQL & " WHERE K4025_WorkingNo		 = '" & WorkingNo & "' "
            SQL = SQL & "   AND K4025_cdMainProcess		 = '" & cdMainProcess & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4025_CLEAR() : GoTo SKIP_READ_PFK4025

            Call K4025_MOVE(rd)
            READ_PFK4025_WorkingNo = True

SKIP_READ_PFK4025:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4025", vbCritical)
        End Try
    End Function
    Public Function READ_PFK4010_SealNo(SealNo As String) As Boolean
        READ_PFK4010_SealNo = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4010 "
            SQL = SQL & " WHERE K4010_SealNo		 = '" & SealNo & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4010_CLEAR() : GoTo SKIP_READ_PFK4010

            Call K4010_MOVE(rd)
            READ_PFK4010_SealNo = True

SKIP_READ_PFK4010:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4010", vbCritical)
        End Try
    End Function
    Public Function READ_PFK4010_SlnoD_WorkOrder_WorkOrderSeq(SlnoD As String, WorkOrder As String, WorkOrderSeq As String) As Boolean
        READ_PFK4010_SlnoD_WorkOrder_WorkOrderSeq = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4010 "
            SQL = SQL & " WHERE K4010_SlnoD		     = '" & SlnoD & "' "
            SQL = SQL & " AND K4010_WorkOrder		 = '" & WorkOrder & "' "
            SQL = SQL & " AND K4010_WorkOrderSeq	 = '" & WorkOrderSeq & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4010_CLEAR() : GoTo SKIP_READ_PFK4010

            Call K4010_MOVE(rd)
            READ_PFK4010_SlnoD_WorkOrder_WorkOrderSeq = True

SKIP_READ_PFK4010:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4010", vbCritical)
        End Try
    End Function
    Public Function READ_PFK4010_SlnoD(SlnoD As String) As Boolean
        READ_PFK4010_SlnoD = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4010 "
            SQL = SQL & " WHERE K4010_SlnoD		 = '" & SlnoD & "' ORDER BY K4010_JobCard DESC "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4010_CLEAR() : GoTo SKIP_READ_PFK4010

            Call K4010_MOVE(rd)
            READ_PFK4010_SlnoD = True

SKIP_READ_PFK4010:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4010", vbCritical)
        End Try
    End Function
    Public Function READ_PFK4002_SLNO(SLNO As String) As Boolean
        READ_PFK4002_SLNO = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4002 INNER JOIN PFK1312 ON K1312_OrderNo = K4002_OrderNo AND K1312_OrderNoSeq = K4002_OrderNoSeq"
            SQL = SQL & " WHERE K1312_SLNO		 = '" & SLNO & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4002_CLEAR() : GoTo SKIP_READ_PFK4002

            Call K4002_MOVE(rd)
            READ_PFK4002_SLNO = True

SKIP_READ_PFK4002:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4002", vbCritical)
        End Try
    End Function
    Public Function READ_PFK4002_SLNO_SEASON(cdSeason As String, SLNO As String) As Boolean
        READ_PFK4002_SLNO_SEASON = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4002 INNER JOIN PFK1312 ON K1312_OrderNo = K4002_OrderNo AND K1312_OrderNoSeq = K4002_OrderNoSeq"
            SQL = SQL & " INNER JOIN PFK7106 ON K1312_ShoesCode = K7106_ShoesCode "
            SQL = SQL & " WHERE K1312_SLNO		 = '" & SLNO & "' "
            SQL = SQL & " AND K7106_cdSeason		 = '" & cdSeason & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4002_CLEAR() : GoTo SKIP_READ_PFK4002

            Call K4002_MOVE(rd)
            READ_PFK4002_SLNO_SEASON = True

SKIP_READ_PFK4002:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4002", vbCritical)
        End Try
    End Function
    Public Function READ_PFK4010_SLNO_SEASON(cdSeason As String, SLNO As String) As Boolean
        READ_PFK4010_SLNO_SEASON = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4010 INNER JOIN PFK4002 ON K4002_WorkOrder = K4010_WorkOrder AND K4002_WorkOrderSeq = K4010_WorkOrderSeq"
            SQL = SQL & " INNER JOIN PFK1312 ON K1312_OrderNo = K4002_OrderNo AND K1312_OrderNoSeq = K4002_OrderNoSeq "
            SQL = SQL & " INNER JOIN PFK7106 ON K1312_ShoesCode = K7106_ShoesCode "
            SQL = SQL & " WHERE K4010_SlNoD		 = '" & SLNO & "' "
            SQL = SQL & " AND K7106_cdSeason		 = '" & cdSeason & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4010_CLEAR() : GoTo SKIP_READ_PFK4010

            Call K4010_MOVE(rd)
            READ_PFK4010_SLNO_SEASON = True

SKIP_READ_PFK4010:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4010", vbCritical)
        End Try
    End Function
    Public Function READ_PFK4002_SealMaster(SealMaster As String) As Boolean
        READ_PFK4002_SealMaster = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4002 "
            SQL = SQL & " WHERE K4002_SealMaster		 = '" & SealMaster & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4002_CLEAR() : GoTo SKIP_READ_PFK4002

            Call K4002_MOVE(rd)
            READ_PFK4002_SealMaster = True

SKIP_READ_PFK4002:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4002", vbCritical)
        End Try
    End Function
    Public Function DELETE_PFK4064_PROCESS(JobCard As String, cdMainProcess As String, cdFactory As String, cdOSLineProd As String) As Boolean
        DELETE_PFK4064_PROCESS = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK4064 "
            SQL = SQL & " WHERE K4064_JobCard		 =  '" & JobCard & "'  "
            SQL = SQL & " AND K4064_cdMainProcess	 =   '" & cdMainProcess & "'  "
            SQL = SQL & " AND K4064_cdFactory	 =  '" & cdFactory & "'  "
            SQL = SQL & " AND K4064_cdLineProd	 =  '" & cdOSLineProd & "'  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK4064_PROCESS = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK4064", vbCritical)
        End Try
    End Function
    Public Function DELETE_PFK4064_PROCESS_ALL(JobCard As String, cdMainProcess As String) As Boolean
        DELETE_PFK4064_PROCESS_ALL = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK4064 "
            SQL = SQL & " WHERE K4064_JobCard		 =  '" & JobCard & "'  "
            SQL = SQL & " AND K4064_cdMainProcess	 =   '" & cdMainProcess & "'  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK4064_PROCESS_ALL = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK4064", vbCritical)
        End Try
    End Function
    Public Function DELETE_PFK4062_PROCESS(JobCard As String, ToolCode As String, DatePlan As String) As Boolean
        DELETE_PFK4062_PROCESS = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK4062 "
            SQL = SQL & " WHERE K4062_JobCard		 =  '" & JobCard & "'  "
            SQL = SQL & " AND K4062_ToolCode	=  '" & ToolCode & "'  "
            SQL = SQL & " AND K4062_DatePlan	=  '" & DatePlan & "'  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK4062_PROCESS = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK4062_PROCESS", vbCritical)
        End Try
    End Function
    Public Function DELETE_PFK4060_PROCESS(JobCard As String, cdMainProcess As String) As Boolean
        DELETE_PFK4060_PROCESS = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK4060 "
            SQL = SQL & " WHERE K4060_JobCard		 =  '" & JobCard & "'  "
            SQL = SQL & " AND K4060_cdMainProcess	=  '" & cdMainProcess & "'  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK4060_PROCESS = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK4060", vbCritical)
        End Try
    End Function
    Public Function READ_PFK4060_1(JobCard As String, DatePlan As String, cdMainProcess As String) As Boolean
        READ_PFK4060_1 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4060 "
            SQL = SQL & " WHERE K4060_JobCard		 =  '" & JobCard & "'  "
            SQL = SQL & " AND K4060_DatePlan		 =  '" & DatePlan & "'  "
            SQL = SQL & " AND K4060_cdMainProcess	 =  '" & cdMainProcess & "'  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4060_CLEAR() : GoTo SKIP_READ_PFK4060

            Call K4060_MOVE(rd)
            READ_PFK4060_1 = True

SKIP_READ_PFK4060:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4060", vbCritical)
        End Try
    End Function
    Public Function READ_PFK4062_1(JobCard As String, DatePlan As String, cdMainProcess As String, ToolCode As String) As Boolean
        READ_PFK4062_1 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4062 "
            SQL = SQL & " WHERE K4062_JobCard		 =  '" & JobCard & "'  "
            SQL = SQL & " AND K4062_DatePlan		 =  '" & DatePlan & "'  "
            SQL = SQL & " AND K4062_cdMainProcess	 =  '" & cdMainProcess & "'  "
            SQL = SQL & " AND K4062_ToolCode	 =  '" & ToolCode & "'  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4062_CLEAR() : GoTo SKIP_READ_PFK4062

            Call K4062_MOVE(rd)
            READ_PFK4062_1 = True

SKIP_READ_PFK4062:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4062", vbCritical)
        End Try
    End Function
    Public Function READ_PFK4064_1(JobCard As String, DatePlan As String, cdMainProcess As String, cdFactory As String, cdLineProd As String) As Boolean
        READ_PFK4064_1 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4064 "
            SQL = SQL & " WHERE K4064_JobCard		 =  '" & JobCard & "'  "
            SQL = SQL & " AND K4064_DatePlan		 =  '" & DatePlan & "'  "
            SQL = SQL & " AND K4064_cdMainProcess	 =  '" & cdMainProcess & "'  "
            SQL = SQL & " AND K4064_cdFactory	 =  '" & cdFactory & "'  "
            SQL = SQL & " AND K4064_cdLineProd	 =  '" & cdLineProd & "'  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4064_CLEAR() : GoTo SKIP_READ_PFK4064

            Call K4064_MOVE(rd)
            READ_PFK4064_1 = True

SKIP_READ_PFK4064:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4064_1", vbCritical)
        End Try
    End Function
    Public Function READ_PFK4060_MAX(JobCard As String, cdMainProcess As String) As Boolean
        READ_PFK4060_MAX = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK4060 "
            SQL = SQL & " WHERE K4060_JobCard		 =  '" & JobCard & "'  "
            SQL = SQL & " AND K4060_cdMainProcess	 =  '" & cdMainProcess & "' ORDER BY  K4060_DatePlan DESC "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4060_CLEAR() : GoTo SKIP_READ_PFK4060

            Call K4060_MOVE(rd)
            READ_PFK4060_MAX = True

SKIP_READ_PFK4060:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4060", vbCritical)
        End Try
    End Function
    Public Function READ_PFK4060_MIN(JobCard As String, cdMainProcess As String) As Boolean
        READ_PFK4060_MIN = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK4060 "
            SQL = SQL & " WHERE K4060_JobCard		 =  '" & JobCard & "'  "
            SQL = SQL & " AND K4060_cdMainProcess	 =  '" & cdMainProcess & "' ORDER BY  K4060_DatePlan ASC "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4060_CLEAR() : GoTo SKIP_READ_PFK4060

            Call K4060_MOVE(rd)
            READ_PFK4060_MIN = True

SKIP_READ_PFK4060:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4060", vbCritical)
        End Try
    End Function
    Public Function READ_PFK4064_MAX(JobCard As String, cdMainProcess As String) As Boolean
        READ_PFK4064_MAX = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK4064 "
            SQL = SQL & " WHERE K4064_JobCard		 =  '" & JobCard & "'  "
            SQL = SQL & " AND K4064_cdMainProcess	 =  '" & cdMainProcess & "' ORDER BY  K4064_DatePlan DESC "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4064_CLEAR() : GoTo SKIP_READ_PFK4064

            Call K4064_MOVE(rd)
            READ_PFK4064_MAX = True

SKIP_READ_PFK4064:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4064", vbCritical)
        End Try
    End Function
    Public Function READ_PFK4064_MIN(JobCard As String, cdMainProcess As String) As Boolean
        READ_PFK4064_MIN = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK4064 "
            SQL = SQL & " WHERE K4064_JobCard		 =  '" & JobCard & "'  "
            SQL = SQL & " AND K4064_cdMainProcess	 =  '" & cdMainProcess & "' ORDER BY  K4064_DatePlan ASC "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4064_CLEAR() : GoTo SKIP_READ_PFK4064

            Call K4064_MOVE(rd)
            READ_PFK4064_MIN = True

SKIP_READ_PFK4064:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4064", vbCritical)
        End Try
    End Function

    Public Function READ_PFK4902_ShippingWorkOrder(ShippingWorkOrder As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4902 "
            SQL = SQL & " WHERE K4902_ShippingWorkOrder		 = '" & ShippingWorkOrder & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK4902", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function
    Public Function READ_PFK4016_SUBPROCESS(JobCard As String, cdSubProcess As String) As Boolean
        READ_PFK4016_SUBPROCESS = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4016 "
            SQL = SQL & " WHERE K4016_JobCard		 = '" & JobCard & "' "
            SQL = SQL & "   AND K4016_cdSubProcess		  = '" & cdSubProcess & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4016_CLEAR() : GoTo SKIP_READ_PFK4016

            Call K4016_MOVE(rd)
            READ_PFK4016_SUBPROCESS = True

SKIP_READ_PFK4016:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4016", vbCritical)
        End Try
    End Function
    Public Function READ_PFK4002_WORKORDER(WORKORDER As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4002 "
            SQL = SQL & " WHERE K4002_WorkOrder		 = '" & WORKORDER & "' "

            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK4002", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function
    Public Function READ_PFK4066_FULL(SealMaster As String, cdFactory As String, cdLineProd As String, cdMainProcess As String, ByRef Con As SqlClient.SqlConnection) As DataSet

        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String

        Try
            SQL = " SELECT * FROM PFK4066 "
            SQL = SQL & " WHERE K4066_SealMaster		 =  '" & SealMaster & "'  "
            SQL = SQL & " AND K4066_cdFactory		 =  '" & cdFactory & "'  "
            SQL = SQL & " AND K4066_cdLineProd		 =  '" & cdLineProd & "'  "
            SQL = SQL & " AND K4066_cdMainProcess	 =  '" & cdMainProcess & "'  "

            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK4066_FULL", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function
    Public Function READ_PFK4073_TOPJOBCARD_FACTORY(cdFactory As String, CDMAINPROCESS As String, JobCard As String) As Boolean
        READ_PFK4073_TOPJOBCARD_FACTORY = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT top 1 * FROM PFK4073 "
            SQL = SQL & " WHERE K4073_JobCard	= '" & JobCard & "' "
            SQL = SQL & " AND K4073_cdMainProcess	= '" & CDMAINPROCESS & "' "
            SQL = SQL & " AND K4073_cdFactory	= '" & cdFactory & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4073_CLEAR() : GoTo SKIP_READ_PFK4073

            Call K4073_MOVE(rd)
            READ_PFK4073_TOPJOBCARD_FACTORY = True

SKIP_READ_PFK4073:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4073", vbCritical)
        End Try
    End Function
    Public Function READ_PFK4070_JobCard(CDFACTORY As String, CDMAINPROCESS As String, MACHINECODE As String, JobCard As String) As Boolean
        READ_PFK4070_JobCard = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4070 "
            SQL = SQL & " WHERE K4070_cdFactory		 = '" & CDFACTORY & "' "
            SQL = SQL & "   AND K4070_cdMainProcess		 = '" & CDMAINPROCESS & "' "
            SQL = SQL & "   AND K4070_MachineCode		 = '" & MACHINECODE & "' "
            SQL = SQL & "   AND K4070_JobCard		 = '" & JobCard & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4070_CLEAR() : GoTo SKIP_READ_PFK4070

            Call K4070_MOVE(rd)
            READ_PFK4070_JobCard = True

SKIP_READ_PFK4070:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4070", vbCritical)
        End Try
    End Function



#End Region

#Region "5000"


#End Region

#Region "6000"


#End Region

#Region "PFK7262xxxxxxxxxxxxxxxxxxx"
    Public Function READ_PFK7263_GETEXACTLY(MATERIALCODE As String) As Boolean
        READ_PFK7263_GETEXACTLY = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK7263 "
            SQL = SQL & " WHERE K7263_MaterialCode		 = '" & MATERIALCODE & "'   "
            SQL = SQL & "   ORDER BY  K7263_ContractID DESC  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7263_CLEAR() : GoTo SKIP_READ_PFK7263

            Call K7263_MOVE(rd)
            READ_PFK7263_GETEXACTLY = True

SKIP_READ_PFK7263:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7263", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7263_GETEXACTLY_NO(MATERIALCODE As String) As Boolean
        READ_PFK7263_GETEXACTLY_NO = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call READ_PFK7231(MATERIALCODE)

            SQL = " SELECT TOP 1 * FROM PFK7263 INNER JOIN PFK7231 ON K7231_MaterialCode = K7263_MaterialCode "
            SQL = SQL & " WHERE K7231_cdSemiGroupMaterial		 = '" & D7231.cdSemiGroupMaterial & "'   "
            SQL = SQL & "   ORDER BY  K7263_ContractID DESC  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7263_CLEAR() : GoTo SKIP_READ_PFK7263

            Call K7263_MOVE(rd)
            READ_PFK7263_GETEXACTLY_NO = True

SKIP_READ_PFK7263:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7263", vbCritical)
        End Try
    End Function

    Public Function READ_PFK7263_AUTOKEY(AutoKey As String) As Boolean
        READ_PFK7263_AUTOKEY = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try

            SQL = " SELECT  * FROM PFK7263  INNER JOIN PFK7262 ON K7263_ContractID = K7262_ContractID "
            SQL = SQL & " WHERE K7263_AutoKey		 = '" & CDecp(AutoKey) & "'   "
            SQL = SQL & " AND K7262_CheckUse = '1' AND K7262_CheckSupplierPrice = '3' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7263_CLEAR() : GoTo SKIP_READ_PFK7263

            Call K7263_MOVE(rd)
            READ_PFK7263_AUTOKEY = True

SKIP_READ_PFK7263:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7263", vbCritical)
        End Try
    End Function

    Public Function READ_PFK7263_MATERIALCODE_COLORCODE_SUPPLIERCODE(MATERIALCODE As String, ColorCode As String, SupplierCode As String) As Boolean
        READ_PFK7263_MATERIALCODE_COLORCODE_SUPPLIERCODE = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String

        Try

            SQL = " SELECT TOP 1 * FROM PFK7263 INNER JOIN PFK7262 ON K7263_ContractID = K7262_ContractID AND K7262_CheckMaterialType = '2'  "
            SQL = SQL & " WHERE K7263_MATERIALCODE		 = '" & MATERIALCODE & "'   "
            SQL = SQL & " AND K7263_ColorCode		 = '" & ColorCode & "'   "
            SQL = SQL & " AND K7262_CustomerCode		 = '" & SupplierCode & "'   "

            SQL = SQL & "   ORDER BY  K7262_DateAccept DESC  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7263_CLEAR() : GoTo SKIP_READ_PFK7263

            Call K7263_MOVE(rd)
            READ_PFK7263_MATERIALCODE_COLORCODE_SUPPLIERCODE = True

SKIP_READ_PFK7263:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7263", vbCritical)
        End Try
    End Function

    Public Function READ_PFK7263_MATERIALCODE_SUPPLIERCODE(MATERIALCODE As String, SupplierCode As String) As Boolean
        READ_PFK7263_MATERIALCODE_SUPPLIERCODE = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String

        Try

            SQL = " SELECT TOP 1 * FROM PFK7263 INNER JOIN PFK7262 ON K7263_ContractID = K7262_ContractID AND K7262_CheckMaterialType = '2' "
            SQL = SQL & " WHERE K7263_MATERIALCODE		 = '" & MATERIALCODE & "'   "
            SQL = SQL & " AND K7262_CustomerCode		 = '" & SupplierCode & "'   "

            SQL = SQL & "   ORDER BY  K7262_DateAccept DESC  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7263_CLEAR() : GoTo SKIP_READ_PFK7263

            Call K7263_MOVE(rd)
            READ_PFK7263_MATERIALCODE_SUPPLIERCODE = True

SKIP_READ_PFK7263:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7263", vbCritical)
        End Try
    End Function


    Public Function READ_PFK7263_MATERIALCODE_COLORCODE_NOSUPPLIERCODE(MATERIALCODE As String, ColorCode As String) As Boolean
        READ_PFK7263_MATERIALCODE_COLORCODE_NOSUPPLIERCODE = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String

        Try

            SQL = " SELECT TOP 1 * FROM PFK7263 INNER JOIN PFK7262 ON K7263_ContractID = K7262_ContractID AND K7262_CheckMaterialType = '2' "
            SQL = SQL & " WHERE K7263_MATERIALCODE		 = '" & MATERIALCODE & "'   "
            SQL = SQL & " AND K7263_ColorCode		 = '" & ColorCode & "'   "
            SQL = SQL & "   ORDER BY  K7262_DateAccept DESC  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7263_CLEAR() : GoTo SKIP_READ_PFK7263

            Call K7263_MOVE(rd)
            READ_PFK7263_MATERIALCODE_COLORCODE_NOSUPPLIERCODE = True

SKIP_READ_PFK7263:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7263", vbCritical)
        End Try
    End Function

    Public Function READ_PFK7263_GETEXACTLY_NO(ContractID As String, MATERIALCODE As String, ColorCode As String, QtyBasic As String) As Boolean
        READ_PFK7263_GETEXACTLY_NO = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try


            SQL = " SELECT TOP 1 * FROM PFK7263  "
            SQL = SQL & " WHERE K7263_ContractID		 = '" & ContractID & "'   "
            SQL = SQL & " AND  K7263_MATERIALCODE		 = '" & MATERIALCODE & "'   "
            SQL = SQL & " AND K7263_ColorCode		 = '" & ColorCode & "'   "

            If READ_PFK7231(MATERIALCODE) Then
                If D7231.Check1 = "2" Then
                    If CDecp(QtyBasic) > 0 Then SQL = SQL & " AND K7263_QtyBasic >= '" & CDecp(QtyBasic) & "'   "
                    If CDecp(QtyBasic) = 0 Then SQL = SQL & " ORDER BY K7263_ContracSeq ASC  "

                    SQL = SQL & " ORDER BY K7263_ContracSeq   ASC "

                End If
            End If

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()


            If rd.HasRows = False Then
                rd.Close()

                SQL = " SELECT TOP 1 * FROM PFK7263  "
                SQL = SQL & " WHERE K7263_ContractID		 = '" & ContractID & "'   "
                SQL = SQL & " AND  K7263_MATERIALCODE		 = '" & MATERIALCODE & "'   "
                SQL = SQL & " AND K7263_ColorCode		 = '" & ColorCode & "'   "

                If READ_PFK7231(MATERIALCODE) Then
                    If D7231.Check1 = "2" Then
                        SQL = SQL & " ORDER BY K7263_ContracSeq   DESC "
                    End If
                End If

                cmd = New SqlClient.SqlCommand(SQL, cn)
                rd = cmd.ExecuteReader
                rd.Read()

            End If

            If rd.HasRows = False Then Call D7263_CLEAR() : GoTo SKIP_READ_PFK7263

            Call K7263_MOVE(rd)
            READ_PFK7263_GETEXACTLY_NO = True

SKIP_READ_PFK7263:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7263", vbCritical)
        End Try
    End Function

#End Region

#Region "7000"
    Public Function READ_PFK7411_NAME(NAME As String) As Boolean
        READ_PFK7411_NAME = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK7411 "
            SQL = SQL & " WHERE K7411_NAME		 = '" & NAME & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7411_CLEAR() : GoTo SKIP_READ_PFK7411

            Call K7411_MOVE(rd)
            READ_PFK7411_NAME = True

SKIP_READ_PFK7411:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7411", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7411_HRNO(NAME As String) As Boolean
        READ_PFK7411_HRNO = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK7411 "
            SQL = SQL & " WHERE K7411_IDHRCode		 LIKE '%" & NAME & "%' "
            SQL = SQL & " AND  K7411_cdSite		 = '" & Pub.SITE & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7411_CLEAR() : GoTo SKIP_READ_PFK7411

            Call K7411_MOVE(rd)
            READ_PFK7411_HRNO = True

SKIP_READ_PFK7411:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7411", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7411_IDNO(NAME As String) As Boolean
        READ_PFK7411_IDNO = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK7411 "
            SQL = SQL & " WHERE ISNUMERIC(K7411_IDNO) = 1 AND CAST(K7411_IDNO	 AS INT)	 = '" & NAME & "' "
            SQL = SQL & " AND  K7411_cdSite		 = '" & Pub.SITE & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7411_CLEAR() : GoTo SKIP_READ_PFK7411

            Call K7411_MOVE(rd)
            READ_PFK7411_IDNO = True

SKIP_READ_PFK7411:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7411", vbCritical)
        End Try
    End Function



    Public Function READ_PFK7214_ART(ART As String) As Boolean
        READ_PFK7214_ART = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7214 "
            SQL = SQL & " WHERE K7214_Article		 =   '" & ART & "'"
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7214_CLEAR() : GoTo SKIP_READ_PFK7214

            Call K7214_MOVE(rd)
            READ_PFK7214_ART = True

SKIP_READ_PFK7214:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7214", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7214_ART_CDSEASON_CUSTOMERCODE(K7214_Article As String, K7214_cdSeason As String, K7214_CustomerCode As String) As Boolean
        READ_PFK7214_ART_CDSEASON_CUSTOMERCODE = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7214 "
            SQL = SQL & " WHERE K7214_Article		 =   '" & K7214_Article & "'"
            SQL = SQL & " AND K7214_cdSeason		 =   '" & K7214_cdSeason & "'"
            SQL = SQL & " AND K7214_CustomerCode		 =   '" & K7214_CustomerCode & "'"

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7214_CLEAR() : GoTo SKIP_READ_PFK7214

            Call K7214_MOVE(rd)
            READ_PFK7214_ART_CDSEASON_CUSTOMERCODE = True

SKIP_READ_PFK7214:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7214", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7104_2(SIZERANGE As String, CustomerCode As String, cdSeason As String) As Boolean
        READ_PFK7104_2 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7104 "
            SQL = SQL & " WHERE K7104_SizeRangeName		 = '" & FormatSQL(SIZERANGE) & "' "
            SQL = SQL & " and K7104_CustomerCode		 = '" & CustomerCode & "' "
            SQL = SQL & " and K7104_cdSeason		     = '" & cdSeason & "' "
            SQL = SQL & " and K7104_CheckUse		    = '1' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7104_CLEAR() : GoTo SKIP_READ_PFK7104

            Call K7104_MOVE(rd)
            READ_PFK7104_2 = True

SKIP_READ_PFK7104:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7104", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7210_CUSTOMER_CARTONNAME(CustomerCode As String, CARTONNAME As String) As Boolean
        READ_PFK7210_CUSTOMER_CARTONNAME = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK7210 "
            SQL = SQL & " WHERE  K7210_CartonType		 LIKE '%" & CARTONNAME & "%' "
            SQL = SQL & " AND  K7210_CustomerCode		 = '" & CustomerCode & "' "
            SQL = SQL & " and isnumeric(right(K7210_CartonType,len(K7210_CartonType)-3)) = 1   order by cast(right(K7210_CartonType,len(K7210_CartonType)-3) as int) asc "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7210_CLEAR() : GoTo SKIP_READ_PFK7210

            Call K7210_MOVE(rd)
            READ_PFK7210_CUSTOMER_CARTONNAME = True

SKIP_READ_PFK7210:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7210_NAME", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7112_TOP1(UPLOADNO As String) As Boolean
        READ_PFK7112_TOP1 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK7112 "
            SQL = SQL & " WHERE K7112_UploadNo		 = '" & UPLOADNO & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7112_CLEAR() : GoTo SKIP_READ_PFK7112

            Call K7112_MOVE(rd)
            READ_PFK7112_TOP1 = True

SKIP_READ_PFK7112:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7112", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7261_GETEXACTLY(MATERIALCODE As String) As Boolean
        READ_PFK7261_GETEXACTLY = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK7261 "
            SQL = SQL & " WHERE K7261_MaterialCode		 = '" & MATERIALCODE & "'   "
            SQL = SQL & "   ORDER BY  K7261_ContractID DESC  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7261_CLEAR() : GoTo SKIP_READ_PFK7261

            Call K7261_MOVE(rd)
            READ_PFK7261_GETEXACTLY = True

SKIP_READ_PFK7261:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7261", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7261_GETEXACTLY_NO(MATERIALCODE As String) As Boolean
        READ_PFK7261_GETEXACTLY_NO = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call READ_PFK7231(MATERIALCODE)

            SQL = " SELECT TOP 1 * FROM PFK7261 INNER JOIN PFK7231 ON K7231_MaterialCode = K7261_MaterialCode "
            SQL = SQL & " WHERE K7231_cdSemiGroupMaterial		 = '" & D7231.cdSemiGroupMaterial & "'   "
            SQL = SQL & "   ORDER BY  K7261_ContractID DESC  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7261_CLEAR() : GoTo SKIP_READ_PFK7261

            Call K7261_MOVE(rd)
            READ_PFK7261_GETEXACTLY_NO = True

SKIP_READ_PFK7261:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7261", vbCritical)
        End Try
    End Function

    Public Function READ_PFK7261_AUTOKEY(AutoKey As String) As Boolean
        READ_PFK7261_AUTOKEY = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try

            SQL = " SELECT  * FROM PFK7261  "
            SQL = SQL & " WHERE K7261_AutoKey		 = '" & AutoKey & "'   "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7261_CLEAR() : GoTo SKIP_READ_PFK7261

            Call K7261_MOVE(rd)
            READ_PFK7261_AUTOKEY = True

SKIP_READ_PFK7261:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7261", vbCritical)
        End Try
    End Function

    Public Function READ_PFK7261_MATERIALCODE_COLORCODE_SUPPLIERCODE(MATERIALCODE As String, ColorCode As String, SupplierCode As String) As Boolean
        READ_PFK7261_MATERIALCODE_COLORCODE_SUPPLIERCODE = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String

        Try

            SQL = " SELECT TOP 1 * FROM PFK7261 INNER JOIN PFK7260 ON K7261_ContractID = K7260_ContractID AND K7260_CheckMaterialType = '2'  "
            SQL = SQL & " WHERE K7261_MATERIALCODE		 = '" & MATERIALCODE & "'   "
            SQL = SQL & " AND K7261_ColorCode		 = '" & ColorCode & "'   "
            SQL = SQL & " AND K7260_CustomerCode		 = '" & SupplierCode & "'   "

            SQL = SQL & "   ORDER BY  K7260_DateAccept DESC  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7261_CLEAR() : GoTo SKIP_READ_PFK7261

            Call K7261_MOVE(rd)
            READ_PFK7261_MATERIALCODE_COLORCODE_SUPPLIERCODE = True

SKIP_READ_PFK7261:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7261", vbCritical)
        End Try
    End Function

    Public Function READ_PFK7261_MATERIALCODE_SUPPLIERCODE(MATERIALCODE As String, SupplierCode As String) As Boolean
        READ_PFK7261_MATERIALCODE_SUPPLIERCODE = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String

        Try

            SQL = " SELECT TOP 1 * FROM PFK7261 INNER JOIN PFK7260 ON K7261_ContractID = K7260_ContractID AND K7260_CheckMaterialType = '2' "
            SQL = SQL & " WHERE K7261_MATERIALCODE		 = '" & MATERIALCODE & "'   "
            SQL = SQL & " AND K7260_CustomerCode		 = '" & SupplierCode & "'   "

            SQL = SQL & "   ORDER BY  K7260_DateAccept DESC  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7261_CLEAR() : GoTo SKIP_READ_PFK7261

            Call K7261_MOVE(rd)
            READ_PFK7261_MATERIALCODE_SUPPLIERCODE = True

SKIP_READ_PFK7261:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7261", vbCritical)
        End Try
    End Function


    Public Function READ_PFK7261_MATERIALCODE_COLORCODE_NOSUPPLIERCODE(MATERIALCODE As String, ColorCode As String) As Boolean
        READ_PFK7261_MATERIALCODE_COLORCODE_NOSUPPLIERCODE = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String

        Try

            SQL = " SELECT TOP 1 * FROM PFK7261 INNER JOIN PFK7260 ON K7261_ContractID = K7260_ContractID AND K7260_CheckMaterialType = '2' "
            SQL = SQL & " WHERE K7261_MATERIALCODE		 = '" & MATERIALCODE & "'   "
            SQL = SQL & " AND K7261_ColorCode		 = '" & ColorCode & "'   "
            SQL = SQL & "   ORDER BY  K7260_DateAccept DESC  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7261_CLEAR() : GoTo SKIP_READ_PFK7261

            Call K7261_MOVE(rd)
            READ_PFK7261_MATERIALCODE_COLORCODE_NOSUPPLIERCODE = True

SKIP_READ_PFK7261:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7261", vbCritical)
        End Try
    End Function

    Public Function READ_PFK7261_GETEXACTLY_NO(ContractID As String, MATERIALCODE As String, ColorCode As String, QtyBasic As String) As Boolean
        READ_PFK7261_GETEXACTLY_NO = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try


            SQL = " SELECT TOP 1 * FROM PFK7261  "
            SQL = SQL & " WHERE K7261_ContractID		 = '" & ContractID & "'   "
            SQL = SQL & " AND  K7261_MATERIALCODE		 = '" & MATERIALCODE & "'   "
            SQL = SQL & " AND K7261_ColorCode		 = '" & ColorCode & "'   "

            If READ_PFK7231(MATERIALCODE) Then
                If D7231.Check1 = "2" Then
                    If CDecp(QtyBasic) > 0 Then SQL = SQL & " AND K7261_QtyBasic >= '" & CDecp(QtyBasic) & "'   "
                    If CDecp(QtyBasic) = 0 Then SQL = SQL & " ORDER BY K7261_ContracSeq ASC  "

                    SQL = SQL & " ORDER BY K7261_ContracSeq   ASC "

                End If
            End If

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()


            If rd.HasRows = False Then
                rd.Close()

                SQL = " SELECT TOP 1 * FROM PFK7261  "
                SQL = SQL & " WHERE K7261_ContractID		 = '" & ContractID & "'   "
                SQL = SQL & " AND  K7261_MATERIALCODE		 = '" & MATERIALCODE & "'   "
                SQL = SQL & " AND K7261_ColorCode		 = '" & ColorCode & "'   "

                If READ_PFK7231(MATERIALCODE) Then
                    If D7231.Check1 = "2" Then
                        SQL = SQL & " ORDER BY K7261_ContracSeq   DESC "
                    End If
                End If

                cmd = New SqlClient.SqlCommand(SQL, cn)
                rd = cmd.ExecuteReader
                rd.Read()

            End If

            If rd.HasRows = False Then Call D7261_CLEAR() : GoTo SKIP_READ_PFK7261

            Call K7261_MOVE(rd)
            READ_PFK7261_GETEXACTLY_NO = True

SKIP_READ_PFK7261:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7261", vbCritical)
        End Try
    End Function


    Public Function DELETE_PFK7111_ALL(GroupComponentBOM As String) As Boolean
        DELETE_PFK7111_ALL = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK7111 "
            SQL = SQL & " WHERE K7111_GroupComponentBOM		 = '" & GroupComponentBOM & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK7111_ALL = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK7109", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7112_1(ShoesCode As String, ComponentName As String, cdSpecialProcess As String, cdUnitMaterial As String, Width As String) As Boolean
        READ_PFK7112_1 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7112 "
            SQL = SQL & " WHERE K7112_ShoesCode		    = '" & FormatSQL(ShoesCode) & "' "
            SQL = SQL & "   AND K7112_ComponentName		= '" & FormatSQL(ComponentName) & "' "
            SQL = SQL & "   AND K7112_cdSpecialProcess	= '" & FormatSQL(cdSpecialProcess) & "' "
            SQL = SQL & "   AND K7112_cdUnitMaterial	= '" & FormatSQL(cdUnitMaterial) & "' "
            SQL = SQL & "   AND K7112_Width		        = '" & FormatSQL(Width) & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7112_CLEAR() : GoTo SKIP_READ_PFK7112

            Call K7112_MOVE(rd)
            READ_PFK7112_1 = True

SKIP_READ_PFK7112:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7112", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7104_SZNO(SIZERANGE As String, SIZENAME As String) As String
        READ_PFK7104_SZNO = ""

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM VPK7104 "
            SQL = SQL & " WHERE SizeRange		 = '" & SIZERANGE & "' "
            SQL = SQL & " AND SizeName		 = '" & Trim(SIZENAME) & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7104_CLEAR() : GoTo SKIP_READ_PFK7104
            READ_PFK7104_SZNO = rd!SizeNo

SKIP_READ_PFK7104:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7104", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7205_SZNO_SIZEGROUP(SHOESCODE As String, SIZENAME As String, SIZEGROUP As String) As String
        READ_PFK7205_SZNO_SIZEGROUP = ""

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM VPK7104_SizeGroup "
            SQL = SQL & " WHERE ShoesCode		 = '" & Trim(SHOESCODE) & "' "
            SQL = SQL & " AND SizeName		 = '" & Trim(SIZENAME) & "' "
            SQL = SQL & " AND SizeGroup		 = '" & Trim(SIZEGROUP) & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7104_CLEAR() : GoTo SKIP_READ_PFK7104
            READ_PFK7205_SZNO_SIZEGROUP = rd!SizeNo

SKIP_READ_PFK7104:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7104", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7104_SIZENAME(SIZERANGE As String, SizeNo As String) As String
        READ_PFK7104_SIZENAME = ""

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM VPK7104 "
            SQL = SQL & " WHERE SizeRange		 = '" & SIZERANGE & "' "
            SQL = SQL & " AND SizeNo		 = '" & Trim(SizeNo) & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7104_CLEAR() : GoTo SKIP_READ_PFK7104
            READ_PFK7104_SIZENAME = rd!SizeName

SKIP_READ_PFK7104:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7104", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7104_SIZENAMEMIN(SIZERANGE As String) As String
        READ_PFK7104_SIZENAMEMIN = ""

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 SizeName, SizeNo FROM VPK7104 "
            SQL = SQL & " WHERE SizeRange		 = '" & SIZERANGE & "' "
            SQL = SQL & " AND SizeName <> '' AND SizeName <> '0' ORDER BY SizeNo ASC  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7104_CLEAR() : GoTo SKIP_READ_PFK7104
            READ_PFK7104_SIZENAMEMIN = rd!SizeNo

SKIP_READ_PFK7104:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7104", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7104_SIZENAMEMAX(SIZERANGE As String) As String
        READ_PFK7104_SIZENAMEMAX = ""

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 SizeName,SizeNo FROM VPK7104 "
            SQL = SQL & " WHERE SizeRange		 = '" & SIZERANGE & "' "
            SQL = SQL & " AND SizeName <> '' AND SizeName <> '0' ORDER BY SizeNo DESC  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7104_CLEAR() : GoTo SKIP_READ_PFK7104
            READ_PFK7104_SIZENAMEMAX = rd!SizeNo

SKIP_READ_PFK7104:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7104", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7104_1(SIZERANGE As String, CustomerCode As String) As Boolean
        READ_PFK7104_1 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7104 "
            SQL = SQL & " WHERE K7104_SizeRangeName		 = '" & FormatSQL(SIZERANGE) & "' "
            SQL = SQL & " and K7104_CustomerCode		 = '" & CustomerCode & "' "
            SQL = SQL & " and K7104_CheckUse		 = '1' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7104_CLEAR() : GoTo SKIP_READ_PFK7104

            Call K7104_MOVE(rd)
            READ_PFK7104_1 = True

SKIP_READ_PFK7104:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7104", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7199_TOP1(DATEEXCHANGE As String, SEUNITPRICE As String, CDUNITPRICE As String) As Boolean
        READ_PFK7199_TOP1 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK7199 "
            SQL = SQL & " WHERE K7199_DateExchange		 <= '" & DATEEXCHANGE & "' "
            SQL = SQL & "   AND K7199_seUnitPrice		 = '" & SEUNITPRICE & "' "
            SQL = SQL & "   AND K7199_cdUnitPrice		 = '" & CDUNITPRICE & "'  ORDER BY K7199_DateExchange DESC "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7199_CLEAR() : GoTo SKIP_READ_PFK7199

            Call K7199_MOVE(rd)
            READ_PFK7199_TOP1 = True

SKIP_READ_PFK7199:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7199", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7106_1(cdSeason As String, cdSpecState As String, Article As String, Line As String, ColorCode As String) As Boolean
        READ_PFK7106_1 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7106 "
            SQL = SQL & " WHERE K7106_cdSpecState	 = '" & FormatSQL(cdSpecState) & "' "
            SQL = SQL & " AND K7106_Article		 = '" & FormatSQL(Article) & "' "
            SQL = SQL & " AND K7106_Line		     = '" & FormatSQL(Line) & "' "
            SQL = SQL & " AND K7106_ColorCode		 = '" & FormatSQL(ColorCode) & "' "
            SQL = SQL & " AND K7106_cdSeason		 = '" & FormatSQL(cdSeason) & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7106_CLEAR() : GoTo SKIP_READ_PFK7106

            Call K7106_MOVE(rd)
            READ_PFK7106_1 = True

SKIP_READ_PFK7106:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7106", vbCritical)
        End Try
    End Function


    Public Function READ_PFK7106_CHECK_NOCOLOR(cdSpecState As String, Article As String, CustSpecNo As String, CustomerCode As String, ColorCode As String) As Boolean
        READ_PFK7106_CHECK_NOCOLOR = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7106 "
            SQL = SQL & " WHERE K7106_cdSpecState	 = '" & FormatSQL(cdSpecState) & "' "
            SQL = SQL & " AND K7106_Article		 = '" & FormatSQL(Article) & "' "
            SQL = SQL & " AND K7106_CustSpecNo		 = '" & FormatSQL(CustSpecNo) & "' "
            SQL = SQL & " AND K7106_CustomerCode		     = '" & FormatSQL(CustomerCode) & "' "
            SQL = SQL & " AND K7106_ColorCode		     = '" & FormatSQL(ColorCode) & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7106_CLEAR() : GoTo SKIP_READ_PFK7106

            Call K7106_MOVE(rd)
            READ_PFK7106_CHECK_NOCOLOR = True

SKIP_READ_PFK7106:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7106", vbCritical)
        End Try
    End Function

    Public Function READ_PFK7106_CHECK(cdSpecState As String, Article As String, CustomerCode As String, ColorCode As String) As Boolean
        READ_PFK7106_CHECK = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7106 "
            SQL = SQL & " WHERE K7106_cdSpecState	 = '" & FormatSQL(cdSpecState) & "' "
            SQL = SQL & " AND K7106_Article		 = '" & FormatSQL(Article) & "' "
            SQL = SQL & " AND K7106_CustomerCode		     = '" & FormatSQL(CustomerCode) & "' "
            SQL = SQL & " AND K7106_ColorCode		     = '" & FormatSQL(ColorCode) & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7106_CLEAR() : GoTo SKIP_READ_PFK7106

            Call K7106_MOVE(rd)
            READ_PFK7106_CHECK = True

SKIP_READ_PFK7106:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7106", vbCritical)
        End Try
    End Function

    Public Function READ_PFK7106_SHOESPARENT(cdSeason As String, cdSpecState As String, Article As String) As Boolean
        READ_PFK7106_SHOESPARENT = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7106 "
            SQL = SQL & " WHERE K7106_cdSpecState	 = '" & FormatSQL(cdSpecState) & "' "
            SQL = SQL & " AND K7106_Article		 = '" & FormatSQL(Article) & "' "
            SQL = SQL & " AND K7106_cdSeason		 = '" & FormatSQL(cdSeason) & "' "
            SQL = SQL & " AND K7106_CheckParent	= '1' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7106_CLEAR() : GoTo SKIP_READ_PFK7106

            Call K7106_MOVE(rd)
            READ_PFK7106_SHOESPARENT = True

SKIP_READ_PFK7106:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7106", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7109_OUTSOLE_NAME(ShoesCode As String) As Boolean
        READ_PFK7109_OUTSOLE_NAME = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK7109  WITH (NOLOCK)  INNER JOIN PFK7108  WITH (NOLOCK) ON K7109_GroupComponentBOM = K7108_GroupComponentBOM "
            SQL = SQL & " INNER JOIN PFK7106  WITH (NOLOCK) ON K7106_ShoesCode = K7108_ShoesCode   WHERE K7106_ShoesCode	 = '" & FormatSQL(ShoesCode) & "' "
            SQL = SQL & " AND  K7109_ComponentName	=	'OUT SOLE' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7109_CLEAR() : GoTo SKIP_READ_PFK7109

            Call K7109_MOVE(rd)
            READ_PFK7109_OUTSOLE_NAME = True

SKIP_READ_PFK7109:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7109", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7106_SHOESMATCHING(ShoesParent As String, ColorCode As String, ColorName As String) As Boolean
        READ_PFK7106_SHOESMATCHING = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7106 "
            SQL = SQL & " WHERE K7106_ShoesParent	 = '" & FormatSQL(ShoesParent) & "' "
            SQL = SQL & " AND (K7106_ColorCode		 = '" & FormatSQL(ColorCode) & "' "
            SQL = SQL & " OR K7106_ColorName		 = '" & FormatSQL(ColorName) & "') "


            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7106_CLEAR() : GoTo SKIP_READ_PFK7106

            Call K7106_MOVE(rd)
            READ_PFK7106_SHOESMATCHING = True

SKIP_READ_PFK7106:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7106", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7106_1_GX(cdSeason As String, cdSpecState As String, Article As String, MCODE As String, ColorCode As String) As Boolean
        READ_PFK7106_1_GX = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7106 "
            SQL = SQL & " WHERE K7106_cdSpecState	 = '" & FormatSQL(cdSpecState) & "' "
            SQL = SQL & " AND K7106_MCODE		 = '" & FormatSQL(MCODE) & "' "
            SQL = SQL & " AND K7106_Article		     = '" & FormatSQL(Article) & "' "
            SQL = SQL & " AND K7106_ColorCode		 = '" & FormatSQL(ColorCode) & "' "
            SQL = SQL & " AND K7106_cdSeason		 = '" & FormatSQL(cdSeason) & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7106_CLEAR() : GoTo SKIP_READ_PFK7106

            Call K7106_MOVE(rd)
            READ_PFK7106_1_GX = True

SKIP_READ_PFK7106:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7106", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7106_1_ALL_CUSTOMER(cdSeason As String, CustomerCode As String, cdSpecState As String, Line As String, Article As String, ColorName As String, ColorCode As String, SizeRange As String) As Boolean
        READ_PFK7106_1_ALL_CUSTOMER = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7106 "
            SQL = SQL & " WHERE K7106_cdSpecState	 = '" & FormatSQL(cdSpecState) & "' "
            'SQL = SQL & " AND K7106_Line		     = N'" & FormatSQL(Line) & "' "
            SQL = SQL & " AND K7106_Article		     = N'" & FormatSQL(Article) & "' "
            SQL = SQL & " AND K7106_ColorName		 = N'" & FormatSQL(ColorName) & "' "
            SQL = SQL & " AND K7106_cdSeason		 = '" & FormatSQL(cdSeason) & "' "
            SQL = SQL & " AND K7106_CustomerCode	 = '" & FormatSQL(CustomerCode) & "' "
            SQL = SQL & " AND K7106_ColorCode	 =  '" & FormatSQL(ColorCode) & "' "
            SQL = SQL & " AND K7106_SizeRange	 = '" & FormatSQL(SizeRange) & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7106_CLEAR() : GoTo SKIP_READ_PFK7106

            Call K7106_MOVE(rd)
            READ_PFK7106_1_ALL_CUSTOMER = True

SKIP_READ_PFK7106:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7106", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7106_1_ALL_CUSTOMER_COLORNAME(cdSeason As String, CustomerCode As String, cdSpecState As String, Line As String, Article As String, ColorName As String) As Boolean
        READ_PFK7106_1_ALL_CUSTOMER_COLORNAME = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7106 "
            SQL = SQL & " WHERE K7106_cdSpecState	 = '" & FormatSQL(cdSpecState) & "' "
            'SQL = SQL & " AND K7106_Line		     = '" & FormatSQL(Line) & "' "
            SQL = SQL & " AND K7106_Article		     = '" & FormatSQL(Article) & "' "
            SQL = SQL & " AND K7106_ColorName		 = '" & FormatSQL(ColorName) & "' "
            SQL = SQL & " AND K7106_cdSeason		 = '" & FormatSQL(cdSeason) & "' "
            SQL = SQL & " AND K7106_CustomerCode	 = '" & FormatSQL(CustomerCode) & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7106_CLEAR() : GoTo SKIP_READ_PFK7106

            Call K7106_MOVE(rd)
            READ_PFK7106_1_ALL_CUSTOMER_COLORNAME = True

SKIP_READ_PFK7106:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7106", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7106_1_ABT(cdSeason As String, cdSpecState As String, Line As String, Article As String, ColorName As String) As Boolean
        READ_PFK7106_1_ABT = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7106 "
            SQL = SQL & " WHERE K7106_cdSpecState	 = '" & FormatSQL(cdSpecState) & "' "
            SQL = SQL & " AND K7106_Line		 = '" & FormatSQL(Line) & "' "
            SQL = SQL & " AND K7106_Article		     = '" & FormatSQL(Article) & "' "
            SQL = SQL & " AND K7106_ColorName		 = '" & FormatSQL(ColorName) & "' "
            SQL = SQL & " AND K7106_cdSeason		 = '" & FormatSQL(cdSeason) & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7106_CLEAR() : GoTo SKIP_READ_PFK7106

            Call K7106_MOVE(rd)
            READ_PFK7106_1_ABT = True

SKIP_READ_PFK7106:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7106", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7106_1_LG(cdSeason As String, cdSpecState As String, Article As String, MCODE As String, ColorCode As String) As Boolean
        READ_PFK7106_1_LG = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7106 "
            SQL = SQL & " WHERE K7106_cdSpecState	 = '" & FormatSQL(cdSpecState) & "' "
            SQL = SQL & " AND K7106_MCODE		 = '" & FormatSQL(MCODE) & "' "
            SQL = SQL & " AND K7106_Article		     = '" & FormatSQL(Article) & "' "
            SQL = SQL & " AND K7106_ColorCode		 = '" & FormatSQL(ColorCode) & "' "
            SQL = SQL & " AND K7106_cdSeason		 = '" & FormatSQL(cdSeason) & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7106_CLEAR() : GoTo SKIP_READ_PFK7106

            Call K7106_MOVE(rd)
            READ_PFK7106_1_LG = True

SKIP_READ_PFK7106:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7106", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7106_1_WW(cdSeason As String, cdSpecState As String, Style As String) As Boolean
        READ_PFK7106_1_WW = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7106 "
            SQL = SQL & " WHERE K7106_cdSpecState	 = '" & FormatSQL(cdSpecState) & "' "
            SQL = SQL & " AND K7106_Style		 = '" & FormatSQL(Style) & "' "
            SQL = SQL & " AND K7106_cdSeason		 = '" & FormatSQL(cdSeason) & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7106_CLEAR() : GoTo SKIP_READ_PFK7106

            Call K7106_MOVE(rd)
            READ_PFK7106_1_WW = True

SKIP_READ_PFK7106:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7106", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7106_1_WW_SizeRange(cdSeason As String, cdSpecState As String, Style As String, SizeRange As String) As Boolean
        READ_PFK7106_1_WW_SizeRange = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7106 "
            SQL = SQL & " WHERE K7106_cdSpecState	 = '" & FormatSQL(cdSpecState) & "' "
            SQL = SQL & " AND K7106_Style		 = '" & FormatSQL(Style) & "' "
            SQL = SQL & " AND K7106_cdSeason		 = '" & FormatSQL(cdSeason) & "' "
            SQL = SQL & " AND K7106_SizeRange		 = '" & FormatSQL(SizeRange) & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7106_CLEAR() : GoTo SKIP_READ_PFK7106

            Call K7106_MOVE(rd)
            READ_PFK7106_1_WW_SizeRange = True

SKIP_READ_PFK7106:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7106", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7106_ALL(Article As String, Line As String, ColorCode As String, ColorName As String) As Boolean
        READ_PFK7106_ALL = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK7106 "
            SQL = SQL & " WHERE K7106_Article		 = '" & FormatSQL(Article) & "' "
            SQL = SQL & " AND K7106_Line		     = '" & FormatSQL(Line) & "' "
            SQL = SQL & " AND (K7106_ColorCode		 = '" & FormatSQL(ColorCode) & "' OR  K7106_ColorName		 = '" & FormatSQL(ColorName) & "') ORDER BY K7106_cdSpecState DESC"

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7106_CLEAR() : GoTo SKIP_READ_PFK7106

            Call K7106_MOVE(rd)
            READ_PFK7106_ALL = True

SKIP_READ_PFK7106:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7106", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7106_ALL_GX(Article As String, MCODE As String, ColorCode As String) As Boolean
        READ_PFK7106_ALL_GX = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK7106 "
            SQL = SQL & " WHERE K7106_Article		 = '" & FormatSQL(Article) & "' "
            SQL = SQL & " AND K7106_MCODE		     = '" & FormatSQL(MCODE) & "' "
            SQL = SQL & " AND K7106_ColorCode		 = '" & FormatSQL(ColorCode) & "' ORDER BY K7106_cdSpecState DESC"

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7106_CLEAR() : GoTo SKIP_READ_PFK7106

            Call K7106_MOVE(rd)
            READ_PFK7106_ALL_GX = True

SKIP_READ_PFK7106:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7106", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7106_ALL_CUSTOMER(cdSeason As String, CustomerCode As String, Line As String, Article As String, ColorName As String) As Boolean
        READ_PFK7106_ALL_CUSTOMER = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK7106 "
            SQL = SQL & " WHERE K7106_Line		 = '" & FormatSQL(Line) & "' "
            SQL = SQL & " AND K7106_Article		     = '" & FormatSQL(Article) & "' "
            SQL = SQL & " AND K7106_ColorName		 = '" & FormatSQL(ColorName) & "'"
            SQL = SQL & " AND K7106_cdSeason		 = '" & FormatSQL(cdSeason) & "' "
            SQL = SQL & " AND K7106_CustomerCode	 = '" & FormatSQL(CustomerCode) & "' ORDER BY K7106_cdSpecState DESC "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7106_CLEAR() : GoTo SKIP_READ_PFK7106

            Call K7106_MOVE(rd)
            READ_PFK7106_ALL_CUSTOMER = True

SKIP_READ_PFK7106:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7106", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7106_ALL_ABT(Line As String, Article As String, ColorName As String) As Boolean
        READ_PFK7106_ALL_ABT = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK7106 "
            SQL = SQL & " WHERE K7106_Line		 = '" & FormatSQL(Line) & "' "
            SQL = SQL & " AND K7106_Article		     = '" & FormatSQL(Article) & "' "
            SQL = SQL & " AND K7106_ColorName		 = '" & FormatSQL(ColorName) & "' ORDER BY K7106_cdSpecState DESC"

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7106_CLEAR() : GoTo SKIP_READ_PFK7106

            Call K7106_MOVE(rd)
            READ_PFK7106_ALL_ABT = True

SKIP_READ_PFK7106:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7106", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7106_ALL_LG(Article As String, MCODE As String, ColorCode As String) As Boolean
        READ_PFK7106_ALL_LG = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK7106 "
            SQL = SQL & " WHERE K7106_Article		 = '" & FormatSQL(Article) & "' "
            SQL = SQL & " AND K7106_MCODE		     = '" & FormatSQL(MCODE) & "' "
            SQL = SQL & " AND K7106_ColorCode		 = '" & FormatSQL(ColorCode) & "' ORDER BY K7106_cdSpecState DESC"

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7106_CLEAR() : GoTo SKIP_READ_PFK7106

            Call K7106_MOVE(rd)
            READ_PFK7106_ALL_LG = True

SKIP_READ_PFK7106:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7106", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7106_ALL_WWW(Style As String) As Boolean
        READ_PFK7106_ALL_WWW = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK7106 "
            SQL = SQL & " WHERE K7106_Style		 = '" & FormatSQL(Style) & "' ORDER BY K7106_cdSpecState DESC"

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7106_CLEAR() : GoTo SKIP_READ_PFK7106

            Call K7106_MOVE(rd)
            READ_PFK7106_ALL_WWW = True

SKIP_READ_PFK7106:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7106", vbCritical)
        End Try
    End Function
    Public Function DELETE_PFK7114_SIZE_TO_SIZE(z7113 As T7113_AREA) As Boolean
        DELETE_PFK7114_SIZE_TO_SIZE = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK7114 "
            SQL = SQL & " WHERE K7114_BaseComponentBOM		 =   '" & z7113.BaseComponentBOM & "' "
            SQL = SQL & " AND K7114_ShoesCode		 =   '" & z7113.ShoesCode & "' "
            SQL = SQL & " AND K7114_MaterialSeq	 =   " & z7113.MaterialSeq & ""
            SQL = SQL & " AND K7114_SizeNo		 >=   '" & z7113.SizeBegin & "' "
            SQL = SQL & " AND K7114_SizeNo		 <=   '" & z7113.SizeEnd & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK7114_SIZE_TO_SIZE = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK7114", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7235_EXCHANGENAME(ExchangeName As String) As Boolean
        READ_PFK7235_EXCHANGENAME = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7235 "
            SQL = SQL & " WHERE K7235_ExchangeName		 = '" & FormatSQL(ExchangeName) & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7235_CLEAR() : GoTo SKIP_READ_PFK7235

            Call K7235_MOVE(rd)
            READ_PFK7235_EXCHANGENAME = True

SKIP_READ_PFK7235:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7235", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7115_SHOESCODE(SHOESCODE As String) As Boolean
        READ_PFK7115_SHOESCODE = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7115 "
            SQL = SQL & " WHERE K7115_SHOESCODE		 = '" & SHOESCODE & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7115_CLEAR() : GoTo SKIP_READ_PFK7115

            Call K7115_MOVE(rd)
            READ_PFK7115_SHOESCODE = True

SKIP_READ_PFK7115:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7115", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7108_SHOESCODE(SHOESCODE As String) As Boolean
        READ_PFK7108_SHOESCODE = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7108 "
            SQL = SQL & " WHERE K7108_SHOESCODE		 = '" & SHOESCODE & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7108_CLEAR() : GoTo SKIP_READ_PFK7108

            Call K7108_MOVE(rd)
            READ_PFK7108_SHOESCODE = True

SKIP_READ_PFK7108:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7108", vbCritical)
        End Try
    End Function

    Public Function READ_PFK3208_SHOESCODE(SHOESCODE As String) As Boolean
        READ_PFK3208_SHOESCODE = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3208 "
            SQL = SQL & " WHERE K3208_SHOESCODE		 = '" & SHOESCODE & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D3208_CLEAR() : GoTo SKIP_READ_PFK3208

            Call K3208_MOVE(rd)
            READ_PFK3208_SHOESCODE = True

SKIP_READ_PFK3208:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK3208", vbCritical)
        End Try
    End Function

    Public Function READ_PFK7109_SHOESCODE_CNT(SHOESCODE As String) As Boolean
        READ_PFK7109_SHOESCODE_CNT = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 PFK7109.* FROM PFK7109 INNER JOIN PFK7108 ON K7109_GroupComponentBOM = K7108_GroupComponentBOM "
            SQL = SQL & " WHERE K7108_SHOESCODE		 = '" & SHOESCODE & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7109_CLEAR() : GoTo SKIP_READ_PFK7109

            Call K7109_MOVE(rd)
            READ_PFK7109_SHOESCODE_CNT = True

SKIP_READ_PFK7109:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7109_SHOESCODE_CNT", vbCritical)
        End Try
    End Function

    Public Function READ_PFK7305_SHOESCODE(SHOESCODE As String) As Boolean
        READ_PFK7305_SHOESCODE = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7305 "
            SQL = SQL & " WHERE K7305_SHOESCODE		 = '" & SHOESCODE & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7305_CLEAR() : GoTo SKIP_READ_PFK7305

            Call K7305_MOVE(rd)
            READ_PFK7305_SHOESCODE = True

SKIP_READ_PFK7305:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7305", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7311_SHOESCODE(SHOESCODE As String) As Boolean
        READ_PFK7311_SHOESCODE = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7311 INNER JOIN PFK7305 ON K7305_ProcessBOMCode = K7311_ProcessBOMCode "
            SQL = SQL & " WHERE K7305_SHOESCODE		 = '" & SHOESCODE & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7311_CLEAR() : GoTo SKIP_READ_PFK7311

            Call K7311_MOVE(rd)
            READ_PFK7311_SHOESCODE = True

SKIP_READ_PFK7311:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7311", vbCritical)
        End Try
    End Function
    Public Function DELETE_PFK7700_PROCESS(cdMainProcess As String, cdFactory As String, cdOSLineProd As String) As Boolean
        DELETE_PFK7700_PROCESS = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK7700 "
            SQL = SQL & " WHERE K7700_cdMainProcess	 =   '" & cdMainProcess & "'  "
            SQL = SQL & " AND K7700_cdFactory	 =  '" & cdFactory & "'  "
            SQL = SQL & " AND K7700_cdOSLineProd	 =  '" & cdOSLineProd & "'  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK7700_PROCESS = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK7700", vbCritical)
        End Try
    End Function
    Public Function DELETE_PFK7700_1(DateTarget As String, cdMainProcess As String, cdFactory As String, cdOSLineProd As String) As Boolean
        DELETE_PFK7700_1 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE PFK7700 "
            SQL = SQL & " WHERE  K7700_DateTarget		 =  '" & DateTarget & "'  "
            SQL = SQL & " AND K7700_cdMainProcess	 =  '" & cdMainProcess & "'  "
            SQL = SQL & " AND K7700_cdFactory	 =  '" & cdFactory & "'  "
            SQL = SQL & " AND K7700_cdOSLineProd	 =  '" & cdOSLineProd & "'  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK7700_1 = True

SKIP_READ_PFK7700:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7700_1", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7700_1(DateTarget As String, cdMainProcess As String, cdFactory As String, cdOSLineProd As String) As Boolean
        READ_PFK7700_1 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7700 "
            SQL = SQL & " WHERE  K7700_DateTarget		 =  '" & DateTarget & "'  "
            SQL = SQL & " AND K7700_cdMainProcess	 =  '" & cdMainProcess & "'  "
            SQL = SQL & " AND K7700_cdFactory	 =  '" & cdFactory & "'  "
            SQL = SQL & " AND K7700_cdOSLineProd	 =  '" & cdOSLineProd & "'  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7700_CLEAR() : GoTo SKIP_READ_PFK7700

            Call K7700_MOVE(rd)
            READ_PFK7700_1 = True

SKIP_READ_PFK7700:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7700_1", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7156_CODE(cdToolGroup As String, TOOLCODE As String) As Boolean
        READ_PFK7156_CODE = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7156 "
            SQL = SQL & " WHERE K7156_ToolCode		 = '" & TOOLCODE & "' "
            SQL = SQL & " AND K7156_cdToolGroup	 = '" & cdToolGroup & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7156_CLEAR() : GoTo SKIP_READ_PFK7156

            Call K7156_MOVE(rd)
            READ_PFK7156_CODE = True

SKIP_READ_PFK7156:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7156", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7156_NAME(cdToolGroup As String, ToolName As String) As Boolean
        READ_PFK7156_NAME = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7156 "
            SQL = SQL & " WHERE K7156_ToolName		 = '" & ToolName & "' "
            SQL = SQL & " AND K7156_cdToolGroup	 = '" & cdToolGroup & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7156_CLEAR() : GoTo SKIP_READ_PFK7156

            Call K7156_MOVE(rd)
            READ_PFK7156_NAME = True

SKIP_READ_PFK7156:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7156", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7421_ITEMNAME(IDNO As String, ITEMNAME As String) As Boolean
        READ_PFK7421_ITEMNAME = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7421 "
            SQL = SQL & " INNER JOIN PFK9911 ON K9911_ITEMCODE = K7421_ITEMCODE "
            SQL = SQL & " WHERE K7421_IDNO		 = '" & IDNO & "' "
            SQL = SQL & "   AND K9911_ItemName		 = '" & ITEMNAME & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7421_CLEAR() : GoTo SKIP_READ_PFK7421

            Call K7421_MOVE(rd)
            READ_PFK7421_ITEMNAME = True

SKIP_READ_PFK7421:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7421", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7420_ITEMNAME(GroupBase As String, ITEMNAME As String) As Boolean
        READ_PFK7420_ITEMNAME = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7420 "
            SQL = SQL & " INNER JOIN PFK9911 ON K9911_ITEMCODE = K7420_ITEMCODE "
            SQL = SQL & " WHERE K7420_GroupBase		 = '" & GroupBase & "' "
            SQL = SQL & "   AND K9911_ItemName		 = '" & ITEMNAME & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7420_CLEAR() : GoTo SKIP_READ_PFK7420

            Call K7420_MOVE(rd)
            READ_PFK7420_ITEMNAME = True

SKIP_READ_PFK7420:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7420", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7101_CODE(BASICCODE As String) As Boolean
        READ_PFK7101_CODE = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7101 "
            SQL = SQL & " WHERE CAST(K7101_CustomerCode AS DECIMAL(18,0))		 = '" & BASICCODE & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7101_CLEAR() : GoTo SKIP_READ_PFK7101

            Call K7101_MOVE(rd)
            READ_PFK7101_CODE = True

SKIP_READ_PFK7101:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7101_HELPBUTTON", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7101_CODE_CUSTOMER(BASICCODE As String) As Boolean
        READ_PFK7101_CODE_CUSTOMER = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT PFK7101.* FROM PFK7101 WITH (NOLOCK)"
            SQL = SQL & " INNER	JOIN PFK9996 WITH (NOLOCK) ON K7101_CustomerCode = K9996_CustomerCode"

            SQL = SQL & " WHERE  K7101_CheckUse		 = '1' "
            SQL = SQL & " AND  K7101_CheckCustomer		 = '1' "
            SQL = SQL & " AND  K9996_SITE		 = '" & Pub.SITE & "' "
            SQL = SQL & " AND  K9996_SANO		 = '" & Pub.SAW & "' "
            SQL = SQL & " AND  CAST(K7101_CustomerCode AS DECIMAL(18,0))		 = '" & BASICCODE & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7101_CLEAR() : GoTo SKIP_READ_PFK7101

            Call K7101_MOVE(rd)
            READ_PFK7101_CODE_CUSTOMER = True

SKIP_READ_PFK7101:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7101_HELPBUTTON", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7101_NAME(CUSTOMERCODE As String) As Boolean
        READ_PFK7101_NAME = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK7101 "
            SQL = SQL & " WHERE K7101_CustomerName		 = N'" & CUSTOMERCODE & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7101_CLEAR() : GoTo SKIP_READ_PFK7101
            Call K7101_MOVE(rd)

            READ_PFK7101_NAME = True


SKIP_READ_PFK7101:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7101", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7101_NAME_CUSTOMER(CUSTOMERCODE As String) As Boolean
        READ_PFK7101_NAME_CUSTOMER = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT PFK7101.* FROM PFK7101 WITH (NOLOCK)"
            SQL = SQL & " INNER	JOIN PFK9996 WITH (NOLOCK) ON K7101_CustomerCode = K9996_CustomerCode"

            SQL = SQL & " WHERE  K7101_CheckUse		 = '1' "
            SQL = SQL & " AND  K7101_CheckCustomer		 = '1' "
            SQL = SQL & " AND  K9996_SITE		 = '" & Pub.SITE & "' "
            SQL = SQL & " AND  K9996_SANO		 = '" & Pub.SAW & "' "
            SQL = SQL & " AND K7101_CustomerName		 = N'" & CUSTOMERCODE & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7101_CLEAR() : GoTo SKIP_READ_PFK7101_CUSTOMER
            Call K7101_MOVE(rd)

            READ_PFK7101_NAME_CUSTOMER = True

SKIP_READ_PFK7101_CUSTOMER:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7101", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7101_SIMPLENAME(CustomerNameSimply As String) As Boolean
        READ_PFK7101_SIMPLENAME = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK7101 "
            SQL = SQL & " WHERE K7101_CustomerNameSimply		 = N'" & CustomerNameSimply & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7101_CLEAR() : GoTo SKIP_READ_PFK7101
            Call K7101_MOVE(rd)

            READ_PFK7101_SIMPLENAME = True

SKIP_READ_PFK7101:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7101", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7103_TYPECODE(cdTypeCode As String, TypeCode As String) As Boolean
        READ_PFK7103_TYPECODE = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7103 "
            SQL = SQL & " WHERE K7103_cdTypeCode		 =  '" & cdTypeCode & "'  "
            SQL = SQL & " AND K7103_TypeCode	 =  '" & TypeCode & "'  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7103_CLEAR() : GoTo SKIP_READ_PFK7103

            Call K7103_MOVE(rd)
            READ_PFK7103_TYPECODE = True

SKIP_READ_PFK7103:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7103", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7103_TYPENAME(cdTypeCode As String, TypeName As String) As Boolean
        READ_PFK7103_TYPENAME = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7103 "
            SQL = SQL & " WHERE K7103_cdTypeCode		 =  '" & cdTypeCode & "'  "
            SQL = SQL & " AND K7103_TypeName	 =  '" & FormatSQL(TypeName) & "'  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7103_CLEAR() : GoTo SKIP_READ_PFK7103

            Call K7103_MOVE(rd)
            READ_PFK7103_TYPENAME = True

SKIP_READ_PFK7103:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7103", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7121_NAME(COLORNAME As String) As Boolean
        READ_PFK7121_NAME = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7121 "
            SQL = SQL & " WHERE K7121_COLORNAME		 = '" & COLORNAME & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7121_CLEAR() : GoTo SKIP_READ_PFK7121

            Call K7121_MOVE(rd)
            READ_PFK7121_NAME = True

SKIP_READ_PFK7121:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7121", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7171_HELPBUTTON(BASICSEL As String, BASICCODE As String) As Boolean
        READ_PFK7171_HELPBUTTON = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7171 "
            SQL = SQL & " WHERE K7171_BasicSel		 = '" & BASICSEL & "' "
            SQL = SQL & "   AND CAST(K7171_BasicCode AS DECIMAL(18,0))		 = '" & CDblp(BASICCODE).ToString & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7171_CLEAR() : GoTo SKIP_READ_PFK7171

            Call K7171_MOVE(rd)
            READ_PFK7171_HELPBUTTON = True

SKIP_READ_PFK7171:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7171_HELPBUTTON", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7171_CODE(BASICSEL As String, BASICCODE As String) As Boolean
        READ_PFK7171_CODE = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7171 "
            SQL = SQL & " WHERE K7171_BasicSel		 = '" & BASICSEL & "' "
            SQL = SQL & "   AND CAST(K7171_BasicCode AS DECIMAL(18,0))		 = '" & CDblp(BASICCODE).ToString & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7171_CLEAR() : GoTo SKIP_READ_PFK7171

            Call K7171_MOVE(rd)
            READ_PFK7171_CODE = True

SKIP_READ_PFK7171:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7171_HELPBUTTON", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7171_NAME(BASICSEL As String, BASICName As String) As Boolean
        READ_PFK7171_NAME = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK7171 "
            SQL = SQL & " WHERE K7171_BasicSel		 = '" & BASICSEL & "' "
            SQL = SQL & "   AND K7171_BasicName		 = '" & FormatSQL(BASICName) & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7171_CLEAR() : GoTo SKIP_READ_PFK7171
            Call K7171_MOVE(rd)

            READ_PFK7171_NAME = True

SKIP_READ_PFK7171:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7171_HELPBUTTON", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7171_SIMPLENAME(BASICSEL As String, NameSimply As String) As Boolean
        READ_PFK7171_SIMPLENAME = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK7171 "
            SQL = SQL & " WHERE K7171_BasicSel		 = '" & BASICSEL & "' "
            SQL = SQL & "   AND K7171_NameSimply		 = '" & FormatSQL(NameSimply) & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7171_CLEAR() : GoTo SKIP_READ_PFK7171
            Call K7171_MOVE(rd)

            READ_PFK7171_SIMPLENAME = True

SKIP_READ_PFK7171:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7171_HELPBUTTON", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7199_TOP1(VinaCode As String) As Boolean
        READ_PFK7199_TOP1 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK7199 "
            SQL = SQL & " WHERE K7199_DateExchange		 <= '" & VinaCode & "' "
            SQL = SQL & " AND   K7199_VND		         >  0 "
            SQL = SQL & " ORDER BY  K7199_DateExchange DESC"

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7199_CLEAR() : GoTo SKIP_READ_PFK7199_TOP1

            Call K7199_MOVE(rd)

            READ_PFK7199_TOP1 = True
SKIP_READ_PFK7199_TOP1:
            rd.Close()

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7199_TOP1", vbCritical)
        End Try
    End Function
    Public Function DELETE_PFK7199_ALL(z7199 As T7199_AREA) As Boolean
        DELETE_PFK7199_ALL = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK7199 "
            SQL = SQL & " WHERE K7199_DateExchange		 = '" & z7199.DateExchange & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK7199_ALL = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK7199", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7231_VINA(VinaCode As String) As Boolean
        READ_PFK7231_VINA = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7231 "
            SQL = SQL & " WHERE K7231_VinaCode		 = '" & VinaCode & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7231_CLEAR() : GoTo SKIP_READ_PFK7231

            READ_PFK7231_VINA = True

SKIP_READ_PFK7231:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7231", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7231_SHOESCODE(VinaCode As String) As Boolean
        READ_PFK7231_SHOESCODE = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7231 "
            SQL = SQL & " WHERE K7231_OtherCode1		 = '" & VinaCode & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7231_CLEAR() : GoTo SKIP_READ_PFK7231
            K7231_MOVE(rd)

            READ_PFK7231_SHOESCODE = True

SKIP_READ_PFK7231:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7231", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7231_NAME_FULLNAME(MaterialName As String) As Boolean
        READ_PFK7231_NAME_FULLNAME = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7231 "
            SQL = SQL & " WHERE K7231_MaterialFullName		 = N'" & FormatSQL(READ_PFK7231_NAME_FULLNAME) & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7231_CLEAR() : GoTo SKIP_READ_PFK7231
            K7231_MOVE(rd)

            READ_PFK7231_NAME_FULLNAME = True

SKIP_READ_PFK7231:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7231", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7231_NAME(MaterialName As String) As Boolean
        READ_PFK7231_NAME = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7231 "
            SQL = SQL & " WHERE K7231_MaterialName		 = N'" & FormatSQL(MaterialName) & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7231_CLEAR() : GoTo SKIP_READ_PFK7231
            K7231_MOVE(rd)

            READ_PFK7231_NAME = True

SKIP_READ_PFK7231:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7231", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7231_NAME_RND(MaterialName As String, Width As String, Height As String, SizeName As String) As Boolean
        READ_PFK7231_NAME_RND = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7231 "
            SQL = SQL & " WHERE K7231_MaterialName		 = N'" & FormatSQL(MaterialName) & "' "
            SQL = SQL & " AND   K7231_CheckDevRnD		 = '2' "
            SQL = SQL & " AND K7231_Width		     = N'" & FormatSQL(Width) & "' "
            SQL = SQL & " AND K7231_Height		     = N'" & FormatSQL(Height) & "' "
            SQL = SQL & " AND K7231_SizeName		 = N'" & FormatSQL(SizeName) & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7231_CLEAR() : GoTo SKIP_READ_PFK7231
            K7231_MOVE(rd)

            READ_PFK7231_NAME_RND = True

SKIP_READ_PFK7231:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7231", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7231_CHECKNAME(MaterialName As String, Width As String, Height As String, SizeName As String) As Boolean
        READ_PFK7231_CHECKNAME = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7231 "
            SQL = SQL & " WHERE K7231_MaterialName	 = N'" & FormatSQL(MaterialName) & "' "
            SQL = SQL & " AND K7231_Width		     = N'" & FormatSQL(Width) & "' "
            SQL = SQL & " AND K7231_Height		     = N'" & FormatSQL(Height) & "' "
            SQL = SQL & " AND K7231_SizeName		 = N'" & FormatSQL(SizeName) & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7231_CLEAR() : GoTo SKIP_READ_PFK7231
            K7231_MOVE(rd)

            READ_PFK7231_CHECKNAME = True

SKIP_READ_PFK7231:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7231", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7231_CHECKNAME(MaterialName As String, MaterialPName As String) As Boolean
        READ_PFK7231_CHECKNAME = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7231 "
            SQL = SQL & " WHERE K7231_MaterialName	 = N'" & FormatSQL(MaterialName) & "' "
            SQL = SQL & " AND K7231_MaterialPName  = N'" & FormatSQL(MaterialPName) & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7231_CLEAR() : GoTo SKIP_READ_PFK7231
            K7231_MOVE(rd)

            READ_PFK7231_CHECKNAME = True

SKIP_READ_PFK7231:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7231", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7231_CHECKNAME_FULL(MaterialName As String) As Boolean
        READ_PFK7231_CHECKNAME_FULL = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7231 "
            SQL = SQL & " WHERE RTRIM(REPLACE(RTRIM(K7231_MaterialName + K7231_MaterialPName),K7231_Width,'')) = N'" & Trim(FormatSQL(MaterialName)) & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then
                rd.Close()
                Call D7231_CLEAR()
                Dim Value() As String
                Dim strTemp As String
                Dim strValue As String

                strValue = Trim(FormatSQL(MaterialName))
                strValue = strValue.Replace("  ", " ")

                strValue = strValue.Replace("(", Space(1))
                strValue = strValue.Replace(")", Space(1))

                strValue = strValue.Replace(",", "")


                strValue = strValue.Replace("""", "")
                strValue = strValue.Replace("  ", " ")
                strValue = Trim(strValue)
                strValue = strValue.Replace("  ", " ")
                Value = strValue.Split(" ")

                Dim Value1 As String
                Dim Value2 As String
                Dim Value3 As String
                Dim Value4 As String
                Dim Value5 As String
                Dim Value6 As String
                Dim Value7 As String
                Dim Value8 As String

                If Value.Length >= 1 Then
                    If Value.Length >= 1 Then
                        If Value(0).Contains(".") Then
                            Value(0) = ""
                            strTemp = Value(0)

                            If Value.Length >= 2 Then If Value(1).Contains(".") = False Then strTemp &= Value(1)
                            If Value.Length >= 3 Then If Value(2).Contains(".") = False Then strTemp &= " AND " & Value(2)
                            If Value.Length >= 4 Then If Value(3).Contains(".") = False Then strTemp &= " AND " & Value(3)
                            If Value.Length >= 5 Then If Value(4).Contains(".") = False Then strTemp &= " AND " & Value(4)
                            If Value.Length >= 6 Then If Value(5).Contains(".") = False Then strTemp &= " AND " & Value(5)
                            If Value.Length >= 7 Then If Value(6).Contains(".") = False Then strTemp &= " AND " & Value(6)
                            If Value.Length >= 8 Then If Value(7).Contains(".") = False Then strTemp &= " AND " & Value(7)

                        Else
                            If Value.Length >= 1 Then strTemp = Value(0)
                            If Value.Length >= 2 Then If Value(1).Contains(".") = False Then strTemp &= " AND " & Value(1)
                            If Value.Length >= 3 Then If Value(2).Contains(".") = False Then strTemp &= " AND " & Value(2)
                            If Value.Length >= 4 Then If Value(3).Contains(".") = False Then strTemp &= " AND " & Value(3)
                            If Value.Length >= 5 Then If Value(4).Contains(".") = False Then strTemp &= " AND " & Value(4)
                            If Value.Length >= 6 Then If Value(5).Contains(".") = False Then strTemp &= " AND " & Value(5)
                            If Value.Length >= 7 Then If Value(6).Contains(".") = False Then strTemp &= " AND " & Value(6)
                            If Value.Length >= 8 Then If Value(7).Contains(".") = False Then strTemp &= " AND " & Value(7)
                        End If


                    End If
                End If


                SQL = " SELECT * FROM PFK7231 "
                SQL = SQL & " WHERE CONTAINS(K7231_MaterialFULLName, N'" & strTemp & "') "

                cmd = New SqlClient.SqlCommand(SQL, cn)
                rd = cmd.ExecuteReader
                rd.Read()

                If rd.HasRows = False Then Call D7231_CLEAR() : GoTo SKIP_READ_PFK7231

            End If

            K7231_MOVE(rd)

            READ_PFK7231_CHECKNAME_FULL = True

SKIP_READ_PFK7231:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7231", vbCritical)
        End Try
    End Function
    Public Function READ_PFK7231_CODE(MaterialCode As String) As Boolean
        READ_PFK7231_CODE = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7231 "
            SQL = SQL & " WHERE CAST(K7231_MaterialCode AS DECIMAL(18,0))		 = '" & MaterialCode & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7231_CLEAR() : GoTo SKIP_READ_PFK7231

            Call K7231_MOVE(rd)
            READ_PFK7231_CODE = True

SKIP_READ_PFK7231:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7231_HELPBUTTON", vbCritical)
        End Try
    End Function




#End Region

#Region "8000"


#End Region

#Region "9000"
    Public Sub DELETE_PFK9702_ALL(FormName As String, User As String)

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK9702 "
            SQL = SQL & " WHERE K9702_FormName		=  '" & FormName & "'  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("READ_PFK9702_01", vbCritical)
        End Try
    End Sub
    Public Function READ_PFK9702_01(FormName As String, User As String) As Boolean
        READ_PFK9702_01 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9702 "
            SQL = SQL & " WHERE K9702_FormName		=  '" & FormName & "'  "
            SQL = SQL & " AND   K9702_User		    =  '" & User & "'  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then GoTo SKIP_READ_PFK9702

            READ_PFK9702_01 = True

SKIP_READ_PFK9702:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK9702_01", vbCritical)
        End Try
    End Function
    Public Function READ_PFK9702_02(FormName As String, User As String, ItemName As String) As Boolean
        READ_PFK9702_02 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9702 "
            SQL = SQL & " WHERE K9702_FormName		=  '" & FormName & "'  "
            SQL = SQL & " AND   K9702_User		    =  '" & User & "'  "
            SQL = SQL & " AND   K9702_ItemName		=  '" & ItemName & "'  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then GoTo SKIP_READ_PFK9702
            Call K9702_MOVE(rd)

            READ_PFK9702_02 = True

SKIP_READ_PFK9702:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK9702_01", vbCritical)
        End Try
    End Function
    Public Sub Save_History_PFK9709(_ActionName As String, _Formname As String, _Reference As String)
        Try
            D9709_CLEAR()
            D9709.ActionName = _ActionName
            D9709.DateCreate = Pub.DAT
            D9709.UserCode = Pub.SAW
            D9709.FormName = _Formname
            D9709.Reference = _Reference

            D9709.DeviceName = R9700.DeviceName
            D9709.MACAddress = R9700.MACAddress
            D9709.IPv4Address = R9700.IPv4Address
            D9709.DHCPServer = R9700.DHCPServer
            D9709.IPWan = R9700.IPWan

            D9709.DNSdomain = R9700.DNSdomain
            D9709.DHCPServer = R9700.DHCPServer

            D9709.HDDSerialNo = R9700.HDDSerialNo
            D9709.ComputerName = R9700.ComputerName
            D9709.AccountWin = R9700.AccountWin

            D9709.UserCode = Pub.SAW
            D9709.DateTimeCreate = System_Date_time()

            Call WRITE_PFK9709(D9709)
        Catch ex As Exception

        End Try

    End Sub
    Public Function READ_PFK9911_ITEMCODE(ITEMCODE As String) As Boolean
        READ_PFK9911_ITEMCODE = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9911 "
            SQL = SQL & "   WHERE K9911_ITEMCODE		 = '" & ITEMCODE & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9911_CLEAR() : GoTo SKIP_READ_PFK9911

            Call K9911_MOVE(rd)
            READ_PFK9911_ITEMCODE = True

SKIP_READ_PFK9911:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK9911", vbCritical)
        End Try
    End Function
    Public Function READ_PFK9912_2(PRODJECTNAME As String, PROGRAMNO As String, SHEETNAME As String, ItemName As String) As Boolean
        READ_PFK9912_2 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT M1.* FROM PFK9912 M1  INNER JOIN PFK9911 M2 ON M1.K9912_ItemCode = M2.K9911_ItemCode "
            SQL = SQL & " WHERE M1.K9912_ProdjectName		 = '" & PRODJECTNAME & "' "
            SQL = SQL & "   AND M1.K9912_ProgramNo		 = '" & PROGRAMNO & "' "
            SQL = SQL & "   AND M1.K9912_SheetName		 = '" & SHEETNAME & "' "
            SQL = SQL & "   AND M2.K9911_ItemName		 = '" & ItemName & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9912_CLEAR() : GoTo SKIP_READ_PFK9912

            Call K9912_MOVE(rd)
            READ_PFK9912_2 = True

SKIP_READ_PFK9912:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("37", "READ_PFK9912")
        End Try
    End Function
    Public Function READ_PFK9912_3(PRODJECTNAME As String, PROGRAMNO As String, SHEETNAME As String, ItemCode As String) As Boolean
        READ_PFK9912_3 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9912 "
            SQL = SQL & " WHERE K9912_ProdjectName		 = '" & PRODJECTNAME & "' "
            SQL = SQL & "   AND K9912_ProgramNo		     = '" & PROGRAMNO & "' "
            SQL = SQL & "   AND K9912_SheetName		     = '" & SHEETNAME & "' "
            SQL = SQL & "   AND K9912_ItemCode  		 = '" & ItemCode & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9912_CLEAR() : GoTo SKIP_READ_PFK9912

            Call K9912_MOVE(rd)
            READ_PFK9912_3 = True

SKIP_READ_PFK9912:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK9912", vbCritical)
        End Try
    End Function
    Public Function READ_PFK9912_DELETE(PRODJECTNAME As String, PROGRAMNO As String, SHEETNAME As String) As Boolean
        READ_PFK9912_DELETE = False

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
            READ_PFK9912_DELETE = True

SKIP_READ_PFK9912:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK9912", vbCritical)
        End Try
    End Function
    Public Function READ_PFK9912_CHECKDEV(PRODJECTNAME As String, PROGRAMNO As String, SHEETNAME As String) As Boolean
        READ_PFK9912_CHECKDEV = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9912 "
            SQL = SQL & " WHERE K9912_ProdjectName		 = '" & PRODJECTNAME & "' "
            SQL = SQL & "   AND K9912_ProgramNo		 = '" & PROGRAMNO & "' "
            SQL = SQL & "   AND K9912_CheckDev = '1' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9912_CLEAR() : GoTo SKIP_READ_PFK9912

            Call K9912_MOVE(rd)
            READ_PFK9912_CHECKDEV = True

SKIP_READ_PFK9912:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK9912", vbCritical)
        End Try
    End Function
    Public Function READ_PFK9912_CHECKDSEQ(PRODJECTNAME As String, PROGRAMNO As String, SHEETNAME As String) As Boolean
        READ_PFK9912_CHECKDSEQ = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT K9912_ProgramDSeq FROM PFK9912 "
            SQL = SQL & " WHERE K9912_ProdjectName	 = '" & PRODJECTNAME & "' "
            SQL = SQL & "   AND K9912_ProgramNo		 = '" & PROGRAMNO & "' "
            SQL = SQL & "   AND K9912_ProgramDSeq    = '1' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9912_CLEAR() : GoTo SKIP_READ_PFK9912

            READ_PFK9912_CHECKDSEQ = True

SKIP_READ_PFK9912:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK9912", vbCritical)
        End Try
    End Function
    Public Function REWRITE_PFK9912_UPDATE_DSEQ1(ProdjectName As String, ProgramNo As String, SheetName As String) As Boolean
        REWRITE_PFK9912_UPDATE_DSEQ1 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try

            SQL = " UPDATE PFK9912 SET "
            SQL = SQL & "    K9912_ProgramDSeq      =  0  "
            SQL = SQL & " WHERE K9912_ProdjectName		 = '" & ProdjectName & "' "
            SQL = SQL & "   AND K9912_ProgramNo		 = '" & ProgramNo & "' "
            SQL = SQL & "   AND K9912_SheetName		 = '" & SheetName & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK9912_UPDATE_DSEQ1 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK9912", vbCritical)
        End Try
    End Function
    Public Function DELETE_PFK9912_DSEQ1(ProdjectName As String, ProgramNo As String, SheetName As String) As Boolean
        DELETE_PFK9912_DSEQ1 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK9912 "
            SQL = SQL & " WHERE K9912_ProdjectName		 = '" & ProdjectName & "' "
            SQL = SQL & "   AND K9912_ProgramNo		 = '" & ProgramNo & "' "
            SQL = SQL & "   AND K9912_SheetName		 = '" & SheetName & "' "
            SQL = SQL & "   AND K9912_ProgramDSeq	= 0  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK9912_DSEQ1 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK9912", vbCritical)
        End Try
    End Function
    Public Function READ_PFK9912_1(PROGRAMNO As String, SHEETNAME As String) As Boolean
        READ_PFK9912_1 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK9912 "
            SQL = SQL & " WHERE K9912_ProgramNo		 = '" & PROGRAMNO & "' "
            SQL = SQL & "   AND K9912_SheetName		 = '" & SHEETNAME & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9912_CLEAR() : GoTo SKIP_READ_PFK9912

            Call K9912_MOVE(rd)
            READ_PFK9912_1 = True

SKIP_READ_PFK9912:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("37", "READ_PFK9912")
        End Try
    End Function
    Public Function READ_PFK9913_ITEMNAME(Sano As String, PRODJECTNAME As String, PROGRAMNO As String, SHEETNAME As String, ItemCode As String) As Boolean
        READ_PFK9913_ITEMNAME = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9913 "
            SQL = SQL & " WHERE K9913_ProdjectName		 = '" & PRODJECTNAME & "' "
            SQL = SQL & "   AND K9913_ProgramNo		 = '" & PROGRAMNO & "' "
            SQL = SQL & "   AND K9913_SheetName		 = '" & SHEETNAME & "' "
            SQL = SQL & "   AND K9913_Sano		 = '" & Sano & "' "
            SQL = SQL & "   AND K9913_ItemCode		 = '" & ItemCode & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)

            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9913_CLEAR() : GoTo SKIP_READ_PFK9913

            Call K9913_MOVE(rd)
            READ_PFK9913_ITEMNAME = True

SKIP_READ_PFK9913:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("37", "READ_PFK9912")
        End Try
    End Function
    Public Function READ_PFK9912_1(PRODJECTNAME As String, PROGRAMNO As String, SHEETNAME As String, ItemCode As String) As Boolean
        READ_PFK9912_1 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9912 "
            SQL = SQL & " WHERE K9912_ProdjectName		 = '" & PRODJECTNAME & "' "
            SQL = SQL & "   AND K9912_ProgramNo		 = '" & PROGRAMNO & "' "
            SQL = SQL & "   AND K9912_SheetName		 = '" & SHEETNAME & "' "
            SQL = SQL & "   AND K9912_ItemCode		 = '" & ItemCode & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9912_CLEAR() : GoTo SKIP_READ_PFK9912

            Call K9912_MOVE(rd)
            READ_PFK9912_1 = True

SKIP_READ_PFK9912:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("37", "READ_PFK9912")
        End Try
    End Function
    Public Function READ_PFK9916_DEV_SELCODE(PROGRAMNO As String, ITEMNAME As String) As String
        READ_PFK9916_DEV_SELCODE = ""

        Try
            SQL = " SELECT * FROM PFK9916 "
            SQL = SQL & " WHERE K9916_ProgramNo		 = '" & PROGRAMNO & "' "
            SQL = SQL & "   AND K9916_ItemName		 = '" & ITEMNAME & "' "
            SQL = SQL & "   AND K9916_CheckDev		 = '1' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then GoTo SKIP_READ_PFK9916
            If rd!K9916_REMK.ToString.Contains(";") Then
                Return Split(rd!K9916_REMK, ";")(1)
            End If

SKIP_READ_PFK9916:
            rd.Close()
            Return ""
        Catch ex As Exception

        End Try
    End Function
    Public Function READ_PFK9916_2(PROGRAMNO As String) As Boolean
        READ_PFK9916_2 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9916 "
            SQL = SQL & " WHERE K9916_ProgramNo		 = '" & PROGRAMNO & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9916_CLEAR() : GoTo SKIP_READ_PFK9916

            Call K9916_MOVE(rd)
            READ_PFK9916_2 = True

SKIP_READ_PFK9916:
            rd.Close()
            Exit Function
        Catch ex As Exception

        End Try
    End Function
    Public Function DELETE_PFK9916_1(z9916 As T9916_AREA) As Boolean
        DELETE_PFK9916_1 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK9916 "
            SQL = SQL & " WHERE K9916_ProgramNo		 = '" & z9916.ProgramNo & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK9916_1 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK9916", vbCritical)
        End Try
    End Function
    Public Function READ_PFK9916_1(PROGRAMNO As String, ITEMNAME As String) As Boolean
        READ_PFK9916_1 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9916 "
            SQL = SQL & " WHERE K9916_ProgramNo		 = '" & PROGRAMNO & "' "
            SQL = SQL & "   AND K9916_ItemName		 = '" & ITEMNAME & "' "
            SQL = SQL & "   AND K9916_CheckDev		 = '1' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9916_CLEAR() : GoTo SKIP_READ_PFK9916

            Call K9916_MOVE(rd)
            READ_PFK9916_1 = True

SKIP_READ_PFK9916:
            rd.Close()
            Exit Function
        Catch ex As Exception

        End Try
    End Function
    Public Function DELETE_PFK9919_1(z9919 As T9919_AREA) As Boolean
        DELETE_PFK9919_1 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK9919 "
            SQL = SQL & " WHERE K9919_ProgramNo		 = '" & z9919.ProgramNo & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK9919_1 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK9919", vbCritical)
        End Try
    End Function
    Public Function READ_PFK9919_2(PROGRAMNO As String) As Boolean
        READ_PFK9919_2 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9919 "
            SQL = SQL & " WHERE K9919_ProgramNo		 = '" & PROGRAMNO & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9919_CLEAR() : GoTo SKIP_READ_PFK9919

            Call K9919_MOVE(rd)
            READ_PFK9919_2 = True

SKIP_READ_PFK9919:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK9919", vbCritical)
        End Try
    End Function
    Public Function READ_PFK9919_1(PROGRAMNO As String, ITEMNAME As String) As Boolean
        READ_PFK9919_1 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9919 "
            SQL = SQL & " WHERE K9919_ProgramNo		 = '" & PROGRAMNO & "' "
            SQL = SQL & "   AND K9919_ItemName		 = '" & ITEMNAME & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9919_CLEAR() : GoTo SKIP_READ_PFK9919

            Call K9919_MOVE(rd)
            READ_PFK9919_1 = True

SKIP_READ_PFK9919:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK9919", vbCritical)
        End Try
    End Function
    Public Function READ_PFK9919_3(ITEMNAME As String) As Boolean
        READ_PFK9919_3 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT TOP 1 * FROM PFK9919 "
            SQL = SQL & " WHERE K9919_ItemName		 = '" & ITEMNAME & "' ORDER BY  K9919_ItemNameForeign2 DESC "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9919_CLEAR() : GoTo SKIP_READ_PFK9919

            Call K9919_MOVE(rd)
            READ_PFK9919_3 = True

SKIP_READ_PFK9919:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK9919", vbCritical)
        End Try
    End Function
    Public Function READ_PFK9996_LIST(SITE As String, SANO As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9996 "
            SQL = SQL & " WHERE K9996_SITE		 = '" & SITE & "' "
            SQL = SQL & "   AND K9996_SANO		 = '" & SANO & "' "

            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK9996", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function



#End Region

#Region "Function Names"
    Public Function READ_PFK9550_Dseq(CDWORKFLOW As String, Dseq As Double) As Boolean
        READ_PFK9550_Dseq = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9550 "
            SQL = SQL & " WHERE K9550_cdWorkFlow		 = '" & CDWORKFLOW & "' "
            SQL = SQL & "   AND K9550_Dseq		 =  " & Dseq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9550_CLEAR() : GoTo SKIP_READ_PFK9550

            Call K9550_MOVE(rd)
            READ_PFK9550_Dseq = True

SKIP_READ_PFK9550:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK9550", vbCritical)
        End Try
    End Function
    Public Function READ_PFK9550_DSEQ(CDWORKFLOW As String, Dseq As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9550 "
            SQL = SQL & " WHERE K9550_cdWorkFlow		 = '" & CDWORKFLOW & "' "
            SQL = SQL & "   AND K9550_Dseq		 =  " & Dseq & "  "

            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK9550", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function
    Public Sub Delete_History(_Formname As String, _Reference As String)
        Try
            D9700_CLEAR()
            D9700.ActionName = "0cmd_DELETE"
            D9700.DateCreate = Pub.DAT
            D9700.UserCode = Pub.SAW
            D9700.FormName = _Formname
            D9700.Reference = _Reference

            D9700.DeviceName = R9700.DeviceName
            D9700.MACAddress = R9700.MACAddress
            D9700.IPv4Address = R9700.IPv4Address
            D9700.DHCPServer = R9700.DHCPServer
            D9700.IPWan = R9700.IPWan

            D9700.DNSdomain = R9700.DNSdomain
            D9700.DHCPServer = R9700.DHCPServer

            D9700.HDDSerialNo = R9700.HDDSerialNo
            D9700.ComputerName = R9700.ComputerName
            D9700.AccountWin = R9700.AccountWin

            D9700.UserCode = Pub.SAW
            D9700.DateTimeCreate = System_Date_time()

            Call WRITE_PFK9700(D9700)
        Catch ex As Exception

        End Try

    End Sub
    Public Function CheckData_Customer(sCustomercode As String, wjob As Integer) As Boolean
        CheckData_Customer = False

        CheckData_Customer = True : Exit Function

        Try
            If Pub.NAM.ToUpper = "PSMADMIN" Then CheckData_Customer = True : Exit Function

            If READ_PFK9992(Pub.SITE, Trim$(Pub.SAW)) = True Then

                If D9992.CUSTOMER_CHK = "1" Then
                    If List_Customer.Count = 0 Then CheckData_Customer = True : Exit Function
                    If List_Customer.Contains(sCustomercode) = False Then CheckData_Customer = False : Exit Function

                    'Select Case wjob
                    '    Case 1
                    '        If LIST_D9996(List_Customer.IndexOf(sCustomercode)).CHK01 = "1" Then CheckData_Customer = True Else CheckData_Customer = False
                    '    Case 2
                    '        If LIST_D9996(List_Customer.IndexOf(sCustomercode)).CHK02 = "1" Then CheckData_Customer = True Else CheckData_Customer = False
                    '    Case 3
                    '        If LIST_D9996(List_Customer.IndexOf(sCustomercode)).CHK03 = "1" Then CheckData_Customer = True Else CheckData_Customer = False
                    '    Case 4
                    '        If LIST_D9996(List_Customer.IndexOf(sCustomercode)).CHK04 = "1" Then CheckData_Customer = True Else CheckData_Customer = False
                    '    Case 5
                    '        If LIST_D9996(List_Customer.IndexOf(sCustomercode)).CHK05 = "1" Then CheckData_Customer = True Else CheckData_Customer = False
                    'End Select

                End If

                CheckData_Customer = True
            End If

        Catch ex As Exception

        End Try
    End Function
    Public Function CheckData_Department(sDepartment As String, wjob As Integer) As Boolean
        CheckData_Department = False

        CheckData_Department = True : Exit Function


        Try
            If Trim$(Pub.NAM.ToUpper) = "PSMADMIN" Then CheckData_Department = True : Exit Function

            If Trim$(sDepartment.ToUpper) = "" Then Exit Function

            If Trim$(Pub.DEPARTMENTCHK) = "1" Then
                If READ_PFK7171(ListCode("Department"), Trim$(Pub.DEPARTMENT)) = True Then

                    If Trim$(sDepartment) <> Trim$(D7171.BasicCode) Then Exit Function

                    CheckData_Department = True
                End If
            Else
                CheckData_Department = False
            End If

        Catch ex As Exception

        End Try
    End Function
    Public Function CheckData_Incharge(sIncharge As String, wjob As Integer) As Boolean
        CheckData_Incharge = False

        Try
            '         If Pub.NAM.ToUpper = "PSMADMIN" Then CheckData_Incharge = True : Exit Function

            'If Trim$(sIncharge.ToUpper) = "" Then Exit Function

            'If READ_PFK7411(Trim$(Pub.SAW)) = True Then
            '    If Trim$(sIncharge) <> Trim$(D7411.IDNO) Then Exit Function

            '    CheckData_Incharge = True
            'End If
            CheckData_Incharge = True
        Catch ex As Exception

        End Try
    End Function
    Public Function READ_FROM_MULTI(SLNO As String) As Boolean
        READ_FROM_MULTI = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT top 1 * FROM [CS_PRINT].[dbo].[A_SHEETPRINT_MATCHING] "
            SQL = SQL & " WHERE PROG	 = '" & SLNO & "' "
            SQL = SQL & " AND CHECKUSE	 = '1' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then READ_FROM_MULTI = False Else READ_FROM_MULTI = True

            rd.Close()

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_FROM_MULTI", vbCritical)
        End Try
    End Function

    Public Sub SetData_Material(sender As Object, xrow As Integer)
        Try
            setData(sender, getColumIndex(sender, "MaterialCode"), xrow, D7231.MaterialCode)
            setData(sender, getColumIndex(sender, "MaterialName"), xrow, D7231.MaterialName)
            setData(sender, getColumIndex(sender, "QtyBasic"), xrow, D7231.QtyBasic)
            setData(sender, getColumIndex(sender, "QtyMOQ"), xrow, D7231.QtyMOQ)

            setData(sender, getColumIndex(sender, "seUnitMaterial"), xrow, D7231.seUnitMaterial)
            setData(sender, getColumIndex(sender, "cdUnitMaterial"), xrow, D7231.cdUnitMaterial)
            Call READ_PFK7171(D7231.seUnitMaterial, D7231.cdUnitMaterial)
            setData(sender, getColumIndex(sender, "cdUnitMaterialName"), xrow, D7171.BasicName)

            setData(sender, getColumIndex(sender, "seUnitPacking"), xrow, D7231.seUnitPacking)
            setData(sender, getColumIndex(sender, "cdUnitPacking"), xrow, D7231.cdUnitPacking)

            Call READ_PFK7171(D7231.seUnitPacking, D7231.cdUnitPacking)
            setData(sender, getColumIndex(sender, "cdUnitPackingName"), xrow, D7171.BasicName)

            setData(sender, getColumIndex(sender, "seUnitPrice"), xrow, D7231.seUnitPrice)
            setData(sender, getColumIndex(sender, "cdUnitPrice"), xrow, D7231.cdUnitPrice)
            Call READ_PFK7171(D7231.seUnitPrice, D7231.cdUnitPrice)
            setData(sender, getColumIndex(sender, "cdUnitPriceName"), xrow, D7171.BasicName)
        Catch ex As Exception

        End Try

    End Sub
    Public Function KNAME_Check(BasicSel As String, BasicCode As String, Optional Data As String = "") As Boolean

        BasicCode = Replace(BasicCode, "'", "`")

        KNAME_Check = False

        If IsNumeric(BasicCode) = True Then
            BasicCode = FormatP(BasicCode, "000")
            If READ_PFK7171(BasicSel, BasicCode) = True Then
                GoTo pass
            End If
        Else
            TranValueText = BasicCode
            If HLP7171ALL.Link_HLP7171A(BasicSel, BasicCode) = False Then Exit Function

        End If

pass:
        KNAME_Check = True

    End Function
    Public Function FormatSQL(tmpdatetime As String) As String
        If tmpdatetime = "" Then Return ""
        FormatSQL = tmpdatetime.ToString.Replace("'", "''")
    End Function
    Public Sub APP_EXIT(Optional ByVal QuickExit As Boolean = False)
        Application.Exit()

        'If QuickExit = False Then

        '    If MsgBoxP("Do you want to Exit Program?", vbYesNo) = vbYes Then

        '        Application.Exit()

        '    End If

        'Else

        '    Application.Exit()

        'End If

    End Sub
    Public Function Gname_Check(KeyCode As Integer, Shift As Integer, _
                       GCHK As String, GCODE As String, Ctl_Gcode As Control) As Boolean

        GCODE = Replace(GCODE, "'", "`")

        Gname_Check = False

        Select Case KeyCode
            Case Keys.Up, Keys.Down

                '    If IsNumeric(GCODE) = True Then
                '        GCODE = Format(GCODE, "000000") 'Ctl_Gcode = GCODE
                '        If READ_PFK7101(GCODE) = True Then
                '            Ctl_Gcode.Text = Trim(D7101.GNAME)
                '            Gname_Check = True
                '            Exit Function
                '        End If
                '    Else
                '        If READ_PFK7101N(GCODE) = True Then
                '            Ctl_Gcode.Text = Trim(D7101.GNAME)
                '            '  Ctl_Gcode.ToolTipText = Trim(D7101.GCODE)
                '            Gname_Check = True
                '            Exit Function
                '        End If
                '    End If

                '    HlpStr = Ctl_Gcode.Text

                '    If HLP7101A.Link_HLP7101A(GCHK) = False Then Exit Function

                '    Ctl_Gcode.Text = Trim(D7101.GNAME)
                '    '         Ctl_Gcode.ToolTipText = Trim(D7101.GCODE)

                'Case Keys.PageDown, Keys.F1

                '    HlpStr = Ctl_Gcode.Text

                '    If HLP7101A.Link_HLP7101A(GCHK) = False Then
                '        Exit Function
                '    Else
                '        Ctl_Gcode.Text = Trim(D7101.GNAME)
                '    End If
                '         Ctl_Gcode.ToolTipText = Trim(D7101.GCODE)

        End Select
    End Function
    Public Function CheckMaterialAll() As Boolean
        CheckMaterialAll = False

        If FormatCut(D7231.cdLargeGroupMaterial) = "" Or FormatCut(D7231.cdSemiGroupMaterial) = "" Or FormatCut(D7231.cdUnitMaterial) = "" Then
            If ISUD7231S.Link_ISUD7231S(3, D7231.MaterialCode, "PFP70231") = False Then Exit Function
            CheckMaterialAll = True
        Else
            CheckMaterialAll = True
        End If

    End Function
    Public Function FormatP(Value As Object, Type As String) As String
        Try
            If Type = "0" Then
                Return CIntp(Value).ToString("0")

            ElseIf Type = "00" Then
                Return CIntp(Value).ToString("00")

            ElseIf Type = "000" Then
                Return CIntp(Value).ToString("000")

            ElseIf Type = "0000" Then
                Return CIntp(Value).ToString("0000")

            ElseIf Type = "00000" Then
                Return CIntp(Value).ToString("00000")

            ElseIf Type = "000000" Then
                Return CIntp(Value).ToString("000000")

            ElseIf Type = "0000000" Then
                Return CIntp(Value).ToString("0000000")

            ElseIf Type = "00000000" Then
                Return CIntp(Value).ToString("00000000")

            ElseIf Type = "000000000" Then
                Return CIntp(Value).ToString("000000000")

            ElseIf Type = "0000000000" Then
                Return CIntp(Value).ToString("0000000000")

            ElseIf Type = "00000000000" Then
                Return CIntp(Value).ToString("00000000000")

            ElseIf Type = "########-000" Then
                Return Strings.Left(Value, 8) & "-" & Strings.Right(Value, 3)

            ElseIf Type = "####/##/##" Then
                Return FSDate(Value)

            ElseIf Type = "#########-#" Then
                Return Strings.Left(Value, 9) & "-" & Strings.Right(Value, 1)

            ElseIf Type = "####/##/##:##:##:##" Then
                Return FSDate(Value)

            ElseIf Type.Contains(".0000") Or Type.Contains(".####") Then
                Return CDblp(Value).ToString("N4")

            ElseIf Type.Contains(".000") Or Type.Contains(".###") Then
                Return CDblp(Value).ToString("N3")

            ElseIf Type.Contains(".00") Or Type.Contains(".##") Then
                Return CDblp(Value).ToString("N2")

            ElseIf Type.Contains(".0") Or Type.Contains(".#") Then
                Return CDblp(Value).ToString("N1")

            ElseIf Type.Contains("0") Or Type.Contains("#") Then
                Return CDblp(Value).ToString("N0")

            ElseIf Type.Contains("#0") Then
                Return FormatNumber(CIntp(Value), 0)

            Else
                Return Value
            End If

        Catch ex As Exception
            Return Value
        End Try
    End Function


#End Region

#Region "Files"
    Public Function GetConnect(pos As Integer) As ConnectSQL
        GetConnect = ListConnectSql.ToList().Where(Function(x) x.ID = pos).First()
    End Function
    Public Sub SetConnect()
        Dim doc As New System.Xml.XmlDocument()
        doc.Load(App_Path & "\ConnectSQL.xml")
        Dim nodes As System.Xml.XmlNodeList = doc.DocumentElement.SelectNodes("/Table/Product")
        Dim iDefault As Integer, iD As Integer, name As String, sSER As String, dBS As String, iDS As String, pWS As String, sER As String
        Dim ListConnectSqls As New List(Of ConnectSQL)

        For Each node As System.Xml.XmlNode In nodes
            iDefault = node.SelectSingleNode("Product_default").InnerText
            iD = node.SelectSingleNode("Product_id").InnerText
            name = Decrypt(node.SelectSingleNode("Product_name").InnerText, "JunCo", "GamCo")
            sSER = Decrypt(node.SelectSingleNode("Product_sser").InnerText, "JunCo", "GamCo")
            dBS = Decrypt(node.SelectSingleNode("Product_dbs").InnerText, "JunCo", "GamCo")
            iDS = Decrypt(node.SelectSingleNode("Product_ids").InnerText, "JunCo", "GamCo")
            pWS = Decrypt(node.SelectSingleNode("Product_pws").InnerText, "JunCo", "GamCo")
            sER = Decrypt(node.SelectSingleNode("Product_ser").InnerText, "JunCo", "GamCo")
            If iDefault = 1 Then DefaultsValue = name.ToString
            ListConnectSqls.Add(New ConnectSQL(iDefault, iD, name, sSER, dBS, iDS, pWS, sER))
        Next

        ListConnectSql = ListConnectSqls
    End Sub
#End Region

    
    
    
    
    
    
    
    
    
    
    
    
    
    
    

#End Region

End Module
