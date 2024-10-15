Public Class PFP49500

#Region "Variable"
    Private Dsu01 As Long
    Private wGCODE As String
    Private Form_Close As Boolean
    Private chk_CheckIOType As String
    Private chk_CheckPurchasingOrder As String
    Private chk_NewForm As Boolean = False

    Private W4958 As T4958_AREA
    Private D4958 As T4958_AREA

#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load

        Call Cms_additem(Cms_1,
                        "LOADING PLAN PROCCESING - " & WordConv("INPUT") & "(F5)")

        Call Cms_additem(Cms_2,
                        "LOADING PLAN PROCCESING - " & WordConv("SEARCH") & "(F6)",
                        "LOADING PLAN PROCCESING - " & WordConv("UPDATE") & "(F7)",
                        "LOADING PLAN PROCCESING - " & WordConv("DELETE") & "(F8)")

        Vs1.ContextMenuStrip = Cms_1
        vS2.ContextMenuStrip = Cms_2

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False, , , , , )

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

        vS3.InsChk = True
    End Sub

    Private Sub Clear_In()

    End Sub

    Private Sub Clear_Out()

    End Sub
    Private Sub DATA_INIT()
        Call Clear_In()
        Call Clear_Out()
        If Me.PeaceFormType = "" Then Exit Sub

        pnr_Year.Value = CDecp(Strings.Left(Pub.DAT, 4))
        pnr_Week.Value = DatePart(DateInterval.WeekOfYear, CDate(FSDate(Pub.DAT)))


    End Sub

#End Region

