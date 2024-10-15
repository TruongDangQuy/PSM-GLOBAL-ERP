'=========================================================================================================================================================
'   TABLE : (PFK4958)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K4958

    Structure T4958_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public Autokey As Double  '			decimal		*
        Public AutoKey_K3422 As Double  '			decimal
        Public ProductInBoundNo As String  '			char(9)
        Public ProductInBoundSeq As String  '			char(3)
        Public PackingBatch As String  '			nvarchar(20)
        Public PackingCusBatch As String  '			nvarchar(20)
        Public sePackingType As String  '			char(3)
        Public cdPackingType As String  '			char(3)
        Public PackingTypeName As String  '			nvarchar(20)
        Public DatePacking As String  '			char(8)
        Public CustomerCode As String  '			char(6)
        Public CartonCode As String  '			char(6)
        Public CartonNo As Double  '			decimal
        Public LoadingNo As String  '			nvarchar(20)
        Public LoadingCode As String  '			char(9)
        Public LoadingSeq As String  '			char(3)
        Public OrderNo As String  '			char(9)
        Public OrderNoSeq As String  '			char(3)
        Public FactOrderNo As String  '			char(9)
        Public FactOrderSeq As Double  '			decimal
        Public JobCard As String  '			char(9)
        Public SizeGroup As String  '			nvarchar(20)
        Public QtyPrs As Double  '			decimal
        Public SizeQty01 As Double  '			decimal
        Public SizeQty02 As Double  '			decimal
        Public SizeQty03 As Double  '			decimal
        Public SizeQty04 As Double  '			decimal
        Public SizeQty05 As Double  '			decimal
        Public SizeQty06 As Double  '			decimal
        Public SizeQty07 As Double  '			decimal
        Public SizeQty08 As Double  '			decimal
        Public SizeQty09 As Double  '			decimal
        Public SizeQty10 As Double  '			decimal
        Public SizeQty11 As Double  '			decimal
        Public SizeQty12 As Double  '			decimal
        Public SizeQty13 As Double  '			decimal
        Public SizeQty14 As Double  '			decimal
        Public SizeQty15 As Double  '			decimal
        Public SizeQty16 As Double  '			decimal
        Public SizeQty17 As Double  '			decimal
        Public SizeQty18 As Double  '			decimal
        Public SizeQty19 As Double  '			decimal
        Public SizeQty20 As Double  '			decimal
        Public SizeQty21 As Double  '			decimal
        Public SizeQty22 As Double  '			decimal
        Public SizeQty23 As Double  '			decimal
        Public SizeQty24 As Double  '			decimal
        Public SizeQty25 As Double  '			decimal
        Public SizeQty26 As Double  '			decimal
        Public SizeQty27 As Double  '			decimal
        Public SizeQty28 As Double  '			decimal
        Public SizeQty29 As Double  '			decimal
        Public SizeQty30 As Double  '			decimal
        Public PackingCMB As Double  '			decimal
        Public PackingGW As Double  '			decimal
        Public PackingNW As Double  '			decimal
        Public QtyPacking As Double  '			decimal
        Public QtyLoading As Double  '			decimal
       
        Public JCPREFIX1 As String  '			nvarchar(10)
        Public JCPREFIX2 As String  '			nvarchar(10)
        Public JOBCARDNO As String  '			nvarchar(10)
        Public ColorCode As String  '			nvarchar(50)
        Public MCODENAME As String  '			nvarchar(50)
        Public PONO As String  '			nvarchar(50)
        Public PKONO As String  '			nvarchar(50)
        Public SlNoD As String  '			nvarchar(20)
        Public SlNo As String  '			nvarchar(20)
        Public Article As String  '			nvarchar(50)
        Public SizeRangeName As String  '			nvarchar(20)
        Public seSeason As String  '			char(3)
        Public cdSeason As String  '			char(3)
        Public DateInsert As String  '			char(8)
        Public DateUpdate As String  '			char(8)
        Public InchargeInsert As String  '			char(8)
        Public InchargeUpdate As String  '			char(8)
        Public CheckUse As String  '			char(1)
        Public CheckComplete As String  '			char(1)
        Public Printed As String  '			char(1)
        Public Remark As String  '			nvarchar(50)
        '=========================================================================================================================================================
    End Structure

    Public D4958 As T4958_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK4958(AUTOKEY As Double) As Boolean
        READ_PFK4958 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4958 "
            SQL = SQL & " WHERE K4958_Autokey		 =  " & Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4958_CLEAR() : GoTo SKIP_READ_PFK4958

            Call K4958_MOVE(rd)
            READ_PFK4958 = True

