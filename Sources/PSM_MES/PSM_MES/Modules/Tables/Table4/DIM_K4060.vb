'=========================================================================================================================================================
'   TABLE : (PFK4060)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K4060

    Structure T4060_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public Autokey As Double  '			decimal		*
        Public JobCard As String  '			char(9)
        Public DatePlan As String  '			char(8)
        Public seMainProcess As String  '			char(3)
        Public cdMainProcess As String  '			char(3)
        Public Description As String  '			nvarchar(100)
        Public QtyPlan As Double  '			decimal
        Public QtyProd As Double  '			decimal
        Public InchargePlan As String  '			char(8)
        Public DateMaster As String  '			char(8)
        Public LineX As Double  '			decimal
        Public LineY As Double  '			decimal
        Public DateInsert As String  '			char(8)
        Public InchargeInsert As String  '			char(6)
        Public DateUpdate As String  '			char(8)
        Public InchargeUpdate As String  '			char(6)
        Public Remark As String  '			nvarchar(50)
        '=========================================================================================================================================================
    End Structure

    Public D4060 As T4060_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK4060(AUTOKEY As Double) As Boolean
        READ_PFK4060 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4060 "
            SQL = SQL & " WHERE K4060_Autokey		 =  " & Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4060_CLEAR() : GoTo SKIP_READ_PFK4060

            Call K4060_MOVE(rd)
            READ_PFK4060 = True

