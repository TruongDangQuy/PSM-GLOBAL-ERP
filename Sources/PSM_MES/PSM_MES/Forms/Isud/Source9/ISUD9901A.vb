Public Class ISUD9901A

#Region "Variable"
    Private wJOB As Integer

    Private WRITE_CHK As String
    Private KEY_CHK As String

    Private W9901 As T9901_AREA
    Private L9901 As T9901_AREA

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD9901A(job As Integer, NotifyCate As String, NotifyCateSeq As String, Optional ByVal TAG As String = "") As Boolean
        D9901.NotifyCate = NotifyCate
        D9901.NotifyCateSeq = NotifyCateSeq

        wJOB = job : L9901 = D9901

        Link_ISUD9901A = False

        Select Case job
            Case 1
                If L9901.NotifyCate = System_Date_8() Then Exit Select

        End Select

        formA = False
        Me.Tag = TAG
        Me.ShowDialog()

        Link_ISUD9901A = isudCHK
    End Function
#End Region

#Region "Form_Load"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub
        'Me.Form_Initial()
        'Me.Form_KeyDown()

        WRITE_CHK = ""
        Call DATA_INIT()
        Call FORM_INIT()

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        Block1.Enabled = False

        Select Case wJOB
            Case 1
                Me.Text = Me.Text & " - INSERT"

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                rad_CheckUse1.Checked = True
                tst_iDelete.Visible = False


                Call KEY_COUNT()
                Setfocus(txt_Name)
            Case 2
                Me.Text = Me.Text & " - SEARCH"

                frm_Condition.Enabled = False
                tst_iDelete.Visible = False

                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()

            Case 3
                Me.Text = Me.Text & " - UPDATE"

                txt_NotifyCate.Enabled = False

                If Pub.DEVCHK <> "1" Then tst_iDelete.Visible = False

                Call DATA_SEARCH01()

                If CHK(3) <> "1" Then
                    If CHK(2) <> "1" Then
                        isudCHK = False
                        formA = True
                        Me.Dispose()
                        Call MsgBoxP("You have no right is this program !")
                        Exit Sub
                    Else
                        Me.Text = Me.Text & " - SEARCH"
                        isudCHK = False
                        formA = True
                        wJOB = 2
                        frm_Condition.Enabled = False
                        tst_iDelete.Visible = False
                        Call MsgBoxP("Only Search !") : tst_iSave.Visible = False
                    End If
                End If

            Case 4
                Me.Text = Me.Text & " - DELETE"
                tst_iDelete.Visible = True
                frm_Condition.Enabled = False

                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()

        End Select
        If Pub.DEVCHK = "1" Then txt_NotifyCate.Enabled = True : txt_NotifyCateSeq.Enabled = True : Block1.Enabled = True

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Call D9901_CLEAR()

        W9901 = D9901
        KEY_CHK = ""
    End Sub
    Private Sub FORM_INIT()

    End Sub
#End Region

