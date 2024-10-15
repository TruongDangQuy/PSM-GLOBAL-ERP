Public Class ISUD7741B

#Region "Variable"
    Private wJOB As Integer

    Private WRITE_CHK As Boolean
    Private FIRST_LINE_CHK As Boolean

    Private privS1_SCOL As Integer

    Private Dsu01 As Integer
    Private Dsu02 As Integer
    Private Dsu04 As Integer


    Private W7741 As T7741_AREA
    Private M7741 As T7741_AREA
    Private L7741 As T7741_AREA

    Private W7743 As T7743_AREA
    Private M7743 As T7743_AREA
    Private L7743 As T7743_AREA

    Private priJOB_CHK As String

    Private CHK(0 To 5) As String


    Private loop_check As Boolean
    Private formA As Boolean
#End Region

#Region "Link"
    Public Function Link_ISUD7741B(job As Integer, cdFactory As String, cdSubProcess As String, DatePlan As String, cdLineProd As String, Optional SeqJob As String = "", Optional FormName As String = "") As Boolean
        Me.Tag = FormName
        On Error GoTo Error_Message

        D7741.cdFactory = cdFactory : D7741.DatePlan = DatePlan : D7741.cdLineProd = cdLineProd : D7741.cdSubProcess = cdSubProcess
        D7743.cdFactory = cdFactory : D7743.DatePlan = DatePlan : D7743.cdLineProd = cdLineProd : D7743.cdSubProcess = cdSubProcess : D7743.SeqJob = SeqJob

        If READ_PFK7171(ListCode("Factory"), cdFactory) Then
            txt_cdFactory.Code = cdFactory
            txt_cdFactory.Data = D7171.BasicName
        End If

        If READ_PFK7171(ListCode("SubProcess"), cdSubProcess) Then
            txt_cdSubProcess.Code = cdSubProcess
            txt_cdSubProcess.Data = D7171.BasicName
        End If

        If READ_PFK7171(ListCode("LineProd"), cdLineProd) Then
            txt_cdLineProd.Code = cdLineProd
            txt_cdLineProd.Data = D7171.BasicName
        End If

        txt_DatePlan.Data = Pub.DAT

        wJOB = job : L7741 = D7741 : L7743 = D7743

        formA = False
        Link_ISUD7741B = False

        Select Case wJOB
            Case "1", "11"
            Case Else
                If READ_PFK7741(L7741.cdFactory, L7741.cdSubProcess, L7741.DatePlan, L7741.cdLineProd) = False Then
                    Call Error_Message("3", "Link_ISUD7741B")
                    Exit Function
                End If

                If D7741.DatePlan > Pub.DAT Then wJOB = 2

        End Select

        Me.ShowDialog()

        Link_ISUD7741B = isudCHK

        Exit Function
Error_Message:
        Call Error_Message("37", WordConv("Link_ISUD7741B"))
    End Function
#End Region

#Region "Form_Load"
    Public Overridable Sub HLP0001_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hlp0000SeVaTt = ""
        hlp0000SeVa = ""
        hlp0000SeVaTt1 = ""
        Me.WindowState = FormWindowState.Maximized
        Array_hlp0000SeVaTt.Clear()
        hlpCHK = False

        vS2.AllowRowMove = True
        Call Cms_additem(Cms_1,
                     WordConv("ADD GROUP PROCESSING") & "(F5)")

        Call DATA_SEARCH_HEAD_vs_Fact()
        Call DATA_SEARCH_HEAD_vS_Sub()
        Call DATA_SEARCH_HEAD_vS_Line()

        Call DATA_SEARCH_HEAD_vS_Machine()

        Call DATA_SEARCH_VS2()

        Setfocus(txt_Name)

    End Sub
#End Region

