Public Class PFP72601

#Region "Variable"

    Private Dsu01 As Long     'Data Su
    Private wGCODE As String

    Private W7260 As New T7260_AREA
    Private L7260 As New T7260_AREA

    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub PFP30112_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control = True And e.KeyCode = Keys.G Then
            chk_Total.Checked = Not chk_Total.Checked
        End If
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Cms_additem(Cms_1,
                 "-",
                 "-",
                 WordConv("CUSTOMER APPROVED PROCESSING") & "-" & WordConv("DETAIL") & "(F7)",
                 "-",
                 WordConv("CUSTOMER APPROVED PROCESSING") & "-" & WordConv("SIMPLE") & "(F9)")

        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, True, False, True, False)

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

        If chk_Total.Checked = False Then
            SplitContainer1.Panel1Collapsed = Not chk_Total.Checked
        End If

    End Sub

    Private Sub DATA_INIT()

    End Sub
#End Region

#Region "Function"
    Private Sub MAIN_JOB01()
    End Sub

    Private Sub MAIN_JOB02()

    End Sub

    Private Sub MAIN_JOB03()
        Dim xJOB As String = "91"

        If getData(vS2, getColumIndex(vS2, "KEY_ContractID"), vS2.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        W7260.CustomerCode = getData(Vs1, getColumIndex(Vs1, "KEY_CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex)
        W7260.ContractID = getData(vS2, getColumIndex(vS2, "KEY_ContractID"), vS2.ActiveSheet.ActiveRowIndex)

        If ISUD7260A.Link_ISUD7260A(91, W7260.ContractID, Me.Name) = False Then Exit Sub

        Call DATA_SEARCH_VS2(W7260.CustomerCode)
    End Sub

    Private Sub MAIN_JOB04()

    End Sub

    Private Sub MAIN_JOB05()
        If getData(vS2, getColumIndex(vS2, "KEY_ContractID"), vS2.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        Dim xStatus1, xStatus2, xStatus3, xStatus4, xStatus5, xStatus6 As String

        xStatus1 = "1"  '1.YES 2.NO
        xStatus2 = "2"  '1.YES 2.NO
        xStatus3 = "2"  '1.YES 2.NO
        xStatus4 = "2"  '1.YES 2.NO
        xStatus5 = "1"  '1.YES 2.NO
        xStatus6 = "1"  '1.YES 2.NO

        Dim xJOB As String = "5"

        W7260.CustomerCode = getData(Vs1, getColumIndex(Vs1, "KEY_CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex)
        W7260.ContractID = getData(vS2, getColumIndex(vS2, "KEY_ContractID"), vS2.ActiveSheet.ActiveRowIndex)

        If ISUD7260P.Link_ISUD7260P(xJOB, getData(vS2, getColumIndex(vS2, "KEY_ContractID"), vS2.ActiveSheet.ActiveRowIndex),
                                         xStatus1, xStatus2, xStatus3, xStatus4, xStatus5, xStatus6, Me.Name) = False Then Exit Sub

        Call DATA_SEARCH_VS2(W7260.CustomerCode)

    End Sub

#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS1(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS1 = False
        Vs1.Enabled = False
        Dim MaterialType As String = "1"

        If Me.PeaceFormType = "RnD" Then
            MaterialType = "2"
        Else
            MaterialType = "1"
        End If

        DS1 = PrcDS("USP_PFP72601_SEARCH_VS1", cn, "*" & txt_ContractNo.Data,
                                                    txt_CustomerCode.Code,
                                                    txt_MaterialCode.Data,
                                                    rad_CheckSupplierPrice1.CheckState,
                                                    rad_CheckSupplierPrice2.CheckState,
                                                    rad_CheckSupplierPrice3.CheckState,
                                                    rad_CheckSupplierPrice4.CheckState,
                                                    rad_CheckSupplierPrice5.CheckState,
                                                    rad_CheckSupplierPrice6.CheckState,
                                                    rad_CheckUse1.CheckState,
                                                    rad_CheckUse2.CheckState,
                                                    MaterialType)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs1, DS1, "USP_PFP72601_SEARCH_VS1", "Vs1")
            Vs1.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "USP_PFP72601_SEARCH_VS1", "Vs1")
        DATA_SEARCH_VS1 = True

        Vs1.Enabled = True
    End Function


    Private Function DATA_SEARCH_VS2(CustomerCode As String) As Boolean
        DATA_SEARCH_VS2 = False
        vS2.Enabled = False
        Dim MaterialType As String = "1"

        If Me.PeaceFormType = "RnD" Then
            MaterialType = "2"
        Else
            MaterialType = "1"
        End If



        DS1 = PrcDS("USP_PFP72601_SEARCH_VS2", cn, txt_ContractNo.Data,
                                                    CustomerCode,
                                                    txt_MaterialCode.Data,
                                                    rad_CheckSupplierPrice1.CheckState,
                                                    rad_CheckSupplierPrice2.CheckState,
                                                    rad_CheckSupplierPrice3.CheckState,
                                                    rad_CheckSupplierPrice4.CheckState,
                                                    rad_CheckSupplierPrice5.CheckState,
                                                    rad_CheckSupplierPrice6.CheckState,
                                                    rad_CheckUse1.CheckState,
                                                    rad_CheckUse2.CheckState,
                                                    MaterialType)

        If GetDsRc(DS1) = 0 Then
            Call SPR_PRO_NEW(vS2, DS1, "USP_PFP72601_SEARCH_VS2", "VS2")
            vS2.Enabled = True
            Exit Function
        End If

        Call SPR_PRO_NEW(vS2, DS1, "USP_PFP72601_SEARCH_VS2", "VS2")

        If chk_Total.Checked = True Then
            Call SPR_HIDE(vS2, False, getColumIndex(vS2, "CustomerName"))
        Else
            Call SPR_HIDE(vS2, True, getColumIndex(vS2, "CustomerName"))
        End If

        DATA_SEARCH_VS2 = True

        vS2.Enabled = True
    End Function

    Private Function LINE_MOVE_DISPLAY01() As Boolean
        LINE_MOVE_DISPLAY01 = False

        Dim ContractID As String

        Try
            ContractID = getData(Vs1, getColumIndex(Vs1, "ContractID"), Vs1.ActiveSheet.ActiveRowIndex)

            DS1 = PrcDS("USP_PFP72601_SEARCH_VS1_LINE", cn, ContractID)

            If GetDsRc(DS1) = 0 Then
                Vs1.Enabled = True
                Exit Function
            End If

            READ_SPREAD(Vs1, DS1, "USP_PFP72601_SEARCH_VS1", "Vs1", Vs1.ActiveSheet.ActiveRowIndex)

            Vs1.Enabled = True
            LINE_MOVE_DISPLAY01 = True
        Catch ex As Exception
            MsgBoxP("LINE_MOVE_DISPLAY01")
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
        If sender.Equals(tst_5) Then
            MAIN_JOB05()
        End If
    End Sub
    Private Sub chk_Total_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Total.CheckedChanged
        SplitContainer1.Panel1Collapsed = Not chk_Total.Checked
    End Sub


    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        Dim CustomerCode As String

        CustomerCode = getData(Vs1, getColumIndex(Vs1, "KEY_CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex)

        If chk_Total.Checked = True Then
            SplitContainer1.Panel1Collapsed = Not chk_Total.Checked

            CustomerCode = getData(Vs1, getColumIndex(Vs1, "KEY_CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex)

            If READ_PFK7101(CustomerCode) Then
                txt_CustomerCode.Code = D7101.CustomerCode
                txt_CustomerCode.Data = D7101.CustomerName
            Else
                txt_CustomerCode.Code = ""
                txt_CustomerCode.Data = ""
            End If

        Else
            If txt_CustomerCode.Data = "" Then txt_CustomerCode.Code = ""

        End If

        Call DATA_SEARCH_VS2(txt_CustomerCode.Code)
    End Sub

    Private Sub vS1_GotFocus(sender As Object, e As EventArgs) Handles Vs1.GotFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False
    End Sub
    Private Sub vS2_GotFocus(sender As Object, e As EventArgs) Handles vS2.GotFocus

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
    Private Sub vS2_LostFocus(sender As Object, e As EventArgs) Handles vS2.LostFocus

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

        If chk_Total.Checked = True Then
            Call DATA_SEARCH_VS1()
        Else
            txt_CustomerCode.Data = ""
            txt_CustomerCode.Code = ""

            Call DATA_SEARCH_VS2("")
        End If

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

        ElseIf Cms_1.Items(4).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB05()
        End If

    End Sub


#End Region


End Class