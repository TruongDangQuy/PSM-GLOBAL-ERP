Public Class ISUD2356Q

#Region "Variable"
    Private wJOB As Integer

    Private W2366 As New T2366_AREA
    Private L2366 As New T2366_AREA

    Private WRITE_CHK As String

    Private formA As Boolean
    Private CHK(0 To 5) As String

    Private _cdDepartment As String
    Private _cdLineProd As String
    Private _cdSubProcess As String

    Private _JobCardWorking As String
    Private _FactOrderNo As String
    Private _FactOrderSeq As String


    Dim _Autokey As String
    Dim _ProdDate As String
    Dim _ProdSeq As String

#End Region

#Region "Form"
    Public Function Link_ISUD2356Q(job As Integer, JobCardWorking As String, cdSubProcess As String, cdDepartment As String, cdLineProd As String, Autokey As String, ProdDate As String, ProdSeq As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG

        _JobCardWorking = JobCardWorking

        If FormatCut(_JobCardWorking).Length = 9 Then
            _FactOrderNo = FormatCut(_JobCardWorking)
        End If

        If READ_PFK3421(_FactOrderNo) = False And _FactOrderNo <> "" Then MsgBoxEx("Wrong Receipt Sai phiếu !") : Exit Function

        _cdSubProcess = cdSubProcess
        _cdDepartment = cdDepartment
        _cdLineProd = cdLineProd

        _Autokey = Autokey
        _ProdDate = ProdDate
        _ProdSeq = ProdSeq

        txt_JobCardWorking.Code = JobCardWorking
        txt_JobCardWorking.Data = JobCardWorking

        wJOB = job
        Link_ISUD2356Q = False

        Try

            Select Case job
                Case 1

                Case Else
                    txt_JobCardWorking.Enabled = False
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD2356Q = isudCHK

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

                Call DATA_SEARCH_HEAD()
                Call KEY_COUNT()

                Application.DoEvents()

                txt_ProdDate.Data = Pub.DAT
                txt_ProdDate.Code = Pub.DAT

                cmd_DEL.Visible = False
                Setfocus(txt_JobCardWorking)

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

                Call DATA_SEARCH_VS1()

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

                Call DATA_SEARCH_VS1()

                cmd_DEL.Visible = True

                cmd_OK.Visible = False

            Case 5
                Me.Text = Me.Text & " - INSERT"

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Me.Show()

                Call DATA_SEARCH_HEAD()
                Call KEY_COUNT()

                Application.DoEvents()

                txt_ProdDate.Data = Pub.DAT
                txt_ProdDate.Code = Pub.DAT

                cmd_DEL.Visible = False
                Setfocus(txt_JobCardWorking)

                cmd_OK.Visible = True

               DATA_SEARCH_VS1_INSERT

        End Select

        txt_JobCardWorking.Enabled = False

        If txt_JobCardWorking.Data = "" Then txt_JobCardWorking.Enabled = True
        formA = True
    End Sub

#End Region

#Region "Search"

    Private Function DATA_SEARCH_VS1_INSERT() As Boolean
        DATA_SEARCH_VS1_INSERT = False

        Try
            If wJOB = "1" Or wJOB = "5" Then
                If READ_PFK3422_1(_JobCardWorking) Then
                    _cdSubProcess = D3422.cdSubProcess
                    _cdDepartment = D3422.cdDepartment
                    _cdLineProd = D3422.cdLineProd

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

                    DS1 = PrcDS("USP_ISUD2356Q_SEARCH_VS1_INSERT", cn, txt_ProdDate.Code, txt_cdDepartment.Code, txt_cdLineProd.Code, txt_cdSubProcess.Code, Pub.SAW, _JobCardWorking)

                    If GetDsRc(DS1) = 0 Then
                        SPR_PRO(vS1, DS1, "USP_ISUD2356Q_SEARCH_VS1_INSERT", "vS1")

                        vS1.ActiveSheet.RowCount = 1
                        vS1.Enabled = True

                        Exit Function
                    End If

                    SPR_PRO(vS1, DS1, "USP_ISUD2356Q_SEARCH_VS1_INSERT", "Vs1")

                    DATA_SEARCH_VS1_INSERT = True


                Else
                    _JobCardWorking = ""
                End If
            Else

                If READ_PFK7171(ListCode("Department"), _cdDepartment) Then
                    txt_cdDepartment.Code = D7171.BasicCode
                    txt_cdDepartment.Data = D7171.BasicName

                End If

                If READ_PFK7171(ListCode("LineProd"), _cdLineProd) Then
                    txt_cdLineProd.Code = D7171.BasicCode
                    txt_cdLineProd.Data = D7171.BasicName
                End If

                If READ_PFK7171(ListCode("SubProcess"), _cdSubProcess) Then
                    txt_cdSubProcess.Code = D7171.BasicCode
                    txt_cdSubProcess.Data = D7171.BasicName
                End If
            End If

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try
    End Function

    Private Function DATA_SEARCH_HEAD() As Boolean
        DATA_SEARCH_HEAD = False

        Try
            If READ_PFK7171(ListCode("Department"), _cdDepartment) Then
                txt_cdDepartment.Code = D7171.BasicCode
                txt_cdDepartment.Data = D7171.BasicName

            End If

            If READ_PFK7171(ListCode("LineProd"), _cdLineProd) Then
                txt_cdLineProd.Code = D7171.BasicCode
                txt_cdLineProd.Data = D7171.BasicName
            End If

            If READ_PFK7171(ListCode("SubProcess"), _cdSubProcess) Then
                txt_cdSubProcess.Code = D7171.BasicCode
                txt_cdSubProcess.Data = D7171.BasicName
            End If

            DATA_SEARCH_HEAD = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_HEAD")
        End Try
    End Function

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False

        txt_ProdDate.Data = _ProdDate
        txt_ProdSeq.Data = _ProdSeq

        If READ_PFK7171(ListCode("Department"), _cdDepartment) Then
            txt_cdDepartment.Code = D7171.BasicCode
            txt_cdDepartment.Data = D7171.BasicName

        End If

        If READ_PFK7171(ListCode("LineProd"), _cdLineProd) Then
            txt_cdLineProd.Code = D7171.BasicCode
            txt_cdLineProd.Data = D7171.BasicName
        End If

        If READ_PFK7171(ListCode("SubProcess"), _cdSubProcess) Then
            txt_cdSubProcess.Code = D7171.BasicCode
            txt_cdSubProcess.Data = D7171.BasicName
        End If

        Try
            DS1 = PrcDS("USP_ISUD2356Q_SEARCH_VS1", cn, _JobCardWorking, _cdSubProcess, _cdDepartment, _cdLineProd, _ProdDate, _ProdSeq)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO(vS1, DS1, "USP_ISUD2356Q_SEARCH_VS1", "vS1")

                vS1.ActiveSheet.RowCount = 1
                vS1.Enabled = True

                Exit Function
            End If

            SPR_PRO(vS1, DS1, "USP_ISUD2356Q_SEARCH_VS1", "Vs1")

            DATA_SEARCH_VS1 = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try
    End Function


#End Region

#Region "Function"

    Private Sub DATA_INIT()
        Try


            If READ_PFK7411(Pub.SAW) Then
                txt_InchargeReceipt.Data = D7411.Name
                txt_InchargeReceipt.Code = D7411.IDNO
            End If

            txt_ProdDate.Data = System_Date_8()

            vS1.InsChk = False
            RemoveHandler txt_JobCardWorking.PeaceTextbox1.KeyDown, AddressOf standard_KeyDown
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Function KEY_COUNT() As String

        Try
            SQL = "SELECT MAX(CAST(K2366_ProdSeq AS DECIMAL)) AS MAX_MCODE FROM PFK2366 "
            SQL = SQL & " WHERE K2366_ProdDate          = '" & txt_ProdDate.Data & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                txt_ProdSeq.Data = "00001"
            Else
                txt_ProdSeq.Data = Format(CIntp(rd!MAX_MCODE + 1), "00000")
            End If

            rd.Close()
        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
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

    Private Function Data_Check() As Boolean
        Data_Check = False
        Dim FactOrderNo As String
        Dim FactOrderSeq As String

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
                FactOrderNo = getData(vS1, getColumIndex(vS1, "KEY_FactOrderNo"), xrow)
                FactOrderSeq = getData(vS1, getColumIndex(vS1, "KEY_FactOrderSeq"), xrow)

                If getDataM(vS1, getColumIndex(vS1, "DCHK"), xrow) = "1" Then
                    If READ_PFK3422(FactOrderNo, FactOrderSeq) Then
                        If D3422.CheckComplete = "1" Then

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
        Dim KEY_ProdDate As String
        Dim KEY_ProdSeq As String
        Dim KEY_Autokey As Long

        If READ_PFK3421(_JobCardWorking) Then
            If READ_PFK3422_1(_JobCardWorking) Then
                '  If txt_cdDepartment.Code <> D3422.cdDepartment Then MsgBoxP("Khác bộ phận!") : GoTo next1
                '  If txt_cdLineProd.Code <> D3422.cdLineProd Then MsgBoxP("Khác chuyền!") : GoTo next1
                If txt_cdSubProcess.Code <> D3422.cdSubProcess Then MsgBoxP("Khác khu sản xuất!") : GoTo next1
            End If
        End If

        GoTo next2
next1:
        Msg_Result = MsgBox("Phiếu nhập khác so với thông tin bao đầu. Tiếp tục(yes), không (no) ? ", vbYesNo)

        If Msg_Result <> vbYes Then Exit Sub

next2:
        If Data_Check() = False Then Exit Sub

        Call KEY_COUNT()

        Dim DateCheck As Boolean = False

        For xrow = 0 To vS1.ActiveSheet.RowCount - 1
            KEY_ProdDate = getData(vS1, getColumIndex(vS1, "KEY_ProdDate"), xrow)
            KEY_ProdSeq = getData(vS1, getColumIndex(vS1, "KEY_ProdSeq"), xrow)
            KEY_Autokey = getData(vS1, getColumIndex(vS1, "KEY_Autokey"), xrow)

            If getDataM(vS1, getColumIndex(vS1, "DCHK"), xrow) = "1" Then
                If READ_PFK2366(KEY_Autokey, KEY_ProdDate, KEY_ProdSeq) Then
                    If CIntp(D2366.QtyReceipt) > 0 Then

                        If D2366.DateRecept <> Pub.DAT And DateCheck = False Then
                            MsgBoxEx("Khác ngày làm việc !")
                            If MsgBoxPPW("Please type the password to modify!", "756") = False Then Exit Sub
                            DateCheck = True
                        End If

                        D2366.cdDepartment = txt_cdDepartment.Code
                        D2366.cdLineProd = txt_cdLineProd.Code
                        D2366.cdSubProcess = txt_cdSubProcess.Code

                        D2366.QtyReceipt = CDecp(getData(vS1, getColumIndex(vS1, "QtyReceipt"), xrow))
                        If REWRITE_PFK2366(D2366) Then
                            isudCHK = True
                            WRITE_CHK = "*"
                        End If

                    End If

                Else

                    If K2366_MOVE(vS1, xrow, W2366, KEY_Autokey, KEY_ProdDate, KEY_ProdSeq) = False Then

                        W2366.ProdDate = txt_ProdDate.Data
                        W2366.ProdSeq = txt_ProdSeq.Data

                        W2366.cdDepartment = txt_cdDepartment.Code
                        W2366.cdLineProd = txt_cdLineProd.Code
                        W2366.cdSubProcess = txt_cdSubProcess.Code
                        W2366.DateRecept = Pub.DAT
                        W2366.TimeReceipt = System_Date_time()
                        W2366.InchargeReceipt = Pub.SAW

                        W2366.seDepartment = ListCode("Department")
                        W2366.seLineProd = ListCode("LineProd")
                        W2366.seSubProcess = ListCode("SubProcess")
                        W2366.seUnitMaterial = ListCode("UnitMaterial")

                        If WRITE_PFK2366(W2366) Then
                            isudCHK = True
                            WRITE_CHK = "*"
                        End If

                    End If


                End If
            End If

        Next

        MsgBoxP("Thành công ! Successully! ", vbInformation)

        Me.Dispose()

    End Sub

    Private Sub txt_JobCardWorking_txtTextKeyDown(sender As Object, e As KeyEventArgs) Handles txt_JobCardWorking.txtTextKeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True

            _JobCardWorking = FormatCut(txt_JobCardWorking.Data)

            If DATA_SEARCH_VS1_INSERT() Then
                txt_JobCardWorking.Enabled = False
            End If

        End If

    End Sub

    Private Sub cmd_DEL_Click(sender As Object, e As EventArgs) Handles cmd_DEL.Click
        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        If CHK(4) <> "1" Then
            Call MsgBoxP("4", "cmd_DEL_Click")
            Exit Sub
        End If


        Dim AUTOKEY As String

        Dim xrow As Integer
        Dim KEY_ProdDate As String
        Dim KEY_ProdSeq As String
        Dim KEY_Autokey As Long

        For xrow = 0 To vS1.ActiveSheet.RowCount - 1
            KEY_ProdDate = getData(vS1, getColumIndex(vS1, "KEY_ProdDate"), xrow)
            KEY_ProdSeq = getData(vS1, getColumIndex(vS1, "KEY_ProdSeq"), xrow)
            KEY_Autokey = getData(vS1, getColumIndex(vS1, "KEY_Autokey"), xrow)

            If getDataM(vS1, getColumIndex(vS1, "DCHK"), xrow) = "1" Then
                If READ_PFK2366(KEY_Autokey, KEY_ProdDate, KEY_ProdSeq) Then

                    If D2366.DateRecept <> Pub.DAT Then
                        MsgBoxEx("Khác ngày làm việc !") : Exit Sub
                    End If

                    If DELETE_PFK2366(D2366) Then

                        isudCHK = True
                        WRITE_CHK = "*"
                    End If

                End If
            End If

        Next
        Me.Dispose()

    End Sub
#End Region

End Class