#Region "DATA_SEARCH"

    Public Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False

        Try
            If FormatCut(txt_Name.Data) = "" Then
                DS1 = PrcDS("USP_ISUD7741B_SEARCH_VS1", cn, txt_cdFactory.Code, txt_cdSubProcess.Code, txt_DatePlan.Data, txt_cdLineProd.Code)
            Else
                DS1 = PrcDS("USP_ISUD7741B_SEARCH_VS1_IDNO", cn, "*" & txt_Name.Data)
            End If

            If GetDsRc(DS1) = 0 Then
                DS2 = PrcDS("USP_ISUD7741B_SEARCH_VS1_INSERT", cn, txt_cdFactory.Code, txt_cdSubProcess.Code, txt_DatePlan.Data, txt_cdLineProd.Code)
                SPR_PRO_NEW(Vs1, DS2, "USP_ISUD7741B_SEARCH_VS1", "Vs1")
                Vs1.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs1, DS1, "USP_ISUD7741B_SEARCH_VS1", "Vs1")

            If READ_PFK7741(txt_cdFactory.Code, txt_cdSubProcess.Code, txt_DatePlan.Data, txt_cdLineProd.Code) Then
                txt_QtyTargetDay.Data = D7741.QtyTargetDay
                txt_QtyTargetHour.Data = D7741.QtyTargetHour
            End If

            DATA_SEARCH_VS1 = True

            Me.Show()
            Application.DoEvents()
            Vs1.Focus()

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Public Function DATA_SEARCH_VS2() As Boolean
        DATA_SEARCH_VS2 = False

        Try

            If rad_chkTeam1.Checked Then
                DS1 = PrcDS("USP_ISUD7741B_SEARCH_VS2_F1", cn, txt_cdFactory.Code, txt_cdSubProcess.Code, txt_DatePlan.Data, txt_cdLineProd.Code, "1")
            Else
                DS1 = PrcDS("USP_ISUD7741B_SEARCH_VS2_F1", cn, txt_cdFactory.Code, txt_cdSubProcess.Code, txt_DatePlan.Data, txt_cdLineProd.Code, "2")
            End If


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS2, DS1, "USP_ISUD7741B_SEARCH_VS2", "VS2")
                vS2.ActiveSheet.RowCount = 1
                vS2.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS2, DS1, "USP_ISUD7741B_SEARCH_VS2", "VS2")

            DATA_SEARCH_VS2 = True

            Me.Show()
            Application.DoEvents()
            vS2.Focus()

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Public Function DATA_SEARCH_HEAD_vs_Fact() As Boolean
        DATA_SEARCH_HEAD_vs_Fact = False

        Try
            DS1 = PrcDS("USP_ISUD7741B_SEARCH_vs_Fact", cn, ListCode("Factory"))
            SPR_PRO_NEW(vs_Fact, DS1, "USP_ISUD7741B_SEARCH_vs_Fact", "vs_Fact")
            vs_Fact.VerticalScrollBarPolicy = ScrollBarPolicy.Never
            vs_Fact.HorizontalScrollBarPolicy = ScrollBarPolicy.Never
            DS1 = Nothing
            DATA_SEARCH_HEAD_vs_Fact = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Public Function DATA_SEARCH_HEAD_vS_Sub() As Boolean
        DATA_SEARCH_HEAD_vS_Sub = False

        Dim cdFactory As String
        cdFactory = getData(vs_Fact, getColumIndex(vs_Fact, "BasicCode"), vs_Fact.ActiveSheet.ActiveRowIndex)

        Try
            DS1 = PrcDS("USP_ISUD7741B_SEARCH_vs_SubProcess", cn, ListCode("SubProcess"), cdFactory)
            SPR_PRO_NEW(vS_Sub, DS1, "USP_ISUD7741B_SEARCH_vs_SubProcess", "vS_Sub")
            vS_Sub.VerticalScrollBarPolicy = ScrollBarPolicy.Never
            vS_Sub.HorizontalScrollBarPolicy = ScrollBarPolicy.Never
            DATA_SEARCH_HEAD_vS_Sub = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Public Function DATA_SEARCH_HEAD_vS_Line() As Boolean
        DATA_SEARCH_HEAD_vS_Line = False

        Dim cdSubProcess As String
        cdSubProcess = getData(vS_Sub, getColumIndex(vS_Sub, "BasicCode"), vS_Sub.ActiveSheet.ActiveRowIndex)

        Dim cdFactory As String
        cdFactory = getData(vs_Fact, getColumIndex(vs_Fact, "BasicCode"), vs_Fact.ActiveSheet.ActiveRowIndex)

        Try
            DS1 = PrcDS("USP_ISUD7741B_SEARCH_vs_LineProd_F1", cn, ListCode("LineProd"), cdFactory, cdSubProcess)
            SPR_PRO_NEW(vS_Line, DS1, "USP_ISUD7741B_SEARCH_vs_LineProd_F1", "vS_Line")

            vS_Line.VerticalScrollBarPolicy = ScrollBarPolicy.Never
            vS_Line.HorizontalScrollBarPolicy = ScrollBarPolicy.Never
            DS1 = Nothing

            DATA_SEARCH_HEAD_vS_Line = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Public Function DATA_SEARCH_HEAD_vS_Machine() As Boolean
        DATA_SEARCH_HEAD_vS_Machine = False

        Try
            DS1 = PrcDS("USP_ISUD7741B_SEARCH_vs_Machine", cn, txt_cdFactory.Code, txt_cdSubProcess.Code)
            SPR_PRO_NEW(vS_Machine, DS1, "USP_ISUD7741B_SEARCH_vs_Machine", "vS_Spec")

            vS_Machine.VerticalScrollBarPolicy = ScrollBarPolicy.Never
            vS_Machine.HorizontalScrollBarPolicy = ScrollBarPolicy.Never

            DATA_SEARCH_HEAD_vS_Machine = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function
