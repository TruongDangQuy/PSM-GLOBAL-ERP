'=========================================================================================================================================================
'   TABLE : (PFK4010)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K4010

Structure T4010_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	JobCard	 AS String	'			char(9)		*
        Public seJobState As String  '			char(3)
        Public cdJobState As String  '			char(3)
        Public SealNo As String  '			nvarchar(20)
        Public SlNoD As String  '			nvarchar(20)
        Public WorkOrder As String  '			char(9)
        Public WorkOrderSeq As String  '			char(3)
        Public selJob As String  '			char(1)
        Public selProd As String  '			char(1)
        Public DateStart As String  '			char(8)
        Public DateFinish As String  '			char(8)
        Public DatePlanStart As String  '			char(8)
        Public DatePlanFinish As String  '			char(8)
        Public JobCardBefore As String  '			char(9)
        Public JobCardAfter As String  '			char(9)
        Public CheckPlan As String  '			char(1)
        Public CheckUse As String  '			char(1)
        Public MaterialStatus As String  '			char(1)
        Public MoldStatus As String  '			char(1)
        Public LastStatus As String  '			char(1)
        Public CuttingDieStatus As String  '			char(1)
        Public SoleStatus As String  '			char(1)
        Public SoleNo As String  '			char(9)
        Public CuttingStatus As String  '			char(1)
        Public CuttingNo As String  '			char(9)
        Public StitchingStatus As String  '			char(1)
        Public StitchingNo As String  '			char(9)
        Public SubprocessStatus As String  '			char(1)
        Public SubprocessNo As String  '			char(9)
        Public OutsourceStatsus As String  '			char(1)
        Public OutsourceNo As String  '			char(9)
        Public StockfitStatsus As String  '			char(1)
        Public StockfitNo As String  '			char(9)
        Public AssemblyStatus As String  '			char(1)
        Public AssemblyNo As String  '			char(9)
        Public QtyOrder As Double  '			decimal
        Public QtyPlan As Double  '			decimal
        Public QtyJob As Double  '			decimal
        Public QtyJobSole As Double  '			decimal
        Public QtyBatchSole As Double  '			decimal
        Public QtySole As Double  '			decimal
        Public QtySoleA As Double  '			decimal
        Public QtySoleX As Double  '			decimal
        Public QtySoleXP As Double  '			decimal
        Public QtySoleXR As Double  '			decimal
        Public QtySoleBLOut As Double  '			decimal
        Public QtySoleBLIn As Double  '			decimal
        Public QtyJobCutting As Double  '			decimal
        Public QtyBatchCutting As Double  '			decimal
        Public QtyCom As Double  '			decimal
        Public QtyCutting As Double  '			decimal
        Public QtyCuttingA As Double  '			decimal
        Public QtyCuttingX As Double  '			decimal
        Public QtyCuttingXP As Double  '			decimal
        Public QtyCuttingXR As Double  '			decimal
        Public QtyCuttingBLOut As Double  '			decimal
        Public QtyCuttingBLIn As Double  '			decimal
        Public QtyJobStitching As Double  '			decimal
        Public QtyBatchStitching As Double  '			decimal
        Public QtyStitching As Double  '			decimal
        Public QtyStitchingA As Double  '			decimal
        Public QtyStitchingX As Double  '			decimal
        Public QtyStitchingXP As Double  '			decimal
        Public QtyStitchingXR As Double  '			decimal
        Public QtyStitchingBLOut As Double  '			decimal
        Public QtyStitchingBLIn As Double  '			decimal
        Public QtyJobStockfit As Double  '			decimal
        Public QtyBatchStockfit As Double  '			decimal
        Public QtyStockfit As Double  '			decimal
        Public QtyStockfitA As Double  '			decimal
        Public QtyStockfitX As Double  '			decimal
        Public QtyStockfitXP As Double  '			decimal
        Public QtyStockfitXR As Double  '			decimal
        Public QtyStockfitBLOut As Double  '			decimal
        Public QtyStockfitBLIn As Double  '			decimal
        Public QtyJobAssembly As Double  '			decimal
        Public QtyBatchAssembly As Double  '			decimal
        Public QtyAssembly As Double  '			decimal
        Public QtyAssemblyA As Double  '			decimal
        Public QtyAssemblyX As Double  '			decimal
        Public QtyAssemblyXP As Double  '			decimal
        Public QtyAssemblyXR As Double  '			decimal
        Public QtyAssemblyBLOut As Double  '			decimal
        Public QtyAssemblyBLIn As Double  '			decimal
        Public QtyJobPacking As Double  '			decimal
        Public QtyBatchPacking As Double  '			decimal
        Public QtyPacking As Double  '			decimal
        Public QtyPackingA As Double  '			decimal
        Public QtyPackingX As Double  '			decimal
        Public QtyPackingXP As Double  '			decimal
        Public QtyPackingXR As Double  '			decimal
        Public QtyPackingBLOut As Double  '			decimal
        Public QtyPackingBLIn As Double  '			decimal
        Public QtyJobShipping As Double  '			decimal
        Public QtyBatchShipping As Double  '			decimal
        Public QtyShipping As Double  '			decimal
        Public QtyShippingA As Double  '			decimal
        Public QtyShippingX As Double  '			decimal
        Public QtyShippingBLOut As Double  '			decimal
        Public QtyShippingBLIn As Double  '			decimal
        Public QtyFootbed As Double  '			decimal
        Public QtyFootbedA As Double  '			decimal
        Public QtyFootbedX As Double  '			decimal
        Public QtyInnerBox As Double  '			decimal
        Public QtyInnerBoxA As Double  '			decimal
        Public QtyInnerBoxX As Double  '			decimal
        Public QtyInbound As Double  '			decimal
        Public QtyInboundA As Double  '			decimal
        Public QtyInboundX As Double  '			decimal
        Public QtySB2UI As Double  '			decimal
        Public QtySB2UIA As Double  '			decimal
        Public QtySB2UIX As Double  '			decimal
        Public QtySB2UO As Double  '			decimal
        Public QtySB2UOA As Double  '			decimal
        Public QtySB2UOX As Double  '			decimal
        Public QtySB2SI As Double  '			decimal
        Public QtySB2SIA As Double  '			decimal
        Public QtySB2SIX As Double  '			decimal
        Public QtySB2SO As Double  '			decimal
        Public QtySB2SOA As Double  '			decimal
        Public QtySB2SOX As Double  '			decimal
        Public QtySB2FI As Double  '			decimal
        Public QtySB2FIA As Double  '			decimal
        Public QtySB2FIX As Double  '			decimal
        Public QtySB2FO As Double  '			decimal
        Public QtySB2FOA As Double  '			decimal
        Public QtySB2FOX As Double  '			decimal
        Public seFactory As String  '			char(3)
        Public cdFactory As String  '			char(3)
        Public seLineProd1 As String  '			char(3)
        Public cdLineProd1 As String  '			char(3)
        Public seLineProd2 As String  '			char(3)
        Public cdLineProd2 As String  '			char(3)
        Public seLineProd3 As String  '			char(3)
        Public cdLineProd3 As String  '			char(3)
        Public DateInsert As String  '			char(8)
        Public InchargeInsert As String  '			char(8)
        Public DateUpdate As String  '			char(8)
        Public InchargeUpdate As String  '			char(8)
        Public RemarkOrder As String  '			nvarchar(500)
        Public RemarkCustomer As String  '			nvarchar(500)
        Public RemarkOther As String  '			nvarchar(500)
        Public seSite As String  '			char(3)
        Public cdSite As String  '			char(3)
        '=========================================================================================================================================================
    End Structure

    Public D4010 As T4010_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK4010(JOBCARD As String) As Boolean
        READ_PFK4010 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4010 "
            SQL = SQL & " WHERE K4010_JobCard		 = '" & JobCard & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D4010_CLEAR() : GoTo SKIP_READ_PFK4010

            Call K4010_MOVE(rd)
            READ_PFK4010 = True

