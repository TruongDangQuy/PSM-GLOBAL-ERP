Public Class PFP23527

#Region "Variable"
    Private Dsu01 As Long
    Private wGCODE As String
    Protected prg As E_PRG

    Private W2351 As T2351_AREA
    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)

        Me.KeyPreview = True
        Call FORM_INIT()
        Call DATA_INIT()
    End Sub
    Private Sub PFP23527_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

        txt_cdDepartment.Data = "Planning"
        txt_cdDepartment.Code = "008"
        txt_cdDepartment.Enabled = Not True

        txt_cdLargeGroupMaterial.Data = "General"
        txt_cdLargeGroupMaterial.Code = "005"
        txt_cdLargeGroupMaterial.Enabled = Not True

        txt_cdSemiGroupMaterial.Data = "Last Tool"
        txt_cdSemiGroupMaterial.Code = "132"
        txt_cdSemiGroupMaterial.Enabled = Not True
    End Sub
#End Region

#Region "Function"
    Private Sub MAIN_JOB01()
        Try

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB01!", vbCritical)
        End Try
    End Sub

    Private Sub MAIN_JOB02()
        Try

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB02!", vbCritical)
        End Try
    End Sub

    Private Sub MAIN_JOB03()
        Try

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB03!", vbCritical)
        End Try
    End Sub

    Private Sub MAIN_JOB04()
        Try

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

        Vs10.Enabled = False

        DS1 = PrcDS("USP_PFP23527_SEARCH_vS10", cn, SdateEdate.text1, _
                                                    SdateEdate.text2, _
                                                    txt_cdDepartment.Code,
                                                    txt_CustomerInBoundMaterialName.Code, _
                                                    txt_cdLargeGroupMaterial.Data,
                                                    txt_cdSemiGroupMaterial.Data, _
                                                    txt_cdDetailGroupMaterial.Data, _
                                                    "*" & txt_MaterialName.Data, _
                                                    chk_CheckMarketType0.CheckState, _
                                                    chk_CheckMarketType1.CheckState,
                                                    chkInApproval1.CheckState, _
                                                    chkInApproval2.CheckState, _
                                                    chkInApproval3.CheckState, _
                                                    chkInApproval4.CheckState, _
                                                    chkInApproval5.CheckState, _
                                                    chkInApproval6.CheckState, _
                                                    chkInApproval7.CheckState, _
                                                    chkInApproval8.CheckState)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs10, DS1, "USP_PFP23527_SEARCH_vS10", "vS10")

            Vs10.ActiveSheet.RowCount = 0
            Vs11.ActiveSheet.RowCount = 0

            Vs10.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs10, DS1, "USP_PFP23527_SEARCH_vS10", "vS10")
        DATA_SEARCH_VS10 = True

        Vs10.Enabled = True
    End Function
    Private Function DATA_SEARCH_VS11(Optional ByVal tmpDate As String = "") As Boolean
        DATA_SEARCH_VS11 = False

        Vs11.Enabled = False

        DS1 = PrcDS("USP_PFP23527_SEARCH_vS11", cn, tmpDate, _
                                                    tmpDate, _
                                                    txt_cdDepartment.Code,
                                                    txt_CustomerInBoundMaterialName.Code, _
                                                    txt_cdLargeGroupMaterial.Data,
                                                    txt_cdSemiGroupMaterial.Data, _
                                                    txt_cdDetailGroupMaterial.Data, _
                                                    "*" & txt_MaterialName.Data, _
                                                    chk_CheckMarketType0.CheckState, _
                                                    chk_CheckMarketType1.CheckState,
                                                    chkInApproval1.CheckState, _
                                                    chkInApproval2.CheckState, _
                                                    chkInApproval3.CheckState, _
                                                    chkInApproval4.CheckState, _
                                                    chkInApproval5.CheckState, _
                                                    chkInApproval6.CheckState, _
                                                    chkInApproval7.CheckState, _
                                                    chkInApproval8.CheckState)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs11, DS1, "USP_PFP23527_SEARCH_vS11", "vS11")
            Vs11.ActiveSheet.RowCount = 0
            Vs11.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs11, DS1, "USP_PFP23527_SEARCH_vS11", "vS11")
        DATA_SEARCH_VS11 = True

        Vs11.Enabled = True
    End Function
    Private Function DATA_SEARCH_VS20(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS20 = False

        vS20.Enabled = False

        DS1 = PrcDS("USP_PFP23527_SEARCH_vS20", cn, SdateEdate.text1, _
                                                    SdateEdate.text2, _
                                                    txt_cdDepartment.Code,
                                                    txt_CustomerInBoundMaterialName.Code, _
                                                    txt_cdLargeGroupMaterial.Data,
                                                    txt_cdSemiGroupMaterial.Data, _
                                                    txt_cdDetailGroupMaterial.Data, _
                                                    "*" & txt_MaterialName.Data, _
                                                    chk_CheckMarketType0.CheckState, _
                                                    chk_CheckMarketType1.CheckState,
                                                    chkInApproval1.CheckState, _
                                                    chkInApproval2.CheckState, _
                                                    chkInApproval3.CheckState, _
                                                    chkInApproval4.CheckState, _
                                                    chkInApproval5.CheckState, _
                                                    chkInApproval6.CheckState, _
                                                    chkInApproval7.CheckState, _
                                                    chkInApproval8.CheckState)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS20, DS1, "USP_PFP23527_SEARCH_vS20", "VS20")
            vS20.ActiveSheet.RowCount = 0
            vS21.ActiveSheet.RowCount = 0

            vS20.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS20, DS1, "USP_PFP23527_SEARCH_vS20", "VS20")
        DATA_SEARCH_VS20 = True

        vS20.Enabled = True
    End Function
    Private Function DATA_SEARCH_VS21(Optional ByVal tmpCustomerInBoundMaterial As String = "") As Boolean
        DATA_SEARCH_VS21 = False

        vS21.Enabled = False

        DS1 = PrcDS("USP_PFP23527_SEARCH_vS21", cn, SdateEdate.text1, _
                                                    SdateEdate.text2, _
                                                    txt_cdDepartment.Code,
                                                    tmpCustomerInBoundMaterial, _
                                                    txt_cdLargeGroupMaterial.Data,
                                                    txt_cdSemiGroupMaterial.Data, _
                                                    txt_cdDetailGroupMaterial.Data, _
                                                    "*" & txt_MaterialName.Data, _
                                                    chk_CheckMarketType0.CheckState, _
                                                    chk_CheckMarketType1.CheckState,
                                                    chkInApproval1.CheckState, _
                                                    chkInApproval2.CheckState, _
                                                    chkInApproval3.CheckState, _
                                                    chkInApproval4.CheckState, _
                                                    chkInApproval5.CheckState, _
                                                    chkInApproval6.CheckState, _
                                                    chkInApproval7.CheckState, _
                                                    chkInApproval8.CheckState)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS21, DS1, "USP_PFP23527_SEARCH_vS21", "vS21")
            vS21.ActiveSheet.RowCount = 0

            vS21.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS21, DS1, "USP_PFP23527_SEARCH_vS21", "vS21")
        DATA_SEARCH_VS21 = True

        vS21.Enabled = True
    End Function
    Private Function DATA_SEARCH_VS30(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS30 = False

        vS30.Enabled = False

        DS1 = PrcDS("USP_PFP23527_SEARCH_vS30", cn, SdateEdate.text1, _
                                                    SdateEdate.text2, _
                                                    txt_cdDepartment.Code,
                                                    txt_CustomerInBoundMaterialName.Code, _
                                                    txt_cdLargeGroupMaterial.Data,
                                                    txt_cdSemiGroupMaterial.Data, _
                                                    txt_cdDetailGroupMaterial.Data, _
                                                    "*" & txt_MaterialName.Data, _
                                                    chk_CheckMarketType0.CheckState, _
                                                    chk_CheckMarketType1.CheckState, _
                                                    chkInApproval1.CheckState, _
                                                    chkInApproval2.CheckState, _
                                                    chkInApproval3.CheckState, _
                                                    chkInApproval4.CheckState, _
                                                    chkInApproval5.CheckState, _
                                                    chkInApproval6.CheckState, _
                                                    chkInApproval7.CheckState, _
                                                    chkInApproval8.CheckState)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS30, DS1, "USP_PFP23527_SEARCH_vS30", "VS30")
            vS30.ActiveSheet.RowCount = 0
            vS31.ActiveSheet.RowCount = 0
            vS30.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS30, DS1, "USP_PFP23527_SEARCH_vS30", "VS30")
        DATA_SEARCH_VS30 = True

        vS30.Enabled = True
    End Function

    Private Function DATA_SEARCH_VS31(Optional ByVal tmpMaterialCode As String = "") As Boolean
        DATA_SEARCH_VS31 = False

        vS31.Enabled = False
        DS1 = PrcDS("USP_PFP23527_SEARCH_vS31", cn, SdateEdate.text1, _
                                                    SdateEdate.text2, _
                                                    txt_cdDepartment.Code,
                                                    txt_CustomerInBoundMaterialName.Code, _
                                                    txt_cdLargeGroupMaterial.Data,
                                                    txt_cdSemiGroupMaterial.Data, _
                                                    txt_cdDetailGroupMaterial.Data, _
                                                    tmpMaterialCode, _
                                                    chk_CheckMarketType0.CheckState, _
                                                    chk_CheckMarketType1.CheckState, _
                                                    chkInApproval1.CheckState, _
                                                    chkInApproval2.CheckState, _
                                                    chkInApproval3.CheckState, _
                                                    chkInApproval4.CheckState, _
                                                    chkInApproval5.CheckState, _
                                                    chkInApproval6.CheckState, _
                                                    chkInApproval7.CheckState, _
                                                    chkInApproval8.CheckState)
        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS31, DS1, "USP_PFP23527_SEARCH_vS31", "vS31")
            vS31.ActiveSheet.RowCount = 0

            vS31.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS31, DS1, "USP_PFP23527_SEARCH_vS31", "vS31")
        DATA_SEARCH_VS31 = True

        vS31.Enabled = True
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
    Private Sub Vs10_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs10.CellClick

        Dim Xrow As Integer

        Xrow = e.Row

        W2351.DateInBoundMaterial = getData(Vs10, getColumIndex(Vs10, "KEY_DateInBoundMaterial"), Xrow)

        Call DATA_SEARCH_vS11(W2351.DateInBoundMaterial)

    End Sub
    Private Sub Vs20_CellClick(sender As Object, e As CellClickEventArgs) Handles vS20.CellClick

        Dim Xrow As Integer

        Xrow = e.Row

        W2351.SupplierCode = getData(vS20, getColumIndex(vS20, "KEY_CustomerNameSimplyMaterial"), Xrow)

        Call DATA_SEARCH_VS21(W2351.SupplierCode)

    End Sub
    Private Sub Vs30_CellClick(sender As Object, e As CellClickEventArgs) Handles vS30.CellClick

        Dim Xrow As Integer

        Xrow = e.Row

        W2351.MaterialCode = getData(vS30, getColumIndex(vS30, "KEY_MaterialName"), Xrow)

        Call DATA_SEARCH_VS31(W2351.MaterialCode)

    End Sub


    Private Sub vS10_GotFocus(sender As Object, e As EventArgs) Handles Vs10.GotFocus

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
    Private Sub vS20_LostFocus(sender As Object, e As EventArgs) Handles vS20.LostFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False)

    End Sub
    Private Sub vS10_LostFocus(sender As Object, e As EventArgs) Handles Vs10.LostFocus

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
        If ItemMain.SelectedIndex = 2 Then Call DATA_SEARCH_VS30()
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



    Private Sub Me_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Width > 30 Then
            ItemMain.ItemSize = New Size((Me.Width - 30) / 3, 25)
        End If
    End Sub

#End Region

End Class