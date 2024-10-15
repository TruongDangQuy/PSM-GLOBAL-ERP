Public Class PFP23567
#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Private wGCODE As String
    Protected prg As E_PRG

    Private W2356 As T2356_AREA


    Private W2352 As New T2352_AREA
    Private L2352 As New T2352_AREA

    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)

        Call Cms_additem(Cms_1, _
                       "MATERIAL WAREHOUSE PROCESSING - " & WordConv("INPUT AUTO") & "(F5)")

        vS10.ContextMenuStrip = Cms_1

        Call Cms_additem(Cms_2, _
                        "MATERIAL WAREHOUSE PROCESSING - " & WordConv("INPUT") & "(F5)", _
                        "MATERIAL WAREHOUSE PROCESSING - " & WordConv("SEARCH") & "(F6)", _
                        "MATERIAL WAREHOUSE PROCESSING - " & WordConv("UPDATE") & "(F7)", _
                        "MATERIAL WAREHOUSE PROCESSING - " & WordConv("DELETE") & "(F8)", _
                        "-")

        vS20.ContextMenuStrip = Cms_2

        Call Cms_additem(Cms_3, _
                "-", _
                "MATERIAL WAREHOUSE PROCESSING - " & WordConv("SEARCH") & "(F6)", _
                "MATERIAL WAREHOUSE PROCESSING - " & WordConv("UPDATE") & "(F7)")

        vS30.ContextMenuStrip = Cms_3

        Me.KeyPreview = True

        Call FORM_INIT()
        Call DATA_INIT()
    End Sub
    Private Sub PFP23567_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)

        Call Function_Event(e.KeyValue)
    End Sub
    Private Sub Function_Event(PressKey As Integer)
        Try
            Select Case PressKey
                Case Keys.F5 : Call MAIN_JOB01()
                Case Keys.F6 : Call MAIN_JOB02()
                Case Keys.F7 : Call MAIN_JOB03()
                Case Keys.F8 : Call MAIN_JOB04()
                Case Keys.F9 : Call MAIN_JOB05()
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FORM_INIT()
        chk_FSEL.CheckState = 1
        chk_FSEL.BackColor = clrCheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("CLOSE")
        ssp_WHERE.Visible = True
    End Sub

    Private Sub DATA_INIT()
        SdateEdate.text1 = Pub.DAT
        SdateEdate.text2 = Pub.DAT

    End Sub
#End Region

#Region "Function"
    Private Sub MAIN_JOB01()

        Try
            Select Case True
                Case vS10.Focused
                    Call CheckOutBoundMaterial()
                    Dim FactOrderNo As String
                    Dim JobCardWorking As String
                    Dim JobCardWorkingSeq As String

                    FactOrderNo = getData(vS10, getColumIndex(vS10, "KEY_FactOrderNo"), vS10.ActiveSheet.ActiveRowIndex)
                    JobCardWorking = getData(vS10, getColumIndex(vS10, "KEY_JobCardWorking"), vS10.ActiveSheet.ActiveRowIndex)
                    JobCardWorkingSeq = getData(vS10, getColumIndex(vS10, "KEY_JobCardWorkingSeq"), vS10.ActiveSheet.ActiveRowIndex)

                    If ISUD2356A.Link_ISUD2356A_AUTO(1, Pub.DAT, FactOrderNo, JobCardWorking, JobCardWorkingSeq, Me.Name) = True Then
                        Call DATA_SEARCH_VS10()
                    End If

                Case vS20.Focused
                    Call CheckOutBoundMaterial()

                    If getData(vS20, getColumIndex(vS20, "KEY_FactOrderNo"), vS20.ActiveSheet.ActiveRowIndex) <> "" Then

                        Dim i As Integer
                        Dim SpecNoList As String
                        Dim KEY_Autokey As String

                        For i = 0 To vS20.ActiveSheet.RowCount - 1
                            If getDataM(vS20, getColumIndex(vS20, "dchk"), i) <> "1" Then GoTo next1
                            KEY_Autokey = getData(vS20, getColumIndex(vS20, "KEY_Autokey_2356"), i)

                            SpecNoList = SpecNoList & "''" & KEY_Autokey & "''"
                            SpecNoList = SpecNoList & ","
