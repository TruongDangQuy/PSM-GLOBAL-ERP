'=========================================================================================================================================================
'   TABLE : (PFK7263)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7263

    Structure T7263_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public ContractID As String  '			char(6)		*
        Public ContracSeq As Double  '			decimal		*
        Public Dseq As Double  '			decimal
        Public MaterialCode As String  '			char(6)
        Public ColorName As String  '			nvarchar(200)
        Public ColorCode As String  '			char(6)
        Public CustomerCode As String  '			char(6)
        Public seSite As String  '			char(3)
        Public cdSite As String  '			char(3)
        Public seDepartment As String  '			char(3)
        Public cdDepartment As String  '			char(3)
        Public seFactory As String  '			char(3)
        Public cdFactory As String  '			char(3)
        Public seUnitPacking As String  '			char(3)
        Public cdUnitPacking As String  '			char(3)
        Public QtyMOQ As Double  '			decimal
        Public CONSUMPTION As Double  '			decimal
        Public QtyBasic As Double  '			decimal
        Public UnitBaseCheck As String  '			char(1)
        Public Specification As String  '			char(1)
        Public seUnitMaterial As String  '			char(3)
        Public cdUnitMaterial As String  '			char(3)
        Public PriceMaterialVND As Double  '			decimal
        Public seUnitPrice As String  '			char(3)
        Public cdUnitPrice As String  '			char(3)
        Public PriceMaterialEX As Double  '			decimal
        Public PriceCharge As Double  '			decimal
        Public DateInsert As String  '			char(8)
        Public DateUpdate As String  '			char(8)
        Public InchargeInsert As String  '			char(6)
        Public InchargeUpdate As String  '			char(6)
        Public DateSync As String  '			char(8)
        Public CheckSync As String  '			char(1)
        Public Remark As String  '			nvarchar(1000)
        '=========================================================================================================================================================
    End Structure

    Public D7263 As T7263_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK7263(CONTRACTID As String, CONTRACSEQ As Double) As Boolean
        READ_PFK7263 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7263  "
            SQL = SQL & " WHERE K7263_ContractID		 = '" & ContractID & "' "
            SQL = SQL & "   AND K7263_ContracSeq		 =  " & CONTRACSEQ & "  "


            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7263_CLEAR() : GoTo SKIP_READ_PFK7263

            Call K7263_MOVE(rd)
            READ_PFK7263 = True

