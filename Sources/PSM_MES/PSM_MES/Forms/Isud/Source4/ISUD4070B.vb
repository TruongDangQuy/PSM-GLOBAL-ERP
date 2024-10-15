Imports System.Net.Mail
Imports System.Text
Imports System.IO.Ports

Public Class ISUD4070B

#Region "Variable"
    Private wJOB As Integer

    Private W4070 As New T4070_AREA
    Private L4070 As New T4070_AREA

    Private W4075 As New T4075_AREA
    Private L4075 As New T4075_AREA

    Private W4071 As New T4071_AREA
    Private L4071 As New T4071_AREA

    Private WRITE_CHK As String
    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD4070B(job As Integer, cdFactory As String, cdMainProcess As String, MachineCode As String, MachineTno As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D4070.MachineCode = MachineCode
        D4070.cdFactory = cdFactory
        D4070.cdMainProcess = cdMainProcess
        D4070.MachineTno = MachineTno

        D4071.MachineCode = MachineCode
        D4071.cdFactory = cdFactory
        D4071.cdMainProcess = cdMainProcess
        D4071.MachineTno = MachineTno

        txt_cdFactory.Data = cdFactory
        txt_cdMainProcess.Data = cdMainProcess
        txt_MachineCode.Data = MachineCode
        txt_MachineTno.Data = MachineTno

        txt_cdFactory.Code = cdFactory
        txt_cdMainProcess.Code = cdMainProcess
        txt_MachineCode.Code = MachineCode
        txt_MachineTno.Code = MachineTno

        wJOB = job : L4070 = D4070

        Link_ISUD4070B = False
        Try
            formA = False


            Select Case job
                Case 1

                Case Else
                    If READ_PFK4070(cdFactory, cdMainProcess, MachineCode, MachineTno) Then
                        If D4070.QtyProd > 0 Or D4070.CheckComplete <> "1" Then cmd_DEL.Visible = False : cmd_OK.Visible = False : wJOB = 2
                    Else
                        Exit Function
                    End If

            End Select

            Me.ShowDialog()

            Link_ISUD4070B = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))
        End Try


    End Function

    Public Function Link_ISUD4070B_JOBCARD(job As Integer, JobCard As String, cdFactory As String, cdMainProcess As String, MachineCode As String, MachineTno As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D4070.MachineCode = MachineCode
        D4070.cdFactory = cdFactory
        D4070.cdMainProcess = cdMainProcess
        D4070.MachineTno = MachineTno
        D4070.JobCard = JobCard

        D4071.MachineCode = MachineCode
        D4071.cdFactory = cdFactory
        D4071.cdMainProcess = cdMainProcess
        D4071.MachineTno = MachineTno

        txt_cdFactory.Data = cdFactory
        txt_cdMainProcess.Data = cdMainProcess
        txt_MachineCode.Data = MachineCode
        txt_MachineTno.Data = MachineTno

        txt_cdFactory.Code = cdFactory
        txt_cdMainProcess.Code = cdMainProcess
        txt_MachineCode.Code = MachineCode
        txt_MachineTno.Code = MachineTno
        txt_JobCard.Code = JobCard
        txt_JobCard.Data = JobCard

        wJOB = job : L4070 = D4070

        Link_ISUD4070B_JOBCARD = False
        Try
            formA = False


            Select Case job
                Case 1, 11

                Case Else
                    If READ_PFK4070(cdFactory, cdMainProcess, MachineCode, MachineTno) Then
                        If D4070.QtyProd > 0 Then cmd_DEL.Visible = False : cmd_OK.Visible = False : wJOB = 2
                    Else
                        Exit Function
                    End If

            End Select

            Me.ShowDialog()

            Link_ISUD4070B_JOBCARD = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))
        End Try


    End Function
#End Region

#Region "Form"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        Me.Form_KeyDown()

        Call DATA_INIT()
        Call FORM_INIT()

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))


begin:

        Select Case wJOB
            Case 1
                If CHK(1) <> "1" Then
                    isudCHK = False
                    formA = True
                    Me.Dispose()
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH_VS0()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()
                Call K4070_CheckComplete(True, False, False, False, False, False)

                Me.Text = Me.Text & " - INSERT"
                cmd_DEL.Visible = False

            Case 2
AgainPoint:
                If CHK(2) <> "1" Then
                    isudCHK = False
                    formA = True
                    Me.Dispose()
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Me.Text = Me.Text & " - SEARCH"
                cmd_DEL.Visible = False
                cmd_OK.Visible = False

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH_HEAD_TAB1()
                Call DATA_SEARCH_VS0()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()

            Case 3
                If CHK(3) <> "1" Then
                    If CHK(2) <> "1" Then
                        isudCHK = False
                        formA = True
                        Me.Dispose()
                        Call MsgBoxP("You have no right is this program !")
                        Exit Sub
                    Else
                        Me.Text = Me.Text & " - SEARCH"
                        isudCHK = False
                        wJOB = 2
                        cmd_DEL.Visible = False
                        GoTo Begin
                    End If
                End If

                Me.Text = Me.Text & " - UPDATE"
                cmd_DEL.Visible = False

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH_HEAD_TAB1()
                Call DATA_SEARCH_VS0()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()

                Call K4070_CheckComplete(False, False, False, False, False, False)

            Case 4

                If CHK(4) <> "1" Then
                    If CHK(2) <> "1" Then
                        isudCHK = False
                        formA = True
                        Me.Dispose()
                        Call MsgBoxP("You have no right is this program !")
                        Exit Sub
                    Else
                        Me.Text = Me.Text & " - SEARCH"
                        isudCHK = False
                        wJOB = 2
                        cmd_DEL.Visible = False
                        GoTo Begin
                    End If
                End If

                Me.Text = Me.Text & " - DELETE"
                cmd_DEL.Visible = True

                cmd_OK.Visible = False

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH_HEAD_TAB1()
                Call DATA_SEARCH_VS0()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()

                Call K4070_CheckComplete(False, False, False, False, False, False)

            Case 11

                If CHK(4) <> "1" Then
                    If CHK(2) <> "1" Then
                        isudCHK = False
                        formA = True
                        Me.Dispose()
                        Call MsgBoxP("You have no right is this program !")
                        Exit Sub
                    Else
                        Me.Text = Me.Text & " - SEARCH"
                        isudCHK = False
                        wJOB = 2
                        cmd_DEL.Visible = False
                        GoTo Begin
                    End If
                End If

                cmd_DEL.Visible = True

                cmd_OK.Visible = True

                Call KEY_COUNT()
                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH_VS0()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()

                Call K4070_CheckComplete(True, False, False, False, False, False)

                txt_Barcode.Data = L4070.JobCard

                Call txt_GreyBarcode_txtTextKeyDown(sender, New System.Windows.Forms.KeyEventArgs(Keys.Enter))

                wJOB = 1
                Me.Text = Me.Text & " - INSERT"
                cmd_OK.Visible = True

        End Select


        formA = True
    End Sub
