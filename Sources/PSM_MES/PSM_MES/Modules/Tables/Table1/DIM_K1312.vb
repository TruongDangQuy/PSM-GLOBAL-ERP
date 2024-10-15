'=========================================================================================================================================================
'   TABLE : (PFK1312)
'
'      	Company    		: PSM GLOBAL ., LTD
'      	Date Create 	: 17-05-2024
'      	Worker    		: MrJun
' 		Phone 			: 0363773856
' 		Email			: Trongtran@psmvn
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K1312

    Structure T1312_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public OrderNo As String  '			char(9)		*
        Public OrderNoSeq As String  '			char(3)		*
        Public PRName As String  '			nvarchar(50)		
        Public TimeReviseApt As String  '			nvarchar(14)		
        Public TimeRevisePrt As String  '			nvarchar(14)		
        Public TimeRevise As String  '			nvarchar(14)		
        Public TimeRnDRevise As String  '			nvarchar(14)		
        Public TimeSalesRevise As String  '			nvarchar(14)		
        Public InchargeRevise As String  '			char(8)		
        Public ReviseNo As Double  '			decimal(3, 0)		
        Public ShoesCode As String  '			char(6)		
        Public ShoesCodeFin As String  '			char(6)		
        Public FacPO As String  '			nvarchar(50)		
        Public SLNoSys As String  '			nvarchar(200)		
        Public SLNo As String  '			nvarchar(20)		
        Public PONO As String  '			nvarchar(50)		
        Public CPONO As String  '			nvarchar(50)		
        Public CustomerCode As String  '			char(6)		
        Public CustomerName As String  '			nvarchar(50)		
        Public Country As String  '			nvarchar(50)		
        Public Destination As String  '			nvarchar(200)		
        Public FinalShop As String  '			nvarchar(50)		
        Public PKO As String  '			nvarchar(50)		
        Public DatePO As String  '			char(8)		
        Public JbCard As String  '			nvarchar(50)		
        Public sePackingCode As String  '			char(3)		
        Public cdPackingCode As String  '			char(3)		
        Public seSpecStatus As String  '			char(3)		
        Public cdSpecStatus As String  '			char(3)		
        Public SizeRange As String  '			char(6)		
        Public SpeciticSize As String  '			nvarchar(4)		
        Public DateSize As String  '			char(8)		
        Public OrderDetailStatus As String  '			char(1)		
        Public DateOrder As String  '			char(8)		
        Public DateApproval As String  '			char(8)		
        Public DateCL As String  '			char(8)		
        Public DateCancel As String  '			char(8)		
        Public RemarkCancel As String  '			nvarchar(500)		
        Public DateComplete As String  '			char(8)		
        Public DatePending As String  '			char(8)		
        Public DatePending2 As String  '			char(8)		
        Public DateExchangePrice As String  '			char(8)		
        Public SizeW As Double  '			decimal(8, 2)		
        Public SizeL As Double  '			decimal(8, 2)		
        Public SizeH As Double  '			decimal(8, 2)		
        Public QtyNo1 As Double  '			decimal(18, 6)		
        Public QtyNo2 As Double  '			decimal(18, 6)		
        Public QtyNo3 As Double  '			decimal(18, 6)		
        Public QtyGW As Double  '			decimal(18, 6)		
        Public QtyNW As Double  '			decimal(18, 6)		
        Public QtyPcsPoly As Double  '			decimal(18, 0)		
        Public QtyPolyCTN As Double  '			decimal(18, 0)		
        Public QtyPcsCTN As Double  '			decimal(18, 0)		
        Public QtyPcsPINO As Double  '			decimal(18, 0)		
        Public PriceExchange As Double  '			decimal(18, 6)		
        Public CheckFOB As String  '			char(1)		
        Public PriceOrderFOB As Double  '			decimal(18, 6)		
        Public TotalAMTFOB As Double  '			decimal(18, 6)		
        Public PriceOrder As Double  '			decimal(18, 6)		
        Public PriceOrder1 As Double  '			decimal(18, 6)		
        Public PriceOrder2 As Double  '			decimal(18, 6)		
        Public PriceOrder3 As Double  '			decimal(18, 6)		
        Public seUnitPrice As String  '			char(3)		
        Public cdUnitPrice As String  '			char(3)		
        Public UnitPrice As String  '			char(3)		
        Public PriceOrderEX As Double  '			decimal(18, 6)		
        Public PriceOrderVND As Double  '			decimal(18, 6)		
        Public Datedelivery As String  '			char(8)		
        Public DateTransfer As String  '			char(8)		
        Public AcceptedOrder As String  '			char(1)		
        Public MaterialStatus As String  '			char(1)		
        Public SoleStatus As String  '			char(1)		
        Public DateLable As String  '			nvarchar(50)		
        Public DatePattern As String  '			char(8)		
        Public DateMaterial As String  '			char(8)		
        Public DatePlanning As String  '			char(8)		
        Public DateRnD As String  '			char(8)		
        Public DateFitting As String  '			char(8)		
        Public InchargeFitting As String  '			char(8)		
        Public CheckFitting As String  '			char(1)		
        Public DateTesting As String  '			char(8)		
        Public InchargeTesting As String  '			char(8)		
        Public CheckTesting As String  '			char(1)		
        Public CheckConfirm As String  '			char(1)		
        Public DateConfirm As String  '			char(8)		
        Public InchargeRD1 As String  '			char(8)		
        Public InchargeRD2 As String  '			char(8)		
        Public InchargeRD3 As String  '			char(8)		
        Public InchargeRD4 As String  '			char(8)		
        Public DateSRD1 As String  '			char(8)		
        Public DateERD1 As String  '			char(8)		
        Public DateSRD2 As String  '			char(8)		
        Public DateERD2 As String  '			char(8)		
        Public DateSRD3 As String  '			char(8)		
        Public DateERD3 As String  '			char(8)		
        Public DateSRD4 As String  '			char(8)		
        Public DateERD4 As String  '			char(8)		
        Public SpecNo As String  '			char(9)		
        Public SpecNoSeq As String  '			char(3)		
        Public DateSole As String  '			char(8)		
        Public DateCutting As String  '			char(8)		
        Public DateStitching As String  '			char(8)		
        Public DateStockfit As String  '			char(8)		
        Public DateAssmbly As String  '			char(8)		
        Public DateShipping As String  '			char(8)		
        Public seUnitMaterial As String  '			char(3)		
        Public cdUnitMaterial As String  '			char(3)		
        Public seUnitPacking As String  '			char(3)		
        Public cdUnitPacking As String  '			char(3)		
        Public QtyOrderSample As Double  '			decimal(10, 2)		
        Public QtyOrderSample01 As Double  '			decimal(10, 2)		
        Public QtyOrderSample02 As Double  '			decimal(10, 2)		
        Public QtyOrder As Double  '			decimal(10, 2)		
        Public QtyJob As Double  '			decimal(10, 2)		
        Public QtySole As Double  '			decimal(10, 2)		
        Public QtyCutting As Double  '			decimal(10, 2)		
        Public QtyStitching As Double  '			decimal(10, 2)		
        Public QtyStockfit As Double  '			decimal(10, 2)		
        Public QtyAssembly As Double  '			decimal(10, 2)		
        Public QtyPacking As Double  '			decimal(10, 2)		
        Public QtyInbound As Double  '			decimal(10, 2)		
        Public QtyShipping As Double  '			decimal(10, 2)		
        Public TimeInsert As String  '			char(14)		
        Public TimeUpdate As String  '			char(14)		
        Public DateInsert As String  '			char(8)		
        Public InchargeInsert As String  '			char(8)		
        Public DateUpdate As String  '			char(8)		
        Public InchargeUpdate As String  '			char(8)		
        Public InchargeSales As String  '			char(8)		
        Public InchargePPC As String  '			char(8)		
        Public TotalQty As Double  '			decimal(6, 2)		
        Public TotalAMT As Double  '			decimal(18, 2)		
        Public TotalCost As Double  '			decimal(18, 2)		
        Public TotalProfit As Double  '			decimal(18, 2)		
        Public TotalAMTEX As Double  '			decimal(18, 2)		
        Public TotalAMTVND As Double  '			decimal(18, 2)		
        Public TotalCostEX As Double  '			decimal(18, 2)		
        Public TotalCostVND As Double  '			decimal(18, 2)		
        Public TotalProfitEX As Double  '			decimal(18, 2)		
        Public TotalProfitVND As Double  '			decimal(18, 2)		
        Public AttachID As String  '			char(6)		
        Public DateSync As String  '			char(8)		
        Public CheckSync As String  '			char(1)		
        Public PINo As String  '			nvarchar(50)		
        Public CheckSizeGroup As String  '			char(1)		
        Public OrderNoRef As String  '			char(9)		
        Public OrderNoSeqRef As String  '			char(3)		
        Public Remark As String  '			nvarchar(200)		
        Public RemarkOrder As String  '			nvarchar(50)		
        Public RemarkCustomer As String  '			nvarchar(50)		
        Public RemarkOther As String  '			nvarchar(500)		
        Public RemarkTrading As String  '			nvarchar(200)		
        Public seSite As String  '			char(3)		
        Public cdSite As String  '			char(3)		
        Public LicenseName As String  '			nvarchar(100)		
        Public TestStandard As String  '			nvarchar(100)		
        Public TestNo As String  '			nvarchar(500)		
        Public DateReport As String  '			nvarchar(100)		
        Public InvoiceStatus As String  '			char(1)		
        Public WIPStatus As String  '			char(1)		
        Public WIPDate As String  '			char(8)		
        Public WIPNo As String  '			nvarchar(10)		
        Public ExportCode As String  '			nvarchar(50)		
        Public ExportName As String  '			nvarchar(200)		

        '=========================================================================================================================================================
    End Structure

    Public D1312 As T1312_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK1312(OrderNo As String, OrderNoSeq As String) As Boolean
        READ_PFK1312 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK1312 WITH(NOLOCK) "
            SQL = SQL & " WHERE K1312_OrderNo		 = '" & OrderNo & "' "
            SQL = SQL & " AND K1312_OrderNoSeq		 = '" & OrderNoSeq & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D1312_CLEAR() : GoTo SKIP_READ_PFK1312

            Call K1312_MOVE(rd)
            READ_PFK1312 = True

