Public Class PFP13123

#Region "Variable"
    Private Dsu01 As Long
    Private wGCODE As String
    Protected prg As E_PRG

    Private W1311 As T1311_AREA
    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim xISUD1311A_F1 As String = ISUD1311A_F1.Text
        Dim xISUD1311P As String = ISUD1311P.Text
        Dim xHLP0511A As String = HLP0511A.Text

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

        Call Cms_additem(Cms_1, _
                                xISUD1311A_F1 & " - " & WordConv("INPUT") & "(F5)",
                                xISUD1311A_F1 & " - " & WordConv("SEARCH") & "(F6)",
                                xISUD1311A_F1 & " - " & WordConv("UPDATE") & "(F7)",
                                xISUD1311A_F1 & " - " & WordConv("DELETE") & "(F8)",
                                "-",
                                xISUD1311P & " - " & WordConv("APPROVAL - LINE "),
                                xISUD1311P & " - " & WordConv("APPROVAL - ALL"),
                                "-",
                                xISUD1311P & " - " & "COPY NEW - LINE",
                                xISUD1311P & " - " & "COPY NEW - ALL",
                                "-",
                                xISUD1311A_F1 & " - " & "REVISE ORDER - LINE",
                                xISUD1311A_F1 & " - " & "REVISE ORDER -ALL")


        Vs1.ContextMenuStrip = Cms_1

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

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
                Case Keys.F10 : Call MAIN_JOB06()
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

        SplitContainer1.Panel1Collapsed = Not chk_Total.Checked
        SplitContainer2.Panel1Collapsed = Not chk_Total.Checked

    End Sub

    Private Sub DATA_INIT()
        ssp_WHERE.txt_SdateEdate.text1 = System_Date_Add(-1)
        ssp_WHERE.txt_SdateEdate.text2 = System_Date_8()

        Call Gadget_Load(ssp_WHERE, Me.Name)

        If chk_Total.Checked Then Call DATA_SEARCH_HEAD_vs_Season()
        If chk_Total.Checked Then Call DATA_SEARCH_HEAD_vS_Line()

          Select Strings.Right(Me.PeaceFormType, 3).ToUpper
            Case "PKO"
                ssp_WHERE.txt_cdSpecState.Code = "007"
                ssp_WHERE.txt_cdSpecState.Data = "FIN"
                ssp_WHERE.txt_cdSpecState.Enabled = False

            Case Else

                ssp_WHERE.txt_cdSpecState.Code = "006"
                ssp_WHERE.txt_cdSpecState.Data = "PPS"
                ssp_WHERE.txt_cdSpecState.Enabled = False

        End Select


    End Sub
#End Region

