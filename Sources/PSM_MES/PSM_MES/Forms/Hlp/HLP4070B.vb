Public Class HLP4070B
#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Private wGCODE As String
    Private W7106 As T7106_AREA


    Private formA As Boolean
#End Region

#Region "Form_load"
    Public Function Link_HLP4070B(JobCard As String, cdSubProcess As String, Optional ByVal TAG As String = "") As Boolean
        Link_HLP4070B = False
        Me.Tag = TAG

        Try
            formA = False

            txt_JobCard.Data = JobCard

            If READ_PFK7171(ListCode("SubProcess"), cdSubProcess) Then
                txt_cdSubProcess.Code = D7171.BasicCode
                txt_cdSubProcess.Data = D7171.BasicName
            End If
            Me.Show()
            Me.TopMost = True
            Link_HLP4070B = isudCHK

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
        chk_Detail.Checked = True
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
    Private Sub vS1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS1.CellDoubleClick
        If chk_Detail.Checked = False Then Exit Sub
        Call DATA_SEARCH_VS2()
        Call DATA_SEARCH_VS3()
    End Sub

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False

        vS1.Enabled = False

        DS1 = PrcDS("USP_HLP4070B_SEARCH_VS1", cn, txt_JobCard.Data, txt_cdSubProcess.Code)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS1, DS1, "USP_HLP4070B_SEARCH_VS1", "VS2")
            vS1.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS1, DS1, "USP_HLP4070B_SEARCH_VS1", "VS2")

        If txt_JobCard.Data.Length = 12 Then
            If READ_PFK1312(Strings.Left(txt_JobCard.Data, 9), Strings.Right(txt_JobCard.Data, 3)) Then
                Call VsSizeRangeNew(vS1, "USP_VS_SIZERANGE_SHOESCODEBASE", "SizeQty01", D1312.ShoesCode)
            End If
        End If




        DATA_SEARCH_VS1 = True

        vS1.Enabled = True
    End Function


    Private Function DATA_SEARCH_VS2() As Boolean
        DATA_SEARCH_VS2 = False
        Dim ProdDate As String

        ProdDate = FormatCut(getData(vS1, getColumIndex(vS1, "ProdDate"), vS1.ActiveSheet.ActiveRowIndex))

        VS2.Enabled = False

        DS1 = PrcDS("USP_HLP4070B_SEARCH_VS2", cn, txt_JobCard.Data, ProdDate, txt_cdSubProcess.Code)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(VS2, DS1, "USP_HLP4070B_SEARCH_VS2", "VS2")
            VS2.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(VS2, DS1, "USP_HLP4070B_SEARCH_VS2", "VS2")

        DATA_SEARCH_VS2 = True

        VS2.Enabled = True
    End Function


    Private Function DATA_SEARCH_VS3() As Boolean
        DATA_SEARCH_VS3 = False
        Dim ProdDate As String

        ProdDate = FormatCut(getData(vS1, getColumIndex(vS1, "ProdDate"), vS1.ActiveSheet.ActiveRowIndex))


        VS3.Enabled = False

        DS1 = PrcDS("USP_HLP4070B_SEARCH_VS3", cn, txt_JobCard.Data, ProdDate, txt_cdSubProcess.Code)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(VS3, DS1, "USP_HLP4070B_SEARCH_VS3", "VS3")
            VS3.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(VS3, DS1, "USP_HLP4070B_SEARCH_VS3", "VS3")

        DATA_SEARCH_VS3 = True

        VS3.Enabled = True
    End Function

#End Region

#Region "Event"

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click

        Me.Close()
    End Sub

    Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click

        Me.Close()
    End Sub

    Private Sub chk_Detail_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Detail.CheckedChanged
        If chk_Detail.Checked = True Then
            SplitContainer1.Panel2Collapsed = False
        ElseIf chk_Detail.Checked = False Then
            SplitContainer1.Panel2Collapsed = True
        End If
    End Sub

#End Region

End Class