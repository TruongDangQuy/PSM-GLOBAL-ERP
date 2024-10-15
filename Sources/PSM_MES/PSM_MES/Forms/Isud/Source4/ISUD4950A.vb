Public Class ISUD4950A

#Region "Variable"
    Private wJOB As Integer

    Private W4958 As New T4958_AREA
    Private L4958 As New T4958_AREA

    Private W4950 As New T4950_AREA
    Private L4950 As New T4950_AREA

    Private W4951 As New T4951_AREA
    Private L4951 As New T4951_AREA

    Private WRITE_CHK As String
    Private formA As Boolean
    Private CHK(0 To 5) As String

    Private Key_OrderNo() As String
    Private Key_OrderNoSeq() As String


#End Region

#Region "Link"

    Public Function Link_ISUD4950A(job As Integer, OrderNo As String, OrderNoSeq As String, CustomerCode As String, Optional ByVal TAG As String = "") As Boolean

        Me.Tag = TAG

        D4958.OrderNo = OrderNo
        D4958.OrderNoSeq = OrderNoSeq
        D4958.CustomerCode = CustomerCode

        wJOB = job : L4958 = D4958

        Link_ISUD4950A = False
        Try

            Select Case job
                Case 1
                Case Else
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD4950A = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Link_ISUD4950A"))
        End Try

    End Function

    Public Function Link_ISUD4950A_Arr(job As Integer, LoadingCode As String, OrderNo As String, OrderNoSeq As String, CustomerCode As String, Optional ByVal TAG As String = "") As Boolean

        Me.Tag = TAG

        Key_OrderNo = OrderNo.Split("|")
        Key_OrderNoSeq = OrderNoSeq.Split("|")

        D4958.CustomerCode = CustomerCode

        wJOB = job : L4958 = D4958

        If wJOB <> 1 Then
            L4958.LoadingCode = LoadingCode
            L4950.LoadingCode = LoadingCode
        End If

        Link_ISUD4950A_Arr = False
        Try

            Select Case job
                Case 1
                Case Else
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD4950A_Arr = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Link_ISUD4950A_Arr"))
        End Try

    End Function

    Public Function Link_ISUD4950A_SUD(job As Integer, LoadingCode As String, Optional ByVal TAG As String = "") As Boolean

        Me.Tag = TAG

        D4950.LoadingCode = LoadingCode
        L4950.LoadingCode = D4950.LoadingCode

        If READ_PFK4951_LOADINGCODE(LoadingCode) = True Then
            L4951.LoadingCode = D4951.LoadingCode
        End If

        wJOB = job : L4951 = D4951

        Link_ISUD4950A_SUD = False
        Try

            Select Case job
                Case 1
                Case Else
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD4950A_SUD = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Link_ISUD4950A_SUD"))
        End Try

    End Function

#End Region

#Region "Form"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        Me.Form_Initial()
        Me.Form_KeyDown()

        Call DATA_INIT()
        Call FORM_INIT()

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        Select Case wJOB
            Case 1
                Me.Text = Me.Text & " - INSERT"
                Frame1.Enabled = True
                tst_iDelete.Visible = False

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call KEY_COUNT()
                Call DATA_SEARCH_VS1_INSERT()

            Case 2
                Me.Text = Me.Text & " - SEARCH"

                Frame1.Enabled = True
                tst_iDelete.Visible = False
                tst_iSave.Visible = False

                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                SPR_LOCK(vS0)
                SPR_LOCK(vS1)

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS0()
                Call DATA_SEARCH_VS1()

            Case 3
                Me.Text = Me.Text & " - UPDATE"

                Frame1.Enabled = True

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS0()
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
                        Call MsgBoxP("Only Search !") : tst_iSave.Visible = False
                        SPR_LOCK(vS0)
                        SPR_LOCK(vS1)

                    End If
                End If

            Case 4
                Me.Text = Me.Text & " - DELETE"

                tst_iSave.Visible = False


                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS0()
                Call DATA_SEARCH_VS1()
        End Select

        formA = True
    End Sub

#End Region

