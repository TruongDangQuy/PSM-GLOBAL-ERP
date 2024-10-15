Public Class ISUD7172A

#Region "Variable"
    Private wJOB As Integer

    Private WRITE_CHK As String   ' 1°ÇÀÌ¶óµµ WRITE°¡ 1°ÇÀÌ¶óµµ WRITEµÈ ÀÚ·á°¡ ÀÖ´ÂÁö Ã¼Å©
    Private KEY_CHK As String     ' KEY_COUNT½Ã Ã¼Å©

    Private W7172 As T7172_AREA
    Private L7172 As T7172_AREA

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7172A(job As Integer, AccCode As String, AccSeq As String, AccSel As String, Optional ByVal TAG As String = "") As Boolean

        D7172.AccCode = AccCode
        D7172.AccSeq = AccSeq
        D7172.AccSel = AccSel

        wJOB = job : L7172 = D7172

        Link_ISUD7172A = False

        Select Case job
            Case 1
                'If AccSeq = "001" Then Exit Select

        End Select

        If L7172.AccCode = Const_PASSWORD Or (L7172.AccCode = "000" And L7172.AccSeq = Const_PASSWORD) Then


        End If

        formA = False
        Me.Tag = TAG
        Me.ShowDialog()

        Link_ISUD7172A = isudCHK
    End Function
#End Region

#Region "Form_Load"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub
        Me.Form_Initial()
        Me.Form_KeyDown()

        WRITE_CHK = ""
        Call DATA_INIT()
        Call FORM_INIT()

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        txt_Selremark.Data = D7172.Remark

        Block1.Enabled = True

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

                UseCheck1.Checked = True
                cmd_DEL.Visible = False
                KEY_COUNT()
                Setfocus(txt_BasicName)
            Case 2
                Me.Text = Me.Text & " - SEARCH"

                frm_Condition.Enabled = False
                cmd_DEL.Visible = False

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

                txt_AccCode.Enabled = False

                If Pub.DEVCHK <> "1" Then cmd_DEL.Visible = False

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
                        cmd_DEL.Visible = False
                        Call MsgBoxP("Only Search !"): cmd_OK.Visible = False
                    End If
                End If

            Case 4
                Me.Text = Me.Text & " - DELETE"
                cmd_DEL.Visible = True
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

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Call D7172_CLEAR()

        W7172 = D7172
        KEY_CHK = ""
    End Sub
    Private Sub FORM_INIT()
        DisplaySeq.Tag = L7172.AccCode
        txt_AccCode.Data = L7172.AccCode
        txt_AccSeq.Data = L7172.AccSeq
        txt_AccSel.Data = L7172.AccSel

    End Sub
#End Region

#Region "Function"
    Private Function Data_Check() As Boolean
        Data_Check = False

        If TextCheck("1", txt_AccCode.Data, "BASIC CODE") = False Then Exit Function
        If IsNumeric(txt_AccSel.Data) = False Then txt_AccSel.Data = "0"
        If IsNumeric(txt_AccSeq.Data) = False Then txt_AccSeq.Data = "0"

        If Trim$(txt_BasicName.Data) = "" Then
            Call MsgBoxP("148", "DATA_CHECK")
            Exit Function
        End If

        Data_Check = True
    End Function
    Private Sub DATA_MOVE()
        W7172.AccCode = txt_AccCode.Data
        W7172.AccSeq = txt_AccSeq.Data
        W7172.AccSel = txt_AccSel.Data

        W7172.BasicName = Trim$(txt_BasicName.Data)
        W7172.ForeignName1 = Trim$(txt_ForeignName1.Data)
        W7172.ForeignName2 = Trim$(txt_ForeignName2.Data)
        W7172.NameSimply = Trim$(txt_NameSimply.Data)

        If W7172.AccSeq = "0" Then
            W7172.DevelopmentCode = W7172.AccCode
        ElseIf W7172.AccSeq <> "0" And W7172.AccSel = "0" Then
            W7172.DevelopmentCode = W7172.AccCode & W7172.AccSeq
        ElseIf W7172.AccSel <> "0" Then
            W7172.DevelopmentCode = W7172.AccCode & W7172.AccSeq & W7172.AccSel
        End If
      
      
        W7172.Check1 = Trim$(check1.Data)
        W7172.Check2 = Trim$(check2.Data)
        W7172.Check3 = Trim$(check3.Data)
        W7172.Check4 = Trim$(check4.Data)
        W7172.Check5 = Trim$(check5.Data)
        W7172.Check6 = Trim$(check6.Data)
        W7172.Check7 = Trim$(check7.Data)
        W7172.Check8 = Trim$(check8.Data)
        W7172.Check9 = Trim$(check9.Data)
        W7172.Check10 = Trim$(check10.Data)

        W7172.CheckName1 = Checkname1.Data
        W7172.CheckName2 = Checkname2.Data
        W7172.CheckName3 = Checkname3.Data
        W7172.CheckName4 = Checkname4.Data
        W7172.CheckName5 = Checkname5.Data
        W7172.CheckName6 = Checkname6.Data
        W7172.CheckName7 = Checkname7.Data
        W7172.CheckName8 = Checkname8.Data
        W7172.CheckName9 = Checkname9.Data
        W7172.CheckName10 = Checkname10.Data

        W7172.Remark = txt_remark.Data

        If UseCheck1.Checked = True Then W7172.UseCheck = "1"
        If UseCheck2.Checked = True Then W7172.UseCheck = "2"

        W7172.BasicName = Replace(W7172.BasicName, "'", "`")
        W7172.ForeignName1 = Replace(W7172.ForeignName1, "'", "`")
        W7172.ForeignName2 = Replace(W7172.ForeignName2, "'", "`")
        W7172.NameSimply = Replace(W7172.NameSimply, "'", "`")


    End Sub
    Private Sub DATA_INSERT()

        Call DATA_MOVE()

        If READ_PFK7172(W7172.AccCode, W7172.AccSeq, W7172.AccSel) = True Then
            Call MsgBoxP("294", "DATA_INSERT")
            txt_AccCode.Focus()
            Call KEY_COUNT()
            Exit Sub
        End If
        'If W7172.AccCode = "000" Then MsgBoxP("No input main Basic Code", vbCritical) : Exit Sub
        If WRITE_PFK7172(W7172) = True Then isudCHK = True : WRITE_CHK = "*"

    End Sub
    Private Sub DATA_UPDATE()
        If Data_Check() = False Then Exit Sub

        Call DATA_MOVE()
        If Block1.Enabled = True Then
            If REWRITE_PFK7172(W7172) = True Then isudCHK = True
        Else
            If REWRITE_PFK7172(W7172) = True Then isudCHK = True
        End If

        Me.Dispose()

    End Sub

    Private Sub DATA_DELETE()
        DATA_MOVE()
        If DELETE_PFK7172(W7172) = True Then isudCHK = True

        Me.Dispose()
    End Sub

    Private Sub KEY_COUNT()
        If KEY_CHK = "*" Then Exit Sub

        SQL = " SELECT MAX(CAST(K7172_AccSeq AS DECIMAL)) AS MAX_CODE FROM PFK7172 "
        SQL = SQL & " WHERE K7172_AccCode = '" & L7172.AccCode & "' "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            L7172.AccSeq = "0"
        Else
            L7172.AccSeq = Format(CInt(rd!MAX_CODE + 1), "0")   'ÇöÀç Á¦ÀÏ Å«°ª¿¡ + 1À»ÇÑ´Ù.
        End If

        W7172.AccCode = L7172.AccCode
        W7172.AccSeq = L7172.AccSeq

        rd.Close()

        If Val(W7172.AccSeq) > 999 Then
            Call MsgBoxP("316", "KEY_COUNT")
        End If

        txt_AccCode.Data = W7172.AccCode
        txt_AccSeq.Data = W7172.AccSeq

    End Sub

