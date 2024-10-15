Public Class PFP34281

#Region "Variable"
    Private Dsu01 As Long
    Private wGCODE As String
    Protected prg As E_PRG

    Private W2351 As T2351_AREA
    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

        Call Cms_additem(Cms_1, _
                        "PAYABLE REQUEST - " & WordConv("AUTO") & "(F5)",
                        "PAYABLE REQUEST - " & WordConv("INPUT") & "(F6)")

        Vs10.ContextMenuStrip = Cms_1

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

        Call Cms_additem(Cms_2, _
                        "PAYABLE REQUEST - " & WordConv("INPUT") & "(F5)", _
                        "PAYABLE REQUEST - " & WordConv("SEARCH") & "(F6)", _
                        "PAYABLE REQUEST - " & WordConv("UPDATE") & "(F7)", _
                        "PAYABLE REQUEST - " & WordConv("DELETE") & "(F8)",
                        "-",
                        "PAYABLE REQUEST - " & WordConv("UN-COMPLETE") & "(F9)",
                         "-",
                        "PAYABLE REQUEST - " & WordConv("CLEAR ADVANCED") & "(F10)")

        Vs20.ContextMenuStrip = Cms_2

        Me.KeyPreview = True

        Call FORM_INIT()
        Call DATA_INIT()

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

        txt_InchargeInsert.Data = Pub.NAM
        txt_InchargeInsert.Code = Pub.SAW
        txt_InchargeInsert.Enabled = False

    End Sub
