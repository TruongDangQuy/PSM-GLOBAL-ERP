Imports System.Net.Mail
Imports System.Text
Imports System.IO.Ports

Public Class ISUD4080A

#Region "Variable"
    Private wJOB As Integer

    Private W4080 As New T4080_AREA
    Private L4080 As New T4080_AREA

    Private W4082 As New T4082_AREA
    Private L4082 As New T4082_AREA

    Private WRITE_CHK As String
    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD4080A(job As Integer, ProdDate As String, ProdSeq As String, cdMainProcess As String, cdMachineType As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D4080.cdMainProcess = cdMainProcess
        D4080.cdMachineType = cdMachineType
        D4080.ProdDate = ProdDate
        D4080.ProdSeq = ProdSeq

        D4082.ProdDate = ProdDate
        D4082.ProdSeq = ProdSeq

        txt_cdMainProcess.Code = cdMainProcess
        txt_cdMachineType.Code = cdMachineType


        If READ_PFK7171(ListCode("MainProcess"), cdMainProcess) = True Then
            txt_cdMainProcess.Data = D7171.BasicName
            txt_cdMainProcess.Code = D7171.BasicCode

            If READ_PFK7171(Const_MachineType, D7171.Check6) Then
                txt_cdMachineType.Code = D7171.BasicCode
                txt_cdMachineType.Data = D7171.BasicName
                D4080.cdMachineType = D7171.BasicCode
            End If
        End If

        If READ_PFK7411(Pub.SAW) = True Then
            txt_InchargeProdution.Code = D7411.IDNO
            txt_InchargeProdution.Code = D7411.Name
        End If

        wJOB = job : L4080 = D4080 : L4082 = D4082

        Link_ISUD4080A = False
        Try
            formA = False


            Select Case job
                Case 1

                Case Else
                    If READ_PFK4080(ProdDate, ProdSeq) Then
                        L4080 = D4080
                    End If
            End Select

            Me.ShowDialog()

            Link_ISUD4080A = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))
        End Try


    End Function

    Public Function Link_ISUD4080A_AUTO(job As Integer, JobCard As String, SpecSeq As String, cdMainProcess As String, cdMachineType As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        CheckLink = True
        txt_JobCard.Data = JobCard & SpecSeq

        D4080.cdMainProcess = cdMainProcess
        D4080.cdMachineType = cdMachineType

        txt_cdMainProcess.Code = cdMainProcess
        txt_cdMachineType.Code = cdMachineType

        If READ_PFK7171(ListCode("MainProcess"), cdMainProcess) = True Then
            txt_cdMainProcess.Data = D7171.BasicName
            txt_cdMainProcess.Code = D7171.BasicCode

            If READ_PFK7171(Const_MachineType, D7171.Check6) Then
                txt_cdMachineType.Code = D7171.BasicCode
                txt_cdMachineType.Data = D7171.BasicName
                D4080.cdMachineType = D7171.BasicCode
            End If
        End If

        If READ_PFK7411(Pub.SAW) = True Then
            txt_InchargeProdution.Code = D7411.IDNO
            txt_InchargeProdution.Code = D7411.Name
        End If

        wJOB = job : L4080 = D4080

        Link_ISUD4080A_AUTO = False
        Try
            formA = False


            Select Case job
                Case 1

                Case Else

            End Select

            Me.ShowDialog()

            Link_ISUD4080A_AUTO = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))
        End Try


    End Function

    Private CheckLink As Boolean = False
    Public Function Link_ISUD4080A_AUTO_4070(job As Integer, JobCard As String, cdFactory As String, MachineCode As String, MachineTno As String, cdMainProcess As String, cdMachineType As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        CheckLink = True
        txt_JobCard.Data = JobCard

        D4080.cdMainProcess = cdMainProcess
        D4080.cdMachineType = cdMachineType
        D4080.ProdDate = Pub.DAT
        D4080.DateProduction = Pub.DAT

        D4080.cdFactory = cdFactory
        D4080.MachineCode = MachineCode
        D4080.MachineTno = MachineTno
        D4080.cdMainProcess = cdMainProcess

        D4080.JobCard = JobCard

        txt_cdMainProcess.Code = cdMainProcess
        txt_cdMachineType.Code = cdMachineType

        If READ_PFK7171(ListCode("MainProcess"), cdMainProcess) = True Then
            txt_cdMainProcess.Data = D7171.BasicName
            txt_cdMainProcess.Code = D7171.BasicCode


            If READ_PFK7171(Const_MachineType, D7171.Check6) Then
                txt_cdMachineType.Code = D7171.BasicCode
                txt_cdMachineType.Data = D7171.BasicName
                D4080.cdMachineType = D7171.BasicCode
            End If
        End If

        If READ_PFK7171(ListCode("Factory"), cdFactory) = True Then
            txt_cdFactory.Data = D7171.BasicName
            txt_cdFactory.Code = D7171.BasicCode
        End If

        If READ_PFK7171(ListCode("LineProd"), MachineCode) = True Then
            txt_MachineCode.Data = D7171.BasicName
            txt_MachineCode.Code = D7171.BasicCode
        End If

        If READ_PFK7411(Pub.SAW) = True Then
            txt_InchargeProdution.Code = D7411.IDNO
            txt_InchargeProdution.Code = D7411.Name
        End If

        If READ_PFK4070(cdFactory, cdMainProcess, MachineCode, MachineTno) Then
            L4080.JobCard = D4070.JobCard
        End If

        txt_cdFactory.Enabled = False
        txt_cdMainProcess.Enabled = False
        txt_cdMainProcess.Enabled = False
        txt_cdMachineType.Enabled = False

        wJOB = job : L4080 = D4080

        Link_ISUD4080A_AUTO_4070 = False
        Try
            formA = False


            Select Case job
                Case 1

                Case Else

            End Select

            Me.ShowDialog()

            Link_ISUD4080A_AUTO_4070 = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))
        End Try


    End Function