#End Region

#Region "DATA_SEARCH"
    Private Function DATA_SEARCH01() As Boolean

        DATA_SEARCH01 = False

        'rd = PrcDR("USP_PFP71720_SEARCH_vS2_LINE", cn, L7172.AccCode, L7172.AccSeq)
        'rd.Read()
        'If rd.HasRows = False Then
        '    rd.Close() : isudCHK = False
        '    Me.Dispose() : Exit Function
        'End If

        '' Call K7172_MOVE(rd) : W7172 = D7172
        ''rd.Close()
        ''Call READ_PFK7172("000", W7172.AccCode)
        ''DisplaySeq.Data = Trim$(D7172.BasicName)

        'txt_AccCode.Data = rd("AccCode")
        'txt_AccSeq.Data = rd("AccSeq")
        'txt_BasicName.Data = rd("BasicName")
        'txt_ForeignName1.Data = rd("ForeignName1")
        'txt_ForeignName2.Data = rd("ForeignName2")
        'txt_NameSimply.Data = rd("NameSimply")

        ''   txt_DevelopmentCode.Data = rd("DevelopmentCode")
        ''txt_DevelopmentCodeP.Data = rd("DevelopmentCodeP

        'Check1.Data = rd("Check1")
        'Check2.Data = rd("Check2")
        'Check3.Data = rd("Check3")
        'Check4.Data = rd("Check4")
        'Check5.Data = rd("Check5")
        'Check6.Data = rd("Check6")
        'Check7.Data = rd("Check7")
        'Check8.Data = rd("Check8")
        'Check9.Data = rd("Check9")
        'Check10.Data = rd("Check10")

        'CheckName1.Data = rd("CheckName1")
        'CheckName2.Data = rd("CheckName2")
        'CheckName3.Data = rd("CheckName3")
        'CheckName4.Data = rd("CheckName4")
        'CheckName5.Data = rd("CheckName5")
        'CheckName6.Data = rd("CheckName6")
        'CheckName7.Data = rd("CheckName7")
        'CheckName8.Data = rd("CheckName8")
        'CheckName9.Data = rd("CheckName9")
        'CheckName10.Data = rd("CheckName10")

        'txt_remark.Data = rd("Remark")


        DS1 = READ_PFK7172(txt_AccCode.Data, txt_AccSeq.Data, txt_AccSel.Data, cn)

        If GetDsRc(DS1) = 0 Then
            Exit Function
        End If

        Call READER_MOVE(Me, DS1)

        If GetDsData(DS1, 0, "K7172_UseCheck") = "1" Then UseCheck1.Checked = True
        If GetDsData(DS1, 0, "K7172_UseCheck") = "2" Then UseCheck2.Checked = True
        rd.Close()


        DATA_SEARCH01 = True

    End Function
#End Region

#Region "Event"
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
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
    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        If WRITE_CHK = "*" Then
            isudCHK = True
        Else
            isudCHK = False
        End If

        Me.Dispose()
    End Sub
    Private Sub cmd_DEL_Click(sender As Object, e As EventArgs) Handles cmd_DEL.Click
        Dim Msg_Result As String

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        If CHK(4) <> "1" Then
            Call MsgBoxP("4", "cmd_DEL_Click")
            Exit Sub
        End If

        Msg_Result = MsgBoxP("Do you want to delete", vbYesNo)
        If Msg_Result <> vbYes Then Exit Sub

        Call DATA_DELETE()
    End Sub


#End Region


End Class