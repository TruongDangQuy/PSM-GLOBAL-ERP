Public Class ISUD7741A

#Region "Variable"
    Private wJOB As Integer

    Private WRITE_CHK As Boolean
    Private FIRST_LINE_CHK As Boolean

    Private privS1_SCOL As Integer

    Private Dsu01 As Integer
    Private Dsu02 As Integer
    Private Dsu04 As Integer


    Private W7741 As T7741_AREA
    Private M7741 As T7741_AREA
    Private L7741 As T7741_AREA

    Private W7743 As T7743_AREA
    Private M7743 As T7743_AREA
    Private L7743 As T7743_AREA

    Private priJOB_CHK As String

    Private CHK(0 To 5) As String


    Private loop_check As Boolean
    Private formA As Boolean
#End Region

#Region "Link"
    Public Function Link_ISUD7741A(job As Integer, cdFactory As String, cdSubProcess As String, DatePlan As String, cdLineProd As String, Optional SeqJob As String = "", Optional FormName As String = "") As Boolean
        Me.Tag = FormName
        On Error GoTo Error_Message

        D7741.cdFactory = cdFactory : D7741.DatePlan = DatePlan : D7741.cdLineProd = cdLineProd : D7741.cdSubProcess = cdSubProcess
        D7743.cdFactory = cdFactory : D7743.DatePlan = DatePlan : D7743.cdLineProd = cdLineProd : D7743.cdSubProcess = cdSubProcess : D7743.SeqJob = SeqJob

        wJOB = job : L7741 = D7741 : L7743 = D7743

        formA = False
        Link_ISUD7741A = False

        Select Case wJOB
            Case "1", "11"
            Case Else
                If READ_PFK7741(L7741.cdFactory, L7741.cdSubProcess, L7741.DatePlan, L7741.cdLineProd) = False Then
                    Call Error_Message("3", "Link_ISUD7741A")
                    Exit Function
                End If

                If D7741.DatePlan > Pub.DAT Then wJOB = 2

        End Select

        Me.ShowDialog()

        Link_ISUD7741A = isudCHK

        Exit Function
Error_Message:
        Call Error_Message("37", WordConv("Link_ISUD7741A"))
    End Function
#End Region

