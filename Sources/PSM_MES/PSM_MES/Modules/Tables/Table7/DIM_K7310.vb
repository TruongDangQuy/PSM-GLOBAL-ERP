'=========================================================================================================================================================
'   TABLE : (PFK7310)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7310

    Structure T7310_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public JobBOMCode As String  '			nvarchar(6)		*
        Public JobBOMSeq As Double  '			decimal		*
        Public JobBOMSno As Double  '			decimal		*
        Public Dseq As Double  '			decimal
        Public seGroupJobProcess As String  '			char(3)
        Public cdGroupJobProcess As String  '			char(3)
        Public cdJobProcess As String  '			char(3)
        Public tpJobProcess As String  '			char(6)
        Public PositionName As String  '			nvarchar(20)
        Public Description As String  '			nvarchar(100)
        Public MaterialCode As String  '			char(6)
        Public SupplierCode As String  '			char(6)
        Public Standard1 As String  '			nvarchar(20)
        Public Standard2 As String  '			nvarchar(20)
        Public Standard3 As String  '			nvarchar(20)
        Public Standard4 As String  '			nvarchar(20)
        Public Standard5 As String  '			nvarchar(20)
        Public Standard6 As String  '			nvarchar(20)
        Public Standard7 As String  '			nvarchar(20)
        Public Standard8 As String  '			nvarchar(20)
        Public Standard9 As String  '			nvarchar(20)
        Public Standard10 As String  '			nvarchar(20)
        Public Remark As String  '			nvarchar(100)
        '=========================================================================================================================================================
    End Structure

    Public D7310 As T7310_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK7310(JOBBOMCODE As String, JOBBOMSEQ As Double, JOBBOMSNO As Double) As Boolean
        READ_PFK7310 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7310 "
            SQL = SQL & " WHERE K7310_JobBOMCode		 = '" & JobBOMCode & "' "
            SQL = SQL & "   AND K7310_JobBOMSeq		 =  " & JobBOMSeq & "  "
            SQL = SQL & "   AND K7310_JobBOMSno		 =  " & JobBOMSno & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7310_CLEAR() : GoTo SKIP_READ_PFK7310

            Call K7310_MOVE(rd)
            READ_PFK7310 = True

