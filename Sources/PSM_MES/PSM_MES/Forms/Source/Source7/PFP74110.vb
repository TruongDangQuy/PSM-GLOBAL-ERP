Public Class PFP74110
#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Private Form_Close As Boolean

    Private a7411() As T7411_AREA
    Private W7411 As T7411_AREA

#End Region

#Region "Formload"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False)

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

    End Sub
#End Region

#Region "Function"
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



#End Region

#Region "Link_isud"
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
        If sender.Equals(tst_5) Then
            MAIN_JOB05()
        End If
    End Sub
    Private Sub MAIN_JOB01()
        If ISUD7411A.Link_ISUD7411A(1, "000000", Me.Name) = False Then Exit Sub

        Call DATA_SEARCH01()
    End Sub
    Private Sub MAIN_JOB02()
        Dim strSANO As String
        strSANO = getData(Vs1, getColumIndex(Vs1, "Key_IDNO"), Vs1.ActiveSheet.ActiveRowIndex)

        If Trim$(strSANO) = "" Then Exit Sub

        If ISUD7411A.Link_ISUD7411A(2, strSANO, Me.Name) = False Then Exit Sub

    End Sub

    Private Sub MAIN_JOB03()
        Dim strSANO As String
        strSANO = getData(Vs1, getColumIndex(Vs1, "Key_IDNO"), Vs1.ActiveSheet.ActiveRowIndex)

        If Trim$(strSANO) = "" Then Exit Sub
        If ISUD7411A.Link_ISUD7411A(3, strSANO, Me.Name) = False Then Exit Sub

        If LINE_MOVE_DISPLAY01() = False Then
            SPR_CLEAR(Vs1, Vs1.ActiveSheet.ActiveRowIndex, 0, Vs1.ActiveSheet.ActiveRowIndex, Vs1.ActiveSheet.ColumnCount)
            setData(Vs1, getColumIndex(Vs1, "IDNO"), Vs1.ActiveSheet.ActiveRowIndex, "[DELETED]", Color.Red)
        End If
    End Sub


    Private Sub MAIN_JOB04()
        Dim strSANO As String
        strSANO = getData(Vs1, getColumIndex(Vs1, "Key_IDNO"), Vs1.ActiveSheet.ActiveRowIndex)

        If Trim$(strSANO) = "" Then Exit Sub
        If ISUD7411A.Link_ISUD7411A(4, strSANO, Me.Name) = False Then Exit Sub

        If LINE_MOVE_DISPLAY01() = False Then
            SPR_CLEAR(Vs1, Vs1.ActiveSheet.ActiveRowIndex, 0, Vs1.ActiveSheet.ActiveRowIndex, Vs1.ActiveSheet.ColumnCount)
            setData(Vs1, getColumIndex(Vs1, "IDNO"), Vs1.ActiveSheet.ActiveRowIndex, "[DELETED]", Color.Red)
        End If
    End Sub

    Private Sub MAIN_JOB05()
       
    End Sub
#End Region

#Region "DATA_SEARCH"
    Private Function DATA_SEARCH01() As Boolean
        Dim RS01 As DataRow = Nothing

        Vs1.Enabled = False

        DATA_SEARCH01 = False

        If Trim(txt_cdIncharge.Data) = "" Then txt_cdIncharge.Code = ""
        If Trim(txt_cdSITE.Data) = "" Then txt_cdSITE.Code = ""

        DS1 = PrcDS("USP_PFP74110_SEARCH_VS1", cn, txt_Name.Data, txt_cdSITE.Data, txt_cdIncharge.Data, check1.CheckState, check2.CheckState)

        If GetDsRc(DS1) = 0 Then
            Vs1.Enabled = True
            Vs1.ActiveSheet.RowCount = 0
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "USP_PFP74110_SEARCH_VS1", "Vs1")
        DATA_SEARCH01 = True

        Vs1.Enabled = True

    End Function

    Private Function LINE_MOVE_DISPLAY01() As Boolean
        LINE_MOVE_DISPLAY01 = False
        Try
            DS1 = PrcDS("USP_PFP74110_SEARCH_VS1_LINE", cn, getData(Vs1, getColumIndex(Vs1, "Key_IDNO"), Vs1.ActiveSheet.ActiveRowIndex))
            If GetDsRc(DS1) = 0 Then
                Exit Function
            End If

            READ_SPREAD(Vs1, DS1, "USP_PFP74110_SEARCH_VS1_LINE", "Vs1", Vs1.ActiveSheet.ActiveRowIndex)

            LINE_MOVE_DISPLAY01 = True

        Catch ex As Exception
            MsgBoxP("Error!")
        End Try

    End Function

#End Region

#Region "Event"

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub

    Private Sub vS1_GotFocus(sender As Object, e As EventArgs) Handles Vs1.GotFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False, WordConv("INPUT") & "(F5)", WordConv("SEARCH") & "(F6)", WordConv("UPDATE") & "(F7)", WordConv("DELETE") & "(F8)")
    End Sub

    Private Sub vS1_LostFocus(sender As Object, e As EventArgs) Handles Vs1.LostFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False)
    End Sub

    Private Sub vS1_DblClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        If e.Row < 0 Then
            Exit Sub
        Else
            Call MAIN_JOB03()
        End If

    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        Call DATA_SEARCH01()
    End Sub
#End Region


End Class