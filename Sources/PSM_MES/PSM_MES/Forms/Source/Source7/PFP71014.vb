Public Class PFP71014
#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Private wGCODE As String
    Protected prg As E_PRG
    Private W7101 As New T7101_AREA


    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False, WordConv("INPUT") & "(F5)")
        Me.KeyPreview = True

        Call FORM_INIT()
        Call DATA_INIT()

    End Sub
    Private Sub Me_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
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

    End Sub
#End Region

#Region "Function"
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
    Private Sub MAIN_JOB01()
        If ISUD7101C.Link_ISUD7101A(1, "000000", Me.Name) = False Then Exit Sub

        Call DATA_SEARCH01()

    End Sub
    Private Sub MAIN_JOB02()
        If getData(Vs1, getColumIndex(Vs1, "Key_CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub


        If ISUD7101C.Link_ISUD7101A(2, getData(Vs1, getColumIndex(Vs1, "Key_CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub


    End Sub
    Private Sub MAIN_JOB03()
        Dim xJOB As String

        If getData(Vs1, getColumIndex(Vs1, "Key_CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        xJOB = "3"
        If getData(Vs1, getColumIndex(Vs1, "CheckCustomerStatus"), Vs1.ActiveSheet.ActiveRowIndex) = "3" Then
            xJOB = "2"
            Call MsgBoxP("Only Search ! This is Data Already Approved  ")
        End If

        If ISUD7101C.Link_ISUD7101A(xJOB, getData(Vs1, getColumIndex(Vs1, "Key_CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub
        Call LINE_MOVE_DISPLAY01()

    End Sub
    Private Sub MAIN_JOB04()
        Dim xJOB As String

        If getData(Vs1, getColumIndex(Vs1, "Key_CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        xJOB = "4"
        If getData(Vs1, getColumIndex(Vs1, "CheckCustomerStatus"), Vs1.ActiveSheet.ActiveRowIndex) = "3" Then
            xJOB = "2"
            Call MsgBoxP("Only Search ! This is Data Already Approved  ")
        End If

        If ISUD7101C.Link_ISUD7101A(xJOB, getData(Vs1, getColumIndex(Vs1, "Key_CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub
        Call LINE_MOVE_DISPLAY01()
    End Sub
    Private Sub MAIN_JOB05()


    End Sub



#End Region

#Region "Data_search"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False
        Dim xSort As String = "1"
        Vs1.Enabled = False

        If opt_SortName.Checked = True Then xSort = "1"
        If opt_SortName.Checked = True Then xSort = "2"

        DS1 = PrcDS("USP_PFP71012_SEARCH_VS1", cn, "*" & txt_GNAME.Data, chk_CheckUse1.CheckState, chk_CheckUse2.CheckState, xSort)

        If GetDsRc(DS1) = 0 Then
            Vs1.ActiveSheet.RowCount = 0
            Vs1.Enabled = True
            Exit Function
        End If
        SPR_PRO_NEW(Vs1, DS1, "USP_PFP71012_SEARCH_VS1", "Vs1")
        DATA_SEARCH01 = True

        Vs1.Enabled = True
    End Function
    Private Function LINE_MOVE_DISPLAY01() As Boolean
        Dim CustomerCode As String
        Dim xrow As Integer
        LINE_MOVE_DISPLAY01 = False
        Try
            xrow = Vs1.ActiveSheet.ActiveRowIndex
            CustomerCode = getData(Vs1, getColumIndex(Vs1, "Key_CustomerCode"), xrow)
            DS1 = PrcDS("USP_PFP71012_SEARCH_VS1_LINE", cn, CustomerCode)

            If GetDsRc(DS1) = 0 Then
                Exit Function
            End If
            READ_SPREAD(Vs1, DS1, "USP_PFP71012_SEARCH_VS1", "Vs1", xrow)

            LINE_MOVE_DISPLAY01 = True
        Catch ex As Exception

        End Try
    End Function
#End Region

#Region "Event"

    Private Sub vS1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        If getData(Vs1, getColumIndex(Vs1, "Key_CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex) <> "" Then
            If getColumIndex(Vs1, "DCHK") <> e.Column Then

                Call MAIN_JOB02()
            End If
        End If
    End Sub

    Private Sub Vs1_Change(sender As Object, e As ChangeEventArgs) Handles Vs1.Change

        If getData(Vs1, getColumIndex(Vs1, "Key_CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex) <> "" Then
            If getColumIndex(Vs1, "DCHK") = e.Column Then

                If getDataM(Vs1, getColumIndex(Vs1, "DCHK"), Vs1.ActiveSheet.ActiveRowIndex) = "1" Then

                    If READ_PFK7101(getData(Vs1, getColumIndex(Vs1, "Key_CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex)) = True Then
                        W7101 = D7101
                        W7101.CheckCustomerStatus = "6"

                        Call REWRITE_PFK7101(W7101)
                        Call LINE_MOVE_DISPLAY01()
                    End If
                Else
                    W7101 = D7101
                    W7101.CheckCustomerStatus = "5"

                    Call REWRITE_PFK7101(W7101)
                    Call LINE_MOVE_DISPLAY01()

                End If
            End If
        End If

    End Sub

    Private Sub vS1_GotFocus(sender As Object, e As EventArgs) Handles Vs1.GotFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False, WordConv("INPUT") & "(F5)", WordConv("CHANGE") & "(F6)")

        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False
    End Sub
    Private Sub txt_GNAME_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_GNAME.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter : cmd_SEARCH.Focus()
        End Select
    End Sub
    Private Sub vS1_LostFocus(sender As Object, e As EventArgs) Handles Vs1.LostFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False, WordConv("INPUT") & "(F5)")

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

    Private Sub Cms_1_Click(sender As Object, e As EventArgs) Handles Cms_1.ItemClicked
        Select Case True
            Case Cms_1.Items(0).Selected
                Cms_1.Hide()
                Call MAIN_JOB01()

            Case Cms_1.Items(1).Selected
                Cms_1.Hide()
                Call MAIN_JOB02()

            Case Cms_1.Items(2).Selected
                Cms_1.Hide()
                Call MAIN_JOB03()

            Case Cms_1.Items(3).Selected
                Cms_1.Hide()
                Call MAIN_JOB04()

            Case Cms_1.Items(5).Selected
                Cms_1.Hide()
                Call MAIN_JOB05()

        End Select
    End Sub
#End Region



End Class