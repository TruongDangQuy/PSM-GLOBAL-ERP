Public Class PFP01698

#Region "Variable"

    Private Dsu01 As Long     'Data Su
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

    Private Sub FORM_INIT()
        txt_sDate.Data = System_Date_8()
        txt_sDate.Visible = True

        Call DATA_SEARCH_vS1()
    End Sub

    Private Sub DATA_INIT()

    End Sub
#End Region

#Region "Function"

    Private Sub MAIN_JOB01()

    End Sub
    Private Sub MAIN_JOB02()

    End Sub

    Private Sub MAIN_JOB03()

    End Sub

    Private Sub MAIN_JOB04()

    End Sub


    Private Sub MAIN_JOB12()

    End Sub

    Private Sub MAIN_JOB13()

    End Sub

    Private Sub MAIN_JOB14()

    End Sub

    Private Sub MAIN_JOB05()

    End Sub


#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_vS1() As Boolean
        DATA_SEARCH_vS1 = False
        Try
            vS1.Enabled = False

            DS1 = PrcDS("USP_PFP01698_SEARCH_vS1", cn, txt_sDate.Data, txt_cdFactory.Code)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS1, DS1, "USP_PFP01698_SEARCH_vS1", "vS1")
                vS1.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS1, DS1, "USP_PFP01698_SEARCH_vS1", "vS1")


            DATA_SEARCH_vS1 = True

            vS1.Enabled = True
        Catch ex As Exception
            MsgBox("DATA_SEARCH_vS1")
        Finally
            vS1.Enabled = True
        End Try
    End Function

    Private Function DATA_SEARCH_vS2(cdSubProcess As String) As Boolean
        DATA_SEARCH_vS2 = False
        Try
            vS2.Enabled = False

            DS1 = PrcDS("USP_PFP01698_SEARCH_vS2", cn, txt_sDate.Data, _
                       txt_cdFactory.Code, cdSubProcess)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS2, DS1, "USP_PFP01698_SEARCH_vS2", "vS2")
                vS2.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS2, DS1, "USP_PFP01698_SEARCH_vS2", "vS2")


            DATA_SEARCH_vS2 = True

            vS2.Enabled = True
        Catch ex As Exception
            MsgBox("DATA_SEARCH_vS2")
        Finally
            vS2.Enabled = True
        End Try
    End Function

#End Region

#Region "Function"

#End Region

#Region "Event"
    Private Sub ptc_1_DoubleClick(sender As Object, e As EventArgs)

        Call cmd_SEARCH.PerformClick()

    End Sub
    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        Call DATA_SEARCH_vS1()
    End Sub

    Private Sub vS1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS1.CellDoubleClick
        Dim cdSubProcess As String
        cdSubProcess = getData(vS1, getColumIndex(vS1, "KEY_cdSubProcess"), e.Row)

        If e.ColumnHeader = False Then Call DATA_SEARCH_vS2(cdSubProcess)

    End Sub


#End Region


  
End Class