SKIP_READ_PFK1312:
            rd.Close()
            Exit Function
        Catch ex As Exception
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK1312(OrderNo As String, OrderNoSeq As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK1312 WITH(NOLOCK) "
            SQL = SQL & " WHERE K1312_OrderNo		 = '" & OrderNo & "' "
            SQL = SQL & " AND K1312_OrderNoSeq		 = '" & OrderNoSeq & "' "

            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception 
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK1312(z1312 As T1312_AREA) As Boolean
        WRITE_PFK1312 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z1312)

            SQL = " INSERT INTO PFK1312 "
            SQL = SQL & " ( "
            SQL = SQL & " K1312_OrderNo"
            SQL = SQL & ", K1312_OrderNoSeq"
            SQL = SQL & ", K1312_PRName"
            SQL = SQL & ", K1312_TimeReviseApt"
            SQL = SQL & ", K1312_TimeRevisePrt"
            SQL = SQL & ", K1312_TimeRevise"
            SQL = SQL & ", K1312_TimeRnDRevise"
            SQL = SQL & ", K1312_TimeSalesRevise"
            SQL = SQL & ", K1312_InchargeRevise"
            SQL = SQL & ", K1312_ReviseNo"
            SQL = SQL & ", K1312_ShoesCode"
            SQL = SQL & ", K1312_ShoesCodeFin"
            SQL = SQL & ", K1312_FacPO"
            SQL = SQL & ", K1312_SLNoSys"
            SQL = SQL & ", K1312_SLNo"
            SQL = SQL & ", K1312_PONO"
            SQL = SQL & ", K1312_CPONO"
            SQL = SQL & ", K1312_CustomerCode"
            SQL = SQL & ", K1312_CustomerName"
            SQL = SQL & ", K1312_Country"
            SQL = SQL & ", K1312_Destination"
            SQL = SQL & ", K1312_FinalShop"
            SQL = SQL & ", K1312_PKO"
            SQL = SQL & ", K1312_DatePO"
            SQL = SQL & ", K1312_JbCard"
            SQL = SQL & ", K1312_sePackingCode"
            SQL = SQL & ", K1312_cdPackingCode"
            SQL = SQL & ", K1312_seSpecStatus"
            SQL = SQL & ", K1312_cdSpecStatus"
            SQL = SQL & ", K1312_SizeRange"
            SQL = SQL & ", K1312_SpeciticSize"
            SQL = SQL & ", K1312_DateSize"
            SQL = SQL & ", K1312_OrderDetailStatus"
            SQL = SQL & ", K1312_DateOrder"
            SQL = SQL & ", K1312_DateApproval"
            SQL = SQL & ", K1312_DateCL"
            SQL = SQL & ", K1312_DateCancel"
            SQL = SQL & ", K1312_RemarkCancel"
            SQL = SQL & ", K1312_DateComplete"
            SQL = SQL & ", K1312_DatePending"
            SQL = SQL & ", K1312_DatePending2"
            SQL = SQL & ", K1312_DateExchangePrice"
            SQL = SQL & ", K1312_SizeW"
            SQL = SQL & ", K1312_SizeL"
            SQL = SQL & ", K1312_SizeH"
            SQL = SQL & ", K1312_QtyNo1"
            SQL = SQL & ", K1312_QtyNo2"
            SQL = SQL & ", K1312_QtyNo3"
            SQL = SQL & ", K1312_QtyGW"
            SQL = SQL & ", K1312_QtyNW"
            SQL = SQL & ", K1312_QtyPcsPoly"
            SQL = SQL & ", K1312_QtyPolyCTN"
            SQL = SQL & ", K1312_QtyPcsCTN"
            SQL = SQL & ", K1312_QtyPcsPINO"
            SQL = SQL & ", K1312_PriceExchange"
            SQL = SQL & ", K1312_CheckFOB"
            SQL = SQL & ", K1312_PriceOrderFOB"
            SQL = SQL & ", K1312_TotalAMTFOB"
            SQL = SQL & ", K1312_PriceOrder"
            SQL = SQL & ", K1312_PriceOrder1"
            SQL = SQL & ", K1312_PriceOrder2"
            SQL = SQL & ", K1312_PriceOrder3"
            SQL = SQL & ", K1312_seUnitPrice"
            SQL = SQL & ", K1312_cdUnitPrice"
            SQL = SQL & ", K1312_UnitPrice"
            SQL = SQL & ", K1312_PriceOrderEX"
            SQL = SQL & ", K1312_PriceOrderVND"
            SQL = SQL & ", K1312_Datedelivery"
            SQL = SQL & ", K1312_DateTransfer"
            SQL = SQL & ", K1312_AcceptedOrder"
            SQL = SQL & ", K1312_MaterialStatus"
            SQL = SQL & ", K1312_SoleStatus"
            SQL = SQL & ", K1312_DateLable"
            SQL = SQL & ", K1312_DatePattern"
            SQL = SQL & ", K1312_DateMaterial"
            SQL = SQL & ", K1312_DatePlanning"
            SQL = SQL & ", K1312_DateRnD"
            SQL = SQL & ", K1312_DateFitting"
            SQL = SQL & ", K1312_InchargeFitting"
            SQL = SQL & ", K1312_CheckFitting"
            SQL = SQL & ", K1312_DateTesting"
            SQL = SQL & ", K1312_InchargeTesting"
            SQL = SQL & ", K1312_CheckTesting"
            SQL = SQL & ", K1312_CheckConfirm"
            SQL = SQL & ", K1312_DateConfirm"
            SQL = SQL & ", K1312_InchargeRD1"
            SQL = SQL & ", K1312_InchargeRD2"
            SQL = SQL & ", K1312_InchargeRD3"
            SQL = SQL & ", K1312_InchargeRD4"
            SQL = SQL & ", K1312_DateSRD1"
            SQL = SQL & ", K1312_DateERD1"
            SQL = SQL & ", K1312_DateSRD2"
            SQL = SQL & ", K1312_DateERD2"
            SQL = SQL & ", K1312_DateSRD3"
            SQL = SQL & ", K1312_DateERD3"
            SQL = SQL & ", K1312_DateSRD4"
            SQL = SQL & ", K1312_DateERD4"
            SQL = SQL & ", K1312_SpecNo"
            SQL = SQL & ", K1312_SpecNoSeq"
            SQL = SQL & ", K1312_DateSole"
            SQL = SQL & ", K1312_DateCutting"
            SQL = SQL & ", K1312_DateStitching"
            SQL = SQL & ", K1312_DateStockfit"
            SQL = SQL & ", K1312_DateAssmbly"
            SQL = SQL & ", K1312_DateShipping"
            SQL = SQL & ", K1312_seUnitMaterial"
            SQL = SQL & ", K1312_cdUnitMaterial"
            SQL = SQL & ", K1312_seUnitPacking"
            SQL = SQL & ", K1312_cdUnitPacking"
            SQL = SQL & ", K1312_QtyOrderSample"
            SQL = SQL & ", K1312_QtyOrderSample01"
            SQL = SQL & ", K1312_QtyOrderSample02"
            SQL = SQL & ", K1312_QtyOrder"
            SQL = SQL & ", K1312_QtyJob"
            SQL = SQL & ", K1312_QtySole"
            SQL = SQL & ", K1312_QtyCutting"
            SQL = SQL & ", K1312_QtyStitching"
            SQL = SQL & ", K1312_QtyStockfit"
            SQL = SQL & ", K1312_QtyAssembly"
            SQL = SQL & ", K1312_QtyPacking"
            SQL = SQL & ", K1312_QtyInbound"
            SQL = SQL & ", K1312_QtyShipping"
            SQL = SQL & ", K1312_TimeInsert"
            SQL = SQL & ", K1312_TimeUpdate"
            SQL = SQL & ", K1312_DateInsert"
            SQL = SQL & ", K1312_InchargeInsert"
            SQL = SQL & ", K1312_DateUpdate"
            SQL = SQL & ", K1312_InchargeUpdate"
            SQL = SQL & ", K1312_InchargeSales"
            SQL = SQL & ", K1312_InchargePPC"
            SQL = SQL & ", K1312_TotalQty"
            SQL = SQL & ", K1312_TotalAMT"
            SQL = SQL & ", K1312_TotalCost"
            SQL = SQL & ", K1312_TotalProfit"
            SQL = SQL & ", K1312_TotalAMTEX"
            SQL = SQL & ", K1312_TotalAMTVND"
            SQL = SQL & ", K1312_TotalCostEX"
            SQL = SQL & ", K1312_TotalCostVND"
            SQL = SQL & ", K1312_TotalProfitEX"
            SQL = SQL & ", K1312_TotalProfitVND"
            SQL = SQL & ", K1312_AttachID"
            SQL = SQL & ", K1312_DateSync"
            SQL = SQL & ", K1312_CheckSync"
            SQL = SQL & ", K1312_PINo"
            SQL = SQL & ", K1312_CheckSizeGroup"
            SQL = SQL & ", K1312_OrderNoRef"
            SQL = SQL & ", K1312_OrderNoSeqRef"
            SQL = SQL & ", K1312_Remark"
            SQL = SQL & ", K1312_RemarkOrder"
            SQL = SQL & ", K1312_RemarkCustomer"
            SQL = SQL & ", K1312_RemarkOther"
            SQL = SQL & ", K1312_RemarkTrading"
            SQL = SQL & ", K1312_seSite"
            SQL = SQL & ", K1312_cdSite"
            SQL = SQL & ", K1312_LicenseName"
            SQL = SQL & ", K1312_TestStandard"
            SQL = SQL & ", K1312_TestNo"
            SQL = SQL & ", K1312_DateReport"
            SQL = SQL & ", K1312_InvoiceStatus"
            SQL = SQL & ", K1312_WIPStatus"
            SQL = SQL & ", K1312_WIPDate"
            SQL = SQL & ", K1312_WIPNo"
            SQL = SQL & ", K1312_ExportCode"
            SQL = SQL & ", K1312_ExportName"

            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  '" & FormatSQL(z1312.OrderNo) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.OrderNoSeq) & "' "
            SQL = SQL & ",  N'" & FormatSQL(z1312.PRName) & "' "
            SQL = SQL & ",  N'" & FormatSQL(z1312.TimeReviseApt) & "' "
            SQL = SQL & ",  N'" & FormatSQL(z1312.TimeRevisePrt) & "' "
            SQL = SQL & ",  N'" & FormatSQL(z1312.TimeRevise) & "' "
            SQL = SQL & ",  N'" & FormatSQL(z1312.TimeRnDRevise) & "' "
            SQL = SQL & ",  N'" & FormatSQL(z1312.TimeSalesRevise) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.InchargeRevise) & "' "
            SQL = SQL & ",  " & FormatSQL(z1312.ReviseNo) & " "
            SQL = SQL & ",  '" & FormatSQL(z1312.ShoesCode) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.ShoesCodeFin) & "' "
            SQL = SQL & ",  N'" & FormatSQL(z1312.FacPO) & "' "
            SQL = SQL & ",  N'" & FormatSQL(z1312.SLNoSys) & "' "
            SQL = SQL & ",  N'" & FormatSQL(z1312.SLNo) & "' "
            SQL = SQL & ",  N'" & FormatSQL(z1312.PONO) & "' "
            SQL = SQL & ",  N'" & FormatSQL(z1312.CPONO) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.CustomerCode) & "' "
            SQL = SQL & ",  N'" & FormatSQL(z1312.CustomerName) & "' "
            SQL = SQL & ",  N'" & FormatSQL(z1312.Country) & "' "
            SQL = SQL & ",  N'" & FormatSQL(z1312.Destination) & "' "
            SQL = SQL & ",  N'" & FormatSQL(z1312.FinalShop) & "' "
            SQL = SQL & ",  N'" & FormatSQL(z1312.PKO) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.DatePO) & "' "
            SQL = SQL & ",  N'" & FormatSQL(z1312.JbCard) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.sePackingCode) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.cdPackingCode) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.seSpecStatus) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.cdSpecStatus) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.SizeRange) & "' "
            SQL = SQL & ",  N'" & FormatSQL(z1312.SpeciticSize) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.DateSize) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.OrderDetailStatus) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.DateOrder) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.DateApproval) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.DateCL) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.DateCancel) & "' "
            SQL = SQL & ",  N'" & FormatSQL(z1312.RemarkCancel) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.DateComplete) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.DatePending) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.DatePending2) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.DateExchangePrice) & "' "
            SQL = SQL & ",  " & FormatSQL(z1312.SizeW) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.SizeL) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.SizeH) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.QtyNo1) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.QtyNo2) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.QtyNo3) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.QtyGW) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.QtyNW) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.QtyPcsPoly) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.QtyPolyCTN) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.QtyPcsCTN) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.QtyPcsPINO) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.PriceExchange) & " "
            SQL = SQL & ",  '" & FormatSQL(z1312.CheckFOB) & "' "
            SQL = SQL & ",  " & FormatSQL(z1312.PriceOrderFOB) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.TotalAMTFOB) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.PriceOrder) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.PriceOrder1) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.PriceOrder2) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.PriceOrder3) & " "
            SQL = SQL & ",  '" & FormatSQL(z1312.seUnitPrice) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.cdUnitPrice) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.UnitPrice) & "' "
            SQL = SQL & ",  " & FormatSQL(z1312.PriceOrderEX) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.PriceOrderVND) & " "
            SQL = SQL & ",  '" & FormatSQL(z1312.Datedelivery) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.DateTransfer) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.AcceptedOrder) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.MaterialStatus) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.SoleStatus) & "' "
            SQL = SQL & ",  N'" & FormatSQL(z1312.DateLable) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.DatePattern) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.DateMaterial) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.DatePlanning) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.DateRnD) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.DateFitting) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.InchargeFitting) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.CheckFitting) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.DateTesting) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.InchargeTesting) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.CheckTesting) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.CheckConfirm) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.DateConfirm) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.InchargeRD1) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.InchargeRD2) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.InchargeRD3) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.InchargeRD4) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.DateSRD1) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.DateERD1) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.DateSRD2) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.DateERD2) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.DateSRD3) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.DateERD3) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.DateSRD4) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.DateERD4) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.SpecNo) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.SpecNoSeq) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.DateSole) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.DateCutting) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.DateStitching) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.DateStockfit) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.DateAssmbly) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.DateShipping) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.seUnitMaterial) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.cdUnitMaterial) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.seUnitPacking) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.cdUnitPacking) & "' "
            SQL = SQL & ",  " & FormatSQL(z1312.QtyOrderSample) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.QtyOrderSample01) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.QtyOrderSample02) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.QtyOrder) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.QtyJob) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.QtySole) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.QtyCutting) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.QtyStitching) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.QtyStockfit) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.QtyAssembly) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.QtyPacking) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.QtyInbound) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.QtyShipping) & " "
            SQL = SQL & ",  '" & FormatSQL(z1312.TimeInsert) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.TimeUpdate) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.DateInsert) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.InchargeInsert) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.DateUpdate) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.InchargeUpdate) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.InchargeSales) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.InchargePPC) & "' "
            SQL = SQL & ",  " & FormatSQL(z1312.TotalQty) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.TotalAMT) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.TotalCost) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.TotalProfit) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.TotalAMTEX) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.TotalAMTVND) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.TotalCostEX) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.TotalCostVND) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.TotalProfitEX) & " "
            SQL = SQL & ",  " & FormatSQL(z1312.TotalProfitVND) & " "
            SQL = SQL & ",  '" & FormatSQL(z1312.AttachID) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.DateSync) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.CheckSync) & "' "
            SQL = SQL & ",  N'" & FormatSQL(z1312.PINo) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.CheckSizeGroup) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.OrderNoRef) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.OrderNoSeqRef) & "' "
            SQL = SQL & ",  N'" & FormatSQL(z1312.Remark) & "' "
            SQL = SQL & ",  N'" & FormatSQL(z1312.RemarkOrder) & "' "
            SQL = SQL & ",  N'" & FormatSQL(z1312.RemarkCustomer) & "' "
            SQL = SQL & ",  N'" & FormatSQL(z1312.RemarkOther) & "' "
            SQL = SQL & ",  N'" & FormatSQL(z1312.RemarkTrading) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.seSite) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.cdSite) & "' "
            SQL = SQL & ",  N'" & FormatSQL(z1312.LicenseName) & "' "
            SQL = SQL & ",  N'" & FormatSQL(z1312.TestStandard) & "' "
            SQL = SQL & ",  N'" & FormatSQL(z1312.TestNo) & "' "
            SQL = SQL & ",  N'" & FormatSQL(z1312.DateReport) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.InvoiceStatus) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.WIPStatus) & "' "
            SQL = SQL & ",  '" & FormatSQL(z1312.WIPDate) & "' "
            SQL = SQL & ",  N'" & FormatSQL(z1312.WIPNo) & "' "
            SQL = SQL & ",  N'" & FormatSQL(z1312.ExportCode) & "' "
            SQL = SQL & ",  N'" & FormatSQL(z1312.ExportName) & "' "

            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK1312 = True
            Exit Function
        Catch ex As Exception

        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK1312(z1312 As T1312_AREA) As Boolean
        REWRITE_PFK1312 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z1312)

            SQL = " UPDATE PFK1312 SET "
            SQL = SQL & "    K1312_PRName        = N'" & FormatSQL(z1312.PRName) & "' "
            SQL = SQL & ",    K1312_TimeReviseApt        = N'" & FormatSQL(z1312.TimeReviseApt) & "' "
            SQL = SQL & ",    K1312_TimeRevisePrt        = N'" & FormatSQL(z1312.TimeRevisePrt) & "' "
            SQL = SQL & ",    K1312_TimeRevise        = N'" & FormatSQL(z1312.TimeRevise) & "' "
            SQL = SQL & ",    K1312_TimeRnDRevise        = N'" & FormatSQL(z1312.TimeRnDRevise) & "' "
            SQL = SQL & ",    K1312_TimeSalesRevise        = N'" & FormatSQL(z1312.TimeSalesRevise) & "' "
            SQL = SQL & ",    K1312_InchargeRevise        = '" & FormatSQL(z1312.InchargeRevise) & "' "
            SQL = SQL & ",    K1312_ReviseNo        = " & FormatSQL(z1312.ReviseNo) & " "
            SQL = SQL & ",    K1312_ShoesCode        = '" & FormatSQL(z1312.ShoesCode) & "' "
            SQL = SQL & ",    K1312_ShoesCodeFin        = '" & FormatSQL(z1312.ShoesCodeFin) & "' "
            SQL = SQL & ",    K1312_FacPO        = N'" & FormatSQL(z1312.FacPO) & "' "
            SQL = SQL & ",    K1312_SLNoSys        = N'" & FormatSQL(z1312.SLNoSys) & "' "
            SQL = SQL & ",    K1312_SLNo        = N'" & FormatSQL(z1312.SLNo) & "' "
            SQL = SQL & ",    K1312_PONO        = N'" & FormatSQL(z1312.PONO) & "' "
            SQL = SQL & ",    K1312_CPONO        = N'" & FormatSQL(z1312.CPONO) & "' "
            SQL = SQL & ",    K1312_CustomerCode        = '" & FormatSQL(z1312.CustomerCode) & "' "
            SQL = SQL & ",    K1312_CustomerName        = N'" & FormatSQL(z1312.CustomerName) & "' "
            SQL = SQL & ",    K1312_Country        = N'" & FormatSQL(z1312.Country) & "' "
            SQL = SQL & ",    K1312_Destination        = N'" & FormatSQL(z1312.Destination) & "' "
            SQL = SQL & ",    K1312_FinalShop        = N'" & FormatSQL(z1312.FinalShop) & "' "
            SQL = SQL & ",    K1312_PKO        = N'" & FormatSQL(z1312.PKO) & "' "
            SQL = SQL & ",    K1312_DatePO        = '" & FormatSQL(z1312.DatePO) & "' "
            SQL = SQL & ",    K1312_JbCard        = N'" & FormatSQL(z1312.JbCard) & "' "
            SQL = SQL & ",    K1312_sePackingCode        = '" & FormatSQL(z1312.sePackingCode) & "' "
            SQL = SQL & ",    K1312_cdPackingCode        = '" & FormatSQL(z1312.cdPackingCode) & "' "
            SQL = SQL & ",    K1312_seSpecStatus        = '" & FormatSQL(z1312.seSpecStatus) & "' "
            SQL = SQL & ",    K1312_cdSpecStatus        = '" & FormatSQL(z1312.cdSpecStatus) & "' "
            SQL = SQL & ",    K1312_SizeRange        = '" & FormatSQL(z1312.SizeRange) & "' "
            SQL = SQL & ",    K1312_SpeciticSize        = N'" & FormatSQL(z1312.SpeciticSize) & "' "
            SQL = SQL & ",    K1312_DateSize        = '" & FormatSQL(z1312.DateSize) & "' "
            SQL = SQL & ",    K1312_OrderDetailStatus        = '" & FormatSQL(z1312.OrderDetailStatus) & "' "
            SQL = SQL & ",    K1312_DateOrder        = '" & FormatSQL(z1312.DateOrder) & "' "
            SQL = SQL & ",    K1312_DateApproval        = '" & FormatSQL(z1312.DateApproval) & "' "
            SQL = SQL & ",    K1312_DateCL        = '" & FormatSQL(z1312.DateCL) & "' "
            SQL = SQL & ",    K1312_DateCancel        = '" & FormatSQL(z1312.DateCancel) & "' "
            SQL = SQL & ",    K1312_RemarkCancel        = N'" & FormatSQL(z1312.RemarkCancel) & "' "
            SQL = SQL & ",    K1312_DateComplete        = '" & FormatSQL(z1312.DateComplete) & "' "
            SQL = SQL & ",    K1312_DatePending        = '" & FormatSQL(z1312.DatePending) & "' "
            SQL = SQL & ",    K1312_DatePending2        = '" & FormatSQL(z1312.DatePending2) & "' "
            SQL = SQL & ",    K1312_DateExchangePrice        = '" & FormatSQL(z1312.DateExchangePrice) & "' "
            SQL = SQL & ",    K1312_SizeW        = " & FormatSQL(z1312.SizeW) & " "
            SQL = SQL & ",    K1312_SizeL        = " & FormatSQL(z1312.SizeL) & " "
            SQL = SQL & ",    K1312_SizeH        = " & FormatSQL(z1312.SizeH) & " "
            SQL = SQL & ",    K1312_QtyNo1        = " & FormatSQL(z1312.QtyNo1) & " "
            SQL = SQL & ",    K1312_QtyNo2        = " & FormatSQL(z1312.QtyNo2) & " "
            SQL = SQL & ",    K1312_QtyNo3        = " & FormatSQL(z1312.QtyNo3) & " "
            SQL = SQL & ",    K1312_QtyGW        = " & FormatSQL(z1312.QtyGW) & " "
            SQL = SQL & ",    K1312_QtyNW        = " & FormatSQL(z1312.QtyNW) & " "
            SQL = SQL & ",    K1312_QtyPcsPoly        = " & FormatSQL(z1312.QtyPcsPoly) & " "
            SQL = SQL & ",    K1312_QtyPolyCTN        = " & FormatSQL(z1312.QtyPolyCTN) & " "
            SQL = SQL & ",    K1312_QtyPcsCTN        = " & FormatSQL(z1312.QtyPcsCTN) & " "
            SQL = SQL & ",    K1312_QtyPcsPINO        = " & FormatSQL(z1312.QtyPcsPINO) & " "
            SQL = SQL & ",    K1312_PriceExchange        = " & FormatSQL(z1312.PriceExchange) & " "
            SQL = SQL & ",    K1312_CheckFOB        = '" & FormatSQL(z1312.CheckFOB) & "' "
            SQL = SQL & ",    K1312_PriceOrderFOB        = " & FormatSQL(z1312.PriceOrderFOB) & " "
            SQL = SQL & ",    K1312_TotalAMTFOB        = " & FormatSQL(z1312.TotalAMTFOB) & " "
            SQL = SQL & ",    K1312_PriceOrder        = " & FormatSQL(z1312.PriceOrder) & " "
            SQL = SQL & ",    K1312_PriceOrder1        = " & FormatSQL(z1312.PriceOrder1) & " "
            SQL = SQL & ",    K1312_PriceOrder2        = " & FormatSQL(z1312.PriceOrder2) & " "
            SQL = SQL & ",    K1312_PriceOrder3        = " & FormatSQL(z1312.PriceOrder3) & " "
            SQL = SQL & ",    K1312_seUnitPrice        = '" & FormatSQL(z1312.seUnitPrice) & "' "
            SQL = SQL & ",    K1312_cdUnitPrice        = '" & FormatSQL(z1312.cdUnitPrice) & "' "
            SQL = SQL & ",    K1312_UnitPrice        = '" & FormatSQL(z1312.UnitPrice) & "' "
            SQL = SQL & ",    K1312_PriceOrderEX        = " & FormatSQL(z1312.PriceOrderEX) & " "
            SQL = SQL & ",    K1312_PriceOrderVND        = " & FormatSQL(z1312.PriceOrderVND) & " "
            SQL = SQL & ",    K1312_Datedelivery        = '" & FormatSQL(z1312.Datedelivery) & "' "
            SQL = SQL & ",    K1312_DateTransfer        = '" & FormatSQL(z1312.DateTransfer) & "' "
            SQL = SQL & ",    K1312_AcceptedOrder        = '" & FormatSQL(z1312.AcceptedOrder) & "' "
            SQL = SQL & ",    K1312_MaterialStatus        = '" & FormatSQL(z1312.MaterialStatus) & "' "
            SQL = SQL & ",    K1312_SoleStatus        = '" & FormatSQL(z1312.SoleStatus) & "' "
            SQL = SQL & ",    K1312_DateLable        = N'" & FormatSQL(z1312.DateLable) & "' "
            SQL = SQL & ",    K1312_DatePattern        = '" & FormatSQL(z1312.DatePattern) & "' "
            SQL = SQL & ",    K1312_DateMaterial        = '" & FormatSQL(z1312.DateMaterial) & "' "
            SQL = SQL & ",    K1312_DatePlanning        = '" & FormatSQL(z1312.DatePlanning) & "' "
            SQL = SQL & ",    K1312_DateRnD        = '" & FormatSQL(z1312.DateRnD) & "' "
            SQL = SQL & ",    K1312_DateFitting        = '" & FormatSQL(z1312.DateFitting) & "' "
            SQL = SQL & ",    K1312_InchargeFitting        = '" & FormatSQL(z1312.InchargeFitting) & "' "
            SQL = SQL & ",    K1312_CheckFitting        = '" & FormatSQL(z1312.CheckFitting) & "' "
            SQL = SQL & ",    K1312_DateTesting        = '" & FormatSQL(z1312.DateTesting) & "' "
            SQL = SQL & ",    K1312_InchargeTesting        = '" & FormatSQL(z1312.InchargeTesting) & "' "
            SQL = SQL & ",    K1312_CheckTesting        = '" & FormatSQL(z1312.CheckTesting) & "' "
            SQL = SQL & ",    K1312_CheckConfirm        = '" & FormatSQL(z1312.CheckConfirm) & "' "
            SQL = SQL & ",    K1312_DateConfirm        = '" & FormatSQL(z1312.DateConfirm) & "' "
            SQL = SQL & ",    K1312_InchargeRD1        = '" & FormatSQL(z1312.InchargeRD1) & "' "
            SQL = SQL & ",    K1312_InchargeRD2        = '" & FormatSQL(z1312.InchargeRD2) & "' "
            SQL = SQL & ",    K1312_InchargeRD3        = '" & FormatSQL(z1312.InchargeRD3) & "' "
            SQL = SQL & ",    K1312_InchargeRD4        = '" & FormatSQL(z1312.InchargeRD4) & "' "
            SQL = SQL & ",    K1312_DateSRD1        = '" & FormatSQL(z1312.DateSRD1) & "' "
            SQL = SQL & ",    K1312_DateERD1        = '" & FormatSQL(z1312.DateERD1) & "' "
            SQL = SQL & ",    K1312_DateSRD2        = '" & FormatSQL(z1312.DateSRD2) & "' "
            SQL = SQL & ",    K1312_DateERD2        = '" & FormatSQL(z1312.DateERD2) & "' "
            SQL = SQL & ",    K1312_DateSRD3        = '" & FormatSQL(z1312.DateSRD3) & "' "
            SQL = SQL & ",    K1312_DateERD3        = '" & FormatSQL(z1312.DateERD3) & "' "
            SQL = SQL & ",    K1312_DateSRD4        = '" & FormatSQL(z1312.DateSRD4) & "' "
            SQL = SQL & ",    K1312_DateERD4        = '" & FormatSQL(z1312.DateERD4) & "' "
            SQL = SQL & ",    K1312_SpecNo        = '" & FormatSQL(z1312.SpecNo) & "' "
            SQL = SQL & ",    K1312_SpecNoSeq        = '" & FormatSQL(z1312.SpecNoSeq) & "' "
            SQL = SQL & ",    K1312_DateSole        = '" & FormatSQL(z1312.DateSole) & "' "
            SQL = SQL & ",    K1312_DateCutting        = '" & FormatSQL(z1312.DateCutting) & "' "
            SQL = SQL & ",    K1312_DateStitching        = '" & FormatSQL(z1312.DateStitching) & "' "
            SQL = SQL & ",    K1312_DateStockfit        = '" & FormatSQL(z1312.DateStockfit) & "' "
            SQL = SQL & ",    K1312_DateAssmbly        = '" & FormatSQL(z1312.DateAssmbly) & "' "
            SQL = SQL & ",    K1312_DateShipping        = '" & FormatSQL(z1312.DateShipping) & "' "
            SQL = SQL & ",    K1312_seUnitMaterial        = '" & FormatSQL(z1312.seUnitMaterial) & "' "
            SQL = SQL & ",    K1312_cdUnitMaterial        = '" & FormatSQL(z1312.cdUnitMaterial) & "' "
            SQL = SQL & ",    K1312_seUnitPacking        = '" & FormatSQL(z1312.seUnitPacking) & "' "
            SQL = SQL & ",    K1312_cdUnitPacking        = '" & FormatSQL(z1312.cdUnitPacking) & "' "
            SQL = SQL & ",    K1312_QtyOrderSample        = " & FormatSQL(z1312.QtyOrderSample) & " "
            SQL = SQL & ",    K1312_QtyOrderSample01        = " & FormatSQL(z1312.QtyOrderSample01) & " "
            SQL = SQL & ",    K1312_QtyOrderSample02        = " & FormatSQL(z1312.QtyOrderSample02) & " "
            SQL = SQL & ",    K1312_QtyOrder        = " & FormatSQL(z1312.QtyOrder) & " "
            SQL = SQL & ",    K1312_QtyJob        = " & FormatSQL(z1312.QtyJob) & " "
            SQL = SQL & ",    K1312_QtySole        = " & FormatSQL(z1312.QtySole) & " "
            SQL = SQL & ",    K1312_QtyCutting        = " & FormatSQL(z1312.QtyCutting) & " "
            SQL = SQL & ",    K1312_QtyStitching        = " & FormatSQL(z1312.QtyStitching) & " "
            SQL = SQL & ",    K1312_QtyStockfit        = " & FormatSQL(z1312.QtyStockfit) & " "
            SQL = SQL & ",    K1312_QtyAssembly        = " & FormatSQL(z1312.QtyAssembly) & " "
            SQL = SQL & ",    K1312_QtyPacking        = " & FormatSQL(z1312.QtyPacking) & " "
            SQL = SQL & ",    K1312_QtyInbound        = " & FormatSQL(z1312.QtyInbound) & " "
            SQL = SQL & ",    K1312_QtyShipping        = " & FormatSQL(z1312.QtyShipping) & " "
            SQL = SQL & ",    K1312_TimeInsert        = '" & FormatSQL(z1312.TimeInsert) & "' "
            SQL = SQL & ",    K1312_TimeUpdate        = '" & FormatSQL(z1312.TimeUpdate) & "' "
            SQL = SQL & ",    K1312_DateInsert        = '" & FormatSQL(z1312.DateInsert) & "' "
            SQL = SQL & ",    K1312_InchargeInsert        = '" & FormatSQL(z1312.InchargeInsert) & "' "
            SQL = SQL & ",    K1312_DateUpdate        = '" & FormatSQL(z1312.DateUpdate) & "' "
            SQL = SQL & ",    K1312_InchargeUpdate        = '" & FormatSQL(z1312.InchargeUpdate) & "' "
            SQL = SQL & ",    K1312_InchargeSales        = '" & FormatSQL(z1312.InchargeSales) & "' "
            SQL = SQL & ",    K1312_InchargePPC        = '" & FormatSQL(z1312.InchargePPC) & "' "
            SQL = SQL & ",    K1312_TotalQty        = " & FormatSQL(z1312.TotalQty) & " "
            SQL = SQL & ",    K1312_TotalAMT        = " & FormatSQL(z1312.TotalAMT) & " "
            SQL = SQL & ",    K1312_TotalCost        = " & FormatSQL(z1312.TotalCost) & " "
            SQL = SQL & ",    K1312_TotalProfit        = " & FormatSQL(z1312.TotalProfit) & " "
            SQL = SQL & ",    K1312_TotalAMTEX        = " & FormatSQL(z1312.TotalAMTEX) & " "
            SQL = SQL & ",    K1312_TotalAMTVND        = " & FormatSQL(z1312.TotalAMTVND) & " "
            SQL = SQL & ",    K1312_TotalCostEX        = " & FormatSQL(z1312.TotalCostEX) & " "
            SQL = SQL & ",    K1312_TotalCostVND        = " & FormatSQL(z1312.TotalCostVND) & " "
            SQL = SQL & ",    K1312_TotalProfitEX        = " & FormatSQL(z1312.TotalProfitEX) & " "
            SQL = SQL & ",    K1312_TotalProfitVND        = " & FormatSQL(z1312.TotalProfitVND) & " "
            SQL = SQL & ",    K1312_AttachID        = '" & FormatSQL(z1312.AttachID) & "' "
            SQL = SQL & ",    K1312_DateSync        = '" & FormatSQL(z1312.DateSync) & "' "
            SQL = SQL & ",    K1312_CheckSync        = '" & FormatSQL(z1312.CheckSync) & "' "
            SQL = SQL & ",    K1312_PINo        = N'" & FormatSQL(z1312.PINo) & "' "
            SQL = SQL & ",    K1312_CheckSizeGroup        = '" & FormatSQL(z1312.CheckSizeGroup) & "' "
            SQL = SQL & ",    K1312_OrderNoRef        = '" & FormatSQL(z1312.OrderNoRef) & "' "
            SQL = SQL & ",    K1312_OrderNoSeqRef        = '" & FormatSQL(z1312.OrderNoSeqRef) & "' "
            SQL = SQL & ",    K1312_Remark        = N'" & FormatSQL(z1312.Remark) & "' "
            SQL = SQL & ",    K1312_RemarkOrder        = N'" & FormatSQL(z1312.RemarkOrder) & "' "
            SQL = SQL & ",    K1312_RemarkCustomer        = N'" & FormatSQL(z1312.RemarkCustomer) & "' "
            SQL = SQL & ",    K1312_RemarkOther        = N'" & FormatSQL(z1312.RemarkOther) & "' "
            SQL = SQL & ",    K1312_RemarkTrading        = N'" & FormatSQL(z1312.RemarkTrading) & "' "
            SQL = SQL & ",    K1312_seSite        = '" & FormatSQL(z1312.seSite) & "' "
            SQL = SQL & ",    K1312_cdSite        = '" & FormatSQL(z1312.cdSite) & "' "
            SQL = SQL & ",    K1312_LicenseName        = N'" & FormatSQL(z1312.LicenseName) & "' "
            SQL = SQL & ",    K1312_TestStandard        = N'" & FormatSQL(z1312.TestStandard) & "' "
            SQL = SQL & ",    K1312_TestNo        = N'" & FormatSQL(z1312.TestNo) & "' "
            SQL = SQL & ",    K1312_DateReport        = N'" & FormatSQL(z1312.DateReport) & "' "
            SQL = SQL & ",    K1312_InvoiceStatus        = '" & FormatSQL(z1312.InvoiceStatus) & "' "
            SQL = SQL & ",    K1312_WIPStatus        = '" & FormatSQL(z1312.WIPStatus) & "' "
            SQL = SQL & ",    K1312_WIPDate        = '" & FormatSQL(z1312.WIPDate) & "' "
            SQL = SQL & ",    K1312_WIPNo        = N'" & FormatSQL(z1312.WIPNo) & "' "
            SQL = SQL & ",    K1312_ExportCode        = N'" & FormatSQL(z1312.ExportCode) & "' "
            SQL = SQL & ",    K1312_ExportName        = N'" & FormatSQL(z1312.ExportName) & "' "

            SQL = SQL & " WHERE K1312_OrderNo		 = '" & z1312.OrderNo & "' "
            SQL = SQL & " AND K1312_OrderNoSeq		 = '" & z1312.OrderNoSeq & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK1312 = True

            Exit Function
        Catch ex As Exception

        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK1312(z1312 As T1312_AREA) As Boolean
        DELETE_PFK1312 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK1312 "
            SQL = SQL & " WHERE K1312_OrderNo		 = '" & z1312.OrderNo & "' "
            SQL = SQL & " AND K1312_OrderNoSeq		 = '" & z1312.OrderNoSeq & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK1312 = True
            Exit Function
        Catch ex As Exception

        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D1312_CLEAR()
        Try

            D1312.OrderNo = ""
            D1312.OrderNoSeq = ""
            D1312.PRName = ""
            D1312.TimeReviseApt = ""
            D1312.TimeRevisePrt = ""
            D1312.TimeRevise = ""
            D1312.TimeRnDRevise = ""
            D1312.TimeSalesRevise = ""
            D1312.InchargeRevise = ""
            D1312.ReviseNo = 0
            D1312.ShoesCode = ""
            D1312.ShoesCodeFin = ""
            D1312.FacPO = ""
            D1312.SLNoSys = ""
            D1312.SLNo = ""
            D1312.PONO = ""
            D1312.CPONO = ""
            D1312.CustomerCode = ""
            D1312.CustomerName = ""
            D1312.Country = ""
            D1312.Destination = ""
            D1312.FinalShop = ""
            D1312.PKO = ""
            D1312.DatePO = ""
            D1312.JbCard = ""
            D1312.sePackingCode = ""
            D1312.cdPackingCode = ""
            D1312.seSpecStatus = ""
            D1312.cdSpecStatus = ""
            D1312.SizeRange = ""
            D1312.SpeciticSize = ""
            D1312.DateSize = ""
            D1312.OrderDetailStatus = ""
            D1312.DateOrder = ""
            D1312.DateApproval = ""
            D1312.DateCL = ""
            D1312.DateCancel = ""
            D1312.RemarkCancel = ""
            D1312.DateComplete = ""
            D1312.DatePending = ""
            D1312.DatePending2 = ""
            D1312.DateExchangePrice = ""
            D1312.SizeW = 0
            D1312.SizeL = 0
            D1312.SizeH = 0
            D1312.QtyNo1 = 0
            D1312.QtyNo2 = 0
            D1312.QtyNo3 = 0
            D1312.QtyGW = 0
            D1312.QtyNW = 0
            D1312.QtyPcsPoly = 0
            D1312.QtyPolyCTN = 0
            D1312.QtyPcsCTN = 0
            D1312.QtyPcsPINO = 0
            D1312.PriceExchange = 0
            D1312.CheckFOB = ""
            D1312.PriceOrderFOB = 0
            D1312.TotalAMTFOB = 0
            D1312.PriceOrder = 0
            D1312.PriceOrder1 = 0
            D1312.PriceOrder2 = 0
            D1312.PriceOrder3 = 0
            D1312.seUnitPrice = ""
            D1312.cdUnitPrice = ""
            D1312.UnitPrice = ""
            D1312.PriceOrderEX = 0
            D1312.PriceOrderVND = 0
            D1312.Datedelivery = ""
            D1312.DateTransfer = ""
            D1312.AcceptedOrder = ""
            D1312.MaterialStatus = ""
            D1312.SoleStatus = ""
            D1312.DateLable = ""
            D1312.DatePattern = ""
            D1312.DateMaterial = ""
            D1312.DatePlanning = ""
            D1312.DateRnD = ""
            D1312.DateFitting = ""
            D1312.InchargeFitting = ""
            D1312.CheckFitting = ""
            D1312.DateTesting = ""
            D1312.InchargeTesting = ""
            D1312.CheckTesting = ""
            D1312.CheckConfirm = ""
            D1312.DateConfirm = ""
            D1312.InchargeRD1 = ""
            D1312.InchargeRD2 = ""
            D1312.InchargeRD3 = ""
            D1312.InchargeRD4 = ""
            D1312.DateSRD1 = ""
            D1312.DateERD1 = ""
            D1312.DateSRD2 = ""
            D1312.DateERD2 = ""
            D1312.DateSRD3 = ""
            D1312.DateERD3 = ""
            D1312.DateSRD4 = ""
            D1312.DateERD4 = ""
            D1312.SpecNo = ""
            D1312.SpecNoSeq = ""
            D1312.DateSole = ""
            D1312.DateCutting = ""
            D1312.DateStitching = ""
            D1312.DateStockfit = ""
            D1312.DateAssmbly = ""
            D1312.DateShipping = ""
            D1312.seUnitMaterial = ""
            D1312.cdUnitMaterial = ""
            D1312.seUnitPacking = ""
            D1312.cdUnitPacking = ""
            D1312.QtyOrderSample = 0
            D1312.QtyOrderSample01 = 0
            D1312.QtyOrderSample02 = 0
            D1312.QtyOrder = 0
            D1312.QtyJob = 0
            D1312.QtySole = 0
            D1312.QtyCutting = 0
            D1312.QtyStitching = 0
            D1312.QtyStockfit = 0
            D1312.QtyAssembly = 0
            D1312.QtyPacking = 0
            D1312.QtyInbound = 0
            D1312.QtyShipping = 0
            D1312.TimeInsert = ""
            D1312.TimeUpdate = ""
            D1312.DateInsert = ""
            D1312.InchargeInsert = ""
            D1312.DateUpdate = ""
            D1312.InchargeUpdate = ""
            D1312.InchargeSales = ""
            D1312.InchargePPC = ""
            D1312.TotalQty = 0
            D1312.TotalAMT = 0
            D1312.TotalCost = 0
            D1312.TotalProfit = 0
            D1312.TotalAMTEX = 0
            D1312.TotalAMTVND = 0
            D1312.TotalCostEX = 0
            D1312.TotalCostVND = 0
            D1312.TotalProfitEX = 0
            D1312.TotalProfitVND = 0
            D1312.AttachID = ""
            D1312.DateSync = ""
            D1312.CheckSync = ""
            D1312.PINo = ""
            D1312.CheckSizeGroup = ""
            D1312.OrderNoRef = ""
            D1312.OrderNoSeqRef = ""
            D1312.Remark = ""
            D1312.RemarkOrder = ""
            D1312.RemarkCustomer = ""
            D1312.RemarkOther = ""
            D1312.RemarkTrading = ""
            D1312.seSite = ""
            D1312.cdSite = ""
            D1312.LicenseName = ""
            D1312.TestStandard = ""
            D1312.TestNo = ""
            D1312.DateReport = ""
            D1312.InvoiceStatus = ""
            D1312.WIPStatus = ""
            D1312.WIPDate = ""
            D1312.WIPNo = ""
            D1312.ExportCode = ""
            D1312.ExportName = ""

        Catch ex As Exception

        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x1312 As T1312_AREA)
        Try

            x1312.OrderNo = Trim$(x1312.OrderNo)
            x1312.OrderNoSeq = Trim$(x1312.OrderNoSeq)
            x1312.PRName = Trim$(x1312.PRName)
            x1312.TimeReviseApt = Trim$(x1312.TimeReviseApt)
            x1312.TimeRevisePrt = Trim$(x1312.TimeRevisePrt)
            x1312.TimeRevise = Trim$(x1312.TimeRevise)
            x1312.TimeRnDRevise = Trim$(x1312.TimeRnDRevise)
            x1312.TimeSalesRevise = Trim$(x1312.TimeSalesRevise)
            x1312.InchargeRevise = Trim$(x1312.InchargeRevise)
            x1312.ReviseNo = Trim$(x1312.ReviseNo)
            x1312.ShoesCode = Trim$(x1312.ShoesCode)
            x1312.ShoesCodeFin = Trim$(x1312.ShoesCodeFin)
            x1312.FacPO = Trim$(x1312.FacPO)
            x1312.SLNoSys = Trim$(x1312.SLNoSys)
            x1312.SLNo = Trim$(x1312.SLNo)
            x1312.PONO = Trim$(x1312.PONO)
            x1312.CPONO = Trim$(x1312.CPONO)
            x1312.CustomerCode = Trim$(x1312.CustomerCode)
            x1312.CustomerName = Trim$(x1312.CustomerName)
            x1312.Country = Trim$(x1312.Country)
            x1312.Destination = Trim$(x1312.Destination)
            x1312.FinalShop = Trim$(x1312.FinalShop)
            x1312.PKO = Trim$(x1312.PKO)
            x1312.DatePO = Trim$(x1312.DatePO)
            x1312.JbCard = Trim$(x1312.JbCard)
            x1312.sePackingCode = Trim$(x1312.sePackingCode)
            x1312.cdPackingCode = Trim$(x1312.cdPackingCode)
            x1312.seSpecStatus = Trim$(x1312.seSpecStatus)
            x1312.cdSpecStatus = Trim$(x1312.cdSpecStatus)
            x1312.SizeRange = Trim$(x1312.SizeRange)
            x1312.SpeciticSize = Trim$(x1312.SpeciticSize)
            x1312.DateSize = Trim$(x1312.DateSize)
            x1312.OrderDetailStatus = Trim$(x1312.OrderDetailStatus)
            x1312.DateOrder = Trim$(x1312.DateOrder)
            x1312.DateApproval = Trim$(x1312.DateApproval)
            x1312.DateCL = Trim$(x1312.DateCL)
            x1312.DateCancel = Trim$(x1312.DateCancel)
            x1312.RemarkCancel = Trim$(x1312.RemarkCancel)
            x1312.DateComplete = Trim$(x1312.DateComplete)
            x1312.DatePending = Trim$(x1312.DatePending)
            x1312.DatePending2 = Trim$(x1312.DatePending2)
            x1312.DateExchangePrice = Trim$(x1312.DateExchangePrice)
            x1312.SizeW = Trim$(x1312.SizeW)
            x1312.SizeL = Trim$(x1312.SizeL)
            x1312.SizeH = Trim$(x1312.SizeH)
            x1312.QtyNo1 = Trim$(x1312.QtyNo1)
            x1312.QtyNo2 = Trim$(x1312.QtyNo2)
            x1312.QtyNo3 = Trim$(x1312.QtyNo3)
            x1312.QtyGW = Trim$(x1312.QtyGW)
            x1312.QtyNW = Trim$(x1312.QtyNW)
            x1312.QtyPcsPoly = Trim$(x1312.QtyPcsPoly)
            x1312.QtyPolyCTN = Trim$(x1312.QtyPolyCTN)
            x1312.QtyPcsCTN = Trim$(x1312.QtyPcsCTN)
            x1312.QtyPcsPINO = Trim$(x1312.QtyPcsPINO)
            x1312.PriceExchange = Trim$(x1312.PriceExchange)
            x1312.CheckFOB = Trim$(x1312.CheckFOB)
            x1312.PriceOrderFOB = Trim$(x1312.PriceOrderFOB)
            x1312.TotalAMTFOB = Trim$(x1312.TotalAMTFOB)
            x1312.PriceOrder = Trim$(x1312.PriceOrder)
            x1312.PriceOrder1 = Trim$(x1312.PriceOrder1)
            x1312.PriceOrder2 = Trim$(x1312.PriceOrder2)
            x1312.PriceOrder3 = Trim$(x1312.PriceOrder3)
            x1312.seUnitPrice = Trim$(x1312.seUnitPrice)
            x1312.cdUnitPrice = Trim$(x1312.cdUnitPrice)
            x1312.UnitPrice = Trim$(x1312.UnitPrice)
            x1312.PriceOrderEX = Trim$(x1312.PriceOrderEX)
            x1312.PriceOrderVND = Trim$(x1312.PriceOrderVND)
            x1312.Datedelivery = Trim$(x1312.Datedelivery)
            x1312.DateTransfer = Trim$(x1312.DateTransfer)
            x1312.AcceptedOrder = Trim$(x1312.AcceptedOrder)
            x1312.MaterialStatus = Trim$(x1312.MaterialStatus)
            x1312.SoleStatus = Trim$(x1312.SoleStatus)
            x1312.DateLable = Trim$(x1312.DateLable)
            x1312.DatePattern = Trim$(x1312.DatePattern)
            x1312.DateMaterial = Trim$(x1312.DateMaterial)
            x1312.DatePlanning = Trim$(x1312.DatePlanning)
            x1312.DateRnD = Trim$(x1312.DateRnD)
            x1312.DateFitting = Trim$(x1312.DateFitting)
            x1312.InchargeFitting = Trim$(x1312.InchargeFitting)
            x1312.CheckFitting = Trim$(x1312.CheckFitting)
            x1312.DateTesting = Trim$(x1312.DateTesting)
            x1312.InchargeTesting = Trim$(x1312.InchargeTesting)
            x1312.CheckTesting = Trim$(x1312.CheckTesting)
            x1312.CheckConfirm = Trim$(x1312.CheckConfirm)
            x1312.DateConfirm = Trim$(x1312.DateConfirm)
            x1312.InchargeRD1 = Trim$(x1312.InchargeRD1)
            x1312.InchargeRD2 = Trim$(x1312.InchargeRD2)
            x1312.InchargeRD3 = Trim$(x1312.InchargeRD3)
            x1312.InchargeRD4 = Trim$(x1312.InchargeRD4)
            x1312.DateSRD1 = Trim$(x1312.DateSRD1)
            x1312.DateERD1 = Trim$(x1312.DateERD1)
            x1312.DateSRD2 = Trim$(x1312.DateSRD2)
            x1312.DateERD2 = Trim$(x1312.DateERD2)
            x1312.DateSRD3 = Trim$(x1312.DateSRD3)
            x1312.DateERD3 = Trim$(x1312.DateERD3)
            x1312.DateSRD4 = Trim$(x1312.DateSRD4)
            x1312.DateERD4 = Trim$(x1312.DateERD4)
            x1312.SpecNo = Trim$(x1312.SpecNo)
            x1312.SpecNoSeq = Trim$(x1312.SpecNoSeq)
            x1312.DateSole = Trim$(x1312.DateSole)
            x1312.DateCutting = Trim$(x1312.DateCutting)
            x1312.DateStitching = Trim$(x1312.DateStitching)
            x1312.DateStockfit = Trim$(x1312.DateStockfit)
            x1312.DateAssmbly = Trim$(x1312.DateAssmbly)
            x1312.DateShipping = Trim$(x1312.DateShipping)
            x1312.seUnitMaterial = Trim$(x1312.seUnitMaterial)
            x1312.cdUnitMaterial = Trim$(x1312.cdUnitMaterial)
            x1312.seUnitPacking = Trim$(x1312.seUnitPacking)
            x1312.cdUnitPacking = Trim$(x1312.cdUnitPacking)
            x1312.QtyOrderSample = Trim$(x1312.QtyOrderSample)
            x1312.QtyOrderSample01 = Trim$(x1312.QtyOrderSample01)
            x1312.QtyOrderSample02 = Trim$(x1312.QtyOrderSample02)
            x1312.QtyOrder = Trim$(x1312.QtyOrder)
            x1312.QtyJob = Trim$(x1312.QtyJob)
            x1312.QtySole = Trim$(x1312.QtySole)
            x1312.QtyCutting = Trim$(x1312.QtyCutting)
            x1312.QtyStitching = Trim$(x1312.QtyStitching)
            x1312.QtyStockfit = Trim$(x1312.QtyStockfit)
            x1312.QtyAssembly = Trim$(x1312.QtyAssembly)
            x1312.QtyPacking = Trim$(x1312.QtyPacking)
            x1312.QtyInbound = Trim$(x1312.QtyInbound)
            x1312.QtyShipping = Trim$(x1312.QtyShipping)
            x1312.TimeInsert = Trim$(x1312.TimeInsert)
            x1312.TimeUpdate = Trim$(x1312.TimeUpdate)
            x1312.DateInsert = Trim$(x1312.DateInsert)
            x1312.InchargeInsert = Trim$(x1312.InchargeInsert)
            x1312.DateUpdate = Trim$(x1312.DateUpdate)
            x1312.InchargeUpdate = Trim$(x1312.InchargeUpdate)
            x1312.InchargeSales = Trim$(x1312.InchargeSales)
            x1312.InchargePPC = Trim$(x1312.InchargePPC)
            x1312.TotalQty = Trim$(x1312.TotalQty)
            x1312.TotalAMT = Trim$(x1312.TotalAMT)
            x1312.TotalCost = Trim$(x1312.TotalCost)
            x1312.TotalProfit = Trim$(x1312.TotalProfit)
            x1312.TotalAMTEX = Trim$(x1312.TotalAMTEX)
            x1312.TotalAMTVND = Trim$(x1312.TotalAMTVND)
            x1312.TotalCostEX = Trim$(x1312.TotalCostEX)
            x1312.TotalCostVND = Trim$(x1312.TotalCostVND)
            x1312.TotalProfitEX = Trim$(x1312.TotalProfitEX)
            x1312.TotalProfitVND = Trim$(x1312.TotalProfitVND)
            x1312.AttachID = Trim$(x1312.AttachID)
            x1312.DateSync = Trim$(x1312.DateSync)
            x1312.CheckSync = Trim$(x1312.CheckSync)
            x1312.PINo = Trim$(x1312.PINo)
            x1312.CheckSizeGroup = Trim$(x1312.CheckSizeGroup)
            x1312.OrderNoRef = Trim$(x1312.OrderNoRef)
            x1312.OrderNoSeqRef = Trim$(x1312.OrderNoSeqRef)
            x1312.Remark = Trim$(x1312.Remark)
            x1312.RemarkOrder = Trim$(x1312.RemarkOrder)
            x1312.RemarkCustomer = Trim$(x1312.RemarkCustomer)
            x1312.RemarkOther = Trim$(x1312.RemarkOther)
            x1312.RemarkTrading = Trim$(x1312.RemarkTrading)
            x1312.seSite = Trim$(x1312.seSite)
            x1312.cdSite = Trim$(x1312.cdSite)
            x1312.LicenseName = Trim$(x1312.LicenseName)
            x1312.TestStandard = Trim$(x1312.TestStandard)
            x1312.TestNo = Trim$(x1312.TestNo)
            x1312.DateReport = Trim$(x1312.DateReport)
            x1312.InvoiceStatus = Trim$(x1312.InvoiceStatus)
            x1312.WIPStatus = Trim$(x1312.WIPStatus)
            x1312.WIPDate = Trim$(x1312.WIPDate)
            x1312.WIPNo = Trim$(x1312.WIPNo)
            x1312.ExportCode = Trim$(x1312.ExportCode)
            x1312.ExportName = Trim$(x1312.ExportName)


            If Trim$(x1312.OrderNo) = "" Then x1312.OrderNo = Space(1)
            If Trim$(x1312.OrderNoSeq) = "" Then x1312.OrderNoSeq = Space(1)
            If Trim$(x1312.PRName) = "" Then x1312.PRName = Space(1)
            If Trim$(x1312.TimeReviseApt) = "" Then x1312.TimeReviseApt = Space(1)
            If Trim$(x1312.TimeRevisePrt) = "" Then x1312.TimeRevisePrt = Space(1)
            If Trim$(x1312.TimeRevise) = "" Then x1312.TimeRevise = Space(1)
            If Trim$(x1312.TimeRnDRevise) = "" Then x1312.TimeRnDRevise = Space(1)
            If Trim$(x1312.TimeSalesRevise) = "" Then x1312.TimeSalesRevise = Space(1)
            If Trim$(x1312.InchargeRevise) = "" Then x1312.InchargeRevise = Space(1)
            If Trim$(x1312.ReviseNo) = "" Then x1312.ReviseNo = 0
            If Trim$(x1312.ShoesCode) = "" Then x1312.ShoesCode = Space(1)
            If Trim$(x1312.ShoesCodeFin) = "" Then x1312.ShoesCodeFin = Space(1)
            If Trim$(x1312.FacPO) = "" Then x1312.FacPO = Space(1)
            If Trim$(x1312.SLNoSys) = "" Then x1312.SLNoSys = Space(1)
            If Trim$(x1312.SLNo) = "" Then x1312.SLNo = Space(1)
            If Trim$(x1312.PONO) = "" Then x1312.PONO = Space(1)
            If Trim$(x1312.CPONO) = "" Then x1312.CPONO = Space(1)
            If Trim$(x1312.CustomerCode) = "" Then x1312.CustomerCode = Space(1)
            If Trim$(x1312.CustomerName) = "" Then x1312.CustomerName = Space(1)
            If Trim$(x1312.Country) = "" Then x1312.Country = Space(1)
            If Trim$(x1312.Destination) = "" Then x1312.Destination = Space(1)
            If Trim$(x1312.FinalShop) = "" Then x1312.FinalShop = Space(1)
            If Trim$(x1312.PKO) = "" Then x1312.PKO = Space(1)
            If Trim$(x1312.DatePO) = "" Then x1312.DatePO = Space(1)
            If Trim$(x1312.JbCard) = "" Then x1312.JbCard = Space(1)
            If Trim$(x1312.sePackingCode) = "" Then x1312.sePackingCode = Space(1)
            If Trim$(x1312.cdPackingCode) = "" Then x1312.cdPackingCode = Space(1)
            If Trim$(x1312.seSpecStatus) = "" Then x1312.seSpecStatus = Space(1)
            If Trim$(x1312.cdSpecStatus) = "" Then x1312.cdSpecStatus = Space(1)
            If Trim$(x1312.SizeRange) = "" Then x1312.SizeRange = Space(1)
            If Trim$(x1312.SpeciticSize) = "" Then x1312.SpeciticSize = Space(1)
            If Trim$(x1312.DateSize) = "" Then x1312.DateSize = Space(1)
            If Trim$(x1312.OrderDetailStatus) = "" Then x1312.OrderDetailStatus = Space(1)
            If Trim$(x1312.DateOrder) = "" Then x1312.DateOrder = Space(1)
            If Trim$(x1312.DateApproval) = "" Then x1312.DateApproval = Space(1)
            If Trim$(x1312.DateCL) = "" Then x1312.DateCL = Space(1)
            If Trim$(x1312.DateCancel) = "" Then x1312.DateCancel = Space(1)
            If Trim$(x1312.RemarkCancel) = "" Then x1312.RemarkCancel = Space(1)
            If Trim$(x1312.DateComplete) = "" Then x1312.DateComplete = Space(1)
            If Trim$(x1312.DatePending) = "" Then x1312.DatePending = Space(1)
            If Trim$(x1312.DatePending2) = "" Then x1312.DatePending2 = Space(1)
            If Trim$(x1312.DateExchangePrice) = "" Then x1312.DateExchangePrice = Space(1)
            If Trim$(x1312.SizeW) = "" Then x1312.SizeW = 0
            If Trim$(x1312.SizeL) = "" Then x1312.SizeL = 0
            If Trim$(x1312.SizeH) = "" Then x1312.SizeH = 0
            If Trim$(x1312.QtyNo1) = "" Then x1312.QtyNo1 = 0
            If Trim$(x1312.QtyNo2) = "" Then x1312.QtyNo2 = 0
            If Trim$(x1312.QtyNo3) = "" Then x1312.QtyNo3 = 0
            If Trim$(x1312.QtyGW) = "" Then x1312.QtyGW = 0
            If Trim$(x1312.QtyNW) = "" Then x1312.QtyNW = 0
            If Trim$(x1312.QtyPcsPoly) = "" Then x1312.QtyPcsPoly = 0
            If Trim$(x1312.QtyPolyCTN) = "" Then x1312.QtyPolyCTN = 0
            If Trim$(x1312.QtyPcsCTN) = "" Then x1312.QtyPcsCTN = 0
            If Trim$(x1312.QtyPcsPINO) = "" Then x1312.QtyPcsPINO = 0
            If Trim$(x1312.PriceExchange) = "" Then x1312.PriceExchange = 0
            If Trim$(x1312.CheckFOB) = "" Then x1312.CheckFOB = Space(1)
            If Trim$(x1312.PriceOrderFOB) = "" Then x1312.PriceOrderFOB = 0
            If Trim$(x1312.TotalAMTFOB) = "" Then x1312.TotalAMTFOB = 0
            If Trim$(x1312.PriceOrder) = "" Then x1312.PriceOrder = 0
            If Trim$(x1312.PriceOrder1) = "" Then x1312.PriceOrder1 = 0
            If Trim$(x1312.PriceOrder2) = "" Then x1312.PriceOrder2 = 0
            If Trim$(x1312.PriceOrder3) = "" Then x1312.PriceOrder3 = 0
            If Trim$(x1312.seUnitPrice) = "" Then x1312.seUnitPrice = Space(1)
            If Trim$(x1312.cdUnitPrice) = "" Then x1312.cdUnitPrice = Space(1)
            If Trim$(x1312.UnitPrice) = "" Then x1312.UnitPrice = Space(1)
            If Trim$(x1312.PriceOrderEX) = "" Then x1312.PriceOrderEX = 0
            If Trim$(x1312.PriceOrderVND) = "" Then x1312.PriceOrderVND = 0
            If Trim$(x1312.Datedelivery) = "" Then x1312.Datedelivery = Space(1)
            If Trim$(x1312.DateTransfer) = "" Then x1312.DateTransfer = Space(1)
            If Trim$(x1312.AcceptedOrder) = "" Then x1312.AcceptedOrder = Space(1)
            If Trim$(x1312.MaterialStatus) = "" Then x1312.MaterialStatus = Space(1)
            If Trim$(x1312.SoleStatus) = "" Then x1312.SoleStatus = Space(1)
            If Trim$(x1312.DateLable) = "" Then x1312.DateLable = Space(1)
            If Trim$(x1312.DatePattern) = "" Then x1312.DatePattern = Space(1)
            If Trim$(x1312.DateMaterial) = "" Then x1312.DateMaterial = Space(1)
            If Trim$(x1312.DatePlanning) = "" Then x1312.DatePlanning = Space(1)
            If Trim$(x1312.DateRnD) = "" Then x1312.DateRnD = Space(1)
            If Trim$(x1312.DateFitting) = "" Then x1312.DateFitting = Space(1)
            If Trim$(x1312.InchargeFitting) = "" Then x1312.InchargeFitting = Space(1)
            If Trim$(x1312.CheckFitting) = "" Then x1312.CheckFitting = Space(1)
            If Trim$(x1312.DateTesting) = "" Then x1312.DateTesting = Space(1)
            If Trim$(x1312.InchargeTesting) = "" Then x1312.InchargeTesting = Space(1)
            If Trim$(x1312.CheckTesting) = "" Then x1312.CheckTesting = Space(1)
            If Trim$(x1312.CheckConfirm) = "" Then x1312.CheckConfirm = Space(1)
            If Trim$(x1312.DateConfirm) = "" Then x1312.DateConfirm = Space(1)
            If Trim$(x1312.InchargeRD1) = "" Then x1312.InchargeRD1 = Space(1)
            If Trim$(x1312.InchargeRD2) = "" Then x1312.InchargeRD2 = Space(1)
            If Trim$(x1312.InchargeRD3) = "" Then x1312.InchargeRD3 = Space(1)
            If Trim$(x1312.InchargeRD4) = "" Then x1312.InchargeRD4 = Space(1)
            If Trim$(x1312.DateSRD1) = "" Then x1312.DateSRD1 = Space(1)
            If Trim$(x1312.DateERD1) = "" Then x1312.DateERD1 = Space(1)
            If Trim$(x1312.DateSRD2) = "" Then x1312.DateSRD2 = Space(1)
            If Trim$(x1312.DateERD2) = "" Then x1312.DateERD2 = Space(1)
            If Trim$(x1312.DateSRD3) = "" Then x1312.DateSRD3 = Space(1)
            If Trim$(x1312.DateERD3) = "" Then x1312.DateERD3 = Space(1)
            If Trim$(x1312.DateSRD4) = "" Then x1312.DateSRD4 = Space(1)
            If Trim$(x1312.DateERD4) = "" Then x1312.DateERD4 = Space(1)
            If Trim$(x1312.SpecNo) = "" Then x1312.SpecNo = Space(1)
            If Trim$(x1312.SpecNoSeq) = "" Then x1312.SpecNoSeq = Space(1)
            If Trim$(x1312.DateSole) = "" Then x1312.DateSole = Space(1)
            If Trim$(x1312.DateCutting) = "" Then x1312.DateCutting = Space(1)
            If Trim$(x1312.DateStitching) = "" Then x1312.DateStitching = Space(1)
            If Trim$(x1312.DateStockfit) = "" Then x1312.DateStockfit = Space(1)
            If Trim$(x1312.DateAssmbly) = "" Then x1312.DateAssmbly = Space(1)
            If Trim$(x1312.DateShipping) = "" Then x1312.DateShipping = Space(1)
            If Trim$(x1312.seUnitMaterial) = "" Then x1312.seUnitMaterial = Space(1)
            If Trim$(x1312.cdUnitMaterial) = "" Then x1312.cdUnitMaterial = Space(1)
            If Trim$(x1312.seUnitPacking) = "" Then x1312.seUnitPacking = Space(1)
            If Trim$(x1312.cdUnitPacking) = "" Then x1312.cdUnitPacking = Space(1)
            If Trim$(x1312.QtyOrderSample) = "" Then x1312.QtyOrderSample = 0
            If Trim$(x1312.QtyOrderSample01) = "" Then x1312.QtyOrderSample01 = 0
            If Trim$(x1312.QtyOrderSample02) = "" Then x1312.QtyOrderSample02 = 0
            If Trim$(x1312.QtyOrder) = "" Then x1312.QtyOrder = 0
            If Trim$(x1312.QtyJob) = "" Then x1312.QtyJob = 0
            If Trim$(x1312.QtySole) = "" Then x1312.QtySole = 0
            If Trim$(x1312.QtyCutting) = "" Then x1312.QtyCutting = 0
            If Trim$(x1312.QtyStitching) = "" Then x1312.QtyStitching = 0
            If Trim$(x1312.QtyStockfit) = "" Then x1312.QtyStockfit = 0
            If Trim$(x1312.QtyAssembly) = "" Then x1312.QtyAssembly = 0
            If Trim$(x1312.QtyPacking) = "" Then x1312.QtyPacking = 0
            If Trim$(x1312.QtyInbound) = "" Then x1312.QtyInbound = 0
            If Trim$(x1312.QtyShipping) = "" Then x1312.QtyShipping = 0
            If Trim$(x1312.TimeInsert) = "" Then x1312.TimeInsert = Space(1)
            If Trim$(x1312.TimeUpdate) = "" Then x1312.TimeUpdate = Space(1)
            If Trim$(x1312.DateInsert) = "" Then x1312.DateInsert = Space(1)
            If Trim$(x1312.InchargeInsert) = "" Then x1312.InchargeInsert = Space(1)
            If Trim$(x1312.DateUpdate) = "" Then x1312.DateUpdate = Space(1)
            If Trim$(x1312.InchargeUpdate) = "" Then x1312.InchargeUpdate = Space(1)
            If Trim$(x1312.InchargeSales) = "" Then x1312.InchargeSales = Space(1)
            If Trim$(x1312.InchargePPC) = "" Then x1312.InchargePPC = Space(1)
            If Trim$(x1312.TotalQty) = "" Then x1312.TotalQty = 0
            If Trim$(x1312.TotalAMT) = "" Then x1312.TotalAMT = 0
            If Trim$(x1312.TotalCost) = "" Then x1312.TotalCost = 0
            If Trim$(x1312.TotalProfit) = "" Then x1312.TotalProfit = 0
            If Trim$(x1312.TotalAMTEX) = "" Then x1312.TotalAMTEX = 0
            If Trim$(x1312.TotalAMTVND) = "" Then x1312.TotalAMTVND = 0
            If Trim$(x1312.TotalCostEX) = "" Then x1312.TotalCostEX = 0
            If Trim$(x1312.TotalCostVND) = "" Then x1312.TotalCostVND = 0
            If Trim$(x1312.TotalProfitEX) = "" Then x1312.TotalProfitEX = 0
            If Trim$(x1312.TotalProfitVND) = "" Then x1312.TotalProfitVND = 0
            If Trim$(x1312.AttachID) = "" Then x1312.AttachID = Space(1)
            If Trim$(x1312.DateSync) = "" Then x1312.DateSync = Space(1)
            If Trim$(x1312.CheckSync) = "" Then x1312.CheckSync = Space(1)
            If Trim$(x1312.PINo) = "" Then x1312.PINo = Space(1)
            If Trim$(x1312.CheckSizeGroup) = "" Then x1312.CheckSizeGroup = Space(1)
            If Trim$(x1312.OrderNoRef) = "" Then x1312.OrderNoRef = Space(1)
            If Trim$(x1312.OrderNoSeqRef) = "" Then x1312.OrderNoSeqRef = Space(1)
            If Trim$(x1312.Remark) = "" Then x1312.Remark = Space(1)
            If Trim$(x1312.RemarkOrder) = "" Then x1312.RemarkOrder = Space(1)
            If Trim$(x1312.RemarkCustomer) = "" Then x1312.RemarkCustomer = Space(1)
            If Trim$(x1312.RemarkOther) = "" Then x1312.RemarkOther = Space(1)
            If Trim$(x1312.RemarkTrading) = "" Then x1312.RemarkTrading = Space(1)
            If Trim$(x1312.seSite) = "" Then x1312.seSite = Space(1)
            If Trim$(x1312.cdSite) = "" Then x1312.cdSite = Space(1)
            If Trim$(x1312.LicenseName) = "" Then x1312.LicenseName = Space(1)
            If Trim$(x1312.TestStandard) = "" Then x1312.TestStandard = Space(1)
            If Trim$(x1312.TestNo) = "" Then x1312.TestNo = Space(1)
            If Trim$(x1312.DateReport) = "" Then x1312.DateReport = Space(1)
            If Trim$(x1312.InvoiceStatus) = "" Then x1312.InvoiceStatus = Space(1)
            If Trim$(x1312.WIPStatus) = "" Then x1312.WIPStatus = Space(1)
            If Trim$(x1312.WIPDate) = "" Then x1312.WIPDate = Space(1)
            If Trim$(x1312.WIPNo) = "" Then x1312.WIPNo = Space(1)
            If Trim$(x1312.ExportCode) = "" Then x1312.ExportCode = Space(1)
            If Trim$(x1312.ExportName) = "" Then x1312.ExportName = Space(1)


        Catch ex As Exception

        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K1312_MOVE(rs1312 As SqlClient.SqlDataReader)
        Try

            Call D1312_CLEAR()

            If IsDBNull(rs1312!K1312_OrderNo) = False Then D1312.OrderNo = Trim$(rs1312!K1312_OrderNo)
            If IsDBNull(rs1312!K1312_OrderNoSeq) = False Then D1312.OrderNoSeq = Trim$(rs1312!K1312_OrderNoSeq)
            If IsDBNull(rs1312!K1312_PRName) = False Then D1312.PRName = Trim$(rs1312!K1312_PRName)
            If IsDBNull(rs1312!K1312_TimeReviseApt) = False Then D1312.TimeReviseApt = Trim$(rs1312!K1312_TimeReviseApt)
            If IsDBNull(rs1312!K1312_TimeRevisePrt) = False Then D1312.TimeRevisePrt = Trim$(rs1312!K1312_TimeRevisePrt)
            If IsDBNull(rs1312!K1312_TimeRevise) = False Then D1312.TimeRevise = Trim$(rs1312!K1312_TimeRevise)
            If IsDBNull(rs1312!K1312_TimeRnDRevise) = False Then D1312.TimeRnDRevise = Trim$(rs1312!K1312_TimeRnDRevise)
            If IsDBNull(rs1312!K1312_TimeSalesRevise) = False Then D1312.TimeSalesRevise = Trim$(rs1312!K1312_TimeSalesRevise)
            If IsDBNull(rs1312!K1312_InchargeRevise) = False Then D1312.InchargeRevise = Trim$(rs1312!K1312_InchargeRevise)
            If IsDBNull(rs1312!K1312_ReviseNo) = False Then D1312.ReviseNo = Trim$(rs1312!K1312_ReviseNo)
            If IsDBNull(rs1312!K1312_ShoesCode) = False Then D1312.ShoesCode = Trim$(rs1312!K1312_ShoesCode)
            If IsDBNull(rs1312!K1312_ShoesCodeFin) = False Then D1312.ShoesCodeFin = Trim$(rs1312!K1312_ShoesCodeFin)
            If IsDBNull(rs1312!K1312_FacPO) = False Then D1312.FacPO = Trim$(rs1312!K1312_FacPO)
            If IsDBNull(rs1312!K1312_SLNoSys) = False Then D1312.SLNoSys = Trim$(rs1312!K1312_SLNoSys)
            If IsDBNull(rs1312!K1312_SLNo) = False Then D1312.SLNo = Trim$(rs1312!K1312_SLNo)
            If IsDBNull(rs1312!K1312_PONO) = False Then D1312.PONO = Trim$(rs1312!K1312_PONO)
            If IsDBNull(rs1312!K1312_CPONO) = False Then D1312.CPONO = Trim$(rs1312!K1312_CPONO)
            If IsDBNull(rs1312!K1312_CustomerCode) = False Then D1312.CustomerCode = Trim$(rs1312!K1312_CustomerCode)
            If IsDBNull(rs1312!K1312_CustomerName) = False Then D1312.CustomerName = Trim$(rs1312!K1312_CustomerName)
            If IsDBNull(rs1312!K1312_Country) = False Then D1312.Country = Trim$(rs1312!K1312_Country)
            If IsDBNull(rs1312!K1312_Destination) = False Then D1312.Destination = Trim$(rs1312!K1312_Destination)
            If IsDBNull(rs1312!K1312_FinalShop) = False Then D1312.FinalShop = Trim$(rs1312!K1312_FinalShop)
            If IsDBNull(rs1312!K1312_PKO) = False Then D1312.PKO = Trim$(rs1312!K1312_PKO)
            If IsDBNull(rs1312!K1312_DatePO) = False Then D1312.DatePO = Trim$(rs1312!K1312_DatePO)
            If IsDBNull(rs1312!K1312_JbCard) = False Then D1312.JbCard = Trim$(rs1312!K1312_JbCard)
            If IsDBNull(rs1312!K1312_sePackingCode) = False Then D1312.sePackingCode = Trim$(rs1312!K1312_sePackingCode)
            If IsDBNull(rs1312!K1312_cdPackingCode) = False Then D1312.cdPackingCode = Trim$(rs1312!K1312_cdPackingCode)
            If IsDBNull(rs1312!K1312_seSpecStatus) = False Then D1312.seSpecStatus = Trim$(rs1312!K1312_seSpecStatus)
            If IsDBNull(rs1312!K1312_cdSpecStatus) = False Then D1312.cdSpecStatus = Trim$(rs1312!K1312_cdSpecStatus)
            If IsDBNull(rs1312!K1312_SizeRange) = False Then D1312.SizeRange = Trim$(rs1312!K1312_SizeRange)
            If IsDBNull(rs1312!K1312_SpeciticSize) = False Then D1312.SpeciticSize = Trim$(rs1312!K1312_SpeciticSize)
            If IsDBNull(rs1312!K1312_DateSize) = False Then D1312.DateSize = Trim$(rs1312!K1312_DateSize)
            If IsDBNull(rs1312!K1312_OrderDetailStatus) = False Then D1312.OrderDetailStatus = Trim$(rs1312!K1312_OrderDetailStatus)
            If IsDBNull(rs1312!K1312_DateOrder) = False Then D1312.DateOrder = Trim$(rs1312!K1312_DateOrder)
            If IsDBNull(rs1312!K1312_DateApproval) = False Then D1312.DateApproval = Trim$(rs1312!K1312_DateApproval)
            If IsDBNull(rs1312!K1312_DateCL) = False Then D1312.DateCL = Trim$(rs1312!K1312_DateCL)
            If IsDBNull(rs1312!K1312_DateCancel) = False Then D1312.DateCancel = Trim$(rs1312!K1312_DateCancel)
            If IsDBNull(rs1312!K1312_RemarkCancel) = False Then D1312.RemarkCancel = Trim$(rs1312!K1312_RemarkCancel)
            If IsDBNull(rs1312!K1312_DateComplete) = False Then D1312.DateComplete = Trim$(rs1312!K1312_DateComplete)
            If IsDBNull(rs1312!K1312_DatePending) = False Then D1312.DatePending = Trim$(rs1312!K1312_DatePending)
            If IsDBNull(rs1312!K1312_DatePending2) = False Then D1312.DatePending2 = Trim$(rs1312!K1312_DatePending2)
            If IsDBNull(rs1312!K1312_DateExchangePrice) = False Then D1312.DateExchangePrice = Trim$(rs1312!K1312_DateExchangePrice)
            If IsDBNull(rs1312!K1312_SizeW) = False Then D1312.SizeW = Trim$(rs1312!K1312_SizeW)
            If IsDBNull(rs1312!K1312_SizeL) = False Then D1312.SizeL = Trim$(rs1312!K1312_SizeL)
            If IsDBNull(rs1312!K1312_SizeH) = False Then D1312.SizeH = Trim$(rs1312!K1312_SizeH)
            If IsDBNull(rs1312!K1312_QtyNo1) = False Then D1312.QtyNo1 = Trim$(rs1312!K1312_QtyNo1)
            If IsDBNull(rs1312!K1312_QtyNo2) = False Then D1312.QtyNo2 = Trim$(rs1312!K1312_QtyNo2)
            If IsDBNull(rs1312!K1312_QtyNo3) = False Then D1312.QtyNo3 = Trim$(rs1312!K1312_QtyNo3)
            If IsDBNull(rs1312!K1312_QtyGW) = False Then D1312.QtyGW = Trim$(rs1312!K1312_QtyGW)
            If IsDBNull(rs1312!K1312_QtyNW) = False Then D1312.QtyNW = Trim$(rs1312!K1312_QtyNW)
            If IsDBNull(rs1312!K1312_QtyPcsPoly) = False Then D1312.QtyPcsPoly = Trim$(rs1312!K1312_QtyPcsPoly)
            If IsDBNull(rs1312!K1312_QtyPolyCTN) = False Then D1312.QtyPolyCTN = Trim$(rs1312!K1312_QtyPolyCTN)
            If IsDBNull(rs1312!K1312_QtyPcsCTN) = False Then D1312.QtyPcsCTN = Trim$(rs1312!K1312_QtyPcsCTN)
            If IsDBNull(rs1312!K1312_QtyPcsPINO) = False Then D1312.QtyPcsPINO = Trim$(rs1312!K1312_QtyPcsPINO)
            If IsDBNull(rs1312!K1312_PriceExchange) = False Then D1312.PriceExchange = Trim$(rs1312!K1312_PriceExchange)
            If IsDBNull(rs1312!K1312_CheckFOB) = False Then D1312.CheckFOB = Trim$(rs1312!K1312_CheckFOB)
            If IsDBNull(rs1312!K1312_PriceOrderFOB) = False Then D1312.PriceOrderFOB = Trim$(rs1312!K1312_PriceOrderFOB)
            If IsDBNull(rs1312!K1312_TotalAMTFOB) = False Then D1312.TotalAMTFOB = Trim$(rs1312!K1312_TotalAMTFOB)
            If IsDBNull(rs1312!K1312_PriceOrder) = False Then D1312.PriceOrder = Trim$(rs1312!K1312_PriceOrder)
            If IsDBNull(rs1312!K1312_PriceOrder1) = False Then D1312.PriceOrder1 = Trim$(rs1312!K1312_PriceOrder1)
            If IsDBNull(rs1312!K1312_PriceOrder2) = False Then D1312.PriceOrder2 = Trim$(rs1312!K1312_PriceOrder2)
            If IsDBNull(rs1312!K1312_PriceOrder3) = False Then D1312.PriceOrder3 = Trim$(rs1312!K1312_PriceOrder3)
            If IsDBNull(rs1312!K1312_seUnitPrice) = False Then D1312.seUnitPrice = Trim$(rs1312!K1312_seUnitPrice)
            If IsDBNull(rs1312!K1312_cdUnitPrice) = False Then D1312.cdUnitPrice = Trim$(rs1312!K1312_cdUnitPrice)
            If IsDBNull(rs1312!K1312_UnitPrice) = False Then D1312.UnitPrice = Trim$(rs1312!K1312_UnitPrice)
            If IsDBNull(rs1312!K1312_PriceOrderEX) = False Then D1312.PriceOrderEX = Trim$(rs1312!K1312_PriceOrderEX)
            If IsDBNull(rs1312!K1312_PriceOrderVND) = False Then D1312.PriceOrderVND = Trim$(rs1312!K1312_PriceOrderVND)
            If IsDBNull(rs1312!K1312_Datedelivery) = False Then D1312.Datedelivery = Trim$(rs1312!K1312_Datedelivery)
            If IsDBNull(rs1312!K1312_DateTransfer) = False Then D1312.DateTransfer = Trim$(rs1312!K1312_DateTransfer)
            If IsDBNull(rs1312!K1312_AcceptedOrder) = False Then D1312.AcceptedOrder = Trim$(rs1312!K1312_AcceptedOrder)
            If IsDBNull(rs1312!K1312_MaterialStatus) = False Then D1312.MaterialStatus = Trim$(rs1312!K1312_MaterialStatus)
            If IsDBNull(rs1312!K1312_SoleStatus) = False Then D1312.SoleStatus = Trim$(rs1312!K1312_SoleStatus)
            If IsDBNull(rs1312!K1312_DateLable) = False Then D1312.DateLable = Trim$(rs1312!K1312_DateLable)
            If IsDBNull(rs1312!K1312_DatePattern) = False Then D1312.DatePattern = Trim$(rs1312!K1312_DatePattern)
            If IsDBNull(rs1312!K1312_DateMaterial) = False Then D1312.DateMaterial = Trim$(rs1312!K1312_DateMaterial)
            If IsDBNull(rs1312!K1312_DatePlanning) = False Then D1312.DatePlanning = Trim$(rs1312!K1312_DatePlanning)
            If IsDBNull(rs1312!K1312_DateRnD) = False Then D1312.DateRnD = Trim$(rs1312!K1312_DateRnD)
            If IsDBNull(rs1312!K1312_DateFitting) = False Then D1312.DateFitting = Trim$(rs1312!K1312_DateFitting)
            If IsDBNull(rs1312!K1312_InchargeFitting) = False Then D1312.InchargeFitting = Trim$(rs1312!K1312_InchargeFitting)
            If IsDBNull(rs1312!K1312_CheckFitting) = False Then D1312.CheckFitting = Trim$(rs1312!K1312_CheckFitting)
            If IsDBNull(rs1312!K1312_DateTesting) = False Then D1312.DateTesting = Trim$(rs1312!K1312_DateTesting)
            If IsDBNull(rs1312!K1312_InchargeTesting) = False Then D1312.InchargeTesting = Trim$(rs1312!K1312_InchargeTesting)
            If IsDBNull(rs1312!K1312_CheckTesting) = False Then D1312.CheckTesting = Trim$(rs1312!K1312_CheckTesting)
            If IsDBNull(rs1312!K1312_CheckConfirm) = False Then D1312.CheckConfirm = Trim$(rs1312!K1312_CheckConfirm)
            If IsDBNull(rs1312!K1312_DateConfirm) = False Then D1312.DateConfirm = Trim$(rs1312!K1312_DateConfirm)
            If IsDBNull(rs1312!K1312_InchargeRD1) = False Then D1312.InchargeRD1 = Trim$(rs1312!K1312_InchargeRD1)
            If IsDBNull(rs1312!K1312_InchargeRD2) = False Then D1312.InchargeRD2 = Trim$(rs1312!K1312_InchargeRD2)
            If IsDBNull(rs1312!K1312_InchargeRD3) = False Then D1312.InchargeRD3 = Trim$(rs1312!K1312_InchargeRD3)
            If IsDBNull(rs1312!K1312_InchargeRD4) = False Then D1312.InchargeRD4 = Trim$(rs1312!K1312_InchargeRD4)
            If IsDBNull(rs1312!K1312_DateSRD1) = False Then D1312.DateSRD1 = Trim$(rs1312!K1312_DateSRD1)
            If IsDBNull(rs1312!K1312_DateERD1) = False Then D1312.DateERD1 = Trim$(rs1312!K1312_DateERD1)
            If IsDBNull(rs1312!K1312_DateSRD2) = False Then D1312.DateSRD2 = Trim$(rs1312!K1312_DateSRD2)
            If IsDBNull(rs1312!K1312_DateERD2) = False Then D1312.DateERD2 = Trim$(rs1312!K1312_DateERD2)
            If IsDBNull(rs1312!K1312_DateSRD3) = False Then D1312.DateSRD3 = Trim$(rs1312!K1312_DateSRD3)
            If IsDBNull(rs1312!K1312_DateERD3) = False Then D1312.DateERD3 = Trim$(rs1312!K1312_DateERD3)
            If IsDBNull(rs1312!K1312_DateSRD4) = False Then D1312.DateSRD4 = Trim$(rs1312!K1312_DateSRD4)
            If IsDBNull(rs1312!K1312_DateERD4) = False Then D1312.DateERD4 = Trim$(rs1312!K1312_DateERD4)
            If IsDBNull(rs1312!K1312_SpecNo) = False Then D1312.SpecNo = Trim$(rs1312!K1312_SpecNo)
            If IsDBNull(rs1312!K1312_SpecNoSeq) = False Then D1312.SpecNoSeq = Trim$(rs1312!K1312_SpecNoSeq)
            If IsDBNull(rs1312!K1312_DateSole) = False Then D1312.DateSole = Trim$(rs1312!K1312_DateSole)
            If IsDBNull(rs1312!K1312_DateCutting) = False Then D1312.DateCutting = Trim$(rs1312!K1312_DateCutting)
            If IsDBNull(rs1312!K1312_DateStitching) = False Then D1312.DateStitching = Trim$(rs1312!K1312_DateStitching)
            If IsDBNull(rs1312!K1312_DateStockfit) = False Then D1312.DateStockfit = Trim$(rs1312!K1312_DateStockfit)
            If IsDBNull(rs1312!K1312_DateAssmbly) = False Then D1312.DateAssmbly = Trim$(rs1312!K1312_DateAssmbly)
            If IsDBNull(rs1312!K1312_DateShipping) = False Then D1312.DateShipping = Trim$(rs1312!K1312_DateShipping)
            If IsDBNull(rs1312!K1312_seUnitMaterial) = False Then D1312.seUnitMaterial = Trim$(rs1312!K1312_seUnitMaterial)
            If IsDBNull(rs1312!K1312_cdUnitMaterial) = False Then D1312.cdUnitMaterial = Trim$(rs1312!K1312_cdUnitMaterial)
            If IsDBNull(rs1312!K1312_seUnitPacking) = False Then D1312.seUnitPacking = Trim$(rs1312!K1312_seUnitPacking)
            If IsDBNull(rs1312!K1312_cdUnitPacking) = False Then D1312.cdUnitPacking = Trim$(rs1312!K1312_cdUnitPacking)
            If IsDBNull(rs1312!K1312_QtyOrderSample) = False Then D1312.QtyOrderSample = Trim$(rs1312!K1312_QtyOrderSample)
            If IsDBNull(rs1312!K1312_QtyOrderSample01) = False Then D1312.QtyOrderSample01 = Trim$(rs1312!K1312_QtyOrderSample01)
            If IsDBNull(rs1312!K1312_QtyOrderSample02) = False Then D1312.QtyOrderSample02 = Trim$(rs1312!K1312_QtyOrderSample02)
            If IsDBNull(rs1312!K1312_QtyOrder) = False Then D1312.QtyOrder = Trim$(rs1312!K1312_QtyOrder)
            If IsDBNull(rs1312!K1312_QtyJob) = False Then D1312.QtyJob = Trim$(rs1312!K1312_QtyJob)
            If IsDBNull(rs1312!K1312_QtySole) = False Then D1312.QtySole = Trim$(rs1312!K1312_QtySole)
            If IsDBNull(rs1312!K1312_QtyCutting) = False Then D1312.QtyCutting = Trim$(rs1312!K1312_QtyCutting)
            If IsDBNull(rs1312!K1312_QtyStitching) = False Then D1312.QtyStitching = Trim$(rs1312!K1312_QtyStitching)
            If IsDBNull(rs1312!K1312_QtyStockfit) = False Then D1312.QtyStockfit = Trim$(rs1312!K1312_QtyStockfit)
            If IsDBNull(rs1312!K1312_QtyAssembly) = False Then D1312.QtyAssembly = Trim$(rs1312!K1312_QtyAssembly)
            If IsDBNull(rs1312!K1312_QtyPacking) = False Then D1312.QtyPacking = Trim$(rs1312!K1312_QtyPacking)
            If IsDBNull(rs1312!K1312_QtyInbound) = False Then D1312.QtyInbound = Trim$(rs1312!K1312_QtyInbound)
            If IsDBNull(rs1312!K1312_QtyShipping) = False Then D1312.QtyShipping = Trim$(rs1312!K1312_QtyShipping)
            If IsDBNull(rs1312!K1312_TimeInsert) = False Then D1312.TimeInsert = Trim$(rs1312!K1312_TimeInsert)
            If IsDBNull(rs1312!K1312_TimeUpdate) = False Then D1312.TimeUpdate = Trim$(rs1312!K1312_TimeUpdate)
            If IsDBNull(rs1312!K1312_DateInsert) = False Then D1312.DateInsert = Trim$(rs1312!K1312_DateInsert)
            If IsDBNull(rs1312!K1312_InchargeInsert) = False Then D1312.InchargeInsert = Trim$(rs1312!K1312_InchargeInsert)
            If IsDBNull(rs1312!K1312_DateUpdate) = False Then D1312.DateUpdate = Trim$(rs1312!K1312_DateUpdate)
            If IsDBNull(rs1312!K1312_InchargeUpdate) = False Then D1312.InchargeUpdate = Trim$(rs1312!K1312_InchargeUpdate)
            If IsDBNull(rs1312!K1312_InchargeSales) = False Then D1312.InchargeSales = Trim$(rs1312!K1312_InchargeSales)
            If IsDBNull(rs1312!K1312_InchargePPC) = False Then D1312.InchargePPC = Trim$(rs1312!K1312_InchargePPC)
            If IsDBNull(rs1312!K1312_TotalQty) = False Then D1312.TotalQty = Trim$(rs1312!K1312_TotalQty)
            If IsDBNull(rs1312!K1312_TotalAMT) = False Then D1312.TotalAMT = Trim$(rs1312!K1312_TotalAMT)
            If IsDBNull(rs1312!K1312_TotalCost) = False Then D1312.TotalCost = Trim$(rs1312!K1312_TotalCost)
            If IsDBNull(rs1312!K1312_TotalProfit) = False Then D1312.TotalProfit = Trim$(rs1312!K1312_TotalProfit)
            If IsDBNull(rs1312!K1312_TotalAMTEX) = False Then D1312.TotalAMTEX = Trim$(rs1312!K1312_TotalAMTEX)
            If IsDBNull(rs1312!K1312_TotalAMTVND) = False Then D1312.TotalAMTVND = Trim$(rs1312!K1312_TotalAMTVND)
            If IsDBNull(rs1312!K1312_TotalCostEX) = False Then D1312.TotalCostEX = Trim$(rs1312!K1312_TotalCostEX)
            If IsDBNull(rs1312!K1312_TotalCostVND) = False Then D1312.TotalCostVND = Trim$(rs1312!K1312_TotalCostVND)
            If IsDBNull(rs1312!K1312_TotalProfitEX) = False Then D1312.TotalProfitEX = Trim$(rs1312!K1312_TotalProfitEX)
            If IsDBNull(rs1312!K1312_TotalProfitVND) = False Then D1312.TotalProfitVND = Trim$(rs1312!K1312_TotalProfitVND)
            If IsDBNull(rs1312!K1312_AttachID) = False Then D1312.AttachID = Trim$(rs1312!K1312_AttachID)
            If IsDBNull(rs1312!K1312_DateSync) = False Then D1312.DateSync = Trim$(rs1312!K1312_DateSync)
            If IsDBNull(rs1312!K1312_CheckSync) = False Then D1312.CheckSync = Trim$(rs1312!K1312_CheckSync)
            If IsDBNull(rs1312!K1312_PINo) = False Then D1312.PINo = Trim$(rs1312!K1312_PINo)
            If IsDBNull(rs1312!K1312_CheckSizeGroup) = False Then D1312.CheckSizeGroup = Trim$(rs1312!K1312_CheckSizeGroup)
            If IsDBNull(rs1312!K1312_OrderNoRef) = False Then D1312.OrderNoRef = Trim$(rs1312!K1312_OrderNoRef)
            If IsDBNull(rs1312!K1312_OrderNoSeqRef) = False Then D1312.OrderNoSeqRef = Trim$(rs1312!K1312_OrderNoSeqRef)
            If IsDBNull(rs1312!K1312_Remark) = False Then D1312.Remark = Trim$(rs1312!K1312_Remark)
            If IsDBNull(rs1312!K1312_RemarkOrder) = False Then D1312.RemarkOrder = Trim$(rs1312!K1312_RemarkOrder)
            If IsDBNull(rs1312!K1312_RemarkCustomer) = False Then D1312.RemarkCustomer = Trim$(rs1312!K1312_RemarkCustomer)
            If IsDBNull(rs1312!K1312_RemarkOther) = False Then D1312.RemarkOther = Trim$(rs1312!K1312_RemarkOther)
            If IsDBNull(rs1312!K1312_RemarkTrading) = False Then D1312.RemarkTrading = Trim$(rs1312!K1312_RemarkTrading)
            If IsDBNull(rs1312!K1312_seSite) = False Then D1312.seSite = Trim$(rs1312!K1312_seSite)
            If IsDBNull(rs1312!K1312_cdSite) = False Then D1312.cdSite = Trim$(rs1312!K1312_cdSite)
            If IsDBNull(rs1312!K1312_LicenseName) = False Then D1312.LicenseName = Trim$(rs1312!K1312_LicenseName)
            If IsDBNull(rs1312!K1312_TestStandard) = False Then D1312.TestStandard = Trim$(rs1312!K1312_TestStandard)
            If IsDBNull(rs1312!K1312_TestNo) = False Then D1312.TestNo = Trim$(rs1312!K1312_TestNo)
            If IsDBNull(rs1312!K1312_DateReport) = False Then D1312.DateReport = Trim$(rs1312!K1312_DateReport)
            If IsDBNull(rs1312!K1312_InvoiceStatus) = False Then D1312.InvoiceStatus = Trim$(rs1312!K1312_InvoiceStatus)
            If IsDBNull(rs1312!K1312_WIPStatus) = False Then D1312.WIPStatus = Trim$(rs1312!K1312_WIPStatus)
            If IsDBNull(rs1312!K1312_WIPDate) = False Then D1312.WIPDate = Trim$(rs1312!K1312_WIPDate)
            If IsDBNull(rs1312!K1312_WIPNo) = False Then D1312.WIPNo = Trim$(rs1312!K1312_WIPNo)
            If IsDBNull(rs1312!K1312_ExportCode) = False Then D1312.ExportCode = Trim$(rs1312!K1312_ExportCode)
            If IsDBNull(rs1312!K1312_ExportName) = False Then D1312.ExportName = Trim$(rs1312!K1312_ExportName)


        Catch ex As Exception

        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K1312_MOVE(rs1312 As DataRow)
        Try

            Call D1312_CLEAR()

            If IsDBNull(rs1312!K1312_OrderNo) = False Then D1312.OrderNo = Trim$(rs1312!K1312_OrderNo)
            If IsDBNull(rs1312!K1312_OrderNoSeq) = False Then D1312.OrderNoSeq = Trim$(rs1312!K1312_OrderNoSeq)
            If IsDBNull(rs1312!K1312_PRName) = False Then D1312.PRName = Trim$(rs1312!K1312_PRName)
            If IsDBNull(rs1312!K1312_TimeReviseApt) = False Then D1312.TimeReviseApt = Trim$(rs1312!K1312_TimeReviseApt)
            If IsDBNull(rs1312!K1312_TimeRevisePrt) = False Then D1312.TimeRevisePrt = Trim$(rs1312!K1312_TimeRevisePrt)
            If IsDBNull(rs1312!K1312_TimeRevise) = False Then D1312.TimeRevise = Trim$(rs1312!K1312_TimeRevise)
            If IsDBNull(rs1312!K1312_TimeRnDRevise) = False Then D1312.TimeRnDRevise = Trim$(rs1312!K1312_TimeRnDRevise)
            If IsDBNull(rs1312!K1312_TimeSalesRevise) = False Then D1312.TimeSalesRevise = Trim$(rs1312!K1312_TimeSalesRevise)
            If IsDBNull(rs1312!K1312_InchargeRevise) = False Then D1312.InchargeRevise = Trim$(rs1312!K1312_InchargeRevise)
            If IsDBNull(rs1312!K1312_ReviseNo) = False Then D1312.ReviseNo = Trim$(rs1312!K1312_ReviseNo)
            If IsDBNull(rs1312!K1312_ShoesCode) = False Then D1312.ShoesCode = Trim$(rs1312!K1312_ShoesCode)
            If IsDBNull(rs1312!K1312_ShoesCodeFin) = False Then D1312.ShoesCodeFin = Trim$(rs1312!K1312_ShoesCodeFin)
            If IsDBNull(rs1312!K1312_FacPO) = False Then D1312.FacPO = Trim$(rs1312!K1312_FacPO)
            If IsDBNull(rs1312!K1312_SLNoSys) = False Then D1312.SLNoSys = Trim$(rs1312!K1312_SLNoSys)
            If IsDBNull(rs1312!K1312_SLNo) = False Then D1312.SLNo = Trim$(rs1312!K1312_SLNo)
            If IsDBNull(rs1312!K1312_PONO) = False Then D1312.PONO = Trim$(rs1312!K1312_PONO)
            If IsDBNull(rs1312!K1312_CPONO) = False Then D1312.CPONO = Trim$(rs1312!K1312_CPONO)
            If IsDBNull(rs1312!K1312_CustomerCode) = False Then D1312.CustomerCode = Trim$(rs1312!K1312_CustomerCode)
            If IsDBNull(rs1312!K1312_CustomerName) = False Then D1312.CustomerName = Trim$(rs1312!K1312_CustomerName)
            If IsDBNull(rs1312!K1312_Country) = False Then D1312.Country = Trim$(rs1312!K1312_Country)
            If IsDBNull(rs1312!K1312_Destination) = False Then D1312.Destination = Trim$(rs1312!K1312_Destination)
            If IsDBNull(rs1312!K1312_FinalShop) = False Then D1312.FinalShop = Trim$(rs1312!K1312_FinalShop)
            If IsDBNull(rs1312!K1312_PKO) = False Then D1312.PKO = Trim$(rs1312!K1312_PKO)
            If IsDBNull(rs1312!K1312_DatePO) = False Then D1312.DatePO = Trim$(rs1312!K1312_DatePO)
            If IsDBNull(rs1312!K1312_JbCard) = False Then D1312.JbCard = Trim$(rs1312!K1312_JbCard)
            If IsDBNull(rs1312!K1312_sePackingCode) = False Then D1312.sePackingCode = Trim$(rs1312!K1312_sePackingCode)
            If IsDBNull(rs1312!K1312_cdPackingCode) = False Then D1312.cdPackingCode = Trim$(rs1312!K1312_cdPackingCode)
            If IsDBNull(rs1312!K1312_seSpecStatus) = False Then D1312.seSpecStatus = Trim$(rs1312!K1312_seSpecStatus)
            If IsDBNull(rs1312!K1312_cdSpecStatus) = False Then D1312.cdSpecStatus = Trim$(rs1312!K1312_cdSpecStatus)
            If IsDBNull(rs1312!K1312_SizeRange) = False Then D1312.SizeRange = Trim$(rs1312!K1312_SizeRange)
            If IsDBNull(rs1312!K1312_SpeciticSize) = False Then D1312.SpeciticSize = Trim$(rs1312!K1312_SpeciticSize)
            If IsDBNull(rs1312!K1312_DateSize) = False Then D1312.DateSize = Trim$(rs1312!K1312_DateSize)
            If IsDBNull(rs1312!K1312_OrderDetailStatus) = False Then D1312.OrderDetailStatus = Trim$(rs1312!K1312_OrderDetailStatus)
            If IsDBNull(rs1312!K1312_DateOrder) = False Then D1312.DateOrder = Trim$(rs1312!K1312_DateOrder)
            If IsDBNull(rs1312!K1312_DateApproval) = False Then D1312.DateApproval = Trim$(rs1312!K1312_DateApproval)
            If IsDBNull(rs1312!K1312_DateCL) = False Then D1312.DateCL = Trim$(rs1312!K1312_DateCL)
            If IsDBNull(rs1312!K1312_DateCancel) = False Then D1312.DateCancel = Trim$(rs1312!K1312_DateCancel)
            If IsDBNull(rs1312!K1312_RemarkCancel) = False Then D1312.RemarkCancel = Trim$(rs1312!K1312_RemarkCancel)
            If IsDBNull(rs1312!K1312_DateComplete) = False Then D1312.DateComplete = Trim$(rs1312!K1312_DateComplete)
            If IsDBNull(rs1312!K1312_DatePending) = False Then D1312.DatePending = Trim$(rs1312!K1312_DatePending)
            If IsDBNull(rs1312!K1312_DatePending2) = False Then D1312.DatePending2 = Trim$(rs1312!K1312_DatePending2)
            If IsDBNull(rs1312!K1312_DateExchangePrice) = False Then D1312.DateExchangePrice = Trim$(rs1312!K1312_DateExchangePrice)
            If IsDBNull(rs1312!K1312_SizeW) = False Then D1312.SizeW = Trim$(rs1312!K1312_SizeW)
            If IsDBNull(rs1312!K1312_SizeL) = False Then D1312.SizeL = Trim$(rs1312!K1312_SizeL)
            If IsDBNull(rs1312!K1312_SizeH) = False Then D1312.SizeH = Trim$(rs1312!K1312_SizeH)
            If IsDBNull(rs1312!K1312_QtyNo1) = False Then D1312.QtyNo1 = Trim$(rs1312!K1312_QtyNo1)
            If IsDBNull(rs1312!K1312_QtyNo2) = False Then D1312.QtyNo2 = Trim$(rs1312!K1312_QtyNo2)
            If IsDBNull(rs1312!K1312_QtyNo3) = False Then D1312.QtyNo3 = Trim$(rs1312!K1312_QtyNo3)
            If IsDBNull(rs1312!K1312_QtyGW) = False Then D1312.QtyGW = Trim$(rs1312!K1312_QtyGW)
            If IsDBNull(rs1312!K1312_QtyNW) = False Then D1312.QtyNW = Trim$(rs1312!K1312_QtyNW)
            If IsDBNull(rs1312!K1312_QtyPcsPoly) = False Then D1312.QtyPcsPoly = Trim$(rs1312!K1312_QtyPcsPoly)
            If IsDBNull(rs1312!K1312_QtyPolyCTN) = False Then D1312.QtyPolyCTN = Trim$(rs1312!K1312_QtyPolyCTN)
            If IsDBNull(rs1312!K1312_QtyPcsCTN) = False Then D1312.QtyPcsCTN = Trim$(rs1312!K1312_QtyPcsCTN)
            If IsDBNull(rs1312!K1312_QtyPcsPINO) = False Then D1312.QtyPcsPINO = Trim$(rs1312!K1312_QtyPcsPINO)
            If IsDBNull(rs1312!K1312_PriceExchange) = False Then D1312.PriceExchange = Trim$(rs1312!K1312_PriceExchange)
            If IsDBNull(rs1312!K1312_CheckFOB) = False Then D1312.CheckFOB = Trim$(rs1312!K1312_CheckFOB)
            If IsDBNull(rs1312!K1312_PriceOrderFOB) = False Then D1312.PriceOrderFOB = Trim$(rs1312!K1312_PriceOrderFOB)
            If IsDBNull(rs1312!K1312_TotalAMTFOB) = False Then D1312.TotalAMTFOB = Trim$(rs1312!K1312_TotalAMTFOB)
            If IsDBNull(rs1312!K1312_PriceOrder) = False Then D1312.PriceOrder = Trim$(rs1312!K1312_PriceOrder)
            If IsDBNull(rs1312!K1312_PriceOrder1) = False Then D1312.PriceOrder1 = Trim$(rs1312!K1312_PriceOrder1)
            If IsDBNull(rs1312!K1312_PriceOrder2) = False Then D1312.PriceOrder2 = Trim$(rs1312!K1312_PriceOrder2)
            If IsDBNull(rs1312!K1312_PriceOrder3) = False Then D1312.PriceOrder3 = Trim$(rs1312!K1312_PriceOrder3)
            If IsDBNull(rs1312!K1312_seUnitPrice) = False Then D1312.seUnitPrice = Trim$(rs1312!K1312_seUnitPrice)
            If IsDBNull(rs1312!K1312_cdUnitPrice) = False Then D1312.cdUnitPrice = Trim$(rs1312!K1312_cdUnitPrice)
            If IsDBNull(rs1312!K1312_UnitPrice) = False Then D1312.UnitPrice = Trim$(rs1312!K1312_UnitPrice)
            If IsDBNull(rs1312!K1312_PriceOrderEX) = False Then D1312.PriceOrderEX = Trim$(rs1312!K1312_PriceOrderEX)
            If IsDBNull(rs1312!K1312_PriceOrderVND) = False Then D1312.PriceOrderVND = Trim$(rs1312!K1312_PriceOrderVND)
            If IsDBNull(rs1312!K1312_Datedelivery) = False Then D1312.Datedelivery = Trim$(rs1312!K1312_Datedelivery)
            If IsDBNull(rs1312!K1312_DateTransfer) = False Then D1312.DateTransfer = Trim$(rs1312!K1312_DateTransfer)
            If IsDBNull(rs1312!K1312_AcceptedOrder) = False Then D1312.AcceptedOrder = Trim$(rs1312!K1312_AcceptedOrder)
            If IsDBNull(rs1312!K1312_MaterialStatus) = False Then D1312.MaterialStatus = Trim$(rs1312!K1312_MaterialStatus)
            If IsDBNull(rs1312!K1312_SoleStatus) = False Then D1312.SoleStatus = Trim$(rs1312!K1312_SoleStatus)
            If IsDBNull(rs1312!K1312_DateLable) = False Then D1312.DateLable = Trim$(rs1312!K1312_DateLable)
            If IsDBNull(rs1312!K1312_DatePattern) = False Then D1312.DatePattern = Trim$(rs1312!K1312_DatePattern)
            If IsDBNull(rs1312!K1312_DateMaterial) = False Then D1312.DateMaterial = Trim$(rs1312!K1312_DateMaterial)
            If IsDBNull(rs1312!K1312_DatePlanning) = False Then D1312.DatePlanning = Trim$(rs1312!K1312_DatePlanning)
            If IsDBNull(rs1312!K1312_DateRnD) = False Then D1312.DateRnD = Trim$(rs1312!K1312_DateRnD)
            If IsDBNull(rs1312!K1312_DateFitting) = False Then D1312.DateFitting = Trim$(rs1312!K1312_DateFitting)
            If IsDBNull(rs1312!K1312_InchargeFitting) = False Then D1312.InchargeFitting = Trim$(rs1312!K1312_InchargeFitting)
            If IsDBNull(rs1312!K1312_CheckFitting) = False Then D1312.CheckFitting = Trim$(rs1312!K1312_CheckFitting)
            If IsDBNull(rs1312!K1312_DateTesting) = False Then D1312.DateTesting = Trim$(rs1312!K1312_DateTesting)
            If IsDBNull(rs1312!K1312_InchargeTesting) = False Then D1312.InchargeTesting = Trim$(rs1312!K1312_InchargeTesting)
            If IsDBNull(rs1312!K1312_CheckTesting) = False Then D1312.CheckTesting = Trim$(rs1312!K1312_CheckTesting)
            If IsDBNull(rs1312!K1312_CheckConfirm) = False Then D1312.CheckConfirm = Trim$(rs1312!K1312_CheckConfirm)
            If IsDBNull(rs1312!K1312_DateConfirm) = False Then D1312.DateConfirm = Trim$(rs1312!K1312_DateConfirm)
            If IsDBNull(rs1312!K1312_InchargeRD1) = False Then D1312.InchargeRD1 = Trim$(rs1312!K1312_InchargeRD1)
            If IsDBNull(rs1312!K1312_InchargeRD2) = False Then D1312.InchargeRD2 = Trim$(rs1312!K1312_InchargeRD2)
            If IsDBNull(rs1312!K1312_InchargeRD3) = False Then D1312.InchargeRD3 = Trim$(rs1312!K1312_InchargeRD3)
            If IsDBNull(rs1312!K1312_InchargeRD4) = False Then D1312.InchargeRD4 = Trim$(rs1312!K1312_InchargeRD4)
            If IsDBNull(rs1312!K1312_DateSRD1) = False Then D1312.DateSRD1 = Trim$(rs1312!K1312_DateSRD1)
            If IsDBNull(rs1312!K1312_DateERD1) = False Then D1312.DateERD1 = Trim$(rs1312!K1312_DateERD1)
            If IsDBNull(rs1312!K1312_DateSRD2) = False Then D1312.DateSRD2 = Trim$(rs1312!K1312_DateSRD2)
            If IsDBNull(rs1312!K1312_DateERD2) = False Then D1312.DateERD2 = Trim$(rs1312!K1312_DateERD2)
            If IsDBNull(rs1312!K1312_DateSRD3) = False Then D1312.DateSRD3 = Trim$(rs1312!K1312_DateSRD3)
            If IsDBNull(rs1312!K1312_DateERD3) = False Then D1312.DateERD3 = Trim$(rs1312!K1312_DateERD3)
            If IsDBNull(rs1312!K1312_DateSRD4) = False Then D1312.DateSRD4 = Trim$(rs1312!K1312_DateSRD4)
            If IsDBNull(rs1312!K1312_DateERD4) = False Then D1312.DateERD4 = Trim$(rs1312!K1312_DateERD4)
            If IsDBNull(rs1312!K1312_SpecNo) = False Then D1312.SpecNo = Trim$(rs1312!K1312_SpecNo)
            If IsDBNull(rs1312!K1312_SpecNoSeq) = False Then D1312.SpecNoSeq = Trim$(rs1312!K1312_SpecNoSeq)
            If IsDBNull(rs1312!K1312_DateSole) = False Then D1312.DateSole = Trim$(rs1312!K1312_DateSole)
            If IsDBNull(rs1312!K1312_DateCutting) = False Then D1312.DateCutting = Trim$(rs1312!K1312_DateCutting)
            If IsDBNull(rs1312!K1312_DateStitching) = False Then D1312.DateStitching = Trim$(rs1312!K1312_DateStitching)
            If IsDBNull(rs1312!K1312_DateStockfit) = False Then D1312.DateStockfit = Trim$(rs1312!K1312_DateStockfit)
            If IsDBNull(rs1312!K1312_DateAssmbly) = False Then D1312.DateAssmbly = Trim$(rs1312!K1312_DateAssmbly)
            If IsDBNull(rs1312!K1312_DateShipping) = False Then D1312.DateShipping = Trim$(rs1312!K1312_DateShipping)
            If IsDBNull(rs1312!K1312_seUnitMaterial) = False Then D1312.seUnitMaterial = Trim$(rs1312!K1312_seUnitMaterial)
            If IsDBNull(rs1312!K1312_cdUnitMaterial) = False Then D1312.cdUnitMaterial = Trim$(rs1312!K1312_cdUnitMaterial)
            If IsDBNull(rs1312!K1312_seUnitPacking) = False Then D1312.seUnitPacking = Trim$(rs1312!K1312_seUnitPacking)
            If IsDBNull(rs1312!K1312_cdUnitPacking) = False Then D1312.cdUnitPacking = Trim$(rs1312!K1312_cdUnitPacking)
            If IsDBNull(rs1312!K1312_QtyOrderSample) = False Then D1312.QtyOrderSample = Trim$(rs1312!K1312_QtyOrderSample)
            If IsDBNull(rs1312!K1312_QtyOrderSample01) = False Then D1312.QtyOrderSample01 = Trim$(rs1312!K1312_QtyOrderSample01)
            If IsDBNull(rs1312!K1312_QtyOrderSample02) = False Then D1312.QtyOrderSample02 = Trim$(rs1312!K1312_QtyOrderSample02)
            If IsDBNull(rs1312!K1312_QtyOrder) = False Then D1312.QtyOrder = Trim$(rs1312!K1312_QtyOrder)
            If IsDBNull(rs1312!K1312_QtyJob) = False Then D1312.QtyJob = Trim$(rs1312!K1312_QtyJob)
            If IsDBNull(rs1312!K1312_QtySole) = False Then D1312.QtySole = Trim$(rs1312!K1312_QtySole)
            If IsDBNull(rs1312!K1312_QtyCutting) = False Then D1312.QtyCutting = Trim$(rs1312!K1312_QtyCutting)
            If IsDBNull(rs1312!K1312_QtyStitching) = False Then D1312.QtyStitching = Trim$(rs1312!K1312_QtyStitching)
            If IsDBNull(rs1312!K1312_QtyStockfit) = False Then D1312.QtyStockfit = Trim$(rs1312!K1312_QtyStockfit)
            If IsDBNull(rs1312!K1312_QtyAssembly) = False Then D1312.QtyAssembly = Trim$(rs1312!K1312_QtyAssembly)
            If IsDBNull(rs1312!K1312_QtyPacking) = False Then D1312.QtyPacking = Trim$(rs1312!K1312_QtyPacking)
            If IsDBNull(rs1312!K1312_QtyInbound) = False Then D1312.QtyInbound = Trim$(rs1312!K1312_QtyInbound)
            If IsDBNull(rs1312!K1312_QtyShipping) = False Then D1312.QtyShipping = Trim$(rs1312!K1312_QtyShipping)
            If IsDBNull(rs1312!K1312_TimeInsert) = False Then D1312.TimeInsert = Trim$(rs1312!K1312_TimeInsert)
            If IsDBNull(rs1312!K1312_TimeUpdate) = False Then D1312.TimeUpdate = Trim$(rs1312!K1312_TimeUpdate)
            If IsDBNull(rs1312!K1312_DateInsert) = False Then D1312.DateInsert = Trim$(rs1312!K1312_DateInsert)
            If IsDBNull(rs1312!K1312_InchargeInsert) = False Then D1312.InchargeInsert = Trim$(rs1312!K1312_InchargeInsert)
            If IsDBNull(rs1312!K1312_DateUpdate) = False Then D1312.DateUpdate = Trim$(rs1312!K1312_DateUpdate)
            If IsDBNull(rs1312!K1312_InchargeUpdate) = False Then D1312.InchargeUpdate = Trim$(rs1312!K1312_InchargeUpdate)
            If IsDBNull(rs1312!K1312_InchargeSales) = False Then D1312.InchargeSales = Trim$(rs1312!K1312_InchargeSales)
            If IsDBNull(rs1312!K1312_InchargePPC) = False Then D1312.InchargePPC = Trim$(rs1312!K1312_InchargePPC)
            If IsDBNull(rs1312!K1312_TotalQty) = False Then D1312.TotalQty = Trim$(rs1312!K1312_TotalQty)
            If IsDBNull(rs1312!K1312_TotalAMT) = False Then D1312.TotalAMT = Trim$(rs1312!K1312_TotalAMT)
            If IsDBNull(rs1312!K1312_TotalCost) = False Then D1312.TotalCost = Trim$(rs1312!K1312_TotalCost)
            If IsDBNull(rs1312!K1312_TotalProfit) = False Then D1312.TotalProfit = Trim$(rs1312!K1312_TotalProfit)
            If IsDBNull(rs1312!K1312_TotalAMTEX) = False Then D1312.TotalAMTEX = Trim$(rs1312!K1312_TotalAMTEX)
            If IsDBNull(rs1312!K1312_TotalAMTVND) = False Then D1312.TotalAMTVND = Trim$(rs1312!K1312_TotalAMTVND)
            If IsDBNull(rs1312!K1312_TotalCostEX) = False Then D1312.TotalCostEX = Trim$(rs1312!K1312_TotalCostEX)
            If IsDBNull(rs1312!K1312_TotalCostVND) = False Then D1312.TotalCostVND = Trim$(rs1312!K1312_TotalCostVND)
            If IsDBNull(rs1312!K1312_TotalProfitEX) = False Then D1312.TotalProfitEX = Trim$(rs1312!K1312_TotalProfitEX)
            If IsDBNull(rs1312!K1312_TotalProfitVND) = False Then D1312.TotalProfitVND = Trim$(rs1312!K1312_TotalProfitVND)
            If IsDBNull(rs1312!K1312_AttachID) = False Then D1312.AttachID = Trim$(rs1312!K1312_AttachID)
            If IsDBNull(rs1312!K1312_DateSync) = False Then D1312.DateSync = Trim$(rs1312!K1312_DateSync)
            If IsDBNull(rs1312!K1312_CheckSync) = False Then D1312.CheckSync = Trim$(rs1312!K1312_CheckSync)
            If IsDBNull(rs1312!K1312_PINo) = False Then D1312.PINo = Trim$(rs1312!K1312_PINo)
            If IsDBNull(rs1312!K1312_CheckSizeGroup) = False Then D1312.CheckSizeGroup = Trim$(rs1312!K1312_CheckSizeGroup)
            If IsDBNull(rs1312!K1312_OrderNoRef) = False Then D1312.OrderNoRef = Trim$(rs1312!K1312_OrderNoRef)
            If IsDBNull(rs1312!K1312_OrderNoSeqRef) = False Then D1312.OrderNoSeqRef = Trim$(rs1312!K1312_OrderNoSeqRef)
            If IsDBNull(rs1312!K1312_Remark) = False Then D1312.Remark = Trim$(rs1312!K1312_Remark)
            If IsDBNull(rs1312!K1312_RemarkOrder) = False Then D1312.RemarkOrder = Trim$(rs1312!K1312_RemarkOrder)
            If IsDBNull(rs1312!K1312_RemarkCustomer) = False Then D1312.RemarkCustomer = Trim$(rs1312!K1312_RemarkCustomer)
            If IsDBNull(rs1312!K1312_RemarkOther) = False Then D1312.RemarkOther = Trim$(rs1312!K1312_RemarkOther)
            If IsDBNull(rs1312!K1312_RemarkTrading) = False Then D1312.RemarkTrading = Trim$(rs1312!K1312_RemarkTrading)
            If IsDBNull(rs1312!K1312_seSite) = False Then D1312.seSite = Trim$(rs1312!K1312_seSite)
            If IsDBNull(rs1312!K1312_cdSite) = False Then D1312.cdSite = Trim$(rs1312!K1312_cdSite)
            If IsDBNull(rs1312!K1312_LicenseName) = False Then D1312.LicenseName = Trim$(rs1312!K1312_LicenseName)
            If IsDBNull(rs1312!K1312_TestStandard) = False Then D1312.TestStandard = Trim$(rs1312!K1312_TestStandard)
            If IsDBNull(rs1312!K1312_TestNo) = False Then D1312.TestNo = Trim$(rs1312!K1312_TestNo)
            If IsDBNull(rs1312!K1312_DateReport) = False Then D1312.DateReport = Trim$(rs1312!K1312_DateReport)
            If IsDBNull(rs1312!K1312_InvoiceStatus) = False Then D1312.InvoiceStatus = Trim$(rs1312!K1312_InvoiceStatus)
            If IsDBNull(rs1312!K1312_WIPStatus) = False Then D1312.WIPStatus = Trim$(rs1312!K1312_WIPStatus)
            If IsDBNull(rs1312!K1312_WIPDate) = False Then D1312.WIPDate = Trim$(rs1312!K1312_WIPDate)
            If IsDBNull(rs1312!K1312_WIPNo) = False Then D1312.WIPNo = Trim$(rs1312!K1312_WIPNo)
            If IsDBNull(rs1312!K1312_ExportCode) = False Then D1312.ExportCode = Trim$(rs1312!K1312_ExportCode)
            If IsDBNull(rs1312!K1312_ExportName) = False Then D1312.ExportName = Trim$(rs1312!K1312_ExportName)


        Catch ex As Exception

        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K1312_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z1312 As T1312_AREA, OrderNo As String, OrderNoSeq As String) As Boolean

        K1312_MOVE = False

        Try
            If READ_PFK1312(OrderNo, OrderNoSeq) = True Then
                z1312 = D1312
                K1312_MOVE = True
            Else
                z1312 = Nothing
            End If

            If getColumnIndex(spr, "OrderNo") > -1 Then z1312.OrderNo = getDataM(spr, getColumnIndex(spr, "OrderNo"), xRow)
            If getColumnIndex(spr, "OrderNoSeq") > -1 Then z1312.OrderNoSeq = getDataM(spr, getColumnIndex(spr, "OrderNoSeq"), xRow)
            If getColumnIndex(spr, "PRName") > -1 Then z1312.PRName = getDataM(spr, getColumnIndex(spr, "PRName"), xRow)
            If getColumnIndex(spr, "TimeReviseApt") > -1 Then z1312.TimeReviseApt = getDataM(spr, getColumnIndex(spr, "TimeReviseApt"), xRow)
            If getColumnIndex(spr, "TimeRevisePrt") > -1 Then z1312.TimeRevisePrt = getDataM(spr, getColumnIndex(spr, "TimeRevisePrt"), xRow)
            If getColumnIndex(spr, "TimeRevise") > -1 Then z1312.TimeRevise = getDataM(spr, getColumnIndex(spr, "TimeRevise"), xRow)
            If getColumnIndex(spr, "TimeRnDRevise") > -1 Then z1312.TimeRnDRevise = getDataM(spr, getColumnIndex(spr, "TimeRnDRevise"), xRow)
            If getColumnIndex(spr, "TimeSalesRevise") > -1 Then z1312.TimeSalesRevise = getDataM(spr, getColumnIndex(spr, "TimeSalesRevise"), xRow)
            If getColumnIndex(spr, "InchargeRevise") > -1 Then z1312.InchargeRevise = getDataM(spr, getColumnIndex(spr, "InchargeRevise"), xRow)
            If getColumnIndex(spr, "ReviseNo") > -1 Then z1312.ReviseNo = getDataM(spr, getColumnIndex(spr, "ReviseNo"), xRow)
            If getColumnIndex(spr, "ShoesCode") > -1 Then z1312.ShoesCode = getDataM(spr, getColumnIndex(spr, "ShoesCode"), xRow)
            If getColumnIndex(spr, "ShoesCodeFin") > -1 Then z1312.ShoesCodeFin = getDataM(spr, getColumnIndex(spr, "ShoesCodeFin"), xRow)
            If getColumnIndex(spr, "FacPO") > -1 Then z1312.FacPO = getDataM(spr, getColumnIndex(spr, "FacPO"), xRow)
            If getColumnIndex(spr, "SLNoSys") > -1 Then z1312.SLNoSys = getDataM(spr, getColumnIndex(spr, "SLNoSys"), xRow)
            If getColumnIndex(spr, "SLNo") > -1 Then z1312.SLNo = getDataM(spr, getColumnIndex(spr, "SLNo"), xRow)
            If getColumnIndex(spr, "PONO") > -1 Then z1312.PONO = getDataM(spr, getColumnIndex(spr, "PONO"), xRow)
            If getColumnIndex(spr, "CPONO") > -1 Then z1312.CPONO = getDataM(spr, getColumnIndex(spr, "CPONO"), xRow)
            If getColumnIndex(spr, "CustomerCode") > -1 Then z1312.CustomerCode = getDataM(spr, getColumnIndex(spr, "CustomerCode"), xRow)
            If getColumnIndex(spr, "CustomerName") > -1 Then z1312.CustomerName = getDataM(spr, getColumnIndex(spr, "CustomerName"), xRow)
            If getColumnIndex(spr, "Country") > -1 Then z1312.Country = getDataM(spr, getColumnIndex(spr, "Country"), xRow)
            If getColumnIndex(spr, "Destination") > -1 Then z1312.Destination = getDataM(spr, getColumnIndex(spr, "Destination"), xRow)
            If getColumnIndex(spr, "FinalShop") > -1 Then z1312.FinalShop = getDataM(spr, getColumnIndex(spr, "FinalShop"), xRow)
            If getColumnIndex(spr, "PKO") > -1 Then z1312.PKO = getDataM(spr, getColumnIndex(spr, "PKO"), xRow)
            If getColumnIndex(spr, "DatePO") > -1 Then z1312.DatePO = getDataM(spr, getColumnIndex(spr, "DatePO"), xRow)
            If getColumnIndex(spr, "JbCard") > -1 Then z1312.JbCard = getDataM(spr, getColumnIndex(spr, "JbCard"), xRow)
            If getColumnIndex(spr, "sePackingCode") > -1 Then z1312.sePackingCode = getDataM(spr, getColumnIndex(spr, "sePackingCode"), xRow)
            If getColumnIndex(spr, "cdPackingCode") > -1 Then z1312.cdPackingCode = getDataM(spr, getColumnIndex(spr, "cdPackingCode"), xRow)
            If getColumnIndex(spr, "seSpecStatus") > -1 Then z1312.seSpecStatus = getDataM(spr, getColumnIndex(spr, "seSpecStatus"), xRow)
            If getColumnIndex(spr, "cdSpecStatus") > -1 Then z1312.cdSpecStatus = getDataM(spr, getColumnIndex(spr, "cdSpecStatus"), xRow)
            If getColumnIndex(spr, "SizeRange") > -1 Then z1312.SizeRange = getDataM(spr, getColumnIndex(spr, "SizeRange"), xRow)
            If getColumnIndex(spr, "SpeciticSize") > -1 Then z1312.SpeciticSize = getDataM(spr, getColumnIndex(spr, "SpeciticSize"), xRow)
            If getColumnIndex(spr, "DateSize") > -1 Then z1312.DateSize = getDataM(spr, getColumnIndex(spr, "DateSize"), xRow)
            If getColumnIndex(spr, "OrderDetailStatus") > -1 Then z1312.OrderDetailStatus = getDataM(spr, getColumnIndex(spr, "OrderDetailStatus"), xRow)
            If getColumnIndex(spr, "DateOrder") > -1 Then z1312.DateOrder = getDataM(spr, getColumnIndex(spr, "DateOrder"), xRow)
            If getColumnIndex(spr, "DateApproval") > -1 Then z1312.DateApproval = getDataM(spr, getColumnIndex(spr, "DateApproval"), xRow)
            If getColumnIndex(spr, "DateCL") > -1 Then z1312.DateCL = getDataM(spr, getColumnIndex(spr, "DateCL"), xRow)
            If getColumnIndex(spr, "DateCancel") > -1 Then z1312.DateCancel = getDataM(spr, getColumnIndex(spr, "DateCancel"), xRow)
            If getColumnIndex(spr, "RemarkCancel") > -1 Then z1312.RemarkCancel = getDataM(spr, getColumnIndex(spr, "RemarkCancel"), xRow)
            If getColumnIndex(spr, "DateComplete") > -1 Then z1312.DateComplete = getDataM(spr, getColumnIndex(spr, "DateComplete"), xRow)
            If getColumnIndex(spr, "DatePending") > -1 Then z1312.DatePending = getDataM(spr, getColumnIndex(spr, "DatePending"), xRow)
            If getColumnIndex(spr, "DatePending2") > -1 Then z1312.DatePending2 = getDataM(spr, getColumnIndex(spr, "DatePending2"), xRow)
            If getColumnIndex(spr, "DateExchangePrice") > -1 Then z1312.DateExchangePrice = getDataM(spr, getColumnIndex(spr, "DateExchangePrice"), xRow)
            If getColumnIndex(spr, "SizeW") > -1 Then z1312.SizeW = getDataM(spr, getColumnIndex(spr, "SizeW"), xRow)
            If getColumnIndex(spr, "SizeL") > -1 Then z1312.SizeL = getDataM(spr, getColumnIndex(spr, "SizeL"), xRow)
            If getColumnIndex(spr, "SizeH") > -1 Then z1312.SizeH = getDataM(spr, getColumnIndex(spr, "SizeH"), xRow)
            If getColumnIndex(spr, "QtyNo1") > -1 Then z1312.QtyNo1 = getDataM(spr, getColumnIndex(spr, "QtyNo1"), xRow)
            If getColumnIndex(spr, "QtyNo2") > -1 Then z1312.QtyNo2 = getDataM(spr, getColumnIndex(spr, "QtyNo2"), xRow)
            If getColumnIndex(spr, "QtyNo3") > -1 Then z1312.QtyNo3 = getDataM(spr, getColumnIndex(spr, "QtyNo3"), xRow)
            If getColumnIndex(spr, "QtyGW") > -1 Then z1312.QtyGW = getDataM(spr, getColumnIndex(spr, "QtyGW"), xRow)
            If getColumnIndex(spr, "QtyNW") > -1 Then z1312.QtyNW = getDataM(spr, getColumnIndex(spr, "QtyNW"), xRow)
            If getColumnIndex(spr, "QtyPcsPoly") > -1 Then z1312.QtyPcsPoly = getDataM(spr, getColumnIndex(spr, "QtyPcsPoly"), xRow)
            If getColumnIndex(spr, "QtyPolyCTN") > -1 Then z1312.QtyPolyCTN = getDataM(spr, getColumnIndex(spr, "QtyPolyCTN"), xRow)
            If getColumnIndex(spr, "QtyPcsCTN") > -1 Then z1312.QtyPcsCTN = getDataM(spr, getColumnIndex(spr, "QtyPcsCTN"), xRow)
            If getColumnIndex(spr, "QtyPcsPINO") > -1 Then z1312.QtyPcsPINO = getDataM(spr, getColumnIndex(spr, "QtyPcsPINO"), xRow)
            If getColumnIndex(spr, "PriceExchange") > -1 Then z1312.PriceExchange = getDataM(spr, getColumnIndex(spr, "PriceExchange"), xRow)
            If getColumnIndex(spr, "CheckFOB") > -1 Then z1312.CheckFOB = getDataM(spr, getColumnIndex(spr, "CheckFOB"), xRow)
            If getColumnIndex(spr, "PriceOrderFOB") > -1 Then z1312.PriceOrderFOB = getDataM(spr, getColumnIndex(spr, "PriceOrderFOB"), xRow)
            If getColumnIndex(spr, "TotalAMTFOB") > -1 Then z1312.TotalAMTFOB = getDataM(spr, getColumnIndex(spr, "TotalAMTFOB"), xRow)
            If getColumnIndex(spr, "PriceOrder") > -1 Then z1312.PriceOrder = getDataM(spr, getColumnIndex(spr, "PriceOrder"), xRow)
            If getColumnIndex(spr, "PriceOrder1") > -1 Then z1312.PriceOrder1 = getDataM(spr, getColumnIndex(spr, "PriceOrder1"), xRow)
            If getColumnIndex(spr, "PriceOrder2") > -1 Then z1312.PriceOrder2 = getDataM(spr, getColumnIndex(spr, "PriceOrder2"), xRow)
            If getColumnIndex(spr, "PriceOrder3") > -1 Then z1312.PriceOrder3 = getDataM(spr, getColumnIndex(spr, "PriceOrder3"), xRow)
            If getColumnIndex(spr, "seUnitPrice") > -1 Then z1312.seUnitPrice = getDataM(spr, getColumnIndex(spr, "seUnitPrice"), xRow)
            If getColumnIndex(spr, "cdUnitPrice") > -1 Then z1312.cdUnitPrice = getDataM(spr, getColumnIndex(spr, "cdUnitPrice"), xRow)
            If getColumnIndex(spr, "UnitPrice") > -1 Then z1312.UnitPrice = getDataM(spr, getColumnIndex(spr, "UnitPrice"), xRow)
            If getColumnIndex(spr, "PriceOrderEX") > -1 Then z1312.PriceOrderEX = getDataM(spr, getColumnIndex(spr, "PriceOrderEX"), xRow)
            If getColumnIndex(spr, "PriceOrderVND") > -1 Then z1312.PriceOrderVND = getDataM(spr, getColumnIndex(spr, "PriceOrderVND"), xRow)
            If getColumnIndex(spr, "Datedelivery") > -1 Then z1312.Datedelivery = getDataM(spr, getColumnIndex(spr, "Datedelivery"), xRow)
            If getColumnIndex(spr, "DateTransfer") > -1 Then z1312.DateTransfer = getDataM(spr, getColumnIndex(spr, "DateTransfer"), xRow)
            If getColumnIndex(spr, "AcceptedOrder") > -1 Then z1312.AcceptedOrder = getDataM(spr, getColumnIndex(spr, "AcceptedOrder"), xRow)
            If getColumnIndex(spr, "MaterialStatus") > -1 Then z1312.MaterialStatus = getDataM(spr, getColumnIndex(spr, "MaterialStatus"), xRow)
            If getColumnIndex(spr, "SoleStatus") > -1 Then z1312.SoleStatus = getDataM(spr, getColumnIndex(spr, "SoleStatus"), xRow)
            If getColumnIndex(spr, "DateLable") > -1 Then z1312.DateLable = getDataM(spr, getColumnIndex(spr, "DateLable"), xRow)
            If getColumnIndex(spr, "DatePattern") > -1 Then z1312.DatePattern = getDataM(spr, getColumnIndex(spr, "DatePattern"), xRow)
            If getColumnIndex(spr, "DateMaterial") > -1 Then z1312.DateMaterial = getDataM(spr, getColumnIndex(spr, "DateMaterial"), xRow)
            If getColumnIndex(spr, "DatePlanning") > -1 Then z1312.DatePlanning = getDataM(spr, getColumnIndex(spr, "DatePlanning"), xRow)
            If getColumnIndex(spr, "DateRnD") > -1 Then z1312.DateRnD = getDataM(spr, getColumnIndex(spr, "DateRnD"), xRow)
            If getColumnIndex(spr, "DateFitting") > -1 Then z1312.DateFitting = getDataM(spr, getColumnIndex(spr, "DateFitting"), xRow)
            If getColumnIndex(spr, "InchargeFitting") > -1 Then z1312.InchargeFitting = getDataM(spr, getColumnIndex(spr, "InchargeFitting"), xRow)
            If getColumnIndex(spr, "CheckFitting") > -1 Then z1312.CheckFitting = getDataM(spr, getColumnIndex(spr, "CheckFitting"), xRow)
            If getColumnIndex(spr, "DateTesting") > -1 Then z1312.DateTesting = getDataM(spr, getColumnIndex(spr, "DateTesting"), xRow)
            If getColumnIndex(spr, "InchargeTesting") > -1 Then z1312.InchargeTesting = getDataM(spr, getColumnIndex(spr, "InchargeTesting"), xRow)
            If getColumnIndex(spr, "CheckTesting") > -1 Then z1312.CheckTesting = getDataM(spr, getColumnIndex(spr, "CheckTesting"), xRow)
            If getColumnIndex(spr, "CheckConfirm") > -1 Then z1312.CheckConfirm = getDataM(spr, getColumnIndex(spr, "CheckConfirm"), xRow)
            If getColumnIndex(spr, "DateConfirm") > -1 Then z1312.DateConfirm = getDataM(spr, getColumnIndex(spr, "DateConfirm"), xRow)
            If getColumnIndex(spr, "InchargeRD1") > -1 Then z1312.InchargeRD1 = getDataM(spr, getColumnIndex(spr, "InchargeRD1"), xRow)
            If getColumnIndex(spr, "InchargeRD2") > -1 Then z1312.InchargeRD2 = getDataM(spr, getColumnIndex(spr, "InchargeRD2"), xRow)
            If getColumnIndex(spr, "InchargeRD3") > -1 Then z1312.InchargeRD3 = getDataM(spr, getColumnIndex(spr, "InchargeRD3"), xRow)
            If getColumnIndex(spr, "InchargeRD4") > -1 Then z1312.InchargeRD4 = getDataM(spr, getColumnIndex(spr, "InchargeRD4"), xRow)
            If getColumnIndex(spr, "DateSRD1") > -1 Then z1312.DateSRD1 = getDataM(spr, getColumnIndex(spr, "DateSRD1"), xRow)
            If getColumnIndex(spr, "DateERD1") > -1 Then z1312.DateERD1 = getDataM(spr, getColumnIndex(spr, "DateERD1"), xRow)
            If getColumnIndex(spr, "DateSRD2") > -1 Then z1312.DateSRD2 = getDataM(spr, getColumnIndex(spr, "DateSRD2"), xRow)
            If getColumnIndex(spr, "DateERD2") > -1 Then z1312.DateERD2 = getDataM(spr, getColumnIndex(spr, "DateERD2"), xRow)
            If getColumnIndex(spr, "DateSRD3") > -1 Then z1312.DateSRD3 = getDataM(spr, getColumnIndex(spr, "DateSRD3"), xRow)
            If getColumnIndex(spr, "DateERD3") > -1 Then z1312.DateERD3 = getDataM(spr, getColumnIndex(spr, "DateERD3"), xRow)
            If getColumnIndex(spr, "DateSRD4") > -1 Then z1312.DateSRD4 = getDataM(spr, getColumnIndex(spr, "DateSRD4"), xRow)
            If getColumnIndex(spr, "DateERD4") > -1 Then z1312.DateERD4 = getDataM(spr, getColumnIndex(spr, "DateERD4"), xRow)
            If getColumnIndex(spr, "SpecNo") > -1 Then z1312.SpecNo = getDataM(spr, getColumnIndex(spr, "SpecNo"), xRow)
            If getColumnIndex(spr, "SpecNoSeq") > -1 Then z1312.SpecNoSeq = getDataM(spr, getColumnIndex(spr, "SpecNoSeq"), xRow)
            If getColumnIndex(spr, "DateSole") > -1 Then z1312.DateSole = getDataM(spr, getColumnIndex(spr, "DateSole"), xRow)
            If getColumnIndex(spr, "DateCutting") > -1 Then z1312.DateCutting = getDataM(spr, getColumnIndex(spr, "DateCutting"), xRow)
            If getColumnIndex(spr, "DateStitching") > -1 Then z1312.DateStitching = getDataM(spr, getColumnIndex(spr, "DateStitching"), xRow)
            If getColumnIndex(spr, "DateStockfit") > -1 Then z1312.DateStockfit = getDataM(spr, getColumnIndex(spr, "DateStockfit"), xRow)
            If getColumnIndex(spr, "DateAssmbly") > -1 Then z1312.DateAssmbly = getDataM(spr, getColumnIndex(spr, "DateAssmbly"), xRow)
            If getColumnIndex(spr, "DateShipping") > -1 Then z1312.DateShipping = getDataM(spr, getColumnIndex(spr, "DateShipping"), xRow)
            If getColumnIndex(spr, "seUnitMaterial") > -1 Then z1312.seUnitMaterial = getDataM(spr, getColumnIndex(spr, "seUnitMaterial"), xRow)
            If getColumnIndex(spr, "cdUnitMaterial") > -1 Then z1312.cdUnitMaterial = getDataM(spr, getColumnIndex(spr, "cdUnitMaterial"), xRow)
            If getColumnIndex(spr, "seUnitPacking") > -1 Then z1312.seUnitPacking = getDataM(spr, getColumnIndex(spr, "seUnitPacking"), xRow)
            If getColumnIndex(spr, "cdUnitPacking") > -1 Then z1312.cdUnitPacking = getDataM(spr, getColumnIndex(spr, "cdUnitPacking"), xRow)
            If getColumnIndex(spr, "QtyOrderSample") > -1 Then z1312.QtyOrderSample = getDataM(spr, getColumnIndex(spr, "QtyOrderSample"), xRow)
            If getColumnIndex(spr, "QtyOrderSample01") > -1 Then z1312.QtyOrderSample01 = getDataM(spr, getColumnIndex(spr, "QtyOrderSample01"), xRow)
            If getColumnIndex(spr, "QtyOrderSample02") > -1 Then z1312.QtyOrderSample02 = getDataM(spr, getColumnIndex(spr, "QtyOrderSample02"), xRow)
            If getColumnIndex(spr, "QtyOrder") > -1 Then z1312.QtyOrder = getDataM(spr, getColumnIndex(spr, "QtyOrder"), xRow)
            If getColumnIndex(spr, "QtyJob") > -1 Then z1312.QtyJob = getDataM(spr, getColumnIndex(spr, "QtyJob"), xRow)
            If getColumnIndex(spr, "QtySole") > -1 Then z1312.QtySole = getDataM(spr, getColumnIndex(spr, "QtySole"), xRow)
            If getColumnIndex(spr, "QtyCutting") > -1 Then z1312.QtyCutting = getDataM(spr, getColumnIndex(spr, "QtyCutting"), xRow)
            If getColumnIndex(spr, "QtyStitching") > -1 Then z1312.QtyStitching = getDataM(spr, getColumnIndex(spr, "QtyStitching"), xRow)
            If getColumnIndex(spr, "QtyStockfit") > -1 Then z1312.QtyStockfit = getDataM(spr, getColumnIndex(spr, "QtyStockfit"), xRow)
            If getColumnIndex(spr, "QtyAssembly") > -1 Then z1312.QtyAssembly = getDataM(spr, getColumnIndex(spr, "QtyAssembly"), xRow)
            If getColumnIndex(spr, "QtyPacking") > -1 Then z1312.QtyPacking = getDataM(spr, getColumnIndex(spr, "QtyPacking"), xRow)
            If getColumnIndex(spr, "QtyInbound") > -1 Then z1312.QtyInbound = getDataM(spr, getColumnIndex(spr, "QtyInbound"), xRow)
            If getColumnIndex(spr, "QtyShipping") > -1 Then z1312.QtyShipping = getDataM(spr, getColumnIndex(spr, "QtyShipping"), xRow)
            If getColumnIndex(spr, "TimeInsert") > -1 Then z1312.TimeInsert = getDataM(spr, getColumnIndex(spr, "TimeInsert"), xRow)
            If getColumnIndex(spr, "TimeUpdate") > -1 Then z1312.TimeUpdate = getDataM(spr, getColumnIndex(spr, "TimeUpdate"), xRow)
            If getColumnIndex(spr, "DateInsert") > -1 Then z1312.DateInsert = getDataM(spr, getColumnIndex(spr, "DateInsert"), xRow)
            If getColumnIndex(spr, "InchargeInsert") > -1 Then z1312.InchargeInsert = getDataM(spr, getColumnIndex(spr, "InchargeInsert"), xRow)
            If getColumnIndex(spr, "DateUpdate") > -1 Then z1312.DateUpdate = getDataM(spr, getColumnIndex(spr, "DateUpdate"), xRow)
            If getColumnIndex(spr, "InchargeUpdate") > -1 Then z1312.InchargeUpdate = getDataM(spr, getColumnIndex(spr, "InchargeUpdate"), xRow)
            If getColumnIndex(spr, "InchargeSales") > -1 Then z1312.InchargeSales = getDataM(spr, getColumnIndex(spr, "InchargeSales"), xRow)
            If getColumnIndex(spr, "InchargePPC") > -1 Then z1312.InchargePPC = getDataM(spr, getColumnIndex(spr, "InchargePPC"), xRow)
            If getColumnIndex(spr, "TotalQty") > -1 Then z1312.TotalQty = getDataM(spr, getColumnIndex(spr, "TotalQty"), xRow)
            If getColumnIndex(spr, "TotalAMT") > -1 Then z1312.TotalAMT = getDataM(spr, getColumnIndex(spr, "TotalAMT"), xRow)
            If getColumnIndex(spr, "TotalCost") > -1 Then z1312.TotalCost = getDataM(spr, getColumnIndex(spr, "TotalCost"), xRow)
            If getColumnIndex(spr, "TotalProfit") > -1 Then z1312.TotalProfit = getDataM(spr, getColumnIndex(spr, "TotalProfit"), xRow)
            If getColumnIndex(spr, "TotalAMTEX") > -1 Then z1312.TotalAMTEX = getDataM(spr, getColumnIndex(spr, "TotalAMTEX"), xRow)
            If getColumnIndex(spr, "TotalAMTVND") > -1 Then z1312.TotalAMTVND = getDataM(spr, getColumnIndex(spr, "TotalAMTVND"), xRow)
            If getColumnIndex(spr, "TotalCostEX") > -1 Then z1312.TotalCostEX = getDataM(spr, getColumnIndex(spr, "TotalCostEX"), xRow)
            If getColumnIndex(spr, "TotalCostVND") > -1 Then z1312.TotalCostVND = getDataM(spr, getColumnIndex(spr, "TotalCostVND"), xRow)
            If getColumnIndex(spr, "TotalProfitEX") > -1 Then z1312.TotalProfitEX = getDataM(spr, getColumnIndex(spr, "TotalProfitEX"), xRow)
            If getColumnIndex(spr, "TotalProfitVND") > -1 Then z1312.TotalProfitVND = getDataM(spr, getColumnIndex(spr, "TotalProfitVND"), xRow)
            If getColumnIndex(spr, "AttachID") > -1 Then z1312.AttachID = getDataM(spr, getColumnIndex(spr, "AttachID"), xRow)
            If getColumnIndex(spr, "DateSync") > -1 Then z1312.DateSync = getDataM(spr, getColumnIndex(spr, "DateSync"), xRow)
            If getColumnIndex(spr, "CheckSync") > -1 Then z1312.CheckSync = getDataM(spr, getColumnIndex(spr, "CheckSync"), xRow)
            If getColumnIndex(spr, "PINo") > -1 Then z1312.PINo = getDataM(spr, getColumnIndex(spr, "PINo"), xRow)
            If getColumnIndex(spr, "CheckSizeGroup") > -1 Then z1312.CheckSizeGroup = getDataM(spr, getColumnIndex(spr, "CheckSizeGroup"), xRow)
            If getColumnIndex(spr, "OrderNoRef") > -1 Then z1312.OrderNoRef = getDataM(spr, getColumnIndex(spr, "OrderNoRef"), xRow)
            If getColumnIndex(spr, "OrderNoSeqRef") > -1 Then z1312.OrderNoSeqRef = getDataM(spr, getColumnIndex(spr, "OrderNoSeqRef"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z1312.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)
            If getColumnIndex(spr, "RemarkOrder") > -1 Then z1312.RemarkOrder = getDataM(spr, getColumnIndex(spr, "RemarkOrder"), xRow)
            If getColumnIndex(spr, "RemarkCustomer") > -1 Then z1312.RemarkCustomer = getDataM(spr, getColumnIndex(spr, "RemarkCustomer"), xRow)
            If getColumnIndex(spr, "RemarkOther") > -1 Then z1312.RemarkOther = getDataM(spr, getColumnIndex(spr, "RemarkOther"), xRow)
            If getColumnIndex(spr, "RemarkTrading") > -1 Then z1312.RemarkTrading = getDataM(spr, getColumnIndex(spr, "RemarkTrading"), xRow)
            If getColumnIndex(spr, "seSite") > -1 Then z1312.seSite = getDataM(spr, getColumnIndex(spr, "seSite"), xRow)
            If getColumnIndex(spr, "cdSite") > -1 Then z1312.cdSite = getDataM(spr, getColumnIndex(spr, "cdSite"), xRow)
            If getColumnIndex(spr, "LicenseName") > -1 Then z1312.LicenseName = getDataM(spr, getColumnIndex(spr, "LicenseName"), xRow)
            If getColumnIndex(spr, "TestStandard") > -1 Then z1312.TestStandard = getDataM(spr, getColumnIndex(spr, "TestStandard"), xRow)
            If getColumnIndex(spr, "TestNo") > -1 Then z1312.TestNo = getDataM(spr, getColumnIndex(spr, "TestNo"), xRow)
            If getColumnIndex(spr, "DateReport") > -1 Then z1312.DateReport = getDataM(spr, getColumnIndex(spr, "DateReport"), xRow)
            If getColumnIndex(spr, "InvoiceStatus") > -1 Then z1312.InvoiceStatus = getDataM(spr, getColumnIndex(spr, "InvoiceStatus"), xRow)
            If getColumnIndex(spr, "WIPStatus") > -1 Then z1312.WIPStatus = getDataM(spr, getColumnIndex(spr, "WIPStatus"), xRow)
            If getColumnIndex(spr, "WIPDate") > -1 Then z1312.WIPDate = getDataM(spr, getColumnIndex(spr, "WIPDate"), xRow)
            If getColumnIndex(spr, "WIPNo") > -1 Then z1312.WIPNo = getDataM(spr, getColumnIndex(spr, "WIPNo"), xRow)
            If getColumnIndex(spr, "ExportCode") > -1 Then z1312.ExportCode = getDataM(spr, getColumnIndex(spr, "ExportCode"), xRow)
            If getColumnIndex(spr, "ExportName") > -1 Then z1312.ExportName = getDataM(spr, getColumnIndex(spr, "ExportName"), xRow)


        Catch ex As Exception

        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K1312_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z1312 As T1312_AREA, CheckClear As Boolean, OrderNo As String, OrderNoSeq As String) As Boolean

        K1312_MOVE = False

        Try
            If READ_PFK1312(OrderNo, OrderNoSeq) = True Then
                z1312 = D1312
                K1312_MOVE = True
            Else
                If CheckClear = True Then z1312 = Nothing
            End If

            If getColumnIndex(spr, "OrderNo") > -1 Then z1312.OrderNo = getDataM(spr, getColumnIndex(spr, "OrderNo"), xRow)
            If getColumnIndex(spr, "OrderNoSeq") > -1 Then z1312.OrderNoSeq = getDataM(spr, getColumnIndex(spr, "OrderNoSeq"), xRow)
            If getColumnIndex(spr, "PRName") > -1 Then z1312.PRName = getDataM(spr, getColumnIndex(spr, "PRName"), xRow)
            If getColumnIndex(spr, "TimeReviseApt") > -1 Then z1312.TimeReviseApt = getDataM(spr, getColumnIndex(spr, "TimeReviseApt"), xRow)
            If getColumnIndex(spr, "TimeRevisePrt") > -1 Then z1312.TimeRevisePrt = getDataM(spr, getColumnIndex(spr, "TimeRevisePrt"), xRow)
            If getColumnIndex(spr, "TimeRevise") > -1 Then z1312.TimeRevise = getDataM(spr, getColumnIndex(spr, "TimeRevise"), xRow)
            If getColumnIndex(spr, "TimeRnDRevise") > -1 Then z1312.TimeRnDRevise = getDataM(spr, getColumnIndex(spr, "TimeRnDRevise"), xRow)
            If getColumnIndex(spr, "TimeSalesRevise") > -1 Then z1312.TimeSalesRevise = getDataM(spr, getColumnIndex(spr, "TimeSalesRevise"), xRow)
            If getColumnIndex(spr, "InchargeRevise") > -1 Then z1312.InchargeRevise = getDataM(spr, getColumnIndex(spr, "InchargeRevise"), xRow)
            If getColumnIndex(spr, "ReviseNo") > -1 Then z1312.ReviseNo = getDataM(spr, getColumnIndex(spr, "ReviseNo"), xRow)
            If getColumnIndex(spr, "ShoesCode") > -1 Then z1312.ShoesCode = getDataM(spr, getColumnIndex(spr, "ShoesCode"), xRow)
            If getColumnIndex(spr, "ShoesCodeFin") > -1 Then z1312.ShoesCodeFin = getDataM(spr, getColumnIndex(spr, "ShoesCodeFin"), xRow)
            If getColumnIndex(spr, "FacPO") > -1 Then z1312.FacPO = getDataM(spr, getColumnIndex(spr, "FacPO"), xRow)
            If getColumnIndex(spr, "SLNoSys") > -1 Then z1312.SLNoSys = getDataM(spr, getColumnIndex(spr, "SLNoSys"), xRow)
            If getColumnIndex(spr, "SLNo") > -1 Then z1312.SLNo = getDataM(spr, getColumnIndex(spr, "SLNo"), xRow)
            If getColumnIndex(spr, "PONO") > -1 Then z1312.PONO = getDataM(spr, getColumnIndex(spr, "PONO"), xRow)
            If getColumnIndex(spr, "CPONO") > -1 Then z1312.CPONO = getDataM(spr, getColumnIndex(spr, "CPONO"), xRow)
            If getColumnIndex(spr, "CustomerCode") > -1 Then z1312.CustomerCode = getDataM(spr, getColumnIndex(spr, "CustomerCode"), xRow)
            If getColumnIndex(spr, "CustomerName") > -1 Then z1312.CustomerName = getDataM(spr, getColumnIndex(spr, "CustomerName"), xRow)
            If getColumnIndex(spr, "Country") > -1 Then z1312.Country = getDataM(spr, getColumnIndex(spr, "Country"), xRow)
            If getColumnIndex(spr, "Destination") > -1 Then z1312.Destination = getDataM(spr, getColumnIndex(spr, "Destination"), xRow)
            If getColumnIndex(spr, "FinalShop") > -1 Then z1312.FinalShop = getDataM(spr, getColumnIndex(spr, "FinalShop"), xRow)
            If getColumnIndex(spr, "PKO") > -1 Then z1312.PKO = getDataM(spr, getColumnIndex(spr, "PKO"), xRow)
            If getColumnIndex(spr, "DatePO") > -1 Then z1312.DatePO = getDataM(spr, getColumnIndex(spr, "DatePO"), xRow)
            If getColumnIndex(spr, "JbCard") > -1 Then z1312.JbCard = getDataM(spr, getColumnIndex(spr, "JbCard"), xRow)
            If getColumnIndex(spr, "sePackingCode") > -1 Then z1312.sePackingCode = getDataM(spr, getColumnIndex(spr, "sePackingCode"), xRow)
            If getColumnIndex(spr, "cdPackingCode") > -1 Then z1312.cdPackingCode = getDataM(spr, getColumnIndex(spr, "cdPackingCode"), xRow)
            If getColumnIndex(spr, "seSpecStatus") > -1 Then z1312.seSpecStatus = getDataM(spr, getColumnIndex(spr, "seSpecStatus"), xRow)
            If getColumnIndex(spr, "cdSpecStatus") > -1 Then z1312.cdSpecStatus = getDataM(spr, getColumnIndex(spr, "cdSpecStatus"), xRow)
            If getColumnIndex(spr, "SizeRange") > -1 Then z1312.SizeRange = getDataM(spr, getColumnIndex(spr, "SizeRange"), xRow)
            If getColumnIndex(spr, "SpeciticSize") > -1 Then z1312.SpeciticSize = getDataM(spr, getColumnIndex(spr, "SpeciticSize"), xRow)
            If getColumnIndex(spr, "DateSize") > -1 Then z1312.DateSize = getDataM(spr, getColumnIndex(spr, "DateSize"), xRow)
            If getColumnIndex(spr, "OrderDetailStatus") > -1 Then z1312.OrderDetailStatus = getDataM(spr, getColumnIndex(spr, "OrderDetailStatus"), xRow)
            If getColumnIndex(spr, "DateOrder") > -1 Then z1312.DateOrder = getDataM(spr, getColumnIndex(spr, "DateOrder"), xRow)
            If getColumnIndex(spr, "DateApproval") > -1 Then z1312.DateApproval = getDataM(spr, getColumnIndex(spr, "DateApproval"), xRow)
            If getColumnIndex(spr, "DateCL") > -1 Then z1312.DateCL = getDataM(spr, getColumnIndex(spr, "DateCL"), xRow)
            If getColumnIndex(spr, "DateCancel") > -1 Then z1312.DateCancel = getDataM(spr, getColumnIndex(spr, "DateCancel"), xRow)
            If getColumnIndex(spr, "RemarkCancel") > -1 Then z1312.RemarkCancel = getDataM(spr, getColumnIndex(spr, "RemarkCancel"), xRow)
            If getColumnIndex(spr, "DateComplete") > -1 Then z1312.DateComplete = getDataM(spr, getColumnIndex(spr, "DateComplete"), xRow)
            If getColumnIndex(spr, "DatePending") > -1 Then z1312.DatePending = getDataM(spr, getColumnIndex(spr, "DatePending"), xRow)
            If getColumnIndex(spr, "DatePending2") > -1 Then z1312.DatePending2 = getDataM(spr, getColumnIndex(spr, "DatePending2"), xRow)
            If getColumnIndex(spr, "DateExchangePrice") > -1 Then z1312.DateExchangePrice = getDataM(spr, getColumnIndex(spr, "DateExchangePrice"), xRow)
            If getColumnIndex(spr, "SizeW") > -1 Then z1312.SizeW = getDataM(spr, getColumnIndex(spr, "SizeW"), xRow)
            If getColumnIndex(spr, "SizeL") > -1 Then z1312.SizeL = getDataM(spr, getColumnIndex(spr, "SizeL"), xRow)
            If getColumnIndex(spr, "SizeH") > -1 Then z1312.SizeH = getDataM(spr, getColumnIndex(spr, "SizeH"), xRow)
            If getColumnIndex(spr, "QtyNo1") > -1 Then z1312.QtyNo1 = getDataM(spr, getColumnIndex(spr, "QtyNo1"), xRow)
            If getColumnIndex(spr, "QtyNo2") > -1 Then z1312.QtyNo2 = getDataM(spr, getColumnIndex(spr, "QtyNo2"), xRow)
            If getColumnIndex(spr, "QtyNo3") > -1 Then z1312.QtyNo3 = getDataM(spr, getColumnIndex(spr, "QtyNo3"), xRow)
            If getColumnIndex(spr, "QtyGW") > -1 Then z1312.QtyGW = getDataM(spr, getColumnIndex(spr, "QtyGW"), xRow)
            If getColumnIndex(spr, "QtyNW") > -1 Then z1312.QtyNW = getDataM(spr, getColumnIndex(spr, "QtyNW"), xRow)
            If getColumnIndex(spr, "QtyPcsPoly") > -1 Then z1312.QtyPcsPoly = getDataM(spr, getColumnIndex(spr, "QtyPcsPoly"), xRow)
            If getColumnIndex(spr, "QtyPolyCTN") > -1 Then z1312.QtyPolyCTN = getDataM(spr, getColumnIndex(spr, "QtyPolyCTN"), xRow)
            If getColumnIndex(spr, "QtyPcsCTN") > -1 Then z1312.QtyPcsCTN = getDataM(spr, getColumnIndex(spr, "QtyPcsCTN"), xRow)
            If getColumnIndex(spr, "QtyPcsPINO") > -1 Then z1312.QtyPcsPINO = getDataM(spr, getColumnIndex(spr, "QtyPcsPINO"), xRow)
            If getColumnIndex(spr, "PriceExchange") > -1 Then z1312.PriceExchange = getDataM(spr, getColumnIndex(spr, "PriceExchange"), xRow)
            If getColumnIndex(spr, "CheckFOB") > -1 Then z1312.CheckFOB = getDataM(spr, getColumnIndex(spr, "CheckFOB"), xRow)
            If getColumnIndex(spr, "PriceOrderFOB") > -1 Then z1312.PriceOrderFOB = getDataM(spr, getColumnIndex(spr, "PriceOrderFOB"), xRow)
            If getColumnIndex(spr, "TotalAMTFOB") > -1 Then z1312.TotalAMTFOB = getDataM(spr, getColumnIndex(spr, "TotalAMTFOB"), xRow)
            If getColumnIndex(spr, "PriceOrder") > -1 Then z1312.PriceOrder = getDataM(spr, getColumnIndex(spr, "PriceOrder"), xRow)
            If getColumnIndex(spr, "PriceOrder1") > -1 Then z1312.PriceOrder1 = getDataM(spr, getColumnIndex(spr, "PriceOrder1"), xRow)
            If getColumnIndex(spr, "PriceOrder2") > -1 Then z1312.PriceOrder2 = getDataM(spr, getColumnIndex(spr, "PriceOrder2"), xRow)
            If getColumnIndex(spr, "PriceOrder3") > -1 Then z1312.PriceOrder3 = getDataM(spr, getColumnIndex(spr, "PriceOrder3"), xRow)
            If getColumnIndex(spr, "seUnitPrice") > -1 Then z1312.seUnitPrice = getDataM(spr, getColumnIndex(spr, "seUnitPrice"), xRow)
            If getColumnIndex(spr, "cdUnitPrice") > -1 Then z1312.cdUnitPrice = getDataM(spr, getColumnIndex(spr, "cdUnitPrice"), xRow)
            If getColumnIndex(spr, "UnitPrice") > -1 Then z1312.UnitPrice = getDataM(spr, getColumnIndex(spr, "UnitPrice"), xRow)
            If getColumnIndex(spr, "PriceOrderEX") > -1 Then z1312.PriceOrderEX = getDataM(spr, getColumnIndex(spr, "PriceOrderEX"), xRow)
            If getColumnIndex(spr, "PriceOrderVND") > -1 Then z1312.PriceOrderVND = getDataM(spr, getColumnIndex(spr, "PriceOrderVND"), xRow)
            If getColumnIndex(spr, "Datedelivery") > -1 Then z1312.Datedelivery = getDataM(spr, getColumnIndex(spr, "Datedelivery"), xRow)
            If getColumnIndex(spr, "DateTransfer") > -1 Then z1312.DateTransfer = getDataM(spr, getColumnIndex(spr, "DateTransfer"), xRow)
            If getColumnIndex(spr, "AcceptedOrder") > -1 Then z1312.AcceptedOrder = getDataM(spr, getColumnIndex(spr, "AcceptedOrder"), xRow)
            If getColumnIndex(spr, "MaterialStatus") > -1 Then z1312.MaterialStatus = getDataM(spr, getColumnIndex(spr, "MaterialStatus"), xRow)
            If getColumnIndex(spr, "SoleStatus") > -1 Then z1312.SoleStatus = getDataM(spr, getColumnIndex(spr, "SoleStatus"), xRow)
            If getColumnIndex(spr, "DateLable") > -1 Then z1312.DateLable = getDataM(spr, getColumnIndex(spr, "DateLable"), xRow)
            If getColumnIndex(spr, "DatePattern") > -1 Then z1312.DatePattern = getDataM(spr, getColumnIndex(spr, "DatePattern"), xRow)
            If getColumnIndex(spr, "DateMaterial") > -1 Then z1312.DateMaterial = getDataM(spr, getColumnIndex(spr, "DateMaterial"), xRow)
            If getColumnIndex(spr, "DatePlanning") > -1 Then z1312.DatePlanning = getDataM(spr, getColumnIndex(spr, "DatePlanning"), xRow)
            If getColumnIndex(spr, "DateRnD") > -1 Then z1312.DateRnD = getDataM(spr, getColumnIndex(spr, "DateRnD"), xRow)
            If getColumnIndex(spr, "DateFitting") > -1 Then z1312.DateFitting = getDataM(spr, getColumnIndex(spr, "DateFitting"), xRow)
            If getColumnIndex(spr, "InchargeFitting") > -1 Then z1312.InchargeFitting = getDataM(spr, getColumnIndex(spr, "InchargeFitting"), xRow)
            If getColumnIndex(spr, "CheckFitting") > -1 Then z1312.CheckFitting = getDataM(spr, getColumnIndex(spr, "CheckFitting"), xRow)
            If getColumnIndex(spr, "DateTesting") > -1 Then z1312.DateTesting = getDataM(spr, getColumnIndex(spr, "DateTesting"), xRow)
            If getColumnIndex(spr, "InchargeTesting") > -1 Then z1312.InchargeTesting = getDataM(spr, getColumnIndex(spr, "InchargeTesting"), xRow)
            If getColumnIndex(spr, "CheckTesting") > -1 Then z1312.CheckTesting = getDataM(spr, getColumnIndex(spr, "CheckTesting"), xRow)
            If getColumnIndex(spr, "CheckConfirm") > -1 Then z1312.CheckConfirm = getDataM(spr, getColumnIndex(spr, "CheckConfirm"), xRow)
            If getColumnIndex(spr, "DateConfirm") > -1 Then z1312.DateConfirm = getDataM(spr, getColumnIndex(spr, "DateConfirm"), xRow)
            If getColumnIndex(spr, "InchargeRD1") > -1 Then z1312.InchargeRD1 = getDataM(spr, getColumnIndex(spr, "InchargeRD1"), xRow)
            If getColumnIndex(spr, "InchargeRD2") > -1 Then z1312.InchargeRD2 = getDataM(spr, getColumnIndex(spr, "InchargeRD2"), xRow)
            If getColumnIndex(spr, "InchargeRD3") > -1 Then z1312.InchargeRD3 = getDataM(spr, getColumnIndex(spr, "InchargeRD3"), xRow)
            If getColumnIndex(spr, "InchargeRD4") > -1 Then z1312.InchargeRD4 = getDataM(spr, getColumnIndex(spr, "InchargeRD4"), xRow)
            If getColumnIndex(spr, "DateSRD1") > -1 Then z1312.DateSRD1 = getDataM(spr, getColumnIndex(spr, "DateSRD1"), xRow)
            If getColumnIndex(spr, "DateERD1") > -1 Then z1312.DateERD1 = getDataM(spr, getColumnIndex(spr, "DateERD1"), xRow)
            If getColumnIndex(spr, "DateSRD2") > -1 Then z1312.DateSRD2 = getDataM(spr, getColumnIndex(spr, "DateSRD2"), xRow)
            If getColumnIndex(spr, "DateERD2") > -1 Then z1312.DateERD2 = getDataM(spr, getColumnIndex(spr, "DateERD2"), xRow)
            If getColumnIndex(spr, "DateSRD3") > -1 Then z1312.DateSRD3 = getDataM(spr, getColumnIndex(spr, "DateSRD3"), xRow)
            If getColumnIndex(spr, "DateERD3") > -1 Then z1312.DateERD3 = getDataM(spr, getColumnIndex(spr, "DateERD3"), xRow)
            If getColumnIndex(spr, "DateSRD4") > -1 Then z1312.DateSRD4 = getDataM(spr, getColumnIndex(spr, "DateSRD4"), xRow)
            If getColumnIndex(spr, "DateERD4") > -1 Then z1312.DateERD4 = getDataM(spr, getColumnIndex(spr, "DateERD4"), xRow)
            If getColumnIndex(spr, "SpecNo") > -1 Then z1312.SpecNo = getDataM(spr, getColumnIndex(spr, "SpecNo"), xRow)
            If getColumnIndex(spr, "SpecNoSeq") > -1 Then z1312.SpecNoSeq = getDataM(spr, getColumnIndex(spr, "SpecNoSeq"), xRow)
            If getColumnIndex(spr, "DateSole") > -1 Then z1312.DateSole = getDataM(spr, getColumnIndex(spr, "DateSole"), xRow)
            If getColumnIndex(spr, "DateCutting") > -1 Then z1312.DateCutting = getDataM(spr, getColumnIndex(spr, "DateCutting"), xRow)
            If getColumnIndex(spr, "DateStitching") > -1 Then z1312.DateStitching = getDataM(spr, getColumnIndex(spr, "DateStitching"), xRow)
            If getColumnIndex(spr, "DateStockfit") > -1 Then z1312.DateStockfit = getDataM(spr, getColumnIndex(spr, "DateStockfit"), xRow)
            If getColumnIndex(spr, "DateAssmbly") > -1 Then z1312.DateAssmbly = getDataM(spr, getColumnIndex(spr, "DateAssmbly"), xRow)
            If getColumnIndex(spr, "DateShipping") > -1 Then z1312.DateShipping = getDataM(spr, getColumnIndex(spr, "DateShipping"), xRow)
            If getColumnIndex(spr, "seUnitMaterial") > -1 Then z1312.seUnitMaterial = getDataM(spr, getColumnIndex(spr, "seUnitMaterial"), xRow)
            If getColumnIndex(spr, "cdUnitMaterial") > -1 Then z1312.cdUnitMaterial = getDataM(spr, getColumnIndex(spr, "cdUnitMaterial"), xRow)
            If getColumnIndex(spr, "seUnitPacking") > -1 Then z1312.seUnitPacking = getDataM(spr, getColumnIndex(spr, "seUnitPacking"), xRow)
            If getColumnIndex(spr, "cdUnitPacking") > -1 Then z1312.cdUnitPacking = getDataM(spr, getColumnIndex(spr, "cdUnitPacking"), xRow)
            If getColumnIndex(spr, "QtyOrderSample") > -1 Then z1312.QtyOrderSample = getDataM(spr, getColumnIndex(spr, "QtyOrderSample"), xRow)
            If getColumnIndex(spr, "QtyOrderSample01") > -1 Then z1312.QtyOrderSample01 = getDataM(spr, getColumnIndex(spr, "QtyOrderSample01"), xRow)
            If getColumnIndex(spr, "QtyOrderSample02") > -1 Then z1312.QtyOrderSample02 = getDataM(spr, getColumnIndex(spr, "QtyOrderSample02"), xRow)
            If getColumnIndex(spr, "QtyOrder") > -1 Then z1312.QtyOrder = getDataM(spr, getColumnIndex(spr, "QtyOrder"), xRow)
            If getColumnIndex(spr, "QtyJob") > -1 Then z1312.QtyJob = getDataM(spr, getColumnIndex(spr, "QtyJob"), xRow)
            If getColumnIndex(spr, "QtySole") > -1 Then z1312.QtySole = getDataM(spr, getColumnIndex(spr, "QtySole"), xRow)
            If getColumnIndex(spr, "QtyCutting") > -1 Then z1312.QtyCutting = getDataM(spr, getColumnIndex(spr, "QtyCutting"), xRow)
            If getColumnIndex(spr, "QtyStitching") > -1 Then z1312.QtyStitching = getDataM(spr, getColumnIndex(spr, "QtyStitching"), xRow)
            If getColumnIndex(spr, "QtyStockfit") > -1 Then z1312.QtyStockfit = getDataM(spr, getColumnIndex(spr, "QtyStockfit"), xRow)
            If getColumnIndex(spr, "QtyAssembly") > -1 Then z1312.QtyAssembly = getDataM(spr, getColumnIndex(spr, "QtyAssembly"), xRow)
            If getColumnIndex(spr, "QtyPacking") > -1 Then z1312.QtyPacking = getDataM(spr, getColumnIndex(spr, "QtyPacking"), xRow)
            If getColumnIndex(spr, "QtyInbound") > -1 Then z1312.QtyInbound = getDataM(spr, getColumnIndex(spr, "QtyInbound"), xRow)
            If getColumnIndex(spr, "QtyShipping") > -1 Then z1312.QtyShipping = getDataM(spr, getColumnIndex(spr, "QtyShipping"), xRow)
            If getColumnIndex(spr, "TimeInsert") > -1 Then z1312.TimeInsert = getDataM(spr, getColumnIndex(spr, "TimeInsert"), xRow)
            If getColumnIndex(spr, "TimeUpdate") > -1 Then z1312.TimeUpdate = getDataM(spr, getColumnIndex(spr, "TimeUpdate"), xRow)
            If getColumnIndex(spr, "DateInsert") > -1 Then z1312.DateInsert = getDataM(spr, getColumnIndex(spr, "DateInsert"), xRow)
            If getColumnIndex(spr, "InchargeInsert") > -1 Then z1312.InchargeInsert = getDataM(spr, getColumnIndex(spr, "InchargeInsert"), xRow)
            If getColumnIndex(spr, "DateUpdate") > -1 Then z1312.DateUpdate = getDataM(spr, getColumnIndex(spr, "DateUpdate"), xRow)
            If getColumnIndex(spr, "InchargeUpdate") > -1 Then z1312.InchargeUpdate = getDataM(spr, getColumnIndex(spr, "InchargeUpdate"), xRow)
            If getColumnIndex(spr, "InchargeSales") > -1 Then z1312.InchargeSales = getDataM(spr, getColumnIndex(spr, "InchargeSales"), xRow)
            If getColumnIndex(spr, "InchargePPC") > -1 Then z1312.InchargePPC = getDataM(spr, getColumnIndex(spr, "InchargePPC"), xRow)
            If getColumnIndex(spr, "TotalQty") > -1 Then z1312.TotalQty = getDataM(spr, getColumnIndex(spr, "TotalQty"), xRow)
            If getColumnIndex(spr, "TotalAMT") > -1 Then z1312.TotalAMT = getDataM(spr, getColumnIndex(spr, "TotalAMT"), xRow)
            If getColumnIndex(spr, "TotalCost") > -1 Then z1312.TotalCost = getDataM(spr, getColumnIndex(spr, "TotalCost"), xRow)
            If getColumnIndex(spr, "TotalProfit") > -1 Then z1312.TotalProfit = getDataM(spr, getColumnIndex(spr, "TotalProfit"), xRow)
            If getColumnIndex(spr, "TotalAMTEX") > -1 Then z1312.TotalAMTEX = getDataM(spr, getColumnIndex(spr, "TotalAMTEX"), xRow)
            If getColumnIndex(spr, "TotalAMTVND") > -1 Then z1312.TotalAMTVND = getDataM(spr, getColumnIndex(spr, "TotalAMTVND"), xRow)
            If getColumnIndex(spr, "TotalCostEX") > -1 Then z1312.TotalCostEX = getDataM(spr, getColumnIndex(spr, "TotalCostEX"), xRow)
            If getColumnIndex(spr, "TotalCostVND") > -1 Then z1312.TotalCostVND = getDataM(spr, getColumnIndex(spr, "TotalCostVND"), xRow)
            If getColumnIndex(spr, "TotalProfitEX") > -1 Then z1312.TotalProfitEX = getDataM(spr, getColumnIndex(spr, "TotalProfitEX"), xRow)
            If getColumnIndex(spr, "TotalProfitVND") > -1 Then z1312.TotalProfitVND = getDataM(spr, getColumnIndex(spr, "TotalProfitVND"), xRow)
            If getColumnIndex(spr, "AttachID") > -1 Then z1312.AttachID = getDataM(spr, getColumnIndex(spr, "AttachID"), xRow)
            If getColumnIndex(spr, "DateSync") > -1 Then z1312.DateSync = getDataM(spr, getColumnIndex(spr, "DateSync"), xRow)
            If getColumnIndex(spr, "CheckSync") > -1 Then z1312.CheckSync = getDataM(spr, getColumnIndex(spr, "CheckSync"), xRow)
            If getColumnIndex(spr, "PINo") > -1 Then z1312.PINo = getDataM(spr, getColumnIndex(spr, "PINo"), xRow)
            If getColumnIndex(spr, "CheckSizeGroup") > -1 Then z1312.CheckSizeGroup = getDataM(spr, getColumnIndex(spr, "CheckSizeGroup"), xRow)
            If getColumnIndex(spr, "OrderNoRef") > -1 Then z1312.OrderNoRef = getDataM(spr, getColumnIndex(spr, "OrderNoRef"), xRow)
            If getColumnIndex(spr, "OrderNoSeqRef") > -1 Then z1312.OrderNoSeqRef = getDataM(spr, getColumnIndex(spr, "OrderNoSeqRef"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z1312.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)
            If getColumnIndex(spr, "RemarkOrder") > -1 Then z1312.RemarkOrder = getDataM(spr, getColumnIndex(spr, "RemarkOrder"), xRow)
            If getColumnIndex(spr, "RemarkCustomer") > -1 Then z1312.RemarkCustomer = getDataM(spr, getColumnIndex(spr, "RemarkCustomer"), xRow)
            If getColumnIndex(spr, "RemarkOther") > -1 Then z1312.RemarkOther = getDataM(spr, getColumnIndex(spr, "RemarkOther"), xRow)
            If getColumnIndex(spr, "RemarkTrading") > -1 Then z1312.RemarkTrading = getDataM(spr, getColumnIndex(spr, "RemarkTrading"), xRow)
            If getColumnIndex(spr, "seSite") > -1 Then z1312.seSite = getDataM(spr, getColumnIndex(spr, "seSite"), xRow)
            If getColumnIndex(spr, "cdSite") > -1 Then z1312.cdSite = getDataM(spr, getColumnIndex(spr, "cdSite"), xRow)
            If getColumnIndex(spr, "LicenseName") > -1 Then z1312.LicenseName = getDataM(spr, getColumnIndex(spr, "LicenseName"), xRow)
            If getColumnIndex(spr, "TestStandard") > -1 Then z1312.TestStandard = getDataM(spr, getColumnIndex(spr, "TestStandard"), xRow)
            If getColumnIndex(spr, "TestNo") > -1 Then z1312.TestNo = getDataM(spr, getColumnIndex(spr, "TestNo"), xRow)
            If getColumnIndex(spr, "DateReport") > -1 Then z1312.DateReport = getDataM(spr, getColumnIndex(spr, "DateReport"), xRow)
            If getColumnIndex(spr, "InvoiceStatus") > -1 Then z1312.InvoiceStatus = getDataM(spr, getColumnIndex(spr, "InvoiceStatus"), xRow)
            If getColumnIndex(spr, "WIPStatus") > -1 Then z1312.WIPStatus = getDataM(spr, getColumnIndex(spr, "WIPStatus"), xRow)
            If getColumnIndex(spr, "WIPDate") > -1 Then z1312.WIPDate = getDataM(spr, getColumnIndex(spr, "WIPDate"), xRow)
            If getColumnIndex(spr, "WIPNo") > -1 Then z1312.WIPNo = getDataM(spr, getColumnIndex(spr, "WIPNo"), xRow)
            If getColumnIndex(spr, "ExportCode") > -1 Then z1312.ExportCode = getDataM(spr, getColumnIndex(spr, "ExportCode"), xRow)
            If getColumnIndex(spr, "ExportName") > -1 Then z1312.ExportName = getDataM(spr, getColumnIndex(spr, "ExportName"), xRow)


        Catch ex As Exception

        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K1312_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z1312 As T1312_AREA, Job As String, OrderNo As String, OrderNoSeq As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K1312_MOVE = False

        Try
            If READ_PFK1312(OrderNo, OrderNoSeq) = True Then
                z1312 = D1312
                K1312_MOVE = True
            Else
                z1312 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1312")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = IIf(Children(i).Name.Contains("_"), Children(i).Name.Substring(Children(i).Name.IndexOf("_") + 1), Children(i).Name)
                temp1 = temp1.ToUpper
                Try
                    If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                        Select Case temp1
                            Case "ORDERNO" : z1312.OrderNo = Children(i).Code
                            Case "ORDERNOSEQ" : z1312.OrderNoSeq = Children(i).Code
                            Case "PRNAME" : z1312.PRName = Children(i).Code
                            Case "TIMEREVISEAPT" : z1312.TimeReviseApt = Children(i).Code
                            Case "TIMEREVISEPRT" : z1312.TimeRevisePrt = Children(i).Code
                            Case "TIMEREVISE" : z1312.TimeRevise = Children(i).Code
                            Case "TIMERNDREVISE" : z1312.TimeRnDRevise = Children(i).Code
                            Case "TIMESALESREVISE" : z1312.TimeSalesRevise = Children(i).Code
                            Case "INCHARGEREVISE" : z1312.InchargeRevise = Children(i).Code
                            Case "REVISENO" : z1312.ReviseNo = Children(i).Code
                            Case "SHOESCODE" : z1312.ShoesCode = Children(i).Code
                            Case "SHOESCODEFIN" : z1312.ShoesCodeFin = Children(i).Code
                            Case "FACPO" : z1312.FacPO = Children(i).Code
                            Case "SLNOSYS" : z1312.SLNoSys = Children(i).Code
                            Case "SLNO" : z1312.SLNo = Children(i).Code
                            Case "PONO" : z1312.PONO = Children(i).Code
                            Case "CPONO" : z1312.CPONO = Children(i).Code
                            Case "CUSTOMERCODE" : z1312.CustomerCode = Children(i).Code
                            Case "CUSTOMERNAME" : z1312.CustomerName = Children(i).Code
                            Case "COUNTRY" : z1312.Country = Children(i).Code
                            Case "DESTINATION" : z1312.Destination = Children(i).Code
                            Case "FINALSHOP" : z1312.FinalShop = Children(i).Code
                            Case "PKO" : z1312.PKO = Children(i).Code
                            Case "DATEPO" : z1312.DatePO = Children(i).Code
                            Case "JBCARD" : z1312.JbCard = Children(i).Code
                            Case "SEPACKINGCODE" : z1312.sePackingCode = Children(i).Code
                            Case "CDPACKINGCODE" : z1312.cdPackingCode = Children(i).Code
                            Case "SESPECSTATUS" : z1312.seSpecStatus = Children(i).Code
                            Case "CDSPECSTATUS" : z1312.cdSpecStatus = Children(i).Code
                            Case "SIZERANGE" : z1312.SizeRange = Children(i).Code
                            Case "SPECITICSIZE" : z1312.SpeciticSize = Children(i).Code
                            Case "DATESIZE" : z1312.DateSize = Children(i).Code
                            Case "ORDERDETAILSTATUS" : z1312.OrderDetailStatus = Children(i).Code
                            Case "DATEORDER" : z1312.DateOrder = Children(i).Code
                            Case "DATEAPPROVAL" : z1312.DateApproval = Children(i).Code
                            Case "DATECL" : z1312.DateCL = Children(i).Code
                            Case "DATECANCEL" : z1312.DateCancel = Children(i).Code
                            Case "REMARKCANCEL" : z1312.RemarkCancel = Children(i).Code
                            Case "DATECOMPLETE" : z1312.DateComplete = Children(i).Code
                            Case "DATEPENDING" : z1312.DatePending = Children(i).Code
                            Case "DATEPENDING2" : z1312.DatePending2 = Children(i).Code
                            Case "DATEEXCHANGEPRICE" : z1312.DateExchangePrice = Children(i).Code
                            Case "SIZEW" : z1312.SizeW = Children(i).Code
                            Case "SIZEL" : z1312.SizeL = Children(i).Code
                            Case "SIZEH" : z1312.SizeH = Children(i).Code
                            Case "QTYNO1" : z1312.QtyNo1 = Children(i).Code
                            Case "QTYNO2" : z1312.QtyNo2 = Children(i).Code
                            Case "QTYNO3" : z1312.QtyNo3 = Children(i).Code
                            Case "QTYGW" : z1312.QtyGW = Children(i).Code
                            Case "QTYNW" : z1312.QtyNW = Children(i).Code
                            Case "QTYPCSPOLY" : z1312.QtyPcsPoly = Children(i).Code
                            Case "QTYPOLYCTN" : z1312.QtyPolyCTN = Children(i).Code
                            Case "QTYPCSCTN" : z1312.QtyPcsCTN = Children(i).Code
                            Case "QTYPCSPINO" : z1312.QtyPcsPINO = Children(i).Code
                            Case "PRICEEXCHANGE" : z1312.PriceExchange = Children(i).Code
                            Case "CHECKFOB" : z1312.CheckFOB = Children(i).Code
                            Case "PRICEORDERFOB" : z1312.PriceOrderFOB = Children(i).Code
                            Case "TOTALAMTFOB" : z1312.TotalAMTFOB = Children(i).Code
                            Case "PRICEORDER" : z1312.PriceOrder = Children(i).Code
                            Case "PRICEORDER1" : z1312.PriceOrder1 = Children(i).Code
                            Case "PRICEORDER2" : z1312.PriceOrder2 = Children(i).Code
                            Case "PRICEORDER3" : z1312.PriceOrder3 = Children(i).Code
                            Case "SEUNITPRICE" : z1312.seUnitPrice = Children(i).Code
                            Case "CDUNITPRICE" : z1312.cdUnitPrice = Children(i).Code
                            Case "UNITPRICE" : z1312.UnitPrice = Children(i).Code
                            Case "PRICEORDEREX" : z1312.PriceOrderEX = Children(i).Code
                            Case "PRICEORDERVND" : z1312.PriceOrderVND = Children(i).Code
                            Case "DATEDELIVERY" : z1312.Datedelivery = Children(i).Code
                            Case "DATETRANSFER" : z1312.DateTransfer = Children(i).Code
                            Case "ACCEPTEDORDER" : z1312.AcceptedOrder = Children(i).Code
                            Case "MATERIALSTATUS" : z1312.MaterialStatus = Children(i).Code
                            Case "SOLESTATUS" : z1312.SoleStatus = Children(i).Code
                            Case "DATELABLE" : z1312.DateLable = Children(i).Code
                            Case "DATEPATTERN" : z1312.DatePattern = Children(i).Code
                            Case "DATEMATERIAL" : z1312.DateMaterial = Children(i).Code
                            Case "DATEPLANNING" : z1312.DatePlanning = Children(i).Code
                            Case "DATERND" : z1312.DateRnD = Children(i).Code
                            Case "DATEFITTING" : z1312.DateFitting = Children(i).Code
                            Case "INCHARGEFITTING" : z1312.InchargeFitting = Children(i).Code
                            Case "CHECKFITTING" : z1312.CheckFitting = Children(i).Code
                            Case "DATETESTING" : z1312.DateTesting = Children(i).Code
                            Case "INCHARGETESTING" : z1312.InchargeTesting = Children(i).Code
                            Case "CHECKTESTING" : z1312.CheckTesting = Children(i).Code
                            Case "CHECKCONFIRM" : z1312.CheckConfirm = Children(i).Code
                            Case "DATECONFIRM" : z1312.DateConfirm = Children(i).Code
                            Case "INCHARGERD1" : z1312.InchargeRD1 = Children(i).Code
                            Case "INCHARGERD2" : z1312.InchargeRD2 = Children(i).Code
                            Case "INCHARGERD3" : z1312.InchargeRD3 = Children(i).Code
                            Case "INCHARGERD4" : z1312.InchargeRD4 = Children(i).Code
                            Case "DATESRD1" : z1312.DateSRD1 = Children(i).Code
                            Case "DATEERD1" : z1312.DateERD1 = Children(i).Code
                            Case "DATESRD2" : z1312.DateSRD2 = Children(i).Code
                            Case "DATEERD2" : z1312.DateERD2 = Children(i).Code
                            Case "DATESRD3" : z1312.DateSRD3 = Children(i).Code
                            Case "DATEERD3" : z1312.DateERD3 = Children(i).Code
                            Case "DATESRD4" : z1312.DateSRD4 = Children(i).Code
                            Case "DATEERD4" : z1312.DateERD4 = Children(i).Code
                            Case "SPECNO" : z1312.SpecNo = Children(i).Code
                            Case "SPECNOSEQ" : z1312.SpecNoSeq = Children(i).Code
                            Case "DATESOLE" : z1312.DateSole = Children(i).Code
                            Case "DATECUTTING" : z1312.DateCutting = Children(i).Code
                            Case "DATESTITCHING" : z1312.DateStitching = Children(i).Code
                            Case "DATESTOCKFIT" : z1312.DateStockfit = Children(i).Code
                            Case "DATEASSMBLY" : z1312.DateAssmbly = Children(i).Code
                            Case "DATESHIPPING" : z1312.DateShipping = Children(i).Code
                            Case "SEUNITMATERIAL" : z1312.seUnitMaterial = Children(i).Code
                            Case "CDUNITMATERIAL" : z1312.cdUnitMaterial = Children(i).Code
                            Case "SEUNITPACKING" : z1312.seUnitPacking = Children(i).Code
                            Case "CDUNITPACKING" : z1312.cdUnitPacking = Children(i).Code
                            Case "QTYORDERSAMPLE" : z1312.QtyOrderSample = Children(i).Code
                            Case "QTYORDERSAMPLE01" : z1312.QtyOrderSample01 = Children(i).Code
                            Case "QTYORDERSAMPLE02" : z1312.QtyOrderSample02 = Children(i).Code
                            Case "QTYORDER" : z1312.QtyOrder = Children(i).Code
                            Case "QTYJOB" : z1312.QtyJob = Children(i).Code
                            Case "QTYSOLE" : z1312.QtySole = Children(i).Code
                            Case "QTYCUTTING" : z1312.QtyCutting = Children(i).Code
                            Case "QTYSTITCHING" : z1312.QtyStitching = Children(i).Code
                            Case "QTYSTOCKFIT" : z1312.QtyStockfit = Children(i).Code
                            Case "QTYASSEMBLY" : z1312.QtyAssembly = Children(i).Code
                            Case "QTYPACKING" : z1312.QtyPacking = Children(i).Code
                            Case "QTYINBOUND" : z1312.QtyInbound = Children(i).Code
                            Case "QTYSHIPPING" : z1312.QtyShipping = Children(i).Code
                            Case "TIMEINSERT" : z1312.TimeInsert = Children(i).Code
                            Case "TIMEUPDATE" : z1312.TimeUpdate = Children(i).Code
                            Case "DATEINSERT" : z1312.DateInsert = Children(i).Code
                            Case "INCHARGEINSERT" : z1312.InchargeInsert = Children(i).Code
                            Case "DATEUPDATE" : z1312.DateUpdate = Children(i).Code
                            Case "INCHARGEUPDATE" : z1312.InchargeUpdate = Children(i).Code
                            Case "INCHARGESALES" : z1312.InchargeSales = Children(i).Code
                            Case "INCHARGEPPC" : z1312.InchargePPC = Children(i).Code
                            Case "TOTALQTY" : z1312.TotalQty = Children(i).Code
                            Case "TOTALAMT" : z1312.TotalAMT = Children(i).Code
                            Case "TOTALCOST" : z1312.TotalCost = Children(i).Code
                            Case "TOTALPROFIT" : z1312.TotalProfit = Children(i).Code
                            Case "TOTALAMTEX" : z1312.TotalAMTEX = Children(i).Code
                            Case "TOTALAMTVND" : z1312.TotalAMTVND = Children(i).Code
                            Case "TOTALCOSTEX" : z1312.TotalCostEX = Children(i).Code
                            Case "TOTALCOSTVND" : z1312.TotalCostVND = Children(i).Code
                            Case "TOTALPROFITEX" : z1312.TotalProfitEX = Children(i).Code
                            Case "TOTALPROFITVND" : z1312.TotalProfitVND = Children(i).Code
                            Case "ATTACHID" : z1312.AttachID = Children(i).Code
                            Case "DATESYNC" : z1312.DateSync = Children(i).Code
                            Case "CHECKSYNC" : z1312.CheckSync = Children(i).Code
                            Case "PINO" : z1312.PINo = Children(i).Code
                            Case "CHECKSIZEGROUP" : z1312.CheckSizeGroup = Children(i).Code
                            Case "ORDERNOREF" : z1312.OrderNoRef = Children(i).Code
                            Case "ORDERNOSEQREF" : z1312.OrderNoSeqRef = Children(i).Code
                            Case "REMARK" : z1312.Remark = Children(i).Code
                            Case "REMARKORDER" : z1312.RemarkOrder = Children(i).Code
                            Case "REMARKCUSTOMER" : z1312.RemarkCustomer = Children(i).Code
                            Case "REMARKOTHER" : z1312.RemarkOther = Children(i).Code
                            Case "REMARKTRADING" : z1312.RemarkTrading = Children(i).Code
                            Case "SESITE" : z1312.seSite = Children(i).Code
                            Case "CDSITE" : z1312.cdSite = Children(i).Code
                            Case "LICENSENAME" : z1312.LicenseName = Children(i).Code
                            Case "TESTSTANDARD" : z1312.TestStandard = Children(i).Code
                            Case "TESTNO" : z1312.TestNo = Children(i).Code
                            Case "DATEREPORT" : z1312.DateReport = Children(i).Code
                            Case "INVOICESTATUS" : z1312.InvoiceStatus = Children(i).Code
                            Case "WIPSTATUS" : z1312.WIPStatus = Children(i).Code
                            Case "WIPDATE" : z1312.WIPDate = Children(i).Code
                            Case "WIPNO" : z1312.WIPNo = Children(i).Code
                            Case "EXPORTCODE" : z1312.ExportCode = Children(i).Code
                            Case "EXPORTNAME" : z1312.ExportName = Children(i).Code

                        End Select
                    Else
                        Select Case temp1
                            Case "ORDERNO" : z1312.OrderNo = Children(i).Data
                            Case "ORDERNOSEQ" : z1312.OrderNoSeq = Children(i).Data
                            Case "PRNAME" : z1312.PRName = Children(i).Data
                            Case "TIMEREVISEAPT" : z1312.TimeReviseApt = Children(i).Data
                            Case "TIMEREVISEPRT" : z1312.TimeRevisePrt = Children(i).Data
                            Case "TIMEREVISE" : z1312.TimeRevise = Children(i).Data
                            Case "TIMERNDREVISE" : z1312.TimeRnDRevise = Children(i).Data
                            Case "TIMESALESREVISE" : z1312.TimeSalesRevise = Children(i).Data
                            Case "INCHARGEREVISE" : z1312.InchargeRevise = Children(i).Data
                            Case "REVISENO" : z1312.ReviseNo = Children(i).Data
                            Case "SHOESCODE" : z1312.ShoesCode = Children(i).Data
                            Case "SHOESCODEFIN" : z1312.ShoesCodeFin = Children(i).Data
                            Case "FACPO" : z1312.FacPO = Children(i).Data
                            Case "SLNOSYS" : z1312.SLNoSys = Children(i).Data
                            Case "SLNO" : z1312.SLNo = Children(i).Data
                            Case "PONO" : z1312.PONO = Children(i).Data
                            Case "CPONO" : z1312.CPONO = Children(i).Data
                            Case "CUSTOMERCODE" : z1312.CustomerCode = Children(i).Data
                            Case "CUSTOMERNAME" : z1312.CustomerName = Children(i).Data
                            Case "COUNTRY" : z1312.Country = Children(i).Data
                            Case "DESTINATION" : z1312.Destination = Children(i).Data
                            Case "FINALSHOP" : z1312.FinalShop = Children(i).Data
                            Case "PKO" : z1312.PKO = Children(i).Data
                            Case "DATEPO" : z1312.DatePO = Children(i).Data
                            Case "JBCARD" : z1312.JbCard = Children(i).Data
                            Case "SEPACKINGCODE" : z1312.sePackingCode = Children(i).Data
                            Case "CDPACKINGCODE" : z1312.cdPackingCode = Children(i).Data
                            Case "SESPECSTATUS" : z1312.seSpecStatus = Children(i).Data
                            Case "CDSPECSTATUS" : z1312.cdSpecStatus = Children(i).Data
                            Case "SIZERANGE" : z1312.SizeRange = Children(i).Data
                            Case "SPECITICSIZE" : z1312.SpeciticSize = Children(i).Data
                            Case "DATESIZE" : z1312.DateSize = Children(i).Data
                            Case "ORDERDETAILSTATUS" : z1312.OrderDetailStatus = Children(i).Data
                            Case "DATEORDER" : z1312.DateOrder = Children(i).Data
                            Case "DATEAPPROVAL" : z1312.DateApproval = Children(i).Data
                            Case "DATECL" : z1312.DateCL = Children(i).Data
                            Case "DATECANCEL" : z1312.DateCancel = Children(i).Data
                            Case "REMARKCANCEL" : z1312.RemarkCancel = Children(i).Data
                            Case "DATECOMPLETE" : z1312.DateComplete = Children(i).Data
                            Case "DATEPENDING" : z1312.DatePending = Children(i).Data
                            Case "DATEPENDING2" : z1312.DatePending2 = Children(i).Data
                            Case "DATEEXCHANGEPRICE" : z1312.DateExchangePrice = Children(i).Data
                            Case "SIZEW" : z1312.SizeW = Children(i).Data
                            Case "SIZEL" : z1312.SizeL = Children(i).Data
                            Case "SIZEH" : z1312.SizeH = Children(i).Data
                            Case "QTYNO1" : z1312.QtyNo1 = Children(i).Data
                            Case "QTYNO2" : z1312.QtyNo2 = Children(i).Data
                            Case "QTYNO3" : z1312.QtyNo3 = Children(i).Data
                            Case "QTYGW" : z1312.QtyGW = Children(i).Data
                            Case "QTYNW" : z1312.QtyNW = Children(i).Data
                            Case "QTYPCSPOLY" : z1312.QtyPcsPoly = Children(i).Data
                            Case "QTYPOLYCTN" : z1312.QtyPolyCTN = Children(i).Data
                            Case "QTYPCSCTN" : z1312.QtyPcsCTN = Children(i).Data
                            Case "QTYPCSPINO" : z1312.QtyPcsPINO = Children(i).Data
                            Case "PRICEEXCHANGE" : z1312.PriceExchange = Children(i).Data
                            Case "CHECKFOB" : z1312.CheckFOB = Children(i).Data
                            Case "PRICEORDERFOB" : z1312.PriceOrderFOB = Children(i).Data
                            Case "TOTALAMTFOB" : z1312.TotalAMTFOB = Children(i).Data
                            Case "PRICEORDER" : z1312.PriceOrder = Children(i).Data
                            Case "PRICEORDER1" : z1312.PriceOrder1 = Children(i).Data
                            Case "PRICEORDER2" : z1312.PriceOrder2 = Children(i).Data
                            Case "PRICEORDER3" : z1312.PriceOrder3 = Children(i).Data
                            Case "SEUNITPRICE" : z1312.seUnitPrice = Children(i).Data
                            Case "CDUNITPRICE" : z1312.cdUnitPrice = Children(i).Data
                            Case "UNITPRICE" : z1312.UnitPrice = Children(i).Data
                            Case "PRICEORDEREX" : z1312.PriceOrderEX = Children(i).Data
                            Case "PRICEORDERVND" : z1312.PriceOrderVND = Children(i).Data
                            Case "DATEDELIVERY" : z1312.Datedelivery = Children(i).Data
                            Case "DATETRANSFER" : z1312.DateTransfer = Children(i).Data
                            Case "ACCEPTEDORDER" : z1312.AcceptedOrder = Children(i).Data
                            Case "MATERIALSTATUS" : z1312.MaterialStatus = Children(i).Data
                            Case "SOLESTATUS" : z1312.SoleStatus = Children(i).Data
                            Case "DATELABLE" : z1312.DateLable = Children(i).Data
                            Case "DATEPATTERN" : z1312.DatePattern = Children(i).Data
                            Case "DATEMATERIAL" : z1312.DateMaterial = Children(i).Data
                            Case "DATEPLANNING" : z1312.DatePlanning = Children(i).Data
                            Case "DATERND" : z1312.DateRnD = Children(i).Data
                            Case "DATEFITTING" : z1312.DateFitting = Children(i).Data
                            Case "INCHARGEFITTING" : z1312.InchargeFitting = Children(i).Data
                            Case "CHECKFITTING" : z1312.CheckFitting = Children(i).Data
                            Case "DATETESTING" : z1312.DateTesting = Children(i).Data
                            Case "INCHARGETESTING" : z1312.InchargeTesting = Children(i).Data
                            Case "CHECKTESTING" : z1312.CheckTesting = Children(i).Data
                            Case "CHECKCONFIRM" : z1312.CheckConfirm = Children(i).Data
                            Case "DATECONFIRM" : z1312.DateConfirm = Children(i).Data
                            Case "INCHARGERD1" : z1312.InchargeRD1 = Children(i).Data
                            Case "INCHARGERD2" : z1312.InchargeRD2 = Children(i).Data
                            Case "INCHARGERD3" : z1312.InchargeRD3 = Children(i).Data
                            Case "INCHARGERD4" : z1312.InchargeRD4 = Children(i).Data
                            Case "DATESRD1" : z1312.DateSRD1 = Children(i).Data
                            Case "DATEERD1" : z1312.DateERD1 = Children(i).Data
                            Case "DATESRD2" : z1312.DateSRD2 = Children(i).Data
                            Case "DATEERD2" : z1312.DateERD2 = Children(i).Data
                            Case "DATESRD3" : z1312.DateSRD3 = Children(i).Data
                            Case "DATEERD3" : z1312.DateERD3 = Children(i).Data
                            Case "DATESRD4" : z1312.DateSRD4 = Children(i).Data
                            Case "DATEERD4" : z1312.DateERD4 = Children(i).Data
                            Case "SPECNO" : z1312.SpecNo = Children(i).Data
                            Case "SPECNOSEQ" : z1312.SpecNoSeq = Children(i).Data
                            Case "DATESOLE" : z1312.DateSole = Children(i).Data
                            Case "DATECUTTING" : z1312.DateCutting = Children(i).Data
                            Case "DATESTITCHING" : z1312.DateStitching = Children(i).Data
                            Case "DATESTOCKFIT" : z1312.DateStockfit = Children(i).Data
                            Case "DATEASSMBLY" : z1312.DateAssmbly = Children(i).Data
                            Case "DATESHIPPING" : z1312.DateShipping = Children(i).Data
                            Case "SEUNITMATERIAL" : z1312.seUnitMaterial = Children(i).Data
                            Case "CDUNITMATERIAL" : z1312.cdUnitMaterial = Children(i).Data
                            Case "SEUNITPACKING" : z1312.seUnitPacking = Children(i).Data
                            Case "CDUNITPACKING" : z1312.cdUnitPacking = Children(i).Data
                            Case "QTYORDERSAMPLE" : z1312.QtyOrderSample = Children(i).Data
                            Case "QTYORDERSAMPLE01" : z1312.QtyOrderSample01 = Children(i).Data
                            Case "QTYORDERSAMPLE02" : z1312.QtyOrderSample02 = Children(i).Data
                            Case "QTYORDER" : z1312.QtyOrder = Children(i).Data
                            Case "QTYJOB" : z1312.QtyJob = Children(i).Data
                            Case "QTYSOLE" : z1312.QtySole = Children(i).Data
                            Case "QTYCUTTING" : z1312.QtyCutting = Children(i).Data
                            Case "QTYSTITCHING" : z1312.QtyStitching = Children(i).Data
                            Case "QTYSTOCKFIT" : z1312.QtyStockfit = Children(i).Data
                            Case "QTYASSEMBLY" : z1312.QtyAssembly = Children(i).Data
                            Case "QTYPACKING" : z1312.QtyPacking = Children(i).Data
                            Case "QTYINBOUND" : z1312.QtyInbound = Children(i).Data
                            Case "QTYSHIPPING" : z1312.QtyShipping = Children(i).Data
                            Case "TIMEINSERT" : z1312.TimeInsert = Children(i).Data
                            Case "TIMEUPDATE" : z1312.TimeUpdate = Children(i).Data
                            Case "DATEINSERT" : z1312.DateInsert = Children(i).Data
                            Case "INCHARGEINSERT" : z1312.InchargeInsert = Children(i).Data
                            Case "DATEUPDATE" : z1312.DateUpdate = Children(i).Data
                            Case "INCHARGEUPDATE" : z1312.InchargeUpdate = Children(i).Data
                            Case "INCHARGESALES" : z1312.InchargeSales = Children(i).Data
                            Case "INCHARGEPPC" : z1312.InchargePPC = Children(i).Data
                            Case "TOTALQTY" : z1312.TotalQty = Children(i).Data
                            Case "TOTALAMT" : z1312.TotalAMT = Children(i).Data
                            Case "TOTALCOST" : z1312.TotalCost = Children(i).Data
                            Case "TOTALPROFIT" : z1312.TotalProfit = Children(i).Data
                            Case "TOTALAMTEX" : z1312.TotalAMTEX = Children(i).Data
                            Case "TOTALAMTVND" : z1312.TotalAMTVND = Children(i).Data
                            Case "TOTALCOSTEX" : z1312.TotalCostEX = Children(i).Data
                            Case "TOTALCOSTVND" : z1312.TotalCostVND = Children(i).Data
                            Case "TOTALPROFITEX" : z1312.TotalProfitEX = Children(i).Data
                            Case "TOTALPROFITVND" : z1312.TotalProfitVND = Children(i).Data
                            Case "ATTACHID" : z1312.AttachID = Children(i).Data
                            Case "DATESYNC" : z1312.DateSync = Children(i).Data
                            Case "CHECKSYNC" : z1312.CheckSync = Children(i).Data
                            Case "PINO" : z1312.PINo = Children(i).Data
                            Case "CHECKSIZEGROUP" : z1312.CheckSizeGroup = Children(i).Data
                            Case "ORDERNOREF" : z1312.OrderNoRef = Children(i).Data
                            Case "ORDERNOSEQREF" : z1312.OrderNoSeqRef = Children(i).Data
                            Case "REMARK" : z1312.Remark = Children(i).Data
                            Case "REMARKORDER" : z1312.RemarkOrder = Children(i).Data
                            Case "REMARKCUSTOMER" : z1312.RemarkCustomer = Children(i).Data
                            Case "REMARKOTHER" : z1312.RemarkOther = Children(i).Data
                            Case "REMARKTRADING" : z1312.RemarkTrading = Children(i).Data
                            Case "SESITE" : z1312.seSite = Children(i).Data
                            Case "CDSITE" : z1312.cdSite = Children(i).Data
                            Case "LICENSENAME" : z1312.LicenseName = Children(i).Data
                            Case "TESTSTANDARD" : z1312.TestStandard = Children(i).Data
                            Case "TESTNO" : z1312.TestNo = Children(i).Data
                            Case "DATEREPORT" : z1312.DateReport = Children(i).Data
                            Case "INVOICESTATUS" : z1312.InvoiceStatus = Children(i).Data
                            Case "WIPSTATUS" : z1312.WIPStatus = Children(i).Data
                            Case "WIPDATE" : z1312.WIPDate = Children(i).Data
                            Case "WIPNO" : z1312.WIPNo = Children(i).Data
                            Case "EXPORTCODE" : z1312.ExportCode = Children(i).Data
                            Case "EXPORTNAME" : z1312.ExportName = Children(i).Data

                        End Select
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception

        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K1312_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z1312 As T1312_AREA, Job As String, CheckClear As Boolean, OrderNo As String, OrderNoSeq As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K1312_MOVE = False

        Try
            If READ_PFK1312(OrderNo, OrderNoSeq) = True Then
                z1312 = D1312
                K1312_MOVE = True
            Else
                If CheckClear = True Then z1312 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1312")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = IIf(Children(i).Name.Contains("_"), Children(i).Name.Substring(Children(i).Name.IndexOf("_") + 1), Children(i).Name)
                Try
                    If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                        Select Case temp1
                            Case "ORDERNO" : z1312.OrderNo = Children(i).Code
                            Case "ORDERNOSEQ" : z1312.OrderNoSeq = Children(i).Code
                            Case "PRNAME" : z1312.PRName = Children(i).Code
                            Case "TIMEREVISEAPT" : z1312.TimeReviseApt = Children(i).Code
                            Case "TIMEREVISEPRT" : z1312.TimeRevisePrt = Children(i).Code
                            Case "TIMEREVISE" : z1312.TimeRevise = Children(i).Code
                            Case "TIMERNDREVISE" : z1312.TimeRnDRevise = Children(i).Code
                            Case "TIMESALESREVISE" : z1312.TimeSalesRevise = Children(i).Code
                            Case "INCHARGEREVISE" : z1312.InchargeRevise = Children(i).Code
                            Case "REVISENO" : z1312.ReviseNo = Children(i).Code
                            Case "SHOESCODE" : z1312.ShoesCode = Children(i).Code
                            Case "SHOESCODEFIN" : z1312.ShoesCodeFin = Children(i).Code
                            Case "FACPO" : z1312.FacPO = Children(i).Code
                            Case "SLNOSYS" : z1312.SLNoSys = Children(i).Code
                            Case "SLNO" : z1312.SLNo = Children(i).Code
                            Case "PONO" : z1312.PONO = Children(i).Code
                            Case "CPONO" : z1312.CPONO = Children(i).Code
                            Case "CUSTOMERCODE" : z1312.CustomerCode = Children(i).Code
                            Case "CUSTOMERNAME" : z1312.CustomerName = Children(i).Code
                            Case "COUNTRY" : z1312.Country = Children(i).Code
                            Case "DESTINATION" : z1312.Destination = Children(i).Code
                            Case "FINALSHOP" : z1312.FinalShop = Children(i).Code
                            Case "PKO" : z1312.PKO = Children(i).Code
                            Case "DATEPO" : z1312.DatePO = Children(i).Code
                            Case "JBCARD" : z1312.JbCard = Children(i).Code
                            Case "SEPACKINGCODE" : z1312.sePackingCode = Children(i).Code
                            Case "CDPACKINGCODE" : z1312.cdPackingCode = Children(i).Code
                            Case "SESPECSTATUS" : z1312.seSpecStatus = Children(i).Code
                            Case "CDSPECSTATUS" : z1312.cdSpecStatus = Children(i).Code
                            Case "SIZERANGE" : z1312.SizeRange = Children(i).Code
                            Case "SPECITICSIZE" : z1312.SpeciticSize = Children(i).Code
                            Case "DATESIZE" : z1312.DateSize = Children(i).Code
                            Case "ORDERDETAILSTATUS" : z1312.OrderDetailStatus = Children(i).Code
                            Case "DATEORDER" : z1312.DateOrder = Children(i).Code
                            Case "DATEAPPROVAL" : z1312.DateApproval = Children(i).Code
                            Case "DATECL" : z1312.DateCL = Children(i).Code
                            Case "DATECANCEL" : z1312.DateCancel = Children(i).Code
                            Case "REMARKCANCEL" : z1312.RemarkCancel = Children(i).Code
                            Case "DATECOMPLETE" : z1312.DateComplete = Children(i).Code
                            Case "DATEPENDING" : z1312.DatePending = Children(i).Code
                            Case "DATEPENDING2" : z1312.DatePending2 = Children(i).Code
                            Case "DATEEXCHANGEPRICE" : z1312.DateExchangePrice = Children(i).Code
                            Case "SIZEW" : z1312.SizeW = Children(i).Code
                            Case "SIZEL" : z1312.SizeL = Children(i).Code
                            Case "SIZEH" : z1312.SizeH = Children(i).Code
                            Case "QTYNO1" : z1312.QtyNo1 = Children(i).Code
                            Case "QTYNO2" : z1312.QtyNo2 = Children(i).Code
                            Case "QTYNO3" : z1312.QtyNo3 = Children(i).Code
                            Case "QTYGW" : z1312.QtyGW = Children(i).Code
                            Case "QTYNW" : z1312.QtyNW = Children(i).Code
                            Case "QTYPCSPOLY" : z1312.QtyPcsPoly = Children(i).Code
                            Case "QTYPOLYCTN" : z1312.QtyPolyCTN = Children(i).Code
                            Case "QTYPCSCTN" : z1312.QtyPcsCTN = Children(i).Code
                            Case "QTYPCSPINO" : z1312.QtyPcsPINO = Children(i).Code
                            Case "PRICEEXCHANGE" : z1312.PriceExchange = Children(i).Code
                            Case "CHECKFOB" : z1312.CheckFOB = Children(i).Code
                            Case "PRICEORDERFOB" : z1312.PriceOrderFOB = Children(i).Code
                            Case "TOTALAMTFOB" : z1312.TotalAMTFOB = Children(i).Code
                            Case "PRICEORDER" : z1312.PriceOrder = Children(i).Code
                            Case "PRICEORDER1" : z1312.PriceOrder1 = Children(i).Code
                            Case "PRICEORDER2" : z1312.PriceOrder2 = Children(i).Code
                            Case "PRICEORDER3" : z1312.PriceOrder3 = Children(i).Code
                            Case "SEUNITPRICE" : z1312.seUnitPrice = Children(i).Code
                            Case "CDUNITPRICE" : z1312.cdUnitPrice = Children(i).Code
                            Case "UNITPRICE" : z1312.UnitPrice = Children(i).Code
                            Case "PRICEORDEREX" : z1312.PriceOrderEX = Children(i).Code
                            Case "PRICEORDERVND" : z1312.PriceOrderVND = Children(i).Code
                            Case "DATEDELIVERY" : z1312.Datedelivery = Children(i).Code
                            Case "DATETRANSFER" : z1312.DateTransfer = Children(i).Code
                            Case "ACCEPTEDORDER" : z1312.AcceptedOrder = Children(i).Code
                            Case "MATERIALSTATUS" : z1312.MaterialStatus = Children(i).Code
                            Case "SOLESTATUS" : z1312.SoleStatus = Children(i).Code
                            Case "DATELABLE" : z1312.DateLable = Children(i).Code
                            Case "DATEPATTERN" : z1312.DatePattern = Children(i).Code
                            Case "DATEMATERIAL" : z1312.DateMaterial = Children(i).Code
                            Case "DATEPLANNING" : z1312.DatePlanning = Children(i).Code
                            Case "DATERND" : z1312.DateRnD = Children(i).Code
                            Case "DATEFITTING" : z1312.DateFitting = Children(i).Code
                            Case "INCHARGEFITTING" : z1312.InchargeFitting = Children(i).Code
                            Case "CHECKFITTING" : z1312.CheckFitting = Children(i).Code
                            Case "DATETESTING" : z1312.DateTesting = Children(i).Code
                            Case "INCHARGETESTING" : z1312.InchargeTesting = Children(i).Code
                            Case "CHECKTESTING" : z1312.CheckTesting = Children(i).Code
                            Case "CHECKCONFIRM" : z1312.CheckConfirm = Children(i).Code
                            Case "DATECONFIRM" : z1312.DateConfirm = Children(i).Code
                            Case "INCHARGERD1" : z1312.InchargeRD1 = Children(i).Code
                            Case "INCHARGERD2" : z1312.InchargeRD2 = Children(i).Code
                            Case "INCHARGERD3" : z1312.InchargeRD3 = Children(i).Code
                            Case "INCHARGERD4" : z1312.InchargeRD4 = Children(i).Code
                            Case "DATESRD1" : z1312.DateSRD1 = Children(i).Code
                            Case "DATEERD1" : z1312.DateERD1 = Children(i).Code
                            Case "DATESRD2" : z1312.DateSRD2 = Children(i).Code
                            Case "DATEERD2" : z1312.DateERD2 = Children(i).Code
                            Case "DATESRD3" : z1312.DateSRD3 = Children(i).Code
                            Case "DATEERD3" : z1312.DateERD3 = Children(i).Code
                            Case "DATESRD4" : z1312.DateSRD4 = Children(i).Code
                            Case "DATEERD4" : z1312.DateERD4 = Children(i).Code
                            Case "SPECNO" : z1312.SpecNo = Children(i).Code
                            Case "SPECNOSEQ" : z1312.SpecNoSeq = Children(i).Code
                            Case "DATESOLE" : z1312.DateSole = Children(i).Code
                            Case "DATECUTTING" : z1312.DateCutting = Children(i).Code
                            Case "DATESTITCHING" : z1312.DateStitching = Children(i).Code
                            Case "DATESTOCKFIT" : z1312.DateStockfit = Children(i).Code
                            Case "DATEASSMBLY" : z1312.DateAssmbly = Children(i).Code
                            Case "DATESHIPPING" : z1312.DateShipping = Children(i).Code
                            Case "SEUNITMATERIAL" : z1312.seUnitMaterial = Children(i).Code
                            Case "CDUNITMATERIAL" : z1312.cdUnitMaterial = Children(i).Code
                            Case "SEUNITPACKING" : z1312.seUnitPacking = Children(i).Code
                            Case "CDUNITPACKING" : z1312.cdUnitPacking = Children(i).Code
                            Case "QTYORDERSAMPLE" : z1312.QtyOrderSample = Children(i).Code
                            Case "QTYORDERSAMPLE01" : z1312.QtyOrderSample01 = Children(i).Code
                            Case "QTYORDERSAMPLE02" : z1312.QtyOrderSample02 = Children(i).Code
                            Case "QTYORDER" : z1312.QtyOrder = Children(i).Code
                            Case "QTYJOB" : z1312.QtyJob = Children(i).Code
                            Case "QTYSOLE" : z1312.QtySole = Children(i).Code
                            Case "QTYCUTTING" : z1312.QtyCutting = Children(i).Code
                            Case "QTYSTITCHING" : z1312.QtyStitching = Children(i).Code
                            Case "QTYSTOCKFIT" : z1312.QtyStockfit = Children(i).Code
                            Case "QTYASSEMBLY" : z1312.QtyAssembly = Children(i).Code
                            Case "QTYPACKING" : z1312.QtyPacking = Children(i).Code
                            Case "QTYINBOUND" : z1312.QtyInbound = Children(i).Code
                            Case "QTYSHIPPING" : z1312.QtyShipping = Children(i).Code
                            Case "TIMEINSERT" : z1312.TimeInsert = Children(i).Code
                            Case "TIMEUPDATE" : z1312.TimeUpdate = Children(i).Code
                            Case "DATEINSERT" : z1312.DateInsert = Children(i).Code
                            Case "INCHARGEINSERT" : z1312.InchargeInsert = Children(i).Code
                            Case "DATEUPDATE" : z1312.DateUpdate = Children(i).Code
                            Case "INCHARGEUPDATE" : z1312.InchargeUpdate = Children(i).Code
                            Case "INCHARGESALES" : z1312.InchargeSales = Children(i).Code
                            Case "INCHARGEPPC" : z1312.InchargePPC = Children(i).Code
                            Case "TOTALQTY" : z1312.TotalQty = Children(i).Code
                            Case "TOTALAMT" : z1312.TotalAMT = Children(i).Code
                            Case "TOTALCOST" : z1312.TotalCost = Children(i).Code
                            Case "TOTALPROFIT" : z1312.TotalProfit = Children(i).Code
                            Case "TOTALAMTEX" : z1312.TotalAMTEX = Children(i).Code
                            Case "TOTALAMTVND" : z1312.TotalAMTVND = Children(i).Code
                            Case "TOTALCOSTEX" : z1312.TotalCostEX = Children(i).Code
                            Case "TOTALCOSTVND" : z1312.TotalCostVND = Children(i).Code
                            Case "TOTALPROFITEX" : z1312.TotalProfitEX = Children(i).Code
                            Case "TOTALPROFITVND" : z1312.TotalProfitVND = Children(i).Code
                            Case "ATTACHID" : z1312.AttachID = Children(i).Code
                            Case "DATESYNC" : z1312.DateSync = Children(i).Code
                            Case "CHECKSYNC" : z1312.CheckSync = Children(i).Code
                            Case "PINO" : z1312.PINo = Children(i).Code
                            Case "CHECKSIZEGROUP" : z1312.CheckSizeGroup = Children(i).Code
                            Case "ORDERNOREF" : z1312.OrderNoRef = Children(i).Code
                            Case "ORDERNOSEQREF" : z1312.OrderNoSeqRef = Children(i).Code
                            Case "REMARK" : z1312.Remark = Children(i).Code
                            Case "REMARKORDER" : z1312.RemarkOrder = Children(i).Code
                            Case "REMARKCUSTOMER" : z1312.RemarkCustomer = Children(i).Code
                            Case "REMARKOTHER" : z1312.RemarkOther = Children(i).Code
                            Case "REMARKTRADING" : z1312.RemarkTrading = Children(i).Code
                            Case "SESITE" : z1312.seSite = Children(i).Code
                            Case "CDSITE" : z1312.cdSite = Children(i).Code
                            Case "LICENSENAME" : z1312.LicenseName = Children(i).Code
                            Case "TESTSTANDARD" : z1312.TestStandard = Children(i).Code
                            Case "TESTNO" : z1312.TestNo = Children(i).Code
                            Case "DATEREPORT" : z1312.DateReport = Children(i).Code
                            Case "INVOICESTATUS" : z1312.InvoiceStatus = Children(i).Code
                            Case "WIPSTATUS" : z1312.WIPStatus = Children(i).Code
                            Case "WIPDATE" : z1312.WIPDate = Children(i).Code
                            Case "WIPNO" : z1312.WIPNo = Children(i).Code
                            Case "EXPORTCODE" : z1312.ExportCode = Children(i).Code
                            Case "EXPORTNAME" : z1312.ExportName = Children(i).Code

                        End Select
                    Else
                        Select Case temp1
                            Case "ORDERNO" : z1312.OrderNo = Children(i).Data
                            Case "ORDERNOSEQ" : z1312.OrderNoSeq = Children(i).Data
                            Case "PRNAME" : z1312.PRName = Children(i).Data
                            Case "TIMEREVISEAPT" : z1312.TimeReviseApt = Children(i).Data
                            Case "TIMEREVISEPRT" : z1312.TimeRevisePrt = Children(i).Data
                            Case "TIMEREVISE" : z1312.TimeRevise = Children(i).Data
                            Case "TIMERNDREVISE" : z1312.TimeRnDRevise = Children(i).Data
                            Case "TIMESALESREVISE" : z1312.TimeSalesRevise = Children(i).Data
                            Case "INCHARGEREVISE" : z1312.InchargeRevise = Children(i).Data
                            Case "REVISENO" : z1312.ReviseNo = Children(i).Data
                            Case "SHOESCODE" : z1312.ShoesCode = Children(i).Data
                            Case "SHOESCODEFIN" : z1312.ShoesCodeFin = Children(i).Data
                            Case "FACPO" : z1312.FacPO = Children(i).Data
                            Case "SLNOSYS" : z1312.SLNoSys = Children(i).Data
                            Case "SLNO" : z1312.SLNo = Children(i).Data
                            Case "PONO" : z1312.PONO = Children(i).Data
                            Case "CPONO" : z1312.CPONO = Children(i).Data
                            Case "CUSTOMERCODE" : z1312.CustomerCode = Children(i).Data
                            Case "CUSTOMERNAME" : z1312.CustomerName = Children(i).Data
                            Case "COUNTRY" : z1312.Country = Children(i).Data
                            Case "DESTINATION" : z1312.Destination = Children(i).Data
                            Case "FINALSHOP" : z1312.FinalShop = Children(i).Data
                            Case "PKO" : z1312.PKO = Children(i).Data
                            Case "DATEPO" : z1312.DatePO = Children(i).Data
                            Case "JBCARD" : z1312.JbCard = Children(i).Data
                            Case "SEPACKINGCODE" : z1312.sePackingCode = Children(i).Data
                            Case "CDPACKINGCODE" : z1312.cdPackingCode = Children(i).Data
                            Case "SESPECSTATUS" : z1312.seSpecStatus = Children(i).Data
                            Case "CDSPECSTATUS" : z1312.cdSpecStatus = Children(i).Data
                            Case "SIZERANGE" : z1312.SizeRange = Children(i).Data
                            Case "SPECITICSIZE" : z1312.SpeciticSize = Children(i).Data
                            Case "DATESIZE" : z1312.DateSize = Children(i).Data
                            Case "ORDERDETAILSTATUS" : z1312.OrderDetailStatus = Children(i).Data
                            Case "DATEORDER" : z1312.DateOrder = Children(i).Data
                            Case "DATEAPPROVAL" : z1312.DateApproval = Children(i).Data
                            Case "DATECL" : z1312.DateCL = Children(i).Data
                            Case "DATECANCEL" : z1312.DateCancel = Children(i).Data
                            Case "REMARKCANCEL" : z1312.RemarkCancel = Children(i).Data
                            Case "DATECOMPLETE" : z1312.DateComplete = Children(i).Data
                            Case "DATEPENDING" : z1312.DatePending = Children(i).Data
                            Case "DATEPENDING2" : z1312.DatePending2 = Children(i).Data
                            Case "DATEEXCHANGEPRICE" : z1312.DateExchangePrice = Children(i).Data
                            Case "SIZEW" : z1312.SizeW = Children(i).Data
                            Case "SIZEL" : z1312.SizeL = Children(i).Data
                            Case "SIZEH" : z1312.SizeH = Children(i).Data
                            Case "QTYNO1" : z1312.QtyNo1 = Children(i).Data
                            Case "QTYNO2" : z1312.QtyNo2 = Children(i).Data
                            Case "QTYNO3" : z1312.QtyNo3 = Children(i).Data
                            Case "QTYGW" : z1312.QtyGW = Children(i).Data
                            Case "QTYNW" : z1312.QtyNW = Children(i).Data
                            Case "QTYPCSPOLY" : z1312.QtyPcsPoly = Children(i).Data
                            Case "QTYPOLYCTN" : z1312.QtyPolyCTN = Children(i).Data
                            Case "QTYPCSCTN" : z1312.QtyPcsCTN = Children(i).Data
                            Case "QTYPCSPINO" : z1312.QtyPcsPINO = Children(i).Data
                            Case "PRICEEXCHANGE" : z1312.PriceExchange = Children(i).Data
                            Case "CHECKFOB" : z1312.CheckFOB = Children(i).Data
                            Case "PRICEORDERFOB" : z1312.PriceOrderFOB = Children(i).Data
                            Case "TOTALAMTFOB" : z1312.TotalAMTFOB = Children(i).Data
                            Case "PRICEORDER" : z1312.PriceOrder = Children(i).Data
                            Case "PRICEORDER1" : z1312.PriceOrder1 = Children(i).Data
                            Case "PRICEORDER2" : z1312.PriceOrder2 = Children(i).Data
                            Case "PRICEORDER3" : z1312.PriceOrder3 = Children(i).Data
                            Case "SEUNITPRICE" : z1312.seUnitPrice = Children(i).Data
                            Case "CDUNITPRICE" : z1312.cdUnitPrice = Children(i).Data
                            Case "UNITPRICE" : z1312.UnitPrice = Children(i).Data
                            Case "PRICEORDEREX" : z1312.PriceOrderEX = Children(i).Data
                            Case "PRICEORDERVND" : z1312.PriceOrderVND = Children(i).Data
                            Case "DATEDELIVERY" : z1312.Datedelivery = Children(i).Data
                            Case "DATETRANSFER" : z1312.DateTransfer = Children(i).Data
                            Case "ACCEPTEDORDER" : z1312.AcceptedOrder = Children(i).Data
                            Case "MATERIALSTATUS" : z1312.MaterialStatus = Children(i).Data
                            Case "SOLESTATUS" : z1312.SoleStatus = Children(i).Data
                            Case "DATELABLE" : z1312.DateLable = Children(i).Data
                            Case "DATEPATTERN" : z1312.DatePattern = Children(i).Data
                            Case "DATEMATERIAL" : z1312.DateMaterial = Children(i).Data
                            Case "DATEPLANNING" : z1312.DatePlanning = Children(i).Data
                            Case "DATERND" : z1312.DateRnD = Children(i).Data
                            Case "DATEFITTING" : z1312.DateFitting = Children(i).Data
                            Case "INCHARGEFITTING" : z1312.InchargeFitting = Children(i).Data
                            Case "CHECKFITTING" : z1312.CheckFitting = Children(i).Data
                            Case "DATETESTING" : z1312.DateTesting = Children(i).Data
                            Case "INCHARGETESTING" : z1312.InchargeTesting = Children(i).Data
                            Case "CHECKTESTING" : z1312.CheckTesting = Children(i).Data
                            Case "CHECKCONFIRM" : z1312.CheckConfirm = Children(i).Data
                            Case "DATECONFIRM" : z1312.DateConfirm = Children(i).Data
                            Case "INCHARGERD1" : z1312.InchargeRD1 = Children(i).Data
                            Case "INCHARGERD2" : z1312.InchargeRD2 = Children(i).Data
                            Case "INCHARGERD3" : z1312.InchargeRD3 = Children(i).Data
                            Case "INCHARGERD4" : z1312.InchargeRD4 = Children(i).Data
                            Case "DATESRD1" : z1312.DateSRD1 = Children(i).Data
                            Case "DATEERD1" : z1312.DateERD1 = Children(i).Data
                            Case "DATESRD2" : z1312.DateSRD2 = Children(i).Data
                            Case "DATEERD2" : z1312.DateERD2 = Children(i).Data
                            Case "DATESRD3" : z1312.DateSRD3 = Children(i).Data
                            Case "DATEERD3" : z1312.DateERD3 = Children(i).Data
                            Case "DATESRD4" : z1312.DateSRD4 = Children(i).Data
                            Case "DATEERD4" : z1312.DateERD4 = Children(i).Data
                            Case "SPECNO" : z1312.SpecNo = Children(i).Data
                            Case "SPECNOSEQ" : z1312.SpecNoSeq = Children(i).Data
                            Case "DATESOLE" : z1312.DateSole = Children(i).Data
                            Case "DATECUTTING" : z1312.DateCutting = Children(i).Data
                            Case "DATESTITCHING" : z1312.DateStitching = Children(i).Data
                            Case "DATESTOCKFIT" : z1312.DateStockfit = Children(i).Data
                            Case "DATEASSMBLY" : z1312.DateAssmbly = Children(i).Data
                            Case "DATESHIPPING" : z1312.DateShipping = Children(i).Data
                            Case "SEUNITMATERIAL" : z1312.seUnitMaterial = Children(i).Data
                            Case "CDUNITMATERIAL" : z1312.cdUnitMaterial = Children(i).Data
                            Case "SEUNITPACKING" : z1312.seUnitPacking = Children(i).Data
                            Case "CDUNITPACKING" : z1312.cdUnitPacking = Children(i).Data
                            Case "QTYORDERSAMPLE" : z1312.QtyOrderSample = Children(i).Data
                            Case "QTYORDERSAMPLE01" : z1312.QtyOrderSample01 = Children(i).Data
                            Case "QTYORDERSAMPLE02" : z1312.QtyOrderSample02 = Children(i).Data
                            Case "QTYORDER" : z1312.QtyOrder = Children(i).Data
                            Case "QTYJOB" : z1312.QtyJob = Children(i).Data
                            Case "QTYSOLE" : z1312.QtySole = Children(i).Data
                            Case "QTYCUTTING" : z1312.QtyCutting = Children(i).Data
                            Case "QTYSTITCHING" : z1312.QtyStitching = Children(i).Data
                            Case "QTYSTOCKFIT" : z1312.QtyStockfit = Children(i).Data
                            Case "QTYASSEMBLY" : z1312.QtyAssembly = Children(i).Data
                            Case "QTYPACKING" : z1312.QtyPacking = Children(i).Data
                            Case "QTYINBOUND" : z1312.QtyInbound = Children(i).Data
                            Case "QTYSHIPPING" : z1312.QtyShipping = Children(i).Data
                            Case "TIMEINSERT" : z1312.TimeInsert = Children(i).Data
                            Case "TIMEUPDATE" : z1312.TimeUpdate = Children(i).Data
                            Case "DATEINSERT" : z1312.DateInsert = Children(i).Data
                            Case "INCHARGEINSERT" : z1312.InchargeInsert = Children(i).Data
                            Case "DATEUPDATE" : z1312.DateUpdate = Children(i).Data
                            Case "INCHARGEUPDATE" : z1312.InchargeUpdate = Children(i).Data
                            Case "INCHARGESALES" : z1312.InchargeSales = Children(i).Data
                            Case "INCHARGEPPC" : z1312.InchargePPC = Children(i).Data
                            Case "TOTALQTY" : z1312.TotalQty = Children(i).Data
                            Case "TOTALAMT" : z1312.TotalAMT = Children(i).Data
                            Case "TOTALCOST" : z1312.TotalCost = Children(i).Data
                            Case "TOTALPROFIT" : z1312.TotalProfit = Children(i).Data
                            Case "TOTALAMTEX" : z1312.TotalAMTEX = Children(i).Data
                            Case "TOTALAMTVND" : z1312.TotalAMTVND = Children(i).Data
                            Case "TOTALCOSTEX" : z1312.TotalCostEX = Children(i).Data
                            Case "TOTALCOSTVND" : z1312.TotalCostVND = Children(i).Data
                            Case "TOTALPROFITEX" : z1312.TotalProfitEX = Children(i).Data
                            Case "TOTALPROFITVND" : z1312.TotalProfitVND = Children(i).Data
                            Case "ATTACHID" : z1312.AttachID = Children(i).Data
                            Case "DATESYNC" : z1312.DateSync = Children(i).Data
                            Case "CHECKSYNC" : z1312.CheckSync = Children(i).Data
                            Case "PINO" : z1312.PINo = Children(i).Data
                            Case "CHECKSIZEGROUP" : z1312.CheckSizeGroup = Children(i).Data
                            Case "ORDERNOREF" : z1312.OrderNoRef = Children(i).Data
                            Case "ORDERNOSEQREF" : z1312.OrderNoSeqRef = Children(i).Data
                            Case "REMARK" : z1312.Remark = Children(i).Data
                            Case "REMARKORDER" : z1312.RemarkOrder = Children(i).Data
                            Case "REMARKCUSTOMER" : z1312.RemarkCustomer = Children(i).Data
                            Case "REMARKOTHER" : z1312.RemarkOther = Children(i).Data
                            Case "REMARKTRADING" : z1312.RemarkTrading = Children(i).Data
                            Case "SESITE" : z1312.seSite = Children(i).Data
                            Case "CDSITE" : z1312.cdSite = Children(i).Data
                            Case "LICENSENAME" : z1312.LicenseName = Children(i).Data
                            Case "TESTSTANDARD" : z1312.TestStandard = Children(i).Data
                            Case "TESTNO" : z1312.TestNo = Children(i).Data
                            Case "DATEREPORT" : z1312.DateReport = Children(i).Data
                            Case "INVOICESTATUS" : z1312.InvoiceStatus = Children(i).Data
                            Case "WIPSTATUS" : z1312.WIPStatus = Children(i).Data
                            Case "WIPDATE" : z1312.WIPDate = Children(i).Data
                            Case "WIPNO" : z1312.WIPNo = Children(i).Data
                            Case "EXPORTCODE" : z1312.ExportCode = Children(i).Data
                            Case "EXPORTNAME" : z1312.ExportName = Children(i).Data

                        End Select
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception

        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW AREA
    '=========================================================================================================================================================
    Public Sub K1312_MOVE(ByRef a1312 As T1312_AREA, ByRef b1312 As T1312_AREA)
        Try
            If trim$(a1312.OrderNo) = "" Then b1312.OrderNo = "" Else b1312.OrderNo = a1312.OrderNo
            If trim$(a1312.OrderNoSeq) = "" Then b1312.OrderNoSeq = "" Else b1312.OrderNoSeq = a1312.OrderNoSeq
            If trim$(a1312.PRName) = "" Then b1312.PRName = "" Else b1312.PRName = a1312.PRName
            If trim$(a1312.TimeReviseApt) = "" Then b1312.TimeReviseApt = "" Else b1312.TimeReviseApt = a1312.TimeReviseApt
            If trim$(a1312.TimeRevisePrt) = "" Then b1312.TimeRevisePrt = "" Else b1312.TimeRevisePrt = a1312.TimeRevisePrt
            If trim$(a1312.TimeRevise) = "" Then b1312.TimeRevise = "" Else b1312.TimeRevise = a1312.TimeRevise
            If trim$(a1312.TimeRnDRevise) = "" Then b1312.TimeRnDRevise = "" Else b1312.TimeRnDRevise = a1312.TimeRnDRevise
            If trim$(a1312.TimeSalesRevise) = "" Then b1312.TimeSalesRevise = "" Else b1312.TimeSalesRevise = a1312.TimeSalesRevise
            If trim$(a1312.InchargeRevise) = "" Then b1312.InchargeRevise = "" Else b1312.InchargeRevise = a1312.InchargeRevise
            If trim$(a1312.ReviseNo) = "" Then b1312.ReviseNo = "" Else b1312.ReviseNo = a1312.ReviseNo
            If trim$(a1312.ShoesCode) = "" Then b1312.ShoesCode = "" Else b1312.ShoesCode = a1312.ShoesCode
            If trim$(a1312.ShoesCodeFin) = "" Then b1312.ShoesCodeFin = "" Else b1312.ShoesCodeFin = a1312.ShoesCodeFin
            If trim$(a1312.FacPO) = "" Then b1312.FacPO = "" Else b1312.FacPO = a1312.FacPO
            If trim$(a1312.SLNoSys) = "" Then b1312.SLNoSys = "" Else b1312.SLNoSys = a1312.SLNoSys
            If trim$(a1312.SLNo) = "" Then b1312.SLNo = "" Else b1312.SLNo = a1312.SLNo
            If trim$(a1312.PONO) = "" Then b1312.PONO = "" Else b1312.PONO = a1312.PONO
            If trim$(a1312.CPONO) = "" Then b1312.CPONO = "" Else b1312.CPONO = a1312.CPONO
            If trim$(a1312.CustomerCode) = "" Then b1312.CustomerCode = "" Else b1312.CustomerCode = a1312.CustomerCode
            If trim$(a1312.CustomerName) = "" Then b1312.CustomerName = "" Else b1312.CustomerName = a1312.CustomerName
            If trim$(a1312.Country) = "" Then b1312.Country = "" Else b1312.Country = a1312.Country
            If trim$(a1312.Destination) = "" Then b1312.Destination = "" Else b1312.Destination = a1312.Destination
            If trim$(a1312.FinalShop) = "" Then b1312.FinalShop = "" Else b1312.FinalShop = a1312.FinalShop
            If trim$(a1312.PKO) = "" Then b1312.PKO = "" Else b1312.PKO = a1312.PKO
            If trim$(a1312.DatePO) = "" Then b1312.DatePO = "" Else b1312.DatePO = a1312.DatePO
            If trim$(a1312.JbCard) = "" Then b1312.JbCard = "" Else b1312.JbCard = a1312.JbCard
            If trim$(a1312.sePackingCode) = "" Then b1312.sePackingCode = "" Else b1312.sePackingCode = a1312.sePackingCode
            If trim$(a1312.cdPackingCode) = "" Then b1312.cdPackingCode = "" Else b1312.cdPackingCode = a1312.cdPackingCode
            If trim$(a1312.seSpecStatus) = "" Then b1312.seSpecStatus = "" Else b1312.seSpecStatus = a1312.seSpecStatus
            If trim$(a1312.cdSpecStatus) = "" Then b1312.cdSpecStatus = "" Else b1312.cdSpecStatus = a1312.cdSpecStatus
            If trim$(a1312.SizeRange) = "" Then b1312.SizeRange = "" Else b1312.SizeRange = a1312.SizeRange
            If trim$(a1312.SpeciticSize) = "" Then b1312.SpeciticSize = "" Else b1312.SpeciticSize = a1312.SpeciticSize
            If trim$(a1312.DateSize) = "" Then b1312.DateSize = "" Else b1312.DateSize = a1312.DateSize
            If trim$(a1312.OrderDetailStatus) = "" Then b1312.OrderDetailStatus = "" Else b1312.OrderDetailStatus = a1312.OrderDetailStatus
            If trim$(a1312.DateOrder) = "" Then b1312.DateOrder = "" Else b1312.DateOrder = a1312.DateOrder
            If trim$(a1312.DateApproval) = "" Then b1312.DateApproval = "" Else b1312.DateApproval = a1312.DateApproval
            If trim$(a1312.DateCL) = "" Then b1312.DateCL = "" Else b1312.DateCL = a1312.DateCL
            If trim$(a1312.DateCancel) = "" Then b1312.DateCancel = "" Else b1312.DateCancel = a1312.DateCancel
            If trim$(a1312.RemarkCancel) = "" Then b1312.RemarkCancel = "" Else b1312.RemarkCancel = a1312.RemarkCancel
            If trim$(a1312.DateComplete) = "" Then b1312.DateComplete = "" Else b1312.DateComplete = a1312.DateComplete
            If trim$(a1312.DatePending) = "" Then b1312.DatePending = "" Else b1312.DatePending = a1312.DatePending
            If trim$(a1312.DatePending2) = "" Then b1312.DatePending2 = "" Else b1312.DatePending2 = a1312.DatePending2
            If trim$(a1312.DateExchangePrice) = "" Then b1312.DateExchangePrice = "" Else b1312.DateExchangePrice = a1312.DateExchangePrice
            If trim$(a1312.SizeW) = "" Then b1312.SizeW = "" Else b1312.SizeW = a1312.SizeW
            If trim$(a1312.SizeL) = "" Then b1312.SizeL = "" Else b1312.SizeL = a1312.SizeL
            If trim$(a1312.SizeH) = "" Then b1312.SizeH = "" Else b1312.SizeH = a1312.SizeH
            If trim$(a1312.QtyNo1) = "" Then b1312.QtyNo1 = "" Else b1312.QtyNo1 = a1312.QtyNo1
            If trim$(a1312.QtyNo2) = "" Then b1312.QtyNo2 = "" Else b1312.QtyNo2 = a1312.QtyNo2
            If trim$(a1312.QtyNo3) = "" Then b1312.QtyNo3 = "" Else b1312.QtyNo3 = a1312.QtyNo3
            If trim$(a1312.QtyGW) = "" Then b1312.QtyGW = "" Else b1312.QtyGW = a1312.QtyGW
            If trim$(a1312.QtyNW) = "" Then b1312.QtyNW = "" Else b1312.QtyNW = a1312.QtyNW
            If trim$(a1312.QtyPcsPoly) = "" Then b1312.QtyPcsPoly = "" Else b1312.QtyPcsPoly = a1312.QtyPcsPoly
            If trim$(a1312.QtyPolyCTN) = "" Then b1312.QtyPolyCTN = "" Else b1312.QtyPolyCTN = a1312.QtyPolyCTN
            If trim$(a1312.QtyPcsCTN) = "" Then b1312.QtyPcsCTN = "" Else b1312.QtyPcsCTN = a1312.QtyPcsCTN
            If trim$(a1312.QtyPcsPINO) = "" Then b1312.QtyPcsPINO = "" Else b1312.QtyPcsPINO = a1312.QtyPcsPINO
            If trim$(a1312.PriceExchange) = "" Then b1312.PriceExchange = "" Else b1312.PriceExchange = a1312.PriceExchange
            If trim$(a1312.CheckFOB) = "" Then b1312.CheckFOB = "" Else b1312.CheckFOB = a1312.CheckFOB
            If trim$(a1312.PriceOrderFOB) = "" Then b1312.PriceOrderFOB = "" Else b1312.PriceOrderFOB = a1312.PriceOrderFOB
            If trim$(a1312.TotalAMTFOB) = "" Then b1312.TotalAMTFOB = "" Else b1312.TotalAMTFOB = a1312.TotalAMTFOB
            If trim$(a1312.PriceOrder) = "" Then b1312.PriceOrder = "" Else b1312.PriceOrder = a1312.PriceOrder
            If trim$(a1312.PriceOrder1) = "" Then b1312.PriceOrder1 = "" Else b1312.PriceOrder1 = a1312.PriceOrder1
            If trim$(a1312.PriceOrder2) = "" Then b1312.PriceOrder2 = "" Else b1312.PriceOrder2 = a1312.PriceOrder2
            If trim$(a1312.PriceOrder3) = "" Then b1312.PriceOrder3 = "" Else b1312.PriceOrder3 = a1312.PriceOrder3
            If trim$(a1312.seUnitPrice) = "" Then b1312.seUnitPrice = "" Else b1312.seUnitPrice = a1312.seUnitPrice
            If trim$(a1312.cdUnitPrice) = "" Then b1312.cdUnitPrice = "" Else b1312.cdUnitPrice = a1312.cdUnitPrice
            If trim$(a1312.UnitPrice) = "" Then b1312.UnitPrice = "" Else b1312.UnitPrice = a1312.UnitPrice
            If trim$(a1312.PriceOrderEX) = "" Then b1312.PriceOrderEX = "" Else b1312.PriceOrderEX = a1312.PriceOrderEX
            If trim$(a1312.PriceOrderVND) = "" Then b1312.PriceOrderVND = "" Else b1312.PriceOrderVND = a1312.PriceOrderVND
            If trim$(a1312.Datedelivery) = "" Then b1312.Datedelivery = "" Else b1312.Datedelivery = a1312.Datedelivery
            If trim$(a1312.DateTransfer) = "" Then b1312.DateTransfer = "" Else b1312.DateTransfer = a1312.DateTransfer
            If trim$(a1312.AcceptedOrder) = "" Then b1312.AcceptedOrder = "" Else b1312.AcceptedOrder = a1312.AcceptedOrder
            If trim$(a1312.MaterialStatus) = "" Then b1312.MaterialStatus = "" Else b1312.MaterialStatus = a1312.MaterialStatus
            If trim$(a1312.SoleStatus) = "" Then b1312.SoleStatus = "" Else b1312.SoleStatus = a1312.SoleStatus
            If trim$(a1312.DateLable) = "" Then b1312.DateLable = "" Else b1312.DateLable = a1312.DateLable
            If trim$(a1312.DatePattern) = "" Then b1312.DatePattern = "" Else b1312.DatePattern = a1312.DatePattern
            If trim$(a1312.DateMaterial) = "" Then b1312.DateMaterial = "" Else b1312.DateMaterial = a1312.DateMaterial
            If trim$(a1312.DatePlanning) = "" Then b1312.DatePlanning = "" Else b1312.DatePlanning = a1312.DatePlanning
            If trim$(a1312.DateRnD) = "" Then b1312.DateRnD = "" Else b1312.DateRnD = a1312.DateRnD
            If trim$(a1312.DateFitting) = "" Then b1312.DateFitting = "" Else b1312.DateFitting = a1312.DateFitting
            If trim$(a1312.InchargeFitting) = "" Then b1312.InchargeFitting = "" Else b1312.InchargeFitting = a1312.InchargeFitting
            If trim$(a1312.CheckFitting) = "" Then b1312.CheckFitting = "" Else b1312.CheckFitting = a1312.CheckFitting
            If trim$(a1312.DateTesting) = "" Then b1312.DateTesting = "" Else b1312.DateTesting = a1312.DateTesting
            If trim$(a1312.InchargeTesting) = "" Then b1312.InchargeTesting = "" Else b1312.InchargeTesting = a1312.InchargeTesting
            If trim$(a1312.CheckTesting) = "" Then b1312.CheckTesting = "" Else b1312.CheckTesting = a1312.CheckTesting
            If trim$(a1312.CheckConfirm) = "" Then b1312.CheckConfirm = "" Else b1312.CheckConfirm = a1312.CheckConfirm
            If trim$(a1312.DateConfirm) = "" Then b1312.DateConfirm = "" Else b1312.DateConfirm = a1312.DateConfirm
            If trim$(a1312.InchargeRD1) = "" Then b1312.InchargeRD1 = "" Else b1312.InchargeRD1 = a1312.InchargeRD1
            If trim$(a1312.InchargeRD2) = "" Then b1312.InchargeRD2 = "" Else b1312.InchargeRD2 = a1312.InchargeRD2
            If trim$(a1312.InchargeRD3) = "" Then b1312.InchargeRD3 = "" Else b1312.InchargeRD3 = a1312.InchargeRD3
            If trim$(a1312.InchargeRD4) = "" Then b1312.InchargeRD4 = "" Else b1312.InchargeRD4 = a1312.InchargeRD4
            If trim$(a1312.DateSRD1) = "" Then b1312.DateSRD1 = "" Else b1312.DateSRD1 = a1312.DateSRD1
            If trim$(a1312.DateERD1) = "" Then b1312.DateERD1 = "" Else b1312.DateERD1 = a1312.DateERD1
            If trim$(a1312.DateSRD2) = "" Then b1312.DateSRD2 = "" Else b1312.DateSRD2 = a1312.DateSRD2
            If trim$(a1312.DateERD2) = "" Then b1312.DateERD2 = "" Else b1312.DateERD2 = a1312.DateERD2
            If trim$(a1312.DateSRD3) = "" Then b1312.DateSRD3 = "" Else b1312.DateSRD3 = a1312.DateSRD3
            If trim$(a1312.DateERD3) = "" Then b1312.DateERD3 = "" Else b1312.DateERD3 = a1312.DateERD3
            If trim$(a1312.DateSRD4) = "" Then b1312.DateSRD4 = "" Else b1312.DateSRD4 = a1312.DateSRD4
            If trim$(a1312.DateERD4) = "" Then b1312.DateERD4 = "" Else b1312.DateERD4 = a1312.DateERD4
            If trim$(a1312.SpecNo) = "" Then b1312.SpecNo = "" Else b1312.SpecNo = a1312.SpecNo
            If trim$(a1312.SpecNoSeq) = "" Then b1312.SpecNoSeq = "" Else b1312.SpecNoSeq = a1312.SpecNoSeq
            If trim$(a1312.DateSole) = "" Then b1312.DateSole = "" Else b1312.DateSole = a1312.DateSole
            If trim$(a1312.DateCutting) = "" Then b1312.DateCutting = "" Else b1312.DateCutting = a1312.DateCutting
            If trim$(a1312.DateStitching) = "" Then b1312.DateStitching = "" Else b1312.DateStitching = a1312.DateStitching
            If trim$(a1312.DateStockfit) = "" Then b1312.DateStockfit = "" Else b1312.DateStockfit = a1312.DateStockfit
            If trim$(a1312.DateAssmbly) = "" Then b1312.DateAssmbly = "" Else b1312.DateAssmbly = a1312.DateAssmbly
            If trim$(a1312.DateShipping) = "" Then b1312.DateShipping = "" Else b1312.DateShipping = a1312.DateShipping
            If trim$(a1312.seUnitMaterial) = "" Then b1312.seUnitMaterial = "" Else b1312.seUnitMaterial = a1312.seUnitMaterial
            If trim$(a1312.cdUnitMaterial) = "" Then b1312.cdUnitMaterial = "" Else b1312.cdUnitMaterial = a1312.cdUnitMaterial
            If trim$(a1312.seUnitPacking) = "" Then b1312.seUnitPacking = "" Else b1312.seUnitPacking = a1312.seUnitPacking
            If trim$(a1312.cdUnitPacking) = "" Then b1312.cdUnitPacking = "" Else b1312.cdUnitPacking = a1312.cdUnitPacking
            If trim$(a1312.QtyOrderSample) = "" Then b1312.QtyOrderSample = "" Else b1312.QtyOrderSample = a1312.QtyOrderSample
            If trim$(a1312.QtyOrderSample01) = "" Then b1312.QtyOrderSample01 = "" Else b1312.QtyOrderSample01 = a1312.QtyOrderSample01
            If trim$(a1312.QtyOrderSample02) = "" Then b1312.QtyOrderSample02 = "" Else b1312.QtyOrderSample02 = a1312.QtyOrderSample02
            If trim$(a1312.QtyOrder) = "" Then b1312.QtyOrder = "" Else b1312.QtyOrder = a1312.QtyOrder
            If trim$(a1312.QtyJob) = "" Then b1312.QtyJob = "" Else b1312.QtyJob = a1312.QtyJob
            If trim$(a1312.QtySole) = "" Then b1312.QtySole = "" Else b1312.QtySole = a1312.QtySole
            If trim$(a1312.QtyCutting) = "" Then b1312.QtyCutting = "" Else b1312.QtyCutting = a1312.QtyCutting
            If trim$(a1312.QtyStitching) = "" Then b1312.QtyStitching = "" Else b1312.QtyStitching = a1312.QtyStitching
            If trim$(a1312.QtyStockfit) = "" Then b1312.QtyStockfit = "" Else b1312.QtyStockfit = a1312.QtyStockfit
            If trim$(a1312.QtyAssembly) = "" Then b1312.QtyAssembly = "" Else b1312.QtyAssembly = a1312.QtyAssembly
            If trim$(a1312.QtyPacking) = "" Then b1312.QtyPacking = "" Else b1312.QtyPacking = a1312.QtyPacking
            If trim$(a1312.QtyInbound) = "" Then b1312.QtyInbound = "" Else b1312.QtyInbound = a1312.QtyInbound
            If trim$(a1312.QtyShipping) = "" Then b1312.QtyShipping = "" Else b1312.QtyShipping = a1312.QtyShipping
            If trim$(a1312.TimeInsert) = "" Then b1312.TimeInsert = "" Else b1312.TimeInsert = a1312.TimeInsert
            If trim$(a1312.TimeUpdate) = "" Then b1312.TimeUpdate = "" Else b1312.TimeUpdate = a1312.TimeUpdate
            If trim$(a1312.DateInsert) = "" Then b1312.DateInsert = "" Else b1312.DateInsert = a1312.DateInsert
            If trim$(a1312.InchargeInsert) = "" Then b1312.InchargeInsert = "" Else b1312.InchargeInsert = a1312.InchargeInsert
            If trim$(a1312.DateUpdate) = "" Then b1312.DateUpdate = "" Else b1312.DateUpdate = a1312.DateUpdate
            If trim$(a1312.InchargeUpdate) = "" Then b1312.InchargeUpdate = "" Else b1312.InchargeUpdate = a1312.InchargeUpdate
            If trim$(a1312.InchargeSales) = "" Then b1312.InchargeSales = "" Else b1312.InchargeSales = a1312.InchargeSales
            If trim$(a1312.InchargePPC) = "" Then b1312.InchargePPC = "" Else b1312.InchargePPC = a1312.InchargePPC
            If trim$(a1312.TotalQty) = "" Then b1312.TotalQty = "" Else b1312.TotalQty = a1312.TotalQty
            If trim$(a1312.TotalAMT) = "" Then b1312.TotalAMT = "" Else b1312.TotalAMT = a1312.TotalAMT
            If trim$(a1312.TotalCost) = "" Then b1312.TotalCost = "" Else b1312.TotalCost = a1312.TotalCost
            If trim$(a1312.TotalProfit) = "" Then b1312.TotalProfit = "" Else b1312.TotalProfit = a1312.TotalProfit
            If trim$(a1312.TotalAMTEX) = "" Then b1312.TotalAMTEX = "" Else b1312.TotalAMTEX = a1312.TotalAMTEX
            If trim$(a1312.TotalAMTVND) = "" Then b1312.TotalAMTVND = "" Else b1312.TotalAMTVND = a1312.TotalAMTVND
            If trim$(a1312.TotalCostEX) = "" Then b1312.TotalCostEX = "" Else b1312.TotalCostEX = a1312.TotalCostEX
            If trim$(a1312.TotalCostVND) = "" Then b1312.TotalCostVND = "" Else b1312.TotalCostVND = a1312.TotalCostVND
            If trim$(a1312.TotalProfitEX) = "" Then b1312.TotalProfitEX = "" Else b1312.TotalProfitEX = a1312.TotalProfitEX
            If trim$(a1312.TotalProfitVND) = "" Then b1312.TotalProfitVND = "" Else b1312.TotalProfitVND = a1312.TotalProfitVND
            If trim$(a1312.AttachID) = "" Then b1312.AttachID = "" Else b1312.AttachID = a1312.AttachID
            If trim$(a1312.DateSync) = "" Then b1312.DateSync = "" Else b1312.DateSync = a1312.DateSync
            If trim$(a1312.CheckSync) = "" Then b1312.CheckSync = "" Else b1312.CheckSync = a1312.CheckSync
            If trim$(a1312.PINo) = "" Then b1312.PINo = "" Else b1312.PINo = a1312.PINo
            If trim$(a1312.CheckSizeGroup) = "" Then b1312.CheckSizeGroup = "" Else b1312.CheckSizeGroup = a1312.CheckSizeGroup
            If trim$(a1312.OrderNoRef) = "" Then b1312.OrderNoRef = "" Else b1312.OrderNoRef = a1312.OrderNoRef
            If trim$(a1312.OrderNoSeqRef) = "" Then b1312.OrderNoSeqRef = "" Else b1312.OrderNoSeqRef = a1312.OrderNoSeqRef
            If trim$(a1312.Remark) = "" Then b1312.Remark = "" Else b1312.Remark = a1312.Remark
            If trim$(a1312.RemarkOrder) = "" Then b1312.RemarkOrder = "" Else b1312.RemarkOrder = a1312.RemarkOrder
            If trim$(a1312.RemarkCustomer) = "" Then b1312.RemarkCustomer = "" Else b1312.RemarkCustomer = a1312.RemarkCustomer
            If trim$(a1312.RemarkOther) = "" Then b1312.RemarkOther = "" Else b1312.RemarkOther = a1312.RemarkOther
            If trim$(a1312.RemarkTrading) = "" Then b1312.RemarkTrading = "" Else b1312.RemarkTrading = a1312.RemarkTrading
            If trim$(a1312.seSite) = "" Then b1312.seSite = "" Else b1312.seSite = a1312.seSite
            If trim$(a1312.cdSite) = "" Then b1312.cdSite = "" Else b1312.cdSite = a1312.cdSite
            If trim$(a1312.LicenseName) = "" Then b1312.LicenseName = "" Else b1312.LicenseName = a1312.LicenseName
            If trim$(a1312.TestStandard) = "" Then b1312.TestStandard = "" Else b1312.TestStandard = a1312.TestStandard
            If trim$(a1312.TestNo) = "" Then b1312.TestNo = "" Else b1312.TestNo = a1312.TestNo
            If trim$(a1312.DateReport) = "" Then b1312.DateReport = "" Else b1312.DateReport = a1312.DateReport
            If trim$(a1312.InvoiceStatus) = "" Then b1312.InvoiceStatus = "" Else b1312.InvoiceStatus = a1312.InvoiceStatus
            If trim$(a1312.WIPStatus) = "" Then b1312.WIPStatus = "" Else b1312.WIPStatus = a1312.WIPStatus
            If trim$(a1312.WIPDate) = "" Then b1312.WIPDate = "" Else b1312.WIPDate = a1312.WIPDate
            If trim$(a1312.WIPNo) = "" Then b1312.WIPNo = "" Else b1312.WIPNo = a1312.WIPNo
            If trim$(a1312.ExportCode) = "" Then b1312.ExportCode = "" Else b1312.ExportCode = a1312.ExportCode
            If trim$(a1312.ExportName) = "" Then b1312.ExportName = "" Else b1312.ExportName = a1312.ExportName


        Catch ex As Exception

        End Try
    End Sub

End Module