#Region "Function"
    Private Sub MAIN_JOB01()

        Dim KEY_OrderNo As String
        Dim KEY_OrderNoSeq As String
        Dim KEY_CustomerCode As String

        Dim KEY_ArrOrderNo As String
        Dim KEY_ArrOrderNoSeq As String
        Dim KEY_ArrCustomerCode As String

        Dim i As Integer
        Dim k As Integer

        Try

            'KEY_OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
            'KEY_OrderNoSeq = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex)
            'KEY_CustomerCode = getData(Vs1, getColumIndex(Vs1, "KEY_CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex)

            'If KEY_OrderNo = "" Or KEY_OrderNoSeq = "" Or KEY_CustomerCode = "" Then Exit Sub

            k = 0
            For i = 0 To Vs1.ActiveSheet.RowCount - 1

                If getData(Vs1, getColumIndex(Vs1, "DCHK"), i) = "1" Then
                    KEY_ArrOrderNo += getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), i) + "|"
                    KEY_ArrOrderNoSeq += getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), i) + "|"
                    If k = 0 Then
                        KEY_ArrCustomerCode = getData(Vs1, getColumIndex(Vs1, "KEY_CustomerCode"), i)
                    End If

                    k += 1
                End If

            Next

            If KEY_ArrOrderNo.Length = 0 Or KEY_ArrOrderNoSeq.Length = 0 Or KEY_ArrCustomerCode.Length = 0 Then Exit Sub

            KEY_ArrOrderNo = KEY_ArrOrderNo.Substring(0, KEY_ArrOrderNo.Length - 1)
            KEY_ArrOrderNoSeq = KEY_ArrOrderNoSeq.Substring(0, KEY_ArrOrderNoSeq.Length - 1)

            If ISUD4950A.Link_ISUD4950A_Arr(1, "", KEY_ArrOrderNo, KEY_ArrOrderNoSeq, KEY_ArrCustomerCode, Me.Name) = False Then Exit Sub

            'Call DATA_SEARCH_VS1()
        Catch ex As Exception
            Call MsgBoxP("MAIN_JOB01")
        End Try

    End Sub

    Private Sub MAIN_JOB02()
        Dim KEY_LoadingCode As String

        Dim KEY_ArrOrderNo As String
        Dim KEY_ArrOrderNoSeq As String
        Dim KEY_ArrCustomerCode As String

        Dim i As Integer
        Dim k As Integer

        Dim dsn As DataSet

        Try
            KEY_LoadingCode = getData(vS2, getColumIndex(vS2, "KEY_LoadingCode"), vS2.ActiveSheet.ActiveRowIndex)
            If KEY_LoadingCode = "" Then Exit Sub

            dsn = READ_PFK4951_DIS(KEY_LoadingCode, cn)

            If GetDsRc(dsn) = 0 Then Exit Sub

            k = 0

            For i = 0 To GetDsRc(dsn) - 1
                KEY_ArrOrderNo += GetDsData(dsn, i, "K4951_OrderNo") + "|"
                KEY_ArrOrderNoSeq += GetDsData(dsn, i, "K4951_OrderNoSeq") + "|"
            Next

            KEY_ArrOrderNo = KEY_ArrOrderNo.Substring(0, Len(KEY_ArrOrderNo) - 1)

            KEY_ArrOrderNoSeq = KEY_ArrOrderNoSeq.Substring(0, Len(KEY_ArrOrderNoSeq) - 1)

            If READ_PFK4950(KEY_LoadingCode) = True Then
                KEY_ArrCustomerCode = D4950.CustomerCode
            End If

            If ISUD4950A.Link_ISUD4950A_Arr(2, KEY_LoadingCode, KEY_ArrOrderNo, KEY_ArrOrderNoSeq, KEY_ArrCustomerCode, Me.Name) = False Then Exit Sub

        Catch ex As Exception
            Call MsgBoxP("MAIN_JOB02")
        End Try
    End Sub

    Private Sub MAIN_JOB03()
        Dim KEY_LoadingCode As String

        Dim KEY_ArrOrderNo As String
        Dim KEY_ArrOrderNoSeq As String
        Dim KEY_ArrCustomerCode As String

        Dim i As Integer
        Dim k As Integer

        Dim dsn As DataSet

        Try
            KEY_LoadingCode = getData(vS2, getColumIndex(vS2, "KEY_LoadingCode"), vS2.ActiveSheet.ActiveRowIndex)
            If KEY_LoadingCode = "" Then Exit Sub

            dsn = READ_PFK4951_DIS(KEY_LoadingCode, cn)

            If GetDsRc(dsn) = 0 Then Exit Sub

            k = 0

            For i = 0 To GetDsRc(dsn) - 1
                KEY_ArrOrderNo += GetDsData(dsn, i, "KEY_OrderNo") + "|"
                KEY_ArrOrderNoSeq += GetDsData(dsn, i, "KEY_OrderNoSeq") + "|"
            Next

            KEY_ArrOrderNo = KEY_ArrOrderNo.Substring(0, Len(KEY_ArrOrderNo) - 1)

            KEY_ArrOrderNoSeq = KEY_ArrOrderNoSeq.Substring(0, Len(KEY_ArrOrderNoSeq) - 1)

            If READ_PFK4950(KEY_LoadingCode) = True Then
                KEY_ArrCustomerCode = D4950.CustomerCode
            End If

            If ISUD4950A.Link_ISUD4950A_Arr(3, KEY_LoadingCode, KEY_ArrOrderNo, KEY_ArrOrderNoSeq, KEY_ArrCustomerCode, Me.Name) = False Then Exit Sub
            'If ISUD4950A.Link_ISUD4950A_SUD(3, KEY_LoadingCode, Me.Name) = False Then Exit Sub

            Call DATA_SEARCH_VS1()
        Catch ex As Exception
            Call MsgBoxP("MAIN_JOB03")
        End Try
    End Sub

    Private Sub MAIN_JOB04()
        Dim KEY_LoadingCode As String

        Dim KEY_ArrOrderNo As String
        Dim KEY_ArrOrderNoSeq As String
        Dim KEY_ArrCustomerCode As String

        Dim i As Integer
        Dim k As Integer

        Dim dsn As DataSet

        Try
            KEY_LoadingCode = getData(vS2, getColumIndex(vS2, "KEY_LoadingCode"), vS2.ActiveSheet.ActiveRowIndex)
            If KEY_LoadingCode = "" Then Exit Sub

            dsn = READ_PFK4951_DIS(KEY_LoadingCode, cn)

            If GetDsRc(dsn) = 0 Then Exit Sub

            k = 0

            For i = 0 To GetDsRc(dsn) - 1
                KEY_ArrOrderNo += GetDsData(dsn, i, "K4951_OrderNo") + "|"
                KEY_ArrOrderNoSeq += GetDsData(dsn, i, "K4951_OrderNoSeq") + "|"
            Next

            KEY_ArrOrderNo = KEY_ArrOrderNo.Substring(0, Len(KEY_ArrOrderNo) - 1)

            KEY_ArrOrderNoSeq = KEY_ArrOrderNoSeq.Substring(0, Len(KEY_ArrOrderNoSeq) - 1)

            If READ_PFK4950(KEY_LoadingCode) = True Then
                KEY_ArrCustomerCode = D4950.CustomerCode
            End If

            If ISUD4950A.Link_ISUD4950A_Arr(4, KEY_LoadingCode, KEY_ArrOrderNo, KEY_ArrOrderNoSeq, KEY_ArrCustomerCode, Me.Name) = False Then Exit Sub

            Call DATA_SEARCH_VS1()
        Catch ex As Exception
            Call MsgBoxP("MAIN_JOB04")
        End Try
    End Sub

