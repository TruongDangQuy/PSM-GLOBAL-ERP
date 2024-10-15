Public Class PFP40755

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
            txt_SlNo.Data = D4010.SlNoD

            Call READ_PFK1312(D4010.WorkOrder, D4010.WorkOrderSeq)
            Call READ_PFK7106(D1312.ShoesCode)
            Call READ_PFK7171(D7106.seSeason, D7106.cdSeason)

            txt_cdSeason.Data = D7171.BasicName
            txt_cdSeason.Code = D7106.cdSeason

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

        DS1 = PrcDS("USP_PFP40755_SEARCH_VS1", cn, txt_cdSeason.Code, txt_SlNo.Data, txt_PKO.Data, chk_USE0.CheckState, chk_USE1.CheckState)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO(Vs1, DS1, "USP_PFP40755_SEARCH_VS1", "Vs1", True)
            Vs1.Enabled = True
            Exit Function
        End If

        SPR_PRO(Vs1, DS1, "USP_PFP40755_SEARCH_VS1", "Vs1", True)
        DATA_SEARCH_VS1 = True

        Vs1.Enabled = True


    End Function

    Private Function DATA_SEARCH_VS2(Optional ByVal xsort As String = "1") As Boolean
        vS2.Enabled = False

        DATA_SEARCH_VS2 = False

        Dim OderNo As String
        Dim OderNoSeq As String
        Dim cdSubProcess As String

        OderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
        OderNoSeq = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex)

        cdSubProcess = getData(Vs1, getColumIndex(Vs1, "KEY_cdSubProcess"), Vs1.ActiveSheet.ActiveRowIndex)

        DS1 = PrcDS("USP_PFP40755_SEARCH_VS2", cn, OderNo, OderNoSeq,
                                                cdSubProcess)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO(vS2, DS1, "USP_PFP40755_SEARCH_VS2", "VS2", True)
            vS2.Enabled = True
            Exit Function
        End If

        SPR_PRO(vS2, DS1, "USP_PFP40755_SEARCH_VS2", "VS2", True)
        DATA_SEARCH_VS2 = True

        vS2.Enabled = True

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

