Public Class PFP23572
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

        Me.KeyPreview = True

        Call FORM_INIT()
        Call DATA_INIT()


    End Sub
    Private Sub PFP23568_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

                    If getData(vS20, getColumIndex(vS20, "KEY_FactOrderNo"), vS20.ActiveSheet.ActiveRowIndex) = "" Then

                        If ISUD2356B.Link_ISUD2356B(1, W2356.CheckOutBoundMaterial, "0000000000", "000", "000000000", "000", Me.Name) = True Then
                            Call DATA_SEARCH_VS20()
                        End If
                    Else
                        If ISUD2356B.Link_ISUD2356B(11, W2356.CheckOutBoundMaterial, getData(vS20, getColumIndex(vS20, "KEY_DateOutBoundMaterial"), vS20.ActiveSheet.ActiveRowIndex),
                                                                             getData(vS20, getColumIndex(vS20, "KEY_SeqOutBoundMaterial"), vS20.ActiveSheet.ActiveRowIndex),
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
                                                    getData(vS10, getColumIndex(vS10, "KEY_FactOrderNo"), vS10.ActiveSheet.ActiveRowIndex),
                                                    getData(vS10, getColumIndex(vS10, "KEY_FactOrderSeq"), vS10.ActiveSheet.ActiveRowIndex), Me.Name) = True Then


                        Call DATA_SEARCH_VS10()
                    End If

                Case vS20.Focused
                    Call CheckOutBoundMaterial()

                    If ISUD2356B.Link_ISUD2356B(2, getData(vS20, getColumIndex(vS20, "KEY_CheckOutBoundMaterial"), vS20.ActiveSheet.ActiveRowIndex),
                                                    getData(vS20, getColumIndex(vS20, "KEY_DateOutBoundMaterial"), vS20.ActiveSheet.ActiveRowIndex),
                                                    getData(vS20, getColumIndex(vS20, "KEY_SeqOutBoundMaterial"), vS20.ActiveSheet.ActiveRowIndex),
                                                    getData(vS20, getColumIndex(vS20, "KEY_FactOrderNo"), vS20.ActiveSheet.ActiveRowIndex),
                                                    getData(vS20, getColumIndex(vS20, "KEY_FactOrderSeq"), vS20.ActiveSheet.ActiveRowIndex), Me.Name) = True Then


                        Call DATA_SEARCH_VS20()
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
                                                    getData(vS20, getColumIndex(vS20, "KEY_FactOrderNo"), vS20.ActiveSheet.ActiveRowIndex),
                                                    getData(vS20, getColumIndex(vS20, "KEY_FactOrderSeq"), vS20.ActiveSheet.ActiveRowIndex), Me.Name) = True Then


                        Call DATA_SEARCH_VS20()
                    End If

                End If


        End Select

    End Sub

    Private Sub MAIN_JOB04()
        Select Case True
            Case vS10.Focused
                If ISUD2356B.Link_ISUD2356B(3, getData(vS10, getColumIndex(vS10, "KEY_CheckOutBoundMaterial"), vS10.ActiveSheet.ActiveRowIndex),
                                     getData(vS10, getColumIndex(vS10, "KEY_DateOutBoundMaterial"), vS10.ActiveSheet.ActiveRowIndex),
                                     getData(vS10, getColumIndex(vS10, "KEY_SeqOutBoundMaterial"), vS10.ActiveSheet.ActiveRowIndex),
                                     getData(vS10, getColumIndex(vS10, "KEY_FactOrderNo"), vS10.ActiveSheet.ActiveRowIndex),
                                     getData(vS10, getColumIndex(vS10, "KEY_FactOrderSeq"), vS10.ActiveSheet.ActiveRowIndex), Me.Name) = True Then


                    Call DATA_SEARCH_VS10()
                End If
            Case vS20.Focused
                Call CheckOutBoundMaterial()

                If ISUD2356B.Link_ISUD2356B(4, getData(vS20, getColumIndex(vS20, "KEY_CheckOutBoundMaterial"), vS20.ActiveSheet.ActiveRowIndex),
                                                getData(vS20, getColumIndex(vS20, "KEY_DateOutBoundMaterial"), vS20.ActiveSheet.ActiveRowIndex),
                                                getData(vS20, getColumIndex(vS20, "KEY_SeqOutBoundMaterial"), vS20.ActiveSheet.ActiveRowIndex),
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

        Call CheckOutBoundMaterial()


        DS1 = PrcDS("USP_PFP23568_SEARCH_VS10", cn, SdateEdate.text1,
                                                    SdateEdate.text2,
                                                    txt_cdDepartment.Code,
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
                                                    "1",
                                                    "1",
                                                    "1",
                                                    "1",
                                                    "1",
                                                    "1",
                                                    "1",
                                                    "1")


        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS10, DS1, "USP_PFP23568_SEARCH_vS10", "vS10")

            vS10.ActiveSheet.RowCount = 0
            vS10.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS10, DS1, "USP_PFP23568_SEARCH_vS10", "vS10")
        DATA_SEARCH_VS10 = True

        vS10.Enabled = True
    End Function

    Private Function DATA_SEARCH_VS20(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS20 = False

        vS20.Enabled = False

        DS1 = PrcDS("USP_PFP23568_SEARCH_VS20", cn, SdateEdate.text1,
                                                    SdateEdate.text2,
                                                    txt_cdDepartment.Code,
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
                                                    opt_SEL5.CheckState)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS20, DS1, "USP_PFP23568_SEARCH_VS20", "VS20")

            vS20.ActiveSheet.RowCount = 0
            vS20.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS20, DS1, "USP_PFP23568_SEARCH_VS20", "VS20")
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

    Private Sub Me_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Width > 30 Then
            ItemMain.ItemSize = New Size((Me.Width - 30) / 2, 25)
        End If
    End Sub

#End Region

End Class