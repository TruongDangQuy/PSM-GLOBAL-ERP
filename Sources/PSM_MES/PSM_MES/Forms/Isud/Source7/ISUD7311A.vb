Public Class ISUD7311A
#Region "Variable"
    Private wJOB As Integer

    Private W7311 As T7311_AREA
    Private L7311 As T7311_AREA

    Private W7312 As T7312_AREA
    Private L7312 As T7312_AREA

    Private W7313 As T7313_AREA
    Private L7313 As T7313_AREA

    Private WRITE_CHK As String

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7311A(job As Integer, JobBOMCode As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG

        D7311.JobBOMCode = JobBOMCode

        If job = "1" Then
            D7311.JobBOMCode = ""
            D7311.ProcessBOMCode = JobBOMCode

            If READ_PFK7305(D7311.ProcessBOMCode) Then
                txt_ShoesCode.Data = D7305.ShoesCode
                txt_ProcessBOMCode.Data = D7305.ProcessBOMCode
                txt_ProcessBOMName.Data = D7305.ProcessBOMName
            End If

        End If

        wJOB = job : L7311 = D7311

        Link_ISUD7311A = False

        Try
            Select Case job
                Case 1
                Case Else
                    If READ_PFK7311(L7311.JobBOMCode) = False Then
                        Call MsgBoxP("3", "LINK_ISUD")

                        Me.Dispose()
                        Exit Function
                    End If
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD7311A = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("JobBOMCode"))
        End Try


    End Function
#End Region

#Region "Form"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        Me.Form_KeyDown()

        Call DATA_INIT()
        Call FORM_INIT()

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        Select Case wJOB
            Case 1                                                      'ÀÔ·Â
                Me.Text = Me.Text & " - INSERT"
                Setfocus(txt_JobBOMName)
                Frame1.Enabled = True
                tst_iDelete.Visible = False

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call KEY_COUNT()
                Call DATA_SEARCH01()


                Call DATA_SEARCH_VS1()

                tst_iSave.PerformClick()


                Call DATA_SEARCH_VS2()

                Setfocus(txt_JobBOMName)
            Case 2
                Me.Text = Me.Text & " - SEARCH"

                Frame1.Enabled = True
                tst_iDelete.Visible = False
                tst_iSave.Visible = False

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
                Me.Text = Me.Text & " - UPDATE"

                Frame1.Enabled = True
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
                        tst_iDelete.Visible = False
                        Call MsgBoxP("16", "Form_Activate")
                    End If
                End If

            Case 4
                Me.Text = Me.Text & " - DELETE"

                Frame1.Enabled = False

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
            Call D7311_CLEAR()
            W7311 = D7311

            tst_iPrint.Visible = False
            tst_iUtilities.Visible = True
            tst_iAttach.Visible = True
            tst_iHistory.Visible = False
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
            '''''''''''''''''''''''''''S Shoe Code'''''''''''''''''''''''''''''''''
            If READ_PFK7311(L7311.JobBOMCode) Then
                If READ_PFK7305(D7311.ProcessBOMCode) Then
                    txt_ShoesCode.Data = D7305.ShoesCode

                End If
            End If

            DS1 = READ_PFK7106(txt_ShoesCode.Data, cn)

            If GetDsRc(DS1) > 0 Then
                READER_MOVE(Me, DS1)
                txt_JobBOMName.Data = txt_Line.Data & "-" & txt_Article.Data & "-" & txt_ColorName.Data
            End If
            DS1 = Nothing
            '''''''''''''''''''''''''''E Shoe Code'''''''''''''''''''''''''''''''''

            DS1 = READ_PFK7311(L7311.JobBOMCode, cn)

            If GetDsRc(DS1) = 0 Then
                Exit Function : Me.Dispose()
                isudCHK = False
            End If

            READER_MOVE(Me, DS1)

            Call DATA_SEARCH_IMAGE_TOTAL(pic_Picture, Me.Name, L7311.JobBOMCode)

            If READ_PFK7171(GetDsData(DS1, 0, "K7311_selSeasonCode"), GetDsData(DS1, 0, "K7311_cdSeasonCode")) Then
                txt_cdSeason.Code = D7171.BasicCode
                txt_cdSeason.Data = D7171.BasicName
            End If

            If GetDsData(DS1, 0, "K7311_CheckUse") = "1" Then
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

        DS1 = PrcDS("USP_ISUD7311A_SEARCH_VS1", cn, L7311.JobBOMCode)

        If GetDsRc(DS1) = 0 Then
            'SPR_PRO_NEW(Vs1, DS1, "USP_ISUD7311A_SEARCH_VS1", "Vs1")

            'DS2 = PrcDS("USP_ISUD7311A_SEARCH_VS1_INSERT", cn, txt_ProcessBOMCode.Data)
            'Call READ_SPREAD_N(Vs1, DS2, GetDsRc(DS2), "USP_ISUD7311A_SEARCH_VS1", "VS1")

            DS2 = PrcDS("USP_ISUD7311A_SEARCH_VS1_INSERT", cn, txt_ProcessBOMCode.Data)
            SPR_PRO_NEW(Vs1, DS2, "USP_ISUD7311A_SEARCH_VS1", "Vs1")

            Vs1.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "USP_ISUD7311A_SEARCH_VS1", "Vs1")

        DATA_SEARCH_VS1 = True


    End Function

    Private Function DATA_SEARCH_VS1_LINE() As Boolean
        DATA_SEARCH_VS1_LINE = False
        Dim xrow As Integer
        Dim JobBOMSeq As String

        JobBOMSeq = getData(Vs1, getColumIndex(Vs1, "KEY_JobBOMSeq"), Vs1.ActiveSheet.ActiveRowIndex)

        xrow = Vs1.ActiveSheet.ActiveRowIndex

        DS1 = PrcDS("USP_ISUD7311A_SEARCH_VS1_LINE", cn, L7311.JobBOMCode, JobBOMSeq)

        If GetDsRc(DS1) = 0 Then
            Exit Function
        End If

        READ_SPREAD(Vs1, DS1, "USP_ISUD7311A_SEARCH_VS1", "Vs1", xrow)

        DATA_SEARCH_VS1_LINE = True
    End Function

    Private Function DATA_SEARCH_VS2() As Boolean
        DATA_SEARCH_VS2 = False
        Dim JobBOMSeq As String

        JobBOMSeq = getData(Vs1, getColumIndex(Vs1, "KEY_JobBOMSeq"), Vs1.ActiveSheet.ActiveRowIndex)

        DS1 = PrcDS("USP_ISUD7311A_SEARCH_VS2", cn, L7311.JobBOMCode, JobBOMSeq)

        If GetDsRc(DS1) = 0 Then
            DS2 = PrcDS("USP_ISUD7311A_SEARCH_VS2_INSERT_F1", cn, txt_ShoesCode.Data)
            SPR_PRO_NEW(vS2, DS2, "USP_ISUD7311A_SEARCH_VS2", "VS2")
            SPR_INSERT(vS2)

            vS2.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS2, DS1, "USP_ISUD7311A_SEARCH_VS2", "VS2")

        DATA_SEARCH_VS2 = True


    End Function
