Public Class ISUD7102B

#Region "Variable"
    Private wJOB As Integer

    Private WRITE_CHK As String
    Private KEY_CHK As String

    Private W7102 As T7102_AREA
    Private L7102 As T7102_AREA

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7102A(job As Integer, BankCode As String, Optional ByVal TAG As String = "") As Boolean

        D7102.BankCode = BankCode

        wJOB = job : L7102 = D7102

        Link_ISUD7102A = False

        Select Case job
            Case 1
            Case Else
                If READ_PFK7102(L7102.BankCode) = False Then
                    Call MsgBoxP("3", "LINK_ISUD")

                    Exit Function
                End If
        End Select

        formA = False
        Me.Tag = TAG
        Me.ShowDialog()

        Link_ISUD7102A = isudCHK

    End Function
#End Region

#Region "Form_load"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub
        Me.Form_Initial()
        Me.Form_KeyDown()
        WRITE_CHK = ""
        Call DATA_INIT()
        Call FORM_INIT()
        txt_BankCode.Enabled = False
        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        Select Case wJOB
            Case 1
                Me.Text = Me.Text & " - INSERT"

                Call KEY_COUNT()

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If
                Setfocus(txt_NameBank)
                cmd_DEL.Visible = False

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

                txt_BankCode.Enabled = False
                If Pub.DEVCHK <> "1" Then cmd_DEL.Visible = False

                Call DATA_SEARCH01()

                If CHK(3) <> "1" Then
                    If CHK(2) <> "1" Then
                        isudCHK = False
                        Me.Dispose()
                        formA = True
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
        Call D7102_CLEAR()

        W7102 = D7102

        KEY_CHK = ""


    End Sub
    Private Sub FORM_INIT()
    End Sub
#End Region

#Region "Function"
    Private Function Data_Check() As Boolean
        Return DataCheck(Me, "PFK7102")
    End Function
    Private Sub DATA_MOVE()
        W7102.BankCode = txt_BankCode.Data
        W7102.cdBank = txt_cdBank.Code
        W7102.CustomerCode = txt_CustomerCode.Code
        W7102.NameBank = txt_NameBank.Data
        W7102.AccountBankUSD = txt_AccountBankUSD.Data
        W7102.AccountBankVND = txt_AccountBankVND.Data
        W7102.Remark = txt_remark.Data
        W7102.StatementStatus = "1"
        W7102.VinaCode = txt_VinaCode.Data

        If rad_CheckUse1.Checked = True Then W7102.UseCheck = "1"
        If rad_CheckUse2.Checked = True Then W7102.UseCheck = "2"
        If rad_KindCustomer1.Checked = True Then W7102.KindCustomer = "1"
        If rad_KindCustomer2.Checked = True Then W7102.KindCustomer = "2"

    End Sub

    Private Sub DATA_INSERT()

        Call DATA_MOVE()
        Call KEY_COUNT()

        If READ_PFK7102(W7102.CustomerCode) = True Then
            Call MsgBoxP("5", "DATA_INSERT")

            Call KEY_COUNT()
            Setfocus(txt_BankCode)
            Exit Sub
        End If

        If WRITE_PFK7102(W7102) = True Then isudCHK = True : WRITE_CHK = "*"

    End Sub
    Private Sub DATA_UPDATE()

        Call DATA_MOVE()

        If REWRITE_PFK7102(W7102) = True Then isudCHK = True

        Me.Dispose()

    End Sub
    Private Sub DATA_DELETE()
        Dim str As String = MsgBoxP("Do you want to delete ?", vbYesNo)
        If str <> vbYes Then Exit Sub
        DATA_MOVE()
        If DELETE_PFK7102(W7102) = True Then isudCHK = True
        Me.Dispose()
    End Sub
    Private Sub KEY_COUNT()
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        If KEY_CHK = "*" Then Exit Sub

        SQL = "SELECT MAX(CAST(K7102_BankCode AS DECIMAL)) AS MAX_CODE FROM PFK7102 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            L7102.BankCode = "000001"
        Else
            L7102.BankCode = CIntp(rd!MAX_CODE + 1).ToString("000000")
        End If

        W7102.BankCode = L7102.BankCode

        rd.Close()

        txt_BankCode.Data = W7102.BankCode
    End Sub


#End Region

#Region "DATA_SEARCH"
    Private Function DATA_SEARCH01() As Boolean

        DATA_SEARCH01 = False


        DS1 = READ_PFK7102(L7102.BankCode, cn)
        If GetDsRc(DS1) = 0 Then
            Exit Function : Me.Dispose()
            isudCHK = False
        End If

        READER_MOVE(Me, DS1)

        If GetDsData(DS1, 0, "K7102_UseCheck") = "1" Then rad_CheckUse1.Checked = True
        If GetDsData(DS1, 0, "K7102_UseCheck") = "2" Then rad_CheckUse2.Checked = True

        If GetDsData(DS1, 0, "K7102_KindCustomer") = "1" Then rad_KindCustomer1.Checked = True
        If GetDsData(DS1, 0, "K7102_KindCustomer") = "2" Then rad_KindCustomer2.Checked = True

        DATA_SEARCH01 = True

    End Function

#End Region

#Region "Event"
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click

        Select Case wJOB
            Case 1
                If Data_Check() = False Then Exit Sub
                Call DATA_INSERT()
                Me.Form_ClearData()
                Call DATA_INIT()
                Call KEY_COUNT()
                Setfocus(txt_BankCode)
            Case 2 : Me.Dispose()
            Case 3
                If Data_Check() = False Then Exit Sub
                Call DATA_UPDATE()
            Case 4 : Call DATA_DELETE()
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
        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        If CHK(4) <> "1" Then
            Call MsgBoxP("4", "cmd_DEL_Click")
            Exit Sub
        End If

        Call DATA_DELETE()
        Me.Dispose()
    End Sub
#End Region



End Class