#Region "Function"
    Private Sub MAIN_JOB01()
        Try
            If ISUD1311A_F1.Link_ISUD1311A_F1(1, "000000000", Me.Name) = False Then Exit Sub
            Call DATA_SEARCH_VS1()
        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB01!", vbCritical)
        End Try

    End Sub

    Private Sub MAIN_JOB02()
        Dim OrderNo As String
        Try
            If getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

            OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)

            If ISUD1311A_F1.Link_ISUD1311A_F1(2, OrderNo, Me.Name) = False Then Exit Sub

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB02!", vbCritical)
        End Try
    End Sub

    Private Sub MAIN_JOB03()
        Dim OrderNo As String
        Try
            If getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
            OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)

            If ISUD1311A_F1.Link_ISUD1311A_F1(3, OrderNo, Me.Name) = False Then Exit Sub
            Call DATA_SEARCH_VS1()
        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB03!", vbCritical)
        End Try
    End Sub

    Private Sub MAIN_JOB04()
        Dim OrderNo As String
        Try
            If getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
            OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)

            If ISUD1311A_F1.Link_ISUD1311A_F1(4, OrderNo, Me.Name) = False Then Exit Sub
            Call DATA_SEARCH_VS1()
        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB04!", vbCritical)
        End Try
    End Sub


    Private Sub KEY_COUNT()

        Dim YRNO As Integer
        YRNO = Mid(System_Date_8(), 3, 4)

        Try
            SQL = "SELECT MAX(CAST(SUBSTRING(K1311_OrderNo,7,3) AS DECIMAL)) AS MAX_MCODE FROM PFK1311 "
            SQL = SQL & " WHERE SUBSTRING(K1311_OrderNo,3,4) = '" & YRNO.ToString & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W1311.OrderNo = "SO" & YRNO & "001"
            Else
                W1311.OrderNo = "SO" & YRNO & FormatP(CInt(rd!MAX_MCODE + 1), "000")
            End If

            rd.Close()
        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

    Private Sub MAIN_JOB05()
        'Exit Sub ' 2019/11/12 Sales Manager Approval MỞ LẠI 2019/12/18

        Dim OrderNo As String
        Dim OrderNoSeq As String
        Try
            If getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
            If getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
            OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
            OrderNoSeq = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex)

            If ISUD1311P.Link_ISUD1311P(3, OrderNo, OrderNoSeq, Me.Name) = False Then Exit Sub
            Call DATA_SEARCH_VS1()
        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB05!", vbCritical)
        End Try
    End Sub

    Private Sub MAIN_JOB06()
        'Exit Sub ' 2019/11/12 Sales Manager Approval

        Dim OrderNo As String
        Dim OrderNoSeq As String
        Try
            If getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
            If getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
            OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
            OrderNoSeq = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex)

            If ISUD1311P.Link_ISUD1311P(4, OrderNo, OrderNoSeq, Me.Name) = False Then Exit Sub
            Call DATA_SEARCH_VS1()
        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB06!", vbCritical)
        End Try

    End Sub

    Private Sub MAIN_JOB08()
        Dim OrderNo As String
        Dim OrderNoSeq As String
        Dim OrderNoNew As String

        Try
            If getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
            If getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
            OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
            OrderNoSeq = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex)

            Call KEY_COUNT()
            OrderNoNew = W1311.OrderNo

            Dim StrMsg As String = MsgBox("Do you want to make a COPY of 1 ORDER-LINE?", vbYesNo)
            If StrMsg <> vbYes Then Exit Sub
            Dim Starting = New DevExpress.Utils.WaitDialogForm("Loading confirm process!", "PSM")

            If PrcExe("USP_PFK1311_COPY_ITEM_MASTER_LINE", cn, OrderNoNew, OrderNo, OrderNoSeq, Pub.SAW) Then
                Starting.close()

                If ISUD1311A_F1.Link_ISUD1311A_F1(3, OrderNoNew, Me.Name, True) = False Then Exit Sub
                Call DATA_SEARCH_VS1()

            End If

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB05!", vbCritical)
        End Try

    End Sub

    Private Sub MAIN_JOB09()
        Dim OrderNo As String
        Dim OrderNoSeq As String
        Dim OrderNoNew As String

        Try
            If getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
            If getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
            OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
            OrderNoSeq = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex)

            Call KEY_COUNT()
            OrderNoNew = W1311.OrderNo

            Dim StrMsg As String = MsgBox("Do you want to make a COPY of ORDERS?", vbYesNo)
            If StrMsg <> vbYes Then Exit Sub
            Dim Starting = New DevExpress.Utils.WaitDialogForm("Loading confirm process!", "PSM")

            If PrcExe("USP_PFK1311_COPY_ITEM_MASTER", cn, OrderNoNew, OrderNo, Pub.SAW) Then
                Starting.close()

                If ISUD1311A_F1.Link_ISUD1311A_F1(3, OrderNoNew, Me.Name, True) = False Then Exit Sub
                Call DATA_SEARCH_VS1()

            End If

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB05!", vbCritical)
        End Try
    End Sub

    Private Sub MAIN_JOB10()
        Dim OrderNo As String
        Dim OrderNoSeq As String

        Try
            If getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
            If getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

            OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
            OrderNoSeq = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex)


        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB05!", vbCritical)
        End Try
    End Sub


    Private Sub MAIN_JOB11()
        Dim ItemCodeFIN As String
        Dim OrderNo As String
        Dim OrderNoSeq As String

        Try
            OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
            OrderNoSeq = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex)


            If READ_PFK1312(OrderNo, OrderNoSeq) Then
                If READ_PFK7108_SHOESCODE(D1312.ShoesCode) Then
                    If ISUD1310A.Link_ISUD1310A(3, D7108.GroupComponentBOM, OrderNo, OrderNoSeq, Me.Name) Then Exit Sub
                End If

            End If

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB05!", vbCritical)
        End Try
    End Sub

    Private Sub MAIN_JOB13()
        Dim OrderNo As String
        Try
            If getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
            OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)

            If ISUD1311A_F1.Link_ISUD1311A_F1(5, OrderNo, Me.Name) = False Then Exit Sub
            Call DATA_SEARCH_VS1()
        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB03!", vbCritical)
        End Try
    End Sub


    Private Sub MAIN_JOB14()
        Dim OrderNo As String

        If MsgBoxPPW("Please type the password to modify!", const_pwSALESRevise) = False Then Exit Sub

        Try
            If getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
            OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)

            If ISUD1311A_F1.Link_ISUD1311A_F1(6, OrderNo, Me.Name) = False Then Exit Sub
            Call DATA_SEARCH_VS1()
        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB03!", vbCritical)
        End Try
    End Sub

    Private Sub MAIN_JOB15()
        Dim OrderNo As String

        Try
            If getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
            OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)

            If ISUD1311K.Link_ISUD1311K(3, OrderNo, Me.Name) = False Then Exit Sub
            Call DATA_SEARCH_VS1()
        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB03!", vbCritical)
        End Try
    End Sub
