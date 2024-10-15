Public Class PFP23616
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
    Private Sub PFP23616_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

        txt_cdDepartment.Data = "Material"
        txt_cdDepartment.Code = "007"
        txt_cdDepartment.Enabled = Not True

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

        DS1 = PrcDS("USP_PFP23616_SEARCH_vS10", cn, SdateEdate.text1,
                                                    SdateEdate.text2,
                                                    txt_cdSeason.Code,
                                                    txt_CustomerCode.Code,
                                                    txt_cdDepartment.Code,
                                                    txt_cdLargeGroupMaterial.Data,
                                                    txt_cdSemiGroupMaterial.Data,
                                                    "*" & txt_MaterialName.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS10, DS1, "USP_PFP23616_SEARCH_vS10", "vS10")

            vS10.ActiveSheet.RowCount = 0
            vS10.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS10, DS1, "USP_PFP23616_SEARCH_vS10", "vS10")
        DATA_SEARCH_VS10 = True

        vS10.Enabled = True
    End Function

    Private Function DATA_SEARCH_VS20(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS20 = False

        vS20.Enabled = False

        Dim Materialcode As String
        Dim ColorName As String
        Dim cdSeason As String
        Dim CustomerCode As String


        DS1 = PrcDS("USP_PFP23616_SEARCH_vS20", cn, SdateEdate.text1,
                                                    SdateEdate.text2,
                                                    txt_cdSeason.Code,
                                                    txt_CustomerCode.Code,
                                                    txt_cdDepartment.Code,
                                                    txt_cdLargeGroupMaterial.Data,
                                                    txt_cdSemiGroupMaterial.Data,
                                                    "*" & txt_MaterialName.Data)


        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS20, DS1, "USP_PFP23616_SEARCH_vS20", "VS20")

            vS20.ActiveSheet.RowCount = 0
            vS20.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS20, DS1, "USP_PFP23616_SEARCH_vS20", "VS20")
        DATA_SEARCH_VS20 = True

        vS20.Enabled = True
    End Function
    Private Function DATA_SEARCH_VS30(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS30 = False

        vS30.Enabled = False

        Dim Materialcode As String
        Dim ColorName As String
        Dim cdSeason As String
        Dim CustomerCode As String


        DS1 = PrcDS("USP_PFP23616_SEARCH_vS30", cn, SdateEdate.text1,
                                                    SdateEdate.text2,
                                                    txt_cdSeason.Code,
                                                    txt_CustomerCode.Code,
                                                    txt_cdDepartment.Code,
                                                    txt_cdLargeGroupMaterial.Data,
                                                    txt_cdSemiGroupMaterial.Data,
                                                    "*" & txt_MaterialName.Data)


        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS20, DS1, "USP_PFP23616_SEARCH_vS30", "vS30")

            vS30.ActiveSheet.RowCount = 0
            vS30.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS30, DS1, "USP_PFP23616_SEARCH_vS30", "vS30")
        DATA_SEARCH_VS30 = True

        vS30.Enabled = True
    End Function
    Private Function DATA_SEARCH_VS40(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS40 = False

        vS40.Enabled = False

        Dim Materialcode As String
        Dim ColorName As String
        Dim cdSeason As String
        Dim CustomerCode As String


        DS1 = PrcDS("USP_PFP23616_SEARCH_vS40", cn, SdateEdate.text1,
                                                    SdateEdate.text2,
                                                    txt_cdSeason.Code,
                                                    txt_CustomerCode.Code,
                                                    txt_cdDepartment.Code,
                                                    txt_cdLargeGroupMaterial.Data,
                                                    txt_cdSemiGroupMaterial.Data,
                                                    "*" & txt_MaterialName.Data)


        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS20, DS1, "USP_PFP23616_SEARCH_vS40", "vS40")

            vS40.ActiveSheet.RowCount = 0
            vS40.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS40, DS1, "USP_PFP23616_SEARCH_vS40", "vS40")
        DATA_SEARCH_VS40 = True

        vS40.Enabled = True
    End Function
    Private Function DATA_SEARCH_VS50(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS50 = False

        vS50.Enabled = False

        Dim Materialcode As String
        Dim ColorName As String
        Dim cdSeason As String
        Dim CustomerCode As String


        DS1 = PrcDS("USP_PFP23616_SEARCH_VS50", cn, SdateEdate.text1,
                                                    SdateEdate.text2,
                                                    txt_cdSeason.Code,
                                                    txt_CustomerCode.Code,
                                                    txt_cdDepartment.Code,
                                                    txt_cdLargeGroupMaterial.Data,
                                                    txt_cdSemiGroupMaterial.Data,
                                                    "*" & txt_MaterialName.Data)


        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS20, DS1, "USP_PFP23616_SEARCH_VS50", "VS50")

            vS50.ActiveSheet.RowCount = 0
            vS50.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS50, DS1, "USP_PFP23616_SEARCH_VS50", "VS50")
        DATA_SEARCH_VS50 = True

        vS50.Enabled = True
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
        If ItemMain.SelectedIndex = 3 Then Call DATA_SEARCH_VS40()
        If ItemMain.SelectedIndex = 4 Then Call DATA_SEARCH_VS50()
    End Sub

    Private Sub ptc_Main_DoubleClick(sender As Object, e As EventArgs) Handles ItemMain.DoubleClick
        If ItemMain.SelectedIndex = -1 Then Exit Sub


        Select Case ItemMain.SelectedIndex
            Case 0 : Call DATA_SEARCH_VS10()
            Case 1 : Call DATA_SEARCH_VS20()
            Case 2 : Call DATA_SEARCH_VS30()
            Case 3 : Call DATA_SEARCH_VS40()
            Case 4 : Call DATA_SEARCH_VS50()
        End Select

    End Sub

    Private Sub Me_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Width > 30 Then
            ItemMain.ItemSize = New Size((Me.Width - 30) / 5, 25)
        End If
    End Sub

    Private Sub ItemMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ItemMain.SelectedIndexChanged
        If ItemMain.SelectedIndex = 0 Then
            GPNAL.Visible = False
        Else
            GPNAL.Visible = True
        End If
    End Sub
 

#End Region


End Class