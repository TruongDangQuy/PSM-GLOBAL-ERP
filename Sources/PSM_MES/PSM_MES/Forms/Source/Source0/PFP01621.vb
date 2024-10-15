Public Class PFP01621

#Region "Variable"
    Private Dsu01 As Long
    Private wGCODE As String
    Private Form_Close As Boolean
    Private wSubProcess As String

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
        txt_cdMainProcess.Data = "SetBalance 2"
        txt_cdMainProcess.Code = "013"

        txt_cdMainProcess.Enabled = Not True

        SdateEdate.text1 = Mid(System_Date_8, 1, 6) & "01"
        SdateEdate.text2 = System_Date_8()

    End Sub
#End Region

#Region "Function"

#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS10(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS10 = False

        Dim xTemp1 As String
        Dim xTemp2 As String
        Dim i As Integer

        Dim x1 As Double
        Dim x2 As Double
        Dim x3 As Double
        Dim x4 As Double

        Dim XL1 As String
        Dim XL2 As String
        Vs10.Enabled = False
        Try
            DS1 = PrcDS("USP_PFP01621_SEARCH_VS10", cn, txt_cdFactory.Code, txt_cdMainProcess.Code, SdateEdate.text1, SdateEdate.text2)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs10, DS1, "USP_PFP01621_SEARCH_VS10", "vS10")
                Vs10.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs10, DS1, "USP_PFP01621_SEARCH_VS10", "vS10")

            xTemp1 = ""
            xTemp2 = ""
            x1 = 0 : x2 = 0 : x3 = 0 : x4 = 0

            For i = 1 To Vs10.ActiveSheet.RowCount - 1
                xTemp1 = (getData(Vs10, getColumIndex(Vs10, "cdMainProcessName"), i) & _
                        getData(Vs10, getColumIndex(Vs10, "cdSeasonName"), i) & _
                        getData(Vs10, getColumIndex(Vs10, "CustomerName"), i) & _
                        getData(Vs10, getColumIndex(Vs10, "cdSpecStateName"), i) & _
                        getData(Vs10, getColumIndex(Vs10, "SlNoD"), i))

                If xTemp1 <> xTemp2 Then
                    x1 = x1 + getData(Vs10, getColumIndex(Vs10, "QtyOrder"), i)
                    x2 = x2 + getData(Vs10, getColumIndex(Vs10, "QtyStitching"), i)
                    x3 = x3 + getData(Vs10, getColumIndex(Vs10, "QtyAssembly"), i)
                    x4 = x4 + getData(Vs10, getColumIndex(Vs10, "QtyPacking"), i)

                    Call setData(Vs10, getColumIndex(Vs10, "QtyOrder"), 0, x1)
                    Call setData(Vs10, getColumIndex(Vs10, "QtyStitching"), 0, x2)
                    Call setData(Vs10, getColumIndex(Vs10, "QtyAssembly"), 0, x3)
                    Call setData(Vs10, getColumIndex(Vs10, "QtyPacking"), 0, x4)

                End If

                xTemp2 = (getData(Vs10, getColumIndex(Vs10, "cdMainProcessName"), 1) & _
                        getData(Vs10, getColumIndex(Vs10, "cdSeasonName"), 1) & _
                        getData(Vs10, getColumIndex(Vs10, "CustomerName"), 1) & _
                        getData(Vs10, getColumIndex(Vs10, "cdSpecStateName"), 1) & _
                        getData(Vs10, getColumIndex(Vs10, "SlNoD"), 1))

                ''-------------------------------------------------------------------
                XL1 = getData(Vs10, getColumIndex(Vs10, "QtyProductionL"), i)
                XL2 = getData(Vs10, getColumIndex(Vs10, "QtyProductionR"), i)

                If Trim$(getData(Vs10, getColumIndex(Vs10, "cdLineProdName"), i)) <> "" Then
                    If XL1 <> XL2 Then
                        Call SPR_BACKCOLORCELL(Vs10, Color.Red, getColumIndex(Vs10, "QtyProductionL"), i)
                        Call SPR_BACKCOLORCELL(Vs10, Color.Red, getColumIndex(Vs10, "QtyProductionR"), i)
                    End If
                End If

            Next

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
        Dim DateProduction As String

        JobCard = getData(Vs10, getColumIndex(Vs10, "KEY_JobCard"), Vs10.ActiveSheet.ActiveRowIndex)
        cdLineProd = getData(Vs10, getColumIndex(Vs10, "cdLineProd"), Vs10.ActiveSheet.ActiveRowIndex)
        cdMainProcess = getData(Vs10, getColumIndex(Vs10, "KEY_cdMainProcess"), Vs10.ActiveSheet.ActiveRowIndex)
        DateProduction = getData(Vs10, getColumIndex(Vs10, "KEY_DateProduction"), Vs10.ActiveSheet.ActiveRowIndex)

        vS11.Enabled = True
        Try
            DS1 = PrcDS("USP_PFP01621_SEARCH_VS11", cn, txt_cdFactory.Code, cdMainProcess, cdLineProd, JobCard, DateProduction)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS11, DS1, "USP_PFP01621_SEARCH_VS11", "VS11")
                vS11.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS11, DS1, "USP_PFP01621_SEARCH_VS11", "VS11")

            Dim i As Integer
            For i = 0 To vS11.ActiveSheet.RowCount - 1
                If Trim$(getData(vS11, getColumIndex(vS11, "Dseq"), i)) <> "" Then
                    If Trim$(getData(vS11, getColumIndex(vS11, "Dseq"), i)) = "01" Then Call SPR_BACKCOLOR(vS11, cSprSealNo, i)

                    If Trim$(getData(vS11, getColumIndex(vS11, "Dseq"), i)) = "06" Then Call SPR_BACKCOLOR(vS11, cSprProduction, i)
                    If Trim$(getData(vS11, getColumIndex(vS11, "Dseq"), i)) = "08" Then Call SPR_BACKCOLOR(vS11, cSprBalance, i)
                    If Trim$(getData(vS11, getColumIndex(vS11, "Dseq"), i)) = "09" Then Call SPR_BACKCOLOR(vS11, cSprProduction, i)
                    If Trim$(getData(vS11, getColumIndex(vS11, "Dseq"), i)) = "11" Then Call SPR_BACKCOLOR(vS11, cSprBalance, i)
                    If Trim$(getData(vS11, getColumIndex(vS11, "Dseq"), i)) = "12" Then Call SPR_BACKCOLOR(vS11, cSprProduction, i)
                    If Trim$(getData(vS11, getColumIndex(vS11, "Dseq"), i)) = "14" Then Call SPR_BACKCOLOR(vS11, cSprBalance, i)
                    If Trim$(getData(vS11, getColumIndex(vS11, "Dseq"), i)) = "15" Then Call SPR_BACKCOLOR(vS11, cSprSetBalance, i)
                End If
            Next

            Call VsSizeRangeNew_one(vS11, "USP_PFP01621_SEARCH_VS11_HEAD", getColumIndex(vS11, "QtyTotal"), getData(vS11, getColumIndex(vS11, "OrderNo"), 0), getData(vS11, getColumIndex(vS11, "OrderNoSeq"), 0))

            DATA_SEARCH_VS11 = True

            vS11.Enabled = True

        Catch ex As Exception

        End Try

    End Function

    Private Function DATA_SEARCH_VS20(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS20 = False

        Dim i As Integer
        Dim XL1 As String
        Dim XL2 As String

        vS20.Enabled = False
        Try
            DS1 = PrcDS("USP_PFP01621_SEARCH_VS20", cn, txt_cdFactory.Code, txt_cdMainProcess.Code, SdateEdate.text1, SdateEdate.text2)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS20, DS1, "USP_PFP01621_SEARCH_VS20", "VS20")
                vS20.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS20, DS1, "USP_PFP01621_SEARCH_VS20", "VS20")

            For i = 1 To vS20.ActiveSheet.RowCount - 1
                XL1 = getData(vS20, getColumIndex(vS20, "QtyProductionL"), i)
                XL2 = getData(vS20, getColumIndex(vS20, "QtyProductionR"), i)

                If Trim$(getData(Vs10, getColumIndex(vS20, "cdLineProdName"), i)) <> "" Then
                    If XL1 <> XL2 Then
                        Call SPR_BACKCOLORCELL(vS20, Color.Red, getColumIndex(vS20, "QtyProductionL"), i)
                        Call SPR_BACKCOLORCELL(vS20, Color.Red, getColumIndex(vS20, "QtyProductionR"), i)
                    End If
                End If
            Next


            DATA_SEARCH_VS20 = True

            vS20.Enabled = True

        Catch ex As Exception

        End Try

    End Function

    Private Function DATA_SEARCH_VS30(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS30 = False

        Dim xTotal As Double
        Dim xPercent As Double
        Dim xPercent_T As Double
        Dim i As Double

        vS30.Enabled = False
        Try
            DS1 = PrcDS("USP_PFP01621_SEARCH_VS30", cn, txt_cdFactory.Code, txt_cdMainProcess.Code, SdateEdate.text1, SdateEdate.text2)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS30, DS1, "USP_PFP01621_SEARCH_VS30", "VS30")
                vS30.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS30, DS1, "USP_PFP01621_SEARCH_VS30", "VS30")

            xTotal = getData(vS30, getColumIndex(vS30, "F_PROD_Total_Qty"), 0)

            For i = 1 To vS30.ActiveSheet.RowCount - 1
                If getData(vS30, getColumIndex(vS30, "F_PROD_Total_Qty"), i) > 0 Then
                    xPercent = (getData(vS30, getColumIndex(vS30, "F_PROD_Total_Qty"), i) / xTotal) * 100
                    Call setData(vS30, getColumIndex(vS30, "F_PROD_Total_Per"), i, xPercent)

                    xPercent_T = xPercent_T + xPercent
                    Call setData(vS30, getColumIndex(vS30, "F_PROD_Total_Per"), 0, xPercent_T)
                End If
            Next

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


    Private Sub ptc_Main_DoubleClick(sender As Object, e As EventArgs) Handles ptc_1.DoubleClick
        If ptc_1.SelectedIndex = -1 Then Exit Sub

        Select Case ptc_1.SelectedIndex
            Case 0 : Call DATA_SEARCH_VS10()
            Case 1 : Call DATA_SEARCH_VS20()
            Case 2 : Call DATA_SEARCH_VS30()
        End Select

    End Sub


    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click

        If ptc_1.SelectedIndex = 0 Then Call DATA_SEARCH_VS10()
        If ptc_1.SelectedIndex = 1 Then Call DATA_SEARCH_VS20()
        If ptc_1.SelectedIndex = 2 Then Call DATA_SEARCH_VS30()
    End Sub

    Private Sub HLP8986A_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If ptc_1.TabCount < 1 Then Exit Sub
        If Me.Width > 30 Then
            ptc_1.ItemSize = New Size((Me.Width - 30) / ptc_1.TabCount, 25)
        End If
    End Sub

    Private Sub txt_SDATE_m_Textchange(sender As Object, e As EventArgs)
        Call cmd_SEARCH.PerformClick()
    End Sub
    Private Sub Vs10_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs10.CellClick
        Call DATA_SEARCH_VS11()
    End Sub

    Private Sub cmd_Closing_Click(sender As Object, e As EventArgs)
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