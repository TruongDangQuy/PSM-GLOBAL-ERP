Public Class PFP13408

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

        Call Cms_additem(Cms_0, "INSERT LIQUIDATION VOUCHER" & "(F5)")


        vS10.ContextMenuStrip = Cms_0

        Call Cms_additem(cms_20, "-",
                         "-",
                        "DELETE LIQUIDATION VOUCHER " & "(F7)",
                         "PRINT LIQUIDATION VOUCHER " & "(F8)",
                        "APPROVAL LIQUIDATION VOUCHER " & "(F9)",
                         "-",
                        "AUTO BALANCE LIQUIDATION VOUCHER " & "(F10)",
                         "RE-SYNC LIQUIDATION VOUCHER " & "(F11)",
                         "-",
                         "PRINT BOM FORM ")

        vS20.ContextMenuStrip = cms_20
        vS30.ContextMenuStrip = cms_20
        vS40.ContextMenuStrip = cms_20



        Call Cms_additem(Cms_1, "INSERT TRADING BOM" & "(F5)",
                                "SEARCH TRADING BOM " & "(F6)",
                                "UPDATE TRADING BOM " & "(F7)",
                                "DELETE TRADING BOM " & "(F8)")

        vS21.ContextMenuStrip = Cms_1

        Call Cms_additem(Cms_2, "INSERT TRANSFER VOUCHER" & "(F5)",
                                "SEARCH TRANSFER VOUCHER " & "(F6)",
                                "UPDATE TRANSFER VOUCHER " & "(F7)",
                                "DELETE TRANSFER VOUCHER " & "(F8)")



        vS22.ContextMenuStrip = Cms_2
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

    Private Sub Cms_20_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles cms_20.ItemClicked

        If cms_20.Items(2).Selected = True Then
            cms_20.Hide()

            Call MAIN_JOB02()
        End If

        If cms_20.Items(3).Selected = True Then ' CHUNG
            cms_20.Hide()

            Call MAIN_JOB03()
        End If

        If cms_20.Items(4).Selected = True Then  ' CHUNG
            cms_20.Hide()

            Call MAIN_JOB06()


        End If
        If cms_20.Items(6).Selected = True Then
            cms_20.Hide()

            Call MAIN_JOB07()

        End If

        If cms_20.Items(7).Selected = True Then
            cms_20.Hide()
            Call MAIN_JOB11()
        End If

        If cms_20.Items(9).Selected = True Then  ' CHUNG
            cms_20.Hide()
            Call MAIN_JOB12()
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
                    Dim InvoiceNo As String = getData(vS10, getColumIndex(vS10, "Key_InvoiceNo"), i)
                    Dim InvoiceSeq As String = getData(vS10, getColumIndex(vS10, "Key_InvoiceSeq"), i)

                    Call PrcExeNoError(" USP_PFK3471_INSERT", cn, InvoiceNo, InvoiceSeq, txt_Year.Value.ToString("0000"), Pub.SAW)

                    SPR_CLEAR(vS10, i, 0, i, vS10.ActiveSheet.ColumnCount)
                    setData(vS10, getColumIndex(vS10, "InvoiceNoMaster"), i, "[LIQUIDATION]", Color.Red)
                End If
              
            Next


        Catch ex As Exception

        End Try
    End Sub


    Private Sub MAIN_JOB02()
        Try
            Dim str As String = MsgBoxP("Do you want to delete this invoice liquidation?", vbYesNo)

            If str <> vbYes Then Exit Sub

            Dim LiquidNo As String = getData(vS20, getColumIndex(vS20, "Key_LiquidNo"), vS20.ActiveSheet.ActiveRowIndex)
            Dim LiquidSeq As String = getData(vS20, getColumIndex(vS20, "Key_LiquidSeq"), vS20.ActiveSheet.ActiveRowIndex)

            Call PrcExeNoError(" USP_PFK3471_DELETE", cn, LiquidNo, LiquidSeq)
            Call DATA_SEARCH_Vs20()
            vS21.ActiveSheet.RowCount = 0
            vS22.ActiveSheet.RowCount = 0
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MAIN_JOB03()
        Try

            If vS20.Focused Then


                If READ_SHEETPRINT_MATCHING(Strings.Left(Me.Name, 8)) = True Then
                    If SheetReport.Link_SheetReport(3, Strings.Left(Me.Name, 8)) = True Then

                        Dim LiquidNo As String = getData(vS20, getColumIndex(vS20, "Key_LiquidNo"), vS20.ActiveSheet.ActiveRowIndex)
                        Dim LiquidSeq As String = getData(vS20, getColumIndex(vS20, "Key_LiquidSeq"), vS20.ActiveSheet.ActiveRowIndex)


                        ChuoiValue1 = "USP_RPT13408_SEARCH_VS20;USP_RPT13408_SEARCH_VS21;USP_RPT13408_SEARCH_VS22"
                        ChuoiValue2 = LiquidNo & "," & LiquidSeq & ";"
                        ChuoiValue2 += ChuoiValue2
                        ChuoiValue2 += LiquidNo & "," & LiquidSeq

                        If PRINTSHEET.Link_PrintSheet(SheetReportName, ChuoiValue1, ChuoiValue2) = True Then


                        End If
                    End If
                End If


            ElseIf vS30.Focused Then

                If READ_SHEETPRINT_MATCHING(Strings.Left(Me.Name, 8)) = True Then
                    If SheetReport.Link_SheetReport(3, Strings.Left(Me.Name, 8)) = True Then

                        Dim LiquidNo As String = getData(vS30, getColumIndex(vS30, "Key_LiquidNo"), vS30.ActiveSheet.ActiveRowIndex)
                        Dim LiquidSeq As String = getData(vS30, getColumIndex(vS30, "Key_LiquidSeq"), vS30.ActiveSheet.ActiveRowIndex)


                        ChuoiValue1 = "USP_RPT13408_SEARCH_VS20;USP_RPT13408_SEARCH_VS21;USP_RPT13408_SEARCH_VS22"
                        ChuoiValue2 = LiquidNo & "," & LiquidSeq & ";"
                        ChuoiValue2 += ChuoiValue2
                        ChuoiValue2 += LiquidNo & "," & LiquidSeq

                        If PRINTSHEET.Link_PrintSheet(SheetReportName, ChuoiValue1, ChuoiValue2) = True Then


                        End If
                    End If
                End If

            ElseIf vS40.Focused Then

                If READ_SHEETPRINT_MATCHING(Strings.Left(Me.Name, 8)) = True Then
                    If SheetReport.Link_SheetReport(3, Strings.Left(Me.Name, 8)) = True Then

                        Dim LiquidNo As String = getData(vS40, getColumIndex(vS40, "Key_LiquidNo"), vS40.ActiveSheet.ActiveRowIndex)
                        Dim LiquidSeq As String = getData(vS40, getColumIndex(vS40, "Key_LiquidSeq"), vS40.ActiveSheet.ActiveRowIndex)


                        ChuoiValue1 = "USP_RPT13408_SEARCH_VS20;USP_RPT13408_SEARCH_VS21;USP_RPT13408_SEARCH_VS22"
                        ChuoiValue2 = LiquidNo & "," & LiquidSeq & ";"
                        ChuoiValue2 += ChuoiValue2
                        ChuoiValue2 += LiquidNo & "," & LiquidSeq

                        If PRINTSHEET.Link_PrintSheet(SheetReportName, ChuoiValue1, ChuoiValue2) = True Then


                        End If
                    End If
                End If

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub MAIN_JOB12()
        Try
            If READ_SHEETPRINT_MATCHING(Strings.Left(Me.Name, 8)) = True Then
                If SheetReport.Link_SheetReport(3, Strings.Left(Me.Name, 8)) = True Then
                    Dim LiquidNo As String
                    Dim LiquidSeq As String
                    If vS20.Focused Then
                        LiquidNo = getData(vS20, getColumIndex(vS20, "Key_LiquidNo"), vS20.ActiveSheet.ActiveRowIndex)
                        LiquidSeq = getData(vS20, getColumIndex(vS20, "Key_LiquidSeq"), vS20.ActiveSheet.ActiveRowIndex)
                    ElseIf vS30.Focused Then
                        LiquidNo = getData(vS30, getColumIndex(vS30, "Key_LiquidNo"), vS30.ActiveSheet.ActiveRowIndex)
                        LiquidSeq = getData(vS30, getColumIndex(vS30, "Key_LiquidSeq"), vS30.ActiveSheet.ActiveRowIndex)
                    ElseIf vS40.Focused Then
                        LiquidNo = getData(vS40, getColumIndex(vS40, "Key_LiquidNo"), vS40.ActiveSheet.ActiveRowIndex)
                        LiquidSeq = getData(vS40, getColumIndex(vS40, "Key_LiquidSeq"), vS40.ActiveSheet.ActiveRowIndex)
                    End If

                    SheetReportName = "CONSUMPTION_INFO"
                    ChuoiValue1 = "USP_RPT13408_SEARCH_BOM_HEAD;USP_RPT13408_SEARCH_BOM_DETAIL"
                    ChuoiValue2 = LiquidNo & "," & LiquidSeq & ";"
                    ChuoiValue2 += LiquidNo & "," & LiquidSeq

                    If PRINTSHEET.Link_PrintSheet(SheetReportName, ChuoiValue1, ChuoiValue2) = True Then


                    End If
                End If
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub MAIN_JOB11()

        Try
            'If READ_SHEETPRINT_MATCHING(Strings.Left(Me.Name, 8)) = True Then
            '    If SheetReport.Link_SheetReport(3, Strings.Left(Me.Name, 8)) = True Then

            '        Dim LiquidNo As String = getData(vS20, getColumIndex(vS20, "Key_LiquidNo"), vS20.ActiveSheet.ActiveRowIndex)
            '        Dim LiquidSeq As String = getData(vS20, getColumIndex(vS20, "Key_LiquidSeq"), vS20.ActiveSheet.ActiveRowIndex)


            '        ChuoiValue1 = "USP_RPT13408_SEARCH_VS20;USP_RPT13408_SEARCH_VS21;USP_RPT13408_SEARCH_VS22"
            '        ChuoiValue2 = LiquidNo & "," & LiquidSeq & ";"
            '        ChuoiValue2 += ChuoiValue2
            '        ChuoiValue2 += LiquidNo & "," & LiquidSeq

            '        If PRINTSHEET.Link_PrintSheet(SheetReportName, ChuoiValue1, ChuoiValue2) = True Then


            '        End If
            '    End If
            'End If

            Dim str As String = MsgBoxP("Do you want to re-sync this invoice liquidation?", vbYesNo)

            If str <> vbYes Then Exit Sub

            Dim i As Integer


            For i = 0 To vS20.ActiveSheet.RowCount - 1
                If getDataM(vS20, getColumIndex(vS20, "DCHK"), i) = "1" Then
                    Dim LiquidNo As String = getData(vS20, getColumIndex(vS20, "Key_LiquidNo"), i)
                    Dim LiquidSeq As String = getData(vS20, getColumIndex(vS20, "Key_LiquidSeq"), i)

                    Call PrcExeNoError(" USP_PFK3471_INSERT", cn, LiquidNo, LiquidSeq, txt_Year.Value.ToString("0000"), Pub.SAW)
                End If
            Next

            Call DATA_SEARCH_Vs20()
            vS21.ActiveSheet.RowCount = 0
            vS22.ActiveSheet.RowCount = 0


        Catch ex As Exception

        End Try
    End Sub



    Private Sub MAIN_JOB04()

    End Sub

    Private Sub MAIN_JOB06()
        Dim LiquidNo As String
        Dim LiquidSeq As String

        If vS20.Focused Then
            LiquidNo = getData(vS20, getColumIndex(vS20, "Key_LiquidNo"), vS20.ActiveSheet.ActiveRowIndex)
            LiquidSeq = getData(vS20, getColumIndex(vS20, "Key_LiquidSeq"), vS20.ActiveSheet.ActiveRowIndex)

        ElseIf vS30.Focused Then
            LiquidNo = getData(vS30, getColumIndex(vS30, "Key_LiquidNo"), vS30.ActiveSheet.ActiveRowIndex)
            LiquidSeq = getData(vS30, getColumIndex(vS30, "Key_LiquidSeq"), vS30.ActiveSheet.ActiveRowIndex)

        ElseIf vS40.Focused Then
            LiquidNo = getData(vS40, getColumIndex(vS40, "Key_LiquidNo"), vS40.ActiveSheet.ActiveRowIndex)
            LiquidSeq = getData(vS40, getColumIndex(vS40, "Key_LiquidSeq"), vS40.ActiveSheet.ActiveRowIndex)

        End If


        If ISUD3471P.Link_ISUD3471P(3, LiquidNo, LiquidSeq, Me.Name) = False Then Exit Sub

        Dim reStatus As String
        Call READ_PFK3471(LiquidNo, LiquidSeq)
        reStatus = D3471.CheckLiquidation

        If vS20.Focused Then
            For i As Integer = 0 To vS20.ActiveSheet.RowCount - 1
                If getDataM(vS20, getColumIndex(vS20, "DCHK"), i) = "1" Then

                    LiquidNo = getData(vS20, getColumIndex(vS20, "Key_LiquidNo"), i)
                    LiquidSeq = getData(vS20, getColumIndex(vS20, "Key_LiquidSeq"), i)

                    If READ_PFK3471(LiquidNo, LiquidSeq) Then
                        D3471.CheckLiquidation = reStatus
                        Call REWRITE_PFK3471(D3471)
                    End If

                End If
            Next

            Call DATA_SEARCH_Vs20()

        ElseIf vS30.Focused Then
            For i As Integer = 0 To vS30.ActiveSheet.RowCount - 1
                If getDataM(vS30, getColumIndex(vS30, "DCHK"), i) = "1" Then

                    LiquidNo = getData(vS30, getColumIndex(vS30, "Key_LiquidNo"), i)
                    LiquidSeq = getData(vS30, getColumIndex(vS30, "Key_LiquidSeq"), i)

                    If READ_PFK3471(LiquidNo, LiquidSeq) Then
                        D3471.CheckLiquidation = reStatus
                        Call REWRITE_PFK3471(D3471)
                    End If

                End If
            Next

            Call DATA_SEARCH_Vs30()

        ElseIf vS40.Focused Then
            For i As Integer = 0 To vS40.ActiveSheet.RowCount - 1
                If getDataM(vS40, getColumIndex(vS40, "DCHK"), i) = "1" Then

                    LiquidNo = getData(vS40, getColumIndex(vS40, "Key_LiquidNo"), i)
                    LiquidSeq = getData(vS40, getColumIndex(vS40, "Key_LiquidSeq"), i)

                    If READ_PFK3471(LiquidNo, LiquidSeq) Then
                        D3471.CheckLiquidation = reStatus
                        Call REWRITE_PFK3471(D3471)
                    End If

                End If
            Next
            Call DATA_SEARCH_vS40()

        End If


    End Sub

    Private Sub MAIN_JOB07()
        Try
            Dim str As String = MsgBoxP("Do you want to auto-balance this invoice liquidation?", vbYesNo)

            If str <> vbYes Then Exit Sub

            For i As Integer = 0 To vS20.ActiveSheet.RowCount - 1
                If getDataM(vS20, getColumIndex(vS20, "DCHK"), i) = "1" Then
                    Dim LiquidNo As String = getData(vS20, getColumIndex(vS20, "Key_LiquidNo"), i)
                    Dim LiquidSeq As String = getData(vS20, getColumIndex(vS20, "Key_LiquidSeq"), i)

                    Call PrcExeNoError(" USP_PFK3471_UPDATE_CHECKTYPE", cn, LiquidNo, LiquidSeq, "3")
                End If
            Next

         
            Call DATA_SEARCH_Vs20()
            vS21.ActiveSheet.RowCount = 0
            vS22.ActiveSheet.RowCount = 0
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Data_search"

    Private Function DATA_SEARCH_Vs10(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_Vs10 = False

        Vs10.Enabled = False
        Try
            DS1 = PrcDS("USP_PFP13408_SEARCH_Vs10", cn, txt_cdSite.Code, txt_Year.Value)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS10, DS1, "USP_PFP13408_SEARCH_Vs10", "Vs10")

                vS10.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS10, DS1, "USP_PFP13408_SEARCH_Vs10", "Vs10")
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
            DS1 = PrcDS("USP_PFP13408_SEARCH_Vs20", cn, txt_cdSite.Code, txt_Year.Value)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs20, DS1, "USP_PFP13408_SEARCH_Vs20", "Vs20")

                Vs20.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS20, DS1, "USP_PFP13408_SEARCH_Vs20", "Vs20")


            DATA_SEARCH_Vs20 = True

            Vs20.Enabled = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_Vs20")
        End Try

    End Function

    Private Function DATA_SEARCH_Vs21(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_Vs21 = False


        Dim LiquidNo As String = getData(vS20, getColumIndex(vS20, "Key_LiquidNo"), vS20.ActiveSheet.ActiveRowIndex)
        Dim LiquidSeq As String = getData(vS20, getColumIndex(vS20, "Key_LiquidSeq"), vS20.ActiveSheet.ActiveRowIndex)


        Vs21.Enabled = False


        Try
            DS1 = PrcDS("USP_PFP13408_SEARCH_Vs21", cn, LiquidNo, LiquidSeq)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs21, DS1, "USP_PFP13408_SEARCH_Vs21", "Vs21")

                Vs21.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs21, DS1, "USP_PFP13408_SEARCH_Vs21", "Vs21")


            DATA_SEARCH_Vs21 = True

            Vs21.Enabled = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_Vs21")
        End Try

    End Function

    Private Function DATA_SEARCH_Vs22(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_Vs22 = False

        Dim LiquidNo As String = getData(vS20, getColumIndex(vS20, "Key_LiquidNo"), vS20.ActiveSheet.ActiveRowIndex)
        Dim LiquidSeq As String = getData(vS20, getColumIndex(vS20, "Key_LiquidSeq"), vS20.ActiveSheet.ActiveRowIndex)

        Vs22.Enabled = False


        Try
            DS1 = PrcDS("USP_PFP13408_SEARCH_Vs22", cn, LiquidNo, LiquidSeq)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs22, DS1, "USP_PFP13408_SEARCH_Vs22", "Vs22")

                Vs22.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs22, DS1, "USP_PFP13408_SEARCH_Vs22", "Vs22")


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
            DS1 = PrcDS("USP_PFP13408_SEARCH_Vs30", cn, txt_cdSite.Code, txt_Year.Value)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs30, DS1, "USP_PFP13408_SEARCH_Vs30", "Vs30")

                Vs30.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS30, DS1, "USP_PFP13408_SEARCH_Vs30", "Vs30")
            DATA_SEARCH_Vs30 = True

            Vs30.Enabled = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_Vs30")
        End Try

    End Function
    Private Function DATA_SEARCH_vS31(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_vS31 = False


        Dim LiquidNo As String = getData(vS30, getColumIndex(vS30, "Key_LiquidNo"), vS30.ActiveSheet.ActiveRowIndex)
        Dim LiquidSeq As String = getData(vS30, getColumIndex(vS30, "Key_LiquidSeq"), vS30.ActiveSheet.ActiveRowIndex)


        vS31.Enabled = False


        Try
            DS1 = PrcDS("USP_PFP13408_SEARCH_vS31", cn, LiquidNo, LiquidSeq)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS31, DS1, "USP_PFP13408_SEARCH_vS31", "vS31")

                vS31.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS31, DS1, "USP_PFP13408_SEARCH_vS31", "vS31")


            DATA_SEARCH_vS31 = True

            vS31.Enabled = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_vS31")
        End Try

    End Function

    Private Function DATA_SEARCH_vS32(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_vS32 = False

        Dim LiquidNo As String = getData(vS30, getColumIndex(vS30, "Key_LiquidNo"), vS30.ActiveSheet.ActiveRowIndex)
        Dim LiquidSeq As String = getData(vS30, getColumIndex(vS30, "Key_LiquidSeq"), vS30.ActiveSheet.ActiveRowIndex)

        vS32.Enabled = False


        Try
            DS1 = PrcDS("USP_PFP13408_SEARCH_vS32", cn, LiquidNo, LiquidSeq)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS32, DS1, "USP_PFP13408_SEARCH_vS32", "vS32")

                vS32.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS32, DS1, "USP_PFP13408_SEARCH_vS32", "vS32")


            DATA_SEARCH_vS32 = True

            vS32.Enabled = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_vS32")
        End Try

    End Function
    Private Function DATA_SEARCH_vS40(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_vS40 = False

        vS40.Enabled = False


        Try
            DS1 = PrcDS("USP_PFP13408_SEARCH_vS40", cn, txt_cdSite.Code, txt_Year.Value)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS40, DS1, "USP_PFP13408_SEARCH_vS40", "vS40")

                vS40.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS40, DS1, "USP_PFP13408_SEARCH_vS40", "vS40")
            DATA_SEARCH_vS40 = True

            vS40.Enabled = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_vS40")
        End Try

    End Function


    Private Function DATA_SEARCH_vS41(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_vS41 = False


        Dim LiquidNo As String = getData(vS40, getColumIndex(vS40, "Key_LiquidNo"), vS40.ActiveSheet.ActiveRowIndex)
        Dim LiquidSeq As String = getData(vS40, getColumIndex(vS40, "Key_LiquidSeq"), vS40.ActiveSheet.ActiveRowIndex)


        vS41.Enabled = False


        Try
            DS1 = PrcDS("USP_PFP13408_SEARCH_vS41", cn, LiquidNo, LiquidSeq)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS41, DS1, "USP_PFP13408_SEARCH_vS41", "vS41")

                vS41.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS41, DS1, "USP_PFP13408_SEARCH_vS41", "vS41")


            DATA_SEARCH_vS41 = True

            vS41.Enabled = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_vS41")
        End Try

    End Function

    Private Function DATA_SEARCH_vS42(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_vS42 = False

        Dim LiquidNo As String = getData(vS40, getColumIndex(vS40, "Key_LiquidNo"), vS40.ActiveSheet.ActiveRowIndex)
        Dim LiquidSeq As String = getData(vS40, getColumIndex(vS40, "Key_LiquidSeq"), vS40.ActiveSheet.ActiveRowIndex)

        vS42.Enabled = False


        Try
            DS1 = PrcDS("USP_PFP13408_SEARCH_vS42", cn, LiquidNo, LiquidSeq)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS42, DS1, "USP_PFP13408_SEARCH_vS42", "vS42")

                vS42.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS42, DS1, "USP_PFP13408_SEARCH_vS42", "vS42")


            DATA_SEARCH_vS42 = True

            vS42.Enabled = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_vS42")
        End Try

    End Function
    Private Function DATA_SEARCH_Vs50(Optional ByVal xsort As String = "1") As Boolean


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
            Dim i As Integer
            Dim Autokey As String
            Dim LiquidNo As String
            Dim LiquidSeq As String

            If Cms_1.Items(2).Selected = True Then
                Cms_0.Hide()


                For i = 0 To vS21.ActiveSheet.RowCount - 1
                    Autokey = getData(vS21, getColumIndex(vS21, "KEY_AUTOKEY"), i)
                    LiquidNo = getData(vS21, getColumIndex(vS21, "KEY_LiquidNo"), i)
                    LiquidSeq = getData(vS21, getColumIndex(vS21, "KEY_LiquidSeq"), i)

                    If READ_PFK3474(Autokey) Then
                        D3474.Remark = getData(vS21, getColumIndex(vS21, "Remark"), i)
                        D3474.QtyOutbound = CDecp(getData(vS21, getColumIndex(vS21, "QtyOutbound"), i))

                        Call REWRITE_PFK3474(D3474)

                    End If

                Next

                Call PrcExeNoError("USP_PFK3471_CLOSING", cn, LiquidNo, LiquidSeq)
            End If


        Catch ex As Exception
            Call MsgBoxP("35", "cmd_SEARCH_Click")
        End Try

    End Sub

    Private Sub vS10_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS10.CellDoubleClick
       
    End Sub

    Private Sub vS20_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS20.CellDoubleClick
        Try
            chk_Detail.Checked = True
            Call DATA_SEARCH_Vs21()
            Call DATA_SEARCH_Vs22()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub vS30_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS30.CellDoubleClick
        Try
            chk_Detail.Checked = True
            Call DATA_SEARCH_Vs31()
            Call DATA_SEARCH_Vs32()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub vS40_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS40.CellDoubleClick
        Try
            chk_Detail.Checked = True
            Call DATA_SEARCH_Vs41()
            Call DATA_SEARCH_Vs42()
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
            If chk_Detail.Checked = False Then SplitContainer1.Panel2Collapsed = True : SplitContainer2.Panel2Collapsed = True : SplitContainer3.Panel2Collapsed = True
            If chk_Detail.Checked = True Then SplitContainer1.Panel2Collapsed = False : SplitContainer2.Panel2Collapsed = False : SplitContainer3.Panel2Collapsed = False

        Catch ex As Exception

        End Try
    End Sub

    Private Sub vS20_CellClick(sender As Object, e As CellClickEventArgs) Handles vS20.CellClick

    End Sub

    Private Sub cmd_AutoMatching_Click(sender As Object, e As EventArgs) Handles cmd_AutoMatching.Click
        Try
            Call PrcExeNoError(" USP_PFK13408_CLOSING_TRADINGCODE", cn, Pub.SAW)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_ClearWrong_Click(sender As Object, e As EventArgs) Handles cmd_ClearWrong.Click
        Try
            Call PrcExeNoError(" USP_PFK13408_CLOSING_CLEARWRONG", cn, Pub.SAW)

        Catch ex As Exception

        End Try
    End Sub
End Class