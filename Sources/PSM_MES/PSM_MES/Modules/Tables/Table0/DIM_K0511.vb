'=========================================================================================================================================================
'   TABLE : (PFK0511)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K0511

    Structure T0511_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public ProdDate As String  '			char(8)		*
        Public ProdSeq As String  '			char(5)		*
        Public SpecNo As String  '			char(9)
        Public SpecNoSeq As String  '			char(3)
        Public seMainProcess As String  '			char(3)
        Public cdMainProcess As String  '			char(3)
        Public seSubProcess As String  '			char(3)
        Public cdSubProcess As String  '			char(3)
        Public seFactory As String  '			char(3)
        Public cdFactory As String  '			char(3)
        Public seLineProd As String  '			char(3)
        Public cdLineProd As String  '			char(3)
        Public LineTno As String  '			char(2)
        Public DateProduction As String  '			char(8)
        Public STimeProduction As String  '			nvarchar(20)
        Public ETimeProduction As String  '			nvarchar(20)
        Public InchargeProdution As String  '			char(8)
        Public seMachineType As String  '			char(3)
        Public cdMachineType As String  '			char(3)
        Public MachineCode As String  '			char(6)
        Public PartProduction As String  '			char(1)
        Public QtyInProduction As Double  '			decimal
        Public QtyProduction As Double  '			decimal
        Public QtyProductionA As Double  '			decimal
        Public QtyProductionX As Double  '			decimal
        Public QtyProductionXP As Double  '			decimal
        Public QtyProductionXD As Double  '			decimal
        Public QtyProductionXR As Double  '			decimal
        Public QtyOutProduction As Double  '			decimal
        Public AmountProduction As Double  '			decimal
        Public AmountProductionReceipt As Double  '			decimal
        Public ISUD As String  '			char(4)
        Public CheckComplete As String  '			char(1)
        Public CheckTrigger As String  '			nvarchar(10)
        Public Remark As String  '			nvarchar(100)
        '=========================================================================================================================================================
    End Structure

    Public D0511 As T0511_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK0511(PRODDATE As String, PRODSEQ As String) As Boolean
        READ_PFK0511 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK0511 "
            SQL = SQL & " WHERE K0511_ProdDate		 = '" & ProdDate & "' "
            SQL = SQL & "   AND K0511_ProdSeq		 = '" & ProdSeq & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D0511_CLEAR() : GoTo SKIP_READ_PFK0511

            Call K0511_MOVE(rd)
            READ_PFK0511 = True