#End Region

#Region "Data_search"
    Public Function DATA_SEARCH_HEAD_vs_Season() As Boolean
        DATA_SEARCH_HEAD_vs_Season = False

        Try
            DS1 = PrcDS("USP_PFP13123_SEARCH_VS_SEASON", cn, ListCode("Season"))
            SPR_PRO_NEW(vs_Season, DS1, "USP_PFP13123_SEARCH_VS_SEASON", "vs_Season")

            DS1 = Nothing
            DATA_SEARCH_HEAD_vs_Season = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Public Function DATA_SEARCH_HEAD_vS_Line() As Boolean
        DATA_SEARCH_HEAD_vS_Line = False
        Dim cdSeason As String

        cdSeason = getData(vs_Season, getColumIndex(vs_Season, "KEY_cdSeason"), vs_Season.ActiveSheet.ActiveRowIndex)

        Try
            DS1 = PrcDS("USP_PFP13123_SEARCH_VS_LINE", cn, cdSeason, ssp_WHERE.gData_CustomerName, ssp_WHERE.gData_SDate,
                                                       ssp_WHERE.gData_EDate, ssp_WHERE.gData_CheckRequest)
            SPR_PRO_NEW(vS_Line, DS1, "USP_PFP13123_SEARCH_VS_LINE", "vS_Line")

            DATA_SEARCH_HEAD_vS_Line = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Private Function DATA_SEARCH_VS1(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS1 = False

        Vs1.Enabled = False


        Try
            If chk_Total.Checked Then
                DS1 = PrcDS("USP_PFP13123_SEARCH_VS1_GROUPBASE", cn, ssp_WHERE.gData_SDate,
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
                    SPR_PRO_NEW(Vs1, DS1, "USP_PFP13123_SEARCH_VS1_GROUPBASE", "Vs1")
                    Vs1.ActiveSheet.RowCount = 0
                    Vs1.Enabled = True
                    Exit Function
                End If

                SPR_PRO_NEW(Vs1, DS1, "USP_PFP13123_SEARCH_VS1_GROUPBASE", "Vs1")
                DATA_SEARCH_VS1 = True

                Vs1.Enabled = True

            Else
                DS1 = PrcDS("USP_PFP13123_SEARCH_VS1", cn, ssp_WHERE.gData_SDate,
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
                    SPR_PRO_NEW(Vs1, DS1, "USP_PFP13123_SEARCH_VS1", "Vs1")
                    Vs1.ActiveSheet.RowCount = 0
                    Vs1.Enabled = True
                    Exit Function
                End If

                SPR_PRO_NEW(Vs1, DS1, "USP_PFP13123_SEARCH_VS1", "Vs1")
                DATA_SEARCH_VS1 = True

                Vs1.Enabled = True

            End If



        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try

    End Function

    Private Function DATA_SEARCH_vS2(ByVal OrderNo As String) As Boolean
        DATA_SEARCH_vS2 = False
        vS2.Enabled = False

        If chk_MaterialList.Checked = True Then Call DATA_SEARCH_VS2_MATERIAL() : Exit Function

        Try
            DS1 = PrcDS("USP_PFP13123_SEARCH_vS2", cn, OrderNo)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS2, DS1, "USP_PFP13123_SEARCH_vS2", "vS2")
                vS2.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS2, DS1, "USP_PFP13123_SEARCH_vS2", "vS2")
            Call VsSizeRange(vS2, "USP_ISU1311A_SEARCH_VS20_HEAD", OrderNo)

            DATA_SEARCH_vS2 = True

            vS2.Enabled = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_vS2")
        End Try

    End Function

    Private Function DATA_SEARCH_VS2_MATERIAL() As Boolean
        DATA_SEARCH_VS2_MATERIAL = False
        vS2.Enabled = False
        Dim KEY_OrderNo As String
        Dim KEY_OrderNoSeq As String

        KEY_OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
        KEY_OrderNoSeq = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex)


        Try
            DS1 = PrcDS("USP_PFP13123_SEARCH_vS2_SPECNO_SPECSEQ_F2", cn, KEY_OrderNo, KEY_OrderNoSeq)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS2, DS1, "USP_PFP13123_SEARCH_vS2_SPECNO_SPECSEQ_F2", "vS2")
                vS2.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS2, DS1, "USP_PFP13123_SEARCH_vS2_SPECNO_SPECSEQ_F2", "vS2")

            DATA_SEARCH_VS2_MATERIAL = True

            vS2.Enabled = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_vS2")
        End Try

    End Function

