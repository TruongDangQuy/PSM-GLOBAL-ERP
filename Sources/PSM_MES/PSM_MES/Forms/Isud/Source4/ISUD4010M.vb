Public Class ISUD4010M

#Region "Variable"
    Private wJOB As Integer

    Private WRITE_CHK As String
    Private KEY_CHK As String

    Private W4010 As T4010_AREA
    Private L4010 As T4010_AREA

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD4010M(job As Integer, JobCard As String, Optional ByVal TAG As String = "") As Boolean
        D4010.JobCard = JobCard
        txt_JobCard.Data = JobCard
        txt_JobCard.Code = JobCard

        wJOB = job

        Link_ISUD4010M = False

        Select Case job
            Case 1
            Case Else
                If READ_PFK4010(D4010.JobCard) = False Then
                    Call MsgBoxP("3", "LINK_ISUD")

                    Exit Function
                End If


        End Select

        L4010 = D4010

        formA = False
        Me.Tag = TAG
        Me.ShowDialog()

        Link_ISUD4010M = isudCHK

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
                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If


                tst_iSave.Visible = True

                Call KEY_COUNT()

            Case 2
                Me.Text = Me.Text & " - SEARCH"
                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If


                tst_iSave.Visible = False
                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH()
                Call DATA_SEARCH_VS1()

            Case 3
                Me.Text = Me.Text & " - UPDATE"
                If CHK(3) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If


                txt_JobCard.Enabled = False

                tst_iSave.Visible = True

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH()
                Call DATA_SEARCH_VS1()


            Case 4
                Me.Text = Me.Text & " - DELETE"
                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If


                tst_iSave.Visible = False

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH()
                Call DATA_SEARCH_VS1()

            Case 5
                Me.Text = Me.Text & " - COPY"

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If


                tst_iSave.Visible = True

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH()
                Call DATA_SEARCH_VS1()
                Call KEY_COUNT()

                wJOB = 1
            Case 6
                Me.Text = Me.Text & " - UPDATE LAST CODE"

                If CHK(3) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If


                txt_JobCard.Enabled = False
                tst_iSave.Visible = True

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH()
                Call DATA_SEARCH_VS1()
                Call DisableAllType()

                wJOB = 3
        End Select

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Call D4010_CLEAR()

        W4010 = D4010

        KEY_CHK = ""


    End Sub
    Private Sub FORM_INIT()
        txt_JobCard.Enabled = False
        Vs1.HorizontalScrollBarPolicy = ScrollBarPolicy.Never

        tst_iDelete.Visible = False
    End Sub
#End Region

#Region "Function"
    Private Function Data_Check() As Boolean
        Data_Check = False
        If txt_JobCardC.Data = "" Then Setfocus(txt_JobCardC) : MsgBoxP("JobCard End?") : Exit Function

        Data_Check = True

    End Function

    Private Sub DATA_MOVE()


    End Sub

    Private Sub DATA_INSERT()


    End Sub
    Private Sub DATA_UPDATE()
        Dim Strmsg As String

        Strmsg = MsgBox("Do you want to TRANSFER?", vbYesNo)

        If StrMsg <> vbYes Then Exit Sub

        Call DATA_MOVE()

        Try
            Dim i As Integer
            Dim OrderNo As String
            Dim OrderNoSeq As String

            str = PrcExeNoError_Value(" EXP_CLOSSING_PFK4010_MERGE_ORDERNO", cn, txt_JobCard.Data, txt_JobCardC.Data)

            If str <> "" Then
                MsgBoxP(str)
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()

            End If


            'Call DATA_SEARCH_VS3()
            'Call DATA_SEARCH_VS4()


        Catch ex As Exception

        End Try




    End Sub
    Private Sub DATA_DELETE()

    End Sub
    Private Sub vS2_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs2.KeyDown
        Dim xCOL As Integer
        Dim xROW As Integer
        Dim Autokey As String

        xCOL = vS2.ActiveSheet.ActiveColumnIndex
        xROW = vS2.ActiveSheet.ActiveRowIndex

        Select Case e.KeyCode
            Case Keys.Delete

                Call Select_Message("3", WordConv("PROCESSING"), 2)

                If Msg_Result <> vbYes Then Exit Sub

                SPR_DEL(vS2, xCOL, xROW)

        End Select
    End Sub



    Private Sub KEY_COUNT()
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        If KEY_CHK = "*" Then Exit Sub

        SQL = "SELECT MAX(CAST(K4010_JobCard AS DECIMAL)) AS MAX_CODE FROM PFK4010 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            L4010.JobCard = "000001"
        Else
            L4010.JobCard = Format(CInt(rd!MAX_CODE + 1), "000000")
        End If

        W4010.JobCard = L4010.JobCard

        rd.Close()
        If Val(W4010.JobCard) > 999999 Then
            Call MsgBoxP("46", "KEY_COUNT")

            Call tst_iClose.PerformClick() : Exit Sub
        End If

        txt_JobCard.Data = W4010.JobCard
    End Sub