#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS10(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS10 = False

        Vs10.Enabled = False
        If chk_PayType2.Checked = True Then
            Vs10.ActiveSheet.RowCount = 0
            Vs11.ActiveSheet.RowCount = 0
        End If
        If chk_PayType0.Checked = True Then
            Vs11.ActiveSheet.RowCount = 0
            DS1 = PrcDS("USP_PFP34281_SEARCH_VS10_F1", cn, SdateEdate.text1,
                                                        SdateEdate.text2,
                                                        txt_cdDepartment.Code,
                                                        txt_FactOrderNo.Data,
                                                        txt_SupplierCode.Code,
                                                        txt_cdSite.Code, _
                                                        txt_CustomerCode.Code, _
                                                        chk_CheckMarketType0.CheckState,
                                                        chk_CheckMarketType1.CheckState,
                                                        Pub.SAW)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs10, DS1, "USP_PFP34281_SEARCH_VS10_F1", "vS10")

                Vs10.ActiveSheet.RowCount = 0
                Vs10.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs10, DS1, "USP_PFP34281_SEARCH_VS10_F1", "vS10")
            DATA_SEARCH_VS10 = True

            Vs10.Enabled = True
        End If

        If chk_PayType1.Checked = True Then
            Vs11.ActiveSheet.RowCount = 0
            DS1 = PrcDS("USP_PFP34281_SEARCH_VS10_02_F1", cn, SdateEdate.text1,
                                                       SdateEdate.text2,
                                                       txt_cdDepartment.Code,
                                                       txt_FactOrderNo.Data,
                                                       txt_SupplierCode.Code,
                                                       txt_cdSite.Code, _
                                                       txt_CustomerCode.Code, _
                                                       chk_CheckMarketType0.CheckState,
                                                       chk_CheckMarketType1.CheckState,
                                                       Pub.SAW)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs10, DS1, "USP_PFP34281_SEARCH_VS10_02_F1", "vS10")

                Vs10.ActiveSheet.RowCount = 0
                Vs10.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs10, DS1, "USP_PFP34281_SEARCH_VS10_02_F1", "vS10")
            DATA_SEARCH_VS10 = True

            Vs10.Enabled = True

        End If

    End Function
    Private Function DATA_SEARCH_VS20(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS20 = False

        Vs20.Enabled = False
        Vs21.ActiveSheet.RowCount = 0

        DS1 = PrcDS("USP_PFP34281_SEARCH_Vs20_F1", cn, SdateEdate.text1, _
                                                    SdateEdate.text2, _
                                                    txt_cdDepartment.Code,
                                                    txt_FactOrderNo.Data,
                                                    txt_SupplierCode.Code, _
                                                    txt_cdSite.Code, _
                                                    txt_CustomerCode.Code, _
                                                    chk_CheckMarketType0.CheckState, _
                                                    chk_CheckMarketType1.CheckState,
                                                    Pub.SAW)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs20, DS1, "USP_PFP34281_SEARCH_Vs20_F1", "vS20")
            Vs20.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs20, DS1, "USP_PFP34281_SEARCH_Vs20_F1", "vS20")
        DATA_SEARCH_VS20 = True

        Vs20.Enabled = True
    End Function

    Private Function DATA_SEARCH_VS21(PayableNo As String) As Boolean

        DATA_SEARCH_VS21 = False

        Vs20.Enabled = False

        DS1 = PrcDS("USP_PFP34281_SEARCH_VS21", cn, PayableNo)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs21, DS1, "USP_PFP34281_SEARCH_VS21", "vS21")
            Vs20.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs21, DS1, "USP_PFP34281_SEARCH_VS21", "vS21")
        DATA_SEARCH_VS21 = True

        Vs20.Enabled = True
    End Function

    Private Function DATA_SEARCH_VS11(FactOrderNo As String) As Boolean

       
        DATA_SEARCH_VS11 = False

        Vs10.Enabled = False
        DS1 = PrcDS("USP_PFP34281_SEARCH_VS11", cn, FactOrderNo)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs11, DS1, "USP_PFP34281_SEARCH_VS11", "vS11")
            Vs10.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs11, DS1, "USP_PFP34281_SEARCH_VS11", "vS11")

        DATA_SEARCH_VS11 = True

        Vs10.Enabled = True

    End Function

    Private Function DATA_SEARCH_VS11_01(MaterialInBoundNo As String, MaterialInBoundSeq As String) As Boolean

        DATA_SEARCH_VS11_01 = False

        Vs10.Enabled = False

        DS1 = PrcDS("USP_PFP34281_SEARCH_VS11_01", cn, MaterialInBoundNo, MaterialInBoundSeq)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs11, DS1, "USP_PFP34281_SEARCH_VS11_01", "vS11")
            Vs10.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs11, DS1, "USP_PFP34281_SEARCH_VS11_01", "vS11")

        DATA_SEARCH_VS11_01 = True

        Vs10.Enabled = True


    End Function

    Private Function LINE_MOVE_DISPLAY01() As Boolean
        LINE_MOVE_DISPLAY01 = False

    End Function
    Private Function CustomerPurchasing_CHK() As String
        CustomerPurchasing_CHK = "1"
        Return CustomerPurchasing_CHK
    End Function

#End Region

