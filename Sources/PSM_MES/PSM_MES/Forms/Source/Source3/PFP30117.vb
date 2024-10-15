Public Class PFP30117
#Region "Variable"
    Private Dsu01 As Long
    Private wGCODE As String
    Private Form_Close As Boolean
#End Region

#Region "Form_load"

    Private Sub PFP30117_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control = True And e.KeyCode = Keys.G Then
            chk_Total.Checked = Not chk_Total.Checked
        End If
    End Sub
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)
        Dim xISUD3411B As String = ISUD3411B.Text

        Me.KeyPreview = True

        Call FORM_INIT()
        Call DATA_INIT()


        Call Cms_additem(Cms_1,
                        xISUD3411B & " - " & WordConv("INPUT") & "(F5)",
                        xISUD3411B & " - " & WordConv("SEARCH") & "(F6)",
                        xISUD3411B & " - " & WordConv("UPDATE") & "(F7)",
                        xISUD3411B & " - " & WordConv("DELETE") & "(F8)",
                        "-",
                        "PAYABLE REQUEST - " & WordConv("UN-COMPLETE") & "(F9)",
                         "-",
                        "PAYABLE REQUEST - " & WordConv("INSERT BY INVOICE") & "(F10)")


        vS30.ContextMenuStrip = Cms_1
        SdateEdate.text1 = System_Date_8()
        SdateEdate.text2 = System_Date_8()
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
    Private Sub FORM_INIT()
        chk_FSEL.CheckState = 1
        chk_FSEL.BackColor = clrCheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("CLOSE")
        ssp_WHERE.Visible = True

        Me.chk_FormEnterkey = False

        SplitContainer1.Panel1Collapsed = True
        SplitContainer2.Panel1Collapsed = True
        SplitContainer3.Panel1Collapsed = True

    End Sub

    Private Sub DATA_INIT()
        If Me.Name = "PFP30117RnD" Then
            chk_CheckSample.Checked = True
            chk_CheckSample.Enabled = False
        Else
            chk_CheckSample.Checked = False
            chk_CheckSample.Enabled = False
        End If

        txt_DateAccept.Data = Pub.DAT
    End Sub
#End Region

#Region "Function"
    Private Sub MAIN_JOB01()
        If ptc_1.SelectedIndex = 0 Then
            If ISUD3411B.Link_ISUD3411B(1, "000000000", "", "", "", Me.Name) = False Then Exit Sub

            Call DATA_SEARCH_VS10()

        ElseIf ptc_1.SelectedIndex = 1 Then
            MAIN_JOB01_AUTO()

        ElseIf ptc_1.SelectedIndex = 2 Then
            If ISUD3428A.Link_ISUD3428A(1, "000000000", "3", "PFP34281") = False Then Exit Sub

        End If
       
    End Sub
    Private Sub MAIN_JOB01_AUTO()

        Dim CheckTypePayable As Integer

        Try

            CheckTypePayable = "1"

            hlp0000SeVa = ""
            hlp0000SeVaTt = ""

            Dim i As Integer
            Dim CheckValue As Boolean = False

            For i = 0 To vS21.ActiveSheet.RowCount - 1
                If getDataM(vS21, getColumIndex(vS21, "DCHK"), i) = "1" Then
                    CheckValue = True
                    hlp0000SeVa &= "''" & getData(vS21, getColumIndex(vS21, "KEY_FactOrderNoSeq"), i) & "''"
                    hlp0000SeVa &= ","

                End If
            Next

            hlp0000SeVa = Strings.Left(hlp0000SeVa, Len(hlp0000SeVa) - 1)
            hlp0000SeVaTt = hlp0000SeVa

            If ISUD3428A.Link_ISUD3428A_AUTO(1, "000000000", CheckTypePayable, hlp0000SeVaTt, "PFP34281") = False Then Exit Sub
            ptc_1.SelectedIndex = 2

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB01!", vbCritical)
        End Try

    End Sub




    Private Sub MAIN_JOB02()

        If ptc_1.SelectedIndex = 0 Then
            If getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

            Dim PurchasingOrderNo As String
            Dim DateInvoice As String
            Dim InvoiceNo As String
            Dim SupplierCode As String

            PurchasingOrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
            DateInvoice = getData(Vs1, getColumIndex(Vs1, "KEY_DateInvoice"), Vs1.ActiveSheet.ActiveRowIndex)
            InvoiceNo = getData(Vs1, getColumIndex(Vs1, "KEY_InvoiceNo"), Vs1.ActiveSheet.ActiveRowIndex)
            SupplierCode = getData(Vs1, getColumIndex(Vs1, "KEY_SupplierCode"), Vs1.ActiveSheet.ActiveRowIndex)

            If ISUD3411B.Link_ISUD3411B(2, PurchasingOrderNo, SupplierCode, InvoiceNo, DateInvoice, Me.Name) = False Then Exit Sub
        ElseIf ptc_1.SelectedIndex = 2 Then

            If ISUD3428A.Link_ISUD3428A(2, getData(vS30, getColumIndex(vS30, "KEY_PayableNo"), vS30.ActiveSheet.ActiveRowIndex), "1", "PFP34281") = False Then Exit Sub

        End If

    End Sub

    Private Sub MAIN_JOB03()
        If ptc_1.SelectedIndex = 0 Then
            If getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

            Dim PurchasingOrderNo As String
            Dim DateInvoice As String
            Dim InvoiceNo As String
            Dim SupplierCode As String

            PurchasingOrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
            DateInvoice = getData(Vs1, getColumIndex(Vs1, "KEY_DateInvoice"), Vs1.ActiveSheet.ActiveRowIndex)


            If getColumName(Vs1, Vs1.ActiveSheet.ActiveColumnIndex).ToUpper.Contains("INVOICE") = False Then Exit Sub

            InvoiceNo = getData(Vs1, Vs1.ActiveSheet.ActiveColumnIndex, Vs1.ActiveSheet.ActiveRowIndex)
            SupplierCode = getData(Vs1, getColumIndex(Vs1, "KEY_SupplierCode"), Vs1.ActiveSheet.ActiveRowIndex)

            If ISUD3411B.Link_ISUD3411B(3, PurchasingOrderNo, SupplierCode, InvoiceNo, DateInvoice, Me.Name) = False Then Exit Sub

            Call DATA_SEARCH_VS10() : Exit Sub

            If LINE_MOVE_DISPLAY01() = False Then
                SPR_CLEAR(Vs1, Vs1.ActiveSheet.ActiveRowIndex, 0, Vs1.ActiveSheet.ActiveRowIndex, Vs1.ActiveSheet.ColumnCount - 1)
                setData(Vs1, getColumIndex(Vs1, "DateAccept"), Vs1.ActiveSheet.ActiveRowIndex, "[DELETED]", Color.Red)
            End If

        ElseIf ptc_1.SelectedIndex = 2 Then

            If ISUD3428A.Link_ISUD3428A(3, getData(vS30, getColumIndex(vS30, "KEY_PayableNo"), vS30.ActiveSheet.ActiveRowIndex), "1", "PFP34281") = False Then Exit Sub

        End If
    End Sub

    Private Sub MAIN_JOB04()
        If ptc_1.SelectedIndex = 0 Then
            If getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

            Dim PurchasingOrderNo As String
            Dim DateInvoice As String
            Dim InvoiceNo As String
            Dim SupplierCode As String

            PurchasingOrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
            DateInvoice = getData(Vs1, getColumIndex(Vs1, "KEY_DateInvoice"), Vs1.ActiveSheet.ActiveRowIndex)
            InvoiceNo = getData(Vs1, getColumIndex(Vs1, "KEY_InvoiceNo"), Vs1.ActiveSheet.ActiveRowIndex)
            SupplierCode = getData(Vs1, getColumIndex(Vs1, "KEY_SupplierCode"), Vs1.ActiveSheet.ActiveRowIndex)

            If ISUD3411B.Link_ISUD3411B(4, PurchasingOrderNo, SupplierCode, InvoiceNo, DateInvoice, Me.Name) = False Then Exit Sub

            Call DATA_SEARCH_VS10() : Exit Sub

            If LINE_MOVE_DISPLAY01() = False Then
                SPR_CLEAR(Vs1, Vs1.ActiveSheet.ActiveRowIndex, 0, Vs1.ActiveSheet.ActiveRowIndex, Vs1.ActiveSheet.ColumnCount - 1)
                setData(Vs1, getColumIndex(Vs1, "DateAccept"), Vs1.ActiveSheet.ActiveRowIndex, "[DELETED]", Color.Red)
            End If
        ElseIf ptc_1.SelectedIndex = 2 Then

            If ISUD3428A.Link_ISUD3428A(4, getData(vS30, getColumIndex(vS30, "KEY_PayableNo"), vS30.ActiveSheet.ActiveRowIndex), "1", "PFP34281") = False Then Exit Sub

        End If
    End Sub


    Private Sub MAIN_JOB05()
        Try
            Try
                Dim i As Integer
                Dim ShoesCode As String
                Dim StrMsg As String

                StrMsg = MsgBox("Do you want to UN-COMPLETE BOM?", vbYesNo)

                If StrMsg <> vbYes Then Exit Sub

                Dim PayableNo As String
                PayableNo = getData(vS30, getColumIndex(vS30, "PayableNo"), vS30.ActiveSheet.ActiveRowIndex)

                If MsgBoxPPW("Please type the password to uncompete!", const_pwPay) = False Then Exit Sub

                If READ_PFK3428(PayableNo) Then
                    D3428.CheckComplete = "2"
                    D3428.DateUpdate = Pub.DAT
                    D3428.InchargeUpdate = Pub.SAW
                    Call REWRITE_PFK3428(D3428)
                End If

            Catch ex As Exception

            End Try

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB05!", vbCritical)
        End Try

    End Sub

    Private Sub MAIN_JOB06()

    End Sub

    Private Sub MAIN_JOB07()
        If ptc_1.SelectedIndex = 0 Then
          

        ElseIf ptc_1.SelectedIndex = 1 Then
            Dim CheckTypePayable As Integer = "1"

            hlp0000SeVa = ""
            hlp0000SeVaTt = ""

            hlp0000SeVa = getDataActiveSheet(vS21)

            str = MsgBox("Do you want to input this invoice " + hlp0000SeVa + " ?", vbYesNo)
            If str <> vbYes Then Exit Sub

            hlp0000SeVaTt = hlp0000SeVa

            If ISUD3428A.Link_ISUD3428A_AUTO(101, "000000000", CheckTypePayable, hlp0000SeVaTt, "PFP34281") = False Then Exit Sub
            ptc_1.SelectedIndex = 2

        End If


    End Sub

