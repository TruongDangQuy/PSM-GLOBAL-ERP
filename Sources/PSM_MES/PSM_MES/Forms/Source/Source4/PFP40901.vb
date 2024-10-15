Public Class PFP40901
#Region "Variable"
    Private Dsu01 As Long
    Private wGCODE As String
    Private Form_Close As Boolean
    Private SizeChk As Boolean = False

    Private W4090 As New T4090_AREA
#End Region

#Region "load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)

        Call Cms_additem(Cms_1, _
                   "CHECK COMPLETE - " & WordConv("INPUT") & "(F5)")


        Me.KeyPreview = True
        Call FORM_INIT()
        Call DATA_INIT()

    End Sub
    Private Sub PFP40901_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub
    Private Sub Function_Event(PressKey As Integer)
        Try
            Select Case PressKey
                Case Keys.F5 : Call MAIN_JOB06()
                Case Keys.F6 : Call MAIN_JOB11()
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FORM_INIT()
    End Sub

    Private Sub DATA_INIT()
        txt_DatePlan.Data = Pub.DAT
        txt_cdMainProcess.Code = "003"
    End Sub

#End Region

#Region "Link"

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


    Private Sub MAIN_JOB11()

    End Sub

    Private Sub MAIN_JOB12()

    End Sub

    Private Sub MAIN_JOB13()

    End Sub

    Private Sub MAIN_JOB14()

    End Sub


    Private Sub MAIN_JOB02_1()

    End Sub


    Private Sub MAIN_JOB03_1()

    End Sub

    Private Sub MAIN_JOB04_1()

    End Sub


#End Region

#Region "search"

    Public Function DATA_SEARCH_HEAD_vS0() As Boolean
        DATA_SEARCH_HEAD_vS0 = False

        Try
            DS1 = PrcDS("USP_PFP40901_SEARCH_vS0", cn, txt_DatePlan.Data, txt_cdFactory.Code, txt_cdMainProcess.Code)
            SPR_PRO_NEW(vs0, DS1, "USP_PFP40901_SEARCH_vS0", "vS0")

            DS1 = Nothing
            DATA_SEARCH_HEAD_vS0 = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Public Function DATA_SEARCH_HEAD_vS1() As Boolean
        DATA_SEARCH_HEAD_vS1 = False

        Dim cdLineProd As String
        cdLineProd = getData(vs0, getColumIndex(vs0, "cdLineProd"), vs0.ActiveSheet.ActiveRowIndex)

        Try
            DS1 = PrcDS("USP_PFP40901_SEARCH_vS1", cn, txt_DatePlan.Data, txt_cdFactory.Code, txt_cdMainProcess.Code, cdLineProd)
            SPR_PRO_NEW(vS1, DS1, "USP_PFP40901_SEARCH_vS1", "vS1")

            Psc_3.SplitterDistance = SPR_SHEETWIDHT(vS1) + cSprWidthSize

            DS1 = Nothing
            DATA_SEARCH_HEAD_vS1 = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Public Function DATA_SEARCH_HEAD_vS2() As Boolean
        DATA_SEARCH_HEAD_vS2 = False

        Dim cdLineProd As String
        Dim JobCard As String

        cdLineProd = getData(vS1, getColumIndex(vS1, "cdLineProd"), vS1.ActiveSheet.ActiveRowIndex)
        JobCard = getData(vS1, getColumIndex(vS1, "JobCard"), vS1.ActiveSheet.ActiveRowIndex)

        Try
            DS1 = PrcDS("USP_PFP40901_SEARCH_vS2", cn, txt_DatePlan.Data, txt_cdFactory.Code, txt_cdMainProcess.Code, cdLineProd, JobCard)
            SPR_PRO_NEW(vS2, DS1, "USP_PFP40901_SEARCH_vS2", "vS2")

            Psc_2.SplitterDistance = SPR_SHEETWIDHT(vS1) + SPR_SHEETWIDHT(vS2) + cSprWidthSize + cSprWidthSize
            Psc_3.SplitterDistance = SPR_SHEETWIDHT(vS1) + cSprWidthSize

            DS1 = Nothing
            DATA_SEARCH_HEAD_vS2 = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function


    Public Function DATA_SEARCH_HEAD_vs3() As Boolean
        DATA_SEARCH_HEAD_vs3 = False

        Dim cdLineProd As String
        Dim JobCard As String
        Dim Sizename As String

        cdLineProd = getData(vS2, getColumIndex(vS2, "cdLineProd"), vS2.ActiveSheet.ActiveRowIndex)
        JobCard = getData(vS2, getColumIndex(vS2, "JobCard"), vS2.ActiveSheet.ActiveRowIndex)
        Sizename = getData(vS2, getColumIndex(vS2, "Sizename"), vS2.ActiveSheet.ActiveRowIndex)

        Try
            DS1 = PrcDS("USP_PFP40901_SEARCH_vs3", cn, txt_DatePlan.Data, txt_cdFactory.Code, txt_cdMainProcess.Code, cdLineProd, JobCard, Sizename)
            SPR_PRO_NEW_BARCODE(vs3, DS1, "USP_PFP40901_SEARCH_vs3", "vs3")

            DS1 = Nothing
            DATA_SEARCH_HEAD_vs3 = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function


    Private Sub vS0_CellClick(sender As Object, e As CellClickEventArgs) Handles vs0.CellClick

        vS1.ActiveSheet.RowCount = 0
        vS2.ActiveSheet.RowCount = 0
        vs3.ActiveSheet.RowCount = 0

        Call DATA_SEARCH_HEAD_vS1()

    End Sub
    Private Sub vS1_CellClick(sender As Object, e As CellClickEventArgs) Handles vS1.CellClick

        vS2.ActiveSheet.RowCount = 0
        vs3.ActiveSheet.RowCount = 0

        Call DATA_SEARCH_HEAD_vS2()

    End Sub
    Private Sub vS2_CellClick(sender As Object, e As CellClickEventArgs) Handles vS2.CellClick

        vs3.ActiveSheet.RowCount = 0

        Call DATA_SEARCH_HEAD_vs3()
    End Sub

    Private Sub vs3_CellClick(sender As Object, e As CellClickEventArgs) Handles vs3.CellDoubleClick
        Dim SpecNo As String
        Dim SpecNoseq As String

        SpecNo = getData(sender, getColumIndex(sender, "KEY_SpecNo"), e.Row)
        SpecNoseq = getData(sender, getColumIndex(sender, "KEY_SpecNoseq"), e.Row)

    End Sub


