Public Class PFP34219
#Region "Variable"
    Private Dsu01 As Long
    Private wGCODE As String
    Private Form_Close As Boolean
    Private chk_CheckIOType As String
    Private chk_CheckPurchasingOrder As String

#End Region

#Region "Form_load"

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim xISUD3421D As String = ISUD3421D.Text
        Dim xISUD3421P As String = ISUD3421P.Text

        Call Cms_additem(Cms_1,
                        xISUD3421D & " - " & WordConv("INPUT") & "(F5)",
                        xISUD3421D & " - " & WordConv("SEARCH") & "(F6)",
                        xISUD3421D & " - " & WordConv("UPDATE") & "(F7)",
                        xISUD3421D & " - " & WordConv("DELETE") & "(F8)",
                        "-",
                        xISUD3421P & " - " & WordConv("APPROVAL") & "(F9)",
                        xISUD3421P & " - " & WordConv("APPROVAL-ALL LINES") & "(F10)",
                        xISUD3421D & " - " & WordConv("UPDATE AFTER") & "(F11)",
                        xISUD3421D & " - " & WordConv("COPY") & "(F12)",
                          "-",
                        " OUTSOURCE GENERATE BARCODE - " & WordConv("BARCODE"))

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

        Me.KeyPreview = True

        Call FORM_INIT()
        Call DATA_INIT()


    End Sub
    Overrides Sub Function_Event(PressKey As Integer)
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


    Private Sub Clear_In()
        chk_CheckInPurchasingOrder1.Checked = False
        chk_CheckInPurchasingOrder2.Checked = False
        chk_CheckInPurchasingOrder3.Checked = False
        chk_CheckInPurchasingOrder4.Checked = False
        chk_CheckInPurchasingOrder5.Checked = False
        chk_CheckInPurchasingOrder6.Checked = False
        chk_CheckInPurchasingOrder7.Checked = False
        chk_CheckInPurchasingOrder8.Checked = False

        chk_CheckIOType0.Checked = False
    End Sub

    Private Sub Clear_Out()
        chk_CheckOutPurchasingOrder1.Checked = False
        chk_CheckOutPurchasingOrder2.Checked = False
        chk_CheckOutPurchasingOrder3.Checked = False
        chk_CheckOutPurchasingOrder4.Checked = False
        chk_CheckOutPurchasingOrder5.Checked = False
        chk_CheckOutPurchasingOrder6.Checked = False

        chk_CheckIOType1.Checked = False
    End Sub
    Private Sub FORM_INIT()
        chk_FSEL.CheckState = 1
        chk_FSEL.BackColor = clrCheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("CLOSE")
        ssp_WHERE.Visible = True

        If Me.PeaceFormType = "" Then Exit Sub

        Call Clear_In()
        Call Clear_Out()

        lbl_Check.Enabled = False
        Lbl_In.Enabled = False
        Lbl_Out.Enabled = False
        Pnl_In.Enabled = False
        Pnl_Out.Enabled = False

        Pnl_CheckWareHouse.Enabled = False
        pnl_CheckProcessType.Enabled = False
    End Sub

    Private Sub DATA_INIT()
        SdateEdate.text1 = System_Date_Add(-1)
        SdateEdate.text2 = System_Date_8()

        If READ_PFK7411(Pub.SAW) Then
            txt_InchargePurcharsing.Data = D7411.Name
            txt_InchargePurcharsing.Code = D7411.IDNO
        End If

        Select Case Strings.Right(Me.PeaceFormType, 2).ToUpper
            Case "I1"
                strFormType = "PURCHASING"
                chk_CheckIOType0.Checked = True
                chk_CheckProcessMaterial1.Checked = True
                chk_CheckInPurchasingOrder1.Checked = True
                chk_CheckIOType = "1"
                chk_CheckPurchasingOrder = "1"

            Case "I2"
                strFormType = "BALANCE"
                chk_CheckIOType0.Checked = True
                chk_CheckProcessMaterial1.Checked = True
                chk_CheckInPurchasingOrder2.Checked = True
                chk_CheckIOType = "1"
                chk_CheckPurchasingOrder = "2"

            Case "I3"
                strFormType = "PRODUCTION"
                chk_CheckIOType0.Checked = True
                chk_CheckInPurchasingOrder3.Checked = True
                chk_CheckIOType = "1"
                chk_CheckPurchasingOrder = "3"

            Case "I4"
                strFormType = "RETURN INSIDE"
                chk_CheckIOType0.Checked = True
                chk_CheckProcessMaterial1.Checked = True
                chk_CheckInPurchasingOrder4.Checked = True
                chk_CheckIOType = "1"
                chk_CheckPurchasingOrder = "4"

            Case "I5"
                strFormType = "RETURN OUTSIDE"
                chk_CheckIOType0.Checked = True
                chk_CheckProcessMaterial1.Checked = True
                chk_CheckInPurchasingOrder5.Checked = True
                chk_CheckIOType = "1"
                chk_CheckPurchasingOrder = "5"

            Case "I6"
                strFormType = "RETURN SALES"
                chk_CheckIOType0.Checked = True
                chk_CheckProcessMaterial1.Checked = True
                chk_CheckInPurchasingOrder6.Checked = True
                chk_CheckIOType = "1"
                chk_CheckPurchasingOrder = "6"

            Case "I7"
                strFormType = "RETURN TRASH"
                chk_CheckIOType0.Checked = True
                chk_CheckProcessMaterial1.Checked = True
                chk_CheckInPurchasingOrder7.Checked = True
                chk_CheckIOType = "1"
                chk_CheckPurchasingOrder = "7"

            Case "I8"
                strFormType = "RETURN PURCHASING"
                chk_CheckIOType0.Checked = True
                chk_CheckProcessMaterial1.Checked = True
                chk_CheckInPurchasingOrder8.Checked = True
                chk_CheckIOType = "1"
                chk_CheckPurchasingOrder = "8"

            Case "O1"
                strFormType = "INSIDE"
                chk_CheckIOType1.Checked = True
                chk_CheckProcessMaterial1.Checked = True
                chk_CheckOutPurchasingOrder1.Checked = True
                chk_CheckIOType = "2"
                chk_CheckPurchasingOrder = "1"


            Case "O2"
                strFormType = "BALANCE"
                chk_CheckIOType1.Checked = True
                chk_CheckProcessMaterial1.Checked = True
                chk_CheckOutPurchasingOrder2.Checked = True
                chk_CheckIOType = "2"
                chk_CheckPurchasingOrder = "2"

            Case "O3"
                strFormType = "SALES"
                chk_CheckIOType1.Checked = True
                chk_CheckProcessMaterial1.Checked = True
                chk_CheckOutPurchasingOrder3.Checked = True
                chk_CheckIOType = "2"
                chk_CheckPurchasingOrder = "3"

            Case "O4"
                strFormType = "TRASH"
                chk_CheckIOType1.Checked = True
                chk_CheckProcessMaterial1.Checked = True
                chk_CheckOutPurchasingOrder4.Checked = True
                chk_CheckIOType = "2"
                chk_CheckPurchasingOrder = "4"

            Case "O5"
                strFormType = "OUTSIDE"
                chk_CheckIOType1.Checked = True
                chk_CheckProcessMaterial1.Checked = True
                chk_CheckOutPurchasingOrder5.Checked = True
                chk_CheckIOType = "2"
                chk_CheckPurchasingOrder = "5"

            Case "O6"
                strFormType = "RETURN PURCHASING"
                chk_CheckProcessMaterial1.Checked = True
                chk_CheckIOType1.Checked = True
                chk_CheckOutPurchasingOrder5.Checked = True
                chk_CheckIOType = "2"
                chk_CheckPurchasingOrder = "6"

        End Select
    End Sub

