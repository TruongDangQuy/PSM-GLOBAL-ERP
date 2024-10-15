Public Class ISUD2356B

#Region "Variable"
    Private wJOB As Integer

    Private W2356 As New T2356_AREA
    Private L2356 As New T2356_AREA

    Private W3421 As New T3421_AREA
    Private W3422 As New T3422_AREA

    Private W3141 As New T3141_AREA
    Private W3142 As New T3142_AREA


    Private WRITE_CHK As String
    Private strValue As String

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Form"
    Public Function Link_ISUD2356B(job As Integer, CheckOutBoundMaterial As String, DateOutBoundMaterial As String, SeqOutBoundMaterial As String, SnoOutBoundMaterial As String, _
                                                                            FactOrderNo As String, FactOrderSeq As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG

        DateOutBoundMaterial = FormatCut(DateOutBoundMaterial)

        D2356.CheckOutBoundMaterial = CheckOutBoundMaterial
        D2356.DateOutBoundMaterial = DateOutBoundMaterial
        D2356.SeqOutBoundMaterial = SeqOutBoundMaterial
        D2356.SnoOutBoundMaterial = SnoOutBoundMaterial

        D2356.FactOrderNo = FactOrderNo
        D2356.FactOrderSeq = FactOrderSeq

        wJOB = job : L2356 = D2356

        Link_ISUD2356B = False
        Try

            Select Case job
                Case 1

                Case Else
                    txt_Barcode.Enabled = True
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD2356B = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Replacement PROCESSING"))
        End Try

    End Function

    Public Function Link_ISUD2356B_AUTO(job As Integer, CheckOutBoundMaterial As String, DateOutBoundMaterial As String, SeqOutBoundMaterial As String, SnoOutBoundMaterial As String, _
                                                                           Value As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = Tag

        DateOutBoundMaterial = FormatCut(DateOutBoundMaterial)

        D2356.CheckOutBoundMaterial = CheckOutBoundMaterial
        D2356.DateOutBoundMaterial = DateOutBoundMaterial
        D2356.SeqOutBoundMaterial = SeqOutBoundMaterial
        D2356.SnoOutBoundMaterial = SnoOutBoundMaterial
        strValue = Value
        job = 11

        wJOB = job : L2356 = D2356

        Link_ISUD2356B_AUTO = False
        Try

            Select Case job
                Case 1

                Case Else
                    txt_Barcode.Enabled = True
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD2356B_AUTO = isudCHK

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

                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()

                Application.DoEvents()

                txt_DateOutBoundMaterial.Data = Pub.DAT
                txt_DateOutBoundMaterial.Code = Pub.DAT

                cmd_DEL.Visible = False

                Setfocus(txt_cdSite)

                cmd_OK.Visible = False
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
                Call DATA_SEARCH_VS2()

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

                    'Call KEY_COUNT_SNO()
                    Call DATA_SEARCH_VS1()
                    Call DATA_SEARCH_VS2()

                    txt_Barcode.Enabled = True
                Else
                    Call DATA_SEARCH_VS1()
                    Call DATA_SEARCH_VS2()

                    txt_Barcode.Enabled = True
                End If

                cmd_OK.Visible = True
                cmd_DEL.Visible = False

                rad_CheckOutSide1.Enabled = True
                rad_CheckOutSide2.Enabled = True
                rad_CheckOutSide3.Enabled = True
                rad_CheckOutSide4.Enabled = True
                rad_CheckOutSide5.Enabled = True
                rad_CheckOutSide6.Enabled = True

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
                Call DATA_SEARCH_VS2()

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
                    If strValue = "" Then Call DATA_SEARCH_VS1() : Call DATA_SEARCH_VS2()
                    If strValue <> "" Then Call DATA_SEARCH_VS1_MULTI() : Call DATA_SEARCH_VS2()
                    wJOB = 3

                    txt_Barcode.TextEnabled = True
                    txt_Barcode.Enabled = True

                End If
                cmd_OK.Visible = True
                cmd_DEL.Visible = False

        End Select

        If rad_CheckOrder2.Checked = True Then
            rad_CheckOrder1.Checked = False
            rad_CheckOrder2.Checked = True
            cmd_OK.Visible = False
            cmd_DEL.Visible = False

            rad_CheckOrder1.Enabled = False
            rad_CheckOrder2.Enabled = False

        End If

        formA = True
    End Sub

#End Region

#Region "Search"

    Private Function DATA_SEARCH_HEAD_INSERT() As Boolean
        DATA_SEARCH_HEAD_INSERT = False

        Try
            DS1 = PrcDS("USP_ISUD2356B_SEARCH_HEAD_MaterialInSide", cn, Pub.SITE, L2356.DateOutBoundMaterial, L2356.SeqOutBoundMaterial, L2356.SnoOutBoundMaterial)
         

            If GetDsRc(DS1) = 0 Then
                Call MsgBoxP("No data !")
                Exit Function
            End If

            Call STORE_MOVE(Me, DS1)

            If GetDsData(DS1, 0, "CheckComplete") = "1" Then
                rad_CheckOrder1.Checked = False
                rad_CheckOrder2.Checked = True
                cmd_OK.Visible = False
                cmd_DEL.Visible = False

                rad_CheckOrder1.Enabled = False
                rad_CheckOrder2.Enabled = False

            End If

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
                    DS1 = PrcDS("USP_ISUD2356B_SEARCH_HEAD_MaterialFullNo", cn, L2356.MaterialInBoundNo, L2356.MaterialInBoundSeq, L2356.MaterialInBoundSno)
                Case "5", "7"
                    DS1 = PrcDS("USP_ISUD2356B_SEARCH_HEAD_MaterialFullNo_Customer", cn, L2356.MaterialInBoundNo, L2356.MaterialInBoundSeq, L2356.MaterialInBoundSno, txt_CustomerOutBoundMaterial.Code)
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

            DS1 = PrcDS("USP_ISUD2356B_SEARCH_VS1_INSERT", cn, L2356.MaterialInBoundNo, _
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

            Call READ_SPREAD(vS1, DS1, "USP_ISUD2356B_SEARCH_VS1_F1", "Vs1", xrow)

            setData(vS1, getColumIndex(vS1, "QtyOutBound"), xrow, GetDsData(DS1, 0, "QtyOutBound"))

            DATA_SEARCH_VS1_INSERT = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1_INSERT")
        End Try
    End Function

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False

        Try
            DS1 = PrcDS("USP_ISUD2356B_SEARCH_VS1_F1", cn, Pub.SITE, L2356.DateOutBoundMaterial, _
                                                        L2356.SeqOutBoundMaterial, L2356.SnoOutBoundMaterial)


            If GetDsRc(DS1) = 0 Then
                SPR_SET(vS1, , , , OperationMode.Normal)
                SPR_PRO(vS1, DS1, "USP_ISUD2356B_SEARCH_VS1", "vS1")

                vS1.ActiveSheet.RowCount = 1
                vS1.Enabled = True

                Exit Function
            End If

            SPR_SET(vS1, , , , OperationMode.Normal)
            SPR_PRO(vS1, DS1, "USP_ISUD2356B_SEARCH_VS1", "Vs1")

            DATA_SEARCH_VS1 = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try
    End Function
    Private Function DATA_SEARCH_VS2() As Boolean
        DATA_SEARCH_VS2 = False

        Try
            DS1 = PrcDS("USP_ISUD2356B_SEARCH_VS2", cn, Pub.SITE, FormatCut(txt_DateOutbound.Data), txt_InvoiceNo.Data)


            If GetDsRc(DS1) = 0 Then
                SPR_SET(VS2, , , , OperationMode.Normal)
                SPR_PRO(VS2, DS1, "USP_ISUD2356B_SEARCH_VS2", "VS2")
                vS2.Enabled = True

                Exit Function
            End If

            SPR_SET(VS2, , , , OperationMode.Normal)
            SPR_PRO(VS2, DS1, "USP_ISUD2356B_SEARCH_VS2", "VS2")

            DATA_SEARCH_VS2 = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS2")
        End Try
    End Function
    Private Function DATA_SEARCH_VS1_MULTI() As Boolean
        DATA_SEARCH_VS1_MULTI = False

        Try
            DS1 = PrcDS("USP_ISUD2356B_SEARCH_VS1_MULTI", cn, Pub.SITE, strValue)


            If GetDsRc(DS1) = 0 Then
                SPR_SET(vS1, , , , OperationMode.Normal)
                SPR_PRO(vS1, DS1, "USP_ISUD2356B_SEARCH_VS1", "vS1")

                vS1.ActiveSheet.RowCount = 1
                vS1.Enabled = True

                Exit Function
            End If

            SPR_SET(vS1, , , , OperationMode.Normal)
            SPR_PRO(vS1, DS1, "USP_ISUD2356B_SEARCH_VS1", "Vs1")

            DATA_SEARCH_VS1_MULTI = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try
    End Function

    Private Function DATA_SEARCH_VS1_LINE() As Boolean
        DATA_SEARCH_VS1_LINE = False

        Try
            DS1 = PrcDS("USP_ISUD2356B_SEARCH_VS1_LINE", cn, L2356.DateOutBoundMaterial, _
                                                             L2356.SeqOutBoundMaterial, _
                                                             L2356.SnoOutBoundMaterial)

            If GetDsRc(DS1) = 0 Then
                SPR_SET(vS1, , , , OperationMode.Normal)
                SPR_PRO(vS1, DS1, "USP_ISUD2356B_SEARCH_VS1", "vS1")
                Exit Function
            End If

            Call READ_SPREAD(vS1, DS1, "USP_ISUD2356B_SEARCH_VS1", "Vs1", vS1.ActiveSheet.RowCount - 1)

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
                W2356.FactOrderSeq = L2356.FactOrderSeq

                W2356.CustomerOutBoundMaterial = txt_CustomerOutBoundMaterial.Code

                W2356.TimeMaterialOutBound = System_Date_time()

                W2356.JobCardWorking = L2356.JobCardWorking
                W2356.JobCardWorkingSeq = L2356.JobCardWorkingSeq
                W2356.JobCardType = L2356.JobCardType

                W2356.QtyOutBound = CDecp(getData(vS1, getColumIndex(vS1, "QtyOutBound"), xRow))

                W2356.cdSite = txt_cdSite.Code
                W2356.cdDepartment = txt_cdDepartment.Code

                W2356.seDepartment = ListCode("Department")
                W2356.seSite = ListCode("Site")
                W2356.cdDepartment = Pub.DEPARTMENT
                W2356.cdSite = Pub.SITE
                W2356.InchargeOutBoundMaterial = txt_InchargeOutBoundMaterial.Code

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
                W2356.InchargeOutBoundMaterial = txt_InchargeOutBoundMaterial.Code

            End If

            DATA_MOVE_K2356_LINE = True
        Catch ex As Exception
            MsgBoxP("DATA_MOVE_K2356_LINE!")
        End Try
    End Function

    Private Sub DATA_DELETE()
        Dim i As Integer

        Try
            Try
                For i = 0 To vS1.ActiveSheet.RowCount - 1
                    Call PrcExeNoError("USP_PFK2356_UPDATE_INFO_MULTI", cn, Pub.SITE, getData(vS1, getColumIndex(vS1, "KEY_DateOutBoundMaterial"), i), getData(vS1, getColumIndex(vS1, "KEY_SeqOutBoundMaterial"), i), CDecp(getData(vS1, getColumIndex(vS1, "KEY_SnoOutBoundMaterial"), i)), L2356.CheckOutBoundMaterial, "", txt_CustomerOutBoundMaterial.Code, "", "", "", "", "", "", "", "", "2")

                    If READ_PFK2356(getData(vS1, getColumIndex(vS1, "KEY_DateOutBoundMaterial"), i), getData(vS1, getColumIndex(vS1, "KEY_SeqOutBoundMaterial"), i), CDecp(getData(vS1, getColumIndex(vS1, "KEY_SnoOutBoundMaterial"), i))) Then
                        W2356 = D2356
                        W2356.JobCardWorking = ""
                        W2356.JobCardWorkingSeq = ""
                        Call REWRITE_PFK2356(W2356)
                    End If

                Next

                DATA_SEARCH_VS1()

            Catch ex As Exception

            End Try


            Call DATA_SEARCH_VS1()

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub

    Private Sub DATA_UPDATE()
        Dim i As Integer

        Try
            Dim strCheckComplete As String = "2"
            If rad_CheckOrder2.Checked = True Then strCheckComplete = "1"

            Call Check_OutBound()
            Try
                If ptc_001.SelectedIndex = 0 Then
                    For i = 0 To vS1.ActiveSheet.RowCount - 1
                        Call PrcExeNoError("USP_PFK2356_UPDATE_INFO_MULTI", cn, Pub.SITE, getData(vS1, getColumIndex(vS1, "KEY_DateOutBoundMaterial"), i), getData(vS1, getColumIndex(vS1, "KEY_SeqOutBoundMaterial"), i), CDecp(getData(vS1, getColumIndex(vS1, "KEY_SnoOutBoundMaterial"), i)), L2356.CheckOutBoundMaterial, txt_DateOutbound.Data, txt_CustomerOutBoundMaterial.Code, "*" & txt_InvoiceNo.Data, "*" & txt_Article.Data, "*" & txt_CustPONO.Data, txt_InchargeOutBoundMaterial.Code, "*" & txt_Buyer.Data, txt_PurchasingList.Data, txt_QtyOrder.Data, "1", strCheckComplete)

                        If READ_PFK2356(getData(vS1, getColumIndex(vS1, "KEY_DateOutBoundMaterial"), i), getData(vS1, getColumIndex(vS1, "KEY_SeqOutBoundMaterial"), i), CDecp(getData(vS1, getColumIndex(vS1, "KEY_SnoOutBoundMaterial"), i))) Then
                            W2356 = D2356
                            W2356.JobCardWorking = FormatCut(txt_JobCard.Data)
                            W2356.JobCardWorkingSeq = FormatCut(txt_JobCard.Data)
                            Call REWRITE_PFK2356(W2356)
                        End If

                    Next

                End If
               

                If ptc_001.SelectedIndex = 0 Then DATA_SEARCH_VS1()
                If ptc_001.SelectedIndex = 1 Then DATA_SEARCH_VS2()



                If rad_CheckOrder2.Checked = True Then
                    rad_CheckOrder1.Checked = False
                    rad_CheckOrder2.Checked = True
                    cmd_OK.Visible = False
                    cmd_DEL.Visible = False

                    rad_CheckOrder1.Enabled = False
                    rad_CheckOrder2.Enabled = False

                End If


            Catch ex As Exception

            End Try



        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub
    Private Sub DATA_LINE_DELETE(xrow As Integer)
        Try

            If FormatCut(getData(vS1, getColumIndex(vS1, "KEY_DateOutBoundMaterial"), xrow)) <> Pub.DAT Then
                MsgBoxP("Can not edit because of not today!")
                If MsgBoxPPW("Please type the password to modify!", const_pwDeleteOutbound) = False Then Exit Sub
            End If

            If READ_PFK2356(FormatCut(getData(vS1, getColumIndex(vS1, "KEY_DateOutBoundMaterial"), xrow)),
                            getData(vS1, getColumIndex(vS1, "KEY_SeqOutBoundMaterial"), xrow),
                            getData(vS1, getColumIndex(vS1, "KEY_SnoOutBoundMaterial"), xrow)) = True Then
                W2356 = D2356


                W2356.JobCardWorking = ""
                W2356.JobCardWorkingSeq = ""

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

            txt_FactOrderNo.Data = L2356.FactOrderNo
            txt_FactOrderSeq.Data = L2356.FactOrderSeq

            Call CheckOutBoundMaterial(L2356.CheckOutBoundMaterial)

            If READ_PFK7171(ListCode("Department"), Pub.DEPARTMENT) Then
                txt_cdDepartment.Code = D7171.BasicCode
                txt_cdDepartment.Data = D7171.BasicName
            End If

            If READ_PFK7411(Pub.SAW) Then
                txt_InchargeOutBoundMaterial.Code = D7411.IDNO
                txt_InchargeOutBoundMaterial.Data = D7411.Name
            End If

            vS1.InsChk = False
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

        Pan_Process.Enabled = True
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
        Select Case wJOB
            Case 1
                Call DATA_UPDATE()
            Case 2
                Me.Dispose()
            Case 3
                Call DATA_UPDATE()

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
        Me.Dispose()
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

                txt_Barcode.Data = getData(vS1, getColumIndex(vS1, "RawInBoundFullNo"), xROW)
                txt_Barcode.Code = FormatCut(getData(vS1, getColumIndex(vS1, "RawInBoundFullNo"), xROW))

                txt_CustomerOutBoundMaterial.Data = getData(vS1, getColumIndex(vS1, "CustomerName"), xROW)
                txt_CustomerOutBoundMaterial.Code = getData(vS1, getColumIndex(vS1, "CustomerOutBoundMaterial"), xROW)

                txt_InchargeOutBoundMaterial.Code = getData(vS1, getColumIndex(vS1, "InchargeOutBoundMaterial"), xROW)
                txt_InchargeOutBoundMaterial.Data = getData(vS1, getColumIndex(vS1, "InchargeName"), xROW)

                txt_DateOutBoundMaterial.Data = FormatCut(getData(vS1, getColumIndex(vS1, "KEY_DateOutBoundMaterial"), xROW))
                txt_DateOutBoundMaterial.Code = FormatCut(getData(vS1, getColumIndex(vS1, "KEY_DateOutBoundMaterial"), xROW))

                txt_SnoOutBoundMaterial.Data = getData(vS1, getColumIndex(vS1, "KEY_SeqOutBoundMaterial"), xROW)
                txt_SnoOutBoundMaterial.Data = getData(vS1, getColumIndex(vS1, "KEY_SnoOutBoundMaterial"), xROW)

                txt_FactOrderNo.Data = getData(vS1, getColumIndex(vS1, "KEY_FactOrderNo"), xROW)
                txt_FactOrderSeq.Data = getData(vS1, getColumIndex(vS1, "KEY_FactOrderSeq"), xROW)

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

                If wJOB = 4 Then Call DATA_LINE_DELETE(xRow)
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
    Private Sub txt_GreyFullNo_txtTextKeyDown(sender As Object, e As KeyEventArgs) Handles txt_Barcode.txtTextKeyDown
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
            Call DATA_SEARCH_VS1_INSERT(vS1.ActiveSheet.RowCount - 1)

            If DATA_MOVE_K2356_LINE(vS1.ActiveSheet.RowCount - 1) Then
                Call DATA_SEARCH_VS1_LINE()

                vS1.ActiveSheet.RowCount += 1
                DATA_SEARCH_HEAD_INSERT()
                txt_Barcode.TextEnabled = True
                txt_Barcode.Data = ""
                txt_Barcode.Code = ""
                Me.Show()

                Application.DoEvents()
                Setfocus(txt_Barcode)

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
            End If
        End If



    End Sub
#End Region

    Private Sub ptc_001_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ptc_001.SelectedIndexChanged
        If ptc_001.SelectedIndex = 0 Then Call DATA_SEARCH_VS1()
        If ptc_001.SelectedIndex = 1 Then Call DATA_SEARCH_VS2()
    End Sub

    Private Sub cmd_Uncom_Click(sender As Object, e As EventArgs) Handles cmd_Uncom.Click
        'const = 752

        If MsgBoxPPW("Please type the password to un-complete!", const_pwDeleteOutbound) = False Then Exit Sub
        rad_CheckOrder1.Enabled = True
        rad_CheckOrder2.Enabled = True
        cmd_OK.Visible = True
        cmd_DEL.Visible = True

    End Sub

    Private Sub cmd_Order_Click(sender As Object, e As EventArgs) Handles cmd_Order.Click
        Try
            If Trim(txt_InvoiceNo.Data) = "" Then MsgBoxP("Input InvoiceNo!") : Exit Sub

            If Trim(txt_InvoiceNo.Data) <> "" And Replace(FormatCut(txt_DateOutbound.Data), "_", "") <> "" Then
                Call HLP2356Y.Link_ISUD2356B(3, FormatCut(txt_DateOutbound.Data), Trim(txt_InvoiceNo.Data), Me.Name)

                DS1 = PrcDS("USP_ISUD2356B_SEARCH_INSERT_K2357", cn, Pub.SITE, FormatCut(txt_DateOutbound.Data), Trim(txt_InvoiceNo.Data))
                If GetDsRc(DS1) > 0 Then

                    txt_CustPONO.Data = GetDsData(DS1, 0, "TransferOrder_SOWI")
                    txt_Article.Data = GetDsData(DS1, 0, "TransferOrder_Article")
                    txt_QtyOrder.Data = GetDsData(DS1, 0, "TransferOrder_QtyOrder")
                    txt_PurchasingList.Data = GetDsData(DS1, 0, "TransferOrder_PrName")

                    If READ_PFK7101(GetDsData(DS1, 0, "TransferOrder_CustomerCode")) Then
                        txt_Buyer.Data = D7101.CustomerName
                    End If

                    ptc_001.SelectedIndex = 1
                    Call DATA_SEARCH_VS2()

                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_JobCard_txtTextKeyDown(sender As Object, e As KeyEventArgs) Handles txt_JobCard.txtTextKeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Dim JobCard As String

                JobCard = FormatCut(txt_JobCard.Data)

                If READ_PFK4010(JobCard) Then
                    DS1 = PrcDS("USP_ISUD2356B_SEARCH_INSERT_JOBCARD", cn, JobCard)
                    If GetDsRc(DS1) > 0 Then

                        txt_CustPONO.Data = GetDsData(DS1, 0, "TransferOrder_SOWI")
                        txt_Article.Data = GetDsData(DS1, 0, "TransferOrder_Article")
                        txt_QtyOrder.Data = GetDsData(DS1, 0, "TransferOrder_QtyOrder")
                        txt_PurchasingList.Data = GetDsData(DS1, 0, "TransferOrder_PrName")

                        If READ_PFK7101(GetDsData(DS1, 0, "TransferOrder_CustomerCode")) Then
                            txt_Buyer.Data = D7101.CustomerName
                        End If

                    Else
                        MsgBoxP("Wrong JobCard!")
                        txt_CustPONO.Data = ""
                        txt_Article.Data = ""
                        txt_QtyOrder.Data = ""
                        txt_PurchasingList.Data = ""

                        If READ_PFK7101(GetDsData(DS1, 0, "TransferOrder_CustomerCode")) Then
                            txt_Buyer.Data = ""
                        End If
                    End If
                Else
                    MsgBoxP("Wrong JobCard!")
                    txt_CustPONO.Data = ""
                    txt_Article.Data = ""
                    txt_QtyOrder.Data = ""
                    txt_PurchasingList.Data = ""

                    If READ_PFK7101(GetDsData(DS1, 0, "TransferOrder_CustomerCode")) Then
                        txt_Buyer.Data = ""
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class