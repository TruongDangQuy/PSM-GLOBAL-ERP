'=========================================================================================================================================================
'   TABLE : (PFK7106)
'
'      WORKER : PSM GLOBAL ., LTD
'       WORK DATE : 2019 NEW
'       DEVELOPER    : MRNLV
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7106

    Structure T7106_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public ShoesCode As String  '			char(6)		*
        Public ShoesCodeBase As String  '			char(6)
        Public Customercode As String  '			char(6)
        Public CustSpecNo As String  '			nvarchar(50)
        Public ProductCode As String  '			nvarchar(50)
        Public Style As String  '			nvarchar(50)
        Public Article As String  '			nvarchar(50)
        Public Line As String  '			nvarchar(50)
        Public MCODE As String  '			nvarchar(50)
        Public ColorCode As String  '			nvarchar(5)
        Public MCODEName As String  '			nvarchar(50)
        Public ColorName As String  '			nvarchar(50)
        Public VerALL As String  '			nvarchar(50)
        Public VerSAM As String  '			nvarchar(5)
        Public VerBOM As String  '			nvarchar(50)
        Public VerCBD As String  '			nvarchar(50)
        Public VerROT As String  '			nvarchar(50)
        Public VerJOB As String  '			nvarchar(50)
        Public CustSpecNo1 As String  '			nvarchar(50)
        Public seProductType As String  '			char(3)
        Public cdProductType As String  '			char(3)
        Public seProductSize As String  '			char(3)
        Public cdProductSize As String  '			char(3)
        Public seSpecState As String  '			char(3)
        Public cdSpecState As String  '			char(3)
        Public Szno As String  '			char(2)
        Public SpeciticSize As String  '			nvarchar(4)
        Public seSeason As String  '			char(3)
        Public cdSeason As String  '			char(3)
        Public seGender As String  '			char(3)
        Public cdGender As String  '			char(3)
        Public LastCode As String  '			char(6)
        Public LastWidth As String  '			nvarchar(50)
        Public LastQty As Double  '			decimal
        Public QtyAverage As Double  '			decimal

        Public MoldCode As String  '			char(6)
        Public MoldSpec As String  '			nvarchar(50)
        Public MoldQty As Double  '			decimal
        Public CuttingDieCode As String  '			char(6)
        Public TexonCode As String  '			char(6)
        Public TexonColor As String  '			nvarchar(50)
        Public InsoleCode As String  '			char(6)
        Public InsoleColor As String  '			nvarchar(50)
        Public OutsoleCode As String  '			char(6)
        Public OutsoleColor As String  '			nvarchar(200)
        Public OutsoleColorCode As String  '			nvarchar(200)
        Public MidSoleCode As String  '			char(6)
        Public MidsoleColor As String  '			nvarchar(200)
        Public LogoCode As String  '			char(6)
        Public LogoColor As String  '			nvarchar(50)
        Public LogoColorCode As String  '			nvarchar(50)
        Public SizeRange As String  '			char(6)
        Public Note0 As String  '			nvarchar(50)
        Public Note1 As String  '			nvarchar(50)
        Public Note2 As String  '			nvarchar(50)
        Public Note3 As String  '			nvarchar(50)
        Public Note4 As String  '			nvarchar(50)
        Public Note5 As String  '			nvarchar(50)
        Public Note6 As String  '			nvarchar(50)
        Public Note7 As String  '			nvarchar(50)
        Public Note8 As String  '			nvarchar(50)
        Public Note9 As String  '			nvarchar(50)
        Public Note10 As String  '			nvarchar(50)
        Public DateExchangePrice As String  '			char(8)
        Public ExchangePrice As Double  '			decimal
        Public PriceUSD As Double  '			decimal
        Public PriceVND As Double  '			decimal
        Public DateLable1 As String  '			char(8)
        Public DateLable2 As String  '			char(8)
        Public DateLable3 As String  '			char(8)
        Public DateInsert As String  '			char(8)
        Public DateUpdate As String  '			char(8)
        Public InchargeInsert As String  '			char(8)
        Public InchargeUpdate As String  '			char(8)
        Public InchargeCBD_I As String  '			char(8)
        Public InchargeCBD_U As String  '			char(8)
        Public InchargeBOM_I As String  '			char(8)
        Public InchargeBOM_U As String  '			char(8)
        Public InchargeCON_I As String  '			char(8)
        Public InchargeCON_U As String  '			char(8)

        Public InchargeDesigner As String  '		char(8)
        Public InchargeStep1 As String  '			char(8)
        Public InchargeStep2 As String  '			char(8)
        Public InchargeStep3 As String  '			char(8)

        Public CheckParent As String  '			char(1)
        Public ShoesParent As String  '			char(6)
        Public CheckUse As String  '			char(1)
        Public TimeInsert As String  '			char(14)
        Public TimeUpdate As String  '			char(14)
        Public CheckComplete As String  '			char(1)
        Public InchargeComplete As String  '			char(8)
        Public DateComplete As String  '			char(8)
        Public InchargeCompleteUn As String  '			char(8)
        Public DateCompleteUn As String  '			char(8)
        Public TimeComplete As String  '			char(20)
        Public CheckBOM As String  '			char(1)
        Public InchargeBOMCom As String  '			char(8)
        Public DateBOMCom As String  '			char(8)
        Public InchargeBOMUn As String  '			char(8)
        Public DateBOMUn As String  '			char(8)
        Public TimeBOMCom As String  '			char(20)
        Public CheckCBD As String  '			char(1)
        Public InchargeCBDCom As String  '			char(8)
        Public DateCBDCom As String  '			char(8)
        Public InchargeCBDUn As String  '			char(8)
        Public DateCBDUn As String  '			char(8)
        Public TimeCBDCom As String  '			char(20)
        Public CheckCON As String  '			char(1)
        Public InchargeCONCom As String  '			char(8)
        Public DateCONCom As String  '			char(8)
        Public InchargeCONUn As String  '			char(8)
        Public DateCONUn As String  '			char(8)
        Public TimeCONCom As String  '			char(20)
        Public CheckFB As String  '			char(1)
        Public CheckSameMold As String  '			char(1)
        Public Remark As String  '			nvarchar(100)
        Public seSite As String  '			char(3)
        Public cdSite As String  '			char(3)
        '=========================================================================================================================================================
    End Structure

    Public D7106 As T7106_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK7106(SHOESCODE As String) As Boolean
        READ_PFK7106 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7106 "
            SQL = SQL & " WHERE K7106_ShoesCode		 = '" & ShoesCode & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7106_CLEAR() : GoTo SKIP_READ_PFK7106

            Call K7106_MOVE(rd)
            READ_PFK7106 = True