SKIP_READ_PFK0511:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK0511", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK0511(PRODDATE As String, PRODSEQ As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK0511 "
            SQL = SQL & " WHERE K0511_ProdDate		 = '" & ProdDate & "' "
            SQL = SQL & "   AND K0511_ProdSeq		 = '" & ProdSeq & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK0511", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK0511(z0511 As T0511_AREA) As Boolean
        WRITE_PFK0511 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z0511)

            SQL = " INSERT INTO PFK0511 "
            SQL = SQL & " ( "
            SQL = SQL & " K0511_ProdDate,"
            SQL = SQL & " K0511_ProdSeq,"
            SQL = SQL & " K0511_SpecNo,"
            SQL = SQL & " K0511_SpecNoSeq,"
            SQL = SQL & " K0511_seMainProcess,"
            SQL = SQL & " K0511_cdMainProcess,"
            SQL = SQL & " K0511_seSubProcess,"
            SQL = SQL & " K0511_cdSubProcess,"
            SQL = SQL & " K0511_seFactory,"
            SQL = SQL & " K0511_cdFactory,"
            SQL = SQL & " K0511_seLineProd,"
            SQL = SQL & " K0511_cdLineProd,"
            SQL = SQL & " K0511_LineTno,"
            SQL = SQL & " K0511_DateProduction,"
            SQL = SQL & " K0511_STimeProduction,"
            SQL = SQL & " K0511_ETimeProduction,"
            SQL = SQL & " K0511_InchargeProdution,"
            SQL = SQL & " K0511_seMachineType,"
            SQL = SQL & " K0511_cdMachineType,"
            SQL = SQL & " K0511_MachineCode,"
            SQL = SQL & " K0511_PartProduction,"
            SQL = SQL & " K0511_QtyInProduction,"
            SQL = SQL & " K0511_QtyProduction,"
            SQL = SQL & " K0511_QtyProductionA,"
            SQL = SQL & " K0511_QtyProductionX,"
            SQL = SQL & " K0511_QtyProductionXP,"
            SQL = SQL & " K0511_QtyProductionXD,"
            SQL = SQL & " K0511_QtyProductionXR,"
            SQL = SQL & " K0511_QtyOutProduction,"
            SQL = SQL & " K0511_AmountProduction,"
            SQL = SQL & " K0511_AmountProductionReceipt,"
            SQL = SQL & " K0511_ISUD,"
            SQL = SQL & " K0511_CheckComplete,"
            SQL = SQL & " K0511_CheckTrigger,"
            SQL = SQL & " K0511_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z0511.ProdDate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0511.ProdSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0511.SpecNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0511.SpecNoSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0511.seMainProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0511.cdMainProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0511.seSubProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0511.cdSubProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0511.seFactory) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0511.cdFactory) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0511.seLineProd) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0511.cdLineProd) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0511.LineTno) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0511.DateProduction) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0511.STimeProduction) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0511.ETimeProduction) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0511.InchargeProdution) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0511.seMachineType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0511.cdMachineType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0511.MachineCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0511.PartProduction) & "', "
            SQL = SQL & "   " & FormatSQL(z0511.QtyInProduction) & ", "
            SQL = SQL & "   " & FormatSQL(z0511.QtyProduction) & ", "
            SQL = SQL & "   " & FormatSQL(z0511.QtyProductionA) & ", "
            SQL = SQL & "   " & FormatSQL(z0511.QtyProductionX) & ", "
            SQL = SQL & "   " & FormatSQL(z0511.QtyProductionXP) & ", "
            SQL = SQL & "   " & FormatSQL(z0511.QtyProductionXD) & ", "
            SQL = SQL & "   " & FormatSQL(z0511.QtyProductionXR) & ", "
            SQL = SQL & "   " & FormatSQL(z0511.QtyOutProduction) & ", "
            SQL = SQL & "   " & FormatSQL(z0511.AmountProduction) & ", "
            SQL = SQL & "   " & FormatSQL(z0511.AmountProductionReceipt) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0511.ISUD) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0511.CheckComplete) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0511.CheckTrigger) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0511.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK0511 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK0511", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK0511(z0511 As T0511_AREA) As Boolean
        REWRITE_PFK0511 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z0511)

            SQL = " UPDATE PFK0511 SET "
            SQL = SQL & "    K0511_SpecNo      = N'" & FormatSQL(z0511.SpecNo) & "', "
            SQL = SQL & "    K0511_SpecNoSeq      = N'" & FormatSQL(z0511.SpecNoSeq) & "', "
            SQL = SQL & "    K0511_seMainProcess      = N'" & FormatSQL(z0511.seMainProcess) & "', "
            SQL = SQL & "    K0511_cdMainProcess      = N'" & FormatSQL(z0511.cdMainProcess) & "', "
            SQL = SQL & "    K0511_seSubProcess      = N'" & FormatSQL(z0511.seSubProcess) & "', "
            SQL = SQL & "    K0511_cdSubProcess      = N'" & FormatSQL(z0511.cdSubProcess) & "', "
            SQL = SQL & "    K0511_seFactory      = N'" & FormatSQL(z0511.seFactory) & "', "
            SQL = SQL & "    K0511_cdFactory      = N'" & FormatSQL(z0511.cdFactory) & "', "
            SQL = SQL & "    K0511_seLineProd      = N'" & FormatSQL(z0511.seLineProd) & "', "
            SQL = SQL & "    K0511_cdLineProd      = N'" & FormatSQL(z0511.cdLineProd) & "', "
            SQL = SQL & "    K0511_LineTno      = N'" & FormatSQL(z0511.LineTno) & "', "
            SQL = SQL & "    K0511_DateProduction      = N'" & FormatSQL(z0511.DateProduction) & "', "
            SQL = SQL & "    K0511_STimeProduction      = N'" & FormatSQL(z0511.STimeProduction) & "', "
            SQL = SQL & "    K0511_ETimeProduction      = N'" & FormatSQL(z0511.ETimeProduction) & "', "
            SQL = SQL & "    K0511_InchargeProdution      = N'" & FormatSQL(z0511.InchargeProdution) & "', "
            SQL = SQL & "    K0511_seMachineType      = N'" & FormatSQL(z0511.seMachineType) & "', "
            SQL = SQL & "    K0511_cdMachineType      = N'" & FormatSQL(z0511.cdMachineType) & "', "
            SQL = SQL & "    K0511_MachineCode      = N'" & FormatSQL(z0511.MachineCode) & "', "
            SQL = SQL & "    K0511_PartProduction      = N'" & FormatSQL(z0511.PartProduction) & "', "
            SQL = SQL & "    K0511_QtyInProduction      =  " & FormatSQL(z0511.QtyInProduction) & ", "
            SQL = SQL & "    K0511_QtyProduction      =  " & FormatSQL(z0511.QtyProduction) & ", "
            SQL = SQL & "    K0511_QtyProductionA      =  " & FormatSQL(z0511.QtyProductionA) & ", "
            SQL = SQL & "    K0511_QtyProductionX      =  " & FormatSQL(z0511.QtyProductionX) & ", "
            SQL = SQL & "    K0511_QtyProductionXP      =  " & FormatSQL(z0511.QtyProductionXP) & ", "
            SQL = SQL & "    K0511_QtyProductionXD      =  " & FormatSQL(z0511.QtyProductionXD) & ", "
            SQL = SQL & "    K0511_QtyProductionXR      =  " & FormatSQL(z0511.QtyProductionXR) & ", "
            SQL = SQL & "    K0511_QtyOutProduction      =  " & FormatSQL(z0511.QtyOutProduction) & ", "
            SQL = SQL & "    K0511_AmountProduction      =  " & FormatSQL(z0511.AmountProduction) & ", "
            SQL = SQL & "    K0511_AmountProductionReceipt      =  " & FormatSQL(z0511.AmountProductionReceipt) & ", "
            SQL = SQL & "    K0511_ISUD      = N'" & FormatSQL(z0511.ISUD) & "', "
            SQL = SQL & "    K0511_CheckComplete      = N'" & FormatSQL(z0511.CheckComplete) & "', "
            SQL = SQL & "    K0511_CheckTrigger      = N'" & FormatSQL(z0511.CheckTrigger) & "', "
            SQL = SQL & "    K0511_Remark      = N'" & FormatSQL(z0511.Remark) & "'  "
            SQL = SQL & " WHERE K0511_ProdDate		 = '" & z0511.ProdDate & "' "
            SQL = SQL & "   AND K0511_ProdSeq		 = '" & z0511.ProdSeq & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK0511 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK0511", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK0511(z0511 As T0511_AREA) As Boolean
        DELETE_PFK0511 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK0511 "
            SQL = SQL & " WHERE K0511_ProdDate		 = '" & z0511.ProdDate & "' "
            SQL = SQL & "   AND K0511_ProdSeq		 = '" & z0511.ProdSeq & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK0511 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK0511", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D0511_CLEAR()
        Try

            D0511.ProdDate = ""
            D0511.ProdSeq = ""
            D0511.SpecNo = ""
            D0511.SpecNoSeq = ""
            D0511.seMainProcess = ""
            D0511.cdMainProcess = ""
            D0511.seSubProcess = ""
            D0511.cdSubProcess = ""
            D0511.seFactory = ""
            D0511.cdFactory = ""
            D0511.seLineProd = ""
            D0511.cdLineProd = ""
            D0511.LineTno = ""
            D0511.DateProduction = ""
            D0511.STimeProduction = ""
            D0511.ETimeProduction = ""
            D0511.InchargeProdution = ""
            D0511.seMachineType = ""
            D0511.cdMachineType = ""
            D0511.MachineCode = ""
            D0511.PartProduction = ""
            D0511.QtyInProduction = 0
            D0511.QtyProduction = 0
            D0511.QtyProductionA = 0
            D0511.QtyProductionX = 0
            D0511.QtyProductionXP = 0
            D0511.QtyProductionXD = 0
            D0511.QtyProductionXR = 0
            D0511.QtyOutProduction = 0
            D0511.AmountProduction = 0
            D0511.AmountProductionReceipt = 0
            D0511.ISUD = ""
            D0511.CheckComplete = ""
            D0511.CheckTrigger = ""
            D0511.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D0511_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x0511 As T0511_AREA)
        Try

            x0511.ProdDate = trim$(x0511.ProdDate)
            x0511.ProdSeq = trim$(x0511.ProdSeq)
            x0511.SpecNo = trim$(x0511.SpecNo)
            x0511.SpecNoSeq = trim$(x0511.SpecNoSeq)
            x0511.seMainProcess = trim$(x0511.seMainProcess)
            x0511.cdMainProcess = trim$(x0511.cdMainProcess)
            x0511.seSubProcess = trim$(x0511.seSubProcess)
            x0511.cdSubProcess = trim$(x0511.cdSubProcess)
            x0511.seFactory = trim$(x0511.seFactory)
            x0511.cdFactory = trim$(x0511.cdFactory)
            x0511.seLineProd = trim$(x0511.seLineProd)
            x0511.cdLineProd = trim$(x0511.cdLineProd)
            x0511.LineTno = trim$(x0511.LineTno)
            x0511.DateProduction = trim$(x0511.DateProduction)
            x0511.STimeProduction = trim$(x0511.STimeProduction)
            x0511.ETimeProduction = trim$(x0511.ETimeProduction)
            x0511.InchargeProdution = trim$(x0511.InchargeProdution)
            x0511.seMachineType = trim$(x0511.seMachineType)
            x0511.cdMachineType = trim$(x0511.cdMachineType)
            x0511.MachineCode = trim$(x0511.MachineCode)
            x0511.PartProduction = trim$(x0511.PartProduction)
            x0511.QtyInProduction = trim$(x0511.QtyInProduction)
            x0511.QtyProduction = trim$(x0511.QtyProduction)
            x0511.QtyProductionA = trim$(x0511.QtyProductionA)
            x0511.QtyProductionX = trim$(x0511.QtyProductionX)
            x0511.QtyProductionXP = trim$(x0511.QtyProductionXP)
            x0511.QtyProductionXD = trim$(x0511.QtyProductionXD)
            x0511.QtyProductionXR = trim$(x0511.QtyProductionXR)
            x0511.QtyOutProduction = trim$(x0511.QtyOutProduction)
            x0511.AmountProduction = trim$(x0511.AmountProduction)
            x0511.AmountProductionReceipt = trim$(x0511.AmountProductionReceipt)
            x0511.ISUD = trim$(x0511.ISUD)
            x0511.CheckComplete = trim$(x0511.CheckComplete)
            x0511.CheckTrigger = trim$(x0511.CheckTrigger)
            x0511.Remark = trim$(x0511.Remark)

            If trim$(x0511.ProdDate) = "" Then x0511.ProdDate = Space(1)
            If trim$(x0511.ProdSeq) = "" Then x0511.ProdSeq = Space(1)
            If trim$(x0511.SpecNo) = "" Then x0511.SpecNo = Space(1)
            If trim$(x0511.SpecNoSeq) = "" Then x0511.SpecNoSeq = Space(1)
            If trim$(x0511.seMainProcess) = "" Then x0511.seMainProcess = Space(1)
            If trim$(x0511.cdMainProcess) = "" Then x0511.cdMainProcess = Space(1)
            If trim$(x0511.seSubProcess) = "" Then x0511.seSubProcess = Space(1)
            If trim$(x0511.cdSubProcess) = "" Then x0511.cdSubProcess = Space(1)
            If trim$(x0511.seFactory) = "" Then x0511.seFactory = Space(1)
            If trim$(x0511.cdFactory) = "" Then x0511.cdFactory = Space(1)
            If trim$(x0511.seLineProd) = "" Then x0511.seLineProd = Space(1)
            If trim$(x0511.cdLineProd) = "" Then x0511.cdLineProd = Space(1)
            If trim$(x0511.LineTno) = "" Then x0511.LineTno = Space(1)
            If trim$(x0511.DateProduction) = "" Then x0511.DateProduction = Space(1)
            If trim$(x0511.STimeProduction) = "" Then x0511.STimeProduction = Space(1)
            If trim$(x0511.ETimeProduction) = "" Then x0511.ETimeProduction = Space(1)
            If trim$(x0511.InchargeProdution) = "" Then x0511.InchargeProdution = Space(1)
            If trim$(x0511.seMachineType) = "" Then x0511.seMachineType = Space(1)
            If trim$(x0511.cdMachineType) = "" Then x0511.cdMachineType = Space(1)
            If trim$(x0511.MachineCode) = "" Then x0511.MachineCode = Space(1)
            If trim$(x0511.PartProduction) = "" Then x0511.PartProduction = Space(1)
            If trim$(x0511.QtyInProduction) = "" Then x0511.QtyInProduction = 0
            If trim$(x0511.QtyProduction) = "" Then x0511.QtyProduction = 0
            If trim$(x0511.QtyProductionA) = "" Then x0511.QtyProductionA = 0
            If trim$(x0511.QtyProductionX) = "" Then x0511.QtyProductionX = 0
            If trim$(x0511.QtyProductionXP) = "" Then x0511.QtyProductionXP = 0
            If trim$(x0511.QtyProductionXD) = "" Then x0511.QtyProductionXD = 0
            If trim$(x0511.QtyProductionXR) = "" Then x0511.QtyProductionXR = 0
            If trim$(x0511.QtyOutProduction) = "" Then x0511.QtyOutProduction = 0
            If trim$(x0511.AmountProduction) = "" Then x0511.AmountProduction = 0
            If trim$(x0511.AmountProductionReceipt) = "" Then x0511.AmountProductionReceipt = 0
            If trim$(x0511.ISUD) = "" Then x0511.ISUD = Space(1)
            If trim$(x0511.CheckComplete) = "" Then x0511.CheckComplete = Space(1)
            If trim$(x0511.CheckTrigger) = "" Then x0511.CheckTrigger = Space(1)
            If trim$(x0511.Remark) = "" Then x0511.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K0511_MOVE(rs0511 As SqlClient.SqlDataReader)
        Try

            Call D0511_CLEAR()

            If IsdbNull(rs0511!K0511_ProdDate) = False Then D0511.ProdDate = Trim$(rs0511!K0511_ProdDate)
            If IsdbNull(rs0511!K0511_ProdSeq) = False Then D0511.ProdSeq = Trim$(rs0511!K0511_ProdSeq)
            If IsdbNull(rs0511!K0511_SpecNo) = False Then D0511.SpecNo = Trim$(rs0511!K0511_SpecNo)
            If IsdbNull(rs0511!K0511_SpecNoSeq) = False Then D0511.SpecNoSeq = Trim$(rs0511!K0511_SpecNoSeq)
            If IsdbNull(rs0511!K0511_seMainProcess) = False Then D0511.seMainProcess = Trim$(rs0511!K0511_seMainProcess)
            If IsdbNull(rs0511!K0511_cdMainProcess) = False Then D0511.cdMainProcess = Trim$(rs0511!K0511_cdMainProcess)
            If IsdbNull(rs0511!K0511_seSubProcess) = False Then D0511.seSubProcess = Trim$(rs0511!K0511_seSubProcess)
            If IsdbNull(rs0511!K0511_cdSubProcess) = False Then D0511.cdSubProcess = Trim$(rs0511!K0511_cdSubProcess)
            If IsdbNull(rs0511!K0511_seFactory) = False Then D0511.seFactory = Trim$(rs0511!K0511_seFactory)
            If IsdbNull(rs0511!K0511_cdFactory) = False Then D0511.cdFactory = Trim$(rs0511!K0511_cdFactory)
            If IsdbNull(rs0511!K0511_seLineProd) = False Then D0511.seLineProd = Trim$(rs0511!K0511_seLineProd)
            If IsdbNull(rs0511!K0511_cdLineProd) = False Then D0511.cdLineProd = Trim$(rs0511!K0511_cdLineProd)
            If IsdbNull(rs0511!K0511_LineTno) = False Then D0511.LineTno = Trim$(rs0511!K0511_LineTno)
            If IsdbNull(rs0511!K0511_DateProduction) = False Then D0511.DateProduction = Trim$(rs0511!K0511_DateProduction)
            If IsdbNull(rs0511!K0511_STimeProduction) = False Then D0511.STimeProduction = Trim$(rs0511!K0511_STimeProduction)
            If IsdbNull(rs0511!K0511_ETimeProduction) = False Then D0511.ETimeProduction = Trim$(rs0511!K0511_ETimeProduction)
            If IsdbNull(rs0511!K0511_InchargeProdution) = False Then D0511.InchargeProdution = Trim$(rs0511!K0511_InchargeProdution)
            If IsdbNull(rs0511!K0511_seMachineType) = False Then D0511.seMachineType = Trim$(rs0511!K0511_seMachineType)
            If IsdbNull(rs0511!K0511_cdMachineType) = False Then D0511.cdMachineType = Trim$(rs0511!K0511_cdMachineType)
            If IsdbNull(rs0511!K0511_MachineCode) = False Then D0511.MachineCode = Trim$(rs0511!K0511_MachineCode)
            If IsdbNull(rs0511!K0511_PartProduction) = False Then D0511.PartProduction = Trim$(rs0511!K0511_PartProduction)
            If IsdbNull(rs0511!K0511_QtyInProduction) = False Then D0511.QtyInProduction = Trim$(rs0511!K0511_QtyInProduction)
            If IsdbNull(rs0511!K0511_QtyProduction) = False Then D0511.QtyProduction = Trim$(rs0511!K0511_QtyProduction)
            If IsdbNull(rs0511!K0511_QtyProductionA) = False Then D0511.QtyProductionA = Trim$(rs0511!K0511_QtyProductionA)
            If IsdbNull(rs0511!K0511_QtyProductionX) = False Then D0511.QtyProductionX = Trim$(rs0511!K0511_QtyProductionX)
            If IsdbNull(rs0511!K0511_QtyProductionXP) = False Then D0511.QtyProductionXP = Trim$(rs0511!K0511_QtyProductionXP)
            If IsdbNull(rs0511!K0511_QtyProductionXD) = False Then D0511.QtyProductionXD = Trim$(rs0511!K0511_QtyProductionXD)
            If IsdbNull(rs0511!K0511_QtyProductionXR) = False Then D0511.QtyProductionXR = Trim$(rs0511!K0511_QtyProductionXR)
            If IsdbNull(rs0511!K0511_QtyOutProduction) = False Then D0511.QtyOutProduction = Trim$(rs0511!K0511_QtyOutProduction)
            If IsdbNull(rs0511!K0511_AmountProduction) = False Then D0511.AmountProduction = Trim$(rs0511!K0511_AmountProduction)
            If IsdbNull(rs0511!K0511_AmountProductionReceipt) = False Then D0511.AmountProductionReceipt = Trim$(rs0511!K0511_AmountProductionReceipt)
            If IsdbNull(rs0511!K0511_ISUD) = False Then D0511.ISUD = Trim$(rs0511!K0511_ISUD)
            If IsdbNull(rs0511!K0511_CheckComplete) = False Then D0511.CheckComplete = Trim$(rs0511!K0511_CheckComplete)
            If IsdbNull(rs0511!K0511_CheckTrigger) = False Then D0511.CheckTrigger = Trim$(rs0511!K0511_CheckTrigger)
            If IsdbNull(rs0511!K0511_Remark) = False Then D0511.Remark = Trim$(rs0511!K0511_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K0511_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K0511_MOVE(rs0511 As DataRow)
        Try

            Call D0511_CLEAR()

            If IsdbNull(rs0511!K0511_ProdDate) = False Then D0511.ProdDate = Trim$(rs0511!K0511_ProdDate)
            If IsdbNull(rs0511!K0511_ProdSeq) = False Then D0511.ProdSeq = Trim$(rs0511!K0511_ProdSeq)
            If IsdbNull(rs0511!K0511_SpecNo) = False Then D0511.SpecNo = Trim$(rs0511!K0511_SpecNo)
            If IsdbNull(rs0511!K0511_SpecNoSeq) = False Then D0511.SpecNoSeq = Trim$(rs0511!K0511_SpecNoSeq)
            If IsdbNull(rs0511!K0511_seMainProcess) = False Then D0511.seMainProcess = Trim$(rs0511!K0511_seMainProcess)
            If IsdbNull(rs0511!K0511_cdMainProcess) = False Then D0511.cdMainProcess = Trim$(rs0511!K0511_cdMainProcess)
            If IsdbNull(rs0511!K0511_seSubProcess) = False Then D0511.seSubProcess = Trim$(rs0511!K0511_seSubProcess)
            If IsdbNull(rs0511!K0511_cdSubProcess) = False Then D0511.cdSubProcess = Trim$(rs0511!K0511_cdSubProcess)
            If IsdbNull(rs0511!K0511_seFactory) = False Then D0511.seFactory = Trim$(rs0511!K0511_seFactory)
            If IsdbNull(rs0511!K0511_cdFactory) = False Then D0511.cdFactory = Trim$(rs0511!K0511_cdFactory)
            If IsdbNull(rs0511!K0511_seLineProd) = False Then D0511.seLineProd = Trim$(rs0511!K0511_seLineProd)
            If IsdbNull(rs0511!K0511_cdLineProd) = False Then D0511.cdLineProd = Trim$(rs0511!K0511_cdLineProd)
            If IsdbNull(rs0511!K0511_LineTno) = False Then D0511.LineTno = Trim$(rs0511!K0511_LineTno)
            If IsdbNull(rs0511!K0511_DateProduction) = False Then D0511.DateProduction = Trim$(rs0511!K0511_DateProduction)
            If IsdbNull(rs0511!K0511_STimeProduction) = False Then D0511.STimeProduction = Trim$(rs0511!K0511_STimeProduction)
            If IsdbNull(rs0511!K0511_ETimeProduction) = False Then D0511.ETimeProduction = Trim$(rs0511!K0511_ETimeProduction)
            If IsdbNull(rs0511!K0511_InchargeProdution) = False Then D0511.InchargeProdution = Trim$(rs0511!K0511_InchargeProdution)
            If IsdbNull(rs0511!K0511_seMachineType) = False Then D0511.seMachineType = Trim$(rs0511!K0511_seMachineType)
            If IsdbNull(rs0511!K0511_cdMachineType) = False Then D0511.cdMachineType = Trim$(rs0511!K0511_cdMachineType)
            If IsdbNull(rs0511!K0511_MachineCode) = False Then D0511.MachineCode = Trim$(rs0511!K0511_MachineCode)
            If IsdbNull(rs0511!K0511_PartProduction) = False Then D0511.PartProduction = Trim$(rs0511!K0511_PartProduction)
            If IsdbNull(rs0511!K0511_QtyInProduction) = False Then D0511.QtyInProduction = Trim$(rs0511!K0511_QtyInProduction)
            If IsdbNull(rs0511!K0511_QtyProduction) = False Then D0511.QtyProduction = Trim$(rs0511!K0511_QtyProduction)
            If IsdbNull(rs0511!K0511_QtyProductionA) = False Then D0511.QtyProductionA = Trim$(rs0511!K0511_QtyProductionA)
            If IsdbNull(rs0511!K0511_QtyProductionX) = False Then D0511.QtyProductionX = Trim$(rs0511!K0511_QtyProductionX)
            If IsdbNull(rs0511!K0511_QtyProductionXP) = False Then D0511.QtyProductionXP = Trim$(rs0511!K0511_QtyProductionXP)
            If IsdbNull(rs0511!K0511_QtyProductionXD) = False Then D0511.QtyProductionXD = Trim$(rs0511!K0511_QtyProductionXD)
            If IsdbNull(rs0511!K0511_QtyProductionXR) = False Then D0511.QtyProductionXR = Trim$(rs0511!K0511_QtyProductionXR)
            If IsdbNull(rs0511!K0511_QtyOutProduction) = False Then D0511.QtyOutProduction = Trim$(rs0511!K0511_QtyOutProduction)
            If IsdbNull(rs0511!K0511_AmountProduction) = False Then D0511.AmountProduction = Trim$(rs0511!K0511_AmountProduction)
            If IsdbNull(rs0511!K0511_AmountProductionReceipt) = False Then D0511.AmountProductionReceipt = Trim$(rs0511!K0511_AmountProductionReceipt)
            If IsdbNull(rs0511!K0511_ISUD) = False Then D0511.ISUD = Trim$(rs0511!K0511_ISUD)
            If IsdbNull(rs0511!K0511_CheckComplete) = False Then D0511.CheckComplete = Trim$(rs0511!K0511_CheckComplete)
            If IsdbNull(rs0511!K0511_CheckTrigger) = False Then D0511.CheckTrigger = Trim$(rs0511!K0511_CheckTrigger)
            If IsdbNull(rs0511!K0511_Remark) = False Then D0511.Remark = Trim$(rs0511!K0511_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K0511_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K0511_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z0511 As T0511_AREA, PRODDATE As String, PRODSEQ As String) As Boolean

        K0511_MOVE = False

        Try
            If READ_PFK0511(PRODDATE, PRODSEQ) = True Then
                z0511 = D0511
                K0511_MOVE = True
            Else
                z0511 = Nothing
            End If

            If getColumIndex(spr, "ProdDate") > -1 Then z0511.ProdDate = getDataM(spr, getColumIndex(spr, "ProdDate"), xRow)
            If getColumIndex(spr, "ProdSeq") > -1 Then z0511.ProdSeq = getDataM(spr, getColumIndex(spr, "ProdSeq"), xRow)
            If getColumIndex(spr, "SpecNo") > -1 Then z0511.SpecNo = getDataM(spr, getColumIndex(spr, "SpecNo"), xRow)
            If getColumIndex(spr, "SpecNoSeq") > -1 Then z0511.SpecNoSeq = getDataM(spr, getColumIndex(spr, "SpecNoSeq"), xRow)
            If getColumIndex(spr, "seMainProcess") > -1 Then z0511.seMainProcess = getDataM(spr, getColumIndex(spr, "seMainProcess"), xRow)
            If getColumIndex(spr, "cdMainProcess") > -1 Then z0511.cdMainProcess = getDataM(spr, getColumIndex(spr, "cdMainProcess"), xRow)
            If getColumIndex(spr, "seSubProcess") > -1 Then z0511.seSubProcess = getDataM(spr, getColumIndex(spr, "seSubProcess"), xRow)
            If getColumIndex(spr, "cdSubProcess") > -1 Then z0511.cdSubProcess = getDataM(spr, getColumIndex(spr, "cdSubProcess"), xRow)
            If getColumIndex(spr, "seFactory") > -1 Then z0511.seFactory = getDataM(spr, getColumIndex(spr, "seFactory"), xRow)
            If getColumIndex(spr, "cdFactory") > -1 Then z0511.cdFactory = getDataM(spr, getColumIndex(spr, "cdFactory"), xRow)
            If getColumIndex(spr, "seLineProd") > -1 Then z0511.seLineProd = getDataM(spr, getColumIndex(spr, "seLineProd"), xRow)
            If getColumIndex(spr, "cdLineProd") > -1 Then z0511.cdLineProd = getDataM(spr, getColumIndex(spr, "cdLineProd"), xRow)
            If getColumIndex(spr, "LineTno") > -1 Then z0511.LineTno = getDataM(spr, getColumIndex(spr, "LineTno"), xRow)
            If getColumIndex(spr, "DateProduction") > -1 Then z0511.DateProduction = getDataM(spr, getColumIndex(spr, "DateProduction"), xRow)
            If getColumIndex(spr, "STimeProduction") > -1 Then z0511.STimeProduction = getDataM(spr, getColumIndex(spr, "STimeProduction"), xRow)
            If getColumIndex(spr, "ETimeProduction") > -1 Then z0511.ETimeProduction = getDataM(spr, getColumIndex(spr, "ETimeProduction"), xRow)
            If getColumIndex(spr, "InchargeProdution") > -1 Then z0511.InchargeProdution = getDataM(spr, getColumIndex(spr, "InchargeProdution"), xRow)
            If getColumIndex(spr, "seMachineType") > -1 Then z0511.seMachineType = getDataM(spr, getColumIndex(spr, "seMachineType"), xRow)
            If getColumIndex(spr, "cdMachineType") > -1 Then z0511.cdMachineType = getDataM(spr, getColumIndex(spr, "cdMachineType"), xRow)
            If getColumIndex(spr, "MachineCode") > -1 Then z0511.MachineCode = getDataM(spr, getColumIndex(spr, "MachineCode"), xRow)
            If getColumIndex(spr, "PartProduction") > -1 Then z0511.PartProduction = getDataM(spr, getColumIndex(spr, "PartProduction"), xRow)
            If getColumIndex(spr, "QtyInProduction") > -1 Then z0511.QtyInProduction = getDataM(spr, getColumIndex(spr, "QtyInProduction"), xRow)
            If getColumIndex(spr, "QtyProduction") > -1 Then z0511.QtyProduction = getDataM(spr, getColumIndex(spr, "QtyProduction"), xRow)
            If getColumIndex(spr, "QtyProductionA") > -1 Then z0511.QtyProductionA = getDataM(spr, getColumIndex(spr, "QtyProductionA"), xRow)
            If getColumIndex(spr, "QtyProductionX") > -1 Then z0511.QtyProductionX = getDataM(spr, getColumIndex(spr, "QtyProductionX"), xRow)
            If getColumIndex(spr, "QtyProductionXP") > -1 Then z0511.QtyProductionXP = getDataM(spr, getColumIndex(spr, "QtyProductionXP"), xRow)
            If getColumIndex(spr, "QtyProductionXD") > -1 Then z0511.QtyProductionXD = getDataM(spr, getColumIndex(spr, "QtyProductionXD"), xRow)
            If getColumIndex(spr, "QtyProductionXR") > -1 Then z0511.QtyProductionXR = getDataM(spr, getColumIndex(spr, "QtyProductionXR"), xRow)
            If getColumIndex(spr, "QtyOutProduction") > -1 Then z0511.QtyOutProduction = getDataM(spr, getColumIndex(spr, "QtyOutProduction"), xRow)
            If getColumIndex(spr, "AmountProduction") > -1 Then z0511.AmountProduction = getDataM(spr, getColumIndex(spr, "AmountProduction"), xRow)
            If getColumIndex(spr, "AmountProductionReceipt") > -1 Then z0511.AmountProductionReceipt = getDataM(spr, getColumIndex(spr, "AmountProductionReceipt"), xRow)
            If getColumIndex(spr, "ISUD") > -1 Then z0511.ISUD = getDataM(spr, getColumIndex(spr, "ISUD"), xRow)
            If getColumIndex(spr, "CheckComplete") > -1 Then z0511.CheckComplete = getDataM(spr, getColumIndex(spr, "CheckComplete"), xRow)
            If getColumIndex(spr, "CheckTrigger") > -1 Then z0511.CheckTrigger = getDataM(spr, getColumIndex(spr, "CheckTrigger"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z0511.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K0511_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K0511_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z0511 As T0511_AREA, CheckClear As Boolean, PRODDATE As String, PRODSEQ As String) As Boolean

        K0511_MOVE = False

        Try
            If READ_PFK0511(PRODDATE, PRODSEQ) = True Then
                z0511 = D0511
                K0511_MOVE = True
            Else
                If CheckClear = True Then z0511 = Nothing
            End If

            If getColumIndex(spr, "ProdDate") > -1 Then z0511.ProdDate = getDataM(spr, getColumIndex(spr, "ProdDate"), xRow)
            If getColumIndex(spr, "ProdSeq") > -1 Then z0511.ProdSeq = getDataM(spr, getColumIndex(spr, "ProdSeq"), xRow)
            If getColumIndex(spr, "SpecNo") > -1 Then z0511.SpecNo = getDataM(spr, getColumIndex(spr, "SpecNo"), xRow)
            If getColumIndex(spr, "SpecNoSeq") > -1 Then z0511.SpecNoSeq = getDataM(spr, getColumIndex(spr, "SpecNoSeq"), xRow)
            If getColumIndex(spr, "seMainProcess") > -1 Then z0511.seMainProcess = getDataM(spr, getColumIndex(spr, "seMainProcess"), xRow)
            If getColumIndex(spr, "cdMainProcess") > -1 Then z0511.cdMainProcess = getDataM(spr, getColumIndex(spr, "cdMainProcess"), xRow)
            If getColumIndex(spr, "seSubProcess") > -1 Then z0511.seSubProcess = getDataM(spr, getColumIndex(spr, "seSubProcess"), xRow)
            If getColumIndex(spr, "cdSubProcess") > -1 Then z0511.cdSubProcess = getDataM(spr, getColumIndex(spr, "cdSubProcess"), xRow)
            If getColumIndex(spr, "seFactory") > -1 Then z0511.seFactory = getDataM(spr, getColumIndex(spr, "seFactory"), xRow)
            If getColumIndex(spr, "cdFactory") > -1 Then z0511.cdFactory = getDataM(spr, getColumIndex(spr, "cdFactory"), xRow)
            If getColumIndex(spr, "seLineProd") > -1 Then z0511.seLineProd = getDataM(spr, getColumIndex(spr, "seLineProd"), xRow)
            If getColumIndex(spr, "cdLineProd") > -1 Then z0511.cdLineProd = getDataM(spr, getColumIndex(spr, "cdLineProd"), xRow)
            If getColumIndex(spr, "LineTno") > -1 Then z0511.LineTno = getDataM(spr, getColumIndex(spr, "LineTno"), xRow)
            If getColumIndex(spr, "DateProduction") > -1 Then z0511.DateProduction = getDataM(spr, getColumIndex(spr, "DateProduction"), xRow)
            If getColumIndex(spr, "STimeProduction") > -1 Then z0511.STimeProduction = getDataM(spr, getColumIndex(spr, "STimeProduction"), xRow)
            If getColumIndex(spr, "ETimeProduction") > -1 Then z0511.ETimeProduction = getDataM(spr, getColumIndex(spr, "ETimeProduction"), xRow)
            If getColumIndex(spr, "InchargeProdution") > -1 Then z0511.InchargeProdution = getDataM(spr, getColumIndex(spr, "InchargeProdution"), xRow)
            If getColumIndex(spr, "seMachineType") > -1 Then z0511.seMachineType = getDataM(spr, getColumIndex(spr, "seMachineType"), xRow)
            If getColumIndex(spr, "cdMachineType") > -1 Then z0511.cdMachineType = getDataM(spr, getColumIndex(spr, "cdMachineType"), xRow)
            If getColumIndex(spr, "MachineCode") > -1 Then z0511.MachineCode = getDataM(spr, getColumIndex(spr, "MachineCode"), xRow)
            If getColumIndex(spr, "PartProduction") > -1 Then z0511.PartProduction = getDataM(spr, getColumIndex(spr, "PartProduction"), xRow)
            If getColumIndex(spr, "QtyInProduction") > -1 Then z0511.QtyInProduction = getDataM(spr, getColumIndex(spr, "QtyInProduction"), xRow)
            If getColumIndex(spr, "QtyProduction") > -1 Then z0511.QtyProduction = getDataM(spr, getColumIndex(spr, "QtyProduction"), xRow)
            If getColumIndex(spr, "QtyProductionA") > -1 Then z0511.QtyProductionA = getDataM(spr, getColumIndex(spr, "QtyProductionA"), xRow)
            If getColumIndex(spr, "QtyProductionX") > -1 Then z0511.QtyProductionX = getDataM(spr, getColumIndex(spr, "QtyProductionX"), xRow)
            If getColumIndex(spr, "QtyProductionXP") > -1 Then z0511.QtyProductionXP = getDataM(spr, getColumIndex(spr, "QtyProductionXP"), xRow)
            If getColumIndex(spr, "QtyProductionXD") > -1 Then z0511.QtyProductionXD = getDataM(spr, getColumIndex(spr, "QtyProductionXD"), xRow)
            If getColumIndex(spr, "QtyProductionXR") > -1 Then z0511.QtyProductionXR = getDataM(spr, getColumIndex(spr, "QtyProductionXR"), xRow)
            If getColumIndex(spr, "QtyOutProduction") > -1 Then z0511.QtyOutProduction = getDataM(spr, getColumIndex(spr, "QtyOutProduction"), xRow)
            If getColumIndex(spr, "AmountProduction") > -1 Then z0511.AmountProduction = getDataM(spr, getColumIndex(spr, "AmountProduction"), xRow)
            If getColumIndex(spr, "AmountProductionReceipt") > -1 Then z0511.AmountProductionReceipt = getDataM(spr, getColumIndex(spr, "AmountProductionReceipt"), xRow)
            If getColumIndex(spr, "ISUD") > -1 Then z0511.ISUD = getDataM(spr, getColumIndex(spr, "ISUD"), xRow)
            If getColumIndex(spr, "CheckComplete") > -1 Then z0511.CheckComplete = getDataM(spr, getColumIndex(spr, "CheckComplete"), xRow)
            If getColumIndex(spr, "CheckTrigger") > -1 Then z0511.CheckTrigger = getDataM(spr, getColumIndex(spr, "CheckTrigger"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z0511.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K0511_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K0511_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z0511 As T0511_AREA, Job As String, PRODDATE As String, PRODSEQ As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K0511_MOVE = False

        Try
            If READ_PFK0511(PRODDATE, PRODSEQ) = True Then
                z0511 = D0511
                K0511_MOVE = True
            Else
                z0511 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0511")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "PRODDATE" : z0511.ProdDate = Children(i).Code
                                Case "PRODSEQ" : z0511.ProdSeq = Children(i).Code
                                Case "SPECNO" : z0511.SpecNo = Children(i).Code
                                Case "SPECNOSEQ" : z0511.SpecNoSeq = Children(i).Code
                                Case "SEMAINPROCESS" : z0511.seMainProcess = Children(i).Code
                                Case "CDMAINPROCESS" : z0511.cdMainProcess = Children(i).Code
                                Case "SESUBPROCESS" : z0511.seSubProcess = Children(i).Code
                                Case "CDSUBPROCESS" : z0511.cdSubProcess = Children(i).Code
                                Case "SEFACTORY" : z0511.seFactory = Children(i).Code
                                Case "CDFACTORY" : z0511.cdFactory = Children(i).Code
                                Case "SELINEPROD" : z0511.seLineProd = Children(i).Code
                                Case "CDLINEPROD" : z0511.cdLineProd = Children(i).Code
                                Case "LINETNO" : z0511.LineTno = Children(i).Code
                                Case "DATEPRODUCTION" : z0511.DateProduction = Children(i).Code
                                Case "STIMEPRODUCTION" : z0511.STimeProduction = Children(i).Code
                                Case "ETIMEPRODUCTION" : z0511.ETimeProduction = Children(i).Code
                                Case "INCHARGEPRODUTION" : z0511.InchargeProdution = Children(i).Code
                                Case "SEMACHINETYPE" : z0511.seMachineType = Children(i).Code
                                Case "CDMACHINETYPE" : z0511.cdMachineType = Children(i).Code
                                Case "MACHINECODE" : z0511.MachineCode = Children(i).Code
                                Case "PARTPRODUCTION" : z0511.PartProduction = Children(i).Code
                                Case "QTYINPRODUCTION" : z0511.QtyInProduction = Children(i).Code
                                Case "QTYPRODUCTION" : z0511.QtyProduction = Children(i).Code
                                Case "QTYPRODUCTIONA" : z0511.QtyProductionA = Children(i).Code
                                Case "QTYPRODUCTIONX" : z0511.QtyProductionX = Children(i).Code
                                Case "QTYPRODUCTIONXP" : z0511.QtyProductionXP = Children(i).Code
                                Case "QTYPRODUCTIONXD" : z0511.QtyProductionXD = Children(i).Code
                                Case "QTYPRODUCTIONXR" : z0511.QtyProductionXR = Children(i).Code
                                Case "QTYOUTPRODUCTION" : z0511.QtyOutProduction = Children(i).Code
                                Case "AMOUNTPRODUCTION" : z0511.AmountProduction = Children(i).Code
                                Case "AMOUNTPRODUCTIONRECEIPT" : z0511.AmountProductionReceipt = Children(i).Code
                                Case "ISUD" : z0511.ISUD = Children(i).Code
                                Case "CHECKCOMPLETE" : z0511.CheckComplete = Children(i).Code
                                Case "CHECKTRIGGER" : z0511.CheckTrigger = Children(i).Code
                                Case "REMARK" : z0511.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "PRODDATE" : z0511.ProdDate = Children(i).Data
                                Case "PRODSEQ" : z0511.ProdSeq = Children(i).Data
                                Case "SPECNO" : z0511.SpecNo = Children(i).Data
                                Case "SPECNOSEQ" : z0511.SpecNoSeq = Children(i).Data
                                Case "SEMAINPROCESS" : z0511.seMainProcess = Children(i).Data
                                Case "CDMAINPROCESS" : z0511.cdMainProcess = Children(i).Data
                                Case "SESUBPROCESS" : z0511.seSubProcess = Children(i).Data
                                Case "CDSUBPROCESS" : z0511.cdSubProcess = Children(i).Data
                                Case "SEFACTORY" : z0511.seFactory = Children(i).Data
                                Case "CDFACTORY" : z0511.cdFactory = Children(i).Data
                                Case "SELINEPROD" : z0511.seLineProd = Children(i).Data
                                Case "CDLINEPROD" : z0511.cdLineProd = Children(i).Data
                                Case "LINETNO" : z0511.LineTno = Children(i).Data
                                Case "DATEPRODUCTION" : z0511.DateProduction = Children(i).Data
                                Case "STIMEPRODUCTION" : z0511.STimeProduction = Children(i).Data
                                Case "ETIMEPRODUCTION" : z0511.ETimeProduction = Children(i).Data
                                Case "INCHARGEPRODUTION" : z0511.InchargeProdution = Children(i).Data
                                Case "SEMACHINETYPE" : z0511.seMachineType = Children(i).Data
                                Case "CDMACHINETYPE" : z0511.cdMachineType = Children(i).Data
                                Case "MACHINECODE" : z0511.MachineCode = Children(i).Data
                                Case "PARTPRODUCTION" : z0511.PartProduction = Children(i).Data
                                Case "QTYINPRODUCTION" : z0511.QtyInProduction = Children(i).Data
                                Case "QTYPRODUCTION" : z0511.QtyProduction = Children(i).Data
                                Case "QTYPRODUCTIONA" : z0511.QtyProductionA = Children(i).Data
                                Case "QTYPRODUCTIONX" : z0511.QtyProductionX = Children(i).Data
                                Case "QTYPRODUCTIONXP" : z0511.QtyProductionXP = Children(i).Data
                                Case "QTYPRODUCTIONXD" : z0511.QtyProductionXD = Children(i).Data
                                Case "QTYPRODUCTIONXR" : z0511.QtyProductionXR = Children(i).Data
                                Case "QTYOUTPRODUCTION" : z0511.QtyOutProduction = Children(i).Data
                                Case "AMOUNTPRODUCTION" : z0511.AmountProduction = Children(i).Data
                                Case "AMOUNTPRODUCTIONRECEIPT" : z0511.AmountProductionReceipt = Children(i).Data
                                Case "ISUD" : z0511.ISUD = Children(i).Data
                                Case "CHECKCOMPLETE" : z0511.CheckComplete = Children(i).Data
                                Case "CHECKTRIGGER" : z0511.CheckTrigger = Children(i).Data
                                Case "REMARK" : z0511.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K0511_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K0511_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z0511 As T0511_AREA, Job As String, CheckClear As Boolean, PRODDATE As String, PRODSEQ As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K0511_MOVE = False

        Try
            If READ_PFK0511(PRODDATE, PRODSEQ) = True Then
                z0511 = D0511
                K0511_MOVE = True
            Else
                If CheckClear = True Then z0511 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0511")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "PRODDATE" : z0511.ProdDate = Children(i).Code
                                Case "PRODSEQ" : z0511.ProdSeq = Children(i).Code
                                Case "SPECNO" : z0511.SpecNo = Children(i).Code
                                Case "SPECNOSEQ" : z0511.SpecNoSeq = Children(i).Code
                                Case "SEMAINPROCESS" : z0511.seMainProcess = Children(i).Code
                                Case "CDMAINPROCESS" : z0511.cdMainProcess = Children(i).Code
                                Case "SESUBPROCESS" : z0511.seSubProcess = Children(i).Code
                                Case "CDSUBPROCESS" : z0511.cdSubProcess = Children(i).Code
                                Case "SEFACTORY" : z0511.seFactory = Children(i).Code
                                Case "CDFACTORY" : z0511.cdFactory = Children(i).Code
                                Case "SELINEPROD" : z0511.seLineProd = Children(i).Code
                                Case "CDLINEPROD" : z0511.cdLineProd = Children(i).Code
                                Case "LINETNO" : z0511.LineTno = Children(i).Code
                                Case "DATEPRODUCTION" : z0511.DateProduction = Children(i).Code
                                Case "STIMEPRODUCTION" : z0511.STimeProduction = Children(i).Code
                                Case "ETIMEPRODUCTION" : z0511.ETimeProduction = Children(i).Code
                                Case "INCHARGEPRODUTION" : z0511.InchargeProdution = Children(i).Code
                                Case "SEMACHINETYPE" : z0511.seMachineType = Children(i).Code
                                Case "CDMACHINETYPE" : z0511.cdMachineType = Children(i).Code
                                Case "MACHINECODE" : z0511.MachineCode = Children(i).Code
                                Case "PARTPRODUCTION" : z0511.PartProduction = Children(i).Code
                                Case "QTYINPRODUCTION" : z0511.QtyInProduction = Children(i).Code
                                Case "QTYPRODUCTION" : z0511.QtyProduction = Children(i).Code
                                Case "QTYPRODUCTIONA" : z0511.QtyProductionA = Children(i).Code
                                Case "QTYPRODUCTIONX" : z0511.QtyProductionX = Children(i).Code
                                Case "QTYPRODUCTIONXP" : z0511.QtyProductionXP = Children(i).Code
                                Case "QTYPRODUCTIONXD" : z0511.QtyProductionXD = Children(i).Code
                                Case "QTYPRODUCTIONXR" : z0511.QtyProductionXR = Children(i).Code
                                Case "QTYOUTPRODUCTION" : z0511.QtyOutProduction = Children(i).Code
                                Case "AMOUNTPRODUCTION" : z0511.AmountProduction = Children(i).Code
                                Case "AMOUNTPRODUCTIONRECEIPT" : z0511.AmountProductionReceipt = Children(i).Code
                                Case "ISUD" : z0511.ISUD = Children(i).Code
                                Case "CHECKCOMPLETE" : z0511.CheckComplete = Children(i).Code
                                Case "CHECKTRIGGER" : z0511.CheckTrigger = Children(i).Code
                                Case "REMARK" : z0511.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "PRODDATE" : z0511.ProdDate = Children(i).Data
                                Case "PRODSEQ" : z0511.ProdSeq = Children(i).Data
                                Case "SPECNO" : z0511.SpecNo = Children(i).Data
                                Case "SPECNOSEQ" : z0511.SpecNoSeq = Children(i).Data
                                Case "SEMAINPROCESS" : z0511.seMainProcess = Children(i).Data
                                Case "CDMAINPROCESS" : z0511.cdMainProcess = Children(i).Data
                                Case "SESUBPROCESS" : z0511.seSubProcess = Children(i).Data
                                Case "CDSUBPROCESS" : z0511.cdSubProcess = Children(i).Data
                                Case "SEFACTORY" : z0511.seFactory = Children(i).Data
                                Case "CDFACTORY" : z0511.cdFactory = Children(i).Data
                                Case "SELINEPROD" : z0511.seLineProd = Children(i).Data
                                Case "CDLINEPROD" : z0511.cdLineProd = Children(i).Data
                                Case "LINETNO" : z0511.LineTno = Children(i).Data
                                Case "DATEPRODUCTION" : z0511.DateProduction = Children(i).Data
                                Case "STIMEPRODUCTION" : z0511.STimeProduction = Children(i).Data
                                Case "ETIMEPRODUCTION" : z0511.ETimeProduction = Children(i).Data
                                Case "INCHARGEPRODUTION" : z0511.InchargeProdution = Children(i).Data
                                Case "SEMACHINETYPE" : z0511.seMachineType = Children(i).Data
                                Case "CDMACHINETYPE" : z0511.cdMachineType = Children(i).Data
                                Case "MACHINECODE" : z0511.MachineCode = Children(i).Data
                                Case "PARTPRODUCTION" : z0511.PartProduction = Children(i).Data
                                Case "QTYINPRODUCTION" : z0511.QtyInProduction = Children(i).Data
                                Case "QTYPRODUCTION" : z0511.QtyProduction = Children(i).Data
                                Case "QTYPRODUCTIONA" : z0511.QtyProductionA = Children(i).Data
                                Case "QTYPRODUCTIONX" : z0511.QtyProductionX = Children(i).Data
                                Case "QTYPRODUCTIONXP" : z0511.QtyProductionXP = Children(i).Data
                                Case "QTYPRODUCTIONXD" : z0511.QtyProductionXD = Children(i).Data
                                Case "QTYPRODUCTIONXR" : z0511.QtyProductionXR = Children(i).Data
                                Case "QTYOUTPRODUCTION" : z0511.QtyOutProduction = Children(i).Data
                                Case "AMOUNTPRODUCTION" : z0511.AmountProduction = Children(i).Data
                                Case "AMOUNTPRODUCTIONRECEIPT" : z0511.AmountProductionReceipt = Children(i).Data
                                Case "ISUD" : z0511.ISUD = Children(i).Data
                                Case "CHECKCOMPLETE" : z0511.CheckComplete = Children(i).Data
                                Case "CHECKTRIGGER" : z0511.CheckTrigger = Children(i).Data
                                Case "REMARK" : z0511.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K0511_MOVE", vbCritical)
        End Try
    End Function

End Module
