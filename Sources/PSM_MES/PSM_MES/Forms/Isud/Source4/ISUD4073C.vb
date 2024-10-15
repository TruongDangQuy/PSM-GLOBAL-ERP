Imports System.Net.Mail
Imports System.Text
Imports System.IO.Ports

Public Class ISUD4073C

#Region "Variable"
    Private wJOB As Integer

    Private W4073 As New T4073_AREA
    Private L4073 As New T4073_AREA

    Private W4075 As New T4075_AREA
    Private L4075 As New T4075_AREA

    Private W4074 As New T4074_AREA
    Private L4074 As New T4074_AREA

    Private WRITE_CHK As String
    Private formA As Boolean
    Private CHK(0 To 5) As String

    Private _QtyBase As String = "5"

#End Region

#Region "Link"

    Public Function Link_ISUD4073C(job As Integer, cdFactory As String, cdMainProcess As String, cdLineProd As String, LineTno As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D4073.cdLineProd = cdLineProd
        D4073.cdFactory = cdFactory
        D4073.cdMainProcess = cdMainProcess
        D4073.LineTno = LineTno

        D4074.cdLineProd = cdLineProd
        D4074.cdFactory = cdFactory
        D4074.cdMainProcess = cdMainProcess
        D4074.LineTno = LineTno

        txt_cdFactory.Data = cdFactory
        txt_cdMainProcess.Data = cdMainProcess
        txt_cdLineProd.Data = cdLineProd
        txt_LineTno.Data = LineTno

        txt_cdFactory.Code = cdFactory
        txt_cdMainProcess.Code = cdMainProcess
        txt_cdLineProd.Code = cdLineProd
        txt_LineTno.Code = LineTno

        wJOB = job : L4073 = D4073

        Link_ISUD4073C = False
        Try
            formA = False


            Select Case job
                Case 1

                Case 5

                Case Else
                    If READ_PFK4073(cdFactory, cdMainProcess, cdLineProd, LineTno) Then
                        If D4073.CheckComplete <> "1" Then wJOB = 2
                    Else
                        Exit Function
                    End If

            End Select

            Me.ShowDialog()

            Link_ISUD4073C = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))
        End Try


    End Function
    Public Function Link_ISUD4073C_QTYBASE(job As Integer, cdFactory As String, cdMainProcess As String, cdLineProd As String, LineTno As String, QtyBase As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG

        _QtyBase = QtyBase

        D4073.cdLineProd = cdLineProd
        D4073.cdFactory = cdFactory
        D4073.cdMainProcess = cdMainProcess
        D4073.LineTno = LineTno

        D4074.cdLineProd = cdLineProd
        D4074.cdFactory = cdFactory
        D4074.cdMainProcess = cdMainProcess
        D4074.LineTno = LineTno

        txt_cdFactory.Data = cdFactory
        txt_cdMainProcess.Data = cdMainProcess
        txt_cdLineProd.Data = cdLineProd
        txt_LineTno.Data = LineTno

        txt_cdFactory.Code = cdFactory
        txt_cdMainProcess.Code = cdMainProcess
        txt_cdLineProd.Code = cdLineProd
        txt_LineTno.Code = LineTno

        wJOB = job : L4073 = D4073

        Link_ISUD4073C_QTYBASE = False
        Try
            formA = False


            Select Case job
                Case 1

                Case 5

                Case Else
                    If READ_PFK4073(cdFactory, cdMainProcess, cdLineProd, LineTno) Then
                        If D4073.CheckComplete <> "1" Then wJOB = 2
                    Else
                        Exit Function
                    End If

            End Select

            Me.ShowDialog()

            Link_ISUD4073C_QTYBASE = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))
        End Try


    End Function
    Public Function Link_ISUD4073C_JobCard(job As Integer, JobCard As String, cdFactory As String, cdMainProcess As String, cdLineProd As String, LineTno As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D4073.cdLineProd = cdLineProd
        D4073.cdFactory = cdFactory
        D4073.cdMainProcess = cdMainProcess
        D4073.LineTno = LineTno
        D4073.JobCard = JobCard

        D4074.cdLineProd = cdLineProd
        D4074.cdFactory = cdFactory
        D4074.cdMainProcess = cdMainProcess
        D4074.LineTno = LineTno

        txt_cdFactory.Data = cdFactory
        txt_cdMainProcess.Data = cdMainProcess
        txt_cdLineProd.Data = cdLineProd
        txt_LineTno.Data = LineTno

        txt_cdFactory.Code = cdFactory
        txt_cdMainProcess.Code = cdMainProcess
        txt_cdLineProd.Code = cdLineProd
        txt_LineTno.Code = LineTno
        txt_JobCard.Code = JobCard
        txt_JobCard.Data = JobCard


        wJOB = job : L4073 = D4073

        Link_ISUD4073C_JobCard = False
        Try
            formA = False


            Select Case job
                Case 1, 11

                Case Else
                    If READ_PFK4073(cdFactory, cdMainProcess, cdLineProd, LineTno) Then
                    Else
                        Exit Function
                    End If

            End Select

            Me.ShowDialog()

            Link_ISUD4073C_JobCard = isudCHK


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
                Call K4073_CheckComplete(True, False, False, False, False, False)

                Me.Text = Me.Text & " - INSERT"

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
                cmd_OK.Visible = True


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

                        GoTo Begin
                    End If
                End If

                Me.Text = Me.Text & " - UPDATE"

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH_HEAD_TAB1()
                Call DATA_SEARCH_VS0()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()

                Call K4073_CheckComplete(False, False, False, False, False, False)

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

                        GoTo Begin
                    End If
                End If

                Me.Text = Me.Text & " - DELETE"
            
                cmd_OK.Visible = False

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH_HEAD_TAB1()
                Call DATA_SEARCH_VS0()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()

                Call K4073_CheckComplete(False, False, False, False, False, False)

            Case 5
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

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH_HEAD_TAB1()
                Call DATA_SEARCH_VS0()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()

                Call K4073_CheckComplete(True, True, True, True, True, True)

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

                        GoTo Begin
                    End If
                End If


                cmd_OK.Visible = True

                Call KEY_COUNT()
                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH_VS0()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()

                Call K4073_CheckComplete(True, False, False, False, False, False)

                txt_Barcode.Data = L4073.JobCard

                Call txt_GreyBarcode_txtTextKeyDown(sender, New System.Windows.Forms.KeyEventArgs(Keys.Enter))

                wJOB = 1
                Me.Text = Me.Text & " - INSERT"
                cmd_OK.Visible = True

        End Select

        cmd_OK.Visible = True

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

        vS1.HorizontalScrollBarPolicy = ScrollBarPolicy.Never
        'Me.WindowState = FormWindowState.Maximized
        txt_Barcode.PeaceTextbox1.Properties.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub KEY_COUNT()
        Try
            SQL = "SELECT MAX(CAST(K4073_LineTno AS DECIMAL)) AS MAX_MCODE FROM PFK4073 "
            SQL = SQL & " WHERE K4073_cdFactory = '" & txt_cdFactory.Code & "' "
            SQL = SQL & " AND K4073_cdMainProcess = '" & txt_cdMainProcess.Code & "' "
            SQL = SQL & " AND K4073_cdLineProd = '" & txt_cdLineProd.Code & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                L4073.LineTno = "01"
            Else
                L4073.LineTno = CIntp(rd!MAX_MCODE + 1).ToString("00")
            End If

            W4073.LineTno = L4073.LineTno
            txt_LineTno.Data = L4073.LineTno

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
            SQL = SQL & " WHERE SUBSTRING(K4075_BatchGroup,1,6) = 'ST" & YRNO.ToString & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                L4075.BatchGroup = "ST" & YRNO.ToString & "0001"
            Else
                L4075.BatchGroup = "ST" & YRNO.ToString & CIntp(rd!MAX_MCODE + 1).ToString("0000")
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

            If READ_PFK4073(L4073.cdFactory, L4073.cdMainProcess, L4073.cdLineProd, L4073.LineTno) = False Then Exit Function



            DS1 = PrcDS("USP_ISUD4073B_SEARCH_VS1_INSERT", cn, D4073.JobCard)

            If GetDsRc(DS1) = 0 Then
                vS1.Enabled = True
                SPR_SET(vS1, , , , OperationMode.Normal)
                SPR_PRO(vS1, DS1, "USP_ISUD4073B_SEARCH_vS1", "Vs1")
                Exit Function
            End If

            SPR_SET(vS1, , , , OperationMode.Normal)
            SPR_PRO(vS1, DS1, "USP_ISUD4073B_SEARCH_vS1", "Vs1")
            Call VsSizeRangeNew(vS1, "USP_VS_SIZERANGE_JOBBASE_STOCKFIT", "SizeQty01", txt_JobCard.Data)
            vS1.ActiveSheet.RowCount += 1

            'vS1.ActiveSheet.Rows(vS1.ActiveSheet.RowCount - 1).Locked = True
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

        'Try

        '    DS1 = PrcDS("USP_ISUD4073B_SEARCH_VS0", cn, L4073.cdFactory,
        '                                                      L4073.cdMainProcess,
        '                                                      L4073.cdLineProd,
        '                                                      L4073.LineTno)

        '    If GetDsRc(DS1) = 0 Then
        '        VS0.Enabled = True
        '        SPR_PRO(vS0, DS1, "USP_ISUD4073B_SEARCH_VS0", "VS0")
        '        Exit Function
        '    End If

        '    SPR_PRO(vS0, DS1, "USP_ISUD4073B_SEARCH_VS0", "VS0")

        '    DATA_SEARCH_VS0 = True
        'Catch ex As Exception
        '    MsgBoxP("DATA_SEARCH_VS1")
        'End Try
    End Function

    Private Function DATA_SEARCH_VS2() As Boolean
        'DATA_SEARCH_VS2 = False
        'Dim SizeName As String

        'SizeName = getData(vS0, getColumIndex(vS0, "SizeName"), vS0.ActiveSheet.ActiveRowIndex)

        'Try

        '    DS1 = PrcDS("USP_ISUD4073B_SEARCH_VS2", cn, L4073.cdFactory,
        '                                                      L4073.cdMainProcess,
        '                                                      L4073.cdLineProd,
        '                                                      L4073.LineTno,
        '                                                      SizeName,
        '                                                        txt_BatchGroup.Data)

        '    If GetDsRc(DS1) = 0 Then
        '        SPR_PRO(vS2, DS1, "USP_ISUD4073B_SEARCH_VS2", "VS2")

        '        Exit Function

        '    End If

        '    SPR_PRO(vS2, DS1, "USP_ISUD4073B_SEARCH_VS2", "VS2")

        '    Dim i As Integer

        '    For i = 0 To vS2.ActiveSheet.RowCount - 1
        '        If CIntp(getData(vS2, getColumIndex(vS2, "QtyProduction"), i)) > 0 Then
        '            SPR_LOCK(vS2, i)
        '            SPR_BACKCOLORCELL(vS2, Color.Red, getColumIndex(vS2, "Dchk"), i)
        '        End If
        '    Next

        '    DATA_SEARCH_VS2 = True
        'Catch ex As Exception
        '    MsgBoxP("DATA_SEARCH_VS1")
        'End Try
    End Function
    Private Function DATA_SEARCH_HEAD() As Boolean
        DATA_SEARCH_HEAD = False
        Try

            DS1 = PrcDS("USP_ISUD4073B_SEARCH_HEAD", cn, L4073.cdFactory,
                                                         L4073.cdMainProcess,
                                                         L4073.cdLineProd,
                                                         L4073.LineTno)

            If GetDsRc(DS1) = 0 Then
                If READ_PFK7171(ListCode("Factory"), L4073.cdFactory) = True Then
                    txt_cdFactory.Data = D7171.BasicName
                    txt_cdFactory.Code = D7171.BasicCode
                End If

                If READ_PFK7171(ListCode("MainProcess"), L4073.cdMainProcess) = True Then
                    txt_cdMainProcess.Data = D7171.BasicName
                    txt_cdMainProcess.Code = D7171.BasicCode
                End If

                If READ_PFK7171(ListCode("LineProd"), L4073.cdLineProd) = True Then
                    txt_cdLineProd.Data = D7171.BasicName
                    txt_cdLineProd.Code = D7171.BasicCode
                End If

                Exit Function
            End If

            STORE_MOVE(Me, DS1)

            L4073.JobCard = GetDsData(DS1, 0, "JobCard")

            Call K4073_CheckComplete(GetDsData(DS1, 0, "CheckComplete"))

            DATA_SEARCH_HEAD = True

            If READ_PFK7171(ListCode("Factory"), L4073.cdFactory) = True Then
                txt_cdFactory.Data = D7171.BasicName
                txt_cdFactory.Code = D7171.BasicCode
            End If

            If READ_PFK7171(ListCode("MainProcess"), L4073.cdMainProcess) = True Then
                txt_cdMainProcess.Data = D7171.BasicName
                txt_cdMainProcess.Code = D7171.BasicCode
            End If

            If READ_PFK7171(ListCode("LineProd"), L4073.cdLineProd) = True Then
                txt_cdLineProd.Data = D7171.BasicName
                txt_cdLineProd.Code = D7171.BasicCode
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

        L4073.cdFactory = txt_cdFactory.Code
        L4073.cdMainProcess = txt_cdMainProcess.Code
        L4073.cdLineProd = txt_cdLineProd.Code
        L4073.LineTno = txt_LineTno.Data

        Try
            If READ_PFK4073(L4073.cdFactory,
                            L4073.cdMainProcess,
                            L4073.cdLineProd,
                            L4073.LineTno) = True Then

                L4073.JobCard = D4073.JobCard
            Else
                Exit Function
            End If

            DS1 = PrcDS("USP_ISUD4073B_SEARCH_sTAB1_HEAD", cn, L4073.JobCard)

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
            DS1 = PrcDS("USP_ISUD4073B_SEARCH_vS1", cn, L4073.cdFactory, L4073.cdMainProcess, L4073.cdLineProd, L4073.LineTno)

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

            'If READ_PFK4073(L4073.cdFactory, L4073.cdMainProcess, L4073.cdLineProd, L4073.LineTno) Then

            '    If D4073.CheckComplete <> "1" Then MsgBoxP("No plan! Cannot delete!") : Exit Function

            '    L4073.cdFactory = txt_cdFactory.Code
            '    L4073.cdMainProcess = txt_cdMainProcess.Code
            '    L4073.cdLineProd = txt_cdLineProd.Code
            '    L4073.LineTno = txt_LineTno.Data

            '    W4073 = D4073

            '    Dim i As Integer
            '    Dim Scol As Integer
            '    Dim FixCol As Integer

            '    Scol = getColumIndex(vS1, "SizeQty01")
            '    FixCol = getColumIndex(vS1, "SizeQty01")

            '    For i = Scol To vS1.ActiveSheet.ColumnCount - 1
            '        If READ_PFK4074(L4073.cdFactory, L4073.cdMainProcess, L4073.cdLineProd, L4073.LineTno, (i - FixCol + 1).ToString("00")) Then
            '            W4074 = D4074
            '            Call DELETE_PFK4074(W4074)
            '        End If
            '    Next

            '    If DELETE_PFK4073(W4073) = True Then
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
        'Try
        '    If READ_PFK4073(L4073.cdFactory,
        '                  L4073.cdMainProcess,
        '                  L4073.cdLineProd,
        '                  L4073.LineTno) Then

        '        If D4073.CheckComplete <> "1" Then MsgBoxP("No plan! Cannot delete!") : Exit Function

        '        L4073.cdFactory = txt_cdFactory.Code
        '        L4073.cdMainProcess = txt_cdMainProcess.Code
        '        L4073.cdLineProd = txt_cdLineProd.Code
        '        L4073.LineTno = txt_LineTno.Data

        '        If K4073_MOVE(vS1, xrow, W4073,
        '                      L4073.cdFactory,
        '                      L4073.cdMainProcess,
        '                      L4073.cdLineProd,
        '                      L4073.LineTno) = True Then

        '            If W4073.LineTno = 1 Then MsgBoxP("You can not delete the main dyeing job no. You must delete all!") : Exit Function

        '            If DELETE_PFK4073(W4073) = True Then
        '                DATA_DELETE = True
        '            End If

        '        End If

        '    End If
        'Catch ex As Exception
        '    MsgBoxP("DATA_MOVE!")
        'End Try
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

            L4073.JobCard = txt_Barcode.Data

            If READ_PFK4010(L4073.JobCard) = False Then Exit Function

            txt_JobCard.Data = L4073.JobCard

            If READ_PFK4073(txt_cdFactory.Code, txt_cdMainProcess.Code, txt_cdLineProd.Code, txt_LineTno.Data) = True Then
                If D4073.QtyProd > 0 Then Exit Function
            End If

            Call KEY_COUNT()

            DS1 = PrcDS("USP_ISUD4073B_SEARCH_vS1_INSERT", cn, L4073.JobCard)

            If GetDsRc(DS1) = 0 Then
                MsgBoxP("No data. Check, please!")
                Exit Function
            End If

            vS1.ActiveSheet.RowCount += 1
            xrow = vS1.ActiveSheet.RowCount - 1
            vS1.SetViewportTopRow(0, vS1.ActiveSheet.RowCount - 1)
            vS1.ActiveSheet.ActiveRowIndex = xrow

            Call READ_SPREAD(vS1, DS1, "USP_ISUD4073B_SEARCH_vS1", "VS1", xrow)

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

    Private Function K4073_CheckMethodDyeing5() As String
        K4073_CheckMethodDyeing5 = ""
    End Function

    Private Sub K4073_CheckComplete(Check1 As Boolean, Check2 As Boolean, Check3 As Boolean, Check4 As Boolean, Check5 As Boolean, Check6 As Boolean)
        chk_CheckComplete1.Enabled = Check1
        chk_CheckComplete2.Enabled = Check2
        chk_CheckComplete3.Enabled = Check3
        chk_CheckComplete4.Enabled = Check4
        chk_CheckComplete5.Enabled = Check5
        chk_CheckComplete6.Enabled = Check6
    End Sub
    Private Sub K4073_CheckMethodDyeing5(Value As String)
    End Sub
    Private Sub K4073_CheckComplete(Value As String)
        chk_CheckComplete1.Checked = True
        If Value = "1" Then chk_CheckComplete1.Checked = True : Exit Sub
        If Value = "2" Then chk_CheckComplete2.Checked = True : Exit Sub
        If Value = "3" Then chk_CheckComplete3.Checked = True : Exit Sub
        If Value = "4" Then chk_CheckComplete4.Checked = True : Exit Sub
        If Value = "5" Then chk_CheckComplete5.Checked = True : Exit Sub
        If Value = "6" Then chk_CheckComplete6.Checked = True : Exit Sub
    End Sub

    Private Sub K4073_CheckComplete()
        W4073.CheckComplete = "1"
        If chk_CheckComplete1.Checked = True Then W4073.CheckComplete = "1" : Exit Sub
        If chk_CheckComplete2.Checked = True Then W4073.CheckComplete = "2" : Exit Sub
        If chk_CheckComplete3.Checked = True Then W4073.CheckComplete = "3" : Exit Sub
        If chk_CheckComplete4.Checked = True Then W4073.CheckComplete = "4" : Exit Sub
        If chk_CheckComplete5.Checked = True Then W4073.CheckComplete = "5" : Exit Sub
        If chk_CheckComplete6.Checked = True Then W4073.CheckComplete = "6" : Exit Sub
    End Sub

    Private Sub K4073_CheckProduction()
    End Sub

    Private Sub K4073_CheckProduction(Value As String)
    End Sub

    Private Function DATA_MOVE() As Boolean
        DATA_MOVE = False
        Try
            Dim xCOL As Long
            Dim xROW As Long

            xCOL = vS1.ActiveSheet.ActiveColumnIndex
            xROW = vS1.ActiveSheet.ActiveRowIndex


            If READ_PFK4073(txt_cdFactory.Code,
                            txt_cdMainProcess.Code,
                            txt_cdLineProd.Code,
                            txt_LineTno.Data) = True Then

                W4073 = D4073

                W4073.seLineProd = ListCode("LineProd")
                W4073.seFactory = ListCode("Factory")
                W4073.seMainProcess = ListCode("MainProcess")


                If REWRITE_PFK4073(W4073) = True Then
                    isudCHK = True
                    DATA_MOVE = True
                End If

            Else
                If K4073_MOVE(Me, W4073, 1, txt_cdFactory.Code,
                                            txt_cdMainProcess.Code,
                                            txt_cdLineProd.Code,
                                            txt_LineTno.Data) = False Then
                    W4073.STimeProduction = FormatCut(W4073.STimeProduction)
                    W4073.ETimeProduction = FormatCut(W4073.ETimeProduction)
                    W4073.CheckComplete = "1"

                    W4073.JobCard = L4073.JobCard

                    W4073.DatePlan = Pub.DAT
                    W4073.DateProduction = Pub.DAT

                    W4073.seFactory = ListCode("Factory")
                    W4073.seMainProcess = ListCode("MainProcess")
                    W4073.seLineProd = ListCode("LineProd")

                    If WRITE_PFK4073(W4073) = True Then
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
            If READ_PFK4073(L4073.cdFactory, L4073.cdMainProcess, L4073.cdLineProd, L4073.LineTno) = True Then
                W4073 = D4073

                Dim i As Integer
                Dim Scol As Integer
                Dim FixCol As Integer

                Scol = getColumIndex(vS1, "SizeQty01")
                FixCol = getColumIndex(vS1, "SizeQty01")

                For i = Scol To vS1.ActiveSheet.ColumnCount - 1
                    If READ_PFK4074(W4073.cdFactory, W4073.cdMainProcess, W4073.cdLineProd, W4073.LineTno, (i - FixCol + 1).ToString("00")) Then
                        W4074 = D4074

                        W4074.seFactory = W4073.seFactory
                        W4074.seLineProd = W4073.seLineProd
                        W4074.seMainProcess = W4073.seMainProcess

                        W4074.cdFactory = W4073.cdFactory
                        W4074.cdMainProcess = W4073.cdMainProcess
                        W4074.cdLineProd = W4073.cdLineProd

                        W4074.LineTno = W4073.LineTno

                        W4074.JobCard = W4073.JobCard
                        W4074.Szno = (i - FixCol + 1).ToString("00")

                        W4074.CheckComplete = "1"

                        W4074.DatePlan = W4073.DatePlan
                        W4074.DateProduction = W4073.DateProduction
                        W4074.STimeProduction = System_Date_time()

                        If getDataM(vS1, i, 1) = "1" Then W4074.QtyPlan = CIntp(getData(vS1, i, 0)) Else W4074.QtyPlan = 0

                        Call REWRITE_PFK4074(W4074)

                    Else
                        W4074 = D4074

                        W4074.seFactory = W4073.seFactory
                        W4074.seLineProd = W4073.seLineProd
                        W4074.seMainProcess = W4073.seMainProcess

                        W4074.cdFactory = W4073.cdFactory
                        W4074.cdMainProcess = W4073.cdMainProcess
                        W4074.cdLineProd = W4073.cdLineProd

                        W4074.LineTno = W4073.LineTno

                        W4074.JobCard = W4073.JobCard
                        W4074.Szno = (i - FixCol + 1).ToString("00")

                        W4074.CheckComplete = "1"

                        W4074.DatePlan = W4073.DatePlan
                        W4074.DateProduction = W4073.DateProduction
                        W4074.STimeProduction = System_Date_time()

                        If getDataM(vS1, i, 1) = "1" Then W4074.QtyPlan = CIntp(getData(vS1, i, 0)) Else W4074.QtyPlan = 0

                        Call WRITE_PFK4074(W4074)

                    End If
                Next

                isudCHK = True
                WRITE_CHK = "*"
                DATA_CHECKCOMPLETE = True
            End If
        Catch ex As Exception
            MsgBoxP("DATA_CHECKCOMPLETE!")
        End Try
    End Function

    Private Function DATA_CHECKSTATUS() As Boolean
        DATA_CHECKSTATUS = False
        Try
            If READ_PFK4073(L4073.cdFactory, L4073.cdMainProcess, L4073.cdLineProd, L4073.LineTno) = True Then
                W4073 = D4073
                Call K4073_CheckComplete()

                If REWRITE_PFK4073(W4073) = True Then
                    isudCHK = True
                    WRITE_CHK = "*"
                    DATA_CHECKSTATUS = True
                End If
            End If
        Catch ex As Exception
            MsgBoxP("DATA_CHECKSTATUS!")
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

                Dim i As Integer



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
                Call PrcExeNoError("USP_PFK4015_GENERATE_BARCODE_ALL_JOBCARD_SIZECHECK", cn, L4073.cdFactory, L4073.cdMainProcess, L4073.cdLineProd, L4073.LineTno)
                Call MsgBoxP("Update Succesfully!", vbInformation)
                 Me.Dispose()
            Case 2
                Me.Dispose()
            Case 3
                If txt_DatePlan.Data <> Pub.DAT Then
                    MsgBoxP("Can not edit because of not today!")
                    If MsgBoxPPW("Please type the password to modify!", const_pwPrintUpdate) = False Then Exit Sub
                End If

                Call DATA_CHECKCOMPLETE()
                Call PrcExeNoError("USP_PFK4015_GENERATE_BARCODE_ALL_JOBCARD_SIZECHECK", cn, L4073.cdFactory, L4073.cdMainProcess, L4073.cdLineProd, L4073.LineTno)
                Call MsgBoxP("Update Succesfully!", vbInformation)
                  Me.Dispose()
            Case 4
                Call DATA_DELETE()

            Case 11
                Call DATA_CHECKCOMPLETE()
                Call PrcExeNoError("USP_PFK4015_GENERATE_BARCODE_ALL_JOBCARD_SIZECHECK_QTYBASE", cn, L4073.cdFactory, L4073.cdMainProcess, L4073.cdLineProd, L4073.LineTno, _QtyBase)
                Call MsgBoxP("Update Succesfully!", vbInformation)
                Me.Dispose()
        End Select

    End Sub

    Private Sub cmd_DEL_Click(sender As Object, e As EventArgs)

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
        Data_Check = True
        Try

            Dim Scol As Integer
            Dim FixCol As Integer
            Dim i As Integer
            Dim j As Integer

            Scol = getColumIndex(vS1, "SizeQty01")
            FixCol = getColumIndex(vS1, "SizeQty01")

            'For i = Scol To vS1.ActiveSheet.ColumnCount - 1
            '    If getDataM(vS1, i, 1) = "1" Then
            '        Data_Check = True
            '        Exit For
            '    End If
            'Next

            If Data_Check = False Then Exit Function

            'For i = 0 To vS2.ActiveSheet.RowCount - 1
            '    If getDataM(vS2, getColumIndex(vS2, "DCHK"), i) = "1" Then
            '        If CIntp(getData(vS2, getColumIndex(vS2, "QtyBatchS"), i)) = 0 Or CIntp(getData(vS2, getColumIndex(vS2, "QtyBatchCnt"), i)) = 0 Then
            '            Data_Check = False
            '            Exit For
            '        Else
            '            Data_Check = True
            '        End If
            '    End If
            'Next
        Catch ex As Exception

        End Try
    End Function
    Private Sub KEY_COUNT_K4075_BATCHSHOES()
        Dim YRNO As Integer
        YRNO = CIntp(Mid(System_Date_8(), 3, 2))

        Try
            SQL = "SELECT MAX(CAST(SUBSTRING(K4075_BatchShoes,5,6) AS DECIMAL)) AS MAX_MCODE FROM PFK4075 "
            SQL = SQL & " WHERE SUBSTRING(K4075_BatchShoes,3,2) = '" & YRNO.ToString & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                L4075.BatchShoes = "PS" & YRNO.ToString & "000001"
            Else
                L4075.BatchShoes = "PS" & YRNO.ToString & CIntp(rd!MAX_MCODE + 1).ToString("000000")
            End If

            W4075.BatchShoes = L4075.BatchShoes
            rd.Close()
        Catch ex As Exception
            Call MsgBoxP("KEY_COUNT")
        End Try
    End Sub
    Private Sub cmd_Generate_Click(sender As Object, e As EventArgs)
        Dim Scol As Integer
        Dim FixCol As Integer
        Dim i As Integer
        Dim j As Integer

        Dim StrMsg As String = MsgBox("Do you want to make a new batch ?", vbYesNo)
        If StrMsg <> vbYes Then Exit Sub

        Scol = getColumIndex(vS1, "SizeQty01")
        FixCol = getColumIndex(vS1, "SizeQty01")

        Call KEY_COUNT_K4075_BatchGroup()

        For i = Scol To vS1.ActiveSheet.ColumnCount - 1
            If getDataM(vS1, i, 1) = "1" And CIntp(getDataM(vS1, i, 0)) >= 1 Then
                If txt_cdFactory.Code = "002" Then
                    Call PrcExeNoError("USP_PFK4075_AUTO_BATCHNO_STITCHING_SZNO_QTY", cn, L4073.cdFactory, "", "", L4073.cdLineProd, L4073.LineTno, L4073.JobCard, (i - FixCol + 1).ToString("00"), CIntp(getDataM(vS1, i, 0)), txt_InchargePlan.Code)

                Else
                    Call PrcExeNoError("USP_PFK4075_AUTO_BATCHNO_STITCHING_SZNO_QTY", cn, L4073.cdFactory, "", "", L4073.cdLineProd, L4073.LineTno, L4073.JobCard, (i - FixCol + 1).ToString("00"), CIntp(getDataM(vS1, i, 0)), txt_InchargePlan.Code)
                End If
                'If READ_PFK4074(L4073.cdFactory, L4073.cdMainProcess, L4073.cdLineProd, L4073.LineTno, (i - FixCol + 1).ToString("00")) Then
                '    'Write Left Shoes

                '    W4075.BatchGroup = L4075.BatchGroup

                '    Call KEY_COUNT_K4075_Sno(D4074.Szno)
                '    Call KEY_COUNT_K4075_BATCHNO()
                '    Call KEY_COUNT_K4075_BATCHSHOES()

                '    W4075.DateBatch = Pub.DAT
                '    W4075.SizeName = getDataCH(vS1, i, 0)

                '    W4075.TypeBatch = "1"
                '    W4075.CheckL = "1"
                '    W4075.CheckR = "2"

                '    W4075.JobCard = D4074.JobCard

                '    W4075.Szno = D4074.Szno
                '    W4075.cdFactory = D4074.cdFactory
                '    W4075.cdMainProcess = D4074.cdMainProcess
                '    W4075.cdLineProd = D4074.cdLineProd
                '    W4075.LineTno = D4074.LineTno

                '    W4075.DateInsert = Pub.DAT
                '    W4075.InchargeInsert = Pub.SAW
                '    W4075.QtyBatch = 1

                '    Call WRITE_PFK4075(W4075)

                '    'Write Right Shoes
                '    Call KEY_COUNT_K4075_Sno(D4074.Szno)
                '    Call KEY_COUNT_K4075_BATCHNO()

                '    W4075.BatchGroup = L4075.BatchGroup

                '    W4075.DateBatch = Pub.DAT
                '    W4075.SizeName = getDataCH(vS1, i, 0)

                '    W4075.TypeBatch = "1"
                '    W4075.CheckL = "2"
                '    W4075.CheckR = "1"

                '    W4075.JobCard = D4074.JobCard

                '    W4075.Szno = D4074.Szno
                '    W4075.cdFactory = D4074.cdFactory
                '    W4075.cdMainProcess = D4074.cdMainProcess
                '    W4075.cdLineProd = D4074.cdLineProd
                '    W4075.LineTno = D4074.LineTno

                '    W4075.DateInsert = Pub.DAT
                '    W4075.InchargeInsert = Pub.SAW
                '    W4075.QtyBatch = 1

                '    Call WRITE_PFK4075(W4075)

                'End If

            End If
        Next


        Call DATA_SEARCH_VS0()
    End Sub

    Private Sub vS2_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Delete Then
            Dim JobCard As String
            Dim JobCardseq As String

            Dim cdMainProcess As String
            Dim Szno As String
            Dim Sno As String
            Dim BatchNo As String


            Call Select_Message("3", WordConv("PROCESSING"), 2)

            If Msg_Result <> vbYes Then Exit Sub

            Dim i As Integer

            '            For i = 0 To vS2.ActiveSheet.RowCount - 1
            '                JobCard = getData(vS2, getColumIndex(vS2, "Key_JobCard"), i)
            '                cdMainProcess = getData(vS2, getColumIndex(vS2, "Key_cdMainProcess"), i)
            '                Szno = getData(vS2, getColumIndex(vS2, "Key_Szno"), i)
            '                Sno = getData(vS2, getColumIndex(vS2, "Key_Sno"), i)
            '                BatchNo = getData(vS2, getColumIndex(vS2, "BatchNo"), i)

            '                If getData(vS2, getColumIndex(vS2, "dchk"), i) = "1" Then
            '                    If READ_PFK4075_BatchNo(BatchNo) = True Then
            '                        W4075 = D4075

            '                        If W4075.QtyProduction > 0 Then GoTo next1

            '                        If DELETE_PFK4075_CANCEL(W4075) = True Then
            '                            SPR_CLEAR(vS2, i, 0, i, vS2.ActiveSheet.ColumnCount - 1)
            '                            setData(vS2, getColumIndex(vS2, "JobCard"), i, "[CANCEL]")
            '                            setData(vS2, getColumIndex(vS2, "BatchNo"), i, "[CANCEL]")
            '                        End If
            '                    End If
            '                End If
            'next1:
            '            Next



        ElseIf e.Control = True And e.KeyCode = Keys.C Then
            'If READ_PFK4075_BatchShoes(getData(vS2, getColumIndex(vS2, "BatchShoes"), vS2.ActiveSheet.ActiveRowIndex), "1", "2") = True And READ_PFK4075_BatchShoes(getData(vS2, getColumIndex(vS2, "BatchShoes"), vS2.ActiveSheet.ActiveRowIndex), "2", "1") = True Then MsgBoxP("2 SHOES ALREADY!") : Exit Sub
            'If MsgBoxPPW("Please type the password to modify!", const_pwPO) = False Then Exit Sub

            'If READ_PFK4075_BatchNo(getData(vS2, getColumIndex(vS2, "BatchNo"), vS2.ActiveSheet.ActiveRowIndex)) Then
            '    'Write Left Shoes
            '    W4075 = D4075

            '    If W4075.CheckL = "1" Then
            '        W4075.CheckL = "2"
            '        W4075.CheckR = "1"
            '    Else
            '        W4075.CheckL = "1"
            '        W4075.CheckR = "2"
            '    End If

            '    Call KEY_COUNT_K4075_BATCHNO()

            '    W4075.TypeBatch = "1"
            '    W4075.DateInsert = Pub.DAT
            '    W4075.InchargeInsert = Pub.SAW

            '    W4075.QtyProduction = 0
            '    W4075.QtyProductionA = 0
            '    W4075.QtyProductionX = 0
            '    W4075.QtyProductionXP = 0
            '    W4075.QtyProductionXR = 0
            '    W4075.QtyBLIn = 0
            '    W4075.QtyBLOut = 0

            '    Call KEY_COUNT_K4075_Sno(W4075.Szno)

            '    Call WRITE_PFK4075(W4075)

            'End If
        End If

    End Sub

    Private Sub vS0_CellClick(sender As Object, e As CellClickEventArgs)
        'txt_BatchGroup.Data = getData(vS0, getColumIndex(vS0, "Key_BatchGroup"), vS0.ActiveSheet.ActiveRowIndex)

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
        Call TAG_PRINT_STITCHING_PANEL_NEW_PROD()
        'Call TAG_PRINT_STITCHING_PANEL_NEW_PROD_TEST()
    End Sub

    Public Sub DATA_MOVE_BARCODE_01(BatchNo1 As String, BatchNo2 As String)
        If READ_PFK4075_BatchNo(BatchNo1) Then
            STITCHINGPANEL1.cdFactory = D4075.cdFactory
            STITCHINGPANEL1.cdProdLine = D4075.cdLineProd

            STITCHINGPANEL1.QtyBatch = D4075.QtyBatch
            STITCHINGPANEL1.SizeName = D4075.SizeName

            STITCHINGPANEL1.JobCard = txt_SLNoD.Data
            STITCHINGPANEL1.BarcodeSeq = D4075.BatchNo

            STITCHINGPANEL1.Article = txt_Article.Data
            STITCHINGPANEL1.Line = txt_Line.Data

            If STITCHINGPANEL1.Line.Length > 10 Then STITCHINGPANEL1.Line = STITCHINGPANEL1.Line.Substring(1, 10)

            STITCHINGPANEL1.Color = txt_ColorName.Data

            STITCHINGPANEL1.DatePrint = Pub.DAT
            STITCHINGPANEL1.SealNo = txt_SLNoD.Data
            STITCHINGPANEL1.Barcode = D4075.BatchNo

            If (CIntp(D4075.Sno) Mod 2) = 0 Then STITCHINGPANEL1.Sno = CIntp(D4075.Sno) / 2
            If (CIntp(D4075.Sno) Mod 2) = 1 Then STITCHINGPANEL1.Sno = (CIntp(D4075.Sno) + 1) / 2


        End If

        If READ_PFK4075_BatchNo(BatchNo2) Then
            STITCHINGPANEL2.cdFactory = D4075.cdFactory
            STITCHINGPANEL2.cdProdLine = D4075.cdLineProd


            STITCHINGPANEL2.SizeName = D4075.SizeName
            STITCHINGPANEL2.QtyBatch = D4075.QtyBatch

            STITCHINGPANEL2.JobCard = txt_SLNoD.Data
            STITCHINGPANEL2.BarcodeSeq = D4075.BatchNo

            STITCHINGPANEL2.Article = txt_Article.Data
            STITCHINGPANEL2.Line = txt_Line.Data

            If STITCHINGPANEL2.Line.Length > 10 Then STITCHINGPANEL2.Line = STITCHINGPANEL2.Line.Substring(1, 10)

            STITCHINGPANEL2.Color = txt_ColorName.Data

            STITCHINGPANEL2.DatePrint = Pub.DAT
            STITCHINGPANEL2.SealNo = txt_SLNoD.Data
            STITCHINGPANEL2.Barcode = D4075.BatchNo


            If (CIntp(D4075.Sno) Mod 2) = 0 Then STITCHINGPANEL2.Sno = CIntp(D4075.Sno) / 2
            If (CIntp(D4075.Sno) Mod 2) = 1 Then STITCHINGPANEL2.Sno = (CIntp(D4075.Sno) + 1) / 2

        End If

    End Sub

    Public Sub DATA_MOVE_BARCODE_02(BatchNo3 As String, BatchNo4 As String)
        If READ_PFK4075_BatchNo(BatchNo3) Then
            STITCHINGPANEL3.cdFactory = D4075.cdFactory
            STITCHINGPANEL3.cdProdLine = D4075.cdLineProd


            STITCHINGPANEL3.SizeName = D4075.SizeName
            STITCHINGPANEL3.QtyBatch = D4075.QtyBatch

            STITCHINGPANEL3.JobCard = txt_SLNoD.Data
            STITCHINGPANEL3.BarcodeSeq = D4075.BatchNo

            STITCHINGPANEL3.Article = txt_Article.Data
            STITCHINGPANEL3.Line = txt_Line.Data

            If STITCHINGPANEL3.Line.Length > 10 Then STITCHINGPANEL3.Line = STITCHINGPANEL3.Line.Substring(1, 10)

            STITCHINGPANEL3.Color = txt_ColorName.Data

            STITCHINGPANEL3.DatePrint = Pub.DAT
            STITCHINGPANEL3.SealNo = txt_SLNoD.Data
            STITCHINGPANEL3.Barcode = D4075.BatchNo

            'STITCHINGPANEL3.Sno = CIntp(CDecp(D4075.Sno) / 2)

            If (CIntp(D4075.Sno) Mod 2) = 0 Then STITCHINGPANEL3.Sno = CIntp(D4075.Sno) / 2
            If (CIntp(D4075.Sno) Mod 2) = 1 Then STITCHINGPANEL3.Sno = (CIntp(D4075.Sno) + 1) / 2
        End If

        If READ_PFK4075_BatchNo(BatchNo4) Then
            STITCHINGPANEL4.cdFactory = D4075.cdFactory
            STITCHINGPANEL4.cdProdLine = D4075.cdLineProd


            STITCHINGPANEL4.SizeName = D4075.SizeName
            STITCHINGPANEL4.QtyBatch = D4075.QtyBatch

            STITCHINGPANEL4.JobCard = txt_SLNoD.Data
            STITCHINGPANEL4.BarcodeSeq = D4075.BatchNo

            STITCHINGPANEL4.Article = txt_Article.Data
            STITCHINGPANEL4.Line = txt_Line.Data

            If STITCHINGPANEL4.Line.Length > 10 Then STITCHINGPANEL4.Line = STITCHINGPANEL4.Line.Substring(1, 10)

            STITCHINGPANEL4.Color = txt_ColorName.Data

            STITCHINGPANEL4.DatePrint = Pub.DAT
            STITCHINGPANEL4.SealNo = txt_SLNoD.Data
            STITCHINGPANEL4.Barcode = D4075.BatchNo

            'STITCHINGPANEL4.Sno = CIntp(CDecp(D4075.Sno) / 2)
            If (CIntp(D4075.Sno) Mod 2) = 0 Then STITCHINGPANEL4.Sno = CIntp(D4075.Sno) / 2
            If (CIntp(D4075.Sno) Mod 2) = 1 Then STITCHINGPANEL4.Sno = (CIntp(D4075.Sno) + 1) / 2
        End If
    End Sub
    Public Sub DATA_MOVE_BARCODE_12(BatchShoes As String)
        If READ_PFK4075_BatchShoes(BatchShoes, "1", "2") Then
            STITCHINGPANEL1.QtyBatch = D4075.QtyBatch
            STITCHINGPANEL1.SizeName = D4075.SizeName

            STITCHINGPANEL1.JobCard = txt_SLNoD.Data
            STITCHINGPANEL1.BarcodeSeq = D4075.BatchNo

            STITCHINGPANEL1.Article = txt_Article.Data
            STITCHINGPANEL1.Line = txt_Line.Data

            If STITCHINGPANEL1.Line.Length > 10 Then STITCHINGPANEL1.Line = STITCHINGPANEL1.Line.Substring(1, 10)

            STITCHINGPANEL1.Color = txt_ColorName.Data

            STITCHINGPANEL1.DatePrint = Pub.DAT
            STITCHINGPANEL1.SealNo = txt_SLNoD.Data
            STITCHINGPANEL1.Barcode = D4075.BatchNo

            If (CIntp(D4075.Sno) Mod 2) = 0 Then STITCHINGPANEL1.Sno = CIntp(D4075.Sno) / 2
            If (CIntp(D4075.Sno) Mod 2) = 1 Then STITCHINGPANEL1.Sno = (CIntp(D4075.Sno) + 1) / 2

        End If

        If READ_PFK4075_BatchShoes(BatchShoes, "2", "1") Then
            STITCHINGPANEL2.SizeName = D4075.SizeName
            STITCHINGPANEL2.QtyBatch = D4075.QtyBatch

            STITCHINGPANEL2.JobCard = txt_SLNoD.Data
            STITCHINGPANEL2.BarcodeSeq = D4075.BatchNo

            STITCHINGPANEL2.Article = txt_Article.Data
            STITCHINGPANEL2.Line = txt_Line.Data

            If STITCHINGPANEL2.Line.Length > 10 Then STITCHINGPANEL2.Line = STITCHINGPANEL2.Line.Substring(1, 10)

            STITCHINGPANEL2.Color = txt_ColorName.Data

            STITCHINGPANEL2.DatePrint = Pub.DAT
            STITCHINGPANEL2.SealNo = txt_SLNoD.Data
            STITCHINGPANEL2.Barcode = D4075.BatchNo


            If (CIntp(D4075.Sno) Mod 2) = 0 Then STITCHINGPANEL2.Sno = CIntp(D4075.Sno) / 2
            If (CIntp(D4075.Sno) Mod 2) = 1 Then STITCHINGPANEL2.Sno = (CIntp(D4075.Sno) + 1) / 2

        End If

    End Sub

    Public Sub DATA_MOVE_BARCODE_34(BatchShoes As String)
        If READ_PFK4075_BatchShoes(BatchShoes, "1", "2") Then
            STITCHINGPANEL3.SizeName = D4075.SizeName
            STITCHINGPANEL3.QtyBatch = D4075.QtyBatch

            STITCHINGPANEL3.JobCard = txt_SLNoD.Data
            STITCHINGPANEL3.BarcodeSeq = D4075.BatchNo

            STITCHINGPANEL3.Article = txt_Article.Data
            STITCHINGPANEL3.Line = txt_Line.Data

            If STITCHINGPANEL3.Line.Length > 10 Then STITCHINGPANEL3.Line = STITCHINGPANEL3.Line.Substring(1, 10)

            STITCHINGPANEL3.Color = txt_ColorName.Data

            STITCHINGPANEL3.DatePrint = Pub.DAT
            STITCHINGPANEL3.SealNo = txt_SLNoD.Data
            STITCHINGPANEL3.Barcode = D4075.BatchNo

            'STITCHINGPANEL3.Sno = CIntp(CDecp(D4075.Sno) / 2)

            If (CIntp(D4075.Sno) Mod 2) = 0 Then STITCHINGPANEL3.Sno = CIntp(D4075.Sno) / 2
            If (CIntp(D4075.Sno) Mod 2) = 1 Then STITCHINGPANEL3.Sno = (CIntp(D4075.Sno) + 1) / 2
        End If

        If READ_PFK4075_BatchShoes(BatchShoes, "2", "1") Then
            STITCHINGPANEL4.SizeName = D4075.SizeName
            STITCHINGPANEL4.QtyBatch = D4075.QtyBatch

            STITCHINGPANEL4.JobCard = txt_SLNoD.Data
            STITCHINGPANEL4.BarcodeSeq = D4075.BatchNo

            STITCHINGPANEL4.Article = txt_Article.Data
            STITCHINGPANEL4.Line = txt_Line.Data

            If STITCHINGPANEL4.Line.Length > 10 Then STITCHINGPANEL4.Line = STITCHINGPANEL4.Line.Substring(1, 10)

            STITCHINGPANEL4.Color = txt_ColorName.Data

            STITCHINGPANEL4.DatePrint = Pub.DAT
            STITCHINGPANEL4.SealNo = txt_SLNoD.Data
            STITCHINGPANEL4.Barcode = D4075.BatchNo

            'STITCHINGPANEL4.Sno = CIntp(CDecp(D4075.Sno) / 2)
            If (CIntp(D4075.Sno) Mod 2) = 0 Then STITCHINGPANEL4.Sno = CIntp(D4075.Sno) / 2
            If (CIntp(D4075.Sno) Mod 2) = 1 Then STITCHINGPANEL4.Sno = (CIntp(D4075.Sno) + 1) / 2
        End If
    End Sub

    
    Public Sub DATA_MOVE_BARCODE_2(JobCard As String, Szno As String, cdMainProcess As String, Sno As String)
        If READ_PFK4075(JobCard, Szno, cdMainProcess, Sno) Then
            OSPANEL2.DatePrint = Pub.DAT
            OSPANEL2.ColorName = txt_ColorName.Data

            OSPANEL2.SizeName = D4075.SizeName

            OSPANEL2.SlNo = txt_SLNoD.Data
            OSPANEL2.MoldName = txt_MCODEName.Data

            OSPANEL2.QtySize = D4075.QtyBatch
            OSPANEL2.Barcode = D4075.BatchNo

        End If
    End Sub

    Public Sub DATA_MOVE_BARCODE_1(JobCard As String, Szno As String, cdMainProcess As String, Sno As String)
        If READ_PFK4075(JobCard, Szno, cdMainProcess, Sno) Then
            OSPANEL1.DatePrint = Pub.DAT
            OSPANEL1.ColorName = txt_ColorName.Data

            OSPANEL1.SizeName = D4075.SizeName

            OSPANEL1.SlNo = txt_SLNoD.Data
            OSPANEL1.MoldName = txt_MCODEName.Data

            OSPANEL1.QtySize = D4075.QtyBatch
            OSPANEL1.Barcode = D4075.BatchNo
        End If

    End Sub

    'Private Sub cmd_CuttingBL_Click(sender As Object, e As EventArgs) Handles cmd_CuttingBL.Click
    '    Call HLP4073A.Link_HLP4073A(txt_JobCard.Data, txt_cdMainProcess.Code)

    'End Sub

    'Private Sub cmd_OrderBL_Click(sender As Object, e As EventArgs) Handles cmd_OrderBL.Click
    '    Call HLP4073B.Link_HLP4073B(txt_JobCard.Data, txt_cdMainProcess.Code)
    'End Sub
End Class