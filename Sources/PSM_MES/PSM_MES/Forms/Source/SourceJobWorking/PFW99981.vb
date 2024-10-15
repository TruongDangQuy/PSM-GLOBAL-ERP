Public Class PFW99981

#Region "Variable"
    Protected prg As E_PRG
    Private Dsu01 As Long
    Private Dsu02 As Long
    Private Dsu03 As Long
    Private a9998() As DIM_W9998.T9998_AREA
    Private b9998() As DIM_W9998.T9998_AREA
    Private Form_Close As Boolean

    Private CheckChild As Boolean = False
    Private StrSchild As String
#End Region

#Region "Formload"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False, WordConv("INSERT") & "(F5)")

        Me.KeyPreview = True
        Call FORM_INIT()
        Call DATA_INIT()

    End Sub

    Private Sub Me_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub

    Private Sub FORM_INIT()

    End Sub
    Private Sub DATA_INIT()
        Try
            If Me.PeaceFormType.Contains("_") Then
                Select Case Strings.Right(Me.PeaceFormType, 3)

                End Select

            End If

        Catch ex As Exception

        End Try



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

    Private Sub MAIN_JOB01()   ' Insert
        If ISUD9998A.Link_ISUD9998A(1, "", "", Me.Name) = False Then Exit Sub
        Call DATA_SEARCH01()
    End Sub

    Private Sub MAIN_JOB02()   ' Search

        If getData(Vs1, getColumIndex(Vs1, "KEY_PageDate"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        If ISUD9998A.Link_ISUD9998A(2, getData(Vs1, getColumIndex(Vs1, "KEY_PageDate"), Vs1.ActiveSheet.ActiveRowIndex), getData(Vs1, getColumIndex(Vs1, "KEY_PageSeq"), Vs1.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub

        Call DATA_SEARCH01()

    End Sub

    Private Sub MAIN_JOB03()   ' Update
        If getData(Vs1, getColumIndex(Vs1, "KEY_PageDate"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        If ISUD9998A.Link_ISUD9998A(3, getData(Vs1, getColumIndex(Vs1, "KEY_PageDate"), Vs1.ActiveSheet.ActiveRowIndex), getData(Vs1, getColumIndex(Vs1, "KEY_PageSeq"), Vs1.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub

        Call DATA_SEARCH01()
    End Sub

    Private Sub MAIN_JOB04()   ' Delete

        If getData(Vs1, getColumIndex(Vs1, "KEY_PageDate"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        If ISUD9998A.Link_ISUD9998A(4, getData(Vs1, getColumIndex(Vs1, "KEY_PageDate"), Vs1.ActiveSheet.ActiveRowIndex), getData(Vs1, getColumIndex(Vs1, "KEY_PageSeq"), Vs1.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub

        Call DATA_SEARCH01()
    End Sub

#End Region

#Region "PFP_SEARCH"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False

        Vs1.Enabled = False

        Dim opt_CHK As Long
        Dim CHK1 As String = "2"
        Dim CHK2 As String = "2"

        'Dim opt_CHK As Long

        If opt_Code.Checked = True Then opt_CHK = 1
        If opt_Name.Checked = True Then opt_CHK = 2
        If opt_SEL0.Checked = True Then CHK1 = "1"
        If opt_SEL1.Checked = True Then CHK2 = "1"

        DS1 = PrcDS("PSM_USP_PFW99981_SEARCH_VS1", cn, CHK1, CHK2, opt_CHK)

        If GetDsRc(DS1) = 0 Then
            Vs1.Enabled = True
            Vs1.ActiveSheet.RowCount = 0
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "PSM_USP_PFW99981_SEARCH_VS1", "Vs1")

        Vs1.Enabled = True
        DATA_SEARCH01 = True
    End Function


#End Region

#Region "EVENT"

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        If DATA_SEARCH01() = True Then
        End If
    End Sub

    Private Sub vS1_GotFocus(sender As Object, e As EventArgs) Handles Vs1.GotFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False, WordConv("INSERT") & "(F5)", WordConv("SEARCH") & "(F6)", WordConv("UPDATE") & "(F7)", WordConv("DELETE") & "(F8)")
    End Sub

    Private Sub vS1_LostFocus(sender As Object, e As EventArgs) Handles Vs1.LostFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False, WordConv("INSERT") & "(F5)")
    End Sub

#End Region

End Class