#Region "Functions"

    Private Sub KEY_COUNT()

        Try

            SQL = "SELECT MAX(CAST(K4950_LoadingCode AS DECIMAL)) AS MAX_MCODE FROM PFK4950 "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                L4950.LoadingCode = "000001"
            Else
                L4950.LoadingCode = Format(CInt(rd!MAX_MCODE + 1), "000000")
            End If

            W4950.LoadingCode = L4950.LoadingCode
            L4951.LoadingCode = L4950.LoadingCode
            W4951.LoadingCode = L4951.LoadingCode

            rd.Close()
            txt_LoadingCode.Data = W4950.LoadingCode
            txt_LoadingCode.TextEnabled = False

        Catch ex As Exception
            Call MsgBoxP("KEY_COUNT")
        End Try
    End Sub


    Private Sub KEY_COUNT_LoadingSeq(LoadingCode As String)

      
    End Sub

    Private Sub KEY_COUNT_LoadingNo(OrderNo As String, OrderNoSeq As String, CustomerCode As String)

       
    End Sub

#End Region

#Region "Search"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False
        Try

            DS1 = READ_PFK4950(L4950.LoadingCode, cn)
            If GetDsRc(DS1) = 0 Then
                Exit Function
                isudCHK = False
            End If

            READER_MOVE(Me, DS1)

            CheckLoading(GetDsData(DS1, 0, "K4950_CheckLoading"))

            If READ_PFK7101(txt_CustomerCode.Data) = True Then
                txt_CustomerCode.Code = D7101.CustomerCode
                txt_CustomerCode.Data = D7101.CustomerName
            End If

            DATA_SEARCH01 = True

        Catch ex As Exception
            Call MsgBoxEx("DATA_SEARCH01")
        End Try
    End Function

    Private Function DATA_SEARCH_VS0() As Boolean
        DATA_SEARCH_VS0 = False
        Try
            DS1 = PrcDS("USP_ISUD4950A_SEARCH_VS0", cn, L4950.LoadingCode)

            If GetDsRc(DS1) = 0 Then
                vS0.ActiveSheet.RowCount = 5
                vS0.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS0, DS1, "USP_ISUD4950A_SEARCH_VS0", "vS0", True)

            txt_QtyLoading.Data = DS1.Tables(0).Compute("SUM(QtyLoading)", "")

            DATA_SEARCH_VS0 = True

        Catch ex As Exception
            Call MsgBoxP("DATA_SEARCH_VS0")
        End Try
    End Function

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False

        Dim Key_OrderNo As String = getData(vS0, getColumIndex(vS0, "Key_OrderNo"), vS0.ActiveSheet.ActiveRowIndex)
        Dim Key_OrderNoSeq As String = getData(vS0, getColumIndex(vS0, "Key_OrderNoSeq"), vS0.ActiveSheet.ActiveRowIndex)


        Try
            DS1 = PrcDS("USP_ISUD4950A_SEARCH_VS1", cn, L4950.LoadingCode, Key_OrderNo,
                                                        Key_OrderNoSeq)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS1, DS1, "USP_ISUD4950A_SEARCH_VS1", "vS1", True)
                vS1.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS1, DS1, "USP_ISUD4950A_SEARCH_VS1", "vS1", True)
            DATA_SEARCH_VS1 = True

        Catch ex As Exception
            Call MsgBoxP("DATA_SEARCH_VS1")
        End Try
    End Function

    Private Function DATA_SEARCH_VS1_INSERT() As Boolean
        DATA_SEARCH_VS1_INSERT = False

        Dim dsnew1 As New DataSet

        Try
            dsnew1 = New DataSet
            For i As Integer = 0 To Key_OrderNo.Length - 1

                DS1 = PrcDS("USP_ISUD4950A_SEARCH_VS1_INSERT", cn, Key_OrderNo(i),
                                                            Key_OrderNoSeq(i))

                dsnew1.Merge(DS1.Tables(0))

            Next

            If GetDsRc(dsnew1) = 0 Then
                SPR_PRO_NEW(vS1, DS1, "USP_ISUD4950A_SEARCH_VS1", "vS1", True)
                vS1.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS1, dsnew1, "USP_ISUD4950A_SEARCH_VS1", "vS1", True)
            DATA_SEARCH_VS1_INSERT = True

        Catch ex As Exception
            Call MsgBoxP("DATA_SEARCH_VS1")
        End Try
    End Function
