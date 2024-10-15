Public Class ISUD9222A

    Private wJOB As Integer

    Private WRITE_CHK As Boolean
    Private FIRST_LINE_CHK As Boolean

    Private privS1_SCOL As Integer

    Private Dsu01 As Integer
    Private Dsu02 As Integer
    Private Dsu04 As Integer


    Private W9222 As T9222_AREA
    Private M9222 As T9222_AREA
    Private L9222 As T9222_AREA

    Private priJOB_CHK As String

    Private CHK(0 To 5) As String


    Private loop_check As Boolean
    Private formA As Boolean

    Public Function Link_ISUD9222A(job As Integer, cdInchargePSM As String, DatePlan As String, Optional FormName As String = "") As Boolean
        Me.Tag = FormName
        On Error GoTo Error_Message

        D9222.cdInchargePSM = cdInchargePSM : D9222.DatePlan = DatePlan
        wJOB = job : L9222 = D9222 : L9222 = D9222

        formA = False
        Link_ISUD9222A = False

        Select Case wJOB
            Case "1", "11"
            Case Else


                If D9222.DatePlan > Pub.DAT Then wJOB = 2

        End Select

        Me.ShowDialog()

        Link_ISUD9222A = isudCHK

        Exit Function
Error_Message:
        Call Error_Message("37", WordConv("Link_ISUD9222A"))
    End Function

    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        Me.Form_KeyDown()


        Call FORM_INIT()
        Call DATA_INIT()

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        Select Case wJOB
            Case 1
                Me.Text = Me.Text & " - INSERT"
                priJOB_CHK = "INSERT"

                cmd_DEL.Visible = False

                Setfocus(txt_DatePlan)

            Case 2
                Me.Text = Me.Text & " - SEARCH"

                Frm_MAIN_HEAD.Enabled = False

                If HEAD_SEARCH() = True Then

                    If DATA_SEARCH_VS1() = True Then Call HEAD_SEARCH_DATE_TOTAL()
                End If

                cmd_DEL.Visible = False
                cmd_OK.Visible = False

                Setfocus(cmd_Cancel)

            Case 3
                Me.Text = Me.Text & " - UPDATE"

                priJOB_CHK = "UPDATE"

                If HEAD_SEARCH() = True Then

                    If DATA_SEARCH_VS1() = True Then Call HEAD_SEARCH_DATE_TOTAL()
                End If

                Frm_MAIN_HEAD.Enabled = True


                Setfocus(cmd_OK)

            Case 4
                Me.Text = Me.Text & " - DELETE"

                If HEAD_SEARCH() = True Then

                    If DATA_SEARCH_VS1() = True Then Call HEAD_SEARCH_DATE_TOTAL()
                End If

                Frm_MAIN_HEAD.Enabled = False
                Frm_MAIN_HEAD.Enabled = False


                cmd_DEL.Visible = True
                cmd_OK.Visible = False

                cmd_Cancel.Select()

            Case 11
                Me.Text = Me.Text & " - COPY"

                If HEAD_SEARCH() = True Then
                    If DATA_SEARCH_VS1() = True Then Call HEAD_SEARCH_DATE_TOTAL()
                End If

                Frm_MAIN_HEAD.Enabled = True

                cmd_DEL.Visible = False

                cmd_OK.Select()

        End Select

        formA = True
    End Sub


    Private Sub FORM_INIT()
        FIRST_LINE_CHK = False

        txt_DatePlan.Data = "" : txt_DatePlan.Data = ""

        txt_cdInchargePSM.Data = "" : txt_cdInchargePSM.Code = ""
        txt_Remark.Data = "" : txt_Remark.Code = ""
        opt_InchargeSelect0.Checked = True
    End Sub

    Private Sub DATA_INIT()
        If wJOB = "1" Then
            txt_DatePlan.Data = Pub.DAT
            txt_DatePlan.Data = Pub.DAT

            L9222.DatePlan = Pub.DAT
            L9222.DatePlan = Pub.DAT

        End If
        vS1.AllowRowMove = True

        WRITE_CHK = False
    End Sub

    Private Function HEAD_SEARCH() As Boolean
        HEAD_SEARCH = False

        HEAD_SEARCH = True
    End Function

    Private Function HEAD_SEARCH_SANO(tmpcdInchargePSM As String, tmpcdSubProcess As String, tmpDatePlan As String, tmpcdLineProd As String, tmpSeqJob As String) As Boolean
        HEAD_SEARCH_SANO = False

        HEAD_SEARCH_SANO = True

    End Function

    Private Function HEAD_SEARCH_DATE_TOTAL() As Boolean
        HEAD_SEARCH_DATE_TOTAL = False

        DS1 = PrcDS("USP_ISUD9222A_SEARCH_HEAD_TOTAL", cn, L9222.cdInchargePSM, L9222.DatePlan)

        If GetDsRc(DS1) = 0 Then
            Exit Function
            isudCHK = False
        End If

        HEAD_SEARCH_DATE_TOTAL = True
    End Function


    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False
        Try
            Dim i As Integer

            DS1 = PrcDS("USP_ISUD9222A_SEARCH_VS1", cn, L9222.cdInchargePSM, L9222.DatePlan)
            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS1, DS1, "USP_ISUD9222A_SEARCH_VS1", "Vs1")
                vS1.ActiveSheet.RowCount = 1
                Vs1.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS1, DS1, "USP_ISUD9222A_SEARCH_VS1", "Vs1")

            DATA_SEARCH_VS1 = True

        Catch ex As Exception

        End Try
    End Function


    Private Function KEY_COUNT() As Boolean
      
    End Function

    Private Sub DATA_MOVE_WRITE()

        Call D9222_CLEAR() : M9222 = D9222

        L9222.cdInchargePSM = W9222.cdInchargePSM
        L9222.DatePlan = W9222.DatePlan

    End Sub


    Private Function DATA_MOVE_COPY_WRITE() As Boolean

        DATA_MOVE_COPY_WRITE = False

        DATA_MOVE_COPY_WRITE = True

    End Function



    Private Sub DATA_INSERT()
        If DataCheck = False Then Exit Sub

        Call DATA_MOVE_WRITE()
        txt_Remark.Data = "" : txt_Remark.Code = ""

        opt_InchargeSelect0.Checked = True

        Call KEY_COUNT()

        Call HEAD_SEARCH_DATE_TOTAL()


    End Sub


    Private Sub DATA_INSERT_COPY()
        If DataCheck = False Then Exit Sub

        If DATA_MOVE_COPY_WRITE = False Then Exit Sub

        If HEAD_SEARCH = True Then
            If DATA_SEARCH_VS1 = True Then Call HEAD_SEARCH_DATE_TOTAL()
        End If


        wJOB = 3

        Frm_MAIN_HEAD.Enabled = True

        opt_InchargeSelect0.Checked = True

        Call KEY_COUNT()

    End Sub

    Private Sub DATA_UPDATE()
        If DataCheck = False Then Exit Sub

        Call DATA_MOVE_WRITE()
        txt_Remark.Data = "" : txt_Remark.Code = ""

        opt_InchargeSelect0.Checked = True

        Call KEY_COUNT()

        Call HEAD_SEARCH_DATE_TOTAL()

        isudCHK = WRITE_CHK
    End Sub

    Private Sub DATA_DELETE()
        WRITE_CHK = False

        '

        SQL = " DELETE FROM PFK9222 "
        SQL = SQL & " WHERE K9222_cdInchargePSM         = '" & W9222.cdInchargePSM & "' "
        SQL = SQL & "   AND K9222_DatePlan       = '" & W9222.DatePlan & "' "

        cmd = New SqlClient.SqlCommand(SQL, cn) : cmd.ExecuteNonQuery()


        WRITE_CHK = True
        isudCHK = WRITE_CHK

    End Sub


    Private Function DataCheck() As Boolean
        DataCheck = False
        If txt_cdInchargePSM.Code = "" Then MsgBoxP("cdInchargePSM Please!") : Exit Function

        If Trim$(txt_DatePlan.Data) = "" Then txt_DatePlan.Data = ""

        DataCheck = True
    End Function

    Private Function DATA_CONDITION_CHK() As Boolean
        DATA_CONDITION_CHK = False


        DATA_CONDITION_CHK = True

    End Function

    Private Function DATA_PERSON_FORMATION_CHK() As Boolean
        DATA_PERSON_FORMATION_CHK = False

        W9222.cdInchargePSM = FormatP(txt_cdInchargePSM.Code, "000")
        W9222.DatePlan = Replace(txt_DatePlan.Data, "/", "")


        SQL = " SELECT * FROM PFK9222 "
        SQL = SQL & " WHERE K9222_cdInchargePSM            = '" & W9222.cdInchargePSM & "' "
        SQL = SQL & "   AND K9222_DatePlan          = '" & W9222.DatePlan & "' "
        rd = New SqlClient.SqlCommand(SQL, cn).ExecuteReader

        If rd.HasRows = True Then
            Call Error_Message("13", WordConv("SANO"))

            rd.Close()
            Exit Function
        End If

        rd.Close()

        DATA_PERSON_FORMATION_CHK = True

    End Function


    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Select Case wJOB
            Case 1
                Call KEY_COUNT()
                Call DATA_INSERT() '

                priJOB_CHK = "INSERT"
                FIRST_LINE_CHK = True

            Case 2 : Me.Dispose()
            Case 3
                Call DATA_UPDATE() '
                priJOB_CHK = "UPDATE"
            Case 11
                Call DATA_INSERT_COPY()
                If WRITE_CHK = True Then
                    priJOB_CHK = "UPDATE"
                    FIRST_LINE_CHK = False
                Else

                End If

        End Select
    End Sub

    Private Sub cmd_DEL_Click(sender As Object, e As EventArgs) Handles cmd_DEL.Click
        Call Select_Message("5", "Cmd_Del_Click", "2")
        If Msg_Result = vbNo Then Exit Sub

        SQL = " DELETE FROM PFK9222 "
        SQL = SQL & " WHERE K9222_cdInchargePSM         = '" & txt_cdInchargePSM.Code & "' "
        SQL = SQL & "   AND K9222_DatePlan       = '" & txt_DatePlan.Code & "' "

        cmd = New SqlClient.SqlCommand(SQL, cn) : cmd.ExecuteNonQuery()

    End Sub

    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        If loop_check = True Then
            Call Select_Message("38", "Cmd_Del_Click", "2")
            If Msg_Result = vbNo Then Exit Sub
        End If

        If WRITE_CHK = True Then
            isudCHK = True
        Else
            isudCHK = False
        End If

        Me.Dispose()
    End Sub

    Private Sub vS1_DblClick(sender As Object, e As CellClickEventArgs) Handles vS1.CellClick

        L9222.cdInchargePSM = getData(vS1, getColumIndex(vS1, "KEY_cdInchargePSM"), e.Row)
        L9222.DatePlan = getData(vS1, getColumIndex(vS1, "KEY_DatePlan"), e.Row)
      
        If L9222.cdInchargePSM = "" Then

            Exit Sub
        End If

        priJOB_CHK = "UPDATE"
    End Sub

    Private Sub vS1_Click(sender As Object, e As CellClickEventArgs) Handles vS1.CellClick

        L9222.cdInchargePSM = getData(vS1, getColumIndex(vS1, "cdInchargePSM"), e.Row)
        L9222.DatePlan = getData(vS1, getColumIndex(vS1, "DatePlan"), e.Row)

        txt_cdInchargePSM.Code = L9222.cdInchargePSM

        If L9222.cdInchargePSM = "" Then Exit Sub

        priJOB_CHK = "UPDATE"

    End Sub

    Private Sub vS1_KeyDown(sender As Object, e As KeyEventArgs) Handles vS1.KeyDown
        Dim xCOL As Integer
        Dim xRow As Integer

        xCOL = vS1.ActiveSheet.ActiveColumnIndex
        xRow = vS1.ActiveSheet.ActiveRowIndex


        Select Case e.KeyCode

            Case Keys.Insert
                If xRow = vS1.ActiveSheet.RowCount - 1 Then
                    vS1.ActiveSheet.RowCount += 1
                    vS1.ActiveSheet.ActiveRowIndex = xRow + 1

                    setData(vS1, getColumIndex(vS1, "cdLineProd"), xRow + 1, vS1.ActiveSheet.ActiveRowIndex)

                    priJOB_CHK = "INSERT"

                    Call KEY_COUNT()
                    txt_Remark.Data = "" : txt_Remark.Data = ""
                    opt_InchargeSelect0.Checked = True



                Else
                    vS1.ActiveSheet.AddRows(xRow + 1, 1)
                    vS1.ActiveSheet.ActiveRowIndex = xRow + 1
                    priJOB_CHK = "INSERT"
                    setData(vS1, getColumIndex(vS1, "cdLineProd_NAME"), xRow + 1, vS1.ActiveSheet.ActiveRowIndex)

                    Call KEY_COUNT()

                    txt_Remark.Data = 0 : txt_Remark.Data = 0
                    opt_InchargeSelect0.Checked = True

                End If

                vS1.ActiveSheet.AddSelection(vS1.ActiveSheet.ActiveRowIndex, 0, 1, 1)
            Case Keys.Delete

                If getData(vS1, getColumIndex(vS1, "DatePlan"), xRow) <> "" Then
                    Call Select_Message("3", WordConv("BARCODE"), 2)

                    If Msg_Result = vbNo Then Exit Sub

                    W9222.cdInchargePSM = getData(vS1, getColumIndex(vS1, "cdInchargePSM"), xRow)
                    W9222.DatePlan = Replace(getData(vS1, getColumIndex(vS1, "DatePlan"), xRow), "/", "")

                    If Trim(W9222.DatePlan) = "" Then Exit Sub

                    Call SPR_DEL(vS1, xCOL, xRow)
                Else
                    Call SPR_DEL(vS1, xCOL, xRow)

                End If

            Case Keys.Enter

        End Select
    End Sub


    Private Sub txt_QtyRateSecondJob_txtTextKeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            cmd_OK.Select()
            cmd_OK.Focus()
        End If
    End Sub

    Private Sub cmd_Reup_Click(sender As Object, e As EventArgs) Handles cmd_Reup.Click
        Call DATA_SEARCH_VS1()
    End Sub
End Class