#End Region

#Region "Function"
    Private Function Date_Check() As Boolean
        Date_Check = False
    End Function

    Private Function CustomerPurchasing_CHK() As String
        CustomerPurchasing_CHK = "1"
        Return CustomerPurchasing_CHK
    End Function

#End Region

#Region "Event"
    Private Sub Cms_1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_1.ItemClicked
        If Cms_1.Items(0).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB01()
        End If
    End Sub

    Private Sub tst_1_Click(sender As Object, e As EventArgs) Handles tst_1.Click, tst_2.Click, tst_3.Click, tst_4.Click, tst_5.Click, tst_6.Click
        If sender.Equals(tst_1) Then
            MAIN_JOB01()
        End If
        If sender.Equals(tst_2) Then
            MAIN_JOB11()
        End If
        If sender.Equals(tst_3) Then
            MAIN_JOB02()
        End If
        If sender.Equals(tst_4) Then
            MAIN_JOB02()
        End If

    End Sub

    Private Sub vS1_GotFocus(sender As Object, e As EventArgs)

        'Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False, WordConv("INPUT") & "(F5)", WordConv("SEARCH") & "(F6)", WordConv("CHANGE") & "(F7)", WordConv("DELETE") & "(F8)")

    End Sub
    Private Sub txt_GNAME_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Enter : cmd_SEARCH.Focus()
        End Select
    End Sub
    Private Sub vS1_LostFocus(sender As Object, e As EventArgs)

        'Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False, WordConv("INPUT") & "(F5)")

    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click

        Call DATA_SEARCH_HEAD_vS0()

    End Sub

    Private Sub vs3_KeyDown(sender As Object, e As KeyEventArgs) Handles vs3.KeyDown

        If e.KeyCode <> Keys.Delete Then Exit Sub

        If MsgBoxPPW("Please type the password to DELETE!", const_pwDeleteBC) = False Then Exit Sub

        If txt_DatePlan.Data <> Pub.DAT Then
            MsgBoxP("Can not edit because of not today!")
            If MsgBoxPPW("Please type the password to modify!", const_pwRnD) = False Then Exit Sub
        End If

        Dim xROW As Integer

        xROW = vs3.ActiveSheet.ActiveRowIndex

        Dim KEY_ProdDate As String
        Dim KEY_ProdSeq As String
        Dim Szno As String
        Dim Sno As String
        Dim batchNo As String

        KEY_ProdDate = getData(vs3, getColumIndex(vs3, "KEY_ProdDate"), vs3.ActiveSheet.ActiveRowIndex)
        KEY_ProdSeq = getData(vs3, getColumIndex(vs3, "KEY_ProdSeq"), vs3.ActiveSheet.ActiveRowIndex)
        Szno = getData(vs3, getColumIndex(vs3, "Key_Szno"), vs3.ActiveSheet.ActiveRowIndex)
        Sno = getData(vs3, getColumIndex(vs3, "Key_Sno"), vs3.ActiveSheet.ActiveRowIndex)

        batchNo = getData(vs3, getColumIndex(vs3, "BatchNo"), vs3.ActiveSheet.ActiveRowIndex)


        If READ_PFK4090(KEY_ProdDate, KEY_ProdSeq) = True Then
            W4090 = D4090

            D9700_CLEAR()
            D9700.ActionName = "DELETE FROM PFK4090 " & KEY_ProdDate & "-" & KEY_ProdSeq

            D9700.DateCreate = Pub.DAT
            D9700.UserCode = Pub.SAW
            D9700.FormName = Me.FindForm.Name

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

            If DELETE_PFK4090(W4090) Then
                SPR_DEL(vs3, 0, xROW)
            End If

        End If



    End Sub
#End Region





  
End Class