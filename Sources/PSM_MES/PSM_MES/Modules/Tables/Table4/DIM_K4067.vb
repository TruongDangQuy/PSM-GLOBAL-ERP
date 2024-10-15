'=========================================================================================================================================================
'   TABLE : (PFK4067)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K4067

Structure T4067_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	Autokey	 AS Double	'			decimal		*
Public 	seMainProcess	 AS String	'			char(3)
Public 	cdMainProcess	 AS String	'			char(3)
Public 	SealMaster	 AS String	'			char(10)
Public 	seFactory	 AS String	'			char(3)
Public 	cdFactory	 AS String	'			char(3)
Public 	CustomerCode	 AS String	'			char(6)
Public 	seLineProd	 AS String	'			char(3)
Public 	cdLineProd	 AS String	'			char(3)
Public 	MachineCode	 AS String	'			char(6)
Public 	DatePlan	 AS String	'			char(8)
Public 	DateFinish	 AS String	'			char(8)
Public 	Description	 AS String	'			nvarchar(50)
Public 	QtyPlan	 AS Double	'			decimal
Public 	QtyProd	 AS Double	'			decimal
        Public QtyVariance As Double  '			decimal
        Public ISUD As String  '			char(1)
        Public InchargePlan As String  '			char(8)
        Public DateInsert As String  '			char(8)
        Public InchargeInsert As String  '			char(8)
        Public DateUpdate As String  '			char(8)
        Public InchargeUpdate As String  '			char(8)
        Public Remark As String  '			nvarchar(50)
        '=========================================================================================================================================================
    End Structure

    Public D4067 As T4067_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK4067(AUTOKEY As Double) As Boolean
        READ_PFK4067 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4067 "
            SQL = SQL & " WHERE K4067_Autokey		 =  " & Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4067_CLEAR() : GoTo SKIP_READ_PFK4067

            Call K4067_MOVE(rd)
            READ_PFK4067 = True

