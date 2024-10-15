Public Class PFP25520
#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Private wGCODE As String
    Protected prg As E_PRG

    Private W2552 As T2552_AREA
    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim xISUD2552A As String = ISUD2552A.Text

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

        Call Cms_additem(Cms_1, _
                        xISUD2552A & " - " & WordConv("INSERT") & "(F5)", _
                        xISUD2552A & " - " & WordConv("SEARCH") & "(F6)", _
                        xISUD2552A & " - " & WordConv("UPDATE") & "(F7)", _
                        xISUD2552A & " - " & WordConv("DELETE") & "(F8)")

        vS1.ContextMenuStrip = Cms_1

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
        Dim xDepartment As String

        SdateEdate.text1 = System_Date_6() & "01"
        SdateEdate.text2 = System_Date_8()


        txt_cdDepartment.Enabled = False
    End Sub

#End Region

#Region "Function"
    Private Sub MAIN_JOB01()
        Try
            If ISUD2552A.Link_ISUD2552A(1, Pub.DAT, Me.Name) = False Then Exit Sub
            Call DATA_SEARCH_Vs1()

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB01!", vbCritical)
        End Try

    End Sub

    Private Sub MAIN_JOB02()
        Try
            Select Case True

                Case Vs1.Focused

                    Dim DateAudit As String

                    DateAudit = getData(vS1, getColumIndex(vS1, "DateAudit"), vS1.ActiveSheet.ActiveRowIndex)

                    If DateAudit = "" Then Exit Sub

                    DateAudit = FormatCut(DateAudit)

                    If ISUD2552A.Link_ISUD2552A(2, DateAudit, Me.Name) = False Then Exit Sub

            End Select
        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB02!", vbCritical)
        End Try

    End Sub

    Private Sub MAIN_JOB03()
        Try
            Select Case True
                Case Vs1.Focused
                    Dim DateAudit As String

                    DateAudit = getData(vS1, getColumIndex(vS1, "DateAudit"), vS1.ActiveSheet.ActiveRowIndex)

                    If DateAudit = "" Then Exit Sub

                    DateAudit = FormatCut(DateAudit)

                    If ISUD2552A.Link_ISUD2552A(3, DateAudit, Me.Name) = False Then Exit Sub
                    DATA_SEARCH_Vs1()
            End Select
        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB03!", vbCritical)
        End Try
    End Sub

    Private Sub MAIN_JOB04()
        Try
            Select Case True
                Case vS1.Focused
                    Dim DateAudit As String

                    DateAudit = getData(vS1, getColumIndex(vS1, "DateAudit"), vS1.ActiveSheet.ActiveRowIndex)

                    If DateAudit = "" Then Exit Sub

                    DateAudit = FormatCut(DateAudit)

                    If ISUD2552A.Link_ISUD2552A(4, DateAudit, Me.Name) = False Then Exit Sub
                    DATA_SEARCH_Vs1()
            End Select

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB04!", vbCritical)
        End Try
    End Sub

    Private Sub MAIN_JOB05()
        Try
            'If getData(Vs1, getColumIndex(Vs1, "KEY_MaterialInBoundNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

            'If ISUD2552B.Link_ISUD2552B(3, getData(Vs1, getColumIndex(Vs1, "KEY_MaterialInBoundNo"), Vs1.ActiveSheet.ActiveRowIndex), getData(Vs1, getColumIndex(Vs1, "KEY_MaterialInBoundSeq"), Vs1.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub

            'Call LINE_MOVE_DISPLAY01()
            'DATA_SEARCH_Vs1()

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB05!", vbCritical)
        End Try

    End Sub

#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_Vs1(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_Vs1 = False

        Vs1.Enabled = False

        DS1 = PrcDS("USP_PFP25520A_SEARCH_Vs1", cn, SdateEdate.text1,
                                                    SdateEdate.text2,
                                                    txt_CustomerInBoundMaterialName.Data,
                                                    txt_cdSemiGroupMaterialName.Data,
                                                    "*" & txt_MaterialName.Data)


        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs1, DS1, "USP_PFP25520A_SEARCH_Vs1", "Vs1")

            Vs1.ActiveSheet.RowCount = 0
            Vs1.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "USP_PFP25520A_SEARCH_Vs1", "Vs1")
        DATA_SEARCH_Vs1 = True

        Vs1.Enabled = True
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
    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs)
        If e.ColumnHeader = True Then Exit Sub
        vS1.ActiveSheet.ActiveColumnIndex = e.Column
        vS1.ActiveSheet.ActiveRowIndex = e.Row
        vS1.ActiveSheet.AddSelection(e.Row, e.Column, 1, 1)
    End Sub



    Private Sub Vs1_GotFocus(sender As Object, e As EventArgs) Handles vS1.GotFocus

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
    Private Sub Vs1_LostFocus(sender As Object, e As EventArgs)

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

        Call DATA_SEARCH_Vs1()
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

        End If

    End Sub

#End Region

    Private Sub vS1_KeyDown(sender As Object, e As KeyEventArgs) Handles vS1.KeyDown
        If e.KeyCode = Keys.Enter Then

            If READ_PFK2552(CIntp(getData(vS1, getColumIndex(vS1, "Autokey"), vS1.ActiveSheet.ActiveRowIndex))) Then
                D2552.QtyAdjust = CDecp(getData(vS1, getColumIndex(vS1, "QtyAdjust"), vS1.ActiveSheet.ActiveRowIndex))
                Call REWRITE_PFK2552(D2552)
            End If


        End If
    End Sub

    Private Sub vS1_Change(sender As Object, e As ChangeEventArgs) Handles vS1.Change
        If e.Column = getColumIndex(vS1, "QtyAdjust") Then
            If READ_PFK2552(CIntp(getData(vS1, getColumIndex(vS1, "Autokey"), vS1.ActiveSheet.ActiveRowIndex))) Then
                D2552.QtyAdjust = CDecp(getData(vS1, getColumIndex(vS1, "QtyAdjust"), vS1.ActiveSheet.ActiveRowIndex))
                Call REWRITE_PFK2552(D2552)
            End If
        End If
    End Sub
End Class