'=========================================================================================================================================================
'   TABLE : (PFK3142)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K3142

    Structure T3142_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public RequestPurchasingNo As String  '			char(9)		*
        Public RequestPurchasingSeq As Double  '			decimal		*
        Public Dseq As Double  '			decimal
        Public MaterialCode As String  '			char(6)
        Public BoxRequestPurchasing As Double  '			decimal
        Public QtyRequestPurchasing As Double  '			decimal
        Public selUnitPriceMaterial As String  '			char(3)
        Public cdUnitPriceMaterial As String  '			char(3)
        Public PricePurchasing As Double  '			decimal
        Public PricePurchasingUSD As Double  '			decimal
        Public PricePurchasingVND As Double  '			decimal
        Public AmtPurchasingUSD As Double  '			decimal
        Public AmtPurchasingVND As Double  '			decimal
        Public selTaxImport As String  '			char(3)
        Public cdTaxImport As String  '			char(3)
        Public PerTaxImport As Double  '			decimal
        Public AmtTaxImport As Double  '			decimal
        Public selTaxVat As String  '			char(3)
        Public cdTaxVat As String  '			char(3)
        Public PerTaxVat As Double  '			decimal
        Public AmtTaxVat As Double  '			decimal
        Public DateInBoundMaterial As String  '			char(8)
        Public BoxInBoundMaterial As Double  '			decimal
        Public QtyInBoundMaterial As Double  '			decimal
        Public AmtInBoundMaterial_USD As Double  '			decimal
        Public AmtInBoundMaterial_VND As Double  '			decimal
        Public CheckRequestPurchasing As String  '			char(1)
        Public DateRequestPurchasing As String  '			char(8)
        Public DateCompletePurchasing As String  '			char(8)
        Public DateApprovalPurchasing As String  '			char(8)
        Public DateCancelPurchasing As String  '			char(8)
        Public CheckComplete As String  '			char(1)
        Public SalesOrderNo As String  '			char(9)
        Public SalesOrderSeq As String  '			char(2)
        Public SalesOrderSno As String  '			char(2)
        Public Remark As String  '			nvarchar(-1)
        '=========================================================================================================================================================
    End Structure

    Public D3142 As T3142_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK3142(REQUESTPURCHASINGNO As String, REQUESTPURCHASINGSEQ As Double) As Boolean
        READ_PFK3142 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3142 "
            SQL = SQL & " WHERE K3142_RequestPurchasingNo		 = '" & RequestPurchasingNo & "' "
            SQL = SQL & "   AND K3142_RequestPurchasingSeq		 =  " & RequestPurchasingSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D3142_CLEAR() : GoTo SKIP_READ_PFK3142

            Call K3142_MOVE(rd)
            READ_PFK3142 = True

