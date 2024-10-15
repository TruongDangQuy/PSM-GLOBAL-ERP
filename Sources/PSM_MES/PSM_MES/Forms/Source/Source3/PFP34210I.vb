Public Class PFP34210I

#Region "Variable"

    Private Dsu01 As Long     'Data Su
    Private wGCODE As String
    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Cms_additem(Cms_1,
                        "INBOUND REQUEST - WAREHOUSE MATERIAL PROCCESING - " & WordConv("INPUT") & "(F5)",
                        "INBOUND REQUEST - WAREHOUSE MATERIAL PROCCESING - " & WordConv("SEARCH") & "(F6)",
                        "INBOUND REQUEST - WAREHOUSE MATERIAL PROCCESING - " & WordConv("UPDATE") & "(F7)",
                        "INBOUND REQUEST - WAREHOUSE MATERIAL PROCCESING - " & WordConv("DELETE") & "(F8)",
                        "-",
                        "INBOUND REQUEST - WAREHOUSE MATERIAL PROCCESING - " & WordConv("APPROVAL") & "(F9)",
                        "INBOUND REQUEST - WAREHOUSE MATERIAL PROCCESING - " & WordConv("APPROVAL-ALL LINES") & "(F10)")

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

        Me.KeyPreview = True

        Call FORM_INIT()
        Call DATA_INIT()

        SdateEdate.text1 = System_Date_Add(-1)
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
    End Sub

    Private Sub DATA_INIT()
        If Trim(Pub.DEPARTMENT) <> "" Then
            If READ_PFK7171(ListCode("Site"), Pub.DEPARTMENT) = True Then

                txt_cdFactory.Data = D7171.BasicName
                txt_cdFactory.Code = D7171.BasicCode
                txt_cdFactory.Enabled = Not True

            End If
        End If

        If Trim(Pub.SITE) <> "" Then
            If READ_PFK7171(ListCode("Site"), Pub.SITE) = True Then

                txt_cdSite.Data = D7171.BasicName
                txt_cdSite.Code = D7171.BasicCode
                txt_cdSite.Enabled = Not True

            End If
        End If

        txt_cdLargeGroupMaterial.Enabled = False
    End Sub
#End Region

