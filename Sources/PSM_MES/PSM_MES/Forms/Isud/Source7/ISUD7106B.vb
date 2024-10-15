Public Class ISUD7106B

#Region "Variable"
    Private wJOB As Integer

    Private WRITE_CHK As String
    Private KEY_CHK As String

    Private W7106 As T7106_AREA
    Private L7106 As T7106_AREA

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7106B(job As Integer, ShoesCode As String, Optional ByVal TAG As String = "") As Boolean

        D7106.ShoesCode = ShoesCode

        wJOB = job : L7106 = D7106

        Link_ISUD7106B = False

        Select Case job
            Case 1
            Case Else
                If READ_PFK7106(L7106.ShoesCode) = False Then
                    Call MsgBoxP("3", "LINK_ISUD")

                    Exit Function
                End If
        End Select

        formA = False
        Me.Tag = TAG
        Me.ShowDialog()

        Link_ISUD7106B = isudCHK

    End Function
#End Region

#Region "Form_load"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        Call DATA_INIT()
        Call FORM_INIT()

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
                Setfocus(txt_CustomerCode)
                cmd_DEL.Visible = False

            Case 2
                Me.Text = Me.Text & " - SEARCH"

                frm_Condition.Enabled = True
                cmd_DEL.Visible = False

                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH()
                Call DATA_SEARCH02()

            Case 3
                Me.Text = Me.Text & " - UPDATE"

                If Pub.DEVCHK <> "1" Then cmd_DEL.Visible = False

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH()
                Call DATA_SEARCH02()

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
                        frm_Condition.Enabled = True
                        cmd_DEL.Visible = False
                        Call MsgBoxP("Only Search !") : cmd_OK.Visible = False
                    End If
                End If

            Case 4
                Me.Text = Me.Text & " - DELETE"

                frm_Condition.Enabled = True

                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH()
                Call DATA_SEARCH02()

            Case 5
                Me.Text = Me.Text & " - COPY"

                If Pub.DEVCHK <> "1" Then cmd_DEL.Visible = False

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH()
                Call DATA_SEARCH02()

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
                        frm_Condition.Enabled = True
                        cmd_DEL.Visible = False
                        Call MsgBoxP("Only Search !") : cmd_OK.Visible = False
                    End If
                End If

                txt_cdSpecState.Data = ""
                txt_cdSpecState.Code = ""

                Call KEY_COUNT()
                wJOB = 1
                Setfocus(txt_ColorCode)

            Case 6
                Me.Text = Me.Text & " - UPDATE LAST CODE"

                If Pub.DEVCHK <> "1" Then cmd_DEL.Visible = False

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH()
                Call DATA_SEARCH02()

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
                        frm_Condition.Enabled = True
                        cmd_DEL.Visible = False
                        Call MsgBoxP("Only Search !") : cmd_OK.Visible = False
                    End If
                End If


                wJOB = 3

        End Select

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Call D7106_CLEAR()

        W7106 = D7106

        KEY_CHK = ""


    End Sub
    Private Sub FORM_INIT()
        txt_ShoesCode.Enabled = False
        Vs1.HorizontalScrollBarPolicy = ScrollBarPolicy.Never
    End Sub
#End Region

