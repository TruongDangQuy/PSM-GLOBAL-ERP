'=========================================================================================================================================================
'   TABLE : (PFK0128)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K0128

    Structure T0128_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public SpecNo As String  '			char(9)		*
        Public SpecNoSeq As String  '			char(3)		*
        Public ProcessSeq As Double  '			decimal		*
        Public JobSeq As Double  '			decimal		*
        Public Dseq As Double  '			decimal
        Public MaterialSeq As Double  '			decimal
        Public seShoesStatus As String  '			char(3)
        Public cdShoesStatus As String  '			char(3)
        Public Price As Double  '			decimal
        Public MaterialAMT As Double  '			decimal
        Public seSpecialProcess As String  '			char(3)
        Public cdSpecialProcess As String  '			char(3)
        Public CheckWidth As String  '			char(1)
        Public Width As String  '			nvarchar(20)
        Public seUnitMaterial As String  '			char(3)
        Public cdUnitMaterial As String  '			char(3)
        Public selGroupComponent As String  '			char(3)
        Public cdGroupComponent As String  '			char(3)
        Public ComponentName As String  '			nvarchar(50)
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

    Public D0128 As T0128_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK0128(SPECNO As String, SPECNOSEQ As String, PROCESSSEQ As Double, JOBSEQ As Double) As Boolean
        READ_PFK0128 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK0128 "
            SQL = SQL & " WHERE K0128_SpecNo		 = '" & SpecNo & "' "
            SQL = SQL & "   AND K0128_SpecNoSeq		 = '" & SpecNoSeq & "' "
            SQL = SQL & "   AND K0128_ProcessSeq		 =  " & ProcessSeq & "  "
            SQL = SQL & "   AND K0128_JobSeq		 =  " & JobSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D0128_CLEAR() : GoTo SKIP_READ_PFK0128

            Call K0128_MOVE(rd)
            READ_PFK0128 = True

