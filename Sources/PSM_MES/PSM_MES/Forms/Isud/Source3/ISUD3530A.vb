Public Class ISUD3530A
#Region "Variable"
    Private wJOB As Integer

    Private W3530 As T3530_AREA
    Private L3530 As T3530_AREA

    Private W3531 As T3531_AREA
    Private L3531 As T3531_AREA

    Private WRITE_CHK As String

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD3530A(job As Integer, cdMachineType As String, MCStandardCode As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D3530.MCStandardCode = MCStandardCode
        D3530.cdMachineType = cdMachineType
        wJOB = job : L3530 = D3530

        Link_ISUD3530A = False

        If READ_PFK7171(ListCode("MachineType"), cdMachineType) Then
            txt_cdMachineType.Data = D7171.BasicName
            txt_cdMachineType.Code = D7171.BasicCode
        End If

        Try
            Select Case job
                Case 1
                Case Else
                    If READ_PFK3530(L3530.MCStandardCode) = False Then
                        Call MsgBoxP("3", "LINK_ISUD")

                        Me.Dispose()
                        Exit Function
                    End If
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD3530A = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("MCStandardCode"))
        End Try


    End Function
#End Region

#Region "Form"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        Me.Form_Initial()
        Me.Form_KeyDown()

        Call DATA_INIT()
        Call FORM_INIT()

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        Select Case wJOB
            Case 1
                Me.Text = Me.Text & " - INSERT"
                cmd_DEL.Visible = False

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call KEY_COUNT()
                Call DATA_SEARCH02()

                Setfocus(txt_MCStandardName)
            Case 2
                Me.Text = "GROUP COMPONENT BOM ISUD3530A" & " - SEARCH"
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
                Call DATA_SEARCH02()
            Case 3
                Me.Text = "GROUP COMPONENT BOM ISUD3530A" & " - UPDATE"
                txt_MCStandardCode.Enabled = False

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
                        cmd_DEL.Visible = False
                        Call MsgBoxP("16", "Form_Activate")
                    End If
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH02()

            Case 4                                                      '»èÁ¦
                Me.Text = "GROUP COMPONENT BOM ISUD3530A" & " - DELETE"

                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH02()

        End Select

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Try
            txt_MCStandardCode.Enabled = False
            Call D3530_CLEAR()
            W3530 = D3530

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Sub FORM_INIT()

    End Sub
#End Region

#Region "Data_Search"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False
        Try

            DS1 = READ_PFK3530(L3530.MCStandardCode, cn)

            If GetDsRc(DS1) = 0 Then
                Exit Function : Me.Dispose()
                isudCHK = False
            End If

            READER_MOVE(Me, DS1)

            If GetDsData(DS1, 0, "K3530_CheckUse") = "1" Then
                rad_CheckUse1.Checked = True
                rad_CheckUse2.Checked = False
            Else
                rad_CheckUse1.Checked = False
                rad_CheckUse2.Checked = True
            End If

            DATA_SEARCH01 = True

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_SEARCH01")
        End Try

    End Function

    Private Function DATA_SEARCH02() As Boolean
        DATA_SEARCH02 = False

        DS1 = PrcDS("USP_ISUD3530A_SEARCH_VS1", cn, L3530.MCStandardCode)

        If GetDsRc(DS1) = 0 Then
            SPR_SET(Vs1, , , , OperationMode.Normal)
            SPR_PRO(Vs1, DS1, "USP_ISUD3530A_SEARCH_VS1", "Vs1")
            Vs1.ActiveSheet.RowCount = 10
            Vs1.Enabled = True
            Exit Function
        End If
        SPR_SET(Vs1, , , , OperationMode.Normal)
        SPR_PRO(Vs1, DS1, "USP_ISUD3530A_SEARCH_VS1", "Vs1")
        Vs1.AllowRowMove = True
        DATA_SEARCH02 = True


    End Function
#End Region

#Region "Function"

    Private Function Data_Check() As Boolean
        Data_Check = False

        Try
            If txt_MCStandardName.Data.Trim = "" Then Setfocus(txt_MCStandardName) : Exit Function
            txt_MCStandardName.Data = Replace(txt_MCStandardName.Data, "'", "`")

            If wJOB = "1" Then
                If READ_PFK3530(L3530.MCStandardCode) = True Then
                    Call MsgBoxP("5", "DATA_INSERT")
                    txt_MCStandardCode.Focus()
                    KEY_COUNT()
                    Exit Function
                End If
            End If


            Data_Check = True
