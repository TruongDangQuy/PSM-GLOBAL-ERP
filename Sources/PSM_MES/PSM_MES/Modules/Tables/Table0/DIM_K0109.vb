'=========================================================================================================================================================
'   TABLE : (PFK0109)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K0109

    Structure T0109_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public Autokey As Double  '			decimal		*
        Public Dseq As Double  '			decimal
        Public SpecNo As String  '			char(9)
        Public SpecNoSeq As String  '			char(3)
        Public MaterialSeq As Double  '			decimal
        Public SizeNo As String  '			char(2)
        Public SizeNoName As String  '			nvarchar(50)
        Public MaterialCode As String  '			char(6)
        Public Color As String  '			nvarchar(200)
        Public Specification As String  '			nvarchar(20)
        Public Width As String  '			nvarchar(20)
        Public Height As String  '			nvarchar(20)
        Public SizeName As String  '			nvarchar(20)
        Public ColorName As String  '			nvarchar(100)
        Public QtySize As Double  '			decimal
        Public LossSize As Double  '			decimal
        Public QtyUsage As Double  '			decimal
        Public seUnitMaterial As String  '			char(3)
        Public cdUnitmaterial As String  '			char(3)
        Public seShoesStatus As String  '			char(3)
        Public cdShoesStatus As String  '			char(3)
        Public seDepartment As String  '			char(3)
        Public cdDepartment As String  '			char(3)
        Public SupplierCode As String  '			char(6)
        Public Price As Double  '			decimal
        Public seUnitPrice As String  '			char(3)
        Public cdUnitPrice As String  '			char(3)
        Public QtyComponent As Double  '			decimal
        Public MaterialAMT As Double  '			decimal
        Public seSubProcess As String  '			char(3)
        Public cdSubProcess As String  '			char(3)
        '=========================================================================================================================================================
    End Structure

    Public D0109 As T0109_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK0109(AUTOKEY As Double) As Boolean
        READ_PFK0109 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK0109 "
            SQL = SQL & " WHERE K0109_Autokey		 =  " & Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D0109_CLEAR() : GoTo SKIP_READ_PFK0109

            Call K0109_MOVE(rd)
            READ_PFK0109 = True

