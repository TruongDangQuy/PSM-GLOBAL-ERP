Public Class PFP30112
#Region "Variable"
    Private Dsu01 As Long
    Private wGCODE As String
    Private Form_Close As Boolean
#End Region

#Region "Form_load"

    Private Sub PFP30112_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control = True And e.KeyCode = Keys.G Then
            chk_Total.Checked = Not chk_Total.Checked
        End If
    End Sub
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)

        Me.KeyPreview = True

        Call Cms_additem(Cms_1,
                     "PURCHASING ORDER - MPO CONTROL PROCCESING - " & WordConv("INPUT") & "(F5)",
                     "PURCHASING ORDER - MPO CONTROL PROCCESING - " & WordConv("SEARCH") & "(F6)",
                     "PURCHASING ORDER - MPO CONTROL PROCCESING - " & WordConv("UPDATE") & "(F7)",
                     "PURCHASING ORDER - MPO CONTROL PROCCESING - " & WordConv("DELETE") & "(F8)",
                     "-",
                     "PURCHASING ORDER - MPO CONTROL PROCCESING - " & WordConv("ADD NEW") & "(F9)",
                     "-",
                     "PURCHASING ORDER - MPO CONTROL PROCCESING - " & WordConv("APPROVAL ALL STATUS") & "(F10)",
                     "PURCHASING ORDER - MPO CONTROL PROCCESING - " & WordConv("APPROVAL  1 LINE STATUS") & "(F11)")



        Call FORM_INIT()
        Call DATA_INIT()

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

        SplitContainer1.Panel1Collapsed = True
        SplitContainer2.Panel1Collapsed = True
        SplitContainer3.Panel1Collapsed = True

    End Sub

    Private Sub DATA_INIT()
        If Me.Name = "PFP30112RnD" Then
            chk_CheckSample.Checked = True
            chk_CheckSample.Enabled = False
        Else
            chk_CheckSample.Checked = False
            chk_CheckSample.Enabled = False
        End If
    End Sub
#End Region

#Region "Function"
    Private Sub MAIN_JOB01()

        Dim i As Integer
        Dim SpecNoList As String
        Dim KEY_Autokey As String

        For i = 0 To Vs1.ActiveSheet.RowCount - 1
            If getDataM(Vs1, getColumIndex(Vs1, "dchk"), i) <> "1" Then GoTo next1
            KEY_AutoKey = getData(Vs1, getColumIndex(Vs1, "KEY_Autokey"), i)

            If READ_PFK3011(KEY_AutoKey) Then
                SpecNoList = SpecNoList & "''" & KEY_AutoKey & "''"
                SpecNoList = SpecNoList & ","
            End If
