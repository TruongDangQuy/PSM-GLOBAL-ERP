Public Class ISUD4010A
#Region "Variable"
    Private wJOB As Integer

    Private W4010 As T4010_AREA
    Private L4010 As T4010_AREA

    Private W4011 As T4011_AREA
    Private L4011 As T4011_AREA

    Private WRITE_CHK As String

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD4010A(job As Integer, JobCard As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D4010.JobCard = JobCard

        wJOB = job : L4010 = D4010

        Link_ISUD4010A = False
        Try
            Select Case job
                Case 1
                Case Else
                    If READ_PFK4010(L4010.JobCard) = False Then
                        If D4010.CheckPlan = "1" Then wJOB = "2"

                        Call MsgBoxP("3", "LINK_ISUD")

                        Me.Dispose()
                        Exit Function
                    End If
            End Select


            formA = False
            Me.ShowDialog()

            Link_ISUD4010A = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("JobCard"))
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
            Case 1
                Me.Text = Me.Text & " - INSERT"

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
                Call DATA_SEARCH02()

                Setfocus(txt_JobCard)
            Case 2
                Me.Text = "JOBCARD PROCESSING ISUD4010A" & " - SEARCH"

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
                Call DATA_SEARCH02()
            Case 3
                Me.Text = "JOBCARD PROCESSING ISUD4010A" & " - UPDATE"

                Frame1.Enabled = True
                txt_JobCard.Enabled = False

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
                        tst_iDelete.Visible = False
                        Call MsgBoxP("16", "Form_Activate")
                    End If
                End If

            Case 4
                Me.Text = "JOBCARD PROCESSING ISUD4010A" & " - DELETE"

                Frame1.Enabled = False

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
            txt_JobCard.Enabled = False
            Call D4010_CLEAR()
            W4010 = D4010

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

        DS1 = READ_PFK4010(L4010.JobCard, cn)
        If GetDsRc(DS1) = 0 Then
            Exit Function
            isudCHK = False
        End If

        READER_MOVE(Me, DS1)

        If GetDsData(DS1, 0, "K4010_CheckPlan") = "1" Then rad_CheckPlan1.Checked = True
        If GetDsData(DS1, 0, "K4010_CheckPlan") = "2" Then rad_CheckPlan2.Checked = True
        If GetDsData(DS1, 0, "K4010_CheckPlan") = "3" Then rad_CheckPlan3.Checked = True
        If GetDsData(DS1, 0, "K4010_CheckPlan") = "4" Then rad_CheckPlan4.Checked = True
        If GetDsData(DS1, 0, "K4010_CheckPlan") = "5" Then rad_CheckPlan5.Checked = True

        If READ_PFK4010(L4010.JobCard) Then
            If READ_PFK1312(D4010.WorkOrder, D4010.WorkOrderSeq) Then
                If READ_PFK7106(D1312.ShoesCode) Then
                    txt_QtyAverage.Data = Format0(D7106.QtyAverage)
                End If
            End If

        End If
       

        DATA_SEARCH01 = True

    End Function

    Private Function DATA_SEARCH02() As Boolean
        DATA_SEARCH02 = False

        DS1 = PrcDS("USP_ISUD4010A_SEARCH_VS1", cn, L4010.JobCard)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs1, DS1, "USP_ISUD4010A_SEARCH_VS1", "Vs1")
            Vs1.ActiveSheet.RowCount = 1
            Vs1.HorizontalScrollBarPolicy = ScrollBarPolicy.Never
            Vs1.Enabled = True
            Call READ_PFK4010(L4010.JobCard)
            setData(Vs1, getColumIndex(Vs1, "SizeQty01"), 0, D4010.QtyOrder)
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "USP_ISUD4010A_SEARCH_VS1", "Vs1")

        Vs1.ActiveSheet.RowCount = 1

        If READ_PFK4010(L4010.JobCard) Then

            Call VsSizeRangeNew_one(Vs1, "USP_PFP01607_SEARCH_VS11_HEAD", getColumIndex(Vs1, "SIZERANGENAME"), D4010.WorkOrder, D4010.WorkOrderSeq)

        End If
        Vs1.HorizontalScrollBarPolicy = ScrollBarPolicy.Never

        Call READ_PFK4010(L4010.JobCard)
        setData(Vs1, getColumIndex(Vs1, "SizeQty01"), 0, D4010.QtyOrder)


        DATA_SEARCH02 = True
    End Function

