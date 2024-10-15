Public Class ISUD9998A
#Region "Variable"
    Private wJOB As Integer

    Private WRITE_CHK As String
    Private KEY_CHK As String

    Private W9998 As T9998_AREA
    Private L9998 As T9998_AREA

    Private formA As Boolean
    Private CHK(0 To 5) As String

    Private _BasicName As String

    Private _K9272_PageDate As String
    Private _K9272_PageSeq As String
    Private _K9272_SEQ As String
    Private _FileName As String
    Private _FileType As String

#End Region

#Region "Link"

    Public Function Link_ISUD9998A(job As Integer, PageDate As String, PageSeq As String, Optional ByVal TAG As String = "") As Boolean
        D9998.PageDate = PageDate
        D9998.PageSeq = PageSeq

        wJOB = job : L9998 = D9998

        Link_ISUD9998A = False

        'Select Case job
        '    Case 1
        '        If PageDate = "002" Then

        '            If READ_PFK9998("000", "001") Then
        '                txt_seBasicMaster.Data = D9998.BasicName
        '                txt_seBasicMaster.Code = D9998.PageSeq
        '                txt_seBasicMaster.Enabled = False
        '                txt_cdBasicMaster.Enabled = False
        '            End If


        '        End If

        '    Case Else
        '        If READ_PFK9998(PageDate, PageSeq) Then
        '            txt_seBasicMaster.Code = D9998.seBasicMaster
        '            txt_cdBasicMaster.Code = D9998.cdBasicMaster

        '            If READ_PFK9998("000", txt_seBasicMaster.Code) Then
        '                txt_seBasicMaster.Data = D9998.BasicName
        '            End If

        '            If READ_PFK9998(txt_seBasicMaster.Code, txt_cdBasicMaster.Code) Then
        '                txt_cdBasicMaster.Data = D9998.BasicName
        '            End If

        '        End If

        'End Select


        formA = False
        Me.Tag = TAG
        Me.ShowDialog()

        Link_ISUD9998A = isudCHK
    End Function

#End Region

#Region "Form_Load"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

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
                cmd_DEL.Visible = False
                L9998.PageDate = System_Date_8()

                Call KEY_COUNT()
                Call DATA_SEARCH_VS11_K7171(L9998.PageDate, L9998.PageSeq)
                Setfocus(txt_PageName)



            Case 2
                Me.Text = Me.Text & " - SEARCH"

                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Bloack2.Enabled = False
                ppan_1.Enabled = False
                cmd_DEL.Visible = False
                cmd_OK.Visible = False

                Call DATA_SEARCH01()


            Case 3
                Me.Text = Me.Text & " - UPDATE"

                If CHK(3) <> "1" Then
                    isudCHK = False
                    formA = True
                    Me.Dispose()
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                cmd_DEL.Visible = False
                cmd_OK.Visible = True
                txt_PageDate.Enabled = False

                Call DATA_SEARCH01()
            Case 4
                Me.Text = Me.Text & " - DELETE"
                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Bloack2.Enabled = False
                ppan_1.Enabled = False
                cmd_DEL.Visible = True
                cmd_OK.Visible = False

                Call DATA_SEARCH01()

        End Select

        If Pub.NAM = "PSMADMIN" Then txt_PageDate.Enabled = True : txt_PageSeq.Enabled = True : Block1.Enabled = True

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Call D9998_CLEAR()

        W9998 = D9998
        KEY_CHK = ""
    End Sub
    Private Sub FORM_INIT()

    End Sub
#End Region

