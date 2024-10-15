Public Class ISUD7501B

#Region "Variable"
    Private wJOB As Integer

    Private WRITE_CHK As String   ' 1°ÇÀÌ¶óµµ WRITE°¡ 1°ÇÀÌ¶óµµ WRITEµÈ ÀÚ·á°¡ ÀÖ´ÂÁö Ã¼Å©
    Private KEY_CHK As String     ' KEY_COUNT½Ã Ã¼Å©

    Private W7501 As T7501_AREA
    Private L7501 As T7501_AREA

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7501B(job As Integer, AccCode As String, Optional ByVal TAG As String = "") As Boolean

        D7501.AccCode = AccCode

        wJOB = job : L7501 = D7501

        Link_ISUD7501B = False

        Select Case job
            Case 1
                'If AccCode = "001" Then Exit Select

            Case Else
                If READ_PFK7501(AccCode) = False Then MsgBoxP("Not Valid!") : Exit Function
        End Select


        formA = False
        Me.Tag = TAG
        Me.ShowDialog()

        Link_ISUD7501B = isudCHK
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

                Call KEY_COUNT()
                Call KEY_COUNT_SEQ()

                chk_UseCheck1.Checked = True
                cmd_DEL.Visible = False

                Setfocus(txt_AccCode)
            Case 2
                Me.Text = Me.Text & " - SEARCH"

                frm_Condition.Enabled = True
                cmd_DEL.Visible = False
                cmd_OK.Visible = False

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
                        Call MsgBoxP("Only Search !") : cmd_OK.Visible = False
                    End If
                End If
                cmd_DEL.Visible = False

            Case 4
                Me.Text = Me.Text & " - DELETE"
                cmd_DEL.Visible = True
                frm_Condition.Enabled = True

                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                cmd_OK.Visible = False
                Call DATA_SEARCH01()

        End Select

        formA = True
    End Sub
    Private Sub KEY_COUNT()
        If KEY_CHK = "*" Then Exit Sub

        SQL = " SELECT MAX(CAST(SUBSTRING(K7501_SKCode,3,4) AS DECIMAL)) AS MAX_CODE FROM PFK7501 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            L7501.AccCode = "SK" & "0001"
        Else
            L7501.AccCode = "SK" & Format(CIntp(rd!MAX_CODE + 1), "0000")
        End If

        W7501.AccCode = L7501.AccCode
        L7501.SKCode = L7501.AccCode

        rd.Close()

        txt_AccCode.Data = L7501.AccCode


    End Sub

    Private Sub KEY_COUNT_SEQ()
        If KEY_CHK = "*" Then Exit Sub

        SQL = " SELECT MAX(CAST(K7501_DisplaySeq AS DECIMAL)) AS MAX_CODE FROM PFK7501 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            L7501.DisplaySeq = "00001"
        Else
            L7501.DisplaySeq = Format(CIntp(rd!MAX_CODE + 1), "00000")
        End If

        W7501.DisplaySeq = L7501.DisplaySeq

        rd.Close()

        txt_DisplaySeq.Data = L7501.DisplaySeq


    End Sub

    Private Function KEY_COUNT_NO(DevelopmentCode As String) As String
        If KEY_CHK = "*" Then KEY_COUNT_NO = Nothing : Exit Function

        SQL = " SELECT count(*) AS MAX_CODE FROM PFK7501 WHERE K7501_DevelopmentCode = '" + DevelopmentCode + "'"

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            KEY_COUNT_NO = "01"
        Else
            KEY_COUNT_NO = Format(CIntp(rd!MAX_CODE + 1), "00")
        End If

        rd.Close()

    End Function
    Private Sub DATA_INIT()
        Call D7501_CLEAR()

        W7501 = D7501
        KEY_CHK = ""
    End Sub
    Private Sub FORM_INIT()
        txt_BasicName.Data = ""
        txt_AccCode.Data = ""

    End Sub
#End Region

