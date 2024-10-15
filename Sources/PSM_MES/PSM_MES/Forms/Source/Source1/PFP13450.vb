Public Class PFP13450

#Region "Variable"
    Private Dsu01 As Long
    Private wGCODE As String
    Protected prg As E_PRG

    Private W1311 As T1311_AREA
    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

        Call Cms_additem(Cms_1, "CONVERT TO INVOICE CONTROL" & "(F5)")

        vS10.ContextMenuStrip = Cms_1


        vS20.ContextMenuStrip = Cms_2
        Call Cms_additem(Cms_2, _
                             "INVOICE CONTROL" & " - " & WordConv("INPUT") & "(F5)",
                             "INVOICE CONTROL" & " - " & WordConv("SEARCH") & "(F6)",
                             "INVOICE CONTROL" & " - " & WordConv("UPDATE") & "(F7)",
                             "INVOICE CONTROL" & " - " & WordConv("DELETE") & "(F8)")


        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

        Me.KeyPreview = True

        Call FORM_INIT()
        Call DATA_INIT()

    End Sub
    Private Sub Cms_2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_2.ItemClicked
        If Cms_2.Items(0).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB01()

        ElseIf Cms_2.Items(1).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB02()

        ElseIf Cms_2.Items(2).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB03()

        ElseIf Cms_2.Items(3).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB04()

        End If

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
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FORM_INIT()
        chk_FSEL.CheckState = 1
        chk_FSEL.BackColor = clrCheck
        chk_FSEL.ForeColor = Color.Black
        Me.chk_FormEnterkey = False

        chk_FSEL.Text = WordConv("CLOSE")
        ssp_WHERE.Visible = True

    End Sub

    Private Sub DATA_INIT()
        Call Gadget_Load(ssp_WHERE, Me.Name)
        SdateEdate.text1 = System_Date_6() & "01"
        SdateEdate.text2 = Function_Date_Add(FSDate(SdateEdate.text1), 1, -1)

    End Sub
#End Region

#Region "Function"
    Private Sub MAIN_JOB01()
        Dim ItemCodeFIN As String
        Dim OrderNo As String
        Dim OrderNoSeq As String

        If ptc_001.SelectedIndex <> 0 Then Exit Sub


        Try
            Dim i As Integer
            Dim SpecNoList As String
            Dim KEY_Autokey As String

            For i = 0 To vS10.ActiveSheet.RowCount - 1
                If getDataM(vS10, getColumIndex(vS10, "dchk"), i) <> "1" Then GoTo next1
                KEY_Autokey = getData(vS10, getColumIndex(vS10, "KEY_OrderNo"), i) & getData(vS10, getColumIndex(vS10, "KEY_OrderNoSeq"), i)

                SpecNoList = SpecNoList & "''" & KEY_Autokey & "''"
                SpecNoList = SpecNoList & ","