#End Region

#Region "Function"

    Private Function Data_Check() As Boolean
        Data_Check = False
        Dim i As Integer

        Try
            If txt_JobBOMName.Data.Trim = "" Then Setfocus(txt_JobBOMName) : Exit Function
            txt_JobBOMName.Data = Replace(txt_JobBOMName.Data, "'", "`")

            If wJOB = "1" Then
                If READ_PFK7311(L7311.JobBOMCode) = True Then
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

            Call K7311_MOVE(Me, W7311, 1, txt_JobBOMCode.Code)

            W7311.seOrderGroup = ListCode("OrderGroup")
            W7311.seSeason = ListCode("Season")
            W7311.seShoesKind = ListCode("ShoesKind")
            W7311.seShoesType = ListCode("ShoesType")

            If rad_CheckUse1.Checked = True Then W7311.CheckUse = "1"
            If rad_CheckUse2.Checked = True Then W7311.CheckUse = "2"

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE"))
        End Try
    End Sub

    Private Sub DATA_MOVE_WRITE01()
        Try

            'SQL = "DELETE FROM PFK7312 "
            'SQL = SQL & " WHERE K7312_JobBOMCode  = '" & W7311.JobBOMCode & "' "

            'cmd = New SqlClient.SqlCommand(SQL, cn)
            'cmd.ExecuteNonQuery()

            Dim i As Integer
            Dim j As Integer
            j = 0
            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                j = j + 1

                Call D7312_CLEAR() : W7312 = D7312

                W7312.JobBOMCode = getData(Vs1, getColumIndex(Vs1, "KEY_JobBOMCode"), i)
                W7312.JobBOMCode = txt_JobBOMCode.Data
                W7312.JobBOMSeq = CIntp(getData(Vs1, getColumIndex(Vs1, "KEY_JobBOMSeq"), i))

                If K7312_MOVE(Vs1, i, W7312, W7312.JobBOMCode, W7312.JobBOMSeq) = False Then

                    W7312.JobBOMCode = L7311.JobBOMCode
                    Call KEY_COUNT_SEQ()

                    W7312.Dseq = j

                    W7312.seGroupJobProcess = ListCode("GroupJobProcess")

                    Call WRITE_PFK7312(W7312)

                Else
                    W7312.Dseq = j
                    W7312.seGroupJobProcess = ListCode("GroupJobProcess")

                    Call REWRITE_PFK7312(W7312)
                End If