#End Region

#Region "Function"
    Private Function KEY_COUNT() As Boolean
        On Error GoTo Error_Message
        KEY_COUNT = False

        Dim i As Integer
        Dim k As Integer

        Dim strKEY_VALUE As String
        Dim strKEY_CNT As String

Start_KEY_COUNT:
        '============================================================================

        SQL = " SELECT MAX(CAST(ISNULL(K7743_SeqJob ,0)  AS NVARCHAR(10))) AS MAX_CODE FROM PFK7743 "
        SQL = SQL & " WHERE  K7743_cdFactory    = '" & txt_cdFactory.Code & "' "
        SQL = SQL & "   AND  K7743_cdSubProcess  = '" & txt_cdSubProcess.Code & "' "
        SQL = SQL & "   AND  K7743_cdLineProd  = '" & txt_cdLineProd.Code & "' "
        SQL = SQL & "   AND  K7743_DatePlan  = '" & txt_DatePlan.Data & "' "

        rd = New SqlClient.SqlCommand(SQL, cn).ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            strKEY_CNT = "001"
        Else
            strKEY_CNT = FormatP(Int(rd!MAX_CODE + 1), "000")
        End If


        W7743.SeqJob = strKEY_CNT
        L7743.SeqJob = strKEY_CNT

        rd.Close()
        '============================================================================
End_KEY_COUNT:
        KEY_COUNT = True

        Exit Function
Error_Message:

        Call Error_Message("37", "KEY_COUNT")
    End Function

    Private Sub MAIN_JOB05()
        Select Case True
            Case vs_Fact.Focused
                Dim cdFactory As String

                cdFactory = getData(vs_Fact, getColumIndex(vs_Fact, "BasicCode"), vs_Fact.ActiveSheet.ActiveRowIndex)

                Call ISUD7171A.Link_ISUD7171A(1, ListCode("Factory"), cdFactory, ListCode("SubProcess"), "000")

            Case vS_Line.Focused

            Case vS_Machine.Focused

        End Select

    End Sub
#End Region

