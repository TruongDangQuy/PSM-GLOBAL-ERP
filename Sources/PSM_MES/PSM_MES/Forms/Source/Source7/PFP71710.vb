Public Class PFP71710

#Region "Variable"
    Protected prg As E_PRG
    Private Dsu01 As Long
    Private Dsu02 As Long
    Private Dsu03 As Long
    Private a7171() As T7171_AREA
    Private b7171() As T7171_AREA
    Private Form_Close As Boolean

    Private CheckChild As Boolean = False
    Private StrSchild As String
#End Region

#Region "Formload"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)
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
                    Case "001"
                        CheckChild = True
                        StrSchild = ListCode("KwissBuyer")

                    Case "002"
                        CheckChild = True
                        StrSchild = ListCode("GeoxBuyer")

                    Case "QCL"
                        CheckChild = True
                        StrSchild = "QCL"

                    Case "040"
                        CheckChild = True
                        StrSchild = "MAL"

                    Case Else
                        CheckChild = True
                        StrSchild = Strings.Right(Me.PeaceFormType, 3)
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
        If getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex) <> "" Then
            If ISUD7171A.Link_ISUD7171A(1, getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex), getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub
            Call DATA_SEARCH02(getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex))
        Else
            If ISUD7171A.Link_ISUD7171A(1, getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex), "001", Me.Name) = False Then Exit Sub
            Call DATA_SEARCH02(getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex))
        End If

    End Sub

    Private Sub MAIN_JOB02()
        If getData(Vs2, 0, Vs2.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        If ISUD7171A.Link_ISUD7171A(2, getData(Vs2, 0, Vs2.ActiveSheet.ActiveRowIndex), getData(Vs2, 1, Vs2.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub

        If DATA_SEARCH02_LINE(getData(Vs2, 0, Vs2.ActiveSheet.ActiveRowIndex), getData(Vs2, 1, Vs2.ActiveSheet.ActiveRowIndex)) = False Then
            SPR_CLEAR(Vs2, Vs2.ActiveSheet.ActiveRowIndex, 0, Vs2.ActiveSheet.ActiveRowIndex, Vs2.ActiveSheet.ColumnCount)
            setData(Vs2, getColumIndex(Vs2, "BasicName"), Vs2.ActiveSheet.ActiveRowIndex, "[DELETED]", Color.Red)
        End If
        If getData(Vs2, 0, Vs2.ActiveSheet.ActiveRowIndex) = "000" Then DATA_SEARCH01()
    End Sub

    Private Sub MAIN_JOB03()
        If getData(Vs2, 0, Vs2.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        If ISUD7171A.Link_ISUD7171A(3, getData(Vs2, 0, Vs2.ActiveSheet.ActiveRowIndex), getData(Vs2, 1, Vs2.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub

        If DATA_SEARCH02_LINE(getData(Vs2, 0, Vs2.ActiveSheet.ActiveRowIndex), getData(Vs2, 1, Vs2.ActiveSheet.ActiveRowIndex)) = False Then
            Call SPR_CLEAR(Vs2, Vs2.ActiveSheet.ActiveRowIndex, 0, Vs2.ActiveSheet.ActiveRowIndex, Vs2.ActiveSheet.ColumnCount)
            setData(Vs2, getColumIndex(Vs2, "BasicName"), Vs2.ActiveSheet.ActiveRowIndex, "[DELETED]", Color.Red)
        End If

        If getData(Vs2, 0, Vs2.ActiveSheet.ActiveRowIndex) = "000" Then DATA_SEARCH01()
    End Sub

    Private Sub MAIN_JOB04()
        If getData(Vs2, 0, Vs2.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        If ISUD7171A.Link_ISUD7171A(4, getData(Vs2, 0, Vs2.ActiveSheet.ActiveRowIndex), getData(Vs2, 1, Vs2.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub

        If DATA_SEARCH02_LINE(getData(Vs2, 0, Vs2.ActiveSheet.ActiveRowIndex), getData(Vs2, 1, Vs2.ActiveSheet.ActiveRowIndex)) = False Then
            SPR_CLEAR(Vs2, Vs2.ActiveSheet.ActiveRowIndex, 0, Vs2.ActiveSheet.ActiveRowIndex, Vs2.ActiveSheet.ColumnCount)
            setData(Vs2, getColumIndex(Vs2, "BasicName"), Vs2.ActiveSheet.ActiveRowIndex, "[DELETED]", Color.Red)
        End If

        If getData(Vs2, 0, Vs2.ActiveSheet.ActiveRowIndex) = "000" Then DATA_SEARCH01()
    End Sub

    Private Sub MAIN_JOB05()
        If getData(Vs2, 12, Vs2.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
    End Sub

#End Region

#Region "PFP_SEARCH"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False

        Vs1.Enabled = False

        Dim opt_CHK As Long

        If opt_Code.Checked = True Then opt_CHK = 1
        If opt_Name.Checked = True Then opt_CHK = 2

        If CheckChild = False Then DS1 = PrcDS("USP_PFP71710_SEARCH_VS1", cn, "000") Else DS1 = PrcDS("USP_PFP71710_SEARCH_VS1", cn, StrSchild)

        If GetDsRc(DS1) = 0 Then
            Vs1.Enabled = True
            Vs1.ActiveSheet.RowCount = 0
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "USP_PFP71710_SEARCH_VS1", "Vs1")

        Vs1.Enabled = True
        DATA_SEARCH01 = True
    End Function

    Private Function DATA_SEARCH02_LINE(BasicSel As String, BasicCode As String) As Boolean
        Dim DSNEW As New DataSet

        DATA_SEARCH02_LINE = False

        Try
            DSNEW = PrcDS("USP_PFP71710_SEARCH_vS2_LINE", cn, BasicSel, BasicCode)

            If GetDsRc(DSNEW) = 0 Then
                Exit Function
            End If

            READ_SPREAD(Vs2, DSNEW, "USP_PFP71710_SEARCH_VS2", "Vs2", Vs2.ActiveSheet.ActiveRowIndex)

            DATA_SEARCH02_LINE = True
        Catch ex As Exception

        End Try
    End Function
    Private Function DATA_SEARCH02(KSEL As String, Optional KNAME As String = Nothing) As Boolean
        Dim DSNEW As New DataSet

        DATA_SEARCH02 = False

        Try
            DSNEW = PrcDS("USP_PFP71710_SEARCH_VS2", cn, KSEL)

            If GetDsRc(DSNEW) = 0 Then
                Vs2.ActiveSheet.RowCount = 0
                Exit Function
            End If

            SPR_PRO_NEW(Vs2, DSNEW, "USP_PFP71710_SEARCH_VS2", "Vs2")

            DATA_SEARCH02 = True
        Catch ex As Exception

        End Try
    End Function


#End Region

#Region "EVENT"

    Private Sub Vs1_CellClick1(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        If e.Row < 0 Then Exit Sub
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
        Vs1.ActiveSheet.ActiveRowIndex = e.Row

        If getData(Vs1, getColumIndex(Vs1, "BasicCode"), e.Row) = "500" Then
            cmd_Interface.Visible = True
        End If

    End Sub
    Private Sub Vs2_CellClick1(sender As Object, e As CellClickEventArgs) Handles Vs2.CellClick
        If e.Row < 0 Then Exit Sub
        Vs2.ActiveSheet.ActiveColumnIndex = e.Column
        Vs2.ActiveSheet.ActiveRowIndex = e.Row
    End Sub
    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        If getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
        Vs1.Enabled = False
        DATA_SEARCH02(getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex))
        Vs1.Enabled = True
    End Sub

    'GOTFOCUS
    Private Sub vS1_GotFocus(sender As Object, e As EventArgs) Handles Vs1.GotFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False, WordConv("INSERT") & "(F5)")
    End Sub

    Private Sub vS2_GotFocus(sender As Object, e As EventArgs) Handles Vs2.GotFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False, WordConv("INSERT") & "(F5)", WordConv("SEARCH") & "(F6)", WordConv("UPDATE") & "(F7)", WordConv("DELETE") & "(F8)")
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

    Private Sub vs2_LostFocus(sender As Object, e As EventArgs) Handles Vs2.LostFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False, WordConv("INSERT") & "(F5)")
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

    Private Sub btn_Rearrange_Click(sender As Object, e As EventArgs) Handles btn_Rearrange.Click
        Dim i As Integer
        Dim j As Integer = 1
        Try
            For i = 0 To Vs2.ActiveSheet.RowCount - 1

                If READ_PFK7171(getData(Vs2, getColumIndex(Vs2, "Key_BasicSel"), i), getData(Vs2, getColumIndex(Vs2, "Key_BasicCode"), i)) Then
                    D7171.DisplaySeq = j
                    j += 1

                    Call REWRITE_PFK7171(D7171)
                End If

            Next
            Call MsgBoxP("btn_Rearrange", "023")
        Catch ex As Exception

        End Try



    End Sub

    Private Sub cmd_Interface_Click(sender As Object, e As EventArgs) Handles cmd_Interface.Click
        Try
            If getData(Vs1, getColumIndex(Vs1, "BasicCode"), Vs1.ActiveSheet.ActiveRowIndex) = "500" Then

                If READ_PFK7171("500", getData(Vs2, getColumIndex(Vs2, "BasicCode"), Vs2.ActiveSheet.ActiveRowIndex)) Then
                    Call HLPACC.Link_HLPACC(D7171.ForeignName1)
                End If


            End If
        Catch ex As Exception

        End Try
    End Sub
End Class