SKIP_READ_PFK7310:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7310", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK7310(JOBBOMCODE As String, JOBBOMSEQ As Double, JOBBOMSNO As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7310 "
            SQL = SQL & " WHERE K7310_JobBOMCode		 = '" & JobBOMCode & "' "
            SQL = SQL & "   AND K7310_JobBOMSeq		 =  " & JobBOMSeq & "  "
            SQL = SQL & "   AND K7310_JobBOMSno		 =  " & JobBOMSno & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK7310", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK7310(z7310 As T7310_AREA) As Boolean
        WRITE_PFK7310 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7310)

            SQL = " INSERT INTO PFK7310 "
            SQL = SQL & " ( "
            SQL = SQL & " K7310_JobBOMCode,"
            SQL = SQL & " K7310_JobBOMSeq,"
            SQL = SQL & " K7310_JobBOMSno,"
            SQL = SQL & " K7310_Dseq,"
            SQL = SQL & " K7310_seGroupJobProcess,"
            SQL = SQL & " K7310_cdGroupJobProcess,"
            SQL = SQL & " K7310_cdJobProcess,"
            SQL = SQL & " K7310_tpJobProcess,"
            SQL = SQL & " K7310_PositionName,"
            SQL = SQL & " K7310_Description,"
            SQL = SQL & " K7310_MaterialCode,"
            SQL = SQL & " K7310_SupplierCode,"
            SQL = SQL & " K7310_Standard1,"
            SQL = SQL & " K7310_Standard2,"
            SQL = SQL & " K7310_Standard3,"
            SQL = SQL & " K7310_Standard4,"
            SQL = SQL & " K7310_Standard5,"
            SQL = SQL & " K7310_Standard6,"
            SQL = SQL & " K7310_Standard7,"
            SQL = SQL & " K7310_Standard8,"
            SQL = SQL & " K7310_Standard9,"
            SQL = SQL & " K7310_Standard10,"
            SQL = SQL & " K7310_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z7310.JobBOMCode) & "', "
            SQL = SQL & "   " & FormatSQL(z7310.JobBOMSeq) & ", "
            SQL = SQL & "   " & FormatSQL(z7310.JobBOMSno) & ", "
            SQL = SQL & "   " & FormatSQL(z7310.Dseq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7310.seGroupJobProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7310.cdGroupJobProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7310.cdJobProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7310.tpJobProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7310.PositionName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7310.Description) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7310.MaterialCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7310.SupplierCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7310.Standard1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7310.Standard2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7310.Standard3) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7310.Standard4) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7310.Standard5) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7310.Standard6) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7310.Standard7) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7310.Standard8) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7310.Standard9) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7310.Standard10) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7310.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK7310 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK7310", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK7310(z7310 As T7310_AREA) As Boolean
        REWRITE_PFK7310 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7310)

            SQL = " UPDATE PFK7310 SET "
            SQL = SQL & "    K7310_Dseq      =  " & FormatSQL(z7310.Dseq) & ", "
            SQL = SQL & "    K7310_seGroupJobProcess      = N'" & FormatSQL(z7310.seGroupJobProcess) & "', "
            SQL = SQL & "    K7310_cdGroupJobProcess      = N'" & FormatSQL(z7310.cdGroupJobProcess) & "', "
            SQL = SQL & "    K7310_cdJobProcess      = N'" & FormatSQL(z7310.cdJobProcess) & "', "
            SQL = SQL & "    K7310_tpJobProcess      = N'" & FormatSQL(z7310.tpJobProcess) & "', "
            SQL = SQL & "    K7310_PositionName      = N'" & FormatSQL(z7310.PositionName) & "', "
            SQL = SQL & "    K7310_Description      = N'" & FormatSQL(z7310.Description) & "', "
            SQL = SQL & "    K7310_MaterialCode      = N'" & FormatSQL(z7310.MaterialCode) & "', "
            SQL = SQL & "    K7310_SupplierCode      = N'" & FormatSQL(z7310.SupplierCode) & "', "
            SQL = SQL & "    K7310_Standard1      = N'" & FormatSQL(z7310.Standard1) & "', "
            SQL = SQL & "    K7310_Standard2      = N'" & FormatSQL(z7310.Standard2) & "', "
            SQL = SQL & "    K7310_Standard3      = N'" & FormatSQL(z7310.Standard3) & "', "
            SQL = SQL & "    K7310_Standard4      = N'" & FormatSQL(z7310.Standard4) & "', "
            SQL = SQL & "    K7310_Standard5      = N'" & FormatSQL(z7310.Standard5) & "', "
            SQL = SQL & "    K7310_Standard6      = N'" & FormatSQL(z7310.Standard6) & "', "
            SQL = SQL & "    K7310_Standard7      = N'" & FormatSQL(z7310.Standard7) & "', "
            SQL = SQL & "    K7310_Standard8      = N'" & FormatSQL(z7310.Standard8) & "', "
            SQL = SQL & "    K7310_Standard9      = N'" & FormatSQL(z7310.Standard9) & "', "
            SQL = SQL & "    K7310_Standard10      = N'" & FormatSQL(z7310.Standard10) & "', "
            SQL = SQL & "    K7310_Remark      = N'" & FormatSQL(z7310.Remark) & "'  "
            SQL = SQL & " WHERE K7310_JobBOMCode		 = '" & z7310.JobBOMCode & "' "
            SQL = SQL & "   AND K7310_JobBOMSeq		 =  " & z7310.JobBOMSeq & "  "
            SQL = SQL & "   AND K7310_JobBOMSno		 =  " & z7310.JobBOMSno & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK7310 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK7310", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK7310(z7310 As T7310_AREA) As Boolean
        DELETE_PFK7310 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK7310 "
            SQL = SQL & " WHERE K7310_JobBOMCode		 = '" & z7310.JobBOMCode & "' "
            SQL = SQL & "   AND K7310_JobBOMSeq		 =  " & z7310.JobBOMSeq & "  "
            SQL = SQL & "   AND K7310_JobBOMSno		 =  " & z7310.JobBOMSno & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK7310 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK7310", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D7310_CLEAR()
        Try

            D7310.JobBOMCode = ""
            D7310.JobBOMSeq = 0
            D7310.JobBOMSno = 0
            D7310.Dseq = 0
            D7310.seGroupJobProcess = ""
            D7310.cdGroupJobProcess = ""
            D7310.cdJobProcess = ""
            D7310.tpJobProcess = ""
            D7310.PositionName = ""
            D7310.Description = ""
            D7310.MaterialCode = ""
            D7310.SupplierCode = ""
            D7310.Standard1 = ""
            D7310.Standard2 = ""
            D7310.Standard3 = ""
            D7310.Standard4 = ""
            D7310.Standard5 = ""
            D7310.Standard6 = ""
            D7310.Standard7 = ""
            D7310.Standard8 = ""
            D7310.Standard9 = ""
            D7310.Standard10 = ""
            D7310.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D7310_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x7310 As T7310_AREA)
        Try

            x7310.JobBOMCode = trim$(x7310.JobBOMCode)
            x7310.JobBOMSeq = trim$(x7310.JobBOMSeq)
            x7310.JobBOMSno = trim$(x7310.JobBOMSno)
            x7310.Dseq = trim$(x7310.Dseq)
            x7310.seGroupJobProcess = trim$(x7310.seGroupJobProcess)
            x7310.cdGroupJobProcess = trim$(x7310.cdGroupJobProcess)
            x7310.cdJobProcess = trim$(x7310.cdJobProcess)
            x7310.tpJobProcess = trim$(x7310.tpJobProcess)
            x7310.PositionName = trim$(x7310.PositionName)
            x7310.Description = trim$(x7310.Description)
            x7310.MaterialCode = trim$(x7310.MaterialCode)
            x7310.SupplierCode = trim$(x7310.SupplierCode)
            x7310.Standard1 = trim$(x7310.Standard1)
            x7310.Standard2 = trim$(x7310.Standard2)
            x7310.Standard3 = trim$(x7310.Standard3)
            x7310.Standard4 = trim$(x7310.Standard4)
            x7310.Standard5 = trim$(x7310.Standard5)
            x7310.Standard6 = trim$(x7310.Standard6)
            x7310.Standard7 = trim$(x7310.Standard7)
            x7310.Standard8 = trim$(x7310.Standard8)
            x7310.Standard9 = trim$(x7310.Standard9)
            x7310.Standard10 = trim$(x7310.Standard10)
            x7310.Remark = trim$(x7310.Remark)

            If trim$(x7310.JobBOMCode) = "" Then x7310.JobBOMCode = Space(1)
            If trim$(x7310.JobBOMSeq) = "" Then x7310.JobBOMSeq = 0
            If trim$(x7310.JobBOMSno) = "" Then x7310.JobBOMSno = 0
            If trim$(x7310.Dseq) = "" Then x7310.Dseq = 0
            If trim$(x7310.seGroupJobProcess) = "" Then x7310.seGroupJobProcess = Space(1)
            If trim$(x7310.cdGroupJobProcess) = "" Then x7310.cdGroupJobProcess = Space(1)
            If trim$(x7310.cdJobProcess) = "" Then x7310.cdJobProcess = Space(1)
            If trim$(x7310.tpJobProcess) = "" Then x7310.tpJobProcess = Space(1)
            If trim$(x7310.PositionName) = "" Then x7310.PositionName = Space(1)
            If trim$(x7310.Description) = "" Then x7310.Description = Space(1)
            If trim$(x7310.MaterialCode) = "" Then x7310.MaterialCode = Space(1)
            If trim$(x7310.SupplierCode) = "" Then x7310.SupplierCode = Space(1)
            If trim$(x7310.Standard1) = "" Then x7310.Standard1 = Space(1)
            If trim$(x7310.Standard2) = "" Then x7310.Standard2 = Space(1)
            If trim$(x7310.Standard3) = "" Then x7310.Standard3 = Space(1)
            If trim$(x7310.Standard4) = "" Then x7310.Standard4 = Space(1)
            If trim$(x7310.Standard5) = "" Then x7310.Standard5 = Space(1)
            If trim$(x7310.Standard6) = "" Then x7310.Standard6 = Space(1)
            If trim$(x7310.Standard7) = "" Then x7310.Standard7 = Space(1)
            If trim$(x7310.Standard8) = "" Then x7310.Standard8 = Space(1)
            If trim$(x7310.Standard9) = "" Then x7310.Standard9 = Space(1)
            If trim$(x7310.Standard10) = "" Then x7310.Standard10 = Space(1)
            If trim$(x7310.Remark) = "" Then x7310.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K7310_MOVE(rs7310 As SqlClient.SqlDataReader)
        Try

            Call D7310_CLEAR()

            If IsdbNull(rs7310!K7310_JobBOMCode) = False Then D7310.JobBOMCode = Trim$(rs7310!K7310_JobBOMCode)
            If IsdbNull(rs7310!K7310_JobBOMSeq) = False Then D7310.JobBOMSeq = Trim$(rs7310!K7310_JobBOMSeq)
            If IsdbNull(rs7310!K7310_JobBOMSno) = False Then D7310.JobBOMSno = Trim$(rs7310!K7310_JobBOMSno)
            If IsdbNull(rs7310!K7310_Dseq) = False Then D7310.Dseq = Trim$(rs7310!K7310_Dseq)
            If IsdbNull(rs7310!K7310_seGroupJobProcess) = False Then D7310.seGroupJobProcess = Trim$(rs7310!K7310_seGroupJobProcess)
            If IsdbNull(rs7310!K7310_cdGroupJobProcess) = False Then D7310.cdGroupJobProcess = Trim$(rs7310!K7310_cdGroupJobProcess)
            If IsdbNull(rs7310!K7310_cdJobProcess) = False Then D7310.cdJobProcess = Trim$(rs7310!K7310_cdJobProcess)
            If IsdbNull(rs7310!K7310_tpJobProcess) = False Then D7310.tpJobProcess = Trim$(rs7310!K7310_tpJobProcess)
            If IsdbNull(rs7310!K7310_PositionName) = False Then D7310.PositionName = Trim$(rs7310!K7310_PositionName)
            If IsdbNull(rs7310!K7310_Description) = False Then D7310.Description = Trim$(rs7310!K7310_Description)
            If IsdbNull(rs7310!K7310_MaterialCode) = False Then D7310.MaterialCode = Trim$(rs7310!K7310_MaterialCode)
            If IsdbNull(rs7310!K7310_SupplierCode) = False Then D7310.SupplierCode = Trim$(rs7310!K7310_SupplierCode)
            If IsdbNull(rs7310!K7310_Standard1) = False Then D7310.Standard1 = Trim$(rs7310!K7310_Standard1)
            If IsdbNull(rs7310!K7310_Standard2) = False Then D7310.Standard2 = Trim$(rs7310!K7310_Standard2)
            If IsdbNull(rs7310!K7310_Standard3) = False Then D7310.Standard3 = Trim$(rs7310!K7310_Standard3)
            If IsdbNull(rs7310!K7310_Standard4) = False Then D7310.Standard4 = Trim$(rs7310!K7310_Standard4)
            If IsdbNull(rs7310!K7310_Standard5) = False Then D7310.Standard5 = Trim$(rs7310!K7310_Standard5)
            If IsdbNull(rs7310!K7310_Standard6) = False Then D7310.Standard6 = Trim$(rs7310!K7310_Standard6)
            If IsdbNull(rs7310!K7310_Standard7) = False Then D7310.Standard7 = Trim$(rs7310!K7310_Standard7)
            If IsdbNull(rs7310!K7310_Standard8) = False Then D7310.Standard8 = Trim$(rs7310!K7310_Standard8)
            If IsdbNull(rs7310!K7310_Standard9) = False Then D7310.Standard9 = Trim$(rs7310!K7310_Standard9)
            If IsdbNull(rs7310!K7310_Standard10) = False Then D7310.Standard10 = Trim$(rs7310!K7310_Standard10)
            If IsdbNull(rs7310!K7310_Remark) = False Then D7310.Remark = Trim$(rs7310!K7310_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7310_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K7310_MOVE(rs7310 As DataRow)
        Try

            Call D7310_CLEAR()

            If IsdbNull(rs7310!K7310_JobBOMCode) = False Then D7310.JobBOMCode = Trim$(rs7310!K7310_JobBOMCode)
            If IsdbNull(rs7310!K7310_JobBOMSeq) = False Then D7310.JobBOMSeq = Trim$(rs7310!K7310_JobBOMSeq)
            If IsdbNull(rs7310!K7310_JobBOMSno) = False Then D7310.JobBOMSno = Trim$(rs7310!K7310_JobBOMSno)
            If IsdbNull(rs7310!K7310_Dseq) = False Then D7310.Dseq = Trim$(rs7310!K7310_Dseq)
            If IsdbNull(rs7310!K7310_seGroupJobProcess) = False Then D7310.seGroupJobProcess = Trim$(rs7310!K7310_seGroupJobProcess)
            If IsdbNull(rs7310!K7310_cdGroupJobProcess) = False Then D7310.cdGroupJobProcess = Trim$(rs7310!K7310_cdGroupJobProcess)
            If IsdbNull(rs7310!K7310_cdJobProcess) = False Then D7310.cdJobProcess = Trim$(rs7310!K7310_cdJobProcess)
            If IsdbNull(rs7310!K7310_tpJobProcess) = False Then D7310.tpJobProcess = Trim$(rs7310!K7310_tpJobProcess)
            If IsdbNull(rs7310!K7310_PositionName) = False Then D7310.PositionName = Trim$(rs7310!K7310_PositionName)
            If IsdbNull(rs7310!K7310_Description) = False Then D7310.Description = Trim$(rs7310!K7310_Description)
            If IsdbNull(rs7310!K7310_MaterialCode) = False Then D7310.MaterialCode = Trim$(rs7310!K7310_MaterialCode)
            If IsdbNull(rs7310!K7310_SupplierCode) = False Then D7310.SupplierCode = Trim$(rs7310!K7310_SupplierCode)
            If IsdbNull(rs7310!K7310_Standard1) = False Then D7310.Standard1 = Trim$(rs7310!K7310_Standard1)
            If IsdbNull(rs7310!K7310_Standard2) = False Then D7310.Standard2 = Trim$(rs7310!K7310_Standard2)
            If IsdbNull(rs7310!K7310_Standard3) = False Then D7310.Standard3 = Trim$(rs7310!K7310_Standard3)
            If IsdbNull(rs7310!K7310_Standard4) = False Then D7310.Standard4 = Trim$(rs7310!K7310_Standard4)
            If IsdbNull(rs7310!K7310_Standard5) = False Then D7310.Standard5 = Trim$(rs7310!K7310_Standard5)
            If IsdbNull(rs7310!K7310_Standard6) = False Then D7310.Standard6 = Trim$(rs7310!K7310_Standard6)
            If IsdbNull(rs7310!K7310_Standard7) = False Then D7310.Standard7 = Trim$(rs7310!K7310_Standard7)
            If IsdbNull(rs7310!K7310_Standard8) = False Then D7310.Standard8 = Trim$(rs7310!K7310_Standard8)
            If IsdbNull(rs7310!K7310_Standard9) = False Then D7310.Standard9 = Trim$(rs7310!K7310_Standard9)
            If IsdbNull(rs7310!K7310_Standard10) = False Then D7310.Standard10 = Trim$(rs7310!K7310_Standard10)
            If IsdbNull(rs7310!K7310_Remark) = False Then D7310.Remark = Trim$(rs7310!K7310_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7310_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K7310_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7310 As T7310_AREA, JOBBOMCODE As String, JOBBOMSEQ As Double, JOBBOMSNO As Double) As Boolean

        K7310_MOVE = False

        Try
            If READ_PFK7310(JOBBOMCODE, JOBBOMSEQ, JOBBOMSNO) = True Then
                z7310 = D7310
                K7310_MOVE = True
            Else
                z7310 = Nothing
            End If

            If getColumIndex(spr, "JobBOMCode") > -1 Then z7310.JobBOMCode = getDataM(spr, getColumIndex(spr, "JobBOMCode"), xRow)
            If getColumIndex(spr, "JobBOMSeq") > -1 Then z7310.JobBOMSeq = getDataM(spr, getColumIndex(spr, "JobBOMSeq"), xRow)
            If getColumIndex(spr, "JobBOMSno") > -1 Then z7310.JobBOMSno = getDataM(spr, getColumIndex(spr, "JobBOMSno"), xRow)
            If getColumIndex(spr, "Dseq") > -1 Then z7310.Dseq = getDataM(spr, getColumIndex(spr, "Dseq"), xRow)
            If getColumIndex(spr, "seGroupJobProcess") > -1 Then z7310.seGroupJobProcess = getDataM(spr, getColumIndex(spr, "seGroupJobProcess"), xRow)
            If getColumIndex(spr, "cdGroupJobProcess") > -1 Then z7310.cdGroupJobProcess = getDataM(spr, getColumIndex(spr, "cdGroupJobProcess"), xRow)
            If getColumIndex(spr, "cdJobProcess") > -1 Then z7310.cdJobProcess = getDataM(spr, getColumIndex(spr, "cdJobProcess"), xRow)
            If getColumIndex(spr, "tpJobProcess") > -1 Then z7310.tpJobProcess = getDataM(spr, getColumIndex(spr, "tpJobProcess"), xRow)
            If getColumIndex(spr, "PositionName") > -1 Then z7310.PositionName = getDataM(spr, getColumIndex(spr, "PositionName"), xRow)
            If getColumIndex(spr, "Description") > -1 Then z7310.Description = getDataM(spr, getColumIndex(spr, "Description"), xRow)
            If getColumIndex(spr, "MaterialCode") > -1 Then z7310.MaterialCode = getDataM(spr, getColumIndex(spr, "MaterialCode"), xRow)
            If getColumIndex(spr, "SupplierCode") > -1 Then z7310.SupplierCode = getDataM(spr, getColumIndex(spr, "SupplierCode"), xRow)
            If getColumIndex(spr, "Standard1") > -1 Then z7310.Standard1 = getDataM(spr, getColumIndex(spr, "Standard1"), xRow)
            If getColumIndex(spr, "Standard2") > -1 Then z7310.Standard2 = getDataM(spr, getColumIndex(spr, "Standard2"), xRow)
            If getColumIndex(spr, "Standard3") > -1 Then z7310.Standard3 = getDataM(spr, getColumIndex(spr, "Standard3"), xRow)
            If getColumIndex(spr, "Standard4") > -1 Then z7310.Standard4 = getDataM(spr, getColumIndex(spr, "Standard4"), xRow)
            If getColumIndex(spr, "Standard5") > -1 Then z7310.Standard5 = getDataM(spr, getColumIndex(spr, "Standard5"), xRow)
            If getColumIndex(spr, "Standard6") > -1 Then z7310.Standard6 = getDataM(spr, getColumIndex(spr, "Standard6"), xRow)
            If getColumIndex(spr, "Standard7") > -1 Then z7310.Standard7 = getDataM(spr, getColumIndex(spr, "Standard7"), xRow)
            If getColumIndex(spr, "Standard8") > -1 Then z7310.Standard8 = getDataM(spr, getColumIndex(spr, "Standard8"), xRow)
            If getColumIndex(spr, "Standard9") > -1 Then z7310.Standard9 = getDataM(spr, getColumIndex(spr, "Standard9"), xRow)
            If getColumIndex(spr, "Standard10") > -1 Then z7310.Standard10 = getDataM(spr, getColumIndex(spr, "Standard10"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z7310.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7310_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K7310_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7310 As T7310_AREA, CheckClear As Boolean, JOBBOMCODE As String, JOBBOMSEQ As Double, JOBBOMSNO As Double) As Boolean

        K7310_MOVE = False

        Try
            If READ_PFK7310(JOBBOMCODE, JOBBOMSEQ, JOBBOMSNO) = True Then
                z7310 = D7310
                K7310_MOVE = True
            Else
                If CheckClear = True Then z7310 = Nothing
            End If

            If getColumIndex(spr, "JobBOMCode") > -1 Then z7310.JobBOMCode = getDataM(spr, getColumIndex(spr, "JobBOMCode"), xRow)
            If getColumIndex(spr, "JobBOMSeq") > -1 Then z7310.JobBOMSeq = getDataM(spr, getColumIndex(spr, "JobBOMSeq"), xRow)
            If getColumIndex(spr, "JobBOMSno") > -1 Then z7310.JobBOMSno = getDataM(spr, getColumIndex(spr, "JobBOMSno"), xRow)
            If getColumIndex(spr, "Dseq") > -1 Then z7310.Dseq = getDataM(spr, getColumIndex(spr, "Dseq"), xRow)
            If getColumIndex(spr, "seGroupJobProcess") > -1 Then z7310.seGroupJobProcess = getDataM(spr, getColumIndex(spr, "seGroupJobProcess"), xRow)
            If getColumIndex(spr, "cdGroupJobProcess") > -1 Then z7310.cdGroupJobProcess = getDataM(spr, getColumIndex(spr, "cdGroupJobProcess"), xRow)
            If getColumIndex(spr, "cdJobProcess") > -1 Then z7310.cdJobProcess = getDataM(spr, getColumIndex(spr, "cdJobProcess"), xRow)
            If getColumIndex(spr, "tpJobProcess") > -1 Then z7310.tpJobProcess = getDataM(spr, getColumIndex(spr, "tpJobProcess"), xRow)
            If getColumIndex(spr, "PositionName") > -1 Then z7310.PositionName = getDataM(spr, getColumIndex(spr, "PositionName"), xRow)
            If getColumIndex(spr, "Description") > -1 Then z7310.Description = getDataM(spr, getColumIndex(spr, "Description"), xRow)
            If getColumIndex(spr, "MaterialCode") > -1 Then z7310.MaterialCode = getDataM(spr, getColumIndex(spr, "MaterialCode"), xRow)
            If getColumIndex(spr, "SupplierCode") > -1 Then z7310.SupplierCode = getDataM(spr, getColumIndex(spr, "SupplierCode"), xRow)
            If getColumIndex(spr, "Standard1") > -1 Then z7310.Standard1 = getDataM(spr, getColumIndex(spr, "Standard1"), xRow)
            If getColumIndex(spr, "Standard2") > -1 Then z7310.Standard2 = getDataM(spr, getColumIndex(spr, "Standard2"), xRow)
            If getColumIndex(spr, "Standard3") > -1 Then z7310.Standard3 = getDataM(spr, getColumIndex(spr, "Standard3"), xRow)
            If getColumIndex(spr, "Standard4") > -1 Then z7310.Standard4 = getDataM(spr, getColumIndex(spr, "Standard4"), xRow)
            If getColumIndex(spr, "Standard5") > -1 Then z7310.Standard5 = getDataM(spr, getColumIndex(spr, "Standard5"), xRow)
            If getColumIndex(spr, "Standard6") > -1 Then z7310.Standard6 = getDataM(spr, getColumIndex(spr, "Standard6"), xRow)
            If getColumIndex(spr, "Standard7") > -1 Then z7310.Standard7 = getDataM(spr, getColumIndex(spr, "Standard7"), xRow)
            If getColumIndex(spr, "Standard8") > -1 Then z7310.Standard8 = getDataM(spr, getColumIndex(spr, "Standard8"), xRow)
            If getColumIndex(spr, "Standard9") > -1 Then z7310.Standard9 = getDataM(spr, getColumIndex(spr, "Standard9"), xRow)
            If getColumIndex(spr, "Standard10") > -1 Then z7310.Standard10 = getDataM(spr, getColumIndex(spr, "Standard10"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z7310.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7310_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K7310_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7310 As T7310_AREA, Job As String, JOBBOMCODE As String, JOBBOMSEQ As Double, JOBBOMSNO As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7310_MOVE = False

        Try
            If READ_PFK7310(JOBBOMCODE, JOBBOMSEQ, JOBBOMSNO) = True Then
                z7310 = D7310
                K7310_MOVE = True
            Else
                z7310 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7310")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "JOBBOMCODE" : z7310.JobBOMCode = Children(i).Code
                                Case "JOBBOMSEQ" : z7310.JobBOMSeq = Children(i).Code
                                Case "JOBBOMSNO" : z7310.JobBOMSno = Children(i).Code
                                Case "DSEQ" : z7310.Dseq = Children(i).Code
                                Case "SEGROUPJOBPROCESS" : z7310.seGroupJobProcess = Children(i).Code
                                Case "CDGROUPJOBPROCESS" : z7310.cdGroupJobProcess = Children(i).Code
                                Case "CDJOBPROCESS" : z7310.cdJobProcess = Children(i).Code
                                Case "TPJOBPROCESS" : z7310.tpJobProcess = Children(i).Code
                                Case "POSITIONNAME" : z7310.PositionName = Children(i).Code
                                Case "DESCRIPTION" : z7310.Description = Children(i).Code
                                Case "MATERIALCODE" : z7310.MaterialCode = Children(i).Code
                                Case "SUPPLIERCODE" : z7310.SupplierCode = Children(i).Code
                                Case "STANDARD1" : z7310.Standard1 = Children(i).Code
                                Case "STANDARD2" : z7310.Standard2 = Children(i).Code
                                Case "STANDARD3" : z7310.Standard3 = Children(i).Code
                                Case "STANDARD4" : z7310.Standard4 = Children(i).Code
                                Case "STANDARD5" : z7310.Standard5 = Children(i).Code
                                Case "STANDARD6" : z7310.Standard6 = Children(i).Code
                                Case "STANDARD7" : z7310.Standard7 = Children(i).Code
                                Case "STANDARD8" : z7310.Standard8 = Children(i).Code
                                Case "STANDARD9" : z7310.Standard9 = Children(i).Code
                                Case "STANDARD10" : z7310.Standard10 = Children(i).Code
                                Case "REMARK" : z7310.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "JOBBOMCODE" : z7310.JobBOMCode = Children(i).Data
                                Case "JOBBOMSEQ" : z7310.JobBOMSeq = Children(i).Data
                                Case "JOBBOMSNO" : z7310.JobBOMSno = Children(i).Data
                                Case "DSEQ" : z7310.Dseq = Children(i).Data
                                Case "SEGROUPJOBPROCESS" : z7310.seGroupJobProcess = Children(i).Data
                                Case "CDGROUPJOBPROCESS" : z7310.cdGroupJobProcess = Children(i).Data
                                Case "CDJOBPROCESS" : z7310.cdJobProcess = Children(i).Data
                                Case "TPJOBPROCESS" : z7310.tpJobProcess = Children(i).Data
                                Case "POSITIONNAME" : z7310.PositionName = Children(i).Data
                                Case "DESCRIPTION" : z7310.Description = Children(i).Data
                                Case "MATERIALCODE" : z7310.MaterialCode = Children(i).Data
                                Case "SUPPLIERCODE" : z7310.SupplierCode = Children(i).Data
                                Case "STANDARD1" : z7310.Standard1 = Children(i).Data
                                Case "STANDARD2" : z7310.Standard2 = Children(i).Data
                                Case "STANDARD3" : z7310.Standard3 = Children(i).Data
                                Case "STANDARD4" : z7310.Standard4 = Children(i).Data
                                Case "STANDARD5" : z7310.Standard5 = Children(i).Data
                                Case "STANDARD6" : z7310.Standard6 = Children(i).Data
                                Case "STANDARD7" : z7310.Standard7 = Children(i).Data
                                Case "STANDARD8" : z7310.Standard8 = Children(i).Data
                                Case "STANDARD9" : z7310.Standard9 = Children(i).Data
                                Case "STANDARD10" : z7310.Standard10 = Children(i).Data
                                Case "REMARK" : z7310.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7310_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K7310_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7310 As T7310_AREA, Job As String, CheckClear As Boolean, JOBBOMCODE As String, JOBBOMSEQ As Double, JOBBOMSNO As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7310_MOVE = False

        Try
            If READ_PFK7310(JOBBOMCODE, JOBBOMSEQ, JOBBOMSNO) = True Then
                z7310 = D7310
                K7310_MOVE = True
            Else
                If CheckClear = True Then z7310 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7310")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "JOBBOMCODE" : z7310.JobBOMCode = Children(i).Code
                                Case "JOBBOMSEQ" : z7310.JobBOMSeq = Children(i).Code
                                Case "JOBBOMSNO" : z7310.JobBOMSno = Children(i).Code
                                Case "DSEQ" : z7310.Dseq = Children(i).Code
                                Case "SEGROUPJOBPROCESS" : z7310.seGroupJobProcess = Children(i).Code
                                Case "CDGROUPJOBPROCESS" : z7310.cdGroupJobProcess = Children(i).Code
                                Case "CDJOBPROCESS" : z7310.cdJobProcess = Children(i).Code
                                Case "TPJOBPROCESS" : z7310.tpJobProcess = Children(i).Code
                                Case "POSITIONNAME" : z7310.PositionName = Children(i).Code
                                Case "DESCRIPTION" : z7310.Description = Children(i).Code
                                Case "MATERIALCODE" : z7310.MaterialCode = Children(i).Code
                                Case "SUPPLIERCODE" : z7310.SupplierCode = Children(i).Code
                                Case "STANDARD1" : z7310.Standard1 = Children(i).Code
                                Case "STANDARD2" : z7310.Standard2 = Children(i).Code
                                Case "STANDARD3" : z7310.Standard3 = Children(i).Code
                                Case "STANDARD4" : z7310.Standard4 = Children(i).Code
                                Case "STANDARD5" : z7310.Standard5 = Children(i).Code
                                Case "STANDARD6" : z7310.Standard6 = Children(i).Code
                                Case "STANDARD7" : z7310.Standard7 = Children(i).Code
                                Case "STANDARD8" : z7310.Standard8 = Children(i).Code
                                Case "STANDARD9" : z7310.Standard9 = Children(i).Code
                                Case "STANDARD10" : z7310.Standard10 = Children(i).Code
                                Case "REMARK" : z7310.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "JOBBOMCODE" : z7310.JobBOMCode = Children(i).Data
                                Case "JOBBOMSEQ" : z7310.JobBOMSeq = Children(i).Data
                                Case "JOBBOMSNO" : z7310.JobBOMSno = Children(i).Data
                                Case "DSEQ" : z7310.Dseq = Children(i).Data
                                Case "SEGROUPJOBPROCESS" : z7310.seGroupJobProcess = Children(i).Data
                                Case "CDGROUPJOBPROCESS" : z7310.cdGroupJobProcess = Children(i).Data
                                Case "CDJOBPROCESS" : z7310.cdJobProcess = Children(i).Data
                                Case "TPJOBPROCESS" : z7310.tpJobProcess = Children(i).Data
                                Case "POSITIONNAME" : z7310.PositionName = Children(i).Data
                                Case "DESCRIPTION" : z7310.Description = Children(i).Data
                                Case "MATERIALCODE" : z7310.MaterialCode = Children(i).Data
                                Case "SUPPLIERCODE" : z7310.SupplierCode = Children(i).Data
                                Case "STANDARD1" : z7310.Standard1 = Children(i).Data
                                Case "STANDARD2" : z7310.Standard2 = Children(i).Data
                                Case "STANDARD3" : z7310.Standard3 = Children(i).Data
                                Case "STANDARD4" : z7310.Standard4 = Children(i).Data
                                Case "STANDARD5" : z7310.Standard5 = Children(i).Data
                                Case "STANDARD6" : z7310.Standard6 = Children(i).Data
                                Case "STANDARD7" : z7310.Standard7 = Children(i).Data
                                Case "STANDARD8" : z7310.Standard8 = Children(i).Data
                                Case "STANDARD9" : z7310.Standard9 = Children(i).Data
                                Case "STANDARD10" : z7310.Standard10 = Children(i).Data
                                Case "REMARK" : z7310.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7310_MOVE", vbCritical)
        End Try
    End Function

End Module
