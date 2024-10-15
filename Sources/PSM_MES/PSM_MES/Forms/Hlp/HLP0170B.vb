Public Class HLP0170B
#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Private wGCODE As String
    Private W7106 As T7106_AREA


    Private formA As Boolean
#End Region

#Region "Form_load"
    Public Function Link_HLP0170B(JobCard As String, cdMainProcess As String, Optional ByVal TAG As String = "") As Boolean
        Link_HLP0170B = False
        Me.Tag = TAG

        Try
            formA = False

            txt_JobCard.Data = JobCard

            If READ_PFK7171(ListCode("MainProcess"), cdMainProcess) Then
                txt_cdMainProcess.Code = D7171.BasicCode
                txt_cdMainProcess.Data = D7171.BasicName
                txt_cdMainProcess.Enabled = False
            End If

            Me.ShowDialog()
            Link_HLP0170B = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))
        End Try
    End Function

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True
        Call FORM_INIT()
        Call DATA_INIT()
        Call DATA_SEARCH_VS1()

    End Sub
    Private Sub Me_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub
    Private Sub FORM_INIT()
    End Sub

    Private Sub DATA_INIT()

    End Sub
    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click

        Try

            Call DATA_SEARCH_VS1()
        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "Function"


#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False

        vS1.Enabled = False

        DS1 = PrcDS("USP_HLP0170B_SEARCH_VS1", cn, txt_JobCard.Data, txt_cdMainProcess.Code)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS1, DS1, "USP_HLP0170B_SEARCH_VS1", "VS2")
            vS1.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS1, DS1, "USP_HLP0170B_SEARCH_VS1", "VS2")
        Call VsSizeRangeNew(vS1, "USP_VS_SIZERANGE_ITEMBASE", "SizeQty01", Strings.Left(txt_JobCard.Data, 9))

        DATA_SEARCH_VS1 = True

        vS1.Enabled = True
    End Function

#End Region

#Region "Event"
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click

        Me.Close()
    End Sub

    Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click

        Me.Close()
    End Sub

#End Region


    

End Class