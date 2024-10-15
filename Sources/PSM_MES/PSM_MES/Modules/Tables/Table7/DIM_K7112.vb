'=========================================================================================================================================================
'   TABLE : (PFK7112)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7112

Structure T7112_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	UploadNo	 AS String	'			char(9)		*
Public 	UploadSeq	 AS Double	'			decimal		*
Public 	NameUpload	 AS String	'			nvarchar(50)
        Public CheckType As String  '			char(1)
        Public DateUpload As String  '			char(8)
        Public InchargeUpload As String  '			char(8)
        Public ComponentName As String  '			nvarchar(50)
        Public cdTypeCode As String  '			char(3)
        Public TypeCode As String  '			char(6)
        Public TypeName As String  '			nvarchar(50)
        Public Specification As String  '			nvarchar(20)
        Public Spec1 As String  '			nvarchar(50)
        Public Spec2 As String  '			nvarchar(50)
        Public Spec3 As String  '			nvarchar(50)
        Public Spec4 As String  '			nvarchar(50)
        Public Width As String  '			nvarchar(20)
        Public Height As String  '			nvarchar(20)
        Public seMainProcess As String  '			char(3)
        Public cdMainProcess As String  '			char(3)
        Public seSubProcess As String  '			char(3)
        Public cdSubProcess As String  '			char(3)
        Public seSpecialProcess As String  '			char(3)
        Public cdSpecialProcess As String  '			char(3)
        Public seUnitMaterial As String  '			char(3)
        Public cdUnitMaterial As String  '			char(3)
        Public BaseComponentBOM As String  '			char(6)
        Public ShoesCode As String  '			char(6)
        Public Dseq As Double  '			decimal
        Public Loss As Double  '			decimal
        Public QtyComponent As Double  '			decimal
        Public CSizeQty01 As Double  '			decimal
        Public CSizeQty02 As Double  '			decimal
        Public CSizeQty03 As Double  '			decimal
        Public CSizeQty04 As Double  '			decimal
        Public CSizeQty05 As Double  '			decimal
        Public CSizeQty06 As Double  '			decimal
        Public CSizeQty07 As Double  '			decimal
        Public CSizeQty08 As Double  '			decimal
        Public CSizeQty09 As Double  '			decimal
        Public CSizeQty10 As Double  '			decimal
        Public CSizeQty11 As Double  '			decimal
        Public CSizeQty12 As Double  '			decimal
        Public CSizeQty13 As Double  '			decimal
        Public CSizeQty14 As Double  '			decimal
        Public CSizeQty15 As Double  '			decimal
        Public CSizeQty16 As Double  '			decimal
        Public CSizeQty17 As Double  '			decimal
        Public CSizeQty18 As Double  '			decimal
        Public CSizeQty19 As Double  '			decimal
        Public CSizeQty20 As Double  '			decimal
        Public CSizeQty21 As Double  '			decimal
        Public CSizeQty22 As Double  '			decimal
        Public CSizeQty23 As Double  '			decimal
        Public CSizeQty24 As Double  '			decimal
        Public CSizeQty25 As Double  '			decimal
        Public CSizeQty26 As Double  '			decimal
        Public CSizeQty27 As Double  '			decimal
        Public CSizeQty28 As Double  '			decimal
        Public CSizeQty29 As Double  '			decimal
        Public CSizeQty30 As Double  '			decimal
        Public Remark As String  '			nvarchar(50)
        '=========================================================================================================================================================
    End Structure

    Public D7112 As T7112_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK7112(UPLOADNO As String, UPLOADSEQ As Double) As Boolean
        READ_PFK7112 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7112 "
            SQL = SQL & " WHERE K7112_UploadNo		 = '" & UploadNo & "' "
            SQL = SQL & "   AND K7112_UploadSeq		 =  " & UploadSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7112_CLEAR() : GoTo SKIP_READ_PFK7112

            Call K7112_MOVE(rd)
            READ_PFK7112 = True