next1:
        Next

        If SpecNoList = "" Then Exit Sub
        If SpecNoList = "" Then Exit Sub

        SpecNoList = Strings.Left(SpecNoList, Len(SpecNoList) - 1)
        If ISUD3411A.Link_ISUD3411A_INSERT_MULTI(11, SpecNoList, Me.Name) = False Then Exit Sub

        Call DATA_SEARCH_HEAD_vs_Large()

        Call DATA_SEARCH_VS1()
    End Sub

    Private Sub MAIN_JOB02()
        If getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        Dim PurchasingOrderNo As String
        PurchasingOrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderNo"), Vs1.ActiveSheet.ActiveRowIndex)

        If ISUD3411A.Link_ISUD3411A(2, PurchasingOrderNo, Me.Name) = False Then Exit Sub

    End Sub

    Private Sub MAIN_JOB03()
        If getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        Dim PurchasingOrderNo As String
        PurchasingOrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderNo"), Vs1.ActiveSheet.ActiveRowIndex)

        If ISUD3411A.Link_ISUD3411A(3, PurchasingOrderNo, Me.Name) = False Then Exit Sub

        Call DATA_SEARCH_VS1()
    End Sub

    Private Sub MAIN_JOB04()
        If getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        Dim PurchasingOrderNo As String
        PurchasingOrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderNo"), Vs1.ActiveSheet.ActiveRowIndex)

        If ISUD3411A.Link_ISUD3411A(4, PurchasingOrderNo, Me.Name) = False Then Exit Sub

        Call DATA_SEARCH_VS1()

    End Sub


    Private Sub MAIN_JOB05()
        Dim cdSite As String
        Dim CustomerCode As String
        Dim Line As String
        Dim cdLargeGroupMaterial As String
        Dim cdSemiGroupMaterial As String
        Dim SupplierCode As String
        Dim PurchasingOrderNo As String
        PurchasingOrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderNo"), Vs1.ActiveSheet.ActiveRowIndex)

        cdSite = txt_cdSite.Code
        CustomerCode = txt_CustomerCode.Code
        Line = txt_Line.Data
        cdLargeGroupMaterial = txt_cdLargeGroupMaterial.Code
        cdSemiGroupMaterial = txt_cdSemiGroupMaterial.Code
        SupplierCode = txt_SupplierCode.Code

        If cdSite = "" Then MsgBoxP("Season?") : Exit Sub
        'If CustomerCode = "" Then MsgBoxP("CustomerCode?") : Exit Sub
        CustomerCode = getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderNo"), Vs1.ActiveSheet.ActiveRowIndex)

        If Line = "" Then MsgBoxP("Line?") : Exit Sub
        If cdLargeGroupMaterial = "" And cdSemiGroupMaterial = "" Then MsgBoxP("Large Group or Semi Group ?") : Exit Sub


        If ISUD3411A.Link_ISUD3411A_AUTO(5, cdSite, CustomerCode, SupplierCode, Line, cdLargeGroupMaterial, cdSemiGroupMaterial, chk_CheckSample.CheckState, PurchasingOrderNo, Me.Name) = False Then Exit Sub

        Call DATA_SEARCH_HEAD_vs_Large()

        Call DATA_SEARCH_VS1()

    End Sub

    Private Sub MAIN_JOB06()

    End Sub

    Private Sub MAIN_JOB07()
        If getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        Dim PurchasingOrderNo As String
        PurchasingOrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderNo"), Vs1.ActiveSheet.ActiveRowIndex)


        If ISUD3411P.Link_ISUD3411P(4, PurchasingOrderNo,
                                    getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderSeq"), Vs1.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub

        Call DATA_SEARCH_VS1()

    End Sub

    Private Sub MAIN_JOB08()
        If getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        Dim PurchasingOrderNo As String
        PurchasingOrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderNo"), Vs1.ActiveSheet.ActiveRowIndex)


        If ISUD3411P.Link_ISUD3411P(3, PurchasingOrderNo,
                                    getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderSeq"), Vs1.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub

        Call DATA_SEARCH_VS1()

    End Sub

#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS1(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS1 = False
        Vs1.Enabled = False

        If chk_Period.Checked = True Then
            DS1 = PrcDS("USP_PFP30112_SEARCH_VS1_F1", cn, SdateEdate.text1,
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
                                                       chk_CheckUse.CheckState,
                                                       txt_cdSupplierGroup.Code)
            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_PFP30112_SEARCH_VS1_F1", "Vs1")
                Vs1.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs1, DS1, "USP_PFP30112_SEARCH_VS1_F1", "Vs1")
            DATA_SEARCH_VS1 = True

            Vs1.Enabled = True

        Else
            DS1 = PrcDS("USP_PFP30112_SEARCH_VS1", cn, SdateEdate.text1,
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
                                                    chk_CheckUse.CheckState,
                                                       txt_cdSupplierGroup.Code)
            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_PFP30112_SEARCH_VS1", "Vs1")
                Vs1.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs1, DS1, "USP_PFP30112_SEARCH_VS1", "Vs1")
            DATA_SEARCH_VS1 = True

            Vs1.Enabled = True
        End If



    End Function

    Public Function DATA_SEARCH_HEAD_vs_Season() As Boolean
        DATA_SEARCH_HEAD_vs_Season = False

        Try
            DS1 = PrcDS("USP_PFP30112_SEARCH_VS_SEASON", cn, ListCode("Season"))
            SPR_PRO_NEW(vs_Season, DS1, "USP_PFP30112_SEARCH_VS_SEASON", "vs_Season")

            DS1 = Nothing
            DATA_SEARCH_HEAD_vs_Season = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Public Function DATA_SEARCH_HEAD_vS_Cus() As Boolean
        DATA_SEARCH_HEAD_vS_Cus = False

        Dim cdSite As String
        cdSite = txt_cdSite.Code



        Try
            If chk_Period.Checked = True Then
                DS1 = PrcDS("USP_PFP30112_SEARCH_vS_Cus_F1", cn, SdateEdate.text1, SdateEdate.text2, txt_CustomerCode.Code, cdSite,
                                                       chk_CheckSample.CheckState, txt_cdSupplierGroup.Code)
                SPR_PRO_NEW(vS_Cus, DS1, "USP_PFP30112_SEARCH_vS_Cus_F1", "vS_Cus")

                SplitContainer1.SplitterDistance = SPR_SHEETWIDHT(vS_Cus) + cSprWidthSize

                DS1 = Nothing
                DATA_SEARCH_HEAD_vS_Cus = True

            Else
                DS1 = PrcDS("USP_PFP30112_SEARCH_vS_Cus", cn, txt_CustomerCode.Code, cdSite,
                                                       chk_CheckSample.CheckState, txt_cdSupplierGroup.Code)
                SPR_PRO_NEW(vS_Cus, DS1, "USP_PFP30112_SEARCH_vS_Cus", "vS_Cus")

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
        Dim cdSite As String
        Dim CustomerCode As String

        cdSite = txt_cdSite.Code
        CustomerCode = getData(vS_Cus, getColumIndex(vS_Cus, "CustomerCode"), vS_Cus.ActiveSheet.ActiveRowIndex)

        If READ_PFK7101(CustomerCode) Then
            txt_SupplierCode.Code = D7101.CustomerCode
            txt_SupplierCode.Data = D7101.CustomerName
        End If

        Try
            If chk_Period.Checked = True Then
                DS1 = PrcDS("USP_PFP30112_SEARCH_vS_Line_F1", cn, SdateEdate.text1, SdateEdate.text2, cdSite, CustomerCode,
                                                       chk_CheckSample.CheckState)

                SPR_PRO_NEW(vS_Line, DS1, "USP_PFP30112_SEARCH_vS_Line_F1", "vS_Line")
                SplitContainer2.SplitterDistance = SPR_SHEETWIDHT(vS_Line) + cSprWidthSize

                DS1 = Nothing
                DATA_SEARCH_HEAD_vS_Line = True

            Else
                DS1 = PrcDS("USP_PFP30112_SEARCH_vS_Line", cn, cdSite, CustomerCode,
                                                       chk_CheckSample.CheckState)

                SPR_PRO_NEW(vS_Line, DS1, "USP_PFP30112_SEARCH_vS_Line", "vS_Line")
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
        Dim cdSite As String
        Dim CustomerCode As String
        Dim Line As String

        cdSite = txt_cdSite.Code
        CustomerCode = getData(vS_Cus, getColumIndex(vS_Cus, "CustomerCode"), vS_Cus.ActiveSheet.ActiveRowIndex)
        Line = getData(vS_Line, getColumIndex(vS_Line, "Line"), vS_Line.ActiveSheet.ActiveRowIndex)

        Try
            If chk_Period.Checked = True Then
                DS1 = PrcDS("USP_PFP30112_SEARCH_vS_Large_F1", cn, SdateEdate.text1, SdateEdate.text2, ListCode("LargeGroupMaterial"), CustomerCode, cdSite, Line,
                                                      chk_CheckSample.CheckState)

                SPR_PRO_NEW(vs_Large, DS1, "USP_PFP30112_SEARCH_vS_Large_F1", "vs_Large")
                SplitContainer2.SplitterDistance = SPR_SHEETWIDHT(vs_Large) + cSprWidthSize

                DS1 = Nothing
                DATA_SEARCH_HEAD_vs_Large = True

            Else
                DS1 = PrcDS("USP_PFP30112_SEARCH_vS_Large", cn, ListCode("LargeGroupMaterial"), CustomerCode, cdSite, Line,
                                                    chk_CheckSample.CheckState)

                SPR_PRO_NEW(vs_Large, DS1, "USP_PFP30112_SEARCH_vS_Large", "vs_Large")
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

    Private Sub Vs1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown
        If Vs1.ActiveSheet.ActiveColumnIndex = getColumIndex(Vs1, "QtyBooking") Then
            If e.KeyCode = Keys.Enter Then
                Msg_Result = InputBox("Vui lòng điền stock ! Stock qTy ?")

                If CDecp(Msg_Result) < 0 Then MsgBoxP("Không đúng ! No correct value !") : Exit Sub
                Dim KEY_Autokey As String
                KEY_Autokey = getData(Vs1, getColumIndex(Vs1, "KEY_Autokey"), Vs1.ActiveSheet.ActiveRowIndex)

                If READ_PFK3011(KEY_Autokey) Then
                    D3011.QtyBooking = CDecp(Msg_Result)
                    D3011.InchargeUpdate = Pub.SAW
                    D3011.DateUdate = Pub.DAT

                    D3011.RemarkLine = getData(Vs1, getColumIndex(Vs1, "RemarkLine"), Vs1.ActiveSheet.ActiveRowIndex)
                    D3011.Remark = getData(Vs1, getColumIndex(Vs1, "Remark"), Vs1.ActiveSheet.ActiveRowIndex)

                    Call REWRITE_PFK3011(D3011)
                End If

            End If
        Else
            If Vs1.ActiveSheet.ActiveColumnIndex = getColumIndex(Vs1, "RemarkLine") Or Vs1.ActiveSheet.ActiveColumnIndex = getColumIndex(Vs1, "Remark") Then
                If e.KeyCode = Keys.Enter Then
                    Dim KEY_Autokey As String
                    KEY_Autokey = getData(Vs1, getColumIndex(Vs1, "KEY_Autokey"), Vs1.ActiveSheet.ActiveRowIndex)

                    If READ_PFK3011(KEY_Autokey) Then
                        D3011.QtyBooking = CDecp(Msg_Result)
                        D3011.InchargeUpdate = Pub.SAW
                        D3011.DateUdate = Pub.DAT

                        D3011.RemarkLine = getData(Vs1, getColumIndex(Vs1, "RemarkLine"), Vs1.ActiveSheet.ActiveRowIndex)
                        D3011.Remark = getData(Vs1, getColumIndex(Vs1, "Remark"), Vs1.ActiveSheet.ActiveRowIndex)

                        If REWRITE_PFK3011(D3011) Then

                        End If
                    End If

                End If
            End If
        End If
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

        If chk_Total.Checked = False Then
            Call DATA_SEARCH_VS1()
        Else
            Call DATA_SEARCH_HEAD_vs_Season()
            Call DATA_SEARCH_HEAD_vS_Cus()
        End If

    End Sub

    Private Sub vs_Season_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vs_Season.CellDoubleClick
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

        Call DATA_SEARCH_VS1()
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

            Call DATA_SEARCH_VS1()
        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Sub



    Private Sub chk_Total_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Total.CheckedChanged
        SplitContainer1.Panel1Collapsed = Not chk_Total.Checked
        SplitContainer2.Panel1Collapsed = Not chk_Total.Checked
        SplitContainer3.Panel1Collapsed = Not chk_Total.Checked

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
        ElseIf Cms_1.Items(8).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB08()

        End If

    End Sub
#End Region


End Class