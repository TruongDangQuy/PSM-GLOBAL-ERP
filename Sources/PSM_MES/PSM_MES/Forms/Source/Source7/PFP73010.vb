Public Class PFP73010

#Region "Variable"
    Protected prg As E_PRG
    Private Dsu01 As Long
    Private Dsu02 As Long
    Private Dsu03 As Long

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
        Dim MaterialBOMCode As String = ""

        If ISUD7301A.Link_ISUD7301A(1, MaterialBOMCode, Me.Name) = False Then Exit Sub

        Call DATA_SEARCH02(getData(Vs1, getColumIndex(Vs1, "KEY_MaterialBOMCode"), Vs1.ActiveSheet.ActiveRowIndex))
        DATA_SEARCH01()
    End Sub

    Private Sub MAIN_JOB02()
        If getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        If ISUD7301A.Link_ISUD7301A(2, getData(Vs1, getColumIndex(Vs1, "KEY_MaterialBOMCode"), Vs1.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub

        Call DATA_SEARCH02(getData(Vs1, getColumIndex(Vs1, "KEY_MaterialBOMCode"), Vs1.ActiveSheet.ActiveRowIndex))

    End Sub

    Private Sub MAIN_JOB03()
        If getData(Vs1, getColumIndex(Vs1, "KEY_MaterialBOMCode"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        If ISUD7301A.Link_ISUD7301A(3, getData(Vs1, getColumIndex(Vs1, "KEY_MaterialBOMCode"), Vs1.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub

        Call DATA_SEARCH02(getData(Vs1, getColumIndex(Vs1, "KEY_MaterialBOMCode"), Vs1.ActiveSheet.ActiveRowIndex))
        DATA_SEARCH01()
    End Sub

    Private Sub MAIN_JOB04()
        If getData(Vs1, getColumIndex(Vs1, "KEY_MaterialBOMCode"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        If ISUD7301A.Link_ISUD7301A(4, getData(Vs1, getColumIndex(Vs1, "KEY_MaterialBOMCode"), Vs1.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub

        Call DATA_SEARCH02(getData(Vs1, getColumIndex(Vs1, "KEY_MaterialBOMCode"), Vs1.ActiveSheet.ActiveRowIndex))
        DATA_SEARCH01()
    End Sub

    Private Sub MAIN_JOB05()
        If getData(Vs1, 12, Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
    End Sub

#End Region

#Region "PFP_SEARCH"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False

        Vs1.Enabled = False
        Vs2.ActiveSheet.RowCount = 0

        DS1 = PrcDS("USP_PFP73010_SEARCH_VS1", cn, txt_BOMName.Data, txt_CustomerCode.Code, chk_CheckUse1.CheckState, chk_CheckUse2.CheckState)

        If GetDsRc(DS1) = 0 Then
            Vs1.Enabled = True
            Vs1.ActiveSheet.RowCount = 0
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "USP_PFP73010_SEARCH_VS1", "Vs1")

        Vs1.Enabled = True
        DATA_SEARCH01 = True
    End Function

    Private Function DATA_SEARCH02(KSEL As String, Optional KNAME As String = Nothing) As Boolean

        DATA_SEARCH02 = False

        Try
            DS1 = PrcDS("USP_PFP73010_SEARCH_VS2", cn, KSEL)

            If GetDsRc(DS1) = 0 Then
                Vs2.ActiveSheet.RowCount = 0
                Exit Function
            End If

            SPR_PRO_NEW(Vs2, DS1, "USP_PFP73010_SEARCH_VS2", "Vs2")
            DATA_SEARCH02 = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH02", vbCritical)
        End Try
    End Function

#End Region

#Region "EVENT"
    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        Vs1.Enabled = False
        Call DATA_SEARCH02(getData(Vs1, getColumIndex(Vs1, "KEY_MaterialBOMCode"), e.Row))
        Vs1.Enabled = True
    End Sub

    'GOTFOCUS
    Private Sub vS1_GotFocus(sender As Object, e As EventArgs) Handles Vs1.GotFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False, WordConv("INSERT") & "(F5)")
    End Sub

    'LOSTFOCUS
    Private Sub vS1_LostFocus(sender As Object, e As EventArgs) Handles Vs1.LostFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False, WordConv("INSERT") & "(F5)")
    End Sub

    Private Sub Vs1_KeyUp(sender As Object, e As KeyEventArgs) Handles Vs1.KeyUp
        Select Case e.KeyCode
            Case Keys.Down, Keys.Up, Keys.PageDown, Keys.PageUp
                Call vS1_Click(Vs1.ActiveSheet.ActiveColumnIndex, Vs1.ActiveSheet.ActiveRowIndex)
        End Select
    End Sub

    Private Sub vS1_Click(ByVal Col As Long, ByVal Row As Long)
        If Row < 0 Then Exit Sub
        If getData(Vs1, 12, Row) = "" Then Exit Sub
        Call DATA_SEARCH02(getData(Vs1, 0, Row), getData(Vs1, 1, Row))
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        If DATA_SEARCH01() = True Then
            '   Call DATA_SEARCH02(a7171(getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex)).KCODE, a7171(getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex)).KNAME)
        End If
    End Sub

#End Region


End Class