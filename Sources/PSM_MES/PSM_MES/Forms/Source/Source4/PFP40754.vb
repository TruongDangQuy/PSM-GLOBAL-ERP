Public Class PFP40754

#Region "Variable"
    Private Dsu01 As Long
    Private wGCODE As String
    Protected prg As E_PRG

    Private W1317 As T1317_AREA

    Private Form_Close As Boolean

#End Region

#Region "Form_load"
    Public Function Link_ISUD40751A(JobCard As String, Optional cdSubProcess As String = "001") As Boolean
        If READ_PFK4010(JobCard) Then
            txt_SlNoD.Data = D4010.SlNoD

            Call READ_PFK1312(D4010.WorkOrder, D4010.WorkOrderSeq)
            Call READ_PFK7106(D1312.ShoesCode)
            Call READ_PFK7171(D7106.seSeason, D7106.cdSeason)

            txt_cdSite.Data = D7171.BasicName
            txt_cdSite.Code = D7106.cdSeason

            'txt_cdTrackingCodeCode.Data = "001"

            'If READ_PFK7171(ListCode("SubProcessCode"), cdSubProcess) Then
            '    txt_cdTrackingCodeCode.Data = D7171.BasicName
            '    txt_cdTrackingCodeCode.Code = D7171.BasicCode
            'End If

            Me.ShowDialog()

        End If
    End Function
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)

        Me.KeyPreview = True

        Call FORM_INIT()
        Call DATA_INIT()
    End Sub
    Private Sub PFP17811_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub
    Overrides Sub Function_Event(PressKey As Integer)
        Try
            Select Case PressKey
                Case Keys.F5 : Call MAIN_JOB01()
                Case Keys.F6 : Call MAIN_JOB02()
                Case Keys.F7 : Call MAIN_JOB03()
                Case Keys.F8 : Call MAIN_JOB04()
                Case Keys.F9 : Call MAIN_JOB05()
                Case Keys.F10 : Call MAIN_JOB06()
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FORM_INIT()
        Me.chk_FormEnterkey = False
    End Sub

    Private Sub DATA_INIT()
        txt_ProdDate.Data = Pub.DAT

        If Weekday(CDate(FSDate(System_Date_Add(0, 0))), FirstDayOfWeek.Sunday) = 1 Then txt_ProdDate.Data = System_Date_Add(0, 0)
        If Weekday(CDate(FSDate(System_Date_Add(0, -1))), FirstDayOfWeek.Sunday) = 1 Then txt_ProdDate.Data = System_Date_Add(0, -1)
        If Weekday(CDate(FSDate(System_Date_Add(0, -2))), FirstDayOfWeek.Sunday) = 1 Then txt_ProdDate.Data = System_Date_Add(0, -2)
        If Weekday(CDate(FSDate(System_Date_Add(0, -3))), FirstDayOfWeek.Sunday) = 1 Then txt_ProdDate.Data = System_Date_Add(0, -3)
        If Weekday(CDate(FSDate(System_Date_Add(0, -4))), FirstDayOfWeek.Sunday) = 1 Then txt_ProdDate.Data = System_Date_Add(0, -4)
        If Weekday(CDate(FSDate(System_Date_Add(0, -5))), FirstDayOfWeek.Sunday) = 1 Then txt_ProdDate.Data = System_Date_Add(0, -5)
        If Weekday(CDate(FSDate(System_Date_Add(0, -6))), FirstDayOfWeek.Sunday) = 1 Then txt_ProdDate.Data = System_Date_Add(0, -6)

    End Sub
#End Region

#Region "Function"
    Private Sub MAIN_JOB01()


    End Sub

    Private Sub MAIN_JOB02()

    End Sub

    Private Sub MAIN_JOB03()


    End Sub

    Private Sub MAIN_JOB04()

    End Sub


    Private Sub MAIN_JOB05()
    End Sub

    Private Sub MAIN_JOB06()

    End Sub