#Region "Function"
    Private Function Data_Check() As Boolean
        Data_Check = False

        If Trim$(txt_PageName.Data) = "" Then
            Call MsgBoxP("148", "DATA_CHECK")
            Exit Function
        End If

        Data_Check = True
    End Function
    Private Sub DATA_MOVE()

        W9998.PageDate = Format(CInt(txt_PageDate.Data), "00000000")
        W9998.PageSeq = Format(CInt(txt_PageSeq.Data), "00000")

        W9998.Page = Trim$(txt_Page.Data)
        W9998.PageName = Trim$(txt_PageName.Data)
        W9998.NameSimply = Trim$(txt_NameSimply.Data)
        W9998.ForeignName1 = Trim$(txt_ForeignName1.Data)
        W9998.ForeignName2 = Trim$(txt_ForeignName2.Data)
        W9998.seSubProcess = "002"
        W9998.cdSubProcess = GetSubProcess()

        W9998.Remark = txt_remark.Data

        If rad_CheckUse1.Checked = True Then W9998.CheckUse = "1"
        If rad_CheckUse2.Checked = True Then W9998.CheckUse = "2"



    End Sub
    Private Sub DATA_INSERT()

        If Data_Check() = False Then Exit Sub

        Call DATA_MOVE()

        If READ_PFW9998(W9998.PageDate, W9998.PageSeq) = True Then
            Call MsgBoxP("294", "DATA_INSERT")
            txt_PageDate.Focus()
            Call KEY_COUNT()
            Exit Sub
        End If

        If WRITE_PFW9998(W9998) = True Then
            isudCHK = True
            WRITE_CHK = "*"
            Me.Form_Initial()
            Call FORM_INIT()
            Call DATA_INIT()
            Call KEY_COUNT()
            txt_Page.Focus()
        End If

    End Sub
    Private Sub DATA_UPDATE()
        If Data_Check() = False Then Exit Sub
        Call DATA_MOVE()

        If Block1.Enabled = True Then
            If REWRITE_PFW9998(W9998) = True Then isudCHK = True
        Else
            If REWRITE_PFW9998(W9998) = True Then isudCHK = True
        End If

        Me.Dispose()

    End Sub

    Private Sub DATA_DELETE()
        If Pub.NAM <> "PSMADMIN" Then MsgBoxP("DATA_DELETE", "003") : Exit Sub

        DATA_MOVE()
        If DELETE_PFW9998(W9998) = True Then isudCHK = True

        Me.Dispose()
    End Sub

    Private Sub KEY_COUNT()
        If KEY_CHK = "*" Then Exit Sub

        SQL = " SELECT MAX(CAST(W9998_PageSeq AS DECIMAL)) AS MAX_CODE FROM PFW9998 "
        SQL = SQL & " WHERE W9998_PageDate = '" & L9998.PageDate & "' "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            L9998.PageSeq = "001"
        Else
            L9998.PageSeq = Format(CInt(rd!MAX_CODE + 1), "000")
        End If

        W9998.PageDate = L9998.PageDate
        W9998.PageSeq = L9998.PageSeq

        rd.Close()

        txt_PageDate.Data = W9998.PageDate
        txt_PageSeq.Data = W9998.PageSeq

    End Sub

    Private Function GetSubProcess() As String
        GetSubProcess = ""
        Try
            Dim i As Integer = 0
            For i = 0 To Vs1.ActiveSheet.RowCount - 1 Step 1
                If CBool(getData(Vs1, getColumIndex(Vs1, "PCHK_PFW99981_VS1"), i)) = True Then
                    Dim asd As String = getData(Vs1, getColumIndex(Vs1, "Key_BasicCode_PFW99981_VS1"), i)
                    GetSubProcess = GetSubProcess & ";" & Format(CInt(getData(Vs1, getColumIndex(Vs1, "Key_BasicCode_PFW99981_VS1"), i)), "000")
                End If
            Next
            GetSubProcess = GetSubProcess.Substring(1)

        Catch ex As Exception

        End Try
    End Function


#End Region

#Region "DATA_SEARCH"
    Private Function DATA_SEARCH01() As Boolean

        DATA_SEARCH01 = False

        rd = PrcDR("PSM_USP_PFW99981_SEARCH_VS1_LINE", cn, L9998.PageDate, L9998.PageSeq)
        rd.Read()
        If rd.HasRows = False Then
            rd.Close() : isudCHK = False
            Me.Dispose() : Exit Function
        End If

        txt_PageDate.Data = rd("KEY_PageDate")
        txt_PageSeq.Data = rd("KEY_PageSeq")

        txt_Page.Data = rd("W9998_Page")
        txt_PageName.Data = rd("W9998_PageName")
        txt_NameSimply.Data = rd("W9998_NameSimply")
        txt_ForeignName1.Data = rd("W9998_ForeignName1")
        txt_ForeignName2.Data = rd("W9998_ForeignName2")

        txt_remark.Data = rd("W9998_Remark")

        If rd("W9998_CheckUse") = "1" Then rad_CheckUse1.Checked = True
        If rd("W9998_CheckUse") = "2" Then rad_CheckUse2.Checked = True

        rd.Close()

        Call DATA_SEARCH_VS11_K7171(L9998.PageDate, L9998.PageSeq)

        DATA_SEARCH01 = True

    End Function

    Private Function DATA_SEARCH_VS11_K7171(PageDate As String, PageSeq As String) As Boolean
        DATA_SEARCH_VS11_K7171 = False

        Try
            Me.Cursor = Cursors.WaitCursor
            TableLayoutPanel1.Enabled = False

            Vs1.Enabled = False
            Dim DS As New DataSet
            DS = PrcDS("PSM_USP_PFW99981_SEARCH_VS1_K7171", cn, PageDate, PageSeq)

            If GetDsRc(DS) = 0 Then
                Vs1.ActiveSheet.RowCount = 0

                Vs1.Enabled = True
                Me.Cursor = Cursors.Default
                TableLayoutPanel1.Enabled = True

                Exit Function
            End If

            Call SPR_PRO_NEW(Vs1, DS, "PSM_USP_PFW99981_SEARCH_VS1_K7171", "VS1")

            Vs1.Enabled = True

            Me.Cursor = Cursors.Default
            TableLayoutPanel1.Enabled = True

            DATA_SEARCH_VS11_K7171 = True
        Catch ex As Exception
            MsgBoxP("ERROR IN PSM_USP_PFW99981_SEARCH_VS1_K7171")
        Finally
            Vs1.Enabled = True
            Me.Cursor = Cursors.Default
            TableLayoutPanel1.Enabled = True
        End Try
    End Function

#End Region

#Region "Event"
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If Bol_AutoInsert = False Then
            If MsgBoxPPW("Please type the password to modify!", const_pwPO) = False Then Exit Sub
        End If

        Select Case wJOB
            Case 1 : Call DATA_INSERT()
            Case 2 : Me.Dispose()
            Case 3 : Call DATA_UPDATE()
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
        If MsgBoxPPW("Please type the password to modify!", const_pwPO) = False Then Exit Sub

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