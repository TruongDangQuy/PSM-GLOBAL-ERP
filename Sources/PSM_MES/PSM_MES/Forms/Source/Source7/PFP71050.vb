Public Class PFP71050

#Region "Variable"
    Private Form_Close As Boolean
#End Region

#Region "Formload"
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

    End Sub

    Private Sub DATA_INIT()

    End Sub

#End Region

#Region "Link_ISUD"
    Overrides Sub Function_Event(PressKey As Integer)
        Try
            Select Case PressKey
                Case Keys.F5 : Call MAIN_JOB01()
                Case Keys.F6 : Call MAIN_JOB02()
                Case Keys.F7 : Call MAIN_JOB03()
                Case Keys.F8 : Call MAIN_JOB04()
                Case Keys.F9 : Call MAIN_JOB05()
            End Select
        Catch ex As Exception
        End Try
    End Sub
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

    Private Sub MAIN_JOB01()
        If txt_CustomerCode.Code = "" Then MsgBoxP("Customer Code, Pls!") : Exit Sub
        If ISUD7105A.Link_ISUD7105A(1, txt_CustomerCode.Code, "", Me.Name) = False Then Exit Sub

        Call DATA_SEARCH02()
        DATA_SEARCH01()
    End Sub

    Private Sub MAIN_JOB02()
        Dim CustomerCode As String
        Dim SizeRangeTool As String

        CustomerCode = getData(Vs2, getColumIndex(Vs2, "KEY_CustomerCode"), Vs2.ActiveSheet.ActiveRowIndex)
        SizeRangeTool = getData(Vs2, getColumIndex(Vs2, "KEY_SizeRangeTool"), Vs2.ActiveSheet.ActiveRowIndex)

        If SizeRangeTool = "" Then Exit Sub

        If ISUD7105A.Link_ISUD7105A(2, CustomerCode, SizeRangeTool, Me.Name) = False Then Exit Sub

        Call DATA_SEARCH02()
        DATA_SEARCH01()
    End Sub

    Private Sub MAIN_JOB03()
        Dim CustomerCode As String
        Dim SizeRangeTool As String

        CustomerCode = getData(Vs2, getColumIndex(Vs2, "KEY_CustomerCode"), Vs2.ActiveSheet.ActiveRowIndex)
        SizeRangeTool = getData(Vs2, getColumIndex(Vs2, "KEY_SizeRangeTool"), Vs2.ActiveSheet.ActiveRowIndex)

        If SizeRangeTool = "" Then Exit Sub

        If ISUD7105A.Link_ISUD7105A(3, CustomerCode, SizeRangeTool, Me.Name) = False Then Exit Sub

        Call DATA_SEARCH02()
        DATA_SEARCH01()
    End Sub

    Private Sub MAIN_JOB04()
        Dim CustomerCode As String
        Dim SizeRangeTool As String

        CustomerCode = getData(Vs2, getColumIndex(Vs2, "KEY_CustomerCode"), Vs2.ActiveSheet.ActiveRowIndex)
        SizeRangeTool = getData(Vs2, getColumIndex(Vs2, "KEY_SizeRangeTool"), Vs2.ActiveSheet.ActiveRowIndex)

        If SizeRangeTool = "" Then Exit Sub

        If ISUD7105A.Link_ISUD7105A(4, CustomerCode, SizeRangeTool, Me.Name) = False Then Exit Sub

        Call DATA_SEARCH02()
        DATA_SEARCH01()
    End Sub

    Private Sub MAIN_JOB05()

    End Sub

#End Region

#Region "PFP_SEARCH"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False

        Vs1.Enabled = False

        DS1 = PrcDS("USP_PFP71050_SEARCH_VS1", cn, txt_CustomerCode.Code)

        If GetDsRc(DS1) = 0 Then
            Vs1.Enabled = True
            Vs1.ActiveSheet.RowCount = 0
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "USP_PFP71050_SEARCH_VS1", "Vs1")

        Vs1.Enabled = True
        DATA_SEARCH01 = True
    End Function

    Private Function DATA_SEARCH02() As Boolean
        DATA_SEARCH02 = False

        Try
            If txt_CustomerCode.Code <> "" Then
                DS1 = PrcDS("USP_PFP71050_SEARCH_VS2", cn, txt_CustomerCode.Code)
            Else
                DS1 = PrcDS("USP_PFP71050_SEARCH_VS2", cn, getData(Vs1, getColumIndex(Vs1, "CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex))
            End If

            If GetDsRc(DS1) = 0 Then
                Vs2.ActiveSheet.RowCount = 0
                Exit Function
            End If

            SPR_PRO_NEW(Vs2, DS1, "USP_PFP71050_SEARCH_VS2", "Vs2")

            DATA_SEARCH02 = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH02", vbCritical)
        End Try
    End Function

#End Region

#Region "EVENT"


    'GOTFOCUS
    Private Sub vS1_GotFocus(sender As Object, e As EventArgs) Handles Vs1.GotFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False, WordConv("INSERT") & "(F5)")
    End Sub

    Private Sub vS2_GotFocus(sender As Object, e As EventArgs) Handles Vs2.GotFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)
    End Sub

    'LOSTFOCUS
    Private Sub vS1_LostFocus(sender As Object, e As EventArgs) Handles Vs1.LostFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)
    End Sub

    Private Sub Vs1_KeyUp(sender As Object, e As KeyEventArgs) Handles Vs1.KeyUp
        Select Case e.KeyCode
            Case Keys.Down, Keys.Up, Keys.PageDown, Keys.PageUp
                Call vS1_Click(Vs1.ActiveSheet.ActiveColumnIndex, Vs1.ActiveSheet.ActiveRowIndex)
        End Select
    End Sub

    Private Sub vs2_LostFocus(sender As Object, e As EventArgs) Handles Vs2.LostFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)
    End Sub

    Private Sub vS1_Click(ByVal Col As Long, ByVal Row As Long)
        If Row < 0 Then Exit Sub
        Call DATA_SEARCH02()
    End Sub
    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        Vs1.Enabled = False
        Call DATA_SEARCH02()
        Vs1.Enabled = True
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        If DATA_SEARCH01() = True Then

        End If
    End Sub

#End Region

End Class