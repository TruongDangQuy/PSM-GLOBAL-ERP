Public Class PFP72609

#Region "Variable"

    Private Dsu01 As Long     'Data Su
    Private wGCODE As String

    Private W7260 As New T7260_AREA
    Private L7260 As New T7260_AREA

    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim xISUD7260A As String
        Dim xISUD7260P As String

        xISUD7260A = ISUD7260A.Text
        xISUD7260P = ISUD7260P.Text

        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)
        Call Cms_additem(Cms_1,
                         xISUD7260A & "-" & WordConv("INPUT") & "(F5)",
                         xISUD7260A & "-" & WordConv("SEARCH") & "(F6)",
                         xISUD7260A & "-" & WordConv("UPDATE") & "(F7)",
                         xISUD7260A & "-" & WordConv("DELETE") & "(F8)",
                         xISUD7260A & "-" & WordConv("COPY") & "(F9)",
                         "-",
                         xISUD7260P & "-" & WordConv("APPROVED") & "(F10)")

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False)

        vS1.ContextMenuStrip = Cms_1

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
                Case Keys.F10 : Call MAIN_JOB06()
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

    End Sub
#End Region

#Region "Function"
    Private Sub MAIN_JOB01()
        Dim xJOB As String = "1"

        'If txt_CustomerCode.Code = "" Then MsgBoxP("Supplier Choose first!") : Exit Sub

        W7260.CustomerCode = txt_CustomerCode.Code

        If chk_RnD.Checked = True Then
            If ISUD7260A.Link_ISUD7260A(xJOB, W7260.CustomerCode, "PFP72600RnD") = False Then Exit Sub
        Else
            If ISUD7260A.Link_ISUD7260A(xJOB, W7260.CustomerCode, "PFP72600") = False Then Exit Sub
        End If

        Call DATA_SEARCH_VS1()
    End Sub

    Private Sub MAIN_JOB02()
        Dim xJOB As String = "2"

        If getData(Vs1, getColumIndex(Vs1, "KEY_ContractID"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        W7260.ContractID = getData(Vs1, getColumIndex(Vs1, "KEY_ContractID"), Vs1.ActiveSheet.ActiveRowIndex)

        If chk_RnD.Checked = True Then
            If ISUD7260A.Link_ISUD7260A(xJOB, W7260.ContractID, "PFP72600RnD") = False Then Exit Sub
        Else
            If ISUD7260A.Link_ISUD7260A(xJOB, W7260.ContractID, "PFP72600") = False Then Exit Sub
        End If

    End Sub

    Private Sub MAIN_JOB03()
        Dim xJOB As String = "3"

        If getData(Vs1, getColumIndex(Vs1, "KEY_ContractID"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        If getData(Vs1, getColumIndex(Vs1, "KEY_CheckSupplierPrice"), Vs1.ActiveSheet.ActiveRowIndex) <> "1" Then
            xJOB = "2"
            Call MsgBoxP("Only Search ! This is Data Already Approved  ")
        End If

        W7260.ContractID = getData(Vs1, getColumIndex(Vs1, "KEY_ContractID"), Vs1.ActiveSheet.ActiveRowIndex)

        If chk_RnD.Checked = True Then
            If ISUD7260A.Link_ISUD7260A(xJOB, W7260.ContractID, "PFP72600RnD") = False Then Exit Sub
        Else
            If ISUD7260A.Link_ISUD7260A(xJOB, W7260.ContractID, "PFP72600") = False Then Exit Sub
        End If

        W7260.CustomerCode = getData(Vs1, getColumIndex(Vs1, "KEY_CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex)
        Call DATA_SEARCH_VS1()

    End Sub

    Private Sub MAIN_JOB04()
        Dim xJOB As String = "3"

        If getData(Vs1, getColumIndex(Vs1, "KEY_ContractID"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        If getData(Vs1, getColumIndex(Vs1, "KEY_CheckSupplierPrice"), Vs1.ActiveSheet.ActiveRowIndex) <> "1" Then
            xJOB = "2"
            Call MsgBoxP("Only Search ! This is Data Already Approved  ")
        End If

        W7260.ContractID = getData(Vs1, getColumIndex(Vs1, "KEY_ContractID"), Vs1.ActiveSheet.ActiveRowIndex)

        If chk_RnD.Checked = True Then
            If ISUD7260A.Link_ISUD7260A(xJOB, W7260.ContractID, "PFP72600RnD") = False Then Exit Sub
        Else
            If ISUD7260A.Link_ISUD7260A(xJOB, W7260.ContractID, "PFP72600") = False Then Exit Sub
        End If

        W7260.CustomerCode = getData(Vs1, getColumIndex(Vs1, "KEY_CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex)
        Call DATA_SEARCH_VS1()

    End Sub


    Private Sub MAIN_JOB05()
        Dim xJOB As String = "5"

        If getData(Vs1, getColumIndex(Vs1, "KEY_ContractID"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        If getData(Vs1, getColumIndex(Vs1, "KEY_CheckSupplierPrice"), Vs1.ActiveSheet.ActiveRowIndex) <> "1" Then
            xJOB = "2"
            Call MsgBoxP("Only Search ! This is Data Already Approved  ")
        End If

        W7260.CustomerCode = getData(Vs1, getColumIndex(Vs1, "KEY_CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex)
        W7260.ContractID = getData(Vs1, getColumIndex(Vs1, "KEY_ContractID"), Vs1.ActiveSheet.ActiveRowIndex)

        If ISUD7260A.Link_ISUD7260A(5, W7260.ContractID, Me.Name) = False Then Exit Sub

        Call DATA_SEARCH_VS1()

    End Sub

    Private Sub MAIN_JOB06()
        If getData(Vs1, getColumIndex(Vs1, "KEY_ContractID"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        Dim xStatus1, xStatus2, xStatus3, xStatus4, xStatus5, xStatus6 As String

        xStatus1 = "1"  '1.YES 2.NO
        xStatus2 = "1"  '1.YES 2.NO
        xStatus3 = "1"  '1.YES 2.NO
        xStatus4 = "1"  '1.YES 2.NO
        xStatus5 = "1"  '1.YES 2.NO
        xStatus6 = "1"  '1.YES 2.NO

        Dim xJOB As String = "5"

        W7260.CustomerCode = getData(Vs1, getColumIndex(Vs1, "KEY_CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex)
        W7260.ContractID = getData(Vs1, getColumIndex(Vs1, "KEY_ContractID"), Vs1.ActiveSheet.ActiveRowIndex)

        If ISUD7260P.Link_ISUD7260P(xJOB, getData(Vs1, getColumIndex(Vs1, "KEY_ContractID"), Vs1.ActiveSheet.ActiveRowIndex),
                                         xStatus1, xStatus2, xStatus3, xStatus4, xStatus5, xStatus6, Me.Name) = False Then Exit Sub

        Call DATA_SEARCH_VS1()

    End Sub


#End Region

#Region "Data_search"

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False
        vS1.Enabled = False

        DS1 = PrcDS("USP_PFP72609_SEARCH_VS1", cn, txt_ContractNo.Data,
                                                    txt_CustomerCode.Code,
                                                   "*" & txt_MaterialCode.Data,
                                                    rad_CheckUse1.CheckState,
                                                    rad_CheckUse2.CheckState,
                                                    chk_RnD.CheckState,
                                                    chk_Material.CheckState)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS1, DS1, "USP_PFP72609_SEARCH_VS1", "VS1")
            vS1.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS1, DS1, "USP_PFP72609_SEARCH_VS1", "VS1")
        DATA_SEARCH_VS1 = True

        vS1.Enabled = True
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

    Private Sub VS1_GotFocus(sender As Object, e As EventArgs) Handles vS1.GotFocus

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
  
    Private Sub VS1_LostFocus(sender As Object, e As EventArgs) Handles vS1.LostFocus

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

        Call DATA_SEARCH_VS1()

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

        ElseIf Cms_1.Items(6).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB06()

        End If

    End Sub


#End Region


    Private Sub chk_RnD_CheckedChanged(sender As Object, e As EventArgs) Handles chk_RnD.CheckedChanged
        If chk_RnD.Checked = True Then
            chk_Material.Checked = False
        ElseIf chk_RnD.Checked = False Then
            chk_Material.Checked = True
        End If
    End Sub

    Private Sub chk_Material_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Material.CheckedChanged
        If chk_Material.Checked = True Then
            chk_RnD.Checked = False
        ElseIf chk_Material.Checked = False Then
            chk_RnD.Checked = True
        End If
    End Sub
End Class