#Region "Function"
    Private Function Data_Check() As Boolean
        Data_Check = False

        txt_AccCode.Data = FormatCut(txt_AccCode.Data)

        If txt_AccCode.Data.Length < 3 Then MsgBoxP("Code not correct!") : Exit Function

        If TextCheck("1", txt_AccCode.Data, "BASIC CODE") = False Then Exit Function

        If Trim$(txt_BasicName.Data) = "" Then
            Call MsgBoxP("148", "DATA_CHECK")
            Exit Function
        End If

        Data_Check = True
    End Function

    Private Sub DATA_MOVE()
        'W7501.AccCode = txt_AccCode.Data
        'W7501.AccCode = txt_AccCode.Data

        'W7501.BasicName = Trim$(txt_BasicName.Data)
        'W7501.ForeignName1 = Trim$(txt_ForeignName1.Data)
        'W7501.ForeignName2 = Trim$(txt_ForeignName2.Data)
        'W7501.NameSimply = Trim$(txt_NameSimply.Data)



        'W7501.CheckName1 = txt_Checkname1.Data
        'W7501.CheckName2 = txt_Checkname2.Data
        'W7501.CheckName3 = txt_Checkname3.Data
        'W7501.CheckName4 = txt_Checkname4.Data
        'W7501.CheckName5 = txt_Checkname5.Data
        'W7501.CheckName6 = txt_Checkname6.Data
        'W7501.CheckName7 = txt_Checkname7.Data
        'W7501.CheckName8 = txt_Checkname8.Data
        'W7501.CheckName9 = txt_Checkname9.Data
        'W7501.CheckName10 = txt_Checkname10.Data

        'W7501.Remark = txt_remark.Data


        Call K7501_MOVE(Me, W7501, 1, txt_AccCode.Data)

        W7501.Check1 = Trim$(chk_Check1.CheckState)
        W7501.Check2 = Trim$(chk_Check2.CheckState)
        W7501.Check3 = Trim$(chk_Check3.CheckState)
        W7501.Check4 = Trim$(chk_Check4.CheckState)
        W7501.Check5 = Trim$(chk_Check5.CheckState)
        W7501.Check6 = Trim$(chk_Check6.CheckState)
        W7501.Check7 = Trim$(chk_Check7.CheckState)
        W7501.Check8 = Trim$(chk_Check8.CheckState)
        W7501.Check9 = Trim$(chk_Check9.CheckState)
        W7501.Check10 = Trim$(chk_Check10.CheckState)

        If chk_UseCheck1.Checked = True Then W7501.UseCheck = "1"
        If chk_UseCheck2.Checked = True Then W7501.UseCheck = "2"

        'W7501.BasicName = Replace(W7501.BasicName, "'", "`")
        'W7501.ForeignName1 = Replace(W7501.ForeignName1, "'", "`")
        'W7501.ForeignName2 = Replace(W7501.ForeignName2, "'", "`")
        'W7501.NameSimply = Replace(W7501.NameSimply, "'", "`")


    End Sub
    Private Sub DATA_INSERT()
        Call DATA_MOVE()

        If READ_PFK7501(W7501.AccCode) = False Then
            'If txt_DevelopmentCode.Code = "" Then
            '    W7501.DevelopmentCode = W7501.AccCode
            'End If
            If txt_DevelopmentCode.Code = "" Then
                W7501.DevelopmentCode = txt_DevelopmentCode.Data

            Else
                W7501.AccCode = txt_DevelopmentCode.Code & "_" & KEY_COUNT_NO(txt_DevelopmentCode.Code)
            End If

            'If txt_DevelopmentCode.Code.Contains("111") Or txt_DevelopmentCode.Code.Contains("112") Or txt_DevelopmentCode.Code.Contains("131") Or txt_DevelopmentCode.Code.Contains("331") Then
            '    W7501.AccCode = txt_DevelopmentCode.Code & L7501.SKCode
            'End If

            W7501.SKCode = L7501.SKCode
            'If W7501.DevelopmentCode = "000" Then MsgBoxP("No input main Basic Code", vbCritical) : Exit Sub
            If WRITE_PFK7501(W7501) = True Then isudCHK = True : WRITE_CHK = "*"
        Else
            'If txt_DevelopmentCode.Code = "" Then
            '    W7501.DevelopmentCode = W7501.AccCode
            'End If
            If txt_DevelopmentCode.Code.Trim = "" Then
                W7501.DevelopmentCode = txt_DevelopmentCode.Data.Trim
            End If

            If REWRITE_PFK7501(W7501) = True Then isudCHK = True : WRITE_CHK = "*"
        End If
    End Sub

    Private Sub DATA_UPDATE()
        If Data_Check() = False Then Exit Sub

        Call DATA_MOVE()

        If txt_DevelopmentCode.Code.Trim = "" Then
            W7501.DevelopmentCode = txt_DevelopmentCode.Data.Trim
        End If

        If REWRITE_PFK7501(W7501) = True Then isudCHK = True

        Me.Dispose()

    End Sub
    Private Sub NULL_ZERO(ByRef x7501 As T7501_AREA)
        Try

            x7501.AccCode = Trim$(x7501.AccCode)
            x7501.BasicName = Trim$(x7501.BasicName)
            x7501.ForeignName1 = Trim$(x7501.ForeignName1)
            x7501.ForeignName2 = Trim$(x7501.ForeignName2)
            x7501.NameSimply = Trim$(x7501.NameSimply)
            x7501.Check1 = Trim$(x7501.Check1)
            x7501.Check2 = Trim$(x7501.Check2)
            x7501.Check3 = Trim$(x7501.Check3)
            x7501.Check4 = Trim$(x7501.Check4)
            x7501.Check5 = Trim$(x7501.Check5)
            x7501.Check6 = Trim$(x7501.Check6)
            x7501.Check7 = Trim$(x7501.Check7)
            x7501.Check8 = Trim$(x7501.Check8)
            x7501.Check9 = Trim$(x7501.Check9)
            x7501.Check10 = Trim$(x7501.Check10)
            x7501.CheckName1 = Trim$(x7501.CheckName1)
            x7501.CheckName2 = Trim$(x7501.CheckName2)
            x7501.CheckName3 = Trim$(x7501.CheckName3)
            x7501.CheckName4 = Trim$(x7501.CheckName4)
            x7501.CheckName5 = Trim$(x7501.CheckName5)
            x7501.CheckName6 = Trim$(x7501.CheckName6)
            x7501.CheckName7 = Trim$(x7501.CheckName7)
            x7501.CheckName8 = Trim$(x7501.CheckName8)
            x7501.CheckName9 = Trim$(x7501.CheckName9)
            x7501.CheckName10 = Trim$(x7501.CheckName10)
            x7501.Remark = Trim$(x7501.Remark)
            x7501.UseCheck = Trim$(x7501.UseCheck)
            x7501.DisplaySeq = Trim$(x7501.DisplaySeq)

            If Trim$(x7501.AccCode) = "" Then x7501.AccCode = Space(1)
            If Trim$(x7501.BasicName) = "" Then x7501.BasicName = Space(1)
            If Trim$(x7501.ForeignName1) = "" Then x7501.ForeignName1 = Space(1)
            If Trim$(x7501.ForeignName2) = "" Then x7501.ForeignName2 = Space(1)
            If Trim$(x7501.NameSimply) = "" Then x7501.NameSimply = Space(1)
            If Trim$(x7501.Check1) = "" Then x7501.Check1 = Space(1)
            If Trim$(x7501.Check2) = "" Then x7501.Check2 = Space(1)
            If Trim$(x7501.Check3) = "" Then x7501.Check3 = Space(1)
            If Trim$(x7501.Check4) = "" Then x7501.Check4 = Space(1)
            If Trim$(x7501.Check5) = "" Then x7501.Check5 = Space(1)
            If Trim$(x7501.Check6) = "" Then x7501.Check6 = Space(1)
            If Trim$(x7501.Check7) = "" Then x7501.Check7 = Space(1)
            If Trim$(x7501.Check8) = "" Then x7501.Check8 = Space(1)
            If Trim$(x7501.Check9) = "" Then x7501.Check9 = Space(1)
            If Trim$(x7501.Check10) = "" Then x7501.Check10 = Space(1)
            If Trim$(x7501.CheckName1) = "" Then x7501.CheckName1 = Space(1)
            If Trim$(x7501.CheckName2) = "" Then x7501.CheckName2 = Space(1)
            If Trim$(x7501.CheckName3) = "" Then x7501.CheckName3 = Space(1)
            If Trim$(x7501.CheckName4) = "" Then x7501.CheckName4 = Space(1)
            If Trim$(x7501.CheckName5) = "" Then x7501.CheckName5 = Space(1)
            If Trim$(x7501.CheckName6) = "" Then x7501.CheckName6 = Space(1)
            If Trim$(x7501.CheckName7) = "" Then x7501.CheckName7 = Space(1)
            If Trim$(x7501.CheckName8) = "" Then x7501.CheckName8 = Space(1)
            If Trim$(x7501.CheckName9) = "" Then x7501.CheckName9 = Space(1)
            If Trim$(x7501.CheckName10) = "" Then x7501.CheckName10 = Space(1)
            If Trim$(x7501.Remark) = "" Then x7501.Remark = Space(1)
            If Trim$(x7501.UseCheck) = "" Then x7501.UseCheck = Space(1)
            If Trim$(x7501.DisplaySeq) = "" Then x7501.DisplaySeq = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub
    Private Sub DATA_DELETE()
        DATA_MOVE()
        If DELETE_PFK7501(W7501) = True Then isudCHK = True

        Me.Dispose()
    End Sub