next1:
            Next


            If SpecNoList = "" Then Exit Sub
            SpecNoList = Strings.Left(SpecNoList, Len(SpecNoList) - 1)

            If ISUD3460A.Link_ISUD3460A_AUTO(11, "", 0, SpecNoList, Me.Name) = False Then Exit Sub

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB05!", vbCritical)
        End Try

    End Sub
    Private Sub MAIN_JOB02()
        Dim OrderNo As String
        Try
            If getData(vS20, getColumIndex(vS20, "Key_InvoiceNo"), vS20.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

            OrderNo = getData(vS20, getColumIndex(vS20, "Key_InvoiceNo"), vS20.ActiveSheet.ActiveRowIndex)

            If ISUD3460A.Link_ISUD3460A(2, OrderNo, Me.Name) = False Then Exit Sub

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB02!", vbCritical)
        End Try
    End Sub

    Private Sub MAIN_JOB03()
        Dim OrderNo As String
        Try
            If getData(vS20, getColumIndex(vS20, "Key_InvoiceNo"), vS20.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
            OrderNo = getData(vS20, getColumIndex(vS20, "Key_InvoiceNo"), vS20.ActiveSheet.ActiveRowIndex)

            If ISUD3460A.Link_ISUD3460A(3, OrderNo, Me.Name) = False Then Exit Sub
            Call DATA_SEARCH_Vs20()
        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB03!", vbCritical)
        End Try
    End Sub

    Private Sub MAIN_JOB04()
        Dim OrderNo As String
        Try
            If getData(vS20, getColumIndex(vS20, "Key_InvoiceNo"), vS20.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
            OrderNo = getData(vS20, getColumIndex(vS20, "Key_InvoiceNo"), vS20.ActiveSheet.ActiveRowIndex)

            If ISUD3460A.Link_ISUD3460A(4, OrderNo, Me.Name) = False Then Exit Sub
            Call DATA_SEARCH_Vs20()
        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB04!", vbCritical)
        End Try
    End Sub
#End Region

#Region "Data_search"

    Private Function DATA_SEARCH_Vs10(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_Vs10 = False

        Vs10.Enabled = False


        Try
            DS1 = PrcDS("USP_PFP13450_SEARCH_Vs10", cn, SdateEdate.text1, SdateEdate.text2, txt_cdSite.Code, txt_Article.Data, txt_CustPONO.Data)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs10, DS1, "USP_PFP13450_SEARCH_Vs10", "Vs10")

                Vs10.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs10, DS1, "USP_PFP13450_SEARCH_Vs10", "Vs10")
            DATA_SEARCH_Vs10 = True

            Vs10.Enabled = True




        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_Vs10")
        End Try

    End Function

    Private Function DATA_SEARCH_Vs20(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_Vs20 = False

        Vs20.Enabled = False


        Try
            DS1 = PrcDS("USP_PFP13450_SEARCH_Vs20", cn, SdateEdate.text1, SdateEdate.text2, txt_cdSite.Code, txt_Article.Data, txt_CustPONO.Data)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs20, DS1, "USP_PFP13450_SEARCH_Vs20", "Vs20")

                Vs20.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS20, DS1, "USP_PFP13450_SEARCH_Vs20", "Vs20")

            DATA_SEARCH_Vs20 = True

            Vs20.Enabled = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_Vs20")
        End Try

    End Function

    Private Function DATA_SEARCH_Vs30(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_Vs30 = False

        Vs30.Enabled = False


        Try
            DS1 = PrcDS("USP_PFP13450_SEARCH_Vs30", cn, txt_cdSite.Code, txt_Article.Data, txt_CustPONO.Data)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs30, DS1, "USP_PFP13450_SEARCH_Vs30", "Vs30")

                Vs30.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs30, DS1, "USP_PFP13450_SEARCH_Vs30", "Vs30")
            DATA_SEARCH_Vs30 = True

            Vs30.Enabled = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_Vs30")
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
            If ptc_001.SelectedIndex = 0 Then Call DATA_SEARCH_Vs10()
            If ptc_001.SelectedIndex = 1 Then Call DATA_SEARCH_Vs20()
            If ptc_001.SelectedIndex = 2 Then Call DATA_SEARCH_Vs30()



        Catch ex As Exception
            Call MsgBoxP("35", "cmd_SEARCH_Click")
        End Try
    End Sub
    Private Sub Cms_1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_1.ItemClicked
        Try

            If Cms_1.Items(0).Selected = True Then
                Cms_1.Hide()
                MAIN_JOB01()

            End If

        Catch ex As Exception
            Call MsgBoxP("35", "cmd_SEARCH_Click")
        End Try

    End Sub


    Private Sub vs_GotFocus(sender As Object, e As EventArgs) Handles vS10.GotFocus
        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False
    End Sub

    Private Sub chk_Total_CheckedChanged(sender As Object, e As EventArgs)


    End Sub
#End Region




    Private Sub vSChange(xROW As Integer)
        Try
           
            'Dim OrderNo As String = getData(Vs10, getColumIndex(Vs10, "OrderNo"), xROW)
            'Dim OrderNoSeq As String = getData(Vs10, getColumIndex(Vs10, "OrderNoSeq"), xROW)
            'Dim DateCL As String = FormatCut(getData(Vs10, getColumIndex(Vs10, "DateCL"), xROW))
            'Dim QtyOrder As String = getData(Vs10, getColumIndex(Vs10, "QtyOrder"), xROW)

            'Dim LicenseName As String = getData(Vs10, getColumIndex(Vs10, "LicenseName"), xROW)
            'Dim TestStandard As String = getData(Vs10, getColumIndex(Vs10, "TestStandard"), xROW)
            'Dim TestNo As String = getData(Vs10, getColumIndex(Vs10, "TestNo"), xROW)
            'Dim DateReport As String = FormatCut(getData(Vs10, getColumIndex(Vs10, "DateReport"), xROW))

            'Dim StrValue As String

            'StrValue = PrcExeNoError_Value("USP_PFK1312_UPDATE_FOB", cn, OrderNo, OrderNoSeq, DateCL, LicenseName, TestStandard, TestNo, DateReport, Pub.SAW, Pub.DAT)

            'setData(Vs10, getColumIndex(Vs10, "Result"), xROW, StrValue)



        Catch ex As Exception

        End Try
    End Sub
    Private Sub Vs10_Change(sender As Object, e As ChangeEventArgs) Handles vS10.Change
        Try
            Dim xROW As Integer

            xROW = e.Row

            vSChange(xROW)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Vs10_KeyDown(sender As Object, e As KeyEventArgs) Handles vS10.KeyDown
        Try
            Dim xROW As Integer
            If e.KeyCode = Keys.Enter Then

                xROW = Vs10.ActiveSheet.ActiveRowIndex

                vSChange(xROW)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class