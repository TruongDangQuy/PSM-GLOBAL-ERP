Public Class PFP94200

#Region "Variable"
    Private Dsu01 As Long
    Private wGCODE As String
    Protected prg As E_PRG

    Private W1311 As T1311_AREA
    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True

        Call FORM_INIT()
        Call DATA_INIT()

        Call Cms_additem(Cms_0, "INSERT TRANSFER VOUCHER" & "(F5)")


        vS10.ContextMenuStrip = Cms_0

        Call Cms_additem(Cms_1, "TRANSFER VOUCHER - RE-DATA" & "(F6)",
                                "TRANSFER VOUCHER - DELETE" & "(F7)",
                                "-",
                                "MAPPING LIQUIDATION VOUCHER - INSERT (F8)",
                                "MAPPING LIQUIDATION VOUCHER - DELETE (F9)")


        vS20.ContextMenuStrip = Cms_1

    End Sub
    Private Sub Cms_0_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_0.ItemClicked
        Try

            If Cms_0.Items(0).Selected = True Then
                Cms_0.Hide()
                MAIN_JOB01()
            End If


        Catch ex As Exception
            Call MsgBoxP("35", "cmd_SEARCH_Click")
        End Try

    End Sub

    Private Sub Cms_1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_1.ItemClicked

        Try

            If Cms_1.Items(0).Selected = True Then
                Cms_1.Hide()
                MAIN_JOB11()
            End If
            If Cms_1.Items(1).Selected = True Then
                Cms_1.Hide()
                MAIN_JOB02()
            End If

        Catch ex As Exception
            Call MsgBoxP("35", "cmd_SEARCH_Click")
        End Try
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

        txt_Year.Value = CIntp(Strings.Left(Pub.DAT, 4))
    End Sub
#End Region

#Region "Function"
    Private Sub MAIN_JOB01()
        Try
            Dim str As String = MsgBoxP("Do you want to process this invoice to liquidation?", vbYesNo)

            If str <> vbYes Then Exit Sub

            Dim i As Integer


            For i = 0 To vS10.ActiveSheet.RowCount - 1
                If getDataM(vS10, getColumIndex(vS10, "DCHK"), i) = "1" Then
                    Dim DateOutbound As String = FormatCut(getData(vS10, getColumIndex(vS10, "DateOutbound"), i))
                    Dim InvoiceNo As String = getData(vS10, getColumIndex(vS10, "InvoiceNo"), i)
                    Dim cdSite As String = txt_cdSite.Code

                    Call PrcExeNoError(" USP_PFK3476_INSERT", cn, cdSite, DateOutbound, InvoiceNo)

                    SPR_CLEAR(vS10, i, 0, i, vS10.ActiveSheet.ColumnCount)
                    setData(vS10, getColumIndex(vS10, "InvoiceNo"), i, "[LIQUIDATION]", Color.Red)
                End If
            Next


        Catch ex As Exception

        End Try
    End Sub

    Private Sub MAIN_JOB11()
        Try
            Dim str As String = MsgBoxP("Do you want to process this invoice to liquidation?", vbYesNo)

            If str <> vbYes Then Exit Sub

            Dim DateOutbound As String = FormatCut(getData(vS20, getColumIndex(vS20, "DateOutbound"), vS20.ActiveSheet.ActiveRowIndex))
            Dim InvoiceNo As String = getData(vS20, getColumIndex(vS20, "InvoiceNo"), vS20.ActiveSheet.ActiveRowIndex)
            Dim cdSite As String = txt_cdSite.Code

            Call PrcExeNoError(" USP_PFK3476_INSERT", cn, cdSite, DateOutbound, InvoiceNo)
            Call DATA_SEARCH_Vs20()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub MAIN_JOB02()
        Try
            Dim str As String = MsgBoxP("Do you want to delete this invoice ?", vbYesNo)

            If str <> vbYes Then Exit Sub

            Dim DateOutbound As String = FormatCut(getData(vS20, getColumIndex(vS20, "DateOutbound"), vS20.ActiveSheet.ActiveRowIndex))
            Dim InvoiceNo As String = getData(vS20, getColumIndex(vS20, "InvoiceNo"), vS20.ActiveSheet.ActiveRowIndex)
            Dim cdSite As String = txt_cdSite.Code

            Call PrcExeNoError(" USP_PFK3476_DELETE", cn, cdSite, DateOutbound, InvoiceNo)
            Call DATA_SEARCH_Vs20()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub MAIN_JOB03()

    End Sub

    Private Sub MAIN_JOB04()

    End Sub
#End Region

