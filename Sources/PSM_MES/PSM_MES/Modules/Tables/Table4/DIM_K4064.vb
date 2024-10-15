'=========================================================================================================================================================
'   TABLE : (PFK4064)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K4064

    Structure T4064_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public Autokey As Double  '			decimal		*
        Public seMainProcess As String  '			char(3)
        Public cdMainProcess As String  '			char(3)
        Public JobCard As String  '			char(9)
        Public seFactory As String  '			char(6)
        Public cdFactory As String  '			char(8)
        Public CustomerCode As String  '			char(6)
        Public seLineProd As String  '			char(6)
        Public cdLineProd As String  '			char(8)
        Public MachineCode As String  '			char(6)
        Public DatePlan As String  '			char(8)
        Public DateFinish As String  '			char(8)
        Public Description As String  '			nvarchar(50)
        Public QtyPlan As Double  '			decimal
        Public QtyProd As Double  '			decimal
        Public InchargePlan As String  '			char(8)
        Public DateInsert As String  '			char(8)
        Public InchargeInsert As String  '			char(6)
        Public DateUpdate As String  '			char(8)
        Public InchargeUpdate As String  '			char(6)
        Public Remark As String  '			nvarchar(50)
        '=========================================================================================================================================================
    End Structure

    Public D4064 As T4064_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK4064(AUTOKEY As Double) As Boolean
        READ_PFK4064 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4064 "
            SQL = SQL & " WHERE K4064_Autokey		 =  " & Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4064_CLEAR() : GoTo SKIP_READ_PFK4064

            Call K4064_MOVE(rd)
            READ_PFK4064 = True