next1:
                        Next

                        If SpecNoList = "" Then Exit Sub

                        SpecNoList = Strings.Left(SpecNoList, Len(SpecNoList) - 1)

                        If ISUD2356B.Link_ISUD2356B_AUTO(11, W2356.CheckOutBoundMaterial, getData(vS20, getColumIndex(vS20, "KEY_DateOutBoundMaterial"), vS20.ActiveSheet.ActiveRowIndex),
                                                                             getData(vS20, getColumIndex(vS20, "KEY_SeqOutBoundMaterial"), vS20.ActiveSheet.ActiveRowIndex),
                                                                             getData(vS20, getColumIndex(vS20, "KEY_SnoOutBoundMaterial"), vS20.ActiveSheet.ActiveRowIndex),
                                                                             SpecNoList, Me.Name) = True Then
                            Call DATA_SEARCH_VS20()
                        End If
                    Else
                        If ISUD2356B.Link_ISUD2356B(11, W2356.CheckOutBoundMaterial, getData(vS20, getColumIndex(vS20, "KEY_DateOutBoundMaterial"), vS20.ActiveSheet.ActiveRowIndex),
                                                                             getData(vS20, getColumIndex(vS20, "KEY_SeqOutBoundMaterial"), vS20.ActiveSheet.ActiveRowIndex),
                                                                              getData(vS20, getColumIndex(vS20, "KEY_SnoOutBoundMaterial"), vS20.ActiveSheet.ActiveRowIndex),
                                                                             getData(vS20, getColumIndex(vS20, "KEY_FactOrderNo"), vS20.ActiveSheet.ActiveRowIndex),
                                                                             getData(vS20, getColumIndex(vS20, "KEY_FactOrderSeq"), vS20.ActiveSheet.ActiveRowIndex), Me.Name) = True Then

                            Call DATA_SEARCH_VS20()
                        End If

                    End If


            End Select
        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB01!", vbCritical)
        End Try
    End Sub

    Private Sub MAIN_JOB02()

        Try
            Select Case True
                Case vS10.Focused

                    If ISUD2356B.Link_ISUD2356B(2, getData(vS10, getColumIndex(vS10, "KEY_CheckOutBoundMaterial"), vS10.ActiveSheet.ActiveRowIndex),
                                                    getData(vS10, getColumIndex(vS10, "KEY_DateOutBoundMaterial"), vS10.ActiveSheet.ActiveRowIndex),
                                                    getData(vS10, getColumIndex(vS10, "KEY_SeqOutBoundMaterial"), vS10.ActiveSheet.ActiveRowIndex),
                                                    getData(vS10, getColumIndex(vS10, "KEY_SnoOutBoundMaterial"), vS10.ActiveSheet.ActiveRowIndex),
                                                    getData(vS10, getColumIndex(vS10, "KEY_FactOrderNo"), vS10.ActiveSheet.ActiveRowIndex),
                                                    getData(vS10, getColumIndex(vS10, "KEY_FactOrderSeq"), vS10.ActiveSheet.ActiveRowIndex), Me.Name) = True Then


                        Call DATA_SEARCH_VS10()
                    End If

                Case vS20.Focused
                    Call CheckOutBoundMaterial()

                    If ISUD2356B.Link_ISUD2356B(2, getData(vS20, getColumIndex(vS20, "KEY_CheckOutBoundMaterial"), vS20.ActiveSheet.ActiveRowIndex),
                                                    getData(vS20, getColumIndex(vS20, "KEY_DateOutBoundMaterial"), vS20.ActiveSheet.ActiveRowIndex),
                                                    getData(vS20, getColumIndex(vS20, "KEY_SeqOutBoundMaterial"), vS20.ActiveSheet.ActiveRowIndex),
                                                     getData(vS20, getColumIndex(vS20, "KEY_SnoOutBoundMaterial"), vS20.ActiveSheet.ActiveRowIndex),
                                                    getData(vS20, getColumIndex(vS20, "KEY_FactOrderNo"), vS20.ActiveSheet.ActiveRowIndex),
                                                    getData(vS20, getColumIndex(vS20, "KEY_FactOrderSeq"), vS20.ActiveSheet.ActiveRowIndex), Me.Name) = True Then


                        Call DATA_SEARCH_VS20()
                    End If

                Case vS30.Focused
                    'Call CheckOutBoundMaterial()

                    Dim DateOutBound As String
                    Dim cdDepartment As String
                    Dim cdLineProd As String
                    Dim cdSubProcess As String
                    Dim SupplierCode As String
                    Dim CustomerCode As String
                    Dim JobCard As String
                    Dim CheckOutBoundMaterial As String

                    DateOutBound = getData(vS30, getColumIndex(vS30, "KEY_DateOutBound"), vS30.ActiveSheet.ActiveRowIndex)
                    cdDepartment = getData(vS30, getColumIndex(vS30, "KEY_cdDepartment"), vS30.ActiveSheet.ActiveRowIndex)
                    cdLineProd = getData(vS30, getColumIndex(vS30, "KEY_cdLineProd"), vS30.ActiveSheet.ActiveRowIndex)
                    cdSubProcess = getData(vS30, getColumIndex(vS30, "KEY_cdSubProcess"), vS30.ActiveSheet.ActiveRowIndex)
                    SupplierCode = getData(vS30, getColumIndex(vS30, "KEY_SupplierCode"), vS30.ActiveSheet.ActiveRowIndex)
                    CustomerCode = getData(vS30, getColumIndex(vS30, "KEY_CustomerCode"), vS30.ActiveSheet.ActiveRowIndex)
                    JobCard = getData(vS30, getColumIndex(vS30, "KEY_JobCard"), vS30.ActiveSheet.ActiveRowIndex)
                    CheckOutBoundMaterial = getData(vS30, getColumIndex(vS30, "KEY_CheckOutBoundMaterial"), vS30.ActiveSheet.ActiveRowIndex)

                    If ISUD2356C.Link_ISUD2356C(2, DateOutBound, cdDepartment, cdLineProd, cdSubProcess, SupplierCode, CustomerCode, JobCard, CheckOutBoundMaterial, Me.Name) = True Then

                    End If

            End Select
        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB01!", vbCritical)
        End Try
    End Sub

    Private Sub MAIN_JOB03()
        Select Case True
            Case vS10.Focused
                If ISUD2356B.Link_ISUD2356B(3, getData(vS10, getColumIndex(vS10, "KEY_CheckOutBoundMaterial"), vS10.ActiveSheet.ActiveRowIndex),
                                     getData(vS10, getColumIndex(vS10, "KEY_DateOutBoundMaterial"), vS10.ActiveSheet.ActiveRowIndex),
                                     getData(vS10, getColumIndex(vS10, "KEY_SeqOutBoundMaterial"), vS10.ActiveSheet.ActiveRowIndex),
                                      getData(vS10, getColumIndex(vS10, "KEY_SnoOutBoundMaterial"), vS10.ActiveSheet.ActiveRowIndex),
                                     getData(vS10, getColumIndex(vS10, "KEY_FactOrderNo"), vS10.ActiveSheet.ActiveRowIndex),
                                     getData(vS10, getColumIndex(vS10, "KEY_FactOrderSeq"), vS10.ActiveSheet.ActiveRowIndex), Me.Name) = True Then


                    Call DATA_SEARCH_VS10()
                End If
            Case vS20.Focused
                Call CheckOutBoundMaterial()

                If getData(vS20, getColumIndex(vS20, "KEY_DateOutBoundMaterial"), vS20.ActiveSheet.ActiveRowIndex) = "" Then

                    If ISUD2356B.Link_ISUD2356B(1, W2356.CheckOutBoundMaterial, "0000000000", "000", "000000000", "000", Me.Name) = True Then
                        Call DATA_SEARCH_VS20()
                    End If
                Else
                    If ISUD2356B.Link_ISUD2356B(3, getData(vS20, getColumIndex(vS20, "KEY_CheckOutBoundMaterial"), vS20.ActiveSheet.ActiveRowIndex),
                                                    getData(vS20, getColumIndex(vS20, "KEY_DateOutBoundMaterial"), vS20.ActiveSheet.ActiveRowIndex),
                                                    getData(vS20, getColumIndex(vS20, "KEY_SeqOutBoundMaterial"), vS20.ActiveSheet.ActiveRowIndex),
                                                     getData(vS20, getColumIndex(vS20, "KEY_SnoOutBoundMaterial"), vS20.ActiveSheet.ActiveRowIndex),
                                                    getData(vS20, getColumIndex(vS20, "KEY_FactOrderNo"), vS20.ActiveSheet.ActiveRowIndex),
                                                    getData(vS20, getColumIndex(vS20, "KEY_FactOrderSeq"), vS20.ActiveSheet.ActiveRowIndex), Me.Name) = True Then


                        Call DATA_SEARCH_VS20()
                    End If

                End If

            Case vS30.Focused
                'Call CheckOutBoundMaterial()

                Dim DateOutBound As String
                Dim cdDepartment As String
                Dim cdLineProd As String
                Dim cdSubProcess As String
                Dim SupplierCode As String
                Dim CustomerCode As String
                Dim JobCard As String
                Dim CheckOutBoundMaterial As String

                DateOutBound = getData(vS30, getColumIndex(vS30, "KEY_DateOutBound"), vS30.ActiveSheet.ActiveRowIndex)
                cdDepartment = getData(vS30, getColumIndex(vS30, "KEY_cdDepartment"), vS30.ActiveSheet.ActiveRowIndex)
                cdLineProd = getData(vS30, getColumIndex(vS30, "KEY_cdLineProd"), vS30.ActiveSheet.ActiveRowIndex)
                cdSubProcess = getData(vS30, getColumIndex(vS30, "KEY_cdSubProcess"), vS30.ActiveSheet.ActiveRowIndex)
                SupplierCode = getData(vS30, getColumIndex(vS30, "KEY_SupplierCode"), vS30.ActiveSheet.ActiveRowIndex)
                CustomerCode = getData(vS30, getColumIndex(vS30, "KEY_CustomerCode"), vS30.ActiveSheet.ActiveRowIndex)
                JobCard = getData(vS30, getColumIndex(vS30, "KEY_JobCard"), vS30.ActiveSheet.ActiveRowIndex)
                CheckOutBoundMaterial = getData(vS30, getColumIndex(vS30, "KEY_CheckOutBoundMaterial"), vS30.ActiveSheet.ActiveRowIndex)

                If ISUD2356C.Link_ISUD2356C(3, DateOutBound, cdDepartment, cdLineProd, cdSubProcess, SupplierCode, CustomerCode, JobCard, CheckOutBoundMaterial, Me.Name) = True Then

                End If


        End Select

    End Sub

    Private Sub MAIN_JOB04()
        Select Case True
            Case vS10.Focused
                If ISUD2356B.Link_ISUD2356B(3, getData(vS10, getColumIndex(vS10, "KEY_CheckOutBoundMaterial"), vS10.ActiveSheet.ActiveRowIndex),
                                     getData(vS10, getColumIndex(vS10, "KEY_DateOutBoundMaterial"), vS10.ActiveSheet.ActiveRowIndex),
                                     getData(vS10, getColumIndex(vS10, "KEY_SeqOutBoundMaterial"), vS10.ActiveSheet.ActiveRowIndex),
                                      getData(vS10, getColumIndex(vS10, "KEY_SnoOutBoundMaterial"), vS10.ActiveSheet.ActiveRowIndex),
                                     getData(vS10, getColumIndex(vS10, "KEY_FactOrderNo"), vS10.ActiveSheet.ActiveRowIndex),
                                     getData(vS10, getColumIndex(vS10, "KEY_FactOrderSeq"), vS10.ActiveSheet.ActiveRowIndex), Me.Name) = True Then


                    Call DATA_SEARCH_VS10()
                End If
            Case vS20.Focused
                Call CheckOutBoundMaterial()

                If ISUD2356B.Link_ISUD2356B(4, getData(vS20, getColumIndex(vS20, "KEY_CheckOutBoundMaterial"), vS20.ActiveSheet.ActiveRowIndex),
                                                getData(vS20, getColumIndex(vS20, "KEY_DateOutBoundMaterial"), vS20.ActiveSheet.ActiveRowIndex),
                                                getData(vS20, getColumIndex(vS20, "KEY_SeqOutBoundMaterial"), vS20.ActiveSheet.ActiveRowIndex),
                                                 getData(vS20, getColumIndex(vS20, "KEY_SnoOutBoundMaterial"), vS20.ActiveSheet.ActiveRowIndex),
                                                getData(vS20, getColumIndex(vS20, "KEY_FactOrderNo"), vS20.ActiveSheet.ActiveRowIndex),
                                                getData(vS20, getColumIndex(vS20, "KEY_FactOrderSeq"), vS20.ActiveSheet.ActiveRowIndex), Me.Name) = True Then


                    Call DATA_SEARCH_VS20()
                End If

        End Select

    End Sub

    Private Sub MAIN_JOB05()

    End Sub