skip_1:
        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))

        End Try
    End Function


    Private Sub DATA_MOVE()
        Try
            Call K3530_MOVE(Me, W3530, 1, txt_MCStandardCode.Data)

            W3530.seMachineType = ListCode("MachineType")

            If rad_CheckUse1.Checked = True Then W3530.CheckUse = "1"
            If rad_CheckUse2.Checked = True Then W3530.CheckUse = "2"

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE"))
        End Try
    End Sub

    Private Sub DATA_MOVE_WRITE01()
        Try

            SQL = "DELETE FROM PFK3531 "
            SQL = SQL & " WHERE K3531_MCStandardCode  = '" & W3530.MCStandardCode & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            Dim i As Integer
            Dim j As Integer
            j = 0
            For i = 0 To Vs1.ActiveSheet.RowCount - 1

                If getData(Vs1, getColumIndex(Vs1, "cdStandardMC"), i) = "" Then GoTo skip

                j = j + 1

                Call D3531_CLEAR() : W3531 = D3531
                Call K3531_MOVE(Vs1, i, W3531, W3531.MCStandardCode, W3531.MCStandardCodeSeq)

                W3531.MCStandardCode = L3530.MCStandardCode
                W3531.MCStandardCodeSeq = j
                W3531.Dseq = j

                W3531.seStandardMC = ListCode("StandardMC")
                Call WRITE_PFK3531(W3531)
skip:
            Next

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE_WRITE01"))
        End Try

    End Sub


    Private Sub DATA_INSERT()
        Try

            Call DATA_MOVE()
            Call KEY_COUNT()

            If WRITE_PFK3530(W3530) = True Then
                Call DATA_MOVE_WRITE01()

                isudCHK = True : WRITE_CHK = "*"
                Exit Sub
            End If
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INSERT")
        End Try

    End Sub

    Private Sub DATA_UPDATE()
        Try
            Call DATA_MOVE()
            If REWRITE_PFK3530(W3530) = True Then
                Call DATA_MOVE_WRITE01()

                isudCHK = True
                Me.Dispose()
            End If

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

    Private Sub DATA_DELETE()
        Try

            If READ_PFK3530(L3530.MCStandardCode) = True Then
                W3530 = D3530

                SQL = "DELETE FROM PFK3531 "
                SQL = SQL & " WHERE K3531_MCStandardCode  = '" & W3530.MCStandardCode & "' "
                cmd = New SqlClient.SqlCommand(SQL, cn)
                cmd.ExecuteNonQuery()

                Call DELETE_PFK3530(W3530)
            End If

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub

    Private Sub KEY_COUNT()
        Try

            SQL = " SELECT MAX(CAST(K3530_MCStandardCode AS DECIMAL)) as MAX_CODE FROM PFK3530 "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If IsDBNull(rd!MAX_CODE) Then
                W3530.MCStandardCode = "000001"
            Else
                W3530.MCStandardCode = Format(CIntp(rd!MAX_CODE + 1), "000000")
            End If

            rd.Close()

            txt_MCStandardCode.Data = W3530.MCStandardCode
            L3530.MCStandardCode = W3530.MCStandardCode

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub


#End Region

#Region "Event"

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Select Case wJOB
            Case 1
                If DataCheck(Me, "PFK3530") = False Then Exit Sub
                'If Data_Check() = False Then Exit Sub
                Call KEY_COUNT()
                Call DATA_INSERT()

                Call FORM_INIT()
                Call DATA_INIT()
                Call KEY_COUNT()

                Setfocus(txt_MCStandardName)
                SPR_CLEAR(Vs1, True)
            Case 2
                Me.Dispose()
            Case 3
                If DataCheck(Me, "PFK3530") = False Then Exit Sub
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

        Dim str As String = MsgBoxP("Do you want to delete it?", vbYesNo)

        If str <> vbYes Then Exit Sub

        Call DATA_DELETE()
    End Sub


    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub


    Private Sub vS1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown
        Dim xCOL As Long
        Dim xROW As Long
        xCOL = Vs1.ActiveSheet.ActiveColumnIndex
        xROW = Vs1.ActiveSheet.ActiveRowIndex

        Select Case e.KeyCode
            Case Keys.Delete

                Call Select_Message("3", WordConv("PROCESSING"), 2)

                If Msg_Result <> vbYes Then Exit Sub

                SPR_DEL(Vs1, xCOL, xROW)
                Vs1.ActiveSheet.ActiveColumnIndex = xCOL
                Vs1.ActiveSheet.ActiveRowIndex = xROW
                Vs1.Focus()

            Case Keys.Enter

        End Select
    End Sub



    Private Sub txt_cdBaseBOM_Load(sender As Object, e As EventArgs) Handles txt_cdBaseBOM.btnTitleClick
        Dim xROW As Integer

        xROW = Vs1.ActiveSheet.ActiveRowIndex
        If Vs1.ActiveSheet.ActiveRowIndex < 0 Then Exit Sub

        If HLP3530A.Link_HLP3530A(txt_cdMachineType.Code, "") = False Then Exit Sub

        If hlp0000SeVa = "" Then Exit Sub
        DS1 = PrcDS("USP_ISUD3530A_SEARCH_VS1", cn, hlp0000SeVaTt)

        Call READ_SPREAD_N(Vs1, DS1, xROW, GetDsRc(DS1), "USP_ISUD3530A_SEARCH_VS1", "VS1")
    End Sub


#End Region



End Class