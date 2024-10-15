'=========================================================================================================================================================
'   TABLE : (PFK3011)
'
'      WORKER : PSM GLOBAL ., LTD
'       WORK DATE : 2019 NEW
'       DEVELOPER    : MRNLV
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K3011

    Structure T3011_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public Autokey As Double  '			decimal		*
        Public KindRevise As Double  '			decimal
        Public seSeason As String  '			char(3)
        Public cdSeason As String  '			char(3)
        Public OrderNo As String  '			char(9)
        Public OrderNoSeq As String  '			char(3)
        Public MaterialCodeBase As String  '			char(6)
        Public Materialcode As String  '			char(6)
        Public Description As String  '			nvarchar(50)
        Public Color As String  '			nvarchar(200)
        Public ColorCode As String  '			nvarchar(50)
        Public SizeNo As String  '			char(2)
        Public Specification As String  '			nvarchar(20)
        Public Width As String  '			nvarchar(20)
        Public Height As String  '			nvarchar(20)
        Public SizeName As String  '			nvarchar(100)
        Public ColorName As String  '			nvarchar(200)
        Public MaterialCheck As String  '			char(1)
        Public seShoesStatus As String  '			char(3)
        Public cdShoesStatus As String  '			char(3)
        Public seDepartment As String  '			char(3)
        Public cdDepartment As String  '			char(3)
        Public SupplierCode As String  '			char(6)
        Public MaterialPrice As Double  '			decimal
        Public seUnitPrice As String  '			char(3)
        Public cdUnitPrice As String  '			char(3)
        Public QtySales As Double  '			decimal
        Public QtySalesSample As Double  '			decimal
        Public GrossUsage As Double  '			decimal
        Public TotalQty As Double  '			decimal
        Public QtyOrder As Double  '			decimal
        Public QtyAdjust As Double  '			decimal
        Public QtyBooking As Double  '			decimal
        Public QtyBooking1 As Double  '			decimal
        Public QtyBooking2 As Double  '			decimal
        Public QtyRequest As Double  '			decimal
        Public QtyPurchasing As Double  '			decimal
        Public QtySizebySize As Double  '			decimal
        Public seUnitMaterial As String  '			char(3)
        Public cdUnitMaterial As String  '			char(3)
        Public InchargeRequest As String  '			char(8)
        Public PRNo As String  '			nvarchar(9)
        Public PRNoSeq As String  '			char(3)
        Public CustomerCode As String  '			char(6)
        Public PRName As String  '			nvarchar(50)
        Public PurchasingOrderNo As String  '			char(9)
        Public PurchasingOrderSeq As Double  '			decimal
        Public CheckOrderMaterial As String  '			char(1)
        Public CheckAdjust As String  '			char(1)
        Public CheckGZ As String  '			char(1)
        Public DateAdjust As String  '			char(8)
        Public DateDelivery As String  '			char(8)
        Public DateOrderMaterialAccept As String  '			char(8)
        Public DateOrderMaterialComplete As String  '			char(8)
        Public DateOrderMaterialApproval As String  '			char(8)
        Public DateOrderMaterialCancel As String  '			char(8)
        Public TimeInsert As String  '			char(14)
        Public TimeUpdate As String  '			char(14)
        Public DateUpdate As String  '			char(8)
        Public DateInsert As String  '			char(8)
        Public DateUdate As String  '			char(8)
        Public InchargeInsert As String  '			char(8)
        Public InchargeUpdate As String  '			char(8)
        Public DateExcel As String  '			char(8)
        Public PriceAPurchasing As Double  '			decimal
        Public cdUnitMaterialA As String  '			char(3)
        Public cdUnitPriceA As String  '			char(3)
        Public QtyAPurchasing As Double  '			decimal
        Public QtyATotal As Double  '			decimal
        Public AmtAPurchasing As Double  '			decimal
        Public AmtATotal As Double  '			decimal
        Public DateArrive1 As String  '			char(8)
        Public DateArrive2 As String  '			char(8)
        Public DateArrive3 As String  '			char(8)
        Public DateArrive4 As String  '			char(8)
        Public DateArrive5 As String  '			char(8)
        Public QtyAArrive1 As Double  '			decimal
        Public QtyAArrive2 As Double  '			decimal
        Public QtyAArrive3 As Double  '			decimal
        Public QtyAArrive4 As Double  '			decimal
        Public QtyAArrive5 As Double  '			decimal
        Public InchargeInvoice As String  '		char(8)
        Public APLName As String  '			    nvarchar(200)
        Public AInvoice As String  '			nvarchar(200)
        Public ARemark As String  '			    nvarchar(200)
        Public Remark As String  '			    nvarchar(200)
        Public RemarkLine As String  '			nvarchar(200)
        Public RemarkMOQ As String  '			nvarchar(200)

        Public QANote1 As String  '			    nvarchar(50)
        Public QANote2 As String  '			    nvarchar(50)
        Public QANote3 As String  '			    nvarchar(50)
        Public QANote4 As String  '			    nvarchar(50)
        Public QANote5 As String  '			    nvarchar(50)
        Public QANote As String  '			    nvarchar(50)

        Public seSite As String  '			char(3)
        Public cdSite As String  '			char(3)
        '=========================================================================================================================================================
    End Structure

    Public D3011 As T3011_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK3011(AUTOKEY As Double) As Boolean
        READ_PFK3011 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3011 "
            SQL = SQL & " WHERE K3011_Autokey		 =  " & Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D3011_CLEAR() : GoTo SKIP_READ_PFK3011

            Call K3011_MOVE(rd)
            READ_PFK3011 = True

