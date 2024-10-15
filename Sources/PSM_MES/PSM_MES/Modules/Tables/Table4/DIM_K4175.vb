'=========================================================================================================================================================
'   TABLE : (PFK4175)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K4175

    Structure T4175_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public JobCard As String  '			char(9)		*
        Public Szno As String  '			char(2)		*
        Public cdMainProcess As String  '			char(3)		*
        Public Sno As String  '			char(5)		*
        Public SizeName As String  '			nvarchar(10)
        Public MaterialSeq As Double  '			decimal
        Public BatchNo As String  '			char(10)
        Public BatchGroup As String  '			char(10)
        Public BatchShoes As String  '			char(10)
        Public TypeBatch As String  '			char(1)
        Public cdFactory As String  '			char(3)
        Public MachineCode As String  '			char(6)
        Public MachineTno As String  '			char(2)
        Public cdLineProd As String  '			char(3)
        Public LineTno As String  '			char(2)
        Public DatePrint As String  '			char(8)
        Public DateBatch As String  '			char(8)
        Public InchargeBatch As String  '			char(8)
        Public InchargePrint As String  '			char(8)
        Public QtyBatch As Double  '			decimal
        Public CheckL As String  '			char(1)
        Public CheckR As String  '			char(1)
        Public QtyProduction As Double  '			decimal
        Public QtyProductionA As Double  '			decimal
        Public QtyProductionX As Double  '			decimal
        Public QtyProductionXP As Double  '			decimal
        Public QtyProductionXR As Double  '			decimal
        Public QtyBLOut As Double  '			decimal
        Public QtyBLIn As Double  '			decimal
        Public DateInsert As String  '			char(8)
        Public InchargeInsert As String  '			char(6)
        Public DateUpdate As String  '			char(8)
        Public InchargeUpdate As String  '			char(8)
        Public CheckComplete As String  '			char(1)
        Public Remark As String  '			nvarchar(50)
        '=========================================================================================================================================================
    End Structure

    Public D4175 As T4175_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK4175(JOBCARD As String, SZNO As String, CDMAINPROCESS As String, SNO As String) As Boolean
        READ_PFK4175 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4175 "
            SQL = SQL & " WHERE K4175_JobCard		 = '" & JobCard & "' "
            SQL = SQL & "   AND K4175_Szno		 = '" & Szno & "' "
            SQL = SQL & "   AND K4175_cdMainProcess		 = '" & cdMainProcess & "' "
            SQL = SQL & "   AND K4175_Sno		 = '" & Sno & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4175_CLEAR() : GoTo SKIP_READ_PFK4175

            Call K4175_MOVE(rd)
            READ_PFK4175 = True

