Public Class ISUD7173A

#Region "Variable"
    Private wJOB As Integer

    Private WRITE_CHK As String   ' 1°ÇÀÌ¶óµµ WRITE°¡ 1°ÇÀÌ¶óµµ WRITEµÈ ÀÚ·á°¡ ÀÖ´ÂÁö Ã¼Å©
    Private KEY_CHK As String     ' KEY_COUNT½Ã Ã¼Å©

    Private W7173 As T7173_AREA
    Private L7173 As T7173_AREA

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7173A(job As Integer, BankCode As String, Optional ByVal TAG As String = "") As Boolean

        D7173.BankCode = BankCode

        wJOB = job : L7173 = D7173

        Link_ISUD7173A = False

        Select Case job
            Case 1
                'If AccountCode = "001" Then Exit Select

            Case Else
                If READ_PFK7173(BankCode) = False Then MsgBoxP("Not Valid!") : Exit Function
        End Select


        formA = False
        Me.Tag = TAG
        Me.ShowDialog()

        Link_ISUD7173A = isudCHK
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

                chk_UseCheck1.Checked = True
                cmd_DEL.Visible = False
                Call KEY_COUNT()

                Setfocus(txt_AccountCode)
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

                txt_BankCode.Enabled = False

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
    Private Sub DATA_INIT()
        Call D7173_CLEAR()

        W7173 = D7173
        KEY_CHK = ""
    End Sub
    Private Sub FORM_INIT()


    End Sub
#End Region

