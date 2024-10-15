Imports Spire.Barcode
Public Class PFP34510
#Region "Variable"
    Private Dsu01 As Long
    Private wGCODE As String
    Private Form_Close As Boolean
    Private chk_CheckIOType As String
    Private chk_CheckPurchasingOrder As String
    Private chk_NewForm As Boolean = False

    Private W4958 As T4958_AREA
    Private L4958 As T4958_AREA

#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Cms_additem(Cms_1,
                        "0. RECALCULATION PACKING ",
                        "1. PROCESS -- PKO NO",
                        "2. CANCEL - PKO NO",
                        "3. REVISE - PKO NO",
                        "4. COMPLETE - PKO NO",
                        "-",
                        "5. UPDATE QTY - PKO NO",
                        "6. DELETE - PKO NO",
                        "7. ADD - PKO NO")

        vS2.ContextMenuStrip = Cms_1

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, True, False, , , , , "UPLOAD")

        Me.KeyPreview = True

        Call FORM_INIT()
        Call DATA_INIT()

    End Sub
    Overrides Sub Function_Event(PressKey As Integer)
        Try
            Select Case PressKey
                Case Keys.F5 : Call MAIN_JOB01()
                Case Keys.F6 : Call MAIN_JOB02()
                Case Keys.F7 : Call MAIN_JOB03()
                Case Keys.F8 : Call MAIN_JOB04()

            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FORM_INIT()
        chk_FSEL.CheckState = 1
        chk_FSEL.BackColor = clrCheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("CLOSE")
        ssp_WHERE.Visible = True

        Me.chk_FormEnterkey = False

        vS2.InsChk = True
    End Sub

    Private Sub Clear_In()

    End Sub

    Private Sub Clear_Out()

    End Sub
    Private Sub DATA_INIT()
        Call Clear_In()
        Call Clear_Out()


        If Me.PeaceFormType = "" Then Exit Sub



    End Sub
#End Region

#Region "Function"
    Private Sub MAIN_JOB01()
        'If ISUD3451D.Link_ISUD3451D(1, "000000000", chk_CheckIOType, chk_CheckPurchasingOrder, Me.Name) = False Then Exit Sub

        'Call DATA_SEARCH_VS1()

        If vS2.Focused = False Then Exit Sub

        Dim str As String = MsgBoxP("Do you want to re-calculation again for all it?", vbYesNo)
        Dim CartonCode As String

        If str <> vbYes Then Exit Sub

        Dim i As Integer

        Dim Starting As Object
        Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")


        Try

            CartonCode = getData(vS2, getColumnIndex(vS2, "CartonCode"), vS2.ActiveSheet.ActiveRowIndex)

            If READ_PFK7210(CartonCode) = True Then

                For i = 0 To vS2.ActiveSheet.RowCount - 1
                    If getDataM(vS2, getColumIndex(vS2, "dchk"), i) = "1" Then
                        If READ_PFK4958(getDataM(vS2, getColumIndex(vS2, "KEY_Autokey"), i)) Then
                            CartonCode = getData(vS2, getColumnIndex(vS2, "CartonCode"), i)
                            READ_PFK7210(CartonCode)
                            D4958.CartonCode = D7210.CartonCode
                            D4958.PackingCMB = D7210.CBM
                            D4958.PackingNW = D7210.CTNetWeight

                            D4958.DatePacking = Pub.DAT
                            D4958.SizeGroup = txt_SizeGroup.Data

                            If REWRITE_PFK4958(D4958) Then
                                Call PrcExeNoError("EXP_CLOSSING_PFK4958_CBM_AUTOKEY", cn, D4958.Autokey)

                                If READ_PFK4958(getDataM(vS2, getColumIndex(vS2, "KEY_Autokey"), i)) Then
                                    setData(vS2, getColumIndex(vS2, "PackingCMB"), i, D4958.PackingCMB)
                                    setData(vS2, getColumIndex(vS2, "PackingGW"), i, D4958.PackingGW)
                                    setData(vS2, getColumIndex(vS2, "PackingNW"), i, D4958.PackingNW)
                                    setData(vS2, getColumIndex(vS2, "QtyPacking"), i, D4958.QtyPacking)

                                    setData(vS2, getColumIndex(vS2, "CTNetWeight"), i, D7210.CTNetWeight)

                                    D9700_CLEAR()
                                    D9700.ActionName = D4958.Autokey & "0. RECALCULATION PACKING "
                                    D9700.DateCreate = Pub.DAT
                                    D9700.UserCode = Pub.SAW
                                    D9700.FormName = "PFP34510"
                                    D9700.Reference = D4958.Autokey

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
                                End If

                            End If
                        End If

                    End If


                Next
            End If

        Catch ex As Exception

        Finally
            Starting.close()
        End Try
    End Sub

    Private Sub MAIN_JOB02()
        Try
            Dim KEY_Autokey As String

            KEY_Autokey = getData(Vs1, getColumIndex(Vs1, "KEY_Autokey"), Vs1.ActiveSheet.ActiveRowIndex)


            If READ_PFK3452(KEY_Autokey) Then
                D3452.CheckPurchasing = "3"

                Call REWRITE_PFK3452(D3452)
                setData(Vs1, getColumIndex(Vs1, "Sel_OrderDetailStatus"), Vs1.ActiveSheet.ActiveRowIndex, "Process")

                D9700_CLEAR()
                D9700.ActionName = D3452.Autokey & "1. PROCESS -- PKO NO"
                D9700.DateCreate = Pub.DAT
                D9700.UserCode = Pub.SAW
                D9700.FormName = "PFP34510"
                D9700.Reference = D3452.Autokey

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

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub MAIN_JOB03()
        Try
            Dim KEY_Autokey As String

            KEY_Autokey = getData(Vs1, getColumIndex(Vs1, "KEY_Autokey"), Vs1.ActiveSheet.ActiveRowIndex)


            If READ_PFK3452(KEY_Autokey) Then
                D3452.CheckPurchasing = "4"

                Call REWRITE_PFK3452(D3452)
                setData(Vs1, getColumIndex(Vs1, "Sel_OrderDetailStatus"), Vs1.ActiveSheet.ActiveRowIndex, "Cancel")

                D9700_CLEAR()
                D9700.ActionName = D3452.Autokey & "2. CANCEL - PKO NO"
                D9700.DateCreate = Pub.DAT
                D9700.UserCode = Pub.SAW
                D9700.FormName = "PFP34510"
                D9700.Reference = D3452.Autokey

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

            End If

        Catch ex As Exception

        End Try


    End Sub

    Private Sub MAIN_JOB04()
        Try
            Dim KEY_Autokey As String

            KEY_Autokey = getData(Vs1, getColumIndex(Vs1, "KEY_Autokey"), Vs1.ActiveSheet.ActiveRowIndex)


            If READ_PFK3452(KEY_Autokey) Then
                D3452.CheckPurchasing = "5"

                Call REWRITE_PFK3452(D3452)
                setData(Vs1, getColumIndex(Vs1, "Sel_OrderDetailStatus"), Vs1.ActiveSheet.ActiveRowIndex, "Revise")

                D9700_CLEAR()
                D9700.ActionName = D3452.Autokey & "3. REVISE - PKO NO"
                D9700.DateCreate = Pub.DAT
                D9700.UserCode = Pub.SAW
                D9700.FormName = "PFP34510"
                D9700.Reference = D3452.Autokey

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

            End If

        Catch ex As Exception

        End Try
    End Sub


    Private Sub MAIN_JOB05()
        Try
            Dim KEY_Autokey As String

            KEY_Autokey = getData(Vs1, getColumIndex(Vs1, "KEY_Autokey"), Vs1.ActiveSheet.ActiveRowIndex)

            If READ_PFK3452(KEY_Autokey) Then


                If D3452.CheckPurchasing = "2" Then
                    Dim str As String = MsgBoxP("This Barcode was complete. Do you want un-complete this?", vbYesNo)
                    If str <> vbYes Then Exit Sub

                    D3452.CheckPurchasing = "3"

                    Call REWRITE_PFK3452(D3452)

                    If PrcExeNoError("USP_PFK3452_UN_CLOSSING_ALL_PROCESS", cn, KEY_Autokey) Then
                        setData(Vs1, getColumIndex(Vs1, "Sel_OrderDetailStatus"), Vs1.ActiveSheet.ActiveRowIndex, "Process")
                    End If

                Else

                    D3452.CheckPurchasing = "2"

                    Call REWRITE_PFK3452(D3452)

                    If PrcExeNoError("USP_PFK3452_CLOSSING_ALL_PROCESS", cn, KEY_Autokey) Then
                        setData(Vs1, getColumIndex(Vs1, "Sel_OrderDetailStatus"), Vs1.ActiveSheet.ActiveRowIndex, "Complete")
                    End If
                End If

                D9700_CLEAR()
                D9700.ActionName = D3452.Autokey & "4. COMPLETE - PKO NO"
                D9700.DateCreate = Pub.DAT
                D9700.UserCode = Pub.SAW
                D9700.FormName = "PFP34510"
                D9700.Reference = D3452.Autokey

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

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub MAIN_JOB06()
        Dim str As String = MsgBoxP("Do you want to update it?", vbYesNo)
        If str <> vbYes Then Exit Sub

        Dim KEY_Autokey As String
        KEY_Autokey = getData(Vs1, getColumIndex(Vs1, "KEY_Autokey"), Vs1.ActiveSheet.ActiveRowIndex)

        If READ_PFK3452(KEY_Autokey) Then
            Dim MSG_qty As String = InputBox("Pls input updated qty > 0 ?")

            If IsNumeric(MSG_qty) And CIntp(MSG_qty) > 0 Then
                D3452.QtyPurchasing = CIntp(MSG_qty)
                Call REWRITE_PFK3452(D3452)

                setData(Vs1, getColumIndex(Vs1, "QtyPurchasing"), Vs1.ActiveSheet.ActiveRowIndex, CIntp(MSG_qty))

                D9700_CLEAR()
                D9700.ActionName = D3452.Autokey & "5. UPDATE QTY - PKO NO"
                D9700.DateCreate = Pub.DAT
                D9700.UserCode = Pub.SAW
                D9700.FormName = "PFP34510"
                D9700.Reference = D3452.Autokey

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


            End If
        End If

    End Sub


    Private Sub MAIN_JOB07()

        Dim str As String = MsgBoxP("Do you want to delete it?", vbYesNo)
        If str <> vbYes Then Exit Sub

        Dim KEY_Autokey As String
        KEY_Autokey = getData(Vs1, getColumIndex(Vs1, "KEY_Autokey"), Vs1.ActiveSheet.ActiveRowIndex)

        If READ_PFK3452(KEY_Autokey) Then
            If D3452.QtyInbound > 0 Or D3452.QtyPacking > 0 Or D3452.QtyOutbound > 0 Then MsgBoxEx("Already data!") : Exit Sub

            Call DELETE_PFK3452(D3452)
            SPR_CLEAR(Vs1, Vs1.ActiveSheet.ActiveRowIndex, 0, Vs1.ActiveSheet.ActiveRowIndex, Vs1.ActiveSheet.ColumnCount - 1)


            D9700_CLEAR()
            D9700.ActionName = D3452.Autokey & "6. DELETE - PKO NO"
            D9700.DateCreate = Pub.DAT
            D9700.UserCode = Pub.SAW
            D9700.FormName = "PFP34510"
            D9700.Reference = D3452.Autokey

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
        End If

    End Sub

    Private Sub MAIN_JOB08()
        Dim str As String = MsgBoxP("Do you want to add more on it?", vbYesNo)
        If str <> vbYes Then Exit Sub

        Dim KEY_Autokey As String
        KEY_Autokey = getData(Vs1, getColumIndex(Vs1, "KEY_Autokey"), Vs1.ActiveSheet.ActiveRowIndex)

        If READ_PFK3452(KEY_Autokey) Then
            Dim QtyPurchasing As String
            Dim PKO As String
            QtyPurchasing = InputBox("Input Qty !")
            If IsNumeric(QtyPurchasing) = False And CIntp(QtyPurchasing) > 0 Then MsgBoxP("Wrong format!") : Exit Sub

            PKO = InputBox("Input PKO Name !")

            If FormatCut(PKO) = "" Then MsgBoxP("Wrong format PKO !") : Exit Sub

            Call PrcExeNoError("EXP_PFK3451_AUTOKEY_ADD", cn, KEY_Autokey, PKO, QtyPurchasing)

            D9700_CLEAR()
            D9700.ActionName = D3452.Autokey & "7. ADD - PKO NO"
            D9700.DateCreate = Pub.DAT
            D9700.UserCode = Pub.SAW
            D9700.FormName = "PFP34510"
            D9700.Reference = D3452.Autokey

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

            Call DATA_SEARCH_VS1()
        End If
    End Sub

    Private Sub MAIN_JOB10()


    End Sub
