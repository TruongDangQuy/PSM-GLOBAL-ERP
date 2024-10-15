Public Class PFP40015
#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Private wGCODE As String
    Protected prg As E_PRG

    Private W4073 As New T4073_AREA

    Private Form_Close As Boolean
    Private SizeChk As Boolean = False
#End Region

#Region "load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

        Me.KeyPreview = True
        Call FORM_INIT()
        Call DATA_INIT()

    End Sub
    Private Sub PFP40735_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub
    Private Sub Function_Event(PressKey As Integer)
        Try
            Select Case PressKey
                Case Keys.F5 : Call MAIN_JOB01()
                Case Keys.F6 : Call MAIN_JOB02()
                Case Keys.F7 : Call MAIN_JOB03()
                Case Keys.F8 : Call MAIN_JOB04()
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FORM_INIT()
        SdateEdate.text1 = Pub.DAT
        SdateEdate.text2 = Pub.DAT
    End Sub

    Private Sub DATA_INIT()

    End Sub

#End Region

#Region "Link"

    Private Sub MAIN_JOB01()

    End Sub

    Private Sub MAIN_JOB02()

    End Sub


    Private Sub MAIN_JOB03()

    End Sub

    Private Sub MAIN_JOB04()

    End Sub

#End Region

#Region "search"


    Public Function DATA_SEARCH_VS1() As Boolean
        Dim DateProd As String
        Dim cdFactory As String
        Dim cdLineProd As String
        Dim cdMainProcess As String


        DATA_SEARCH_VS1 = False

        vS1.Enabled = False

        DS1 = PrcDS("USP_PFP40015_SEARCH_vS1", cn, SdateEdate.text1, SdateEdate.text2,
                                                    txt_cdSite.Code, txt_CustPONO.Data, txt_Article.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_SET(vS1, , , , OperationMode.SingleSelect)
            SPR_PRO(vS1, DS1, "USP_PFP40015_SEARCH_vS1", "vS1")
            vS1.Enabled = True
            Exit Function
        End If

        SPR_SET(vS1, , , , OperationMode.SingleSelect)
        SPR_PRO(vS1, DS1, "USP_PFP40015_SEARCH_vS1", "vS1")

        DATA_SEARCH_VS1 = True

        vS1.Enabled = True

    End Function

#End Region

#Region "Function"


#End Region

#Region "Event"
    Private Sub tst_1_Click(sender As Object, e As EventArgs) Handles tst_1.Click, tst_2.Click, tst_3.Click, tst_4.Click, tst_5.Click, tst_6.Click
        If sender.Equals(tst_1) Then
            MAIN_JOB01()
        End If
        If sender.Equals(tst_2) Then
            MAIN_JOB02()
        End If
        If sender.Equals(tst_3) Then
            MAIN_JOB03()
        End If
        If sender.Equals(tst_4) Then
            MAIN_JOB04()
        End If
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        Call DATA_SEARCH_VS1()
    End Sub

    Private Sub Cms_1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_1.ItemClicked
        If Cms_1.Items(0).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB01()

        ElseIf Cms_1.Items(1).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB02()

        ElseIf Cms_1.Items(2).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB03()

        ElseIf Cms_1.Items(3).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB04()
        End If

    End Sub

#End Region

End Class