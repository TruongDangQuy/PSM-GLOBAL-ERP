Public Class ISUD2356A

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

    Private chk_AutoLink As Boolean = False
    Dim dec_QtyOutbound As Decimal = 0
#End Region

#Region "Form"
    Public Function Link_ISUD2356A(job As Integer, CheckOutBoundMaterial As String, DateOutBoundMaterial As String, SeqOutBoundMaterial As String, _
                                                                            FactOrderNo As String, FactOrderSeq As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG

        DateOutBoundMaterial = FormatCut(DateOutBoundMaterial)

        D2356.CheckOutBoundMaterial = CheckOutBoundMaterial
        D2356.DateOutBoundMaterial = DateOutBoundMaterial
        D2356.SeqOutBoundMaterial = SeqOutBoundMaterial

        D2356.FactOrderNo = FactOrderNo
        D2356.FactOrderSeq = FactOrderSeq

        wJOB = job : L2356 = D2356

        Link_ISUD2356A = False
        Try

            Select Case job
                Case 1

                Case Else
                    txt_Barcode.Enabled = True
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD2356A = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Replacement PROCESSING"))
        End Try

    End Function
   
    Public Function Link_ISUD2356A_AUTO(job As Integer, DateOutBoundMaterial As String, FactOrderNo As String, JobCardWorking As String, JobCardWorkingSeq As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        chk_AutoLink = True
        DateOutBoundMaterial = FormatCut(DateOutBoundMaterial)

        D2356.DateOutBoundMaterial = DateOutBoundMaterial
        D2356.FactOrderNo = FactOrderNo

        D2356.JobCardWorking = JobCardWorking
        D2356.JobCardWorkingSeq = JobCardWorkingSeq

        txt_DateOutBoundMaterial.Data = DateOutBoundMaterial
        txt_FactOrderNo.Data = FactOrderNo
        txt_JobCardWorking.Data = JobCardWorking
        txt_JobCardWorkingSeq.Data = JobCardWorkingSeq

        wJOB = job : L2356 = D2356

        Link_ISUD2356A_AUTO = False
        Try

            Select Case job
                Case 1
                    txt_InchargeWHOutBound.Code = Pub.SAW


                    txt_TimeMaterialOutBound.Data = FSDateTime(System_Date_time())
                    txt_TimeMaterialOutBound.Code = System_Date_time()
                Case Else
                    txt_Barcode.Enabled = True
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD2356A_AUTO = isudCHK

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

                Call DATA_SEARCH_VS0()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_HEAD_INSERT()
                Application.DoEvents()

                txt_DateOutBoundMaterial.Data = Pub.DAT
                txt_DateOutBoundMaterial.Code = Pub.DAT

                cmd_DEL.Visible = False

                Setfocus(txt_CustomerOutBound)

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
                Call DATA_SEARCH_VS0()
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
                    Call DATA_SEARCH_VS0()
                    Call DATA_SEARCH_VS1()

                    txt_Barcode.Enabled = True
                End If

                cmd_OK.Visible = False
                cmd_DEL.Visible = False
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
                Call DATA_SEARCH_VS0()
                Call DATA_SEARCH_VS1()

                cmd_DEL.Visible = True

                cmd_OK.Visible = False
            Case 11
                Me.Text = Me.Text & " - INTERFACE"

                txt_DateOutBoundMaterial.Data = FSDate(System_Date_8())
                txt_DateOutBoundMaterial.Code = System_Date_8()

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
                    Call DATA_SEARCH_VS0()
                    Call DATA_SEARCH_VS1()

                    Call KEY_COUNT()
                    Call KEY_COUNT_SNO()

                    txt_Barcode.TextEnabled = True
                    txt_Barcode.Enabled = True

                End If
                cmd_OK.Visible = False
                cmd_DEL.Visible = False

        End Select

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
                    DS1 = PrcDS("USP_ISUD2356A_SEARCH_HEAD_MaterialInSide", cn, L2356.FactOrderNo, L2356.FactOrderSeq)

                Case "2"
                    DS1 = PrcDS("USP_ISUD2356A_SEARCH_HEAD_MaterialSales", cn, L2356.FactOrderNo, L2356.FactOrderSeq)

                Case "3"
                    DS1 = PrcDS("USP_ISUD2356A_SEARCH_HEAD_MaterialTrash", cn, L2356.FactOrderNo, L2356.FactOrderSeq)

                Case "4"
                    DS1 = PrcDS("USP_ISUD2356A_SEARCH_HEAD_Balance", cn, L2356.FactOrderNo, L2356.FactOrderSeq)

                Case "5"
                    DS1 = PrcDS("USP_ISUD2356A_SEARCH_HEAD_ReturnOut", cn, L2356.FactOrderNo, L2356.FactOrderSeq)

                Case "7"
                    DS1 = PrcDS("USP_ISUD2356A_SEARCH_HEAD_ReturnPurchasing", cn, L2356.FactOrderNo, L2356.FactOrderSeq)

                Case Else
                    DS1 = PrcDS("USP_ISUD2356A_SEARCH_HEAD_MaterialInSide", cn, L2356.FactOrderNo, L2356.FactOrderSeq)


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
                    DS1 = PrcDS("USP_ISUD2356A_SEARCH_HEAD_MaterialFullNo", cn, L2356.MaterialInBoundNo, L2356.MaterialInBoundSeq, L2356.MaterialInBoundSno)
                Case "5", "7"
                    DS1 = PrcDS("USP_ISUD2356A_SEARCH_HEAD_MaterialFullNo_Customer", cn, L2356.MaterialInBoundNo, L2356.MaterialInBoundSeq, L2356.MaterialInBoundSno, txt_CustomerOutBound.Code)
            End Select

            If GetDsRc(DS1) = 0 Then
                Exit Function
            End If

            '       Call STORE_MOVE(Block1, DS1)

            DATA_SEARCH_HEAD_MaterialFullNo = True

            StoreFormat(Me)
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_HEAD")
        End Try

    End Function

    Private Function DATA_SEARCH_VS1_INSERT(Optional xrow As Integer = 0) As Boolean
        DATA_SEARCH_VS1_INSERT = False

        Try
            Call Check_OutBound()

            DS1 = PrcDS("USP_ISUD2356A_SEARCH_VS1_INSERT", cn, L2356.MaterialInBoundNo, _
                                                                  L2356.MaterialInBoundSeq, _
                                                                  L2356.MaterialInBoundSno, _
                                                                  L2356.CheckOutBoundMaterial, _
                                                                  L2356.JobCardType, _
                                                                  L2356.JobCardWorking, _
                                                                  L2356.JobCardWorkingSeq)

            If GetDsRc(DS1) = 0 Then
                vS1.Enabled = True
                Exit Function
            End If

            Call READ_SPREAD(vS1, DS1, "USP_ISUD2356A_SEARCH_VS1", "Vs1", xrow)

            setData(vS1, getColumIndex(vS1, "QtyOutBound"), xrow, GetDsData(DS1, 0, "QtyOutBound"))

            DATA_SEARCH_VS1_INSERT = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1_INSERT")
        End Try
    End Function

    Private Function DATA_SEARCH_VS0() As Boolean
        DATA_SEARCH_VS0 = False

        Try
            DS1 = PrcDS("USP_ISUD2356A_SEARCH_VS0", cn, L2356.FactOrderNo, _
                                                        L2356.JobCardWorking,
                                                        L2356.JobCardWorkingSeq)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO(vS0, DS1, "USP_ISUD2356A_SEARCH_VS0", "VS0")
                vS0.Enabled = True

                Exit Function
            End If

            SPR_PRO(vS0, DS1, "USP_ISUD2356A_SEARCH_VS0", "VS0")

            DATA_SEARCH_VS0 = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try
    End Function

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False

        Try
            DS1 = PrcDS("USP_ISUD2356A_SEARCH_VS1", cn, L2356.DateOutBoundMaterial, _
                                                        L2356.SeqOutBoundMaterial)


            If GetDsRc(DS1) = 0 Then
                SPR_SET(vS1, , , , OperationMode.Normal)
                SPR_PRO(vS1, DS1, "USP_ISUD2356A_SEARCH_VS1", "vS1")

                vS1.ActiveSheet.RowCount = 1
                vS1.Enabled = True

                Exit Function
            End If

            SPR_SET(vS1, , , , OperationMode.Normal)
            SPR_PRO(vS1, DS1, "USP_ISUD2356A_SEARCH_VS1", "Vs1")

            DATA_SEARCH_VS1 = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try
    End Function
    Private Function DATA_SEARCH_VS1_LINE() As Boolean
        DATA_SEARCH_VS1_LINE = False

        Try
            DS1 = PrcDS("USP_ISUD2356A_SEARCH_VS1_LINE", cn, L2356.DateOutBoundMaterial, _
                                                             L2356.SeqOutBoundMaterial, _
                                                             L2356.SnoOutBoundMaterial)

            If GetDsRc(DS1) = 0 Then
                SPR_SET(vS1, , , , OperationMode.Normal)
                SPR_PRO(vS1, DS1, "USP_ISUD2356A_SEARCH_VS1", "vS1")
                Exit Function
            End If

            Call READ_SPREAD(vS1, DS1, "USP_ISUD2356A_SEARCH_VS1", "Vs1", vS1.ActiveSheet.RowCount - 1)

            DATA_SEARCH_VS1_LINE = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try
    End Function


#End Region

#Region "Function"

    Private Function DATA_MOVE_K2356_LINE(xRow As Integer) As Boolean
        DATA_MOVE_K2356_LINE = False

        Try
            Call KEY_COUNT_SNO()

            If K2356_MOVE(vS1, xRow, W2356, L2356.DateOutBoundMaterial, L2356.SeqOutBoundMaterial, L2356.SnoOutBoundMaterial) = False Then

                Call K2356_MOVE(Me, W2356, 3, False, L2356.DateOutBoundMaterial, L2356.SeqOutBoundMaterial, L2356.SnoOutBoundMaterial)

                W2356.CheckOutBoundMaterial = Check_OutBound()
                W2356.PackOutBound = "1"

                W2356.DateOutBoundMaterial = L2356.DateOutBoundMaterial
                W2356.SeqOutBoundMaterial = L2356.SeqOutBoundMaterial
                W2356.SnoOutBoundMaterial = L2356.SnoOutBoundMaterial

                W2356.MaterialInBoundNo = L2356.MaterialInBoundNo
                W2356.MaterialInBoundSeq = L2356.MaterialInBoundSeq
                W2356.MaterialInBoundSno = L2356.MaterialInBoundSno

                W2356.FactOrderNo = L2356.FactOrderNo
                W2356.FactOrderSeq = CDecp(getData(vS0, getColumIndex(vS0, "KEY_FactOrderSeq"), vS0.ActiveSheet.ActiveRowIndex))

                W2356.CustomerOutBoundMaterial = txt_CustomerOutBound.Code

                W2356.TimeMaterialOutBound = System_Date_time()

                W2356.JobCardWorking = L2356.JobCardWorking
                W2356.JobCardWorkingSeq = L2356.JobCardWorkingSeq
                W2356.JobCardType = L2356.JobCardType

                W2356.QtyOutBound = CDecp(getData(vS1, getColumIndex(vS1, "QtyOutBound"), xRow))

                W2356.seDepartment = ListCode("Department")
                W2356.seSite = ListCode("Site")
                W2356.cdDepartment = Pub.DEPARTMENT
                W2356.cdSite = Pub.SITE
                W2356.InchargeOutBoundMaterial = txt_InchargeWHOutBound.Code

                W2356.JobCardWorking = txt_JobCardWorking.Data
                W2356.JobCardWorkingSeq = txt_JobCardWorkingSeq.Data
                W2356.FactOrderNo = txt_FactOrderNo.Data
                'W2356.FactOrderSeq = getFactOrderSeq(W2356.MaterialInBoundNo, W2356.MaterialInBoundSeq)

                If WRITE_PFK2356(W2356) = True Then
                    isudCHK = True
                End If
            Else
                Call K2356_MOVE(Me, W2356, 3, False, L2356.DateOutBoundMaterial, L2356.SeqOutBoundMaterial, L2356.SnoOutBoundMaterial)

                W2356.PackOutBound = "1"
                Call REWRITE_PFK2356(W2356)

                W2356.seDepartment = ListCode("Department")
                W2356.seSite = ListCode("Site")
                W2356.cdDepartment = Pub.DEPARTMENT
                W2356.cdSite = Pub.SITE
                W2356.InchargeOutBoundMaterial = txt_InchargeWHOutBound.Code

            End If

            DATA_MOVE_K2356_LINE = True
        Catch ex As Exception
            MsgBoxP("DATA_MOVE_K2356_LINE!")
        End Try
    End Function

    Private Function DATA_MOVE_K2356_LINE_NEWQTY(xRow As Integer) As Boolean
        DATA_MOVE_K2356_LINE_NEWQTY = False

        Try
            Call KEY_COUNT_SNO()

            If K2356_MOVE(vS1, xRow, W2356, L2356.DateOutBoundMaterial, L2356.SeqOutBoundMaterial, L2356.SnoOutBoundMaterial) = False Then

                Call K2356_MOVE(Me, W2356, 3, False, L2356.DateOutBoundMaterial, L2356.SeqOutBoundMaterial, L2356.SnoOutBoundMaterial)

                W2356.CheckOutBoundMaterial = Check_OutBound()
                W2356.PackOutBound = "1"

                W2356.DateOutBoundMaterial = L2356.DateOutBoundMaterial
                W2356.SeqOutBoundMaterial = L2356.SeqOutBoundMaterial
                W2356.SnoOutBoundMaterial = L2356.SnoOutBoundMaterial

                W2356.MaterialInBoundNo = L2356.MaterialInBoundNo
                W2356.MaterialInBoundSeq = L2356.MaterialInBoundSeq
                W2356.MaterialInBoundSno = L2356.MaterialInBoundSno

                W2356.FactOrderNo = L2356.FactOrderNo
                W2356.FactOrderSeq = L2356.FactOrderSeq

                W2356.CustomerOutBoundMaterial = txt_CustomerOutBound.Code

                W2356.TimeMaterialOutBound = System_Date_time()

                W2356.JobCardWorking = L2356.JobCardWorking
                W2356.JobCardWorkingSeq = L2356.JobCardWorkingSeq
                W2356.JobCardType = L2356.JobCardType

                W2356.QtyOutBound = CDecp(getData(vS1, getColumIndex(vS1, "QtyOutBound"), xRow))

                W2356.seDepartment = ListCode("Department")
                W2356.seSite = ListCode("Site")
                W2356.cdDepartment = Pub.DEPARTMENT
                W2356.cdSite = Pub.SITE
                W2356.InchargeOutBoundMaterial = txt_InchargeWHOutBound.Code

                W2356.JobCardWorking = txt_JobCardWorking.Data
                W2356.JobCardWorkingSeq = txt_JobCardWorkingSeq.Data
                W2356.FactOrderNo = txt_FactOrderNo.Data
                W2356.FactOrderSeq = getFactOrderSeq(W2356.MaterialInBoundNo, W2356.MaterialInBoundSeq)

                W2356.QtyOutBound = dec_QtyOutbound

                If WRITE_PFK2356(W2356) = True Then
                    isudCHK = True
                End If
            Else
                Call K2356_MOVE(Me, W2356, 3, False, L2356.DateOutBoundMaterial, L2356.SeqOutBoundMaterial, L2356.SnoOutBoundMaterial)

                W2356.PackOutBound = "1"
                W2356.QtyOutBound = dec_QtyOutbound

                Call REWRITE_PFK2356(W2356)

                W2356.seDepartment = ListCode("Department")
                W2356.seSite = ListCode("Site")

                W2356.InchargeOutBoundMaterial = txt_InchargeWHOutBound.Code


            End If

            DATA_MOVE_K2356_LINE_NEWQTY = True
        Catch ex As Exception
            MsgBoxP("DATA_MOVE_K2356_LINE!")
        End Try
    End Function
    Private Function getFactOrderSeq(MaterialInBoundNo As String, MaterialInBoundSeq As String) As Integer
        getFactOrderSeq = 0
        Try
            Dim i As Integer

            If READ_PFK2351(MaterialInBoundNo, MaterialInBoundSeq) Then
                For i = 0 To vS0.ActiveSheet.RowCount - 1
                    If D2351.MaterialCode = getData(vS0, getColumIndex(vS0, "MaterialCode"), i) Then
                        Return CIntp(getData(vS0, getColumIndex(vS0, "KEY_FactOrderSeq"), i))

                    End If

                Next
            End If



        Catch ex As Exception

        End Try
    End Function
    Private Sub DATA_DELETE()
        Dim i As Integer

        Try
            For i = 0 To vS1.ActiveSheet.RowCount - 1
                If getDataM(vS1, getColumIndex(vS1, "CheckDsel"), i) = "1" Then
                    DATA_LINE_DELETE(i)
                End If
            Next

            Call DATA_SEARCH_VS1()

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub
    Private Sub DATA_LINE_DELETE(xrow As Integer)
        Try

            If READ_PFK2356(FormatCut(getData(vS1, getColumIndex(vS1, "KEY_DateOutBoundMaterial"), xrow)),
                            getData(vS1, getColumIndex(vS1, "KEY_SeqOutBoundMaterial"), xrow),
                            getData(vS1, getColumIndex(vS1, "KEY_SnoOutBoundMaterial"), xrow)) = True Then
                W2356 = D2356

                If DELETE_PFK2356(W2356) = True Then
                    Call Delete_History("PFK2356", W2356.MaterialInBoundNo & "-" & W2356.MaterialInBoundSeq & "-" & W2356.MaterialInBoundSno.ToString)
                    isudCHK = True
                End If

            End If

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub

    Private Sub DATA_INIT()
        Try
            txt_DateOutBoundMaterial.Data = FSDate(L2356.DateOutBoundMaterial)
            txt_DateOutBoundMaterial.Code = FormatCut(L2356.DateOutBoundMaterial)
            txt_SeqOutBoundMaterial.Data = L2356.SeqOutBoundMaterial

            Call CheckOutBoundMaterial(L2356.CheckOutBoundMaterial)

            If READ_PFK7411(Pub.SAW) Then
                txt_InchargeWHOutBound.Code = D7411.IDNO
                txt_InchargeWHOutBound.Data = D7411.Name
            End If

            vS1.InsChk = False
            Me.WindowState = FormWindowState.Maximized

            RemoveHandler txt_Barcode.PeaceTextbox1.KeyDown, AddressOf standard_KeyDown
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub
    Private Sub KEY_COUNT()

        Dim YRNO As Integer
        YRNO = System_Date_8()

        L2356.DateOutBoundMaterial = YRNO

        Try
            SQL = "SELECT MAX(CAST(ISNULL(K2356_SeqOutBoundMaterial, 0) AS DECIMAL)) AS MAX_MCODE FROM PFK2356 "
            SQL = SQL & " WHERE K2356_DateOutBoundMaterial = '" & YRNO & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W2356.SeqOutBoundMaterial = "001"
            Else
                W2356.SeqOutBoundMaterial = Format(CInt(rd!MAX_MCODE + 1), "000")
            End If

            rd.Close()

            txt_SeqOutBoundMaterial.Data = W2356.SeqOutBoundMaterial
            L2356.SeqOutBoundMaterial = W2356.SeqOutBoundMaterial

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
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

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Dim DS_New As New DataSet

        If txt_InchargeWHOutBound.Code = "" Then MsgBoxP("Incharge?!") : Exit Sub

        Select Case wJOB
            Case 1

                Dim int_x As Integer
                Dim int_LINE As Integer
                Dim dec_SumQty As Decimal
                Dim dec_ReqQty As Decimal
                Dim dec_InQty As Decimal
                Dim dec_OutQty As Decimal

                Call KEY_COUNT()

                For int_x = 0 To vS0.ActiveSheet.RowCount - 1
                    DS_New = PrcDS("EXP_CLOSSING_PFK2356_OUTBOUND_MANUAL_LINE", cn, txt_FactOrderNo.Data, getData(vS0, getColumIndex(vS0, "KEY_FactOrderSeq"), int_x))
                    dec_SumQty = 0

                    If GetDsRc(DS_New) > 0 Then
                        For int_LINE = 0 To GetDsRc(DS_New) - 1
                            dec_ReqQty = CDecp(GetDsData(DS_New, int_LINE, "QtyRequest"))
                            dec_InQty = CDecp(GetDsData(DS_New, int_LINE, "K2352_QtyInBound"))

                            If dec_InQty >= dec_ReqQty And dec_SumQty = 0 Then
                                dec_OutQty = dec_ReqQty
                                dec_QtyOutbound = dec_OutQty
                                txt_Barcode.Data = GetDsData(DS_New, int_LINE, "Barcode")
                                Call txt_GreyFullNo_txtTextKeyDown_NEW()

                                Exit For

                            End If

                            If dec_InQty <= dec_ReqQty And dec_SumQty < dec_ReqQty Then
                                dec_OutQty = dec_InQty
                                dec_QtyOutbound = dec_OutQty

                                txt_Barcode.Data = GetDsData(DS_New, int_LINE, "Barcode")
                                Call txt_GreyFullNo_txtTextKeyDown_NEW()

                                dec_SumQty += dec_OutQty

                            ElseIf dec_SumQty + dec_InQty >= dec_ReqQty Then
                                dec_OutQty = dec_ReqQty - dec_SumQty
                                dec_QtyOutbound = dec_OutQty

                                txt_Barcode.Data = GetDsData(DS_New, int_LINE, "Barcode")
                                Call txt_GreyFullNo_txtTextKeyDown_NEW()
                                Exit For

                            End If


                        Next

                    End If

                Next

                Call DATA_SEARCH_VS0()


            Case 2
                Me.Dispose()
            Case 3
            Case 4
        End Select
    End Sub


    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        If WRITE_CHK = "*" Then
            isudCHK = True
        Else
            isudCHK = False
        End If

        Me.Dispose()
    End Sub

    Private Sub cmd_DEL_Click(sender As Object, e As EventArgs) Handles cmd_DEL.Click
        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        If CHK(4) <> "1" Then
            Call MsgBoxP("4", "cmd_DEL_Click")
            Exit Sub
        End If

        Dim str As String = MsgBoxP("Do you want to delete all roll?", vbYesNo)

        If str <> vbYes Then Exit Sub


        Call DATA_DELETE()
    End Sub

    Private Sub vS1_CellClick(sender As Object, e As CellClickEventArgs) Handles vS1.CellClick
        If e.ColumnHeader = True Then Exit Sub
        Dim xCOL As Integer
        Dim xROW As Integer

        Try
            xCOL = vS1.ActiveSheet.ActiveColumnIndex
            xROW = vS1.ActiveSheet.ActiveRowIndex

            If getData(vS1, getColumIndex(vS1, "KEY_DateOutBoundMaterial"), xROW) <> "" Then

                L2356.CheckInBoundMaterial = getData(vS1, getColumIndex(vS1, "KEY_CheckInBoundMaterial"), xROW)
                L2356.DateOutBoundMaterial = FormatCut(getData(vS1, getColumIndex(vS1, "KEY_DateOutBoundMaterial"), xROW))
                L2356.SeqOutBoundMaterial = getData(vS1, getColumIndex(vS1, "KEY_SeqOutBoundMaterial"), xROW)
                L2356.SnoOutBoundMaterial = getData(vS1, getColumIndex(vS1, "KEY_SnoOutBoundMaterial"), xROW)

                'L2356.JobCardWorking = getData(vS1, getColumIndex(vS1, "KEY_JobCardWorking"), xROW)
                'L2356.JobCardWorkingSeq = getData(vS1, getColumIndex(vS1, "KEY_JobCardWorkingSeq"), xROW)

                txt_Barcode.Data = getData(vS1, getColumIndex(vS1, "RawInBoundFullNo"), xROW)
                txt_Barcode.Code = FormatCut(getData(vS1, getColumIndex(vS1, "RawInBoundFullNo"), xROW))

                txt_CustomerOutBound.Data = getData(vS1, getColumIndex(vS1, "CustomerName"), xROW)
                txt_CustomerOutBound.Code = getData(vS1, getColumIndex(vS1, "CustomerOutBoundMaterial"), xROW)

                txt_InchargeWHOutBound.Code = getData(vS1, getColumIndex(vS1, "InchargeOutBoundMaterial"), xROW)
                txt_InchargeWHOutBound.Data = getData(vS1, getColumIndex(vS1, "InchargeName"), xROW)

                txt_DateOutBoundMaterial.Data = FormatCut(getData(vS1, getColumIndex(vS1, "KEY_DateOutBoundMaterial"), xROW))
                txt_DateOutBoundMaterial.Code = FormatCut(getData(vS1, getColumIndex(vS1, "KEY_DateOutBoundMaterial"), xROW))

                txt_SnoOutBoundMaterial.Data = getData(vS1, getColumIndex(vS1, "KEY_SeqOutBoundMaterial"), xROW)
                txt_SnoOutBoundMaterial.Data = getData(vS1, getColumIndex(vS1, "KEY_SnoOutBoundMaterial"), xROW)

                txt_Barcode.PeaceTextbox1.Enabled = False
            End If

        Catch ex As Exception
            MsgBoxP("vS1_CellClick")
        End Try
    End Sub
    Private Sub vS1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS1.CellDoubleClick
        If e.Column <> getColumIndex(vS1, "QtyOutBound") Then

            If wJOB = "1" Or wJOB = "3" Or wJOB = "11" Then
                txt_Barcode.Data = ""
                txt_SnoOutBoundMaterial.Data = ""

                Call KEY_COUNT_SNO()

                txt_Barcode.Enabled = True
                txt_Barcode.TextEnabled = True

                If getData(vS1, getColumIndex(vS1, "KEY_DateOutBoundMaterial"), vS1.ActiveSheet.RowCount - 1) <> "" Then
                    vS1.ActiveSheet.RowCount += 1
                    vS1.ActiveSheet.ActiveRowIndex = vS1.ActiveSheet.RowCount - 1
                End If

                e.Cancel = True
                vS1.RetainSelectionBlock = True
                Me.Show()
                Application.DoEvents()
                Setfocus(txt_Barcode)
            End If

        End If
    End Sub
    Private Sub Vs1_Change(sender As Object, e As ChangeEventArgs) Handles vS1.Change
        Dim xCOL As Integer
        Dim xROW As Integer

        Try
            xROW = e.Row
            xCOL = e.Column

            vSChange(xROW)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub vSChange(xROW As Integer)
        If wJOB = 2 Then Exit Sub
        Dim QtyOutBound As Integer
        Dim Barcode As String

        If READ_PFK2356(FormatCut(getData(vS1, getColumIndex(vS1, "KEY_DateOutBoundMaterial"), xROW)),
                           getData(vS1, getColumIndex(vS1, "KEY_SeqOutBoundMaterial"), xROW),
                           getData(vS1, getColumIndex(vS1, "KEY_SnoOutBoundMaterial"), xROW)) = True Then
            W2356 = D2356
            W2356.QtyOutBound = CDecp(getData(vS1, getColumIndex(vS1, "QtyOutBound"), xROW))

            Barcode = W2356.DateOutBoundMaterial & W2356.SeqOutBoundMaterial & W2356.SnoOutBoundMaterial.ToString

            SQL = " SELECT SUM(ISNULL(K2356_QtyOutBound,0)) as TotalQtyOutBound FROM PFK2356 "
            SQL = SQL & " WHERE K2356_MaterialInBoundNo		 = '" & W2356.MaterialInBoundNo & "' "
            SQL = SQL & "   AND K2356_MaterialInBoundSeq		 = '" & W2356.MaterialInBoundSeq & "' "
            SQL = SQL & "   AND K2356_MaterialInBoundSno		 =  " & W2356.MaterialInBoundSno & "  "
            SQL = SQL & "   AND (K2356_DateOutBoundMaterial + K2356_SeqOutBoundMaterial +CAST(K2356_SnoOutBoundMaterial AS NVARCHAR(10)) "
            SQL = SQL & " 	 <>  '" & Barcode & "' ) "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows Then
                If IsDBNull(rd!TotalQtyOutBound) Then QtyOutBound = 0 Else QtyOutBound = rd!TotalQtyOutBound
            End If

            rd.Close()

            If READ_PFK2352(W2356.MaterialInBoundNo, W2356.MaterialInBoundSeq, W2356.MaterialInBoundSno) Then
                If (QtyOutBound + W2356.QtyOutBound) > D2352.QtyInBound Then
                    MsgBoxP("Over the qty -" & ((QtyOutBound + W2356.QtyOutBound) - D2352.QtyInBound))

                    setData(vS1, getColumIndex(vS1, "QtyOutBound"), xROW, D2356.QtyOutBound)

                    Exit Sub

                End If
                Call REWRITE_PFK2356(W2356)

            End If

        End If


    End Sub
    Private Sub vS1_KeyDown(sender As Object, e As KeyEventArgs) Handles vS1.KeyDown
        Dim xCol As Long
        Dim xRow As Long

        xCol = vS1.ActiveSheet.ActiveColumnIndex
        xRow = vS1.ActiveSheet.ActiveRowIndex

        Select Case e.KeyCode
            Case Keys.Insert
                If getData(vS1, getColumIndex(vS1, "KEY_DateOutBoundMaterial"), vS1.ActiveSheet.RowCount - 1) <> "" Then
                    vS1.ActiveSheet.RowCount += 1
                    vS1.ActiveSheet.ActiveRowIndex = vS1.ActiveSheet.RowCount - 1
                End If

            Case Keys.Delete
                If getData(vS1, getColumIndex(vS1, "KEY_DateOutBoundMaterial"), xRow) = "" Then
                    Call SPR_DEL(vS1, 0, xRow)
                    Exit Sub
                End If

                Msg_Result = MsgBoxP("Do you want to delete?", vbYesNo)
                If Msg_Result <> vbYes Then Exit Sub

                Call DATA_LINE_DELETE(xRow)
                Call SPR_DEL(vS1, 0, xRow)

                vS1.Focus()

            Case Keys.Enter
                Select Case xCol
                    Case getColumIndex(vS1, "QtyOutBound")
                        Call vSChange(xRow)

                End Select

        End Select


    End Sub

    Private Sub Vs1_ButtonClicked(sender As Object, e As EditorNotifyEventArgs) Handles vS1.ButtonClicked
        Dim xRow As Integer
        Dim xCol As Integer

        xRow = e.Row
        xCol = e.Column

        Select Case xCol
            Case getColumIndex(vS1, "btnCustomerGreyRecall")
                HLPCHECK("btn_Customer")
                If hlp0000SeVaTt = "" Or hlp0000SeVa = "" Then Exit Sub

                setData(vS1, getColumIndex(vS1, "CustomerGreyRecall"), xRow, hlp0000SeVaTt)
                setData(vS1, getColumIndex(vS1, "CustomerGreyRecallName"), xRow, hlp0000SeVa)
                vS1.ActiveSheet.ActiveColumnIndex += 1 : vS1.ActiveSheet.ActiveRowIndex = xRow

                vS1.Focus()
            Case getColumIndex(vS1, "btnInchargeWeavingInspect")
                HLPCHECK("Const_Emp134")
                If hlp0000SeVaTt = "" Or hlp0000SeVa = "" Then Exit Sub

                setData(vS1, getColumIndex(vS1, "InchargeWeavingInspect"), xRow, hlp0000SeVaTt)
                setData(vS1, getColumIndex(vS1, "InchargeWeavingInspectName"), xRow, hlp0000SeVa)
                vS1.ActiveSheet.ActiveColumnIndex += 1 : vS1.ActiveSheet.ActiveRowIndex = xRow

                vS1.Focus()
            Case getColumIndex(vS1, "btnDyeingColor")
                HLPCHECK("Const_DyeingColor")
                If hlp0000SeVaTt = "" Or hlp0000SeVa = "" Then Exit Sub
                setData(vS1, getColumIndex(vS1, "cdDyeingColor"), xRow, hlp0000SeVaTt)
                setData(vS1, getColumIndex(vS1, "cdDyeingColorName"), xRow, hlp0000SeVa)
                vS1.ActiveSheet.ActiveColumnIndex += 1 : vS1.ActiveSheet.ActiveRowIndex = xRow

                vS1.Focus()

        End Select
    End Sub
    Private Sub txt_FactOrderNo_btnTitleClick(sender As Object, e As EventArgs)
        Try
            'LATER
            'Dim tmpCheckGreyType0 As String
            'Dim tmpCheckGreyType1 As String
            'Dim tmpCheckMarketType0 As String
            'Dim tmpCheckMarketType1 As String
            'Dim tmpCheckGreyOutSide0 As String
            'Dim tmpCheckGreyOutSide1 As String
            'Dim tmpCheckGreyOutSide2 As String
            'Dim tmpCheckGreyOutSide3 As String
            'Dim tmpCheckGreyOutSide4 As String

            'tmpCheckGreyType0 = "1"             '1.Normal
            'tmpCheckGreyType1 = "1"             '2.Sample 
            'tmpCheckMarketType0 = "1"           '1.Domestic
            'tmpCheckMarketType1 = "1"           '2.Export

            'tmpCheckGreyOutSide0 = "0"          'Not Approval
            'tmpCheckGreyOutSide1 = "0"          'Complete
            'tmpCheckGreyOutSide2 = "1"          'Approval
            'tmpCheckGreyOutSide3 = "0"          'Cancel
            'tmpCheckGreyOutSide4 = "0"          'Transmit

            'W2356.CheckOutBoundMaterial = Check_OutBound()

            'Select Case W2356.CheckOutBoundMaterial
            '    Case "1"
            '        W3147.cdFactory = txt_cdFactory.Code
            '        W3147.CheckIOType = "2" '1.InBound 2.OutBound
            '        W3147.CheckProcessGreyInSide = "1" '1.InSide 2.Return

            '        If HLP3147A.Link_HLP3147A(W3147, W3148,
            '                                         tmpCheckGreyType0,
            '                                         tmpCheckGreyType1,
            '                                         tmpCheckMarketType0,
            '                                         tmpCheckMarketType1,
            '                                         tmpCheckGreyOutSide0,
            '                                         tmpCheckGreyOutSide1,
            '                                         tmpCheckGreyOutSide2,
            '                                         tmpCheckGreyOutSide3,
            '                                         tmpCheckGreyOutSide4) = True Then
            '        End If

            '        L2356.FactOrderNo = W3148.GreyInSideNo
            '        L2356.FactOrderSeq = W3148.GreyInSideSeq

            '        txt_FactOrderNo.Data = W3148.GreyInSideNo
            '        txt_FactOrderSeq.Data = W3148.GreyInSideSeq

            '    Case "2"
            '        W3141.cdFactory = txt_cdFactory.Code
            '        W3141.CheckIOType = "2" '1.InBound 2.OutBound

            '        If HLP3141A.Link_HLP3141A(W3141, W3142,
            '                                         tmpCheckGreyType0,
            '                                         tmpCheckGreyType1,
            '                                         tmpCheckMarketType0,
            '                                         tmpCheckMarketType1,
            '                                         tmpCheckGreyOutSide0,
            '                                         tmpCheckGreyOutSide1,
            '                                         tmpCheckGreyOutSide2,
            '                                         tmpCheckGreyOutSide3,
            '                                         tmpCheckGreyOutSide4) = True Then
            '        End If

            '        L2356.FactOrderNo = W3142.GreySalesNo
            '        L2356.FactOrderSeq = W3142.GreySalesSeq

            '        txt_FactOrderNo.Data = W3142.GreySalesNo
            '        txt_FactOrderSeq.Data = W3142.GreySalesSeq

            '    Case "3"
            '        W3143.cdFactory = txt_cdFactory.Code
            '        W3143.CheckIOType = "2" '1.InBound 2.OutBound

            '        If HLP3143A.Link_HLP3143A(W3143, W3144,
            '                                         tmpCheckGreyType0,
            '                                         tmpCheckGreyType1,
            '                                         tmpCheckMarketType0,
            '                                         tmpCheckMarketType1,
            '                                         tmpCheckGreyOutSide0,
            '                                         tmpCheckGreyOutSide1,
            '                                         tmpCheckGreyOutSide2,
            '                                         tmpCheckGreyOutSide3,
            '                                         tmpCheckGreyOutSide4) = True Then
            '        End If

            '        L2356.FactOrderNo = W3144.GreyTrashNo
            '        L2356.FactOrderSeq = W3144.GreyTrashSeq

            '        txt_FactOrderNo.Data = W3144.GreyTrashNo
            '        txt_FactOrderSeq.Data = W3144.GreyTrashSeq

            '    Case "4"

            '    Case "7"
            '        W3135.cdFactory = txt_cdFactory.Code
            '        W3135.CheckIOType = "2" '1.InBound 2.OutBound

            '        If HLP3135A.Link_HLP3135A(W3135, W3136,
            '                                         tmpCheckGreyType0,
            '                                         tmpCheckGreyType1,
            '                                         tmpCheckMarketType0,
            '                                         tmpCheckMarketType1,
            '                                         tmpCheckGreyOutSide0,
            '                                         tmpCheckGreyOutSide1,
            '                                         tmpCheckGreyOutSide2,
            '                                         tmpCheckGreyOutSide3,
            '                                         tmpCheckGreyOutSide4) = True Then
            '        End If

            '        L2356.FactOrderNo = W3136.GreyOutSideNo
            '        L2356.FactOrderSeq = W3136.GreyOutSideSeq

            '        txt_FactOrderNo.Data = W3136.GreyOutSideNo
            '        txt_FactOrderSeq.Data = W3136.GreyOutSideSeq

            '    Case "8"
            '        W3137.cdFactory = txt_cdFactory.Code
            '        W3137.CheckIOType = "2" '1.InBound 2.OutBound

            '        If HLP3137A.Link_HLP3137A(W3137, W3138,
            '                                         tmpCheckGreyType0,
            '                                         tmpCheckGreyType1,
            '                                         tmpCheckMarketType0,
            '                                         tmpCheckMarketType1,
            '                                         tmpCheckGreyOutSide0,
            '                                         tmpCheckGreyOutSide1,
            '                                         tmpCheckGreyOutSide2,
            '                                         tmpCheckGreyOutSide3,
            '                                         tmpCheckGreyOutSide4) = True Then
            '        End If

            '        L2356.FactOrderNo = W3138.GreyBookingNo
            '        L2356.FactOrderSeq = W3138.GreyBookingSeq

            '        txt_FactOrderNo.Data = W3138.GreyBookingNo
            '        txt_FactOrderSeq.Data = W3138.GreyBookingSeq

            '    Case "9"
            '        W3421.cdFactory = txt_cdFactory.Code
            '        W3421.CheckIOType = "2" '1.InBound 2.OutBound

            '        If HLP3421B.Link_HLP3421B(W3421, W3422,
            '                                         tmpCheckGreyType0,
            '                                         tmpCheckGreyType1,
            '                                         tmpCheckMarketType0,
            '                                         tmpCheckMarketType1,
            '                                         tmpCheckGreyOutSide0,
            '                                         tmpCheckGreyOutSide1,
            '                                         tmpCheckGreyOutSide2,
            '                                         tmpCheckGreyOutSide3,
            '                                         tmpCheckGreyOutSide4) = True Then
            '        End If

            '        L2356.FactOrderNo = W3422.FactOrderNo
            '        L2356.FactOrderSeq = W3422.FactOrderSeq

            '        txt_FactOrderNo.Data = W3422.FactOrderNo
            '        txt_FactOrderSeq.Data = W3422.FactOrderSeq
            '    Case "D"
            '        W3421.cdFactory = txt_cdFactory.Code
            '        W3421.CheckIOType = "2" '1.InBound 2.OutBound

            '        If HLP3421A.Link_HLP3421A(W3421, W3422,
            '                                         tmpCheckGreyType0,
            '                                         tmpCheckGreyType1,
            '                                         tmpCheckMarketType0,
            '                                         tmpCheckMarketType1,
            '                                         tmpCheckGreyOutSide0,
            '                                         tmpCheckGreyOutSide1,
            '                                         tmpCheckGreyOutSide2,
            '                                         tmpCheckGreyOutSide3,
            '                                         tmpCheckGreyOutSide4) = True Then
            '        End If

            '        L2356.FactOrderNo = W3422.FabricPurchasingNo
            '        L2356.FactOrderSeq = W3422.FabricPurchasingSeq

            '        txt_FactOrderNo.Data = W3422.FabricPurchasingNo
            '        txt_FactOrderSeq.Data = W3422.FabricPurchasingSeq
            '    Case "F"
            '        W3139.cdFactory = txt_cdFactory.Code
            '        W3139.CheckIOType = "2" '1.InBound 2.OutBound

            '        If HLP3139A.Link_HLP3139A(W3139, W3130,
            '                                         tmpCheckGreyType0,
            '                                         tmpCheckGreyType1,
            '                                         tmpCheckMarketType0,
            '                                         tmpCheckMarketType1,
            '                                         tmpCheckGreyOutSide0,
            '                                         tmpCheckGreyOutSide1,
            '                                         tmpCheckGreyOutSide2,
            '                                         tmpCheckGreyOutSide3,
            '                                         tmpCheckGreyOutSide4) = True Then
            '        End If

            '        L2356.FactOrderNo = W3130.RequestOutSourcingNo
            '        L2356.FactOrderSeq = W3130.RequestOutSourcingSeq

            '        txt_FactOrderNo.Data = W3130.RequestOutSourcingNo
            '        txt_FactOrderSeq.Data = W3130.RequestOutSourcingSeq

            'End Select

            'Call KEY_COUNT()

            'If DATA_SEARCH_HEAD_INSERT() = False Then
            '    Me.Form_ClearData()
            '    vS1.ActiveSheet.RowCount = 0
            '    MsgBoxP("Worksheet no data. Please check!")

            '    txt_FactOrderNo.Data = ""
            '    txt_FactOrderSeq.Data = ""
            '    Exit Sub
            'End If

            'Call DATA_SEARCH_VS1()


        Catch ex As Exception
            MsgBoxP("Weaving Worksheet!", vbCritical)
        End Try
    End Sub
    Private Function CheckBalance() As Boolean
        CheckBalance = False
        Try
            Dim StrMsg As String
            'If CIntp(txt_QtyBalance.Data) < -200 Then
            '    StrMsg = MsgBox("Quá 200 yds rồi! Xuất tiếp bấm Yes?", vbYesNo)
            '    If StrMsg <> vbYes Then Exit Function
            'End If
            CheckBalance = True
        Catch ex As Exception

        End Try

    End Function
    Private Sub txt_Barcode_txtTextKeyDown(sender As Object, e As KeyEventArgs) Handles txt_Barcode.txtTextKeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True

            If txt_Barcode.Data = "" Then Exit Sub
            If CheckBalance() = False Then Exit Sub

            txt_Barcode.Code = FormatCut(txt_Barcode.Data)

            If Len(txt_Barcode.Code) < 13 Then Exit Sub

            L2356.MaterialInBoundNo = Strings.Left(txt_Barcode.Code, 9)
            L2356.MaterialInBoundSeq = Strings.Mid(txt_Barcode.Code, 10, 3)
            L2356.MaterialInBoundSno = Strings.Mid(txt_Barcode.Code, 13)

            If DATA_SEARCH_HEAD_MaterialFullNo() = False Then
                MsgBoxP("Worksheet MaterialName no data . Please check!")

                txt_Barcode.Data = ""
                txt_Barcode.Code = ""

                txt_Barcode.PeaceTextbox1.Enabled = True

                Setfocus(txt_Barcode)
                Exit Sub
            End If

            Dim i As Integer
            Call READ_PFK2351(L2356.MaterialInBoundNo, L2356.MaterialInBoundSeq)
            If DATA_SEARCH_VS1_INSERT(vS1.ActiveSheet.RowCount - 1) = False Then
                MsgBoxP("Barcode no inventory . Please check!")

                Setfocus(txt_Barcode)
                Exit Sub
            End If

            If DATA_MOVE_K2356_LINE(vS1.ActiveSheet.RowCount - 1) Then
                Call DATA_SEARCH_VS1_LINE()

                vS1.ActiveSheet.RowCount += 1
                Call DATA_SEARCH_HEAD_INSERT()
                txt_Barcode.TextEnabled = True
                txt_Barcode.Data = ""
                txt_Barcode.Code = ""
                Me.Show()

                Application.DoEvents()
                Setfocus(txt_Barcode)

                txt_TimeMaterialOutBound.Data = FSDateTime(System_Date_time())
                txt_TimeMaterialOutBound.Code = System_Date_time()
            Else
                txt_Barcode.TextEnabled = True
                txt_Barcode.Data = ""
                txt_Barcode.Code = ""

                Call KEY_COUNT_SNO()

                vS1.SetViewportTopRow(0, vS1.ActiveSheet.RowCount - 1)
                vS1.ActiveSheet.ActiveRowIndex = vS1.ActiveSheet.RowCount - 1

                Me.Show()
                Application.DoEvents()
                Setfocus(txt_Barcode)

                txt_TimeMaterialOutBound.Data = FSDateTime(System_Date_time())
                txt_TimeMaterialOutBound.Code = System_Date_time()
            End If
        End If



    End Sub

    Private Sub txt_GreyFullNo_txtTextKeyDown_NEW()

        If txt_Barcode.Data = "" Then Exit Sub
        If CheckBalance() = False Then Exit Sub

        txt_Barcode.Code = FormatCut(txt_Barcode.Data)

        If Len(txt_Barcode.Code) < 13 Then Exit Sub

        L2356.MaterialInBoundNo = Strings.Left(txt_Barcode.Code, 9)
        L2356.MaterialInBoundSeq = Strings.Mid(txt_Barcode.Code, 10, 3)
        L2356.MaterialInBoundSno = Strings.Mid(txt_Barcode.Code, 13)

        If DATA_SEARCH_HEAD_MaterialFullNo() = False Then
            MsgBoxP("Worksheet MaterialName no data . Please check!")

            txt_Barcode.Data = ""
            txt_Barcode.Code = ""

            txt_Barcode.PeaceTextbox1.Enabled = True

            Setfocus(txt_Barcode)
            Exit Sub
        End If

        Dim i As Integer
        Call READ_PFK2351(L2356.MaterialInBoundNo, L2356.MaterialInBoundSeq)
        Call DATA_SEARCH_VS1_INSERT(vS1.ActiveSheet.RowCount - 1)

        If DATA_MOVE_K2356_LINE_NEWQTY(vS1.ActiveSheet.RowCount - 1) Then
            Call DATA_SEARCH_VS1_LINE()

            vS1.ActiveSheet.RowCount += 1
            Call DATA_SEARCH_HEAD_INSERT()
            txt_Barcode.TextEnabled = True
            txt_Barcode.Data = ""
            txt_Barcode.Code = ""
            Me.Show()

            Application.DoEvents()
            Setfocus(txt_Barcode)

            txt_TimeMaterialOutBound.Data = FSDateTime(System_Date_time())
            txt_TimeMaterialOutBound.Code = System_Date_time()

        Else
            txt_Barcode.TextEnabled = True
            txt_Barcode.Data = ""
            txt_Barcode.Code = ""

            Call KEY_COUNT_SNO()

            vS1.SetViewportTopRow(0, vS1.ActiveSheet.RowCount - 1)
            vS1.ActiveSheet.ActiveRowIndex = vS1.ActiveSheet.RowCount - 1

            Me.Show()
            Application.DoEvents()
            Setfocus(txt_Barcode)

            txt_TimeMaterialOutBound.Data = FSDateTime(System_Date_time())
            txt_TimeMaterialOutBound.Code = System_Date_time()
        End If

    End Sub
#End Region

End Class