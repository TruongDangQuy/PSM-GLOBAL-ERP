Public Class PFP01632

#Region "Variable"
    Private Dsu01 As Long
    Private wGCODE As String
    Private Form_Close As Boolean
    Private FormA As Boolean = False

#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load

        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)

        Me.KeyPreview = True
        Call FORM_INIT()
        Call DATA_INIT()

        FormA = True

    End Sub
    Private Sub PFP17811_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub
    Overrides Sub Function_Event(PressKey As Integer)
        Try
            Select Case PressKey

            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FORM_INIT()

    End Sub

    Private Sub DATA_INIT()
        txt_cdMainProcess.Data = "Stitching"
        txt_cdMainProcess.Code = "003"

        txt_cdMainProcess.Enabled = Not True
        txt_SDATE.Data = Pub.DAT

    End Sub
#End Region

#Region "Function"

#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS10(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS10 = False

        vS10.Enabled = False

        Try
            DS1 = PrcDS("USP_PFP01632_SEARCH_VS10", cn, txt_cdFactory.Code, txt_SDATE.Data)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS10, DS1, "USP_PFP01632_SEARCH_VS10", "vS10")
                Vs10.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS10, DS1, "USP_PFP01632_SEARCH_VS10", "vS10")

            DATA_SEARCH_VS10 = True
            Vs10.Enabled = True
        Catch ex As Exception

        End Try

    End Function

    Private Function DATA_SEARCH_VS11(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS11 = False
        Dim JobCard As String
        Dim cdLineProd As String
        Dim cdMainProcess As String

        JobCard = getData(Vs10, getColumIndex(Vs10, "KEY_JobCard"), Vs10.ActiveSheet.ActiveRowIndex)
        cdLineProd = getData(Vs10, getColumIndex(Vs10, "cdLineProd"), Vs10.ActiveSheet.ActiveRowIndex)
        cdMainProcess = getData(Vs10, getColumIndex(Vs10, "KEY_cdMainProcess"), Vs10.ActiveSheet.ActiveRowIndex)

        vS10.Enabled = False

        Try
            DS1 = PrcDS("USP_PFP01632_SEARCH_VS11", cn, txt_cdFactory.Code, cdMainProcess, cdLineProd, JobCard, txt_SDATE.Data)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS11, DS1, "USP_PFP01632_SEARCH_VS11", "VS11")
                vS10.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS11, DS1, "USP_PFP01632_SEARCH_VS11", "VS11")
            Dim i As Integer
            For i = 0 To vS11.ActiveSheet.RowCount - 1

                If Trim$(getData(vS11, getColumIndex(vS11, "TITILE_S150"), i)) <> "" Then
                    If Trim$(getData(vS11, getColumIndex(vS11, "TITILE_S150"), i)) = "1.SealNo" Then Call SPR_BACKCOLOR(vS11, cSprSealNo, i)
                    If Trim$(getData(vS11, getColumIndex(vS11, "TITILE_S150"), i)) = "2.Prod" Then Call SPR_BACKCOLOR(vS11, cSprProduction, i)
                    If Trim$(getData(vS11, getColumIndex(vS11, "TITILE_S150"), i)) = "5.Balance" Then Call SPR_BACKCOLOR(vS11, cSprBalance, i)

                End If

            Next

            Call VsSizeRangeNew_one(vS11, "USP_PFP01603_SEARCH_VS11_HEAD", getColumIndex(vS11, "QtyTotal"), getData(vS11, getColumIndex(vS11, "OrderNo"), 0), getData(vS11, getColumIndex(vS11, "OrderNoSeq"), 0))

            DATA_SEARCH_VS11 = True

            vS10.Enabled = True

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

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click

        Call DATA_SEARCH_VS10()

    End Sub

    Private Sub Vs10_CellClick(sender As Object, e As CellClickEventArgs) Handles vS10.CellClick

        Call DATA_SEARCH_VS11()

    End Sub


    Private Sub txt_SDATE_m_Textchange(sender As Object, e As EventArgs) Handles txt_SDATE.m_Textchange
        If FormA = True Then
            Call cmd_SEARCH.PerformClick()
        End If
    End Sub

    Private Sub cmd_Closing_Click(sender As Object, e As EventArgs) Handles cmd_Closing.Click
        Msg_Result = MsgBoxP("Do you want to closing all date?", vbYesNo)

        If Msg_Result <> vbYes Then Exit Sub


        Dim Starting As Object
        Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")


        Try
            Call PrcExeNoError("CLOSING_ALL_SUB_PROCESS_PRODUCTION_DATE", cn, Pub.DAT)

        Catch ex As Exception

        Finally
            Starting.close()
        End Try
    End Sub

#End Region

End Class