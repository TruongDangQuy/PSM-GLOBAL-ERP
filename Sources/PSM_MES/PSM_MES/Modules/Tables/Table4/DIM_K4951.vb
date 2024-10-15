'=========================================================================================================================================================
'   TABLE : (PFK4951)
'
'      WORKER : PSM GLOBAL ., LTD
'       WORK DATE : 2019 NEW
'       DEVELOPER    : MRNLV
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K4951

    Structure T4951_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public AutoKey As Double  '			decimal		*
        Public LoadingCode As String  '			char(6)
        Public seSite As String  '			char(3)
        Public cdSite As String  '			char(3)
        Public Autokey_4958 As Double  '			decimal
        Public LoadingCMB As Double  '			decimal
        Public LoadingNW As Double  '			decimal
        Public LoadingGW As Double  '			decimal
        Public QtyCarton As Double  '			decimal
        Public QtyLoading As Double  '			decimal
        Public DateInsert As String  '			char(8)
        Public DateUpdate As String  '			char(8)
        Public TimeInsert As String  '			char(14)
        Public TimeUpdate As String  '			char(14)
        Public InchargeInsert As String  '			char(8)
        Public InchargeUpdate As String  '			char(8)
        Public CheckUse As String  '			char(1)
        Public CheckComplete As String  '			char(1)
        '=========================================================================================================================================================
    End Structure

    Public D4951 As T4951_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK4951(AUTOKEY As Double) As Boolean
        READ_PFK4951 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4951 "
            SQL = SQL & " WHERE K4951_AutoKey		 =  " & AutoKey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4951_CLEAR() : GoTo SKIP_READ_PFK4951

            Call K4951_MOVE(rd)
            READ_PFK4951 = True