#End Region

#Region "Event"
  
    Private Sub vs_Season_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vs_Season.CellDoubleClick
        ssp_WHERE.gData_CustomerName = ""
        ssp_WHERE.gData_Line = ""
        ssp_WHERE.gData_SpecState = ""

        Call DATA_SEARCH_HEAD_vS_Line()
        Vs1.ActiveSheet.RowCount = 0
        vS2.ActiveSheet.RowCount = 0
    End Sub
    Private Sub vS_Line_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS_Line.CellDoubleClick
        Call DATA_SEARCH_VS1()
        If Vs1.ActiveSheet.RowCount > 1 Then Call DATA_SEARCH_vS2(getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), 1))
    End Sub

    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        Dim OrderNo As String

        OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
        Call DATA_SEARCH_vS2(OrderNo)
    End Sub

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
        Try

            chk_FSEL.CheckState = 0
            chk_FSEL.BackColor = clrUncheck
            chk_FSEL.ForeColor = Color.Black

            chk_FSEL.Text = WordConv("OPEN")
            ssp_WHERE.Visible = False

            Call DATA_SEARCH_HEAD_vs_Season()
            Call DATA_SEARCH_HEAD_vS_Line()
            Call DATA_SEARCH_VS1()

            If Vs1.ActiveSheet.RowCount > 1 Then Call DATA_SEARCH_vS2(getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), 1))

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Cms_1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_1.ItemClicked
        Try

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

            ElseIf Cms_1.Items(5).Selected = True Then
                Cms_1.Hide()
                MAIN_JOB05()

            ElseIf Cms_1.Items(6).Selected = True Then
                Cms_1.Hide()
                MAIN_JOB06()

            ElseIf Cms_1.Items(8).Selected = True Then
                Cms_1.Hide()
                MAIN_JOB08()

            ElseIf Cms_1.Items(9).Selected = True Then
                Cms_1.Hide()
                MAIN_JOB09()

            ElseIf Cms_1.Items(11).Selected = True Then
                Cms_1.Hide()
                MAIN_JOB13()

            ElseIf Cms_1.Items(12).Selected = True Then
                Cms_1.Hide()
                MAIN_JOB14()

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub vs_GotFocus(sender As Object, e As EventArgs) Handles vs_Season.GotFocus, vS_Line.GotFocus, Vs1.GotFocus
        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False
    End Sub

    Private Sub chk_Total_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Total.CheckedChanged


    End Sub
#End Region






End Class