Public Class PFP30115

#Region "Variable"

    Private Dsu01 As Long     'Data Su
    Private wGCODE As String
    Private Form_Close As Boolean

    Private W1312 As New T1312_AREA
    Private L1312 As New T1312_AREA

    Private W1322 As New T1322_AREA
    Private L1322 As New T1322_AREA

#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim xISUD1311A As String = ISUD1311A.Text
        Dim xISUD7110K As String = ISUD7110K.Text
        Dim xISUD7106A As String = ISUD7106A.Text

        Me.KeyPreview = True

        Call Cms_additem(Cms_1, "MCO# PROCCESING - " & WordConv("ACCEPT") & "(F5)",
                                xISUD1311A & " - " & WordConv("SEARCH") & "(F6)",
                                xISUD7110K & " - " & WordConv("SEARCH") & "(F7)",
                                xISUD7106A & " - " & WordConv("SEARCH") & "(F8)")
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)


        Vs10.ContextMenuStrip = Cms_1

        Call Cms_additem(Cms_2, "-",
                                 xISUD1311A & " - " & WordConv("SEARCH") & "(F6)",
                                 xISUD7110K & " - " & WordConv("SEARCH") & "(F7)",
                                 xISUD7106A & " - " & WordConv("SEARCH") & "(F8)")

        Vs20.ContextMenuStrip = Cms_2

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
    End Sub

    Private Sub DATA_INIT()
       
    End Sub
#End Region