SKIP_READ_PFK4958:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4958", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK4958(AUTOKEY As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4958 "
            SQL = SQL & " WHERE K4958_Autokey		 =  " & Autokey & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK4958", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK4958(z4958 As T4958_AREA) As Boolean
        WRITE_PFK4958 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z4958)

            SQL = " INSERT INTO PFK4958 "
            SQL = SQL & " ( "
            SQL = SQL & " K4958_AutoKey_K3422,"
            SQL = SQL & " K4958_ProductInBoundNo,"
            SQL = SQL & " K4958_ProductInBoundSeq,"
            SQL = SQL & " K4958_PackingBatch,"
            SQL = SQL & " K4958_PackingCusBatch,"
            SQL = SQL & " K4958_sePackingType,"
            SQL = SQL & " K4958_cdPackingType,"
            SQL = SQL & " K4958_PackingTypeName,"
            SQL = SQL & " K4958_DatePacking,"
            SQL = SQL & " K4958_CustomerCode,"
            SQL = SQL & " K4958_CartonCode,"
            SQL = SQL & " K4958_CartonNo,"
            SQL = SQL & " K4958_LoadingNo,"
            SQL = SQL & " K4958_LoadingCode,"
            SQL = SQL & " K4958_LoadingSeq,"
            SQL = SQL & " K4958_OrderNo,"
            SQL = SQL & " K4958_OrderNoSeq,"
            SQL = SQL & " K4958_FactOrderNo,"
            SQL = SQL & " K4958_FactOrderSeq,"
            SQL = SQL & " K4958_JobCard,"
            SQL = SQL & " K4958_SizeGroup,"
            SQL = SQL & " K4958_QtyPrs,"
            SQL = SQL & " K4958_SizeQty01,"
            SQL = SQL & " K4958_SizeQty02,"
            SQL = SQL & " K4958_SizeQty03,"
            SQL = SQL & " K4958_SizeQty04,"
            SQL = SQL & " K4958_SizeQty05,"
            SQL = SQL & " K4958_SizeQty06,"
            SQL = SQL & " K4958_SizeQty07,"
            SQL = SQL & " K4958_SizeQty08,"
            SQL = SQL & " K4958_SizeQty09,"
            SQL = SQL & " K4958_SizeQty10,"
            SQL = SQL & " K4958_SizeQty11,"
            SQL = SQL & " K4958_SizeQty12,"
            SQL = SQL & " K4958_SizeQty13,"
            SQL = SQL & " K4958_SizeQty14,"
            SQL = SQL & " K4958_SizeQty15,"
            SQL = SQL & " K4958_SizeQty16,"
            SQL = SQL & " K4958_SizeQty17,"
            SQL = SQL & " K4958_SizeQty18,"
            SQL = SQL & " K4958_SizeQty19,"
            SQL = SQL & " K4958_SizeQty20,"
            SQL = SQL & " K4958_SizeQty21,"
            SQL = SQL & " K4958_SizeQty22,"
            SQL = SQL & " K4958_SizeQty23,"
            SQL = SQL & " K4958_SizeQty24,"
            SQL = SQL & " K4958_SizeQty25,"
            SQL = SQL & " K4958_SizeQty26,"
            SQL = SQL & " K4958_SizeQty27,"
            SQL = SQL & " K4958_SizeQty28,"
            SQL = SQL & " K4958_SizeQty29,"
            SQL = SQL & " K4958_SizeQty30,"
            SQL = SQL & " K4958_PackingCMB,"
            SQL = SQL & " K4958_PackingGW,"
            SQL = SQL & " K4958_PackingNW,"
            SQL = SQL & " K4958_QtyPacking,"
            SQL = SQL & " K4958_QtyLoading,"

            SQL = SQL & " K4958_JCPREFIX1,"
            SQL = SQL & " K4958_JCPREFIX2,"
            SQL = SQL & " K4958_JOBCARDNO,"
            SQL = SQL & " K4958_ColorCode,"
            SQL = SQL & " K4958_MCODENAME,"
            SQL = SQL & " K4958_PONO,"
            SQL = SQL & " K4958_PKONO,"
            SQL = SQL & " K4958_SlNoD,"
            SQL = SQL & " K4958_SlNo,"
            SQL = SQL & " K4958_Article,"
            SQL = SQL & " K4958_SizeRangeName,"
            SQL = SQL & " K4958_seSeason,"
            SQL = SQL & " K4958_cdSeason,"
            SQL = SQL & " K4958_DateInsert,"
            SQL = SQL & " K4958_DateUpdate,"
            SQL = SQL & " K4958_InchargeInsert,"
            SQL = SQL & " K4958_InchargeUpdate,"
            SQL = SQL & " K4958_CheckUse,"
            SQL = SQL & " K4958_CheckComplete,"
            SQL = SQL & " K4958_Printed,"
            SQL = SQL & " K4958_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "   " & FormatSQL(z4958.AutoKey_K3422) & ", "
            SQL = SQL & "  N'" & FormatSQL(z4958.ProductInBoundNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4958.ProductInBoundSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4958.PackingBatch) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4958.PackingCusBatch) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4958.sePackingType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4958.cdPackingType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4958.PackingTypeName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4958.DatePacking) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4958.CustomerCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4958.CartonCode) & "', "
            SQL = SQL & "   " & FormatSQL(z4958.CartonNo) & ", "
            SQL = SQL & "  N'" & FormatSQL(z4958.LoadingNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4958.LoadingCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4958.LoadingSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4958.OrderNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4958.OrderNoSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4958.FactOrderNo) & "', "
            SQL = SQL & "   " & FormatSQL(z4958.FactOrderSeq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z4958.JobCard) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4958.SizeGroup) & "', "
            SQL = SQL & "   " & FormatSQL(z4958.QtyPrs) & ", "
            SQL = SQL & "   " & FormatSQL(z4958.SizeQty01) & ", "
            SQL = SQL & "   " & FormatSQL(z4958.SizeQty02) & ", "
            SQL = SQL & "   " & FormatSQL(z4958.SizeQty03) & ", "
            SQL = SQL & "   " & FormatSQL(z4958.SizeQty04) & ", "
            SQL = SQL & "   " & FormatSQL(z4958.SizeQty05) & ", "
            SQL = SQL & "   " & FormatSQL(z4958.SizeQty06) & ", "
            SQL = SQL & "   " & FormatSQL(z4958.SizeQty07) & ", "
            SQL = SQL & "   " & FormatSQL(z4958.SizeQty08) & ", "
            SQL = SQL & "   " & FormatSQL(z4958.SizeQty09) & ", "
            SQL = SQL & "   " & FormatSQL(z4958.SizeQty10) & ", "
            SQL = SQL & "   " & FormatSQL(z4958.SizeQty11) & ", "
            SQL = SQL & "   " & FormatSQL(z4958.SizeQty12) & ", "
            SQL = SQL & "   " & FormatSQL(z4958.SizeQty13) & ", "
            SQL = SQL & "   " & FormatSQL(z4958.SizeQty14) & ", "
            SQL = SQL & "   " & FormatSQL(z4958.SizeQty15) & ", "
            SQL = SQL & "   " & FormatSQL(z4958.SizeQty16) & ", "
            SQL = SQL & "   " & FormatSQL(z4958.SizeQty17) & ", "
            SQL = SQL & "   " & FormatSQL(z4958.SizeQty18) & ", "
            SQL = SQL & "   " & FormatSQL(z4958.SizeQty19) & ", "
            SQL = SQL & "   " & FormatSQL(z4958.SizeQty20) & ", "
            SQL = SQL & "   " & FormatSQL(z4958.SizeQty21) & ", "
            SQL = SQL & "   " & FormatSQL(z4958.SizeQty22) & ", "
            SQL = SQL & "   " & FormatSQL(z4958.SizeQty23) & ", "
            SQL = SQL & "   " & FormatSQL(z4958.SizeQty24) & ", "
            SQL = SQL & "   " & FormatSQL(z4958.SizeQty25) & ", "
            SQL = SQL & "   " & FormatSQL(z4958.SizeQty26) & ", "
            SQL = SQL & "   " & FormatSQL(z4958.SizeQty27) & ", "
            SQL = SQL & "   " & FormatSQL(z4958.SizeQty28) & ", "
            SQL = SQL & "   " & FormatSQL(z4958.SizeQty29) & ", "
            SQL = SQL & "   " & FormatSQL(z4958.SizeQty30) & ", "
            SQL = SQL & "   " & FormatSQL(z4958.PackingCMB) & ", "
            SQL = SQL & "   " & FormatSQL(z4958.PackingGW) & ", "
            SQL = SQL & "   " & FormatSQL(z4958.PackingNW) & ", "
            SQL = SQL & "   " & FormatSQL(z4958.QtyPacking) & ", "
            SQL = SQL & "   " & FormatSQL(z4958.QtyLoading) & ", "

            SQL = SQL & "  N'" & FormatSQL(z4958.JCPREFIX1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4958.JCPREFIX2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4958.JOBCARDNO) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4958.ColorCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4958.MCODENAME) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4958.PONO) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4958.PKONO) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4958.SlNoD) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4958.SlNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4958.Article) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4958.SizeRangeName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4958.seSeason) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4958.cdSeason) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4958.DateInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4958.DateUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4958.InchargeInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4958.InchargeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4958.CheckUse) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4958.CheckComplete) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4958.Printed) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4958.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK4958 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK4958", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK4958(z4958 As T4958_AREA) As Boolean
        REWRITE_PFK4958 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z4958)

            SQL = " UPDATE PFK4958 SET "
            SQL = SQL & "    K4958_AutoKey_K3422      =  " & FormatSQL(z4958.AutoKey_K3422) & ", "
            SQL = SQL & "    K4958_ProductInBoundNo      = N'" & FormatSQL(z4958.ProductInBoundNo) & "', "
            SQL = SQL & "    K4958_ProductInBoundSeq      = N'" & FormatSQL(z4958.ProductInBoundSeq) & "', "
            SQL = SQL & "    K4958_PackingBatch      = N'" & FormatSQL(z4958.PackingBatch) & "', "
            SQL = SQL & "    K4958_PackingCusBatch      = N'" & FormatSQL(z4958.PackingCusBatch) & "', "
            SQL = SQL & "    K4958_sePackingType      = N'" & FormatSQL(z4958.sePackingType) & "', "
            SQL = SQL & "    K4958_cdPackingType      = N'" & FormatSQL(z4958.cdPackingType) & "', "
            SQL = SQL & "    K4958_PackingTypeName      = N'" & FormatSQL(z4958.PackingTypeName) & "', "
            SQL = SQL & "    K4958_DatePacking      = N'" & FormatSQL(z4958.DatePacking) & "', "
            SQL = SQL & "    K4958_CustomerCode      = N'" & FormatSQL(z4958.CustomerCode) & "', "
            SQL = SQL & "    K4958_CartonCode      = N'" & FormatSQL(z4958.CartonCode) & "', "
            SQL = SQL & "    K4958_CartonNo      =  " & FormatSQL(z4958.CartonNo) & ", "
            SQL = SQL & "    K4958_LoadingNo      = N'" & FormatSQL(z4958.LoadingNo) & "', "
            SQL = SQL & "    K4958_LoadingCode      = N'" & FormatSQL(z4958.LoadingCode) & "', "
            SQL = SQL & "    K4958_LoadingSeq      = N'" & FormatSQL(z4958.LoadingSeq) & "', "
            SQL = SQL & "    K4958_OrderNo      = N'" & FormatSQL(z4958.OrderNo) & "', "
            SQL = SQL & "    K4958_OrderNoSeq      = N'" & FormatSQL(z4958.OrderNoSeq) & "', "
            SQL = SQL & "    K4958_FactOrderNo      = N'" & FormatSQL(z4958.FactOrderNo) & "', "
            SQL = SQL & "    K4958_FactOrderSeq      =  " & FormatSQL(z4958.FactOrderSeq) & ", "
            SQL = SQL & "    K4958_JobCard      = N'" & FormatSQL(z4958.JobCard) & "', "
            SQL = SQL & "    K4958_SizeGroup      = N'" & FormatSQL(z4958.SizeGroup) & "', "
            SQL = SQL & "    K4958_QtyPrs      =  " & FormatSQL(z4958.QtyPrs) & ", "
            SQL = SQL & "    K4958_SizeQty01      =  " & FormatSQL(z4958.SizeQty01) & ", "
            SQL = SQL & "    K4958_SizeQty02      =  " & FormatSQL(z4958.SizeQty02) & ", "
            SQL = SQL & "    K4958_SizeQty03      =  " & FormatSQL(z4958.SizeQty03) & ", "
            SQL = SQL & "    K4958_SizeQty04      =  " & FormatSQL(z4958.SizeQty04) & ", "
            SQL = SQL & "    K4958_SizeQty05      =  " & FormatSQL(z4958.SizeQty05) & ", "
            SQL = SQL & "    K4958_SizeQty06      =  " & FormatSQL(z4958.SizeQty06) & ", "
            SQL = SQL & "    K4958_SizeQty07      =  " & FormatSQL(z4958.SizeQty07) & ", "
            SQL = SQL & "    K4958_SizeQty08      =  " & FormatSQL(z4958.SizeQty08) & ", "
            SQL = SQL & "    K4958_SizeQty09      =  " & FormatSQL(z4958.SizeQty09) & ", "
            SQL = SQL & "    K4958_SizeQty10      =  " & FormatSQL(z4958.SizeQty10) & ", "
            SQL = SQL & "    K4958_SizeQty11      =  " & FormatSQL(z4958.SizeQty11) & ", "
            SQL = SQL & "    K4958_SizeQty12      =  " & FormatSQL(z4958.SizeQty12) & ", "
            SQL = SQL & "    K4958_SizeQty13      =  " & FormatSQL(z4958.SizeQty13) & ", "
            SQL = SQL & "    K4958_SizeQty14      =  " & FormatSQL(z4958.SizeQty14) & ", "
            SQL = SQL & "    K4958_SizeQty15      =  " & FormatSQL(z4958.SizeQty15) & ", "
            SQL = SQL & "    K4958_SizeQty16      =  " & FormatSQL(z4958.SizeQty16) & ", "
            SQL = SQL & "    K4958_SizeQty17      =  " & FormatSQL(z4958.SizeQty17) & ", "
            SQL = SQL & "    K4958_SizeQty18      =  " & FormatSQL(z4958.SizeQty18) & ", "
            SQL = SQL & "    K4958_SizeQty19      =  " & FormatSQL(z4958.SizeQty19) & ", "
            SQL = SQL & "    K4958_SizeQty20      =  " & FormatSQL(z4958.SizeQty20) & ", "
            SQL = SQL & "    K4958_SizeQty21      =  " & FormatSQL(z4958.SizeQty21) & ", "
            SQL = SQL & "    K4958_SizeQty22      =  " & FormatSQL(z4958.SizeQty22) & ", "
            SQL = SQL & "    K4958_SizeQty23      =  " & FormatSQL(z4958.SizeQty23) & ", "
            SQL = SQL & "    K4958_SizeQty24      =  " & FormatSQL(z4958.SizeQty24) & ", "
            SQL = SQL & "    K4958_SizeQty25      =  " & FormatSQL(z4958.SizeQty25) & ", "
            SQL = SQL & "    K4958_SizeQty26      =  " & FormatSQL(z4958.SizeQty26) & ", "
            SQL = SQL & "    K4958_SizeQty27      =  " & FormatSQL(z4958.SizeQty27) & ", "
            SQL = SQL & "    K4958_SizeQty28      =  " & FormatSQL(z4958.SizeQty28) & ", "
            SQL = SQL & "    K4958_SizeQty29      =  " & FormatSQL(z4958.SizeQty29) & ", "
            SQL = SQL & "    K4958_SizeQty30      =  " & FormatSQL(z4958.SizeQty30) & ", "
            SQL = SQL & "    K4958_PackingCMB      =  " & FormatSQL(z4958.PackingCMB) & ", "
            SQL = SQL & "    K4958_PackingGW      =  " & FormatSQL(z4958.PackingGW) & ", "
            SQL = SQL & "    K4958_PackingNW      =  " & FormatSQL(z4958.PackingNW) & ", "
            SQL = SQL & "    K4958_QtyPacking      =  " & FormatSQL(z4958.QtyPacking) & ", "
            SQL = SQL & "    K4958_QtyLoading      =  " & FormatSQL(z4958.QtyLoading) & ", "

            SQL = SQL & "    K4958_JCPREFIX1      = N'" & FormatSQL(z4958.JCPREFIX1) & "', "
            SQL = SQL & "    K4958_JCPREFIX2      = N'" & FormatSQL(z4958.JCPREFIX2) & "', "
            SQL = SQL & "    K4958_JOBCARDNO      = N'" & FormatSQL(z4958.JOBCARDNO) & "', "
            SQL = SQL & "    K4958_ColorCode      = N'" & FormatSQL(z4958.ColorCode) & "', "
            SQL = SQL & "    K4958_MCODENAME      = N'" & FormatSQL(z4958.MCODENAME) & "', "
            SQL = SQL & "    K4958_PONO      = N'" & FormatSQL(z4958.PONO) & "', "
            SQL = SQL & "    K4958_PKONO      = N'" & FormatSQL(z4958.PKONO) & "', "
            SQL = SQL & "    K4958_SlNoD      = N'" & FormatSQL(z4958.SlNoD) & "', "
            SQL = SQL & "    K4958_SlNo      = N'" & FormatSQL(z4958.SlNo) & "', "
            SQL = SQL & "    K4958_Article      = N'" & FormatSQL(z4958.Article) & "', "
            SQL = SQL & "    K4958_SizeRangeName      = N'" & FormatSQL(z4958.SizeRangeName) & "', "
            SQL = SQL & "    K4958_seSeason      = N'" & FormatSQL(z4958.seSeason) & "', "
            SQL = SQL & "    K4958_cdSeason      = N'" & FormatSQL(z4958.cdSeason) & "', "
            SQL = SQL & "    K4958_DateInsert      = N'" & FormatSQL(z4958.DateInsert) & "', "
            SQL = SQL & "    K4958_DateUpdate      = N'" & FormatSQL(z4958.DateUpdate) & "', "
            SQL = SQL & "    K4958_InchargeInsert      = N'" & FormatSQL(z4958.InchargeInsert) & "', "
            SQL = SQL & "    K4958_InchargeUpdate      = N'" & FormatSQL(z4958.InchargeUpdate) & "', "
            SQL = SQL & "    K4958_CheckUse      = N'" & FormatSQL(z4958.CheckUse) & "', "
            SQL = SQL & "    K4958_CheckComplete      = N'" & FormatSQL(z4958.CheckComplete) & "', "
            SQL = SQL & "    K4958_Printed      = N'" & FormatSQL(z4958.Printed) & "', "
            SQL = SQL & "    K4958_Remark      = N'" & FormatSQL(z4958.Remark) & "'  "
            SQL = SQL & " WHERE K4958_Autokey		 =  " & z4958.Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK4958 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK4958", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK4958(z4958 As T4958_AREA) As Boolean
        DELETE_PFK4958 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK4958 "
            SQL = SQL & " WHERE K4958_Autokey		 =  " & z4958.Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK4958 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK4958", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D4958_CLEAR()
        Try

            D4958.Autokey = 0
            D4958.AutoKey_K3422 = 0
            D4958.ProductInBoundNo = ""
            D4958.ProductInBoundSeq = ""
            D4958.PackingBatch = ""
            D4958.PackingCusBatch = ""
            D4958.sePackingType = ""
            D4958.cdPackingType = ""
            D4958.PackingTypeName = ""
            D4958.DatePacking = ""
            D4958.CustomerCode = ""
            D4958.CartonCode = ""
            D4958.CartonNo = 0
            D4958.LoadingNo = ""
            D4958.LoadingCode = ""
            D4958.LoadingSeq = ""
            D4958.OrderNo = ""
            D4958.OrderNoSeq = ""
            D4958.FactOrderNo = ""
            D4958.FactOrderSeq = 0
            D4958.JobCard = ""
            D4958.SizeGroup = ""
            D4958.QtyPrs = 0
            D4958.SizeQty01 = 0
            D4958.SizeQty02 = 0
            D4958.SizeQty03 = 0
            D4958.SizeQty04 = 0
            D4958.SizeQty05 = 0
            D4958.SizeQty06 = 0
            D4958.SizeQty07 = 0
            D4958.SizeQty08 = 0
            D4958.SizeQty09 = 0
            D4958.SizeQty10 = 0
            D4958.SizeQty11 = 0
            D4958.SizeQty12 = 0
            D4958.SizeQty13 = 0
            D4958.SizeQty14 = 0
            D4958.SizeQty15 = 0
            D4958.SizeQty16 = 0
            D4958.SizeQty17 = 0
            D4958.SizeQty18 = 0
            D4958.SizeQty19 = 0
            D4958.SizeQty20 = 0
            D4958.SizeQty21 = 0
            D4958.SizeQty22 = 0
            D4958.SizeQty23 = 0
            D4958.SizeQty24 = 0
            D4958.SizeQty25 = 0
            D4958.SizeQty26 = 0
            D4958.SizeQty27 = 0
            D4958.SizeQty28 = 0
            D4958.SizeQty29 = 0
            D4958.SizeQty30 = 0
            D4958.PackingCMB = 0
            D4958.PackingGW = 0
            D4958.PackingNW = 0
            D4958.QtyPacking = 0
            D4958.QtyLoading = 0

            D4958.JCPREFIX1 = ""
            D4958.JCPREFIX2 = ""
            D4958.JOBCARDNO = ""
            D4958.ColorCode = ""
            D4958.MCODENAME = ""
            D4958.PONO = ""
            D4958.PKONO = ""
            D4958.SlNoD = ""
            D4958.SlNo = ""
            D4958.Article = ""
            D4958.SizeRangeName = ""
            D4958.seSeason = ""
            D4958.cdSeason = ""
            D4958.DateInsert = ""
            D4958.DateUpdate = ""
            D4958.InchargeInsert = ""
            D4958.InchargeUpdate = ""
            D4958.CheckUse = ""
            D4958.CheckComplete = ""
            D4958.Printed = ""
            D4958.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D4958_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x4958 As T4958_AREA)
        Try

            x4958.Autokey = trim$(x4958.Autokey)
            x4958.AutoKey_K3422 = trim$(x4958.AutoKey_K3422)
            x4958.ProductInBoundNo = trim$(x4958.ProductInBoundNo)
            x4958.ProductInBoundSeq = trim$(x4958.ProductInBoundSeq)
            x4958.PackingBatch = trim$(x4958.PackingBatch)
            x4958.PackingCusBatch = trim$(x4958.PackingCusBatch)
            x4958.sePackingType = trim$(x4958.sePackingType)
            x4958.cdPackingType = trim$(x4958.cdPackingType)
            x4958.PackingTypeName = trim$(x4958.PackingTypeName)
            x4958.DatePacking = trim$(x4958.DatePacking)
            x4958.CustomerCode = trim$(x4958.CustomerCode)
            x4958.CartonCode = trim$(x4958.CartonCode)
            x4958.CartonNo = trim$(x4958.CartonNo)
            x4958.LoadingNo = trim$(x4958.LoadingNo)
            x4958.LoadingCode = trim$(x4958.LoadingCode)
            x4958.LoadingSeq = trim$(x4958.LoadingSeq)
            x4958.OrderNo = trim$(x4958.OrderNo)
            x4958.OrderNoSeq = trim$(x4958.OrderNoSeq)
            x4958.FactOrderNo = trim$(x4958.FactOrderNo)
            x4958.FactOrderSeq = trim$(x4958.FactOrderSeq)
            x4958.JobCard = trim$(x4958.JobCard)
            x4958.SizeGroup = trim$(x4958.SizeGroup)
            x4958.QtyPrs = trim$(x4958.QtyPrs)
            x4958.SizeQty01 = trim$(x4958.SizeQty01)
            x4958.SizeQty02 = trim$(x4958.SizeQty02)
            x4958.SizeQty03 = trim$(x4958.SizeQty03)
            x4958.SizeQty04 = trim$(x4958.SizeQty04)
            x4958.SizeQty05 = trim$(x4958.SizeQty05)
            x4958.SizeQty06 = trim$(x4958.SizeQty06)
            x4958.SizeQty07 = trim$(x4958.SizeQty07)
            x4958.SizeQty08 = trim$(x4958.SizeQty08)
            x4958.SizeQty09 = trim$(x4958.SizeQty09)
            x4958.SizeQty10 = trim$(x4958.SizeQty10)
            x4958.SizeQty11 = trim$(x4958.SizeQty11)
            x4958.SizeQty12 = trim$(x4958.SizeQty12)
            x4958.SizeQty13 = trim$(x4958.SizeQty13)
            x4958.SizeQty14 = trim$(x4958.SizeQty14)
            x4958.SizeQty15 = trim$(x4958.SizeQty15)
            x4958.SizeQty16 = trim$(x4958.SizeQty16)
            x4958.SizeQty17 = trim$(x4958.SizeQty17)
            x4958.SizeQty18 = trim$(x4958.SizeQty18)
            x4958.SizeQty19 = trim$(x4958.SizeQty19)
            x4958.SizeQty20 = trim$(x4958.SizeQty20)
            x4958.SizeQty21 = trim$(x4958.SizeQty21)
            x4958.SizeQty22 = trim$(x4958.SizeQty22)
            x4958.SizeQty23 = trim$(x4958.SizeQty23)
            x4958.SizeQty24 = trim$(x4958.SizeQty24)
            x4958.SizeQty25 = trim$(x4958.SizeQty25)
            x4958.SizeQty26 = trim$(x4958.SizeQty26)
            x4958.SizeQty27 = trim$(x4958.SizeQty27)
            x4958.SizeQty28 = trim$(x4958.SizeQty28)
            x4958.SizeQty29 = trim$(x4958.SizeQty29)
            x4958.SizeQty30 = trim$(x4958.SizeQty30)
            x4958.PackingCMB = trim$(x4958.PackingCMB)
            x4958.PackingGW = trim$(x4958.PackingGW)
            x4958.PackingNW = trim$(x4958.PackingNW)
            x4958.QtyPacking = trim$(x4958.QtyPacking)
            x4958.QtyLoading = trim$(x4958.QtyLoading)

            x4958.JCPREFIX1 = trim$(x4958.JCPREFIX1)
            x4958.JCPREFIX2 = trim$(x4958.JCPREFIX2)
            x4958.JOBCARDNO = trim$(x4958.JOBCARDNO)
            x4958.ColorCode = trim$(x4958.ColorCode)
            x4958.MCODENAME = trim$(x4958.MCODENAME)
            x4958.PONO = trim$(x4958.PONO)
            x4958.PKONO = trim$(x4958.PKONO)
            x4958.SlNoD = trim$(x4958.SlNoD)
            x4958.SlNo = trim$(x4958.SlNo)
            x4958.Article = trim$(x4958.Article)
            x4958.SizeRangeName = trim$(x4958.SizeRangeName)
            x4958.seSeason = trim$(x4958.seSeason)
            x4958.cdSeason = trim$(x4958.cdSeason)
            x4958.DateInsert = trim$(x4958.DateInsert)
            x4958.DateUpdate = trim$(x4958.DateUpdate)
            x4958.InchargeInsert = trim$(x4958.InchargeInsert)
            x4958.InchargeUpdate = trim$(x4958.InchargeUpdate)
            x4958.CheckUse = trim$(x4958.CheckUse)
            x4958.CheckComplete = trim$(x4958.CheckComplete)
            x4958.Printed = trim$(x4958.Printed)
            x4958.Remark = trim$(x4958.Remark)

            If trim$(x4958.Autokey) = "" Then x4958.Autokey = 0
            If trim$(x4958.AutoKey_K3422) = "" Then x4958.AutoKey_K3422 = 0

            If trim$(x4958.ProductInBoundNo) = "" Then x4958.ProductInBoundNo = Space(1)
            If trim$(x4958.ProductInBoundSeq) = "" Then x4958.ProductInBoundSeq = Space(1)
            If trim$(x4958.PackingBatch) = "" Then x4958.PackingBatch = Space(1)
            If trim$(x4958.PackingCusBatch) = "" Then x4958.PackingCusBatch = Space(1)
            If trim$(x4958.sePackingType) = "" Then x4958.sePackingType = Space(1)
            If trim$(x4958.cdPackingType) = "" Then x4958.cdPackingType = Space(1)
            If trim$(x4958.PackingTypeName) = "" Then x4958.PackingTypeName = Space(1)
            If trim$(x4958.DatePacking) = "" Then x4958.DatePacking = Space(1)
            If trim$(x4958.CustomerCode) = "" Then x4958.CustomerCode = Space(1)
            If trim$(x4958.CartonCode) = "" Then x4958.CartonCode = Space(1)
            If trim$(x4958.CartonNo) = "" Then x4958.CartonNo = 0
            If trim$(x4958.LoadingNo) = "" Then x4958.LoadingNo = Space(1)
            If trim$(x4958.LoadingCode) = "" Then x4958.LoadingCode = Space(1)
            If trim$(x4958.LoadingSeq) = "" Then x4958.LoadingSeq = Space(1)
            If trim$(x4958.OrderNo) = "" Then x4958.OrderNo = Space(1)
            If trim$(x4958.OrderNoSeq) = "" Then x4958.OrderNoSeq = Space(1)
            If trim$(x4958.FactOrderNo) = "" Then x4958.FactOrderNo = Space(1)
            If trim$(x4958.FactOrderSeq) = "" Then x4958.FactOrderSeq = 0
            If trim$(x4958.JobCard) = "" Then x4958.JobCard = Space(1)
            If trim$(x4958.SizeGroup) = "" Then x4958.SizeGroup = Space(1)
            If trim$(x4958.QtyPrs) = "" Then x4958.QtyPrs = 0
            If trim$(x4958.SizeQty01) = "" Then x4958.SizeQty01 = 0
            If trim$(x4958.SizeQty02) = "" Then x4958.SizeQty02 = 0
            If trim$(x4958.SizeQty03) = "" Then x4958.SizeQty03 = 0
            If trim$(x4958.SizeQty04) = "" Then x4958.SizeQty04 = 0
            If trim$(x4958.SizeQty05) = "" Then x4958.SizeQty05 = 0
            If trim$(x4958.SizeQty06) = "" Then x4958.SizeQty06 = 0
            If trim$(x4958.SizeQty07) = "" Then x4958.SizeQty07 = 0
            If trim$(x4958.SizeQty08) = "" Then x4958.SizeQty08 = 0
            If trim$(x4958.SizeQty09) = "" Then x4958.SizeQty09 = 0
            If trim$(x4958.SizeQty10) = "" Then x4958.SizeQty10 = 0
            If trim$(x4958.SizeQty11) = "" Then x4958.SizeQty11 = 0
            If trim$(x4958.SizeQty12) = "" Then x4958.SizeQty12 = 0
            If trim$(x4958.SizeQty13) = "" Then x4958.SizeQty13 = 0
            If trim$(x4958.SizeQty14) = "" Then x4958.SizeQty14 = 0
            If trim$(x4958.SizeQty15) = "" Then x4958.SizeQty15 = 0
            If trim$(x4958.SizeQty16) = "" Then x4958.SizeQty16 = 0
            If trim$(x4958.SizeQty17) = "" Then x4958.SizeQty17 = 0
            If trim$(x4958.SizeQty18) = "" Then x4958.SizeQty18 = 0
            If trim$(x4958.SizeQty19) = "" Then x4958.SizeQty19 = 0
            If trim$(x4958.SizeQty20) = "" Then x4958.SizeQty20 = 0
            If trim$(x4958.SizeQty21) = "" Then x4958.SizeQty21 = 0
            If trim$(x4958.SizeQty22) = "" Then x4958.SizeQty22 = 0
            If trim$(x4958.SizeQty23) = "" Then x4958.SizeQty23 = 0
            If trim$(x4958.SizeQty24) = "" Then x4958.SizeQty24 = 0
            If trim$(x4958.SizeQty25) = "" Then x4958.SizeQty25 = 0
            If trim$(x4958.SizeQty26) = "" Then x4958.SizeQty26 = 0
            If trim$(x4958.SizeQty27) = "" Then x4958.SizeQty27 = 0
            If trim$(x4958.SizeQty28) = "" Then x4958.SizeQty28 = 0
            If trim$(x4958.SizeQty29) = "" Then x4958.SizeQty29 = 0
            If trim$(x4958.SizeQty30) = "" Then x4958.SizeQty30 = 0
            If trim$(x4958.PackingCMB) = "" Then x4958.PackingCMB = 0
            If trim$(x4958.PackingGW) = "" Then x4958.PackingGW = 0
            If trim$(x4958.PackingNW) = "" Then x4958.PackingNW = 0
            If trim$(x4958.QtyPacking) = "" Then x4958.QtyPacking = 0
            If trim$(x4958.QtyLoading) = "" Then x4958.QtyLoading = 0

            If trim$(x4958.JCPREFIX1) = "" Then x4958.JCPREFIX1 = Space(1)
            If trim$(x4958.JCPREFIX2) = "" Then x4958.JCPREFIX2 = Space(1)
            If trim$(x4958.JOBCARDNO) = "" Then x4958.JOBCARDNO = Space(1)
            If trim$(x4958.ColorCode) = "" Then x4958.ColorCode = Space(1)
            If trim$(x4958.MCODENAME) = "" Then x4958.MCODENAME = Space(1)
            If trim$(x4958.PONO) = "" Then x4958.PONO = Space(1)
            If trim$(x4958.PKONO) = "" Then x4958.PKONO = Space(1)
            If trim$(x4958.SlNoD) = "" Then x4958.SlNoD = Space(1)
            If trim$(x4958.SlNo) = "" Then x4958.SlNo = Space(1)
            If trim$(x4958.Article) = "" Then x4958.Article = Space(1)
            If trim$(x4958.SizeRangeName) = "" Then x4958.SizeRangeName = Space(1)
            If trim$(x4958.seSeason) = "" Then x4958.seSeason = Space(1)
            If trim$(x4958.cdSeason) = "" Then x4958.cdSeason = Space(1)
            If trim$(x4958.DateInsert) = "" Then x4958.DateInsert = Space(1)
            If trim$(x4958.DateUpdate) = "" Then x4958.DateUpdate = Space(1)
            If trim$(x4958.InchargeInsert) = "" Then x4958.InchargeInsert = Space(1)
            If trim$(x4958.InchargeUpdate) = "" Then x4958.InchargeUpdate = Space(1)
            If trim$(x4958.CheckUse) = "" Then x4958.CheckUse = Space(1)
            If trim$(x4958.CheckComplete) = "" Then x4958.CheckComplete = Space(1)
            If trim$(x4958.Printed) = "" Then x4958.Printed = Space(1)
            If trim$(x4958.Remark) = "" Then x4958.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K4958_MOVE(rs4958 As SqlClient.SqlDataReader)
        Try

            Call D4958_CLEAR()

            If IsdbNull(rs4958!K4958_Autokey) = False Then D4958.Autokey = Trim$(rs4958!K4958_Autokey)
            If IsdbNull(rs4958!K4958_AutoKey_K3422) = False Then D4958.AutoKey_K3422 = Trim$(rs4958!K4958_AutoKey_K3422)

            If IsdbNull(rs4958!K4958_ProductInBoundNo) = False Then D4958.ProductInBoundNo = Trim$(rs4958!K4958_ProductInBoundNo)
            If IsdbNull(rs4958!K4958_ProductInBoundSeq) = False Then D4958.ProductInBoundSeq = Trim$(rs4958!K4958_ProductInBoundSeq)
            If IsdbNull(rs4958!K4958_PackingBatch) = False Then D4958.PackingBatch = Trim$(rs4958!K4958_PackingBatch)
            If IsdbNull(rs4958!K4958_PackingCusBatch) = False Then D4958.PackingCusBatch = Trim$(rs4958!K4958_PackingCusBatch)
            If IsdbNull(rs4958!K4958_sePackingType) = False Then D4958.sePackingType = Trim$(rs4958!K4958_sePackingType)
            If IsdbNull(rs4958!K4958_cdPackingType) = False Then D4958.cdPackingType = Trim$(rs4958!K4958_cdPackingType)
            If IsdbNull(rs4958!K4958_PackingTypeName) = False Then D4958.PackingTypeName = Trim$(rs4958!K4958_PackingTypeName)
            If IsdbNull(rs4958!K4958_DatePacking) = False Then D4958.DatePacking = Trim$(rs4958!K4958_DatePacking)
            If IsdbNull(rs4958!K4958_CustomerCode) = False Then D4958.CustomerCode = Trim$(rs4958!K4958_CustomerCode)
            If IsdbNull(rs4958!K4958_CartonCode) = False Then D4958.CartonCode = Trim$(rs4958!K4958_CartonCode)
            If IsdbNull(rs4958!K4958_CartonNo) = False Then D4958.CartonNo = Trim$(rs4958!K4958_CartonNo)
            If IsdbNull(rs4958!K4958_LoadingNo) = False Then D4958.LoadingNo = Trim$(rs4958!K4958_LoadingNo)
            If IsdbNull(rs4958!K4958_LoadingCode) = False Then D4958.LoadingCode = Trim$(rs4958!K4958_LoadingCode)
            If IsdbNull(rs4958!K4958_LoadingSeq) = False Then D4958.LoadingSeq = Trim$(rs4958!K4958_LoadingSeq)
            If IsdbNull(rs4958!K4958_OrderNo) = False Then D4958.OrderNo = Trim$(rs4958!K4958_OrderNo)
            If IsdbNull(rs4958!K4958_OrderNoSeq) = False Then D4958.OrderNoSeq = Trim$(rs4958!K4958_OrderNoSeq)
            If IsdbNull(rs4958!K4958_FactOrderNo) = False Then D4958.FactOrderNo = Trim$(rs4958!K4958_FactOrderNo)
            If IsdbNull(rs4958!K4958_FactOrderSeq) = False Then D4958.FactOrderSeq = Trim$(rs4958!K4958_FactOrderSeq)
            If IsdbNull(rs4958!K4958_JobCard) = False Then D4958.JobCard = Trim$(rs4958!K4958_JobCard)
            If IsdbNull(rs4958!K4958_SizeGroup) = False Then D4958.SizeGroup = Trim$(rs4958!K4958_SizeGroup)
            If IsdbNull(rs4958!K4958_QtyPrs) = False Then D4958.QtyPrs = Trim$(rs4958!K4958_QtyPrs)
            If IsdbNull(rs4958!K4958_SizeQty01) = False Then D4958.SizeQty01 = Trim$(rs4958!K4958_SizeQty01)
            If IsdbNull(rs4958!K4958_SizeQty02) = False Then D4958.SizeQty02 = Trim$(rs4958!K4958_SizeQty02)
            If IsdbNull(rs4958!K4958_SizeQty03) = False Then D4958.SizeQty03 = Trim$(rs4958!K4958_SizeQty03)
            If IsdbNull(rs4958!K4958_SizeQty04) = False Then D4958.SizeQty04 = Trim$(rs4958!K4958_SizeQty04)
            If IsdbNull(rs4958!K4958_SizeQty05) = False Then D4958.SizeQty05 = Trim$(rs4958!K4958_SizeQty05)
            If IsdbNull(rs4958!K4958_SizeQty06) = False Then D4958.SizeQty06 = Trim$(rs4958!K4958_SizeQty06)
            If IsdbNull(rs4958!K4958_SizeQty07) = False Then D4958.SizeQty07 = Trim$(rs4958!K4958_SizeQty07)
            If IsdbNull(rs4958!K4958_SizeQty08) = False Then D4958.SizeQty08 = Trim$(rs4958!K4958_SizeQty08)
            If IsdbNull(rs4958!K4958_SizeQty09) = False Then D4958.SizeQty09 = Trim$(rs4958!K4958_SizeQty09)
            If IsdbNull(rs4958!K4958_SizeQty10) = False Then D4958.SizeQty10 = Trim$(rs4958!K4958_SizeQty10)
            If IsdbNull(rs4958!K4958_SizeQty11) = False Then D4958.SizeQty11 = Trim$(rs4958!K4958_SizeQty11)
            If IsdbNull(rs4958!K4958_SizeQty12) = False Then D4958.SizeQty12 = Trim$(rs4958!K4958_SizeQty12)
            If IsdbNull(rs4958!K4958_SizeQty13) = False Then D4958.SizeQty13 = Trim$(rs4958!K4958_SizeQty13)
            If IsdbNull(rs4958!K4958_SizeQty14) = False Then D4958.SizeQty14 = Trim$(rs4958!K4958_SizeQty14)
            If IsdbNull(rs4958!K4958_SizeQty15) = False Then D4958.SizeQty15 = Trim$(rs4958!K4958_SizeQty15)
            If IsdbNull(rs4958!K4958_SizeQty16) = False Then D4958.SizeQty16 = Trim$(rs4958!K4958_SizeQty16)
            If IsdbNull(rs4958!K4958_SizeQty17) = False Then D4958.SizeQty17 = Trim$(rs4958!K4958_SizeQty17)
            If IsdbNull(rs4958!K4958_SizeQty18) = False Then D4958.SizeQty18 = Trim$(rs4958!K4958_SizeQty18)
            If IsdbNull(rs4958!K4958_SizeQty19) = False Then D4958.SizeQty19 = Trim$(rs4958!K4958_SizeQty19)
            If IsdbNull(rs4958!K4958_SizeQty20) = False Then D4958.SizeQty20 = Trim$(rs4958!K4958_SizeQty20)
            If IsdbNull(rs4958!K4958_SizeQty21) = False Then D4958.SizeQty21 = Trim$(rs4958!K4958_SizeQty21)
            If IsdbNull(rs4958!K4958_SizeQty22) = False Then D4958.SizeQty22 = Trim$(rs4958!K4958_SizeQty22)
            If IsdbNull(rs4958!K4958_SizeQty23) = False Then D4958.SizeQty23 = Trim$(rs4958!K4958_SizeQty23)
            If IsdbNull(rs4958!K4958_SizeQty24) = False Then D4958.SizeQty24 = Trim$(rs4958!K4958_SizeQty24)
            If IsdbNull(rs4958!K4958_SizeQty25) = False Then D4958.SizeQty25 = Trim$(rs4958!K4958_SizeQty25)
            If IsdbNull(rs4958!K4958_SizeQty26) = False Then D4958.SizeQty26 = Trim$(rs4958!K4958_SizeQty26)
            If IsdbNull(rs4958!K4958_SizeQty27) = False Then D4958.SizeQty27 = Trim$(rs4958!K4958_SizeQty27)
            If IsdbNull(rs4958!K4958_SizeQty28) = False Then D4958.SizeQty28 = Trim$(rs4958!K4958_SizeQty28)
            If IsdbNull(rs4958!K4958_SizeQty29) = False Then D4958.SizeQty29 = Trim$(rs4958!K4958_SizeQty29)
            If IsdbNull(rs4958!K4958_SizeQty30) = False Then D4958.SizeQty30 = Trim$(rs4958!K4958_SizeQty30)
            If IsdbNull(rs4958!K4958_PackingCMB) = False Then D4958.PackingCMB = Trim$(rs4958!K4958_PackingCMB)
            If IsdbNull(rs4958!K4958_PackingGW) = False Then D4958.PackingGW = Trim$(rs4958!K4958_PackingGW)
            If IsdbNull(rs4958!K4958_PackingNW) = False Then D4958.PackingNW = Trim$(rs4958!K4958_PackingNW)
            If IsdbNull(rs4958!K4958_QtyPacking) = False Then D4958.QtyPacking = Trim$(rs4958!K4958_QtyPacking)
            If IsdbNull(rs4958!K4958_QtyLoading) = False Then D4958.QtyLoading = Trim$(rs4958!K4958_QtyLoading)

            If IsdbNull(rs4958!K4958_JCPREFIX1) = False Then D4958.JCPREFIX1 = Trim$(rs4958!K4958_JCPREFIX1)
            If IsdbNull(rs4958!K4958_JCPREFIX2) = False Then D4958.JCPREFIX2 = Trim$(rs4958!K4958_JCPREFIX2)
            If IsdbNull(rs4958!K4958_JOBCARDNO) = False Then D4958.JOBCARDNO = Trim$(rs4958!K4958_JOBCARDNO)
            If IsdbNull(rs4958!K4958_ColorCode) = False Then D4958.ColorCode = Trim$(rs4958!K4958_ColorCode)
            If IsdbNull(rs4958!K4958_MCODENAME) = False Then D4958.MCODENAME = Trim$(rs4958!K4958_MCODENAME)
            If IsdbNull(rs4958!K4958_PONO) = False Then D4958.PONO = Trim$(rs4958!K4958_PONO)
            If IsdbNull(rs4958!K4958_PKONO) = False Then D4958.PKONO = Trim$(rs4958!K4958_PKONO)
            If IsdbNull(rs4958!K4958_SlNoD) = False Then D4958.SlNoD = Trim$(rs4958!K4958_SlNoD)
            If IsdbNull(rs4958!K4958_SlNo) = False Then D4958.SlNo = Trim$(rs4958!K4958_SlNo)
            If IsdbNull(rs4958!K4958_Article) = False Then D4958.Article = Trim$(rs4958!K4958_Article)
            If IsdbNull(rs4958!K4958_SizeRangeName) = False Then D4958.SizeRangeName = Trim$(rs4958!K4958_SizeRangeName)
            If IsdbNull(rs4958!K4958_seSeason) = False Then D4958.seSeason = Trim$(rs4958!K4958_seSeason)
            If IsdbNull(rs4958!K4958_cdSeason) = False Then D4958.cdSeason = Trim$(rs4958!K4958_cdSeason)
            If IsdbNull(rs4958!K4958_DateInsert) = False Then D4958.DateInsert = Trim$(rs4958!K4958_DateInsert)
            If IsdbNull(rs4958!K4958_DateUpdate) = False Then D4958.DateUpdate = Trim$(rs4958!K4958_DateUpdate)
            If IsdbNull(rs4958!K4958_InchargeInsert) = False Then D4958.InchargeInsert = Trim$(rs4958!K4958_InchargeInsert)
            If IsdbNull(rs4958!K4958_InchargeUpdate) = False Then D4958.InchargeUpdate = Trim$(rs4958!K4958_InchargeUpdate)
            If IsdbNull(rs4958!K4958_CheckUse) = False Then D4958.CheckUse = Trim$(rs4958!K4958_CheckUse)
            If IsdbNull(rs4958!K4958_CheckComplete) = False Then D4958.CheckComplete = Trim$(rs4958!K4958_CheckComplete)
            If IsdbNull(rs4958!K4958_Printed) = False Then D4958.Printed = Trim$(rs4958!K4958_Printed)
            If IsdbNull(rs4958!K4958_Remark) = False Then D4958.Remark = Trim$(rs4958!K4958_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K4958_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K4958_MOVE(rs4958 As DataRow)
        Try

            Call D4958_CLEAR()

            If IsdbNull(rs4958!K4958_Autokey) = False Then D4958.Autokey = Trim$(rs4958!K4958_Autokey)
            If IsdbNull(rs4958!K4958_AutoKey_K3422) = False Then D4958.AutoKey_K3422 = Trim$(rs4958!K4958_AutoKey_K3422)
            If IsdbNull(rs4958!K4958_ProductInBoundNo) = False Then D4958.ProductInBoundNo = Trim$(rs4958!K4958_ProductInBoundNo)
            If IsdbNull(rs4958!K4958_ProductInBoundSeq) = False Then D4958.ProductInBoundSeq = Trim$(rs4958!K4958_ProductInBoundSeq)
            If IsdbNull(rs4958!K4958_PackingBatch) = False Then D4958.PackingBatch = Trim$(rs4958!K4958_PackingBatch)
            If IsdbNull(rs4958!K4958_PackingCusBatch) = False Then D4958.PackingCusBatch = Trim$(rs4958!K4958_PackingCusBatch)
            If IsdbNull(rs4958!K4958_sePackingType) = False Then D4958.sePackingType = Trim$(rs4958!K4958_sePackingType)
            If IsdbNull(rs4958!K4958_cdPackingType) = False Then D4958.cdPackingType = Trim$(rs4958!K4958_cdPackingType)
            If IsdbNull(rs4958!K4958_PackingTypeName) = False Then D4958.PackingTypeName = Trim$(rs4958!K4958_PackingTypeName)
            If IsdbNull(rs4958!K4958_DatePacking) = False Then D4958.DatePacking = Trim$(rs4958!K4958_DatePacking)
            If IsdbNull(rs4958!K4958_CustomerCode) = False Then D4958.CustomerCode = Trim$(rs4958!K4958_CustomerCode)
            If IsdbNull(rs4958!K4958_CartonCode) = False Then D4958.CartonCode = Trim$(rs4958!K4958_CartonCode)
            If IsdbNull(rs4958!K4958_CartonNo) = False Then D4958.CartonNo = Trim$(rs4958!K4958_CartonNo)
            If IsdbNull(rs4958!K4958_LoadingNo) = False Then D4958.LoadingNo = Trim$(rs4958!K4958_LoadingNo)
            If IsdbNull(rs4958!K4958_LoadingCode) = False Then D4958.LoadingCode = Trim$(rs4958!K4958_LoadingCode)
            If IsdbNull(rs4958!K4958_LoadingSeq) = False Then D4958.LoadingSeq = Trim$(rs4958!K4958_LoadingSeq)
            If IsdbNull(rs4958!K4958_OrderNo) = False Then D4958.OrderNo = Trim$(rs4958!K4958_OrderNo)
            If IsdbNull(rs4958!K4958_OrderNoSeq) = False Then D4958.OrderNoSeq = Trim$(rs4958!K4958_OrderNoSeq)
            If IsdbNull(rs4958!K4958_FactOrderNo) = False Then D4958.FactOrderNo = Trim$(rs4958!K4958_FactOrderNo)
            If IsdbNull(rs4958!K4958_FactOrderSeq) = False Then D4958.FactOrderSeq = Trim$(rs4958!K4958_FactOrderSeq)
            If IsdbNull(rs4958!K4958_JobCard) = False Then D4958.JobCard = Trim$(rs4958!K4958_JobCard)
            If IsdbNull(rs4958!K4958_SizeGroup) = False Then D4958.SizeGroup = Trim$(rs4958!K4958_SizeGroup)
            If IsdbNull(rs4958!K4958_QtyPrs) = False Then D4958.QtyPrs = Trim$(rs4958!K4958_QtyPrs)
            If IsdbNull(rs4958!K4958_SizeQty01) = False Then D4958.SizeQty01 = Trim$(rs4958!K4958_SizeQty01)
            If IsdbNull(rs4958!K4958_SizeQty02) = False Then D4958.SizeQty02 = Trim$(rs4958!K4958_SizeQty02)
            If IsdbNull(rs4958!K4958_SizeQty03) = False Then D4958.SizeQty03 = Trim$(rs4958!K4958_SizeQty03)
            If IsdbNull(rs4958!K4958_SizeQty04) = False Then D4958.SizeQty04 = Trim$(rs4958!K4958_SizeQty04)
            If IsdbNull(rs4958!K4958_SizeQty05) = False Then D4958.SizeQty05 = Trim$(rs4958!K4958_SizeQty05)
            If IsdbNull(rs4958!K4958_SizeQty06) = False Then D4958.SizeQty06 = Trim$(rs4958!K4958_SizeQty06)
            If IsdbNull(rs4958!K4958_SizeQty07) = False Then D4958.SizeQty07 = Trim$(rs4958!K4958_SizeQty07)
            If IsdbNull(rs4958!K4958_SizeQty08) = False Then D4958.SizeQty08 = Trim$(rs4958!K4958_SizeQty08)
            If IsdbNull(rs4958!K4958_SizeQty09) = False Then D4958.SizeQty09 = Trim$(rs4958!K4958_SizeQty09)
            If IsdbNull(rs4958!K4958_SizeQty10) = False Then D4958.SizeQty10 = Trim$(rs4958!K4958_SizeQty10)
            If IsdbNull(rs4958!K4958_SizeQty11) = False Then D4958.SizeQty11 = Trim$(rs4958!K4958_SizeQty11)
            If IsdbNull(rs4958!K4958_SizeQty12) = False Then D4958.SizeQty12 = Trim$(rs4958!K4958_SizeQty12)
            If IsdbNull(rs4958!K4958_SizeQty13) = False Then D4958.SizeQty13 = Trim$(rs4958!K4958_SizeQty13)
            If IsdbNull(rs4958!K4958_SizeQty14) = False Then D4958.SizeQty14 = Trim$(rs4958!K4958_SizeQty14)
            If IsdbNull(rs4958!K4958_SizeQty15) = False Then D4958.SizeQty15 = Trim$(rs4958!K4958_SizeQty15)
            If IsdbNull(rs4958!K4958_SizeQty16) = False Then D4958.SizeQty16 = Trim$(rs4958!K4958_SizeQty16)
            If IsdbNull(rs4958!K4958_SizeQty17) = False Then D4958.SizeQty17 = Trim$(rs4958!K4958_SizeQty17)
            If IsdbNull(rs4958!K4958_SizeQty18) = False Then D4958.SizeQty18 = Trim$(rs4958!K4958_SizeQty18)
            If IsdbNull(rs4958!K4958_SizeQty19) = False Then D4958.SizeQty19 = Trim$(rs4958!K4958_SizeQty19)
            If IsdbNull(rs4958!K4958_SizeQty20) = False Then D4958.SizeQty20 = Trim$(rs4958!K4958_SizeQty20)
            If IsdbNull(rs4958!K4958_SizeQty21) = False Then D4958.SizeQty21 = Trim$(rs4958!K4958_SizeQty21)
            If IsdbNull(rs4958!K4958_SizeQty22) = False Then D4958.SizeQty22 = Trim$(rs4958!K4958_SizeQty22)
            If IsdbNull(rs4958!K4958_SizeQty23) = False Then D4958.SizeQty23 = Trim$(rs4958!K4958_SizeQty23)
            If IsdbNull(rs4958!K4958_SizeQty24) = False Then D4958.SizeQty24 = Trim$(rs4958!K4958_SizeQty24)
            If IsdbNull(rs4958!K4958_SizeQty25) = False Then D4958.SizeQty25 = Trim$(rs4958!K4958_SizeQty25)
            If IsdbNull(rs4958!K4958_SizeQty26) = False Then D4958.SizeQty26 = Trim$(rs4958!K4958_SizeQty26)
            If IsdbNull(rs4958!K4958_SizeQty27) = False Then D4958.SizeQty27 = Trim$(rs4958!K4958_SizeQty27)
            If IsdbNull(rs4958!K4958_SizeQty28) = False Then D4958.SizeQty28 = Trim$(rs4958!K4958_SizeQty28)
            If IsdbNull(rs4958!K4958_SizeQty29) = False Then D4958.SizeQty29 = Trim$(rs4958!K4958_SizeQty29)
            If IsdbNull(rs4958!K4958_SizeQty30) = False Then D4958.SizeQty30 = Trim$(rs4958!K4958_SizeQty30)
            If IsdbNull(rs4958!K4958_PackingCMB) = False Then D4958.PackingCMB = Trim$(rs4958!K4958_PackingCMB)
            If IsdbNull(rs4958!K4958_PackingGW) = False Then D4958.PackingGW = Trim$(rs4958!K4958_PackingGW)
            If IsdbNull(rs4958!K4958_PackingNW) = False Then D4958.PackingNW = Trim$(rs4958!K4958_PackingNW)
            If IsdbNull(rs4958!K4958_QtyPacking) = False Then D4958.QtyPacking = Trim$(rs4958!K4958_QtyPacking)
            If IsdbNull(rs4958!K4958_QtyLoading) = False Then D4958.QtyLoading = Trim$(rs4958!K4958_QtyLoading)

            If IsdbNull(rs4958!K4958_JCPREFIX1) = False Then D4958.JCPREFIX1 = Trim$(rs4958!K4958_JCPREFIX1)
            If IsdbNull(rs4958!K4958_JCPREFIX2) = False Then D4958.JCPREFIX2 = Trim$(rs4958!K4958_JCPREFIX2)
            If IsdbNull(rs4958!K4958_JOBCARDNO) = False Then D4958.JOBCARDNO = Trim$(rs4958!K4958_JOBCARDNO)
            If IsdbNull(rs4958!K4958_ColorCode) = False Then D4958.ColorCode = Trim$(rs4958!K4958_ColorCode)
            If IsdbNull(rs4958!K4958_MCODENAME) = False Then D4958.MCODENAME = Trim$(rs4958!K4958_MCODENAME)
            If IsdbNull(rs4958!K4958_PONO) = False Then D4958.PONO = Trim$(rs4958!K4958_PONO)
            If IsdbNull(rs4958!K4958_PKONO) = False Then D4958.PKONO = Trim$(rs4958!K4958_PKONO)
            If IsdbNull(rs4958!K4958_SlNoD) = False Then D4958.SlNoD = Trim$(rs4958!K4958_SlNoD)
            If IsdbNull(rs4958!K4958_SlNo) = False Then D4958.SlNo = Trim$(rs4958!K4958_SlNo)
            If IsdbNull(rs4958!K4958_Article) = False Then D4958.Article = Trim$(rs4958!K4958_Article)
            If IsdbNull(rs4958!K4958_SizeRangeName) = False Then D4958.SizeRangeName = Trim$(rs4958!K4958_SizeRangeName)
            If IsdbNull(rs4958!K4958_seSeason) = False Then D4958.seSeason = Trim$(rs4958!K4958_seSeason)
            If IsdbNull(rs4958!K4958_cdSeason) = False Then D4958.cdSeason = Trim$(rs4958!K4958_cdSeason)
            If IsdbNull(rs4958!K4958_DateInsert) = False Then D4958.DateInsert = Trim$(rs4958!K4958_DateInsert)
            If IsdbNull(rs4958!K4958_DateUpdate) = False Then D4958.DateUpdate = Trim$(rs4958!K4958_DateUpdate)
            If IsdbNull(rs4958!K4958_InchargeInsert) = False Then D4958.InchargeInsert = Trim$(rs4958!K4958_InchargeInsert)
            If IsdbNull(rs4958!K4958_InchargeUpdate) = False Then D4958.InchargeUpdate = Trim$(rs4958!K4958_InchargeUpdate)
            If IsdbNull(rs4958!K4958_CheckUse) = False Then D4958.CheckUse = Trim$(rs4958!K4958_CheckUse)
            If IsdbNull(rs4958!K4958_CheckComplete) = False Then D4958.CheckComplete = Trim$(rs4958!K4958_CheckComplete)
            If IsdbNull(rs4958!K4958_Printed) = False Then D4958.Printed = Trim$(rs4958!K4958_Printed)
            If IsdbNull(rs4958!K4958_Remark) = False Then D4958.Remark = Trim$(rs4958!K4958_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K4958_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K4958_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z4958 As T4958_AREA, AUTOKEY As Double) As Boolean

        K4958_MOVE = False

        Try
            If READ_PFK4958(AUTOKEY) = True Then
                z4958 = D4958
                K4958_MOVE = True
            Else
                z4958 = Nothing
            End If

            If getColumnIndex(spr, "Autokey") > -1 Then z4958.Autokey = getDataM(spr, getColumnIndex(spr, "Autokey"), xRow)
            If getColumnIndex(spr, "AutoKey_K3422") > -1 Then z4958.AutoKey_K3422 = getDataM(spr, getColumnIndex(spr, "AutoKey_K3422"), xRow)
            If getColumnIndex(spr, "ProductInBoundNo") > -1 Then z4958.ProductInBoundNo = getDataM(spr, getColumnIndex(spr, "ProductInBoundNo"), xRow)
            If getColumnIndex(spr, "ProductInBoundSeq") > -1 Then z4958.ProductInBoundSeq = getDataM(spr, getColumnIndex(spr, "ProductInBoundSeq"), xRow)
            If getColumnIndex(spr, "PackingBatch") > -1 Then z4958.PackingBatch = getDataM(spr, getColumnIndex(spr, "PackingBatch"), xRow)
            If getColumnIndex(spr, "PackingCusBatch") > -1 Then z4958.PackingCusBatch = getDataM(spr, getColumnIndex(spr, "PackingCusBatch"), xRow)
            If getColumnIndex(spr, "sePackingType") > -1 Then z4958.sePackingType = getDataM(spr, getColumnIndex(spr, "sePackingType"), xRow)
            If getColumnIndex(spr, "cdPackingType") > -1 Then z4958.cdPackingType = getDataM(spr, getColumnIndex(spr, "cdPackingType"), xRow)
            If getColumnIndex(spr, "PackingTypeName") > -1 Then z4958.PackingTypeName = getDataM(spr, getColumnIndex(spr, "PackingTypeName"), xRow)
            If getColumnIndex(spr, "DatePacking") > -1 Then z4958.DatePacking = getDataM(spr, getColumnIndex(spr, "DatePacking"), xRow)
            If getColumnIndex(spr, "CustomerCode") > -1 Then z4958.CustomerCode = getDataM(spr, getColumnIndex(spr, "CustomerCode"), xRow)
            If getColumnIndex(spr, "CartonCode") > -1 Then z4958.CartonCode = getDataM(spr, getColumnIndex(spr, "CartonCode"), xRow)
            If getColumnIndex(spr, "CartonNo") > -1 Then z4958.CartonNo = getDataM(spr, getColumnIndex(spr, "CartonNo"), xRow)
            If getColumnIndex(spr, "LoadingNo") > -1 Then z4958.LoadingNo = getDataM(spr, getColumnIndex(spr, "LoadingNo"), xRow)
            If getColumnIndex(spr, "LoadingCode") > -1 Then z4958.LoadingCode = getDataM(spr, getColumnIndex(spr, "LoadingCode"), xRow)
            If getColumnIndex(spr, "LoadingSeq") > -1 Then z4958.LoadingSeq = getDataM(spr, getColumnIndex(spr, "LoadingSeq"), xRow)
            If getColumnIndex(spr, "OrderNo") > -1 Then z4958.OrderNo = getDataM(spr, getColumnIndex(spr, "OrderNo"), xRow)
            If getColumnIndex(spr, "OrderNoSeq") > -1 Then z4958.OrderNoSeq = getDataM(spr, getColumnIndex(spr, "OrderNoSeq"), xRow)
            If getColumnIndex(spr, "FactOrderNo") > -1 Then z4958.FactOrderNo = getDataM(spr, getColumnIndex(spr, "FactOrderNo"), xRow)
            If getColumnIndex(spr, "FactOrderSeq") > -1 Then z4958.FactOrderSeq = getDataM(spr, getColumnIndex(spr, "FactOrderSeq"), xRow)
            If getColumnIndex(spr, "JobCard") > -1 Then z4958.JobCard = getDataM(spr, getColumnIndex(spr, "JobCard"), xRow)
            If getColumnIndex(spr, "SizeGroup") > -1 Then z4958.SizeGroup = getDataM(spr, getColumnIndex(spr, "SizeGroup"), xRow)
            If getColumnIndex(spr, "QtyPrs") > -1 Then z4958.QtyPrs = getDataM(spr, getColumnIndex(spr, "QtyPrs"), xRow)
            If getColumnIndex(spr, "SizeQty01") > -1 Then z4958.SizeQty01 = getDataM(spr, getColumnIndex(spr, "SizeQty01"), xRow)
            If getColumnIndex(spr, "SizeQty02") > -1 Then z4958.SizeQty02 = getDataM(spr, getColumnIndex(spr, "SizeQty02"), xRow)
            If getColumnIndex(spr, "SizeQty03") > -1 Then z4958.SizeQty03 = getDataM(spr, getColumnIndex(spr, "SizeQty03"), xRow)
            If getColumnIndex(spr, "SizeQty04") > -1 Then z4958.SizeQty04 = getDataM(spr, getColumnIndex(spr, "SizeQty04"), xRow)
            If getColumnIndex(spr, "SizeQty05") > -1 Then z4958.SizeQty05 = getDataM(spr, getColumnIndex(spr, "SizeQty05"), xRow)
            If getColumnIndex(spr, "SizeQty06") > -1 Then z4958.SizeQty06 = getDataM(spr, getColumnIndex(spr, "SizeQty06"), xRow)
            If getColumnIndex(spr, "SizeQty07") > -1 Then z4958.SizeQty07 = getDataM(spr, getColumnIndex(spr, "SizeQty07"), xRow)
            If getColumnIndex(spr, "SizeQty08") > -1 Then z4958.SizeQty08 = getDataM(spr, getColumnIndex(spr, "SizeQty08"), xRow)
            If getColumnIndex(spr, "SizeQty09") > -1 Then z4958.SizeQty09 = getDataM(spr, getColumnIndex(spr, "SizeQty09"), xRow)
            If getColumnIndex(spr, "SizeQty10") > -1 Then z4958.SizeQty10 = getDataM(spr, getColumnIndex(spr, "SizeQty10"), xRow)
            If getColumnIndex(spr, "SizeQty11") > -1 Then z4958.SizeQty11 = getDataM(spr, getColumnIndex(spr, "SizeQty11"), xRow)
            If getColumnIndex(spr, "SizeQty12") > -1 Then z4958.SizeQty12 = getDataM(spr, getColumnIndex(spr, "SizeQty12"), xRow)
            If getColumnIndex(spr, "SizeQty13") > -1 Then z4958.SizeQty13 = getDataM(spr, getColumnIndex(spr, "SizeQty13"), xRow)
            If getColumnIndex(spr, "SizeQty14") > -1 Then z4958.SizeQty14 = getDataM(spr, getColumnIndex(spr, "SizeQty14"), xRow)
            If getColumnIndex(spr, "SizeQty15") > -1 Then z4958.SizeQty15 = getDataM(spr, getColumnIndex(spr, "SizeQty15"), xRow)
            If getColumnIndex(spr, "SizeQty16") > -1 Then z4958.SizeQty16 = getDataM(spr, getColumnIndex(spr, "SizeQty16"), xRow)
            If getColumnIndex(spr, "SizeQty17") > -1 Then z4958.SizeQty17 = getDataM(spr, getColumnIndex(spr, "SizeQty17"), xRow)
            If getColumnIndex(spr, "SizeQty18") > -1 Then z4958.SizeQty18 = getDataM(spr, getColumnIndex(spr, "SizeQty18"), xRow)
            If getColumnIndex(spr, "SizeQty19") > -1 Then z4958.SizeQty19 = getDataM(spr, getColumnIndex(spr, "SizeQty19"), xRow)
            If getColumnIndex(spr, "SizeQty20") > -1 Then z4958.SizeQty20 = getDataM(spr, getColumnIndex(spr, "SizeQty20"), xRow)
            If getColumnIndex(spr, "SizeQty21") > -1 Then z4958.SizeQty21 = getDataM(spr, getColumnIndex(spr, "SizeQty21"), xRow)
            If getColumnIndex(spr, "SizeQty22") > -1 Then z4958.SizeQty22 = getDataM(spr, getColumnIndex(spr, "SizeQty22"), xRow)
            If getColumnIndex(spr, "SizeQty23") > -1 Then z4958.SizeQty23 = getDataM(spr, getColumnIndex(spr, "SizeQty23"), xRow)
            If getColumnIndex(spr, "SizeQty24") > -1 Then z4958.SizeQty24 = getDataM(spr, getColumnIndex(spr, "SizeQty24"), xRow)
            If getColumnIndex(spr, "SizeQty25") > -1 Then z4958.SizeQty25 = getDataM(spr, getColumnIndex(spr, "SizeQty25"), xRow)
            If getColumnIndex(spr, "SizeQty26") > -1 Then z4958.SizeQty26 = getDataM(spr, getColumnIndex(spr, "SizeQty26"), xRow)
            If getColumnIndex(spr, "SizeQty27") > -1 Then z4958.SizeQty27 = getDataM(spr, getColumnIndex(spr, "SizeQty27"), xRow)
            If getColumnIndex(spr, "SizeQty28") > -1 Then z4958.SizeQty28 = getDataM(spr, getColumnIndex(spr, "SizeQty28"), xRow)
            If getColumnIndex(spr, "SizeQty29") > -1 Then z4958.SizeQty29 = getDataM(spr, getColumnIndex(spr, "SizeQty29"), xRow)
            If getColumnIndex(spr, "SizeQty30") > -1 Then z4958.SizeQty30 = getDataM(spr, getColumnIndex(spr, "SizeQty30"), xRow)
            If getColumnIndex(spr, "PackingCMB") > -1 Then z4958.PackingCMB = getDataM(spr, getColumnIndex(spr, "PackingCMB"), xRow)
            If getColumnIndex(spr, "PackingGW") > -1 Then z4958.PackingGW = getDataM(spr, getColumnIndex(spr, "PackingGW"), xRow)
            If getColumnIndex(spr, "PackingNW") > -1 Then z4958.PackingNW = getDataM(spr, getColumnIndex(spr, "PackingNW"), xRow)
            If getColumnIndex(spr, "QtyPacking") > -1 Then z4958.QtyPacking = getDataM(spr, getColumnIndex(spr, "QtyPacking"), xRow)
            If getColumnIndex(spr, "QtyLoading") > -1 Then z4958.QtyLoading = getDataM(spr, getColumnIndex(spr, "QtyLoading"), xRow)

            If getColumnIndex(spr, "JCPREFIX1") > -1 Then z4958.JCPREFIX1 = getDataM(spr, getColumnIndex(spr, "JCPREFIX1"), xRow)
            If getColumnIndex(spr, "JCPREFIX2") > -1 Then z4958.JCPREFIX2 = getDataM(spr, getColumnIndex(spr, "JCPREFIX2"), xRow)
            If getColumnIndex(spr, "JOBCARDNO") > -1 Then z4958.JOBCARDNO = getDataM(spr, getColumnIndex(spr, "JOBCARDNO"), xRow)
            If getColumnIndex(spr, "ColorCode") > -1 Then z4958.ColorCode = getDataM(spr, getColumnIndex(spr, "ColorCode"), xRow)
            If getColumnIndex(spr, "MCODENAME") > -1 Then z4958.MCODENAME = getDataM(spr, getColumnIndex(spr, "MCODENAME"), xRow)
            If getColumnIndex(spr, "PONO") > -1 Then z4958.PONO = getDataM(spr, getColumnIndex(spr, "PONO"), xRow)
            If getColumnIndex(spr, "PKONO") > -1 Then z4958.PKONO = getDataM(spr, getColumnIndex(spr, "PKONO"), xRow)
            If getColumnIndex(spr, "SlNoD") > -1 Then z4958.SlNoD = getDataM(spr, getColumnIndex(spr, "SlNoD"), xRow)
            If getColumnIndex(spr, "SlNo") > -1 Then z4958.SlNo = getDataM(spr, getColumnIndex(spr, "SlNo"), xRow)
            If getColumnIndex(spr, "Article") > -1 Then z4958.Article = getDataM(spr, getColumnIndex(spr, "Article"), xRow)
            If getColumnIndex(spr, "SizeRangeName") > -1 Then z4958.SizeRangeName = getDataM(spr, getColumnIndex(spr, "SizeRangeName"), xRow)
            If getColumnIndex(spr, "seSeason") > -1 Then z4958.seSeason = getDataM(spr, getColumnIndex(spr, "seSeason"), xRow)
            If getColumnIndex(spr, "cdSeason") > -1 Then z4958.cdSeason = getDataM(spr, getColumnIndex(spr, "cdSeason"), xRow)
            If getColumnIndex(spr, "DateInsert") > -1 Then z4958.DateInsert = getDataM(spr, getColumnIndex(spr, "DateInsert"), xRow)
            If getColumnIndex(spr, "DateUpdate") > -1 Then z4958.DateUpdate = getDataM(spr, getColumnIndex(spr, "DateUpdate"), xRow)
            If getColumnIndex(spr, "InchargeInsert") > -1 Then z4958.InchargeInsert = getDataM(spr, getColumnIndex(spr, "InchargeInsert"), xRow)
            If getColumnIndex(spr, "InchargeUpdate") > -1 Then z4958.InchargeUpdate = getDataM(spr, getColumnIndex(spr, "InchargeUpdate"), xRow)
            If getColumnIndex(spr, "CheckUse") > -1 Then z4958.CheckUse = getDataM(spr, getColumnIndex(spr, "CheckUse"), xRow)
            If getColumnIndex(spr, "CheckComplete") > -1 Then z4958.CheckComplete = getDataM(spr, getColumnIndex(spr, "CheckComplete"), xRow)
            If getColumnIndex(spr, "Printed") > -1 Then z4958.Printed = getDataM(spr, getColumnIndex(spr, "Printed"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z4958.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4958_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K4958_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z4958 As T4958_AREA, CheckClear As Boolean, AUTOKEY As Double) As Boolean

        K4958_MOVE = False

        Try
            If READ_PFK4958(AUTOKEY) = True Then
                z4958 = D4958
                K4958_MOVE = True
            Else
                If CheckClear = True Then z4958 = Nothing
            End If

            If getColumnIndex(spr, "Autokey") > -1 Then z4958.Autokey = getDataM(spr, getColumnIndex(spr, "Autokey"), xRow)
            If getColumnIndex(spr, "AutoKey_K3422") > -1 Then z4958.AutoKey_K3422 = getDataM(spr, getColumnIndex(spr, "AutoKey_K3422"), xRow)
            If getColumnIndex(spr, "ProductInBoundNo") > -1 Then z4958.ProductInBoundNo = getDataM(spr, getColumnIndex(spr, "ProductInBoundNo"), xRow)
            If getColumnIndex(spr, "ProductInBoundSeq") > -1 Then z4958.ProductInBoundSeq = getDataM(spr, getColumnIndex(spr, "ProductInBoundSeq"), xRow)
            If getColumnIndex(spr, "PackingBatch") > -1 Then z4958.PackingBatch = getDataM(spr, getColumnIndex(spr, "PackingBatch"), xRow)
            If getColumnIndex(spr, "PackingCusBatch") > -1 Then z4958.PackingCusBatch = getDataM(spr, getColumnIndex(spr, "PackingCusBatch"), xRow)
            If getColumnIndex(spr, "sePackingType") > -1 Then z4958.sePackingType = getDataM(spr, getColumnIndex(spr, "sePackingType"), xRow)
            If getColumnIndex(spr, "cdPackingType") > -1 Then z4958.cdPackingType = getDataM(spr, getColumnIndex(spr, "cdPackingType"), xRow)
            If getColumnIndex(spr, "PackingTypeName") > -1 Then z4958.PackingTypeName = getDataM(spr, getColumnIndex(spr, "PackingTypeName"), xRow)
            If getColumnIndex(spr, "DatePacking") > -1 Then z4958.DatePacking = getDataM(spr, getColumnIndex(spr, "DatePacking"), xRow)
            If getColumnIndex(spr, "CustomerCode") > -1 Then z4958.CustomerCode = getDataM(spr, getColumnIndex(spr, "CustomerCode"), xRow)
            If getColumnIndex(spr, "CartonCode") > -1 Then z4958.CartonCode = getDataM(spr, getColumnIndex(spr, "CartonCode"), xRow)
            If getColumnIndex(spr, "CartonNo") > -1 Then z4958.CartonNo = getDataM(spr, getColumnIndex(spr, "CartonNo"), xRow)
            If getColumnIndex(spr, "LoadingNo") > -1 Then z4958.LoadingNo = getDataM(spr, getColumnIndex(spr, "LoadingNo"), xRow)
            If getColumnIndex(spr, "LoadingCode") > -1 Then z4958.LoadingCode = getDataM(spr, getColumnIndex(spr, "LoadingCode"), xRow)
            If getColumnIndex(spr, "LoadingSeq") > -1 Then z4958.LoadingSeq = getDataM(spr, getColumnIndex(spr, "LoadingSeq"), xRow)
            If getColumnIndex(spr, "OrderNo") > -1 Then z4958.OrderNo = getDataM(spr, getColumnIndex(spr, "OrderNo"), xRow)
            If getColumnIndex(spr, "OrderNoSeq") > -1 Then z4958.OrderNoSeq = getDataM(spr, getColumnIndex(spr, "OrderNoSeq"), xRow)
            If getColumnIndex(spr, "FactOrderNo") > -1 Then z4958.FactOrderNo = getDataM(spr, getColumnIndex(spr, "FactOrderNo"), xRow)
            If getColumnIndex(spr, "FactOrderSeq") > -1 Then z4958.FactOrderSeq = getDataM(spr, getColumnIndex(spr, "FactOrderSeq"), xRow)
            If getColumnIndex(spr, "JobCard") > -1 Then z4958.JobCard = getDataM(spr, getColumnIndex(spr, "JobCard"), xRow)
            If getColumnIndex(spr, "SizeGroup") > -1 Then z4958.SizeGroup = getDataM(spr, getColumnIndex(spr, "SizeGroup"), xRow)
            If getColumnIndex(spr, "QtyPrs") > -1 Then z4958.QtyPrs = getDataM(spr, getColumnIndex(spr, "QtyPrs"), xRow)
            If getColumnIndex(spr, "SizeQty01") > -1 Then z4958.SizeQty01 = getDataM(spr, getColumnIndex(spr, "SizeQty01"), xRow)
            If getColumnIndex(spr, "SizeQty02") > -1 Then z4958.SizeQty02 = getDataM(spr, getColumnIndex(spr, "SizeQty02"), xRow)
            If getColumnIndex(spr, "SizeQty03") > -1 Then z4958.SizeQty03 = getDataM(spr, getColumnIndex(spr, "SizeQty03"), xRow)
            If getColumnIndex(spr, "SizeQty04") > -1 Then z4958.SizeQty04 = getDataM(spr, getColumnIndex(spr, "SizeQty04"), xRow)
            If getColumnIndex(spr, "SizeQty05") > -1 Then z4958.SizeQty05 = getDataM(spr, getColumnIndex(spr, "SizeQty05"), xRow)
            If getColumnIndex(spr, "SizeQty06") > -1 Then z4958.SizeQty06 = getDataM(spr, getColumnIndex(spr, "SizeQty06"), xRow)
            If getColumnIndex(spr, "SizeQty07") > -1 Then z4958.SizeQty07 = getDataM(spr, getColumnIndex(spr, "SizeQty07"), xRow)
            If getColumnIndex(spr, "SizeQty08") > -1 Then z4958.SizeQty08 = getDataM(spr, getColumnIndex(spr, "SizeQty08"), xRow)
            If getColumnIndex(spr, "SizeQty09") > -1 Then z4958.SizeQty09 = getDataM(spr, getColumnIndex(spr, "SizeQty09"), xRow)
            If getColumnIndex(spr, "SizeQty10") > -1 Then z4958.SizeQty10 = getDataM(spr, getColumnIndex(spr, "SizeQty10"), xRow)
            If getColumnIndex(spr, "SizeQty11") > -1 Then z4958.SizeQty11 = getDataM(spr, getColumnIndex(spr, "SizeQty11"), xRow)
            If getColumnIndex(spr, "SizeQty12") > -1 Then z4958.SizeQty12 = getDataM(spr, getColumnIndex(spr, "SizeQty12"), xRow)
            If getColumnIndex(spr, "SizeQty13") > -1 Then z4958.SizeQty13 = getDataM(spr, getColumnIndex(spr, "SizeQty13"), xRow)
            If getColumnIndex(spr, "SizeQty14") > -1 Then z4958.SizeQty14 = getDataM(spr, getColumnIndex(spr, "SizeQty14"), xRow)
            If getColumnIndex(spr, "SizeQty15") > -1 Then z4958.SizeQty15 = getDataM(spr, getColumnIndex(spr, "SizeQty15"), xRow)
            If getColumnIndex(spr, "SizeQty16") > -1 Then z4958.SizeQty16 = getDataM(spr, getColumnIndex(spr, "SizeQty16"), xRow)
            If getColumnIndex(spr, "SizeQty17") > -1 Then z4958.SizeQty17 = getDataM(spr, getColumnIndex(spr, "SizeQty17"), xRow)
            If getColumnIndex(spr, "SizeQty18") > -1 Then z4958.SizeQty18 = getDataM(spr, getColumnIndex(spr, "SizeQty18"), xRow)
            If getColumnIndex(spr, "SizeQty19") > -1 Then z4958.SizeQty19 = getDataM(spr, getColumnIndex(spr, "SizeQty19"), xRow)
            If getColumnIndex(spr, "SizeQty20") > -1 Then z4958.SizeQty20 = getDataM(spr, getColumnIndex(spr, "SizeQty20"), xRow)
            If getColumnIndex(spr, "SizeQty21") > -1 Then z4958.SizeQty21 = getDataM(spr, getColumnIndex(spr, "SizeQty21"), xRow)
            If getColumnIndex(spr, "SizeQty22") > -1 Then z4958.SizeQty22 = getDataM(spr, getColumnIndex(spr, "SizeQty22"), xRow)
            If getColumnIndex(spr, "SizeQty23") > -1 Then z4958.SizeQty23 = getDataM(spr, getColumnIndex(spr, "SizeQty23"), xRow)
            If getColumnIndex(spr, "SizeQty24") > -1 Then z4958.SizeQty24 = getDataM(spr, getColumnIndex(spr, "SizeQty24"), xRow)
            If getColumnIndex(spr, "SizeQty25") > -1 Then z4958.SizeQty25 = getDataM(spr, getColumnIndex(spr, "SizeQty25"), xRow)
            If getColumnIndex(spr, "SizeQty26") > -1 Then z4958.SizeQty26 = getDataM(spr, getColumnIndex(spr, "SizeQty26"), xRow)
            If getColumnIndex(spr, "SizeQty27") > -1 Then z4958.SizeQty27 = getDataM(spr, getColumnIndex(spr, "SizeQty27"), xRow)
            If getColumnIndex(spr, "SizeQty28") > -1 Then z4958.SizeQty28 = getDataM(spr, getColumnIndex(spr, "SizeQty28"), xRow)
            If getColumnIndex(spr, "SizeQty29") > -1 Then z4958.SizeQty29 = getDataM(spr, getColumnIndex(spr, "SizeQty29"), xRow)
            If getColumnIndex(spr, "SizeQty30") > -1 Then z4958.SizeQty30 = getDataM(spr, getColumnIndex(spr, "SizeQty30"), xRow)
            If getColumnIndex(spr, "PackingCMB") > -1 Then z4958.PackingCMB = getDataM(spr, getColumnIndex(spr, "PackingCMB"), xRow)
            If getColumnIndex(spr, "PackingGW") > -1 Then z4958.PackingGW = getDataM(spr, getColumnIndex(spr, "PackingGW"), xRow)
            If getColumnIndex(spr, "PackingNW") > -1 Then z4958.PackingNW = getDataM(spr, getColumnIndex(spr, "PackingNW"), xRow)
            If getColumnIndex(spr, "QtyPacking") > -1 Then z4958.QtyPacking = getDataM(spr, getColumnIndex(spr, "QtyPacking"), xRow)
            If getColumnIndex(spr, "QtyLoading") > -1 Then z4958.QtyLoading = getDataM(spr, getColumnIndex(spr, "QtyLoading"), xRow)

            If getColumnIndex(spr, "JCPREFIX1") > -1 Then z4958.JCPREFIX1 = getDataM(spr, getColumnIndex(spr, "JCPREFIX1"), xRow)
            If getColumnIndex(spr, "JCPREFIX2") > -1 Then z4958.JCPREFIX2 = getDataM(spr, getColumnIndex(spr, "JCPREFIX2"), xRow)
            If getColumnIndex(spr, "JOBCARDNO") > -1 Then z4958.JOBCARDNO = getDataM(spr, getColumnIndex(spr, "JOBCARDNO"), xRow)
            If getColumnIndex(spr, "ColorCode") > -1 Then z4958.ColorCode = getDataM(spr, getColumnIndex(spr, "ColorCode"), xRow)
            If getColumnIndex(spr, "MCODENAME") > -1 Then z4958.MCODENAME = getDataM(spr, getColumnIndex(spr, "MCODENAME"), xRow)
            If getColumnIndex(spr, "PONO") > -1 Then z4958.PONO = getDataM(spr, getColumnIndex(spr, "PONO"), xRow)
            If getColumnIndex(spr, "PKONO") > -1 Then z4958.PKONO = getDataM(spr, getColumnIndex(spr, "PKONO"), xRow)
            If getColumnIndex(spr, "SlNoD") > -1 Then z4958.SlNoD = getDataM(spr, getColumnIndex(spr, "SlNoD"), xRow)
            If getColumnIndex(spr, "SlNo") > -1 Then z4958.SlNo = getDataM(spr, getColumnIndex(spr, "SlNo"), xRow)
            If getColumnIndex(spr, "Article") > -1 Then z4958.Article = getDataM(spr, getColumnIndex(spr, "Article"), xRow)
            If getColumnIndex(spr, "SizeRangeName") > -1 Then z4958.SizeRangeName = getDataM(spr, getColumnIndex(spr, "SizeRangeName"), xRow)
            If getColumnIndex(spr, "seSeason") > -1 Then z4958.seSeason = getDataM(spr, getColumnIndex(spr, "seSeason"), xRow)
            If getColumnIndex(spr, "cdSeason") > -1 Then z4958.cdSeason = getDataM(spr, getColumnIndex(spr, "cdSeason"), xRow)
            If getColumnIndex(spr, "DateInsert") > -1 Then z4958.DateInsert = getDataM(spr, getColumnIndex(spr, "DateInsert"), xRow)
            If getColumnIndex(spr, "DateUpdate") > -1 Then z4958.DateUpdate = getDataM(spr, getColumnIndex(spr, "DateUpdate"), xRow)
            If getColumnIndex(spr, "InchargeInsert") > -1 Then z4958.InchargeInsert = getDataM(spr, getColumnIndex(spr, "InchargeInsert"), xRow)
            If getColumnIndex(spr, "InchargeUpdate") > -1 Then z4958.InchargeUpdate = getDataM(spr, getColumnIndex(spr, "InchargeUpdate"), xRow)
            If getColumnIndex(spr, "CheckUse") > -1 Then z4958.CheckUse = getDataM(spr, getColumnIndex(spr, "CheckUse"), xRow)
            If getColumnIndex(spr, "CheckComplete") > -1 Then z4958.CheckComplete = getDataM(spr, getColumnIndex(spr, "CheckComplete"), xRow)
            If getColumnIndex(spr, "Printed") > -1 Then z4958.Printed = getDataM(spr, getColumnIndex(spr, "Printed"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z4958.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4958_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K4958_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z4958 As T4958_AREA, Job As String, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K4958_MOVE = False

        Try
            If READ_PFK4958(AUTOKEY) = True Then
                z4958 = D4958
                K4958_MOVE = True
            Else
                z4958 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4958")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z4958.Autokey = Children(i).Code
                                Case "AUTOKEY_K3422" : z4958.AutoKey_K3422 = Children(i).Code

                                Case "PRODUCTINBOUNDNO" : z4958.ProductInBoundNo = Children(i).Code
                                Case "PRODUCTINBOUNDSEQ" : z4958.ProductInBoundSeq = Children(i).Code
                                Case "PACKINGBATCH" : z4958.PackingBatch = Children(i).Code
                                Case "PACKINGCUSBATCH" : z4958.PackingCusBatch = Children(i).Code
                                Case "SEPACKINGTYPE" : z4958.sePackingType = Children(i).Code
                                Case "CDPACKINGTYPE" : z4958.cdPackingType = Children(i).Code
                                Case "PACKINGTYPENAME" : z4958.PackingTypeName = Children(i).Code
                                Case "DATEPACKING" : z4958.DatePacking = Children(i).Code
                                Case "CUSTOMERCODE" : z4958.CustomerCode = Children(i).Code
                                Case "CARTONCODE" : z4958.CartonCode = Children(i).Code
                                Case "CARTONNO" : z4958.CartonNo = Children(i).Code
                                Case "LOADINGNO" : z4958.LoadingNo = Children(i).Code
                                Case "LOADINGCODE" : z4958.LoadingCode = Children(i).Code
                                Case "LOADINGSEQ" : z4958.LoadingSeq = Children(i).Code
                                Case "ORDERNO" : z4958.OrderNo = Children(i).Code
                                Case "ORDERNOSEQ" : z4958.OrderNoSeq = Children(i).Code
                                Case "FACTORDERNO" : z4958.FactOrderNo = Children(i).Code
                                Case "FACTORDERSEQ" : z4958.FactOrderSeq = Children(i).Code
                                Case "JOBCARD" : z4958.JobCard = Children(i).Code
                                Case "SIZEGROUP" : z4958.SizeGroup = Children(i).Code
                                Case "QTYPRS" : z4958.QtyPrs = Children(i).Code
                                Case "SIZEQTY01" : z4958.SizeQty01 = Children(i).Code
                                Case "SIZEQTY02" : z4958.SizeQty02 = Children(i).Code
                                Case "SIZEQTY03" : z4958.SizeQty03 = Children(i).Code
                                Case "SIZEQTY04" : z4958.SizeQty04 = Children(i).Code
                                Case "SIZEQTY05" : z4958.SizeQty05 = Children(i).Code
                                Case "SIZEQTY06" : z4958.SizeQty06 = Children(i).Code
                                Case "SIZEQTY07" : z4958.SizeQty07 = Children(i).Code
                                Case "SIZEQTY08" : z4958.SizeQty08 = Children(i).Code
                                Case "SIZEQTY09" : z4958.SizeQty09 = Children(i).Code
                                Case "SIZEQTY10" : z4958.SizeQty10 = Children(i).Code
                                Case "SIZEQTY11" : z4958.SizeQty11 = Children(i).Code
                                Case "SIZEQTY12" : z4958.SizeQty12 = Children(i).Code
                                Case "SIZEQTY13" : z4958.SizeQty13 = Children(i).Code
                                Case "SIZEQTY14" : z4958.SizeQty14 = Children(i).Code
                                Case "SIZEQTY15" : z4958.SizeQty15 = Children(i).Code
                                Case "SIZEQTY16" : z4958.SizeQty16 = Children(i).Code
                                Case "SIZEQTY17" : z4958.SizeQty17 = Children(i).Code
                                Case "SIZEQTY18" : z4958.SizeQty18 = Children(i).Code
                                Case "SIZEQTY19" : z4958.SizeQty19 = Children(i).Code
                                Case "SIZEQTY20" : z4958.SizeQty20 = Children(i).Code
                                Case "SIZEQTY21" : z4958.SizeQty21 = Children(i).Code
                                Case "SIZEQTY22" : z4958.SizeQty22 = Children(i).Code
                                Case "SIZEQTY23" : z4958.SizeQty23 = Children(i).Code
                                Case "SIZEQTY24" : z4958.SizeQty24 = Children(i).Code
                                Case "SIZEQTY25" : z4958.SizeQty25 = Children(i).Code
                                Case "SIZEQTY26" : z4958.SizeQty26 = Children(i).Code
                                Case "SIZEQTY27" : z4958.SizeQty27 = Children(i).Code
                                Case "SIZEQTY28" : z4958.SizeQty28 = Children(i).Code
                                Case "SIZEQTY29" : z4958.SizeQty29 = Children(i).Code
                                Case "SIZEQTY30" : z4958.SizeQty30 = Children(i).Code
                                Case "PACKINGCMB" : z4958.PackingCMB = Children(i).Code
                                Case "PACKINGGW" : z4958.PackingGW = Children(i).Code
                                Case "PACKINGNW" : z4958.PackingNW = Children(i).Code
                                Case "QTYPACKING" : z4958.QtyPacking = Children(i).Code
                                Case "QTYLOADING" : z4958.QtyLoading = Children(i).Code

                                Case "JCPREFIX1" : z4958.JCPREFIX1 = Children(i).Code
                                Case "JCPREFIX2" : z4958.JCPREFIX2 = Children(i).Code
                                Case "JOBCARDNO" : z4958.JOBCARDNO = Children(i).Code
                                Case "COLORCODE" : z4958.ColorCode = Children(i).Code
                                Case "MCODENAME" : z4958.MCODENAME = Children(i).Code
                                Case "PONO" : z4958.PONO = Children(i).Code
                                Case "PKONO" : z4958.PKONO = Children(i).Code
                                Case "SLNOD" : z4958.SlNoD = Children(i).Code
                                Case "SLNO" : z4958.SlNo = Children(i).Code
                                Case "ARTICLE" : z4958.Article = Children(i).Code
                                Case "SIZERANGENAME" : z4958.SizeRangeName = Children(i).Code
                                Case "SESEASON" : z4958.seSeason = Children(i).Code
                                Case "CDSEASON" : z4958.cdSeason = Children(i).Code
                                Case "DATEINSERT" : z4958.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z4958.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z4958.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z4958.InchargeUpdate = Children(i).Code
                                Case "CHECKUSE" : z4958.CheckUse = Children(i).Code
                                Case "CHECKCOMPLETE" : z4958.CheckComplete = Children(i).Code
                                Case "PRINTED" : z4958.Printed = Children(i).Code
                                Case "REMARK" : z4958.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z4958.Autokey = Children(i).Data
                                Case "AUTOKEY_K3422" : z4958.AutoKey_K3422 = Children(i).Data
                                Case "PRODUCTINBOUNDNO" : z4958.ProductInBoundNo = Children(i).Data
                                Case "PRODUCTINBOUNDSEQ" : z4958.ProductInBoundSeq = Children(i).Data
                                Case "PACKINGBATCH" : z4958.PackingBatch = Children(i).Data
                                Case "PACKINGCUSBATCH" : z4958.PackingCusBatch = Children(i).Data
                                Case "SEPACKINGTYPE" : z4958.sePackingType = Children(i).Data
                                Case "CDPACKINGTYPE" : z4958.cdPackingType = Children(i).Data
                                Case "PACKINGTYPENAME" : z4958.PackingTypeName = Children(i).Data
                                Case "DATEPACKING" : z4958.DatePacking = Children(i).Data
                                Case "CUSTOMERCODE" : z4958.CustomerCode = Children(i).Data
                                Case "CARTONCODE" : z4958.CartonCode = Children(i).Data
                                Case "CARTONNO" : z4958.CartonNo = Children(i).Data
                                Case "LOADINGNO" : z4958.LoadingNo = Children(i).Data
                                Case "LOADINGCODE" : z4958.LoadingCode = Children(i).Data
                                Case "LOADINGSEQ" : z4958.LoadingSeq = Children(i).Data
                                Case "ORDERNO" : z4958.OrderNo = Children(i).Data
                                Case "ORDERNOSEQ" : z4958.OrderNoSeq = Children(i).Data
                                Case "FACTORDERNO" : z4958.FactOrderNo = Children(i).Data
                                Case "FACTORDERSEQ" : z4958.FactOrderSeq = Children(i).Data
                                Case "JOBCARD" : z4958.JobCard = Children(i).Data
                                Case "SIZEGROUP" : z4958.SizeGroup = Children(i).Data
                                Case "QTYPRS" : z4958.QtyPrs = Children(i).Data
                                Case "SIZEQTY01" : z4958.SizeQty01 = Children(i).Data
                                Case "SIZEQTY02" : z4958.SizeQty02 = Children(i).Data
                                Case "SIZEQTY03" : z4958.SizeQty03 = Children(i).Data
                                Case "SIZEQTY04" : z4958.SizeQty04 = Children(i).Data
                                Case "SIZEQTY05" : z4958.SizeQty05 = Children(i).Data
                                Case "SIZEQTY06" : z4958.SizeQty06 = Children(i).Data
                                Case "SIZEQTY07" : z4958.SizeQty07 = Children(i).Data
                                Case "SIZEQTY08" : z4958.SizeQty08 = Children(i).Data
                                Case "SIZEQTY09" : z4958.SizeQty09 = Children(i).Data
                                Case "SIZEQTY10" : z4958.SizeQty10 = Children(i).Data
                                Case "SIZEQTY11" : z4958.SizeQty11 = Children(i).Data
                                Case "SIZEQTY12" : z4958.SizeQty12 = Children(i).Data
                                Case "SIZEQTY13" : z4958.SizeQty13 = Children(i).Data
                                Case "SIZEQTY14" : z4958.SizeQty14 = Children(i).Data
                                Case "SIZEQTY15" : z4958.SizeQty15 = Children(i).Data
                                Case "SIZEQTY16" : z4958.SizeQty16 = Children(i).Data
                                Case "SIZEQTY17" : z4958.SizeQty17 = Children(i).Data
                                Case "SIZEQTY18" : z4958.SizeQty18 = Children(i).Data
                                Case "SIZEQTY19" : z4958.SizeQty19 = Children(i).Data
                                Case "SIZEQTY20" : z4958.SizeQty20 = Children(i).Data
                                Case "SIZEQTY21" : z4958.SizeQty21 = Children(i).Data
                                Case "SIZEQTY22" : z4958.SizeQty22 = Children(i).Data
                                Case "SIZEQTY23" : z4958.SizeQty23 = Children(i).Data
                                Case "SIZEQTY24" : z4958.SizeQty24 = Children(i).Data
                                Case "SIZEQTY25" : z4958.SizeQty25 = Children(i).Data
                                Case "SIZEQTY26" : z4958.SizeQty26 = Children(i).Data
                                Case "SIZEQTY27" : z4958.SizeQty27 = Children(i).Data
                                Case "SIZEQTY28" : z4958.SizeQty28 = Children(i).Data
                                Case "SIZEQTY29" : z4958.SizeQty29 = Children(i).Data
                                Case "SIZEQTY30" : z4958.SizeQty30 = Children(i).Data
                                Case "PACKINGCMB" : z4958.PackingCMB = Children(i).Data
                                Case "PACKINGGW" : z4958.PackingGW = Children(i).Data
                                Case "PACKINGNW" : z4958.PackingNW = Children(i).Data
                                Case "QTYPACKING" : z4958.QtyPacking = Children(i).Data
                                Case "QTYLOADING" : z4958.QtyLoading = Children(i).Data
     
                                Case "JCPREFIX1" : z4958.JCPREFIX1 = Children(i).Data
                                Case "JCPREFIX2" : z4958.JCPREFIX2 = Children(i).Data
                                Case "JOBCARDNO" : z4958.JOBCARDNO = Children(i).Data
                                Case "COLORCODE" : z4958.ColorCode = Children(i).Data
                                Case "MCODENAME" : z4958.MCODENAME = Children(i).Data
                                Case "PONO" : z4958.PONO = Children(i).Data
                                Case "PKONO" : z4958.PKONO = Children(i).Data
                                Case "SLNOD" : z4958.SlNoD = Children(i).Data
                                Case "SLNO" : z4958.SlNo = Children(i).Data
                                Case "ARTICLE" : z4958.Article = Children(i).Data
                                Case "SIZERANGENAME" : z4958.SizeRangeName = Children(i).Data
                                Case "SESEASON" : z4958.seSeason = Children(i).Data
                                Case "CDSEASON" : z4958.cdSeason = Children(i).Data
                                Case "DATEINSERT" : z4958.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z4958.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z4958.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z4958.InchargeUpdate = Children(i).Data
                                Case "CHECKUSE" : z4958.CheckUse = Children(i).Data
                                Case "CHECKCOMPLETE" : z4958.CheckComplete = Children(i).Data
                                Case "PRINTED" : z4958.Printed = Children(i).Data
                                Case "REMARK" : z4958.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4958_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K4958_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z4958 As T4958_AREA, Job As String, CheckClear As Boolean, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K4958_MOVE = False

        Try
            If READ_PFK4958(AUTOKEY) = True Then
                z4958 = D4958
                K4958_MOVE = True
            Else
                If CheckClear = True Then z4958 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4958")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z4958.Autokey = Children(i).Code
                                Case "AUTOKEY_K3422" : z4958.AutoKey_K3422 = Children(i).Code
                                Case "PRODUCTINBOUNDNO" : z4958.ProductInBoundNo = Children(i).Code
                                Case "PRODUCTINBOUNDSEQ" : z4958.ProductInBoundSeq = Children(i).Code
                                Case "PACKINGBATCH" : z4958.PackingBatch = Children(i).Code
                                Case "PACKINGCUSBATCH" : z4958.PackingCusBatch = Children(i).Code
                                Case "SEPACKINGTYPE" : z4958.sePackingType = Children(i).Code
                                Case "CDPACKINGTYPE" : z4958.cdPackingType = Children(i).Code
                                Case "PACKINGTYPENAME" : z4958.PackingTypeName = Children(i).Code
                                Case "DATEPACKING" : z4958.DatePacking = Children(i).Code
                                Case "CUSTOMERCODE" : z4958.CustomerCode = Children(i).Code
                                Case "CARTONCODE" : z4958.CartonCode = Children(i).Code
                                Case "CARTONNO" : z4958.CartonNo = Children(i).Code
                                Case "LOADINGNO" : z4958.LoadingNo = Children(i).Code
                                Case "LOADINGCODE" : z4958.LoadingCode = Children(i).Code
                                Case "LOADINGSEQ" : z4958.LoadingSeq = Children(i).Code
                                Case "ORDERNO" : z4958.OrderNo = Children(i).Code
                                Case "ORDERNOSEQ" : z4958.OrderNoSeq = Children(i).Code
                                Case "FACTORDERNO" : z4958.FactOrderNo = Children(i).Code
                                Case "FACTORDERSEQ" : z4958.FactOrderSeq = Children(i).Code
                                Case "JOBCARD" : z4958.JobCard = Children(i).Code
                                Case "SIZEGROUP" : z4958.SizeGroup = Children(i).Code
                                Case "QTYPRS" : z4958.QtyPrs = Children(i).Code
                                Case "SIZEQTY01" : z4958.SizeQty01 = Children(i).Code
                                Case "SIZEQTY02" : z4958.SizeQty02 = Children(i).Code
                                Case "SIZEQTY03" : z4958.SizeQty03 = Children(i).Code
                                Case "SIZEQTY04" : z4958.SizeQty04 = Children(i).Code
                                Case "SIZEQTY05" : z4958.SizeQty05 = Children(i).Code
                                Case "SIZEQTY06" : z4958.SizeQty06 = Children(i).Code
                                Case "SIZEQTY07" : z4958.SizeQty07 = Children(i).Code
                                Case "SIZEQTY08" : z4958.SizeQty08 = Children(i).Code
                                Case "SIZEQTY09" : z4958.SizeQty09 = Children(i).Code
                                Case "SIZEQTY10" : z4958.SizeQty10 = Children(i).Code
                                Case "SIZEQTY11" : z4958.SizeQty11 = Children(i).Code
                                Case "SIZEQTY12" : z4958.SizeQty12 = Children(i).Code
                                Case "SIZEQTY13" : z4958.SizeQty13 = Children(i).Code
                                Case "SIZEQTY14" : z4958.SizeQty14 = Children(i).Code
                                Case "SIZEQTY15" : z4958.SizeQty15 = Children(i).Code
                                Case "SIZEQTY16" : z4958.SizeQty16 = Children(i).Code
                                Case "SIZEQTY17" : z4958.SizeQty17 = Children(i).Code
                                Case "SIZEQTY18" : z4958.SizeQty18 = Children(i).Code
                                Case "SIZEQTY19" : z4958.SizeQty19 = Children(i).Code
                                Case "SIZEQTY20" : z4958.SizeQty20 = Children(i).Code
                                Case "SIZEQTY21" : z4958.SizeQty21 = Children(i).Code
                                Case "SIZEQTY22" : z4958.SizeQty22 = Children(i).Code
                                Case "SIZEQTY23" : z4958.SizeQty23 = Children(i).Code
                                Case "SIZEQTY24" : z4958.SizeQty24 = Children(i).Code
                                Case "SIZEQTY25" : z4958.SizeQty25 = Children(i).Code
                                Case "SIZEQTY26" : z4958.SizeQty26 = Children(i).Code
                                Case "SIZEQTY27" : z4958.SizeQty27 = Children(i).Code
                                Case "SIZEQTY28" : z4958.SizeQty28 = Children(i).Code
                                Case "SIZEQTY29" : z4958.SizeQty29 = Children(i).Code
                                Case "SIZEQTY30" : z4958.SizeQty30 = Children(i).Code
                                Case "PACKINGCMB" : z4958.PackingCMB = Children(i).Code
                                Case "PACKINGGW" : z4958.PackingGW = Children(i).Code
                                Case "PACKINGNW" : z4958.PackingNW = Children(i).Code
                                Case "QTYPACKING" : z4958.QtyPacking = Children(i).Code
                                Case "QTYLOADING" : z4958.QtyLoading = Children(i).Code

                                Case "JCPREFIX1" : z4958.JCPREFIX1 = Children(i).Code
                                Case "JCPREFIX2" : z4958.JCPREFIX2 = Children(i).Code
                                Case "JOBCARDNO" : z4958.JOBCARDNO = Children(i).Code
                                Case "COLORCODE" : z4958.ColorCode = Children(i).Code
                                Case "MCODENAME" : z4958.MCODENAME = Children(i).Code
                                Case "PONO" : z4958.PONO = Children(i).Code
                                Case "PKONO" : z4958.PKONO = Children(i).Code
                                Case "SLNOD" : z4958.SlNoD = Children(i).Code
                                Case "SLNO" : z4958.SlNo = Children(i).Code
                                Case "ARTICLE" : z4958.Article = Children(i).Code
                                Case "SIZERANGENAME" : z4958.SizeRangeName = Children(i).Code
                                Case "SESEASON" : z4958.seSeason = Children(i).Code
                                Case "CDSEASON" : z4958.cdSeason = Children(i).Code
                                Case "DATEINSERT" : z4958.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z4958.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z4958.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z4958.InchargeUpdate = Children(i).Code
                                Case "CHECKUSE" : z4958.CheckUse = Children(i).Code
                                Case "CHECKCOMPLETE" : z4958.CheckComplete = Children(i).Code
                                Case "PRINTED" : z4958.Printed = Children(i).Code
                                Case "REMARK" : z4958.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z4958.Autokey = Children(i).Data
                                Case "AUTOKEY_K3422" : z4958.AutoKey_K3422 = Children(i).Data

                                Case "PRODUCTINBOUNDNO" : z4958.ProductInBoundNo = Children(i).Data
                                Case "PRODUCTINBOUNDSEQ" : z4958.ProductInBoundSeq = Children(i).Data
                                Case "PACKINGBATCH" : z4958.PackingBatch = Children(i).Data
                                Case "PACKINGCUSBATCH" : z4958.PackingCusBatch = Children(i).Data
                                Case "SEPACKINGTYPE" : z4958.sePackingType = Children(i).Data
                                Case "CDPACKINGTYPE" : z4958.cdPackingType = Children(i).Data
                                Case "PACKINGTYPENAME" : z4958.PackingTypeName = Children(i).Data
                                Case "DATEPACKING" : z4958.DatePacking = Children(i).Data
                                Case "CUSTOMERCODE" : z4958.CustomerCode = Children(i).Data
                                Case "CARTONCODE" : z4958.CartonCode = Children(i).Data
                                Case "CARTONNO" : z4958.CartonNo = Children(i).Data
                                Case "LOADINGNO" : z4958.LoadingNo = Children(i).Data
                                Case "LOADINGCODE" : z4958.LoadingCode = Children(i).Data
                                Case "LOADINGSEQ" : z4958.LoadingSeq = Children(i).Data
                                Case "ORDERNO" : z4958.OrderNo = Children(i).Data
                                Case "ORDERNOSEQ" : z4958.OrderNoSeq = Children(i).Data
                                Case "FACTORDERNO" : z4958.FactOrderNo = Children(i).Data
                                Case "FACTORDERSEQ" : z4958.FactOrderSeq = Children(i).Data
                                Case "JOBCARD" : z4958.JobCard = Children(i).Data
                                Case "SIZEGROUP" : z4958.SizeGroup = Children(i).Data
                                Case "QTYPRS" : z4958.QtyPrs = Children(i).Data
                                Case "SIZEQTY01" : z4958.SizeQty01 = Children(i).Data
                                Case "SIZEQTY02" : z4958.SizeQty02 = Children(i).Data
                                Case "SIZEQTY03" : z4958.SizeQty03 = Children(i).Data
                                Case "SIZEQTY04" : z4958.SizeQty04 = Children(i).Data
                                Case "SIZEQTY05" : z4958.SizeQty05 = Children(i).Data
                                Case "SIZEQTY06" : z4958.SizeQty06 = Children(i).Data
                                Case "SIZEQTY07" : z4958.SizeQty07 = Children(i).Data
                                Case "SIZEQTY08" : z4958.SizeQty08 = Children(i).Data
                                Case "SIZEQTY09" : z4958.SizeQty09 = Children(i).Data
                                Case "SIZEQTY10" : z4958.SizeQty10 = Children(i).Data
                                Case "SIZEQTY11" : z4958.SizeQty11 = Children(i).Data
                                Case "SIZEQTY12" : z4958.SizeQty12 = Children(i).Data
                                Case "SIZEQTY13" : z4958.SizeQty13 = Children(i).Data
                                Case "SIZEQTY14" : z4958.SizeQty14 = Children(i).Data
                                Case "SIZEQTY15" : z4958.SizeQty15 = Children(i).Data
                                Case "SIZEQTY16" : z4958.SizeQty16 = Children(i).Data
                                Case "SIZEQTY17" : z4958.SizeQty17 = Children(i).Data
                                Case "SIZEQTY18" : z4958.SizeQty18 = Children(i).Data
                                Case "SIZEQTY19" : z4958.SizeQty19 = Children(i).Data
                                Case "SIZEQTY20" : z4958.SizeQty20 = Children(i).Data
                                Case "SIZEQTY21" : z4958.SizeQty21 = Children(i).Data
                                Case "SIZEQTY22" : z4958.SizeQty22 = Children(i).Data
                                Case "SIZEQTY23" : z4958.SizeQty23 = Children(i).Data
                                Case "SIZEQTY24" : z4958.SizeQty24 = Children(i).Data
                                Case "SIZEQTY25" : z4958.SizeQty25 = Children(i).Data
                                Case "SIZEQTY26" : z4958.SizeQty26 = Children(i).Data
                                Case "SIZEQTY27" : z4958.SizeQty27 = Children(i).Data
                                Case "SIZEQTY28" : z4958.SizeQty28 = Children(i).Data
                                Case "SIZEQTY29" : z4958.SizeQty29 = Children(i).Data
                                Case "SIZEQTY30" : z4958.SizeQty30 = Children(i).Data
                                Case "PACKINGCMB" : z4958.PackingCMB = Children(i).Data
                                Case "PACKINGGW" : z4958.PackingGW = Children(i).Data
                                Case "PACKINGNW" : z4958.PackingNW = Children(i).Data
                                Case "QTYPACKING" : z4958.QtyPacking = Children(i).Data
                                Case "QTYLOADING" : z4958.QtyLoading = Children(i).Data

                                Case "JCPREFIX1" : z4958.JCPREFIX1 = Children(i).Data
                                Case "JCPREFIX2" : z4958.JCPREFIX2 = Children(i).Data
                                Case "JOBCARDNO" : z4958.JOBCARDNO = Children(i).Data
                                Case "COLORCODE" : z4958.ColorCode = Children(i).Data
                                Case "MCODENAME" : z4958.MCODENAME = Children(i).Data
                                Case "PONO" : z4958.PONO = Children(i).Data
                                Case "PKONO" : z4958.PKONO = Children(i).Data
                                Case "SLNOD" : z4958.SlNoD = Children(i).Data
                                Case "SLNO" : z4958.SlNo = Children(i).Data
                                Case "ARTICLE" : z4958.Article = Children(i).Data
                                Case "SIZERANGENAME" : z4958.SizeRangeName = Children(i).Data
                                Case "SESEASON" : z4958.seSeason = Children(i).Data
                                Case "CDSEASON" : z4958.cdSeason = Children(i).Data
                                Case "DATEINSERT" : z4958.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z4958.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z4958.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z4958.InchargeUpdate = Children(i).Data
                                Case "CHECKUSE" : z4958.CheckUse = Children(i).Data
                                Case "CHECKCOMPLETE" : z4958.CheckComplete = Children(i).Data
                                Case "PRINTED" : z4958.Printed = Children(i).Data
                                Case "REMARK" : z4958.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4958_MOVE", vbCritical)
        End Try
    End Function

End Module