SKIP_READ_PFK0109:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK0109", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK0109(AUTOKEY As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK0109 "
            SQL = SQL & " WHERE K0109_Autokey		 =  " & Autokey & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK0109", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK0109(z0109 As T0109_AREA) As Boolean
        WRITE_PFK0109 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z0109)

            SQL = " INSERT INTO PFK0109 "
            SQL = SQL & " ( "
            SQL = SQL & " K0109_Dseq,"
            SQL = SQL & " K0109_SpecNo,"
            SQL = SQL & " K0109_SpecNoSeq,"
            SQL = SQL & " K0109_MaterialSeq,"
            SQL = SQL & " K0109_SizeNo,"
            SQL = SQL & " K0109_SizeNoName,"
            SQL = SQL & " K0109_MaterialCode,"
            SQL = SQL & " K0109_Color,"
            SQL = SQL & " K0109_Specification,"
            SQL = SQL & " K0109_Width,"
            SQL = SQL & " K0109_Height,"
            SQL = SQL & " K0109_SizeName,"
            SQL = SQL & " K0109_ColorName,"
            SQL = SQL & " K0109_QtySize,"
            SQL = SQL & " K0109_LossSize,"
            SQL = SQL & " K0109_QtyUsage,"
            SQL = SQL & " K0109_seUnitMaterial,"
            SQL = SQL & " K0109_cdUnitmaterial,"
            SQL = SQL & " K0109_seShoesStatus,"
            SQL = SQL & " K0109_cdShoesStatus,"
            SQL = SQL & " K0109_seDepartment,"
            SQL = SQL & " K0109_cdDepartment,"
            SQL = SQL & " K0109_SupplierCode,"
            SQL = SQL & " K0109_Price,"
            SQL = SQL & " K0109_seUnitPrice,"
            SQL = SQL & " K0109_cdUnitPrice,"
            SQL = SQL & " K0109_QtyComponent,"
            SQL = SQL & " K0109_MaterialAMT,"
            SQL = SQL & " K0109_seSubProcess,"
            SQL = SQL & " K0109_cdSubProcess "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "   " & FormatSQL(z0109.Dseq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0109.SpecNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0109.SpecNoSeq) & "', "
            SQL = SQL & "   " & FormatSQL(z0109.MaterialSeq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0109.SizeNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0109.SizeNoName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0109.MaterialCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0109.Color) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0109.Specification) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0109.Width) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0109.Height) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0109.SizeName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0109.ColorName) & "', "
            SQL = SQL & "   " & FormatSQL(z0109.QtySize) & ", "
            SQL = SQL & "   " & FormatSQL(z0109.LossSize) & ", "
            SQL = SQL & "   " & FormatSQL(z0109.QtyUsage) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0109.seUnitMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0109.cdUnitmaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0109.seShoesStatus) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0109.cdShoesStatus) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0109.seDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0109.cdDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0109.SupplierCode) & "', "
            SQL = SQL & "   " & FormatSQL(z0109.Price) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0109.seUnitPrice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0109.cdUnitPrice) & "', "
            SQL = SQL & "   " & FormatSQL(z0109.QtyComponent) & ", "
            SQL = SQL & "   " & FormatSQL(z0109.MaterialAMT) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0109.seSubProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0109.cdSubProcess) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK0109 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK0109", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK0109(z0109 As T0109_AREA) As Boolean
        REWRITE_PFK0109 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z0109)

            SQL = " UPDATE PFK0109 SET "
            SQL = SQL & "    K0109_Dseq      =  " & FormatSQL(z0109.Dseq) & ", "
            SQL = SQL & "    K0109_SpecNo      = N'" & FormatSQL(z0109.SpecNo) & "', "
            SQL = SQL & "    K0109_SpecNoSeq      = N'" & FormatSQL(z0109.SpecNoSeq) & "', "
            SQL = SQL & "    K0109_MaterialSeq      =  " & FormatSQL(z0109.MaterialSeq) & ", "
            SQL = SQL & "    K0109_SizeNo      = N'" & FormatSQL(z0109.SizeNo) & "', "
            SQL = SQL & "    K0109_SizeNoName      = N'" & FormatSQL(z0109.SizeNoName) & "', "
            SQL = SQL & "    K0109_MaterialCode      = N'" & FormatSQL(z0109.MaterialCode) & "', "
            SQL = SQL & "    K0109_Color      = N'" & FormatSQL(z0109.Color) & "', "
            SQL = SQL & "    K0109_Specification      = N'" & FormatSQL(z0109.Specification) & "', "
            SQL = SQL & "    K0109_Width      = N'" & FormatSQL(z0109.Width) & "', "
            SQL = SQL & "    K0109_Height      = N'" & FormatSQL(z0109.Height) & "', "
            SQL = SQL & "    K0109_SizeName      = N'" & FormatSQL(z0109.SizeName) & "', "
            SQL = SQL & "    K0109_ColorName      = N'" & FormatSQL(z0109.ColorName) & "', "
            SQL = SQL & "    K0109_QtySize      =  " & FormatSQL(z0109.QtySize) & ", "
            SQL = SQL & "    K0109_LossSize      =  " & FormatSQL(z0109.LossSize) & ", "
            SQL = SQL & "    K0109_QtyUsage      =  " & FormatSQL(z0109.QtyUsage) & ", "
            SQL = SQL & "    K0109_seUnitMaterial      = N'" & FormatSQL(z0109.seUnitMaterial) & "', "
            SQL = SQL & "    K0109_cdUnitmaterial      = N'" & FormatSQL(z0109.cdUnitmaterial) & "', "
            SQL = SQL & "    K0109_seShoesStatus      = N'" & FormatSQL(z0109.seShoesStatus) & "', "
            SQL = SQL & "    K0109_cdShoesStatus      = N'" & FormatSQL(z0109.cdShoesStatus) & "', "
            SQL = SQL & "    K0109_seDepartment      = N'" & FormatSQL(z0109.seDepartment) & "', "
            SQL = SQL & "    K0109_cdDepartment      = N'" & FormatSQL(z0109.cdDepartment) & "', "
            SQL = SQL & "    K0109_SupplierCode      = N'" & FormatSQL(z0109.SupplierCode) & "', "
            SQL = SQL & "    K0109_Price      =  " & FormatSQL(z0109.Price) & ", "
            SQL = SQL & "    K0109_seUnitPrice      = N'" & FormatSQL(z0109.seUnitPrice) & "', "
            SQL = SQL & "    K0109_cdUnitPrice      = N'" & FormatSQL(z0109.cdUnitPrice) & "', "
            SQL = SQL & "    K0109_QtyComponent      =  " & FormatSQL(z0109.QtyComponent) & ", "
            SQL = SQL & "    K0109_MaterialAMT      =  " & FormatSQL(z0109.MaterialAMT) & ", "
            SQL = SQL & "    K0109_seSubProcess      = N'" & FormatSQL(z0109.seSubProcess) & "', "
            SQL = SQL & "    K0109_cdSubProcess      = N'" & FormatSQL(z0109.cdSubProcess) & "'  "
            SQL = SQL & " WHERE K0109_Autokey		 =  " & z0109.Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK0109 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK0109", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK0109(z0109 As T0109_AREA) As Boolean
        DELETE_PFK0109 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK0109 "
            SQL = SQL & " WHERE K0109_Autokey		 =  " & z0109.Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK0109 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK0109", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D0109_CLEAR()
        Try

            D0109.Autokey = 0
            D0109.Dseq = 0
            D0109.SpecNo = ""
            D0109.SpecNoSeq = ""
            D0109.MaterialSeq = 0
            D0109.SizeNo = ""
            D0109.SizeNoName = ""
            D0109.MaterialCode = ""
            D0109.Color = ""
            D0109.Specification = ""
            D0109.Width = ""
            D0109.Height = ""
            D0109.SizeName = ""
            D0109.ColorName = ""
            D0109.QtySize = 0
            D0109.LossSize = 0
            D0109.QtyUsage = 0
            D0109.seUnitMaterial = ""
            D0109.cdUnitmaterial = ""
            D0109.seShoesStatus = ""
            D0109.cdShoesStatus = ""
            D0109.seDepartment = ""
            D0109.cdDepartment = ""
            D0109.SupplierCode = ""
            D0109.Price = 0
            D0109.seUnitPrice = ""
            D0109.cdUnitPrice = ""
            D0109.QtyComponent = 0
            D0109.MaterialAMT = 0
            D0109.seSubProcess = ""
            D0109.cdSubProcess = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D0109_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x0109 As T0109_AREA)
        Try

            x0109.Autokey = trim$(x0109.Autokey)
            x0109.Dseq = trim$(x0109.Dseq)
            x0109.SpecNo = trim$(x0109.SpecNo)
            x0109.SpecNoSeq = trim$(x0109.SpecNoSeq)
            x0109.MaterialSeq = trim$(x0109.MaterialSeq)
            x0109.SizeNo = trim$(x0109.SizeNo)
            x0109.SizeNoName = trim$(x0109.SizeNoName)
            x0109.MaterialCode = trim$(x0109.MaterialCode)
            x0109.Color = trim$(x0109.Color)
            x0109.Specification = trim$(x0109.Specification)
            x0109.Width = trim$(x0109.Width)
            x0109.Height = trim$(x0109.Height)
            x0109.SizeName = trim$(x0109.SizeName)
            x0109.ColorName = trim$(x0109.ColorName)
            x0109.QtySize = trim$(x0109.QtySize)
            x0109.LossSize = trim$(x0109.LossSize)
            x0109.QtyUsage = trim$(x0109.QtyUsage)
            x0109.seUnitMaterial = trim$(x0109.seUnitMaterial)
            x0109.cdUnitmaterial = trim$(x0109.cdUnitmaterial)
            x0109.seShoesStatus = trim$(x0109.seShoesStatus)
            x0109.cdShoesStatus = trim$(x0109.cdShoesStatus)
            x0109.seDepartment = trim$(x0109.seDepartment)
            x0109.cdDepartment = trim$(x0109.cdDepartment)
            x0109.SupplierCode = trim$(x0109.SupplierCode)
            x0109.Price = trim$(x0109.Price)
            x0109.seUnitPrice = trim$(x0109.seUnitPrice)
            x0109.cdUnitPrice = trim$(x0109.cdUnitPrice)
            x0109.QtyComponent = trim$(x0109.QtyComponent)
            x0109.MaterialAMT = trim$(x0109.MaterialAMT)
            x0109.seSubProcess = trim$(x0109.seSubProcess)
            x0109.cdSubProcess = trim$(x0109.cdSubProcess)

            If trim$(x0109.Autokey) = "" Then x0109.Autokey = 0
            If trim$(x0109.Dseq) = "" Then x0109.Dseq = 0
            If trim$(x0109.SpecNo) = "" Then x0109.SpecNo = Space(1)
            If trim$(x0109.SpecNoSeq) = "" Then x0109.SpecNoSeq = Space(1)
            If trim$(x0109.MaterialSeq) = "" Then x0109.MaterialSeq = 0
            If trim$(x0109.SizeNo) = "" Then x0109.SizeNo = Space(1)
            If trim$(x0109.SizeNoName) = "" Then x0109.SizeNoName = Space(1)
            If trim$(x0109.MaterialCode) = "" Then x0109.MaterialCode = Space(1)
            If trim$(x0109.Color) = "" Then x0109.Color = Space(1)
            If trim$(x0109.Specification) = "" Then x0109.Specification = Space(1)
            If trim$(x0109.Width) = "" Then x0109.Width = Space(1)
            If trim$(x0109.Height) = "" Then x0109.Height = Space(1)
            If trim$(x0109.SizeName) = "" Then x0109.SizeName = Space(1)
            If trim$(x0109.ColorName) = "" Then x0109.ColorName = Space(1)
            If trim$(x0109.QtySize) = "" Then x0109.QtySize = 0
            If trim$(x0109.LossSize) = "" Then x0109.LossSize = 0
            If trim$(x0109.QtyUsage) = "" Then x0109.QtyUsage = 0
            If trim$(x0109.seUnitMaterial) = "" Then x0109.seUnitMaterial = Space(1)
            If trim$(x0109.cdUnitmaterial) = "" Then x0109.cdUnitmaterial = Space(1)
            If trim$(x0109.seShoesStatus) = "" Then x0109.seShoesStatus = Space(1)
            If trim$(x0109.cdShoesStatus) = "" Then x0109.cdShoesStatus = Space(1)
            If trim$(x0109.seDepartment) = "" Then x0109.seDepartment = Space(1)
            If trim$(x0109.cdDepartment) = "" Then x0109.cdDepartment = Space(1)
            If trim$(x0109.SupplierCode) = "" Then x0109.SupplierCode = Space(1)
            If trim$(x0109.Price) = "" Then x0109.Price = 0
            If trim$(x0109.seUnitPrice) = "" Then x0109.seUnitPrice = Space(1)
            If trim$(x0109.cdUnitPrice) = "" Then x0109.cdUnitPrice = Space(1)
            If trim$(x0109.QtyComponent) = "" Then x0109.QtyComponent = 0
            If trim$(x0109.MaterialAMT) = "" Then x0109.MaterialAMT = 0
            If trim$(x0109.seSubProcess) = "" Then x0109.seSubProcess = Space(1)
            If trim$(x0109.cdSubProcess) = "" Then x0109.cdSubProcess = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K0109_MOVE(rs0109 As SqlClient.SqlDataReader)
        Try

            Call D0109_CLEAR()

            If IsdbNull(rs0109!K0109_Autokey) = False Then D0109.Autokey = Trim$(rs0109!K0109_Autokey)
            If IsdbNull(rs0109!K0109_Dseq) = False Then D0109.Dseq = Trim$(rs0109!K0109_Dseq)
            If IsdbNull(rs0109!K0109_SpecNo) = False Then D0109.SpecNo = Trim$(rs0109!K0109_SpecNo)
            If IsdbNull(rs0109!K0109_SpecNoSeq) = False Then D0109.SpecNoSeq = Trim$(rs0109!K0109_SpecNoSeq)
            If IsdbNull(rs0109!K0109_MaterialSeq) = False Then D0109.MaterialSeq = Trim$(rs0109!K0109_MaterialSeq)
            If IsdbNull(rs0109!K0109_SizeNo) = False Then D0109.SizeNo = Trim$(rs0109!K0109_SizeNo)
            If IsdbNull(rs0109!K0109_SizeNoName) = False Then D0109.SizeNoName = Trim$(rs0109!K0109_SizeNoName)
            If IsdbNull(rs0109!K0109_MaterialCode) = False Then D0109.MaterialCode = Trim$(rs0109!K0109_MaterialCode)
            If IsdbNull(rs0109!K0109_Color) = False Then D0109.Color = Trim$(rs0109!K0109_Color)
            If IsdbNull(rs0109!K0109_Specification) = False Then D0109.Specification = Trim$(rs0109!K0109_Specification)
            If IsdbNull(rs0109!K0109_Width) = False Then D0109.Width = Trim$(rs0109!K0109_Width)
            If IsdbNull(rs0109!K0109_Height) = False Then D0109.Height = Trim$(rs0109!K0109_Height)
            If IsdbNull(rs0109!K0109_SizeName) = False Then D0109.SizeName = Trim$(rs0109!K0109_SizeName)
            If IsdbNull(rs0109!K0109_ColorName) = False Then D0109.ColorName = Trim$(rs0109!K0109_ColorName)
            If IsdbNull(rs0109!K0109_QtySize) = False Then D0109.QtySize = Trim$(rs0109!K0109_QtySize)
            If IsdbNull(rs0109!K0109_LossSize) = False Then D0109.LossSize = Trim$(rs0109!K0109_LossSize)
            If IsdbNull(rs0109!K0109_QtyUsage) = False Then D0109.QtyUsage = Trim$(rs0109!K0109_QtyUsage)
            If IsdbNull(rs0109!K0109_seUnitMaterial) = False Then D0109.seUnitMaterial = Trim$(rs0109!K0109_seUnitMaterial)
            If IsdbNull(rs0109!K0109_cdUnitmaterial) = False Then D0109.cdUnitmaterial = Trim$(rs0109!K0109_cdUnitmaterial)
            If IsdbNull(rs0109!K0109_seShoesStatus) = False Then D0109.seShoesStatus = Trim$(rs0109!K0109_seShoesStatus)
            If IsdbNull(rs0109!K0109_cdShoesStatus) = False Then D0109.cdShoesStatus = Trim$(rs0109!K0109_cdShoesStatus)
            If IsdbNull(rs0109!K0109_seDepartment) = False Then D0109.seDepartment = Trim$(rs0109!K0109_seDepartment)
            If IsdbNull(rs0109!K0109_cdDepartment) = False Then D0109.cdDepartment = Trim$(rs0109!K0109_cdDepartment)
            If IsdbNull(rs0109!K0109_SupplierCode) = False Then D0109.SupplierCode = Trim$(rs0109!K0109_SupplierCode)
            If IsdbNull(rs0109!K0109_Price) = False Then D0109.Price = Trim$(rs0109!K0109_Price)
            If IsdbNull(rs0109!K0109_seUnitPrice) = False Then D0109.seUnitPrice = Trim$(rs0109!K0109_seUnitPrice)
            If IsdbNull(rs0109!K0109_cdUnitPrice) = False Then D0109.cdUnitPrice = Trim$(rs0109!K0109_cdUnitPrice)
            If IsdbNull(rs0109!K0109_QtyComponent) = False Then D0109.QtyComponent = Trim$(rs0109!K0109_QtyComponent)
            If IsdbNull(rs0109!K0109_MaterialAMT) = False Then D0109.MaterialAMT = Trim$(rs0109!K0109_MaterialAMT)
            If IsdbNull(rs0109!K0109_seSubProcess) = False Then D0109.seSubProcess = Trim$(rs0109!K0109_seSubProcess)
            If IsdbNull(rs0109!K0109_cdSubProcess) = False Then D0109.cdSubProcess = Trim$(rs0109!K0109_cdSubProcess)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K0109_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K0109_MOVE(rs0109 As DataRow)
        Try

            Call D0109_CLEAR()

            If IsdbNull(rs0109!K0109_Autokey) = False Then D0109.Autokey = Trim$(rs0109!K0109_Autokey)
            If IsdbNull(rs0109!K0109_Dseq) = False Then D0109.Dseq = Trim$(rs0109!K0109_Dseq)
            If IsdbNull(rs0109!K0109_SpecNo) = False Then D0109.SpecNo = Trim$(rs0109!K0109_SpecNo)
            If IsdbNull(rs0109!K0109_SpecNoSeq) = False Then D0109.SpecNoSeq = Trim$(rs0109!K0109_SpecNoSeq)
            If IsdbNull(rs0109!K0109_MaterialSeq) = False Then D0109.MaterialSeq = Trim$(rs0109!K0109_MaterialSeq)
            If IsdbNull(rs0109!K0109_SizeNo) = False Then D0109.SizeNo = Trim$(rs0109!K0109_SizeNo)
            If IsdbNull(rs0109!K0109_SizeNoName) = False Then D0109.SizeNoName = Trim$(rs0109!K0109_SizeNoName)
            If IsdbNull(rs0109!K0109_MaterialCode) = False Then D0109.MaterialCode = Trim$(rs0109!K0109_MaterialCode)
            If IsdbNull(rs0109!K0109_Color) = False Then D0109.Color = Trim$(rs0109!K0109_Color)
            If IsdbNull(rs0109!K0109_Specification) = False Then D0109.Specification = Trim$(rs0109!K0109_Specification)
            If IsdbNull(rs0109!K0109_Width) = False Then D0109.Width = Trim$(rs0109!K0109_Width)
            If IsdbNull(rs0109!K0109_Height) = False Then D0109.Height = Trim$(rs0109!K0109_Height)
            If IsdbNull(rs0109!K0109_SizeName) = False Then D0109.SizeName = Trim$(rs0109!K0109_SizeName)
            If IsdbNull(rs0109!K0109_ColorName) = False Then D0109.ColorName = Trim$(rs0109!K0109_ColorName)
            If IsdbNull(rs0109!K0109_QtySize) = False Then D0109.QtySize = Trim$(rs0109!K0109_QtySize)
            If IsdbNull(rs0109!K0109_LossSize) = False Then D0109.LossSize = Trim$(rs0109!K0109_LossSize)
            If IsdbNull(rs0109!K0109_QtyUsage) = False Then D0109.QtyUsage = Trim$(rs0109!K0109_QtyUsage)
            If IsdbNull(rs0109!K0109_seUnitMaterial) = False Then D0109.seUnitMaterial = Trim$(rs0109!K0109_seUnitMaterial)
            If IsdbNull(rs0109!K0109_cdUnitmaterial) = False Then D0109.cdUnitmaterial = Trim$(rs0109!K0109_cdUnitmaterial)
            If IsdbNull(rs0109!K0109_seShoesStatus) = False Then D0109.seShoesStatus = Trim$(rs0109!K0109_seShoesStatus)
            If IsdbNull(rs0109!K0109_cdShoesStatus) = False Then D0109.cdShoesStatus = Trim$(rs0109!K0109_cdShoesStatus)
            If IsdbNull(rs0109!K0109_seDepartment) = False Then D0109.seDepartment = Trim$(rs0109!K0109_seDepartment)
            If IsdbNull(rs0109!K0109_cdDepartment) = False Then D0109.cdDepartment = Trim$(rs0109!K0109_cdDepartment)
            If IsdbNull(rs0109!K0109_SupplierCode) = False Then D0109.SupplierCode = Trim$(rs0109!K0109_SupplierCode)
            If IsdbNull(rs0109!K0109_Price) = False Then D0109.Price = Trim$(rs0109!K0109_Price)
            If IsdbNull(rs0109!K0109_seUnitPrice) = False Then D0109.seUnitPrice = Trim$(rs0109!K0109_seUnitPrice)
            If IsdbNull(rs0109!K0109_cdUnitPrice) = False Then D0109.cdUnitPrice = Trim$(rs0109!K0109_cdUnitPrice)
            If IsdbNull(rs0109!K0109_QtyComponent) = False Then D0109.QtyComponent = Trim$(rs0109!K0109_QtyComponent)
            If IsdbNull(rs0109!K0109_MaterialAMT) = False Then D0109.MaterialAMT = Trim$(rs0109!K0109_MaterialAMT)
            If IsdbNull(rs0109!K0109_seSubProcess) = False Then D0109.seSubProcess = Trim$(rs0109!K0109_seSubProcess)
            If IsdbNull(rs0109!K0109_cdSubProcess) = False Then D0109.cdSubProcess = Trim$(rs0109!K0109_cdSubProcess)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K0109_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K0109_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z0109 As T0109_AREA, AUTOKEY As Double) As Boolean

        K0109_MOVE = False

        Try
            If READ_PFK0109(AUTOKEY) = True Then
                z0109 = D0109
                K0109_MOVE = True
            Else
                z0109 = Nothing
            End If

            If getColumIndex(spr, "Autokey") > -1 Then z0109.Autokey = getDataM(spr, getColumIndex(spr, "Autokey"), xRow)
            If getColumIndex(spr, "Dseq") > -1 Then z0109.Dseq = getDataM(spr, getColumIndex(spr, "Dseq"), xRow)
            If getColumIndex(spr, "SpecNo") > -1 Then z0109.SpecNo = getDataM(spr, getColumIndex(spr, "SpecNo"), xRow)
            If getColumIndex(spr, "SpecNoSeq") > -1 Then z0109.SpecNoSeq = getDataM(spr, getColumIndex(spr, "SpecNoSeq"), xRow)
            If getColumIndex(spr, "MaterialSeq") > -1 Then z0109.MaterialSeq = getDataM(spr, getColumIndex(spr, "MaterialSeq"), xRow)
            If getColumIndex(spr, "SizeNo") > -1 Then z0109.SizeNo = getDataM(spr, getColumIndex(spr, "SizeNo"), xRow)
            If getColumIndex(spr, "SizeNoName") > -1 Then z0109.SizeNoName = getDataM(spr, getColumIndex(spr, "SizeNoName"), xRow)
            If getColumIndex(spr, "MaterialCode") > -1 Then z0109.MaterialCode = getDataM(spr, getColumIndex(spr, "MaterialCode"), xRow)
            If getColumIndex(spr, "Color") > -1 Then z0109.Color = getDataM(spr, getColumIndex(spr, "Color"), xRow)
            If getColumIndex(spr, "Specification") > -1 Then z0109.Specification = getDataM(spr, getColumIndex(spr, "Specification"), xRow)
            If getColumIndex(spr, "Width") > -1 Then z0109.Width = getDataM(spr, getColumIndex(spr, "Width"), xRow)
            If getColumIndex(spr, "Height") > -1 Then z0109.Height = getDataM(spr, getColumIndex(spr, "Height"), xRow)
            If getColumIndex(spr, "SizeName") > -1 Then z0109.SizeName = getDataM(spr, getColumIndex(spr, "SizeName"), xRow)
            If getColumIndex(spr, "ColorName") > -1 Then z0109.ColorName = getDataM(spr, getColumIndex(spr, "ColorName"), xRow)
            If getColumIndex(spr, "QtySize") > -1 Then z0109.QtySize = getDataM(spr, getColumIndex(spr, "QtySize"), xRow)
            If getColumIndex(spr, "LossSize") > -1 Then z0109.LossSize = getDataM(spr, getColumIndex(spr, "LossSize"), xRow)
            If getColumIndex(spr, "QtyUsage") > -1 Then z0109.QtyUsage = getDataM(spr, getColumIndex(spr, "QtyUsage"), xRow)
            If getColumIndex(spr, "seUnitMaterial") > -1 Then z0109.seUnitMaterial = getDataM(spr, getColumIndex(spr, "seUnitMaterial"), xRow)
            If getColumIndex(spr, "cdUnitmaterial") > -1 Then z0109.cdUnitmaterial = getDataM(spr, getColumIndex(spr, "cdUnitmaterial"), xRow)
            If getColumIndex(spr, "seShoesStatus") > -1 Then z0109.seShoesStatus = getDataM(spr, getColumIndex(spr, "seShoesStatus"), xRow)
            If getColumIndex(spr, "cdShoesStatus") > -1 Then z0109.cdShoesStatus = getDataM(spr, getColumIndex(spr, "cdShoesStatus"), xRow)
            If getColumIndex(spr, "seDepartment") > -1 Then z0109.seDepartment = getDataM(spr, getColumIndex(spr, "seDepartment"), xRow)
            If getColumIndex(spr, "cdDepartment") > -1 Then z0109.cdDepartment = getDataM(spr, getColumIndex(spr, "cdDepartment"), xRow)
            If getColumIndex(spr, "SupplierCode") > -1 Then z0109.SupplierCode = getDataM(spr, getColumIndex(spr, "SupplierCode"), xRow)
            If getColumIndex(spr, "Price") > -1 Then z0109.Price = getDataM(spr, getColumIndex(spr, "Price"), xRow)
            If getColumIndex(spr, "seUnitPrice") > -1 Then z0109.seUnitPrice = getDataM(spr, getColumIndex(spr, "seUnitPrice"), xRow)
            If getColumIndex(spr, "cdUnitPrice") > -1 Then z0109.cdUnitPrice = getDataM(spr, getColumIndex(spr, "cdUnitPrice"), xRow)
            If getColumIndex(spr, "QtyComponent") > -1 Then z0109.QtyComponent = getDataM(spr, getColumIndex(spr, "QtyComponent"), xRow)
            If getColumIndex(spr, "MaterialAMT") > -1 Then z0109.MaterialAMT = getDataM(spr, getColumIndex(spr, "MaterialAMT"), xRow)
            If getColumIndex(spr, "seSubProcess") > -1 Then z0109.seSubProcess = getDataM(spr, getColumIndex(spr, "seSubProcess"), xRow)
            If getColumIndex(spr, "cdSubProcess") > -1 Then z0109.cdSubProcess = getDataM(spr, getColumIndex(spr, "cdSubProcess"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K0109_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K0109_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z0109 As T0109_AREA, CheckClear As Boolean, AUTOKEY As Double) As Boolean

        K0109_MOVE = False

        Try
            If READ_PFK0109(AUTOKEY) = True Then
                z0109 = D0109
                K0109_MOVE = True
            Else
                If CheckClear = True Then z0109 = Nothing
            End If

            If getColumIndex(spr, "Autokey") > -1 Then z0109.Autokey = getDataM(spr, getColumIndex(spr, "Autokey"), xRow)
            If getColumIndex(spr, "Dseq") > -1 Then z0109.Dseq = getDataM(spr, getColumIndex(spr, "Dseq"), xRow)
            If getColumIndex(spr, "SpecNo") > -1 Then z0109.SpecNo = getDataM(spr, getColumIndex(spr, "SpecNo"), xRow)
            If getColumIndex(spr, "SpecNoSeq") > -1 Then z0109.SpecNoSeq = getDataM(spr, getColumIndex(spr, "SpecNoSeq"), xRow)
            If getColumIndex(spr, "MaterialSeq") > -1 Then z0109.MaterialSeq = getDataM(spr, getColumIndex(spr, "MaterialSeq"), xRow)
            If getColumIndex(spr, "SizeNo") > -1 Then z0109.SizeNo = getDataM(spr, getColumIndex(spr, "SizeNo"), xRow)
            If getColumIndex(spr, "SizeNoName") > -1 Then z0109.SizeNoName = getDataM(spr, getColumIndex(spr, "SizeNoName"), xRow)
            If getColumIndex(spr, "MaterialCode") > -1 Then z0109.MaterialCode = getDataM(spr, getColumIndex(spr, "MaterialCode"), xRow)
            If getColumIndex(spr, "Color") > -1 Then z0109.Color = getDataM(spr, getColumIndex(spr, "Color"), xRow)
            If getColumIndex(spr, "Specification") > -1 Then z0109.Specification = getDataM(spr, getColumIndex(spr, "Specification"), xRow)
            If getColumIndex(spr, "Width") > -1 Then z0109.Width = getDataM(spr, getColumIndex(spr, "Width"), xRow)
            If getColumIndex(spr, "Height") > -1 Then z0109.Height = getDataM(spr, getColumIndex(spr, "Height"), xRow)
            If getColumIndex(spr, "SizeName") > -1 Then z0109.SizeName = getDataM(spr, getColumIndex(spr, "SizeName"), xRow)
            If getColumIndex(spr, "ColorName") > -1 Then z0109.ColorName = getDataM(spr, getColumIndex(spr, "ColorName"), xRow)
            If getColumIndex(spr, "QtySize") > -1 Then z0109.QtySize = getDataM(spr, getColumIndex(spr, "QtySize"), xRow)
            If getColumIndex(spr, "LossSize") > -1 Then z0109.LossSize = getDataM(spr, getColumIndex(spr, "LossSize"), xRow)
            If getColumIndex(spr, "QtyUsage") > -1 Then z0109.QtyUsage = getDataM(spr, getColumIndex(spr, "QtyUsage"), xRow)
            If getColumIndex(spr, "seUnitMaterial") > -1 Then z0109.seUnitMaterial = getDataM(spr, getColumIndex(spr, "seUnitMaterial"), xRow)
            If getColumIndex(spr, "cdUnitmaterial") > -1 Then z0109.cdUnitmaterial = getDataM(spr, getColumIndex(spr, "cdUnitmaterial"), xRow)
            If getColumIndex(spr, "seShoesStatus") > -1 Then z0109.seShoesStatus = getDataM(spr, getColumIndex(spr, "seShoesStatus"), xRow)
            If getColumIndex(spr, "cdShoesStatus") > -1 Then z0109.cdShoesStatus = getDataM(spr, getColumIndex(spr, "cdShoesStatus"), xRow)
            If getColumIndex(spr, "seDepartment") > -1 Then z0109.seDepartment = getDataM(spr, getColumIndex(spr, "seDepartment"), xRow)
            If getColumIndex(spr, "cdDepartment") > -1 Then z0109.cdDepartment = getDataM(spr, getColumIndex(spr, "cdDepartment"), xRow)
            If getColumIndex(spr, "SupplierCode") > -1 Then z0109.SupplierCode = getDataM(spr, getColumIndex(spr, "SupplierCode"), xRow)
            If getColumIndex(spr, "Price") > -1 Then z0109.Price = getDataM(spr, getColumIndex(spr, "Price"), xRow)
            If getColumIndex(spr, "seUnitPrice") > -1 Then z0109.seUnitPrice = getDataM(spr, getColumIndex(spr, "seUnitPrice"), xRow)
            If getColumIndex(spr, "cdUnitPrice") > -1 Then z0109.cdUnitPrice = getDataM(spr, getColumIndex(spr, "cdUnitPrice"), xRow)
            If getColumIndex(spr, "QtyComponent") > -1 Then z0109.QtyComponent = getDataM(spr, getColumIndex(spr, "QtyComponent"), xRow)
            If getColumIndex(spr, "MaterialAMT") > -1 Then z0109.MaterialAMT = getDataM(spr, getColumIndex(spr, "MaterialAMT"), xRow)
            If getColumIndex(spr, "seSubProcess") > -1 Then z0109.seSubProcess = getDataM(spr, getColumIndex(spr, "seSubProcess"), xRow)
            If getColumIndex(spr, "cdSubProcess") > -1 Then z0109.cdSubProcess = getDataM(spr, getColumIndex(spr, "cdSubProcess"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K0109_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K0109_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z0109 As T0109_AREA, Job As String, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K0109_MOVE = False

        Try
            If READ_PFK0109(AUTOKEY) = True Then
                z0109 = D0109
                K0109_MOVE = True
            Else
                z0109 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0109")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z0109.Autokey = Children(i).Code
                                Case "DSEQ" : z0109.Dseq = Children(i).Code
                                Case "SPECNO" : z0109.SpecNo = Children(i).Code
                                Case "SPECNOSEQ" : z0109.SpecNoSeq = Children(i).Code
                                Case "MATERIALSEQ" : z0109.MaterialSeq = Children(i).Code
                                Case "SIZENO" : z0109.SizeNo = Children(i).Code
                                Case "SIZENONAME" : z0109.SizeNoName = Children(i).Code
                                Case "MATERIALCODE" : z0109.MaterialCode = Children(i).Code
                                Case "COLOR" : z0109.Color = Children(i).Code
                                Case "SPECIFICATION" : z0109.Specification = Children(i).Code
                                Case "WIDTH" : z0109.Width = Children(i).Code
                                Case "HEIGHT" : z0109.Height = Children(i).Code
                                Case "SIZENAME" : z0109.SizeName = Children(i).Code
                                Case "COLORNAME" : z0109.ColorName = Children(i).Code
                                Case "QTYSIZE" : z0109.QtySize = Children(i).Code
                                Case "LOSSSIZE" : z0109.LossSize = Children(i).Code
                                Case "QTYUSAGE" : z0109.QtyUsage = Children(i).Code
                                Case "SEUNITMATERIAL" : z0109.seUnitMaterial = Children(i).Code
                                Case "CDUNITMATERIAL" : z0109.cdUnitmaterial = Children(i).Code
                                Case "SESHOESSTATUS" : z0109.seShoesStatus = Children(i).Code
                                Case "CDSHOESSTATUS" : z0109.cdShoesStatus = Children(i).Code
                                Case "SEDEPARTMENT" : z0109.seDepartment = Children(i).Code
                                Case "CDDEPARTMENT" : z0109.cdDepartment = Children(i).Code
                                Case "SUPPLIERCODE" : z0109.SupplierCode = Children(i).Code
                                Case "PRICE" : z0109.Price = Children(i).Code
                                Case "SEUNITPRICE" : z0109.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z0109.cdUnitPrice = Children(i).Code
                                Case "QTYCOMPONENT" : z0109.QtyComponent = Children(i).Code
                                Case "MATERIALAMT" : z0109.MaterialAMT = Children(i).Code
                                Case "SESUBPROCESS" : z0109.seSubProcess = Children(i).Code
                                Case "CDSUBPROCESS" : z0109.cdSubProcess = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z0109.Autokey = Children(i).Data
                                Case "DSEQ" : z0109.Dseq = Children(i).Data
                                Case "SPECNO" : z0109.SpecNo = Children(i).Data
                                Case "SPECNOSEQ" : z0109.SpecNoSeq = Children(i).Data
                                Case "MATERIALSEQ" : z0109.MaterialSeq = Children(i).Data
                                Case "SIZENO" : z0109.SizeNo = Children(i).Data
                                Case "SIZENONAME" : z0109.SizeNoName = Children(i).Data
                                Case "MATERIALCODE" : z0109.MaterialCode = Children(i).Data
                                Case "COLOR" : z0109.Color = Children(i).Data
                                Case "SPECIFICATION" : z0109.Specification = Children(i).Data
                                Case "WIDTH" : z0109.Width = Children(i).Data
                                Case "HEIGHT" : z0109.Height = Children(i).Data
                                Case "SIZENAME" : z0109.SizeName = Children(i).Data
                                Case "COLORNAME" : z0109.ColorName = Children(i).Data
                                Case "QTYSIZE" : z0109.QtySize = Children(i).Data
                                Case "LOSSSIZE" : z0109.LossSize = Children(i).Data
                                Case "QTYUSAGE" : z0109.QtyUsage = Children(i).Data
                                Case "SEUNITMATERIAL" : z0109.seUnitMaterial = Children(i).Data
                                Case "CDUNITMATERIAL" : z0109.cdUnitmaterial = Children(i).Data
                                Case "SESHOESSTATUS" : z0109.seShoesStatus = Children(i).Data
                                Case "CDSHOESSTATUS" : z0109.cdShoesStatus = Children(i).Data
                                Case "SEDEPARTMENT" : z0109.seDepartment = Children(i).Data
                                Case "CDDEPARTMENT" : z0109.cdDepartment = Children(i).Data
                                Case "SUPPLIERCODE" : z0109.SupplierCode = Children(i).Data
                                Case "PRICE" : z0109.Price = Children(i).Data
                                Case "SEUNITPRICE" : z0109.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z0109.cdUnitPrice = Children(i).Data
                                Case "QTYCOMPONENT" : z0109.QtyComponent = Children(i).Data
                                Case "MATERIALAMT" : z0109.MaterialAMT = Children(i).Data
                                Case "SESUBPROCESS" : z0109.seSubProcess = Children(i).Data
                                Case "CDSUBPROCESS" : z0109.cdSubProcess = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K0109_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K0109_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z0109 As T0109_AREA, Job As String, CheckClear As Boolean, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K0109_MOVE = False

        Try
            If READ_PFK0109(AUTOKEY) = True Then
                z0109 = D0109
                K0109_MOVE = True
            Else
                If CheckClear = True Then z0109 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0109")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z0109.Autokey = Children(i).Code
                                Case "DSEQ" : z0109.Dseq = Children(i).Code
                                Case "SPECNO" : z0109.SpecNo = Children(i).Code
                                Case "SPECNOSEQ" : z0109.SpecNoSeq = Children(i).Code
                                Case "MATERIALSEQ" : z0109.MaterialSeq = Children(i).Code
                                Case "SIZENO" : z0109.SizeNo = Children(i).Code
                                Case "SIZENONAME" : z0109.SizeNoName = Children(i).Code
                                Case "MATERIALCODE" : z0109.MaterialCode = Children(i).Code
                                Case "COLOR" : z0109.Color = Children(i).Code
                                Case "SPECIFICATION" : z0109.Specification = Children(i).Code
                                Case "WIDTH" : z0109.Width = Children(i).Code
                                Case "HEIGHT" : z0109.Height = Children(i).Code
                                Case "SIZENAME" : z0109.SizeName = Children(i).Code
                                Case "COLORNAME" : z0109.ColorName = Children(i).Code
                                Case "QTYSIZE" : z0109.QtySize = Children(i).Code
                                Case "LOSSSIZE" : z0109.LossSize = Children(i).Code
                                Case "QTYUSAGE" : z0109.QtyUsage = Children(i).Code
                                Case "SEUNITMATERIAL" : z0109.seUnitMaterial = Children(i).Code
                                Case "CDUNITMATERIAL" : z0109.cdUnitmaterial = Children(i).Code
                                Case "SESHOESSTATUS" : z0109.seShoesStatus = Children(i).Code
                                Case "CDSHOESSTATUS" : z0109.cdShoesStatus = Children(i).Code
                                Case "SEDEPARTMENT" : z0109.seDepartment = Children(i).Code
                                Case "CDDEPARTMENT" : z0109.cdDepartment = Children(i).Code
                                Case "SUPPLIERCODE" : z0109.SupplierCode = Children(i).Code
                                Case "PRICE" : z0109.Price = Children(i).Code
                                Case "SEUNITPRICE" : z0109.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z0109.cdUnitPrice = Children(i).Code
                                Case "QTYCOMPONENT" : z0109.QtyComponent = Children(i).Code
                                Case "MATERIALAMT" : z0109.MaterialAMT = Children(i).Code
                                Case "SESUBPROCESS" : z0109.seSubProcess = Children(i).Code
                                Case "CDSUBPROCESS" : z0109.cdSubProcess = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z0109.Autokey = Children(i).Data
                                Case "DSEQ" : z0109.Dseq = Children(i).Data
                                Case "SPECNO" : z0109.SpecNo = Children(i).Data
                                Case "SPECNOSEQ" : z0109.SpecNoSeq = Children(i).Data
                                Case "MATERIALSEQ" : z0109.MaterialSeq = Children(i).Data
                                Case "SIZENO" : z0109.SizeNo = Children(i).Data
                                Case "SIZENONAME" : z0109.SizeNoName = Children(i).Data
                                Case "MATERIALCODE" : z0109.MaterialCode = Children(i).Data
                                Case "COLOR" : z0109.Color = Children(i).Data
                                Case "SPECIFICATION" : z0109.Specification = Children(i).Data
                                Case "WIDTH" : z0109.Width = Children(i).Data
                                Case "HEIGHT" : z0109.Height = Children(i).Data
                                Case "SIZENAME" : z0109.SizeName = Children(i).Data
                                Case "COLORNAME" : z0109.ColorName = Children(i).Data
                                Case "QTYSIZE" : z0109.QtySize = Children(i).Data
                                Case "LOSSSIZE" : z0109.LossSize = Children(i).Data
                                Case "QTYUSAGE" : z0109.QtyUsage = Children(i).Data
                                Case "SEUNITMATERIAL" : z0109.seUnitMaterial = Children(i).Data
                                Case "CDUNITMATERIAL" : z0109.cdUnitmaterial = Children(i).Data
                                Case "SESHOESSTATUS" : z0109.seShoesStatus = Children(i).Data
                                Case "CDSHOESSTATUS" : z0109.cdShoesStatus = Children(i).Data
                                Case "SEDEPARTMENT" : z0109.seDepartment = Children(i).Data
                                Case "CDDEPARTMENT" : z0109.cdDepartment = Children(i).Data
                                Case "SUPPLIERCODE" : z0109.SupplierCode = Children(i).Data
                                Case "PRICE" : z0109.Price = Children(i).Data
                                Case "SEUNITPRICE" : z0109.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z0109.cdUnitPrice = Children(i).Data
                                Case "QTYCOMPONENT" : z0109.QtyComponent = Children(i).Data
                                Case "MATERIALAMT" : z0109.MaterialAMT = Children(i).Data
                                Case "SESUBPROCESS" : z0109.seSubProcess = Children(i).Data
                                Case "CDSUBPROCESS" : z0109.cdSubProcess = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K0109_MOVE", vbCritical)
        End Try
    End Function

End Module
