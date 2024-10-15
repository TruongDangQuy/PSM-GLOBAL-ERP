'=========================================================================================================================================================
'   TABLE : (PFK2366)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K2366

    Structure T2366_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public Autokey As Long    '			int		*
        Public ProdDate As String  '			char(8)		*
        Public ProdSeq As String  '			char(5)		*
        Public FactOrderNo As String  '			char(9)
        Public FactOrderSeq As Double  '			decimal
        Public JobCard As String  '			char(9)
        Public MaterialCode As String  '			char(6)
        Public ColorName As String  '			nvarchar(500)
        Public cdUnitMaterial As String  '			char(3)
        Public seUnitMaterial As String  '			char(3)
        Public seDepartment As String  '			char(3)
        Public seLineProd As String  '			char(3)
        Public seSubProcess As String  '			char(3)
        Public cdDepartment As String  '			char(3)
        Public cdLineProd As String  '			char(3)
        Public cdSubProcess As String  '			char(3)
        Public InchargeReceipt As String  '			char(8)
        Public TimeReceipt As String
        Public DateRecept As String  '			char(8)
        Public PriceReceipt As Double  '			decimal
        Public QtyOutbound As Double  '			decimal
        Public QtyReceipt As Double  '			decimal
        Public QtyProduction As Double  '			decimal
        Public Remark As String  '			nvarchar(250)
        '=========================================================================================================================================================
    End Structure

    Public D2366 As T2366_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK2366(AUTOKEY As Long, PRODDATE As String, PRODSEQ As String) As Boolean
        READ_PFK2366 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK2366 "
            SQL = SQL & " WHERE K2366_Autokey		 =  " & Autokey & "  "
            SQL = SQL & "   AND K2366_ProdDate		 = '" & ProdDate & "' "
            SQL = SQL & "   AND K2366_ProdSeq		 = '" & ProdSeq & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D2366_CLEAR() : GoTo SKIP_READ_PFK2366

            Call K2366_MOVE(rd)
            READ_PFK2366 = True