#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS10(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS10 = False
        Vs1.Enabled = False

        DS1 = PrcDS("USP_PFP30117A_SEARCH_VS1_F2", cn, SdateEdate.text1,
                                                  SdateEdate.text2,
                                                  txt_PRName.Data,
                                                  txt_cdSite.Code,
                                                  txt_CustomerCode.Code,
                                                  txt_SupplierCode.Code,
                                                  txt_Article.Data,
                                                  txt_Line.Data,
                                                  txt_MaterialCode.Data,
                                                  txt_cdLargeGroupMaterial.Code,
                                                  txt_cdSemiGroupMaterial.Code,
                                                  txt_cdDetailGroupMaterial.Code,
                                                  chk_Complete1.CheckState,
                                                  chk_Period.CheckState, txt_Invoice.Data, txt_cdSupplierGroup.Code)
        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs1, DS1, "USP_PFP30117A_SEARCH_VS1_F2", "Vs1")
            SPR_TEXTBOXM(Vs1, getColumIndex(Vs1, "ARemark"))
            Vs1.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "USP_PFP30117A_SEARCH_VS1_F2", "Vs1")
        SPR_TEXTBOXM(Vs1, getColumIndex(Vs1, "ARemark"))
        DATA_SEARCH_VS10 = True

        Vs1.Enabled = True



    End Function

    Private Function DATA_SEARCH_VS20(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS20 = False
        vS20.Enabled = False

        DS1 = PrcDS("USP_PFP30117A_SEARCH_vS20", cn, SdateEdate.text1,
                                                  SdateEdate.text2,
                                                   txt_cdSite.Code)
        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS20, DS1, "USP_PFP30117A_SEARCH_vS20", "vS20")
            vS20.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS20, DS1, "USP_PFP30117A_SEARCH_vS20", "vS20")
        DATA_SEARCH_VS20 = True

        vS20.Enabled = True

    End Function

    Private Function DATA_SEARCH_VS30(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS30 = False
        vS30.Enabled = False

        DS1 = PrcDS("USP_PFP30117A_SEARCH_vS30", cn, SdateEdate.text1,
                                                  SdateEdate.text2,
                                                   txt_cdSite.Code)
        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS30, DS1, "USP_PFP30117A_SEARCH_vS30", "vS30")
            vS30.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS30, DS1, "USP_PFP30117A_SEARCH_vS30", "vS30")
        DATA_SEARCH_VS30 = True

        vS30.Enabled = True



    End Function

    Private Function DATA_SEARCH_VS21(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS21 = False
        vS21.Enabled = False
        Dim SupplierCode As String
        SupplierCode = getData(vS20, getColumIndex(vS20, "KEY_SupplierCode"), vS20.ActiveSheet.ActiveRowIndex)

        If SupplierCode = "" Then Exit Function

        DS1 = PrcDS("USP_PFP30117A_SEARCH_VS21", cn, SupplierCode, SdateEdate.text1,
                                                  SdateEdate.text2,
                                                  txt_PRName.Data,
                                                  txt_cdSite.Code,
                                                  txt_CustomerCode.Code,
                                                  txt_SupplierCode.Code,
                                                  txt_Article.Data,
                                                  txt_Line.Data,
                                                  txt_MaterialCode.Data,
                                                  txt_cdLargeGroupMaterial.Code,
                                                  txt_cdSemiGroupMaterial.Code,
                                                  txt_cdDetailGroupMaterial.Code,
                                                  chk_Complete1.CheckState,
                                                  chk_Period.CheckState)
        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS21, DS1, "USP_PFP30117A_SEARCH_VS21", "VS21")
            vS21.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS21, DS1, "USP_PFP30117A_SEARCH_VS21", "VS21")
        DATA_SEARCH_VS21 = True

        vS21.Enabled = True



    End Function

    Private Function DATA_SEARCH_VS31(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS31 = False
        vS31.Enabled = False
        Dim PayableNo As String
        PayableNo = getData(vS30, getColumIndex(vS30, "KEY_PayableNo"), vS30.ActiveSheet.ActiveRowIndex)

        If PayableNo = "" Then Exit Function

        DS1 = PrcDS("USP_PFP30117A_SEARCH_VS31", cn, PayableNo)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS31, DS1, "USP_PFP30117A_SEARCH_VS31", "VS31")
            vS31.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS31, DS1, "USP_PFP30117A_SEARCH_VS31", "VS31")
        DATA_SEARCH_VS31 = True

        vS31.Enabled = True



    End Function

    Private Function DATA_SEARCH_vS40(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_vS40 = False
        vS40.Enabled = False

        DS1 = PrcDS("USP_PFP30117A_SEARCH_vS40", cn, SdateEdate.text1,
                                                  SdateEdate.text2,
                                                   txt_cdSite.Code)
        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS40, DS1, "USP_PFP30117A_SEARCH_vS40", "vS40")
            vS40.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS40, DS1, "USP_PFP30117A_SEARCH_vS40", "vS40")
        DATA_SEARCH_vS40 = True

        vS40.Enabled = True



    End Function


    Public Function DATA_SEARCH_HEAD_vs_Season() As Boolean
        DATA_SEARCH_HEAD_vs_Season = False

        Try
            DS1 = PrcDS("USP_PFP30117_SEARCH_VS_SEASON", cn, ListCode("Season"))
            SPR_PRO_NEW(vs_Season, DS1, "USP_PFP30117_SEARCH_VS_SEASON", "vs_Season")

            DS1 = Nothing
            DATA_SEARCH_HEAD_vs_Season = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Public Function DATA_SEARCH_HEAD_vS_Cus() As Boolean
        DATA_SEARCH_HEAD_vS_Cus = False

        Dim cdSeason As String
        cdSeason = getData(vs_Season, getColumIndex(vs_Season, "BasicCode"), vs_Season.ActiveSheet.ActiveRowIndex)


        If READ_PFK7171(ListCode("Season"), cdSeason) Then
            txt_cdSite.Code = D7171.BasicCode
            txt_cdSite.Data = D7171.BasicName
        End If


        Try
            If chk_Period.Checked = True Then
                DS1 = PrcDS("USP_PFP30117_SEARCH_vS_Cus_F1", cn, SdateEdate.text1, SdateEdate.text2, txt_CustomerCode.Code, cdSeason,
                                                       chk_CheckSample.CheckState)
                SPR_PRO_NEW(vS_Cus, DS1, "USP_PFP30117_SEARCH_vS_Cus_F1", "vS_Cus")

                SplitContainer1.SplitterDistance = SPR_SHEETWIDHT(vS_Cus) + cSprWidthSize

                DS1 = Nothing
                DATA_SEARCH_HEAD_vS_Cus = True

            Else
                DS1 = PrcDS("USP_PFP30117_SEARCH_vS_Cus", cn, txt_CustomerCode.Code, cdSeason,
                                                       chk_CheckSample.CheckState)
                SPR_PRO_NEW(vS_Cus, DS1, "USP_PFP30117_SEARCH_vS_Cus", "vS_Cus")

                SplitContainer1.SplitterDistance = SPR_SHEETWIDHT(vS_Cus) + cSprWidthSize

                DS1 = Nothing
                DATA_SEARCH_HEAD_vS_Cus = True
            End If


        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Public Function DATA_SEARCH_HEAD_vS_Line() As Boolean
        DATA_SEARCH_HEAD_vS_Line = False
        Dim cdSeason As String
        Dim CustomerCode As String

        cdSeason = getData(vs_Season, getColumIndex(vs_Season, "BasicCode"), vs_Season.ActiveSheet.ActiveRowIndex)
        CustomerCode = getData(vS_Cus, getColumIndex(vS_Cus, "CustomerCode"), vS_Cus.ActiveSheet.ActiveRowIndex)

        If READ_PFK7171(ListCode("Season"), cdSeason) Then
            txt_cdSite.Code = D7171.BasicCode
            txt_cdSite.Data = D7171.BasicName
        End If

        If READ_PFK7101(CustomerCode) Then
            txt_SupplierCode.Code = D7101.CustomerCode
            txt_SupplierCode.Data = D7101.CustomerName
        End If

        Try
            If chk_Period.Checked = True Then
                DS1 = PrcDS("USP_PFP30117_SEARCH_vS_Line_F1", cn, SdateEdate.text1, SdateEdate.text2, cdSeason, CustomerCode,
                                                       chk_CheckSample.CheckState)

                SPR_PRO_NEW(vS_Line, DS1, "USP_PFP30117_SEARCH_vS_Line_F1", "vS_Line")
                SplitContainer2.SplitterDistance = SPR_SHEETWIDHT(vS_Line) + cSprWidthSize

                DS1 = Nothing
                DATA_SEARCH_HEAD_vS_Line = True

            Else
                DS1 = PrcDS("USP_PFP30117_SEARCH_vS_Line", cn, cdSeason, CustomerCode,
                                                       chk_CheckSample.CheckState)

                SPR_PRO_NEW(vS_Line, DS1, "USP_PFP30117_SEARCH_vS_Line", "vS_Line")
                SplitContainer2.SplitterDistance = SPR_SHEETWIDHT(vS_Line) + cSprWidthSize

                DS1 = Nothing
                DATA_SEARCH_HEAD_vS_Line = True
            End If


        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Public Function DATA_SEARCH_HEAD_vs_Large() As Boolean
        DATA_SEARCH_HEAD_vs_Large = False
        Dim cdSeason As String
        Dim CustomerCode As String
        Dim Line As String

        cdSeason = getData(vs_Season, getColumIndex(vs_Season, "BasicCode"), vs_Season.ActiveSheet.ActiveRowIndex)
        CustomerCode = getData(vS_Cus, getColumIndex(vS_Cus, "CustomerCode"), vS_Cus.ActiveSheet.ActiveRowIndex)
        Line = getData(vS_Line, getColumIndex(vS_Line, "Line"), vS_Line.ActiveSheet.ActiveRowIndex)

        Try
            If chk_Period.Checked = True Then
                DS1 = PrcDS("USP_PFP30117_SEARCH_vS_Large_F1", cn, SdateEdate.text1, SdateEdate.text2, ListCode("LargeGroupMaterial"), CustomerCode, cdSeason, Line,
                                                      chk_CheckSample.CheckState)

                SPR_PRO_NEW(vs_Large, DS1, "USP_PFP30117_SEARCH_vS_Large_F1", "vs_Large")
                SplitContainer2.SplitterDistance = SPR_SHEETWIDHT(vs_Large) + cSprWidthSize

                DS1 = Nothing
                DATA_SEARCH_HEAD_vs_Large = True

            Else
                DS1 = PrcDS("USP_PFP30117_SEARCH_vS_Large", cn, ListCode("LargeGroupMaterial"), CustomerCode, cdSeason, Line,
                                                    chk_CheckSample.CheckState)

                SPR_PRO_NEW(vs_Large, DS1, "USP_PFP30117_SEARCH_vS_Large", "vs_Large")
                SplitContainer2.SplitterDistance = SPR_SHEETWIDHT(vs_Large) + cSprWidthSize

                DS1 = Nothing
                DATA_SEARCH_HEAD_vs_Large = True
            End If


        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function


    Private Function LINE_MOVE_DISPLAY01() As Boolean
        LINE_MOVE_DISPLAY01 = False
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
    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        If e.ColumnHeader = True Then Exit Sub
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.AddSelection(e.Row, e.Column, 1, 1)
    End Sub

    Private Sub Vs1_Change(sender As Object, e As ChangeEventArgs) Handles Vs1.Change, vS21.Change
        Try
            Dim KEY_Autokey As Decimal
            Dim intRow As Integer = e.Row

            KEY_Autokey = CDecp(getData(sender, getColumIndex(sender, "KEY_Autokey"), intRow))

            If READ_PFK3011(KEY_Autokey) Then
                D3011.QtyBooking = CDecp(getData(sender, getColumIndex(sender, "QtyBooking"), intRow))

                Call REWRITE_PFK3011(D3011)
            End If

            If READ_PFK3412(getData(sender, getColumIndex(sender, "KEY_PurchasingOrderNo"), intRow), getData(sender, getColumIndex(sender, "KEY_PurchasingOrderSeq"), intRow)) Then
                D3412.QtyBooking = CDecp(getData(sender, getColumIndex(sender, "QtyBooking"), intRow))
                D3412.QtyPurchasingMOQ = CDecp(getData(sender, getColumIndex(sender, "QtyPurchasingMOQ"), intRow))
                D3412.QtyPurchasing = CDecp(getData(sender, getColumIndex(sender, "QtyPurchasing"), intRow))
                D3412.QtyPurchasingNet = CDecp(getData(sender, getColumIndex(sender, "QtyPurchasingNet"), intRow))

                D3412.DateDelivery = FormatCut(getData(sender, getColumIndex(sender, "DateDelivery"), intRow))
                D3412.DateStart = FormatCut(getData(sender, getColumIndex(sender, "DateStart"), intRow))

                D3412.PricePurchasing = CDecp(getData(sender, getColumIndex(sender, "PricePurchasing"), intRow))

                If getDataM(sender, getColumIndex(sender, "CheckComplete"), intRow) = "1" Then
                    D3412.CheckComplete = "1"
                Else
                    D3412.CheckComplete = "2"
                End If


                D3412.QtyAArrive1 = CDecp(getData(sender, getColumIndex(sender, "QtyAArrive1"), intRow))
                D3412.QtyAArrive2 = CDecp(getData(sender, getColumIndex(sender, "QtyAArrive2"), intRow))
                D3412.QtyAArrive3 = CDecp(getData(sender, getColumIndex(sender, "QtyAArrive3"), intRow))
                D3412.QtyAArrive4 = CDecp(getData(sender, getColumIndex(sender, "QtyAArrive4"), intRow))
                D3412.QtyAArrive5 = CDecp(getData(sender, getColumIndex(sender, "QtyAArrive5"), intRow))
                D3412.QtyAArrive6 = CDecp(getData(sender, getColumIndex(sender, "QtyAArrive6"), intRow))
                D3412.QtyAArrive7 = CDecp(getData(sender, getColumIndex(sender, "QtyAArrive7"), intRow))
                D3412.QtyAArrive8 = CDecp(getData(sender, getColumIndex(sender, "QtyAArrive8"), intRow))
                D3412.QtyAArrive9 = CDecp(getData(sender, getColumIndex(sender, "QtyAArrive9"), intRow))
                D3412.QtyAArrive10 = CDecp(getData(sender, getColumIndex(sender, "QtyAArrive10"), intRow))

                D3412.QtyATotal = D3412.QtyAArrive1 + D3412.QtyAArrive2 + D3412.QtyAArrive3 + D3412.QtyAArrive4 + D3412.QtyAArrive5 + D3412.QtyAArrive6 + D3412.QtyAArrive7 + D3412.QtyAArrive8 + D3412.QtyAArrive9 + D3412.QtyAArrive10


                D3412.DateArrive1 = FormatCut(getData(sender, getColumIndex(sender, "DateArrive1"), intRow))
                D3412.DateArrive2 = FormatCut(getData(sender, getColumIndex(sender, "DateArrive2"), intRow))
                D3412.DateArrive3 = FormatCut(getData(sender, getColumIndex(sender, "DateArrive3"), intRow))
                D3412.DateArrive4 = FormatCut(getData(sender, getColumIndex(sender, "DateArrive4"), intRow))
                D3412.DateArrive5 = FormatCut(getData(sender, getColumIndex(sender, "DateArrive5"), intRow))
                D3412.DateArrive6 = FormatCut(getData(sender, getColumIndex(sender, "DateArrive6"), intRow))
                D3412.DateArrive7 = FormatCut(getData(sender, getColumIndex(sender, "DateArrive7"), intRow))
                D3412.DateArrive8 = FormatCut(getData(sender, getColumIndex(sender, "DateArrive8"), intRow))
                D3412.DateArrive9 = FormatCut(getData(sender, getColumIndex(sender, "DateArrive9"), intRow))
                D3412.DateArrive10 = FormatCut(getData(sender, getColumIndex(sender, "DateArrive10"), intRow))

                D3412.InvoiceNo1 = getData(sender, getColumIndex(sender, "InvoiceNo1"), intRow)
                D3412.InvoiceNo2 = getData(sender, getColumIndex(sender, "InvoiceNo2"), intRow)
                D3412.InvoiceNo3 = getData(sender, getColumIndex(sender, "InvoiceNo3"), intRow)
                D3412.InvoiceNo4 = getData(sender, getColumIndex(sender, "InvoiceNo4"), intRow)
                D3412.InvoiceNo5 = getData(sender, getColumIndex(sender, "InvoiceNo5"), intRow)
                D3412.InvoiceNo6 = getData(sender, getColumIndex(sender, "InvoiceNo6"), intRow)
                D3412.InvoiceNo7 = getData(sender, getColumIndex(sender, "InvoiceNo7"), intRow)
                D3412.InvoiceNo8 = getData(sender, getColumIndex(sender, "InvoiceNo8"), intRow)
                D3412.InvoiceNo9 = getData(sender, getColumIndex(sender, "InvoiceNo9"), intRow)
                D3412.InvoiceNo10 = getData(sender, getColumIndex(sender, "InvoiceNo10"), intRow)

                D3412.ARemark = getData(sender, getColumIndex(sender, "ARemark"), intRow)
                'D3412.AInvoice = getData(sender, getColumIndex(sender, "AInvoice"), intRow)
                D3412.APLName = getData(sender, getColumIndex(sender, "APLName"), intRow)

                D3412.AInvoice = D3412.InvoiceNo1 + IIf(D3412.InvoiceNo2 <> "", "," + D3412.InvoiceNo2, "")
                D3412.AInvoice += IIf(D3412.InvoiceNo3 <> "", "," + D3412.InvoiceNo3, "")
                D3412.AInvoice += IIf(D3412.InvoiceNo4 <> "", "," + D3412.InvoiceNo4, "")
                D3412.AInvoice += IIf(D3412.InvoiceNo5 <> "", "," + D3412.InvoiceNo5, "")
                D3412.AInvoice += IIf(D3412.InvoiceNo6 <> "", "," + D3412.InvoiceNo6, "")
                D3412.AInvoice += IIf(D3412.InvoiceNo7 <> "", "," + D3412.InvoiceNo7, "")
                D3412.AInvoice += IIf(D3412.InvoiceNo8 <> "", "," + D3412.InvoiceNo8, "")
                D3412.AInvoice += IIf(D3412.InvoiceNo9 <> "", "," + D3412.InvoiceNo9, "")
                D3412.AInvoice += IIf(D3412.InvoiceNo10 <> "", "," + D3412.InvoiceNo10, "")


                D3412.cdUnitMaterialA = FormatCut(getData(sender, getColumIndex(sender, "cdUnitMaterialA"), intRow))
                D3412.cdUnitPriceA = FormatCut(getData(sender, getColumIndex(sender, "cdUnitPriceA"), intRow))

                D3412.PriceAPurchasing = CDecp(getData(sender, getColumIndex(sender, "PriceAPurchasing"), intRow))

                D3412.AmtAPurchasing = CDecp(getData(sender, getColumIndex(sender, "AmtAPurchasing"), intRow))
                D3412.AmtATotal = CDecp(getData(sender, getColumIndex(sender, "AmtATotal"), intRow))
                D3412.AmtATotal = D3412.QtyATotal * D3412.PricePurchasing

                D3412.InchargeInvoice = Pub.SAW


                Call REWRITE_PFK3412(D3412)



            End If

        Catch ex As Exception

        End Try
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

    Private Sub Vs1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown, vS21.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Dim KEY_Autokey As Decimal
                Dim intRow As Integer = sender.ActiveSheet.ActiveRowIndex

                KEY_Autokey = CDecp(getData(sender, getColumIndex(sender, "KEY_Autokey"), intRow))

                If READ_PFK3011(KEY_Autokey) Then
                    D3011.QtyBooking = CDecp(getData(sender, getColumIndex(sender, "QtyBooking"), intRow))


                    Call REWRITE_PFK3011(D3011)
                End If

                If READ_PFK3412(getData(sender, getColumIndex(sender, "KEY_PurchasingOrderNo"), intRow), getData(sender, getColumIndex(sender, "KEY_PurchasingOrderSeq"), intRow)) Then
                    If D3412.CheckPurchasing = "2" Then Exit Sub
                    D3412.QtyBooking = CDecp(getData(sender, getColumIndex(sender, "QtyBooking"), intRow))
                    D3412.QtyPurchasingMOQ = CDecp(getData(sender, getColumIndex(sender, "QtyPurchasingMOQ"), intRow))
                    D3412.QtyPurchasing = CDecp(getData(sender, getColumIndex(sender, "QtyPurchasing"), intRow))
                    D3412.QtyPurchasingNet = CDecp(getData(sender, getColumIndex(sender, "QtyPurchasingNet"), intRow))
                    D3412.DateDelivery = FormatCut(getData(sender, getColumIndex(sender, "DateDelivery"), intRow))

                    Call READ_PFK3411(D3412.PurchasingOrderNo)
                    Dim DateStart As String

                    If READ_PFK7101(D3411.SupplierCode) Then
                        If D7101.cdSupplierGroup <> "001" And D7101.cdSupplierGroup <> "002" Then
                            D3412.DateStart = FormatCut(getData(sender, getColumIndex(sender, "DateStart"), intRow))

                        Else
                            If D7101.cdSupplierGroup = "001" Then DateStart = Function_Date_Add(CDate(FSDate(D3412.DateDelivery)), 0, 7)
                            If D7101.cdSupplierGroup = "002" Then DateStart = Function_Date_Add(CDate(FSDate(D3412.DateDelivery)), 0, 12)
                            D3412.DateStart = FormatCut(DateStart)
                            setData(sender, getColumIndex(sender, "DateStart"), intRow, D3412.DateStart)
                        End If


                    End If


                  

                    D3412.PricePurchasing = CDecp(getData(sender, getColumIndex(sender, "PricePurchasing"), intRow))

                    If getDataM(sender, getColumIndex(sender, "CheckComplete"), intRow) = "1" Then
                        D3412.CheckComplete = "1"
                    Else
                        D3412.CheckComplete = "2"
                    End If

                    D3412.QtyAArrive1 = CDecp(getData(sender, getColumIndex(sender, "QtyAArrive1"), intRow))
                    D3412.QtyAArrive2 = CDecp(getData(sender, getColumIndex(sender, "QtyAArrive2"), intRow))
                    D3412.QtyAArrive3 = CDecp(getData(sender, getColumIndex(sender, "QtyAArrive3"), intRow))
                    D3412.QtyAArrive4 = CDecp(getData(sender, getColumIndex(sender, "QtyAArrive4"), intRow))
                    D3412.QtyAArrive5 = CDecp(getData(sender, getColumIndex(sender, "QtyAArrive5"), intRow))
                    D3412.QtyAArrive6 = CDecp(getData(sender, getColumIndex(sender, "QtyAArrive6"), intRow))
                    D3412.QtyAArrive7 = CDecp(getData(sender, getColumIndex(sender, "QtyAArrive7"), intRow))
                    D3412.QtyAArrive8 = CDecp(getData(sender, getColumIndex(sender, "QtyAArrive8"), intRow))
                    D3412.QtyAArrive9 = CDecp(getData(sender, getColumIndex(sender, "QtyAArrive9"), intRow))
                    D3412.QtyAArrive10 = CDecp(getData(sender, getColumIndex(sender, "QtyAArrive10"), intRow))

                    D3412.QtyATotal = D3412.QtyAArrive1 + D3412.QtyAArrive2 + D3412.QtyAArrive3 + D3412.QtyAArrive4 + D3412.QtyAArrive5 + D3412.QtyAArrive6 + D3412.QtyAArrive7 + D3412.QtyAArrive8 + D3412.QtyAArrive9 + D3412.QtyAArrive10


                    D3412.DateArrive1 = FormatCut(getData(sender, getColumIndex(sender, "DateArrive1"), intRow))
                    D3412.DateArrive2 = FormatCut(getData(sender, getColumIndex(sender, "DateArrive2"), intRow))
                    D3412.DateArrive3 = FormatCut(getData(sender, getColumIndex(sender, "DateArrive3"), intRow))
                    D3412.DateArrive4 = FormatCut(getData(sender, getColumIndex(sender, "DateArrive4"), intRow))
                    D3412.DateArrive5 = FormatCut(getData(sender, getColumIndex(sender, "DateArrive5"), intRow))
                    D3412.DateArrive6 = FormatCut(getData(sender, getColumIndex(sender, "DateArrive6"), intRow))
                    D3412.DateArrive7 = FormatCut(getData(sender, getColumIndex(sender, "DateArrive7"), intRow))
                    D3412.DateArrive8 = FormatCut(getData(sender, getColumIndex(sender, "DateArrive8"), intRow))
                    D3412.DateArrive9 = FormatCut(getData(sender, getColumIndex(sender, "DateArrive9"), intRow))
                    D3412.DateArrive10 = FormatCut(getData(sender, getColumIndex(sender, "DateArrive10"), intRow))


                    D3412.InvoiceNo1 = getData(sender, getColumIndex(sender, "InvoiceNo1"), intRow)
                    D3412.InvoiceNo2 = getData(sender, getColumIndex(sender, "InvoiceNo2"), intRow)
                    D3412.InvoiceNo3 = getData(sender, getColumIndex(sender, "InvoiceNo3"), intRow)
                    D3412.InvoiceNo4 = getData(sender, getColumIndex(sender, "InvoiceNo4"), intRow)
                    D3412.InvoiceNo5 = getData(sender, getColumIndex(sender, "InvoiceNo5"), intRow)
                    D3412.InvoiceNo6 = getData(sender, getColumIndex(sender, "InvoiceNo6"), intRow)
                    D3412.InvoiceNo7 = getData(sender, getColumIndex(sender, "InvoiceNo7"), intRow)
                    D3412.InvoiceNo8 = getData(sender, getColumIndex(sender, "InvoiceNo8"), intRow)
                    D3412.InvoiceNo9 = getData(sender, getColumIndex(sender, "InvoiceNo9"), intRow)
                    D3412.InvoiceNo10 = getData(sender, getColumIndex(sender, "InvoiceNo10"), intRow)

                    D3412.ARemark = getData(sender, getColumIndex(sender, "ARemark"), intRow)
                    'D3412.AInvoice = getData(sender, getColumIndex(sender, "AInvoice"), intRow)
                    D3412.APLName = getData(sender, getColumIndex(sender, "APLName"), intRow)

                    D3412.AInvoice = D3412.InvoiceNo1 + IIf(D3412.InvoiceNo2 <> "", "," + D3412.InvoiceNo2, "")
                    D3412.AInvoice += IIf(D3412.InvoiceNo3 <> "", "," + D3412.InvoiceNo3, "")
                    D3412.AInvoice += IIf(D3412.InvoiceNo4 <> "", "," + D3412.InvoiceNo4, "")
                    D3412.AInvoice += IIf(D3412.InvoiceNo5 <> "", "," + D3412.InvoiceNo5, "")
                    D3412.AInvoice += IIf(D3412.InvoiceNo6 <> "", "," + D3412.InvoiceNo6, "")
                    D3412.AInvoice += IIf(D3412.InvoiceNo7 <> "", "," + D3412.InvoiceNo7, "")
                    D3412.AInvoice += IIf(D3412.InvoiceNo8 <> "", "," + D3412.InvoiceNo8, "")
                    D3412.AInvoice += IIf(D3412.InvoiceNo9 <> "", "," + D3412.InvoiceNo9, "")
                    D3412.AInvoice += IIf(D3412.InvoiceNo10 <> "", "," + D3412.InvoiceNo10, "")


                    D3412.cdUnitMaterialA = FormatCut(getData(sender, getColumIndex(sender, "cdUnitMaterialA"), intRow))
                    D3412.cdUnitPriceA = FormatCut(getData(sender, getColumIndex(sender, "cdUnitPriceA"), intRow))

                    D3412.PriceAPurchasing = CDecp(getData(sender, getColumIndex(sender, "PriceAPurchasing"), intRow))

                    D3412.AmtAPurchasing = CDecp(getData(sender, getColumIndex(sender, "AmtAPurchasing"), intRow))
                    D3412.AmtATotal = CDecp(getData(sender, getColumIndex(sender, "AmtATotal"), intRow))

                    D3412.InchargeInvoice = Pub.SAW
                    D3412.AmtATotal = D3412.QtyATotal * D3412.PricePurchasing

                    If REWRITE_PFK3412(D3412) Then

                    End If



                End If

            End If
        Catch ex As Exception

        End Try
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

        If ptc_1.SelectedIndex = 0 Then Call DATA_SEARCH_VS10()
        If ptc_1.SelectedIndex = 1 Then Call DATA_SEARCH_VS20()
        If ptc_1.SelectedIndex = 2 Then Call DATA_SEARCH_VS30()
        If ptc_1.SelectedIndex = 3 Then Call DATA_SEARCH_VS40()
    End Sub

    Private Sub vs_Season_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vs_Season.CellDoubleClick
        txt_cdSite.Code = ""
        txt_cdSite.Data = ""

        txt_CustomerCode.Code = ""
        txt_CustomerCode.Data = ""

        txt_SupplierCode.Code = ""
        txt_SupplierCode.Data = ""

        vS_Cus.ActiveSheet.RowCount = 0
        vS_Line.ActiveSheet.RowCount = 0
        vs_Large.ActiveSheet.RowCount = 0

        Vs1.ActiveSheet.RowCount = 0

        Call DATA_SEARCH_HEAD_vS_Cus()

    End Sub
    Private Sub vS_Cus_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS_Cus.CellDoubleClick
        txt_CustomerCode.Code = ""
        txt_CustomerCode.Data = ""

        txt_Line.Code = ""
        txt_Line.Data = ""

        txt_cdLargeGroupMaterial.Code = ""
        txt_cdLargeGroupMaterial.Data = ""

        txt_cdSemiGroupMaterial.Code = ""
        txt_cdSemiGroupMaterial.Data = ""

        txt_SupplierCode.Code = ""
        txt_SupplierCode.Data = ""

        vS_Line.ActiveSheet.RowCount = 0
        vs_Large.ActiveSheet.RowCount = 0
        Vs1.ActiveSheet.RowCount = 0


        Call DATA_SEARCH_HEAD_vS_Line()

    End Sub
    Private Sub vS_Line_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS_Line.CellDoubleClick
        txt_Line.Code = ""
        txt_Line.Data = ""

        txt_Line.Code = getData(vS_Line, getColumIndex(vS_Line, "Line"), vS_Line.ActiveSheet.ActiveRowIndex)
        txt_Line.Data = getData(vS_Line, getColumIndex(vS_Line, "Line"), vS_Line.ActiveSheet.ActiveRowIndex)

        txt_cdLargeGroupMaterial.Code = ""
        txt_cdLargeGroupMaterial.Data = ""

        txt_cdSemiGroupMaterial.Code = ""
        txt_cdSemiGroupMaterial.Data = ""

        vs_Large.ActiveSheet.RowCount = 0
        Vs1.ActiveSheet.RowCount = 0

        Call DATA_SEARCH_VS10()
        Call DATA_SEARCH_HEAD_vs_Large()

    End Sub

    Private Sub vs_Large_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vs_Large.CellDoubleClick
        Try
            Dim cdLargeGroupMaterial As String

            cdLargeGroupMaterial = getData(vs_Large, getColumIndex(vs_Large, "BasicCode"), vs_Large.ActiveSheet.ActiveRowIndex)

            If READ_PFK7171(ListCode("LargeGroupMaterial"), cdLargeGroupMaterial) Then
                txt_cdLargeGroupMaterial.Code = D7171.BasicCode
                txt_cdLargeGroupMaterial.Data = D7171.BasicName
            End If

            txt_cdSemiGroupMaterial.Code = ""
            txt_cdDetailGroupMaterial.Code = ""
            txt_cdSemiGroupMaterial.Data = ""
            txt_cdDetailGroupMaterial.Data = ""

            txt_SupplierCode.Code = ""
            txt_SupplierCode.Data = ""

            Call DATA_SEARCH_VS10()
        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Sub



    Private Sub chk_Total_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Total.CheckedChanged
        SplitContainer1.Panel1Collapsed = Not chk_Total.Checked
        SplitContainer2.Panel1Collapsed = Not chk_Total.Checked
        SplitContainer3.Panel1Collapsed = Not chk_Total.Checked

    End Sub


