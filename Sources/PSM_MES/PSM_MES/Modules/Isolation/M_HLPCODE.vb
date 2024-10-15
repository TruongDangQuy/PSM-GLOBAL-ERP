Module M_HLPCODE

#Region "Variable"
    Public SheetReportName As String
    Public ChuoiValue1 As String
    Public ChuoiValue2 As String
    Public HLPNA As String = "HELPFUL"
    Public FSSQL As Integer
    Public TranValue As String = "" ' TranValue la gi tri dung cho helpbox de tim kiem nhanh
    Public TranValueText As String = ""
#End Region

#Region "Methods"
    Public Function HLPCHECKBUTTON(HLPNAME As String) As Boolean
        HLPCHECKBUTTON = False

        If HLPNAME <> "btn_programname" And HLPNAME <> "btn_sheetprint" Then Exit Function
        Try
            Dim f As Form
            HLPNA = HLPNAME
            Select Case HLPNAME
                Case "btn_Customer"

                    f = New HLP7101A
                    f.ShowDialog()

                Case "btn_Pono",
                    "btn_Odno",
                    "btn_Style",
                    "btn_Buyer"

                    'f = New HLP7171SBP
                    'f.ShowDialog()

                Case "Const_InchargeWork",
                    "Const_InchargeSales"
                    f = New HLP0002
                    f.ShowDialog()

                Case "btn_YarnSearch"
                    'f = New HLP7141B
                    'f.ShowDialog()

                Case "btn_programname",
                    "btn_sheetprint"
                    f = New HLP7141P
                    f.ShowDialog()

                Case "Const_Site",
                    "Const_Nationality",
                    "Const_Department",
                    "Const_OnePosition",
                    "Const_Position",
                    "Const_cdRawMaterial",
                    "Const_YarnCount",
                    "Const_cdYarnStructure",
                    "Const_InCharge",
                    "Const_MarketType",
                    "Const_MachineType",
                    "Const_ProcessProduction",
                    "Const_LargeGroupMaterial",
                    "Const_SemiGroupMaterial",
                    "Const_DetailGroupMaterial",
                    "Const_UnitMaterial",
                    "Const_UnitPrescription",
                    "Const_UnitPrice",
                    "Const_Tax",
                    "Const_MethodDyeing",
                    "Const_ProcessPrescription",
                    "Const_ProcessProductionWeaving",
                    "Const_FabricStructure",
                    "Const_FabricMaterial",
                    "Const_DirectExpense",
                    "Const_cdWeavingType",
                    "Const_cdSizingType",
                    "Const_ContractTerm",
                    "Const_PaymentCondition",
                    "Const_ShippingType",
                    "Const_Season",
                    "Const_UnitQuantity",
                    "Const_Factory",
                    "Const_Team",
                    "Const_WareHouseGroup",
                    "Const_WareHouseNameYarn",
                    "Const_WareHouseNameMaterial",
                    "Const_WareHouseNameGrey",
                    "Const_OrdertExpense",
                    "Const_RecipeType",
                    "Const_ColorCategory",
                    "Const_ColorBase",
                    "Const_SunLight",
                    "Const_cdPhysicalTest",
                    "Const_FactoryWeaving",
                    "Const_FactoryDyeing",
                    "Const_cdAccidentDyeingProduct",
                    "Const_DyeingColor",
                    "Const_DefectList",
                    "Const_selOrderChange",
                    "Const_cdOrderChange",
                    "Const_SUNIT",
                    "Const_GROUP_ACSR_A",
                    "Const_UNIT_ACSR",
                    "Const_TSEL",
                    "Const_WDCD",
                    "Const_ERP_PROC",
                    "Const_FACT_SP",
                    "Const_GJCD_SPINNING",
                    "Const_MATERIAL_TYPE_CD",
                    "Const_STABLE_LENGHT_CD",
                    "Const_ORIGIN_TYPE_CD",
                    "Const_OTHER_CHARACTERTITICS_CD",
                    "Const_PYCD",
                    "Const_BANK_NAME_CD",
                    "Const_ERP_SITE",
                    "Const_COMPANY",
                    "Const_SECD",
                    "Const_WH_POSI_GREY_DYEING",
                    "Const_WH_GREY_FABRIC",
                    "Const_BASE",
                    "Const_KWGU",
                    "Const_GACD",
                    "Const_PJCD",
                    "Const_MSORT",
                    "Const_SSORT",
                    "Const_CSEL",
                    "Const_FIBER"

                    f = New HLP7171ALL
                    f.ShowDialog()

                Case "Const_ProcessProduction;Check1;1",
                    "Const_ProcessProduction;Check1;2",
                    "Const_ProcessProduction;Check6;1",
                    "Const_MachineType;Check7;1",
                    "Const_MachineType;Check7;3",
                    "Const_ProcessProduction;Check4;1",
                    "Const_ProcessProduction;Check4;2"

                    f = New HLP7171ALL_Check
                    f.ShowDialog()

                Case "Const_Emp001",
                    "Const_Emp002",
                    "Const_Emp003",
                    "Const_Emp101",
                    "Const_Emp102",
                    "Const_Emp103",
                    "Const_Emp104",
                    "Const_Emp111",
                    "Const_Emp112",
                    "Const_Emp113",
                    "Const_Emp114",
                    "Const_Emp115",
                    "Const_Emp116",
                    "Const_Emp117",
                    "Const_Emp118",
                    "Const_Emp119",
                    "Const_Emp131",
                    "Const_Emp132",
                    "Const_Emp133",
                    "Const_Emp134",
                    "Const_Emp135",
                    "Const_Emp136",
                    "Const_Emp137",
                    "Const_Emp138",
                    "Const_Emp139",
                    "Const_EMP20",
                    "Const_EMP19",
                    "Const_EMP12",
                    "Const_EMP15",
                    "Const_EMP16",
                    "Const_EMP11",
                    "Const_EMP03"

                    f = New HLP0002
                    f.ShowDialog()

                Case "Const_LargeGroupMaterial_M"
                    'f = New HLP7171Material
                    'f.ShowDialog()


            End Select

            HLPCHECKBUTTON = True
        Catch ex As Exception
            MsgBoxP("HLPCHECK" & HLPNAME, vbCritical)
        End Try
    End Function
    Public Function HLPCHECK(HLPNAME As String) As Boolean
        HLPCHECK = False
        Try
            Dim f As Form
            HLPNA = HLPNAME
            Select Case HLPNAME
                Case "btn_MaterialCode", "btn_Material"
                    f = New HLP7231C
                    f.ShowDialog()

                Case "btn_Material_Final"
                    f = New HLP7231C_Final
                    f.ShowDialog()

                Case "btn_Customer"

                    f = New HLP7101A
                    f.ShowDialog()

                Case "btn_Customer;1"

                    f = New HLP0001_Cus
                    f.ShowDialog()

                Case "btn_Customer;2"

                    f = New HLP0001_Sup
                    f.ShowDialog()


                Case "btn_Pono",
                    "btn_Odno",
                    "btn_Style",
                    "btn_Buyer"

                    f = New HLP7171SBP
                    f.ShowDialog()

                Case "Const_AccCode"

                    f = New HLP7172ALL
                    f.ShowDialog()

                Case "Const_AccCode;7", "Const_AccCode;7"

                    f = New HLP7172ALL
                    f.ShowDialog()

                Case "Const_AccCode;8"

                    f = New HLP7172ALL
                    f.ShowDialog()

                Case "Const_1121"

                    f = New HLP7173A
                    f.ShowDialog()

                Case "btn_programname",
                    "btn_sheetprint"
                    f = New HLP7141A
                    f.ShowDialog()

                Case "Const_CustomerDivision",
                    "Const_CustomerLocation",
                    "Const_SalesGroup",
                    "Const_SalesTeam",
                    "Const_SalesKind",
                    "Const_UnitMaterial",
                    "Const_UnitPacking",
                    "Const_LargeGroupMaterial",
                    "Const_SemiGroupMaterial",
                    "Const_DetailGroupMaterial",
                    "Const_Tax",
                    "Const_UnitPrice",
                    "Const_Site",
                    "Const_Nationality",
                    "Const_Department",
                    "Const_OnePosition",
                    "Const_Position",
                    "Const_Incharge",
                    "Const_PaymentCondition",
                    "Const_DeliveryTerm",
                    "Const_BankId",
                    "Const_ExpenseCode",
                    "Const_ImPortCondition",
                    "Const_Lonic",
                    "Const_Apperance",
                    "Const_FAAPs",
                    "Const_selBasicMaster"

                    f = New HLP7171ALL
                    f.ShowDialog()

                Case "Const_Emp001",
                    "Const_Emp002",
                    "Const_Emp003",
                    "Const_Emp004",
                    "Const_Emp005",
                    "Const_Emp101",
                    "Const_Emp102",
                    "Const_Emp103",
                    "Const_Emp104",
                    "Const_Emp112",
                    "Const_Emp119",
                    "Const_Emp131",
                    "Const_Emp137"

                    f = New HLP0002
                    f.ShowDialog()

                Case "Const_LargeGroupMaterial_M"
                    f = New HLP7171Material
                    f.ShowDialog()


                Case Else
                    If READ_PFK7171(Const_selBasicMaster, HLPNAME) Then
                        f = New HLP7171ALL
                        f.ShowDialog()
                    End If

            End Select

            HLPCHECK = True
        Catch ex As Exception
            MsgBoxP("HLPCHECK" & HLPNAME, vbCritical)
        End Try
    End Function
    ' Case for HLP0001
    Public Sub HLPSEARCH(HLPNA As String, text As String, ts As String, sw As String, ew As String, hn As Integer)

        Select Case HLPNA

            Case "btn_Buyer"
                PrcDS("SP_HLP7102A_SEARCH_1", cn, text, ts, sw, ew, hn)

            Case "btn_Buyer1"
                PrcDS("SP_HLP7102A_SEARCH_F", cn, text, ts, sw, ew, hn)

            Case "btn_Odno"
                PrcDS("SP_HLP7102A_SEARCH_2", cn, text, ts, sw, ew, hn)

            Case "btn_Pono"
                PrcDS("SP_HLP7102A_SEARCH_3", cn, text, ts, sw, ew, hn)

            Case "btn_WProcess"
                PrcDS("USP_HLP8780A_SEARCH_1", cn, text, ts, sw, ew, hn)

            Case "btn_OriginSearch"
                PrcDS("USP_HLP8381A_SEARCH_1", cn, text, ts, sw, ew, hn)

            Case "btn_YarnSearch"
                PrcDS("USP_HLP7141A_SEARCH_1", cn, text, ts, sw, ew, hn)

            Case "btn_InsMachine"
                PrcDS("USP_HLP7155A_SEARCH_1", cn, "013", text, ts, sw, ew, hn)

            Case "btn_FabricSearch"
                PrcDS("USP_HLP7111Z_SEARCH_VS1_01", cn, text, ts, sw, ew, hn)

            Case "btn_Style"
                PrcDS("SP_HLP7106A_SEARCH_1", cn, text, "", "", ts, sw, ew, hn)

            Case "btn_Customer"
                PrcDS("SP_HLP7102A_SEARCH_1", cn, text, ts, sw, ew, hn)

        End Select
    End Sub
    'SEL cho HLP0002,HLP003
    Public Function SELCON(ByRef HLPNA As String) As String
        SELCON = HLPNA
    End Function
#End Region

    
   
End Module
