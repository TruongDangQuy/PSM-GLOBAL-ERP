'=========================================================================================================================================================
'   TABLE : (PFK2356)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K2356

    Structure T2356_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public DateOutBoundMaterial As String  '			char(8)		*
        Public SeqOutBoundMaterial As String  '			char(3)		*
        Public SnoOutBoundMaterial As Double  '			decimal		*
        Public CheckOutBoundMaterial As String  '			char(1)
        Public CheckInBoundMaterial As String  '			char(1)
        Public CustomerOutBoundMaterial As String  '			char(6)
        Public InchargeOutBoundMaterial As String  '			char(8)
        Public PackOutBound As Double  '			decimal
        Public QtyOutBound As Double  '			decimal
        Public PackProd As Double  '			decimal
        Public QtyProd As Double  '			decimal
        Public PriceOutBoundEX As Double  '			decimal
        Public PriceOutBoundVND As Double  '			decimal
        Public AmountOutBoundEX As Double  '			decimal
        Public AmountOutBoundVND As Double  '			decimal
        Public TimeMaterialOutBound As String  '			nvarchar(20)
        Public MaterialInBoundNo As String  '			char(9)
        Public MaterialInBoundSeq As String  '			char(3)
        Public MaterialInBoundSno As Double  '			decimal
        Public FactOrderNo As String  '			char(9)
        Public FactOrderSeq As Double  '			decimal
        Public JobCardWorking As String  '			char(10)
        Public JobCardWorkingSeq As String  '			char(3)
        Public JobCardType As String  '			char(1)
        Public CheckComplete As String  '			char(1)
        Public seSite As String  '			char(3)
        Public cdSite As String  '			char(3)
        Public seDepartment As String  '			char(3)
        Public cdDepartment As String  '			char(3)
        Public Remark As String  '			nvarchar(100)
        '=========================================================================================================================================================
    End Structure

    Public D2356 As T2356_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK2356(DATEOUTBOUNDMATERIAL As String, SEQOUTBOUNDMATERIAL As String, SNOOUTBOUNDMATERIAL As Double) As Boolean
        READ_PFK2356 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK2356 "
            SQL = SQL & " WHERE K2356_DateOutBoundMaterial		 = '" & DateOutBoundMaterial & "' "
            SQL = SQL & "   AND K2356_SeqOutBoundMaterial		 = '" & SeqOutBoundMaterial & "' "
            SQL = SQL & "   AND K2356_SnoOutBoundMaterial		 =  " & SnoOutBoundMaterial & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D2356_CLEAR() : GoTo SKIP_READ_PFK2356

            Call K2356_MOVE(rd)
            READ_PFK2356 = True