#Region "Function"
    Private Sub MAIN_JOB01()
        'If ISUD3421A_IN.Link_ISUD3421A_IN(1, "000000000", Me.Name) = False Then Exit Sub

        Call DATA_SEARCH01()
    End Sub

    Private Sub MAIN_JOB02()
        If getData(Vs1, getColumIndex(Vs1, "KEY_FactRequestOrderYarnNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
        Dim FactRequestOrderYarnNo As String

        FactRequestOrderYarnNo = getData(Vs1, getColumIndex(Vs1, "KEY_FactRequestOrderYarnNo"), Vs1.ActiveSheet.ActiveRowIndex)

        'If ISUD3421A_IN.Link_ISUD3421A_IN(2, FactRequestOrderYarnNo, Me.Name) = False Then Exit Sub

    End Sub

    Private Sub MAIN_JOB03()
        If getData(Vs1, getColumIndex(Vs1, "KEY_FactRequestOrderYarnNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
        Dim FactRequestOrderYarnNo As String

        FactRequestOrderYarnNo = getData(Vs1, getColumIndex(Vs1, "KEY_FactRequestOrderYarnNo"), Vs1.ActiveSheet.ActiveRowIndex)

        'If ISUD3421A_IN.Link_ISUD3421A_IN(3, FactRequestOrderYarnNo, Me.Name) = False Then Exit Sub

        Call DATA_SEARCH01() : Exit Sub

        If LINE_MOVE_DISPLAY01() = False Then
            SPR_CLEAR(Vs1, Vs1.ActiveSheet.ActiveRowIndex, 0, Vs1.ActiveSheet.ActiveRowIndex, Vs1.ActiveSheet.ColumnCount - 1)
            setData(Vs1, getColumIndex(Vs1, "DateRequestMaterial"), Vs1.ActiveSheet.ActiveRowIndex, "[DELETED]", Color.Red)
        End If
    End Sub

    Private Sub MAIN_JOB04()
        If getData(Vs1, getColumIndex(Vs1, "KEY_FactRequestOrderYarnNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
        Dim FactRequestOrderYarnNo As String

        FactRequestOrderYarnNo = getData(Vs1, getColumIndex(Vs1, "KEY_FactRequestOrderYarnNo"), Vs1.ActiveSheet.ActiveRowIndex)

        'If ISUD3421A_IN.Link_ISUD3421A_IN(4, FactRequestOrderYarnNo, Me.Name) = False Then Exit Sub

        Call DATA_SEARCH01() : Exit Sub

        If LINE_MOVE_DISPLAY01() = False Then
            SPR_CLEAR(Vs1, Vs1.ActiveSheet.ActiveRowIndex, 0, Vs1.ActiveSheet.ActiveRowIndex, Vs1.ActiveSheet.ColumnCount - 1)
            setData(Vs1, getColumIndex(Vs1, "DateRequestMaterial"), Vs1.ActiveSheet.ActiveRowIndex, "[DELETED]", Color.Red)
        End If

    End Sub


    Private Sub MAIN_JOB05()
        If getData(Vs1, getColumIndex(Vs1, "KEY_FactRequestOrderYarnNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
        Dim FactRequestOrderYarnNo As String

        FactRequestOrderYarnNo = getData(Vs1, getColumIndex(Vs1, "KEY_FactRequestOrderYarnNo"), Vs1.ActiveSheet.ActiveRowIndex)

        'If ISUD3421P.Link_ISUD3421P(3, FactRequestOrderYarnNo,
        '                            getData(Vs1, getColumIndex(Vs1, "KEY_FactRequestOrderYarnSeq"), Vs1.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub

        Call DATA_SEARCH01() : Exit Sub

        If LINE_MOVE_DISPLAY01() = False Then
            SPR_CLEAR(Vs1, Vs1.ActiveSheet.ActiveRowIndex, 0, Vs1.ActiveSheet.ActiveRowIndex, Vs1.ActiveSheet.ColumnCount - 1)
            setData(Vs1, getColumIndex(Vs1, "DateRequestMaterial"), Vs1.ActiveSheet.ActiveRowIndex, "[DELETED]", Color.Red)
        End If

    End Sub

    Private Sub MAIN_JOB06()
        If getData(Vs1, getColumIndex(Vs1, "KEY_FactRequestOrderYarnNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
        Dim FactRequestOrderYarnNo As String

        FactRequestOrderYarnNo = getData(Vs1, getColumIndex(Vs1, "KEY_FactRequestOrderYarnNo"), Vs1.ActiveSheet.ActiveRowIndex)

        'If ISUD3421P.Link_ISUD3421P(4, FactRequestOrderYarnNo,
        '                            getData(Vs1, getColumIndex(Vs1, "KEY_FactRequestOrderYarnSeq"), Vs1.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub

        Call DATA_SEARCH01()

    End Sub

#End Region

#Region "Data_search"
    Private Function DATA_SEARCH01(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH01 = False
        Vs1.Enabled = False

        DS1 = PrcDS("USP_PFP34210I_SEARCH_VS1", cn, SdateEdate.text1,
                                                    SdateEdate.text2,
                                                    txt_GCODE.chkAll.CheckState,
                                                    txt_GCODE.SQL,
                                                    txt_cdSite.Code,
                                                    txt_cdFactory.Code,
                                                   "*" & txt_MaterialName.Data,
                                                    txt_InchargePurcharsing.Code,
                                                    txt_cdLargeGroupMaterial.Code,
                                                    txt_cdSemiGroupMaterial.Data,
                                                    txt_cdDetailGroupMaterial.Data,
                                                    CheckRequestMaterial,
                                                    cmb_CheckMaterialInbound.InSelected,
                                                    opt_CheckRelationType0.CheckState,
                                                    opt_CheckRelationType1.CheckState,
                                                    chk_CheckIOType0.CheckState,
                                                    chk_CheckIOType1.CheckState,
                                                    chk_CheckMaterialType0.CheckState,
                                                    chk_CheckMaterialType1.CheckState,
                                                    chk_CheckMarketType0.CheckState,
                                                    chk_CheckMarketType1.CheckState)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs1, DS1, "USP_PFP34210I_SEARCH_VS1", "Vs1")
            Vs1.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "USP_PFP34210I_SEARCH_VS1", "Vs1")
        DATA_SEARCH01 = True

        Vs1.Enabled = True
    End Function

    Private Function LINE_MOVE_DISPLAY01() As Boolean
        LINE_MOVE_DISPLAY01 = False
        Dim FactRequestOrderYarnNo As String
        Dim FactRequestOrderYarnSeq As String
        Dim cdFactory As String
        Dim cdSite As String

        cdSite = getData(Vs1, getColumIndex(Vs1, "KEY_cdSite"), Vs1.ActiveSheet.ActiveRowIndex)
        cdFactory = getData(Vs1, getColumIndex(Vs1, "KEY_cdFactory"), Vs1.ActiveSheet.ActiveRowIndex)

        FactRequestOrderYarnNo = getData(Vs1, getColumIndex(Vs1, "FactRequestOrderYarnNo"), Vs1.ActiveSheet.ActiveRowIndex)
        FactRequestOrderYarnSeq = getData(Vs1, getColumIndex(Vs1, "FactRequestOrderYarnSeq"), Vs1.ActiveSheet.ActiveRowIndex)

        Try
            DS1 = PrcDS("USP_PFP34210_SEARCH_VS1_LINE", cn,
                                                        FactRequestOrderYarnNo,
                                                        FactRequestOrderYarnSeq)

            If GetDsRc(DS1) = 0 Then
                Vs1.Enabled = True
                Exit Function
            End If

            READ_SPREAD(Vs1, DS1, "USP_PFP34210_SEARCH_VS1", "Vs1", Vs1.ActiveSheet.ActiveRowIndex)

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
        End If

    End Sub


#End Region


End Class