SKIP_READ_PFK3011:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK3011", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK3011(AUTOKEY As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3011 "
            SQL = SQL & " WHERE K3011_Autokey		 =  " & Autokey & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK3011", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK3011(z3011 As T3011_AREA) As Boolean
        WRITE_PFK3011 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z3011)

            SQL = " INSERT INTO PFK3011 "
            SQL = SQL & " ( "

            SQL = SQL & " K3011_KindRevise,"
            SQL = SQL & " K3011_seSeason,"
            SQL = SQL & " K3011_cdSeason,"
            SQL = SQL & " K3011_OrderNo,"
            SQL = SQL & " K3011_OrderNoSeq,"
            SQL = SQL & " K3011_MaterialCodeBase,"
            SQL = SQL & " K3011_Materialcode,"
            SQL = SQL & " K3011_Description,"
            SQL = SQL & " K3011_Color,"
            SQL = SQL & " K3011_ColorCode,"
            SQL = SQL & " K3011_SizeNo,"
            SQL = SQL & " K3011_Specification,"
            SQL = SQL & " K3011_Width,"
            SQL = SQL & " K3011_Height,"
            SQL = SQL & " K3011_SizeName,"
            SQL = SQL & " K3011_ColorName,"
            SQL = SQL & " K3011_MaterialCheck,"
            SQL = SQL & " K3011_seShoesStatus,"
            SQL = SQL & " K3011_cdShoesStatus,"
            SQL = SQL & " K3011_seDepartment,"
            SQL = SQL & " K3011_cdDepartment,"
            SQL = SQL & " K3011_SupplierCode,"
            SQL = SQL & " K3011_MaterialPrice,"
            SQL = SQL & " K3011_seUnitPrice,"
            SQL = SQL & " K3011_cdUnitPrice,"
            SQL = SQL & " K3011_QtySales,"
            SQL = SQL & " K3011_QtySalesSample,"
            SQL = SQL & " K3011_GrossUsage,"
            SQL = SQL & " K3011_TotalQty,"
            SQL = SQL & " K3011_QtyOrder,"
            SQL = SQL & " K3011_QtyAdjust,"
            SQL = SQL & " K3011_QtyBooking,"
            SQL = SQL & " K3011_QtyBooking1,"
            SQL = SQL & " K3011_QtyBooking2,"
            SQL = SQL & " K3011_QtyRequest,"
            SQL = SQL & " K3011_QtyPurchasing,"
            SQL = SQL & " K3011_QtySizebySize,"
            SQL = SQL & " K3011_seUnitMaterial,"
            SQL = SQL & " K3011_cdUnitMaterial,"
            SQL = SQL & " K3011_InchargeRequest,"
            SQL = SQL & " K3011_PRNo,"
            SQL = SQL & " K3011_PRNoSeq,"
            SQL = SQL & " K3011_CustomerCode,"
            SQL = SQL & " K3011_PRName,"
            SQL = SQL & " K3011_PurchasingOrderNo,"
            SQL = SQL & " K3011_PurchasingOrderSeq,"
            SQL = SQL & " K3011_CheckOrderMaterial,"
            SQL = SQL & " K3011_CheckAdjust,"
            SQL = SQL & " K3011_CheckGZ,"
            SQL = SQL & " K3011_DateAdjust,"
            SQL = SQL & " K3011_DateDelivery,"
            SQL = SQL & " K3011_DateOrderMaterialAccept,"
            SQL = SQL & " K3011_DateOrderMaterialComplete,"
            SQL = SQL & " K3011_DateOrderMaterialApproval,"
            SQL = SQL & " K3011_DateOrderMaterialCancel,"
            SQL = SQL & " K3011_TimeInsert,"
            SQL = SQL & " K3011_TimeUpdate,"
            SQL = SQL & " K3011_DateUpdate,"
            SQL = SQL & " K3011_DateInsert,"
            SQL = SQL & " K3011_DateUdate,"
            SQL = SQL & " K3011_InchargeInsert,"
            SQL = SQL & " K3011_InchargeUpdate,"
            SQL = SQL & " K3011_DateExcel,"
            SQL = SQL & " K3011_PriceAPurchasing,"
            SQL = SQL & " K3011_cdUnitMaterialA,"
            SQL = SQL & " K3011_cdUnitPriceA,"
            SQL = SQL & " K3011_QtyAPurchasing,"
            SQL = SQL & " K3011_QtyATotal,"
            SQL = SQL & " K3011_AmtAPurchasing,"
            SQL = SQL & " K3011_AmtATotal,"
            SQL = SQL & " K3011_DateArrive1,"
            SQL = SQL & " K3011_DateArrive2,"
            SQL = SQL & " K3011_DateArrive3,"
            SQL = SQL & " K3011_DateArrive4,"
            SQL = SQL & " K3011_DateArrive5,"
            SQL = SQL & " K3011_QtyAArrive1,"
            SQL = SQL & " K3011_QtyAArrive2,"
            SQL = SQL & " K3011_QtyAArrive3,"
            SQL = SQL & " K3011_QtyAArrive4,"
            SQL = SQL & " K3011_QtyAArrive5,"
            SQL = SQL & " K3011_InchargeInvoice,"
            SQL = SQL & " K3011_APLName,"
            SQL = SQL & " K3011_AInvoice,"
            SQL = SQL & " K3011_ARemark,"
            SQL = SQL & " K3011_Remark,"
            SQL = SQL & " K3011_RemarkLine,"
            SQL = SQL & " K3011_RemarkMOQ,"
            SQL = SQL & " K3011_QANote1,"
            SQL = SQL & " K3011_QANote2,"
            SQL = SQL & " K3011_QANote3,"
            SQL = SQL & " K3011_QANote,"
            SQL = SQL & " K3011_seSite,"
            SQL = SQL & " K3011_cdSite "
            SQL = SQL & " ) VALUES ( "

            SQL = SQL & "   " & FormatSQL(z3011.KindRevise) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3011.seSeason) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.cdSeason) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.OrderNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.OrderNoSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.MaterialCodeBase) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.Materialcode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.Description) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.Color) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.ColorCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.SizeNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.Specification) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.Width) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.Height) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.SizeName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.ColorName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.MaterialCheck) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.seShoesStatus) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.cdShoesStatus) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.seDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.cdDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.SupplierCode) & "', "
            SQL = SQL & "   " & FormatSQL(z3011.MaterialPrice) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3011.seUnitPrice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.cdUnitPrice) & "', "
            SQL = SQL & "   " & FormatSQL(z3011.QtySales) & ", "
            SQL = SQL & "   " & FormatSQL(z3011.QtySalesSample) & ", "
            SQL = SQL & "   " & FormatSQL(z3011.GrossUsage) & ", "
            SQL = SQL & "   " & FormatSQL(z3011.TotalQty) & ", "
            SQL = SQL & "   " & FormatSQL(z3011.QtyOrder) & ", "
            SQL = SQL & "   " & FormatSQL(z3011.QtyAdjust) & ", "
            SQL = SQL & "   " & FormatSQL(z3011.QtyBooking) & ", "
            SQL = SQL & "   " & FormatSQL(z3011.QtyBooking1) & ", "
            SQL = SQL & "   " & FormatSQL(z3011.QtyBooking2) & ", "
            SQL = SQL & "   " & FormatSQL(z3011.QtyRequest) & ", "
            SQL = SQL & "   " & FormatSQL(z3011.QtyPurchasing) & ", "
            SQL = SQL & "   " & FormatSQL(z3011.QtySizebySize) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3011.seUnitMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.cdUnitMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.InchargeRequest) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.PRNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.PRNoSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.CustomerCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.PRName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.PurchasingOrderNo) & "', "
            SQL = SQL & "   " & FormatSQL(z3011.PurchasingOrderSeq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3011.CheckOrderMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.CheckAdjust) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.CheckGZ) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.DateAdjust) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.DateDelivery) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.DateOrderMaterialAccept) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.DateOrderMaterialComplete) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.DateOrderMaterialApproval) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.DateOrderMaterialCancel) & "', "
            SQL = SQL & "  N'" & FormatSQL(PUB.TIME) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.TimeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.DateUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(PUB.DAT) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.DateUdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(PUB.SAW) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.InchargeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.DateExcel) & "', "
            SQL = SQL & "   " & FormatSQL(z3011.PriceAPurchasing) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3011.cdUnitMaterialA) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.cdUnitPriceA) & "', "
            SQL = SQL & "   " & FormatSQL(z3011.QtyAPurchasing) & ", "
            SQL = SQL & "   " & FormatSQL(z3011.QtyATotal) & ", "
            SQL = SQL & "   " & FormatSQL(z3011.AmtAPurchasing) & ", "
            SQL = SQL & "   " & FormatSQL(z3011.AmtATotal) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3011.DateArrive1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.DateArrive2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.DateArrive3) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.DateArrive4) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.DateArrive5) & "', "
            SQL = SQL & "   " & FormatSQL(z3011.QtyAArrive1) & ", "
            SQL = SQL & "   " & FormatSQL(z3011.QtyAArrive2) & ", "
            SQL = SQL & "   " & FormatSQL(z3011.QtyAArrive3) & ", "
            SQL = SQL & "   " & FormatSQL(z3011.QtyAArrive4) & ", "
            SQL = SQL & "   " & FormatSQL(z3011.QtyAArrive5) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3011.InchargeInvoice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.APLName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.AInvoice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.ARemark) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.Remark) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.RemarkLine) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.RemarkMOQ) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.QANote1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.QANote2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.QANote3) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.QANote) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.seSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3011.cdSite) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK3011 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK3011", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK3011(z3011 As T3011_AREA) As Boolean
        REWRITE_PFK3011 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z3011)

            SQL = " UPDATE PFK3011 SET "
            SQL = SQL & "    K3011_KindRevise      =  " & FormatSQL(z3011.KindRevise) & ", "
            SQL = SQL & "    K3011_seSeason      = N'" & FormatSQL(z3011.seSeason) & "', "
            SQL = SQL & "    K3011_cdSeason      = N'" & FormatSQL(z3011.cdSeason) & "', "
            SQL = SQL & "    K3011_OrderNo      = N'" & FormatSQL(z3011.OrderNo) & "', "
            SQL = SQL & "    K3011_OrderNoSeq      = N'" & FormatSQL(z3011.OrderNoSeq) & "', "
            SQL = SQL & "    K3011_MaterialCodeBase      = N'" & FormatSQL(z3011.MaterialCodeBase) & "', "
            SQL = SQL & "    K3011_Materialcode      = N'" & FormatSQL(z3011.Materialcode) & "', "
            SQL = SQL & "    K3011_Description      = N'" & FormatSQL(z3011.Description) & "', "
            SQL = SQL & "    K3011_Color      = N'" & FormatSQL(z3011.Color) & "', "
            SQL = SQL & "    K3011_ColorCode      = N'" & FormatSQL(z3011.ColorCode) & "', "
            SQL = SQL & "    K3011_SizeNo      = N'" & FormatSQL(z3011.SizeNo) & "', "
            SQL = SQL & "    K3011_Specification      = N'" & FormatSQL(z3011.Specification) & "', "
            SQL = SQL & "    K3011_Width      = N'" & FormatSQL(z3011.Width) & "', "
            SQL = SQL & "    K3011_Height      = N'" & FormatSQL(z3011.Height) & "', "
            SQL = SQL & "    K3011_SizeName      = N'" & FormatSQL(z3011.SizeName) & "', "
            SQL = SQL & "    K3011_ColorName      = N'" & FormatSQL(z3011.ColorName) & "', "
            SQL = SQL & "    K3011_MaterialCheck      = N'" & FormatSQL(z3011.MaterialCheck) & "', "
            SQL = SQL & "    K3011_seShoesStatus      = N'" & FormatSQL(z3011.seShoesStatus) & "', "
            SQL = SQL & "    K3011_cdShoesStatus      = N'" & FormatSQL(z3011.cdShoesStatus) & "', "
            SQL = SQL & "    K3011_seDepartment      = N'" & FormatSQL(z3011.seDepartment) & "', "
            SQL = SQL & "    K3011_cdDepartment      = N'" & FormatSQL(z3011.cdDepartment) & "', "
            SQL = SQL & "    K3011_SupplierCode      = N'" & FormatSQL(z3011.SupplierCode) & "', "
            SQL = SQL & "    K3011_MaterialPrice      =  " & FormatSQL(z3011.MaterialPrice) & ", "
            SQL = SQL & "    K3011_seUnitPrice      = N'" & FormatSQL(z3011.seUnitPrice) & "', "
            SQL = SQL & "    K3011_cdUnitPrice      = N'" & FormatSQL(z3011.cdUnitPrice) & "', "
            SQL = SQL & "    K3011_QtySales      =  " & FormatSQL(z3011.QtySales) & ", "
            SQL = SQL & "    K3011_QtySalesSample      =  " & FormatSQL(z3011.QtySalesSample) & ", "
            SQL = SQL & "    K3011_GrossUsage      =  " & FormatSQL(z3011.GrossUsage) & ", "
            SQL = SQL & "    K3011_TotalQty      =  " & FormatSQL(z3011.TotalQty) & ", "
            SQL = SQL & "    K3011_QtyOrder      =  " & FormatSQL(z3011.QtyOrder) & ", "
            SQL = SQL & "    K3011_QtyAdjust      =  " & FormatSQL(z3011.QtyAdjust) & ", "
            SQL = SQL & "    K3011_QtyBooking      =  " & FormatSQL(z3011.QtyBooking) & ", "
            SQL = SQL & "    K3011_QtyBooking1      =  " & FormatSQL(z3011.QtyBooking1) & ", "
            SQL = SQL & "    K3011_QtyBooking2      =  " & FormatSQL(z3011.QtyBooking2) & ", "
            SQL = SQL & "    K3011_QtyRequest      =  " & FormatSQL(z3011.QtyRequest) & ", "
            SQL = SQL & "    K3011_QtyPurchasing      =  " & FormatSQL(z3011.QtyPurchasing) & ", "
            SQL = SQL & "    K3011_QtySizebySize      =  " & FormatSQL(z3011.QtySizebySize) & ", "
            SQL = SQL & "    K3011_seUnitMaterial      = N'" & FormatSQL(z3011.seUnitMaterial) & "', "
            SQL = SQL & "    K3011_cdUnitMaterial      = N'" & FormatSQL(z3011.cdUnitMaterial) & "', "
            SQL = SQL & "    K3011_InchargeRequest      = N'" & FormatSQL(z3011.InchargeRequest) & "', "
            SQL = SQL & "    K3011_PRNo      = N'" & FormatSQL(z3011.PRNo) & "', "
            SQL = SQL & "    K3011_PRNoSeq      = N'" & FormatSQL(z3011.PRNoSeq) & "', "
            SQL = SQL & "    K3011_CustomerCode      = N'" & FormatSQL(z3011.CustomerCode) & "', "
            SQL = SQL & "    K3011_PRName      = N'" & FormatSQL(z3011.PRName) & "', "
            SQL = SQL & "    K3011_PurchasingOrderNo      = N'" & FormatSQL(z3011.PurchasingOrderNo) & "', "
            SQL = SQL & "    K3011_PurchasingOrderSeq      =  " & FormatSQL(z3011.PurchasingOrderSeq) & ", "
            SQL = SQL & "    K3011_CheckOrderMaterial      = N'" & FormatSQL(z3011.CheckOrderMaterial) & "', "
            SQL = SQL & "    K3011_CheckAdjust      = N'" & FormatSQL(z3011.CheckAdjust) & "', "
            SQL = SQL & "    K3011_CheckGZ      = N'" & FormatSQL(z3011.CheckGZ) & "', "
            SQL = SQL & "    K3011_DateAdjust      = N'" & FormatSQL(z3011.DateAdjust) & "', "
            SQL = SQL & "    K3011_DateDelivery      = N'" & FormatSQL(z3011.DateDelivery) & "', "
            SQL = SQL & "    K3011_DateOrderMaterialAccept      = N'" & FormatSQL(z3011.DateOrderMaterialAccept) & "', "
            SQL = SQL & "    K3011_DateOrderMaterialComplete      = N'" & FormatSQL(z3011.DateOrderMaterialComplete) & "', "
            SQL = SQL & "    K3011_DateOrderMaterialApproval      = N'" & FormatSQL(z3011.DateOrderMaterialApproval) & "', "
            SQL = SQL & "    K3011_DateOrderMaterialCancel      = N'" & FormatSQL(z3011.DateOrderMaterialCancel) & "', "
            SQL = SQL & "    K3011_TimeInsert      = N'" & FormatSQL(z3011.TimeInsert) & "', "
            SQL = SQL & "    K3011_TimeUpdate      = N'" & FormatSQL(PUB.TIME) & "', "
            SQL = SQL & "    K3011_DateUpdate      = N'" & FormatSQL(PUB.DAT) & "', "
            SQL = SQL & "    K3011_DateInsert      = N'" & FormatSQL(z3011.DateInsert) & "', "
            SQL = SQL & "    K3011_DateUdate      = N'" & FormatSQL(z3011.DateUdate) & "', "
            SQL = SQL & "    K3011_InchargeInsert      = N'" & FormatSQL(z3011.InchargeInsert) & "', "
            SQL = SQL & "    K3011_InchargeUpdate      = N'" & FormatSQL(PUB.SAW) & "', "
            SQL = SQL & "    K3011_DateExcel      = N'" & FormatSQL(z3011.DateExcel) & "', "
            SQL = SQL & "    K3011_PriceAPurchasing      =  " & FormatSQL(z3011.PriceAPurchasing) & ", "
            SQL = SQL & "    K3011_cdUnitMaterialA      = N'" & FormatSQL(z3011.cdUnitMaterialA) & "', "
            SQL = SQL & "    K3011_cdUnitPriceA      = N'" & FormatSQL(z3011.cdUnitPriceA) & "', "
            SQL = SQL & "    K3011_QtyAPurchasing      =  " & FormatSQL(z3011.QtyAPurchasing) & ", "
            SQL = SQL & "    K3011_QtyATotal      =  " & FormatSQL(z3011.QtyATotal) & ", "
            SQL = SQL & "    K3011_AmtAPurchasing      =  " & FormatSQL(z3011.AmtAPurchasing) & ", "
            SQL = SQL & "    K3011_AmtATotal      =  " & FormatSQL(z3011.AmtATotal) & ", "
            SQL = SQL & "    K3011_DateArrive1      = N'" & FormatSQL(z3011.DateArrive1) & "', "
            SQL = SQL & "    K3011_DateArrive2      = N'" & FormatSQL(z3011.DateArrive2) & "', "
            SQL = SQL & "    K3011_DateArrive3      = N'" & FormatSQL(z3011.DateArrive3) & "', "
            SQL = SQL & "    K3011_DateArrive4      = N'" & FormatSQL(z3011.DateArrive4) & "', "
            SQL = SQL & "    K3011_DateArrive5      = N'" & FormatSQL(z3011.DateArrive5) & "', "
            SQL = SQL & "    K3011_QtyAArrive1      =  " & FormatSQL(z3011.QtyAArrive1) & ", "
            SQL = SQL & "    K3011_QtyAArrive2      =  " & FormatSQL(z3011.QtyAArrive2) & ", "
            SQL = SQL & "    K3011_QtyAArrive3      =  " & FormatSQL(z3011.QtyAArrive3) & ", "
            SQL = SQL & "    K3011_QtyAArrive4      =  " & FormatSQL(z3011.QtyAArrive4) & ", "
            SQL = SQL & "    K3011_QtyAArrive5      =  " & FormatSQL(z3011.QtyAArrive5) & ", "
            SQL = SQL & "    K3011_InchargeInvoice      = N'" & FormatSQL(z3011.InchargeInvoice) & "', "
            SQL = SQL & "    K3011_APLName      = N'" & FormatSQL(z3011.APLName) & "', "
            SQL = SQL & "    K3011_AInvoice      = N'" & FormatSQL(z3011.AInvoice) & "', "
            SQL = SQL & "    K3011_ARemark      = N'" & FormatSQL(z3011.ARemark) & "', "
            SQL = SQL & "    K3011_Remark      = N'" & FormatSQL(z3011.Remark) & "', "
            SQL = SQL & "    K3011_RemarkLine      = N'" & FormatSQL(z3011.RemarkLine) & "', "
            SQL = SQL & "    K3011_RemarkMOQ      = N'" & FormatSQL(z3011.RemarkMOQ) & "', "
            SQL = SQL & "    K3011_QANote1      = N'" & FormatSQL(z3011.QANote1) & "', "
            SQL = SQL & "    K3011_QANote2      = N'" & FormatSQL(z3011.QANote2) & "', "
            SQL = SQL & "    K3011_QANote3      = N'" & FormatSQL(z3011.QANote3) & "', "
            SQL = SQL & "    K3011_QANote      = N'" & FormatSQL(z3011.QANote) & "', "
            SQL = SQL & "    K3011_seSite      = N'" & FormatSQL(z3011.seSite) & "', "
            SQL = SQL & "    K3011_cdSite      = N'" & FormatSQL(z3011.cdSite) & "'  "
            SQL = SQL & " WHERE K3011_Autokey		 =  " & z3011.Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()


            REWRITE_PFK3011 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK3011", vbCritical)

        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK3011(z3011 As T3011_AREA) As Boolean
        DELETE_PFK3011 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z3011)

            SQL = " DELETE FROM PFK3011  "
            SQL = SQL & " WHERE K3011_Autokey		 =  " & z3011.Autokey & "  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK3011 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK3011", vbCritical)
        Finally
            Call GetFullInformation("PFK3011", "D", SQL)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D3011_CLEAR()
        Try

            D3011.Autokey = 0
            D3011.KindRevise = 0
            D3011.seSeason = ""
            D3011.cdSeason = ""
            D3011.OrderNo = ""
            D3011.OrderNoSeq = ""
            D3011.MaterialCodeBase = ""
            D3011.Materialcode = ""
            D3011.Description = ""
            D3011.Color = ""
            D3011.ColorCode = ""
            D3011.SizeNo = ""
            D3011.Specification = ""
            D3011.Width = ""
            D3011.Height = ""
            D3011.SizeName = ""
            D3011.ColorName = ""
            D3011.MaterialCheck = ""
            D3011.seShoesStatus = ""
            D3011.cdShoesStatus = ""
            D3011.seDepartment = ""
            D3011.cdDepartment = ""
            D3011.SupplierCode = ""
            D3011.MaterialPrice = 0
            D3011.seUnitPrice = ""
            D3011.cdUnitPrice = ""
            D3011.QtySales = 0
            D3011.QtySalesSample = 0
            D3011.GrossUsage = 0
            D3011.TotalQty = 0
            D3011.QtyOrder = 0
            D3011.QtyAdjust = 0
            D3011.QtyBooking = 0
            D3011.QtyBooking1 = 0
            D3011.QtyBooking2 = 0
            D3011.QtyRequest = 0
            D3011.QtyPurchasing = 0
            D3011.QtySizebySize = 0
            D3011.seUnitMaterial = ""
            D3011.cdUnitMaterial = ""
            D3011.InchargeRequest = ""
            D3011.PRNo = ""
            D3011.PRNoSeq = ""
            D3011.CustomerCode = ""
            D3011.PRName = ""
            D3011.PurchasingOrderNo = ""
            D3011.PurchasingOrderSeq = 0
            D3011.CheckOrderMaterial = ""
            D3011.CheckAdjust = ""
            D3011.CheckGZ = ""
            D3011.DateAdjust = ""
            D3011.DateDelivery = ""
            D3011.DateOrderMaterialAccept = ""
            D3011.DateOrderMaterialComplete = ""
            D3011.DateOrderMaterialApproval = ""
            D3011.DateOrderMaterialCancel = ""
            D3011.TimeInsert = ""
            D3011.TimeUpdate = ""
            D3011.DateUpdate = ""
            D3011.DateInsert = ""
            D3011.DateUdate = ""
            D3011.InchargeInsert = ""
            D3011.InchargeUpdate = ""
            D3011.DateExcel = ""
            D3011.PriceAPurchasing = 0
            D3011.cdUnitMaterialA = ""
            D3011.cdUnitPriceA = ""
            D3011.QtyAPurchasing = 0
            D3011.QtyATotal = 0
            D3011.AmtAPurchasing = 0
            D3011.AmtATotal = 0
            D3011.DateArrive1 = ""
            D3011.DateArrive2 = ""
            D3011.DateArrive3 = ""
            D3011.DateArrive4 = ""
            D3011.DateArrive5 = ""
            D3011.QtyAArrive1 = 0
            D3011.QtyAArrive2 = 0
            D3011.QtyAArrive3 = 0
            D3011.QtyAArrive4 = 0
            D3011.QtyAArrive5 = 0
            D3011.InchargeInvoice = ""
            D3011.APLName = ""
            D3011.AInvoice = ""
            D3011.ARemark = ""
            D3011.Remark = ""
            D3011.RemarkLine = ""
            D3011.RemarkMOQ = ""
            D3011.QANote1 = ""
            D3011.QANote2 = ""
            D3011.QANote3 = ""
            D3011.QANote = ""
            D3011.seSite = ""
            D3011.cdSite = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D3011_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x3011 As T3011_AREA)
        Try

            x3011.Autokey = trim$(x3011.Autokey)
            x3011.KindRevise = trim$(x3011.KindRevise)
            x3011.seSeason = trim$(x3011.seSeason)
            x3011.cdSeason = trim$(x3011.cdSeason)
            x3011.OrderNo = trim$(x3011.OrderNo)
            x3011.OrderNoSeq = trim$(x3011.OrderNoSeq)
            x3011.MaterialCodeBase = trim$(x3011.MaterialCodeBase)
            x3011.Materialcode = trim$(x3011.Materialcode)
            x3011.Description = trim$(x3011.Description)
            x3011.Color = trim$(x3011.Color)
            x3011.ColorCode = trim$(x3011.ColorCode)
            x3011.SizeNo = trim$(x3011.SizeNo)
            x3011.Specification = trim$(x3011.Specification)
            x3011.Width = trim$(x3011.Width)
            x3011.Height = trim$(x3011.Height)
            x3011.SizeName = trim$(x3011.SizeName)
            x3011.ColorName = trim$(x3011.ColorName)
            x3011.MaterialCheck = trim$(x3011.MaterialCheck)
            x3011.seShoesStatus = trim$(x3011.seShoesStatus)
            x3011.cdShoesStatus = trim$(x3011.cdShoesStatus)
            x3011.seDepartment = trim$(x3011.seDepartment)
            x3011.cdDepartment = trim$(x3011.cdDepartment)
            x3011.SupplierCode = trim$(x3011.SupplierCode)
            x3011.MaterialPrice = trim$(x3011.MaterialPrice)
            x3011.seUnitPrice = trim$(x3011.seUnitPrice)
            x3011.cdUnitPrice = trim$(x3011.cdUnitPrice)
            x3011.QtySales = trim$(x3011.QtySales)
            x3011.QtySalesSample = trim$(x3011.QtySalesSample)
            x3011.GrossUsage = trim$(x3011.GrossUsage)
            x3011.TotalQty = trim$(x3011.TotalQty)
            x3011.QtyOrder = trim$(x3011.QtyOrder)
            x3011.QtyAdjust = trim$(x3011.QtyAdjust)
            x3011.QtyBooking = Trim$(x3011.QtyBooking)
            x3011.QtyBooking1 = Trim$(x3011.QtyBooking1)
            x3011.QtyBooking2 = Trim$(x3011.QtyBooking2)
            x3011.QtyRequest = trim$(x3011.QtyRequest)
            x3011.QtyPurchasing = trim$(x3011.QtyPurchasing)
            x3011.QtySizebySize = trim$(x3011.QtySizebySize)
            x3011.seUnitMaterial = trim$(x3011.seUnitMaterial)
            x3011.cdUnitMaterial = trim$(x3011.cdUnitMaterial)
            x3011.InchargeRequest = trim$(x3011.InchargeRequest)
            x3011.PRNo = trim$(x3011.PRNo)
            x3011.PRNoSeq = trim$(x3011.PRNoSeq)
            x3011.CustomerCode = trim$(x3011.CustomerCode)
            x3011.PRName = trim$(x3011.PRName)
            x3011.PurchasingOrderNo = trim$(x3011.PurchasingOrderNo)
            x3011.PurchasingOrderSeq = trim$(x3011.PurchasingOrderSeq)
            x3011.CheckOrderMaterial = trim$(x3011.CheckOrderMaterial)
            x3011.CheckAdjust = trim$(x3011.CheckAdjust)
            x3011.CheckGZ = trim$(x3011.CheckGZ)
            x3011.DateAdjust = trim$(x3011.DateAdjust)
            x3011.DateDelivery = trim$(x3011.DateDelivery)
            x3011.DateOrderMaterialAccept = trim$(x3011.DateOrderMaterialAccept)
            x3011.DateOrderMaterialComplete = trim$(x3011.DateOrderMaterialComplete)
            x3011.DateOrderMaterialApproval = trim$(x3011.DateOrderMaterialApproval)
            x3011.DateOrderMaterialCancel = trim$(x3011.DateOrderMaterialCancel)
            x3011.TimeInsert = trim$(x3011.TimeInsert)
            x3011.TimeUpdate = trim$(x3011.TimeUpdate)
            x3011.DateUpdate = trim$(x3011.DateUpdate)
            x3011.DateInsert = trim$(x3011.DateInsert)
            x3011.DateUdate = trim$(x3011.DateUdate)
            x3011.InchargeInsert = trim$(x3011.InchargeInsert)
            x3011.InchargeUpdate = trim$(x3011.InchargeUpdate)
            x3011.DateExcel = trim$(x3011.DateExcel)
            x3011.PriceAPurchasing = trim$(x3011.PriceAPurchasing)
            x3011.cdUnitMaterialA = trim$(x3011.cdUnitMaterialA)
            x3011.cdUnitPriceA = trim$(x3011.cdUnitPriceA)
            x3011.QtyAPurchasing = trim$(x3011.QtyAPurchasing)
            x3011.QtyATotal = trim$(x3011.QtyATotal)
            x3011.AmtAPurchasing = trim$(x3011.AmtAPurchasing)
            x3011.AmtATotal = trim$(x3011.AmtATotal)
            x3011.DateArrive1 = trim$(x3011.DateArrive1)
            x3011.DateArrive2 = trim$(x3011.DateArrive2)
            x3011.DateArrive3 = trim$(x3011.DateArrive3)
            x3011.DateArrive4 = trim$(x3011.DateArrive4)
            x3011.DateArrive5 = trim$(x3011.DateArrive5)
            x3011.QtyAArrive1 = trim$(x3011.QtyAArrive1)
            x3011.QtyAArrive2 = trim$(x3011.QtyAArrive2)
            x3011.QtyAArrive3 = trim$(x3011.QtyAArrive3)
            x3011.QtyAArrive4 = trim$(x3011.QtyAArrive4)
            x3011.QtyAArrive5 = trim$(x3011.QtyAArrive5)
            x3011.InchargeInvoice = trim$(x3011.InchargeInvoice)
            x3011.APLName = trim$(x3011.APLName)
            x3011.AInvoice = trim$(x3011.AInvoice)
            x3011.ARemark = trim$(x3011.ARemark)
            x3011.Remark = trim$(x3011.Remark)
            x3011.RemarkLine = Trim$(x3011.RemarkLine)
            x3011.RemarkMOQ = Trim$(x3011.RemarkMOQ)
            x3011.QANote1 = Trim$(x3011.QANote1)
            x3011.QANote2 = Trim$(x3011.QANote2)
            x3011.QANote3 = Trim$(x3011.QANote3)
            x3011.QANote = Trim$(x3011.QANote)
            x3011.seSite = trim$(x3011.seSite)
            x3011.cdSite = trim$(x3011.cdSite)

            If trim$(x3011.Autokey) = "" Then x3011.Autokey = 0
            If trim$(x3011.KindRevise) = "" Then x3011.KindRevise = 0
            If trim$(x3011.seSeason) = "" Then x3011.seSeason = Space(1)
            If trim$(x3011.cdSeason) = "" Then x3011.cdSeason = Space(1)
            If trim$(x3011.OrderNo) = "" Then x3011.OrderNo = Space(1)
            If trim$(x3011.OrderNoSeq) = "" Then x3011.OrderNoSeq = Space(1)
            If trim$(x3011.MaterialCodeBase) = "" Then x3011.MaterialCodeBase = Space(1)
            If trim$(x3011.Materialcode) = "" Then x3011.Materialcode = Space(1)
            If trim$(x3011.Description) = "" Then x3011.Description = Space(1)
            If trim$(x3011.Color) = "" Then x3011.Color = Space(1)
            If trim$(x3011.ColorCode) = "" Then x3011.ColorCode = Space(1)
            If trim$(x3011.SizeNo) = "" Then x3011.SizeNo = Space(1)
            If trim$(x3011.Specification) = "" Then x3011.Specification = Space(1)
            If trim$(x3011.Width) = "" Then x3011.Width = Space(1)
            If trim$(x3011.Height) = "" Then x3011.Height = Space(1)
            If trim$(x3011.SizeName) = "" Then x3011.SizeName = Space(1)
            If trim$(x3011.ColorName) = "" Then x3011.ColorName = Space(1)
            If trim$(x3011.MaterialCheck) = "" Then x3011.MaterialCheck = Space(1)
            If trim$(x3011.seShoesStatus) = "" Then x3011.seShoesStatus = Space(1)
            If trim$(x3011.cdShoesStatus) = "" Then x3011.cdShoesStatus = Space(1)
            If trim$(x3011.seDepartment) = "" Then x3011.seDepartment = Space(1)
            If trim$(x3011.cdDepartment) = "" Then x3011.cdDepartment = Space(1)
            If trim$(x3011.SupplierCode) = "" Then x3011.SupplierCode = Space(1)
            If trim$(x3011.MaterialPrice) = "" Then x3011.MaterialPrice = 0
            If trim$(x3011.seUnitPrice) = "" Then x3011.seUnitPrice = Space(1)
            If trim$(x3011.cdUnitPrice) = "" Then x3011.cdUnitPrice = Space(1)
            If trim$(x3011.QtySales) = "" Then x3011.QtySales = 0
            If trim$(x3011.QtySalesSample) = "" Then x3011.QtySalesSample = 0
            If trim$(x3011.GrossUsage) = "" Then x3011.GrossUsage = 0
            If trim$(x3011.TotalQty) = "" Then x3011.TotalQty = 0
            If trim$(x3011.QtyOrder) = "" Then x3011.QtyOrder = 0
            If trim$(x3011.QtyAdjust) = "" Then x3011.QtyAdjust = 0
            If Trim$(x3011.QtyBooking) = "" Then x3011.QtyBooking = 0
            If Trim$(x3011.QtyBooking1) = "" Then x3011.QtyBooking1 = 0
            If Trim$(x3011.QtyBooking2) = "" Then x3011.QtyBooking2 = 0
            If trim$(x3011.QtyRequest) = "" Then x3011.QtyRequest = 0
            If trim$(x3011.QtyPurchasing) = "" Then x3011.QtyPurchasing = 0
            If trim$(x3011.QtySizebySize) = "" Then x3011.QtySizebySize = 0
            If trim$(x3011.seUnitMaterial) = "" Then x3011.seUnitMaterial = Space(1)
            If trim$(x3011.cdUnitMaterial) = "" Then x3011.cdUnitMaterial = Space(1)
            If trim$(x3011.InchargeRequest) = "" Then x3011.InchargeRequest = Space(1)
            If trim$(x3011.PRNo) = "" Then x3011.PRNo = Space(1)
            If trim$(x3011.PRNoSeq) = "" Then x3011.PRNoSeq = Space(1)
            If trim$(x3011.CustomerCode) = "" Then x3011.CustomerCode = Space(1)
            If trim$(x3011.PRName) = "" Then x3011.PRName = Space(1)
            If trim$(x3011.PurchasingOrderNo) = "" Then x3011.PurchasingOrderNo = Space(1)
            If trim$(x3011.PurchasingOrderSeq) = "" Then x3011.PurchasingOrderSeq = 0
            If trim$(x3011.CheckOrderMaterial) = "" Then x3011.CheckOrderMaterial = Space(1)
            If trim$(x3011.CheckAdjust) = "" Then x3011.CheckAdjust = Space(1)
            If trim$(x3011.CheckGZ) = "" Then x3011.CheckGZ = Space(1)
            If trim$(x3011.DateAdjust) = "" Then x3011.DateAdjust = Space(1)
            If trim$(x3011.DateDelivery) = "" Then x3011.DateDelivery = Space(1)
            If trim$(x3011.DateOrderMaterialAccept) = "" Then x3011.DateOrderMaterialAccept = Space(1)
            If trim$(x3011.DateOrderMaterialComplete) = "" Then x3011.DateOrderMaterialComplete = Space(1)
            If trim$(x3011.DateOrderMaterialApproval) = "" Then x3011.DateOrderMaterialApproval = Space(1)
            If trim$(x3011.DateOrderMaterialCancel) = "" Then x3011.DateOrderMaterialCancel = Space(1)
            If trim$(x3011.TimeInsert) = "" Then x3011.TimeInsert = Space(1)
            If trim$(x3011.TimeUpdate) = "" Then x3011.TimeUpdate = Space(1)
            If trim$(x3011.DateUpdate) = "" Then x3011.DateUpdate = Space(1)
            If trim$(x3011.DateInsert) = "" Then x3011.DateInsert = Space(1)
            If trim$(x3011.DateUdate) = "" Then x3011.DateUdate = Space(1)
            If trim$(x3011.InchargeInsert) = "" Then x3011.InchargeInsert = Space(1)
            If trim$(x3011.InchargeUpdate) = "" Then x3011.InchargeUpdate = Space(1)
            If trim$(x3011.DateExcel) = "" Then x3011.DateExcel = Space(1)
            If trim$(x3011.PriceAPurchasing) = "" Then x3011.PriceAPurchasing = 0
            If trim$(x3011.cdUnitMaterialA) = "" Then x3011.cdUnitMaterialA = Space(1)
            If trim$(x3011.cdUnitPriceA) = "" Then x3011.cdUnitPriceA = Space(1)
            If trim$(x3011.QtyAPurchasing) = "" Then x3011.QtyAPurchasing = 0
            If trim$(x3011.QtyATotal) = "" Then x3011.QtyATotal = 0
            If trim$(x3011.AmtAPurchasing) = "" Then x3011.AmtAPurchasing = 0
            If trim$(x3011.AmtATotal) = "" Then x3011.AmtATotal = 0
            If trim$(x3011.DateArrive1) = "" Then x3011.DateArrive1 = Space(1)
            If trim$(x3011.DateArrive2) = "" Then x3011.DateArrive2 = Space(1)
            If trim$(x3011.DateArrive3) = "" Then x3011.DateArrive3 = Space(1)
            If trim$(x3011.DateArrive4) = "" Then x3011.DateArrive4 = Space(1)
            If trim$(x3011.DateArrive5) = "" Then x3011.DateArrive5 = Space(1)
            If trim$(x3011.QtyAArrive1) = "" Then x3011.QtyAArrive1 = 0
            If trim$(x3011.QtyAArrive2) = "" Then x3011.QtyAArrive2 = 0
            If trim$(x3011.QtyAArrive3) = "" Then x3011.QtyAArrive3 = 0
            If trim$(x3011.QtyAArrive4) = "" Then x3011.QtyAArrive4 = 0
            If trim$(x3011.QtyAArrive5) = "" Then x3011.QtyAArrive5 = 0
            If trim$(x3011.InchargeInvoice) = "" Then x3011.InchargeInvoice = Space(1)
            If trim$(x3011.APLName) = "" Then x3011.APLName = Space(1)
            If trim$(x3011.AInvoice) = "" Then x3011.AInvoice = Space(1)
            If trim$(x3011.ARemark) = "" Then x3011.ARemark = Space(1)
            If trim$(x3011.Remark) = "" Then x3011.Remark = Space(1)
            If Trim$(x3011.RemarkLine) = "" Then x3011.RemarkLine = Space(1)
            If Trim$(x3011.RemarkMOQ) = "" Then x3011.RemarkMOQ = Space(1)
            If Trim$(x3011.QANote1) = "" Then x3011.QANote1 = Space(1)
            If Trim$(x3011.QANote2) = "" Then x3011.QANote2 = Space(1)
            If Trim$(x3011.QANote3) = "" Then x3011.QANote3 = Space(1)
            If Trim$(x3011.QANote) = "" Then x3011.QANote = Space(1)
            If trim$(x3011.seSite) = "" Then x3011.seSite = Space(1)
            If trim$(x3011.cdSite) = "" Then x3011.cdSite = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K3011_MOVE(rs3011 As SqlClient.SqlDataReader)
        Try

            Call D3011_CLEAR()

            If IsdbNull(rs3011!K3011_Autokey) = False Then D3011.Autokey = Trim$(rs3011!K3011_Autokey)
            If IsdbNull(rs3011!K3011_KindRevise) = False Then D3011.KindRevise = Trim$(rs3011!K3011_KindRevise)
            If IsdbNull(rs3011!K3011_seSeason) = False Then D3011.seSeason = Trim$(rs3011!K3011_seSeason)
            If IsdbNull(rs3011!K3011_cdSeason) = False Then D3011.cdSeason = Trim$(rs3011!K3011_cdSeason)
            If IsdbNull(rs3011!K3011_OrderNo) = False Then D3011.OrderNo = Trim$(rs3011!K3011_OrderNo)
            If IsdbNull(rs3011!K3011_OrderNoSeq) = False Then D3011.OrderNoSeq = Trim$(rs3011!K3011_OrderNoSeq)
            If IsdbNull(rs3011!K3011_MaterialCodeBase) = False Then D3011.MaterialCodeBase = Trim$(rs3011!K3011_MaterialCodeBase)
            If IsdbNull(rs3011!K3011_Materialcode) = False Then D3011.Materialcode = Trim$(rs3011!K3011_Materialcode)
            If IsdbNull(rs3011!K3011_Description) = False Then D3011.Description = Trim$(rs3011!K3011_Description)
            If IsdbNull(rs3011!K3011_Color) = False Then D3011.Color = Trim$(rs3011!K3011_Color)
            If IsdbNull(rs3011!K3011_ColorCode) = False Then D3011.ColorCode = Trim$(rs3011!K3011_ColorCode)
            If IsdbNull(rs3011!K3011_SizeNo) = False Then D3011.SizeNo = Trim$(rs3011!K3011_SizeNo)
            If IsdbNull(rs3011!K3011_Specification) = False Then D3011.Specification = Trim$(rs3011!K3011_Specification)
            If IsdbNull(rs3011!K3011_Width) = False Then D3011.Width = Trim$(rs3011!K3011_Width)
            If IsdbNull(rs3011!K3011_Height) = False Then D3011.Height = Trim$(rs3011!K3011_Height)
            If IsdbNull(rs3011!K3011_SizeName) = False Then D3011.SizeName = Trim$(rs3011!K3011_SizeName)
            If IsdbNull(rs3011!K3011_ColorName) = False Then D3011.ColorName = Trim$(rs3011!K3011_ColorName)
            If IsdbNull(rs3011!K3011_MaterialCheck) = False Then D3011.MaterialCheck = Trim$(rs3011!K3011_MaterialCheck)
            If IsdbNull(rs3011!K3011_seShoesStatus) = False Then D3011.seShoesStatus = Trim$(rs3011!K3011_seShoesStatus)
            If IsdbNull(rs3011!K3011_cdShoesStatus) = False Then D3011.cdShoesStatus = Trim$(rs3011!K3011_cdShoesStatus)
            If IsdbNull(rs3011!K3011_seDepartment) = False Then D3011.seDepartment = Trim$(rs3011!K3011_seDepartment)
            If IsdbNull(rs3011!K3011_cdDepartment) = False Then D3011.cdDepartment = Trim$(rs3011!K3011_cdDepartment)
            If IsdbNull(rs3011!K3011_SupplierCode) = False Then D3011.SupplierCode = Trim$(rs3011!K3011_SupplierCode)
            If IsdbNull(rs3011!K3011_MaterialPrice) = False Then D3011.MaterialPrice = Trim$(rs3011!K3011_MaterialPrice)
            If IsdbNull(rs3011!K3011_seUnitPrice) = False Then D3011.seUnitPrice = Trim$(rs3011!K3011_seUnitPrice)
            If IsdbNull(rs3011!K3011_cdUnitPrice) = False Then D3011.cdUnitPrice = Trim$(rs3011!K3011_cdUnitPrice)
            If IsdbNull(rs3011!K3011_QtySales) = False Then D3011.QtySales = Trim$(rs3011!K3011_QtySales)
            If IsdbNull(rs3011!K3011_QtySalesSample) = False Then D3011.QtySalesSample = Trim$(rs3011!K3011_QtySalesSample)
            If IsdbNull(rs3011!K3011_GrossUsage) = False Then D3011.GrossUsage = Trim$(rs3011!K3011_GrossUsage)
            If IsdbNull(rs3011!K3011_TotalQty) = False Then D3011.TotalQty = Trim$(rs3011!K3011_TotalQty)
            If IsdbNull(rs3011!K3011_QtyOrder) = False Then D3011.QtyOrder = Trim$(rs3011!K3011_QtyOrder)
            If IsdbNull(rs3011!K3011_QtyAdjust) = False Then D3011.QtyAdjust = Trim$(rs3011!K3011_QtyAdjust)
            If IsDBNull(rs3011!K3011_QtyBooking) = False Then D3011.QtyBooking = Trim$(rs3011!K3011_QtyBooking)
            If IsDBNull(rs3011!K3011_QtyBooking1) = False Then D3011.QtyBooking1 = Trim$(rs3011!K3011_QtyBooking1)
            If IsDBNull(rs3011!K3011_QtyBooking2) = False Then D3011.QtyBooking2 = Trim$(rs3011!K3011_QtyBooking2)
            If IsdbNull(rs3011!K3011_QtyRequest) = False Then D3011.QtyRequest = Trim$(rs3011!K3011_QtyRequest)
            If IsdbNull(rs3011!K3011_QtyPurchasing) = False Then D3011.QtyPurchasing = Trim$(rs3011!K3011_QtyPurchasing)
            If IsdbNull(rs3011!K3011_QtySizebySize) = False Then D3011.QtySizebySize = Trim$(rs3011!K3011_QtySizebySize)
            If IsdbNull(rs3011!K3011_seUnitMaterial) = False Then D3011.seUnitMaterial = Trim$(rs3011!K3011_seUnitMaterial)
            If IsdbNull(rs3011!K3011_cdUnitMaterial) = False Then D3011.cdUnitMaterial = Trim$(rs3011!K3011_cdUnitMaterial)
            If IsdbNull(rs3011!K3011_InchargeRequest) = False Then D3011.InchargeRequest = Trim$(rs3011!K3011_InchargeRequest)
            If IsdbNull(rs3011!K3011_PRNo) = False Then D3011.PRNo = Trim$(rs3011!K3011_PRNo)
            If IsdbNull(rs3011!K3011_PRNoSeq) = False Then D3011.PRNoSeq = Trim$(rs3011!K3011_PRNoSeq)
            If IsdbNull(rs3011!K3011_CustomerCode) = False Then D3011.CustomerCode = Trim$(rs3011!K3011_CustomerCode)
            If IsdbNull(rs3011!K3011_PRName) = False Then D3011.PRName = Trim$(rs3011!K3011_PRName)
            If IsdbNull(rs3011!K3011_PurchasingOrderNo) = False Then D3011.PurchasingOrderNo = Trim$(rs3011!K3011_PurchasingOrderNo)
            If IsdbNull(rs3011!K3011_PurchasingOrderSeq) = False Then D3011.PurchasingOrderSeq = Trim$(rs3011!K3011_PurchasingOrderSeq)
            If IsdbNull(rs3011!K3011_CheckOrderMaterial) = False Then D3011.CheckOrderMaterial = Trim$(rs3011!K3011_CheckOrderMaterial)
            If IsdbNull(rs3011!K3011_CheckAdjust) = False Then D3011.CheckAdjust = Trim$(rs3011!K3011_CheckAdjust)
            If IsdbNull(rs3011!K3011_CheckGZ) = False Then D3011.CheckGZ = Trim$(rs3011!K3011_CheckGZ)
            If IsdbNull(rs3011!K3011_DateAdjust) = False Then D3011.DateAdjust = Trim$(rs3011!K3011_DateAdjust)
            If IsdbNull(rs3011!K3011_DateDelivery) = False Then D3011.DateDelivery = Trim$(rs3011!K3011_DateDelivery)
            If IsdbNull(rs3011!K3011_DateOrderMaterialAccept) = False Then D3011.DateOrderMaterialAccept = Trim$(rs3011!K3011_DateOrderMaterialAccept)
            If IsdbNull(rs3011!K3011_DateOrderMaterialComplete) = False Then D3011.DateOrderMaterialComplete = Trim$(rs3011!K3011_DateOrderMaterialComplete)
            If IsdbNull(rs3011!K3011_DateOrderMaterialApproval) = False Then D3011.DateOrderMaterialApproval = Trim$(rs3011!K3011_DateOrderMaterialApproval)
            If IsdbNull(rs3011!K3011_DateOrderMaterialCancel) = False Then D3011.DateOrderMaterialCancel = Trim$(rs3011!K3011_DateOrderMaterialCancel)
            If IsdbNull(rs3011!K3011_TimeInsert) = False Then D3011.TimeInsert = Trim$(rs3011!K3011_TimeInsert)
            If IsdbNull(rs3011!K3011_TimeUpdate) = False Then D3011.TimeUpdate = Trim$(rs3011!K3011_TimeUpdate)
            If IsdbNull(rs3011!K3011_DateUpdate) = False Then D3011.DateUpdate = Trim$(rs3011!K3011_DateUpdate)
            If IsdbNull(rs3011!K3011_DateInsert) = False Then D3011.DateInsert = Trim$(rs3011!K3011_DateInsert)
            If IsdbNull(rs3011!K3011_DateUdate) = False Then D3011.DateUdate = Trim$(rs3011!K3011_DateUdate)
            If IsdbNull(rs3011!K3011_InchargeInsert) = False Then D3011.InchargeInsert = Trim$(rs3011!K3011_InchargeInsert)
            If IsdbNull(rs3011!K3011_InchargeUpdate) = False Then D3011.InchargeUpdate = Trim$(rs3011!K3011_InchargeUpdate)
            If IsdbNull(rs3011!K3011_DateExcel) = False Then D3011.DateExcel = Trim$(rs3011!K3011_DateExcel)
            If IsdbNull(rs3011!K3011_PriceAPurchasing) = False Then D3011.PriceAPurchasing = Trim$(rs3011!K3011_PriceAPurchasing)
            If IsdbNull(rs3011!K3011_cdUnitMaterialA) = False Then D3011.cdUnitMaterialA = Trim$(rs3011!K3011_cdUnitMaterialA)
            If IsdbNull(rs3011!K3011_cdUnitPriceA) = False Then D3011.cdUnitPriceA = Trim$(rs3011!K3011_cdUnitPriceA)
            If IsdbNull(rs3011!K3011_QtyAPurchasing) = False Then D3011.QtyAPurchasing = Trim$(rs3011!K3011_QtyAPurchasing)
            If IsdbNull(rs3011!K3011_QtyATotal) = False Then D3011.QtyATotal = Trim$(rs3011!K3011_QtyATotal)
            If IsdbNull(rs3011!K3011_AmtAPurchasing) = False Then D3011.AmtAPurchasing = Trim$(rs3011!K3011_AmtAPurchasing)
            If IsdbNull(rs3011!K3011_AmtATotal) = False Then D3011.AmtATotal = Trim$(rs3011!K3011_AmtATotal)
            If IsdbNull(rs3011!K3011_DateArrive1) = False Then D3011.DateArrive1 = Trim$(rs3011!K3011_DateArrive1)
            If IsdbNull(rs3011!K3011_DateArrive2) = False Then D3011.DateArrive2 = Trim$(rs3011!K3011_DateArrive2)
            If IsdbNull(rs3011!K3011_DateArrive3) = False Then D3011.DateArrive3 = Trim$(rs3011!K3011_DateArrive3)
            If IsdbNull(rs3011!K3011_DateArrive4) = False Then D3011.DateArrive4 = Trim$(rs3011!K3011_DateArrive4)
            If IsdbNull(rs3011!K3011_DateArrive5) = False Then D3011.DateArrive5 = Trim$(rs3011!K3011_DateArrive5)
            If IsdbNull(rs3011!K3011_QtyAArrive1) = False Then D3011.QtyAArrive1 = Trim$(rs3011!K3011_QtyAArrive1)
            If IsdbNull(rs3011!K3011_QtyAArrive2) = False Then D3011.QtyAArrive2 = Trim$(rs3011!K3011_QtyAArrive2)
            If IsdbNull(rs3011!K3011_QtyAArrive3) = False Then D3011.QtyAArrive3 = Trim$(rs3011!K3011_QtyAArrive3)
            If IsdbNull(rs3011!K3011_QtyAArrive4) = False Then D3011.QtyAArrive4 = Trim$(rs3011!K3011_QtyAArrive4)
            If IsdbNull(rs3011!K3011_QtyAArrive5) = False Then D3011.QtyAArrive5 = Trim$(rs3011!K3011_QtyAArrive5)
            If IsdbNull(rs3011!K3011_InchargeInvoice) = False Then D3011.InchargeInvoice = Trim$(rs3011!K3011_InchargeInvoice)
            If IsdbNull(rs3011!K3011_APLName) = False Then D3011.APLName = Trim$(rs3011!K3011_APLName)
            If IsdbNull(rs3011!K3011_AInvoice) = False Then D3011.AInvoice = Trim$(rs3011!K3011_AInvoice)
            If IsdbNull(rs3011!K3011_ARemark) = False Then D3011.ARemark = Trim$(rs3011!K3011_ARemark)
            If IsdbNull(rs3011!K3011_Remark) = False Then D3011.Remark = Trim$(rs3011!K3011_Remark)
            If IsDBNull(rs3011!K3011_RemarkLine) = False Then D3011.RemarkLine = Trim$(rs3011!K3011_RemarkLine)
            If IsDBNull(rs3011!K3011_RemarkMOQ) = False Then D3011.RemarkMOQ = Trim$(rs3011!K3011_RemarkMOQ)
            If IsDBNull(rs3011!K3011_QANote1) = False Then D3011.QANote1 = Trim$(rs3011!K3011_QANote1)
            If IsDBNull(rs3011!K3011_QANote2) = False Then D3011.QANote2 = Trim$(rs3011!K3011_QANote2)
            If IsDBNull(rs3011!K3011_QANote3) = False Then D3011.QANote3 = Trim$(rs3011!K3011_QANote3)
            If IsDBNull(rs3011!K3011_QANote) = False Then D3011.QANote = Trim$(rs3011!K3011_QANote)
            If IsdbNull(rs3011!K3011_seSite) = False Then D3011.seSite = Trim$(rs3011!K3011_seSite)
            If IsdbNull(rs3011!K3011_cdSite) = False Then D3011.cdSite = Trim$(rs3011!K3011_cdSite)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K3011_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K3011_MOVE(rs3011 As DataRow)
        Try

            Call D3011_CLEAR()

            If IsdbNull(rs3011!K3011_Autokey) = False Then D3011.Autokey = Trim$(rs3011!K3011_Autokey)
            If IsdbNull(rs3011!K3011_KindRevise) = False Then D3011.KindRevise = Trim$(rs3011!K3011_KindRevise)
            If IsdbNull(rs3011!K3011_seSeason) = False Then D3011.seSeason = Trim$(rs3011!K3011_seSeason)
            If IsdbNull(rs3011!K3011_cdSeason) = False Then D3011.cdSeason = Trim$(rs3011!K3011_cdSeason)
            If IsdbNull(rs3011!K3011_OrderNo) = False Then D3011.OrderNo = Trim$(rs3011!K3011_OrderNo)
            If IsdbNull(rs3011!K3011_OrderNoSeq) = False Then D3011.OrderNoSeq = Trim$(rs3011!K3011_OrderNoSeq)
            If IsdbNull(rs3011!K3011_MaterialCodeBase) = False Then D3011.MaterialCodeBase = Trim$(rs3011!K3011_MaterialCodeBase)
            If IsdbNull(rs3011!K3011_Materialcode) = False Then D3011.Materialcode = Trim$(rs3011!K3011_Materialcode)
            If IsdbNull(rs3011!K3011_Description) = False Then D3011.Description = Trim$(rs3011!K3011_Description)
            If IsdbNull(rs3011!K3011_Color) = False Then D3011.Color = Trim$(rs3011!K3011_Color)
            If IsdbNull(rs3011!K3011_ColorCode) = False Then D3011.ColorCode = Trim$(rs3011!K3011_ColorCode)
            If IsdbNull(rs3011!K3011_SizeNo) = False Then D3011.SizeNo = Trim$(rs3011!K3011_SizeNo)
            If IsdbNull(rs3011!K3011_Specification) = False Then D3011.Specification = Trim$(rs3011!K3011_Specification)
            If IsdbNull(rs3011!K3011_Width) = False Then D3011.Width = Trim$(rs3011!K3011_Width)
            If IsdbNull(rs3011!K3011_Height) = False Then D3011.Height = Trim$(rs3011!K3011_Height)
            If IsdbNull(rs3011!K3011_SizeName) = False Then D3011.SizeName = Trim$(rs3011!K3011_SizeName)
            If IsdbNull(rs3011!K3011_ColorName) = False Then D3011.ColorName = Trim$(rs3011!K3011_ColorName)
            If IsdbNull(rs3011!K3011_MaterialCheck) = False Then D3011.MaterialCheck = Trim$(rs3011!K3011_MaterialCheck)
            If IsdbNull(rs3011!K3011_seShoesStatus) = False Then D3011.seShoesStatus = Trim$(rs3011!K3011_seShoesStatus)
            If IsdbNull(rs3011!K3011_cdShoesStatus) = False Then D3011.cdShoesStatus = Trim$(rs3011!K3011_cdShoesStatus)
            If IsdbNull(rs3011!K3011_seDepartment) = False Then D3011.seDepartment = Trim$(rs3011!K3011_seDepartment)
            If IsdbNull(rs3011!K3011_cdDepartment) = False Then D3011.cdDepartment = Trim$(rs3011!K3011_cdDepartment)
            If IsdbNull(rs3011!K3011_SupplierCode) = False Then D3011.SupplierCode = Trim$(rs3011!K3011_SupplierCode)
            If IsdbNull(rs3011!K3011_MaterialPrice) = False Then D3011.MaterialPrice = Trim$(rs3011!K3011_MaterialPrice)
            If IsdbNull(rs3011!K3011_seUnitPrice) = False Then D3011.seUnitPrice = Trim$(rs3011!K3011_seUnitPrice)
            If IsdbNull(rs3011!K3011_cdUnitPrice) = False Then D3011.cdUnitPrice = Trim$(rs3011!K3011_cdUnitPrice)
            If IsdbNull(rs3011!K3011_QtySales) = False Then D3011.QtySales = Trim$(rs3011!K3011_QtySales)
            If IsdbNull(rs3011!K3011_QtySalesSample) = False Then D3011.QtySalesSample = Trim$(rs3011!K3011_QtySalesSample)
            If IsdbNull(rs3011!K3011_GrossUsage) = False Then D3011.GrossUsage = Trim$(rs3011!K3011_GrossUsage)
            If IsdbNull(rs3011!K3011_TotalQty) = False Then D3011.TotalQty = Trim$(rs3011!K3011_TotalQty)
            If IsdbNull(rs3011!K3011_QtyOrder) = False Then D3011.QtyOrder = Trim$(rs3011!K3011_QtyOrder)
            If IsdbNull(rs3011!K3011_QtyAdjust) = False Then D3011.QtyAdjust = Trim$(rs3011!K3011_QtyAdjust)
            If IsDBNull(rs3011!K3011_QtyBooking) = False Then D3011.QtyBooking = Trim$(rs3011!K3011_QtyBooking)
            If IsDBNull(rs3011!K3011_QtyBooking1) = False Then D3011.QtyBooking1 = Trim$(rs3011!K3011_QtyBooking1)
            If IsDBNull(rs3011!K3011_QtyBooking2) = False Then D3011.QtyBooking2 = Trim$(rs3011!K3011_QtyBooking2)
            If IsdbNull(rs3011!K3011_QtyRequest) = False Then D3011.QtyRequest = Trim$(rs3011!K3011_QtyRequest)
            If IsdbNull(rs3011!K3011_QtyPurchasing) = False Then D3011.QtyPurchasing = Trim$(rs3011!K3011_QtyPurchasing)
            If IsdbNull(rs3011!K3011_QtySizebySize) = False Then D3011.QtySizebySize = Trim$(rs3011!K3011_QtySizebySize)
            If IsdbNull(rs3011!K3011_seUnitMaterial) = False Then D3011.seUnitMaterial = Trim$(rs3011!K3011_seUnitMaterial)
            If IsdbNull(rs3011!K3011_cdUnitMaterial) = False Then D3011.cdUnitMaterial = Trim$(rs3011!K3011_cdUnitMaterial)
            If IsdbNull(rs3011!K3011_InchargeRequest) = False Then D3011.InchargeRequest = Trim$(rs3011!K3011_InchargeRequest)
            If IsdbNull(rs3011!K3011_PRNo) = False Then D3011.PRNo = Trim$(rs3011!K3011_PRNo)
            If IsdbNull(rs3011!K3011_PRNoSeq) = False Then D3011.PRNoSeq = Trim$(rs3011!K3011_PRNoSeq)
            If IsdbNull(rs3011!K3011_CustomerCode) = False Then D3011.CustomerCode = Trim$(rs3011!K3011_CustomerCode)
            If IsdbNull(rs3011!K3011_PRName) = False Then D3011.PRName = Trim$(rs3011!K3011_PRName)
            If IsdbNull(rs3011!K3011_PurchasingOrderNo) = False Then D3011.PurchasingOrderNo = Trim$(rs3011!K3011_PurchasingOrderNo)
            If IsdbNull(rs3011!K3011_PurchasingOrderSeq) = False Then D3011.PurchasingOrderSeq = Trim$(rs3011!K3011_PurchasingOrderSeq)
            If IsdbNull(rs3011!K3011_CheckOrderMaterial) = False Then D3011.CheckOrderMaterial = Trim$(rs3011!K3011_CheckOrderMaterial)
            If IsdbNull(rs3011!K3011_CheckAdjust) = False Then D3011.CheckAdjust = Trim$(rs3011!K3011_CheckAdjust)
            If IsdbNull(rs3011!K3011_CheckGZ) = False Then D3011.CheckGZ = Trim$(rs3011!K3011_CheckGZ)
            If IsdbNull(rs3011!K3011_DateAdjust) = False Then D3011.DateAdjust = Trim$(rs3011!K3011_DateAdjust)
            If IsdbNull(rs3011!K3011_DateDelivery) = False Then D3011.DateDelivery = Trim$(rs3011!K3011_DateDelivery)
            If IsdbNull(rs3011!K3011_DateOrderMaterialAccept) = False Then D3011.DateOrderMaterialAccept = Trim$(rs3011!K3011_DateOrderMaterialAccept)
            If IsdbNull(rs3011!K3011_DateOrderMaterialComplete) = False Then D3011.DateOrderMaterialComplete = Trim$(rs3011!K3011_DateOrderMaterialComplete)
            If IsdbNull(rs3011!K3011_DateOrderMaterialApproval) = False Then D3011.DateOrderMaterialApproval = Trim$(rs3011!K3011_DateOrderMaterialApproval)
            If IsdbNull(rs3011!K3011_DateOrderMaterialCancel) = False Then D3011.DateOrderMaterialCancel = Trim$(rs3011!K3011_DateOrderMaterialCancel)
            If IsdbNull(rs3011!K3011_TimeInsert) = False Then D3011.TimeInsert = Trim$(rs3011!K3011_TimeInsert)
            If IsdbNull(rs3011!K3011_TimeUpdate) = False Then D3011.TimeUpdate = Trim$(rs3011!K3011_TimeUpdate)
            If IsdbNull(rs3011!K3011_DateUpdate) = False Then D3011.DateUpdate = Trim$(rs3011!K3011_DateUpdate)
            If IsdbNull(rs3011!K3011_DateInsert) = False Then D3011.DateInsert = Trim$(rs3011!K3011_DateInsert)
            If IsdbNull(rs3011!K3011_DateUdate) = False Then D3011.DateUdate = Trim$(rs3011!K3011_DateUdate)
            If IsdbNull(rs3011!K3011_InchargeInsert) = False Then D3011.InchargeInsert = Trim$(rs3011!K3011_InchargeInsert)
            If IsdbNull(rs3011!K3011_InchargeUpdate) = False Then D3011.InchargeUpdate = Trim$(rs3011!K3011_InchargeUpdate)
            If IsdbNull(rs3011!K3011_DateExcel) = False Then D3011.DateExcel = Trim$(rs3011!K3011_DateExcel)
            If IsdbNull(rs3011!K3011_PriceAPurchasing) = False Then D3011.PriceAPurchasing = Trim$(rs3011!K3011_PriceAPurchasing)
            If IsdbNull(rs3011!K3011_cdUnitMaterialA) = False Then D3011.cdUnitMaterialA = Trim$(rs3011!K3011_cdUnitMaterialA)
            If IsdbNull(rs3011!K3011_cdUnitPriceA) = False Then D3011.cdUnitPriceA = Trim$(rs3011!K3011_cdUnitPriceA)
            If IsdbNull(rs3011!K3011_QtyAPurchasing) = False Then D3011.QtyAPurchasing = Trim$(rs3011!K3011_QtyAPurchasing)
            If IsdbNull(rs3011!K3011_QtyATotal) = False Then D3011.QtyATotal = Trim$(rs3011!K3011_QtyATotal)
            If IsdbNull(rs3011!K3011_AmtAPurchasing) = False Then D3011.AmtAPurchasing = Trim$(rs3011!K3011_AmtAPurchasing)
            If IsdbNull(rs3011!K3011_AmtATotal) = False Then D3011.AmtATotal = Trim$(rs3011!K3011_AmtATotal)
            If IsdbNull(rs3011!K3011_DateArrive1) = False Then D3011.DateArrive1 = Trim$(rs3011!K3011_DateArrive1)
            If IsdbNull(rs3011!K3011_DateArrive2) = False Then D3011.DateArrive2 = Trim$(rs3011!K3011_DateArrive2)
            If IsdbNull(rs3011!K3011_DateArrive3) = False Then D3011.DateArrive3 = Trim$(rs3011!K3011_DateArrive3)
            If IsdbNull(rs3011!K3011_DateArrive4) = False Then D3011.DateArrive4 = Trim$(rs3011!K3011_DateArrive4)
            If IsdbNull(rs3011!K3011_DateArrive5) = False Then D3011.DateArrive5 = Trim$(rs3011!K3011_DateArrive5)
            If IsdbNull(rs3011!K3011_QtyAArrive1) = False Then D3011.QtyAArrive1 = Trim$(rs3011!K3011_QtyAArrive1)
            If IsdbNull(rs3011!K3011_QtyAArrive2) = False Then D3011.QtyAArrive2 = Trim$(rs3011!K3011_QtyAArrive2)
            If IsdbNull(rs3011!K3011_QtyAArrive3) = False Then D3011.QtyAArrive3 = Trim$(rs3011!K3011_QtyAArrive3)
            If IsdbNull(rs3011!K3011_QtyAArrive4) = False Then D3011.QtyAArrive4 = Trim$(rs3011!K3011_QtyAArrive4)
            If IsdbNull(rs3011!K3011_QtyAArrive5) = False Then D3011.QtyAArrive5 = Trim$(rs3011!K3011_QtyAArrive5)
            If IsdbNull(rs3011!K3011_InchargeInvoice) = False Then D3011.InchargeInvoice = Trim$(rs3011!K3011_InchargeInvoice)
            If IsdbNull(rs3011!K3011_APLName) = False Then D3011.APLName = Trim$(rs3011!K3011_APLName)
            If IsdbNull(rs3011!K3011_AInvoice) = False Then D3011.AInvoice = Trim$(rs3011!K3011_AInvoice)
            If IsdbNull(rs3011!K3011_ARemark) = False Then D3011.ARemark = Trim$(rs3011!K3011_ARemark)
            If IsdbNull(rs3011!K3011_Remark) = False Then D3011.Remark = Trim$(rs3011!K3011_Remark)
            If IsDBNull(rs3011!K3011_RemarkLine) = False Then D3011.RemarkLine = Trim$(rs3011!K3011_RemarkLine)
            If IsDBNull(rs3011!K3011_RemarkMOQ) = False Then D3011.RemarkMOQ = Trim$(rs3011!K3011_RemarkMOQ)
            If IsDBNull(rs3011!K3011_QANote1) = False Then D3011.QANote1 = Trim$(rs3011!K3011_QANote1)
            If IsDBNull(rs3011!K3011_QANote2) = False Then D3011.QANote2 = Trim$(rs3011!K3011_QANote2)
            If IsDBNull(rs3011!K3011_QANote3) = False Then D3011.QANote3 = Trim$(rs3011!K3011_QANote3)
            If IsDBNull(rs3011!K3011_QANote) = False Then D3011.QANote = Trim$(rs3011!K3011_QANote)
            If IsdbNull(rs3011!K3011_seSite) = False Then D3011.seSite = Trim$(rs3011!K3011_seSite)
            If IsdbNull(rs3011!K3011_cdSite) = False Then D3011.cdSite = Trim$(rs3011!K3011_cdSite)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K3011_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K3011_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z3011 As T3011_AREA, AUTOKEY As Double) As Boolean

        K3011_MOVE = False

        Try
            If READ_PFK3011(AUTOKEY) = True Then
                z3011 = D3011
                K3011_MOVE = True
            Else
                z3011 = Nothing
            End If

            If getColumnIndex(spr, "Autokey") > -1 Then z3011.Autokey = Cdecp(getDataM(spr, getColumnIndex(spr, "Autokey"), xRow))
            If getColumnIndex(spr, "KindRevise") > -1 Then z3011.KindRevise = Cdecp(getDataM(spr, getColumnIndex(spr, "KindRevise"), xRow))
            If getColumnIndex(spr, "seSeason") > -1 Then z3011.seSeason = getDataM(spr, getColumnIndex(spr, "seSeason"), xRow)
            If getColumnIndex(spr, "cdSeason") > -1 Then z3011.cdSeason = getDataM(spr, getColumnIndex(spr, "cdSeason"), xRow)
            If getColumnIndex(spr, "OrderNo") > -1 Then z3011.OrderNo = getDataM(spr, getColumnIndex(spr, "OrderNo"), xRow)
            If getColumnIndex(spr, "OrderNoSeq") > -1 Then z3011.OrderNoSeq = getDataM(spr, getColumnIndex(spr, "OrderNoSeq"), xRow)
            If getColumnIndex(spr, "MaterialCodeBase") > -1 Then z3011.MaterialCodeBase = getDataM(spr, getColumnIndex(spr, "MaterialCodeBase"), xRow)
            If getColumnIndex(spr, "Materialcode") > -1 Then z3011.Materialcode = getDataM(spr, getColumnIndex(spr, "Materialcode"), xRow)
            If getColumnIndex(spr, "Description") > -1 Then z3011.Description = getDataM(spr, getColumnIndex(spr, "Description"), xRow)
            If getColumnIndex(spr, "Color") > -1 Then z3011.Color = getDataM(spr, getColumnIndex(spr, "Color"), xRow)
            If getColumnIndex(spr, "ColorCode") > -1 Then z3011.ColorCode = getDataM(spr, getColumnIndex(spr, "ColorCode"), xRow)
            If getColumnIndex(spr, "SizeNo") > -1 Then z3011.SizeNo = getDataM(spr, getColumnIndex(spr, "SizeNo"), xRow)
            If getColumnIndex(spr, "Specification") > -1 Then z3011.Specification = getDataM(spr, getColumnIndex(spr, "Specification"), xRow)
            If getColumnIndex(spr, "Width") > -1 Then z3011.Width = getDataM(spr, getColumnIndex(spr, "Width"), xRow)
            If getColumnIndex(spr, "Height") > -1 Then z3011.Height = getDataM(spr, getColumnIndex(spr, "Height"), xRow)
            If getColumnIndex(spr, "SizeName") > -1 Then z3011.SizeName = getDataM(spr, getColumnIndex(spr, "SizeName"), xRow)
            If getColumnIndex(spr, "ColorName") > -1 Then z3011.ColorName = getDataM(spr, getColumnIndex(spr, "ColorName"), xRow)
            If getColumnIndex(spr, "MaterialCheck") > -1 Then z3011.MaterialCheck = getDataM(spr, getColumnIndex(spr, "MaterialCheck"), xRow)
            If getColumnIndex(spr, "seShoesStatus") > -1 Then z3011.seShoesStatus = getDataM(spr, getColumnIndex(spr, "seShoesStatus"), xRow)
            If getColumnIndex(spr, "cdShoesStatus") > -1 Then z3011.cdShoesStatus = getDataM(spr, getColumnIndex(spr, "cdShoesStatus"), xRow)
            If getColumnIndex(spr, "seDepartment") > -1 Then z3011.seDepartment = getDataM(spr, getColumnIndex(spr, "seDepartment"), xRow)
            If getColumnIndex(spr, "cdDepartment") > -1 Then z3011.cdDepartment = getDataM(spr, getColumnIndex(spr, "cdDepartment"), xRow)
            If getColumnIndex(spr, "SupplierCode") > -1 Then z3011.SupplierCode = getDataM(spr, getColumnIndex(spr, "SupplierCode"), xRow)
            If getColumnIndex(spr, "MaterialPrice") > -1 Then z3011.MaterialPrice = Cdecp(getDataM(spr, getColumnIndex(spr, "MaterialPrice"), xRow))
            If getColumnIndex(spr, "seUnitPrice") > -1 Then z3011.seUnitPrice = getDataM(spr, getColumnIndex(spr, "seUnitPrice"), xRow)
            If getColumnIndex(spr, "cdUnitPrice") > -1 Then z3011.cdUnitPrice = getDataM(spr, getColumnIndex(spr, "cdUnitPrice"), xRow)
            If getColumnIndex(spr, "QtySales") > -1 Then z3011.QtySales = Cdecp(getDataM(spr, getColumnIndex(spr, "QtySales"), xRow))
            If getColumnIndex(spr, "QtySalesSample") > -1 Then z3011.QtySalesSample = Cdecp(getDataM(spr, getColumnIndex(spr, "QtySalesSample"), xRow))
            If getColumnIndex(spr, "GrossUsage") > -1 Then z3011.GrossUsage = Cdecp(getDataM(spr, getColumnIndex(spr, "GrossUsage"), xRow))
            If getColumnIndex(spr, "TotalQty") > -1 Then z3011.TotalQty = Cdecp(getDataM(spr, getColumnIndex(spr, "TotalQty"), xRow))
            If getColumnIndex(spr, "QtyOrder") > -1 Then z3011.QtyOrder = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyOrder"), xRow))
            If getColumnIndex(spr, "QtyAdjust") > -1 Then z3011.QtyAdjust = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyAdjust"), xRow))
            If getColumnIndex(spr, "QtyBooking") > -1 Then z3011.QtyBooking = CDecp(getDataM(spr, getColumnIndex(spr, "QtyBooking"), xRow))
            If getColumnIndex(spr, "QtyBooking1") > -1 Then z3011.QtyBooking1 = CDecp(getDataM(spr, getColumnIndex(spr, "QtyBooking1"), xRow))
            If getColumnIndex(spr, "QtyBooking2") > -1 Then z3011.QtyBooking2 = CDecp(getDataM(spr, getColumnIndex(spr, "QtyBooking2"), xRow))
            If getColumnIndex(spr, "QtyRequest") > -1 Then z3011.QtyRequest = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyRequest"), xRow))
            If getColumnIndex(spr, "QtyPurchasing") > -1 Then z3011.QtyPurchasing = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyPurchasing"), xRow))
            If getColumnIndex(spr, "QtySizebySize") > -1 Then z3011.QtySizebySize = Cdecp(getDataM(spr, getColumnIndex(spr, "QtySizebySize"), xRow))
            If getColumnIndex(spr, "seUnitMaterial") > -1 Then z3011.seUnitMaterial = getDataM(spr, getColumnIndex(spr, "seUnitMaterial"), xRow)
            If getColumnIndex(spr, "cdUnitMaterial") > -1 Then z3011.cdUnitMaterial = getDataM(spr, getColumnIndex(spr, "cdUnitMaterial"), xRow)
            If getColumnIndex(spr, "InchargeRequest") > -1 Then z3011.InchargeRequest = getDataM(spr, getColumnIndex(spr, "InchargeRequest"), xRow)
            If getColumnIndex(spr, "PRNo") > -1 Then z3011.PRNo = getDataM(spr, getColumnIndex(spr, "PRNo"), xRow)
            If getColumnIndex(spr, "PRNoSeq") > -1 Then z3011.PRNoSeq = getDataM(spr, getColumnIndex(spr, "PRNoSeq"), xRow)
            If getColumnIndex(spr, "CustomerCode") > -1 Then z3011.CustomerCode = getDataM(spr, getColumnIndex(spr, "CustomerCode"), xRow)
            If getColumnIndex(spr, "PRName") > -1 Then z3011.PRName = getDataM(spr, getColumnIndex(spr, "PRName"), xRow)
            If getColumnIndex(spr, "PurchasingOrderNo") > -1 Then z3011.PurchasingOrderNo = getDataM(spr, getColumnIndex(spr, "PurchasingOrderNo"), xRow)
            If getColumnIndex(spr, "PurchasingOrderSeq") > -1 Then z3011.PurchasingOrderSeq = Cdecp(getDataM(spr, getColumnIndex(spr, "PurchasingOrderSeq"), xRow))
            If getColumnIndex(spr, "CheckOrderMaterial") > -1 Then z3011.CheckOrderMaterial = getDataM(spr, getColumnIndex(spr, "CheckOrderMaterial"), xRow)
            If getColumnIndex(spr, "CheckAdjust") > -1 Then z3011.CheckAdjust = getDataM(spr, getColumnIndex(spr, "CheckAdjust"), xRow)
            If getColumnIndex(spr, "CheckGZ") > -1 Then z3011.CheckGZ = getDataM(spr, getColumnIndex(spr, "CheckGZ"), xRow)
            If getColumnIndex(spr, "DateAdjust") > -1 Then z3011.DateAdjust = getDataM(spr, getColumnIndex(spr, "DateAdjust"), xRow)
            If getColumnIndex(spr, "DateDelivery") > -1 Then z3011.DateDelivery = getDataM(spr, getColumnIndex(spr, "DateDelivery"), xRow)
            If getColumnIndex(spr, "DateOrderMaterialAccept") > -1 Then z3011.DateOrderMaterialAccept = getDataM(spr, getColumnIndex(spr, "DateOrderMaterialAccept"), xRow)
            If getColumnIndex(spr, "DateOrderMaterialComplete") > -1 Then z3011.DateOrderMaterialComplete = getDataM(spr, getColumnIndex(spr, "DateOrderMaterialComplete"), xRow)
            If getColumnIndex(spr, "DateOrderMaterialApproval") > -1 Then z3011.DateOrderMaterialApproval = getDataM(spr, getColumnIndex(spr, "DateOrderMaterialApproval"), xRow)
            If getColumnIndex(spr, "DateOrderMaterialCancel") > -1 Then z3011.DateOrderMaterialCancel = getDataM(spr, getColumnIndex(spr, "DateOrderMaterialCancel"), xRow)
            If getColumnIndex(spr, "TimeInsert") > -1 Then z3011.TimeInsert = getDataM(spr, getColumnIndex(spr, "TimeInsert"), xRow)
            If getColumnIndex(spr, "TimeUpdate") > -1 Then z3011.TimeUpdate = getDataM(spr, getColumnIndex(spr, "TimeUpdate"), xRow)
            If getColumnIndex(spr, "DateUpdate") > -1 Then z3011.DateUpdate = getDataM(spr, getColumnIndex(spr, "DateUpdate"), xRow)
            If getColumnIndex(spr, "DateInsert") > -1 Then z3011.DateInsert = getDataM(spr, getColumnIndex(spr, "DateInsert"), xRow)
            If getColumnIndex(spr, "DateUdate") > -1 Then z3011.DateUdate = getDataM(spr, getColumnIndex(spr, "DateUdate"), xRow)
            If getColumnIndex(spr, "InchargeInsert") > -1 Then z3011.InchargeInsert = getDataM(spr, getColumnIndex(spr, "InchargeInsert"), xRow)
            If getColumnIndex(spr, "InchargeUpdate") > -1 Then z3011.InchargeUpdate = getDataM(spr, getColumnIndex(spr, "InchargeUpdate"), xRow)
            If getColumnIndex(spr, "DateExcel") > -1 Then z3011.DateExcel = getDataM(spr, getColumnIndex(spr, "DateExcel"), xRow)
            If getColumnIndex(spr, "PriceAPurchasing") > -1 Then z3011.PriceAPurchasing = Cdecp(getDataM(spr, getColumnIndex(spr, "PriceAPurchasing"), xRow))
            If getColumnIndex(spr, "cdUnitMaterialA") > -1 Then z3011.cdUnitMaterialA = getDataM(spr, getColumnIndex(spr, "cdUnitMaterialA"), xRow)
            If getColumnIndex(spr, "cdUnitPriceA") > -1 Then z3011.cdUnitPriceA = getDataM(spr, getColumnIndex(spr, "cdUnitPriceA"), xRow)
            If getColumnIndex(spr, "QtyAPurchasing") > -1 Then z3011.QtyAPurchasing = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyAPurchasing"), xRow))
            If getColumnIndex(spr, "QtyATotal") > -1 Then z3011.QtyATotal = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyATotal"), xRow))
            If getColumnIndex(spr, "AmtAPurchasing") > -1 Then z3011.AmtAPurchasing = Cdecp(getDataM(spr, getColumnIndex(spr, "AmtAPurchasing"), xRow))
            If getColumnIndex(spr, "AmtATotal") > -1 Then z3011.AmtATotal = Cdecp(getDataM(spr, getColumnIndex(spr, "AmtATotal"), xRow))
            If getColumnIndex(spr, "DateArrive1") > -1 Then z3011.DateArrive1 = getDataM(spr, getColumnIndex(spr, "DateArrive1"), xRow)
            If getColumnIndex(spr, "DateArrive2") > -1 Then z3011.DateArrive2 = getDataM(spr, getColumnIndex(spr, "DateArrive2"), xRow)
            If getColumnIndex(spr, "DateArrive3") > -1 Then z3011.DateArrive3 = getDataM(spr, getColumnIndex(spr, "DateArrive3"), xRow)
            If getColumnIndex(spr, "DateArrive4") > -1 Then z3011.DateArrive4 = getDataM(spr, getColumnIndex(spr, "DateArrive4"), xRow)
            If getColumnIndex(spr, "DateArrive5") > -1 Then z3011.DateArrive5 = getDataM(spr, getColumnIndex(spr, "DateArrive5"), xRow)
            If getColumnIndex(spr, "QtyAArrive1") > -1 Then z3011.QtyAArrive1 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyAArrive1"), xRow))
            If getColumnIndex(spr, "QtyAArrive2") > -1 Then z3011.QtyAArrive2 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyAArrive2"), xRow))
            If getColumnIndex(spr, "QtyAArrive3") > -1 Then z3011.QtyAArrive3 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyAArrive3"), xRow))
            If getColumnIndex(spr, "QtyAArrive4") > -1 Then z3011.QtyAArrive4 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyAArrive4"), xRow))
            If getColumnIndex(spr, "QtyAArrive5") > -1 Then z3011.QtyAArrive5 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyAArrive5"), xRow))
            If getColumnIndex(spr, "InchargeInvoice") > -1 Then z3011.InchargeInvoice = getDataM(spr, getColumnIndex(spr, "InchargeInvoice"), xRow)
            If getColumnIndex(spr, "APLName") > -1 Then z3011.APLName = getDataM(spr, getColumnIndex(spr, "APLName"), xRow)
            If getColumnIndex(spr, "AInvoice") > -1 Then z3011.AInvoice = getDataM(spr, getColumnIndex(spr, "AInvoice"), xRow)
            If getColumnIndex(spr, "ARemark") > -1 Then z3011.ARemark = getDataM(spr, getColumnIndex(spr, "ARemark"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z3011.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)
            If getColumnIndex(spr, "RemarkLine") > -1 Then z3011.RemarkLine = getDataM(spr, getColumnIndex(spr, "RemarkLine"), xRow)
            If getColumnIndex(spr, "RemarkMOQ") > -1 Then z3011.RemarkMOQ = getDataM(spr, getColumnIndex(spr, "RemarkMOQ"), xRow)
            If getColumnIndex(spr, "QANote1") > -1 Then z3011.QANote1 = getDataM(spr, getColumnIndex(spr, "QANote1"), xRow)
            If getColumnIndex(spr, "QANote2") > -1 Then z3011.QANote2 = getDataM(spr, getColumnIndex(spr, "QANote2"), xRow)
            If getColumnIndex(spr, "QANote3") > -1 Then z3011.QANote3 = getDataM(spr, getColumnIndex(spr, "QANote3"), xRow)
            If getColumnIndex(spr, "QANote") > -1 Then z3011.QANote = getDataM(spr, getColumnIndex(spr, "QANote"), xRow)
            If getColumnIndex(spr, "seSite") > -1 Then z3011.seSite = getDataM(spr, getColumnIndex(spr, "seSite"), xRow)
            If getColumnIndex(spr, "cdSite") > -1 Then z3011.cdSite = getDataM(spr, getColumnIndex(spr, "cdSite"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3011_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K3011_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z3011 As T3011_AREA, CheckClear As Boolean, AUTOKEY As Double) As Boolean

        K3011_MOVE = False

        Try
            If READ_PFK3011(AUTOKEY) = True Then
                z3011 = D3011
                K3011_MOVE = True
            Else
                If CheckClear = True Then z3011 = Nothing
            End If

            If getColumnIndex(spr, "Autokey") > -1 Then z3011.Autokey = Cdecp(getDataM(spr, getColumnIndex(spr, "Autokey"), xRow))
            If getColumnIndex(spr, "KindRevise") > -1 Then z3011.KindRevise = Cdecp(getDataM(spr, getColumnIndex(spr, "KindRevise"), xRow))
            If getColumnIndex(spr, "seSeason") > -1 Then z3011.seSeason = getDataM(spr, getColumnIndex(spr, "seSeason"), xRow)
            If getColumnIndex(spr, "cdSeason") > -1 Then z3011.cdSeason = getDataM(spr, getColumnIndex(spr, "cdSeason"), xRow)
            If getColumnIndex(spr, "OrderNo") > -1 Then z3011.OrderNo = getDataM(spr, getColumnIndex(spr, "OrderNo"), xRow)
            If getColumnIndex(spr, "OrderNoSeq") > -1 Then z3011.OrderNoSeq = getDataM(spr, getColumnIndex(spr, "OrderNoSeq"), xRow)
            If getColumnIndex(spr, "MaterialCodeBase") > -1 Then z3011.MaterialCodeBase = getDataM(spr, getColumnIndex(spr, "MaterialCodeBase"), xRow)
            If getColumnIndex(spr, "Materialcode") > -1 Then z3011.Materialcode = getDataM(spr, getColumnIndex(spr, "Materialcode"), xRow)
            If getColumnIndex(spr, "Description") > -1 Then z3011.Description = getDataM(spr, getColumnIndex(spr, "Description"), xRow)
            If getColumnIndex(spr, "Color") > -1 Then z3011.Color = getDataM(spr, getColumnIndex(spr, "Color"), xRow)
            If getColumnIndex(spr, "ColorCode") > -1 Then z3011.ColorCode = getDataM(spr, getColumnIndex(spr, "ColorCode"), xRow)
            If getColumnIndex(spr, "SizeNo") > -1 Then z3011.SizeNo = getDataM(spr, getColumnIndex(spr, "SizeNo"), xRow)
            If getColumnIndex(spr, "Specification") > -1 Then z3011.Specification = getDataM(spr, getColumnIndex(spr, "Specification"), xRow)
            If getColumnIndex(spr, "Width") > -1 Then z3011.Width = getDataM(spr, getColumnIndex(spr, "Width"), xRow)
            If getColumnIndex(spr, "Height") > -1 Then z3011.Height = getDataM(spr, getColumnIndex(spr, "Height"), xRow)
            If getColumnIndex(spr, "SizeName") > -1 Then z3011.SizeName = getDataM(spr, getColumnIndex(spr, "SizeName"), xRow)
            If getColumnIndex(spr, "ColorName") > -1 Then z3011.ColorName = getDataM(spr, getColumnIndex(spr, "ColorName"), xRow)
            If getColumnIndex(spr, "MaterialCheck") > -1 Then z3011.MaterialCheck = getDataM(spr, getColumnIndex(spr, "MaterialCheck"), xRow)
            If getColumnIndex(spr, "seShoesStatus") > -1 Then z3011.seShoesStatus = getDataM(spr, getColumnIndex(spr, "seShoesStatus"), xRow)
            If getColumnIndex(spr, "cdShoesStatus") > -1 Then z3011.cdShoesStatus = getDataM(spr, getColumnIndex(spr, "cdShoesStatus"), xRow)
            If getColumnIndex(spr, "seDepartment") > -1 Then z3011.seDepartment = getDataM(spr, getColumnIndex(spr, "seDepartment"), xRow)
            If getColumnIndex(spr, "cdDepartment") > -1 Then z3011.cdDepartment = getDataM(spr, getColumnIndex(spr, "cdDepartment"), xRow)
            If getColumnIndex(spr, "SupplierCode") > -1 Then z3011.SupplierCode = getDataM(spr, getColumnIndex(spr, "SupplierCode"), xRow)
            If getColumnIndex(spr, "MaterialPrice") > -1 Then z3011.MaterialPrice = Cdecp(getDataM(spr, getColumnIndex(spr, "MaterialPrice"), xRow))
            If getColumnIndex(spr, "seUnitPrice") > -1 Then z3011.seUnitPrice = getDataM(spr, getColumnIndex(spr, "seUnitPrice"), xRow)
            If getColumnIndex(spr, "cdUnitPrice") > -1 Then z3011.cdUnitPrice = getDataM(spr, getColumnIndex(spr, "cdUnitPrice"), xRow)
            If getColumnIndex(spr, "QtySales") > -1 Then z3011.QtySales = Cdecp(getDataM(spr, getColumnIndex(spr, "QtySales"), xRow))
            If getColumnIndex(spr, "QtySalesSample") > -1 Then z3011.QtySalesSample = Cdecp(getDataM(spr, getColumnIndex(spr, "QtySalesSample"), xRow))
            If getColumnIndex(spr, "GrossUsage") > -1 Then z3011.GrossUsage = Cdecp(getDataM(spr, getColumnIndex(spr, "GrossUsage"), xRow))
            If getColumnIndex(spr, "TotalQty") > -1 Then z3011.TotalQty = Cdecp(getDataM(spr, getColumnIndex(spr, "TotalQty"), xRow))
            If getColumnIndex(spr, "QtyOrder") > -1 Then z3011.QtyOrder = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyOrder"), xRow))
            If getColumnIndex(spr, "QtyAdjust") > -1 Then z3011.QtyAdjust = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyAdjust"), xRow))
            If getColumnIndex(spr, "QtyBooking") > -1 Then z3011.QtyBooking = CDecp(getDataM(spr, getColumnIndex(spr, "QtyBooking"), xRow))
            If getColumnIndex(spr, "QtyBooking1") > -1 Then z3011.QtyBooking1 = CDecp(getDataM(spr, getColumnIndex(spr, "QtyBooking1"), xRow))
            If getColumnIndex(spr, "QtyBooking2") > -1 Then z3011.QtyBooking2 = CDecp(getDataM(spr, getColumnIndex(spr, "QtyBooking2"), xRow))
            If getColumnIndex(spr, "QtyRequest") > -1 Then z3011.QtyRequest = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyRequest"), xRow))
            If getColumnIndex(spr, "QtyPurchasing") > -1 Then z3011.QtyPurchasing = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyPurchasing"), xRow))
            If getColumnIndex(spr, "QtySizebySize") > -1 Then z3011.QtySizebySize = Cdecp(getDataM(spr, getColumnIndex(spr, "QtySizebySize"), xRow))
            If getColumnIndex(spr, "seUnitMaterial") > -1 Then z3011.seUnitMaterial = getDataM(spr, getColumnIndex(spr, "seUnitMaterial"), xRow)
            If getColumnIndex(spr, "cdUnitMaterial") > -1 Then z3011.cdUnitMaterial = getDataM(spr, getColumnIndex(spr, "cdUnitMaterial"), xRow)
            If getColumnIndex(spr, "InchargeRequest") > -1 Then z3011.InchargeRequest = getDataM(spr, getColumnIndex(spr, "InchargeRequest"), xRow)
            If getColumnIndex(spr, "PRNo") > -1 Then z3011.PRNo = getDataM(spr, getColumnIndex(spr, "PRNo"), xRow)
            If getColumnIndex(spr, "PRNoSeq") > -1 Then z3011.PRNoSeq = getDataM(spr, getColumnIndex(spr, "PRNoSeq"), xRow)
            If getColumnIndex(spr, "CustomerCode") > -1 Then z3011.CustomerCode = getDataM(spr, getColumnIndex(spr, "CustomerCode"), xRow)
            If getColumnIndex(spr, "PRName") > -1 Then z3011.PRName = getDataM(spr, getColumnIndex(spr, "PRName"), xRow)
            If getColumnIndex(spr, "PurchasingOrderNo") > -1 Then z3011.PurchasingOrderNo = getDataM(spr, getColumnIndex(spr, "PurchasingOrderNo"), xRow)
            If getColumnIndex(spr, "PurchasingOrderSeq") > -1 Then z3011.PurchasingOrderSeq = Cdecp(getDataM(spr, getColumnIndex(spr, "PurchasingOrderSeq"), xRow))
            If getColumnIndex(spr, "CheckOrderMaterial") > -1 Then z3011.CheckOrderMaterial = getDataM(spr, getColumnIndex(spr, "CheckOrderMaterial"), xRow)
            If getColumnIndex(spr, "CheckAdjust") > -1 Then z3011.CheckAdjust = getDataM(spr, getColumnIndex(spr, "CheckAdjust"), xRow)
            If getColumnIndex(spr, "CheckGZ") > -1 Then z3011.CheckGZ = getDataM(spr, getColumnIndex(spr, "CheckGZ"), xRow)
            If getColumnIndex(spr, "DateAdjust") > -1 Then z3011.DateAdjust = getDataM(spr, getColumnIndex(spr, "DateAdjust"), xRow)
            If getColumnIndex(spr, "DateDelivery") > -1 Then z3011.DateDelivery = getDataM(spr, getColumnIndex(spr, "DateDelivery"), xRow)
            If getColumnIndex(spr, "DateOrderMaterialAccept") > -1 Then z3011.DateOrderMaterialAccept = getDataM(spr, getColumnIndex(spr, "DateOrderMaterialAccept"), xRow)
            If getColumnIndex(spr, "DateOrderMaterialComplete") > -1 Then z3011.DateOrderMaterialComplete = getDataM(spr, getColumnIndex(spr, "DateOrderMaterialComplete"), xRow)
            If getColumnIndex(spr, "DateOrderMaterialApproval") > -1 Then z3011.DateOrderMaterialApproval = getDataM(spr, getColumnIndex(spr, "DateOrderMaterialApproval"), xRow)
            If getColumnIndex(spr, "DateOrderMaterialCancel") > -1 Then z3011.DateOrderMaterialCancel = getDataM(spr, getColumnIndex(spr, "DateOrderMaterialCancel"), xRow)
            If getColumnIndex(spr, "TimeInsert") > -1 Then z3011.TimeInsert = getDataM(spr, getColumnIndex(spr, "TimeInsert"), xRow)
            If getColumnIndex(spr, "TimeUpdate") > -1 Then z3011.TimeUpdate = getDataM(spr, getColumnIndex(spr, "TimeUpdate"), xRow)
            If getColumnIndex(spr, "DateUpdate") > -1 Then z3011.DateUpdate = getDataM(spr, getColumnIndex(spr, "DateUpdate"), xRow)
            If getColumnIndex(spr, "DateInsert") > -1 Then z3011.DateInsert = getDataM(spr, getColumnIndex(spr, "DateInsert"), xRow)
            If getColumnIndex(spr, "DateUdate") > -1 Then z3011.DateUdate = getDataM(spr, getColumnIndex(spr, "DateUdate"), xRow)
            If getColumnIndex(spr, "InchargeInsert") > -1 Then z3011.InchargeInsert = getDataM(spr, getColumnIndex(spr, "InchargeInsert"), xRow)
            If getColumnIndex(spr, "InchargeUpdate") > -1 Then z3011.InchargeUpdate = getDataM(spr, getColumnIndex(spr, "InchargeUpdate"), xRow)
            If getColumnIndex(spr, "DateExcel") > -1 Then z3011.DateExcel = getDataM(spr, getColumnIndex(spr, "DateExcel"), xRow)
            If getColumnIndex(spr, "PriceAPurchasing") > -1 Then z3011.PriceAPurchasing = Cdecp(getDataM(spr, getColumnIndex(spr, "PriceAPurchasing"), xRow))
            If getColumnIndex(spr, "cdUnitMaterialA") > -1 Then z3011.cdUnitMaterialA = getDataM(spr, getColumnIndex(spr, "cdUnitMaterialA"), xRow)
            If getColumnIndex(spr, "cdUnitPriceA") > -1 Then z3011.cdUnitPriceA = getDataM(spr, getColumnIndex(spr, "cdUnitPriceA"), xRow)
            If getColumnIndex(spr, "QtyAPurchasing") > -1 Then z3011.QtyAPurchasing = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyAPurchasing"), xRow))
            If getColumnIndex(spr, "QtyATotal") > -1 Then z3011.QtyATotal = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyATotal"), xRow))
            If getColumnIndex(spr, "AmtAPurchasing") > -1 Then z3011.AmtAPurchasing = Cdecp(getDataM(spr, getColumnIndex(spr, "AmtAPurchasing"), xRow))
            If getColumnIndex(spr, "AmtATotal") > -1 Then z3011.AmtATotal = Cdecp(getDataM(spr, getColumnIndex(spr, "AmtATotal"), xRow))
            If getColumnIndex(spr, "DateArrive1") > -1 Then z3011.DateArrive1 = getDataM(spr, getColumnIndex(spr, "DateArrive1"), xRow)
            If getColumnIndex(spr, "DateArrive2") > -1 Then z3011.DateArrive2 = getDataM(spr, getColumnIndex(spr, "DateArrive2"), xRow)
            If getColumnIndex(spr, "DateArrive3") > -1 Then z3011.DateArrive3 = getDataM(spr, getColumnIndex(spr, "DateArrive3"), xRow)
            If getColumnIndex(spr, "DateArrive4") > -1 Then z3011.DateArrive4 = getDataM(spr, getColumnIndex(spr, "DateArrive4"), xRow)
            If getColumnIndex(spr, "DateArrive5") > -1 Then z3011.DateArrive5 = getDataM(spr, getColumnIndex(spr, "DateArrive5"), xRow)
            If getColumnIndex(spr, "QtyAArrive1") > -1 Then z3011.QtyAArrive1 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyAArrive1"), xRow))
            If getColumnIndex(spr, "QtyAArrive2") > -1 Then z3011.QtyAArrive2 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyAArrive2"), xRow))
            If getColumnIndex(spr, "QtyAArrive3") > -1 Then z3011.QtyAArrive3 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyAArrive3"), xRow))
            If getColumnIndex(spr, "QtyAArrive4") > -1 Then z3011.QtyAArrive4 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyAArrive4"), xRow))
            If getColumnIndex(spr, "QtyAArrive5") > -1 Then z3011.QtyAArrive5 = Cdecp(getDataM(spr, getColumnIndex(spr, "QtyAArrive5"), xRow))
            If getColumnIndex(spr, "InchargeInvoice") > -1 Then z3011.InchargeInvoice = getDataM(spr, getColumnIndex(spr, "InchargeInvoice"), xRow)
            If getColumnIndex(spr, "APLName") > -1 Then z3011.APLName = getDataM(spr, getColumnIndex(spr, "APLName"), xRow)
            If getColumnIndex(spr, "AInvoice") > -1 Then z3011.AInvoice = getDataM(spr, getColumnIndex(spr, "AInvoice"), xRow)
            If getColumnIndex(spr, "ARemark") > -1 Then z3011.ARemark = getDataM(spr, getColumnIndex(spr, "ARemark"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z3011.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)
            If getColumnIndex(spr, "RemarkLine") > -1 Then z3011.RemarkLine = getDataM(spr, getColumnIndex(spr, "RemarkLine"), xRow)
            If getColumnIndex(spr, "RemarkMOQ") > -1 Then z3011.RemarkMOQ = getDataM(spr, getColumnIndex(spr, "RemarkMOQ"), xRow)
            If getColumnIndex(spr, "QANote1") > -1 Then z3011.QANote1 = getDataM(spr, getColumnIndex(spr, "QANote1"), xRow)
            If getColumnIndex(spr, "QANote2") > -1 Then z3011.QANote2 = getDataM(spr, getColumnIndex(spr, "QANote2"), xRow)
            If getColumnIndex(spr, "QANote3") > -1 Then z3011.QANote3 = getDataM(spr, getColumnIndex(spr, "QANote3"), xRow)
            If getColumnIndex(spr, "QANote") > -1 Then z3011.QANote = getDataM(spr, getColumnIndex(spr, "QANote"), xRow)
            If getColumnIndex(spr, "seSite") > -1 Then z3011.seSite = getDataM(spr, getColumnIndex(spr, "seSite"), xRow)
            If getColumnIndex(spr, "cdSite") > -1 Then z3011.cdSite = getDataM(spr, getColumnIndex(spr, "cdSite"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3011_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K3011_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z3011 As T3011_AREA, Job As String, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K3011_MOVE = False

        Try
            If READ_PFK3011(AUTOKEY) = True Then
                z3011 = D3011
                K3011_MOVE = True
            Else
                z3011 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3011")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z3011.Autokey = Children(i).Code
                                Case "KINDREVISE" : z3011.KindRevise = Children(i).Code
                                Case "SESEASON" : z3011.seSeason = Children(i).Code
                                Case "CDSEASON" : z3011.cdSeason = Children(i).Code
                                Case "ORDERNO" : z3011.OrderNo = Children(i).Code
                                Case "ORDERNOSEQ" : z3011.OrderNoSeq = Children(i).Code
                                Case "MATERIALCODEBASE" : z3011.MaterialCodeBase = Children(i).Code
                                Case "MATERIALCODE" : z3011.Materialcode = Children(i).Code
                                Case "DESCRIPTION" : z3011.Description = Children(i).Code
                                Case "COLOR" : z3011.Color = Children(i).Code
                                Case "COLORCODE" : z3011.ColorCode = Children(i).Code
                                Case "SIZENO" : z3011.SizeNo = Children(i).Code
                                Case "SPECIFICATION" : z3011.Specification = Children(i).Code
                                Case "WIDTH" : z3011.Width = Children(i).Code
                                Case "HEIGHT" : z3011.Height = Children(i).Code
                                Case "SIZENAME" : z3011.SizeName = Children(i).Code
                                Case "COLORNAME" : z3011.ColorName = Children(i).Code
                                Case "MATERIALCHECK" : z3011.MaterialCheck = Children(i).Code
                                Case "SESHOESSTATUS" : z3011.seShoesStatus = Children(i).Code
                                Case "CDSHOESSTATUS" : z3011.cdShoesStatus = Children(i).Code
                                Case "SEDEPARTMENT" : z3011.seDepartment = Children(i).Code
                                Case "CDDEPARTMENT" : z3011.cdDepartment = Children(i).Code
                                Case "SUPPLIERCODE" : z3011.SupplierCode = Children(i).Code
                                Case "MATERIALPRICE" : z3011.MaterialPrice = Children(i).Code
                                Case "SEUNITPRICE" : z3011.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z3011.cdUnitPrice = Children(i).Code
                                Case "QTYSALES" : z3011.QtySales = Children(i).Code
                                Case "QTYSALESSAMPLE" : z3011.QtySalesSample = Children(i).Code
                                Case "GROSSUSAGE" : z3011.GrossUsage = Children(i).Code
                                Case "TOTALQTY" : z3011.TotalQty = Children(i).Code
                                Case "QTYORDER" : z3011.QtyOrder = Children(i).Code
                                Case "QTYADJUST" : z3011.QtyAdjust = Children(i).Code
                                Case "QTYBOOKING" : z3011.QtyBooking = Children(i).Code
                                Case "QtyBooking1" : z3011.QtyBooking1 = Children(i).Code
                                Case "QtyBooking2" : z3011.QtyBooking2 = Children(i).Code
                                Case "QTYREQUEST" : z3011.QtyRequest = Children(i).Code
                                Case "QTYPURCHASING" : z3011.QtyPurchasing = Children(i).Code
                                Case "QTYSIZEBYSIZE" : z3011.QtySizebySize = Children(i).Code
                                Case "SEUNITMATERIAL" : z3011.seUnitMaterial = Children(i).Code
                                Case "CDUNITMATERIAL" : z3011.cdUnitMaterial = Children(i).Code
                                Case "INCHARGEREQUEST" : z3011.InchargeRequest = Children(i).Code
                                Case "PRNO" : z3011.PRNo = Children(i).Code
                                Case "PRNOSEQ" : z3011.PRNoSeq = Children(i).Code
                                Case "CUSTOMERCODE" : z3011.CustomerCode = Children(i).Code
                                Case "PRNAME" : z3011.PRName = Children(i).Code
                                Case "PURCHASINGORDERNO" : z3011.PurchasingOrderNo = Children(i).Code
                                Case "PURCHASINGORDERSEQ" : z3011.PurchasingOrderSeq = Children(i).Code
                                Case "CHECKORDERMATERIAL" : z3011.CheckOrderMaterial = Children(i).Code
                                Case "CHECKADJUST" : z3011.CheckAdjust = Children(i).Code
                                Case "CHECKGZ" : z3011.CheckGZ = Children(i).Code
                                Case "DATEADJUST" : z3011.DateAdjust = Children(i).Code
                                Case "DATEDELIVERY" : z3011.DateDelivery = Children(i).Code
                                Case "DATEORDERMATERIALACCEPT" : z3011.DateOrderMaterialAccept = Children(i).Code
                                Case "DATEORDERMATERIALCOMPLETE" : z3011.DateOrderMaterialComplete = Children(i).Code
                                Case "DATEORDERMATERIALAPPROVAL" : z3011.DateOrderMaterialApproval = Children(i).Code
                                Case "DATEORDERMATERIALCANCEL" : z3011.DateOrderMaterialCancel = Children(i).Code
                                Case "TIMEINSERT" : z3011.TimeInsert = Children(i).Code
                                Case "TIMEUPDATE" : z3011.TimeUpdate = Children(i).Code
                                Case "DATEUPDATE" : z3011.DateUpdate = Children(i).Code
                                Case "DATEINSERT" : z3011.DateInsert = Children(i).Code
                                Case "DATEUDATE" : z3011.DateUdate = Children(i).Code
                                Case "INCHARGEINSERT" : z3011.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z3011.InchargeUpdate = Children(i).Code
                                Case "DATEEXCEL" : z3011.DateExcel = Children(i).Code
                                Case "PRICEAPURCHASING" : z3011.PriceAPurchasing = Children(i).Code
                                Case "CDUNITMATERIALA" : z3011.cdUnitMaterialA = Children(i).Code
                                Case "CDUNITPRICEA" : z3011.cdUnitPriceA = Children(i).Code
                                Case "QTYAPURCHASING" : z3011.QtyAPurchasing = Children(i).Code
                                Case "QTYATOTAL" : z3011.QtyATotal = Children(i).Code
                                Case "AMTAPURCHASING" : z3011.AmtAPurchasing = Children(i).Code
                                Case "AMTATOTAL" : z3011.AmtATotal = Children(i).Code
                                Case "DATEARRIVE1" : z3011.DateArrive1 = Children(i).Code
                                Case "DATEARRIVE2" : z3011.DateArrive2 = Children(i).Code
                                Case "DATEARRIVE3" : z3011.DateArrive3 = Children(i).Code
                                Case "DATEARRIVE4" : z3011.DateArrive4 = Children(i).Code
                                Case "DATEARRIVE5" : z3011.DateArrive5 = Children(i).Code
                                Case "QTYAARRIVE1" : z3011.QtyAArrive1 = Children(i).Code
                                Case "QTYAARRIVE2" : z3011.QtyAArrive2 = Children(i).Code
                                Case "QTYAARRIVE3" : z3011.QtyAArrive3 = Children(i).Code
                                Case "QTYAARRIVE4" : z3011.QtyAArrive4 = Children(i).Code
                                Case "QTYAARRIVE5" : z3011.QtyAArrive5 = Children(i).Code
                                Case "INCHARGEINVOICE" : z3011.InchargeInvoice = Children(i).Code
                                Case "APLNAME" : z3011.APLName = Children(i).Code
                                Case "AINVOICE" : z3011.AInvoice = Children(i).Code
                                Case "AREMARK" : z3011.ARemark = Children(i).Code
                                Case "REMARK" : z3011.Remark = Children(i).Code
                                Case "REMARKLINE" : z3011.RemarkLine = Children(i).Code
                                Case "RemarkMOQ" : z3011.RemarkMOQ = Children(i).Code
                                Case "QANote1" : z3011.QANote1 = Children(i).Code
                                Case "QANote2" : z3011.QANote2 = Children(i).Code
                                Case "QANote3" : z3011.QANote3 = Children(i).Code
                                Case "QANote" : z3011.QANote = Children(i).Code
                                Case "SESITE" : z3011.seSite = Children(i).Code
                                Case "CDSITE" : z3011.cdSite = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z3011.Autokey = Cdecp(Children(i).Data)
                                Case "KINDREVISE" : z3011.KindRevise = Cdecp(Children(i).Data)
                                Case "SESEASON" : z3011.seSeason = Children(i).Data
                                Case "CDSEASON" : z3011.cdSeason = Children(i).Data
                                Case "ORDERNO" : z3011.OrderNo = Children(i).Data
                                Case "ORDERNOSEQ" : z3011.OrderNoSeq = Children(i).Data
                                Case "MATERIALCODEBASE" : z3011.MaterialCodeBase = Children(i).Data
                                Case "MATERIALCODE" : z3011.Materialcode = Children(i).Data
                                Case "DESCRIPTION" : z3011.Description = Children(i).Data
                                Case "COLOR" : z3011.Color = Children(i).Data
                                Case "COLORCODE" : z3011.ColorCode = Children(i).Data
                                Case "SIZENO" : z3011.SizeNo = Children(i).Data
                                Case "SPECIFICATION" : z3011.Specification = Children(i).Data
                                Case "WIDTH" : z3011.Width = Children(i).Data
                                Case "HEIGHT" : z3011.Height = Children(i).Data
                                Case "SIZENAME" : z3011.SizeName = Children(i).Data
                                Case "COLORNAME" : z3011.ColorName = Children(i).Data
                                Case "MATERIALCHECK" : z3011.MaterialCheck = Children(i).Data
                                Case "SESHOESSTATUS" : z3011.seShoesStatus = Children(i).Data
                                Case "CDSHOESSTATUS" : z3011.cdShoesStatus = Children(i).Data
                                Case "SEDEPARTMENT" : z3011.seDepartment = Children(i).Data
                                Case "CDDEPARTMENT" : z3011.cdDepartment = Children(i).Data
                                Case "SUPPLIERCODE" : z3011.SupplierCode = Children(i).Data
                                Case "MATERIALPRICE" : z3011.MaterialPrice = Cdecp(Children(i).Data)
                                Case "SEUNITPRICE" : z3011.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z3011.cdUnitPrice = Children(i).Data
                                Case "QTYSALES" : z3011.QtySales = Cdecp(Children(i).Data)
                                Case "QTYSALESSAMPLE" : z3011.QtySalesSample = Cdecp(Children(i).Data)
                                Case "GROSSUSAGE" : z3011.GrossUsage = Cdecp(Children(i).Data)
                                Case "TOTALQTY" : z3011.TotalQty = Cdecp(Children(i).Data)
                                Case "QTYORDER" : z3011.QtyOrder = Cdecp(Children(i).Data)
                                Case "QTYADJUST" : z3011.QtyAdjust = Cdecp(Children(i).Data)
                                Case "QTYBOOKING" : z3011.QtyBooking = CDecp(Children(i).Data)
                                Case "QtyBooking1" : z3011.QtyBooking1 = CDecp(Children(i).Data)
                                Case "QtyBooking2" : z3011.QtyBooking2 = CDecp(Children(i).Data)
                                Case "QTYREQUEST" : z3011.QtyRequest = Cdecp(Children(i).Data)
                                Case "QTYPURCHASING" : z3011.QtyPurchasing = Cdecp(Children(i).Data)
                                Case "QTYSIZEBYSIZE" : z3011.QtySizebySize = Cdecp(Children(i).Data)
                                Case "SEUNITMATERIAL" : z3011.seUnitMaterial = Children(i).Data
                                Case "CDUNITMATERIAL" : z3011.cdUnitMaterial = Children(i).Data
                                Case "INCHARGEREQUEST" : z3011.InchargeRequest = Children(i).Data
                                Case "PRNO" : z3011.PRNo = Children(i).Data
                                Case "PRNOSEQ" : z3011.PRNoSeq = Children(i).Data
                                Case "CUSTOMERCODE" : z3011.CustomerCode = Children(i).Data
                                Case "PRNAME" : z3011.PRName = Children(i).Data
                                Case "PURCHASINGORDERNO" : z3011.PurchasingOrderNo = Children(i).Data
                                Case "PURCHASINGORDERSEQ" : z3011.PurchasingOrderSeq = Cdecp(Children(i).Data)
                                Case "CHECKORDERMATERIAL" : z3011.CheckOrderMaterial = Children(i).Data
                                Case "CHECKADJUST" : z3011.CheckAdjust = Children(i).Data
                                Case "CHECKGZ" : z3011.CheckGZ = Children(i).Data
                                Case "DATEADJUST" : z3011.DateAdjust = Children(i).Data
                                Case "DATEDELIVERY" : z3011.DateDelivery = Children(i).Data
                                Case "DATEORDERMATERIALACCEPT" : z3011.DateOrderMaterialAccept = Children(i).Data
                                Case "DATEORDERMATERIALCOMPLETE" : z3011.DateOrderMaterialComplete = Children(i).Data
                                Case "DATEORDERMATERIALAPPROVAL" : z3011.DateOrderMaterialApproval = Children(i).Data
                                Case "DATEORDERMATERIALCANCEL" : z3011.DateOrderMaterialCancel = Children(i).Data
                                Case "TIMEINSERT" : z3011.TimeInsert = Children(i).Data
                                Case "TIMEUPDATE" : z3011.TimeUpdate = Children(i).Data
                                Case "DATEUPDATE" : z3011.DateUpdate = Children(i).Data
                                Case "DATEINSERT" : z3011.DateInsert = Children(i).Data
                                Case "DATEUDATE" : z3011.DateUdate = Children(i).Data
                                Case "INCHARGEINSERT" : z3011.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z3011.InchargeUpdate = Children(i).Data
                                Case "DATEEXCEL" : z3011.DateExcel = Children(i).Data
                                Case "PRICEAPURCHASING" : z3011.PriceAPurchasing = Cdecp(Children(i).Data)
                                Case "CDUNITMATERIALA" : z3011.cdUnitMaterialA = Children(i).Data
                                Case "CDUNITPRICEA" : z3011.cdUnitPriceA = Children(i).Data
                                Case "QTYAPURCHASING" : z3011.QtyAPurchasing = Cdecp(Children(i).Data)
                                Case "QTYATOTAL" : z3011.QtyATotal = Cdecp(Children(i).Data)
                                Case "AMTAPURCHASING" : z3011.AmtAPurchasing = Cdecp(Children(i).Data)
                                Case "AMTATOTAL" : z3011.AmtATotal = Cdecp(Children(i).Data)
                                Case "DATEARRIVE1" : z3011.DateArrive1 = Children(i).Data
                                Case "DATEARRIVE2" : z3011.DateArrive2 = Children(i).Data
                                Case "DATEARRIVE3" : z3011.DateArrive3 = Children(i).Data
                                Case "DATEARRIVE4" : z3011.DateArrive4 = Children(i).Data
                                Case "DATEARRIVE5" : z3011.DateArrive5 = Children(i).Data
                                Case "QTYAARRIVE1" : z3011.QtyAArrive1 = Cdecp(Children(i).Data)
                                Case "QTYAARRIVE2" : z3011.QtyAArrive2 = Cdecp(Children(i).Data)
                                Case "QTYAARRIVE3" : z3011.QtyAArrive3 = Cdecp(Children(i).Data)
                                Case "QTYAARRIVE4" : z3011.QtyAArrive4 = Cdecp(Children(i).Data)
                                Case "QTYAARRIVE5" : z3011.QtyAArrive5 = Cdecp(Children(i).Data)
                                Case "INCHARGEINVOICE" : z3011.InchargeInvoice = Children(i).Data
                                Case "APLNAME" : z3011.APLName = Children(i).Data
                                Case "AINVOICE" : z3011.AInvoice = Children(i).Data
                                Case "AREMARK" : z3011.ARemark = Children(i).Data
                                Case "REMARK" : z3011.Remark = Children(i).Data
                                Case "REMARKLINE" : z3011.RemarkLine = Children(i).Data
                                Case "RemarkMOQ" : z3011.RemarkMOQ = Children(i).Data
                                Case "QANote1" : z3011.QANote1 = Children(i).Data
                                Case "QANote2" : z3011.QANote2 = Children(i).Data
                                Case "QANote3" : z3011.QANote3 = Children(i).Data
                                Case "QANote" : z3011.QANote = Children(i).Data
                                Case "SESITE" : z3011.seSite = Children(i).Data
                                Case "CDSITE" : z3011.cdSite = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3011_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K3011_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z3011 As T3011_AREA, Job As String, CheckClear As Boolean, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K3011_MOVE = False

        Try
            If READ_PFK3011(AUTOKEY) = True Then
                z3011 = D3011
                K3011_MOVE = True
            Else
                If CheckClear = True Then z3011 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3011")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z3011.Autokey = Children(i).Code
                                Case "KINDREVISE" : z3011.KindRevise = Children(i).Code
                                Case "SESEASON" : z3011.seSeason = Children(i).Code
                                Case "CDSEASON" : z3011.cdSeason = Children(i).Code
                                Case "ORDERNO" : z3011.OrderNo = Children(i).Code
                                Case "ORDERNOSEQ" : z3011.OrderNoSeq = Children(i).Code
                                Case "MATERIALCODEBASE" : z3011.MaterialCodeBase = Children(i).Code
                                Case "MATERIALCODE" : z3011.Materialcode = Children(i).Code
                                Case "DESCRIPTION" : z3011.Description = Children(i).Code
                                Case "COLOR" : z3011.Color = Children(i).Code
                                Case "COLORCODE" : z3011.ColorCode = Children(i).Code
                                Case "SIZENO" : z3011.SizeNo = Children(i).Code
                                Case "SPECIFICATION" : z3011.Specification = Children(i).Code
                                Case "WIDTH" : z3011.Width = Children(i).Code
                                Case "HEIGHT" : z3011.Height = Children(i).Code
                                Case "SIZENAME" : z3011.SizeName = Children(i).Code
                                Case "COLORNAME" : z3011.ColorName = Children(i).Code
                                Case "MATERIALCHECK" : z3011.MaterialCheck = Children(i).Code
                                Case "SESHOESSTATUS" : z3011.seShoesStatus = Children(i).Code
                                Case "CDSHOESSTATUS" : z3011.cdShoesStatus = Children(i).Code
                                Case "SEDEPARTMENT" : z3011.seDepartment = Children(i).Code
                                Case "CDDEPARTMENT" : z3011.cdDepartment = Children(i).Code
                                Case "SUPPLIERCODE" : z3011.SupplierCode = Children(i).Code
                                Case "MATERIALPRICE" : z3011.MaterialPrice = Children(i).Code
                                Case "SEUNITPRICE" : z3011.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z3011.cdUnitPrice = Children(i).Code
                                Case "QTYSALES" : z3011.QtySales = Children(i).Code
                                Case "QTYSALESSAMPLE" : z3011.QtySalesSample = Children(i).Code
                                Case "GROSSUSAGE" : z3011.GrossUsage = Children(i).Code
                                Case "TOTALQTY" : z3011.TotalQty = Children(i).Code
                                Case "QTYORDER" : z3011.QtyOrder = Children(i).Code
                                Case "QTYADJUST" : z3011.QtyAdjust = Children(i).Code
                                Case "QTYBOOKING" : z3011.QtyBooking = Children(i).Code
                                Case "QtyBooking1" : z3011.QtyBooking1 = Children(i).Code
                                Case "QtyBooking2" : z3011.QtyBooking2 = Children(i).Code
                                Case "QTYREQUEST" : z3011.QtyRequest = Children(i).Code
                                Case "QTYPURCHASING" : z3011.QtyPurchasing = Children(i).Code
                                Case "QTYSIZEBYSIZE" : z3011.QtySizebySize = Children(i).Code
                                Case "SEUNITMATERIAL" : z3011.seUnitMaterial = Children(i).Code
                                Case "CDUNITMATERIAL" : z3011.cdUnitMaterial = Children(i).Code
                                Case "INCHARGEREQUEST" : z3011.InchargeRequest = Children(i).Code
                                Case "PRNO" : z3011.PRNo = Children(i).Code
                                Case "PRNOSEQ" : z3011.PRNoSeq = Children(i).Code
                                Case "CUSTOMERCODE" : z3011.CustomerCode = Children(i).Code
                                Case "PRNAME" : z3011.PRName = Children(i).Code
                                Case "PURCHASINGORDERNO" : z3011.PurchasingOrderNo = Children(i).Code
                                Case "PURCHASINGORDERSEQ" : z3011.PurchasingOrderSeq = Children(i).Code
                                Case "CHECKORDERMATERIAL" : z3011.CheckOrderMaterial = Children(i).Code
                                Case "CHECKADJUST" : z3011.CheckAdjust = Children(i).Code
                                Case "CHECKGZ" : z3011.CheckGZ = Children(i).Code
                                Case "DATEADJUST" : z3011.DateAdjust = Children(i).Code
                                Case "DATEDELIVERY" : z3011.DateDelivery = Children(i).Code
                                Case "DATEORDERMATERIALACCEPT" : z3011.DateOrderMaterialAccept = Children(i).Code
                                Case "DATEORDERMATERIALCOMPLETE" : z3011.DateOrderMaterialComplete = Children(i).Code
                                Case "DATEORDERMATERIALAPPROVAL" : z3011.DateOrderMaterialApproval = Children(i).Code
                                Case "DATEORDERMATERIALCANCEL" : z3011.DateOrderMaterialCancel = Children(i).Code
                                Case "TIMEINSERT" : z3011.TimeInsert = Children(i).Code
                                Case "TIMEUPDATE" : z3011.TimeUpdate = Children(i).Code
                                Case "DATEUPDATE" : z3011.DateUpdate = Children(i).Code
                                Case "DATEINSERT" : z3011.DateInsert = Children(i).Code
                                Case "DATEUDATE" : z3011.DateUdate = Children(i).Code
                                Case "INCHARGEINSERT" : z3011.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z3011.InchargeUpdate = Children(i).Code
                                Case "DATEEXCEL" : z3011.DateExcel = Children(i).Code
                                Case "PRICEAPURCHASING" : z3011.PriceAPurchasing = Children(i).Code
                                Case "CDUNITMATERIALA" : z3011.cdUnitMaterialA = Children(i).Code
                                Case "CDUNITPRICEA" : z3011.cdUnitPriceA = Children(i).Code
                                Case "QTYAPURCHASING" : z3011.QtyAPurchasing = Children(i).Code
                                Case "QTYATOTAL" : z3011.QtyATotal = Children(i).Code
                                Case "AMTAPURCHASING" : z3011.AmtAPurchasing = Children(i).Code
                                Case "AMTATOTAL" : z3011.AmtATotal = Children(i).Code
                                Case "DATEARRIVE1" : z3011.DateArrive1 = Children(i).Code
                                Case "DATEARRIVE2" : z3011.DateArrive2 = Children(i).Code
                                Case "DATEARRIVE3" : z3011.DateArrive3 = Children(i).Code
                                Case "DATEARRIVE4" : z3011.DateArrive4 = Children(i).Code
                                Case "DATEARRIVE5" : z3011.DateArrive5 = Children(i).Code
                                Case "QTYAARRIVE1" : z3011.QtyAArrive1 = Children(i).Code
                                Case "QTYAARRIVE2" : z3011.QtyAArrive2 = Children(i).Code
                                Case "QTYAARRIVE3" : z3011.QtyAArrive3 = Children(i).Code
                                Case "QTYAARRIVE4" : z3011.QtyAArrive4 = Children(i).Code
                                Case "QTYAARRIVE5" : z3011.QtyAArrive5 = Children(i).Code
                                Case "INCHARGEINVOICE" : z3011.InchargeInvoice = Children(i).Code
                                Case "APLNAME" : z3011.APLName = Children(i).Code
                                Case "AINVOICE" : z3011.AInvoice = Children(i).Code
                                Case "AREMARK" : z3011.ARemark = Children(i).Code
                                Case "REMARK" : z3011.Remark = Children(i).Code
                                Case "REMARKLINE" : z3011.RemarkLine = Children(i).Code
                                Case "RemarkMOQ" : z3011.RemarkMOQ = Children(i).Code
                                Case "QANote1" : z3011.QANote1 = Children(i).Code
                                Case "QANote2" : z3011.QANote2 = Children(i).Code
                                Case "QANote3" : z3011.QANote3 = Children(i).Code
                                Case "QANote" : z3011.QANote = Children(i).Code
                                Case "SESITE" : z3011.seSite = Children(i).Code
                                Case "CDSITE" : z3011.cdSite = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z3011.Autokey = Cdecp(Children(i).Data)
                                Case "KINDREVISE" : z3011.KindRevise = Cdecp(Children(i).Data)
                                Case "SESEASON" : z3011.seSeason = Children(i).Data
                                Case "CDSEASON" : z3011.cdSeason = Children(i).Data
                                Case "ORDERNO" : z3011.OrderNo = Children(i).Data
                                Case "ORDERNOSEQ" : z3011.OrderNoSeq = Children(i).Data
                                Case "MATERIALCODEBASE" : z3011.MaterialCodeBase = Children(i).Data
                                Case "MATERIALCODE" : z3011.Materialcode = Children(i).Data
                                Case "DESCRIPTION" : z3011.Description = Children(i).Data
                                Case "COLOR" : z3011.Color = Children(i).Data
                                Case "COLORCODE" : z3011.ColorCode = Children(i).Data
                                Case "SIZENO" : z3011.SizeNo = Children(i).Data
                                Case "SPECIFICATION" : z3011.Specification = Children(i).Data
                                Case "WIDTH" : z3011.Width = Children(i).Data
                                Case "HEIGHT" : z3011.Height = Children(i).Data
                                Case "SIZENAME" : z3011.SizeName = Children(i).Data
                                Case "COLORNAME" : z3011.ColorName = Children(i).Data
                                Case "MATERIALCHECK" : z3011.MaterialCheck = Children(i).Data
                                Case "SESHOESSTATUS" : z3011.seShoesStatus = Children(i).Data
                                Case "CDSHOESSTATUS" : z3011.cdShoesStatus = Children(i).Data
                                Case "SEDEPARTMENT" : z3011.seDepartment = Children(i).Data
                                Case "CDDEPARTMENT" : z3011.cdDepartment = Children(i).Data
                                Case "SUPPLIERCODE" : z3011.SupplierCode = Children(i).Data
                                Case "MATERIALPRICE" : z3011.MaterialPrice = Cdecp(Children(i).Data)
                                Case "SEUNITPRICE" : z3011.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z3011.cdUnitPrice = Children(i).Data
                                Case "QTYSALES" : z3011.QtySales = Cdecp(Children(i).Data)
                                Case "QTYSALESSAMPLE" : z3011.QtySalesSample = Cdecp(Children(i).Data)
                                Case "GROSSUSAGE" : z3011.GrossUsage = Cdecp(Children(i).Data)
                                Case "TOTALQTY" : z3011.TotalQty = Cdecp(Children(i).Data)
                                Case "QTYORDER" : z3011.QtyOrder = Cdecp(Children(i).Data)
                                Case "QTYADJUST" : z3011.QtyAdjust = Cdecp(Children(i).Data)
                                Case "QTYBOOKING" : z3011.QtyBooking = CDecp(Children(i).Data)
                                Case "QtyBooking1" : z3011.QtyBooking1 = CDecp(Children(i).Data)
                                Case "QtyBooking2" : z3011.QtyBooking2 = CDecp(Children(i).Data)
                                Case "QTYREQUEST" : z3011.QtyRequest = Cdecp(Children(i).Data)
                                Case "QTYPURCHASING" : z3011.QtyPurchasing = Cdecp(Children(i).Data)
                                Case "QTYSIZEBYSIZE" : z3011.QtySizebySize = Cdecp(Children(i).Data)
                                Case "SEUNITMATERIAL" : z3011.seUnitMaterial = Children(i).Data
                                Case "CDUNITMATERIAL" : z3011.cdUnitMaterial = Children(i).Data
                                Case "INCHARGEREQUEST" : z3011.InchargeRequest = Children(i).Data
                                Case "PRNO" : z3011.PRNo = Children(i).Data
                                Case "PRNOSEQ" : z3011.PRNoSeq = Children(i).Data
                                Case "CUSTOMERCODE" : z3011.CustomerCode = Children(i).Data
                                Case "PRNAME" : z3011.PRName = Children(i).Data
                                Case "PURCHASINGORDERNO" : z3011.PurchasingOrderNo = Children(i).Data
                                Case "PURCHASINGORDERSEQ" : z3011.PurchasingOrderSeq = Cdecp(Children(i).Data)
                                Case "CHECKORDERMATERIAL" : z3011.CheckOrderMaterial = Children(i).Data
                                Case "CHECKADJUST" : z3011.CheckAdjust = Children(i).Data
                                Case "CHECKGZ" : z3011.CheckGZ = Children(i).Data
                                Case "DATEADJUST" : z3011.DateAdjust = Children(i).Data
                                Case "DATEDELIVERY" : z3011.DateDelivery = Children(i).Data
                                Case "DATEORDERMATERIALACCEPT" : z3011.DateOrderMaterialAccept = Children(i).Data
                                Case "DATEORDERMATERIALCOMPLETE" : z3011.DateOrderMaterialComplete = Children(i).Data
                                Case "DATEORDERMATERIALAPPROVAL" : z3011.DateOrderMaterialApproval = Children(i).Data
                                Case "DATEORDERMATERIALCANCEL" : z3011.DateOrderMaterialCancel = Children(i).Data
                                Case "TIMEINSERT" : z3011.TimeInsert = Children(i).Data
                                Case "TIMEUPDATE" : z3011.TimeUpdate = Children(i).Data
                                Case "DATEUPDATE" : z3011.DateUpdate = Children(i).Data
                                Case "DATEINSERT" : z3011.DateInsert = Children(i).Data
                                Case "DATEUDATE" : z3011.DateUdate = Children(i).Data
                                Case "INCHARGEINSERT" : z3011.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z3011.InchargeUpdate = Children(i).Data
                                Case "DATEEXCEL" : z3011.DateExcel = Children(i).Data
                                Case "PRICEAPURCHASING" : z3011.PriceAPurchasing = Cdecp(Children(i).Data)
                                Case "CDUNITMATERIALA" : z3011.cdUnitMaterialA = Children(i).Data
                                Case "CDUNITPRICEA" : z3011.cdUnitPriceA = Children(i).Data
                                Case "QTYAPURCHASING" : z3011.QtyAPurchasing = Cdecp(Children(i).Data)
                                Case "QTYATOTAL" : z3011.QtyATotal = Cdecp(Children(i).Data)
                                Case "AMTAPURCHASING" : z3011.AmtAPurchasing = Cdecp(Children(i).Data)
                                Case "AMTATOTAL" : z3011.AmtATotal = Cdecp(Children(i).Data)
                                Case "DATEARRIVE1" : z3011.DateArrive1 = Children(i).Data
                                Case "DATEARRIVE2" : z3011.DateArrive2 = Children(i).Data
                                Case "DATEARRIVE3" : z3011.DateArrive3 = Children(i).Data
                                Case "DATEARRIVE4" : z3011.DateArrive4 = Children(i).Data
                                Case "DATEARRIVE5" : z3011.DateArrive5 = Children(i).Data
                                Case "QTYAARRIVE1" : z3011.QtyAArrive1 = Cdecp(Children(i).Data)
                                Case "QTYAARRIVE2" : z3011.QtyAArrive2 = Cdecp(Children(i).Data)
                                Case "QTYAARRIVE3" : z3011.QtyAArrive3 = Cdecp(Children(i).Data)
                                Case "QTYAARRIVE4" : z3011.QtyAArrive4 = Cdecp(Children(i).Data)
                                Case "QTYAARRIVE5" : z3011.QtyAArrive5 = Cdecp(Children(i).Data)
                                Case "INCHARGEINVOICE" : z3011.InchargeInvoice = Children(i).Data
                                Case "APLNAME" : z3011.APLName = Children(i).Data
                                Case "AINVOICE" : z3011.AInvoice = Children(i).Data
                                Case "AREMARK" : z3011.ARemark = Children(i).Data
                                Case "REMARK" : z3011.Remark = Children(i).Data
                                Case "REMARKLINE" : z3011.RemarkLine = Children(i).Data
                                Case "RemarkMOQ" : z3011.RemarkMOQ = Children(i).Data
                                Case "QANote1" : z3011.QANote1 = Children(i).Data
                                Case "QANote2" : z3011.QANote2 = Children(i).Data
                                Case "QANote3" : z3011.QANote3 = Children(i).Data
                                Case "QANote" : z3011.QANote = Children(i).Data
                                Case "SESITE" : z3011.seSite = Children(i).Data
                                Case "CDSITE" : z3011.cdSite = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3011_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW AREA
    '=========================================================================================================================================================
    Public Sub K3011_MOVE(ByRef a3011 As T3011_AREA, ByRef b3011 As T3011_AREA)
        Try
            If trim$(a3011.Autokey) = "" Then b3011.Autokey = "" Else b3011.Autokey = a3011.Autokey
            If trim$(a3011.KindRevise) = "" Then b3011.KindRevise = "" Else b3011.KindRevise = a3011.KindRevise
            If trim$(a3011.seSeason) = "" Then b3011.seSeason = "" Else b3011.seSeason = a3011.seSeason
            If trim$(a3011.cdSeason) = "" Then b3011.cdSeason = "" Else b3011.cdSeason = a3011.cdSeason
            If trim$(a3011.OrderNo) = "" Then b3011.OrderNo = "" Else b3011.OrderNo = a3011.OrderNo
            If trim$(a3011.OrderNoSeq) = "" Then b3011.OrderNoSeq = "" Else b3011.OrderNoSeq = a3011.OrderNoSeq
            If trim$(a3011.MaterialCodeBase) = "" Then b3011.MaterialCodeBase = "" Else b3011.MaterialCodeBase = a3011.MaterialCodeBase
            If trim$(a3011.Materialcode) = "" Then b3011.Materialcode = "" Else b3011.Materialcode = a3011.Materialcode
            If trim$(a3011.Description) = "" Then b3011.Description = "" Else b3011.Description = a3011.Description
            If trim$(a3011.Color) = "" Then b3011.Color = "" Else b3011.Color = a3011.Color
            If trim$(a3011.ColorCode) = "" Then b3011.ColorCode = "" Else b3011.ColorCode = a3011.ColorCode
            If trim$(a3011.SizeNo) = "" Then b3011.SizeNo = "" Else b3011.SizeNo = a3011.SizeNo
            If trim$(a3011.Specification) = "" Then b3011.Specification = "" Else b3011.Specification = a3011.Specification
            If trim$(a3011.Width) = "" Then b3011.Width = "" Else b3011.Width = a3011.Width
            If trim$(a3011.Height) = "" Then b3011.Height = "" Else b3011.Height = a3011.Height
            If trim$(a3011.SizeName) = "" Then b3011.SizeName = "" Else b3011.SizeName = a3011.SizeName
            If trim$(a3011.ColorName) = "" Then b3011.ColorName = "" Else b3011.ColorName = a3011.ColorName
            If trim$(a3011.MaterialCheck) = "" Then b3011.MaterialCheck = "" Else b3011.MaterialCheck = a3011.MaterialCheck
            If trim$(a3011.seShoesStatus) = "" Then b3011.seShoesStatus = "" Else b3011.seShoesStatus = a3011.seShoesStatus
            If trim$(a3011.cdShoesStatus) = "" Then b3011.cdShoesStatus = "" Else b3011.cdShoesStatus = a3011.cdShoesStatus
            If trim$(a3011.seDepartment) = "" Then b3011.seDepartment = "" Else b3011.seDepartment = a3011.seDepartment
            If trim$(a3011.cdDepartment) = "" Then b3011.cdDepartment = "" Else b3011.cdDepartment = a3011.cdDepartment
            If trim$(a3011.SupplierCode) = "" Then b3011.SupplierCode = "" Else b3011.SupplierCode = a3011.SupplierCode
            If trim$(a3011.MaterialPrice) = "" Then b3011.MaterialPrice = "" Else b3011.MaterialPrice = a3011.MaterialPrice
            If trim$(a3011.seUnitPrice) = "" Then b3011.seUnitPrice = "" Else b3011.seUnitPrice = a3011.seUnitPrice
            If trim$(a3011.cdUnitPrice) = "" Then b3011.cdUnitPrice = "" Else b3011.cdUnitPrice = a3011.cdUnitPrice
            If trim$(a3011.QtySales) = "" Then b3011.QtySales = "" Else b3011.QtySales = a3011.QtySales
            If trim$(a3011.QtySalesSample) = "" Then b3011.QtySalesSample = "" Else b3011.QtySalesSample = a3011.QtySalesSample
            If trim$(a3011.GrossUsage) = "" Then b3011.GrossUsage = "" Else b3011.GrossUsage = a3011.GrossUsage
            If trim$(a3011.TotalQty) = "" Then b3011.TotalQty = "" Else b3011.TotalQty = a3011.TotalQty
            If trim$(a3011.QtyOrder) = "" Then b3011.QtyOrder = "" Else b3011.QtyOrder = a3011.QtyOrder
            If trim$(a3011.QtyAdjust) = "" Then b3011.QtyAdjust = "" Else b3011.QtyAdjust = a3011.QtyAdjust
            If Trim$(a3011.QtyBooking) = "" Then b3011.QtyBooking = "" Else b3011.QtyBooking = a3011.QtyBooking
            If Trim$(a3011.QtyBooking1) = "" Then b3011.QtyBooking1 = "" Else b3011.QtyBooking1 = a3011.QtyBooking1
            If Trim$(a3011.QtyBooking2) = "" Then b3011.QtyBooking2 = "" Else b3011.QtyBooking2 = a3011.QtyBooking2
            If trim$(a3011.QtyRequest) = "" Then b3011.QtyRequest = "" Else b3011.QtyRequest = a3011.QtyRequest
            If trim$(a3011.QtyPurchasing) = "" Then b3011.QtyPurchasing = "" Else b3011.QtyPurchasing = a3011.QtyPurchasing
            If trim$(a3011.QtySizebySize) = "" Then b3011.QtySizebySize = "" Else b3011.QtySizebySize = a3011.QtySizebySize
            If trim$(a3011.seUnitMaterial) = "" Then b3011.seUnitMaterial = "" Else b3011.seUnitMaterial = a3011.seUnitMaterial
            If trim$(a3011.cdUnitMaterial) = "" Then b3011.cdUnitMaterial = "" Else b3011.cdUnitMaterial = a3011.cdUnitMaterial
            If trim$(a3011.InchargeRequest) = "" Then b3011.InchargeRequest = "" Else b3011.InchargeRequest = a3011.InchargeRequest
            If trim$(a3011.PRNo) = "" Then b3011.PRNo = "" Else b3011.PRNo = a3011.PRNo
            If trim$(a3011.PRNoSeq) = "" Then b3011.PRNoSeq = "" Else b3011.PRNoSeq = a3011.PRNoSeq
            If trim$(a3011.CustomerCode) = "" Then b3011.CustomerCode = "" Else b3011.CustomerCode = a3011.CustomerCode
            If trim$(a3011.PRName) = "" Then b3011.PRName = "" Else b3011.PRName = a3011.PRName
            If trim$(a3011.PurchasingOrderNo) = "" Then b3011.PurchasingOrderNo = "" Else b3011.PurchasingOrderNo = a3011.PurchasingOrderNo
            If trim$(a3011.PurchasingOrderSeq) = "" Then b3011.PurchasingOrderSeq = "" Else b3011.PurchasingOrderSeq = a3011.PurchasingOrderSeq
            If trim$(a3011.CheckOrderMaterial) = "" Then b3011.CheckOrderMaterial = "" Else b3011.CheckOrderMaterial = a3011.CheckOrderMaterial
            If trim$(a3011.CheckAdjust) = "" Then b3011.CheckAdjust = "" Else b3011.CheckAdjust = a3011.CheckAdjust
            If trim$(a3011.CheckGZ) = "" Then b3011.CheckGZ = "" Else b3011.CheckGZ = a3011.CheckGZ
            If trim$(a3011.DateAdjust) = "" Then b3011.DateAdjust = "" Else b3011.DateAdjust = a3011.DateAdjust
            If trim$(a3011.DateDelivery) = "" Then b3011.DateDelivery = "" Else b3011.DateDelivery = a3011.DateDelivery
            If trim$(a3011.DateOrderMaterialAccept) = "" Then b3011.DateOrderMaterialAccept = "" Else b3011.DateOrderMaterialAccept = a3011.DateOrderMaterialAccept
            If trim$(a3011.DateOrderMaterialComplete) = "" Then b3011.DateOrderMaterialComplete = "" Else b3011.DateOrderMaterialComplete = a3011.DateOrderMaterialComplete
            If trim$(a3011.DateOrderMaterialApproval) = "" Then b3011.DateOrderMaterialApproval = "" Else b3011.DateOrderMaterialApproval = a3011.DateOrderMaterialApproval
            If trim$(a3011.DateOrderMaterialCancel) = "" Then b3011.DateOrderMaterialCancel = "" Else b3011.DateOrderMaterialCancel = a3011.DateOrderMaterialCancel
            If trim$(a3011.TimeInsert) = "" Then b3011.TimeInsert = "" Else b3011.TimeInsert = a3011.TimeInsert
            If trim$(a3011.TimeUpdate) = "" Then b3011.TimeUpdate = "" Else b3011.TimeUpdate = a3011.TimeUpdate
            If trim$(a3011.DateUpdate) = "" Then b3011.DateUpdate = "" Else b3011.DateUpdate = a3011.DateUpdate
            If trim$(a3011.DateInsert) = "" Then b3011.DateInsert = "" Else b3011.DateInsert = a3011.DateInsert
            If trim$(a3011.DateUdate) = "" Then b3011.DateUdate = "" Else b3011.DateUdate = a3011.DateUdate
            If trim$(a3011.InchargeInsert) = "" Then b3011.InchargeInsert = "" Else b3011.InchargeInsert = a3011.InchargeInsert
            If trim$(a3011.InchargeUpdate) = "" Then b3011.InchargeUpdate = "" Else b3011.InchargeUpdate = a3011.InchargeUpdate
            If trim$(a3011.DateExcel) = "" Then b3011.DateExcel = "" Else b3011.DateExcel = a3011.DateExcel
            If trim$(a3011.PriceAPurchasing) = "" Then b3011.PriceAPurchasing = "" Else b3011.PriceAPurchasing = a3011.PriceAPurchasing
            If trim$(a3011.cdUnitMaterialA) = "" Then b3011.cdUnitMaterialA = "" Else b3011.cdUnitMaterialA = a3011.cdUnitMaterialA
            If trim$(a3011.cdUnitPriceA) = "" Then b3011.cdUnitPriceA = "" Else b3011.cdUnitPriceA = a3011.cdUnitPriceA
            If trim$(a3011.QtyAPurchasing) = "" Then b3011.QtyAPurchasing = "" Else b3011.QtyAPurchasing = a3011.QtyAPurchasing
            If trim$(a3011.QtyATotal) = "" Then b3011.QtyATotal = "" Else b3011.QtyATotal = a3011.QtyATotal
            If trim$(a3011.AmtAPurchasing) = "" Then b3011.AmtAPurchasing = "" Else b3011.AmtAPurchasing = a3011.AmtAPurchasing
            If trim$(a3011.AmtATotal) = "" Then b3011.AmtATotal = "" Else b3011.AmtATotal = a3011.AmtATotal
            If trim$(a3011.DateArrive1) = "" Then b3011.DateArrive1 = "" Else b3011.DateArrive1 = a3011.DateArrive1
            If trim$(a3011.DateArrive2) = "" Then b3011.DateArrive2 = "" Else b3011.DateArrive2 = a3011.DateArrive2
            If trim$(a3011.DateArrive3) = "" Then b3011.DateArrive3 = "" Else b3011.DateArrive3 = a3011.DateArrive3
            If trim$(a3011.DateArrive4) = "" Then b3011.DateArrive4 = "" Else b3011.DateArrive4 = a3011.DateArrive4
            If trim$(a3011.DateArrive5) = "" Then b3011.DateArrive5 = "" Else b3011.DateArrive5 = a3011.DateArrive5
            If trim$(a3011.QtyAArrive1) = "" Then b3011.QtyAArrive1 = "" Else b3011.QtyAArrive1 = a3011.QtyAArrive1
            If trim$(a3011.QtyAArrive2) = "" Then b3011.QtyAArrive2 = "" Else b3011.QtyAArrive2 = a3011.QtyAArrive2
            If trim$(a3011.QtyAArrive3) = "" Then b3011.QtyAArrive3 = "" Else b3011.QtyAArrive3 = a3011.QtyAArrive3
            If trim$(a3011.QtyAArrive4) = "" Then b3011.QtyAArrive4 = "" Else b3011.QtyAArrive4 = a3011.QtyAArrive4
            If trim$(a3011.QtyAArrive5) = "" Then b3011.QtyAArrive5 = "" Else b3011.QtyAArrive5 = a3011.QtyAArrive5
            If trim$(a3011.InchargeInvoice) = "" Then b3011.InchargeInvoice = "" Else b3011.InchargeInvoice = a3011.InchargeInvoice
            If trim$(a3011.APLName) = "" Then b3011.APLName = "" Else b3011.APLName = a3011.APLName
            If trim$(a3011.AInvoice) = "" Then b3011.AInvoice = "" Else b3011.AInvoice = a3011.AInvoice
            If trim$(a3011.ARemark) = "" Then b3011.ARemark = "" Else b3011.ARemark = a3011.ARemark
            If trim$(a3011.Remark) = "" Then b3011.Remark = "" Else b3011.Remark = a3011.Remark
            If Trim$(a3011.RemarkLine) = "" Then b3011.RemarkLine = "" Else b3011.RemarkLine = a3011.RemarkLine
            If Trim$(a3011.RemarkMOQ) = "" Then b3011.RemarkMOQ = "" Else b3011.RemarkMOQ = a3011.RemarkMOQ
            If Trim$(a3011.QANote1) = "" Then b3011.QANote1 = "" Else b3011.QANote1 = a3011.QANote1
            If Trim$(a3011.QANote2) = "" Then b3011.QANote2 = "" Else b3011.QANote2 = a3011.QANote2
            If Trim$(a3011.QANote3) = "" Then b3011.QANote3 = "" Else b3011.QANote3 = a3011.QANote3
            If Trim$(a3011.QANote) = "" Then b3011.QANote = "" Else b3011.QANote = a3011.QANote
            If trim$(a3011.seSite) = "" Then b3011.seSite = "" Else b3011.seSite = a3011.seSite
            If trim$(a3011.cdSite) = "" Then b3011.cdSite = "" Else b3011.cdSite = a3011.cdSite
        Catch ex As Exception
            Call MsgBoxP("K3011_MOVE", vbCritical)
        End Try
    End Sub


End Module
