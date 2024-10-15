Public Class ISUD9900A
#Region "Variable"
    Private wJOB As Integer

    Private WRITE_CHK As String
    Private KEY_CHK As String

    Private W9900 As T9900_AREA
    Private L9900 As T9900_AREA

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD9900A(job As Integer, NotifySeting As String, NotifySetingSeq As String, Optional ByVal TAG As String = "") As Boolean
        D9900.NotifySeting = NotifySeting
        D9900.NotifySetingSeq = NotifySetingSeq

        wJOB = job : L9900 = D9900

        Link_ISUD9900A = False

        Select Case job
            Case 1
                If L9900.NotifySeting = System_Date_8() Then Exit Select

        End Select

        formA = False
        Me.Tag = TAG
        Me.ShowDialog()

        Link_ISUD9900A = isudCHK
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
                'Setfocus(txt_Name)
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

                txt_NotifySeting.Enabled = False

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
        If Pub.DEVCHK = "1" Then txt_NotifySeting.Enabled = True : txt_NotifySetingSeq.Enabled = True : Block1.Enabled = True

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Call D9900_CLEAR()

        If READ_PFK9900() = False Then wJOB = 1

        W9900 = D9900
        KEY_CHK = ""
    End Sub
    Private Sub FORM_INIT()

    End Sub
#End Region

