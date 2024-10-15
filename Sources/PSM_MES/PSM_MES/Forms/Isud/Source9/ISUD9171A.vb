Public Class ISUD9171A

#Region "Variable"
    Private wJOB As Integer

    Private WRITE_CHK As String
    Private KEY_CHK As String

    Private W9171 As T9171_AREA
    Private L9171 As T9171_AREA

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD9171A(job As Integer, BasicSel As String, BasicCode As String, Optional ByVal TAG As String = "") As Boolean
        D9171.BasicSel = BasicSel
        D9171.BasicCode = BasicCode

        wJOB = job : L9171 = D9171

        Link_ISUD9171A = False

        Select Case job
            Case 1
                If BasicCode = "001" Then Exit Select

        End Select

        If BasicSel <> "000" Then txt_NameHLPButton.Visible = False Else txt_NameHLPButton.Visible = True


        formA = False
        Me.Tag = TAG
        Me.ShowDialog()

        Link_ISUD9171A = isudCHK
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

        Call READ_PFK9171("000", L9171.BasicSel)
        txt_Selremark.Data = D9171.Remark

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

                Call READ_PFK9171("000", L9171.BasicCode)

                rad_CheckUse1.Checked = True
                tst_iDelete.Visible = False

                Call KEY_COUNT()
                Setfocus(txt_BasicName)
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

                txt_BasicSel.Enabled = False

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
        If Pub.DEVCHK = "1" Then txt_BasicSel.Enabled = True : txt_BasicCode.Enabled = True : Block1.Enabled = True

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Call D9171_CLEAR()

        W9171 = D9171
        KEY_CHK = ""
    End Sub
    Private Sub FORM_INIT()
        DisplaySeq.Tag = L9171.BasicSel
    End Sub
#End Region

#Region "Function"
    Private Function Data_Check() As Boolean
        Data_Check = False
        'If CInt(txt_BasicSel.Data) = 6 And IsNumeric(txt_BasicName.Data) = False Then MsgBoxP("Numeric only!") : Exit Function
        If TextCheck("1", txt_BasicSel.Data, "BASIC CODE") = False Then Exit Function

        If Trim$(txt_BasicName.Data) = "" Then
            Call MsgBoxP("148", "DATA_CHECK")
            Exit Function
        End If

        Data_Check = True
    End Function
    Private Sub DATA_MOVE()

        W9171.BasicSel = Format(CInt(txt_BasicSel.Data), "000")
        W9171.BasicCode = Format(CInt(txt_BasicCode.Data), "000")

        W9171.selBasicMaster = txt_selBasicMaster.Code
        W9171.cdBasicMaster = txt_cdBasicMaster.Code
        'If CInt(txt_BasicSel.Data) = 6 And IsNumeric(txt_BasicName.Data) = False Then MsgBoxP("Numeric only!") : Exit Sub

        W9171.BasicName = Trim$(txt_BasicName.Data)
        W9171.ForeignName1 = Trim$(txt_ForeignName1.Data)
        W9171.ForeignName2 = Trim$(txt_ForeignName2.Data)
        W9171.NameSimply = Trim$(txt_NameSimply.Data)

        W9171.DevelopmentCode = Trim$(txt_DevelopmentCode.Data)
        'W9171.DevelopmentCodeP = Trim$(txt_DevelopmentCodeP.Data)

        W9171.Check1 = Trim$(check1.Data)
        W9171.Check2 = Trim$(check2.Data)
        W9171.Check3 = Trim$(check3.Data)
        W9171.Check4 = Trim$(check4.Data)
        W9171.Check5 = Trim$(check5.Data)
        W9171.Check6 = Trim$(check6.Data)
        W9171.Check7 = Trim$(check7.Data)
        W9171.Check8 = Trim$(check8.Data)
        W9171.Check9 = Trim$(check9.Data)
        W9171.Check10 = Trim$(check10.Data)

        W9171.CheckName1 = Checkname1.Data
        W9171.CheckName2 = Checkname2.Data
        W9171.CheckName3 = Checkname3.Data
        W9171.CheckName4 = Checkname4.Data
        W9171.CheckName5 = Checkname5.Data
        W9171.CheckName6 = Checkname6.Data
        W9171.CheckName7 = Checkname7.Data
        W9171.CheckName8 = Checkname8.Data
        W9171.CheckName9 = Checkname9.Data
        W9171.CheckName10 = Checkname10.Data

        W9171.Remark = txt_remark.Data

        If rad_CheckUse1.Checked = True Then W9171.CheckUse = "1"
        If rad_CheckUse2.Checked = True Then W9171.CheckUse = "2"

        W9171.BasicName = Replace(W9171.BasicName, "'", "`")
        W9171.ForeignName1 = Replace(W9171.ForeignName1, "'", "`")
        W9171.ForeignName2 = Replace(W9171.ForeignName2, "'", "`")
        W9171.NameSimply = Replace(W9171.NameSimply, "'", "`")

        W9171.NameHLPButton = Trim$(txt_NameHLPButton.Data)

        W9171.DisplaySeq = CIntp(DisplaySeq.Data)

    End Sub
    Private Sub DATA_INSERT()

        Call DATA_MOVE()

        If READ_PFK9171(W9171.BasicSel, W9171.BasicCode) = True Then
            Call MsgBoxP("294", "DATA_INSERT")
            txt_BasicSel.Focus()
            Call KEY_COUNT()
            Exit Sub
        End If


        W9171.DateInsert = Pub.DAT
        W9171.TimeInsert = System_Date_time()
        W9171.DisplaySeq = CIntp(W9171.BasicCode)

        If WRITE_PFK9171(W9171) = True Then isudCHK = True : WRITE_CHK = "*"

    End Sub
    Private Sub DATA_UPDATE()
        If Data_Check() = False Then Exit Sub
        Call DATA_MOVE()

        W9171.DateUpdate = Pub.DAT
        W9171.TimeUpdate = System_Date_time()

        If Block1.Enabled = True Then
            If REWRITE_PFK9171(W9171) = True Then isudCHK = True
        Else
            If REWRITE_PFK9171(W9171) = True Then isudCHK = True
        End If

        Me.Dispose()

    End Sub

    Private Sub DATA_DELETE()
        If Pub.DEVCHK <> "1" Then MsgBoxP("DATA_DELETE", "003") : Exit Sub

        DATA_MOVE()
        If DELETE_PFK9171(W9171) = True Then isudCHK = True

        Me.Dispose()
    End Sub

    Private Sub KEY_COUNT()
        If KEY_CHK = "*" Then Exit Sub

        SQL = " SELECT MAX(CAST(K9171_BasicCode AS DECIMAL)) AS MAX_CODE FROM PFK9171 "
        SQL = SQL & " WHERE K9171_BasicSel = '" & L9171.BasicSel & "' "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            L9171.BasicCode = "001"
        Else
            L9171.BasicCode = Format(CInt(rd!MAX_CODE + 1), "000")
        End If

        W9171.BasicSel = L9171.BasicSel
        W9171.BasicCode = L9171.BasicCode

        rd.Close()

        If Val(W9171.BasicCode) > 999 Then
            Call MsgBoxP("316", "KEY_COUNT")
            txt_BasicSel.Focus() : Exit Sub
        End If

        txt_BasicSel.Data = W9171.BasicSel
        txt_BasicCode.Data = W9171.BasicCode

    End Sub