#End Region

#Region "Form"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""

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

                Me.Text = Me.Text & " - INSERT"
                cmd_DEL.Visible = False
                L4080.ProdDate = Pub.DAT
                W4080.ProdSeq = Pub.DAT
                Me.Show()
                Application.DoEvents()
                Setfocus(txt_cdFactory)

                If CheckLink = True Then Setfocus(txt_QtyProduction)

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
                        GoTo Begin
                    End If
                End If

                Me.Text = Me.Text & " - UPDATE"
                cmd_DEL.Visible = False
                txt_MachineCode.Enabled = True

                txt_cdFactory.Enabled = False
                txt_cdMainProcess.Enabled = False
                txt_cdMainProcess.Enabled = False
                txt_cdMachineType.Enabled = False

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH_HEAD_TAB1()
                Call DATA_SEARCH_vS0()
                Call DATA_SEARCH_vS1()

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
                txt_MachineCode.Enabled = False

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH_HEAD_TAB1()
                Call DATA_SEARCH_VS0()
                Call DATA_SEARCH_VS1()

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

                Me.Text = Me.Text & " - INSERT AUTO"
                cmd_DEL.Visible = True

                cmd_OK.Visible = True
                txt_MachineCode.Enabled = True

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH_HEAD_TAB1()
                Call DATA_SEARCH_VS0()
                Call DATA_SEARCH_vS1()

                Call txt_GreyBarcode_txtTextKeyDown(sender, New System.Windows.Forms.KeyEventArgs(Keys.Enter))

                Setfocus(txt_QtyProduction)

                If CheckLink = True Then Setfocus(txt_QtyProduction)

                wJOB = 1

        End Select


        formA = True
    End Sub
#End Region