#Region "Function"
    Private Function Data_Check() As Boolean
        Data_Check = False
        'If CInt(txt_BasicSel.Data) = 6 And IsNumeric(txt_BasicName.Data) = False Then MsgBoxP("Numeric only!") : Exit Function
        If TextCheck("1", txt_NotifySeting.Data, "Notify Setting") = False Then Exit Function

        If Trim$(txt_NotifySeting.Data) = "" Then
            Call MsgBoxP("148", "DATA_CHECK")
            Exit Function
        End If

        Data_Check = True
    End Function
    Private Sub DATA_MOVE()

        D9900.NotifySeting = txt_NotifySeting.Data
        D9900.NotifySetingSeq = txt_NotifySetingSeq.Data
        D9900.TimeStart = txt_TimeStart.Data
        D9900.TimeEnd = txt_TimeEnd.Data
        D9900.TimeRefresh = txt_TimeRefresh.Data
        D9900.DashboardUse = SetDashboardUse()

        If rad_CheckUse1.Checked = True Then D9900.CheckUse = "1"
        If rad_CheckUse2.Checked = True Then D9900.CheckUse = "2"

        W9900 = D9900

    End Sub
    Private Sub DATA_INSERT()

        Call DATA_MOVE()

        If READ_PFK9900(W9900.NotifySeting, W9900.NotifySetingSeq) = True Then
            Call MsgBoxP("294", "DATA_INSERT")
            'txt_Name.Focus()
            Call KEY_COUNT()
            Exit Sub
        End If

        D9900.DateCreate = System_Date_8()
        D9900.InchargeCreate = Pub.NAM

        If WRITE_PFK9900(W9900) = True Then isudCHK = True : WRITE_CHK = "*"

    End Sub
    Private Sub DATA_UPDATE()
        If Data_Check() = False Then Exit Sub
        Call DATA_MOVE()

        W9900.DateUpdate = System_Date_8()
        W9900.InchargeUpdate = Pub.NAM

        If Block1.Enabled = True Then
            If REWRITE_PFK9900(W9900) = True Then isudCHK = True
        Else
            If REWRITE_PFK9900(W9900) = True Then isudCHK = True
        End If

        Me.Dispose()

    End Sub

    Private Sub DATA_DELETE()
        If Pub.DEVCHK <> "1" Then MsgBoxP("DATA_DELETE", "003") : Exit Sub

        DATA_MOVE()
        If DELETE_PFK9900(W9900) = True Then isudCHK = True

        Me.Dispose()
    End Sub

    Private Sub KEY_COUNT()
        If KEY_CHK = "*" Then Exit Sub

        SQL = " SELECT MAX(CAST(K9900_NotifySetingSeq AS DECIMAL)) AS MAX_CODE FROM PFK9900 "
        SQL = SQL & " WHERE K9900_NotifySeting = '" & L9900.NotifySeting & "' "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            L9900.NotifySetingSeq = 1
        Else
            L9900.NotifySetingSeq = CInt(rd!MAX_CODE + 1)
        End If

        W9900.NotifySeting = L9900.NotifySeting
        W9900.NotifySetingSeq = L9900.NotifySetingSeq

        rd.Close()

        txt_NotifySeting.Data = W9900.NotifySeting
        txt_NotifySetingSeq.Data = W9900.NotifySetingSeq

    End Sub

    Private Function GetDashboardUse(DashboardUse As String)

        ckb_DashboardUse1.Checked = False
        ckb_DashboardUse2.Checked = False
        ckb_DashboardUse3.Checked = False
        ckb_DashboardUse4.Checked = False
        ckb_DashboardUse5.Checked = False
        ckb_DashboardUse6.Checked = False
        ckb_DashboardUse7.Checked = False
        ckb_DashboardUse8.Checked = False
        ckb_DashboardUse9.Checked = False
        ckb_DashboardUse10.Checked = False
        ckb_DashboardUse11.Checked = False
        ckb_DashboardUse12.Checked = False
        ckb_DashboardUse13.Checked = False
        ckb_DashboardUse14.Checked = False
        ckb_DashboardUse15.Checked = False
        ckb_DashboardUse16.Checked = False
        ckb_DashboardUse17.Checked = False
        ckb_DashboardUse18.Checked = False
        ckb_DashboardUse19.Checked = False
        ckb_DashboardUse20.Checked = False
        ckb_DashboardUse21.Checked = False
        ckb_DashboardUse22.Checked = False
        For Each item As String In DashboardUse.Split(" ")
            Select Case item
                Case "CuttingRD"
                    ckb_DashboardUse1.Checked = True
                Case "SitchingRD"
                    ckb_DashboardUse2.Checked = True
                Case "AssemblyRD"
                    ckb_DashboardUse3.Checked = True
                Case "TotailRD"
                    ckb_DashboardUse4.Checked = True
                Case "Cutting"
                    ckb_DashboardUse5.Checked = True
                Case "CuttingV2"
                    ckb_DashboardUse6.Checked = True
                Case "Stitching"
                    ckb_DashboardUse7.Checked = True
                Case "Assembly"
                    ckb_DashboardUse8.Checked = True
                Case "AssemblyTotail"
                    ckb_DashboardUse9.Checked = True
                Case "StitchingTotail"
                    ckb_DashboardUse10.Checked = True
                Case "OutsoleV1"
                    ckb_DashboardUse11.Checked = True
                Case "FootbedV1"
                    ckb_DashboardUse12.Checked = True
                Case "Stockfit"
                    ckb_DashboardUse13.Checked = True
                Case "SetBalance"
                    ckb_DashboardUse14.Checked = True
                Case "OSideV1"
                    ckb_DashboardUse15.Checked = True
                Case "OS3"
                    ckb_DashboardUse16.Checked = True
                Case "OSRuuber"
                    ckb_DashboardUse17.Checked = True
                Case "OSRuuber"
                    ckb_DashboardUse18.Checked = True
                Case "OSTotalV2"
                    ckb_DashboardUse19.Checked = True
                Case "OSTotalV4"
                    ckb_DashboardUse20.Checked = True
                Case "OSRuuber"
                    ckb_DashboardUse21.Checked = True
                Case "MaterialWHAmt"
                    ckb_DashboardUse22.Checked = True
                Case Else

            End Select
        Next


    End Function
    Private Function SetDashboardUse() As String
        SetDashboardUse = ""
        If ckb_DashboardUse1.Checked = True Then SetDashboardUse = SetDashboardUse & " CuttingRD"
        If ckb_DashboardUse2.Checked = True Then SetDashboardUse = SetDashboardUse & " SitchingRD"
        If ckb_DashboardUse3.Checked = True Then SetDashboardUse = SetDashboardUse & " AssemblyRD"
        If ckb_DashboardUse4.Checked = True Then SetDashboardUse = SetDashboardUse & " TotailRD"
        If ckb_DashboardUse5.Checked = True Then SetDashboardUse = SetDashboardUse & " Cutting"
        If ckb_DashboardUse6.Checked = True Then SetDashboardUse = SetDashboardUse & " CuttingV2"
        If ckb_DashboardUse7.Checked = True Then SetDashboardUse = SetDashboardUse & " Stitching"
        If ckb_DashboardUse8.Checked = True Then SetDashboardUse = SetDashboardUse & " Assembly"
        If ckb_DashboardUse9.Checked = True Then SetDashboardUse = SetDashboardUse & " AssemblyTotail"
        If ckb_DashboardUse10.Checked = True Then SetDashboardUse = SetDashboardUse & " StitchingTotail"
        If ckb_DashboardUse11.Checked = True Then SetDashboardUse = SetDashboardUse & " OutsoleV1"
        If ckb_DashboardUse12.Checked = True Then SetDashboardUse = SetDashboardUse & " FootbedV1"
        If ckb_DashboardUse13.Checked = True Then SetDashboardUse = SetDashboardUse & " Stockfit"
        If ckb_DashboardUse14.Checked = True Then SetDashboardUse = SetDashboardUse & " SetBalance"
        If ckb_DashboardUse15.Checked = True Then SetDashboardUse = SetDashboardUse & " OSideV1"
        If ckb_DashboardUse16.Checked = True Then SetDashboardUse = SetDashboardUse & " OS3"
        If ckb_DashboardUse17.Checked = True Then SetDashboardUse = SetDashboardUse & " OSRuuber"
        If ckb_DashboardUse18.Checked = True Then SetDashboardUse = SetDashboardUse & " OSRuuber"
        If ckb_DashboardUse19.Checked = True Then SetDashboardUse = SetDashboardUse & " OSTotalV2"
        If ckb_DashboardUse20.Checked = True Then SetDashboardUse = SetDashboardUse & " OSTotalV4"
        If ckb_DashboardUse21.Checked = True Then SetDashboardUse = SetDashboardUse & " OSRuuber"
        If ckb_DashboardUse22.Checked = True Then SetDashboardUse = SetDashboardUse & " MaterialWHAmt"

        SetDashboardUse = SetDashboardUse.Trim

    End Function



#End Region

#Region "DATA_SEARCH"
    Private Function DATA_SEARCH01() As Boolean

        DATA_SEARCH01 = False

        READ_PFK9900()

        txt_NotifySeting.Data = D9900.NotifySeting
        txt_NotifySetingSeq.Data = D9900.NotifySetingSeq
        txt_TimeStart.Data = D9900.TimeStart
        txt_TimeEnd.Data = D9900.TimeEnd
        txt_TimeRefresh.Data = D9900.TimeRefresh


        If D9900.CheckUse = "1" Then rad_CheckUse1.Checked = True
        If D9900.CheckUse = "2" Then rad_CheckUse2.Checked = True

        GetDashboardUse(D9900.DashboardUse)

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
                'txt_Name.Focus()
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