Public Class ISUD7325A
#Region "Variable"
    Private wJOB As Integer

    Private W7325 As T7325_AREA
    Private L7325 As T7325_AREA

    Private W7326 As T7326_AREA
    Private L7326 As T7326_AREA

    Private WRITE_CHK As String

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7325A(job As Integer, cdMainProcess As String, ProcessBOMCode As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D7325.ProcessBOMCode = ProcessBOMCode
        D7325.cdMainProcess = cdMainProcess

        If job = "1" Then
            D7325.ProcessBOMCode = ""
            D7325.ShoesCode = ProcessBOMCode
            txt_ShoesCode.Data = ProcessBOMCode
        End If

        wJOB = job : L7325 = D7325
        Link_ISUD7325A = False

        If READ_PFK7171(ListCode("MainProcess"), cdMainProcess) Then
            txt_cdMainProcess.Data = D7171.BasicName
            txt_cdMainProcess.Code = D7171.BasicCode
        End If

        Try
            Select Case job
                Case 1
                Case Else
                    If READ_PFK7325(L7325.ProcessBOMCode) = False Then
                        Call MsgBoxP("3", "LINK_ISUD")

                        Me.Dispose()
                        Exit Function
                    End If
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD7325A = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("ProcessBOMCode"))
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
            Case 1                                                      'ÀÔ·Â
                Me.Text = Me.Text & " - INSERT"
                Setfocus(txt_ProcessBOMName)
                cmd_DEL.Visible = False

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call KEY_COUNT()

                Call DATA_SEARCH01()
                Call DATA_SEARCH02()
            Case 2
                Me.Text = Me.Text & " - SEARCH"

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
                Me.Text = Me.Text & " - UPDATE"

                txt_ProcessBOMCode.Enabled = False

                Call DATA_SEARCH01()
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
                        cmd_DEL.Visible = False
                        Call MsgBoxP("16", "Form_Activate")
                    End If
                End If

            Case 4
                Me.Text = Me.Text & " - DELETE"

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
            txt_ProcessBOMCode.Enabled = False
            Call D7325_CLEAR()
            W7325 = D7325

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

            If READ_PFK7325(L7325.ProcessBOMCode) Then
                L7325.ShoesCode = D7325.ShoesCode
            End If

            DS1 = READ_PFK7106(L7325.ShoesCode, cn)

            If GetDsRc(DS1) > 0 Then
                READER_MOVE(Me, DS1)
            End If
            DS1 = Nothing

            DS1 = READ_PFK7325(L7325.ProcessBOMCode, cn)

            If GetDsRc(DS1) = 0 Then
                Exit Function
                isudCHK = False
            End If

            READER_MOVE(Me, DS1)

            If READ_PFK7171(GetDsData(DS1, 0, "K7325_selSeasonCode"), GetDsData(DS1, 0, "K7325_cdSeasonCode")) Then
                txt_cdSeason.Code = D7171.BasicCode
                txt_cdSeason.Data = D7171.BasicName
            End If

            If GetDsData(DS1, 0, "K7325_CheckUse") = "1" Then
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

        DS1 = PrcDS("USP_ISUD7325A_SEARCH_VS1", cn, L7325.ProcessBOMCode)

        If GetDsRc(DS1) = 0 Then
            SPR_SET(Vs1, , , , OperationMode.Normal)
            SPR_PRO(Vs1, DS1, "USP_ISUD7325A_SEARCH_VS1", "Vs1")
            Vs1.ActiveSheet.RowCount = 10
            Vs1.Enabled = True
            Exit Function
        End If
        SPR_SET(Vs1, , , , OperationMode.Normal)
        SPR_PRO(Vs1, DS1, "USP_ISUD7325A_SEARCH_VS1", "Vs1")

        DATA_SEARCH02 = True


    End Function
#End Region

