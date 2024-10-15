'=========================================================================================================================================================
'   TABLE : (PFK4950)
'
'      WORKER : PSM GLOBAL ., LTD
'       WORK DATE : 2019 NEW
'       DEVELOPER    : MRNLV
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K4950

    Structure T4950_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public LoadingCode As String  '			char(6)		*
        Public LoadingNo As String  '			nvarchar(20)
        Public CheckLoading As String  '			char(1)
        Public CheckTransType As String  '			char(1)
        Public DateShipping As String  '			char(8)
        Public DateLoading As String  '			char(8)
        Public DateDelivery As String  '			char(8)
        Public FromLoading As String  '			nvarchar(50)
        Public ToLoading As String  '			nvarchar(50)
        Public ContainerNo As String  '			nvarchar(50)
        Public CustomerCode As String  '			char(6)
        Public LoadingCMB As Double  '			decimal
        Public LoadingNW As Double  '			decimal
        Public LoadingGW As Double  '			decimal
        Public QtyCarton As Double  '			decimal
        Public QtyLoading As Double  '			decimal
        Public TimeInsert As String  '			char(14)
        Public TimeUpdate As String  '			char(14)
        Public DateInsert As String  '			char(8)
        Public DateUpdate As String  '			char(8)
        Public InchargeInsert As String  '			char(8)
        Public InchargeUpdate As String  '			char(8)
        Public CheckUse As String  '			char(1)
        Public CheckComplete As String  '			char(1)
        Public VesselName As String  '			nvarchar(200)
        Public VesselNo As String  '			nvarchar(200)
        Public Remark As String  '			nvarchar(50)
        Public seSite As String  '			char(3)
        Public cdSite As String  '			char(3)
        '=========================================================================================================================================================
    End Structure

    Public D4950 As T4950_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK4950(LOADINGCODE As String) As Boolean
        READ_PFK4950 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4950 "
            SQL = SQL & " WHERE K4950_LoadingCode		 = '" & LoadingCode & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4950_CLEAR() : GoTo SKIP_READ_PFK4950

            Call K4950_MOVE(rd)
            READ_PFK4950 = True

