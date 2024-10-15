Public Class PFP72318

#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Private Form_Close As Boolean
#End Region

#Region "Form Load - Toolstrip"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False, WordConv("INPUT") & "(F5)")
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

        DS1 = PrcDS("USP_PFP72318_SEARCH_VS1", cn, txt_cdSite.Code, "*" & txt_Name.Data)

        If GetDsRc(DS1) = 0 Then
            Vs1.Enabled = True
            SPR_PRO_NEW(Vs1, DS1, "USP_PFP72318_SEARCH_VS1", "Vs1")
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "USP_PFP72318_SEARCH_VS1", "Vs1")
        DATA_SEARCH01 = True

        Vs1.Enabled = True

    End Function

    Private Function LINE_MOVE_DISPLAY01() As Boolean
        LINE_MOVE_DISPLAY01 = False
        Try
            Dim RS01 As DataRow = Nothing
            DS1 = PrcDS("USP_PFP72318_SEARCH_VS1_LINE", cn, getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex))

            If GetDsRc(DS1) = 0 Then
                Exit Function
            End If
            READ_SPREAD(Vs1, DS1, "USP_PFP72318_SEARCH_VS1", "Vs1", Vs1.ActiveSheet.ActiveRowIndex)

            LINE_MOVE_DISPLAY01 = True

        Catch ex As Exception
            MsgBoxP("LINE_MOVE_DISPLAY01!")
        End Try
    End Function

#End Region

#Region "Spread"

    Private Sub Vs1_Change(sender As Object, e As ChangeEventArgs) Handles Vs1.Change
        Try
            Select Case e.Column
                Case getColumIndex(Vs1, "ExportCode"), getColumIndex(Vs1, "ExportName"), getColumIndex(Vs1, "RemarkTrading")
                    If READ_PFK1312(getData(Vs1, getColumIndex(Vs1, "Key_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex), getData(Vs1, getColumIndex(Vs1, "Key_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex)) Then

                        D1312.ExportCode = getData(Vs1, getColumIndex(Vs1, "ExportCode"), Vs1.ActiveSheet.ActiveRowIndex)
                        D1312.ExportName = getData(Vs1, getColumIndex(Vs1, "ExportName"), Vs1.ActiveSheet.ActiveRowIndex)
                        D1312.RemarkTrading = getData(Vs1, getColumIndex(Vs1, "RemarkTrading"), Vs1.ActiveSheet.ActiveRowIndex)

                        Call REWRITE_PFK1312(D1312)

                    End If
                Case getColumIndex(Vs1, "ProductCode")
                    If READ_PFK7106(getData(Vs1, getColumIndex(Vs1, "Key_ShoesCode"), Vs1.ActiveSheet.ActiveRowIndex)) Then

                        D7106.ProductCode = getData(Vs1, getColumIndex(Vs1, "ProductCode"), Vs1.ActiveSheet.ActiveRowIndex)

                        Call REWRITE_PFK7106(D7106)
                    End If
            End Select

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Vs1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown
        Try

            If e.KeyCode = Keys.Enter Then
                If READ_PFK1312(getData(Vs1, getColumIndex(Vs1, "Key_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex), getData(Vs1, getColumIndex(Vs1, "Key_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex)) Then

                    D1312.ExportCode = getData(Vs1, getColumIndex(Vs1, "ExportCode"), Vs1.ActiveSheet.ActiveRowIndex)
                    D1312.ExportName = getData(Vs1, getColumIndex(Vs1, "ExportName"), Vs1.ActiveSheet.ActiveRowIndex)
                    D1312.RemarkTrading = getData(Vs1, getColumIndex(Vs1, "RemarkTrading"), Vs1.ActiveSheet.ActiveRowIndex)

                    Call REWRITE_PFK1312(D1312)

                End If
            End If

        Catch ex As Exception

        End Try
    End Sub


#End Region

#Region "Event"
    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        Call DATA_SEARCH01()
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

                    If READ_PFK1312(getData(Vs1, getColumIndex(Vs1, "Key_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex), getData(Vs1, getColumIndex(Vs1, "Key_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex)) Then

                        D1312.ExportCode = getData(Vs1, getColumIndex(Vs1, "ExportCode"), Vs1.ActiveSheet.ActiveRowIndex)
                        D1312.ExportName = getData(Vs1, getColumIndex(Vs1, "ExportName"), Vs1.ActiveSheet.ActiveRowIndex)
                        D1312.RemarkTrading = getData(Vs1, getColumIndex(Vs1, "RemarkTrading"), Vs1.ActiveSheet.ActiveRowIndex)

                        Call REWRITE_PFK1312(D1312)

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