#End Region

#Region "Search"
    Private Sub DATA_INIT()
        Try
            txt_DatePlan.Data = Pub.DAT

            txt_InchargePlan.Data = Pub.NAM
            txt_InchargePlan.Code = Pub.SAW
        Catch ex As Exception
            Call MsgBoxP("DATA_INIT")
        End Try
    End Sub
    Private Sub Calculation()

    End Sub
    Private Sub FORM_INIT()
        RemoveHandler txt_Barcode.PeaceTextbox1.KeyDown, AddressOf standard_KeyDown

        vS0.InsChk = True
        vS1.HorizontalScrollBarPolicy = ScrollBarPolicy.Never
        Me.WindowState = FormWindowState.Maximized
        txt_Barcode.PeaceTextbox1.Properties.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub KEY_COUNT()
        Try
            SQL = "SELECT MAX(CAST(K4070_MachineTno AS DECIMAL)) AS MAX_MCODE FROM PFK4070 "
            SQL = SQL & " WHERE K4070_cdFactory = '" & txt_cdFactory.Code & "' "
            SQL = SQL & " AND K4070_cdMainProcess = '" & txt_cdMainProcess.Code & "' "
            SQL = SQL & " AND K4070_MachineCode = '" & txt_MachineCode.Code & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                L4070.MachineTno = "01"
            Else
                L4070.MachineTno = CIntp(rd!MAX_MCODE + 1).ToString("00")
            End If

            W4070.MachineTno = L4070.MachineTno
            txt_MachineTno.Data = L4070.MachineTno

            rd.Close()
        Catch ex As Exception
            Call MsgBoxP("KEY_COUNT")
        End Try
    End Sub
    Private Sub KEY_COUNT_K4075_Sno(Szno As String)
        Try
            SQL = "SELECT MAX(CAST(K4075_Sno AS DECIMAL)) AS MAX_MCODE FROM PFK4075 "
            SQL = SQL & " WHERE K4075_Szno = '" & Szno & "' "
            SQL = SQL & " AND K4075_JobCard = '" & txt_JobCard.Data & "' "
            SQL = SQL & " AND K4075_cdMainProcess= '" & txt_cdMainProcess.Code & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                L4075.Sno = "00001"
            Else
                L4075.Sno = CIntp(rd!MAX_MCODE + 1).ToString("00000")
            End If

            W4075.Sno = L4075.Sno
            rd.Close()
        Catch ex As Exception
            Call MsgBoxP("KEY_COUNT")
        End Try
    End Sub

    Private Sub KEY_COUNT_K4075_BATCHNO()
        Dim YRNO As Integer
        YRNO = CIntp(Mid(System_Date_8(), 3, 2))

        Try
            SQL = "SELECT MAX(CAST(SUBSTRING(K4075_BatchNo,3,8) AS DECIMAL)) AS MAX_MCODE FROM PFK4075 "
            SQL = SQL & " WHERE SUBSTRING(K4075_BatchNo,1,2) = '" & YRNO.ToString & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                L4075.BatchNo = YRNO.ToString & "00000001"
            Else
                L4075.BatchNo = YRNO.ToString & CIntp(rd!MAX_MCODE + 1).ToString("00000000")
            End If

            W4075.BatchNo = L4075.BatchNo
            rd.Close()
        Catch ex As Exception
            Call MsgBoxP("KEY_COUNT")
        End Try
    End Sub

    Private Sub KEY_COUNT_K4075_BatchGroup()
        Dim YRNO As Integer
        YRNO = CIntp(Mid(System_Date_8(), 3, 4))

        Try
            SQL = "SELECT MAX(CAST(SUBSTRING(K4075_BatchGroup,7,10) AS DECIMAL)) AS MAX_MCODE FROM PFK4075 "
            SQL = SQL & " WHERE SUBSTRING(K4075_BatchGroup,1,6) = 'CT" & YRNO.ToString & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                L4075.BatchGroup = "CT" & YRNO.ToString & "0001"
            Else
                L4075.BatchGroup = "CT" & YRNO.ToString & CIntp(rd!MAX_MCODE + 1).ToString("0000")
            End If

            W4075.BatchGroup = L4075.BatchGroup
            rd.Close()
        Catch ex As Exception
            Call MsgBoxP("KEY_COUNT")
        End Try
    End Sub

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False
        Dim i As Integer
        Dim Scol As Integer
        Dim FixCol As Integer

        Try

            DS1 = PrcDS("USP_ISUD4070B_SEARCH_vS1", cn, L4070.cdFactory,
                                                              L4070.cdMainProcess,
                                                              L4070.MachineCode,
                                                              L4070.MachineTno)

            If GetDsRc(DS1) = 0 Then
                vS1.Enabled = True
                SPR_SET(vS1, , , , OperationMode.Normal)
                SPR_PRO(vS1, DS1, "USP_ISUD4070B_SEARCH_vS1", "Vs1")
                Exit Function
            End If

            SPR_SET(vS1, , , , OperationMode.Normal)
            SPR_PRO(vS1, DS1, "USP_ISUD4070B_SEARCH_vS1", "Vs1")
            Call VsSizeRangeNew(vS1, "USP_VS_SIZERANGE_JOBBASE", "SizeQty01", txt_JobCard.Data)
            vS1.ActiveSheet.RowCount += 1

            SPR_CHECKBOXROW(vS1, 1)

            'Scol = getColumIndex(vS1, "SizeQty01")
            'FixCol = getColumIndex(vS1, "SizeQty01")

            'For i = Scol To vS1.ActiveSheet.ColumnCount - 1
            '    If CIntp(getData(vS1, i, 0)) > 0 Then
            '        setData(vS1, i, 2, getData(vS1, i, 0))
            '        setData(vS1, i, 3, 1)
            '    End If
            'Next

            'Call Calculation()
            DATA_SEARCH_VS1 = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try
    End Function
    Private Function DATA_SEARCH_VS0() As Boolean
        DATA_SEARCH_VS0 = False

        Try

            DS1 = PrcDS("USP_ISUD4070B_SEARCH_VS0", cn, L4070.cdFactory,
                                                              L4070.cdMainProcess,
                                                              L4070.MachineCode,
                                                              L4070.MachineTno)

            If GetDsRc(DS1) = 0 Then
                VS0.Enabled = True
                SPR_PRO(vS0, DS1, "USP_ISUD4070B_SEARCH_VS0", "VS0")
                Exit Function
            End If

            SPR_PRO(vS0, DS1, "USP_ISUD4070B_SEARCH_VS0", "VS0")

            DATA_SEARCH_VS0 = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try
    End Function

    Private Function DATA_SEARCH_VS2() As Boolean
        DATA_SEARCH_VS2 = False

        Try

            DS1 = PrcDS("USP_ISUD4070B_SEARCH_VS2", cn, L4070.cdFactory,
                                                              L4070.cdMainProcess,
                                                              L4070.MachineCode,
                                                              L4070.MachineTno,
                                                                txt_BatchGroup.Data)

            If GetDsRc(DS1) = 0 Then
                DS2 = PrcDS("USP_ISUD4070B_SEARCH_VS2_INSERT", cn, L4070.JobCard, L4070.cdMainProcess)
                SPR_PRO_NEW(vS2, DS2, "USP_ISUD4070B_SEARCH_VS2", "Vs1")
                SPR_INSERT(vS2)
                Exit Function

            End If

            SPR_PRO(vS2, DS1, "USP_ISUD4070B_SEARCH_VS2", "VS2")

            DATA_SEARCH_VS2 = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try
    End Function
    Private Function DATA_SEARCH_HEAD() As Boolean
        DATA_SEARCH_HEAD = False
        Try

            DS1 = PrcDS("USP_ISUD4070B_SEARCH_HEAD", cn, L4070.cdFactory,
                                                         L4070.cdMainProcess,
                                                         L4070.MachineCode,
                                                         L4070.MachineTno)

            If GetDsRc(DS1) = 0 Then
                If READ_PFK7171(ListCode("Factory"), L4070.cdFactory) = True Then
                    txt_cdFactory.Data = D7171.BasicName
                    txt_cdFactory.Code = D7171.BasicCode
                End If

                If READ_PFK7171(ListCode("MainProcess"), L4070.cdMainProcess) = True Then
                    txt_cdMainProcess.Data = D7171.BasicName
                    txt_cdMainProcess.Code = D7171.BasicCode
                End If

                If READ_PFK7171(ListCode("LineProd"), L4070.MachineCode) = True Then
                    txt_MachineCode.Data = D7171.BasicName
                    txt_MachineCode.Code = D7171.BasicCode
                End If

                Exit Function
            End If

            STORE_MOVE(Me, DS1)

            L4070.JobCard = GetDsData(DS1, 0, "JobCard")

            Call K4070_CheckComplete(GetDsData(DS1, 0, "CheckComplete"))

            DATA_SEARCH_HEAD = True

            If READ_PFK7171(ListCode("Factory"), L4070.cdFactory) = True Then
                txt_cdFactory.Data = D7171.BasicName
                txt_cdFactory.Code = D7171.BasicCode
            End If

            If READ_PFK7171(ListCode("MainProcess"), L4070.cdMainProcess) = True Then
                txt_cdMainProcess.Data = D7171.BasicName
                txt_cdMainProcess.Code = D7171.BasicCode
            End If

            If READ_PFK7171(ListCode("LineProd"), L4070.MachineCode) = True Then
                txt_MachineCode.Data = D7171.BasicName
                txt_MachineCode.Code = D7171.BasicCode
            End If

            Call StoreFormat(Me)

         
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH01")
        End Try
    End Function
    Private Function DATA_SEARCH_HEAD_TAB1() As Boolean
        DATA_SEARCH_HEAD_TAB1 = False
        DATA_SEARCH_HEAD_TAB1 = True
        Exit Function

        L4070.cdFactory = txt_cdFactory.Code
        L4070.cdMainProcess = txt_cdMainProcess.Code
        L4070.MachineCode = txt_MachineCode.Code
        L4070.MachineTno = txt_MachineTno.Data

        Try
            If READ_PFK4070(L4070.cdFactory,
                            L4070.cdMainProcess,
                            L4070.MachineCode,
                            L4070.MachineTno) = True Then

                L4070.JobCard = D4070.JobCard
            Else
                Exit Function
            End If

            DS1 = PrcDS("USP_ISUD4070B_SEARCH_sTAB1_HEAD", cn, L4070.JobCard)

            STORE_MOVE(Block1, DS1)

            DATA_SEARCH_HEAD_TAB1 = True

            Call StoreFormat(Block1)

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH01")
        End Try
    End Function
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False
        Try
            DS1 = PrcDS("USP_ISUD4070B_SEARCH_vS1", cn, L4070.cdFactory, L4070.cdMainProcess, L4070.MachineCode, L4070.MachineTno)

            If GetDsRc(DS1) = 0 Then
                Exit Function
            End If

            STORE_MOVE(Me, DS1)

            DATA_SEARCH01 = True
            Call StoreFormat(Me)

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH01")
        End Try
    End Function

    Private Function DATA_DELETE()
        DATA_DELETE = False
        Try

            'If READ_PFK4070(L4070.cdFactory, L4070.cdMainProcess, L4070.MachineCode, L4070.MachineTno) Then

            '    If D4070.CheckComplete <> "1" Then MsgBoxP("No plan! Cannot delete!") : Exit Function

            '    L4070.cdFactory = txt_cdFactory.Code
            '    L4070.cdMainProcess = txt_cdMainProcess.Code
            '    L4070.MachineCode = txt_MachineCode.Code
            '    L4070.MachineTno = txt_MachineTno.Data

            '    W4070 = D4070

            '    Dim i As Integer
            '    Dim Scol As Integer
            '    Dim FixCol As Integer

            '    Scol = getColumIndex(vS1, "SizeQty01")
            '    FixCol = getColumIndex(vS1, "SizeQty01")

            '    For i = Scol To vS1.ActiveSheet.ColumnCount - 1
            '        If READ_PFK4071(L4070.cdFactory, L4070.cdMainProcess, L4070.MachineCode, L4070.MachineTno, (i - FixCol + 1).ToString("00")) Then
            '            W4071 = D4071
            '            Call DELETE_PFK4071(W4071)
            '        End If
            '    Next

            '    If DELETE_PFK4070(W4070) = True Then
            '        DATA_DELETE = True
            '        isudCHK = True
            '    End If
            'End If

        Catch ex As Exception
            MsgBoxP("DATA_MOVE!")
        End Try
    End Function

    Private Function DATA_DELETE(xrow As Integer)
        DATA_DELETE = False
        Try
            'If READ_PFK4070(L4070.cdFactory,
            '              L4070.cdMainProcess,
            '              L4070.MachineCode,
            '              L4070.MachineTno) Then

            '    If D4070.CheckComplete <> "1" Then MsgBoxP("No plan! Cannot delete!") : Exit Function

            '    L4070.cdFactory = txt_cdFactory.Code
            '    L4070.cdMainProcess = txt_cdMainProcess.Code
            '    L4070.MachineCode = txt_MachineCode.Code
            '    L4070.MachineTno = txt_MachineTno.Data

            '    If K4070_MOVE(vS1, xrow, W4070,
            '                  L4070.cdFactory,
            '                  L4070.cdMainProcess,
            '                  L4070.MachineCode,
            '                  L4070.MachineTno) = True Then

            '        If W4070.MachineTno = 1 Then MsgBoxP("You can not delete the main dyeing job no. You must delete all!") : Exit Function

            '        If DELETE_PFK4070(W4070) = True Then
            '            DATA_DELETE = True
            '        End If

            '    End If

            'End If
        Catch ex As Exception
            MsgBoxP("DATA_MOVE!")
        End Try
    End Function

    Private Function CheckItemCode(ItemCode As String) As Boolean
        CheckItemCode = False
        Try

            If ItemCode = txt_Line.Data Then
                CheckItemCode = True
            Else
                If MsgBoxPPW("Please input password, different item code!", const_pwPrintUpdate) = True Then
                    CheckItemCode = True
                End If
            End If

        Catch ex As Exception
            MsgBoxP("CheckItemCode")
        End Try
    End Function


    Private Function DATA_SEARCH_VS1_INSERT() As Boolean
        DATA_SEARCH_VS1_INSERT = False
        Dim xrow As Integer

        If txt_InchargePlan.Code = "" Then MsgBoxP("Please Input Incharge Name!") : Exit Function

        Try
            txt_Barcode.Data = FormatCut(txt_Barcode.Data)

            If txt_Barcode.Data.Length <> 9 Then Exit Function

            L4070.JobCard = txt_Barcode.Data

            If READ_PFK4010(L4070.JobCard) = False Then Exit Function

            txt_JobCard.Data = L4070.JobCard

            If READ_PFK4070(txt_cdFactory.Code, txt_cdMainProcess.Code, txt_MachineCode.Code, txt_MachineTno.Data) = True Then
                If D4070.QtyProd > 0 Then Exit Function
            End If

            Call KEY_COUNT()

            DS1 = PrcDS("USP_ISUD4070B_SEARCH_VS1_INSERT", cn, L4070.JobCard)

            If GetDsRc(DS1) = 0 Then
                MsgBoxP("No data. Check, please!")
                Exit Function
            End If

            vS1.ActiveSheet.RowCount += 1
            xrow = vS1.ActiveSheet.RowCount - 1
            vS1.SetViewportTopRow(0, vS1.ActiveSheet.RowCount - 1)
            vS1.ActiveSheet.ActiveRowIndex = xrow

            Call READ_SPREAD(vS1, DS1, "USP_ISUD4070B_SEARCH_vS1", "VS1", xrow)

            If DATA_MOVE() = True Then
                Call DATA_CHECKCOMPLETE()
                Call DATA_SEARCH_VS1()

                DATA_SEARCH_VS1_INSERT = True
            Else
                MsgBoxP("Can not input!")
                txt_ProcessSeq.Data = ""
                vS1.ActiveSheet.RowCount -= 1
            End If

            Call Calculation()
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try
    End Function

    Private Function K4070_CheckMethodDyeing5() As String

    End Function

    Private Sub K4070_CheckComplete(Check1 As Boolean, Check2 As Boolean, Check3 As Boolean, Check4 As Boolean, Check5 As Boolean, Check6 As Boolean)
        chk_CheckComplete1.Enabled = Check1
        chk_CheckComplete2.Enabled = Check2
        chk_CheckComplete3.Enabled = Check3
        chk_CheckComplete4.Enabled = Check4
        chk_CheckComplete5.Enabled = Check5
        chk_CheckComplete6.Enabled = Check6
    End Sub
    Private Sub K4070_CheckMethodDyeing5(Value As String)
    End Sub
    Private Sub K4070_CheckComplete(Value As String)
        chk_CheckComplete1.Checked = True
        If Value = "1" Then chk_CheckComplete1.Checked = True : Exit Sub
        If Value = "2" Then chk_CheckComplete2.Checked = True : Exit Sub
        If Value = "3" Then chk_CheckComplete3.Checked = True : Exit Sub
        If Value = "4" Then chk_CheckComplete4.Checked = True : Exit Sub
        If Value = "5" Then chk_CheckComplete5.Checked = True : Exit Sub
        If Value = "6" Then chk_CheckComplete6.Checked = True : Exit Sub
    End Sub

    Private Sub K4070_CheckComplete()
        W4070.CheckComplete = "1"
        If chk_CheckComplete1.Checked = True Then W4070.CheckComplete = "1" : Exit Sub
        If chk_CheckComplete2.Checked = True Then W4070.CheckComplete = "2" : Exit Sub
        If chk_CheckComplete3.Checked = True Then W4070.CheckComplete = "3" : Exit Sub
        If chk_CheckComplete4.Checked = True Then W4070.CheckComplete = "4" : Exit Sub
        If chk_CheckComplete5.Checked = True Then W4070.CheckComplete = "5" : Exit Sub
        If chk_CheckComplete6.Checked = True Then W4070.CheckComplete = "6" : Exit Sub
    End Sub

    Private Sub K4070_CheckProduction()
    End Sub

    Private Sub K4070_CheckProduction(Value As String)
    End Sub

    Private Function DATA_MOVE() As Boolean
        DATA_MOVE = False
        Try
            Dim xCOL As Long
            Dim xROW As Long

            xCOL = vS1.ActiveSheet.ActiveColumnIndex
            xROW = vS1.ActiveSheet.ActiveRowIndex


            If READ_PFK4070(txt_cdFactory.Code,
                            txt_cdMainProcess.Code,
                            txt_MachineCode.Code,
                            txt_MachineTno.Data) = True Then

                W4070 = D4070

                W4070.seFactory = ListCode("Factory")
                W4070.seMainProcess = ListCode("MainProcess")


                If REWRITE_PFK4070(W4070) = True Then
                    isudCHK = True
                    DATA_MOVE = True
                End If

            Else
                If K4070_MOVE(Me, W4070, 1, txt_cdFactory.Code,
                                            txt_cdMainProcess.Code,
                                            txt_MachineCode.Code,
                                            txt_MachineTno.Data) = False Then
                    W4070.STimeProduction = FormatCut(W4070.STimeProduction)
                    W4070.ETimeProduction = FormatCut(W4070.ETimeProduction)
                    W4070.CheckComplete = "1"

                    W4070.JobCard = L4070.JobCard

                    W4070.DatePlan = Pub.DAT
                    W4070.DateProduction = Pub.DAT

                    W4070.seFactory = ListCode("Factory")
                    W4070.seMainProcess = ListCode("MainProcess")

                    If WRITE_PFK4070(W4070) = True Then
                        isudCHK = True
                        DATA_MOVE = True
                        wJOB = 3
                    End If
                End If

            End If



        Catch ex As Exception
            MsgBoxP("DATA_MOVE!")
        End Try
    End Function

    Private Function DATA_INSERT_UPDATE() As Boolean
        DATA_INSERT_UPDATE = False
        Try

        Catch ex As Exception
            MsgBoxP("DATA_MOVE!")
        End Try
    End Function

    Private Function DATA_CHECKCOMPLETE() As Boolean
        DATA_CHECKCOMPLETE = False
        Try
            If READ_PFK4070(L4070.cdFactory, L4070.cdMainProcess, L4070.MachineCode, L4070.MachineTno) = True Then
                W4070 = D4070
                W4070.Remark = txt_Remark.Data
                W4070.InchargePlan = txt_InchargePlan.Code
                K4070_CheckProduction()
                K4070_CheckComplete()

                If REWRITE_PFK4070(W4070) = True Then
                    Dim i As Integer
                    Dim Scol As Integer
                    Dim FixCol As Integer

                    Scol = getColumIndex(vS1, "SizeQty01")
                    FixCol = getColumIndex(vS1, "SizeQty01")

                    For i = Scol To vS1.ActiveSheet.ColumnCount - 1
                        If READ_PFK4071(L4070.cdFactory, L4070.cdMainProcess, L4070.MachineCode, L4070.MachineTno, (i - FixCol + 1).ToString("00")) Then
                            W4071 = D4071

                            W4071.cdFactory = L4070.cdFactory
                            W4071.cdMainProcess = L4070.cdMainProcess

                            W4071.MachineCode = L4070.MachineCode
                            W4071.MachineTno = L4070.MachineTno

                            W4071.JobCard = W4070.JobCard
                            W4071.Szno = (i - FixCol + 1).ToString("00")

                            W4071.QtyPlan = CIntp(getData(vS1, i, 0))
                            If W4071.QtyPlan > 0 Then Call REWRITE_PFK4071(W4071) ' Else DELETE_PFK4071(W4071)

                            Call REWRITE_PFK4071(W4071)
                        Else
                            W4071 = D4071

                            W4071.cdFactory = L4070.cdFactory
                            W4071.cdMainProcess = L4070.cdMainProcess
                            W4071.MachineCode = L4070.MachineCode
                            W4071.MachineTno = L4070.MachineTno

                            W4071.JobCard = W4070.JobCard
                            W4071.Szno = (i - FixCol + 1).ToString("00")

                            W4071.QtyPlan = CIntp(getData(vS1, i, 0))
                            If W4071.QtyPlan > 0 Then Call WRITE_PFK4071(W4071)

                        End If
                    Next

                    isudCHK = True
                    WRITE_CHK = "*"
                    DATA_CHECKCOMPLETE = True
                End If
            End If
        Catch ex As Exception
            MsgBoxP("DATA_CHECKCOMPLETE!")
        End Try
    End Function
    Private Sub KEY_COUNT_NO()
        Dim YRNO As Integer
        YRNO = Pub.DAT
    End Sub