#End Region

#Region "Function"
    Private Sub CheckLoading(Process As String)
        Select Case Process
            Case "1" : chk_01.Checked = True
            Case Else : chk_01.Checked = False
        End Select
    End Sub


    Private Sub DATA_MOVE()

    End Sub

    Private Function DATA_CHECK() As Boolean
        DATA_CHECK = False

        Try


            DATA_CHECK = True

        Catch ex As Exception

        End Try

    End Function

    Private Function DATA_SAVE() As Boolean
        DATA_SAVE = False

        Try
            If READ_PFK4950(L4950.LoadingCode) = True Then

                W4950 = D4950

                W4950.LoadingNo = txt_LoadingNo.Data
                W4950.CheckLoading = chk_01.CheckState
                W4950.CheckTransType = txt_CheckTransType.InSelected + 1
                W4950.DateShipping = txt_DateShipping.Data
                W4950.DateLoading = txt_DateLoading.Data
                W4950.DateDelivery = txt_DateDelivery.Data
                W4950.FromLoading = txt_FromLoading.Data
                W4950.ToLoading = txt_ToLoading.Data
                W4950.ContainerNo = txt_ContainerNo.Data
                W4950.CustomerCode = txt_CustomerCode.Code
                W4950.QtyLoading = 0

                W4950.DateUpdate = System_Date_8()
                W4950.InchargeUpdate = Pub.SAW

                W4950.CheckUse = "1"
                W4950.CheckComplete = "2"
                W4950.VesselName = txt_VesselName.Data
                W4950.VesselNo = txt_VesselNo.Data
                W4950.Remark = ""

                If REWRITE_PFK4950(W4950) = True Then
                    Call DATA_MOVE_WRITE()
                End If

            Else

                W4950.LoadingCode = txt_LoadingCode.Data
                W4950.LoadingNo = txt_LoadingNo.Data
                W4950.CheckLoading = chk_01.CheckState
                W4950.CheckTransType = txt_CheckTransType.InSelected + 1
                W4950.DateShipping = txt_DateShipping.Data
                W4950.DateLoading = txt_DateLoading.Data
                W4950.DateDelivery = txt_DateDelivery.Data
                W4950.FromLoading = txt_FromLoading.Data
                W4950.ToLoading = txt_ToLoading.Data
                W4950.ContainerNo = txt_ContainerNo.Data
                W4950.CustomerCode = txt_CustomerCode.Code
                W4950.QtyLoading = 0
                W4950.DateInsert = System_Date_8()
                W4950.InchargeInsert = Pub.SAW
                W4950.CheckUse = "1"
                W4950.CheckComplete = "2"
                W4950.VesselName = txt_VesselName.Data
                W4950.VesselNo = txt_VesselNo.Data
                W4950.Remark = ""

                If WRITE_PFK4950(W4950) = True Then
                    Call DATA_MOVE_WRITE()
                End If

            End If

            DATA_SAVE = True
            Call MsgBoxP("Data Save successfully!", vbInformation)
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_SAVE")
        End Try
    End Function


    Private Function DATA_MOVE_WRITE() As Boolean
        DATA_MOVE_WRITE = False
        Try
            Dim i As Integer

            For i = 0 To vS1.ActiveSheet.RowCount - 1

                If getDataM(vS1, getColumIndex(vS1, "DCHK"), i) = "1" Then

                    If READ_PFK4951(getData(vS1, getColumIndex(vS1, "KEY_autokey"), i)) = True Then
                        W4951 = D4951

                        W4951.Autokey_4958 = getData(vS1, getColumIndex(vS1, "KEY_Autokey_4958"), i)

                        W4951.LoadingCMB = CDblp(getData(vS1, getColumIndex(vS1, "LoadingCMB"), i))
                        W4951.LoadingNW = CDblp(getData(vS1, getColumIndex(vS1, "LoadingNW"), i))
                        W4951.LoadingGW = CDblp(getData(vS1, getColumIndex(vS1, "LoadingGW"), i))

                        W4951.QtyCarton = CDblp(getData(vS1, getColumIndex(vS1, "QtyCarton"), i))
                        W4951.QtyLoading = CDblp(getData(vS1, getColumIndex(vS1, "QtyLoading"), i))

                        W4951.CheckUse = "2"

                        W4951.CheckComplete = "2"

                        Call REWRITE_PFK4951(W4951)
                        isudCHK = True
                    Else
                        W4951.LoadingCode = L4951.LoadingCode
                        Call KEY_COUNT_LoadingSeq(L4951.LoadingCode)
                        W4951.Autokey_4958 = getData(vS1, getColumIndex(vS1, "KEY_Autokey_4958"), i)
                        W4951.LoadingCMB = CDblp(getData(vS1, getColumIndex(vS1, "LoadingCMB"), i))
                        W4951.LoadingNW = CDblp(getData(vS1, getColumIndex(vS1, "LoadingNW"), i))
                        W4951.LoadingGW = CDblp(getData(vS1, getColumIndex(vS1, "LoadingGW"), i))

                        W4951.QtyCarton = CDblp(getData(vS1, getColumIndex(vS1, "QtyCarton"), i))
                        W4951.QtyLoading = CDblp(getData(vS1, getColumIndex(vS1, "QtyLoading"), i))

                        W4951.CheckUse = "2"
                        W4951.CheckComplete = "2"

                        Call WRITE_PFK4951(W4951)

                    End If

                End If

            Next
            DATA_MOVE_WRITE = True
            Call MsgBoxP("Update Date Succuessfully!", vbInformation)
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_MOVE_WRITE")
        End Try
    End Function

    Private Function DATA_DELETE() As Boolean
        DATA_DELETE = False
        Dim i As Integer
        Try

            DS1 = READ_PFK4951_LOADINGCODE(L4950.LoadingCode, cn)
            If GetDsRc(DS1) > 0 Then
                For i = 0 To GetDsRc(DS1) - 1
                    If READ_PFK4951(GetDsData(DS1, i, "K4951_Autokey")) = True Then
                        W4951 = D4951
                        Call DELETE_PFK4951(W4951)
                    End If
                Next
            End If

            If READ_PFK4950(L4951.LoadingCode) = True Then
                W4950 = D4950
                Call DELETE_PFK4950(W4950)
            End If

            Call MsgBoxP("Delete Data Successfully!", vbInformation)

            DATA_DELETE = True

            Me.Dispose()

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Function

    Private Sub DATA_INIT()
        Try

            txt_DateDelivery.Data = System_Date_8()
            txt_DateLoading.Data = System_Date_8()
            txt_DateShipping.Data = System_Date_8()

            COMBO_TransType(txt_CheckTransType.PeaceCombobox1)

            If READ_PFK7101(L4958.CustomerCode) = True Then
                txt_CustomerCode.Code = L4958.CustomerCode
                txt_CustomerCode.Data = D7101.CustomerName
            End If

            If wJOB = 1 Then
                Call KEY_COUNT_LoadingNo(Key_OrderNo(0), Key_OrderNoSeq(0), L4958.CustomerCode)
            End If

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Public Sub COMBO_TransType(ctlCombo As ComboBox)
        ctlCombo.Items.Clear()
        ctlCombo.Items.Add("SEA")
        ctlCombo.Items.Add("AIR")
        ctlCombo.Items.Add("CAR")
        ctlCombo.SelectedIndex = 0
    End Sub

    Private Sub FORM_INIT()

    End Sub

