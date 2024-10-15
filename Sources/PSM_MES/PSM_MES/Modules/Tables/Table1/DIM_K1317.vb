'=========================================================================================================================================================
'   TABLE : (PFK1317)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K1317

    Structure T1317_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public OrderNo As String  '			char(9)		*
        Public OrderNoSeq As String  '			char(3)		*
        Public OrderNoSno As Double  '			decimal		*
        Public seMainProcess As String  '			char(3)
        Public cdMainProcess As String  '			char(3)
        Public seSubProcess As String  '			char(3)
        Public cdSubProcess As String  '			char(3)
        Public Description As String  '			nvarchar(100)
        Public QtyDateStandard As Double  '			decimal
        Public QtyDateMin As Double  '			decimal
        Public QtyDateMax As Double  '			decimal
        Public MasterModelDateProcess As String  '			char(8)
        Public MasterPlanDateProcess As String  '			char(8)
        Public MasterSalesDateProcess As String  '			char(8)
        Public MasterDateProcess_1 As String  '			char(8)
        Public MasterDateProcess_2 As String  '			char(8)
        Public MasterDateProcess_3 As String  '			char(8)
        Public MasterDateProcess_4 As String  '			char(8)
        Public MasterDateProcess_5 As String  '			char(8)
        Public InchargePlan1 As String  '			char(8)
        Public InchargePlan2 As String  '			char(8)
        Public InchargePlan3 As String  '			char(8)
        Public InchargePlan4 As String  '			char(8)
        Public InchargePlan5 As String  '			char(8)
        Public DateInsert As String  '			char(8)
        Public InchargeInsert As String  '			char(6)
        Public DateUpdate As String  '			char(8)
        Public InchargeUpdate As String  '			char(6)
        Public RemarkPlan1 As String  '			nvarchar(50)
        Public RemarkPlan2 As String  '			nvarchar(50)
        Public RemarkPlan3 As String  '			nvarchar(50)
        Public RemarkPlan4 As String  '			nvarchar(50)
        Public RemarkPlan5 As String  '			nvarchar(50)
        '=========================================================================================================================================================
    End Structure

    Public D1317 As T1317_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK1317(ORDERNO As String, ORDERNOSEQ As String, ORDERNOSNO As Double) As Boolean
        READ_PFK1317 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK1317 "
            SQL = SQL & " WHERE K1317_OrderNo		 = '" & OrderNo & "' "
            SQL = SQL & "   AND K1317_OrderNoSeq		 = '" & OrderNoSeq & "' "
            SQL = SQL & "   AND K1317_OrderNoSno		 =  " & OrderNoSno & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D1317_CLEAR() : GoTo SKIP_READ_PFK1317

            Call K1317_MOVE(rd)
            READ_PFK1317 = True

