Public Class ISUD7122A

#Region "Variable"
    Private wJOB As Integer

    Private WRITE_CHK As String
    Private KEY_CHK As String

    Private W7122 As T7122_AREA
    Private L7122 As T7122_AREA

    Private W7123 As T7123_AREA
    Private L7123 As T7123_AREA

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7122A(job As Integer, SpecCode As String, Optional ByVal TAG As String = "") As Boolean

        D7122.SpecCode = SpecCode

        wJOB = job : L7122 = D7122

        Link_ISUD7122A = False

        Select Case job
            Case 1
            Case Else
                If READ_PFK7122(L7122.SpecCode) = False Then
                    Call MsgBoxP("3", "LINK_ISUD")

                    Exit Function
                End If
        End Select


        formA = False
        Me.Tag = TAG
        Me.ShowDialog()

        Link_ISUD7122A = isudCHK

    End Function
    Public Function Link_ISUD7122A_AUTO(job As Integer, cdLargeGroupMaterial As String, cdSemiGroupMaterial As String, cdDetailGroupMaterial As String, Optional ByVal TAG As String = "") As Boolean

        D7122.cdLargeGroupMaterial = cdLargeGroupMaterial
        D7122.cdSemiGroupMaterial = cdSemiGroupMaterial
        D7122.cdDetailGroupMaterial = cdDetailGroupMaterial

        wJOB = job : L7122 = D7122

        If READ_PFK7171(ListCode("LargeGroupMaterial"), cdLargeGroupMaterial) Then
            txt_cdLargeGroupMaterial.Data = D7171.BasicName
            txt_cdLargeGroupMaterial.Code = D7171.BasicCode
        End If

        If READ_PFK7171(ListCode("SemiGroupMaterial"), cdSemiGroupMaterial) Then
            txt_cdSemiGroupMaterial.Data = D7171.BasicName
            txt_cdSemiGroupMaterial.Code = D7171.BasicCode
        End If

        If READ_PFK7171(ListCode("DetailGroupMaterial"), cdDetailGroupMaterial) Then
            txt_cdDetailGroupMaterial.Data = D7171.BasicName
            txt_cdDetailGroupMaterial.Code = D7171.BasicCode
        End If
        Link_ISUD7122A_AUTO = False

        Select Case job
            Case 1
            Case Else
                If READ_PFK7122(L7122.SpecCode) = False Then
                    Call MsgBoxP("3", "LINK_ISUD")

                    Exit Function
                End If
        End Select


        formA = False
        Me.Tag = TAG
        Me.ShowDialog()

        Link_ISUD7122A_AUTO = isudCHK

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
                Call DATA_SEARCH_VS1()

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If
                Setfocus(txt_cdLargeGroupMaterial)
                If txt_cdLargeGroupMaterial.Code <> "" Then vs1.Select()

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

                Call DATA_SEARCH()
                Call DATA_SEARCH_VS1()
            Case 3
                Me.Text = Me.Text & " - UPDATE"

                If Pub.DEVCHK <> "1" Then cmd_DEL.Visible = False

                Call DATA_SEARCH()
                Call DATA_SEARCH_VS1()

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

                Call DATA_SEARCH()
                Call DATA_SEARCH_VS1()

        End Select

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Call D7122_CLEAR()

        W7122 = D7122

        KEY_CHK = ""

        txt_SpecCode.Data = ""
    End Sub
    Private Sub FORM_INIT()
        txt_SpecCode.Enabled = False
        vs1.InsChk = True
    End Sub
#End Region

#Region "Function"
    Private Function Data_Check() As Boolean
        Return DataCheck(Me, "PFK7122")
    End Function
    Private Sub DATA_MOVE()
        Call K7122_MOVE(Me, W7122, 1, L7122.SpecCode)

        W7122.seLargeGroupMaterial = ListCode("LargeGroupMaterial")
        W7122.seSemiGroupMaterial = ListCode("SemiGroupMaterial")
        W7122.seDetailGroupMaterial = ListCode("DetailGroupMaterial")

        If rad_CheckUse1.Checked = True Then W7122.CheckUse = "1" Else W7122.CheckUse = "2"
    End Sub

    Private Sub DATA_INSERT()
        Call DATA_MOVE()

        Call KEY_COUNT()
        If WRITE_PFK7122(W7122) = True Then
            Call DATA_MOVE_WRITE()
            isudCHK = True : WRITE_CHK = "*"
        End If

    End Sub
    Private Sub DATA_MOVE_WRITE()
        Dim i As Integer
        Dim j As Integer
        j = 0

        SQL = "DELETE FROM PFK7123 "
        SQL = SQL & " WHERE K7123_SpecCode  = '" & txt_SpecCode.Data & "' "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        cmd.ExecuteNonQuery()

        For i = 0 To vs1.ActiveSheet.RowCount - 1
            If getData(vs1, getColumIndex(vs1, "Width"), i) = "" and getData(vs1, getColumIndex(vs1, "Height"), i) = "" Then GoTo skip
            j = j + 1

            If K7123_MOVE(vs1, i, W7123, txt_SpecCode.Data, getData(vs1, getColumIndex(vs1, "KEY_SpecSeq"), i)) = True Then
                W7123.SpecSeq = j

                W7123.Width = Trim(W7123.Width)
                W7123.Height = Trim(W7123.Height)
                W7123.SizeName = Trim(W7123.SizeName)

                Call REWRITE_PFK7123(W7123)
            Else
                W7123.SpecSeq = j
                W7123.SpecCode = txt_SpecCode.Data

                W7123.Width = Trim(W7123.Width)
                W7123.Height = Trim(W7123.Height)
                W7123.SizeName = Trim(W7123.SizeName)

                If WRITE_PFK7123(W7123) = True Then
                    isudCHK = True
                End If
            End If