SKIP_READ_PFK7263:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7263", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK7263(CONTRACTID As String, CONTRACSEQ As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7263 "
            SQL = SQL & " WHERE K7263_ContractID		 = '" & ContractID & "' "
            SQL = SQL & "   AND K7263_ContracSeq		 =  " & ContracSeq & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK7263", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK7263(z7263 As T7263_AREA) As Boolean
        WRITE_PFK7263 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7263)

            SQL = " INSERT INTO PFK7263 "
            SQL = SQL & " ( "
            SQL = SQL & " K7263_ContractID,"
            SQL = SQL & " K7263_ContracSeq,"
            SQL = SQL & " K7263_Dseq,"
            SQL = SQL & " K7263_MaterialCode,"
            SQL = SQL & " K7263_ColorName,"
            SQL = SQL & " K7263_ColorCode,"
            SQL = SQL & " K7263_CustomerCode,"
            SQL = SQL & " K7263_seSite,"
            SQL = SQL & " K7263_cdSite,"
            SQL = SQL & " K7263_seDepartment,"
            SQL = SQL & " K7263_cdDepartment,"
            SQL = SQL & " K7263_seFactory,"
            SQL = SQL & " K7263_cdFactory,"
            SQL = SQL & " K7263_seUnitPacking,"
            SQL = SQL & " K7263_cdUnitPacking,"
            SQL = SQL & " K7263_QtyMOQ,"
            SQL = SQL & " K7263_CONSUMPTION,"
            SQL = SQL & " K7263_QtyBasic,"
            SQL = SQL & " K7263_UnitBaseCheck,"
            SQL = SQL & " K7263_Specification,"
            SQL = SQL & " K7263_seUnitMaterial,"
            SQL = SQL & " K7263_cdUnitMaterial,"
            SQL = SQL & " K7263_PriceMaterialVND,"
            SQL = SQL & " K7263_seUnitPrice,"
            SQL = SQL & " K7263_cdUnitPrice,"
            SQL = SQL & " K7263_PriceMaterialEX,"
            SQL = SQL & " K7263_PriceCharge,"
            SQL = SQL & " K7263_DateInsert,"
            SQL = SQL & " K7263_DateUpdate,"
            SQL = SQL & " K7263_InchargeInsert,"
            SQL = SQL & " K7263_InchargeUpdate,"
            SQL = SQL & " K7263_DateSync,"
            SQL = SQL & " K7263_CheckSync,"
            SQL = SQL & " K7263_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z7263.ContractID) & "', "
            SQL = SQL & "   " & FormatSQL(z7263.ContracSeq) & ", "
            SQL = SQL & "   " & FormatSQL(z7263.Dseq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7263.MaterialCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7263.ColorName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7263.ColorCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7263.CustomerCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7263.seSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7263.cdSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7263.seDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7263.cdDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7263.seFactory) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7263.cdFactory) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7263.seUnitPacking) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7263.cdUnitPacking) & "', "
            SQL = SQL & "   " & FormatSQL(z7263.QtyMOQ) & ", "
            SQL = SQL & "   " & FormatSQL(z7263.CONSUMPTION) & ", "
            SQL = SQL & "   " & FormatSQL(z7263.QtyBasic) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7263.UnitBaseCheck) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7263.Specification) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7263.seUnitMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7263.cdUnitMaterial) & "', "
            SQL = SQL & "   " & FormatSQL(z7263.PriceMaterialVND) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7263.seUnitPrice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7263.cdUnitPrice) & "', "
            SQL = SQL & "   " & FormatSQL(z7263.PriceMaterialEX) & ", "
            SQL = SQL & "   " & FormatSQL(z7263.PriceCharge) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7263.DateInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7263.DateUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7263.InchargeInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7263.InchargeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7263.DateSync) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7263.CheckSync) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7263.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK7263 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK7263", vbCritical)
        Finally
            Call GetFullInformation("PFK7263", "I", SQL)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK7263(z7263 As T7263_AREA) As Boolean
        REWRITE_PFK7263 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7263)

            SQL = " UPDATE PFK7263 SET "
            SQL = SQL & "    K7263_Dseq      =  " & FormatSQL(z7263.Dseq) & ", "
            SQL = SQL & "    K7263_MaterialCode      = N'" & FormatSQL(z7263.MaterialCode) & "', "
            SQL = SQL & "    K7263_ColorName      = N'" & FormatSQL(z7263.ColorName) & "', "
            SQL = SQL & "    K7263_ColorCode      = N'" & FormatSQL(z7263.ColorCode) & "', "
            SQL = SQL & "    K7263_CustomerCode      = N'" & FormatSQL(z7263.CustomerCode) & "', "
            SQL = SQL & "    K7263_seSite      = N'" & FormatSQL(z7263.seSite) & "', "
            SQL = SQL & "    K7263_cdSite      = N'" & FormatSQL(z7263.cdSite) & "', "
            SQL = SQL & "    K7263_seDepartment      = N'" & FormatSQL(z7263.seDepartment) & "', "
            SQL = SQL & "    K7263_cdDepartment      = N'" & FormatSQL(z7263.cdDepartment) & "', "
            SQL = SQL & "    K7263_seFactory      = N'" & FormatSQL(z7263.seFactory) & "', "
            SQL = SQL & "    K7263_cdFactory      = N'" & FormatSQL(z7263.cdFactory) & "', "
            SQL = SQL & "    K7263_seUnitPacking      = N'" & FormatSQL(z7263.seUnitPacking) & "', "
            SQL = SQL & "    K7263_cdUnitPacking      = N'" & FormatSQL(z7263.cdUnitPacking) & "', "
            SQL = SQL & "    K7263_QtyMOQ      =  " & FormatSQL(z7263.QtyMOQ) & ", "
            SQL = SQL & "    K7263_CONSUMPTION      =  " & FormatSQL(z7263.CONSUMPTION) & ", "
            SQL = SQL & "    K7263_QtyBasic      =  " & FormatSQL(z7263.QtyBasic) & ", "
            SQL = SQL & "    K7263_UnitBaseCheck      = N'" & FormatSQL(z7263.UnitBaseCheck) & "', "
            SQL = SQL & "    K7263_Specification      = N'" & FormatSQL(z7263.Specification) & "', "
            SQL = SQL & "    K7263_seUnitMaterial      = N'" & FormatSQL(z7263.seUnitMaterial) & "', "
            SQL = SQL & "    K7263_cdUnitMaterial      = N'" & FormatSQL(z7263.cdUnitMaterial) & "', "
            SQL = SQL & "    K7263_PriceMaterialVND      =  " & FormatSQL(z7263.PriceMaterialVND) & ", "
            SQL = SQL & "    K7263_seUnitPrice      = N'" & FormatSQL(z7263.seUnitPrice) & "', "
            SQL = SQL & "    K7263_cdUnitPrice      = N'" & FormatSQL(z7263.cdUnitPrice) & "', "
            SQL = SQL & "    K7263_PriceMaterialEX      =  " & FormatSQL(z7263.PriceMaterialEX) & ", "
            SQL = SQL & "    K7263_PriceCharge      =  " & FormatSQL(z7263.PriceCharge) & ", "
            SQL = SQL & "    K7263_DateInsert      = N'" & FormatSQL(z7263.DateInsert) & "', "
            SQL = SQL & "    K7263_DateUpdate      = N'" & FormatSQL(z7263.DateUpdate) & "', "
            SQL = SQL & "    K7263_InchargeInsert      = N'" & FormatSQL(z7263.InchargeInsert) & "', "
            SQL = SQL & "    K7263_InchargeUpdate      = N'" & FormatSQL(z7263.InchargeUpdate) & "', "
            SQL = SQL & "    K7263_DateSync      = N'" & FormatSQL(z7263.DateSync) & "', "
            SQL = SQL & "    K7263_CheckSync      = N'" & FormatSQL(z7263.CheckSync) & "', "
            SQL = SQL & "    K7263_Remark      = N'" & FormatSQL(z7263.Remark) & "'  "
            SQL = SQL & " WHERE K7263_ContractID		 = '" & z7263.ContractID & "' "
            SQL = SQL & "   AND K7263_ContracSeq		 =  " & z7263.ContracSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK7263 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK7263", vbCritical)
        Finally
            Call GetFullInformation("PFK7263", "U", SQL)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK7263(z7263 As T7263_AREA) As Boolean
        DELETE_PFK7263 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7263)

            SQL = " DELETE FROM PFK7263  "
            SQL = SQL & " WHERE K7263_ContractID		 = '" & z7263.ContractID & "' "
            SQL = SQL & "   AND K7263_ContracSeq		 =  " & z7263.ContracSeq & "  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK7263 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK7263", vbCritical)
        Finally
            Call GetFullInformation("PFK7263", "U", SQL)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D7263_CLEAR()
        Try

            D7263.ContractID = ""
            D7263.ContracSeq = 0
            D7263.Dseq = 0
            D7263.MaterialCode = ""
            D7263.ColorName = ""
            D7263.ColorCode = ""
            D7263.CustomerCode = ""
            D7263.seSite = ""
            D7263.cdSite = ""
            D7263.seDepartment = ""
            D7263.cdDepartment = ""
            D7263.seFactory = ""
            D7263.cdFactory = ""
            D7263.seUnitPacking = ""
            D7263.cdUnitPacking = ""
            D7263.QtyMOQ = 0
            D7263.CONSUMPTION = 0
            D7263.QtyBasic = 0
            D7263.UnitBaseCheck = ""
            D7263.Specification = ""
            D7263.seUnitMaterial = ""
            D7263.cdUnitMaterial = ""
            D7263.PriceMaterialVND = 0
            D7263.seUnitPrice = ""
            D7263.cdUnitPrice = ""
            D7263.PriceMaterialEX = 0
            D7263.PriceCharge = 0
            D7263.DateInsert = ""
            D7263.DateUpdate = ""
            D7263.InchargeInsert = ""
            D7263.InchargeUpdate = ""
            D7263.DateSync = ""
            D7263.CheckSync = ""
            D7263.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D7263_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x7263 As T7263_AREA)
        Try

            x7263.ContractID = trim$(x7263.ContractID)
            x7263.ContracSeq = trim$(x7263.ContracSeq)
            x7263.Dseq = trim$(x7263.Dseq)
            x7263.MaterialCode = trim$(x7263.MaterialCode)
            x7263.ColorName = trim$(x7263.ColorName)
            x7263.ColorCode = trim$(x7263.ColorCode)
            x7263.CustomerCode = trim$(x7263.CustomerCode)
            x7263.seSite = trim$(x7263.seSite)
            x7263.cdSite = trim$(x7263.cdSite)
            x7263.seDepartment = trim$(x7263.seDepartment)
            x7263.cdDepartment = trim$(x7263.cdDepartment)
            x7263.seFactory = trim$(x7263.seFactory)
            x7263.cdFactory = trim$(x7263.cdFactory)
            x7263.seUnitPacking = trim$(x7263.seUnitPacking)
            x7263.cdUnitPacking = trim$(x7263.cdUnitPacking)
            x7263.QtyMOQ = Trim$(x7263.QtyMOQ)
            x7263.CONSUMPTION = Trim$(x7263.CONSUMPTION)
            x7263.QtyBasic = trim$(x7263.QtyBasic)
            x7263.UnitBaseCheck = Trim$(x7263.UnitBaseCheck)
            x7263.Specification = Trim$(x7263.Specification)
            x7263.seUnitMaterial = trim$(x7263.seUnitMaterial)
            x7263.cdUnitMaterial = trim$(x7263.cdUnitMaterial)
            x7263.PriceMaterialVND = trim$(x7263.PriceMaterialVND)
            x7263.seUnitPrice = trim$(x7263.seUnitPrice)
            x7263.cdUnitPrice = trim$(x7263.cdUnitPrice)
            x7263.PriceMaterialEX = trim$(x7263.PriceMaterialEX)
            x7263.PriceCharge = trim$(x7263.PriceCharge)
            x7263.DateInsert = trim$(x7263.DateInsert)
            x7263.DateUpdate = trim$(x7263.DateUpdate)
            x7263.InchargeInsert = trim$(x7263.InchargeInsert)
            x7263.InchargeUpdate = trim$(x7263.InchargeUpdate)
            x7263.DateSync = trim$(x7263.DateSync)
            x7263.CheckSync = trim$(x7263.CheckSync)
            x7263.Remark = trim$(x7263.Remark)

            If trim$(x7263.ContractID) = "" Then x7263.ContractID = Space(1)
            If trim$(x7263.ContracSeq) = "" Then x7263.ContracSeq = 0
            If trim$(x7263.Dseq) = "" Then x7263.Dseq = 0
            If trim$(x7263.MaterialCode) = "" Then x7263.MaterialCode = Space(1)
            If trim$(x7263.ColorName) = "" Then x7263.ColorName = Space(1)
            If trim$(x7263.ColorCode) = "" Then x7263.ColorCode = Space(1)
            If trim$(x7263.CustomerCode) = "" Then x7263.CustomerCode = Space(1)
            If trim$(x7263.seSite) = "" Then x7263.seSite = Space(1)
            If trim$(x7263.cdSite) = "" Then x7263.cdSite = Space(1)
            If trim$(x7263.seDepartment) = "" Then x7263.seDepartment = Space(1)
            If trim$(x7263.cdDepartment) = "" Then x7263.cdDepartment = Space(1)
            If trim$(x7263.seFactory) = "" Then x7263.seFactory = Space(1)
            If trim$(x7263.cdFactory) = "" Then x7263.cdFactory = Space(1)
            If trim$(x7263.seUnitPacking) = "" Then x7263.seUnitPacking = Space(1)
            If trim$(x7263.cdUnitPacking) = "" Then x7263.cdUnitPacking = Space(1)
            If Trim$(x7263.QtyMOQ) = "" Then x7263.QtyMOQ = 0
            If Trim$(x7263.CONSUMPTION) = "" Then x7263.CONSUMPTION = 0
            If trim$(x7263.QtyBasic) = "" Then x7263.QtyBasic = 0
            If Trim$(x7263.UnitBaseCheck) = "" Then x7263.UnitBaseCheck = Space(1)
            If Trim$(x7263.Specification) = "" Then x7263.Specification = Space(1)
            If trim$(x7263.seUnitMaterial) = "" Then x7263.seUnitMaterial = Space(1)
            If trim$(x7263.cdUnitMaterial) = "" Then x7263.cdUnitMaterial = Space(1)
            If trim$(x7263.PriceMaterialVND) = "" Then x7263.PriceMaterialVND = 0
            If trim$(x7263.seUnitPrice) = "" Then x7263.seUnitPrice = Space(1)
            If trim$(x7263.cdUnitPrice) = "" Then x7263.cdUnitPrice = Space(1)
            If trim$(x7263.PriceMaterialEX) = "" Then x7263.PriceMaterialEX = 0
            If trim$(x7263.PriceCharge) = "" Then x7263.PriceCharge = 0
            If trim$(x7263.DateInsert) = "" Then x7263.DateInsert = Space(1)
            If trim$(x7263.DateUpdate) = "" Then x7263.DateUpdate = Space(1)
            If trim$(x7263.InchargeInsert) = "" Then x7263.InchargeInsert = Space(1)
            If trim$(x7263.InchargeUpdate) = "" Then x7263.InchargeUpdate = Space(1)
            If trim$(x7263.DateSync) = "" Then x7263.DateSync = Space(1)
            If trim$(x7263.CheckSync) = "" Then x7263.CheckSync = Space(1)
            If trim$(x7263.Remark) = "" Then x7263.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K7263_MOVE(rs7263 As SqlClient.SqlDataReader)
        Try

            Call D7263_CLEAR()

            If IsdbNull(rs7263!K7263_ContractID) = False Then D7263.ContractID = Trim$(rs7263!K7263_ContractID)
            If IsdbNull(rs7263!K7263_ContracSeq) = False Then D7263.ContracSeq = Trim$(rs7263!K7263_ContracSeq)
            If IsdbNull(rs7263!K7263_Dseq) = False Then D7263.Dseq = Trim$(rs7263!K7263_Dseq)
            If IsdbNull(rs7263!K7263_MaterialCode) = False Then D7263.MaterialCode = Trim$(rs7263!K7263_MaterialCode)
            If IsdbNull(rs7263!K7263_ColorName) = False Then D7263.ColorName = Trim$(rs7263!K7263_ColorName)
            If IsdbNull(rs7263!K7263_ColorCode) = False Then D7263.ColorCode = Trim$(rs7263!K7263_ColorCode)
            If IsdbNull(rs7263!K7263_CustomerCode) = False Then D7263.CustomerCode = Trim$(rs7263!K7263_CustomerCode)
            If IsdbNull(rs7263!K7263_seSite) = False Then D7263.seSite = Trim$(rs7263!K7263_seSite)
            If IsdbNull(rs7263!K7263_cdSite) = False Then D7263.cdSite = Trim$(rs7263!K7263_cdSite)
            If IsdbNull(rs7263!K7263_seDepartment) = False Then D7263.seDepartment = Trim$(rs7263!K7263_seDepartment)
            If IsdbNull(rs7263!K7263_cdDepartment) = False Then D7263.cdDepartment = Trim$(rs7263!K7263_cdDepartment)
            If IsdbNull(rs7263!K7263_seFactory) = False Then D7263.seFactory = Trim$(rs7263!K7263_seFactory)
            If IsdbNull(rs7263!K7263_cdFactory) = False Then D7263.cdFactory = Trim$(rs7263!K7263_cdFactory)
            If IsdbNull(rs7263!K7263_seUnitPacking) = False Then D7263.seUnitPacking = Trim$(rs7263!K7263_seUnitPacking)
            If IsdbNull(rs7263!K7263_cdUnitPacking) = False Then D7263.cdUnitPacking = Trim$(rs7263!K7263_cdUnitPacking)
            If IsDBNull(rs7263!K7263_QtyMOQ) = False Then D7263.QtyMOQ = Trim$(rs7263!K7263_QtyMOQ)
            If IsDBNull(rs7263!K7263_CONSUMPTION) = False Then D7263.CONSUMPTION = Trim$(rs7263!K7263_CONSUMPTION)
            If IsdbNull(rs7263!K7263_QtyBasic) = False Then D7263.QtyBasic = Trim$(rs7263!K7263_QtyBasic)
            If IsDBNull(rs7263!K7263_UnitBaseCheck) = False Then D7263.UnitBaseCheck = Trim$(rs7263!K7263_UnitBaseCheck)
            If IsDBNull(rs7263!K7263_Specification) = False Then D7263.Specification = Trim$(rs7263!K7263_Specification)
            If IsdbNull(rs7263!K7263_seUnitMaterial) = False Then D7263.seUnitMaterial = Trim$(rs7263!K7263_seUnitMaterial)
            If IsdbNull(rs7263!K7263_cdUnitMaterial) = False Then D7263.cdUnitMaterial = Trim$(rs7263!K7263_cdUnitMaterial)
            If IsdbNull(rs7263!K7263_PriceMaterialVND) = False Then D7263.PriceMaterialVND = Trim$(rs7263!K7263_PriceMaterialVND)
            If IsdbNull(rs7263!K7263_seUnitPrice) = False Then D7263.seUnitPrice = Trim$(rs7263!K7263_seUnitPrice)
            If IsdbNull(rs7263!K7263_cdUnitPrice) = False Then D7263.cdUnitPrice = Trim$(rs7263!K7263_cdUnitPrice)
            If IsdbNull(rs7263!K7263_PriceMaterialEX) = False Then D7263.PriceMaterialEX = Trim$(rs7263!K7263_PriceMaterialEX)
            If IsdbNull(rs7263!K7263_PriceCharge) = False Then D7263.PriceCharge = Trim$(rs7263!K7263_PriceCharge)
            If IsdbNull(rs7263!K7263_DateInsert) = False Then D7263.DateInsert = Trim$(rs7263!K7263_DateInsert)
            If IsdbNull(rs7263!K7263_DateUpdate) = False Then D7263.DateUpdate = Trim$(rs7263!K7263_DateUpdate)
            If IsdbNull(rs7263!K7263_InchargeInsert) = False Then D7263.InchargeInsert = Trim$(rs7263!K7263_InchargeInsert)
            If IsdbNull(rs7263!K7263_InchargeUpdate) = False Then D7263.InchargeUpdate = Trim$(rs7263!K7263_InchargeUpdate)
            If IsdbNull(rs7263!K7263_DateSync) = False Then D7263.DateSync = Trim$(rs7263!K7263_DateSync)
            If IsdbNull(rs7263!K7263_CheckSync) = False Then D7263.CheckSync = Trim$(rs7263!K7263_CheckSync)
            If IsdbNull(rs7263!K7263_Remark) = False Then D7263.Remark = Trim$(rs7263!K7263_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7263_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K7263_MOVE(rs7263 As DataRow)
        Try

            Call D7263_CLEAR()

            If IsdbNull(rs7263!K7263_ContractID) = False Then D7263.ContractID = Trim$(rs7263!K7263_ContractID)
            If IsdbNull(rs7263!K7263_ContracSeq) = False Then D7263.ContracSeq = Trim$(rs7263!K7263_ContracSeq)
            If IsdbNull(rs7263!K7263_Dseq) = False Then D7263.Dseq = Trim$(rs7263!K7263_Dseq)
            If IsdbNull(rs7263!K7263_MaterialCode) = False Then D7263.MaterialCode = Trim$(rs7263!K7263_MaterialCode)
            If IsdbNull(rs7263!K7263_ColorName) = False Then D7263.ColorName = Trim$(rs7263!K7263_ColorName)
            If IsdbNull(rs7263!K7263_ColorCode) = False Then D7263.ColorCode = Trim$(rs7263!K7263_ColorCode)
            If IsdbNull(rs7263!K7263_CustomerCode) = False Then D7263.CustomerCode = Trim$(rs7263!K7263_CustomerCode)
            If IsdbNull(rs7263!K7263_seSite) = False Then D7263.seSite = Trim$(rs7263!K7263_seSite)
            If IsdbNull(rs7263!K7263_cdSite) = False Then D7263.cdSite = Trim$(rs7263!K7263_cdSite)
            If IsdbNull(rs7263!K7263_seDepartment) = False Then D7263.seDepartment = Trim$(rs7263!K7263_seDepartment)
            If IsdbNull(rs7263!K7263_cdDepartment) = False Then D7263.cdDepartment = Trim$(rs7263!K7263_cdDepartment)
            If IsdbNull(rs7263!K7263_seFactory) = False Then D7263.seFactory = Trim$(rs7263!K7263_seFactory)
            If IsdbNull(rs7263!K7263_cdFactory) = False Then D7263.cdFactory = Trim$(rs7263!K7263_cdFactory)
            If IsdbNull(rs7263!K7263_seUnitPacking) = False Then D7263.seUnitPacking = Trim$(rs7263!K7263_seUnitPacking)
            If IsdbNull(rs7263!K7263_cdUnitPacking) = False Then D7263.cdUnitPacking = Trim$(rs7263!K7263_cdUnitPacking)
            If IsDBNull(rs7263!K7263_QtyMOQ) = False Then D7263.QtyMOQ = Trim$(rs7263!K7263_QtyMOQ)
            If IsDBNull(rs7263!K7263_CONSUMPTION) = False Then D7263.CONSUMPTION = Trim$(rs7263!K7263_CONSUMPTION)
            If IsdbNull(rs7263!K7263_QtyBasic) = False Then D7263.QtyBasic = Trim$(rs7263!K7263_QtyBasic)
            If IsDBNull(rs7263!K7263_UnitBaseCheck) = False Then D7263.UnitBaseCheck = Trim$(rs7263!K7263_UnitBaseCheck)
            If IsDBNull(rs7263!K7263_Specification) = False Then D7263.Specification = Trim$(rs7263!K7263_Specification)
            If IsdbNull(rs7263!K7263_seUnitMaterial) = False Then D7263.seUnitMaterial = Trim$(rs7263!K7263_seUnitMaterial)
            If IsdbNull(rs7263!K7263_cdUnitMaterial) = False Then D7263.cdUnitMaterial = Trim$(rs7263!K7263_cdUnitMaterial)
            If IsdbNull(rs7263!K7263_PriceMaterialVND) = False Then D7263.PriceMaterialVND = Trim$(rs7263!K7263_PriceMaterialVND)
            If IsdbNull(rs7263!K7263_seUnitPrice) = False Then D7263.seUnitPrice = Trim$(rs7263!K7263_seUnitPrice)
            If IsdbNull(rs7263!K7263_cdUnitPrice) = False Then D7263.cdUnitPrice = Trim$(rs7263!K7263_cdUnitPrice)
            If IsdbNull(rs7263!K7263_PriceMaterialEX) = False Then D7263.PriceMaterialEX = Trim$(rs7263!K7263_PriceMaterialEX)
            If IsdbNull(rs7263!K7263_PriceCharge) = False Then D7263.PriceCharge = Trim$(rs7263!K7263_PriceCharge)
            If IsdbNull(rs7263!K7263_DateInsert) = False Then D7263.DateInsert = Trim$(rs7263!K7263_DateInsert)
            If IsdbNull(rs7263!K7263_DateUpdate) = False Then D7263.DateUpdate = Trim$(rs7263!K7263_DateUpdate)
            If IsdbNull(rs7263!K7263_InchargeInsert) = False Then D7263.InchargeInsert = Trim$(rs7263!K7263_InchargeInsert)
            If IsdbNull(rs7263!K7263_InchargeUpdate) = False Then D7263.InchargeUpdate = Trim$(rs7263!K7263_InchargeUpdate)
            If IsdbNull(rs7263!K7263_DateSync) = False Then D7263.DateSync = Trim$(rs7263!K7263_DateSync)
            If IsdbNull(rs7263!K7263_CheckSync) = False Then D7263.CheckSync = Trim$(rs7263!K7263_CheckSync)
            If IsdbNull(rs7263!K7263_Remark) = False Then D7263.Remark = Trim$(rs7263!K7263_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7263_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K7263_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7263 As T7263_AREA, CONTRACTID As String, CONTRACSEQ As Double) As Boolean

        K7263_MOVE = False

        Try
            If READ_PFK7263(CONTRACTID, CONTRACSEQ) = True Then
                z7263 = D7263
                K7263_MOVE = True
            Else
                z7263 = Nothing
            End If

            If getColumnIndex(spr, "ContractID") > -1 Then z7263.ContractID = getDataM(spr, getColumnIndex(spr, "ContractID"), xRow)
            If getColumnIndex(spr, "ContracSeq") > -1 Then z7263.ContracSeq = getDataM(spr, getColumnIndex(spr, "ContracSeq"), xRow)
            If getColumnIndex(spr, "Dseq") > -1 Then z7263.Dseq = getDataM(spr, getColumnIndex(spr, "Dseq"), xRow)
            If getColumnIndex(spr, "MaterialCode") > -1 Then z7263.MaterialCode = getDataM(spr, getColumnIndex(spr, "MaterialCode"), xRow)
            If getColumnIndex(spr, "ColorName") > -1 Then z7263.ColorName = getDataM(spr, getColumnIndex(spr, "ColorName"), xRow)
            If getColumnIndex(spr, "ColorCode") > -1 Then z7263.ColorCode = getDataM(spr, getColumnIndex(spr, "ColorCode"), xRow)
            If getColumnIndex(spr, "CustomerCode") > -1 Then z7263.CustomerCode = getDataM(spr, getColumnIndex(spr, "CustomerCode"), xRow)
            If getColumnIndex(spr, "seSite") > -1 Then z7263.seSite = getDataM(spr, getColumnIndex(spr, "seSite"), xRow)
            If getColumnIndex(spr, "cdSite") > -1 Then z7263.cdSite = getDataM(spr, getColumnIndex(spr, "cdSite"), xRow)
            If getColumnIndex(spr, "seDepartment") > -1 Then z7263.seDepartment = getDataM(spr, getColumnIndex(spr, "seDepartment"), xRow)
            If getColumnIndex(spr, "cdDepartment") > -1 Then z7263.cdDepartment = getDataM(spr, getColumnIndex(spr, "cdDepartment"), xRow)
            If getColumnIndex(spr, "seFactory") > -1 Then z7263.seFactory = getDataM(spr, getColumnIndex(spr, "seFactory"), xRow)
            If getColumnIndex(spr, "cdFactory") > -1 Then z7263.cdFactory = getDataM(spr, getColumnIndex(spr, "cdFactory"), xRow)
            If getColumnIndex(spr, "seUnitPacking") > -1 Then z7263.seUnitPacking = getDataM(spr, getColumnIndex(spr, "seUnitPacking"), xRow)
            If getColumnIndex(spr, "cdUnitPacking") > -1 Then z7263.cdUnitPacking = getDataM(spr, getColumnIndex(spr, "cdUnitPacking"), xRow)
            If getColumnIndex(spr, "QtyMOQ") > -1 Then z7263.QtyMOQ = getDataM(spr, getColumnIndex(spr, "QtyMOQ"), xRow)
            If getColumnIndex(spr, "CONSUMPTION") > -1 Then z7263.CONSUMPTION = getDataM(spr, getColumnIndex(spr, "CONSUMPTION"), xRow)
            If getColumnIndex(spr, "QtyBasic") > -1 Then z7263.QtyBasic = getDataM(spr, getColumnIndex(spr, "QtyBasic"), xRow)
            If getColumnIndex(spr, "UnitBaseCheck") > -1 Then z7263.UnitBaseCheck = getDataM(spr, getColumnIndex(spr, "UnitBaseCheck"), xRow)
            If getColumnIndex(spr, "Specification") > -1 Then z7263.Specification = getDataM(spr, getColumnIndex(spr, "Specification"), xRow)
            If getColumnIndex(spr, "seUnitMaterial") > -1 Then z7263.seUnitMaterial = getDataM(spr, getColumnIndex(spr, "seUnitMaterial"), xRow)
            If getColumnIndex(spr, "cdUnitMaterial") > -1 Then z7263.cdUnitMaterial = getDataM(spr, getColumnIndex(spr, "cdUnitMaterial"), xRow)
            If getColumnIndex(spr, "PriceMaterialVND") > -1 Then z7263.PriceMaterialVND = getDataM(spr, getColumnIndex(spr, "PriceMaterialVND"), xRow)
            If getColumnIndex(spr, "seUnitPrice") > -1 Then z7263.seUnitPrice = getDataM(spr, getColumnIndex(spr, "seUnitPrice"), xRow)
            If getColumnIndex(spr, "cdUnitPrice") > -1 Then z7263.cdUnitPrice = getDataM(spr, getColumnIndex(spr, "cdUnitPrice"), xRow)
            If getColumnIndex(spr, "PriceMaterialEX") > -1 Then z7263.PriceMaterialEX = getDataM(spr, getColumnIndex(spr, "PriceMaterialEX"), xRow)
            If getColumnIndex(spr, "PriceCharge") > -1 Then z7263.PriceCharge = getDataM(spr, getColumnIndex(spr, "PriceCharge"), xRow)
            If getColumnIndex(spr, "DateInsert") > -1 Then z7263.DateInsert = getDataM(spr, getColumnIndex(spr, "DateInsert"), xRow)
            If getColumnIndex(spr, "DateUpdate") > -1 Then z7263.DateUpdate = getDataM(spr, getColumnIndex(spr, "DateUpdate"), xRow)
            If getColumnIndex(spr, "InchargeInsert") > -1 Then z7263.InchargeInsert = getDataM(spr, getColumnIndex(spr, "InchargeInsert"), xRow)
            If getColumnIndex(spr, "InchargeUpdate") > -1 Then z7263.InchargeUpdate = getDataM(spr, getColumnIndex(spr, "InchargeUpdate"), xRow)
            If getColumnIndex(spr, "DateSync") > -1 Then z7263.DateSync = getDataM(spr, getColumnIndex(spr, "DateSync"), xRow)
            If getColumnIndex(spr, "CheckSync") > -1 Then z7263.CheckSync = getDataM(spr, getColumnIndex(spr, "CheckSync"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z7263.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7263_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K7263_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7263 As T7263_AREA, CheckClear As Boolean, CONTRACTID As String, CONTRACSEQ As Double) As Boolean

        K7263_MOVE = False

        Try
            If READ_PFK7263(CONTRACTID, CONTRACSEQ) = True Then
                z7263 = D7263
                K7263_MOVE = True
            Else
                If CheckClear = True Then z7263 = Nothing
            End If

            If getColumnIndex(spr, "ContractID") > -1 Then z7263.ContractID = getDataM(spr, getColumnIndex(spr, "ContractID"), xRow)
            If getColumnIndex(spr, "ContracSeq") > -1 Then z7263.ContracSeq = getDataM(spr, getColumnIndex(spr, "ContracSeq"), xRow)
            If getColumnIndex(spr, "Dseq") > -1 Then z7263.Dseq = getDataM(spr, getColumnIndex(spr, "Dseq"), xRow)
            If getColumnIndex(spr, "MaterialCode") > -1 Then z7263.MaterialCode = getDataM(spr, getColumnIndex(spr, "MaterialCode"), xRow)
            If getColumnIndex(spr, "ColorName") > -1 Then z7263.ColorName = getDataM(spr, getColumnIndex(spr, "ColorName"), xRow)
            If getColumnIndex(spr, "ColorCode") > -1 Then z7263.ColorCode = getDataM(spr, getColumnIndex(spr, "ColorCode"), xRow)
            If getColumnIndex(spr, "CustomerCode") > -1 Then z7263.CustomerCode = getDataM(spr, getColumnIndex(spr, "CustomerCode"), xRow)
            If getColumnIndex(spr, "seSite") > -1 Then z7263.seSite = getDataM(spr, getColumnIndex(spr, "seSite"), xRow)
            If getColumnIndex(spr, "cdSite") > -1 Then z7263.cdSite = getDataM(spr, getColumnIndex(spr, "cdSite"), xRow)
            If getColumnIndex(spr, "seDepartment") > -1 Then z7263.seDepartment = getDataM(spr, getColumnIndex(spr, "seDepartment"), xRow)
            If getColumnIndex(spr, "cdDepartment") > -1 Then z7263.cdDepartment = getDataM(spr, getColumnIndex(spr, "cdDepartment"), xRow)
            If getColumnIndex(spr, "seFactory") > -1 Then z7263.seFactory = getDataM(spr, getColumnIndex(spr, "seFactory"), xRow)
            If getColumnIndex(spr, "cdFactory") > -1 Then z7263.cdFactory = getDataM(spr, getColumnIndex(spr, "cdFactory"), xRow)
            If getColumnIndex(spr, "seUnitPacking") > -1 Then z7263.seUnitPacking = getDataM(spr, getColumnIndex(spr, "seUnitPacking"), xRow)
            If getColumnIndex(spr, "cdUnitPacking") > -1 Then z7263.cdUnitPacking = getDataM(spr, getColumnIndex(spr, "cdUnitPacking"), xRow)
            If getColumnIndex(spr, "QtyMOQ") > -1 Then z7263.QtyMOQ = getDataM(spr, getColumnIndex(spr, "QtyMOQ"), xRow)
            If getColumnIndex(spr, "CONSUMPTION") > -1 Then z7263.CONSUMPTION = getDataM(spr, getColumnIndex(spr, "CONSUMPTION"), xRow)
            If getColumnIndex(spr, "QtyBasic") > -1 Then z7263.QtyBasic = getDataM(spr, getColumnIndex(spr, "QtyBasic"), xRow)
            If getColumnIndex(spr, "UnitBaseCheck") > -1 Then z7263.UnitBaseCheck = getDataM(spr, getColumnIndex(spr, "UnitBaseCheck"), xRow)
            If getColumnIndex(spr, "Specification") > -1 Then z7263.Specification = getDataM(spr, getColumnIndex(spr, "Specification"), xRow)
            If getColumnIndex(spr, "seUnitMaterial") > -1 Then z7263.seUnitMaterial = getDataM(spr, getColumnIndex(spr, "seUnitMaterial"), xRow)
            If getColumnIndex(spr, "cdUnitMaterial") > -1 Then z7263.cdUnitMaterial = getDataM(spr, getColumnIndex(spr, "cdUnitMaterial"), xRow)
            If getColumnIndex(spr, "PriceMaterialVND") > -1 Then z7263.PriceMaterialVND = getDataM(spr, getColumnIndex(spr, "PriceMaterialVND"), xRow)
            If getColumnIndex(spr, "seUnitPrice") > -1 Then z7263.seUnitPrice = getDataM(spr, getColumnIndex(spr, "seUnitPrice"), xRow)
            If getColumnIndex(spr, "cdUnitPrice") > -1 Then z7263.cdUnitPrice = getDataM(spr, getColumnIndex(spr, "cdUnitPrice"), xRow)
            If getColumnIndex(spr, "PriceMaterialEX") > -1 Then z7263.PriceMaterialEX = getDataM(spr, getColumnIndex(spr, "PriceMaterialEX"), xRow)
            If getColumnIndex(spr, "PriceCharge") > -1 Then z7263.PriceCharge = getDataM(spr, getColumnIndex(spr, "PriceCharge"), xRow)
            If getColumnIndex(spr, "DateInsert") > -1 Then z7263.DateInsert = getDataM(spr, getColumnIndex(spr, "DateInsert"), xRow)
            If getColumnIndex(spr, "DateUpdate") > -1 Then z7263.DateUpdate = getDataM(spr, getColumnIndex(spr, "DateUpdate"), xRow)
            If getColumnIndex(spr, "InchargeInsert") > -1 Then z7263.InchargeInsert = getDataM(spr, getColumnIndex(spr, "InchargeInsert"), xRow)
            If getColumnIndex(spr, "InchargeUpdate") > -1 Then z7263.InchargeUpdate = getDataM(spr, getColumnIndex(spr, "InchargeUpdate"), xRow)
            If getColumnIndex(spr, "DateSync") > -1 Then z7263.DateSync = getDataM(spr, getColumnIndex(spr, "DateSync"), xRow)
            If getColumnIndex(spr, "CheckSync") > -1 Then z7263.CheckSync = getDataM(spr, getColumnIndex(spr, "CheckSync"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z7263.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7263_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K7263_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7263 As T7263_AREA, Job As String, CONTRACTID As String, CONTRACSEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7263_MOVE = False

        Try
            If READ_PFK7263(CONTRACTID, CONTRACSEQ) = True Then
                z7263 = D7263
                K7263_MOVE = True
            Else
                z7263 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7263")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "CONTRACTID" : z7263.ContractID = Children(i).Code
                                Case "CONTRACSEQ" : z7263.ContracSeq = Children(i).Code
                                Case "DSEQ" : z7263.Dseq = Children(i).Code
                                Case "MATERIALCODE" : z7263.MaterialCode = Children(i).Code
                                Case "COLORNAME" : z7263.ColorName = Children(i).Code
                                Case "COLORCODE" : z7263.ColorCode = Children(i).Code
                                Case "CUSTOMERCODE" : z7263.CustomerCode = Children(i).Code
                                Case "SESITE" : z7263.seSite = Children(i).Code
                                Case "CDSITE" : z7263.cdSite = Children(i).Code
                                Case "SEDEPARTMENT" : z7263.seDepartment = Children(i).Code
                                Case "CDDEPARTMENT" : z7263.cdDepartment = Children(i).Code
                                Case "SEFACTORY" : z7263.seFactory = Children(i).Code
                                Case "CDFACTORY" : z7263.cdFactory = Children(i).Code
                                Case "SEUNITPACKING" : z7263.seUnitPacking = Children(i).Code
                                Case "CDUNITPACKING" : z7263.cdUnitPacking = Children(i).Code
                                Case "QTYMOQ" : z7263.QtyMOQ = Children(i).Code
                                Case "CONSUMPTION" : z7263.CONSUMPTION = Children(i).Code
                                Case "QTYBASIC" : z7263.QtyBasic = Children(i).Code
                                Case "UNITBASECHECK" : z7263.UnitBaseCheck = Children(i).Code
                                Case "SPECIFICATION" : z7263.Specification = Children(i).Code
                                Case "SEUNITMATERIAL" : z7263.seUnitMaterial = Children(i).Code
                                Case "CDUNITMATERIAL" : z7263.cdUnitMaterial = Children(i).Code
                                Case "PRICEMATERIALVND" : z7263.PriceMaterialVND = Children(i).Code
                                Case "SEUNITPRICE" : z7263.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z7263.cdUnitPrice = Children(i).Code
                                Case "PRICEMATERIALEX" : z7263.PriceMaterialEX = Children(i).Code
                                Case "PRICECHARGE" : z7263.PriceCharge = Children(i).Code
                                Case "DATEINSERT" : z7263.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z7263.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z7263.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z7263.InchargeUpdate = Children(i).Code
                                Case "DATESYNC" : z7263.DateSync = Children(i).Code
                                Case "CHECKSYNC" : z7263.CheckSync = Children(i).Code
                                Case "REMARK" : z7263.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "CONTRACTID" : z7263.ContractID = Children(i).Data
                                Case "CONTRACSEQ" : z7263.ContracSeq = Children(i).Data
                                Case "DSEQ" : z7263.Dseq = Children(i).Data
                                Case "MATERIALCODE" : z7263.MaterialCode = Children(i).Data
                                Case "COLORNAME" : z7263.ColorName = Children(i).Data
                                Case "COLORCODE" : z7263.ColorCode = Children(i).Data
                                Case "CUSTOMERCODE" : z7263.CustomerCode = Children(i).Data
                                Case "SESITE" : z7263.seSite = Children(i).Data
                                Case "CDSITE" : z7263.cdSite = Children(i).Data
                                Case "SEDEPARTMENT" : z7263.seDepartment = Children(i).Data
                                Case "CDDEPARTMENT" : z7263.cdDepartment = Children(i).Data
                                Case "SEFACTORY" : z7263.seFactory = Children(i).Data
                                Case "CDFACTORY" : z7263.cdFactory = Children(i).Data
                                Case "SEUNITPACKING" : z7263.seUnitPacking = Children(i).Data
                                Case "CDUNITPACKING" : z7263.cdUnitPacking = Children(i).Data
                                Case "QTYMOQ" : z7263.QtyMOQ = Children(i).Data
                                Case "CONSUMPTION" : z7263.CONSUMPTION = Children(i).Data
                                Case "QTYBASIC" : z7263.QtyBasic = Children(i).Data
                                Case "UNITBASECHECK" : z7263.UnitBaseCheck = Children(i).Data
                                Case "SPECIFICATION" : z7263.Specification = Children(i).Data
                                Case "SEUNITMATERIAL" : z7263.seUnitMaterial = Children(i).Data
                                Case "CDUNITMATERIAL" : z7263.cdUnitMaterial = Children(i).Data
                                Case "PRICEMATERIALVND" : z7263.PriceMaterialVND = Children(i).Data
                                Case "SEUNITPRICE" : z7263.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z7263.cdUnitPrice = Children(i).Data
                                Case "PRICEMATERIALEX" : z7263.PriceMaterialEX = Children(i).Data
                                Case "PRICECHARGE" : z7263.PriceCharge = Children(i).Data
                                Case "DATEINSERT" : z7263.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z7263.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z7263.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z7263.InchargeUpdate = Children(i).Data
                                Case "DATESYNC" : z7263.DateSync = Children(i).Data
                                Case "CHECKSYNC" : z7263.CheckSync = Children(i).Data
                                Case "REMARK" : z7263.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7263_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K7263_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7263 As T7263_AREA, Job As String, CheckClear As Boolean, CONTRACTID As String, CONTRACSEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7263_MOVE = False

        Try
            If READ_PFK7263(CONTRACTID, CONTRACSEQ) = True Then
                z7263 = D7263
                K7263_MOVE = True
            Else
                If CheckClear = True Then z7263 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7263")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "CONTRACTID" : z7263.ContractID = Children(i).Code
                                Case "CONTRACSEQ" : z7263.ContracSeq = Children(i).Code
                                Case "DSEQ" : z7263.Dseq = Children(i).Code
                                Case "MATERIALCODE" : z7263.MaterialCode = Children(i).Code
                                Case "COLORNAME" : z7263.ColorName = Children(i).Code
                                Case "COLORCODE" : z7263.ColorCode = Children(i).Code
                                Case "CUSTOMERCODE" : z7263.CustomerCode = Children(i).Code
                                Case "SESITE" : z7263.seSite = Children(i).Code
                                Case "CDSITE" : z7263.cdSite = Children(i).Code
                                Case "SEDEPARTMENT" : z7263.seDepartment = Children(i).Code
                                Case "CDDEPARTMENT" : z7263.cdDepartment = Children(i).Code
                                Case "SEFACTORY" : z7263.seFactory = Children(i).Code
                                Case "CDFACTORY" : z7263.cdFactory = Children(i).Code
                                Case "SEUNITPACKING" : z7263.seUnitPacking = Children(i).Code
                                Case "CDUNITPACKING" : z7263.cdUnitPacking = Children(i).Code
                                Case "QTYMOQ" : z7263.QtyMOQ = Children(i).Code
                                Case "CONSUMPTION" : z7263.CONSUMPTION = Children(i).Code
                                Case "QTYBASIC" : z7263.QtyBasic = Children(i).Code
                                Case "UNITBASECHECK" : z7263.UnitBaseCheck = Children(i).Code
                                Case "SPECIFICATION" : z7263.Specification = Children(i).Code
                                Case "SEUNITMATERIAL" : z7263.seUnitMaterial = Children(i).Code
                                Case "CDUNITMATERIAL" : z7263.cdUnitMaterial = Children(i).Code
                                Case "PRICEMATERIALVND" : z7263.PriceMaterialVND = Children(i).Code
                                Case "SEUNITPRICE" : z7263.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z7263.cdUnitPrice = Children(i).Code
                                Case "PRICEMATERIALEX" : z7263.PriceMaterialEX = Children(i).Code
                                Case "PRICECHARGE" : z7263.PriceCharge = Children(i).Code
                                Case "DATEINSERT" : z7263.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z7263.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z7263.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z7263.InchargeUpdate = Children(i).Code
                                Case "DATESYNC" : z7263.DateSync = Children(i).Code
                                Case "CHECKSYNC" : z7263.CheckSync = Children(i).Code
                                Case "REMARK" : z7263.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "CONTRACTID" : z7263.ContractID = Children(i).Data
                                Case "CONTRACSEQ" : z7263.ContracSeq = Children(i).Data
                                Case "DSEQ" : z7263.Dseq = Children(i).Data
                                Case "MATERIALCODE" : z7263.MaterialCode = Children(i).Data
                                Case "COLORNAME" : z7263.ColorName = Children(i).Data
                                Case "COLORCODE" : z7263.ColorCode = Children(i).Data
                                Case "CUSTOMERCODE" : z7263.CustomerCode = Children(i).Data
                                Case "SESITE" : z7263.seSite = Children(i).Data
                                Case "CDSITE" : z7263.cdSite = Children(i).Data
                                Case "SEDEPARTMENT" : z7263.seDepartment = Children(i).Data
                                Case "CDDEPARTMENT" : z7263.cdDepartment = Children(i).Data
                                Case "SEFACTORY" : z7263.seFactory = Children(i).Data
                                Case "CDFACTORY" : z7263.cdFactory = Children(i).Data
                                Case "SEUNITPACKING" : z7263.seUnitPacking = Children(i).Data
                                Case "CDUNITPACKING" : z7263.cdUnitPacking = Children(i).Data
                                Case "QTYMOQ" : z7263.QtyMOQ = Children(i).Data
                                Case "CONSUMPTION" : z7263.CONSUMPTION = Children(i).Data
                                Case "QTYBASIC" : z7263.QtyBasic = Children(i).Data
                                Case "UNITBASECHECK" : z7263.UnitBaseCheck = Children(i).Data
                                Case "SPECIFICATION" : z7263.Specification = Children(i).Data
                                Case "SEUNITMATERIAL" : z7263.seUnitMaterial = Children(i).Data
                                Case "CDUNITMATERIAL" : z7263.cdUnitMaterial = Children(i).Data
                                Case "PRICEMATERIALVND" : z7263.PriceMaterialVND = Children(i).Data
                                Case "SEUNITPRICE" : z7263.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z7263.cdUnitPrice = Children(i).Data
                                Case "PRICEMATERIALEX" : z7263.PriceMaterialEX = Children(i).Data
                                Case "PRICECHARGE" : z7263.PriceCharge = Children(i).Data
                                Case "DATEINSERT" : z7263.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z7263.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z7263.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z7263.InchargeUpdate = Children(i).Data
                                Case "DATESYNC" : z7263.DateSync = Children(i).Data
                                Case "CHECKSYNC" : z7263.CheckSync = Children(i).Data
                                Case "REMARK" : z7263.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7263_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW AREA
    '=========================================================================================================================================================
    Public Sub K7263_MOVE(ByRef a7263 As T7263_AREA, ByRef b7263 As T7263_AREA)
        Try
            If trim$(a7263.ContractID) = "" Then b7263.ContractID = "" Else b7263.ContractID = a7263.ContractID
            If trim$(a7263.ContracSeq) = "" Then b7263.ContracSeq = "" Else b7263.ContracSeq = a7263.ContracSeq
            If trim$(a7263.Dseq) = "" Then b7263.Dseq = "" Else b7263.Dseq = a7263.Dseq
            If trim$(a7263.MaterialCode) = "" Then b7263.MaterialCode = "" Else b7263.MaterialCode = a7263.MaterialCode
            If trim$(a7263.ColorName) = "" Then b7263.ColorName = "" Else b7263.ColorName = a7263.ColorName
            If trim$(a7263.ColorCode) = "" Then b7263.ColorCode = "" Else b7263.ColorCode = a7263.ColorCode
            If trim$(a7263.CustomerCode) = "" Then b7263.CustomerCode = "" Else b7263.CustomerCode = a7263.CustomerCode
            If trim$(a7263.seSite) = "" Then b7263.seSite = "" Else b7263.seSite = a7263.seSite
            If trim$(a7263.cdSite) = "" Then b7263.cdSite = "" Else b7263.cdSite = a7263.cdSite
            If trim$(a7263.seDepartment) = "" Then b7263.seDepartment = "" Else b7263.seDepartment = a7263.seDepartment
            If trim$(a7263.cdDepartment) = "" Then b7263.cdDepartment = "" Else b7263.cdDepartment = a7263.cdDepartment
            If trim$(a7263.seFactory) = "" Then b7263.seFactory = "" Else b7263.seFactory = a7263.seFactory
            If trim$(a7263.cdFactory) = "" Then b7263.cdFactory = "" Else b7263.cdFactory = a7263.cdFactory
            If trim$(a7263.seUnitPacking) = "" Then b7263.seUnitPacking = "" Else b7263.seUnitPacking = a7263.seUnitPacking
            If trim$(a7263.cdUnitPacking) = "" Then b7263.cdUnitPacking = "" Else b7263.cdUnitPacking = a7263.cdUnitPacking
            If Trim$(a7263.QtyMOQ) = "" Then b7263.QtyMOQ = "" Else b7263.QtyMOQ = a7263.QtyMOQ
            If Trim$(a7263.CONSUMPTION) = "" Then b7263.CONSUMPTION = "" Else b7263.CONSUMPTION = a7263.CONSUMPTION
            If trim$(a7263.QtyBasic) = "" Then b7263.QtyBasic = "" Else b7263.QtyBasic = a7263.QtyBasic
            If Trim$(a7263.UnitBaseCheck) = "" Then b7263.UnitBaseCheck = "" Else b7263.UnitBaseCheck = a7263.UnitBaseCheck
            If Trim$(a7263.Specification) = "" Then b7263.Specification = "" Else b7263.Specification = a7263.Specification
            If trim$(a7263.seUnitMaterial) = "" Then b7263.seUnitMaterial = "" Else b7263.seUnitMaterial = a7263.seUnitMaterial
            If trim$(a7263.cdUnitMaterial) = "" Then b7263.cdUnitMaterial = "" Else b7263.cdUnitMaterial = a7263.cdUnitMaterial
            If trim$(a7263.PriceMaterialVND) = "" Then b7263.PriceMaterialVND = "" Else b7263.PriceMaterialVND = a7263.PriceMaterialVND
            If trim$(a7263.seUnitPrice) = "" Then b7263.seUnitPrice = "" Else b7263.seUnitPrice = a7263.seUnitPrice
            If trim$(a7263.cdUnitPrice) = "" Then b7263.cdUnitPrice = "" Else b7263.cdUnitPrice = a7263.cdUnitPrice
            If trim$(a7263.PriceMaterialEX) = "" Then b7263.PriceMaterialEX = "" Else b7263.PriceMaterialEX = a7263.PriceMaterialEX
            If trim$(a7263.PriceCharge) = "" Then b7263.PriceCharge = "" Else b7263.PriceCharge = a7263.PriceCharge
            If trim$(a7263.DateInsert) = "" Then b7263.DateInsert = "" Else b7263.DateInsert = a7263.DateInsert
            If trim$(a7263.DateUpdate) = "" Then b7263.DateUpdate = "" Else b7263.DateUpdate = a7263.DateUpdate
            If trim$(a7263.InchargeInsert) = "" Then b7263.InchargeInsert = "" Else b7263.InchargeInsert = a7263.InchargeInsert
            If trim$(a7263.InchargeUpdate) = "" Then b7263.InchargeUpdate = "" Else b7263.InchargeUpdate = a7263.InchargeUpdate
            If trim$(a7263.DateSync) = "" Then b7263.DateSync = "" Else b7263.DateSync = a7263.DateSync
            If trim$(a7263.CheckSync) = "" Then b7263.CheckSync = "" Else b7263.CheckSync = a7263.CheckSync
            If trim$(a7263.Remark) = "" Then b7263.Remark = "" Else b7263.Remark = a7263.Remark
        Catch ex As Exception
            Call MsgBoxP("K7263_MOVE", vbCritical)
        End Try
    End Sub


End Module
