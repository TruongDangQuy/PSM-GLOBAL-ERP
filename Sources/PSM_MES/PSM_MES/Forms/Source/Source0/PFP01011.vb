Public Class PFP01011

#Region "Variable"
    Private Dsu01 As Long
    Private wGCODE As String
    Protected prg As E_PRG
    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

        Call Cms_additem(Cms_1, _
                        "R&D ACCEPT PROCESSING - " & WordConv("INPUT") & "(F5)")

        vS20.ContextMenuStrip = Cms_1

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

        Call Cms_additem(Cms_2, _
                        "ORDER BASE ITEM CODE PROCESSING - " & WordConv("DELETE") & "(F5)")

        vS20.ContextMenuStrip = Cms_2

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
                Case Keys.F5 : Call MAIN_JOB00()
                Case Keys.F6 : Call MAIN_JOB01()
                Case Keys.F7 : Call MAIN_JOB02()
                Case Keys.F8 : Call MAIN_JOB03()
                Case Keys.F9 : Call MAIN_JOB04()
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
        ssp_WHERE.txt_SdateEdate.text1 = System_Date_6() & "01"
        ssp_WHERE.txt_SdateEdate.text2 = System_Date_8()

        Call Gadget_Load(ssp_WHERE, Me.Name)

        ssp_WHERE.Location = New Point(38, 110)
    End Sub
#End Region

