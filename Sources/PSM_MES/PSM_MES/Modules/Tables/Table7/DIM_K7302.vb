'=========================================================================================================================================================
'   TABLE : (PFK7302)
'
'      WORKER : PSM GLOBAL ., LTD
'       WORK DATE : 2019 NEW
'       DEVELOPER    : MRNLV
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7302

    Structure T7302_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public MaterialBOMCode As String  '			nvarchar(6)		*
        Public MaterialBOMSeq As Double  '			decimal		*
        Public DSeq As Double  '			decimal
        Public seGroupComponent As String  '			char(3)
        Public cdGroupComponent As String  '			char(3)
        Public seComponent As String  '			char(3)
        Public cdComponent As String  '			char(3)
        Public MaterialCode As String  '			char(6)
        Public Description As String  '			nvarchar(200)
        Public Specification As String  '			nvarchar(200)

        Public seMaterialUnit As String  '			char(3)
        Public cdMaterialUnit As String  '			char(3)
        Public seStatus As String  '			char(3)
        Public cdStatus As String  '			char(3)
        Public seDepartment As String  '			char(3)
        Public cdDepartment As String  '			char(3)
        Public SupplierCode As String  '			char(6)
        Public ColorCode As String  '			char(6)
        Public Color As String  '			nvarchar(100)
        Public Qty As Double  '			decimal
        Public PriceMaterial As Double  '			decimal
        Public UnitPrice As String  '			char(3)
        Public Consumption As String  '			nvarchar(200)
        Public Loss As String  '			varchar(10)
        Public Usage As String  '			char(1)
        Public Remark As String  '			nvarchar(200)
        Public seSite As String  '			char(3)
        Public cdSite As String  '			char(3)
        Public DateInsert As String  '			char(8)
        Public DateUpdate As String  '			char(8)
        Public InchargeInsert As String  '			char(8)
        Public InchargeUpdate As String  '			char(8)
        Public TimeUpdate As String  '			char(14)
        Public TimeInsert As String  '			char(14)
        '=========================================================================================================================================================
    End Structure

    Public D7302 As T7302_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK7302(MATERIALBOMCODE As String, MATERIALBOMSEQ As Double) As Boolean
        READ_PFK7302 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7302 "
            SQL = SQL & " WHERE K7302_MaterialBOMCode		 = '" & MaterialBOMCode & "' "
            SQL = SQL & "   AND K7302_MaterialBOMSeq		 =  " & MaterialBOMSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7302_CLEAR() : GoTo SKIP_READ_PFK7302

            Call K7302_MOVE(rd)
            READ_PFK7302 = True