#Region "Function"
    Private Sub MAIN_JOB01()
        Try
            Dim i As Integer
            Dim ShoesCode As String
            Dim StrMsg As String

            Dim CheckValue As Boolean = False

            'Call READ_PFK7106(ShoesCode)
            'If FormatCutAll(READ_PFK7104_SZNO(D7106.SizeRange, D7106.SpeciticSize)) = "" Then MsgBoxP("Size Wrong!") : Exit Sub
            For i = 0 To Vs10.ActiveSheet.RowCount - 1

                If getDataM(Vs10, getColumIndex(Vs10, "dchk"), i) = "1" Then
                    ShoesCode = getData(Vs10, getColumIndex(Vs10, "ShoesCode"), i)
                    Call READ_PFK7106(ShoesCode)
                    If FormatCutAll(READ_PFK7104_SZNO(D7106.SizeRange, D7106.SpeciticSize)) = "" Then MsgBoxP("Size Wrong!") : Exit Sub

                    ' Jun add P.604 2019/03/26 11:27 AM
                    DS1 = PrcDS("USP_PFP30115_INSERT_CHECK_MCO", cn, ShoesCode)
                    If GetDsData(DS1, 0, 0).Trim <> "" Then MsgBoxP(GetDsData(DS1, 0, 0).ToString()) : Exit Sub
                    ' End Jun add P.604 2019/03/26 11:27 AM
                End If
            Next

            StrMsg = MsgBox("Quan trọng ! Vui lòng kiểm tra kỹ khi matching ! Hệ thống tự động tạo yêu cầu ! Important! Please check carefully !", vbYesNo)

            If StrMsg <> vbYes Then Exit Sub

            For i = 0 To Vs10.ActiveSheet.RowCount - 1

                If getDataM(Vs10, getColumIndex(Vs10, "dchk"), i) = "1" Then

                    ShoesCode = getData(Vs10, getColumIndex(Vs10, "ShoesCode"), i)
                    Call READ_PFK7106(ShoesCode)

                    If READ_PFK1312(getData(Vs10, getColumIndex(Vs10, "KEY_OrderNo"), i), getData(Vs10, getColumIndex(Vs10, "KEY_OrderNoSeq"), i)) Then
                        W1312 = D1312
                        W1312.SpeciticSize = D7106.SpeciticSize

                        Call READ_PFK7106(D1312.ShoesCode)

                        If READ_PFK7106_SHOESMATCHING(ShoesCode, D7106.ColorCode, D7106.ColorName) Then
                            W1312.AttachID = D7106.ShoesCode
                        Else
                            W1312.AttachID = ShoesCode
                        End If

                        W1312.DateSize = Pub.SAW

                        If REWRITE_PFK1312(W1312) = True Then
                            Call KEY_COUNT_K1322()

                            W1322.ShoesCode = W1312.ShoesCode
                            W1322.OrderNo = W1312.OrderNo
                            W1322.OrderNoSeq = W1312.OrderNoSeq

                            W1322.MatchingDate = Pub.DAT
                            W1322.MatchingTime = System_Date_time()

                            W1322.InchargeMatching = Pub.SAW

                            W1322.ShoesMatching = W1312.AttachID
                            W1322.QtyMatching = D1312.QtyOrder
                            W1322.SpeciticSize = D7106.SpeciticSize

                            Call WRITE_PFK1322(W1322)

                            Call PrcExeNoError("USP_PFK1322_ROW_NUMBER_F1", cn, W1322.ShoesCode, W1322.MatchingAutoKey)
                            Call PrcExeNoError("USP_PFK3011_ROW_NUMBER_F1", cn, W1312.OrderNo, W1312.OrderNoSeq, W1312.AttachID)
                            Call PrcExeNoError("USP_PFK3015_ROW_NUMBER_F1", cn, W1312.OrderNo, W1312.OrderNoSeq, W1312.AttachID)
                            Call PrcExeNoError("USP_PFK3018_ROW_NUMBER_F1", cn, W1312.OrderNo, W1312.OrderNoSeq, W1312.AttachID)

                        End If

                    End If

                End If
            Next

            'Me.Dispose()
        Catch ex As Exception
            MsgBoxP("cmd_OK_Click!", vbCritical)
        End Try

    End Sub

    Private Sub MAIN_JOB02()
        If ptc_1.SelectedIndex = 0 Then
            Dim OrderNo As String
            If getData(Vs10, getColumIndex(Vs10, "KEY_OrderNo"), Vs10.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

            OrderNo = getData(Vs10, getColumIndex(Vs10, "KEY_OrderNo"), Vs10.ActiveSheet.ActiveRowIndex)

            If ISUD1311A.Link_ISUD1311A(2, OrderNo, Me.Name) = False Then Exit Sub
        Else
            Dim OrderNo As String
            If getData(Vs20, getColumIndex(Vs20, "KEY_OrderNo"), Vs20.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

            OrderNo = getData(Vs20, getColumIndex(Vs20, "KEY_OrderNo"), Vs20.ActiveSheet.ActiveRowIndex)

            If ISUD1311A.Link_ISUD1311A(2, OrderNo, Me.Name) = False Then Exit Sub
        End If
      
    End Sub

    Private Sub MAIN_JOB03()
        If ptc_1.SelectedIndex = 0 Then
            Dim ShoesCode As String
            ShoesCode = getData(Vs10, getColumIndex(Vs10, "ShoesCode"), Vs10.ActiveSheet.ActiveRowIndex)

            If READ_PFK7106(ShoesCode) Then
                If ISUD7110K.Link_ISUD7110K(2, D7106.ShoesParent, Me.Name) = False Then Exit Sub

            End If
        Else
            Dim ShoesCode As String
            ShoesCode = getData(Vs20, getColumIndex(Vs20, "ShoesCode"), Vs20.ActiveSheet.ActiveRowIndex)

            If READ_PFK7106(ShoesCode) Then
                If ISUD7110K.Link_ISUD7110K(2, D7106.ShoesParent, Me.Name) = False Then Exit Sub

            End If
        End If


    End Sub

    Private Sub MAIN_JOB04()
        If ptc_1.SelectedIndex = 0 Then
            Dim ShoesCode As String
            ShoesCode = getData(Vs10, getColumIndex(Vs10, "ShoesCode"), Vs10.ActiveSheet.ActiveRowIndex)

            If ISUD7106A.Link_ISUD7106A(2, ShoesCode, Me.Name) = False Then Exit Sub
        Else
            Dim ShoesCode As String
            ShoesCode = getData(Vs20, getColumIndex(Vs20, "ShoesCode"), Vs20.ActiveSheet.ActiveRowIndex)

            If ISUD7106A.Link_ISUD7106A(2, ShoesCode, Me.Name) = False Then Exit Sub
        End If
    End Sub


    Private Sub MAIN_JOB05()

    End Sub

    Private Sub KEY_COUNT_K1322()
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        SQL = "SELECT MAX(CAST(K1322_MatchingAutoKey AS DECIMAL)) AS MAX_CODE FROM PFK1322 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            L1322.MatchingAutoKey = "00000001"
        Else
            L1322.MatchingAutoKey = Format(CInt(rd!MAX_CODE + 1), "00000000")
        End If

        W1322.MatchingAutoKey = L1322.MatchingAutoKey

        rd.Close()

    End Sub


#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS10(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS10 = False
        VS10.Enabled = False

        DS1 = PrcDS("USP_PFP30115_SEARCH_VS10", cn, txt_CustomerCode.Code, txt_cdSite.Code, txt_Line.Data, txt_Article.Data, txt_ColorName.Data, chk_CheckUse1.CheckState, chk_CheckUse2.CheckState)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs10, DS1, "USP_PFP30115_SEARCH_VS10", "VS10")
            VS10.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs10, DS1, "USP_PFP30115_SEARCH_VS10", "VS10")
        DATA_SEARCH_VS10 = True

        VS10.Enabled = True
    End Function

    Private Function DATA_SEARCH_VS11(ShoesCode As String, OrderNo As String, OrderNoSeq As String) As Boolean
        DATA_SEARCH_VS11 = False
        vS11.Enabled = False

        DS1 = PrcDS("USP_PFP30115_SEARCH_VS11", cn, ShoesCode, OrderNo, OrderNoSeq)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS11, DS1, "USP_PFP30115_SEARCH_VS11", "VS11")
            vS11.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS11, DS1, "USP_PFP30115_SEARCH_VS11", "VS11")
        DATA_SEARCH_VS11 = True

        vS11.Enabled = True
    End Function
    Private Function DATA_SEARCH_VS20(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS20 = False
        VS20.Enabled = False

        DS1 = PrcDS("USP_PFP30115_SEARCH_VS20", cn, txt_CustomerCode.Code, txt_cdSite.Code, txt_Line.Data, txt_Article.Data, txt_ColorName.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs20, DS1, "USP_PFP30115_SEARCH_VS20", "VS20")
            vS20.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs20, DS1, "USP_PFP30115_SEARCH_VS20", "VS20")
        DATA_SEARCH_VS20 = True

        vS20.Enabled = True
    End Function

    Private Function DATA_SEARCH_VS21(ShoesCode As String, OrderNo As String, OrderNoSeq As String) As Boolean
        DATA_SEARCH_VS21 = False
        VS21.Enabled = False

        DS1 = PrcDS("USP_PFP30115_SEARCH_VS21", cn, ShoesCode, OrderNo, OrderNoSeq)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs21, DS1, "USP_PFP30115_SEARCH_VS21", "VS21")
            VS21.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs21, DS1, "USP_PFP30115_SEARCH_VS21", "VS21")
        DATA_SEARCH_VS21 = True

        VS21.Enabled = True
    End Function
    Private Function LINE_MOVE_DISPLAY01() As Boolean
        LINE_MOVE_DISPLAY01 = False

        Dim cdFactory As String
        Dim cdMainProcess As String
        Dim cdLineProd As String
        Dim DatePlan As String

        cdFactory = getData(VS10, getColumIndex(VS10, "KEY_cdFactory"), VS10.ActiveSheet.ActiveRowIndex)
        cdMainProcess = getData(VS10, getColumIndex(VS10, "KEY_cdMainProcess"), VS10.ActiveSheet.ActiveRowIndex)
        DatePlan = getData(VS10, getColumIndex(VS10, "KEY_DatePlan"), VS10.ActiveSheet.ActiveRowIndex)
        cdLineProd = getData(VS10, getColumIndex(VS10, "KEY_cdLineProd"), VS10.ActiveSheet.ActiveRowIndex)

        Try
            DS1 = PrcDS("USP_PFP40799_SEARCH_VS10_LINE", cn, cdFactory, cdMainProcess, DatePlan, cdLineProd)

            If GetDsRc(DS1) = 0 Then
                VS10.Enabled = True
                Exit Function
            End If

            READ_SPREAD(VS10, DS1, "USP_PFP40799_SEARCH_VS10", "VS10", VS10.ActiveSheet.ActiveRowIndex)

            VS10.Enabled = True
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
            MAIN_JOB05()
        End If
    End Sub
    Private Sub VS10_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs10.CellClick
        If e.ColumnHeader = True Then Exit Sub
        VS10.ActiveSheet.ActiveColumnIndex = e.Column
        VS10.ActiveSheet.ActiveRowIndex = e.Row
        Vs10.ActiveSheet.AddSelection(e.Row, e.Column, 1, 1)

        If e.Column = getColumIndex(Vs10, "DCHK") Then
            Vs10.ActiveSheet.OperationMode = OperationMode.Normal
        Else
            Vs10.ActiveSheet.OperationMode = OperationMode.SingleSelect
        End If

    End Sub

    Private Sub VS10_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs10.CellDoubleClick
        If e.ColumnHeader = True Then Exit Sub
        Vs10.ActiveSheet.ActiveColumnIndex = e.Column
        Vs10.ActiveSheet.ActiveRowIndex = e.Row
        Vs10.ActiveSheet.AddSelection(e.Row, e.Column, 1, 1)

        If e.Column = getColumIndex(Vs10, "DCHK") Then
            Vs10.ActiveSheet.OperationMode = OperationMode.Normal
            Exit Sub
        Else
            Vs10.ActiveSheet.OperationMode = OperationMode.SingleSelect
        End If

        Dim ShoesCode As String
        Dim OrderNo As String
        Dim OrderNoSeq As String

        ShoesCode = getData(Vs10, getColumIndex(Vs10, "ShoesCode"), Vs10.ActiveSheet.ActiveRowIndex)
        OrderNo = getData(Vs10, getColumIndex(Vs10, "KEY_OrderNo"), Vs10.ActiveSheet.ActiveRowIndex)
        OrderNoSeq = getData(Vs10, getColumIndex(Vs10, "KEY_OrderNoSeq"), Vs10.ActiveSheet.ActiveRowIndex)

        Call DATA_SEARCH_VS11(ShoesCode, OrderNo, OrderNoSeq)

    End Sub

    Private Sub VS20_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs20.CellDoubleClick
        Dim ShoesCode As String
        Dim OrderNo As String
        Dim OrderNoSeq As String

        ShoesCode = getData(Vs20, getColumIndex(Vs20, "ShoesCode"), Vs20.ActiveSheet.ActiveRowIndex)
        OrderNo = getData(Vs20, getColumIndex(Vs20, "KEY_OrderNo"), Vs20.ActiveSheet.ActiveRowIndex)
        OrderNoSeq = getData(Vs20, getColumIndex(Vs20, "KEY_OrderNoSeq"), Vs20.ActiveSheet.ActiveRowIndex)

        Call DATA_SEARCH_VS21(ShoesCode, OrderNo, OrderNoSeq)

    End Sub

    Private Sub VS10_GotFocus(sender As Object, e As EventArgs) Handles Vs10.GotFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

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
    Private Sub VS10_LostFocus(sender As Object, e As EventArgs) Handles Vs10.LostFocus

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

        If ptc_1.SelectedIndex = 0 Then Call DATA_SEARCH_VS10()
        If ptc_1.SelectedIndex = 1 Then Call DATA_SEARCH_VS20()

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

        End If

    End Sub

    Private Sub Cms_2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_2.ItemClicked
        If Cms_2.Items(0).Selected = True Then
            Cms_2.Hide()
            '

        ElseIf Cms_2.Items(1).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB02()

        ElseIf Cms_2.Items(2).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB03()

        ElseIf Cms_2.Items(3).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB04()

        ElseIf Cms_2.Items(4).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB05()

        End If

    End Sub

    Private Sub Me_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Width > 20 Then
            ptc_1.ItemSize = New Size((Me.Width - 20) / 2, 30)
        End If
    End Sub

#End Region



End Class