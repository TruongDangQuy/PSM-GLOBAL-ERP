Public Class PFP13500

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

        Call Cms_additem(Cms_1, "CONVERT TO WIP CONTROL" & "(F5)",
                                "ADD TO OLD WIP " & "(F6)")

        vS10.ContextMenuStrip = Cms_1


        vS20.ContextMenuStrip = Cms_2
        Call Cms_additem(Cms_2, _
                             "WIP CONTROL" & " - " & WordConv("INPUT") & "(F5)",
                             "WIP CONTROL" & " - " & WordConv("SEARCH") & "(F6)",
                             "WIP CONTROL" & " - " & WordConv("UPDATE") & "(F7)",
                             "WIP CONTROL" & " - " & WordConv("DELETE") & "(F8)")


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
        SdateEdate.text1 = Strings.Left(Pub.DAT, 6) & "01"

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

            If ISUD3490A.Link_ISUD3490A_AUTO(11, "", 0, SpecNoList, Me.Name) = False Then Exit Sub

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB05!", vbCritical)
        End Try

    End Sub

    Private Sub MAIN_JOB05()
        Dim ItemCodeFIN As String
        Dim OrderNo As String
        Dim OrderNoSeq As String
        Dim KEY_Autokey As String

        If ptc_001.SelectedIndex <> 0 Then Exit Sub


        Try
            Dim i As Integer
            Dim SpecNoList As String
            Dim KEY_OrderNo As String
            Dim KEY_OrderNoSeq As String
            Dim InvoiceNo As String
            'later 2022/03/03
            '            If HLP3490.Link_HLP3490Material = True Then
            '                InvoiceNo = hlp0000SeVaTt
            '                For i = 0 To vS10.ActiveSheet.RowCount - 1
            '                    If getDataM(vS10, getColumIndex(vS10, "dchk"), i) <> "1" Then GoTo next1
            '                    KEY_Autokey = getData(vS10, getColumIndex(vS10, "KEY_OrderNo"), i) & getData(vS10, getColumIndex(vS10, "KEY_OrderNoSeq"), i)

            '                    SpecNoList = SpecNoList & "''" & KEY_Autokey & "''"
            '                    SpecNoList = SpecNoList & ","
            'next1:
            '                Next


            '                If SpecNoList = "" Then Exit Sub
            '                SpecNoList = Strings.Left(SpecNoList, Len(SpecNoList) - 1)
            '                If ISUD3490A.Link_ISUD3490A_AUTO(12, InvoiceNo, 0, SpecNoList, Me.Name) = False Then Exit Sub
            '            End If





        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB05!", vbCritical)
        End Try

    End Sub

    Private Sub MAIN_JOB02()
        Dim OrderNo As String
        Try
            If getData(vS20, getColumIndex(vS20, "Key_WIPNo"), vS20.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

            OrderNo = getData(vS20, getColumIndex(vS20, "Key_WIPNo"), vS20.ActiveSheet.ActiveRowIndex)

            If ISUD3490A.Link_ISUD3490A(2, OrderNo, Me.Name) = False Then Exit Sub

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB02!", vbCritical)
        End Try
    End Sub

    Private Sub MAIN_JOB03()
        Dim OrderNo As String
        Try
            If getData(vS20, getColumIndex(vS20, "Key_WIPNo"), vS20.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
            OrderNo = getData(vS20, getColumIndex(vS20, "Key_WIPNo"), vS20.ActiveSheet.ActiveRowIndex)

            If ISUD3490A.Link_ISUD3490A(3, OrderNo, Me.Name) = False Then Exit Sub
            Call DATA_SEARCH_Vs20()
        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB03!", vbCritical)
        End Try
    End Sub

    Private Sub MAIN_JOB04()
        Dim OrderNo As String
        Try
            If getData(vS20, getColumIndex(vS20, "Key_WIPNo"), vS20.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
            OrderNo = getData(vS20, getColumIndex(vS20, "Key_WIPNo"), vS20.ActiveSheet.ActiveRowIndex)

            If ISUD3490A.Link_ISUD3490A(4, OrderNo, Me.Name) = False Then Exit Sub
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
            DS1 = PrcDS("USP_PFP13500_SEARCH_Vs10", cn, txt_cdSite.Code, txt_Article.Data, txt_CustPONO.Data, txt_cdStatusExport.Code, txt_Year.Value.ToString("0000") & "1231")


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs10, DS1, "USP_PFP13500_SEARCH_Vs10", "Vs10")

                Vs10.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs10, DS1, "USP_PFP13500_SEARCH_Vs10", "Vs10")
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
            DS1 = PrcDS("USP_PFP13500_SEARCH_Vs20", cn, txt_cdSite.Code, txt_Article.Data, txt_CustPONO.Data, txt_InvoiceNo.Data, txt_cdStatusExport.Code, SdateEdate.text1, SdateEdate.text2)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs20, DS1, "USP_PFP13500_SEARCH_Vs20", "Vs20")

                Vs20.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS20, DS1, "USP_PFP13500_SEARCH_Vs20", "Vs20")

            If chk_TradingExportColor Then
                Dim i As Integer
                Dim Xcol As Integer = getColumIndex(vS20, "CheckStatus_TD")
                Dim XcolsEL As Integer = getColumIndex(vS20, "CheckStatus_TD_Sel")
                DS3 = PrcDS("USP_HLP7171_LISTCOLOR", cn, ListCode("StatusExport"))
                For i = 0 To vS20.ActiveSheet.RowCount - 1
                    SPR_BACKCOLORCELL(vS20, FUNCTION_TRADING_BACK(getData(vS20, Xcol, i)), XcolsEL, i)
                Next
            End If


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
            DS1 = PrcDS("USP_PFP13500_SEARCH_Vs30", cn, txt_cdSite.Code, txt_Article.Data, txt_CustPONO.Data, txt_InvoiceNo.Data, SdateEdate.text1, SdateEdate.text2)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs30, DS1, "USP_PFP13500_SEARCH_Vs30", "Vs30")

                Vs30.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS30, DS1, "USP_PFP13500_SEARCH_Vs30", "Vs30")

           


            DATA_SEARCH_Vs30 = True

            Vs30.Enabled = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_Vs30")
        End Try

    End Function

    Private Function DATA_SEARCH_Vs40(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_Vs40 = False

        Vs40.Enabled = False


        Try
            DS1 = PrcDS("USP_PFP13500_SEARCH_Vs40", cn, txt_cdSite.Code, txt_Article.Data, txt_CustPONO.Data, SdateEdate.text1, SdateEdate.text2)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs40, DS1, "USP_PFP13500_SEARCH_Vs40", "Vs40")

                Vs40.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs40, DS1, "USP_PFP13500_SEARCH_Vs40", "Vs40")
            DATA_SEARCH_Vs40 = True

            Vs40.Enabled = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_Vs40")
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
            If ptc_001.SelectedIndex = 3 Then Call DATA_SEARCH_Vs40()


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
            If Cms_1.Items(1).Selected = True Then
                Cms_1.Hide()
                MAIN_JOB05()

            End If


        Catch ex As Exception
            Call MsgBoxP("35", "cmd_SEARCH_Click")
        End Try

    End Sub

    Private Sub vS10_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS10.CellDoubleClick
        Try


            Dim KEY_OrderNo As String
            Dim KEY_OrderNoSeq As String


            If e.Column = getColumIndex(vS10, "RemarkTrading") Then




                Dim str As String = MsgBoxP("Do you want to update remark it?", vbYesNo)
                If str <> vbYes Then Exit Sub


                str = InputBox("Please remark trading !")


                For i As Integer = 0 To vS10.ActiveSheet.RowCount - 1
                    KEY_OrderNo = getData(vS10, getColumIndex(vS10, "KEY_OrderNo"), i)
                    KEY_OrderNoSeq = getData(vS10, getColumIndex(vS10, "KEY_OrderNoSeq"), i)

                    If READ_PFK1312(KEY_OrderNo, KEY_OrderNoSeq) = False Then GoTo next1
                    If getDataM(vS10, getColumIndex(vS10, "dchk"), i) <> "1" Then GoTo next1

                    Dim StrValue As String



                    StrValue = PrcExeNoError_ValueVN("USP_PFK3490_UPDATE_PFK1312_REMARK_TRADING", cn, KEY_OrderNo, KEY_OrderNoSeq, "*" & str)

                    setData(vS10, getColumIndex(vS10, "RemarkTrading"), i, str)
                    MdiMenu.lbl_Status1.Text = StrValue
                    MdiMenu.lbl_Status1.ForeColor = Color.Blue