#Region "Search"
    Private Sub DATA_INIT()
        Try
            Me.WindowState = FormWindowState.Maximized

            txt_STimeProduction.Data = FSDateTime(System_Date_time)
            txt_ETimeProduction.Data = FSDateTime(System_Date_time)
            txt_DateProduction.Data = System_Date_8()

            txt_InchargeProdution.Data = Pub.NAM

            txt_DateProduction.Enabled = True
            txt_MachineCode.Enabled = True

        Catch ex As Exception
            Call MsgBoxP("DATA_INIT")
        End Try
    End Sub

    Private Sub FORM_INIT()
        RemoveHandler txt_ETimeProduction.txtTextKeyDown, AddressOf standard_KeyDown

        txt_ETimeProduction.PeaceTextbox1.EnterMoveNextControl = False

    End Sub
    Private Sub KEY_COUNT_CHANGE()
        Dim YRNO As Integer
        YRNO = Mid(System_Date_8(), 3, 4)
        Try
            SQL = "SELECT MAX(CAST(RIGHT(K4080_MachineCode,2) AS DECIMAL)) AS MAX_MCODE FROM PFK4080 "
            SQL = SQL & " WHERE K4080_MachineCode = '" & L4080.MachineCode & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                MsgBoxP("They had been deleted already!")
                rd.Close()
                Me.Dispose()
                Exit Sub
            Else
                W4080.MachineCode = Strings.Left(L4080.MachineCode, 11) & Format(CInt(rd!MAX_MCODE + 1), "00")
            End If

            rd.Close()
            L4080.MachineCode = W4080.MachineCode
            'txt_MachineCode.Data = W4080.MachineCode

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

    Private Sub KEY_COUNT()
        Dim YRNO As Integer
        YRNO = Mid(System_Date_8(), 3, 4)
        Try
            SQL = "SELECT MAX(CAST(K4080_ProdSeq AS DECIMAL)) AS MAX_MCODE FROM PFK4080 "
            SQL = SQL & " WHERE K4080_ProdDate = '" & L4080.ProdDate & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                L4080.ProdSeq = "00001"
            Else
                L4080.ProdSeq = CInt(rd!MAX_MCODE + 1).ToString("00000")
            End If

            rd.Close()
            W4080.ProdSeq = L4080.ProdSeq

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

    Private Function DATA_SEARCH_HEAD() As Boolean
        DATA_SEARCH_HEAD = False
        Try

            DS1 = READ_PFK4080(L4080.ProdDate, L4080.ProdSeq, cn)

            If GetDsRc(DS1) = 0 Then
                Exit Function
            End If

            READER_MOVE(Me, DS1)

            Call K4080_PartProduction(GetDsData(DS1, 0, "K4080_PartProduction"))

            L4080.JobCard = GetDsData(DS1, 0, "K4080_JobCard")

            txt_JobCard.Data = L4080.JobCard

            DATA_SEARCH_HEAD = True

            If READ_PFK7155(GetDsData(DS1, 0, "K4080_MachineCode")) = True Then
                txt_MachineCode.Data = D7155.MachineName
                txt_MachineCode.Code = D7155.MachineCode
            End If

            txt_STimeProduction.Data = FSDateTime(txt_STimeProduction.Data)
            txt_ETimeProduction.Data = FSDateTime(txt_ETimeProduction.Data)

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH01")
        End Try
    End Function
    Private Function DATA_SEARCH_HEAD_TAB1() As Boolean
        DATA_SEARCH_HEAD_TAB1 = False
        Try
            DS1 = PrcDS("USP_ISUD4080A_SEARCH_HEAD", cn, L4080.JobCard)

            If GetDsRc(DS1) = 0 Then
                Exit Function
            End If

            STORE_MOVE(Me, DS1)

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH01")
        End Try
    End Function

    Private Function DATA_SEARCH_vS0() As Boolean
        DATA_SEARCH_vS0 = False
        Try
            DS1 = PrcDS("USP_ISUD4080A_SEARCH_vS0", cn, L4080.ProdDate, L4080.ProdSeq)

            If GetDsRc(DS1) = 0 Then
                SPR_SET(vS0, , , , OperationMode.SingleSelect)
                SPR_PRO(vS0, DS1, "USP_ISUD4080A_SEARCH_vS0", "vS0")
                vS0.Enabled = True
                Exit Function
            End If

            SPR_SET(vS0, , , , OperationMode.SingleSelect)
            SPR_PRO(vS0, DS1, "USP_ISUD4080A_SEARCH_vS0", "vS0")
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH01")
        End Try
    End Function

    Private Function DATA_SEARCH_vS1() As Boolean
        DATA_SEARCH_vS1 = False
        Try
            DS1 = PrcDS("USP_ISUD4080A_SEARCH_VS1", cn, L4080.ProdDate, L4080.ProdSeq)

            If GetDsRc(DS1) = 0 Then
                SPR_SET(vS1, , , , OperationMode.SingleSelect)
                SPR_PRO(vS1, DS1, "USP_ISUD4080A_SEARCH_VS1", "vs1")
                Call VsSizeRangeNew(vS1, "USP_VS_SIZERANGE_ITEMBASE", "SizeQty01", L4080.JobCard)
                vS1.ActiveSheet.RowCount = 1
                vS1.Enabled = True
                Exit Function
            End If

            SPR_SET(vS1, , , , OperationMode.SingleSelect)
            SPR_PRO(vS1, DS1, "USP_ISUD4080A_SEARCH_VS1", "vs1")
            Call VsSizeRangeNew(vS1, "USP_VS_SIZERANGE_ITEMBASE", "SizeQty01", L4080.JobCard)

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH01")
        End Try
    End Function


    Private Function DATA_DELETE() As Boolean
        DATA_DELETE = False
        Try
            Dim i As Integer
            Dim Scol As Integer
            Dim FixCol As Integer

            Scol = getColumIndex(vS1, "SizeQty01")
            FixCol = getColumIndex(vS1, "SizeQty01")

            For i = Scol To vS1.ActiveSheet.ColumnCount - 1
                If READ_PFK4082(L4080.ProdDate, L4080.ProdSeq, (i - FixCol + 1).ToString("00")) Then
                    W4082 = D4082
                    DELETE_PFK4082(W4082)
                End If
            Next

            If READ_PFK4080(L4080.ProdDate, L4080.ProdSeq) = True Then
                W4080 = D4080
                If DELETE_PFK4080(W4080) = True Then
                    isudCHK = True
                    DATA_DELETE = True
                End If
            End If


        Catch ex As Exception
            MsgBoxP("DATA_MOVE!")
        End Try
    End Function


    Private Function CheckItemCode(ItemCode As String) As Boolean
        CheckItemCode = False
        Try

        Catch ex As Exception
            MsgBoxP("CheckItemCode")
        End Try
    End Function

    Private Function DATA_SEARCH_VS1_INSERT() As Boolean
        DATA_SEARCH_VS1_INSERT = False

        Try
            txt_JobCard.Data = FormatCut(txt_JobCard.Data)

            If Len(txt_JobCard.Data) <> 9 Then txt_JobCard.Data = "" : Setfocus(txt_JobCard) : Exit Function

            L4080.JobCard = txt_JobCard.Data

            DS1 = PrcDS("USP_ISUD4080A_SEARCH_HEAD", cn, L4080.JobCard)

            If GetDsRc(DS1) = 0 Then
                txt_JobCard.Data = ""
                MsgBoxP("No data. Check, please!")
                Setfocus(txt_JobCard)
                Exit Function
            End If

            STORE_MOVE(Me, DS1)

            DATA_SEARCH_VS1_INSERT = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try
    End Function




    Private Sub K4080_PartProduction()
        W4080.PartProduction = "1"
        If rad_PartProduction1.Checked = True Then W4080.PartProduction = "1" : Exit Sub
        If rad_PartProduction2.Checked = True Then W4080.PartProduction = "2" : Exit Sub
        If rad_PartProduction3.Checked = True Then W4080.PartProduction = "3" : Exit Sub
    End Sub

    Private Sub K4080_PartProduction(Value As String)
        rad_PartProduction1.Checked = True
        If Value = "1" Then rad_PartProduction1.Checked = True : Exit Sub
        If Value = "2" Then rad_PartProduction2.Checked = True : Exit Sub
        If Value = "3" Then rad_PartProduction3.Checked = True : Exit Sub
    End Sub


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
            If READ_PFK4080(L4080.ProdDate, L4080.ProdSeq) = False Then
                Call KEY_COUNT()

                W4080.ProdDate = L4080.ProdDate
                W4080.ProdSeq = L4080.ProdSeq

                W4080.JobCard = L4080.JobCard

                W4080.cdMainProcess = txt_cdMainProcess.Code
                W4080.cdMachineType = txt_cdMachineType.Code
                W4080.cdFactory = txt_cdFactory.Code
                W4080.MachineCode = txt_MachineCode.Code
                W4080.MachineTno = L4080.MachineTno

                W4080.seMainProcess = ListCode("MainProcess")
                W4080.seMachineType = ListCode("MachineType")
                W4080.seFactory = ListCode("Factory")

                W4080.InchargeProdution = txt_InchargeProdution.Code
                W4080.STimeProduction = FormatCut(txt_STimeProduction.Data)
                W4080.ETimeProduction = FormatCut(txt_ETimeProduction.Data)
                K4080_PartProduction()

                W4080.DateProduction = FormatCut(txt_DateProduction.Data)
                W4080.CheckComplete = "1"

                W4080.ISUD = "I"

                If WRITE_PFK4080(W4080) = True Then
                    Call DATA_MOVE_WRITE()
                    isudCHK = True
                End If
            Else
                W4080.STimeProduction = FormatCut(txt_STimeProduction.Data)
                W4080.ETimeProduction = FormatCut(txt_ETimeProduction.Data)
                W4080.InchargeProdution = Pub.SAW

                W4080.DateProduction = FormatCut(txt_DateProduction.Data)

                W4080.seMainProcess = ListCode("MainProcess")
                W4080.seMachineType = ListCode("MachineType")

                W4080.seFactory = ListCode("Factory")

                W4080.ISUD = "U"

                If REWRITE_PFK4080(W4080) = True Then
                    Call DATA_MOVE_WRITE()
                    isudCHK = True
                End If
            End If
        Catch ex As Exception
            MsgBoxP("DATA_CHECKCOMPLETE!")
        End Try
    End Function
    Private Sub KEY_COUNT_NO()
        Dim YRNO As Integer
        YRNO = System_Date_8()

        'Try
        '    SQL = "SELECT MAX(CAST(K1132_MachineCodeRoll AS DECIMAL)) AS MAX_MCODE FROM PFK1132 "
        '    SQL = SQL & " WHERE K1132_SelFabric = '1' "
        '    SQL = SQL & " AND K1132_MachineCode = '" & txt_MachineCode.Data & "' "

        '    cmd = New SqlClient.SqlCommand(SQL, cn)
        '    rd = cmd.ExecuteReader
        '    rd.Read()

        '    If IsDBNull(rd!MAX_MCODE) Then
        '        W1132.MachineCodeRoll = 1
        '    Else
        '        W1132.MachineCodeRoll = CInt(rd!MAX_MCODE + 1)
        '    End If

        '    rd.Close()

        '    L1132.MachineCodeRoll = W1132.MachineCodeRoll

        'Catch ex As Exception
        '    Call MsgBoxP("KEY_COUNT_NO")
        'End Try

    End Sub
