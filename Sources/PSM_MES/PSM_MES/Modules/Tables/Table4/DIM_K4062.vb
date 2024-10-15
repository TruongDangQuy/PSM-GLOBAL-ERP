'=========================================================================================================================================================
'   TABLE : (PFK4062)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K4062

    Structure T4062_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public Autokey As Double  '			decimal		*
        Public seMainProcess As String  '			char(3)
        Public cdMainProcess As String  '			char(3)
        Public JobCard As String  '			char(9)
        Public MaterialCode As String  '			char(6)
        Public ToolCode As String  '			char(8)
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

    Public D4062 As T4062_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK4062(AUTOKEY As Double) As Boolean
        READ_PFK4062 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4062 "
            SQL = SQL & " WHERE K4062_Autokey		 =  " & Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4062_CLEAR() : GoTo SKIP_READ_PFK4062

            Call K4062_MOVE(rd)
            READ_PFK4062 = True

SKIP_READ_PFK4062:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4062", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK4062(AUTOKEY As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4062 "
            SQL = SQL & " WHERE K4062_Autokey		 =  " & Autokey & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK4062", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK4062(z4062 As T4062_AREA) As Boolean
        WRITE_PFK4062 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z4062)

            SQL = " INSERT INTO PFK4062 "
            SQL = SQL & " ( "
            SQL = SQL & " K4062_seMainProcess,"
            SQL = SQL & " K4062_cdMainProcess,"
            SQL = SQL & " K4062_JobCard,"
            SQL = SQL & " K4062_MaterialCode,"
            SQL = SQL & " K4062_ToolCode,"
            SQL = SQL & " K4062_DatePlan,"
            SQL = SQL & " K4062_DateFinish,"
            SQL = SQL & " K4062_Description,"
            SQL = SQL & " K4062_QtyPlan,"
            SQL = SQL & " K4062_QtyProd,"
            SQL = SQL & " K4062_InchargePlan,"
            SQL = SQL & " K4062_DateInsert,"
            SQL = SQL & " K4062_InchargeInsert,"
            SQL = SQL & " K4062_DateUpdate,"
            SQL = SQL & " K4062_InchargeUpdate,"
            SQL = SQL & " K4062_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z4062.seMainProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4062.cdMainProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4062.JobCard) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4062.MaterialCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4062.ToolCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4062.DatePlan) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4062.DateFinish) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4062.Description) & "', "
            SQL = SQL & "   " & FormatSQL(z4062.QtyPlan) & ", "
            SQL = SQL & "   " & FormatSQL(z4062.QtyProd) & ", "
            SQL = SQL & "  N'" & FormatSQL(z4062.InchargePlan) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4062.DateInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4062.InchargeInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4062.DateUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4062.InchargeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4062.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK4062 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK4062", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK4062(z4062 As T4062_AREA) As Boolean
        REWRITE_PFK4062 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z4062)

            SQL = " UPDATE PFK4062 SET "
            SQL = SQL & "    K4062_seMainProcess      = N'" & FormatSQL(z4062.seMainProcess) & "', "
            SQL = SQL & "    K4062_cdMainProcess      = N'" & FormatSQL(z4062.cdMainProcess) & "', "
            SQL = SQL & "    K4062_JobCard      = N'" & FormatSQL(z4062.JobCard) & "', "
            SQL = SQL & "    K4062_MaterialCode      = N'" & FormatSQL(z4062.MaterialCode) & "', "
            SQL = SQL & "    K4062_ToolCode      = N'" & FormatSQL(z4062.ToolCode) & "', "
            SQL = SQL & "    K4062_DatePlan      = N'" & FormatSQL(z4062.DatePlan) & "', "
            SQL = SQL & "    K4062_DateFinish      = N'" & FormatSQL(z4062.DateFinish) & "', "
            SQL = SQL & "    K4062_Description      = N'" & FormatSQL(z4062.Description) & "', "
            SQL = SQL & "    K4062_QtyPlan      =  " & FormatSQL(z4062.QtyPlan) & ", "
            SQL = SQL & "    K4062_QtyProd      =  " & FormatSQL(z4062.QtyProd) & ", "
            SQL = SQL & "    K4062_InchargePlan      = N'" & FormatSQL(z4062.InchargePlan) & "', "
            SQL = SQL & "    K4062_DateInsert      = N'" & FormatSQL(z4062.DateInsert) & "', "
            SQL = SQL & "    K4062_InchargeInsert      = N'" & FormatSQL(z4062.InchargeInsert) & "', "
            SQL = SQL & "    K4062_DateUpdate      = N'" & FormatSQL(z4062.DateUpdate) & "', "
            SQL = SQL & "    K4062_InchargeUpdate      = N'" & FormatSQL(z4062.InchargeUpdate) & "', "
            SQL = SQL & "    K4062_Remark      = N'" & FormatSQL(z4062.Remark) & "'  "
            SQL = SQL & " WHERE K4062_Autokey		 =  " & z4062.Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK4062 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK4062", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK4062(z4062 As T4062_AREA) As Boolean
        DELETE_PFK4062 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK4062 "
            SQL = SQL & " WHERE K4062_Autokey		 =  " & z4062.Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK4062 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK4062", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D4062_CLEAR()
        Try

            D4062.Autokey = 0
            D4062.seMainProcess = ""
            D4062.cdMainProcess = ""
            D4062.JobCard = ""
            D4062.MaterialCode = ""
            D4062.ToolCode = ""
            D4062.DatePlan = ""
            D4062.DateFinish = ""
            D4062.Description = ""
            D4062.QtyPlan = 0
            D4062.QtyProd = 0
            D4062.InchargePlan = ""
            D4062.DateInsert = ""
            D4062.InchargeInsert = ""
            D4062.DateUpdate = ""
            D4062.InchargeUpdate = ""
            D4062.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D4062_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x4062 As T4062_AREA)
        Try

            x4062.Autokey = trim$(x4062.Autokey)
            x4062.seMainProcess = trim$(x4062.seMainProcess)
            x4062.cdMainProcess = trim$(x4062.cdMainProcess)
            x4062.JobCard = trim$(x4062.JobCard)
            x4062.MaterialCode = trim$(x4062.MaterialCode)
            x4062.ToolCode = trim$(x4062.ToolCode)
            x4062.DatePlan = trim$(x4062.DatePlan)
            x4062.DateFinish = trim$(x4062.DateFinish)
            x4062.Description = trim$(x4062.Description)
            x4062.QtyPlan = trim$(x4062.QtyPlan)
            x4062.QtyProd = trim$(x4062.QtyProd)
            x4062.InchargePlan = trim$(x4062.InchargePlan)
            x4062.DateInsert = trim$(x4062.DateInsert)
            x4062.InchargeInsert = trim$(x4062.InchargeInsert)
            x4062.DateUpdate = trim$(x4062.DateUpdate)
            x4062.InchargeUpdate = trim$(x4062.InchargeUpdate)
            x4062.Remark = trim$(x4062.Remark)

            If trim$(x4062.Autokey) = "" Then x4062.Autokey = 0
            If trim$(x4062.seMainProcess) = "" Then x4062.seMainProcess = Space(1)
            If trim$(x4062.cdMainProcess) = "" Then x4062.cdMainProcess = Space(1)
            If trim$(x4062.JobCard) = "" Then x4062.JobCard = Space(1)
            If trim$(x4062.MaterialCode) = "" Then x4062.MaterialCode = Space(1)
            If trim$(x4062.ToolCode) = "" Then x4062.ToolCode = Space(1)
            If trim$(x4062.DatePlan) = "" Then x4062.DatePlan = Space(1)
            If trim$(x4062.DateFinish) = "" Then x4062.DateFinish = Space(1)
            If trim$(x4062.Description) = "" Then x4062.Description = Space(1)
            If trim$(x4062.QtyPlan) = "" Then x4062.QtyPlan = 0
            If trim$(x4062.QtyProd) = "" Then x4062.QtyProd = 0
            If trim$(x4062.InchargePlan) = "" Then x4062.InchargePlan = Space(1)
            If trim$(x4062.DateInsert) = "" Then x4062.DateInsert = Space(1)
            If trim$(x4062.InchargeInsert) = "" Then x4062.InchargeInsert = Space(1)
            If trim$(x4062.DateUpdate) = "" Then x4062.DateUpdate = Space(1)
            If trim$(x4062.InchargeUpdate) = "" Then x4062.InchargeUpdate = Space(1)
            If trim$(x4062.Remark) = "" Then x4062.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K4062_MOVE(rs4062 As SqlClient.SqlDataReader)
        Try

            Call D4062_CLEAR()

            If IsdbNull(rs4062!K4062_Autokey) = False Then D4062.Autokey = Trim$(rs4062!K4062_Autokey)
            If IsdbNull(rs4062!K4062_seMainProcess) = False Then D4062.seMainProcess = Trim$(rs4062!K4062_seMainProcess)
            If IsdbNull(rs4062!K4062_cdMainProcess) = False Then D4062.cdMainProcess = Trim$(rs4062!K4062_cdMainProcess)
            If IsdbNull(rs4062!K4062_JobCard) = False Then D4062.JobCard = Trim$(rs4062!K4062_JobCard)
            If IsdbNull(rs4062!K4062_MaterialCode) = False Then D4062.MaterialCode = Trim$(rs4062!K4062_MaterialCode)
            If IsdbNull(rs4062!K4062_ToolCode) = False Then D4062.ToolCode = Trim$(rs4062!K4062_ToolCode)
            If IsdbNull(rs4062!K4062_DatePlan) = False Then D4062.DatePlan = Trim$(rs4062!K4062_DatePlan)
            If IsdbNull(rs4062!K4062_DateFinish) = False Then D4062.DateFinish = Trim$(rs4062!K4062_DateFinish)
            If IsdbNull(rs4062!K4062_Description) = False Then D4062.Description = Trim$(rs4062!K4062_Description)
            If IsdbNull(rs4062!K4062_QtyPlan) = False Then D4062.QtyPlan = Trim$(rs4062!K4062_QtyPlan)
            If IsdbNull(rs4062!K4062_QtyProd) = False Then D4062.QtyProd = Trim$(rs4062!K4062_QtyProd)
            If IsdbNull(rs4062!K4062_InchargePlan) = False Then D4062.InchargePlan = Trim$(rs4062!K4062_InchargePlan)
            If IsdbNull(rs4062!K4062_DateInsert) = False Then D4062.DateInsert = Trim$(rs4062!K4062_DateInsert)
            If IsdbNull(rs4062!K4062_InchargeInsert) = False Then D4062.InchargeInsert = Trim$(rs4062!K4062_InchargeInsert)
            If IsdbNull(rs4062!K4062_DateUpdate) = False Then D4062.DateUpdate = Trim$(rs4062!K4062_DateUpdate)
            If IsdbNull(rs4062!K4062_InchargeUpdate) = False Then D4062.InchargeUpdate = Trim$(rs4062!K4062_InchargeUpdate)
            If IsdbNull(rs4062!K4062_Remark) = False Then D4062.Remark = Trim$(rs4062!K4062_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K4062_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K4062_MOVE(rs4062 As DataRow)
        Try

            Call D4062_CLEAR()

            If IsdbNull(rs4062!K4062_Autokey) = False Then D4062.Autokey = Trim$(rs4062!K4062_Autokey)
            If IsdbNull(rs4062!K4062_seMainProcess) = False Then D4062.seMainProcess = Trim$(rs4062!K4062_seMainProcess)
            If IsdbNull(rs4062!K4062_cdMainProcess) = False Then D4062.cdMainProcess = Trim$(rs4062!K4062_cdMainProcess)
            If IsdbNull(rs4062!K4062_JobCard) = False Then D4062.JobCard = Trim$(rs4062!K4062_JobCard)
            If IsdbNull(rs4062!K4062_MaterialCode) = False Then D4062.MaterialCode = Trim$(rs4062!K4062_MaterialCode)
            If IsdbNull(rs4062!K4062_ToolCode) = False Then D4062.ToolCode = Trim$(rs4062!K4062_ToolCode)
            If IsdbNull(rs4062!K4062_DatePlan) = False Then D4062.DatePlan = Trim$(rs4062!K4062_DatePlan)
            If IsdbNull(rs4062!K4062_DateFinish) = False Then D4062.DateFinish = Trim$(rs4062!K4062_DateFinish)
            If IsdbNull(rs4062!K4062_Description) = False Then D4062.Description = Trim$(rs4062!K4062_Description)
            If IsdbNull(rs4062!K4062_QtyPlan) = False Then D4062.QtyPlan = Trim$(rs4062!K4062_QtyPlan)
            If IsdbNull(rs4062!K4062_QtyProd) = False Then D4062.QtyProd = Trim$(rs4062!K4062_QtyProd)
            If IsdbNull(rs4062!K4062_InchargePlan) = False Then D4062.InchargePlan = Trim$(rs4062!K4062_InchargePlan)
            If IsdbNull(rs4062!K4062_DateInsert) = False Then D4062.DateInsert = Trim$(rs4062!K4062_DateInsert)
            If IsdbNull(rs4062!K4062_InchargeInsert) = False Then D4062.InchargeInsert = Trim$(rs4062!K4062_InchargeInsert)
            If IsdbNull(rs4062!K4062_DateUpdate) = False Then D4062.DateUpdate = Trim$(rs4062!K4062_DateUpdate)
            If IsdbNull(rs4062!K4062_InchargeUpdate) = False Then D4062.InchargeUpdate = Trim$(rs4062!K4062_InchargeUpdate)
            If IsdbNull(rs4062!K4062_Remark) = False Then D4062.Remark = Trim$(rs4062!K4062_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K4062_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K4062_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z4062 As T4062_AREA, AUTOKEY As Double) As Boolean

        K4062_MOVE = False

        Try
            If READ_PFK4062(AUTOKEY) = True Then
                z4062 = D4062
                K4062_MOVE = True
            Else
                z4062 = Nothing
            End If

            If getColumIndex(spr, "Autokey") > -1 Then z4062.Autokey = getDataM(spr, getColumIndex(spr, "Autokey"), xRow)
            If getColumIndex(spr, "seMainProcess") > -1 Then z4062.seMainProcess = getDataM(spr, getColumIndex(spr, "seMainProcess"), xRow)
            If getColumIndex(spr, "cdMainProcess") > -1 Then z4062.cdMainProcess = getDataM(spr, getColumIndex(spr, "cdMainProcess"), xRow)
            If getColumIndex(spr, "JobCard") > -1 Then z4062.JobCard = getDataM(spr, getColumIndex(spr, "JobCard"), xRow)
            If getColumIndex(spr, "MaterialCode") > -1 Then z4062.MaterialCode = getDataM(spr, getColumIndex(spr, "MaterialCode"), xRow)
            If getColumIndex(spr, "ToolCode") > -1 Then z4062.ToolCode = getDataM(spr, getColumIndex(spr, "ToolCode"), xRow)
            If getColumIndex(spr, "DatePlan") > -1 Then z4062.DatePlan = getDataM(spr, getColumIndex(spr, "DatePlan"), xRow)
            If getColumIndex(spr, "DateFinish") > -1 Then z4062.DateFinish = getDataM(spr, getColumIndex(spr, "DateFinish"), xRow)
            If getColumIndex(spr, "Description") > -1 Then z4062.Description = getDataM(spr, getColumIndex(spr, "Description"), xRow)
            If getColumIndex(spr, "QtyPlan") > -1 Then z4062.QtyPlan = getDataM(spr, getColumIndex(spr, "QtyPlan"), xRow)
            If getColumIndex(spr, "QtyProd") > -1 Then z4062.QtyProd = getDataM(spr, getColumIndex(spr, "QtyProd"), xRow)
            If getColumIndex(spr, "InchargePlan") > -1 Then z4062.InchargePlan = getDataM(spr, getColumIndex(spr, "InchargePlan"), xRow)
            If getColumIndex(spr, "DateInsert") > -1 Then z4062.DateInsert = getDataM(spr, getColumIndex(spr, "DateInsert"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z4062.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "DateUpdate") > -1 Then z4062.DateUpdate = getDataM(spr, getColumIndex(spr, "DateUpdate"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z4062.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z4062.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4062_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K4062_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z4062 As T4062_AREA, CheckClear As Boolean, AUTOKEY As Double) As Boolean

        K4062_MOVE = False

        Try
            If READ_PFK4062(AUTOKEY) = True Then
                z4062 = D4062
                K4062_MOVE = True
            Else
                If CheckClear = True Then z4062 = Nothing
            End If

            If getColumIndex(spr, "Autokey") > -1 Then z4062.Autokey = getDataM(spr, getColumIndex(spr, "Autokey"), xRow)
            If getColumIndex(spr, "seMainProcess") > -1 Then z4062.seMainProcess = getDataM(spr, getColumIndex(spr, "seMainProcess"), xRow)
            If getColumIndex(spr, "cdMainProcess") > -1 Then z4062.cdMainProcess = getDataM(spr, getColumIndex(spr, "cdMainProcess"), xRow)
            If getColumIndex(spr, "JobCard") > -1 Then z4062.JobCard = getDataM(spr, getColumIndex(spr, "JobCard"), xRow)
            If getColumIndex(spr, "MaterialCode") > -1 Then z4062.MaterialCode = getDataM(spr, getColumIndex(spr, "MaterialCode"), xRow)
            If getColumIndex(spr, "ToolCode") > -1 Then z4062.ToolCode = getDataM(spr, getColumIndex(spr, "ToolCode"), xRow)
            If getColumIndex(spr, "DatePlan") > -1 Then z4062.DatePlan = getDataM(spr, getColumIndex(spr, "DatePlan"), xRow)
            If getColumIndex(spr, "DateFinish") > -1 Then z4062.DateFinish = getDataM(spr, getColumIndex(spr, "DateFinish"), xRow)
            If getColumIndex(spr, "Description") > -1 Then z4062.Description = getDataM(spr, getColumIndex(spr, "Description"), xRow)
            If getColumIndex(spr, "QtyPlan") > -1 Then z4062.QtyPlan = getDataM(spr, getColumIndex(spr, "QtyPlan"), xRow)
            If getColumIndex(spr, "QtyProd") > -1 Then z4062.QtyProd = getDataM(spr, getColumIndex(spr, "QtyProd"), xRow)
            If getColumIndex(spr, "InchargePlan") > -1 Then z4062.InchargePlan = getDataM(spr, getColumIndex(spr, "InchargePlan"), xRow)
            If getColumIndex(spr, "DateInsert") > -1 Then z4062.DateInsert = getDataM(spr, getColumIndex(spr, "DateInsert"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z4062.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "DateUpdate") > -1 Then z4062.DateUpdate = getDataM(spr, getColumIndex(spr, "DateUpdate"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z4062.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z4062.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4062_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K4062_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z4062 As T4062_AREA, Job As String, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K4062_MOVE = False

        Try
            If READ_PFK4062(AUTOKEY) = True Then
                z4062 = D4062
                K4062_MOVE = True
            Else
                z4062 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4062")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z4062.Autokey = Children(i).Code
                                Case "SEMAINPROCESS" : z4062.seMainProcess = Children(i).Code
                                Case "CDMAINPROCESS" : z4062.cdMainProcess = Children(i).Code
                                Case "JOBCARD" : z4062.JobCard = Children(i).Code
                                Case "MATERIALCODE" : z4062.MaterialCode = Children(i).Code
                                Case "TOOLCODE" : z4062.ToolCode = Children(i).Code
                                Case "DATEPLAN" : z4062.DatePlan = Children(i).Code
                                Case "DATEFINISH" : z4062.DateFinish = Children(i).Code
                                Case "DESCRIPTION" : z4062.Description = Children(i).Code
                                Case "QTYPLAN" : z4062.QtyPlan = Children(i).Code
                                Case "QTYPROD" : z4062.QtyProd = Children(i).Code
                                Case "INCHARGEPLAN" : z4062.InchargePlan = Children(i).Code
                                Case "DATEINSERT" : z4062.DateInsert = Children(i).Code
                                Case "INCHARGEINSERT" : z4062.InchargeInsert = Children(i).Code
                                Case "DATEUPDATE" : z4062.DateUpdate = Children(i).Code
                                Case "INCHARGEUPDATE" : z4062.InchargeUpdate = Children(i).Code
                                Case "REMARK" : z4062.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z4062.Autokey = Children(i).Data
                                Case "SEMAINPROCESS" : z4062.seMainProcess = Children(i).Data
                                Case "CDMAINPROCESS" : z4062.cdMainProcess = Children(i).Data
                                Case "JOBCARD" : z4062.JobCard = Children(i).Data
                                Case "MATERIALCODE" : z4062.MaterialCode = Children(i).Data
                                Case "TOOLCODE" : z4062.ToolCode = Children(i).Data
                                Case "DATEPLAN" : z4062.DatePlan = Children(i).Data
                                Case "DATEFINISH" : z4062.DateFinish = Children(i).Data
                                Case "DESCRIPTION" : z4062.Description = Children(i).Data
                                Case "QTYPLAN" : z4062.QtyPlan = Children(i).Data
                                Case "QTYPROD" : z4062.QtyProd = Children(i).Data
                                Case "INCHARGEPLAN" : z4062.InchargePlan = Children(i).Data
                                Case "DATEINSERT" : z4062.DateInsert = Children(i).Data
                                Case "INCHARGEINSERT" : z4062.InchargeInsert = Children(i).Data
                                Case "DATEUPDATE" : z4062.DateUpdate = Children(i).Data
                                Case "INCHARGEUPDATE" : z4062.InchargeUpdate = Children(i).Data
                                Case "REMARK" : z4062.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4062_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K4062_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z4062 As T4062_AREA, Job As String, CheckClear As Boolean, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K4062_MOVE = False

        Try
            If READ_PFK4062(AUTOKEY) = True Then
                z4062 = D4062
                K4062_MOVE = True
            Else
                If CheckClear = True Then z4062 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4062")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z4062.Autokey = Children(i).Code
                                Case "SEMAINPROCESS" : z4062.seMainProcess = Children(i).Code
                                Case "CDMAINPROCESS" : z4062.cdMainProcess = Children(i).Code
                                Case "JOBCARD" : z4062.JobCard = Children(i).Code
                                Case "MATERIALCODE" : z4062.MaterialCode = Children(i).Code
                                Case "TOOLCODE" : z4062.ToolCode = Children(i).Code
                                Case "DATEPLAN" : z4062.DatePlan = Children(i).Code
                                Case "DATEFINISH" : z4062.DateFinish = Children(i).Code
                                Case "DESCRIPTION" : z4062.Description = Children(i).Code
                                Case "QTYPLAN" : z4062.QtyPlan = Children(i).Code
                                Case "QTYPROD" : z4062.QtyProd = Children(i).Code
                                Case "INCHARGEPLAN" : z4062.InchargePlan = Children(i).Code
                                Case "DATEINSERT" : z4062.DateInsert = Children(i).Code
                                Case "INCHARGEINSERT" : z4062.InchargeInsert = Children(i).Code
                                Case "DATEUPDATE" : z4062.DateUpdate = Children(i).Code
                                Case "INCHARGEUPDATE" : z4062.InchargeUpdate = Children(i).Code
                                Case "REMARK" : z4062.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z4062.Autokey = Children(i).Data
                                Case "SEMAINPROCESS" : z4062.seMainProcess = Children(i).Data
                                Case "CDMAINPROCESS" : z4062.cdMainProcess = Children(i).Data
                                Case "JOBCARD" : z4062.JobCard = Children(i).Data
                                Case "MATERIALCODE" : z4062.MaterialCode = Children(i).Data
                                Case "TOOLCODE" : z4062.ToolCode = Children(i).Data
                                Case "DATEPLAN" : z4062.DatePlan = Children(i).Data
                                Case "DATEFINISH" : z4062.DateFinish = Children(i).Data
                                Case "DESCRIPTION" : z4062.Description = Children(i).Data
                                Case "QTYPLAN" : z4062.QtyPlan = Children(i).Data
                                Case "QTYPROD" : z4062.QtyProd = Children(i).Data
                                Case "INCHARGEPLAN" : z4062.InchargePlan = Children(i).Data
                                Case "DATEINSERT" : z4062.DateInsert = Children(i).Data
                                Case "INCHARGEINSERT" : z4062.InchargeInsert = Children(i).Data
                                Case "DATEUPDATE" : z4062.DateUpdate = Children(i).Data
                                Case "INCHARGEUPDATE" : z4062.InchargeUpdate = Children(i).Data
                                Case "REMARK" : z4062.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4062_MOVE", vbCritical)
        End Try
    End Function

End Module
