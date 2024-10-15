Public Class HLP4070C
#Region "Variable"


    Private formA As Boolean
#End Region

#Region "Form_load"
    Public Function Link_HLP4070C(Job As String, JobCard As String, cdSubProcess As String, ProdDate As String, Optional ByVal TAG As String = "") As Boolean
        Link_HLP4070C = False
        Me.Tag = TAG

        Try
            formA = False

            txt_JobCard.Data = JobCard
            txt_ProdDate.Data = ProdDate
            txt_Job.Data = Job

            If READ_PFK7171(ListCode("SubProcess"), cdSubProcess) Then
                txt_cdSubProcess.Code = D7171.BasicCode
                txt_cdSubProcess.Data = D7171.BasicName
            End If

            Me.ShowDialog()
            Link_HLP4070C = isudCHK

        Catch ex As Exception
            Call MsgBoxP(ex.Message.ToString, WordConv("YARN PROCESSING"))
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

        txt_cdSubProcess.Enabled = False
        txt_JobCard.Enabled = False
        txt_ProdDate.Enabled = False

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

        DS1 = PrcDS("USP_HLP4070C_SEARCH_VS1", cn, txt_ProdDate.Code, txt_JobCard.Data, txt_cdSubProcess.Code)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS1, DS1, "USP_HLP4070C_SEARCH_VS1", "VS1")
            vS1.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS1, DS1, "USP_HLP4070C_SEARCH_VS1", "VS1")

        Call VsSizeRangeNew(vS1, "USP_VS_SIZERANGE_JOBBASE_STOCKFIT", "SizeQty01", txt_JobCard.Data)

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