skip:
        Next
    End Sub
    Private Sub DATA_UPDATE()
        Call DATA_MOVE()
        W7122.SpecCode = L7122.SpecCode

        If REWRITE_PFK7122(W7122) = True Then
            Call DATA_MOVE_WRITE()
            isudCHK = True

            Me.Dispose()
        End If
        

    End Sub
    Private Sub DATA_DELETE()
        Dim str As String = MsgBoxP("Do you want to delete ?", vbYesNo)
        If str <> vbYes Then Exit Sub

        SQL = "DELETE FROM PFK7123 "
        SQL = SQL & " WHERE K7123_SpecCode  = '" & txt_SpecCode.Data & "' "

        W7122.SpecCode = txt_SpecCode.Data

        If DELETE_PFK7122(W7122) = True Then isudCHK = True
        Me.Dispose()
    End Sub
    Private Sub KEY_COUNT()
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        If KEY_CHK = "*" Then Exit Sub

        SQL = "SELECT MAX(CAST(K7122_SpecCode AS DECIMAL)) AS MAX_CODE FROM PFK7122 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            L7122.SpecCode = "000001"
        Else
            L7122.SpecCode = Format(CIntp(rd!MAX_CODE + 1), "000000")
        End If

        W7122.SpecCode = L7122.SpecCode

        rd.Close()

        txt_SpecCode.Data = W7122.SpecCode
    End Sub

    Private Sub vS1_KeyDown(sender As Object, e As KeyEventArgs) Handles vs1.KeyDown
        If wJOB = 2 Then Exit Sub

        Dim xCOL As Long
        Dim xROW As Long

        xCOL = Vs1.ActiveSheet.ActiveColumnIndex
        xROW = Vs1.ActiveSheet.ActiveRowIndex

        Select e.KeyCode
            Case Keys.Insert
                If xROW = sender.ActiveSheet.RowCount - 1 Then
                    Vs1.ActiveSheet.RowCount += 1
                    Vs1.ActiveSheet.ActiveRowIndex = xROW + 1
                Else
                    Vs1.ActiveSheet.AddRows(xROW, 1)
                End If

            Case Keys.Delete

                Msg_Result = MsgBoxP("Do you want to delete?", vbYesNo)

                If Msg_Result <> vbYes Then Exit Sub

                If K7123_MOVE(vs1, xROW, W7123, txt_SpecCode.Data, getData(vs1, getColumIndex(vs1, "KEY_SpecSeq"), xROW)) Then
                    If DELETE_PFK7123(W7123) = True Then
                        isudCHK = True
                    End If
                End If

                SPR_DEL(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex)
                vs1.Focus()

        End Select
    End Sub


#End Region

#Region "DATA_SEARCH"
    Private Function DATA_SEARCH() As Boolean

        DATA_SEARCH = False

        DS1 = READ_PFK7122(L7122.SpecCode, cn)

        If GetDsRc(DS1) = 0 Then
            Exit Function
            isudCHK = False
        End If

        READER_MOVE(Me, DS1)

        If GetDsData(DS1, 0, "CheckUse") = "1" Then rad_CheckUse1.Checked = True
        If GetDsData(DS1, 0, "CheckUse") = "2" Then rad_CheckUse2.Checked = True

        DATA_SEARCH = True

    End Function


    Private Function DATA_SEARCH_vS1() As Boolean
        DATA_SEARCH_vS1 = False

        DS1 = PrcDS("USP_ISUD7122A_SEARCH_VS1", cn, txt_SpecCode.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_SET(vs1, , , , OperationMode.Normal)
            SPR_PRO(vs1, DS1, "USP_ISUD7122A_SEARCH_VS1", "Vs1")
            vs1.ActiveSheet.RowCount = 10
            vs1.Enabled = True
            Exit Function
        End If

        SPR_SET(vs1, , , , OperationMode.Normal)
        SPR_PRO(vs1, DS1, "USP_ISUD7122A_SEARCH_VS1", "Vs1")

        DATA_SEARCH_vS1 = True
    End Function

#End Region

#Region "Event"
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click

        Select Case wJOB
            Case 1
                If Data_Check() = False Then Exit Sub
                Call DATA_INSERT()

                Call DATA_INIT()
                Call KEY_COUNT()
                Setfocus(txt_cdLargeGroupMaterial)

            Case 2 : Me.Dispose()

            Case 3
                If Data_Check() = False Then Exit Sub
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