#End Region


#Region "Event"
    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles vS1.CellClick
        If e.ColumnHeader = True Then Exit Sub


        txt_Barcode.Data = getData(vS1, getColumIndex(vS1, "DyeingJobNo"), vS1.ActiveSheet.ActiveRowIndex)
        txt_ProcessSeq.Data = getData(vS1, getColumIndex(vS1, "ProcessSeq"), vS1.ActiveSheet.ActiveRowIndex)

    End Sub

    Private Sub vS1_KeyDown(sender As Object, e As KeyEventArgs) Handles vS1.KeyDown
        If wJOB = 2 Then Exit Sub

        Dim xCOL As Long
        Dim xROW As Long
        xROW = vS1.ActiveSheet.ActiveRowIndex
        xCOL = vS1.ActiveSheet.ActiveColumnIndex
        Select Case e.KeyCode
            Case Keys.Delete
                Msg_Result = MsgBoxP("Do you want to delete all?", vbYesNo)

                If Msg_Result <> vbYes Then Exit Sub

                If txt_DatePlan.Data <> Pub.DAT Then
                    MsgBoxP("Can not edit because of not today!")
                    If MsgBoxPPW("Please type the password to modify!", const_pwPrintUpdate) = False Then Exit Sub
                End If

                If DATA_DELETE(xROW) = True Then
                    Call SPR_DEL(vS1, 0, xROW)
                End If
            Case Else
                e.Handled = True
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

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Select Case wJOB
            Case 1
                Call DATA_CHECKCOMPLETE()
                Call MsgBoxP("Update Succesfully!", vbInformation)
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS0()
            Case 2
                Me.Dispose()
            Case 3
                If txt_DatePlan.Data <> Pub.DAT Then
                    MsgBoxP("Can not edit because of not today!")
                    If MsgBoxPPW("Please type the password to modify!", const_pwPrintUpdate) = False Then Exit Sub
                End If

                Call DATA_CHECKCOMPLETE()
                Call MsgBoxP("Update Succesfully!", vbInformation)
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS0()
            Case 4
                Call DATA_DELETE()
        End Select

    End Sub

    Private Sub cmd_DEL_Click(sender As Object, e As EventArgs) Handles cmd_DEL.Click

        If CHK(4) <> "1" Then MsgBoxP("You have no right in this program!") : Exit Sub
        Msg_Result = MsgBoxP("Do you want to delete all worksheet?", vbYesNo)

        If Msg_Result <> vbYes Then Exit Sub

        If txt_DatePlan.Data <> Pub.DAT Then
            MsgBoxP("Can not edit because of not today!")
            If MsgBoxPPW("Please type the password to modify!", const_pwPrintUpdate) = False Then Exit Sub
        End If
        Try
            Call DATA_DELETE()
            Me.Dispose()
        Catch ex As Exception
            MsgBoxP("cmd_DEL_Click")
        End Try
    End Sub


    Private Sub txt_GreyBarcode_txtTextKeyDown(sender As Object, e As KeyEventArgs) Handles txt_Barcode.txtTextKeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_DatePlan.Data = "" Then txt_DatePlan.Data = Pub.DAT
            If txt_cdFactory.Code = "" Then MsgBoxP("No Factory!") : Exit Sub

            If txt_DatePlan.Data <> Pub.DAT Then
                MsgBoxP("Can not edit because of not today!")
                If MsgBoxPPW("Please type the password to modify!", const_pwPrintUpdate) = False Then Exit Sub
            End If

            Call DATA_SEARCH_VS1_INSERT()
            txt_Barcode.Data = ""
            Me.Show()

            Application.DoEvents()
            Setfocus(txt_Barcode)
        End If
    End Sub

    Private Function Data_Check() As Boolean
        Data_Check = False
        Try

            Dim Scol As Integer
            Dim FixCol As Integer
            Dim i As Integer
            Dim j As Integer

            Scol = getColumIndex(vS1, "SizeQty01")
            FixCol = getColumIndex(vS1, "SizeQty01")

            For i = Scol To vS1.ActiveSheet.ColumnCount - 1
                If getDataM(vS1, i, 1) = "1" Then
                    Data_Check = True
                    Exit For
                End If
            Next

            If Data_Check = False Then Exit Function

            For i = 0 To vS2.ActiveSheet.RowCount - 1
                If getDataM(vS2, getColumIndex(vS2, "DCHK"), i) = "1" Then
                    If CIntp(getData(vS2, getColumIndex(vS2, "QtyBatchS"), i)) = 0 Or CIntp(getData(vS2, getColumIndex(vS2, "QtyBatchCnt"), i)) = 0 Then
                        Data_Check = False
                        Exit For
                    Else
                        Data_Check = True
                    End If
                End If
            Next
        Catch ex As Exception

        End Try
    End Function

    Private Sub cmd_Generate_Click(sender As Object, e As EventArgs) Handles cmd_Generate.Click
        If Data_Check() = False Then Exit Sub

        Dim Scol As Integer
        Dim FixCol As Integer
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer

        Dim StrMsg As String = MsgBox("Do you want to make a new batch ?", vbYesNo)
        If StrMsg <> vbYes Then Exit Sub

        Scol = getColumIndex(vS1, "SizeQty01")
        FixCol = getColumIndex(vS1, "SizeQty01")
        Call KEY_COUNT_K4075_BatchGroup()

        For i = Scol To vS1.ActiveSheet.ColumnCount - 1
            If getDataM(vS1, i, 1) = "1" Then


                If READ_PFK4071(L4070.cdFactory, L4070.cdMainProcess, L4070.MachineCode, L4070.MachineTno, (i - FixCol + 1).ToString("00")) Then
                    For k = 0 To vS2.ActiveSheet.RowCount - 1
                        If getDataM(vS2, getColumIndex(vS2, "DCHK"), k) = "1" Then
                            Call KEY_COUNT_K4075_Sno(D4071.Szno)
                            Call KEY_COUNT_K4075_BATCHNO()

                            W4075.BatchGroup = L4075.BatchGroup

                            W4075.DateBatch = Pub.DAT
                            W4075.SizeName = getDataCH(vS1, i, 0)

                            W4075.TypeBatch = "1"

                            W4075.InchargeBatch = txt_InchargePlan.Code

                            W4075.JobCard = D4071.JobCard
                            W4075.Szno = D4071.Szno
                            W4075.cdFactory = D4071.cdFactory
                            W4075.cdMainProcess = D4071.cdMainProcess
                            W4075.MachineCode = D4071.MachineCode
                            W4075.MachineTno = D4071.MachineTno

                            W4075.DateInsert = Pub.DAT
                            W4075.InchargeInsert = Pub.SAW
                            W4075.QtyBatch = CIntp(getData(vS2, getColumIndex(vS2, "QtyBatchS"), k))

                            W4075.MaterialSeq = getData(vS2, getColumIndex(vS2, "KEY_MaterialSeq"), k)

                            Call WRITE_PFK4075(W4075)
                        End If

                    Next

                End If
            End If
        Next

        Call DATA_SEARCH_VS1()
        Call DATA_SEARCH_VS0()
        txt_BatchGroup.Data = W4075.BatchGroup
        Call DATA_SEARCH_VS2()
    End Sub

    Private Sub vS2_KeyDown(sender As Object, e As KeyEventArgs) Handles vS2.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim JobCard As String
            Dim cdMainProcess As String
            Dim Szno As String
            Dim Sno As String


            JobCard = getData(vS2, getColumIndex(vS2, "Key_JobCard"), vS2.ActiveSheet.ActiveRowIndex)
            cdMainProcess = getData(vS2, getColumIndex(vS2, "Key_cdMainProcess"), vS2.ActiveSheet.ActiveRowIndex)
            Szno = getData(vS2, getColumIndex(vS2, "Key_Szno"), vS2.ActiveSheet.ActiveRowIndex)
            Sno = getData(vS2, getColumIndex(vS2, "Key_Sno"), vS2.ActiveSheet.ActiveRowIndex)

            Call Select_Message("3", WordConv("PROCESSING"), 2)

            If Msg_Result <> vbYes Then Exit Sub

            If READ_PFK4075(JobCard, Szno, cdMainProcess, Sno) = True Then
                W4075 = D4075
                If DELETE_PFK4075_CANCEL(W4075) = True Then
                    isudCHK = True
                End If
            End If

            SPR_DEL(vS2, 0, vS2.ActiveSheet.ActiveRowIndex)

        End If

    End Sub

    Private Sub vS0_CellClick(sender As Object, e As CellClickEventArgs) Handles vS0.CellClick
        txt_BatchGroup.Data = getData(vS0, getColumIndex(vS0, "Key_BatchGroup"), vS0.ActiveSheet.ActiveRowIndex)

        Call DATA_SEARCH_VS2()

    End Sub