#End Region


    Private Sub cmd_Save_Click(sender As Object, e As EventArgs) Handles cmd_Save.Click
        Try
            Dim intRow As Integer
            Dim KEY_Autokey As String

            If ptc_1.SelectedIndex = 0 Then

                For intRow = 0 To Vs1.ActiveSheet.RowCount - 1
                    If getDataM(Vs1, getColumIndex(Vs1, "DCHK"), intRow) = "1" Then
                        KEY_Autokey = getData(Vs1, getColumIndex(Vs1, "KEY_Autokey"), intRow)

                        If READ_PFK3011(KEY_Autokey) Then
                            D3011.QtyBooking = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyBooking"), intRow))


                            Call REWRITE_PFK3011(D3011)
                        End If


                        If READ_PFK3412(getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderNo"), intRow), getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderSeq"), intRow)) Then
                            If D3412.CheckPurchasing = "2" Then GoTo next1
                            D3412.QtyBooking = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyBooking"), intRow))
                            D3412.QtyPurchasingMOQ = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyPurchasingMOQ"), intRow))
                            D3412.QtyPurchasing = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyPurchasing"), intRow))
                            D3412.QtyPurchasingNet = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyPurchasingNet"), intRow))

                            D3412.DateDelivery = FormatCut(getData(Vs1, getColumIndex(Vs1, "DateDelivery"), intRow))
                            D3412.DateStart = FormatCut(getData(Vs1, getColumIndex(Vs1, "DateStart"), intRow))

                            D3412.PricePurchasing = CDecp(getData(Vs1, getColumIndex(Vs1, "PricePurchasing"), intRow))
                            If getDataM(Vs1, getColumIndex(Vs1, "CheckComplete"), intRow) = "1" Then
                                D3412.CheckComplete = "1"
                            Else
                                D3412.CheckComplete = "2"
                            End If

                            D3412.QtyAArrive1 = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyAArrive1"), intRow))
                            D3412.QtyAArrive2 = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyAArrive2"), intRow))
                            D3412.QtyAArrive3 = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyAArrive3"), intRow))
                            D3412.QtyAArrive4 = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyAArrive4"), intRow))
                            D3412.QtyAArrive5 = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyAArrive5"), intRow))
                            D3412.QtyAArrive6 = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyAArrive6"), intRow))
                            D3412.QtyAArrive7 = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyAArrive7"), intRow))
                            D3412.QtyAArrive8 = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyAArrive8"), intRow))
                            D3412.QtyAArrive9 = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyAArrive9"), intRow))
                            D3412.QtyAArrive10 = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyAArrive10"), intRow))

                            D3412.QtyATotal = D3412.QtyAArrive1 + D3412.QtyAArrive2 + D3412.QtyAArrive3 + D3412.QtyAArrive4 + D3412.QtyAArrive5 + D3412.QtyAArrive6 + D3412.QtyAArrive7 + D3412.QtyAArrive8 + D3412.QtyAArrive9 + D3412.QtyAArrive10


                            D3412.DateArrive1 = FormatCut(getData(Vs1, getColumIndex(Vs1, "DateArrive1"), intRow))
                            D3412.DateArrive2 = FormatCut(getData(Vs1, getColumIndex(Vs1, "DateArrive2"), intRow))
                            D3412.DateArrive3 = FormatCut(getData(Vs1, getColumIndex(Vs1, "DateArrive3"), intRow))
                            D3412.DateArrive4 = FormatCut(getData(Vs1, getColumIndex(Vs1, "DateArrive4"), intRow))
                            D3412.DateArrive5 = FormatCut(getData(Vs1, getColumIndex(Vs1, "DateArrive5"), intRow))
                            D3412.DateArrive6 = FormatCut(getData(Vs1, getColumIndex(Vs1, "DateArrive6"), intRow))
                            D3412.DateArrive7 = FormatCut(getData(Vs1, getColumIndex(Vs1, "DateArrive7"), intRow))
                            D3412.DateArrive8 = FormatCut(getData(Vs1, getColumIndex(Vs1, "DateArrive8"), intRow))
                            D3412.DateArrive9 = FormatCut(getData(Vs1, getColumIndex(Vs1, "DateArrive9"), intRow))
                            D3412.DateArrive10 = FormatCut(getData(Vs1, getColumIndex(Vs1, "DateArrive10"), intRow))

                            'D3412.QtyAArrive1 = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyAArrive1"), intRow))
                            'D3412.QtyAArrive2 = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyAArrive2"), intRow))
                            'D3412.QtyAArrive3 = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyAArrive3"), intRow))
                            'D3412.QtyAArrive4 = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyAArrive4"), intRow))
                            'D3412.QtyAArrive5 = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyAArrive5"), intRow))

                            'D3412.QtyATotal = D3412.QtyAArrive1 + D3412.QtyAArrive2 + D3412.QtyAArrive3 + D3412.QtyAArrive4 + D3412.QtyAArrive5

                            'D3412.DateArrive1 = FormatCut(getData(Vs1, getColumIndex(Vs1, "DateArrive1"), intRow))
                            'D3412.DateArrive2 = FormatCut(getData(Vs1, getColumIndex(Vs1, "DateArrive2"), intRow))
                            'D3412.DateArrive3 = FormatCut(getData(Vs1, getColumIndex(Vs1, "DateArrive3"), intRow))
                            'D3412.DateArrive4 = FormatCut(getData(Vs1, getColumIndex(Vs1, "DateArrive4"), intRow))
                            'D3412.DateArrive5 = FormatCut(getData(Vs1, getColumIndex(Vs1, "DateArrive5"), intRow))

                            If FormatCut(txt_InvoiceNo.Data) = "" Then
                                D3412.InvoiceNo1 = getData(Vs1, getColumIndex(Vs1, "InvoiceNo1"), intRow)
                                D3412.InvoiceNo2 = getData(Vs1, getColumIndex(Vs1, "InvoiceNo2"), intRow)
                                D3412.InvoiceNo3 = getData(Vs1, getColumIndex(Vs1, "InvoiceNo3"), intRow)
                                D3412.InvoiceNo4 = getData(Vs1, getColumIndex(Vs1, "InvoiceNo4"), intRow)
                                D3412.InvoiceNo5 = getData(Vs1, getColumIndex(Vs1, "InvoiceNo5"), intRow)
                                D3412.InvoiceNo6 = getData(Vs1, getColumIndex(Vs1, "InvoiceNo6"), intRow)
                                D3412.InvoiceNo7 = getData(Vs1, getColumIndex(Vs1, "InvoiceNo7"), intRow)
                                D3412.InvoiceNo8 = getData(Vs1, getColumIndex(Vs1, "InvoiceNo8"), intRow)
                                D3412.InvoiceNo9 = getData(Vs1, getColumIndex(Vs1, "InvoiceNo9"), intRow)
                                D3412.InvoiceNo10 = getData(Vs1, getColumIndex(Vs1, "InvoiceNo10"), intRow)

                            Else
                                If FormatCut(txt_InvoiceNo.Data) = "CLEARINVOICE1" Then
                                    D3412.InvoiceNo1 = ""
                                    D3412.DateArrive1 = ""
                                    D3412.QtyAArrive1 = 0



                                ElseIf FormatCut(txt_InvoiceNo.Data) = "CLEARINVOICE2" Then
                                    D3412.InvoiceNo2 = ""
                                    D3412.DateArrive2 = ""
                                    D3412.QtyAArrive2 = 0


                                ElseIf FormatCut(txt_InvoiceNo.Data) = "CLEARINVOICE3" Then
                                    D3412.InvoiceNo3 = ""
                                    D3412.DateArrive3 = ""
                                    D3412.QtyAArrive3 = 0


                                ElseIf FormatCut(txt_InvoiceNo.Data) = "CLEARINVOICE4" Then
                                    D3412.InvoiceNo4 = ""
                                    D3412.DateArrive4 = ""
                                    D3412.QtyAArrive4 = 0


                                ElseIf FormatCut(txt_InvoiceNo.Data) = "CLEARINVOICE5" Then
                                    D3412.InvoiceNo5 = ""
                                    D3412.DateArrive5 = ""
                                    D3412.QtyAArrive5 = 0

                                ElseIf FormatCut(txt_InvoiceNo.Data) = "CLEARINVOICE6" Then
                                    D3412.InvoiceNo6 = ""
                                    D3412.DateArrive6 = ""
                                    D3412.QtyAArrive6 = 0

                                ElseIf FormatCut(txt_InvoiceNo.Data) = "CLEARINVOICE7" Then
                                    D3412.InvoiceNo7 = ""
                                    D3412.DateArrive7 = ""
                                    D3412.QtyAArrive7 = 0

                                ElseIf FormatCut(txt_InvoiceNo.Data) = "CLEARINVOICE8" Then
                                    D3412.InvoiceNo8 = ""
                                    D3412.DateArrive8 = ""
                                    D3412.QtyAArrive8 = 0

                                ElseIf FormatCut(txt_InvoiceNo.Data) = "CLEARINVOICE9" Then
                                    D3412.InvoiceNo9 = ""
                                    D3412.DateArrive9 = ""
                                    D3412.QtyAArrive9 = 0


                                ElseIf FormatCut(txt_InvoiceNo.Data) = "CLEARINVOICE10" Then
                                    D3412.InvoiceNo10 = ""
                                    D3412.DateArrive10 = ""
                                    D3412.QtyAArrive10 = 0


                                ElseIf FormatCut(D3412.InvoiceNo1) = "" Then
                                    D3412.InvoiceNo1 = txt_InvoiceNo.Data
                                    D3412.DateArrive1 = txt_DateAccept.Data

                                ElseIf FormatCut(D3412.InvoiceNo2) = "" Then
                                    D3412.InvoiceNo2 = txt_InvoiceNo.Data
                                    D3412.DateArrive2 = txt_DateAccept.Data

                                ElseIf FormatCut(D3412.InvoiceNo3) = "" Then
                                    D3412.InvoiceNo3 = txt_InvoiceNo.Data
                                    D3412.DateArrive3 = txt_DateAccept.Data

                                ElseIf FormatCut(D3412.InvoiceNo4) = "" Then
                                    D3412.InvoiceNo4 = txt_InvoiceNo.Data
                                    D3412.DateArrive4 = txt_DateAccept.Data

                                ElseIf FormatCut(D3412.InvoiceNo5) = "" Then
                                    D3412.InvoiceNo5 = txt_InvoiceNo.Data
                                    D3412.DateArrive5 = txt_DateAccept.Data


                                End If

                                

                            End If

                           

                            D3412.ARemark = getData(Vs1, getColumIndex(Vs1, "ARemark"), intRow)
                            D3412.AInvoice = getData(Vs1, getColumIndex(Vs1, "AInvoice"), intRow)
                            D3412.APLName = getData(Vs1, getColumIndex(Vs1, "APLName"), intRow)

                            D3412.AInvoice = D3412.InvoiceNo1 + IIf(D3412.InvoiceNo2 <> "", "," + D3412.InvoiceNo2, "")
                            D3412.AInvoice += IIf(D3412.InvoiceNo3 <> "", "," + D3412.InvoiceNo3, "")
                            D3412.AInvoice += IIf(D3412.InvoiceNo4 <> "", "," + D3412.InvoiceNo4, "")
                            D3412.AInvoice += IIf(D3412.InvoiceNo5 <> "", "," + D3412.InvoiceNo5, "")
                            D3412.AInvoice += IIf(D3412.InvoiceNo6 <> "", "," + D3412.InvoiceNo6, "")
                            D3412.AInvoice += IIf(D3412.InvoiceNo7 <> "", "," + D3412.InvoiceNo7, "")
                            D3412.AInvoice += IIf(D3412.InvoiceNo8 <> "", "," + D3412.InvoiceNo8, "")
                            D3412.AInvoice += IIf(D3412.InvoiceNo9 <> "", "," + D3412.InvoiceNo9, "")
                            D3412.AInvoice += IIf(D3412.InvoiceNo10 <> "", "," + D3412.InvoiceNo10, "")

                            D3412.cdUnitMaterialA = FormatCut(getData(Vs1, getColumIndex(Vs1, "cdUnitMaterialA"), intRow))
                            D3412.cdUnitPriceA = FormatCut(getData(Vs1, getColumIndex(Vs1, "cdUnitPriceA"), intRow))

                            D3412.PriceAPurchasing = CDecp(getData(Vs1, getColumIndex(Vs1, "PriceAPurchasing"), intRow))

                            D3412.AmtAPurchasing = CDecp(getData(Vs1, getColumIndex(Vs1, "AmtAPurchasing"), intRow))
                            D3412.AmtATotal = CDecp(getData(Vs1, getColumIndex(Vs1, "AmtATotal"), intRow))

                            D3412.InchargeInvoice = Pub.SAW
                            D3412.AmtATotal = D3412.QtyATotal * D3412.PricePurchasing





                            Call REWRITE_PFK3412(D3412)



                        End If

                    End If