#Region "Form_Load"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        Me.Form_KeyDown()


        Call FORM_INIT()
        Call DATA_INIT()

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        Select Case wJOB
            Case 1

                Me.Text = Me.Text & " - INSERT"
                If CHK(1) <> "1" Then
                    Call MsgBoxP(WordConv("You have no right is this program !"))
                    Exit Sub
                End If
                priJOB_CHK = "INSERT"

                tst_iDelete.Visible = False

                Setfocus(txt_DatePlan)

            Case 2

                Me.Text = Me.Text & " - SEARCH"
                If CHK(2) <> "1" Then
                    Call MsgBoxP(WordConv("You have no right is this program !"))
                    Exit Sub
                End If
                Frm_MAIN_HEAD.Enabled = False

                If HEAD_SEARCH() = True Then
                    Call HEAD_SEARCH_SANO(L7743.cdFactory, L7743.cdSubProcess, L7743.DatePlan, L7743.cdLineProd, L7743.SeqJob)

                    If DATA_SEARCH_VS1() = True Then Call HEAD_SEARCH_DATE_TOTAL()
                End If

                tst_iDelete.Visible = False
                tst_iSave.Visible = False

                Setfocus(tst_iClose)

            Case 3
                Me.Text = Me.Text & " - UPDATE"
                If CHK(3) <> "1" Then
                    Call MsgBoxP(WordConv("You have no right is this program !"))
                    Exit Sub
                End If
                priJOB_CHK = "UPDATE"

                If HEAD_SEARCH() = True Then
                    Call HEAD_SEARCH_SANO(L7743.cdFactory, L7743.cdSubProcess, L7743.DatePlan, L7743.cdLineProd, L7743.SeqJob)

                    If DATA_SEARCH_VS1() = True Then Call HEAD_SEARCH_DATE_TOTAL()
                End If

                Frm_MAIN_HEAD.Enabled = True


                Setfocus(tst_iSave)

            Case 4
                Me.Text = Me.Text & " - DELETE"
                If CHK(4) <> "1" Then
                    Call MsgBoxP(WordConv("You have no right is this program !"))
                    Exit Sub
                End If
                If HEAD_SEARCH() = True Then
                    Call HEAD_SEARCH_SANO(L7743.cdFactory, L7743.cdSubProcess, L7743.DatePlan, L7743.cdLineProd, L7743.SeqJob)

                    If DATA_SEARCH_VS1() = True Then Call HEAD_SEARCH_DATE_TOTAL()
                End If

                Frm_MAIN_HEAD.Enabled = False
                Frm_MAIN_HEAD.Enabled = False


                tst_iDelete.Visible = True
                tst_iSave.Visible = False

                tst_iClose.Select()

            Case 11
                Me.Text = Me.Text & " - COPY"

                If HEAD_SEARCH() = True Then
                    Call HEAD_SEARCH_SANO(L7743.cdFactory, L7743.cdSubProcess, L7743.DatePlan, L7743.cdLineProd, L7743.SeqJob)

                    If DATA_SEARCH_VS1() = True Then Call HEAD_SEARCH_DATE_TOTAL()
                End If

                Frm_MAIN_HEAD.Enabled = True

                txt_QtyTargetDay.Enabled = True
                txt_QtyTargetHour.Enabled = True
                txt_InchargePlan.Enabled = True

                txt_InchargeJob.Enabled = False
                txt_cdJobProcess.Enabled = False
                txt_cdSubProcess.Enabled = False


                tst_iDelete.Visible = False

                tst_iSave.Select()

        End Select

        formA = True
    End Sub
    Private Sub FORM_INIT()
        FIRST_LINE_CHK = False

        txt_DatePlan.Data = "" : txt_DatePlan.Data = ""

        txt_cdFactory.Data = "" : txt_cdFactory.Code = ""
        txt_cdLineProd.Data = "" : txt_cdLineProd.Code = ""
        txt_InchargePlan.Data = "" : txt_InchargePlan.Code = ""

        txt_TimeJob.Data = "" : txt_TimeJob.Code = ""
        txt_InchargeJob.Data = "" : txt_InchargeJob.Code = ""
        txt_cdJobProcess.Data = "" : txt_cdJobProcess.Code = ""


        txt_QtyTargetDay.Data = 0 : txt_QtyTargetDay.Code = 0
        txt_QtyTargetHour.Data = 0 : txt_QtyTargetHour.Code = 0
        txt_QtyRateSecond.Data = 0 : txt_QtyRateSecond.Code = 0
        c.Data = 0 : c.Code = 0

        txt_SeqJob.Data = "" : txt_SeqJob.Code = ""

        lab_A_MAIN.Data = 0
        lab_B_MAIN.Data = 0
        lab_C_MAIN.Data = 0
        lab_D_MAIN.Data = 0
        lab_T_MAIN.Data = 0

        lab_A_SUB.Data = 0
        lab_B_SUB.Data = 0
        lab_C_SUB.Data = 0
        lab_D_SUB.Data = 0
        lab_T_SUB.Data = 0

        lab_A_MANA.Data = 0
        lab_B_MANA.Data = 0
        lab_C_MANA.Data = 0
        lab_D_MANA.Data = 0
        lab_T_MANA.Data = 0

        opt_InchargeSelect0.Checked = True
        opt_Grade0.Checked = True
    End Sub

    Private Sub DATA_INIT()
        If wJOB = "1" Then
            txt_DatePlan.Data = Pub.DAT
            txt_DatePlan.Data = Pub.DAT

            L7741.DatePlan = Pub.DAT
            L7743.DatePlan = Pub.DAT

        End If
        vS1.AllowRowMove = True
        RemoveHandler opt_Grade0.KeyDown, AddressOf standard_KeyDown
        RemoveHandler opt_Grade1.KeyDown, AddressOf standard_KeyDown
        RemoveHandler opt_Grade2.KeyDown, AddressOf standard_KeyDown
        RemoveHandler opt_Grade3.KeyDown, AddressOf standard_KeyDown

        WRITE_CHK = False
    End Sub
#End Region

#Region "DATA_SEARCH"
    Private Function HEAD_SEARCH() As Boolean
        HEAD_SEARCH = False

        DS1 = READ_PFK7741(L7741.cdFactory, L7741.cdSubProcess, L7741.DatePlan, L7741.cdLineProd, cn)

        If GetDsRc(DS1) = 0 Then
            Exit Function
            isudCHK = False
        End If

        Call READER_MOVE(Me, DS1)

        HEAD_SEARCH = True
    End Function

    Private Function HEAD_SEARCH_SANO(tmpcdFactory As String, tmpcdSubProcess As String, tmpDatePlan As String, tmpcdLineProd As String, tmpSeqJob As String) As Boolean
        HEAD_SEARCH_SANO = False

        DS1 = READ_PFK7743(tmpcdFactory, tmpcdSubProcess, tmpDatePlan, tmpcdLineProd, tmpSeqJob, cn)

        If GetDsRc(DS1) = 0 Then
            Exit Function
            isudCHK = False
        End If

        Call READER_MOVE(Me, DS1)

        HEAD_SEARCH_SANO = True

    End Function

    Private Function HEAD_SEARCH_DATE_TOTAL() As Boolean
        HEAD_SEARCH_DATE_TOTAL = False

        DS1 = PrcDS("USP_ISUD7741A_SEARCH_HEAD_TOTAL", cn, L7741.cdFactory, L7741.cdSubProcess, L7741.DatePlan, L7741.cdLineProd)

        If GetDsRc(DS1) = 0 Then
            Exit Function
            isudCHK = False
        End If

        lab_SANO_TOAL.Data = GetDsData(DS1, 0, "InchargeSelect")
        lab_T_MAIN.Data = GetDsData(DS1, 0, "InchargeSelect_A")
        lab_T_SUB.Data = GetDsData(DS1, 0, "InchargeSelect_B")
        lab_T_MANA.Data = GetDsData(DS1, 0, "InchargeSelect_C")


        HEAD_SEARCH_DATE_TOTAL = True
    End Function

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False
        Try
            Dim i As Integer

            DS1 = PrcDS("USP_ISUD7741A_SEARCH_VS1", cn, L7741.cdFactory, L7741.cdSubProcess, L7741.DatePlan, L7741.cdLineProd)
            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS1, DS1, "USP_ISUD7741A_SEARCH_VS1", "Vs1")
                vS1.ActiveSheet.RowCount = 1
                vS1.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS1, DS1, "USP_ISUD7741A_SEARCH_VS1", "Vs1")

            DATA_SEARCH_VS1 = True

        Catch ex As Exception

        End Try
    End Function