#Region "Function"
    Private Function Data_Check() As Boolean
        Return DataCheck(Me, "PFK7106")
    End Function
    Private Sub DATA_MOVE()

        W7106.OutsoleColor = txt_OutsoleColor.Data
        W7106.LogoColor = txt_LogoColor.Data

        W7106.OutsoleColorCode = txt_OutsoleColorCode.Data
        W7106.LogoColorCode = txt_LogoColorCode.Data

        W7106.MoldCode = txt_MoldCode.Code

        W7106.MidsoleColor = txt_MidsoleColor.Data
        W7106.InsoleColor = txt_InsoleColor.Data

    End Sub

    Private Sub DATA_INSERT()
       

    End Sub
    Private Sub DATA_UPDATE()
        If READ_PFK7106(L7106.ShoesCode) Then
            W7106 = D7106

            Call DATA_MOVE()

            W7106.DateUpdate = Pub.DAT
            W7106.InchargeUpdate = Pub.SAW


            If REWRITE_PFK7106(W7106) = True Then isudCHK = True

            Me.Dispose()
        End If
    End Sub
    Private Sub DATA_DELETE()
        Dim str As String = MsgBoxP("Do you want to delete ?", vbYesNo)
        If str <> vbYes Then Exit Sub
        DATA_MOVE()

        If CheckExist(W7106.ShoesCode) = True Then Exit Sub

        If PrcExe("USP_PFK7106_DELETE_SHOESCODE", cn, W7106.ShoesCode) Then
            isudCHK = True
        End If

        Me.Dispose()

    End Sub

    Private Function CheckExist(ShoesCode As String) As Boolean
        CheckExist = False

        Dim RC As Integer
        Try
            rd = PrcDR("USP_ISUD7106B_CHECKEXIST", cn, ShoesCode)

            If rd.HasRows = True Then
                rd.Read()
                RC = rd!RC
                If RC > 0 Then MsgBoxP("Next Data Already!") : rd.Close() : CheckExist = True : Exit Function
            End If

            rd.Close()
        Catch ex As Exception

        Finally

            If rd IsNot Nothing Then
                If rd.IsClosed = False Then
                    rd.Close()
                End If
            End If
        End Try

    End Function

    Private Sub KEY_COUNT()
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        If KEY_CHK = "*" Then Exit Sub

        SQL = "SELECT MAX(CAST(K7106_ShoesCode AS DECIMAL)) AS MAX_CODE FROM PFK7106 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            L7106.ShoesCode = "000001"
        Else
            L7106.ShoesCode = Format(CInt(rd!MAX_CODE + 1), "000000")
        End If

        W7106.ShoesCode = L7106.ShoesCode

        rd.Close()
        If Val(W7106.ShoesCode) > 999999 Then
            Call MsgBoxP("46", "KEY_COUNT")

            Call cmd_Cancel.PerformClick() : Exit Sub
        End If

        txt_ShoesCode.Data = W7106.ShoesCode
    End Sub


#End Region

#Region "DATA_SEARCH"
    Private Function DATA_SEARCH() As Boolean

        DATA_SEARCH = False

        DS1 = READ_PFK7106(L7106.ShoesCode, cn)

        If GetDsRc(DS1) = 0 Then
            Setfocus(txt_CustomerCode)
            Exit Function
            isudCHK = False
        End If

        READER_MOVE(Me, DS1)

        If GetDsData(DS1, 0, "CheckUse") = "1" Then rad_CheckUse1.Checked = True
        If GetDsData(DS1, 0, "CheckUse") = "2" Then rad_CheckUse2.Checked = True

        Setfocus(txt_CustomerCode)

        DATA_SEARCH = True

    End Function

    Private Function DATA_SEARCH02() As Boolean
        DATA_SEARCH02 = False

        DS1 = PrcDS("USP_ISUD7104A_SEARCH_VS1", cn, txt_SizeRange.Code)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs1, DS1, "USP_ISUD7104A_SEARCH_VS1", "Vs1")
            Vs1.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "USP_ISUD7104A_SEARCH_VS1", "Vs1")
        DATA_SEARCH02 = True

    End Function

    Private Function DATA_SEARCH_HEAD() As Boolean
        DATA_SEARCH_HEAD = False

        DATA_SEARCH_HEAD = True

    End Function

#End Region

#Region "Event"
    Private Sub cmd_UpdateSize_Click(sender As Object, e As EventArgs) Handles cmd_UpdateSize.Click
        If HLP7106G.Link_HLP7106G(txt_ShoesCode.Data) Then

        End If
    End Sub
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click

        Select Case wJOB
            Case 1
                If Data_Check() = False Then Exit Sub
                Call DATA_INSERT()
                Me.Form_ClearData()
                Call DATA_INIT()
                Call KEY_COUNT()
                Setfocus(txt_CustomerCode)
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

    Private Sub txt_SizeRange_txtTextChange(sender As Object, e As EventArgs) Handles txt_SizeRange.txtTextChange
        If formA = False Then Exit Sub

        Call DATA_SEARCH02()

    End Sub

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        txt_SpeciticSize.Data = getData(Vs1, e.Column, e.Row)
        txt_Szno.Data = getDataCH(Vs1, e.Column, e.Row)
    End Sub

#End Region







 
End Class