SKIP_READ_PFK4064:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4064", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK4064(AUTOKEY As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4064 "
            SQL = SQL & " WHERE K4064_Autokey		 =  " & Autokey & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK4064", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK4064(z4064 As T4064_AREA) As Boolean
        WRITE_PFK4064 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z4064)

            SQL = " INSERT INTO PFK4064 "
            SQL = SQL & " ( "
            SQL = SQL & " K4064_seMainProcess,"
            SQL = SQL & " K4064_cdMainProcess,"
            SQL = SQL & " K4064_JobCard,"
            SQL = SQL & " K4064_seFactory,"
            SQL = SQL & " K4064_cdFactory,"
            SQL = SQL & " K4064_CustomerCode,"
            SQL = SQL & " K4064_seLineProd,"
            SQL = SQL & " K4064_cdLineProd,"
            SQL = SQL & " K4064_MachineCode,"
            SQL = SQL & " K4064_DatePlan,"
            SQL = SQL & " K4064_DateFinish,"
            SQL = SQL & " K4064_Description,"
            SQL = SQL & " K4064_QtyPlan,"
            SQL = SQL & " K4064_QtyProd,"
            SQL = SQL & " K4064_InchargePlan,"
            SQL = SQL & " K4064_DateInsert,"
            SQL = SQL & " K4064_InchargeInsert,"
            SQL = SQL & " K4064_DateUpdate,"
            SQL = SQL & " K4064_InchargeUpdate,"
            SQL = SQL & " K4064_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z4064.seMainProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4064.cdMainProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4064.JobCard) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4064.seFactory) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4064.cdFactory) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4064.CustomerCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4064.seLineProd) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4064.cdLineProd) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4064.MachineCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4064.DatePlan) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4064.DateFinish) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4064.Description) & "', "
            SQL = SQL & "   " & FormatSQL(z4064.QtyPlan) & ", "
            SQL = SQL & "   " & FormatSQL(z4064.QtyProd) & ", "
            SQL = SQL & "  N'" & FormatSQL(z4064.InchargePlan) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4064.DateInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4064.InchargeInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4064.DateUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4064.InchargeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4064.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK4064 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK4064", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK4064(z4064 As T4064_AREA) As Boolean
        REWRITE_PFK4064 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z4064)

            SQL = " UPDATE PFK4064 SET "
            SQL = SQL & "    K4064_seMainProcess      = N'" & FormatSQL(z4064.seMainProcess) & "', "
            SQL = SQL & "    K4064_cdMainProcess      = N'" & FormatSQL(z4064.cdMainProcess) & "', "
            SQL = SQL & "    K4064_JobCard      = N'" & FormatSQL(z4064.JobCard) & "', "
            SQL = SQL & "    K4064_seFactory      = N'" & FormatSQL(z4064.seFactory) & "', "
            SQL = SQL & "    K4064_cdFactory      = N'" & FormatSQL(z4064.cdFactory) & "', "
            SQL = SQL & "    K4064_CustomerCode      = N'" & FormatSQL(z4064.CustomerCode) & "', "
            SQL = SQL & "    K4064_seLineProd      = N'" & FormatSQL(z4064.seLineProd) & "', "
            SQL = SQL & "    K4064_cdLineProd      = N'" & FormatSQL(z4064.cdLineProd) & "', "
            SQL = SQL & "    K4064_MachineCode      = N'" & FormatSQL(z4064.MachineCode) & "', "
            SQL = SQL & "    K4064_DatePlan      = N'" & FormatSQL(z4064.DatePlan) & "', "
            SQL = SQL & "    K4064_DateFinish      = N'" & FormatSQL(z4064.DateFinish) & "', "
            SQL = SQL & "    K4064_Description      = N'" & FormatSQL(z4064.Description) & "', "
            SQL = SQL & "    K4064_QtyPlan      =  " & FormatSQL(z4064.QtyPlan) & ", "
            SQL = SQL & "    K4064_QtyProd      =  " & FormatSQL(z4064.QtyProd) & ", "
            SQL = SQL & "    K4064_InchargePlan      = N'" & FormatSQL(z4064.InchargePlan) & "', "
            SQL = SQL & "    K4064_DateInsert      = N'" & FormatSQL(z4064.DateInsert) & "', "
            SQL = SQL & "    K4064_InchargeInsert      = N'" & FormatSQL(z4064.InchargeInsert) & "', "
            SQL = SQL & "    K4064_DateUpdate      = N'" & FormatSQL(z4064.DateUpdate) & "', "
            SQL = SQL & "    K4064_InchargeUpdate      = N'" & FormatSQL(z4064.InchargeUpdate) & "', "
            SQL = SQL & "    K4064_Remark      = N'" & FormatSQL(z4064.Remark) & "'  "
            SQL = SQL & " WHERE K4064_Autokey		 =  " & z4064.Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK4064 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK4064", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK4064(z4064 As T4064_AREA) As Boolean
        DELETE_PFK4064 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK4064 "
            SQL = SQL & " WHERE K4064_Autokey		 =  " & z4064.Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK4064 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK4064", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D4064_CLEAR()
        Try

            D4064.Autokey = 0
            D4064.seMainProcess = ""
            D4064.cdMainProcess = ""
            D4064.JobCard = ""
            D4064.seFactory = ""
            D4064.cdFactory = ""
            D4064.CustomerCode = ""
            D4064.seLineProd = ""
            D4064.cdLineProd = ""
            D4064.MachineCode = ""
            D4064.DatePlan = ""
            D4064.DateFinish = ""
            D4064.Description = ""
            D4064.QtyPlan = 0
            D4064.QtyProd = 0
            D4064.InchargePlan = ""
            D4064.DateInsert = ""
            D4064.InchargeInsert = ""
            D4064.DateUpdate = ""
            D4064.InchargeUpdate = ""
            D4064.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D4064_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x4064 As T4064_AREA)
        Try

            x4064.Autokey = trim$(x4064.Autokey)
            x4064.seMainProcess = trim$(x4064.seMainProcess)
            x4064.cdMainProcess = trim$(x4064.cdMainProcess)
            x4064.JobCard = trim$(x4064.JobCard)
            x4064.seFactory = trim$(x4064.seFactory)
            x4064.cdFactory = trim$(x4064.cdFactory)
            x4064.CustomerCode = trim$(x4064.CustomerCode)
            x4064.seLineProd = trim$(x4064.seLineProd)
            x4064.cdLineProd = trim$(x4064.cdLineProd)
            x4064.MachineCode = trim$(x4064.MachineCode)
            x4064.DatePlan = trim$(x4064.DatePlan)
            x4064.DateFinish = trim$(x4064.DateFinish)
            x4064.Description = trim$(x4064.Description)
            x4064.QtyPlan = trim$(x4064.QtyPlan)
            x4064.QtyProd = trim$(x4064.QtyProd)
            x4064.InchargePlan = trim$(x4064.InchargePlan)
            x4064.DateInsert = trim$(x4064.DateInsert)
            x4064.InchargeInsert = trim$(x4064.InchargeInsert)
            x4064.DateUpdate = trim$(x4064.DateUpdate)
            x4064.InchargeUpdate = trim$(x4064.InchargeUpdate)
            x4064.Remark = trim$(x4064.Remark)

            If trim$(x4064.Autokey) = "" Then x4064.Autokey = 0
            If trim$(x4064.seMainProcess) = "" Then x4064.seMainProcess = Space(1)
            If trim$(x4064.cdMainProcess) = "" Then x4064.cdMainProcess = Space(1)
            If trim$(x4064.JobCard) = "" Then x4064.JobCard = Space(1)
            If trim$(x4064.seFactory) = "" Then x4064.seFactory = Space(1)
            If trim$(x4064.cdFactory) = "" Then x4064.cdFactory = Space(1)
            If trim$(x4064.CustomerCode) = "" Then x4064.CustomerCode = Space(1)
            If trim$(x4064.seLineProd) = "" Then x4064.seLineProd = Space(1)
            If trim$(x4064.cdLineProd) = "" Then x4064.cdLineProd = Space(1)
            If trim$(x4064.MachineCode) = "" Then x4064.MachineCode = Space(1)
            If trim$(x4064.DatePlan) = "" Then x4064.DatePlan = Space(1)
            If trim$(x4064.DateFinish) = "" Then x4064.DateFinish = Space(1)
            If trim$(x4064.Description) = "" Then x4064.Description = Space(1)
            If trim$(x4064.QtyPlan) = "" Then x4064.QtyPlan = 0
            If trim$(x4064.QtyProd) = "" Then x4064.QtyProd = 0
            If trim$(x4064.InchargePlan) = "" Then x4064.InchargePlan = Space(1)
            If trim$(x4064.DateInsert) = "" Then x4064.DateInsert = Space(1)
            If trim$(x4064.InchargeInsert) = "" Then x4064.InchargeInsert = Space(1)
            If trim$(x4064.DateUpdate) = "" Then x4064.DateUpdate = Space(1)
            If trim$(x4064.InchargeUpdate) = "" Then x4064.InchargeUpdate = Space(1)
            If trim$(x4064.Remark) = "" Then x4064.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K4064_MOVE(rs4064 As SqlClient.SqlDataReader)
        Try

            Call D4064_CLEAR()

            If IsdbNull(rs4064!K4064_Autokey) = False Then D4064.Autokey = Trim$(rs4064!K4064_Autokey)
            If IsdbNull(rs4064!K4064_seMainProcess) = False Then D4064.seMainProcess = Trim$(rs4064!K4064_seMainProcess)
            If IsdbNull(rs4064!K4064_cdMainProcess) = False Then D4064.cdMainProcess = Trim$(rs4064!K4064_cdMainProcess)
            If IsdbNull(rs4064!K4064_JobCard) = False Then D4064.JobCard = Trim$(rs4064!K4064_JobCard)
            If IsdbNull(rs4064!K4064_seFactory) = False Then D4064.seFactory = Trim$(rs4064!K4064_seFactory)
            If IsdbNull(rs4064!K4064_cdFactory) = False Then D4064.cdFactory = Trim$(rs4064!K4064_cdFactory)
            If IsdbNull(rs4064!K4064_CustomerCode) = False Then D4064.CustomerCode = Trim$(rs4064!K4064_CustomerCode)
            If IsdbNull(rs4064!K4064_seLineProd) = False Then D4064.seLineProd = Trim$(rs4064!K4064_seLineProd)
            If IsdbNull(rs4064!K4064_cdLineProd) = False Then D4064.cdLineProd = Trim$(rs4064!K4064_cdLineProd)
            If IsdbNull(rs4064!K4064_MachineCode) = False Then D4064.MachineCode = Trim$(rs4064!K4064_MachineCode)
            If IsdbNull(rs4064!K4064_DatePlan) = False Then D4064.DatePlan = Trim$(rs4064!K4064_DatePlan)
            If IsdbNull(rs4064!K4064_DateFinish) = False Then D4064.DateFinish = Trim$(rs4064!K4064_DateFinish)
            If IsdbNull(rs4064!K4064_Description) = False Then D4064.Description = Trim$(rs4064!K4064_Description)
            If IsdbNull(rs4064!K4064_QtyPlan) = False Then D4064.QtyPlan = Trim$(rs4064!K4064_QtyPlan)
            If IsdbNull(rs4064!K4064_QtyProd) = False Then D4064.QtyProd = Trim$(rs4064!K4064_QtyProd)
            If IsdbNull(rs4064!K4064_InchargePlan) = False Then D4064.InchargePlan = Trim$(rs4064!K4064_InchargePlan)
            If IsdbNull(rs4064!K4064_DateInsert) = False Then D4064.DateInsert = Trim$(rs4064!K4064_DateInsert)
            If IsdbNull(rs4064!K4064_InchargeInsert) = False Then D4064.InchargeInsert = Trim$(rs4064!K4064_InchargeInsert)
            If IsdbNull(rs4064!K4064_DateUpdate) = False Then D4064.DateUpdate = Trim$(rs4064!K4064_DateUpdate)
            If IsdbNull(rs4064!K4064_InchargeUpdate) = False Then D4064.InchargeUpdate = Trim$(rs4064!K4064_InchargeUpdate)
            If IsdbNull(rs4064!K4064_Remark) = False Then D4064.Remark = Trim$(rs4064!K4064_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K4064_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K4064_MOVE(rs4064 As DataRow)
        Try

            Call D4064_CLEAR()

            If IsdbNull(rs4064!K4064_Autokey) = False Then D4064.Autokey = Trim$(rs4064!K4064_Autokey)
            If IsdbNull(rs4064!K4064_seMainProcess) = False Then D4064.seMainProcess = Trim$(rs4064!K4064_seMainProcess)
            If IsdbNull(rs4064!K4064_cdMainProcess) = False Then D4064.cdMainProcess = Trim$(rs4064!K4064_cdMainProcess)
            If IsdbNull(rs4064!K4064_JobCard) = False Then D4064.JobCard = Trim$(rs4064!K4064_JobCard)
            If IsdbNull(rs4064!K4064_seFactory) = False Then D4064.seFactory = Trim$(rs4064!K4064_seFactory)
            If IsdbNull(rs4064!K4064_cdFactory) = False Then D4064.cdFactory = Trim$(rs4064!K4064_cdFactory)
            If IsdbNull(rs4064!K4064_CustomerCode) = False Then D4064.CustomerCode = Trim$(rs4064!K4064_CustomerCode)
            If IsdbNull(rs4064!K4064_seLineProd) = False Then D4064.seLineProd = Trim$(rs4064!K4064_seLineProd)
            If IsdbNull(rs4064!K4064_cdLineProd) = False Then D4064.cdLineProd = Trim$(rs4064!K4064_cdLineProd)
            If IsdbNull(rs4064!K4064_MachineCode) = False Then D4064.MachineCode = Trim$(rs4064!K4064_MachineCode)
            If IsdbNull(rs4064!K4064_DatePlan) = False Then D4064.DatePlan = Trim$(rs4064!K4064_DatePlan)
            If IsdbNull(rs4064!K4064_DateFinish) = False Then D4064.DateFinish = Trim$(rs4064!K4064_DateFinish)
            If IsdbNull(rs4064!K4064_Description) = False Then D4064.Description = Trim$(rs4064!K4064_Description)
            If IsdbNull(rs4064!K4064_QtyPlan) = False Then D4064.QtyPlan = Trim$(rs4064!K4064_QtyPlan)
            If IsdbNull(rs4064!K4064_QtyProd) = False Then D4064.QtyProd = Trim$(rs4064!K4064_QtyProd)
            If IsdbNull(rs4064!K4064_InchargePlan) = False Then D4064.InchargePlan = Trim$(rs4064!K4064_InchargePlan)
            If IsdbNull(rs4064!K4064_DateInsert) = False Then D4064.DateInsert = Trim$(rs4064!K4064_DateInsert)
            If IsdbNull(rs4064!K4064_InchargeInsert) = False Then D4064.InchargeInsert = Trim$(rs4064!K4064_InchargeInsert)
            If IsdbNull(rs4064!K4064_DateUpdate) = False Then D4064.DateUpdate = Trim$(rs4064!K4064_DateUpdate)
            If IsdbNull(rs4064!K4064_InchargeUpdate) = False Then D4064.InchargeUpdate = Trim$(rs4064!K4064_InchargeUpdate)
            If IsdbNull(rs4064!K4064_Remark) = False Then D4064.Remark = Trim$(rs4064!K4064_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K4064_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K4064_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z4064 As T4064_AREA, AUTOKEY As Double) As Boolean

        K4064_MOVE = False

        Try
            If READ_PFK4064(AUTOKEY) = True Then
                z4064 = D4064
                K4064_MOVE = True
            Else
                z4064 = Nothing
            End If

            If getColumIndex(spr, "Autokey") > -1 Then z4064.Autokey = getDataM(spr, getColumIndex(spr, "Autokey"), xRow)
            If getColumIndex(spr, "seMainProcess") > -1 Then z4064.seMainProcess = getDataM(spr, getColumIndex(spr, "seMainProcess"), xRow)
            If getColumIndex(spr, "cdMainProcess") > -1 Then z4064.cdMainProcess = getDataM(spr, getColumIndex(spr, "cdMainProcess"), xRow)
            If getColumIndex(spr, "JobCard") > -1 Then z4064.JobCard = getDataM(spr, getColumIndex(spr, "JobCard"), xRow)
            If getColumIndex(spr, "seFactory") > -1 Then z4064.seFactory = getDataM(spr, getColumIndex(spr, "seFactory"), xRow)
            If getColumIndex(spr, "cdFactory") > -1 Then z4064.cdFactory = getDataM(spr, getColumIndex(spr, "cdFactory"), xRow)
            If getColumIndex(spr, "CustomerCode") > -1 Then z4064.CustomerCode = getDataM(spr, getColumIndex(spr, "CustomerCode"), xRow)
            If getColumIndex(spr, "seLineProd") > -1 Then z4064.seLineProd = getDataM(spr, getColumIndex(spr, "seLineProd"), xRow)
            If getColumIndex(spr, "cdLineProd") > -1 Then z4064.cdLineProd = getDataM(spr, getColumIndex(spr, "cdLineProd"), xRow)
            If getColumIndex(spr, "MachineCode") > -1 Then z4064.MachineCode = getDataM(spr, getColumIndex(spr, "MachineCode"), xRow)
            If getColumIndex(spr, "DatePlan") > -1 Then z4064.DatePlan = getDataM(spr, getColumIndex(spr, "DatePlan"), xRow)
            If getColumIndex(spr, "DateFinish") > -1 Then z4064.DateFinish = getDataM(spr, getColumIndex(spr, "DateFinish"), xRow)
            If getColumIndex(spr, "Description") > -1 Then z4064.Description = getDataM(spr, getColumIndex(spr, "Description"), xRow)
            If getColumIndex(spr, "QtyPlan") > -1 Then z4064.QtyPlan = getDataM(spr, getColumIndex(spr, "QtyPlan"), xRow)
            If getColumIndex(spr, "QtyProd") > -1 Then z4064.QtyProd = getDataM(spr, getColumIndex(spr, "QtyProd"), xRow)
            If getColumIndex(spr, "InchargePlan") > -1 Then z4064.InchargePlan = getDataM(spr, getColumIndex(spr, "InchargePlan"), xRow)
            If getColumIndex(spr, "DateInsert") > -1 Then z4064.DateInsert = getDataM(spr, getColumIndex(spr, "DateInsert"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z4064.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "DateUpdate") > -1 Then z4064.DateUpdate = getDataM(spr, getColumIndex(spr, "DateUpdate"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z4064.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z4064.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4064_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K4064_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z4064 As T4064_AREA, CheckClear As Boolean, AUTOKEY As Double) As Boolean

        K4064_MOVE = False

        Try
            If READ_PFK4064(AUTOKEY) = True Then
                z4064 = D4064
                K4064_MOVE = True
            Else
                If CheckClear = True Then z4064 = Nothing
            End If

            If getColumIndex(spr, "Autokey") > -1 Then z4064.Autokey = getDataM(spr, getColumIndex(spr, "Autokey"), xRow)
            If getColumIndex(spr, "seMainProcess") > -1 Then z4064.seMainProcess = getDataM(spr, getColumIndex(spr, "seMainProcess"), xRow)
            If getColumIndex(spr, "cdMainProcess") > -1 Then z4064.cdMainProcess = getDataM(spr, getColumIndex(spr, "cdMainProcess"), xRow)
            If getColumIndex(spr, "JobCard") > -1 Then z4064.JobCard = getDataM(spr, getColumIndex(spr, "JobCard"), xRow)
            If getColumIndex(spr, "seFactory") > -1 Then z4064.seFactory = getDataM(spr, getColumIndex(spr, "seFactory"), xRow)
            If getColumIndex(spr, "cdFactory") > -1 Then z4064.cdFactory = getDataM(spr, getColumIndex(spr, "cdFactory"), xRow)
            If getColumIndex(spr, "CustomerCode") > -1 Then z4064.CustomerCode = getDataM(spr, getColumIndex(spr, "CustomerCode"), xRow)
            If getColumIndex(spr, "seLineProd") > -1 Then z4064.seLineProd = getDataM(spr, getColumIndex(spr, "seLineProd"), xRow)
            If getColumIndex(spr, "cdLineProd") > -1 Then z4064.cdLineProd = getDataM(spr, getColumIndex(spr, "cdLineProd"), xRow)
            If getColumIndex(spr, "MachineCode") > -1 Then z4064.MachineCode = getDataM(spr, getColumIndex(spr, "MachineCode"), xRow)
            If getColumIndex(spr, "DatePlan") > -1 Then z4064.DatePlan = getDataM(spr, getColumIndex(spr, "DatePlan"), xRow)
            If getColumIndex(spr, "DateFinish") > -1 Then z4064.DateFinish = getDataM(spr, getColumIndex(spr, "DateFinish"), xRow)
            If getColumIndex(spr, "Description") > -1 Then z4064.Description = getDataM(spr, getColumIndex(spr, "Description"), xRow)
            If getColumIndex(spr, "QtyPlan") > -1 Then z4064.QtyPlan = getDataM(spr, getColumIndex(spr, "QtyPlan"), xRow)
            If getColumIndex(spr, "QtyProd") > -1 Then z4064.QtyProd = getDataM(spr, getColumIndex(spr, "QtyProd"), xRow)
            If getColumIndex(spr, "InchargePlan") > -1 Then z4064.InchargePlan = getDataM(spr, getColumIndex(spr, "InchargePlan"), xRow)
            If getColumIndex(spr, "DateInsert") > -1 Then z4064.DateInsert = getDataM(spr, getColumIndex(spr, "DateInsert"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z4064.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "DateUpdate") > -1 Then z4064.DateUpdate = getDataM(spr, getColumIndex(spr, "DateUpdate"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z4064.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z4064.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4064_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K4064_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z4064 As T4064_AREA, Job As String, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K4064_MOVE = False

        Try
            If READ_PFK4064(AUTOKEY) = True Then
                z4064 = D4064
                K4064_MOVE = True
            Else
                z4064 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4064")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z4064.Autokey = Children(i).Code
                                Case "SEMAINPROCESS" : z4064.seMainProcess = Children(i).Code
                                Case "CDMAINPROCESS" : z4064.cdMainProcess = Children(i).Code
                                Case "JOBCARD" : z4064.JobCard = Children(i).Code
                                Case "SEFACTORY" : z4064.seFactory = Children(i).Code
                                Case "CDFACTORY" : z4064.cdFactory = Children(i).Code
                                Case "CUSTOMERCODE" : z4064.CustomerCode = Children(i).Code
                                Case "SELINEPROD" : z4064.seLineProd = Children(i).Code
                                Case "CDLINEPROD" : z4064.cdLineProd = Children(i).Code
                                Case "MACHINECODE" : z4064.MachineCode = Children(i).Code
                                Case "DATEPLAN" : z4064.DatePlan = Children(i).Code
                                Case "DATEFINISH" : z4064.DateFinish = Children(i).Code
                                Case "DESCRIPTION" : z4064.Description = Children(i).Code
                                Case "QTYPLAN" : z4064.QtyPlan = Children(i).Code
                                Case "QTYPROD" : z4064.QtyProd = Children(i).Code
                                Case "INCHARGEPLAN" : z4064.InchargePlan = Children(i).Code
                                Case "DATEINSERT" : z4064.DateInsert = Children(i).Code
                                Case "INCHARGEINSERT" : z4064.InchargeInsert = Children(i).Code
                                Case "DATEUPDATE" : z4064.DateUpdate = Children(i).Code
                                Case "INCHARGEUPDATE" : z4064.InchargeUpdate = Children(i).Code
                                Case "REMARK" : z4064.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z4064.Autokey = Children(i).Data
                                Case "SEMAINPROCESS" : z4064.seMainProcess = Children(i).Data
                                Case "CDMAINPROCESS" : z4064.cdMainProcess = Children(i).Data
                                Case "JOBCARD" : z4064.JobCard = Children(i).Data
                                Case "SEFACTORY" : z4064.seFactory = Children(i).Data
                                Case "CDFACTORY" : z4064.cdFactory = Children(i).Data
                                Case "CUSTOMERCODE" : z4064.CustomerCode = Children(i).Data
                                Case "SELINEPROD" : z4064.seLineProd = Children(i).Data
                                Case "CDLINEPROD" : z4064.cdLineProd = Children(i).Data
                                Case "MACHINECODE" : z4064.MachineCode = Children(i).Data
                                Case "DATEPLAN" : z4064.DatePlan = Children(i).Data
                                Case "DATEFINISH" : z4064.DateFinish = Children(i).Data
                                Case "DESCRIPTION" : z4064.Description = Children(i).Data
                                Case "QTYPLAN" : z4064.QtyPlan = Children(i).Data
                                Case "QTYPROD" : z4064.QtyProd = Children(i).Data
                                Case "INCHARGEPLAN" : z4064.InchargePlan = Children(i).Data
                                Case "DATEINSERT" : z4064.DateInsert = Children(i).Data
                                Case "INCHARGEINSERT" : z4064.InchargeInsert = Children(i).Data
                                Case "DATEUPDATE" : z4064.DateUpdate = Children(i).Data
                                Case "INCHARGEUPDATE" : z4064.InchargeUpdate = Children(i).Data
                                Case "REMARK" : z4064.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4064_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K4064_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z4064 As T4064_AREA, Job As String, CheckClear As Boolean, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K4064_MOVE = False

        Try
            If READ_PFK4064(AUTOKEY) = True Then
                z4064 = D4064
                K4064_MOVE = True
            Else
                If CheckClear = True Then z4064 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4064")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z4064.Autokey = Children(i).Code
                                Case "SEMAINPROCESS" : z4064.seMainProcess = Children(i).Code
                                Case "CDMAINPROCESS" : z4064.cdMainProcess = Children(i).Code
                                Case "JOBCARD" : z4064.JobCard = Children(i).Code
                                Case "SEFACTORY" : z4064.seFactory = Children(i).Code
                                Case "CDFACTORY" : z4064.cdFactory = Children(i).Code
                                Case "CUSTOMERCODE" : z4064.CustomerCode = Children(i).Code
                                Case "SELINEPROD" : z4064.seLineProd = Children(i).Code
                                Case "CDLINEPROD" : z4064.cdLineProd = Children(i).Code
                                Case "MACHINECODE" : z4064.MachineCode = Children(i).Code
                                Case "DATEPLAN" : z4064.DatePlan = Children(i).Code
                                Case "DATEFINISH" : z4064.DateFinish = Children(i).Code
                                Case "DESCRIPTION" : z4064.Description = Children(i).Code
                                Case "QTYPLAN" : z4064.QtyPlan = Children(i).Code
                                Case "QTYPROD" : z4064.QtyProd = Children(i).Code
                                Case "INCHARGEPLAN" : z4064.InchargePlan = Children(i).Code
                                Case "DATEINSERT" : z4064.DateInsert = Children(i).Code
                                Case "INCHARGEINSERT" : z4064.InchargeInsert = Children(i).Code
                                Case "DATEUPDATE" : z4064.DateUpdate = Children(i).Code
                                Case "INCHARGEUPDATE" : z4064.InchargeUpdate = Children(i).Code
                                Case "REMARK" : z4064.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z4064.Autokey = Children(i).Data
                                Case "SEMAINPROCESS" : z4064.seMainProcess = Children(i).Data
                                Case "CDMAINPROCESS" : z4064.cdMainProcess = Children(i).Data
                                Case "JOBCARD" : z4064.JobCard = Children(i).Data
                                Case "SEFACTORY" : z4064.seFactory = Children(i).Data
                                Case "CDFACTORY" : z4064.cdFactory = Children(i).Data
                                Case "CUSTOMERCODE" : z4064.CustomerCode = Children(i).Data
                                Case "SELINEPROD" : z4064.seLineProd = Children(i).Data
                                Case "CDLINEPROD" : z4064.cdLineProd = Children(i).Data
                                Case "MACHINECODE" : z4064.MachineCode = Children(i).Data
                                Case "DATEPLAN" : z4064.DatePlan = Children(i).Data
                                Case "DATEFINISH" : z4064.DateFinish = Children(i).Data
                                Case "DESCRIPTION" : z4064.Description = Children(i).Data
                                Case "QTYPLAN" : z4064.QtyPlan = Children(i).Data
                                Case "QTYPROD" : z4064.QtyProd = Children(i).Data
                                Case "INCHARGEPLAN" : z4064.InchargePlan = Children(i).Data
                                Case "DATEINSERT" : z4064.DateInsert = Children(i).Data
                                Case "INCHARGEINSERT" : z4064.InchargeInsert = Children(i).Data
                                Case "DATEUPDATE" : z4064.DateUpdate = Children(i).Data
                                Case "INCHARGEUPDATE" : z4064.InchargeUpdate = Children(i).Data
                                Case "REMARK" : z4064.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4064_MOVE", vbCritical)
        End Try
    End Function

End Module