skip:
            Next

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE_WRITE01"))
        End Try

    End Sub

    Private Sub KEY_COUNT_SEQ()
        Try

            SQL = " SELECT MAX(K7312_JobBOMSeq) as MAX_CODE FROM PFK7312 "
            SQL = SQL + " WHERE K7312_JobBOMCode  = '" & L7311.JobBOMCode & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If IsDBNull(rd!MAX_CODE) Then
                W7312.JobBOMSeq = 1
            Else
                W7312.JobBOMSeq = CIntp(rd!MAX_CODE + 1)
            End If

            rd.Close()

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

    Private Sub KEY_COUNT_SNO(JobBOMCode As String, JobBOMSeq As String)
        Try

            SQL = " SELECT MAX(K7313_JobBOMSno) as MAX_CODE FROM PFK7313 "
            SQL = SQL + " WHERE K7313_JobBOMCode  = '" & JobBOMCode & "' "
            SQL = SQL + " AND K7313_JobBOMSeq  = '" & JobBOMSeq & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If IsDBNull(rd!MAX_CODE) Then
                W7313.JobBOMSno = 1
            Else
                W7313.JobBOMSno = CIntp(rd!MAX_CODE + 1)
            End If

            rd.Close()

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

    Private Function DATA_MOVE_WRITE02() As Boolean
        DATA_MOVE_WRITE02 = False

        Dim JobBOMCode As String, JobBOMSeq As String
        JobBOMCode = getData(Vs1, getColumIndex(Vs1, "KEY_JobBOMCode"), Vs1.ActiveSheet.ActiveRowIndex)
        JobBOMSeq = getData(Vs1, getColumIndex(Vs1, "KEY_JobBOMSeq"), Vs1.ActiveSheet.ActiveRowIndex)

        If READ_PFK7312(JobBOMCode, JobBOMSeq) = False Then Exit Function

        Try
            'SQL = "DELETE FROM PFK7313 "
            'SQL = SQL & " WHERE K7313_JobBOMCode  = '" & JobBOMCode & "' "
            'SQL = SQL & " AND K7313_JobBOMSeq  = '" & JobBOMSeq & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            Dim i As Integer
            Dim j As Integer
            j = 0
            For i = 0 To vS2.ActiveSheet.RowCount - 1

                If getData(vS2, getColumIndex(vS2, "CheckUse"), i) <> "1" Then GoTo skip
                j = j + 1

                Call D7313_CLEAR() : W7313 = D7313

                W7313.JobBOMCode = JobBOMCode
                W7313.JobBOMSeq = JobBOMSeq
                W7313.JobBOMSno = CIntp(getData(vS2, getColumIndex(vS2, "KEY_JobBOMSno"), i))

                If K7313_MOVE(vS2, i, W7313, W7313.JobBOMCode, W7313.JobBOMSeq, W7313.JobBOMSno) = False Then

                    W7313.JobBOMCode = JobBOMCode
                    W7313.JobBOMSeq = JobBOMSeq

                    Call KEY_COUNT_SNO(JobBOMCode, JobBOMSeq)

                    W7313.Dseq = j

                    W7313.seShoesStatus = ListCode("ShoesStatus")
                    W7313.seSpecialProcess = ListCode("SpecialProcess")
                    W7313.seUnitMaterial = ListCode("UnitMaterial")

                    Call WRITE_PFK7313(W7313)

                Else
                    W7313.Dseq = j

                    W7313.seShoesStatus = ListCode("ShoesStatus")
                    W7313.seSpecialProcess = ListCode("SpecialProcess")
                    W7313.seUnitMaterial = ListCode("UnitMaterial")

                    Call REWRITE_PFK7313(W7313)

                End If