SKIP_READ_PFK2356:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK2356", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK2356(DATEOUTBOUNDMATERIAL As String, SEQOUTBOUNDMATERIAL As String, SNOOUTBOUNDMATERIAL As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK2356 "
            SQL = SQL & " WHERE K2356_DateOutBoundMaterial		 = '" & DateOutBoundMaterial & "' "
            SQL = SQL & "   AND K2356_SeqOutBoundMaterial		 = '" & SeqOutBoundMaterial & "' "
            SQL = SQL & "   AND K2356_SnoOutBoundMaterial		 =  " & SnoOutBoundMaterial & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK2356", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK2356(z2356 As T2356_AREA) As Boolean
        WRITE_PFK2356 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z2356)

            SQL = " INSERT INTO PFK2356 "
            SQL = SQL & " ( "
            SQL = SQL & " K2356_DateOutBoundMaterial,"
            SQL = SQL & " K2356_SeqOutBoundMaterial,"
            SQL = SQL & " K2356_SnoOutBoundMaterial,"
            SQL = SQL & " K2356_CheckOutBoundMaterial,"
            SQL = SQL & " K2356_CheckInBoundMaterial,"
            SQL = SQL & " K2356_CustomerOutBoundMaterial,"
            SQL = SQL & " K2356_InchargeOutBoundMaterial,"
            SQL = SQL & " K2356_PackOutBound,"
            SQL = SQL & " K2356_QtyOutBound,"
            SQL = SQL & " K2356_PackProd,"
            SQL = SQL & " K2356_QtyProd,"
            SQL = SQL & " K2356_PriceOutBoundEX,"
            SQL = SQL & " K2356_PriceOutBoundVND,"
            SQL = SQL & " K2356_AmountOutBoundEX,"
            SQL = SQL & " K2356_AmountOutBoundVND,"
            SQL = SQL & " K2356_TimeMaterialOutBound,"
            SQL = SQL & " K2356_MaterialInBoundNo,"
            SQL = SQL & " K2356_MaterialInBoundSeq,"
            SQL = SQL & " K2356_MaterialInBoundSno,"
            SQL = SQL & " K2356_FactOrderNo,"
            SQL = SQL & " K2356_FactOrderSeq,"
            SQL = SQL & " K2356_JobCardWorking,"
            SQL = SQL & " K2356_JobCardWorkingSeq,"
            SQL = SQL & " K2356_JobCardType,"
            SQL = SQL & " K2356_CheckComplete,"
            SQL = SQL & " K2356_seSite,"
            SQL = SQL & " K2356_cdSite,"
            SQL = SQL & " K2356_seDepartment,"
            SQL = SQL & " K2356_cdDepartment,"
            SQL = SQL & " K2356_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z2356.DateOutBoundMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2356.SeqOutBoundMaterial) & "', "
            SQL = SQL & "   " & FormatSQL(z2356.SnoOutBoundMaterial) & ", "
            SQL = SQL & "  N'" & FormatSQL(z2356.CheckOutBoundMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2356.CheckInBoundMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2356.CustomerOutBoundMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2356.InchargeOutBoundMaterial) & "', "
            SQL = SQL & "   " & FormatSQL(z2356.PackOutBound) & ", "
            SQL = SQL & "   " & FormatSQL(z2356.QtyOutBound) & ", "
            SQL = SQL & "   " & FormatSQL(z2356.PackProd) & ", "
            SQL = SQL & "   " & FormatSQL(z2356.QtyProd) & ", "
            SQL = SQL & "   " & FormatSQL(z2356.PriceOutBoundEX) & ", "
            SQL = SQL & "   " & FormatSQL(z2356.PriceOutBoundVND) & ", "
            SQL = SQL & "   " & FormatSQL(z2356.AmountOutBoundEX) & ", "
            SQL = SQL & "   " & FormatSQL(z2356.AmountOutBoundVND) & ", "
            SQL = SQL & "  N'" & FormatSQL(z2356.TimeMaterialOutBound) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2356.MaterialInBoundNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2356.MaterialInBoundSeq) & "', "
            SQL = SQL & "   " & FormatSQL(z2356.MaterialInBoundSno) & ", "
            SQL = SQL & "  N'" & FormatSQL(z2356.FactOrderNo) & "', "
            SQL = SQL & "   " & FormatSQL(z2356.FactOrderSeq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z2356.JobCardWorking) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2356.JobCardWorkingSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2356.JobCardType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2356.CheckComplete) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2356.seSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2356.cdSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2356.seDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2356.cdDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2356.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK2356 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK2356", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK2356(z2356 As T2356_AREA) As Boolean
        REWRITE_PFK2356 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z2356)

            SQL = " UPDATE PFK2356 SET "
            SQL = SQL & "    K2356_CheckOutBoundMaterial      = N'" & FormatSQL(z2356.CheckOutBoundMaterial) & "', "
            SQL = SQL & "    K2356_CheckInBoundMaterial      = N'" & FormatSQL(z2356.CheckInBoundMaterial) & "', "
            SQL = SQL & "    K2356_CustomerOutBoundMaterial      = N'" & FormatSQL(z2356.CustomerOutBoundMaterial) & "', "
            SQL = SQL & "    K2356_InchargeOutBoundMaterial      = N'" & FormatSQL(z2356.InchargeOutBoundMaterial) & "', "
            SQL = SQL & "    K2356_PackOutBound      =  " & FormatSQL(z2356.PackOutBound) & ", "
            SQL = SQL & "    K2356_QtyOutBound      =  " & FormatSQL(z2356.QtyOutBound) & ", "
            SQL = SQL & "    K2356_PackProd      =  " & FormatSQL(z2356.PackProd) & ", "
            SQL = SQL & "    K2356_QtyProd      =  " & FormatSQL(z2356.QtyProd) & ", "
            SQL = SQL & "    K2356_PriceOutBoundEX      =  " & FormatSQL(z2356.PriceOutBoundEX) & ", "
            SQL = SQL & "    K2356_PriceOutBoundVND      =  " & FormatSQL(z2356.PriceOutBoundVND) & ", "
            SQL = SQL & "    K2356_AmountOutBoundEX      =  " & FormatSQL(z2356.AmountOutBoundEX) & ", "
            SQL = SQL & "    K2356_AmountOutBoundVND      =  " & FormatSQL(z2356.AmountOutBoundVND) & ", "
            SQL = SQL & "    K2356_TimeMaterialOutBound      = N'" & FormatSQL(z2356.TimeMaterialOutBound) & "', "
            SQL = SQL & "    K2356_MaterialInBoundNo      = N'" & FormatSQL(z2356.MaterialInBoundNo) & "', "
            SQL = SQL & "    K2356_MaterialInBoundSeq      = N'" & FormatSQL(z2356.MaterialInBoundSeq) & "', "
            SQL = SQL & "    K2356_MaterialInBoundSno      =  " & FormatSQL(z2356.MaterialInBoundSno) & ", "
            SQL = SQL & "    K2356_FactOrderNo      = N'" & FormatSQL(z2356.FactOrderNo) & "', "
            SQL = SQL & "    K2356_FactOrderSeq      =  " & FormatSQL(z2356.FactOrderSeq) & ", "
            SQL = SQL & "    K2356_JobCardWorking      = N'" & FormatSQL(z2356.JobCardWorking) & "', "
            SQL = SQL & "    K2356_JobCardWorkingSeq      = N'" & FormatSQL(z2356.JobCardWorkingSeq) & "', "
            SQL = SQL & "    K2356_JobCardType      = N'" & FormatSQL(z2356.JobCardType) & "', "
            SQL = SQL & "    K2356_CheckComplete      = N'" & FormatSQL(z2356.CheckComplete) & "', "
            SQL = SQL & "    K2356_seSite      = N'" & FormatSQL(z2356.seSite) & "', "
            SQL = SQL & "    K2356_cdSite      = N'" & FormatSQL(z2356.cdSite) & "', "
            SQL = SQL & "    K2356_seDepartment      = N'" & FormatSQL(z2356.seDepartment) & "', "
            SQL = SQL & "    K2356_cdDepartment      = N'" & FormatSQL(z2356.cdDepartment) & "', "
            SQL = SQL & "    K2356_Remark      = N'" & FormatSQL(z2356.Remark) & "'  "
            SQL = SQL & " WHERE K2356_DateOutBoundMaterial		 = '" & z2356.DateOutBoundMaterial & "' "
            SQL = SQL & "   AND K2356_SeqOutBoundMaterial		 = '" & z2356.SeqOutBoundMaterial & "' "
            SQL = SQL & "   AND K2356_SnoOutBoundMaterial		 =  " & z2356.SnoOutBoundMaterial & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK2356 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK2356", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK2356(z2356 As T2356_AREA) As Boolean
        DELETE_PFK2356 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK2356 "
            SQL = SQL & " WHERE K2356_DateOutBoundMaterial		 = '" & z2356.DateOutBoundMaterial & "' "
            SQL = SQL & "   AND K2356_SeqOutBoundMaterial		 = '" & z2356.SeqOutBoundMaterial & "' "
            SQL = SQL & "   AND K2356_SnoOutBoundMaterial		 =  " & z2356.SnoOutBoundMaterial & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK2356 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK2356", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D2356_CLEAR()
        Try

            D2356.DateOutBoundMaterial = ""
            D2356.SeqOutBoundMaterial = ""
            D2356.SnoOutBoundMaterial = 0
            D2356.CheckOutBoundMaterial = ""
            D2356.CheckInBoundMaterial = ""
            D2356.CustomerOutBoundMaterial = ""
            D2356.InchargeOutBoundMaterial = ""
            D2356.PackOutBound = 0
            D2356.QtyOutBound = 0
            D2356.PackProd = 0
            D2356.QtyProd = 0
            D2356.PriceOutBoundEX = 0
            D2356.PriceOutBoundVND = 0
            D2356.AmountOutBoundEX = 0
            D2356.AmountOutBoundVND = 0
            D2356.TimeMaterialOutBound = ""
            D2356.MaterialInBoundNo = ""
            D2356.MaterialInBoundSeq = ""
            D2356.MaterialInBoundSno = 0
            D2356.FactOrderNo = ""
            D2356.FactOrderSeq = 0
            D2356.JobCardWorking = ""
            D2356.JobCardWorkingSeq = ""
            D2356.JobCardType = ""
            D2356.CheckComplete = ""
            D2356.seSite = ""
            D2356.cdSite = ""
            D2356.seDepartment = ""
            D2356.cdDepartment = ""
            D2356.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D2356_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x2356 As T2356_AREA)
        Try

            x2356.DateOutBoundMaterial = trim$(x2356.DateOutBoundMaterial)
            x2356.SeqOutBoundMaterial = trim$(x2356.SeqOutBoundMaterial)
            x2356.SnoOutBoundMaterial = trim$(x2356.SnoOutBoundMaterial)
            x2356.CheckOutBoundMaterial = trim$(x2356.CheckOutBoundMaterial)
            x2356.CheckInBoundMaterial = trim$(x2356.CheckInBoundMaterial)
            x2356.CustomerOutBoundMaterial = trim$(x2356.CustomerOutBoundMaterial)
            x2356.InchargeOutBoundMaterial = trim$(x2356.InchargeOutBoundMaterial)
            x2356.PackOutBound = trim$(x2356.PackOutBound)
            x2356.QtyOutBound = trim$(x2356.QtyOutBound)
            x2356.PackProd = trim$(x2356.PackProd)
            x2356.QtyProd = trim$(x2356.QtyProd)
            x2356.PriceOutBoundEX = trim$(x2356.PriceOutBoundEX)
            x2356.PriceOutBoundVND = trim$(x2356.PriceOutBoundVND)
            x2356.AmountOutBoundEX = trim$(x2356.AmountOutBoundEX)
            x2356.AmountOutBoundVND = trim$(x2356.AmountOutBoundVND)
            x2356.TimeMaterialOutBound = trim$(x2356.TimeMaterialOutBound)
            x2356.MaterialInBoundNo = trim$(x2356.MaterialInBoundNo)
            x2356.MaterialInBoundSeq = trim$(x2356.MaterialInBoundSeq)
            x2356.MaterialInBoundSno = trim$(x2356.MaterialInBoundSno)
            x2356.FactOrderNo = trim$(x2356.FactOrderNo)
            x2356.FactOrderSeq = trim$(x2356.FactOrderSeq)
            x2356.JobCardWorking = trim$(x2356.JobCardWorking)
            x2356.JobCardWorkingSeq = trim$(x2356.JobCardWorkingSeq)
            x2356.JobCardType = trim$(x2356.JobCardType)
            x2356.CheckComplete = trim$(x2356.CheckComplete)
            x2356.seSite = trim$(x2356.seSite)
            x2356.cdSite = trim$(x2356.cdSite)
            x2356.seDepartment = trim$(x2356.seDepartment)
            x2356.cdDepartment = trim$(x2356.cdDepartment)
            x2356.Remark = trim$(x2356.Remark)

            If trim$(x2356.DateOutBoundMaterial) = "" Then x2356.DateOutBoundMaterial = Space(1)
            If trim$(x2356.SeqOutBoundMaterial) = "" Then x2356.SeqOutBoundMaterial = Space(1)
            If trim$(x2356.SnoOutBoundMaterial) = "" Then x2356.SnoOutBoundMaterial = 0
            If trim$(x2356.CheckOutBoundMaterial) = "" Then x2356.CheckOutBoundMaterial = Space(1)
            If trim$(x2356.CheckInBoundMaterial) = "" Then x2356.CheckInBoundMaterial = Space(1)
            If trim$(x2356.CustomerOutBoundMaterial) = "" Then x2356.CustomerOutBoundMaterial = Space(1)
            If trim$(x2356.InchargeOutBoundMaterial) = "" Then x2356.InchargeOutBoundMaterial = Space(1)
            If trim$(x2356.PackOutBound) = "" Then x2356.PackOutBound = 0
            If trim$(x2356.QtyOutBound) = "" Then x2356.QtyOutBound = 0
            If trim$(x2356.PackProd) = "" Then x2356.PackProd = 0
            If trim$(x2356.QtyProd) = "" Then x2356.QtyProd = 0
            If trim$(x2356.PriceOutBoundEX) = "" Then x2356.PriceOutBoundEX = 0
            If trim$(x2356.PriceOutBoundVND) = "" Then x2356.PriceOutBoundVND = 0
            If trim$(x2356.AmountOutBoundEX) = "" Then x2356.AmountOutBoundEX = 0
            If trim$(x2356.AmountOutBoundVND) = "" Then x2356.AmountOutBoundVND = 0
            If trim$(x2356.TimeMaterialOutBound) = "" Then x2356.TimeMaterialOutBound = Space(1)
            If trim$(x2356.MaterialInBoundNo) = "" Then x2356.MaterialInBoundNo = Space(1)
            If trim$(x2356.MaterialInBoundSeq) = "" Then x2356.MaterialInBoundSeq = Space(1)
            If trim$(x2356.MaterialInBoundSno) = "" Then x2356.MaterialInBoundSno = 0
            If trim$(x2356.FactOrderNo) = "" Then x2356.FactOrderNo = Space(1)
            If trim$(x2356.FactOrderSeq) = "" Then x2356.FactOrderSeq = 0
            If trim$(x2356.JobCardWorking) = "" Then x2356.JobCardWorking = Space(1)
            If trim$(x2356.JobCardWorkingSeq) = "" Then x2356.JobCardWorkingSeq = Space(1)
            If trim$(x2356.JobCardType) = "" Then x2356.JobCardType = Space(1)
            If trim$(x2356.CheckComplete) = "" Then x2356.CheckComplete = Space(1)
            If trim$(x2356.seSite) = "" Then x2356.seSite = Space(1)
            If trim$(x2356.cdSite) = "" Then x2356.cdSite = Space(1)
            If trim$(x2356.seDepartment) = "" Then x2356.seDepartment = Space(1)
            If trim$(x2356.cdDepartment) = "" Then x2356.cdDepartment = Space(1)
            If trim$(x2356.Remark) = "" Then x2356.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K2356_MOVE(rs2356 As SqlClient.SqlDataReader)
        Try

            Call D2356_CLEAR()

            If IsdbNull(rs2356!K2356_DateOutBoundMaterial) = False Then D2356.DateOutBoundMaterial = Trim$(rs2356!K2356_DateOutBoundMaterial)
            If IsdbNull(rs2356!K2356_SeqOutBoundMaterial) = False Then D2356.SeqOutBoundMaterial = Trim$(rs2356!K2356_SeqOutBoundMaterial)
            If IsdbNull(rs2356!K2356_SnoOutBoundMaterial) = False Then D2356.SnoOutBoundMaterial = Trim$(rs2356!K2356_SnoOutBoundMaterial)
            If IsdbNull(rs2356!K2356_CheckOutBoundMaterial) = False Then D2356.CheckOutBoundMaterial = Trim$(rs2356!K2356_CheckOutBoundMaterial)
            If IsdbNull(rs2356!K2356_CheckInBoundMaterial) = False Then D2356.CheckInBoundMaterial = Trim$(rs2356!K2356_CheckInBoundMaterial)
            If IsdbNull(rs2356!K2356_CustomerOutBoundMaterial) = False Then D2356.CustomerOutBoundMaterial = Trim$(rs2356!K2356_CustomerOutBoundMaterial)
            If IsdbNull(rs2356!K2356_InchargeOutBoundMaterial) = False Then D2356.InchargeOutBoundMaterial = Trim$(rs2356!K2356_InchargeOutBoundMaterial)
            If IsdbNull(rs2356!K2356_PackOutBound) = False Then D2356.PackOutBound = Trim$(rs2356!K2356_PackOutBound)
            If IsdbNull(rs2356!K2356_QtyOutBound) = False Then D2356.QtyOutBound = Trim$(rs2356!K2356_QtyOutBound)
            If IsdbNull(rs2356!K2356_PackProd) = False Then D2356.PackProd = Trim$(rs2356!K2356_PackProd)
            If IsdbNull(rs2356!K2356_QtyProd) = False Then D2356.QtyProd = Trim$(rs2356!K2356_QtyProd)
            If IsdbNull(rs2356!K2356_PriceOutBoundEX) = False Then D2356.PriceOutBoundEX = Trim$(rs2356!K2356_PriceOutBoundEX)
            If IsdbNull(rs2356!K2356_PriceOutBoundVND) = False Then D2356.PriceOutBoundVND = Trim$(rs2356!K2356_PriceOutBoundVND)
            If IsdbNull(rs2356!K2356_AmountOutBoundEX) = False Then D2356.AmountOutBoundEX = Trim$(rs2356!K2356_AmountOutBoundEX)
            If IsdbNull(rs2356!K2356_AmountOutBoundVND) = False Then D2356.AmountOutBoundVND = Trim$(rs2356!K2356_AmountOutBoundVND)
            If IsdbNull(rs2356!K2356_TimeMaterialOutBound) = False Then D2356.TimeMaterialOutBound = Trim$(rs2356!K2356_TimeMaterialOutBound)
            If IsdbNull(rs2356!K2356_MaterialInBoundNo) = False Then D2356.MaterialInBoundNo = Trim$(rs2356!K2356_MaterialInBoundNo)
            If IsdbNull(rs2356!K2356_MaterialInBoundSeq) = False Then D2356.MaterialInBoundSeq = Trim$(rs2356!K2356_MaterialInBoundSeq)
            If IsdbNull(rs2356!K2356_MaterialInBoundSno) = False Then D2356.MaterialInBoundSno = Trim$(rs2356!K2356_MaterialInBoundSno)
            If IsdbNull(rs2356!K2356_FactOrderNo) = False Then D2356.FactOrderNo = Trim$(rs2356!K2356_FactOrderNo)
            If IsdbNull(rs2356!K2356_FactOrderSeq) = False Then D2356.FactOrderSeq = Trim$(rs2356!K2356_FactOrderSeq)
            If IsdbNull(rs2356!K2356_JobCardWorking) = False Then D2356.JobCardWorking = Trim$(rs2356!K2356_JobCardWorking)
            If IsdbNull(rs2356!K2356_JobCardWorkingSeq) = False Then D2356.JobCardWorkingSeq = Trim$(rs2356!K2356_JobCardWorkingSeq)
            If IsdbNull(rs2356!K2356_JobCardType) = False Then D2356.JobCardType = Trim$(rs2356!K2356_JobCardType)
            If IsdbNull(rs2356!K2356_CheckComplete) = False Then D2356.CheckComplete = Trim$(rs2356!K2356_CheckComplete)
            If IsdbNull(rs2356!K2356_seSite) = False Then D2356.seSite = Trim$(rs2356!K2356_seSite)
            If IsdbNull(rs2356!K2356_cdSite) = False Then D2356.cdSite = Trim$(rs2356!K2356_cdSite)
            If IsdbNull(rs2356!K2356_seDepartment) = False Then D2356.seDepartment = Trim$(rs2356!K2356_seDepartment)
            If IsdbNull(rs2356!K2356_cdDepartment) = False Then D2356.cdDepartment = Trim$(rs2356!K2356_cdDepartment)
            If IsdbNull(rs2356!K2356_Remark) = False Then D2356.Remark = Trim$(rs2356!K2356_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K2356_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K2356_MOVE(rs2356 As DataRow)
        Try

            Call D2356_CLEAR()

            If IsdbNull(rs2356!K2356_DateOutBoundMaterial) = False Then D2356.DateOutBoundMaterial = Trim$(rs2356!K2356_DateOutBoundMaterial)
            If IsdbNull(rs2356!K2356_SeqOutBoundMaterial) = False Then D2356.SeqOutBoundMaterial = Trim$(rs2356!K2356_SeqOutBoundMaterial)
            If IsdbNull(rs2356!K2356_SnoOutBoundMaterial) = False Then D2356.SnoOutBoundMaterial = Trim$(rs2356!K2356_SnoOutBoundMaterial)
            If IsdbNull(rs2356!K2356_CheckOutBoundMaterial) = False Then D2356.CheckOutBoundMaterial = Trim$(rs2356!K2356_CheckOutBoundMaterial)
            If IsdbNull(rs2356!K2356_CheckInBoundMaterial) = False Then D2356.CheckInBoundMaterial = Trim$(rs2356!K2356_CheckInBoundMaterial)
            If IsdbNull(rs2356!K2356_CustomerOutBoundMaterial) = False Then D2356.CustomerOutBoundMaterial = Trim$(rs2356!K2356_CustomerOutBoundMaterial)
            If IsdbNull(rs2356!K2356_InchargeOutBoundMaterial) = False Then D2356.InchargeOutBoundMaterial = Trim$(rs2356!K2356_InchargeOutBoundMaterial)
            If IsdbNull(rs2356!K2356_PackOutBound) = False Then D2356.PackOutBound = Trim$(rs2356!K2356_PackOutBound)
            If IsdbNull(rs2356!K2356_QtyOutBound) = False Then D2356.QtyOutBound = Trim$(rs2356!K2356_QtyOutBound)
            If IsdbNull(rs2356!K2356_PackProd) = False Then D2356.PackProd = Trim$(rs2356!K2356_PackProd)
            If IsdbNull(rs2356!K2356_QtyProd) = False Then D2356.QtyProd = Trim$(rs2356!K2356_QtyProd)
            If IsdbNull(rs2356!K2356_PriceOutBoundEX) = False Then D2356.PriceOutBoundEX = Trim$(rs2356!K2356_PriceOutBoundEX)
            If IsdbNull(rs2356!K2356_PriceOutBoundVND) = False Then D2356.PriceOutBoundVND = Trim$(rs2356!K2356_PriceOutBoundVND)
            If IsdbNull(rs2356!K2356_AmountOutBoundEX) = False Then D2356.AmountOutBoundEX = Trim$(rs2356!K2356_AmountOutBoundEX)
            If IsdbNull(rs2356!K2356_AmountOutBoundVND) = False Then D2356.AmountOutBoundVND = Trim$(rs2356!K2356_AmountOutBoundVND)
            If IsdbNull(rs2356!K2356_TimeMaterialOutBound) = False Then D2356.TimeMaterialOutBound = Trim$(rs2356!K2356_TimeMaterialOutBound)
            If IsdbNull(rs2356!K2356_MaterialInBoundNo) = False Then D2356.MaterialInBoundNo = Trim$(rs2356!K2356_MaterialInBoundNo)
            If IsdbNull(rs2356!K2356_MaterialInBoundSeq) = False Then D2356.MaterialInBoundSeq = Trim$(rs2356!K2356_MaterialInBoundSeq)
            If IsdbNull(rs2356!K2356_MaterialInBoundSno) = False Then D2356.MaterialInBoundSno = Trim$(rs2356!K2356_MaterialInBoundSno)
            If IsdbNull(rs2356!K2356_FactOrderNo) = False Then D2356.FactOrderNo = Trim$(rs2356!K2356_FactOrderNo)
            If IsdbNull(rs2356!K2356_FactOrderSeq) = False Then D2356.FactOrderSeq = Trim$(rs2356!K2356_FactOrderSeq)
            If IsdbNull(rs2356!K2356_JobCardWorking) = False Then D2356.JobCardWorking = Trim$(rs2356!K2356_JobCardWorking)
            If IsdbNull(rs2356!K2356_JobCardWorkingSeq) = False Then D2356.JobCardWorkingSeq = Trim$(rs2356!K2356_JobCardWorkingSeq)
            If IsdbNull(rs2356!K2356_JobCardType) = False Then D2356.JobCardType = Trim$(rs2356!K2356_JobCardType)
            If IsdbNull(rs2356!K2356_CheckComplete) = False Then D2356.CheckComplete = Trim$(rs2356!K2356_CheckComplete)
            If IsdbNull(rs2356!K2356_seSite) = False Then D2356.seSite = Trim$(rs2356!K2356_seSite)
            If IsdbNull(rs2356!K2356_cdSite) = False Then D2356.cdSite = Trim$(rs2356!K2356_cdSite)
            If IsdbNull(rs2356!K2356_seDepartment) = False Then D2356.seDepartment = Trim$(rs2356!K2356_seDepartment)
            If IsdbNull(rs2356!K2356_cdDepartment) = False Then D2356.cdDepartment = Trim$(rs2356!K2356_cdDepartment)
            If IsdbNull(rs2356!K2356_Remark) = False Then D2356.Remark = Trim$(rs2356!K2356_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K2356_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K2356_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z2356 As T2356_AREA, DATEOUTBOUNDMATERIAL As String, SEQOUTBOUNDMATERIAL As String, SNOOUTBOUNDMATERIAL As Double) As Boolean

        K2356_MOVE = False

        Try
            If READ_PFK2356(DATEOUTBOUNDMATERIAL, SEQOUTBOUNDMATERIAL, SNOOUTBOUNDMATERIAL) = True Then
                z2356 = D2356
                K2356_MOVE = True
            Else
                z2356 = Nothing
            End If

            If getColumIndex(spr, "DateOutBoundMaterial") > -1 Then z2356.DateOutBoundMaterial = getDataM(spr, getColumIndex(spr, "DateOutBoundMaterial"), xRow)
            If getColumIndex(spr, "SeqOutBoundMaterial") > -1 Then z2356.SeqOutBoundMaterial = getDataM(spr, getColumIndex(spr, "SeqOutBoundMaterial"), xRow)
            If getColumIndex(spr, "SnoOutBoundMaterial") > -1 Then z2356.SnoOutBoundMaterial = getDataM(spr, getColumIndex(spr, "SnoOutBoundMaterial"), xRow)
            If getColumIndex(spr, "CheckOutBoundMaterial") > -1 Then z2356.CheckOutBoundMaterial = getDataM(spr, getColumIndex(spr, "CheckOutBoundMaterial"), xRow)
            If getColumIndex(spr, "CheckInBoundMaterial") > -1 Then z2356.CheckInBoundMaterial = getDataM(spr, getColumIndex(spr, "CheckInBoundMaterial"), xRow)
            If getColumIndex(spr, "CustomerOutBoundMaterial") > -1 Then z2356.CustomerOutBoundMaterial = getDataM(spr, getColumIndex(spr, "CustomerOutBoundMaterial"), xRow)
            If getColumIndex(spr, "InchargeOutBoundMaterial") > -1 Then z2356.InchargeOutBoundMaterial = getDataM(spr, getColumIndex(spr, "InchargeOutBoundMaterial"), xRow)
            If getColumIndex(spr, "PackOutBound") > -1 Then z2356.PackOutBound = getDataM(spr, getColumIndex(spr, "PackOutBound"), xRow)
            If getColumIndex(spr, "QtyOutBound") > -1 Then z2356.QtyOutBound = getDataM(spr, getColumIndex(spr, "QtyOutBound"), xRow)
            If getColumIndex(spr, "PackProd") > -1 Then z2356.PackProd = getDataM(spr, getColumIndex(spr, "PackProd"), xRow)
            If getColumIndex(spr, "QtyProd") > -1 Then z2356.QtyProd = getDataM(spr, getColumIndex(spr, "QtyProd"), xRow)
            If getColumIndex(spr, "PriceOutBoundEX") > -1 Then z2356.PriceOutBoundEX = getDataM(spr, getColumIndex(spr, "PriceOutBoundEX"), xRow)
            If getColumIndex(spr, "PriceOutBoundVND") > -1 Then z2356.PriceOutBoundVND = getDataM(spr, getColumIndex(spr, "PriceOutBoundVND"), xRow)
            If getColumIndex(spr, "AmountOutBoundEX") > -1 Then z2356.AmountOutBoundEX = getDataM(spr, getColumIndex(spr, "AmountOutBoundEX"), xRow)
            If getColumIndex(spr, "AmountOutBoundVND") > -1 Then z2356.AmountOutBoundVND = getDataM(spr, getColumIndex(spr, "AmountOutBoundVND"), xRow)
            If getColumIndex(spr, "TimeMaterialOutBound") > -1 Then z2356.TimeMaterialOutBound = getDataM(spr, getColumIndex(spr, "TimeMaterialOutBound"), xRow)
            If getColumIndex(spr, "MaterialInBoundNo") > -1 Then z2356.MaterialInBoundNo = getDataM(spr, getColumIndex(spr, "MaterialInBoundNo"), xRow)
            If getColumIndex(spr, "MaterialInBoundSeq") > -1 Then z2356.MaterialInBoundSeq = getDataM(spr, getColumIndex(spr, "MaterialInBoundSeq"), xRow)
            If getColumIndex(spr, "MaterialInBoundSno") > -1 Then z2356.MaterialInBoundSno = getDataM(spr, getColumIndex(spr, "MaterialInBoundSno"), xRow)
            If getColumIndex(spr, "FactOrderNo") > -1 Then z2356.FactOrderNo = getDataM(spr, getColumIndex(spr, "FactOrderNo"), xRow)
            If getColumIndex(spr, "FactOrderSeq") > -1 Then z2356.FactOrderSeq = getDataM(spr, getColumIndex(spr, "FactOrderSeq"), xRow)
            If getColumIndex(spr, "JobCardWorking") > -1 Then z2356.JobCardWorking = getDataM(spr, getColumIndex(spr, "JobCardWorking"), xRow)
            If getColumIndex(spr, "JobCardWorkingSeq") > -1 Then z2356.JobCardWorkingSeq = getDataM(spr, getColumIndex(spr, "JobCardWorkingSeq"), xRow)
            If getColumIndex(spr, "JobCardType") > -1 Then z2356.JobCardType = getDataM(spr, getColumIndex(spr, "JobCardType"), xRow)
            If getColumIndex(spr, "CheckComplete") > -1 Then z2356.CheckComplete = getDataM(spr, getColumIndex(spr, "CheckComplete"), xRow)
            If getColumIndex(spr, "seSite") > -1 Then z2356.seSite = getDataM(spr, getColumIndex(spr, "seSite"), xRow)
            If getColumIndex(spr, "cdSite") > -1 Then z2356.cdSite = getDataM(spr, getColumIndex(spr, "cdSite"), xRow)
            If getColumIndex(spr, "seDepartment") > -1 Then z2356.seDepartment = getDataM(spr, getColumIndex(spr, "seDepartment"), xRow)
            If getColumIndex(spr, "cdDepartment") > -1 Then z2356.cdDepartment = getDataM(spr, getColumIndex(spr, "cdDepartment"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z2356.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2356_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K2356_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z2356 As T2356_AREA, CheckClear As Boolean, DATEOUTBOUNDMATERIAL As String, SEQOUTBOUNDMATERIAL As String, SNOOUTBOUNDMATERIAL As Double) As Boolean

        K2356_MOVE = False

        Try
            If READ_PFK2356(DATEOUTBOUNDMATERIAL, SEQOUTBOUNDMATERIAL, SNOOUTBOUNDMATERIAL) = True Then
                z2356 = D2356
                K2356_MOVE = True
            Else
                If CheckClear = True Then z2356 = Nothing
            End If

            If getColumIndex(spr, "DateOutBoundMaterial") > -1 Then z2356.DateOutBoundMaterial = getDataM(spr, getColumIndex(spr, "DateOutBoundMaterial"), xRow)
            If getColumIndex(spr, "SeqOutBoundMaterial") > -1 Then z2356.SeqOutBoundMaterial = getDataM(spr, getColumIndex(spr, "SeqOutBoundMaterial"), xRow)
            If getColumIndex(spr, "SnoOutBoundMaterial") > -1 Then z2356.SnoOutBoundMaterial = getDataM(spr, getColumIndex(spr, "SnoOutBoundMaterial"), xRow)
            If getColumIndex(spr, "CheckOutBoundMaterial") > -1 Then z2356.CheckOutBoundMaterial = getDataM(spr, getColumIndex(spr, "CheckOutBoundMaterial"), xRow)
            If getColumIndex(spr, "CheckInBoundMaterial") > -1 Then z2356.CheckInBoundMaterial = getDataM(spr, getColumIndex(spr, "CheckInBoundMaterial"), xRow)
            If getColumIndex(spr, "CustomerOutBoundMaterial") > -1 Then z2356.CustomerOutBoundMaterial = getDataM(spr, getColumIndex(spr, "CustomerOutBoundMaterial"), xRow)
            If getColumIndex(spr, "InchargeOutBoundMaterial") > -1 Then z2356.InchargeOutBoundMaterial = getDataM(spr, getColumIndex(spr, "InchargeOutBoundMaterial"), xRow)
            If getColumIndex(spr, "PackOutBound") > -1 Then z2356.PackOutBound = getDataM(spr, getColumIndex(spr, "PackOutBound"), xRow)
            If getColumIndex(spr, "QtyOutBound") > -1 Then z2356.QtyOutBound = getDataM(spr, getColumIndex(spr, "QtyOutBound"), xRow)
            If getColumIndex(spr, "PackProd") > -1 Then z2356.PackProd = getDataM(spr, getColumIndex(spr, "PackProd"), xRow)
            If getColumIndex(spr, "QtyProd") > -1 Then z2356.QtyProd = getDataM(spr, getColumIndex(spr, "QtyProd"), xRow)
            If getColumIndex(spr, "PriceOutBoundEX") > -1 Then z2356.PriceOutBoundEX = getDataM(spr, getColumIndex(spr, "PriceOutBoundEX"), xRow)
            If getColumIndex(spr, "PriceOutBoundVND") > -1 Then z2356.PriceOutBoundVND = getDataM(spr, getColumIndex(spr, "PriceOutBoundVND"), xRow)
            If getColumIndex(spr, "AmountOutBoundEX") > -1 Then z2356.AmountOutBoundEX = getDataM(spr, getColumIndex(spr, "AmountOutBoundEX"), xRow)
            If getColumIndex(spr, "AmountOutBoundVND") > -1 Then z2356.AmountOutBoundVND = getDataM(spr, getColumIndex(spr, "AmountOutBoundVND"), xRow)
            If getColumIndex(spr, "TimeMaterialOutBound") > -1 Then z2356.TimeMaterialOutBound = getDataM(spr, getColumIndex(spr, "TimeMaterialOutBound"), xRow)
            If getColumIndex(spr, "MaterialInBoundNo") > -1 Then z2356.MaterialInBoundNo = getDataM(spr, getColumIndex(spr, "MaterialInBoundNo"), xRow)
            If getColumIndex(spr, "MaterialInBoundSeq") > -1 Then z2356.MaterialInBoundSeq = getDataM(spr, getColumIndex(spr, "MaterialInBoundSeq"), xRow)
            If getColumIndex(spr, "MaterialInBoundSno") > -1 Then z2356.MaterialInBoundSno = getDataM(spr, getColumIndex(spr, "MaterialInBoundSno"), xRow)
            If getColumIndex(spr, "FactOrderNo") > -1 Then z2356.FactOrderNo = getDataM(spr, getColumIndex(spr, "FactOrderNo"), xRow)
            If getColumIndex(spr, "FactOrderSeq") > -1 Then z2356.FactOrderSeq = getDataM(spr, getColumIndex(spr, "FactOrderSeq"), xRow)
            If getColumIndex(spr, "JobCardWorking") > -1 Then z2356.JobCardWorking = getDataM(spr, getColumIndex(spr, "JobCardWorking"), xRow)
            If getColumIndex(spr, "JobCardWorkingSeq") > -1 Then z2356.JobCardWorkingSeq = getDataM(spr, getColumIndex(spr, "JobCardWorkingSeq"), xRow)
            If getColumIndex(spr, "JobCardType") > -1 Then z2356.JobCardType = getDataM(spr, getColumIndex(spr, "JobCardType"), xRow)
            If getColumIndex(spr, "CheckComplete") > -1 Then z2356.CheckComplete = getDataM(spr, getColumIndex(spr, "CheckComplete"), xRow)
            If getColumIndex(spr, "seSite") > -1 Then z2356.seSite = getDataM(spr, getColumIndex(spr, "seSite"), xRow)
            If getColumIndex(spr, "cdSite") > -1 Then z2356.cdSite = getDataM(spr, getColumIndex(spr, "cdSite"), xRow)
            If getColumIndex(spr, "seDepartment") > -1 Then z2356.seDepartment = getDataM(spr, getColumIndex(spr, "seDepartment"), xRow)
            If getColumIndex(spr, "cdDepartment") > -1 Then z2356.cdDepartment = getDataM(spr, getColumIndex(spr, "cdDepartment"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z2356.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2356_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K2356_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z2356 As T2356_AREA, Job As String, DATEOUTBOUNDMATERIAL As String, SEQOUTBOUNDMATERIAL As String, SNOOUTBOUNDMATERIAL As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K2356_MOVE = False

        Try
            If READ_PFK2356(DATEOUTBOUNDMATERIAL, SEQOUTBOUNDMATERIAL, SNOOUTBOUNDMATERIAL) = True Then
                z2356 = D2356
                K2356_MOVE = True
            Else
                z2356 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2356")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "DATEOUTBOUNDMATERIAL" : z2356.DateOutBoundMaterial = Children(i).Code
                                Case "SEQOUTBOUNDMATERIAL" : z2356.SeqOutBoundMaterial = Children(i).Code
                                Case "SNOOUTBOUNDMATERIAL" : z2356.SnoOutBoundMaterial = Children(i).Code
                                Case "CHECKOUTBOUNDMATERIAL" : z2356.CheckOutBoundMaterial = Children(i).Code
                                Case "CHECKINBOUNDMATERIAL" : z2356.CheckInBoundMaterial = Children(i).Code
                                Case "CUSTOMEROUTBOUNDMATERIAL" : z2356.CustomerOutBoundMaterial = Children(i).Code
                                Case "INCHARGEOUTBOUNDMATERIAL" : z2356.InchargeOutBoundMaterial = Children(i).Code
                                Case "PACKOUTBOUND" : z2356.PackOutBound = Children(i).Code
                                Case "QTYOUTBOUND" : z2356.QtyOutBound = Children(i).Code
                                Case "PACKPROD" : z2356.PackProd = Children(i).Code
                                Case "QTYPROD" : z2356.QtyProd = Children(i).Code
                                Case "PRICEOUTBOUNDEX" : z2356.PriceOutBoundEX = Children(i).Code
                                Case "PRICEOUTBOUNDVND" : z2356.PriceOutBoundVND = Children(i).Code
                                Case "AMOUNTOUTBOUNDEX" : z2356.AmountOutBoundEX = Children(i).Code
                                Case "AMOUNTOUTBOUNDVND" : z2356.AmountOutBoundVND = Children(i).Code
                                Case "TIMEMATERIALOUTBOUND" : z2356.TimeMaterialOutBound = Children(i).Code
                                Case "MATERIALINBOUNDNO" : z2356.MaterialInBoundNo = Children(i).Code
                                Case "MATERIALINBOUNDSEQ" : z2356.MaterialInBoundSeq = Children(i).Code
                                Case "MATERIALINBOUNDSNO" : z2356.MaterialInBoundSno = Children(i).Code
                                Case "FACTORDERNO" : z2356.FactOrderNo = Children(i).Code
                                Case "FACTORDERSEQ" : z2356.FactOrderSeq = Children(i).Code
                                Case "JOBCARDWORKING" : z2356.JobCardWorking = Children(i).Code
                                Case "JOBCARDWORKINGSEQ" : z2356.JobCardWorkingSeq = Children(i).Code
                                Case "JOBCARDTYPE" : z2356.JobCardType = Children(i).Code
                                Case "CHECKCOMPLETE" : z2356.CheckComplete = Children(i).Code
                                Case "SESITE" : z2356.seSite = Children(i).Code
                                Case "CDSITE" : z2356.cdSite = Children(i).Code
                                Case "SEDEPARTMENT" : z2356.seDepartment = Children(i).Code
                                Case "CDDEPARTMENT" : z2356.cdDepartment = Children(i).Code
                                Case "REMARK" : z2356.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "DATEOUTBOUNDMATERIAL" : z2356.DateOutBoundMaterial = Children(i).Data
                                Case "SEQOUTBOUNDMATERIAL" : z2356.SeqOutBoundMaterial = Children(i).Data
                                Case "SNOOUTBOUNDMATERIAL" : z2356.SnoOutBoundMaterial = Children(i).Data
                                Case "CHECKOUTBOUNDMATERIAL" : z2356.CheckOutBoundMaterial = Children(i).Data
                                Case "CHECKINBOUNDMATERIAL" : z2356.CheckInBoundMaterial = Children(i).Data
                                Case "CUSTOMEROUTBOUNDMATERIAL" : z2356.CustomerOutBoundMaterial = Children(i).Data
                                Case "INCHARGEOUTBOUNDMATERIAL" : z2356.InchargeOutBoundMaterial = Children(i).Data
                                Case "PACKOUTBOUND" : z2356.PackOutBound = Children(i).Data
                                Case "QTYOUTBOUND" : z2356.QtyOutBound = Children(i).Data
                                Case "PACKPROD" : z2356.PackProd = Children(i).Data
                                Case "QTYPROD" : z2356.QtyProd = Children(i).Data
                                Case "PRICEOUTBOUNDEX" : z2356.PriceOutBoundEX = Children(i).Data
                                Case "PRICEOUTBOUNDVND" : z2356.PriceOutBoundVND = Children(i).Data
                                Case "AMOUNTOUTBOUNDEX" : z2356.AmountOutBoundEX = Children(i).Data
                                Case "AMOUNTOUTBOUNDVND" : z2356.AmountOutBoundVND = Children(i).Data
                                Case "TIMEMATERIALOUTBOUND" : z2356.TimeMaterialOutBound = Children(i).Data
                                Case "MATERIALINBOUNDNO" : z2356.MaterialInBoundNo = Children(i).Data
                                Case "MATERIALINBOUNDSEQ" : z2356.MaterialInBoundSeq = Children(i).Data
                                Case "MATERIALINBOUNDSNO" : z2356.MaterialInBoundSno = Children(i).Data
                                Case "FACTORDERNO" : z2356.FactOrderNo = Children(i).Data
                                Case "FACTORDERSEQ" : z2356.FactOrderSeq = Children(i).Data
                                Case "JOBCARDWORKING" : z2356.JobCardWorking = Children(i).Data
                                Case "JOBCARDWORKINGSEQ" : z2356.JobCardWorkingSeq = Children(i).Data
                                Case "JOBCARDTYPE" : z2356.JobCardType = Children(i).Data
                                Case "CHECKCOMPLETE" : z2356.CheckComplete = Children(i).Data
                                Case "SESITE" : z2356.seSite = Children(i).Data
                                Case "CDSITE" : z2356.cdSite = Children(i).Data
                                Case "SEDEPARTMENT" : z2356.seDepartment = Children(i).Data
                                Case "CDDEPARTMENT" : z2356.cdDepartment = Children(i).Data
                                Case "REMARK" : z2356.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2356_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K2356_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z2356 As T2356_AREA, Job As String, CheckClear As Boolean, DATEOUTBOUNDMATERIAL As String, SEQOUTBOUNDMATERIAL As String, SNOOUTBOUNDMATERIAL As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K2356_MOVE = False

        Try
            If READ_PFK2356(DATEOUTBOUNDMATERIAL, SEQOUTBOUNDMATERIAL, SNOOUTBOUNDMATERIAL) = True Then
                z2356 = D2356
                K2356_MOVE = True
            Else
                If CheckClear = True Then z2356 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2356")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "DATEOUTBOUNDMATERIAL" : z2356.DateOutBoundMaterial = Children(i).Code
                                Case "SEQOUTBOUNDMATERIAL" : z2356.SeqOutBoundMaterial = Children(i).Code
                                Case "SNOOUTBOUNDMATERIAL" : z2356.SnoOutBoundMaterial = Children(i).Code
                                Case "CHECKOUTBOUNDMATERIAL" : z2356.CheckOutBoundMaterial = Children(i).Code
                                Case "CHECKINBOUNDMATERIAL" : z2356.CheckInBoundMaterial = Children(i).Code
                                Case "CUSTOMEROUTBOUNDMATERIAL" : z2356.CustomerOutBoundMaterial = Children(i).Code
                                Case "INCHARGEOUTBOUNDMATERIAL" : z2356.InchargeOutBoundMaterial = Children(i).Code
                                Case "PACKOUTBOUND" : z2356.PackOutBound = Children(i).Code
                                Case "QTYOUTBOUND" : z2356.QtyOutBound = Children(i).Code
                                Case "PACKPROD" : z2356.PackProd = Children(i).Code
                                Case "QTYPROD" : z2356.QtyProd = Children(i).Code
                                Case "PRICEOUTBOUNDEX" : z2356.PriceOutBoundEX = Children(i).Code
                                Case "PRICEOUTBOUNDVND" : z2356.PriceOutBoundVND = Children(i).Code
                                Case "AMOUNTOUTBOUNDEX" : z2356.AmountOutBoundEX = Children(i).Code
                                Case "AMOUNTOUTBOUNDVND" : z2356.AmountOutBoundVND = Children(i).Code
                                Case "TIMEMATERIALOUTBOUND" : z2356.TimeMaterialOutBound = Children(i).Code
                                Case "MATERIALINBOUNDNO" : z2356.MaterialInBoundNo = Children(i).Code
                                Case "MATERIALINBOUNDSEQ" : z2356.MaterialInBoundSeq = Children(i).Code
                                Case "MATERIALINBOUNDSNO" : z2356.MaterialInBoundSno = Children(i).Code
                                Case "FACTORDERNO" : z2356.FactOrderNo = Children(i).Code
                                Case "FACTORDERSEQ" : z2356.FactOrderSeq = Children(i).Code
                                Case "JOBCARDWORKING" : z2356.JobCardWorking = Children(i).Code
                                Case "JOBCARDWORKINGSEQ" : z2356.JobCardWorkingSeq = Children(i).Code
                                Case "JOBCARDTYPE" : z2356.JobCardType = Children(i).Code
                                Case "CHECKCOMPLETE" : z2356.CheckComplete = Children(i).Code
                                Case "SESITE" : z2356.seSite = Children(i).Code
                                Case "CDSITE" : z2356.cdSite = Children(i).Code
                                Case "SEDEPARTMENT" : z2356.seDepartment = Children(i).Code
                                Case "CDDEPARTMENT" : z2356.cdDepartment = Children(i).Code
                                Case "REMARK" : z2356.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "DATEOUTBOUNDMATERIAL" : z2356.DateOutBoundMaterial = Children(i).Data
                                Case "SEQOUTBOUNDMATERIAL" : z2356.SeqOutBoundMaterial = Children(i).Data
                                Case "SNOOUTBOUNDMATERIAL" : z2356.SnoOutBoundMaterial = Children(i).Data
                                Case "CHECKOUTBOUNDMATERIAL" : z2356.CheckOutBoundMaterial = Children(i).Data
                                Case "CHECKINBOUNDMATERIAL" : z2356.CheckInBoundMaterial = Children(i).Data
                                Case "CUSTOMEROUTBOUNDMATERIAL" : z2356.CustomerOutBoundMaterial = Children(i).Data
                                Case "INCHARGEOUTBOUNDMATERIAL" : z2356.InchargeOutBoundMaterial = Children(i).Data
                                Case "PACKOUTBOUND" : z2356.PackOutBound = Children(i).Data
                                Case "QTYOUTBOUND" : z2356.QtyOutBound = Children(i).Data
                                Case "PACKPROD" : z2356.PackProd = Children(i).Data
                                Case "QTYPROD" : z2356.QtyProd = Children(i).Data
                                Case "PRICEOUTBOUNDEX" : z2356.PriceOutBoundEX = Children(i).Data
                                Case "PRICEOUTBOUNDVND" : z2356.PriceOutBoundVND = Children(i).Data
                                Case "AMOUNTOUTBOUNDEX" : z2356.AmountOutBoundEX = Children(i).Data
                                Case "AMOUNTOUTBOUNDVND" : z2356.AmountOutBoundVND = Children(i).Data
                                Case "TIMEMATERIALOUTBOUND" : z2356.TimeMaterialOutBound = Children(i).Data
                                Case "MATERIALINBOUNDNO" : z2356.MaterialInBoundNo = Children(i).Data
                                Case "MATERIALINBOUNDSEQ" : z2356.MaterialInBoundSeq = Children(i).Data
                                Case "MATERIALINBOUNDSNO" : z2356.MaterialInBoundSno = Children(i).Data
                                Case "FACTORDERNO" : z2356.FactOrderNo = Children(i).Data
                                Case "FACTORDERSEQ" : z2356.FactOrderSeq = Children(i).Data
                                Case "JOBCARDWORKING" : z2356.JobCardWorking = Children(i).Data
                                Case "JOBCARDWORKINGSEQ" : z2356.JobCardWorkingSeq = Children(i).Data
                                Case "JOBCARDTYPE" : z2356.JobCardType = Children(i).Data
                                Case "CHECKCOMPLETE" : z2356.CheckComplete = Children(i).Data
                                Case "SESITE" : z2356.seSite = Children(i).Data
                                Case "CDSITE" : z2356.cdSite = Children(i).Data
                                Case "SEDEPARTMENT" : z2356.seDepartment = Children(i).Data
                                Case "CDDEPARTMENT" : z2356.cdDepartment = Children(i).Data
                                Case "REMARK" : z2356.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2356_MOVE", vbCritical)
        End Try
    End Function

End Module