#End Region

#Region "DATA_SEARCH"
    Private Function DATA_SEARCH01() As Boolean

        DATA_SEARCH01 = False

        DS1 = READ_PFK7501(L7501.AccCode, cn)
        If GetDsRc(DS1) = 0 Then
            Exit Function
            isudCHK = False
        End If

        Call READER_MOVE(Me, DS1)

        If GetDsData(DS1, 0, "K7501_UseCheck") = "1" Then chk_UseCheck1.Checked = True
        If GetDsData(DS1, 0, "K7501_UseCheck") = "2" Then chk_UseCheck2.Checked = True

        If GetDsData(DS1, 0, "K7501_Check1") = "1" Then chk_Check1.Checked = True
        If GetDsData(DS1, 0, "K7501_Check2") = "1" Then chk_Check2.Checked = True
        If GetDsData(DS1, 0, "K7501_Check3") = "1" Then chk_Check3.Checked = True
        If GetDsData(DS1, 0, "K7501_Check4") = "1" Then chk_Check4.Checked = True
        If GetDsData(DS1, 0, "K7501_Check5") = "1" Then chk_Check5.Checked = True
        If GetDsData(DS1, 0, "K7501_Check6") = "1" Then chk_Check6.Checked = True
        If GetDsData(DS1, 0, "K7501_Check7") = "1" Then chk_Check7.Checked = True
        If GetDsData(DS1, 0, "K7501_Check8") = "1" Then chk_Check8.Checked = True
        If GetDsData(DS1, 0, "K7501_Check9") = "1" Then chk_Check9.Checked = True
        If GetDsData(DS1, 0, "K7501_Check10") = "1" Then chk_Check10.Checked = True

        If READ_PFK7501(txt_DevelopmentCode.Code) = True Then
            txt_DevelopmentCode.Data = D7501.BasicName
        End If

        DATA_SEARCH01 = True

    End Function
#End Region

#Region "Event"
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Select Case wJOB
            Case 1
                If Data_Check() = False Then Exit Sub
                Call DATA_INSERT()
                'Me.Form_Initial()
                Call FORM_INIT()
                Call DATA_INIT()

                Call KEY_COUNT()
                Call KEY_COUNT_SEQ()

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