#End Region

#Region "Function"
    Private Function KEY_COUNT() As Boolean
        On Error GoTo Error_Message
        KEY_COUNT = False

        Dim i As Integer
        Dim k As Integer

        Dim strKEY_VALUE As String
        Dim strKEY_CNT As String

Start_KEY_COUNT:
        '============================================================================

        SQL = " SELECT MAX(CAST(ISNULL(K7743_SeqJob ,0)  AS NVARCHAR(10))) AS MAX_CODE FROM PFK7743 "
        SQL = SQL & " WHERE  K7743_cdFactory    = '" & L7741.cdFactory & "' "
        SQL = SQL & "   AND  K7743_cdSubProcess  = '" & L7741.cdSubProcess & "' "
        SQL = SQL & "   AND  K7743_cdLineProd  = '" & L7741.cdLineProd & "' "
        SQL = SQL & "   AND  K7743_DatePlan  = '" & L7741.DatePlan & "' "

        rd = New SqlClient.SqlCommand(SQL, cn).ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            strKEY_CNT = "001"
        Else
            strKEY_CNT = FormatP(Int(rd!MAX_CODE + 1), "000")
        End If


        W7743.SeqJob = strKEY_CNT
        L7743.SeqJob = strKEY_CNT

        txt_SeqJob.Data = strKEY_CNT

        rd.Close()
        '============================================================================
End_KEY_COUNT:
        KEY_COUNT = True

        Exit Function
