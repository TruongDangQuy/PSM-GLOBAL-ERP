Public Class PFP40010

#Region "Variable"
    Private Dsu01 As Long
    Private wGCODE As String
    Protected prg As E_PRG

    Private W4011 As T4011_AREA
    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.chk_FormEnterkey = False

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

        Call Cms_additem(Cms_3, _
                        "-", _
                        "-",
                        "JOBCARD PROCESSING - " & WordConv("UPDATE") & "(F6)", _
                        "JOBCARD PROCESSING - " & WordConv("DELETE ") & "(F7)",
                        "-",
                        "JOBCARD PROCESSING - " & WordConv("ADD NEW ") & "(F8)",
                        "JOBCARD PROCESSING - " & WordConv("TRANSFER JOB CARD") & "(F9)",
                        "-",
                        "JOBCARD PROCESSING - " & WordConv("ADD BO SUNG") & "(F11)")




        vS21.ContextMenuStrip = Cms_3

        Me.KeyPreview = True

        Call FORM_INIT()
        Call DATA_INIT()

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

        ptc_1.TabPages.RemoveAt(0)

    End Sub

    Private Sub DATA_INIT()
        ssp_WHERE.txt_SdateEdate.text1 = System_Date_6() & "01"
        ssp_WHERE.txt_SdateEdate.text2 = System_Date_8()

        Call Gadget_Load(ssp_WHERE, Me.Name)

        ssp_WHERE.Location = New Point(38, 110)
    End Sub
#End Region