SKIP_READ_PFK1317:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK1317", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK1317(ORDERNO As String, ORDERNOSEQ As String, ORDERNOSNO As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK1317 "
            SQL = SQL & " WHERE K1317_OrderNo		 = '" & OrderNo & "' "
            SQL = SQL & "   AND K1317_OrderNoSeq		 = '" & OrderNoSeq & "' "
            SQL = SQL & "   AND K1317_OrderNoSno		 =  " & OrderNoSno & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK1317", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK1317(z1317 As T1317_AREA) As Boolean
        WRITE_PFK1317 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z1317)

            SQL = " INSERT INTO PFK1317 "
            SQL = SQL & " ( "
            SQL = SQL & " K1317_OrderNo,"
            SQL = SQL & " K1317_OrderNoSeq,"
            SQL = SQL & " K1317_OrderNoSno,"
            SQL = SQL & " K1317_seMainProcess,"
            SQL = SQL & " K1317_cdMainProcess,"
            SQL = SQL & " K1317_seSubProcess,"
            SQL = SQL & " K1317_cdSubProcess,"
            SQL = SQL & " K1317_Description,"
            SQL = SQL & " K1317_QtyDateStandard,"
            SQL = SQL & " K1317_QtyDateMin,"
            SQL = SQL & " K1317_QtyDateMax,"
            SQL = SQL & " K1317_MasterModelDateProcess,"
            SQL = SQL & " K1317_MasterPlanDateProcess,"
            SQL = SQL & " K1317_MasterSalesDateProcess,"
            SQL = SQL & " K1317_MasterDateProcess_1,"
            SQL = SQL & " K1317_MasterDateProcess_2,"
            SQL = SQL & " K1317_MasterDateProcess_3,"
            SQL = SQL & " K1317_MasterDateProcess_4,"
            SQL = SQL & " K1317_MasterDateProcess_5,"
            SQL = SQL & " K1317_InchargePlan1,"
            SQL = SQL & " K1317_InchargePlan2,"
            SQL = SQL & " K1317_InchargePlan3,"
            SQL = SQL & " K1317_InchargePlan4,"
            SQL = SQL & " K1317_InchargePlan5,"
            SQL = SQL & " K1317_DateInsert,"
            SQL = SQL & " K1317_InchargeInsert,"
            SQL = SQL & " K1317_DateUpdate,"
            SQL = SQL & " K1317_InchargeUpdate,"
            SQL = SQL & " K1317_RemarkPlan1,"
            SQL = SQL & " K1317_RemarkPlan2,"
            SQL = SQL & " K1317_RemarkPlan3,"
            SQL = SQL & " K1317_RemarkPlan4,"
            SQL = SQL & " K1317_RemarkPlan5 "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z1317.OrderNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1317.OrderNoSeq) & "', "
            SQL = SQL & "   " & FormatSQL(z1317.OrderNoSno) & ", "
            SQL = SQL & "  N'" & FormatSQL(z1317.seMainProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1317.cdMainProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1317.seSubProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1317.cdSubProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1317.Description) & "', "
            SQL = SQL & "   " & FormatSQL(z1317.QtyDateStandard) & ", "
            SQL = SQL & "   " & FormatSQL(z1317.QtyDateMin) & ", "
            SQL = SQL & "   " & FormatSQL(z1317.QtyDateMax) & ", "
            SQL = SQL & "  N'" & FormatSQL(z1317.MasterModelDateProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1317.MasterPlanDateProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1317.MasterSalesDateProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1317.MasterDateProcess_1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1317.MasterDateProcess_2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1317.MasterDateProcess_3) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1317.MasterDateProcess_4) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1317.MasterDateProcess_5) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1317.InchargePlan1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1317.InchargePlan2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1317.InchargePlan3) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1317.InchargePlan4) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1317.InchargePlan5) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1317.DateInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1317.InchargeInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1317.DateUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1317.InchargeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1317.RemarkPlan1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1317.RemarkPlan2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1317.RemarkPlan3) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1317.RemarkPlan4) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1317.RemarkPlan5) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK1317 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK1317", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK1317(z1317 As T1317_AREA) As Boolean
        REWRITE_PFK1317 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z1317)

            SQL = " UPDATE PFK1317 SET "
            SQL = SQL & "    K1317_seMainProcess      = N'" & FormatSQL(z1317.seMainProcess) & "', "
            SQL = SQL & "    K1317_cdMainProcess      = N'" & FormatSQL(z1317.cdMainProcess) & "', "
            SQL = SQL & "    K1317_seSubProcess      = N'" & FormatSQL(z1317.seSubProcess) & "', "
            SQL = SQL & "    K1317_cdSubProcess      = N'" & FormatSQL(z1317.cdSubProcess) & "', "
            SQL = SQL & "    K1317_Description      = N'" & FormatSQL(z1317.Description) & "', "
            SQL = SQL & "    K1317_QtyDateStandard      =  " & FormatSQL(z1317.QtyDateStandard) & ", "
            SQL = SQL & "    K1317_QtyDateMin      =  " & FormatSQL(z1317.QtyDateMin) & ", "
            SQL = SQL & "    K1317_QtyDateMax      =  " & FormatSQL(z1317.QtyDateMax) & ", "
            SQL = SQL & "    K1317_MasterModelDateProcess      = N'" & FormatSQL(z1317.MasterModelDateProcess) & "', "
            SQL = SQL & "    K1317_MasterPlanDateProcess      = N'" & FormatSQL(z1317.MasterPlanDateProcess) & "', "
            SQL = SQL & "    K1317_MasterSalesDateProcess      = N'" & FormatSQL(z1317.MasterSalesDateProcess) & "', "
            SQL = SQL & "    K1317_MasterDateProcess_1      = N'" & FormatSQL(z1317.MasterDateProcess_1) & "', "
            SQL = SQL & "    K1317_MasterDateProcess_2      = N'" & FormatSQL(z1317.MasterDateProcess_2) & "', "
            SQL = SQL & "    K1317_MasterDateProcess_3      = N'" & FormatSQL(z1317.MasterDateProcess_3) & "', "
            SQL = SQL & "    K1317_MasterDateProcess_4      = N'" & FormatSQL(z1317.MasterDateProcess_4) & "', "
            SQL = SQL & "    K1317_MasterDateProcess_5      = N'" & FormatSQL(z1317.MasterDateProcess_5) & "', "
            SQL = SQL & "    K1317_InchargePlan1      = N'" & FormatSQL(z1317.InchargePlan1) & "', "
            SQL = SQL & "    K1317_InchargePlan2      = N'" & FormatSQL(z1317.InchargePlan2) & "', "
            SQL = SQL & "    K1317_InchargePlan3      = N'" & FormatSQL(z1317.InchargePlan3) & "', "
            SQL = SQL & "    K1317_InchargePlan4      = N'" & FormatSQL(z1317.InchargePlan4) & "', "
            SQL = SQL & "    K1317_InchargePlan5      = N'" & FormatSQL(z1317.InchargePlan5) & "', "
            SQL = SQL & "    K1317_DateInsert      = N'" & FormatSQL(z1317.DateInsert) & "', "
            SQL = SQL & "    K1317_InchargeInsert      = N'" & FormatSQL(z1317.InchargeInsert) & "', "
            SQL = SQL & "    K1317_DateUpdate      = N'" & FormatSQL(z1317.DateUpdate) & "', "
            SQL = SQL & "    K1317_InchargeUpdate      = N'" & FormatSQL(z1317.InchargeUpdate) & "', "
            SQL = SQL & "    K1317_RemarkPlan1      = N'" & FormatSQL(z1317.RemarkPlan1) & "', "
            SQL = SQL & "    K1317_RemarkPlan2      = N'" & FormatSQL(z1317.RemarkPlan2) & "', "
            SQL = SQL & "    K1317_RemarkPlan3      = N'" & FormatSQL(z1317.RemarkPlan3) & "', "
            SQL = SQL & "    K1317_RemarkPlan4      = N'" & FormatSQL(z1317.RemarkPlan4) & "', "
            SQL = SQL & "    K1317_RemarkPlan5      = N'" & FormatSQL(z1317.RemarkPlan5) & "'  "
            SQL = SQL & " WHERE K1317_OrderNo		 = '" & z1317.OrderNo & "' "
            SQL = SQL & "   AND K1317_OrderNoSeq		 = '" & z1317.OrderNoSeq & "' "
            SQL = SQL & "   AND K1317_OrderNoSno		 =  " & z1317.OrderNoSno & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK1317 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK1317", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK1317(z1317 As T1317_AREA) As Boolean
        DELETE_PFK1317 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK1317 "
            SQL = SQL & " WHERE K1317_OrderNo		 = '" & z1317.OrderNo & "' "
            SQL = SQL & "   AND K1317_OrderNoSeq		 = '" & z1317.OrderNoSeq & "' "
            SQL = SQL & "   AND K1317_OrderNoSno		 =  " & z1317.OrderNoSno & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK1317 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK1317", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D1317_CLEAR()
        Try

            D1317.OrderNo = ""
            D1317.OrderNoSeq = ""
            D1317.OrderNoSno = 0
            D1317.seMainProcess = ""
            D1317.cdMainProcess = ""
            D1317.seSubProcess = ""
            D1317.cdSubProcess = ""
            D1317.Description = ""
            D1317.QtyDateStandard = 0
            D1317.QtyDateMin = 0
            D1317.QtyDateMax = 0
            D1317.MasterModelDateProcess = ""
            D1317.MasterPlanDateProcess = ""
            D1317.MasterSalesDateProcess = ""
            D1317.MasterDateProcess_1 = ""
            D1317.MasterDateProcess_2 = ""
            D1317.MasterDateProcess_3 = ""
            D1317.MasterDateProcess_4 = ""
            D1317.MasterDateProcess_5 = ""
            D1317.InchargePlan1 = ""
            D1317.InchargePlan2 = ""
            D1317.InchargePlan3 = ""
            D1317.InchargePlan4 = ""
            D1317.InchargePlan5 = ""
            D1317.DateInsert = ""
            D1317.InchargeInsert = ""
            D1317.DateUpdate = ""
            D1317.InchargeUpdate = ""
            D1317.RemarkPlan1 = ""
            D1317.RemarkPlan2 = ""
            D1317.RemarkPlan3 = ""
            D1317.RemarkPlan4 = ""
            D1317.RemarkPlan5 = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D1317_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x1317 As T1317_AREA)
        Try

            x1317.OrderNo = trim$(x1317.OrderNo)
            x1317.OrderNoSeq = trim$(x1317.OrderNoSeq)
            x1317.OrderNoSno = trim$(x1317.OrderNoSno)
            x1317.seMainProcess = trim$(x1317.seMainProcess)
            x1317.cdMainProcess = trim$(x1317.cdMainProcess)
            x1317.seSubProcess = trim$(x1317.seSubProcess)
            x1317.cdSubProcess = trim$(x1317.cdSubProcess)
            x1317.Description = trim$(x1317.Description)
            x1317.QtyDateStandard = trim$(x1317.QtyDateStandard)
            x1317.QtyDateMin = trim$(x1317.QtyDateMin)
            x1317.QtyDateMax = trim$(x1317.QtyDateMax)
            x1317.MasterModelDateProcess = trim$(x1317.MasterModelDateProcess)
            x1317.MasterPlanDateProcess = trim$(x1317.MasterPlanDateProcess)
            x1317.MasterSalesDateProcess = trim$(x1317.MasterSalesDateProcess)
            x1317.MasterDateProcess_1 = trim$(x1317.MasterDateProcess_1)
            x1317.MasterDateProcess_2 = trim$(x1317.MasterDateProcess_2)
            x1317.MasterDateProcess_3 = trim$(x1317.MasterDateProcess_3)
            x1317.MasterDateProcess_4 = trim$(x1317.MasterDateProcess_4)
            x1317.MasterDateProcess_5 = trim$(x1317.MasterDateProcess_5)
            x1317.InchargePlan1 = trim$(x1317.InchargePlan1)
            x1317.InchargePlan2 = trim$(x1317.InchargePlan2)
            x1317.InchargePlan3 = trim$(x1317.InchargePlan3)
            x1317.InchargePlan4 = trim$(x1317.InchargePlan4)
            x1317.InchargePlan5 = trim$(x1317.InchargePlan5)
            x1317.DateInsert = trim$(x1317.DateInsert)
            x1317.InchargeInsert = trim$(x1317.InchargeInsert)
            x1317.DateUpdate = trim$(x1317.DateUpdate)
            x1317.InchargeUpdate = trim$(x1317.InchargeUpdate)
            x1317.RemarkPlan1 = trim$(x1317.RemarkPlan1)
            x1317.RemarkPlan2 = trim$(x1317.RemarkPlan2)
            x1317.RemarkPlan3 = trim$(x1317.RemarkPlan3)
            x1317.RemarkPlan4 = trim$(x1317.RemarkPlan4)
            x1317.RemarkPlan5 = trim$(x1317.RemarkPlan5)

            If trim$(x1317.OrderNo) = "" Then x1317.OrderNo = Space(1)
            If trim$(x1317.OrderNoSeq) = "" Then x1317.OrderNoSeq = Space(1)
            If trim$(x1317.OrderNoSno) = "" Then x1317.OrderNoSno = 0
            If trim$(x1317.seMainProcess) = "" Then x1317.seMainProcess = Space(1)
            If trim$(x1317.cdMainProcess) = "" Then x1317.cdMainProcess = Space(1)
            If trim$(x1317.seSubProcess) = "" Then x1317.seSubProcess = Space(1)
            If trim$(x1317.cdSubProcess) = "" Then x1317.cdSubProcess = Space(1)
            If trim$(x1317.Description) = "" Then x1317.Description = Space(1)
            If trim$(x1317.QtyDateStandard) = "" Then x1317.QtyDateStandard = 0
            If trim$(x1317.QtyDateMin) = "" Then x1317.QtyDateMin = 0
            If trim$(x1317.QtyDateMax) = "" Then x1317.QtyDateMax = 0
            If trim$(x1317.MasterModelDateProcess) = "" Then x1317.MasterModelDateProcess = Space(1)
            If trim$(x1317.MasterPlanDateProcess) = "" Then x1317.MasterPlanDateProcess = Space(1)
            If trim$(x1317.MasterSalesDateProcess) = "" Then x1317.MasterSalesDateProcess = Space(1)
            If trim$(x1317.MasterDateProcess_1) = "" Then x1317.MasterDateProcess_1 = Space(1)
            If trim$(x1317.MasterDateProcess_2) = "" Then x1317.MasterDateProcess_2 = Space(1)
            If trim$(x1317.MasterDateProcess_3) = "" Then x1317.MasterDateProcess_3 = Space(1)
            If trim$(x1317.MasterDateProcess_4) = "" Then x1317.MasterDateProcess_4 = Space(1)
            If trim$(x1317.MasterDateProcess_5) = "" Then x1317.MasterDateProcess_5 = Space(1)
            If trim$(x1317.InchargePlan1) = "" Then x1317.InchargePlan1 = Space(1)
            If trim$(x1317.InchargePlan2) = "" Then x1317.InchargePlan2 = Space(1)
            If trim$(x1317.InchargePlan3) = "" Then x1317.InchargePlan3 = Space(1)
            If trim$(x1317.InchargePlan4) = "" Then x1317.InchargePlan4 = Space(1)
            If trim$(x1317.InchargePlan5) = "" Then x1317.InchargePlan5 = Space(1)
            If trim$(x1317.DateInsert) = "" Then x1317.DateInsert = Space(1)
            If trim$(x1317.InchargeInsert) = "" Then x1317.InchargeInsert = Space(1)
            If trim$(x1317.DateUpdate) = "" Then x1317.DateUpdate = Space(1)
            If trim$(x1317.InchargeUpdate) = "" Then x1317.InchargeUpdate = Space(1)
            If trim$(x1317.RemarkPlan1) = "" Then x1317.RemarkPlan1 = Space(1)
            If trim$(x1317.RemarkPlan2) = "" Then x1317.RemarkPlan2 = Space(1)
            If trim$(x1317.RemarkPlan3) = "" Then x1317.RemarkPlan3 = Space(1)
            If trim$(x1317.RemarkPlan4) = "" Then x1317.RemarkPlan4 = Space(1)
            If trim$(x1317.RemarkPlan5) = "" Then x1317.RemarkPlan5 = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K1317_MOVE(rs1317 As SqlClient.SqlDataReader)
        Try

            Call D1317_CLEAR()

            If IsdbNull(rs1317!K1317_OrderNo) = False Then D1317.OrderNo = Trim$(rs1317!K1317_OrderNo)
            If IsdbNull(rs1317!K1317_OrderNoSeq) = False Then D1317.OrderNoSeq = Trim$(rs1317!K1317_OrderNoSeq)
            If IsdbNull(rs1317!K1317_OrderNoSno) = False Then D1317.OrderNoSno = Trim$(rs1317!K1317_OrderNoSno)
            If IsdbNull(rs1317!K1317_seMainProcess) = False Then D1317.seMainProcess = Trim$(rs1317!K1317_seMainProcess)
            If IsdbNull(rs1317!K1317_cdMainProcess) = False Then D1317.cdMainProcess = Trim$(rs1317!K1317_cdMainProcess)
            If IsdbNull(rs1317!K1317_seSubProcess) = False Then D1317.seSubProcess = Trim$(rs1317!K1317_seSubProcess)
            If IsdbNull(rs1317!K1317_cdSubProcess) = False Then D1317.cdSubProcess = Trim$(rs1317!K1317_cdSubProcess)
            If IsdbNull(rs1317!K1317_Description) = False Then D1317.Description = Trim$(rs1317!K1317_Description)
            If IsdbNull(rs1317!K1317_QtyDateStandard) = False Then D1317.QtyDateStandard = Trim$(rs1317!K1317_QtyDateStandard)
            If IsdbNull(rs1317!K1317_QtyDateMin) = False Then D1317.QtyDateMin = Trim$(rs1317!K1317_QtyDateMin)
            If IsdbNull(rs1317!K1317_QtyDateMax) = False Then D1317.QtyDateMax = Trim$(rs1317!K1317_QtyDateMax)
            If IsdbNull(rs1317!K1317_MasterModelDateProcess) = False Then D1317.MasterModelDateProcess = Trim$(rs1317!K1317_MasterModelDateProcess)
            If IsdbNull(rs1317!K1317_MasterPlanDateProcess) = False Then D1317.MasterPlanDateProcess = Trim$(rs1317!K1317_MasterPlanDateProcess)
            If IsdbNull(rs1317!K1317_MasterSalesDateProcess) = False Then D1317.MasterSalesDateProcess = Trim$(rs1317!K1317_MasterSalesDateProcess)
            If IsdbNull(rs1317!K1317_MasterDateProcess_1) = False Then D1317.MasterDateProcess_1 = Trim$(rs1317!K1317_MasterDateProcess_1)
            If IsdbNull(rs1317!K1317_MasterDateProcess_2) = False Then D1317.MasterDateProcess_2 = Trim$(rs1317!K1317_MasterDateProcess_2)
            If IsdbNull(rs1317!K1317_MasterDateProcess_3) = False Then D1317.MasterDateProcess_3 = Trim$(rs1317!K1317_MasterDateProcess_3)
            If IsdbNull(rs1317!K1317_MasterDateProcess_4) = False Then D1317.MasterDateProcess_4 = Trim$(rs1317!K1317_MasterDateProcess_4)
            If IsdbNull(rs1317!K1317_MasterDateProcess_5) = False Then D1317.MasterDateProcess_5 = Trim$(rs1317!K1317_MasterDateProcess_5)
            If IsdbNull(rs1317!K1317_InchargePlan1) = False Then D1317.InchargePlan1 = Trim$(rs1317!K1317_InchargePlan1)
            If IsdbNull(rs1317!K1317_InchargePlan2) = False Then D1317.InchargePlan2 = Trim$(rs1317!K1317_InchargePlan2)
            If IsdbNull(rs1317!K1317_InchargePlan3) = False Then D1317.InchargePlan3 = Trim$(rs1317!K1317_InchargePlan3)
            If IsdbNull(rs1317!K1317_InchargePlan4) = False Then D1317.InchargePlan4 = Trim$(rs1317!K1317_InchargePlan4)
            If IsdbNull(rs1317!K1317_InchargePlan5) = False Then D1317.InchargePlan5 = Trim$(rs1317!K1317_InchargePlan5)
            If IsdbNull(rs1317!K1317_DateInsert) = False Then D1317.DateInsert = Trim$(rs1317!K1317_DateInsert)
            If IsdbNull(rs1317!K1317_InchargeInsert) = False Then D1317.InchargeInsert = Trim$(rs1317!K1317_InchargeInsert)
            If IsdbNull(rs1317!K1317_DateUpdate) = False Then D1317.DateUpdate = Trim$(rs1317!K1317_DateUpdate)
            If IsdbNull(rs1317!K1317_InchargeUpdate) = False Then D1317.InchargeUpdate = Trim$(rs1317!K1317_InchargeUpdate)
            If IsdbNull(rs1317!K1317_RemarkPlan1) = False Then D1317.RemarkPlan1 = Trim$(rs1317!K1317_RemarkPlan1)
            If IsdbNull(rs1317!K1317_RemarkPlan2) = False Then D1317.RemarkPlan2 = Trim$(rs1317!K1317_RemarkPlan2)
            If IsdbNull(rs1317!K1317_RemarkPlan3) = False Then D1317.RemarkPlan3 = Trim$(rs1317!K1317_RemarkPlan3)
            If IsdbNull(rs1317!K1317_RemarkPlan4) = False Then D1317.RemarkPlan4 = Trim$(rs1317!K1317_RemarkPlan4)
            If IsdbNull(rs1317!K1317_RemarkPlan5) = False Then D1317.RemarkPlan5 = Trim$(rs1317!K1317_RemarkPlan5)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K1317_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K1317_MOVE(rs1317 As DataRow)
        Try

            Call D1317_CLEAR()

            If IsdbNull(rs1317!K1317_OrderNo) = False Then D1317.OrderNo = Trim$(rs1317!K1317_OrderNo)
            If IsdbNull(rs1317!K1317_OrderNoSeq) = False Then D1317.OrderNoSeq = Trim$(rs1317!K1317_OrderNoSeq)
            If IsdbNull(rs1317!K1317_OrderNoSno) = False Then D1317.OrderNoSno = Trim$(rs1317!K1317_OrderNoSno)
            If IsdbNull(rs1317!K1317_seMainProcess) = False Then D1317.seMainProcess = Trim$(rs1317!K1317_seMainProcess)
            If IsdbNull(rs1317!K1317_cdMainProcess) = False Then D1317.cdMainProcess = Trim$(rs1317!K1317_cdMainProcess)
            If IsdbNull(rs1317!K1317_seSubProcess) = False Then D1317.seSubProcess = Trim$(rs1317!K1317_seSubProcess)
            If IsdbNull(rs1317!K1317_cdSubProcess) = False Then D1317.cdSubProcess = Trim$(rs1317!K1317_cdSubProcess)
            If IsdbNull(rs1317!K1317_Description) = False Then D1317.Description = Trim$(rs1317!K1317_Description)
            If IsdbNull(rs1317!K1317_QtyDateStandard) = False Then D1317.QtyDateStandard = Trim$(rs1317!K1317_QtyDateStandard)
            If IsdbNull(rs1317!K1317_QtyDateMin) = False Then D1317.QtyDateMin = Trim$(rs1317!K1317_QtyDateMin)
            If IsdbNull(rs1317!K1317_QtyDateMax) = False Then D1317.QtyDateMax = Trim$(rs1317!K1317_QtyDateMax)
            If IsdbNull(rs1317!K1317_MasterModelDateProcess) = False Then D1317.MasterModelDateProcess = Trim$(rs1317!K1317_MasterModelDateProcess)
            If IsdbNull(rs1317!K1317_MasterPlanDateProcess) = False Then D1317.MasterPlanDateProcess = Trim$(rs1317!K1317_MasterPlanDateProcess)
            If IsdbNull(rs1317!K1317_MasterSalesDateProcess) = False Then D1317.MasterSalesDateProcess = Trim$(rs1317!K1317_MasterSalesDateProcess)
            If IsdbNull(rs1317!K1317_MasterDateProcess_1) = False Then D1317.MasterDateProcess_1 = Trim$(rs1317!K1317_MasterDateProcess_1)
            If IsdbNull(rs1317!K1317_MasterDateProcess_2) = False Then D1317.MasterDateProcess_2 = Trim$(rs1317!K1317_MasterDateProcess_2)
            If IsdbNull(rs1317!K1317_MasterDateProcess_3) = False Then D1317.MasterDateProcess_3 = Trim$(rs1317!K1317_MasterDateProcess_3)
            If IsdbNull(rs1317!K1317_MasterDateProcess_4) = False Then D1317.MasterDateProcess_4 = Trim$(rs1317!K1317_MasterDateProcess_4)
            If IsdbNull(rs1317!K1317_MasterDateProcess_5) = False Then D1317.MasterDateProcess_5 = Trim$(rs1317!K1317_MasterDateProcess_5)
            If IsdbNull(rs1317!K1317_InchargePlan1) = False Then D1317.InchargePlan1 = Trim$(rs1317!K1317_InchargePlan1)
            If IsdbNull(rs1317!K1317_InchargePlan2) = False Then D1317.InchargePlan2 = Trim$(rs1317!K1317_InchargePlan2)
            If IsdbNull(rs1317!K1317_InchargePlan3) = False Then D1317.InchargePlan3 = Trim$(rs1317!K1317_InchargePlan3)
            If IsdbNull(rs1317!K1317_InchargePlan4) = False Then D1317.InchargePlan4 = Trim$(rs1317!K1317_InchargePlan4)
            If IsdbNull(rs1317!K1317_InchargePlan5) = False Then D1317.InchargePlan5 = Trim$(rs1317!K1317_InchargePlan5)
            If IsdbNull(rs1317!K1317_DateInsert) = False Then D1317.DateInsert = Trim$(rs1317!K1317_DateInsert)
            If IsdbNull(rs1317!K1317_InchargeInsert) = False Then D1317.InchargeInsert = Trim$(rs1317!K1317_InchargeInsert)
            If IsdbNull(rs1317!K1317_DateUpdate) = False Then D1317.DateUpdate = Trim$(rs1317!K1317_DateUpdate)
            If IsdbNull(rs1317!K1317_InchargeUpdate) = False Then D1317.InchargeUpdate = Trim$(rs1317!K1317_InchargeUpdate)
            If IsdbNull(rs1317!K1317_RemarkPlan1) = False Then D1317.RemarkPlan1 = Trim$(rs1317!K1317_RemarkPlan1)
            If IsdbNull(rs1317!K1317_RemarkPlan2) = False Then D1317.RemarkPlan2 = Trim$(rs1317!K1317_RemarkPlan2)
            If IsdbNull(rs1317!K1317_RemarkPlan3) = False Then D1317.RemarkPlan3 = Trim$(rs1317!K1317_RemarkPlan3)
            If IsdbNull(rs1317!K1317_RemarkPlan4) = False Then D1317.RemarkPlan4 = Trim$(rs1317!K1317_RemarkPlan4)
            If IsdbNull(rs1317!K1317_RemarkPlan5) = False Then D1317.RemarkPlan5 = Trim$(rs1317!K1317_RemarkPlan5)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K1317_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K1317_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z1317 As T1317_AREA, ORDERNO As String, ORDERNOSEQ As String, ORDERNOSNO As Double) As Boolean

        K1317_MOVE = False

        Try
            If READ_PFK1317(ORDERNO, ORDERNOSEQ, ORDERNOSNO) = True Then
                z1317 = D1317
                K1317_MOVE = True
            Else
                z1317 = Nothing
            End If

            If getColumIndex(spr, "OrderNo") > -1 Then z1317.OrderNo = getDataM(spr, getColumIndex(spr, "OrderNo"), xRow)
            If getColumIndex(spr, "OrderNoSeq") > -1 Then z1317.OrderNoSeq = getDataM(spr, getColumIndex(spr, "OrderNoSeq"), xRow)
            If getColumIndex(spr, "OrderNoSno") > -1 Then z1317.OrderNoSno = getDataM(spr, getColumIndex(spr, "OrderNoSno"), xRow)
            If getColumIndex(spr, "seMainProcess") > -1 Then z1317.seMainProcess = getDataM(spr, getColumIndex(spr, "seMainProcess"), xRow)
            If getColumIndex(spr, "cdMainProcess") > -1 Then z1317.cdMainProcess = getDataM(spr, getColumIndex(spr, "cdMainProcess"), xRow)
            If getColumIndex(spr, "seSubProcess") > -1 Then z1317.seSubProcess = getDataM(spr, getColumIndex(spr, "seSubProcess"), xRow)
            If getColumIndex(spr, "cdSubProcess") > -1 Then z1317.cdSubProcess = getDataM(spr, getColumIndex(spr, "cdSubProcess"), xRow)
            If getColumIndex(spr, "Description") > -1 Then z1317.Description = getDataM(spr, getColumIndex(spr, "Description"), xRow)
            If getColumIndex(spr, "QtyDateStandard") > -1 Then z1317.QtyDateStandard = getDataM(spr, getColumIndex(spr, "QtyDateStandard"), xRow)
            If getColumIndex(spr, "QtyDateMin") > -1 Then z1317.QtyDateMin = getDataM(spr, getColumIndex(spr, "QtyDateMin"), xRow)
            If getColumIndex(spr, "QtyDateMax") > -1 Then z1317.QtyDateMax = getDataM(spr, getColumIndex(spr, "QtyDateMax"), xRow)
            If getColumIndex(spr, "MasterModelDateProcess") > -1 Then z1317.MasterModelDateProcess = getDataM(spr, getColumIndex(spr, "MasterModelDateProcess"), xRow)
            If getColumIndex(spr, "MasterPlanDateProcess") > -1 Then z1317.MasterPlanDateProcess = getDataM(spr, getColumIndex(spr, "MasterPlanDateProcess"), xRow)
            If getColumIndex(spr, "MasterSalesDateProcess") > -1 Then z1317.MasterSalesDateProcess = getDataM(spr, getColumIndex(spr, "MasterSalesDateProcess"), xRow)
            If getColumIndex(spr, "MasterDateProcess_1") > -1 Then z1317.MasterDateProcess_1 = getDataM(spr, getColumIndex(spr, "MasterDateProcess_1"), xRow)
            If getColumIndex(spr, "MasterDateProcess_2") > -1 Then z1317.MasterDateProcess_2 = getDataM(spr, getColumIndex(spr, "MasterDateProcess_2"), xRow)
            If getColumIndex(spr, "MasterDateProcess_3") > -1 Then z1317.MasterDateProcess_3 = getDataM(spr, getColumIndex(spr, "MasterDateProcess_3"), xRow)
            If getColumIndex(spr, "MasterDateProcess_4") > -1 Then z1317.MasterDateProcess_4 = getDataM(spr, getColumIndex(spr, "MasterDateProcess_4"), xRow)
            If getColumIndex(spr, "MasterDateProcess_5") > -1 Then z1317.MasterDateProcess_5 = getDataM(spr, getColumIndex(spr, "MasterDateProcess_5"), xRow)
            If getColumIndex(spr, "InchargePlan1") > -1 Then z1317.InchargePlan1 = getDataM(spr, getColumIndex(spr, "InchargePlan1"), xRow)
            If getColumIndex(spr, "InchargePlan2") > -1 Then z1317.InchargePlan2 = getDataM(spr, getColumIndex(spr, "InchargePlan2"), xRow)
            If getColumIndex(spr, "InchargePlan3") > -1 Then z1317.InchargePlan3 = getDataM(spr, getColumIndex(spr, "InchargePlan3"), xRow)
            If getColumIndex(spr, "InchargePlan4") > -1 Then z1317.InchargePlan4 = getDataM(spr, getColumIndex(spr, "InchargePlan4"), xRow)
            If getColumIndex(spr, "InchargePlan5") > -1 Then z1317.InchargePlan5 = getDataM(spr, getColumIndex(spr, "InchargePlan5"), xRow)
            If getColumIndex(spr, "DateInsert") > -1 Then z1317.DateInsert = getDataM(spr, getColumIndex(spr, "DateInsert"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z1317.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "DateUpdate") > -1 Then z1317.DateUpdate = getDataM(spr, getColumIndex(spr, "DateUpdate"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z1317.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)
            If getColumIndex(spr, "RemarkPlan1") > -1 Then z1317.RemarkPlan1 = getDataM(spr, getColumIndex(spr, "RemarkPlan1"), xRow)
            If getColumIndex(spr, "RemarkPlan2") > -1 Then z1317.RemarkPlan2 = getDataM(spr, getColumIndex(spr, "RemarkPlan2"), xRow)
            If getColumIndex(spr, "RemarkPlan3") > -1 Then z1317.RemarkPlan3 = getDataM(spr, getColumIndex(spr, "RemarkPlan3"), xRow)
            If getColumIndex(spr, "RemarkPlan4") > -1 Then z1317.RemarkPlan4 = getDataM(spr, getColumIndex(spr, "RemarkPlan4"), xRow)
            If getColumIndex(spr, "RemarkPlan5") > -1 Then z1317.RemarkPlan5 = getDataM(spr, getColumIndex(spr, "RemarkPlan5"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K1317_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K1317_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z1317 As T1317_AREA, CheckClear As Boolean, ORDERNO As String, ORDERNOSEQ As String, ORDERNOSNO As Double) As Boolean

        K1317_MOVE = False

        Try
            If READ_PFK1317(ORDERNO, ORDERNOSEQ, ORDERNOSNO) = True Then
                z1317 = D1317
                K1317_MOVE = True
            Else
                If CheckClear = True Then z1317 = Nothing
            End If

            If getColumIndex(spr, "OrderNo") > -1 Then z1317.OrderNo = getDataM(spr, getColumIndex(spr, "OrderNo"), xRow)
            If getColumIndex(spr, "OrderNoSeq") > -1 Then z1317.OrderNoSeq = getDataM(spr, getColumIndex(spr, "OrderNoSeq"), xRow)
            If getColumIndex(spr, "OrderNoSno") > -1 Then z1317.OrderNoSno = getDataM(spr, getColumIndex(spr, "OrderNoSno"), xRow)
            If getColumIndex(spr, "seMainProcess") > -1 Then z1317.seMainProcess = getDataM(spr, getColumIndex(spr, "seMainProcess"), xRow)
            If getColumIndex(spr, "cdMainProcess") > -1 Then z1317.cdMainProcess = getDataM(spr, getColumIndex(spr, "cdMainProcess"), xRow)
            If getColumIndex(spr, "seSubProcess") > -1 Then z1317.seSubProcess = getDataM(spr, getColumIndex(spr, "seSubProcess"), xRow)
            If getColumIndex(spr, "cdSubProcess") > -1 Then z1317.cdSubProcess = getDataM(spr, getColumIndex(spr, "cdSubProcess"), xRow)
            If getColumIndex(spr, "Description") > -1 Then z1317.Description = getDataM(spr, getColumIndex(spr, "Description"), xRow)
            If getColumIndex(spr, "QtyDateStandard") > -1 Then z1317.QtyDateStandard = getDataM(spr, getColumIndex(spr, "QtyDateStandard"), xRow)
            If getColumIndex(spr, "QtyDateMin") > -1 Then z1317.QtyDateMin = getDataM(spr, getColumIndex(spr, "QtyDateMin"), xRow)
            If getColumIndex(spr, "QtyDateMax") > -1 Then z1317.QtyDateMax = getDataM(spr, getColumIndex(spr, "QtyDateMax"), xRow)
            If getColumIndex(spr, "MasterModelDateProcess") > -1 Then z1317.MasterModelDateProcess = getDataM(spr, getColumIndex(spr, "MasterModelDateProcess"), xRow)
            If getColumIndex(spr, "MasterPlanDateProcess") > -1 Then z1317.MasterPlanDateProcess = getDataM(spr, getColumIndex(spr, "MasterPlanDateProcess"), xRow)
            If getColumIndex(spr, "MasterSalesDateProcess") > -1 Then z1317.MasterSalesDateProcess = getDataM(spr, getColumIndex(spr, "MasterSalesDateProcess"), xRow)
            If getColumIndex(spr, "MasterDateProcess_1") > -1 Then z1317.MasterDateProcess_1 = getDataM(spr, getColumIndex(spr, "MasterDateProcess_1"), xRow)
            If getColumIndex(spr, "MasterDateProcess_2") > -1 Then z1317.MasterDateProcess_2 = getDataM(spr, getColumIndex(spr, "MasterDateProcess_2"), xRow)
            If getColumIndex(spr, "MasterDateProcess_3") > -1 Then z1317.MasterDateProcess_3 = getDataM(spr, getColumIndex(spr, "MasterDateProcess_3"), xRow)
            If getColumIndex(spr, "MasterDateProcess_4") > -1 Then z1317.MasterDateProcess_4 = getDataM(spr, getColumIndex(spr, "MasterDateProcess_4"), xRow)
            If getColumIndex(spr, "MasterDateProcess_5") > -1 Then z1317.MasterDateProcess_5 = getDataM(spr, getColumIndex(spr, "MasterDateProcess_5"), xRow)
            If getColumIndex(spr, "InchargePlan1") > -1 Then z1317.InchargePlan1 = getDataM(spr, getColumIndex(spr, "InchargePlan1"), xRow)
            If getColumIndex(spr, "InchargePlan2") > -1 Then z1317.InchargePlan2 = getDataM(spr, getColumIndex(spr, "InchargePlan2"), xRow)
            If getColumIndex(spr, "InchargePlan3") > -1 Then z1317.InchargePlan3 = getDataM(spr, getColumIndex(spr, "InchargePlan3"), xRow)
            If getColumIndex(spr, "InchargePlan4") > -1 Then z1317.InchargePlan4 = getDataM(spr, getColumIndex(spr, "InchargePlan4"), xRow)
            If getColumIndex(spr, "InchargePlan5") > -1 Then z1317.InchargePlan5 = getDataM(spr, getColumIndex(spr, "InchargePlan5"), xRow)
            If getColumIndex(spr, "DateInsert") > -1 Then z1317.DateInsert = getDataM(spr, getColumIndex(spr, "DateInsert"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z1317.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "DateUpdate") > -1 Then z1317.DateUpdate = getDataM(spr, getColumIndex(spr, "DateUpdate"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z1317.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)
            If getColumIndex(spr, "RemarkPlan1") > -1 Then z1317.RemarkPlan1 = getDataM(spr, getColumIndex(spr, "RemarkPlan1"), xRow)
            If getColumIndex(spr, "RemarkPlan2") > -1 Then z1317.RemarkPlan2 = getDataM(spr, getColumIndex(spr, "RemarkPlan2"), xRow)
            If getColumIndex(spr, "RemarkPlan3") > -1 Then z1317.RemarkPlan3 = getDataM(spr, getColumIndex(spr, "RemarkPlan3"), xRow)
            If getColumIndex(spr, "RemarkPlan4") > -1 Then z1317.RemarkPlan4 = getDataM(spr, getColumIndex(spr, "RemarkPlan4"), xRow)
            If getColumIndex(spr, "RemarkPlan5") > -1 Then z1317.RemarkPlan5 = getDataM(spr, getColumIndex(spr, "RemarkPlan5"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K1317_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K1317_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z1317 As T1317_AREA, Job As String, ORDERNO As String, ORDERNOSEQ As String, ORDERNOSNO As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K1317_MOVE = False

        Try
            If READ_PFK1317(ORDERNO, ORDERNOSEQ, ORDERNOSNO) = True Then
                z1317 = D1317
                K1317_MOVE = True
            Else
                z1317 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1317")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "ORDERNO" : z1317.OrderNo = Children(i).Code
                                Case "ORDERNOSEQ" : z1317.OrderNoSeq = Children(i).Code
                                Case "ORDERNOSNO" : z1317.OrderNoSno = Children(i).Code
                                Case "SEMAINPROCESS" : z1317.seMainProcess = Children(i).Code
                                Case "CDMAINPROCESS" : z1317.cdMainProcess = Children(i).Code
                                Case "SESUBPROCESS" : z1317.seSubProcess = Children(i).Code
                                Case "CDSUBPROCESS" : z1317.cdSubProcess = Children(i).Code
                                Case "DESCRIPTION" : z1317.Description = Children(i).Code
                                Case "QTYDATESTANDARD" : z1317.QtyDateStandard = Children(i).Code
                                Case "QTYDATEMIN" : z1317.QtyDateMin = Children(i).Code
                                Case "QTYDATEMAX" : z1317.QtyDateMax = Children(i).Code
                                Case "MASTERMODELDATEPROCESS" : z1317.MasterModelDateProcess = Children(i).Code
                                Case "MASTERPLANDATEPROCESS" : z1317.MasterPlanDateProcess = Children(i).Code
                                Case "MASTERSALESDATEPROCESS" : z1317.MasterSalesDateProcess = Children(i).Code
                                Case "MASTERDATEPROCESS_1" : z1317.MasterDateProcess_1 = Children(i).Code
                                Case "MASTERDATEPROCESS_2" : z1317.MasterDateProcess_2 = Children(i).Code
                                Case "MASTERDATEPROCESS_3" : z1317.MasterDateProcess_3 = Children(i).Code
                                Case "MASTERDATEPROCESS_4" : z1317.MasterDateProcess_4 = Children(i).Code
                                Case "MASTERDATEPROCESS_5" : z1317.MasterDateProcess_5 = Children(i).Code
                                Case "INCHARGEPLAN1" : z1317.InchargePlan1 = Children(i).Code
                                Case "INCHARGEPLAN2" : z1317.InchargePlan2 = Children(i).Code
                                Case "INCHARGEPLAN3" : z1317.InchargePlan3 = Children(i).Code
                                Case "INCHARGEPLAN4" : z1317.InchargePlan4 = Children(i).Code
                                Case "INCHARGEPLAN5" : z1317.InchargePlan5 = Children(i).Code
                                Case "DATEINSERT" : z1317.DateInsert = Children(i).Code
                                Case "INCHARGEINSERT" : z1317.InchargeInsert = Children(i).Code
                                Case "DATEUPDATE" : z1317.DateUpdate = Children(i).Code
                                Case "INCHARGEUPDATE" : z1317.InchargeUpdate = Children(i).Code
                                Case "REMARKPLAN1" : z1317.RemarkPlan1 = Children(i).Code
                                Case "REMARKPLAN2" : z1317.RemarkPlan2 = Children(i).Code
                                Case "REMARKPLAN3" : z1317.RemarkPlan3 = Children(i).Code
                                Case "REMARKPLAN4" : z1317.RemarkPlan4 = Children(i).Code
                                Case "REMARKPLAN5" : z1317.RemarkPlan5 = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "ORDERNO" : z1317.OrderNo = Children(i).Data
                                Case "ORDERNOSEQ" : z1317.OrderNoSeq = Children(i).Data
                                Case "ORDERNOSNO" : z1317.OrderNoSno = Children(i).Data
                                Case "SEMAINPROCESS" : z1317.seMainProcess = Children(i).Data
                                Case "CDMAINPROCESS" : z1317.cdMainProcess = Children(i).Data
                                Case "SESUBPROCESS" : z1317.seSubProcess = Children(i).Data
                                Case "CDSUBPROCESS" : z1317.cdSubProcess = Children(i).Data
                                Case "DESCRIPTION" : z1317.Description = Children(i).Data
                                Case "QTYDATESTANDARD" : z1317.QtyDateStandard = Children(i).Data
                                Case "QTYDATEMIN" : z1317.QtyDateMin = Children(i).Data
                                Case "QTYDATEMAX" : z1317.QtyDateMax = Children(i).Data
                                Case "MASTERMODELDATEPROCESS" : z1317.MasterModelDateProcess = Children(i).Data
                                Case "MASTERPLANDATEPROCESS" : z1317.MasterPlanDateProcess = Children(i).Data
                                Case "MASTERSALESDATEPROCESS" : z1317.MasterSalesDateProcess = Children(i).Data
                                Case "MASTERDATEPROCESS_1" : z1317.MasterDateProcess_1 = Children(i).Data
                                Case "MASTERDATEPROCESS_2" : z1317.MasterDateProcess_2 = Children(i).Data
                                Case "MASTERDATEPROCESS_3" : z1317.MasterDateProcess_3 = Children(i).Data
                                Case "MASTERDATEPROCESS_4" : z1317.MasterDateProcess_4 = Children(i).Data
                                Case "MASTERDATEPROCESS_5" : z1317.MasterDateProcess_5 = Children(i).Data
                                Case "INCHARGEPLAN1" : z1317.InchargePlan1 = Children(i).Data
                                Case "INCHARGEPLAN2" : z1317.InchargePlan2 = Children(i).Data
                                Case "INCHARGEPLAN3" : z1317.InchargePlan3 = Children(i).Data
                                Case "INCHARGEPLAN4" : z1317.InchargePlan4 = Children(i).Data
                                Case "INCHARGEPLAN5" : z1317.InchargePlan5 = Children(i).Data
                                Case "DATEINSERT" : z1317.DateInsert = Children(i).Data
                                Case "INCHARGEINSERT" : z1317.InchargeInsert = Children(i).Data
                                Case "DATEUPDATE" : z1317.DateUpdate = Children(i).Data
                                Case "INCHARGEUPDATE" : z1317.InchargeUpdate = Children(i).Data
                                Case "REMARKPLAN1" : z1317.RemarkPlan1 = Children(i).Data
                                Case "REMARKPLAN2" : z1317.RemarkPlan2 = Children(i).Data
                                Case "REMARKPLAN3" : z1317.RemarkPlan3 = Children(i).Data
                                Case "REMARKPLAN4" : z1317.RemarkPlan4 = Children(i).Data
                                Case "REMARKPLAN5" : z1317.RemarkPlan5 = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K1317_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K1317_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z1317 As T1317_AREA, Job As String, CheckClear As Boolean, ORDERNO As String, ORDERNOSEQ As String, ORDERNOSNO As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K1317_MOVE = False

        Try
            If READ_PFK1317(ORDERNO, ORDERNOSEQ, ORDERNOSNO) = True Then
                z1317 = D1317
                K1317_MOVE = True
            Else
                If CheckClear = True Then z1317 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1317")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "ORDERNO" : z1317.OrderNo = Children(i).Code
                                Case "ORDERNOSEQ" : z1317.OrderNoSeq = Children(i).Code
                                Case "ORDERNOSNO" : z1317.OrderNoSno = Children(i).Code
                                Case "SEMAINPROCESS" : z1317.seMainProcess = Children(i).Code
                                Case "CDMAINPROCESS" : z1317.cdMainProcess = Children(i).Code
                                Case "SESUBPROCESS" : z1317.seSubProcess = Children(i).Code
                                Case "CDSUBPROCESS" : z1317.cdSubProcess = Children(i).Code
                                Case "DESCRIPTION" : z1317.Description = Children(i).Code
                                Case "QTYDATESTANDARD" : z1317.QtyDateStandard = Children(i).Code
                                Case "QTYDATEMIN" : z1317.QtyDateMin = Children(i).Code
                                Case "QTYDATEMAX" : z1317.QtyDateMax = Children(i).Code
                                Case "MASTERMODELDATEPROCESS" : z1317.MasterModelDateProcess = Children(i).Code
                                Case "MASTERPLANDATEPROCESS" : z1317.MasterPlanDateProcess = Children(i).Code
                                Case "MASTERSALESDATEPROCESS" : z1317.MasterSalesDateProcess = Children(i).Code
                                Case "MASTERDATEPROCESS_1" : z1317.MasterDateProcess_1 = Children(i).Code
                                Case "MASTERDATEPROCESS_2" : z1317.MasterDateProcess_2 = Children(i).Code
                                Case "MASTERDATEPROCESS_3" : z1317.MasterDateProcess_3 = Children(i).Code
                                Case "MASTERDATEPROCESS_4" : z1317.MasterDateProcess_4 = Children(i).Code
                                Case "MASTERDATEPROCESS_5" : z1317.MasterDateProcess_5 = Children(i).Code
                                Case "INCHARGEPLAN1" : z1317.InchargePlan1 = Children(i).Code
                                Case "INCHARGEPLAN2" : z1317.InchargePlan2 = Children(i).Code
                                Case "INCHARGEPLAN3" : z1317.InchargePlan3 = Children(i).Code
                                Case "INCHARGEPLAN4" : z1317.InchargePlan4 = Children(i).Code
                                Case "INCHARGEPLAN5" : z1317.InchargePlan5 = Children(i).Code
                                Case "DATEINSERT" : z1317.DateInsert = Children(i).Code
                                Case "INCHARGEINSERT" : z1317.InchargeInsert = Children(i).Code
                                Case "DATEUPDATE" : z1317.DateUpdate = Children(i).Code
                                Case "INCHARGEUPDATE" : z1317.InchargeUpdate = Children(i).Code
                                Case "REMARKPLAN1" : z1317.RemarkPlan1 = Children(i).Code
                                Case "REMARKPLAN2" : z1317.RemarkPlan2 = Children(i).Code
                                Case "REMARKPLAN3" : z1317.RemarkPlan3 = Children(i).Code
                                Case "REMARKPLAN4" : z1317.RemarkPlan4 = Children(i).Code
                                Case "REMARKPLAN5" : z1317.RemarkPlan5 = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "ORDERNO" : z1317.OrderNo = Children(i).Data
                                Case "ORDERNOSEQ" : z1317.OrderNoSeq = Children(i).Data
                                Case "ORDERNOSNO" : z1317.OrderNoSno = Children(i).Data
                                Case "SEMAINPROCESS" : z1317.seMainProcess = Children(i).Data
                                Case "CDMAINPROCESS" : z1317.cdMainProcess = Children(i).Data
                                Case "SESUBPROCESS" : z1317.seSubProcess = Children(i).Data
                                Case "CDSUBPROCESS" : z1317.cdSubProcess = Children(i).Data
                                Case "DESCRIPTION" : z1317.Description = Children(i).Data
                                Case "QTYDATESTANDARD" : z1317.QtyDateStandard = Children(i).Data
                                Case "QTYDATEMIN" : z1317.QtyDateMin = Children(i).Data
                                Case "QTYDATEMAX" : z1317.QtyDateMax = Children(i).Data
                                Case "MASTERMODELDATEPROCESS" : z1317.MasterModelDateProcess = Children(i).Data
                                Case "MASTERPLANDATEPROCESS" : z1317.MasterPlanDateProcess = Children(i).Data
                                Case "MASTERSALESDATEPROCESS" : z1317.MasterSalesDateProcess = Children(i).Data
                                Case "MASTERDATEPROCESS_1" : z1317.MasterDateProcess_1 = Children(i).Data
                                Case "MASTERDATEPROCESS_2" : z1317.MasterDateProcess_2 = Children(i).Data
                                Case "MASTERDATEPROCESS_3" : z1317.MasterDateProcess_3 = Children(i).Data
                                Case "MASTERDATEPROCESS_4" : z1317.MasterDateProcess_4 = Children(i).Data
                                Case "MASTERDATEPROCESS_5" : z1317.MasterDateProcess_5 = Children(i).Data
                                Case "INCHARGEPLAN1" : z1317.InchargePlan1 = Children(i).Data
                                Case "INCHARGEPLAN2" : z1317.InchargePlan2 = Children(i).Data
                                Case "INCHARGEPLAN3" : z1317.InchargePlan3 = Children(i).Data
                                Case "INCHARGEPLAN4" : z1317.InchargePlan4 = Children(i).Data
                                Case "INCHARGEPLAN5" : z1317.InchargePlan5 = Children(i).Data
                                Case "DATEINSERT" : z1317.DateInsert = Children(i).Data
                                Case "INCHARGEINSERT" : z1317.InchargeInsert = Children(i).Data
                                Case "DATEUPDATE" : z1317.DateUpdate = Children(i).Data
                                Case "INCHARGEUPDATE" : z1317.InchargeUpdate = Children(i).Data
                                Case "REMARKPLAN1" : z1317.RemarkPlan1 = Children(i).Data
                                Case "REMARKPLAN2" : z1317.RemarkPlan2 = Children(i).Data
                                Case "REMARKPLAN3" : z1317.RemarkPlan3 = Children(i).Data
                                Case "REMARKPLAN4" : z1317.RemarkPlan4 = Children(i).Data
                                Case "REMARKPLAN5" : z1317.RemarkPlan5 = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K1317_MOVE", vbCritical)
        End Try
    End Function

End Module