Error_Message:

        Call Error_Message("37", "KEY_COUNT")
    End Function

    Private Sub DATA_MOVE_WRITE()

        Call D7741_CLEAR() : M7741 = D7741

        M7741.cdFactory = FormatP(txt_cdFactory.Code, "000")
        M7741.DatePlan = Replace(txt_DatePlan.Data, "/", "")
        M7741.cdLineProd = FormatP(txt_cdLineProd.Code, "000")
        M7741.InchargePlan = txt_InchargePlan.Code
        M7741.cdSubProcess = txt_cdSubProcess.Code
        M7741.TimeJob = Replace(txt_TimeJob.Data, ":", "")
        M7741.QtyTargetDay = FormatP(txt_QtyTargetDay.Data, "##0")
        M7741.QtyTargetHour = Format1(txt_QtyTargetHour.Data)
        M7741.QtyRateSecond = FormatP(txt_QtyRateSecond.Data, "##0")

        If READ_PFK7741(M7741.cdFactory, M7741.cdSubProcess, M7741.DatePlan, M7741.cdLineProd) = True Then
            W7741 = D7741

            W7741.InchargePlan = M7741.InchargePlan
            W7741.TimeJob = M7741.TimeJob
            W7741.QtyTargetDay = M7741.QtyTargetDay
            W7741.QtyTargetHour = M7741.QtyTargetHour
            W7741.QtyRateSecond = M7741.QtyRateSecond
            W7741.cdSubProcess = txt_cdSubProcess.Code

            If READ_PFK7171(ListCode("SubProcess"), txt_cdSubProcess.Code) Then
                W7741.seMainProcess = D7171.seBasicMaster
                W7741.cdMainProcess = D7171.cdBasicMaster
            End If

            W7741.seFactory = ListCode("Factory")
            W7741.seLineProd = ListCode("LineProd")
            W7741.seSubProcess = ListCode("SubProcess")

            Call REWRITE_PFK7741(W7741)

            W7743.SeqJob = FormatP(txt_SeqJob.Data, "000")
            Call DATA_MOVE_WRITE_K7743(W7741.cdFactory, W7741.cdSubProcess, W7741.DatePlan, W7741.cdLineProd, W7743.SeqJob)

            WRITE_CHK = True

        Else
            W7741 = M7741
            L7741.cdFactory = M7741.cdFactory
            Call KEY_COUNT()

            W7741.seFactory = ListCode("Factory")
            W7741.seLineProd = ListCode("LineProd")
            W7741.seSubProcess = ListCode("SubProcess")

            If READ_PFK7171(ListCode("SubProcess"), txt_cdSubProcess.Code) Then
                W7741.seMainProcess = D7171.seBasicMaster
                W7741.cdMainProcess = D7171.cdBasicMaster
            End If

            Call WRITE_PFK7741(W7741)

            W7743.SeqJob = FormatP(txt_SeqJob.Data, "000")
            Call DATA_MOVE_WRITE_K7743(W7741.cdFactory, W7741.cdSubProcess, W7741.DatePlan, W7741.cdLineProd, W7743.SeqJob)

            WRITE_CHK = True
        End If

        L7741.cdFactory = W7741.cdFactory
        L7741.DatePlan = W7741.DatePlan
        L7741.cdLineProd = W7741.cdLineProd
        L7741.cdSubProcess = W7741.cdSubProcess
    End Sub

    Private Sub DATA_MOVE_WRITE_K7743(tmpcdFactory As String, tmpcdSubProcess As String, tmpDatePlan As String, tmpcdLineProd As String, tmpSeqJob As String)
        Dim i As Integer

        i = 0

        Call D7743_CLEAR()

        M7743.cdFactory = tmpcdFactory
        M7743.cdSubProcess = tmpcdSubProcess
        M7743.DatePlan = tmpDatePlan
        M7743.cdLineProd = tmpcdLineProd
        M7743.SeqJob = tmpSeqJob

        M7743.MachineCode = txt_MachineCode.Code

        M7743.InchargeJob = txt_InchargeJob.Code
        M7743.cdJobProcess = txt_cdJobProcess.Code
        M7743.cdSubProcess = txt_cdSubProcess.Code
        M7743.QtyRateSecondJob = FormatP(CDblp(c.Data), "##0")

        If opt_InchargeSelect0.Checked = True Then M7743.InchargeSelect = "1"
        If opt_InchargeSelect1.Checked = True Then M7743.InchargeSelect = "2"
        If opt_InchargeSelect2.Checked = True Then M7743.InchargeSelect = "3"

        If opt_Grade0.Checked = True Then M7743.Grade = "1"
        If opt_Grade1.Checked = True Then M7743.Grade = "2"
        If opt_Grade2.Checked = True Then M7743.Grade = "3"
        If opt_Grade3.Checked = True Then M7743.Grade = "4"

        If priJOB_CHK = "INSERT" Then

            Call KEY_COUNT()

            M7743.SeqJob = L7743.SeqJob

            If READ_PFK7743(tmpcdFactory, tmpcdSubProcess, tmpDatePlan, tmpcdLineProd, L7743.SeqJob) = False Then
                W7743 = M7743
                W7743.seJobProcess = ListCode("JobProcess")
                W7743.seSubProcess = ListCode("SubProcess")

                If READ_PFK7171(ListCode("SubProcess"), txt_cdSubProcess.Code) Then
                    W7743.seMainProcess = D7171.seBasicMaster
                    W7743.cdMainProcess = D7171.cdBasicMaster
                End If

                Call WRITE_PFK7743(W7743)
                L7741.cdFactory = W7743.cdFactory
                L7741.DatePlan = W7743.DatePlan
                L7741.cdLineProd = W7743.cdLineProd

                If DATA_SEARCH_VS1() = True Then Call HEAD_SEARCH_DATE_TOTAL()

            Else
                W7743 = D7743

                W7743.InchargeJob = M7743.InchargeJob
                W7743.cdJobProcess = M7743.cdJobProcess
                W7743.cdSubProcess = M7743.cdSubProcess
                W7743.QtyRateSecondJob = M7743.QtyRateSecondJob

                W7743.InchargeSelect = M7743.InchargeSelect
                W7743.Grade = M7743.Grade

                W7743.seJobProcess = ListCode("JobProcess")
                W7743.seSubProcess = ListCode("SubProcess")

                If READ_PFK7171(ListCode("SubProcess"), txt_cdSubProcess.Code) Then
                    W7743.seMainProcess = D7171.seBasicMaster
                    W7743.cdMainProcess = D7171.cdBasicMaster
                End If


                Call REWRITE_PFK7743(W7743)

                L7741.cdFactory = W7743.cdFactory
                L7741.DatePlan = W7743.DatePlan
                L7741.cdLineProd = W7743.cdLineProd
                L7741.cdSubProcess = W7743.cdSubProcess

                If DATA_SEARCH_VS1() = True Then Call HEAD_SEARCH_DATE_TOTAL()

            End If

        Else

            If READ_PFK7743(tmpcdFactory, tmpcdSubProcess, tmpDatePlan, tmpcdLineProd, L7743.SeqJob) = False Then
                W7743 = M7743

                Call KEY_COUNT()

                W7743.SeqJob = L7743.SeqJob
                W7743.seJobProcess = ListCode("JobProcess")
                W7743.seSubProcess = ListCode("SubProcess")

                If READ_PFK7171(ListCode("SubProcess"), txt_cdSubProcess.Code) Then
                    W7743.seMainProcess = D7171.seBasicMaster
                    W7743.cdMainProcess = D7171.cdBasicMaster
                End If


                Call WRITE_PFK7743(W7743)
                If DATA_SEARCH_VS1() = True Then Call HEAD_SEARCH_DATE_TOTAL()

            Else
                W7743 = D7743

                W7743.InchargeJob = M7743.InchargeJob
                W7743.cdJobProcess = M7743.cdJobProcess
                W7743.cdSubProcess = M7743.cdSubProcess
                W7743.InchargeSelect = M7743.InchargeSelect
                W7743.QtyRateSecondJob = M7743.QtyRateSecondJob

                W7743.Grade = M7743.Grade
                W7743.seJobProcess = ListCode("JobProcess")
                W7743.seSubProcess = ListCode("SubProcess")

                If READ_PFK7171(ListCode("SubProcess"), txt_cdSubProcess.Code) Then
                    W7743.seMainProcess = D7171.seBasicMaster
                    W7743.cdMainProcess = D7171.cdBasicMaster
                End If


                Call REWRITE_PFK7743(W7743)
                If DATA_SEARCH_VS1() = True Then Call HEAD_SEARCH_DATE_TOTAL()
            End If
        End If


    End Sub

    Private Function DATA_MOVE_COPY_WRITE() As Boolean

        DATA_MOVE_COPY_WRITE = False

        DATA_MOVE_COPY_WRITE = True

    End Function

    Private Sub DATA_INSERT()
        If DataCheck() = False Then Exit Sub

        Call DATA_MOVE_WRITE()

        txt_SeqJob.Data = "" : txt_SeqJob.Code = ""
        txt_InchargeJob.Data = "" : txt_InchargeJob.Code = ""
        txt_cdJobProcess.Data = "" : txt_cdJobProcess.Code = ""
        c.Data = 0 : c.Code = 0

        opt_InchargeSelect0.Checked = True
        opt_Grade0.Checked = True

        Call KEY_COUNT()

        Call HEAD_SEARCH_DATE_TOTAL()

        Setfocus(txt_InchargeJob)

    End Sub

    Private Sub DATA_INSERT_COPY()
        If DataCheck = False Then Exit Sub

        If DATA_MOVE_COPY_WRITE = False Then Exit Sub

        If HEAD_SEARCH = True Then
            If DATA_SEARCH_VS1 = True Then Call HEAD_SEARCH_DATE_TOTAL()
        End If


        wJOB = 3

        Frm_MAIN_HEAD.Enabled = True

        txt_QtyTargetDay.Enabled = True
        txt_QtyTargetHour.Enabled = True
        txt_InchargeJob.Enabled = True


        txt_InchargeJob.Enabled = True
        txt_InchargePlan.Enabled = True
        txt_cdJobProcess.Enabled = True

        txt_SeqJob.Data = "" : txt_SeqJob.Code = ""
        txt_InchargeJob.Data = "" : txt_InchargeJob.Code = ""
        txt_cdJobProcess.Data = "" : txt_cdJobProcess.Code = ""
        txt_cdSubProcess.Data = "" : txt_cdSubProcess.Code = ""
        c.Data = "" : c.Code = ""

        opt_InchargeSelect0.Checked = True
        opt_Grade0.Checked = True

        Call KEY_COUNT()
        Setfocus(txt_InchargeJob)

    End Sub

    Private Sub DATA_REUP()
        Dim i As Integer
        Dim J As Integer
        For i = 0 To vS1.ActiveSheet.RowCount - 1
            If READ_PFK7741(getData(vS1, getColumIndex(vS1, "cdFactory"), i), getData(vS1, getColumIndex(vS1, "cdSubProcess"), i), getData(vS1, getColumIndex(vS1, "DatePlan"), i), getData(vS1, getColumIndex(vS1, "cdLineProd"), i)) Then
                W7741 = D7741
                J += 1
                W7741.Dseq = J

                W7741.seFactory = ListCode("Factory")
                W7741.seLineProd = ListCode("LineProd")
                W7741.seSubProcess = ListCode("SubProcess")

                If READ_PFK7171(ListCode("SubProcess"), txt_cdSubProcess.Code) Then
                    W7741.seMainProcess = D7171.seBasicMaster
                    W7741.cdMainProcess = D7171.cdBasicMaster
                End If

                If REWRITE_PFK7741(W7741) = True Then
                    If READ_PFK7743(W7741.cdFactory, W7741.cdSubProcess, W7741.DatePlan, W7741.cdLineProd, "01") = True Then

                    End If
                End If
            End If
        Next
    End Sub
    Private Sub DATA_UPDATE()
        If DataCheck = False Then Exit Sub

        Call DATA_MOVE_WRITE()
        txt_SeqJob.Data = "" : txt_SeqJob.Code = ""
        txt_InchargeJob.Data = "" : txt_InchargeJob.Code = ""
        txt_cdJobProcess.Data = "" : txt_cdJobProcess.Code = ""
        c.Data = 0 : c.Code = 0

        opt_InchargeSelect0.Checked = True
        opt_Grade0.Checked = True

        Call KEY_COUNT()

        Call HEAD_SEARCH_DATE_TOTAL()

        Setfocus(txt_InchargeJob)

        isudCHK = WRITE_CHK
    End Sub

    Private Sub DATA_DELETE()
        WRITE_CHK = False

        '
        If HEAD_SEARCH_SANO(W7743.cdFactory, W7743.cdSubProcess, W7743.DatePlan, W7743.cdLineProd, W7743.SeqJob) = True Then

            SQL = " DELETE FROM PFK7743 "
            SQL = SQL & " WHERE K7743_cdFactory         = '" & W7743.cdFactory & "' "
            SQL = SQL & "   AND K7743_cdSubProcess       = '" & W7743.cdSubProcess & "' "
            SQL = SQL & "   AND K7743_DatePlan       = '" & W7743.DatePlan & "' "
            SQL = SQL & "   AND K7743_cdLineProd       = '" & W7743.cdLineProd & "' "
            SQL = SQL & "   AND K7743_SeqJob        = '" & W7743.SeqJob & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn) : cmd.ExecuteNonQuery()


            WRITE_CHK = True
        End If

        isudCHK = WRITE_CHK

    End Sub

    Private Function DATA_DELETE_K7741(tmpcdFactory As String, tmpcdSubProcess As String, tmpPROD_DATE As String, tmpcdLineProd As String) As Boolean
        DATA_DELETE_K7741 = False

        SQL = " SELECT * FROM PFK7743 "
        SQL = SQL & " WHERE K7743_cdFactory         = '" & tmpcdFactory & "' "
        SQL = SQL & "   AND K7743_DatePlan       = '" & tmpPROD_DATE & "' "
        SQL = SQL & "   AND K7743_cdSubProcess       = '" & tmpcdSubProcess & "' "
        SQL = SQL & "   AND K7743_cdLineProd       = '" & tmpcdLineProd & "' "

        rd = New SqlClient.SqlCommand(SQL, cn).ExecuteReader

        If rd.HasRows = False Then

            W7741.cdFactory = W7743.cdFactory
            W7741.DatePlan = W7743.DatePlan
            W7741.cdLineProd = W7743.cdLineProd
            W7741.cdSubProcess = W7743.cdSubProcess

            Call DELETE_PFK7741(W7741)

            DATA_DELETE_K7741 = True

        End If

        rd.Close()

    End Function

    Private Function DataCheck() As Boolean
        DataCheck = False
        If txt_cdFactory.Code = "" Then MsgBoxP("cdFactory Please!") : Exit Function

        If Trim$(txt_cdFactory.Data) = "" Then txt_cdFactory.Code = ""
        If Trim$(txt_cdLineProd.Data) = "" Then txt_cdLineProd.Code = ""
        If Trim$(txt_InchargePlan.Data) = "" Then txt_InchargePlan.Code = ""
        If Trim$(txt_TimeJob.Data) = "" Then txt_TimeJob.Code = ""
        If Trim$(txt_InchargeJob.Data) = "" Then txt_InchargeJob.Code = ""
        If Trim$(txt_cdJobProcess.Data) = "" Then txt_cdJobProcess.Code = ""
        If Trim$(txt_cdSubProcess.Data) = "" Then txt_cdSubProcess.Code = ""
        If Trim$(txt_QtyRateSecond.Data) = "" Then txt_QtyRateSecond.Code = ""

        If Trim$(txt_DatePlan.Data) = "" Then txt_DatePlan.Data = ""

        If TextCheck("1", txt_cdFactory.Code, WordConv("cdFactory")) = False Then Exit Function
        If TextCheck("1", txt_cdLineProd.Code, WordConv("PRODUCT LINE")) = False Then Exit Function
        If TextCheck("1", txt_InchargeJob.Code, WordConv("SJOB SANO")) = False Then Exit Function
        If TextCheck("1", txt_InchargePlan.Code, WordConv("PLAN SANO")) = False Then Exit Function

        If TextCheck("1", txt_cdSubProcess.Code, WordConv("cdSubProcess")) = False Then Exit Function

        If TextCheck("2", txt_QtyTargetDay.Data, WordConv("DAY TARGET QTY")) = False Then Exit Function
        If TextCheck("2", txt_QtyTargetHour.Data, WordConv("DAY TARGET HOURS")) = False Then Exit Function

        If TextCheck("2", txt_QtyRateSecond.Data, WordConv("PRODUCTION RATE")) = False Then Exit Function

        If Trim$(txt_InchargePlan.Code) = "" Then
            Call Error_Message("118", "Data_Check")
            Exit Function
        End If

        If Trim$(txt_InchargeJob.Code) = "" Then
            Call Error_Message("118", "Data_Check")
            Exit Function
        End If


        DataCheck = True
    End Function

    Private Function DATA_CONDITION_CHK() As Boolean
        DATA_CONDITION_CHK = False

        '' DATA CHECK
        '-- SEWING JOB ORDER CHKECK
        If READ_PFK7743(W7743.cdFactory, W7743.cdSubProcess, W7743.DatePlan, W7743.cdLineProd, W7743.SeqJob) = False Then
            Call Error_Message("150", WordConv("LINE FORMATION"))
            Exit Function
        End If

        If D7743.QtyDateProdNormal > 0 Or D7743.QtyDateProdDefect > 0 Then
            Call Error_Message("150", WordConv("LINE FORMATION"))
            Exit Function
        End If

        DATA_CONDITION_CHK = True

    End Function

    Private Function DATA_PERSON_FORMATION_CHK() As Boolean
        DATA_PERSON_FORMATION_CHK = False

        If Trim(txt_InchargeJob.Data) = "" Then Exit Function

        W7743.cdFactory = FormatP(txt_cdFactory.Code, "000")
        W7743.DatePlan = Replace(txt_DatePlan.Data, "/", "")
        W7743.InchargeJob = txt_InchargeJob.Code
        W7743.cdJobProcess = txt_cdJobProcess.Code


        SQL = " SELECT * FROM PFK7743 "
        SQL = SQL & " WHERE K7743_cdFactory            = '" & W7743.cdFactory & "' "
        SQL = SQL & "   AND K7743_DatePlan          = '" & W7743.DatePlan & "' "
        SQL = SQL & "   AND K7743_InchargeJob          = '" & W7743.InchargeJob & "' "
        SQL = SQL & "   AND K7743_cdJobProcess       = '" & W7743.cdJobProcess & "' "
        rd = New SqlClient.SqlCommand(SQL, cn).ExecuteReader

        If rd.HasRows = True Then
            Call Error_Message("13", WordConv("SANO"))

            rd.Close()
            Setfocus(txt_InchargeJob)
            Exit Function
        End If

        rd.Close()

        DATA_PERSON_FORMATION_CHK = True

    End Function