#Region "Function"
    Private Sub MAIN_JOB01_AUTO()

        Dim CheckTypePayable As Integer

        Try

            If chk_PayType0.Checked = True Then
                CheckTypePayable = 1
            ElseIf chk_PayType1.Checked = True Then
                CheckTypePayable = 2
            ElseIf chk_PayType2.Checked = True Then
                CheckTypePayable = 3

                If ISUD3428B.Link_ISUD3428B(1, "000000000", CheckTypePayable, Me.Name) = False Then Exit Sub
                ItemMain.SelectedIndex = 1

                Exit Sub
            End If

            hlp0000SeVa = ""
            hlp0000SeVaTt = ""

            Dim i As Integer
            Dim CheckValue As Boolean = False

            For i = 0 To Vs10.ActiveSheet.RowCount - 1
                If getDataM(Vs10, getColumIndex(Vs10, "DCHK"), i) = "1" Then
                    CheckValue = True
                    Select Case True
                        Case CheckTypePayable = "1"
                            hlp0000SeVa &= "''" & getData(Vs10, getColumIndex(Vs10, "KEY_FactOrderNo"), i) & "''"
                            hlp0000SeVa &= ","
                        Case CheckTypePayable = "2"
                            hlp0000SeVa &= "''" & getData(Vs10, getColumIndex(Vs10, "KEY_MaterialInBoundNo"), i) & "!"
                            hlp0000SeVa &= getData(Vs10, getColumIndex(Vs10, "KEY_MaterialInBoundSeq"), i) & "''" & ","
                    End Select

                End If
            Next

            hlp0000SeVa = Strings.Left(hlp0000SeVa, Len(hlp0000SeVa) - 1)
            hlp0000SeVaTt = hlp0000SeVa
           
            If ISUD3428A.Link_ISUD3428A_AUTO(1, "000000000", CheckTypePayable, hlp0000SeVaTt, Me.Name) = False Then Exit Sub
            ItemMain.SelectedIndex = 1

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB01!", vbCritical)
        End Try

    End Sub

    Private Sub MAIN_JOB02_AUTO()
        Dim CheckTypePayable As Integer

        Try

            If chk_PayType0.Checked = True Then
                CheckTypePayable = 1
            ElseIf chk_PayType1.Checked = True Then
                CheckTypePayable = 2
            ElseIf chk_PayType2.Checked = True Then
                CheckTypePayable = 3
            End If

            If ISUD3428A.Link_ISUD3428A(1, "000000000", CheckTypePayable, Me.Name) = False Then Exit Sub

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB01!", vbCritical)
        End Try

    End Sub

    Private Sub MAIN_JOB01()
        If Vs10.Focused Then
            Call MAIN_JOB01_AUTO()
            Exit Sub
        End If

        Dim CheckTypePayable As Integer

        Try

            If chk_PayType0.Checked = True Then
                CheckTypePayable = 1
            ElseIf chk_PayType1.Checked = True Then
                CheckTypePayable = 2
            ElseIf chk_PayType2.Checked = True Then
                CheckTypePayable = 3

                If ISUD3428B.Link_ISUD3428B(1, "000000000", CheckTypePayable, Me.Name) = False Then Exit Sub
                ItemMain.SelectedIndex = 1

            End If

            If ISUD3428A.Link_ISUD3428A(1, "000000000", CheckTypePayable, Me.Name) = False Then Exit Sub

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB01!", vbCritical)
        End Try

    End Sub

    Private Sub MAIN_JOB02()
        If Vs10.Focused Then
            Call MAIN_JOB02_AUTO()
            Exit Sub
        End If

        Dim CheckTypePayable As Integer

        Try

            If chk_PayType0.Checked = True Then
                CheckTypePayable = 1
            ElseIf chk_PayType1.Checked = True Then
                CheckTypePayable = 2
            ElseIf chk_PayType2.Checked = True Then
                CheckTypePayable = 3
            End If
            Select Case True

                Case Vs20.Focused

                    If getData(Vs20, getColumIndex(Vs20, "KEY_PayableNo"), Vs20.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

                    If READ_PFK3428(getData(Vs20, getColumIndex(Vs20, "KEY_PayableNo"), Vs20.ActiveSheet.ActiveRowIndex)) Then
                        If D3428.CheckProcessType <> "3" Then
                            If ISUD3428A.Link_ISUD3428A(2, getData(Vs20, getColumIndex(Vs20, "KEY_PayableNo"), Vs20.ActiveSheet.ActiveRowIndex), CheckTypePayable, Me.Name) = False Then Exit Sub
                        Else
                            If ISUD3428B.Link_ISUD3428B(2, getData(Vs20, getColumIndex(Vs20, "KEY_PayableNo"), Vs20.ActiveSheet.ActiveRowIndex), CheckTypePayable, Me.Name) = False Then Exit Sub

                        End If
                    End If

            End Select

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB02!", vbCritical)
        End Try

    End Sub

    Private Sub MAIN_JOB03()

        Dim CheckTypePayable As Integer
        Try

            If chk_PayType0.Checked = True Then
                CheckTypePayable = 1
            ElseIf chk_PayType1.Checked = True Then
                CheckTypePayable = 2
            ElseIf chk_PayType2.Checked = True Then
                CheckTypePayable = 3
            End If

            Select Case True

                Case Vs20.Focused
                    If READ_PFK3428(getData(Vs20, getColumIndex(Vs20, "KEY_PayableNo"), Vs20.ActiveSheet.ActiveRowIndex)) Then
                        If D3428.CheckProcessType <> "3" Then
                            If ISUD3428A.Link_ISUD3428A(3, getData(Vs20, getColumIndex(Vs20, "KEY_PayableNo"), Vs20.ActiveSheet.ActiveRowIndex), CheckTypePayable, Me.Name) = False Then Exit Sub
                            Call LINE_MOVE_DISPLAY01()
                        Else
                            If ISUD3428B.Link_ISUD3428B(3, getData(Vs20, getColumIndex(Vs20, "KEY_PayableNo"), Vs20.ActiveSheet.ActiveRowIndex), CheckTypePayable, Me.Name) = False Then Exit Sub
                            Call LINE_MOVE_DISPLAY01()
                        End If
                    End If

            End Select

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB03!", vbCritical)
        End Try
    End Sub

    Private Sub MAIN_JOB04()

        Dim CheckTypePayable As Integer
        Try

            If chk_PayType0.Checked = True Then
                CheckTypePayable = 1
            ElseIf chk_PayType1.Checked = True Then
                CheckTypePayable = 2
            ElseIf chk_PayType2.Checked = True Then
                CheckTypePayable = 3
            End If

            Select Case True

                Case Vs20.Focused

                    If READ_PFK3428(getData(Vs20, getColumIndex(Vs20, "KEY_PayableNo"), Vs20.ActiveSheet.ActiveRowIndex)) Then
                        If D3428.CheckProcessType <> "3" Then
                            If ISUD3428A.Link_ISUD3428A(4, getData(Vs20, getColumIndex(Vs20, "KEY_PayableNo"), Vs20.ActiveSheet.ActiveRowIndex), CheckTypePayable, Me.Name) = False Then Exit Sub
                            Call LINE_MOVE_DISPLAY01()
                        Else
                            If ISUD3428B.Link_ISUD3428B(4, getData(Vs20, getColumIndex(Vs20, "KEY_PayableNo"), Vs20.ActiveSheet.ActiveRowIndex), CheckTypePayable, Me.Name) = False Then Exit Sub
                            Call LINE_MOVE_DISPLAY01()
                        End If
                    End If
            End Select

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB04!", vbCritical)
        End Try
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
                PayableNo = getData(Vs20, getColumIndex(Vs20, "PayableNo"), Vs20.ActiveSheet.ActiveRowIndex)

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

    Private Sub MAIN_JOB07()

        Dim CheckTypePayable As Integer
        Try


            Select Case True

                Case Vs20.Focused
                    If READ_PFK3428(getData(Vs20, getColumIndex(Vs20, "KEY_PayableNo"), Vs20.ActiveSheet.ActiveRowIndex)) Then
                        If D3428.CheckProcessType = "1" Then
                            If ISUD3428A.Link_ISUD3428A(5, getData(Vs20, getColumIndex(Vs20, "KEY_PayableNo"), Vs20.ActiveSheet.ActiveRowIndex), CheckTypePayable, Me.Name) = False Then Exit Sub
                            Call LINE_MOVE_DISPLAY01()
                        ElseIf D3428.CheckProcessType = "6" And D3428.CheckMaterialType = "1" Then
                            If ISUD3428B.Link_ISUD3428B(5, getData(Vs20, getColumIndex(Vs20, "KEY_PayableNo"), Vs20.ActiveSheet.ActiveRowIndex), CheckTypePayable, Me.Name) = False Then Exit Sub
                            Call LINE_MOVE_DISPLAY01()
                        End If
                    End If

            End Select

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB03!", vbCritical)
        End Try
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

    End Sub
    Private Sub vS10_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs10.CellClick
        If e.ColumnHeader = True Then Exit Sub
        If e.Column = getColumIndex(Vs10, "DCHK") Then Exit Sub

        Vs10.ActiveSheet.ActiveColumnIndex = e.Column
        Vs10.ActiveSheet.ActiveRowIndex = e.Row
        Vs10.ActiveSheet.AddSelection(e.Row, e.Column, 1, 1)
    End Sub

    Private Sub vS10_GotFocus(sender As Object, e As EventArgs) Handles Vs10.GotFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False)

        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False

    End Sub
    Private Sub vS10_LostFocus(sender As Object, e As EventArgs) Handles Vs10.LostFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False)

    End Sub

    Private Sub txt_GNAME_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Enter : cmd_SEARCH.Focus()
        End Select
    End Sub

    Private Sub vS20_GotFocus(sender As Object, e As EventArgs) Handles Vs20.GotFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False

    End Sub

    Private Sub vS20_LostFocus(sender As Object, e As EventArgs) Handles Vs20.LostFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

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

        ElseIf Cms_2.Items(7).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB07()
        End If

    End Sub


    Private Sub Vs20_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs20.CellDoubleClick

        Dim PayableNo As String
        Try

            If getData(Vs20, getColumIndex(Vs20, "KEY_PayableNo"), Vs20.ActiveSheet.ActiveRowIndex) <> "" Then
                PayableNo = getData(Vs20, getColumIndex(Vs20, "KEY_PayableNo"), Vs20.ActiveSheet.ActiveRowIndex)
                DATA_SEARCH_VS21(PayableNo)
            End If

        Catch ex As Exception

            MsgBoxP("Error in Vs20_CellDoubleClick!", vbCritical)

        End Try

    End Sub

    Private Sub Vs10_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs10.CellDoubleClick
        If e.ColumnHeader = True Then Exit Sub
        If e.Column = getColumIndex(Vs10, "DCHK") Then Exit Sub


        Dim FactOrderNo As String
        Dim MaterialInBoundNo As String
        Dim MaterialInBoundSeq As String

        Try

            If chk_PayType0.Checked = True Then

                If getData(Vs10, getColumIndex(Vs10, "KEY_FactOrderNo"), Vs10.ActiveSheet.ActiveRowIndex) <> "" Then
                    FactOrderNo = getData(Vs10, getColumIndex(Vs10, "KEY_FactOrderNo"), Vs10.ActiveSheet.ActiveRowIndex)
                    DATA_SEARCH_VS11(FactOrderNo)
                End If

            End If

            If chk_PayType1.Checked = True Then

                If getData(Vs10, getColumIndex(Vs10, "Key_MaterialInBoundNo"), Vs10.ActiveSheet.ActiveRowIndex) <> "" Then
                    MaterialInBoundNo = getData(Vs10, getColumIndex(Vs10, "Key_MaterialInBoundNo"), Vs10.ActiveSheet.ActiveRowIndex)
                    MaterialInBoundSeq = getData(Vs10, getColumIndex(Vs10, "Key_MaterialInBoundSeq"), Vs10.ActiveSheet.ActiveRowIndex)
                    DATA_SEARCH_VS11_01(MaterialInBoundNo, MaterialInBoundSeq)
                End If

            End If

        Catch ex As Exception

            MsgBoxP("Error in Vs20_CellDoubleClick!", vbCritical)

        End Try


    End Sub

    Private Sub PFP17811_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub

    Private Sub Me_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Width > 30 Then
            ItemMain.ItemSize = New Size((Me.Width - 30) / ItemMain.TabCount, 25)
        End If
    End Sub
   

#End Region

    Private Sub Vs20_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs20.CellClick

    End Sub
End Class