SKIP_READ_PFK4060:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4060", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK4060(AUTOKEY As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4060 "
            SQL = SQL & " WHERE K4060_Autokey		 =  " & Autokey & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK4060", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK4060(z4060 As T4060_AREA) As Boolean
        WRITE_PFK4060 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z4060)

            SQL = " INSERT INTO PFK4060 "
            SQL = SQL & " ( "
            SQL = SQL & " K4060_JobCard,"
            SQL = SQL & " K4060_DatePlan,"
            SQL = SQL & " K4060_seMainProcess,"
            SQL = SQL & " K4060_cdMainProcess,"
            SQL = SQL & " K4060_Description,"
            SQL = SQL & " K4060_QtyPlan,"
            SQL = SQL & " K4060_QtyProd,"
            SQL = SQL & " K4060_InchargePlan,"
            SQL = SQL & " K4060_DateMaster,"
            SQL = SQL & " K4060_LineX,"
            SQL = SQL & " K4060_LineY,"
            SQL = SQL & " K4060_DateInsert,"
            SQL = SQL & " K4060_InchargeInsert,"
            SQL = SQL & " K4060_DateUpdate,"
            SQL = SQL & " K4060_InchargeUpdate,"
            SQL = SQL & " K4060_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z4060.JobCard) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4060.DatePlan) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4060.seMainProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4060.cdMainProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4060.Description) & "', "
            SQL = SQL & "   " & FormatSQL(z4060.QtyPlan) & ", "
            SQL = SQL & "   " & FormatSQL(z4060.QtyProd) & ", "
            SQL = SQL & "  N'" & FormatSQL(z4060.InchargePlan) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4060.DateMaster) & "', "
            SQL = SQL & "   " & FormatSQL(z4060.LineX) & ", "
            SQL = SQL & "   " & FormatSQL(z4060.LineY) & ", "
            SQL = SQL & "  N'" & FormatSQL(z4060.DateInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4060.InchargeInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4060.DateUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4060.InchargeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4060.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK4060 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK4060", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK4060(z4060 As T4060_AREA) As Boolean
        REWRITE_PFK4060 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z4060)

            SQL = " UPDATE PFK4060 SET "
            SQL = SQL & "    K4060_JobCard      = N'" & FormatSQL(z4060.JobCard) & "', "
            SQL = SQL & "    K4060_DatePlan      = N'" & FormatSQL(z4060.DatePlan) & "', "
            SQL = SQL & "    K4060_seMainProcess      = N'" & FormatSQL(z4060.seMainProcess) & "', "
            SQL = SQL & "    K4060_cdMainProcess      = N'" & FormatSQL(z4060.cdMainProcess) & "', "
            SQL = SQL & "    K4060_Description      = N'" & FormatSQL(z4060.Description) & "', "
            SQL = SQL & "    K4060_QtyPlan      =  " & FormatSQL(z4060.QtyPlan) & ", "
            SQL = SQL & "    K4060_QtyProd      =  " & FormatSQL(z4060.QtyProd) & ", "
            SQL = SQL & "    K4060_InchargePlan      = N'" & FormatSQL(z4060.InchargePlan) & "', "
            SQL = SQL & "    K4060_DateMaster      = N'" & FormatSQL(z4060.DateMaster) & "', "
            SQL = SQL & "    K4060_LineX      =  " & FormatSQL(z4060.LineX) & ", "
            SQL = SQL & "    K4060_LineY      =  " & FormatSQL(z4060.LineY) & ", "
            SQL = SQL & "    K4060_DateInsert      = N'" & FormatSQL(z4060.DateInsert) & "', "
            SQL = SQL & "    K4060_InchargeInsert      = N'" & FormatSQL(z4060.InchargeInsert) & "', "
            SQL = SQL & "    K4060_DateUpdate      = N'" & FormatSQL(z4060.DateUpdate) & "', "
            SQL = SQL & "    K4060_InchargeUpdate      = N'" & FormatSQL(z4060.InchargeUpdate) & "', "
            SQL = SQL & "    K4060_Remark      = N'" & FormatSQL(z4060.Remark) & "'  "
            SQL = SQL & " WHERE K4060_Autokey		 =  " & z4060.Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK4060 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK4060", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK4060(z4060 As T4060_AREA) As Boolean
        DELETE_PFK4060 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK4060 "
            SQL = SQL & " WHERE K4060_Autokey		 =  " & z4060.Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK4060 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK4060", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D4060_CLEAR()
        Try

            D4060.Autokey = 0
            D4060.JobCard = ""
            D4060.DatePlan = ""
            D4060.seMainProcess = ""
            D4060.cdMainProcess = ""
            D4060.Description = ""
            D4060.QtyPlan = 0
            D4060.QtyProd = 0
            D4060.InchargePlan = ""
            D4060.DateMaster = ""
            D4060.LineX = 0
            D4060.LineY = 0
            D4060.DateInsert = ""
            D4060.InchargeInsert = ""
            D4060.DateUpdate = ""
            D4060.InchargeUpdate = ""
            D4060.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D4060_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x4060 As T4060_AREA)
        Try

            x4060.Autokey = trim$(x4060.Autokey)
            x4060.JobCard = trim$(x4060.JobCard)
            x4060.DatePlan = trim$(x4060.DatePlan)
            x4060.seMainProcess = trim$(x4060.seMainProcess)
            x4060.cdMainProcess = trim$(x4060.cdMainProcess)
            x4060.Description = trim$(x4060.Description)
            x4060.QtyPlan = trim$(x4060.QtyPlan)
            x4060.QtyProd = trim$(x4060.QtyProd)
            x4060.InchargePlan = trim$(x4060.InchargePlan)
            x4060.DateMaster = trim$(x4060.DateMaster)
            x4060.LineX = trim$(x4060.LineX)
            x4060.LineY = trim$(x4060.LineY)
            x4060.DateInsert = trim$(x4060.DateInsert)
            x4060.InchargeInsert = trim$(x4060.InchargeInsert)
            x4060.DateUpdate = trim$(x4060.DateUpdate)
            x4060.InchargeUpdate = trim$(x4060.InchargeUpdate)
            x4060.Remark = trim$(x4060.Remark)

            If trim$(x4060.Autokey) = "" Then x4060.Autokey = 0
            If trim$(x4060.JobCard) = "" Then x4060.JobCard = Space(1)
            If trim$(x4060.DatePlan) = "" Then x4060.DatePlan = Space(1)
            If trim$(x4060.seMainProcess) = "" Then x4060.seMainProcess = Space(1)
            If trim$(x4060.cdMainProcess) = "" Then x4060.cdMainProcess = Space(1)
            If trim$(x4060.Description) = "" Then x4060.Description = Space(1)
            If trim$(x4060.QtyPlan) = "" Then x4060.QtyPlan = 0
            If trim$(x4060.QtyProd) = "" Then x4060.QtyProd = 0
            If trim$(x4060.InchargePlan) = "" Then x4060.InchargePlan = Space(1)
            If trim$(x4060.DateMaster) = "" Then x4060.DateMaster = Space(1)
            If trim$(x4060.LineX) = "" Then x4060.LineX = 0
            If trim$(x4060.LineY) = "" Then x4060.LineY = 0
            If trim$(x4060.DateInsert) = "" Then x4060.DateInsert = Space(1)
            If trim$(x4060.InchargeInsert) = "" Then x4060.InchargeInsert = Space(1)
            If trim$(x4060.DateUpdate) = "" Then x4060.DateUpdate = Space(1)
            If trim$(x4060.InchargeUpdate) = "" Then x4060.InchargeUpdate = Space(1)
            If trim$(x4060.Remark) = "" Then x4060.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K4060_MOVE(rs4060 As SqlClient.SqlDataReader)
        Try

            Call D4060_CLEAR()

            If IsdbNull(rs4060!K4060_Autokey) = False Then D4060.Autokey = Trim$(rs4060!K4060_Autokey)
            If IsdbNull(rs4060!K4060_JobCard) = False Then D4060.JobCard = Trim$(rs4060!K4060_JobCard)
            If IsdbNull(rs4060!K4060_DatePlan) = False Then D4060.DatePlan = Trim$(rs4060!K4060_DatePlan)
            If IsdbNull(rs4060!K4060_seMainProcess) = False Then D4060.seMainProcess = Trim$(rs4060!K4060_seMainProcess)
            If IsdbNull(rs4060!K4060_cdMainProcess) = False Then D4060.cdMainProcess = Trim$(rs4060!K4060_cdMainProcess)
            If IsdbNull(rs4060!K4060_Description) = False Then D4060.Description = Trim$(rs4060!K4060_Description)
            If IsdbNull(rs4060!K4060_QtyPlan) = False Then D4060.QtyPlan = Trim$(rs4060!K4060_QtyPlan)
            If IsdbNull(rs4060!K4060_QtyProd) = False Then D4060.QtyProd = Trim$(rs4060!K4060_QtyProd)
            If IsdbNull(rs4060!K4060_InchargePlan) = False Then D4060.InchargePlan = Trim$(rs4060!K4060_InchargePlan)
            If IsdbNull(rs4060!K4060_DateMaster) = False Then D4060.DateMaster = Trim$(rs4060!K4060_DateMaster)
            If IsdbNull(rs4060!K4060_LineX) = False Then D4060.LineX = Trim$(rs4060!K4060_LineX)
            If IsdbNull(rs4060!K4060_LineY) = False Then D4060.LineY = Trim$(rs4060!K4060_LineY)
            If IsdbNull(rs4060!K4060_DateInsert) = False Then D4060.DateInsert = Trim$(rs4060!K4060_DateInsert)
            If IsdbNull(rs4060!K4060_InchargeInsert) = False Then D4060.InchargeInsert = Trim$(rs4060!K4060_InchargeInsert)
            If IsdbNull(rs4060!K4060_DateUpdate) = False Then D4060.DateUpdate = Trim$(rs4060!K4060_DateUpdate)
            If IsdbNull(rs4060!K4060_InchargeUpdate) = False Then D4060.InchargeUpdate = Trim$(rs4060!K4060_InchargeUpdate)
            If IsdbNull(rs4060!K4060_Remark) = False Then D4060.Remark = Trim$(rs4060!K4060_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K4060_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K4060_MOVE(rs4060 As DataRow)
        Try

            Call D4060_CLEAR()

            If IsdbNull(rs4060!K4060_Autokey) = False Then D4060.Autokey = Trim$(rs4060!K4060_Autokey)
            If IsdbNull(rs4060!K4060_JobCard) = False Then D4060.JobCard = Trim$(rs4060!K4060_JobCard)
            If IsdbNull(rs4060!K4060_DatePlan) = False Then D4060.DatePlan = Trim$(rs4060!K4060_DatePlan)
            If IsdbNull(rs4060!K4060_seMainProcess) = False Then D4060.seMainProcess = Trim$(rs4060!K4060_seMainProcess)
            If IsdbNull(rs4060!K4060_cdMainProcess) = False Then D4060.cdMainProcess = Trim$(rs4060!K4060_cdMainProcess)
            If IsdbNull(rs4060!K4060_Description) = False Then D4060.Description = Trim$(rs4060!K4060_Description)
            If IsdbNull(rs4060!K4060_QtyPlan) = False Then D4060.QtyPlan = Trim$(rs4060!K4060_QtyPlan)
            If IsdbNull(rs4060!K4060_QtyProd) = False Then D4060.QtyProd = Trim$(rs4060!K4060_QtyProd)
            If IsdbNull(rs4060!K4060_InchargePlan) = False Then D4060.InchargePlan = Trim$(rs4060!K4060_InchargePlan)
            If IsdbNull(rs4060!K4060_DateMaster) = False Then D4060.DateMaster = Trim$(rs4060!K4060_DateMaster)
            If IsdbNull(rs4060!K4060_LineX) = False Then D4060.LineX = Trim$(rs4060!K4060_LineX)
            If IsdbNull(rs4060!K4060_LineY) = False Then D4060.LineY = Trim$(rs4060!K4060_LineY)
            If IsdbNull(rs4060!K4060_DateInsert) = False Then D4060.DateInsert = Trim$(rs4060!K4060_DateInsert)
            If IsdbNull(rs4060!K4060_InchargeInsert) = False Then D4060.InchargeInsert = Trim$(rs4060!K4060_InchargeInsert)
            If IsdbNull(rs4060!K4060_DateUpdate) = False Then D4060.DateUpdate = Trim$(rs4060!K4060_DateUpdate)
            If IsdbNull(rs4060!K4060_InchargeUpdate) = False Then D4060.InchargeUpdate = Trim$(rs4060!K4060_InchargeUpdate)
            If IsdbNull(rs4060!K4060_Remark) = False Then D4060.Remark = Trim$(rs4060!K4060_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K4060_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K4060_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z4060 As T4060_AREA, AUTOKEY As Double) As Boolean

        K4060_MOVE = False

        Try
            If READ_PFK4060(AUTOKEY) = True Then
                z4060 = D4060
                K4060_MOVE = True
            Else
                z4060 = Nothing
            End If

            If getColumIndex(spr, "Autokey") > -1 Then z4060.Autokey = getDataM(spr, getColumIndex(spr, "Autokey"), xRow)
            If getColumIndex(spr, "JobCard") > -1 Then z4060.JobCard = getDataM(spr, getColumIndex(spr, "JobCard"), xRow)
            If getColumIndex(spr, "DatePlan") > -1 Then z4060.DatePlan = getDataM(spr, getColumIndex(spr, "DatePlan"), xRow)
            If getColumIndex(spr, "seMainProcess") > -1 Then z4060.seMainProcess = getDataM(spr, getColumIndex(spr, "seMainProcess"), xRow)
            If getColumIndex(spr, "cdMainProcess") > -1 Then z4060.cdMainProcess = getDataM(spr, getColumIndex(spr, "cdMainProcess"), xRow)
            If getColumIndex(spr, "Description") > -1 Then z4060.Description = getDataM(spr, getColumIndex(spr, "Description"), xRow)
            If getColumIndex(spr, "QtyPlan") > -1 Then z4060.QtyPlan = getDataM(spr, getColumIndex(spr, "QtyPlan"), xRow)
            If getColumIndex(spr, "QtyProd") > -1 Then z4060.QtyProd = getDataM(spr, getColumIndex(spr, "QtyProd"), xRow)
            If getColumIndex(spr, "InchargePlan") > -1 Then z4060.InchargePlan = getDataM(spr, getColumIndex(spr, "InchargePlan"), xRow)
            If getColumIndex(spr, "DateMaster") > -1 Then z4060.DateMaster = getDataM(spr, getColumIndex(spr, "DateMaster"), xRow)
            If getColumIndex(spr, "LineX") > -1 Then z4060.LineX = getDataM(spr, getColumIndex(spr, "LineX"), xRow)
            If getColumIndex(spr, "LineY") > -1 Then z4060.LineY = getDataM(spr, getColumIndex(spr, "LineY"), xRow)
            If getColumIndex(spr, "DateInsert") > -1 Then z4060.DateInsert = getDataM(spr, getColumIndex(spr, "DateInsert"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z4060.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "DateUpdate") > -1 Then z4060.DateUpdate = getDataM(spr, getColumIndex(spr, "DateUpdate"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z4060.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z4060.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4060_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K4060_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z4060 As T4060_AREA, CheckClear As Boolean, AUTOKEY As Double) As Boolean

        K4060_MOVE = False

        Try
            If READ_PFK4060(AUTOKEY) = True Then
                z4060 = D4060
                K4060_MOVE = True
            Else
                If CheckClear = True Then z4060 = Nothing
            End If

            If getColumIndex(spr, "Autokey") > -1 Then z4060.Autokey = getDataM(spr, getColumIndex(spr, "Autokey"), xRow)
            If getColumIndex(spr, "JobCard") > -1 Then z4060.JobCard = getDataM(spr, getColumIndex(spr, "JobCard"), xRow)
            If getColumIndex(spr, "DatePlan") > -1 Then z4060.DatePlan = getDataM(spr, getColumIndex(spr, "DatePlan"), xRow)
            If getColumIndex(spr, "seMainProcess") > -1 Then z4060.seMainProcess = getDataM(spr, getColumIndex(spr, "seMainProcess"), xRow)
            If getColumIndex(spr, "cdMainProcess") > -1 Then z4060.cdMainProcess = getDataM(spr, getColumIndex(spr, "cdMainProcess"), xRow)
            If getColumIndex(spr, "Description") > -1 Then z4060.Description = getDataM(spr, getColumIndex(spr, "Description"), xRow)
            If getColumIndex(spr, "QtyPlan") > -1 Then z4060.QtyPlan = getDataM(spr, getColumIndex(spr, "QtyPlan"), xRow)
            If getColumIndex(spr, "QtyProd") > -1 Then z4060.QtyProd = getDataM(spr, getColumIndex(spr, "QtyProd"), xRow)
            If getColumIndex(spr, "InchargePlan") > -1 Then z4060.InchargePlan = getDataM(spr, getColumIndex(spr, "InchargePlan"), xRow)
            If getColumIndex(spr, "DateMaster") > -1 Then z4060.DateMaster = getDataM(spr, getColumIndex(spr, "DateMaster"), xRow)
            If getColumIndex(spr, "LineX") > -1 Then z4060.LineX = getDataM(spr, getColumIndex(spr, "LineX"), xRow)
            If getColumIndex(spr, "LineY") > -1 Then z4060.LineY = getDataM(spr, getColumIndex(spr, "LineY"), xRow)
            If getColumIndex(spr, "DateInsert") > -1 Then z4060.DateInsert = getDataM(spr, getColumIndex(spr, "DateInsert"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z4060.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "DateUpdate") > -1 Then z4060.DateUpdate = getDataM(spr, getColumIndex(spr, "DateUpdate"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z4060.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z4060.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4060_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K4060_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z4060 As T4060_AREA, Job As String, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K4060_MOVE = False

        Try
            If READ_PFK4060(AUTOKEY) = True Then
                z4060 = D4060
                K4060_MOVE = True
            Else
                z4060 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4060")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z4060.Autokey = Children(i).Code
                                Case "JOBCARD" : z4060.JobCard = Children(i).Code
                                Case "DATEPLAN" : z4060.DatePlan = Children(i).Code
                                Case "SEMAINPROCESS" : z4060.seMainProcess = Children(i).Code
                                Case "CDMAINPROCESS" : z4060.cdMainProcess = Children(i).Code
                                Case "DESCRIPTION" : z4060.Description = Children(i).Code
                                Case "QTYPLAN" : z4060.QtyPlan = Children(i).Code
                                Case "QTYPROD" : z4060.QtyProd = Children(i).Code
                                Case "INCHARGEPLAN" : z4060.InchargePlan = Children(i).Code
                                Case "DATEMASTER" : z4060.DateMaster = Children(i).Code
                                Case "LINEX" : z4060.LineX = Children(i).Code
                                Case "LINEY" : z4060.LineY = Children(i).Code
                                Case "DATEINSERT" : z4060.DateInsert = Children(i).Code
                                Case "INCHARGEINSERT" : z4060.InchargeInsert = Children(i).Code
                                Case "DATEUPDATE" : z4060.DateUpdate = Children(i).Code
                                Case "INCHARGEUPDATE" : z4060.InchargeUpdate = Children(i).Code
                                Case "REMARK" : z4060.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z4060.Autokey = Children(i).Data
                                Case "JOBCARD" : z4060.JobCard = Children(i).Data
                                Case "DATEPLAN" : z4060.DatePlan = Children(i).Data
                                Case "SEMAINPROCESS" : z4060.seMainProcess = Children(i).Data
                                Case "CDMAINPROCESS" : z4060.cdMainProcess = Children(i).Data
                                Case "DESCRIPTION" : z4060.Description = Children(i).Data
                                Case "QTYPLAN" : z4060.QtyPlan = Children(i).Data
                                Case "QTYPROD" : z4060.QtyProd = Children(i).Data
                                Case "INCHARGEPLAN" : z4060.InchargePlan = Children(i).Data
                                Case "DATEMASTER" : z4060.DateMaster = Children(i).Data
                                Case "LINEX" : z4060.LineX = Children(i).Data
                                Case "LINEY" : z4060.LineY = Children(i).Data
                                Case "DATEINSERT" : z4060.DateInsert = Children(i).Data
                                Case "INCHARGEINSERT" : z4060.InchargeInsert = Children(i).Data
                                Case "DATEUPDATE" : z4060.DateUpdate = Children(i).Data
                                Case "INCHARGEUPDATE" : z4060.InchargeUpdate = Children(i).Data
                                Case "REMARK" : z4060.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4060_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K4060_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z4060 As T4060_AREA, Job As String, CheckClear As Boolean, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K4060_MOVE = False

        Try
            If READ_PFK4060(AUTOKEY) = True Then
                z4060 = D4060
                K4060_MOVE = True
            Else
                If CheckClear = True Then z4060 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4060")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z4060.Autokey = Children(i).Code
                                Case "JOBCARD" : z4060.JobCard = Children(i).Code
                                Case "DATEPLAN" : z4060.DatePlan = Children(i).Code
                                Case "SEMAINPROCESS" : z4060.seMainProcess = Children(i).Code
                                Case "CDMAINPROCESS" : z4060.cdMainProcess = Children(i).Code
                                Case "DESCRIPTION" : z4060.Description = Children(i).Code
                                Case "QTYPLAN" : z4060.QtyPlan = Children(i).Code
                                Case "QTYPROD" : z4060.QtyProd = Children(i).Code
                                Case "INCHARGEPLAN" : z4060.InchargePlan = Children(i).Code
                                Case "DATEMASTER" : z4060.DateMaster = Children(i).Code
                                Case "LINEX" : z4060.LineX = Children(i).Code
                                Case "LINEY" : z4060.LineY = Children(i).Code
                                Case "DATEINSERT" : z4060.DateInsert = Children(i).Code
                                Case "INCHARGEINSERT" : z4060.InchargeInsert = Children(i).Code
                                Case "DATEUPDATE" : z4060.DateUpdate = Children(i).Code
                                Case "INCHARGEUPDATE" : z4060.InchargeUpdate = Children(i).Code
                                Case "REMARK" : z4060.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z4060.Autokey = Children(i).Data
                                Case "JOBCARD" : z4060.JobCard = Children(i).Data
                                Case "DATEPLAN" : z4060.DatePlan = Children(i).Data
                                Case "SEMAINPROCESS" : z4060.seMainProcess = Children(i).Data
                                Case "CDMAINPROCESS" : z4060.cdMainProcess = Children(i).Data
                                Case "DESCRIPTION" : z4060.Description = Children(i).Data
                                Case "QTYPLAN" : z4060.QtyPlan = Children(i).Data
                                Case "QTYPROD" : z4060.QtyProd = Children(i).Data
                                Case "INCHARGEPLAN" : z4060.InchargePlan = Children(i).Data
                                Case "DATEMASTER" : z4060.DateMaster = Children(i).Data
                                Case "LINEX" : z4060.LineX = Children(i).Data
                                Case "LINEY" : z4060.LineY = Children(i).Data
                                Case "DATEINSERT" : z4060.DateInsert = Children(i).Data
                                Case "INCHARGEINSERT" : z4060.InchargeInsert = Children(i).Data
                                Case "DATEUPDATE" : z4060.DateUpdate = Children(i).Data
                                Case "INCHARGEUPDATE" : z4060.InchargeUpdate = Children(i).Data
                                Case "REMARK" : z4060.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4060_MOVE", vbCritical)
        End Try
    End Function

End Module