#Region "Function"
    Private Function Data_Check() As Boolean
        Data_Check = False
        'If CInt(txt_BasicSel.Data) = 6 And IsNumeric(txt_BasicName.Data) = False Then MsgBoxP("Numeric only!") : Exit Function
        If TextCheck("1", txt_NotifyCate.Data, "Notify Cate") = False Then Exit Function

        If Trim$(txt_Name.Data) = "" Then
            Call MsgBoxP("148", "DATA_CHECK")
            Exit Function
        End If

        Data_Check = True
    End Function
    Private Sub DATA_MOVE()

        D9901.NotifyCate = txt_NotifyCate.Data
        D9901.NotifyCateSeq = txt_NotifyCateSeq.Data
        D9901.DSeq = txt_Dseq.Data
        D9901.Name = txt_Name.Data

        If rad_CheckUse1.Checked = True Then W9901.CheckUse = "1"
        If rad_CheckUse2.Checked = True Then W9901.CheckUse = "2"

        W9901 = D9901

    End Sub
    Private Sub DATA_INSERT()

        Call DATA_MOVE()

        If READ_PFK9901(W9901.NotifyCate, W9901.NotifyCateSeq) = True Then
            Call MsgBoxP("294", "DATA_INSERT")
            txt_Name.Focus()
            Call KEY_COUNT()
            Exit Sub
        End If

        D9901.DateCreate = System_Date_8()
        D9901.InchargeCreate = Pub.DAT

        If WRITE_PFK9901(W9901) = True Then isudCHK = True : WRITE_CHK = "*"

    End Sub
    Private Sub DATA_UPDATE()
        If Data_Check() = False Then Exit Sub
        Call DATA_MOVE()

        D9901.DateUpdate = System_Date_8()
        D9901.InchargeUpdate = Pub.DAT

        If Block1.Enabled = True Then
            If REWRITE_PFK9901(W9901) = True Then isudCHK = True
        Else
            If REWRITE_PFK9901(W9901) = True Then isudCHK = True
        End If

        Me.Dispose()

    End Sub

    Private Sub DATA_DELETE()
        If Pub.DEVCHK <> "1" Then MsgBoxP("DATA_DELETE", "003") : Exit Sub

        DATA_MOVE()
        If DELETE_PFK9901(W9901) = True Then isudCHK = True

        Me.Dispose()
    End Sub

    Private Sub KEY_COUNT()
        If KEY_CHK = "*" Then Exit Sub

        SQL = " SELECT MAX(CAST(K9901_NotifyCateSeq AS DECIMAL)) AS MAX_CODE FROM PFK9901 "
        SQL = SQL & " WHERE K9901_NotifyCate = '" & L9901.NotifyCate & "' "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            L9901.NotifyCateSeq = 1
        Else
            L9901.NotifyCateSeq = CInt(rd!MAX_CODE + 1)
        End If

        W9901.NotifyCate = L9901.NotifyCate
        W9901.NotifyCateSeq = L9901.NotifyCateSeq

        rd.Close()

        txt_NotifyCate.Data = W9901.NotifyCate
        txt_NotifyCateSeq.Data = W9901.NotifyCateSeq

    End Sub

#End Region

#Region "DATA_SEARCH"
    Private Function DATA_SEARCH01() As Boolean

        DATA_SEARCH01 = False

        READ_PFK9901(L9901.NotifyCate, L9901.NotifyCateSeq)

        txt_NotifyCate.Data = D9901.NotifyCate
        txt_NotifyCateSeq.Data = D9901.NotifyCateSeq
        txt_Dseq.Data = D9901.DSeq
        txt_Name.Data = D9901.Name

        If W9901.CheckUse = "1" Then rad_CheckUse1.Checked = True
        If W9901.CheckUse = "2" Then rad_CheckUse2.Checked = True

        DATA_SEARCH01 = True

    End Function
#End Region

#Region "Event"
    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        Select Case wJOB
            Case 1
                If Data_Check() = False Then Exit Sub
                Call DATA_INSERT()
                Me.Form_Initial()
                Call FORM_INIT()
                Call DATA_INIT()
                Call KEY_COUNT()
                txt_Name.Focus()
            Case 2
                Me.Dispose()
            Case 3
                Call DATA_UPDATE()
            Case 4
                Call DATA_DELETE()
        End Select
    End Sub
    Private Sub tst_iClose_Click(sender As Object, e As EventArgs) Handles tst_iClose.Click
        If WRITE_CHK = "*" Then
            isudCHK = True
        Else
            isudCHK = False
        End If

        Me.Dispose()
    End Sub
    Private Sub tst_iDelete_Click(sender As Object, e As EventArgs) Handles tst_iDelete.Click
        Dim Msg_Result As String

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        If CHK(4) <> "1" Then
            Call MsgBoxP("4", "tst_iDelete_Click")
            Exit Sub
        End If

        If MsgBoxP("Do you want to delete", vbYesNo) <> vbYes Then Exit Sub

        Call DATA_DELETE()
    End Sub

#End Region

End Class