#Region "Function"
    Private Sub MAIN_JOB00()
        Dim OrderNo As String
        Dim OrderNoSeq As String

        Try
            If getData(vS20, getColumIndex(vS20, "KEY_OrderNo"), vS20.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

            OrderNo = getData(vS20, getColumIndex(vS20, "KEY_OrderNo"), vS20.ActiveSheet.ActiveRowIndex)
            OrderNoSeq = getData(vS20, getColumIndex(vS20, "KEY_OrderNoSeq"), vS20.ActiveSheet.ActiveRowIndex)

            If ISUD1312B.Link_ISUD1312B(3, OrderNo, OrderNoSeq, Me.Name) = False Then Exit Sub

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB02!", vbCritical)
        End Try

    End Sub

    Private Sub MAIN_JOB01()
       
    End Sub

    Private Sub MAIN_JOB02()
       
    End Sub

    Private Sub MAIN_JOB03()
       
    End Sub

    Private Sub MAIN_JOB04()

    End Sub
    Private Sub MAIN_JOB05()
       

    End Sub

    Private Sub MAIN_JOB06()
       

    End Sub

    Private Sub MAIN_JOB07()
        
    End Sub

    Private Sub MAIN_JOB08()
      
    End Sub

    Private Sub MAIN_JOB09()
       
    End Sub
    Private Sub MAIN_JOB10()

    End Sub

    Private Sub MAIN_JOB11()

    End Sub


    Private Sub MAIN_JOB12()
       
    End Sub


    Private Sub MAIN_JOB13()
        
    End Sub


    Private Sub MAIN_JOB14()
        
    End Sub


    Private Sub MAIN_JOB15()
        Try


        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB04!", vbCritical)
        End Try
    End Sub


    Private Sub MAIN_JOB16()
       
    End Sub


    Private Sub MAIN_JOB17()
       
    End Sub

  
#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS10(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS10 = False

        Vs10.Enabled = False
        Try
            DS1 = PrcDS("USP_PFP01011_SEARCH_VS10", cn, ssp_WHERE.gData_SDate,
                                                       ssp_WHERE.gData_EDate,
                                                       ssp_WHERE.gData_chkGCodeCheck,
                                                       ssp_WHERE.gData_chkGCodeSQL,
                                                       ssp_WHERE.gData_chkGCodeData,
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
                SPR_PRO_NEW(Vs10, DS1, "USP_PFP01011_SEARCH_VS10", "vS10")
                Vs10.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs10, DS1, "USP_PFP01011_SEARCH_VS10", "vS10")
            DATA_SEARCH_VS10 = True

            Vs10.Enabled = True

        Catch ex As Exception

        End Try

    End Function

    Private Function DATA_SEARCH_VS20(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS20 = False

        VS20.Enabled = False
        Try
            DS1 = PrcDS("USP_PFP01011_SEARCH_VS20", cn, ssp_WHERE.gData_SDate,
                                                       ssp_WHERE.gData_EDate,
                                                       ssp_WHERE.gData_chkGCodeCheck,
                                                       ssp_WHERE.gData_chkGCodeSQL,
                                                       ssp_WHERE.gData_chkGCodeData,
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
                SPR_PRO_NEW(vS20, DS1, "USP_PFP01011_SEARCH_VS20", "VS20")
                vS20.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS20, DS1, "USP_PFP01011_SEARCH_VS20", "VS20")
            DATA_SEARCH_VS20 = True

            vS20.Enabled = True

        Catch ex As Exception

        End Try

    End Function

    Dim i As Integer

    Private Function DATA_SEARCH_VS30() As Boolean
        DATA_SEARCH_VS30 = False

        vS30.Enabled = False
        Try
            DS1 = PrcDS("USP_PFP01011_SEARCH_VS30", cn, ssp_WHERE.gData_SDate,
                                                       ssp_WHERE.gData_EDate,
                                                       ssp_WHERE.gData_chkGCodeCheck,
                                                       ssp_WHERE.gData_chkGCodeSQL,
                                                       ssp_WHERE.gData_chkGCodeData,
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
                SPR_PRO_NEW(vS30, DS1, "USP_PFP01011_SEARCH_VS30", "VS30")
                vS30.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS30, DS1, "USP_PFP01011_SEARCH_VS30", "VS30")
            DATA_SEARCH_VS30 = True

            vS30.Enabled = True

        Catch ex As Exception

        End Try

    End Function

    Private Function LINE_MOVE_DISPLAY01() As Boolean
        LINE_MOVE_DISPLAY01 = False

    End Function
    Private Function CustomerPurchasing_CHK() As String
        CustomerPurchasing_CHK = "1"
        Return CustomerPurchasing_CHK
    End Function

#End Region

#Region "Event"
    Private Sub tst_1_Click(sender As Object, e As EventArgs) Handles tst_1.Click, tst_2.Click, tst_3.Click, tst_4.Click, tst_5.Click, tst_6.Click
    
    End Sub

    Private Sub vS20_CellClick(sender As Object, e As CellClickEventArgs) Handles vS20.CellClick
        If e.Column = getColumIndex(vS20, "CheckUse") Then
            vS20.ActiveSheet.OperationMode = OperationMode.Normal
        Else
            vS20.ActiveSheet.OperationMode = OperationMode.SingleSelect
        End If
    End Sub

    Private Sub vS20_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS20.CellDoubleClick
        If DATA_SEARCH_VS30() Then
            ptc_1.SelectedIndex = 2
        End If
    End Sub


    Private Sub vS20_LostFocus(sender As Object, e As EventArgs) Handles vS20.LostFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False)
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

        If ptc_1.SelectedIndex = 0 Then Call DATA_SEARCH_VS10()
        If ptc_1.SelectedIndex = 1 Then Call DATA_SEARCH_VS20()
        If ptc_1.SelectedIndex = 2 Then Call DATA_SEARCH_VS30()
    End Sub
    Private Sub Cms_1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_1.ItemClicked
        If Cms_1.Items(0).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB00()

        End If

    End Sub
    Private Sub Cms_2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_2.ItemClicked
        If Cms_2.Items(0).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB00()
        End If

    End Sub

    Private Sub HLP8986A_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If ptc_1.TabCount < 1 Then Exit Sub
        If Me.Width > 30 Then
            ptc_1.ItemSize = New Size((Me.Width - 30) / ptc_1.TabCount, 25)
        End If
    End Sub

#End Region


End Class