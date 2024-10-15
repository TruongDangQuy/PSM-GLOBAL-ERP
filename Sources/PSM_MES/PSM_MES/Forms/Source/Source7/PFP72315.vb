Public Class PFP72315

#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Private Form_Close As Boolean
#End Region

#Region "Form Load - Toolstrip"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False, WordConv("INPUT") & "(F5)")
        Call Cms_additem(Cms_1,
                         WordConv("MATERIAL CODE PROCESSING") & "-" & WordConv("VIEW") & "(F6)",
                         WordConv("MATERIAL CODE PROCESSING") & "-" & WordConv("SEARCH") & "(F6)")

        Vs1.ContextMenuStrip = Cms_1

        Call FORM_INIT()
        Call DATA_INIT()
    End Sub
    Private Sub FORM_INIT()


    End Sub

    Private Sub DATA_INIT()

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

    Private Sub MAIN_JOB01()
        Call HLP7231C.ShowDialog()
    End Sub

    Private Sub MAIN_JOB02()
        Dim xJOB As String = "2"

        If getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        If ISUD7231A.Link_ISUD7231A(xJOB, getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub
    End Sub

    Private Sub MAIN_JOB03()

    End Sub

    Private Sub MAIN_JOB04()

    End Sub

    Private Sub MAIN_JOB05()

    End Sub
    Private Sub MAIN_JOB06()

    End Sub
#End Region

#Region "Data Search"
    Private Function DATA_SEARCH01() As Boolean

        Dim RS01 As DataRow = Nothing
        Dim xSort As String = "1"
        Vs1.Enabled = False

        DATA_SEARCH01 = False

        If xSORT1.Checked = True Then xSort = "1"
        If xSORT2.Checked = True Then xSort = "2"
        If xSORT3.Checked = True Then xSort = "3"

        DS1 = PrcDS("USP_PFP72315_SEARCH_VS1", cn, "*" & txt_Name.Data,
                                                    "",
                                                    "",
                                                    "",
                                                    rad_StatusMaterial1.CheckState,
                                                    rad_StatusMaterial2.CheckState,
                                                    rad_StatusMaterial3.CheckState,
                                                    rad_StatusMaterial4.CheckState,
                                                    rad_StatusMaterial5.CheckState,
                                                    rad_StatusMaterial6.CheckState,
                                                    rad_CheckUse1.CheckState,
                                                    rad_CheckUse2.CheckState,
                                                    xSort)

        If GetDsRc(DS1) = 0 Then
            Vs1.Enabled = True
            SPR_PRO_NEW(Vs1, DS1, "USP_PFP72315_SEARCH_VS1", "Vs1")
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "USP_PFP72315_SEARCH_VS1", "Vs1")
        DATA_SEARCH01 = True

        Vs1.Enabled = True

    End Function

    Private Function LINE_MOVE_DISPLAY01() As Boolean
        LINE_MOVE_DISPLAY01 = False
        Try
            Dim RS01 As DataRow = Nothing
            DS1 = PrcDS("USP_PFP72315_SEARCH_VS1_LINE", cn, getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex))

            If GetDsRc(DS1) = 0 Then
                Exit Function
            End If
            READ_SPREAD(Vs1, DS1, "USP_PFP72315_SEARCH_VS1", "Vs1", Vs1.ActiveSheet.ActiveRowIndex)

            LINE_MOVE_DISPLAY01 = True

        Catch ex As Exception
            MsgBoxP("LINE_MOVE_DISPLAY01!")
        End Try
    End Function

#End Region

#Region "Spread"

    Private Sub Vs1_Change(sender As Object, e As ChangeEventArgs) Handles Vs1.Change
        Try


            If READ_PFK7231(getData(Vs1, getColumIndex(Vs1, "KEY_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex)) Then
             
                D7231.ImportName1 = getData(Vs1, getColumIndex(Vs1, "ImportName1"), Vs1.ActiveSheet.ActiveRowIndex)
                D7231.ImportCode1 = getData(Vs1, getColumIndex(Vs1, "ImportCode1"), Vs1.ActiveSheet.ActiveRowIndex)

                Call REWRITE_PFK7231(D7231)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Vs1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown
        Try

            If e.KeyCode = Keys.Enter Then
                If READ_PFK7231(getData(Vs1, getColumIndex(Vs1, "KEY_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex)) Then

                    D7231.ImportName1 = getData(Vs1, getColumIndex(Vs1, "ImportName1"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7231.ImportCode1 = getData(Vs1, getColumIndex(Vs1, "ImportCode1"), Vs1.ActiveSheet.ActiveRowIndex)

                    Call REWRITE_PFK7231(D7231)
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub vS1_GotFocus(sender As Object, e As EventArgs) Handles Vs1.GotFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False, WordConv("INPUT") & "(F5)", WordConv("SEARCH") & "(F6)", WordConv("UPDATE") & "(F7)", WordConv("DELETE") & "(F8)")

    End Sub

    Private Sub vS1_LostFocus(sender As Object, e As EventArgs) Handles Vs1.LostFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False, WordConv("INPUT") & "(F5)", WordConv("SEARCH") & "(F6)", WordConv("UPDATE") & "(F7)", WordConv("DELETE") & "(F8)")
    End Sub

    Private Sub vS1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        'Call MAIN_JOB02()
    End Sub

#End Region

#Region "Event"
    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
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

            Case Cms_1.Items(4).Selected
                Cms_1.Hide()
                Call MAIN_JOB05()

            Case Cms_1.Items(6).Selected
                Cms_1.Hide()
                Call MAIN_JOB06()

        End Select
    End Sub


    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Try
            Dim i As Integer

            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If getDataM(Vs1, getColumIndex(Vs1, "dchk"), i) = "1" Then
                    GoTo next1
                End If
            Next

            MsgBoxP("You have to check at least one ! ")
            Exit Sub

next1:
            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If getDataM(Vs1, getColumIndex(Vs1, "dchk"), i) = "1" Then

                    If READ_PFK7231(getData(Vs1, getColumIndex(Vs1, "KEY_MaterialCode"), i)) Then
                   
                        D7231.ImportName1 = getData(Vs1, getColumIndex(Vs1, "ImportName1"), i)
                        D7231.ImportCode1 = getData(Vs1, getColumIndex(Vs1, "ImportCode1"), i)

                        Call REWRITE_PFK7231(D7231)
                    End If

                End If

            Next

            Call MsgBoxP("Update Succesully !", vbInformation)
        Catch ex As Exception
            Call MsgBoxP("Update Wrong ! Check again!")
        End Try
    End Sub


#End Region



End Class