SKIP_READ_PFK7302:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7302", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK7302(MATERIALBOMCODE As String, MATERIALBOMSEQ As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7302 "
            SQL = SQL & " WHERE K7302_MaterialBOMCode		 = '" & MaterialBOMCode & "' "
            SQL = SQL & "   AND K7302_MaterialBOMSeq		 =  " & MaterialBOMSeq & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK7302", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK7302(z7302 As T7302_AREA) As Boolean
        WRITE_PFK7302 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7302)

            SQL = " INSERT INTO PFK7302 "
            SQL = SQL & " ( "
            SQL = SQL & " K7302_MaterialBOMCode,"
            SQL = SQL & " K7302_MaterialBOMSeq,"
            SQL = SQL & " K7302_DSeq,"
            SQL = SQL & " K7302_seGroupComponent,"
            SQL = SQL & " K7302_cdGroupComponent,"
            SQL = SQL & " K7302_seComponent,"
            SQL = SQL & " K7302_cdComponent,"
            SQL = SQL & " K7302_MaterialCode,"
            SQL = SQL & " K7302_Description,"
            SQL = SQL & " K7302_Specification,"

            SQL = SQL & " K7302_seMaterialUnit,"
            SQL = SQL & " K7302_cdMaterialUnit,"
            SQL = SQL & " K7302_seStatus,"
            SQL = SQL & " K7302_cdStatus,"
            SQL = SQL & " K7302_seDepartment,"
            SQL = SQL & " K7302_cdDepartment,"
            SQL = SQL & " K7302_SupplierCode,"
            SQL = SQL & " K7302_ColorCode,"
            SQL = SQL & " K7302_Color,"
            SQL = SQL & " K7302_Qty,"
            SQL = SQL & " K7302_PriceMaterial,"
            SQL = SQL & " K7302_UnitPrice,"
            SQL = SQL & " K7302_Consumption,"
            SQL = SQL & " K7302_Loss,"
            SQL = SQL & " K7302_Usage,"
            SQL = SQL & " K7302_Remark,"
            SQL = SQL & " K7302_seSite,"
            SQL = SQL & " K7302_cdSite,"
            SQL = SQL & " K7302_DateInsert,"
            SQL = SQL & " K7302_DateUpdate,"
            SQL = SQL & " K7302_InchargeInsert,"
            SQL = SQL & " K7302_InchargeUpdate,"
            SQL = SQL & " K7302_TimeUpdate,"
            SQL = SQL & " K7302_TimeInsert "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z7302.MaterialBOMCode) & "', "
            SQL = SQL & "   " & FormatSQL(z7302.MaterialBOMSeq) & ", "
            SQL = SQL & "   " & FormatSQL(z7302.DSeq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7302.seGroupComponent) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7302.cdGroupComponent) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7302.seComponent) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7302.cdComponent) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7302.MaterialCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7302.Description) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7302.Specification) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7302.seMaterialUnit) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7302.cdMaterialUnit) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7302.seStatus) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7302.cdStatus) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7302.seDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7302.cdDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7302.SupplierCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7302.ColorCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7302.Color) & "', "
            SQL = SQL & "   " & FormatSQL(z7302.Qty) & ", "
            SQL = SQL & "   " & FormatSQL(z7302.PriceMaterial) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7302.UnitPrice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7302.Consumption) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7302.Loss) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7302.Usage) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7302.Remark) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7302.seSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7302.cdSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(PUB.DAT) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7302.DateUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(PUB.SAW) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7302.InchargeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7302.TimeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(PUB.TIME) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK7302 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK7302", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK7302(z7302 As T7302_AREA) As Boolean
        REWRITE_PFK7302 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7302)

            SQL = " UPDATE PFK7302 SET "
            SQL = SQL & "    K7302_DSeq      =  " & FormatSQL(z7302.DSeq) & ", "
            SQL = SQL & "    K7302_seGroupComponent      = N'" & FormatSQL(z7302.seGroupComponent) & "', "
            SQL = SQL & "    K7302_cdGroupComponent      = N'" & FormatSQL(z7302.cdGroupComponent) & "', "
            SQL = SQL & "    K7302_seComponent      = N'" & FormatSQL(z7302.seComponent) & "', "
            SQL = SQL & "    K7302_cdComponent      = N'" & FormatSQL(z7302.cdComponent) & "', "
            SQL = SQL & "    K7302_MaterialCode      = N'" & FormatSQL(z7302.MaterialCode) & "', "
            SQL = SQL & "    K7302_Description      = N'" & FormatSQL(z7302.Description) & "', "
            SQL = SQL & "    K7302_Specification      = N'" & FormatSQL(z7302.Specification) & "', "
            SQL = SQL & "    K7302_seMaterialUnit      = N'" & FormatSQL(z7302.seMaterialUnit) & "', "
            SQL = SQL & "    K7302_cdMaterialUnit      = N'" & FormatSQL(z7302.cdMaterialUnit) & "', "
            SQL = SQL & "    K7302_seStatus      = N'" & FormatSQL(z7302.seStatus) & "', "
            SQL = SQL & "    K7302_cdStatus      = N'" & FormatSQL(z7302.cdStatus) & "', "
            SQL = SQL & "    K7302_seDepartment      = N'" & FormatSQL(z7302.seDepartment) & "', "
            SQL = SQL & "    K7302_cdDepartment      = N'" & FormatSQL(z7302.cdDepartment) & "', "
            SQL = SQL & "    K7302_SupplierCode      = N'" & FormatSQL(z7302.SupplierCode) & "', "
            SQL = SQL & "    K7302_ColorCode      = N'" & FormatSQL(z7302.ColorCode) & "', "
            SQL = SQL & "    K7302_Color      = N'" & FormatSQL(z7302.Color) & "', "
            SQL = SQL & "    K7302_Qty      =  " & FormatSQL(z7302.Qty) & ", "
            SQL = SQL & "    K7302_PriceMaterial      =  " & FormatSQL(z7302.PriceMaterial) & ", "
            SQL = SQL & "    K7302_UnitPrice      = N'" & FormatSQL(z7302.UnitPrice) & "', "
            SQL = SQL & "    K7302_Consumption      = N'" & FormatSQL(z7302.Consumption) & "', "
            SQL = SQL & "    K7302_Loss      = N'" & FormatSQL(z7302.Loss) & "', "
            SQL = SQL & "    K7302_Usage      = N'" & FormatSQL(z7302.Usage) & "', "
            SQL = SQL & "    K7302_Remark      = N'" & FormatSQL(z7302.Remark) & "', "
            SQL = SQL & "    K7302_seSite      = N'" & FormatSQL(z7302.seSite) & "', "
            SQL = SQL & "    K7302_cdSite      = N'" & FormatSQL(z7302.cdSite) & "', "
            SQL = SQL & "    K7302_DateInsert      = N'" & FormatSQL(z7302.DateInsert) & "', "
            SQL = SQL & "    K7302_DateUpdate      = N'" & FormatSQL(PUB.DAT) & "', "
            SQL = SQL & "    K7302_InchargeInsert      = N'" & FormatSQL(z7302.InchargeInsert) & "', "
            SQL = SQL & "    K7302_InchargeUpdate      = N'" & FormatSQL(PUB.SAW) & "', "
            SQL = SQL & "    K7302_TimeUpdate      = N'" & FormatSQL(PUB.TIME) & "', "
            SQL = SQL & "    K7302_TimeInsert      = N'" & FormatSQL(z7302.TimeInsert) & "'  "
            SQL = SQL & " WHERE K7302_MaterialBOMCode		 = '" & z7302.MaterialBOMCode & "' "
            SQL = SQL & "   AND K7302_MaterialBOMSeq		 =  " & z7302.MaterialBOMSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()


            REWRITE_PFK7302 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK7302", vbCritical)

        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK7302(z7302 As T7302_AREA) As Boolean
        DELETE_PFK7302 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7302)

            SQL = " DELETE FROM PFK7302  "
            SQL = SQL & " WHERE K7302_MaterialBOMCode		 = '" & z7302.MaterialBOMCode & "' "
            SQL = SQL & "   AND K7302_MaterialBOMSeq		 =  " & z7302.MaterialBOMSeq & "  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK7302 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK7302", vbCritical)
        Finally
            Call GetFullInformation("PFK7302", "D", SQL)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D7302_CLEAR()
        Try

            D7302.MaterialBOMCode = ""
            D7302.MaterialBOMSeq = 0
            D7302.DSeq = 0
            D7302.seGroupComponent = ""
            D7302.cdGroupComponent = ""
            D7302.seComponent = ""
            D7302.cdComponent = ""
            D7302.MaterialCode = ""
            D7302.Description = ""
            D7302.Specification = ""
            D7302.seMaterialUnit = ""
            D7302.cdMaterialUnit = ""
            D7302.seStatus = ""
            D7302.cdStatus = ""
            D7302.seDepartment = ""
            D7302.cdDepartment = ""
            D7302.SupplierCode = ""
            D7302.ColorCode = ""
            D7302.Color = ""
            D7302.Qty = 0
            D7302.PriceMaterial = 0
            D7302.UnitPrice = ""
            D7302.Consumption = ""
            D7302.Loss = ""
            D7302.Usage = ""
            D7302.Remark = ""
            D7302.seSite = ""
            D7302.cdSite = ""
            D7302.DateInsert = ""
            D7302.DateUpdate = ""
            D7302.InchargeInsert = ""
            D7302.InchargeUpdate = ""
            D7302.TimeUpdate = ""
            D7302.TimeInsert = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D7302_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x7302 As T7302_AREA)
        Try

            x7302.MaterialBOMCode = trim$(x7302.MaterialBOMCode)
            x7302.MaterialBOMSeq = trim$(x7302.MaterialBOMSeq)
            x7302.DSeq = trim$(x7302.DSeq)
            x7302.seGroupComponent = trim$(x7302.seGroupComponent)
            x7302.cdGroupComponent = trim$(x7302.cdGroupComponent)
            x7302.seComponent = trim$(x7302.seComponent)
            x7302.cdComponent = trim$(x7302.cdComponent)
            x7302.MaterialCode = trim$(x7302.MaterialCode)
            x7302.Description = Trim$(x7302.Description)
            x7302.Specification = Trim$(x7302.Specification)
            x7302.seMaterialUnit = trim$(x7302.seMaterialUnit)
            x7302.cdMaterialUnit = trim$(x7302.cdMaterialUnit)
            x7302.seStatus = trim$(x7302.seStatus)
            x7302.cdStatus = trim$(x7302.cdStatus)
            x7302.seDepartment = trim$(x7302.seDepartment)
            x7302.cdDepartment = trim$(x7302.cdDepartment)
            x7302.SupplierCode = trim$(x7302.SupplierCode)
            x7302.ColorCode = trim$(x7302.ColorCode)
            x7302.Color = trim$(x7302.Color)
            x7302.Qty = trim$(x7302.Qty)
            x7302.PriceMaterial = trim$(x7302.PriceMaterial)
            x7302.UnitPrice = trim$(x7302.UnitPrice)
            x7302.Consumption = trim$(x7302.Consumption)
            x7302.Loss = trim$(x7302.Loss)
            x7302.Usage = trim$(x7302.Usage)
            x7302.Remark = trim$(x7302.Remark)
            x7302.seSite = trim$(x7302.seSite)
            x7302.cdSite = trim$(x7302.cdSite)
            x7302.DateInsert = trim$(x7302.DateInsert)
            x7302.DateUpdate = trim$(x7302.DateUpdate)
            x7302.InchargeInsert = trim$(x7302.InchargeInsert)
            x7302.InchargeUpdate = trim$(x7302.InchargeUpdate)
            x7302.TimeUpdate = trim$(x7302.TimeUpdate)
            x7302.TimeInsert = trim$(x7302.TimeInsert)

            If trim$(x7302.MaterialBOMCode) = "" Then x7302.MaterialBOMCode = Space(1)
            If trim$(x7302.MaterialBOMSeq) = "" Then x7302.MaterialBOMSeq = 0
            If trim$(x7302.DSeq) = "" Then x7302.DSeq = 0
            If trim$(x7302.seGroupComponent) = "" Then x7302.seGroupComponent = Space(1)
            If trim$(x7302.cdGroupComponent) = "" Then x7302.cdGroupComponent = Space(1)
            If trim$(x7302.seComponent) = "" Then x7302.seComponent = Space(1)
            If trim$(x7302.cdComponent) = "" Then x7302.cdComponent = Space(1)
            If trim$(x7302.MaterialCode) = "" Then x7302.MaterialCode = Space(1)
            If Trim$(x7302.Description) = "" Then x7302.Description = Space(1)
            If Trim$(x7302.Specification) = "" Then x7302.Specification = Space(1)
            If trim$(x7302.seMaterialUnit) = "" Then x7302.seMaterialUnit = Space(1)
            If trim$(x7302.cdMaterialUnit) = "" Then x7302.cdMaterialUnit = Space(1)
            If trim$(x7302.seStatus) = "" Then x7302.seStatus = Space(1)
            If trim$(x7302.cdStatus) = "" Then x7302.cdStatus = Space(1)
            If trim$(x7302.seDepartment) = "" Then x7302.seDepartment = Space(1)
            If trim$(x7302.cdDepartment) = "" Then x7302.cdDepartment = Space(1)
            If trim$(x7302.SupplierCode) = "" Then x7302.SupplierCode = Space(1)
            If trim$(x7302.ColorCode) = "" Then x7302.ColorCode = Space(1)
            If trim$(x7302.Color) = "" Then x7302.Color = Space(1)
            If trim$(x7302.Qty) = "" Then x7302.Qty = 0
            If trim$(x7302.PriceMaterial) = "" Then x7302.PriceMaterial = 0
            If trim$(x7302.UnitPrice) = "" Then x7302.UnitPrice = Space(1)
            If trim$(x7302.Consumption) = "" Then x7302.Consumption = Space(1)
            If trim$(x7302.Loss) = "" Then x7302.Loss = Space(1)
            If trim$(x7302.Usage) = "" Then x7302.Usage = Space(1)
            If trim$(x7302.Remark) = "" Then x7302.Remark = Space(1)
            If trim$(x7302.seSite) = "" Then x7302.seSite = Space(1)
            If trim$(x7302.cdSite) = "" Then x7302.cdSite = Space(1)
            If trim$(x7302.DateInsert) = "" Then x7302.DateInsert = Space(1)
            If trim$(x7302.DateUpdate) = "" Then x7302.DateUpdate = Space(1)
            If trim$(x7302.InchargeInsert) = "" Then x7302.InchargeInsert = Space(1)
            If trim$(x7302.InchargeUpdate) = "" Then x7302.InchargeUpdate = Space(1)
            If trim$(x7302.TimeUpdate) = "" Then x7302.TimeUpdate = Space(1)
            If trim$(x7302.TimeInsert) = "" Then x7302.TimeInsert = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K7302_MOVE(rs7302 As SqlClient.SqlDataReader)
        Try

            Call D7302_CLEAR()

            If IsdbNull(rs7302!K7302_MaterialBOMCode) = False Then D7302.MaterialBOMCode = Trim$(rs7302!K7302_MaterialBOMCode)
            If IsdbNull(rs7302!K7302_MaterialBOMSeq) = False Then D7302.MaterialBOMSeq = Trim$(rs7302!K7302_MaterialBOMSeq)
            If IsdbNull(rs7302!K7302_DSeq) = False Then D7302.DSeq = Trim$(rs7302!K7302_DSeq)
            If IsdbNull(rs7302!K7302_seGroupComponent) = False Then D7302.seGroupComponent = Trim$(rs7302!K7302_seGroupComponent)
            If IsdbNull(rs7302!K7302_cdGroupComponent) = False Then D7302.cdGroupComponent = Trim$(rs7302!K7302_cdGroupComponent)
            If IsdbNull(rs7302!K7302_seComponent) = False Then D7302.seComponent = Trim$(rs7302!K7302_seComponent)
            If IsdbNull(rs7302!K7302_cdComponent) = False Then D7302.cdComponent = Trim$(rs7302!K7302_cdComponent)
            If IsdbNull(rs7302!K7302_MaterialCode) = False Then D7302.MaterialCode = Trim$(rs7302!K7302_MaterialCode)
            If IsDBNull(rs7302!K7302_Description) = False Then D7302.Description = Trim$(rs7302!K7302_Description)
            If IsDBNull(rs7302!K7302_Specification) = False Then D7302.Specification = Trim$(rs7302!K7302_Specification)
            If IsdbNull(rs7302!K7302_seMaterialUnit) = False Then D7302.seMaterialUnit = Trim$(rs7302!K7302_seMaterialUnit)
            If IsdbNull(rs7302!K7302_cdMaterialUnit) = False Then D7302.cdMaterialUnit = Trim$(rs7302!K7302_cdMaterialUnit)
            If IsdbNull(rs7302!K7302_seStatus) = False Then D7302.seStatus = Trim$(rs7302!K7302_seStatus)
            If IsdbNull(rs7302!K7302_cdStatus) = False Then D7302.cdStatus = Trim$(rs7302!K7302_cdStatus)
            If IsdbNull(rs7302!K7302_seDepartment) = False Then D7302.seDepartment = Trim$(rs7302!K7302_seDepartment)
            If IsdbNull(rs7302!K7302_cdDepartment) = False Then D7302.cdDepartment = Trim$(rs7302!K7302_cdDepartment)
            If IsdbNull(rs7302!K7302_SupplierCode) = False Then D7302.SupplierCode = Trim$(rs7302!K7302_SupplierCode)
            If IsdbNull(rs7302!K7302_ColorCode) = False Then D7302.ColorCode = Trim$(rs7302!K7302_ColorCode)
            If IsdbNull(rs7302!K7302_Color) = False Then D7302.Color = Trim$(rs7302!K7302_Color)
            If IsdbNull(rs7302!K7302_Qty) = False Then D7302.Qty = Trim$(rs7302!K7302_Qty)
            If IsdbNull(rs7302!K7302_PriceMaterial) = False Then D7302.PriceMaterial = Trim$(rs7302!K7302_PriceMaterial)
            If IsdbNull(rs7302!K7302_UnitPrice) = False Then D7302.UnitPrice = Trim$(rs7302!K7302_UnitPrice)
            If IsdbNull(rs7302!K7302_Consumption) = False Then D7302.Consumption = Trim$(rs7302!K7302_Consumption)
            If IsdbNull(rs7302!K7302_Loss) = False Then D7302.Loss = Trim$(rs7302!K7302_Loss)
            If IsdbNull(rs7302!K7302_Usage) = False Then D7302.Usage = Trim$(rs7302!K7302_Usage)
            If IsdbNull(rs7302!K7302_Remark) = False Then D7302.Remark = Trim$(rs7302!K7302_Remark)
            If IsdbNull(rs7302!K7302_seSite) = False Then D7302.seSite = Trim$(rs7302!K7302_seSite)
            If IsdbNull(rs7302!K7302_cdSite) = False Then D7302.cdSite = Trim$(rs7302!K7302_cdSite)
            If IsdbNull(rs7302!K7302_DateInsert) = False Then D7302.DateInsert = Trim$(rs7302!K7302_DateInsert)
            If IsdbNull(rs7302!K7302_DateUpdate) = False Then D7302.DateUpdate = Trim$(rs7302!K7302_DateUpdate)
            If IsdbNull(rs7302!K7302_InchargeInsert) = False Then D7302.InchargeInsert = Trim$(rs7302!K7302_InchargeInsert)
            If IsdbNull(rs7302!K7302_InchargeUpdate) = False Then D7302.InchargeUpdate = Trim$(rs7302!K7302_InchargeUpdate)
            If IsdbNull(rs7302!K7302_TimeUpdate) = False Then D7302.TimeUpdate = Trim$(rs7302!K7302_TimeUpdate)
            If IsdbNull(rs7302!K7302_TimeInsert) = False Then D7302.TimeInsert = Trim$(rs7302!K7302_TimeInsert)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7302_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K7302_MOVE(rs7302 As DataRow)
        Try

            Call D7302_CLEAR()

            If IsdbNull(rs7302!K7302_MaterialBOMCode) = False Then D7302.MaterialBOMCode = Trim$(rs7302!K7302_MaterialBOMCode)
            If IsdbNull(rs7302!K7302_MaterialBOMSeq) = False Then D7302.MaterialBOMSeq = Trim$(rs7302!K7302_MaterialBOMSeq)
            If IsdbNull(rs7302!K7302_DSeq) = False Then D7302.DSeq = Trim$(rs7302!K7302_DSeq)
            If IsdbNull(rs7302!K7302_seGroupComponent) = False Then D7302.seGroupComponent = Trim$(rs7302!K7302_seGroupComponent)
            If IsdbNull(rs7302!K7302_cdGroupComponent) = False Then D7302.cdGroupComponent = Trim$(rs7302!K7302_cdGroupComponent)
            If IsdbNull(rs7302!K7302_seComponent) = False Then D7302.seComponent = Trim$(rs7302!K7302_seComponent)
            If IsdbNull(rs7302!K7302_cdComponent) = False Then D7302.cdComponent = Trim$(rs7302!K7302_cdComponent)
            If IsdbNull(rs7302!K7302_MaterialCode) = False Then D7302.MaterialCode = Trim$(rs7302!K7302_MaterialCode)
            If IsDBNull(rs7302!K7302_Description) = False Then D7302.Description = Trim$(rs7302!K7302_Description)
            If IsDBNull(rs7302!K7302_Specification) = False Then D7302.Specification = Trim$(rs7302!K7302_Specification)
            If IsdbNull(rs7302!K7302_seMaterialUnit) = False Then D7302.seMaterialUnit = Trim$(rs7302!K7302_seMaterialUnit)
            If IsdbNull(rs7302!K7302_cdMaterialUnit) = False Then D7302.cdMaterialUnit = Trim$(rs7302!K7302_cdMaterialUnit)
            If IsdbNull(rs7302!K7302_seStatus) = False Then D7302.seStatus = Trim$(rs7302!K7302_seStatus)
            If IsdbNull(rs7302!K7302_cdStatus) = False Then D7302.cdStatus = Trim$(rs7302!K7302_cdStatus)
            If IsdbNull(rs7302!K7302_seDepartment) = False Then D7302.seDepartment = Trim$(rs7302!K7302_seDepartment)
            If IsdbNull(rs7302!K7302_cdDepartment) = False Then D7302.cdDepartment = Trim$(rs7302!K7302_cdDepartment)
            If IsdbNull(rs7302!K7302_SupplierCode) = False Then D7302.SupplierCode = Trim$(rs7302!K7302_SupplierCode)
            If IsdbNull(rs7302!K7302_ColorCode) = False Then D7302.ColorCode = Trim$(rs7302!K7302_ColorCode)
            If IsdbNull(rs7302!K7302_Color) = False Then D7302.Color = Trim$(rs7302!K7302_Color)
            If IsdbNull(rs7302!K7302_Qty) = False Then D7302.Qty = Trim$(rs7302!K7302_Qty)
            If IsdbNull(rs7302!K7302_PriceMaterial) = False Then D7302.PriceMaterial = Trim$(rs7302!K7302_PriceMaterial)
            If IsdbNull(rs7302!K7302_UnitPrice) = False Then D7302.UnitPrice = Trim$(rs7302!K7302_UnitPrice)
            If IsdbNull(rs7302!K7302_Consumption) = False Then D7302.Consumption = Trim$(rs7302!K7302_Consumption)
            If IsdbNull(rs7302!K7302_Loss) = False Then D7302.Loss = Trim$(rs7302!K7302_Loss)
            If IsdbNull(rs7302!K7302_Usage) = False Then D7302.Usage = Trim$(rs7302!K7302_Usage)
            If IsdbNull(rs7302!K7302_Remark) = False Then D7302.Remark = Trim$(rs7302!K7302_Remark)
            If IsdbNull(rs7302!K7302_seSite) = False Then D7302.seSite = Trim$(rs7302!K7302_seSite)
            If IsdbNull(rs7302!K7302_cdSite) = False Then D7302.cdSite = Trim$(rs7302!K7302_cdSite)
            If IsdbNull(rs7302!K7302_DateInsert) = False Then D7302.DateInsert = Trim$(rs7302!K7302_DateInsert)
            If IsdbNull(rs7302!K7302_DateUpdate) = False Then D7302.DateUpdate = Trim$(rs7302!K7302_DateUpdate)
            If IsdbNull(rs7302!K7302_InchargeInsert) = False Then D7302.InchargeInsert = Trim$(rs7302!K7302_InchargeInsert)
            If IsdbNull(rs7302!K7302_InchargeUpdate) = False Then D7302.InchargeUpdate = Trim$(rs7302!K7302_InchargeUpdate)
            If IsdbNull(rs7302!K7302_TimeUpdate) = False Then D7302.TimeUpdate = Trim$(rs7302!K7302_TimeUpdate)
            If IsdbNull(rs7302!K7302_TimeInsert) = False Then D7302.TimeInsert = Trim$(rs7302!K7302_TimeInsert)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7302_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K7302_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7302 As T7302_AREA, MATERIALBOMCODE As String, MATERIALBOMSEQ As Double) As Boolean

        K7302_MOVE = False

        Try
            If READ_PFK7302(MATERIALBOMCODE, MATERIALBOMSEQ) = True Then
                z7302 = D7302
                K7302_MOVE = True
            Else
                z7302 = Nothing
            End If

            If getColumnIndex(spr, "MaterialBOMCode") > -1 Then z7302.MaterialBOMCode = getDataM(spr, getColumnIndex(spr, "MaterialBOMCode"), xRow)
            If getColumnIndex(spr, "MaterialBOMSeq") > -1 Then z7302.MaterialBOMSeq = Cdecp(getDataM(spr, getColumnIndex(spr, "MaterialBOMSeq"), xRow))
            If getColumnIndex(spr, "DSeq") > -1 Then z7302.DSeq = Cdecp(getDataM(spr, getColumnIndex(spr, "DSeq"), xRow))
            If getColumnIndex(spr, "seGroupComponent") > -1 Then z7302.seGroupComponent = getDataM(spr, getColumnIndex(spr, "seGroupComponent"), xRow)
            If getColumnIndex(spr, "cdGroupComponent") > -1 Then z7302.cdGroupComponent = getDataM(spr, getColumnIndex(spr, "cdGroupComponent"), xRow)
            If getColumnIndex(spr, "seComponent") > -1 Then z7302.seComponent = getDataM(spr, getColumnIndex(spr, "seComponent"), xRow)
            If getColumnIndex(spr, "cdComponent") > -1 Then z7302.cdComponent = getDataM(spr, getColumnIndex(spr, "cdComponent"), xRow)
            If getColumnIndex(spr, "MaterialCode") > -1 Then z7302.MaterialCode = getDataM(spr, getColumnIndex(spr, "MaterialCode"), xRow)
            If getColumnIndex(spr, "Description") > -1 Then z7302.Description = getDataM(spr, getColumnIndex(spr, "Description"), xRow)
            If getColumnIndex(spr, "Specification") > -1 Then z7302.Specification = getDataM(spr, getColumnIndex(spr, "Specification"), xRow)
            If getColumnIndex(spr, "seMaterialUnit") > -1 Then z7302.seMaterialUnit = getDataM(spr, getColumnIndex(spr, "seMaterialUnit"), xRow)
            If getColumnIndex(spr, "cdMaterialUnit") > -1 Then z7302.cdMaterialUnit = getDataM(spr, getColumnIndex(spr, "cdMaterialUnit"), xRow)
            If getColumnIndex(spr, "seStatus") > -1 Then z7302.seStatus = getDataM(spr, getColumnIndex(spr, "seStatus"), xRow)
            If getColumnIndex(spr, "cdStatus") > -1 Then z7302.cdStatus = getDataM(spr, getColumnIndex(spr, "cdStatus"), xRow)
            If getColumnIndex(spr, "seDepartment") > -1 Then z7302.seDepartment = getDataM(spr, getColumnIndex(spr, "seDepartment"), xRow)
            If getColumnIndex(spr, "cdDepartment") > -1 Then z7302.cdDepartment = getDataM(spr, getColumnIndex(spr, "cdDepartment"), xRow)
            If getColumnIndex(spr, "SupplierCode") > -1 Then z7302.SupplierCode = getDataM(spr, getColumnIndex(spr, "SupplierCode"), xRow)
            If getColumnIndex(spr, "ColorCode") > -1 Then z7302.ColorCode = getDataM(spr, getColumnIndex(spr, "ColorCode"), xRow)
            If getColumnIndex(spr, "Color") > -1 Then z7302.Color = getDataM(spr, getColumnIndex(spr, "Color"), xRow)
            If getColumnIndex(spr, "Qty") > -1 Then z7302.Qty = Cdecp(getDataM(spr, getColumnIndex(spr, "Qty"), xRow))
            If getColumnIndex(spr, "PriceMaterial") > -1 Then z7302.PriceMaterial = Cdecp(getDataM(spr, getColumnIndex(spr, "PriceMaterial"), xRow))
            If getColumnIndex(spr, "UnitPrice") > -1 Then z7302.UnitPrice = getDataM(spr, getColumnIndex(spr, "UnitPrice"), xRow)
            If getColumnIndex(spr, "Consumption") > -1 Then z7302.Consumption = getDataM(spr, getColumnIndex(spr, "Consumption"), xRow)
            If getColumnIndex(spr, "Loss") > -1 Then z7302.Loss = getDataM(spr, getColumnIndex(spr, "Loss"), xRow)
            If getColumnIndex(spr, "Usage") > -1 Then z7302.Usage = getDataM(spr, getColumnIndex(spr, "Usage"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z7302.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)
            If getColumnIndex(spr, "seSite") > -1 Then z7302.seSite = getDataM(spr, getColumnIndex(spr, "seSite"), xRow)
            If getColumnIndex(spr, "cdSite") > -1 Then z7302.cdSite = getDataM(spr, getColumnIndex(spr, "cdSite"), xRow)
            If getColumnIndex(spr, "DateInsert") > -1 Then z7302.DateInsert = getDataM(spr, getColumnIndex(spr, "DateInsert"), xRow)
            If getColumnIndex(spr, "DateUpdate") > -1 Then z7302.DateUpdate = getDataM(spr, getColumnIndex(spr, "DateUpdate"), xRow)
            If getColumnIndex(spr, "InchargeInsert") > -1 Then z7302.InchargeInsert = getDataM(spr, getColumnIndex(spr, "InchargeInsert"), xRow)
            If getColumnIndex(spr, "InchargeUpdate") > -1 Then z7302.InchargeUpdate = getDataM(spr, getColumnIndex(spr, "InchargeUpdate"), xRow)
            If getColumnIndex(spr, "TimeUpdate") > -1 Then z7302.TimeUpdate = getDataM(spr, getColumnIndex(spr, "TimeUpdate"), xRow)
            If getColumnIndex(spr, "TimeInsert") > -1 Then z7302.TimeInsert = getDataM(spr, getColumnIndex(spr, "TimeInsert"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7302_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K7302_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7302 As T7302_AREA, CheckClear As Boolean, MATERIALBOMCODE As String, MATERIALBOMSEQ As Double) As Boolean

        K7302_MOVE = False

        Try
            If READ_PFK7302(MATERIALBOMCODE, MATERIALBOMSEQ) = True Then
                z7302 = D7302
                K7302_MOVE = True
            Else
                If CheckClear = True Then z7302 = Nothing
            End If

            If getColumnIndex(spr, "MaterialBOMCode") > -1 Then z7302.MaterialBOMCode = getDataM(spr, getColumnIndex(spr, "MaterialBOMCode"), xRow)
            If getColumnIndex(spr, "MaterialBOMSeq") > -1 Then z7302.MaterialBOMSeq = Cdecp(getDataM(spr, getColumnIndex(spr, "MaterialBOMSeq"), xRow))
            If getColumnIndex(spr, "DSeq") > -1 Then z7302.DSeq = Cdecp(getDataM(spr, getColumnIndex(spr, "DSeq"), xRow))
            If getColumnIndex(spr, "seGroupComponent") > -1 Then z7302.seGroupComponent = getDataM(spr, getColumnIndex(spr, "seGroupComponent"), xRow)
            If getColumnIndex(spr, "cdGroupComponent") > -1 Then z7302.cdGroupComponent = getDataM(spr, getColumnIndex(spr, "cdGroupComponent"), xRow)
            If getColumnIndex(spr, "seComponent") > -1 Then z7302.seComponent = getDataM(spr, getColumnIndex(spr, "seComponent"), xRow)
            If getColumnIndex(spr, "cdComponent") > -1 Then z7302.cdComponent = getDataM(spr, getColumnIndex(spr, "cdComponent"), xRow)
            If getColumnIndex(spr, "MaterialCode") > -1 Then z7302.MaterialCode = getDataM(spr, getColumnIndex(spr, "MaterialCode"), xRow)
            If getColumnIndex(spr, "Description") > -1 Then z7302.Description = getDataM(spr, getColumnIndex(spr, "Description"), xRow)
            If getColumnIndex(spr, "Specification") > -1 Then z7302.Specification = getDataM(spr, getColumnIndex(spr, "Specification"), xRow)
            If getColumnIndex(spr, "seMaterialUnit") > -1 Then z7302.seMaterialUnit = getDataM(spr, getColumnIndex(spr, "seMaterialUnit"), xRow)
            If getColumnIndex(spr, "cdMaterialUnit") > -1 Then z7302.cdMaterialUnit = getDataM(spr, getColumnIndex(spr, "cdMaterialUnit"), xRow)
            If getColumnIndex(spr, "seStatus") > -1 Then z7302.seStatus = getDataM(spr, getColumnIndex(spr, "seStatus"), xRow)
            If getColumnIndex(spr, "cdStatus") > -1 Then z7302.cdStatus = getDataM(spr, getColumnIndex(spr, "cdStatus"), xRow)
            If getColumnIndex(spr, "seDepartment") > -1 Then z7302.seDepartment = getDataM(spr, getColumnIndex(spr, "seDepartment"), xRow)
            If getColumnIndex(spr, "cdDepartment") > -1 Then z7302.cdDepartment = getDataM(spr, getColumnIndex(spr, "cdDepartment"), xRow)
            If getColumnIndex(spr, "SupplierCode") > -1 Then z7302.SupplierCode = getDataM(spr, getColumnIndex(spr, "SupplierCode"), xRow)
            If getColumnIndex(spr, "ColorCode") > -1 Then z7302.ColorCode = getDataM(spr, getColumnIndex(spr, "ColorCode"), xRow)
            If getColumnIndex(spr, "Color") > -1 Then z7302.Color = getDataM(spr, getColumnIndex(spr, "Color"), xRow)
            If getColumnIndex(spr, "Qty") > -1 Then z7302.Qty = Cdecp(getDataM(spr, getColumnIndex(spr, "Qty"), xRow))
            If getColumnIndex(spr, "PriceMaterial") > -1 Then z7302.PriceMaterial = Cdecp(getDataM(spr, getColumnIndex(spr, "PriceMaterial"), xRow))
            If getColumnIndex(spr, "UnitPrice") > -1 Then z7302.UnitPrice = getDataM(spr, getColumnIndex(spr, "UnitPrice"), xRow)
            If getColumnIndex(spr, "Consumption") > -1 Then z7302.Consumption = getDataM(spr, getColumnIndex(spr, "Consumption"), xRow)
            If getColumnIndex(spr, "Loss") > -1 Then z7302.Loss = getDataM(spr, getColumnIndex(spr, "Loss"), xRow)
            If getColumnIndex(spr, "Usage") > -1 Then z7302.Usage = getDataM(spr, getColumnIndex(spr, "Usage"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z7302.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)
            If getColumnIndex(spr, "seSite") > -1 Then z7302.seSite = getDataM(spr, getColumnIndex(spr, "seSite"), xRow)
            If getColumnIndex(spr, "cdSite") > -1 Then z7302.cdSite = getDataM(spr, getColumnIndex(spr, "cdSite"), xRow)
            If getColumnIndex(spr, "DateInsert") > -1 Then z7302.DateInsert = getDataM(spr, getColumnIndex(spr, "DateInsert"), xRow)
            If getColumnIndex(spr, "DateUpdate") > -1 Then z7302.DateUpdate = getDataM(spr, getColumnIndex(spr, "DateUpdate"), xRow)
            If getColumnIndex(spr, "InchargeInsert") > -1 Then z7302.InchargeInsert = getDataM(spr, getColumnIndex(spr, "InchargeInsert"), xRow)
            If getColumnIndex(spr, "InchargeUpdate") > -1 Then z7302.InchargeUpdate = getDataM(spr, getColumnIndex(spr, "InchargeUpdate"), xRow)
            If getColumnIndex(spr, "TimeUpdate") > -1 Then z7302.TimeUpdate = getDataM(spr, getColumnIndex(spr, "TimeUpdate"), xRow)
            If getColumnIndex(spr, "TimeInsert") > -1 Then z7302.TimeInsert = getDataM(spr, getColumnIndex(spr, "TimeInsert"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7302_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K7302_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7302 As T7302_AREA, Job As String, MATERIALBOMCODE As String, MATERIALBOMSEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7302_MOVE = False

        Try
            If READ_PFK7302(MATERIALBOMCODE, MATERIALBOMSEQ) = True Then
                z7302 = D7302
                K7302_MOVE = True
            Else
                z7302 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7302")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "MATERIALBOMCODE" : z7302.MaterialBOMCode = Children(i).Code
                                Case "MATERIALBOMSEQ" : z7302.MaterialBOMSeq = Children(i).Code
                                Case "DSEQ" : z7302.DSeq = Children(i).Code
                                Case "SEGROUPCOMPONENT" : z7302.seGroupComponent = Children(i).Code
                                Case "CDGROUPCOMPONENT" : z7302.cdGroupComponent = Children(i).Code
                                Case "SECOMPONENT" : z7302.seComponent = Children(i).Code
                                Case "CDCOMPONENT" : z7302.cdComponent = Children(i).Code
                                Case "MATERIALCODE" : z7302.MaterialCode = Children(i).Code
                                Case "DESCRIPTION" : z7302.Description = Children(i).Code
                                Case "SPECIFICATION" : z7302.Specification = Children(i).Code
                                Case "SEMATERIALUNIT" : z7302.seMaterialUnit = Children(i).Code
                                Case "CDMATERIALUNIT" : z7302.cdMaterialUnit = Children(i).Code
                                Case "SESTATUS" : z7302.seStatus = Children(i).Code
                                Case "CDSTATUS" : z7302.cdStatus = Children(i).Code
                                Case "SEDEPARTMENT" : z7302.seDepartment = Children(i).Code
                                Case "CDDEPARTMENT" : z7302.cdDepartment = Children(i).Code
                                Case "SUPPLIERCODE" : z7302.SupplierCode = Children(i).Code
                                Case "COLORCODE" : z7302.ColorCode = Children(i).Code
                                Case "COLOR" : z7302.Color = Children(i).Code
                                Case "QTY" : z7302.Qty = Children(i).Code
                                Case "PRICEMATERIAL" : z7302.PriceMaterial = Children(i).Code
                                Case "UNITPRICE" : z7302.UnitPrice = Children(i).Code
                                Case "CONSUMPTION" : z7302.Consumption = Children(i).Code
                                Case "LOSS" : z7302.Loss = Children(i).Code
                                Case "USAGE" : z7302.Usage = Children(i).Code
                                Case "REMARK" : z7302.Remark = Children(i).Code
                                Case "SESITE" : z7302.seSite = Children(i).Code
                                Case "CDSITE" : z7302.cdSite = Children(i).Code
                                Case "DATEINSERT" : z7302.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z7302.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z7302.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z7302.InchargeUpdate = Children(i).Code
                                Case "TIMEUPDATE" : z7302.TimeUpdate = Children(i).Code
                                Case "TIMEINSERT" : z7302.TimeInsert = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "MATERIALBOMCODE" : z7302.MaterialBOMCode = Children(i).Data
                                Case "MATERIALBOMSEQ" : z7302.MaterialBOMSeq = Cdecp(Children(i).Data)
                                Case "DSEQ" : z7302.DSeq = Cdecp(Children(i).Data)
                                Case "SEGROUPCOMPONENT" : z7302.seGroupComponent = Children(i).Data
                                Case "CDGROUPCOMPONENT" : z7302.cdGroupComponent = Children(i).Data
                                Case "SECOMPONENT" : z7302.seComponent = Children(i).Data
                                Case "CDCOMPONENT" : z7302.cdComponent = Children(i).Data
                                Case "MATERIALCODE" : z7302.MaterialCode = Children(i).Data
                                Case "DESCRIPTION" : z7302.Description = Children(i).Data
                                Case "SPECIFICATION" : z7302.Specification = Children(i).Data
                                Case "SEMATERIALUNIT" : z7302.seMaterialUnit = Children(i).Data
                                Case "CDMATERIALUNIT" : z7302.cdMaterialUnit = Children(i).Data
                                Case "SESTATUS" : z7302.seStatus = Children(i).Data
                                Case "CDSTATUS" : z7302.cdStatus = Children(i).Data
                                Case "SEDEPARTMENT" : z7302.seDepartment = Children(i).Data
                                Case "CDDEPARTMENT" : z7302.cdDepartment = Children(i).Data
                                Case "SUPPLIERCODE" : z7302.SupplierCode = Children(i).Data
                                Case "COLORCODE" : z7302.ColorCode = Children(i).Data
                                Case "COLOR" : z7302.Color = Children(i).Data
                                Case "QTY" : z7302.Qty = Cdecp(Children(i).Data)
                                Case "PRICEMATERIAL" : z7302.PriceMaterial = Cdecp(Children(i).Data)
                                Case "UNITPRICE" : z7302.UnitPrice = Children(i).Data
                                Case "CONSUMPTION" : z7302.Consumption = Children(i).Data
                                Case "LOSS" : z7302.Loss = Children(i).Data
                                Case "USAGE" : z7302.Usage = Children(i).Data
                                Case "REMARK" : z7302.Remark = Children(i).Data
                                Case "SESITE" : z7302.seSite = Children(i).Data
                                Case "CDSITE" : z7302.cdSite = Children(i).Data
                                Case "DATEINSERT" : z7302.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z7302.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z7302.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z7302.InchargeUpdate = Children(i).Data
                                Case "TIMEUPDATE" : z7302.TimeUpdate = Children(i).Data
                                Case "TIMEINSERT" : z7302.TimeInsert = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7302_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K7302_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7302 As T7302_AREA, Job As String, CheckClear As Boolean, MATERIALBOMCODE As String, MATERIALBOMSEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7302_MOVE = False

        Try
            If READ_PFK7302(MATERIALBOMCODE, MATERIALBOMSEQ) = True Then
                z7302 = D7302
                K7302_MOVE = True
            Else
                If CheckClear = True Then z7302 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7302")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "MATERIALBOMCODE" : z7302.MaterialBOMCode = Children(i).Code
                                Case "MATERIALBOMSEQ" : z7302.MaterialBOMSeq = Children(i).Code
                                Case "DSEQ" : z7302.DSeq = Children(i).Code
                                Case "SEGROUPCOMPONENT" : z7302.seGroupComponent = Children(i).Code
                                Case "CDGROUPCOMPONENT" : z7302.cdGroupComponent = Children(i).Code
                                Case "SECOMPONENT" : z7302.seComponent = Children(i).Code
                                Case "CDCOMPONENT" : z7302.cdComponent = Children(i).Code
                                Case "MATERIALCODE" : z7302.MaterialCode = Children(i).Code
                                Case "DESCRIPTION" : z7302.Description = Children(i).Code
                                Case "SPECIFICATION" : z7302.Specification = Children(i).Code
                                Case "SEMATERIALUNIT" : z7302.seMaterialUnit = Children(i).Code
                                Case "CDMATERIALUNIT" : z7302.cdMaterialUnit = Children(i).Code
                                Case "SESTATUS" : z7302.seStatus = Children(i).Code
                                Case "CDSTATUS" : z7302.cdStatus = Children(i).Code
                                Case "SEDEPARTMENT" : z7302.seDepartment = Children(i).Code
                                Case "CDDEPARTMENT" : z7302.cdDepartment = Children(i).Code
                                Case "SUPPLIERCODE" : z7302.SupplierCode = Children(i).Code
                                Case "COLORCODE" : z7302.ColorCode = Children(i).Code
                                Case "COLOR" : z7302.Color = Children(i).Code
                                Case "QTY" : z7302.Qty = Children(i).Code
                                Case "PRICEMATERIAL" : z7302.PriceMaterial = Children(i).Code
                                Case "UNITPRICE" : z7302.UnitPrice = Children(i).Code
                                Case "CONSUMPTION" : z7302.Consumption = Children(i).Code
                                Case "LOSS" : z7302.Loss = Children(i).Code
                                Case "USAGE" : z7302.Usage = Children(i).Code
                                Case "REMARK" : z7302.Remark = Children(i).Code
                                Case "SESITE" : z7302.seSite = Children(i).Code
                                Case "CDSITE" : z7302.cdSite = Children(i).Code
                                Case "DATEINSERT" : z7302.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z7302.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z7302.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z7302.InchargeUpdate = Children(i).Code
                                Case "TIMEUPDATE" : z7302.TimeUpdate = Children(i).Code
                                Case "TIMEINSERT" : z7302.TimeInsert = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "MATERIALBOMCODE" : z7302.MaterialBOMCode = Children(i).Data
                                Case "MATERIALBOMSEQ" : z7302.MaterialBOMSeq = Cdecp(Children(i).Data)
                                Case "DSEQ" : z7302.DSeq = Cdecp(Children(i).Data)
                                Case "SEGROUPCOMPONENT" : z7302.seGroupComponent = Children(i).Data
                                Case "CDGROUPCOMPONENT" : z7302.cdGroupComponent = Children(i).Data
                                Case "SECOMPONENT" : z7302.seComponent = Children(i).Data
                                Case "CDCOMPONENT" : z7302.cdComponent = Children(i).Data
                                Case "MATERIALCODE" : z7302.MaterialCode = Children(i).Data
                                Case "DESCRIPTION" : z7302.Description = Children(i).Data
                                Case "SPECIFICATION" : z7302.Specification = Children(i).Data
                                Case "SEMATERIALUNIT" : z7302.seMaterialUnit = Children(i).Data
                                Case "CDMATERIALUNIT" : z7302.cdMaterialUnit = Children(i).Data
                                Case "SESTATUS" : z7302.seStatus = Children(i).Data
                                Case "CDSTATUS" : z7302.cdStatus = Children(i).Data
                                Case "SEDEPARTMENT" : z7302.seDepartment = Children(i).Data
                                Case "CDDEPARTMENT" : z7302.cdDepartment = Children(i).Data
                                Case "SUPPLIERCODE" : z7302.SupplierCode = Children(i).Data
                                Case "COLORCODE" : z7302.ColorCode = Children(i).Data
                                Case "COLOR" : z7302.Color = Children(i).Data
                                Case "QTY" : z7302.Qty = Cdecp(Children(i).Data)
                                Case "PRICEMATERIAL" : z7302.PriceMaterial = Cdecp(Children(i).Data)
                                Case "UNITPRICE" : z7302.UnitPrice = Children(i).Data
                                Case "CONSUMPTION" : z7302.Consumption = Children(i).Data
                                Case "LOSS" : z7302.Loss = Children(i).Data
                                Case "USAGE" : z7302.Usage = Children(i).Data
                                Case "REMARK" : z7302.Remark = Children(i).Data
                                Case "SESITE" : z7302.seSite = Children(i).Data
                                Case "CDSITE" : z7302.cdSite = Children(i).Data
                                Case "DATEINSERT" : z7302.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z7302.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z7302.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z7302.InchargeUpdate = Children(i).Data
                                Case "TIMEUPDATE" : z7302.TimeUpdate = Children(i).Data
                                Case "TIMEINSERT" : z7302.TimeInsert = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7302_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW AREA
    '=========================================================================================================================================================
    Public Sub K7302_MOVE(ByRef a7302 As T7302_AREA, ByRef b7302 As T7302_AREA)
        Try
            If trim$(a7302.MaterialBOMCode) = "" Then b7302.MaterialBOMCode = "" Else b7302.MaterialBOMCode = a7302.MaterialBOMCode
            If trim$(a7302.MaterialBOMSeq) = "" Then b7302.MaterialBOMSeq = "" Else b7302.MaterialBOMSeq = a7302.MaterialBOMSeq
            If trim$(a7302.DSeq) = "" Then b7302.DSeq = "" Else b7302.DSeq = a7302.DSeq
            If trim$(a7302.seGroupComponent) = "" Then b7302.seGroupComponent = "" Else b7302.seGroupComponent = a7302.seGroupComponent
            If trim$(a7302.cdGroupComponent) = "" Then b7302.cdGroupComponent = "" Else b7302.cdGroupComponent = a7302.cdGroupComponent
            If trim$(a7302.seComponent) = "" Then b7302.seComponent = "" Else b7302.seComponent = a7302.seComponent
            If trim$(a7302.cdComponent) = "" Then b7302.cdComponent = "" Else b7302.cdComponent = a7302.cdComponent
            If trim$(a7302.MaterialCode) = "" Then b7302.MaterialCode = "" Else b7302.MaterialCode = a7302.MaterialCode
            If Trim$(a7302.Description) = "" Then b7302.Description = "" Else b7302.Description = a7302.Description
            If Trim$(a7302.Specification) = "" Then b7302.Specification = "" Else b7302.Specification = a7302.Specification
            If trim$(a7302.seMaterialUnit) = "" Then b7302.seMaterialUnit = "" Else b7302.seMaterialUnit = a7302.seMaterialUnit
            If trim$(a7302.cdMaterialUnit) = "" Then b7302.cdMaterialUnit = "" Else b7302.cdMaterialUnit = a7302.cdMaterialUnit
            If trim$(a7302.seStatus) = "" Then b7302.seStatus = "" Else b7302.seStatus = a7302.seStatus
            If trim$(a7302.cdStatus) = "" Then b7302.cdStatus = "" Else b7302.cdStatus = a7302.cdStatus
            If trim$(a7302.seDepartment) = "" Then b7302.seDepartment = "" Else b7302.seDepartment = a7302.seDepartment
            If trim$(a7302.cdDepartment) = "" Then b7302.cdDepartment = "" Else b7302.cdDepartment = a7302.cdDepartment
            If trim$(a7302.SupplierCode) = "" Then b7302.SupplierCode = "" Else b7302.SupplierCode = a7302.SupplierCode
            If trim$(a7302.ColorCode) = "" Then b7302.ColorCode = "" Else b7302.ColorCode = a7302.ColorCode
            If trim$(a7302.Color) = "" Then b7302.Color = "" Else b7302.Color = a7302.Color
            If trim$(a7302.Qty) = "" Then b7302.Qty = "" Else b7302.Qty = a7302.Qty
            If trim$(a7302.PriceMaterial) = "" Then b7302.PriceMaterial = "" Else b7302.PriceMaterial = a7302.PriceMaterial
            If trim$(a7302.UnitPrice) = "" Then b7302.UnitPrice = "" Else b7302.UnitPrice = a7302.UnitPrice
            If trim$(a7302.Consumption) = "" Then b7302.Consumption = "" Else b7302.Consumption = a7302.Consumption
            If trim$(a7302.Loss) = "" Then b7302.Loss = "" Else b7302.Loss = a7302.Loss
            If trim$(a7302.Usage) = "" Then b7302.Usage = "" Else b7302.Usage = a7302.Usage
            If trim$(a7302.Remark) = "" Then b7302.Remark = "" Else b7302.Remark = a7302.Remark
            If trim$(a7302.seSite) = "" Then b7302.seSite = "" Else b7302.seSite = a7302.seSite
            If trim$(a7302.cdSite) = "" Then b7302.cdSite = "" Else b7302.cdSite = a7302.cdSite
            If trim$(a7302.DateInsert) = "" Then b7302.DateInsert = "" Else b7302.DateInsert = a7302.DateInsert
            If trim$(a7302.DateUpdate) = "" Then b7302.DateUpdate = "" Else b7302.DateUpdate = a7302.DateUpdate
            If trim$(a7302.InchargeInsert) = "" Then b7302.InchargeInsert = "" Else b7302.InchargeInsert = a7302.InchargeInsert
            If trim$(a7302.InchargeUpdate) = "" Then b7302.InchargeUpdate = "" Else b7302.InchargeUpdate = a7302.InchargeUpdate
            If trim$(a7302.TimeUpdate) = "" Then b7302.TimeUpdate = "" Else b7302.TimeUpdate = a7302.TimeUpdate
            If trim$(a7302.TimeInsert) = "" Then b7302.TimeInsert = "" Else b7302.TimeInsert = a7302.TimeInsert
        Catch ex As Exception
            Call MsgBoxP("K7302_MOVE", vbCritical)
        End Try
    End Sub


End Module