#End Region

#Region "DATA_SEARCH"
    Private Function DATA_SEARCH01() As Boolean

        DATA_SEARCH01 = False

        rd = PrcDR("USP_PFP91710_SEARCH_vS2_LINE", cn, L9171.BasicSel, L9171.BasicCode)
        rd.Read()
        If rd.HasRows = False Then
            rd.Close() : isudCHK = False
            Me.Dispose() : Exit Function
        End If

        ' Call K9171_MOVE(rd) : W9171 = D9171
        'rd.Close()
        'Call READ_PFK9171("000", W9171.BasicSel)
        'DisplaySeq.Data = Trim$(D9171.BasicName)

        txt_BasicSel.Data = rd("BasicSel")
        txt_BasicCode.Data = rd("BasicCode")
        txt_BasicName.Data = rd("BasicName")
        txt_ForeignName1.Data = rd("ForeignName1")
        txt_ForeignName2.Data = rd("ForeignName2")
        txt_NameSimply.Data = rd("NameSimply")

        txt_NameHLPButton.Data = rd("NameHLPButton")

        '   txt_DevelopmentCode.Data = rd("DevelopmentCode")
        'txt_DevelopmentCodeP.Data = rd("DevelopmentCodeP

        Check1.Data = rd("Check1")
        Check2.Data = rd("Check2")
        Check3.Data = rd("Check3")
        Check4.Data = rd("Check4")
        Check5.Data = rd("Check5")
        Check6.Data = rd("Check6")
        Check7.Data = rd("Check7")
        Check8.Data = rd("Check8")
        Check9.Data = rd("Check9")
        Check10.Data = rd("Check10")

        CheckName1.Data = rd("CheckName1")
        CheckName2.Data = rd("CheckName2")
        CheckName3.Data = rd("CheckName3")
        CheckName4.Data = rd("CheckName4")
        CheckName5.Data = rd("CheckName5")
        CheckName6.Data = rd("CheckName6")
        CheckName7.Data = rd("CheckName7")
        CheckName8.Data = rd("CheckName8")
        CheckName9.Data = rd("CheckName9")
        CheckName10.Data = rd("CheckName10")

        DisplaySeq.Data = rd("DisplaySeq")
        txt_DateInsert.Data = rd("DateInsert")
        txt_DateUpdate.Data = rd("DateUpdate")

        txt_remark.Data = rd("Remark")

        If rd("CheckUse") = "1" Then rad_CheckUse1.Checked = True
        If rd("CheckUse") = "2" Then rad_CheckUse2.Checked = True
        rd.Close()


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
                txt_BasicName.Focus()
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

        Msg_Result = MsgBoxP("Do you want to delete", vbYesNo)
        If Msg_Result <> vbYes Then Exit Sub

        Call DATA_DELETE()
    End Sub

    Private Sub txt_selBasicMaster_txtTextChange(sender As Object, e As EventArgs) Handles txt_selBasicMaster.txtTextChange
        If READ_PFK9171(Const_selBasicMaster, txt_selBasicMaster.Code) Then
            txt_cdBasicMaster.ButtonName = D9171.BasicCode
        End If
    End Sub

#End Region

End Class