skip:
            Next

            DATA_MOVE_WRITE02 = True

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE_WRITE01"))
        End Try

    End Function

    Private Sub DATA_DELETE_WRITE02(JobBOMCode As String, JobBOMSeq As String)
        Try
            SQL = "DELETE FROM PFK7313 "
            SQL = SQL & " WHERE K7313_JobBOMCode  = '" & JobBOMCode & "' "
            SQL = SQL & " AND K7313_JobBOMSeq  = '" & JobBOMSeq & "' "

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

            If WRITE_PFK7311(W7311) = True Then
                Call DATA_MOVE_WRITE01()
                Call DATA_MOVE_WRITE02()
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
            If REWRITE_PFK7311(W7311) = True Then


                Call DATA_MOVE_WRITE02()

                isudCHK = True
            End If

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

    Private Sub DATA_DELETE()
        Try

            If READ_PFK7311(L7311.JobBOMCode) = True Then
                W7311 = D7311

                SQL = "DELETE FROM PFK7312 "
                SQL = SQL & " WHERE K7312_JobBOMCode  = '" & W7311.JobBOMCode & "' "
                cmd = New SqlClient.SqlCommand(SQL, cn)
                cmd.ExecuteNonQuery()

                If DELETE_PFK7311(W7311) Then
                    isudCHK = True
                End If
            End If

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub

    Private Sub KEY_COUNT()
        Try

            SQL = " SELECT MAX(CAST(K7311_JobBOMCode AS DECIMAL)) as MAX_CODE FROM PFK7311 "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If IsDBNull(rd!MAX_CODE) Then
                W7311.JobBOMCode = "000001"
            Else
                W7311.JobBOMCode = Format(CIntp(rd!MAX_CODE + 1), "000000")
            End If

            rd.Close()

            txt_JobBOMCode.Data = W7311.JobBOMCode
            L7311.JobBOMCode = W7311.JobBOMCode

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub


#End Region

