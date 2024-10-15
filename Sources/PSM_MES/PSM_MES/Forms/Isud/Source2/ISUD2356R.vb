Public Class ISUD2356R

#Region "Variable"
    Private wJOB As Integer

    Private W2356 As New T2356_AREA
    Private L2356 As New T2356_AREA

    Private W3421 As New T3421_AREA
    Private W3422 As New T3422_AREA

    Private W3141 As New T3141_AREA
    Private W3142 As New T3142_AREA


    Private WRITE_CHK As String

    Private formA As Boolean
    Private CHK(0 To 5) As String

    Private _cdDepartment As String
    Private _cdLineProd As String
    Private _cdSubProcess As String

    Private _JobCardWorking As String

#End Region

#Region "Form"
    Public Function Link_ISUD2356R(job As Integer, JobCardWorking As String, cdSubProcess As String, cdDepartment As String, cdLineProd As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG

        _JobCardWorking = JobCardWorking
        _cdSubProcess = cdSubProcess
        _cdDepartment = cdDepartment
        _cdLineProd = cdLineProd


        txt_JobCardWorking.Code = JobCardWorking
        txt_JobCardWorking.Data = JobCardWorking

        wJOB = job
        Link_ISUD2356R = False

        Try

            Select Case job
                Case 1

                Case Else
                    txt_JobCardWorking.Enabled = False
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD2356R = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Replacement PROCESSING"))
        End Try

    End Function

    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        Control.CheckForIllegalCrossThreadCalls = False
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        Me.Form_KeyDown()

        Call DATA_INIT()

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

                Me.Show()

                Call KEY_COUNT()
                Call KEY_COUNT_SNO()

                Call DATA_SEARCH_VS1_INSERT()

                Application.DoEvents()

                txt_DateOutBoundMaterial.Data = Pub.DAT
                txt_DateOutBoundMaterial.Code = Pub.DAT

                cmd_DEL.Visible = False


                cmd_OK.Visible = True
            Case 2
                Me.Text = Me.Text & " - SEARCH"

                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH_HEAD_INSERT()
                Call DATA_SEARCH_VS1()

                cmd_DEL.Visible = False
                cmd_OK.Visible = False
            Case 3
                Me.Text = Me.Text & " - UPDATE"

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
                        Call MsgBoxP("Only Search !") : cmd_OK.Visible = False
                    End If
                End If

                If DATA_SEARCH_HEAD_INSERT() = True Then

                    Call KEY_COUNT_SNO()
                    Call DATA_SEARCH_VS1()

                    txt_JobCardWorking.Enabled = True
                End If

                cmd_OK.Visible = True
                cmd_DEL.Visible = True
            Case 4
                Me.Text = Me.Text & " - DELETE"

                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH_HEAD_INSERT()
                Call DATA_SEARCH_VS1()

                cmd_DEL.Visible = True

                cmd_OK.Visible = False
            Case 11
                Me.Text = Me.Text & " - INTERFACE"

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
                        Call MsgBoxP("Only Search !") : cmd_OK.Visible = False
                    End If
                End If

                txt_DateOutBoundMaterial.Data = FSDate(System_Date_8())
                txt_DateOutBoundMaterial.Code = System_Date_8()

                If DATA_SEARCH_HEAD_INSERT() = True Then
                    Call DATA_SEARCH_VS1()

                    Call KEY_COUNT()
                    Call KEY_COUNT_SNO()

                    txt_JobCardWorking.TextEnabled = True
                    txt_JobCardWorking.Enabled = True

                End If
                cmd_OK.Visible = False
                cmd_DEL.Visible = False

        End Select

        txt_JobCardWorking.Enabled = False

        If txt_JobCardWorking.Data = "" Then txt_JobCardWorking.Enabled = True
        formA = True
    End Sub

#End Region

#Region "Search"

    Private Function DATA_SEARCH_HEAD_INSERT() As Boolean
        DATA_SEARCH_HEAD_INSERT = False
        DATA_SEARCH_HEAD_INSERT = True
        Exit Function

        Try
            Select Case L2356.CheckOutBoundMaterial
                Case "1"
                    DS1 = PrcDS("USP_ISUD2356R_SEARCH_HEAD_MaterialInSide", cn, L2356.FactOrderNo, L2356.FactOrderSeq)

                Case "2"
                    DS1 = PrcDS("USP_ISUD2356R_SEARCH_HEAD_MaterialSales", cn, L2356.FactOrderNo, L2356.FactOrderSeq)

                Case "3"
                    DS1 = PrcDS("USP_ISUD2356R_SEARCH_HEAD_MaterialTrash", cn, L2356.FactOrderNo, L2356.FactOrderSeq)

                Case "4"
                    DS1 = PrcDS("USP_ISUD2356R_SEARCH_HEAD_Balance", cn, L2356.FactOrderNo, L2356.FactOrderSeq)

                Case "5"
                    DS1 = PrcDS("USP_ISUD2356R_SEARCH_HEAD_ReturnOut", cn, L2356.FactOrderNo, L2356.FactOrderSeq)

                Case "7"
                    DS1 = PrcDS("USP_ISUD2356R_SEARCH_HEAD_ReturnPurchasing", cn, L2356.FactOrderNo, L2356.FactOrderSeq)

                Case Else
                    DS1 = PrcDS("USP_ISUD2356R_SEARCH_HEAD_MaterialInSide", cn, L2356.FactOrderNo, L2356.FactOrderSeq)


            End Select
            If GetDsRc(DS1) = 0 Then
                Call MsgBoxP("No data !")
                Exit Function
            End If

            Call STORE_MOVE(Me, DS1)

            L2356.JobCardType = GetDsData(DS1, 0, "JobCardType")
            L2356.JobCardWorking = GetDsData(DS1, 0, "JobCardWorking")
            L2356.JobCardWorkingSeq = GetDsData(DS1, 0, "JobCardWorkingSeq")

            DATA_SEARCH_HEAD_INSERT = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_HEAD_INSERT")
        End Try

    End Function

    Private Function DATA_SEARCH_HEAD_MaterialFullNo() As Boolean
        DATA_SEARCH_HEAD_MaterialFullNo = False

        Try
            Select Case L2356.CheckOutBoundMaterial
                Case "1", "2", "3", "4"
                    DS1 = PrcDS("USP_ISUD2356R_SEARCH_HEAD_MaterialFullNo", cn, L2356.MaterialInBoundNo, L2356.MaterialInBoundSeq, L2356.MaterialInBoundSno)
                  End Select

            If GetDsRc(DS1) = 0 Then
                Exit Function
            End If

            DATA_SEARCH_HEAD_MaterialFullNo = True

            StoreFormat(Me)
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_HEAD")
        End Try

    End Function

    Private Function DATA_SEARCH_VS1_INSERT(Optional xrow As Integer = 0) As Boolean
        DATA_SEARCH_VS1_INSERT = False

    End Function
    Private Function DATA_SEARCH_VS1_INSERT() As Boolean
        DATA_SEARCH_VS1_INSERT = False

        Try

            If READ_PFK2356_JobCardWorking(_JobCardWorking) Then
                If READ_PFK3422(D2356.FactOrderNo, D2356.FactOrderSeq) Then
                    txt_cdDepartment.Code = D3422.cdDepartment
                    txt_cdLineProd.Code = D3422.cdLineProd
                    txt_cdSubProcess.Code = D3422.cdSubProcess

                    If READ_PFK7171(ListCode("Department"), D3422.cdDepartment) Then
                        txt_cdDepartment.Data = D7171.BasicName
                    End If

                    If READ_PFK7171(ListCode("LineProd"), D3422.cdLineProd) Then
                        txt_cdLineProd.Data = D7171.BasicName
                    End If

                    If READ_PFK7171(ListCode("SubProcess"), D3422.cdSubProcess) Then
                        txt_cdSubProcess.Data = D7171.BasicName
                    End If

                End If


                DS1 = PrcDS("USP_ISUD2356R_SEARCH_VS1_INSERT", cn, _JobCardWorking)

                If GetDsRc(DS1) = 0 Then
                    SPR_PRO(vS1, DS1, "USP_ISUD2356R_SEARCH_VS1_INSERT", "vS1")

                    vS1.ActiveSheet.RowCount = 1
                    vS1.Enabled = True

                    Exit Function
                End If

                SPR_PRO(vS1, DS1, "USP_ISUD2356R_SEARCH_VS1_INSERT", "Vs1")

                DATA_SEARCH_VS1_INSERT = True

            End If
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try
    End Function
    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False

        Try
            DS1 = PrcDS("USP_ISUD2356R_SEARCH_VS1", cn, _JobCardWorking, _cdSubProcess, _cdDepartment, _cdLineProd)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO(vS1, DS1, "USP_ISUD2356R_SEARCH_VS1", "vS1")

                vS1.ActiveSheet.RowCount = 1
                vS1.Enabled = True

                Exit Function
            End If

            SPR_PRO(vS1, DS1, "USP_ISUD2356R_SEARCH_VS1", "Vs1")

            DATA_SEARCH_VS1 = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try
    End Function
    Private Function DATA_SEARCH_VS1_LINE() As Boolean
        DATA_SEARCH_VS1_LINE = False

        Try
            DS1 = PrcDS("USP_ISUD2356R_SEARCH_VS1_LINE", cn, L2356.DateOutBoundMaterial, _
                                                             L2356.SeqOutBoundMaterial, _
                                                             L2356.SnoOutBoundMaterial)

            If GetDsRc(DS1) = 0 Then
                SPR_SET(vS1, , , , OperationMode.Normal)
                SPR_PRO(vS1, DS1, "USP_ISUD2356R_SEARCH_VS1", "vS1")
                Exit Function
            End If

            Call READ_SPREAD(vS1, DS1, "USP_ISUD2356R_SEARCH_VS1", "Vs1", vS1.ActiveSheet.RowCount - 1)

            DATA_SEARCH_VS1_LINE = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try
    End Function


#End Region

#Region "Function"

    Private Sub DATA_INIT()
        Try
            txt_DateOutBoundMaterial.Data = FSDate(L2356.DateOutBoundMaterial)
            txt_DateOutBoundMaterial.Code = FormatCut(L2356.DateOutBoundMaterial)
            txt_SeqOutBoundMaterial.Data = L2356.SeqOutBoundMaterial

            txt_FactOrderNo.Data = L2356.FactOrderNo
            txt_FactOrderSeq.Data = L2356.FactOrderSeq

            Call CheckOutBoundMaterial(L2356.CheckOutBoundMaterial)

            If READ_PFK7411(Pub.SAW) Then
                txt_InchargeReceipt.Data = D7411.Name
                txt_InchargeReceipt.Code = D7411.IDNO
            End If

            vS1.InsChk = False
            RemoveHandler txt_JobCardWorking.PeaceTextbox1.KeyDown, AddressOf standard_KeyDown
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Sub KEY_COUNT_SNO()

        Try
            SQL = "SELECT MAX(CAST(K2356_SnoOutBoundMaterial AS DECIMAL)) AS MAX_MCODE FROM PFK2356 "
            SQL = SQL & " WHERE K2356_DateOutBoundMaterial          = '" & L2356.DateOutBoundMaterial & "' "
            SQL = SQL & " AND   K2356_SeqOutBoundMaterial           = '" & L2356.SeqOutBoundMaterial & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W2356.SnoOutBoundMaterial = "1"
            Else
                W2356.SnoOutBoundMaterial = CIntp(rd!MAX_MCODE + 1)
            End If

            rd.Close()

            W2356.DateOutBoundMaterial = L2356.DateOutBoundMaterial
            W2356.SeqOutBoundMaterial = L2356.SeqOutBoundMaterial

            txt_DateOutBoundMaterial.Data = W2356.DateOutBoundMaterial
            txt_SeqOutBoundMaterial.Data = W2356.SeqOutBoundMaterial
            txt_SnoOutBoundMaterial.Data = W2356.SnoOutBoundMaterial

            L2356.SnoOutBoundMaterial = W2356.SnoOutBoundMaterial
        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT_SNO")
        End Try
    End Sub
    Private Sub CheckOutBoundMaterial(Process As String)
        Select Case Process
            Case "1" : rad_CheckOutSide1.Checked = True : L2356.CheckOutBoundMaterial = "1"
            Case "2" : rad_CheckOutSide2.Checked = True : L2356.CheckOutBoundMaterial = "2"
            Case "3" : rad_CheckOutSide3.Checked = True : L2356.CheckOutBoundMaterial = "3"
            Case "4" : rad_CheckOutSide4.Checked = True : L2356.CheckOutBoundMaterial = "4"

            Case "5" : rad_CheckOutSide5.Checked = True : L2356.CheckOutBoundMaterial = "5"
            Case "6" : rad_CheckOutSide6.Checked = True : L2356.CheckOutBoundMaterial = "6"
            Case Else : rad_CheckOutSide1.Checked = True : L2356.CheckOutBoundMaterial = "1"
        End Select

        Pan_Process.Enabled = False
    End Sub
    Private Function Check_OutBound() As String

        Check_OutBound = "1"

        If rad_CheckOutSide1.Checked = True Then Check_OutBound = "1" : L2356.CheckOutBoundMaterial = "1"
        If rad_CheckOutSide2.Checked = True Then Check_OutBound = "2" : L2356.CheckOutBoundMaterial = "2"
        If rad_CheckOutSide3.Checked = True Then Check_OutBound = "3" : L2356.CheckOutBoundMaterial = "3"
        If rad_CheckOutSide4.Checked = True Then Check_OutBound = "4" : L2356.CheckOutBoundMaterial = "4"
        If rad_CheckOutSide5.Checked = True Then Check_OutBound = "5" : L2356.CheckOutBoundMaterial = "5"
        If rad_CheckOutSide6.Checked = True Then Check_OutBound = "6" : L2356.CheckOutBoundMaterial = "6"

        Return Check_OutBound
    End Function

#End Region

#Region "Event"



    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        If WRITE_CHK = "*" Then
            isudCHK = True
        Else
            isudCHK = False
        End If

        Me.Dispose()
    End Sub

    Private Sub vS1_CellClick(sender As Object, e As CellClickEventArgs) Handles vS1.CellClick
        If e.ColumnHeader = True Then Exit Sub
        Dim xCOL As Integer
        Dim xROW As Integer

        Try
            xCOL = vS1.ActiveSheet.ActiveColumnIndex
            xROW = vS1.ActiveSheet.ActiveRowIndex

            'If getData(vS1, getColumIndex(vS1, "KEY_DateOutBoundMaterial"), xROW) <> "" Then

            '    L2356.CheckInBoundMaterial = getData(vS1, getColumIndex(vS1, "KEY_CheckInBoundMaterial"), xROW)
            '    L2356.DateOutBoundMaterial = FormatCut(getData(vS1, getColumIndex(vS1, "KEY_DateOutBoundMaterial"), xROW))
            '    L2356.SeqOutBoundMaterial = getData(vS1, getColumIndex(vS1, "KEY_SeqOutBoundMaterial"), xROW)
            '    L2356.SnoOutBoundMaterial = getData(vS1, getColumIndex(vS1, "KEY_SnoOutBoundMaterial"), xROW)

            '    L2356.JobCardWorking = getData(vS1, getColumIndex(vS1, "KEY_JobCardWorking"), xROW)
            '    L2356.JobCardWorkingSeq = getData(vS1, getColumIndex(vS1, "KEY_JobCardWorkingSeq"), xROW)

            '    txt_JobCardWorking.Data = getData(vS1, getColumIndex(vS1, "JobCardWorking"), xROW)

            '    txt_DateOutBoundMaterial.Data = FormatCut(getData(vS1, getColumIndex(vS1, "KEY_DateOutBoundMaterial"), xROW))
            '    txt_DateOutBoundMaterial.Code = FormatCut(getData(vS1, getColumIndex(vS1, "KEY_DateOutBoundMaterial"), xROW))

            '    txt_SnoOutBoundMaterial.Data = getData(vS1, getColumIndex(vS1, "KEY_SeqOutBoundMaterial"), xROW)
            '    txt_SnoOutBoundMaterial.Data = getData(vS1, getColumIndex(vS1, "KEY_SnoOutBoundMaterial"), xROW)

            '    txt_FactOrderNo.Data = getData(vS1, getColumIndex(vS1, "KEY_FactOrderNo"), xROW)
            '    txt_FactOrderSeq.Data = getData(vS1, getColumIndex(vS1, "KEY_FactOrderSeq"), xROW)

            'End If

        Catch ex As Exception
            MsgBoxP("vS1_CellClick")
        End Try
    End Sub

    Private Function Data_Check() As Boolean
        Data_Check = False
        Dim DateOutBoundMaterial As String
        Dim SeqOutBoundMaterial As String
        Dim SnoOutBoundMaterial As String
        Dim xrow As Integer

        Try
            For xrow = 0 To vS1.ActiveSheet.RowCount - 1
                If getDataM(vS1, getColumIndex(vS1, "DCHK"), xrow) = "1" Then
                    GoTo next1
                End If

            Next
            Call MsgBoxP("Chưa click chọn ! No select line !") : Exit Function

next1:
            For xrow = 0 To vS1.ActiveSheet.RowCount - 1
                DateOutBoundMaterial = getData(vS1, getColumIndex(vS1, "KEY_DateOutBoundMaterial"), xrow)
                SeqOutBoundMaterial = getData(vS1, getColumIndex(vS1, "KEY_SeqOutBoundMaterial"), xrow)
                SnoOutBoundMaterial = getData(vS1, getColumIndex(vS1, "KEY_SnoOutBoundMaterial"), xrow)

                If getDataM(vS1, getColumIndex(vS1, "DCHK"), xrow) = "1" Then
                    If READ_PFK2356(DateOutBoundMaterial, SeqOutBoundMaterial, SnoOutBoundMaterial) Then
                        If CIntp(D2356.JobCardWorking) > 0 Then

                            MsgBoxP("Already Receipt Note!")
                            Exit Function

                        End If

                    End If
                End If

            Next

            Data_Check = True

        Catch ex As Exception

        End Try


    End Function
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Dim AUTOKEY As String
     
        Dim xrow As Integer


        If READ_PFK2356_JobCardWorking(_JobCardWorking) Then
            If READ_PFK3422(D2356.FactOrderNo, D2356.FactOrderSeq) Then
                If txt_cdDepartment.Code <> D3422.cdDepartment Then MsgBoxP("Khác bộ phận!") : GoTo next1
                If txt_cdLineProd.Code <> D3422.cdLineProd Then MsgBoxP("Khác chuyền!") : GoTo next1
                If txt_cdSubProcess.Code <> D3422.cdSubProcess Then MsgBoxP("Khác khu sản xuất!") : GoTo next1
            End If
        End If

        GoTo next2
next1:
        Msg_Result = MsgBox("Phiếu nhập khác so với thông tin bao đầu. Tiếp tục(yes), không (no) ? ", vbYesNo)

        If Msg_Result <> vbYes Then Exit Sub

next2:
        If Data_Check() = False Then Exit Sub


        For xrow = 0 To vS1.ActiveSheet.RowCount - 1
            AUTOKEY = getData(vS1, getColumIndex(vS1, "KEY_AUTOKEY"), xrow)

            If getDataM(vS1, getColumIndex(vS1, "DCHK"), xrow) = "1" Then
                If READ_PFK2367(AUTOKEY) Then
                    If CIntp(D2367.QtyReceipt) = 0 Then
                        D2367.DateRecept = Pub.DAT
                        D2367.InchargeReceipt = Pub.SAW
                        D2367.QtyReceipt = CDecp(getData(vS1, getColumIndex(vS1, "QtyReceipt"), xrow))

                        D2367.cdDepartment = txt_cdDepartment.Code
                        D2367.cdLineProd = txt_cdLineProd.Code
                        D2367.cdSubProcess = txt_cdSubProcess.Code

                        D2367.TimeReceipt = System_Date_time()

                        setData(vS1, getColumIndex(vS1, "DateRecept"), xrow, D2367.DateRecept)
                        If REWRITE_PFK2367(D2367) Then
                            isudCHK = True
                            WRITE_CHK = "*"
                        End If

                    End If

                End If
            End If

        Next

        Call PrcExeNoError("USP_PFK2368A_UPDATE", cn, _JobCardWorking, txt_cdSubProcess.Code, txt_cdDepartment.Code, txt_cdLineProd.Code)
        MsgBoxP("Thành công ! Successully! ", vbInformation)

        Me.Dispose()

    End Sub


    Private Function KEY_COUNT() As String
        Dim YRNO As Integer

        Call SQLSERVER_DATE()
        YRNO = Mid(Pub.DAT, 3, 6)

        KEY_COUNT = ""

        SQL = "SELECT MAX(CAST(right(K2356_JobCardWorking,3) AS DECIMAL)) AS MAX_MCODE FROM PFK2356 "
        SQL = SQL & " WHERE SUBSTRING(K2356_JobCardWorking,1,6) = '" & YRNO.ToString & "' "
        SQL = SQL & " AND   K2356_DateOutBoundMaterial = '" & Pub.DAT & "' "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_MCODE) Then
            KEY_COUNT = YRNO & "001"
        Else
            KEY_COUNT = YRNO & Format(CInt(rd!MAX_MCODE + 1), "000")
        End If


        rd.Close()

    End Function
    Private Sub txt_GreyFullNo_txtTextKeyDown(sender As Object, e As KeyEventArgs) Handles txt_JobCardWorking.txtTextKeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True

            If DATA_SEARCH_VS1_INSERT() Then
                txt_JobCardWorking.Enabled = False
            End If

        End If

    End Sub

#End Region


End Class