SKIP_READ_PFK4067:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4067", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK4067(AUTOKEY As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4067 "
            SQL = SQL & " WHERE K4067_Autokey		 =  " & Autokey & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK4067", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK4067(z4067 As T4067_AREA) As Boolean
        WRITE_PFK4067 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z4067)

            SQL = " INSERT INTO PFK4067 "
            SQL = SQL & " ( "
            SQL = SQL & " K4067_seMainProcess,"
            SQL = SQL & " K4067_cdMainProcess,"
            SQL = SQL & " K4067_SealMaster,"
            SQL = SQL & " K4067_seFactory,"
            SQL = SQL & " K4067_cdFactory,"
            SQL = SQL & " K4067_CustomerCode,"
            SQL = SQL & " K4067_seLineProd,"
            SQL = SQL & " K4067_cdLineProd,"
            SQL = SQL & " K4067_MachineCode,"
            SQL = SQL & " K4067_DatePlan,"
            SQL = SQL & " K4067_DateFinish,"
            SQL = SQL & " K4067_Description,"
            SQL = SQL & " K4067_QtyPlan,"
            SQL = SQL & " K4067_QtyProd,"
            SQL = SQL & " K4067_QtyVariance,"
            SQL = SQL & " K4067_ISUD,"
            SQL = SQL & " K4067_InchargePlan,"
            SQL = SQL & " K4067_DateInsert,"
            SQL = SQL & " K4067_InchargeInsert,"
            SQL = SQL & " K4067_DateUpdate,"
            SQL = SQL & " K4067_InchargeUpdate,"
            SQL = SQL & " K4067_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z4067.seMainProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4067.cdMainProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4067.SealMaster) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4067.seFactory) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4067.cdFactory) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4067.CustomerCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4067.seLineProd) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4067.cdLineProd) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4067.MachineCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4067.DatePlan) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4067.DateFinish) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4067.Description) & "', "
            SQL = SQL & "   " & FormatSQL(z4067.QtyPlan) & ", "
            SQL = SQL & "   " & FormatSQL(z4067.QtyProd) & ", "
            SQL = SQL & "   " & FormatSQL(z4067.QtyVariance) & ", "
            SQL = SQL & "  N'" & FormatSQL(z4067.ISUD) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4067.InchargePlan) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4067.DateInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4067.InchargeInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4067.DateUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4067.InchargeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4067.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK4067 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK4067", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK4067(z4067 As T4067_AREA) As Boolean
        REWRITE_PFK4067 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z4067)

            SQL = " UPDATE PFK4067 SET "
            SQL = SQL & "    K4067_seMainProcess      = N'" & FormatSQL(z4067.seMainProcess) & "', "
            SQL = SQL & "    K4067_cdMainProcess      = N'" & FormatSQL(z4067.cdMainProcess) & "', "
            SQL = SQL & "    K4067_SealMaster      = N'" & FormatSQL(z4067.SealMaster) & "', "
            SQL = SQL & "    K4067_seFactory      = N'" & FormatSQL(z4067.seFactory) & "', "
            SQL = SQL & "    K4067_cdFactory      = N'" & FormatSQL(z4067.cdFactory) & "', "
            SQL = SQL & "    K4067_CustomerCode      = N'" & FormatSQL(z4067.CustomerCode) & "', "
            SQL = SQL & "    K4067_seLineProd      = N'" & FormatSQL(z4067.seLineProd) & "', "
            SQL = SQL & "    K4067_cdLineProd      = N'" & FormatSQL(z4067.cdLineProd) & "', "
            SQL = SQL & "    K4067_MachineCode      = N'" & FormatSQL(z4067.MachineCode) & "', "
            SQL = SQL & "    K4067_DatePlan      = N'" & FormatSQL(z4067.DatePlan) & "', "
            SQL = SQL & "    K4067_DateFinish      = N'" & FormatSQL(z4067.DateFinish) & "', "
            SQL = SQL & "    K4067_Description      = N'" & FormatSQL(z4067.Description) & "', "
            SQL = SQL & "    K4067_QtyPlan      =  " & FormatSQL(z4067.QtyPlan) & ", "
            SQL = SQL & "    K4067_QtyProd      =  " & FormatSQL(z4067.QtyProd) & ", "
            SQL = SQL & "    K4067_QtyVariance      =  " & FormatSQL(z4067.QtyVariance) & ", "
            SQL = SQL & "    K4067_ISUD      = N'" & FormatSQL(z4067.ISUD) & "', "
            SQL = SQL & "    K4067_InchargePlan      = N'" & FormatSQL(z4067.InchargePlan) & "', "
            SQL = SQL & "    K4067_DateInsert      = N'" & FormatSQL(z4067.DateInsert) & "', "
            SQL = SQL & "    K4067_InchargeInsert      = N'" & FormatSQL(z4067.InchargeInsert) & "', "
            SQL = SQL & "    K4067_DateUpdate      = N'" & FormatSQL(z4067.DateUpdate) & "', "
            SQL = SQL & "    K4067_InchargeUpdate      = N'" & FormatSQL(z4067.InchargeUpdate) & "', "
            SQL = SQL & "    K4067_Remark      = N'" & FormatSQL(z4067.Remark) & "'  "
            SQL = SQL & " WHERE K4067_Autokey		 =  " & z4067.Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK4067 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK4067", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK4067(z4067 As T4067_AREA) As Boolean
        DELETE_PFK4067 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK4067 "
            SQL = SQL & " WHERE K4067_Autokey		 =  " & z4067.Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK4067 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK4067", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D4067_CLEAR()
        Try

            D4067.Autokey = 0
            D4067.seMainProcess = ""
            D4067.cdMainProcess = ""
            D4067.SealMaster = ""
            D4067.seFactory = ""
            D4067.cdFactory = ""
            D4067.CustomerCode = ""
            D4067.seLineProd = ""
            D4067.cdLineProd = ""
            D4067.MachineCode = ""
            D4067.DatePlan = ""
            D4067.DateFinish = ""
            D4067.Description = ""
            D4067.QtyPlan = 0
            D4067.QtyProd = 0
            D4067.QtyVariance = 0
            D4067.ISUD = ""
            D4067.InchargePlan = ""
            D4067.DateInsert = ""
            D4067.InchargeInsert = ""
            D4067.DateUpdate = ""
            D4067.InchargeUpdate = ""
            D4067.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D4067_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x4067 As T4067_AREA)
        Try

            x4067.Autokey = trim$(x4067.Autokey)
            x4067.seMainProcess = trim$(x4067.seMainProcess)
            x4067.cdMainProcess = trim$(x4067.cdMainProcess)
            x4067.SealMaster = trim$(x4067.SealMaster)
            x4067.seFactory = trim$(x4067.seFactory)
            x4067.cdFactory = trim$(x4067.cdFactory)
            x4067.CustomerCode = trim$(x4067.CustomerCode)
            x4067.seLineProd = trim$(x4067.seLineProd)
            x4067.cdLineProd = trim$(x4067.cdLineProd)
            x4067.MachineCode = trim$(x4067.MachineCode)
            x4067.DatePlan = trim$(x4067.DatePlan)
            x4067.DateFinish = trim$(x4067.DateFinish)
            x4067.Description = trim$(x4067.Description)
            x4067.QtyPlan = trim$(x4067.QtyPlan)
            x4067.QtyProd = trim$(x4067.QtyProd)
            x4067.QtyVariance = trim$(x4067.QtyVariance)
            x4067.ISUD = trim$(x4067.ISUD)
            x4067.InchargePlan = trim$(x4067.InchargePlan)
            x4067.DateInsert = trim$(x4067.DateInsert)
            x4067.InchargeInsert = trim$(x4067.InchargeInsert)
            x4067.DateUpdate = trim$(x4067.DateUpdate)
            x4067.InchargeUpdate = trim$(x4067.InchargeUpdate)
            x4067.Remark = trim$(x4067.Remark)

            If trim$(x4067.Autokey) = "" Then x4067.Autokey = 0
            If trim$(x4067.seMainProcess) = "" Then x4067.seMainProcess = Space(1)
            If trim$(x4067.cdMainProcess) = "" Then x4067.cdMainProcess = Space(1)
            If trim$(x4067.SealMaster) = "" Then x4067.SealMaster = Space(1)
            If trim$(x4067.seFactory) = "" Then x4067.seFactory = Space(1)
            If trim$(x4067.cdFactory) = "" Then x4067.cdFactory = Space(1)
            If trim$(x4067.CustomerCode) = "" Then x4067.CustomerCode = Space(1)
            If trim$(x4067.seLineProd) = "" Then x4067.seLineProd = Space(1)
            If trim$(x4067.cdLineProd) = "" Then x4067.cdLineProd = Space(1)
            If trim$(x4067.MachineCode) = "" Then x4067.MachineCode = Space(1)
            If trim$(x4067.DatePlan) = "" Then x4067.DatePlan = Space(1)
            If trim$(x4067.DateFinish) = "" Then x4067.DateFinish = Space(1)
            If trim$(x4067.Description) = "" Then x4067.Description = Space(1)
            If trim$(x4067.QtyPlan) = "" Then x4067.QtyPlan = 0
            If trim$(x4067.QtyProd) = "" Then x4067.QtyProd = 0
            If trim$(x4067.QtyVariance) = "" Then x4067.QtyVariance = 0
            If trim$(x4067.ISUD) = "" Then x4067.ISUD = Space(1)
            If trim$(x4067.InchargePlan) = "" Then x4067.InchargePlan = Space(1)
            If trim$(x4067.DateInsert) = "" Then x4067.DateInsert = Space(1)
            If trim$(x4067.InchargeInsert) = "" Then x4067.InchargeInsert = Space(1)
            If trim$(x4067.DateUpdate) = "" Then x4067.DateUpdate = Space(1)
            If trim$(x4067.InchargeUpdate) = "" Then x4067.InchargeUpdate = Space(1)
            If trim$(x4067.Remark) = "" Then x4067.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K4067_MOVE(rs4067 As SqlClient.SqlDataReader)
        Try

            Call D4067_CLEAR()

            If IsdbNull(rs4067!K4067_Autokey) = False Then D4067.Autokey = Trim$(rs4067!K4067_Autokey)
            If IsdbNull(rs4067!K4067_seMainProcess) = False Then D4067.seMainProcess = Trim$(rs4067!K4067_seMainProcess)
            If IsdbNull(rs4067!K4067_cdMainProcess) = False Then D4067.cdMainProcess = Trim$(rs4067!K4067_cdMainProcess)
            If IsdbNull(rs4067!K4067_SealMaster) = False Then D4067.SealMaster = Trim$(rs4067!K4067_SealMaster)
            If IsdbNull(rs4067!K4067_seFactory) = False Then D4067.seFactory = Trim$(rs4067!K4067_seFactory)
            If IsdbNull(rs4067!K4067_cdFactory) = False Then D4067.cdFactory = Trim$(rs4067!K4067_cdFactory)
            If IsdbNull(rs4067!K4067_CustomerCode) = False Then D4067.CustomerCode = Trim$(rs4067!K4067_CustomerCode)
            If IsdbNull(rs4067!K4067_seLineProd) = False Then D4067.seLineProd = Trim$(rs4067!K4067_seLineProd)
            If IsdbNull(rs4067!K4067_cdLineProd) = False Then D4067.cdLineProd = Trim$(rs4067!K4067_cdLineProd)
            If IsdbNull(rs4067!K4067_MachineCode) = False Then D4067.MachineCode = Trim$(rs4067!K4067_MachineCode)
            If IsdbNull(rs4067!K4067_DatePlan) = False Then D4067.DatePlan = Trim$(rs4067!K4067_DatePlan)
            If IsdbNull(rs4067!K4067_DateFinish) = False Then D4067.DateFinish = Trim$(rs4067!K4067_DateFinish)
            If IsdbNull(rs4067!K4067_Description) = False Then D4067.Description = Trim$(rs4067!K4067_Description)
            If IsdbNull(rs4067!K4067_QtyPlan) = False Then D4067.QtyPlan = Trim$(rs4067!K4067_QtyPlan)
            If IsdbNull(rs4067!K4067_QtyProd) = False Then D4067.QtyProd = Trim$(rs4067!K4067_QtyProd)
            If IsdbNull(rs4067!K4067_QtyVariance) = False Then D4067.QtyVariance = Trim$(rs4067!K4067_QtyVariance)
            If IsdbNull(rs4067!K4067_ISUD) = False Then D4067.ISUD = Trim$(rs4067!K4067_ISUD)
            If IsdbNull(rs4067!K4067_InchargePlan) = False Then D4067.InchargePlan = Trim$(rs4067!K4067_InchargePlan)
            If IsdbNull(rs4067!K4067_DateInsert) = False Then D4067.DateInsert = Trim$(rs4067!K4067_DateInsert)
            If IsdbNull(rs4067!K4067_InchargeInsert) = False Then D4067.InchargeInsert = Trim$(rs4067!K4067_InchargeInsert)
            If IsdbNull(rs4067!K4067_DateUpdate) = False Then D4067.DateUpdate = Trim$(rs4067!K4067_DateUpdate)
            If IsdbNull(rs4067!K4067_InchargeUpdate) = False Then D4067.InchargeUpdate = Trim$(rs4067!K4067_InchargeUpdate)
            If IsdbNull(rs4067!K4067_Remark) = False Then D4067.Remark = Trim$(rs4067!K4067_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K4067_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K4067_MOVE(rs4067 As DataRow)
        Try

            Call D4067_CLEAR()

            If IsdbNull(rs4067!K4067_Autokey) = False Then D4067.Autokey = Trim$(rs4067!K4067_Autokey)
            If IsdbNull(rs4067!K4067_seMainProcess) = False Then D4067.seMainProcess = Trim$(rs4067!K4067_seMainProcess)
            If IsdbNull(rs4067!K4067_cdMainProcess) = False Then D4067.cdMainProcess = Trim$(rs4067!K4067_cdMainProcess)
            If IsdbNull(rs4067!K4067_SealMaster) = False Then D4067.SealMaster = Trim$(rs4067!K4067_SealMaster)
            If IsdbNull(rs4067!K4067_seFactory) = False Then D4067.seFactory = Trim$(rs4067!K4067_seFactory)
            If IsdbNull(rs4067!K4067_cdFactory) = False Then D4067.cdFactory = Trim$(rs4067!K4067_cdFactory)
            If IsdbNull(rs4067!K4067_CustomerCode) = False Then D4067.CustomerCode = Trim$(rs4067!K4067_CustomerCode)
            If IsdbNull(rs4067!K4067_seLineProd) = False Then D4067.seLineProd = Trim$(rs4067!K4067_seLineProd)
            If IsdbNull(rs4067!K4067_cdLineProd) = False Then D4067.cdLineProd = Trim$(rs4067!K4067_cdLineProd)
            If IsdbNull(rs4067!K4067_MachineCode) = False Then D4067.MachineCode = Trim$(rs4067!K4067_MachineCode)
            If IsdbNull(rs4067!K4067_DatePlan) = False Then D4067.DatePlan = Trim$(rs4067!K4067_DatePlan)
            If IsdbNull(rs4067!K4067_DateFinish) = False Then D4067.DateFinish = Trim$(rs4067!K4067_DateFinish)
            If IsdbNull(rs4067!K4067_Description) = False Then D4067.Description = Trim$(rs4067!K4067_Description)
            If IsdbNull(rs4067!K4067_QtyPlan) = False Then D4067.QtyPlan = Trim$(rs4067!K4067_QtyPlan)
            If IsdbNull(rs4067!K4067_QtyProd) = False Then D4067.QtyProd = Trim$(rs4067!K4067_QtyProd)
            If IsdbNull(rs4067!K4067_QtyVariance) = False Then D4067.QtyVariance = Trim$(rs4067!K4067_QtyVariance)
            If IsdbNull(rs4067!K4067_ISUD) = False Then D4067.ISUD = Trim$(rs4067!K4067_ISUD)
            If IsdbNull(rs4067!K4067_InchargePlan) = False Then D4067.InchargePlan = Trim$(rs4067!K4067_InchargePlan)
            If IsdbNull(rs4067!K4067_DateInsert) = False Then D4067.DateInsert = Trim$(rs4067!K4067_DateInsert)
            If IsdbNull(rs4067!K4067_InchargeInsert) = False Then D4067.InchargeInsert = Trim$(rs4067!K4067_InchargeInsert)
            If IsdbNull(rs4067!K4067_DateUpdate) = False Then D4067.DateUpdate = Trim$(rs4067!K4067_DateUpdate)
            If IsdbNull(rs4067!K4067_InchargeUpdate) = False Then D4067.InchargeUpdate = Trim$(rs4067!K4067_InchargeUpdate)
            If IsdbNull(rs4067!K4067_Remark) = False Then D4067.Remark = Trim$(rs4067!K4067_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K4067_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K4067_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z4067 As T4067_AREA, AUTOKEY As Double) As Boolean

        K4067_MOVE = False

        Try
            If READ_PFK4067(AUTOKEY) = True Then
                z4067 = D4067
                K4067_MOVE = True
            Else
                z4067 = Nothing
            End If

            If getColumIndex(spr, "Autokey") > -1 Then z4067.Autokey = getDataM(spr, getColumIndex(spr, "Autokey"), xRow)
            If getColumIndex(spr, "seMainProcess") > -1 Then z4067.seMainProcess = getDataM(spr, getColumIndex(spr, "seMainProcess"), xRow)
            If getColumIndex(spr, "cdMainProcess") > -1 Then z4067.cdMainProcess = getDataM(spr, getColumIndex(spr, "cdMainProcess"), xRow)
            If getColumIndex(spr, "SealMaster") > -1 Then z4067.SealMaster = getDataM(spr, getColumIndex(spr, "SealMaster"), xRow)
            If getColumIndex(spr, "seFactory") > -1 Then z4067.seFactory = getDataM(spr, getColumIndex(spr, "seFactory"), xRow)
            If getColumIndex(spr, "cdFactory") > -1 Then z4067.cdFactory = getDataM(spr, getColumIndex(spr, "cdFactory"), xRow)
            If getColumIndex(spr, "CustomerCode") > -1 Then z4067.CustomerCode = getDataM(spr, getColumIndex(spr, "CustomerCode"), xRow)
            If getColumIndex(spr, "seLineProd") > -1 Then z4067.seLineProd = getDataM(spr, getColumIndex(spr, "seLineProd"), xRow)
            If getColumIndex(spr, "cdLineProd") > -1 Then z4067.cdLineProd = getDataM(spr, getColumIndex(spr, "cdLineProd"), xRow)
            If getColumIndex(spr, "MachineCode") > -1 Then z4067.MachineCode = getDataM(spr, getColumIndex(spr, "MachineCode"), xRow)
            If getColumIndex(spr, "DatePlan") > -1 Then z4067.DatePlan = getDataM(spr, getColumIndex(spr, "DatePlan"), xRow)
            If getColumIndex(spr, "DateFinish") > -1 Then z4067.DateFinish = getDataM(spr, getColumIndex(spr, "DateFinish"), xRow)
            If getColumIndex(spr, "Description") > -1 Then z4067.Description = getDataM(spr, getColumIndex(spr, "Description"), xRow)
            If getColumIndex(spr, "QtyPlan") > -1 Then z4067.QtyPlan = getDataM(spr, getColumIndex(spr, "QtyPlan"), xRow)
            If getColumIndex(spr, "QtyProd") > -1 Then z4067.QtyProd = getDataM(spr, getColumIndex(spr, "QtyProd"), xRow)
            If getColumIndex(spr, "QtyVariance") > -1 Then z4067.QtyVariance = getDataM(spr, getColumIndex(spr, "QtyVariance"), xRow)
            If getColumIndex(spr, "ISUD") > -1 Then z4067.ISUD = getDataM(spr, getColumIndex(spr, "ISUD"), xRow)
            If getColumIndex(spr, "InchargePlan") > -1 Then z4067.InchargePlan = getDataM(spr, getColumIndex(spr, "InchargePlan"), xRow)
            If getColumIndex(spr, "DateInsert") > -1 Then z4067.DateInsert = getDataM(spr, getColumIndex(spr, "DateInsert"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z4067.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "DateUpdate") > -1 Then z4067.DateUpdate = getDataM(spr, getColumIndex(spr, "DateUpdate"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z4067.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z4067.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4067_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K4067_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z4067 As T4067_AREA, CheckClear As Boolean, AUTOKEY As Double) As Boolean

        K4067_MOVE = False

        Try
            If READ_PFK4067(AUTOKEY) = True Then
                z4067 = D4067
                K4067_MOVE = True
            Else
                If CheckClear = True Then z4067 = Nothing
            End If

            If getColumIndex(spr, "Autokey") > -1 Then z4067.Autokey = getDataM(spr, getColumIndex(spr, "Autokey"), xRow)
            If getColumIndex(spr, "seMainProcess") > -1 Then z4067.seMainProcess = getDataM(spr, getColumIndex(spr, "seMainProcess"), xRow)
            If getColumIndex(spr, "cdMainProcess") > -1 Then z4067.cdMainProcess = getDataM(spr, getColumIndex(spr, "cdMainProcess"), xRow)
            If getColumIndex(spr, "SealMaster") > -1 Then z4067.SealMaster = getDataM(spr, getColumIndex(spr, "SealMaster"), xRow)
            If getColumIndex(spr, "seFactory") > -1 Then z4067.seFactory = getDataM(spr, getColumIndex(spr, "seFactory"), xRow)
            If getColumIndex(spr, "cdFactory") > -1 Then z4067.cdFactory = getDataM(spr, getColumIndex(spr, "cdFactory"), xRow)
            If getColumIndex(spr, "CustomerCode") > -1 Then z4067.CustomerCode = getDataM(spr, getColumIndex(spr, "CustomerCode"), xRow)
            If getColumIndex(spr, "seLineProd") > -1 Then z4067.seLineProd = getDataM(spr, getColumIndex(spr, "seLineProd"), xRow)
            If getColumIndex(spr, "cdLineProd") > -1 Then z4067.cdLineProd = getDataM(spr, getColumIndex(spr, "cdLineProd"), xRow)
            If getColumIndex(spr, "MachineCode") > -1 Then z4067.MachineCode = getDataM(spr, getColumIndex(spr, "MachineCode"), xRow)
            If getColumIndex(spr, "DatePlan") > -1 Then z4067.DatePlan = getDataM(spr, getColumIndex(spr, "DatePlan"), xRow)
            If getColumIndex(spr, "DateFinish") > -1 Then z4067.DateFinish = getDataM(spr, getColumIndex(spr, "DateFinish"), xRow)
            If getColumIndex(spr, "Description") > -1 Then z4067.Description = getDataM(spr, getColumIndex(spr, "Description"), xRow)
            If getColumIndex(spr, "QtyPlan") > -1 Then z4067.QtyPlan = getDataM(spr, getColumIndex(spr, "QtyPlan"), xRow)
            If getColumIndex(spr, "QtyProd") > -1 Then z4067.QtyProd = getDataM(spr, getColumIndex(spr, "QtyProd"), xRow)
            If getColumIndex(spr, "QtyVariance") > -1 Then z4067.QtyVariance = getDataM(spr, getColumIndex(spr, "QtyVariance"), xRow)
            If getColumIndex(spr, "ISUD") > -1 Then z4067.ISUD = getDataM(spr, getColumIndex(spr, "ISUD"), xRow)
            If getColumIndex(spr, "InchargePlan") > -1 Then z4067.InchargePlan = getDataM(spr, getColumIndex(spr, "InchargePlan"), xRow)
            If getColumIndex(spr, "DateInsert") > -1 Then z4067.DateInsert = getDataM(spr, getColumIndex(spr, "DateInsert"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z4067.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "DateUpdate") > -1 Then z4067.DateUpdate = getDataM(spr, getColumIndex(spr, "DateUpdate"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z4067.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z4067.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4067_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K4067_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z4067 As T4067_AREA, Job As String, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K4067_MOVE = False

        Try
            If READ_PFK4067(AUTOKEY) = True Then
                z4067 = D4067
                K4067_MOVE = True
            Else
                z4067 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4067")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z4067.Autokey = Children(i).Code
                                Case "SEMAINPROCESS" : z4067.seMainProcess = Children(i).Code
                                Case "CDMAINPROCESS" : z4067.cdMainProcess = Children(i).Code
                                Case "SEALMASTER" : z4067.SealMaster = Children(i).Code
                                Case "SEFACTORY" : z4067.seFactory = Children(i).Code
                                Case "CDFACTORY" : z4067.cdFactory = Children(i).Code
                                Case "CUSTOMERCODE" : z4067.CustomerCode = Children(i).Code
                                Case "SELINEPROD" : z4067.seLineProd = Children(i).Code
                                Case "CDLINEPROD" : z4067.cdLineProd = Children(i).Code
                                Case "MACHINECODE" : z4067.MachineCode = Children(i).Code
                                Case "DATEPLAN" : z4067.DatePlan = Children(i).Code
                                Case "DATEFINISH" : z4067.DateFinish = Children(i).Code
                                Case "DESCRIPTION" : z4067.Description = Children(i).Code
                                Case "QTYPLAN" : z4067.QtyPlan = Children(i).Code
                                Case "QTYPROD" : z4067.QtyProd = Children(i).Code
                                Case "QTYVARIANCE" : z4067.QtyVariance = Children(i).Code
                                Case "ISUD" : z4067.ISUD = Children(i).Code
                                Case "INCHARGEPLAN" : z4067.InchargePlan = Children(i).Code
                                Case "DATEINSERT" : z4067.DateInsert = Children(i).Code
                                Case "INCHARGEINSERT" : z4067.InchargeInsert = Children(i).Code
                                Case "DATEUPDATE" : z4067.DateUpdate = Children(i).Code
                                Case "INCHARGEUPDATE" : z4067.InchargeUpdate = Children(i).Code
                                Case "REMARK" : z4067.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z4067.Autokey = Children(i).Data
                                Case "SEMAINPROCESS" : z4067.seMainProcess = Children(i).Data
                                Case "CDMAINPROCESS" : z4067.cdMainProcess = Children(i).Data
                                Case "SEALMASTER" : z4067.SealMaster = Children(i).Data
                                Case "SEFACTORY" : z4067.seFactory = Children(i).Data
                                Case "CDFACTORY" : z4067.cdFactory = Children(i).Data
                                Case "CUSTOMERCODE" : z4067.CustomerCode = Children(i).Data
                                Case "SELINEPROD" : z4067.seLineProd = Children(i).Data
                                Case "CDLINEPROD" : z4067.cdLineProd = Children(i).Data
                                Case "MACHINECODE" : z4067.MachineCode = Children(i).Data
                                Case "DATEPLAN" : z4067.DatePlan = Children(i).Data
                                Case "DATEFINISH" : z4067.DateFinish = Children(i).Data
                                Case "DESCRIPTION" : z4067.Description = Children(i).Data
                                Case "QTYPLAN" : z4067.QtyPlan = Children(i).Data
                                Case "QTYPROD" : z4067.QtyProd = Children(i).Data
                                Case "QTYVARIANCE" : z4067.QtyVariance = Children(i).Data
                                Case "ISUD" : z4067.ISUD = Children(i).Data
                                Case "INCHARGEPLAN" : z4067.InchargePlan = Children(i).Data
                                Case "DATEINSERT" : z4067.DateInsert = Children(i).Data
                                Case "INCHARGEINSERT" : z4067.InchargeInsert = Children(i).Data
                                Case "DATEUPDATE" : z4067.DateUpdate = Children(i).Data
                                Case "INCHARGEUPDATE" : z4067.InchargeUpdate = Children(i).Data
                                Case "REMARK" : z4067.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4067_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K4067_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z4067 As T4067_AREA, Job As String, CheckClear As Boolean, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K4067_MOVE = False

        Try
            If READ_PFK4067(AUTOKEY) = True Then
                z4067 = D4067
                K4067_MOVE = True
            Else
                If CheckClear = True Then z4067 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4067")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z4067.Autokey = Children(i).Code
                                Case "SEMAINPROCESS" : z4067.seMainProcess = Children(i).Code
                                Case "CDMAINPROCESS" : z4067.cdMainProcess = Children(i).Code
                                Case "SEALMASTER" : z4067.SealMaster = Children(i).Code
                                Case "SEFACTORY" : z4067.seFactory = Children(i).Code
                                Case "CDFACTORY" : z4067.cdFactory = Children(i).Code
                                Case "CUSTOMERCODE" : z4067.CustomerCode = Children(i).Code
                                Case "SELINEPROD" : z4067.seLineProd = Children(i).Code
                                Case "CDLINEPROD" : z4067.cdLineProd = Children(i).Code
                                Case "MACHINECODE" : z4067.MachineCode = Children(i).Code
                                Case "DATEPLAN" : z4067.DatePlan = Children(i).Code
                                Case "DATEFINISH" : z4067.DateFinish = Children(i).Code
                                Case "DESCRIPTION" : z4067.Description = Children(i).Code
                                Case "QTYPLAN" : z4067.QtyPlan = Children(i).Code
                                Case "QTYPROD" : z4067.QtyProd = Children(i).Code
                                Case "QTYVARIANCE" : z4067.QtyVariance = Children(i).Code
                                Case "ISUD" : z4067.ISUD = Children(i).Code
                                Case "INCHARGEPLAN" : z4067.InchargePlan = Children(i).Code
                                Case "DATEINSERT" : z4067.DateInsert = Children(i).Code
                                Case "INCHARGEINSERT" : z4067.InchargeInsert = Children(i).Code
                                Case "DATEUPDATE" : z4067.DateUpdate = Children(i).Code
                                Case "INCHARGEUPDATE" : z4067.InchargeUpdate = Children(i).Code
                                Case "REMARK" : z4067.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z4067.Autokey = Children(i).Data
                                Case "SEMAINPROCESS" : z4067.seMainProcess = Children(i).Data
                                Case "CDMAINPROCESS" : z4067.cdMainProcess = Children(i).Data
                                Case "SEALMASTER" : z4067.SealMaster = Children(i).Data
                                Case "SEFACTORY" : z4067.seFactory = Children(i).Data
                                Case "CDFACTORY" : z4067.cdFactory = Children(i).Data
                                Case "CUSTOMERCODE" : z4067.CustomerCode = Children(i).Data
                                Case "SELINEPROD" : z4067.seLineProd = Children(i).Data
                                Case "CDLINEPROD" : z4067.cdLineProd = Children(i).Data
                                Case "MACHINECODE" : z4067.MachineCode = Children(i).Data
                                Case "DATEPLAN" : z4067.DatePlan = Children(i).Data
                                Case "DATEFINISH" : z4067.DateFinish = Children(i).Data
                                Case "DESCRIPTION" : z4067.Description = Children(i).Data
                                Case "QTYPLAN" : z4067.QtyPlan = Children(i).Data
                                Case "QTYPROD" : z4067.QtyProd = Children(i).Data
                                Case "QTYVARIANCE" : z4067.QtyVariance = Children(i).Data
                                Case "ISUD" : z4067.ISUD = Children(i).Data
   Case "INCHARGEPLAN":z4067.InchargePlan = Children(i).Data
   Case "DATEINSERT":z4067.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z4067.InchargeInsert = Children(i).Data
   Case "DATEUPDATE":z4067.DateUpdate = Children(i).Data
   Case "INCHARGEUPDATE":z4067.InchargeUpdate = Children(i).Data
   Case "REMARK":z4067.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4067_MOVE",vbCritical)
End Try
End Function 
    
End Module 
