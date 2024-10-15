Public Class PFP72310

#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Private Form_Close As Boolean
#End Region

#Region "Form Load - Toolstrip"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim xISUD7231A As String
        Dim xISUD7231PPP As String

        xISUD7231A = ISUD7231A.Text
        xISUD7231PPP = ISUD7231PPP.Text

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False, WordConv("INPUT") & "(F5)")

        Call Cms_additem(Cms_1,
                         xISUD7231A & "-" & WordConv("INPUT") & "(F5)",
                         xISUD7231A & "-" & WordConv("SEARCH") & "(F6)",
                         xISUD7231A & "-" & WordConv("UPDATE") & "(F7)",
                         xISUD7231A & "-" & WordConv("DELETE") & "(F8)",
                         xISUD7231A & "-" & WordConv("COPY") & "(F9)")


        Vs1.ContextMenuStrip = Cms_1

        Call FORM_INIT()
        Call DATA_INIT()
        Call DATA_SEARCH01()
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
        If chk_NewInsert.Checked = False Then
            If ISUD7231A.Link_ISUD7231A(1, getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub

            Call DATA_SEARCH01()
        Else

            HLP7231C.ShowDialog()
        End If
    End Sub

    Private Sub MAIN_JOB02()
        Dim xJOB As String = "2"

        If getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        If ISUD7231A.Link_ISUD7231A(xJOB, getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub

    End Sub

    Private Sub MAIN_JOB03()
        Dim xJOB As String = "3"

        If getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        If ISUD7231A.Link_ISUD7231A(xJOB, getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub
        If LINE_MOVE_DISPLAY01() = False Then
            SPR_CLEAR(Vs1, Vs1.ActiveSheet.ActiveRowIndex, 0, Vs1.ActiveSheet.ActiveRowIndex, Vs1.ActiveSheet.ColumnCount)
            setData(Vs1, getColumIndex(Vs1, "NameSemiGroupMaterial"), Vs1.ActiveSheet.ActiveRowIndex, "[DELETED]", Color.Red)
        End If

    End Sub

    Private Sub MAIN_JOB04()
        Dim xJOB As String = "4"

        If getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        If ISUD7231A.Link_ISUD7231A(xJOB, getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub
        If LINE_MOVE_DISPLAY01() = False Then
            SPR_CLEAR(Vs1, Vs1.ActiveSheet.ActiveRowIndex, 0, Vs1.ActiveSheet.ActiveRowIndex, Vs1.ActiveSheet.ColumnCount)
            setData(Vs1, getColumIndex(Vs1, "NameSemiGroupMaterial"), Vs1.ActiveSheet.ActiveRowIndex, "[DELETED]", Color.Red)
        End If
    End Sub


    Private Sub MAIN_JOB05()
        Dim xJOB As String = "5"


        If getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        If ISUD7231A.Link_ISUD7231A(xJOB, getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub

        If LINE_MOVE_DISPLAY01() = False Then
            SPR_CLEAR(Vs1, Vs1.ActiveSheet.ActiveRowIndex, 0, Vs1.ActiveSheet.ActiveRowIndex, Vs1.ActiveSheet.ColumnCount)
            setData(Vs1, getColumIndex(Vs1, "NameSemiGroupMaterial"), Vs1.ActiveSheet.ActiveRowIndex, "[DELETED]", Color.Red)
        End If
    End Sub
    Private Sub MAIN_JOB06()
        If getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        Dim xStatus1, xStatus2, xStatus3, xStatus4, xStatus5, xStatus6 As String
        xStatus1 = "1"  '1.YES 2.NO
        xStatus2 = "1"  '1.YES 2.NO
        xStatus3 = "1"  '1.YES 2.NO
        xStatus4 = "1"  '1.YES 2.NO
        xStatus5 = "1"  '1.YES 2.NO
        xStatus6 = "1"  '1.YES 2.NO


        If READ_PFK7231(getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex)) = False Then Exit Sub

        If D7231.StatusMaterial = "2" Then MsgBoxEx("No change ! Already Purchasing ! ") : Exit Sub
        If D7231.StatusMaterial = "3" Then MsgBoxEx("No change ! Already Approval ! ") : Exit Sub
        If D7231.StatusMaterial = "4" Then MsgBoxEx("No change ! Already Cancel ! ") : Exit Sub

        If ISUD7231PPP.Link_ISUD7231PPP(3, getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex),
                                         xStatus1, xStatus2, xStatus3, xStatus4, xStatus5, xStatus6, Me.Name) = False Then Exit Sub

        If LINE_MOVE_DISPLAY01() = False Then
            SPR_CLEAR(Vs1, Vs1.ActiveSheet.ActiveRowIndex, 0, Vs1.ActiveSheet.ActiveRowIndex, Vs1.ActiveSheet.ColumnCount)
            setData(Vs1, getColumIndex(Vs1, "NameSemiGroupMaterial"), Vs1.ActiveSheet.ActiveRowIndex, "[DELETED]", Color.Red)
        End If

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

        DS1 = PrcDS("USP_PFP72310_SEARCH_VS1_F1", cn, "*" & txt_Name.Data,
                                                    txt_cdLargeGroupMaterial.Data,
                                                    txt_cdSemiGroupMaterial.Data,
                                                    txt_cdDetailGroupMaterial.Data,
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
            Vs1.ActiveSheet.RowCount = 0
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "USP_PFP72310_SEARCH_VS1_F1", "Vs1")
        DATA_SEARCH01 = True

        Vs1.Enabled = True

    End Function

    Private Function LINE_MOVE_DISPLAY01() As Boolean
        LINE_MOVE_DISPLAY01 = False
        Try
            Dim RS01 As DataRow = Nothing
            DS1 = PrcDS("USP_PFP72310_SEARCH_VS1_LINE", cn, getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex))

            If GetDsRc(DS1) = 0 Then
                Exit Function
            End If
            READ_SPREAD(Vs1, DS1, "USP_PFP72310_SEARCH_VS1", "Vs1", Vs1.ActiveSheet.ActiveRowIndex)

            LINE_MOVE_DISPLAY01 = True

        Catch ex As Exception
            MsgBoxP("LINE_MOVE_DISPLAY01!")
        End Try
    End Function

#End Region

#Region "Spread"
    Private Sub vS1_GotFocus(sender As Object, e As EventArgs) Handles Vs1.GotFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False, WordConv("INPUT") & "(F5)", WordConv("SEARCH") & "(F6)", WordConv("UPDATE") & "(F7)", WordConv("DELETE") & "(F8)")

    End Sub

    Private Sub vS1_LostFocus(sender As Object, e As EventArgs) Handles Vs1.LostFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False, WordConv("INPUT") & "(F5)", WordConv("SEARCH") & "(F6)", WordConv("UPDATE") & "(F7)", WordConv("DELETE") & "(F8)")
    End Sub

    Private Sub vS1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        Call MAIN_JOB02()
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
        Call DATA_SEARCH01()
    End Sub

    Private Sub txt_cdLargeGroupMaterial_txtTextChange(sender As Object, e As EventArgs) Handles txt_cdLargeGroupMaterial.txtTextChange

        If txt_cdLargeGroupMaterial.Code = "" Then ChkCdLarge = False : ValueCdLarge = "" : Exit Sub
        ChkCdLarge = True : ValueCdLarge = txt_cdLargeGroupMaterial.Code : Exit Sub
    End Sub

#End Region

    Private Sub Cms_1_Click(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_1.ItemClicked

    End Sub
End Class