#End Region

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If MsgBoxPPW("Please type the password to revise this data !!", "755") = False Then Exit Sub

        Dim xRow As Integer
        Dim cdFactory_new As String
        Dim cdLineProd_new As String

        Dim OderNo As String
        Dim OderNoSeq As String
        Dim cdSubProcess As String
        Dim BarcodeNo As String

        Dim Starting As Object

        Dim cdMainProcess As String
        Dim cdFactory As String
        Dim cdLineProd As String

        cdFactory_new = txt_cdFactory.Code
        cdLineProd_new = txt_cdLineProd.Code

        OderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
        OderNoSeq = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex)
        cdSubProcess = getData(Vs1, getColumIndex(Vs1, "KEY_cdSubProcess"), Vs1.ActiveSheet.ActiveRowIndex)

        If cdFactory_new = "" Then MsgBoxP("Factory Input ?!") : Exit Sub
        If cdLineProd_new = "" Then MsgBoxP("Line Input ?!") : Exit Sub
        If txt_ProdDate.Data = "" Then MsgBoxP("Date Input ?!") : Exit Sub

        If READ_PFK7171("002", cdSubProcess) Then
            cdMainProcess = D7171.CheckName7
        End If


        Try
            Msg_Result = MsgBox("Waring ! You can not roll back ! Do you want to transfer ?", vbYesNo)

            If Msg_Result = MsgBoxResult.No Then Exit Sub

            Starting = New DevExpress.Utils.WaitDialogForm("Process Closing data...", "PSM")

            For xRow = 0 To vS2.ActiveSheet.RowCount - 1
                If getDataM(vS2, getColumIndex(vS2, "DCHK"), xRow) = "1" Then

                    BarcodeNo = getData(vS2, getColumIndex(vS2, "BarcodeNo"), xRow)

                    If getData(vS2, getColumIndex(vS2, "cdFactoryName"), xRow) <> "" Then

                        cdFactory = getData(vS2, getColumIndex(vS2, "cdFactory"), xRow)
                        cdLineProd = getData(vS2, getColumIndex(vS2, "cdLineProd"), xRow)

                        Call PrcExeNoError("USP_PFP40755_TRANSFER_DATA_DETAIL", cn, cdFactory, cdLineProd, cdFactory_new, cdLineProd_new, Pub.SAW, BarcodeNo, cdSubProcess)
                        Call PrcExeNoError("USP_PFP40755_TRANSFER_DATA_CLOSING_DETAIL", cn, BarcodeNo, cdSubProcess, cdFactory, cdLineProd, cdFactory_new, cdLineProd_new)

                    Else
                        If cdSubProcess = "130" Then
                            Call PrcExeNoError("USP_PFP40755_INSERT_PFK2651", cn, BarcodeNo, Pub.SAW, cdFactory_new, cdLineProd_new, txt_ProdDate.Data)
                        End If

                        If cdSubProcess <> "131" Then
                            Call PrcExeNoError("USP_PFP40755_INSERT_PFK2656", cn, BarcodeNo, Pub.SAW, cdFactory_new, cdLineProd_new, txt_ProdDate.Data)
                        End If

                    End If

                    Application.DoEvents()
                    Me.Show()
                    SPR_BACKCOLORCELL(vS2, Color.PaleVioletRed, getColumIndex(vS2, "cdFactoryName"), xRow)
                    SPR_BACKCOLORCELL(vS2, Color.PaleVioletRed, getColumIndex(vS2, "cdLineProdName"), xRow)

                    setData(vS2, getColumIndex(vS2, "DCHK"), xRow, "2")

                End If

            Next

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

        Dim OderNo As String
        Dim OderNoSeq As String
        Dim cdSubProcess As String

        If MsgBoxPPW("Please type the password to revise this data !!", "755") = False Then Exit Sub

        Try


            Starting = New DevExpress.Utils.WaitDialogForm("Process Closing data...", "PSM")
            For xRow = 0 To Vs1.ActiveSheet.RowCount - 1
                If getDataM(Vs1, getColumIndex(Vs1, "DCHK"), xRow) = "1" Then

                    cdFactory = getData(Vs1, getColumIndex(Vs1, "cdFactory"), xRow)
                    cdLineProd = getData(Vs1, getColumIndex(Vs1, "cdLineProd"), xRow)

                    cdFactory_new = getData(Vs1, getColumIndex(Vs1, "cdFactory_new"), xRow)
                    cdLineProd_new = getData(Vs1, getColumIndex(Vs1, "cdLineProd_new"), xRow)

                    OderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), xRow)
                    OderNoSeq = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), xRow)

                    cdSubProcess = getData(Vs1, getColumIndex(Vs1, "KEY_cdSubProcess"), xRow)

                    Call PrcExeNoError("USP_PFP40755_TRANSFER_DATA", cn, cdFactory, cdLineProd, cdFactory_new, cdLineProd_new, Pub.SAW, OderNo, OderNoSeq, cdSubProcess)
                    Call PrcExeNoError("USP_PFP40755_TRANSFER_DATA_CLOSING", cn, OderNo, OderNoSeq, cdSubProcess, cdFactory, cdLineProd, cdFactory_new, cdLineProd_new)

                    Application.DoEvents()
                    Me.Show()
                    SPR_BACKCOLORCELL(Vs1, Color.PaleVioletRed, getColumIndex(Vs1, "cdFactoryName_Now"), xRow)
                    SPR_BACKCOLORCELL(Vs1, Color.PaleVioletRed, getColumIndex(Vs1, "cdLineProdName_Now"), xRow)

                    setData(Vs1, getColumIndex(Vs1, "DCHK"), xRow, "2")
                End If

            Next

        Catch ex As Exception

        Finally
            Starting.close()
        End Try

    End Sub


    Private Sub cmd_ClosingSlNo_Click(sender As Object, e As EventArgs) Handles cmd_ClosingSlNo.Click
        Dim OderNo As String
        Dim OderNoSeq As String
        Try
            OderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
            OderNoSeq = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex)

            If READ_PFK3452_OrderNo(OderNo, OderNoSeq) = False Then Exit Sub

            If D3452.CheckPurchasing = "2" Then
                MsgBoxEx("Already Completed !")
                Msg_Result = MsgBox("Do you want to unlock this Seal " & D3452.PKO, vbYesNo)

                If Msg_Result <> vbYes Then Exit Sub
                Call PrcExeNoError("USP_PFK3452_CLOSSING_ALL_PROCESS_OrderNo", cn, OderNo, OderNoSeq, "1")
                Exit Sub
            End If

            Msg_Result = MsgBox("Do you want to close this Seal " & D3452.PKO, vbYesNo)

            If Msg_Result <> vbYes Then Exit Sub

            Call PrcExeNoError("USP_PFK3452_CLOSSING_ALL_PROCESS_OrderNo", cn, OderNo, OderNoSeq, "2")


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

        Dim cdSubProcess As String
        Dim BatchNo As String

        Dim Starting As Object

        Dim cdFactory As String
        Dim cdLineProd As String
        Dim LineTno As String

        cdFactory_new = txt_cdFactory.Code
        cdLineProd_new = txt_cdLineProd.Code

        cdSubProcess = getData(Vs1, getColumIndex(Vs1, "KEY_cdSubProcess"), Vs1.ActiveSheet.ActiveRowIndex)

        Try
            Msg_Result = MsgBox("Waring ! You can not roll back ! Do you want to transfer ?", vbYesNo)

            If Msg_Result = MsgBoxResult.No Then Exit Sub

            Starting = New DevExpress.Utils.WaitDialogForm("Process Closing data...", "PSM")

            For xRow = 0 To vS2.ActiveSheet.RowCount - 1
                If getDataM(vS2, getColumIndex(vS2, "DCHK"), xRow) = "1" Then

                    BatchNo = getData(vS2, getColumIndex(vS2, "BarcodeNo"), xRow)

                    Call PrcExeNoError("USP_PFP40755_TRANSFER_DATA_DELETE", cn, Pub.SAW, BatchNo, cdSubProcess)

                    Application.DoEvents()
                    Me.Show()

                    SPR_BACKCOLORCELL(vS2, Color.PaleVioletRed, getColumIndex(vS2, "BatchNo"), xRow)
                    setData(vS2, getColumIndex(vS2, "BarcodeNo"), xRow, "[DELETED]")

                    setData(vS2, getColumIndex(vS2, "DCHK"), xRow, "2")

                End If

            Next

        Catch ex As Exception

        Finally
            Starting.close()
        End Try

    End Sub

End Class