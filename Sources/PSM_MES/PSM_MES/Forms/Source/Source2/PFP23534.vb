Public Class PFP23534
#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Private wGCODE As String
    Protected prg As E_PRG

    Private W2356 As T2356_AREA
    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

        Me.KeyPreview = True

        Call FORM_INIT()
        Call DATA_INIT()


    End Sub
    Private Sub PFP23534_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
        SdateEdate.text1 = System_Date_Add(-1)
        SdateEdate.text2 = System_Date_8()
        GPNAL.Visible = False

    End Sub
#End Region

#Region "Function"
    Private Sub MAIN_JOB01()

    End Sub

    Private Sub MAIN_JOB02()

    End Sub

    Private Sub MAIN_JOB03()

    End Sub

    Private Sub MAIN_JOB04()

    End Sub

    Private Sub MAIN_JOB05()

    End Sub

#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS10(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS10 = False

        vS10.Enabled = False

        Call CheckOutBoundMaterial()

        DS1 = PrcDS("USP_PFP23534_SEARCH_vS10", cn, SdateEdate.text1,
                                                    SdateEdate.text2,
                                                    txt_cdDepartment.Code,
                                                    txt_cdLargeGroupMaterialName.Data,
                                                    txt_cdSemiGroupMaterialName.Data,
                                                    "*" & txt_MaterialName.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS10, DS1, "USP_PFP23534_SEARCH_vS10", "vS10")

            vS10.ActiveSheet.RowCount = 0
            vS10.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS10, DS1, "USP_PFP23534_SEARCH_vS10", "vS10")
        DATA_SEARCH_VS10 = True

        vS10.Enabled = True
    End Function

    Private Function DATA_SEARCH_VS20(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS20 = False

        vS20.Enabled = False

        DS1 = PrcDS("USP_PFP23534_SEARCH_VS20", cn, SdateEdate.text1, _
                                                    SdateEdate.text2, _
                                                    txt_InvoiceNo.Data,
                                                    txt_CustomerInBoundMaterialName.Data, _
                                                    txt_cdDepartment.Code,
                                                    txt_cdLargeGroupMaterialName.Data,
                                                    txt_cdSemiGroupMaterialName.Data, _
                                                    txt_cdDetailGroupMaterialName.Data,
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
            SPR_PRO_NEW(vS20, DS1, "USP_PFP23534_SEARCH_VS20", "VS20")

            vS20.ActiveSheet.RowCount = 0
            vS20.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS20, DS1, "USP_PFP23534_SEARCH_VS20", "VS20")
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
    End Sub


    Private Sub Me_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Width > 30 Then
            ItemMain.ItemSize = New Size((Me.Width - 30) / 2, 25)
        End If
    End Sub

    Private Sub ItemMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ItemMain.SelectedIndexChanged
        If ItemMain.SelectedIndex = 0 Then
            GPNAL.Visible = False
        Else
            GPNAL.Visible = True
        End If
    End Sub
    Private Sub vS10_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS10.CellDoubleClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            txt_MaterialName.Data = getData(vS10, getColumIndex(vS10, "MaterialName"), e.Row)
            Call DATA_SEARCH_VS20()
        End If
    End Sub

#End Region


End Class