SKIP_READ_PFK3142:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK3142", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK3142(REQUESTPURCHASINGNO As String, REQUESTPURCHASINGSEQ As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3142 "
            SQL = SQL & " WHERE K3142_RequestPurchasingNo		 = '" & RequestPurchasingNo & "' "
            SQL = SQL & "   AND K3142_RequestPurchasingSeq		 =  " & RequestPurchasingSeq & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK3142", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK3142(z3142 As T3142_AREA) As Boolean
        WRITE_PFK3142 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z3142)

            SQL = " INSERT INTO PFK3142 "
            SQL = SQL & " ( "
            SQL = SQL & " K3142_RequestPurchasingNo,"
            SQL = SQL & " K3142_RequestPurchasingSeq,"
            SQL = SQL & " K3142_Dseq,"
            SQL = SQL & " K3142_MaterialCode,"
            SQL = SQL & " K3142_BoxRequestPurchasing,"
            SQL = SQL & " K3142_QtyRequestPurchasing,"
            SQL = SQL & " K3142_selUnitPriceMaterial,"
            SQL = SQL & " K3142_cdUnitPriceMaterial,"
            SQL = SQL & " K3142_PricePurchasing,"
            SQL = SQL & " K3142_PricePurchasingUSD,"
            SQL = SQL & " K3142_PricePurchasingVND,"
            SQL = SQL & " K3142_AmtPurchasingUSD,"
            SQL = SQL & " K3142_AmtPurchasingVND,"
            SQL = SQL & " K3142_selTaxImport,"
            SQL = SQL & " K3142_cdTaxImport,"
            SQL = SQL & " K3142_PerTaxImport,"
            SQL = SQL & " K3142_AmtTaxImport,"
            SQL = SQL & " K3142_selTaxVat,"
            SQL = SQL & " K3142_cdTaxVat,"
            SQL = SQL & " K3142_PerTaxVat,"
            SQL = SQL & " K3142_AmtTaxVat,"
            SQL = SQL & " K3142_DateInBoundMaterial,"
            SQL = SQL & " K3142_BoxInBoundMaterial,"
            SQL = SQL & " K3142_QtyInBoundMaterial,"
            SQL = SQL & " K3142_AmtInBoundMaterial_USD,"
            SQL = SQL & " K3142_AmtInBoundMaterial_VND,"
            SQL = SQL & " K3142_CheckRequestPurchasing,"
            SQL = SQL & " K3142_DateRequestPurchasing,"
            SQL = SQL & " K3142_DateCompletePurchasing,"
            SQL = SQL & " K3142_DateApprovalPurchasing,"
            SQL = SQL & " K3142_DateCancelPurchasing,"
            SQL = SQL & " K3142_CheckComplete,"
            SQL = SQL & " K3142_SalesOrderNo,"
            SQL = SQL & " K3142_SalesOrderSeq,"
            SQL = SQL & " K3142_SalesOrderSno,"
            SQL = SQL & " K3142_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  '" & z3142.RequestPurchasingNo & "', "
            SQL = SQL & "   " & z3142.RequestPurchasingSeq & " , "
            SQL = SQL & "   " & z3142.Dseq & " , "
            SQL = SQL & "  '" & z3142.MaterialCode & "', "
            SQL = SQL & "   " & z3142.BoxRequestPurchasing & " , "
            SQL = SQL & "   " & z3142.QtyRequestPurchasing & " , "
            SQL = SQL & "  '" & z3142.selUnitPriceMaterial & "', "
            SQL = SQL & "  '" & z3142.cdUnitPriceMaterial & "', "
            SQL = SQL & "   " & z3142.PricePurchasing & " , "
            SQL = SQL & "   " & z3142.PricePurchasingUSD & " , "
            SQL = SQL & "   " & z3142.PricePurchasingVND & " , "
            SQL = SQL & "   " & z3142.AmtPurchasingUSD & " , "
            SQL = SQL & "   " & z3142.AmtPurchasingVND & " , "
            SQL = SQL & "  '" & z3142.selTaxImport & "', "
            SQL = SQL & "  '" & z3142.cdTaxImport & "', "
            SQL = SQL & "   " & z3142.PerTaxImport & " , "
            SQL = SQL & "   " & z3142.AmtTaxImport & " , "
            SQL = SQL & "  '" & z3142.selTaxVat & "', "
            SQL = SQL & "  '" & z3142.cdTaxVat & "', "
            SQL = SQL & "   " & z3142.PerTaxVat & " , "
            SQL = SQL & "   " & z3142.AmtTaxVat & " , "
            SQL = SQL & "  '" & z3142.DateInBoundMaterial & "', "
            SQL = SQL & "   " & z3142.BoxInBoundMaterial & " , "
            SQL = SQL & "   " & z3142.QtyInBoundMaterial & " , "
            SQL = SQL & "   " & z3142.AmtInBoundMaterial_USD & " , "
            SQL = SQL & "   " & z3142.AmtInBoundMaterial_VND & " , "
            SQL = SQL & "  '" & z3142.CheckRequestPurchasing & "', "
            SQL = SQL & "  '" & z3142.DateRequestPurchasing & "', "
            SQL = SQL & "  '" & z3142.DateCompletePurchasing & "', "
            SQL = SQL & "  '" & z3142.DateApprovalPurchasing & "', "
            SQL = SQL & "  '" & z3142.DateCancelPurchasing & "', "
            SQL = SQL & "  '" & z3142.CheckComplete & "', "
            SQL = SQL & "  '" & z3142.SalesOrderNo & "', "
            SQL = SQL & "  '" & z3142.SalesOrderSeq & "', "
            SQL = SQL & "  '" & z3142.SalesOrderSno & "', "
            SQL = SQL & "  '" & z3142.Remark & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK3142 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK3142", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK3142(z3142 As T3142_AREA) As Boolean
        REWRITE_PFK3142 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z3142)

            SQL = " UPDATE PFK3142 SET "
            SQL = SQL & "    K3142_Dseq      =  " & z3142.Dseq & " , "
            SQL = SQL & "    K3142_MaterialCode      = '" & z3142.MaterialCode & "', "
            SQL = SQL & "    K3142_BoxRequestPurchasing      =  " & z3142.BoxRequestPurchasing & " , "
            SQL = SQL & "    K3142_QtyRequestPurchasing      =  " & z3142.QtyRequestPurchasing & " , "
            SQL = SQL & "    K3142_selUnitPriceMaterial      = '" & z3142.selUnitPriceMaterial & "', "
            SQL = SQL & "    K3142_cdUnitPriceMaterial      = '" & z3142.cdUnitPriceMaterial & "', "
            SQL = SQL & "    K3142_PricePurchasing      =  " & z3142.PricePurchasing & " , "
            SQL = SQL & "    K3142_PricePurchasingUSD      =  " & z3142.PricePurchasingUSD & " , "
            SQL = SQL & "    K3142_PricePurchasingVND      =  " & z3142.PricePurchasingVND & " , "
            SQL = SQL & "    K3142_AmtPurchasingUSD      =  " & z3142.AmtPurchasingUSD & " , "
            SQL = SQL & "    K3142_AmtPurchasingVND      =  " & z3142.AmtPurchasingVND & " , "
            SQL = SQL & "    K3142_selTaxImport      = '" & z3142.selTaxImport & "', "
            SQL = SQL & "    K3142_cdTaxImport      = '" & z3142.cdTaxImport & "', "
            SQL = SQL & "    K3142_PerTaxImport      =  " & z3142.PerTaxImport & " , "
            SQL = SQL & "    K3142_AmtTaxImport      =  " & z3142.AmtTaxImport & " , "
            SQL = SQL & "    K3142_selTaxVat      = '" & z3142.selTaxVat & "', "
            SQL = SQL & "    K3142_cdTaxVat      = '" & z3142.cdTaxVat & "', "
            SQL = SQL & "    K3142_PerTaxVat      =  " & z3142.PerTaxVat & " , "
            SQL = SQL & "    K3142_AmtTaxVat      =  " & z3142.AmtTaxVat & " , "
            SQL = SQL & "    K3142_DateInBoundMaterial      = '" & z3142.DateInBoundMaterial & "', "
            SQL = SQL & "    K3142_BoxInBoundMaterial      =  " & z3142.BoxInBoundMaterial & " , "
            SQL = SQL & "    K3142_QtyInBoundMaterial      =  " & z3142.QtyInBoundMaterial & " , "
            SQL = SQL & "    K3142_AmtInBoundMaterial_USD      =  " & z3142.AmtInBoundMaterial_USD & " , "
            SQL = SQL & "    K3142_AmtInBoundMaterial_VND      =  " & z3142.AmtInBoundMaterial_VND & " , "
            SQL = SQL & "    K3142_CheckRequestPurchasing      = '" & z3142.CheckRequestPurchasing & "', "
            SQL = SQL & "    K3142_DateRequestPurchasing      = '" & z3142.DateRequestPurchasing & "', "
            SQL = SQL & "    K3142_DateCompletePurchasing      = '" & z3142.DateCompletePurchasing & "', "
            SQL = SQL & "    K3142_DateApprovalPurchasing      = '" & z3142.DateApprovalPurchasing & "', "
            SQL = SQL & "    K3142_DateCancelPurchasing      = '" & z3142.DateCancelPurchasing & "', "
            SQL = SQL & "    K3142_CheckComplete      = '" & z3142.CheckComplete & "', "
            SQL = SQL & "    K3142_SalesOrderNo      = '" & z3142.SalesOrderNo & "', "
            SQL = SQL & "    K3142_SalesOrderSeq      = '" & z3142.SalesOrderSeq & "', "
            SQL = SQL & "    K3142_SalesOrderSno      = '" & z3142.SalesOrderSno & "', "
            SQL = SQL & "    K3142_Remark      = '" & z3142.Remark & "'  "
            SQL = SQL & " WHERE K3142_RequestPurchasingNo		 = '" & z3142.RequestPurchasingNo & "' "
            SQL = SQL & "   AND K3142_RequestPurchasingSeq		 =  " & z3142.RequestPurchasingSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK3142 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK3142", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK3142(z3142 As T3142_AREA) As Boolean
        DELETE_PFK3142 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK3142 "
            SQL = SQL & " WHERE K3142_RequestPurchasingNo		 = '" & z3142.RequestPurchasingNo & "' "
            SQL = SQL & "   AND K3142_RequestPurchasingSeq		 =  " & z3142.RequestPurchasingSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK3142 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK3142", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D3142_CLEAR()
        Try

            D3142.RequestPurchasingNo = ""
            D3142.RequestPurchasingSeq = 0
            D3142.Dseq = 0
            D3142.MaterialCode = ""
            D3142.BoxRequestPurchasing = 0
            D3142.QtyRequestPurchasing = 0
            D3142.selUnitPriceMaterial = ""
            D3142.cdUnitPriceMaterial = ""
            D3142.PricePurchasing = 0
            D3142.PricePurchasingUSD = 0
            D3142.PricePurchasingVND = 0
            D3142.AmtPurchasingUSD = 0
            D3142.AmtPurchasingVND = 0
            D3142.selTaxImport = ""
            D3142.cdTaxImport = ""
            D3142.PerTaxImport = 0
            D3142.AmtTaxImport = 0
            D3142.selTaxVat = ""
            D3142.cdTaxVat = ""
            D3142.PerTaxVat = 0
            D3142.AmtTaxVat = 0
            D3142.DateInBoundMaterial = ""
            D3142.BoxInBoundMaterial = 0
            D3142.QtyInBoundMaterial = 0
            D3142.AmtInBoundMaterial_USD = 0
            D3142.AmtInBoundMaterial_VND = 0
            D3142.CheckRequestPurchasing = ""
            D3142.DateRequestPurchasing = ""
            D3142.DateCompletePurchasing = ""
            D3142.DateApprovalPurchasing = ""
            D3142.DateCancelPurchasing = ""
            D3142.CheckComplete = ""
            D3142.SalesOrderNo = ""
            D3142.SalesOrderSeq = ""
            D3142.SalesOrderSno = ""
            D3142.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D3142_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x3142 As T3142_AREA)
        Try

            x3142.RequestPurchasingNo = trim$(x3142.RequestPurchasingNo)
            x3142.RequestPurchasingSeq = trim$(x3142.RequestPurchasingSeq)
            x3142.Dseq = trim$(x3142.Dseq)
            x3142.MaterialCode = trim$(x3142.MaterialCode)
            x3142.BoxRequestPurchasing = trim$(x3142.BoxRequestPurchasing)
            x3142.QtyRequestPurchasing = trim$(x3142.QtyRequestPurchasing)
            x3142.selUnitPriceMaterial = trim$(x3142.selUnitPriceMaterial)
            x3142.cdUnitPriceMaterial = trim$(x3142.cdUnitPriceMaterial)
            x3142.PricePurchasing = trim$(x3142.PricePurchasing)
            x3142.PricePurchasingUSD = trim$(x3142.PricePurchasingUSD)
            x3142.PricePurchasingVND = trim$(x3142.PricePurchasingVND)
            x3142.AmtPurchasingUSD = trim$(x3142.AmtPurchasingUSD)
            x3142.AmtPurchasingVND = trim$(x3142.AmtPurchasingVND)
            x3142.selTaxImport = trim$(x3142.selTaxImport)
            x3142.cdTaxImport = trim$(x3142.cdTaxImport)
            x3142.PerTaxImport = trim$(x3142.PerTaxImport)
            x3142.AmtTaxImport = trim$(x3142.AmtTaxImport)
            x3142.selTaxVat = trim$(x3142.selTaxVat)
            x3142.cdTaxVat = trim$(x3142.cdTaxVat)
            x3142.PerTaxVat = trim$(x3142.PerTaxVat)
            x3142.AmtTaxVat = trim$(x3142.AmtTaxVat)
            x3142.DateInBoundMaterial = trim$(x3142.DateInBoundMaterial)
            x3142.BoxInBoundMaterial = trim$(x3142.BoxInBoundMaterial)
            x3142.QtyInBoundMaterial = trim$(x3142.QtyInBoundMaterial)
            x3142.AmtInBoundMaterial_USD = trim$(x3142.AmtInBoundMaterial_USD)
            x3142.AmtInBoundMaterial_VND = trim$(x3142.AmtInBoundMaterial_VND)
            x3142.CheckRequestPurchasing = trim$(x3142.CheckRequestPurchasing)
            x3142.DateRequestPurchasing = trim$(x3142.DateRequestPurchasing)
            x3142.DateCompletePurchasing = trim$(x3142.DateCompletePurchasing)
            x3142.DateApprovalPurchasing = trim$(x3142.DateApprovalPurchasing)
            x3142.DateCancelPurchasing = trim$(x3142.DateCancelPurchasing)
            x3142.CheckComplete = trim$(x3142.CheckComplete)
            x3142.SalesOrderNo = trim$(x3142.SalesOrderNo)
            x3142.SalesOrderSeq = trim$(x3142.SalesOrderSeq)
            x3142.SalesOrderSno = trim$(x3142.SalesOrderSno)
            x3142.Remark = trim$(x3142.Remark)

            If trim$(x3142.RequestPurchasingNo) = "" Then x3142.RequestPurchasingNo = Space(1)
            If trim$(x3142.RequestPurchasingSeq) = "" Then x3142.RequestPurchasingSeq = 0
            If trim$(x3142.Dseq) = "" Then x3142.Dseq = 0
            If trim$(x3142.MaterialCode) = "" Then x3142.MaterialCode = Space(1)
            If trim$(x3142.BoxRequestPurchasing) = "" Then x3142.BoxRequestPurchasing = 0
            If trim$(x3142.QtyRequestPurchasing) = "" Then x3142.QtyRequestPurchasing = 0
            If trim$(x3142.selUnitPriceMaterial) = "" Then x3142.selUnitPriceMaterial = Space(1)
            If trim$(x3142.cdUnitPriceMaterial) = "" Then x3142.cdUnitPriceMaterial = Space(1)
            If trim$(x3142.PricePurchasing) = "" Then x3142.PricePurchasing = 0
            If trim$(x3142.PricePurchasingUSD) = "" Then x3142.PricePurchasingUSD = 0
            If trim$(x3142.PricePurchasingVND) = "" Then x3142.PricePurchasingVND = 0
            If trim$(x3142.AmtPurchasingUSD) = "" Then x3142.AmtPurchasingUSD = 0
            If trim$(x3142.AmtPurchasingVND) = "" Then x3142.AmtPurchasingVND = 0
            If trim$(x3142.selTaxImport) = "" Then x3142.selTaxImport = Space(1)
            If trim$(x3142.cdTaxImport) = "" Then x3142.cdTaxImport = Space(1)
            If trim$(x3142.PerTaxImport) = "" Then x3142.PerTaxImport = 0
            If trim$(x3142.AmtTaxImport) = "" Then x3142.AmtTaxImport = 0
            If trim$(x3142.selTaxVat) = "" Then x3142.selTaxVat = Space(1)
            If trim$(x3142.cdTaxVat) = "" Then x3142.cdTaxVat = Space(1)
            If trim$(x3142.PerTaxVat) = "" Then x3142.PerTaxVat = 0
            If trim$(x3142.AmtTaxVat) = "" Then x3142.AmtTaxVat = 0
            If trim$(x3142.DateInBoundMaterial) = "" Then x3142.DateInBoundMaterial = Space(1)
            If trim$(x3142.BoxInBoundMaterial) = "" Then x3142.BoxInBoundMaterial = 0
            If trim$(x3142.QtyInBoundMaterial) = "" Then x3142.QtyInBoundMaterial = 0
            If trim$(x3142.AmtInBoundMaterial_USD) = "" Then x3142.AmtInBoundMaterial_USD = 0
            If trim$(x3142.AmtInBoundMaterial_VND) = "" Then x3142.AmtInBoundMaterial_VND = 0
            If trim$(x3142.CheckRequestPurchasing) = "" Then x3142.CheckRequestPurchasing = Space(1)
            If trim$(x3142.DateRequestPurchasing) = "" Then x3142.DateRequestPurchasing = Space(1)
            If trim$(x3142.DateCompletePurchasing) = "" Then x3142.DateCompletePurchasing = Space(1)
            If trim$(x3142.DateApprovalPurchasing) = "" Then x3142.DateApprovalPurchasing = Space(1)
            If trim$(x3142.DateCancelPurchasing) = "" Then x3142.DateCancelPurchasing = Space(1)
            If trim$(x3142.CheckComplete) = "" Then x3142.CheckComplete = Space(1)
            If trim$(x3142.SalesOrderNo) = "" Then x3142.SalesOrderNo = Space(1)
            If trim$(x3142.SalesOrderSeq) = "" Then x3142.SalesOrderSeq = Space(1)
            If trim$(x3142.SalesOrderSno) = "" Then x3142.SalesOrderSno = Space(1)
            If trim$(x3142.Remark) = "" Then x3142.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K3142_MOVE(rs3142 As SqlClient.SqlDataReader)
        Try

            Call D3142_CLEAR()

            If IsdbNull(rs3142!K3142_RequestPurchasingNo) = False Then D3142.RequestPurchasingNo = Trim$(rs3142!K3142_RequestPurchasingNo)
            If IsdbNull(rs3142!K3142_RequestPurchasingSeq) = False Then D3142.RequestPurchasingSeq = Trim$(rs3142!K3142_RequestPurchasingSeq)
            If IsdbNull(rs3142!K3142_Dseq) = False Then D3142.Dseq = Trim$(rs3142!K3142_Dseq)
            If IsdbNull(rs3142!K3142_MaterialCode) = False Then D3142.MaterialCode = Trim$(rs3142!K3142_MaterialCode)
            If IsdbNull(rs3142!K3142_BoxRequestPurchasing) = False Then D3142.BoxRequestPurchasing = Trim$(rs3142!K3142_BoxRequestPurchasing)
            If IsdbNull(rs3142!K3142_QtyRequestPurchasing) = False Then D3142.QtyRequestPurchasing = Trim$(rs3142!K3142_QtyRequestPurchasing)
            If IsdbNull(rs3142!K3142_selUnitPriceMaterial) = False Then D3142.selUnitPriceMaterial = Trim$(rs3142!K3142_selUnitPriceMaterial)
            If IsdbNull(rs3142!K3142_cdUnitPriceMaterial) = False Then D3142.cdUnitPriceMaterial = Trim$(rs3142!K3142_cdUnitPriceMaterial)
            If IsdbNull(rs3142!K3142_PricePurchasing) = False Then D3142.PricePurchasing = Trim$(rs3142!K3142_PricePurchasing)
            If IsdbNull(rs3142!K3142_PricePurchasingUSD) = False Then D3142.PricePurchasingUSD = Trim$(rs3142!K3142_PricePurchasingUSD)
            If IsdbNull(rs3142!K3142_PricePurchasingVND) = False Then D3142.PricePurchasingVND = Trim$(rs3142!K3142_PricePurchasingVND)
            If IsdbNull(rs3142!K3142_AmtPurchasingUSD) = False Then D3142.AmtPurchasingUSD = Trim$(rs3142!K3142_AmtPurchasingUSD)
            If IsdbNull(rs3142!K3142_AmtPurchasingVND) = False Then D3142.AmtPurchasingVND = Trim$(rs3142!K3142_AmtPurchasingVND)
            If IsdbNull(rs3142!K3142_selTaxImport) = False Then D3142.selTaxImport = Trim$(rs3142!K3142_selTaxImport)
            If IsdbNull(rs3142!K3142_cdTaxImport) = False Then D3142.cdTaxImport = Trim$(rs3142!K3142_cdTaxImport)
            If IsdbNull(rs3142!K3142_PerTaxImport) = False Then D3142.PerTaxImport = Trim$(rs3142!K3142_PerTaxImport)
            If IsdbNull(rs3142!K3142_AmtTaxImport) = False Then D3142.AmtTaxImport = Trim$(rs3142!K3142_AmtTaxImport)
            If IsdbNull(rs3142!K3142_selTaxVat) = False Then D3142.selTaxVat = Trim$(rs3142!K3142_selTaxVat)
            If IsdbNull(rs3142!K3142_cdTaxVat) = False Then D3142.cdTaxVat = Trim$(rs3142!K3142_cdTaxVat)
            If IsdbNull(rs3142!K3142_PerTaxVat) = False Then D3142.PerTaxVat = Trim$(rs3142!K3142_PerTaxVat)
            If IsdbNull(rs3142!K3142_AmtTaxVat) = False Then D3142.AmtTaxVat = Trim$(rs3142!K3142_AmtTaxVat)
            If IsdbNull(rs3142!K3142_DateInBoundMaterial) = False Then D3142.DateInBoundMaterial = Trim$(rs3142!K3142_DateInBoundMaterial)
            If IsdbNull(rs3142!K3142_BoxInBoundMaterial) = False Then D3142.BoxInBoundMaterial = Trim$(rs3142!K3142_BoxInBoundMaterial)
            If IsdbNull(rs3142!K3142_QtyInBoundMaterial) = False Then D3142.QtyInBoundMaterial = Trim$(rs3142!K3142_QtyInBoundMaterial)
            If IsdbNull(rs3142!K3142_AmtInBoundMaterial_USD) = False Then D3142.AmtInBoundMaterial_USD = Trim$(rs3142!K3142_AmtInBoundMaterial_USD)
            If IsdbNull(rs3142!K3142_AmtInBoundMaterial_VND) = False Then D3142.AmtInBoundMaterial_VND = Trim$(rs3142!K3142_AmtInBoundMaterial_VND)
            If IsdbNull(rs3142!K3142_CheckRequestPurchasing) = False Then D3142.CheckRequestPurchasing = Trim$(rs3142!K3142_CheckRequestPurchasing)
            If IsdbNull(rs3142!K3142_DateRequestPurchasing) = False Then D3142.DateRequestPurchasing = Trim$(rs3142!K3142_DateRequestPurchasing)
            If IsdbNull(rs3142!K3142_DateCompletePurchasing) = False Then D3142.DateCompletePurchasing = Trim$(rs3142!K3142_DateCompletePurchasing)
            If IsdbNull(rs3142!K3142_DateApprovalPurchasing) = False Then D3142.DateApprovalPurchasing = Trim$(rs3142!K3142_DateApprovalPurchasing)
            If IsdbNull(rs3142!K3142_DateCancelPurchasing) = False Then D3142.DateCancelPurchasing = Trim$(rs3142!K3142_DateCancelPurchasing)
            If IsdbNull(rs3142!K3142_CheckComplete) = False Then D3142.CheckComplete = Trim$(rs3142!K3142_CheckComplete)
            If IsdbNull(rs3142!K3142_SalesOrderNo) = False Then D3142.SalesOrderNo = Trim$(rs3142!K3142_SalesOrderNo)
            If IsdbNull(rs3142!K3142_SalesOrderSeq) = False Then D3142.SalesOrderSeq = Trim$(rs3142!K3142_SalesOrderSeq)
            If IsdbNull(rs3142!K3142_SalesOrderSno) = False Then D3142.SalesOrderSno = Trim$(rs3142!K3142_SalesOrderSno)
            If IsdbNull(rs3142!K3142_Remark) = False Then D3142.Remark = Trim$(rs3142!K3142_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K3142_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K3142_MOVE(rs3142 As DataRow)
        Try

            Call D3142_CLEAR()

            If IsdbNull(rs3142!K3142_RequestPurchasingNo) = False Then D3142.RequestPurchasingNo = Trim$(rs3142!K3142_RequestPurchasingNo)
            If IsdbNull(rs3142!K3142_RequestPurchasingSeq) = False Then D3142.RequestPurchasingSeq = Trim$(rs3142!K3142_RequestPurchasingSeq)
            If IsdbNull(rs3142!K3142_Dseq) = False Then D3142.Dseq = Trim$(rs3142!K3142_Dseq)
            If IsdbNull(rs3142!K3142_MaterialCode) = False Then D3142.MaterialCode = Trim$(rs3142!K3142_MaterialCode)
            If IsdbNull(rs3142!K3142_BoxRequestPurchasing) = False Then D3142.BoxRequestPurchasing = Trim$(rs3142!K3142_BoxRequestPurchasing)
            If IsdbNull(rs3142!K3142_QtyRequestPurchasing) = False Then D3142.QtyRequestPurchasing = Trim$(rs3142!K3142_QtyRequestPurchasing)
            If IsdbNull(rs3142!K3142_selUnitPriceMaterial) = False Then D3142.selUnitPriceMaterial = Trim$(rs3142!K3142_selUnitPriceMaterial)
            If IsdbNull(rs3142!K3142_cdUnitPriceMaterial) = False Then D3142.cdUnitPriceMaterial = Trim$(rs3142!K3142_cdUnitPriceMaterial)
            If IsdbNull(rs3142!K3142_PricePurchasing) = False Then D3142.PricePurchasing = Trim$(rs3142!K3142_PricePurchasing)
            If IsdbNull(rs3142!K3142_PricePurchasingUSD) = False Then D3142.PricePurchasingUSD = Trim$(rs3142!K3142_PricePurchasingUSD)
            If IsdbNull(rs3142!K3142_PricePurchasingVND) = False Then D3142.PricePurchasingVND = Trim$(rs3142!K3142_PricePurchasingVND)
            If IsdbNull(rs3142!K3142_AmtPurchasingUSD) = False Then D3142.AmtPurchasingUSD = Trim$(rs3142!K3142_AmtPurchasingUSD)
            If IsdbNull(rs3142!K3142_AmtPurchasingVND) = False Then D3142.AmtPurchasingVND = Trim$(rs3142!K3142_AmtPurchasingVND)
            If IsdbNull(rs3142!K3142_selTaxImport) = False Then D3142.selTaxImport = Trim$(rs3142!K3142_selTaxImport)
            If IsdbNull(rs3142!K3142_cdTaxImport) = False Then D3142.cdTaxImport = Trim$(rs3142!K3142_cdTaxImport)
            If IsdbNull(rs3142!K3142_PerTaxImport) = False Then D3142.PerTaxImport = Trim$(rs3142!K3142_PerTaxImport)
            If IsdbNull(rs3142!K3142_AmtTaxImport) = False Then D3142.AmtTaxImport = Trim$(rs3142!K3142_AmtTaxImport)
            If IsdbNull(rs3142!K3142_selTaxVat) = False Then D3142.selTaxVat = Trim$(rs3142!K3142_selTaxVat)
            If IsdbNull(rs3142!K3142_cdTaxVat) = False Then D3142.cdTaxVat = Trim$(rs3142!K3142_cdTaxVat)
            If IsdbNull(rs3142!K3142_PerTaxVat) = False Then D3142.PerTaxVat = Trim$(rs3142!K3142_PerTaxVat)
            If IsdbNull(rs3142!K3142_AmtTaxVat) = False Then D3142.AmtTaxVat = Trim$(rs3142!K3142_AmtTaxVat)
            If IsdbNull(rs3142!K3142_DateInBoundMaterial) = False Then D3142.DateInBoundMaterial = Trim$(rs3142!K3142_DateInBoundMaterial)
            If IsdbNull(rs3142!K3142_BoxInBoundMaterial) = False Then D3142.BoxInBoundMaterial = Trim$(rs3142!K3142_BoxInBoundMaterial)
            If IsdbNull(rs3142!K3142_QtyInBoundMaterial) = False Then D3142.QtyInBoundMaterial = Trim$(rs3142!K3142_QtyInBoundMaterial)
            If IsdbNull(rs3142!K3142_AmtInBoundMaterial_USD) = False Then D3142.AmtInBoundMaterial_USD = Trim$(rs3142!K3142_AmtInBoundMaterial_USD)
            If IsdbNull(rs3142!K3142_AmtInBoundMaterial_VND) = False Then D3142.AmtInBoundMaterial_VND = Trim$(rs3142!K3142_AmtInBoundMaterial_VND)
            If IsdbNull(rs3142!K3142_CheckRequestPurchasing) = False Then D3142.CheckRequestPurchasing = Trim$(rs3142!K3142_CheckRequestPurchasing)
            If IsdbNull(rs3142!K3142_DateRequestPurchasing) = False Then D3142.DateRequestPurchasing = Trim$(rs3142!K3142_DateRequestPurchasing)
            If IsdbNull(rs3142!K3142_DateCompletePurchasing) = False Then D3142.DateCompletePurchasing = Trim$(rs3142!K3142_DateCompletePurchasing)
            If IsdbNull(rs3142!K3142_DateApprovalPurchasing) = False Then D3142.DateApprovalPurchasing = Trim$(rs3142!K3142_DateApprovalPurchasing)
            If IsdbNull(rs3142!K3142_DateCancelPurchasing) = False Then D3142.DateCancelPurchasing = Trim$(rs3142!K3142_DateCancelPurchasing)
            If IsdbNull(rs3142!K3142_CheckComplete) = False Then D3142.CheckComplete = Trim$(rs3142!K3142_CheckComplete)
            If IsdbNull(rs3142!K3142_SalesOrderNo) = False Then D3142.SalesOrderNo = Trim$(rs3142!K3142_SalesOrderNo)
            If IsdbNull(rs3142!K3142_SalesOrderSeq) = False Then D3142.SalesOrderSeq = Trim$(rs3142!K3142_SalesOrderSeq)
            If IsdbNull(rs3142!K3142_SalesOrderSno) = False Then D3142.SalesOrderSno = Trim$(rs3142!K3142_SalesOrderSno)
            If IsdbNull(rs3142!K3142_Remark) = False Then D3142.Remark = Trim$(rs3142!K3142_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K3142_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K3142_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z3142 As T3142_AREA, REQUESTPURCHASINGNO As String, REQUESTPURCHASINGSEQ As Double) As Boolean

        K3142_MOVE = False

        Try
            If READ_PFK3142(REQUESTPURCHASINGNO, REQUESTPURCHASINGSEQ) = True Then
                z3142 = D3142
                K3142_MOVE = True
            Else
                z3142 = Nothing
            End If

            If getColumIndex(spr, "RequestPurchasingNo") > -1 Then z3142.RequestPurchasingNo = getDataM(spr, getColumIndex(spr, "RequestPurchasingNo"), xRow)
            If getColumIndex(spr, "RequestPurchasingSeq") > -1 Then z3142.RequestPurchasingSeq = getDataM(spr, getColumIndex(spr, "RequestPurchasingSeq"), xRow)
            If getColumIndex(spr, "Dseq") > -1 Then z3142.Dseq = getDataM(spr, getColumIndex(spr, "Dseq"), xRow)
            If getColumIndex(spr, "MaterialCode") > -1 Then z3142.MaterialCode = getDataM(spr, getColumIndex(spr, "MaterialCode"), xRow)
            If getColumIndex(spr, "BoxRequestPurchasing") > -1 Then z3142.BoxRequestPurchasing = getDataM(spr, getColumIndex(spr, "BoxRequestPurchasing"), xRow)
            If getColumIndex(spr, "QtyRequestPurchasing") > -1 Then z3142.QtyRequestPurchasing = getDataM(spr, getColumIndex(spr, "QtyRequestPurchasing"), xRow)
            If getColumIndex(spr, "selUnitPriceMaterial") > -1 Then z3142.selUnitPriceMaterial = getDataM(spr, getColumIndex(spr, "selUnitPriceMaterial"), xRow)
            If getColumIndex(spr, "cdUnitPriceMaterial") > -1 Then z3142.cdUnitPriceMaterial = getDataM(spr, getColumIndex(spr, "cdUnitPriceMaterial"), xRow)
            If getColumIndex(spr, "PricePurchasing") > -1 Then z3142.PricePurchasing = getDataM(spr, getColumIndex(spr, "PricePurchasing"), xRow)
            If getColumIndex(spr, "PricePurchasingUSD") > -1 Then z3142.PricePurchasingUSD = getDataM(spr, getColumIndex(spr, "PricePurchasingUSD"), xRow)
            If getColumIndex(spr, "PricePurchasingVND") > -1 Then z3142.PricePurchasingVND = getDataM(spr, getColumIndex(spr, "PricePurchasingVND"), xRow)
            If getColumIndex(spr, "AmtPurchasingUSD") > -1 Then z3142.AmtPurchasingUSD = getDataM(spr, getColumIndex(spr, "AmtPurchasingUSD"), xRow)
            If getColumIndex(spr, "AmtPurchasingVND") > -1 Then z3142.AmtPurchasingVND = getDataM(spr, getColumIndex(spr, "AmtPurchasingVND"), xRow)
            If getColumIndex(spr, "selTaxImport") > -1 Then z3142.selTaxImport = getDataM(spr, getColumIndex(spr, "selTaxImport"), xRow)
            If getColumIndex(spr, "cdTaxImport") > -1 Then z3142.cdTaxImport = getDataM(spr, getColumIndex(spr, "cdTaxImport"), xRow)
            If getColumIndex(spr, "PerTaxImport") > -1 Then z3142.PerTaxImport = getDataM(spr, getColumIndex(spr, "PerTaxImport"), xRow)
            If getColumIndex(spr, "AmtTaxImport") > -1 Then z3142.AmtTaxImport = getDataM(spr, getColumIndex(spr, "AmtTaxImport"), xRow)
            If getColumIndex(spr, "selTaxVat") > -1 Then z3142.selTaxVat = getDataM(spr, getColumIndex(spr, "selTaxVat"), xRow)
            If getColumIndex(spr, "cdTaxVat") > -1 Then z3142.cdTaxVat = getDataM(spr, getColumIndex(spr, "cdTaxVat"), xRow)
            If getColumIndex(spr, "PerTaxVat") > -1 Then z3142.PerTaxVat = getDataM(spr, getColumIndex(spr, "PerTaxVat"), xRow)
            If getColumIndex(spr, "AmtTaxVat") > -1 Then z3142.AmtTaxVat = getDataM(spr, getColumIndex(spr, "AmtTaxVat"), xRow)
            If getColumIndex(spr, "DateInBoundMaterial") > -1 Then z3142.DateInBoundMaterial = getDataM(spr, getColumIndex(spr, "DateInBoundMaterial"), xRow)
            If getColumIndex(spr, "BoxInBoundMaterial") > -1 Then z3142.BoxInBoundMaterial = getDataM(spr, getColumIndex(spr, "BoxInBoundMaterial"), xRow)
            If getColumIndex(spr, "QtyInBoundMaterial") > -1 Then z3142.QtyInBoundMaterial = getDataM(spr, getColumIndex(spr, "QtyInBoundMaterial"), xRow)
            If getColumIndex(spr, "AmtInBoundMaterial_USD") > -1 Then z3142.AmtInBoundMaterial_USD = getDataM(spr, getColumIndex(spr, "AmtInBoundMaterial_USD"), xRow)
            If getColumIndex(spr, "AmtInBoundMaterial_VND") > -1 Then z3142.AmtInBoundMaterial_VND = getDataM(spr, getColumIndex(spr, "AmtInBoundMaterial_VND"), xRow)
            If getColumIndex(spr, "CheckRequestPurchasing") > -1 Then z3142.CheckRequestPurchasing = getDataM(spr, getColumIndex(spr, "CheckRequestPurchasing"), xRow)
            If getColumIndex(spr, "DateRequestPurchasing") > -1 Then z3142.DateRequestPurchasing = getDataM(spr, getColumIndex(spr, "DateRequestPurchasing"), xRow)
            If getColumIndex(spr, "DateCompletePurchasing") > -1 Then z3142.DateCompletePurchasing = getDataM(spr, getColumIndex(spr, "DateCompletePurchasing"), xRow)
            If getColumIndex(spr, "DateApprovalPurchasing") > -1 Then z3142.DateApprovalPurchasing = getDataM(spr, getColumIndex(spr, "DateApprovalPurchasing"), xRow)
            If getColumIndex(spr, "DateCancelPurchasing") > -1 Then z3142.DateCancelPurchasing = getDataM(spr, getColumIndex(spr, "DateCancelPurchasing"), xRow)
            If getColumIndex(spr, "CheckComplete") > -1 Then z3142.CheckComplete = getDataM(spr, getColumIndex(spr, "CheckComplete"), xRow)
            If getColumIndex(spr, "SalesOrderNo") > -1 Then z3142.SalesOrderNo = getDataM(spr, getColumIndex(spr, "SalesOrderNo"), xRow)
            If getColumIndex(spr, "SalesOrderSeq") > -1 Then z3142.SalesOrderSeq = getDataM(spr, getColumIndex(spr, "SalesOrderSeq"), xRow)
            If getColumIndex(spr, "SalesOrderSno") > -1 Then z3142.SalesOrderSno = getDataM(spr, getColumIndex(spr, "SalesOrderSno"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z3142.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3142_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K3142_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z3142 As T3142_AREA, CheckClear As Boolean, REQUESTPURCHASINGNO As String, REQUESTPURCHASINGSEQ As Double) As Boolean

        K3142_MOVE = False

        Try
            If READ_PFK3142(REQUESTPURCHASINGNO, REQUESTPURCHASINGSEQ) = True Then
                z3142 = D3142
                K3142_MOVE = True
            Else
                If CheckClear = True Then z3142 = Nothing
            End If

            If getColumIndex(spr, "RequestPurchasingNo") > -1 Then z3142.RequestPurchasingNo = getDataM(spr, getColumIndex(spr, "RequestPurchasingNo"), xRow)
            If getColumIndex(spr, "RequestPurchasingSeq") > -1 Then z3142.RequestPurchasingSeq = getDataM(spr, getColumIndex(spr, "RequestPurchasingSeq"), xRow)
            If getColumIndex(spr, "Dseq") > -1 Then z3142.Dseq = getDataM(spr, getColumIndex(spr, "Dseq"), xRow)
            If getColumIndex(spr, "MaterialCode") > -1 Then z3142.MaterialCode = getDataM(spr, getColumIndex(spr, "MaterialCode"), xRow)
            If getColumIndex(spr, "BoxRequestPurchasing") > -1 Then z3142.BoxRequestPurchasing = getDataM(spr, getColumIndex(spr, "BoxRequestPurchasing"), xRow)
            If getColumIndex(spr, "QtyRequestPurchasing") > -1 Then z3142.QtyRequestPurchasing = getDataM(spr, getColumIndex(spr, "QtyRequestPurchasing"), xRow)
            If getColumIndex(spr, "selUnitPriceMaterial") > -1 Then z3142.selUnitPriceMaterial = getDataM(spr, getColumIndex(spr, "selUnitPriceMaterial"), xRow)
            If getColumIndex(spr, "cdUnitPriceMaterial") > -1 Then z3142.cdUnitPriceMaterial = getDataM(spr, getColumIndex(spr, "cdUnitPriceMaterial"), xRow)
            If getColumIndex(spr, "PricePurchasing") > -1 Then z3142.PricePurchasing = getDataM(spr, getColumIndex(spr, "PricePurchasing"), xRow)
            If getColumIndex(spr, "PricePurchasingUSD") > -1 Then z3142.PricePurchasingUSD = getDataM(spr, getColumIndex(spr, "PricePurchasingUSD"), xRow)
            If getColumIndex(spr, "PricePurchasingVND") > -1 Then z3142.PricePurchasingVND = getDataM(spr, getColumIndex(spr, "PricePurchasingVND"), xRow)
            If getColumIndex(spr, "AmtPurchasingUSD") > -1 Then z3142.AmtPurchasingUSD = getDataM(spr, getColumIndex(spr, "AmtPurchasingUSD"), xRow)
            If getColumIndex(spr, "AmtPurchasingVND") > -1 Then z3142.AmtPurchasingVND = getDataM(spr, getColumIndex(spr, "AmtPurchasingVND"), xRow)
            If getColumIndex(spr, "selTaxImport") > -1 Then z3142.selTaxImport = getDataM(spr, getColumIndex(spr, "selTaxImport"), xRow)
            If getColumIndex(spr, "cdTaxImport") > -1 Then z3142.cdTaxImport = getDataM(spr, getColumIndex(spr, "cdTaxImport"), xRow)
            If getColumIndex(spr, "PerTaxImport") > -1 Then z3142.PerTaxImport = getDataM(spr, getColumIndex(spr, "PerTaxImport"), xRow)
            If getColumIndex(spr, "AmtTaxImport") > -1 Then z3142.AmtTaxImport = getDataM(spr, getColumIndex(spr, "AmtTaxImport"), xRow)
            If getColumIndex(spr, "selTaxVat") > -1 Then z3142.selTaxVat = getDataM(spr, getColumIndex(spr, "selTaxVat"), xRow)
            If getColumIndex(spr, "cdTaxVat") > -1 Then z3142.cdTaxVat = getDataM(spr, getColumIndex(spr, "cdTaxVat"), xRow)
            If getColumIndex(spr, "PerTaxVat") > -1 Then z3142.PerTaxVat = getDataM(spr, getColumIndex(spr, "PerTaxVat"), xRow)
            If getColumIndex(spr, "AmtTaxVat") > -1 Then z3142.AmtTaxVat = getDataM(spr, getColumIndex(spr, "AmtTaxVat"), xRow)
            If getColumIndex(spr, "DateInBoundMaterial") > -1 Then z3142.DateInBoundMaterial = getDataM(spr, getColumIndex(spr, "DateInBoundMaterial"), xRow)
            If getColumIndex(spr, "BoxInBoundMaterial") > -1 Then z3142.BoxInBoundMaterial = getDataM(spr, getColumIndex(spr, "BoxInBoundMaterial"), xRow)
            If getColumIndex(spr, "QtyInBoundMaterial") > -1 Then z3142.QtyInBoundMaterial = getDataM(spr, getColumIndex(spr, "QtyInBoundMaterial"), xRow)
            If getColumIndex(spr, "AmtInBoundMaterial_USD") > -1 Then z3142.AmtInBoundMaterial_USD = getDataM(spr, getColumIndex(spr, "AmtInBoundMaterial_USD"), xRow)
            If getColumIndex(spr, "AmtInBoundMaterial_VND") > -1 Then z3142.AmtInBoundMaterial_VND = getDataM(spr, getColumIndex(spr, "AmtInBoundMaterial_VND"), xRow)
            If getColumIndex(spr, "CheckRequestPurchasing") > -1 Then z3142.CheckRequestPurchasing = getDataM(spr, getColumIndex(spr, "CheckRequestPurchasing"), xRow)
            If getColumIndex(spr, "DateRequestPurchasing") > -1 Then z3142.DateRequestPurchasing = getDataM(spr, getColumIndex(spr, "DateRequestPurchasing"), xRow)
            If getColumIndex(spr, "DateCompletePurchasing") > -1 Then z3142.DateCompletePurchasing = getDataM(spr, getColumIndex(spr, "DateCompletePurchasing"), xRow)
            If getColumIndex(spr, "DateApprovalPurchasing") > -1 Then z3142.DateApprovalPurchasing = getDataM(spr, getColumIndex(spr, "DateApprovalPurchasing"), xRow)
            If getColumIndex(spr, "DateCancelPurchasing") > -1 Then z3142.DateCancelPurchasing = getDataM(spr, getColumIndex(spr, "DateCancelPurchasing"), xRow)
            If getColumIndex(spr, "CheckComplete") > -1 Then z3142.CheckComplete = getDataM(spr, getColumIndex(spr, "CheckComplete"), xRow)
            If getColumIndex(spr, "SalesOrderNo") > -1 Then z3142.SalesOrderNo = getDataM(spr, getColumIndex(spr, "SalesOrderNo"), xRow)
            If getColumIndex(spr, "SalesOrderSeq") > -1 Then z3142.SalesOrderSeq = getDataM(spr, getColumIndex(spr, "SalesOrderSeq"), xRow)
            If getColumIndex(spr, "SalesOrderSno") > -1 Then z3142.SalesOrderSno = getDataM(spr, getColumIndex(spr, "SalesOrderSno"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z3142.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3142_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K3142_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z3142 As T3142_AREA, Job As String, REQUESTPURCHASINGNO As String, REQUESTPURCHASINGSEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K3142_MOVE = False

        Try
            If READ_PFK3142(REQUESTPURCHASINGNO, REQUESTPURCHASINGSEQ) = True Then
                z3142 = D3142
                K3142_MOVE = True
            Else
                z3142 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3142")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "RequestPurchasingNo" : z3142.RequestPurchasingNo = Children(i).Code
                                Case "RequestPurchasingSeq" : z3142.RequestPurchasingSeq = Children(i).Code
                                Case "Dseq" : z3142.Dseq = Children(i).Code
                                Case "MaterialCode" : z3142.MaterialCode = Children(i).Code
                                Case "BoxRequestPurchasing" : z3142.BoxRequestPurchasing = Children(i).Code
                                Case "QtyRequestPurchasing" : z3142.QtyRequestPurchasing = Children(i).Code
                                Case "selUnitPriceMaterial" : z3142.selUnitPriceMaterial = Children(i).Code
                                Case "cdUnitPriceMaterial" : z3142.cdUnitPriceMaterial = Children(i).Code
                                Case "PricePurchasing" : z3142.PricePurchasing = Children(i).Code
                                Case "PricePurchasingUSD" : z3142.PricePurchasingUSD = Children(i).Code
                                Case "PricePurchasingVND" : z3142.PricePurchasingVND = Children(i).Code
                                Case "AmtPurchasingUSD" : z3142.AmtPurchasingUSD = Children(i).Code
                                Case "AmtPurchasingVND" : z3142.AmtPurchasingVND = Children(i).Code
                                Case "selTaxImport" : z3142.selTaxImport = Children(i).Code
                                Case "cdTaxImport" : z3142.cdTaxImport = Children(i).Code
                                Case "PerTaxImport" : z3142.PerTaxImport = Children(i).Code
                                Case "AmtTaxImport" : z3142.AmtTaxImport = Children(i).Code
                                Case "selTaxVat" : z3142.selTaxVat = Children(i).Code
                                Case "cdTaxVat" : z3142.cdTaxVat = Children(i).Code
                                Case "PerTaxVat" : z3142.PerTaxVat = Children(i).Code
                                Case "AmtTaxVat" : z3142.AmtTaxVat = Children(i).Code
                                Case "DateInBoundMaterial" : z3142.DateInBoundMaterial = Children(i).Code
                                Case "BoxInBoundMaterial" : z3142.BoxInBoundMaterial = Children(i).Code
                                Case "QtyInBoundMaterial" : z3142.QtyInBoundMaterial = Children(i).Code
                                Case "AmtInBoundMaterial_USD" : z3142.AmtInBoundMaterial_USD = Children(i).Code
                                Case "AmtInBoundMaterial_VND" : z3142.AmtInBoundMaterial_VND = Children(i).Code
                                Case "CheckRequestPurchasing" : z3142.CheckRequestPurchasing = Children(i).Code
                                Case "DateRequestPurchasing" : z3142.DateRequestPurchasing = Children(i).Code
                                Case "DateCompletePurchasing" : z3142.DateCompletePurchasing = Children(i).Code
                                Case "DateApprovalPurchasing" : z3142.DateApprovalPurchasing = Children(i).Code
                                Case "DateCancelPurchasing" : z3142.DateCancelPurchasing = Children(i).Code
                                Case "CheckComplete" : z3142.CheckComplete = Children(i).Code
                                Case "SalesOrderNo" : z3142.SalesOrderNo = Children(i).Code
                                Case "SalesOrderSeq" : z3142.SalesOrderSeq = Children(i).Code
                                Case "SalesOrderSno" : z3142.SalesOrderSno = Children(i).Code
                                Case "Remark" : z3142.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "RequestPurchasingNo" : z3142.RequestPurchasingNo = Children(i).Data
                                Case "RequestPurchasingSeq" : z3142.RequestPurchasingSeq = Children(i).Data
                                Case "Dseq" : z3142.Dseq = Children(i).Data
                                Case "MaterialCode" : z3142.MaterialCode = Children(i).Data
                                Case "BoxRequestPurchasing" : z3142.BoxRequestPurchasing = Children(i).Data
                                Case "QtyRequestPurchasing" : z3142.QtyRequestPurchasing = Children(i).Data
                                Case "selUnitPriceMaterial" : z3142.selUnitPriceMaterial = Children(i).Data
                                Case "cdUnitPriceMaterial" : z3142.cdUnitPriceMaterial = Children(i).Data
                                Case "PricePurchasing" : z3142.PricePurchasing = Children(i).Data
                                Case "PricePurchasingUSD" : z3142.PricePurchasingUSD = Children(i).Data
                                Case "PricePurchasingVND" : z3142.PricePurchasingVND = Children(i).Data
                                Case "AmtPurchasingUSD" : z3142.AmtPurchasingUSD = Children(i).Data
                                Case "AmtPurchasingVND" : z3142.AmtPurchasingVND = Children(i).Data
                                Case "selTaxImport" : z3142.selTaxImport = Children(i).Data
                                Case "cdTaxImport" : z3142.cdTaxImport = Children(i).Data
                                Case "PerTaxImport" : z3142.PerTaxImport = Children(i).Data
                                Case "AmtTaxImport" : z3142.AmtTaxImport = Children(i).Data
                                Case "selTaxVat" : z3142.selTaxVat = Children(i).Data
                                Case "cdTaxVat" : z3142.cdTaxVat = Children(i).Data
                                Case "PerTaxVat" : z3142.PerTaxVat = Children(i).Data
                                Case "AmtTaxVat" : z3142.AmtTaxVat = Children(i).Data
                                Case "DateInBoundMaterial" : z3142.DateInBoundMaterial = Children(i).Data
                                Case "BoxInBoundMaterial" : z3142.BoxInBoundMaterial = Children(i).Data
                                Case "QtyInBoundMaterial" : z3142.QtyInBoundMaterial = Children(i).Data
                                Case "AmtInBoundMaterial_USD" : z3142.AmtInBoundMaterial_USD = Children(i).Data
                                Case "AmtInBoundMaterial_VND" : z3142.AmtInBoundMaterial_VND = Children(i).Data
                                Case "CheckRequestPurchasing" : z3142.CheckRequestPurchasing = Children(i).Data
                                Case "DateRequestPurchasing" : z3142.DateRequestPurchasing = Children(i).Data
                                Case "DateCompletePurchasing" : z3142.DateCompletePurchasing = Children(i).Data
                                Case "DateApprovalPurchasing" : z3142.DateApprovalPurchasing = Children(i).Data
                                Case "DateCancelPurchasing" : z3142.DateCancelPurchasing = Children(i).Data
                                Case "CheckComplete" : z3142.CheckComplete = Children(i).Data
                                Case "SalesOrderNo" : z3142.SalesOrderNo = Children(i).Data
                                Case "SalesOrderSeq" : z3142.SalesOrderSeq = Children(i).Data
                                Case "SalesOrderSno" : z3142.SalesOrderSno = Children(i).Data
                                Case "Remark" : z3142.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3142_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K3142_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z3142 As T3142_AREA, Job As String, CheckClear As Boolean, REQUESTPURCHASINGNO As String, REQUESTPURCHASINGSEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K3142_MOVE = False

        Try
            If READ_PFK3142(REQUESTPURCHASINGNO, REQUESTPURCHASINGSEQ) = True Then
                z3142 = D3142
                K3142_MOVE = True
            Else
                If CheckClear = True Then z3142 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3142")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "RequestPurchasingNo" : z3142.RequestPurchasingNo = Children(i).Code
                                Case "RequestPurchasingSeq" : z3142.RequestPurchasingSeq = Children(i).Code
                                Case "Dseq" : z3142.Dseq = Children(i).Code
                                Case "MaterialCode" : z3142.MaterialCode = Children(i).Code
                                Case "BoxRequestPurchasing" : z3142.BoxRequestPurchasing = Children(i).Code
                                Case "QtyRequestPurchasing" : z3142.QtyRequestPurchasing = Children(i).Code
                                Case "selUnitPriceMaterial" : z3142.selUnitPriceMaterial = Children(i).Code
                                Case "cdUnitPriceMaterial" : z3142.cdUnitPriceMaterial = Children(i).Code
                                Case "PricePurchasing" : z3142.PricePurchasing = Children(i).Code
                                Case "PricePurchasingUSD" : z3142.PricePurchasingUSD = Children(i).Code
                                Case "PricePurchasingVND" : z3142.PricePurchasingVND = Children(i).Code
                                Case "AmtPurchasingUSD" : z3142.AmtPurchasingUSD = Children(i).Code
                                Case "AmtPurchasingVND" : z3142.AmtPurchasingVND = Children(i).Code
                                Case "selTaxImport" : z3142.selTaxImport = Children(i).Code
                                Case "cdTaxImport" : z3142.cdTaxImport = Children(i).Code
                                Case "PerTaxImport" : z3142.PerTaxImport = Children(i).Code
                                Case "AmtTaxImport" : z3142.AmtTaxImport = Children(i).Code
                                Case "selTaxVat" : z3142.selTaxVat = Children(i).Code
                                Case "cdTaxVat" : z3142.cdTaxVat = Children(i).Code
                                Case "PerTaxVat" : z3142.PerTaxVat = Children(i).Code
                                Case "AmtTaxVat" : z3142.AmtTaxVat = Children(i).Code
                                Case "DateInBoundMaterial" : z3142.DateInBoundMaterial = Children(i).Code
                                Case "BoxInBoundMaterial" : z3142.BoxInBoundMaterial = Children(i).Code
                                Case "QtyInBoundMaterial" : z3142.QtyInBoundMaterial = Children(i).Code
                                Case "AmtInBoundMaterial_USD" : z3142.AmtInBoundMaterial_USD = Children(i).Code
                                Case "AmtInBoundMaterial_VND" : z3142.AmtInBoundMaterial_VND = Children(i).Code
                                Case "CheckRequestPurchasing" : z3142.CheckRequestPurchasing = Children(i).Code
                                Case "DateRequestPurchasing" : z3142.DateRequestPurchasing = Children(i).Code
                                Case "DateCompletePurchasing" : z3142.DateCompletePurchasing = Children(i).Code
                                Case "DateApprovalPurchasing" : z3142.DateApprovalPurchasing = Children(i).Code
                                Case "DateCancelPurchasing" : z3142.DateCancelPurchasing = Children(i).Code
                                Case "CheckComplete" : z3142.CheckComplete = Children(i).Code
                                Case "SalesOrderNo" : z3142.SalesOrderNo = Children(i).Code
                                Case "SalesOrderSeq" : z3142.SalesOrderSeq = Children(i).Code
                                Case "SalesOrderSno" : z3142.SalesOrderSno = Children(i).Code
                                Case "Remark" : z3142.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "RequestPurchasingNo" : z3142.RequestPurchasingNo = Children(i).Data
                                Case "RequestPurchasingSeq" : z3142.RequestPurchasingSeq = Children(i).Data
                                Case "Dseq" : z3142.Dseq = Children(i).Data
                                Case "MaterialCode" : z3142.MaterialCode = Children(i).Data
                                Case "BoxRequestPurchasing" : z3142.BoxRequestPurchasing = Children(i).Data
                                Case "QtyRequestPurchasing" : z3142.QtyRequestPurchasing = Children(i).Data
                                Case "selUnitPriceMaterial" : z3142.selUnitPriceMaterial = Children(i).Data
                                Case "cdUnitPriceMaterial" : z3142.cdUnitPriceMaterial = Children(i).Data
                                Case "PricePurchasing" : z3142.PricePurchasing = Children(i).Data
                                Case "PricePurchasingUSD" : z3142.PricePurchasingUSD = Children(i).Data
                                Case "PricePurchasingVND" : z3142.PricePurchasingVND = Children(i).Data
                                Case "AmtPurchasingUSD" : z3142.AmtPurchasingUSD = Children(i).Data
                                Case "AmtPurchasingVND" : z3142.AmtPurchasingVND = Children(i).Data
                                Case "selTaxImport" : z3142.selTaxImport = Children(i).Data
                                Case "cdTaxImport" : z3142.cdTaxImport = Children(i).Data
                                Case "PerTaxImport" : z3142.PerTaxImport = Children(i).Data
                                Case "AmtTaxImport" : z3142.AmtTaxImport = Children(i).Data
                                Case "selTaxVat" : z3142.selTaxVat = Children(i).Data
                                Case "cdTaxVat" : z3142.cdTaxVat = Children(i).Data
                                Case "PerTaxVat" : z3142.PerTaxVat = Children(i).Data
                                Case "AmtTaxVat" : z3142.AmtTaxVat = Children(i).Data
                                Case "DateInBoundMaterial" : z3142.DateInBoundMaterial = Children(i).Data
                                Case "BoxInBoundMaterial" : z3142.BoxInBoundMaterial = Children(i).Data
                                Case "QtyInBoundMaterial" : z3142.QtyInBoundMaterial = Children(i).Data
                                Case "AmtInBoundMaterial_USD" : z3142.AmtInBoundMaterial_USD = Children(i).Data
                                Case "AmtInBoundMaterial_VND" : z3142.AmtInBoundMaterial_VND = Children(i).Data
                                Case "CheckRequestPurchasing" : z3142.CheckRequestPurchasing = Children(i).Data
                                Case "DateRequestPurchasing" : z3142.DateRequestPurchasing = Children(i).Data
                                Case "DateCompletePurchasing" : z3142.DateCompletePurchasing = Children(i).Data
                                Case "DateApprovalPurchasing" : z3142.DateApprovalPurchasing = Children(i).Data
                                Case "DateCancelPurchasing" : z3142.DateCancelPurchasing = Children(i).Data
                                Case "CheckComplete" : z3142.CheckComplete = Children(i).Data
                                Case "SalesOrderNo" : z3142.SalesOrderNo = Children(i).Data
                                Case "SalesOrderSeq" : z3142.SalesOrderSeq = Children(i).Data
                                Case "SalesOrderSno" : z3142.SalesOrderSno = Children(i).Data
                                Case "Remark" : z3142.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3142_MOVE", vbCritical)
        End Try
    End Function

End Module
