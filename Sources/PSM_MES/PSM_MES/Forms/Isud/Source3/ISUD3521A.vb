Public Class ISUD3521A
#Region "Variable"
    Private wJOB As Integer

    Private W3521 As T3521_AREA
    Private L3521 As T3521_AREA

    Private W3522 As T3522_AREA
    Private L3522 As T3522_AREA

    Private WRITE_CHK As String

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD3521A(job As Integer, MachineTestOrder As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D3521.MachineTestOrder = MachineTestOrder
        wJOB = job : L3521 = D3521

        Link_ISUD3521A = False


        Try
            Select Case job
                Case 1
                Case Else
                    If READ_PFK3521(L3521.MachineTestOrder) = False Then
                        Call MsgBoxP("3", "LINK_ISUD")

                        Me.Dispose()
                        Exit Function
                    End If
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD3521A = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("MachineTestOrder"))
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

            Case 2
                Me.Text = "GROUP COMPONENT BOM ISUD3521A" & " - SEARCH"
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
                Me.Text = "GROUP COMPONENT BOM ISUD3521A" & " - UPDATE"
                txt_MachineTestOrder.Enabled = False

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
                Me.Text = "GROUP COMPONENT BOM ISUD3521A" & " - DELETE"

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
            txt_MachineTestOrder.Enabled = False
            Call D3521_CLEAR()
            W3521 = D3521

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Sub FORM_INIT()
        txt_cdMachineType.Enabled = True
    End Sub
#End Region

#Region "Data_Search"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False
        Try

            DS1 = READ_PFK3521(L3521.MachineTestOrder, cn)

            If GetDsRc(DS1) = 0 Then
                Exit Function : Me.Dispose()
                isudCHK = False
            End If

            READER_MOVE(Me, DS1)


            DATA_SEARCH01 = True

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_SEARCH01")
        End Try

    End Function

    Private Function DATA_SEARCH02() As Boolean
        DATA_SEARCH02 = False

        DS1 = PrcDS("USP_ISUD3521A_SEARCH_VS1", cn, L3521.MachineTestOrder)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs1, DS1, "USP_ISUD3521A_SEARCH_VS1", "Vs1")
            Vs1.ActiveSheet.RowCount = 10
            Vs1.Enabled = True
            Exit Function
        End If
        SPR_PRO_NEW(Vs1, DS1, "USP_ISUD3521A_SEARCH_VS1", "Vs1")
        Vs1.AllowRowMove = True
        DATA_SEARCH02 = True


    End Function
#End Region

#Region "Function"

    Private Function Data_Check() As Boolean
        Data_Check = False

        Try
            If wJOB = "1" Then
                If READ_PFK3521(L3521.MachineTestOrder) = True Then
                    Call MsgBoxP("5", "DATA_INSERT")
                    txt_MachineTestOrder.Focus()
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
            Call K3521_MOVE(Me, W3521, 1, txt_MachineTestOrder.Data)

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE"))
        End Try
    End Sub

    Private Sub DATA_MOVE_WRITE01()
        Try

            SQL = "DELETE FROM PFK3522 "
            SQL = SQL & " WHERE K3522_MachineTestOrder  = '" & W3521.MachineTestOrder & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            Dim i As Integer
            Dim j As Integer
            j = 0
            For i = 0 To Vs1.ActiveSheet.RowCount - 1

                If getData(Vs1, getColumIndex(Vs1, "MachineCode"), i) = "" Then GoTo skip

                j = j + 1

                Call D3522_CLEAR() : W3522 = D3522
                Call K3522_MOVE(Vs1, i, W3522, W3522.MachineTestOrder, W3522.MachineTestOrderSeq)

                W3522.MachineTestOrder = L3521.MachineTestOrder
                W3522.MachineTestOrderSeq = j
                W3522.Dseq = j

                Call WRITE_PFK3522(W3522)
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

            W3521.DateTest = Pub.DAT
            W3521.MCStandardCode = getData(Vs1, getColumIndex(Vs1, "MCStandardCode"), 0)

            If WRITE_PFK3521(W3521) = True Then
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
            If REWRITE_PFK3521(W3521) = True Then
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

            If READ_PFK3521(L3521.MachineTestOrder) = True Then
                W3521 = D3521

                SQL = "DELETE FROM PFK3522 "
                SQL = SQL & " WHERE K3522_MachineTestOrder  = '" & W3521.MachineTestOrder & "' "
                cmd = New SqlClient.SqlCommand(SQL, cn)
                cmd.ExecuteNonQuery()

                Call DELETE_PFK3521(W3521)
            End If

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub

    Private Sub KEY_COUNT()
        Try

            SQL = " SELECT MAX(CAST(K3521_MachineTestOrder AS DECIMAL)) as MAX_CODE FROM PFK3521 "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If IsDBNull(rd!MAX_CODE) Then
                W3521.MachineTestOrder = "000000001"
            Else
                W3521.MachineTestOrder = FormatP(CIntp(rd!MAX_CODE + 1), "000000000")
            End If

            rd.Close()

            txt_MachineTestOrder.Data = W3521.MachineTestOrder
            L3521.MachineTestOrder = W3521.MachineTestOrder

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub


#End Region

#Region "Event"

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Select Case wJOB
            Case 1
                'If DataCheck(Me, "PFK3521") = False Then Exit Sub
                'If Data_Check() = False Then Exit Sub
                Call KEY_COUNT()
                Call DATA_INSERT()

                Call FORM_INIT()
                Call DATA_INIT()
                Call KEY_COUNT()

                Me.Dispose()
            Case 2
                Me.Dispose()
            Case 3
                If DataCheck(Me, "PFK3521") = False Then Exit Sub
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
        DS1 = PrcDS("USP_ISUD3521A_SEARCH_VS1_INSERT_MULTI", cn, hlp0000SeVaTt, txt_MCCODE.chkAll.CheckState, txt_MCCODE.SQL)

        Call READ_SPREAD_N(Vs1, DS1, GetDsRc(DS1), "USP_ISUD3521A_SEARCH_VS1", "VS1")
    End Sub


#End Region

End Class