#End Region

#Region "DATA_SEARCH"
    Private Function DATA_SEARCH() As Boolean

        DATA_SEARCH = False


        DATA_SEARCH = True

    End Function

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False

        DS1 = PrcDS("USP_ISUD4010M_SEARCH_VS1", cn, txt_JobCard.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs1, DS1, "USP_ISUD4010M_SEARCH_VS1", "Vs1")
            Vs1.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "USP_ISUD4010M_SEARCH_VS1", "Vs1")
        DATA_SEARCH_VS1 = True

    End Function

    Private Function DATA_SEARCH_VS2() As Boolean
        DATA_SEARCH_VS2 = False
        Dim JobCardAfter As String

        JobCardAfter = getData(Vs1, getColumIndex(Vs1, "Jobcard"), Vs1.ActiveSheet.ActiveRowIndex)

        DS1 = PrcDS("USP_ISUD4010M_SEARCH_VS2", cn, JobCardAfter)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(VS2, DS1, "USP_ISUD4010M_SEARCH_VS2", "VS2")
            VS2.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(VS2, DS1, "USP_ISUD4010M_SEARCH_VS2", "VS2")
        DATA_SEARCH_VS2 = True

    End Function

    Private Function DATA_SEARCH_VS3() As Boolean
        DATA_SEARCH_VS3 = False

        DS1 = PrcDS("USP_ISUD4010M_SEARCH_VS3", cn, txt_JobCardC.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(VS3, DS1, "USP_ISUD4010M_SEARCH_VS3", "VS3")
            VS3.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(VS3, DS1, "USP_ISUD4010M_SEARCH_VS3", "VS3")
        DATA_SEARCH_VS3 = True

    End Function

    Private Function DATA_SEARCH_VS4() As Boolean
        DATA_SEARCH_VS4 = False

        DS1 = PrcDS("USP_ISUD4010M_SEARCH_VS4", cn, txt_JobCardC.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(VS4, DS1, "USP_ISUD4010M_SEARCH_VS4", "VS4")
            VS4.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(VS4, DS1, "USP_ISUD4010M_SEARCH_VS4", "VS4")
        DATA_SEARCH_VS4 = True

    End Function


    Private Function DATA_SEARCH_HEAD() As Boolean
        DATA_SEARCH_HEAD = False

        DATA_SEARCH_HEAD = True

    End Function

#End Region

#Region "Event"
   
    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        Select Case wJOB
            Case 3
                If Data_Check() = False Then Exit Sub
                Call DATA_UPDATE()
            Case 4 : Call DATA_DELETE()
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
    Private Sub tst_iDelete_Click(sender As Object, e As EventArgs)
        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        If CHK(4) <> "1" Then
            Call MsgBoxP("4", "tst_iDelete_Click")
            Exit Sub
        End If
        Call DATA_DELETE()
        Me.Dispose()
    End Sub
    Private Sub txt_JobCardC_btnTitleClick(sender As Object, e As EventArgs) Handles txt_JobCardC.btnTitleClick
        If READ_PFK4010(L4010.JobCard) Then
         

        End If

    End Sub


#End Region




    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        txt_JobCardC.Data = getData(Vs1, getColumIndex(Vs1, "JobCard"), e.Row)

        Call DATA_SEARCH_VS2()

    End Sub
End Class