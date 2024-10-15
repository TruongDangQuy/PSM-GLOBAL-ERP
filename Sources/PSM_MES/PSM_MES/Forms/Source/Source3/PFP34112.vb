
Public Class PFP34112
#Region "Variable"
    Private Dsu01 As Long
    Private wGCODE As String
    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim xISUD3411B As String = ISUD3411B.Text
        Dim xISUD3411P As String = ISUD3411P.Text

        Call Cms_additem(Cms_1,
                        xISUD3411B & " - " & WordConv("INPUT") & "(F5)",
                        xISUD3411B & " - " & WordConv("SEARCH") & "(F6)",
                        xISUD3411B & " - " & WordConv("UPDATE") & "(F7)",
                        xISUD3411B & " - " & WordConv("DELETE") & "(F8)",
                        "-",
                        xISUD3411P & " - " & WordConv("ONE"),
                        xISUD3411P & " - " & WordConv("ALL"),
                        xISUD3411P & " - " & WordConv("UPDATE AFTER"),
                         "-",
                        xISUD3411B & " - " & WordConv("RETURN PURCHASING"))

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

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
        ssp_WHERE.txt_SdateEdate.text1 = System_Date_Add(-1)
        ssp_WHERE.txt_SdateEdate.text2 = System_Date_8()

        If READ_PFK7411(Pub.SAW) Then
            ssp_WHERE.txt_Incharge.Data = D7411.Name
            ssp_WHERE.txt_Incharge.Code = D7411.IDNO
        End If

    End Sub
#End Region

