Public Class PFP71550
#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Private Form_Close As Boolean

    Private a7155() As T7155_AREA
    Private W7155 As T7155_AREA


    Private Enum colvS1
        SANO = 1
        NAME = 2
        BUSEO = 3
        JIKUI = 4
        SITE = 5
        NAT = 6
        SOSOK = 7
        EMPL = 8
        ABC = 9
    End Enum
#End Region

#Region "Formload"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False)

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
        If ISUD7155A.Link_ISUD7155A_AUTO(1, txt_cdFactory.Code, txt_cdSubProcess.Code, Me.Name) = False Then Exit Sub

        Call DATA_SEARCH_VS1()
    End Sub

    Private Sub MAIN_JOB02()
        If getData(Vs1, getColumIndex(Vs1, "KEY_MachineCode"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
        If ISUD7155A.Link_ISUD7155A(2, getData(Vs1, getColumIndex(Vs1, "KEY_MachineCode"), Vs1.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub
    End Sub

    Private Sub MAIN_JOB03()
        If getData(Vs1, getColumIndex(Vs1, "KEY_MachineCode"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
        If ISUD7155A.Link_ISUD7155A(3, getData(Vs1, getColumIndex(Vs1, "KEY_MachineCode"), Vs1.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub

        If LINE_MOVE_DISPLAY01() = False Then
            SPR_CLEAR(Vs1, Vs1.ActiveSheet.ActiveRowIndex, 0, Vs1.ActiveSheet.ActiveRowIndex, Vs1.ActiveSheet.ColumnCount)
            setData(Vs1, getColumIndex(Vs1, "cdSubProcessName"), Vs1.ActiveSheet.ActiveRowIndex, "[DELETED]", Color.Red)
        End If
    End Sub

    Private Sub MAIN_JOB04()
        If getData(Vs1, getColumIndex(Vs1, "KEY_MachineCode"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
        If ISUD7155A.Link_ISUD7155A(4, getData(Vs1, getColumIndex(Vs1, "KEY_MachineCode"), Vs1.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub

        If LINE_MOVE_DISPLAY01() = False Then
            SPR_CLEAR(Vs1, Vs1.ActiveSheet.ActiveRowIndex, 0, Vs1.ActiveSheet.ActiveRowIndex, Vs1.ActiveSheet.ColumnCount)
            setData(Vs1, getColumIndex(Vs1, "cdSubProcessName"), Vs1.ActiveSheet.ActiveRowIndex, "[DELETED]", Color.Red)
        End If
    End Sub

    Private Sub MAIN_JOB05()
        If getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

    End Sub
#End Region

#Region "DATA_SEARCH"
    Private Function DATA_SEARCH_VS1() As Boolean
        Vs1.Enabled = False

        DATA_SEARCH_VS1 = False
        Try

            'If Trim(txt_cdFactory.Data) = "" Then txt_cdFactory.Code = ""

            DS1 = PrcDS("USP_PFP71550_SEARCH_VS1", cn, txt_cdFactory.Code, txt_cdSubProcess.Code, txt_Name.Data, check1.CheckState, check2.CheckState)

            If GetDsRc(DS1) = 0 Then
                Vs1.Enabled = True
                Vs1.ActiveSheet.RowCount = 0
                Exit Function
            End If

            SPR_PRO_NEW(Vs1, DS1, "USP_PFP71550_SEARCH_VS1", "Vs1")
            DATA_SEARCH_VS1 = True

            Vs1.Enabled = True

        Catch ex As Exception
            MsgBoxP(ex.Message)
        End Try
    End Function

    Private Function LINE_MOVE_DISPLAY01() As Boolean
        LINE_MOVE_DISPLAY01 = False

        Try
            DS1 = PrcDS("USP_PFP71550_SEARCH_VS1_LINE", cn, getData(Vs1, getColumIndex(Vs1, "Key_MachineCode"), Vs1.ActiveSheet.ActiveRowIndex))


            If GetDsRc(DS1) = 0 Then
                Exit Function
            End If

            READ_SPREAD(Vs1, DS1, "USP_PFP71550_SEARCH_VS1", "Vs1", Vs1.ActiveSheet.ActiveRowIndex)

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
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)
    End Sub

    Private Sub vS1_LostFocus(sender As Object, e As EventArgs) Handles Vs1.LostFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False)
    End Sub

    Private Sub vS1_DblClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        If e.Row < 0 Then
            Exit Sub
        Else
            Call MAIN_JOB02()
        End If

    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        Call DATA_SEARCH_HEAD_vs_Factory()
    End Sub


    Private Sub vs_Factory_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vs_Factory.CellDoubleClick
        Vs1.ActiveSheet.RowCount = 0
        vS_Sub.ActiveSheet.RowCount = 0

        txt_cdFactory.Code = getData(vs_Factory, getColumIndex(vs_Factory, "BasicCode"), vs_Factory.ActiveSheet.ActiveRowIndex)

        Call DATA_SEARCH_HEAD_vS_Sub()
    End Sub

    Private Sub vs_Sub_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS_Sub.CellDoubleClick
        txt_cdFactory.Code = getData(vs_Factory, getColumIndex(vs_Factory, "BasicCode"), vs_Factory.ActiveSheet.ActiveRowIndex)
        txt_cdSubProcess.Code = getData(vS_Sub, getColumIndex(vS_Sub, "BasicCode"), vS_Sub.ActiveSheet.ActiveRowIndex)

        Call DATA_SEARCH_VS1()
    End Sub

    Public Function DATA_SEARCH_HEAD_vs_Factory() As Boolean
        DATA_SEARCH_HEAD_vs_Factory = False

        Try
            DS1 = PrcDS("USP_PFP71550_SEARCH_vs_Factory", cn, ListCode("Factory"))
            SPR_PRO_NEW(vs_Factory, DS1, "USP_PFP71550_SEARCH_vs_Factory", "vs_Factory")

            SplitContainer2.SplitterDistance = SPR_SHEETWIDHT(vs_Factory) + cSprWidthSize

            DS1 = Nothing
            DATA_SEARCH_HEAD_vs_Factory = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Public Function DATA_SEARCH_HEAD_vS_Sub() As Boolean
        DATA_SEARCH_HEAD_vS_Sub = False

        Try
            DS1 = PrcDS("USP_PFP71550_SEARCH_vS_Sub", cn, txt_cdFactory.Code, ListCode("SubProcess"))
            SPR_PRO_NEW(vS_Sub, DS1, "USP_PFP71550_SEARCH_vS_Sub", "vS_Sub")

            SplitContainer2.SplitterDistance = SPR_SHEETWIDHT(vS_Sub) + cSprWidthSize

            DS1 = Nothing
            DATA_SEARCH_HEAD_vS_Sub = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

#End Region


End Class