Public Class PFP40751

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
            Me.chk_FormEnterkey = False
            Call READ_PFK1312(D4010.WorkOrder, D4010.WorkOrderSeq)
            Call READ_PFK7106(D1312.ShoesCode)
            Call READ_PFK7171(D7106.seSeason, D7106.cdSeason)

            txt_cdSeason.Data = D7171.BasicName
            txt_cdSeason.Code = D7106.cdSeason

            'txt_cdTrackingCode.Data = "001"

            'If READ_PFK7171(ListCode("TrackingCode"), cdSubProcess) Then
            '    txt_cdTrackingCode.Data = D7171.BasicName
            '    txt_cdTrackingCode.Code = D7171.BasicCode
            'End If

            Me.ShowDialog()

        End If
    End Function
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)

        Me.KeyPreview = True

        Call FORM_INIT()
        Call DATA_INIT()
        Call DATA_SEARCH_VS1()
    End Sub
    Private Sub PFP17811_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
    End Sub

    Private Sub DATA_INIT()
      
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

        If txt_cdTrackingCode.Code = "" Then MsgBoxEx("Tracking Code !") : Exit Function
        If READ_PFK4010_SLNO_SEASON(txt_cdSeason.Code, txt_SlNoD.Data) = False Then MsgBoxEx("Seal Wrong Code !") : Exit Function

        DS1 = PrcDS("USP_PFP40751_SEARCH_VS1_" & txt_cdTrackingCode.Code, cn, txt_cdTrackingCode.Code,
                                                txt_cdSeason.Code,
                                                txt_SlNoD.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_SET(Vs1, , , , OperationMode.SingleSelect)
            SPR_PRO(Vs1, DS1, "USP_PFP40751_SEARCH_VS1_" & txt_cdTrackingCode.Code, "Vs1", True)
            Vs1.Enabled = True
            Exit Function
        End If
        SPR_SET(Vs1, , , , OperationMode.SingleSelect)
        SPR_PRO(Vs1, DS1, "USP_PFP40751_SEARCH_VS1_" & txt_cdTrackingCode.Code, "Vs1", True)

        If txt_cdTrackingCode.Code = "015" Then
            Call VsSizeRangeNew(Vs1, "USP_VS_SIZERANGE_JOBBASE", "SizeQty01", D4010.JobCard)
        End If
        DATA_SEARCH_VS1 = True

        Vs1.Enabled = True


    End Function

    Private Function LINE_MOVE_DISPLAY01() As Boolean
        Vs1.Enabled = False

        LINE_MOVE_DISPLAY01 = False

        DS1 = PrcDS("USP_PFP40751_SEARCH_VS1_LINE", cn, getData(Vs1, getColumIndex(Vs1, "KEY_ProdDate"), Vs1.ActiveSheet.ActiveRowIndex),
                                        getData(Vs1, getColumIndex(Vs1, "KEY_ProdSeq"), Vs1.ActiveSheet.ActiveRowIndex))
        If GetDsRc(DS1) = 0 Then
            Vs1.Enabled = True
            Exit Function
        End If
        READ_SPREAD(Vs1, DS1, "USP_PFP40751_SEARCH_VS1", "Vs1", Vs1.ActiveSheet.ActiveRowIndex)
        LINE_MOVE_DISPLAY01 = True

        Vs1.Enabled = True
    End Function

#End Region

#Region "Event"
    Private Sub tst_1_Click(sender As Object, e As EventArgs) Handles tst_1.Click, tst_2.Click, tst_3.Click, tst_4.Click, tst_5.Click, tst_6.Click
        If sender.Equals(tst_1) Then
            MAIN_JOB01()
        End If
        If sender.Equals(tst_2) Then
            MAIN_JOB02()
        End If
        If sender.Equals(tst_3) Then
            MAIN_JOB03()
        End If
        If sender.Equals(tst_4) Then
            MAIN_JOB04()
        End If
        If sender.Equals(tst_5) Then
            MAIN_JOB05()
        End If
    End Sub

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

    Private Sub Vs1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown

        If e.KeyCode = Keys.Enter And txt_cdTrackingCode.Code = "100" Then

            Dim cdSubProcess, Chkvalue As String

            cdSubProcess = getData(Vs1, getColumIndex(Vs1, "KEY_cdSubProcess"), Vs1.ActiveSheet.ActiveRowIndex)
            Chkvalue = getDataM(Vs1, getColumIndex(Vs1, "CheckJCStatus"), Vs1.ActiveSheet.ActiveRowIndex)

            If cdSubProcess <> "" Then

                If CheckPassword = False Then
                    If MsgBoxPPW("Please type the password to modify!", "753") = False Then Exit Sub
                    CheckPassword = True
                End If

                Call PrcExeNoError("USP_PFK4018_CLOSSING_JOBCARD", cn, cdSubProcess, txt_cdSeason.Code, txt_SlNoD.Data, Pub.SAW, Chkvalue)
                Call DATA_SEARCH_VS1()
            End If

        End If

        If e.KeyCode = Keys.Enter And txt_cdTrackingCode.Code = "101" Then

            Dim cdSubProcess, Chkvalue As String

            cdSubProcess = getData(Vs1, getColumIndex(Vs1, "KEY_cdSubProcess"), Vs1.ActiveSheet.ActiveRowIndex)
            Chkvalue = getDataM(Vs1, getColumIndex(Vs1, "CheckJCStatus"), Vs1.ActiveSheet.ActiveRowIndex)

            If cdSubProcess <> "" Then

                If CheckPassword = False Then
                    If MsgBoxPPW("Please type the password to modify!", "753") = False Then Exit Sub
                    CheckPassword = True
                End If

                Call PrcExeNoError("USP_PFK4019_CLOSSING_JOBCARD", cn, cdSubProcess, txt_cdSeason.Code, txt_SlNoD.Data, Pub.SAW, Chkvalue)
                Call DATA_SEARCH_VS1()
            End If

        End If

        If e.KeyCode = Keys.Delete Then
            If txt_cdTrackingCode.Code = "001" Or txt_cdTrackingCode.Code = "002" Or txt_cdTrackingCode.Code = "003" Then

                If CheckPassword = False Then
                    If MsgBoxPPW("Please type the password to modify!", "753") = False Then Exit Sub
                    CheckPassword = True
                End If


                If READ_PFK4075_BatchNo(getData(Vs1, getColumIndex(Vs1, "BatchNo"), Vs1.ActiveSheet.ActiveRowIndex)) Then
                    If READ_PFK4090_BATCHNO(D4075.BatchNo) Then
                        MsgBoxP("Production Already !") : Exit Sub

                    End If

                    If D4075.DatePrint <> "" Then
                        Msg_Result = MsgBox("Printed ! Do you want to delete ?", vbYesNo)
                        If Msg_Result = MsgBoxResult.No Then Exit Sub

                    End If

                    If DELETE_PFK4075(D4075) = False Then
                        SQL = " DELETE FROM PFK4075 "
                        SQL = SQL & " WHERE K4075_BatchNo		 = '" & D4075.BatchNo & "' "


                        cmd = New SqlClient.SqlCommand(SQL, cn)
                        cmd.ExecuteNonQuery()

                        D9700_CLEAR()
                        D9700.ActionName = wJOB & Me.Name
                        D9700.DateCreate = Pub.DAT
                        D9700.UserCode = Pub.SAW
                        D9700.FormName = Me.FindForm.Name
                        D9700.Reference = D4075.BatchNo

                        D9700.DeviceName = R9700.DeviceName
                        D9700.MACAddress = R9700.MACAddress
                        D9700.IPv4Address = R9700.IPv4Address
                        D9700.DHCPServer = R9700.DHCPServer
                        D9700.IPWan = R9700.IPWan

                        D9700.DNSdomain = R9700.DNSdomain
                        D9700.DHCPServer = R9700.DHCPServer

                        D9700.HDDSerialNo = R9700.HDDSerialNo
                        D9700.ComputerName = R9700.ComputerName
                        D9700.AccountWin = R9700.AccountWin

                        D9700.UserCode = Pub.SAW
                        D9700.DateTimeCreate = System_Date_time()

                        Call WRITE_PFK9700(D9700)

                        Call SPR_DEL(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex)
                    End If

                End If
            End If
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If txt_cdTrackingCode.Code = "005" Then

                If CheckPassword = False Then
                    If MsgBoxPPW("Please type the password to modify!", "753") = False Then Exit Sub
                    CheckPassword = True
                End If


                If READ_PFK4175_BatchNo(getData(Vs1, getColumIndex(Vs1, "BatchGroup"), Vs1.ActiveSheet.ActiveRowIndex)) Then
                    If READ_PFK4367_BatchGroup(D4175.BatchGroup) Then
                        MsgBoxP("Production Already !") : Exit Sub

                    End If

                    If D4175.DatePrint <> "" Then
                        Msg_Result = MsgBox("Printed ! Do you want to delete ?", vbYesNo)
                        If Msg_Result = MsgBoxResult.No Then Exit Sub

                    End If

                    If DELETE_PFK4175_ZZZ(D4175) Then

                        D9700_CLEAR()
                        D9700.ActionName = wJOB & Me.Name
                        D9700.DateCreate = Pub.DAT
                        D9700.UserCode = Pub.SAW
                        D9700.FormName = Me.FindForm.Name
                        D9700.Reference = D4175.BatchGroup

                        D9700.DeviceName = R9700.DeviceName
                        D9700.MACAddress = R9700.MACAddress
                        D9700.IPv4Address = R9700.IPv4Address
                        D9700.DHCPServer = R9700.DHCPServer
                        D9700.IPWan = R9700.IPWan

                        D9700.DNSdomain = R9700.DNSdomain
                        D9700.DHCPServer = R9700.DHCPServer

                        D9700.HDDSerialNo = R9700.HDDSerialNo
                        D9700.ComputerName = R9700.ComputerName
                        D9700.AccountWin = R9700.AccountWin

                        D9700.UserCode = Pub.SAW
                        D9700.DateTimeCreate = System_Date_time()

                        Call WRITE_PFK9700(D9700)

                        Call cmd_SEARCH.PerformClick()
                    End If

                End If
            End If
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If txt_cdTrackingCode.Code = "006" Then

                If CheckPassword = False Then
                    If MsgBoxPPW("Please type the password to modify!", "753") = False Then Exit Sub
                    CheckPassword = True
                End If


                If READ_PFK4075_BatchNo(getData(Vs1, getColumIndex(Vs1, "BatchNo"), Vs1.ActiveSheet.ActiveRowIndex)) Then
                    If READ_PFK4090_BATCHNO(D4075.BatchNo) Then
                        MsgBoxP("Production Already !") : Exit Sub

                    End If

                    If D4075.DatePrint <> "" Then
                        Msg_Result = MsgBox("Printed ! Do you want to delete ?", vbYesNo)
                        If Msg_Result = MsgBoxResult.No Then Exit Sub

                    End If

                    If DELETE_PFK4075(D4075) = False Then
                        SQL = " DELETE FROM PFK4075 "
                        SQL = SQL & " WHERE K4075_BatchNo		 = '" & D4075.BatchNo & "' "


                        cmd = New SqlClient.SqlCommand(SQL, cn)
                        cmd.ExecuteNonQuery()

                        D9700_CLEAR()
                        D9700.ActionName = wJOB & Me.Name
                        D9700.DateCreate = Pub.DAT
                        D9700.UserCode = Pub.SAW
                        D9700.FormName = Me.FindForm.Name
                        D9700.Reference = D4075.BatchNo

                        D9700.DeviceName = R9700.DeviceName
                        D9700.MACAddress = R9700.MACAddress
                        D9700.IPv4Address = R9700.IPv4Address
                        D9700.DHCPServer = R9700.DHCPServer
                        D9700.IPWan = R9700.IPWan

                        D9700.DNSdomain = R9700.DNSdomain
                        D9700.DHCPServer = R9700.DHCPServer

                        D9700.HDDSerialNo = R9700.HDDSerialNo
                        D9700.ComputerName = R9700.ComputerName
                        D9700.AccountWin = R9700.AccountWin

                        D9700.UserCode = Pub.SAW
                        D9700.DateTimeCreate = System_Date_time()

                        Call WRITE_PFK9700(D9700)

                        Call SPR_DEL(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex)
                    End If
                End If
            End If
        End If



    End Sub


#End Region



End Class