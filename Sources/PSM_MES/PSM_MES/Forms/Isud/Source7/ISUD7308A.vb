Public Class ISUD7308A
#Region "Variable"
    Private wJOB As Integer

    Private W7308 As T7308_AREA
    Private L7308 As T7308_AREA

    Private W7309 As T7309_AREA
    Private L7309 As T7309_AREA

    Private W7310 As T7310_AREA
    Private L7310 As T7310_AREA

    Private WRITE_CHK As String

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7308A(job As Integer, cdMainProcess As String, JobBOMCode As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG

        D7308.JobBOMCode = JobBOMCode
        D7328.cdMainProcess = cdMainProcess

        wJOB = job : L7308 = D7308

        If READ_PFK7171(ListCode("MainProcess"), cdMainProcess) Then
            txt_cdMainProcess.Data = D7171.BasicName
            txt_cdMainProcess.Code = D7171.BasicCode
        End If

        Link_ISUD7308A = False

        Try
            Select Case job
                Case 1
                Case Else
                    txt_cdJobProcessBOM.Visible = False
                    txt_cdProcessBOM.Visible = False

                    If READ_PFK7308(L7308.JobBOMCode) = False Then
                        Call MsgBoxP("3", "LINK_ISUD")

                        Me.Dispose()
                        Exit Function
                    End If
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD7308A = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("JobBOMCode"))
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
                Setfocus(txt_JobBOMName)
                cmd_DEL.Visible = False

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call KEY_COUNT()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()
            Case 2
                Me.Text = "GROUP JOB PROCESS BOM ISUD7308A" & " - SEARCH"

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
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()
            Case 3
                Me.Text = "GROUP JOB PROCESS BOM ISUD7308A" & " - UPDATE"

                txt_JobBOMCode.Enabled = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()

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

            Case 4                                                      '»èÁ¦
                Me.Text = "GROUP JOB PROCESS BOM ISUD7308A" & " - DELETE"

                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()

        End Select

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Try
            txt_JobBOMCode.Enabled = False
            Call D7308_CLEAR()
            W7308 = D7308

            txt_JobBOMName.Data = ""
            txt_Article.Data = ""
            txt_Line.Data = ""

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

            DS1 = READ_PFK7308(L7308.JobBOMCode, cn)

            If GetDsRc(DS1) = 0 Then
                Exit Function : Me.Dispose()
                isudCHK = False
            End If

            READER_MOVE(Me, DS1)

            Call DATA_SEARCH_IMAGE_TOTAL(pic_Picture, Me.Name, L7308.JobBOMCode)

            If READ_PFK7171(GetDsData(DS1, 0, "K7308_selSeasonCode"), GetDsData(DS1, 0, "K7308_cdSeasonCode")) Then
                txt_cdSeason.Code = D7171.BasicCode
                txt_cdSeason.Data = D7171.BasicName
            End If

            If GetDsData(DS1, 0, "K7308_CheckUse") = "1" Then
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

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False

        DS1 = PrcDS("USP_ISUD7308A_SEARCH_VS1", cn, L7308.JobBOMCode)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs1, DS1, "USP_ISUD7308A_SEARCH_VS1", "Vs1")
            Vs1.ActiveSheet.RowCount = 10
            Vs1.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "USP_ISUD7308A_SEARCH_VS1", "Vs1")

        DATA_SEARCH_VS1 = True


    End Function

    Private Function DATA_SEARCH_VS2() As Boolean
        DATA_SEARCH_VS2 = False
        Dim JobBOMSeq As String

        JobBOMSeq = getData(Vs1, getColumIndex(Vs1, "KEY_JobBOMSeq"), Vs1.ActiveSheet.ActiveRowIndex)

        DS1 = PrcDS("USP_ISUD7308A_SEARCH_VS2", cn, L7308.JobBOMCode, JobBOMSeq)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS2, DS1, "USP_ISUD7308A_SEARCH_VS2", "VS2")

            vS2.ActiveSheet.RowCount = 10
            vS2.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS2, DS1, "USP_ISUD7308A_SEARCH_VS2", "VS2")

        DATA_SEARCH_VS2 = True


    End Function
#End Region