next1:
                Next

            End If
        Catch ex As Exception

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
            If chk_AutoSave.Checked = False Then Exit Sub

            Dim SONo As String = getData(vS30, getColumIndex(vS30, "SONo"), xROW)
            Dim BookingNo As String = getData(vS30, getColumIndex(vS30, "BookingNo"), xROW)
            Dim DateEXFac As String = FormatCut(getData(vS30, getColumIndex(vS30, "DateEXFac"), xROW))
            Dim DateETD As String = FormatCut(getData(vS30, getColumIndex(vS30, "DateETD"), xROW))
            Dim DateETA As String = FormatCut(getData(vS30, getColumIndex(vS30, "DateETA"), xROW))

            Dim ChkDocsBuyer As String = getData(vS30, getColumIndex(vS30, "ChkDocsBuyer"), xROW)
            Dim ChkDocsHK As String = getData(vS30, getColumIndex(vS30, "ChkDocsHK"), xROW)
            Dim ChkLocalCharge As String = getData(vS30, getColumIndex(vS30, "ChkLocalCharge"), xROW)
            Dim ChkSMDocs As String = getData(vS30, getColumIndex(vS30, "ChkSMDocs"), xROW)
            Dim ChkUploadDocs As String = getData(vS30, getColumIndex(vS30, "ChkUploadDocs"), xROW)
            Dim ShipmentType As String = getData(vS30, getColumIndex(vS30, "ShipmentType"), xROW)
            Dim BLNo As String = getData(vS30, getColumIndex(vS30, "BLNo"), xROW)
            Dim VesselName As String = getData(vS30, getColumIndex(vS30, "VesselName"), xROW)

            Dim InvoiceNo As String = getData(vS30, getColumIndex(vS30, "Key_WIPNo"), xROW)

            Dim ChkReceiveHK As String = getData(vS30, getColumIndex(vS30, "ChkReceiveHK"), xROW)
            Dim ChkPending As String = getData(vS30, getColumIndex(vS30, "ChkPending"), xROW)
            Dim DateDeclare As String = getData(vS30, getColumIndex(vS30, "DateDeclare"), xROW)
            Dim DateBL As String = getData(vS30, getColumIndex(vS30, "DateBL"), xROW)
            Dim Remark As String = getData(vS30, getColumIndex(vS30, "Remark"), xROW)

            Dim StrValue As String

            StrValue = PrcExeNoError_ValueVN("USP_PFK3490_UPDATE_INVOICENO", cn, InvoiceNo, _
                                           SONo, BookingNo, DateEXFac, DateETD, DateETA, _
                                            ChkDocsBuyer, ChkDocsHK, ChkLocalCharge, ChkSMDocs, ChkUploadDocs, _
                                            ShipmentType, BLNo, VesselName,
                                            ChkReceiveHK, ChkPending, DateDeclare, DateBL, "*" & Remark)

            MdiMenu.lbl_Status1.Text = StrValue
            MdiMenu.lbl_Status1.ForeColor = Color.Blue


        Catch ex As Exception

        End Try
    End Sub
    Private Sub vS30_Change(sender As Object, e As ChangeEventArgs) Handles vS30.Change
        Try
            Dim xROW As Integer

            xROW = e.Row

            vSChange(xROW)

            If getData(vS30, xROW, e.Column) <> "" Then
                SPR_BACKCOLORCELL(vS30, Color.Aqua, e.Column, e.Row)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub vS30_KeyDown(sender As Object, e As KeyEventArgs) Handles vS30.KeyDown
        Try
            Dim xROW As Integer
            If e.KeyCode = Keys.Enter Then

                xROW = vS30.ActiveSheet.ActiveRowIndex

                vSChange(xROW)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class