SKIP_READ_PFK2366:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK2366", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK2366(AUTOKEY As Long, PRODDATE As String, PRODSEQ As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK2366 "
            SQL = SQL & " WHERE K2366_Autokey		 =  " & Autokey & "  "
            SQL = SQL & "   AND K2366_ProdDate		 = '" & ProdDate & "' "
            SQL = SQL & "   AND K2366_ProdSeq		 = '" & ProdSeq & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK2366", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK2366(z2366 As T2366_AREA) As Boolean
        WRITE_PFK2366 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z2366)

            SQL = " INSERT INTO PFK2366 "
            SQL = SQL & " ( "
            SQL = SQL & " K2366_ProdDate,"
            SQL = SQL & " K2366_ProdSeq,"
            SQL = SQL & " K2366_FactOrderNo,"
            SQL = SQL & " K2366_FactOrderSeq,"
            SQL = SQL & " K2366_JobCard,"
            SQL = SQL & " K2366_MaterialCode,"
            SQL = SQL & " K2366_ColorName,"
            SQL = SQL & " K2366_cdUnitMaterial,"
            SQL = SQL & " K2366_seUnitMaterial,"
            SQL = SQL & " K2366_seDepartment,"
            SQL = SQL & " K2366_seLineProd,"
            SQL = SQL & " K2366_seSubProcess,"
            SQL = SQL & " K2366_cdDepartment,"
            SQL = SQL & " K2366_cdLineProd,"
            SQL = SQL & " K2366_cdSubProcess,"
            SQL = SQL & " K2366_InchargeReceipt,"
            SQL = SQL & " K2366_TimeReceipt,"
            SQL = SQL & " K2366_DateRecept,"
            SQL = SQL & " K2366_PriceReceipt,"
            SQL = SQL & " K2366_QtyOutbound,"
            SQL = SQL & " K2366_QtyReceipt,"
            SQL = SQL & " K2366_QtyProduction,"
            SQL = SQL & " K2366_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z2366.ProdDate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2366.ProdSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2366.FactOrderNo) & "', "
            SQL = SQL & "   " & FormatSQL(z2366.FactOrderSeq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z2366.JobCard) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2366.MaterialCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2366.ColorName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2366.cdUnitMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2366.seUnitMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2366.seDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2366.seLineProd) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2366.seSubProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2366.cdDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2366.cdLineProd) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2366.cdSubProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2366.InchargeReceipt) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2366.TimeReceipt) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2366.DateRecept) & "', "
            SQL = SQL & "   " & FormatSQL(z2366.PriceReceipt) & ", "
            SQL = SQL & "   " & FormatSQL(z2366.QtyOutbound) & ", "
            SQL = SQL & "   " & FormatSQL(z2366.QtyReceipt) & ", "
            SQL = SQL & "   " & FormatSQL(z2366.QtyProduction) & ", "
            SQL = SQL & "  N'" & FormatSQL(z2366.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK2366 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK2366", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK2366(z2366 As T2366_AREA) As Boolean
        REWRITE_PFK2366 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z2366)

            SQL = " UPDATE PFK2366 SET "
            SQL = SQL & "    K2366_FactOrderNo      = N'" & FormatSQL(z2366.FactOrderNo) & "', "
            SQL = SQL & "    K2366_FactOrderSeq      =  " & FormatSQL(z2366.FactOrderSeq) & ", "
            SQL = SQL & "    K2366_JobCard      = N'" & FormatSQL(z2366.JobCard) & "', "
            SQL = SQL & "    K2366_MaterialCode      = N'" & FormatSQL(z2366.MaterialCode) & "', "
            SQL = SQL & "    K2366_ColorName      = N'" & FormatSQL(z2366.ColorName) & "', "
            SQL = SQL & "    K2366_cdUnitMaterial      = N'" & FormatSQL(z2366.cdUnitMaterial) & "', "
            SQL = SQL & "    K2366_seUnitMaterial      = N'" & FormatSQL(z2366.seUnitMaterial) & "', "
            SQL = SQL & "    K2366_seDepartment      = N'" & FormatSQL(z2366.seDepartment) & "', "
            SQL = SQL & "    K2366_seLineProd      = N'" & FormatSQL(z2366.seLineProd) & "', "
            SQL = SQL & "    K2366_seSubProcess      = N'" & FormatSQL(z2366.seSubProcess) & "', "
            SQL = SQL & "    K2366_cdDepartment      = N'" & FormatSQL(z2366.cdDepartment) & "', "
            SQL = SQL & "    K2366_cdLineProd      = N'" & FormatSQL(z2366.cdLineProd) & "', "
            SQL = SQL & "    K2366_cdSubProcess      = N'" & FormatSQL(z2366.cdSubProcess) & "', "
            SQL = SQL & "    K2366_InchargeReceipt      = N'" & FormatSQL(z2366.InchargeReceipt) & "', "
            SQL = SQL & "    K2366_TimeReceipt      = N'" & FormatSQL(z2366.TimeReceipt) & "', "
            SQL = SQL & "    K2366_DateRecept      = N'" & FormatSQL(z2366.DateRecept) & "', "
            SQL = SQL & "    K2366_PriceReceipt      =  " & FormatSQL(z2366.PriceReceipt) & ", "
            SQL = SQL & "    K2366_QtyOutbound      =  " & FormatSQL(z2366.QtyOutbound) & ", "
            SQL = SQL & "    K2366_QtyReceipt      =  " & FormatSQL(z2366.QtyReceipt) & ", "
            SQL = SQL & "    K2366_QtyProduction      =  " & FormatSQL(z2366.QtyProduction) & ", "
            SQL = SQL & "    K2366_Remark      = N'" & FormatSQL(z2366.Remark) & "'  "
            SQL = SQL & " WHERE K2366_Autokey		 =  " & z2366.Autokey & "  "
            SQL = SQL & "   AND K2366_ProdDate		 = '" & z2366.ProdDate & "' "
            SQL = SQL & "   AND K2366_ProdSeq		 = '" & z2366.ProdSeq & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK2366 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK2366", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK2366(z2366 As T2366_AREA) As Boolean
        DELETE_PFK2366 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK2366 "
            SQL = SQL & " WHERE K2366_Autokey		 =  " & z2366.Autokey & "  "
            SQL = SQL & "   AND K2366_ProdDate		 = '" & z2366.ProdDate & "' "
            SQL = SQL & "   AND K2366_ProdSeq		 = '" & z2366.ProdSeq & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK2366 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK2366", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D2366_CLEAR()
        Try

            D2366.Autokey = 0
            D2366.ProdDate = ""
            D2366.ProdSeq = ""
            D2366.FactOrderNo = ""
            D2366.FactOrderSeq = 0
            D2366.JobCard = ""
            D2366.MaterialCode = ""
            D2366.ColorName = ""
            D2366.cdUnitMaterial = ""
            D2366.seUnitMaterial = ""
            D2366.seDepartment = ""
            D2366.seLineProd = ""
            D2366.seSubProcess = ""
            D2366.cdDepartment = ""
            D2366.cdLineProd = ""
            D2366.cdSubProcess = ""
            D2366.InchargeReceipt = ""
            D2366.TimeReceipt = ""
            D2366.DateRecept = ""
            D2366.PriceReceipt = 0
            D2366.QtyOutbound = 0
            D2366.QtyReceipt = 0
            D2366.QtyProduction = 0
            D2366.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D2366_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x2366 As T2366_AREA)
        Try

            x2366.Autokey = trim$(x2366.Autokey)
            x2366.ProdDate = trim$(x2366.ProdDate)
            x2366.ProdSeq = trim$(x2366.ProdSeq)
            x2366.FactOrderNo = trim$(x2366.FactOrderNo)
            x2366.FactOrderSeq = trim$(x2366.FactOrderSeq)
            x2366.JobCard = trim$(x2366.JobCard)
            x2366.MaterialCode = trim$(x2366.MaterialCode)
            x2366.ColorName = trim$(x2366.ColorName)
            x2366.cdUnitMaterial = trim$(x2366.cdUnitMaterial)
            x2366.seUnitMaterial = trim$(x2366.seUnitMaterial)
            x2366.seDepartment = trim$(x2366.seDepartment)
            x2366.seLineProd = trim$(x2366.seLineProd)
            x2366.seSubProcess = trim$(x2366.seSubProcess)
            x2366.cdDepartment = trim$(x2366.cdDepartment)
            x2366.cdLineProd = trim$(x2366.cdLineProd)
            x2366.cdSubProcess = trim$(x2366.cdSubProcess)
            x2366.InchargeReceipt = trim$(x2366.InchargeReceipt)
            x2366.TimeReceipt = trim$(x2366.TimeReceipt)
            x2366.DateRecept = trim$(x2366.DateRecept)
            x2366.PriceReceipt = trim$(x2366.PriceReceipt)
            x2366.QtyOutbound = trim$(x2366.QtyOutbound)
            x2366.QtyReceipt = trim$(x2366.QtyReceipt)
            x2366.QtyProduction = trim$(x2366.QtyProduction)
            x2366.Remark = trim$(x2366.Remark)

            If trim$(x2366.Autokey) = "" Then x2366.Autokey = 0
            If trim$(x2366.ProdDate) = "" Then x2366.ProdDate = Space(1)
            If trim$(x2366.ProdSeq) = "" Then x2366.ProdSeq = Space(1)
            If trim$(x2366.FactOrderNo) = "" Then x2366.FactOrderNo = Space(1)
            If trim$(x2366.FactOrderSeq) = "" Then x2366.FactOrderSeq = 0
            If trim$(x2366.JobCard) = "" Then x2366.JobCard = Space(1)
            If trim$(x2366.MaterialCode) = "" Then x2366.MaterialCode = Space(1)
            If trim$(x2366.ColorName) = "" Then x2366.ColorName = Space(1)
            If trim$(x2366.cdUnitMaterial) = "" Then x2366.cdUnitMaterial = Space(1)
            If trim$(x2366.seUnitMaterial) = "" Then x2366.seUnitMaterial = Space(1)
            If trim$(x2366.seDepartment) = "" Then x2366.seDepartment = Space(1)
            If trim$(x2366.seLineProd) = "" Then x2366.seLineProd = Space(1)
            If trim$(x2366.seSubProcess) = "" Then x2366.seSubProcess = Space(1)
            If trim$(x2366.cdDepartment) = "" Then x2366.cdDepartment = Space(1)
            If trim$(x2366.cdLineProd) = "" Then x2366.cdLineProd = Space(1)
            If trim$(x2366.cdSubProcess) = "" Then x2366.cdSubProcess = Space(1)
            If trim$(x2366.InchargeReceipt) = "" Then x2366.InchargeReceipt = Space(1)
            If trim$(x2366.TimeReceipt) = "" Then x2366.TimeReceipt = Space(1)
            If trim$(x2366.DateRecept) = "" Then x2366.DateRecept = Space(1)
            If trim$(x2366.PriceReceipt) = "" Then x2366.PriceReceipt = 0
            If trim$(x2366.QtyOutbound) = "" Then x2366.QtyOutbound = 0
            If trim$(x2366.QtyReceipt) = "" Then x2366.QtyReceipt = 0
            If trim$(x2366.QtyProduction) = "" Then x2366.QtyProduction = 0
            If trim$(x2366.Remark) = "" Then x2366.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K2366_MOVE(rs2366 As SqlClient.SqlDataReader)
        Try

            Call D2366_CLEAR()

            If IsdbNull(rs2366!K2366_Autokey) = False Then D2366.Autokey = Trim$(rs2366!K2366_Autokey)
            If IsdbNull(rs2366!K2366_ProdDate) = False Then D2366.ProdDate = Trim$(rs2366!K2366_ProdDate)
            If IsdbNull(rs2366!K2366_ProdSeq) = False Then D2366.ProdSeq = Trim$(rs2366!K2366_ProdSeq)
            If IsdbNull(rs2366!K2366_FactOrderNo) = False Then D2366.FactOrderNo = Trim$(rs2366!K2366_FactOrderNo)
            If IsdbNull(rs2366!K2366_FactOrderSeq) = False Then D2366.FactOrderSeq = Trim$(rs2366!K2366_FactOrderSeq)
            If IsdbNull(rs2366!K2366_JobCard) = False Then D2366.JobCard = Trim$(rs2366!K2366_JobCard)
            If IsdbNull(rs2366!K2366_MaterialCode) = False Then D2366.MaterialCode = Trim$(rs2366!K2366_MaterialCode)
            If IsdbNull(rs2366!K2366_ColorName) = False Then D2366.ColorName = Trim$(rs2366!K2366_ColorName)
            If IsdbNull(rs2366!K2366_cdUnitMaterial) = False Then D2366.cdUnitMaterial = Trim$(rs2366!K2366_cdUnitMaterial)
            If IsdbNull(rs2366!K2366_seUnitMaterial) = False Then D2366.seUnitMaterial = Trim$(rs2366!K2366_seUnitMaterial)
            If IsdbNull(rs2366!K2366_seDepartment) = False Then D2366.seDepartment = Trim$(rs2366!K2366_seDepartment)
            If IsdbNull(rs2366!K2366_seLineProd) = False Then D2366.seLineProd = Trim$(rs2366!K2366_seLineProd)
            If IsdbNull(rs2366!K2366_seSubProcess) = False Then D2366.seSubProcess = Trim$(rs2366!K2366_seSubProcess)
            If IsdbNull(rs2366!K2366_cdDepartment) = False Then D2366.cdDepartment = Trim$(rs2366!K2366_cdDepartment)
            If IsdbNull(rs2366!K2366_cdLineProd) = False Then D2366.cdLineProd = Trim$(rs2366!K2366_cdLineProd)
            If IsdbNull(rs2366!K2366_cdSubProcess) = False Then D2366.cdSubProcess = Trim$(rs2366!K2366_cdSubProcess)
            If IsdbNull(rs2366!K2366_InchargeReceipt) = False Then D2366.InchargeReceipt = Trim$(rs2366!K2366_InchargeReceipt)
            If IsdbNull(rs2366!K2366_TimeReceipt) = False Then D2366.TimeReceipt = Trim$(rs2366!K2366_TimeReceipt)
            If IsdbNull(rs2366!K2366_DateRecept) = False Then D2366.DateRecept = Trim$(rs2366!K2366_DateRecept)
            If IsdbNull(rs2366!K2366_PriceReceipt) = False Then D2366.PriceReceipt = Trim$(rs2366!K2366_PriceReceipt)
            If IsdbNull(rs2366!K2366_QtyOutbound) = False Then D2366.QtyOutbound = Trim$(rs2366!K2366_QtyOutbound)
            If IsdbNull(rs2366!K2366_QtyReceipt) = False Then D2366.QtyReceipt = Trim$(rs2366!K2366_QtyReceipt)
            If IsdbNull(rs2366!K2366_QtyProduction) = False Then D2366.QtyProduction = Trim$(rs2366!K2366_QtyProduction)
            If IsdbNull(rs2366!K2366_Remark) = False Then D2366.Remark = Trim$(rs2366!K2366_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K2366_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K2366_MOVE(rs2366 As DataRow)
        Try

            Call D2366_CLEAR()

            If IsdbNull(rs2366!K2366_Autokey) = False Then D2366.Autokey = Trim$(rs2366!K2366_Autokey)
            If IsdbNull(rs2366!K2366_ProdDate) = False Then D2366.ProdDate = Trim$(rs2366!K2366_ProdDate)
            If IsdbNull(rs2366!K2366_ProdSeq) = False Then D2366.ProdSeq = Trim$(rs2366!K2366_ProdSeq)
            If IsdbNull(rs2366!K2366_FactOrderNo) = False Then D2366.FactOrderNo = Trim$(rs2366!K2366_FactOrderNo)
            If IsdbNull(rs2366!K2366_FactOrderSeq) = False Then D2366.FactOrderSeq = Trim$(rs2366!K2366_FactOrderSeq)
            If IsdbNull(rs2366!K2366_JobCard) = False Then D2366.JobCard = Trim$(rs2366!K2366_JobCard)
            If IsdbNull(rs2366!K2366_MaterialCode) = False Then D2366.MaterialCode = Trim$(rs2366!K2366_MaterialCode)
            If IsdbNull(rs2366!K2366_ColorName) = False Then D2366.ColorName = Trim$(rs2366!K2366_ColorName)
            If IsdbNull(rs2366!K2366_cdUnitMaterial) = False Then D2366.cdUnitMaterial = Trim$(rs2366!K2366_cdUnitMaterial)
            If IsdbNull(rs2366!K2366_seUnitMaterial) = False Then D2366.seUnitMaterial = Trim$(rs2366!K2366_seUnitMaterial)
            If IsdbNull(rs2366!K2366_seDepartment) = False Then D2366.seDepartment = Trim$(rs2366!K2366_seDepartment)
            If IsdbNull(rs2366!K2366_seLineProd) = False Then D2366.seLineProd = Trim$(rs2366!K2366_seLineProd)
            If IsdbNull(rs2366!K2366_seSubProcess) = False Then D2366.seSubProcess = Trim$(rs2366!K2366_seSubProcess)
            If IsdbNull(rs2366!K2366_cdDepartment) = False Then D2366.cdDepartment = Trim$(rs2366!K2366_cdDepartment)
            If IsdbNull(rs2366!K2366_cdLineProd) = False Then D2366.cdLineProd = Trim$(rs2366!K2366_cdLineProd)
            If IsdbNull(rs2366!K2366_cdSubProcess) = False Then D2366.cdSubProcess = Trim$(rs2366!K2366_cdSubProcess)
            If IsdbNull(rs2366!K2366_InchargeReceipt) = False Then D2366.InchargeReceipt = Trim$(rs2366!K2366_InchargeReceipt)
            If IsdbNull(rs2366!K2366_TimeReceipt) = False Then D2366.TimeReceipt = Trim$(rs2366!K2366_TimeReceipt)
            If IsdbNull(rs2366!K2366_DateRecept) = False Then D2366.DateRecept = Trim$(rs2366!K2366_DateRecept)
            If IsdbNull(rs2366!K2366_PriceReceipt) = False Then D2366.PriceReceipt = Trim$(rs2366!K2366_PriceReceipt)
            If IsdbNull(rs2366!K2366_QtyOutbound) = False Then D2366.QtyOutbound = Trim$(rs2366!K2366_QtyOutbound)
            If IsdbNull(rs2366!K2366_QtyReceipt) = False Then D2366.QtyReceipt = Trim$(rs2366!K2366_QtyReceipt)
            If IsdbNull(rs2366!K2366_QtyProduction) = False Then D2366.QtyProduction = Trim$(rs2366!K2366_QtyProduction)
            If IsdbNull(rs2366!K2366_Remark) = False Then D2366.Remark = Trim$(rs2366!K2366_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K2366_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K2366_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z2366 As T2366_AREA, AUTOKEY As Long, PRODDATE As String, PRODSEQ As String) As Boolean

        K2366_MOVE = False

        Try
            If READ_PFK2366(AUTOKEY, PRODDATE, PRODSEQ) = True Then
                z2366 = D2366
                K2366_MOVE = True
            Else
                z2366 = Nothing
            End If

            If getColumnIndex(spr, "Autokey") > -1 Then z2366.Autokey = getDataM(spr, getColumnIndex(spr, "Autokey"), xRow)
            If getColumnIndex(spr, "ProdDate") > -1 Then z2366.ProdDate = getDataM(spr, getColumnIndex(spr, "ProdDate"), xRow)
            If getColumnIndex(spr, "ProdSeq") > -1 Then z2366.ProdSeq = getDataM(spr, getColumnIndex(spr, "ProdSeq"), xRow)
            If getColumnIndex(spr, "FactOrderNo") > -1 Then z2366.FactOrderNo = getDataM(spr, getColumnIndex(spr, "FactOrderNo"), xRow)
            If getColumnIndex(spr, "FactOrderSeq") > -1 Then z2366.FactOrderSeq = getDataM(spr, getColumnIndex(spr, "FactOrderSeq"), xRow)
            If getColumnIndex(spr, "JobCard") > -1 Then z2366.JobCard = getDataM(spr, getColumnIndex(spr, "JobCard"), xRow)
            If getColumnIndex(spr, "MaterialCode") > -1 Then z2366.MaterialCode = getDataM(spr, getColumnIndex(spr, "MaterialCode"), xRow)
            If getColumnIndex(spr, "ColorName") > -1 Then z2366.ColorName = getDataM(spr, getColumnIndex(spr, "ColorName"), xRow)
            If getColumnIndex(spr, "cdUnitMaterial") > -1 Then z2366.cdUnitMaterial = getDataM(spr, getColumnIndex(spr, "cdUnitMaterial"), xRow)
            If getColumnIndex(spr, "seUnitMaterial") > -1 Then z2366.seUnitMaterial = getDataM(spr, getColumnIndex(spr, "seUnitMaterial"), xRow)
            If getColumnIndex(spr, "seDepartment") > -1 Then z2366.seDepartment = getDataM(spr, getColumnIndex(spr, "seDepartment"), xRow)
            If getColumnIndex(spr, "seLineProd") > -1 Then z2366.seLineProd = getDataM(spr, getColumnIndex(spr, "seLineProd"), xRow)
            If getColumnIndex(spr, "seSubProcess") > -1 Then z2366.seSubProcess = getDataM(spr, getColumnIndex(spr, "seSubProcess"), xRow)
            If getColumnIndex(spr, "cdDepartment") > -1 Then z2366.cdDepartment = getDataM(spr, getColumnIndex(spr, "cdDepartment"), xRow)
            If getColumnIndex(spr, "cdLineProd") > -1 Then z2366.cdLineProd = getDataM(spr, getColumnIndex(spr, "cdLineProd"), xRow)
            If getColumnIndex(spr, "cdSubProcess") > -1 Then z2366.cdSubProcess = getDataM(spr, getColumnIndex(spr, "cdSubProcess"), xRow)
            If getColumnIndex(spr, "InchargeReceipt") > -1 Then z2366.InchargeReceipt = getDataM(spr, getColumnIndex(spr, "InchargeReceipt"), xRow)
            If getColumnIndex(spr, "TimeReceipt") > -1 Then z2366.TimeReceipt = getDataM(spr, getColumnIndex(spr, "TimeReceipt"), xRow)
            If getColumnIndex(spr, "DateRecept") > -1 Then z2366.DateRecept = getDataM(spr, getColumnIndex(spr, "DateRecept"), xRow)
            If getColumnIndex(spr, "PriceReceipt") > -1 Then z2366.PriceReceipt = getDataM(spr, getColumnIndex(spr, "PriceReceipt"), xRow)
            If getColumnIndex(spr, "QtyOutbound") > -1 Then z2366.QtyOutbound = getDataM(spr, getColumnIndex(spr, "QtyOutbound"), xRow)
            If getColumnIndex(spr, "QtyReceipt") > -1 Then z2366.QtyReceipt = getDataM(spr, getColumnIndex(spr, "QtyReceipt"), xRow)
            If getColumnIndex(spr, "QtyProduction") > -1 Then z2366.QtyProduction = getDataM(spr, getColumnIndex(spr, "QtyProduction"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z2366.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2366_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K2366_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z2366 As T2366_AREA, CheckClear As Boolean, AUTOKEY As Long, PRODDATE As String, PRODSEQ As String) As Boolean

        K2366_MOVE = False

        Try
            If READ_PFK2366(AUTOKEY, PRODDATE, PRODSEQ) = True Then
                z2366 = D2366
                K2366_MOVE = True
            Else
                If CheckClear = True Then z2366 = Nothing
            End If

            If getColumnIndex(spr, "Autokey") > -1 Then z2366.Autokey = getDataM(spr, getColumnIndex(spr, "Autokey"), xRow)
            If getColumnIndex(spr, "ProdDate") > -1 Then z2366.ProdDate = getDataM(spr, getColumnIndex(spr, "ProdDate"), xRow)
            If getColumnIndex(spr, "ProdSeq") > -1 Then z2366.ProdSeq = getDataM(spr, getColumnIndex(spr, "ProdSeq"), xRow)
            If getColumnIndex(spr, "FactOrderNo") > -1 Then z2366.FactOrderNo = getDataM(spr, getColumnIndex(spr, "FactOrderNo"), xRow)
            If getColumnIndex(spr, "FactOrderSeq") > -1 Then z2366.FactOrderSeq = getDataM(spr, getColumnIndex(spr, "FactOrderSeq"), xRow)
            If getColumnIndex(spr, "JobCard") > -1 Then z2366.JobCard = getDataM(spr, getColumnIndex(spr, "JobCard"), xRow)
            If getColumnIndex(spr, "MaterialCode") > -1 Then z2366.MaterialCode = getDataM(spr, getColumnIndex(spr, "MaterialCode"), xRow)
            If getColumnIndex(spr, "ColorName") > -1 Then z2366.ColorName = getDataM(spr, getColumnIndex(spr, "ColorName"), xRow)
            If getColumnIndex(spr, "cdUnitMaterial") > -1 Then z2366.cdUnitMaterial = getDataM(spr, getColumnIndex(spr, "cdUnitMaterial"), xRow)
            If getColumnIndex(spr, "seUnitMaterial") > -1 Then z2366.seUnitMaterial = getDataM(spr, getColumnIndex(spr, "seUnitMaterial"), xRow)
            If getColumnIndex(spr, "seDepartment") > -1 Then z2366.seDepartment = getDataM(spr, getColumnIndex(spr, "seDepartment"), xRow)
            If getColumnIndex(spr, "seLineProd") > -1 Then z2366.seLineProd = getDataM(spr, getColumnIndex(spr, "seLineProd"), xRow)
            If getColumnIndex(spr, "seSubProcess") > -1 Then z2366.seSubProcess = getDataM(spr, getColumnIndex(spr, "seSubProcess"), xRow)
            If getColumnIndex(spr, "cdDepartment") > -1 Then z2366.cdDepartment = getDataM(spr, getColumnIndex(spr, "cdDepartment"), xRow)
            If getColumnIndex(spr, "cdLineProd") > -1 Then z2366.cdLineProd = getDataM(spr, getColumnIndex(spr, "cdLineProd"), xRow)
            If getColumnIndex(spr, "cdSubProcess") > -1 Then z2366.cdSubProcess = getDataM(spr, getColumnIndex(spr, "cdSubProcess"), xRow)
            If getColumnIndex(spr, "InchargeReceipt") > -1 Then z2366.InchargeReceipt = getDataM(spr, getColumnIndex(spr, "InchargeReceipt"), xRow)
            If getColumnIndex(spr, "TimeReceipt") > -1 Then z2366.TimeReceipt = getDataM(spr, getColumnIndex(spr, "TimeReceipt"), xRow)
            If getColumnIndex(spr, "DateRecept") > -1 Then z2366.DateRecept = getDataM(spr, getColumnIndex(spr, "DateRecept"), xRow)
            If getColumnIndex(spr, "PriceReceipt") > -1 Then z2366.PriceReceipt = getDataM(spr, getColumnIndex(spr, "PriceReceipt"), xRow)
            If getColumnIndex(spr, "QtyOutbound") > -1 Then z2366.QtyOutbound = getDataM(spr, getColumnIndex(spr, "QtyOutbound"), xRow)
            If getColumnIndex(spr, "QtyReceipt") > -1 Then z2366.QtyReceipt = getDataM(spr, getColumnIndex(spr, "QtyReceipt"), xRow)
            If getColumnIndex(spr, "QtyProduction") > -1 Then z2366.QtyProduction = getDataM(spr, getColumnIndex(spr, "QtyProduction"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z2366.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2366_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K2366_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z2366 As T2366_AREA, Job As String, AUTOKEY As Long, PRODDATE As String, PRODSEQ As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K2366_MOVE = False

        Try
            If READ_PFK2366(AUTOKEY, PRODDATE, PRODSEQ) = True Then
                z2366 = D2366
                K2366_MOVE = True
            Else
                z2366 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2366")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z2366.Autokey = Children(i).Code
                                Case "PRODDATE" : z2366.ProdDate = Children(i).Code
                                Case "PRODSEQ" : z2366.ProdSeq = Children(i).Code
                                Case "FACTORDERNO" : z2366.FactOrderNo = Children(i).Code
                                Case "FACTORDERSEQ" : z2366.FactOrderSeq = Children(i).Code
                                Case "JOBCARD" : z2366.JobCard = Children(i).Code
                                Case "MATERIALCODE" : z2366.MaterialCode = Children(i).Code
                                Case "COLORNAME" : z2366.ColorName = Children(i).Code
                                Case "CDUNITMATERIAL" : z2366.cdUnitMaterial = Children(i).Code
                                Case "SEUNITMATERIAL" : z2366.seUnitMaterial = Children(i).Code
                                Case "SEDEPARTMENT" : z2366.seDepartment = Children(i).Code
                                Case "SELINEPROD" : z2366.seLineProd = Children(i).Code
                                Case "SESUBPROCESS" : z2366.seSubProcess = Children(i).Code
                                Case "CDDEPARTMENT" : z2366.cdDepartment = Children(i).Code
                                Case "CDLINEPROD" : z2366.cdLineProd = Children(i).Code
                                Case "CDSUBPROCESS" : z2366.cdSubProcess = Children(i).Code
                                Case "INCHARGERECEIPT" : z2366.InchargeReceipt = Children(i).Code
                                Case "TIMERECEIPT" : z2366.TimeReceipt = Children(i).Code
                                Case "DATERECEPT" : z2366.DateRecept = Children(i).Code
                                Case "PRICERECEIPT" : z2366.PriceReceipt = Children(i).Code
                                Case "QTYOUTBOUND" : z2366.QtyOutbound = Children(i).Code
                                Case "QTYRECEIPT" : z2366.QtyReceipt = Children(i).Code
                                Case "QTYPRODUCTION" : z2366.QtyProduction = Children(i).Code
                                Case "REMARK" : z2366.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z2366.Autokey = Children(i).Data
                                Case "PRODDATE" : z2366.ProdDate = Children(i).Data
                                Case "PRODSEQ" : z2366.ProdSeq = Children(i).Data
                                Case "FACTORDERNO" : z2366.FactOrderNo = Children(i).Data
                                Case "FACTORDERSEQ" : z2366.FactOrderSeq = Children(i).Data
                                Case "JOBCARD" : z2366.JobCard = Children(i).Data
                                Case "MATERIALCODE" : z2366.MaterialCode = Children(i).Data
                                Case "COLORNAME" : z2366.ColorName = Children(i).Data
                                Case "CDUNITMATERIAL" : z2366.cdUnitMaterial = Children(i).Data
                                Case "SEUNITMATERIAL" : z2366.seUnitMaterial = Children(i).Data
                                Case "SEDEPARTMENT" : z2366.seDepartment = Children(i).Data
                                Case "SELINEPROD" : z2366.seLineProd = Children(i).Data
                                Case "SESUBPROCESS" : z2366.seSubProcess = Children(i).Data
                                Case "CDDEPARTMENT" : z2366.cdDepartment = Children(i).Data
                                Case "CDLINEPROD" : z2366.cdLineProd = Children(i).Data
                                Case "CDSUBPROCESS" : z2366.cdSubProcess = Children(i).Data
                                Case "INCHARGERECEIPT" : z2366.InchargeReceipt = Children(i).Data
                                Case "TIMERECEIPT" : z2366.TimeReceipt = Children(i).Data
                                Case "DATERECEPT" : z2366.DateRecept = Children(i).Data
                                Case "PRICERECEIPT" : z2366.PriceReceipt = Children(i).Data
                                Case "QTYOUTBOUND" : z2366.QtyOutbound = Children(i).Data
                                Case "QTYRECEIPT" : z2366.QtyReceipt = Children(i).Data
                                Case "QTYPRODUCTION" : z2366.QtyProduction = Children(i).Data
                                Case "REMARK" : z2366.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2366_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K2366_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z2366 As T2366_AREA, Job As String, CheckClear As Boolean, AUTOKEY As Long, PRODDATE As String, PRODSEQ As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K2366_MOVE = False

        Try
            If READ_PFK2366(AUTOKEY, PRODDATE, PRODSEQ) = True Then
                z2366 = D2366
                K2366_MOVE = True
            Else
                If CheckClear = True Then z2366 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2366")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z2366.Autokey = Children(i).Code
                                Case "PRODDATE" : z2366.ProdDate = Children(i).Code
                                Case "PRODSEQ" : z2366.ProdSeq = Children(i).Code
                                Case "FACTORDERNO" : z2366.FactOrderNo = Children(i).Code
                                Case "FACTORDERSEQ" : z2366.FactOrderSeq = Children(i).Code
                                Case "JOBCARD" : z2366.JobCard = Children(i).Code
                                Case "MATERIALCODE" : z2366.MaterialCode = Children(i).Code
                                Case "COLORNAME" : z2366.ColorName = Children(i).Code
                                Case "CDUNITMATERIAL" : z2366.cdUnitMaterial = Children(i).Code
                                Case "SEUNITMATERIAL" : z2366.seUnitMaterial = Children(i).Code
                                Case "SEDEPARTMENT" : z2366.seDepartment = Children(i).Code
                                Case "SELINEPROD" : z2366.seLineProd = Children(i).Code
                                Case "SESUBPROCESS" : z2366.seSubProcess = Children(i).Code
                                Case "CDDEPARTMENT" : z2366.cdDepartment = Children(i).Code
                                Case "CDLINEPROD" : z2366.cdLineProd = Children(i).Code
                                Case "CDSUBPROCESS" : z2366.cdSubProcess = Children(i).Code
                                Case "INCHARGERECEIPT" : z2366.InchargeReceipt = Children(i).Code
                                Case "TIMERECEIPT" : z2366.TimeReceipt = Children(i).Code
                                Case "DATERECEPT" : z2366.DateRecept = Children(i).Code
                                Case "PRICERECEIPT" : z2366.PriceReceipt = Children(i).Code
                                Case "QTYOUTBOUND" : z2366.QtyOutbound = Children(i).Code
                                Case "QTYRECEIPT" : z2366.QtyReceipt = Children(i).Code
                                Case "QTYPRODUCTION" : z2366.QtyProduction = Children(i).Code
                                Case "REMARK" : z2366.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z2366.Autokey = Children(i).Data
                                Case "PRODDATE" : z2366.ProdDate = Children(i).Data
                                Case "PRODSEQ" : z2366.ProdSeq = Children(i).Data
                                Case "FACTORDERNO" : z2366.FactOrderNo = Children(i).Data
                                Case "FACTORDERSEQ" : z2366.FactOrderSeq = Children(i).Data
                                Case "JOBCARD" : z2366.JobCard = Children(i).Data
                                Case "MATERIALCODE" : z2366.MaterialCode = Children(i).Data
                                Case "COLORNAME" : z2366.ColorName = Children(i).Data
                                Case "CDUNITMATERIAL" : z2366.cdUnitMaterial = Children(i).Data
                                Case "SEUNITMATERIAL" : z2366.seUnitMaterial = Children(i).Data
                                Case "SEDEPARTMENT" : z2366.seDepartment = Children(i).Data
                                Case "SELINEPROD" : z2366.seLineProd = Children(i).Data
                                Case "SESUBPROCESS" : z2366.seSubProcess = Children(i).Data
                                Case "CDDEPARTMENT" : z2366.cdDepartment = Children(i).Data
                                Case "CDLINEPROD" : z2366.cdLineProd = Children(i).Data
                                Case "CDSUBPROCESS" : z2366.cdSubProcess = Children(i).Data
                                Case "INCHARGERECEIPT" : z2366.InchargeReceipt = Children(i).Data
                                Case "TIMERECEIPT" : z2366.TimeReceipt = Children(i).Data
                                Case "DATERECEPT" : z2366.DateRecept = Children(i).Data
                                Case "PRICERECEIPT" : z2366.PriceReceipt = Children(i).Data
                                Case "QTYOUTBOUND" : z2366.QtyOutbound = Children(i).Data
                                Case "QTYRECEIPT" : z2366.QtyReceipt = Children(i).Data
                                Case "QTYPRODUCTION" : z2366.QtyProduction = Children(i).Data
                                Case "REMARK" : z2366.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2366_MOVE", vbCritical)
        End Try
    End Function

End Module
