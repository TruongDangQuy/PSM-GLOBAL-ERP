Public Class PFP13122

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
                                "TESTING AND FITTING PROCESSING - " & WordConv("INPUT") & "(F5)",
                                "TESTING AND FITTING PROCESSING - " & WordConv("SEARCH") & "(F6)",
                                "TESTING AND FITTING PROCESSING - " & WordConv("UPDATE") & "(F7)",
                                "TESTING AND FITTING PROCESSING - " & WordConv("DELETE") & "(F8)")

        Vs1.ContextMenuStrip = Cms_1

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

        Me.KeyPreview = True

        Call FORM_INIT()
        Call DATA_INIT()

    End Sub
    Private Sub PFP17811_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
        ssp_WHERE.txt_SdateEdate.text1 = System_Date_6() & "01"
        ssp_WHERE.txt_SdateEdate.text2 = System_Date_8()

        Call Gadget_Load(ssp_WHERE, Me.Name)

    End Sub
#End Region

#Region "Function"
    Private Sub MAIN_JOB01()
        Dim OrderNo As String
        Dim OrderNoSeq As String

        OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
        OrderNoSeq = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex)

        Try
            If ISUD1312T.Link_ISUD1312T(1, OrderNo, OrderNoSeq, Me.Name) = False Then Exit Sub
            Call LINE_MOVE_DISPLAY01()

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB01!", vbCritical)
        End Try

    End Sub

    Private Sub MAIN_JOB02()
        Dim OrderNo As String
        Dim OrderNoSeq As String

        OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
        OrderNoSeq = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex)

        Try
            If ISUD1312T.Link_ISUD1312T(2, OrderNo, OrderNoSeq, Me.Name) = False Then Exit Sub

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB01!", vbCritical)
        End Try
    End Sub

    Private Sub MAIN_JOB03()
        Dim OrderNo As String
        Dim OrderNoSeq As String

        OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
        OrderNoSeq = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex)

        Try
            If ISUD1312T.Link_ISUD1312T(3, OrderNo, OrderNoSeq, Me.Name) = False Then Exit Sub
            Call LINE_MOVE_DISPLAY01()

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB01!", vbCritical)
        End Try
    End Sub

    Private Sub MAIN_JOB04()
        Dim OrderNo As String
        Dim OrderNoSeq As String

        OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
        OrderNoSeq = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex)

        Try
            If ISUD1312T.Link_ISUD1312T(4, OrderNo, OrderNoSeq, Me.Name) = False Then Exit Sub
            Call LINE_MOVE_DISPLAY01()

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB01!", vbCritical)
        End Try
    End Sub

    Private Sub MAIN_JOB05()

    End Sub

    Private Sub MAIN_JOB06()

    End Sub

#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS1(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS1 = False

        Vs1.Enabled = False
        Try

            DS1 = PrcDS("USP_PFP13122_SEARCH_VS1", cn, ssp_WHERE.gData_SDate,
                                                       ssp_WHERE.gData_EDate,
                                                       ssp_WHERE.gData_chkGCodeCheck,
                                                       ssp_WHERE.gData_chkGCodeSQL,
                                                       ssp_WHERE.gData_CustomerName,
                                                       ssp_WHERE.gData_Season,
                                                       ssp_WHERE.gData_SpecNoRef,
                                                       ssp_WHERE.gData_SpecStatus,
                                                       ssp_WHERE.gData_SpecState,
                                                       ssp_WHERE.gData_SpecKind,
                                                       ssp_WHERE.gData_SizeRange,
                                                       ssp_WHERE.gData_Article,
                                                       ssp_WHERE.gData_Line,
                                                       ssp_WHERE.gData_MaterialName,
                                                       ssp_WHERE.gData_ColorName,
                                                       ssp_WHERE.gData_MoldName,
                                                       ssp_WHERE.gData_LastName,
                                                       ssp_WHERE.gData_Incharge,
                                                       ssp_WHERE.gData_CheckRequest,
                                                       ssp_WHERE.gData_CheckUse0,
                                                       ssp_WHERE.gData_CheckUse1)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_PFP13122_SEARCH_VS1", "Vs1")
                Vs1.ActiveSheet.RowCount = 0
                Vs1.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs1, DS1, "USP_PFP13122_SEARCH_VS1", "Vs1")
            DATA_SEARCH_VS1 = True

            Vs1.Enabled = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try

    End Function

    Private Function LINE_MOVE_DISPLAY01() As Boolean
        Dim OrderNo As String
        Dim OrderNoSeq As String

        Dim xrow As Integer
        LINE_MOVE_DISPLAY01 = False
        Try
            xrow = Vs1.ActiveSheet.ActiveRowIndex
            OrderNo = getData(Vs1, getColumIndex(Vs1, "Key_OrderNo"), xrow)
            OrderNoSeq = getData(Vs1, getColumIndex(Vs1, "Key_OrderNoSeq"), xrow)

            DS1 = PrcDS("USP_PFP13122_SEARCH_VS1_LINE", cn, OrderNo, OrderNoSeq)

            If GetDsRc(DS1) = 0 Then
                Exit Function
            End If

            READ_SPREAD(Vs1, DS1, "USP_PFP13122_SEARCH_VS1", "Vs1", xrow)

            LINE_MOVE_DISPLAY01 = True
        Catch ex As Exception

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
        Try

            chk_FSEL.CheckState = 0
            chk_FSEL.BackColor = clrUncheck
            chk_FSEL.ForeColor = Color.Black

            chk_FSEL.Text = WordConv("OPEN")
            ssp_WHERE.Visible = False

            Call DATA_SEARCH_VS1()

        Catch ex As Exception
            Call MsgBoxP("35", "cmd_SEARCH_Click")
        End Try
    End Sub
    Private Sub Cms_1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_1.ItemClicked
        Try

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

            End If

        Catch ex As Exception
            Call MsgBoxP("35", "cmd_SEARCH_Click")
        End Try

    End Sub


#End Region

End Class