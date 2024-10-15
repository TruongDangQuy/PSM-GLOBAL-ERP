Public Class PFP01631

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
        txt_cdMainProcess.Data = "F/G Outbound"
        txt_cdMainProcess.Code = "091"

        txt_cdMainProcess.Enabled = Not True
        SdateEdate.text1 = Pub.DAT
        SdateEdate.text2 = Pub.DAT

    End Sub
#End Region

#Region "Function"

#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS10(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS10 = False

        vS10.Enabled = False

        Try
            DS1 = PrcDS("USP_PFP01631_SEARCH_VS10", cn, txt_cdFactory.Code, SdateEdate.text1, SdateEdate.text2)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS10, DS1, "USP_PFP01631_SEARCH_VS10", "vS10")
                Vs10.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS10, DS1, "USP_PFP01631_SEARCH_VS10", "vS10")

            DATA_SEARCH_VS10 = True
            Vs10.Enabled = True
        Catch ex As Exception

        End Try

    End Function

    Private Function DATA_SEARCH_VS11(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS11 = False
        

        Try
           
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


    Private Sub txt_SDATE_m_Textchange(sender As Object, e As EventArgs)
        If FormA = True Then
            Call cmd_SEARCH.PerformClick()
        End If

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