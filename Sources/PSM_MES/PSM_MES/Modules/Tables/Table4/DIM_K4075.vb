'=========================================================================================================================================================
'   TABLE : (PFK4075)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K4075

    Structure T4075_AREA
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

    Public D4075 As T4075_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK4075(JOBCARD As String, SZNO As String, CDMAINPROCESS As String, SNO As String) As Boolean
        READ_PFK4075 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4075 "
            SQL = SQL & " WHERE K4075_JobCard		 = '" & JobCard & "' "
            SQL = SQL & "   AND K4075_Szno		 = '" & Szno & "' "
            SQL = SQL & "   AND K4075_cdMainProcess		 = '" & cdMainProcess & "' "
            SQL = SQL & "   AND K4075_Sno		 = '" & Sno & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4075_CLEAR() : GoTo SKIP_READ_PFK4075

            Call K4075_MOVE(rd)
            READ_PFK4075 = True

SKIP_READ_PFK4075:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4075", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK4075(JOBCARD As String, SZNO As String, CDMAINPROCESS As String, SNO As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4075 "
            SQL = SQL & " WHERE K4075_JobCard		 = '" & JobCard & "' "
            SQL = SQL & "   AND K4075_Szno		 = '" & Szno & "' "
            SQL = SQL & "   AND K4075_cdMainProcess		 = '" & cdMainProcess & "' "
            SQL = SQL & "   AND K4075_Sno		 = '" & Sno & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK4075", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK4075(z4075 As T4075_AREA) As Boolean
        WRITE_PFK4075 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z4075)

            SQL = " INSERT INTO PFK4075 "
            SQL = SQL & " ( "
            SQL = SQL & " K4075_JobCard,"
            SQL = SQL & " K4075_Szno,"
            SQL = SQL & " K4075_cdMainProcess,"
            SQL = SQL & " K4075_Sno,"
            SQL = SQL & " K4075_SizeName,"
            SQL = SQL & " K4075_MaterialSeq,"
            SQL = SQL & " K4075_BatchNo,"
            SQL = SQL & " K4075_BatchGroup,"
            SQL = SQL & " K4075_BatchShoes,"
            SQL = SQL & " K4075_TypeBatch,"
            SQL = SQL & " K4075_cdFactory,"
            SQL = SQL & " K4075_MachineCode,"
            SQL = SQL & " K4075_MachineTno,"
            SQL = SQL & " K4075_cdLineProd,"
            SQL = SQL & " K4075_LineTno,"
            SQL = SQL & " K4075_DatePrint,"
            SQL = SQL & " K4075_DateBatch,"
            SQL = SQL & " K4075_InchargeBatch,"
            SQL = SQL & " K4075_InchargePrint,"
            SQL = SQL & " K4075_QtyBatch,"
            SQL = SQL & " K4075_CheckL,"
            SQL = SQL & " K4075_CheckR,"
            SQL = SQL & " K4075_QtyProduction,"
            SQL = SQL & " K4075_QtyProductionA,"
            SQL = SQL & " K4075_QtyProductionX,"
            SQL = SQL & " K4075_QtyProductionXP,"
            SQL = SQL & " K4075_QtyProductionXR,"
            SQL = SQL & " K4075_QtyBLOut,"
            SQL = SQL & " K4075_QtyBLIn,"
            SQL = SQL & " K4075_DateInsert,"
            SQL = SQL & " K4075_InchargeInsert,"
            SQL = SQL & " K4075_DateUpdate,"
            SQL = SQL & " K4075_InchargeUpdate,"
            SQL = SQL & " K4075_CheckComplete,"
            SQL = SQL & " K4075_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z4075.JobCard) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4075.Szno) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4075.cdMainProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4075.Sno) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4075.SizeName) & "', "
            SQL = SQL & "   " & FormatSQL(z4075.MaterialSeq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z4075.BatchNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4075.BatchGroup) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4075.BatchShoes) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4075.TypeBatch) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4075.cdFactory) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4075.MachineCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4075.MachineTno) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4075.cdLineProd) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4075.LineTno) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4075.DatePrint) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4075.DateBatch) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4075.InchargeBatch) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4075.InchargePrint) & "', "
            SQL = SQL & "   " & FormatSQL(z4075.QtyBatch) & ", "
            SQL = SQL & "  N'" & FormatSQL(z4075.CheckL) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4075.CheckR) & "', "
            SQL = SQL & "   " & FormatSQL(z4075.QtyProduction) & ", "
            SQL = SQL & "   " & FormatSQL(z4075.QtyProductionA) & ", "
            SQL = SQL & "   " & FormatSQL(z4075.QtyProductionX) & ", "
            SQL = SQL & "   " & FormatSQL(z4075.QtyProductionXP) & ", "
            SQL = SQL & "   " & FormatSQL(z4075.QtyProductionXR) & ", "
            SQL = SQL & "   " & FormatSQL(z4075.QtyBLOut) & ", "
            SQL = SQL & "   " & FormatSQL(z4075.QtyBLIn) & ", "
            SQL = SQL & "  N'" & FormatSQL(z4075.DateInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4075.InchargeInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4075.DateUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4075.InchargeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4075.CheckComplete) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4075.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK4075 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK4075", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK4075(z4075 As T4075_AREA) As Boolean
        REWRITE_PFK4075 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z4075)

            SQL = " UPDATE PFK4075 SET "
            SQL = SQL & "    K4075_SizeName      = N'" & FormatSQL(z4075.SizeName) & "', "
            SQL = SQL & "    K4075_MaterialSeq      =  " & FormatSQL(z4075.MaterialSeq) & ", "
            SQL = SQL & "    K4075_BatchNo      = N'" & FormatSQL(z4075.BatchNo) & "', "
            SQL = SQL & "    K4075_BatchGroup      = N'" & FormatSQL(z4075.BatchGroup) & "', "
            SQL = SQL & "    K4075_BatchShoes      = N'" & FormatSQL(z4075.BatchShoes) & "', "
            SQL = SQL & "    K4075_TypeBatch      = N'" & FormatSQL(z4075.TypeBatch) & "', "
            SQL = SQL & "    K4075_cdFactory      = N'" & FormatSQL(z4075.cdFactory) & "', "
            SQL = SQL & "    K4075_MachineCode      = N'" & FormatSQL(z4075.MachineCode) & "', "
            SQL = SQL & "    K4075_MachineTno      = N'" & FormatSQL(z4075.MachineTno) & "', "
            SQL = SQL & "    K4075_cdLineProd      = N'" & FormatSQL(z4075.cdLineProd) & "', "
            SQL = SQL & "    K4075_LineTno      = N'" & FormatSQL(z4075.LineTno) & "', "
            SQL = SQL & "    K4075_DatePrint      = N'" & FormatSQL(z4075.DatePrint) & "', "
            SQL = SQL & "    K4075_DateBatch      = N'" & FormatSQL(z4075.DateBatch) & "', "
            SQL = SQL & "    K4075_InchargeBatch      = N'" & FormatSQL(z4075.InchargeBatch) & "', "
            SQL = SQL & "    K4075_InchargePrint      = N'" & FormatSQL(z4075.InchargePrint) & "', "
            SQL = SQL & "    K4075_QtyBatch      =  " & FormatSQL(z4075.QtyBatch) & ", "
            SQL = SQL & "    K4075_CheckL      = N'" & FormatSQL(z4075.CheckL) & "', "
            SQL = SQL & "    K4075_CheckR      = N'" & FormatSQL(z4075.CheckR) & "', "
            SQL = SQL & "    K4075_QtyProduction      =  " & FormatSQL(z4075.QtyProduction) & ", "
            SQL = SQL & "    K4075_QtyProductionA      =  " & FormatSQL(z4075.QtyProductionA) & ", "
            SQL = SQL & "    K4075_QtyProductionX      =  " & FormatSQL(z4075.QtyProductionX) & ", "
            SQL = SQL & "    K4075_QtyProductionXP      =  " & FormatSQL(z4075.QtyProductionXP) & ", "
            SQL = SQL & "    K4075_QtyProductionXR      =  " & FormatSQL(z4075.QtyProductionXR) & ", "
            SQL = SQL & "    K4075_QtyBLOut      =  " & FormatSQL(z4075.QtyBLOut) & ", "
            SQL = SQL & "    K4075_QtyBLIn      =  " & FormatSQL(z4075.QtyBLIn) & ", "
            SQL = SQL & "    K4075_DateInsert      = N'" & FormatSQL(z4075.DateInsert) & "', "
            SQL = SQL & "    K4075_InchargeInsert      = N'" & FormatSQL(z4075.InchargeInsert) & "', "
            SQL = SQL & "    K4075_DateUpdate      = N'" & FormatSQL(z4075.DateUpdate) & "', "
            SQL = SQL & "    K4075_InchargeUpdate      = N'" & FormatSQL(z4075.InchargeUpdate) & "', "
            SQL = SQL & "    K4075_CheckComplete      = N'" & FormatSQL(z4075.CheckComplete) & "', "
            SQL = SQL & "    K4075_Remark      = N'" & FormatSQL(z4075.Remark) & "'  "
            SQL = SQL & " WHERE K4075_JobCard		 = '" & z4075.JobCard & "' "
            SQL = SQL & "   AND K4075_Szno		 = '" & z4075.Szno & "' "
            SQL = SQL & "   AND K4075_cdMainProcess		 = '" & z4075.cdMainProcess & "' "
            SQL = SQL & "   AND K4075_Sno		 = '" & z4075.Sno & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK4075 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK4075", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK4075(z4075 As T4075_AREA) As Boolean
        DELETE_PFK4075 = False

        'Dim cmd As SqlClient.SqlCommand
        'Dim SQL As String
        'Try
        '    SQL = " DELETE FROM PFK4075 "
        '    SQL = SQL & " WHERE K4075_JobCard		 = '" & z4075.JobCard & "' "
        '    SQL = SQL & "   AND K4075_Szno		 = '" & z4075.Szno & "' "
        '    SQL = SQL & "   AND K4075_cdMainProcess		 = '" & z4075.cdMainProcess & "' "
        '    SQL = SQL & "   AND K4075_Sno		 = '" & z4075.Sno & "' "
        '    cmd = New SqlClient.SqlCommand(SQL, cn)
        '    cmd.ExecuteNonQuery()

        '    DELETE_PFK4075 = True
        '    Exit Function
        'Catch ex As Exception
        '    Call MsgBoxP("DELETE_PFK4075", vbCritical)
        'End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D4075_CLEAR()
        Try

            D4075.JobCard = ""
            D4075.Szno = ""
            D4075.cdMainProcess = ""
            D4075.Sno = ""
            D4075.SizeName = ""
            D4075.MaterialSeq = 0
            D4075.BatchNo = ""
            D4075.BatchGroup = ""
            D4075.BatchShoes = ""
            D4075.TypeBatch = ""
            D4075.cdFactory = ""
            D4075.MachineCode = ""
            D4075.MachineTno = ""
            D4075.cdLineProd = ""
            D4075.LineTno = ""
            D4075.DatePrint = ""
            D4075.DateBatch = ""
            D4075.InchargeBatch = ""
            D4075.InchargePrint = ""
            D4075.QtyBatch = 0
            D4075.CheckL = ""
            D4075.CheckR = ""
            D4075.QtyProduction = 0
            D4075.QtyProductionA = 0
            D4075.QtyProductionX = 0
            D4075.QtyProductionXP = 0
            D4075.QtyProductionXR = 0
            D4075.QtyBLOut = 0
            D4075.QtyBLIn = 0
            D4075.DateInsert = ""
            D4075.InchargeInsert = ""
            D4075.DateUpdate = ""
            D4075.InchargeUpdate = ""
            D4075.CheckComplete = ""
            D4075.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D4075_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x4075 As T4075_AREA)
        Try

            x4075.JobCard = trim$(x4075.JobCard)
            x4075.Szno = trim$(x4075.Szno)
            x4075.cdMainProcess = trim$(x4075.cdMainProcess)
            x4075.Sno = trim$(x4075.Sno)
            x4075.SizeName = trim$(x4075.SizeName)
            x4075.MaterialSeq = trim$(x4075.MaterialSeq)
            x4075.BatchNo = trim$(x4075.BatchNo)
            x4075.BatchGroup = trim$(x4075.BatchGroup)
            x4075.BatchShoes = trim$(x4075.BatchShoes)
            x4075.TypeBatch = trim$(x4075.TypeBatch)
            x4075.cdFactory = trim$(x4075.cdFactory)
            x4075.MachineCode = trim$(x4075.MachineCode)
            x4075.MachineTno = trim$(x4075.MachineTno)
            x4075.cdLineProd = trim$(x4075.cdLineProd)
            x4075.LineTno = trim$(x4075.LineTno)
            x4075.DatePrint = trim$(x4075.DatePrint)
            x4075.DateBatch = trim$(x4075.DateBatch)
            x4075.InchargeBatch = trim$(x4075.InchargeBatch)
            x4075.InchargePrint = trim$(x4075.InchargePrint)
            x4075.QtyBatch = trim$(x4075.QtyBatch)
            x4075.CheckL = trim$(x4075.CheckL)
            x4075.CheckR = trim$(x4075.CheckR)
            x4075.QtyProduction = trim$(x4075.QtyProduction)
            x4075.QtyProductionA = trim$(x4075.QtyProductionA)
            x4075.QtyProductionX = trim$(x4075.QtyProductionX)
            x4075.QtyProductionXP = trim$(x4075.QtyProductionXP)
            x4075.QtyProductionXR = trim$(x4075.QtyProductionXR)
            x4075.QtyBLOut = trim$(x4075.QtyBLOut)
            x4075.QtyBLIn = trim$(x4075.QtyBLIn)
            x4075.DateInsert = trim$(x4075.DateInsert)
            x4075.InchargeInsert = trim$(x4075.InchargeInsert)
            x4075.DateUpdate = trim$(x4075.DateUpdate)
            x4075.InchargeUpdate = trim$(x4075.InchargeUpdate)
            x4075.CheckComplete = trim$(x4075.CheckComplete)
            x4075.Remark = trim$(x4075.Remark)

            If trim$(x4075.JobCard) = "" Then x4075.JobCard = Space(1)
            If trim$(x4075.Szno) = "" Then x4075.Szno = Space(1)
            If trim$(x4075.cdMainProcess) = "" Then x4075.cdMainProcess = Space(1)
            If trim$(x4075.Sno) = "" Then x4075.Sno = Space(1)
            If trim$(x4075.SizeName) = "" Then x4075.SizeName = Space(1)
            If trim$(x4075.MaterialSeq) = "" Then x4075.MaterialSeq = 0
            If trim$(x4075.BatchNo) = "" Then x4075.BatchNo = Space(1)
            If trim$(x4075.BatchGroup) = "" Then x4075.BatchGroup = Space(1)
            If trim$(x4075.BatchShoes) = "" Then x4075.BatchShoes = Space(1)
            If trim$(x4075.TypeBatch) = "" Then x4075.TypeBatch = Space(1)
            If trim$(x4075.cdFactory) = "" Then x4075.cdFactory = Space(1)
            If trim$(x4075.MachineCode) = "" Then x4075.MachineCode = Space(1)
            If trim$(x4075.MachineTno) = "" Then x4075.MachineTno = Space(1)
            If trim$(x4075.cdLineProd) = "" Then x4075.cdLineProd = Space(1)
            If trim$(x4075.LineTno) = "" Then x4075.LineTno = Space(1)
            If trim$(x4075.DatePrint) = "" Then x4075.DatePrint = Space(1)
            If trim$(x4075.DateBatch) = "" Then x4075.DateBatch = Space(1)
            If trim$(x4075.InchargeBatch) = "" Then x4075.InchargeBatch = Space(1)
            If trim$(x4075.InchargePrint) = "" Then x4075.InchargePrint = Space(1)
            If trim$(x4075.QtyBatch) = "" Then x4075.QtyBatch = 0
            If trim$(x4075.CheckL) = "" Then x4075.CheckL = Space(1)
            If trim$(x4075.CheckR) = "" Then x4075.CheckR = Space(1)
            If trim$(x4075.QtyProduction) = "" Then x4075.QtyProduction = 0
            If trim$(x4075.QtyProductionA) = "" Then x4075.QtyProductionA = 0
            If trim$(x4075.QtyProductionX) = "" Then x4075.QtyProductionX = 0
            If trim$(x4075.QtyProductionXP) = "" Then x4075.QtyProductionXP = 0
            If trim$(x4075.QtyProductionXR) = "" Then x4075.QtyProductionXR = 0
            If trim$(x4075.QtyBLOut) = "" Then x4075.QtyBLOut = 0
            If trim$(x4075.QtyBLIn) = "" Then x4075.QtyBLIn = 0
            If trim$(x4075.DateInsert) = "" Then x4075.DateInsert = Space(1)
            If trim$(x4075.InchargeInsert) = "" Then x4075.InchargeInsert = Space(1)
            If trim$(x4075.DateUpdate) = "" Then x4075.DateUpdate = Space(1)
            If trim$(x4075.InchargeUpdate) = "" Then x4075.InchargeUpdate = Space(1)
            If trim$(x4075.CheckComplete) = "" Then x4075.CheckComplete = Space(1)
            If trim$(x4075.Remark) = "" Then x4075.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K4075_MOVE(rs4075 As SqlClient.SqlDataReader)
        Try

            Call D4075_CLEAR()

            If IsdbNull(rs4075!K4075_JobCard) = False Then D4075.JobCard = Trim$(rs4075!K4075_JobCard)
            If IsdbNull(rs4075!K4075_Szno) = False Then D4075.Szno = Trim$(rs4075!K4075_Szno)
            If IsdbNull(rs4075!K4075_cdMainProcess) = False Then D4075.cdMainProcess = Trim$(rs4075!K4075_cdMainProcess)
            If IsdbNull(rs4075!K4075_Sno) = False Then D4075.Sno = Trim$(rs4075!K4075_Sno)
            If IsdbNull(rs4075!K4075_SizeName) = False Then D4075.SizeName = Trim$(rs4075!K4075_SizeName)
            If IsdbNull(rs4075!K4075_MaterialSeq) = False Then D4075.MaterialSeq = Trim$(rs4075!K4075_MaterialSeq)
            If IsdbNull(rs4075!K4075_BatchNo) = False Then D4075.BatchNo = Trim$(rs4075!K4075_BatchNo)
            If IsdbNull(rs4075!K4075_BatchGroup) = False Then D4075.BatchGroup = Trim$(rs4075!K4075_BatchGroup)
            If IsdbNull(rs4075!K4075_BatchShoes) = False Then D4075.BatchShoes = Trim$(rs4075!K4075_BatchShoes)
            If IsdbNull(rs4075!K4075_TypeBatch) = False Then D4075.TypeBatch = Trim$(rs4075!K4075_TypeBatch)
            If IsdbNull(rs4075!K4075_cdFactory) = False Then D4075.cdFactory = Trim$(rs4075!K4075_cdFactory)
            If IsdbNull(rs4075!K4075_MachineCode) = False Then D4075.MachineCode = Trim$(rs4075!K4075_MachineCode)
            If IsdbNull(rs4075!K4075_MachineTno) = False Then D4075.MachineTno = Trim$(rs4075!K4075_MachineTno)
            If IsdbNull(rs4075!K4075_cdLineProd) = False Then D4075.cdLineProd = Trim$(rs4075!K4075_cdLineProd)
            If IsdbNull(rs4075!K4075_LineTno) = False Then D4075.LineTno = Trim$(rs4075!K4075_LineTno)
            If IsdbNull(rs4075!K4075_DatePrint) = False Then D4075.DatePrint = Trim$(rs4075!K4075_DatePrint)
            If IsdbNull(rs4075!K4075_DateBatch) = False Then D4075.DateBatch = Trim$(rs4075!K4075_DateBatch)
            If IsdbNull(rs4075!K4075_InchargeBatch) = False Then D4075.InchargeBatch = Trim$(rs4075!K4075_InchargeBatch)
            If IsdbNull(rs4075!K4075_InchargePrint) = False Then D4075.InchargePrint = Trim$(rs4075!K4075_InchargePrint)
            If IsdbNull(rs4075!K4075_QtyBatch) = False Then D4075.QtyBatch = Trim$(rs4075!K4075_QtyBatch)
            If IsdbNull(rs4075!K4075_CheckL) = False Then D4075.CheckL = Trim$(rs4075!K4075_CheckL)
            If IsdbNull(rs4075!K4075_CheckR) = False Then D4075.CheckR = Trim$(rs4075!K4075_CheckR)
            If IsdbNull(rs4075!K4075_QtyProduction) = False Then D4075.QtyProduction = Trim$(rs4075!K4075_QtyProduction)
            If IsdbNull(rs4075!K4075_QtyProductionA) = False Then D4075.QtyProductionA = Trim$(rs4075!K4075_QtyProductionA)
            If IsdbNull(rs4075!K4075_QtyProductionX) = False Then D4075.QtyProductionX = Trim$(rs4075!K4075_QtyProductionX)
            If IsdbNull(rs4075!K4075_QtyProductionXP) = False Then D4075.QtyProductionXP = Trim$(rs4075!K4075_QtyProductionXP)
            If IsdbNull(rs4075!K4075_QtyProductionXR) = False Then D4075.QtyProductionXR = Trim$(rs4075!K4075_QtyProductionXR)
            If IsdbNull(rs4075!K4075_QtyBLOut) = False Then D4075.QtyBLOut = Trim$(rs4075!K4075_QtyBLOut)
            If IsdbNull(rs4075!K4075_QtyBLIn) = False Then D4075.QtyBLIn = Trim$(rs4075!K4075_QtyBLIn)
            If IsdbNull(rs4075!K4075_DateInsert) = False Then D4075.DateInsert = Trim$(rs4075!K4075_DateInsert)
            If IsdbNull(rs4075!K4075_InchargeInsert) = False Then D4075.InchargeInsert = Trim$(rs4075!K4075_InchargeInsert)
            If IsdbNull(rs4075!K4075_DateUpdate) = False Then D4075.DateUpdate = Trim$(rs4075!K4075_DateUpdate)
            If IsdbNull(rs4075!K4075_InchargeUpdate) = False Then D4075.InchargeUpdate = Trim$(rs4075!K4075_InchargeUpdate)
            If IsdbNull(rs4075!K4075_CheckComplete) = False Then D4075.CheckComplete = Trim$(rs4075!K4075_CheckComplete)
            If IsdbNull(rs4075!K4075_Remark) = False Then D4075.Remark = Trim$(rs4075!K4075_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K4075_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K4075_MOVE(rs4075 As DataRow)
        Try

            Call D4075_CLEAR()

            If IsdbNull(rs4075!K4075_JobCard) = False Then D4075.JobCard = Trim$(rs4075!K4075_JobCard)
            If IsdbNull(rs4075!K4075_Szno) = False Then D4075.Szno = Trim$(rs4075!K4075_Szno)
            If IsdbNull(rs4075!K4075_cdMainProcess) = False Then D4075.cdMainProcess = Trim$(rs4075!K4075_cdMainProcess)
            If IsdbNull(rs4075!K4075_Sno) = False Then D4075.Sno = Trim$(rs4075!K4075_Sno)
            If IsdbNull(rs4075!K4075_SizeName) = False Then D4075.SizeName = Trim$(rs4075!K4075_SizeName)
            If IsdbNull(rs4075!K4075_MaterialSeq) = False Then D4075.MaterialSeq = Trim$(rs4075!K4075_MaterialSeq)
            If IsdbNull(rs4075!K4075_BatchNo) = False Then D4075.BatchNo = Trim$(rs4075!K4075_BatchNo)
            If IsdbNull(rs4075!K4075_BatchGroup) = False Then D4075.BatchGroup = Trim$(rs4075!K4075_BatchGroup)
            If IsdbNull(rs4075!K4075_BatchShoes) = False Then D4075.BatchShoes = Trim$(rs4075!K4075_BatchShoes)
            If IsdbNull(rs4075!K4075_TypeBatch) = False Then D4075.TypeBatch = Trim$(rs4075!K4075_TypeBatch)
            If IsdbNull(rs4075!K4075_cdFactory) = False Then D4075.cdFactory = Trim$(rs4075!K4075_cdFactory)
            If IsdbNull(rs4075!K4075_MachineCode) = False Then D4075.MachineCode = Trim$(rs4075!K4075_MachineCode)
            If IsdbNull(rs4075!K4075_MachineTno) = False Then D4075.MachineTno = Trim$(rs4075!K4075_MachineTno)
            If IsdbNull(rs4075!K4075_cdLineProd) = False Then D4075.cdLineProd = Trim$(rs4075!K4075_cdLineProd)
            If IsdbNull(rs4075!K4075_LineTno) = False Then D4075.LineTno = Trim$(rs4075!K4075_LineTno)
            If IsdbNull(rs4075!K4075_DatePrint) = False Then D4075.DatePrint = Trim$(rs4075!K4075_DatePrint)
            If IsdbNull(rs4075!K4075_DateBatch) = False Then D4075.DateBatch = Trim$(rs4075!K4075_DateBatch)
            If IsdbNull(rs4075!K4075_InchargeBatch) = False Then D4075.InchargeBatch = Trim$(rs4075!K4075_InchargeBatch)
            If IsdbNull(rs4075!K4075_InchargePrint) = False Then D4075.InchargePrint = Trim$(rs4075!K4075_InchargePrint)
            If IsdbNull(rs4075!K4075_QtyBatch) = False Then D4075.QtyBatch = Trim$(rs4075!K4075_QtyBatch)
            If IsdbNull(rs4075!K4075_CheckL) = False Then D4075.CheckL = Trim$(rs4075!K4075_CheckL)
            If IsdbNull(rs4075!K4075_CheckR) = False Then D4075.CheckR = Trim$(rs4075!K4075_CheckR)
            If IsdbNull(rs4075!K4075_QtyProduction) = False Then D4075.QtyProduction = Trim$(rs4075!K4075_QtyProduction)
            If IsdbNull(rs4075!K4075_QtyProductionA) = False Then D4075.QtyProductionA = Trim$(rs4075!K4075_QtyProductionA)
            If IsdbNull(rs4075!K4075_QtyProductionX) = False Then D4075.QtyProductionX = Trim$(rs4075!K4075_QtyProductionX)
            If IsdbNull(rs4075!K4075_QtyProductionXP) = False Then D4075.QtyProductionXP = Trim$(rs4075!K4075_QtyProductionXP)
            If IsdbNull(rs4075!K4075_QtyProductionXR) = False Then D4075.QtyProductionXR = Trim$(rs4075!K4075_QtyProductionXR)
            If IsdbNull(rs4075!K4075_QtyBLOut) = False Then D4075.QtyBLOut = Trim$(rs4075!K4075_QtyBLOut)
            If IsdbNull(rs4075!K4075_QtyBLIn) = False Then D4075.QtyBLIn = Trim$(rs4075!K4075_QtyBLIn)
            If IsdbNull(rs4075!K4075_DateInsert) = False Then D4075.DateInsert = Trim$(rs4075!K4075_DateInsert)
            If IsdbNull(rs4075!K4075_InchargeInsert) = False Then D4075.InchargeInsert = Trim$(rs4075!K4075_InchargeInsert)
            If IsdbNull(rs4075!K4075_DateUpdate) = False Then D4075.DateUpdate = Trim$(rs4075!K4075_DateUpdate)
            If IsdbNull(rs4075!K4075_InchargeUpdate) = False Then D4075.InchargeUpdate = Trim$(rs4075!K4075_InchargeUpdate)
            If IsdbNull(rs4075!K4075_CheckComplete) = False Then D4075.CheckComplete = Trim$(rs4075!K4075_CheckComplete)
            If IsdbNull(rs4075!K4075_Remark) = False Then D4075.Remark = Trim$(rs4075!K4075_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K4075_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K4075_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z4075 As T4075_AREA, JOBCARD As String, SZNO As String, CDMAINPROCESS As String, SNO As String) As Boolean

        K4075_MOVE = False

        Try
            If READ_PFK4075(JOBCARD, SZNO, CDMAINPROCESS, SNO) = True Then
                z4075 = D4075
                K4075_MOVE = True
            Else
                z4075 = Nothing
            End If

            If getColumIndex(spr, "JobCard") > -1 Then z4075.JobCard = getDataM(spr, getColumIndex(spr, "JobCard"), xRow)
            If getColumIndex(spr, "Szno") > -1 Then z4075.Szno = getDataM(spr, getColumIndex(spr, "Szno"), xRow)
            If getColumIndex(spr, "cdMainProcess") > -1 Then z4075.cdMainProcess = getDataM(spr, getColumIndex(spr, "cdMainProcess"), xRow)
            If getColumIndex(spr, "Sno") > -1 Then z4075.Sno = getDataM(spr, getColumIndex(spr, "Sno"), xRow)
            If getColumIndex(spr, "SizeName") > -1 Then z4075.SizeName = getDataM(spr, getColumIndex(spr, "SizeName"), xRow)
            If getColumIndex(spr, "MaterialSeq") > -1 Then z4075.MaterialSeq = getDataM(spr, getColumIndex(spr, "MaterialSeq"), xRow)
            If getColumIndex(spr, "BatchNo") > -1 Then z4075.BatchNo = getDataM(spr, getColumIndex(spr, "BatchNo"), xRow)
            If getColumIndex(spr, "BatchGroup") > -1 Then z4075.BatchGroup = getDataM(spr, getColumIndex(spr, "BatchGroup"), xRow)
            If getColumIndex(spr, "BatchShoes") > -1 Then z4075.BatchShoes = getDataM(spr, getColumIndex(spr, "BatchShoes"), xRow)
            If getColumIndex(spr, "TypeBatch") > -1 Then z4075.TypeBatch = getDataM(spr, getColumIndex(spr, "TypeBatch"), xRow)
            If getColumIndex(spr, "cdFactory") > -1 Then z4075.cdFactory = getDataM(spr, getColumIndex(spr, "cdFactory"), xRow)
            If getColumIndex(spr, "MachineCode") > -1 Then z4075.MachineCode = getDataM(spr, getColumIndex(spr, "MachineCode"), xRow)
            If getColumIndex(spr, "MachineTno") > -1 Then z4075.MachineTno = getDataM(spr, getColumIndex(spr, "MachineTno"), xRow)
            If getColumIndex(spr, "cdLineProd") > -1 Then z4075.cdLineProd = getDataM(spr, getColumIndex(spr, "cdLineProd"), xRow)
            If getColumIndex(spr, "LineTno") > -1 Then z4075.LineTno = getDataM(spr, getColumIndex(spr, "LineTno"), xRow)
            If getColumIndex(spr, "DatePrint") > -1 Then z4075.DatePrint = getDataM(spr, getColumIndex(spr, "DatePrint"), xRow)
            If getColumIndex(spr, "DateBatch") > -1 Then z4075.DateBatch = getDataM(spr, getColumIndex(spr, "DateBatch"), xRow)
            If getColumIndex(spr, "InchargeBatch") > -1 Then z4075.InchargeBatch = getDataM(spr, getColumIndex(spr, "InchargeBatch"), xRow)
            If getColumIndex(spr, "InchargePrint") > -1 Then z4075.InchargePrint = getDataM(spr, getColumIndex(spr, "InchargePrint"), xRow)
            If getColumIndex(spr, "QtyBatch") > -1 Then z4075.QtyBatch = getDataM(spr, getColumIndex(spr, "QtyBatch"), xRow)
            If getColumIndex(spr, "CheckL") > -1 Then z4075.CheckL = getDataM(spr, getColumIndex(spr, "CheckL"), xRow)
            If getColumIndex(spr, "CheckR") > -1 Then z4075.CheckR = getDataM(spr, getColumIndex(spr, "CheckR"), xRow)
            If getColumIndex(spr, "QtyProduction") > -1 Then z4075.QtyProduction = getDataM(spr, getColumIndex(spr, "QtyProduction"), xRow)
            If getColumIndex(spr, "QtyProductionA") > -1 Then z4075.QtyProductionA = getDataM(spr, getColumIndex(spr, "QtyProductionA"), xRow)
            If getColumIndex(spr, "QtyProductionX") > -1 Then z4075.QtyProductionX = getDataM(spr, getColumIndex(spr, "QtyProductionX"), xRow)
            If getColumIndex(spr, "QtyProductionXP") > -1 Then z4075.QtyProductionXP = getDataM(spr, getColumIndex(spr, "QtyProductionXP"), xRow)
            If getColumIndex(spr, "QtyProductionXR") > -1 Then z4075.QtyProductionXR = getDataM(spr, getColumIndex(spr, "QtyProductionXR"), xRow)
            If getColumIndex(spr, "QtyBLOut") > -1 Then z4075.QtyBLOut = getDataM(spr, getColumIndex(spr, "QtyBLOut"), xRow)
            If getColumIndex(spr, "QtyBLIn") > -1 Then z4075.QtyBLIn = getDataM(spr, getColumIndex(spr, "QtyBLIn"), xRow)
            If getColumIndex(spr, "DateInsert") > -1 Then z4075.DateInsert = getDataM(spr, getColumIndex(spr, "DateInsert"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z4075.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "DateUpdate") > -1 Then z4075.DateUpdate = getDataM(spr, getColumIndex(spr, "DateUpdate"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z4075.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)
            If getColumIndex(spr, "CheckComplete") > -1 Then z4075.CheckComplete = getDataM(spr, getColumIndex(spr, "CheckComplete"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z4075.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4075_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K4075_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z4075 As T4075_AREA, CheckClear As Boolean, JOBCARD As String, SZNO As String, CDMAINPROCESS As String, SNO As String) As Boolean

        K4075_MOVE = False

        Try
            If READ_PFK4075(JOBCARD, SZNO, CDMAINPROCESS, SNO) = True Then
                z4075 = D4075
                K4075_MOVE = True
            Else
                If CheckClear = True Then z4075 = Nothing
            End If

            If getColumIndex(spr, "JobCard") > -1 Then z4075.JobCard = getDataM(spr, getColumIndex(spr, "JobCard"), xRow)
            If getColumIndex(spr, "Szno") > -1 Then z4075.Szno = getDataM(spr, getColumIndex(spr, "Szno"), xRow)
            If getColumIndex(spr, "cdMainProcess") > -1 Then z4075.cdMainProcess = getDataM(spr, getColumIndex(spr, "cdMainProcess"), xRow)
            If getColumIndex(spr, "Sno") > -1 Then z4075.Sno = getDataM(spr, getColumIndex(spr, "Sno"), xRow)
            If getColumIndex(spr, "SizeName") > -1 Then z4075.SizeName = getDataM(spr, getColumIndex(spr, "SizeName"), xRow)
            If getColumIndex(spr, "MaterialSeq") > -1 Then z4075.MaterialSeq = getDataM(spr, getColumIndex(spr, "MaterialSeq"), xRow)
            If getColumIndex(spr, "BatchNo") > -1 Then z4075.BatchNo = getDataM(spr, getColumIndex(spr, "BatchNo"), xRow)
            If getColumIndex(spr, "BatchGroup") > -1 Then z4075.BatchGroup = getDataM(spr, getColumIndex(spr, "BatchGroup"), xRow)
            If getColumIndex(spr, "BatchShoes") > -1 Then z4075.BatchShoes = getDataM(spr, getColumIndex(spr, "BatchShoes"), xRow)
            If getColumIndex(spr, "TypeBatch") > -1 Then z4075.TypeBatch = getDataM(spr, getColumIndex(spr, "TypeBatch"), xRow)
            If getColumIndex(spr, "cdFactory") > -1 Then z4075.cdFactory = getDataM(spr, getColumIndex(spr, "cdFactory"), xRow)
            If getColumIndex(spr, "MachineCode") > -1 Then z4075.MachineCode = getDataM(spr, getColumIndex(spr, "MachineCode"), xRow)
            If getColumIndex(spr, "MachineTno") > -1 Then z4075.MachineTno = getDataM(spr, getColumIndex(spr, "MachineTno"), xRow)
            If getColumIndex(spr, "cdLineProd") > -1 Then z4075.cdLineProd = getDataM(spr, getColumIndex(spr, "cdLineProd"), xRow)
            If getColumIndex(spr, "LineTno") > -1 Then z4075.LineTno = getDataM(spr, getColumIndex(spr, "LineTno"), xRow)
            If getColumIndex(spr, "DatePrint") > -1 Then z4075.DatePrint = getDataM(spr, getColumIndex(spr, "DatePrint"), xRow)
            If getColumIndex(spr, "DateBatch") > -1 Then z4075.DateBatch = getDataM(spr, getColumIndex(spr, "DateBatch"), xRow)
            If getColumIndex(spr, "InchargeBatch") > -1 Then z4075.InchargeBatch = getDataM(spr, getColumIndex(spr, "InchargeBatch"), xRow)
            If getColumIndex(spr, "InchargePrint") > -1 Then z4075.InchargePrint = getDataM(spr, getColumIndex(spr, "InchargePrint"), xRow)
            If getColumIndex(spr, "QtyBatch") > -1 Then z4075.QtyBatch = getDataM(spr, getColumIndex(spr, "QtyBatch"), xRow)
            If getColumIndex(spr, "CheckL") > -1 Then z4075.CheckL = getDataM(spr, getColumIndex(spr, "CheckL"), xRow)
            If getColumIndex(spr, "CheckR") > -1 Then z4075.CheckR = getDataM(spr, getColumIndex(spr, "CheckR"), xRow)
            If getColumIndex(spr, "QtyProduction") > -1 Then z4075.QtyProduction = getDataM(spr, getColumIndex(spr, "QtyProduction"), xRow)
            If getColumIndex(spr, "QtyProductionA") > -1 Then z4075.QtyProductionA = getDataM(spr, getColumIndex(spr, "QtyProductionA"), xRow)
            If getColumIndex(spr, "QtyProductionX") > -1 Then z4075.QtyProductionX = getDataM(spr, getColumIndex(spr, "QtyProductionX"), xRow)
            If getColumIndex(spr, "QtyProductionXP") > -1 Then z4075.QtyProductionXP = getDataM(spr, getColumIndex(spr, "QtyProductionXP"), xRow)
            If getColumIndex(spr, "QtyProductionXR") > -1 Then z4075.QtyProductionXR = getDataM(spr, getColumIndex(spr, "QtyProductionXR"), xRow)
            If getColumIndex(spr, "QtyBLOut") > -1 Then z4075.QtyBLOut = getDataM(spr, getColumIndex(spr, "QtyBLOut"), xRow)
            If getColumIndex(spr, "QtyBLIn") > -1 Then z4075.QtyBLIn = getDataM(spr, getColumIndex(spr, "QtyBLIn"), xRow)
            If getColumIndex(spr, "DateInsert") > -1 Then z4075.DateInsert = getDataM(spr, getColumIndex(spr, "DateInsert"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z4075.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "DateUpdate") > -1 Then z4075.DateUpdate = getDataM(spr, getColumIndex(spr, "DateUpdate"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z4075.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)
            If getColumIndex(spr, "CheckComplete") > -1 Then z4075.CheckComplete = getDataM(spr, getColumIndex(spr, "CheckComplete"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z4075.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4075_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K4075_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z4075 As T4075_AREA, Job As String, JOBCARD As String, SZNO As String, CDMAINPROCESS As String, SNO As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K4075_MOVE = False

        Try
            If READ_PFK4075(JOBCARD, SZNO, CDMAINPROCESS, SNO) = True Then
                z4075 = D4075
                K4075_MOVE = True
            Else
                z4075 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4075")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "JOBCARD" : z4075.JobCard = Children(i).Code
                                Case "SZNO" : z4075.Szno = Children(i).Code
                                Case "CDMAINPROCESS" : z4075.cdMainProcess = Children(i).Code
                                Case "SNO" : z4075.Sno = Children(i).Code
                                Case "SIZENAME" : z4075.SizeName = Children(i).Code
                                Case "MATERIALSEQ" : z4075.MaterialSeq = Children(i).Code
                                Case "BATCHNO" : z4075.BatchNo = Children(i).Code
                                Case "BATCHGROUP" : z4075.BatchGroup = Children(i).Code
                                Case "BATCHSHOES" : z4075.BatchShoes = Children(i).Code
                                Case "TYPEBATCH" : z4075.TypeBatch = Children(i).Code
                                Case "CDFACTORY" : z4075.cdFactory = Children(i).Code
                                Case "MACHINECODE" : z4075.MachineCode = Children(i).Code
                                Case "MACHINETNO" : z4075.MachineTno = Children(i).Code
                                Case "CDLINEPROD" : z4075.cdLineProd = Children(i).Code
                                Case "LINETNO" : z4075.LineTno = Children(i).Code
                                Case "DATEPRINT" : z4075.DatePrint = Children(i).Code
                                Case "DATEBATCH" : z4075.DateBatch = Children(i).Code
                                Case "INCHARGEBATCH" : z4075.InchargeBatch = Children(i).Code
                                Case "INCHARGEPRINT" : z4075.InchargePrint = Children(i).Code
                                Case "QTYBATCH" : z4075.QtyBatch = Children(i).Code
                                Case "CHECKL" : z4075.CheckL = Children(i).Code
                                Case "CHECKR" : z4075.CheckR = Children(i).Code
                                Case "QTYPRODUCTION" : z4075.QtyProduction = Children(i).Code
                                Case "QTYPRODUCTIONA" : z4075.QtyProductionA = Children(i).Code
                                Case "QTYPRODUCTIONX" : z4075.QtyProductionX = Children(i).Code
                                Case "QTYPRODUCTIONXP" : z4075.QtyProductionXP = Children(i).Code
                                Case "QTYPRODUCTIONXR" : z4075.QtyProductionXR = Children(i).Code
                                Case "QTYBLOUT" : z4075.QtyBLOut = Children(i).Code
                                Case "QTYBLIN" : z4075.QtyBLIn = Children(i).Code
                                Case "DATEINSERT" : z4075.DateInsert = Children(i).Code
                                Case "INCHARGEINSERT" : z4075.InchargeInsert = Children(i).Code
                                Case "DATEUPDATE" : z4075.DateUpdate = Children(i).Code
                                Case "INCHARGEUPDATE" : z4075.InchargeUpdate = Children(i).Code
                                Case "CHECKCOMPLETE" : z4075.CheckComplete = Children(i).Code
                                Case "REMARK" : z4075.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "JOBCARD" : z4075.JobCard = Children(i).Data
                                Case "SZNO" : z4075.Szno = Children(i).Data
                                Case "CDMAINPROCESS" : z4075.cdMainProcess = Children(i).Data
                                Case "SNO" : z4075.Sno = Children(i).Data
                                Case "SIZENAME" : z4075.SizeName = Children(i).Data
                                Case "MATERIALSEQ" : z4075.MaterialSeq = Children(i).Data
                                Case "BATCHNO" : z4075.BatchNo = Children(i).Data
                                Case "BATCHGROUP" : z4075.BatchGroup = Children(i).Data
                                Case "BATCHSHOES" : z4075.BatchShoes = Children(i).Data
                                Case "TYPEBATCH" : z4075.TypeBatch = Children(i).Data
                                Case "CDFACTORY" : z4075.cdFactory = Children(i).Data
                                Case "MACHINECODE" : z4075.MachineCode = Children(i).Data
                                Case "MACHINETNO" : z4075.MachineTno = Children(i).Data
                                Case "CDLINEPROD" : z4075.cdLineProd = Children(i).Data
                                Case "LINETNO" : z4075.LineTno = Children(i).Data
                                Case "DATEPRINT" : z4075.DatePrint = Children(i).Data
                                Case "DATEBATCH" : z4075.DateBatch = Children(i).Data
                                Case "INCHARGEBATCH" : z4075.InchargeBatch = Children(i).Data
                                Case "INCHARGEPRINT" : z4075.InchargePrint = Children(i).Data
                                Case "QTYBATCH" : z4075.QtyBatch = Children(i).Data
                                Case "CHECKL" : z4075.CheckL = Children(i).Data
                                Case "CHECKR" : z4075.CheckR = Children(i).Data
                                Case "QTYPRODUCTION" : z4075.QtyProduction = Children(i).Data
                                Case "QTYPRODUCTIONA" : z4075.QtyProductionA = Children(i).Data
                                Case "QTYPRODUCTIONX" : z4075.QtyProductionX = Children(i).Data
                                Case "QTYPRODUCTIONXP" : z4075.QtyProductionXP = Children(i).Data
                                Case "QTYPRODUCTIONXR" : z4075.QtyProductionXR = Children(i).Data
                                Case "QTYBLOUT" : z4075.QtyBLOut = Children(i).Data
                                Case "QTYBLIN" : z4075.QtyBLIn = Children(i).Data
                                Case "DATEINSERT" : z4075.DateInsert = Children(i).Data
                                Case "INCHARGEINSERT" : z4075.InchargeInsert = Children(i).Data
                                Case "DATEUPDATE" : z4075.DateUpdate = Children(i).Data
                                Case "INCHARGEUPDATE" : z4075.InchargeUpdate = Children(i).Data
                                Case "CHECKCOMPLETE" : z4075.CheckComplete = Children(i).Data
                                Case "REMARK" : z4075.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4075_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K4075_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z4075 As T4075_AREA, Job As String, CheckClear As Boolean, JOBCARD As String, SZNO As String, CDMAINPROCESS As String, SNO As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K4075_MOVE = False

        Try
            If READ_PFK4075(JOBCARD, SZNO, CDMAINPROCESS, SNO) = True Then
                z4075 = D4075
                K4075_MOVE = True
            Else
                If CheckClear = True Then z4075 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4075")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "JOBCARD" : z4075.JobCard = Children(i).Code
                                Case "SZNO" : z4075.Szno = Children(i).Code
                                Case "CDMAINPROCESS" : z4075.cdMainProcess = Children(i).Code
                                Case "SNO" : z4075.Sno = Children(i).Code
                                Case "SIZENAME" : z4075.SizeName = Children(i).Code
                                Case "MATERIALSEQ" : z4075.MaterialSeq = Children(i).Code
                                Case "BATCHNO" : z4075.BatchNo = Children(i).Code
                                Case "BATCHGROUP" : z4075.BatchGroup = Children(i).Code
                                Case "BATCHSHOES" : z4075.BatchShoes = Children(i).Code
                                Case "TYPEBATCH" : z4075.TypeBatch = Children(i).Code
                                Case "CDFACTORY" : z4075.cdFactory = Children(i).Code
                                Case "MACHINECODE" : z4075.MachineCode = Children(i).Code
                                Case "MACHINETNO" : z4075.MachineTno = Children(i).Code
                                Case "CDLINEPROD" : z4075.cdLineProd = Children(i).Code
                                Case "LINETNO" : z4075.LineTno = Children(i).Code
                                Case "DATEPRINT" : z4075.DatePrint = Children(i).Code
                                Case "DATEBATCH" : z4075.DateBatch = Children(i).Code
                                Case "INCHARGEBATCH" : z4075.InchargeBatch = Children(i).Code
                                Case "INCHARGEPRINT" : z4075.InchargePrint = Children(i).Code
                                Case "QTYBATCH" : z4075.QtyBatch = Children(i).Code
                                Case "CHECKL" : z4075.CheckL = Children(i).Code
                                Case "CHECKR" : z4075.CheckR = Children(i).Code
                                Case "QTYPRODUCTION" : z4075.QtyProduction = Children(i).Code
                                Case "QTYPRODUCTIONA" : z4075.QtyProductionA = Children(i).Code
                                Case "QTYPRODUCTIONX" : z4075.QtyProductionX = Children(i).Code
                                Case "QTYPRODUCTIONXP" : z4075.QtyProductionXP = Children(i).Code
                                Case "QTYPRODUCTIONXR" : z4075.QtyProductionXR = Children(i).Code
                                Case "QTYBLOUT" : z4075.QtyBLOut = Children(i).Code
                                Case "QTYBLIN" : z4075.QtyBLIn = Children(i).Code
                                Case "DATEINSERT" : z4075.DateInsert = Children(i).Code
                                Case "INCHARGEINSERT" : z4075.InchargeInsert = Children(i).Code
                                Case "DATEUPDATE" : z4075.DateUpdate = Children(i).Code
                                Case "INCHARGEUPDATE" : z4075.InchargeUpdate = Children(i).Code
                                Case "CHECKCOMPLETE" : z4075.CheckComplete = Children(i).Code
                                Case "REMARK" : z4075.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "JOBCARD" : z4075.JobCard = Children(i).Data
                                Case "SZNO" : z4075.Szno = Children(i).Data
                                Case "CDMAINPROCESS" : z4075.cdMainProcess = Children(i).Data
                                Case "SNO" : z4075.Sno = Children(i).Data
                                Case "SIZENAME" : z4075.SizeName = Children(i).Data
                                Case "MATERIALSEQ" : z4075.MaterialSeq = Children(i).Data
                                Case "BATCHNO" : z4075.BatchNo = Children(i).Data
                                Case "BATCHGROUP" : z4075.BatchGroup = Children(i).Data
                                Case "BATCHSHOES" : z4075.BatchShoes = Children(i).Data
                                Case "TYPEBATCH" : z4075.TypeBatch = Children(i).Data
                                Case "CDFACTORY" : z4075.cdFactory = Children(i).Data
                                Case "MACHINECODE" : z4075.MachineCode = Children(i).Data
                                Case "MACHINETNO" : z4075.MachineTno = Children(i).Data
                                Case "CDLINEPROD" : z4075.cdLineProd = Children(i).Data
                                Case "LINETNO" : z4075.LineTno = Children(i).Data
                                Case "DATEPRINT" : z4075.DatePrint = Children(i).Data
                                Case "DATEBATCH" : z4075.DateBatch = Children(i).Data
                                Case "INCHARGEBATCH" : z4075.InchargeBatch = Children(i).Data
                                Case "INCHARGEPRINT" : z4075.InchargePrint = Children(i).Data
                                Case "QTYBATCH" : z4075.QtyBatch = Children(i).Data
                                Case "CHECKL" : z4075.CheckL = Children(i).Data
                                Case "CHECKR" : z4075.CheckR = Children(i).Data
                                Case "QTYPRODUCTION" : z4075.QtyProduction = Children(i).Data
                                Case "QTYPRODUCTIONA" : z4075.QtyProductionA = Children(i).Data
                                Case "QTYPRODUCTIONX" : z4075.QtyProductionX = Children(i).Data
                                Case "QTYPRODUCTIONXP" : z4075.QtyProductionXP = Children(i).Data
                                Case "QTYPRODUCTIONXR" : z4075.QtyProductionXR = Children(i).Data
                                Case "QTYBLOUT" : z4075.QtyBLOut = Children(i).Data
                                Case "QTYBLIN" : z4075.QtyBLIn = Children(i).Data
                                Case "DATEINSERT" : z4075.DateInsert = Children(i).Data
                                Case "INCHARGEINSERT" : z4075.InchargeInsert = Children(i).Data
                                Case "DATEUPDATE" : z4075.DateUpdate = Children(i).Data
                                Case "INCHARGEUPDATE" : z4075.InchargeUpdate = Children(i).Data
                                Case "CHECKCOMPLETE" : z4075.CheckComplete = Children(i).Data
                                Case "REMARK" : z4075.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4075_MOVE", vbCritical)
        End Try
    End Function

End Module