#End Region

#Region "Event"
    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles vS1.CellClick
        Exit Sub

        Dim ProcessCurrentDate As String
        If e.ColumnHeader = True Then Exit Sub

        ProcessCurrentDate = getData(vS1, getColumIndex(vS1, "ProcessCurrentDate"), vS1.ActiveSheet.ActiveRowIndex)

        DS1 = PrcDS("USP_ISUD4080A_SEARCH_HEAD_Spec", cn, L4080.JobCard, L4080.cdMainProcess)

        If GetDsRc(DS1) = 0 Then Exit Sub

        If L4080.cdMainProcess <> GetDsData(DS1, 0, "cdMainProcess") Then
            txt_QtyProduction.Data = ""
            txt_QtyProductionA.Data = ""
            txt_QtyProductionX.Data = ""

            MsgBoxP("Wrong process!") : Exit Sub
        End If

        txt_QtyProduction.Data = GetDsData(DS1, 0, "QtyProduction")
        txt_QtyProductionA.Data = GetDsData(DS1, 0, "QtyProductionA")
        txt_QtyProductionX.Data = GetDsData(DS1, 0, "QtyProductionX")

    End Sub

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
        Try

            If txt_cdMachineType.Code = "" Then MsgBoxP("MachineType on this!") : Setfocus(txt_cdMachineType) : Exit Function
            If txt_cdMainProcess.Code = "" Then MsgBoxP("ProcessProduction on this!") : Setfocus(txt_cdMainProcess) : Exit Function
            If txt_JobCard.Data = "" Then MsgBoxP("JobCard on this!") : Setfocus(txt_JobCard) : Exit Function
            If FormatCut(txt_DateProduction.Data) = "" Then MsgBoxP("Date Prod on this!") : Setfocus(txt_DateProduction) : Exit Function

            If txt_cdFactory.Code = "" Then MsgBoxP("Factory on this!") : Setfocus(txt_cdFactory) : Exit Function
            If txt_cdMainProcess.Code = "" Then MsgBoxP("MainProcess on this!") : Setfocus(txt_cdMainProcess) : Exit Function
            If txt_cdMainProcess.Code = "" Then MsgBoxP("MainProcess on this!") : Setfocus(txt_cdMainProcess) : Exit Function
            If txt_MachineCode.Code = "" Then MsgBoxP("LineProd on this!") : Setfocus(txt_MachineCode) : Exit Function

            Data_Check = True
        Catch ex As Exception
            MsgBoxP("Data_Check")
        End Try
    End Function

    Private Sub DATA_MOVE_WRITE()
        Dim i As Integer
        Dim Scol As Integer
        Dim FixCol As Integer

        Scol = getColumIndex(vS1, "SizeQty01")
        FixCol = getColumIndex(vS1, "SizeQty01")

        For i = Scol To vS1.ActiveSheet.ColumnCount - 1
            If READ_PFK4082(L4080.ProdDate, L4080.ProdSeq, (i - FixCol + 1).ToString("00")) Then
                W4082 = D4082
                W4082.QtyProduction = CIntp(getData(vS1, i, 0))
                W4082.QtyProductionA = CIntp(getData(vS1, i, 0))

                If W4082.QtyProduction > 0 Then Call REWRITE_PFK4082(W4082) Else DELETE_PFK4082(W4082)

            Else
                W4082 = D4082
                W4082.ProdDate = L4080.ProdDate
                W4082.ProdSeq = L4080.ProdSeq
                W4082.ProdSzno = (i - FixCol + 1).ToString("00")
                W4082.QtyProduction = CIntp(getData(vS1, i, 0))
                W4082.QtyProductionA = CIntp(getData(vS1, i, 0))

                If W4082.QtyProduction > 0 Then Call WRITE_PFK4082(W4082)

            End If
        Next
    End Sub
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Select Case wJOB
            Case 1
                If Data_Check() = False Then Exit Sub
                Call KEY_COUNT()
                Call DATA_CHECKCOMPLETE()
                Call MsgBoxP("Insert Succesfully!", vbInformation)
                Me.Dispose()
            Case 2
                Me.Dispose()
            Case 3
                If Data_Check() = False Then Exit Sub
                Call DATA_CHECKCOMPLETE()
                Call MsgBoxP("Update Succesfully!", vbInformation)
                Me.Dispose()
            Case 4
                Call DATA_DELETE()
        End Select

    End Sub

    Private Sub cmd_DEL_Click(sender As Object, e As EventArgs) Handles cmd_DEL.Click

        If CHK(4) <> "1" Then MsgBoxP("You have no right in this program!") : Exit Sub
        Msg_Result = MsgBoxP("Do you want to delete all worksheet?", vbYesNo)

        If Msg_Result <> vbYes Then Exit Sub

        Try
            Call DATA_DELETE()
            Me.Dispose()
        Catch ex As Exception
            MsgBoxP("cmd_DEL_Click")
        End Try
    End Sub


    Private Sub txt_GreyBarcode_txtTextKeyDown(sender As Object, e As KeyEventArgs) Handles txt_JobCard.txtTextKeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_DateProduction.Data = "" Then txt_DateProduction.Data = System_Date_8()

            If Data_Check() = False Then Exit Sub

            If DATA_SEARCH_VS1_INSERT() = True Then
                DATA_SEARCH_vS1()
            End If
            Me.Show()
            Application.DoEvents()
            vS1.Focus()

            e.Handled = True

            Setfocus(txt_QtyProduction)

        End If

        If txt_JobCard.Data = "" Then
            Call Me.Form_ClearData()
            vS1.ActiveSheet.RowCount = 0
            Call DATA_INIT()

        End If
    End Sub

    Private Sub txt_ETimeProduction_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ETimeProduction.txtTextKeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            cmd_OK.Select()
        End If
    End Sub


    Private Sub vS0_CellClick(sender As Object, e As CellClickEventArgs) Handles vS0.CellClick
        Dim KEY_ProdDate As String
        Dim KEY_ProdSeq As String

        KEY_ProdDate = getData(vS0, getColumIndex(vS0, "KEY_ProdDate"), e.Row)
        KEY_ProdSeq = getData(vS0, getColumIndex(vS0, "KEY_ProdSeq"), e.Row)

        If FormatCut(KEY_ProdDate) = "" Then Exit Sub
        L4080.ProdDate = KEY_ProdDate
        L4080.ProdSeq = KEY_ProdSeq

        L4082.ProdDate = KEY_ProdDate
        L4082.ProdSeq = KEY_ProdSeq

        wJOB = 3

        Call DATA_SEARCH_vS1()

    End Sub

#End Region






End Class