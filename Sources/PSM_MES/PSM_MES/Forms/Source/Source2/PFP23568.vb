Public Class PFP23568
#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Private wGCODE As String

    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)

        Me.KeyPreview = True

        Call FORM_INIT()
        Call DATA_INIT()

        Call Cms_additem(Cms_1,
                   "ISSUE CONTROL PROCCESING - " & WordConv("INPUT") & "(F5)")


        Call Cms_additem(Cms_2,
                  "ISSUE CONTROL PROCCESING - " & WordConv("INPUT") & "(F5)",
                 "ISSUE CONTROL PROCCESING - " & WordConv("SEARCH") & "(F6)",
                 "ISSUE CONTROL PROCCESING - " & WordConv("UPDATE") & "(F7)",
                 "ISSUE CONTROL PROCCESING - " & WordConv("DELETE") & "(F8)",
                 "-",
                 "ISSUE CONTRO PROCCESING - " & WordConv("APPROVAL STATUS") & "(F10)")

        vS20.ContextMenuStrip = Cms_1
        VS30.ContextMenuStrip = Cms_2

    End Sub
    Private Sub PFP17811_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

        Dim i As Integer
        Dim SpecNoList As String
        Dim KEY_Autokey As String

        If vS20.Focused Then


            For i = 0 To vS20.ActiveSheet.RowCount - 1
                If getDataM(vS20, getColumIndex(vS20, "dchk"), i) <> "1" Then GoTo next1
                KEY_Autokey = getData(vS20, getColumIndex(vS20, "KEY_Autokey"), i)

                If READ_PFK3011(KEY_Autokey) Then
                    SpecNoList = SpecNoList & "''" & KEY_Autokey & "''"
                    SpecNoList = SpecNoList & ","
                End If