#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS1(Optional ByVal xsort As String = "1") As Boolean
        Vs1.Enabled = False

        DATA_SEARCH_VS1 = False

        DS1 = PrcDS("USP_PFP40754_SEARCH_VS1", cn, txt_cdClosingCode.Code, txt_cdSite.Code, txt_SlNoD.Data, chk_USE0.CheckState, chk_USE1.CheckState)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO(Vs1, DS1, "USP_PFP40754_SEARCH_VS1", "Vs1", True)
            Vs1.Enabled = True
            Exit Function
        End If

        SPR_PRO(Vs1, DS1, "USP_PFP40754_SEARCH_VS1", "Vs1", True)
        DATA_SEARCH_VS1 = True

        Vs1.Enabled = True


    End Function

    Private Function DATA_SEARCH_VS2(Optional ByVal xsort As String = "1") As Boolean
        vS2.Enabled = False

        DATA_SEARCH_VS2 = False

        Dim jobcard As String
        Dim cdSubProcess As String

        jobcard = getData(Vs1, getColumIndex(Vs1, "jobcard"), Vs1.ActiveSheet.ActiveRowIndex)
        cdSubProcess = getData(Vs1, getColumIndex(Vs1, "KEY_cdSubProcess"), Vs1.ActiveSheet.ActiveRowIndex)

        If READ_PFK7171(ListCode("SubProcess"), cdSubProcess) = False Then Exit Function

        If D7171.CheckName7 <> "002" Then

            DS1 = PrcDS("USP_PFP40754_SEARCH_VS2", cn, jobcard,
                                                    cdSubProcess)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO(vS2, DS1, "USP_PFP40754_SEARCH_VS2", "VS2", True)
                vS2.Enabled = True
                Exit Function
            End If

            SPR_PRO(vS2, DS1, "USP_PFP40754_SEARCH_VS2", "VS2", True)
            DATA_SEARCH_VS2 = True

            vS2.Enabled = True

        Else
            DS1 = PrcDS("USP_PFP40754_SEARCH_VS2_CUTTING", cn, jobcard,
                                                    cdSubProcess)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO(vS2, DS1, "USP_PFP40754_SEARCH_VS2_CUTTING", "VS2", True)
                vS2.Enabled = True
                Exit Function
            End If

            SPR_PRO(vS2, DS1, "USP_PFP40754_SEARCH_VS2_CUTTING", "VS2", True)
            DATA_SEARCH_VS2 = True

            vS2.Enabled = True

        End If


    End Function



    Private Function DATA_SEARCH_VS1_ALL(Optional ByVal xsort As String = "1") As Boolean
        Vs1.Enabled = False

        DATA_SEARCH_VS1_ALL = False

        If txt_cdClosingCode.Code = "" Then MsgBoxEx("SubProcess Code !") : Exit Function
        If READ_PFK4010_SLNO_SEASON(txt_cdSite.Code, txt_SlNoD.Data) = False Then MsgBoxEx("Seal Wrong Code !") : Exit Function

        DS1 = PrcDS("USP_PFP40754_SEARCH_VS1_ALL", cn, txt_cdClosingCode.Code,
                                                txt_cdSite.Code,
                                                txt_SlNoD.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO(Vs1, DS1, "USP_PFP40754_SEARCH_VS1_ALL", "Vs1", True)
            Vs1.Enabled = True
            Exit Function
        End If

        SPR_PRO(Vs1, DS1, "USP_PFP40754_SEARCH_VS1_ALL", "Vs1", True)
        DATA_SEARCH_VS1_ALL = True

        Vs1.Enabled = True


    End Function

    Private Function LINE_MOVE_DISPLAY01() As Boolean
        Vs1.Enabled = False

        LINE_MOVE_DISPLAY01 = False

        DS1 = PrcDS("USP_PFP40754_SEARCH_VS1_LINE", cn, getData(Vs1, getColumIndex(Vs1, "KEY_ProdDate"), Vs1.ActiveSheet.ActiveRowIndex),
                                        getData(Vs1, getColumIndex(Vs1, "KEY_ProdSeq"), Vs1.ActiveSheet.ActiveRowIndex))
        If GetDsRc(DS1) = 0 Then
            Vs1.Enabled = True
            Exit Function
        End If
        READ_SPREAD(Vs1, DS1, "USP_PFP40754_SEARCH_VS1", "Vs1", Vs1.ActiveSheet.ActiveRowIndex)
        LINE_MOVE_DISPLAY01 = True

        Vs1.Enabled = True
    End Function

#End Region

#Region "Event"

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        Try

            Call DATA_SEARCH_VS1()
        Catch ex As Exception
            Call MsgBoxP("35", "cmd_SEARCH_Click")
        End Try
    End Sub



    Public Sub DATA_MOVE_BARCODE()

        Try
            PrintDocument1 = New Printing.PrintDocument
            PrintDocument1.Print()
        Catch ex As Exception
        End Try

    End Sub


    Private CheckPassword As Boolean = False

    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        If e.ColumnHeader Then Exit Sub
        Call DATA_SEARCH_VS2()
    End Sub

    Private Sub Vs1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown

    End Sub


#End Region

    Private Function CheckData() As Boolean
        CheckData = False
        Dim xRow As Integer
        Dim ProdDate As String
        Dim ProdSeq As String

        Try
            'For xRow = 0 To Vs1.ActiveSheet.RowCount - 1
            '    If getDataM(Vs1, getColumIndex(Vs1, "DCHK"), xRow) = "1" Then

            '        ProdDate = getData(Vs1, getColumIndex(Vs1, "KEY_ProdDate"), xRow)
            '        ProdSeq = getData(Vs1, getColumIndex(Vs1, "KEY_ProdSeq"), xRow)

            '        rd = PrcDR("USP_PFP40754_CHECKDATA", cn, ProdDate, ProdSeq)

            '        If rd.HasRows = True Then
            '            rd.Read()
            '            MsgBoxP(rd(0))
            '            rd.Close()
            '            Exit Function
            '        End If

            '    End If

            'Next

            CheckData = True

        Catch ex As Exception

        End Try
    End Function

    Private Function KEY_TSEQ(cdFactory As String, cdLineProd As String) As String
        KEY_TSEQ = ""
        Dim YRNO As Integer
        YRNO = Mid(System_Date_8(), 3, 4)

        Try
            SQL = "SELECT MAX(CAST(K4073_LineTno AS DECIMAL)) AS MAX_MCODE FROM PFK4073 "
            SQL = SQL & " WHERE K4073_cdFactory = '" & cdFactory & "' "
            SQL = SQL & " AND K4073_cdLineProd = '" & cdLineProd & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                rd.Close()
                Exit Function
            Else
                KEY_TSEQ = Format(CInt(rd!MAX_MCODE), "00")
            End If

            rd.Close()
        Catch ex As Exception
            Call MsgBoxP("35", "KEY_TSEQ")
        End Try
    End Function

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If MsgBoxPPW("Please type the password to revise this data !!", "755") = False Then Exit Sub

        Dim xRow As Integer
        Dim cdFactory_new As String
        Dim cdLineProd_new As String

        Dim jobcard As String
        Dim cdSubProcess As String
        Dim BatchNo As String

        Dim Starting As Object

        Dim cdMainProcess As String
        Dim cdFactory As String
        Dim cdLineProd As String
        Dim LineTno As String

        cdFactory_new = txt_cdFactory.Code
        cdLineProd_new = txt_cdLineProd.Code

        jobcard = getData(Vs1, getColumIndex(Vs1, "jobcard"), Vs1.ActiveSheet.ActiveRowIndex)
        cdSubProcess = getData(Vs1, getColumIndex(Vs1, "KEY_cdSubProcess"), Vs1.ActiveSheet.ActiveRowIndex)

        If cdFactory_new = "" Then MsgBoxP("Factory Input ?!") : Exit Sub
        If cdLineProd_new = "" Then MsgBoxP("Line Input ?!") : Exit Sub
        If txt_ProdDate.Data = "" Then MsgBoxP("Date Input ?!") : Exit Sub

        If READ_PFK7171("002", cdSubProcess) Then
            cdMainProcess = D7171.CheckName7
        End If

        If cdSubProcess = "050" Then

            If ISUD4367A.Link_ISUD4367A(1, "", jobcard, "050", cdFactory, cdLineProd, Me.Name) Then
                DATA_SEARCH_VS2()
            End If

            Exit Sub
        End If

        Try
            Msg_Result = MsgBox("Waring ! You can not roll back ! Do you want to transfer ?", vbYesNo)

            If Msg_Result = MsgBoxResult.No Then Exit Sub

            Starting = New DevExpress.Utils.WaitDialogForm("Process Closing data...", "PSM")

            If cdSubProcess <> "001" And cdSubProcess <> "050" Then
                For xRow = 0 To vS2.ActiveSheet.RowCount - 1
                    If getDataM(vS2, getColumIndex(vS2, "DCHK"), xRow) = "1" Then

                        BatchNo = getData(vS2, getColumIndex(vS2, "BatchNo"), xRow)

                        If getData(vS2, getColumIndex(vS2, "cdFactoryName_M1"), xRow) <> "" Then

                            Call PrcExeNoError("USP_PFP40754_TRANSFER_DATA_DETAIL", cn, BatchNo, cdFactory_new, cdLineProd_new, Pub.SAW, jobcard, cdSubProcess)
                            Call PrcExeNoError("USP_PFP40754_TRANSFER_DATA_CLOSING_DETAIL", cn, jobcard, cdSubProcess, cdFactory_new, cdLineProd_new, BatchNo)

                        Else
                            If cdSubProcess = "015" Then
                                Call PrcExeNoError("USP_CLOSINGDATA_PFK2451_CASE002", cn, txt_ProdDate.Data, cdFactory_new, cdLineProd_new, Pub.SAW, BatchNo)
                            End If

                            If cdSubProcess <> "001" Then
                                Call PrcExeNoError("USP_CLOSINGDATA_PFK4090_CASE001", cn, txt_ProdDate.Data, cdFactory_new, cdLineProd_new, cdSubProcess, Pub.SAW, BatchNo)
                            End If

                        End If

                        Application.DoEvents()
                        Me.Show()
                        SPR_BACKCOLORCELL(vS2, Color.PaleVioletRed, getColumIndex(vS2, "cdFactoryName_M1"), xRow)
                        SPR_BACKCOLORCELL(vS2, Color.PaleVioletRed, getColumIndex(vS2, "cdLineProdName_M1"), xRow)

                        setData(vS2, getColumIndex(vS2, "DCHK"), xRow, "2")

                    End If

                Next


                If jobcard <> "" Then Call PrcExeNoError("USP_PFK4167_CLOSSING_DATE_ALL_JOBCARD_FULL", cn, jobcard)

            Else

                For xRow = 0 To vS2.ActiveSheet.RowCount - 1
                    If getDataM(vS2, getColumIndex(vS2, "DCHK"), xRow) = "1" Then

                        BatchNo = getData(vS2, getColumIndex(vS2, "BatchGroup"), xRow)


                        DS1 = PrcDS("USP_PFK4367_INSERT_BATCHGROUP", cn, txt_ProdDate.Data, cdSubProcess, txt_cdFactory.Code, txt_cdLineProd.Code, Pub.SAW, BatchNo)

                    End If

                Next


                If jobcard <> "" Then Call PrcExeNoError("USP_PFK4167_CLOSSING_DATE_ALL_JOBCARD_FULL_CUTTING", cn, jobcard, txt_ProdDate.Data)

            End If




        Catch ex As Exception

        Finally
            Starting.close()
        End Try


    End Sub

    Private Sub cmd_Revise_Click(sender As Object, e As EventArgs) Handles cmd_Revise.Click
        Dim Starting As Object

        Dim xRow As Integer
        Dim cdFactory As String
        Dim cdLineProd As String

        Dim cdFactory_new As String
        Dim cdLineProd_new As String

        Dim jobcard As String
        Dim cdSubProcess As String

        Dim jobcardx As String

        If MsgBoxPPW("Please type the password to revise this data !!", "755") = False Then Exit Sub

        Try


            Starting = New DevExpress.Utils.WaitDialogForm("Process Closing data...", "PSM")
            For xRow = 0 To Vs1.ActiveSheet.RowCount - 1
                If getDataM(Vs1, getColumIndex(Vs1, "DCHK"), xRow) = "1" Then

                    cdFactory = getData(Vs1, getColumIndex(Vs1, "cdFactory"), xRow)
                    cdLineProd = getData(Vs1, getColumIndex(Vs1, "cdLineProd"), xRow)

                    cdFactory_new = getData(Vs1, getColumIndex(Vs1, "cdFactory_new"), xRow)
                    cdLineProd_new = getData(Vs1, getColumIndex(Vs1, "cdLineProd_new"), xRow)

                    jobcard = getData(Vs1, getColumIndex(Vs1, "jobcard"), xRow)
                    cdSubProcess = getData(Vs1, getColumIndex(Vs1, "KEY_cdSubProcess"), xRow)

                    Call PrcExeNoError("USP_PFP40754_TRANSFER_DATA", cn, cdFactory, cdLineProd, cdFactory_new, cdLineProd_new, Pub.SAW, jobcard, cdSubProcess)
                    Call PrcExeNoError("USP_PFP40754_TRANSFER_DATA_CLOSING", cn, jobcard, cdSubProcess, cdFactory_new, cdLineProd_new)


                    If jobcard <> jobcardx And jobcardx <> "" Then
                        Call PrcExeNoError("USP_PFK4167_CLOSSING_DATE_ALL_JOBCARD_FULL", cn, jobcard)
                    End If

                    Application.DoEvents()
                    Me.Show()
                    SPR_BACKCOLORCELL(Vs1, Color.PaleVioletRed, getColumIndex(Vs1, "cdFactoryName_Now"), xRow)
                    SPR_BACKCOLORCELL(Vs1, Color.PaleVioletRed, getColumIndex(Vs1, "cdLineProdName_Now"), xRow)

                    setData(Vs1, getColumIndex(Vs1, "DCHK"), xRow, "2")

                    jobcardx = getData(Vs1, getColumIndex(Vs1, "jobcard"), xRow)
                End If

            Next

            If jobcardx <> "" Then Call PrcExeNoError("USP_PFK4167_CLOSSING_DATE_ALL_JOBCARD_FULL", cn, jobcardx)

        Catch ex As Exception

        Finally
            Starting.close()
        End Try

    End Sub


    Private Sub cmd_ClosingSlNo_Click(sender As Object, e As EventArgs) Handles cmd_ClosingSlNo.Click
        Dim JobCard As String

        Try
            JobCard = getData(Vs1, getColumIndex(Vs1, "JOBCARD"), Vs1.ActiveSheet.ActiveRowIndex)

            If READ_PFK4010(JobCard) = False Then Exit Sub

            If D4010.CheckPlan = "1" Then
                MsgBoxEx("Already Completed !")
                Msg_Result = MsgBox("Do you want to open this Seal " & D4010.SlNoD, vbYesNo)

                If Msg_Result <> vbYes Then Exit Sub
                D4010.CheckPlan = "2"
                D4010.DateFinish = ""
                D4010.DateUpdate = Pub.DAT

                Call REWRITE_PFK4010(D4010)
                Exit Sub

            End If

            Msg_Result = MsgBox("Do you want to close this Seal " & D4010.SlNoD, vbYesNo)

            If Msg_Result <> vbYes Then Exit Sub

            Call PrcExeNoError("USP_PFK4013_CLOSSING_ALL_PROCESS_STATUS_ONLY", cn, JobCard)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub PeaceButton1_Click(sender As Object, e As EventArgs) Handles cmd_ClosingSL.Click
        Dim JobCard As String
        Dim Starting As Object

        Try
            JobCard = getData(vS1, getColumIndex(vS1, "KEY_JOBCARD"), vS1.ActiveSheet.ActiveRowIndex)

            If READ_PFK4010(JobCard) = False Then Exit Sub

            Msg_Result = MsgBox("Do you want to close this Seal " & D4010.SlNoD, vbYesNo)

            If Msg_Result <> vbYes Then Exit Sub

            Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")

            Call PrcExeNoError("USP_PFK4167_CLOSSING_DATE_ALL_JOBCARD_FULL", cn, JobCard)

        Catch ex As Exception

        Finally
            Starting.close()
        End Try
    End Sub



    Private Sub cmd_Del_Click(sender As Object, e As EventArgs) Handles cmd_Del.Click
        If MsgBoxPPW("Please type the password to delete this data !!", "755") = False Then Exit Sub

        Dim xRow As Integer
        Dim cdFactory_new As String
        Dim cdLineProd_new As String

        Dim jobcard As String
        Dim cdSubProcess As String
        Dim BatchNo As String

        Dim Starting As Object

        Dim cdMainProcess As String
        Dim cdFactory As String
        Dim cdLineProd As String
        Dim LineTno As String

        cdFactory_new = txt_cdFactory.Code
        cdLineProd_new = txt_cdLineProd.Code

        jobcard = getData(Vs1, getColumIndex(Vs1, "jobcard"), Vs1.ActiveSheet.ActiveRowIndex)
        cdSubProcess = getData(Vs1, getColumIndex(Vs1, "KEY_cdSubProcess"), Vs1.ActiveSheet.ActiveRowIndex)


        If READ_PFK7171("002", cdSubProcess) Then
            cdMainProcess = D7171.CheckName7
        End If

        Try
            Msg_Result = MsgBox("Waring ! You can not roll back ! Do you want to transfer ?", vbYesNo)

            If Msg_Result = MsgBoxResult.No Then Exit Sub

            Starting = New DevExpress.Utils.WaitDialogForm("Process Closing data...", "PSM")

            If cdSubProcess <> "001" And cdSubProcess <> "050" Then
                For xRow = 0 To vS2.ActiveSheet.RowCount - 1
                    If getDataM(vS2, getColumIndex(vS2, "DCHK"), xRow) = "1" Then

                        BatchNo = getData(vS2, getColumIndex(vS2, "BatchNo"), xRow)

                        Call PrcExeNoError("USP_PFP40754_TRANSFER_DATA_DELETE", cn, Pub.SAW, BatchNo, cdSubProcess)

                        Application.DoEvents()
                        Me.Show()

                        SPR_BACKCOLORCELL(vS2, Color.PaleVioletRed, getColumIndex(vS2, "BatchNo"), xRow)
                        setData(vS2, getColumIndex(vS2, "BatchNo"), xRow, "[DELETED]")

                        setData(vS2, getColumIndex(vS2, "DCHK"), xRow, "2")

                    End If

                Next


                If jobcard <> "" Then Call PrcExeNoError("USP_PFK4167_CLOSSING_DATE_ALL_JOBCARD_FULL", cn, jobcard)

            Else

                Dim ProdDate As String

                For xRow = 0 To vS2.ActiveSheet.RowCount - 1
                    If getDataM(vS2, getColumIndex(vS2, "DCHK"), xRow) = "1" Then

                        BatchNo = getData(vS2, getColumIndex(vS2, "BatchGroup"), xRow)
                        ProdDate = FormatCut(getData(vS2, getColumIndex(vS2, "ProdDate"), xRow))

                        If cdSubProcess <> "050" Then
                            Call PrcExeNoError("USP_PFK4367_DELETE_BATCHGROUP", cn, ProdDate, BatchNo, cdSubProcess, Pub.SAW)
                        Else
                            Dim cdFactory_1 As String = getData(vS2, getColumIndex(vS2, "cdFactory"), xRow)
                            Dim cdLineProd_2 As String = getData(vS2, getColumIndex(vS2, "cdLineProd"), xRow)

                            Call PrcExeNoError("USP_PFK4367_DELETE_BATCHGROUP_SB1", cn, jobcard, BatchNo, ProdDate, cdFactory_1, cdLineProd_2)
                        End If


                        Application.DoEvents()
                        Me.Show()

                        SPR_BACKCOLORCELL(vS2, Color.PaleVioletRed, getColumIndex(vS2, "BatchGroup"), xRow)
                        setData(vS2, getColumIndex(vS2, "BatchGroup"), xRow, "[DELETED]")

                        setData(vS2, getColumIndex(vS2, "dchk"), xRow, "2")

                    End If

                Next


                If cdSubProcess <> "050" Then If jobcard <> "" Then Call PrcExeNoError("USP_PFK4167_CLOSSING_DATE_ALL_JOBCARD_FULL_CUTTING", cn, jobcard, ProdDate)
                If cdSubProcess = "050" Then If jobcard <> "" Then Call PrcExeNoError("USP_PFK4167_CLOSSING_DATE_ALL_JOBCARD_FULL_CUTTING", cn, jobcard, ProdDate)

            End If

           

        Catch ex As Exception

        Finally
            Starting.close()
        End Try

    End Sub

    Private Sub cmd_Gen_Click(sender As Object, e As EventArgs) Handles cmd_Gen.Click
        Try
            If MsgBoxPPW("Please type the password to gen this data !!", "755") = False Then Exit Sub


            Dim xRow As Integer
            Dim cdFactory_new As String
            Dim cdLineProd_new As String

            Dim jobcard As String
            Dim cdSubProcess As String
            Dim BatchNo As String

            Dim Starting As Object

            Dim cdMainProcess As String
            Dim cdFactory As String
            Dim cdLineProd As String
            Dim LineTno As String

            cdFactory_new = txt_cdFactory.Code
            cdLineProd_new = txt_cdLineProd.Code

            jobcard = getData(Vs1, getColumIndex(Vs1, "jobcard"), Vs1.ActiveSheet.ActiveRowIndex)
            cdSubProcess = getData(Vs1, getColumIndex(Vs1, "KEY_cdSubProcess"), Vs1.ActiveSheet.ActiveRowIndex)


            xRow = Vs1.ActiveSheet.ActiveRowIndex
            cdFactory = txt_cdFactory.Code
            cdLineProd = txt_cdLineProd.Code

            If READ_PFK7171("002", cdSubProcess) Then
                cdMainProcess = D7171.CheckName7
            End If


            If READ_PFK4010(jobcard) = False Then Exit Sub
            If READ_PFK1312(D4010.WorkOrder, D4010.WorkOrderSeq) = False Then Exit Sub
            If READ_PFK7106(D1312.ShoesCode) = False Then Exit Sub

            If cdFactory = "" Then MsgBoxP("Factory Plz!") : Exit Sub
            If cdLineProd = "" Then MsgBoxP("Line Plan Plz!") : Exit Sub

            If READ_PFK4073_TOPJOBCARD_FACTORY(cdFactory, cdMainProcess, jobcard) = True Then
                If ISUD4073F.Link_ISUD4073F(3, D4073.cdFactory, D4073.cdMainProcess, D4073.cdLineProd, D4073.LineTno, "PFP40703") = False Then Exit Sub
            Else
                Msg_Result = MsgBox("No have Cutting Plan. Are you want make new Cutting Plan for " & D4010.SlNoD, vbYesNo)

                If Msg_Result <> vbYes Then Exit Sub

                LineTno = PrcExeNoError_Value("USP_PFK4073_INSERT_AUTO_SlNoD_GENENARATION_PFP40703", cn, D7106.cdSeason, cdFactory, cdMainProcess, cdLineProd, D4010.SlNoD)

                If LineTno = "" Then Exit Sub
                If ISUD4073F.Link_ISUD4073F(3, cdFactory, cdMainProcess, cdLineProd, LineTno, "PFP40703") = False Then Exit Sub

            End If
        Catch ex As Exception

        End Try
    End Sub

End Class