#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS1(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS1 = False
        Vs1.Enabled = False

        SplitContainer1.Panel2Collapsed = True
        Try

            DS1 = PrcDS("USP_PFP49500_SEARCH_VS1", cn, txt_cdSite.Code, pnr_Year.Value.ToString, pnr_Week.Value.ToString, txt_CustomerCode.Code, txt_PackingBatch.Data, _
             txt_PONO.Data, txt_PKO.Data, txt_Line.Data, txt_Article.Data, txt_ColorName.Data, txt_SLno.Data, chk_POno.CheckState, chk_POYes.CheckState)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_PFP49500_SEARCH_VS1", "Vs1")
                Vs1.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs1, DS1, "USP_PFP49500_SEARCH_VS1", "Vs1")
            DATA_SEARCH_VS1 = True

            Vs1.Enabled = True

        Catch ex As Exception
            Call MsgBoxP("DATA_SEARCH_VS1")
        End Try
    End Function

    Private Function DATA_SEARCH_VS2(OrderNo As String, OrderNoSeq As String, Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS2 = False
        vS2.Enabled = False
        SplitContainer1.Panel2Collapsed = True

        Try

            DS1 = PrcDS("USP_PFP49500_SEARCH_VS2", cn, OrderNo, OrderNoSeq)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS2, DS1, "USP_PFP49500_SEARCH_VS2", "vS2")
                vS3.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS2, DS1, "USP_PFP49500_SEARCH_VS2", "vS2")
            DATA_SEARCH_VS2 = True

            vS2.Enabled = True

            SPR_CLEAR(vS3)

        Catch ex As Exception
            Call MsgBoxP("DATA_SEARCH_VS2")
        End Try
    End Function

    Private Function DATA_SEARCH_VS3(LoadingCode As String, Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS3 = False
        vS3.Enabled = False
        Try

            DS1 = PrcDS("USP_PFP49500_SEARCH_VS3", cn, LoadingCode)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS3, DS1, "USP_PFP49500_SEARCH_VS3", "vS3")
                vS3.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS3, DS1, "USP_PFP49500_SEARCH_VS3", "vS3")
            DATA_SEARCH_VS3 = True

            vS3.Enabled = True

        Catch ex As Exception
            Call MsgBoxP("DATA_SEARCH_VS3")
        End Try
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
    End Sub

    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick

        Dim OrderNo As String
        Dim OrderSeq As String

        Try
            OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
            OrderSeq = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex)

            Call DATA_SEARCH_VS2(OrderNo, OrderSeq)

            SPR_CLEAR(vS3)

        Catch ex As Exception
            Call MsgBoxP("Vs1_CellDoubleClick")
        End Try

    End Sub

    Private Sub Vs2_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS2.CellDoubleClick

        Dim LoadingCode As String
        Try
            LoadingCode = getData(vS2, getColumIndex(vS2, "KEY_LoadingCode"), vS2.ActiveSheet.ActiveRowIndex)
            If READ_PFK4950(LoadingCode) = False Then Exit Sub

            SplitContainer1.Panel2Collapsed = False
            Call DATA_SEARCH_VS3(LoadingCode)
        Catch ex As Exception
            Call MsgBoxP("Vs2_CellDoubleClick")
        End Try

    End Sub

    Private Sub vS1_GotFocus(sender As Object, e As EventArgs)

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False)

        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False
    End Sub

    Private Sub vS1_LostFocus(sender As Object, e As EventArgs)
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False)
    End Sub

    Private Sub vS3_GotFocus(sender As Object, e As EventArgs) Handles vS3.GotFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, True, True, True, False, False)
    End Sub

    Private Sub vS3_LostFocus(sender As Object, e As EventArgs) Handles vS3.LostFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)
    End Sub

    Private Sub txt_GNAME_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Enter : cmd_SEARCH.Focus()
        End Select
    End Sub


    Private Sub chk_FSEL_Click(sender As Object, e As EventArgs) Handles chk_FSEL.CheckedChanged
        If chk_FSEL.CheckState = 0 Then
            chk_FSEL.BackColor = clrUncheck
            chk_FSEL.ForeColor = Color.Black

            chk_FSEL.Text = WordConv("OPEN")
            ssp_WHERE.Visible = False
        Else
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

        Call DATA_SEARCH_VS1()

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
            MAIN_JOB02()
        ElseIf Cms_2.Items(1).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB03()
        ElseIf Cms_2.Items(2).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB04()
        End If

    End Sub


#End Region


End Class