#Region "Data_search"

    Private Function DATA_SEARCH_Vs10(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_Vs10 = False

        Vs10.Enabled = False
        Try
            DS1 = PrcDS("USP_PFP94100_SEARCH_Vs10", cn, txt_cdSite.Code, txt_Year.Value, txt_Month.Value.ToString("00"))


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS10, DS1, "USP_PFP94100_SEARCH_Vs10", "Vs10")

                vS10.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS10, DS1, "USP_PFP94100_SEARCH_Vs10", "Vs10")
            DATA_SEARCH_Vs10 = True

            vS10.Enabled = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_Vs10")
        End Try

    End Function

    Private Function DATA_SEARCH_Vs20(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_Vs20 = False

        Vs20.Enabled = False


        Try
            DS1 = PrcDS("USP_PFP94100_SEARCH_Vs20", cn, txt_cdSite.Code, txt_Year.Value, txt_Month.Value.ToString("00"))


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs20, DS1, "USP_PFP94100_SEARCH_Vs20", "Vs20")

                Vs20.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS20, DS1, "USP_PFP94100_SEARCH_Vs20", "Vs20")


            DATA_SEARCH_Vs20 = True

            Vs20.Enabled = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_Vs20")
        End Try

    End Function

    Private Function DATA_SEARCH_Vs21(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_Vs21 = False


        Dim cdSite As String = getData(vS20, getColumIndex(vS20, "KEY_cdSite"), vS20.ActiveSheet.ActiveRowIndex)
        Dim DateOutbound As String = getData(vS20, getColumIndex(vS20, "KEY_DateOutbound"), vS20.ActiveSheet.ActiveRowIndex)
        Dim InvoiceNo As String = getData(vS20, getColumIndex(vS20, "KEY_InvoiceNo"), vS20.ActiveSheet.ActiveRowIndex)

        Dim TradingCode As String = getData(vS20, getColumIndex(vS20, "KEY_TradingCode"), vS20.ActiveSheet.ActiveRowIndex)

        Vs21.Enabled = False


        Try
            DS1 = PrcDS("USP_PFP94100_SEARCH_Vs21", cn, cdSite, DateOutbound, InvoiceNo, TradingCode)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs21, DS1, "USP_PFP94100_SEARCH_Vs21", "Vs21")

                Vs21.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs21, DS1, "USP_PFP94100_SEARCH_Vs21", "Vs21")


            DATA_SEARCH_Vs21 = True

            Vs21.Enabled = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_Vs21")
        End Try

    End Function

    Private Function DATA_SEARCH_Vs22(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_Vs22 = False
        Exit Function

        Dim LiquidNo As String = getData(vS20, getColumIndex(vS20, "Key_LiquidNo"), vS20.ActiveSheet.ActiveRowIndex)
        Dim LiquidSeq As String = getData(vS20, getColumIndex(vS20, "Key_LiquidSeq"), vS20.ActiveSheet.ActiveRowIndex)

        Vs22.Enabled = False


        Try
            DS1 = PrcDS("USP_PFP94100_SEARCH_Vs22", cn, LiquidNo, LiquidSeq)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs22, DS1, "USP_PFP94100_SEARCH_Vs22", "Vs22")

                Vs22.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs22, DS1, "USP_PFP94100_SEARCH_Vs22", "Vs22")


            DATA_SEARCH_Vs22 = True

            Vs22.Enabled = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_Vs22")
        End Try

    End Function

    Private Function DATA_SEARCH_Vs30(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_Vs30 = False

        Vs30.Enabled = False


        Try
            DS1 = PrcDS("USP_PFP94100_SEARCH_Vs30", cn, txt_cdSite.Code, txt_Year.Value, txt_Month.Value.ToString("00"))


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs30, DS1, "USP_PFP94100_SEARCH_Vs30", "Vs30")

                Vs30.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS30, DS1, "USP_PFP94100_SEARCH_Vs30", "Vs30")
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

    Private Sub vS10_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS10.CellDoubleClick
        Try



        Catch ex As Exception

        End Try
    End Sub

    Private Sub vS20_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS20.CellDoubleClick
        Try
            Exit Sub

            chk_Detail.Checked = True
            Call DATA_SEARCH_Vs21()
            Call DATA_SEARCH_Vs22()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub vS30_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS30.CellDoubleClick
        Try

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



    Private Sub chk_Detail_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Detail.CheckedChanged
        Try
            If chk_Detail.Checked = False Then SplitContainer1.Panel2Collapsed = True
            If chk_Detail.Checked = True Then SplitContainer1.Panel2Collapsed = False

        Catch ex As Exception

        End Try
    End Sub

    Private Sub vS20_CellClick(sender As Object, e As CellClickEventArgs) Handles vS20.CellClick

    End Sub

    Private Sub cmd_Closing_Click(sender As Object, e As EventArgs) Handles cmd_Closing.Click
        Msg_Result = MsgBoxP("Do you want to closing all date?", vbYesNo)

        If Msg_Result <> vbYes Then Exit Sub


        Dim Starting As Object
        Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")


        Try
            Call PrcExeNoError("CLOSING_MATERIAL_INVENTORY", cn, txt_Year.Value.ToString("0000"), txt_Month.Value.ToString("00"))

        Catch ex As Exception

        Finally
            Starting.close()
        End Try
    End Sub
End Class