Public Class PFP26516
#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Private wGCODE As String
    Protected prg As E_PRG

    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load

        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)

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

        DS1 = PrcDS("USP_PFP26516_SEARCH_VS10", cn, SdateEdate.text1, _
                                                       SdateEdate.text2,
                                                       txt_CustomerCode.Code, _
                                                       txt_cdSeason.Code, _
                                                       txt_Line.Data, _
                                                       txt_Article.Data, _
                                                       txt_SLNO.Data,
                                                       txt_PKO.Data, _
                                                       txt_PONO.Data, _
                                                       txt_ColorName.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS10, DS1, "USP_PFP26516_SEARCH_VS10", "vS10")
            vS10.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS10, DS1, "USP_PFP26516_SEARCH_VS10", "vS10")
        DATA_SEARCH_VS10 = True

        vS10.Enabled = True

    End Function

    Private Function DATA_SEARCH_VS11(Optional ByVal xsort As String = "1") As Boolean

        Dim KEY_OrderNo As String
        Dim KEY_OrderNoSeq As String
        Dim KEY_PKONO As String

        DATA_SEARCH_VS11 = False

        vS11.Enabled = False

        KEY_OrderNo = getData(vS10, getColumIndex(vS10, "KEY_OrderNo"), vS10.ActiveSheet.ActiveRowIndex)
        KEY_OrderNoSeq = getData(vS10, getColumIndex(vS10, "KEY_OrderNoSeq"), vS10.ActiveSheet.ActiveRowIndex)
        KEY_PKONO = getData(vS10, getColumIndex(vS10, "KEY_PKONO"), vS10.ActiveSheet.ActiveRowIndex)

        DS1 = PrcDS("USP_PFP26516_SEARCH_vS11", cn, KEY_OrderNo,
                                                    KEY_OrderNoSeq,
                                                    KEY_PKONO)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS11, DS1, "USP_PFP26516_SEARCH_vS11", "vS11")
            vS11.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS11, DS1, "USP_PFP26516_SEARCH_vS11", "vS11")

        Call VsSizeRangeNew_one(vS11, "USP_VS_SIZERANGE_ORDERBASE", getColumIndex(vS11, "SizeQty01"), KEY_OrderNo, KEY_OrderNoSeq)


        DATA_SEARCH_VS11 = True

        vS11.Enabled = True
    End Function


#End Region

#Region "Event"

  
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
        Call DATA_SEARCH_VS11()
    End Sub

#End Region


End Class