SKIP_READ_PFK4010:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK4010", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK4010(JOBCARD As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK4010 "
            SQL = SQL & " WHERE K4010_JobCard		 = '" & JobCard & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK4010", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK4010(z4010 As T4010_AREA) As Boolean
        WRITE_PFK4010 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z4010)

            SQL = " INSERT INTO PFK4010 "
            SQL = SQL & " ( "
            SQL = SQL & " K4010_JobCard,"
            SQL = SQL & " K4010_seJobState,"
            SQL = SQL & " K4010_cdJobState,"
            SQL = SQL & " K4010_SealNo,"
            SQL = SQL & " K4010_SlNoD,"
            SQL = SQL & " K4010_WorkOrder,"
            SQL = SQL & " K4010_WorkOrderSeq,"
            SQL = SQL & " K4010_selJob,"
            SQL = SQL & " K4010_selProd,"
            SQL = SQL & " K4010_DateStart,"
            SQL = SQL & " K4010_DateFinish,"
            SQL = SQL & " K4010_DatePlanStart,"
            SQL = SQL & " K4010_DatePlanFinish,"
            SQL = SQL & " K4010_JobCardBefore,"
            SQL = SQL & " K4010_JobCardAfter,"
            SQL = SQL & " K4010_CheckPlan,"
            SQL = SQL & " K4010_CheckUse,"
            SQL = SQL & " K4010_MaterialStatus,"
            SQL = SQL & " K4010_MoldStatus,"
            SQL = SQL & " K4010_LastStatus,"
            SQL = SQL & " K4010_CuttingDieStatus,"
            SQL = SQL & " K4010_SoleStatus,"
            SQL = SQL & " K4010_SoleNo,"
            SQL = SQL & " K4010_CuttingStatus,"
            SQL = SQL & " K4010_CuttingNo,"
            SQL = SQL & " K4010_StitchingStatus,"
            SQL = SQL & " K4010_StitchingNo,"
            SQL = SQL & " K4010_SubprocessStatus,"
            SQL = SQL & " K4010_SubprocessNo,"
            SQL = SQL & " K4010_OutsourceStatsus,"
            SQL = SQL & " K4010_OutsourceNo,"
            SQL = SQL & " K4010_StockfitStatsus,"
            SQL = SQL & " K4010_StockfitNo,"
            SQL = SQL & " K4010_AssemblyStatus,"
            SQL = SQL & " K4010_AssemblyNo,"
            SQL = SQL & " K4010_QtyOrder,"
            SQL = SQL & " K4010_QtyPlan,"
            SQL = SQL & " K4010_QtyJob,"
            SQL = SQL & " K4010_QtyJobSole,"
            SQL = SQL & " K4010_QtyBatchSole,"
            SQL = SQL & " K4010_QtySole,"
            SQL = SQL & " K4010_QtySoleA,"
            SQL = SQL & " K4010_QtySoleX,"
            SQL = SQL & " K4010_QtySoleXP,"
            SQL = SQL & " K4010_QtySoleXR,"
            SQL = SQL & " K4010_QtySoleBLOut,"
            SQL = SQL & " K4010_QtySoleBLIn,"
            SQL = SQL & " K4010_QtyJobCutting,"
            SQL = SQL & " K4010_QtyBatchCutting,"
            SQL = SQL & " K4010_QtyCom,"
            SQL = SQL & " K4010_QtyCutting,"
            SQL = SQL & " K4010_QtyCuttingA,"
            SQL = SQL & " K4010_QtyCuttingX,"
            SQL = SQL & " K4010_QtyCuttingXP,"
            SQL = SQL & " K4010_QtyCuttingXR,"
            SQL = SQL & " K4010_QtyCuttingBLOut,"
            SQL = SQL & " K4010_QtyCuttingBLIn,"
            SQL = SQL & " K4010_QtyJobStitching,"
            SQL = SQL & " K4010_QtyBatchStitching,"
            SQL = SQL & " K4010_QtyStitching,"
            SQL = SQL & " K4010_QtyStitchingA,"
            SQL = SQL & " K4010_QtyStitchingX,"
            SQL = SQL & " K4010_QtyStitchingXP,"
            SQL = SQL & " K4010_QtyStitchingXR,"
            SQL = SQL & " K4010_QtyStitchingBLOut,"
            SQL = SQL & " K4010_QtyStitchingBLIn,"
            SQL = SQL & " K4010_QtyJobStockfit,"
            SQL = SQL & " K4010_QtyBatchStockfit,"
            SQL = SQL & " K4010_QtyStockfit,"
            SQL = SQL & " K4010_QtyStockfitA,"
            SQL = SQL & " K4010_QtyStockfitX,"
            SQL = SQL & " K4010_QtyStockfitXP,"
            SQL = SQL & " K4010_QtyStockfitXR,"
            SQL = SQL & " K4010_QtyStockfitBLOut,"
            SQL = SQL & " K4010_QtyStockfitBLIn,"
            SQL = SQL & " K4010_QtyJobAssembly,"
            SQL = SQL & " K4010_QtyBatchAssembly,"
            SQL = SQL & " K4010_QtyAssembly,"
            SQL = SQL & " K4010_QtyAssemblyA,"
            SQL = SQL & " K4010_QtyAssemblyX,"
            SQL = SQL & " K4010_QtyAssemblyXP,"
            SQL = SQL & " K4010_QtyAssemblyXR,"
            SQL = SQL & " K4010_QtyAssemblyBLOut,"
            SQL = SQL & " K4010_QtyAssemblyBLIn,"
            SQL = SQL & " K4010_QtyJobPacking,"
            SQL = SQL & " K4010_QtyBatchPacking,"
            SQL = SQL & " K4010_QtyPacking,"
            SQL = SQL & " K4010_QtyPackingA,"
            SQL = SQL & " K4010_QtyPackingX,"
            SQL = SQL & " K4010_QtyPackingXP,"
            SQL = SQL & " K4010_QtyPackingXR,"
            SQL = SQL & " K4010_QtyPackingBLOut,"
            SQL = SQL & " K4010_QtyPackingBLIn,"
            SQL = SQL & " K4010_QtyJobShipping,"
            SQL = SQL & " K4010_QtyBatchShipping,"
            SQL = SQL & " K4010_QtyShipping,"
            SQL = SQL & " K4010_QtyShippingA,"
            SQL = SQL & " K4010_QtyShippingX,"
            SQL = SQL & " K4010_QtyShippingBLOut,"
            SQL = SQL & " K4010_QtyShippingBLIn,"
            SQL = SQL & " K4010_QtyFootbed,"
            SQL = SQL & " K4010_QtyFootbedA,"
            SQL = SQL & " K4010_QtyFootbedX,"
            SQL = SQL & " K4010_QtyInnerBox,"
            SQL = SQL & " K4010_QtyInnerBoxA,"
            SQL = SQL & " K4010_QtyInnerBoxX,"
            SQL = SQL & " K4010_QtyInbound,"
            SQL = SQL & " K4010_QtyInboundA,"
            SQL = SQL & " K4010_QtyInboundX,"
            SQL = SQL & " K4010_QtySB2UI,"
            SQL = SQL & " K4010_QtySB2UIA,"
            SQL = SQL & " K4010_QtySB2UIX,"
            SQL = SQL & " K4010_QtySB2UO,"
            SQL = SQL & " K4010_QtySB2UOA,"
            SQL = SQL & " K4010_QtySB2UOX,"
            SQL = SQL & " K4010_QtySB2SI,"
            SQL = SQL & " K4010_QtySB2SIA,"
            SQL = SQL & " K4010_QtySB2SIX,"
            SQL = SQL & " K4010_QtySB2SO,"
            SQL = SQL & " K4010_QtySB2SOA,"
            SQL = SQL & " K4010_QtySB2SOX,"
            SQL = SQL & " K4010_QtySB2FI,"
            SQL = SQL & " K4010_QtySB2FIA,"
            SQL = SQL & " K4010_QtySB2FIX,"
            SQL = SQL & " K4010_QtySB2FO,"
            SQL = SQL & " K4010_QtySB2FOA,"
            SQL = SQL & " K4010_QtySB2FOX,"
            SQL = SQL & " K4010_seFactory,"
            SQL = SQL & " K4010_cdFactory,"
            SQL = SQL & " K4010_seLineProd1,"
            SQL = SQL & " K4010_cdLineProd1,"
            SQL = SQL & " K4010_seLineProd2,"
            SQL = SQL & " K4010_cdLineProd2,"
            SQL = SQL & " K4010_seLineProd3,"
            SQL = SQL & " K4010_cdLineProd3,"
            SQL = SQL & " K4010_DateInsert,"
            SQL = SQL & " K4010_InchargeInsert,"
            SQL = SQL & " K4010_DateUpdate,"
            SQL = SQL & " K4010_InchargeUpdate,"
            SQL = SQL & " K4010_RemarkOrder,"
            SQL = SQL & " K4010_RemarkCustomer,"
            SQL = SQL & " K4010_RemarkOther,"
            SQL = SQL & " K4010_seSite,"
            SQL = SQL & " K4010_cdSite "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z4010.JobCard) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.seJobState) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.cdJobState) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.SealNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.SlNoD) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.WorkOrder) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.WorkOrderSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.selJob) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.selProd) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.DateStart) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.DateFinish) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.DatePlanStart) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.DatePlanFinish) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.JobCardBefore) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.JobCardAfter) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.CheckPlan) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.CheckUse) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.MaterialStatus) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.MoldStatus) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.LastStatus) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.CuttingDieStatus) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.SoleStatus) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.SoleNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.CuttingStatus) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.CuttingNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.StitchingStatus) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.StitchingNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.SubprocessStatus) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.SubprocessNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.OutsourceStatsus) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.OutsourceNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.StockfitStatsus) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.StockfitNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.AssemblyStatus) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.AssemblyNo) & "', "
            SQL = SQL & "   " & FormatSQL(z4010.QtyOrder) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyPlan) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyJob) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyJobSole) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyBatchSole) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtySole) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtySoleA) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtySoleX) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtySoleXP) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtySoleXR) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtySoleBLOut) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtySoleBLIn) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyJobCutting) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyBatchCutting) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyCom) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyCutting) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyCuttingA) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyCuttingX) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyCuttingXP) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyCuttingXR) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyCuttingBLOut) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyCuttingBLIn) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyJobStitching) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyBatchStitching) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyStitching) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyStitchingA) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyStitchingX) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyStitchingXP) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyStitchingXR) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyStitchingBLOut) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyStitchingBLIn) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyJobStockfit) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyBatchStockfit) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyStockfit) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyStockfitA) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyStockfitX) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyStockfitXP) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyStockfitXR) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyStockfitBLOut) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyStockfitBLIn) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyJobAssembly) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyBatchAssembly) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyAssembly) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyAssemblyA) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyAssemblyX) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyAssemblyXP) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyAssemblyXR) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyAssemblyBLOut) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyAssemblyBLIn) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyJobPacking) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyBatchPacking) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyPacking) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyPackingA) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyPackingX) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyPackingXP) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyPackingXR) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyPackingBLOut) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyPackingBLIn) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyJobShipping) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyBatchShipping) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyShipping) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyShippingA) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyShippingX) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyShippingBLOut) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyShippingBLIn) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyFootbed) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyFootbedA) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyFootbedX) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyInnerBox) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyInnerBoxA) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyInnerBoxX) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyInbound) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyInboundA) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtyInboundX) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtySB2UI) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtySB2UIA) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtySB2UIX) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtySB2UO) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtySB2UOA) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtySB2UOX) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtySB2SI) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtySB2SIA) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtySB2SIX) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtySB2SO) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtySB2SOA) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtySB2SOX) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtySB2FI) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtySB2FIA) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtySB2FIX) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtySB2FO) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtySB2FOA) & ", "
            SQL = SQL & "   " & FormatSQL(z4010.QtySB2FOX) & ", "
            SQL = SQL & "  N'" & FormatSQL(z4010.seFactory) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.cdFactory) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.seLineProd1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.cdLineProd1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.seLineProd2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.cdLineProd2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.seLineProd3) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.cdLineProd3) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.DateInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.InchargeInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.DateUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.InchargeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.RemarkOrder) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.RemarkCustomer) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.RemarkOther) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.seSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(z4010.cdSite) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK4010 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK4010", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK4010(z4010 As T4010_AREA) As Boolean
        REWRITE_PFK4010 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z4010)

            SQL = " UPDATE PFK4010 SET "
            SQL = SQL & "    K4010_seJobState      = N'" & FormatSQL(z4010.seJobState) & "', "
            SQL = SQL & "    K4010_cdJobState      = N'" & FormatSQL(z4010.cdJobState) & "', "
            SQL = SQL & "    K4010_SealNo      = N'" & FormatSQL(z4010.SealNo) & "', "
            SQL = SQL & "    K4010_SlNoD      = N'" & FormatSQL(z4010.SlNoD) & "', "
            SQL = SQL & "    K4010_WorkOrder      = N'" & FormatSQL(z4010.WorkOrder) & "', "
            SQL = SQL & "    K4010_WorkOrderSeq      = N'" & FormatSQL(z4010.WorkOrderSeq) & "', "
            SQL = SQL & "    K4010_selJob      = N'" & FormatSQL(z4010.selJob) & "', "
            SQL = SQL & "    K4010_selProd      = N'" & FormatSQL(z4010.selProd) & "', "
            SQL = SQL & "    K4010_DateStart      = N'" & FormatSQL(z4010.DateStart) & "', "
            SQL = SQL & "    K4010_DateFinish      = N'" & FormatSQL(z4010.DateFinish) & "', "
            SQL = SQL & "    K4010_DatePlanStart      = N'" & FormatSQL(z4010.DatePlanStart) & "', "
            SQL = SQL & "    K4010_DatePlanFinish      = N'" & FormatSQL(z4010.DatePlanFinish) & "', "
            SQL = SQL & "    K4010_JobCardBefore      = N'" & FormatSQL(z4010.JobCardBefore) & "', "
            SQL = SQL & "    K4010_JobCardAfter      = N'" & FormatSQL(z4010.JobCardAfter) & "', "
            SQL = SQL & "    K4010_CheckPlan      = N'" & FormatSQL(z4010.CheckPlan) & "', "
            SQL = SQL & "    K4010_CheckUse      = N'" & FormatSQL(z4010.CheckUse) & "', "
            SQL = SQL & "    K4010_MaterialStatus      = N'" & FormatSQL(z4010.MaterialStatus) & "', "
            SQL = SQL & "    K4010_MoldStatus      = N'" & FormatSQL(z4010.MoldStatus) & "', "
            SQL = SQL & "    K4010_LastStatus      = N'" & FormatSQL(z4010.LastStatus) & "', "
            SQL = SQL & "    K4010_CuttingDieStatus      = N'" & FormatSQL(z4010.CuttingDieStatus) & "', "
            SQL = SQL & "    K4010_SoleStatus      = N'" & FormatSQL(z4010.SoleStatus) & "', "
            SQL = SQL & "    K4010_SoleNo      = N'" & FormatSQL(z4010.SoleNo) & "', "
            SQL = SQL & "    K4010_CuttingStatus      = N'" & FormatSQL(z4010.CuttingStatus) & "', "
            SQL = SQL & "    K4010_CuttingNo      = N'" & FormatSQL(z4010.CuttingNo) & "', "
            SQL = SQL & "    K4010_StitchingStatus      = N'" & FormatSQL(z4010.StitchingStatus) & "', "
            SQL = SQL & "    K4010_StitchingNo      = N'" & FormatSQL(z4010.StitchingNo) & "', "
            SQL = SQL & "    K4010_SubprocessStatus      = N'" & FormatSQL(z4010.SubprocessStatus) & "', "
            SQL = SQL & "    K4010_SubprocessNo      = N'" & FormatSQL(z4010.SubprocessNo) & "', "
            SQL = SQL & "    K4010_OutsourceStatsus      = N'" & FormatSQL(z4010.OutsourceStatsus) & "', "
            SQL = SQL & "    K4010_OutsourceNo      = N'" & FormatSQL(z4010.OutsourceNo) & "', "
            SQL = SQL & "    K4010_StockfitStatsus      = N'" & FormatSQL(z4010.StockfitStatsus) & "', "
            SQL = SQL & "    K4010_StockfitNo      = N'" & FormatSQL(z4010.StockfitNo) & "', "
            SQL = SQL & "    K4010_AssemblyStatus      = N'" & FormatSQL(z4010.AssemblyStatus) & "', "
            SQL = SQL & "    K4010_AssemblyNo      = N'" & FormatSQL(z4010.AssemblyNo) & "', "
            SQL = SQL & "    K4010_QtyOrder      =  " & FormatSQL(z4010.QtyOrder) & ", "
            SQL = SQL & "    K4010_QtyPlan      =  " & FormatSQL(z4010.QtyPlan) & ", "
            SQL = SQL & "    K4010_QtyJob      =  " & FormatSQL(z4010.QtyJob) & ", "
            SQL = SQL & "    K4010_QtyJobSole      =  " & FormatSQL(z4010.QtyJobSole) & ", "
            SQL = SQL & "    K4010_QtyBatchSole      =  " & FormatSQL(z4010.QtyBatchSole) & ", "
            SQL = SQL & "    K4010_QtySole      =  " & FormatSQL(z4010.QtySole) & ", "
            SQL = SQL & "    K4010_QtySoleA      =  " & FormatSQL(z4010.QtySoleA) & ", "
            SQL = SQL & "    K4010_QtySoleX      =  " & FormatSQL(z4010.QtySoleX) & ", "
            SQL = SQL & "    K4010_QtySoleXP      =  " & FormatSQL(z4010.QtySoleXP) & ", "
            SQL = SQL & "    K4010_QtySoleXR      =  " & FormatSQL(z4010.QtySoleXR) & ", "
            SQL = SQL & "    K4010_QtySoleBLOut      =  " & FormatSQL(z4010.QtySoleBLOut) & ", "
            SQL = SQL & "    K4010_QtySoleBLIn      =  " & FormatSQL(z4010.QtySoleBLIn) & ", "
            SQL = SQL & "    K4010_QtyJobCutting      =  " & FormatSQL(z4010.QtyJobCutting) & ", "
            SQL = SQL & "    K4010_QtyBatchCutting      =  " & FormatSQL(z4010.QtyBatchCutting) & ", "
            SQL = SQL & "    K4010_QtyCom      =  " & FormatSQL(z4010.QtyCom) & ", "
            SQL = SQL & "    K4010_QtyCutting      =  " & FormatSQL(z4010.QtyCutting) & ", "
            SQL = SQL & "    K4010_QtyCuttingA      =  " & FormatSQL(z4010.QtyCuttingA) & ", "
            SQL = SQL & "    K4010_QtyCuttingX      =  " & FormatSQL(z4010.QtyCuttingX) & ", "
            SQL = SQL & "    K4010_QtyCuttingXP      =  " & FormatSQL(z4010.QtyCuttingXP) & ", "
            SQL = SQL & "    K4010_QtyCuttingXR      =  " & FormatSQL(z4010.QtyCuttingXR) & ", "
            SQL = SQL & "    K4010_QtyCuttingBLOut      =  " & FormatSQL(z4010.QtyCuttingBLOut) & ", "
            SQL = SQL & "    K4010_QtyCuttingBLIn      =  " & FormatSQL(z4010.QtyCuttingBLIn) & ", "
            SQL = SQL & "    K4010_QtyJobStitching      =  " & FormatSQL(z4010.QtyJobStitching) & ", "
            SQL = SQL & "    K4010_QtyBatchStitching      =  " & FormatSQL(z4010.QtyBatchStitching) & ", "
            SQL = SQL & "    K4010_QtyStitching      =  " & FormatSQL(z4010.QtyStitching) & ", "
            SQL = SQL & "    K4010_QtyStitchingA      =  " & FormatSQL(z4010.QtyStitchingA) & ", "
            SQL = SQL & "    K4010_QtyStitchingX      =  " & FormatSQL(z4010.QtyStitchingX) & ", "
            SQL = SQL & "    K4010_QtyStitchingXP      =  " & FormatSQL(z4010.QtyStitchingXP) & ", "
            SQL = SQL & "    K4010_QtyStitchingXR      =  " & FormatSQL(z4010.QtyStitchingXR) & ", "
            SQL = SQL & "    K4010_QtyStitchingBLOut      =  " & FormatSQL(z4010.QtyStitchingBLOut) & ", "
            SQL = SQL & "    K4010_QtyStitchingBLIn      =  " & FormatSQL(z4010.QtyStitchingBLIn) & ", "
            SQL = SQL & "    K4010_QtyJobStockfit      =  " & FormatSQL(z4010.QtyJobStockfit) & ", "
            SQL = SQL & "    K4010_QtyBatchStockfit      =  " & FormatSQL(z4010.QtyBatchStockfit) & ", "
            SQL = SQL & "    K4010_QtyStockfit      =  " & FormatSQL(z4010.QtyStockfit) & ", "
            SQL = SQL & "    K4010_QtyStockfitA      =  " & FormatSQL(z4010.QtyStockfitA) & ", "
            SQL = SQL & "    K4010_QtyStockfitX      =  " & FormatSQL(z4010.QtyStockfitX) & ", "
            SQL = SQL & "    K4010_QtyStockfitXP      =  " & FormatSQL(z4010.QtyStockfitXP) & ", "
            SQL = SQL & "    K4010_QtyStockfitXR      =  " & FormatSQL(z4010.QtyStockfitXR) & ", "
            SQL = SQL & "    K4010_QtyStockfitBLOut      =  " & FormatSQL(z4010.QtyStockfitBLOut) & ", "
            SQL = SQL & "    K4010_QtyStockfitBLIn      =  " & FormatSQL(z4010.QtyStockfitBLIn) & ", "
            SQL = SQL & "    K4010_QtyJobAssembly      =  " & FormatSQL(z4010.QtyJobAssembly) & ", "
            SQL = SQL & "    K4010_QtyBatchAssembly      =  " & FormatSQL(z4010.QtyBatchAssembly) & ", "
            SQL = SQL & "    K4010_QtyAssembly      =  " & FormatSQL(z4010.QtyAssembly) & ", "
            SQL = SQL & "    K4010_QtyAssemblyA      =  " & FormatSQL(z4010.QtyAssemblyA) & ", "
            SQL = SQL & "    K4010_QtyAssemblyX      =  " & FormatSQL(z4010.QtyAssemblyX) & ", "
            SQL = SQL & "    K4010_QtyAssemblyXP      =  " & FormatSQL(z4010.QtyAssemblyXP) & ", "
            SQL = SQL & "    K4010_QtyAssemblyXR      =  " & FormatSQL(z4010.QtyAssemblyXR) & ", "
            SQL = SQL & "    K4010_QtyAssemblyBLOut      =  " & FormatSQL(z4010.QtyAssemblyBLOut) & ", "
            SQL = SQL & "    K4010_QtyAssemblyBLIn      =  " & FormatSQL(z4010.QtyAssemblyBLIn) & ", "
            SQL = SQL & "    K4010_QtyJobPacking      =  " & FormatSQL(z4010.QtyJobPacking) & ", "
            SQL = SQL & "    K4010_QtyBatchPacking      =  " & FormatSQL(z4010.QtyBatchPacking) & ", "
            SQL = SQL & "    K4010_QtyPacking      =  " & FormatSQL(z4010.QtyPacking) & ", "
            SQL = SQL & "    K4010_QtyPackingA      =  " & FormatSQL(z4010.QtyPackingA) & ", "
            SQL = SQL & "    K4010_QtyPackingX      =  " & FormatSQL(z4010.QtyPackingX) & ", "
            SQL = SQL & "    K4010_QtyPackingXP      =  " & FormatSQL(z4010.QtyPackingXP) & ", "
            SQL = SQL & "    K4010_QtyPackingXR      =  " & FormatSQL(z4010.QtyPackingXR) & ", "
            SQL = SQL & "    K4010_QtyPackingBLOut      =  " & FormatSQL(z4010.QtyPackingBLOut) & ", "
            SQL = SQL & "    K4010_QtyPackingBLIn      =  " & FormatSQL(z4010.QtyPackingBLIn) & ", "
            SQL = SQL & "    K4010_QtyJobShipping      =  " & FormatSQL(z4010.QtyJobShipping) & ", "
            SQL = SQL & "    K4010_QtyBatchShipping      =  " & FormatSQL(z4010.QtyBatchShipping) & ", "
            SQL = SQL & "    K4010_QtyShipping      =  " & FormatSQL(z4010.QtyShipping) & ", "
            SQL = SQL & "    K4010_QtyShippingA      =  " & FormatSQL(z4010.QtyShippingA) & ", "
            SQL = SQL & "    K4010_QtyShippingX      =  " & FormatSQL(z4010.QtyShippingX) & ", "
            SQL = SQL & "    K4010_QtyShippingBLOut      =  " & FormatSQL(z4010.QtyShippingBLOut) & ", "
            SQL = SQL & "    K4010_QtyShippingBLIn      =  " & FormatSQL(z4010.QtyShippingBLIn) & ", "
            SQL = SQL & "    K4010_QtyFootbed      =  " & FormatSQL(z4010.QtyFootbed) & ", "
            SQL = SQL & "    K4010_QtyFootbedA      =  " & FormatSQL(z4010.QtyFootbedA) & ", "
            SQL = SQL & "    K4010_QtyFootbedX      =  " & FormatSQL(z4010.QtyFootbedX) & ", "
            SQL = SQL & "    K4010_QtyInnerBox      =  " & FormatSQL(z4010.QtyInnerBox) & ", "
            SQL = SQL & "    K4010_QtyInnerBoxA      =  " & FormatSQL(z4010.QtyInnerBoxA) & ", "
            SQL = SQL & "    K4010_QtyInnerBoxX      =  " & FormatSQL(z4010.QtyInnerBoxX) & ", "
            SQL = SQL & "    K4010_QtyInbound      =  " & FormatSQL(z4010.QtyInbound) & ", "
            SQL = SQL & "    K4010_QtyInboundA      =  " & FormatSQL(z4010.QtyInboundA) & ", "
            SQL = SQL & "    K4010_QtyInboundX      =  " & FormatSQL(z4010.QtyInboundX) & ", "
            SQL = SQL & "    K4010_QtySB2UI      =  " & FormatSQL(z4010.QtySB2UI) & ", "
            SQL = SQL & "    K4010_QtySB2UIA      =  " & FormatSQL(z4010.QtySB2UIA) & ", "
            SQL = SQL & "    K4010_QtySB2UIX      =  " & FormatSQL(z4010.QtySB2UIX) & ", "
            SQL = SQL & "    K4010_QtySB2UO      =  " & FormatSQL(z4010.QtySB2UO) & ", "
            SQL = SQL & "    K4010_QtySB2UOA      =  " & FormatSQL(z4010.QtySB2UOA) & ", "
            SQL = SQL & "    K4010_QtySB2UOX      =  " & FormatSQL(z4010.QtySB2UOX) & ", "
            SQL = SQL & "    K4010_QtySB2SI      =  " & FormatSQL(z4010.QtySB2SI) & ", "
            SQL = SQL & "    K4010_QtySB2SIA      =  " & FormatSQL(z4010.QtySB2SIA) & ", "
            SQL = SQL & "    K4010_QtySB2SIX      =  " & FormatSQL(z4010.QtySB2SIX) & ", "
            SQL = SQL & "    K4010_QtySB2SO      =  " & FormatSQL(z4010.QtySB2SO) & ", "
            SQL = SQL & "    K4010_QtySB2SOA      =  " & FormatSQL(z4010.QtySB2SOA) & ", "
            SQL = SQL & "    K4010_QtySB2SOX      =  " & FormatSQL(z4010.QtySB2SOX) & ", "
            SQL = SQL & "    K4010_QtySB2FI      =  " & FormatSQL(z4010.QtySB2FI) & ", "
            SQL = SQL & "    K4010_QtySB2FIA      =  " & FormatSQL(z4010.QtySB2FIA) & ", "
            SQL = SQL & "    K4010_QtySB2FIX      =  " & FormatSQL(z4010.QtySB2FIX) & ", "
            SQL = SQL & "    K4010_QtySB2FO      =  " & FormatSQL(z4010.QtySB2FO) & ", "
            SQL = SQL & "    K4010_QtySB2FOA      =  " & FormatSQL(z4010.QtySB2FOA) & ", "
            SQL = SQL & "    K4010_QtySB2FOX      =  " & FormatSQL(z4010.QtySB2FOX) & ", "
            SQL = SQL & "    K4010_seFactory      = N'" & FormatSQL(z4010.seFactory) & "', "
            SQL = SQL & "    K4010_cdFactory      = N'" & FormatSQL(z4010.cdFactory) & "', "
            SQL = SQL & "    K4010_seLineProd1      = N'" & FormatSQL(z4010.seLineProd1) & "', "
            SQL = SQL & "    K4010_cdLineProd1      = N'" & FormatSQL(z4010.cdLineProd1) & "', "
            SQL = SQL & "    K4010_seLineProd2      = N'" & FormatSQL(z4010.seLineProd2) & "', "
            SQL = SQL & "    K4010_cdLineProd2      = N'" & FormatSQL(z4010.cdLineProd2) & "', "
            SQL = SQL & "    K4010_seLineProd3      = N'" & FormatSQL(z4010.seLineProd3) & "', "
            SQL = SQL & "    K4010_cdLineProd3      = N'" & FormatSQL(z4010.cdLineProd3) & "', "
            SQL = SQL & "    K4010_DateInsert      = N'" & FormatSQL(z4010.DateInsert) & "', "
            SQL = SQL & "    K4010_InchargeInsert      = N'" & FormatSQL(z4010.InchargeInsert) & "', "
            SQL = SQL & "    K4010_DateUpdate      = N'" & FormatSQL(z4010.DateUpdate) & "', "
            SQL = SQL & "    K4010_InchargeUpdate      = N'" & FormatSQL(z4010.InchargeUpdate) & "', "
            SQL = SQL & "    K4010_RemarkOrder      = N'" & FormatSQL(z4010.RemarkOrder) & "', "
            SQL = SQL & "    K4010_RemarkCustomer      = N'" & FormatSQL(z4010.RemarkCustomer) & "', "
            SQL = SQL & "    K4010_RemarkOther      = N'" & FormatSQL(z4010.RemarkOther) & "', "
            SQL = SQL & "    K4010_seSite      = N'" & FormatSQL(z4010.seSite) & "', "
            SQL = SQL & "    K4010_cdSite      = N'" & FormatSQL(z4010.cdSite) & "'  "
            SQL = SQL & " WHERE K4010_JobCard		 = '" & z4010.JobCard & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK4010 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK4010", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK4010(z4010 As T4010_AREA) As Boolean
        DELETE_PFK4010 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK4010 "
            SQL = SQL & " WHERE K4010_JobCard		 = '" & z4010.JobCard & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK4010 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK4010", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D4010_CLEAR()
        Try

            D4010.JobCard = ""
            D4010.seJobState = ""
            D4010.cdJobState = ""
            D4010.SealNo = ""
            D4010.SlNoD = ""
            D4010.WorkOrder = ""
            D4010.WorkOrderSeq = ""
            D4010.selJob = ""
            D4010.selProd = ""
            D4010.DateStart = ""
            D4010.DateFinish = ""
            D4010.DatePlanStart = ""
            D4010.DatePlanFinish = ""
            D4010.JobCardBefore = ""
            D4010.JobCardAfter = ""
            D4010.CheckPlan = ""
            D4010.CheckUse = ""
            D4010.MaterialStatus = ""
            D4010.MoldStatus = ""
            D4010.LastStatus = ""
            D4010.CuttingDieStatus = ""
            D4010.SoleStatus = ""
            D4010.SoleNo = ""
            D4010.CuttingStatus = ""
            D4010.CuttingNo = ""
            D4010.StitchingStatus = ""
            D4010.StitchingNo = ""
            D4010.SubprocessStatus = ""
            D4010.SubprocessNo = ""
            D4010.OutsourceStatsus = ""
            D4010.OutsourceNo = ""
            D4010.StockfitStatsus = ""
            D4010.StockfitNo = ""
            D4010.AssemblyStatus = ""
            D4010.AssemblyNo = ""
            D4010.QtyOrder = 0
            D4010.QtyPlan = 0
            D4010.QtyJob = 0
            D4010.QtyJobSole = 0
            D4010.QtyBatchSole = 0
            D4010.QtySole = 0
            D4010.QtySoleA = 0
            D4010.QtySoleX = 0
            D4010.QtySoleXP = 0
            D4010.QtySoleXR = 0
            D4010.QtySoleBLOut = 0
            D4010.QtySoleBLIn = 0
            D4010.QtyJobCutting = 0
            D4010.QtyBatchCutting = 0
            D4010.QtyCom = 0
            D4010.QtyCutting = 0
            D4010.QtyCuttingA = 0
            D4010.QtyCuttingX = 0
            D4010.QtyCuttingXP = 0
            D4010.QtyCuttingXR = 0
            D4010.QtyCuttingBLOut = 0
            D4010.QtyCuttingBLIn = 0
            D4010.QtyJobStitching = 0
            D4010.QtyBatchStitching = 0
            D4010.QtyStitching = 0
            D4010.QtyStitchingA = 0
            D4010.QtyStitchingX = 0
            D4010.QtyStitchingXP = 0
            D4010.QtyStitchingXR = 0
            D4010.QtyStitchingBLOut = 0
            D4010.QtyStitchingBLIn = 0
            D4010.QtyJobStockfit = 0
            D4010.QtyBatchStockfit = 0
            D4010.QtyStockfit = 0
            D4010.QtyStockfitA = 0
            D4010.QtyStockfitX = 0
            D4010.QtyStockfitXP = 0
            D4010.QtyStockfitXR = 0
            D4010.QtyStockfitBLOut = 0
            D4010.QtyStockfitBLIn = 0
            D4010.QtyJobAssembly = 0
            D4010.QtyBatchAssembly = 0
            D4010.QtyAssembly = 0
            D4010.QtyAssemblyA = 0
            D4010.QtyAssemblyX = 0
            D4010.QtyAssemblyXP = 0
            D4010.QtyAssemblyXR = 0
            D4010.QtyAssemblyBLOut = 0
            D4010.QtyAssemblyBLIn = 0
            D4010.QtyJobPacking = 0
            D4010.QtyBatchPacking = 0
            D4010.QtyPacking = 0
            D4010.QtyPackingA = 0
            D4010.QtyPackingX = 0
            D4010.QtyPackingXP = 0
            D4010.QtyPackingXR = 0
            D4010.QtyPackingBLOut = 0
            D4010.QtyPackingBLIn = 0
            D4010.QtyJobShipping = 0
            D4010.QtyBatchShipping = 0
            D4010.QtyShipping = 0
            D4010.QtyShippingA = 0
            D4010.QtyShippingX = 0
            D4010.QtyShippingBLOut = 0
            D4010.QtyShippingBLIn = 0
            D4010.QtyFootbed = 0
            D4010.QtyFootbedA = 0
            D4010.QtyFootbedX = 0
            D4010.QtyInnerBox = 0
            D4010.QtyInnerBoxA = 0
            D4010.QtyInnerBoxX = 0
            D4010.QtyInbound = 0
            D4010.QtyInboundA = 0
            D4010.QtyInboundX = 0
            D4010.QtySB2UI = 0
            D4010.QtySB2UIA = 0
            D4010.QtySB2UIX = 0
            D4010.QtySB2UO = 0
            D4010.QtySB2UOA = 0
            D4010.QtySB2UOX = 0
            D4010.QtySB2SI = 0
            D4010.QtySB2SIA = 0
            D4010.QtySB2SIX = 0
            D4010.QtySB2SO = 0
            D4010.QtySB2SOA = 0
            D4010.QtySB2SOX = 0
            D4010.QtySB2FI = 0
            D4010.QtySB2FIA = 0
            D4010.QtySB2FIX = 0
            D4010.QtySB2FO = 0
            D4010.QtySB2FOA = 0
            D4010.QtySB2FOX = 0
            D4010.seFactory = ""
            D4010.cdFactory = ""
            D4010.seLineProd1 = ""
            D4010.cdLineProd1 = ""
            D4010.seLineProd2 = ""
            D4010.cdLineProd2 = ""
            D4010.seLineProd3 = ""
            D4010.cdLineProd3 = ""
            D4010.DateInsert = ""
            D4010.InchargeInsert = ""
            D4010.DateUpdate = ""
            D4010.InchargeUpdate = ""
            D4010.RemarkOrder = ""
            D4010.RemarkCustomer = ""
            D4010.RemarkOther = ""
            D4010.seSite = ""
            D4010.cdSite = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D4010_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x4010 As T4010_AREA)
        Try

            x4010.JobCard = trim$(x4010.JobCard)
            x4010.seJobState = trim$(x4010.seJobState)
            x4010.cdJobState = trim$(x4010.cdJobState)
            x4010.SealNo = trim$(x4010.SealNo)
            x4010.SlNoD = trim$(x4010.SlNoD)
            x4010.WorkOrder = trim$(x4010.WorkOrder)
            x4010.WorkOrderSeq = trim$(x4010.WorkOrderSeq)
            x4010.selJob = trim$(x4010.selJob)
            x4010.selProd = trim$(x4010.selProd)
            x4010.DateStart = trim$(x4010.DateStart)
            x4010.DateFinish = trim$(x4010.DateFinish)
            x4010.DatePlanStart = trim$(x4010.DatePlanStart)
            x4010.DatePlanFinish = trim$(x4010.DatePlanFinish)
            x4010.JobCardBefore = trim$(x4010.JobCardBefore)
            x4010.JobCardAfter = trim$(x4010.JobCardAfter)
            x4010.CheckPlan = trim$(x4010.CheckPlan)
            x4010.CheckUse = trim$(x4010.CheckUse)
            x4010.MaterialStatus = trim$(x4010.MaterialStatus)
            x4010.MoldStatus = trim$(x4010.MoldStatus)
            x4010.LastStatus = trim$(x4010.LastStatus)
            x4010.CuttingDieStatus = trim$(x4010.CuttingDieStatus)
            x4010.SoleStatus = trim$(x4010.SoleStatus)
            x4010.SoleNo = trim$(x4010.SoleNo)
            x4010.CuttingStatus = trim$(x4010.CuttingStatus)
            x4010.CuttingNo = trim$(x4010.CuttingNo)
            x4010.StitchingStatus = trim$(x4010.StitchingStatus)
            x4010.StitchingNo = trim$(x4010.StitchingNo)
            x4010.SubprocessStatus = trim$(x4010.SubprocessStatus)
            x4010.SubprocessNo = trim$(x4010.SubprocessNo)
            x4010.OutsourceStatsus = trim$(x4010.OutsourceStatsus)
            x4010.OutsourceNo = trim$(x4010.OutsourceNo)
            x4010.StockfitStatsus = trim$(x4010.StockfitStatsus)
            x4010.StockfitNo = trim$(x4010.StockfitNo)
            x4010.AssemblyStatus = trim$(x4010.AssemblyStatus)
            x4010.AssemblyNo = trim$(x4010.AssemblyNo)
            x4010.QtyOrder = trim$(x4010.QtyOrder)
            x4010.QtyPlan = trim$(x4010.QtyPlan)
            x4010.QtyJob = trim$(x4010.QtyJob)
            x4010.QtyJobSole = trim$(x4010.QtyJobSole)
            x4010.QtyBatchSole = trim$(x4010.QtyBatchSole)
            x4010.QtySole = trim$(x4010.QtySole)
            x4010.QtySoleA = trim$(x4010.QtySoleA)
            x4010.QtySoleX = trim$(x4010.QtySoleX)
            x4010.QtySoleXP = trim$(x4010.QtySoleXP)
            x4010.QtySoleXR = trim$(x4010.QtySoleXR)
            x4010.QtySoleBLOut = trim$(x4010.QtySoleBLOut)
            x4010.QtySoleBLIn = trim$(x4010.QtySoleBLIn)
            x4010.QtyJobCutting = trim$(x4010.QtyJobCutting)
            x4010.QtyBatchCutting = trim$(x4010.QtyBatchCutting)
            x4010.QtyCom = trim$(x4010.QtyCom)
            x4010.QtyCutting = trim$(x4010.QtyCutting)
            x4010.QtyCuttingA = trim$(x4010.QtyCuttingA)
            x4010.QtyCuttingX = trim$(x4010.QtyCuttingX)
            x4010.QtyCuttingXP = trim$(x4010.QtyCuttingXP)
            x4010.QtyCuttingXR = trim$(x4010.QtyCuttingXR)
            x4010.QtyCuttingBLOut = trim$(x4010.QtyCuttingBLOut)
            x4010.QtyCuttingBLIn = trim$(x4010.QtyCuttingBLIn)
            x4010.QtyJobStitching = trim$(x4010.QtyJobStitching)
            x4010.QtyBatchStitching = trim$(x4010.QtyBatchStitching)
            x4010.QtyStitching = trim$(x4010.QtyStitching)
            x4010.QtyStitchingA = trim$(x4010.QtyStitchingA)
            x4010.QtyStitchingX = trim$(x4010.QtyStitchingX)
            x4010.QtyStitchingXP = trim$(x4010.QtyStitchingXP)
            x4010.QtyStitchingXR = trim$(x4010.QtyStitchingXR)
            x4010.QtyStitchingBLOut = trim$(x4010.QtyStitchingBLOut)
            x4010.QtyStitchingBLIn = trim$(x4010.QtyStitchingBLIn)
            x4010.QtyJobStockfit = trim$(x4010.QtyJobStockfit)
            x4010.QtyBatchStockfit = trim$(x4010.QtyBatchStockfit)
            x4010.QtyStockfit = trim$(x4010.QtyStockfit)
            x4010.QtyStockfitA = trim$(x4010.QtyStockfitA)
            x4010.QtyStockfitX = trim$(x4010.QtyStockfitX)
            x4010.QtyStockfitXP = trim$(x4010.QtyStockfitXP)
            x4010.QtyStockfitXR = trim$(x4010.QtyStockfitXR)
            x4010.QtyStockfitBLOut = trim$(x4010.QtyStockfitBLOut)
            x4010.QtyStockfitBLIn = trim$(x4010.QtyStockfitBLIn)
            x4010.QtyJobAssembly = trim$(x4010.QtyJobAssembly)
            x4010.QtyBatchAssembly = trim$(x4010.QtyBatchAssembly)
            x4010.QtyAssembly = trim$(x4010.QtyAssembly)
            x4010.QtyAssemblyA = trim$(x4010.QtyAssemblyA)
            x4010.QtyAssemblyX = trim$(x4010.QtyAssemblyX)
            x4010.QtyAssemblyXP = trim$(x4010.QtyAssemblyXP)
            x4010.QtyAssemblyXR = trim$(x4010.QtyAssemblyXR)
            x4010.QtyAssemblyBLOut = trim$(x4010.QtyAssemblyBLOut)
            x4010.QtyAssemblyBLIn = trim$(x4010.QtyAssemblyBLIn)
            x4010.QtyJobPacking = trim$(x4010.QtyJobPacking)
            x4010.QtyBatchPacking = trim$(x4010.QtyBatchPacking)
            x4010.QtyPacking = trim$(x4010.QtyPacking)
            x4010.QtyPackingA = trim$(x4010.QtyPackingA)
            x4010.QtyPackingX = trim$(x4010.QtyPackingX)
            x4010.QtyPackingXP = trim$(x4010.QtyPackingXP)
            x4010.QtyPackingXR = trim$(x4010.QtyPackingXR)
            x4010.QtyPackingBLOut = trim$(x4010.QtyPackingBLOut)
            x4010.QtyPackingBLIn = trim$(x4010.QtyPackingBLIn)
            x4010.QtyJobShipping = trim$(x4010.QtyJobShipping)
            x4010.QtyBatchShipping = trim$(x4010.QtyBatchShipping)
            x4010.QtyShipping = trim$(x4010.QtyShipping)
            x4010.QtyShippingA = trim$(x4010.QtyShippingA)
            x4010.QtyShippingX = trim$(x4010.QtyShippingX)
            x4010.QtyShippingBLOut = trim$(x4010.QtyShippingBLOut)
            x4010.QtyShippingBLIn = trim$(x4010.QtyShippingBLIn)
            x4010.QtyFootbed = trim$(x4010.QtyFootbed)
            x4010.QtyFootbedA = trim$(x4010.QtyFootbedA)
            x4010.QtyFootbedX = trim$(x4010.QtyFootbedX)
            x4010.QtyInnerBox = trim$(x4010.QtyInnerBox)
            x4010.QtyInnerBoxA = trim$(x4010.QtyInnerBoxA)
            x4010.QtyInnerBoxX = trim$(x4010.QtyInnerBoxX)
            x4010.QtyInbound = trim$(x4010.QtyInbound)
            x4010.QtyInboundA = trim$(x4010.QtyInboundA)
            x4010.QtyInboundX = trim$(x4010.QtyInboundX)
            x4010.QtySB2UI = trim$(x4010.QtySB2UI)
            x4010.QtySB2UIA = trim$(x4010.QtySB2UIA)
            x4010.QtySB2UIX = trim$(x4010.QtySB2UIX)
            x4010.QtySB2UO = trim$(x4010.QtySB2UO)
            x4010.QtySB2UOA = trim$(x4010.QtySB2UOA)
            x4010.QtySB2UOX = trim$(x4010.QtySB2UOX)
            x4010.QtySB2SI = trim$(x4010.QtySB2SI)
            x4010.QtySB2SIA = trim$(x4010.QtySB2SIA)
            x4010.QtySB2SIX = trim$(x4010.QtySB2SIX)
            x4010.QtySB2SO = trim$(x4010.QtySB2SO)
            x4010.QtySB2SOA = trim$(x4010.QtySB2SOA)
            x4010.QtySB2SOX = trim$(x4010.QtySB2SOX)
            x4010.QtySB2FI = trim$(x4010.QtySB2FI)
            x4010.QtySB2FIA = trim$(x4010.QtySB2FIA)
            x4010.QtySB2FIX = trim$(x4010.QtySB2FIX)
            x4010.QtySB2FO = trim$(x4010.QtySB2FO)
            x4010.QtySB2FOA = trim$(x4010.QtySB2FOA)
            x4010.QtySB2FOX = trim$(x4010.QtySB2FOX)
            x4010.seFactory = trim$(x4010.seFactory)
            x4010.cdFactory = trim$(x4010.cdFactory)
            x4010.seLineProd1 = trim$(x4010.seLineProd1)
            x4010.cdLineProd1 = trim$(x4010.cdLineProd1)
            x4010.seLineProd2 = trim$(x4010.seLineProd2)
            x4010.cdLineProd2 = trim$(x4010.cdLineProd2)
            x4010.seLineProd3 = trim$(x4010.seLineProd3)
            x4010.cdLineProd3 = trim$(x4010.cdLineProd3)
            x4010.DateInsert = trim$(x4010.DateInsert)
            x4010.InchargeInsert = trim$(x4010.InchargeInsert)
            x4010.DateUpdate = trim$(x4010.DateUpdate)
            x4010.InchargeUpdate = trim$(x4010.InchargeUpdate)
            x4010.RemarkOrder = trim$(x4010.RemarkOrder)
            x4010.RemarkCustomer = trim$(x4010.RemarkCustomer)
            x4010.RemarkOther = trim$(x4010.RemarkOther)
            x4010.seSite = trim$(x4010.seSite)
            x4010.cdSite = trim$(x4010.cdSite)

            If trim$(x4010.JobCard) = "" Then x4010.JobCard = Space(1)
            If trim$(x4010.seJobState) = "" Then x4010.seJobState = Space(1)
            If trim$(x4010.cdJobState) = "" Then x4010.cdJobState = Space(1)
            If trim$(x4010.SealNo) = "" Then x4010.SealNo = Space(1)
            If trim$(x4010.SlNoD) = "" Then x4010.SlNoD = Space(1)
            If trim$(x4010.WorkOrder) = "" Then x4010.WorkOrder = Space(1)
            If trim$(x4010.WorkOrderSeq) = "" Then x4010.WorkOrderSeq = Space(1)
            If trim$(x4010.selJob) = "" Then x4010.selJob = Space(1)
            If trim$(x4010.selProd) = "" Then x4010.selProd = Space(1)
            If trim$(x4010.DateStart) = "" Then x4010.DateStart = Space(1)
            If trim$(x4010.DateFinish) = "" Then x4010.DateFinish = Space(1)
            If trim$(x4010.DatePlanStart) = "" Then x4010.DatePlanStart = Space(1)
            If trim$(x4010.DatePlanFinish) = "" Then x4010.DatePlanFinish = Space(1)
            If trim$(x4010.JobCardBefore) = "" Then x4010.JobCardBefore = Space(1)
            If trim$(x4010.JobCardAfter) = "" Then x4010.JobCardAfter = Space(1)
            If trim$(x4010.CheckPlan) = "" Then x4010.CheckPlan = Space(1)
            If trim$(x4010.CheckUse) = "" Then x4010.CheckUse = Space(1)
            If trim$(x4010.MaterialStatus) = "" Then x4010.MaterialStatus = Space(1)
            If trim$(x4010.MoldStatus) = "" Then x4010.MoldStatus = Space(1)
            If trim$(x4010.LastStatus) = "" Then x4010.LastStatus = Space(1)
            If trim$(x4010.CuttingDieStatus) = "" Then x4010.CuttingDieStatus = Space(1)
            If trim$(x4010.SoleStatus) = "" Then x4010.SoleStatus = Space(1)
            If trim$(x4010.SoleNo) = "" Then x4010.SoleNo = Space(1)
            If trim$(x4010.CuttingStatus) = "" Then x4010.CuttingStatus = Space(1)
            If trim$(x4010.CuttingNo) = "" Then x4010.CuttingNo = Space(1)
            If trim$(x4010.StitchingStatus) = "" Then x4010.StitchingStatus = Space(1)
            If trim$(x4010.StitchingNo) = "" Then x4010.StitchingNo = Space(1)
            If trim$(x4010.SubprocessStatus) = "" Then x4010.SubprocessStatus = Space(1)
            If trim$(x4010.SubprocessNo) = "" Then x4010.SubprocessNo = Space(1)
            If trim$(x4010.OutsourceStatsus) = "" Then x4010.OutsourceStatsus = Space(1)
            If trim$(x4010.OutsourceNo) = "" Then x4010.OutsourceNo = Space(1)
            If trim$(x4010.StockfitStatsus) = "" Then x4010.StockfitStatsus = Space(1)
            If trim$(x4010.StockfitNo) = "" Then x4010.StockfitNo = Space(1)
            If trim$(x4010.AssemblyStatus) = "" Then x4010.AssemblyStatus = Space(1)
            If trim$(x4010.AssemblyNo) = "" Then x4010.AssemblyNo = Space(1)
            If trim$(x4010.QtyOrder) = "" Then x4010.QtyOrder = 0
            If trim$(x4010.QtyPlan) = "" Then x4010.QtyPlan = 0
            If trim$(x4010.QtyJob) = "" Then x4010.QtyJob = 0
            If trim$(x4010.QtyJobSole) = "" Then x4010.QtyJobSole = 0
            If trim$(x4010.QtyBatchSole) = "" Then x4010.QtyBatchSole = 0
            If trim$(x4010.QtySole) = "" Then x4010.QtySole = 0
            If trim$(x4010.QtySoleA) = "" Then x4010.QtySoleA = 0
            If trim$(x4010.QtySoleX) = "" Then x4010.QtySoleX = 0
            If trim$(x4010.QtySoleXP) = "" Then x4010.QtySoleXP = 0
            If trim$(x4010.QtySoleXR) = "" Then x4010.QtySoleXR = 0
            If trim$(x4010.QtySoleBLOut) = "" Then x4010.QtySoleBLOut = 0
            If trim$(x4010.QtySoleBLIn) = "" Then x4010.QtySoleBLIn = 0
            If trim$(x4010.QtyJobCutting) = "" Then x4010.QtyJobCutting = 0
            If trim$(x4010.QtyBatchCutting) = "" Then x4010.QtyBatchCutting = 0
            If trim$(x4010.QtyCom) = "" Then x4010.QtyCom = 0
            If trim$(x4010.QtyCutting) = "" Then x4010.QtyCutting = 0
            If trim$(x4010.QtyCuttingA) = "" Then x4010.QtyCuttingA = 0
            If trim$(x4010.QtyCuttingX) = "" Then x4010.QtyCuttingX = 0
            If trim$(x4010.QtyCuttingXP) = "" Then x4010.QtyCuttingXP = 0
            If trim$(x4010.QtyCuttingXR) = "" Then x4010.QtyCuttingXR = 0
            If trim$(x4010.QtyCuttingBLOut) = "" Then x4010.QtyCuttingBLOut = 0
            If trim$(x4010.QtyCuttingBLIn) = "" Then x4010.QtyCuttingBLIn = 0
            If trim$(x4010.QtyJobStitching) = "" Then x4010.QtyJobStitching = 0
            If trim$(x4010.QtyBatchStitching) = "" Then x4010.QtyBatchStitching = 0
            If trim$(x4010.QtyStitching) = "" Then x4010.QtyStitching = 0
            If trim$(x4010.QtyStitchingA) = "" Then x4010.QtyStitchingA = 0
            If trim$(x4010.QtyStitchingX) = "" Then x4010.QtyStitchingX = 0
            If trim$(x4010.QtyStitchingXP) = "" Then x4010.QtyStitchingXP = 0
            If trim$(x4010.QtyStitchingXR) = "" Then x4010.QtyStitchingXR = 0
            If trim$(x4010.QtyStitchingBLOut) = "" Then x4010.QtyStitchingBLOut = 0
            If trim$(x4010.QtyStitchingBLIn) = "" Then x4010.QtyStitchingBLIn = 0
            If trim$(x4010.QtyJobStockfit) = "" Then x4010.QtyJobStockfit = 0
            If trim$(x4010.QtyBatchStockfit) = "" Then x4010.QtyBatchStockfit = 0
            If trim$(x4010.QtyStockfit) = "" Then x4010.QtyStockfit = 0
            If trim$(x4010.QtyStockfitA) = "" Then x4010.QtyStockfitA = 0
            If trim$(x4010.QtyStockfitX) = "" Then x4010.QtyStockfitX = 0
            If trim$(x4010.QtyStockfitXP) = "" Then x4010.QtyStockfitXP = 0
            If trim$(x4010.QtyStockfitXR) = "" Then x4010.QtyStockfitXR = 0
            If trim$(x4010.QtyStockfitBLOut) = "" Then x4010.QtyStockfitBLOut = 0
            If trim$(x4010.QtyStockfitBLIn) = "" Then x4010.QtyStockfitBLIn = 0
            If trim$(x4010.QtyJobAssembly) = "" Then x4010.QtyJobAssembly = 0
            If trim$(x4010.QtyBatchAssembly) = "" Then x4010.QtyBatchAssembly = 0
            If trim$(x4010.QtyAssembly) = "" Then x4010.QtyAssembly = 0
            If trim$(x4010.QtyAssemblyA) = "" Then x4010.QtyAssemblyA = 0
            If trim$(x4010.QtyAssemblyX) = "" Then x4010.QtyAssemblyX = 0
            If trim$(x4010.QtyAssemblyXP) = "" Then x4010.QtyAssemblyXP = 0
            If trim$(x4010.QtyAssemblyXR) = "" Then x4010.QtyAssemblyXR = 0
            If trim$(x4010.QtyAssemblyBLOut) = "" Then x4010.QtyAssemblyBLOut = 0
            If trim$(x4010.QtyAssemblyBLIn) = "" Then x4010.QtyAssemblyBLIn = 0
            If trim$(x4010.QtyJobPacking) = "" Then x4010.QtyJobPacking = 0
            If trim$(x4010.QtyBatchPacking) = "" Then x4010.QtyBatchPacking = 0
            If trim$(x4010.QtyPacking) = "" Then x4010.QtyPacking = 0
            If trim$(x4010.QtyPackingA) = "" Then x4010.QtyPackingA = 0
            If trim$(x4010.QtyPackingX) = "" Then x4010.QtyPackingX = 0
            If trim$(x4010.QtyPackingXP) = "" Then x4010.QtyPackingXP = 0
            If trim$(x4010.QtyPackingXR) = "" Then x4010.QtyPackingXR = 0
            If trim$(x4010.QtyPackingBLOut) = "" Then x4010.QtyPackingBLOut = 0
            If trim$(x4010.QtyPackingBLIn) = "" Then x4010.QtyPackingBLIn = 0
            If trim$(x4010.QtyJobShipping) = "" Then x4010.QtyJobShipping = 0
            If trim$(x4010.QtyBatchShipping) = "" Then x4010.QtyBatchShipping = 0
            If trim$(x4010.QtyShipping) = "" Then x4010.QtyShipping = 0
            If trim$(x4010.QtyShippingA) = "" Then x4010.QtyShippingA = 0
            If trim$(x4010.QtyShippingX) = "" Then x4010.QtyShippingX = 0
            If trim$(x4010.QtyShippingBLOut) = "" Then x4010.QtyShippingBLOut = 0
            If trim$(x4010.QtyShippingBLIn) = "" Then x4010.QtyShippingBLIn = 0
            If trim$(x4010.QtyFootbed) = "" Then x4010.QtyFootbed = 0
            If trim$(x4010.QtyFootbedA) = "" Then x4010.QtyFootbedA = 0
            If trim$(x4010.QtyFootbedX) = "" Then x4010.QtyFootbedX = 0
            If trim$(x4010.QtyInnerBox) = "" Then x4010.QtyInnerBox = 0
            If trim$(x4010.QtyInnerBoxA) = "" Then x4010.QtyInnerBoxA = 0
            If trim$(x4010.QtyInnerBoxX) = "" Then x4010.QtyInnerBoxX = 0
            If trim$(x4010.QtyInbound) = "" Then x4010.QtyInbound = 0
            If trim$(x4010.QtyInboundA) = "" Then x4010.QtyInboundA = 0
            If trim$(x4010.QtyInboundX) = "" Then x4010.QtyInboundX = 0
            If trim$(x4010.QtySB2UI) = "" Then x4010.QtySB2UI = 0
            If trim$(x4010.QtySB2UIA) = "" Then x4010.QtySB2UIA = 0
            If trim$(x4010.QtySB2UIX) = "" Then x4010.QtySB2UIX = 0
            If trim$(x4010.QtySB2UO) = "" Then x4010.QtySB2UO = 0
            If trim$(x4010.QtySB2UOA) = "" Then x4010.QtySB2UOA = 0
            If trim$(x4010.QtySB2UOX) = "" Then x4010.QtySB2UOX = 0
            If trim$(x4010.QtySB2SI) = "" Then x4010.QtySB2SI = 0
            If trim$(x4010.QtySB2SIA) = "" Then x4010.QtySB2SIA = 0
            If trim$(x4010.QtySB2SIX) = "" Then x4010.QtySB2SIX = 0
            If trim$(x4010.QtySB2SO) = "" Then x4010.QtySB2SO = 0
            If trim$(x4010.QtySB2SOA) = "" Then x4010.QtySB2SOA = 0
            If trim$(x4010.QtySB2SOX) = "" Then x4010.QtySB2SOX = 0
            If trim$(x4010.QtySB2FI) = "" Then x4010.QtySB2FI = 0
            If trim$(x4010.QtySB2FIA) = "" Then x4010.QtySB2FIA = 0
            If trim$(x4010.QtySB2FIX) = "" Then x4010.QtySB2FIX = 0
            If trim$(x4010.QtySB2FO) = "" Then x4010.QtySB2FO = 0
            If trim$(x4010.QtySB2FOA) = "" Then x4010.QtySB2FOA = 0
            If trim$(x4010.QtySB2FOX) = "" Then x4010.QtySB2FOX = 0
            If trim$(x4010.seFactory) = "" Then x4010.seFactory = Space(1)
            If trim$(x4010.cdFactory) = "" Then x4010.cdFactory = Space(1)
            If trim$(x4010.seLineProd1) = "" Then x4010.seLineProd1 = Space(1)
            If trim$(x4010.cdLineProd1) = "" Then x4010.cdLineProd1 = Space(1)
            If trim$(x4010.seLineProd2) = "" Then x4010.seLineProd2 = Space(1)
            If trim$(x4010.cdLineProd2) = "" Then x4010.cdLineProd2 = Space(1)
            If trim$(x4010.seLineProd3) = "" Then x4010.seLineProd3 = Space(1)
            If trim$(x4010.cdLineProd3) = "" Then x4010.cdLineProd3 = Space(1)
            If trim$(x4010.DateInsert) = "" Then x4010.DateInsert = Space(1)
            If trim$(x4010.InchargeInsert) = "" Then x4010.InchargeInsert = Space(1)
            If trim$(x4010.DateUpdate) = "" Then x4010.DateUpdate = Space(1)
            If trim$(x4010.InchargeUpdate) = "" Then x4010.InchargeUpdate = Space(1)
            If trim$(x4010.RemarkOrder) = "" Then x4010.RemarkOrder = Space(1)
            If trim$(x4010.RemarkCustomer) = "" Then x4010.RemarkCustomer = Space(1)
            If trim$(x4010.RemarkOther) = "" Then x4010.RemarkOther = Space(1)
            If trim$(x4010.seSite) = "" Then x4010.seSite = Space(1)
            If trim$(x4010.cdSite) = "" Then x4010.cdSite = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K4010_MOVE(rs4010 As SqlClient.SqlDataReader)
        Try

            Call D4010_CLEAR()

            If IsdbNull(rs4010!K4010_JobCard) = False Then D4010.JobCard = Trim$(rs4010!K4010_JobCard)
            If IsdbNull(rs4010!K4010_seJobState) = False Then D4010.seJobState = Trim$(rs4010!K4010_seJobState)
            If IsdbNull(rs4010!K4010_cdJobState) = False Then D4010.cdJobState = Trim$(rs4010!K4010_cdJobState)
            If IsdbNull(rs4010!K4010_SealNo) = False Then D4010.SealNo = Trim$(rs4010!K4010_SealNo)
            If IsdbNull(rs4010!K4010_SlNoD) = False Then D4010.SlNoD = Trim$(rs4010!K4010_SlNoD)
            If IsdbNull(rs4010!K4010_WorkOrder) = False Then D4010.WorkOrder = Trim$(rs4010!K4010_WorkOrder)
            If IsdbNull(rs4010!K4010_WorkOrderSeq) = False Then D4010.WorkOrderSeq = Trim$(rs4010!K4010_WorkOrderSeq)
            If IsdbNull(rs4010!K4010_selJob) = False Then D4010.selJob = Trim$(rs4010!K4010_selJob)
            If IsdbNull(rs4010!K4010_selProd) = False Then D4010.selProd = Trim$(rs4010!K4010_selProd)
            If IsdbNull(rs4010!K4010_DateStart) = False Then D4010.DateStart = Trim$(rs4010!K4010_DateStart)
            If IsdbNull(rs4010!K4010_DateFinish) = False Then D4010.DateFinish = Trim$(rs4010!K4010_DateFinish)
            If IsdbNull(rs4010!K4010_DatePlanStart) = False Then D4010.DatePlanStart = Trim$(rs4010!K4010_DatePlanStart)
            If IsdbNull(rs4010!K4010_DatePlanFinish) = False Then D4010.DatePlanFinish = Trim$(rs4010!K4010_DatePlanFinish)
            If IsdbNull(rs4010!K4010_JobCardBefore) = False Then D4010.JobCardBefore = Trim$(rs4010!K4010_JobCardBefore)
            If IsdbNull(rs4010!K4010_JobCardAfter) = False Then D4010.JobCardAfter = Trim$(rs4010!K4010_JobCardAfter)
            If IsdbNull(rs4010!K4010_CheckPlan) = False Then D4010.CheckPlan = Trim$(rs4010!K4010_CheckPlan)
            If IsdbNull(rs4010!K4010_CheckUse) = False Then D4010.CheckUse = Trim$(rs4010!K4010_CheckUse)
            If IsdbNull(rs4010!K4010_MaterialStatus) = False Then D4010.MaterialStatus = Trim$(rs4010!K4010_MaterialStatus)
            If IsdbNull(rs4010!K4010_MoldStatus) = False Then D4010.MoldStatus = Trim$(rs4010!K4010_MoldStatus)
            If IsdbNull(rs4010!K4010_LastStatus) = False Then D4010.LastStatus = Trim$(rs4010!K4010_LastStatus)
            If IsdbNull(rs4010!K4010_CuttingDieStatus) = False Then D4010.CuttingDieStatus = Trim$(rs4010!K4010_CuttingDieStatus)
            If IsdbNull(rs4010!K4010_SoleStatus) = False Then D4010.SoleStatus = Trim$(rs4010!K4010_SoleStatus)
            If IsdbNull(rs4010!K4010_SoleNo) = False Then D4010.SoleNo = Trim$(rs4010!K4010_SoleNo)
            If IsdbNull(rs4010!K4010_CuttingStatus) = False Then D4010.CuttingStatus = Trim$(rs4010!K4010_CuttingStatus)
            If IsdbNull(rs4010!K4010_CuttingNo) = False Then D4010.CuttingNo = Trim$(rs4010!K4010_CuttingNo)
            If IsdbNull(rs4010!K4010_StitchingStatus) = False Then D4010.StitchingStatus = Trim$(rs4010!K4010_StitchingStatus)
            If IsdbNull(rs4010!K4010_StitchingNo) = False Then D4010.StitchingNo = Trim$(rs4010!K4010_StitchingNo)
            If IsdbNull(rs4010!K4010_SubprocessStatus) = False Then D4010.SubprocessStatus = Trim$(rs4010!K4010_SubprocessStatus)
            If IsdbNull(rs4010!K4010_SubprocessNo) = False Then D4010.SubprocessNo = Trim$(rs4010!K4010_SubprocessNo)
            If IsdbNull(rs4010!K4010_OutsourceStatsus) = False Then D4010.OutsourceStatsus = Trim$(rs4010!K4010_OutsourceStatsus)
            If IsdbNull(rs4010!K4010_OutsourceNo) = False Then D4010.OutsourceNo = Trim$(rs4010!K4010_OutsourceNo)
            If IsdbNull(rs4010!K4010_StockfitStatsus) = False Then D4010.StockfitStatsus = Trim$(rs4010!K4010_StockfitStatsus)
            If IsdbNull(rs4010!K4010_StockfitNo) = False Then D4010.StockfitNo = Trim$(rs4010!K4010_StockfitNo)
            If IsdbNull(rs4010!K4010_AssemblyStatus) = False Then D4010.AssemblyStatus = Trim$(rs4010!K4010_AssemblyStatus)
            If IsdbNull(rs4010!K4010_AssemblyNo) = False Then D4010.AssemblyNo = Trim$(rs4010!K4010_AssemblyNo)
            If IsdbNull(rs4010!K4010_QtyOrder) = False Then D4010.QtyOrder = Trim$(rs4010!K4010_QtyOrder)
            If IsdbNull(rs4010!K4010_QtyPlan) = False Then D4010.QtyPlan = Trim$(rs4010!K4010_QtyPlan)
            If IsdbNull(rs4010!K4010_QtyJob) = False Then D4010.QtyJob = Trim$(rs4010!K4010_QtyJob)
            If IsdbNull(rs4010!K4010_QtyJobSole) = False Then D4010.QtyJobSole = Trim$(rs4010!K4010_QtyJobSole)
            If IsdbNull(rs4010!K4010_QtyBatchSole) = False Then D4010.QtyBatchSole = Trim$(rs4010!K4010_QtyBatchSole)
            If IsdbNull(rs4010!K4010_QtySole) = False Then D4010.QtySole = Trim$(rs4010!K4010_QtySole)
            If IsdbNull(rs4010!K4010_QtySoleA) = False Then D4010.QtySoleA = Trim$(rs4010!K4010_QtySoleA)
            If IsdbNull(rs4010!K4010_QtySoleX) = False Then D4010.QtySoleX = Trim$(rs4010!K4010_QtySoleX)
            If IsdbNull(rs4010!K4010_QtySoleXP) = False Then D4010.QtySoleXP = Trim$(rs4010!K4010_QtySoleXP)
            If IsdbNull(rs4010!K4010_QtySoleXR) = False Then D4010.QtySoleXR = Trim$(rs4010!K4010_QtySoleXR)
            If IsdbNull(rs4010!K4010_QtySoleBLOut) = False Then D4010.QtySoleBLOut = Trim$(rs4010!K4010_QtySoleBLOut)
            If IsdbNull(rs4010!K4010_QtySoleBLIn) = False Then D4010.QtySoleBLIn = Trim$(rs4010!K4010_QtySoleBLIn)
            If IsdbNull(rs4010!K4010_QtyJobCutting) = False Then D4010.QtyJobCutting = Trim$(rs4010!K4010_QtyJobCutting)
            If IsdbNull(rs4010!K4010_QtyBatchCutting) = False Then D4010.QtyBatchCutting = Trim$(rs4010!K4010_QtyBatchCutting)
            If IsdbNull(rs4010!K4010_QtyCom) = False Then D4010.QtyCom = Trim$(rs4010!K4010_QtyCom)
            If IsdbNull(rs4010!K4010_QtyCutting) = False Then D4010.QtyCutting = Trim$(rs4010!K4010_QtyCutting)
            If IsdbNull(rs4010!K4010_QtyCuttingA) = False Then D4010.QtyCuttingA = Trim$(rs4010!K4010_QtyCuttingA)
            If IsdbNull(rs4010!K4010_QtyCuttingX) = False Then D4010.QtyCuttingX = Trim$(rs4010!K4010_QtyCuttingX)
            If IsdbNull(rs4010!K4010_QtyCuttingXP) = False Then D4010.QtyCuttingXP = Trim$(rs4010!K4010_QtyCuttingXP)
            If IsdbNull(rs4010!K4010_QtyCuttingXR) = False Then D4010.QtyCuttingXR = Trim$(rs4010!K4010_QtyCuttingXR)
            If IsdbNull(rs4010!K4010_QtyCuttingBLOut) = False Then D4010.QtyCuttingBLOut = Trim$(rs4010!K4010_QtyCuttingBLOut)
            If IsdbNull(rs4010!K4010_QtyCuttingBLIn) = False Then D4010.QtyCuttingBLIn = Trim$(rs4010!K4010_QtyCuttingBLIn)
            If IsdbNull(rs4010!K4010_QtyJobStitching) = False Then D4010.QtyJobStitching = Trim$(rs4010!K4010_QtyJobStitching)
            If IsdbNull(rs4010!K4010_QtyBatchStitching) = False Then D4010.QtyBatchStitching = Trim$(rs4010!K4010_QtyBatchStitching)
            If IsdbNull(rs4010!K4010_QtyStitching) = False Then D4010.QtyStitching = Trim$(rs4010!K4010_QtyStitching)
            If IsdbNull(rs4010!K4010_QtyStitchingA) = False Then D4010.QtyStitchingA = Trim$(rs4010!K4010_QtyStitchingA)
            If IsdbNull(rs4010!K4010_QtyStitchingX) = False Then D4010.QtyStitchingX = Trim$(rs4010!K4010_QtyStitchingX)
            If IsdbNull(rs4010!K4010_QtyStitchingXP) = False Then D4010.QtyStitchingXP = Trim$(rs4010!K4010_QtyStitchingXP)
            If IsdbNull(rs4010!K4010_QtyStitchingXR) = False Then D4010.QtyStitchingXR = Trim$(rs4010!K4010_QtyStitchingXR)
            If IsdbNull(rs4010!K4010_QtyStitchingBLOut) = False Then D4010.QtyStitchingBLOut = Trim$(rs4010!K4010_QtyStitchingBLOut)
            If IsdbNull(rs4010!K4010_QtyStitchingBLIn) = False Then D4010.QtyStitchingBLIn = Trim$(rs4010!K4010_QtyStitchingBLIn)
            If IsdbNull(rs4010!K4010_QtyJobStockfit) = False Then D4010.QtyJobStockfit = Trim$(rs4010!K4010_QtyJobStockfit)
            If IsdbNull(rs4010!K4010_QtyBatchStockfit) = False Then D4010.QtyBatchStockfit = Trim$(rs4010!K4010_QtyBatchStockfit)
            If IsdbNull(rs4010!K4010_QtyStockfit) = False Then D4010.QtyStockfit = Trim$(rs4010!K4010_QtyStockfit)
            If IsdbNull(rs4010!K4010_QtyStockfitA) = False Then D4010.QtyStockfitA = Trim$(rs4010!K4010_QtyStockfitA)
            If IsdbNull(rs4010!K4010_QtyStockfitX) = False Then D4010.QtyStockfitX = Trim$(rs4010!K4010_QtyStockfitX)
            If IsdbNull(rs4010!K4010_QtyStockfitXP) = False Then D4010.QtyStockfitXP = Trim$(rs4010!K4010_QtyStockfitXP)
            If IsdbNull(rs4010!K4010_QtyStockfitXR) = False Then D4010.QtyStockfitXR = Trim$(rs4010!K4010_QtyStockfitXR)
            If IsdbNull(rs4010!K4010_QtyStockfitBLOut) = False Then D4010.QtyStockfitBLOut = Trim$(rs4010!K4010_QtyStockfitBLOut)
            If IsdbNull(rs4010!K4010_QtyStockfitBLIn) = False Then D4010.QtyStockfitBLIn = Trim$(rs4010!K4010_QtyStockfitBLIn)
            If IsdbNull(rs4010!K4010_QtyJobAssembly) = False Then D4010.QtyJobAssembly = Trim$(rs4010!K4010_QtyJobAssembly)
            If IsdbNull(rs4010!K4010_QtyBatchAssembly) = False Then D4010.QtyBatchAssembly = Trim$(rs4010!K4010_QtyBatchAssembly)
            If IsdbNull(rs4010!K4010_QtyAssembly) = False Then D4010.QtyAssembly = Trim$(rs4010!K4010_QtyAssembly)
            If IsdbNull(rs4010!K4010_QtyAssemblyA) = False Then D4010.QtyAssemblyA = Trim$(rs4010!K4010_QtyAssemblyA)
            If IsdbNull(rs4010!K4010_QtyAssemblyX) = False Then D4010.QtyAssemblyX = Trim$(rs4010!K4010_QtyAssemblyX)
            If IsdbNull(rs4010!K4010_QtyAssemblyXP) = False Then D4010.QtyAssemblyXP = Trim$(rs4010!K4010_QtyAssemblyXP)
            If IsdbNull(rs4010!K4010_QtyAssemblyXR) = False Then D4010.QtyAssemblyXR = Trim$(rs4010!K4010_QtyAssemblyXR)
            If IsdbNull(rs4010!K4010_QtyAssemblyBLOut) = False Then D4010.QtyAssemblyBLOut = Trim$(rs4010!K4010_QtyAssemblyBLOut)
            If IsdbNull(rs4010!K4010_QtyAssemblyBLIn) = False Then D4010.QtyAssemblyBLIn = Trim$(rs4010!K4010_QtyAssemblyBLIn)
            If IsdbNull(rs4010!K4010_QtyJobPacking) = False Then D4010.QtyJobPacking = Trim$(rs4010!K4010_QtyJobPacking)
            If IsdbNull(rs4010!K4010_QtyBatchPacking) = False Then D4010.QtyBatchPacking = Trim$(rs4010!K4010_QtyBatchPacking)
            If IsdbNull(rs4010!K4010_QtyPacking) = False Then D4010.QtyPacking = Trim$(rs4010!K4010_QtyPacking)
            If IsdbNull(rs4010!K4010_QtyPackingA) = False Then D4010.QtyPackingA = Trim$(rs4010!K4010_QtyPackingA)
            If IsdbNull(rs4010!K4010_QtyPackingX) = False Then D4010.QtyPackingX = Trim$(rs4010!K4010_QtyPackingX)
            If IsdbNull(rs4010!K4010_QtyPackingXP) = False Then D4010.QtyPackingXP = Trim$(rs4010!K4010_QtyPackingXP)
            If IsdbNull(rs4010!K4010_QtyPackingXR) = False Then D4010.QtyPackingXR = Trim$(rs4010!K4010_QtyPackingXR)
            If IsdbNull(rs4010!K4010_QtyPackingBLOut) = False Then D4010.QtyPackingBLOut = Trim$(rs4010!K4010_QtyPackingBLOut)
            If IsdbNull(rs4010!K4010_QtyPackingBLIn) = False Then D4010.QtyPackingBLIn = Trim$(rs4010!K4010_QtyPackingBLIn)
            If IsdbNull(rs4010!K4010_QtyJobShipping) = False Then D4010.QtyJobShipping = Trim$(rs4010!K4010_QtyJobShipping)
            If IsdbNull(rs4010!K4010_QtyBatchShipping) = False Then D4010.QtyBatchShipping = Trim$(rs4010!K4010_QtyBatchShipping)
            If IsdbNull(rs4010!K4010_QtyShipping) = False Then D4010.QtyShipping = Trim$(rs4010!K4010_QtyShipping)
            If IsdbNull(rs4010!K4010_QtyShippingA) = False Then D4010.QtyShippingA = Trim$(rs4010!K4010_QtyShippingA)
            If IsdbNull(rs4010!K4010_QtyShippingX) = False Then D4010.QtyShippingX = Trim$(rs4010!K4010_QtyShippingX)
            If IsdbNull(rs4010!K4010_QtyShippingBLOut) = False Then D4010.QtyShippingBLOut = Trim$(rs4010!K4010_QtyShippingBLOut)
            If IsdbNull(rs4010!K4010_QtyShippingBLIn) = False Then D4010.QtyShippingBLIn = Trim$(rs4010!K4010_QtyShippingBLIn)
            If IsdbNull(rs4010!K4010_QtyFootbed) = False Then D4010.QtyFootbed = Trim$(rs4010!K4010_QtyFootbed)
            If IsdbNull(rs4010!K4010_QtyFootbedA) = False Then D4010.QtyFootbedA = Trim$(rs4010!K4010_QtyFootbedA)
            If IsdbNull(rs4010!K4010_QtyFootbedX) = False Then D4010.QtyFootbedX = Trim$(rs4010!K4010_QtyFootbedX)
            If IsdbNull(rs4010!K4010_QtyInnerBox) = False Then D4010.QtyInnerBox = Trim$(rs4010!K4010_QtyInnerBox)
            If IsdbNull(rs4010!K4010_QtyInnerBoxA) = False Then D4010.QtyInnerBoxA = Trim$(rs4010!K4010_QtyInnerBoxA)
            If IsdbNull(rs4010!K4010_QtyInnerBoxX) = False Then D4010.QtyInnerBoxX = Trim$(rs4010!K4010_QtyInnerBoxX)
            If IsdbNull(rs4010!K4010_QtyInbound) = False Then D4010.QtyInbound = Trim$(rs4010!K4010_QtyInbound)
            If IsdbNull(rs4010!K4010_QtyInboundA) = False Then D4010.QtyInboundA = Trim$(rs4010!K4010_QtyInboundA)
            If IsdbNull(rs4010!K4010_QtyInboundX) = False Then D4010.QtyInboundX = Trim$(rs4010!K4010_QtyInboundX)
            If IsdbNull(rs4010!K4010_QtySB2UI) = False Then D4010.QtySB2UI = Trim$(rs4010!K4010_QtySB2UI)
            If IsdbNull(rs4010!K4010_QtySB2UIA) = False Then D4010.QtySB2UIA = Trim$(rs4010!K4010_QtySB2UIA)
            If IsdbNull(rs4010!K4010_QtySB2UIX) = False Then D4010.QtySB2UIX = Trim$(rs4010!K4010_QtySB2UIX)
            If IsdbNull(rs4010!K4010_QtySB2UO) = False Then D4010.QtySB2UO = Trim$(rs4010!K4010_QtySB2UO)
            If IsdbNull(rs4010!K4010_QtySB2UOA) = False Then D4010.QtySB2UOA = Trim$(rs4010!K4010_QtySB2UOA)
            If IsdbNull(rs4010!K4010_QtySB2UOX) = False Then D4010.QtySB2UOX = Trim$(rs4010!K4010_QtySB2UOX)
            If IsdbNull(rs4010!K4010_QtySB2SI) = False Then D4010.QtySB2SI = Trim$(rs4010!K4010_QtySB2SI)
            If IsdbNull(rs4010!K4010_QtySB2SIA) = False Then D4010.QtySB2SIA = Trim$(rs4010!K4010_QtySB2SIA)
            If IsdbNull(rs4010!K4010_QtySB2SIX) = False Then D4010.QtySB2SIX = Trim$(rs4010!K4010_QtySB2SIX)
            If IsdbNull(rs4010!K4010_QtySB2SO) = False Then D4010.QtySB2SO = Trim$(rs4010!K4010_QtySB2SO)
            If IsdbNull(rs4010!K4010_QtySB2SOA) = False Then D4010.QtySB2SOA = Trim$(rs4010!K4010_QtySB2SOA)
            If IsdbNull(rs4010!K4010_QtySB2SOX) = False Then D4010.QtySB2SOX = Trim$(rs4010!K4010_QtySB2SOX)
            If IsdbNull(rs4010!K4010_QtySB2FI) = False Then D4010.QtySB2FI = Trim$(rs4010!K4010_QtySB2FI)
            If IsdbNull(rs4010!K4010_QtySB2FIA) = False Then D4010.QtySB2FIA = Trim$(rs4010!K4010_QtySB2FIA)
            If IsdbNull(rs4010!K4010_QtySB2FIX) = False Then D4010.QtySB2FIX = Trim$(rs4010!K4010_QtySB2FIX)
            If IsdbNull(rs4010!K4010_QtySB2FO) = False Then D4010.QtySB2FO = Trim$(rs4010!K4010_QtySB2FO)
            If IsdbNull(rs4010!K4010_QtySB2FOA) = False Then D4010.QtySB2FOA = Trim$(rs4010!K4010_QtySB2FOA)
            If IsdbNull(rs4010!K4010_QtySB2FOX) = False Then D4010.QtySB2FOX = Trim$(rs4010!K4010_QtySB2FOX)
            If IsdbNull(rs4010!K4010_seFactory) = False Then D4010.seFactory = Trim$(rs4010!K4010_seFactory)
            If IsdbNull(rs4010!K4010_cdFactory) = False Then D4010.cdFactory = Trim$(rs4010!K4010_cdFactory)
            If IsdbNull(rs4010!K4010_seLineProd1) = False Then D4010.seLineProd1 = Trim$(rs4010!K4010_seLineProd1)
            If IsdbNull(rs4010!K4010_cdLineProd1) = False Then D4010.cdLineProd1 = Trim$(rs4010!K4010_cdLineProd1)
            If IsdbNull(rs4010!K4010_seLineProd2) = False Then D4010.seLineProd2 = Trim$(rs4010!K4010_seLineProd2)
            If IsdbNull(rs4010!K4010_cdLineProd2) = False Then D4010.cdLineProd2 = Trim$(rs4010!K4010_cdLineProd2)
            If IsdbNull(rs4010!K4010_seLineProd3) = False Then D4010.seLineProd3 = Trim$(rs4010!K4010_seLineProd3)
            If IsdbNull(rs4010!K4010_cdLineProd3) = False Then D4010.cdLineProd3 = Trim$(rs4010!K4010_cdLineProd3)
            If IsdbNull(rs4010!K4010_DateInsert) = False Then D4010.DateInsert = Trim$(rs4010!K4010_DateInsert)
            If IsdbNull(rs4010!K4010_InchargeInsert) = False Then D4010.InchargeInsert = Trim$(rs4010!K4010_InchargeInsert)
            If IsdbNull(rs4010!K4010_DateUpdate) = False Then D4010.DateUpdate = Trim$(rs4010!K4010_DateUpdate)
            If IsdbNull(rs4010!K4010_InchargeUpdate) = False Then D4010.InchargeUpdate = Trim$(rs4010!K4010_InchargeUpdate)
            If IsdbNull(rs4010!K4010_RemarkOrder) = False Then D4010.RemarkOrder = Trim$(rs4010!K4010_RemarkOrder)
            If IsdbNull(rs4010!K4010_RemarkCustomer) = False Then D4010.RemarkCustomer = Trim$(rs4010!K4010_RemarkCustomer)
            If IsdbNull(rs4010!K4010_RemarkOther) = False Then D4010.RemarkOther = Trim$(rs4010!K4010_RemarkOther)
            If IsdbNull(rs4010!K4010_seSite) = False Then D4010.seSite = Trim$(rs4010!K4010_seSite)
            If IsdbNull(rs4010!K4010_cdSite) = False Then D4010.cdSite = Trim$(rs4010!K4010_cdSite)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K4010_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K4010_MOVE(rs4010 As DataRow)
        Try

            Call D4010_CLEAR()

            If IsdbNull(rs4010!K4010_JobCard) = False Then D4010.JobCard = Trim$(rs4010!K4010_JobCard)
            If IsdbNull(rs4010!K4010_seJobState) = False Then D4010.seJobState = Trim$(rs4010!K4010_seJobState)
            If IsdbNull(rs4010!K4010_cdJobState) = False Then D4010.cdJobState = Trim$(rs4010!K4010_cdJobState)
            If IsdbNull(rs4010!K4010_SealNo) = False Then D4010.SealNo = Trim$(rs4010!K4010_SealNo)
            If IsdbNull(rs4010!K4010_SlNoD) = False Then D4010.SlNoD = Trim$(rs4010!K4010_SlNoD)
            If IsdbNull(rs4010!K4010_WorkOrder) = False Then D4010.WorkOrder = Trim$(rs4010!K4010_WorkOrder)
            If IsdbNull(rs4010!K4010_WorkOrderSeq) = False Then D4010.WorkOrderSeq = Trim$(rs4010!K4010_WorkOrderSeq)
            If IsdbNull(rs4010!K4010_selJob) = False Then D4010.selJob = Trim$(rs4010!K4010_selJob)
            If IsdbNull(rs4010!K4010_selProd) = False Then D4010.selProd = Trim$(rs4010!K4010_selProd)
            If IsdbNull(rs4010!K4010_DateStart) = False Then D4010.DateStart = Trim$(rs4010!K4010_DateStart)
            If IsdbNull(rs4010!K4010_DateFinish) = False Then D4010.DateFinish = Trim$(rs4010!K4010_DateFinish)
            If IsdbNull(rs4010!K4010_DatePlanStart) = False Then D4010.DatePlanStart = Trim$(rs4010!K4010_DatePlanStart)
            If IsdbNull(rs4010!K4010_DatePlanFinish) = False Then D4010.DatePlanFinish = Trim$(rs4010!K4010_DatePlanFinish)
            If IsdbNull(rs4010!K4010_JobCardBefore) = False Then D4010.JobCardBefore = Trim$(rs4010!K4010_JobCardBefore)
            If IsdbNull(rs4010!K4010_JobCardAfter) = False Then D4010.JobCardAfter = Trim$(rs4010!K4010_JobCardAfter)
            If IsdbNull(rs4010!K4010_CheckPlan) = False Then D4010.CheckPlan = Trim$(rs4010!K4010_CheckPlan)
            If IsdbNull(rs4010!K4010_CheckUse) = False Then D4010.CheckUse = Trim$(rs4010!K4010_CheckUse)
            If IsdbNull(rs4010!K4010_MaterialStatus) = False Then D4010.MaterialStatus = Trim$(rs4010!K4010_MaterialStatus)
            If IsdbNull(rs4010!K4010_MoldStatus) = False Then D4010.MoldStatus = Trim$(rs4010!K4010_MoldStatus)
            If IsdbNull(rs4010!K4010_LastStatus) = False Then D4010.LastStatus = Trim$(rs4010!K4010_LastStatus)
            If IsdbNull(rs4010!K4010_CuttingDieStatus) = False Then D4010.CuttingDieStatus = Trim$(rs4010!K4010_CuttingDieStatus)
            If IsdbNull(rs4010!K4010_SoleStatus) = False Then D4010.SoleStatus = Trim$(rs4010!K4010_SoleStatus)
            If IsdbNull(rs4010!K4010_SoleNo) = False Then D4010.SoleNo = Trim$(rs4010!K4010_SoleNo)
            If IsdbNull(rs4010!K4010_CuttingStatus) = False Then D4010.CuttingStatus = Trim$(rs4010!K4010_CuttingStatus)
            If IsdbNull(rs4010!K4010_CuttingNo) = False Then D4010.CuttingNo = Trim$(rs4010!K4010_CuttingNo)
            If IsdbNull(rs4010!K4010_StitchingStatus) = False Then D4010.StitchingStatus = Trim$(rs4010!K4010_StitchingStatus)
            If IsdbNull(rs4010!K4010_StitchingNo) = False Then D4010.StitchingNo = Trim$(rs4010!K4010_StitchingNo)
            If IsdbNull(rs4010!K4010_SubprocessStatus) = False Then D4010.SubprocessStatus = Trim$(rs4010!K4010_SubprocessStatus)
            If IsdbNull(rs4010!K4010_SubprocessNo) = False Then D4010.SubprocessNo = Trim$(rs4010!K4010_SubprocessNo)
            If IsdbNull(rs4010!K4010_OutsourceStatsus) = False Then D4010.OutsourceStatsus = Trim$(rs4010!K4010_OutsourceStatsus)
            If IsdbNull(rs4010!K4010_OutsourceNo) = False Then D4010.OutsourceNo = Trim$(rs4010!K4010_OutsourceNo)
            If IsdbNull(rs4010!K4010_StockfitStatsus) = False Then D4010.StockfitStatsus = Trim$(rs4010!K4010_StockfitStatsus)
            If IsdbNull(rs4010!K4010_StockfitNo) = False Then D4010.StockfitNo = Trim$(rs4010!K4010_StockfitNo)
            If IsdbNull(rs4010!K4010_AssemblyStatus) = False Then D4010.AssemblyStatus = Trim$(rs4010!K4010_AssemblyStatus)
            If IsdbNull(rs4010!K4010_AssemblyNo) = False Then D4010.AssemblyNo = Trim$(rs4010!K4010_AssemblyNo)
            If IsdbNull(rs4010!K4010_QtyOrder) = False Then D4010.QtyOrder = Trim$(rs4010!K4010_QtyOrder)
            If IsdbNull(rs4010!K4010_QtyPlan) = False Then D4010.QtyPlan = Trim$(rs4010!K4010_QtyPlan)
            If IsdbNull(rs4010!K4010_QtyJob) = False Then D4010.QtyJob = Trim$(rs4010!K4010_QtyJob)
            If IsdbNull(rs4010!K4010_QtyJobSole) = False Then D4010.QtyJobSole = Trim$(rs4010!K4010_QtyJobSole)
            If IsdbNull(rs4010!K4010_QtyBatchSole) = False Then D4010.QtyBatchSole = Trim$(rs4010!K4010_QtyBatchSole)
            If IsdbNull(rs4010!K4010_QtySole) = False Then D4010.QtySole = Trim$(rs4010!K4010_QtySole)
            If IsdbNull(rs4010!K4010_QtySoleA) = False Then D4010.QtySoleA = Trim$(rs4010!K4010_QtySoleA)
            If IsdbNull(rs4010!K4010_QtySoleX) = False Then D4010.QtySoleX = Trim$(rs4010!K4010_QtySoleX)
            If IsdbNull(rs4010!K4010_QtySoleXP) = False Then D4010.QtySoleXP = Trim$(rs4010!K4010_QtySoleXP)
            If IsdbNull(rs4010!K4010_QtySoleXR) = False Then D4010.QtySoleXR = Trim$(rs4010!K4010_QtySoleXR)
            If IsdbNull(rs4010!K4010_QtySoleBLOut) = False Then D4010.QtySoleBLOut = Trim$(rs4010!K4010_QtySoleBLOut)
            If IsdbNull(rs4010!K4010_QtySoleBLIn) = False Then D4010.QtySoleBLIn = Trim$(rs4010!K4010_QtySoleBLIn)
            If IsdbNull(rs4010!K4010_QtyJobCutting) = False Then D4010.QtyJobCutting = Trim$(rs4010!K4010_QtyJobCutting)
            If IsdbNull(rs4010!K4010_QtyBatchCutting) = False Then D4010.QtyBatchCutting = Trim$(rs4010!K4010_QtyBatchCutting)
            If IsdbNull(rs4010!K4010_QtyCom) = False Then D4010.QtyCom = Trim$(rs4010!K4010_QtyCom)
            If IsdbNull(rs4010!K4010_QtyCutting) = False Then D4010.QtyCutting = Trim$(rs4010!K4010_QtyCutting)
            If IsdbNull(rs4010!K4010_QtyCuttingA) = False Then D4010.QtyCuttingA = Trim$(rs4010!K4010_QtyCuttingA)
            If IsdbNull(rs4010!K4010_QtyCuttingX) = False Then D4010.QtyCuttingX = Trim$(rs4010!K4010_QtyCuttingX)
            If IsdbNull(rs4010!K4010_QtyCuttingXP) = False Then D4010.QtyCuttingXP = Trim$(rs4010!K4010_QtyCuttingXP)
            If IsdbNull(rs4010!K4010_QtyCuttingXR) = False Then D4010.QtyCuttingXR = Trim$(rs4010!K4010_QtyCuttingXR)
            If IsdbNull(rs4010!K4010_QtyCuttingBLOut) = False Then D4010.QtyCuttingBLOut = Trim$(rs4010!K4010_QtyCuttingBLOut)
            If IsdbNull(rs4010!K4010_QtyCuttingBLIn) = False Then D4010.QtyCuttingBLIn = Trim$(rs4010!K4010_QtyCuttingBLIn)
            If IsdbNull(rs4010!K4010_QtyJobStitching) = False Then D4010.QtyJobStitching = Trim$(rs4010!K4010_QtyJobStitching)
            If IsdbNull(rs4010!K4010_QtyBatchStitching) = False Then D4010.QtyBatchStitching = Trim$(rs4010!K4010_QtyBatchStitching)
            If IsdbNull(rs4010!K4010_QtyStitching) = False Then D4010.QtyStitching = Trim$(rs4010!K4010_QtyStitching)
            If IsdbNull(rs4010!K4010_QtyStitchingA) = False Then D4010.QtyStitchingA = Trim$(rs4010!K4010_QtyStitchingA)
            If IsdbNull(rs4010!K4010_QtyStitchingX) = False Then D4010.QtyStitchingX = Trim$(rs4010!K4010_QtyStitchingX)
            If IsdbNull(rs4010!K4010_QtyStitchingXP) = False Then D4010.QtyStitchingXP = Trim$(rs4010!K4010_QtyStitchingXP)
            If IsdbNull(rs4010!K4010_QtyStitchingXR) = False Then D4010.QtyStitchingXR = Trim$(rs4010!K4010_QtyStitchingXR)
            If IsdbNull(rs4010!K4010_QtyStitchingBLOut) = False Then D4010.QtyStitchingBLOut = Trim$(rs4010!K4010_QtyStitchingBLOut)
            If IsdbNull(rs4010!K4010_QtyStitchingBLIn) = False Then D4010.QtyStitchingBLIn = Trim$(rs4010!K4010_QtyStitchingBLIn)
            If IsdbNull(rs4010!K4010_QtyJobStockfit) = False Then D4010.QtyJobStockfit = Trim$(rs4010!K4010_QtyJobStockfit)
            If IsdbNull(rs4010!K4010_QtyBatchStockfit) = False Then D4010.QtyBatchStockfit = Trim$(rs4010!K4010_QtyBatchStockfit)
            If IsdbNull(rs4010!K4010_QtyStockfit) = False Then D4010.QtyStockfit = Trim$(rs4010!K4010_QtyStockfit)
            If IsdbNull(rs4010!K4010_QtyStockfitA) = False Then D4010.QtyStockfitA = Trim$(rs4010!K4010_QtyStockfitA)
            If IsdbNull(rs4010!K4010_QtyStockfitX) = False Then D4010.QtyStockfitX = Trim$(rs4010!K4010_QtyStockfitX)
            If IsdbNull(rs4010!K4010_QtyStockfitXP) = False Then D4010.QtyStockfitXP = Trim$(rs4010!K4010_QtyStockfitXP)
            If IsdbNull(rs4010!K4010_QtyStockfitXR) = False Then D4010.QtyStockfitXR = Trim$(rs4010!K4010_QtyStockfitXR)
            If IsdbNull(rs4010!K4010_QtyStockfitBLOut) = False Then D4010.QtyStockfitBLOut = Trim$(rs4010!K4010_QtyStockfitBLOut)
            If IsdbNull(rs4010!K4010_QtyStockfitBLIn) = False Then D4010.QtyStockfitBLIn = Trim$(rs4010!K4010_QtyStockfitBLIn)
            If IsdbNull(rs4010!K4010_QtyJobAssembly) = False Then D4010.QtyJobAssembly = Trim$(rs4010!K4010_QtyJobAssembly)
            If IsdbNull(rs4010!K4010_QtyBatchAssembly) = False Then D4010.QtyBatchAssembly = Trim$(rs4010!K4010_QtyBatchAssembly)
            If IsdbNull(rs4010!K4010_QtyAssembly) = False Then D4010.QtyAssembly = Trim$(rs4010!K4010_QtyAssembly)
            If IsdbNull(rs4010!K4010_QtyAssemblyA) = False Then D4010.QtyAssemblyA = Trim$(rs4010!K4010_QtyAssemblyA)
            If IsdbNull(rs4010!K4010_QtyAssemblyX) = False Then D4010.QtyAssemblyX = Trim$(rs4010!K4010_QtyAssemblyX)
            If IsdbNull(rs4010!K4010_QtyAssemblyXP) = False Then D4010.QtyAssemblyXP = Trim$(rs4010!K4010_QtyAssemblyXP)
            If IsdbNull(rs4010!K4010_QtyAssemblyXR) = False Then D4010.QtyAssemblyXR = Trim$(rs4010!K4010_QtyAssemblyXR)
            If IsdbNull(rs4010!K4010_QtyAssemblyBLOut) = False Then D4010.QtyAssemblyBLOut = Trim$(rs4010!K4010_QtyAssemblyBLOut)
            If IsdbNull(rs4010!K4010_QtyAssemblyBLIn) = False Then D4010.QtyAssemblyBLIn = Trim$(rs4010!K4010_QtyAssemblyBLIn)
            If IsdbNull(rs4010!K4010_QtyJobPacking) = False Then D4010.QtyJobPacking = Trim$(rs4010!K4010_QtyJobPacking)
            If IsdbNull(rs4010!K4010_QtyBatchPacking) = False Then D4010.QtyBatchPacking = Trim$(rs4010!K4010_QtyBatchPacking)
            If IsdbNull(rs4010!K4010_QtyPacking) = False Then D4010.QtyPacking = Trim$(rs4010!K4010_QtyPacking)
            If IsdbNull(rs4010!K4010_QtyPackingA) = False Then D4010.QtyPackingA = Trim$(rs4010!K4010_QtyPackingA)
            If IsdbNull(rs4010!K4010_QtyPackingX) = False Then D4010.QtyPackingX = Trim$(rs4010!K4010_QtyPackingX)
            If IsdbNull(rs4010!K4010_QtyPackingXP) = False Then D4010.QtyPackingXP = Trim$(rs4010!K4010_QtyPackingXP)
            If IsdbNull(rs4010!K4010_QtyPackingXR) = False Then D4010.QtyPackingXR = Trim$(rs4010!K4010_QtyPackingXR)
            If IsdbNull(rs4010!K4010_QtyPackingBLOut) = False Then D4010.QtyPackingBLOut = Trim$(rs4010!K4010_QtyPackingBLOut)
            If IsdbNull(rs4010!K4010_QtyPackingBLIn) = False Then D4010.QtyPackingBLIn = Trim$(rs4010!K4010_QtyPackingBLIn)
            If IsdbNull(rs4010!K4010_QtyJobShipping) = False Then D4010.QtyJobShipping = Trim$(rs4010!K4010_QtyJobShipping)
            If IsdbNull(rs4010!K4010_QtyBatchShipping) = False Then D4010.QtyBatchShipping = Trim$(rs4010!K4010_QtyBatchShipping)
            If IsdbNull(rs4010!K4010_QtyShipping) = False Then D4010.QtyShipping = Trim$(rs4010!K4010_QtyShipping)
            If IsdbNull(rs4010!K4010_QtyShippingA) = False Then D4010.QtyShippingA = Trim$(rs4010!K4010_QtyShippingA)
            If IsdbNull(rs4010!K4010_QtyShippingX) = False Then D4010.QtyShippingX = Trim$(rs4010!K4010_QtyShippingX)
            If IsdbNull(rs4010!K4010_QtyShippingBLOut) = False Then D4010.QtyShippingBLOut = Trim$(rs4010!K4010_QtyShippingBLOut)
            If IsdbNull(rs4010!K4010_QtyShippingBLIn) = False Then D4010.QtyShippingBLIn = Trim$(rs4010!K4010_QtyShippingBLIn)
            If IsdbNull(rs4010!K4010_QtyFootbed) = False Then D4010.QtyFootbed = Trim$(rs4010!K4010_QtyFootbed)
            If IsdbNull(rs4010!K4010_QtyFootbedA) = False Then D4010.QtyFootbedA = Trim$(rs4010!K4010_QtyFootbedA)
            If IsdbNull(rs4010!K4010_QtyFootbedX) = False Then D4010.QtyFootbedX = Trim$(rs4010!K4010_QtyFootbedX)
            If IsdbNull(rs4010!K4010_QtyInnerBox) = False Then D4010.QtyInnerBox = Trim$(rs4010!K4010_QtyInnerBox)
            If IsdbNull(rs4010!K4010_QtyInnerBoxA) = False Then D4010.QtyInnerBoxA = Trim$(rs4010!K4010_QtyInnerBoxA)
            If IsdbNull(rs4010!K4010_QtyInnerBoxX) = False Then D4010.QtyInnerBoxX = Trim$(rs4010!K4010_QtyInnerBoxX)
            If IsdbNull(rs4010!K4010_QtyInbound) = False Then D4010.QtyInbound = Trim$(rs4010!K4010_QtyInbound)
            If IsdbNull(rs4010!K4010_QtyInboundA) = False Then D4010.QtyInboundA = Trim$(rs4010!K4010_QtyInboundA)
            If IsdbNull(rs4010!K4010_QtyInboundX) = False Then D4010.QtyInboundX = Trim$(rs4010!K4010_QtyInboundX)
            If IsdbNull(rs4010!K4010_QtySB2UI) = False Then D4010.QtySB2UI = Trim$(rs4010!K4010_QtySB2UI)
            If IsdbNull(rs4010!K4010_QtySB2UIA) = False Then D4010.QtySB2UIA = Trim$(rs4010!K4010_QtySB2UIA)
            If IsdbNull(rs4010!K4010_QtySB2UIX) = False Then D4010.QtySB2UIX = Trim$(rs4010!K4010_QtySB2UIX)
            If IsdbNull(rs4010!K4010_QtySB2UO) = False Then D4010.QtySB2UO = Trim$(rs4010!K4010_QtySB2UO)
            If IsdbNull(rs4010!K4010_QtySB2UOA) = False Then D4010.QtySB2UOA = Trim$(rs4010!K4010_QtySB2UOA)
            If IsdbNull(rs4010!K4010_QtySB2UOX) = False Then D4010.QtySB2UOX = Trim$(rs4010!K4010_QtySB2UOX)
            If IsdbNull(rs4010!K4010_QtySB2SI) = False Then D4010.QtySB2SI = Trim$(rs4010!K4010_QtySB2SI)
            If IsdbNull(rs4010!K4010_QtySB2SIA) = False Then D4010.QtySB2SIA = Trim$(rs4010!K4010_QtySB2SIA)
            If IsdbNull(rs4010!K4010_QtySB2SIX) = False Then D4010.QtySB2SIX = Trim$(rs4010!K4010_QtySB2SIX)
            If IsdbNull(rs4010!K4010_QtySB2SO) = False Then D4010.QtySB2SO = Trim$(rs4010!K4010_QtySB2SO)
            If IsdbNull(rs4010!K4010_QtySB2SOA) = False Then D4010.QtySB2SOA = Trim$(rs4010!K4010_QtySB2SOA)
            If IsdbNull(rs4010!K4010_QtySB2SOX) = False Then D4010.QtySB2SOX = Trim$(rs4010!K4010_QtySB2SOX)
            If IsdbNull(rs4010!K4010_QtySB2FI) = False Then D4010.QtySB2FI = Trim$(rs4010!K4010_QtySB2FI)
            If IsdbNull(rs4010!K4010_QtySB2FIA) = False Then D4010.QtySB2FIA = Trim$(rs4010!K4010_QtySB2FIA)
            If IsdbNull(rs4010!K4010_QtySB2FIX) = False Then D4010.QtySB2FIX = Trim$(rs4010!K4010_QtySB2FIX)
            If IsdbNull(rs4010!K4010_QtySB2FO) = False Then D4010.QtySB2FO = Trim$(rs4010!K4010_QtySB2FO)
            If IsdbNull(rs4010!K4010_QtySB2FOA) = False Then D4010.QtySB2FOA = Trim$(rs4010!K4010_QtySB2FOA)
            If IsdbNull(rs4010!K4010_QtySB2FOX) = False Then D4010.QtySB2FOX = Trim$(rs4010!K4010_QtySB2FOX)
            If IsdbNull(rs4010!K4010_seFactory) = False Then D4010.seFactory = Trim$(rs4010!K4010_seFactory)
            If IsdbNull(rs4010!K4010_cdFactory) = False Then D4010.cdFactory = Trim$(rs4010!K4010_cdFactory)
            If IsdbNull(rs4010!K4010_seLineProd1) = False Then D4010.seLineProd1 = Trim$(rs4010!K4010_seLineProd1)
            If IsdbNull(rs4010!K4010_cdLineProd1) = False Then D4010.cdLineProd1 = Trim$(rs4010!K4010_cdLineProd1)
            If IsdbNull(rs4010!K4010_seLineProd2) = False Then D4010.seLineProd2 = Trim$(rs4010!K4010_seLineProd2)
            If IsdbNull(rs4010!K4010_cdLineProd2) = False Then D4010.cdLineProd2 = Trim$(rs4010!K4010_cdLineProd2)
            If IsdbNull(rs4010!K4010_seLineProd3) = False Then D4010.seLineProd3 = Trim$(rs4010!K4010_seLineProd3)
            If IsdbNull(rs4010!K4010_cdLineProd3) = False Then D4010.cdLineProd3 = Trim$(rs4010!K4010_cdLineProd3)
            If IsdbNull(rs4010!K4010_DateInsert) = False Then D4010.DateInsert = Trim$(rs4010!K4010_DateInsert)
            If IsdbNull(rs4010!K4010_InchargeInsert) = False Then D4010.InchargeInsert = Trim$(rs4010!K4010_InchargeInsert)
            If IsdbNull(rs4010!K4010_DateUpdate) = False Then D4010.DateUpdate = Trim$(rs4010!K4010_DateUpdate)
            If IsdbNull(rs4010!K4010_InchargeUpdate) = False Then D4010.InchargeUpdate = Trim$(rs4010!K4010_InchargeUpdate)
            If IsdbNull(rs4010!K4010_RemarkOrder) = False Then D4010.RemarkOrder = Trim$(rs4010!K4010_RemarkOrder)
            If IsdbNull(rs4010!K4010_RemarkCustomer) = False Then D4010.RemarkCustomer = Trim$(rs4010!K4010_RemarkCustomer)
            If IsdbNull(rs4010!K4010_RemarkOther) = False Then D4010.RemarkOther = Trim$(rs4010!K4010_RemarkOther)
            If IsdbNull(rs4010!K4010_seSite) = False Then D4010.seSite = Trim$(rs4010!K4010_seSite)
            If IsdbNull(rs4010!K4010_cdSite) = False Then D4010.cdSite = Trim$(rs4010!K4010_cdSite)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K4010_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K4010_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z4010 As T4010_AREA, JOBCARD As String) As Boolean

        K4010_MOVE = False

        Try
            If READ_PFK4010(JOBCARD) = True Then
                z4010 = D4010
                K4010_MOVE = True
            Else
                z4010 = Nothing
            End If

            If getColumnIndex(spr, "JobCard") > -1 Then z4010.JobCard = getDataM(spr, getColumnIndex(spr, "JobCard"), xRow)
            If getColumnIndex(spr, "seJobState") > -1 Then z4010.seJobState = getDataM(spr, getColumnIndex(spr, "seJobState"), xRow)
            If getColumnIndex(spr, "cdJobState") > -1 Then z4010.cdJobState = getDataM(spr, getColumnIndex(spr, "cdJobState"), xRow)
            If getColumnIndex(spr, "SealNo") > -1 Then z4010.SealNo = getDataM(spr, getColumnIndex(spr, "SealNo"), xRow)
            If getColumnIndex(spr, "SlNoD") > -1 Then z4010.SlNoD = getDataM(spr, getColumnIndex(spr, "SlNoD"), xRow)
            If getColumnIndex(spr, "WorkOrder") > -1 Then z4010.WorkOrder = getDataM(spr, getColumnIndex(spr, "WorkOrder"), xRow)
            If getColumnIndex(spr, "WorkOrderSeq") > -1 Then z4010.WorkOrderSeq = getDataM(spr, getColumnIndex(spr, "WorkOrderSeq"), xRow)
            If getColumnIndex(spr, "selJob") > -1 Then z4010.selJob = getDataM(spr, getColumnIndex(spr, "selJob"), xRow)
            If getColumnIndex(spr, "selProd") > -1 Then z4010.selProd = getDataM(spr, getColumnIndex(spr, "selProd"), xRow)
            If getColumnIndex(spr, "DateStart") > -1 Then z4010.DateStart = getDataM(spr, getColumnIndex(spr, "DateStart"), xRow)
            If getColumnIndex(spr, "DateFinish") > -1 Then z4010.DateFinish = getDataM(spr, getColumnIndex(spr, "DateFinish"), xRow)
            If getColumnIndex(spr, "DatePlanStart") > -1 Then z4010.DatePlanStart = getDataM(spr, getColumnIndex(spr, "DatePlanStart"), xRow)
            If getColumnIndex(spr, "DatePlanFinish") > -1 Then z4010.DatePlanFinish = getDataM(spr, getColumnIndex(spr, "DatePlanFinish"), xRow)
            If getColumnIndex(spr, "JobCardBefore") > -1 Then z4010.JobCardBefore = getDataM(spr, getColumnIndex(spr, "JobCardBefore"), xRow)
            If getColumnIndex(spr, "JobCardAfter") > -1 Then z4010.JobCardAfter = getDataM(spr, getColumnIndex(spr, "JobCardAfter"), xRow)
            If getColumnIndex(spr, "CheckPlan") > -1 Then z4010.CheckPlan = getDataM(spr, getColumnIndex(spr, "CheckPlan"), xRow)
            If getColumnIndex(spr, "CheckUse") > -1 Then z4010.CheckUse = getDataM(spr, getColumnIndex(spr, "CheckUse"), xRow)
            If getColumnIndex(spr, "MaterialStatus") > -1 Then z4010.MaterialStatus = getDataM(spr, getColumnIndex(spr, "MaterialStatus"), xRow)
            If getColumnIndex(spr, "MoldStatus") > -1 Then z4010.MoldStatus = getDataM(spr, getColumnIndex(spr, "MoldStatus"), xRow)
            If getColumnIndex(spr, "LastStatus") > -1 Then z4010.LastStatus = getDataM(spr, getColumnIndex(spr, "LastStatus"), xRow)
            If getColumnIndex(spr, "CuttingDieStatus") > -1 Then z4010.CuttingDieStatus = getDataM(spr, getColumnIndex(spr, "CuttingDieStatus"), xRow)
            If getColumnIndex(spr, "SoleStatus") > -1 Then z4010.SoleStatus = getDataM(spr, getColumnIndex(spr, "SoleStatus"), xRow)
            If getColumnIndex(spr, "SoleNo") > -1 Then z4010.SoleNo = getDataM(spr, getColumnIndex(spr, "SoleNo"), xRow)
            If getColumnIndex(spr, "CuttingStatus") > -1 Then z4010.CuttingStatus = getDataM(spr, getColumnIndex(spr, "CuttingStatus"), xRow)
            If getColumnIndex(spr, "CuttingNo") > -1 Then z4010.CuttingNo = getDataM(spr, getColumnIndex(spr, "CuttingNo"), xRow)
            If getColumnIndex(spr, "StitchingStatus") > -1 Then z4010.StitchingStatus = getDataM(spr, getColumnIndex(spr, "StitchingStatus"), xRow)
            If getColumnIndex(spr, "StitchingNo") > -1 Then z4010.StitchingNo = getDataM(spr, getColumnIndex(spr, "StitchingNo"), xRow)
            If getColumnIndex(spr, "SubprocessStatus") > -1 Then z4010.SubprocessStatus = getDataM(spr, getColumnIndex(spr, "SubprocessStatus"), xRow)
            If getColumnIndex(spr, "SubprocessNo") > -1 Then z4010.SubprocessNo = getDataM(spr, getColumnIndex(spr, "SubprocessNo"), xRow)
            If getColumnIndex(spr, "OutsourceStatsus") > -1 Then z4010.OutsourceStatsus = getDataM(spr, getColumnIndex(spr, "OutsourceStatsus"), xRow)
            If getColumnIndex(spr, "OutsourceNo") > -1 Then z4010.OutsourceNo = getDataM(spr, getColumnIndex(spr, "OutsourceNo"), xRow)
            If getColumnIndex(spr, "StockfitStatsus") > -1 Then z4010.StockfitStatsus = getDataM(spr, getColumnIndex(spr, "StockfitStatsus"), xRow)
            If getColumnIndex(spr, "StockfitNo") > -1 Then z4010.StockfitNo = getDataM(spr, getColumnIndex(spr, "StockfitNo"), xRow)
            If getColumnIndex(spr, "AssemblyStatus") > -1 Then z4010.AssemblyStatus = getDataM(spr, getColumnIndex(spr, "AssemblyStatus"), xRow)
            If getColumnIndex(spr, "AssemblyNo") > -1 Then z4010.AssemblyNo = getDataM(spr, getColumnIndex(spr, "AssemblyNo"), xRow)
            If getColumnIndex(spr, "QtyOrder") > -1 Then z4010.QtyOrder = getDataM(spr, getColumnIndex(spr, "QtyOrder"), xRow)
            If getColumnIndex(spr, "QtyPlan") > -1 Then z4010.QtyPlan = getDataM(spr, getColumnIndex(spr, "QtyPlan"), xRow)
            If getColumnIndex(spr, "QtyJob") > -1 Then z4010.QtyJob = getDataM(spr, getColumnIndex(spr, "QtyJob"), xRow)
            If getColumnIndex(spr, "QtyJobSole") > -1 Then z4010.QtyJobSole = getDataM(spr, getColumnIndex(spr, "QtyJobSole"), xRow)
            If getColumnIndex(spr, "QtyBatchSole") > -1 Then z4010.QtyBatchSole = getDataM(spr, getColumnIndex(spr, "QtyBatchSole"), xRow)
            If getColumnIndex(spr, "QtySole") > -1 Then z4010.QtySole = getDataM(spr, getColumnIndex(spr, "QtySole"), xRow)
            If getColumnIndex(spr, "QtySoleA") > -1 Then z4010.QtySoleA = getDataM(spr, getColumnIndex(spr, "QtySoleA"), xRow)
            If getColumnIndex(spr, "QtySoleX") > -1 Then z4010.QtySoleX = getDataM(spr, getColumnIndex(spr, "QtySoleX"), xRow)
            If getColumnIndex(spr, "QtySoleXP") > -1 Then z4010.QtySoleXP = getDataM(spr, getColumnIndex(spr, "QtySoleXP"), xRow)
            If getColumnIndex(spr, "QtySoleXR") > -1 Then z4010.QtySoleXR = getDataM(spr, getColumnIndex(spr, "QtySoleXR"), xRow)
            If getColumnIndex(spr, "QtySoleBLOut") > -1 Then z4010.QtySoleBLOut = getDataM(spr, getColumnIndex(spr, "QtySoleBLOut"), xRow)
            If getColumnIndex(spr, "QtySoleBLIn") > -1 Then z4010.QtySoleBLIn = getDataM(spr, getColumnIndex(spr, "QtySoleBLIn"), xRow)
            If getColumnIndex(spr, "QtyJobCutting") > -1 Then z4010.QtyJobCutting = getDataM(spr, getColumnIndex(spr, "QtyJobCutting"), xRow)
            If getColumnIndex(spr, "QtyBatchCutting") > -1 Then z4010.QtyBatchCutting = getDataM(spr, getColumnIndex(spr, "QtyBatchCutting"), xRow)
            If getColumnIndex(spr, "QtyCom") > -1 Then z4010.QtyCom = getDataM(spr, getColumnIndex(spr, "QtyCom"), xRow)
            If getColumnIndex(spr, "QtyCutting") > -1 Then z4010.QtyCutting = getDataM(spr, getColumnIndex(spr, "QtyCutting"), xRow)
            If getColumnIndex(spr, "QtyCuttingA") > -1 Then z4010.QtyCuttingA = getDataM(spr, getColumnIndex(spr, "QtyCuttingA"), xRow)
            If getColumnIndex(spr, "QtyCuttingX") > -1 Then z4010.QtyCuttingX = getDataM(spr, getColumnIndex(spr, "QtyCuttingX"), xRow)
            If getColumnIndex(spr, "QtyCuttingXP") > -1 Then z4010.QtyCuttingXP = getDataM(spr, getColumnIndex(spr, "QtyCuttingXP"), xRow)
            If getColumnIndex(spr, "QtyCuttingXR") > -1 Then z4010.QtyCuttingXR = getDataM(spr, getColumnIndex(spr, "QtyCuttingXR"), xRow)
            If getColumnIndex(spr, "QtyCuttingBLOut") > -1 Then z4010.QtyCuttingBLOut = getDataM(spr, getColumnIndex(spr, "QtyCuttingBLOut"), xRow)
            If getColumnIndex(spr, "QtyCuttingBLIn") > -1 Then z4010.QtyCuttingBLIn = getDataM(spr, getColumnIndex(spr, "QtyCuttingBLIn"), xRow)
            If getColumnIndex(spr, "QtyJobStitching") > -1 Then z4010.QtyJobStitching = getDataM(spr, getColumnIndex(spr, "QtyJobStitching"), xRow)
            If getColumnIndex(spr, "QtyBatchStitching") > -1 Then z4010.QtyBatchStitching = getDataM(spr, getColumnIndex(spr, "QtyBatchStitching"), xRow)
            If getColumnIndex(spr, "QtyStitching") > -1 Then z4010.QtyStitching = getDataM(spr, getColumnIndex(spr, "QtyStitching"), xRow)
            If getColumnIndex(spr, "QtyStitchingA") > -1 Then z4010.QtyStitchingA = getDataM(spr, getColumnIndex(spr, "QtyStitchingA"), xRow)
            If getColumnIndex(spr, "QtyStitchingX") > -1 Then z4010.QtyStitchingX = getDataM(spr, getColumnIndex(spr, "QtyStitchingX"), xRow)
            If getColumnIndex(spr, "QtyStitchingXP") > -1 Then z4010.QtyStitchingXP = getDataM(spr, getColumnIndex(spr, "QtyStitchingXP"), xRow)
            If getColumnIndex(spr, "QtyStitchingXR") > -1 Then z4010.QtyStitchingXR = getDataM(spr, getColumnIndex(spr, "QtyStitchingXR"), xRow)
            If getColumnIndex(spr, "QtyStitchingBLOut") > -1 Then z4010.QtyStitchingBLOut = getDataM(spr, getColumnIndex(spr, "QtyStitchingBLOut"), xRow)
            If getColumnIndex(spr, "QtyStitchingBLIn") > -1 Then z4010.QtyStitchingBLIn = getDataM(spr, getColumnIndex(spr, "QtyStitchingBLIn"), xRow)
            If getColumnIndex(spr, "QtyJobStockfit") > -1 Then z4010.QtyJobStockfit = getDataM(spr, getColumnIndex(spr, "QtyJobStockfit"), xRow)
            If getColumnIndex(spr, "QtyBatchStockfit") > -1 Then z4010.QtyBatchStockfit = getDataM(spr, getColumnIndex(spr, "QtyBatchStockfit"), xRow)
            If getColumnIndex(spr, "QtyStockfit") > -1 Then z4010.QtyStockfit = getDataM(spr, getColumnIndex(spr, "QtyStockfit"), xRow)
            If getColumnIndex(spr, "QtyStockfitA") > -1 Then z4010.QtyStockfitA = getDataM(spr, getColumnIndex(spr, "QtyStockfitA"), xRow)
            If getColumnIndex(spr, "QtyStockfitX") > -1 Then z4010.QtyStockfitX = getDataM(spr, getColumnIndex(spr, "QtyStockfitX"), xRow)
            If getColumnIndex(spr, "QtyStockfitXP") > -1 Then z4010.QtyStockfitXP = getDataM(spr, getColumnIndex(spr, "QtyStockfitXP"), xRow)
            If getColumnIndex(spr, "QtyStockfitXR") > -1 Then z4010.QtyStockfitXR = getDataM(spr, getColumnIndex(spr, "QtyStockfitXR"), xRow)
            If getColumnIndex(spr, "QtyStockfitBLOut") > -1 Then z4010.QtyStockfitBLOut = getDataM(spr, getColumnIndex(spr, "QtyStockfitBLOut"), xRow)
            If getColumnIndex(spr, "QtyStockfitBLIn") > -1 Then z4010.QtyStockfitBLIn = getDataM(spr, getColumnIndex(spr, "QtyStockfitBLIn"), xRow)
            If getColumnIndex(spr, "QtyJobAssembly") > -1 Then z4010.QtyJobAssembly = getDataM(spr, getColumnIndex(spr, "QtyJobAssembly"), xRow)
            If getColumnIndex(spr, "QtyBatchAssembly") > -1 Then z4010.QtyBatchAssembly = getDataM(spr, getColumnIndex(spr, "QtyBatchAssembly"), xRow)
            If getColumnIndex(spr, "QtyAssembly") > -1 Then z4010.QtyAssembly = getDataM(spr, getColumnIndex(spr, "QtyAssembly"), xRow)
            If getColumnIndex(spr, "QtyAssemblyA") > -1 Then z4010.QtyAssemblyA = getDataM(spr, getColumnIndex(spr, "QtyAssemblyA"), xRow)
            If getColumnIndex(spr, "QtyAssemblyX") > -1 Then z4010.QtyAssemblyX = getDataM(spr, getColumnIndex(spr, "QtyAssemblyX"), xRow)
            If getColumnIndex(spr, "QtyAssemblyXP") > -1 Then z4010.QtyAssemblyXP = getDataM(spr, getColumnIndex(spr, "QtyAssemblyXP"), xRow)
            If getColumnIndex(spr, "QtyAssemblyXR") > -1 Then z4010.QtyAssemblyXR = getDataM(spr, getColumnIndex(spr, "QtyAssemblyXR"), xRow)
            If getColumnIndex(spr, "QtyAssemblyBLOut") > -1 Then z4010.QtyAssemblyBLOut = getDataM(spr, getColumnIndex(spr, "QtyAssemblyBLOut"), xRow)
            If getColumnIndex(spr, "QtyAssemblyBLIn") > -1 Then z4010.QtyAssemblyBLIn = getDataM(spr, getColumnIndex(spr, "QtyAssemblyBLIn"), xRow)
            If getColumnIndex(spr, "QtyJobPacking") > -1 Then z4010.QtyJobPacking = getDataM(spr, getColumnIndex(spr, "QtyJobPacking"), xRow)
            If getColumnIndex(spr, "QtyBatchPacking") > -1 Then z4010.QtyBatchPacking = getDataM(spr, getColumnIndex(spr, "QtyBatchPacking"), xRow)
            If getColumnIndex(spr, "QtyPacking") > -1 Then z4010.QtyPacking = getDataM(spr, getColumnIndex(spr, "QtyPacking"), xRow)
            If getColumnIndex(spr, "QtyPackingA") > -1 Then z4010.QtyPackingA = getDataM(spr, getColumnIndex(spr, "QtyPackingA"), xRow)
            If getColumnIndex(spr, "QtyPackingX") > -1 Then z4010.QtyPackingX = getDataM(spr, getColumnIndex(spr, "QtyPackingX"), xRow)
            If getColumnIndex(spr, "QtyPackingXP") > -1 Then z4010.QtyPackingXP = getDataM(spr, getColumnIndex(spr, "QtyPackingXP"), xRow)
            If getColumnIndex(spr, "QtyPackingXR") > -1 Then z4010.QtyPackingXR = getDataM(spr, getColumnIndex(spr, "QtyPackingXR"), xRow)
            If getColumnIndex(spr, "QtyPackingBLOut") > -1 Then z4010.QtyPackingBLOut = getDataM(spr, getColumnIndex(spr, "QtyPackingBLOut"), xRow)
            If getColumnIndex(spr, "QtyPackingBLIn") > -1 Then z4010.QtyPackingBLIn = getDataM(spr, getColumnIndex(spr, "QtyPackingBLIn"), xRow)
            If getColumnIndex(spr, "QtyJobShipping") > -1 Then z4010.QtyJobShipping = getDataM(spr, getColumnIndex(spr, "QtyJobShipping"), xRow)
            If getColumnIndex(spr, "QtyBatchShipping") > -1 Then z4010.QtyBatchShipping = getDataM(spr, getColumnIndex(spr, "QtyBatchShipping"), xRow)
            If getColumnIndex(spr, "QtyShipping") > -1 Then z4010.QtyShipping = getDataM(spr, getColumnIndex(spr, "QtyShipping"), xRow)
            If getColumnIndex(spr, "QtyShippingA") > -1 Then z4010.QtyShippingA = getDataM(spr, getColumnIndex(spr, "QtyShippingA"), xRow)
            If getColumnIndex(spr, "QtyShippingX") > -1 Then z4010.QtyShippingX = getDataM(spr, getColumnIndex(spr, "QtyShippingX"), xRow)
            If getColumnIndex(spr, "QtyShippingBLOut") > -1 Then z4010.QtyShippingBLOut = getDataM(spr, getColumnIndex(spr, "QtyShippingBLOut"), xRow)
            If getColumnIndex(spr, "QtyShippingBLIn") > -1 Then z4010.QtyShippingBLIn = getDataM(spr, getColumnIndex(spr, "QtyShippingBLIn"), xRow)
            If getColumnIndex(spr, "QtyFootbed") > -1 Then z4010.QtyFootbed = getDataM(spr, getColumnIndex(spr, "QtyFootbed"), xRow)
            If getColumnIndex(spr, "QtyFootbedA") > -1 Then z4010.QtyFootbedA = getDataM(spr, getColumnIndex(spr, "QtyFootbedA"), xRow)
            If getColumnIndex(spr, "QtyFootbedX") > -1 Then z4010.QtyFootbedX = getDataM(spr, getColumnIndex(spr, "QtyFootbedX"), xRow)
            If getColumnIndex(spr, "QtyInnerBox") > -1 Then z4010.QtyInnerBox = getDataM(spr, getColumnIndex(spr, "QtyInnerBox"), xRow)
            If getColumnIndex(spr, "QtyInnerBoxA") > -1 Then z4010.QtyInnerBoxA = getDataM(spr, getColumnIndex(spr, "QtyInnerBoxA"), xRow)
            If getColumnIndex(spr, "QtyInnerBoxX") > -1 Then z4010.QtyInnerBoxX = getDataM(spr, getColumnIndex(spr, "QtyInnerBoxX"), xRow)
            If getColumnIndex(spr, "QtyInbound") > -1 Then z4010.QtyInbound = getDataM(spr, getColumnIndex(spr, "QtyInbound"), xRow)
            If getColumnIndex(spr, "QtyInboundA") > -1 Then z4010.QtyInboundA = getDataM(spr, getColumnIndex(spr, "QtyInboundA"), xRow)
            If getColumnIndex(spr, "QtyInboundX") > -1 Then z4010.QtyInboundX = getDataM(spr, getColumnIndex(spr, "QtyInboundX"), xRow)
            If getColumnIndex(spr, "QtySB2UI") > -1 Then z4010.QtySB2UI = getDataM(spr, getColumnIndex(spr, "QtySB2UI"), xRow)
            If getColumnIndex(spr, "QtySB2UIA") > -1 Then z4010.QtySB2UIA = getDataM(spr, getColumnIndex(spr, "QtySB2UIA"), xRow)
            If getColumnIndex(spr, "QtySB2UIX") > -1 Then z4010.QtySB2UIX = getDataM(spr, getColumnIndex(spr, "QtySB2UIX"), xRow)
            If getColumnIndex(spr, "QtySB2UO") > -1 Then z4010.QtySB2UO = getDataM(spr, getColumnIndex(spr, "QtySB2UO"), xRow)
            If getColumnIndex(spr, "QtySB2UOA") > -1 Then z4010.QtySB2UOA = getDataM(spr, getColumnIndex(spr, "QtySB2UOA"), xRow)
            If getColumnIndex(spr, "QtySB2UOX") > -1 Then z4010.QtySB2UOX = getDataM(spr, getColumnIndex(spr, "QtySB2UOX"), xRow)
            If getColumnIndex(spr, "QtySB2SI") > -1 Then z4010.QtySB2SI = getDataM(spr, getColumnIndex(spr, "QtySB2SI"), xRow)
            If getColumnIndex(spr, "QtySB2SIA") > -1 Then z4010.QtySB2SIA = getDataM(spr, getColumnIndex(spr, "QtySB2SIA"), xRow)
            If getColumnIndex(spr, "QtySB2SIX") > -1 Then z4010.QtySB2SIX = getDataM(spr, getColumnIndex(spr, "QtySB2SIX"), xRow)
            If getColumnIndex(spr, "QtySB2SO") > -1 Then z4010.QtySB2SO = getDataM(spr, getColumnIndex(spr, "QtySB2SO"), xRow)
            If getColumnIndex(spr, "QtySB2SOA") > -1 Then z4010.QtySB2SOA = getDataM(spr, getColumnIndex(spr, "QtySB2SOA"), xRow)
            If getColumnIndex(spr, "QtySB2SOX") > -1 Then z4010.QtySB2SOX = getDataM(spr, getColumnIndex(spr, "QtySB2SOX"), xRow)
            If getColumnIndex(spr, "QtySB2FI") > -1 Then z4010.QtySB2FI = getDataM(spr, getColumnIndex(spr, "QtySB2FI"), xRow)
            If getColumnIndex(spr, "QtySB2FIA") > -1 Then z4010.QtySB2FIA = getDataM(spr, getColumnIndex(spr, "QtySB2FIA"), xRow)
            If getColumnIndex(spr, "QtySB2FIX") > -1 Then z4010.QtySB2FIX = getDataM(spr, getColumnIndex(spr, "QtySB2FIX"), xRow)
            If getColumnIndex(spr, "QtySB2FO") > -1 Then z4010.QtySB2FO = getDataM(spr, getColumnIndex(spr, "QtySB2FO"), xRow)
            If getColumnIndex(spr, "QtySB2FOA") > -1 Then z4010.QtySB2FOA = getDataM(spr, getColumnIndex(spr, "QtySB2FOA"), xRow)
            If getColumnIndex(spr, "QtySB2FOX") > -1 Then z4010.QtySB2FOX = getDataM(spr, getColumnIndex(spr, "QtySB2FOX"), xRow)
            If getColumnIndex(spr, "seFactory") > -1 Then z4010.seFactory = getDataM(spr, getColumnIndex(spr, "seFactory"), xRow)
            If getColumnIndex(spr, "cdFactory") > -1 Then z4010.cdFactory = getDataM(spr, getColumnIndex(spr, "cdFactory"), xRow)
            If getColumnIndex(spr, "seLineProd1") > -1 Then z4010.seLineProd1 = getDataM(spr, getColumnIndex(spr, "seLineProd1"), xRow)
            If getColumnIndex(spr, "cdLineProd1") > -1 Then z4010.cdLineProd1 = getDataM(spr, getColumnIndex(spr, "cdLineProd1"), xRow)
            If getColumnIndex(spr, "seLineProd2") > -1 Then z4010.seLineProd2 = getDataM(spr, getColumnIndex(spr, "seLineProd2"), xRow)
            If getColumnIndex(spr, "cdLineProd2") > -1 Then z4010.cdLineProd2 = getDataM(spr, getColumnIndex(spr, "cdLineProd2"), xRow)
            If getColumnIndex(spr, "seLineProd3") > -1 Then z4010.seLineProd3 = getDataM(spr, getColumnIndex(spr, "seLineProd3"), xRow)
            If getColumnIndex(spr, "cdLineProd3") > -1 Then z4010.cdLineProd3 = getDataM(spr, getColumnIndex(spr, "cdLineProd3"), xRow)
            If getColumnIndex(spr, "DateInsert") > -1 Then z4010.DateInsert = getDataM(spr, getColumnIndex(spr, "DateInsert"), xRow)
            If getColumnIndex(spr, "InchargeInsert") > -1 Then z4010.InchargeInsert = getDataM(spr, getColumnIndex(spr, "InchargeInsert"), xRow)
            If getColumnIndex(spr, "DateUpdate") > -1 Then z4010.DateUpdate = getDataM(spr, getColumnIndex(spr, "DateUpdate"), xRow)
            If getColumnIndex(spr, "InchargeUpdate") > -1 Then z4010.InchargeUpdate = getDataM(spr, getColumnIndex(spr, "InchargeUpdate"), xRow)
            If getColumnIndex(spr, "RemarkOrder") > -1 Then z4010.RemarkOrder = getDataM(spr, getColumnIndex(spr, "RemarkOrder"), xRow)
            If getColumnIndex(spr, "RemarkCustomer") > -1 Then z4010.RemarkCustomer = getDataM(spr, getColumnIndex(spr, "RemarkCustomer"), xRow)
            If getColumnIndex(spr, "RemarkOther") > -1 Then z4010.RemarkOther = getDataM(spr, getColumnIndex(spr, "RemarkOther"), xRow)
            If getColumnIndex(spr, "seSite") > -1 Then z4010.seSite = getDataM(spr, getColumnIndex(spr, "seSite"), xRow)
            If getColumnIndex(spr, "cdSite") > -1 Then z4010.cdSite = getDataM(spr, getColumnIndex(spr, "cdSite"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4010_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K4010_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z4010 As T4010_AREA, CheckClear As Boolean, JOBCARD As String) As Boolean

        K4010_MOVE = False

        Try
            If READ_PFK4010(JOBCARD) = True Then
                z4010 = D4010
                K4010_MOVE = True
            Else
                If CheckClear = True Then z4010 = Nothing
            End If

            If getColumnIndex(spr, "JobCard") > -1 Then z4010.JobCard = getDataM(spr, getColumnIndex(spr, "JobCard"), xRow)
            If getColumnIndex(spr, "seJobState") > -1 Then z4010.seJobState = getDataM(spr, getColumnIndex(spr, "seJobState"), xRow)
            If getColumnIndex(spr, "cdJobState") > -1 Then z4010.cdJobState = getDataM(spr, getColumnIndex(spr, "cdJobState"), xRow)
            If getColumnIndex(spr, "SealNo") > -1 Then z4010.SealNo = getDataM(spr, getColumnIndex(spr, "SealNo"), xRow)
            If getColumnIndex(spr, "SlNoD") > -1 Then z4010.SlNoD = getDataM(spr, getColumnIndex(spr, "SlNoD"), xRow)
            If getColumnIndex(spr, "WorkOrder") > -1 Then z4010.WorkOrder = getDataM(spr, getColumnIndex(spr, "WorkOrder"), xRow)
            If getColumnIndex(spr, "WorkOrderSeq") > -1 Then z4010.WorkOrderSeq = getDataM(spr, getColumnIndex(spr, "WorkOrderSeq"), xRow)
            If getColumnIndex(spr, "selJob") > -1 Then z4010.selJob = getDataM(spr, getColumnIndex(spr, "selJob"), xRow)
            If getColumnIndex(spr, "selProd") > -1 Then z4010.selProd = getDataM(spr, getColumnIndex(spr, "selProd"), xRow)
            If getColumnIndex(spr, "DateStart") > -1 Then z4010.DateStart = getDataM(spr, getColumnIndex(spr, "DateStart"), xRow)
            If getColumnIndex(spr, "DateFinish") > -1 Then z4010.DateFinish = getDataM(spr, getColumnIndex(spr, "DateFinish"), xRow)
            If getColumnIndex(spr, "DatePlanStart") > -1 Then z4010.DatePlanStart = getDataM(spr, getColumnIndex(spr, "DatePlanStart"), xRow)
            If getColumnIndex(spr, "DatePlanFinish") > -1 Then z4010.DatePlanFinish = getDataM(spr, getColumnIndex(spr, "DatePlanFinish"), xRow)
            If getColumnIndex(spr, "JobCardBefore") > -1 Then z4010.JobCardBefore = getDataM(spr, getColumnIndex(spr, "JobCardBefore"), xRow)
            If getColumnIndex(spr, "JobCardAfter") > -1 Then z4010.JobCardAfter = getDataM(spr, getColumnIndex(spr, "JobCardAfter"), xRow)
            If getColumnIndex(spr, "CheckPlan") > -1 Then z4010.CheckPlan = getDataM(spr, getColumnIndex(spr, "CheckPlan"), xRow)
            If getColumnIndex(spr, "CheckUse") > -1 Then z4010.CheckUse = getDataM(spr, getColumnIndex(spr, "CheckUse"), xRow)
            If getColumnIndex(spr, "MaterialStatus") > -1 Then z4010.MaterialStatus = getDataM(spr, getColumnIndex(spr, "MaterialStatus"), xRow)
            If getColumnIndex(spr, "MoldStatus") > -1 Then z4010.MoldStatus = getDataM(spr, getColumnIndex(spr, "MoldStatus"), xRow)
            If getColumnIndex(spr, "LastStatus") > -1 Then z4010.LastStatus = getDataM(spr, getColumnIndex(spr, "LastStatus"), xRow)
            If getColumnIndex(spr, "CuttingDieStatus") > -1 Then z4010.CuttingDieStatus = getDataM(spr, getColumnIndex(spr, "CuttingDieStatus"), xRow)
            If getColumnIndex(spr, "SoleStatus") > -1 Then z4010.SoleStatus = getDataM(spr, getColumnIndex(spr, "SoleStatus"), xRow)
            If getColumnIndex(spr, "SoleNo") > -1 Then z4010.SoleNo = getDataM(spr, getColumnIndex(spr, "SoleNo"), xRow)
            If getColumnIndex(spr, "CuttingStatus") > -1 Then z4010.CuttingStatus = getDataM(spr, getColumnIndex(spr, "CuttingStatus"), xRow)
            If getColumnIndex(spr, "CuttingNo") > -1 Then z4010.CuttingNo = getDataM(spr, getColumnIndex(spr, "CuttingNo"), xRow)
            If getColumnIndex(spr, "StitchingStatus") > -1 Then z4010.StitchingStatus = getDataM(spr, getColumnIndex(spr, "StitchingStatus"), xRow)
            If getColumnIndex(spr, "StitchingNo") > -1 Then z4010.StitchingNo = getDataM(spr, getColumnIndex(spr, "StitchingNo"), xRow)
            If getColumnIndex(spr, "SubprocessStatus") > -1 Then z4010.SubprocessStatus = getDataM(spr, getColumnIndex(spr, "SubprocessStatus"), xRow)
            If getColumnIndex(spr, "SubprocessNo") > -1 Then z4010.SubprocessNo = getDataM(spr, getColumnIndex(spr, "SubprocessNo"), xRow)
            If getColumnIndex(spr, "OutsourceStatsus") > -1 Then z4010.OutsourceStatsus = getDataM(spr, getColumnIndex(spr, "OutsourceStatsus"), xRow)
            If getColumnIndex(spr, "OutsourceNo") > -1 Then z4010.OutsourceNo = getDataM(spr, getColumnIndex(spr, "OutsourceNo"), xRow)
            If getColumnIndex(spr, "StockfitStatsus") > -1 Then z4010.StockfitStatsus = getDataM(spr, getColumnIndex(spr, "StockfitStatsus"), xRow)
            If getColumnIndex(spr, "StockfitNo") > -1 Then z4010.StockfitNo = getDataM(spr, getColumnIndex(spr, "StockfitNo"), xRow)
            If getColumnIndex(spr, "AssemblyStatus") > -1 Then z4010.AssemblyStatus = getDataM(spr, getColumnIndex(spr, "AssemblyStatus"), xRow)
            If getColumnIndex(spr, "AssemblyNo") > -1 Then z4010.AssemblyNo = getDataM(spr, getColumnIndex(spr, "AssemblyNo"), xRow)
            If getColumnIndex(spr, "QtyOrder") > -1 Then z4010.QtyOrder = getDataM(spr, getColumnIndex(spr, "QtyOrder"), xRow)
            If getColumnIndex(spr, "QtyPlan") > -1 Then z4010.QtyPlan = getDataM(spr, getColumnIndex(spr, "QtyPlan"), xRow)
            If getColumnIndex(spr, "QtyJob") > -1 Then z4010.QtyJob = getDataM(spr, getColumnIndex(spr, "QtyJob"), xRow)
            If getColumnIndex(spr, "QtyJobSole") > -1 Then z4010.QtyJobSole = getDataM(spr, getColumnIndex(spr, "QtyJobSole"), xRow)
            If getColumnIndex(spr, "QtyBatchSole") > -1 Then z4010.QtyBatchSole = getDataM(spr, getColumnIndex(spr, "QtyBatchSole"), xRow)
            If getColumnIndex(spr, "QtySole") > -1 Then z4010.QtySole = getDataM(spr, getColumnIndex(spr, "QtySole"), xRow)
            If getColumnIndex(spr, "QtySoleA") > -1 Then z4010.QtySoleA = getDataM(spr, getColumnIndex(spr, "QtySoleA"), xRow)
            If getColumnIndex(spr, "QtySoleX") > -1 Then z4010.QtySoleX = getDataM(spr, getColumnIndex(spr, "QtySoleX"), xRow)
            If getColumnIndex(spr, "QtySoleXP") > -1 Then z4010.QtySoleXP = getDataM(spr, getColumnIndex(spr, "QtySoleXP"), xRow)
            If getColumnIndex(spr, "QtySoleXR") > -1 Then z4010.QtySoleXR = getDataM(spr, getColumnIndex(spr, "QtySoleXR"), xRow)
            If getColumnIndex(spr, "QtySoleBLOut") > -1 Then z4010.QtySoleBLOut = getDataM(spr, getColumnIndex(spr, "QtySoleBLOut"), xRow)
            If getColumnIndex(spr, "QtySoleBLIn") > -1 Then z4010.QtySoleBLIn = getDataM(spr, getColumnIndex(spr, "QtySoleBLIn"), xRow)
            If getColumnIndex(spr, "QtyJobCutting") > -1 Then z4010.QtyJobCutting = getDataM(spr, getColumnIndex(spr, "QtyJobCutting"), xRow)
            If getColumnIndex(spr, "QtyBatchCutting") > -1 Then z4010.QtyBatchCutting = getDataM(spr, getColumnIndex(spr, "QtyBatchCutting"), xRow)
            If getColumnIndex(spr, "QtyCom") > -1 Then z4010.QtyCom = getDataM(spr, getColumnIndex(spr, "QtyCom"), xRow)
            If getColumnIndex(spr, "QtyCutting") > -1 Then z4010.QtyCutting = getDataM(spr, getColumnIndex(spr, "QtyCutting"), xRow)
            If getColumnIndex(spr, "QtyCuttingA") > -1 Then z4010.QtyCuttingA = getDataM(spr, getColumnIndex(spr, "QtyCuttingA"), xRow)
            If getColumnIndex(spr, "QtyCuttingX") > -1 Then z4010.QtyCuttingX = getDataM(spr, getColumnIndex(spr, "QtyCuttingX"), xRow)
            If getColumnIndex(spr, "QtyCuttingXP") > -1 Then z4010.QtyCuttingXP = getDataM(spr, getColumnIndex(spr, "QtyCuttingXP"), xRow)
            If getColumnIndex(spr, "QtyCuttingXR") > -1 Then z4010.QtyCuttingXR = getDataM(spr, getColumnIndex(spr, "QtyCuttingXR"), xRow)
            If getColumnIndex(spr, "QtyCuttingBLOut") > -1 Then z4010.QtyCuttingBLOut = getDataM(spr, getColumnIndex(spr, "QtyCuttingBLOut"), xRow)
            If getColumnIndex(spr, "QtyCuttingBLIn") > -1 Then z4010.QtyCuttingBLIn = getDataM(spr, getColumnIndex(spr, "QtyCuttingBLIn"), xRow)
            If getColumnIndex(spr, "QtyJobStitching") > -1 Then z4010.QtyJobStitching = getDataM(spr, getColumnIndex(spr, "QtyJobStitching"), xRow)
            If getColumnIndex(spr, "QtyBatchStitching") > -1 Then z4010.QtyBatchStitching = getDataM(spr, getColumnIndex(spr, "QtyBatchStitching"), xRow)
            If getColumnIndex(spr, "QtyStitching") > -1 Then z4010.QtyStitching = getDataM(spr, getColumnIndex(spr, "QtyStitching"), xRow)
            If getColumnIndex(spr, "QtyStitchingA") > -1 Then z4010.QtyStitchingA = getDataM(spr, getColumnIndex(spr, "QtyStitchingA"), xRow)
            If getColumnIndex(spr, "QtyStitchingX") > -1 Then z4010.QtyStitchingX = getDataM(spr, getColumnIndex(spr, "QtyStitchingX"), xRow)
            If getColumnIndex(spr, "QtyStitchingXP") > -1 Then z4010.QtyStitchingXP = getDataM(spr, getColumnIndex(spr, "QtyStitchingXP"), xRow)
            If getColumnIndex(spr, "QtyStitchingXR") > -1 Then z4010.QtyStitchingXR = getDataM(spr, getColumnIndex(spr, "QtyStitchingXR"), xRow)
            If getColumnIndex(spr, "QtyStitchingBLOut") > -1 Then z4010.QtyStitchingBLOut = getDataM(spr, getColumnIndex(spr, "QtyStitchingBLOut"), xRow)
            If getColumnIndex(spr, "QtyStitchingBLIn") > -1 Then z4010.QtyStitchingBLIn = getDataM(spr, getColumnIndex(spr, "QtyStitchingBLIn"), xRow)
            If getColumnIndex(spr, "QtyJobStockfit") > -1 Then z4010.QtyJobStockfit = getDataM(spr, getColumnIndex(spr, "QtyJobStockfit"), xRow)
            If getColumnIndex(spr, "QtyBatchStockfit") > -1 Then z4010.QtyBatchStockfit = getDataM(spr, getColumnIndex(spr, "QtyBatchStockfit"), xRow)
            If getColumnIndex(spr, "QtyStockfit") > -1 Then z4010.QtyStockfit = getDataM(spr, getColumnIndex(spr, "QtyStockfit"), xRow)
            If getColumnIndex(spr, "QtyStockfitA") > -1 Then z4010.QtyStockfitA = getDataM(spr, getColumnIndex(spr, "QtyStockfitA"), xRow)
            If getColumnIndex(spr, "QtyStockfitX") > -1 Then z4010.QtyStockfitX = getDataM(spr, getColumnIndex(spr, "QtyStockfitX"), xRow)
            If getColumnIndex(spr, "QtyStockfitXP") > -1 Then z4010.QtyStockfitXP = getDataM(spr, getColumnIndex(spr, "QtyStockfitXP"), xRow)
            If getColumnIndex(spr, "QtyStockfitXR") > -1 Then z4010.QtyStockfitXR = getDataM(spr, getColumnIndex(spr, "QtyStockfitXR"), xRow)
            If getColumnIndex(spr, "QtyStockfitBLOut") > -1 Then z4010.QtyStockfitBLOut = getDataM(spr, getColumnIndex(spr, "QtyStockfitBLOut"), xRow)
            If getColumnIndex(spr, "QtyStockfitBLIn") > -1 Then z4010.QtyStockfitBLIn = getDataM(spr, getColumnIndex(spr, "QtyStockfitBLIn"), xRow)
            If getColumnIndex(spr, "QtyJobAssembly") > -1 Then z4010.QtyJobAssembly = getDataM(spr, getColumnIndex(spr, "QtyJobAssembly"), xRow)
            If getColumnIndex(spr, "QtyBatchAssembly") > -1 Then z4010.QtyBatchAssembly = getDataM(spr, getColumnIndex(spr, "QtyBatchAssembly"), xRow)
            If getColumnIndex(spr, "QtyAssembly") > -1 Then z4010.QtyAssembly = getDataM(spr, getColumnIndex(spr, "QtyAssembly"), xRow)
            If getColumnIndex(spr, "QtyAssemblyA") > -1 Then z4010.QtyAssemblyA = getDataM(spr, getColumnIndex(spr, "QtyAssemblyA"), xRow)
            If getColumnIndex(spr, "QtyAssemblyX") > -1 Then z4010.QtyAssemblyX = getDataM(spr, getColumnIndex(spr, "QtyAssemblyX"), xRow)
            If getColumnIndex(spr, "QtyAssemblyXP") > -1 Then z4010.QtyAssemblyXP = getDataM(spr, getColumnIndex(spr, "QtyAssemblyXP"), xRow)
            If getColumnIndex(spr, "QtyAssemblyXR") > -1 Then z4010.QtyAssemblyXR = getDataM(spr, getColumnIndex(spr, "QtyAssemblyXR"), xRow)
            If getColumnIndex(spr, "QtyAssemblyBLOut") > -1 Then z4010.QtyAssemblyBLOut = getDataM(spr, getColumnIndex(spr, "QtyAssemblyBLOut"), xRow)
            If getColumnIndex(spr, "QtyAssemblyBLIn") > -1 Then z4010.QtyAssemblyBLIn = getDataM(spr, getColumnIndex(spr, "QtyAssemblyBLIn"), xRow)
            If getColumnIndex(spr, "QtyJobPacking") > -1 Then z4010.QtyJobPacking = getDataM(spr, getColumnIndex(spr, "QtyJobPacking"), xRow)
            If getColumnIndex(spr, "QtyBatchPacking") > -1 Then z4010.QtyBatchPacking = getDataM(spr, getColumnIndex(spr, "QtyBatchPacking"), xRow)
            If getColumnIndex(spr, "QtyPacking") > -1 Then z4010.QtyPacking = getDataM(spr, getColumnIndex(spr, "QtyPacking"), xRow)
            If getColumnIndex(spr, "QtyPackingA") > -1 Then z4010.QtyPackingA = getDataM(spr, getColumnIndex(spr, "QtyPackingA"), xRow)
            If getColumnIndex(spr, "QtyPackingX") > -1 Then z4010.QtyPackingX = getDataM(spr, getColumnIndex(spr, "QtyPackingX"), xRow)
            If getColumnIndex(spr, "QtyPackingXP") > -1 Then z4010.QtyPackingXP = getDataM(spr, getColumnIndex(spr, "QtyPackingXP"), xRow)
            If getColumnIndex(spr, "QtyPackingXR") > -1 Then z4010.QtyPackingXR = getDataM(spr, getColumnIndex(spr, "QtyPackingXR"), xRow)
            If getColumnIndex(spr, "QtyPackingBLOut") > -1 Then z4010.QtyPackingBLOut = getDataM(spr, getColumnIndex(spr, "QtyPackingBLOut"), xRow)
            If getColumnIndex(spr, "QtyPackingBLIn") > -1 Then z4010.QtyPackingBLIn = getDataM(spr, getColumnIndex(spr, "QtyPackingBLIn"), xRow)
            If getColumnIndex(spr, "QtyJobShipping") > -1 Then z4010.QtyJobShipping = getDataM(spr, getColumnIndex(spr, "QtyJobShipping"), xRow)
            If getColumnIndex(spr, "QtyBatchShipping") > -1 Then z4010.QtyBatchShipping = getDataM(spr, getColumnIndex(spr, "QtyBatchShipping"), xRow)
            If getColumnIndex(spr, "QtyShipping") > -1 Then z4010.QtyShipping = getDataM(spr, getColumnIndex(spr, "QtyShipping"), xRow)
            If getColumnIndex(spr, "QtyShippingA") > -1 Then z4010.QtyShippingA = getDataM(spr, getColumnIndex(spr, "QtyShippingA"), xRow)
            If getColumnIndex(spr, "QtyShippingX") > -1 Then z4010.QtyShippingX = getDataM(spr, getColumnIndex(spr, "QtyShippingX"), xRow)
            If getColumnIndex(spr, "QtyShippingBLOut") > -1 Then z4010.QtyShippingBLOut = getDataM(spr, getColumnIndex(spr, "QtyShippingBLOut"), xRow)
            If getColumnIndex(spr, "QtyShippingBLIn") > -1 Then z4010.QtyShippingBLIn = getDataM(spr, getColumnIndex(spr, "QtyShippingBLIn"), xRow)
            If getColumnIndex(spr, "QtyFootbed") > -1 Then z4010.QtyFootbed = getDataM(spr, getColumnIndex(spr, "QtyFootbed"), xRow)
            If getColumnIndex(spr, "QtyFootbedA") > -1 Then z4010.QtyFootbedA = getDataM(spr, getColumnIndex(spr, "QtyFootbedA"), xRow)
            If getColumnIndex(spr, "QtyFootbedX") > -1 Then z4010.QtyFootbedX = getDataM(spr, getColumnIndex(spr, "QtyFootbedX"), xRow)
            If getColumnIndex(spr, "QtyInnerBox") > -1 Then z4010.QtyInnerBox = getDataM(spr, getColumnIndex(spr, "QtyInnerBox"), xRow)
            If getColumnIndex(spr, "QtyInnerBoxA") > -1 Then z4010.QtyInnerBoxA = getDataM(spr, getColumnIndex(spr, "QtyInnerBoxA"), xRow)
            If getColumnIndex(spr, "QtyInnerBoxX") > -1 Then z4010.QtyInnerBoxX = getDataM(spr, getColumnIndex(spr, "QtyInnerBoxX"), xRow)
            If getColumnIndex(spr, "QtyInbound") > -1 Then z4010.QtyInbound = getDataM(spr, getColumnIndex(spr, "QtyInbound"), xRow)
            If getColumnIndex(spr, "QtyInboundA") > -1 Then z4010.QtyInboundA = getDataM(spr, getColumnIndex(spr, "QtyInboundA"), xRow)
            If getColumnIndex(spr, "QtyInboundX") > -1 Then z4010.QtyInboundX = getDataM(spr, getColumnIndex(spr, "QtyInboundX"), xRow)
            If getColumnIndex(spr, "QtySB2UI") > -1 Then z4010.QtySB2UI = getDataM(spr, getColumnIndex(spr, "QtySB2UI"), xRow)
            If getColumnIndex(spr, "QtySB2UIA") > -1 Then z4010.QtySB2UIA = getDataM(spr, getColumnIndex(spr, "QtySB2UIA"), xRow)
            If getColumnIndex(spr, "QtySB2UIX") > -1 Then z4010.QtySB2UIX = getDataM(spr, getColumnIndex(spr, "QtySB2UIX"), xRow)
            If getColumnIndex(spr, "QtySB2UO") > -1 Then z4010.QtySB2UO = getDataM(spr, getColumnIndex(spr, "QtySB2UO"), xRow)
            If getColumnIndex(spr, "QtySB2UOA") > -1 Then z4010.QtySB2UOA = getDataM(spr, getColumnIndex(spr, "QtySB2UOA"), xRow)
            If getColumnIndex(spr, "QtySB2UOX") > -1 Then z4010.QtySB2UOX = getDataM(spr, getColumnIndex(spr, "QtySB2UOX"), xRow)
            If getColumnIndex(spr, "QtySB2SI") > -1 Then z4010.QtySB2SI = getDataM(spr, getColumnIndex(spr, "QtySB2SI"), xRow)
            If getColumnIndex(spr, "QtySB2SIA") > -1 Then z4010.QtySB2SIA = getDataM(spr, getColumnIndex(spr, "QtySB2SIA"), xRow)
            If getColumnIndex(spr, "QtySB2SIX") > -1 Then z4010.QtySB2SIX = getDataM(spr, getColumnIndex(spr, "QtySB2SIX"), xRow)
            If getColumnIndex(spr, "QtySB2SO") > -1 Then z4010.QtySB2SO = getDataM(spr, getColumnIndex(spr, "QtySB2SO"), xRow)
            If getColumnIndex(spr, "QtySB2SOA") > -1 Then z4010.QtySB2SOA = getDataM(spr, getColumnIndex(spr, "QtySB2SOA"), xRow)
            If getColumnIndex(spr, "QtySB2SOX") > -1 Then z4010.QtySB2SOX = getDataM(spr, getColumnIndex(spr, "QtySB2SOX"), xRow)
            If getColumnIndex(spr, "QtySB2FI") > -1 Then z4010.QtySB2FI = getDataM(spr, getColumnIndex(spr, "QtySB2FI"), xRow)
            If getColumnIndex(spr, "QtySB2FIA") > -1 Then z4010.QtySB2FIA = getDataM(spr, getColumnIndex(spr, "QtySB2FIA"), xRow)
            If getColumnIndex(spr, "QtySB2FIX") > -1 Then z4010.QtySB2FIX = getDataM(spr, getColumnIndex(spr, "QtySB2FIX"), xRow)
            If getColumnIndex(spr, "QtySB2FO") > -1 Then z4010.QtySB2FO = getDataM(spr, getColumnIndex(spr, "QtySB2FO"), xRow)
            If getColumnIndex(spr, "QtySB2FOA") > -1 Then z4010.QtySB2FOA = getDataM(spr, getColumnIndex(spr, "QtySB2FOA"), xRow)
            If getColumnIndex(spr, "QtySB2FOX") > -1 Then z4010.QtySB2FOX = getDataM(spr, getColumnIndex(spr, "QtySB2FOX"), xRow)
            If getColumnIndex(spr, "seFactory") > -1 Then z4010.seFactory = getDataM(spr, getColumnIndex(spr, "seFactory"), xRow)
            If getColumnIndex(spr, "cdFactory") > -1 Then z4010.cdFactory = getDataM(spr, getColumnIndex(spr, "cdFactory"), xRow)
            If getColumnIndex(spr, "seLineProd1") > -1 Then z4010.seLineProd1 = getDataM(spr, getColumnIndex(spr, "seLineProd1"), xRow)
            If getColumnIndex(spr, "cdLineProd1") > -1 Then z4010.cdLineProd1 = getDataM(spr, getColumnIndex(spr, "cdLineProd1"), xRow)
            If getColumnIndex(spr, "seLineProd2") > -1 Then z4010.seLineProd2 = getDataM(spr, getColumnIndex(spr, "seLineProd2"), xRow)
            If getColumnIndex(spr, "cdLineProd2") > -1 Then z4010.cdLineProd2 = getDataM(spr, getColumnIndex(spr, "cdLineProd2"), xRow)
            If getColumnIndex(spr, "seLineProd3") > -1 Then z4010.seLineProd3 = getDataM(spr, getColumnIndex(spr, "seLineProd3"), xRow)
            If getColumnIndex(spr, "cdLineProd3") > -1 Then z4010.cdLineProd3 = getDataM(spr, getColumnIndex(spr, "cdLineProd3"), xRow)
            If getColumnIndex(spr, "DateInsert") > -1 Then z4010.DateInsert = getDataM(spr, getColumnIndex(spr, "DateInsert"), xRow)
            If getColumnIndex(spr, "InchargeInsert") > -1 Then z4010.InchargeInsert = getDataM(spr, getColumnIndex(spr, "InchargeInsert"), xRow)
            If getColumnIndex(spr, "DateUpdate") > -1 Then z4010.DateUpdate = getDataM(spr, getColumnIndex(spr, "DateUpdate"), xRow)
            If getColumnIndex(spr, "InchargeUpdate") > -1 Then z4010.InchargeUpdate = getDataM(spr, getColumnIndex(spr, "InchargeUpdate"), xRow)
            If getColumnIndex(spr, "RemarkOrder") > -1 Then z4010.RemarkOrder = getDataM(spr, getColumnIndex(spr, "RemarkOrder"), xRow)
            If getColumnIndex(spr, "RemarkCustomer") > -1 Then z4010.RemarkCustomer = getDataM(spr, getColumnIndex(spr, "RemarkCustomer"), xRow)
            If getColumnIndex(spr, "RemarkOther") > -1 Then z4010.RemarkOther = getDataM(spr, getColumnIndex(spr, "RemarkOther"), xRow)
            If getColumnIndex(spr, "seSite") > -1 Then z4010.seSite = getDataM(spr, getColumnIndex(spr, "seSite"), xRow)
            If getColumnIndex(spr, "cdSite") > -1 Then z4010.cdSite = getDataM(spr, getColumnIndex(spr, "cdSite"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4010_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K4010_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z4010 As T4010_AREA, Job As String, JOBCARD As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K4010_MOVE = False

        Try
            If READ_PFK4010(JOBCARD) = True Then
                z4010 = D4010
                K4010_MOVE = True
            Else
                z4010 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4010")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "JOBCARD" : z4010.JobCard = Children(i).Code
                                Case "SEJOBSTATE" : z4010.seJobState = Children(i).Code
                                Case "CDJOBSTATE" : z4010.cdJobState = Children(i).Code
                                Case "SEALNO" : z4010.SealNo = Children(i).Code
                                Case "SLNOD" : z4010.SlNoD = Children(i).Code
                                Case "WORKORDER" : z4010.WorkOrder = Children(i).Code
                                Case "WORKORDERSEQ" : z4010.WorkOrderSeq = Children(i).Code
                                Case "SELJOB" : z4010.selJob = Children(i).Code
                                Case "SELPROD" : z4010.selProd = Children(i).Code
                                Case "DATESTART" : z4010.DateStart = Children(i).Code
                                Case "DATEFINISH" : z4010.DateFinish = Children(i).Code
                                Case "DATEPLANSTART" : z4010.DatePlanStart = Children(i).Code
                                Case "DATEPLANFINISH" : z4010.DatePlanFinish = Children(i).Code
                                Case "JOBCARDBEFORE" : z4010.JobCardBefore = Children(i).Code
                                Case "JOBCARDAFTER" : z4010.JobCardAfter = Children(i).Code
                                Case "CHECKPLAN" : z4010.CheckPlan = Children(i).Code
                                Case "CHECKUSE" : z4010.CheckUse = Children(i).Code
                                Case "MATERIALSTATUS" : z4010.MaterialStatus = Children(i).Code
                                Case "MOLDSTATUS" : z4010.MoldStatus = Children(i).Code
                                Case "LASTSTATUS" : z4010.LastStatus = Children(i).Code
                                Case "CUTTINGDIESTATUS" : z4010.CuttingDieStatus = Children(i).Code
                                Case "SOLESTATUS" : z4010.SoleStatus = Children(i).Code
                                Case "SOLENO" : z4010.SoleNo = Children(i).Code
                                Case "CUTTINGSTATUS" : z4010.CuttingStatus = Children(i).Code
                                Case "CUTTINGNO" : z4010.CuttingNo = Children(i).Code
                                Case "STITCHINGSTATUS" : z4010.StitchingStatus = Children(i).Code
                                Case "STITCHINGNO" : z4010.StitchingNo = Children(i).Code
                                Case "SUBPROCESSSTATUS" : z4010.SubprocessStatus = Children(i).Code
                                Case "SUBPROCESSNO" : z4010.SubprocessNo = Children(i).Code
                                Case "OUTSOURCESTATSUS" : z4010.OutsourceStatsus = Children(i).Code
                                Case "OUTSOURCENO" : z4010.OutsourceNo = Children(i).Code
                                Case "STOCKFITSTATSUS" : z4010.StockfitStatsus = Children(i).Code
                                Case "STOCKFITNO" : z4010.StockfitNo = Children(i).Code
                                Case "ASSEMBLYSTATUS" : z4010.AssemblyStatus = Children(i).Code
                                Case "ASSEMBLYNO" : z4010.AssemblyNo = Children(i).Code
                                Case "QTYORDER" : z4010.QtyOrder = Children(i).Code
                                Case "QTYPLAN" : z4010.QtyPlan = Children(i).Code
                                Case "QTYJOB" : z4010.QtyJob = Children(i).Code
                                Case "QTYJOBSOLE" : z4010.QtyJobSole = Children(i).Code
                                Case "QTYBATCHSOLE" : z4010.QtyBatchSole = Children(i).Code
                                Case "QTYSOLE" : z4010.QtySole = Children(i).Code
                                Case "QTYSOLEA" : z4010.QtySoleA = Children(i).Code
                                Case "QTYSOLEX" : z4010.QtySoleX = Children(i).Code
                                Case "QTYSOLEXP" : z4010.QtySoleXP = Children(i).Code
                                Case "QTYSOLEXR" : z4010.QtySoleXR = Children(i).Code
                                Case "QTYSOLEBLOUT" : z4010.QtySoleBLOut = Children(i).Code
                                Case "QTYSOLEBLIN" : z4010.QtySoleBLIn = Children(i).Code
                                Case "QTYJOBCUTTING" : z4010.QtyJobCutting = Children(i).Code
                                Case "QTYBATCHCUTTING" : z4010.QtyBatchCutting = Children(i).Code
                                Case "QTYCOM" : z4010.QtyCom = Children(i).Code
                                Case "QTYCUTTING" : z4010.QtyCutting = Children(i).Code
                                Case "QTYCUTTINGA" : z4010.QtyCuttingA = Children(i).Code
                                Case "QTYCUTTINGX" : z4010.QtyCuttingX = Children(i).Code
                                Case "QTYCUTTINGXP" : z4010.QtyCuttingXP = Children(i).Code
                                Case "QTYCUTTINGXR" : z4010.QtyCuttingXR = Children(i).Code
                                Case "QTYCUTTINGBLOUT" : z4010.QtyCuttingBLOut = Children(i).Code
                                Case "QTYCUTTINGBLIN" : z4010.QtyCuttingBLIn = Children(i).Code
                                Case "QTYJOBSTITCHING" : z4010.QtyJobStitching = Children(i).Code
                                Case "QTYBATCHSTITCHING" : z4010.QtyBatchStitching = Children(i).Code
                                Case "QTYSTITCHING" : z4010.QtyStitching = Children(i).Code
                                Case "QTYSTITCHINGA" : z4010.QtyStitchingA = Children(i).Code
                                Case "QTYSTITCHINGX" : z4010.QtyStitchingX = Children(i).Code
                                Case "QTYSTITCHINGXP" : z4010.QtyStitchingXP = Children(i).Code
                                Case "QTYSTITCHINGXR" : z4010.QtyStitchingXR = Children(i).Code
                                Case "QTYSTITCHINGBLOUT" : z4010.QtyStitchingBLOut = Children(i).Code
                                Case "QTYSTITCHINGBLIN" : z4010.QtyStitchingBLIn = Children(i).Code
                                Case "QTYJOBSTOCKFIT" : z4010.QtyJobStockfit = Children(i).Code
                                Case "QTYBATCHSTOCKFIT" : z4010.QtyBatchStockfit = Children(i).Code
                                Case "QTYSTOCKFIT" : z4010.QtyStockfit = Children(i).Code
                                Case "QTYSTOCKFITA" : z4010.QtyStockfitA = Children(i).Code
                                Case "QTYSTOCKFITX" : z4010.QtyStockfitX = Children(i).Code
                                Case "QTYSTOCKFITXP" : z4010.QtyStockfitXP = Children(i).Code
                                Case "QTYSTOCKFITXR" : z4010.QtyStockfitXR = Children(i).Code
                                Case "QTYSTOCKFITBLOUT" : z4010.QtyStockfitBLOut = Children(i).Code
                                Case "QTYSTOCKFITBLIN" : z4010.QtyStockfitBLIn = Children(i).Code
                                Case "QTYJOBASSEMBLY" : z4010.QtyJobAssembly = Children(i).Code
                                Case "QTYBATCHASSEMBLY" : z4010.QtyBatchAssembly = Children(i).Code
                                Case "QTYASSEMBLY" : z4010.QtyAssembly = Children(i).Code
                                Case "QTYASSEMBLYA" : z4010.QtyAssemblyA = Children(i).Code
                                Case "QTYASSEMBLYX" : z4010.QtyAssemblyX = Children(i).Code
                                Case "QTYASSEMBLYXP" : z4010.QtyAssemblyXP = Children(i).Code
                                Case "QTYASSEMBLYXR" : z4010.QtyAssemblyXR = Children(i).Code
                                Case "QTYASSEMBLYBLOUT" : z4010.QtyAssemblyBLOut = Children(i).Code
                                Case "QTYASSEMBLYBLIN" : z4010.QtyAssemblyBLIn = Children(i).Code
                                Case "QTYJOBPACKING" : z4010.QtyJobPacking = Children(i).Code
                                Case "QTYBATCHPACKING" : z4010.QtyBatchPacking = Children(i).Code
                                Case "QTYPACKING" : z4010.QtyPacking = Children(i).Code
                                Case "QTYPACKINGA" : z4010.QtyPackingA = Children(i).Code
                                Case "QTYPACKINGX" : z4010.QtyPackingX = Children(i).Code
                                Case "QTYPACKINGXP" : z4010.QtyPackingXP = Children(i).Code
                                Case "QTYPACKINGXR" : z4010.QtyPackingXR = Children(i).Code
                                Case "QTYPACKINGBLOUT" : z4010.QtyPackingBLOut = Children(i).Code
                                Case "QTYPACKINGBLIN" : z4010.QtyPackingBLIn = Children(i).Code
                                Case "QTYJOBSHIPPING" : z4010.QtyJobShipping = Children(i).Code
                                Case "QTYBATCHSHIPPING" : z4010.QtyBatchShipping = Children(i).Code
                                Case "QTYSHIPPING" : z4010.QtyShipping = Children(i).Code
                                Case "QTYSHIPPINGA" : z4010.QtyShippingA = Children(i).Code
                                Case "QTYSHIPPINGX" : z4010.QtyShippingX = Children(i).Code
                                Case "QTYSHIPPINGBLOUT" : z4010.QtyShippingBLOut = Children(i).Code
                                Case "QTYSHIPPINGBLIN" : z4010.QtyShippingBLIn = Children(i).Code
                                Case "QTYFOOTBED" : z4010.QtyFootbed = Children(i).Code
                                Case "QTYFOOTBEDA" : z4010.QtyFootbedA = Children(i).Code
                                Case "QTYFOOTBEDX" : z4010.QtyFootbedX = Children(i).Code
                                Case "QTYINNERBOX" : z4010.QtyInnerBox = Children(i).Code
                                Case "QTYINNERBOXA" : z4010.QtyInnerBoxA = Children(i).Code
                                Case "QTYINNERBOXX" : z4010.QtyInnerBoxX = Children(i).Code
                                Case "QTYINBOUND" : z4010.QtyInbound = Children(i).Code
                                Case "QTYINBOUNDA" : z4010.QtyInboundA = Children(i).Code
                                Case "QTYINBOUNDX" : z4010.QtyInboundX = Children(i).Code
                                Case "QTYSB2UI" : z4010.QtySB2UI = Children(i).Code
                                Case "QTYSB2UIA" : z4010.QtySB2UIA = Children(i).Code
                                Case "QTYSB2UIX" : z4010.QtySB2UIX = Children(i).Code
                                Case "QTYSB2UO" : z4010.QtySB2UO = Children(i).Code
                                Case "QTYSB2UOA" : z4010.QtySB2UOA = Children(i).Code
                                Case "QTYSB2UOX" : z4010.QtySB2UOX = Children(i).Code
                                Case "QTYSB2SI" : z4010.QtySB2SI = Children(i).Code
                                Case "QTYSB2SIA" : z4010.QtySB2SIA = Children(i).Code
                                Case "QTYSB2SIX" : z4010.QtySB2SIX = Children(i).Code
                                Case "QTYSB2SO" : z4010.QtySB2SO = Children(i).Code
                                Case "QTYSB2SOA" : z4010.QtySB2SOA = Children(i).Code
                                Case "QTYSB2SOX" : z4010.QtySB2SOX = Children(i).Code
                                Case "QTYSB2FI" : z4010.QtySB2FI = Children(i).Code
                                Case "QTYSB2FIA" : z4010.QtySB2FIA = Children(i).Code
                                Case "QTYSB2FIX" : z4010.QtySB2FIX = Children(i).Code
                                Case "QTYSB2FO" : z4010.QtySB2FO = Children(i).Code
                                Case "QTYSB2FOA" : z4010.QtySB2FOA = Children(i).Code
                                Case "QTYSB2FOX" : z4010.QtySB2FOX = Children(i).Code
                                Case "SEFACTORY" : z4010.seFactory = Children(i).Code
                                Case "CDFACTORY" : z4010.cdFactory = Children(i).Code
                                Case "SELINEPROD1" : z4010.seLineProd1 = Children(i).Code
                                Case "CDLINEPROD1" : z4010.cdLineProd1 = Children(i).Code
                                Case "SELINEPROD2" : z4010.seLineProd2 = Children(i).Code
                                Case "CDLINEPROD2" : z4010.cdLineProd2 = Children(i).Code
                                Case "SELINEPROD3" : z4010.seLineProd3 = Children(i).Code
                                Case "CDLINEPROD3" : z4010.cdLineProd3 = Children(i).Code
                                Case "DATEINSERT" : z4010.DateInsert = Children(i).Code
                                Case "INCHARGEINSERT" : z4010.InchargeInsert = Children(i).Code
                                Case "DATEUPDATE" : z4010.DateUpdate = Children(i).Code
                                Case "INCHARGEUPDATE" : z4010.InchargeUpdate = Children(i).Code
                                Case "REMARKORDER" : z4010.RemarkOrder = Children(i).Code
                                Case "REMARKCUSTOMER" : z4010.RemarkCustomer = Children(i).Code
                                Case "REMARKOTHER" : z4010.RemarkOther = Children(i).Code
                                Case "SESITE" : z4010.seSite = Children(i).Code
                                Case "CDSITE" : z4010.cdSite = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "JOBCARD" : z4010.JobCard = Children(i).Data
                                Case "SEJOBSTATE" : z4010.seJobState = Children(i).Data
                                Case "CDJOBSTATE" : z4010.cdJobState = Children(i).Data
                                Case "SEALNO" : z4010.SealNo = Children(i).Data
                                Case "SLNOD" : z4010.SlNoD = Children(i).Data
                                Case "WORKORDER" : z4010.WorkOrder = Children(i).Data
                                Case "WORKORDERSEQ" : z4010.WorkOrderSeq = Children(i).Data
                                Case "SELJOB" : z4010.selJob = Children(i).Data
                                Case "SELPROD" : z4010.selProd = Children(i).Data
                                Case "DATESTART" : z4010.DateStart = Children(i).Data
                                Case "DATEFINISH" : z4010.DateFinish = Children(i).Data
                                Case "DATEPLANSTART" : z4010.DatePlanStart = Children(i).Data
                                Case "DATEPLANFINISH" : z4010.DatePlanFinish = Children(i).Data
                                Case "JOBCARDBEFORE" : z4010.JobCardBefore = Children(i).Data
                                Case "JOBCARDAFTER" : z4010.JobCardAfter = Children(i).Data
                                Case "CHECKPLAN" : z4010.CheckPlan = Children(i).Data
                                Case "CHECKUSE" : z4010.CheckUse = Children(i).Data
                                Case "MATERIALSTATUS" : z4010.MaterialStatus = Children(i).Data
                                Case "MOLDSTATUS" : z4010.MoldStatus = Children(i).Data
                                Case "LASTSTATUS" : z4010.LastStatus = Children(i).Data
                                Case "CUTTINGDIESTATUS" : z4010.CuttingDieStatus = Children(i).Data
                                Case "SOLESTATUS" : z4010.SoleStatus = Children(i).Data
                                Case "SOLENO" : z4010.SoleNo = Children(i).Data
                                Case "CUTTINGSTATUS" : z4010.CuttingStatus = Children(i).Data
                                Case "CUTTINGNO" : z4010.CuttingNo = Children(i).Data
                                Case "STITCHINGSTATUS" : z4010.StitchingStatus = Children(i).Data
                                Case "STITCHINGNO" : z4010.StitchingNo = Children(i).Data
                                Case "SUBPROCESSSTATUS" : z4010.SubprocessStatus = Children(i).Data
                                Case "SUBPROCESSNO" : z4010.SubprocessNo = Children(i).Data
                                Case "OUTSOURCESTATSUS" : z4010.OutsourceStatsus = Children(i).Data
                                Case "OUTSOURCENO" : z4010.OutsourceNo = Children(i).Data
                                Case "STOCKFITSTATSUS" : z4010.StockfitStatsus = Children(i).Data
                                Case "STOCKFITNO" : z4010.StockfitNo = Children(i).Data
                                Case "ASSEMBLYSTATUS" : z4010.AssemblyStatus = Children(i).Data
                                Case "ASSEMBLYNO" : z4010.AssemblyNo = Children(i).Data
                                Case "QTYORDER" : z4010.QtyOrder = Children(i).Data
                                Case "QTYPLAN" : z4010.QtyPlan = Children(i).Data
                                Case "QTYJOB" : z4010.QtyJob = Children(i).Data
                                Case "QTYJOBSOLE" : z4010.QtyJobSole = Children(i).Data
                                Case "QTYBATCHSOLE" : z4010.QtyBatchSole = Children(i).Data
                                Case "QTYSOLE" : z4010.QtySole = Children(i).Data
                                Case "QTYSOLEA" : z4010.QtySoleA = Children(i).Data
                                Case "QTYSOLEX" : z4010.QtySoleX = Children(i).Data
                                Case "QTYSOLEXP" : z4010.QtySoleXP = Children(i).Data
                                Case "QTYSOLEXR" : z4010.QtySoleXR = Children(i).Data
                                Case "QTYSOLEBLOUT" : z4010.QtySoleBLOut = Children(i).Data
                                Case "QTYSOLEBLIN" : z4010.QtySoleBLIn = Children(i).Data
                                Case "QTYJOBCUTTING" : z4010.QtyJobCutting = Children(i).Data
                                Case "QTYBATCHCUTTING" : z4010.QtyBatchCutting = Children(i).Data
                                Case "QTYCOM" : z4010.QtyCom = Children(i).Data
                                Case "QTYCUTTING" : z4010.QtyCutting = Children(i).Data
                                Case "QTYCUTTINGA" : z4010.QtyCuttingA = Children(i).Data
                                Case "QTYCUTTINGX" : z4010.QtyCuttingX = Children(i).Data
                                Case "QTYCUTTINGXP" : z4010.QtyCuttingXP = Children(i).Data
                                Case "QTYCUTTINGXR" : z4010.QtyCuttingXR = Children(i).Data
                                Case "QTYCUTTINGBLOUT" : z4010.QtyCuttingBLOut = Children(i).Data
                                Case "QTYCUTTINGBLIN" : z4010.QtyCuttingBLIn = Children(i).Data
                                Case "QTYJOBSTITCHING" : z4010.QtyJobStitching = Children(i).Data
                                Case "QTYBATCHSTITCHING" : z4010.QtyBatchStitching = Children(i).Data
                                Case "QTYSTITCHING" : z4010.QtyStitching = Children(i).Data
                                Case "QTYSTITCHINGA" : z4010.QtyStitchingA = Children(i).Data
                                Case "QTYSTITCHINGX" : z4010.QtyStitchingX = Children(i).Data
                                Case "QTYSTITCHINGXP" : z4010.QtyStitchingXP = Children(i).Data
                                Case "QTYSTITCHINGXR" : z4010.QtyStitchingXR = Children(i).Data
                                Case "QTYSTITCHINGBLOUT" : z4010.QtyStitchingBLOut = Children(i).Data
                                Case "QTYSTITCHINGBLIN" : z4010.QtyStitchingBLIn = Children(i).Data
                                Case "QTYJOBSTOCKFIT" : z4010.QtyJobStockfit = Children(i).Data
                                Case "QTYBATCHSTOCKFIT" : z4010.QtyBatchStockfit = Children(i).Data
                                Case "QTYSTOCKFIT" : z4010.QtyStockfit = Children(i).Data
                                Case "QTYSTOCKFITA" : z4010.QtyStockfitA = Children(i).Data
                                Case "QTYSTOCKFITX" : z4010.QtyStockfitX = Children(i).Data
                                Case "QTYSTOCKFITXP" : z4010.QtyStockfitXP = Children(i).Data
                                Case "QTYSTOCKFITXR" : z4010.QtyStockfitXR = Children(i).Data
                                Case "QTYSTOCKFITBLOUT" : z4010.QtyStockfitBLOut = Children(i).Data
                                Case "QTYSTOCKFITBLIN" : z4010.QtyStockfitBLIn = Children(i).Data
                                Case "QTYJOBASSEMBLY" : z4010.QtyJobAssembly = Children(i).Data
                                Case "QTYBATCHASSEMBLY" : z4010.QtyBatchAssembly = Children(i).Data
                                Case "QTYASSEMBLY" : z4010.QtyAssembly = Children(i).Data
                                Case "QTYASSEMBLYA" : z4010.QtyAssemblyA = Children(i).Data
                                Case "QTYASSEMBLYX" : z4010.QtyAssemblyX = Children(i).Data
                                Case "QTYASSEMBLYXP" : z4010.QtyAssemblyXP = Children(i).Data
                                Case "QTYASSEMBLYXR" : z4010.QtyAssemblyXR = Children(i).Data
                                Case "QTYASSEMBLYBLOUT" : z4010.QtyAssemblyBLOut = Children(i).Data
                                Case "QTYASSEMBLYBLIN" : z4010.QtyAssemblyBLIn = Children(i).Data
                                Case "QTYJOBPACKING" : z4010.QtyJobPacking = Children(i).Data
                                Case "QTYBATCHPACKING" : z4010.QtyBatchPacking = Children(i).Data
                                Case "QTYPACKING" : z4010.QtyPacking = Children(i).Data
                                Case "QTYPACKINGA" : z4010.QtyPackingA = Children(i).Data
                                Case "QTYPACKINGX" : z4010.QtyPackingX = Children(i).Data
                                Case "QTYPACKINGXP" : z4010.QtyPackingXP = Children(i).Data
                                Case "QTYPACKINGXR" : z4010.QtyPackingXR = Children(i).Data
                                Case "QTYPACKINGBLOUT" : z4010.QtyPackingBLOut = Children(i).Data
                                Case "QTYPACKINGBLIN" : z4010.QtyPackingBLIn = Children(i).Data
                                Case "QTYJOBSHIPPING" : z4010.QtyJobShipping = Children(i).Data
                                Case "QTYBATCHSHIPPING" : z4010.QtyBatchShipping = Children(i).Data
                                Case "QTYSHIPPING" : z4010.QtyShipping = Children(i).Data
                                Case "QTYSHIPPINGA" : z4010.QtyShippingA = Children(i).Data
                                Case "QTYSHIPPINGX" : z4010.QtyShippingX = Children(i).Data
                                Case "QTYSHIPPINGBLOUT" : z4010.QtyShippingBLOut = Children(i).Data
                                Case "QTYSHIPPINGBLIN" : z4010.QtyShippingBLIn = Children(i).Data
                                Case "QTYFOOTBED" : z4010.QtyFootbed = Children(i).Data
                                Case "QTYFOOTBEDA" : z4010.QtyFootbedA = Children(i).Data
                                Case "QTYFOOTBEDX" : z4010.QtyFootbedX = Children(i).Data
                                Case "QTYINNERBOX" : z4010.QtyInnerBox = Children(i).Data
                                Case "QTYINNERBOXA" : z4010.QtyInnerBoxA = Children(i).Data
                                Case "QTYINNERBOXX" : z4010.QtyInnerBoxX = Children(i).Data
                                Case "QTYINBOUND" : z4010.QtyInbound = Children(i).Data
                                Case "QTYINBOUNDA" : z4010.QtyInboundA = Children(i).Data
                                Case "QTYINBOUNDX" : z4010.QtyInboundX = Children(i).Data
                                Case "QTYSB2UI" : z4010.QtySB2UI = Children(i).Data
                                Case "QTYSB2UIA" : z4010.QtySB2UIA = Children(i).Data
                                Case "QTYSB2UIX" : z4010.QtySB2UIX = Children(i).Data
                                Case "QTYSB2UO" : z4010.QtySB2UO = Children(i).Data
                                Case "QTYSB2UOA" : z4010.QtySB2UOA = Children(i).Data
                                Case "QTYSB2UOX" : z4010.QtySB2UOX = Children(i).Data
                                Case "QTYSB2SI" : z4010.QtySB2SI = Children(i).Data
                                Case "QTYSB2SIA" : z4010.QtySB2SIA = Children(i).Data
                                Case "QTYSB2SIX" : z4010.QtySB2SIX = Children(i).Data
                                Case "QTYSB2SO" : z4010.QtySB2SO = Children(i).Data
                                Case "QTYSB2SOA" : z4010.QtySB2SOA = Children(i).Data
                                Case "QTYSB2SOX" : z4010.QtySB2SOX = Children(i).Data
                                Case "QTYSB2FI" : z4010.QtySB2FI = Children(i).Data
                                Case "QTYSB2FIA" : z4010.QtySB2FIA = Children(i).Data
                                Case "QTYSB2FIX" : z4010.QtySB2FIX = Children(i).Data
                                Case "QTYSB2FO" : z4010.QtySB2FO = Children(i).Data
                                Case "QTYSB2FOA" : z4010.QtySB2FOA = Children(i).Data
                                Case "QTYSB2FOX" : z4010.QtySB2FOX = Children(i).Data
                                Case "SEFACTORY" : z4010.seFactory = Children(i).Data
                                Case "CDFACTORY" : z4010.cdFactory = Children(i).Data
                                Case "SELINEPROD1" : z4010.seLineProd1 = Children(i).Data
                                Case "CDLINEPROD1" : z4010.cdLineProd1 = Children(i).Data
                                Case "SELINEPROD2" : z4010.seLineProd2 = Children(i).Data
                                Case "CDLINEPROD2" : z4010.cdLineProd2 = Children(i).Data
                                Case "SELINEPROD3" : z4010.seLineProd3 = Children(i).Data
                                Case "CDLINEPROD3" : z4010.cdLineProd3 = Children(i).Data
                                Case "DATEINSERT" : z4010.DateInsert = Children(i).Data
                                Case "INCHARGEINSERT" : z4010.InchargeInsert = Children(i).Data
                                Case "DATEUPDATE" : z4010.DateUpdate = Children(i).Data
                                Case "INCHARGEUPDATE" : z4010.InchargeUpdate = Children(i).Data
                                Case "REMARKORDER" : z4010.RemarkOrder = Children(i).Data
                                Case "REMARKCUSTOMER" : z4010.RemarkCustomer = Children(i).Data
                                Case "REMARKOTHER" : z4010.RemarkOther = Children(i).Data
                                Case "SESITE" : z4010.seSite = Children(i).Data
                                Case "CDSITE" : z4010.cdSite = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K4010_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K4010_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z4010 As T4010_AREA, Job As String, CheckClear As Boolean, JOBCARD As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K4010_MOVE = False

        Try
            If READ_PFK4010(JOBCARD) = True Then
                z4010 = D4010
                K4010_MOVE = True
            Else
                If CheckClear = True Then z4010 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4010")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "JOBCARD" : z4010.JobCard = Children(i).Code
                                Case "SEJOBSTATE" : z4010.seJobState = Children(i).Code
                                Case "CDJOBSTATE" : z4010.cdJobState = Children(i).Code
                                Case "SEALNO" : z4010.SealNo = Children(i).Code
                                Case "SLNOD" : z4010.SlNoD = Children(i).Code
                                Case "WORKORDER" : z4010.WorkOrder = Children(i).Code
                                Case "WORKORDERSEQ" : z4010.WorkOrderSeq = Children(i).Code
                                Case "SELJOB" : z4010.selJob = Children(i).Code
                                Case "SELPROD" : z4010.selProd = Children(i).Code
                                Case "DATESTART" : z4010.DateStart = Children(i).Code
                                Case "DATEFINISH" : z4010.DateFinish = Children(i).Code
                                Case "DATEPLANSTART" : z4010.DatePlanStart = Children(i).Code
                                Case "DATEPLANFINISH" : z4010.DatePlanFinish = Children(i).Code
                                Case "JOBCARDBEFORE" : z4010.JobCardBefore = Children(i).Code
                                Case "JOBCARDAFTER" : z4010.JobCardAfter = Children(i).Code
                                Case "CHECKPLAN" : z4010.CheckPlan = Children(i).Code
                                Case "CHECKUSE" : z4010.CheckUse = Children(i).Code
                                Case "MATERIALSTATUS" : z4010.MaterialStatus = Children(i).Code
                                Case "MOLDSTATUS" : z4010.MoldStatus = Children(i).Code
                                Case "LASTSTATUS" : z4010.LastStatus = Children(i).Code
                                Case "CUTTINGDIESTATUS" : z4010.CuttingDieStatus = Children(i).Code
                                Case "SOLESTATUS" : z4010.SoleStatus = Children(i).Code
                                Case "SOLENO" : z4010.SoleNo = Children(i).Code
                                Case "CUTTINGSTATUS" : z4010.CuttingStatus = Children(i).Code
                                Case "CUTTINGNO" : z4010.CuttingNo = Children(i).Code
                                Case "STITCHINGSTATUS" : z4010.StitchingStatus = Children(i).Code
                                Case "STITCHINGNO" : z4010.StitchingNo = Children(i).Code
                                Case "SUBPROCESSSTATUS" : z4010.SubprocessStatus = Children(i).Code
                                Case "SUBPROCESSNO" : z4010.SubprocessNo = Children(i).Code
                                Case "OUTSOURCESTATSUS" : z4010.OutsourceStatsus = Children(i).Code
                                Case "OUTSOURCENO" : z4010.OutsourceNo = Children(i).Code
                                Case "STOCKFITSTATSUS" : z4010.StockfitStatsus = Children(i).Code
                                Case "STOCKFITNO" : z4010.StockfitNo = Children(i).Code
                                Case "ASSEMBLYSTATUS" : z4010.AssemblyStatus = Children(i).Code
                                Case "ASSEMBLYNO" : z4010.AssemblyNo = Children(i).Code
                                Case "QTYORDER" : z4010.QtyOrder = Children(i).Code
                                Case "QTYPLAN" : z4010.QtyPlan = Children(i).Code
                                Case "QTYJOB" : z4010.QtyJob = Children(i).Code
                                Case "QTYJOBSOLE" : z4010.QtyJobSole = Children(i).Code
                                Case "QTYBATCHSOLE" : z4010.QtyBatchSole = Children(i).Code
                                Case "QTYSOLE" : z4010.QtySole = Children(i).Code
                                Case "QTYSOLEA" : z4010.QtySoleA = Children(i).Code
                                Case "QTYSOLEX" : z4010.QtySoleX = Children(i).Code
                                Case "QTYSOLEXP" : z4010.QtySoleXP = Children(i).Code
                                Case "QTYSOLEXR" : z4010.QtySoleXR = Children(i).Code
                                Case "QTYSOLEBLOUT" : z4010.QtySoleBLOut = Children(i).Code
                                Case "QTYSOLEBLIN" : z4010.QtySoleBLIn = Children(i).Code
                                Case "QTYJOBCUTTING" : z4010.QtyJobCutting = Children(i).Code
                                Case "QTYBATCHCUTTING" : z4010.QtyBatchCutting = Children(i).Code
                                Case "QTYCOM" : z4010.QtyCom = Children(i).Code
                                Case "QTYCUTTING" : z4010.QtyCutting = Children(i).Code
                                Case "QTYCUTTINGA" : z4010.QtyCuttingA = Children(i).Code
                                Case "QTYCUTTINGX" : z4010.QtyCuttingX = Children(i).Code
                                Case "QTYCUTTINGXP" : z4010.QtyCuttingXP = Children(i).Code
                                Case "QTYCUTTINGXR" : z4010.QtyCuttingXR = Children(i).Code
                                Case "QTYCUTTINGBLOUT" : z4010.QtyCuttingBLOut = Children(i).Code
                                Case "QTYCUTTINGBLIN" : z4010.QtyCuttingBLIn = Children(i).Code
                                Case "QTYJOBSTITCHING" : z4010.QtyJobStitching = Children(i).Code
                                Case "QTYBATCHSTITCHING" : z4010.QtyBatchStitching = Children(i).Code
                                Case "QTYSTITCHING" : z4010.QtyStitching = Children(i).Code
                                Case "QTYSTITCHINGA" : z4010.QtyStitchingA = Children(i).Code
                                Case "QTYSTITCHINGX" : z4010.QtyStitchingX = Children(i).Code
                                Case "QTYSTITCHINGXP" : z4010.QtyStitchingXP = Children(i).Code
                                Case "QTYSTITCHINGXR" : z4010.QtyStitchingXR = Children(i).Code
                                Case "QTYSTITCHINGBLOUT" : z4010.QtyStitchingBLOut = Children(i).Code
                                Case "QTYSTITCHINGBLIN" : z4010.QtyStitchingBLIn = Children(i).Code
                                Case "QTYJOBSTOCKFIT" : z4010.QtyJobStockfit = Children(i).Code
                                Case "QTYBATCHSTOCKFIT" : z4010.QtyBatchStockfit = Children(i).Code
                                Case "QTYSTOCKFIT" : z4010.QtyStockfit = Children(i).Code
                                Case "QTYSTOCKFITA" : z4010.QtyStockfitA = Children(i).Code
                                Case "QTYSTOCKFITX" : z4010.QtyStockfitX = Children(i).Code
                                Case "QTYSTOCKFITXP" : z4010.QtyStockfitXP = Children(i).Code
                                Case "QTYSTOCKFITXR" : z4010.QtyStockfitXR = Children(i).Code
                                Case "QTYSTOCKFITBLOUT" : z4010.QtyStockfitBLOut = Children(i).Code
                                Case "QTYSTOCKFITBLIN" : z4010.QtyStockfitBLIn = Children(i).Code
                                Case "QTYJOBASSEMBLY" : z4010.QtyJobAssembly = Children(i).Code
                                Case "QTYBATCHASSEMBLY" : z4010.QtyBatchAssembly = Children(i).Code
                                Case "QTYASSEMBLY" : z4010.QtyAssembly = Children(i).Code
                                Case "QTYASSEMBLYA" : z4010.QtyAssemblyA = Children(i).Code
                                Case "QTYASSEMBLYX" : z4010.QtyAssemblyX = Children(i).Code
                                Case "QTYASSEMBLYXP" : z4010.QtyAssemblyXP = Children(i).Code
                                Case "QTYASSEMBLYXR" : z4010.QtyAssemblyXR = Children(i).Code
                                Case "QTYASSEMBLYBLOUT" : z4010.QtyAssemblyBLOut = Children(i).Code
                                Case "QTYASSEMBLYBLIN" : z4010.QtyAssemblyBLIn = Children(i).Code
                                Case "QTYJOBPACKING" : z4010.QtyJobPacking = Children(i).Code
                                Case "QTYBATCHPACKING" : z4010.QtyBatchPacking = Children(i).Code
                                Case "QTYPACKING" : z4010.QtyPacking = Children(i).Code
                                Case "QTYPACKINGA" : z4010.QtyPackingA = Children(i).Code
                                Case "QTYPACKINGX" : z4010.QtyPackingX = Children(i).Code
                                Case "QTYPACKINGXP" : z4010.QtyPackingXP = Children(i).Code
                                Case "QTYPACKINGXR" : z4010.QtyPackingXR = Children(i).Code
                                Case "QTYPACKINGBLOUT" : z4010.QtyPackingBLOut = Children(i).Code
                                Case "QTYPACKINGBLIN" : z4010.QtyPackingBLIn = Children(i).Code
                                Case "QTYJOBSHIPPING" : z4010.QtyJobShipping = Children(i).Code
                                Case "QTYBATCHSHIPPING" : z4010.QtyBatchShipping = Children(i).Code
                                Case "QTYSHIPPING" : z4010.QtyShipping = Children(i).Code
                                Case "QTYSHIPPINGA" : z4010.QtyShippingA = Children(i).Code
                                Case "QTYSHIPPINGX" : z4010.QtyShippingX = Children(i).Code
                                Case "QTYSHIPPINGBLOUT" : z4010.QtyShippingBLOut = Children(i).Code
                                Case "QTYSHIPPINGBLIN" : z4010.QtyShippingBLIn = Children(i).Code
                                Case "QTYFOOTBED" : z4010.QtyFootbed = Children(i).Code
                                Case "QTYFOOTBEDA" : z4010.QtyFootbedA = Children(i).Code
                                Case "QTYFOOTBEDX" : z4010.QtyFootbedX = Children(i).Code
                                Case "QTYINNERBOX" : z4010.QtyInnerBox = Children(i).Code
                                Case "QTYINNERBOXA" : z4010.QtyInnerBoxA = Children(i).Code
                                Case "QTYINNERBOXX" : z4010.QtyInnerBoxX = Children(i).Code
                                Case "QTYINBOUND" : z4010.QtyInbound = Children(i).Code
                                Case "QTYINBOUNDA" : z4010.QtyInboundA = Children(i).Code
                                Case "QTYINBOUNDX" : z4010.QtyInboundX = Children(i).Code
                                Case "QTYSB2UI" : z4010.QtySB2UI = Children(i).Code
                                Case "QTYSB2UIA" : z4010.QtySB2UIA = Children(i).Code
                                Case "QTYSB2UIX" : z4010.QtySB2UIX = Children(i).Code
                                Case "QTYSB2UO" : z4010.QtySB2UO = Children(i).Code
                                Case "QTYSB2UOA" : z4010.QtySB2UOA = Children(i).Code
                                Case "QTYSB2UOX" : z4010.QtySB2UOX = Children(i).Code
                                Case "QTYSB2SI" : z4010.QtySB2SI = Children(i).Code
                                Case "QTYSB2SIA" : z4010.QtySB2SIA = Children(i).Code
                                Case "QTYSB2SIX" : z4010.QtySB2SIX = Children(i).Code
                                Case "QTYSB2SO" : z4010.QtySB2SO = Children(i).Code
                                Case "QTYSB2SOA" : z4010.QtySB2SOA = Children(i).Code
                                Case "QTYSB2SOX" : z4010.QtySB2SOX = Children(i).Code
                                Case "QTYSB2FI" : z4010.QtySB2FI = Children(i).Code
                                Case "QTYSB2FIA" : z4010.QtySB2FIA = Children(i).Code
                                Case "QTYSB2FIX" : z4010.QtySB2FIX = Children(i).Code
                                Case "QTYSB2FO" : z4010.QtySB2FO = Children(i).Code
                                Case "QTYSB2FOA" : z4010.QtySB2FOA = Children(i).Code
                                Case "QTYSB2FOX" : z4010.QtySB2FOX = Children(i).Code
                                Case "SEFACTORY" : z4010.seFactory = Children(i).Code
                                Case "CDFACTORY" : z4010.cdFactory = Children(i).Code
                                Case "SELINEPROD1" : z4010.seLineProd1 = Children(i).Code
                                Case "CDLINEPROD1" : z4010.cdLineProd1 = Children(i).Code
                                Case "SELINEPROD2" : z4010.seLineProd2 = Children(i).Code
                                Case "CDLINEPROD2" : z4010.cdLineProd2 = Children(i).Code
                                Case "SELINEPROD3" : z4010.seLineProd3 = Children(i).Code
                                Case "CDLINEPROD3" : z4010.cdLineProd3 = Children(i).Code
                                Case "DATEINSERT" : z4010.DateInsert = Children(i).Code
                                Case "INCHARGEINSERT" : z4010.InchargeInsert = Children(i).Code
                                Case "DATEUPDATE" : z4010.DateUpdate = Children(i).Code
                                Case "INCHARGEUPDATE" : z4010.InchargeUpdate = Children(i).Code
                                Case "REMARKORDER" : z4010.RemarkOrder = Children(i).Code
                                Case "REMARKCUSTOMER" : z4010.RemarkCustomer = Children(i).Code
                                Case "REMARKOTHER" : z4010.RemarkOther = Children(i).Code
                                Case "SESITE" : z4010.seSite = Children(i).Code
                                Case "CDSITE" : z4010.cdSite = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "JOBCARD" : z4010.JobCard = Children(i).Data
                                Case "SEJOBSTATE" : z4010.seJobState = Children(i).Data
                                Case "CDJOBSTATE" : z4010.cdJobState = Children(i).Data
                                Case "SEALNO" : z4010.SealNo = Children(i).Data
                                Case "SLNOD" : z4010.SlNoD = Children(i).Data
                                Case "WORKORDER" : z4010.WorkOrder = Children(i).Data
                                Case "WORKORDERSEQ" : z4010.WorkOrderSeq = Children(i).Data
                                Case "SELJOB" : z4010.selJob = Children(i).Data
                                Case "SELPROD" : z4010.selProd = Children(i).Data
                                Case "DATESTART" : z4010.DateStart = Children(i).Data
                                Case "DATEFINISH" : z4010.DateFinish = Children(i).Data
                                Case "DATEPLANSTART" : z4010.DatePlanStart = Children(i).Data
                                Case "DATEPLANFINISH" : z4010.DatePlanFinish = Children(i).Data
                                Case "JOBCARDBEFORE" : z4010.JobCardBefore = Children(i).Data
                                Case "JOBCARDAFTER" : z4010.JobCardAfter = Children(i).Data
                                Case "CHECKPLAN" : z4010.CheckPlan = Children(i).Data
                                Case "CHECKUSE" : z4010.CheckUse = Children(i).Data
                                Case "MATERIALSTATUS" : z4010.MaterialStatus = Children(i).Data
                                Case "MOLDSTATUS" : z4010.MoldStatus = Children(i).Data
                                Case "LASTSTATUS" : z4010.LastStatus = Children(i).Data
                                Case "CUTTINGDIESTATUS" : z4010.CuttingDieStatus = Children(i).Data
                                Case "SOLESTATUS" : z4010.SoleStatus = Children(i).Data
                                Case "SOLENO" : z4010.SoleNo = Children(i).Data
                                Case "CUTTINGSTATUS" : z4010.CuttingStatus = Children(i).Data
                                Case "CUTTINGNO" : z4010.CuttingNo = Children(i).Data
                                Case "STITCHINGSTATUS" : z4010.StitchingStatus = Children(i).Data
                                Case "STITCHINGNO" : z4010.StitchingNo = Children(i).Data
                                Case "SUBPROCESSSTATUS" : z4010.SubprocessStatus = Children(i).Data
                                Case "SUBPROCESSNO" : z4010.SubprocessNo = Children(i).Data
                                Case "OUTSOURCESTATSUS" : z4010.OutsourceStatsus = Children(i).Data
                                Case "OUTSOURCENO" : z4010.OutsourceNo = Children(i).Data
                                Case "STOCKFITSTATSUS" : z4010.StockfitStatsus = Children(i).Data
                                Case "STOCKFITNO" : z4010.StockfitNo = Children(i).Data
                                Case "ASSEMBLYSTATUS" : z4010.AssemblyStatus = Children(i).Data
                                Case "ASSEMBLYNO" : z4010.AssemblyNo = Children(i).Data
                                Case "QTYORDER" : z4010.QtyOrder = Children(i).Data
                                Case "QTYPLAN" : z4010.QtyPlan = Children(i).Data
                                Case "QTYJOB" : z4010.QtyJob = Children(i).Data
                                Case "QTYJOBSOLE" : z4010.QtyJobSole = Children(i).Data
                                Case "QTYBATCHSOLE" : z4010.QtyBatchSole = Children(i).Data
                                Case "QTYSOLE" : z4010.QtySole = Children(i).Data
                                Case "QTYSOLEA" : z4010.QtySoleA = Children(i).Data
                                Case "QTYSOLEX" : z4010.QtySoleX = Children(i).Data
                                Case "QTYSOLEXP" : z4010.QtySoleXP = Children(i).Data
                                Case "QTYSOLEXR" : z4010.QtySoleXR = Children(i).Data
                                Case "QTYSOLEBLOUT" : z4010.QtySoleBLOut = Children(i).Data
                                Case "QTYSOLEBLIN" : z4010.QtySoleBLIn = Children(i).Data
                                Case "QTYJOBCUTTING" : z4010.QtyJobCutting = Children(i).Data
                                Case "QTYBATCHCUTTING" : z4010.QtyBatchCutting = Children(i).Data
                                Case "QTYCOM" : z4010.QtyCom = Children(i).Data
                                Case "QTYCUTTING" : z4010.QtyCutting = Children(i).Data
                                Case "QTYCUTTINGA" : z4010.QtyCuttingA = Children(i).Data
                                Case "QTYCUTTINGX" : z4010.QtyCuttingX = Children(i).Data
                                Case "QTYCUTTINGXP" : z4010.QtyCuttingXP = Children(i).Data
                                Case "QTYCUTTINGXR" : z4010.QtyCuttingXR = Children(i).Data
                                Case "QTYCUTTINGBLOUT" : z4010.QtyCuttingBLOut = Children(i).Data
                                Case "QTYCUTTINGBLIN" : z4010.QtyCuttingBLIn = Children(i).Data
                                Case "QTYJOBSTITCHING" : z4010.QtyJobStitching = Children(i).Data
                                Case "QTYBATCHSTITCHING" : z4010.QtyBatchStitching = Children(i).Data
                                Case "QTYSTITCHING" : z4010.QtyStitching = Children(i).Data
                                Case "QTYSTITCHINGA" : z4010.QtyStitchingA = Children(i).Data
                                Case "QTYSTITCHINGX" : z4010.QtyStitchingX = Children(i).Data
                                Case "QTYSTITCHINGXP" : z4010.QtyStitchingXP = Children(i).Data
                                Case "QTYSTITCHINGXR" : z4010.QtyStitchingXR = Children(i).Data
                                Case "QTYSTITCHINGBLOUT" : z4010.QtyStitchingBLOut = Children(i).Data
                                Case "QTYSTITCHINGBLIN" : z4010.QtyStitchingBLIn = Children(i).Data
                                Case "QTYJOBSTOCKFIT" : z4010.QtyJobStockfit = Children(i).Data
                                Case "QTYBATCHSTOCKFIT" : z4010.QtyBatchStockfit = Children(i).Data
                                Case "QTYSTOCKFIT" : z4010.QtyStockfit = Children(i).Data
                                Case "QTYSTOCKFITA" : z4010.QtyStockfitA = Children(i).Data
                                Case "QTYSTOCKFITX" : z4010.QtyStockfitX = Children(i).Data
                                Case "QTYSTOCKFITXP" : z4010.QtyStockfitXP = Children(i).Data
                                Case "QTYSTOCKFITXR" : z4010.QtyStockfitXR = Children(i).Data
                                Case "QTYSTOCKFITBLOUT" : z4010.QtyStockfitBLOut = Children(i).Data
                                Case "QTYSTOCKFITBLIN" : z4010.QtyStockfitBLIn = Children(i).Data
                                Case "QTYJOBASSEMBLY" : z4010.QtyJobAssembly = Children(i).Data
                                Case "QTYBATCHASSEMBLY" : z4010.QtyBatchAssembly = Children(i).Data
                                Case "QTYASSEMBLY" : z4010.QtyAssembly = Children(i).Data
                                Case "QTYASSEMBLYA" : z4010.QtyAssemblyA = Children(i).Data
                                Case "QTYASSEMBLYX" : z4010.QtyAssemblyX = Children(i).Data
                                Case "QTYASSEMBLYXP" : z4010.QtyAssemblyXP = Children(i).Data
                                Case "QTYASSEMBLYXR" : z4010.QtyAssemblyXR = Children(i).Data
                                Case "QTYASSEMBLYBLOUT" : z4010.QtyAssemblyBLOut = Children(i).Data
                                Case "QTYASSEMBLYBLIN" : z4010.QtyAssemblyBLIn = Children(i).Data
                                Case "QTYJOBPACKING" : z4010.QtyJobPacking = Children(i).Data
                                Case "QTYBATCHPACKING" : z4010.QtyBatchPacking = Children(i).Data
                                Case "QTYPACKING" : z4010.QtyPacking = Children(i).Data
                                Case "QTYPACKINGA" : z4010.QtyPackingA = Children(i).Data
                                Case "QTYPACKINGX" : z4010.QtyPackingX = Children(i).Data
                                Case "QTYPACKINGXP" : z4010.QtyPackingXP = Children(i).Data
                                Case "QTYPACKINGXR" : z4010.QtyPackingXR = Children(i).Data
                                Case "QTYPACKINGBLOUT" : z4010.QtyPackingBLOut = Children(i).Data
                                Case "QTYPACKINGBLIN" : z4010.QtyPackingBLIn = Children(i).Data
                                Case "QTYJOBSHIPPING" : z4010.QtyJobShipping = Children(i).Data
                                Case "QTYBATCHSHIPPING" : z4010.QtyBatchShipping = Children(i).Data
                                Case "QTYSHIPPING" : z4010.QtyShipping = Children(i).Data
                                Case "QTYSHIPPINGA" : z4010.QtyShippingA = Children(i).Data
                                Case "QTYSHIPPINGX" : z4010.QtyShippingX = Children(i).Data
                                Case "QTYSHIPPINGBLOUT" : z4010.QtyShippingBLOut = Children(i).Data
                                Case "QTYSHIPPINGBLIN" : z4010.QtyShippingBLIn = Children(i).Data
                                Case "QTYFOOTBED" : z4010.QtyFootbed = Children(i).Data
                                Case "QTYFOOTBEDA" : z4010.QtyFootbedA = Children(i).Data
                                Case "QTYFOOTBEDX" : z4010.QtyFootbedX = Children(i).Data
                                Case "QTYINNERBOX" : z4010.QtyInnerBox = Children(i).Data
                                Case "QTYINNERBOXA" : z4010.QtyInnerBoxA = Children(i).Data
                                Case "QTYINNERBOXX" : z4010.QtyInnerBoxX = Children(i).Data
                                Case "QTYINBOUND" : z4010.QtyInbound = Children(i).Data
                                Case "QTYINBOUNDA" : z4010.QtyInboundA = Children(i).Data
                                Case "QTYINBOUNDX" : z4010.QtyInboundX = Children(i).Data
                                Case "QTYSB2UI" : z4010.QtySB2UI = Children(i).Data
                                Case "QTYSB2UIA" : z4010.QtySB2UIA = Children(i).Data
                                Case "QTYSB2UIX" : z4010.QtySB2UIX = Children(i).Data
                                Case "QTYSB2UO" : z4010.QtySB2UO = Children(i).Data
                                Case "QTYSB2UOA" : z4010.QtySB2UOA = Children(i).Data
                                Case "QTYSB2UOX" : z4010.QtySB2UOX = Children(i).Data
                                Case "QTYSB2SI" : z4010.QtySB2SI = Children(i).Data
                                Case "QTYSB2SIA" : z4010.QtySB2SIA = Children(i).Data
                                Case "QTYSB2SIX" : z4010.QtySB2SIX = Children(i).Data
                                Case "QTYSB2SO" : z4010.QtySB2SO = Children(i).Data
                                Case "QTYSB2SOA" : z4010.QtySB2SOA = Children(i).Data
                                Case "QTYSB2SOX" : z4010.QtySB2SOX = Children(i).Data
                                Case "QTYSB2FI" : z4010.QtySB2FI = Children(i).Data
                                Case "QTYSB2FIA" : z4010.QtySB2FIA = Children(i).Data
                                Case "QTYSB2FIX" : z4010.QtySB2FIX = Children(i).Data
                                Case "QTYSB2FO" : z4010.QtySB2FO = Children(i).Data
                                Case "QTYSB2FOA" : z4010.QtySB2FOA = Children(i).Data
                                Case "QTYSB2FOX" : z4010.QtySB2FOX = Children(i).Data
                                Case "SEFACTORY" : z4010.seFactory = Children(i).Data
                                Case "CDFACTORY" : z4010.cdFactory = Children(i).Data
                                Case "SELINEPROD1" : z4010.seLineProd1 = Children(i).Data
                                Case "CDLINEPROD1" : z4010.cdLineProd1 = Children(i).Data
                                Case "SELINEPROD2" : z4010.seLineProd2 = Children(i).Data
                                Case "CDLINEPROD2" : z4010.cdLineProd2 = Children(i).Data
                                Case "SELINEPROD3" : z4010.seLineProd3 = Children(i).Data
                                Case "CDLINEPROD3" : z4010.cdLineProd3 = Children(i).Data
                                Case "DATEINSERT" : z4010.DateInsert = Children(i).Data
                                Case "INCHARGEINSERT" : z4010.InchargeInsert = Children(i).Data
                                Case "DATEUPDATE" : z4010.DateUpdate = Children(i).Data
                                Case "INCHARGEUPDATE" : z4010.InchargeUpdate = Children(i).Data
                                Case "REMARKORDER" : z4010.RemarkOrder = Children(i).Data
                                Case "REMARKCUSTOMER" : z4010.RemarkCustomer = Children(i).Data
                                Case "REMARKOTHER" : z4010.RemarkOther = Children(i).Data
                                Case "SESITE" : z4010.seSite = Children(i).Data
                                Case "CDSITE" : z4010.cdSite = Children(i).Data
                            End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4010_MOVE",vbCritical)
End Try
End Function 
    
End Module 