#Region "Function"
    Private Sub MAIN_JOB01()
        Try
            Select Case True

                Case Vs10.Focused
                    Dim OrderNo As String
                    Dim OrderNoSeq As String
                    Dim ShoesCode As String


                    OrderNo = getData(Vs10, getColumIndex(Vs10, "KEY_OrderNo"), Vs10.ActiveSheet.ActiveRowIndex)
                    OrderNoSeq = getData(Vs10, getColumIndex(Vs10, "KEY_OrderNoSeq"), Vs10.ActiveSheet.ActiveRowIndex)
                    Dim i As Integer

                    If ISUD4001A.Link_ISUD4001A_AUTO(11, OrderNo, OrderNoSeq, ValueGet, Me.Name) = False Then Exit Sub
                    Call DATA_SEARCH_VS10()
                Case vS20.Focused

                    If ISUD4001A.Link_ISUD4001A(1, "", "", Me.Name) = False Then Exit Sub

                Case vS30.Focused

                    If ISUD4015A.Link_ISUD4015A(1, getData(vS30, getColumIndex(vS30, "KEY_JobCard"), vS30.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub

            End Select
        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB01!", vbCritical)
        End Try

    End Sub

    Private Function ValueGet() As String
        ValueGet = ""

        Dim i As Integer
        Dim CheckValue As Boolean = False

        For i = 0 To Vs10.ActiveSheet.RowCount - 1
            If getDataM(Vs10, getColumIndex(Vs10, "CheckUse"), i) = "1" And getData(Vs10, getColumIndex(Vs10, "KEY_OrderNo"), i) <> "" Then
                CheckValue = True
                ValueGet &= "''" & getData(Vs10, getColumIndex(Vs10, "KEY_OrderNo"), i)
                ValueGet &= getData(Vs10, getColumIndex(Vs10, "KEY_OrderNoSeq"), i) & "''|"
            End If
        Next
        ValueGet = Strings.Left(ValueGet, Len(ValueGet) - 1)

        ValueGet = ValueGet.Replace("|", ",")

    End Function
    Private Sub MAIN_JOB02()
        Try
            Select Case True

                Case Vs10.Focused
                    Dim OrderNo As String

                    If getData(Vs10, getColumIndex(Vs10, "KEY_OrderNo"), Vs10.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

                    OrderNo = getData(Vs10, getColumIndex(Vs10, "KEY_OrderNo"), Vs10.ActiveSheet.ActiveRowIndex)

                    If ISUD1311A.Link_ISUD1311A(2, OrderNo, Me.Name) = False Then Exit Sub

                Case vS20.Focused

                    Dim SpecNo As String
                    Dim SpecNoSeq As String

                    SpecNo = getData(vS20, getColumIndex(vS20, "KEY_WorkOrder"), vS20.ActiveSheet.ActiveRowIndex)
                    SpecNoSeq = getData(vS20, getColumIndex(vS20, "KEY_WorkOrderSeq"), vS20.ActiveSheet.ActiveRowIndex)

                    If ISUD4001A.Link_ISUD4001A(2, SpecNo, SpecNoSeq, Me.Name) = False Then Exit Sub

            End Select
        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB02!", vbCritical)
        End Try

    End Sub

    Private Sub MAIN_JOB03()
        Try
            Select Case True
                Case Vs10.Focused
                    Dim ShoesCode As String
                    ShoesCode = getData(Vs10, getColumIndex(Vs10, "KEY_ShoesCode"), Vs10.ActiveSheet.ActiveRowIndex)
                    If ShoesCode = "" Then Exit Sub

                    If ISUD7106A.Link_ISUD7106A(6, ShoesCode, Me.Name) = False Then Exit Sub

                Case vS20.Focused
                    Dim SpecNo As String
                    Dim SpecNoSeq As String

                    SpecNo = getData(vS20, getColumIndex(vS20, "KEY_WorkOrder"), vS20.ActiveSheet.ActiveRowIndex)
                    SpecNoSeq = getData(vS20, getColumIndex(vS20, "KEY_WorkOrderSeq"), vS20.ActiveSheet.ActiveRowIndex)

                    If ISUD4001A.Link_ISUD4001A(3, SpecNo, SpecNoSeq, Me.Name) = False Then Exit Sub
                    Call DATA_SEARCH_VS20()

            End Select
        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB03!", vbCritical)
        End Try
    End Sub

    Private Sub MAIN_JOB04()
        Try
            Select Case True
                Case Vs10.Focused
                    Dim OrderNo As String
                    Dim OrderNoSeq As String

                    OrderNo = getData(Vs10, getColumIndex(Vs10, "KEY_OrderNo"), Vs10.ActiveSheet.ActiveRowIndex)
                    OrderNoSeq = getData(Vs10, getColumIndex(Vs10, "KEY_OrderNoSeq"), Vs10.ActiveSheet.ActiveRowIndex)


                Case vS20.Focused
                    Dim SpecNo As String
                    Dim SpecNoSeq As String

                    SpecNo = getData(vS20, getColumIndex(vS20, "KEY_WorkOrder"), vS20.ActiveSheet.ActiveRowIndex)
                    SpecNoSeq = getData(vS20, getColumIndex(vS20, "KEY_WorkOrderSeq"), vS20.ActiveSheet.ActiveRowIndex)

                    If ISUD4001A.Link_ISUD4001A(4, SpecNo, SpecNoSeq, Me.Name) = False Then Exit Sub
                    Call DATA_SEARCH_VS20()

            End Select

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB04!", vbCritical)
        End Try
    End Sub

    Private Sub MAIN_JOB05()
        Try
            Select Case True
                Case Vs10.Focused

                Case vS20.Focused
                    Dim SpecNo As String
                    Dim SpecNoSeq As String

                    SpecNo = getData(vS20, getColumIndex(vS20, "KEY_WorkOrder"), vS20.ActiveSheet.ActiveRowIndex)
                    SpecNoSeq = getData(vS20, getColumIndex(vS20, "KEY_WorkOrderSeq"), vS20.ActiveSheet.ActiveRowIndex)

                    If ISUD4001P.Link_ISUD4001P(3, SpecNo, SpecNoSeq, Me.Name) = False Then Exit Sub
                    Call DATA_SEARCH_VS20()

            End Select

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB05!", vbCritical)
        End Try

    End Sub

    Private Sub MAIN_JOB06()
        Try
            Select Case True
                Case Vs10.Focused

                Case vS20.Focused
                    Dim SpecNo As String
                    Dim SpecNoSeq As String

                    SpecNo = getData(vS20, getColumIndex(vS20, "KEY_WorkOrder"), vS20.ActiveSheet.ActiveRowIndex)
                    SpecNoSeq = getData(vS20, getColumIndex(vS20, "KEY_WorkOrderSeq"), vS20.ActiveSheet.ActiveRowIndex)

                    If ISUD4001P.Link_ISUD4001P(4, SpecNo, SpecNoSeq, Me.Name) = False Then Exit Sub
                    Call DATA_SEARCH_VS20()

            End Select

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB05!", vbCritical)
        End Try

    End Sub


    Private Sub MAIN_JOB03_1()
        Try
            Dim WorkOrder As String
            Dim WorkOrderSeq As String

            WorkOrder = getData(vS20, getColumIndex(vS20, "KEY_WorkOrder"), vS20.ActiveSheet.ActiveRowIndex)
            WorkOrderSeq = getData(vS20, getColumIndex(vS20, "KEY_WorkOrderSeq"), vS20.ActiveSheet.ActiveRowIndex)

            Call PrcExe("USP_PFK4010_AUTO_GENERATE", cn, WorkOrder, WorkOrderSeq)

            Call DATA_SEARCH_VS21()

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB05!", vbCritical)
        End Try

    End Sub

    Private Sub MAIN_JOB03_2()
        Try
            Dim JobCard As String

            JobCard = getData(vS21, getColumIndex(vS21, "KEY_JobCard"), vS21.ActiveSheet.ActiveRowIndex)

            If ISUD4010A.Link_ISUD4010A(3, JobCard, Me.Name) = False Then Exit Sub

            Call DATA_SEARCH_VS21()

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB05!", vbCritical)
        End Try

    End Sub


    Private Sub MAIN_JOB03_3()
        Try
            Dim JobCard As String

            JobCard = getData(vS21, getColumIndex(vS21, "KEY_JobCard"), vS21.ActiveSheet.ActiveRowIndex)

            Dim Strmsg As String

            Strmsg = MsgBox("Do you want to delete?", vbYesNo)

            If StrMsg <> vbYes Then Exit Sub


            If MsgBoxPPW("Please type the password to delete!", const_pwDeletEJC) = False Then Exit Sub

            If READ_PFK4010(JobCard) Then
                If D4010.QtyCutting > 0 Or D4010.QtyStitching > 0 Or D4010.QtyStockfit > 0 Then Exit Sub

                Call PrcExe("USP_PFK4010_DELETE_ALL_JOBCARD_NEW", cn, JobCard)
                Call DATA_SEARCH_VS21()

            End If



        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB05!", vbCritical)
        End Try

    End Sub


    Private Sub MAIN_JOB03_4()
        Try
            Dim Strmsg As String
            Dim cdJobState As String

            Strmsg = MsgBox("Do you want to add NEW-ORDER (-)?", vbYesNo)
            If StrMsg <> vbYes Then Exit Sub

            Dim WorkOrder As String
            Dim WorkOrderSeq As String

            WorkOrder = getData(vS20, getColumIndex(vS20, "KEY_WorkOrder"), vS20.ActiveSheet.ActiveRowIndex)
            WorkOrderSeq = getData(vS20, getColumIndex(vS20, "KEY_WorkOrderSeq"), vS20.ActiveSheet.ActiveRowIndex)

            Call PrcExe("USP_PFK4010_AUTO_GENERATE_ADD_NORMAL", cn, WorkOrder, WorkOrderSeq, Pub.SAW)

            Call DATA_SEARCH_VS21()

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB05!", vbCritical)
        End Try

    End Sub

    Private Sub MAIN_JOB03_5()
        Try
            Dim Strmsg As String
            Dim JobCardBefore As String
            Dim JobCardAfter As String

            Strmsg = MsgBox("Do you want to TRANSFER to new JOBCARD ? Danger ! Can not rollback or update if the process is done ! ", vbYesNo)
            If StrMsg <> vbYes Then Exit Sub
            JobCardBefore = getData(vS21, getColumIndex(vS21, "JobCard"), vS21.ActiveSheet.ActiveRowIndex)

            If ISUD4010M.Link_ISUD4010M(3, JobCardBefore, Me.Name) Then
               
            End If

            'JobCardAfter = InputBox("Input new JOBCARD,pls ?")

            'Strmsg = PrcExeNoError_Value("ISUD_PFK4010_CHECK_TRANSFER_JOBCARD", cn, JobCardBefore, JobCardAfter)

            'If Strmsg <> "" Then
            '    MsgBoxP(Strmsg)
            '    Exit Sub

            'End If

            'Strmsg = PrcExeNoError_Value("ISUD_PFK4010_CHECK_TRANSFER_PROCESS", cn, JobCardBefore, JobCardAfter)

            'If Strmsg <> "" Then
            '    MsgBoxP(Strmsg)
            '    Exit Sub

            'End If

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB05!", vbCritical)
        End Try
    End Sub

    Private Sub MAIN_JOB03_6()
        Try
            'Dim Strmsg As String

            'Strmsg = MsgBox("Do you want to add LOSS-ORDER (B)?", vbYesNo)
            'If StrMsg <> vbYes Then Exit Sub

            'Dim WorkOrder As String
            'Dim WorkOrderSeq As String

            'WorkOrder = getData(vS20, getColumIndex(vS20, "KEY_WorkOrder"), vS20.ActiveSheet.ActiveRowIndex)
            'WorkOrderSeq = getData(vS20, getColumIndex(vS20, "KEY_WorkOrderSeq"), vS20.ActiveSheet.ActiveRowIndex)

            'Call PrcExe("USP_PFK4010_AUTO_GENERATE_ADD_LOSS", cn, WorkOrder, WorkOrderSeq)

            'Call DATA_SEARCH_VS21()

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB03_6!", vbCritical)
        End Try

    End Sub

    Private Sub MAIN_JOB03_8()
        Try
            Dim Strmsg As String
            Dim cdJobState As String

            Strmsg = MsgBox("Do you want to add BOSUNG-ORDER (BOSUNG)?", vbYesNo)
            If StrMsg <> vbYes Then Exit Sub

            Dim JobCardB As String
            Dim WorkOrder As String
            Dim WorkOrderSeq As String

            JobCardB = getData(vS21, getColumIndex(vS21, "JobCard"), vS21.ActiveSheet.ActiveRowIndex)
            WorkOrder = getData(vS20, getColumIndex(vS20, "KEY_WorkOrder"), vS20.ActiveSheet.ActiveRowIndex)
            WorkOrderSeq = getData(vS20, getColumIndex(vS20, "KEY_WorkOrderSeq"), vS20.ActiveSheet.ActiveRowIndex)

            'If READ_PFK4010(JobCardB) Then
            '    If ISUD4010C.Link_ISUD4010C("1", cdJobState) = True Then
            '        If READ_PFK7171(ListCode("JobState"), cdJobState) Then
            '            Strmsg = MsgBox("Do you want to add (BOSUNG) " & D7171.BasicName & " ?", vbYesNo)
            '            If StrMsg <> vbYes Then Exit Sub

            '            Call PrcExe("USP_PFK4010_AUTO_GENERATE_ADD_BOSUNG", cn, cdJobState, Pub.SAW, JobCardB)

            '            Call DATA_SEARCH_VS21()
            '        End If
            '    End If

            'End If


        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB03_6!", vbCritical)
        End Try

    End Sub

    Private Sub MAIN_JOB10()
        Try

            Call PrcExe("USP_PFK4010_UPDATE_SIZEQTY", cn, getData(vS21, getColumIndex(vS21, "JobCard"), i))
        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB04!", vbCritical)
        End Try
    End Sub


    Private Sub MAIN_JOB11()

    End Sub


    Private Sub MAIN_JOB12()
        Try
            Select Case True
                Case Vs10.Focused

                Case vS20.Focused
                    Dim WorkOrder As String
                    Dim WorkOrderSeq As String

                    WorkOrder = getData(vS20, getColumIndex(vS20, "KEY_WorkOrder"), vS20.ActiveSheet.ActiveRowIndex)
                    WorkOrderSeq = getData(vS20, getColumIndex(vS20, "KEY_WorkOrderSeq"), vS20.ActiveSheet.ActiveRowIndex)

                    If ISUD4001A.Link_ISUD4001A(12, WorkOrder, WorkOrderSeq, Me.Name) = False Then Exit Sub
                    Call DATA_SEARCH_VS20()

            End Select

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB04!", vbCritical)
        End Try
    End Sub

    Private Function KEY_COUNT() As String
        Dim YRNO As Integer
        YRNO = Mid(System_Date_8(), 3, 4)

        KEY_COUNT = ""

        SQL = "SELECT MAX(CAST(right(K4001_WorkOrder,3) AS DECIMAL)) AS MAX_MCODE FROM PFK4001 "
        SQL = SQL & " WHERE SUBSTRING(K4001_WorkOrder,3,4) = '" & YRNO.ToString & "' "
        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_MCODE) Then
            KEY_COUNT = "WP" & YRNO & "001"
        Else
            KEY_COUNT = "WP" & YRNO & Format(CInt(rd!MAX_MCODE + 1), "000")
        End If


        rd.Close()

    End Function

    Private Function KEY_COUNT_NO(WorkOrder As String) As String
        KEY_COUNT_NO = ""

        Dim YRNO As Integer
        YRNO = Mid(System_Date_8(), 3, 2)


        SQL = "SELECT MAX(CAST(K0102_WorkOrderSeq AS DECIMAL)) AS MAX_MCODE FROM PFK0102 "
        SQL = SQL & " WHERE K0102_WorkOrder = '" & WorkOrder & "' "
        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_MCODE) Then
            KEY_COUNT_NO = "001"
        Else
            KEY_COUNT_NO = FormatP(CIntp(rd!MAX_MCODE + 1), "000")
        End If

        rd.Close()

    End Function
#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS10(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS10 = False

        Vs10.Enabled = False
        Try
            DS1 = PrcDS("USP_PFP40010_SEARCH_VS10", cn, ssp_WHERE.gData_SDate,
                                                       ssp_WHERE.gData_EDate,
                                                       ssp_WHERE.gData_chkGCodeCheck,
                                                       ssp_WHERE.gData_chkGCodeSQL,
                                                       ssp_WHERE.gData_CustomerName,
                                                       ssp_WHERE.gData_Season,
                                                       ssp_WHERE.gData_SpecNoRef,
                                                       ssp_WHERE.gData_SpecStatus,
                                                       ssp_WHERE.gData_SpecState,
                                                       ssp_WHERE.gData_SpecKind,
                                                       ssp_WHERE.gData_SizeRange,
                                                       ssp_WHERE.gData_Article,
                                                       ssp_WHERE.gData_Line,
                                                       ssp_WHERE.gData_MaterialName,
                                                       ssp_WHERE.gData_ColorName,
                                                       ssp_WHERE.gData_MoldName,
                                                       ssp_WHERE.gData_LastName,
                                                       ssp_WHERE.gData_Incharge,
                                                       ssp_WHERE.gData_CheckRequest,
                                                       ssp_WHERE.gData_CheckUse0,
                                                       ssp_WHERE.gData_CheckUse1)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs10, DS1, "USP_PFP40010_SEARCH_VS10", "vS10")
                Vs10.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs10, DS1, "USP_PFP40010_SEARCH_VS10", "vS10")
            DATA_SEARCH_VS10 = True

            Vs10.Enabled = True

        Catch ex As Exception

        End Try

    End Function

    Private Function DATA_SEARCH_VS20(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS20 = False

        vS20.Enabled = False
        Try
            DS1 = PrcDS("USP_PFP40010_SEARCH_VS20", cn, ssp_WHERE.gData_SDate,
                                                       ssp_WHERE.gData_EDate,
                                                       ssp_WHERE.gData_chkGCodeCheck,
                                                       ssp_WHERE.gData_chkGCodeSQL,
                                                       ssp_WHERE.gData_CustomerName,
                                                       ssp_WHERE.gData_Season,
                                                       ssp_WHERE.gData_SpecNoRef,
                                                       ssp_WHERE.gData_SpecStatus,
                                                       ssp_WHERE.gData_SpecState,
                                                       ssp_WHERE.gData_SpecKind,
                                                       ssp_WHERE.gData_SizeRange,
                                                       ssp_WHERE.gData_Article,
                                                       ssp_WHERE.gData_Line,
                                                       ssp_WHERE.gData_MaterialName,
                                                       ssp_WHERE.gData_ColorName,
                                                       ssp_WHERE.gData_MoldName,
                                                       ssp_WHERE.gData_LastName,
                                                       ssp_WHERE.gData_Incharge,
                                                       ssp_WHERE.gData_CheckRequest,
                                                       ssp_WHERE.gData_CheckUse0,
                                                       ssp_WHERE.gData_CheckUse1)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS20, DS1, "USP_PFP40010_SEARCH_VS20", "VS20")
                vS20.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS20, DS1, "USP_PFP40010_SEARCH_VS20", "VS20")
            DATA_SEARCH_VS20 = True

            vS20.Enabled = True

        Catch ex As Exception

        End Try

    End Function

    Private Function DATA_SEARCH_VS21(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS21 = False
        Dim WorkOrder As String
        Dim WorkOrderSeq As String

        WorkOrder = getData(vS20, getColumIndex(vS20, "KEY_WorkOrder"), vS20.ActiveSheet.ActiveRowIndex)
        WorkOrderSeq = getData(vS20, getColumIndex(vS20, "KEY_WorkOrderSeq"), vS20.ActiveSheet.ActiveRowIndex)

        vS21.Enabled = True
        Try
            DS1 = PrcDS("USP_PFP40010_SEARCH_VS21", cn, WorkOrder,
                                                       WorkOrderSeq)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS21, DS1, "USP_PFP40010_SEARCH_VS21", "VS21")
                vS21.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS21, DS1, "USP_PFP40010_SEARCH_VS21", "VS21")
            DATA_SEARCH_VS21 = True

            vS21.Enabled = True

        Catch ex As Exception

        End Try

    End Function

    Private Function DATA_SEARCH_VS11(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS11 = False
        Dim MaterialCode As String
        Dim OrderNo As String
        Dim OrderNoSeq As String

        MaterialCode = getData(Vs10, getColumIndex(Vs10, "MaterialCode"), Vs10.ActiveSheet.ActiveRowIndex)
        OrderNo = getData(Vs10, getColumIndex(Vs10, "KEY_OrderNo"), Vs10.ActiveSheet.ActiveRowIndex)
        OrderNoSeq = getData(Vs10, getColumIndex(Vs10, "Key_OrderNoSeq"), Vs10.ActiveSheet.ActiveRowIndex)

        vS11.Enabled = False
        Try
            DS1 = PrcDS("USP_PFP40010_SEARCH_VS11", cn, MaterialCode, OrderNo, OrderNoSeq)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS11, DS1, "USP_PFP40010_SEARCH_VS11", "VS11")
                vS11.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS11, DS1, "USP_PFP40010_SEARCH_VS11", "VS11")

            If READ_PFK1311(OrderNo) Then
                Call VsSizeRangeTool(vS11, "USP_PFP40010_SEARCH_VS11_HEAD", D1311.CustomerCode)
                vS11.ActiveSheet.RowCount += 2

                For i = getColumIndex(vS11, "SizeQty01") To vS11.ActiveSheet.ColumnCount - 1
                    setData(vS11, i, 2, CDecp(getData(vS11, i, 0)) * CDecp(getData(vS11, getColumIndex(vS11, "TimeInput"), 0)) - CDecp(getData(vS11, i, 1)))
                    setData(vS11, i, 3, CDecp(getData(vS11, i, 2)) / CDecp(getData(vS11, getColumIndex(vS11, "TimeInput"), 0)))

                Next

                setData(vS11, getColumIndex(vS11, "MaterialName"), 2, "Balance Qty :")
                setData(vS11, getColumIndex(vS11, "MaterialName"), 3, "Balance Last :")

            End If

            DATA_SEARCH_VS11 = True
            vS11.Enabled = True
            vS11.Enabled = True

        Catch ex As Exception

        End Try

    End Function

    Dim i As Integer

    Private Function DATA_SEARCH_VS30() As Boolean
        DATA_SEARCH_VS30 = False

        vS30.Enabled = False
        Try
            DS1 = PrcDS("USP_PFP40010_SEARCH_VS30", cn, ssp_WHERE.gData_SDate,
                                                       ssp_WHERE.gData_EDate,
                                                       ssp_WHERE.gData_chkGCodeCheck,
                                                       ssp_WHERE.gData_chkGCodeSQL,
                                                       ssp_WHERE.gData_CustomerName,
                                                       ssp_WHERE.gData_Season,
                                                       ssp_WHERE.gData_SpecNoRef,
                                                       ssp_WHERE.gData_SpecStatus,
                                                       ssp_WHERE.gData_SpecState,
                                                       ssp_WHERE.gData_SpecKind,
                                                       ssp_WHERE.gData_SizeRange,
                                                       ssp_WHERE.gData_Article,
                                                       ssp_WHERE.gData_Line,
                                                       ssp_WHERE.gData_MaterialName,
                                                       ssp_WHERE.gData_ColorName,
                                                       ssp_WHERE.gData_MoldName,
                                                       ssp_WHERE.gData_LastName,
                                                       ssp_WHERE.gData_Incharge,
                                                       ssp_WHERE.gData_CheckRequest,
                                                       ssp_WHERE.gData_CheckUse0,
                                                       ssp_WHERE.gData_CheckUse1)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS30, DS1, "USP_PFP40010_SEARCH_VS30", "VS30")
                vS30.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS30, DS1, "USP_PFP40010_SEARCH_VS30", "VS30")
            DATA_SEARCH_VS30 = True

            vS30.Enabled = True

        Catch ex As Exception

        End Try
    End Function

  

    Private Function LINE_MOVE_DISPLAY01() As Boolean
        LINE_MOVE_DISPLAY01 = False

    End Function

    Private Function LINE_MOVE_DISPLAY_VS20() As Boolean
        Dim WorkOrder As String
        Dim WorkOrderSeq As String

        Dim xrow As Integer
        LINE_MOVE_DISPLAY_VS20 = False
        Try
            xrow = vS20.ActiveSheet.ActiveRowIndex

            WorkOrder = getData(vS20, getColumIndex(vS20, "KEY_WorkOrder"), xrow)
            WorkOrderSeq = getData(vS20, getColumIndex(vS20, "KEY_WorkOrderSeq"), xrow)

            DS1 = PrcDS("USP_PFP40010_SEARCH_VS20_LINE", cn, WorkOrder, WorkOrderSeq)

            If GetDsRc(DS1) = 0 Then
                Exit Function
            End If
            READ_SPREAD(vS20, DS1, "USP_PFP40010_SEARCH_VS20_LINE", "VS20", xrow)

            LINE_MOVE_DISPLAY_VS20 = True
        Catch ex As Exception

        End Try
    End Function

    Private Function CustomerPurchasing_CHK() As String
        CustomerPurchasing_CHK = "1"
        Return CustomerPurchasing_CHK
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

    Private Sub Vs10_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs10.CellDoubleClick
        If DATA_SEARCH_VS11() Then

        End If
    End Sub
    Private Sub vS20_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS20.CellDoubleClick
        If DATA_SEARCH_VS21() Then

        End If
    End Sub


    Private Sub vS20_LostFocus(sender As Object, e As EventArgs) Handles vS20.LostFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False)

    End Sub

    Private Sub Vs10_Change(sender As Object, e As ChangeEventArgs) Handles Vs10.Change
        If e.Column = getColumIndex(Vs10, "QtyJobStandard") Then
            If READ_PFK7103_TYPENAME("002", getData(Vs10, getColumIndex(Vs10, "Article"), e.Row)) Then
                D7103.Standard1 = CIntp(getData(Vs10, getColumIndex(Vs10, "QtyJobStandard"), e.Row))
                Call REWRITE_PFK7103(D7103)
            End If
        End If

    End Sub

    Private Sub Vs10_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs10.KeyDown
        If e.KeyCode = Keys.Enter Then
            If READ_PFK7103_TYPENAME("002", getData(Vs10, getColumIndex(Vs10, "Article"), Vs10.ActiveSheet.ActiveRowIndex)) Then
                D7103.Standard1 = CIntp(getData(Vs10, getColumIndex(Vs10, "QtyJobStandard"), Vs10.ActiveSheet.ActiveRowIndex))
                Call REWRITE_PFK7103(D7103)
            End If
        End If
    End Sub

    Private Sub Vs10_GotFocus(sender As Object, e As EventArgs) Handles Vs10.GotFocus
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False)

    End Sub


    Private Sub Vs20_GotFocus(sender As Object, e As EventArgs) Handles vS20.GotFocus
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

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

        If ptc_1.SelectedIndex = 0 Then Call DATA_SEARCH_VS20()
        If ptc_1.SelectedIndex = 1 Then Call DATA_SEARCH_VS30()
    End Sub

    Private Sub Cms_3_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_3.ItemClicked
        If Cms_3.Items(0).Selected = True Then
            Cms_3.Hide()
            'MAIN_JOB03_1()

        ElseIf Cms_3.Items(2).Selected = True Then
            Cms_3.Hide()
            MAIN_JOB03_2()

        ElseIf Cms_3.Items(3).Selected = True Then
            Cms_3.Hide()
            MAIN_JOB03_3()


        ElseIf Cms_3.Items(5).Selected = True Then
            Cms_3.Hide()
            MAIN_JOB03_4()


        ElseIf Cms_3.Items(6).Selected = True Then
            Cms_3.Hide()
            MAIN_JOB03_5()

        ElseIf Cms_3.Items(7).Selected = True Then
            Cms_3.Hide()
            'MAIN_JOB03_6()

        ElseIf Cms_3.Items(8).Selected = True Then
            Cms_3.Hide()
            MAIN_JOB03_8()

        End If

    End Sub
    Private Sub HLP8986A_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If ptc_1.TabCount < 1 Then Exit Sub
        If Me.Width > 30 Then
            ptc_1.ItemSize = New Size((Me.Width - 30) / ptc_1.TabCount, 25)
        End If
    End Sub


    Private Sub vS21_Change(sender As Object, e As ChangeEventArgs) Handles vS21.Change

        If READ_PFK4010(getData(vS21, getColumIndex(vS21, "JobCard"), vS21.ActiveSheet.ActiveRowIndex)) = True Then
            If D4010.QtyStockfit > 0 Or D4010.QtyCutting > 0 Or D4010.QtyStitching > 0 Then Exit Sub

            D4010.SlNoD = getData(vS21, getColumIndex(vS21, "SlNoD"), vS21.ActiveSheet.ActiveRowIndex)

            Call REWRITE_PFK4010(D4010)

        End If

    End Sub


    Private Sub vS21_KeyDown(sender As Object, e As KeyEventArgs) Handles vS21.KeyDown
        If e.KeyCode = Keys.Enter Then
            If READ_PFK4010(getData(vS21, getColumIndex(vS21, "JobCard"), vS21.ActiveSheet.ActiveRowIndex)) = True Then
                If D4010.QtyStockfit > 0 Or D4010.QtyCutting > 0 Or D4010.QtyStitching > 0 Then Exit Sub

                D4010.SlNoD = getData(vS21, getColumIndex(vS21, "SlNoD"), vS21.ActiveSheet.ActiveRowIndex)

                Call REWRITE_PFK4010(D4010)

            End If
        End If
    End Sub
    Private Function DATA_MOVE_WRITE03_ROW(i As Integer) As Boolean
        DATA_MOVE_WRITE03_ROW = False
        Try

            Dim j As Integer
            Dim colstart As Integer

            j = 0
            If Trim(getData(vS21, getColumIndex(vS21, "JobCard"), i)) = "" Then Exit Function

            j = j + 1
            colstart = getColumIndex(vS21, "SizeQty01")
            If K4011_MOVE(vS21, i, W4011, getData(vS21, getColumIndex(vS21, "JobCard"), i)) = True Then
                Call PrcExe("USP_PFK4010_AUTO_BACKUP_JOBCARD", cn, W4011.JobCard)

                W4011.SizeQty01 = CDblp(getData(vS21, colstart, i))
                W4011.SizeQty02 = CDblp(getData(vS21, colstart + 1, i))
                W4011.SizeQty03 = CDblp(getData(vS21, colstart + 2, i))
                W4011.SizeQty04 = CDblp(getData(vS21, colstart + 3, i))
                W4011.SizeQty05 = CDblp(getData(vS21, colstart + 4, i))
                W4011.SizeQty06 = CDblp(getData(vS21, colstart + 5, i))
                W4011.SizeQty07 = CDblp(getData(vS21, colstart + 6, i))
                W4011.SizeQty08 = CDblp(getData(vS21, colstart + 7, i))
                W4011.SizeQty09 = CDblp(getData(vS21, colstart + 8, i))
                W4011.SizeQty10 = CDblp(getData(vS21, colstart + 9, i))
                W4011.SizeQty11 = CDblp(getData(vS21, colstart + 10, i))
                W4011.SizeQty12 = CDblp(getData(vS21, colstart + 11, i))
                W4011.SizeQty13 = CDblp(getData(vS21, colstart + 12, i))
                W4011.SizeQty14 = CDblp(getData(vS21, colstart + 13, i))
                W4011.SizeQty15 = CDblp(getData(vS21, colstart + 14, i))
                W4011.SizeQty16 = CDblp(getData(vS21, colstart + 15, i))
                W4011.SizeQty17 = CDblp(getData(vS21, colstart + 16, i))
                W4011.SizeQty18 = CDblp(getData(vS21, colstart + 17, i))
                W4011.SizeQty19 = CDblp(getData(vS21, colstart + 18, i))
                W4011.SizeQty20 = CDblp(getData(vS21, colstart + 19, i))
                W4011.SizeQty21 = CDblp(getData(vS21, colstart + 20, i))
                W4011.SizeQty22 = CDblp(getData(vS21, colstart + 21, i))
                W4011.SizeQty23 = CDblp(getData(vS21, colstart + 22, i))
                W4011.SizeQty24 = CDblp(getData(vS21, colstart + 23, i))
                W4011.SizeQty25 = CDblp(getData(vS21, colstart + 24, i))
                W4011.SizeQty26 = CDblp(getData(vS21, colstart + 25, i))
                W4011.SizeQty27 = CDblp(getData(vS21, colstart + 26, i))
                W4011.SizeQty28 = CDblp(getData(vS21, colstart + 27, i))
                W4011.SizeQty29 = CDblp(getData(vS21, colstart + 28, i))
                W4011.SizeQty30 = CDblp(getData(vS21, colstart + 29, i))

                Call REWRITE_PFK4011(W4011)
                isudCHK = True

            End If


            DATA_MOVE_WRITE03_ROW = True

        Catch ex As Exception
            MsgBoxP("DATA_MOVE_WRITE03_ROW")
        End Try

    End Function

#End Region

End Class