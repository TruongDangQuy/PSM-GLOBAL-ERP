'=========================================================================================================================================================
'   TABLE : (PFK2352)
'
'      WORKER : PSM GLOBAL ., LTD
'       WORK DATE : 2019 NEW
'       DEVELOPER    : MRNLV
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K2352

    Structure T2352_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public MaterialInBoundNo As String  '			char(9)		*
        Public MaterialInBoundSeq As String  '			char(3)		*
        Public MaterialInBoundSno As Double  '			decimal		*
        Public MaterialInBoundDseq As Double  '			decimal
        Public PackInBound As Double  '			decimal
        Public QtyInBound_Or As Double  '			decimal
        Public QtyInboundPL As Double  '			decimal
        Public QtyInBound As Double  '			decimal
        Public QtyInBoundQC As Double  '			decimal
        Public AmountInBoundEX As Double  '			decimal
        Public AmountInBoundVND As Double  '			decimal
        Public PackOutBound As Double  '			decimal
        Public QtyOutBound As Double  '			decimal
        Public QtyConvert As Double  '			decimal
        Public seWareHouseGroup As String  '			char(3)
        Public cdWareHouseGroup As String  '			char(3)
        Public seWareHousePosition As String  '			char(3)
        Public cdWareHousePosition As String  '			char(3)
        Public seDefectMaterial As String  '			char(3)
        Public cdDefectMaterial As String  '			char(3)
        Public SupplierName As String  '			nvarchar(100)
        Public SOEName As String  '			nvarchar(100)
        Public TypeName0 As String  '			nvarchar(100)
        Public TypeName1 As String  '			nvarchar(100)
        Public TypeName2 As String  '			nvarchar(100)
        Public TypeName3 As String  '			nvarchar(100)
        Public TypeName4 As String  '			nvarchar(100)
        Public TypeName5 As String  '			nvarchar(100)
        Public SizeName As String  '			nvarchar(200)
        Public Grade As String  '			nvarchar(200)
        Public Szno As String  '			nvarchar(200)
        Public LotGrade As String  '			nvarchar(10)
        Public Remark As String  '			nvarchar(50)
        Public DateQC As String  '			char(8)
        Public DateInsert As String  '			char(8)
        Public DateUpdate As String  '			char(8)
        Public InchargeInsert As String  '			char(8)
        Public InchargeUpdate As String  '			char(8)
        Public JobCard As String  '			char(9)
        Public OrderNo As String  '			char(9)
        Public OrderNoSeq As String  '			char(3)
        Public JobCardWorking As String  '			char(10)
        Public JobCardWorkingSeq As String  '			char(3)
        Public JobCardPSeq As String  '			char(3)
        Public JobCardType As String  '			char(1)
        Public LotNo As String  '			char(9)
        Public LotNoSeq As String  '			char(2)
        Public CheckComplete As String  '			char(1)
        Public CheckPrint As String  '			char(1)
        Public TimePrint As String  '			nvarchar(20)
        Public CheckAllocation As String  '			char(1)
        Public TimeUpdate As String  '			char(14)
        Public seSite As String  '			char(3)
        Public cdSite As String  '			char(3)
        Public InchargeQC As String  '			char(8)
        Public PathImageQC As String  '			nvarchar(500)
        Public RemarkQC As String  '			nvarchar(500)
        Public Date20QC As String  '			char(20)
        '=========================================================================================================================================================
    End Structure

    Public D2352 As T2352_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK2352(MATERIALINBOUNDNO As String, MATERIALINBOUNDSEQ As String, MATERIALINBOUNDSNO As Double) As Boolean
        READ_PFK2352 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK2352 "
            SQL = SQL & " WHERE K2352_MaterialInBoundNo		 = '" & MaterialInBoundNo & "' "
            SQL = SQL & "   AND K2352_MaterialInBoundSeq		 = '" & MaterialInBoundSeq & "' "
            SQL = SQL & "   AND K2352_MaterialInBoundSno		 =  " & MaterialInBoundSno & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D2352_CLEAR() : GoTo SKIP_READ_PFK2352

            Call K2352_MOVE(rd)
            READ_PFK2352 = True