#Region "Function"

    Private Function Data_Check() As Boolean
        Data_Check = False

        Try
            If txt_JobBOMName.Data.Trim = "" Then Setfocus(txt_JobBOMName) : Exit Function
            txt_JobBOMName.Data = Replace(txt_JobBOMName.Data, "'", "`")

            If wJOB = "1" Then
                If READ_PFK7308(L7308.JobBOMCode) = True Then
                    Call MsgBoxP("5", "DATA_INSERT")
                    txt_JobBOMCode.Focus()
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

            Call K7308_MOVE(Me, W7308, 1, txt_JobBOMCode.Code)

            W7308.seOrderGroup = ListCode("OrderGroup")
            W7308.seSeason = ListCode("Season")
            W7308.seShoesKind = ListCode("ShoesKind")
            W7308.seShoesType = ListCode("ShoesType")

            If rad_CheckUse1.Checked = True Then W7308.CheckUse = "1"
            If rad_CheckUse2.Checked = True Then W7308.CheckUse = "2"

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE"))
        End Try
    End Sub

    Private Sub DATA_MOVE_WRITE01()
        Try

            SQL = "DELETE FROM PFK7309 "
            SQL = SQL & " WHERE K7309_JobBOMCode  = '" & W7308.JobBOMCode & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            Dim i As Integer
            Dim j As Integer
            j = 0
            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                j = j + 1

                Call D7309_CLEAR() : W7309 = D7309
                Call K7309_MOVE(Vs1, i, W7309, W7309.JobBOMCode, W7309.JobBOMSeq)

                W7309.JobBOMCode = L7308.JobBOMCode
                W7309.JobBOMSeq = j
                W7309.Dseq = j

                W7309.seGroupJobProcess = ListCode("GroupJobProcess")

                Call WRITE_PFK7309(W7309)
skip:
            Next

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE_WRITE01"))
        End Try

    End Sub


    Private Sub DATA_MOVE_WRITE02(JobBOMCode As String, JobBOMSeq As String)
        Try
            SQL = "DELETE FROM PFK7310 "
            SQL = SQL & " WHERE K7310_JobBOMCode  = '" & JobBOMCode & "' "
            SQL = SQL & " AND K7310_JobBOMSeq  = '" & JobBOMSeq & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            Dim i As Integer
            Dim j As Integer
            j = 0
            For i = 0 To vS2.ActiveSheet.RowCount - 1
                j = j + 1

                Call D7310_CLEAR() : W7310 = D7310
                Call K7310_MOVE(vS2, i, W7310, W7310.JobBOMCode, W7310.JobBOMSeq, W7310.JobBOMSno)

                W7310.JobBOMCode = JobBOMCode
                W7310.JobBOMSeq = JobBOMSeq
                W7310.JobBOMSno = j

                W7310.Dseq = j

                W7310.seGroupJobProcess = ListCode("GroupJobProcess")

                Call WRITE_PFK7310(W7310)
skip:
            Next

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE_WRITE01"))
        End Try

    End Sub

    Private Sub DATA_DELETE_WRITE02(JobBOMCode As String, JobBOMSeq As String)
        Try
            SQL = "DELETE FROM PFK7310 "
            SQL = SQL & " WHERE K7310_JobBOMCode  = '" & JobBOMCode & "' "
            SQL = SQL & " AND K7310_JobBOMSeq  = '" & JobBOMSeq & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_DELETE_WRITE02"))
        End Try

    End Sub
    Private Sub DATA_INSERT()
        Try

            Call DATA_MOVE()
            Call KEY_COUNT()

            If WRITE_PFK7308(W7308) = True Then
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
            If REWRITE_PFK7308(W7308) = True Then
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

            If READ_PFK7308(L7308.JobBOMCode) = True Then
                W7308 = D7308

                SQL = "DELETE FROM PFK7309 "
                SQL = SQL & " WHERE K7309_JobBOMCode  = '" & W7308.JobBOMCode & "' "
                cmd = New SqlClient.SqlCommand(SQL, cn)
                cmd.ExecuteNonQuery()

                Call DELETE_PFK7308(W7308)
            End If

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub

    Private Sub KEY_COUNT()
        Try

            SQL = " SELECT MAX(CAST(K7308_JobBOMCode AS DECIMAL)) as MAX_CODE FROM PFK7308 "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If IsDBNull(rd!MAX_CODE) Then
                W7308.JobBOMCode = "000001"
            Else
                W7308.JobBOMCode = Format(CIntp(rd!MAX_CODE + 1), "000000")
            End If

            rd.Close()

            txt_JobBOMCode.Data = W7308.JobBOMCode
            L7308.JobBOMCode = W7308.JobBOMCode

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub


#End Region

#Region "Event"

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Select Case wJOB
            Case 1
                If DataCheck(Me, "PFK7308") = False Then Exit Sub
                'If Data_Check() = False Then Exit Sub
                Call KEY_COUNT()
                Call DATA_INSERT()

                Call FORM_INIT()
                Call DATA_INIT()
                Call KEY_COUNT()
                SPR_CLEAR(Vs1, True)

                Setfocus(txt_JobBOMName)

            Case 2
                Me.Dispose()
            Case 3
                If DataCheck(Me, "PFK7308") = False Then Exit Sub
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

    Private Sub Vs1_ButtonClicked(sender As Object, e As EditorNotifyEventArgs) Handles Vs1.ButtonClicked
        Dim JobBOMCode As String
        Dim JobBOMSeq As String

        Dim cdSubProcess As String
        cdSubProcess = getData(Vs1, getColumIndex(Vs1, "cdSubProcess"), Vs1.ActiveSheet.ActiveRowIndex)
        JobBOMCode = getData(Vs1, getColumIndex(Vs1, "KEY_JobBOMCode"), Vs1.ActiveSheet.ActiveRowIndex)
        JobBOMSeq = getData(Vs1, getColumIndex(Vs1, "KEY_JobBOMSeq"), Vs1.ActiveSheet.ActiveRowIndex)

        If JobBOMCode = "" Then MsgBoxP("Not Save Information!")

        Try
            If e.Column = getColumIndex(Vs1, "CLJobBOM") Then
                If HLP7328A.Link_HLP7328A(txt_cdMainProcess.Code, cdSubProcess) = False Then Exit Sub

                If hlp0000SeVa = "" Then Exit Sub
                DS1 = PrcDS("USP_ISUD7328A_SEARCH_VS1", cn, hlp0000SeVaTt)
                Call READ_SPREAD_N(vS2, DS1, GetDsRc(DS1), "USP_ISUD7308A_SEARCH_VS2", "VS2")

                Call DATA_MOVE_WRITE02(JobBOMCode, JobBOMSeq)
            End If

        Catch ex As Exception

        End Try
    End Sub


    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column

        If e.Column = getColumIndex(Vs1, "CLJobBOM") Then
            Vs1.ActiveSheet.OperationMode = OperationMode.Normal
        Else
            Vs1.ActiveSheet.OperationMode = OperationMode.SingleSelect
        End If
    End Sub

    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        Call DATA_SEARCH_VS2()
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

            Case Keys.Up Or Keys.Down
                Call DATA_SEARCH_VS2()
        End Select
    End Sub


    Private Sub txt_cdJobProcessBOM_Load(sender As Object, e As EventArgs) Handles txt_cdJobProcessBOM.btnTitleClick
        Dim xROW As Integer

        xROW = Vs1.ActiveSheet.ActiveRowIndex
        If Vs1.ActiveSheet.ActiveRowIndex < 0 Then Exit Sub

        If HLP7308A.Link_HLP7308A("") = False Then Exit Sub

        If hlp0000SeVa = "" Then Exit Sub
        DS1 = PrcDS("USP_ISUD7308A_SEARCH_VS1", cn, hlp0000SeVaTt)

        DS2 = READ_PFK7308(hlp0000SeVaTt, cn)
        DS2.Tables(0).Columns.Remove("K7308_JobBOMCode")

        Call READER_MOVE(Me, DS2)

        If READ_PFK7325(GetDsData(DS2, 0, "K7308_ProcessBOMCode")) Then
            txt_ProcessBOMCode.Data = D7325.ProcessBOMCode
            txt_ProcessBOMName.Data = D7325.ProcessBOMName
        End If

        Call READ_SPREAD_N(Vs1, DS1, xROW, GetDsRc(DS1), "USP_ISUD7308A_SEARCH_VS1", "VS1")

    End Sub

    Private Sub txt_cdBaseBOM_Load(sender As Object, e As EventArgs) Handles txt_cdProcessBOM.btnTitleClick
        Dim xROW As Integer

        xROW = Vs1.ActiveSheet.ActiveRowIndex
        If Vs1.ActiveSheet.ActiveRowIndex < 0 Then Exit Sub

        If HLP7325A.Link_HLP7325A(txt_cdMainProcess.Code) = False Then Exit Sub

        If hlp0000SeVa = "" Then Exit Sub
        DS1 = PrcDS("USP_ISUD7325A_SEARCH_VS1", cn, hlp0000SeVaTt)

        If READ_PFK7325(GetDsData(DS1, 0, "ProcessBOMCode")) Then
            txt_ProcessBOMCode.Data = D7325.ProcessBOMCode
            txt_ProcessBOMName.Data = D7325.ProcessBOMName
        End If

        Call READ_SPREAD_N(Vs1, DS1, GetDsRc(DS1), "USP_ISUD7308A_SEARCH_VS1", "VS1")
    End Sub


    Private Sub UPDATEJOBPROCESSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UPDATEJOBPROCESSToolStripMenuItem.Click
        Dim JobBOMCode As String
        Dim JobBOMSeq As String

        Dim cdSubProcess As String
        cdSubProcess = getData(Vs1, getColumIndex(Vs1, "cdSubProcess"), Vs1.ActiveSheet.ActiveRowIndex)
        JobBOMCode = getData(Vs1, getColumIndex(Vs1, "KEY_JobBOMCode"), Vs1.ActiveSheet.ActiveRowIndex)
        JobBOMSeq = getData(Vs1, getColumIndex(Vs1, "KEY_JobBOMSeq"), Vs1.ActiveSheet.ActiveRowIndex)

        If JobBOMCode = "" Then MsgBoxP("Not Save Information!")

        JobBOMCode = getData(Vs1, getColumIndex(Vs1, "KEY_JobBOMCode"), Vs1.ActiveSheet.ActiveRowIndex)
        JobBOMSeq = getData(Vs1, getColumIndex(Vs1, "KEY_JobBOMSeq"), Vs1.ActiveSheet.ActiveRowIndex)

        Call DATA_MOVE_WRITE02(JobBOMCode, JobBOMSeq)
        Call DATA_SEARCH_VS2()
    End Sub
    Private Sub DELETEALLJOBPROCESSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DELETEALLJOBPROCESSToolStripMenuItem.Click
        Dim JobBOMCode As String
        Dim JobBOMSeq As String

        Dim cdSubProcess As String
        cdSubProcess = getData(Vs1, getColumIndex(Vs1, "cdSubProcess"), Vs1.ActiveSheet.ActiveRowIndex)
        JobBOMCode = getData(Vs1, getColumIndex(Vs1, "KEY_JobBOMCode"), Vs1.ActiveSheet.ActiveRowIndex)
        JobBOMSeq = getData(Vs1, getColumIndex(Vs1, "KEY_JobBOMSeq"), Vs1.ActiveSheet.ActiveRowIndex)

        If JobBOMCode = "" Then MsgBoxP("Not Save Information!")

        JobBOMCode = getData(Vs1, getColumIndex(Vs1, "KEY_JobBOMCode"), Vs1.ActiveSheet.ActiveRowIndex)
        JobBOMSeq = getData(Vs1, getColumIndex(Vs1, "KEY_JobBOMSeq"), Vs1.ActiveSheet.ActiveRowIndex)

        Call DATA_DELETE_WRITE02(JobBOMCode, JobBOMSeq)
        Call DATA_SEARCH_VS2()
    End Sub
    Private Sub cmd_AttachID_Click(sender As Object, e As EventArgs) Handles cmd_AttachID.Click
        Call DATA_SEARCH_IMAGE_TOTAL(pic_Picture, Me.Name, L7308.JobBOMCode)
    End Sub
#End Region



End Class