#Region "Events"
    Private Sub SelectLabelSearch1_KeyDown(sender As Object, e As KeyPressEventArgs) Handles txt_Name.txtTextKeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cmd_SEARCH.PerformClick()
        End If

    End Sub
    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click

        If txt_Name.Data <> "" Then Call DATA_SEARCH_VS1()
        If txt_Name.Data = "" Then Call DATA_SEARCH_HEAD_vs_Fact() : vS_Sub.ActiveSheet.RowCount = 0 : vS_Line.ActiveSheet.RowCount = 0 : vS_Machine.ActiveSheet.RowCount = 0 : Vs1.ActiveSheet.RowCount = 0 : vS2.ActiveSheet.RowCount = 0

        'Call DATA_SEARCH_HEAD_vs_Fact()
        'Call DATA_SEARCH_HEAD_vS_Sub()
        'Call DATA_SEARCH_HEAD_vS_Line()
        'Call DATA_SEARCH_HEAD_vS_Machine()

    End Sub
    Public Overridable Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        Dim i As Integer

        Try
            If READ_PFK7741(txt_cdFactory.Code, txt_cdSubProcess.Code, txt_DatePlan.Data, txt_cdLineProd.Code) Then
                W7741 = D7741

                W7741.QtyTargetDay = CDecp(txt_QtyTargetDay.Data)
                W7741.QtyTargetHour = CDecp(txt_QtyTargetHour.Data)

                Call REWRITE_PFK7741(W7741)

                For i = 0 To vS2.ActiveSheet.RowCount - 1
                    If READ_PFK7743(txt_cdFactory.Code, txt_cdSubProcess.Code, txt_DatePlan.Data, txt_cdLineProd.Code, getData(vS2, getColumIndex(vS2, "KEY_SeqJob"), i)) = False Then
                        W7743 = D7743
                        Call KEY_COUNT()
                        W7743.seJobProcess = ListCode("JobProcess")
                        W7743.seSubProcess = ListCode("SubProcess")


                        If READ_PFK7171(ListCode("SubProcess"), txt_cdSubProcess.Code) Then
                            W7743.seMainProcess = D7171.seBasicMaster
                            W7743.cdMainProcess = D7171.cdBasicMaster
                        End If


                        W7743.cdFactory = txt_cdFactory.Code
                        W7743.cdSubProcess = txt_cdSubProcess.Code
                        W7743.DatePlan = txt_DatePlan.Data
                        W7743.cdLineProd = txt_cdLineProd.Code

                        W7743.MachineCode = getData(vS2, getColumIndex(vS2, "MachineCode"), i)

                        W7743.InchargeJob = getData(vS2, getColumIndex(vS2, "InchargeJob"), i)
                        W7743.cdJobProcess = ""

                        W7743.QtyRateSecondJob = 0
                        W7743.QtyTargetDay = CDecp(getData(vS2, getColumIndex(vS2, "QtyTargetDay"), i))
                        W7743.QtyTargetHour = CDecp(getData(vS2, getColumIndex(vS2, "QtyTargetHour"), i))

                        W7743.InchargeSelect = "1"

                        W7743.seMainProcess = ListCode("MainProcess")
                        W7743.seSubProcess = ListCode("SubProcess")

                        If rad_chkTeam1.Checked Then W7743.chkTeam = "1"
                        If rad_chkTeam2.Checked Then W7743.chkTeam = "2"

                        Call WRITE_PFK7743(W7743)
                    Else
                        W7743 = D7743

                        W7743.MachineCode = getData(vS2, getColumIndex(vS2, "MachineCode"), i)
                        W7743.QtyRateSecondJob = 0
                        W7743.QtyTargetDay = CDecp(getData(vS2, getColumIndex(vS2, "QtyTargetDay"), i))
                        W7743.QtyTargetHour = CDecp(getData(vS2, getColumIndex(vS2, "QtyTargetHour"), i))
                        W7743.InchargeSelect = "1"

                        If rad_chkTeam1.Checked Then W7743.chkTeam = "1"
                        If rad_chkTeam2.Checked Then W7743.chkTeam = "2"

                        Call REWRITE_PFK7743(W7743)

                    End If

                Next



            Else
                W7741.cdFactory = FormatP(txt_cdFactory.Code, "000")
                W7741.DatePlan = Replace(txt_DatePlan.Data, "/", "")
                W7741.cdLineProd = FormatP(txt_cdLineProd.Code, "000")
                W7741.InchargePlan = Pub.SAW
                W7741.cdSubProcess = txt_cdSubProcess.Code
                W7741.TimeJob = "0730"
                W7741.QtyTargetDay = 0
                W7741.QtyTargetHour = 0
                W7741.QtyRateSecond = 0

                W7741.seFactory = ListCode("Factory")
                W7741.seLineProd = ListCode("LineProd")
                W7741.seSubProcess = ListCode("SubProcess")

                W7741.QtyTargetDay = CDecp(txt_QtyTargetDay.Data)
                W7741.QtyTargetHour = CDecp(txt_QtyTargetHour.Data)

                If READ_PFK7171(ListCode("SubProcess"), txt_cdSubProcess.Code) Then
                    W7741.seMainProcess = D7171.seBasicMaster
                    W7741.cdMainProcess = D7171.cdBasicMaster
                End If

                If WRITE_PFK7741(W7741) Then
                    For i = 0 To vS2.ActiveSheet.RowCount - 1
                        If READ_PFK7743(txt_cdFactory.Code, txt_cdSubProcess.Code, txt_DatePlan.Data, txt_cdLineProd.Code, getData(vS2, getColumIndex(vS2, "SelJob"), i)) = False Then
                            W7743 = D7743
                            Call KEY_COUNT()
                            W7743.seJobProcess = ListCode("JobProcess")
                            W7743.seSubProcess = ListCode("SubProcess")

                            If READ_PFK7171(ListCode("SubProcess"), txt_cdSubProcess.Code) Then
                                W7743.seMainProcess = D7171.seBasicMaster
                                W7743.cdMainProcess = D7171.cdBasicMaster
                            End If


                            W7743.cdFactory = txt_cdFactory.Code
                            W7743.cdSubProcess = txt_cdSubProcess.Code
                            W7743.DatePlan = txt_DatePlan.Data
                            W7743.cdLineProd = txt_cdLineProd.Code

                            W7743.MachineCode = getData(vS2, getColumIndex(vS2, "MachineCode"), i)

                            W7743.InchargeJob = getData(vS2, getColumIndex(vS2, "InchargeJob"), i)
                            W7743.cdJobProcess = ""

                            W7743.QtyRateSecondJob = 0

                            W7743.QtyTargetDay = CDecp(getData(vS2, getColumIndex(vS2, "QtyTargetDay"), i))
                            W7743.QtyTargetHour = CDecp(getData(vS2, getColumIndex(vS2, "QtyTargetHour"), i))

                            W7743.InchargeSelect = "1"

                            'If opt_InchargeSelect0.Checked = True Then W7743.InchargeSelect = "1"
                            'If opt_InchargeSelect1.Checked = True Then W7743.InchargeSelect = "2"
                            'If opt_InchargeSelect2.Checked = True Then W7743.InchargeSelect = "3"

                            'If opt_Grade0.Checked = True Then W7743.Grade = "1"
                            'If opt_Grade1.Checked = True Then W7743.Grade = "2"
                            'If opt_Grade2.Checked = True Then W7743.Grade = "3"
                            'If opt_Grade3.Checked = True Then W7743.Grade = "4"
                            If rad_chkTeam1.Checked Then W7743.chkTeam = "1"
                            If rad_chkTeam2.Checked Then W7743.chkTeam = "2"

                            Call WRITE_PFK7743(W7743)

                        End If

                    Next
                End If


            End If

            Call DATA_SEARCH_VS2()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs)
        If e.Row < 0 Then Exit Sub
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub

    Private Sub Vs1_CellClick1(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        Dim Value() As String

        Value = Trim(getData(Vs1, getColumIndex(Vs1, "MaterialName"), Vs1.ActiveSheet.ActiveRowIndex)).Split(" ")

    End Sub

    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        'If chk_FullText.Checked = False Then Exit Sub

        hlp0000SeVaTt = getData(Vs1, getColumIndex(Vs1, "InchargeJob"), Vs1.ActiveSheet.ActiveRowIndex)

        If READ_PFK7411(hlp0000SeVaTt) Then
            If vS2.ActiveSheet.RowCount = 0 Then vS2.ActiveSheet.RowCount = 1
            If vS2.ActiveSheet.RowCount >= 1 And getData(vS2, getColumIndex(vS2, "InchargeJob"), vS2.ActiveSheet.RowCount - 1) <> "" Then vS2.ActiveSheet.RowCount += 1
            setData(vS2, getColumIndex(vS2, "InchargeJob"), vS2.ActiveSheet.RowCount - 1, D7411.IDNO)
            setData(vS2, getColumIndex(vS2, "InchargeJobName"), vS2.ActiveSheet.RowCount - 1, D7411.Name)

            setData(vS2, getColumIndex(vS2, "InchargeJobIDHRCode"), vS2.ActiveSheet.RowCount - 1, D7411.IDHRCode)

            setData(vS2, getColumIndex(vS2, "cdFactory"), vS2.ActiveSheet.RowCount - 1, D7411.cdFactory)
            setData(vS2, getColumIndex(vS2, "cdSubProcess"), vS2.ActiveSheet.RowCount - 1, D7411.cdSubProcess)
            setData(vS2, getColumIndex(vS2, "cdLineProd"), vS2.ActiveSheet.RowCount - 1, D7411.cdLineProd)

            setData(vS2, getColumIndex(vS2, "DatePlan"), vS2.ActiveSheet.RowCount - 1, txt_DatePlan.Data)

            If READ_PFK7171(ListCode("Factory"), D7411.cdFactory) Then
                setData(vS2, getColumIndex(vS2, "KEY_cdFactory"), vS2.ActiveSheet.RowCount - 1, D7171.BasicCode)
                setData(vS2, getColumIndex(vS2, "cdFactoryName"), vS2.ActiveSheet.RowCount - 1, D7171.BasicName)
            End If

            If READ_PFK7171(ListCode("SubProcess"), D7411.cdSubProcess) Then
                setData(vS2, getColumIndex(vS2, "KEY_cdSubProcess"), vS2.ActiveSheet.RowCount - 1, D7171.BasicCode)
                setData(vS2, getColumIndex(vS2, "cdSubProcessName"), vS2.ActiveSheet.RowCount - 1, D7171.BasicName)
            End If

            If READ_PFK7171(ListCode("LineProd"), D7411.cdLineProd) Then
                setData(vS2, getColumIndex(vS2, "KEY_cdLineProd"), vS2.ActiveSheet.RowCount - 1, D7171.BasicCode)
                setData(vS2, getColumIndex(vS2, "cdLineProdName"), vS2.ActiveSheet.RowCount - 1, D7171.BasicName)
            End If




        End If



    End Sub

    Private Sub tst_iClose_Click_1(sender As Object, e As EventArgs) Handles tst_iClose.Click
        hlp0000SeVaTt = ""
        hlp0000SeVa = ""
        hlp0000SeVaTt1 = ""
        Array_hlp0000SeVaTt.Clear()

        hlpCHK = False
        Me.Dispose()
    End Sub

    Private Sub Vs1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown
        If e.KeyCode = Keys.Enter Then
            tst_iSave.PerformClick()
        End If
    End Sub

    Private Sub txt_Add_Click(sender As Object, e As EventArgs) Handles txt_Add.Click
        'If ISUD7231A.Link_ISUD7231A(1, getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex), "PFP70231") = False Then Exit Sub

        'Call DATA_SEARCH_VS1()

        Dim IDNO As String

        IDNO = ""
        If ISUD7411A.Link_ISUD7411A(1, IDNO, "PFP74110") = False Then Exit Sub

    End Sub

    Private Sub vS2_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS2.CellDoubleClick
        'If ISUD7231S.Link_ISUD7231S(3, getData(vS2, getColumIndex(vS2, "Key_MaterialCode"), vS2.ActiveSheet.ActiveRowIndex), "PFP70231") = False Then Exit Sub
        'If READ_PFK7231(getData(vS2, getColumIndex(vS2, "Key_MaterialCode"), vS2.ActiveSheet.ActiveRowIndex)) Then



        'End If

    End Sub

    Private Sub vS2_KeyDown(sender As Object, e As KeyEventArgs) Handles vS2.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim xRow As Integer

            xRow = vS2.ActiveSheet.ActiveRowIndex

            W7743.cdFactory = getData(vS2, getColumIndex(vS2, "cdFactory"), xRow)
            W7743.cdSubProcess = getData(vS2, getColumIndex(vS2, "cdSubProcess"), xRow)
            W7743.DatePlan = Replace(getData(vS2, getColumIndex(vS2, "DatePlan"), xRow), "/", "")
            W7743.cdLineProd = getData(vS2, getColumIndex(vS2, "cdLineProd"), xRow)
            W7743.SeqJob = getData(vS2, getColumIndex(vS2, "SeqJob"), xRow)


            If READ_PFK7743(W7743.cdFactory, W7743.cdSubProcess, W7743.DatePlan, W7743.cdLineProd, W7743.SeqJob) = True Then
                W7743 = D7743

                DELETE_PFK7743(W7743)

            End If

            SPR_DEL(vS2, vS2.ActiveSheet.ActiveColumnIndex, vS2.ActiveSheet.ActiveRowIndex)
        End If
    End Sub

    Private Sub vs_Fact_CellClick(sender As Object, e As CellClickEventArgs) Handles vs_Fact.CellClick
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        Try
            txt_cdFactory.Code = ""
            txt_cdFactory.Data = ""

            Dim cdFactory As String

            cdFactory = getData(vs_Fact, getColumIndex(vs_Fact, "BasicCode"), vs_Fact.ActiveSheet.ActiveRowIndex)

            If READ_PFK7171(ListCode("Factory"), cdFactory) Then
                txt_cdFactory.Code = D7171.BasicCode
                txt_cdFactory.Data = D7171.BasicName
            End If

            Call DATA_SEARCH_HEAD_vS_Machine()
            Call DATA_SEARCH_HEAD_vS_Sub()
            Call DATA_SEARCH_VS1()

            DS1 = PrcDS("USP_ISUD7741B_SEARCH_VS2", cn, txt_cdFactory.Code, txt_cdSubProcess.Code, txt_DatePlan.Data, txt_cdLineProd.Code)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS2, DS1, "USP_ISUD7741B_SEARCH_VS2", "VS2")
                vS2.Enabled = True
                Exit Sub
            End If
            SPR_PRO_NEW(vS2, DS1, "USP_ISUD7741B_SEARCH_VS2", "VS2")

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Sub

    Private Sub vS_Sub_CellClick(sender As Object, e As CellClickEventArgs) Handles vS_Sub.CellClick
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub

        Try
            Dim cdSubProcess As String

            cdSubProcess = getData(vS_Sub, getColumIndex(vS_Sub, "BasicCode"), vS_Sub.ActiveSheet.ActiveRowIndex)

            If READ_PFK7171(ListCode("SubProcess"), cdSubProcess) Then
                txt_cdSubProcess.Code = D7171.BasicCode
                txt_cdSubProcess.Data = D7171.BasicName
            End If

            Call DATA_SEARCH_HEAD_vS_Machine()
            Call DATA_SEARCH_HEAD_vS_Line()
            Call DATA_SEARCH_VS1()

            If rad_chkTeam1.Checked Then
                DS1 = PrcDS("USP_ISUD7741B_SEARCH_VS2_F1", cn, txt_cdFactory.Code, txt_cdSubProcess.Code, txt_DatePlan.Data, txt_cdLineProd.Code, "1")
            Else
                DS1 = PrcDS("USP_ISUD7741B_SEARCH_VS2_F1", cn, txt_cdFactory.Code, txt_cdSubProcess.Code, txt_DatePlan.Data, txt_cdLineProd.Code, "2")
            End If


            'DS1 = PrcDS("USP_ISUD7741B_SEARCH_VS2", cn, txt_cdFactory.Code, txt_cdSubProcess.Code, txt_DatePlan.Data, txt_cdLineProd.Code)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS2, DS1, "USP_ISUD7741B_SEARCH_VS2", "VS2")
                vS2.Enabled = True
                Exit Sub
            End If

            SPR_PRO_NEW(vS2, DS1, "USP_ISUD7741B_SEARCH_VS2", "VS2")

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Sub

    Private Sub vS_Line_CellClick(sender As Object, e As CellClickEventArgs) Handles vS_Line.CellClick
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub

        Try
            txt_cdLineProd.Code = ""
            txt_cdLineProd.Data = ""

            Dim cdLineProd As String

            cdLineProd = getData(vS_Line, getColumIndex(vS_Line, "BasicCode"), vS_Line.ActiveSheet.ActiveRowIndex)

            If READ_PFK7171(ListCode("LineProd"), cdLineProd) Then
                txt_cdLineProd.Code = D7171.BasicCode
                txt_cdLineProd.Data = D7171.BasicName
            End If

            Call DATA_SEARCH_HEAD_vS_Machine()
            Call DATA_SEARCH_VS1()

            'DS1 = PrcDS("USP_ISUD7741B_SEARCH_VS2", cn, txt_cdFactory.Code, txt_cdSubProcess.Code, txt_DatePlan.Data, txt_cdLineProd.Code)
            If rad_chkTeam1.Checked Then
                DS1 = PrcDS("USP_ISUD7741B_SEARCH_VS2_F1", cn, txt_cdFactory.Code, txt_cdSubProcess.Code, txt_DatePlan.Data, txt_cdLineProd.Code, "1")
            Else
                DS1 = PrcDS("USP_ISUD7741B_SEARCH_VS2_F1", cn, txt_cdFactory.Code, txt_cdSubProcess.Code, txt_DatePlan.Data, txt_cdLineProd.Code, "2")
            End If


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS2, DS1, "USP_ISUD7741B_SEARCH_VS2", "VS2")
                vS2.Enabled = True
                Exit Sub
            End If
            SPR_PRO_NEW(vS2, DS1, "USP_ISUD7741B_SEARCH_VS2", "VS2")

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Sub

    Private Sub vS_Spec_CellClick(sender As Object, e As CellClickEventArgs) Handles vS_Machine.CellClick
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub

        setData(vS2, getColumIndex(vS2, "MachineCode"), vS2.ActiveSheet.ActiveRowIndex, getData(vS_Machine, getColumIndex(vS_Machine, "MachineCode"), vS_Machine.ActiveSheet.ActiveRowIndex))
        setData(vS2, getColumIndex(vS2, "MachineName"), vS2.ActiveSheet.ActiveRowIndex, getData(vS_Machine, getColumIndex(vS_Machine, "MachineName"), vS_Machine.ActiveSheet.ActiveRowIndex))


    End Sub

    Private Sub cmd_Copy_Click(sender As Object, e As EventArgs) Handles cmd_Copy.Click
        Dim IDNO As String

        IDNO = getData(Vs1, getColumIndex(Vs1, "InchargeJob"), Vs1.ActiveSheet.ActiveRowIndex)
        If ISUD7411A.Link_ISUD7411A(3, IDNO, "PFP74110") = False Then Exit Sub
    End Sub

    Private Sub cmd_QuickAdd_Click(sender As Object, e As EventArgs) Handles cmd_QuickAdd.Click
        Dim i, j As Integer

        vS2.ActiveSheet.RowCount = Vs1.ActiveSheet.RowCount
        If vS2.ActiveSheet.RowCount = 0 Then Exit Sub

        For i = 0 To Vs1.ActiveSheet.RowCount - 1
            For j = 0 To Vs1.ActiveSheet.ColumnCount - 1
                setData(vS2, j, i, getData(Vs1, j, i))
            Next
        Next


    End Sub

    Private Sub Cms_1_Click(sender As Object, e As EventArgs) Handles Cms_1.ItemClicked
        Select Case True
            Case Cms_1.Items(0).Selected
                Cms_1.Hide()
                Call MAIN_JOB05()
        End Select

    End Sub
#End Region

End Class