SKIP_READ_PFK4950:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4950", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK4950(LOADINGCODE As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4950 "
            SQL = SQL & " WHERE K4950_LoadingCode		 = '" & LoadingCode & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK4950", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK4950(z4950 As T4950_AREA) As Boolean
        WRITE_PFK4950 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z4950)

            SQL = " INSERT INTO PFK4950 "
            SQL = SQL & " ( "
            SQL = SQL & " K4950_LoadingCode,"
            SQL = SQL & " K4950_LoadingNo,"
            SQL = SQL & " K4950_CheckLoading,"
            SQL = SQL & " K4950_CheckTransType,"
            SQL = SQL & " K4950_DateShipping,"
            SQL = SQL & " K4950_DateLoading,"
            SQL = SQL & " K4950_DateDelivery,"
            SQL = SQL & " K4950_FromLoading,"
            SQL = SQL & " K4950_ToLoading,"
            SQL = SQL & " K4950_ContainerNo,"
            SQL = SQL & " K4950_CustomerCode,"
            SQL = SQL & " K4950_LoadingCMB,"
            SQL = SQL & " K4950_LoadingNW,"
            SQL = SQL & " K4950_LoadingGW,"
            SQL = SQL & " K4950_QtyCarton,"
            SQL = SQL & " K4950_QtyLoading,"
            SQL = SQL & " K4950_TimeInsert,"
            SQL = SQL & " K4950_TimeUpdate,"
            SQL = SQL & " K4950_DateInsert,"
            SQL = SQL & " K4950_DateUpdate,"
            SQL = SQL & " K4950_InchargeInsert,"
            SQL = SQL & " K4950_InchargeUpdate,"
            SQL = SQL & " K4950_CheckUse,"
            SQL = SQL & " K4950_CheckComplete,"
            SQL = SQL & " K4950_VesselName,"
            SQL = SQL & " K4950_VesselNo,"
            SQL = SQL & " K4950_Remark,"
            SQL = SQL & " K4950_seSite,"
            SQL = SQL & " K4950_cdSite "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z4950.LoadingCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4950.LoadingNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4950.CheckLoading) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4950.CheckTransType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4950.DateShipping) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4950.DateLoading) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4950.DateDelivery) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4950.FromLoading) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4950.ToLoading) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4950.ContainerNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4950.CustomerCode) & "', "
            SQL = SQL & "   " & FormatSQL(z4950.LoadingCMB) & ", "
            SQL = SQL & "   " & FormatSQL(z4950.LoadingNW) & ", "
            SQL = SQL & "   " & FormatSQL(z4950.LoadingGW) & ", "
            SQL = SQL & "   " & FormatSQL(z4950.QtyCarton) & ", "
            SQL = SQL & "   " & FormatSQL(z4950.QtyLoading) & ", "
            SQL = SQL & "  N'" & FormatSQL(PUB.TIME) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4950.TimeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(PUB.DAT) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4950.DateUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(PUB.SAW) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4950.InchargeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4950.CheckUse) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4950.CheckComplete) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4950.VesselName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4950.VesselNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4950.Remark) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4950.seSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4950.cdSite) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK4950 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK4950", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK4950(z4950 As T4950_AREA) As Boolean
        REWRITE_PFK4950 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z4950)

            SQL = " UPDATE PFK4950 SET "
            SQL = SQL & "    K4950_LoadingNo      = N'" & FormatSQL(z4950.LoadingNo) & "', "
            SQL = SQL & "    K4950_CheckLoading      = N'" & FormatSQL(z4950.CheckLoading) & "', "
            SQL = SQL & "    K4950_CheckTransType      = N'" & FormatSQL(z4950.CheckTransType) & "', "
            SQL = SQL & "    K4950_DateShipping      = N'" & FormatSQL(z4950.DateShipping) & "', "
            SQL = SQL & "    K4950_DateLoading      = N'" & FormatSQL(z4950.DateLoading) & "', "
            SQL = SQL & "    K4950_DateDelivery      = N'" & FormatSQL(z4950.DateDelivery) & "', "
            SQL = SQL & "    K4950_FromLoading      = N'" & FormatSQL(z4950.FromLoading) & "', "
            SQL = SQL & "    K4950_ToLoading      = N'" & FormatSQL(z4950.ToLoading) & "', "
            SQL = SQL & "    K4950_ContainerNo      = N'" & FormatSQL(z4950.ContainerNo) & "', "
            SQL = SQL & "    K4950_CustomerCode      = N'" & FormatSQL(z4950.CustomerCode) & "', "
            SQL = SQL & "    K4950_LoadingCMB      =  " & FormatSQL(z4950.LoadingCMB) & ", "
            SQL = SQL & "    K4950_LoadingNW      =  " & FormatSQL(z4950.LoadingNW) & ", "
            SQL = SQL & "    K4950_LoadingGW      =  " & FormatSQL(z4950.LoadingGW) & ", "
            SQL = SQL & "    K4950_QtyCarton      =  " & FormatSQL(z4950.QtyCarton) & ", "
            SQL = SQL & "    K4950_QtyLoading      =  " & FormatSQL(z4950.QtyLoading) & ", "
            SQL = SQL & "    K4950_TimeInsert      = N'" & FormatSQL(z4950.TimeInsert) & "', "
            SQL = SQL & "    K4950_TimeUpdate      = N'" & FormatSQL(PUB.TIME) & "', "
            SQL = SQL & "    K4950_DateInsert      = N'" & FormatSQL(z4950.DateInsert) & "', "
            SQL = SQL & "    K4950_DateUpdate      = N'" & FormatSQL(PUB.DAT) & "', "
            SQL = SQL & "    K4950_InchargeInsert      = N'" & FormatSQL(z4950.InchargeInsert) & "', "
            SQL = SQL & "    K4950_InchargeUpdate      = N'" & FormatSQL(PUB.SAW) & "', "
            SQL = SQL & "    K4950_CheckUse      = N'" & FormatSQL(z4950.CheckUse) & "', "
            SQL = SQL & "    K4950_CheckComplete      = N'" & FormatSQL(z4950.CheckComplete) & "', "
            SQL = SQL & "    K4950_VesselName      = N'" & FormatSQL(z4950.VesselName) & "', "
            SQL = SQL & "    K4950_VesselNo      = N'" & FormatSQL(z4950.VesselNo) & "', "
            SQL = SQL & "    K4950_Remark      = N'" & FormatSQL(z4950.Remark) & "', "
            SQL = SQL & "    K4950_seSite      = N'" & FormatSQL(z4950.seSite) & "', "
            SQL = SQL & "    K4950_cdSite      = N'" & FormatSQL(z4950.cdSite) & "'  "
            SQL = SQL & " WHERE K4950_LoadingCode		 = '" & z4950.LoadingCode & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()


            REWRITE_PFK4950 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK4950", vbCritical)

        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK4950(z4950 As T4950_AREA) As Boolean
        DELETE_PFK4950 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z4950)

            SQL = " DELETE FROM PFK4950  "
            SQL = SQL & " WHERE K4950_LoadingCode		 = '" & z4950.LoadingCode & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK4950 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK4950", vbCritical)
        Finally
            Call GetFullInformation("PFK4950", "D", SQL)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D4950_CLEAR()
        Try

            D4950.LoadingCode = ""
            D4950.LoadingNo = ""
            D4950.CheckLoading = ""
            D4950.CheckTransType = ""
            D4950.DateShipping = ""
            D4950.DateLoading = ""
            D4950.DateDelivery = ""
            D4950.FromLoading = ""
            D4950.ToLoading = ""
            D4950.ContainerNo = ""
            D4950.CustomerCode = ""
            D4950.LoadingCMB = 0
            D4950.LoadingNW = 0
            D4950.LoadingGW = 0
            D4950.QtyCarton = 0
            D4950.QtyLoading = 0
            D4950.TimeInsert = ""
            D4950.TimeUpdate = ""
            D4950.DateInsert = ""
            D4950.DateUpdate = ""
            D4950.InchargeInsert = ""
            D4950.InchargeUpdate = ""
            D4950.CheckUse = ""
            D4950.CheckComplete = ""
            D4950.VesselName = ""
            D4950.VesselNo = ""
            D4950.Remark = ""
            D4950.seSite = ""
            D4950.cdSite = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D4950_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x4950 As T4950_AREA)
        Try

            x4950.LoadingCode = trim$(x4950.LoadingCode)
            x4950.LoadingNo = trim$(x4950.LoadingNo)
            x4950.CheckLoading = trim$(x4950.CheckLoading)
            x4950.CheckTransType = trim$(x4950.CheckTransType)
            x4950.DateShipping = trim$(x4950.DateShipping)
            x4950.DateLoading = trim$(x4950.DateLoading)
            x4950.DateDelivery = trim$(x4950.DateDelivery)
            x4950.FromLoading = trim$(x4950.FromLoading)
            x4950.ToLoading = trim$(x4950.ToLoading)
            x4950.ContainerNo = trim$(x4950.ContainerNo)
            x4950.CustomerCode = trim$(x4950.CustomerCode)
            x4950.LoadingCMB = trim$(x4950.LoadingCMB)
            x4950.LoadingNW = trim$(x4950.LoadingNW)
            x4950.LoadingGW = trim$(x4950.LoadingGW)
            x4950.QtyCarton = trim$(x4950.QtyCarton)
            x4950.QtyLoading = trim$(x4950.QtyLoading)
            x4950.TimeInsert = trim$(x4950.TimeInsert)
            x4950.TimeUpdate = trim$(x4950.TimeUpdate)
            x4950.DateInsert = trim$(x4950.DateInsert)
            x4950.DateUpdate = trim$(x4950.DateUpdate)
            x4950.InchargeInsert = trim$(x4950.InchargeInsert)
            x4950.InchargeUpdate = trim$(x4950.InchargeUpdate)
            x4950.CheckUse = trim$(x4950.CheckUse)
            x4950.CheckComplete = trim$(x4950.CheckComplete)
            x4950.VesselName = trim$(x4950.VesselName)
            x4950.VesselNo = trim$(x4950.VesselNo)
            x4950.Remark = trim$(x4950.Remark)
            x4950.seSite = trim$(x4950.seSite)
            x4950.cdSite = trim$(x4950.cdSite)

            If trim$(x4950.LoadingCode) = "" Then x4950.LoadingCode = Space(1)
            If trim$(x4950.LoadingNo) = "" Then x4950.LoadingNo = Space(1)
            If trim$(x4950.CheckLoading) = "" Then x4950.CheckLoading = Space(1)
            If trim$(x4950.CheckTransType) = "" Then x4950.CheckTransType = Space(1)
            If trim$(x4950.DateShipping) = "" Then x4950.DateShipping = Space(1)
            If trim$(x4950.DateLoading) = "" Then x4950.DateLoading = Space(1)
            If trim$(x4950.DateDelivery) = "" Then x4950.DateDelivery = Space(1)
            If trim$(x4950.FromLoading) = "" Then x4950.FromLoading = Space(1)
            If trim$(x4950.ToLoading) = "" Then x4950.ToLoading = Space(1)
            If trim$(x4950.ContainerNo) = "" Then x4950.ContainerNo = Space(1)
            If trim$(x4950.CustomerCode) = "" Then x4950.CustomerCode = Space(1)
            If trim$(x4950.LoadingCMB) = "" Then x4950.LoadingCMB = 0
            If trim$(x4950.LoadingNW) = "" Then x4950.LoadingNW = 0
            If trim$(x4950.LoadingGW) = "" Then x4950.LoadingGW = 0
            If trim$(x4950.QtyCarton) = "" Then x4950.QtyCarton = 0
            If trim$(x4950.QtyLoading) = "" Then x4950.QtyLoading = 0
            If trim$(x4950.TimeInsert) = "" Then x4950.TimeInsert = Space(1)
            If trim$(x4950.TimeUpdate) = "" Then x4950.TimeUpdate = Space(1)
            If trim$(x4950.DateInsert) = "" Then x4950.DateInsert = Space(1)
            If trim$(x4950.DateUpdate) = "" Then x4950.DateUpdate = Space(1)
            If trim$(x4950.InchargeInsert) = "" Then x4950.InchargeInsert = Space(1)
            If trim$(x4950.InchargeUpdate) = "" Then x4950.InchargeUpdate = Space(1)
            If trim$(x4950.CheckUse) = "" Then x4950.CheckUse = Space(1)
            If trim$(x4950.CheckComplete) = "" Then x4950.CheckComplete = Space(1)
            If trim$(x4950.VesselName) = "" Then x4950.VesselName = Space(1)
            If trim$(x4950.VesselNo) = "" Then x4950.VesselNo = Space(1)
            If trim$(x4950.Remark) = "" Then x4950.Remark = Space(1)
            If trim$(x4950.seSite) = "" Then x4950.seSite = Space(1)
            If trim$(x4950.cdSite) = "" Then x4950.cdSite = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K4950_MOVE(rs4950 As SqlClient.SqlDataReader)
        Try

            Call D4950_CLEAR()

            If IsdbNull(rs4950!K4950_LoadingCode) = False Then D4950.LoadingCode = Trim$(rs4950!K4950_LoadingCode)
            If IsdbNull(rs4950!K4950_LoadingNo) = False Then D4950.LoadingNo = Trim$(rs4950!K4950_LoadingNo)
            If IsdbNull(rs4950!K4950_CheckLoading) = False Then D4950.CheckLoading = Trim$(rs4950!K4950_CheckLoading)
            If IsdbNull(rs4950!K4950_CheckTransType) = False Then D4950.CheckTransType = Trim$(rs4950!K4950_CheckTransType)
            If IsdbNull(rs4950!K4950_DateShipping) = False Then D4950.DateShipping = Trim$(rs4950!K4950_DateShipping)
            If IsdbNull(rs4950!K4950_DateLoading) = False Then D4950.DateLoading = Trim$(rs4950!K4950_DateLoading)
            If IsdbNull(rs4950!K4950_DateDelivery) = False Then D4950.DateDelivery = Trim$(rs4950!K4950_DateDelivery)
            If IsdbNull(rs4950!K4950_FromLoading) = False Then D4950.FromLoading = Trim$(rs4950!K4950_FromLoading)
            If IsdbNull(rs4950!K4950_ToLoading) = False Then D4950.ToLoading = Trim$(rs4950!K4950_ToLoading)
            If IsdbNull(rs4950!K4950_ContainerNo) = False Then D4950.ContainerNo = Trim$(rs4950!K4950_ContainerNo)
            If IsdbNull(rs4950!K4950_CustomerCode) = False Then D4950.CustomerCode = Trim$(rs4950!K4950_CustomerCode)
            If IsdbNull(rs4950!K4950_LoadingCMB) = False Then D4950.LoadingCMB = Trim$(rs4950!K4950_LoadingCMB)
            If IsdbNull(rs4950!K4950_LoadingNW) = False Then D4950.LoadingNW = Trim$(rs4950!K4950_LoadingNW)
            If IsdbNull(rs4950!K4950_LoadingGW) = False Then D4950.LoadingGW = Trim$(rs4950!K4950_LoadingGW)
            If IsdbNull(rs4950!K4950_QtyCarton) = False Then D4950.QtyCarton = Trim$(rs4950!K4950_QtyCarton)
            If IsdbNull(rs4950!K4950_QtyLoading) = False Then D4950.QtyLoading = Trim$(rs4950!K4950_QtyLoading)
            If IsdbNull(rs4950!K4950_TimeInsert) = False Then D4950.TimeInsert = Trim$(rs4950!K4950_TimeInsert)
            If IsdbNull(rs4950!K4950_TimeUpdate) = False Then D4950.TimeUpdate = Trim$(rs4950!K4950_TimeUpdate)
            If IsdbNull(rs4950!K4950_DateInsert) = False Then D4950.DateInsert = Trim$(rs4950!K4950_DateInsert)
            If IsdbNull(rs4950!K4950_DateUpdate) = False Then D4950.DateUpdate = Trim$(rs4950!K4950_DateUpdate)
            If IsdbNull(rs4950!K4950_InchargeInsert) = False Then D4950.InchargeInsert = Trim$(rs4950!K4950_InchargeInsert)
            If IsdbNull(rs4950!K4950_InchargeUpdate) = False Then D4950.InchargeUpdate = Trim$(rs4950!K4950_InchargeUpdate)
            If IsdbNull(rs4950!K4950_CheckUse) = False Then D4950.CheckUse = Trim$(rs4950!K4950_CheckUse)
            If IsdbNull(rs4950!K4950_CheckComplete) = False Then D4950.CheckComplete = Trim$(rs4950!K4950_CheckComplete)
            If IsdbNull(rs4950!K4950_VesselName) = False Then D4950.VesselName = Trim$(rs4950!K4950_VesselName)
            If IsdbNull(rs4950!K4950_VesselNo) = False Then D4950.VesselNo = Trim$(rs4950!K4950_VesselNo)
            If IsdbNull(rs4950!K4950_Remark) = False Then D4950.Remark = Trim$(rs4950!K4950_Remark)
            If IsdbNull(rs4950!K4950_seSite) = False Then D4950.seSite = Trim$(rs4950!K4950_seSite)
            If IsdbNull(rs4950!K4950_cdSite) = False Then D4950.cdSite = Trim$(rs4950!K4950_cdSite)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K4950_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K4950_MOVE(rs4950 As DataRow)
        Try

            Call D4950_CLEAR()

            If IsdbNull(rs4950!K4950_LoadingCode) = False Then D4950.LoadingCode = Trim$(rs4950!K4950_LoadingCode)
            If IsdbNull(rs4950!K4950_LoadingNo) = False Then D4950.LoadingNo = Trim$(rs4950!K4950_LoadingNo)
            If IsdbNull(rs4950!K4950_CheckLoading) = False Then D4950.CheckLoading = Trim$(rs4950!K4950_CheckLoading)
            If IsdbNull(rs4950!K4950_CheckTransType) = False Then D4950.CheckTransType = Trim$(rs4950!K4950_CheckTransType)
            If IsdbNull(rs4950!K4950_DateShipping) = False Then D4950.DateShipping = Trim$(rs4950!K4950_DateShipping)
            If IsdbNull(rs4950!K4950_DateLoading) = False Then D4950.DateLoading = Trim$(rs4950!K4950_DateLoading)
            If IsdbNull(rs4950!K4950_DateDelivery) = False Then D4950.DateDelivery = Trim$(rs4950!K4950_DateDelivery)
            If IsdbNull(rs4950!K4950_FromLoading) = False Then D4950.FromLoading = Trim$(rs4950!K4950_FromLoading)
            If IsdbNull(rs4950!K4950_ToLoading) = False Then D4950.ToLoading = Trim$(rs4950!K4950_ToLoading)
            If IsdbNull(rs4950!K4950_ContainerNo) = False Then D4950.ContainerNo = Trim$(rs4950!K4950_ContainerNo)
            If IsdbNull(rs4950!K4950_CustomerCode) = False Then D4950.CustomerCode = Trim$(rs4950!K4950_CustomerCode)
            If IsdbNull(rs4950!K4950_LoadingCMB) = False Then D4950.LoadingCMB = Trim$(rs4950!K4950_LoadingCMB)
            If IsdbNull(rs4950!K4950_LoadingNW) = False Then D4950.LoadingNW = Trim$(rs4950!K4950_LoadingNW)
            If IsdbNull(rs4950!K4950_LoadingGW) = False Then D4950.LoadingGW = Trim$(rs4950!K4950_LoadingGW)
            If IsdbNull(rs4950!K4950_QtyCarton) = False Then D4950.QtyCarton = Trim$(rs4950!K4950_QtyCarton)
            If IsdbNull(rs4950!K4950_QtyLoading) = False Then D4950.QtyLoading = Trim$(rs4950!K4950_QtyLoading)
            If IsdbNull(rs4950!K4950_TimeInsert) = False Then D4950.TimeInsert = Trim$(rs4950!K4950_TimeInsert)
            If IsdbNull(rs4950!K4950_TimeUpdate) = False Then D4950.TimeUpdate = Trim$(rs4950!K4950_TimeUpdate)
            If IsdbNull(rs4950!K4950_DateInsert) = False Then D4950.DateInsert = Trim$(rs4950!K4950_DateInsert)
            If IsdbNull(rs4950!K4950_DateUpdate) = False Then D4950.DateUpdate = Trim$(rs4950!K4950_DateUpdate)
            If IsdbNull(rs4950!K4950_InchargeInsert) = False Then D4950.InchargeInsert = Trim$(rs4950!K4950_InchargeInsert)
            If IsdbNull(rs4950!K4950_InchargeUpdate) = False Then D4950.InchargeUpdate = Trim$(rs4950!K4950_InchargeUpdate)
            If IsdbNull(rs4950!K4950_CheckUse) = False Then D4950.CheckUse = Trim$(rs4950!K4950_CheckUse)
            If IsdbNull(rs4950!K4950_CheckComplete) = False Then D4950.CheckComplete = Trim$(rs4950!K4950_CheckComplete)
            If IsdbNull(rs4950!K4950_VesselName) = False Then D4950.VesselName = Trim$(rs4950!K4950_VesselName)
            If IsdbNull(rs4950!K4950_VesselNo) = False Then D4950.VesselNo = Trim$(rs4950!K4950_VesselNo)
            If IsdbNull(rs4950!K4950_Remark) = False Then D4950.Remark = Trim$(rs4950!K4950_Remark)
            If IsdbNull(rs4950!K4950_seSite) = False Then D4950.seSite = Trim$(rs4950!K4950_seSite)
            If IsdbNull(rs4950!K4950_cdSite) = False Then D4950.cdSite = Trim$(rs4950!K4950_cdSite)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K4950_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K4950_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z4950 As T4950_AREA, LOADINGCODE As String) As Boolean

        K4950_MOVE = False

        Try
            If READ_PFK4950(LOADINGCODE) = True Then
                z4950 = D4950
                K4950_MOVE = True
            Else
                z4950 = Nothing
            End If

            If getColumnIndex(spr, "LoadingCode") > -1 Then z4950.LoadingCode = getDataM(spr, getColumnIndex(spr, "LoadingCode"), xRow)
            If getColumnIndex(spr, "LoadingNo") > -1 Then z4950.LoadingNo = getDataM(spr, getColumnIndex(spr, "LoadingNo"), xRow)
            If getColumnIndex(spr, "CheckLoading") > -1 Then z4950.CheckLoading = getDataM(spr, getColumnIndex(spr, "CheckLoading"), xRow)
            If getColumnIndex(spr, "CheckTransType") > -1 Then z4950.CheckTransType = getDataM(spr, getColumnIndex(spr, "CheckTransType"), xRow)
            If getColumnIndex(spr, "DateShipping") > -1 Then z4950.DateShipping = getDataM(spr, getColumnIndex(spr, "DateShipping"), xRow)
            If getColumnIndex(spr, "DateLoading") > -1 Then z4950.DateLoading = getDataM(spr, getColumnIndex(spr, "DateLoading"), xRow)
            If getColumnIndex(spr, "DateDelivery") > -1 Then z4950.DateDelivery = getDataM(spr, getColumnIndex(spr, "DateDelivery"), xRow)
            If getColumnIndex(spr, "FromLoading") > -1 Then z4950.FromLoading = getDataM(spr, getColumnIndex(spr, "FromLoading"), xRow)
            If getColumnIndex(spr, "ToLoading") > -1 Then z4950.ToLoading = getDataM(spr, getColumnIndex(spr, "ToLoading"), xRow)
            If getColumnIndex(spr, "ContainerNo") > -1 Then z4950.ContainerNo = getDataM(spr, getColumnIndex(spr, "ContainerNo"), xRow)
            If getColumnIndex(spr, "CustomerCode") > -1 Then z4950.CustomerCode = getDataM(spr, getColumnIndex(spr, "CustomerCode"), xRow)
            If getColumnIndex(spr, "LoadingCMB") > -1 Then z4950.LoadingCMB = Cdecp(getDataM(spr, getColumnIndex(spr, "LoadingCMB"), xRow))
            If getColumnIndex(spr, "LoadingNW") > -1 Then z4950.LoadingNW = Cdecp(getDataM(spr, getColumnIndex(spr, "LoadingNW"), xRow))
            If getColumnIndex(spr, "LoadingGW") > -1 Then z4950.LoadingGW = Cdecp(getDataM(spr, getColumnIndex(spr, "LoadingGW"), xRow))
            If getColumnIndex(spr, "QtyCarton") > -1 Then z4950.QtyCarton = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyCarton"), xRow))
            If getColumnIndex(spr, "QtyLoading") > -1 Then z4950.QtyLoading = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyLoading"), xRow))
            If getColumnIndex(spr, "TimeInsert") > -1 Then z4950.TimeInsert = getDataM(spr, getColumnIndex(spr, "TimeInsert"), xRow)
            If getColumnIndex(spr, "TimeUpdate") > -1 Then z4950.TimeUpdate = getDataM(spr, getColumnIndex(spr, "TimeUpdate"), xRow)
            If getColumnIndex(spr, "DateInsert") > -1 Then z4950.DateInsert = getDataM(spr, getColumnIndex(spr, "DateInsert"), xRow)
            If getColumnIndex(spr, "DateUpdate") > -1 Then z4950.DateUpdate = getDataM(spr, getColumnIndex(spr, "DateUpdate"), xRow)
            If getColumnIndex(spr, "InchargeInsert") > -1 Then z4950.InchargeInsert = getDataM(spr, getColumnIndex(spr, "InchargeInsert"), xRow)
            If getColumnIndex(spr, "InchargeUpdate") > -1 Then z4950.InchargeUpdate = getDataM(spr, getColumnIndex(spr, "InchargeUpdate"), xRow)
            If getColumnIndex(spr, "CheckUse") > -1 Then z4950.CheckUse = getDataM(spr, getColumnIndex(spr, "CheckUse"), xRow)
            If getColumnIndex(spr, "CheckComplete") > -1 Then z4950.CheckComplete = getDataM(spr, getColumnIndex(spr, "CheckComplete"), xRow)
            If getColumnIndex(spr, "VesselName") > -1 Then z4950.VesselName = getDataM(spr, getColumnIndex(spr, "VesselName"), xRow)
            If getColumnIndex(spr, "VesselNo") > -1 Then z4950.VesselNo = getDataM(spr, getColumnIndex(spr, "VesselNo"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z4950.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)
            If getColumnIndex(spr, "seSite") > -1 Then z4950.seSite = getDataM(spr, getColumnIndex(spr, "seSite"), xRow)
            If getColumnIndex(spr, "cdSite") > -1 Then z4950.cdSite = getDataM(spr, getColumnIndex(spr, "cdSite"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4950_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K4950_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z4950 As T4950_AREA, CheckClear As Boolean, LOADINGCODE As String) As Boolean

        K4950_MOVE = False

        Try
            If READ_PFK4950(LOADINGCODE) = True Then
                z4950 = D4950
                K4950_MOVE = True
            Else
                If CheckClear = True Then z4950 = Nothing
            End If

            If getColumnIndex(spr, "LoadingCode") > -1 Then z4950.LoadingCode = getDataM(spr, getColumnIndex(spr, "LoadingCode"), xRow)
            If getColumnIndex(spr, "LoadingNo") > -1 Then z4950.LoadingNo = getDataM(spr, getColumnIndex(spr, "LoadingNo"), xRow)
            If getColumnIndex(spr, "CheckLoading") > -1 Then z4950.CheckLoading = getDataM(spr, getColumnIndex(spr, "CheckLoading"), xRow)
            If getColumnIndex(spr, "CheckTransType") > -1 Then z4950.CheckTransType = getDataM(spr, getColumnIndex(spr, "CheckTransType"), xRow)
            If getColumnIndex(spr, "DateShipping") > -1 Then z4950.DateShipping = getDataM(spr, getColumnIndex(spr, "DateShipping"), xRow)
            If getColumnIndex(spr, "DateLoading") > -1 Then z4950.DateLoading = getDataM(spr, getColumnIndex(spr, "DateLoading"), xRow)
            If getColumnIndex(spr, "DateDelivery") > -1 Then z4950.DateDelivery = getDataM(spr, getColumnIndex(spr, "DateDelivery"), xRow)
            If getColumnIndex(spr, "FromLoading") > -1 Then z4950.FromLoading = getDataM(spr, getColumnIndex(spr, "FromLoading"), xRow)
            If getColumnIndex(spr, "ToLoading") > -1 Then z4950.ToLoading = getDataM(spr, getColumnIndex(spr, "ToLoading"), xRow)
            If getColumnIndex(spr, "ContainerNo") > -1 Then z4950.ContainerNo = getDataM(spr, getColumnIndex(spr, "ContainerNo"), xRow)
            If getColumnIndex(spr, "CustomerCode") > -1 Then z4950.CustomerCode = getDataM(spr, getColumnIndex(spr, "CustomerCode"), xRow)
            If getColumnIndex(spr, "LoadingCMB") > -1 Then z4950.LoadingCMB = Cdecp(getDataM(spr, getColumnIndex(spr, "LoadingCMB"), xRow))
            If getColumnIndex(spr, "LoadingNW") > -1 Then z4950.LoadingNW = Cdecp(getDataM(spr, getColumnIndex(spr, "LoadingNW"), xRow))
            If getColumnIndex(spr, "LoadingGW") > -1 Then z4950.LoadingGW = Cdecp(getDataM(spr, getColumnIndex(spr, "LoadingGW"), xRow))
            If getColumnIndex(spr, "QtyCarton") > -1 Then z4950.QtyCarton = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyCarton"), xRow))
            If getColumnIndex(spr, "QtyLoading") > -1 Then z4950.QtyLoading = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyLoading"), xRow))
            If getColumnIndex(spr, "TimeInsert") > -1 Then z4950.TimeInsert = getDataM(spr, getColumnIndex(spr, "TimeInsert"), xRow)
            If getColumnIndex(spr, "TimeUpdate") > -1 Then z4950.TimeUpdate = getDataM(spr, getColumnIndex(spr, "TimeUpdate"), xRow)
            If getColumnIndex(spr, "DateInsert") > -1 Then z4950.DateInsert = getDataM(spr, getColumnIndex(spr, "DateInsert"), xRow)
            If getColumnIndex(spr, "DateUpdate") > -1 Then z4950.DateUpdate = getDataM(spr, getColumnIndex(spr, "DateUpdate"), xRow)
            If getColumnIndex(spr, "InchargeInsert") > -1 Then z4950.InchargeInsert = getDataM(spr, getColumnIndex(spr, "InchargeInsert"), xRow)
            If getColumnIndex(spr, "InchargeUpdate") > -1 Then z4950.InchargeUpdate = getDataM(spr, getColumnIndex(spr, "InchargeUpdate"), xRow)
            If getColumnIndex(spr, "CheckUse") > -1 Then z4950.CheckUse = getDataM(spr, getColumnIndex(spr, "CheckUse"), xRow)
            If getColumnIndex(spr, "CheckComplete") > -1 Then z4950.CheckComplete = getDataM(spr, getColumnIndex(spr, "CheckComplete"), xRow)
            If getColumnIndex(spr, "VesselName") > -1 Then z4950.VesselName = getDataM(spr, getColumnIndex(spr, "VesselName"), xRow)
            If getColumnIndex(spr, "VesselNo") > -1 Then z4950.VesselNo = getDataM(spr, getColumnIndex(spr, "VesselNo"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z4950.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)
            If getColumnIndex(spr, "seSite") > -1 Then z4950.seSite = getDataM(spr, getColumnIndex(spr, "seSite"), xRow)
            If getColumnIndex(spr, "cdSite") > -1 Then z4950.cdSite = getDataM(spr, getColumnIndex(spr, "cdSite"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4950_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K4950_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z4950 As T4950_AREA, Job As String, LOADINGCODE As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K4950_MOVE = False

        Try
            If READ_PFK4950(LOADINGCODE) = True Then
                z4950 = D4950
                K4950_MOVE = True
            Else
                z4950 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4950")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "LOADINGCODE" : z4950.LoadingCode = Children(i).Code
                                Case "LOADINGNO" : z4950.LoadingNo = Children(i).Code
                                Case "CHECKLOADING" : z4950.CheckLoading = Children(i).Code
                                Case "CHECKTRANSTYPE" : z4950.CheckTransType = Children(i).Code
                                Case "DATESHIPPING" : z4950.DateShipping = Children(i).Code
                                Case "DATELOADING" : z4950.DateLoading = Children(i).Code
                                Case "DATEDELIVERY" : z4950.DateDelivery = Children(i).Code
                                Case "FROMLOADING" : z4950.FromLoading = Children(i).Code
                                Case "TOLOADING" : z4950.ToLoading = Children(i).Code
                                Case "CONTAINERNO" : z4950.ContainerNo = Children(i).Code
                                Case "CUSTOMERCODE" : z4950.CustomerCode = Children(i).Code
                                Case "LOADINGCMB" : z4950.LoadingCMB = Children(i).Code
                                Case "LOADINGNW" : z4950.LoadingNW = Children(i).Code
                                Case "LOADINGGW" : z4950.LoadingGW = Children(i).Code
                                Case "QTYCARTON" : z4950.QtyCarton = Children(i).Code
                                Case "QTYLOADING" : z4950.QtyLoading = Children(i).Code
                                Case "TIMEINSERT" : z4950.TimeInsert = Children(i).Code
                                Case "TIMEUPDATE" : z4950.TimeUpdate = Children(i).Code
                                Case "DATEINSERT" : z4950.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z4950.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z4950.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z4950.InchargeUpdate = Children(i).Code
                                Case "CHECKUSE" : z4950.CheckUse = Children(i).Code
                                Case "CHECKCOMPLETE" : z4950.CheckComplete = Children(i).Code
                                Case "VESSELNAME" : z4950.VesselName = Children(i).Code
                                Case "VESSELNO" : z4950.VesselNo = Children(i).Code
                                Case "REMARK" : z4950.Remark = Children(i).Code
                                Case "SESITE" : z4950.seSite = Children(i).Code
                                Case "CDSITE" : z4950.cdSite = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "LOADINGCODE" : z4950.LoadingCode = Children(i).Data
                                Case "LOADINGNO" : z4950.LoadingNo = Children(i).Data
                                Case "CHECKLOADING" : z4950.CheckLoading = Children(i).Data
                                Case "CHECKTRANSTYPE" : z4950.CheckTransType = Children(i).Data
                                Case "DATESHIPPING" : z4950.DateShipping = Children(i).Data
                                Case "DATELOADING" : z4950.DateLoading = Children(i).Data
                                Case "DATEDELIVERY" : z4950.DateDelivery = Children(i).Data
                                Case "FROMLOADING" : z4950.FromLoading = Children(i).Data
                                Case "TOLOADING" : z4950.ToLoading = Children(i).Data
                                Case "CONTAINERNO" : z4950.ContainerNo = Children(i).Data
                                Case "CUSTOMERCODE" : z4950.CustomerCode = Children(i).Data
                                Case "LOADINGCMB" : z4950.LoadingCMB = Cdecp(Children(i).Data)
                                Case "LOADINGNW" : z4950.LoadingNW = Cdecp(Children(i).Data)
                                Case "LOADINGGW" : z4950.LoadingGW = Cdecp(Children(i).Data)
                                Case "QTYCARTON" : z4950.QtyCarton = Cdecp(Children(i).Data)
                                Case "QTYLOADING" : z4950.QtyLoading = Cdecp(Children(i).Data)
                                Case "TIMEINSERT" : z4950.TimeInsert = Children(i).Data
                                Case "TIMEUPDATE" : z4950.TimeUpdate = Children(i).Data
                                Case "DATEINSERT" : z4950.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z4950.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z4950.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z4950.InchargeUpdate = Children(i).Data
                                Case "CHECKUSE" : z4950.CheckUse = Children(i).Data
                                Case "CHECKCOMPLETE" : z4950.CheckComplete = Children(i).Data
                                Case "VESSELNAME" : z4950.VesselName = Children(i).Data
                                Case "VESSELNO" : z4950.VesselNo = Children(i).Data
                                Case "REMARK" : z4950.Remark = Children(i).Data
                                Case "SESITE" : z4950.seSite = Children(i).Data
                                Case "CDSITE" : z4950.cdSite = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4950_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K4950_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z4950 As T4950_AREA, Job As String, CheckClear As Boolean, LOADINGCODE As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K4950_MOVE = False

        Try
            If READ_PFK4950(LOADINGCODE) = True Then
                z4950 = D4950
                K4950_MOVE = True
            Else
                If CheckClear = True Then z4950 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4950")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "LOADINGCODE" : z4950.LoadingCode = Children(i).Code
                                Case "LOADINGNO" : z4950.LoadingNo = Children(i).Code
                                Case "CHECKLOADING" : z4950.CheckLoading = Children(i).Code
                                Case "CHECKTRANSTYPE" : z4950.CheckTransType = Children(i).Code
                                Case "DATESHIPPING" : z4950.DateShipping = Children(i).Code
                                Case "DATELOADING" : z4950.DateLoading = Children(i).Code
                                Case "DATEDELIVERY" : z4950.DateDelivery = Children(i).Code
                                Case "FROMLOADING" : z4950.FromLoading = Children(i).Code
                                Case "TOLOADING" : z4950.ToLoading = Children(i).Code
                                Case "CONTAINERNO" : z4950.ContainerNo = Children(i).Code
                                Case "CUSTOMERCODE" : z4950.CustomerCode = Children(i).Code
                                Case "LOADINGCMB" : z4950.LoadingCMB = Children(i).Code
                                Case "LOADINGNW" : z4950.LoadingNW = Children(i).Code
                                Case "LOADINGGW" : z4950.LoadingGW = Children(i).Code
                                Case "QTYCARTON" : z4950.QtyCarton = Children(i).Code
                                Case "QTYLOADING" : z4950.QtyLoading = Children(i).Code
                                Case "TIMEINSERT" : z4950.TimeInsert = Children(i).Code
                                Case "TIMEUPDATE" : z4950.TimeUpdate = Children(i).Code
                                Case "DATEINSERT" : z4950.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z4950.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z4950.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z4950.InchargeUpdate = Children(i).Code
                                Case "CHECKUSE" : z4950.CheckUse = Children(i).Code
                                Case "CHECKCOMPLETE" : z4950.CheckComplete = Children(i).Code
                                Case "VESSELNAME" : z4950.VesselName = Children(i).Code
                                Case "VESSELNO" : z4950.VesselNo = Children(i).Code
                                Case "REMARK" : z4950.Remark = Children(i).Code
                                Case "SESITE" : z4950.seSite = Children(i).Code
                                Case "CDSITE" : z4950.cdSite = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "LOADINGCODE" : z4950.LoadingCode = Children(i).Data
                                Case "LOADINGNO" : z4950.LoadingNo = Children(i).Data
                                Case "CHECKLOADING" : z4950.CheckLoading = Children(i).Data
                                Case "CHECKTRANSTYPE" : z4950.CheckTransType = Children(i).Data
                                Case "DATESHIPPING" : z4950.DateShipping = Children(i).Data
                                Case "DATELOADING" : z4950.DateLoading = Children(i).Data
                                Case "DATEDELIVERY" : z4950.DateDelivery = Children(i).Data
                                Case "FROMLOADING" : z4950.FromLoading = Children(i).Data
                                Case "TOLOADING" : z4950.ToLoading = Children(i).Data
                                Case "CONTAINERNO" : z4950.ContainerNo = Children(i).Data
                                Case "CUSTOMERCODE" : z4950.CustomerCode = Children(i).Data
                                Case "LOADINGCMB" : z4950.LoadingCMB = Cdecp(Children(i).Data)
                                Case "LOADINGNW" : z4950.LoadingNW = Cdecp(Children(i).Data)
                                Case "LOADINGGW" : z4950.LoadingGW = Cdecp(Children(i).Data)
                                Case "QTYCARTON" : z4950.QtyCarton = Cdecp(Children(i).Data)
                                Case "QTYLOADING" : z4950.QtyLoading = Cdecp(Children(i).Data)
                                Case "TIMEINSERT" : z4950.TimeInsert = Children(i).Data
                                Case "TIMEUPDATE" : z4950.TimeUpdate = Children(i).Data
                                Case "DATEINSERT" : z4950.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z4950.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z4950.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z4950.InchargeUpdate = Children(i).Data
                                Case "CHECKUSE" : z4950.CheckUse = Children(i).Data
                                Case "CHECKCOMPLETE" : z4950.CheckComplete = Children(i).Data
                                Case "VESSELNAME" : z4950.VesselName = Children(i).Data
                                Case "VESSELNO" : z4950.VesselNo = Children(i).Data
                                Case "REMARK" : z4950.Remark = Children(i).Data
                                Case "SESITE" : z4950.seSite = Children(i).Data
                                Case "CDSITE" : z4950.cdSite = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4950_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW AREA
    '=========================================================================================================================================================
    Public Sub K4950_MOVE(ByRef a4950 As T4950_AREA, ByRef b4950 As T4950_AREA)
        Try
            If trim$(a4950.LoadingCode) = "" Then b4950.LoadingCode = "" Else b4950.LoadingCode = a4950.LoadingCode
            If trim$(a4950.LoadingNo) = "" Then b4950.LoadingNo = "" Else b4950.LoadingNo = a4950.LoadingNo
            If trim$(a4950.CheckLoading) = "" Then b4950.CheckLoading = "" Else b4950.CheckLoading = a4950.CheckLoading
            If trim$(a4950.CheckTransType) = "" Then b4950.CheckTransType = "" Else b4950.CheckTransType = a4950.CheckTransType
            If trim$(a4950.DateShipping) = "" Then b4950.DateShipping = "" Else b4950.DateShipping = a4950.DateShipping
            If trim$(a4950.DateLoading) = "" Then b4950.DateLoading = "" Else b4950.DateLoading = a4950.DateLoading
            If trim$(a4950.DateDelivery) = "" Then b4950.DateDelivery = "" Else b4950.DateDelivery = a4950.DateDelivery
            If trim$(a4950.FromLoading) = "" Then b4950.FromLoading = "" Else b4950.FromLoading = a4950.FromLoading
            If trim$(a4950.ToLoading) = "" Then b4950.ToLoading = "" Else b4950.ToLoading = a4950.ToLoading
            If trim$(a4950.ContainerNo) = "" Then b4950.ContainerNo = "" Else b4950.ContainerNo = a4950.ContainerNo
            If trim$(a4950.CustomerCode) = "" Then b4950.CustomerCode = "" Else b4950.CustomerCode = a4950.CustomerCode
            If trim$(a4950.LoadingCMB) = "" Then b4950.LoadingCMB = "" Else b4950.LoadingCMB = a4950.LoadingCMB
            If trim$(a4950.LoadingNW) = "" Then b4950.LoadingNW = "" Else b4950.LoadingNW = a4950.LoadingNW
            If trim$(a4950.LoadingGW) = "" Then b4950.LoadingGW = "" Else b4950.LoadingGW = a4950.LoadingGW
            If trim$(a4950.QtyCarton) = "" Then b4950.QtyCarton = "" Else b4950.QtyCarton = a4950.QtyCarton
            If trim$(a4950.QtyLoading) = "" Then b4950.QtyLoading = "" Else b4950.QtyLoading = a4950.QtyLoading
            If trim$(a4950.TimeInsert) = "" Then b4950.TimeInsert = "" Else b4950.TimeInsert = a4950.TimeInsert
            If trim$(a4950.TimeUpdate) = "" Then b4950.TimeUpdate = "" Else b4950.TimeUpdate = a4950.TimeUpdate
            If trim$(a4950.DateInsert) = "" Then b4950.DateInsert = "" Else b4950.DateInsert = a4950.DateInsert
            If trim$(a4950.DateUpdate) = "" Then b4950.DateUpdate = "" Else b4950.DateUpdate = a4950.DateUpdate
            If trim$(a4950.InchargeInsert) = "" Then b4950.InchargeInsert = "" Else b4950.InchargeInsert = a4950.InchargeInsert
            If trim$(a4950.InchargeUpdate) = "" Then b4950.InchargeUpdate = "" Else b4950.InchargeUpdate = a4950.InchargeUpdate
            If trim$(a4950.CheckUse) = "" Then b4950.CheckUse = "" Else b4950.CheckUse = a4950.CheckUse
            If trim$(a4950.CheckComplete) = "" Then b4950.CheckComplete = "" Else b4950.CheckComplete = a4950.CheckComplete
            If trim$(a4950.VesselName) = "" Then b4950.VesselName = "" Else b4950.VesselName = a4950.VesselName
            If trim$(a4950.VesselNo) = "" Then b4950.VesselNo = "" Else b4950.VesselNo = a4950.VesselNo
            If trim$(a4950.Remark) = "" Then b4950.Remark = "" Else b4950.Remark = a4950.Remark
            If trim$(a4950.seSite) = "" Then b4950.seSite = "" Else b4950.seSite = a4950.seSite
            If trim$(a4950.cdSite) = "" Then b4950.cdSite = "" Else b4950.cdSite = a4950.cdSite
        Catch ex As Exception
            Call MsgBoxP("K4950_MOVE", vbCritical)
        End Try
    End Sub


End Module