SKIP_READ_PFK0128:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK0128", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK0128(SPECNO As String, SPECNOSEQ As String, PROCESSSEQ As Double, JOBSEQ As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK0128 "
            SQL = SQL & " WHERE K0128_SpecNo		 = '" & SpecNo & "' "
            SQL = SQL & "   AND K0128_SpecNoSeq		 = '" & SpecNoSeq & "' "
            SQL = SQL & "   AND K0128_ProcessSeq		 =  " & ProcessSeq & "  "
            SQL = SQL & "   AND K0128_JobSeq		 =  " & JobSeq & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK0128", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK0128(z0128 As T0128_AREA) As Boolean
        WRITE_PFK0128 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z0128)

            SQL = " INSERT INTO PFK0128 "
            SQL = SQL & " ( "
            SQL = SQL & " K0128_SpecNo,"
            SQL = SQL & " K0128_SpecNoSeq,"
            SQL = SQL & " K0128_ProcessSeq,"
            SQL = SQL & " K0128_JobSeq,"
            SQL = SQL & " K0128_Dseq,"
            SQL = SQL & " K0128_MaterialSeq,"
            SQL = SQL & " K0128_seShoesStatus,"
            SQL = SQL & " K0128_cdShoesStatus,"
            SQL = SQL & " K0128_Price,"
            SQL = SQL & " K0128_MaterialAMT,"
            SQL = SQL & " K0128_seSpecialProcess,"
            SQL = SQL & " K0128_cdSpecialProcess,"
            SQL = SQL & " K0128_CheckWidth,"
            SQL = SQL & " K0128_Width,"
            SQL = SQL & " K0128_seUnitMaterial,"
            SQL = SQL & " K0128_cdUnitMaterial,"
            SQL = SQL & " K0128_selGroupComponent,"
            SQL = SQL & " K0128_cdGroupComponent,"
            SQL = SQL & " K0128_ComponentName,"
            SQL = SQL & " K0128_seGroupJobProcess,"
            SQL = SQL & " K0128_cdGroupJobProcess,"
            SQL = SQL & " K0128_cdJobProcess,"
            SQL = SQL & " K0128_tpJobProcess,"
            SQL = SQL & " K0128_PositionName,"
            SQL = SQL & " K0128_Description,"
            SQL = SQL & " K0128_MaterialCode,"
            SQL = SQL & " K0128_SupplierCode,"
            SQL = SQL & " K0128_Standard1,"
            SQL = SQL & " K0128_Standard2,"
            SQL = SQL & " K0128_Standard3,"
            SQL = SQL & " K0128_Standard4,"
            SQL = SQL & " K0128_Standard5,"
            SQL = SQL & " K0128_Standard6,"
            SQL = SQL & " K0128_Standard7,"
            SQL = SQL & " K0128_Standard8,"
            SQL = SQL & " K0128_Standard9,"
            SQL = SQL & " K0128_Standard10,"
            SQL = SQL & " K0128_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z0128.SpecNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0128.SpecNoSeq) & "', "
            SQL = SQL & "   " & FormatSQL(z0128.ProcessSeq) & ", "
            SQL = SQL & "   " & FormatSQL(z0128.JobSeq) & ", "
            SQL = SQL & "   " & FormatSQL(z0128.Dseq) & ", "
            SQL = SQL & "   " & FormatSQL(z0128.MaterialSeq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0128.seShoesStatus) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0128.cdShoesStatus) & "', "
            SQL = SQL & "   " & FormatSQL(z0128.Price) & ", "
            SQL = SQL & "   " & FormatSQL(z0128.MaterialAMT) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0128.seSpecialProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0128.cdSpecialProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0128.CheckWidth) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0128.Width) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0128.seUnitMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0128.cdUnitMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0128.selGroupComponent) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0128.cdGroupComponent) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0128.ComponentName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0128.seGroupJobProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0128.cdGroupJobProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0128.cdJobProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0128.tpJobProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0128.PositionName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0128.Description) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0128.MaterialCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0128.SupplierCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0128.Standard1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0128.Standard2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0128.Standard3) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0128.Standard4) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0128.Standard5) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0128.Standard6) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0128.Standard7) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0128.Standard8) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0128.Standard9) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0128.Standard10) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0128.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK0128 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK0128", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK0128(z0128 As T0128_AREA) As Boolean
        REWRITE_PFK0128 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z0128)

            SQL = " UPDATE PFK0128 SET "
            SQL = SQL & "    K0128_Dseq      =  " & FormatSQL(z0128.Dseq) & ", "
            SQL = SQL & "    K0128_MaterialSeq      =  " & FormatSQL(z0128.MaterialSeq) & ", "
            SQL = SQL & "    K0128_seShoesStatus      = N'" & FormatSQL(z0128.seShoesStatus) & "', "
            SQL = SQL & "    K0128_cdShoesStatus      = N'" & FormatSQL(z0128.cdShoesStatus) & "', "
            SQL = SQL & "    K0128_Price      =  " & FormatSQL(z0128.Price) & ", "
            SQL = SQL & "    K0128_MaterialAMT      =  " & FormatSQL(z0128.MaterialAMT) & ", "
            SQL = SQL & "    K0128_seSpecialProcess      = N'" & FormatSQL(z0128.seSpecialProcess) & "', "
            SQL = SQL & "    K0128_cdSpecialProcess      = N'" & FormatSQL(z0128.cdSpecialProcess) & "', "
            SQL = SQL & "    K0128_CheckWidth      = N'" & FormatSQL(z0128.CheckWidth) & "', "
            SQL = SQL & "    K0128_Width      = N'" & FormatSQL(z0128.Width) & "', "
            SQL = SQL & "    K0128_seUnitMaterial      = N'" & FormatSQL(z0128.seUnitMaterial) & "', "
            SQL = SQL & "    K0128_cdUnitMaterial      = N'" & FormatSQL(z0128.cdUnitMaterial) & "', "
            SQL = SQL & "    K0128_selGroupComponent      = N'" & FormatSQL(z0128.selGroupComponent) & "', "
            SQL = SQL & "    K0128_cdGroupComponent      = N'" & FormatSQL(z0128.cdGroupComponent) & "', "
            SQL = SQL & "    K0128_ComponentName      = N'" & FormatSQL(z0128.ComponentName) & "', "
            SQL = SQL & "    K0128_seGroupJobProcess      = N'" & FormatSQL(z0128.seGroupJobProcess) & "', "
            SQL = SQL & "    K0128_cdGroupJobProcess      = N'" & FormatSQL(z0128.cdGroupJobProcess) & "', "
            SQL = SQL & "    K0128_cdJobProcess      = N'" & FormatSQL(z0128.cdJobProcess) & "', "
            SQL = SQL & "    K0128_tpJobProcess      = N'" & FormatSQL(z0128.tpJobProcess) & "', "
            SQL = SQL & "    K0128_PositionName      = N'" & FormatSQL(z0128.PositionName) & "', "
            SQL = SQL & "    K0128_Description      = N'" & FormatSQL(z0128.Description) & "', "
            SQL = SQL & "    K0128_MaterialCode      = N'" & FormatSQL(z0128.MaterialCode) & "', "
            SQL = SQL & "    K0128_SupplierCode      = N'" & FormatSQL(z0128.SupplierCode) & "', "
            SQL = SQL & "    K0128_Standard1      = N'" & FormatSQL(z0128.Standard1) & "', "
            SQL = SQL & "    K0128_Standard2      = N'" & FormatSQL(z0128.Standard2) & "', "
            SQL = SQL & "    K0128_Standard3      = N'" & FormatSQL(z0128.Standard3) & "', "
            SQL = SQL & "    K0128_Standard4      = N'" & FormatSQL(z0128.Standard4) & "', "
            SQL = SQL & "    K0128_Standard5      = N'" & FormatSQL(z0128.Standard5) & "', "
            SQL = SQL & "    K0128_Standard6      = N'" & FormatSQL(z0128.Standard6) & "', "
            SQL = SQL & "    K0128_Standard7      = N'" & FormatSQL(z0128.Standard7) & "', "
            SQL = SQL & "    K0128_Standard8      = N'" & FormatSQL(z0128.Standard8) & "', "
            SQL = SQL & "    K0128_Standard9      = N'" & FormatSQL(z0128.Standard9) & "', "
            SQL = SQL & "    K0128_Standard10      = N'" & FormatSQL(z0128.Standard10) & "', "
            SQL = SQL & "    K0128_Remark      = N'" & FormatSQL(z0128.Remark) & "'  "
            SQL = SQL & " WHERE K0128_SpecNo		 = '" & z0128.SpecNo & "' "
            SQL = SQL & "   AND K0128_SpecNoSeq		 = '" & z0128.SpecNoSeq & "' "
            SQL = SQL & "   AND K0128_ProcessSeq		 =  " & z0128.ProcessSeq & "  "
            SQL = SQL & "   AND K0128_JobSeq		 =  " & z0128.JobSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK0128 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK0128", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK0128(z0128 As T0128_AREA) As Boolean
        DELETE_PFK0128 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK0128 "
            SQL = SQL & " WHERE K0128_SpecNo		 = '" & z0128.SpecNo & "' "
            SQL = SQL & "   AND K0128_SpecNoSeq		 = '" & z0128.SpecNoSeq & "' "
            SQL = SQL & "   AND K0128_ProcessSeq		 =  " & z0128.ProcessSeq & "  "
            SQL = SQL & "   AND K0128_JobSeq		 =  " & z0128.JobSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK0128 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK0128", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D0128_CLEAR()
        Try

            D0128.SpecNo = ""
            D0128.SpecNoSeq = ""
            D0128.ProcessSeq = 0
            D0128.JobSeq = 0
            D0128.Dseq = 0
            D0128.MaterialSeq = 0
            D0128.seShoesStatus = ""
            D0128.cdShoesStatus = ""
            D0128.Price = 0
            D0128.MaterialAMT = 0
            D0128.seSpecialProcess = ""
            D0128.cdSpecialProcess = ""
            D0128.CheckWidth = ""
            D0128.Width = ""
            D0128.seUnitMaterial = ""
            D0128.cdUnitMaterial = ""
            D0128.selGroupComponent = ""
            D0128.cdGroupComponent = ""
            D0128.ComponentName = ""
            D0128.seGroupJobProcess = ""
            D0128.cdGroupJobProcess = ""
            D0128.cdJobProcess = ""
            D0128.tpJobProcess = ""
            D0128.PositionName = ""
            D0128.Description = ""
            D0128.MaterialCode = ""
            D0128.SupplierCode = ""
            D0128.Standard1 = ""
            D0128.Standard2 = ""
            D0128.Standard3 = ""
            D0128.Standard4 = ""
            D0128.Standard5 = ""
            D0128.Standard6 = ""
            D0128.Standard7 = ""
            D0128.Standard8 = ""
            D0128.Standard9 = ""
            D0128.Standard10 = ""
            D0128.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D0128_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x0128 As T0128_AREA)
        Try

            x0128.SpecNo = trim$(x0128.SpecNo)
            x0128.SpecNoSeq = trim$(x0128.SpecNoSeq)
            x0128.ProcessSeq = trim$(x0128.ProcessSeq)
            x0128.JobSeq = trim$(x0128.JobSeq)
            x0128.Dseq = trim$(x0128.Dseq)
            x0128.MaterialSeq = trim$(x0128.MaterialSeq)
            x0128.seShoesStatus = trim$(x0128.seShoesStatus)
            x0128.cdShoesStatus = trim$(x0128.cdShoesStatus)
            x0128.Price = trim$(x0128.Price)
            x0128.MaterialAMT = trim$(x0128.MaterialAMT)
            x0128.seSpecialProcess = trim$(x0128.seSpecialProcess)
            x0128.cdSpecialProcess = trim$(x0128.cdSpecialProcess)
            x0128.CheckWidth = trim$(x0128.CheckWidth)
            x0128.Width = trim$(x0128.Width)
            x0128.seUnitMaterial = trim$(x0128.seUnitMaterial)
            x0128.cdUnitMaterial = trim$(x0128.cdUnitMaterial)
            x0128.selGroupComponent = trim$(x0128.selGroupComponent)
            x0128.cdGroupComponent = trim$(x0128.cdGroupComponent)
            x0128.ComponentName = trim$(x0128.ComponentName)
            x0128.seGroupJobProcess = trim$(x0128.seGroupJobProcess)
            x0128.cdGroupJobProcess = trim$(x0128.cdGroupJobProcess)
            x0128.cdJobProcess = trim$(x0128.cdJobProcess)
            x0128.tpJobProcess = trim$(x0128.tpJobProcess)
            x0128.PositionName = trim$(x0128.PositionName)
            x0128.Description = trim$(x0128.Description)
            x0128.MaterialCode = trim$(x0128.MaterialCode)
            x0128.SupplierCode = trim$(x0128.SupplierCode)
            x0128.Standard1 = trim$(x0128.Standard1)
            x0128.Standard2 = trim$(x0128.Standard2)
            x0128.Standard3 = trim$(x0128.Standard3)
            x0128.Standard4 = trim$(x0128.Standard4)
            x0128.Standard5 = trim$(x0128.Standard5)
            x0128.Standard6 = trim$(x0128.Standard6)
            x0128.Standard7 = trim$(x0128.Standard7)
            x0128.Standard8 = trim$(x0128.Standard8)
            x0128.Standard9 = trim$(x0128.Standard9)
            x0128.Standard10 = trim$(x0128.Standard10)
            x0128.Remark = trim$(x0128.Remark)

            If trim$(x0128.SpecNo) = "" Then x0128.SpecNo = Space(1)
            If trim$(x0128.SpecNoSeq) = "" Then x0128.SpecNoSeq = Space(1)
            If trim$(x0128.ProcessSeq) = "" Then x0128.ProcessSeq = 0
            If trim$(x0128.JobSeq) = "" Then x0128.JobSeq = 0
            If trim$(x0128.Dseq) = "" Then x0128.Dseq = 0
            If trim$(x0128.MaterialSeq) = "" Then x0128.MaterialSeq = 0
            If trim$(x0128.seShoesStatus) = "" Then x0128.seShoesStatus = Space(1)
            If trim$(x0128.cdShoesStatus) = "" Then x0128.cdShoesStatus = Space(1)
            If trim$(x0128.Price) = "" Then x0128.Price = 0
            If trim$(x0128.MaterialAMT) = "" Then x0128.MaterialAMT = 0
            If trim$(x0128.seSpecialProcess) = "" Then x0128.seSpecialProcess = Space(1)
            If trim$(x0128.cdSpecialProcess) = "" Then x0128.cdSpecialProcess = Space(1)
            If trim$(x0128.CheckWidth) = "" Then x0128.CheckWidth = Space(1)
            If trim$(x0128.Width) = "" Then x0128.Width = Space(1)
            If trim$(x0128.seUnitMaterial) = "" Then x0128.seUnitMaterial = Space(1)
            If trim$(x0128.cdUnitMaterial) = "" Then x0128.cdUnitMaterial = Space(1)
            If trim$(x0128.selGroupComponent) = "" Then x0128.selGroupComponent = Space(1)
            If trim$(x0128.cdGroupComponent) = "" Then x0128.cdGroupComponent = Space(1)
            If trim$(x0128.ComponentName) = "" Then x0128.ComponentName = Space(1)
            If trim$(x0128.seGroupJobProcess) = "" Then x0128.seGroupJobProcess = Space(1)
            If trim$(x0128.cdGroupJobProcess) = "" Then x0128.cdGroupJobProcess = Space(1)
            If trim$(x0128.cdJobProcess) = "" Then x0128.cdJobProcess = Space(1)
            If trim$(x0128.tpJobProcess) = "" Then x0128.tpJobProcess = Space(1)
            If trim$(x0128.PositionName) = "" Then x0128.PositionName = Space(1)
            If trim$(x0128.Description) = "" Then x0128.Description = Space(1)
            If trim$(x0128.MaterialCode) = "" Then x0128.MaterialCode = Space(1)
            If trim$(x0128.SupplierCode) = "" Then x0128.SupplierCode = Space(1)
            If trim$(x0128.Standard1) = "" Then x0128.Standard1 = Space(1)
            If trim$(x0128.Standard2) = "" Then x0128.Standard2 = Space(1)
            If trim$(x0128.Standard3) = "" Then x0128.Standard3 = Space(1)
            If trim$(x0128.Standard4) = "" Then x0128.Standard4 = Space(1)
            If trim$(x0128.Standard5) = "" Then x0128.Standard5 = Space(1)
            If trim$(x0128.Standard6) = "" Then x0128.Standard6 = Space(1)
            If trim$(x0128.Standard7) = "" Then x0128.Standard7 = Space(1)
            If trim$(x0128.Standard8) = "" Then x0128.Standard8 = Space(1)
            If trim$(x0128.Standard9) = "" Then x0128.Standard9 = Space(1)
            If trim$(x0128.Standard10) = "" Then x0128.Standard10 = Space(1)
            If trim$(x0128.Remark) = "" Then x0128.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K0128_MOVE(rs0128 As SqlClient.SqlDataReader)
        Try

            Call D0128_CLEAR()

            If IsdbNull(rs0128!K0128_SpecNo) = False Then D0128.SpecNo = Trim$(rs0128!K0128_SpecNo)
            If IsdbNull(rs0128!K0128_SpecNoSeq) = False Then D0128.SpecNoSeq = Trim$(rs0128!K0128_SpecNoSeq)
            If IsdbNull(rs0128!K0128_ProcessSeq) = False Then D0128.ProcessSeq = Trim$(rs0128!K0128_ProcessSeq)
            If IsdbNull(rs0128!K0128_JobSeq) = False Then D0128.JobSeq = Trim$(rs0128!K0128_JobSeq)
            If IsdbNull(rs0128!K0128_Dseq) = False Then D0128.Dseq = Trim$(rs0128!K0128_Dseq)
            If IsdbNull(rs0128!K0128_MaterialSeq) = False Then D0128.MaterialSeq = Trim$(rs0128!K0128_MaterialSeq)
            If IsdbNull(rs0128!K0128_seShoesStatus) = False Then D0128.seShoesStatus = Trim$(rs0128!K0128_seShoesStatus)
            If IsdbNull(rs0128!K0128_cdShoesStatus) = False Then D0128.cdShoesStatus = Trim$(rs0128!K0128_cdShoesStatus)
            If IsdbNull(rs0128!K0128_Price) = False Then D0128.Price = Trim$(rs0128!K0128_Price)
            If IsdbNull(rs0128!K0128_MaterialAMT) = False Then D0128.MaterialAMT = Trim$(rs0128!K0128_MaterialAMT)
            If IsdbNull(rs0128!K0128_seSpecialProcess) = False Then D0128.seSpecialProcess = Trim$(rs0128!K0128_seSpecialProcess)
            If IsdbNull(rs0128!K0128_cdSpecialProcess) = False Then D0128.cdSpecialProcess = Trim$(rs0128!K0128_cdSpecialProcess)
            If IsdbNull(rs0128!K0128_CheckWidth) = False Then D0128.CheckWidth = Trim$(rs0128!K0128_CheckWidth)
            If IsdbNull(rs0128!K0128_Width) = False Then D0128.Width = Trim$(rs0128!K0128_Width)
            If IsdbNull(rs0128!K0128_seUnitMaterial) = False Then D0128.seUnitMaterial = Trim$(rs0128!K0128_seUnitMaterial)
            If IsdbNull(rs0128!K0128_cdUnitMaterial) = False Then D0128.cdUnitMaterial = Trim$(rs0128!K0128_cdUnitMaterial)
            If IsdbNull(rs0128!K0128_selGroupComponent) = False Then D0128.selGroupComponent = Trim$(rs0128!K0128_selGroupComponent)
            If IsdbNull(rs0128!K0128_cdGroupComponent) = False Then D0128.cdGroupComponent = Trim$(rs0128!K0128_cdGroupComponent)
            If IsdbNull(rs0128!K0128_ComponentName) = False Then D0128.ComponentName = Trim$(rs0128!K0128_ComponentName)
            If IsdbNull(rs0128!K0128_seGroupJobProcess) = False Then D0128.seGroupJobProcess = Trim$(rs0128!K0128_seGroupJobProcess)
            If IsdbNull(rs0128!K0128_cdGroupJobProcess) = False Then D0128.cdGroupJobProcess = Trim$(rs0128!K0128_cdGroupJobProcess)
            If IsdbNull(rs0128!K0128_cdJobProcess) = False Then D0128.cdJobProcess = Trim$(rs0128!K0128_cdJobProcess)
            If IsdbNull(rs0128!K0128_tpJobProcess) = False Then D0128.tpJobProcess = Trim$(rs0128!K0128_tpJobProcess)
            If IsdbNull(rs0128!K0128_PositionName) = False Then D0128.PositionName = Trim$(rs0128!K0128_PositionName)
            If IsdbNull(rs0128!K0128_Description) = False Then D0128.Description = Trim$(rs0128!K0128_Description)
            If IsdbNull(rs0128!K0128_MaterialCode) = False Then D0128.MaterialCode = Trim$(rs0128!K0128_MaterialCode)
            If IsdbNull(rs0128!K0128_SupplierCode) = False Then D0128.SupplierCode = Trim$(rs0128!K0128_SupplierCode)
            If IsdbNull(rs0128!K0128_Standard1) = False Then D0128.Standard1 = Trim$(rs0128!K0128_Standard1)
            If IsdbNull(rs0128!K0128_Standard2) = False Then D0128.Standard2 = Trim$(rs0128!K0128_Standard2)
            If IsdbNull(rs0128!K0128_Standard3) = False Then D0128.Standard3 = Trim$(rs0128!K0128_Standard3)
            If IsdbNull(rs0128!K0128_Standard4) = False Then D0128.Standard4 = Trim$(rs0128!K0128_Standard4)
            If IsdbNull(rs0128!K0128_Standard5) = False Then D0128.Standard5 = Trim$(rs0128!K0128_Standard5)
            If IsdbNull(rs0128!K0128_Standard6) = False Then D0128.Standard6 = Trim$(rs0128!K0128_Standard6)
            If IsdbNull(rs0128!K0128_Standard7) = False Then D0128.Standard7 = Trim$(rs0128!K0128_Standard7)
            If IsdbNull(rs0128!K0128_Standard8) = False Then D0128.Standard8 = Trim$(rs0128!K0128_Standard8)
            If IsdbNull(rs0128!K0128_Standard9) = False Then D0128.Standard9 = Trim$(rs0128!K0128_Standard9)
            If IsdbNull(rs0128!K0128_Standard10) = False Then D0128.Standard10 = Trim$(rs0128!K0128_Standard10)
            If IsdbNull(rs0128!K0128_Remark) = False Then D0128.Remark = Trim$(rs0128!K0128_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K0128_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K0128_MOVE(rs0128 As DataRow)
        Try

            Call D0128_CLEAR()

            If IsdbNull(rs0128!K0128_SpecNo) = False Then D0128.SpecNo = Trim$(rs0128!K0128_SpecNo)
            If IsdbNull(rs0128!K0128_SpecNoSeq) = False Then D0128.SpecNoSeq = Trim$(rs0128!K0128_SpecNoSeq)
            If IsdbNull(rs0128!K0128_ProcessSeq) = False Then D0128.ProcessSeq = Trim$(rs0128!K0128_ProcessSeq)
            If IsdbNull(rs0128!K0128_JobSeq) = False Then D0128.JobSeq = Trim$(rs0128!K0128_JobSeq)
            If IsdbNull(rs0128!K0128_Dseq) = False Then D0128.Dseq = Trim$(rs0128!K0128_Dseq)
            If IsdbNull(rs0128!K0128_MaterialSeq) = False Then D0128.MaterialSeq = Trim$(rs0128!K0128_MaterialSeq)
            If IsdbNull(rs0128!K0128_seShoesStatus) = False Then D0128.seShoesStatus = Trim$(rs0128!K0128_seShoesStatus)
            If IsdbNull(rs0128!K0128_cdShoesStatus) = False Then D0128.cdShoesStatus = Trim$(rs0128!K0128_cdShoesStatus)
            If IsdbNull(rs0128!K0128_Price) = False Then D0128.Price = Trim$(rs0128!K0128_Price)
            If IsdbNull(rs0128!K0128_MaterialAMT) = False Then D0128.MaterialAMT = Trim$(rs0128!K0128_MaterialAMT)
            If IsdbNull(rs0128!K0128_seSpecialProcess) = False Then D0128.seSpecialProcess = Trim$(rs0128!K0128_seSpecialProcess)
            If IsdbNull(rs0128!K0128_cdSpecialProcess) = False Then D0128.cdSpecialProcess = Trim$(rs0128!K0128_cdSpecialProcess)
            If IsdbNull(rs0128!K0128_CheckWidth) = False Then D0128.CheckWidth = Trim$(rs0128!K0128_CheckWidth)
            If IsdbNull(rs0128!K0128_Width) = False Then D0128.Width = Trim$(rs0128!K0128_Width)
            If IsdbNull(rs0128!K0128_seUnitMaterial) = False Then D0128.seUnitMaterial = Trim$(rs0128!K0128_seUnitMaterial)
            If IsdbNull(rs0128!K0128_cdUnitMaterial) = False Then D0128.cdUnitMaterial = Trim$(rs0128!K0128_cdUnitMaterial)
            If IsdbNull(rs0128!K0128_selGroupComponent) = False Then D0128.selGroupComponent = Trim$(rs0128!K0128_selGroupComponent)
            If IsdbNull(rs0128!K0128_cdGroupComponent) = False Then D0128.cdGroupComponent = Trim$(rs0128!K0128_cdGroupComponent)
            If IsdbNull(rs0128!K0128_ComponentName) = False Then D0128.ComponentName = Trim$(rs0128!K0128_ComponentName)
            If IsdbNull(rs0128!K0128_seGroupJobProcess) = False Then D0128.seGroupJobProcess = Trim$(rs0128!K0128_seGroupJobProcess)
            If IsdbNull(rs0128!K0128_cdGroupJobProcess) = False Then D0128.cdGroupJobProcess = Trim$(rs0128!K0128_cdGroupJobProcess)
            If IsdbNull(rs0128!K0128_cdJobProcess) = False Then D0128.cdJobProcess = Trim$(rs0128!K0128_cdJobProcess)
            If IsdbNull(rs0128!K0128_tpJobProcess) = False Then D0128.tpJobProcess = Trim$(rs0128!K0128_tpJobProcess)
            If IsdbNull(rs0128!K0128_PositionName) = False Then D0128.PositionName = Trim$(rs0128!K0128_PositionName)
            If IsdbNull(rs0128!K0128_Description) = False Then D0128.Description = Trim$(rs0128!K0128_Description)
            If IsdbNull(rs0128!K0128_MaterialCode) = False Then D0128.MaterialCode = Trim$(rs0128!K0128_MaterialCode)
            If IsdbNull(rs0128!K0128_SupplierCode) = False Then D0128.SupplierCode = Trim$(rs0128!K0128_SupplierCode)
            If IsdbNull(rs0128!K0128_Standard1) = False Then D0128.Standard1 = Trim$(rs0128!K0128_Standard1)
            If IsdbNull(rs0128!K0128_Standard2) = False Then D0128.Standard2 = Trim$(rs0128!K0128_Standard2)
            If IsdbNull(rs0128!K0128_Standard3) = False Then D0128.Standard3 = Trim$(rs0128!K0128_Standard3)
            If IsdbNull(rs0128!K0128_Standard4) = False Then D0128.Standard4 = Trim$(rs0128!K0128_Standard4)
            If IsdbNull(rs0128!K0128_Standard5) = False Then D0128.Standard5 = Trim$(rs0128!K0128_Standard5)
            If IsdbNull(rs0128!K0128_Standard6) = False Then D0128.Standard6 = Trim$(rs0128!K0128_Standard6)
            If IsdbNull(rs0128!K0128_Standard7) = False Then D0128.Standard7 = Trim$(rs0128!K0128_Standard7)
            If IsdbNull(rs0128!K0128_Standard8) = False Then D0128.Standard8 = Trim$(rs0128!K0128_Standard8)
            If IsdbNull(rs0128!K0128_Standard9) = False Then D0128.Standard9 = Trim$(rs0128!K0128_Standard9)
            If IsdbNull(rs0128!K0128_Standard10) = False Then D0128.Standard10 = Trim$(rs0128!K0128_Standard10)
            If IsdbNull(rs0128!K0128_Remark) = False Then D0128.Remark = Trim$(rs0128!K0128_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K0128_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K0128_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z0128 As T0128_AREA, SPECNO As String, SPECNOSEQ As String, PROCESSSEQ As Double, JOBSEQ As Double) As Boolean

        K0128_MOVE = False

        Try
            If READ_PFK0128(SPECNO, SPECNOSEQ, PROCESSSEQ, JOBSEQ) = True Then
                z0128 = D0128
                K0128_MOVE = True
            Else
                z0128 = Nothing
            End If

            If getColumIndex(spr, "SpecNo") > -1 Then z0128.SpecNo = getDataM(spr, getColumIndex(spr, "SpecNo"), xRow)
            If getColumIndex(spr, "SpecNoSeq") > -1 Then z0128.SpecNoSeq = getDataM(spr, getColumIndex(spr, "SpecNoSeq"), xRow)
            If getColumIndex(spr, "ProcessSeq") > -1 Then z0128.ProcessSeq = getDataM(spr, getColumIndex(spr, "ProcessSeq"), xRow)
            If getColumIndex(spr, "JobSeq") > -1 Then z0128.JobSeq = getDataM(spr, getColumIndex(spr, "JobSeq"), xRow)
            If getColumIndex(spr, "Dseq") > -1 Then z0128.Dseq = getDataM(spr, getColumIndex(spr, "Dseq"), xRow)
            If getColumIndex(spr, "MaterialSeq") > -1 Then z0128.MaterialSeq = getDataM(spr, getColumIndex(spr, "MaterialSeq"), xRow)
            If getColumIndex(spr, "seShoesStatus") > -1 Then z0128.seShoesStatus = getDataM(spr, getColumIndex(spr, "seShoesStatus"), xRow)
            If getColumIndex(spr, "cdShoesStatus") > -1 Then z0128.cdShoesStatus = getDataM(spr, getColumIndex(spr, "cdShoesStatus"), xRow)
            If getColumIndex(spr, "Price") > -1 Then z0128.Price = getDataM(spr, getColumIndex(spr, "Price"), xRow)
            If getColumIndex(spr, "MaterialAMT") > -1 Then z0128.MaterialAMT = getDataM(spr, getColumIndex(spr, "MaterialAMT"), xRow)
            If getColumIndex(spr, "seSpecialProcess") > -1 Then z0128.seSpecialProcess = getDataM(spr, getColumIndex(spr, "seSpecialProcess"), xRow)
            If getColumIndex(spr, "cdSpecialProcess") > -1 Then z0128.cdSpecialProcess = getDataM(spr, getColumIndex(spr, "cdSpecialProcess"), xRow)
            If getColumIndex(spr, "CheckWidth") > -1 Then z0128.CheckWidth = getDataM(spr, getColumIndex(spr, "CheckWidth"), xRow)
            If getColumIndex(spr, "Width") > -1 Then z0128.Width = getDataM(spr, getColumIndex(spr, "Width"), xRow)
            If getColumIndex(spr, "seUnitMaterial") > -1 Then z0128.seUnitMaterial = getDataM(spr, getColumIndex(spr, "seUnitMaterial"), xRow)
            If getColumIndex(spr, "cdUnitMaterial") > -1 Then z0128.cdUnitMaterial = getDataM(spr, getColumIndex(spr, "cdUnitMaterial"), xRow)
            If getColumIndex(spr, "selGroupComponent") > -1 Then z0128.selGroupComponent = getDataM(spr, getColumIndex(spr, "selGroupComponent"), xRow)
            If getColumIndex(spr, "cdGroupComponent") > -1 Then z0128.cdGroupComponent = getDataM(spr, getColumIndex(spr, "cdGroupComponent"), xRow)
            If getColumIndex(spr, "ComponentName") > -1 Then z0128.ComponentName = getDataM(spr, getColumIndex(spr, "ComponentName"), xRow)
            If getColumIndex(spr, "seGroupJobProcess") > -1 Then z0128.seGroupJobProcess = getDataM(spr, getColumIndex(spr, "seGroupJobProcess"), xRow)
            If getColumIndex(spr, "cdGroupJobProcess") > -1 Then z0128.cdGroupJobProcess = getDataM(spr, getColumIndex(spr, "cdGroupJobProcess"), xRow)
            If getColumIndex(spr, "cdJobProcess") > -1 Then z0128.cdJobProcess = getDataM(spr, getColumIndex(spr, "cdJobProcess"), xRow)
            If getColumIndex(spr, "tpJobProcess") > -1 Then z0128.tpJobProcess = getDataM(spr, getColumIndex(spr, "tpJobProcess"), xRow)
            If getColumIndex(spr, "PositionName") > -1 Then z0128.PositionName = getDataM(spr, getColumIndex(spr, "PositionName"), xRow)
            If getColumIndex(spr, "Description") > -1 Then z0128.Description = getDataM(spr, getColumIndex(spr, "Description"), xRow)
            If getColumIndex(spr, "MaterialCode") > -1 Then z0128.MaterialCode = getDataM(spr, getColumIndex(spr, "MaterialCode"), xRow)
            If getColumIndex(spr, "SupplierCode") > -1 Then z0128.SupplierCode = getDataM(spr, getColumIndex(spr, "SupplierCode"), xRow)
            If getColumIndex(spr, "Standard1") > -1 Then z0128.Standard1 = getDataM(spr, getColumIndex(spr, "Standard1"), xRow)
            If getColumIndex(spr, "Standard2") > -1 Then z0128.Standard2 = getDataM(spr, getColumIndex(spr, "Standard2"), xRow)
            If getColumIndex(spr, "Standard3") > -1 Then z0128.Standard3 = getDataM(spr, getColumIndex(spr, "Standard3"), xRow)
            If getColumIndex(spr, "Standard4") > -1 Then z0128.Standard4 = getDataM(spr, getColumIndex(spr, "Standard4"), xRow)
            If getColumIndex(spr, "Standard5") > -1 Then z0128.Standard5 = getDataM(spr, getColumIndex(spr, "Standard5"), xRow)
            If getColumIndex(spr, "Standard6") > -1 Then z0128.Standard6 = getDataM(spr, getColumIndex(spr, "Standard6"), xRow)
            If getColumIndex(spr, "Standard7") > -1 Then z0128.Standard7 = getDataM(spr, getColumIndex(spr, "Standard7"), xRow)
            If getColumIndex(spr, "Standard8") > -1 Then z0128.Standard8 = getDataM(spr, getColumIndex(spr, "Standard8"), xRow)
            If getColumIndex(spr, "Standard9") > -1 Then z0128.Standard9 = getDataM(spr, getColumIndex(spr, "Standard9"), xRow)
            If getColumIndex(spr, "Standard10") > -1 Then z0128.Standard10 = getDataM(spr, getColumIndex(spr, "Standard10"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z0128.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K0128_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K0128_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z0128 As T0128_AREA, CheckClear As Boolean, SPECNO As String, SPECNOSEQ As String, PROCESSSEQ As Double, JOBSEQ As Double) As Boolean

        K0128_MOVE = False

        Try
            If READ_PFK0128(SPECNO, SPECNOSEQ, PROCESSSEQ, JOBSEQ) = True Then
                z0128 = D0128
                K0128_MOVE = True
            Else
                If CheckClear = True Then z0128 = Nothing
            End If

            If getColumIndex(spr, "SpecNo") > -1 Then z0128.SpecNo = getDataM(spr, getColumIndex(spr, "SpecNo"), xRow)
            If getColumIndex(spr, "SpecNoSeq") > -1 Then z0128.SpecNoSeq = getDataM(spr, getColumIndex(spr, "SpecNoSeq"), xRow)
            If getColumIndex(spr, "ProcessSeq") > -1 Then z0128.ProcessSeq = getDataM(spr, getColumIndex(spr, "ProcessSeq"), xRow)
            If getColumIndex(spr, "JobSeq") > -1 Then z0128.JobSeq = getDataM(spr, getColumIndex(spr, "JobSeq"), xRow)
            If getColumIndex(spr, "Dseq") > -1 Then z0128.Dseq = getDataM(spr, getColumIndex(spr, "Dseq"), xRow)
            If getColumIndex(spr, "MaterialSeq") > -1 Then z0128.MaterialSeq = getDataM(spr, getColumIndex(spr, "MaterialSeq"), xRow)
            If getColumIndex(spr, "seShoesStatus") > -1 Then z0128.seShoesStatus = getDataM(spr, getColumIndex(spr, "seShoesStatus"), xRow)
            If getColumIndex(spr, "cdShoesStatus") > -1 Then z0128.cdShoesStatus = getDataM(spr, getColumIndex(spr, "cdShoesStatus"), xRow)
            If getColumIndex(spr, "Price") > -1 Then z0128.Price = getDataM(spr, getColumIndex(spr, "Price"), xRow)
            If getColumIndex(spr, "MaterialAMT") > -1 Then z0128.MaterialAMT = getDataM(spr, getColumIndex(spr, "MaterialAMT"), xRow)
            If getColumIndex(spr, "seSpecialProcess") > -1 Then z0128.seSpecialProcess = getDataM(spr, getColumIndex(spr, "seSpecialProcess"), xRow)
            If getColumIndex(spr, "cdSpecialProcess") > -1 Then z0128.cdSpecialProcess = getDataM(spr, getColumIndex(spr, "cdSpecialProcess"), xRow)
            If getColumIndex(spr, "CheckWidth") > -1 Then z0128.CheckWidth = getDataM(spr, getColumIndex(spr, "CheckWidth"), xRow)
            If getColumIndex(spr, "Width") > -1 Then z0128.Width = getDataM(spr, getColumIndex(spr, "Width"), xRow)
            If getColumIndex(spr, "seUnitMaterial") > -1 Then z0128.seUnitMaterial = getDataM(spr, getColumIndex(spr, "seUnitMaterial"), xRow)
            If getColumIndex(spr, "cdUnitMaterial") > -1 Then z0128.cdUnitMaterial = getDataM(spr, getColumIndex(spr, "cdUnitMaterial"), xRow)
            If getColumIndex(spr, "selGroupComponent") > -1 Then z0128.selGroupComponent = getDataM(spr, getColumIndex(spr, "selGroupComponent"), xRow)
            If getColumIndex(spr, "cdGroupComponent") > -1 Then z0128.cdGroupComponent = getDataM(spr, getColumIndex(spr, "cdGroupComponent"), xRow)
            If getColumIndex(spr, "ComponentName") > -1 Then z0128.ComponentName = getDataM(spr, getColumIndex(spr, "ComponentName"), xRow)
            If getColumIndex(spr, "seGroupJobProcess") > -1 Then z0128.seGroupJobProcess = getDataM(spr, getColumIndex(spr, "seGroupJobProcess"), xRow)
            If getColumIndex(spr, "cdGroupJobProcess") > -1 Then z0128.cdGroupJobProcess = getDataM(spr, getColumIndex(spr, "cdGroupJobProcess"), xRow)
            If getColumIndex(spr, "cdJobProcess") > -1 Then z0128.cdJobProcess = getDataM(spr, getColumIndex(spr, "cdJobProcess"), xRow)
            If getColumIndex(spr, "tpJobProcess") > -1 Then z0128.tpJobProcess = getDataM(spr, getColumIndex(spr, "tpJobProcess"), xRow)
            If getColumIndex(spr, "PositionName") > -1 Then z0128.PositionName = getDataM(spr, getColumIndex(spr, "PositionName"), xRow)
            If getColumIndex(spr, "Description") > -1 Then z0128.Description = getDataM(spr, getColumIndex(spr, "Description"), xRow)
            If getColumIndex(spr, "MaterialCode") > -1 Then z0128.MaterialCode = getDataM(spr, getColumIndex(spr, "MaterialCode"), xRow)
            If getColumIndex(spr, "SupplierCode") > -1 Then z0128.SupplierCode = getDataM(spr, getColumIndex(spr, "SupplierCode"), xRow)
            If getColumIndex(spr, "Standard1") > -1 Then z0128.Standard1 = getDataM(spr, getColumIndex(spr, "Standard1"), xRow)
            If getColumIndex(spr, "Standard2") > -1 Then z0128.Standard2 = getDataM(spr, getColumIndex(spr, "Standard2"), xRow)
            If getColumIndex(spr, "Standard3") > -1 Then z0128.Standard3 = getDataM(spr, getColumIndex(spr, "Standard3"), xRow)
            If getColumIndex(spr, "Standard4") > -1 Then z0128.Standard4 = getDataM(spr, getColumIndex(spr, "Standard4"), xRow)
            If getColumIndex(spr, "Standard5") > -1 Then z0128.Standard5 = getDataM(spr, getColumIndex(spr, "Standard5"), xRow)
            If getColumIndex(spr, "Standard6") > -1 Then z0128.Standard6 = getDataM(spr, getColumIndex(spr, "Standard6"), xRow)
            If getColumIndex(spr, "Standard7") > -1 Then z0128.Standard7 = getDataM(spr, getColumIndex(spr, "Standard7"), xRow)
            If getColumIndex(spr, "Standard8") > -1 Then z0128.Standard8 = getDataM(spr, getColumIndex(spr, "Standard8"), xRow)
            If getColumIndex(spr, "Standard9") > -1 Then z0128.Standard9 = getDataM(spr, getColumIndex(spr, "Standard9"), xRow)
            If getColumIndex(spr, "Standard10") > -1 Then z0128.Standard10 = getDataM(spr, getColumIndex(spr, "Standard10"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z0128.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K0128_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K0128_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z0128 As T0128_AREA, Job As String, SPECNO As String, SPECNOSEQ As String, PROCESSSEQ As Double, JOBSEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K0128_MOVE = False

        Try
            If READ_PFK0128(SPECNO, SPECNOSEQ, PROCESSSEQ, JOBSEQ) = True Then
                z0128 = D0128
                K0128_MOVE = True
            Else
                z0128 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0128")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "SPECNO" : z0128.SpecNo = Children(i).Code
                                Case "SPECNOSEQ" : z0128.SpecNoSeq = Children(i).Code
                                Case "PROCESSSEQ" : z0128.ProcessSeq = Children(i).Code
                                Case "JOBSEQ" : z0128.JobSeq = Children(i).Code
                                Case "DSEQ" : z0128.Dseq = Children(i).Code
                                Case "MATERIALSEQ" : z0128.MaterialSeq = Children(i).Code
                                Case "SESHOESSTATUS" : z0128.seShoesStatus = Children(i).Code
                                Case "CDSHOESSTATUS" : z0128.cdShoesStatus = Children(i).Code
                                Case "PRICE" : z0128.Price = Children(i).Code
                                Case "MATERIALAMT" : z0128.MaterialAMT = Children(i).Code
                                Case "SESPECIALPROCESS" : z0128.seSpecialProcess = Children(i).Code
                                Case "CDSPECIALPROCESS" : z0128.cdSpecialProcess = Children(i).Code
                                Case "CHECKWIDTH" : z0128.CheckWidth = Children(i).Code
                                Case "WIDTH" : z0128.Width = Children(i).Code
                                Case "SEUNITMATERIAL" : z0128.seUnitMaterial = Children(i).Code
                                Case "CDUNITMATERIAL" : z0128.cdUnitMaterial = Children(i).Code
                                Case "SELGROUPCOMPONENT" : z0128.selGroupComponent = Children(i).Code
                                Case "CDGROUPCOMPONENT" : z0128.cdGroupComponent = Children(i).Code
                                Case "COMPONENTNAME" : z0128.ComponentName = Children(i).Code
                                Case "SEGROUPJOBPROCESS" : z0128.seGroupJobProcess = Children(i).Code
                                Case "CDGROUPJOBPROCESS" : z0128.cdGroupJobProcess = Children(i).Code
                                Case "CDJOBPROCESS" : z0128.cdJobProcess = Children(i).Code
                                Case "TPJOBPROCESS" : z0128.tpJobProcess = Children(i).Code
                                Case "POSITIONNAME" : z0128.PositionName = Children(i).Code
                                Case "DESCRIPTION" : z0128.Description = Children(i).Code
                                Case "MATERIALCODE" : z0128.MaterialCode = Children(i).Code
                                Case "SUPPLIERCODE" : z0128.SupplierCode = Children(i).Code
                                Case "STANDARD1" : z0128.Standard1 = Children(i).Code
                                Case "STANDARD2" : z0128.Standard2 = Children(i).Code
                                Case "STANDARD3" : z0128.Standard3 = Children(i).Code
                                Case "STANDARD4" : z0128.Standard4 = Children(i).Code
                                Case "STANDARD5" : z0128.Standard5 = Children(i).Code
                                Case "STANDARD6" : z0128.Standard6 = Children(i).Code
                                Case "STANDARD7" : z0128.Standard7 = Children(i).Code
                                Case "STANDARD8" : z0128.Standard8 = Children(i).Code
                                Case "STANDARD9" : z0128.Standard9 = Children(i).Code
                                Case "STANDARD10" : z0128.Standard10 = Children(i).Code
                                Case "REMARK" : z0128.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "SPECNO" : z0128.SpecNo = Children(i).Data
                                Case "SPECNOSEQ" : z0128.SpecNoSeq = Children(i).Data
                                Case "PROCESSSEQ" : z0128.ProcessSeq = Children(i).Data
                                Case "JOBSEQ" : z0128.JobSeq = Children(i).Data
                                Case "DSEQ" : z0128.Dseq = Children(i).Data
                                Case "MATERIALSEQ" : z0128.MaterialSeq = Children(i).Data
                                Case "SESHOESSTATUS" : z0128.seShoesStatus = Children(i).Data
                                Case "CDSHOESSTATUS" : z0128.cdShoesStatus = Children(i).Data
                                Case "PRICE" : z0128.Price = Children(i).Data
                                Case "MATERIALAMT" : z0128.MaterialAMT = Children(i).Data
                                Case "SESPECIALPROCESS" : z0128.seSpecialProcess = Children(i).Data
                                Case "CDSPECIALPROCESS" : z0128.cdSpecialProcess = Children(i).Data
                                Case "CHECKWIDTH" : z0128.CheckWidth = Children(i).Data
                                Case "WIDTH" : z0128.Width = Children(i).Data
                                Case "SEUNITMATERIAL" : z0128.seUnitMaterial = Children(i).Data
                                Case "CDUNITMATERIAL" : z0128.cdUnitMaterial = Children(i).Data
                                Case "SELGROUPCOMPONENT" : z0128.selGroupComponent = Children(i).Data
                                Case "CDGROUPCOMPONENT" : z0128.cdGroupComponent = Children(i).Data
                                Case "COMPONENTNAME" : z0128.ComponentName = Children(i).Data
                                Case "SEGROUPJOBPROCESS" : z0128.seGroupJobProcess = Children(i).Data
                                Case "CDGROUPJOBPROCESS" : z0128.cdGroupJobProcess = Children(i).Data
                                Case "CDJOBPROCESS" : z0128.cdJobProcess = Children(i).Data
                                Case "TPJOBPROCESS" : z0128.tpJobProcess = Children(i).Data
                                Case "POSITIONNAME" : z0128.PositionName = Children(i).Data
                                Case "DESCRIPTION" : z0128.Description = Children(i).Data
                                Case "MATERIALCODE" : z0128.MaterialCode = Children(i).Data
                                Case "SUPPLIERCODE" : z0128.SupplierCode = Children(i).Data
                                Case "STANDARD1" : z0128.Standard1 = Children(i).Data
                                Case "STANDARD2" : z0128.Standard2 = Children(i).Data
                                Case "STANDARD3" : z0128.Standard3 = Children(i).Data
                                Case "STANDARD4" : z0128.Standard4 = Children(i).Data
                                Case "STANDARD5" : z0128.Standard5 = Children(i).Data
                                Case "STANDARD6" : z0128.Standard6 = Children(i).Data
                                Case "STANDARD7" : z0128.Standard7 = Children(i).Data
                                Case "STANDARD8" : z0128.Standard8 = Children(i).Data
                                Case "STANDARD9" : z0128.Standard9 = Children(i).Data
                                Case "STANDARD10" : z0128.Standard10 = Children(i).Data
                                Case "REMARK" : z0128.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K0128_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K0128_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z0128 As T0128_AREA, Job As String, CheckClear As Boolean, SPECNO As String, SPECNOSEQ As String, PROCESSSEQ As Double, JOBSEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K0128_MOVE = False

        Try
            If READ_PFK0128(SPECNO, SPECNOSEQ, PROCESSSEQ, JOBSEQ) = True Then
                z0128 = D0128
                K0128_MOVE = True
            Else
                If CheckClear = True Then z0128 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0128")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "SPECNO" : z0128.SpecNo = Children(i).Code
                                Case "SPECNOSEQ" : z0128.SpecNoSeq = Children(i).Code
                                Case "PROCESSSEQ" : z0128.ProcessSeq = Children(i).Code
                                Case "JOBSEQ" : z0128.JobSeq = Children(i).Code
                                Case "DSEQ" : z0128.Dseq = Children(i).Code
                                Case "MATERIALSEQ" : z0128.MaterialSeq = Children(i).Code
                                Case "SESHOESSTATUS" : z0128.seShoesStatus = Children(i).Code
                                Case "CDSHOESSTATUS" : z0128.cdShoesStatus = Children(i).Code
                                Case "PRICE" : z0128.Price = Children(i).Code
                                Case "MATERIALAMT" : z0128.MaterialAMT = Children(i).Code
                                Case "SESPECIALPROCESS" : z0128.seSpecialProcess = Children(i).Code
                                Case "CDSPECIALPROCESS" : z0128.cdSpecialProcess = Children(i).Code
                                Case "CHECKWIDTH" : z0128.CheckWidth = Children(i).Code
                                Case "WIDTH" : z0128.Width = Children(i).Code
                                Case "SEUNITMATERIAL" : z0128.seUnitMaterial = Children(i).Code
                                Case "CDUNITMATERIAL" : z0128.cdUnitMaterial = Children(i).Code
                                Case "SELGROUPCOMPONENT" : z0128.selGroupComponent = Children(i).Code
                                Case "CDGROUPCOMPONENT" : z0128.cdGroupComponent = Children(i).Code
                                Case "COMPONENTNAME" : z0128.ComponentName = Children(i).Code
                                Case "SEGROUPJOBPROCESS" : z0128.seGroupJobProcess = Children(i).Code
                                Case "CDGROUPJOBPROCESS" : z0128.cdGroupJobProcess = Children(i).Code
                                Case "CDJOBPROCESS" : z0128.cdJobProcess = Children(i).Code
                                Case "TPJOBPROCESS" : z0128.tpJobProcess = Children(i).Code
                                Case "POSITIONNAME" : z0128.PositionName = Children(i).Code
                                Case "DESCRIPTION" : z0128.Description = Children(i).Code
                                Case "MATERIALCODE" : z0128.MaterialCode = Children(i).Code
                                Case "SUPPLIERCODE" : z0128.SupplierCode = Children(i).Code
                                Case "STANDARD1" : z0128.Standard1 = Children(i).Code
                                Case "STANDARD2" : z0128.Standard2 = Children(i).Code
                                Case "STANDARD3" : z0128.Standard3 = Children(i).Code
                                Case "STANDARD4" : z0128.Standard4 = Children(i).Code
                                Case "STANDARD5" : z0128.Standard5 = Children(i).Code
                                Case "STANDARD6" : z0128.Standard6 = Children(i).Code
                                Case "STANDARD7" : z0128.Standard7 = Children(i).Code
                                Case "STANDARD8" : z0128.Standard8 = Children(i).Code
                                Case "STANDARD9" : z0128.Standard9 = Children(i).Code
                                Case "STANDARD10" : z0128.Standard10 = Children(i).Code
                                Case "REMARK" : z0128.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "SPECNO" : z0128.SpecNo = Children(i).Data
                                Case "SPECNOSEQ" : z0128.SpecNoSeq = Children(i).Data
                                Case "PROCESSSEQ" : z0128.ProcessSeq = Children(i).Data
                                Case "JOBSEQ" : z0128.JobSeq = Children(i).Data
                                Case "DSEQ" : z0128.Dseq = Children(i).Data
                                Case "MATERIALSEQ" : z0128.MaterialSeq = Children(i).Data
                                Case "SESHOESSTATUS" : z0128.seShoesStatus = Children(i).Data
                                Case "CDSHOESSTATUS" : z0128.cdShoesStatus = Children(i).Data
                                Case "PRICE" : z0128.Price = Children(i).Data
                                Case "MATERIALAMT" : z0128.MaterialAMT = Children(i).Data
                                Case "SESPECIALPROCESS" : z0128.seSpecialProcess = Children(i).Data
                                Case "CDSPECIALPROCESS" : z0128.cdSpecialProcess = Children(i).Data
                                Case "CHECKWIDTH" : z0128.CheckWidth = Children(i).Data
                                Case "WIDTH" : z0128.Width = Children(i).Data
                                Case "SEUNITMATERIAL" : z0128.seUnitMaterial = Children(i).Data
                                Case "CDUNITMATERIAL" : z0128.cdUnitMaterial = Children(i).Data
                                Case "SELGROUPCOMPONENT" : z0128.selGroupComponent = Children(i).Data
                                Case "CDGROUPCOMPONENT" : z0128.cdGroupComponent = Children(i).Data
                                Case "COMPONENTNAME" : z0128.ComponentName = Children(i).Data
                                Case "SEGROUPJOBPROCESS" : z0128.seGroupJobProcess = Children(i).Data
                                Case "CDGROUPJOBPROCESS" : z0128.cdGroupJobProcess = Children(i).Data
                                Case "CDJOBPROCESS" : z0128.cdJobProcess = Children(i).Data
                                Case "TPJOBPROCESS" : z0128.tpJobProcess = Children(i).Data
                                Case "POSITIONNAME" : z0128.PositionName = Children(i).Data
                                Case "DESCRIPTION" : z0128.Description = Children(i).Data
                                Case "MATERIALCODE" : z0128.MaterialCode = Children(i).Data
                                Case "SUPPLIERCODE" : z0128.SupplierCode = Children(i).Data
                                Case "STANDARD1" : z0128.Standard1 = Children(i).Data
                                Case "STANDARD2" : z0128.Standard2 = Children(i).Data
                                Case "STANDARD3" : z0128.Standard3 = Children(i).Data
                                Case "STANDARD4" : z0128.Standard4 = Children(i).Data
                                Case "STANDARD5" : z0128.Standard5 = Children(i).Data
                                Case "STANDARD6" : z0128.Standard6 = Children(i).Data
                                Case "STANDARD7" : z0128.Standard7 = Children(i).Data
                                Case "STANDARD8" : z0128.Standard8 = Children(i).Data
                                Case "STANDARD9" : z0128.Standard9 = Children(i).Data
                                Case "STANDARD10" : z0128.Standard10 = Children(i).Data
                                Case "REMARK" : z0128.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K0128_MOVE", vbCritical)
        End Try
    End Function

End Module