next1:
            Next

            If SpecNoList = "" Then Exit Sub
            If SpecNoList = "" Then Exit Sub

            SpecNoList = Strings.Left(SpecNoList, Len(SpecNoList) - 1)
            If ISUD2345A.Link_ISUD2345A_INSERT_MULTI(11, SpecNoList, Me.Name) = False Then Exit Sub

            Call DATA_SEARCH_VS20()

        ElseIf VS30.Focused Then
            If ISUD2345A.Link_ISUD2345A(1, "", Me.Name) = False Then Exit Sub

            Call DATA_SEARCH_VS20()
        End If

    End Sub

    Private Sub MAIN_JOB02()
        If getData(VS30, getColumIndex(VS30, "KEY_FactOrderNo"), VS30.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        Dim FactOrderNo As String
        FactOrderNo = getData(VS30, getColumIndex(VS30, "KEY_FactOrderNo"), VS30.ActiveSheet.ActiveRowIndex)

        If ISUD2345A.Link_ISUD2345A(2, FactOrderNo, Me.Name) = False Then Exit Sub

    End Sub

    Private Sub MAIN_JOB03()
        If getData(VS30, getColumIndex(VS30, "KEY_FactOrderNo"), VS30.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        Dim FactOrderNo As String
        FactOrderNo = getData(VS30, getColumIndex(VS30, "KEY_FactOrderNo"), VS30.ActiveSheet.ActiveRowIndex)

        If ISUD2345A.Link_ISUD2345A(3, FactOrderNo, Me.Name) = False Then Exit Sub

        Call DATA_SEARCH_VS30()
    End Sub

    Private Sub MAIN_JOB04()
        If getData(VS30, getColumIndex(VS30, "KEY_FactOrderNo"), VS30.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        Dim FactOrderNo As String
        FactOrderNo = getData(VS30, getColumIndex(VS30, "KEY_FactOrderNo"), VS30.ActiveSheet.ActiveRowIndex)

        If ISUD2345A.Link_ISUD2345A(4, FactOrderNo, Me.Name) = False Then Exit Sub

        Call DATA_SEARCH_VS30()

    End Sub
    Private Sub MAIN_JOB05()

        If getData(VS30, getColumIndex(VS30, "KEY_FactOrderNo"), VS30.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        Dim FactOrderNo As String
        FactOrderNo = getData(VS30, getColumIndex(VS30, "KEY_FactOrderNo"), VS30.ActiveSheet.ActiveRowIndex)

        If ISUD2345P.Link_ISUD2345P(3, FactOrderNo,
                                        getData(VS30, getColumIndex(VS30, "KEY_FactOrderSeq"),
                                        VS30.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub

        Call DATA_SEARCH_VS30()
    End Sub

    Private Sub MAIN_JOB31()


    End Sub

#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS10(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS10 = False

        Vs10.Enabled = False

        DS1 = PrcDS("USP_PFP23568_SEARCH_VS10", cn, SdateEdate.text1, SdateEdate.text2, txt_cdSite.Code, txt_CustPONO.Data, txt_Article.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs10, DS1, "USP_PFP23568_SEARCH_VS10", "vS10")

            Vs10.ActiveSheet.RowCount = 0
            Vs10.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs10, DS1, "USP_PFP23568_SEARCH_VS10", "vS10")
        DATA_SEARCH_VS10 = True

        Vs10.Enabled = True
    End Function
    Private Function DATA_SEARCH_VS20(Optional OrderNo As String = "", Optional OrderNoSeq As String = "") As Boolean
        DATA_SEARCH_VS20 = False

        vS20.Enabled = False

        If txt_cdSite.Data = "" Then txt_cdSite.Code = ""

        DS1 = PrcDS("USP_PFP23568_SEARCH_vS20", cn, SdateEdate.text1, SdateEdate.text2, txt_cdSite.Code, txt_CustPONO.Data, txt_Article.Data)


        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS20, DS1, "USP_PFP23568_SEARCH_vS20", "vS20")
            vS20.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS20, DS1, "USP_PFP23568_SEARCH_vS20", "vS20")
        DATA_SEARCH_VS20 = True

        vS20.Enabled = True
    End Function

    Private Function DATA_SEARCH_VS30(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS30 = False

        VS30.Enabled = False

        DS1 = PrcDS("USP_PFP23568_SEARCH_VS30", cn, SdateEdate.text1, SdateEdate.text2, txt_cdSite.Code, txt_CustPONO.Data, txt_Article.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(VS30, DS1, "USP_PFP23568_SEARCH_VS30", "VS30")

            VS30.ActiveSheet.RowCount = 0
            VS30.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(VS30, DS1, "USP_PFP23568_SEARCH_VS30", "VS30")
        DATA_SEARCH_VS30 = True

        VS30.Enabled = True
    End Function
    Private Function LINE_MOVE_DISPLAY01() As Boolean
        LINE_MOVE_DISPLAY01 = False

    End Function
    Private Function CustomerPurchasing_CHK() As String
        CustomerPurchasing_CHK = "1"
        Return CustomerPurchasing_CHK
    End Function

#End Region

#Region "Event"
    Private Sub tst_1_Click(sender As Object, e As EventArgs) Handles tst_1.Click, tst_2.Click, tst_3.Click, tst_4.Click, tst_5.Click, tst_6.Click

    End Sub
    Private Sub vS20_CellClick(sender As Object, e As CellClickEventArgs)
        If e.ColumnHeader = True Then Exit Sub
        vS20.ActiveSheet.ActiveColumnIndex = e.Column
        vS20.ActiveSheet.ActiveRowIndex = e.Row
        vS20.ActiveSheet.AddSelection(e.Row, e.Column, 1, 1)
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

    End Sub
    Private Sub Me_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Width > 30 Then
            ItemMain.ItemSize = New Size((Me.Width - 30) / ItemMain.TabCount, 25)
        End If
    End Sub

#End Region

    Private Sub Vs10_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs10.CellClick

    End Sub

    Private Sub Vs10_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs10.CellDoubleClick
        Dim OrderNo As String
        Dim OrderNoSeq As String

        OrderNo = getData(Vs10, getColumIndex(Vs10, "KEY_OrderNo"), e.Row)
        OrderNoSeq = getData(Vs10, getColumIndex(Vs10, "KEY_OrderNoSeq"), e.Row)

        If READ_PFK1312(OrderNo, OrderNoSeq) = False Then Exit Sub

        Select Case e.Column
            Case getColumIndex(Vs10, "CustPoNo"), getColumIndex(Vs10, "PONO")
                Call ISUD1311A_F1.Link_ISUD1311A_F1("2", OrderNo, "PFP13123")

            Case getColumIndex(Vs10, "cntCFPK"), getColumIndex(Vs10, "CheckCFPK")
                If READ_PFK7108_SHOESCODE(D1312.ShoesCode) Then
                    Call ISUD1310A.Link_ISUD1310A("2", D7108.GroupComponentBOM, OrderNo, OrderNoSeq, "PFP13123")
                End If



            Case getColumIndex(Vs10, "cntCFRND"), getColumIndex(Vs10, "CheckCFRND")
                If READ_PFK7108_SHOESCODE(D1312.ShoesCode) Then
                    Call ISUD7108C.Link_ISUD7108C("2", D7108.GroupComponentBOM, "PFP71060")
                End If


            Case Else
                If READ_PFK1312(OrderNo, OrderNoSeq) Then
                    Call DATA_SEARCH_VS20(OrderNo, OrderNoSeq)

                    ItemMain.SelectedIndex = 1
                End If
        End Select



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

End Class