#Region "Function"

    Private Function Data_Check() As Boolean
        Data_Check = False

        Try
            If txt_ProcessBOMName.Data.Trim = "" Then Setfocus(txt_ProcessBOMName) : Exit Function
            txt_ProcessBOMName.Data = Replace(txt_ProcessBOMName.Data, "'", "`")

            If wJOB = "1" Then
                If READ_PFK7325(L7325.ProcessBOMCode) = True Then
                    Call MsgBoxP("5", "DATA_INSERT")
                    txt_ProcessBOMCode.Focus()
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

            Call K7325_MOVE(Me, W7325, 1, txt_ProcessBOMCode.Code)

            W7325.seMainProcess = ListCode("MainProcess")
            W7325.ShoesCode = txt_ShoesCode.Data

            If rad_CheckUse1.Checked = True Then W7325.CheckUse = "1"
            If rad_CheckUse2.Checked = True Then W7325.CheckUse = "2"

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE"))
        End Try
    End Sub

    Private Sub DATA_MOVE_WRITE01()
        Try

            SQL = "DELETE FROM PFK7326 "
            SQL = SQL & " WHERE K7326_ProcessBOMCode  = '" & W7325.ProcessBOMCode & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            Dim i As Integer
            Dim j As Integer
            j = 0
            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                j = j + 1

                Call D7326_CLEAR() : W7326 = D7326
                Call K7326_MOVE(Vs1, i, W7326, W7326.ProcessBOMCode, W7326.ProcessBOMSeq)

                W7326.ProcessBOMCode = L7325.ProcessBOMCode
                W7326.ProcessBOMSeq = j
                W7326.Dseq = j

                W7326.cdMainProcess = txt_cdMainProcess.Code

                W7326.seMainProcess = ListCode("MainProcess")
                W7326.seSubProcess = ListCode("SubProcess")

                Call WRITE_PFK7326(W7326)
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

            If WRITE_PFK7325(W7325) = True Then
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
            If REWRITE_PFK7325(W7325) = True Then
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

            If READ_PFK7325(L7325.ProcessBOMCode) = True Then
                W7325 = D7325

                SQL = "DELETE FROM PFK7326 "
                SQL = SQL & " WHERE K7326_ProcessBOMCode  = '" & W7325.ProcessBOMCode & "' "
                cmd = New SqlClient.SqlCommand(SQL, cn)
                cmd.ExecuteNonQuery()

                Call DELETE_PFK7325(W7325)
            End If

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub

    Private Sub KEY_COUNT()
        Try

            SQL = " SELECT MAX(CAST(K7325_ProcessBOMCode AS DECIMAL)) as MAX_CODE FROM PFK7325 "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If IsDBNull(rd!MAX_CODE) Then
                W7325.ProcessBOMCode = "000001"
            Else
                W7325.ProcessBOMCode = Format(CIntp(rd!MAX_CODE + 1), "000000")
            End If

            rd.Close()

            txt_ProcessBOMCode.Data = W7325.ProcessBOMCode
            L7325.ProcessBOMCode = W7325.ProcessBOMCode

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub


#End Region

#Region "Event"

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Select Case wJOB
            Case 1
                If DataCheck(Me, "PFK7325") = False Then Exit Sub
                'If Data_Check() = False Then Exit Sub
                Call KEY_COUNT()
                Call DATA_INSERT()
                Me.Dispose()
            Case 2
                Me.Dispose()
            Case 3
                If DataCheck(Me, "PFK7325") = False Then Exit Sub
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
        Me.Dispose()
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

        If HLP7325A.Link_HLP7325A(txt_cdMainProcess.Code) = False Then Exit Sub

        If hlp0000SeVa = "" Then Exit Sub
        DS1 = PrcDS("USP_ISUD7325A_SEARCH_VS1", cn, hlp0000SeVaTt)

        DS2 = READ_PFK7325(hlp0000SeVaTt, cn)
        DS2.Tables(0).Columns.Remove("K7325_ProcessBOMCode")

        Call READER_MOVE(Me, DS2)

        Call READ_SPREAD_N(Vs1, DS1, xROW, GetDsRc(DS1), "USP_ISUD7325A_SEARCH_VS1", "VS1")
    End Sub


#End Region



End Class