SKIP_READ_PFK7112:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7112", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK7112(UPLOADNO As String, UPLOADSEQ As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7112 "
            SQL = SQL & " WHERE K7112_UploadNo		 = '" & UploadNo & "' "
            SQL = SQL & "   AND K7112_UploadSeq		 =  " & UploadSeq & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK7112", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK7112(z7112 As T7112_AREA) As Boolean
        WRITE_PFK7112 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7112)

            SQL = " INSERT INTO PFK7112 "
            SQL = SQL & " ( "
            SQL = SQL & " K7112_UploadNo,"
            SQL = SQL & " K7112_UploadSeq,"
            SQL = SQL & " K7112_NameUpload,"
            SQL = SQL & " K7112_CheckType,"
            SQL = SQL & " K7112_DateUpload,"
            SQL = SQL & " K7112_InchargeUpload,"
            SQL = SQL & " K7112_ComponentName,"
            SQL = SQL & " K7112_cdTypeCode,"
            SQL = SQL & " K7112_TypeCode,"
            SQL = SQL & " K7112_TypeName,"
            SQL = SQL & " K7112_Specification,"
            SQL = SQL & " K7112_Spec1,"
            SQL = SQL & " K7112_Spec2,"
            SQL = SQL & " K7112_Spec3,"
            SQL = SQL & " K7112_Spec4,"
            SQL = SQL & " K7112_Width,"
            SQL = SQL & " K7112_Height,"
            SQL = SQL & " K7112_seMainProcess,"
            SQL = SQL & " K7112_cdMainProcess,"
            SQL = SQL & " K7112_seSubProcess,"
            SQL = SQL & " K7112_cdSubProcess,"
            SQL = SQL & " K7112_seSpecialProcess,"
            SQL = SQL & " K7112_cdSpecialProcess,"
            SQL = SQL & " K7112_seUnitMaterial,"
            SQL = SQL & " K7112_cdUnitMaterial,"
            SQL = SQL & " K7112_BaseComponentBOM,"
            SQL = SQL & " K7112_ShoesCode,"
            SQL = SQL & " K7112_Dseq,"
            SQL = SQL & " K7112_Loss,"
            SQL = SQL & " K7112_QtyComponent,"
            SQL = SQL & " K7112_CSizeQty01,"
            SQL = SQL & " K7112_CSizeQty02,"
            SQL = SQL & " K7112_CSizeQty03,"
            SQL = SQL & " K7112_CSizeQty04,"
            SQL = SQL & " K7112_CSizeQty05,"
            SQL = SQL & " K7112_CSizeQty06,"
            SQL = SQL & " K7112_CSizeQty07,"
            SQL = SQL & " K7112_CSizeQty08,"
            SQL = SQL & " K7112_CSizeQty09,"
            SQL = SQL & " K7112_CSizeQty10,"
            SQL = SQL & " K7112_CSizeQty11,"
            SQL = SQL & " K7112_CSizeQty12,"
            SQL = SQL & " K7112_CSizeQty13,"
            SQL = SQL & " K7112_CSizeQty14,"
            SQL = SQL & " K7112_CSizeQty15,"
            SQL = SQL & " K7112_CSizeQty16,"
            SQL = SQL & " K7112_CSizeQty17,"
            SQL = SQL & " K7112_CSizeQty18,"
            SQL = SQL & " K7112_CSizeQty19,"
            SQL = SQL & " K7112_CSizeQty20,"
            SQL = SQL & " K7112_CSizeQty21,"
            SQL = SQL & " K7112_CSizeQty22,"
            SQL = SQL & " K7112_CSizeQty23,"
            SQL = SQL & " K7112_CSizeQty24,"
            SQL = SQL & " K7112_CSizeQty25,"
            SQL = SQL & " K7112_CSizeQty26,"
            SQL = SQL & " K7112_CSizeQty27,"
            SQL = SQL & " K7112_CSizeQty28,"
            SQL = SQL & " K7112_CSizeQty29,"
            SQL = SQL & " K7112_CSizeQty30,"
            SQL = SQL & " K7112_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z7112.UploadNo) & "', "
            SQL = SQL & "   " & FormatSQL(z7112.UploadSeq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7112.NameUpload) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7112.CheckType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7112.DateUpload) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7112.InchargeUpload) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7112.ComponentName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7112.cdTypeCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7112.TypeCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7112.TypeName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7112.Specification) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7112.Spec1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7112.Spec2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7112.Spec3) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7112.Spec4) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7112.Width) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7112.Height) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7112.seMainProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7112.cdMainProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7112.seSubProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7112.cdSubProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7112.seSpecialProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7112.cdSpecialProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7112.seUnitMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7112.cdUnitMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7112.BaseComponentBOM) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7112.ShoesCode) & "', "
            SQL = SQL & "   " & FormatSQL(z7112.Dseq) & ", "
            SQL = SQL & "   " & FormatSQL(z7112.Loss) & ", "
            SQL = SQL & "   " & FormatSQL(z7112.QtyComponent) & ", "
            SQL = SQL & "   " & FormatSQL(z7112.CSizeQty01) & ", "
            SQL = SQL & "   " & FormatSQL(z7112.CSizeQty02) & ", "
            SQL = SQL & "   " & FormatSQL(z7112.CSizeQty03) & ", "
            SQL = SQL & "   " & FormatSQL(z7112.CSizeQty04) & ", "
            SQL = SQL & "   " & FormatSQL(z7112.CSizeQty05) & ", "
            SQL = SQL & "   " & FormatSQL(z7112.CSizeQty06) & ", "
            SQL = SQL & "   " & FormatSQL(z7112.CSizeQty07) & ", "
            SQL = SQL & "   " & FormatSQL(z7112.CSizeQty08) & ", "
            SQL = SQL & "   " & FormatSQL(z7112.CSizeQty09) & ", "
            SQL = SQL & "   " & FormatSQL(z7112.CSizeQty10) & ", "
            SQL = SQL & "   " & FormatSQL(z7112.CSizeQty11) & ", "
            SQL = SQL & "   " & FormatSQL(z7112.CSizeQty12) & ", "
            SQL = SQL & "   " & FormatSQL(z7112.CSizeQty13) & ", "
            SQL = SQL & "   " & FormatSQL(z7112.CSizeQty14) & ", "
            SQL = SQL & "   " & FormatSQL(z7112.CSizeQty15) & ", "
            SQL = SQL & "   " & FormatSQL(z7112.CSizeQty16) & ", "
            SQL = SQL & "   " & FormatSQL(z7112.CSizeQty17) & ", "
            SQL = SQL & "   " & FormatSQL(z7112.CSizeQty18) & ", "
            SQL = SQL & "   " & FormatSQL(z7112.CSizeQty19) & ", "
            SQL = SQL & "   " & FormatSQL(z7112.CSizeQty20) & ", "
            SQL = SQL & "   " & FormatSQL(z7112.CSizeQty21) & ", "
            SQL = SQL & "   " & FormatSQL(z7112.CSizeQty22) & ", "
            SQL = SQL & "   " & FormatSQL(z7112.CSizeQty23) & ", "
            SQL = SQL & "   " & FormatSQL(z7112.CSizeQty24) & ", "
            SQL = SQL & "   " & FormatSQL(z7112.CSizeQty25) & ", "
            SQL = SQL & "   " & FormatSQL(z7112.CSizeQty26) & ", "
            SQL = SQL & "   " & FormatSQL(z7112.CSizeQty27) & ", "
            SQL = SQL & "   " & FormatSQL(z7112.CSizeQty28) & ", "
            SQL = SQL & "   " & FormatSQL(z7112.CSizeQty29) & ", "
            SQL = SQL & "   " & FormatSQL(z7112.CSizeQty30) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7112.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK7112 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK7112", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK7112(z7112 As T7112_AREA) As Boolean
        REWRITE_PFK7112 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7112)

            SQL = " UPDATE PFK7112 SET "
            SQL = SQL & "    K7112_NameUpload      = N'" & FormatSQL(z7112.NameUpload) & "', "
            SQL = SQL & "    K7112_CheckType      = N'" & FormatSQL(z7112.CheckType) & "', "
            SQL = SQL & "    K7112_DateUpload      = N'" & FormatSQL(z7112.DateUpload) & "', "
            SQL = SQL & "    K7112_InchargeUpload      = N'" & FormatSQL(z7112.InchargeUpload) & "', "
            SQL = SQL & "    K7112_ComponentName      = N'" & FormatSQL(z7112.ComponentName) & "', "
            SQL = SQL & "    K7112_cdTypeCode      = N'" & FormatSQL(z7112.cdTypeCode) & "', "
            SQL = SQL & "    K7112_TypeCode      = N'" & FormatSQL(z7112.TypeCode) & "', "
            SQL = SQL & "    K7112_TypeName      = N'" & FormatSQL(z7112.TypeName) & "', "
            SQL = SQL & "    K7112_Specification      = N'" & FormatSQL(z7112.Specification) & "', "
            SQL = SQL & "    K7112_Spec1      = N'" & FormatSQL(z7112.Spec1) & "', "
            SQL = SQL & "    K7112_Spec2      = N'" & FormatSQL(z7112.Spec2) & "', "
            SQL = SQL & "    K7112_Spec3      = N'" & FormatSQL(z7112.Spec3) & "', "
            SQL = SQL & "    K7112_Spec4      = N'" & FormatSQL(z7112.Spec4) & "', "
            SQL = SQL & "    K7112_Width      = N'" & FormatSQL(z7112.Width) & "', "
            SQL = SQL & "    K7112_Height      = N'" & FormatSQL(z7112.Height) & "', "
            SQL = SQL & "    K7112_seMainProcess      = N'" & FormatSQL(z7112.seMainProcess) & "', "
            SQL = SQL & "    K7112_cdMainProcess      = N'" & FormatSQL(z7112.cdMainProcess) & "', "
            SQL = SQL & "    K7112_seSubProcess      = N'" & FormatSQL(z7112.seSubProcess) & "', "
            SQL = SQL & "    K7112_cdSubProcess      = N'" & FormatSQL(z7112.cdSubProcess) & "', "
            SQL = SQL & "    K7112_seSpecialProcess      = N'" & FormatSQL(z7112.seSpecialProcess) & "', "
            SQL = SQL & "    K7112_cdSpecialProcess      = N'" & FormatSQL(z7112.cdSpecialProcess) & "', "
            SQL = SQL & "    K7112_seUnitMaterial      = N'" & FormatSQL(z7112.seUnitMaterial) & "', "
            SQL = SQL & "    K7112_cdUnitMaterial      = N'" & FormatSQL(z7112.cdUnitMaterial) & "', "
            SQL = SQL & "    K7112_BaseComponentBOM      = N'" & FormatSQL(z7112.BaseComponentBOM) & "', "
            SQL = SQL & "    K7112_ShoesCode      = N'" & FormatSQL(z7112.ShoesCode) & "', "
            SQL = SQL & "    K7112_Dseq      =  " & FormatSQL(z7112.Dseq) & ", "
            SQL = SQL & "    K7112_Loss      =  " & FormatSQL(z7112.Loss) & ", "
            SQL = SQL & "    K7112_QtyComponent      =  " & FormatSQL(z7112.QtyComponent) & ", "
            SQL = SQL & "    K7112_CSizeQty01      =  " & FormatSQL(z7112.CSizeQty01) & ", "
            SQL = SQL & "    K7112_CSizeQty02      =  " & FormatSQL(z7112.CSizeQty02) & ", "
            SQL = SQL & "    K7112_CSizeQty03      =  " & FormatSQL(z7112.CSizeQty03) & ", "
            SQL = SQL & "    K7112_CSizeQty04      =  " & FormatSQL(z7112.CSizeQty04) & ", "
            SQL = SQL & "    K7112_CSizeQty05      =  " & FormatSQL(z7112.CSizeQty05) & ", "
            SQL = SQL & "    K7112_CSizeQty06      =  " & FormatSQL(z7112.CSizeQty06) & ", "
            SQL = SQL & "    K7112_CSizeQty07      =  " & FormatSQL(z7112.CSizeQty07) & ", "
            SQL = SQL & "    K7112_CSizeQty08      =  " & FormatSQL(z7112.CSizeQty08) & ", "
            SQL = SQL & "    K7112_CSizeQty09      =  " & FormatSQL(z7112.CSizeQty09) & ", "
            SQL = SQL & "    K7112_CSizeQty10      =  " & FormatSQL(z7112.CSizeQty10) & ", "
            SQL = SQL & "    K7112_CSizeQty11      =  " & FormatSQL(z7112.CSizeQty11) & ", "
            SQL = SQL & "    K7112_CSizeQty12      =  " & FormatSQL(z7112.CSizeQty12) & ", "
            SQL = SQL & "    K7112_CSizeQty13      =  " & FormatSQL(z7112.CSizeQty13) & ", "
            SQL = SQL & "    K7112_CSizeQty14      =  " & FormatSQL(z7112.CSizeQty14) & ", "
            SQL = SQL & "    K7112_CSizeQty15      =  " & FormatSQL(z7112.CSizeQty15) & ", "
            SQL = SQL & "    K7112_CSizeQty16      =  " & FormatSQL(z7112.CSizeQty16) & ", "
            SQL = SQL & "    K7112_CSizeQty17      =  " & FormatSQL(z7112.CSizeQty17) & ", "
            SQL = SQL & "    K7112_CSizeQty18      =  " & FormatSQL(z7112.CSizeQty18) & ", "
            SQL = SQL & "    K7112_CSizeQty19      =  " & FormatSQL(z7112.CSizeQty19) & ", "
            SQL = SQL & "    K7112_CSizeQty20      =  " & FormatSQL(z7112.CSizeQty20) & ", "
            SQL = SQL & "    K7112_CSizeQty21      =  " & FormatSQL(z7112.CSizeQty21) & ", "
            SQL = SQL & "    K7112_CSizeQty22      =  " & FormatSQL(z7112.CSizeQty22) & ", "
            SQL = SQL & "    K7112_CSizeQty23      =  " & FormatSQL(z7112.CSizeQty23) & ", "
            SQL = SQL & "    K7112_CSizeQty24      =  " & FormatSQL(z7112.CSizeQty24) & ", "
            SQL = SQL & "    K7112_CSizeQty25      =  " & FormatSQL(z7112.CSizeQty25) & ", "
            SQL = SQL & "    K7112_CSizeQty26      =  " & FormatSQL(z7112.CSizeQty26) & ", "
            SQL = SQL & "    K7112_CSizeQty27      =  " & FormatSQL(z7112.CSizeQty27) & ", "
            SQL = SQL & "    K7112_CSizeQty28      =  " & FormatSQL(z7112.CSizeQty28) & ", "
            SQL = SQL & "    K7112_CSizeQty29      =  " & FormatSQL(z7112.CSizeQty29) & ", "
            SQL = SQL & "    K7112_CSizeQty30      =  " & FormatSQL(z7112.CSizeQty30) & ", "
            SQL = SQL & "    K7112_Remark      = N'" & FormatSQL(z7112.Remark) & "'  "
            SQL = SQL & " WHERE K7112_UploadNo		 = '" & z7112.UploadNo & "' "
            SQL = SQL & "   AND K7112_UploadSeq		 =  " & z7112.UploadSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK7112 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK7112", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK7112(z7112 As T7112_AREA) As Boolean
        DELETE_PFK7112 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK7112 "
            SQL = SQL & " WHERE K7112_UploadNo		 = '" & z7112.UploadNo & "' "
            SQL = SQL & "   AND K7112_UploadSeq		 =  " & z7112.UploadSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK7112 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK7112", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D7112_CLEAR()
        Try

            D7112.UploadNo = ""
            D7112.UploadSeq = 0
            D7112.NameUpload = ""
            D7112.CheckType = ""
            D7112.DateUpload = ""
            D7112.InchargeUpload = ""
            D7112.ComponentName = ""
            D7112.cdTypeCode = ""
            D7112.TypeCode = ""
            D7112.TypeName = ""
            D7112.Specification = ""
            D7112.Spec1 = ""
            D7112.Spec2 = ""
            D7112.Spec3 = ""
            D7112.Spec4 = ""
            D7112.Width = ""
            D7112.Height = ""
            D7112.seMainProcess = ""
            D7112.cdMainProcess = ""
            D7112.seSubProcess = ""
            D7112.cdSubProcess = ""
            D7112.seSpecialProcess = ""
            D7112.cdSpecialProcess = ""
            D7112.seUnitMaterial = ""
            D7112.cdUnitMaterial = ""
            D7112.BaseComponentBOM = ""
            D7112.ShoesCode = ""
            D7112.Dseq = 0
            D7112.Loss = 0
            D7112.QtyComponent = 0
            D7112.CSizeQty01 = 0
            D7112.CSizeQty02 = 0
            D7112.CSizeQty03 = 0
            D7112.CSizeQty04 = 0
            D7112.CSizeQty05 = 0
            D7112.CSizeQty06 = 0
            D7112.CSizeQty07 = 0
            D7112.CSizeQty08 = 0
            D7112.CSizeQty09 = 0
            D7112.CSizeQty10 = 0
            D7112.CSizeQty11 = 0
            D7112.CSizeQty12 = 0
            D7112.CSizeQty13 = 0
            D7112.CSizeQty14 = 0
            D7112.CSizeQty15 = 0
            D7112.CSizeQty16 = 0
            D7112.CSizeQty17 = 0
            D7112.CSizeQty18 = 0
            D7112.CSizeQty19 = 0
            D7112.CSizeQty20 = 0
            D7112.CSizeQty21 = 0
            D7112.CSizeQty22 = 0
            D7112.CSizeQty23 = 0
            D7112.CSizeQty24 = 0
            D7112.CSizeQty25 = 0
            D7112.CSizeQty26 = 0
            D7112.CSizeQty27 = 0
            D7112.CSizeQty28 = 0
            D7112.CSizeQty29 = 0
            D7112.CSizeQty30 = 0
            D7112.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D7112_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x7112 As T7112_AREA)
        Try

            x7112.UploadNo = trim$(x7112.UploadNo)
            x7112.UploadSeq = trim$(x7112.UploadSeq)
            x7112.NameUpload = trim$(x7112.NameUpload)
            x7112.CheckType = trim$(x7112.CheckType)
            x7112.DateUpload = trim$(x7112.DateUpload)
            x7112.InchargeUpload = trim$(x7112.InchargeUpload)
            x7112.ComponentName = trim$(x7112.ComponentName)
            x7112.cdTypeCode = trim$(x7112.cdTypeCode)
            x7112.TypeCode = trim$(x7112.TypeCode)
            x7112.TypeName = trim$(x7112.TypeName)
            x7112.Specification = trim$(x7112.Specification)
            x7112.Spec1 = trim$(x7112.Spec1)
            x7112.Spec2 = trim$(x7112.Spec2)
            x7112.Spec3 = trim$(x7112.Spec3)
            x7112.Spec4 = trim$(x7112.Spec4)
            x7112.Width = trim$(x7112.Width)
            x7112.Height = trim$(x7112.Height)
            x7112.seMainProcess = trim$(x7112.seMainProcess)
            x7112.cdMainProcess = trim$(x7112.cdMainProcess)
            x7112.seSubProcess = trim$(x7112.seSubProcess)
            x7112.cdSubProcess = trim$(x7112.cdSubProcess)
            x7112.seSpecialProcess = trim$(x7112.seSpecialProcess)
            x7112.cdSpecialProcess = trim$(x7112.cdSpecialProcess)
            x7112.seUnitMaterial = trim$(x7112.seUnitMaterial)
            x7112.cdUnitMaterial = trim$(x7112.cdUnitMaterial)
            x7112.BaseComponentBOM = trim$(x7112.BaseComponentBOM)
            x7112.ShoesCode = trim$(x7112.ShoesCode)
            x7112.Dseq = trim$(x7112.Dseq)
            x7112.Loss = trim$(x7112.Loss)
            x7112.QtyComponent = trim$(x7112.QtyComponent)
            x7112.CSizeQty01 = trim$(x7112.CSizeQty01)
            x7112.CSizeQty02 = trim$(x7112.CSizeQty02)
            x7112.CSizeQty03 = trim$(x7112.CSizeQty03)
            x7112.CSizeQty04 = trim$(x7112.CSizeQty04)
            x7112.CSizeQty05 = trim$(x7112.CSizeQty05)
            x7112.CSizeQty06 = trim$(x7112.CSizeQty06)
            x7112.CSizeQty07 = trim$(x7112.CSizeQty07)
            x7112.CSizeQty08 = trim$(x7112.CSizeQty08)
            x7112.CSizeQty09 = trim$(x7112.CSizeQty09)
            x7112.CSizeQty10 = trim$(x7112.CSizeQty10)
            x7112.CSizeQty11 = trim$(x7112.CSizeQty11)
            x7112.CSizeQty12 = trim$(x7112.CSizeQty12)
            x7112.CSizeQty13 = trim$(x7112.CSizeQty13)
            x7112.CSizeQty14 = trim$(x7112.CSizeQty14)
            x7112.CSizeQty15 = trim$(x7112.CSizeQty15)
            x7112.CSizeQty16 = trim$(x7112.CSizeQty16)
            x7112.CSizeQty17 = trim$(x7112.CSizeQty17)
            x7112.CSizeQty18 = trim$(x7112.CSizeQty18)
            x7112.CSizeQty19 = trim$(x7112.CSizeQty19)
            x7112.CSizeQty20 = trim$(x7112.CSizeQty20)
            x7112.CSizeQty21 = trim$(x7112.CSizeQty21)
            x7112.CSizeQty22 = trim$(x7112.CSizeQty22)
            x7112.CSizeQty23 = trim$(x7112.CSizeQty23)
            x7112.CSizeQty24 = trim$(x7112.CSizeQty24)
            x7112.CSizeQty25 = trim$(x7112.CSizeQty25)
            x7112.CSizeQty26 = trim$(x7112.CSizeQty26)
            x7112.CSizeQty27 = trim$(x7112.CSizeQty27)
            x7112.CSizeQty28 = trim$(x7112.CSizeQty28)
            x7112.CSizeQty29 = trim$(x7112.CSizeQty29)
            x7112.CSizeQty30 = trim$(x7112.CSizeQty30)
            x7112.Remark = trim$(x7112.Remark)

            If trim$(x7112.UploadNo) = "" Then x7112.UploadNo = Space(1)
            If trim$(x7112.UploadSeq) = "" Then x7112.UploadSeq = 0
            If trim$(x7112.NameUpload) = "" Then x7112.NameUpload = Space(1)
            If trim$(x7112.CheckType) = "" Then x7112.CheckType = Space(1)
            If trim$(x7112.DateUpload) = "" Then x7112.DateUpload = Space(1)
            If trim$(x7112.InchargeUpload) = "" Then x7112.InchargeUpload = Space(1)
            If trim$(x7112.ComponentName) = "" Then x7112.ComponentName = Space(1)
            If trim$(x7112.cdTypeCode) = "" Then x7112.cdTypeCode = Space(1)
            If trim$(x7112.TypeCode) = "" Then x7112.TypeCode = Space(1)
            If trim$(x7112.TypeName) = "" Then x7112.TypeName = Space(1)
            If trim$(x7112.Specification) = "" Then x7112.Specification = Space(1)
            If trim$(x7112.Spec1) = "" Then x7112.Spec1 = Space(1)
            If trim$(x7112.Spec2) = "" Then x7112.Spec2 = Space(1)
            If trim$(x7112.Spec3) = "" Then x7112.Spec3 = Space(1)
            If trim$(x7112.Spec4) = "" Then x7112.Spec4 = Space(1)
            If trim$(x7112.Width) = "" Then x7112.Width = Space(1)
            If trim$(x7112.Height) = "" Then x7112.Height = Space(1)
            If trim$(x7112.seMainProcess) = "" Then x7112.seMainProcess = Space(1)
            If trim$(x7112.cdMainProcess) = "" Then x7112.cdMainProcess = Space(1)
            If trim$(x7112.seSubProcess) = "" Then x7112.seSubProcess = Space(1)
            If trim$(x7112.cdSubProcess) = "" Then x7112.cdSubProcess = Space(1)
            If trim$(x7112.seSpecialProcess) = "" Then x7112.seSpecialProcess = Space(1)
            If trim$(x7112.cdSpecialProcess) = "" Then x7112.cdSpecialProcess = Space(1)
            If trim$(x7112.seUnitMaterial) = "" Then x7112.seUnitMaterial = Space(1)
            If trim$(x7112.cdUnitMaterial) = "" Then x7112.cdUnitMaterial = Space(1)
            If trim$(x7112.BaseComponentBOM) = "" Then x7112.BaseComponentBOM = Space(1)
            If trim$(x7112.ShoesCode) = "" Then x7112.ShoesCode = Space(1)
            If trim$(x7112.Dseq) = "" Then x7112.Dseq = 0
            If trim$(x7112.Loss) = "" Then x7112.Loss = 0
            If trim$(x7112.QtyComponent) = "" Then x7112.QtyComponent = 0
            If trim$(x7112.CSizeQty01) = "" Then x7112.CSizeQty01 = 0
            If trim$(x7112.CSizeQty02) = "" Then x7112.CSizeQty02 = 0
            If trim$(x7112.CSizeQty03) = "" Then x7112.CSizeQty03 = 0
            If trim$(x7112.CSizeQty04) = "" Then x7112.CSizeQty04 = 0
            If trim$(x7112.CSizeQty05) = "" Then x7112.CSizeQty05 = 0
            If trim$(x7112.CSizeQty06) = "" Then x7112.CSizeQty06 = 0
            If trim$(x7112.CSizeQty07) = "" Then x7112.CSizeQty07 = 0
            If trim$(x7112.CSizeQty08) = "" Then x7112.CSizeQty08 = 0
            If trim$(x7112.CSizeQty09) = "" Then x7112.CSizeQty09 = 0
            If trim$(x7112.CSizeQty10) = "" Then x7112.CSizeQty10 = 0
            If trim$(x7112.CSizeQty11) = "" Then x7112.CSizeQty11 = 0
            If trim$(x7112.CSizeQty12) = "" Then x7112.CSizeQty12 = 0
            If trim$(x7112.CSizeQty13) = "" Then x7112.CSizeQty13 = 0
            If trim$(x7112.CSizeQty14) = "" Then x7112.CSizeQty14 = 0
            If trim$(x7112.CSizeQty15) = "" Then x7112.CSizeQty15 = 0
            If trim$(x7112.CSizeQty16) = "" Then x7112.CSizeQty16 = 0
            If trim$(x7112.CSizeQty17) = "" Then x7112.CSizeQty17 = 0
            If trim$(x7112.CSizeQty18) = "" Then x7112.CSizeQty18 = 0
            If trim$(x7112.CSizeQty19) = "" Then x7112.CSizeQty19 = 0
            If trim$(x7112.CSizeQty20) = "" Then x7112.CSizeQty20 = 0
            If trim$(x7112.CSizeQty21) = "" Then x7112.CSizeQty21 = 0
            If trim$(x7112.CSizeQty22) = "" Then x7112.CSizeQty22 = 0
            If trim$(x7112.CSizeQty23) = "" Then x7112.CSizeQty23 = 0
            If trim$(x7112.CSizeQty24) = "" Then x7112.CSizeQty24 = 0
            If trim$(x7112.CSizeQty25) = "" Then x7112.CSizeQty25 = 0
            If trim$(x7112.CSizeQty26) = "" Then x7112.CSizeQty26 = 0
            If trim$(x7112.CSizeQty27) = "" Then x7112.CSizeQty27 = 0
            If trim$(x7112.CSizeQty28) = "" Then x7112.CSizeQty28 = 0
            If trim$(x7112.CSizeQty29) = "" Then x7112.CSizeQty29 = 0
            If trim$(x7112.CSizeQty30) = "" Then x7112.CSizeQty30 = 0
            If trim$(x7112.Remark) = "" Then x7112.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K7112_MOVE(rs7112 As SqlClient.SqlDataReader)
        Try

            Call D7112_CLEAR()

            If IsdbNull(rs7112!K7112_UploadNo) = False Then D7112.UploadNo = Trim$(rs7112!K7112_UploadNo)
            If IsdbNull(rs7112!K7112_UploadSeq) = False Then D7112.UploadSeq = Trim$(rs7112!K7112_UploadSeq)
            If IsdbNull(rs7112!K7112_NameUpload) = False Then D7112.NameUpload = Trim$(rs7112!K7112_NameUpload)
            If IsdbNull(rs7112!K7112_CheckType) = False Then D7112.CheckType = Trim$(rs7112!K7112_CheckType)
            If IsdbNull(rs7112!K7112_DateUpload) = False Then D7112.DateUpload = Trim$(rs7112!K7112_DateUpload)
            If IsdbNull(rs7112!K7112_InchargeUpload) = False Then D7112.InchargeUpload = Trim$(rs7112!K7112_InchargeUpload)
            If IsdbNull(rs7112!K7112_ComponentName) = False Then D7112.ComponentName = Trim$(rs7112!K7112_ComponentName)
            If IsdbNull(rs7112!K7112_cdTypeCode) = False Then D7112.cdTypeCode = Trim$(rs7112!K7112_cdTypeCode)
            If IsdbNull(rs7112!K7112_TypeCode) = False Then D7112.TypeCode = Trim$(rs7112!K7112_TypeCode)
            If IsdbNull(rs7112!K7112_TypeName) = False Then D7112.TypeName = Trim$(rs7112!K7112_TypeName)
            If IsdbNull(rs7112!K7112_Specification) = False Then D7112.Specification = Trim$(rs7112!K7112_Specification)
            If IsdbNull(rs7112!K7112_Spec1) = False Then D7112.Spec1 = Trim$(rs7112!K7112_Spec1)
            If IsdbNull(rs7112!K7112_Spec2) = False Then D7112.Spec2 = Trim$(rs7112!K7112_Spec2)
            If IsdbNull(rs7112!K7112_Spec3) = False Then D7112.Spec3 = Trim$(rs7112!K7112_Spec3)
            If IsdbNull(rs7112!K7112_Spec4) = False Then D7112.Spec4 = Trim$(rs7112!K7112_Spec4)
            If IsdbNull(rs7112!K7112_Width) = False Then D7112.Width = Trim$(rs7112!K7112_Width)
            If IsdbNull(rs7112!K7112_Height) = False Then D7112.Height = Trim$(rs7112!K7112_Height)
            If IsdbNull(rs7112!K7112_seMainProcess) = False Then D7112.seMainProcess = Trim$(rs7112!K7112_seMainProcess)
            If IsdbNull(rs7112!K7112_cdMainProcess) = False Then D7112.cdMainProcess = Trim$(rs7112!K7112_cdMainProcess)
            If IsdbNull(rs7112!K7112_seSubProcess) = False Then D7112.seSubProcess = Trim$(rs7112!K7112_seSubProcess)
            If IsdbNull(rs7112!K7112_cdSubProcess) = False Then D7112.cdSubProcess = Trim$(rs7112!K7112_cdSubProcess)
            If IsdbNull(rs7112!K7112_seSpecialProcess) = False Then D7112.seSpecialProcess = Trim$(rs7112!K7112_seSpecialProcess)
            If IsdbNull(rs7112!K7112_cdSpecialProcess) = False Then D7112.cdSpecialProcess = Trim$(rs7112!K7112_cdSpecialProcess)
            If IsdbNull(rs7112!K7112_seUnitMaterial) = False Then D7112.seUnitMaterial = Trim$(rs7112!K7112_seUnitMaterial)
            If IsdbNull(rs7112!K7112_cdUnitMaterial) = False Then D7112.cdUnitMaterial = Trim$(rs7112!K7112_cdUnitMaterial)
            If IsdbNull(rs7112!K7112_BaseComponentBOM) = False Then D7112.BaseComponentBOM = Trim$(rs7112!K7112_BaseComponentBOM)
            If IsdbNull(rs7112!K7112_ShoesCode) = False Then D7112.ShoesCode = Trim$(rs7112!K7112_ShoesCode)
            If IsdbNull(rs7112!K7112_Dseq) = False Then D7112.Dseq = Trim$(rs7112!K7112_Dseq)
            If IsdbNull(rs7112!K7112_Loss) = False Then D7112.Loss = Trim$(rs7112!K7112_Loss)
            If IsdbNull(rs7112!K7112_QtyComponent) = False Then D7112.QtyComponent = Trim$(rs7112!K7112_QtyComponent)
            If IsdbNull(rs7112!K7112_CSizeQty01) = False Then D7112.CSizeQty01 = Trim$(rs7112!K7112_CSizeQty01)
            If IsdbNull(rs7112!K7112_CSizeQty02) = False Then D7112.CSizeQty02 = Trim$(rs7112!K7112_CSizeQty02)
            If IsdbNull(rs7112!K7112_CSizeQty03) = False Then D7112.CSizeQty03 = Trim$(rs7112!K7112_CSizeQty03)
            If IsdbNull(rs7112!K7112_CSizeQty04) = False Then D7112.CSizeQty04 = Trim$(rs7112!K7112_CSizeQty04)
            If IsdbNull(rs7112!K7112_CSizeQty05) = False Then D7112.CSizeQty05 = Trim$(rs7112!K7112_CSizeQty05)
            If IsdbNull(rs7112!K7112_CSizeQty06) = False Then D7112.CSizeQty06 = Trim$(rs7112!K7112_CSizeQty06)
            If IsdbNull(rs7112!K7112_CSizeQty07) = False Then D7112.CSizeQty07 = Trim$(rs7112!K7112_CSizeQty07)
            If IsdbNull(rs7112!K7112_CSizeQty08) = False Then D7112.CSizeQty08 = Trim$(rs7112!K7112_CSizeQty08)
            If IsdbNull(rs7112!K7112_CSizeQty09) = False Then D7112.CSizeQty09 = Trim$(rs7112!K7112_CSizeQty09)
            If IsdbNull(rs7112!K7112_CSizeQty10) = False Then D7112.CSizeQty10 = Trim$(rs7112!K7112_CSizeQty10)
            If IsdbNull(rs7112!K7112_CSizeQty11) = False Then D7112.CSizeQty11 = Trim$(rs7112!K7112_CSizeQty11)
            If IsdbNull(rs7112!K7112_CSizeQty12) = False Then D7112.CSizeQty12 = Trim$(rs7112!K7112_CSizeQty12)
            If IsdbNull(rs7112!K7112_CSizeQty13) = False Then D7112.CSizeQty13 = Trim$(rs7112!K7112_CSizeQty13)
            If IsdbNull(rs7112!K7112_CSizeQty14) = False Then D7112.CSizeQty14 = Trim$(rs7112!K7112_CSizeQty14)
            If IsdbNull(rs7112!K7112_CSizeQty15) = False Then D7112.CSizeQty15 = Trim$(rs7112!K7112_CSizeQty15)
            If IsdbNull(rs7112!K7112_CSizeQty16) = False Then D7112.CSizeQty16 = Trim$(rs7112!K7112_CSizeQty16)
            If IsdbNull(rs7112!K7112_CSizeQty17) = False Then D7112.CSizeQty17 = Trim$(rs7112!K7112_CSizeQty17)
            If IsdbNull(rs7112!K7112_CSizeQty18) = False Then D7112.CSizeQty18 = Trim$(rs7112!K7112_CSizeQty18)
            If IsdbNull(rs7112!K7112_CSizeQty19) = False Then D7112.CSizeQty19 = Trim$(rs7112!K7112_CSizeQty19)
            If IsdbNull(rs7112!K7112_CSizeQty20) = False Then D7112.CSizeQty20 = Trim$(rs7112!K7112_CSizeQty20)
            If IsdbNull(rs7112!K7112_CSizeQty21) = False Then D7112.CSizeQty21 = Trim$(rs7112!K7112_CSizeQty21)
            If IsdbNull(rs7112!K7112_CSizeQty22) = False Then D7112.CSizeQty22 = Trim$(rs7112!K7112_CSizeQty22)
            If IsdbNull(rs7112!K7112_CSizeQty23) = False Then D7112.CSizeQty23 = Trim$(rs7112!K7112_CSizeQty23)
            If IsdbNull(rs7112!K7112_CSizeQty24) = False Then D7112.CSizeQty24 = Trim$(rs7112!K7112_CSizeQty24)
            If IsdbNull(rs7112!K7112_CSizeQty25) = False Then D7112.CSizeQty25 = Trim$(rs7112!K7112_CSizeQty25)
            If IsdbNull(rs7112!K7112_CSizeQty26) = False Then D7112.CSizeQty26 = Trim$(rs7112!K7112_CSizeQty26)
            If IsdbNull(rs7112!K7112_CSizeQty27) = False Then D7112.CSizeQty27 = Trim$(rs7112!K7112_CSizeQty27)
            If IsdbNull(rs7112!K7112_CSizeQty28) = False Then D7112.CSizeQty28 = Trim$(rs7112!K7112_CSizeQty28)
            If IsdbNull(rs7112!K7112_CSizeQty29) = False Then D7112.CSizeQty29 = Trim$(rs7112!K7112_CSizeQty29)
            If IsdbNull(rs7112!K7112_CSizeQty30) = False Then D7112.CSizeQty30 = Trim$(rs7112!K7112_CSizeQty30)
            If IsdbNull(rs7112!K7112_Remark) = False Then D7112.Remark = Trim$(rs7112!K7112_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7112_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K7112_MOVE(rs7112 As DataRow)
        Try

            Call D7112_CLEAR()

            If IsdbNull(rs7112!K7112_UploadNo) = False Then D7112.UploadNo = Trim$(rs7112!K7112_UploadNo)
            If IsdbNull(rs7112!K7112_UploadSeq) = False Then D7112.UploadSeq = Trim$(rs7112!K7112_UploadSeq)
            If IsdbNull(rs7112!K7112_NameUpload) = False Then D7112.NameUpload = Trim$(rs7112!K7112_NameUpload)
            If IsdbNull(rs7112!K7112_CheckType) = False Then D7112.CheckType = Trim$(rs7112!K7112_CheckType)
            If IsdbNull(rs7112!K7112_DateUpload) = False Then D7112.DateUpload = Trim$(rs7112!K7112_DateUpload)
            If IsdbNull(rs7112!K7112_InchargeUpload) = False Then D7112.InchargeUpload = Trim$(rs7112!K7112_InchargeUpload)
            If IsdbNull(rs7112!K7112_ComponentName) = False Then D7112.ComponentName = Trim$(rs7112!K7112_ComponentName)
            If IsdbNull(rs7112!K7112_cdTypeCode) = False Then D7112.cdTypeCode = Trim$(rs7112!K7112_cdTypeCode)
            If IsdbNull(rs7112!K7112_TypeCode) = False Then D7112.TypeCode = Trim$(rs7112!K7112_TypeCode)
            If IsdbNull(rs7112!K7112_TypeName) = False Then D7112.TypeName = Trim$(rs7112!K7112_TypeName)
            If IsdbNull(rs7112!K7112_Specification) = False Then D7112.Specification = Trim$(rs7112!K7112_Specification)
            If IsdbNull(rs7112!K7112_Spec1) = False Then D7112.Spec1 = Trim$(rs7112!K7112_Spec1)
            If IsdbNull(rs7112!K7112_Spec2) = False Then D7112.Spec2 = Trim$(rs7112!K7112_Spec2)
            If IsdbNull(rs7112!K7112_Spec3) = False Then D7112.Spec3 = Trim$(rs7112!K7112_Spec3)
            If IsdbNull(rs7112!K7112_Spec4) = False Then D7112.Spec4 = Trim$(rs7112!K7112_Spec4)
            If IsdbNull(rs7112!K7112_Width) = False Then D7112.Width = Trim$(rs7112!K7112_Width)
            If IsdbNull(rs7112!K7112_Height) = False Then D7112.Height = Trim$(rs7112!K7112_Height)
            If IsdbNull(rs7112!K7112_seMainProcess) = False Then D7112.seMainProcess = Trim$(rs7112!K7112_seMainProcess)
            If IsdbNull(rs7112!K7112_cdMainProcess) = False Then D7112.cdMainProcess = Trim$(rs7112!K7112_cdMainProcess)
            If IsdbNull(rs7112!K7112_seSubProcess) = False Then D7112.seSubProcess = Trim$(rs7112!K7112_seSubProcess)
            If IsdbNull(rs7112!K7112_cdSubProcess) = False Then D7112.cdSubProcess = Trim$(rs7112!K7112_cdSubProcess)
            If IsdbNull(rs7112!K7112_seSpecialProcess) = False Then D7112.seSpecialProcess = Trim$(rs7112!K7112_seSpecialProcess)
            If IsdbNull(rs7112!K7112_cdSpecialProcess) = False Then D7112.cdSpecialProcess = Trim$(rs7112!K7112_cdSpecialProcess)
            If IsdbNull(rs7112!K7112_seUnitMaterial) = False Then D7112.seUnitMaterial = Trim$(rs7112!K7112_seUnitMaterial)
            If IsdbNull(rs7112!K7112_cdUnitMaterial) = False Then D7112.cdUnitMaterial = Trim$(rs7112!K7112_cdUnitMaterial)
            If IsdbNull(rs7112!K7112_BaseComponentBOM) = False Then D7112.BaseComponentBOM = Trim$(rs7112!K7112_BaseComponentBOM)
            If IsdbNull(rs7112!K7112_ShoesCode) = False Then D7112.ShoesCode = Trim$(rs7112!K7112_ShoesCode)
            If IsdbNull(rs7112!K7112_Dseq) = False Then D7112.Dseq = Trim$(rs7112!K7112_Dseq)
            If IsdbNull(rs7112!K7112_Loss) = False Then D7112.Loss = Trim$(rs7112!K7112_Loss)
            If IsdbNull(rs7112!K7112_QtyComponent) = False Then D7112.QtyComponent = Trim$(rs7112!K7112_QtyComponent)
            If IsdbNull(rs7112!K7112_CSizeQty01) = False Then D7112.CSizeQty01 = Trim$(rs7112!K7112_CSizeQty01)
            If IsdbNull(rs7112!K7112_CSizeQty02) = False Then D7112.CSizeQty02 = Trim$(rs7112!K7112_CSizeQty02)
            If IsdbNull(rs7112!K7112_CSizeQty03) = False Then D7112.CSizeQty03 = Trim$(rs7112!K7112_CSizeQty03)
            If IsdbNull(rs7112!K7112_CSizeQty04) = False Then D7112.CSizeQty04 = Trim$(rs7112!K7112_CSizeQty04)
            If IsdbNull(rs7112!K7112_CSizeQty05) = False Then D7112.CSizeQty05 = Trim$(rs7112!K7112_CSizeQty05)
            If IsdbNull(rs7112!K7112_CSizeQty06) = False Then D7112.CSizeQty06 = Trim$(rs7112!K7112_CSizeQty06)
            If IsdbNull(rs7112!K7112_CSizeQty07) = False Then D7112.CSizeQty07 = Trim$(rs7112!K7112_CSizeQty07)
            If IsdbNull(rs7112!K7112_CSizeQty08) = False Then D7112.CSizeQty08 = Trim$(rs7112!K7112_CSizeQty08)
            If IsdbNull(rs7112!K7112_CSizeQty09) = False Then D7112.CSizeQty09 = Trim$(rs7112!K7112_CSizeQty09)
            If IsdbNull(rs7112!K7112_CSizeQty10) = False Then D7112.CSizeQty10 = Trim$(rs7112!K7112_CSizeQty10)
            If IsdbNull(rs7112!K7112_CSizeQty11) = False Then D7112.CSizeQty11 = Trim$(rs7112!K7112_CSizeQty11)
            If IsdbNull(rs7112!K7112_CSizeQty12) = False Then D7112.CSizeQty12 = Trim$(rs7112!K7112_CSizeQty12)
            If IsdbNull(rs7112!K7112_CSizeQty13) = False Then D7112.CSizeQty13 = Trim$(rs7112!K7112_CSizeQty13)
            If IsdbNull(rs7112!K7112_CSizeQty14) = False Then D7112.CSizeQty14 = Trim$(rs7112!K7112_CSizeQty14)
            If IsdbNull(rs7112!K7112_CSizeQty15) = False Then D7112.CSizeQty15 = Trim$(rs7112!K7112_CSizeQty15)
            If IsdbNull(rs7112!K7112_CSizeQty16) = False Then D7112.CSizeQty16 = Trim$(rs7112!K7112_CSizeQty16)
            If IsdbNull(rs7112!K7112_CSizeQty17) = False Then D7112.CSizeQty17 = Trim$(rs7112!K7112_CSizeQty17)
            If IsdbNull(rs7112!K7112_CSizeQty18) = False Then D7112.CSizeQty18 = Trim$(rs7112!K7112_CSizeQty18)
            If IsdbNull(rs7112!K7112_CSizeQty19) = False Then D7112.CSizeQty19 = Trim$(rs7112!K7112_CSizeQty19)
            If IsdbNull(rs7112!K7112_CSizeQty20) = False Then D7112.CSizeQty20 = Trim$(rs7112!K7112_CSizeQty20)
            If IsdbNull(rs7112!K7112_CSizeQty21) = False Then D7112.CSizeQty21 = Trim$(rs7112!K7112_CSizeQty21)
            If IsdbNull(rs7112!K7112_CSizeQty22) = False Then D7112.CSizeQty22 = Trim$(rs7112!K7112_CSizeQty22)
            If IsdbNull(rs7112!K7112_CSizeQty23) = False Then D7112.CSizeQty23 = Trim$(rs7112!K7112_CSizeQty23)
            If IsdbNull(rs7112!K7112_CSizeQty24) = False Then D7112.CSizeQty24 = Trim$(rs7112!K7112_CSizeQty24)
            If IsdbNull(rs7112!K7112_CSizeQty25) = False Then D7112.CSizeQty25 = Trim$(rs7112!K7112_CSizeQty25)
            If IsdbNull(rs7112!K7112_CSizeQty26) = False Then D7112.CSizeQty26 = Trim$(rs7112!K7112_CSizeQty26)
            If IsdbNull(rs7112!K7112_CSizeQty27) = False Then D7112.CSizeQty27 = Trim$(rs7112!K7112_CSizeQty27)
            If IsdbNull(rs7112!K7112_CSizeQty28) = False Then D7112.CSizeQty28 = Trim$(rs7112!K7112_CSizeQty28)
            If IsdbNull(rs7112!K7112_CSizeQty29) = False Then D7112.CSizeQty29 = Trim$(rs7112!K7112_CSizeQty29)
            If IsdbNull(rs7112!K7112_CSizeQty30) = False Then D7112.CSizeQty30 = Trim$(rs7112!K7112_CSizeQty30)
            If IsdbNull(rs7112!K7112_Remark) = False Then D7112.Remark = Trim$(rs7112!K7112_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7112_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K7112_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7112 As T7112_AREA, UPLOADNO As String, UPLOADSEQ As Double) As Boolean

        K7112_MOVE = False

        Try
            If READ_PFK7112(UPLOADNO, UPLOADSEQ) = True Then
                z7112 = D7112
                K7112_MOVE = True
            Else
                z7112 = Nothing
            End If

            If getColumIndex(spr, "UploadNo") > -1 Then z7112.UploadNo = getDataM(spr, getColumIndex(spr, "UploadNo"), xRow)
            If getColumIndex(spr, "UploadSeq") > -1 Then z7112.UploadSeq = getDataM(spr, getColumIndex(spr, "UploadSeq"), xRow)
            If getColumIndex(spr, "NameUpload") > -1 Then z7112.NameUpload = getDataM(spr, getColumIndex(spr, "NameUpload"), xRow)
            If getColumIndex(spr, "CheckType") > -1 Then z7112.CheckType = getDataM(spr, getColumIndex(spr, "CheckType"), xRow)
            If getColumIndex(spr, "DateUpload") > -1 Then z7112.DateUpload = getDataM(spr, getColumIndex(spr, "DateUpload"), xRow)
            If getColumIndex(spr, "InchargeUpload") > -1 Then z7112.InchargeUpload = getDataM(spr, getColumIndex(spr, "InchargeUpload"), xRow)
            If getColumIndex(spr, "ComponentName") > -1 Then z7112.ComponentName = getDataM(spr, getColumIndex(spr, "ComponentName"), xRow)
            If getColumIndex(spr, "cdTypeCode") > -1 Then z7112.cdTypeCode = getDataM(spr, getColumIndex(spr, "cdTypeCode"), xRow)
            If getColumIndex(spr, "TypeCode") > -1 Then z7112.TypeCode = getDataM(spr, getColumIndex(spr, "TypeCode"), xRow)
            If getColumIndex(spr, "TypeName") > -1 Then z7112.TypeName = getDataM(spr, getColumIndex(spr, "TypeName"), xRow)
            If getColumIndex(spr, "Specification") > -1 Then z7112.Specification = getDataM(spr, getColumIndex(spr, "Specification"), xRow)
            If getColumIndex(spr, "Spec1") > -1 Then z7112.Spec1 = getDataM(spr, getColumIndex(spr, "Spec1"), xRow)
            If getColumIndex(spr, "Spec2") > -1 Then z7112.Spec2 = getDataM(spr, getColumIndex(spr, "Spec2"), xRow)
            If getColumIndex(spr, "Spec3") > -1 Then z7112.Spec3 = getDataM(spr, getColumIndex(spr, "Spec3"), xRow)
            If getColumIndex(spr, "Spec4") > -1 Then z7112.Spec4 = getDataM(spr, getColumIndex(spr, "Spec4"), xRow)
            If getColumIndex(spr, "Width") > -1 Then z7112.Width = getDataM(spr, getColumIndex(spr, "Width"), xRow)
            If getColumIndex(spr, "Height") > -1 Then z7112.Height = getDataM(spr, getColumIndex(spr, "Height"), xRow)
            If getColumIndex(spr, "seMainProcess") > -1 Then z7112.seMainProcess = getDataM(spr, getColumIndex(spr, "seMainProcess"), xRow)
            If getColumIndex(spr, "cdMainProcess") > -1 Then z7112.cdMainProcess = getDataM(spr, getColumIndex(spr, "cdMainProcess"), xRow)
            If getColumIndex(spr, "seSubProcess") > -1 Then z7112.seSubProcess = getDataM(spr, getColumIndex(spr, "seSubProcess"), xRow)
            If getColumIndex(spr, "cdSubProcess") > -1 Then z7112.cdSubProcess = getDataM(spr, getColumIndex(spr, "cdSubProcess"), xRow)
            If getColumIndex(spr, "seSpecialProcess") > -1 Then z7112.seSpecialProcess = getDataM(spr, getColumIndex(spr, "seSpecialProcess"), xRow)
            If getColumIndex(spr, "cdSpecialProcess") > -1 Then z7112.cdSpecialProcess = getDataM(spr, getColumIndex(spr, "cdSpecialProcess"), xRow)
            If getColumIndex(spr, "seUnitMaterial") > -1 Then z7112.seUnitMaterial = getDataM(spr, getColumIndex(spr, "seUnitMaterial"), xRow)
            If getColumIndex(spr, "cdUnitMaterial") > -1 Then z7112.cdUnitMaterial = getDataM(spr, getColumIndex(spr, "cdUnitMaterial"), xRow)
            If getColumIndex(spr, "BaseComponentBOM") > -1 Then z7112.BaseComponentBOM = getDataM(spr, getColumIndex(spr, "BaseComponentBOM"), xRow)
            If getColumIndex(spr, "ShoesCode") > -1 Then z7112.ShoesCode = getDataM(spr, getColumIndex(spr, "ShoesCode"), xRow)
            If getColumIndex(spr, "Dseq") > -1 Then z7112.Dseq = getDataM(spr, getColumIndex(spr, "Dseq"), xRow)
            If getColumIndex(spr, "Loss") > -1 Then z7112.Loss = getDataM(spr, getColumIndex(spr, "Loss"), xRow)
            If getColumIndex(spr, "QtyComponent") > -1 Then z7112.QtyComponent = getDataM(spr, getColumIndex(spr, "QtyComponent"), xRow)
            If getColumIndex(spr, "CSizeQty01") > -1 Then z7112.CSizeQty01 = getDataM(spr, getColumIndex(spr, "CSizeQty01"), xRow)
            If getColumIndex(spr, "CSizeQty02") > -1 Then z7112.CSizeQty02 = getDataM(spr, getColumIndex(spr, "CSizeQty02"), xRow)
            If getColumIndex(spr, "CSizeQty03") > -1 Then z7112.CSizeQty03 = getDataM(spr, getColumIndex(spr, "CSizeQty03"), xRow)
            If getColumIndex(spr, "CSizeQty04") > -1 Then z7112.CSizeQty04 = getDataM(spr, getColumIndex(spr, "CSizeQty04"), xRow)
            If getColumIndex(spr, "CSizeQty05") > -1 Then z7112.CSizeQty05 = getDataM(spr, getColumIndex(spr, "CSizeQty05"), xRow)
            If getColumIndex(spr, "CSizeQty06") > -1 Then z7112.CSizeQty06 = getDataM(spr, getColumIndex(spr, "CSizeQty06"), xRow)
            If getColumIndex(spr, "CSizeQty07") > -1 Then z7112.CSizeQty07 = getDataM(spr, getColumIndex(spr, "CSizeQty07"), xRow)
            If getColumIndex(spr, "CSizeQty08") > -1 Then z7112.CSizeQty08 = getDataM(spr, getColumIndex(spr, "CSizeQty08"), xRow)
            If getColumIndex(spr, "CSizeQty09") > -1 Then z7112.CSizeQty09 = getDataM(spr, getColumIndex(spr, "CSizeQty09"), xRow)
            If getColumIndex(spr, "CSizeQty10") > -1 Then z7112.CSizeQty10 = getDataM(spr, getColumIndex(spr, "CSizeQty10"), xRow)
            If getColumIndex(spr, "CSizeQty11") > -1 Then z7112.CSizeQty11 = getDataM(spr, getColumIndex(spr, "CSizeQty11"), xRow)
            If getColumIndex(spr, "CSizeQty12") > -1 Then z7112.CSizeQty12 = getDataM(spr, getColumIndex(spr, "CSizeQty12"), xRow)
            If getColumIndex(spr, "CSizeQty13") > -1 Then z7112.CSizeQty13 = getDataM(spr, getColumIndex(spr, "CSizeQty13"), xRow)
            If getColumIndex(spr, "CSizeQty14") > -1 Then z7112.CSizeQty14 = getDataM(spr, getColumIndex(spr, "CSizeQty14"), xRow)
            If getColumIndex(spr, "CSizeQty15") > -1 Then z7112.CSizeQty15 = getDataM(spr, getColumIndex(spr, "CSizeQty15"), xRow)
            If getColumIndex(spr, "CSizeQty16") > -1 Then z7112.CSizeQty16 = getDataM(spr, getColumIndex(spr, "CSizeQty16"), xRow)
            If getColumIndex(spr, "CSizeQty17") > -1 Then z7112.CSizeQty17 = getDataM(spr, getColumIndex(spr, "CSizeQty17"), xRow)
            If getColumIndex(spr, "CSizeQty18") > -1 Then z7112.CSizeQty18 = getDataM(spr, getColumIndex(spr, "CSizeQty18"), xRow)
            If getColumIndex(spr, "CSizeQty19") > -1 Then z7112.CSizeQty19 = getDataM(spr, getColumIndex(spr, "CSizeQty19"), xRow)
            If getColumIndex(spr, "CSizeQty20") > -1 Then z7112.CSizeQty20 = getDataM(spr, getColumIndex(spr, "CSizeQty20"), xRow)
            If getColumIndex(spr, "CSizeQty21") > -1 Then z7112.CSizeQty21 = getDataM(spr, getColumIndex(spr, "CSizeQty21"), xRow)
            If getColumIndex(spr, "CSizeQty22") > -1 Then z7112.CSizeQty22 = getDataM(spr, getColumIndex(spr, "CSizeQty22"), xRow)
            If getColumIndex(spr, "CSizeQty23") > -1 Then z7112.CSizeQty23 = getDataM(spr, getColumIndex(spr, "CSizeQty23"), xRow)
            If getColumIndex(spr, "CSizeQty24") > -1 Then z7112.CSizeQty24 = getDataM(spr, getColumIndex(spr, "CSizeQty24"), xRow)
            If getColumIndex(spr, "CSizeQty25") > -1 Then z7112.CSizeQty25 = getDataM(spr, getColumIndex(spr, "CSizeQty25"), xRow)
            If getColumIndex(spr, "CSizeQty26") > -1 Then z7112.CSizeQty26 = getDataM(spr, getColumIndex(spr, "CSizeQty26"), xRow)
            If getColumIndex(spr, "CSizeQty27") > -1 Then z7112.CSizeQty27 = getDataM(spr, getColumIndex(spr, "CSizeQty27"), xRow)
            If getColumIndex(spr, "CSizeQty28") > -1 Then z7112.CSizeQty28 = getDataM(spr, getColumIndex(spr, "CSizeQty28"), xRow)
            If getColumIndex(spr, "CSizeQty29") > -1 Then z7112.CSizeQty29 = getDataM(spr, getColumIndex(spr, "CSizeQty29"), xRow)
            If getColumIndex(spr, "CSizeQty30") > -1 Then z7112.CSizeQty30 = getDataM(spr, getColumIndex(spr, "CSizeQty30"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z7112.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7112_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K7112_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7112 As T7112_AREA, CheckClear As Boolean, UPLOADNO As String, UPLOADSEQ As Double) As Boolean

        K7112_MOVE = False

        Try
            If READ_PFK7112(UPLOADNO, UPLOADSEQ) = True Then
                z7112 = D7112
                K7112_MOVE = True
            Else
                If CheckClear = True Then z7112 = Nothing
            End If

            If getColumIndex(spr, "UploadNo") > -1 Then z7112.UploadNo = getDataM(spr, getColumIndex(spr, "UploadNo"), xRow)
            If getColumIndex(spr, "UploadSeq") > -1 Then z7112.UploadSeq = getDataM(spr, getColumIndex(spr, "UploadSeq"), xRow)
            If getColumIndex(spr, "NameUpload") > -1 Then z7112.NameUpload = getDataM(spr, getColumIndex(spr, "NameUpload"), xRow)
            If getColumIndex(spr, "CheckType") > -1 Then z7112.CheckType = getDataM(spr, getColumIndex(spr, "CheckType"), xRow)
            If getColumIndex(spr, "DateUpload") > -1 Then z7112.DateUpload = getDataM(spr, getColumIndex(spr, "DateUpload"), xRow)
            If getColumIndex(spr, "InchargeUpload") > -1 Then z7112.InchargeUpload = getDataM(spr, getColumIndex(spr, "InchargeUpload"), xRow)
            If getColumIndex(spr, "ComponentName") > -1 Then z7112.ComponentName = getDataM(spr, getColumIndex(spr, "ComponentName"), xRow)
            If getColumIndex(spr, "cdTypeCode") > -1 Then z7112.cdTypeCode = getDataM(spr, getColumIndex(spr, "cdTypeCode"), xRow)
            If getColumIndex(spr, "TypeCode") > -1 Then z7112.TypeCode = getDataM(spr, getColumIndex(spr, "TypeCode"), xRow)
            If getColumIndex(spr, "TypeName") > -1 Then z7112.TypeName = getDataM(spr, getColumIndex(spr, "TypeName"), xRow)
            If getColumIndex(spr, "Specification") > -1 Then z7112.Specification = getDataM(spr, getColumIndex(spr, "Specification"), xRow)
            If getColumIndex(spr, "Spec1") > -1 Then z7112.Spec1 = getDataM(spr, getColumIndex(spr, "Spec1"), xRow)
            If getColumIndex(spr, "Spec2") > -1 Then z7112.Spec2 = getDataM(spr, getColumIndex(spr, "Spec2"), xRow)
            If getColumIndex(spr, "Spec3") > -1 Then z7112.Spec3 = getDataM(spr, getColumIndex(spr, "Spec3"), xRow)
            If getColumIndex(spr, "Spec4") > -1 Then z7112.Spec4 = getDataM(spr, getColumIndex(spr, "Spec4"), xRow)
            If getColumIndex(spr, "Width") > -1 Then z7112.Width = getDataM(spr, getColumIndex(spr, "Width"), xRow)
            If getColumIndex(spr, "Height") > -1 Then z7112.Height = getDataM(spr, getColumIndex(spr, "Height"), xRow)
            If getColumIndex(spr, "seMainProcess") > -1 Then z7112.seMainProcess = getDataM(spr, getColumIndex(spr, "seMainProcess"), xRow)
            If getColumIndex(spr, "cdMainProcess") > -1 Then z7112.cdMainProcess = getDataM(spr, getColumIndex(spr, "cdMainProcess"), xRow)
            If getColumIndex(spr, "seSubProcess") > -1 Then z7112.seSubProcess = getDataM(spr, getColumIndex(spr, "seSubProcess"), xRow)
            If getColumIndex(spr, "cdSubProcess") > -1 Then z7112.cdSubProcess = getDataM(spr, getColumIndex(spr, "cdSubProcess"), xRow)
            If getColumIndex(spr, "seSpecialProcess") > -1 Then z7112.seSpecialProcess = getDataM(spr, getColumIndex(spr, "seSpecialProcess"), xRow)
            If getColumIndex(spr, "cdSpecialProcess") > -1 Then z7112.cdSpecialProcess = getDataM(spr, getColumIndex(spr, "cdSpecialProcess"), xRow)
            If getColumIndex(spr, "seUnitMaterial") > -1 Then z7112.seUnitMaterial = getDataM(spr, getColumIndex(spr, "seUnitMaterial"), xRow)
            If getColumIndex(spr, "cdUnitMaterial") > -1 Then z7112.cdUnitMaterial = getDataM(spr, getColumIndex(spr, "cdUnitMaterial"), xRow)
            If getColumIndex(spr, "BaseComponentBOM") > -1 Then z7112.BaseComponentBOM = getDataM(spr, getColumIndex(spr, "BaseComponentBOM"), xRow)
            If getColumIndex(spr, "ShoesCode") > -1 Then z7112.ShoesCode = getDataM(spr, getColumIndex(spr, "ShoesCode"), xRow)
            If getColumIndex(spr, "Dseq") > -1 Then z7112.Dseq = getDataM(spr, getColumIndex(spr, "Dseq"), xRow)
            If getColumIndex(spr, "Loss") > -1 Then z7112.Loss = getDataM(spr, getColumIndex(spr, "Loss"), xRow)
            If getColumIndex(spr, "QtyComponent") > -1 Then z7112.QtyComponent = getDataM(spr, getColumIndex(spr, "QtyComponent"), xRow)
            If getColumIndex(spr, "CSizeQty01") > -1 Then z7112.CSizeQty01 = getDataM(spr, getColumIndex(spr, "CSizeQty01"), xRow)
            If getColumIndex(spr, "CSizeQty02") > -1 Then z7112.CSizeQty02 = getDataM(spr, getColumIndex(spr, "CSizeQty02"), xRow)
            If getColumIndex(spr, "CSizeQty03") > -1 Then z7112.CSizeQty03 = getDataM(spr, getColumIndex(spr, "CSizeQty03"), xRow)
            If getColumIndex(spr, "CSizeQty04") > -1 Then z7112.CSizeQty04 = getDataM(spr, getColumIndex(spr, "CSizeQty04"), xRow)
            If getColumIndex(spr, "CSizeQty05") > -1 Then z7112.CSizeQty05 = getDataM(spr, getColumIndex(spr, "CSizeQty05"), xRow)
            If getColumIndex(spr, "CSizeQty06") > -1 Then z7112.CSizeQty06 = getDataM(spr, getColumIndex(spr, "CSizeQty06"), xRow)
            If getColumIndex(spr, "CSizeQty07") > -1 Then z7112.CSizeQty07 = getDataM(spr, getColumIndex(spr, "CSizeQty07"), xRow)
            If getColumIndex(spr, "CSizeQty08") > -1 Then z7112.CSizeQty08 = getDataM(spr, getColumIndex(spr, "CSizeQty08"), xRow)
            If getColumIndex(spr, "CSizeQty09") > -1 Then z7112.CSizeQty09 = getDataM(spr, getColumIndex(spr, "CSizeQty09"), xRow)
            If getColumIndex(spr, "CSizeQty10") > -1 Then z7112.CSizeQty10 = getDataM(spr, getColumIndex(spr, "CSizeQty10"), xRow)
            If getColumIndex(spr, "CSizeQty11") > -1 Then z7112.CSizeQty11 = getDataM(spr, getColumIndex(spr, "CSizeQty11"), xRow)
            If getColumIndex(spr, "CSizeQty12") > -1 Then z7112.CSizeQty12 = getDataM(spr, getColumIndex(spr, "CSizeQty12"), xRow)
            If getColumIndex(spr, "CSizeQty13") > -1 Then z7112.CSizeQty13 = getDataM(spr, getColumIndex(spr, "CSizeQty13"), xRow)
            If getColumIndex(spr, "CSizeQty14") > -1 Then z7112.CSizeQty14 = getDataM(spr, getColumIndex(spr, "CSizeQty14"), xRow)
            If getColumIndex(spr, "CSizeQty15") > -1 Then z7112.CSizeQty15 = getDataM(spr, getColumIndex(spr, "CSizeQty15"), xRow)
            If getColumIndex(spr, "CSizeQty16") > -1 Then z7112.CSizeQty16 = getDataM(spr, getColumIndex(spr, "CSizeQty16"), xRow)
            If getColumIndex(spr, "CSizeQty17") > -1 Then z7112.CSizeQty17 = getDataM(spr, getColumIndex(spr, "CSizeQty17"), xRow)
            If getColumIndex(spr, "CSizeQty18") > -1 Then z7112.CSizeQty18 = getDataM(spr, getColumIndex(spr, "CSizeQty18"), xRow)
            If getColumIndex(spr, "CSizeQty19") > -1 Then z7112.CSizeQty19 = getDataM(spr, getColumIndex(spr, "CSizeQty19"), xRow)
            If getColumIndex(spr, "CSizeQty20") > -1 Then z7112.CSizeQty20 = getDataM(spr, getColumIndex(spr, "CSizeQty20"), xRow)
            If getColumIndex(spr, "CSizeQty21") > -1 Then z7112.CSizeQty21 = getDataM(spr, getColumIndex(spr, "CSizeQty21"), xRow)
            If getColumIndex(spr, "CSizeQty22") > -1 Then z7112.CSizeQty22 = getDataM(spr, getColumIndex(spr, "CSizeQty22"), xRow)
            If getColumIndex(spr, "CSizeQty23") > -1 Then z7112.CSizeQty23 = getDataM(spr, getColumIndex(spr, "CSizeQty23"), xRow)
            If getColumIndex(spr, "CSizeQty24") > -1 Then z7112.CSizeQty24 = getDataM(spr, getColumIndex(spr, "CSizeQty24"), xRow)
            If getColumIndex(spr, "CSizeQty25") > -1 Then z7112.CSizeQty25 = getDataM(spr, getColumIndex(spr, "CSizeQty25"), xRow)
            If getColumIndex(spr, "CSizeQty26") > -1 Then z7112.CSizeQty26 = getDataM(spr, getColumIndex(spr, "CSizeQty26"), xRow)
            If getColumIndex(spr, "CSizeQty27") > -1 Then z7112.CSizeQty27 = getDataM(spr, getColumIndex(spr, "CSizeQty27"), xRow)
            If getColumIndex(spr, "CSizeQty28") > -1 Then z7112.CSizeQty28 = getDataM(spr, getColumIndex(spr, "CSizeQty28"), xRow)
            If getColumIndex(spr, "CSizeQty29") > -1 Then z7112.CSizeQty29 = getDataM(spr, getColumIndex(spr, "CSizeQty29"), xRow)
            If getColumIndex(spr, "CSizeQty30") > -1 Then z7112.CSizeQty30 = getDataM(spr, getColumIndex(spr, "CSizeQty30"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z7112.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7112_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K7112_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7112 As T7112_AREA, Job As String, UPLOADNO As String, UPLOADSEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7112_MOVE = False

        Try
            If READ_PFK7112(UPLOADNO, UPLOADSEQ) = True Then
                z7112 = D7112
                K7112_MOVE = True
            Else
                z7112 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7112")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "UPLOADNO" : z7112.UploadNo = Children(i).Code
                                Case "UPLOADSEQ" : z7112.UploadSeq = Children(i).Code
                                Case "NAMEUPLOAD" : z7112.NameUpload = Children(i).Code
                                Case "CHECKTYPE" : z7112.CheckType = Children(i).Code
                                Case "DATEUPLOAD" : z7112.DateUpload = Children(i).Code
                                Case "INCHARGEUPLOAD" : z7112.InchargeUpload = Children(i).Code
                                Case "COMPONENTNAME" : z7112.ComponentName = Children(i).Code
                                Case "CDTYPECODE" : z7112.cdTypeCode = Children(i).Code
                                Case "TYPECODE" : z7112.TypeCode = Children(i).Code
                                Case "TYPENAME" : z7112.TypeName = Children(i).Code
                                Case "SPECIFICATION" : z7112.Specification = Children(i).Code
                                Case "SPEC1" : z7112.Spec1 = Children(i).Code
                                Case "SPEC2" : z7112.Spec2 = Children(i).Code
                                Case "SPEC3" : z7112.Spec3 = Children(i).Code
                                Case "SPEC4" : z7112.Spec4 = Children(i).Code
                                Case "WIDTH" : z7112.Width = Children(i).Code
                                Case "HEIGHT" : z7112.Height = Children(i).Code
                                Case "SEMAINPROCESS" : z7112.seMainProcess = Children(i).Code
                                Case "CDMAINPROCESS" : z7112.cdMainProcess = Children(i).Code
                                Case "SESUBPROCESS" : z7112.seSubProcess = Children(i).Code
                                Case "CDSUBPROCESS" : z7112.cdSubProcess = Children(i).Code
                                Case "SESPECIALPROCESS" : z7112.seSpecialProcess = Children(i).Code
                                Case "CDSPECIALPROCESS" : z7112.cdSpecialProcess = Children(i).Code
                                Case "SEUNITMATERIAL" : z7112.seUnitMaterial = Children(i).Code
                                Case "CDUNITMATERIAL" : z7112.cdUnitMaterial = Children(i).Code
                                Case "BASECOMPONENTBOM" : z7112.BaseComponentBOM = Children(i).Code
                                Case "SHOESCODE" : z7112.ShoesCode = Children(i).Code
                                Case "DSEQ" : z7112.Dseq = Children(i).Code
                                Case "LOSS" : z7112.Loss = Children(i).Code
                                Case "QTYCOMPONENT" : z7112.QtyComponent = Children(i).Code
                                Case "CSIZEQTY01" : z7112.CSizeQty01 = Children(i).Code
                                Case "CSIZEQTY02" : z7112.CSizeQty02 = Children(i).Code
                                Case "CSIZEQTY03" : z7112.CSizeQty03 = Children(i).Code
                                Case "CSIZEQTY04" : z7112.CSizeQty04 = Children(i).Code
                                Case "CSIZEQTY05" : z7112.CSizeQty05 = Children(i).Code
                                Case "CSIZEQTY06" : z7112.CSizeQty06 = Children(i).Code
                                Case "CSIZEQTY07" : z7112.CSizeQty07 = Children(i).Code
                                Case "CSIZEQTY08" : z7112.CSizeQty08 = Children(i).Code
                                Case "CSIZEQTY09" : z7112.CSizeQty09 = Children(i).Code
                                Case "CSIZEQTY10" : z7112.CSizeQty10 = Children(i).Code
                                Case "CSIZEQTY11" : z7112.CSizeQty11 = Children(i).Code
                                Case "CSIZEQTY12" : z7112.CSizeQty12 = Children(i).Code
                                Case "CSIZEQTY13" : z7112.CSizeQty13 = Children(i).Code
                                Case "CSIZEQTY14" : z7112.CSizeQty14 = Children(i).Code
                                Case "CSIZEQTY15" : z7112.CSizeQty15 = Children(i).Code
                                Case "CSIZEQTY16" : z7112.CSizeQty16 = Children(i).Code
                                Case "CSIZEQTY17" : z7112.CSizeQty17 = Children(i).Code
                                Case "CSIZEQTY18" : z7112.CSizeQty18 = Children(i).Code
                                Case "CSIZEQTY19" : z7112.CSizeQty19 = Children(i).Code
                                Case "CSIZEQTY20" : z7112.CSizeQty20 = Children(i).Code
                                Case "CSIZEQTY21" : z7112.CSizeQty21 = Children(i).Code
                                Case "CSIZEQTY22" : z7112.CSizeQty22 = Children(i).Code
                                Case "CSIZEQTY23" : z7112.CSizeQty23 = Children(i).Code
                                Case "CSIZEQTY24" : z7112.CSizeQty24 = Children(i).Code
                                Case "CSIZEQTY25" : z7112.CSizeQty25 = Children(i).Code
                                Case "CSIZEQTY26" : z7112.CSizeQty26 = Children(i).Code
                                Case "CSIZEQTY27" : z7112.CSizeQty27 = Children(i).Code
                                Case "CSIZEQTY28" : z7112.CSizeQty28 = Children(i).Code
                                Case "CSIZEQTY29" : z7112.CSizeQty29 = Children(i).Code
                                Case "CSIZEQTY30" : z7112.CSizeQty30 = Children(i).Code
                                Case "REMARK" : z7112.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "UPLOADNO" : z7112.UploadNo = Children(i).Data
                                Case "UPLOADSEQ" : z7112.UploadSeq = Children(i).Data
                                Case "NAMEUPLOAD" : z7112.NameUpload = Children(i).Data
                                Case "CHECKTYPE" : z7112.CheckType = Children(i).Data
                                Case "DATEUPLOAD" : z7112.DateUpload = Children(i).Data
                                Case "INCHARGEUPLOAD" : z7112.InchargeUpload = Children(i).Data
                                Case "COMPONENTNAME" : z7112.ComponentName = Children(i).Data
                                Case "CDTYPECODE" : z7112.cdTypeCode = Children(i).Data
                                Case "TYPECODE" : z7112.TypeCode = Children(i).Data
                                Case "TYPENAME" : z7112.TypeName = Children(i).Data
                                Case "SPECIFICATION" : z7112.Specification = Children(i).Data
                                Case "SPEC1" : z7112.Spec1 = Children(i).Data
                                Case "SPEC2" : z7112.Spec2 = Children(i).Data
                                Case "SPEC3" : z7112.Spec3 = Children(i).Data
                                Case "SPEC4" : z7112.Spec4 = Children(i).Data
                                Case "WIDTH" : z7112.Width = Children(i).Data
                                Case "HEIGHT" : z7112.Height = Children(i).Data
                                Case "SEMAINPROCESS" : z7112.seMainProcess = Children(i).Data
                                Case "CDMAINPROCESS" : z7112.cdMainProcess = Children(i).Data
                                Case "SESUBPROCESS" : z7112.seSubProcess = Children(i).Data
                                Case "CDSUBPROCESS" : z7112.cdSubProcess = Children(i).Data
                                Case "SESPECIALPROCESS" : z7112.seSpecialProcess = Children(i).Data
                                Case "CDSPECIALPROCESS" : z7112.cdSpecialProcess = Children(i).Data
                                Case "SEUNITMATERIAL" : z7112.seUnitMaterial = Children(i).Data
                                Case "CDUNITMATERIAL" : z7112.cdUnitMaterial = Children(i).Data
                                Case "BASECOMPONENTBOM" : z7112.BaseComponentBOM = Children(i).Data
                                Case "SHOESCODE" : z7112.ShoesCode = Children(i).Data
                                Case "DSEQ" : z7112.Dseq = Children(i).Data
                                Case "LOSS" : z7112.Loss = Children(i).Data
                                Case "QTYCOMPONENT" : z7112.QtyComponent = Children(i).Data
                                Case "CSIZEQTY01" : z7112.CSizeQty01 = Children(i).Data
                                Case "CSIZEQTY02" : z7112.CSizeQty02 = Children(i).Data
                                Case "CSIZEQTY03" : z7112.CSizeQty03 = Children(i).Data
                                Case "CSIZEQTY04" : z7112.CSizeQty04 = Children(i).Data
                                Case "CSIZEQTY05" : z7112.CSizeQty05 = Children(i).Data
                                Case "CSIZEQTY06" : z7112.CSizeQty06 = Children(i).Data
                                Case "CSIZEQTY07" : z7112.CSizeQty07 = Children(i).Data
                                Case "CSIZEQTY08" : z7112.CSizeQty08 = Children(i).Data
                                Case "CSIZEQTY09" : z7112.CSizeQty09 = Children(i).Data
                                Case "CSIZEQTY10" : z7112.CSizeQty10 = Children(i).Data
                                Case "CSIZEQTY11" : z7112.CSizeQty11 = Children(i).Data
                                Case "CSIZEQTY12" : z7112.CSizeQty12 = Children(i).Data
                                Case "CSIZEQTY13" : z7112.CSizeQty13 = Children(i).Data
                                Case "CSIZEQTY14" : z7112.CSizeQty14 = Children(i).Data
                                Case "CSIZEQTY15" : z7112.CSizeQty15 = Children(i).Data
                                Case "CSIZEQTY16" : z7112.CSizeQty16 = Children(i).Data
                                Case "CSIZEQTY17" : z7112.CSizeQty17 = Children(i).Data
                                Case "CSIZEQTY18" : z7112.CSizeQty18 = Children(i).Data
                                Case "CSIZEQTY19" : z7112.CSizeQty19 = Children(i).Data
                                Case "CSIZEQTY20" : z7112.CSizeQty20 = Children(i).Data
                                Case "CSIZEQTY21" : z7112.CSizeQty21 = Children(i).Data
                                Case "CSIZEQTY22" : z7112.CSizeQty22 = Children(i).Data
                                Case "CSIZEQTY23" : z7112.CSizeQty23 = Children(i).Data
                                Case "CSIZEQTY24" : z7112.CSizeQty24 = Children(i).Data
                                Case "CSIZEQTY25" : z7112.CSizeQty25 = Children(i).Data
                                Case "CSIZEQTY26" : z7112.CSizeQty26 = Children(i).Data
                                Case "CSIZEQTY27" : z7112.CSizeQty27 = Children(i).Data
                                Case "CSIZEQTY28" : z7112.CSizeQty28 = Children(i).Data
                                Case "CSIZEQTY29" : z7112.CSizeQty29 = Children(i).Data
                                Case "CSIZEQTY30" : z7112.CSizeQty30 = Children(i).Data
                                Case "REMARK" : z7112.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7112_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K7112_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7112 As T7112_AREA, Job As String, CheckClear As Boolean, UPLOADNO As String, UPLOADSEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7112_MOVE = False

        Try
            If READ_PFK7112(UPLOADNO, UPLOADSEQ) = True Then
                z7112 = D7112
                K7112_MOVE = True
            Else
                If CheckClear = True Then z7112 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7112")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "UPLOADNO" : z7112.UploadNo = Children(i).Code
                                Case "UPLOADSEQ" : z7112.UploadSeq = Children(i).Code
                                Case "NAMEUPLOAD" : z7112.NameUpload = Children(i).Code
                                Case "CHECKTYPE" : z7112.CheckType = Children(i).Code
                                Case "DATEUPLOAD" : z7112.DateUpload = Children(i).Code
                                Case "INCHARGEUPLOAD" : z7112.InchargeUpload = Children(i).Code
                                Case "COMPONENTNAME" : z7112.ComponentName = Children(i).Code
                                Case "CDTYPECODE" : z7112.cdTypeCode = Children(i).Code
                                Case "TYPECODE" : z7112.TypeCode = Children(i).Code
                                Case "TYPENAME" : z7112.TypeName = Children(i).Code
                                Case "SPECIFICATION" : z7112.Specification = Children(i).Code
                                Case "SPEC1" : z7112.Spec1 = Children(i).Code
                                Case "SPEC2" : z7112.Spec2 = Children(i).Code
                                Case "SPEC3" : z7112.Spec3 = Children(i).Code
                                Case "SPEC4" : z7112.Spec4 = Children(i).Code
                                Case "WIDTH" : z7112.Width = Children(i).Code
                                Case "HEIGHT" : z7112.Height = Children(i).Code
                                Case "SEMAINPROCESS" : z7112.seMainProcess = Children(i).Code
                                Case "CDMAINPROCESS" : z7112.cdMainProcess = Children(i).Code
                                Case "SESUBPROCESS" : z7112.seSubProcess = Children(i).Code
                                Case "CDSUBPROCESS" : z7112.cdSubProcess = Children(i).Code
                                Case "SESPECIALPROCESS" : z7112.seSpecialProcess = Children(i).Code
                                Case "CDSPECIALPROCESS" : z7112.cdSpecialProcess = Children(i).Code
                                Case "SEUNITMATERIAL" : z7112.seUnitMaterial = Children(i).Code
                                Case "CDUNITMATERIAL" : z7112.cdUnitMaterial = Children(i).Code
                                Case "BASECOMPONENTBOM" : z7112.BaseComponentBOM = Children(i).Code
                                Case "SHOESCODE" : z7112.ShoesCode = Children(i).Code
                                Case "DSEQ" : z7112.Dseq = Children(i).Code
                                Case "LOSS" : z7112.Loss = Children(i).Code
                                Case "QTYCOMPONENT" : z7112.QtyComponent = Children(i).Code
                                Case "CSIZEQTY01" : z7112.CSizeQty01 = Children(i).Code
                                Case "CSIZEQTY02" : z7112.CSizeQty02 = Children(i).Code
                                Case "CSIZEQTY03" : z7112.CSizeQty03 = Children(i).Code
                                Case "CSIZEQTY04" : z7112.CSizeQty04 = Children(i).Code
                                Case "CSIZEQTY05" : z7112.CSizeQty05 = Children(i).Code
                                Case "CSIZEQTY06" : z7112.CSizeQty06 = Children(i).Code
                                Case "CSIZEQTY07" : z7112.CSizeQty07 = Children(i).Code
                                Case "CSIZEQTY08" : z7112.CSizeQty08 = Children(i).Code
                                Case "CSIZEQTY09" : z7112.CSizeQty09 = Children(i).Code
                                Case "CSIZEQTY10" : z7112.CSizeQty10 = Children(i).Code
                                Case "CSIZEQTY11" : z7112.CSizeQty11 = Children(i).Code
                                Case "CSIZEQTY12" : z7112.CSizeQty12 = Children(i).Code
                                Case "CSIZEQTY13" : z7112.CSizeQty13 = Children(i).Code
                                Case "CSIZEQTY14" : z7112.CSizeQty14 = Children(i).Code
                                Case "CSIZEQTY15" : z7112.CSizeQty15 = Children(i).Code
                                Case "CSIZEQTY16" : z7112.CSizeQty16 = Children(i).Code
                                Case "CSIZEQTY17" : z7112.CSizeQty17 = Children(i).Code
                                Case "CSIZEQTY18" : z7112.CSizeQty18 = Children(i).Code
                                Case "CSIZEQTY19" : z7112.CSizeQty19 = Children(i).Code
                                Case "CSIZEQTY20" : z7112.CSizeQty20 = Children(i).Code
                                Case "CSIZEQTY21" : z7112.CSizeQty21 = Children(i).Code
                                Case "CSIZEQTY22" : z7112.CSizeQty22 = Children(i).Code
                                Case "CSIZEQTY23" : z7112.CSizeQty23 = Children(i).Code
                                Case "CSIZEQTY24" : z7112.CSizeQty24 = Children(i).Code
                                Case "CSIZEQTY25" : z7112.CSizeQty25 = Children(i).Code
                                Case "CSIZEQTY26" : z7112.CSizeQty26 = Children(i).Code
                                Case "CSIZEQTY27" : z7112.CSizeQty27 = Children(i).Code
                                Case "CSIZEQTY28" : z7112.CSizeQty28 = Children(i).Code
                                Case "CSIZEQTY29" : z7112.CSizeQty29 = Children(i).Code
                                Case "CSIZEQTY30" : z7112.CSizeQty30 = Children(i).Code
                                Case "REMARK" : z7112.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "UPLOADNO" : z7112.UploadNo = Children(i).Data
                                Case "UPLOADSEQ" : z7112.UploadSeq = Children(i).Data
                                Case "NAMEUPLOAD" : z7112.NameUpload = Children(i).Data
                                Case "CHECKTYPE" : z7112.CheckType = Children(i).Data
                                Case "DATEUPLOAD" : z7112.DateUpload = Children(i).Data
                                Case "INCHARGEUPLOAD" : z7112.InchargeUpload = Children(i).Data
                                Case "COMPONENTNAME" : z7112.ComponentName = Children(i).Data
                                Case "CDTYPECODE" : z7112.cdTypeCode = Children(i).Data
                                Case "TYPECODE" : z7112.TypeCode = Children(i).Data
                                Case "TYPENAME" : z7112.TypeName = Children(i).Data
                                Case "SPECIFICATION" : z7112.Specification = Children(i).Data
                                Case "SPEC1" : z7112.Spec1 = Children(i).Data
                                Case "SPEC2" : z7112.Spec2 = Children(i).Data
                                Case "SPEC3" : z7112.Spec3 = Children(i).Data
                                Case "SPEC4" : z7112.Spec4 = Children(i).Data
                                Case "WIDTH" : z7112.Width = Children(i).Data
                                Case "HEIGHT" : z7112.Height = Children(i).Data
                                Case "SEMAINPROCESS" : z7112.seMainProcess = Children(i).Data
                                Case "CDMAINPROCESS" : z7112.cdMainProcess = Children(i).Data
                                Case "SESUBPROCESS" : z7112.seSubProcess = Children(i).Data
                                Case "CDSUBPROCESS" : z7112.cdSubProcess = Children(i).Data
                                Case "SESPECIALPROCESS" : z7112.seSpecialProcess = Children(i).Data
                                Case "CDSPECIALPROCESS" : z7112.cdSpecialProcess = Children(i).Data
                                Case "SEUNITMATERIAL" : z7112.seUnitMaterial = Children(i).Data
                                Case "CDUNITMATERIAL" : z7112.cdUnitMaterial = Children(i).Data
                                Case "BASECOMPONENTBOM" : z7112.BaseComponentBOM = Children(i).Data
   Case "SHOESCODE":z7112.ShoesCode = Children(i).Data
   Case "DSEQ":z7112.Dseq = Children(i).Data
   Case "LOSS":z7112.Loss = Children(i).Data
   Case "QTYCOMPONENT":z7112.QtyComponent = Children(i).Data
   Case "CSIZEQTY01":z7112.CSizeQty01 = Children(i).Data
   Case "CSIZEQTY02":z7112.CSizeQty02 = Children(i).Data
   Case "CSIZEQTY03":z7112.CSizeQty03 = Children(i).Data
   Case "CSIZEQTY04":z7112.CSizeQty04 = Children(i).Data
   Case "CSIZEQTY05":z7112.CSizeQty05 = Children(i).Data
   Case "CSIZEQTY06":z7112.CSizeQty06 = Children(i).Data
   Case "CSIZEQTY07":z7112.CSizeQty07 = Children(i).Data
   Case "CSIZEQTY08":z7112.CSizeQty08 = Children(i).Data
   Case "CSIZEQTY09":z7112.CSizeQty09 = Children(i).Data
   Case "CSIZEQTY10":z7112.CSizeQty10 = Children(i).Data
   Case "CSIZEQTY11":z7112.CSizeQty11 = Children(i).Data
   Case "CSIZEQTY12":z7112.CSizeQty12 = Children(i).Data
   Case "CSIZEQTY13":z7112.CSizeQty13 = Children(i).Data
   Case "CSIZEQTY14":z7112.CSizeQty14 = Children(i).Data
   Case "CSIZEQTY15":z7112.CSizeQty15 = Children(i).Data
   Case "CSIZEQTY16":z7112.CSizeQty16 = Children(i).Data
   Case "CSIZEQTY17":z7112.CSizeQty17 = Children(i).Data
   Case "CSIZEQTY18":z7112.CSizeQty18 = Children(i).Data
   Case "CSIZEQTY19":z7112.CSizeQty19 = Children(i).Data
   Case "CSIZEQTY20":z7112.CSizeQty20 = Children(i).Data
   Case "CSIZEQTY21":z7112.CSizeQty21 = Children(i).Data
   Case "CSIZEQTY22":z7112.CSizeQty22 = Children(i).Data
   Case "CSIZEQTY23":z7112.CSizeQty23 = Children(i).Data
   Case "CSIZEQTY24":z7112.CSizeQty24 = Children(i).Data
   Case "CSIZEQTY25":z7112.CSizeQty25 = Children(i).Data
   Case "CSIZEQTY26":z7112.CSizeQty26 = Children(i).Data
   Case "CSIZEQTY27":z7112.CSizeQty27 = Children(i).Data
   Case "CSIZEQTY28":z7112.CSizeQty28 = Children(i).Data
   Case "CSIZEQTY29":z7112.CSizeQty29 = Children(i).Data
   Case "CSIZEQTY30":z7112.CSizeQty30 = Children(i).Data
   Case "REMARK":z7112.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7112_MOVE",vbCritical)
End Try
End Function 
    
End Module 