#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS10(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS10 = False

        vS10.Enabled = False


        Dim Starting As Object
        Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")

        Try
            Call CheckOutBoundMaterial()

            DS1 = PrcDS("USP_PFP23567_SEARCH_VS10", cn, SdateEdate.text1,
                                                        SdateEdate.text2,
                                                        txt_cdSite.Code,
                                                        txt_FactOrderNo.Data,
                                                        txt_Customer.Data,
                                                        txt_cdLargeGroupMaterial.Data,
                                                        txt_cdSemiGroupMaterial.Data,
                                                        "*" & txt_MaterialName.Data,
                                                        chk_CheckProcessMaterial0.CheckState,
                                                        chk_CheckProcessMaterial1.CheckState,
                                                        chk_CheckIOType0.CheckState,
                                                        chk_CheckIOType1.CheckState,
                                                        chk_CheckMaterialType0.CheckState,
                                                        chk_CheckMaterialType1.CheckState,
                                                        chk_CheckMarketType0.CheckState,
                                                        chk_CheckMarketType1.CheckState,
                                                        opt_SEL0.CheckState,
                                                        opt_SEL1.CheckState,
                                                        opt_SEL2.CheckState,
                                                        opt_SEL3.CheckState,
                                                        opt_SEL4.CheckState,
                                                        opt_SEL5.CheckState,
                                                        W2356.CheckOutBoundMaterial,
                                                        "1",
                                                        "1",
                                                        "1",
                                                        "1",
                                                        "1",
                                                        "1",
                                                        "1",
                                                        txt_SlNoD.Data)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS10, DS1, "USP_PFP23567_SEARCH_vS10", "vS10")

                vS10.ActiveSheet.RowCount = 0
                vS10.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS10, DS1, "USP_PFP23567_SEARCH_vS10", "vS10")
            DATA_SEARCH_VS10 = True

        Catch ex As Exception
        Finally
            vS10.Enabled = True
            Starting.close()
        End Try

    End Function

    Private Function DATA_SEARCH_VS20(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS20 = False

        vS20.Enabled = False

        Dim Starting As Object
        Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")

        Try
            Call CheckOutBoundMaterial()

            DS1 = PrcDS("USP_PFP23567_SEARCH_VS20", cn, SdateEdate.text1,
                                                        SdateEdate.text2,
                                                        txt_cdSite.Code,
                                                        txt_FactOrderNo.Data,
                                                        txt_Customer.Data,
                                                        txt_cdLargeGroupMaterial.Data,
                                                        txt_cdSemiGroupMaterial.Data,
                                                        "*" & txt_MaterialName.Data,
                                                        W2356.CheckOutBoundMaterial,
                                                        chk_CheckProcessMaterial0.CheckState,
                                                        chk_CheckProcessMaterial1.CheckState,
                                                        chk_CheckIOType0.CheckState,
                                                        chk_CheckIOType1.CheckState,
                                                        chk_CheckMaterialType0.CheckState,
                                                        chk_CheckMaterialType1.CheckState,
                                                        chk_CheckMarketType0.CheckState,
                                                        chk_CheckMarketType1.CheckState,
                                                        opt_SEL0.CheckState,
                                                        opt_SEL1.CheckState,
                                                        opt_SEL2.CheckState,
                                                        opt_SEL3.CheckState,
                                                        opt_SEL4.CheckState,
                                                        opt_SEL5.CheckState,
                                                        txt_SlNoD.Data,
                                                        txt_TradingCode.Data
                                                        )

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS20, DS1, "USP_PFP23567_SEARCH_VS20", "VS20")

                vS20.ActiveSheet.RowCount = 0
                vS20.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS20, DS1, "USP_PFP23567_SEARCH_VS20", "VS20")
            DATA_SEARCH_VS20 = True

        Catch ex As Exception
        Finally
            vS20.Enabled = True
            Starting.close()
        End Try
    End Function

    Private Function DATA_SEARCH_VS50(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS50 = False

        VS50.Enabled = False

        Dim Starting As Object
        Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")

        Try
            Call CheckOutBoundMaterial()

            DS1 = PrcDS("USP_PFP23567_SEARCH_VS50", cn, SdateEdate.text1,
                                                        SdateEdate.text2,
                                                        txt_cdSite.Code,
                                                        txt_FactOrderNo.Data,
                                                        txt_Customer.Data,
                                                        txt_cdLargeGroupMaterial.Data,
                                                        txt_cdSemiGroupMaterial.Data,
                                                        "*" & txt_MaterialName.Data,
                                                        W2356.CheckOutBoundMaterial,
                                                        chk_CheckProcessMaterial0.CheckState,
                                                        chk_CheckProcessMaterial1.CheckState,
                                                        chk_CheckIOType0.CheckState,
                                                        chk_CheckIOType1.CheckState,
                                                        chk_CheckMaterialType0.CheckState,
                                                        chk_CheckMaterialType1.CheckState,
                                                        chk_CheckMarketType0.CheckState,
                                                        chk_CheckMarketType1.CheckState,
                                                        opt_SEL0.CheckState,
                                                        opt_SEL1.CheckState,
                                                        opt_SEL2.CheckState,
                                                        opt_SEL3.CheckState,
                                                        opt_SEL4.CheckState,
                                                        opt_SEL5.CheckState,
                                                        txt_SlNoD.Data)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(VS50, DS1, "USP_PFP23567_SEARCH_VS50", "VS50")

                VS50.ActiveSheet.RowCount = 0
                VS50.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(VS50, DS1, "USP_PFP23567_SEARCH_VS50", "VS50")
            DATA_SEARCH_VS50 = True

        Catch ex As Exception
        Finally
            VS50.Enabled = True
            Starting.close()
        End Try
    End Function

    Private Function DATA_SEARCH_VS30(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS30 = False

        vS30.Enabled = False

        Dim Starting As Object
        Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")

        Try

            DS1 = PrcDS("USP_PFP23567_SEARCH_VS30", cn, SdateEdate.text1,
                                                        SdateEdate.text2,
                                                        txt_cdSite.Code)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS30, DS1, "USP_PFP23567_SEARCH_VS30", "VS30")

                vS30.ActiveSheet.RowCount = 0
                vS30.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS30, DS1, "USP_PFP23567_SEARCH_VS30", "VS30")
            DATA_SEARCH_VS30 = True


        Catch ex As Exception
        Finally
            vS30.Enabled = True
            Starting.close()
        End Try

    End Function

    Private Function DATA_SEARCH_VS40(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS40 = False

        VS40.Enabled = False

        Try

            DS1 = PrcDS("USP_PFP23567_SEARCH_VS40", cn, SdateEdate.text1,
                                                        SdateEdate.text2,
                                                        txt_cdSite.Code)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(VS40, DS1, "USP_PFP23567_SEARCH_VS40", "VS40")

                VS40.ActiveSheet.RowCount = 0
                VS40.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(VS40, DS1, "USP_PFP23567_SEARCH_VS40", "VS40")
            DATA_SEARCH_VS40 = True


        Catch ex As Exception
        Finally
            vS40.Enabled = True

        End Try

    End Function

    Private Sub cmd_BARCODE_Click(sender As Object, e As EventArgs) Handles cmd_BARCODE.Click
        Dim Msg_Result As String
        Dim i As Integer
        Try
            Msg_Result = MsgBoxP("TAG PRINT?", vbYesNo)
            If Msg_Result = vbYes Then
                For i = 0 To vS20.ActiveSheet.RowCount - 1
                    If getDataM(vS20, getColumIndex(vS20, "DCHK"), i) = "1" Then

                        Call DATA_MOVE_BARCODE(getData(vS20, getColumIndex(vS20, "KEY_MaterialInBoundNo"), i),
                                               getData(vS20, getColumIndex(vS20, "KEY_MaterialInBoundSeq"), i),
                                               getData(vS20, getColumIndex(vS20, "KEY_MaterialInBoundSno"), i))


                        If READ_PFK2352(getData(vS20, getColumIndex(vS20, "KEY_MaterialInBoundNo"), i),
                                               getData(vS20, getColumIndex(vS20, "KEY_MaterialInBoundSeq"), i),
                                               getData(vS20, getColumIndex(vS20, "KEY_MaterialInBoundSno"), i)) Then
                            W2352 = D2352
                            W2352.CheckPrint = "1"
                            W2352.TimePrint = System_Date_time()

                            Call REWRITE_PFK2352(W2352)
                        End If
                    End If
                Next i
            End If
        Catch ex As Exception
            MsgBoxP("DATA_MOVE_BARCODE")
        End Try

    End Sub

    Public Sub DATA_MOVE_BARCODE(MaterialInBoundNo As String, MaterialInBoundSeq As String, MaterialInBoundSno As String)
        DS1 = PrcDS("USP_ISUD2352A_SEARCH_PRINT", cn, MaterialInBoundNo, MaterialInBoundSeq, MaterialInBoundSno)
        If GetDsRc(DS1) = 0 Then MsgBoxP("No data!") : Exit Sub

        MATERIAL.PRNo = GetDsData(DS1, 0, "PRNo")
        MATERIAL.MaterialInBoundSno = MaterialInBoundSno

        MATERIAL.MaterialCode = GetDsData(DS1, 0, "MaterialCode")
        MATERIAL.MaterialName = GetDsData(DS1, 0, "MaterialName")
        MATERIAL.cdUnitMaterialName = GetDsData(DS1, 0, "cdUnitMaterialName")
        MATERIAL.cdUnitPackingName = GetDsData(DS1, 0, "cdUnitPackingName")

        MATERIAL.DateInBoundMaterial = GetDsData(DS1, 0, "DateInBoundMaterial")

        MATERIAL.PackInBound = GetDsData(DS1, 0, "PackInBound")
        MATERIAL.QtyInBound = GetDsData(DS1, 0, "QtyInBound")
        MATERIAL.InvoiceNo = GetDsData(DS1, 0, "InvoiceNo")

        MATERIAL.InchargeInBoundName = GetDsData(DS1, 0, "InchargeInBoundName")
        MATERIAL.SupplierName = GetDsData(DS1, 0, "SupplierCodeName")

        MATERIAL.CheckInBoundMaterial = GetDsData(DS1, 0, "CheckInBoundMaterial")
        MATERIAL.CheckMaterialType = GetDsData(DS1, 0, "CheckMaterialType")
        MATERIAL.CheckMarketType = GetDsData(DS1, 0, "CheckMarketType")

        MATERIAL.Barcode = GetDsData(DS1, 0, "Barcode")
        MATERIAL.ColorName = GetDsData(DS1, 0, "ColorName")

        Try
            PrintDocument1 = New Printing.PrintDocument
            PrintDocument1.Print()

        Catch ex As Exception
            MsgBoxP("DATA_MOVE_BARCODE")
        End Try

    End Sub

    Public Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        gpp = e.Graphics
        Call TAG_PRINT_MATERIAL_NEW_F1()

    End Sub
    Private Function LINE_MOVE_DISPLAY01() As Boolean
        LINE_MOVE_DISPLAY01 = False

    End Function
    Private Function CustomerPurchasing_CHK() As String
        CustomerPurchasing_CHK = "1"
        Return CustomerPurchasing_CHK
    End Function
    Private Sub CheckOutBoundMaterial(Process As String)
        Select Case Process
            Case "1" : rad_CheckOutSide1.Checked = True
            Case "2" : rad_CheckOutSide2.Checked = True
            Case "3" : rad_CheckOutSide3.Checked = True
            Case "4" : rad_CheckOutSide4.Checked = True
            Case "5" : rad_CheckOutSide5.Checked = True
            Case "6" : rad_CheckOutSide6.Checked = True
            Case Else : rad_CheckOutSide1.Checked = True
        End Select
    End Sub

    Private Sub CheckOutBoundMaterial()
        If rad_CheckOutSide1.Checked = True Then W2356.CheckOutBoundMaterial = "1"
        If rad_CheckOutSide2.Checked = True Then W2356.CheckOutBoundMaterial = "2"
        If rad_CheckOutSide3.Checked = True Then W2356.CheckOutBoundMaterial = "3"
        If rad_CheckOutSide4.Checked = True Then W2356.CheckOutBoundMaterial = "4"
        If rad_CheckOutSide5.Checked = True Then W2356.CheckOutBoundMaterial = "5"
        If rad_CheckOutSide6.Checked = True Then W2356.CheckOutBoundMaterial = "6"
    End Sub


#End Region

#Region "Event"
    Private Sub tst_1_Click(sender As Object, e As EventArgs) Handles tst_1.Click, tst_2.Click, tst_3.Click, tst_4.Click, tst_5.Click, tst_6.Click
        If sender.Equals(tst_1) Then
            MAIN_JOB01()
        End If
        If sender.Equals(tst_2) Then
            MAIN_JOB02()
        End If
        If sender.Equals(tst_3) Then
            MAIN_JOB03()
        End If
        If sender.Equals(tst_4) Then
            MAIN_JOB04()
        End If
        If sender.Equals(tst_5) Then
            MAIN_JOB05()
        End If
    End Sub

    Private Sub chk_FSEL_Click(sender As Object, e As EventArgs) Handles chk_FSEL.CheckedChanged
        If chk_FSEL.CheckState = 0 Then                  '
            chk_FSEL.BackColor = clrUncheck
            chk_FSEL.ForeColor = Color.Black

            chk_FSEL.Text = WordConv("OPEN")
            ssp_WHERE.Visible = False
        Else                                        '
            chk_FSEL.BackColor = clrCheck
            chk_FSEL.ForeColor = Color.Black

            chk_FSEL.Text = WordConv("CLOSE")
            ssp_WHERE.Visible = True
        End If
    End Sub
    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click

        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False

        If ItemMain.SelectedIndex = 0 Then Call DATA_SEARCH_VS10()
        If ItemMain.SelectedIndex = 1 Then Call DATA_SEARCH_VS20()
        If ItemMain.SelectedIndex = 2 Then Call DATA_SEARCH_VS30()
        If ItemMain.SelectedIndex = 3 Then Call DATA_SEARCH_VS40()
        If ItemMain.SelectedIndex = 4 Then Call DATA_SEARCH_VS50()
    End Sub

    Private Sub Cms_1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_1.ItemClicked
        If Cms_1.Items(0).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB01()
        End If
    End Sub

    Private Sub Cms_2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_2.ItemClicked
        If Cms_2.Items(0).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB01()

        ElseIf Cms_2.Items(1).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB02()

        ElseIf Cms_2.Items(2).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB03()

        ElseIf Cms_2.Items(3).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB04()

        ElseIf Cms_2.Items(5).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB05()
        End If
    End Sub

    Private Sub Cms_3_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_3.ItemClicked
        If Cms_3.Items(0).Selected = True Then
            Cms_3.Hide()
            MAIN_JOB01()

        ElseIf Cms_3.Items(1).Selected = True Then
            Cms_3.Hide()
            MAIN_JOB02()

        ElseIf Cms_3.Items(2).Selected = True Then
            Cms_3.Hide()
            MAIN_JOB03()

        ElseIf Cms_3.Items(3).Selected = True Then
            Cms_3.Hide()
            MAIN_JOB04()

        ElseIf Cms_3.Items(5).Selected = True Then
            Cms_3.Hide()
            MAIN_JOB05()
        End If
    End Sub

    Private Sub Me_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Width > 30 Then
            ItemMain.ItemSize = New Size((Me.Width - 30) / ItemMain.TabCount, 25)
        End If
    End Sub

    Private Sub vS20_KeyDown(sender As Object, e As KeyEventArgs) Handles vS20.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Dim StrMsg As String
                Dim intAutoKey As Integer
                Dim KEY_DateOutBoundMaterial As String
                Dim KEY_SeqOutBoundMaterial As String
                Dim KEY_SnoOutBoundMaterial As String


                KEY_DateOutBoundMaterial = getData(vS20, getColumIndex(vS20, "KEY_DateOutBoundMaterial"), vS20.ActiveSheet.ActiveRowIndex)
                KEY_SeqOutBoundMaterial = getData(vS20, getColumIndex(vS20, "KEY_SeqOutBoundMaterial"), vS20.ActiveSheet.ActiveRowIndex)
                KEY_SnoOutBoundMaterial = getData(vS20, getColumIndex(vS20, "KEY_SnoOutBoundMaterial"), vS20.ActiveSheet.ActiveRowIndex)



                If HLP2356A.Link_HLP3011Material(KEY_DateOutBoundMaterial, KEY_SeqOutBoundMaterial, KEY_SnoOutBoundMaterial) Then
                    If READ_PFK3011(hlp0000SeVa) Then
                        StrMsg = PrcExeNoError_Value("USP_PFK2356_UPDATE_AUTOKEY_PFK2360", cn, hlp0000SeVa, hlp0000SeVaTt, KEY_DateOutBoundMaterial, KEY_SeqOutBoundMaterial, KEY_SnoOutBoundMaterial)

                        MdiMenu.lbl_Status1.Text = StrMsg
                        MdiMenu.lbl_Status1.ForeColor = Color.Blue


                    End If


                End If




            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub vS10_GotFocus(sender As Object, e As EventArgs) Handles vS10.GotFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False)

        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False
    End Sub

    Private Sub vS10_LostFocus(sender As Object, e As EventArgs) Handles vS10.LostFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)
    End Sub
    Private Sub vS20_GotFocus(sender As Object, e As EventArgs) Handles vS20.GotFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)
    End Sub
    Private Sub vS20_LostFocus(sender As Object, e As EventArgs) Handles vS20.LostFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)
    End Sub
    Private Sub vS30_GotFocus(sender As Object, e As EventArgs) Handles vS30.GotFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, True, True, False, False, False)
    End Sub
    Private Sub vS30_LostFocus(sender As Object, e As EventArgs) Handles vS30.LostFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)
    End Sub

#End Region


End Class