#End Region

#Region "Events"
    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        Select Case wJOB
            Case 1
                Call KEY_COUNT()


                priJOB_CHK = "INSERT"
                FIRST_LINE_CHK = True
                'D7741.cdFactory = txt_cdFactory.Code : D7741.DatePlan = txt_DatePlan.Code : D7741.cdLineProd = txt_cdLineProd.Code : D7741.cdSubProcess = txt_cdSubProcess.Code
                Call DATA_INSERT()
                Call DATA_SEARCH_VS1()
            Case 2 : Me.Dispose()
            Case 3
                Call DATA_UPDATE() '
                priJOB_CHK = "UPDATE"
            Case 11
                Call DATA_INSERT_COPY()
                If WRITE_CHK = True Then
                    priJOB_CHK = "UPDATE"
                    FIRST_LINE_CHK = False
                Else

                End If

        End Select
    End Sub

    Private Sub tst_iDelete_Click(sender As Object, e As EventArgs) Handles tst_iDelete.Click
        Call Select_Message("5", "tst_iDelete_Click", "2")
        If Msg_Result <> vbYes Then Exit Sub

        SQL = " DELETE FROM PFK7743 "
        SQL = SQL & " WHERE K7743_cdFactory         = '" & txt_cdFactory.Code & "' "
        SQL = SQL & "   AND K7743_cdSubProcess       = '" & txt_cdSubProcess.Code & "' "
        SQL = SQL & "   AND K7743_DatePlan       = '" & txt_DatePlan.Code & "' "
        SQL = SQL & "   AND K7743_cdLineProd       = '" & txt_cdLineProd.Code & "' "

        cmd = New SqlClient.SqlCommand(SQL, cn) : cmd.ExecuteNonQuery()

        If DATA_DELETE_K7741(W7743.cdFactory, W7743.cdSubProcess, W7743.DatePlan, W7743.cdLineProd) = True Then

            isudCHK = True
            Me.Dispose()

        Else
            isudCHK = True
        End If

    End Sub

    Private Sub tst_iClose_Click(sender As Object, e As EventArgs) Handles tst_iClose.Click
        If loop_check = True Then
            Call Select_Message("38", "tst_iDelete_Click", "2")
            If Msg_Result <> vbYes Then Exit Sub
        End If

        If WRITE_CHK = True Then
            isudCHK = True
        Else
            isudCHK = False
        End If

        Me.Dispose()
    End Sub

    Private Sub vS1_DblClick(sender As Object, e As CellClickEventArgs) Handles vS1.CellClick

        L7743.cdFactory = getData(vS1, getColumIndex(vS1, "KEY_cdFactory"), e.Row)
        L7743.DatePlan = getData(vS1, getColumIndex(vS1, "KEY_DatePlan"), e.Row)
        L7743.cdLineProd = getData(vS1, getColumIndex(vS1, "KEY_cdLineProd"), e.Row)
        L7743.SeqJob = getData(vS1, getColumIndex(vS1, "KEY_SeqJob"), e.Row)

        If L7743.cdFactory = "" Then
            txt_SeqJob.Data = "" : txt_SeqJob.Code = ""
            txt_InchargeJob.Data = "" : txt_InchargeJob.Code = ""
            txt_cdJobProcess.Data = "" : txt_cdJobProcess.Code = ""
            txt_cdSubProcess.Data = "" : txt_cdSubProcess.Code = ""

            opt_Grade0.Checked = True

            Exit Sub
        End If

        Call HEAD_SEARCH_SANO(L7743.cdFactory, L7743.cdSubProcess, L7743.DatePlan, L7743.cdLineProd, L7743.SeqJob)

        priJOB_CHK = "UPDATE"
    End Sub

    Private Sub vS1_Click(sender As Object, e As CellClickEventArgs) Handles vS1.CellClick

        L7743.cdFactory = getData(vS1, getColumIndex(vS1, "cdFactory"), e.Row)
        L7743.cdSubProcess = getData(vS1, getColumIndex(vS1, "cdSubProcess"), e.Row)
        L7743.DatePlan = getData(vS1, getColumIndex(vS1, "DatePlan"), e.Row)
        L7743.cdLineProd = getData(vS1, getColumIndex(vS1, "cdLineProd"), e.Row)
        L7743.SeqJob = "01"

        txt_cdFactory.Code = L7743.cdFactory
        txt_cdSubProcess.Code = L7743.cdSubProcess
        txt_cdLineProd.Code = L7743.cdLineProd

        If READ_PFK7171(ListCode("LineProd"), L7743.cdFactory) Then
            txt_cdFactory.Data = D7171.BasicName
        End If

        If READ_PFK7171(ListCode("LineProd"), L7743.cdSubProcess) Then
            txt_cdSubProcess.Data = D7171.BasicName
        End If

        If READ_PFK7171(ListCode("LineProd"), L7743.cdLineProd) Then
            txt_cdLineProd.Data = D7171.BasicName
        End If

        If L7743.cdFactory = "" Then Exit Sub

        Call HEAD_SEARCH_SANO(L7743.cdFactory, L7743.cdSubProcess, L7743.DatePlan, L7743.cdLineProd, L7743.SeqJob)

        priJOB_CHK = "UPDATE"

    End Sub

    Private Sub vS1_KeyDown(sender As Object, e As KeyEventArgs) Handles vS1.KeyDown
        Dim xCOL As Integer
        Dim xRow As Integer

        xCOL = vS1.ActiveSheet.ActiveColumnIndex
        xRow = vS1.ActiveSheet.ActiveRowIndex


        Select Case e.KeyCode

            Case Keys.Insert
                If xRow = vS1.ActiveSheet.RowCount - 1 Then
                    vS1.ActiveSheet.RowCount += 1
                    vS1.ActiveSheet.ActiveRowIndex = xRow + 1

                    setData(vS1, getColumIndex(vS1, "cdLineProd"), xRow + 1, vS1.ActiveSheet.ActiveRowIndex)

                    priJOB_CHK = "INSERT"

                    Call KEY_COUNT()

                    txt_InchargeJob.Data = "" : txt_InchargeJob.Code = ""
                    txt_cdJobProcess.Data = "" : txt_cdJobProcess.Code = ""
                    c.Data = 0 : c.Data = 0
                    opt_InchargeSelect0.Checked = True
                    opt_Grade0.Checked = True

                    Setfocus(txt_InchargeJob)


                Else
                    vS1.ActiveSheet.AddRows(xRow + 1, 1)
                    vS1.ActiveSheet.ActiveRowIndex = xRow + 1
                    priJOB_CHK = "INSERT"
                    setData(vS1, getColumIndex(vS1, "cdLineProd_NAME"), xRow + 1, vS1.ActiveSheet.ActiveRowIndex)

                    Call KEY_COUNT()

                    txt_InchargeJob.Data = "" : txt_InchargeJob.Code = ""
                    txt_cdJobProcess.Data = "" : txt_cdJobProcess.Code = ""
                    c.Data = 0 : c.Data = 0
                    opt_InchargeSelect0.Checked = True
                    opt_Grade0.Checked = True

                    Setfocus(txt_InchargeJob)
                End If

                vS1.ActiveSheet.AddSelection(vS1.ActiveSheet.ActiveRowIndex, 0, 1, 1)
            Case Keys.Delete

                If getData(vS1, getColumIndex(vS1, "DatePlan"), xRow) <> "" Then
                    Call Select_Message("3", WordConv("BARCODE"), 2)

                    If Msg_Result <> vbYes Then Exit Sub

                    W7743.cdFactory = getData(vS1, getColumIndex(vS1, "cdFactory"), xRow)
                    W7743.cdSubProcess = getData(vS1, getColumIndex(vS1, "cdSubProcess"), xRow)
                    W7743.DatePlan = Replace(getData(vS1, getColumIndex(vS1, "DatePlan"), xRow), "/", "")
                    W7743.cdLineProd = getData(vS1, getColumIndex(vS1, "cdLineProd"), xRow)
                    W7743.SeqJob = getData(vS1, getColumIndex(vS1, "SeqJob"), xRow)

                    If Trim(W7743.DatePlan) = "" Then Exit Sub

                    If HEAD_SEARCH_SANO(W7743.cdFactory, W7743.cdSubProcess, W7743.DatePlan, W7743.cdLineProd, W7743.SeqJob) = True Then

                        If READ_PFK7743(W7743.cdFactory, W7743.cdSubProcess, W7743.DatePlan, W7743.cdLineProd, W7743.SeqJob) = True Then
                            If DATA_CONDITION_CHK() = False Then Exit Sub

                            Call DATA_DELETE()

                            Call DATA_DELETE_K7741(W7743.cdFactory, W7743.cdSubProcess, W7743.DatePlan, W7743.cdLineProd)
                        End If
                    End If
                    Call SPR_DEL(vS1, xCOL, xRow)
                Else
                    Call SPR_DEL(vS1, xCOL, xRow)

                End If

            Case Keys.Enter

        End Select
    End Sub

    Private Sub txt_QtyRateSecondJob_txtTextKeyDown(sender As Object, e As KeyEventArgs) Handles opt_Grade0.KeyDown, opt_Grade1.KeyDown, opt_Grade2.KeyDown, opt_Grade3.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            tst_iSave.Select()
        End If
    End Sub

    Private Sub cmd_Reup_Click(sender As Object, e As EventArgs) Handles cmd_Reup.Click
        Call DATA_REUP()
        Call DATA_SEARCH_VS1()
    End Sub
#End Region

End Class