Public Class PFP26560
#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Private wGCODE As String
    Protected prg As E_PRG

    Private W2456 As T2456_AREA
    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

        Me.KeyPreview = True

        Call FORM_INIT()
        Call DATA_INIT()

    End Sub
    Private Sub PFP17811_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub
   
    Private Sub FORM_INIT()
        chk_FSEL.CheckState = 1
        chk_FSEL.BackColor = clrCheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("CLOSE")
        ssp_WHERE.Visible = True
    End Sub

    Private Sub DATA_INIT()
        txt_SDATE.Data = Pub.DAT
        Me.Tag = Me.Name
        SdateEdate.text1 = System_Date_6() & "01"
        SdateEdate.text2 = System_Date_8()
    End Sub
#End Region

#Region "Function"
  
#End Region

#Region "Data_search"
    
    Private Function DATA_SEARCH_VS10(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS10 = False

        vS10.Enabled = False

        DS1 = PrcDS("USP_PFP26560_SEARCH_vS20_F1", cn, SdateEdate.text1, _
                                                       SdateEdate.text2, _
                                                       txt_cdFactory.Code, _
                                                       txt_CustomerCode.Data, _
                                                       txt_cdSite.Code, _
                                                       txt_Line.Data, _
                                                       txt_Article.Data, _
                                                       txt_SLNO.Data,
                                                       txt_PKO.Data, _
                                                       txt_PONO.Data, _
                                                       "1",
                                                       "2",
                                                       "3",
                                                       "4",
                                                       "5")

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS10, DS1, "USP_PFP26560_SEARCH_vS20_F1", "vS10")
            vS10.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS10, DS1, "USP_PFP26560_SEARCH_vS20_F1", "vS10")
        DATA_SEARCH_VS10 = True

        vS10.Enabled = True

    End Function

    Private Function DATA_SEARCH_VS11(Optional ByVal xsort As String = "1") As Boolean

        Dim ProductOutboundNo As String
        Dim KEY_AutoKey As String

        DATA_SEARCH_VS11 = False

        vS11.Enabled = False

        ProductOutboundNo = getData(vS10, getColumIndex(vS10, "KEY_ProductOutboundNo"), vS10.ActiveSheet.ActiveRowIndex)
        KEY_AutoKey = getData(vS10, getColumIndex(vS10, "KEY_AutoKey"), vS10.ActiveSheet.ActiveRowIndex)

        DS1 = PrcDS("USP_PFP26560_SEARCH_vS11", cn, ProductOutboundNo,
                                                    KEY_AutoKey)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS11, DS1, "USP_PFP26560_SEARCH_vS11", "vS11")
            vS11.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS11, DS1, "USP_PFP26560_SEARCH_vS11", "vS11")
        DATA_SEARCH_VS11 = True

        vS11.Enabled = True
    End Function
    Private Function DATA_SEARCH_VS11_PKO(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS11_PKO = False

        Dim Key_PKO As String
        Dim Key_cdSeason As String
        Dim KEY_FactOrderNo As String
        Dim KEY_FactOrderSeq As String
        Dim KEY_ProductOutboundNo As String

        Try
            vS11.Enabled = False

            Key_cdSeason = getData(vS10, getColumIndex(vS10, "cdSeason"), vS10.ActiveSheet.ActiveRowIndex)
            Key_PKO = getData(vS10, getColumIndex(vS10, "PKO"), vS10.ActiveSheet.ActiveRowIndex)
            KEY_FactOrderNo = getData(vS10, getColumIndex(vS10, "KEY_FactOrderNo"), vS10.ActiveSheet.ActiveRowIndex)
            KEY_FactOrderSeq = getData(vS10, getColumIndex(vS10, "KEY_FactOrderSeq"), vS10.ActiveSheet.ActiveRowIndex)
            KEY_ProductOutboundNo = getData(vS10, getColumIndex(vS10, "KEY_ProductOutboundNo"), vS10.ActiveSheet.ActiveRowIndex)

            DS1 = PrcDS("USP_PFP26560_SEARCH_vS11_PKO", cn, Key_cdSeason, KEY_FactOrderNo, KEY_FactOrderSeq, Key_PKO, KEY_ProductOutboundNo)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS11, DS1, "USP_PFP26560_SEARCH_vS11_PKO", "vS11")
                vS11.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS11, DS1, "USP_PFP26560_SEARCH_vS11_PKO", "vS11")

            DATA_SEARCH_VS11_PKO = True

            vS11.Enabled = True

        Catch ex As Exception

        End Try
    End Function
    Private Function DATA_SEARCH_VS11_PKO_BAL(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS11_PKO_BAL = False

        Dim Key_PKO As String
        Dim Key_cdSeason As String
        Dim KEY_FactOrderNo As String
        Dim KEY_FactOrderSeq As String
        Dim KEY_ProductOutboundNo As String

        Try
            vS11.Enabled = False

            Key_cdSeason = getData(vS10, getColumIndex(vS10, "cdSeason"), vS10.ActiveSheet.ActiveRowIndex)
            Key_PKO = getData(vS10, getColumIndex(vS10, "PKO"), vS10.ActiveSheet.ActiveRowIndex)
            KEY_FactOrderNo = getData(vS10, getColumIndex(vS10, "KEY_FactOrderNo"), vS10.ActiveSheet.ActiveRowIndex)
            KEY_FactOrderSeq = getData(vS10, getColumIndex(vS10, "KEY_FactOrderSeq"), vS10.ActiveSheet.ActiveRowIndex)
            KEY_ProductOutboundNo = getData(vS10, getColumIndex(vS10, "KEY_ProductOutboundNo"), vS10.ActiveSheet.ActiveRowIndex)

            DS1 = PrcDS("USP_PFP26560_SEARCH_vS11_PKO_BAL", cn, Key_cdSeason, KEY_FactOrderNo, KEY_FactOrderSeq, Key_PKO, KEY_ProductOutboundNo)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS11, DS1, "USP_PFP26560_SEARCH_vS11_PKO_BAL", "vS11")
                vS11.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS11, DS1, "USP_PFP26560_SEARCH_vS11_PKO_BAL", "vS11")

            DATA_SEARCH_VS11_PKO_BAL = True

            vS11.Enabled = True

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
   
    Private Sub vS10_GotFocus(sender As Object, e As EventArgs)

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
    Private Sub vS20_LostFocus(sender As Object, e As EventArgs)

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

        Call DATA_SEARCH_VS10()

    End Sub

    Private Sub vS10_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS10.CellDoubleClick

        Select Case e.Column

            Case CDblp(getColumIndex(vS10, "QtyProductOutboundTotail"))
                Call DATA_SEARCH_VS11_PKO()

            Case CDblp(getColumIndex(vS10, "QtyBalance"))
                Call DATA_SEARCH_VS11_PKO_BAL()
            Case CDblp(getColumIndex(vS10, "BoxBalance"))
                Call DATA_SEARCH_VS11_PKO_BAL()
            Case Else
                Call DATA_SEARCH_VS11()
        End Select
    End Sub

#End Region

    
End Class