#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS1(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS1 = False
        Vs1.Enabled = False

        DS1 = PrcDS("USP_PFP34510_SEARCH_VS1_DETAIL", cn, txt_cdSite.Code, txt_CustomerCode.Code, txt_PackingBatch.Data, _
            txt_PONO.Data, txt_PKO.Data, txt_Line.Data, txt_Article.Data, txt_ColorName.Data, txt_SLno.Data, chk_POno.CheckState, chk_POYes.CheckState)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs1, DS1, "USP_PFP34510_SEARCH_VS1_DETAIL", "Vs1")
            Vs1.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "USP_PFP34510_SEARCH_VS1_DETAIL", "Vs1")



        DATA_SEARCH_VS1 = True

        Vs1.Enabled = True


    End Function

    Private Function LINE_MOVE_DISPLAY01() As Boolean
        LINE_MOVE_DISPLAY01 = False
        Dim FactOrderNo As String
        Dim FactOrderSeq As String

        FactOrderNo = getData(Vs1, getColumIndex(Vs1, "FactOrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
        FactOrderSeq = getData(Vs1, getColumIndex(Vs1, "FactOrderSeq"), Vs1.ActiveSheet.ActiveRowIndex)

        Try
            DS1 = PrcDS("USP_PFP34510_SEARCH_VS1_LINE", cn, FactOrderNo,
                                                        FactOrderSeq)

            If GetDsRc(DS1) = 0 Then
                Vs1.Enabled = True
                Exit Function
            End If

            READ_SPREAD(Vs1, DS1, "USP_PFP34510_SEARCH_VS1", "Vs1", Vs1.ActiveSheet.ActiveRowIndex)

            Vs1.Enabled = True
            LINE_MOVE_DISPLAY01 = True
        Catch ex As Exception
            MsgBoxP("LINE_MOVE_DISPLAY01")
        End Try
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
            MAIN_JOB10()
        End If
    End Sub


    Private Sub Vs1_CellClickCellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column

        If e.Column = getColumIndex(Vs1, "TIVE30") Or e.Column = getColumIndex(Vs1, "DTEX30") Then
            Vs1.ActiveSheet.OperationMode = OperationMode.Normal
        Else
            Vs1.ActiveSheet.OperationMode = OperationMode.SingleSelect
        End If
    End Sub

    Private Sub vS1_Change(sender As Object, e As ChangeEventArgs) Handles Vs1.Change
        Dim Autokey As String
        Dim DESTINATION As String
        Dim LSDTDATE As String

        Autokey = getData(Vs1, getColumIndex(Vs1, "KEY_Autokey"), Vs1.ActiveSheet.ActiveRowIndex)

        If e.Column = getColumIndex(Vs1, "TIVE30") Then
            DESTINATION = getData(Vs1, getColumIndex(Vs1, "TIVE30"), Vs1.ActiveSheet.ActiveRowIndex)

            If READ_PFK7171_NAME("201", DESTINATION) Then
                If READ_PFK3452_AUTOKEY(Autokey) Then
                    D3452.TIVE30 = D7171.BasicName
                    D3452.DTIV30 = D7171.NameSimply
                    Call REWRITE_PFK3452(D3452)
                End If

            End If


        End If

        If e.Column = getColumIndex(Vs1, "DTEX30") Then
            LSDTDATE = getData(Vs1, getColumIndex(Vs1, "DTEX30"), Vs1.ActiveSheet.ActiveRowIndex)

            If IsDate(LSDTDATE) = True Then
                If READ_PFK3452_AUTOKEY(Autokey) Then
                    D3452.DTEX30 = LSDTDATE
                    Call REWRITE_PFK3452(D3452)
                End If
            End If
        End If
    End Sub
    Private Sub vS4_Change(sender As Object, e As ChangeEventArgs) Handles vS4.Change

        Select Case vS4.ActiveSheet.ActiveRowIndex

            Case "3"
                Dim sothung As Integer
                Dim Qtyorder As Integer
                Dim soluong1thung As Integer

                Qtyorder = getData(vS4, vS4.ActiveSheet.ActiveColumnIndex, "5")
                soluong1thung = getData(vS4, vS4.ActiveSheet.ActiveColumnIndex, "3")

                If CHK_Solid.Checked = True Then

                    If soluong1thung <> "0" Then

                        sothung = Math.Floor(Qtyorder / soluong1thung)

                    Else
                        Call MsgBox("Input Qty 1 box!")

                    End If

                    setData(vS4, vS4.ActiveSheet.ActiveColumnIndex, "4", sothung)

                Else


                    If soluong1thung <> "0" Then

                        sothung = txt_BoxQty.Value

                    Else
                        Call MsgBox("Input Qty 1 box!")

                    End If

                    setData(vS4, vS4.ActiveSheet.ActiveColumnIndex, "4", sothung)

                End If

        End Select

    End Sub

    Private Sub vS5_KeyDown(sender As Object, e As KeyEventArgs) Handles vS5.KeyDown

        Select Case e.KeyCode

            Case Keys.Delete

                Dim str As String = MsgBoxP("Do you want to delete it?", vbYesNo)

                If str <> vbYes Then Exit Sub

                Dim autokey As Integer

                autokey = CInt(getData(vS5, getColumIndex(vS5, "Key_autokey"), vS5.ActiveSheet.ActiveRowIndex))

                If READ_PFK4951_AUTOKEY(autokey) = True Then Call MsgBox("Already Make Loading Plan!") : Exit Sub

                If autokey <> "0" Then

                    If READ_PFK4958(autokey) = True Then
                        'If D4958.Printed = "1" Then Call MsgBox("Already print can't delete barcode!") : Exit Sub

                        W4958 = D4958

                        W4958.CheckUse = "2"

                        ' Call REWRITE_PFK4958(W4958)  'Jun change for P.423, P.408 2018/11/26 05:56 PM

                        If READ_PFK2656_BarcodePacking(W4958.Autokey) = True Then Call MsgBox("Already outbound can't delete barcode!") : Exit Sub

                        Call DELETE_PFK2651_Autokey_4958(W4958.Autokey) ' 'Jun new for P.534 2018/01/04 09:43 AM
                        D9700_CLEAR()
                        D9700.ActionName = "0cmd_DELETE"
                        D9700.DateCreate = Pub.DAT
                        D9700.UserCode = Pub.SAW
                        D9700.FormName = "ISUD2651"
                        D9700.Reference = W4958.Autokey

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

                        Call DELETE_PFK4958(W4958)

                        D9700_CLEAR()
                        D9700.ActionName = "0cmd_DELETE"
                        D9700.DateCreate = Pub.DAT
                        D9700.UserCode = Pub.SAW
                        D9700.FormName = Me.FindForm.Name
                        D9700.Reference = W4958.Autokey

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

                        SPR_DEL(vS5, 0, vS5.ActiveSheet.ActiveRowIndex)
                    End If


                End If

        End Select

        vS5.Focus()

    End Sub


    Private Sub CHK_Solid_CheckedChanged(sender As Object, e As EventArgs) Handles CHK_Solid.CheckedChanged

        If CHK_Solid.Checked = True Then txt_BoxQty.Visible = False : lbe_Box.Visible = False
        If CHK_Assort.Checked = True Then txt_BoxQty.Visible = True : lbe_Box.Visible = True

    End Sub

#End Region

#Region "Fuction"

    Private Function DATA_SEARCH_VS2() As Boolean
        DATA_SEARCH_VS2 = False

        Dim PKONO As String
        Dim OrderNo As String
        Dim OrderSeq As String

        Dim FactOrderNo As String
        Dim FactOrderSeq As String

        FactOrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
        FactOrderSeq = getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderSeq"), Vs1.ActiveSheet.ActiveRowIndex)

        OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
        OrderSeq = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex)

        PKONO = getData(Vs1, getColumIndex(Vs1, "PKO"), Vs1.ActiveSheet.ActiveRowIndex)

        Try
            If chk_Packing.Checked = False Then
                DS1 = PrcDS("USP_PFP34510_SEARCH_VS2", cn, FactOrderNo, FactOrderSeq, PKONO)


                If GetDsRc(DS1) = 0 Then
                    SPR_SET(vS2, , , , OperationMode.Normal)
                    SPR_PRO(vS2, DS1, "USP_PFP34510_SEARCH_vS2", "vS2")

                    vS2.ActiveSheet.RowCount = 1
                    vS2.Enabled = True

                    Exit Function
                End If

                SPR_SET(vS2, , , , OperationMode.Normal)
                SPR_PRO(vS2, DS1, "USP_PFP34510_SEARCH_vS2", "vS2")


                DATA_SEARCH_VS2 = True
            Else
                DS1 = PrcDS("USP_PFP34510_SEARCH_VS2_GROUP", cn, FactOrderNo, FactOrderSeq, PKONO)


                If GetDsRc(DS1) = 0 Then
                    SPR_SET(vS2, , , , OperationMode.Normal)
                    SPR_PRO(vS2, DS1, "USP_PFP34510_SEARCH_VS2_GROUP", "vS2")

                    vS2.ActiveSheet.RowCount = 1
                    vS2.Enabled = True

                    Exit Function
                End If

                SPR_SET(vS2, , , , OperationMode.Normal)
                SPR_PRO(vS2, DS1, "USP_PFP34510_SEARCH_VS2_GROUP", "vS2")

                DATA_SEARCH_VS2 = True

            End If
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_vS2")
        End Try
    End Function

    Private Function DATA_SEARCH_VS3() As Boolean
        DATA_SEARCH_VS3 = False

        Dim CartonCode As String
        Dim OrderNo As String
        Dim OrderSeq As String

        Dim FactOrderNo As String
        Dim FactOrderSeq As String

        vS4.ActiveSheet.RowCount = 0

        FactOrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
        FactOrderSeq = getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderSeq"), Vs1.ActiveSheet.ActiveRowIndex)

        OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
        OrderSeq = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex)

        CartonCode = txt_CartonCode.Code

        Try
            DS1 = PrcDS("USP_PFP34510_SEARCH_VS3", cn, FactOrderNo, FactOrderSeq, CartonCode)


            If GetDsRc(DS1) = 0 Then
                SPR_SET(vS3, , , , OperationMode.Normal)
                SPR_PRO(vS3, DS1, "USP_PFP34510_SEARCH_VS3", "VS3")

                vS3.ActiveSheet.RowCount = 0
                vS3.Enabled = True

                Exit Function
            End If

            SPR_PRO(vS3, DS1, "USP_PFP34510_SEARCH_VS3", "VS3")

            DATA_SEARCH_VS3 = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS3")
        End Try
    End Function

    Private Function DATA_SEARCH_VS4() As Boolean
        DATA_SEARCH_VS4 = False

        Dim PKONO As String
        Dim OrderNo As String
        Dim OrderSeq As String

        Dim FactOrderNo As String
        Dim FactOrderSeq As String
        Dim Autokey As String

        vS4.ActiveSheet.RowCount = 0

        FactOrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
        FactOrderSeq = getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderSeq"), Vs1.ActiveSheet.ActiveRowIndex)

        OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
        OrderSeq = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex)

        Autokey = getData(Vs1, getColumIndex(Vs1, "KEY_Autokey"), Vs1.ActiveSheet.ActiveRowIndex)
        PKONO = getData(Vs1, getColumIndex(Vs1, "PKO"), Vs1.ActiveSheet.ActiveRowIndex)

        Try
            DS1 = PrcDS("USP_PFP34510_SEARCH_VS4", cn, FactOrderNo, FactOrderSeq, PKONO, txt_CartonCode.Code, Autokey)

            If GetDsRc(DS1) = 0 Then
                SPR_SET(vS4, , , , OperationMode.Normal)
                SPR_PRO(vS4, DS1, "USP_PFP34510_SEARCH_VS4", "VS4")

                vS4.ActiveSheet.RowCount = 0
                vS4.Enabled = True

                Exit Function
            End If

            SPR_PRO(vS4, DS1, "USP_PFP34510_SEARCH_VS4", "VS4")

            vS4.ActiveSheet.Rows(0).Locked = True
            vS4.ActiveSheet.Rows(1).Locked = True
            vS4.ActiveSheet.Rows(2).Locked = True

            vS4.ActiveSheet.Rows(3).BackColor = Color.LightYellow
            vS4.ActiveSheet.Rows(4).BackColor = Color.LightSkyBlue


            setData(vS4, getColumIndex(vS4, "SizeQty01"), 3, getData(vS3, getColumIndex(vS3, "CTQty"), vS3.ActiveSheet.ActiveRowIndex))

            DATA_SEARCH_VS4 = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS4")
        End Try
    End Function

    Private Function DATA_SEARCH_VS5() As Boolean
        DATA_SEARCH_VS5 = False

        Dim PKONO As String
        Dim OrderNo As String
        Dim OrderSeq As String

        Dim FactOrderNo As String
        Dim FactOrderSeq As String

        FactOrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
        FactOrderSeq = getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderSeq"), Vs1.ActiveSheet.ActiveRowIndex)

        OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
        OrderSeq = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex)

        PKONO = getData(Vs1, getColumIndex(Vs1, "PKO"), Vs1.ActiveSheet.ActiveRowIndex)

        Try

            DS1 = PrcDS("USP_PFP34510_SEARCH_VS5", cn, FactOrderNo, FactOrderSeq)

            If GetDsRc(DS1) = 0 Then
                SPR_SET(vS5, , , , OperationMode.Normal)
                SPR_PRO(vS5, DS1, "USP_PFP34510_SEARCH_VS5", "vS5")

                vS5.ActiveSheet.RowCount = 1
                vS5.Enabled = True

                Exit Function
            End If

            SPR_SET(vS5, , , , OperationMode.Normal)
            SPR_PRO(vS5, DS1, "USP_PFP34510_SEARCH_VS5", "vS5")

            Call VsSizeRangeNew_one(vS5, "USP_VS_SIZERANGE_ORDERBASE", getColumIndex(vS5, "SizeQty01"), OrderNo, OrderSeq)

            DATA_SEARCH_VS5 = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS5")
        End Try

    End Function

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        If e.ColumnHeader = True Then Exit Sub
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.AddSelection(e.Row, e.Column, 1, 1)
    End Sub

    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        Call DATA_SEARCH_VS2()
    End Sub

    Private Sub vS1_GotFocus(sender As Object, e As EventArgs) Handles Vs1.GotFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, True, False)

        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False
    End Sub
    Private Sub txt_GNAME_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Enter : cmd_SEARCH.Focus()
        End Select
    End Sub
    Private Sub vS1_LostFocus(sender As Object, e As EventArgs) Handles Vs1.LostFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False)

    End Sub
    Private Sub chk_FSEL_Click(sender As Object, e As EventArgs) Handles chk_FSEL.CheckedChanged
        If chk_FSEL.CheckState = 0 Then                  '
            chk_FSEL.BackColor = clrUncheck
            chk_FSEL.ForeColor = Color.Black

            chk_FSEL.Text = WordConv("OPEN")
            ssp_WHERE.Visible = False
        Else                                        '
            chk_FSEL.BackColor = clrCheck
            chk_FSEL.ForeColor = Color.Black

            chk_FSEL.Text = WordConv("CLOSE")
            ssp_WHERE.Visible = True
        End If
    End Sub
    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click

        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False

        Call DATA_SEARCH_VS1()

    End Sub
    Private Sub Cms_1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_1.ItemClicked
        If Cms_1.Items(0).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB01()

        ElseIf Cms_1.Items(1).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB02()

        ElseIf Cms_1.Items(2).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB03()

        ElseIf Cms_1.Items(3).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB04()

        ElseIf Cms_1.Items(4).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB05()


        ElseIf Cms_1.Items(6).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB06()

        ElseIf Cms_1.Items(7).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB07()

        ElseIf Cms_1.Items(8).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB08()

        End If

    End Sub

    Private Sub txt_CartonCode_txtTextChange(sender As Object, e As EventArgs) Handles txt_CartonCode.txtTextChange


    End Sub

    Private Sub txt_CartonCode_Load(sender As Object, e As EventArgs) Handles txt_CartonCode.btnTitleClick
        Try

        Catch ex As Exception

        End Try


    End Sub

    Private Sub vS2_CellClick(sender As Object, e As CellClickEventArgs) Handles vS2.CellClick

    End Sub

    Private Sub vS2_ButtonClicked(sender As Object, e As EditorNotifyEventArgs) Handles vS2.ButtonClicked
        If e.Column = getColumIndex(vS2, "CLcdCartonCode") Then
            If HLP7210A.Link_HLP7210A(getData(Vs1, getColumIndex(Vs1, "CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex), "") = False Then Exit Sub

            D7210.CartonCode = hlp0000SeVaTt

            Dim i As Integer

            hlp0000SeVaTt = ""
            hlp0000SeVa = ""
            hlp0000SeVaTt1 = ""
            txt_CartonCode.Code = D7210.CartonCode

            If READ_PFK7210(txt_CartonCode.Code) = True Then

                For i = 0 To vS2.ActiveSheet.RowCount - 1
                    If getDataM(vS2, getColumIndex(vS2, "dchk"), i) = "1" Then

                        txt_CartonCode.Data = D7210.CartonType
                        txt_CartonCode.Code = D7210.CartonCode

                        txt_CBM.Data = D7210.CBM
                        txt_CTHeight.Data = D7210.CTHeight
                        txt_CTWidth.Data = D7210.CTWidth
                        txt_CTNetWeight.Data = D7210.CTNetWeight
                        txt_CTGrossWeight.Data = D7210.CTNetWeight

                        txt_CTLength.Data = D7210.CTLength

                        setData(vS2, getColumIndex(vS2, "CartonType"), i, D7210.CartonType)
                        setData(vS2, getColumIndex(vS2, "CartonCode"), i, D7210.CartonCode)

                        If READ_PFK4958(getDataM(vS2, getColumIndex(vS2, "KEY_Autokey"), i)) Then
                            D4958.CartonCode = D7210.CartonCode
                            D4958.PackingCMB = D7210.CBM
                            D4958.PackingNW = D7210.CTNetWeight

                            D4958.DatePacking = Pub.DAT
                            D4958.SizeGroup = txt_SizeGroup.Data

                            If REWRITE_PFK4958(D4958) Then
                                Call PrcExeNoError("EXP_CLOSSING_PFK4958_CBM_AUTOKEY", cn, D4958.Autokey)

                                If READ_PFK4958(getDataM(vS2, getColumIndex(vS2, "KEY_Autokey"), i)) Then
                                    setData(vS2, getColumIndex(vS2, "PackingCMB"), i, D4958.PackingCMB)
                                    setData(vS2, getColumIndex(vS2, "PackingGW"), i, D4958.PackingGW)
                                    setData(vS2, getColumIndex(vS2, "PackingNW"), i, D4958.PackingNW)
                                    setData(vS2, getColumIndex(vS2, "QtyPacking"), i, D4958.QtyPacking)

                                    setData(vS2, getColumIndex(vS2, "CTNetWeight"), i, D7210.CTNetWeight)

                                End If

                            End If
                        End If

                    End If


                Next
            End If

        End If


    End Sub

    Private Sub CHK_dE_CheckedChanged(sender As Object, e As EventArgs) Handles CHK_dE.CheckedChanged

        If CHK_dE.Checked = True Then
            'If txt_CustomerCode.Code = "" Then MsgBoxEx("Please Chose Customer!") : CHK_dE.Checked = False : Exit Sub

            Dim K7214_Article As String
            Dim K7214_CustomerCode As String
            Dim K7214_cdSeason As String

            K7214_cdSeason = txt_cdSite.Code
            K7214_CustomerCode = getData(Vs1, getColumIndex(Vs1, "CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex)
            K7214_Article = getData(Vs1, getColumIndex(Vs1, "Article"), Vs1.ActiveSheet.ActiveRowIndex)

            DS1 = PrcDS("USP_PFP34510_SEARCH_Article", cn, K7214_Article, K7214_CustomerCode, K7214_cdSeason)

            If GetDsRc(DS1) = 0 Then
                MsgBoxP("No Article Weight for this " & K7214_Article)
                CHK_dE.Checked = False
                Exit Sub
            End If

            pnl_Working.Visible = True
            Call DATA_SEARCH_VS3()

            Call DATA_SEARCH_VS4()
            Call DATA_SEARCH_VS5()

        Else
            pnl_Working.Visible = False
            SPR_CLEAR(vS3)
            SPR_CLEAR(vS4)
            SPR_CLEAR(vS5)

        End If
    End Sub


    Private Sub txt_UpdateCalculation2_Click(sender As Object, e As EventArgs) Handles txt_UpdateCalculation2.Click

        Dim i As Integer
        Dim j As Integer

        Dim CnF As Integer
        Dim PKONO As String
        Dim PackingBatch As String
        Dim CartonCode As String
        Dim TotalQty As Integer = "0"

        Dim FactOrderNo As String
        Dim FactOrderSeq As String
        Dim OrderNo As String
        Dim OrderNoSeq As String
        Dim Article As String

        If getData(Vs1, getColumIndex(Vs1, "CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex) <> "000001" Then Exit Sub

        PKONO = getData(Vs1, getColumIndex(Vs1, "PKO"), Vs1.ActiveSheet.ActiveRowIndex)
        If Trim(PKONO) = "" Then PKONO = getData(Vs1, getColumIndex(Vs1, "SlNo"), Vs1.ActiveSheet.ActiveRowIndex)
        PackingBatch = getData(Vs1, getColumIndex(Vs1, "PackingBatch"), Vs1.ActiveSheet.ActiveRowIndex)

        FactOrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
        FactOrderSeq = getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderSeq"), Vs1.ActiveSheet.ActiveRowIndex)
        OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
        OrderNoSeq = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex)

        Article = getData(Vs1, getColumIndex(Vs1, "Article"), Vs1.ActiveSheet.ActiveRowIndex)


        If READ_PFK4958_MAX_CT(FactOrderNo, FactOrderSeq, PKONO) Then
            CnF = D4958.CartonNo
        Else
            CnF = 0
        End If

        Try

            Call KEY_COUNT()

            Dim xrow As Integer
            xrow = vS2.ActiveSheet.ActiveRowIndex


            For i = 0 To vS2.ActiveSheet.RowCount - 1

                Dim CartonType As String

                If getDataM(vS2, getColumIndex(vS2, "DCHK"), i) = "1" Then

                    If CDecp(getData(vS2, getColumIndex(vS2, "CartonNo"), i)) > 0 Then

                        If getData(vS2, getColumIndex(vS2, "CartonType"), i) <> "" Then

                            CartonType = getData(vS2, getColumIndex(vS2, "CartonType"), i)

                            If READ_PFK7210_NAME(CartonType) = True Then
                                CartonCode = D7210.CartonCode
                            Else
                                Call MsgBoxP(" Wrong carton Type! Sai ma thung carton") : Exit Sub
                            End If

                        End If

                        If READ_PFK4958(CDecp(getData(vS2, getColumIndex(vS2, "KEY_Autokey"), i))) = True Then

                            W4958 = D4958
                            W4958.CartonCode = CartonCode
                            If REWRITE_PFK4958(W4958) Then

                                W4958.QtyPrs = 0
                                W4958.SizeQty01 = 0
                                W4958.SizeQty02 = 0
                                W4958.SizeQty03 = 0
                                W4958.SizeQty04 = 0
                                W4958.SizeQty05 = 0
                                W4958.SizeQty06 = 0
                                W4958.SizeQty07 = 0
                                W4958.SizeQty08 = 0
                                W4958.SizeQty09 = 0
                                W4958.SizeQty10 = 0
                                W4958.SizeQty11 = 0
                                W4958.SizeQty12 = 0
                                W4958.SizeQty13 = 0
                                W4958.SizeQty14 = 0
                                W4958.SizeQty15 = 0
                                W4958.SizeQty16 = 0
                                W4958.SizeQty17 = 0
                                W4958.SizeQty18 = 0
                                W4958.SizeQty19 = 0
                                W4958.SizeQty20 = 0
                                W4958.SizeQty21 = 0
                                W4958.SizeQty22 = 0
                                W4958.SizeQty23 = 0
                                W4958.SizeQty24 = 0
                                W4958.SizeQty25 = 0
                                W4958.SizeQty26 = 0
                                W4958.SizeQty27 = 0
                                W4958.SizeQty28 = 0
                                W4958.SizeQty29 = 0
                                W4958.SizeQty30 = 0
                                W4958.PackingCMB = 0
                                W4958.PackingGW = 0
                                W4958.PackingNW = 0
                                W4958.QtyPacking = 0
                                W4958.QtyLoading = 0

                            End If
                        End If
                    End If
                End If

            Next i

            'If PrcExeNoError("EXP_CLOSSING_PFK4958", cn, D4958.PackingBatch, D4958.PackingBatch, D4958.PKONO) Then
            '    Call DATA_SEARCH_VS2()
            'End If

            D4958.FactOrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
            D4958.FactOrderSeq = getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderSeq"), Vs1.ActiveSheet.ActiveRowIndex)
            D4958.PKONO = getData(Vs1, getColumIndex(Vs1, "PKO"), Vs1.ActiveSheet.ActiveRowIndex)


            If PrcExeNoError("EXP_CLOSSING_PFK4958_CBM", cn, D4958.FactOrderNo, D4958.FactOrderSeq, D4958.PKONO) Then
                Call DATA_SEARCH_VS2()
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub txt_UpdateCalculation_Click(sender As Object, e As EventArgs) Handles txt_UpdateCalculation.Click

        Dim i As Integer
        Dim j As Integer

        Dim CnF As Integer
        Dim PKONO As String
        Dim PackingBatch As String
        Dim CartonCode As String
        Dim TotalQty As Integer = "0"

        Dim FactOrderNo As String
        Dim FactOrderSeq As String
        Dim OrderNo As String
        Dim OrderNoSeq As String
        Dim Article As String

        PKONO = getData(Vs1, getColumIndex(Vs1, "PKO"), Vs1.ActiveSheet.ActiveRowIndex)
        If Trim(PKONO) = "" Then PKONO = getData(Vs1, getColumIndex(Vs1, "SlNo"), Vs1.ActiveSheet.ActiveRowIndex)
        PackingBatch = getData(Vs1, getColumIndex(Vs1, "PackingBatch"), Vs1.ActiveSheet.ActiveRowIndex)

        FactOrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
        FactOrderSeq = getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderSeq"), Vs1.ActiveSheet.ActiveRowIndex)
        OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
        OrderNoSeq = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex)

        Article = getData(Vs1, getColumIndex(Vs1, "Article"), Vs1.ActiveSheet.ActiveRowIndex)

        Dim KEY_Autokey As String

        KEY_Autokey = getData(Vs1, getColumIndex(Vs1, "KEY_Autokey"), Vs1.ActiveSheet.ActiveRowIndex)


        If READ_PFK4958_MAX_CT(FactOrderNo, FactOrderSeq, PKONO) Then
            CnF = D4958.CartonNo
        Else
            CnF = 0
        End If

        Try

            Call KEY_COUNT()

            Dim xrow As Integer
            xrow = vS3.ActiveSheet.ActiveRowIndex


            If CHK_Solid.Checked = True Then

                For i = 0 To vS4.ActiveSheet.ColumnCount - 1

                    If CDecp(getData(vS4, i, 4)) > 0 Then

                        Call KEY_COUNT()
                        D4958.PackingBatch = W4958.PackingBatch

                        For j = 1 To CDecp(getData(vS4, i, 4))
                            If FormatCut(PKONO) = "" Then PKONO = getData(Vs1, getColumIndex(Vs1, "slno"), Vs1.ActiveSheet.ActiveRowIndex)

                            SQL = " SELECT isnull(MAX(K4958_CartonNo),0) AS CartonNo FROM PFK4958 "
                            SQL = SQL & " WHERE K4958_AutoKey_K3422	 =  '" & KEY_Autokey & "'  "


                            cmd = New SqlClient.SqlCommand(SQL, cn)
                            rd = cmd.ExecuteReader
                            rd.Read()

                            If rd.HasRows = False Then
                                D4958.CartonNo = 1
                            Else
                                D4958.CartonNo = rd!CartonNo + 1
                            End If
                            rd.Close()

                            D4958.AutoKey_K3422 = KEY_Autokey
                            D4958.CartonCode = CartonCode
                            D4958.PackingCMB = CDecp(getData(vS3, getColumIndex(vS3, "PackingCMB"), xrow))
                            D4958.PackingNW = CDecp(getData(vS3, getColumIndex(vS3, "PackingNW"), xrow))
                            D4958.PackingGW = CDecp(getData(vS3, getColumIndex(vS3, "PackingGW"), xrow))

                            D4958.DatePacking = Pub.DAT
                            D4958.SizeGroup = getData(vS3, getColumIndex(vS3, "SizeGroup"), xrow)

                            D4958.CustomerCode = getData(Vs1, getColumIndex(Vs1, "CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex)
                            D4958.cdSeason = txt_cdSite.Code
                            D4958.seSeason = ListCode("Season")

                            D4958.QtyPacking = CDecp(getData(vS4, i, 3))

                            D4958.SizeQty01 = 0
                            D4958.SizeQty02 = 0
                            D4958.SizeQty03 = 0
                            D4958.SizeQty04 = 0
                            D4958.SizeQty05 = 0
                            D4958.SizeQty06 = 0
                            D4958.SizeQty07 = 0
                            D4958.SizeQty08 = 0
                            D4958.SizeQty09 = 0
                            D4958.SizeQty10 = 0
                            D4958.SizeQty11 = 0
                            D4958.SizeQty12 = 0
                            D4958.SizeQty13 = 0
                            D4958.SizeQty14 = 0
                            D4958.SizeQty15 = 0
                            D4958.SizeQty16 = 0
                            D4958.SizeQty17 = 0
                            D4958.SizeQty18 = 0
                            D4958.SizeQty19 = 0
                            D4958.SizeQty20 = 0
                            D4958.SizeQty21 = 0
                            D4958.SizeQty22 = 0
                            D4958.SizeQty23 = 0
                            D4958.SizeQty24 = 0
                            D4958.SizeQty25 = 0
                            D4958.SizeQty26 = 0
                            D4958.SizeQty27 = 0
                            D4958.SizeQty28 = 0
                            D4958.SizeQty29 = 0
                            D4958.SizeQty30 = 0

                            If getColumIndex(vS4, "SizeQty01") = i Then D4958.SizeQty01 = CDecp(getData(vS4, i, 3)) : GoTo next1
                            If getColumIndex(vS4, "SizeQty02") = i Then D4958.SizeQty02 = CDecp(getData(vS4, i, 3)) : GoTo next1
                            If getColumIndex(vS4, "SizeQty03") = i Then D4958.SizeQty03 = CDecp(getData(vS4, i, 3)) : GoTo next1
                            If getColumIndex(vS4, "SizeQty04") = i Then D4958.SizeQty04 = CDecp(getData(vS4, i, 3)) : GoTo next1
                            If getColumIndex(vS4, "SizeQty05") = i Then D4958.SizeQty05 = CDecp(getData(vS4, i, 3)) : GoTo next1
                            If getColumIndex(vS4, "SizeQty06") = i Then D4958.SizeQty06 = CDecp(getData(vS4, i, 3)) : GoTo next1
                            If getColumIndex(vS4, "SizeQty07") = i Then D4958.SizeQty07 = CDecp(getData(vS4, i, 3)) : GoTo next1
                            If getColumIndex(vS4, "SizeQty08") = i Then D4958.SizeQty08 = CDecp(getData(vS4, i, 3)) : GoTo next1
                            If getColumIndex(vS4, "SizeQty09") = i Then D4958.SizeQty09 = CDecp(getData(vS4, i, 3)) : GoTo next1
                            If getColumIndex(vS4, "SizeQty10") = i Then D4958.SizeQty10 = CDecp(getData(vS4, i, 3)) : GoTo next1
                            If getColumIndex(vS4, "SizeQty11") = i Then D4958.SizeQty11 = CDecp(getData(vS4, i, 3)) : GoTo next1
                            If getColumIndex(vS4, "SizeQty12") = i Then D4958.SizeQty12 = CDecp(getData(vS4, i, 3)) : GoTo next1
                            If getColumIndex(vS4, "SizeQty13") = i Then D4958.SizeQty13 = CDecp(getData(vS4, i, 3)) : GoTo next1
                            If getColumIndex(vS4, "SizeQty14") = i Then D4958.SizeQty14 = CDecp(getData(vS4, i, 3)) : GoTo next1
                            If getColumIndex(vS4, "SizeQty15") = i Then D4958.SizeQty15 = CDecp(getData(vS4, i, 3)) : GoTo next1
                            If getColumIndex(vS4, "SizeQty16") = i Then D4958.SizeQty16 = CDecp(getData(vS4, i, 3)) : GoTo next1
                            If getColumIndex(vS4, "SizeQty17") = i Then D4958.SizeQty17 = CDecp(getData(vS4, i, 3)) : GoTo next1
                            If getColumIndex(vS4, "SizeQty18") = i Then D4958.SizeQty18 = CDecp(getData(vS4, i, 3)) : GoTo next1
                            If getColumIndex(vS4, "SizeQty19") = i Then D4958.SizeQty19 = CDecp(getData(vS4, i, 3)) : GoTo next1
                            If getColumIndex(vS4, "SizeQty20") = i Then D4958.SizeQty20 = CDecp(getData(vS4, i, 3)) : GoTo next1
                            If getColumIndex(vS4, "SizeQty21") = i Then D4958.SizeQty21 = CDecp(getData(vS4, i, 3)) : GoTo next1
                            If getColumIndex(vS4, "SizeQty22") = i Then D4958.SizeQty22 = CDecp(getData(vS4, i, 3)) : GoTo next1
                            If getColumIndex(vS4, "SizeQty23") = i Then D4958.SizeQty23 = CDecp(getData(vS4, i, 3)) : GoTo next1
                            If getColumIndex(vS4, "SizeQty24") = i Then D4958.SizeQty24 = CDecp(getData(vS4, i, 3)) : GoTo next1
                            If getColumIndex(vS4, "SizeQty25") = i Then D4958.SizeQty25 = CDecp(getData(vS4, i, 3)) : GoTo next1
                            If getColumIndex(vS4, "SizeQty26") = i Then D4958.SizeQty26 = CDecp(getData(vS4, i, 3)) : GoTo next1
                            If getColumIndex(vS4, "SizeQty27") = i Then D4958.SizeQty27 = CDecp(getData(vS4, i, 3)) : GoTo next1
                            If getColumIndex(vS4, "SizeQty28") = i Then D4958.SizeQty28 = CDecp(getData(vS4, i, 3)) : GoTo next1
                            If getColumIndex(vS4, "SizeQty29") = i Then D4958.SizeQty29 = CDecp(getData(vS4, i, 3)) : GoTo next1
                            If getColumIndex(vS4, "SizeQty30") = i Then D4958.SizeQty30 = CDecp(getData(vS4, i, 3)) : GoTo next1

next1:
                            D4958.FactOrderNo = FactOrderNo
                            D4958.FactOrderSeq = FactOrderSeq

                            D4958.OrderNo = OrderNo
                            D4958.OrderNoSeq = OrderNoSeq
                            D4958.PKONO = PKONO

                            D4958.Article = Article

                            If WRITE_PFK4958(D4958) = True Then

                                D4958.QtyPrs = 0
                                D4958.SizeQty01 = 0
                                D4958.SizeQty02 = 0
                                D4958.SizeQty03 = 0
                                D4958.SizeQty04 = 0
                                D4958.SizeQty05 = 0
                                D4958.SizeQty06 = 0
                                D4958.SizeQty07 = 0
                                D4958.SizeQty08 = 0
                                D4958.SizeQty09 = 0
                                D4958.SizeQty10 = 0
                                D4958.SizeQty11 = 0
                                D4958.SizeQty12 = 0
                                D4958.SizeQty13 = 0
                                D4958.SizeQty14 = 0
                                D4958.SizeQty15 = 0
                                D4958.SizeQty16 = 0
                                D4958.SizeQty17 = 0
                                D4958.SizeQty18 = 0
                                D4958.SizeQty19 = 0
                                D4958.SizeQty20 = 0
                                D4958.SizeQty21 = 0
                                D4958.SizeQty22 = 0
                                D4958.SizeQty23 = 0
                                D4958.SizeQty24 = 0
                                D4958.SizeQty25 = 0
                                D4958.SizeQty26 = 0
                                D4958.SizeQty27 = 0
                                D4958.SizeQty28 = 0
                                D4958.SizeQty29 = 0
                                D4958.SizeQty30 = 0
                                D4958.PackingCMB = 0
                                D4958.PackingGW = 0
                                D4958.PackingNW = 0
                                D4958.QtyPacking = 0
                                D4958.QtyLoading = 0

                            End If

                        Next j

                    End If

                Next i

            Else

                Call KEY_COUNT()

                For j = 1 To txt_BoxQty.Value

                    D4958 = New T4958_AREA

                    If FormatCut(PKONO) = "" Then PKONO = getData(Vs1, getColumIndex(Vs1, "slno"), Vs1.ActiveSheet.ActiveRowIndex)

                    SQL = " SELECT isnull(MAX(K4958_CartonNo),0) AS CartonNo FROM PFK4958 "
                    SQL = SQL & " WHERE K4958_AutoKey_K3422	 =  '" & KEY_Autokey & "'  "


                    cmd = New SqlClient.SqlCommand(SQL, cn)
                    rd = cmd.ExecuteReader
                    rd.Read()

                    If rd.HasRows = False Then
                        D4958.CartonNo = 1
                    Else
                        D4958.CartonNo = rd!CartonNo + 1
                    End If
                    rd.Close()

                    D4958.AutoKey_K3422 = KEY_Autokey
                    D4958.PackingBatch = W4958.PackingBatch

                    D4958.CartonCode = CartonCode
                    D4958.PackingCMB = CDecp(getData(vS3, getColumIndex(vS3, "PackingCMB"), xrow))
                    D4958.PackingNW = CDecp(getData(vS3, getColumIndex(vS3, "PackingNW"), xrow))
                    D4958.PackingGW = CDecp(getData(vS3, getColumIndex(vS3, "PackingGW"), xrow))

                    D4958.DatePacking = Pub.DAT
                    D4958.SizeGroup = getData(vS3, getColumIndex(vS3, "SizeGroup"), xrow)

                    D4958.CustomerCode = getData(Vs1, getColumIndex(Vs1, "CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex)
                    D4958.cdSeason = txt_cdSite.Code
                    D4958.seSeason = ListCode("Season")

                    For i = 0 To vS4.ActiveSheet.ColumnCount - 1

                        TotalQty = TotalQty + CDecp(getData(vS4, i, 3))

                        D4958.QtyPacking = TotalQty

                    Next i

                    If CDecp(getData(vS4, getColumIndex(vS4, "SizeQty01"), 3)) <> "0" Then D4958.SizeQty01 = CDecp(getData(vS4, getColumIndex(vS4, "SizeQty01"), 3))
                    If CDecp(getData(vS4, getColumIndex(vS4, "SizeQty02"), 3)) <> "0" Then D4958.SizeQty02 = CDecp(getData(vS4, getColumIndex(vS4, "SizeQty02"), 3))
                    If CDecp(getData(vS4, getColumIndex(vS4, "SizeQty03"), 3)) <> "0" Then D4958.SizeQty03 = CDecp(getData(vS4, getColumIndex(vS4, "SizeQty03"), 3))
                    If CDecp(getData(vS4, getColumIndex(vS4, "SizeQty04"), 3)) <> "0" Then D4958.SizeQty04 = CDecp(getData(vS4, getColumIndex(vS4, "SizeQty04"), 3))
                    If CDecp(getData(vS4, getColumIndex(vS4, "SizeQty05"), 3)) <> "0" Then D4958.SizeQty05 = CDecp(getData(vS4, getColumIndex(vS4, "SizeQty05"), 3))
                    If CDecp(getData(vS4, getColumIndex(vS4, "SizeQty06"), 3)) <> "0" Then D4958.SizeQty06 = CDecp(getData(vS4, getColumIndex(vS4, "SizeQty06"), 3))
                    If CDecp(getData(vS4, getColumIndex(vS4, "SizeQty07"), 3)) <> "0" Then D4958.SizeQty07 = CDecp(getData(vS4, getColumIndex(vS4, "SizeQty07"), 3))
                    If CDecp(getData(vS4, getColumIndex(vS4, "SizeQty08"), 3)) <> "0" Then D4958.SizeQty08 = CDecp(getData(vS4, getColumIndex(vS4, "SizeQty08"), 3))
                    If CDecp(getData(vS4, getColumIndex(vS4, "SizeQty09"), 3)) <> "0" Then D4958.SizeQty09 = CDecp(getData(vS4, getColumIndex(vS4, "SizeQty09"), 3))
                    If CDecp(getData(vS4, getColumIndex(vS4, "SizeQty10"), 3)) <> "0" Then D4958.SizeQty10 = CDecp(getData(vS4, getColumIndex(vS4, "SizeQty10"), 3))
                    If CDecp(getData(vS4, getColumIndex(vS4, "SizeQty11"), 3)) <> "0" Then D4958.SizeQty11 = CDecp(getData(vS4, getColumIndex(vS4, "SizeQty11"), 3))
                    If CDecp(getData(vS4, getColumIndex(vS4, "SizeQty12"), 3)) <> "0" Then D4958.SizeQty12 = CDecp(getData(vS4, getColumIndex(vS4, "SizeQty12"), 3))
                    If CDecp(getData(vS4, getColumIndex(vS4, "SizeQty13"), 3)) <> "0" Then D4958.SizeQty13 = CDecp(getData(vS4, getColumIndex(vS4, "SizeQty13"), 3))
                    If CDecp(getData(vS4, getColumIndex(vS4, "SizeQty14"), 3)) <> "0" Then D4958.SizeQty14 = CDecp(getData(vS4, getColumIndex(vS4, "SizeQty14"), 3))
                    If CDecp(getData(vS4, getColumIndex(vS4, "SizeQty15"), 3)) <> "0" Then D4958.SizeQty15 = CDecp(getData(vS4, getColumIndex(vS4, "SizeQty15"), 3))
                    If CDecp(getData(vS4, getColumIndex(vS4, "SizeQty16"), 3)) <> "0" Then D4958.SizeQty16 = CDecp(getData(vS4, getColumIndex(vS4, "SizeQty16"), 3))
                    If CDecp(getData(vS4, getColumIndex(vS4, "SizeQty17"), 3)) <> "0" Then D4958.SizeQty17 = CDecp(getData(vS4, getColumIndex(vS4, "SizeQty17"), 3))
                    If CDecp(getData(vS4, getColumIndex(vS4, "SizeQty18"), 3)) <> "0" Then D4958.SizeQty18 = CDecp(getData(vS4, getColumIndex(vS4, "SizeQty18"), 3))
                    If CDecp(getData(vS4, getColumIndex(vS4, "SizeQty19"), 3)) <> "0" Then D4958.SizeQty19 = CDecp(getData(vS4, getColumIndex(vS4, "SizeQty19"), 3))
                    If CDecp(getData(vS4, getColumIndex(vS4, "SizeQty20"), 3)) <> "0" Then D4958.SizeQty20 = CDecp(getData(vS4, getColumIndex(vS4, "SizeQty20"), 3))
                    If CDecp(getData(vS4, getColumIndex(vS4, "SizeQty21"), 3)) <> "0" Then D4958.SizeQty21 = CDecp(getData(vS4, getColumIndex(vS4, "SizeQty21"), 3))
                    If CDecp(getData(vS4, getColumIndex(vS4, "SizeQty22"), 3)) <> "0" Then D4958.SizeQty22 = CDecp(getData(vS4, getColumIndex(vS4, "SizeQty22"), 3))
                    If CDecp(getData(vS4, getColumIndex(vS4, "SizeQty23"), 3)) <> "0" Then D4958.SizeQty23 = CDecp(getData(vS4, getColumIndex(vS4, "SizeQty23"), 3))
                    If CDecp(getData(vS4, getColumIndex(vS4, "SizeQty24"), 3)) <> "0" Then D4958.SizeQty24 = CDecp(getData(vS4, getColumIndex(vS4, "SizeQty24"), 3))
                    If CDecp(getData(vS4, getColumIndex(vS4, "SizeQty25"), 3)) <> "0" Then D4958.SizeQty25 = CDecp(getData(vS4, getColumIndex(vS4, "SizeQty25"), 3))
                    If CDecp(getData(vS4, getColumIndex(vS4, "SizeQty26"), 3)) <> "0" Then D4958.SizeQty26 = CDecp(getData(vS4, getColumIndex(vS4, "SizeQty26"), 3))
                    If CDecp(getData(vS4, getColumIndex(vS4, "SizeQty27"), 3)) <> "0" Then D4958.SizeQty27 = CDecp(getData(vS4, getColumIndex(vS4, "SizeQty27"), 3))
                    If CDecp(getData(vS4, getColumIndex(vS4, "SizeQty28"), 3)) <> "0" Then D4958.SizeQty28 = CDecp(getData(vS4, getColumIndex(vS4, "SizeQty28"), 3))
                    If CDecp(getData(vS4, getColumIndex(vS4, "SizeQty29"), 3)) <> "0" Then D4958.SizeQty29 = CDecp(getData(vS4, getColumIndex(vS4, "SizeQty29"), 3))
                    If CDecp(getData(vS4, getColumIndex(vS4, "SizeQty30"), 3)) <> "0" Then D4958.SizeQty30 = CDecp(getData(vS4, getColumIndex(vS4, "SizeQty30"), 3))

                    D4958.FactOrderNo = FactOrderNo
                    D4958.FactOrderSeq = FactOrderSeq

                    D4958.OrderNo = OrderNo
                    D4958.OrderNoSeq = OrderNoSeq
                    D4958.PKONO = PKONO

                    D4958.Article = Article


                    If WRITE_PFK4958(D4958) Then

                        D4958.QtyPrs = 0
                        D4958.SizeQty01 = 0
                        D4958.SizeQty02 = 0
                        D4958.SizeQty03 = 0
                        D4958.SizeQty04 = 0
                        D4958.SizeQty05 = 0
                        D4958.SizeQty06 = 0
                        D4958.SizeQty07 = 0
                        D4958.SizeQty08 = 0
                        D4958.SizeQty09 = 0
                        D4958.SizeQty10 = 0
                        D4958.SizeQty11 = 0
                        D4958.SizeQty12 = 0
                        D4958.SizeQty13 = 0
                        D4958.SizeQty14 = 0
                        D4958.SizeQty15 = 0
                        D4958.SizeQty16 = 0
                        D4958.SizeQty17 = 0
                        D4958.SizeQty18 = 0
                        D4958.SizeQty19 = 0
                        D4958.SizeQty20 = 0
                        D4958.SizeQty21 = 0
                        D4958.SizeQty22 = 0
                        D4958.SizeQty23 = 0
                        D4958.SizeQty24 = 0
                        D4958.SizeQty25 = 0
                        D4958.SizeQty26 = 0
                        D4958.SizeQty27 = 0
                        D4958.SizeQty28 = 0
                        D4958.SizeQty29 = 0
                        D4958.SizeQty30 = 0
                        D4958.PackingCMB = 0
                        D4958.PackingGW = 0
                        D4958.PackingNW = 0
                        D4958.QtyPacking = 0
                        D4958.QtyLoading = 0

                    End If

                Next j

            End If

            D4958.FactOrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
            D4958.FactOrderSeq = getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderSeq"), Vs1.ActiveSheet.ActiveRowIndex)
            D4958.PKONO = getData(Vs1, getColumIndex(Vs1, "PKO"), Vs1.ActiveSheet.ActiveRowIndex)


            If PrcExeNoError("EXP_CLOSSING_PFK4958_CBM", cn, D4958.FactOrderNo, D4958.FactOrderSeq, D4958.PKONO) Then
                Call DATA_SEARCH_VS2()
            End If


            Call DATA_SEARCH_VS4()
            Call DATA_SEARCH_VS5()


        Catch ex As Exception

        End Try

    End Sub

    Private Sub KEY_COUNT()
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        Dim lENsLNO As String
        Dim cntlENsLNO As Integer

        Call READ_PFK7101(getData(Vs1, getColumIndex(Vs1, "CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex))

        lENsLNO = D7101.CustomerNameSimply & txt_cdSite.Data & "0000"
        cntlENsLNO = lENsLNO.Length

        'SQL = "SELECT  MAX( CAST (RIGHT([K0000_PackingBatch], LEN([K0000_PackingBatch]) - " & cntlENsLNO & " +4 ) AS INT) ) AS MAX_CODE FROM PFK0000 WHERE LEFT(K0000_PackingBatch, " & cntlENsLNO & " -4) = '" & D7101.CustomerNameSimply & txt_cdSeason.Data & "'  "

        'cmd = New SqlClient.SqlCommand(SQL, cn)
        'rd = cmd.ExecuteReader
        'rd.Read()

        'If IsDBNull(rd!MAX_CODE) Then
        '    W4958.PackingBatch = D7101.CustomerNameSimply & txt_cdSeason.Data & "0001"
        'Else
        '    W4958.PackingBatch = D7101.CustomerNameSimply & txt_cdSeason.Data & Format(CInt(rd!MAX_CODE + 1), "0000")
        'End If

        'txt_PackingBatch.Data = W4958.PackingBatch
        'rd.Close()

    End Sub

    Private Sub vS2_KeyDown(sender As Object, e As KeyEventArgs) Handles vS2.KeyDown

        Select Case e.KeyCode


            Case Keys.Delete
                Dim str As String = MsgBoxP("Do you want to delete it?", vbYesNo)

                If str <> vbYes Then Exit Sub

                Dim i As Integer

                For i = 0 To vS2.ActiveSheet.RowCount - 1
                    Dim CartonType As String

                    If getDataM(vS2, getColumIndex(vS2, "DCHK"), i) = "1" Then


                        Dim KEY_Autokey As String

                        KEY_Autokey = getData(vS2, getColumnIndex(vS2, "KEY_Autokey"), i)

                        If READ_PFK4958(KEY_Autokey) = True Then
                            ''If D4958.CustomerCode <> "000001" Then
                            'If D4958.Printed = "1" Then Call MsgBox("Already print can't delete barcode!") : Exit Sub
                            W4958 = D4958
                            W4958.CheckUse = "2"

                            'Call REWRITE_PFK4958(W4958) 'Jun change for P.423, P.408 2018/11/26 05:56 PM

                            'If READ_PFK2656_BarcodePacking(W4958.Autokey) = True Then Call MsgBox("Already outbound can't delete barcode!") : Exit Sub

                            If READ_PFK2656_BarcodePacking(W4958.Autokey) = True Then Exit Sub

                            Call DELETE_PFK2651_Autokey_4958(W4958.Autokey) 'Jun new for P.534 2018/01/04 09:43 AM

                            D9700_CLEAR()
                            D9700.ActionName = "0cmd_DELETE"
                            D9700.DateCreate = Pub.DAT
                            D9700.UserCode = Pub.SAW
                            D9700.FormName = "ISUD2651"
                            D9700.Reference = W4958.Autokey

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

                            Call DELETE_PFK4958(W4958)

                            D9700_CLEAR()
                            D9700.ActionName = "0cmd_DELETE"
                            D9700.DateCreate = Pub.DAT
                            D9700.UserCode = Pub.SAW
                            D9700.FormName = Me.FindForm.Name
                            D9700.Reference = W4958.Autokey

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

                            '  'End If
                        End If
                    End If
                Next

            Case Keys.Enter
                Dim KEY_Autokey As String
                Dim CartonType As String

                KEY_Autokey = getData(vS2, getColumnIndex(vS2, "KEY_Autokey"), vS2.ActiveSheet.ActiveRowIndex)

                If READ_PFK4958(KEY_Autokey) = True Then
                    D7210.CartonCode = D4958.CartonCode

                    Dim i As Integer

                    hlp0000SeVaTt = ""
                    hlp0000SeVa = ""
                    hlp0000SeVaTt1 = ""
                    txt_CartonCode.Code = D7210.CartonCode

                    CartonType = getData(vS2, getColumnIndex(vS2, "CartonType"), vS2.ActiveSheet.ActiveRowIndex)

                    If READ_PFK7210_CUSTOMER_CARTONNAME(D4958.CustomerCode, CartonType) = True Then
                        txt_CartonCode.Code = D7210.CartonCode

                        For i = 0 To vS2.ActiveSheet.RowCount - 1
                            If getDataM(vS2, getColumIndex(vS2, "dchk"), i) = "1" Then

                                txt_CartonCode.Data = D7210.CartonType
                                txt_CartonCode.Code = D7210.CartonCode

                                txt_CBM.Data = D7210.CBM
                                txt_CTHeight.Data = D7210.CTHeight
                                txt_CTWidth.Data = D7210.CTWidth
                                txt_CTNetWeight.Data = D7210.CTNetWeight
                                txt_CTGrossWeight.Data = D7210.CTNetWeight

                                txt_CTLength.Data = D7210.CTLength

                                setData(vS2, getColumIndex(vS2, "CartonType"), i, D7210.CartonType)
                                setData(vS2, getColumIndex(vS2, "CartonCode"), i, D7210.CartonCode)

                                If READ_PFK4958(getDataM(vS2, getColumIndex(vS2, "KEY_Autokey"), i)) Then

                                    D4958.CartonCode = D7210.CartonCode
                                    D4958.PackingCMB = D7210.CBM
                                    D4958.PackingNW = D7210.CTNetWeight

                                    D4958.DatePacking = Pub.DAT
                                    D4958.SizeGroup = txt_SizeGroup.Data

                                    If REWRITE_PFK4958(D4958) Then
                                        Call PrcExeNoError("EXP_CLOSSING_PFK4958_CBM_AUTOKEY", cn, D4958.Autokey)

                                        If READ_PFK4958(getDataM(vS2, getColumIndex(vS2, "KEY_Autokey"), i)) Then
                                            setData(vS2, getColumIndex(vS2, "PackingCMB"), i, D4958.PackingCMB)
                                            setData(vS2, getColumIndex(vS2, "PackingGW"), i, D4958.PackingGW)
                                            setData(vS2, getColumIndex(vS2, "PackingNW"), i, D4958.PackingNW)
                                            setData(vS2, getColumIndex(vS2, "QtyPacking"), i, D4958.QtyPacking)

                                            setData(vS2, getColumIndex(vS2, "CTNetWeight"), i, D7210.CTNetWeight)

                                        End If

                                    End If
                                End If

                            End If


                        Next
                    End If

                End If


        End Select

    End Sub

    Private Sub cmd_Print3451_Click(sender As Object, e As EventArgs) Handles cmd_Print3451.Click
        Dim f As New Form
        Dim i As Integer
        Dim ChuoiValue2 As String
        f = Me.FindForm

        ChuoiValue1 = ""
        ChuoiValue2 = ""

        If GETCHUOI1(ChuoiValue1, "PackingList") = False Then Exit Sub


        txt_FactOrderNo.Data = getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
        txt_FactOrderSeq.Data = getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderSeq"), Vs1.ActiveSheet.ActiveRowIndex)

        If GETCHUOI2_01(f, ChuoiValue2, "PackingList", ChuoiValue1) = False Then Exit Sub

        If PRINTSHEET.Link_PrintSheet("PackingList", ChuoiValue1, ChuoiValue2) = True Then

        End If


    End Sub

#End Region



#Region "Print"


    Public PACKING1 As PACKING_AREA
    Public PACKING2 As PACKING_AREA
    Public Structure PACKING_AREA
        Public KEY_Autokey As String
        Public CustomerName As String
        Public SLNo As String
        Public PKONO As String
        Public Article As String
        Public Line As String
        Public MCODE As String
        Public ColorCode As String
        Public QtyPacking As String
        Public CartonNo As String
    End Structure




    Public Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        gpp = e.Graphics
        Call TAG_PRINT_BARCODE_PACKINGLIST_PKO()
    End Sub

    Private int_MaxCnt As Integer

    Private Sub cmd_BarCode_Click(sender As Object, e As EventArgs) Handles cmd_BarCode.Click
        Try
            Dim I As Integer
            Dim List_Auto_key As String

            Dim int_Max As Integer

            int_MaxCnt = 0

            For xxx As Integer = 0 To vS5.ActiveSheet.RowCount - 1
                If getDataM(vS5, getColumIndex(vS5, "DCHK"), xxx) = "1" Then
                    List_Auto_key = List_Auto_key + CStrp(getData(vS5, getColumIndex(vS5, "KEY_Autokey"), xxx)) + ","

                    'If CStrp(getData(vS2, getColumIndex(vS2, "CTNetWeight"), xxx)).Trim = "" Then
                    '    MsgBoxP("Plz input CTNetWeight!")
                    '    Exit Sub
                    'End If

                    int_Max = getData(vS5, getColumIndex(vS5, "CartonNo"), xxx)
                    If int_MaxCnt < int_Max Then int_MaxCnt = int_Max
                End If
            Next

            List_Auto_key = List_Auto_key.Substring(0, List_Auto_key.Length - 1)

            DS1 = PrcDS("USP_ISUD4958A_BARCODE_PRINT_NEW", cn, List_Auto_key)

            If GetDsRc(DS1) > 0 Then
                For I = 0 To GetDsRc(DS1) - 1
                    Call DATA_MOVE_BARCODE_1(DS1, I)
                    Call DATA_MOVE_BARCODE()
                Next I
            Else
                MsgBoxP("No data !")
            End If

        Catch ex As Exception
            Call MsgBoxP("cmd_BarCode_Click")
        End Try
    End Sub



    Private Sub cmd_BarCodeOut_Click(sender As Object, e As EventArgs) Handles cmd_BarCodeOut.Click
        Try
            Dim I As Integer
            Dim List_Auto_key As String
            Dim int_Max As Integer


            int_MaxCnt = 0

            For xxx As Integer = 0 To vS2.ActiveSheet.RowCount - 1
                If getDataM(vS2, getColumIndex(vS2, "DCHK"), xxx) = "1" Then
                    List_Auto_key = List_Auto_key + CStrp(getData(vS2, getColumIndex(vS2, "KEY_Autokey"), xxx)) + ","

                    If CDecp(getData(vS2, getColumIndex(vS2, "CTNetWeight"), xxx)) = 0 Then
                        MsgBoxP("Plz input CTNetWeight!")
                        Exit Sub
                    End If

                End If

                int_Max = getData(vS2, getColumIndex(vS2, "CartonNo"), xxx)
                If int_MaxCnt < int_Max Then int_MaxCnt = int_Max

            Next

            List_Auto_key = List_Auto_key.Substring(0, List_Auto_key.Length - 1)

            DS1 = PrcDS("USP_ISUD4958A_BARCODE_PRINT_NEW", cn, List_Auto_key)

            If GetDsRc(DS1) > 0 Then
                For I = 0 To GetDsRc(DS1) - 1
                    Call DATA_MOVE_BARCODE_1(DS1, I)
                    Call DATA_MOVE_BARCODE()
                Next I
            Else
                MsgBoxP("No data !")
            End If

        Catch ex As Exception
            Call MsgBoxP("cmd_BarCode_Click")
        End Try
    End Sub


    Public Sub DATA_MOVE_BARCODE_1(ds As DataSet, i As Integer)

        PACKING1.KEY_Autokey = GetDsData(ds, i, "KEY_Autokey")
        PACKING1.CustomerName = GetDsData(ds, i, "CustomerName")
        PACKING1.SLNo = GetDsData(ds, i, "SLNo")
        PACKING1.PKONO = GetDsData(ds, i, "PKONO")
        PACKING1.Article = GetDsData(ds, i, "Article")
        PACKING1.Line = GetDsData(ds, i, "Line")
        PACKING1.MCODE = GetDsData(ds, i, "MCODE")
        PACKING1.ColorCode = GetDsData(ds, i, "ColorCode")
        PACKING1.QtyPacking = GetDsData(ds, i, "QtyPacking")
        PACKING1.CartonNo = GetDsData(ds, i, "CartonNo")

    End Sub

    Public Sub DATA_MOVE_BARCODE_2(ds As DataSet, i As Integer)

        PACKING2.KEY_Autokey = GetDsData(ds, i, "KEY_Autokey")
        PACKING2.CustomerName = GetDsData(ds, i, "CustomerName")
        PACKING2.SLNo = GetDsData(ds, i, "SLNo")
        PACKING2.PKONO = GetDsData(ds, i, "PKONO")
        PACKING2.Article = GetDsData(ds, i, "Article")
        PACKING2.Line = GetDsData(ds, i, "Line")
        PACKING2.MCODE = GetDsData(ds, i, "MCODE")
        PACKING2.ColorCode = GetDsData(ds, i, "ColorCode")
        PACKING2.QtyPacking = GetDsData(ds, i, "QtyPacking")
        PACKING2.CartonNo = GetDsData(ds, i, "CartonNo")

    End Sub




    Public Sub DATA_MOVE_BARCODE()
        Try

            PrintDocument1 = New Printing.PrintDocument
            PrintDocument1.Print()

        Catch ex As Exception
            MsgBoxP("DATA_MOVE_BARCODE")
        End Try

    End Sub


    Public Sub TAG_PRINT_BARCODE_PACKINGLIST_PKO()

        Dim stringFormat As New StringFormat()
        stringFormat.Alignment = StringAlignment.Center
        stringFormat.LineAlignment = StringAlignment.Center

        Dim settings As BarcodeSettings = New BarcodeSettings()
        BarcodeSettings.ApplyKey("0H8YP-M0FO1-9O9ZJ-441BF-WJ1NA")
        Dim barc As New FarPoint.Win.Spread.CellType.BarCodeCellType

        settings.Type = BarCodeType.QRCode
        settings.Unit = GraphicsUnit.Pixel
        settings.ShowText = False
        settings.ResolutionType = ResolutionType.UseDpi
        settings.Data = FormatCut(PACKING1.KEY_Autokey)
        settings.X = 3.5
        settings.ForeColor = Color.Black
        settings.BackColor = Color.White
        settings.QRCodeECL = QRCodeECL.L
        settings.LeftMargin = 1
        settings.RightMargin = 1
        settings.BottomMargin = 1
        settings.TopMargin = 1

        settings.ResolutionType = ResolutionType.UseDpi
        Dim generator As BarCodeGenerator = New BarCodeGenerator(settings)

        Dim QRbarcode As Image = generator.GenerateImage





        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''BARCODE 1

        If PACKING1.KEY_Autokey <> "" Then

            DLine(gpp, 0.3, 0.4, 0.3, 3) ' vạch thang đầu
            DLine(gpp, 0.3, 0.4, 4.9, 0.4) ' vạch ngang đứng

            DLine(gpp, 4.9, 0.4, 4.9, 3)   ' vạch ngang đứng
            DLine(gpp, 0.3, 3, 4.9, 3)   ' vạch thang cuối


            'Call Code128_Print("P", 0.6 + 3 - 2.15, 2.1 - 1.6, 0.03, 0.003, 0.6, 0, FormatCut(PACKING1.KEY_Autokey), Nothing)
            'DString(gpp, "Arial", True, False, False, 6, PACKING1.KEY_Autokey, 0, 0.9 + 1.2 + 0.2 - 0.2, 0.4 + 0.8)

            DString(gpp, "Arial", True, False, False, 7 + 2, PACKING1.CustomerName, 0, 0.35, 1.35)
            DString(gpp, "Arial", True, False, False, 7 + 2, "WH-" & PACKING1.PKONO, 0, 0.35, 1.7)

            DString(gpp, "Arial", True, False, False, 4 + 2, "ART:", 0, 0.35, 2.03)
            DString(gpp, "Arial", True, False, False, 4 + 2, PACKING1.Article, 0, 1, 2.03)

            Dim rect4 As New RectangleF(0.26 * 400, 6.67 * 18, 180.0F, 120.0F)
            gpp.DrawString(PACKING1.Article, New Font("Arial", 10, FontStyle.Bold), New SolidBrush(Color.Black), rect4, stringFormat)

            gpp.DrawImage(QRbarcode, CInt(7.7 * twtopi), CInt(2.2 * twtopi))

            DString(gpp, "Arial", True, False, False, 6 + 2, "QTY", 0, 0.35, 2.33)
            DString(gpp, "Arial", True, False, False, 6 + 2, "CT NO", 0, 3.6, 2.33)

            DString(gpp, "Arial", True, False, False, 8 + 2, PACKING1.QtyPacking, 0, 0.35, 2.63)
            DString(gpp, "Arial", True, False, False, 8 + 2, PACKING1.CartonNo & "/" & int_MaxCnt, 0, 3.8, 2.63)

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        End If

        If PACKING1.KEY_Autokey <> "" Then

            ''BARCODE 2

            DLine(gpp, 5.1, 0.4, 5.1, 3) ' vạch thang đầu
            DLine(gpp, 5.1, 0.4, 9.7, 0.4) ' vạch ngang đứng

            DLine(gpp, 9.7, 0.4, 9.7, 3) ' vạch thang cuối
            DLine(gpp, 5.1, 3, 9.7, 3) ' vạch ngang đứng


            'Call Code128_Print("P", 0.6 + 3 - 2.15 + 5 - 0.2, 2.1 - 1.6, 0.03, 0.003, 0.6, 0, FormatCut(PACKING1.KEY_Autokey), Nothing)
            'DString(gpp, "Arial", True, False, False, 6, PACKING1.KEY_Autokey, 0, 0.9 + 1.2 + 5 - 0.2, 0.4 + 0.8)

            DString(gpp, "Arial", True, False, False, 7 + 2, PACKING1.CustomerName, 0, 5.15, 1.35)
            DString(gpp, "Arial", True, False, False, 7 + 2, "PL-" & PACKING1.PKONO, 0, 5.15, 1.7)

            DString(gpp, "Arial", True, False, False, 4 + 2, "ART:", 0, 5.15, 2.03)
            DString(gpp, "Arial", True, False, False, 4 + 2, PACKING1.Article, 0, 5.8, 2.03)

            DString(gpp, "Arial", True, False, False, 6 + 2, "QTY", 0, 5.15, 2.33)
            DString(gpp, "Arial", True, False, False, 6 + 2, "CT NO", 0, 8.4, 2.33)

            DString(gpp, "Arial", True, False, False, 8 + 2, PACKING1.QtyPacking, 0, 5.15, 2.63)
            DString(gpp, "Arial", True, False, False, 8 + 2, PACKING1.CartonNo & "/" & int_MaxCnt, 0, 8.6, 2.63)


            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        End If

    End Sub

#End Region


    Private Sub vS3_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS3.CellDoubleClick

        Try

            If READ_PFK7210(getData(vS3, getColumIndex(vS3, "KEY_CartonCode"), vS3.ActiveSheet.ActiveRowIndex)) = True Then

                txt_CartonCode.Code = D7210.CartonCode

                If READ_PFK7210(txt_CartonCode.Code) = True Then
                    txt_CartonCode.Data = D7210.CartonType
                    txt_CartonCode.Code = D7210.CartonCode

                    txt_CBM.Data = D7210.CBM
                    txt_CTHeight.Data = D7210.CTHeight
                    txt_CTWidth.Data = D7210.CTWidth
                    txt_CTNetWeight.Data = D7210.CTNetWeight
                    txt_CTGrossWeight.Data = D7210.CTNetWeight

                    txt_CTLength.Data = D7210.CTLength

                Else
                    txt_CartonCode.Data = ""
                    txt_CartonCode.Code = ""

                    txt_CBM.Data = ""
                    txt_CTHeight.Data = ""
                    txt_CTWidth.Data = ""
                    txt_CTNetWeight.Data = ""
                    txt_CTGrossWeight.Data = ""
                    vS3.ActiveSheet.RowCount = 0

                End If

                DATA_SEARCH_VS4()

                DATA_SEARCH_VS5()
            Else

                Call MsgBox("Please Input Catton Code") : Exit Sub

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub PeaceButton1_Click(sender As Object, e As EventArgs) Handles cmd_CBM.Click
        D4958.FactOrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
        D4958.FactOrderSeq = getData(Vs1, getColumIndex(Vs1, "KEY_FactOrderSeq"), Vs1.ActiveSheet.ActiveRowIndex)
        D4958.PKONO = getData(Vs1, getColumIndex(Vs1, "PKO"), Vs1.ActiveSheet.ActiveRowIndex)

        If PrcExeNoError("EXP_CLOSSING_PFK4958_CBM", cn, D4958.FactOrderNo, D4958.FactOrderSeq, D4958.PKONO) Then
            Call DATA_SEARCH_VS2()
        End If
    End Sub

    Private Sub cmd_Closing_Click(sender As Object, e As EventArgs) Handles cmd_Closing.Click
        Msg_Result = MsgBoxP("Do you want to closing FINISH GOODS WH?", vbYesNo)

        If Msg_Result <> vbYes Then Exit Sub


        Dim Starting As Object
        Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")


        Try
            Call PrcExeNoError("EXP_CLOSSING_FINISH_GOODS_ALL", cn)

        Catch ex As Exception

        Finally
            Starting.close()
        End Try
    End Sub
End Class