#Region "Function"
   Private Sub MAIN_JOB01()
        If ISUD3411A.Link_ISUD3411A(1, "000000000", Me.Name) = False Then Exit Sub

        Call DATA_SEARCH01()
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

        Call DATA_SEARCH01() : Exit Sub

        If LINE_MOVE_DISPLAY01() = False Then
            SPR_CLEAR(Vs1, Vs1.ActiveSheet.ActiveRowIndex, 0, Vs1.ActiveSheet.ActiveRowIndex, Vs1.ActiveSheet.ColumnCount - 1)
            setData(Vs1, getColumIndex(Vs1, "DateAccept"), Vs1.ActiveSheet.ActiveRowIndex, "[DELETED]", Color.Red)
        End If
    End Sub

    Private Sub MAIN_JOB04()
        If getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        Dim PurchasingOrderNo As String

        PurchasingOrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderNo"), Vs1.ActiveSheet.ActiveRowIndex)

        If ISUD3411A.Link_ISUD3411A(4, PurchasingOrderNo, Me.Name) = False Then Exit Sub

        Call DATA_SEARCH01() : Exit Sub

        If LINE_MOVE_DISPLAY01() = False Then
            SPR_CLEAR(Vs1, Vs1.ActiveSheet.ActiveRowIndex, 0, Vs1.ActiveSheet.ActiveRowIndex, Vs1.ActiveSheet.ColumnCount - 1)
            setData(Vs1, getColumIndex(Vs1, "DateAccept"), Vs1.ActiveSheet.ActiveRowIndex, "[DELETED]", Color.Red)
        End If

    End Sub



    Private Sub MAIN_JOB05()
        If getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        Dim PurchasingOrderNo As String
        PurchasingOrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderNo"), Vs1.ActiveSheet.ActiveRowIndex)


        If ISUD3411P.Link_ISUD3411P(3, PurchasingOrderNo,
                                    getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderSeq"), Vs1.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub

        'If ssp_WHERE.opt_G1.Checked = False Then Exit Sub

        Call DATA_SEARCH01() : Exit Sub

        If LINE_MOVE_DISPLAY01() = False Then
            SPR_CLEAR(Vs1, Vs1.ActiveSheet.ActiveRowIndex, 0, Vs1.ActiveSheet.ActiveRowIndex, Vs1.ActiveSheet.ColumnCount - 1)
            setData(Vs1, getColumIndex(Vs1, "DateAccept"), Vs1.ActiveSheet.ActiveRowIndex, "[DELETED]", Color.Red)
        End If

    End Sub

    Private Sub MAIN_JOB06()
        If getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        Dim PurchasingOrderNo As String
        PurchasingOrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderNo"), Vs1.ActiveSheet.ActiveRowIndex)


        If ISUD3411P.Link_ISUD3411P(4, PurchasingOrderNo,
                                    getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderSeq"), Vs1.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub

        Call DATA_SEARCH01()

    End Sub


    Private Sub MAIN_JOB07()
        If getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        Dim PurchasingOrderNo As String

        PurchasingOrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderNo"), Vs1.ActiveSheet.ActiveRowIndex)

        If ISUD3411A.Link_ISUD3411A(5, PurchasingOrderNo, Me.Name) = False Then Exit Sub

        Call DATA_SEARCH01() : Exit Sub

        If LINE_MOVE_DISPLAY01() = False Then
            SPR_CLEAR(Vs1, Vs1.ActiveSheet.ActiveRowIndex, 0, Vs1.ActiveSheet.ActiveRowIndex, Vs1.ActiveSheet.ColumnCount - 1)
            setData(Vs1, getColumIndex(Vs1, "DateAccept"), Vs1.ActiveSheet.ActiveRowIndex, "[DELETED]", Color.Red)
        End If
    End Sub

    Private Sub MAIN_JOB09()
        If getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        Dim PurchasingOrderNo As String
        Dim PurchasingOrderNo_New As String

        PurchasingOrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_PurchasingOrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
        PurchasingOrderNo_New = PurchasingOrderNo.Replace("PO", "RP")

        If MsgBoxPPW("Please type the password to make return po!", const_pwPO) = False Then Exit Sub

        If READ_PFK3411(PurchasingOrderNo_New) Then MsgBoxP("Already return!") : Exit Sub

        If PrcExe("USP_PFK3411_APPROVAL_PFK3411_RETURN_PO", cn, PurchasingOrderNo, PurchasingOrderNo_New, Pub.SAW) Then
            If ISUD3411A.Link_ISUD3411A(3, PurchasingOrderNo_New, Me.Name) = False Then Exit Sub
            Call DATA_SEARCH01()
        End If

    End Sub

#End Region

#Region "Data_search"
    Private Function DATA_SEARCH01(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH01 = False
        Vs1.Enabled = False

        If ssp_WHERE.opt_ChkGroup.Checked = True Then

            DS1 = PrcDS("USP_PFP34112_SEARCH_VS1_GROUP", cn,
                                                        ssp_WHERE.txt_SdateEdate.text1,
                                                        ssp_WHERE.txt_SdateEdate.text2,
                                                        ssp_WHERE.txt_GCODE.chkAll.CheckState,
                                                        ssp_WHERE.txt_GCODE.SQL,
                                                        ssp_WHERE.txt_cdDepartment.Code,
                                                        "*" & ssp_WHERE.txt_MaterialCode.Data,
                                                        ssp_WHERE.txt_Incharge.Code,
                                                        ssp_WHERE.txt_PurchasingNo.Data,
                                                        ssp_WHERE.txt_SupplierCode.Data,
                                                        ssp_WHERE.txt_cdLargeGroupMaterial.Code,
                                                        ssp_WHERE.txt_cdSemiGroupMaterial.Code,
                                                        ssp_WHERE.txt_cdDetailGroupMaterial.Code,
                                                        CheckRequestMaterial,
                                                        ssp_WHERE.txt_CustomerCode.Data,
                                                        ssp_WHERE.txt_Article.Data,
                                                        ssp_WHERE.txt_Line.Data,
                                                        ssp_WHERE.chk_CheckProcessMaterial0.CheckState,
                                                        ssp_WHERE.chk_CheckProcessMaterial1.CheckState,
                                                        ssp_WHERE.chk_CheckIOType0.CheckState,
                                                        ssp_WHERE.chk_CheckIOType1.CheckState,
                                                        ssp_WHERE.chk_CheckMaterialType0.CheckState,
                                                        ssp_WHERE.chk_CheckMaterialType1.CheckState,
                                                        ssp_WHERE.chk_CheckMarketType0.CheckState,
                                                        ssp_WHERE.chk_CheckMarketType1.CheckState,
                                                        ssp_WHERE.chk_CheckRelationType0.CheckState,
                                                        ssp_WHERE.chk_CheckRelationType1.CheckState)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_PFP34112_SEARCH_VS1_GROUP", "Vs1")
                Vs1.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs1, DS1, "USP_PFP34112_SEARCH_VS1_GROUP", "Vs1")
            DATA_SEARCH01 = True

            Vs1.Enabled = True

        Else

            DS1 = PrcDS("USP_PFP34112_SEARCH_VS1_DETAIL", cn,
                                                        ssp_WHERE.txt_SdateEdate.text1,
                                                        ssp_WHERE.txt_SdateEdate.text2,
                                                        ssp_WHERE.txt_GCODE.chkAll.CheckState,
                                                        ssp_WHERE.txt_GCODE.SQL,
                                                        ssp_WHERE.txt_cdDepartment.Code,
                                                        "*" & ssp_WHERE.txt_MaterialCode.Data,
                                                        ssp_WHERE.txt_Incharge.Code,
                                                        ssp_WHERE.txt_PurchasingNo.Data,
                                                        ssp_WHERE.txt_SupplierCode.Data,
                                                        ssp_WHERE.txt_cdLargeGroupMaterial.Code,
                                                        ssp_WHERE.txt_cdSemiGroupMaterial.Code,
                                                        ssp_WHERE.txt_cdDetailGroupMaterial.Code,
                                                        CheckRequestMaterial,
                                                        ssp_WHERE.txt_CustomerCode.Data,
                                                        ssp_WHERE.txt_Article.Data,
                                                        ssp_WHERE.txt_Line.Data,
                                                        ssp_WHERE.chk_CheckProcessMaterial0.CheckState,
                                                        ssp_WHERE.chk_CheckProcessMaterial1.CheckState,
                                                        ssp_WHERE.chk_CheckIOType0.CheckState,
                                                        ssp_WHERE.chk_CheckIOType1.CheckState,
                                                        ssp_WHERE.chk_CheckMaterialType0.CheckState,
                                                        ssp_WHERE.chk_CheckMaterialType1.CheckState,
                                                        ssp_WHERE.chk_CheckMarketType0.CheckState,
                                                        ssp_WHERE.chk_CheckMarketType1.CheckState,
                                                        ssp_WHERE.chk_CheckRelationType0.CheckState,
                                                        ssp_WHERE.chk_CheckRelationType1.CheckState)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_PFP34112_SEARCH_VS1_DETAIL", "Vs1")
                Vs1.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs1, DS1, "USP_PFP34112_SEARCH_VS1_DETAIL", "Vs1")
            DATA_SEARCH01 = True

            Vs1.Enabled = True
        End If

    End Function

    Private Function LINE_MOVE_DISPLAY01() As Boolean
        LINE_MOVE_DISPLAY01 = False
        Dim PurchasingOrderNo As String
        Dim PurchasingOrderSeq As String

        PurchasingOrderNo = getData(Vs1, getColumIndex(Vs1, "PurchasingOrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
        PurchasingOrderSeq = getData(Vs1, getColumIndex(Vs1, "PurchasingOrderSeq"), Vs1.ActiveSheet.ActiveRowIndex)

        Try
            DS1 = PrcDS("USP_PFP34112_SEARCH_VS1_LINE", cn, PurchasingOrderNo,
                                                        PurchasingOrderSeq)

            If GetDsRc(DS1) = 0 Then
                Vs1.Enabled = True
                Exit Function
            End If

            READ_SPREAD(Vs1, DS1, "USP_PFP34112_SEARCH_VS1", "Vs1", Vs1.ActiveSheet.ActiveRowIndex)

            Vs1.Enabled = True
            LINE_MOVE_DISPLAY01 = True
        Catch ex As Exception
            MsgBoxP("LINE_MOVE_DISPLAY01")
        End Try
    End Function
    Private Function CheckRequestMaterial() As String
        CheckRequestMaterial = "9"
        If ssp_WHERE.opt_SEL0.Checked = True Then CheckRequestMaterial = "1"
        If ssp_WHERE.opt_SEL1.Checked = True Then CheckRequestMaterial = "2"
        If ssp_WHERE.opt_SEL2.Checked = True Then CheckRequestMaterial = "3"
        If ssp_WHERE.opt_SEL3.Checked = True Then CheckRequestMaterial = "4"
        If ssp_WHERE.opt_SEL4.Checked = True Then CheckRequestMaterial = "6"
        If ssp_WHERE.opt_SEL5.Checked = True Then CheckRequestMaterial = "9"
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

        ElseIf Cms_1.Items(7).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB07()

        ElseIf Cms_1.Items(9).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB09()
        End If

    End Sub


#End Region


End Class