SKIP_READ_PFK2352:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK2352", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK2352(MATERIALINBOUNDNO As String, MATERIALINBOUNDSEQ As String, MATERIALINBOUNDSNO As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK2352 "
            SQL = SQL & " WHERE K2352_MaterialInBoundNo		 = '" & MaterialInBoundNo & "' "
            SQL = SQL & "   AND K2352_MaterialInBoundSeq		 = '" & MaterialInBoundSeq & "' "
            SQL = SQL & "   AND K2352_MaterialInBoundSno		 =  " & MaterialInBoundSno & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK2352", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK2352(z2352 As T2352_AREA) As Boolean
        WRITE_PFK2352 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z2352)

            SQL = " INSERT INTO PFK2352 "
            SQL = SQL & " ( "
            SQL = SQL & " K2352_MaterialInBoundNo,"
            SQL = SQL & " K2352_MaterialInBoundSeq,"
            SQL = SQL & " K2352_MaterialInBoundSno,"
            SQL = SQL & " K2352_MaterialInBoundDseq,"
            SQL = SQL & " K2352_PackInBound,"
            SQL = SQL & " K2352_QtyInBound_Or,"
            SQL = SQL & " K2352_QtyInboundPL,"
            SQL = SQL & " K2352_QtyInBound,"
            SQL = SQL & " K2352_QtyInBoundQC,"
            SQL = SQL & " K2352_AmountInBoundEX,"
            SQL = SQL & " K2352_AmountInBoundVND,"
            SQL = SQL & " K2352_PackOutBound,"
            SQL = SQL & " K2352_QtyOutBound,"
            SQL = SQL & " K2352_QtyConvert,"
            SQL = SQL & " K2352_seWareHouseGroup,"
            SQL = SQL & " K2352_cdWareHouseGroup,"
            SQL = SQL & " K2352_seWareHousePosition,"
            SQL = SQL & " K2352_cdWareHousePosition,"
            SQL = SQL & " K2352_seDefectMaterial,"
            SQL = SQL & " K2352_cdDefectMaterial,"
            SQL = SQL & " K2352_SupplierName,"
            SQL = SQL & " K2352_SOEName,"
            SQL = SQL & " K2352_TypeName0,"
            SQL = SQL & " K2352_TypeName1,"
            SQL = SQL & " K2352_TypeName2,"
            SQL = SQL & " K2352_TypeName3,"
            SQL = SQL & " K2352_TypeName4,"
            SQL = SQL & " K2352_TypeName5,"
            SQL = SQL & " K2352_SizeName,"
            SQL = SQL & " K2352_Grade,"
            SQL = SQL & " K2352_Szno,"
            SQL = SQL & " K2352_LotGrade,"
            SQL = SQL & " K2352_Remark,"
            SQL = SQL & " K2352_DateQC,"
            SQL = SQL & " K2352_DateInsert,"
            SQL = SQL & " K2352_DateUpdate,"
            SQL = SQL & " K2352_InchargeInsert,"
            SQL = SQL & " K2352_InchargeUpdate,"
            SQL = SQL & " K2352_JobCard,"
            SQL = SQL & " K2352_OrderNo,"
            SQL = SQL & " K2352_OrderNoSeq,"
            SQL = SQL & " K2352_JobCardWorking,"
            SQL = SQL & " K2352_JobCardWorkingSeq,"
            SQL = SQL & " K2352_JobCardPSeq,"
            SQL = SQL & " K2352_JobCardType,"
            SQL = SQL & " K2352_LotNo,"
            SQL = SQL & " K2352_LotNoSeq,"
            SQL = SQL & " K2352_CheckComplete,"
            SQL = SQL & " K2352_CheckPrint,"
            SQL = SQL & " K2352_TimePrint,"
            SQL = SQL & " K2352_CheckAllocation,"
            SQL = SQL & " K2352_TimeUpdate,"
            SQL = SQL & " K2352_seSite,"
            SQL = SQL & " K2352_cdSite,"
            SQL = SQL & " K2352_InchargeQC,"
            SQL = SQL & " K2352_PathImageQC,"
            SQL = SQL & " K2352_RemarkQC,"
            SQL = SQL & " K2352_Date20QC "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z2352.MaterialInBoundNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.MaterialInBoundSeq) & "', "
            SQL = SQL & "   " & FormatSQL(z2352.MaterialInBoundSno) & ", "
            SQL = SQL & "   " & FormatSQL(z2352.MaterialInBoundDseq) & ", "
            SQL = SQL & "   " & FormatSQL(z2352.PackInBound) & ", "
            SQL = SQL & "   " & FormatSQL(z2352.QtyInBound_Or) & ", "
            SQL = SQL & "   " & FormatSQL(z2352.QtyInboundPL) & ", "
            SQL = SQL & "   " & FormatSQL(z2352.QtyInBound) & ", "
            SQL = SQL & "   " & FormatSQL(z2352.QtyInBoundQC) & ", "
            SQL = SQL & "   " & FormatSQL(z2352.AmountInBoundEX) & ", "
            SQL = SQL & "   " & FormatSQL(z2352.AmountInBoundVND) & ", "
            SQL = SQL & "   " & FormatSQL(z2352.PackOutBound) & ", "
            SQL = SQL & "   " & FormatSQL(z2352.QtyOutBound) & ", "
            SQL = SQL & "   " & FormatSQL(z2352.QtyConvert) & ", "
            SQL = SQL & "  N'" & FormatSQL(z2352.seWareHouseGroup) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.cdWareHouseGroup) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.seWareHousePosition) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.cdWareHousePosition) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.seDefectMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.cdDefectMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.SupplierName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.SOEName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.TypeName0) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.TypeName1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.TypeName2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.TypeName3) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.TypeName4) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.TypeName5) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.SizeName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.Grade) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.Szno) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.LotGrade) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.Remark) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.DateQC) & "', "
            SQL = SQL & "  N'" & FormatSQL(PUB.DAT) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.DateUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(PUB.SAW) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.InchargeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.JobCard) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.OrderNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.OrderNoSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.JobCardWorking) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.JobCardWorkingSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.JobCardPSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.JobCardType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.LotNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.LotNoSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.CheckComplete) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.CheckPrint) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.TimePrint) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.CheckAllocation) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.TimeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.seSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.cdSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.InchargeQC) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.PathImageQC) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.RemarkQC) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2352.Date20QC) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK2352 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK2352", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK2352(z2352 As T2352_AREA) As Boolean
        REWRITE_PFK2352 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z2352)

            SQL = " UPDATE PFK2352 SET "
            SQL = SQL & "    K2352_MaterialInBoundDseq      =  " & FormatSQL(z2352.MaterialInBoundDseq) & ", "
            SQL = SQL & "    K2352_PackInBound      =  " & FormatSQL(z2352.PackInBound) & ", "
            SQL = SQL & "    K2352_QtyInBound_Or      =  " & FormatSQL(z2352.QtyInBound_Or) & ", "
            SQL = SQL & "    K2352_QtyInboundPL      =  " & FormatSQL(z2352.QtyInboundPL) & ", "
            SQL = SQL & "    K2352_QtyInBound      =  " & FormatSQL(z2352.QtyInBound) & ", "
            SQL = SQL & "    K2352_QtyInBoundQC      =  " & FormatSQL(z2352.QtyInBoundQC) & ", "
            SQL = SQL & "    K2352_AmountInBoundEX      =  " & FormatSQL(z2352.AmountInBoundEX) & ", "
            SQL = SQL & "    K2352_AmountInBoundVND      =  " & FormatSQL(z2352.AmountInBoundVND) & ", "
            SQL = SQL & "    K2352_PackOutBound      =  " & FormatSQL(z2352.PackOutBound) & ", "
            SQL = SQL & "    K2352_QtyOutBound      =  " & FormatSQL(z2352.QtyOutBound) & ", "
            SQL = SQL & "    K2352_QtyConvert      =  " & FormatSQL(z2352.QtyConvert) & ", "
            SQL = SQL & "    K2352_seWareHouseGroup      = N'" & FormatSQL(z2352.seWareHouseGroup) & "', "
            SQL = SQL & "    K2352_cdWareHouseGroup      = N'" & FormatSQL(z2352.cdWareHouseGroup) & "', "
            SQL = SQL & "    K2352_seWareHousePosition      = N'" & FormatSQL(z2352.seWareHousePosition) & "', "
            SQL = SQL & "    K2352_cdWareHousePosition      = N'" & FormatSQL(z2352.cdWareHousePosition) & "', "
            SQL = SQL & "    K2352_seDefectMaterial      = N'" & FormatSQL(z2352.seDefectMaterial) & "', "
            SQL = SQL & "    K2352_cdDefectMaterial      = N'" & FormatSQL(z2352.cdDefectMaterial) & "', "
            SQL = SQL & "    K2352_SupplierName      = N'" & FormatSQL(z2352.SupplierName) & "', "
            SQL = SQL & "    K2352_SOEName      = N'" & FormatSQL(z2352.SOEName) & "', "
            SQL = SQL & "    K2352_TypeName0      = N'" & FormatSQL(z2352.TypeName0) & "', "
            SQL = SQL & "    K2352_TypeName1      = N'" & FormatSQL(z2352.TypeName1) & "', "
            SQL = SQL & "    K2352_TypeName2      = N'" & FormatSQL(z2352.TypeName2) & "', "
            SQL = SQL & "    K2352_TypeName3      = N'" & FormatSQL(z2352.TypeName3) & "', "
            SQL = SQL & "    K2352_TypeName4      = N'" & FormatSQL(z2352.TypeName4) & "', "
            SQL = SQL & "    K2352_TypeName5      = N'" & FormatSQL(z2352.TypeName5) & "', "
            SQL = SQL & "    K2352_SizeName      = N'" & FormatSQL(z2352.SizeName) & "', "
            SQL = SQL & "    K2352_Grade      = N'" & FormatSQL(z2352.Grade) & "', "
            SQL = SQL & "    K2352_Szno      = N'" & FormatSQL(z2352.Szno) & "', "
            SQL = SQL & "    K2352_LotGrade      = N'" & FormatSQL(z2352.LotGrade) & "', "
            SQL = SQL & "    K2352_Remark      = N'" & FormatSQL(z2352.Remark) & "', "
            SQL = SQL & "    K2352_DateQC      = N'" & FormatSQL(z2352.DateQC) & "', "
            SQL = SQL & "    K2352_DateInsert      = N'" & FormatSQL(z2352.DateInsert) & "', "
            SQL = SQL & "    K2352_DateUpdate      = N'" & FormatSQL(PUB.DAT) & "', "
            SQL = SQL & "    K2352_InchargeInsert      = N'" & FormatSQL(z2352.InchargeInsert) & "', "
            SQL = SQL & "    K2352_InchargeUpdate      = N'" & FormatSQL(PUB.SAW) & "', "
            SQL = SQL & "    K2352_JobCard      = N'" & FormatSQL(z2352.JobCard) & "', "
            SQL = SQL & "    K2352_OrderNo      = N'" & FormatSQL(z2352.OrderNo) & "', "
            SQL = SQL & "    K2352_OrderNoSeq      = N'" & FormatSQL(z2352.OrderNoSeq) & "', "
            SQL = SQL & "    K2352_JobCardWorking      = N'" & FormatSQL(z2352.JobCardWorking) & "', "
            SQL = SQL & "    K2352_JobCardWorkingSeq      = N'" & FormatSQL(z2352.JobCardWorkingSeq) & "', "
            SQL = SQL & "    K2352_JobCardPSeq      = N'" & FormatSQL(z2352.JobCardPSeq) & "', "
            SQL = SQL & "    K2352_JobCardType      = N'" & FormatSQL(z2352.JobCardType) & "', "
            SQL = SQL & "    K2352_LotNo      = N'" & FormatSQL(z2352.LotNo) & "', "
            SQL = SQL & "    K2352_LotNoSeq      = N'" & FormatSQL(z2352.LotNoSeq) & "', "
            SQL = SQL & "    K2352_CheckComplete      = N'" & FormatSQL(z2352.CheckComplete) & "', "
            SQL = SQL & "    K2352_CheckPrint      = N'" & FormatSQL(z2352.CheckPrint) & "', "
            SQL = SQL & "    K2352_TimePrint      = N'" & FormatSQL(z2352.TimePrint) & "', "
            SQL = SQL & "    K2352_CheckAllocation      = N'" & FormatSQL(z2352.CheckAllocation) & "', "
            SQL = SQL & "    K2352_TimeUpdate      = N'" & FormatSQL(Pub.TIME) & "', "
            SQL = SQL & "    K2352_seSite      = N'" & FormatSQL(z2352.seSite) & "', "
            SQL = SQL & "    K2352_cdSite      = N'" & FormatSQL(z2352.cdSite) & "', "
            SQL = SQL & "    K2352_InchargeQC      = N'" & FormatSQL(z2352.InchargeQC) & "', "
            SQL = SQL & "    K2352_PathImageQC      = N'" & FormatSQL(z2352.PathImageQC) & "', "
            SQL = SQL & "    K2352_RemarkQC      = N'" & FormatSQL(z2352.RemarkQC) & "', "
            SQL = SQL & "    K2352_Date20QC      = N'" & FormatSQL(z2352.Date20QC) & "'  "
            SQL = SQL & " WHERE K2352_MaterialInBoundNo		 = '" & z2352.MaterialInBoundNo & "' "
            SQL = SQL & "   AND K2352_MaterialInBoundSeq		 = '" & z2352.MaterialInBoundSeq & "' "
            SQL = SQL & "   AND K2352_MaterialInBoundSno		 =  " & z2352.MaterialInBoundSno & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()


            REWRITE_PFK2352 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK2352", vbCritical)

        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK2352(z2352 As T2352_AREA) As Boolean
        DELETE_PFK2352 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z2352)

            SQL = " DELETE FROM PFK2352  "
            SQL = SQL & " WHERE K2352_MaterialInBoundNo		 = '" & z2352.MaterialInBoundNo & "' "
            SQL = SQL & "   AND K2352_MaterialInBoundSeq		 = '" & z2352.MaterialInBoundSeq & "' "
            SQL = SQL & "   AND K2352_MaterialInBoundSno		 =  " & z2352.MaterialInBoundSno & "  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK2352 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK2352", vbCritical)
        Finally
            Call GetFullInformation("PFK2352", "D", SQL)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D2352_CLEAR()
        Try

            D2352.MaterialInBoundNo = ""
            D2352.MaterialInBoundSeq = ""
            D2352.MaterialInBoundSno = 0
            D2352.MaterialInBoundDseq = 0
            D2352.PackInBound = 0
            D2352.QtyInBound_Or = 0
            D2352.QtyInboundPL = 0
            D2352.QtyInBound = 0
            D2352.QtyInBoundQC = 0
            D2352.AmountInBoundEX = 0
            D2352.AmountInBoundVND = 0
            D2352.PackOutBound = 0
            D2352.QtyOutBound = 0
            D2352.QtyConvert = 0
            D2352.seWareHouseGroup = ""
            D2352.cdWareHouseGroup = ""
            D2352.seWareHousePosition = ""
            D2352.cdWareHousePosition = ""
            D2352.seDefectMaterial = ""
            D2352.cdDefectMaterial = ""
            D2352.SupplierName = ""
            D2352.SOEName = ""
            D2352.TypeName0 = ""
            D2352.TypeName1 = ""
            D2352.TypeName2 = ""
            D2352.TypeName3 = ""
            D2352.TypeName4 = ""
            D2352.TypeName5 = ""
            D2352.SizeName = ""
            D2352.Grade = ""
            D2352.Szno = ""
            D2352.LotGrade = ""
            D2352.Remark = ""
            D2352.DateQC = ""
            D2352.DateInsert = ""
            D2352.DateUpdate = ""
            D2352.InchargeInsert = ""
            D2352.InchargeUpdate = ""
            D2352.JobCard = ""
            D2352.OrderNo = ""
            D2352.OrderNoSeq = ""
            D2352.JobCardWorking = ""
            D2352.JobCardWorkingSeq = ""
            D2352.JobCardPSeq = ""
            D2352.JobCardType = ""
            D2352.LotNo = ""
            D2352.LotNoSeq = ""
            D2352.CheckComplete = ""
            D2352.CheckPrint = ""
            D2352.TimePrint = ""
            D2352.CheckAllocation = ""
            D2352.TimeUpdate = ""
            D2352.seSite = ""
            D2352.cdSite = ""
            D2352.InchargeQC = ""
            D2352.PathImageQC = ""
            D2352.RemarkQC = ""
            D2352.Date20QC = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D2352_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x2352 As T2352_AREA)
        Try

            x2352.MaterialInBoundNo = trim$(x2352.MaterialInBoundNo)
            x2352.MaterialInBoundSeq = trim$(x2352.MaterialInBoundSeq)
            x2352.MaterialInBoundSno = trim$(x2352.MaterialInBoundSno)
            x2352.MaterialInBoundDseq = trim$(x2352.MaterialInBoundDseq)
            x2352.PackInBound = trim$(x2352.PackInBound)
            x2352.QtyInBound_Or = trim$(x2352.QtyInBound_Or)
            x2352.QtyInboundPL = trim$(x2352.QtyInboundPL)
            x2352.QtyInBound = trim$(x2352.QtyInBound)
            x2352.QtyInBoundQC = trim$(x2352.QtyInBoundQC)
            x2352.AmountInBoundEX = trim$(x2352.AmountInBoundEX)
            x2352.AmountInBoundVND = trim$(x2352.AmountInBoundVND)
            x2352.PackOutBound = trim$(x2352.PackOutBound)
            x2352.QtyOutBound = trim$(x2352.QtyOutBound)
            x2352.QtyConvert = trim$(x2352.QtyConvert)
            x2352.seWareHouseGroup = trim$(x2352.seWareHouseGroup)
            x2352.cdWareHouseGroup = trim$(x2352.cdWareHouseGroup)
            x2352.seWareHousePosition = trim$(x2352.seWareHousePosition)
            x2352.cdWareHousePosition = trim$(x2352.cdWareHousePosition)
            x2352.seDefectMaterial = trim$(x2352.seDefectMaterial)
            x2352.cdDefectMaterial = trim$(x2352.cdDefectMaterial)
            x2352.SupplierName = trim$(x2352.SupplierName)
            x2352.SOEName = trim$(x2352.SOEName)
            x2352.TypeName0 = trim$(x2352.TypeName0)
            x2352.TypeName1 = trim$(x2352.TypeName1)
            x2352.TypeName2 = trim$(x2352.TypeName2)
            x2352.TypeName3 = trim$(x2352.TypeName3)
            x2352.TypeName4 = trim$(x2352.TypeName4)
            x2352.TypeName5 = trim$(x2352.TypeName5)
            x2352.SizeName = trim$(x2352.SizeName)
            x2352.Grade = trim$(x2352.Grade)
            x2352.Szno = trim$(x2352.Szno)
            x2352.LotGrade = trim$(x2352.LotGrade)
            x2352.Remark = trim$(x2352.Remark)
            x2352.DateQC = trim$(x2352.DateQC)
            x2352.DateInsert = trim$(x2352.DateInsert)
            x2352.DateUpdate = trim$(x2352.DateUpdate)
            x2352.InchargeInsert = trim$(x2352.InchargeInsert)
            x2352.InchargeUpdate = trim$(x2352.InchargeUpdate)
            x2352.JobCard = trim$(x2352.JobCard)
            x2352.OrderNo = trim$(x2352.OrderNo)
            x2352.OrderNoSeq = trim$(x2352.OrderNoSeq)
            x2352.JobCardWorking = trim$(x2352.JobCardWorking)
            x2352.JobCardWorkingSeq = trim$(x2352.JobCardWorkingSeq)
            x2352.JobCardPSeq = trim$(x2352.JobCardPSeq)
            x2352.JobCardType = trim$(x2352.JobCardType)
            x2352.LotNo = trim$(x2352.LotNo)
            x2352.LotNoSeq = trim$(x2352.LotNoSeq)
            x2352.CheckComplete = trim$(x2352.CheckComplete)
            x2352.CheckPrint = trim$(x2352.CheckPrint)
            x2352.TimePrint = trim$(x2352.TimePrint)
            x2352.CheckAllocation = trim$(x2352.CheckAllocation)
            x2352.TimeUpdate = Trim$(x2352.TimeUpdate)
            x2352.seSite = trim$(x2352.seSite)
            x2352.cdSite = trim$(x2352.cdSite)
            x2352.InchargeQC = trim$(x2352.InchargeQC)
            x2352.PathImageQC = trim$(x2352.PathImageQC)
            x2352.RemarkQC = trim$(x2352.RemarkQC)
            x2352.Date20QC = trim$(x2352.Date20QC)

            If trim$(x2352.MaterialInBoundNo) = "" Then x2352.MaterialInBoundNo = Space(1)
            If trim$(x2352.MaterialInBoundSeq) = "" Then x2352.MaterialInBoundSeq = Space(1)
            If trim$(x2352.MaterialInBoundSno) = "" Then x2352.MaterialInBoundSno = 0
            If trim$(x2352.MaterialInBoundDseq) = "" Then x2352.MaterialInBoundDseq = 0
            If trim$(x2352.PackInBound) = "" Then x2352.PackInBound = 0
            If trim$(x2352.QtyInBound_Or) = "" Then x2352.QtyInBound_Or = 0
            If trim$(x2352.QtyInboundPL) = "" Then x2352.QtyInboundPL = 0
            If trim$(x2352.QtyInBound) = "" Then x2352.QtyInBound = 0
            If trim$(x2352.QtyInBoundQC) = "" Then x2352.QtyInBoundQC = 0
            If trim$(x2352.AmountInBoundEX) = "" Then x2352.AmountInBoundEX = 0
            If trim$(x2352.AmountInBoundVND) = "" Then x2352.AmountInBoundVND = 0
            If trim$(x2352.PackOutBound) = "" Then x2352.PackOutBound = 0
            If trim$(x2352.QtyOutBound) = "" Then x2352.QtyOutBound = 0
            If trim$(x2352.QtyConvert) = "" Then x2352.QtyConvert = 0
            If trim$(x2352.seWareHouseGroup) = "" Then x2352.seWareHouseGroup = Space(1)
            If trim$(x2352.cdWareHouseGroup) = "" Then x2352.cdWareHouseGroup = Space(1)
            If trim$(x2352.seWareHousePosition) = "" Then x2352.seWareHousePosition = Space(1)
            If trim$(x2352.cdWareHousePosition) = "" Then x2352.cdWareHousePosition = Space(1)
            If trim$(x2352.seDefectMaterial) = "" Then x2352.seDefectMaterial = Space(1)
            If trim$(x2352.cdDefectMaterial) = "" Then x2352.cdDefectMaterial = Space(1)
            If trim$(x2352.SupplierName) = "" Then x2352.SupplierName = Space(1)
            If trim$(x2352.SOEName) = "" Then x2352.SOEName = Space(1)
            If trim$(x2352.TypeName0) = "" Then x2352.TypeName0 = Space(1)
            If trim$(x2352.TypeName1) = "" Then x2352.TypeName1 = Space(1)
            If trim$(x2352.TypeName2) = "" Then x2352.TypeName2 = Space(1)
            If trim$(x2352.TypeName3) = "" Then x2352.TypeName3 = Space(1)
            If trim$(x2352.TypeName4) = "" Then x2352.TypeName4 = Space(1)
            If trim$(x2352.TypeName5) = "" Then x2352.TypeName5 = Space(1)
            If trim$(x2352.SizeName) = "" Then x2352.SizeName = Space(1)
            If trim$(x2352.Grade) = "" Then x2352.Grade = Space(1)
            If trim$(x2352.Szno) = "" Then x2352.Szno = Space(1)
            If trim$(x2352.LotGrade) = "" Then x2352.LotGrade = Space(1)
            If trim$(x2352.Remark) = "" Then x2352.Remark = Space(1)
            If trim$(x2352.DateQC) = "" Then x2352.DateQC = Space(1)
            If trim$(x2352.DateInsert) = "" Then x2352.DateInsert = Space(1)
            If trim$(x2352.DateUpdate) = "" Then x2352.DateUpdate = Space(1)
            If trim$(x2352.InchargeInsert) = "" Then x2352.InchargeInsert = Space(1)
            If trim$(x2352.InchargeUpdate) = "" Then x2352.InchargeUpdate = Space(1)
            If trim$(x2352.JobCard) = "" Then x2352.JobCard = Space(1)
            If trim$(x2352.OrderNo) = "" Then x2352.OrderNo = Space(1)
            If trim$(x2352.OrderNoSeq) = "" Then x2352.OrderNoSeq = Space(1)
            If trim$(x2352.JobCardWorking) = "" Then x2352.JobCardWorking = Space(1)
            If trim$(x2352.JobCardWorkingSeq) = "" Then x2352.JobCardWorkingSeq = Space(1)
            If trim$(x2352.JobCardPSeq) = "" Then x2352.JobCardPSeq = Space(1)
            If trim$(x2352.JobCardType) = "" Then x2352.JobCardType = Space(1)
            If trim$(x2352.LotNo) = "" Then x2352.LotNo = Space(1)
            If trim$(x2352.LotNoSeq) = "" Then x2352.LotNoSeq = Space(1)
            If trim$(x2352.CheckComplete) = "" Then x2352.CheckComplete = Space(1)
            If trim$(x2352.CheckPrint) = "" Then x2352.CheckPrint = Space(1)
            If trim$(x2352.TimePrint) = "" Then x2352.TimePrint = Space(1)
            If trim$(x2352.CheckAllocation) = "" Then x2352.CheckAllocation = Space(1)
            If Trim$(x2352.TimeUpdate) = "" Then x2352.TimeUpdate = Space(1)
            If trim$(x2352.seSite) = "" Then x2352.seSite = Space(1)
            If trim$(x2352.cdSite) = "" Then x2352.cdSite = Space(1)
            If trim$(x2352.InchargeQC) = "" Then x2352.InchargeQC = Space(1)
            If trim$(x2352.PathImageQC) = "" Then x2352.PathImageQC = Space(1)
            If trim$(x2352.RemarkQC) = "" Then x2352.RemarkQC = Space(1)
            If trim$(x2352.Date20QC) = "" Then x2352.Date20QC = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K2352_MOVE(rs2352 As SqlClient.SqlDataReader)
        Try

            Call D2352_CLEAR()

            If IsdbNull(rs2352!K2352_MaterialInBoundNo) = False Then D2352.MaterialInBoundNo = Trim$(rs2352!K2352_MaterialInBoundNo)
            If IsdbNull(rs2352!K2352_MaterialInBoundSeq) = False Then D2352.MaterialInBoundSeq = Trim$(rs2352!K2352_MaterialInBoundSeq)
            If IsdbNull(rs2352!K2352_MaterialInBoundSno) = False Then D2352.MaterialInBoundSno = Trim$(rs2352!K2352_MaterialInBoundSno)
            If IsdbNull(rs2352!K2352_MaterialInBoundDseq) = False Then D2352.MaterialInBoundDseq = Trim$(rs2352!K2352_MaterialInBoundDseq)
            If IsdbNull(rs2352!K2352_PackInBound) = False Then D2352.PackInBound = Trim$(rs2352!K2352_PackInBound)
            If IsdbNull(rs2352!K2352_QtyInBound_Or) = False Then D2352.QtyInBound_Or = Trim$(rs2352!K2352_QtyInBound_Or)
            If IsdbNull(rs2352!K2352_QtyInboundPL) = False Then D2352.QtyInboundPL = Trim$(rs2352!K2352_QtyInboundPL)
            If IsdbNull(rs2352!K2352_QtyInBound) = False Then D2352.QtyInBound = Trim$(rs2352!K2352_QtyInBound)
            If IsdbNull(rs2352!K2352_QtyInBoundQC) = False Then D2352.QtyInBoundQC = Trim$(rs2352!K2352_QtyInBoundQC)
            If IsdbNull(rs2352!K2352_AmountInBoundEX) = False Then D2352.AmountInBoundEX = Trim$(rs2352!K2352_AmountInBoundEX)
            If IsdbNull(rs2352!K2352_AmountInBoundVND) = False Then D2352.AmountInBoundVND = Trim$(rs2352!K2352_AmountInBoundVND)
            If IsdbNull(rs2352!K2352_PackOutBound) = False Then D2352.PackOutBound = Trim$(rs2352!K2352_PackOutBound)
            If IsdbNull(rs2352!K2352_QtyOutBound) = False Then D2352.QtyOutBound = Trim$(rs2352!K2352_QtyOutBound)
            If IsdbNull(rs2352!K2352_QtyConvert) = False Then D2352.QtyConvert = Trim$(rs2352!K2352_QtyConvert)
            If IsdbNull(rs2352!K2352_seWareHouseGroup) = False Then D2352.seWareHouseGroup = Trim$(rs2352!K2352_seWareHouseGroup)
            If IsdbNull(rs2352!K2352_cdWareHouseGroup) = False Then D2352.cdWareHouseGroup = Trim$(rs2352!K2352_cdWareHouseGroup)
            If IsdbNull(rs2352!K2352_seWareHousePosition) = False Then D2352.seWareHousePosition = Trim$(rs2352!K2352_seWareHousePosition)
            If IsdbNull(rs2352!K2352_cdWareHousePosition) = False Then D2352.cdWareHousePosition = Trim$(rs2352!K2352_cdWareHousePosition)
            If IsdbNull(rs2352!K2352_seDefectMaterial) = False Then D2352.seDefectMaterial = Trim$(rs2352!K2352_seDefectMaterial)
            If IsdbNull(rs2352!K2352_cdDefectMaterial) = False Then D2352.cdDefectMaterial = Trim$(rs2352!K2352_cdDefectMaterial)
            If IsdbNull(rs2352!K2352_SupplierName) = False Then D2352.SupplierName = Trim$(rs2352!K2352_SupplierName)
            If IsdbNull(rs2352!K2352_SOEName) = False Then D2352.SOEName = Trim$(rs2352!K2352_SOEName)
            If IsdbNull(rs2352!K2352_TypeName0) = False Then D2352.TypeName0 = Trim$(rs2352!K2352_TypeName0)
            If IsdbNull(rs2352!K2352_TypeName1) = False Then D2352.TypeName1 = Trim$(rs2352!K2352_TypeName1)
            If IsdbNull(rs2352!K2352_TypeName2) = False Then D2352.TypeName2 = Trim$(rs2352!K2352_TypeName2)
            If IsdbNull(rs2352!K2352_TypeName3) = False Then D2352.TypeName3 = Trim$(rs2352!K2352_TypeName3)
            If IsdbNull(rs2352!K2352_TypeName4) = False Then D2352.TypeName4 = Trim$(rs2352!K2352_TypeName4)
            If IsdbNull(rs2352!K2352_TypeName5) = False Then D2352.TypeName5 = Trim$(rs2352!K2352_TypeName5)
            If IsdbNull(rs2352!K2352_SizeName) = False Then D2352.SizeName = Trim$(rs2352!K2352_SizeName)
            If IsdbNull(rs2352!K2352_Grade) = False Then D2352.Grade = Trim$(rs2352!K2352_Grade)
            If IsdbNull(rs2352!K2352_Szno) = False Then D2352.Szno = Trim$(rs2352!K2352_Szno)
            If IsdbNull(rs2352!K2352_LotGrade) = False Then D2352.LotGrade = Trim$(rs2352!K2352_LotGrade)
            If IsdbNull(rs2352!K2352_Remark) = False Then D2352.Remark = Trim$(rs2352!K2352_Remark)
            If IsdbNull(rs2352!K2352_DateQC) = False Then D2352.DateQC = Trim$(rs2352!K2352_DateQC)
            If IsdbNull(rs2352!K2352_DateInsert) = False Then D2352.DateInsert = Trim$(rs2352!K2352_DateInsert)
            If IsdbNull(rs2352!K2352_DateUpdate) = False Then D2352.DateUpdate = Trim$(rs2352!K2352_DateUpdate)
            If IsdbNull(rs2352!K2352_InchargeInsert) = False Then D2352.InchargeInsert = Trim$(rs2352!K2352_InchargeInsert)
            If IsdbNull(rs2352!K2352_InchargeUpdate) = False Then D2352.InchargeUpdate = Trim$(rs2352!K2352_InchargeUpdate)
            If IsdbNull(rs2352!K2352_JobCard) = False Then D2352.JobCard = Trim$(rs2352!K2352_JobCard)
            If IsdbNull(rs2352!K2352_OrderNo) = False Then D2352.OrderNo = Trim$(rs2352!K2352_OrderNo)
            If IsdbNull(rs2352!K2352_OrderNoSeq) = False Then D2352.OrderNoSeq = Trim$(rs2352!K2352_OrderNoSeq)
            If IsdbNull(rs2352!K2352_JobCardWorking) = False Then D2352.JobCardWorking = Trim$(rs2352!K2352_JobCardWorking)
            If IsdbNull(rs2352!K2352_JobCardWorkingSeq) = False Then D2352.JobCardWorkingSeq = Trim$(rs2352!K2352_JobCardWorkingSeq)
            If IsdbNull(rs2352!K2352_JobCardPSeq) = False Then D2352.JobCardPSeq = Trim$(rs2352!K2352_JobCardPSeq)
            If IsdbNull(rs2352!K2352_JobCardType) = False Then D2352.JobCardType = Trim$(rs2352!K2352_JobCardType)
            If IsdbNull(rs2352!K2352_LotNo) = False Then D2352.LotNo = Trim$(rs2352!K2352_LotNo)
            If IsdbNull(rs2352!K2352_LotNoSeq) = False Then D2352.LotNoSeq = Trim$(rs2352!K2352_LotNoSeq)
            If IsdbNull(rs2352!K2352_CheckComplete) = False Then D2352.CheckComplete = Trim$(rs2352!K2352_CheckComplete)
            If IsdbNull(rs2352!K2352_CheckPrint) = False Then D2352.CheckPrint = Trim$(rs2352!K2352_CheckPrint)
            If IsdbNull(rs2352!K2352_TimePrint) = False Then D2352.TimePrint = Trim$(rs2352!K2352_TimePrint)
            If IsdbNull(rs2352!K2352_CheckAllocation) = False Then D2352.CheckAllocation = Trim$(rs2352!K2352_CheckAllocation)
            If IsDBNull(rs2352!K2352_TimeUpdate) = False Then D2352.TimeUpdate = Trim$(rs2352!K2352_TimeUpdate)
            If IsdbNull(rs2352!K2352_seSite) = False Then D2352.seSite = Trim$(rs2352!K2352_seSite)
            If IsdbNull(rs2352!K2352_cdSite) = False Then D2352.cdSite = Trim$(rs2352!K2352_cdSite)
            If IsdbNull(rs2352!K2352_InchargeQC) = False Then D2352.InchargeQC = Trim$(rs2352!K2352_InchargeQC)
            If IsdbNull(rs2352!K2352_PathImageQC) = False Then D2352.PathImageQC = Trim$(rs2352!K2352_PathImageQC)
            If IsdbNull(rs2352!K2352_RemarkQC) = False Then D2352.RemarkQC = Trim$(rs2352!K2352_RemarkQC)
            If IsdbNull(rs2352!K2352_Date20QC) = False Then D2352.Date20QC = Trim$(rs2352!K2352_Date20QC)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K2352_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K2352_MOVE(rs2352 As DataRow)
        Try

            Call D2352_CLEAR()

            If IsdbNull(rs2352!K2352_MaterialInBoundNo) = False Then D2352.MaterialInBoundNo = Trim$(rs2352!K2352_MaterialInBoundNo)
            If IsdbNull(rs2352!K2352_MaterialInBoundSeq) = False Then D2352.MaterialInBoundSeq = Trim$(rs2352!K2352_MaterialInBoundSeq)
            If IsdbNull(rs2352!K2352_MaterialInBoundSno) = False Then D2352.MaterialInBoundSno = Trim$(rs2352!K2352_MaterialInBoundSno)
            If IsdbNull(rs2352!K2352_MaterialInBoundDseq) = False Then D2352.MaterialInBoundDseq = Trim$(rs2352!K2352_MaterialInBoundDseq)
            If IsdbNull(rs2352!K2352_PackInBound) = False Then D2352.PackInBound = Trim$(rs2352!K2352_PackInBound)
            If IsdbNull(rs2352!K2352_QtyInBound_Or) = False Then D2352.QtyInBound_Or = Trim$(rs2352!K2352_QtyInBound_Or)
            If IsdbNull(rs2352!K2352_QtyInboundPL) = False Then D2352.QtyInboundPL = Trim$(rs2352!K2352_QtyInboundPL)
            If IsdbNull(rs2352!K2352_QtyInBound) = False Then D2352.QtyInBound = Trim$(rs2352!K2352_QtyInBound)
            If IsdbNull(rs2352!K2352_QtyInBoundQC) = False Then D2352.QtyInBoundQC = Trim$(rs2352!K2352_QtyInBoundQC)
            If IsdbNull(rs2352!K2352_AmountInBoundEX) = False Then D2352.AmountInBoundEX = Trim$(rs2352!K2352_AmountInBoundEX)
            If IsdbNull(rs2352!K2352_AmountInBoundVND) = False Then D2352.AmountInBoundVND = Trim$(rs2352!K2352_AmountInBoundVND)
            If IsdbNull(rs2352!K2352_PackOutBound) = False Then D2352.PackOutBound = Trim$(rs2352!K2352_PackOutBound)
            If IsdbNull(rs2352!K2352_QtyOutBound) = False Then D2352.QtyOutBound = Trim$(rs2352!K2352_QtyOutBound)
            If IsdbNull(rs2352!K2352_QtyConvert) = False Then D2352.QtyConvert = Trim$(rs2352!K2352_QtyConvert)
            If IsdbNull(rs2352!K2352_seWareHouseGroup) = False Then D2352.seWareHouseGroup = Trim$(rs2352!K2352_seWareHouseGroup)
            If IsdbNull(rs2352!K2352_cdWareHouseGroup) = False Then D2352.cdWareHouseGroup = Trim$(rs2352!K2352_cdWareHouseGroup)
            If IsdbNull(rs2352!K2352_seWareHousePosition) = False Then D2352.seWareHousePosition = Trim$(rs2352!K2352_seWareHousePosition)
            If IsdbNull(rs2352!K2352_cdWareHousePosition) = False Then D2352.cdWareHousePosition = Trim$(rs2352!K2352_cdWareHousePosition)
            If IsdbNull(rs2352!K2352_seDefectMaterial) = False Then D2352.seDefectMaterial = Trim$(rs2352!K2352_seDefectMaterial)
            If IsdbNull(rs2352!K2352_cdDefectMaterial) = False Then D2352.cdDefectMaterial = Trim$(rs2352!K2352_cdDefectMaterial)
            If IsdbNull(rs2352!K2352_SupplierName) = False Then D2352.SupplierName = Trim$(rs2352!K2352_SupplierName)
            If IsdbNull(rs2352!K2352_SOEName) = False Then D2352.SOEName = Trim$(rs2352!K2352_SOEName)
            If IsdbNull(rs2352!K2352_TypeName0) = False Then D2352.TypeName0 = Trim$(rs2352!K2352_TypeName0)
            If IsdbNull(rs2352!K2352_TypeName1) = False Then D2352.TypeName1 = Trim$(rs2352!K2352_TypeName1)
            If IsdbNull(rs2352!K2352_TypeName2) = False Then D2352.TypeName2 = Trim$(rs2352!K2352_TypeName2)
            If IsdbNull(rs2352!K2352_TypeName3) = False Then D2352.TypeName3 = Trim$(rs2352!K2352_TypeName3)
            If IsdbNull(rs2352!K2352_TypeName4) = False Then D2352.TypeName4 = Trim$(rs2352!K2352_TypeName4)
            If IsdbNull(rs2352!K2352_TypeName5) = False Then D2352.TypeName5 = Trim$(rs2352!K2352_TypeName5)
            If IsdbNull(rs2352!K2352_SizeName) = False Then D2352.SizeName = Trim$(rs2352!K2352_SizeName)
            If IsdbNull(rs2352!K2352_Grade) = False Then D2352.Grade = Trim$(rs2352!K2352_Grade)
            If IsdbNull(rs2352!K2352_Szno) = False Then D2352.Szno = Trim$(rs2352!K2352_Szno)
            If IsdbNull(rs2352!K2352_LotGrade) = False Then D2352.LotGrade = Trim$(rs2352!K2352_LotGrade)
            If IsdbNull(rs2352!K2352_Remark) = False Then D2352.Remark = Trim$(rs2352!K2352_Remark)
            If IsdbNull(rs2352!K2352_DateQC) = False Then D2352.DateQC = Trim$(rs2352!K2352_DateQC)
            If IsdbNull(rs2352!K2352_DateInsert) = False Then D2352.DateInsert = Trim$(rs2352!K2352_DateInsert)
            If IsdbNull(rs2352!K2352_DateUpdate) = False Then D2352.DateUpdate = Trim$(rs2352!K2352_DateUpdate)
            If IsdbNull(rs2352!K2352_InchargeInsert) = False Then D2352.InchargeInsert = Trim$(rs2352!K2352_InchargeInsert)
            If IsdbNull(rs2352!K2352_InchargeUpdate) = False Then D2352.InchargeUpdate = Trim$(rs2352!K2352_InchargeUpdate)
            If IsdbNull(rs2352!K2352_JobCard) = False Then D2352.JobCard = Trim$(rs2352!K2352_JobCard)
            If IsdbNull(rs2352!K2352_OrderNo) = False Then D2352.OrderNo = Trim$(rs2352!K2352_OrderNo)
            If IsdbNull(rs2352!K2352_OrderNoSeq) = False Then D2352.OrderNoSeq = Trim$(rs2352!K2352_OrderNoSeq)
            If IsdbNull(rs2352!K2352_JobCardWorking) = False Then D2352.JobCardWorking = Trim$(rs2352!K2352_JobCardWorking)
            If IsdbNull(rs2352!K2352_JobCardWorkingSeq) = False Then D2352.JobCardWorkingSeq = Trim$(rs2352!K2352_JobCardWorkingSeq)
            If IsdbNull(rs2352!K2352_JobCardPSeq) = False Then D2352.JobCardPSeq = Trim$(rs2352!K2352_JobCardPSeq)
            If IsdbNull(rs2352!K2352_JobCardType) = False Then D2352.JobCardType = Trim$(rs2352!K2352_JobCardType)
            If IsdbNull(rs2352!K2352_LotNo) = False Then D2352.LotNo = Trim$(rs2352!K2352_LotNo)
            If IsdbNull(rs2352!K2352_LotNoSeq) = False Then D2352.LotNoSeq = Trim$(rs2352!K2352_LotNoSeq)
            If IsdbNull(rs2352!K2352_CheckComplete) = False Then D2352.CheckComplete = Trim$(rs2352!K2352_CheckComplete)
            If IsdbNull(rs2352!K2352_CheckPrint) = False Then D2352.CheckPrint = Trim$(rs2352!K2352_CheckPrint)
            If IsdbNull(rs2352!K2352_TimePrint) = False Then D2352.TimePrint = Trim$(rs2352!K2352_TimePrint)
            If IsdbNull(rs2352!K2352_CheckAllocation) = False Then D2352.CheckAllocation = Trim$(rs2352!K2352_CheckAllocation)
            If IsDBNull(rs2352!K2352_TimeUpdate) = False Then D2352.TimeUpdate = Trim$(rs2352!K2352_TimeUpdate)
            If IsdbNull(rs2352!K2352_seSite) = False Then D2352.seSite = Trim$(rs2352!K2352_seSite)
            If IsdbNull(rs2352!K2352_cdSite) = False Then D2352.cdSite = Trim$(rs2352!K2352_cdSite)
            If IsdbNull(rs2352!K2352_InchargeQC) = False Then D2352.InchargeQC = Trim$(rs2352!K2352_InchargeQC)
            If IsdbNull(rs2352!K2352_PathImageQC) = False Then D2352.PathImageQC = Trim$(rs2352!K2352_PathImageQC)
            If IsdbNull(rs2352!K2352_RemarkQC) = False Then D2352.RemarkQC = Trim$(rs2352!K2352_RemarkQC)
            If IsdbNull(rs2352!K2352_Date20QC) = False Then D2352.Date20QC = Trim$(rs2352!K2352_Date20QC)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K2352_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K2352_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z2352 As T2352_AREA, MATERIALINBOUNDNO As String, MATERIALINBOUNDSEQ As String, MATERIALINBOUNDSNO As Double) As Boolean

        K2352_MOVE = False

        Try
            If READ_PFK2352(MATERIALINBOUNDNO, MATERIALINBOUNDSEQ, MATERIALINBOUNDSNO) = True Then
                z2352 = D2352
                K2352_MOVE = True
            Else
                z2352 = Nothing
            End If

            If getColumnIndex(spr, "MaterialInBoundNo") > -1 Then z2352.MaterialInBoundNo = getDataM(spr, getColumnIndex(spr, "MaterialInBoundNo"), xRow)
            If getColumnIndex(spr, "MaterialInBoundSeq") > -1 Then z2352.MaterialInBoundSeq = getDataM(spr, getColumnIndex(spr, "MaterialInBoundSeq"), xRow)
            If getColumnIndex(spr, "MaterialInBoundSno") > -1 Then z2352.MaterialInBoundSno = Cdecp(getDataM(spr, getColumnIndex(spr, "MaterialInBoundSno"), xRow))
            If getColumnIndex(spr, "MaterialInBoundDseq") > -1 Then z2352.MaterialInBoundDseq = Cdecp(getDataM(spr, getColumnIndex(spr, "MaterialInBoundDseq"), xRow))
            If getColumnIndex(spr, "PackInBound") > -1 Then z2352.PackInBound = Cdecp(getDataM(spr, getColumnIndex(spr, "PackInBound"), xRow))
            If getColumnIndex(spr, "QtyInBound_Or") > -1 Then z2352.QtyInBound_Or = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyInBound_Or"), xRow))
            If getColumnIndex(spr, "QtyInboundPL") > -1 Then z2352.QtyInboundPL = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyInboundPL"), xRow))
            If getColumnIndex(spr, "QtyInBound") > -1 Then z2352.QtyInBound = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyInBound"), xRow))
            If getColumnIndex(spr, "QtyInBoundQC") > -1 Then z2352.QtyInBoundQC = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyInBoundQC"), xRow))
            If getColumnIndex(spr, "AmountInBoundEX") > -1 Then z2352.AmountInBoundEX = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountInBoundEX"), xRow))
            If getColumnIndex(spr, "AmountInBoundVND") > -1 Then z2352.AmountInBoundVND = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountInBoundVND"), xRow))
            If getColumnIndex(spr, "PackOutBound") > -1 Then z2352.PackOutBound = Cdecp(getDataM(spr, getColumnIndex(spr, "PackOutBound"), xRow))
            If getColumnIndex(spr, "QtyOutBound") > -1 Then z2352.QtyOutBound = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyOutBound"), xRow))
            If getColumnIndex(spr, "QtyConvert") > -1 Then z2352.QtyConvert = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyConvert"), xRow))
            If getColumnIndex(spr, "seWareHouseGroup") > -1 Then z2352.seWareHouseGroup = getDataM(spr, getColumnIndex(spr, "seWareHouseGroup"), xRow)
            If getColumnIndex(spr, "cdWareHouseGroup") > -1 Then z2352.cdWareHouseGroup = getDataM(spr, getColumnIndex(spr, "cdWareHouseGroup"), xRow)
            If getColumnIndex(spr, "seWareHousePosition") > -1 Then z2352.seWareHousePosition = getDataM(spr, getColumnIndex(spr, "seWareHousePosition"), xRow)
            If getColumnIndex(spr, "cdWareHousePosition") > -1 Then z2352.cdWareHousePosition = getDataM(spr, getColumnIndex(spr, "cdWareHousePosition"), xRow)
            If getColumnIndex(spr, "seDefectMaterial") > -1 Then z2352.seDefectMaterial = getDataM(spr, getColumnIndex(spr, "seDefectMaterial"), xRow)
            If getColumnIndex(spr, "cdDefectMaterial") > -1 Then z2352.cdDefectMaterial = getDataM(spr, getColumnIndex(spr, "cdDefectMaterial"), xRow)
            If getColumnIndex(spr, "SupplierName") > -1 Then z2352.SupplierName = getDataM(spr, getColumnIndex(spr, "SupplierName"), xRow)
            If getColumnIndex(spr, "SOEName") > -1 Then z2352.SOEName = getDataM(spr, getColumnIndex(spr, "SOEName"), xRow)
            If getColumnIndex(spr, "TypeName0") > -1 Then z2352.TypeName0 = getDataM(spr, getColumnIndex(spr, "TypeName0"), xRow)
            If getColumnIndex(spr, "TypeName1") > -1 Then z2352.TypeName1 = getDataM(spr, getColumnIndex(spr, "TypeName1"), xRow)
            If getColumnIndex(spr, "TypeName2") > -1 Then z2352.TypeName2 = getDataM(spr, getColumnIndex(spr, "TypeName2"), xRow)
            If getColumnIndex(spr, "TypeName3") > -1 Then z2352.TypeName3 = getDataM(spr, getColumnIndex(spr, "TypeName3"), xRow)
            If getColumnIndex(spr, "TypeName4") > -1 Then z2352.TypeName4 = getDataM(spr, getColumnIndex(spr, "TypeName4"), xRow)
            If getColumnIndex(spr, "TypeName5") > -1 Then z2352.TypeName5 = getDataM(spr, getColumnIndex(spr, "TypeName5"), xRow)
            If getColumnIndex(spr, "SizeName") > -1 Then z2352.SizeName = getDataM(spr, getColumnIndex(spr, "SizeName"), xRow)
            If getColumnIndex(spr, "Grade") > -1 Then z2352.Grade = getDataM(spr, getColumnIndex(spr, "Grade"), xRow)
            If getColumnIndex(spr, "Szno") > -1 Then z2352.Szno = getDataM(spr, getColumnIndex(spr, "Szno"), xRow)
            If getColumnIndex(spr, "LotGrade") > -1 Then z2352.LotGrade = getDataM(spr, getColumnIndex(spr, "LotGrade"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z2352.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)
            If getColumnIndex(spr, "DateQC") > -1 Then z2352.DateQC = getDataM(spr, getColumnIndex(spr, "DateQC"), xRow)
            If getColumnIndex(spr, "DateInsert") > -1 Then z2352.DateInsert = getDataM(spr, getColumnIndex(spr, "DateInsert"), xRow)
            If getColumnIndex(spr, "DateUpdate") > -1 Then z2352.DateUpdate = getDataM(spr, getColumnIndex(spr, "DateUpdate"), xRow)
            If getColumnIndex(spr, "InchargeInsert") > -1 Then z2352.InchargeInsert = getDataM(spr, getColumnIndex(spr, "InchargeInsert"), xRow)
            If getColumnIndex(spr, "InchargeUpdate") > -1 Then z2352.InchargeUpdate = getDataM(spr, getColumnIndex(spr, "InchargeUpdate"), xRow)
            If getColumnIndex(spr, "JobCard") > -1 Then z2352.JobCard = getDataM(spr, getColumnIndex(spr, "JobCard"), xRow)
            If getColumnIndex(spr, "OrderNo") > -1 Then z2352.OrderNo = getDataM(spr, getColumnIndex(spr, "OrderNo"), xRow)
            If getColumnIndex(spr, "OrderNoSeq") > -1 Then z2352.OrderNoSeq = getDataM(spr, getColumnIndex(spr, "OrderNoSeq"), xRow)
            If getColumnIndex(spr, "JobCardWorking") > -1 Then z2352.JobCardWorking = getDataM(spr, getColumnIndex(spr, "JobCardWorking"), xRow)
            If getColumnIndex(spr, "JobCardWorkingSeq") > -1 Then z2352.JobCardWorkingSeq = getDataM(spr, getColumnIndex(spr, "JobCardWorkingSeq"), xRow)
            If getColumnIndex(spr, "JobCardPSeq") > -1 Then z2352.JobCardPSeq = getDataM(spr, getColumnIndex(spr, "JobCardPSeq"), xRow)
            If getColumnIndex(spr, "JobCardType") > -1 Then z2352.JobCardType = getDataM(spr, getColumnIndex(spr, "JobCardType"), xRow)
            If getColumnIndex(spr, "LotNo") > -1 Then z2352.LotNo = getDataM(spr, getColumnIndex(spr, "LotNo"), xRow)
            If getColumnIndex(spr, "LotNoSeq") > -1 Then z2352.LotNoSeq = getDataM(spr, getColumnIndex(spr, "LotNoSeq"), xRow)
            If getColumnIndex(spr, "CheckComplete") > -1 Then z2352.CheckComplete = getDataM(spr, getColumnIndex(spr, "CheckComplete"), xRow)
            If getColumnIndex(spr, "CheckPrint") > -1 Then z2352.CheckPrint = getDataM(spr, getColumnIndex(spr, "CheckPrint"), xRow)
            If getColumnIndex(spr, "TimePrint") > -1 Then z2352.TimePrint = getDataM(spr, getColumnIndex(spr, "TimePrint"), xRow)
            If getColumnIndex(spr, "CheckAllocation") > -1 Then z2352.CheckAllocation = getDataM(spr, getColumnIndex(spr, "CheckAllocation"), xRow)
            If getColumnIndex(spr, "TimeUpdate") > -1 Then z2352.TimeUpdate = getDataM(spr, getColumnIndex(spr, "TimeUpdate"), xRow)
            If getColumnIndex(spr, "seSite") > -1 Then z2352.seSite = getDataM(spr, getColumnIndex(spr, "seSite"), xRow)
            If getColumnIndex(spr, "cdSite") > -1 Then z2352.cdSite = getDataM(spr, getColumnIndex(spr, "cdSite"), xRow)
            If getColumnIndex(spr, "InchargeQC") > -1 Then z2352.InchargeQC = getDataM(spr, getColumnIndex(spr, "InchargeQC"), xRow)
            If getColumnIndex(spr, "PathImageQC") > -1 Then z2352.PathImageQC = getDataM(spr, getColumnIndex(spr, "PathImageQC"), xRow)
            If getColumnIndex(spr, "RemarkQC") > -1 Then z2352.RemarkQC = getDataM(spr, getColumnIndex(spr, "RemarkQC"), xRow)
            If getColumnIndex(spr, "Date20QC") > -1 Then z2352.Date20QC = getDataM(spr, getColumnIndex(spr, "Date20QC"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2352_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K2352_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z2352 As T2352_AREA, CheckClear As Boolean, MATERIALINBOUNDNO As String, MATERIALINBOUNDSEQ As String, MATERIALINBOUNDSNO As Double) As Boolean

        K2352_MOVE = False

        Try
            If READ_PFK2352(MATERIALINBOUNDNO, MATERIALINBOUNDSEQ, MATERIALINBOUNDSNO) = True Then
                z2352 = D2352
                K2352_MOVE = True
            Else
                If CheckClear = True Then z2352 = Nothing
            End If

            If getColumnIndex(spr, "MaterialInBoundNo") > -1 Then z2352.MaterialInBoundNo = getDataM(spr, getColumnIndex(spr, "MaterialInBoundNo"), xRow)
            If getColumnIndex(spr, "MaterialInBoundSeq") > -1 Then z2352.MaterialInBoundSeq = getDataM(spr, getColumnIndex(spr, "MaterialInBoundSeq"), xRow)
            If getColumnIndex(spr, "MaterialInBoundSno") > -1 Then z2352.MaterialInBoundSno = Cdecp(getDataM(spr, getColumnIndex(spr, "MaterialInBoundSno"), xRow))
            If getColumnIndex(spr, "MaterialInBoundDseq") > -1 Then z2352.MaterialInBoundDseq = Cdecp(getDataM(spr, getColumnIndex(spr, "MaterialInBoundDseq"), xRow))
            If getColumnIndex(spr, "PackInBound") > -1 Then z2352.PackInBound = Cdecp(getDataM(spr, getColumnIndex(spr, "PackInBound"), xRow))
            If getColumnIndex(spr, "QtyInBound_Or") > -1 Then z2352.QtyInBound_Or = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyInBound_Or"), xRow))
            If getColumnIndex(spr, "QtyInboundPL") > -1 Then z2352.QtyInboundPL = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyInboundPL"), xRow))
            If getColumnIndex(spr, "QtyInBound") > -1 Then z2352.QtyInBound = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyInBound"), xRow))
            If getColumnIndex(spr, "QtyInBoundQC") > -1 Then z2352.QtyInBoundQC = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyInBoundQC"), xRow))
            If getColumnIndex(spr, "AmountInBoundEX") > -1 Then z2352.AmountInBoundEX = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountInBoundEX"), xRow))
            If getColumnIndex(spr, "AmountInBoundVND") > -1 Then z2352.AmountInBoundVND = Cdecp(getDataM(spr, getColumnIndex(spr, "AmountInBoundVND"), xRow))
            If getColumnIndex(spr, "PackOutBound") > -1 Then z2352.PackOutBound = Cdecp(getDataM(spr, getColumnIndex(spr, "PackOutBound"), xRow))
            If getColumnIndex(spr, "QtyOutBound") > -1 Then z2352.QtyOutBound = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyOutBound"), xRow))
            If getColumnIndex(spr, "QtyConvert") > -1 Then z2352.QtyConvert = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyConvert"), xRow))
            If getColumnIndex(spr, "seWareHouseGroup") > -1 Then z2352.seWareHouseGroup = getDataM(spr, getColumnIndex(spr, "seWareHouseGroup"), xRow)
            If getColumnIndex(spr, "cdWareHouseGroup") > -1 Then z2352.cdWareHouseGroup = getDataM(spr, getColumnIndex(spr, "cdWareHouseGroup"), xRow)
            If getColumnIndex(spr, "seWareHousePosition") > -1 Then z2352.seWareHousePosition = getDataM(spr, getColumnIndex(spr, "seWareHousePosition"), xRow)
            If getColumnIndex(spr, "cdWareHousePosition") > -1 Then z2352.cdWareHousePosition = getDataM(spr, getColumnIndex(spr, "cdWareHousePosition"), xRow)
            If getColumnIndex(spr, "seDefectMaterial") > -1 Then z2352.seDefectMaterial = getDataM(spr, getColumnIndex(spr, "seDefectMaterial"), xRow)
            If getColumnIndex(spr, "cdDefectMaterial") > -1 Then z2352.cdDefectMaterial = getDataM(spr, getColumnIndex(spr, "cdDefectMaterial"), xRow)
            If getColumnIndex(spr, "SupplierName") > -1 Then z2352.SupplierName = getDataM(spr, getColumnIndex(spr, "SupplierName"), xRow)
            If getColumnIndex(spr, "SOEName") > -1 Then z2352.SOEName = getDataM(spr, getColumnIndex(spr, "SOEName"), xRow)
            If getColumnIndex(spr, "TypeName0") > -1 Then z2352.TypeName0 = getDataM(spr, getColumnIndex(spr, "TypeName0"), xRow)
            If getColumnIndex(spr, "TypeName1") > -1 Then z2352.TypeName1 = getDataM(spr, getColumnIndex(spr, "TypeName1"), xRow)
            If getColumnIndex(spr, "TypeName2") > -1 Then z2352.TypeName2 = getDataM(spr, getColumnIndex(spr, "TypeName2"), xRow)
            If getColumnIndex(spr, "TypeName3") > -1 Then z2352.TypeName3 = getDataM(spr, getColumnIndex(spr, "TypeName3"), xRow)
            If getColumnIndex(spr, "TypeName4") > -1 Then z2352.TypeName4 = getDataM(spr, getColumnIndex(spr, "TypeName4"), xRow)
            If getColumnIndex(spr, "TypeName5") > -1 Then z2352.TypeName5 = getDataM(spr, getColumnIndex(spr, "TypeName5"), xRow)
            If getColumnIndex(spr, "SizeName") > -1 Then z2352.SizeName = getDataM(spr, getColumnIndex(spr, "SizeName"), xRow)
            If getColumnIndex(spr, "Grade") > -1 Then z2352.Grade = getDataM(spr, getColumnIndex(spr, "Grade"), xRow)
            If getColumnIndex(spr, "Szno") > -1 Then z2352.Szno = getDataM(spr, getColumnIndex(spr, "Szno"), xRow)
            If getColumnIndex(spr, "LotGrade") > -1 Then z2352.LotGrade = getDataM(spr, getColumnIndex(spr, "LotGrade"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z2352.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)
            If getColumnIndex(spr, "DateQC") > -1 Then z2352.DateQC = getDataM(spr, getColumnIndex(spr, "DateQC"), xRow)
            If getColumnIndex(spr, "DateInsert") > -1 Then z2352.DateInsert = getDataM(spr, getColumnIndex(spr, "DateInsert"), xRow)
            If getColumnIndex(spr, "DateUpdate") > -1 Then z2352.DateUpdate = getDataM(spr, getColumnIndex(spr, "DateUpdate"), xRow)
            If getColumnIndex(spr, "InchargeInsert") > -1 Then z2352.InchargeInsert = getDataM(spr, getColumnIndex(spr, "InchargeInsert"), xRow)
            If getColumnIndex(spr, "InchargeUpdate") > -1 Then z2352.InchargeUpdate = getDataM(spr, getColumnIndex(spr, "InchargeUpdate"), xRow)
            If getColumnIndex(spr, "JobCard") > -1 Then z2352.JobCard = getDataM(spr, getColumnIndex(spr, "JobCard"), xRow)
            If getColumnIndex(spr, "OrderNo") > -1 Then z2352.OrderNo = getDataM(spr, getColumnIndex(spr, "OrderNo"), xRow)
            If getColumnIndex(spr, "OrderNoSeq") > -1 Then z2352.OrderNoSeq = getDataM(spr, getColumnIndex(spr, "OrderNoSeq"), xRow)
            If getColumnIndex(spr, "JobCardWorking") > -1 Then z2352.JobCardWorking = getDataM(spr, getColumnIndex(spr, "JobCardWorking"), xRow)
            If getColumnIndex(spr, "JobCardWorkingSeq") > -1 Then z2352.JobCardWorkingSeq = getDataM(spr, getColumnIndex(spr, "JobCardWorkingSeq"), xRow)
            If getColumnIndex(spr, "JobCardPSeq") > -1 Then z2352.JobCardPSeq = getDataM(spr, getColumnIndex(spr, "JobCardPSeq"), xRow)
            If getColumnIndex(spr, "JobCardType") > -1 Then z2352.JobCardType = getDataM(spr, getColumnIndex(spr, "JobCardType"), xRow)
            If getColumnIndex(spr, "LotNo") > -1 Then z2352.LotNo = getDataM(spr, getColumnIndex(spr, "LotNo"), xRow)
            If getColumnIndex(spr, "LotNoSeq") > -1 Then z2352.LotNoSeq = getDataM(spr, getColumnIndex(spr, "LotNoSeq"), xRow)
            If getColumnIndex(spr, "CheckComplete") > -1 Then z2352.CheckComplete = getDataM(spr, getColumnIndex(spr, "CheckComplete"), xRow)
            If getColumnIndex(spr, "CheckPrint") > -1 Then z2352.CheckPrint = getDataM(spr, getColumnIndex(spr, "CheckPrint"), xRow)
            If getColumnIndex(spr, "TimePrint") > -1 Then z2352.TimePrint = getDataM(spr, getColumnIndex(spr, "TimePrint"), xRow)
            If getColumnIndex(spr, "CheckAllocation") > -1 Then z2352.CheckAllocation = getDataM(spr, getColumnIndex(spr, "CheckAllocation"), xRow)
            If getColumnIndex(spr, "TimeUpdate") > -1 Then z2352.TimeUpdate = getDataM(spr, getColumnIndex(spr, "TimeUpdate"), xRow)
            If getColumnIndex(spr, "seSite") > -1 Then z2352.seSite = getDataM(spr, getColumnIndex(spr, "seSite"), xRow)
            If getColumnIndex(spr, "cdSite") > -1 Then z2352.cdSite = getDataM(spr, getColumnIndex(spr, "cdSite"), xRow)
            If getColumnIndex(spr, "InchargeQC") > -1 Then z2352.InchargeQC = getDataM(spr, getColumnIndex(spr, "InchargeQC"), xRow)
            If getColumnIndex(spr, "PathImageQC") > -1 Then z2352.PathImageQC = getDataM(spr, getColumnIndex(spr, "PathImageQC"), xRow)
            If getColumnIndex(spr, "RemarkQC") > -1 Then z2352.RemarkQC = getDataM(spr, getColumnIndex(spr, "RemarkQC"), xRow)
            If getColumnIndex(spr, "Date20QC") > -1 Then z2352.Date20QC = getDataM(spr, getColumnIndex(spr, "Date20QC"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2352_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K2352_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z2352 As T2352_AREA, Job As String, MATERIALINBOUNDNO As String, MATERIALINBOUNDSEQ As String, MATERIALINBOUNDSNO As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K2352_MOVE = False

        Try
            If READ_PFK2352(MATERIALINBOUNDNO, MATERIALINBOUNDSEQ, MATERIALINBOUNDSNO) = True Then
                z2352 = D2352
                K2352_MOVE = True
            Else
                z2352 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2352")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "MATERIALINBOUNDNO" : z2352.MaterialInBoundNo = Children(i).Code
                                Case "MATERIALINBOUNDSEQ" : z2352.MaterialInBoundSeq = Children(i).Code
                                Case "MATERIALINBOUNDSNO" : z2352.MaterialInBoundSno = Children(i).Code
                                Case "MATERIALINBOUNDDSEQ" : z2352.MaterialInBoundDseq = Children(i).Code
                                Case "PACKINBOUND" : z2352.PackInBound = Children(i).Code
                                Case "QTYINBOUND_OR" : z2352.QtyInBound_Or = Children(i).Code
                                Case "QTYINBOUNDPL" : z2352.QtyInboundPL = Children(i).Code
                                Case "QTYINBOUND" : z2352.QtyInBound = Children(i).Code
                                Case "QTYINBOUNDQC" : z2352.QtyInBoundQC = Children(i).Code
                                Case "AMOUNTINBOUNDEX" : z2352.AmountInBoundEX = Children(i).Code
                                Case "AMOUNTINBOUNDVND" : z2352.AmountInBoundVND = Children(i).Code
                                Case "PACKOUTBOUND" : z2352.PackOutBound = Children(i).Code
                                Case "QTYOUTBOUND" : z2352.QtyOutBound = Children(i).Code
                                Case "QTYCONVERT" : z2352.QtyConvert = Children(i).Code
                                Case "SEWAREHOUSEGROUP" : z2352.seWareHouseGroup = Children(i).Code
                                Case "CDWAREHOUSEGROUP" : z2352.cdWareHouseGroup = Children(i).Code
                                Case "SEWAREHOUSEPOSITION" : z2352.seWareHousePosition = Children(i).Code
                                Case "CDWAREHOUSEPOSITION" : z2352.cdWareHousePosition = Children(i).Code
                                Case "SEDEFECTMATERIAL" : z2352.seDefectMaterial = Children(i).Code
                                Case "CDDEFECTMATERIAL" : z2352.cdDefectMaterial = Children(i).Code
                                Case "SUPPLIERNAME" : z2352.SupplierName = Children(i).Code
                                Case "SOENAME" : z2352.SOEName = Children(i).Code
                                Case "TYPENAME0" : z2352.TypeName0 = Children(i).Code
                                Case "TYPENAME1" : z2352.TypeName1 = Children(i).Code
                                Case "TYPENAME2" : z2352.TypeName2 = Children(i).Code
                                Case "TYPENAME3" : z2352.TypeName3 = Children(i).Code
                                Case "TYPENAME4" : z2352.TypeName4 = Children(i).Code
                                Case "TYPENAME5" : z2352.TypeName5 = Children(i).Code
                                Case "SIZENAME" : z2352.SizeName = Children(i).Code
                                Case "GRADE" : z2352.Grade = Children(i).Code
                                Case "SZNO" : z2352.Szno = Children(i).Code
                                Case "LOTGRADE" : z2352.LotGrade = Children(i).Code
                                Case "REMARK" : z2352.Remark = Children(i).Code
                                Case "DATEQC" : z2352.DateQC = Children(i).Code
                                Case "DATEINSERT" : z2352.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z2352.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z2352.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z2352.InchargeUpdate = Children(i).Code
                                Case "JOBCARD" : z2352.JobCard = Children(i).Code
                                Case "ORDERNO" : z2352.OrderNo = Children(i).Code
                                Case "ORDERNOSEQ" : z2352.OrderNoSeq = Children(i).Code
                                Case "JOBCARDWORKING" : z2352.JobCardWorking = Children(i).Code
                                Case "JOBCARDWORKINGSEQ" : z2352.JobCardWorkingSeq = Children(i).Code
                                Case "JOBCARDPSEQ" : z2352.JobCardPSeq = Children(i).Code
                                Case "JOBCARDTYPE" : z2352.JobCardType = Children(i).Code
                                Case "LOTNO" : z2352.LotNo = Children(i).Code
                                Case "LOTNOSEQ" : z2352.LotNoSeq = Children(i).Code
                                Case "CHECKCOMPLETE" : z2352.CheckComplete = Children(i).Code
                                Case "CHECKPRINT" : z2352.CheckPrint = Children(i).Code
                                Case "TIMEPRINT" : z2352.TimePrint = Children(i).Code
                                Case "CHECKALLOCATION" : z2352.CheckAllocation = Children(i).Code
                                Case "TIMEUPDATE" : z2352.TimeUpdate = Children(i).Code
                                Case "SESITE" : z2352.seSite = Children(i).Code
                                Case "CDSITE" : z2352.cdSite = Children(i).Code
                                Case "INCHARGEQC" : z2352.InchargeQC = Children(i).Code
                                Case "PATHIMAGEQC" : z2352.PathImageQC = Children(i).Code
                                Case "REMARKQC" : z2352.RemarkQC = Children(i).Code
                                Case "DATE20QC" : z2352.Date20QC = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "MATERIALINBOUNDNO" : z2352.MaterialInBoundNo = Children(i).Data
                                Case "MATERIALINBOUNDSEQ" : z2352.MaterialInBoundSeq = Children(i).Data
                                Case "MATERIALINBOUNDSNO" : z2352.MaterialInBoundSno = Cdecp(Children(i).Data)
                                Case "MATERIALINBOUNDDSEQ" : z2352.MaterialInBoundDseq = Cdecp(Children(i).Data)
                                Case "PACKINBOUND" : z2352.PackInBound = Cdecp(Children(i).Data)
                                Case "QTYINBOUND_OR" : z2352.QtyInBound_Or = Cdecp(Children(i).Data)
                                Case "QTYINBOUNDPL" : z2352.QtyInboundPL = Cdecp(Children(i).Data)
                                Case "QTYINBOUND" : z2352.QtyInBound = Cdecp(Children(i).Data)
                                Case "QTYINBOUNDQC" : z2352.QtyInBoundQC = Cdecp(Children(i).Data)
                                Case "AMOUNTINBOUNDEX" : z2352.AmountInBoundEX = Cdecp(Children(i).Data)
                                Case "AMOUNTINBOUNDVND" : z2352.AmountInBoundVND = Cdecp(Children(i).Data)
                                Case "PACKOUTBOUND" : z2352.PackOutBound = Cdecp(Children(i).Data)
                                Case "QTYOUTBOUND" : z2352.QtyOutBound = Cdecp(Children(i).Data)
                                Case "QTYCONVERT" : z2352.QtyConvert = Cdecp(Children(i).Data)
                                Case "SEWAREHOUSEGROUP" : z2352.seWareHouseGroup = Children(i).Data
                                Case "CDWAREHOUSEGROUP" : z2352.cdWareHouseGroup = Children(i).Data
                                Case "SEWAREHOUSEPOSITION" : z2352.seWareHousePosition = Children(i).Data
                                Case "CDWAREHOUSEPOSITION" : z2352.cdWareHousePosition = Children(i).Data
                                Case "SEDEFECTMATERIAL" : z2352.seDefectMaterial = Children(i).Data
                                Case "CDDEFECTMATERIAL" : z2352.cdDefectMaterial = Children(i).Data
                                Case "SUPPLIERNAME" : z2352.SupplierName = Children(i).Data
                                Case "SOENAME" : z2352.SOEName = Children(i).Data
                                Case "TYPENAME0" : z2352.TypeName0 = Children(i).Data
                                Case "TYPENAME1" : z2352.TypeName1 = Children(i).Data
                                Case "TYPENAME2" : z2352.TypeName2 = Children(i).Data
                                Case "TYPENAME3" : z2352.TypeName3 = Children(i).Data
                                Case "TYPENAME4" : z2352.TypeName4 = Children(i).Data
                                Case "TYPENAME5" : z2352.TypeName5 = Children(i).Data
                                Case "SIZENAME" : z2352.SizeName = Children(i).Data
                                Case "GRADE" : z2352.Grade = Children(i).Data
                                Case "SZNO" : z2352.Szno = Children(i).Data
                                Case "LOTGRADE" : z2352.LotGrade = Children(i).Data
                                Case "REMARK" : z2352.Remark = Children(i).Data
                                Case "DATEQC" : z2352.DateQC = Children(i).Data
                                Case "DATEINSERT" : z2352.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z2352.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z2352.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z2352.InchargeUpdate = Children(i).Data
                                Case "JOBCARD" : z2352.JobCard = Children(i).Data
                                Case "ORDERNO" : z2352.OrderNo = Children(i).Data
                                Case "ORDERNOSEQ" : z2352.OrderNoSeq = Children(i).Data
                                Case "JOBCARDWORKING" : z2352.JobCardWorking = Children(i).Data
                                Case "JOBCARDWORKINGSEQ" : z2352.JobCardWorkingSeq = Children(i).Data
                                Case "JOBCARDPSEQ" : z2352.JobCardPSeq = Children(i).Data
                                Case "JOBCARDTYPE" : z2352.JobCardType = Children(i).Data
                                Case "LOTNO" : z2352.LotNo = Children(i).Data
                                Case "LOTNOSEQ" : z2352.LotNoSeq = Children(i).Data
                                Case "CHECKCOMPLETE" : z2352.CheckComplete = Children(i).Data
                                Case "CHECKPRINT" : z2352.CheckPrint = Children(i).Data
                                Case "TIMEPRINT" : z2352.TimePrint = Children(i).Data
                                Case "CHECKALLOCATION" : z2352.CheckAllocation = Children(i).Data
                                Case "TIMEUPDATE" : z2352.TimeUpdate = Children(i).Data
                                Case "SESITE" : z2352.seSite = Children(i).Data
                                Case "CDSITE" : z2352.cdSite = Children(i).Data
                                Case "INCHARGEQC" : z2352.InchargeQC = Children(i).Data
                                Case "PATHIMAGEQC" : z2352.PathImageQC = Children(i).Data
                                Case "REMARKQC" : z2352.RemarkQC = Children(i).Data
                                Case "DATE20QC" : z2352.Date20QC = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2352_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K2352_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z2352 As T2352_AREA, Job As String, CheckClear As Boolean, MATERIALINBOUNDNO As String, MATERIALINBOUNDSEQ As String, MATERIALINBOUNDSNO As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K2352_MOVE = False

        Try
            If READ_PFK2352(MATERIALINBOUNDNO, MATERIALINBOUNDSEQ, MATERIALINBOUNDSNO) = True Then
                z2352 = D2352
                K2352_MOVE = True
            Else
                If CheckClear = True Then z2352 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2352")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "MATERIALINBOUNDNO" : z2352.MaterialInBoundNo = Children(i).Code
                                Case "MATERIALINBOUNDSEQ" : z2352.MaterialInBoundSeq = Children(i).Code
                                Case "MATERIALINBOUNDSNO" : z2352.MaterialInBoundSno = Children(i).Code
                                Case "MATERIALINBOUNDDSEQ" : z2352.MaterialInBoundDseq = Children(i).Code
                                Case "PACKINBOUND" : z2352.PackInBound = Children(i).Code
                                Case "QTYINBOUND_OR" : z2352.QtyInBound_Or = Children(i).Code
                                Case "QTYINBOUNDPL" : z2352.QtyInboundPL = Children(i).Code
                                Case "QTYINBOUND" : z2352.QtyInBound = Children(i).Code
                                Case "QTYINBOUNDQC" : z2352.QtyInBoundQC = Children(i).Code
                                Case "AMOUNTINBOUNDEX" : z2352.AmountInBoundEX = Children(i).Code
                                Case "AMOUNTINBOUNDVND" : z2352.AmountInBoundVND = Children(i).Code
                                Case "PACKOUTBOUND" : z2352.PackOutBound = Children(i).Code
                                Case "QTYOUTBOUND" : z2352.QtyOutBound = Children(i).Code
                                Case "QTYCONVERT" : z2352.QtyConvert = Children(i).Code
                                Case "SEWAREHOUSEGROUP" : z2352.seWareHouseGroup = Children(i).Code
                                Case "CDWAREHOUSEGROUP" : z2352.cdWareHouseGroup = Children(i).Code
                                Case "SEWAREHOUSEPOSITION" : z2352.seWareHousePosition = Children(i).Code
                                Case "CDWAREHOUSEPOSITION" : z2352.cdWareHousePosition = Children(i).Code
                                Case "SEDEFECTMATERIAL" : z2352.seDefectMaterial = Children(i).Code
                                Case "CDDEFECTMATERIAL" : z2352.cdDefectMaterial = Children(i).Code
                                Case "SUPPLIERNAME" : z2352.SupplierName = Children(i).Code
                                Case "SOENAME" : z2352.SOEName = Children(i).Code
                                Case "TYPENAME0" : z2352.TypeName0 = Children(i).Code
                                Case "TYPENAME1" : z2352.TypeName1 = Children(i).Code
                                Case "TYPENAME2" : z2352.TypeName2 = Children(i).Code
                                Case "TYPENAME3" : z2352.TypeName3 = Children(i).Code
                                Case "TYPENAME4" : z2352.TypeName4 = Children(i).Code
                                Case "TYPENAME5" : z2352.TypeName5 = Children(i).Code
                                Case "SIZENAME" : z2352.SizeName = Children(i).Code
                                Case "GRADE" : z2352.Grade = Children(i).Code
                                Case "SZNO" : z2352.Szno = Children(i).Code
                                Case "LOTGRADE" : z2352.LotGrade = Children(i).Code
                                Case "REMARK" : z2352.Remark = Children(i).Code
                                Case "DATEQC" : z2352.DateQC = Children(i).Code
                                Case "DATEINSERT" : z2352.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z2352.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z2352.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z2352.InchargeUpdate = Children(i).Code
                                Case "JOBCARD" : z2352.JobCard = Children(i).Code
                                Case "ORDERNO" : z2352.OrderNo = Children(i).Code
                                Case "ORDERNOSEQ" : z2352.OrderNoSeq = Children(i).Code
                                Case "JOBCARDWORKING" : z2352.JobCardWorking = Children(i).Code
                                Case "JOBCARDWORKINGSEQ" : z2352.JobCardWorkingSeq = Children(i).Code
                                Case "JOBCARDPSEQ" : z2352.JobCardPSeq = Children(i).Code
                                Case "JOBCARDTYPE" : z2352.JobCardType = Children(i).Code
                                Case "LOTNO" : z2352.LotNo = Children(i).Code
                                Case "LOTNOSEQ" : z2352.LotNoSeq = Children(i).Code
                                Case "CHECKCOMPLETE" : z2352.CheckComplete = Children(i).Code
                                Case "CHECKPRINT" : z2352.CheckPrint = Children(i).Code
                                Case "TIMEPRINT" : z2352.TimePrint = Children(i).Code
                                Case "CHECKALLOCATION" : z2352.CheckAllocation = Children(i).Code
                                Case "TIMEUPDATE" : z2352.TimeUpdate = Children(i).Code
                                Case "SESITE" : z2352.seSite = Children(i).Code
                                Case "CDSITE" : z2352.cdSite = Children(i).Code
                                Case "INCHARGEQC" : z2352.InchargeQC = Children(i).Code
                                Case "PATHIMAGEQC" : z2352.PathImageQC = Children(i).Code
                                Case "REMARKQC" : z2352.RemarkQC = Children(i).Code
                                Case "DATE20QC" : z2352.Date20QC = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "MATERIALINBOUNDNO" : z2352.MaterialInBoundNo = Children(i).Data
                                Case "MATERIALINBOUNDSEQ" : z2352.MaterialInBoundSeq = Children(i).Data
                                Case "MATERIALINBOUNDSNO" : z2352.MaterialInBoundSno = Cdecp(Children(i).Data)
                                Case "MATERIALINBOUNDDSEQ" : z2352.MaterialInBoundDseq = Cdecp(Children(i).Data)
                                Case "PACKINBOUND" : z2352.PackInBound = Cdecp(Children(i).Data)
                                Case "QTYINBOUND_OR" : z2352.QtyInBound_Or = Cdecp(Children(i).Data)
                                Case "QTYINBOUNDPL" : z2352.QtyInboundPL = Cdecp(Children(i).Data)
                                Case "QTYINBOUND" : z2352.QtyInBound = Cdecp(Children(i).Data)
                                Case "QTYINBOUNDQC" : z2352.QtyInBoundQC = Cdecp(Children(i).Data)
                                Case "AMOUNTINBOUNDEX" : z2352.AmountInBoundEX = Cdecp(Children(i).Data)
                                Case "AMOUNTINBOUNDVND" : z2352.AmountInBoundVND = Cdecp(Children(i).Data)
                                Case "PACKOUTBOUND" : z2352.PackOutBound = Cdecp(Children(i).Data)
                                Case "QTYOUTBOUND" : z2352.QtyOutBound = Cdecp(Children(i).Data)
                                Case "QTYCONVERT" : z2352.QtyConvert = Cdecp(Children(i).Data)
                                Case "SEWAREHOUSEGROUP" : z2352.seWareHouseGroup = Children(i).Data
                                Case "CDWAREHOUSEGROUP" : z2352.cdWareHouseGroup = Children(i).Data
                                Case "SEWAREHOUSEPOSITION" : z2352.seWareHousePosition = Children(i).Data
                                Case "CDWAREHOUSEPOSITION" : z2352.cdWareHousePosition = Children(i).Data
                                Case "SEDEFECTMATERIAL" : z2352.seDefectMaterial = Children(i).Data
                                Case "CDDEFECTMATERIAL" : z2352.cdDefectMaterial = Children(i).Data
                                Case "SUPPLIERNAME" : z2352.SupplierName = Children(i).Data
                                Case "SOENAME" : z2352.SOEName = Children(i).Data
                                Case "TYPENAME0" : z2352.TypeName0 = Children(i).Data
                                Case "TYPENAME1" : z2352.TypeName1 = Children(i).Data
                                Case "TYPENAME2" : z2352.TypeName2 = Children(i).Data
                                Case "TYPENAME3" : z2352.TypeName3 = Children(i).Data
                                Case "TYPENAME4" : z2352.TypeName4 = Children(i).Data
                                Case "TYPENAME5" : z2352.TypeName5 = Children(i).Data
                                Case "SIZENAME" : z2352.SizeName = Children(i).Data
                                Case "GRADE" : z2352.Grade = Children(i).Data
                                Case "SZNO" : z2352.Szno = Children(i).Data
                                Case "LOTGRADE" : z2352.LotGrade = Children(i).Data
                                Case "REMARK" : z2352.Remark = Children(i).Data
                                Case "DATEQC" : z2352.DateQC = Children(i).Data
                                Case "DATEINSERT" : z2352.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z2352.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z2352.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z2352.InchargeUpdate = Children(i).Data
                                Case "JOBCARD" : z2352.JobCard = Children(i).Data
                                Case "ORDERNO" : z2352.OrderNo = Children(i).Data
                                Case "ORDERNOSEQ" : z2352.OrderNoSeq = Children(i).Data
                                Case "JOBCARDWORKING" : z2352.JobCardWorking = Children(i).Data
                                Case "JOBCARDWORKINGSEQ" : z2352.JobCardWorkingSeq = Children(i).Data
                                Case "JOBCARDPSEQ" : z2352.JobCardPSeq = Children(i).Data
                                Case "JOBCARDTYPE" : z2352.JobCardType = Children(i).Data
                                Case "LOTNO" : z2352.LotNo = Children(i).Data
                                Case "LOTNOSEQ" : z2352.LotNoSeq = Children(i).Data
                                Case "CHECKCOMPLETE" : z2352.CheckComplete = Children(i).Data
                                Case "CHECKPRINT" : z2352.CheckPrint = Children(i).Data
                                Case "TIMEPRINT" : z2352.TimePrint = Children(i).Data
                                Case "CHECKALLOCATION" : z2352.CheckAllocation = Children(i).Data
                                Case "TIMEUPDATE" : z2352.TimeUpdate = Children(i).Data
                                Case "SESITE" : z2352.seSite = Children(i).Data
                                Case "CDSITE" : z2352.cdSite = Children(i).Data
                                Case "INCHARGEQC" : z2352.InchargeQC = Children(i).Data
                                Case "PATHIMAGEQC" : z2352.PathImageQC = Children(i).Data
                                Case "REMARKQC" : z2352.RemarkQC = Children(i).Data
                                Case "DATE20QC" : z2352.Date20QC = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2352_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW AREA
    '=========================================================================================================================================================
    Public Sub K2352_MOVE(ByRef a2352 As T2352_AREA, ByRef b2352 As T2352_AREA)
        Try
            If trim$(a2352.MaterialInBoundNo) = "" Then b2352.MaterialInBoundNo = "" Else b2352.MaterialInBoundNo = a2352.MaterialInBoundNo
            If trim$(a2352.MaterialInBoundSeq) = "" Then b2352.MaterialInBoundSeq = "" Else b2352.MaterialInBoundSeq = a2352.MaterialInBoundSeq
            If trim$(a2352.MaterialInBoundSno) = "" Then b2352.MaterialInBoundSno = "" Else b2352.MaterialInBoundSno = a2352.MaterialInBoundSno
            If trim$(a2352.MaterialInBoundDseq) = "" Then b2352.MaterialInBoundDseq = "" Else b2352.MaterialInBoundDseq = a2352.MaterialInBoundDseq
            If trim$(a2352.PackInBound) = "" Then b2352.PackInBound = "" Else b2352.PackInBound = a2352.PackInBound
            If trim$(a2352.QtyInBound_Or) = "" Then b2352.QtyInBound_Or = "" Else b2352.QtyInBound_Or = a2352.QtyInBound_Or
            If trim$(a2352.QtyInboundPL) = "" Then b2352.QtyInboundPL = "" Else b2352.QtyInboundPL = a2352.QtyInboundPL
            If trim$(a2352.QtyInBound) = "" Then b2352.QtyInBound = "" Else b2352.QtyInBound = a2352.QtyInBound
            If trim$(a2352.QtyInBoundQC) = "" Then b2352.QtyInBoundQC = "" Else b2352.QtyInBoundQC = a2352.QtyInBoundQC
            If trim$(a2352.AmountInBoundEX) = "" Then b2352.AmountInBoundEX = "" Else b2352.AmountInBoundEX = a2352.AmountInBoundEX
            If trim$(a2352.AmountInBoundVND) = "" Then b2352.AmountInBoundVND = "" Else b2352.AmountInBoundVND = a2352.AmountInBoundVND
            If trim$(a2352.PackOutBound) = "" Then b2352.PackOutBound = "" Else b2352.PackOutBound = a2352.PackOutBound
            If trim$(a2352.QtyOutBound) = "" Then b2352.QtyOutBound = "" Else b2352.QtyOutBound = a2352.QtyOutBound
            If trim$(a2352.QtyConvert) = "" Then b2352.QtyConvert = "" Else b2352.QtyConvert = a2352.QtyConvert
            If trim$(a2352.seWareHouseGroup) = "" Then b2352.seWareHouseGroup = "" Else b2352.seWareHouseGroup = a2352.seWareHouseGroup
            If trim$(a2352.cdWareHouseGroup) = "" Then b2352.cdWareHouseGroup = "" Else b2352.cdWareHouseGroup = a2352.cdWareHouseGroup
            If trim$(a2352.seWareHousePosition) = "" Then b2352.seWareHousePosition = "" Else b2352.seWareHousePosition = a2352.seWareHousePosition
            If trim$(a2352.cdWareHousePosition) = "" Then b2352.cdWareHousePosition = "" Else b2352.cdWareHousePosition = a2352.cdWareHousePosition
            If trim$(a2352.seDefectMaterial) = "" Then b2352.seDefectMaterial = "" Else b2352.seDefectMaterial = a2352.seDefectMaterial
            If trim$(a2352.cdDefectMaterial) = "" Then b2352.cdDefectMaterial = "" Else b2352.cdDefectMaterial = a2352.cdDefectMaterial
            If trim$(a2352.SupplierName) = "" Then b2352.SupplierName = "" Else b2352.SupplierName = a2352.SupplierName
            If trim$(a2352.SOEName) = "" Then b2352.SOEName = "" Else b2352.SOEName = a2352.SOEName
            If trim$(a2352.TypeName0) = "" Then b2352.TypeName0 = "" Else b2352.TypeName0 = a2352.TypeName0
            If trim$(a2352.TypeName1) = "" Then b2352.TypeName1 = "" Else b2352.TypeName1 = a2352.TypeName1
            If trim$(a2352.TypeName2) = "" Then b2352.TypeName2 = "" Else b2352.TypeName2 = a2352.TypeName2
            If trim$(a2352.TypeName3) = "" Then b2352.TypeName3 = "" Else b2352.TypeName3 = a2352.TypeName3
            If trim$(a2352.TypeName4) = "" Then b2352.TypeName4 = "" Else b2352.TypeName4 = a2352.TypeName4
            If trim$(a2352.TypeName5) = "" Then b2352.TypeName5 = "" Else b2352.TypeName5 = a2352.TypeName5
            If trim$(a2352.SizeName) = "" Then b2352.SizeName = "" Else b2352.SizeName = a2352.SizeName
            If trim$(a2352.Grade) = "" Then b2352.Grade = "" Else b2352.Grade = a2352.Grade
            If trim$(a2352.Szno) = "" Then b2352.Szno = "" Else b2352.Szno = a2352.Szno
            If trim$(a2352.LotGrade) = "" Then b2352.LotGrade = "" Else b2352.LotGrade = a2352.LotGrade
            If trim$(a2352.Remark) = "" Then b2352.Remark = "" Else b2352.Remark = a2352.Remark
            If trim$(a2352.DateQC) = "" Then b2352.DateQC = "" Else b2352.DateQC = a2352.DateQC
            If trim$(a2352.DateInsert) = "" Then b2352.DateInsert = "" Else b2352.DateInsert = a2352.DateInsert
            If trim$(a2352.DateUpdate) = "" Then b2352.DateUpdate = "" Else b2352.DateUpdate = a2352.DateUpdate
            If trim$(a2352.InchargeInsert) = "" Then b2352.InchargeInsert = "" Else b2352.InchargeInsert = a2352.InchargeInsert
            If trim$(a2352.InchargeUpdate) = "" Then b2352.InchargeUpdate = "" Else b2352.InchargeUpdate = a2352.InchargeUpdate
            If trim$(a2352.JobCard) = "" Then b2352.JobCard = "" Else b2352.JobCard = a2352.JobCard
            If trim$(a2352.OrderNo) = "" Then b2352.OrderNo = "" Else b2352.OrderNo = a2352.OrderNo
            If trim$(a2352.OrderNoSeq) = "" Then b2352.OrderNoSeq = "" Else b2352.OrderNoSeq = a2352.OrderNoSeq
            If trim$(a2352.JobCardWorking) = "" Then b2352.JobCardWorking = "" Else b2352.JobCardWorking = a2352.JobCardWorking
            If trim$(a2352.JobCardWorkingSeq) = "" Then b2352.JobCardWorkingSeq = "" Else b2352.JobCardWorkingSeq = a2352.JobCardWorkingSeq
            If trim$(a2352.JobCardPSeq) = "" Then b2352.JobCardPSeq = "" Else b2352.JobCardPSeq = a2352.JobCardPSeq
            If trim$(a2352.JobCardType) = "" Then b2352.JobCardType = "" Else b2352.JobCardType = a2352.JobCardType
            If trim$(a2352.LotNo) = "" Then b2352.LotNo = "" Else b2352.LotNo = a2352.LotNo
            If trim$(a2352.LotNoSeq) = "" Then b2352.LotNoSeq = "" Else b2352.LotNoSeq = a2352.LotNoSeq
            If trim$(a2352.CheckComplete) = "" Then b2352.CheckComplete = "" Else b2352.CheckComplete = a2352.CheckComplete
            If trim$(a2352.CheckPrint) = "" Then b2352.CheckPrint = "" Else b2352.CheckPrint = a2352.CheckPrint
            If trim$(a2352.TimePrint) = "" Then b2352.TimePrint = "" Else b2352.TimePrint = a2352.TimePrint
            If trim$(a2352.CheckAllocation) = "" Then b2352.CheckAllocation = "" Else b2352.CheckAllocation = a2352.CheckAllocation
            If Trim$(a2352.TimeUpdate) = "" Then b2352.TimeUpdate = "" Else b2352.TimeUpdate = a2352.TimeUpdate
            If trim$(a2352.seSite) = "" Then b2352.seSite = "" Else b2352.seSite = a2352.seSite
            If trim$(a2352.cdSite) = "" Then b2352.cdSite = "" Else b2352.cdSite = a2352.cdSite
            If trim$(a2352.InchargeQC) = "" Then b2352.InchargeQC = "" Else b2352.InchargeQC = a2352.InchargeQC
            If trim$(a2352.PathImageQC) = "" Then b2352.PathImageQC = "" Else b2352.PathImageQC = a2352.PathImageQC
            If trim$(a2352.RemarkQC) = "" Then b2352.RemarkQC = "" Else b2352.RemarkQC = a2352.RemarkQC
            If trim$(a2352.Date20QC) = "" Then b2352.Date20QC = "" Else b2352.Date20QC = a2352.Date20QC
        Catch ex As Exception
            Call MsgBoxP("K2352_MOVE", vbCritical)
        End Try
    End Sub


End Module