SKIP_READ_PFK4175:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4175", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK4175(JOBCARD As String, SZNO As String, CDMAINPROCESS As String, SNO As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4175 "
            SQL = SQL & " WHERE K4175_JobCard		 = '" & JobCard & "' "
            SQL = SQL & "   AND K4175_Szno		 = '" & Szno & "' "
            SQL = SQL & "   AND K4175_cdMainProcess		 = '" & cdMainProcess & "' "
            SQL = SQL & "   AND K4175_Sno		 = '" & Sno & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK4175", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK4175(z4175 As T4175_AREA) As Boolean
        WRITE_PFK4175 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z4175)

            SQL = " INSERT INTO PFK4175 "
            SQL = SQL & " ( "
            SQL = SQL & " K4175_JobCard,"
            SQL = SQL & " K4175_Szno,"
            SQL = SQL & " K4175_cdMainProcess,"
            SQL = SQL & " K4175_Sno,"
            SQL = SQL & " K4175_SizeName,"
            SQL = SQL & " K4175_MaterialSeq,"
            SQL = SQL & " K4175_BatchNo,"
            SQL = SQL & " K4175_BatchGroup,"
            SQL = SQL & " K4175_BatchShoes,"
            SQL = SQL & " K4175_TypeBatch,"
            SQL = SQL & " K4175_cdFactory,"
            SQL = SQL & " K4175_MachineCode,"
            SQL = SQL & " K4175_MachineTno,"
            SQL = SQL & " K4175_cdLineProd,"
            SQL = SQL & " K4175_LineTno,"
            SQL = SQL & " K4175_DatePrint,"
            SQL = SQL & " K4175_DateBatch,"
            SQL = SQL & " K4175_InchargeBatch,"
            SQL = SQL & " K4175_InchargePrint,"
            SQL = SQL & " K4175_QtyBatch,"
            SQL = SQL & " K4175_CheckL,"
            SQL = SQL & " K4175_CheckR,"
            SQL = SQL & " K4175_QtyProduction,"
            SQL = SQL & " K4175_QtyProductionA,"
            SQL = SQL & " K4175_QtyProductionX,"
            SQL = SQL & " K4175_QtyProductionXP,"
            SQL = SQL & " K4175_QtyProductionXR,"
            SQL = SQL & " K4175_QtyBLOut,"
            SQL = SQL & " K4175_QtyBLIn,"
            SQL = SQL & " K4175_DateInsert,"
            SQL = SQL & " K4175_InchargeInsert,"
            SQL = SQL & " K4175_DateUpdate,"
            SQL = SQL & " K4175_InchargeUpdate,"
            SQL = SQL & " K4175_CheckComplete,"
            SQL = SQL & " K4175_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z4175.JobCard) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4175.Szno) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4175.cdMainProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4175.Sno) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4175.SizeName) & "', "
            SQL = SQL & "   " & FormatSQL(z4175.MaterialSeq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z4175.BatchNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4175.BatchGroup) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4175.BatchShoes) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4175.TypeBatch) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4175.cdFactory) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4175.MachineCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4175.MachineTno) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4175.cdLineProd) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4175.LineTno) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4175.DatePrint) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4175.DateBatch) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4175.InchargeBatch) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4175.InchargePrint) & "', "
            SQL = SQL & "   " & FormatSQL(z4175.QtyBatch) & ", "
            SQL = SQL & "  N'" & FormatSQL(z4175.CheckL) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4175.CheckR) & "', "
            SQL = SQL & "   " & FormatSQL(z4175.QtyProduction) & ", "
            SQL = SQL & "   " & FormatSQL(z4175.QtyProductionA) & ", "
            SQL = SQL & "   " & FormatSQL(z4175.QtyProductionX) & ", "
            SQL = SQL & "   " & FormatSQL(z4175.QtyProductionXP) & ", "
            SQL = SQL & "   " & FormatSQL(z4175.QtyProductionXR) & ", "
            SQL = SQL & "   " & FormatSQL(z4175.QtyBLOut) & ", "
            SQL = SQL & "   " & FormatSQL(z4175.QtyBLIn) & ", "
            SQL = SQL & "  N'" & FormatSQL(z4175.DateInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4175.InchargeInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4175.DateUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4175.InchargeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4175.CheckComplete) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4175.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK4175 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK4175", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK4175(z4175 As T4175_AREA) As Boolean
        REWRITE_PFK4175 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z4175)

            SQL = " UPDATE PFK4175 SET "
            SQL = SQL & "    K4175_SizeName      = N'" & FormatSQL(z4175.SizeName) & "', "
            SQL = SQL & "    K4175_MaterialSeq      =  " & FormatSQL(z4175.MaterialSeq) & ", "
            SQL = SQL & "    K4175_BatchNo      = N'" & FormatSQL(z4175.BatchNo) & "', "
            SQL = SQL & "    K4175_BatchGroup      = N'" & FormatSQL(z4175.BatchGroup) & "', "
            SQL = SQL & "    K4175_BatchShoes      = N'" & FormatSQL(z4175.BatchShoes) & "', "
            SQL = SQL & "    K4175_TypeBatch      = N'" & FormatSQL(z4175.TypeBatch) & "', "
            SQL = SQL & "    K4175_cdFactory      = N'" & FormatSQL(z4175.cdFactory) & "', "
            SQL = SQL & "    K4175_MachineCode      = N'" & FormatSQL(z4175.MachineCode) & "', "
            SQL = SQL & "    K4175_MachineTno      = N'" & FormatSQL(z4175.MachineTno) & "', "
            SQL = SQL & "    K4175_cdLineProd      = N'" & FormatSQL(z4175.cdLineProd) & "', "
            SQL = SQL & "    K4175_LineTno      = N'" & FormatSQL(z4175.LineTno) & "', "
            SQL = SQL & "    K4175_DatePrint      = N'" & FormatSQL(z4175.DatePrint) & "', "
            SQL = SQL & "    K4175_DateBatch      = N'" & FormatSQL(z4175.DateBatch) & "', "
            SQL = SQL & "    K4175_InchargeBatch      = N'" & FormatSQL(z4175.InchargeBatch) & "', "
            SQL = SQL & "    K4175_InchargePrint      = N'" & FormatSQL(z4175.InchargePrint) & "', "
            SQL = SQL & "    K4175_QtyBatch      =  " & FormatSQL(z4175.QtyBatch) & ", "
            SQL = SQL & "    K4175_CheckL      = N'" & FormatSQL(z4175.CheckL) & "', "
            SQL = SQL & "    K4175_CheckR      = N'" & FormatSQL(z4175.CheckR) & "', "
            SQL = SQL & "    K4175_QtyProduction      =  " & FormatSQL(z4175.QtyProduction) & ", "
            SQL = SQL & "    K4175_QtyProductionA      =  " & FormatSQL(z4175.QtyProductionA) & ", "
            SQL = SQL & "    K4175_QtyProductionX      =  " & FormatSQL(z4175.QtyProductionX) & ", "
            SQL = SQL & "    K4175_QtyProductionXP      =  " & FormatSQL(z4175.QtyProductionXP) & ", "
            SQL = SQL & "    K4175_QtyProductionXR      =  " & FormatSQL(z4175.QtyProductionXR) & ", "
            SQL = SQL & "    K4175_QtyBLOut      =  " & FormatSQL(z4175.QtyBLOut) & ", "
            SQL = SQL & "    K4175_QtyBLIn      =  " & FormatSQL(z4175.QtyBLIn) & ", "
            SQL = SQL & "    K4175_DateInsert      = N'" & FormatSQL(z4175.DateInsert) & "', "
            SQL = SQL & "    K4175_InchargeInsert      = N'" & FormatSQL(z4175.InchargeInsert) & "', "
            SQL = SQL & "    K4175_DateUpdate      = N'" & FormatSQL(z4175.DateUpdate) & "', "
            SQL = SQL & "    K4175_InchargeUpdate      = N'" & FormatSQL(z4175.InchargeUpdate) & "', "
            SQL = SQL & "    K4175_CheckComplete      = N'" & FormatSQL(z4175.CheckComplete) & "', "
            SQL = SQL & "    K4175_Remark      = N'" & FormatSQL(z4175.Remark) & "'  "
            SQL = SQL & " WHERE K4175_JobCard		 = '" & z4175.JobCard & "' "
            SQL = SQL & "   AND K4175_Szno		 = '" & z4175.Szno & "' "
            SQL = SQL & "   AND K4175_cdMainProcess		 = '" & z4175.cdMainProcess & "' "
            SQL = SQL & "   AND K4175_Sno		 = '" & z4175.Sno & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK4175 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK4175", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK4175(z4175 As T4175_AREA) As Boolean
        DELETE_PFK4175 = False

        'Dim cmd As SqlClient.SqlCommand
        'Dim SQL As String
        'Try
        '    SQL = " DELETE FROM PFK4175 "
        '    SQL = SQL & " WHERE K4175_JobCard		 = '" & z4175.JobCard & "' "
        '    SQL = SQL & "   AND K4175_Szno		 = '" & z4175.Szno & "' "
        '    SQL = SQL & "   AND K4175_cdMainProcess		 = '" & z4175.cdMainProcess & "' "
        '    SQL = SQL & "   AND K4175_Sno		 = '" & z4175.Sno & "' "
        '    cmd = New SqlClient.SqlCommand(SQL, cn)
        '    cmd.ExecuteNonQuery()

        '    DELETE_PFK4175 = True
        '    Exit Function
        'Catch ex As Exception
        '    Call MsgBoxP("DELETE_PFK4175", vbCritical)
        'End Try
    End Function

    Public Function DELETE_PFK4175_ZZZ(z4175 As T4175_AREA) As Boolean
        DELETE_PFK4175_ZZZ = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK4175 "
            SQL = SQL & " WHERE K4175_BatchGroup		 = '" & z4175.BatchGroup & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK4175_ZZZ = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK4175", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D4175_CLEAR()
        Try

            D4175.JobCard = ""
            D4175.Szno = ""
            D4175.cdMainProcess = ""
            D4175.Sno = ""
            D4175.SizeName = ""
            D4175.MaterialSeq = 0
            D4175.BatchNo = ""
            D4175.BatchGroup = ""
            D4175.BatchShoes = ""
            D4175.TypeBatch = ""
            D4175.cdFactory = ""
            D4175.MachineCode = ""
            D4175.MachineTno = ""
            D4175.cdLineProd = ""
            D4175.LineTno = ""
            D4175.DatePrint = ""
            D4175.DateBatch = ""
            D4175.InchargeBatch = ""
            D4175.InchargePrint = ""
            D4175.QtyBatch = 0
            D4175.CheckL = ""
            D4175.CheckR = ""
            D4175.QtyProduction = 0
            D4175.QtyProductionA = 0
            D4175.QtyProductionX = 0
            D4175.QtyProductionXP = 0
            D4175.QtyProductionXR = 0
            D4175.QtyBLOut = 0
            D4175.QtyBLIn = 0
            D4175.DateInsert = ""
            D4175.InchargeInsert = ""
            D4175.DateUpdate = ""
            D4175.InchargeUpdate = ""
            D4175.CheckComplete = ""
            D4175.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D4175_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x4175 As T4175_AREA)
        Try

            x4175.JobCard = trim$(x4175.JobCard)
            x4175.Szno = trim$(x4175.Szno)
            x4175.cdMainProcess = trim$(x4175.cdMainProcess)
            x4175.Sno = trim$(x4175.Sno)
            x4175.SizeName = trim$(x4175.SizeName)
            x4175.MaterialSeq = trim$(x4175.MaterialSeq)
            x4175.BatchNo = trim$(x4175.BatchNo)
            x4175.BatchGroup = trim$(x4175.BatchGroup)
            x4175.BatchShoes = trim$(x4175.BatchShoes)
            x4175.TypeBatch = trim$(x4175.TypeBatch)
            x4175.cdFactory = trim$(x4175.cdFactory)
            x4175.MachineCode = trim$(x4175.MachineCode)
            x4175.MachineTno = trim$(x4175.MachineTno)
            x4175.cdLineProd = trim$(x4175.cdLineProd)
            x4175.LineTno = trim$(x4175.LineTno)
            x4175.DatePrint = trim$(x4175.DatePrint)
            x4175.DateBatch = trim$(x4175.DateBatch)
            x4175.InchargeBatch = trim$(x4175.InchargeBatch)
            x4175.InchargePrint = trim$(x4175.InchargePrint)
            x4175.QtyBatch = trim$(x4175.QtyBatch)
            x4175.CheckL = trim$(x4175.CheckL)
            x4175.CheckR = trim$(x4175.CheckR)
            x4175.QtyProduction = trim$(x4175.QtyProduction)
            x4175.QtyProductionA = trim$(x4175.QtyProductionA)
            x4175.QtyProductionX = trim$(x4175.QtyProductionX)
            x4175.QtyProductionXP = trim$(x4175.QtyProductionXP)
            x4175.QtyProductionXR = trim$(x4175.QtyProductionXR)
            x4175.QtyBLOut = trim$(x4175.QtyBLOut)
            x4175.QtyBLIn = trim$(x4175.QtyBLIn)
            x4175.DateInsert = trim$(x4175.DateInsert)
            x4175.InchargeInsert = trim$(x4175.InchargeInsert)
            x4175.DateUpdate = trim$(x4175.DateUpdate)
            x4175.InchargeUpdate = trim$(x4175.InchargeUpdate)
            x4175.CheckComplete = trim$(x4175.CheckComplete)
            x4175.Remark = trim$(x4175.Remark)

            If trim$(x4175.JobCard) = "" Then x4175.JobCard = Space(1)
            If trim$(x4175.Szno) = "" Then x4175.Szno = Space(1)
            If trim$(x4175.cdMainProcess) = "" Then x4175.cdMainProcess = Space(1)
            If trim$(x4175.Sno) = "" Then x4175.Sno = Space(1)
            If trim$(x4175.SizeName) = "" Then x4175.SizeName = Space(1)
            If trim$(x4175.MaterialSeq) = "" Then x4175.MaterialSeq = 0
            If trim$(x4175.BatchNo) = "" Then x4175.BatchNo = Space(1)
            If trim$(x4175.BatchGroup) = "" Then x4175.BatchGroup = Space(1)
            If trim$(x4175.BatchShoes) = "" Then x4175.BatchShoes = Space(1)
            If trim$(x4175.TypeBatch) = "" Then x4175.TypeBatch = Space(1)
            If trim$(x4175.cdFactory) = "" Then x4175.cdFactory = Space(1)
            If trim$(x4175.MachineCode) = "" Then x4175.MachineCode = Space(1)
            If trim$(x4175.MachineTno) = "" Then x4175.MachineTno = Space(1)
            If trim$(x4175.cdLineProd) = "" Then x4175.cdLineProd = Space(1)
            If trim$(x4175.LineTno) = "" Then x4175.LineTno = Space(1)
            If trim$(x4175.DatePrint) = "" Then x4175.DatePrint = Space(1)
            If trim$(x4175.DateBatch) = "" Then x4175.DateBatch = Space(1)
            If trim$(x4175.InchargeBatch) = "" Then x4175.InchargeBatch = Space(1)
            If trim$(x4175.InchargePrint) = "" Then x4175.InchargePrint = Space(1)
            If trim$(x4175.QtyBatch) = "" Then x4175.QtyBatch = 0
            If trim$(x4175.CheckL) = "" Then x4175.CheckL = Space(1)
            If trim$(x4175.CheckR) = "" Then x4175.CheckR = Space(1)
            If trim$(x4175.QtyProduction) = "" Then x4175.QtyProduction = 0
            If trim$(x4175.QtyProductionA) = "" Then x4175.QtyProductionA = 0
            If trim$(x4175.QtyProductionX) = "" Then x4175.QtyProductionX = 0
            If trim$(x4175.QtyProductionXP) = "" Then x4175.QtyProductionXP = 0
            If trim$(x4175.QtyProductionXR) = "" Then x4175.QtyProductionXR = 0
            If trim$(x4175.QtyBLOut) = "" Then x4175.QtyBLOut = 0
            If trim$(x4175.QtyBLIn) = "" Then x4175.QtyBLIn = 0
            If trim$(x4175.DateInsert) = "" Then x4175.DateInsert = Space(1)
            If trim$(x4175.InchargeInsert) = "" Then x4175.InchargeInsert = Space(1)
            If trim$(x4175.DateUpdate) = "" Then x4175.DateUpdate = Space(1)
            If trim$(x4175.InchargeUpdate) = "" Then x4175.InchargeUpdate = Space(1)
            If trim$(x4175.CheckComplete) = "" Then x4175.CheckComplete = Space(1)
            If trim$(x4175.Remark) = "" Then x4175.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K4175_MOVE(rs4175 As SqlClient.SqlDataReader)
        Try

            Call D4175_CLEAR()

            If IsdbNull(rs4175!K4175_JobCard) = False Then D4175.JobCard = Trim$(rs4175!K4175_JobCard)
            If IsdbNull(rs4175!K4175_Szno) = False Then D4175.Szno = Trim$(rs4175!K4175_Szno)
            If IsdbNull(rs4175!K4175_cdMainProcess) = False Then D4175.cdMainProcess = Trim$(rs4175!K4175_cdMainProcess)
            If IsdbNull(rs4175!K4175_Sno) = False Then D4175.Sno = Trim$(rs4175!K4175_Sno)
            If IsdbNull(rs4175!K4175_SizeName) = False Then D4175.SizeName = Trim$(rs4175!K4175_SizeName)
            If IsdbNull(rs4175!K4175_MaterialSeq) = False Then D4175.MaterialSeq = Trim$(rs4175!K4175_MaterialSeq)
            If IsdbNull(rs4175!K4175_BatchNo) = False Then D4175.BatchNo = Trim$(rs4175!K4175_BatchNo)
            If IsdbNull(rs4175!K4175_BatchGroup) = False Then D4175.BatchGroup = Trim$(rs4175!K4175_BatchGroup)
            If IsdbNull(rs4175!K4175_BatchShoes) = False Then D4175.BatchShoes = Trim$(rs4175!K4175_BatchShoes)
            If IsdbNull(rs4175!K4175_TypeBatch) = False Then D4175.TypeBatch = Trim$(rs4175!K4175_TypeBatch)
            If IsdbNull(rs4175!K4175_cdFactory) = False Then D4175.cdFactory = Trim$(rs4175!K4175_cdFactory)
            If IsdbNull(rs4175!K4175_MachineCode) = False Then D4175.MachineCode = Trim$(rs4175!K4175_MachineCode)
            If IsdbNull(rs4175!K4175_MachineTno) = False Then D4175.MachineTno = Trim$(rs4175!K4175_MachineTno)
            If IsdbNull(rs4175!K4175_cdLineProd) = False Then D4175.cdLineProd = Trim$(rs4175!K4175_cdLineProd)
            If IsdbNull(rs4175!K4175_LineTno) = False Then D4175.LineTno = Trim$(rs4175!K4175_LineTno)
            If IsdbNull(rs4175!K4175_DatePrint) = False Then D4175.DatePrint = Trim$(rs4175!K4175_DatePrint)
            If IsdbNull(rs4175!K4175_DateBatch) = False Then D4175.DateBatch = Trim$(rs4175!K4175_DateBatch)
            If IsdbNull(rs4175!K4175_InchargeBatch) = False Then D4175.InchargeBatch = Trim$(rs4175!K4175_InchargeBatch)
            If IsdbNull(rs4175!K4175_InchargePrint) = False Then D4175.InchargePrint = Trim$(rs4175!K4175_InchargePrint)
            If IsdbNull(rs4175!K4175_QtyBatch) = False Then D4175.QtyBatch = Trim$(rs4175!K4175_QtyBatch)
            If IsdbNull(rs4175!K4175_CheckL) = False Then D4175.CheckL = Trim$(rs4175!K4175_CheckL)
            If IsdbNull(rs4175!K4175_CheckR) = False Then D4175.CheckR = Trim$(rs4175!K4175_CheckR)
            If IsdbNull(rs4175!K4175_QtyProduction) = False Then D4175.QtyProduction = Trim$(rs4175!K4175_QtyProduction)
            If IsdbNull(rs4175!K4175_QtyProductionA) = False Then D4175.QtyProductionA = Trim$(rs4175!K4175_QtyProductionA)
            If IsdbNull(rs4175!K4175_QtyProductionX) = False Then D4175.QtyProductionX = Trim$(rs4175!K4175_QtyProductionX)
            If IsdbNull(rs4175!K4175_QtyProductionXP) = False Then D4175.QtyProductionXP = Trim$(rs4175!K4175_QtyProductionXP)
            If IsdbNull(rs4175!K4175_QtyProductionXR) = False Then D4175.QtyProductionXR = Trim$(rs4175!K4175_QtyProductionXR)
            If IsdbNull(rs4175!K4175_QtyBLOut) = False Then D4175.QtyBLOut = Trim$(rs4175!K4175_QtyBLOut)
            If IsdbNull(rs4175!K4175_QtyBLIn) = False Then D4175.QtyBLIn = Trim$(rs4175!K4175_QtyBLIn)
            If IsdbNull(rs4175!K4175_DateInsert) = False Then D4175.DateInsert = Trim$(rs4175!K4175_DateInsert)
            If IsdbNull(rs4175!K4175_InchargeInsert) = False Then D4175.InchargeInsert = Trim$(rs4175!K4175_InchargeInsert)
            If IsdbNull(rs4175!K4175_DateUpdate) = False Then D4175.DateUpdate = Trim$(rs4175!K4175_DateUpdate)
            If IsdbNull(rs4175!K4175_InchargeUpdate) = False Then D4175.InchargeUpdate = Trim$(rs4175!K4175_InchargeUpdate)
            If IsdbNull(rs4175!K4175_CheckComplete) = False Then D4175.CheckComplete = Trim$(rs4175!K4175_CheckComplete)
            If IsdbNull(rs4175!K4175_Remark) = False Then D4175.Remark = Trim$(rs4175!K4175_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K4175_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K4175_MOVE(rs4175 As DataRow)
        Try

            Call D4175_CLEAR()

            If IsdbNull(rs4175!K4175_JobCard) = False Then D4175.JobCard = Trim$(rs4175!K4175_JobCard)
            If IsdbNull(rs4175!K4175_Szno) = False Then D4175.Szno = Trim$(rs4175!K4175_Szno)
            If IsdbNull(rs4175!K4175_cdMainProcess) = False Then D4175.cdMainProcess = Trim$(rs4175!K4175_cdMainProcess)
            If IsdbNull(rs4175!K4175_Sno) = False Then D4175.Sno = Trim$(rs4175!K4175_Sno)
            If IsdbNull(rs4175!K4175_SizeName) = False Then D4175.SizeName = Trim$(rs4175!K4175_SizeName)
            If IsdbNull(rs4175!K4175_MaterialSeq) = False Then D4175.MaterialSeq = Trim$(rs4175!K4175_MaterialSeq)
            If IsdbNull(rs4175!K4175_BatchNo) = False Then D4175.BatchNo = Trim$(rs4175!K4175_BatchNo)
            If IsdbNull(rs4175!K4175_BatchGroup) = False Then D4175.BatchGroup = Trim$(rs4175!K4175_BatchGroup)
            If IsdbNull(rs4175!K4175_BatchShoes) = False Then D4175.BatchShoes = Trim$(rs4175!K4175_BatchShoes)
            If IsdbNull(rs4175!K4175_TypeBatch) = False Then D4175.TypeBatch = Trim$(rs4175!K4175_TypeBatch)
            If IsdbNull(rs4175!K4175_cdFactory) = False Then D4175.cdFactory = Trim$(rs4175!K4175_cdFactory)
            If IsdbNull(rs4175!K4175_MachineCode) = False Then D4175.MachineCode = Trim$(rs4175!K4175_MachineCode)
            If IsdbNull(rs4175!K4175_MachineTno) = False Then D4175.MachineTno = Trim$(rs4175!K4175_MachineTno)
            If IsdbNull(rs4175!K4175_cdLineProd) = False Then D4175.cdLineProd = Trim$(rs4175!K4175_cdLineProd)
            If IsdbNull(rs4175!K4175_LineTno) = False Then D4175.LineTno = Trim$(rs4175!K4175_LineTno)
            If IsdbNull(rs4175!K4175_DatePrint) = False Then D4175.DatePrint = Trim$(rs4175!K4175_DatePrint)
            If IsdbNull(rs4175!K4175_DateBatch) = False Then D4175.DateBatch = Trim$(rs4175!K4175_DateBatch)
            If IsdbNull(rs4175!K4175_InchargeBatch) = False Then D4175.InchargeBatch = Trim$(rs4175!K4175_InchargeBatch)
            If IsdbNull(rs4175!K4175_InchargePrint) = False Then D4175.InchargePrint = Trim$(rs4175!K4175_InchargePrint)
            If IsdbNull(rs4175!K4175_QtyBatch) = False Then D4175.QtyBatch = Trim$(rs4175!K4175_QtyBatch)
            If IsdbNull(rs4175!K4175_CheckL) = False Then D4175.CheckL = Trim$(rs4175!K4175_CheckL)
            If IsdbNull(rs4175!K4175_CheckR) = False Then D4175.CheckR = Trim$(rs4175!K4175_CheckR)
            If IsdbNull(rs4175!K4175_QtyProduction) = False Then D4175.QtyProduction = Trim$(rs4175!K4175_QtyProduction)
            If IsdbNull(rs4175!K4175_QtyProductionA) = False Then D4175.QtyProductionA = Trim$(rs4175!K4175_QtyProductionA)
            If IsdbNull(rs4175!K4175_QtyProductionX) = False Then D4175.QtyProductionX = Trim$(rs4175!K4175_QtyProductionX)
            If IsdbNull(rs4175!K4175_QtyProductionXP) = False Then D4175.QtyProductionXP = Trim$(rs4175!K4175_QtyProductionXP)
            If IsdbNull(rs4175!K4175_QtyProductionXR) = False Then D4175.QtyProductionXR = Trim$(rs4175!K4175_QtyProductionXR)
            If IsdbNull(rs4175!K4175_QtyBLOut) = False Then D4175.QtyBLOut = Trim$(rs4175!K4175_QtyBLOut)
            If IsdbNull(rs4175!K4175_QtyBLIn) = False Then D4175.QtyBLIn = Trim$(rs4175!K4175_QtyBLIn)
            If IsdbNull(rs4175!K4175_DateInsert) = False Then D4175.DateInsert = Trim$(rs4175!K4175_DateInsert)
            If IsdbNull(rs4175!K4175_InchargeInsert) = False Then D4175.InchargeInsert = Trim$(rs4175!K4175_InchargeInsert)
            If IsdbNull(rs4175!K4175_DateUpdate) = False Then D4175.DateUpdate = Trim$(rs4175!K4175_DateUpdate)
            If IsdbNull(rs4175!K4175_InchargeUpdate) = False Then D4175.InchargeUpdate = Trim$(rs4175!K4175_InchargeUpdate)
            If IsdbNull(rs4175!K4175_CheckComplete) = False Then D4175.CheckComplete = Trim$(rs4175!K4175_CheckComplete)
            If IsdbNull(rs4175!K4175_Remark) = False Then D4175.Remark = Trim$(rs4175!K4175_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K4175_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K4175_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z4175 As T4175_AREA, JOBCARD As String, SZNO As String, CDMAINPROCESS As String, SNO As String) As Boolean

        K4175_MOVE = False

        Try
            If READ_PFK4175(JOBCARD, SZNO, CDMAINPROCESS, SNO) = True Then
                z4175 = D4175
                K4175_MOVE = True
            Else
                z4175 = Nothing
            End If

            If getColumIndex(spr, "JobCard") > -1 Then z4175.JobCard = getDataM(spr, getColumIndex(spr, "JobCard"), xRow)
            If getColumIndex(spr, "Szno") > -1 Then z4175.Szno = getDataM(spr, getColumIndex(spr, "Szno"), xRow)
            If getColumIndex(spr, "cdMainProcess") > -1 Then z4175.cdMainProcess = getDataM(spr, getColumIndex(spr, "cdMainProcess"), xRow)
            If getColumIndex(spr, "Sno") > -1 Then z4175.Sno = getDataM(spr, getColumIndex(spr, "Sno"), xRow)
            If getColumIndex(spr, "SizeName") > -1 Then z4175.SizeName = getDataM(spr, getColumIndex(spr, "SizeName"), xRow)
            If getColumIndex(spr, "MaterialSeq") > -1 Then z4175.MaterialSeq = getDataM(spr, getColumIndex(spr, "MaterialSeq"), xRow)
            If getColumIndex(spr, "BatchNo") > -1 Then z4175.BatchNo = getDataM(spr, getColumIndex(spr, "BatchNo"), xRow)
            If getColumIndex(spr, "BatchGroup") > -1 Then z4175.BatchGroup = getDataM(spr, getColumIndex(spr, "BatchGroup"), xRow)
            If getColumIndex(spr, "BatchShoes") > -1 Then z4175.BatchShoes = getDataM(spr, getColumIndex(spr, "BatchShoes"), xRow)
            If getColumIndex(spr, "TypeBatch") > -1 Then z4175.TypeBatch = getDataM(spr, getColumIndex(spr, "TypeBatch"), xRow)
            If getColumIndex(spr, "cdFactory") > -1 Then z4175.cdFactory = getDataM(spr, getColumIndex(spr, "cdFactory"), xRow)
            If getColumIndex(spr, "MachineCode") > -1 Then z4175.MachineCode = getDataM(spr, getColumIndex(spr, "MachineCode"), xRow)
            If getColumIndex(spr, "MachineTno") > -1 Then z4175.MachineTno = getDataM(spr, getColumIndex(spr, "MachineTno"), xRow)
            If getColumIndex(spr, "cdLineProd") > -1 Then z4175.cdLineProd = getDataM(spr, getColumIndex(spr, "cdLineProd"), xRow)
            If getColumIndex(spr, "LineTno") > -1 Then z4175.LineTno = getDataM(spr, getColumIndex(spr, "LineTno"), xRow)
            If getColumIndex(spr, "DatePrint") > -1 Then z4175.DatePrint = getDataM(spr, getColumIndex(spr, "DatePrint"), xRow)
            If getColumIndex(spr, "DateBatch") > -1 Then z4175.DateBatch = getDataM(spr, getColumIndex(spr, "DateBatch"), xRow)
            If getColumIndex(spr, "InchargeBatch") > -1 Then z4175.InchargeBatch = getDataM(spr, getColumIndex(spr, "InchargeBatch"), xRow)
            If getColumIndex(spr, "InchargePrint") > -1 Then z4175.InchargePrint = getDataM(spr, getColumIndex(spr, "InchargePrint"), xRow)
            If getColumIndex(spr, "QtyBatch") > -1 Then z4175.QtyBatch = getDataM(spr, getColumIndex(spr, "QtyBatch"), xRow)
            If getColumIndex(spr, "CheckL") > -1 Then z4175.CheckL = getDataM(spr, getColumIndex(spr, "CheckL"), xRow)
            If getColumIndex(spr, "CheckR") > -1 Then z4175.CheckR = getDataM(spr, getColumIndex(spr, "CheckR"), xRow)
            If getColumIndex(spr, "QtyProduction") > -1 Then z4175.QtyProduction = getDataM(spr, getColumIndex(spr, "QtyProduction"), xRow)
            If getColumIndex(spr, "QtyProductionA") > -1 Then z4175.QtyProductionA = getDataM(spr, getColumIndex(spr, "QtyProductionA"), xRow)
            If getColumIndex(spr, "QtyProductionX") > -1 Then z4175.QtyProductionX = getDataM(spr, getColumIndex(spr, "QtyProductionX"), xRow)
            If getColumIndex(spr, "QtyProductionXP") > -1 Then z4175.QtyProductionXP = getDataM(spr, getColumIndex(spr, "QtyProductionXP"), xRow)
            If getColumIndex(spr, "QtyProductionXR") > -1 Then z4175.QtyProductionXR = getDataM(spr, getColumIndex(spr, "QtyProductionXR"), xRow)
            If getColumIndex(spr, "QtyBLOut") > -1 Then z4175.QtyBLOut = getDataM(spr, getColumIndex(spr, "QtyBLOut"), xRow)
            If getColumIndex(spr, "QtyBLIn") > -1 Then z4175.QtyBLIn = getDataM(spr, getColumIndex(spr, "QtyBLIn"), xRow)
            If getColumIndex(spr, "DateInsert") > -1 Then z4175.DateInsert = getDataM(spr, getColumIndex(spr, "DateInsert"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z4175.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "DateUpdate") > -1 Then z4175.DateUpdate = getDataM(spr, getColumIndex(spr, "DateUpdate"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z4175.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)
            If getColumIndex(spr, "CheckComplete") > -1 Then z4175.CheckComplete = getDataM(spr, getColumIndex(spr, "CheckComplete"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z4175.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4175_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K4175_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z4175 As T4175_AREA, CheckClear As Boolean, JOBCARD As String, SZNO As String, CDMAINPROCESS As String, SNO As String) As Boolean

        K4175_MOVE = False

        Try
            If READ_PFK4175(JOBCARD, SZNO, CDMAINPROCESS, SNO) = True Then
                z4175 = D4175
                K4175_MOVE = True
            Else
                If CheckClear = True Then z4175 = Nothing
            End If

            If getColumIndex(spr, "JobCard") > -1 Then z4175.JobCard = getDataM(spr, getColumIndex(spr, "JobCard"), xRow)
            If getColumIndex(spr, "Szno") > -1 Then z4175.Szno = getDataM(spr, getColumIndex(spr, "Szno"), xRow)
            If getColumIndex(spr, "cdMainProcess") > -1 Then z4175.cdMainProcess = getDataM(spr, getColumIndex(spr, "cdMainProcess"), xRow)
            If getColumIndex(spr, "Sno") > -1 Then z4175.Sno = getDataM(spr, getColumIndex(spr, "Sno"), xRow)
            If getColumIndex(spr, "SizeName") > -1 Then z4175.SizeName = getDataM(spr, getColumIndex(spr, "SizeName"), xRow)
            If getColumIndex(spr, "MaterialSeq") > -1 Then z4175.MaterialSeq = getDataM(spr, getColumIndex(spr, "MaterialSeq"), xRow)
            If getColumIndex(spr, "BatchNo") > -1 Then z4175.BatchNo = getDataM(spr, getColumIndex(spr, "BatchNo"), xRow)
            If getColumIndex(spr, "BatchGroup") > -1 Then z4175.BatchGroup = getDataM(spr, getColumIndex(spr, "BatchGroup"), xRow)
            If getColumIndex(spr, "BatchShoes") > -1 Then z4175.BatchShoes = getDataM(spr, getColumIndex(spr, "BatchShoes"), xRow)
            If getColumIndex(spr, "TypeBatch") > -1 Then z4175.TypeBatch = getDataM(spr, getColumIndex(spr, "TypeBatch"), xRow)
            If getColumIndex(spr, "cdFactory") > -1 Then z4175.cdFactory = getDataM(spr, getColumIndex(spr, "cdFactory"), xRow)
            If getColumIndex(spr, "MachineCode") > -1 Then z4175.MachineCode = getDataM(spr, getColumIndex(spr, "MachineCode"), xRow)
            If getColumIndex(spr, "MachineTno") > -1 Then z4175.MachineTno = getDataM(spr, getColumIndex(spr, "MachineTno"), xRow)
            If getColumIndex(spr, "cdLineProd") > -1 Then z4175.cdLineProd = getDataM(spr, getColumIndex(spr, "cdLineProd"), xRow)
            If getColumIndex(spr, "LineTno") > -1 Then z4175.LineTno = getDataM(spr, getColumIndex(spr, "LineTno"), xRow)
            If getColumIndex(spr, "DatePrint") > -1 Then z4175.DatePrint = getDataM(spr, getColumIndex(spr, "DatePrint"), xRow)
            If getColumIndex(spr, "DateBatch") > -1 Then z4175.DateBatch = getDataM(spr, getColumIndex(spr, "DateBatch"), xRow)
            If getColumIndex(spr, "InchargeBatch") > -1 Then z4175.InchargeBatch = getDataM(spr, getColumIndex(spr, "InchargeBatch"), xRow)
            If getColumIndex(spr, "InchargePrint") > -1 Then z4175.InchargePrint = getDataM(spr, getColumIndex(spr, "InchargePrint"), xRow)
            If getColumIndex(spr, "QtyBatch") > -1 Then z4175.QtyBatch = getDataM(spr, getColumIndex(spr, "QtyBatch"), xRow)
            If getColumIndex(spr, "CheckL") > -1 Then z4175.CheckL = getDataM(spr, getColumIndex(spr, "CheckL"), xRow)
            If getColumIndex(spr, "CheckR") > -1 Then z4175.CheckR = getDataM(spr, getColumIndex(spr, "CheckR"), xRow)
            If getColumIndex(spr, "QtyProduction") > -1 Then z4175.QtyProduction = getDataM(spr, getColumIndex(spr, "QtyProduction"), xRow)
            If getColumIndex(spr, "QtyProductionA") > -1 Then z4175.QtyProductionA = getDataM(spr, getColumIndex(spr, "QtyProductionA"), xRow)
            If getColumIndex(spr, "QtyProductionX") > -1 Then z4175.QtyProductionX = getDataM(spr, getColumIndex(spr, "QtyProductionX"), xRow)
            If getColumIndex(spr, "QtyProductionXP") > -1 Then z4175.QtyProductionXP = getDataM(spr, getColumIndex(spr, "QtyProductionXP"), xRow)
            If getColumIndex(spr, "QtyProductionXR") > -1 Then z4175.QtyProductionXR = getDataM(spr, getColumIndex(spr, "QtyProductionXR"), xRow)
            If getColumIndex(spr, "QtyBLOut") > -1 Then z4175.QtyBLOut = getDataM(spr, getColumIndex(spr, "QtyBLOut"), xRow)
            If getColumIndex(spr, "QtyBLIn") > -1 Then z4175.QtyBLIn = getDataM(spr, getColumIndex(spr, "QtyBLIn"), xRow)
            If getColumIndex(spr, "DateInsert") > -1 Then z4175.DateInsert = getDataM(spr, getColumIndex(spr, "DateInsert"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z4175.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "DateUpdate") > -1 Then z4175.DateUpdate = getDataM(spr, getColumIndex(spr, "DateUpdate"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z4175.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)
            If getColumIndex(spr, "CheckComplete") > -1 Then z4175.CheckComplete = getDataM(spr, getColumIndex(spr, "CheckComplete"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z4175.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4175_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K4175_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z4175 As T4175_AREA, Job As String, JOBCARD As String, SZNO As String, CDMAINPROCESS As String, SNO As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K4175_MOVE = False

        Try
            If READ_PFK4175(JOBCARD, SZNO, CDMAINPROCESS, SNO) = True Then
                z4175 = D4175
                K4175_MOVE = True
            Else
                z4175 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4175")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "JOBCARD" : z4175.JobCard = Children(i).Code
                                Case "SZNO" : z4175.Szno = Children(i).Code
                                Case "CDMAINPROCESS" : z4175.cdMainProcess = Children(i).Code
                                Case "SNO" : z4175.Sno = Children(i).Code
                                Case "SIZENAME" : z4175.SizeName = Children(i).Code
                                Case "MATERIALSEQ" : z4175.MaterialSeq = Children(i).Code
                                Case "BATCHNO" : z4175.BatchNo = Children(i).Code
                                Case "BATCHGROUP" : z4175.BatchGroup = Children(i).Code
                                Case "BATCHSHOES" : z4175.BatchShoes = Children(i).Code
                                Case "TYPEBATCH" : z4175.TypeBatch = Children(i).Code
                                Case "CDFACTORY" : z4175.cdFactory = Children(i).Code
                                Case "MACHINECODE" : z4175.MachineCode = Children(i).Code
                                Case "MACHINETNO" : z4175.MachineTno = Children(i).Code
                                Case "CDLINEPROD" : z4175.cdLineProd = Children(i).Code
                                Case "LINETNO" : z4175.LineTno = Children(i).Code
                                Case "DATEPRINT" : z4175.DatePrint = Children(i).Code
                                Case "DATEBATCH" : z4175.DateBatch = Children(i).Code
                                Case "INCHARGEBATCH" : z4175.InchargeBatch = Children(i).Code
                                Case "INCHARGEPRINT" : z4175.InchargePrint = Children(i).Code
                                Case "QTYBATCH" : z4175.QtyBatch = Children(i).Code
                                Case "CHECKL" : z4175.CheckL = Children(i).Code
                                Case "CHECKR" : z4175.CheckR = Children(i).Code
                                Case "QTYPRODUCTION" : z4175.QtyProduction = Children(i).Code
                                Case "QTYPRODUCTIONA" : z4175.QtyProductionA = Children(i).Code
                                Case "QTYPRODUCTIONX" : z4175.QtyProductionX = Children(i).Code
                                Case "QTYPRODUCTIONXP" : z4175.QtyProductionXP = Children(i).Code
                                Case "QTYPRODUCTIONXR" : z4175.QtyProductionXR = Children(i).Code
                                Case "QTYBLOUT" : z4175.QtyBLOut = Children(i).Code
                                Case "QTYBLIN" : z4175.QtyBLIn = Children(i).Code
                                Case "DATEINSERT" : z4175.DateInsert = Children(i).Code
                                Case "INCHARGEINSERT" : z4175.InchargeInsert = Children(i).Code
                                Case "DATEUPDATE" : z4175.DateUpdate = Children(i).Code
                                Case "INCHARGEUPDATE" : z4175.InchargeUpdate = Children(i).Code
                                Case "CHECKCOMPLETE" : z4175.CheckComplete = Children(i).Code
                                Case "REMARK" : z4175.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "JOBCARD" : z4175.JobCard = Children(i).Data
                                Case "SZNO" : z4175.Szno = Children(i).Data
                                Case "CDMAINPROCESS" : z4175.cdMainProcess = Children(i).Data
                                Case "SNO" : z4175.Sno = Children(i).Data
                                Case "SIZENAME" : z4175.SizeName = Children(i).Data
                                Case "MATERIALSEQ" : z4175.MaterialSeq = Children(i).Data
                                Case "BATCHNO" : z4175.BatchNo = Children(i).Data
                                Case "BATCHGROUP" : z4175.BatchGroup = Children(i).Data
                                Case "BATCHSHOES" : z4175.BatchShoes = Children(i).Data
                                Case "TYPEBATCH" : z4175.TypeBatch = Children(i).Data
                                Case "CDFACTORY" : z4175.cdFactory = Children(i).Data
                                Case "MACHINECODE" : z4175.MachineCode = Children(i).Data
                                Case "MACHINETNO" : z4175.MachineTno = Children(i).Data
                                Case "CDLINEPROD" : z4175.cdLineProd = Children(i).Data
                                Case "LINETNO" : z4175.LineTno = Children(i).Data
                                Case "DATEPRINT" : z4175.DatePrint = Children(i).Data
                                Case "DATEBATCH" : z4175.DateBatch = Children(i).Data
                                Case "INCHARGEBATCH" : z4175.InchargeBatch = Children(i).Data
                                Case "INCHARGEPRINT" : z4175.InchargePrint = Children(i).Data
                                Case "QTYBATCH" : z4175.QtyBatch = Children(i).Data
                                Case "CHECKL" : z4175.CheckL = Children(i).Data
                                Case "CHECKR" : z4175.CheckR = Children(i).Data
                                Case "QTYPRODUCTION" : z4175.QtyProduction = Children(i).Data
                                Case "QTYPRODUCTIONA" : z4175.QtyProductionA = Children(i).Data
                                Case "QTYPRODUCTIONX" : z4175.QtyProductionX = Children(i).Data
                                Case "QTYPRODUCTIONXP" : z4175.QtyProductionXP = Children(i).Data
                                Case "QTYPRODUCTIONXR" : z4175.QtyProductionXR = Children(i).Data
                                Case "QTYBLOUT" : z4175.QtyBLOut = Children(i).Data
                                Case "QTYBLIN" : z4175.QtyBLIn = Children(i).Data
                                Case "DATEINSERT" : z4175.DateInsert = Children(i).Data
                                Case "INCHARGEINSERT" : z4175.InchargeInsert = Children(i).Data
                                Case "DATEUPDATE" : z4175.DateUpdate = Children(i).Data
                                Case "INCHARGEUPDATE" : z4175.InchargeUpdate = Children(i).Data
                                Case "CHECKCOMPLETE" : z4175.CheckComplete = Children(i).Data
                                Case "REMARK" : z4175.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4175_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K4175_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z4175 As T4175_AREA, Job As String, CheckClear As Boolean, JOBCARD As String, SZNO As String, CDMAINPROCESS As String, SNO As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K4175_MOVE = False

        Try
            If READ_PFK4175(JOBCARD, SZNO, CDMAINPROCESS, SNO) = True Then
                z4175 = D4175
                K4175_MOVE = True
            Else
                If CheckClear = True Then z4175 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4175")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "JOBCARD" : z4175.JobCard = Children(i).Code
                                Case "SZNO" : z4175.Szno = Children(i).Code
                                Case "CDMAINPROCESS" : z4175.cdMainProcess = Children(i).Code
                                Case "SNO" : z4175.Sno = Children(i).Code
                                Case "SIZENAME" : z4175.SizeName = Children(i).Code
                                Case "MATERIALSEQ" : z4175.MaterialSeq = Children(i).Code
                                Case "BATCHNO" : z4175.BatchNo = Children(i).Code
                                Case "BATCHGROUP" : z4175.BatchGroup = Children(i).Code
                                Case "BATCHSHOES" : z4175.BatchShoes = Children(i).Code
                                Case "TYPEBATCH" : z4175.TypeBatch = Children(i).Code
                                Case "CDFACTORY" : z4175.cdFactory = Children(i).Code
                                Case "MACHINECODE" : z4175.MachineCode = Children(i).Code
                                Case "MACHINETNO" : z4175.MachineTno = Children(i).Code
                                Case "CDLINEPROD" : z4175.cdLineProd = Children(i).Code
                                Case "LINETNO" : z4175.LineTno = Children(i).Code
                                Case "DATEPRINT" : z4175.DatePrint = Children(i).Code
                                Case "DATEBATCH" : z4175.DateBatch = Children(i).Code
                                Case "INCHARGEBATCH" : z4175.InchargeBatch = Children(i).Code
                                Case "INCHARGEPRINT" : z4175.InchargePrint = Children(i).Code
                                Case "QTYBATCH" : z4175.QtyBatch = Children(i).Code
                                Case "CHECKL" : z4175.CheckL = Children(i).Code
                                Case "CHECKR" : z4175.CheckR = Children(i).Code
                                Case "QTYPRODUCTION" : z4175.QtyProduction = Children(i).Code
                                Case "QTYPRODUCTIONA" : z4175.QtyProductionA = Children(i).Code
                                Case "QTYPRODUCTIONX" : z4175.QtyProductionX = Children(i).Code
                                Case "QTYPRODUCTIONXP" : z4175.QtyProductionXP = Children(i).Code
                                Case "QTYPRODUCTIONXR" : z4175.QtyProductionXR = Children(i).Code
                                Case "QTYBLOUT" : z4175.QtyBLOut = Children(i).Code
                                Case "QTYBLIN" : z4175.QtyBLIn = Children(i).Code
                                Case "DATEINSERT" : z4175.DateInsert = Children(i).Code
                                Case "INCHARGEINSERT" : z4175.InchargeInsert = Children(i).Code
                                Case "DATEUPDATE" : z4175.DateUpdate = Children(i).Code
                                Case "INCHARGEUPDATE" : z4175.InchargeUpdate = Children(i).Code
                                Case "CHECKCOMPLETE" : z4175.CheckComplete = Children(i).Code
                                Case "REMARK" : z4175.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "JOBCARD" : z4175.JobCard = Children(i).Data
                                Case "SZNO" : z4175.Szno = Children(i).Data
                                Case "CDMAINPROCESS" : z4175.cdMainProcess = Children(i).Data
                                Case "SNO" : z4175.Sno = Children(i).Data
                                Case "SIZENAME" : z4175.SizeName = Children(i).Data
                                Case "MATERIALSEQ" : z4175.MaterialSeq = Children(i).Data
                                Case "BATCHNO" : z4175.BatchNo = Children(i).Data
                                Case "BATCHGROUP" : z4175.BatchGroup = Children(i).Data
                                Case "BATCHSHOES" : z4175.BatchShoes = Children(i).Data
                                Case "TYPEBATCH" : z4175.TypeBatch = Children(i).Data
                                Case "CDFACTORY" : z4175.cdFactory = Children(i).Data
                                Case "MACHINECODE" : z4175.MachineCode = Children(i).Data
                                Case "MACHINETNO" : z4175.MachineTno = Children(i).Data
                                Case "CDLINEPROD" : z4175.cdLineProd = Children(i).Data
                                Case "LINETNO" : z4175.LineTno = Children(i).Data
                                Case "DATEPRINT" : z4175.DatePrint = Children(i).Data
                                Case "DATEBATCH" : z4175.DateBatch = Children(i).Data
                                Case "INCHARGEBATCH" : z4175.InchargeBatch = Children(i).Data
                                Case "INCHARGEPRINT" : z4175.InchargePrint = Children(i).Data
                                Case "QTYBATCH" : z4175.QtyBatch = Children(i).Data
                                Case "CHECKL" : z4175.CheckL = Children(i).Data
                                Case "CHECKR" : z4175.CheckR = Children(i).Data
                                Case "QTYPRODUCTION" : z4175.QtyProduction = Children(i).Data
                                Case "QTYPRODUCTIONA" : z4175.QtyProductionA = Children(i).Data
                                Case "QTYPRODUCTIONX" : z4175.QtyProductionX = Children(i).Data
                                Case "QTYPRODUCTIONXP" : z4175.QtyProductionXP = Children(i).Data
                                Case "QTYPRODUCTIONXR" : z4175.QtyProductionXR = Children(i).Data
                                Case "QTYBLOUT" : z4175.QtyBLOut = Children(i).Data
                                Case "QTYBLIN" : z4175.QtyBLIn = Children(i).Data
                                Case "DATEINSERT" : z4175.DateInsert = Children(i).Data
                                Case "INCHARGEINSERT" : z4175.InchargeInsert = Children(i).Data
                                Case "DATEUPDATE" : z4175.DateUpdate = Children(i).Data
                                Case "INCHARGEUPDATE" : z4175.InchargeUpdate = Children(i).Data
                                Case "CHECKCOMPLETE" : z4175.CheckComplete = Children(i).Data
                                Case "REMARK" : z4175.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4175_MOVE", vbCritical)
        End Try
    End Function

End Module