#End Region

#Region "Function"
    Private Sub MAIN_JOB01()
        If ISUD3421D.Link_ISUD3421D(1, "000000000", chk_CheckIOType, chk_CheckPurchasingOrder, Me.Name) = False Then Exit Sub

        Call DATA_SEARCH01()
    End Sub

    Private Sub MAIN_JOB02()
        If getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        Dim FactOrderNo As String

        FactOrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderNo"), Vs1.ActiveSheet.ActiveRowIndex)

        If ISUD3421D.Link_ISUD3421D(2, FactOrderNo, chk_CheckIOType, chk_CheckPurchasingOrder, Me.Name) = False Then Exit Sub

    End Sub

    Private Sub MAIN_JOB03()
        If getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        Dim FactOrderNo As String

        FactOrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderNo"), Vs1.ActiveSheet.ActiveRowIndex)

        If ISUD3421D.Link_ISUD3421D(3, FactOrderNo, chk_CheckIOType, chk_CheckPurchasingOrder, Me.Name) = False Then Exit Sub

        Call DATA_SEARCH01() : Exit Sub

        If LINE_MOVE_DISPLAY01() = False Then
            SPR_CLEAR(Vs1, Vs1.ActiveSheet.ActiveRowIndex, 0, Vs1.ActiveSheet.ActiveRowIndex, Vs1.ActiveSheet.ColumnCount - 1)
            setData(Vs1, getColumIndex(Vs1, "DateAccept"), Vs1.ActiveSheet.ActiveRowIndex, "[DELETED]", Color.Red)
        End If
    End Sub

    Private Sub MAIN_JOB04()
        If getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        Dim FactOrderNo As String

        FactOrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderNo"), Vs1.ActiveSheet.ActiveRowIndex)

        If ISUD3421D.Link_ISUD3421D(4, FactOrderNo, chk_CheckIOType, chk_CheckPurchasingOrder, Me.Name) = False Then Exit Sub

        Call DATA_SEARCH01() : Exit Sub

        If LINE_MOVE_DISPLAY01() = False Then
            SPR_CLEAR(Vs1, Vs1.ActiveSheet.ActiveRowIndex, 0, Vs1.ActiveSheet.ActiveRowIndex, Vs1.ActiveSheet.ColumnCount - 1)
            setData(Vs1, getColumIndex(Vs1, "DateAccept"), Vs1.ActiveSheet.ActiveRowIndex, "[DELETED]", Color.Red)
        End If

    End Sub


    Private Sub MAIN_JOB05()
        If getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        Dim FactOrderNo As String
        FactOrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderNo"), Vs1.ActiveSheet.ActiveRowIndex)


        If ISUD3421P.Link_ISUD3421P(3, FactOrderNo,
                                    getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderSeq"), Vs1.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub

        Call DATA_SEARCH01() : Exit Sub

        If LINE_MOVE_DISPLAY01() = False Then
            SPR_CLEAR(Vs1, Vs1.ActiveSheet.ActiveRowIndex, 0, Vs1.ActiveSheet.ActiveRowIndex, Vs1.ActiveSheet.ColumnCount - 1)
            setData(Vs1, getColumIndex(Vs1, "DateAccept"), Vs1.ActiveSheet.ActiveRowIndex, "[DELETED]", Color.Red)
        End If

    End Sub

    Private Sub MAIN_JOB06()
        If getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        Dim FactOrderNo As String
        FactOrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderNo"), Vs1.ActiveSheet.ActiveRowIndex)

        If ISUD3421P.Link_ISUD3421P(4, FactOrderNo,
                                    getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderSeq"), Vs1.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub

        Call DATA_SEARCH01()

    End Sub


    Private Sub MAIN_JOB07()
        If getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        Dim FactOrderNo As String

        FactOrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderNo"), Vs1.ActiveSheet.ActiveRowIndex)

        If ISUD3421D.Link_ISUD3421D(5, FactOrderNo, chk_CheckIOType, chk_CheckPurchasingOrder, Me.Name) = False Then Exit Sub

        Call DATA_SEARCH01() : Exit Sub

        If LINE_MOVE_DISPLAY01() = False Then
            SPR_CLEAR(Vs1, Vs1.ActiveSheet.ActiveRowIndex, 0, Vs1.ActiveSheet.ActiveRowIndex, Vs1.ActiveSheet.ColumnCount - 1)
            setData(Vs1, getColumIndex(Vs1, "DateAccept"), Vs1.ActiveSheet.ActiveRowIndex, "[DELETED]", Color.Red)
        End If
    End Sub


    Private Sub MAIN_JOB08()
        If getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        Dim FactOrderNo As String

        FactOrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderNo"), Vs1.ActiveSheet.ActiveRowIndex)

        Dim cdSubProcess As String
        cdSubProcess = ""

        If ISUD7106D.Link_ISUD7106D("1", cdSubProcess) = True Then
            If cdSubProcess = "" Then Exit Sub

            If ISUD3421D.Link_ISUD3421D_INSERT(6, cdSubProcess, FactOrderNo, chk_CheckIOType, chk_CheckPurchasingOrder, Me.Name) = False Then Exit Sub

            Call DATA_SEARCH01() : Exit Sub

        End If

    End Sub

    Private Sub MAIN_JOB09()

        Dim cdFactory As String
        Dim cdLineProd As String
        Dim cdSeason As String
        Dim LineTno As String
        Dim CheckPlan As Integer
        Dim SealNo As String
        Dim SupplierCode As String

        Dim cdMainProcess As String

        cdSeason = getData(Vs1, getColumIndex(Vs1, "cdSeason"), Vs1.ActiveSheet.ActiveRowIndex)
        SealNo = getData(Vs1, getColumIndex(Vs1, "SlNo"), Vs1.ActiveSheet.ActiveRowIndex)

        SupplierCode = getData(Vs1, getColumIndex(Vs1, "SupplierCode"), Vs1.ActiveSheet.ActiveRowIndex)

        DS1 = PrcDS("Customertoline", cn, SupplierCode)

        If GetDsRc(DS1) <> 0 Then

            cdLineProd = FormatP(GetDsData(DS1, 0, "Key_Line"), "000")

        Else

            Call MsgBox("Khách hàng chưa chưa chọn gia công!")

        End If

        'cdMainProcess = "003"    'Stitching

        cdMainProcess = getData(Vs1, getColumIndex(Vs1, "cdBasicMaster"), Vs1.ActiveSheet.ActiveRowIndex)


        If cdLineProd <> "" Then

            CheckPlan = PrcExeNoError_Value("USP_PFK4073_INSERT_AUTO_SlNoD_Plancheck", cn, cdSeason, "051", cdMainProcess, cdLineProd, SealNo)

            If CheckPlan = "-1" Then Call MsgBox("Please make Work Order first!") : Exit Sub

            If CheckPlan <> "0" Then Call MsgBox("Already make Plan!") : Exit Sub

            DS1 = PrcDS("USP_PFK4073_INSERT_AUTO_SlNoD_SizeCheck_OUTSOURCE", cn, cdSeason, "051", cdMainProcess, cdLineProd, SealNo)

            LineTno = GetDsData(DS1, 0, 0)
            cdLineProd = GetDsData(DS1, 0, 1)

            If LineTno = "" Then Exit Sub

            If ISUD4073D_NC.Link_ISUD4073D(1, "051", cdMainProcess, cdLineProd, LineTno, "PFP34219") Then
                Me.Show()
                Application.DoEvents()

                If ISUD4073B_NC.Link_ISUD4073B(3, "051", cdMainProcess, cdLineProd, LineTno, Me.Name) = False Then Exit Sub

            End If

        Else
            MsgBoxP("Wrong Sealno ! (Sai số seal)", vbInformation)

        End If

    End Sub


#End Region

#Region "Data_search"
    Private Function DATA_SEARCH01(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH01 = False
        Vs1.Enabled = False

        If opt_G1.Checked = True Then

            DS1 = PrcDS("USP_PFP34219_SEARCH_VS1_GROUP", cn, SdateEdate.text1,
                                                        SdateEdate.text2,
                                                        txt_GCODE.chkAll.CheckState,
                                                        txt_GCODE.SQL,
                                                        txt_cdDepartment.Code,
                                                        txt_FactOrderNo.Data,
                                                        txt_cdFactory.Data,
                                                        txt_SupplierCode.Data,
                                                        txt_cdLargeGroupMaterial.Code,
                                                        txt_cdSemiGroupMaterial.Code,
                                                       "*" & txt_MaterialName.Data,
                                                        txt_InchargePurcharsing.Code,
                                                        CheckRequestMaterial,
                                                        CheckInPurchasingOrder,
                                                        CheckOutPurchasingOrder,
                                                        chk_CheckProcessMaterial0.CheckState,
                                                        chk_CheckProcessMaterial1.CheckState,
                                                        chk_CheckIOType0.CheckState,
                                                        chk_CheckIOType1.CheckState,
                                                        chk_CheckMaterialType0.CheckState,
                                                        chk_CheckMaterialType1.CheckState,
                                                        chk_CheckMarketType0.CheckState,
                                                        chk_CheckMarketType1.CheckState,
                                                        opt_CheckRelationType0.CheckState,
                                                        opt_CheckRelationType1.CheckState)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_PFP34219_SEARCH_VS1_GROUP", "Vs1")
                Vs1.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs1, DS1, "USP_PFP34219_SEARCH_VS1_GROUP", "Vs1")
            DATA_SEARCH01 = True

            Vs1.Enabled = True

        Else

            DS1 = PrcDS("USP_PFP34219_SEARCH_VS1_DETAIL", cn, SdateEdate.text1,
                                                       SdateEdate.text2,
                                                       txt_GCODE.chkAll.CheckState,
                                                       txt_GCODE.SQL,
                                                         txt_cdDepartment.Code,
                                                        txt_FactOrderNo.Data,
                                                        txt_cdFactory.Data,
                                                        txt_SupplierCode.Data,
                                                        txt_cdLargeGroupMaterial.Code,
                                                        txt_cdSemiGroupMaterial.Code,
                                                       "*" & txt_MaterialName.Data,
                                                        txt_InchargePurcharsing.Code,
                                                        CheckRequestMaterial,
                                                        CheckInPurchasingOrder,
                                                        CheckOutPurchasingOrder,
                                                       chk_CheckProcessMaterial0.CheckState,
                                                       chk_CheckProcessMaterial1.CheckState,
                                                       chk_CheckIOType0.CheckState,
                                                       chk_CheckIOType1.CheckState,
                                                       chk_CheckMaterialType0.CheckState,
                                                       chk_CheckMaterialType1.CheckState,
                                                       chk_CheckMarketType0.CheckState,
                                                       chk_CheckMarketType1.CheckState,
                                                       opt_CheckRelationType0.CheckState,
                                                       opt_CheckRelationType1.CheckState)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_PFP34219_SEARCH_VS1_DETAIL", "Vs1")
                Vs1.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs1, DS1, "USP_PFP34219_SEARCH_VS1_DETAIL", "Vs1")
            DATA_SEARCH01 = True

            Vs1.Enabled = True
        End If

    End Function

    Private Function LINE_MOVE_DISPLAY01() As Boolean
        LINE_MOVE_DISPLAY01 = False
        Dim FactOrderNo As String
        Dim FactOrderSeq As String

        FactOrderNo = getData(Vs1, getColumIndex(Vs1, "FactOrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
        FactOrderSeq = getData(Vs1, getColumIndex(Vs1, "FactOrderSeq"), Vs1.ActiveSheet.ActiveRowIndex)

        Try
            DS1 = PrcDS("USP_PFP34219_SEARCH_VS1_LINE", cn, FactOrderNo,
                                                        FactOrderSeq)

            If GetDsRc(DS1) = 0 Then
                Vs1.Enabled = True
                Exit Function
            End If

            READ_SPREAD(Vs1, DS1, "USP_PFP34219_SEARCH_VS1", "Vs1", Vs1.ActiveSheet.ActiveRowIndex)

            Vs1.Enabled = True
            LINE_MOVE_DISPLAY01 = True
        Catch ex As Exception
            MsgBoxP("LINE_MOVE_DISPLAY01")
        End Try
    End Function
    Private Function CheckRequestMaterial() As String
        CheckRequestMaterial = "9"
        If opt_SEL0.Checked = True Then CheckRequestMaterial = "1"
        If opt_SEL1.Checked = True Then CheckRequestMaterial = "2"
        If opt_SEL2.Checked = True Then CheckRequestMaterial = "3"
        If opt_SEL3.Checked = True Then CheckRequestMaterial = "4"
        If opt_SEL4.Checked = True Then CheckRequestMaterial = "6"
        If opt_SEL5.Checked = True Then CheckRequestMaterial = "9"
        Return CheckRequestMaterial
    End Function

    Private Function CheckInPurchasingOrder() As String
        Dim strCheckInPurchasingOrder = ""
        If chk_CheckInPurchasingOrder1.Checked = True Then If strCheckInPurchasingOrder = "" Then strCheckInPurchasingOrder = "1" Else strCheckInPurchasingOrder += "1"
        If chk_CheckInPurchasingOrder2.Checked = True Then If strCheckInPurchasingOrder = "" Then strCheckInPurchasingOrder = "2" Else strCheckInPurchasingOrder += ",2"
        If chk_CheckInPurchasingOrder3.Checked = True Then If strCheckInPurchasingOrder = "" Then strCheckInPurchasingOrder = "3" Else strCheckInPurchasingOrder += ",3"
        If chk_CheckInPurchasingOrder4.Checked = True Then If strCheckInPurchasingOrder = "" Then strCheckInPurchasingOrder = "4" Else strCheckInPurchasingOrder += ",4"
        If chk_CheckInPurchasingOrder5.Checked = True Then If strCheckInPurchasingOrder = "" Then strCheckInPurchasingOrder = "5" Else strCheckInPurchasingOrder += ",5"
        If chk_CheckInPurchasingOrder6.Checked = True Then If strCheckInPurchasingOrder = "" Then strCheckInPurchasingOrder = "6" Else strCheckInPurchasingOrder += ",6"
        If chk_CheckInPurchasingOrder7.Checked = True Then If strCheckInPurchasingOrder = "" Then strCheckInPurchasingOrder = "7" Else strCheckInPurchasingOrder += ",7"
        If chk_CheckInPurchasingOrder8.Checked = True Then If strCheckInPurchasingOrder = "" Then strCheckInPurchasingOrder = "8" Else strCheckInPurchasingOrder += ",8"

        Return strCheckInPurchasingOrder
    End Function

    Private Function CheckOutPurchasingOrder() As String
        Dim strCheckOutPurchasingOrder = ""
        If chk_CheckOutPurchasingOrder1.Checked = True Then If strCheckOutPurchasingOrder = "" Then strCheckOutPurchasingOrder = "1" Else strCheckOutPurchasingOrder += "1"
        If chk_CheckOutPurchasingOrder2.Checked = True Then If strCheckOutPurchasingOrder = "" Then strCheckOutPurchasingOrder = "2" Else strCheckOutPurchasingOrder += ",2"
        If chk_CheckOutPurchasingOrder3.Checked = True Then If strCheckOutPurchasingOrder = "" Then strCheckOutPurchasingOrder = "3" Else strCheckOutPurchasingOrder += ",3"
        If chk_CheckOutPurchasingOrder4.Checked = True Then If strCheckOutPurchasingOrder = "" Then strCheckOutPurchasingOrder = "4" Else strCheckOutPurchasingOrder += ",4"

        Return strCheckOutPurchasingOrder
    End Function

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
    Private Sub SelectMulti1_Load(sender As Object, e As EventArgs) Handles txt_GCODE.btnSelectClick
        Call OBJ_GCODE(txt_GCODE, "K7101_CustomerCode", "G1.")
    End Sub
    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        If e.ColumnHeader = True Then Exit Sub
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.AddSelection(e.Row, e.Column, 1, 1)
    End Sub

    Private Sub vS1_GotFocus(sender As Object, e As EventArgs) Handles Vs1.GotFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False
    End Sub
    Private Sub txt_GNAME_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Enter : cmd_SEARCH.Focus()
        End Select
    End Sub
    Private Sub vS1_LostFocus(sender As Object, e As EventArgs) Handles Vs1.LostFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False)

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

        Call DATA_SEARCH01()

    End Sub
    Private Sub Cms_1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_1.ItemClicked
        If Cms_1.Items(0).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB01()

        ElseIf Cms_1.Items(1).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB02()

        ElseIf Cms_1.Items(2).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB03()

        ElseIf Cms_1.Items(3).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB04()

        ElseIf Cms_1.Items(5).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB05()

        ElseIf Cms_1.Items(6).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB06()

        ElseIf Cms_1.Items(7).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB07()

        ElseIf Cms_1.Items(8).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB08()

        ElseIf Cms_1.Items(10).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB09()
        End If

    End Sub


#End Region

End Class