#End Region

#Region "Event"

    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        If wJOB = 2 Then Exit Sub

        Select Case wJOB
            Case 1
                If DATA_CHECK() = False Then Exit Sub
                If DATA_SAVE() = True Then
                    Call PrcExeNoError("USP_ISUD4951_4950_WEIGHTCAL", cn, txt_LoadingCode.Data)
                    Call DATA_SEARCH_VS0()
                    Call DATA_SEARCH_VS1()

                    wJOB = 3
                End If
             
            Case 2
                Me.Dispose()

            Case 3
                If DATA_CHECK() = False Then Exit Sub
                Call DATA_SAVE()
                Call PrcExeNoError("USP_ISUD4951_4950_WEIGHTCAL", cn, txt_LoadingCode.Data)
                Call DATA_SEARCH_VS0()
                Call DATA_SEARCH_VS1()
        End Select

    End Sub

    Private Sub chk_CheckLoading_CheckedChanged(sender As Object, e As EventArgs) Handles chk_01.CheckedChanged, chk_02.CheckedChanged
        If formA = True Then
            Call DATA_SEARCH_VS1()
        End If
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
        If wJOB = 2 Then Exit Sub

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        If CHK(4) <> "1" Then
            Call MsgBoxP("4", "tst_iDelete_Click")
            Exit Sub
        End If

        'If MsgBoxPPW("Type pass to delete order!", const_pwPrintUpdate) = False Then MsgBoxP("Please check condition!") : Exit Sub

        Dim str As String = MsgBoxP("Do you want to delete it?", vbYesNo)

        If str <> vbYes Then Exit Sub
        If DATA_CHECK() = False Then Exit Sub

        If DATA_DELETE() = True Then
            'Call DATA_SEARCH_VS0()
            'Call DATA_SEARCH_VS1()
        Else
            MsgBoxP("Delete DATE error!")
        End If
    End Sub

    Private Sub txt_CartonNo_txtTextKeyDown(sender As Object, e As KeyEventArgs) Handles txt_CartonNo.txtTextKeyDown
        If wJOB = 2 Then Exit Sub
        Dim CARTONNO As String()
        Dim k As Integer
        Dim j As Integer
        Dim i As Integer

        Try
            If e.KeyCode = Keys.Enter Then

                If txt_CartonNo.Data.Trim.Length > 0 Then

                    For i = 0 To vS1.ActiveSheet.RowCount - 1
                        setDataCk(vS1, getColumIndex(vS1, "DCHK"), i, "0")
                    Next

                    CARTONNO = txt_CartonNo.Data.Trim.ToString.Split(",")

                    For k = 0 To CARTONNO.Length

                        For j = 0 To vS1.ActiveSheet.RowCount - 1
                            If getData(vS1, getColumIndex(vS1, "CartonNo"), j) = CARTONNO(k) Then
                                setDataCk(vS1, getColumIndex(vS1, "DCHK"), j, "1")
                            End If
                        Next
                    Next
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_To_txtTextKeyDown(sender As Object, e As KeyEventArgs) Handles txt_To.txtTextKeyDown
        If wJOB = 2 Then Exit Sub
        Dim _From As Integer
        Dim _To As Integer

        Dim i As Integer
        Dim _Data As String

        Try
            If e.KeyCode = Keys.Enter Then

                For i = 0 To vS1.ActiveSheet.RowCount - 1
                    setDataCk(vS1, getColumIndex(vS1, "DCHK"), i, "0")
                Next

                If IsNumeric(txt_From.Data) = False Then Setfocus(txt_From) : Exit Sub
                If IsNumeric(txt_To.Data) = False Then Setfocus(txt_To) : Exit Sub

                _From = CDblp(txt_From.Data)
                _To = CDblp(txt_To.Data)

                If _From < _To Then
                    For i = 0 To vS1.ActiveSheet.RowCount - 1
                        _Data = CDblp(getData(vS1, getColumIndex(vS1, "CartonNo"), i))

                        If IsNumeric(_Data) Then
                            If _Data >= _From And _Data <= _To Then
                                setDataCk(vS1, getColumIndex(vS1, "DCHK"), i, "1")
                            End If
                        End If
                    Next
                ElseIf _From > _To Then
                    For i = 0 To vS1.ActiveSheet.RowCount - 1
                        _Data = CDblp(getData(vS1, getColumIndex(vS1, "CartonNo"), i))

                        If IsNumeric(_Data) Then
                            If _Data <= _From And _Data >= _To Then
                                setDataCk(vS1, getColumIndex(vS1, "DCHK"), i, "1")
                            End If
                        End If
                    Next
                ElseIf _From = _To Then
                    For i = 0 To vS1.ActiveSheet.RowCount - 1
                        _Data = CDblp(getData(vS1, getColumIndex(vS1, "CartonNo"), i))

                        If IsNumeric(_Data) Then
                            If _Data = _From Then
                                setDataCk(vS1, getColumIndex(vS1, "DCHK"), i, "1")
                            End If
                        End If
                    Next
                End If

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_From_txtTextKeyDown(sender As Object, e As KeyEventArgs) Handles txt_From.txtTextKeyDown
        If wJOB = 2 Then Exit Sub
        Try

            If e.KeyCode = Keys.Enter Then
                Setfocus(txt_From)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub vS0_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS0.CellDoubleClick
        If wJOB = "1" Then Exit Sub
        Call DATA_SEARCH_VS1()
    End Sub

    Private Sub vS0_KeyDown(sender As Object, e As KeyEventArgs) Handles vS0.KeyDown
        If wJOB = 2 Then Exit Sub
        Dim KEY_LoadingCode As String
        Dim KEY_LoadingSeq As String

        Try
            If e.KeyCode = Keys.Delete Then
                KEY_LoadingCode = getData(vS0, getColumIndex(vS0, "KEY_LoadingCode"), vS0.ActiveSheet.ActiveRowIndex)

                If READ_PFK4950(KEY_LoadingCode) = True Then
                    W4950 = D4950
                    Dim str As String = MsgBoxP("Do you want to delete all ?", vbYesNo)

                    If str <> vbYes Then Exit Sub
                    Call DELETE_PFK4950(W4950)
                    Call DATA_SEARCH_VS0()
                    Call DATA_SEARCH_VS1()

                    vS0.Focus()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub vS1_CellClick(sender As Object, e As CellClickEventArgs) Handles vS1.CellClick
        If wJOB = 2 Then Exit Sub

        Dim QtyLoading As Decimal = 0
        Dim i As Decimal
        Try
            txt_QtyLoading.Data = "0"
            If getColumIndex(vS1, "DCHK") = vS1.ActiveSheet.ActiveColumnIndex Then
                For i = 0 To vS1.ActiveSheet.RowCount - 1
                    If getData(vS1, getColumIndex(vS1, "DCHK"), i) = "1" Then
                        QtyLoading += CDblp(getData(vS1, getColumIndex(vS1, "QtyLoading"), i))
                    End If
                Next
            End If

            txt_QtyLoading.Data = CStrp(QtyLoading)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_Cal_Click(sender As Object, e As EventArgs) Handles cmd_Cal.Click

        Dim CartonCode As String
        Dim FactOrderNo As String
        Dim FactOrderSeq As Decimal
        Dim Article As String
        Dim CustomerCode As String
        Dim cdSeason As String

        Dim i As Integer


        For i = 0 To vS1.ActiveSheet.RowCount - 1

            CartonCode = getData(vS1, getColumIndex(vS1, "Key_CartonCode"), i)
            Article = getData(vS1, getColumIndex(vS1, "Key_Article"), i)
            CustomerCode = getData(vS1, getColumIndex(vS1, "Key_Customercode"), i)
            cdSeason = getData(vS1, getColumIndex(vS1, "Key_cdSeason"), i)
            FactOrderNo = getData(vS1, getColumIndex(vS1, "Key_FactOrderNo"), i)
            FactOrderSeq = getData(vS1, getColumIndex(vS1, "Key_FactOrderSeq"), i)

            Call PrcExeNoError("USP_ISUD4958A_WEIGHTCAL", cn, CartonCode, FactOrderNo, FactOrderSeq, Article, CustomerCode, cdSeason)

            Call PrcExeNoError("USP_ISUD4958A_4951_WEIGHTCAL", cn, FactOrderNo, FactOrderSeq)

        Next

        Call DATA_SEARCH_VS1()


    End Sub

#End Region


   
End Class