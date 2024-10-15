Public Class ISUD4010B
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
    Public Function Link_ISUD4010B(job As Integer, JobCard As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D4010.JobCard = JobCard

        wJOB = job : L4010 = D4010

        Link_ISUD4010B = False
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

            Link_ISUD4010B = isudCHK


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


                tst_iDelete.Visible = False

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call KEY_COUNT()
                Call DATA_SEARCH_VS1()

                Setfocus(txt_JobCard)
            Case 2
                Me.Text = "JOBCARD PROCESSING ISUD4010B" & " - SEARCH"


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
            Case 3
                Me.Text = "JOBCARD PROCESSING ISUD4010B" & " - UPDATE"


                txt_JobCard.Enabled = False

                Call DATA_SEARCH01()
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
                        tst_iDelete.Visible = False
                        Call MsgBoxP("16", "Form_Activate")
                    End If
                End If

            Case 4
                Me.Text = "JOBCARD PROCESSING ISUD4010B" & " - DELETE"


                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()

        End Select

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Try
            txt_JobCard.Enabled = False
            Call D4010_CLEAR()
            W4010 = D4010
            txt_ProdDate.Data = Pub.DAT
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

        DS1 = PrcDS("USP_ISUD4010B_SEARCH_HEAD", cn, L4010.JobCard)

        If GetDsRc(DS1) = 0 Then
            Exit Function
            isudCHK = False
        End If

        STORE_MOVE(Me, DS1)
        txt_JobCard.Data = L4010.JobCard

        DATA_SEARCH01 = True

    End Function

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False

        DS1 = PrcDS("USP_ISUD4010B_SEARCH_VS1", cn, L4010.JobCard, txt_cdSubProcess.Code, txt_ProdDate.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs1, DS1, "USP_ISUD4010B_SEARCH_VS1", "Vs1")
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "USP_ISUD4010B_SEARCH_VS1", "Vs1")



        DATA_SEARCH_VS1 = True
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


            Data_Check = True
skip_1:
        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))

        End Try
    End Function

    Private Sub DATA_MOVE()
        W4011.JobCard = txt_JobCard.Data



    End Sub


    Private Sub DATA_INSERT()
        Try

            Call DATA_MOVE()
            Call KEY_COUNT()

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INSERT")
        End Try

    End Sub

    Private Sub DATA_UPDATE()
        Try
            Call DATA_MOVE()


        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

    Private Sub KEY_COUNT()

    End Sub

    Private Sub DATA_DELETE()
        Try
            Call DATA_MOVE()

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

#End Region

#Region "Event"
    Private Sub txt_DatePlanStart_Textchange(sender As Object, e As EventArgs) Handles txt_ProdDate.m_Textchange, txt_cdSubProcess.txtTextChange
        Try
            If formA = False Then Exit Sub
            If READ_PFK4010(txt_JobCard.Data) Then
                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_DatePlanStart_txtTextKeyDown(sender As Object, e As KeyEventArgs) Handles txt_ProdDate.txtTextKeyDown, txt_cdSubProcess.txtTextKeyDown, txt_JobCard.txtTextKeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If READ_PFK4010(txt_JobCard.Data) Then
                    L4010.JobCard = D4010.JobCard
                    Call DATA_SEARCH01()
                    Call DATA_SEARCH_VS1()
                Else
                    txt_JobCard.Data = ""
                    D4010_CLEAR()
                    L4010 = D4010
                    W4010 = D4010
                    Call DATA_SEARCH01()
                    Call DATA_SEARCH_VS1()

                End If
            End If



        Catch ex As Exception

        End Try
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
        Dim QtyProduction As Decimal
        Dim KEY_Autokey As Decimal
        Dim ComponentName As String
        Dim cdLineProd As String

        Try
            If e.KeyCode = Keys.Enter Then
                QtyProduction = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyProduction"), Vs1.ActiveSheet.ActiveRowIndex))
                KEY_Autokey = CDecp(getData(Vs1, getColumIndex(Vs1, "KEY_Autokey"), Vs1.ActiveSheet.ActiveRowIndex))
                ComponentName = getData(Vs1, getColumIndex(Vs1, "ComponentName"), Vs1.ActiveSheet.ActiveRowIndex)
                cdLineProd = getData(Vs1, getColumIndex(Vs1, "cdLineProd"), Vs1.ActiveSheet.ActiveRowIndex)

                If cdLineProd = "" Then cdLineProd = "01"

                rd = PrcDR("USP_ISUD4010B_CHECK_DATA", cn, KEY_Autokey)

                If rd.HasRows Then
                    Call PrcExeNoError("USP_PFK4367_UPDATE_DATA", cn, L4010.JobCard, txt_ProdDate.Data, txt_cdSubProcess.Code, cdLineProd, QtyProduction)
                Else
                    Call PrcExeNoError("USP_PFK4367_INSERT_DATA", cn, L4010.JobCard, txt_ProdDate.Data, txt_cdSubProcess.Code, cdLineProd, QtyProduction)
                    Call DATA_SEARCH_VS1()
                End If

                rd.Close()


            End If
            If e.KeyCode = Keys.Delete Then
                Dim Strmsg = MsgBox("Do you want to delete?", vbYesNo)

                If StrMsg <> vbYes Then Exit Sub

                KEY_Autokey = CDecp(getData(Vs1, getColumIndex(Vs1, "KEY_Autokey"), Vs1.ActiveSheet.ActiveRowIndex))

                rd = PrcDR("USP_ISUD4010B_CHECK_DATA", cn, KEY_Autokey)

                If rd.HasRows Then
                    Call PrcExeNoError("USP_PFK4367_DELETE_DATA", cn, KEY_Autokey)
                    Call SPR_DEL(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex)
                Else
                    Call SPR_DEL(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex)
                End If

                rd.Close()

            End If
        Catch ex As Exception

        End Try

    End Sub

#End Region




End Class