next1:
                Next


                Call DATA_SEARCH_VS10()

            ElseIf ptc_1.SelectedIndex = 1 Then


                For intRow = 0 To vS21.ActiveSheet.RowCount - 1
                    If getDataM(vS21, getColumIndex(vS21, "DCHK"), intRow) = "1" Then
                        KEY_Autokey = getData(vS21, getColumIndex(vS21, "KEY_Autokey"), intRow)

                        If READ_PFK3011(KEY_Autokey) Then
                            D3011.QtyBooking = CDecp(getData(vS21, getColumIndex(vS21, "QtyBooking"), intRow))

                            Call REWRITE_PFK3011(D3011)
                        End If


                        If READ_PFK3412(getData(vS21, getColumIndex(vS21, "KEY_PurchasingOrderNo"), intRow), getData(vS21, getColumIndex(vS21, "KEY_PurchasingOrderSeq"), intRow)) Then
                            If D3412.CheckPurchasing = "2" Then GoTo next2
                            D3412.QtyBooking = CDecp(getData(vS21, getColumIndex(vS21, "QtyBooking"), intRow))
                            D3412.QtyPurchasingMOQ = CDecp(getData(vS21, getColumIndex(vS21, "QtyPurchasingMOQ"), intRow))
                            D3412.QtyPurchasing = CDecp(getData(vS21, getColumIndex(vS21, "QtyPurchasing"), intRow))
                            D3412.QtyPurchasingNet = CDecp(getData(vS21, getColumIndex(vS21, "QtyPurchasingNet"), intRow))

                            D3412.DateDelivery = FormatCut(getData(vS21, getColumIndex(vS21, "DateDelivery"), intRow))
                            D3412.DateStart = FormatCut(getData(vS21, getColumIndex(vS21, "DateStart"), intRow))

                            D3412.PricePurchasing = CDecp(getData(vS21, getColumIndex(vS21, "PricePurchasing"), intRow))
                            If getDataM(vS21, getColumIndex(vS21, "CheckComplete"), intRow) = "1" Then
                                D3412.CheckComplete = "1"
                            Else
                                D3412.CheckComplete = "2"
                            End If

                            D3412.QtyAArrive1 = CDecp(getData(vS21, getColumIndex(vS21, "QtyAArrive1"), intRow))
                            D3412.QtyAArrive2 = CDecp(getData(vS21, getColumIndex(vS21, "QtyAArrive2"), intRow))
                            D3412.QtyAArrive3 = CDecp(getData(vS21, getColumIndex(vS21, "QtyAArrive3"), intRow))
                            D3412.QtyAArrive4 = CDecp(getData(vS21, getColumIndex(vS21, "QtyAArrive4"), intRow))
                            D3412.QtyAArrive5 = CDecp(getData(vS21, getColumIndex(vS21, "QtyAArrive5"), intRow))
                            D3412.QtyAArrive6 = CDecp(getData(vS21, getColumIndex(vS21, "QtyAArrive6"), intRow))
                            D3412.QtyAArrive7 = CDecp(getData(vS21, getColumIndex(vS21, "QtyAArrive7"), intRow))
                            D3412.QtyAArrive8 = CDecp(getData(vS21, getColumIndex(vS21, "QtyAArrive8"), intRow))
                            D3412.QtyAArrive9 = CDecp(getData(vS21, getColumIndex(vS21, "QtyAArrive9"), intRow))
                            D3412.QtyAArrive10 = CDecp(getData(vS21, getColumIndex(vS21, "QtyAArrive10"), intRow))

                            D3412.QtyATotal = D3412.QtyAArrive1 + D3412.QtyAArrive2 + D3412.QtyAArrive3 + D3412.QtyAArrive4 + D3412.QtyAArrive5
                            D3412.QtyATotal += D3412.QtyAArrive6 + D3412.QtyAArrive7 + D3412.QtyAArrive8 + D3412.QtyAArrive9 + D3412.QtyAArrive10

                            D3412.DateArrive1 = FormatCut(getData(vS21, getColumIndex(vS21, "DateArrive1"), intRow))
                            D3412.DateArrive2 = FormatCut(getData(vS21, getColumIndex(vS21, "DateArrive2"), intRow))
                            D3412.DateArrive3 = FormatCut(getData(vS21, getColumIndex(vS21, "DateArrive3"), intRow))
                            D3412.DateArrive4 = FormatCut(getData(vS21, getColumIndex(vS21, "DateArrive4"), intRow))
                            D3412.DateArrive5 = FormatCut(getData(vS21, getColumIndex(vS21, "DateArrive5"), intRow))
                            D3412.DateArrive6 = FormatCut(getData(vS21, getColumIndex(vS21, "DateArrive6"), intRow))
                            D3412.DateArrive7 = FormatCut(getData(vS21, getColumIndex(vS21, "DateArrive7"), intRow))
                            D3412.DateArrive8 = FormatCut(getData(vS21, getColumIndex(vS21, "DateArrive8"), intRow))
                            D3412.DateArrive9 = FormatCut(getData(vS21, getColumIndex(vS21, "DateArrive9"), intRow))
                            D3412.DateArrive10 = FormatCut(getData(vS21, getColumIndex(vS21, "DateArrive10"), intRow))

                            'D3412.InvoiceNo1 = getData(vS21, getColumIndex(vS21, "InvoiceNo1"), intRow)
                            'D3412.InvoiceNo2 = getData(vS21, getColumIndex(vS21, "InvoiceNo2"), intRow)
                            'D3412.InvoiceNo3 = getData(vS21, getColumIndex(vS21, "InvoiceNo3"), intRow)
                            'D3412.InvoiceNo4 = getData(vS21, getColumIndex(vS21, "InvoiceNo4"), intRow)
                            'D3412.InvoiceNo5 = getData(vS21, getColumIndex(vS21, "InvoiceNo5"), intRow)
                            If FormatCut(txt_InvoiceNo.Data) = "" Then
                                D3412.InvoiceNo1 = getData(Vs1, getColumIndex(Vs1, "InvoiceNo1"), intRow)
                                D3412.InvoiceNo2 = getData(Vs1, getColumIndex(Vs1, "InvoiceNo2"), intRow)
                                D3412.InvoiceNo3 = getData(Vs1, getColumIndex(Vs1, "InvoiceNo3"), intRow)
                                D3412.InvoiceNo4 = getData(Vs1, getColumIndex(Vs1, "InvoiceNo4"), intRow)
                                D3412.InvoiceNo5 = getData(Vs1, getColumIndex(Vs1, "InvoiceNo5"), intRow)

                            Else
                                If FormatCut(D3412.InvoiceNo1) = "" Then
                                    D3412.InvoiceNo1 = txt_InvoiceNo.Data
                                    D3412.DateArrive1 = txt_DateAccept.Data

                                ElseIf FormatCut(D3412.InvoiceNo2) = "" Then
                                    D3412.InvoiceNo2 = txt_InvoiceNo.Data
                                    D3412.DateArrive2 = txt_DateAccept.Data

                                ElseIf FormatCut(D3412.InvoiceNo3) = "" Then
                                    D3412.InvoiceNo3 = txt_InvoiceNo.Data
                                    D3412.DateArrive3 = txt_DateAccept.Data

                                ElseIf FormatCut(D3412.InvoiceNo4) = "" Then
                                    D3412.InvoiceNo4 = txt_InvoiceNo.Data
                                    D3412.DateArrive4 = txt_DateAccept.Data

                                ElseIf FormatCut(D3412.InvoiceNo5) = "" Then
                                    D3412.InvoiceNo5 = txt_InvoiceNo.Data
                                    D3412.DateArrive5 = txt_DateAccept.Data


                                End If

                            End If

                            D3412.ARemark = getData(vS21, getColumIndex(vS21, "ARemark"), intRow)
                            D3412.AInvoice = getData(vS21, getColumIndex(vS21, "AInvoice"), intRow)
                            D3412.APLName = getData(vS21, getColumIndex(vS21, "APLName"), intRow)

                            D3412.AInvoice = D3412.InvoiceNo1 + IIf(D3412.InvoiceNo2 <> "", "," + D3412.InvoiceNo2, "")
                            D3412.AInvoice += IIf(D3412.InvoiceNo3 <> "", "," + D3412.InvoiceNo3, "")
                            D3412.AInvoice += IIf(D3412.InvoiceNo4 <> "", "," + D3412.InvoiceNo4, "")
                            D3412.AInvoice += IIf(D3412.InvoiceNo5 <> "", "," + D3412.InvoiceNo5, "")
                            D3412.AInvoice += IIf(D3412.InvoiceNo6 <> "", "," + D3412.InvoiceNo6, "")
                            D3412.AInvoice += IIf(D3412.InvoiceNo7 <> "", "," + D3412.InvoiceNo7, "")
                            D3412.AInvoice += IIf(D3412.InvoiceNo8 <> "", "," + D3412.InvoiceNo8, "")
                            D3412.AInvoice += IIf(D3412.InvoiceNo9 <> "", "," + D3412.InvoiceNo9, "")
                            D3412.AInvoice += IIf(D3412.InvoiceNo10 <> "", "," + D3412.InvoiceNo10, "")

                            D3412.cdUnitMaterialA = FormatCut(getData(vS21, getColumIndex(vS21, "cdUnitMaterialA"), intRow))
                            D3412.cdUnitPriceA = FormatCut(getData(vS21, getColumIndex(vS21, "cdUnitPriceA"), intRow))

                            D3412.PriceAPurchasing = CDecp(getData(vS21, getColumIndex(vS21, "PriceAPurchasing"), intRow))

                            D3412.AmtAPurchasing = CDecp(getData(vS21, getColumIndex(vS21, "AmtAPurchasing"), intRow))
                            D3412.AmtATotal = CDecp(getData(vS21, getColumIndex(vS21, "AmtATotal"), intRow))

                            D3412.InchargeInvoice = Pub.SAW
                            D3412.AmtATotal = D3412.QtyATotal * D3412.PricePurchasing
                            Call REWRITE_PFK3412(D3412)



                        End If

                    End If
next2:
                Next


                Call DATA_SEARCH_VS21()

            End If



        Catch ex As Exception

        End Try
    End Sub

    Private Sub vS20_CellClick(sender As Object, e As CellClickEventArgs) Handles vS20.CellDoubleClick
        Call DATA_SEARCH_VS21()
    End Sub

    Private Sub vS30_CellClick(sender As Object, e As CellClickEventArgs) Handles vS30.CellDoubleClick
        Call DATA_SEARCH_VS31()
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

        ElseIf Cms_1.Items(7).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB07()

        End If

    End Sub

End Class