#End Region
    Public Sub DATA_MOVE_BARCODE()

        Try
            PrintDocument1 = New Printing.PrintDocument
            PrintDocument1.Print()
        Catch ex As Exception
        End Try

    End Sub

    Public Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        gpp = e.Graphics
        Call TAG_PRINT_OS_PANEL()
    End Sub

    'Private Sub cmd_BarCode_Click(sender As Object, e As EventArgs) Handles cmd_BarCode.Click
    '    Dim Msg_Result As String
    '    Dim i As Integer
    '    Dim j As Integer
    '    Dim SizeNo As Integer
    '    Dim Cnt As Integer

    '    Try
    '        Msg_Result = MsgBoxP("TAG PRINT?", vbYesNo)
    '        If Msg_Result = vbYes Then
    '            For i = 0 To vS2.ActiveSheet.RowCount - 1

    '                If getDataM(vS2, getColumIndex(vS2, "DCHK"), i) = "1" Then
    '                    Call DATA_MOVE_BARCODE_2(getData(vS2, getColumIndex(vS2, "KEY_JobCard"), i),
    '                               getData(vS2, getColumIndex(vS2, "KEY_Szno"), i),
    '                               getData(vS2, getColumIndex(vS2, "Key_cdMainProcess"), i),
    '                               getData(vS2, getColumIndex(vS2, "KEY_Sno"), i))

    '                    Call DATA_MOVE_BARCODE()
    '                    OSPANEL1 = Nothing
    '                    OSPANEL2 = Nothing

    '                Else
    '                    Call DATA_MOVE_BARCODE_1(getData(vS2, getColumIndex(vS2, "KEY_JobCard"), i),
    '                             getData(vS2, getColumIndex(vS2, "KEY_Szno"), i),
    '                             getData(vS2, getColumIndex(vS2, "Key_cdMainProcess"), i),
    '                             getData(vS2, getColumIndex(vS2, "KEY_Sno"), i))

    '                End If

    '            Next


    '            If (Cnt Mod 2) = 1 Then
    '                Call DATA_MOVE_BARCODE()
    '            End If


    '        End If
    '    Catch ex As Exception
    '        MsgBoxP("DATA_MOVE_BARCODE")
    '    End Try

    'End Sub
    'Public Sub DATA_MOVE_BARCODE_2(JobCard As String, Szno As String, cdMainProcess As String, Sno As String)
    '    If READ_PFK4075(JobCard, Szno, cdMainProcess, Sno) Then
    '        OSPANEL2.DatePrint = Pub.DAT
    '        OSPANEL2.ColorName = txt_ColorName.Data

    '        OSPANEL2.SizeName = D4075.SizeName

    '        OSPANEL2.SlNo = txt_CustomerName.Data
    '        OSPANEL2.MoldName = txt_MCODEName.Data

    '        OSPANEL2.QtySize = D4075.QtyBatch
    '        OSPANEL2.Barcode = D4075.BatchNo

    '    End If
    'End Sub

    'Public Sub DATA_MOVE_BARCODE_1(JobCard As String, Szno As String, cdMainProcess As String, Sno As String)
    '    If READ_PFK4075(JobCard, Szno, cdMainProcess, Sno) Then
    '        OSPANEL1.DatePrint = Pub.DAT
    '        OSPANEL1.ColorName = txt_ColorName.Data

    '        OSPANEL1.SizeName = D4075.SizeName

    '        OSPANEL1.SlNo = txt_CustomerName.Data
    '        OSPANEL1.MoldName = txt_MCODEName.Data

    '        OSPANEL1.QtySize = D4075.QtyBatch
    '        OSPANEL1.Barcode = D4075.BatchNo

    '    End If


    'End Sub

    Private Sub cmd_BarCode_Click(sender As Object, e As EventArgs) Handles cmd_BarCode.Click
        Dim Msg_Result As String
        Dim i As Integer
        Dim j As Integer
        Dim SizeNo As Integer
        Dim Cnt As Integer
        Dim CheckFull As Boolean = False
        Dim CheckOne As Boolean = False
        Try
            Msg_Result = MsgBoxP("TAG PRINT?", vbYesNo)
            If Msg_Result = vbYes Then
                For i = 0 To vS2.ActiveSheet.RowCount - 1

                    If getDataM(vS2, getColumIndex(vS2, "DCHK"), i) = "1" Then
                        If CheckOne = False Then
                            Call DATA_MOVE_BARCODE_1(getData(vS2, getColumIndex(vS2, "Batchno"), i)) : CheckOne = True
                        Else
                            DATA_MOVE_BARCODE_2(getData(vS2, getColumIndex(vS2, "Batchno"), i))
                            CheckFull = True
                            Call DATA_MOVE_BARCODE()

                            OSPANEL1 = Nothing
                            OSPANEL2 = Nothing

                            CheckOne = False
                            CheckFull = True

                        End If


                    End If

                Next

            End If

            If CheckOne = True Then Call DATA_MOVE_BARCODE()

        Catch ex As Exception
            MsgBoxP("DATA_MOVE_BARCODE")
        End Try

    End Sub
    Public Sub DATA_MOVE_BARCODE_2(Batchno As String)
        If READ_PFK4075_BatchNo(Batchno) Then
            OSPANEL2.DatePrint = Pub.DAT
            OSPANEL2.ColorName = txt_OutsoleColorCode.Data & "-" & txt_LogoColorCode.Data

            OSPANEL2.SizeName = D4075.SizeName

            OSPANEL2.SlNo = txt_SLNo.Data
            OSPANEL2.MoldName = txt_MoldCode.Data

            OSPANEL2.QtySize = D4075.QtyBatch
            OSPANEL2.Barcode = D4075.BatchNo

            OSPANEL2.OSColorCode = txt_OutsoleColorCode.Data
            OSPANEL2.OSColorName = txt_OutsoleColor.Data

            OSPANEL2.LGColorCode = txt_LogoColorCode.Data
            OSPANEL2.LGColorName = txt_LogoColor.Data

        End If
    End Sub

    Public Sub DATA_MOVE_BARCODE_1(Batchno As String)
        If READ_PFK4075_BatchNo(Batchno) Then
            OSPANEL1.DatePrint = Pub.DAT
            OSPANEL1.ColorName = txt_OutsoleColorCode.Data & "-" & txt_LogoColorCode.Data

            OSPANEL1.SizeName = D4075.SizeName

            OSPANEL1.SlNo = txt_SLNo.Data
            OSPANEL1.MoldName = txt_MoldCode.Data

            OSPANEL1.QtySize = D4075.QtyBatch
            OSPANEL1.Barcode = D4075.BatchNo

            OSPANEL2.OSColorCode = txt_OutsoleColorCode.Data
            OSPANEL2.OSColorName = txt_OutsoleColor.Data

            OSPANEL2.LGColorCode = txt_LogoColorCode.Data
            OSPANEL2.LGColorName = txt_LogoColor.Data

        End If


    End Sub

    Private Sub cmd_CuttingBL_Click(sender As Object, e As EventArgs) Handles cmd_CuttingBL.Click
        Call HLP4070A.Link_HLP4070A(txt_JobCard.Data, txt_cdMainProcess.Code)

    End Sub
End Class