#End Region

#Region "Function"

    Private Function Data_Check() As Boolean
        Data_Check = False

        Try

            If wJOB = "1" Then
                If READ_PFK4010(L4010.JobCard) = True Then
                    Call MsgBoxP("5", "DATA_INSERT")
                    txt_JobCard.Focus()
                    KEY_COUNT()
                    Exit Function
                End If
            End If

            If READ_PFK4010(L4010.JobCard) = True And wJOB = "3" Then
                Dim strvalue As String
                strvalue = PrcExeNoError_Value("USP_PFK4010_CHECK_INFORMATION", cn, L4010.JobCard)

                If strvalue <> "" Then

                    Call MsgBoxP(strvalue)
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
        W4011.JobCard = txt_JobCard.Data

        Call K4011_MOVE(Me, W4011, 1, txt_JobCard.Data)

        Call READ_PFK4011(txt_JobCard.Data)
        W4011 = D4011
        W4011.SizeQty01 = getData(Vs1, getColumIndex(Vs1, "SizeQty01"), 0)
        W4011.SizeQty02 = getData(Vs1, getColumIndex(Vs1, "SizeQty02"), 0)
        W4011.SizeQty03 = getData(Vs1, getColumIndex(Vs1, "SizeQty03"), 0)
        W4011.SizeQty04 = getData(Vs1, getColumIndex(Vs1, "SizeQty04"), 0)
        W4011.SizeQty05 = getData(Vs1, getColumIndex(Vs1, "SizeQty05"), 0)
        W4011.SizeQty06 = getData(Vs1, getColumIndex(Vs1, "SizeQty06"), 0)
        W4011.SizeQty07 = getData(Vs1, getColumIndex(Vs1, "SizeQty07"), 0)
        W4011.SizeQty08 = getData(Vs1, getColumIndex(Vs1, "SizeQty08"), 0)
        W4011.SizeQty09 = getData(Vs1, getColumIndex(Vs1, "SizeQty09"), 0)
        W4011.SizeQty10 = getData(Vs1, getColumIndex(Vs1, "SizeQty10"), 0)

        W4011.SizeQty11 = getData(Vs1, getColumIndex(Vs1, "SizeQty11"), 0)
        W4011.SizeQty12 = getData(Vs1, getColumIndex(Vs1, "SizeQty12"), 0)
        W4011.SizeQty13 = getData(Vs1, getColumIndex(Vs1, "SizeQty13"), 0)
        W4011.SizeQty14 = getData(Vs1, getColumIndex(Vs1, "SizeQty14"), 0)
        W4011.SizeQty15 = getData(Vs1, getColumIndex(Vs1, "SizeQty15"), 0)
        W4011.SizeQty16 = getData(Vs1, getColumIndex(Vs1, "SizeQty16"), 0)
        W4011.SizeQty17 = getData(Vs1, getColumIndex(Vs1, "SizeQty17"), 0)
        W4011.SizeQty18 = getData(Vs1, getColumIndex(Vs1, "SizeQty18"), 0)
        W4011.SizeQty19 = getData(Vs1, getColumIndex(Vs1, "SizeQty19"), 0)
        W4011.SizeQty20 = getData(Vs1, getColumIndex(Vs1, "SizeQty20"), 0)

        W4011.SizeQty21 = getData(Vs1, getColumIndex(Vs1, "SizeQty21"), 0)
        W4011.SizeQty22 = getData(Vs1, getColumIndex(Vs1, "SizeQty22"), 0)
        W4011.SizeQty23 = getData(Vs1, getColumIndex(Vs1, "SizeQty23"), 0)
        W4011.SizeQty24 = getData(Vs1, getColumIndex(Vs1, "SizeQty24"), 0)
        W4011.SizeQty25 = getData(Vs1, getColumIndex(Vs1, "SizeQty25"), 0)
        W4011.SizeQty26 = getData(Vs1, getColumIndex(Vs1, "SizeQty26"), 0)
        W4011.SizeQty27 = getData(Vs1, getColumIndex(Vs1, "SizeQty27"), 0)
        W4011.SizeQty28 = getData(Vs1, getColumIndex(Vs1, "SizeQty28"), 0)
        W4011.SizeQty29 = getData(Vs1, getColumIndex(Vs1, "SizeQty29"), 0)
        W4011.SizeQty30 = getData(Vs1, getColumIndex(Vs1, "SizeQty30"), 0)

        W4011.JobCard = L4010.JobCard

        If READ_PFK4011(W4011.JobCard) = False Then
            Call WRITE_PFK4011(W4011)
            Call PrcExeNoError("USP_PFK4010_UPDATE_SIZEQTY", cn, W4011.JobCard)

        Else
            If REWRITE_PFK4011(W4011) Then
                Call PrcExeNoError("USP_PFK4010_UPDATE_SIZEQTY", cn, W4011.JobCard)
            End If

        End If

        Call READ_PFK4010(txt_JobCard.Data)
        W4010 = D4010

        W4010.cdJobState = txt_cdJobState.Code
        W4010.seJobState = ListCode("JobState")

        If txt_cdJobState.Code = "" Then txt_cdJobState.Code = "001"
        If rad_CheckPlan1.Checked Then W4010.CheckPlan = "1" : W4010.DateFinish = Pub.DAT : W4010.DateUpdate = Pub.DAT
        If rad_CheckPlan2.Checked Then W4010.CheckPlan = "2" : W4010.DateFinish = "" : W4010.DateUpdate = Pub.DAT
        If rad_CheckPlan3.Checked Then W4010.CheckPlan = "3" : W4010.DateUpdate = Pub.DAT
        If rad_CheckPlan4.Checked Then W4010.CheckPlan = "4" : W4010.DateUpdate = Pub.DAT
        If rad_CheckPlan5.Checked Then W4010.CheckPlan = "5" : W4010.DateUpdate = Pub.DAT

        W4010.DatePlanStart = txt_DatePlanStart.Data
        W4010.DatePlanFinish = txt_DatePlanFinish.Data
        W4010.cdFactory = txt_cdFactory.Code

        W4010.seFactory = ListCode("Factory")
        W4010.seJobState = ListCode("JobState")
        W4010.DateUpdate = Pub.DAT


    End Sub


    Private Sub DATA_INSERT()
        Try

            Call DATA_MOVE()
            Call KEY_COUNT()

            If WRITE_PFK4010(W4010) = True Then

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
            If REWRITE_PFK4010(W4010) = True Then

                isudCHK = True
                Me.Dispose()
            End If

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

    Private Sub KEY_COUNT()
        Try

            SQL = " SELECT MAX(CAST(K4010_JobCard AS DECIMAL)) as MAX_CODE FROM PFK4010 "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If IsDBNull(rd!MAX_CODE) Then
                W4011.JobCard = "000001"
            Else
                W4011.JobCard = Format(CInt(rd!MAX_CODE + 1), "000000")
            End If

            rd.Close()

            txt_JobCard.Data = W4011.JobCard
            L4010.JobCard = W4011.JobCard

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

    Private Sub DATA_DELETE()
        Try
            Call DATA_MOVE()
            If DELETE_PFK4010(W4010) = True Then

                Call Delete_History("PFK4010", W4010.JobCard)

                isudCHK = True
                Me.Dispose()
            End If

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

#End Region

#Region "Event"
    Private Sub txt_DatePlanStart_txtTextKeyDown(sender As Object, e As KeyEventArgs) Handles txt_DatePlanStart.txtTextKeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                txt_DatePlanFinish.Data = PrcExeNoError_Value("USP_ISUD4010A_DATE_FINISH", cn, L4010.JobCard, txt_DatePlanStart.Data)

            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        Select Case wJOB
            Case 1
                Call KEY_COUNT()
                Call DATA_INSERT()

                Call FORM_INIT()
                Call DATA_INIT()
                Call KEY_COUNT()
                Setfocus(txt_JobCard)

            Case 2
                Me.Dispose()
            Case 3
                If DataCheck(Me, "PFK7018") = False Then Exit Sub

                If Data_Check() = False Then Exit Sub

                Call DATA_UPDATE()
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
    End Sub

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub


    Private Sub vS1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown

    End Sub

#End Region


    Private Sub cmd_CuttingBL_Click(sender As Object, e As EventArgs)
        Call HLP4070A.Link_HLP4070A(txt_JobCard.Data, "")
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class