#Region "Event"

    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        Select Case wJOB
            Case 1
                If Data_Check() = False Then Exit Sub
                If DataCheck(Me, "PFK7311") = False Then Exit Sub

                Call KEY_COUNT()
                Call DATA_INSERT()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()
                wJOB = 3

            Case 2
                Me.Dispose()
            Case 3
                If Data_Check() = False Then Exit Sub
                If DataCheck(Me, "PFK7311") = False Then Exit Sub

                SQL = "SELECT * FROM PFK7312 "
                SQL = SQL & " WHERE K7312_JobBOMCode  = '" & L7311.JobBOMCode & "' "
                cmd = New SqlClient.SqlCommand(SQL, cn)
                rd = cmd.ExecuteReader

                If rd.HasRows = False Then
                    rd.Close()
                    Call DATA_MOVE_WRITE01()
                    Call DATA_SEARCH_VS1()
                End If

                rd.Close()

                Call DATA_UPDATE()

                Call DATA_SEARCH_VS2()
                Call DATA_SEARCH_VS1_LINE()

            Case 4
                Call DATA_DELETE()
        End Select
    End Sub

    Private Sub tst_iClose_Click(sender As Object, e As EventArgs) Handles tst_iClose.Click
        If WRITE_CHK = "*" Then
            isudCHK = True
        Else
            isudCHK = False
        End If

        Me.Dispose()
    End Sub

    Private Sub tst_iDelete_Click(sender As Object, e As EventArgs) Handles tst_iDelete.Click
        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        If CHK(4) <> "1" Then
            Call MsgBoxP("4", "tst_iDelete_Click")
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
        Dim xCOL As Integer
        Dim xROW As Integer
        xCOL = vS1.ActiveSheet.ActiveColumnIndex
        xROW = vS1.ActiveSheet.ActiveRowIndex

        Select Case e.KeyCode
            Case Keys.Delete

                Call Select_Message("3", WordConv("PROCESSING"), 2)

                If Msg_Result <> vbYes Then Exit Sub

                Dim JobBOMCode As String
                Dim JobBOMSeq As String

                JobBOMCode = getData(Vs1, getColumIndex(Vs1, "KEY_JobBOMCode"), Vs1.ActiveSheet.ActiveRowIndex)
                JobBOMSeq = getData(Vs1, getColumIndex(Vs1, "KEY_JobBOMSeq"), Vs1.ActiveSheet.ActiveRowIndex)

                If READ_PFK7312(JobBOMCode, JobBOMSeq) = False Then Exit Sub

                SQL = "DELETE FROM PFK7313 "
                SQL = SQL & " WHERE K7313_JobBOMCode  = '" & JobBOMCode & "' "
                SQL = SQL & " AND K7313_JobBOMSeq  = '" & JobBOMSeq & "' "

                cmd = New SqlClient.SqlCommand(SQL, cn)
                cmd.ExecuteNonQuery()

                Call DATA_SEARCH_VS2()
                Call DATA_SEARCH_VS1_LINE()

                Vs1.ActiveSheet.ActiveColumnIndex = xCOL
                Vs1.ActiveSheet.ActiveRowIndex = xROW
                Vs1.Focus()

        End Select
    End Sub

    Private Sub vS2_ButtonClicked(sender As Object, e As EditorNotifyEventArgs) Handles vS2.ButtonClicked
        Try
            Dim i As Integer

            If e.Column = getColumIndex(vS2, "CLcdSpecialProcess") Then
                For i = 0 To vS2.ActiveSheet.RowCount - 1
                    If getDataM(vS2, getColumIndex(vS2, "CheckUse"), i) = "1" Then
                        setData(vS2, getColumIndex(vS2, "cdSpecialProcess"), i, getData(vS2, getColumIndex(vS2, "cdSpecialProcess"), e.Row))
                        setData(vS2, getColumIndex(vS2, "cdSpecialProcessName"), i, getData(vS2, getColumIndex(vS2, "cdSpecialProcessName"), e.Row))
                    End If
                Next


            ElseIf e.Column = getColumIndex(vS2, "CLcdUnitmaterial") Then
                For i = 0 To vS2.ActiveSheet.RowCount - 1
                    If getDataM(vS2, getColumIndex(vS2, "CheckUse"), i) = "1" Then
                        setData(vS2, getColumIndex(vS2, "cdUnitmaterial"), i, getData(vS2, getColumIndex(vS2, "cdUnitmaterial"), e.Row))
                        setData(vS2, getColumIndex(vS2, "cdUnitmaterialName"), i, getData(vS2, getColumIndex(vS2, "cdUnitmaterialName"), e.Row))
                    End If
                Next

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub vS2_Change(sender As Object, e As ChangeEventArgs) Handles vS2.Change
        Try
            Dim i As Integer

            If e.Column = getColumIndex(vS2, "cdSpecialProcess") Or e.Column = getColumIndex(vS2, "cdSpecialProcessName") Then
                For i = 0 To vS2.ActiveSheet.RowCount - 1
                    If getDataM(vS2, getColumIndex(vS2, "CheckUse"), i) = "1" Then
                        setData(vS2, getColumIndex(vS2, "cdSpecialProcess"), i, getData(vS2, getColumIndex(vS2, "cdSpecialProcess"), e.Row))
                        setData(vS2, getColumIndex(vS2, "cdSpecialProcessName"), i, getData(vS2, getColumIndex(vS2, "cdSpecialProcessName"), e.Row))
                    End If
                Next
            End If

        Catch ex As Exception

        End Try
      
    End Sub

    Private Sub vS2_KeyDown(sender As Object, e As KeyEventArgs) Handles vS2.KeyDown
        Dim xCOL As Integer
        Dim xROW As Integer
        Dim JobBOMCode As String
        Dim JobBOMSeq As String
        Dim JobBOMSno As String

        xCOL = vS2.ActiveSheet.ActiveColumnIndex
        xROW = vS2.ActiveSheet.ActiveRowIndex

        Select Case e.KeyCode
            Case Keys.Delete

                Call Select_Message("3", WordConv("PROCESSING"), 2)

                If Msg_Result <> vbYes Then Exit Sub

                JobBOMCode = getData(vS2, getColumIndex(vS2, "KEY_JobBOMCode"), vS2.ActiveSheet.ActiveRowIndex)
                JobBOMSeq = getData(vS2, getColumIndex(vS2, "KEY_JobBOMSeq"), vS2.ActiveSheet.ActiveRowIndex)
                JobBOMSno = getData(vS2, getColumIndex(vS2, "KEY_JobBOMSno"), vS2.ActiveSheet.ActiveRowIndex)

                If READ_PFK7313(JobBOMCode, JobBOMSeq, JobBOMSno) Then
                    Call DELETE_PFK7313(D7313)
                End If

                SPR_DEL(vS2, xCOL, xROW)
                vS2.ActiveSheet.ActiveColumnIndex = xCOL
                vS2.ActiveSheet.ActiveRowIndex = xROW
                vS2.Focus()

        End Select
    End Sub

    Private Sub txt_cdJobProcessBOM_Load(sender As Object, e As EventArgs)
        Exit Sub

        Dim xROW As Integer

        xROW = Vs1.ActiveSheet.ActiveRowIndex
        If Vs1.ActiveSheet.ActiveRowIndex < 0 Then Exit Sub

        If HLP7311A.Link_HLP7311A("") = False Then Exit Sub

        If hlp0000SeVa = "" Then Exit Sub
        DS1 = PrcDS("USP_ISUD7311A_SEARCH_VS1", cn, hlp0000SeVaTt)

        DS2 = READ_PFK7311(hlp0000SeVaTt, cn)
        DS2.Tables(0).Columns.Remove("K7311_JobBOMCode")

        Call READER_MOVE(Me, DS2)

        If READ_PFK7325(GetDsData(DS2, 0, "K7311_ProcessBOMCode")) Then
            txt_ProcessBOMCode.Data = D7325.ProcessBOMCode
            txt_ProcessBOMName.Data = D7325.ProcessBOMName
        End If

        DS3 = PrcDS("USP_ISUD7311A_SEARCH_VS2_INSERT", cn, hlp0000SeVaTt)

        Call READ_SPREAD_N(Vs1, DS1, xROW, GetDsRc(DS1), "USP_ISUD7311A_SEARCH_VS1", "VS1")

    End Sub

    Private Sub txt_cdBaseBOM_Load(sender As Object, e As EventArgs) Handles txt_cdProcessBOM.btnTitleClick
        Dim xROW As Integer

        xROW = Vs1.ActiveSheet.ActiveRowIndex
        If Vs1.ActiveSheet.ActiveRowIndex < 0 Then Exit Sub

        If HLP7305A.Link_HLP7305A("") = False Then Exit Sub

        If hlp0000SeVa = "" Then Exit Sub
        DS1 = PrcDS("USP_ISUD7305A_SEARCH_VS1", cn, hlp0000SeVaTt)

        DS2 = READ_PFK7305(hlp0000SeVaTt, cn)
        DS2.Tables(0).Columns.Remove("K7305_ProcessBOMCode")

        Call READER_MOVE(Me, DS2)

        Call READ_SPREAD_N(Vs1, DS1, GetDsRc(DS1), "USP_ISUD7311A_SEARCH_VS1", "VS1")
    End Sub

    Private Sub UPDATEJOBPROCESSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UPDATEJOBPROCESSToolStripMenuItem.Click
        'Dim JobBOMCode As String
        'Dim JobBOMSeq As String

        'Dim cdSubProcess As String
        'cdSubProcess = getData(Vs1, getColumIndex(Vs1, "cdSubProcess"), Vs1.ActiveSheet.ActiveRowIndex)
        'JobBOMCode = getData(Vs1, getColumIndex(Vs1, "KEY_JobBOMCode"), Vs1.ActiveSheet.ActiveRowIndex)
        'JobBOMSeq = getData(Vs1, getColumIndex(Vs1, "KEY_JobBOMSeq"), Vs1.ActiveSheet.ActiveRowIndex)

        'If JobBOMCode = "" Then MsgBoxP("Not Save Information!")

        'JobBOMCode = getData(Vs1, getColumIndex(Vs1, "KEY_JobBOMCode"), Vs1.ActiveSheet.ActiveRowIndex)
        'JobBOMSeq = getData(Vs1, getColumIndex(Vs1, "KEY_JobBOMSeq"), Vs1.ActiveSheet.ActiveRowIndex)

        'Call DATA_MOVE_WRITE02(JobBOMCode, JobBOMSeq)
        'Call DATA_SEARCH_VS2()
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
    Private Sub tst_iAttach_Click(sender As Object, e As EventArgs) Handles tst_iAttach.Click
        Call DATA_SEARCH_IMAGE_TOTAL(pic_Picture, Me.Name, L7311.JobBOMCode)
    End Sub
#End Region

End Class