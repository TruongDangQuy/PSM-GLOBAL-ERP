Public Class PFP23549
#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Private wGCODE As String
    Protected prg As E_PRG

    Private W2354 As T2354_AREA
    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)


        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

        Call Cms_additem(Cms_2, _
                        "MATERIAL QC INBOUND PROCESSING - " & WordConv("INSERT") & "(F6)", _
                        "MATERIAL QC INBOUND PROCESSING - " & WordConv("SEARCH") & "(F6)", _
                        "MATERIAL QC INBOUND PROCESSING - " & WordConv("UPDATE") & "(F7)", _
                        "MATERIAL QC INBOUND PROCESSING - " & WordConv("DELETE") & "(F8)")

        vS20.ContextMenuStrip = Cms_2

        Me.KeyPreview = True

        Call FORM_INIT()
        Call DATA_INIT()

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
        SdateEdate.text1 = System_Date_6() & "01"
        SdateEdate.text2 = System_Date_8()

        txt_cdDepartment.Enabled = Not True

    End Sub
#End Region

#Region "Function"
    Private Sub MAIN_JOB01()
        Try
            Select Case True

                Case vS20.Focused

                    If ISUD2354B.Link_ISUD2354B(1, getData(vS20, getColumIndex(vS20, "KEY_MaterialInBoundNo"), vS20.ActiveSheet.ActiveRowIndex), getData(vS20, getColumIndex(vS20, "KEY_MaterialInboundSeq"), vS20.ActiveSheet.ActiveRowIndex), getData(vS20, getColumIndex(vS20, "KEY_MaterialInboundSno"), vS20.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub

            End Select
        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB01!", vbCritical)
        End Try

    End Sub

    Private Sub MAIN_JOB02()
        Try
            Select Case True

                Case vS20.Focused

                    If getData(vS20, getColumIndex(vS20, "KEY_MaterialInBoundNo"), vS20.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

                    If ISUD2354B.Link_ISUD2354B(2, getData(vS20, getColumIndex(vS20, "KEY_MaterialInBoundNo"), vS20.ActiveSheet.ActiveRowIndex), getData(vS20, getColumIndex(vS20, "KEY_MaterialInboundSeq"), vS20.ActiveSheet.ActiveRowIndex), getData(vS20, getColumIndex(vS20, "KEY_MaterialInboundSno"), vS20.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub

            End Select
        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB02!", vbCritical)
        End Try

    End Sub

    Private Sub MAIN_JOB03()
        Try
            Select Case True
                Case vS20.Focused

                    If getData(vS20, getColumIndex(vS20, "KEY_MaterialInBoundNo"), vS20.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

                    If ISUD2354B.Link_ISUD2354B(3, getData(vS20, getColumIndex(vS20, "KEY_MaterialInBoundNo"), vS20.ActiveSheet.ActiveRowIndex), getData(vS20, getColumIndex(vS20, "KEY_MaterialInboundSeq"), vS20.ActiveSheet.ActiveRowIndex), getData(vS20, getColumIndex(vS20, "KEY_MaterialInboundSno"), vS20.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub
                    DATA_SEARCH_VS20()
            End Select
        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB03!", vbCritical)
        End Try
    End Sub

    Private Sub MAIN_JOB04()
        Try
            Select Case True
                Case vS20.Focused
                    Dim CheckInBoundMaterial As String

                    If getData(vS20, getColumIndex(vS20, "KEY_MaterialInBoundNo"), vS20.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
                    CheckInBoundMaterial = getData(vS20, getColumIndex(vS20, "CheckInBoundMaterial"), vS20.ActiveSheet.ActiveRowIndex)

                    If ISUD2354B.Link_ISUD2354B(4, getData(vS20, getColumIndex(vS20, "KEY_MaterialInBoundNo"), vS20.ActiveSheet.ActiveRowIndex), getData(vS20, getColumIndex(vS20, "KEY_MaterialInboundSeq"), vS20.ActiveSheet.ActiveRowIndex), getData(vS20, getColumIndex(vS20, "KEY_MaterialInboundSno"), vS20.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub
                    DATA_SEARCH_VS20()
            End Select

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB04!", vbCritical)
        End Try
    End Sub

    Private Sub MAIN_JOB05()
        Try


        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB05!", vbCritical)
        End Try

    End Sub

#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS10(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS10 = False

        VS10.Enabled = False

        DS1 = PrcDS("USP_PFP23549_SEARCH_VS10", cn, SdateEdate.text1, _
                                                    SdateEdate.text2, _
                                                    txt_cdDepartment.Code,
                                                    txt_FactOrderNo.Data,
                                                    txt_SupplierCode.Data, _
                                                    txt_cdLargeGroupMaterial.Data, _
                                                    txt_cdSemiGroupMaterial.Data, _
                                                    "*" & txt_MaterialName.Data, _
                                                    chk_CheckProcessMaterial0.CheckState, _
                                                    chk_CheckProcessMaterial1.CheckState, _
                                                    chk_CheckMaterialType0.CheckState, _
                                                    chk_CheckMaterialType1.CheckState, _
                                                    chk_CheckMarketType0.CheckState, _
                                                    chk_CheckMarketType1.CheckState,
                                                    PeaceCheckbox1.CheckState,
                                                    PeaceCheckbox2.CheckState,
                                                    PeaceCheckbox3.CheckState,
                                                    PeaceCheckbox4.CheckState,
                                                    PeaceCheckbox5.CheckState,
                                                    PeaceCheckbox6.CheckState,
                                                    PeaceCheckbox7.CheckState,
                                                    PeaceCheckbox8.CheckState)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(VS10, DS1, "USP_PFP23549_SEARCH_VS10", "VS10")
            VS10.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(VS10, DS1, "USP_PFP23549_SEARCH_VS10", "VS10")
        DATA_SEARCH_VS10 = True

        VS10.Enabled = True
    End Function

    Private Function DATA_SEARCH_VS20(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS20 = False

        vS20.Enabled = False

        DS1 = PrcDS("USP_PFP23549_SEARCH_VS20", cn, SdateEdate.text1, _
                                                    SdateEdate.text2, _
                                                    txt_cdDepartment.Code,
                                                    txt_FactOrderNo.Data,
                                                    txt_SupplierCode.Data, _
                                                    txt_cdLargeGroupMaterial.Data, _
                                                    txt_cdSemiGroupMaterial.Data, _
                                                    "*" & txt_MaterialName.Data, _
                                                    chk_CheckProcessMaterial0.CheckState, _
                                                    chk_CheckProcessMaterial1.CheckState, _
                                                    chk_CheckMaterialType0.CheckState, _
                                                    chk_CheckMaterialType1.CheckState, _
                                                    chk_CheckMarketType0.CheckState, _
                                                    chk_CheckMarketType1.CheckState,
                                                    PeaceCheckbox1.CheckState,
                                                    PeaceCheckbox2.CheckState,
                                                    PeaceCheckbox3.CheckState,
                                                    PeaceCheckbox4.CheckState,
                                                    PeaceCheckbox5.CheckState,
                                                    PeaceCheckbox6.CheckState,
                                                    PeaceCheckbox7.CheckState,
                                                    PeaceCheckbox8.CheckState)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS20, DS1, "USP_PFP23549_SEARCH_VS20", "VS20")
            vS20.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS20, DS1, "USP_PFP23549_SEARCH_VS20", "VS20")
        DATA_SEARCH_VS20 = True

        vS20.Enabled = True
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
    Private Sub VS10_CellClick(sender As Object, e As CellClickEventArgs)
        If e.ColumnHeader = True Then Exit Sub
        VS10.ActiveSheet.ActiveColumnIndex = e.Column
        VS10.ActiveSheet.ActiveRowIndex = e.Row
        VS10.ActiveSheet.AddSelection(e.Row, e.Column, 1, 1)
    End Sub

    Private Sub VS10_GotFocus(sender As Object, e As EventArgs)

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False

        If ItemMain.SelectedIndex = 0 Then Call DATA_SEARCH_VS10()
        If ItemMain.SelectedIndex = 1 Then Call DATA_SEARCH_VS20()

    End Sub
    Private Sub txt_GNAME_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Enter : cmd_SEARCH.Focus()
        End Select
    End Sub
    Private Sub VS10_LostFocus(sender As Object, e As EventArgs)

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

        If ItemMain.SelectedIndex = 0 Then Call DATA_SEARCH_VS10()
        If ItemMain.SelectedIndex = 1 Then Call DATA_SEARCH_VS20()
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

        ElseIf Cms_2.Items(4).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB04()

        End If
    End Sub

    Private Sub Me_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Width > 30 Then
            ItemMain.ItemSize = New Size((Me.Width - 30) / 3, 25)
        End If
    End Sub

#End Region

End Class