SKIP_READ_PFK4951:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4951", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK4951(AUTOKEY As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4951 "
            SQL = SQL & " WHERE K4951_AutoKey		 =  " & AutoKey & "  "
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

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK4951(z4951 As T4951_AREA) As Boolean
        WRITE_PFK4951 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z4951)

            SQL = " INSERT INTO PFK4951 "
            SQL = SQL & " ( "

            SQL = SQL & " K4951_LoadingCode,"
            SQL = SQL & " K4951_seSite,"
            SQL = SQL & " K4951_cdSite,"
            SQL = SQL & " K4951_Autokey_4958,"
            SQL = SQL & " K4951_LoadingCMB,"
            SQL = SQL & " K4951_LoadingNW,"
            SQL = SQL & " K4951_LoadingGW,"
            SQL = SQL & " K4951_QtyCarton,"
            SQL = SQL & " K4951_QtyLoading,"
            SQL = SQL & " K4951_DateInsert,"
            SQL = SQL & " K4951_DateUpdate,"
            SQL = SQL & " K4951_TimeInsert,"
            SQL = SQL & " K4951_TimeUpdate,"
            SQL = SQL & " K4951_InchargeInsert,"
            SQL = SQL & " K4951_InchargeUpdate,"
            SQL = SQL & " K4951_CheckUse,"
            SQL = SQL & " K4951_CheckComplete "
            SQL = SQL & " ) VALUES ( "

            SQL = SQL & "  N'" & FormatSQL(z4951.LoadingCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4951.seSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4951.cdSite) & "', "
            SQL = SQL & "   " & FormatSQL(z4951.Autokey_4958) & ", "
            SQL = SQL & "   " & FormatSQL(z4951.LoadingCMB) & ", "
            SQL = SQL & "   " & FormatSQL(z4951.LoadingNW) & ", "
            SQL = SQL & "   " & FormatSQL(z4951.LoadingGW) & ", "
            SQL = SQL & "   " & FormatSQL(z4951.QtyCarton) & ", "
            SQL = SQL & "   " & FormatSQL(z4951.QtyLoading) & ", "
            SQL = SQL & "  N'" & FormatSQL(PUB.DAT) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4951.DateUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(PUB.TIME) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4951.TimeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(PUB.SAW) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4951.InchargeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4951.CheckUse) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4951.CheckComplete) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK4951 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK4951", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK4951(z4951 As T4951_AREA) As Boolean
        REWRITE_PFK4951 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z4951)

            SQL = " UPDATE PFK4951 SET "
            SQL = SQL & "    K4951_LoadingCode      =  N'" & FormatSQL(z4951.LoadingCode) & "', "
            SQL = SQL & "    K4951_seSite      = N'" & FormatSQL(z4951.seSite) & "', "
            SQL = SQL & "    K4951_cdSite      = N'" & FormatSQL(z4951.cdSite) & "', "
             SQL = SQL & "    K4951_Autokey_4958      =   " & FormatSQL(z4951.Autokey_4958) & ", "
            SQL = SQL & "    K4951_LoadingCMB      =  " & FormatSQL(z4951.LoadingCMB) & ", "
            SQL = SQL & "    K4951_LoadingNW      =  " & FormatSQL(z4951.LoadingNW) & ", "
            SQL = SQL & "    K4951_LoadingGW      =  " & FormatSQL(z4951.LoadingGW) & ", "
            SQL = SQL & "    K4951_QtyCarton      =  " & FormatSQL(z4951.QtyCarton) & ", "
            SQL = SQL & "    K4951_QtyLoading      =  " & FormatSQL(z4951.QtyLoading) & ", "
            SQL = SQL & "    K4951_DateInsert      = N'" & FormatSQL(z4951.DateInsert) & "', "
            SQL = SQL & "    K4951_DateUpdate      = N'" & FormatSQL(PUB.DAT) & "', "
            SQL = SQL & "    K4951_TimeInsert      = N'" & FormatSQL(z4951.TimeInsert) & "', "
            SQL = SQL & "    K4951_TimeUpdate      = N'" & FormatSQL(PUB.TIME) & "', "
            SQL = SQL & "    K4951_InchargeInsert      = N'" & FormatSQL(z4951.InchargeInsert) & "', "
            SQL = SQL & "    K4951_InchargeUpdate      = N'" & FormatSQL(PUB.SAW) & "', "
            SQL = SQL & "    K4951_CheckUse      = N'" & FormatSQL(z4951.CheckUse) & "', "
            SQL = SQL & "    K4951_CheckComplete      = N'" & FormatSQL(z4951.CheckComplete) & "'  "
            SQL = SQL & " WHERE K4951_AutoKey		 =  " & z4951.AutoKey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()


            REWRITE_PFK4951 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK4951", vbCritical)

        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK4951(z4951 As T4951_AREA) As Boolean
        DELETE_PFK4951 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z4951)

            SQL = " DELETE FROM PFK4951  "
            SQL = SQL & " WHERE K4951_AutoKey		 =  " & z4951.AutoKey & "  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK4951 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK4951", vbCritical)
        Finally
            Call GetFullInformation("PFK4951", "D", SQL)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D4951_CLEAR()
        Try

            D4951.AutoKey = 0
            D4951.LoadingCode = ""
            D4951.seSite = ""
            D4951.cdSite = ""
            D4951.Autokey_4958 = 0
            D4951.LoadingCMB = 0
            D4951.LoadingNW = 0
            D4951.LoadingGW = 0
            D4951.QtyCarton = 0
            D4951.QtyLoading = 0
            D4951.DateInsert = ""
            D4951.DateUpdate = ""
            D4951.TimeInsert = ""
            D4951.TimeUpdate = ""
            D4951.InchargeInsert = ""
            D4951.InchargeUpdate = ""
            D4951.CheckUse = ""
            D4951.CheckComplete = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D4951_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x4951 As T4951_AREA)
        Try

            x4951.AutoKey = trim$(x4951.AutoKey)
            x4951.LoadingCode = trim$(x4951.LoadingCode)
            x4951.seSite = trim$(x4951.seSite)
            x4951.cdSite = trim$(x4951.cdSite)
            x4951.Autokey_4958 = trim$(x4951.Autokey_4958)
            x4951.LoadingCMB = trim$(x4951.LoadingCMB)
            x4951.LoadingNW = trim$(x4951.LoadingNW)
            x4951.LoadingGW = trim$(x4951.LoadingGW)
            x4951.QtyCarton = trim$(x4951.QtyCarton)
            x4951.QtyLoading = trim$(x4951.QtyLoading)
            x4951.DateInsert = trim$(x4951.DateInsert)
            x4951.DateUpdate = trim$(x4951.DateUpdate)
            x4951.TimeInsert = trim$(x4951.TimeInsert)
            x4951.TimeUpdate = trim$(x4951.TimeUpdate)
            x4951.InchargeInsert = trim$(x4951.InchargeInsert)
            x4951.InchargeUpdate = trim$(x4951.InchargeUpdate)
            x4951.CheckUse = trim$(x4951.CheckUse)
            x4951.CheckComplete = trim$(x4951.CheckComplete)

            If trim$(x4951.AutoKey) = "" Then x4951.AutoKey = 0
            If trim$(x4951.LoadingCode) = "" Then x4951.LoadingCode = Space(1)
            If trim$(x4951.seSite) = "" Then x4951.seSite = Space(1)
            If trim$(x4951.cdSite) = "" Then x4951.cdSite = Space(1)
            If trim$(x4951.Autokey_4958) = "" Then x4951.Autokey_4958 = 0
            If trim$(x4951.LoadingCMB) = "" Then x4951.LoadingCMB = 0
            If trim$(x4951.LoadingNW) = "" Then x4951.LoadingNW = 0
            If trim$(x4951.LoadingGW) = "" Then x4951.LoadingGW = 0
            If trim$(x4951.QtyCarton) = "" Then x4951.QtyCarton = 0
            If trim$(x4951.QtyLoading) = "" Then x4951.QtyLoading = 0
            If trim$(x4951.DateInsert) = "" Then x4951.DateInsert = Space(1)
            If trim$(x4951.DateUpdate) = "" Then x4951.DateUpdate = Space(1)
            If trim$(x4951.TimeInsert) = "" Then x4951.TimeInsert = Space(1)
            If trim$(x4951.TimeUpdate) = "" Then x4951.TimeUpdate = Space(1)
            If trim$(x4951.InchargeInsert) = "" Then x4951.InchargeInsert = Space(1)
            If trim$(x4951.InchargeUpdate) = "" Then x4951.InchargeUpdate = Space(1)
            If trim$(x4951.CheckUse) = "" Then x4951.CheckUse = Space(1)
            If trim$(x4951.CheckComplete) = "" Then x4951.CheckComplete = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K4951_MOVE(rs4951 As SqlClient.SqlDataReader)
        Try

            Call D4951_CLEAR()

            If IsdbNull(rs4951!K4951_AutoKey) = False Then D4951.AutoKey = Trim$(rs4951!K4951_AutoKey)
            If IsdbNull(rs4951!K4951_LoadingCode) = False Then D4951.LoadingCode = Trim$(rs4951!K4951_LoadingCode)
            If IsdbNull(rs4951!K4951_seSite) = False Then D4951.seSite = Trim$(rs4951!K4951_seSite)
            If IsdbNull(rs4951!K4951_cdSite) = False Then D4951.cdSite = Trim$(rs4951!K4951_cdSite)
            If IsdbNull(rs4951!K4951_Autokey_4958) = False Then D4951.Autokey_4958 = Trim$(rs4951!K4951_Autokey_4958)
            If IsdbNull(rs4951!K4951_LoadingCMB) = False Then D4951.LoadingCMB = Trim$(rs4951!K4951_LoadingCMB)
            If IsdbNull(rs4951!K4951_LoadingNW) = False Then D4951.LoadingNW = Trim$(rs4951!K4951_LoadingNW)
            If IsdbNull(rs4951!K4951_LoadingGW) = False Then D4951.LoadingGW = Trim$(rs4951!K4951_LoadingGW)
            If IsdbNull(rs4951!K4951_QtyCarton) = False Then D4951.QtyCarton = Trim$(rs4951!K4951_QtyCarton)
            If IsdbNull(rs4951!K4951_QtyLoading) = False Then D4951.QtyLoading = Trim$(rs4951!K4951_QtyLoading)
            If IsdbNull(rs4951!K4951_DateInsert) = False Then D4951.DateInsert = Trim$(rs4951!K4951_DateInsert)
            If IsdbNull(rs4951!K4951_DateUpdate) = False Then D4951.DateUpdate = Trim$(rs4951!K4951_DateUpdate)
            If IsdbNull(rs4951!K4951_TimeInsert) = False Then D4951.TimeInsert = Trim$(rs4951!K4951_TimeInsert)
            If IsdbNull(rs4951!K4951_TimeUpdate) = False Then D4951.TimeUpdate = Trim$(rs4951!K4951_TimeUpdate)
            If IsdbNull(rs4951!K4951_InchargeInsert) = False Then D4951.InchargeInsert = Trim$(rs4951!K4951_InchargeInsert)
            If IsdbNull(rs4951!K4951_InchargeUpdate) = False Then D4951.InchargeUpdate = Trim$(rs4951!K4951_InchargeUpdate)
            If IsdbNull(rs4951!K4951_CheckUse) = False Then D4951.CheckUse = Trim$(rs4951!K4951_CheckUse)
            If IsdbNull(rs4951!K4951_CheckComplete) = False Then D4951.CheckComplete = Trim$(rs4951!K4951_CheckComplete)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K4951_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K4951_MOVE(rs4951 As DataRow)
        Try

            Call D4951_CLEAR()

            If IsdbNull(rs4951!K4951_AutoKey) = False Then D4951.AutoKey = Trim$(rs4951!K4951_AutoKey)
            If IsdbNull(rs4951!K4951_LoadingCode) = False Then D4951.LoadingCode = Trim$(rs4951!K4951_LoadingCode)
            If IsdbNull(rs4951!K4951_seSite) = False Then D4951.seSite = Trim$(rs4951!K4951_seSite)
            If IsdbNull(rs4951!K4951_cdSite) = False Then D4951.cdSite = Trim$(rs4951!K4951_cdSite)
            If IsdbNull(rs4951!K4951_Autokey_4958) = False Then D4951.Autokey_4958 = Trim$(rs4951!K4951_Autokey_4958)
            If IsdbNull(rs4951!K4951_LoadingCMB) = False Then D4951.LoadingCMB = Trim$(rs4951!K4951_LoadingCMB)
            If IsdbNull(rs4951!K4951_LoadingNW) = False Then D4951.LoadingNW = Trim$(rs4951!K4951_LoadingNW)
            If IsdbNull(rs4951!K4951_LoadingGW) = False Then D4951.LoadingGW = Trim$(rs4951!K4951_LoadingGW)
            If IsdbNull(rs4951!K4951_QtyCarton) = False Then D4951.QtyCarton = Trim$(rs4951!K4951_QtyCarton)
            If IsdbNull(rs4951!K4951_QtyLoading) = False Then D4951.QtyLoading = Trim$(rs4951!K4951_QtyLoading)
            If IsdbNull(rs4951!K4951_DateInsert) = False Then D4951.DateInsert = Trim$(rs4951!K4951_DateInsert)
            If IsdbNull(rs4951!K4951_DateUpdate) = False Then D4951.DateUpdate = Trim$(rs4951!K4951_DateUpdate)
            If IsdbNull(rs4951!K4951_TimeInsert) = False Then D4951.TimeInsert = Trim$(rs4951!K4951_TimeInsert)
            If IsdbNull(rs4951!K4951_TimeUpdate) = False Then D4951.TimeUpdate = Trim$(rs4951!K4951_TimeUpdate)
            If IsdbNull(rs4951!K4951_InchargeInsert) = False Then D4951.InchargeInsert = Trim$(rs4951!K4951_InchargeInsert)
            If IsdbNull(rs4951!K4951_InchargeUpdate) = False Then D4951.InchargeUpdate = Trim$(rs4951!K4951_InchargeUpdate)
            If IsdbNull(rs4951!K4951_CheckUse) = False Then D4951.CheckUse = Trim$(rs4951!K4951_CheckUse)
            If IsdbNull(rs4951!K4951_CheckComplete) = False Then D4951.CheckComplete = Trim$(rs4951!K4951_CheckComplete)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K4951_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K4951_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z4951 As T4951_AREA, AUTOKEY As Double) As Boolean

        K4951_MOVE = False

        Try
            If READ_PFK4951(AUTOKEY) = True Then
                z4951 = D4951
                K4951_MOVE = True
            Else
                z4951 = Nothing
            End If

            If getColumnIndex(spr, "AutoKey") > -1 Then z4951.AutoKey = Cdecp(getDataM(spr, getColumnIndex(spr, "AutoKey"), xRow))
            If getColumnIndex(spr, "LoadingCode") > -1 Then z4951.LoadingCode = getDataM(spr, getColumnIndex(spr, "LoadingCode"), xRow)
            If getColumnIndex(spr, "seSite") > -1 Then z4951.seSite = getDataM(spr, getColumnIndex(spr, "seSite"), xRow)
            If getColumnIndex(spr, "cdSite") > -1 Then z4951.cdSite = getDataM(spr, getColumnIndex(spr, "cdSite"), xRow)
            If getColumnIndex(spr, "Autokey_4958") > -1 Then z4951.Autokey_4958 = Cdecp(getDataM(spr, getColumnIndex(spr, "Autokey_4958"), xRow))
            If getColumnIndex(spr, "LoadingCMB") > -1 Then z4951.LoadingCMB = Cdecp(getDataM(spr, getColumnIndex(spr, "LoadingCMB"), xRow))
            If getColumnIndex(spr, "LoadingNW") > -1 Then z4951.LoadingNW = Cdecp(getDataM(spr, getColumnIndex(spr, "LoadingNW"), xRow))
            If getColumnIndex(spr, "LoadingGW") > -1 Then z4951.LoadingGW = Cdecp(getDataM(spr, getColumnIndex(spr, "LoadingGW"), xRow))
            If getColumnIndex(spr, "QtyCarton") > -1 Then z4951.QtyCarton = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyCarton"), xRow))
            If getColumnIndex(spr, "QtyLoading") > -1 Then z4951.QtyLoading = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyLoading"), xRow))
            If getColumnIndex(spr, "DateInsert") > -1 Then z4951.DateInsert = getDataM(spr, getColumnIndex(spr, "DateInsert"), xRow)
            If getColumnIndex(spr, "DateUpdate") > -1 Then z4951.DateUpdate = getDataM(spr, getColumnIndex(spr, "DateUpdate"), xRow)
            If getColumnIndex(spr, "TimeInsert") > -1 Then z4951.TimeInsert = getDataM(spr, getColumnIndex(spr, "TimeInsert"), xRow)
            If getColumnIndex(spr, "TimeUpdate") > -1 Then z4951.TimeUpdate = getDataM(spr, getColumnIndex(spr, "TimeUpdate"), xRow)
            If getColumnIndex(spr, "InchargeInsert") > -1 Then z4951.InchargeInsert = getDataM(spr, getColumnIndex(spr, "InchargeInsert"), xRow)
            If getColumnIndex(spr, "InchargeUpdate") > -1 Then z4951.InchargeUpdate = getDataM(spr, getColumnIndex(spr, "InchargeUpdate"), xRow)
            If getColumnIndex(spr, "CheckUse") > -1 Then z4951.CheckUse = getDataM(spr, getColumnIndex(spr, "CheckUse"), xRow)
            If getColumnIndex(spr, "CheckComplete") > -1 Then z4951.CheckComplete = getDataM(spr, getColumnIndex(spr, "CheckComplete"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4951_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K4951_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z4951 As T4951_AREA, CheckClear As Boolean, AUTOKEY As Double) As Boolean

        K4951_MOVE = False

        Try
            If READ_PFK4951(AUTOKEY) = True Then
                z4951 = D4951
                K4951_MOVE = True
            Else
                If CheckClear = True Then z4951 = Nothing
            End If

            If getColumnIndex(spr, "AutoKey") > -1 Then z4951.AutoKey = Cdecp(getDataM(spr, getColumnIndex(spr, "AutoKey"), xRow))
            If getColumnIndex(spr, "LoadingCode") > -1 Then z4951.LoadingCode = getDataM(spr, getColumnIndex(spr, "LoadingCode"), xRow)
            If getColumnIndex(spr, "seSite") > -1 Then z4951.seSite = getDataM(spr, getColumnIndex(spr, "seSite"), xRow)
            If getColumnIndex(spr, "cdSite") > -1 Then z4951.cdSite = getDataM(spr, getColumnIndex(spr, "cdSite"), xRow)
            If getColumnIndex(spr, "Autokey_4958") > -1 Then z4951.Autokey_4958 = Cdecp(getDataM(spr, getColumnIndex(spr, "Autokey_4958"), xRow))
            If getColumnIndex(spr, "LoadingCMB") > -1 Then z4951.LoadingCMB = Cdecp(getDataM(spr, getColumnIndex(spr, "LoadingCMB"), xRow))
            If getColumnIndex(spr, "LoadingNW") > -1 Then z4951.LoadingNW = Cdecp(getDataM(spr, getColumnIndex(spr, "LoadingNW"), xRow))
            If getColumnIndex(spr, "LoadingGW") > -1 Then z4951.LoadingGW = Cdecp(getDataM(spr, getColumnIndex(spr, "LoadingGW"), xRow))
            If getColumnIndex(spr, "QtyCarton") > -1 Then z4951.QtyCarton = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyCarton"), xRow))
            If getColumnIndex(spr, "QtyLoading") > -1 Then z4951.QtyLoading = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyLoading"), xRow))
            If getColumnIndex(spr, "DateInsert") > -1 Then z4951.DateInsert = getDataM(spr, getColumnIndex(spr, "DateInsert"), xRow)
            If getColumnIndex(spr, "DateUpdate") > -1 Then z4951.DateUpdate = getDataM(spr, getColumnIndex(spr, "DateUpdate"), xRow)
            If getColumnIndex(spr, "TimeInsert") > -1 Then z4951.TimeInsert = getDataM(spr, getColumnIndex(spr, "TimeInsert"), xRow)
            If getColumnIndex(spr, "TimeUpdate") > -1 Then z4951.TimeUpdate = getDataM(spr, getColumnIndex(spr, "TimeUpdate"), xRow)
            If getColumnIndex(spr, "InchargeInsert") > -1 Then z4951.InchargeInsert = getDataM(spr, getColumnIndex(spr, "InchargeInsert"), xRow)
            If getColumnIndex(spr, "InchargeUpdate") > -1 Then z4951.InchargeUpdate = getDataM(spr, getColumnIndex(spr, "InchargeUpdate"), xRow)
            If getColumnIndex(spr, "CheckUse") > -1 Then z4951.CheckUse = getDataM(spr, getColumnIndex(spr, "CheckUse"), xRow)
            If getColumnIndex(spr, "CheckComplete") > -1 Then z4951.CheckComplete = getDataM(spr, getColumnIndex(spr, "CheckComplete"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4951_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K4951_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z4951 As T4951_AREA, Job As String, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K4951_MOVE = False

        Try
            If READ_PFK4951(AUTOKEY) = True Then
                z4951 = D4951
                K4951_MOVE = True
            Else
                z4951 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4951")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z4951.AutoKey = Children(i).Code
                                Case "LOADINGCODE" : z4951.LoadingCode = Children(i).Code
                                Case "SESITE" : z4951.seSite = Children(i).Code
                                Case "CDSITE" : z4951.cdSite = Children(i).Code
                                Case "AUTOKEY_4958" : z4951.Autokey_4958 = Children(i).Code
                                Case "LOADINGCMB" : z4951.LoadingCMB = Children(i).Code
                                Case "LOADINGNW" : z4951.LoadingNW = Children(i).Code
                                Case "LOADINGGW" : z4951.LoadingGW = Children(i).Code
                                Case "QTYCARTON" : z4951.QtyCarton = Children(i).Code
                                Case "QTYLOADING" : z4951.QtyLoading = Children(i).Code
                                Case "DATEINSERT" : z4951.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z4951.DateUpdate = Children(i).Code
                                Case "TIMEINSERT" : z4951.TimeInsert = Children(i).Code
                                Case "TIMEUPDATE" : z4951.TimeUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z4951.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z4951.InchargeUpdate = Children(i).Code
                                Case "CHECKUSE" : z4951.CheckUse = Children(i).Code
                                Case "CHECKCOMPLETE" : z4951.CheckComplete = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z4951.AutoKey = Cdecp(Children(i).Data)
                                Case "LOADINGCODE" : z4951.LoadingCode = Children(i).Data
                                Case "SESITE" : z4951.seSite = Children(i).Data
                                Case "CDSITE" : z4951.cdSite = Children(i).Data
                                Case "AUTOKEY_4958" : z4951.Autokey_4958 = Cdecp(Children(i).Data)
                                Case "LOADINGCMB" : z4951.LoadingCMB = Cdecp(Children(i).Data)
                                Case "LOADINGNW" : z4951.LoadingNW = Cdecp(Children(i).Data)
                                Case "LOADINGGW" : z4951.LoadingGW = Cdecp(Children(i).Data)
                                Case "QTYCARTON" : z4951.QtyCarton = Cdecp(Children(i).Data)
                                Case "QTYLOADING" : z4951.QtyLoading = Cdecp(Children(i).Data)
                                Case "DATEINSERT" : z4951.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z4951.DateUpdate = Children(i).Data
                                Case "TIMEINSERT" : z4951.TimeInsert = Children(i).Data
                                Case "TIMEUPDATE" : z4951.TimeUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z4951.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z4951.InchargeUpdate = Children(i).Data
                                Case "CHECKUSE" : z4951.CheckUse = Children(i).Data
                                Case "CHECKCOMPLETE" : z4951.CheckComplete = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4951_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K4951_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z4951 As T4951_AREA, Job As String, CheckClear As Boolean, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K4951_MOVE = False

        Try
            If READ_PFK4951(AUTOKEY) = True Then
                z4951 = D4951
                K4951_MOVE = True
            Else
                If CheckClear = True Then z4951 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4951")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z4951.AutoKey = Children(i).Code
                                Case "LOADINGCODE" : z4951.LoadingCode = Children(i).Code
                                Case "SESITE" : z4951.seSite = Children(i).Code
                                Case "CDSITE" : z4951.cdSite = Children(i).Code
                                Case "AUTOKEY_4958" : z4951.Autokey_4958 = Children(i).Code
                                Case "LOADINGCMB" : z4951.LoadingCMB = Children(i).Code
                                Case "LOADINGNW" : z4951.LoadingNW = Children(i).Code
                                Case "LOADINGGW" : z4951.LoadingGW = Children(i).Code
                                Case "QTYCARTON" : z4951.QtyCarton = Children(i).Code
                                Case "QTYLOADING" : z4951.QtyLoading = Children(i).Code
                                Case "DATEINSERT" : z4951.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z4951.DateUpdate = Children(i).Code
                                Case "TIMEINSERT" : z4951.TimeInsert = Children(i).Code
                                Case "TIMEUPDATE" : z4951.TimeUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z4951.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z4951.InchargeUpdate = Children(i).Code
                                Case "CHECKUSE" : z4951.CheckUse = Children(i).Code
                                Case "CHECKCOMPLETE" : z4951.CheckComplete = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z4951.AutoKey = Cdecp(Children(i).Data)
                                Case "LOADINGCODE" : z4951.LoadingCode = Children(i).Data
                                Case "SESITE" : z4951.seSite = Children(i).Data
                                Case "CDSITE" : z4951.cdSite = Children(i).Data
                                Case "AUTOKEY_4958" : z4951.Autokey_4958 = Cdecp(Children(i).Data)
                                Case "LOADINGCMB" : z4951.LoadingCMB = Cdecp(Children(i).Data)
                                Case "LOADINGNW" : z4951.LoadingNW = Cdecp(Children(i).Data)
                                Case "LOADINGGW" : z4951.LoadingGW = Cdecp(Children(i).Data)
                                Case "QTYCARTON" : z4951.QtyCarton = Cdecp(Children(i).Data)
                                Case "QTYLOADING" : z4951.QtyLoading = Cdecp(Children(i).Data)
                                Case "DATEINSERT" : z4951.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z4951.DateUpdate = Children(i).Data
                                Case "TIMEINSERT" : z4951.TimeInsert = Children(i).Data
                                Case "TIMEUPDATE" : z4951.TimeUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z4951.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z4951.InchargeUpdate = Children(i).Data
                                Case "CHECKUSE" : z4951.CheckUse = Children(i).Data
                                Case "CHECKCOMPLETE" : z4951.CheckComplete = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4951_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW AREA
    '=========================================================================================================================================================
    Public Sub K4951_MOVE(ByRef a4951 As T4951_AREA, ByRef b4951 As T4951_AREA)
        Try
            If trim$(a4951.AutoKey) = "" Then b4951.AutoKey = "" Else b4951.AutoKey = a4951.AutoKey
            If trim$(a4951.LoadingCode) = "" Then b4951.LoadingCode = "" Else b4951.LoadingCode = a4951.LoadingCode
            If trim$(a4951.seSite) = "" Then b4951.seSite = "" Else b4951.seSite = a4951.seSite
            If trim$(a4951.cdSite) = "" Then b4951.cdSite = "" Else b4951.cdSite = a4951.cdSite
            If trim$(a4951.Autokey_4958) = "" Then b4951.Autokey_4958 = "" Else b4951.Autokey_4958 = a4951.Autokey_4958
            If trim$(a4951.LoadingCMB) = "" Then b4951.LoadingCMB = "" Else b4951.LoadingCMB = a4951.LoadingCMB
            If trim$(a4951.LoadingNW) = "" Then b4951.LoadingNW = "" Else b4951.LoadingNW = a4951.LoadingNW
            If trim$(a4951.LoadingGW) = "" Then b4951.LoadingGW = "" Else b4951.LoadingGW = a4951.LoadingGW
            If trim$(a4951.QtyCarton) = "" Then b4951.QtyCarton = "" Else b4951.QtyCarton = a4951.QtyCarton
            If trim$(a4951.QtyLoading) = "" Then b4951.QtyLoading = "" Else b4951.QtyLoading = a4951.QtyLoading
            If trim$(a4951.DateInsert) = "" Then b4951.DateInsert = "" Else b4951.DateInsert = a4951.DateInsert
            If trim$(a4951.DateUpdate) = "" Then b4951.DateUpdate = "" Else b4951.DateUpdate = a4951.DateUpdate
            If trim$(a4951.TimeInsert) = "" Then b4951.TimeInsert = "" Else b4951.TimeInsert = a4951.TimeInsert
            If trim$(a4951.TimeUpdate) = "" Then b4951.TimeUpdate = "" Else b4951.TimeUpdate = a4951.TimeUpdate
            If trim$(a4951.InchargeInsert) = "" Then b4951.InchargeInsert = "" Else b4951.InchargeInsert = a4951.InchargeInsert
            If trim$(a4951.InchargeUpdate) = "" Then b4951.InchargeUpdate = "" Else b4951.InchargeUpdate = a4951.InchargeUpdate
            If trim$(a4951.CheckUse) = "" Then b4951.CheckUse = "" Else b4951.CheckUse = a4951.CheckUse
            If trim$(a4951.CheckComplete) = "" Then b4951.CheckComplete = "" Else b4951.CheckComplete = a4951.CheckComplete
        Catch ex As Exception
            Call MsgBoxP("K4951_MOVE", vbCritical)
        End Try
    End Sub


End Module