SKIP_READ_PFK7106:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7106", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK7106(SHOESCODE As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7106 "
            SQL = SQL & " WHERE K7106_ShoesCode		 = '" & ShoesCode & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK7106", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK7106(z7106 As T7106_AREA) As Boolean
        WRITE_PFK7106 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7106)

            SQL = " INSERT INTO PFK7106 "
            SQL = SQL & " ( "
            SQL = SQL & " K7106_ShoesCode,"
            SQL = SQL & " K7106_ShoesCodeBase,"
            SQL = SQL & " K7106_Customercode,"
            SQL = SQL & " K7106_CustSpecNo,"
            SQL = SQL & " K7106_ProductCode,"
            SQL = SQL & " K7106_Style,"
            SQL = SQL & " K7106_Article,"
            SQL = SQL & " K7106_Line,"
            SQL = SQL & " K7106_MCODE,"
            SQL = SQL & " K7106_ColorCode,"
            SQL = SQL & " K7106_MCODEName,"
            SQL = SQL & " K7106_ColorName,"
            SQL = SQL & " K7106_VerALL,"
            SQL = SQL & " K7106_VerSAM,"
            SQL = SQL & " K7106_VerBOM,"
            SQL = SQL & " K7106_VerCBD,"
            SQL = SQL & " K7106_VerROT,"
            SQL = SQL & " K7106_VerJOB,"
            SQL = SQL & " K7106_CustSpecNo1,"
            SQL = SQL & " K7106_seProductType,"
            SQL = SQL & " K7106_cdProductType,"
            SQL = SQL & " K7106_seProductSize,"
            SQL = SQL & " K7106_cdProductSize,"
            SQL = SQL & " K7106_seSpecState,"
            SQL = SQL & " K7106_cdSpecState,"
            SQL = SQL & " K7106_Szno,"
            SQL = SQL & " K7106_SpeciticSize,"
            SQL = SQL & " K7106_seSeason,"
            SQL = SQL & " K7106_cdSeason,"
            SQL = SQL & " K7106_seGender,"
            SQL = SQL & " K7106_cdGender,"
            SQL = SQL & " K7106_LastCode,"
            SQL = SQL & " K7106_LastWidth,"
            SQL = SQL & " K7106_LastQty,"
            SQL = SQL & " K7106_QtyAverage,"
            SQL = SQL & " K7106_MoldCode,"
            SQL = SQL & " K7106_MoldSpec,"
            SQL = SQL & " K7106_MoldQty,"
            SQL = SQL & " K7106_CuttingDieCode,"
            SQL = SQL & " K7106_TexonCode,"
            SQL = SQL & " K7106_TexonColor,"
            SQL = SQL & " K7106_InsoleCode,"
            SQL = SQL & " K7106_InsoleColor,"
            SQL = SQL & " K7106_OutsoleCode,"
            SQL = SQL & " K7106_OutsoleColor,"
            SQL = SQL & " K7106_OutsoleColorCode,"
            SQL = SQL & " K7106_MidSoleCode,"
            SQL = SQL & " K7106_MidsoleColor,"
            SQL = SQL & " K7106_LogoCode,"
            SQL = SQL & " K7106_LogoColor,"
            SQL = SQL & " K7106_LogoColorCode,"
            SQL = SQL & " K7106_SizeRange,"
            SQL = SQL & " K7106_Note0,"
            SQL = SQL & " K7106_Note1,"
            SQL = SQL & " K7106_Note2,"
            SQL = SQL & " K7106_Note3,"
            SQL = SQL & " K7106_Note4,"
            SQL = SQL & " K7106_Note5,"
            SQL = SQL & " K7106_Note6,"
            SQL = SQL & " K7106_Note7,"
            SQL = SQL & " K7106_Note8,"
            SQL = SQL & " K7106_Note9,"
            SQL = SQL & " K7106_Note10,"
            SQL = SQL & " K7106_DateExchangePrice,"
            SQL = SQL & " K7106_ExchangePrice,"
            SQL = SQL & " K7106_PriceUSD,"
            SQL = SQL & " K7106_PriceVND,"
            SQL = SQL & " K7106_DateLable1,"
            SQL = SQL & " K7106_DateLable2,"
            SQL = SQL & " K7106_DateLable3,"
            SQL = SQL & " K7106_DateInsert,"
            SQL = SQL & " K7106_DateUpdate,"
            SQL = SQL & " K7106_InchargeInsert,"
            SQL = SQL & " K7106_InchargeUpdate,"
            SQL = SQL & " K7106_InchargeCBD_I,"
            SQL = SQL & " K7106_InchargeCBD_U,"
            SQL = SQL & " K7106_InchargeBOM_I,"
            SQL = SQL & " K7106_InchargeBOM_U,"
            SQL = SQL & " K7106_InchargeCON_I,"
            SQL = SQL & " K7106_InchargeCON_U,"


            '   InchargeDesigner
            '   InchargeStep1
            '   InchargeStep2
            '   InchargeStep3






            SQL = SQL & " K7106_InchargeDesigner,"
            SQL = SQL & " K7106_InchargeStep1,"
            SQL = SQL & " K7106_InchargeStep2,"
            SQL = SQL & " K7106_InchargeStep3,"

            SQL = SQL & " K7106_CheckParent,"
            SQL = SQL & " K7106_ShoesParent,"
            SQL = SQL & " K7106_CheckUse,"
            SQL = SQL & " K7106_TimeInsert,"
            SQL = SQL & " K7106_TimeUpdate,"
            SQL = SQL & " K7106_CheckComplete,"
            SQL = SQL & " K7106_InchargeComplete,"
            SQL = SQL & " K7106_DateComplete,"
            SQL = SQL & " K7106_InchargeCompleteUn,"
            SQL = SQL & " K7106_DateCompleteUn,"
            SQL = SQL & " K7106_TimeComplete,"
            SQL = SQL & " K7106_CheckBOM,"
            SQL = SQL & " K7106_InchargeBOMCom,"
            SQL = SQL & " K7106_DateBOMCom,"
            SQL = SQL & " K7106_InchargeBOMUn,"
            SQL = SQL & " K7106_DateBOMUn,"
            SQL = SQL & " K7106_TimeBOMCom,"
            SQL = SQL & " K7106_CheckCBD,"
            SQL = SQL & " K7106_InchargeCBDCom,"
            SQL = SQL & " K7106_DateCBDCom,"
            SQL = SQL & " K7106_InchargeCBDUn,"
            SQL = SQL & " K7106_DateCBDUn,"
            SQL = SQL & " K7106_TimeCBDCom,"
            SQL = SQL & " K7106_CheckCON,"
            SQL = SQL & " K7106_InchargeCONCom,"
            SQL = SQL & " K7106_DateCONCom,"
            SQL = SQL & " K7106_InchargeCONUn,"
            SQL = SQL & " K7106_DateCONUn,"
            SQL = SQL & " K7106_TimeCONCom,"
            SQL = SQL & " K7106_CheckFB,"
            SQL = SQL & " K7106_CheckSameMold,"
            SQL = SQL & " K7106_Remark,"
            SQL = SQL & " K7106_seSite,"
            SQL = SQL & " K7106_cdSite "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z7106.ShoesCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.ShoesCodeBase) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.Customercode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.CustSpecNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.ProductCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.Style) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.Article) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.Line) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.MCODE) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.ColorCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.MCODEName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.ColorName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.VerALL) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.VerSAM) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.VerBOM) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.VerCBD) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.VerROT) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.VerJOB) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.CustSpecNo1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.seProductType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.cdProductType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.seProductSize) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.cdProductSize) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.seSpecState) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.cdSpecState) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.Szno) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.SpeciticSize) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.seSeason) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.cdSeason) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.seGender) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.cdGender) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.LastCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.LastWidth) & "', "
            SQL = SQL & "   " & FormatSQL(z7106.LastQty) & ", "
            SQL = SQL & "   " & FormatSQL(z7106.QtyAverage) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7106.MoldCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.MoldSpec) & "', "
            SQL = SQL & "   " & FormatSQL(z7106.MoldQty) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7106.CuttingDieCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.TexonCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.TexonColor) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.InsoleCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.InsoleColor) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.OutsoleCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.OutsoleColor) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.OutsoleColorCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.MidSoleCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.MidsoleColor) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.LogoCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.LogoColor) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.LogoColorCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.SizeRange) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.Note0) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.Note1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.Note2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.Note3) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.Note4) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.Note5) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.Note6) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.Note7) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.Note8) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.Note9) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.Note10) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.DateExchangePrice) & "', "
            SQL = SQL & "   " & FormatSQL(z7106.ExchangePrice) & ", "
            SQL = SQL & "   " & FormatSQL(z7106.PriceUSD) & ", "
            SQL = SQL & "   " & FormatSQL(z7106.PriceVND) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7106.DateLable1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.DateLable2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.DateLable3) & "', "
            SQL = SQL & "  N'" & FormatSQL(PUB.DAT) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.DateUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(PUB.SAW) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.InchargeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.InchargeCBD_I) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.InchargeCBD_U) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.InchargeBOM_I) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.InchargeBOM_U) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.InchargeCON_I) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.InchargeCON_U) & "', "

            SQL = SQL & "  N'" & FormatSQL(z7106.InchargeDesigner) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.InchargeStep1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.InchargeStep2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.InchargeStep3) & "', "

            SQL = SQL & "  N'" & FormatSQL(z7106.CheckParent) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.ShoesParent) & "', "
            SQL = SQL & "  N'1', "
            SQL = SQL & "  N'" & FormatSQL(PUB.TIME) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.TimeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.CheckComplete) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.InchargeComplete) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.DateComplete) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.InchargeCompleteUn) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.DateCompleteUn) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.TimeComplete) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.CheckBOM) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.InchargeBOMCom) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.DateBOMCom) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.InchargeBOMUn) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.DateBOMUn) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.TimeBOMCom) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.CheckCBD) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.InchargeCBDCom) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.DateCBDCom) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.InchargeCBDUn) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.DateCBDUn) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.TimeCBDCom) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.CheckCON) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.InchargeCONCom) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.DateCONCom) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.InchargeCONUn) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.DateCONUn) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.TimeCONCom) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.CheckFB) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.CheckSameMold) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.Remark) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.seSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7106.cdSite) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK7106 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK7106", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK7106(z7106 As T7106_AREA) As Boolean
        REWRITE_PFK7106 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7106)

            SQL = " UPDATE PFK7106 SET "
            SQL = SQL & "    K7106_ShoesCodeBase      = N'" & FormatSQL(z7106.ShoesCodeBase) & "', "
            SQL = SQL & "    K7106_Customercode      = N'" & FormatSQL(z7106.Customercode) & "', "
            SQL = SQL & "    K7106_CustSpecNo      = N'" & FormatSQL(z7106.CustSpecNo) & "', "
            SQL = SQL & "    K7106_ProductCode      = N'" & FormatSQL(z7106.ProductCode) & "', "
            SQL = SQL & "    K7106_Style      = N'" & FormatSQL(z7106.Style) & "', "
            SQL = SQL & "    K7106_Article      = N'" & FormatSQL(z7106.Article) & "', "
            SQL = SQL & "    K7106_Line      = N'" & FormatSQL(z7106.Line) & "', "
            SQL = SQL & "    K7106_MCODE      = N'" & FormatSQL(z7106.MCODE) & "', "
            SQL = SQL & "    K7106_ColorCode      = N'" & FormatSQL(z7106.ColorCode) & "', "
            SQL = SQL & "    K7106_MCODEName      = N'" & FormatSQL(z7106.MCODEName) & "', "
            SQL = SQL & "    K7106_ColorName      = N'" & FormatSQL(z7106.ColorName) & "', "
            SQL = SQL & "    K7106_VerALL      = N'" & FormatSQL(z7106.VerALL) & "', "
            SQL = SQL & "    K7106_VerSAM      = N'" & FormatSQL(z7106.VerSAM) & "', "
            SQL = SQL & "    K7106_VerBOM      = N'" & FormatSQL(z7106.VerBOM) & "', "
            SQL = SQL & "    K7106_VerCBD      = N'" & FormatSQL(z7106.VerCBD) & "', "
            SQL = SQL & "    K7106_VerROT      = N'" & FormatSQL(z7106.VerROT) & "', "
            SQL = SQL & "    K7106_VerJOB      = N'" & FormatSQL(z7106.VerJOB) & "', "
            SQL = SQL & "    K7106_CustSpecNo1      = N'" & FormatSQL(z7106.CustSpecNo1) & "', "
            SQL = SQL & "    K7106_seProductType      = N'" & FormatSQL(z7106.seProductType) & "', "
            SQL = SQL & "    K7106_cdProductType      = N'" & FormatSQL(z7106.cdProductType) & "', "
            SQL = SQL & "    K7106_seProductSize      = N'" & FormatSQL(z7106.seProductSize) & "', "
            SQL = SQL & "    K7106_cdProductSize      = N'" & FormatSQL(z7106.cdProductSize) & "', "
            SQL = SQL & "    K7106_seSpecState      = N'" & FormatSQL(z7106.seSpecState) & "', "
            SQL = SQL & "    K7106_cdSpecState      = N'" & FormatSQL(z7106.cdSpecState) & "', "
            SQL = SQL & "    K7106_Szno      = N'" & FormatSQL(z7106.Szno) & "', "
            SQL = SQL & "    K7106_SpeciticSize      = N'" & FormatSQL(z7106.SpeciticSize) & "', "
            SQL = SQL & "    K7106_seSeason      = N'" & FormatSQL(z7106.seSeason) & "', "
            SQL = SQL & "    K7106_cdSeason      = N'" & FormatSQL(z7106.cdSeason) & "', "
            SQL = SQL & "    K7106_seGender      = N'" & FormatSQL(z7106.seGender) & "', "
            SQL = SQL & "    K7106_cdGender      = N'" & FormatSQL(z7106.cdGender) & "', "
            SQL = SQL & "    K7106_LastCode      = N'" & FormatSQL(z7106.LastCode) & "', "
            SQL = SQL & "    K7106_LastWidth      = N'" & FormatSQL(z7106.LastWidth) & "', "
            SQL = SQL & "    K7106_LastQty      =  " & FormatSQL(z7106.LastQty) & ", "
            SQL = SQL & "    K7106_QtyAverage      =  " & FormatSQL(z7106.QtyAverage) & ", "
            SQL = SQL & "    K7106_MoldCode      = N'" & FormatSQL(z7106.MoldCode) & "', "
            SQL = SQL & "    K7106_MoldSpec      = N'" & FormatSQL(z7106.MoldSpec) & "', "
            SQL = SQL & "    K7106_MoldQty      =  " & FormatSQL(z7106.MoldQty) & ", "
            SQL = SQL & "    K7106_CuttingDieCode      = N'" & FormatSQL(z7106.CuttingDieCode) & "', "
            SQL = SQL & "    K7106_TexonCode      = N'" & FormatSQL(z7106.TexonCode) & "', "
            SQL = SQL & "    K7106_TexonColor      = N'" & FormatSQL(z7106.TexonColor) & "', "
            SQL = SQL & "    K7106_InsoleCode      = N'" & FormatSQL(z7106.InsoleCode) & "', "
            SQL = SQL & "    K7106_InsoleColor      = N'" & FormatSQL(z7106.InsoleColor) & "', "
            SQL = SQL & "    K7106_OutsoleCode      = N'" & FormatSQL(z7106.OutsoleCode) & "', "
            SQL = SQL & "    K7106_OutsoleColor      = N'" & FormatSQL(z7106.OutsoleColor) & "', "
            SQL = SQL & "    K7106_OutsoleColorCode      = N'" & FormatSQL(z7106.OutsoleColorCode) & "', "
            SQL = SQL & "    K7106_MidSoleCode      = N'" & FormatSQL(z7106.MidSoleCode) & "', "
            SQL = SQL & "    K7106_MidsoleColor      = N'" & FormatSQL(z7106.MidsoleColor) & "', "
            SQL = SQL & "    K7106_LogoCode      = N'" & FormatSQL(z7106.LogoCode) & "', "
            SQL = SQL & "    K7106_LogoColor      = N'" & FormatSQL(z7106.LogoColor) & "', "
            SQL = SQL & "    K7106_LogoColorCode      = N'" & FormatSQL(z7106.LogoColorCode) & "', "
            SQL = SQL & "    K7106_SizeRange      = N'" & FormatSQL(z7106.SizeRange) & "', "
            SQL = SQL & "    K7106_Note0      = N'" & FormatSQL(z7106.Note0) & "', "
            SQL = SQL & "    K7106_Note1      = N'" & FormatSQL(z7106.Note1) & "', "
            SQL = SQL & "    K7106_Note2      = N'" & FormatSQL(z7106.Note2) & "', "
            SQL = SQL & "    K7106_Note3      = N'" & FormatSQL(z7106.Note3) & "', "
            SQL = SQL & "    K7106_Note4      = N'" & FormatSQL(z7106.Note4) & "', "
            SQL = SQL & "    K7106_Note5      = N'" & FormatSQL(z7106.Note5) & "', "
            SQL = SQL & "    K7106_Note6      = N'" & FormatSQL(z7106.Note6) & "', "
            SQL = SQL & "    K7106_Note7      = N'" & FormatSQL(z7106.Note7) & "', "
            SQL = SQL & "    K7106_Note8      = N'" & FormatSQL(z7106.Note8) & "', "
            SQL = SQL & "    K7106_Note9      = N'" & FormatSQL(z7106.Note9) & "', "
            SQL = SQL & "    K7106_Note10      = N'" & FormatSQL(z7106.Note10) & "', "
            SQL = SQL & "    K7106_DateExchangePrice      = N'" & FormatSQL(z7106.DateExchangePrice) & "', "
            SQL = SQL & "    K7106_ExchangePrice      =  " & FormatSQL(z7106.ExchangePrice) & ", "
            SQL = SQL & "    K7106_PriceUSD      =  " & FormatSQL(z7106.PriceUSD) & ", "
            SQL = SQL & "    K7106_PriceVND      =  " & FormatSQL(z7106.PriceVND) & ", "
            SQL = SQL & "    K7106_DateLable1      = N'" & FormatSQL(z7106.DateLable1) & "', "
            SQL = SQL & "    K7106_DateLable2      = N'" & FormatSQL(z7106.DateLable2) & "', "
            SQL = SQL & "    K7106_DateLable3      = N'" & FormatSQL(z7106.DateLable3) & "', "
            SQL = SQL & "    K7106_DateInsert      = N'" & FormatSQL(z7106.DateInsert) & "', "
            SQL = SQL & "    K7106_DateUpdate      = N'" & FormatSQL(PUB.DAT) & "', "
            SQL = SQL & "    K7106_InchargeInsert      = N'" & FormatSQL(z7106.InchargeInsert) & "', "
            SQL = SQL & "    K7106_InchargeUpdate      = N'" & FormatSQL(PUB.SAW) & "', "
            SQL = SQL & "    K7106_InchargeCBD_I      = N'" & FormatSQL(z7106.InchargeCBD_I) & "', "
            SQL = SQL & "    K7106_InchargeCBD_U      = N'" & FormatSQL(z7106.InchargeCBD_U) & "', "
            SQL = SQL & "    K7106_InchargeBOM_I      = N'" & FormatSQL(z7106.InchargeBOM_I) & "', "
            SQL = SQL & "    K7106_InchargeBOM_U      = N'" & FormatSQL(z7106.InchargeBOM_U) & "', "
            SQL = SQL & "    K7106_InchargeCON_I      = N'" & FormatSQL(z7106.InchargeCON_I) & "', "
            SQL = SQL & "    K7106_InchargeCON_U      = N'" & FormatSQL(z7106.InchargeCON_U) & "', "

            SQL = SQL & "    K7106_InchargeDesigner   = N'" & FormatSQL(z7106.InchargeDesigner) & "', "
            SQL = SQL & "    K7106_InchargeStep1      = N'" & FormatSQL(z7106.InchargeStep1) & "', "
            SQL = SQL & "    K7106_InchargeStep2      = N'" & FormatSQL(z7106.InchargeStep2) & "', "
            SQL = SQL & "    K7106_InchargeStep3      = N'" & FormatSQL(z7106.InchargeStep3) & "', "

            SQL = SQL & "    K7106_CheckParent      = N'" & FormatSQL(z7106.CheckParent) & "', "
            SQL = SQL & "    K7106_ShoesParent      = N'" & FormatSQL(z7106.ShoesParent) & "', "
            SQL = SQL & "    K7106_CheckUse      = N'" & FormatSQL(z7106.CheckUse) & "', "
            SQL = SQL & "    K7106_TimeInsert      = N'" & FormatSQL(z7106.TimeInsert) & "', "
            SQL = SQL & "    K7106_TimeUpdate      = N'" & FormatSQL(PUB.TIME) & "', "
            SQL = SQL & "    K7106_CheckComplete      = N'" & FormatSQL(z7106.CheckComplete) & "', "
            SQL = SQL & "    K7106_InchargeComplete      = N'" & FormatSQL(z7106.InchargeComplete) & "', "
            SQL = SQL & "    K7106_DateComplete      = N'" & FormatSQL(z7106.DateComplete) & "', "
            SQL = SQL & "    K7106_InchargeCompleteUn      = N'" & FormatSQL(z7106.InchargeCompleteUn) & "', "
            SQL = SQL & "    K7106_DateCompleteUn      = N'" & FormatSQL(z7106.DateCompleteUn) & "', "
            SQL = SQL & "    K7106_TimeComplete      = N'" & FormatSQL(z7106.TimeComplete) & "', "
            SQL = SQL & "    K7106_CheckBOM      = N'" & FormatSQL(z7106.CheckBOM) & "', "
            SQL = SQL & "    K7106_InchargeBOMCom      = N'" & FormatSQL(z7106.InchargeBOMCom) & "', "
            SQL = SQL & "    K7106_DateBOMCom      = N'" & FormatSQL(z7106.DateBOMCom) & "', "
            SQL = SQL & "    K7106_InchargeBOMUn      = N'" & FormatSQL(z7106.InchargeBOMUn) & "', "
            SQL = SQL & "    K7106_DateBOMUn      = N'" & FormatSQL(z7106.DateBOMUn) & "', "
            SQL = SQL & "    K7106_TimeBOMCom      = N'" & FormatSQL(z7106.TimeBOMCom) & "', "
            SQL = SQL & "    K7106_CheckCBD      = N'" & FormatSQL(z7106.CheckCBD) & "', "
            SQL = SQL & "    K7106_InchargeCBDCom      = N'" & FormatSQL(z7106.InchargeCBDCom) & "', "
            SQL = SQL & "    K7106_DateCBDCom      = N'" & FormatSQL(z7106.DateCBDCom) & "', "
            SQL = SQL & "    K7106_InchargeCBDUn      = N'" & FormatSQL(z7106.InchargeCBDUn) & "', "
            SQL = SQL & "    K7106_DateCBDUn      = N'" & FormatSQL(z7106.DateCBDUn) & "', "
            SQL = SQL & "    K7106_TimeCBDCom      = N'" & FormatSQL(z7106.TimeCBDCom) & "', "
            SQL = SQL & "    K7106_CheckCON      = N'" & FormatSQL(z7106.CheckCON) & "', "
            SQL = SQL & "    K7106_InchargeCONCom      = N'" & FormatSQL(z7106.InchargeCONCom) & "', "
            SQL = SQL & "    K7106_DateCONCom      = N'" & FormatSQL(z7106.DateCONCom) & "', "
            SQL = SQL & "    K7106_InchargeCONUn      = N'" & FormatSQL(z7106.InchargeCONUn) & "', "
            SQL = SQL & "    K7106_DateCONUn      = N'" & FormatSQL(z7106.DateCONUn) & "', "
            SQL = SQL & "    K7106_TimeCONCom      = N'" & FormatSQL(z7106.TimeCONCom) & "', "
            SQL = SQL & "    K7106_CheckFB      = N'" & FormatSQL(z7106.CheckFB) & "', "
            SQL = SQL & "    K7106_CheckSameMold      = N'" & FormatSQL(z7106.CheckSameMold) & "', "
            SQL = SQL & "    K7106_Remark      = N'" & FormatSQL(z7106.Remark) & "', "
            SQL = SQL & "    K7106_seSite      = N'" & FormatSQL(z7106.seSite) & "', "
            SQL = SQL & "    K7106_cdSite      = N'" & FormatSQL(z7106.cdSite) & "'  "
            SQL = SQL & " WHERE K7106_ShoesCode		 = '" & z7106.ShoesCode & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()


            REWRITE_PFK7106 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK7106", vbCritical)

        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK7106(z7106 As T7106_AREA) As Boolean
        DELETE_PFK7106 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7106)

            SQL = " DELETE FROM PFK7106  "
            SQL = SQL & " WHERE K7106_ShoesCode		 = '" & z7106.ShoesCode & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK7106 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK7106", vbCritical)
        Finally
            Call GetFullInformation("PFK7106", "D", SQL)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D7106_CLEAR()
        Try

            D7106.ShoesCode = ""
            D7106.ShoesCodeBase = ""
            D7106.Customercode = ""
            D7106.CustSpecNo = ""
            D7106.ProductCode = ""
            D7106.Style = ""
            D7106.Article = ""
            D7106.Line = ""
            D7106.MCODE = ""
            D7106.ColorCode = ""
            D7106.MCODEName = ""
            D7106.ColorName = ""
            D7106.VerALL = ""
            D7106.VerSAM = ""
            D7106.VerBOM = ""
            D7106.VerCBD = ""
            D7106.VerROT = ""
            D7106.VerJOB = ""
            D7106.CustSpecNo1 = ""
            D7106.seProductType = ""
            D7106.cdProductType = ""
            D7106.seProductSize = ""
            D7106.cdProductSize = ""
            D7106.seSpecState = ""
            D7106.cdSpecState = ""
            D7106.Szno = ""
            D7106.SpeciticSize = ""
            D7106.seSeason = ""
            D7106.cdSeason = ""
            D7106.seGender = ""
            D7106.cdGender = ""
            D7106.LastCode = ""
            D7106.LastWidth = ""
            D7106.LastQty = 0
            D7106.QtyAverage = 0
            D7106.MoldCode = ""
            D7106.MoldSpec = ""
            D7106.MoldQty = 0
            D7106.CuttingDieCode = ""
            D7106.TexonCode = ""
            D7106.TexonColor = ""
            D7106.InsoleCode = ""
            D7106.InsoleColor = ""
            D7106.OutsoleCode = ""
            D7106.OutsoleColor = ""
            D7106.OutsoleColorCode = ""
            D7106.MidSoleCode = ""
            D7106.MidsoleColor = ""
            D7106.LogoCode = ""
            D7106.LogoColor = ""
            D7106.LogoColorCode = ""
            D7106.SizeRange = ""
            D7106.Note0 = ""
            D7106.Note1 = ""
            D7106.Note2 = ""
            D7106.Note3 = ""
            D7106.Note4 = ""
            D7106.Note5 = ""
            D7106.Note6 = ""
            D7106.Note7 = ""
            D7106.Note8 = ""
            D7106.Note9 = ""
            D7106.Note10 = ""
            D7106.DateExchangePrice = ""
            D7106.ExchangePrice = 0
            D7106.PriceUSD = 0
            D7106.PriceVND = 0
            D7106.DateLable1 = ""
            D7106.DateLable2 = ""
            D7106.DateLable3 = ""
            D7106.DateInsert = ""
            D7106.DateUpdate = ""
            D7106.InchargeInsert = ""
            D7106.InchargeUpdate = ""
            D7106.InchargeCBD_I = ""
            D7106.InchargeCBD_U = ""
            D7106.InchargeBOM_I = ""
            D7106.InchargeBOM_U = ""
            D7106.InchargeCON_I = ""
            D7106.InchargeCON_U = ""

            D7106.InchargeDesigner = ""
            D7106.InchargeStep1 = ""
            D7106.InchargeStep2 = ""
            D7106.InchargeStep3 = ""

            D7106.CheckParent = ""
            D7106.ShoesParent = ""
            D7106.CheckUse = ""
            D7106.TimeInsert = ""
            D7106.TimeUpdate = ""
            D7106.CheckComplete = ""
            D7106.InchargeComplete = ""
            D7106.DateComplete = ""
            D7106.InchargeCompleteUn = ""
            D7106.DateCompleteUn = ""
            D7106.TimeComplete = ""
            D7106.CheckBOM = ""
            D7106.InchargeBOMCom = ""
            D7106.DateBOMCom = ""
            D7106.InchargeBOMUn = ""
            D7106.DateBOMUn = ""
            D7106.TimeBOMCom = ""
            D7106.CheckCBD = ""
            D7106.InchargeCBDCom = ""
            D7106.DateCBDCom = ""
            D7106.InchargeCBDUn = ""
            D7106.DateCBDUn = ""
            D7106.TimeCBDCom = ""
            D7106.CheckCON = ""
            D7106.InchargeCONCom = ""
            D7106.DateCONCom = ""
            D7106.InchargeCONUn = ""
            D7106.DateCONUn = ""
            D7106.TimeCONCom = ""
            D7106.CheckFB = ""
            D7106.CheckSameMold = ""
            D7106.Remark = ""
            D7106.seSite = ""
            D7106.cdSite = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D7106_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x7106 As T7106_AREA)
        Try

            x7106.ShoesCode = trim$(x7106.ShoesCode)
            x7106.ShoesCodeBase = trim$(x7106.ShoesCodeBase)
            x7106.Customercode = trim$(x7106.Customercode)
            x7106.CustSpecNo = trim$(x7106.CustSpecNo)
            x7106.ProductCode = trim$(x7106.ProductCode)
            x7106.Style = trim$(x7106.Style)
            x7106.Article = trim$(x7106.Article)
            x7106.Line = trim$(x7106.Line)
            x7106.MCODE = trim$(x7106.MCODE)
            x7106.ColorCode = trim$(x7106.ColorCode)
            x7106.MCODEName = trim$(x7106.MCODEName)
            x7106.ColorName = trim$(x7106.ColorName)
            x7106.VerALL = trim$(x7106.VerALL)
            x7106.VerSAM = trim$(x7106.VerSAM)
            x7106.VerBOM = trim$(x7106.VerBOM)
            x7106.VerCBD = trim$(x7106.VerCBD)
            x7106.VerROT = trim$(x7106.VerROT)
            x7106.VerJOB = trim$(x7106.VerJOB)
            x7106.CustSpecNo1 = trim$(x7106.CustSpecNo1)
            x7106.seProductType = trim$(x7106.seProductType)
            x7106.cdProductType = trim$(x7106.cdProductType)
            x7106.seProductSize = trim$(x7106.seProductSize)
            x7106.cdProductSize = trim$(x7106.cdProductSize)
            x7106.seSpecState = trim$(x7106.seSpecState)
            x7106.cdSpecState = trim$(x7106.cdSpecState)
            x7106.Szno = trim$(x7106.Szno)
            x7106.SpeciticSize = trim$(x7106.SpeciticSize)
            x7106.seSeason = trim$(x7106.seSeason)
            x7106.cdSeason = trim$(x7106.cdSeason)
            x7106.seGender = trim$(x7106.seGender)
            x7106.cdGender = trim$(x7106.cdGender)
            x7106.LastCode = trim$(x7106.LastCode)
            x7106.LastWidth = trim$(x7106.LastWidth)
            x7106.LastQty = Trim$(x7106.LastQty)
            x7106.QtyAverage = Trim$(x7106.QtyAverage)
            x7106.MoldCode = trim$(x7106.MoldCode)
            x7106.MoldSpec = trim$(x7106.MoldSpec)
            x7106.MoldQty = trim$(x7106.MoldQty)
            x7106.CuttingDieCode = trim$(x7106.CuttingDieCode)
            x7106.TexonCode = trim$(x7106.TexonCode)
            x7106.TexonColor = trim$(x7106.TexonColor)
            x7106.InsoleCode = trim$(x7106.InsoleCode)
            x7106.InsoleColor = trim$(x7106.InsoleColor)
            x7106.OutsoleCode = trim$(x7106.OutsoleCode)
            x7106.OutsoleColor = trim$(x7106.OutsoleColor)
            x7106.OutsoleColorCode = trim$(x7106.OutsoleColorCode)
            x7106.MidSoleCode = trim$(x7106.MidSoleCode)
            x7106.MidsoleColor = trim$(x7106.MidsoleColor)
            x7106.LogoCode = trim$(x7106.LogoCode)
            x7106.LogoColor = trim$(x7106.LogoColor)
            x7106.LogoColorCode = trim$(x7106.LogoColorCode)
            x7106.SizeRange = trim$(x7106.SizeRange)
            x7106.Note0 = trim$(x7106.Note0)
            x7106.Note1 = trim$(x7106.Note1)
            x7106.Note2 = trim$(x7106.Note2)
            x7106.Note3 = trim$(x7106.Note3)
            x7106.Note4 = trim$(x7106.Note4)
            x7106.Note5 = trim$(x7106.Note5)
            x7106.Note6 = trim$(x7106.Note6)
            x7106.Note7 = trim$(x7106.Note7)
            x7106.Note8 = trim$(x7106.Note8)
            x7106.Note9 = trim$(x7106.Note9)
            x7106.Note10 = trim$(x7106.Note10)
            x7106.DateExchangePrice = trim$(x7106.DateExchangePrice)
            x7106.ExchangePrice = trim$(x7106.ExchangePrice)
            x7106.PriceUSD = trim$(x7106.PriceUSD)
            x7106.PriceVND = trim$(x7106.PriceVND)
            x7106.DateLable1 = trim$(x7106.DateLable1)
            x7106.DateLable2 = trim$(x7106.DateLable2)
            x7106.DateLable3 = trim$(x7106.DateLable3)
            x7106.DateInsert = trim$(x7106.DateInsert)
            x7106.DateUpdate = trim$(x7106.DateUpdate)
            x7106.InchargeInsert = trim$(x7106.InchargeInsert)
            x7106.InchargeUpdate = trim$(x7106.InchargeUpdate)
            x7106.InchargeCBD_I = trim$(x7106.InchargeCBD_I)
            x7106.InchargeCBD_U = trim$(x7106.InchargeCBD_U)
            x7106.InchargeBOM_I = trim$(x7106.InchargeBOM_I)
            x7106.InchargeBOM_U = trim$(x7106.InchargeBOM_U)
            x7106.InchargeCON_I = trim$(x7106.InchargeCON_I)
            x7106.InchargeCON_U = Trim$(x7106.InchargeCON_U)

            x7106.InchargeDesigner = Trim$(x7106.InchargeDesigner)
            x7106.InchargeStep1 = Trim$(x7106.InchargeStep1)
            x7106.InchargeStep2 = Trim$(x7106.InchargeStep2)
            x7106.InchargeStep3 = Trim$(x7106.InchargeStep3)

            x7106.CheckParent = trim$(x7106.CheckParent)
            x7106.ShoesParent = trim$(x7106.ShoesParent)
            x7106.CheckUse = trim$(x7106.CheckUse)
            x7106.TimeInsert = trim$(x7106.TimeInsert)
            x7106.TimeUpdate = trim$(x7106.TimeUpdate)
            x7106.CheckComplete = trim$(x7106.CheckComplete)
            x7106.InchargeComplete = trim$(x7106.InchargeComplete)
            x7106.DateComplete = trim$(x7106.DateComplete)
            x7106.InchargeCompleteUn = trim$(x7106.InchargeCompleteUn)
            x7106.DateCompleteUn = trim$(x7106.DateCompleteUn)
            x7106.TimeComplete = trim$(x7106.TimeComplete)
            x7106.CheckBOM = trim$(x7106.CheckBOM)
            x7106.InchargeBOMCom = trim$(x7106.InchargeBOMCom)
            x7106.DateBOMCom = trim$(x7106.DateBOMCom)
            x7106.InchargeBOMUn = trim$(x7106.InchargeBOMUn)
            x7106.DateBOMUn = trim$(x7106.DateBOMUn)
            x7106.TimeBOMCom = trim$(x7106.TimeBOMCom)
            x7106.CheckCBD = trim$(x7106.CheckCBD)
            x7106.InchargeCBDCom = trim$(x7106.InchargeCBDCom)
            x7106.DateCBDCom = trim$(x7106.DateCBDCom)
            x7106.InchargeCBDUn = trim$(x7106.InchargeCBDUn)
            x7106.DateCBDUn = trim$(x7106.DateCBDUn)
            x7106.TimeCBDCom = trim$(x7106.TimeCBDCom)
            x7106.CheckCON = trim$(x7106.CheckCON)
            x7106.InchargeCONCom = trim$(x7106.InchargeCONCom)
            x7106.DateCONCom = trim$(x7106.DateCONCom)
            x7106.InchargeCONUn = trim$(x7106.InchargeCONUn)
            x7106.DateCONUn = trim$(x7106.DateCONUn)
            x7106.TimeCONCom = trim$(x7106.TimeCONCom)
            x7106.CheckFB = trim$(x7106.CheckFB)
            x7106.CheckSameMold = trim$(x7106.CheckSameMold)
            x7106.Remark = trim$(x7106.Remark)
            x7106.seSite = trim$(x7106.seSite)
            x7106.cdSite = trim$(x7106.cdSite)

            If trim$(x7106.ShoesCode) = "" Then x7106.ShoesCode = Space(1)
            If trim$(x7106.ShoesCodeBase) = "" Then x7106.ShoesCodeBase = Space(1)
            If trim$(x7106.Customercode) = "" Then x7106.Customercode = Space(1)
            If trim$(x7106.CustSpecNo) = "" Then x7106.CustSpecNo = Space(1)
            If trim$(x7106.ProductCode) = "" Then x7106.ProductCode = Space(1)
            If trim$(x7106.Style) = "" Then x7106.Style = Space(1)
            If trim$(x7106.Article) = "" Then x7106.Article = Space(1)
            If trim$(x7106.Line) = "" Then x7106.Line = Space(1)
            If trim$(x7106.MCODE) = "" Then x7106.MCODE = Space(1)
            If trim$(x7106.ColorCode) = "" Then x7106.ColorCode = Space(1)
            If trim$(x7106.MCODEName) = "" Then x7106.MCODEName = Space(1)
            If trim$(x7106.ColorName) = "" Then x7106.ColorName = Space(1)
            If trim$(x7106.VerALL) = "" Then x7106.VerALL = Space(1)
            If trim$(x7106.VerSAM) = "" Then x7106.VerSAM = Space(1)
            If trim$(x7106.VerBOM) = "" Then x7106.VerBOM = Space(1)
            If trim$(x7106.VerCBD) = "" Then x7106.VerCBD = Space(1)
            If trim$(x7106.VerROT) = "" Then x7106.VerROT = Space(1)
            If trim$(x7106.VerJOB) = "" Then x7106.VerJOB = Space(1)
            If trim$(x7106.CustSpecNo1) = "" Then x7106.CustSpecNo1 = Space(1)
            If trim$(x7106.seProductType) = "" Then x7106.seProductType = Space(1)
            If trim$(x7106.cdProductType) = "" Then x7106.cdProductType = Space(1)
            If trim$(x7106.seProductSize) = "" Then x7106.seProductSize = Space(1)
            If trim$(x7106.cdProductSize) = "" Then x7106.cdProductSize = Space(1)
            If trim$(x7106.seSpecState) = "" Then x7106.seSpecState = Space(1)
            If trim$(x7106.cdSpecState) = "" Then x7106.cdSpecState = Space(1)
            If trim$(x7106.Szno) = "" Then x7106.Szno = Space(1)
            If trim$(x7106.SpeciticSize) = "" Then x7106.SpeciticSize = Space(1)
            If trim$(x7106.seSeason) = "" Then x7106.seSeason = Space(1)
            If trim$(x7106.cdSeason) = "" Then x7106.cdSeason = Space(1)
            If trim$(x7106.seGender) = "" Then x7106.seGender = Space(1)
            If trim$(x7106.cdGender) = "" Then x7106.cdGender = Space(1)
            If trim$(x7106.LastCode) = "" Then x7106.LastCode = Space(1)
            If trim$(x7106.LastWidth) = "" Then x7106.LastWidth = Space(1)
            If Trim$(x7106.LastQty) = "" Then x7106.LastQty = 0
            If Trim$(x7106.QtyAverage) = "" Then x7106.QtyAverage = 0
            If trim$(x7106.MoldCode) = "" Then x7106.MoldCode = Space(1)
            If trim$(x7106.MoldSpec) = "" Then x7106.MoldSpec = Space(1)
            If trim$(x7106.MoldQty) = "" Then x7106.MoldQty = 0
            If trim$(x7106.CuttingDieCode) = "" Then x7106.CuttingDieCode = Space(1)
            If trim$(x7106.TexonCode) = "" Then x7106.TexonCode = Space(1)
            If trim$(x7106.TexonColor) = "" Then x7106.TexonColor = Space(1)
            If trim$(x7106.InsoleCode) = "" Then x7106.InsoleCode = Space(1)
            If trim$(x7106.InsoleColor) = "" Then x7106.InsoleColor = Space(1)
            If trim$(x7106.OutsoleCode) = "" Then x7106.OutsoleCode = Space(1)
            If trim$(x7106.OutsoleColor) = "" Then x7106.OutsoleColor = Space(1)
            If trim$(x7106.OutsoleColorCode) = "" Then x7106.OutsoleColorCode = Space(1)
            If trim$(x7106.MidSoleCode) = "" Then x7106.MidSoleCode = Space(1)
            If trim$(x7106.MidsoleColor) = "" Then x7106.MidsoleColor = Space(1)
            If trim$(x7106.LogoCode) = "" Then x7106.LogoCode = Space(1)
            If trim$(x7106.LogoColor) = "" Then x7106.LogoColor = Space(1)
            If trim$(x7106.LogoColorCode) = "" Then x7106.LogoColorCode = Space(1)
            If trim$(x7106.SizeRange) = "" Then x7106.SizeRange = Space(1)
            If trim$(x7106.Note0) = "" Then x7106.Note0 = Space(1)
            If trim$(x7106.Note1) = "" Then x7106.Note1 = Space(1)
            If trim$(x7106.Note2) = "" Then x7106.Note2 = Space(1)
            If trim$(x7106.Note3) = "" Then x7106.Note3 = Space(1)
            If trim$(x7106.Note4) = "" Then x7106.Note4 = Space(1)
            If trim$(x7106.Note5) = "" Then x7106.Note5 = Space(1)
            If trim$(x7106.Note6) = "" Then x7106.Note6 = Space(1)
            If trim$(x7106.Note7) = "" Then x7106.Note7 = Space(1)
            If trim$(x7106.Note8) = "" Then x7106.Note8 = Space(1)
            If trim$(x7106.Note9) = "" Then x7106.Note9 = Space(1)
            If trim$(x7106.Note10) = "" Then x7106.Note10 = Space(1)
            If trim$(x7106.DateExchangePrice) = "" Then x7106.DateExchangePrice = Space(1)
            If trim$(x7106.ExchangePrice) = "" Then x7106.ExchangePrice = 0
            If trim$(x7106.PriceUSD) = "" Then x7106.PriceUSD = 0
            If trim$(x7106.PriceVND) = "" Then x7106.PriceVND = 0
            If trim$(x7106.DateLable1) = "" Then x7106.DateLable1 = Space(1)
            If trim$(x7106.DateLable2) = "" Then x7106.DateLable2 = Space(1)
            If trim$(x7106.DateLable3) = "" Then x7106.DateLable3 = Space(1)
            If trim$(x7106.DateInsert) = "" Then x7106.DateInsert = Space(1)
            If trim$(x7106.DateUpdate) = "" Then x7106.DateUpdate = Space(1)
            If trim$(x7106.InchargeInsert) = "" Then x7106.InchargeInsert = Space(1)
            If trim$(x7106.InchargeUpdate) = "" Then x7106.InchargeUpdate = Space(1)
            If trim$(x7106.InchargeCBD_I) = "" Then x7106.InchargeCBD_I = Space(1)
            If trim$(x7106.InchargeCBD_U) = "" Then x7106.InchargeCBD_U = Space(1)
            If trim$(x7106.InchargeBOM_I) = "" Then x7106.InchargeBOM_I = Space(1)
            If trim$(x7106.InchargeBOM_U) = "" Then x7106.InchargeBOM_U = Space(1)
            If trim$(x7106.InchargeCON_I) = "" Then x7106.InchargeCON_I = Space(1)
            If Trim$(x7106.InchargeCON_U) = "" Then x7106.InchargeCON_U = Space(1)

            If Trim$(x7106.InchargeDesigner) = "" Then x7106.InchargeDesigner = Space(1)
            If Trim$(x7106.InchargeStep1) = "" Then x7106.InchargeStep1 = Space(1)
            If Trim$(x7106.InchargeStep2) = "" Then x7106.InchargeStep2 = Space(1)
            If Trim$(x7106.InchargeStep3) = "" Then x7106.InchargeStep3 = Space(1)

            If trim$(x7106.CheckParent) = "" Then x7106.CheckParent = Space(1)
            If trim$(x7106.ShoesParent) = "" Then x7106.ShoesParent = Space(1)
            If trim$(x7106.CheckUse) = "" Then x7106.CheckUse = Space(1)
            If trim$(x7106.TimeInsert) = "" Then x7106.TimeInsert = Space(1)
            If trim$(x7106.TimeUpdate) = "" Then x7106.TimeUpdate = Space(1)
            If trim$(x7106.CheckComplete) = "" Then x7106.CheckComplete = Space(1)
            If trim$(x7106.InchargeComplete) = "" Then x7106.InchargeComplete = Space(1)
            If trim$(x7106.DateComplete) = "" Then x7106.DateComplete = Space(1)
            If trim$(x7106.InchargeCompleteUn) = "" Then x7106.InchargeCompleteUn = Space(1)
            If trim$(x7106.DateCompleteUn) = "" Then x7106.DateCompleteUn = Space(1)
            If trim$(x7106.TimeComplete) = "" Then x7106.TimeComplete = Space(1)
            If trim$(x7106.CheckBOM) = "" Then x7106.CheckBOM = Space(1)
            If trim$(x7106.InchargeBOMCom) = "" Then x7106.InchargeBOMCom = Space(1)
            If trim$(x7106.DateBOMCom) = "" Then x7106.DateBOMCom = Space(1)
            If trim$(x7106.InchargeBOMUn) = "" Then x7106.InchargeBOMUn = Space(1)
            If trim$(x7106.DateBOMUn) = "" Then x7106.DateBOMUn = Space(1)
            If trim$(x7106.TimeBOMCom) = "" Then x7106.TimeBOMCom = Space(1)
            If trim$(x7106.CheckCBD) = "" Then x7106.CheckCBD = Space(1)
            If trim$(x7106.InchargeCBDCom) = "" Then x7106.InchargeCBDCom = Space(1)
            If trim$(x7106.DateCBDCom) = "" Then x7106.DateCBDCom = Space(1)
            If trim$(x7106.InchargeCBDUn) = "" Then x7106.InchargeCBDUn = Space(1)
            If trim$(x7106.DateCBDUn) = "" Then x7106.DateCBDUn = Space(1)
            If trim$(x7106.TimeCBDCom) = "" Then x7106.TimeCBDCom = Space(1)
            If trim$(x7106.CheckCON) = "" Then x7106.CheckCON = Space(1)
            If trim$(x7106.InchargeCONCom) = "" Then x7106.InchargeCONCom = Space(1)
            If trim$(x7106.DateCONCom) = "" Then x7106.DateCONCom = Space(1)
            If trim$(x7106.InchargeCONUn) = "" Then x7106.InchargeCONUn = Space(1)
            If trim$(x7106.DateCONUn) = "" Then x7106.DateCONUn = Space(1)
            If trim$(x7106.TimeCONCom) = "" Then x7106.TimeCONCom = Space(1)
            If trim$(x7106.CheckFB) = "" Then x7106.CheckFB = Space(1)
            If trim$(x7106.CheckSameMold) = "" Then x7106.CheckSameMold = Space(1)
            If trim$(x7106.Remark) = "" Then x7106.Remark = Space(1)
            If trim$(x7106.seSite) = "" Then x7106.seSite = Space(1)
            If trim$(x7106.cdSite) = "" Then x7106.cdSite = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K7106_MOVE(rs7106 As SqlClient.SqlDataReader)
        Try

            Call D7106_CLEAR()

            If IsdbNull(rs7106!K7106_ShoesCode) = False Then D7106.ShoesCode = Trim$(rs7106!K7106_ShoesCode)
            If IsdbNull(rs7106!K7106_ShoesCodeBase) = False Then D7106.ShoesCodeBase = Trim$(rs7106!K7106_ShoesCodeBase)
            If IsdbNull(rs7106!K7106_Customercode) = False Then D7106.Customercode = Trim$(rs7106!K7106_Customercode)
            If IsdbNull(rs7106!K7106_CustSpecNo) = False Then D7106.CustSpecNo = Trim$(rs7106!K7106_CustSpecNo)
            If IsdbNull(rs7106!K7106_ProductCode) = False Then D7106.ProductCode = Trim$(rs7106!K7106_ProductCode)
            If IsdbNull(rs7106!K7106_Style) = False Then D7106.Style = Trim$(rs7106!K7106_Style)
            If IsdbNull(rs7106!K7106_Article) = False Then D7106.Article = Trim$(rs7106!K7106_Article)
            If IsdbNull(rs7106!K7106_Line) = False Then D7106.Line = Trim$(rs7106!K7106_Line)
            If IsdbNull(rs7106!K7106_MCODE) = False Then D7106.MCODE = Trim$(rs7106!K7106_MCODE)
            If IsdbNull(rs7106!K7106_ColorCode) = False Then D7106.ColorCode = Trim$(rs7106!K7106_ColorCode)
            If IsdbNull(rs7106!K7106_MCODEName) = False Then D7106.MCODEName = Trim$(rs7106!K7106_MCODEName)
            If IsdbNull(rs7106!K7106_ColorName) = False Then D7106.ColorName = Trim$(rs7106!K7106_ColorName)
            If IsdbNull(rs7106!K7106_VerALL) = False Then D7106.VerALL = Trim$(rs7106!K7106_VerALL)
            If IsdbNull(rs7106!K7106_VerSAM) = False Then D7106.VerSAM = Trim$(rs7106!K7106_VerSAM)
            If IsdbNull(rs7106!K7106_VerBOM) = False Then D7106.VerBOM = Trim$(rs7106!K7106_VerBOM)
            If IsdbNull(rs7106!K7106_VerCBD) = False Then D7106.VerCBD = Trim$(rs7106!K7106_VerCBD)
            If IsdbNull(rs7106!K7106_VerROT) = False Then D7106.VerROT = Trim$(rs7106!K7106_VerROT)
            If IsdbNull(rs7106!K7106_VerJOB) = False Then D7106.VerJOB = Trim$(rs7106!K7106_VerJOB)
            If IsdbNull(rs7106!K7106_CustSpecNo1) = False Then D7106.CustSpecNo1 = Trim$(rs7106!K7106_CustSpecNo1)
            If IsdbNull(rs7106!K7106_seProductType) = False Then D7106.seProductType = Trim$(rs7106!K7106_seProductType)
            If IsdbNull(rs7106!K7106_cdProductType) = False Then D7106.cdProductType = Trim$(rs7106!K7106_cdProductType)
            If IsdbNull(rs7106!K7106_seProductSize) = False Then D7106.seProductSize = Trim$(rs7106!K7106_seProductSize)
            If IsdbNull(rs7106!K7106_cdProductSize) = False Then D7106.cdProductSize = Trim$(rs7106!K7106_cdProductSize)
            If IsdbNull(rs7106!K7106_seSpecState) = False Then D7106.seSpecState = Trim$(rs7106!K7106_seSpecState)
            If IsdbNull(rs7106!K7106_cdSpecState) = False Then D7106.cdSpecState = Trim$(rs7106!K7106_cdSpecState)
            If IsdbNull(rs7106!K7106_Szno) = False Then D7106.Szno = Trim$(rs7106!K7106_Szno)
            If IsdbNull(rs7106!K7106_SpeciticSize) = False Then D7106.SpeciticSize = Trim$(rs7106!K7106_SpeciticSize)
            If IsdbNull(rs7106!K7106_seSeason) = False Then D7106.seSeason = Trim$(rs7106!K7106_seSeason)
            If IsdbNull(rs7106!K7106_cdSeason) = False Then D7106.cdSeason = Trim$(rs7106!K7106_cdSeason)
            If IsdbNull(rs7106!K7106_seGender) = False Then D7106.seGender = Trim$(rs7106!K7106_seGender)
            If IsdbNull(rs7106!K7106_cdGender) = False Then D7106.cdGender = Trim$(rs7106!K7106_cdGender)
            If IsdbNull(rs7106!K7106_LastCode) = False Then D7106.LastCode = Trim$(rs7106!K7106_LastCode)
            If IsdbNull(rs7106!K7106_LastWidth) = False Then D7106.LastWidth = Trim$(rs7106!K7106_LastWidth)
            If IsDBNull(rs7106!K7106_LastQty) = False Then D7106.LastQty = Trim$(rs7106!K7106_LastQty)
            If IsDBNull(rs7106!K7106_QtyAverage) = False Then D7106.QtyAverage = Trim$(rs7106!K7106_QtyAverage)
            If IsdbNull(rs7106!K7106_MoldCode) = False Then D7106.MoldCode = Trim$(rs7106!K7106_MoldCode)
            If IsdbNull(rs7106!K7106_MoldSpec) = False Then D7106.MoldSpec = Trim$(rs7106!K7106_MoldSpec)
            If IsdbNull(rs7106!K7106_MoldQty) = False Then D7106.MoldQty = Trim$(rs7106!K7106_MoldQty)
            If IsdbNull(rs7106!K7106_CuttingDieCode) = False Then D7106.CuttingDieCode = Trim$(rs7106!K7106_CuttingDieCode)
            If IsdbNull(rs7106!K7106_TexonCode) = False Then D7106.TexonCode = Trim$(rs7106!K7106_TexonCode)
            If IsdbNull(rs7106!K7106_TexonColor) = False Then D7106.TexonColor = Trim$(rs7106!K7106_TexonColor)
            If IsdbNull(rs7106!K7106_InsoleCode) = False Then D7106.InsoleCode = Trim$(rs7106!K7106_InsoleCode)
            If IsdbNull(rs7106!K7106_InsoleColor) = False Then D7106.InsoleColor = Trim$(rs7106!K7106_InsoleColor)
            If IsdbNull(rs7106!K7106_OutsoleCode) = False Then D7106.OutsoleCode = Trim$(rs7106!K7106_OutsoleCode)
            If IsdbNull(rs7106!K7106_OutsoleColor) = False Then D7106.OutsoleColor = Trim$(rs7106!K7106_OutsoleColor)
            If IsdbNull(rs7106!K7106_OutsoleColorCode) = False Then D7106.OutsoleColorCode = Trim$(rs7106!K7106_OutsoleColorCode)
            If IsdbNull(rs7106!K7106_MidSoleCode) = False Then D7106.MidSoleCode = Trim$(rs7106!K7106_MidSoleCode)
            If IsdbNull(rs7106!K7106_MidsoleColor) = False Then D7106.MidsoleColor = Trim$(rs7106!K7106_MidsoleColor)
            If IsdbNull(rs7106!K7106_LogoCode) = False Then D7106.LogoCode = Trim$(rs7106!K7106_LogoCode)
            If IsdbNull(rs7106!K7106_LogoColor) = False Then D7106.LogoColor = Trim$(rs7106!K7106_LogoColor)
            If IsdbNull(rs7106!K7106_LogoColorCode) = False Then D7106.LogoColorCode = Trim$(rs7106!K7106_LogoColorCode)
            If IsdbNull(rs7106!K7106_SizeRange) = False Then D7106.SizeRange = Trim$(rs7106!K7106_SizeRange)
            If IsdbNull(rs7106!K7106_Note0) = False Then D7106.Note0 = Trim$(rs7106!K7106_Note0)
            If IsdbNull(rs7106!K7106_Note1) = False Then D7106.Note1 = Trim$(rs7106!K7106_Note1)
            If IsdbNull(rs7106!K7106_Note2) = False Then D7106.Note2 = Trim$(rs7106!K7106_Note2)
            If IsdbNull(rs7106!K7106_Note3) = False Then D7106.Note3 = Trim$(rs7106!K7106_Note3)
            If IsdbNull(rs7106!K7106_Note4) = False Then D7106.Note4 = Trim$(rs7106!K7106_Note4)
            If IsdbNull(rs7106!K7106_Note5) = False Then D7106.Note5 = Trim$(rs7106!K7106_Note5)
            If IsdbNull(rs7106!K7106_Note6) = False Then D7106.Note6 = Trim$(rs7106!K7106_Note6)
            If IsdbNull(rs7106!K7106_Note7) = False Then D7106.Note7 = Trim$(rs7106!K7106_Note7)
            If IsdbNull(rs7106!K7106_Note8) = False Then D7106.Note8 = Trim$(rs7106!K7106_Note8)
            If IsdbNull(rs7106!K7106_Note9) = False Then D7106.Note9 = Trim$(rs7106!K7106_Note9)
            If IsdbNull(rs7106!K7106_Note10) = False Then D7106.Note10 = Trim$(rs7106!K7106_Note10)
            If IsdbNull(rs7106!K7106_DateExchangePrice) = False Then D7106.DateExchangePrice = Trim$(rs7106!K7106_DateExchangePrice)
            If IsdbNull(rs7106!K7106_ExchangePrice) = False Then D7106.ExchangePrice = Trim$(rs7106!K7106_ExchangePrice)
            If IsdbNull(rs7106!K7106_PriceUSD) = False Then D7106.PriceUSD = Trim$(rs7106!K7106_PriceUSD)
            If IsdbNull(rs7106!K7106_PriceVND) = False Then D7106.PriceVND = Trim$(rs7106!K7106_PriceVND)
            If IsdbNull(rs7106!K7106_DateLable1) = False Then D7106.DateLable1 = Trim$(rs7106!K7106_DateLable1)
            If IsdbNull(rs7106!K7106_DateLable2) = False Then D7106.DateLable2 = Trim$(rs7106!K7106_DateLable2)
            If IsdbNull(rs7106!K7106_DateLable3) = False Then D7106.DateLable3 = Trim$(rs7106!K7106_DateLable3)
            If IsdbNull(rs7106!K7106_DateInsert) = False Then D7106.DateInsert = Trim$(rs7106!K7106_DateInsert)
            If IsdbNull(rs7106!K7106_DateUpdate) = False Then D7106.DateUpdate = Trim$(rs7106!K7106_DateUpdate)
            If IsdbNull(rs7106!K7106_InchargeInsert) = False Then D7106.InchargeInsert = Trim$(rs7106!K7106_InchargeInsert)
            If IsdbNull(rs7106!K7106_InchargeUpdate) = False Then D7106.InchargeUpdate = Trim$(rs7106!K7106_InchargeUpdate)
            If IsdbNull(rs7106!K7106_InchargeCBD_I) = False Then D7106.InchargeCBD_I = Trim$(rs7106!K7106_InchargeCBD_I)
            If IsdbNull(rs7106!K7106_InchargeCBD_U) = False Then D7106.InchargeCBD_U = Trim$(rs7106!K7106_InchargeCBD_U)
            If IsdbNull(rs7106!K7106_InchargeBOM_I) = False Then D7106.InchargeBOM_I = Trim$(rs7106!K7106_InchargeBOM_I)
            If IsdbNull(rs7106!K7106_InchargeBOM_U) = False Then D7106.InchargeBOM_U = Trim$(rs7106!K7106_InchargeBOM_U)
            If IsdbNull(rs7106!K7106_InchargeCON_I) = False Then D7106.InchargeCON_I = Trim$(rs7106!K7106_InchargeCON_I)
            If IsDBNull(rs7106!K7106_InchargeCON_U) = False Then D7106.InchargeCON_U = Trim$(rs7106!K7106_InchargeCON_U)

            If IsDBNull(rs7106!K7106_InchargeDesigner) = False Then D7106.InchargeDesigner = Trim$(rs7106!K7106_InchargeDesigner)
            If IsDBNull(rs7106!K7106_InchargeStep1) = False Then D7106.InchargeStep1 = Trim$(rs7106!K7106_InchargeStep1)
            If IsDBNull(rs7106!K7106_InchargeStep2) = False Then D7106.InchargeStep2 = Trim$(rs7106!K7106_InchargeStep2)
            If IsDBNull(rs7106!K7106_InchargeStep3) = False Then D7106.InchargeStep3 = Trim$(rs7106!K7106_InchargeStep3)

            If IsdbNull(rs7106!K7106_CheckParent) = False Then D7106.CheckParent = Trim$(rs7106!K7106_CheckParent)
            If IsdbNull(rs7106!K7106_ShoesParent) = False Then D7106.ShoesParent = Trim$(rs7106!K7106_ShoesParent)
            If IsdbNull(rs7106!K7106_CheckUse) = False Then D7106.CheckUse = Trim$(rs7106!K7106_CheckUse)
            If IsdbNull(rs7106!K7106_TimeInsert) = False Then D7106.TimeInsert = Trim$(rs7106!K7106_TimeInsert)
            If IsdbNull(rs7106!K7106_TimeUpdate) = False Then D7106.TimeUpdate = Trim$(rs7106!K7106_TimeUpdate)
            If IsdbNull(rs7106!K7106_CheckComplete) = False Then D7106.CheckComplete = Trim$(rs7106!K7106_CheckComplete)
            If IsdbNull(rs7106!K7106_InchargeComplete) = False Then D7106.InchargeComplete = Trim$(rs7106!K7106_InchargeComplete)
            If IsdbNull(rs7106!K7106_DateComplete) = False Then D7106.DateComplete = Trim$(rs7106!K7106_DateComplete)
            If IsdbNull(rs7106!K7106_InchargeCompleteUn) = False Then D7106.InchargeCompleteUn = Trim$(rs7106!K7106_InchargeCompleteUn)
            If IsdbNull(rs7106!K7106_DateCompleteUn) = False Then D7106.DateCompleteUn = Trim$(rs7106!K7106_DateCompleteUn)
            If IsdbNull(rs7106!K7106_TimeComplete) = False Then D7106.TimeComplete = Trim$(rs7106!K7106_TimeComplete)
            If IsdbNull(rs7106!K7106_CheckBOM) = False Then D7106.CheckBOM = Trim$(rs7106!K7106_CheckBOM)
            If IsdbNull(rs7106!K7106_InchargeBOMCom) = False Then D7106.InchargeBOMCom = Trim$(rs7106!K7106_InchargeBOMCom)
            If IsdbNull(rs7106!K7106_DateBOMCom) = False Then D7106.DateBOMCom = Trim$(rs7106!K7106_DateBOMCom)
            If IsdbNull(rs7106!K7106_InchargeBOMUn) = False Then D7106.InchargeBOMUn = Trim$(rs7106!K7106_InchargeBOMUn)
            If IsdbNull(rs7106!K7106_DateBOMUn) = False Then D7106.DateBOMUn = Trim$(rs7106!K7106_DateBOMUn)
            If IsdbNull(rs7106!K7106_TimeBOMCom) = False Then D7106.TimeBOMCom = Trim$(rs7106!K7106_TimeBOMCom)
            If IsdbNull(rs7106!K7106_CheckCBD) = False Then D7106.CheckCBD = Trim$(rs7106!K7106_CheckCBD)
            If IsdbNull(rs7106!K7106_InchargeCBDCom) = False Then D7106.InchargeCBDCom = Trim$(rs7106!K7106_InchargeCBDCom)
            If IsdbNull(rs7106!K7106_DateCBDCom) = False Then D7106.DateCBDCom = Trim$(rs7106!K7106_DateCBDCom)
            If IsdbNull(rs7106!K7106_InchargeCBDUn) = False Then D7106.InchargeCBDUn = Trim$(rs7106!K7106_InchargeCBDUn)
            If IsdbNull(rs7106!K7106_DateCBDUn) = False Then D7106.DateCBDUn = Trim$(rs7106!K7106_DateCBDUn)
            If IsdbNull(rs7106!K7106_TimeCBDCom) = False Then D7106.TimeCBDCom = Trim$(rs7106!K7106_TimeCBDCom)
            If IsdbNull(rs7106!K7106_CheckCON) = False Then D7106.CheckCON = Trim$(rs7106!K7106_CheckCON)
            If IsdbNull(rs7106!K7106_InchargeCONCom) = False Then D7106.InchargeCONCom = Trim$(rs7106!K7106_InchargeCONCom)
            If IsdbNull(rs7106!K7106_DateCONCom) = False Then D7106.DateCONCom = Trim$(rs7106!K7106_DateCONCom)
            If IsdbNull(rs7106!K7106_InchargeCONUn) = False Then D7106.InchargeCONUn = Trim$(rs7106!K7106_InchargeCONUn)
            If IsdbNull(rs7106!K7106_DateCONUn) = False Then D7106.DateCONUn = Trim$(rs7106!K7106_DateCONUn)
            If IsdbNull(rs7106!K7106_TimeCONCom) = False Then D7106.TimeCONCom = Trim$(rs7106!K7106_TimeCONCom)
            If IsdbNull(rs7106!K7106_CheckFB) = False Then D7106.CheckFB = Trim$(rs7106!K7106_CheckFB)
            If IsdbNull(rs7106!K7106_CheckSameMold) = False Then D7106.CheckSameMold = Trim$(rs7106!K7106_CheckSameMold)
            If IsdbNull(rs7106!K7106_Remark) = False Then D7106.Remark = Trim$(rs7106!K7106_Remark)
            If IsdbNull(rs7106!K7106_seSite) = False Then D7106.seSite = Trim$(rs7106!K7106_seSite)
            If IsdbNull(rs7106!K7106_cdSite) = False Then D7106.cdSite = Trim$(rs7106!K7106_cdSite)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7106_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K7106_MOVE(rs7106 As DataRow)
        Try

            Call D7106_CLEAR()

            If IsdbNull(rs7106!K7106_ShoesCode) = False Then D7106.ShoesCode = Trim$(rs7106!K7106_ShoesCode)
            If IsdbNull(rs7106!K7106_ShoesCodeBase) = False Then D7106.ShoesCodeBase = Trim$(rs7106!K7106_ShoesCodeBase)
            If IsdbNull(rs7106!K7106_Customercode) = False Then D7106.Customercode = Trim$(rs7106!K7106_Customercode)
            If IsdbNull(rs7106!K7106_CustSpecNo) = False Then D7106.CustSpecNo = Trim$(rs7106!K7106_CustSpecNo)
            If IsdbNull(rs7106!K7106_ProductCode) = False Then D7106.ProductCode = Trim$(rs7106!K7106_ProductCode)
            If IsdbNull(rs7106!K7106_Style) = False Then D7106.Style = Trim$(rs7106!K7106_Style)
            If IsdbNull(rs7106!K7106_Article) = False Then D7106.Article = Trim$(rs7106!K7106_Article)
            If IsdbNull(rs7106!K7106_Line) = False Then D7106.Line = Trim$(rs7106!K7106_Line)
            If IsdbNull(rs7106!K7106_MCODE) = False Then D7106.MCODE = Trim$(rs7106!K7106_MCODE)
            If IsdbNull(rs7106!K7106_ColorCode) = False Then D7106.ColorCode = Trim$(rs7106!K7106_ColorCode)
            If IsdbNull(rs7106!K7106_MCODEName) = False Then D7106.MCODEName = Trim$(rs7106!K7106_MCODEName)
            If IsdbNull(rs7106!K7106_ColorName) = False Then D7106.ColorName = Trim$(rs7106!K7106_ColorName)
            If IsdbNull(rs7106!K7106_VerALL) = False Then D7106.VerALL = Trim$(rs7106!K7106_VerALL)
            If IsdbNull(rs7106!K7106_VerSAM) = False Then D7106.VerSAM = Trim$(rs7106!K7106_VerSAM)
            If IsdbNull(rs7106!K7106_VerBOM) = False Then D7106.VerBOM = Trim$(rs7106!K7106_VerBOM)
            If IsdbNull(rs7106!K7106_VerCBD) = False Then D7106.VerCBD = Trim$(rs7106!K7106_VerCBD)
            If IsdbNull(rs7106!K7106_VerROT) = False Then D7106.VerROT = Trim$(rs7106!K7106_VerROT)
            If IsdbNull(rs7106!K7106_VerJOB) = False Then D7106.VerJOB = Trim$(rs7106!K7106_VerJOB)
            If IsdbNull(rs7106!K7106_CustSpecNo1) = False Then D7106.CustSpecNo1 = Trim$(rs7106!K7106_CustSpecNo1)
            If IsdbNull(rs7106!K7106_seProductType) = False Then D7106.seProductType = Trim$(rs7106!K7106_seProductType)
            If IsdbNull(rs7106!K7106_cdProductType) = False Then D7106.cdProductType = Trim$(rs7106!K7106_cdProductType)
            If IsdbNull(rs7106!K7106_seProductSize) = False Then D7106.seProductSize = Trim$(rs7106!K7106_seProductSize)
            If IsdbNull(rs7106!K7106_cdProductSize) = False Then D7106.cdProductSize = Trim$(rs7106!K7106_cdProductSize)
            If IsdbNull(rs7106!K7106_seSpecState) = False Then D7106.seSpecState = Trim$(rs7106!K7106_seSpecState)
            If IsdbNull(rs7106!K7106_cdSpecState) = False Then D7106.cdSpecState = Trim$(rs7106!K7106_cdSpecState)
            If IsdbNull(rs7106!K7106_Szno) = False Then D7106.Szno = Trim$(rs7106!K7106_Szno)
            If IsdbNull(rs7106!K7106_SpeciticSize) = False Then D7106.SpeciticSize = Trim$(rs7106!K7106_SpeciticSize)
            If IsdbNull(rs7106!K7106_seSeason) = False Then D7106.seSeason = Trim$(rs7106!K7106_seSeason)
            If IsdbNull(rs7106!K7106_cdSeason) = False Then D7106.cdSeason = Trim$(rs7106!K7106_cdSeason)
            If IsdbNull(rs7106!K7106_seGender) = False Then D7106.seGender = Trim$(rs7106!K7106_seGender)
            If IsdbNull(rs7106!K7106_cdGender) = False Then D7106.cdGender = Trim$(rs7106!K7106_cdGender)
            If IsdbNull(rs7106!K7106_LastCode) = False Then D7106.LastCode = Trim$(rs7106!K7106_LastCode)
            If IsdbNull(rs7106!K7106_LastWidth) = False Then D7106.LastWidth = Trim$(rs7106!K7106_LastWidth)
            If IsDBNull(rs7106!K7106_LastQty) = False Then D7106.LastQty = Trim$(rs7106!K7106_LastQty)
            If IsDBNull(rs7106!K7106_QtyAverage) = False Then D7106.QtyAverage = Trim$(rs7106!K7106_QtyAverage)
            If IsdbNull(rs7106!K7106_MoldCode) = False Then D7106.MoldCode = Trim$(rs7106!K7106_MoldCode)
            If IsdbNull(rs7106!K7106_MoldSpec) = False Then D7106.MoldSpec = Trim$(rs7106!K7106_MoldSpec)
            If IsdbNull(rs7106!K7106_MoldQty) = False Then D7106.MoldQty = Trim$(rs7106!K7106_MoldQty)
            If IsdbNull(rs7106!K7106_CuttingDieCode) = False Then D7106.CuttingDieCode = Trim$(rs7106!K7106_CuttingDieCode)
            If IsdbNull(rs7106!K7106_TexonCode) = False Then D7106.TexonCode = Trim$(rs7106!K7106_TexonCode)
            If IsdbNull(rs7106!K7106_TexonColor) = False Then D7106.TexonColor = Trim$(rs7106!K7106_TexonColor)
            If IsdbNull(rs7106!K7106_InsoleCode) = False Then D7106.InsoleCode = Trim$(rs7106!K7106_InsoleCode)
            If IsdbNull(rs7106!K7106_InsoleColor) = False Then D7106.InsoleColor = Trim$(rs7106!K7106_InsoleColor)
            If IsdbNull(rs7106!K7106_OutsoleCode) = False Then D7106.OutsoleCode = Trim$(rs7106!K7106_OutsoleCode)
            If IsdbNull(rs7106!K7106_OutsoleColor) = False Then D7106.OutsoleColor = Trim$(rs7106!K7106_OutsoleColor)
            If IsdbNull(rs7106!K7106_OutsoleColorCode) = False Then D7106.OutsoleColorCode = Trim$(rs7106!K7106_OutsoleColorCode)
            If IsdbNull(rs7106!K7106_MidSoleCode) = False Then D7106.MidSoleCode = Trim$(rs7106!K7106_MidSoleCode)
            If IsdbNull(rs7106!K7106_MidsoleColor) = False Then D7106.MidsoleColor = Trim$(rs7106!K7106_MidsoleColor)
            If IsdbNull(rs7106!K7106_LogoCode) = False Then D7106.LogoCode = Trim$(rs7106!K7106_LogoCode)
            If IsdbNull(rs7106!K7106_LogoColor) = False Then D7106.LogoColor = Trim$(rs7106!K7106_LogoColor)
            If IsdbNull(rs7106!K7106_LogoColorCode) = False Then D7106.LogoColorCode = Trim$(rs7106!K7106_LogoColorCode)
            If IsdbNull(rs7106!K7106_SizeRange) = False Then D7106.SizeRange = Trim$(rs7106!K7106_SizeRange)
            If IsdbNull(rs7106!K7106_Note0) = False Then D7106.Note0 = Trim$(rs7106!K7106_Note0)
            If IsdbNull(rs7106!K7106_Note1) = False Then D7106.Note1 = Trim$(rs7106!K7106_Note1)
            If IsdbNull(rs7106!K7106_Note2) = False Then D7106.Note2 = Trim$(rs7106!K7106_Note2)
            If IsdbNull(rs7106!K7106_Note3) = False Then D7106.Note3 = Trim$(rs7106!K7106_Note3)
            If IsdbNull(rs7106!K7106_Note4) = False Then D7106.Note4 = Trim$(rs7106!K7106_Note4)
            If IsdbNull(rs7106!K7106_Note5) = False Then D7106.Note5 = Trim$(rs7106!K7106_Note5)
            If IsdbNull(rs7106!K7106_Note6) = False Then D7106.Note6 = Trim$(rs7106!K7106_Note6)
            If IsdbNull(rs7106!K7106_Note7) = False Then D7106.Note7 = Trim$(rs7106!K7106_Note7)
            If IsdbNull(rs7106!K7106_Note8) = False Then D7106.Note8 = Trim$(rs7106!K7106_Note8)
            If IsdbNull(rs7106!K7106_Note9) = False Then D7106.Note9 = Trim$(rs7106!K7106_Note9)
            If IsdbNull(rs7106!K7106_Note10) = False Then D7106.Note10 = Trim$(rs7106!K7106_Note10)
            If IsdbNull(rs7106!K7106_DateExchangePrice) = False Then D7106.DateExchangePrice = Trim$(rs7106!K7106_DateExchangePrice)
            If IsdbNull(rs7106!K7106_ExchangePrice) = False Then D7106.ExchangePrice = Trim$(rs7106!K7106_ExchangePrice)
            If IsdbNull(rs7106!K7106_PriceUSD) = False Then D7106.PriceUSD = Trim$(rs7106!K7106_PriceUSD)
            If IsdbNull(rs7106!K7106_PriceVND) = False Then D7106.PriceVND = Trim$(rs7106!K7106_PriceVND)
            If IsdbNull(rs7106!K7106_DateLable1) = False Then D7106.DateLable1 = Trim$(rs7106!K7106_DateLable1)
            If IsdbNull(rs7106!K7106_DateLable2) = False Then D7106.DateLable2 = Trim$(rs7106!K7106_DateLable2)
            If IsdbNull(rs7106!K7106_DateLable3) = False Then D7106.DateLable3 = Trim$(rs7106!K7106_DateLable3)
            If IsdbNull(rs7106!K7106_DateInsert) = False Then D7106.DateInsert = Trim$(rs7106!K7106_DateInsert)
            If IsdbNull(rs7106!K7106_DateUpdate) = False Then D7106.DateUpdate = Trim$(rs7106!K7106_DateUpdate)
            If IsdbNull(rs7106!K7106_InchargeInsert) = False Then D7106.InchargeInsert = Trim$(rs7106!K7106_InchargeInsert)
            If IsdbNull(rs7106!K7106_InchargeUpdate) = False Then D7106.InchargeUpdate = Trim$(rs7106!K7106_InchargeUpdate)
            If IsdbNull(rs7106!K7106_InchargeCBD_I) = False Then D7106.InchargeCBD_I = Trim$(rs7106!K7106_InchargeCBD_I)
            If IsdbNull(rs7106!K7106_InchargeCBD_U) = False Then D7106.InchargeCBD_U = Trim$(rs7106!K7106_InchargeCBD_U)
            If IsdbNull(rs7106!K7106_InchargeBOM_I) = False Then D7106.InchargeBOM_I = Trim$(rs7106!K7106_InchargeBOM_I)
            If IsdbNull(rs7106!K7106_InchargeBOM_U) = False Then D7106.InchargeBOM_U = Trim$(rs7106!K7106_InchargeBOM_U)
            If IsdbNull(rs7106!K7106_InchargeCON_I) = False Then D7106.InchargeCON_I = Trim$(rs7106!K7106_InchargeCON_I)
            If IsDBNull(rs7106!K7106_InchargeCON_U) = False Then D7106.InchargeCON_U = Trim$(rs7106!K7106_InchargeCON_U)

            If IsDBNull(rs7106!K7106_InchargeDesigner) = False Then D7106.InchargeDesigner = Trim$(rs7106!K7106_InchargeDesigner)
            If IsDBNull(rs7106!K7106_InchargeStep1) = False Then D7106.InchargeStep1 = Trim$(rs7106!K7106_InchargeStep1)
            If IsDBNull(rs7106!K7106_InchargeStep2) = False Then D7106.InchargeStep2 = Trim$(rs7106!K7106_InchargeStep2)
            If IsDBNull(rs7106!K7106_InchargeStep3) = False Then D7106.InchargeStep3 = Trim$(rs7106!K7106_InchargeStep3)

            If IsdbNull(rs7106!K7106_CheckParent) = False Then D7106.CheckParent = Trim$(rs7106!K7106_CheckParent)
            If IsdbNull(rs7106!K7106_ShoesParent) = False Then D7106.ShoesParent = Trim$(rs7106!K7106_ShoesParent)
            If IsdbNull(rs7106!K7106_CheckUse) = False Then D7106.CheckUse = Trim$(rs7106!K7106_CheckUse)
            If IsdbNull(rs7106!K7106_TimeInsert) = False Then D7106.TimeInsert = Trim$(rs7106!K7106_TimeInsert)
            If IsdbNull(rs7106!K7106_TimeUpdate) = False Then D7106.TimeUpdate = Trim$(rs7106!K7106_TimeUpdate)
            If IsdbNull(rs7106!K7106_CheckComplete) = False Then D7106.CheckComplete = Trim$(rs7106!K7106_CheckComplete)
            If IsdbNull(rs7106!K7106_InchargeComplete) = False Then D7106.InchargeComplete = Trim$(rs7106!K7106_InchargeComplete)
            If IsdbNull(rs7106!K7106_DateComplete) = False Then D7106.DateComplete = Trim$(rs7106!K7106_DateComplete)
            If IsdbNull(rs7106!K7106_InchargeCompleteUn) = False Then D7106.InchargeCompleteUn = Trim$(rs7106!K7106_InchargeCompleteUn)
            If IsdbNull(rs7106!K7106_DateCompleteUn) = False Then D7106.DateCompleteUn = Trim$(rs7106!K7106_DateCompleteUn)
            If IsdbNull(rs7106!K7106_TimeComplete) = False Then D7106.TimeComplete = Trim$(rs7106!K7106_TimeComplete)
            If IsdbNull(rs7106!K7106_CheckBOM) = False Then D7106.CheckBOM = Trim$(rs7106!K7106_CheckBOM)
            If IsdbNull(rs7106!K7106_InchargeBOMCom) = False Then D7106.InchargeBOMCom = Trim$(rs7106!K7106_InchargeBOMCom)
            If IsdbNull(rs7106!K7106_DateBOMCom) = False Then D7106.DateBOMCom = Trim$(rs7106!K7106_DateBOMCom)
            If IsdbNull(rs7106!K7106_InchargeBOMUn) = False Then D7106.InchargeBOMUn = Trim$(rs7106!K7106_InchargeBOMUn)
            If IsdbNull(rs7106!K7106_DateBOMUn) = False Then D7106.DateBOMUn = Trim$(rs7106!K7106_DateBOMUn)
            If IsdbNull(rs7106!K7106_TimeBOMCom) = False Then D7106.TimeBOMCom = Trim$(rs7106!K7106_TimeBOMCom)
            If IsdbNull(rs7106!K7106_CheckCBD) = False Then D7106.CheckCBD = Trim$(rs7106!K7106_CheckCBD)
            If IsdbNull(rs7106!K7106_InchargeCBDCom) = False Then D7106.InchargeCBDCom = Trim$(rs7106!K7106_InchargeCBDCom)
            If IsdbNull(rs7106!K7106_DateCBDCom) = False Then D7106.DateCBDCom = Trim$(rs7106!K7106_DateCBDCom)
            If IsdbNull(rs7106!K7106_InchargeCBDUn) = False Then D7106.InchargeCBDUn = Trim$(rs7106!K7106_InchargeCBDUn)
            If IsdbNull(rs7106!K7106_DateCBDUn) = False Then D7106.DateCBDUn = Trim$(rs7106!K7106_DateCBDUn)
            If IsdbNull(rs7106!K7106_TimeCBDCom) = False Then D7106.TimeCBDCom = Trim$(rs7106!K7106_TimeCBDCom)
            If IsdbNull(rs7106!K7106_CheckCON) = False Then D7106.CheckCON = Trim$(rs7106!K7106_CheckCON)
            If IsdbNull(rs7106!K7106_InchargeCONCom) = False Then D7106.InchargeCONCom = Trim$(rs7106!K7106_InchargeCONCom)
            If IsdbNull(rs7106!K7106_DateCONCom) = False Then D7106.DateCONCom = Trim$(rs7106!K7106_DateCONCom)
            If IsdbNull(rs7106!K7106_InchargeCONUn) = False Then D7106.InchargeCONUn = Trim$(rs7106!K7106_InchargeCONUn)
            If IsdbNull(rs7106!K7106_DateCONUn) = False Then D7106.DateCONUn = Trim$(rs7106!K7106_DateCONUn)
            If IsdbNull(rs7106!K7106_TimeCONCom) = False Then D7106.TimeCONCom = Trim$(rs7106!K7106_TimeCONCom)
            If IsdbNull(rs7106!K7106_CheckFB) = False Then D7106.CheckFB = Trim$(rs7106!K7106_CheckFB)
            If IsdbNull(rs7106!K7106_CheckSameMold) = False Then D7106.CheckSameMold = Trim$(rs7106!K7106_CheckSameMold)
            If IsdbNull(rs7106!K7106_Remark) = False Then D7106.Remark = Trim$(rs7106!K7106_Remark)
            If IsdbNull(rs7106!K7106_seSite) = False Then D7106.seSite = Trim$(rs7106!K7106_seSite)
            If IsdbNull(rs7106!K7106_cdSite) = False Then D7106.cdSite = Trim$(rs7106!K7106_cdSite)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7106_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K7106_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7106 As T7106_AREA, Job As String, SHOESCODE As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7106_MOVE = False

        Try
            If READ_PFK7106(SHOESCODE) = True Then
                z7106 = D7106
                K7106_MOVE = True
            Else
                z7106 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7106")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "SHOESCODE" : z7106.ShoesCode = Children(i).Code
                                Case "SHOESCODEBASE" : z7106.ShoesCodeBase = Children(i).Code
                                Case "CUSTOMERCODE" : z7106.Customercode = Children(i).Code
                                Case "CUSTSPECNO" : z7106.CustSpecNo = Children(i).Code
                                Case "PRODUCTCODE" : z7106.ProductCode = Children(i).Code
                                Case "STYLE" : z7106.Style = Children(i).Code
                                Case "ARTICLE" : z7106.Article = Children(i).Code
                                Case "LINE" : z7106.Line = Children(i).Code
                                Case "MCODE" : z7106.MCODE = Children(i).Code
                                Case "COLORCODE" : z7106.ColorCode = Children(i).Code
                                Case "MCODENAME" : z7106.MCODEName = Children(i).Code
                                Case "COLORNAME" : z7106.ColorName = Children(i).Code
                                Case "VERALL" : z7106.VerALL = Children(i).Code
                                Case "VERSAM" : z7106.VerSAM = Children(i).Code
                                Case "VERBOM" : z7106.VerBOM = Children(i).Code
                                Case "VERCBD" : z7106.VerCBD = Children(i).Code
                                Case "VERROT" : z7106.VerROT = Children(i).Code
                                Case "VERJOB" : z7106.VerJOB = Children(i).Code
                                Case "CUSTSPECNO1" : z7106.CustSpecNo1 = Children(i).Code
                                Case "SEPRODUCTTYPE" : z7106.seProductType = Children(i).Code
                                Case "CDPRODUCTTYPE" : z7106.cdProductType = Children(i).Code
                                Case "SEPRODUCTSIZE" : z7106.seProductSize = Children(i).Code
                                Case "CDPRODUCTSIZE" : z7106.cdProductSize = Children(i).Code
                                Case "SESPECSTATE" : z7106.seSpecState = Children(i).Code
                                Case "CDSPECSTATE" : z7106.cdSpecState = Children(i).Code
                                Case "SZNO" : z7106.Szno = Children(i).Code
                                Case "SPECITICSIZE" : z7106.SpeciticSize = Children(i).Code
                                Case "SESEASON" : z7106.seSeason = Children(i).Code
                                Case "CDSEASON" : z7106.cdSeason = Children(i).Code
                                Case "SEGENDER" : z7106.seGender = Children(i).Code
                                Case "CDGENDER" : z7106.cdGender = Children(i).Code
                                Case "LASTCODE" : z7106.LastCode = Children(i).Code
                                Case "LASTWIDTH" : z7106.LastWidth = Children(i).Code
                                Case "LASTQTY" : z7106.LastQty = Children(i).Code
                                Case "QTYAVERAGE" : z7106.QtyAverage = Children(i).Code

                                Case "MOLDCODE" : z7106.MoldCode = Children(i).Code
                                Case "MOLDSPEC" : z7106.MoldSpec = Children(i).Code
                                Case "MOLDQTY" : z7106.MoldQty = Children(i).Code
                                Case "CUTTINGDIECODE" : z7106.CuttingDieCode = Children(i).Code
                                Case "TEXONCODE" : z7106.TexonCode = Children(i).Code
                                Case "TEXONCOLOR" : z7106.TexonColor = Children(i).Code
                                Case "INSOLECODE" : z7106.InsoleCode = Children(i).Code
                                Case "INSOLECOLOR" : z7106.InsoleColor = Children(i).Code
                                Case "OUTSOLECODE" : z7106.OutsoleCode = Children(i).Code
                                Case "OUTSOLECOLOR" : z7106.OutsoleColor = Children(i).Code
                                Case "OUTSOLECOLORCODE" : z7106.OutsoleColorCode = Children(i).Code
                                Case "MIDSOLECODE" : z7106.MidSoleCode = Children(i).Code
                                Case "MIDSOLECOLOR" : z7106.MidsoleColor = Children(i).Code
                                Case "LOGOCODE" : z7106.LogoCode = Children(i).Code
                                Case "LOGOCOLOR" : z7106.LogoColor = Children(i).Code
                                Case "LOGOCOLORCODE" : z7106.LogoColorCode = Children(i).Code
                                Case "SIZERANGE" : z7106.SizeRange = Children(i).Code
                                Case "NOTE0" : z7106.Note0 = Children(i).Code
                                Case "NOTE1" : z7106.Note1 = Children(i).Code
                                Case "NOTE2" : z7106.Note2 = Children(i).Code
                                Case "NOTE3" : z7106.Note3 = Children(i).Code
                                Case "NOTE4" : z7106.Note4 = Children(i).Code
                                Case "NOTE5" : z7106.Note5 = Children(i).Code
                                Case "NOTE6" : z7106.Note6 = Children(i).Code
                                Case "NOTE7" : z7106.Note7 = Children(i).Code
                                Case "NOTE8" : z7106.Note8 = Children(i).Code
                                Case "NOTE9" : z7106.Note9 = Children(i).Code
                                Case "NOTE10" : z7106.Note10 = Children(i).Code
                                Case "DATEEXCHANGEPRICE" : z7106.DateExchangePrice = Children(i).Code
                                Case "EXCHANGEPRICE" : z7106.ExchangePrice = Children(i).Code
                                Case "PRICEUSD" : z7106.PriceUSD = Children(i).Code
                                Case "PRICEVND" : z7106.PriceVND = Children(i).Code
                                Case "DATELABLE1" : z7106.DateLable1 = Children(i).Code
                                Case "DATELABLE2" : z7106.DateLable2 = Children(i).Code
                                Case "DATELABLE3" : z7106.DateLable3 = Children(i).Code
                                Case "DATEINSERT" : z7106.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z7106.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z7106.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z7106.InchargeUpdate = Children(i).Code
                                Case "INCHARGECBD_I" : z7106.InchargeCBD_I = Children(i).Code
                                Case "INCHARGECBD_U" : z7106.InchargeCBD_U = Children(i).Code
                                Case "INCHARGEBOM_I" : z7106.InchargeBOM_I = Children(i).Code
                                Case "INCHARGEBOM_U" : z7106.InchargeBOM_U = Children(i).Code
                                Case "INCHARGECON_I" : z7106.InchargeCON_I = Children(i).Code
                                Case "INCHARGECON_U" : z7106.InchargeCON_U = Children(i).Code

                                Case "INCHARGEDESINGER" : z7106.InchargeDesigner = Children(i).Code
                                Case "INCHARGESTEP1" : z7106.InchargeStep1 = Children(i).Code
                                Case "INCHARGESTEP2" : z7106.InchargeStep2 = Children(i).Code
                                Case "INCHARGESTEP3" : z7106.InchargeStep3 = Children(i).Code

                                Case "CHECKPARENT" : z7106.CheckParent = Children(i).Code
                                Case "SHOESPARENT" : z7106.ShoesParent = Children(i).Code
                                Case "CHECKUSE" : z7106.CheckUse = Children(i).Code
                                Case "TIMEINSERT" : z7106.TimeInsert = Children(i).Code
                                Case "TIMEUPDATE" : z7106.TimeUpdate = Children(i).Code
                                Case "CHECKCOMPLETE" : z7106.CheckComplete = Children(i).Code
                                Case "INCHARGECOMPLETE" : z7106.InchargeComplete = Children(i).Code
                                Case "DATECOMPLETE" : z7106.DateComplete = Children(i).Code
                                Case "INCHARGECOMPLETEUN" : z7106.InchargeCompleteUn = Children(i).Code
                                Case "DATECOMPLETEUN" : z7106.DateCompleteUn = Children(i).Code
                                Case "TIMECOMPLETE" : z7106.TimeComplete = Children(i).Code
                                Case "CHECKBOM" : z7106.CheckBOM = Children(i).Code
                                Case "INCHARGEBOMCOM" : z7106.InchargeBOMCom = Children(i).Code
                                Case "DATEBOMCOM" : z7106.DateBOMCom = Children(i).Code
                                Case "INCHARGEBOMUN" : z7106.InchargeBOMUn = Children(i).Code
                                Case "DATEBOMUN" : z7106.DateBOMUn = Children(i).Code
                                Case "TIMEBOMCOM" : z7106.TimeBOMCom = Children(i).Code
                                Case "CHECKCBD" : z7106.CheckCBD = Children(i).Code
                                Case "INCHARGECBDCOM" : z7106.InchargeCBDCom = Children(i).Code
                                Case "DATECBDCOM" : z7106.DateCBDCom = Children(i).Code
                                Case "INCHARGECBDUN" : z7106.InchargeCBDUn = Children(i).Code
                                Case "DATECBDUN" : z7106.DateCBDUn = Children(i).Code
                                Case "TIMECBDCOM" : z7106.TimeCBDCom = Children(i).Code
                                Case "CHECKCON" : z7106.CheckCON = Children(i).Code
                                Case "INCHARGECONCOM" : z7106.InchargeCONCom = Children(i).Code
                                Case "DATECONCOM" : z7106.DateCONCom = Children(i).Code
                                Case "INCHARGECONUN" : z7106.InchargeCONUn = Children(i).Code
                                Case "DATECONUN" : z7106.DateCONUn = Children(i).Code
                                Case "TIMECONCOM" : z7106.TimeCONCom = Children(i).Code
                                Case "CHECKFB" : z7106.CheckFB = Children(i).Code
                                Case "CHECKSAMEMOLD" : z7106.CheckSameMold = Children(i).Code
                                Case "REMARK" : z7106.Remark = Children(i).Code
                                Case "SESITE" : z7106.seSite = Children(i).Code
                                Case "CDSITE" : z7106.cdSite = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "SHOESCODE" : z7106.ShoesCode = Children(i).Data
                                Case "SHOESCODEBASE" : z7106.ShoesCodeBase = Children(i).Data
                                Case "CUSTOMERCODE" : z7106.Customercode = Children(i).Data
                                Case "CUSTSPECNO" : z7106.CustSpecNo = Children(i).Data
                                Case "PRODUCTCODE" : z7106.ProductCode = Children(i).Data
                                Case "STYLE" : z7106.Style = Children(i).Data
                                Case "ARTICLE" : z7106.Article = Children(i).Data
                                Case "LINE" : z7106.Line = Children(i).Data
                                Case "MCODE" : z7106.MCODE = Children(i).Data
                                Case "COLORCODE" : z7106.ColorCode = Children(i).Data
                                Case "MCODENAME" : z7106.MCODEName = Children(i).Data
                                Case "COLORNAME" : z7106.ColorName = Children(i).Data
                                Case "VERALL" : z7106.VerALL = Children(i).Data
                                Case "VERSAM" : z7106.VerSAM = Children(i).Data
                                Case "VERBOM" : z7106.VerBOM = Children(i).Data
                                Case "VERCBD" : z7106.VerCBD = Children(i).Data
                                Case "VERROT" : z7106.VerROT = Children(i).Data
                                Case "VERJOB" : z7106.VerJOB = Children(i).Data
                                Case "CUSTSPECNO1" : z7106.CustSpecNo1 = Children(i).Data
                                Case "SEPRODUCTTYPE" : z7106.seProductType = Children(i).Data
                                Case "CDPRODUCTTYPE" : z7106.cdProductType = Children(i).Data
                                Case "SEPRODUCTSIZE" : z7106.seProductSize = Children(i).Data
                                Case "CDPRODUCTSIZE" : z7106.cdProductSize = Children(i).Data
                                Case "SESPECSTATE" : z7106.seSpecState = Children(i).Data
                                Case "CDSPECSTATE" : z7106.cdSpecState = Children(i).Data
                                Case "SZNO" : z7106.Szno = Children(i).Data
                                Case "SPECITICSIZE" : z7106.SpeciticSize = Children(i).Data
                                Case "SESEASON" : z7106.seSeason = Children(i).Data
                                Case "CDSEASON" : z7106.cdSeason = Children(i).Data
                                Case "SEGENDER" : z7106.seGender = Children(i).Data
                                Case "CDGENDER" : z7106.cdGender = Children(i).Data
                                Case "LASTCODE" : z7106.LastCode = Children(i).Data
                                Case "LASTWIDTH" : z7106.LastWidth = Children(i).Data
                                Case "LASTQTY" : z7106.LastQty = CDecp(Children(i).Data)
                                Case "QTYAVERAGE" : z7106.QtyAverage = CDecp(Children(i).Data)
                                Case "MOLDCODE" : z7106.MoldCode = Children(i).Data
                                Case "MOLDSPEC" : z7106.MoldSpec = Children(i).Data
                                Case "MOLDQTY" : z7106.MoldQty = Cdecp(Children(i).Data)
                                Case "CUTTINGDIECODE" : z7106.CuttingDieCode = Children(i).Data
                                Case "TEXONCODE" : z7106.TexonCode = Children(i).Data
                                Case "TEXONCOLOR" : z7106.TexonColor = Children(i).Data
                                Case "INSOLECODE" : z7106.InsoleCode = Children(i).Data
                                Case "INSOLECOLOR" : z7106.InsoleColor = Children(i).Data
                                Case "OUTSOLECODE" : z7106.OutsoleCode = Children(i).Data
                                Case "OUTSOLECOLOR" : z7106.OutsoleColor = Children(i).Data
                                Case "OUTSOLECOLORCODE" : z7106.OutsoleColorCode = Children(i).Data
                                Case "MIDSOLECODE" : z7106.MidSoleCode = Children(i).Data
                                Case "MIDSOLECOLOR" : z7106.MidsoleColor = Children(i).Data
                                Case "LOGOCODE" : z7106.LogoCode = Children(i).Data
                                Case "LOGOCOLOR" : z7106.LogoColor = Children(i).Data
                                Case "LOGOCOLORCODE" : z7106.LogoColorCode = Children(i).Data
                                Case "SIZERANGE" : z7106.SizeRange = Children(i).Data
                                Case "NOTE0" : z7106.Note0 = Children(i).Data
                                Case "NOTE1" : z7106.Note1 = Children(i).Data
                                Case "NOTE2" : z7106.Note2 = Children(i).Data
                                Case "NOTE3" : z7106.Note3 = Children(i).Data
                                Case "NOTE4" : z7106.Note4 = Children(i).Data
                                Case "NOTE5" : z7106.Note5 = Children(i).Data
                                Case "NOTE6" : z7106.Note6 = Children(i).Data
                                Case "NOTE7" : z7106.Note7 = Children(i).Data
                                Case "NOTE8" : z7106.Note8 = Children(i).Data
                                Case "NOTE9" : z7106.Note9 = Children(i).Data
                                Case "NOTE10" : z7106.Note10 = Children(i).Data
                                Case "DATEEXCHANGEPRICE" : z7106.DateExchangePrice = Children(i).Data
                                Case "EXCHANGEPRICE" : z7106.ExchangePrice = Cdecp(Children(i).Data)
                                Case "PRICEUSD" : z7106.PriceUSD = Cdecp(Children(i).Data)
                                Case "PRICEVND" : z7106.PriceVND = Cdecp(Children(i).Data)
                                Case "DATELABLE1" : z7106.DateLable1 = Children(i).Data
                                Case "DATELABLE2" : z7106.DateLable2 = Children(i).Data
                                Case "DATELABLE3" : z7106.DateLable3 = Children(i).Data
                                Case "DATEINSERT" : z7106.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z7106.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z7106.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z7106.InchargeUpdate = Children(i).Data
                                Case "INCHARGECBD_I" : z7106.InchargeCBD_I = Children(i).Data
                                Case "INCHARGECBD_U" : z7106.InchargeCBD_U = Children(i).Data
                                Case "INCHARGEBOM_I" : z7106.InchargeBOM_I = Children(i).Data
                                Case "INCHARGEBOM_U" : z7106.InchargeBOM_U = Children(i).Data
                                Case "INCHARGECON_I" : z7106.InchargeCON_I = Children(i).Data
                                Case "INCHARGECON_U" : z7106.InchargeCON_U = Children(i).Data

                                Case "INCHARGEDESINGER" : z7106.InchargeDesigner = Children(i).Data
                                Case "INCHARGESTEP1" : z7106.InchargeStep1 = Children(i).Data
                                Case "INCHARGESTEP2" : z7106.InchargeStep2 = Children(i).Data
                                Case "INCHARGESTEP3" : z7106.InchargeStep3 = Children(i).Data

                                Case "CHECKPARENT" : z7106.CheckParent = Children(i).Data
                                Case "SHOESPARENT" : z7106.ShoesParent = Children(i).Data
                                Case "CHECKUSE" : z7106.CheckUse = Children(i).Data
                                Case "TIMEINSERT" : z7106.TimeInsert = Children(i).Data
                                Case "TIMEUPDATE" : z7106.TimeUpdate = Children(i).Data
                                Case "CHECKCOMPLETE" : z7106.CheckComplete = Children(i).Data
                                Case "INCHARGECOMPLETE" : z7106.InchargeComplete = Children(i).Data
                                Case "DATECOMPLETE" : z7106.DateComplete = Children(i).Data
                                Case "INCHARGECOMPLETEUN" : z7106.InchargeCompleteUn = Children(i).Data
                                Case "DATECOMPLETEUN" : z7106.DateCompleteUn = Children(i).Data
                                Case "TIMECOMPLETE" : z7106.TimeComplete = Children(i).Data
                                Case "CHECKBOM" : z7106.CheckBOM = Children(i).Data
                                Case "INCHARGEBOMCOM" : z7106.InchargeBOMCom = Children(i).Data
                                Case "DATEBOMCOM" : z7106.DateBOMCom = Children(i).Data
                                Case "INCHARGEBOMUN" : z7106.InchargeBOMUn = Children(i).Data
                                Case "DATEBOMUN" : z7106.DateBOMUn = Children(i).Data
                                Case "TIMEBOMCOM" : z7106.TimeBOMCom = Children(i).Data
                                Case "CHECKCBD" : z7106.CheckCBD = Children(i).Data
                                Case "INCHARGECBDCOM" : z7106.InchargeCBDCom = Children(i).Data
                                Case "DATECBDCOM" : z7106.DateCBDCom = Children(i).Data
                                Case "INCHARGECBDUN" : z7106.InchargeCBDUn = Children(i).Data
                                Case "DATECBDUN" : z7106.DateCBDUn = Children(i).Data
                                Case "TIMECBDCOM" : z7106.TimeCBDCom = Children(i).Data
                                Case "CHECKCON" : z7106.CheckCON = Children(i).Data
                                Case "INCHARGECONCOM" : z7106.InchargeCONCom = Children(i).Data
                                Case "DATECONCOM" : z7106.DateCONCom = Children(i).Data
                                Case "INCHARGECONUN" : z7106.InchargeCONUn = Children(i).Data
                                Case "DATECONUN" : z7106.DateCONUn = Children(i).Data
                                Case "TIMECONCOM" : z7106.TimeCONCom = Children(i).Data
                                Case "CHECKFB" : z7106.CheckFB = Children(i).Data
                                Case "CHECKSAMEMOLD" : z7106.CheckSameMold = Children(i).Data
                                Case "REMARK" : z7106.Remark = Children(i).Data
                                Case "SESITE" : z7106.seSite = Children(i).Data
                                Case "CDSITE" : z7106.cdSite = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7106_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K7106_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7106 As T7106_AREA, Job As String, CheckClear As Boolean, SHOESCODE As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7106_MOVE = False

        Try
            If READ_PFK7106(SHOESCODE) = True Then
                z7106 = D7106
                K7106_MOVE = True
            Else
                If CheckClear = True Then z7106 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7106")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "SHOESCODE" : z7106.ShoesCode = Children(i).Code
                                Case "SHOESCODEBASE" : z7106.ShoesCodeBase = Children(i).Code
                                Case "CUSTOMERCODE" : z7106.Customercode = Children(i).Code
                                Case "CUSTSPECNO" : z7106.CustSpecNo = Children(i).Code
                                Case "PRODUCTCODE" : z7106.ProductCode = Children(i).Code
                                Case "STYLE" : z7106.Style = Children(i).Code
                                Case "ARTICLE" : z7106.Article = Children(i).Code
                                Case "LINE" : z7106.Line = Children(i).Code
                                Case "MCODE" : z7106.MCODE = Children(i).Code
                                Case "COLORCODE" : z7106.ColorCode = Children(i).Code
                                Case "MCODENAME" : z7106.MCODEName = Children(i).Code
                                Case "COLORNAME" : z7106.ColorName = Children(i).Code
                                Case "VERALL" : z7106.VerALL = Children(i).Code
                                Case "VERSAM" : z7106.VerSAM = Children(i).Code
                                Case "VERBOM" : z7106.VerBOM = Children(i).Code
                                Case "VERCBD" : z7106.VerCBD = Children(i).Code
                                Case "VERROT" : z7106.VerROT = Children(i).Code
                                Case "VERJOB" : z7106.VerJOB = Children(i).Code
                                Case "CUSTSPECNO1" : z7106.CustSpecNo1 = Children(i).Code
                                Case "SEPRODUCTTYPE" : z7106.seProductType = Children(i).Code
                                Case "CDPRODUCTTYPE" : z7106.cdProductType = Children(i).Code
                                Case "SEPRODUCTSIZE" : z7106.seProductSize = Children(i).Code
                                Case "CDPRODUCTSIZE" : z7106.cdProductSize = Children(i).Code
                                Case "SESPECSTATE" : z7106.seSpecState = Children(i).Code
                                Case "CDSPECSTATE" : z7106.cdSpecState = Children(i).Code
                                Case "SZNO" : z7106.Szno = Children(i).Code
                                Case "SPECITICSIZE" : z7106.SpeciticSize = Children(i).Code
                                Case "SESEASON" : z7106.seSeason = Children(i).Code
                                Case "CDSEASON" : z7106.cdSeason = Children(i).Code
                                Case "SEGENDER" : z7106.seGender = Children(i).Code
                                Case "CDGENDER" : z7106.cdGender = Children(i).Code
                                Case "LASTCODE" : z7106.LastCode = Children(i).Code
                                Case "LASTWIDTH" : z7106.LastWidth = Children(i).Code
                                Case "LASTQTY" : z7106.LastQty = Children(i).Code
                                Case "QTYAVERAGE" : z7106.QtyAverage = Children(i).Code
                                Case "MOLDCODE" : z7106.MoldCode = Children(i).Code
                                Case "MOLDSPEC" : z7106.MoldSpec = Children(i).Code
                                Case "MOLDQTY" : z7106.MoldQty = Children(i).Code
                                Case "CUTTINGDIECODE" : z7106.CuttingDieCode = Children(i).Code
                                Case "TEXONCODE" : z7106.TexonCode = Children(i).Code
                                Case "TEXONCOLOR" : z7106.TexonColor = Children(i).Code
                                Case "INSOLECODE" : z7106.InsoleCode = Children(i).Code
                                Case "INSOLECOLOR" : z7106.InsoleColor = Children(i).Code
                                Case "OUTSOLECODE" : z7106.OutsoleCode = Children(i).Code
                                Case "OUTSOLECOLOR" : z7106.OutsoleColor = Children(i).Code
                                Case "OUTSOLECOLORCODE" : z7106.OutsoleColorCode = Children(i).Code
                                Case "MIDSOLECODE" : z7106.MidSoleCode = Children(i).Code
                                Case "MIDSOLECOLOR" : z7106.MidsoleColor = Children(i).Code
                                Case "LOGOCODE" : z7106.LogoCode = Children(i).Code
                                Case "LOGOCOLOR" : z7106.LogoColor = Children(i).Code
                                Case "LOGOCOLORCODE" : z7106.LogoColorCode = Children(i).Code
                                Case "SIZERANGE" : z7106.SizeRange = Children(i).Code
                                Case "NOTE0" : z7106.Note0 = Children(i).Code
                                Case "NOTE1" : z7106.Note1 = Children(i).Code
                                Case "NOTE2" : z7106.Note2 = Children(i).Code
                                Case "NOTE3" : z7106.Note3 = Children(i).Code
                                Case "NOTE4" : z7106.Note4 = Children(i).Code
                                Case "NOTE5" : z7106.Note5 = Children(i).Code
                                Case "NOTE6" : z7106.Note6 = Children(i).Code
                                Case "NOTE7" : z7106.Note7 = Children(i).Code
                                Case "NOTE8" : z7106.Note8 = Children(i).Code
                                Case "NOTE9" : z7106.Note9 = Children(i).Code
                                Case "NOTE10" : z7106.Note10 = Children(i).Code
                                Case "DATEEXCHANGEPRICE" : z7106.DateExchangePrice = Children(i).Code
                                Case "EXCHANGEPRICE" : z7106.ExchangePrice = Children(i).Code
                                Case "PRICEUSD" : z7106.PriceUSD = Children(i).Code
                                Case "PRICEVND" : z7106.PriceVND = Children(i).Code
                                Case "DATELABLE1" : z7106.DateLable1 = Children(i).Code
                                Case "DATELABLE2" : z7106.DateLable2 = Children(i).Code
                                Case "DATELABLE3" : z7106.DateLable3 = Children(i).Code
                                Case "DATEINSERT" : z7106.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z7106.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z7106.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z7106.InchargeUpdate = Children(i).Code
                                Case "INCHARGECBD_I" : z7106.InchargeCBD_I = Children(i).Code
                                Case "INCHARGECBD_U" : z7106.InchargeCBD_U = Children(i).Code
                                Case "INCHARGEBOM_I" : z7106.InchargeBOM_I = Children(i).Code
                                Case "INCHARGEBOM_U" : z7106.InchargeBOM_U = Children(i).Code
                                Case "INCHARGECON_I" : z7106.InchargeCON_I = Children(i).Code
                                Case "INCHARGECON_U" : z7106.InchargeCON_U = Children(i).Code

                                Case "INCHARGEDESINGER" : z7106.InchargeDesigner = Children(i).Code
                                Case "INCHARGESTEP1" : z7106.InchargeStep1 = Children(i).Code
                                Case "INCHARGESTEP2" : z7106.InchargeStep2 = Children(i).Code
                                Case "INCHARGESTEP3" : z7106.InchargeStep3 = Children(i).Code


                                Case "CHECKPARENT" : z7106.CheckParent = Children(i).Code
                                Case "SHOESPARENT" : z7106.ShoesParent = Children(i).Code
                                Case "CHECKUSE" : z7106.CheckUse = Children(i).Code
                                Case "TIMEINSERT" : z7106.TimeInsert = Children(i).Code
                                Case "TIMEUPDATE" : z7106.TimeUpdate = Children(i).Code
                                Case "CHECKCOMPLETE" : z7106.CheckComplete = Children(i).Code
                                Case "INCHARGECOMPLETE" : z7106.InchargeComplete = Children(i).Code
                                Case "DATECOMPLETE" : z7106.DateComplete = Children(i).Code
                                Case "INCHARGECOMPLETEUN" : z7106.InchargeCompleteUn = Children(i).Code
                                Case "DATECOMPLETEUN" : z7106.DateCompleteUn = Children(i).Code
                                Case "TIMECOMPLETE" : z7106.TimeComplete = Children(i).Code
                                Case "CHECKBOM" : z7106.CheckBOM = Children(i).Code
                                Case "INCHARGEBOMCOM" : z7106.InchargeBOMCom = Children(i).Code
                                Case "DATEBOMCOM" : z7106.DateBOMCom = Children(i).Code
                                Case "INCHARGEBOMUN" : z7106.InchargeBOMUn = Children(i).Code
                                Case "DATEBOMUN" : z7106.DateBOMUn = Children(i).Code
                                Case "TIMEBOMCOM" : z7106.TimeBOMCom = Children(i).Code
                                Case "CHECKCBD" : z7106.CheckCBD = Children(i).Code
                                Case "INCHARGECBDCOM" : z7106.InchargeCBDCom = Children(i).Code
                                Case "DATECBDCOM" : z7106.DateCBDCom = Children(i).Code
                                Case "INCHARGECBDUN" : z7106.InchargeCBDUn = Children(i).Code
                                Case "DATECBDUN" : z7106.DateCBDUn = Children(i).Code
                                Case "TIMECBDCOM" : z7106.TimeCBDCom = Children(i).Code
                                Case "CHECKCON" : z7106.CheckCON = Children(i).Code
                                Case "INCHARGECONCOM" : z7106.InchargeCONCom = Children(i).Code
                                Case "DATECONCOM" : z7106.DateCONCom = Children(i).Code
                                Case "INCHARGECONUN" : z7106.InchargeCONUn = Children(i).Code
                                Case "DATECONUN" : z7106.DateCONUn = Children(i).Code
                                Case "TIMECONCOM" : z7106.TimeCONCom = Children(i).Code
                                Case "CHECKFB" : z7106.CheckFB = Children(i).Code
                                Case "CHECKSAMEMOLD" : z7106.CheckSameMold = Children(i).Code
                                Case "REMARK" : z7106.Remark = Children(i).Code
                                Case "SESITE" : z7106.seSite = Children(i).Code
                                Case "CDSITE" : z7106.cdSite = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "SHOESCODE" : z7106.ShoesCode = Children(i).Data
                                Case "SHOESCODEBASE" : z7106.ShoesCodeBase = Children(i).Data
                                Case "CUSTOMERCODE" : z7106.Customercode = Children(i).Data
                                Case "CUSTSPECNO" : z7106.CustSpecNo = Children(i).Data
                                Case "PRODUCTCODE" : z7106.ProductCode = Children(i).Data
                                Case "STYLE" : z7106.Style = Children(i).Data
                                Case "ARTICLE" : z7106.Article = Children(i).Data
                                Case "LINE" : z7106.Line = Children(i).Data
                                Case "MCODE" : z7106.MCODE = Children(i).Data
                                Case "COLORCODE" : z7106.ColorCode = Children(i).Data
                                Case "MCODENAME" : z7106.MCODEName = Children(i).Data
                                Case "COLORNAME" : z7106.ColorName = Children(i).Data
                                Case "VERALL" : z7106.VerALL = Children(i).Data
                                Case "VERSAM" : z7106.VerSAM = Children(i).Data
                                Case "VERBOM" : z7106.VerBOM = Children(i).Data
                                Case "VERCBD" : z7106.VerCBD = Children(i).Data
                                Case "VERROT" : z7106.VerROT = Children(i).Data
                                Case "VERJOB" : z7106.VerJOB = Children(i).Data
                                Case "CUSTSPECNO1" : z7106.CustSpecNo1 = Children(i).Data
                                Case "SEPRODUCTTYPE" : z7106.seProductType = Children(i).Data
                                Case "CDPRODUCTTYPE" : z7106.cdProductType = Children(i).Data
                                Case "SEPRODUCTSIZE" : z7106.seProductSize = Children(i).Data
                                Case "CDPRODUCTSIZE" : z7106.cdProductSize = Children(i).Data
                                Case "SESPECSTATE" : z7106.seSpecState = Children(i).Data
                                Case "CDSPECSTATE" : z7106.cdSpecState = Children(i).Data
                                Case "SZNO" : z7106.Szno = Children(i).Data
                                Case "SPECITICSIZE" : z7106.SpeciticSize = Children(i).Data
                                Case "SESEASON" : z7106.seSeason = Children(i).Data
                                Case "CDSEASON" : z7106.cdSeason = Children(i).Data
                                Case "SEGENDER" : z7106.seGender = Children(i).Data
                                Case "CDGENDER" : z7106.cdGender = Children(i).Data
                                Case "LASTCODE" : z7106.LastCode = Children(i).Data
                                Case "LASTWIDTH" : z7106.LastWidth = Children(i).Data
                                Case "LASTQTY" : z7106.LastQty = CDecp(Children(i).Data)
                                Case "QTYAVERAGE" : z7106.QtyAverage = CDecp(Children(i).Data)
                                Case "MOLDCODE" : z7106.MoldCode = Children(i).Data
                                Case "MOLDSPEC" : z7106.MoldSpec = Children(i).Data
                                Case "MOLDQTY" : z7106.MoldQty = Cdecp(Children(i).Data)
                                Case "CUTTINGDIECODE" : z7106.CuttingDieCode = Children(i).Data
                                Case "TEXONCODE" : z7106.TexonCode = Children(i).Data
                                Case "TEXONCOLOR" : z7106.TexonColor = Children(i).Data
                                Case "INSOLECODE" : z7106.InsoleCode = Children(i).Data
                                Case "INSOLECOLOR" : z7106.InsoleColor = Children(i).Data
                                Case "OUTSOLECODE" : z7106.OutsoleCode = Children(i).Data
                                Case "OUTSOLECOLOR" : z7106.OutsoleColor = Children(i).Data
                                Case "OUTSOLECOLORCODE" : z7106.OutsoleColorCode = Children(i).Data
                                Case "MIDSOLECODE" : z7106.MidSoleCode = Children(i).Data
                                Case "MIDSOLECOLOR" : z7106.MidsoleColor = Children(i).Data
                                Case "LOGOCODE" : z7106.LogoCode = Children(i).Data
                                Case "LOGOCOLOR" : z7106.LogoColor = Children(i).Data
                                Case "LOGOCOLORCODE" : z7106.LogoColorCode = Children(i).Data
                                Case "SIZERANGE" : z7106.SizeRange = Children(i).Data
                                Case "NOTE0" : z7106.Note0 = Children(i).Data
                                Case "NOTE1" : z7106.Note1 = Children(i).Data
                                Case "NOTE2" : z7106.Note2 = Children(i).Data
                                Case "NOTE3" : z7106.Note3 = Children(i).Data
                                Case "NOTE4" : z7106.Note4 = Children(i).Data
                                Case "NOTE5" : z7106.Note5 = Children(i).Data
                                Case "NOTE6" : z7106.Note6 = Children(i).Data
                                Case "NOTE7" : z7106.Note7 = Children(i).Data
                                Case "NOTE8" : z7106.Note8 = Children(i).Data
                                Case "NOTE9" : z7106.Note9 = Children(i).Data
                                Case "NOTE10" : z7106.Note10 = Children(i).Data
                                Case "DATEEXCHANGEPRICE" : z7106.DateExchangePrice = Children(i).Data
                                Case "EXCHANGEPRICE" : z7106.ExchangePrice = Cdecp(Children(i).Data)
                                Case "PRICEUSD" : z7106.PriceUSD = Cdecp(Children(i).Data)
                                Case "PRICEVND" : z7106.PriceVND = Cdecp(Children(i).Data)
                                Case "DATELABLE1" : z7106.DateLable1 = Children(i).Data
                                Case "DATELABLE2" : z7106.DateLable2 = Children(i).Data
                                Case "DATELABLE3" : z7106.DateLable3 = Children(i).Data
                                Case "DATEINSERT" : z7106.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z7106.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z7106.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z7106.InchargeUpdate = Children(i).Data
                                Case "INCHARGECBD_I" : z7106.InchargeCBD_I = Children(i).Data
                                Case "INCHARGECBD_U" : z7106.InchargeCBD_U = Children(i).Data
                                Case "INCHARGEBOM_I" : z7106.InchargeBOM_I = Children(i).Data
                                Case "INCHARGEBOM_U" : z7106.InchargeBOM_U = Children(i).Data
                                Case "INCHARGECON_I" : z7106.InchargeCON_I = Children(i).Data
                                Case "INCHARGECON_U" : z7106.InchargeCON_U = Children(i).Data


                                Case "INCHARGEDESINGER" : z7106.InchargeDesigner = Children(i).Data
                                Case "INCHARGESTEP1" : z7106.InchargeStep1 = Children(i).Data
                                Case "INCHARGESTEP2" : z7106.InchargeStep2 = Children(i).Data
                                Case "INCHARGESTEP3" : z7106.InchargeStep3 = Children(i).Data

                                Case "CHECKPARENT" : z7106.CheckParent = Children(i).Data
                                Case "SHOESPARENT" : z7106.ShoesParent = Children(i).Data
                                Case "CHECKUSE" : z7106.CheckUse = Children(i).Data
                                Case "TIMEINSERT" : z7106.TimeInsert = Children(i).Data
                                Case "TIMEUPDATE" : z7106.TimeUpdate = Children(i).Data
                                Case "CHECKCOMPLETE" : z7106.CheckComplete = Children(i).Data
                                Case "INCHARGECOMPLETE" : z7106.InchargeComplete = Children(i).Data
                                Case "DATECOMPLETE" : z7106.DateComplete = Children(i).Data
                                Case "INCHARGECOMPLETEUN" : z7106.InchargeCompleteUn = Children(i).Data
                                Case "DATECOMPLETEUN" : z7106.DateCompleteUn = Children(i).Data
                                Case "TIMECOMPLETE" : z7106.TimeComplete = Children(i).Data
                                Case "CHECKBOM" : z7106.CheckBOM = Children(i).Data
                                Case "INCHARGEBOMCOM" : z7106.InchargeBOMCom = Children(i).Data
                                Case "DATEBOMCOM" : z7106.DateBOMCom = Children(i).Data
                                Case "INCHARGEBOMUN" : z7106.InchargeBOMUn = Children(i).Data
                                Case "DATEBOMUN" : z7106.DateBOMUn = Children(i).Data
                                Case "TIMEBOMCOM" : z7106.TimeBOMCom = Children(i).Data
                                Case "CHECKCBD" : z7106.CheckCBD = Children(i).Data
                                Case "INCHARGECBDCOM" : z7106.InchargeCBDCom = Children(i).Data
                                Case "DATECBDCOM" : z7106.DateCBDCom = Children(i).Data
                                Case "INCHARGECBDUN" : z7106.InchargeCBDUn = Children(i).Data
                                Case "DATECBDUN" : z7106.DateCBDUn = Children(i).Data
                                Case "TIMECBDCOM" : z7106.TimeCBDCom = Children(i).Data
                                Case "CHECKCON" : z7106.CheckCON = Children(i).Data
                                Case "INCHARGECONCOM" : z7106.InchargeCONCom = Children(i).Data
                                Case "DATECONCOM" : z7106.DateCONCom = Children(i).Data
                                Case "INCHARGECONUN" : z7106.InchargeCONUn = Children(i).Data
                                Case "DATECONUN" : z7106.DateCONUn = Children(i).Data
                                Case "TIMECONCOM" : z7106.TimeCONCom = Children(i).Data
                                Case "CHECKFB" : z7106.CheckFB = Children(i).Data
                                Case "CHECKSAMEMOLD" : z7106.CheckSameMold = Children(i).Data
                                Case "REMARK" : z7106.Remark = Children(i).Data
                                Case "SESITE" : z7106.seSite = Children(i).Data
                                Case "CDSITE" : z7106.cdSite = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7106_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW AREA
    '=========================================================================================================================================================
    Public Sub K7106_MOVE(ByRef a7106 As T7106_AREA, ByRef b7106 As T7106_AREA)
        Try
            If trim$(a7106.ShoesCode) = "" Then b7106.ShoesCode = "" Else b7106.ShoesCode = a7106.ShoesCode
            If trim$(a7106.ShoesCodeBase) = "" Then b7106.ShoesCodeBase = "" Else b7106.ShoesCodeBase = a7106.ShoesCodeBase
            If trim$(a7106.Customercode) = "" Then b7106.Customercode = "" Else b7106.Customercode = a7106.Customercode
            If trim$(a7106.CustSpecNo) = "" Then b7106.CustSpecNo = "" Else b7106.CustSpecNo = a7106.CustSpecNo
            If trim$(a7106.ProductCode) = "" Then b7106.ProductCode = "" Else b7106.ProductCode = a7106.ProductCode
            If trim$(a7106.Style) = "" Then b7106.Style = "" Else b7106.Style = a7106.Style
            If trim$(a7106.Article) = "" Then b7106.Article = "" Else b7106.Article = a7106.Article
            If trim$(a7106.Line) = "" Then b7106.Line = "" Else b7106.Line = a7106.Line
            If trim$(a7106.MCODE) = "" Then b7106.MCODE = "" Else b7106.MCODE = a7106.MCODE
            If trim$(a7106.ColorCode) = "" Then b7106.ColorCode = "" Else b7106.ColorCode = a7106.ColorCode
            If trim$(a7106.MCODEName) = "" Then b7106.MCODEName = "" Else b7106.MCODEName = a7106.MCODEName
            If trim$(a7106.ColorName) = "" Then b7106.ColorName = "" Else b7106.ColorName = a7106.ColorName
            If trim$(a7106.VerALL) = "" Then b7106.VerALL = "" Else b7106.VerALL = a7106.VerALL
            If trim$(a7106.VerSAM) = "" Then b7106.VerSAM = "" Else b7106.VerSAM = a7106.VerSAM
            If trim$(a7106.VerBOM) = "" Then b7106.VerBOM = "" Else b7106.VerBOM = a7106.VerBOM
            If trim$(a7106.VerCBD) = "" Then b7106.VerCBD = "" Else b7106.VerCBD = a7106.VerCBD
            If trim$(a7106.VerROT) = "" Then b7106.VerROT = "" Else b7106.VerROT = a7106.VerROT
            If trim$(a7106.VerJOB) = "" Then b7106.VerJOB = "" Else b7106.VerJOB = a7106.VerJOB
            If trim$(a7106.CustSpecNo1) = "" Then b7106.CustSpecNo1 = "" Else b7106.CustSpecNo1 = a7106.CustSpecNo1
            If trim$(a7106.seProductType) = "" Then b7106.seProductType = "" Else b7106.seProductType = a7106.seProductType
            If trim$(a7106.cdProductType) = "" Then b7106.cdProductType = "" Else b7106.cdProductType = a7106.cdProductType
            If trim$(a7106.seProductSize) = "" Then b7106.seProductSize = "" Else b7106.seProductSize = a7106.seProductSize
            If trim$(a7106.cdProductSize) = "" Then b7106.cdProductSize = "" Else b7106.cdProductSize = a7106.cdProductSize
            If trim$(a7106.seSpecState) = "" Then b7106.seSpecState = "" Else b7106.seSpecState = a7106.seSpecState
            If trim$(a7106.cdSpecState) = "" Then b7106.cdSpecState = "" Else b7106.cdSpecState = a7106.cdSpecState
            If trim$(a7106.Szno) = "" Then b7106.Szno = "" Else b7106.Szno = a7106.Szno
            If trim$(a7106.SpeciticSize) = "" Then b7106.SpeciticSize = "" Else b7106.SpeciticSize = a7106.SpeciticSize
            If trim$(a7106.seSeason) = "" Then b7106.seSeason = "" Else b7106.seSeason = a7106.seSeason
            If trim$(a7106.cdSeason) = "" Then b7106.cdSeason = "" Else b7106.cdSeason = a7106.cdSeason
            If trim$(a7106.seGender) = "" Then b7106.seGender = "" Else b7106.seGender = a7106.seGender
            If trim$(a7106.cdGender) = "" Then b7106.cdGender = "" Else b7106.cdGender = a7106.cdGender
            If trim$(a7106.LastCode) = "" Then b7106.LastCode = "" Else b7106.LastCode = a7106.LastCode
            If trim$(a7106.LastWidth) = "" Then b7106.LastWidth = "" Else b7106.LastWidth = a7106.LastWidth
            If Trim$(a7106.LastQty) = "" Then b7106.LastQty = "" Else b7106.LastQty = a7106.LastQty
            If Trim$(a7106.QtyAverage) = "" Then b7106.QtyAverage = "" Else b7106.QtyAverage = a7106.QtyAverage

            If trim$(a7106.MoldCode) = "" Then b7106.MoldCode = "" Else b7106.MoldCode = a7106.MoldCode
            If trim$(a7106.MoldSpec) = "" Then b7106.MoldSpec = "" Else b7106.MoldSpec = a7106.MoldSpec
            If trim$(a7106.MoldQty) = "" Then b7106.MoldQty = "" Else b7106.MoldQty = a7106.MoldQty
            If trim$(a7106.CuttingDieCode) = "" Then b7106.CuttingDieCode = "" Else b7106.CuttingDieCode = a7106.CuttingDieCode
            If trim$(a7106.TexonCode) = "" Then b7106.TexonCode = "" Else b7106.TexonCode = a7106.TexonCode
            If trim$(a7106.TexonColor) = "" Then b7106.TexonColor = "" Else b7106.TexonColor = a7106.TexonColor
            If trim$(a7106.InsoleCode) = "" Then b7106.InsoleCode = "" Else b7106.InsoleCode = a7106.InsoleCode
            If trim$(a7106.InsoleColor) = "" Then b7106.InsoleColor = "" Else b7106.InsoleColor = a7106.InsoleColor
            If trim$(a7106.OutsoleCode) = "" Then b7106.OutsoleCode = "" Else b7106.OutsoleCode = a7106.OutsoleCode
            If trim$(a7106.OutsoleColor) = "" Then b7106.OutsoleColor = "" Else b7106.OutsoleColor = a7106.OutsoleColor
            If trim$(a7106.OutsoleColorCode) = "" Then b7106.OutsoleColorCode = "" Else b7106.OutsoleColorCode = a7106.OutsoleColorCode
            If trim$(a7106.MidSoleCode) = "" Then b7106.MidSoleCode = "" Else b7106.MidSoleCode = a7106.MidSoleCode
            If trim$(a7106.MidsoleColor) = "" Then b7106.MidsoleColor = "" Else b7106.MidsoleColor = a7106.MidsoleColor
            If trim$(a7106.LogoCode) = "" Then b7106.LogoCode = "" Else b7106.LogoCode = a7106.LogoCode
            If trim$(a7106.LogoColor) = "" Then b7106.LogoColor = "" Else b7106.LogoColor = a7106.LogoColor
            If trim$(a7106.LogoColorCode) = "" Then b7106.LogoColorCode = "" Else b7106.LogoColorCode = a7106.LogoColorCode
            If trim$(a7106.SizeRange) = "" Then b7106.SizeRange = "" Else b7106.SizeRange = a7106.SizeRange
            If trim$(a7106.Note0) = "" Then b7106.Note0 = "" Else b7106.Note0 = a7106.Note0
            If trim$(a7106.Note1) = "" Then b7106.Note1 = "" Else b7106.Note1 = a7106.Note1
            If trim$(a7106.Note2) = "" Then b7106.Note2 = "" Else b7106.Note2 = a7106.Note2
            If trim$(a7106.Note3) = "" Then b7106.Note3 = "" Else b7106.Note3 = a7106.Note3
            If trim$(a7106.Note4) = "" Then b7106.Note4 = "" Else b7106.Note4 = a7106.Note4
            If trim$(a7106.Note5) = "" Then b7106.Note5 = "" Else b7106.Note5 = a7106.Note5
            If trim$(a7106.Note6) = "" Then b7106.Note6 = "" Else b7106.Note6 = a7106.Note6
            If trim$(a7106.Note7) = "" Then b7106.Note7 = "" Else b7106.Note7 = a7106.Note7
            If trim$(a7106.Note8) = "" Then b7106.Note8 = "" Else b7106.Note8 = a7106.Note8
            If trim$(a7106.Note9) = "" Then b7106.Note9 = "" Else b7106.Note9 = a7106.Note9
            If trim$(a7106.Note10) = "" Then b7106.Note10 = "" Else b7106.Note10 = a7106.Note10
            If trim$(a7106.DateExchangePrice) = "" Then b7106.DateExchangePrice = "" Else b7106.DateExchangePrice = a7106.DateExchangePrice
            If trim$(a7106.ExchangePrice) = "" Then b7106.ExchangePrice = "" Else b7106.ExchangePrice = a7106.ExchangePrice
            If trim$(a7106.PriceUSD) = "" Then b7106.PriceUSD = "" Else b7106.PriceUSD = a7106.PriceUSD
            If trim$(a7106.PriceVND) = "" Then b7106.PriceVND = "" Else b7106.PriceVND = a7106.PriceVND
            If trim$(a7106.DateLable1) = "" Then b7106.DateLable1 = "" Else b7106.DateLable1 = a7106.DateLable1
            If trim$(a7106.DateLable2) = "" Then b7106.DateLable2 = "" Else b7106.DateLable2 = a7106.DateLable2
            If trim$(a7106.DateLable3) = "" Then b7106.DateLable3 = "" Else b7106.DateLable3 = a7106.DateLable3
            If trim$(a7106.DateInsert) = "" Then b7106.DateInsert = "" Else b7106.DateInsert = a7106.DateInsert
            If trim$(a7106.DateUpdate) = "" Then b7106.DateUpdate = "" Else b7106.DateUpdate = a7106.DateUpdate
            If trim$(a7106.InchargeInsert) = "" Then b7106.InchargeInsert = "" Else b7106.InchargeInsert = a7106.InchargeInsert
            If trim$(a7106.InchargeUpdate) = "" Then b7106.InchargeUpdate = "" Else b7106.InchargeUpdate = a7106.InchargeUpdate
            If trim$(a7106.InchargeCBD_I) = "" Then b7106.InchargeCBD_I = "" Else b7106.InchargeCBD_I = a7106.InchargeCBD_I
            If trim$(a7106.InchargeCBD_U) = "" Then b7106.InchargeCBD_U = "" Else b7106.InchargeCBD_U = a7106.InchargeCBD_U
            If trim$(a7106.InchargeBOM_I) = "" Then b7106.InchargeBOM_I = "" Else b7106.InchargeBOM_I = a7106.InchargeBOM_I
            If trim$(a7106.InchargeBOM_U) = "" Then b7106.InchargeBOM_U = "" Else b7106.InchargeBOM_U = a7106.InchargeBOM_U
            If trim$(a7106.InchargeCON_I) = "" Then b7106.InchargeCON_I = "" Else b7106.InchargeCON_I = a7106.InchargeCON_I
            If Trim$(a7106.InchargeCON_U) = "" Then b7106.InchargeCON_U = "" Else b7106.InchargeCON_U = a7106.InchargeCON_U

            If Trim$(a7106.InchargeDesigner) = "" Then b7106.InchargeDesigner = "" Else b7106.InchargeDesigner = a7106.InchargeDesigner
            If Trim$(a7106.InchargeStep1) = "" Then b7106.InchargeStep1 = "" Else b7106.InchargeStep1 = a7106.InchargeStep1
            If Trim$(a7106.InchargeStep2) = "" Then b7106.InchargeStep2 = "" Else b7106.InchargeStep2 = a7106.InchargeStep2
            If Trim$(a7106.InchargeStep3) = "" Then b7106.InchargeStep3 = "" Else b7106.InchargeStep3 = a7106.InchargeStep3

            If trim$(a7106.CheckParent) = "" Then b7106.CheckParent = "" Else b7106.CheckParent = a7106.CheckParent
            If trim$(a7106.ShoesParent) = "" Then b7106.ShoesParent = "" Else b7106.ShoesParent = a7106.ShoesParent
            If trim$(a7106.CheckUse) = "" Then b7106.CheckUse = "" Else b7106.CheckUse = a7106.CheckUse
            If trim$(a7106.TimeInsert) = "" Then b7106.TimeInsert = "" Else b7106.TimeInsert = a7106.TimeInsert
            If trim$(a7106.TimeUpdate) = "" Then b7106.TimeUpdate = "" Else b7106.TimeUpdate = a7106.TimeUpdate
            If trim$(a7106.CheckComplete) = "" Then b7106.CheckComplete = "" Else b7106.CheckComplete = a7106.CheckComplete
            If trim$(a7106.InchargeComplete) = "" Then b7106.InchargeComplete = "" Else b7106.InchargeComplete = a7106.InchargeComplete
            If trim$(a7106.DateComplete) = "" Then b7106.DateComplete = "" Else b7106.DateComplete = a7106.DateComplete
            If trim$(a7106.InchargeCompleteUn) = "" Then b7106.InchargeCompleteUn = "" Else b7106.InchargeCompleteUn = a7106.InchargeCompleteUn
            If trim$(a7106.DateCompleteUn) = "" Then b7106.DateCompleteUn = "" Else b7106.DateCompleteUn = a7106.DateCompleteUn
            If trim$(a7106.TimeComplete) = "" Then b7106.TimeComplete = "" Else b7106.TimeComplete = a7106.TimeComplete
            If trim$(a7106.CheckBOM) = "" Then b7106.CheckBOM = "" Else b7106.CheckBOM = a7106.CheckBOM
            If trim$(a7106.InchargeBOMCom) = "" Then b7106.InchargeBOMCom = "" Else b7106.InchargeBOMCom = a7106.InchargeBOMCom
            If trim$(a7106.DateBOMCom) = "" Then b7106.DateBOMCom = "" Else b7106.DateBOMCom = a7106.DateBOMCom
            If trim$(a7106.InchargeBOMUn) = "" Then b7106.InchargeBOMUn = "" Else b7106.InchargeBOMUn = a7106.InchargeBOMUn
            If trim$(a7106.DateBOMUn) = "" Then b7106.DateBOMUn = "" Else b7106.DateBOMUn = a7106.DateBOMUn
            If trim$(a7106.TimeBOMCom) = "" Then b7106.TimeBOMCom = "" Else b7106.TimeBOMCom = a7106.TimeBOMCom
            If trim$(a7106.CheckCBD) = "" Then b7106.CheckCBD = "" Else b7106.CheckCBD = a7106.CheckCBD
            If trim$(a7106.InchargeCBDCom) = "" Then b7106.InchargeCBDCom = "" Else b7106.InchargeCBDCom = a7106.InchargeCBDCom
            If trim$(a7106.DateCBDCom) = "" Then b7106.DateCBDCom = "" Else b7106.DateCBDCom = a7106.DateCBDCom
            If trim$(a7106.InchargeCBDUn) = "" Then b7106.InchargeCBDUn = "" Else b7106.InchargeCBDUn = a7106.InchargeCBDUn
            If trim$(a7106.DateCBDUn) = "" Then b7106.DateCBDUn = "" Else b7106.DateCBDUn = a7106.DateCBDUn
            If trim$(a7106.TimeCBDCom) = "" Then b7106.TimeCBDCom = "" Else b7106.TimeCBDCom = a7106.TimeCBDCom
            If trim$(a7106.CheckCON) = "" Then b7106.CheckCON = "" Else b7106.CheckCON = a7106.CheckCON
            If trim$(a7106.InchargeCONCom) = "" Then b7106.InchargeCONCom = "" Else b7106.InchargeCONCom = a7106.InchargeCONCom
            If trim$(a7106.DateCONCom) = "" Then b7106.DateCONCom = "" Else b7106.DateCONCom = a7106.DateCONCom
            If trim$(a7106.InchargeCONUn) = "" Then b7106.InchargeCONUn = "" Else b7106.InchargeCONUn = a7106.InchargeCONUn
            If trim$(a7106.DateCONUn) = "" Then b7106.DateCONUn = "" Else b7106.DateCONUn = a7106.DateCONUn
            If trim$(a7106.TimeCONCom) = "" Then b7106.TimeCONCom = "" Else b7106.TimeCONCom = a7106.TimeCONCom
            If trim$(a7106.CheckFB) = "" Then b7106.CheckFB = "" Else b7106.CheckFB = a7106.CheckFB
            If trim$(a7106.CheckSameMold) = "" Then b7106.CheckSameMold = "" Else b7106.CheckSameMold = a7106.CheckSameMold
            If trim$(a7106.Remark) = "" Then b7106.Remark = "" Else b7106.Remark = a7106.Remark
            If trim$(a7106.seSite) = "" Then b7106.seSite = "" Else b7106.seSite = a7106.seSite
            If trim$(a7106.cdSite) = "" Then b7106.cdSite = "" Else b7106.cdSite = a7106.cdSite
        Catch ex As Exception
            Call MsgBoxP("K7106_MOVE", vbCritical)
        End Try
    End Sub


End Module