#Region "Function"
    Private Function Data_Check() As Boolean
        Data_Check = False

        If TextCheck("1", txt_BankCode.Data, "BASIC CODE") = False Then Exit Function

        If Trim$(txt_BasicName.Data) = "" Then
            Call MsgBoxP("148", "DATA_CHECK")
            Exit Function
        End If

        Data_Check = True
    End Function
    Private Sub KEY_COUNT()
        If KEY_CHK = "*" Then Exit Sub

        SQL = " SELECT MAX(CAST(K7173_BankCode AS DECIMAL)) AS MAX_CODE FROM PFK7173 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            L7173.BankCode = "00001"
        Else
            L7173.BankCode = Format(CIntp(rd!MAX_CODE + 1), "00000")   'ÇöÀç Á¦ÀÏ Å«°ª¿¡ + 1À»ÇÑ´Ù.
        End If

        W7173.BankCode = L7173.BankCode

        rd.Close()
        txt_BankCode.Data = W7173.BankCode

    End Sub
    Private Sub DATA_MOVE()
        'W7173.BankCode = txt_BankCode.Data
        'W7173.AccountCode = txt_AccountCode.Data

        'W7173.BasicName = Trim$(txt_BasicName.Data)
        'W7173.ForeignName1 = Trim$(txt_ForeignName1.Data)
        'W7173.ForeignName2 = Trim$(txt_ForeignName2.Data)
        'W7173.NameSimply = Trim$(txt_NameSimply.Data)


        'W7173.Check1 = Trim$(txt_check1.Data)
        'W7173.Check2 = Trim$(txt_check2.Data)
        'W7173.Check3 = Trim$(txt_check3.Data)
        'W7173.Check4 = Trim$(txt_check4.Data)
        'W7173.Check5 = Trim$(txt_check5.Data)
        'W7173.Check6 = Trim$(txt_check6.Data)
        'W7173.Check7 = Trim$(txt_check7.Data)
        'W7173.Check8 = Trim$(txt_check8.Data)
        'W7173.Check9 = Trim$(txt_check9.Data)
        'W7173.Check10 = Trim$(txt_check10.Data)

        'W7173.CheckName1 = txt_Checkname1.Data
        'W7173.CheckName2 = txt_Checkname2.Data
        'W7173.CheckName3 = txt_Checkname3.Data
        'W7173.CheckName4 = txt_Checkname4.Data
        'W7173.CheckName5 = txt_Checkname5.Data
        'W7173.CheckName6 = txt_Checkname6.Data
        'W7173.CheckName7 = txt_Checkname7.Data
        'W7173.CheckName8 = txt_Checkname8.Data
        'W7173.CheckName9 = txt_Checkname9.Data
        'W7173.CheckName10 = txt_Checkname10.Data

        'W7173.Remark = txt_remark.Data

        Call K7173_MOVE(Me, W7173, 1, txt_BankCode.Data)

        If chk_UseCheck1.Checked = True Then W7173.UseCheck = "1"
        If chk_UseCheck2.Checked = True Then W7173.UseCheck = "2"

        'W7173.BasicName = Replace(W7173.BasicName, "'", "`")
        'W7173.ForeignName1 = Replace(W7173.ForeignName1, "'", "`")
        'W7173.ForeignName2 = Replace(W7173.ForeignName2, "'", "`")
        'W7173.NameSimply = Replace(W7173.NameSimply, "'", "`")


    End Sub
    Private Sub DATA_INSERT()
        Call KEY_COUNT()
        Call DATA_MOVE()

        'If W7173.DevelopmentCode = "000" Then MsgBoxP("No input main Basic Code", vbCritical) : Exit Sub
        If WRITE_PFK7173(W7173) = True Then isudCHK = True : WRITE_CHK = "*"

    End Sub
    Private Sub DATA_UPDATE()
        If Data_Check() = False Then Exit Sub

        Call DATA_MOVE()

        If REWRITE_PFK7173(W7173) = True Then isudCHK = True

        Me.Dispose()

    End Sub
    Private Sub NULL_ZERO(ByRef x7173 As T7173_AREA)
        Try

            x7173.AccountCode = Trim$(x7173.AccountCode)
            x7173.BasicName = trim$(x7173.BasicName)
            x7173.ForeignName1 = trim$(x7173.ForeignName1)
            x7173.ForeignName2 = trim$(x7173.ForeignName2)
            x7173.NameSimply = trim$(x7173.NameSimply)
            x7173.Check1 = trim$(x7173.Check1)
            x7173.Check2 = trim$(x7173.Check2)
            x7173.Check3 = trim$(x7173.Check3)
            x7173.Check4 = trim$(x7173.Check4)
            x7173.Check5 = trim$(x7173.Check5)
            x7173.Check6 = trim$(x7173.Check6)
            x7173.Check7 = trim$(x7173.Check7)
            x7173.Check8 = trim$(x7173.Check8)
            x7173.Check9 = trim$(x7173.Check9)
            x7173.Check10 = trim$(x7173.Check10)
            x7173.CheckName1 = trim$(x7173.CheckName1)
            x7173.CheckName2 = trim$(x7173.CheckName2)
            x7173.CheckName3 = trim$(x7173.CheckName3)
            x7173.CheckName4 = trim$(x7173.CheckName4)
            x7173.CheckName5 = trim$(x7173.CheckName5)
            x7173.CheckName6 = trim$(x7173.CheckName6)
            x7173.CheckName7 = trim$(x7173.CheckName7)
            x7173.CheckName8 = trim$(x7173.CheckName8)
            x7173.CheckName9 = trim$(x7173.CheckName9)
            x7173.CheckName10 = trim$(x7173.CheckName10)
            x7173.Remark = trim$(x7173.Remark)
            x7173.UseCheck = trim$(x7173.UseCheck)
            x7173.DisplaySeq = trim$(x7173.DisplaySeq)

            If Trim$(x7173.AccountCode) = "" Then x7173.AccountCode = Space(1)
            If trim$(x7173.BasicName) = "" Then x7173.BasicName = Space(1)
            If trim$(x7173.ForeignName1) = "" Then x7173.ForeignName1 = Space(1)
            If trim$(x7173.ForeignName2) = "" Then x7173.ForeignName2 = Space(1)
            If trim$(x7173.NameSimply) = "" Then x7173.NameSimply = Space(1)
            If trim$(x7173.Check1) = "" Then x7173.Check1 = Space(1)
            If trim$(x7173.Check2) = "" Then x7173.Check2 = Space(1)
            If trim$(x7173.Check3) = "" Then x7173.Check3 = Space(1)
            If trim$(x7173.Check4) = "" Then x7173.Check4 = Space(1)
            If trim$(x7173.Check5) = "" Then x7173.Check5 = Space(1)
            If trim$(x7173.Check6) = "" Then x7173.Check6 = Space(1)
            If trim$(x7173.Check7) = "" Then x7173.Check7 = Space(1)
            If trim$(x7173.Check8) = "" Then x7173.Check8 = Space(1)
            If trim$(x7173.Check9) = "" Then x7173.Check9 = Space(1)
            If trim$(x7173.Check10) = "" Then x7173.Check10 = Space(1)
            If trim$(x7173.CheckName1) = "" Then x7173.CheckName1 = Space(1)
            If trim$(x7173.CheckName2) = "" Then x7173.CheckName2 = Space(1)
            If trim$(x7173.CheckName3) = "" Then x7173.CheckName3 = Space(1)
            If trim$(x7173.CheckName4) = "" Then x7173.CheckName4 = Space(1)
            If trim$(x7173.CheckName5) = "" Then x7173.CheckName5 = Space(1)
            If trim$(x7173.CheckName6) = "" Then x7173.CheckName6 = Space(1)
            If trim$(x7173.CheckName7) = "" Then x7173.CheckName7 = Space(1)
            If trim$(x7173.CheckName8) = "" Then x7173.CheckName8 = Space(1)
            If trim$(x7173.CheckName9) = "" Then x7173.CheckName9 = Space(1)
            If trim$(x7173.CheckName10) = "" Then x7173.CheckName10 = Space(1)
            If trim$(x7173.Remark) = "" Then x7173.Remark = Space(1)
            If trim$(x7173.UseCheck) = "" Then x7173.UseCheck = Space(1)
            If trim$(x7173.DisplaySeq) = "" Then x7173.DisplaySeq = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub
    Private Sub DATA_DELETE()
        DATA_MOVE()
        If DELETE_PFK7173(W7173) = True Then isudCHK = True

        Me.Dispose()
    End Sub


#End Region

#Region "DATA_SEARCH"
    Private Function DATA_SEARCH01() As Boolean

        DATA_SEARCH01 = False

        DS1 = READ_PFK7173(L7173.BankCode, cn)
        If GetDsRc(DS1) = 0 Then
            Exit Function
            isudCHK = False
        End If

        Call READER_MOVE(Me, DS1)

        If GetDsData(DS1, 0, "UseCheck") = "1" Then chk_UseCheck1.Checked = True
        If GetDsData(DS1, 0, "UseCheck") = "2" Then chk_UseCheck2.Checked = True

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