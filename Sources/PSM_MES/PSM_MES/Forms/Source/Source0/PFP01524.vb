Public Class PFP01524

#Region "Variable"
    Private Dsu01 As Long
    Private wGCODE As String
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
        Me.Tag = Me.Name

        txt_cdMainProcess.Code = "102"

        If READ_PFK7171(ListCode("MainProcess"), txt_cdMainProcess.Code) Then
            txt_cdMainProcess.Data = D7171.BasicName
        End If

        txt_cdMainProcess.Enabled = Not True
        txt_SDATE.Data = Pub.DAT
    End Sub
#End Region

#Region "Function"

#End Region

#Region "Data_search"

    Private Function DATA_SEARCH_VS10(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS10 = False

        Dim i As Integer
        Dim X1 As String
        Dim X2 As String

        Vs10.Enabled = False
        Try

            DS1 = PrcDS("USP_PFP01524_SEARCH_VS10", cn, txt_cdFactory.Code, txt_SDATE.Data)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs10, DS1, "USP_PFP01524_SEARCH_VS10", "VS10")
                Vs10.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs10, DS1, "USP_PFP01524_SEARCH_VS10", "VS10")

            DATA_SEARCH_VS10 = True
            Vs10.Enabled = True
        Catch ex As Exception

        End Try

    End Function

    Private Function DATA_SEARCH_VS20(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS20 = False
        Dim i As Integer
        Dim X1 As String
        Dim X2 As String

        vS20.Enabled = False
        Try
            DS1 = PrcDS("USP_PFP01524_SEARCH_VS20", cn, txt_cdFactory.Code, txt_SDATE.Data)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS20, DS1, "USP_PFP01524_SEARCH_VS20", "VS20")
                vS20.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS20, DS1, "USP_PFP01524_SEARCH_VS20", "VS20")

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
            DS1 = PrcDS("USP_PFP01524_SEARCH_VS30", cn, txt_cdFactory.Code, txt_SDATE.Data)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS30, DS1, "USP_PFP01524_SEARCH_VS30", "VS30")
                vS30.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS30, DS1, "USP_PFP01524_SEARCH_VS30", "VS30")

            vS30.Enabled = True

            DATA_SEARCH_VS30 = True

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

    Private Sub txt_SDATE_m_Textchange(sender As Object, e As EventArgs) Handles txt_SDATE.m_Textchange
        Call cmd_SEARCH.PerformClick()
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