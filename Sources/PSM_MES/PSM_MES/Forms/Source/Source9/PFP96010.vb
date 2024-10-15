Public Class PFP96010

#Region "Variable"
    Private Dsu01 As Long
    Private wGCODE As String
    Protected prg As E_PRG

    Private W9601 As T9601_AREA

    Private Form_Close As Boolean

#End Region

#Region "Form_load"

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)

        Me.chk_FormEnterkey = False
        Me.KeyPreview = True

        Call FORM_INIT()
        Call DATA_INIT()

    End Sub
    Private Sub PFP17811_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub
    Overrides Sub Function_Event(PressKey As Integer)
        Try
            Select Case PressKey
                Case Keys.F5 : Call MAIN_JOB01()
                Case Keys.F6 : Call MAIN_JOB02()
                Case Keys.F7 : Call MAIN_JOB03()
                Case Keys.F8 : Call MAIN_JOB04()
                Case Keys.F9 : Call MAIN_JOB05()
                Case Keys.F10 : Call MAIN_JOB06()
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FORM_INIT()
    End Sub

    Private Sub DATA_INIT()
        txt_DateTarget.Value = CIntp(Pub.DAT.Substring(0, 4))

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


    Private Sub MAIN_JOB05()
    End Sub

    Private Sub MAIN_JOB06()

    End Sub

#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS1(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS1 = False
        Vs1.Enabled = False

        If txt_cdFactory.Code = "" Then MsgBoxP("Factory Pls!") : Setfocus(txt_cdFactory) : Exit Function
        If txt_cdSubProcess.Code = "" Then MsgBoxP("SubProcess Pls!") : Setfocus(txt_cdSubProcess) : Exit Function

        DATA_SEARCH_VS1 = False

        DS1 = PrcDS("USP_PFP96010_SEARCH_VS1", cn, ListCode("Factory"),
                                                txt_cdFactory.Code,
                                                txt_cdFactory.Data,
                                               ListCode("SubProcess"),
                                               txt_cdSubProcess.Code,
                                               txt_cdSubProcess.Data,
                                                txt_DateTarget.Value.ToString)

        If GetDsRc(DS1) = 0 Then
            DS2 = PrcDS("USP_PFP96010_SEARCH_VS1_INSERT", cn, ListCode("Factory"),
                                                txt_cdFactory.Code,
                                                txt_cdFactory.Data,
                                               ListCode("SubProcess"),
                                               txt_cdSubProcess.Code,
                                               txt_cdSubProcess.Data,
                                                txt_DateTarget.Value.ToString)

            SPR_PRO(Vs1, DS2, "USP_PFP96010_SEARCH_VS1", "Vs1", True)

            Vs1.Enabled = True
            Exit Function
        End If
        SPR_SET(Vs1, , , , OperationMode.SingleSelect)
        SPR_PRO(Vs1, DS1, "USP_PFP96010_SEARCH_VS1", "Vs1", True)
        DATA_SEARCH_VS1 = True

        Vs1.Enabled = True


    End Function

    Private Function LINE_MOVE_DISPLAY01() As Boolean
        LINE_MOVE_DISPLAY01 = False

    End Function

#End Region

#Region "Event"
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Dim seFactory As String
        Dim cdFactory As String
        Dim seSubProcess As String
        Dim cdSubProcess As String
        Dim DateTarget As String
        Dim xRow As Integer

        seFactory = ListCode("Factory")
        seSubProcess = ListCode("SubProcess")
        cdFactory = txt_cdFactory.Code
        cdSubProcess = txt_cdSubProcess.Code

        Try
            For xRow = 0 To Vs1.ActiveSheet.RowCount - 1
                DateTarget = Replace(getData(Vs1, getColumIndex(Vs1, "DateTarget"), xRow), "/", "")

                If READ_PFK9601(seFactory, cdFactory, seSubProcess, cdSubProcess, DateTarget) = False Then
                    W9601.seFactory = seFactory
                    W9601.seSubProcess = seSubProcess
                    W9601.cdFactory = cdFactory
                    W9601.cdSubProcess = cdSubProcess
                    W9601.DateTarget = DateTarget
                    W9601.QtyTarget = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyTarget"), xRow))
                    W9601.AmtTarget = CDecp(getData(Vs1, getColumIndex(Vs1, "AmtTarget"), xRow))

                    Call WRITE_PFK9601(W9601)

                ElseIf READ_PFK9601(seFactory, cdFactory, seSubProcess, cdSubProcess, DateTarget) = True Then
                    W9601 = D9601
                    W9601.DateTarget = DateTarget
                    W9601.QtyTarget = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyTarget"), xRow))
                    W9601.AmtTarget = CDecp(getData(Vs1, getColumIndex(Vs1, "AmtTarget"), xRow))

                    Call REWRITE_PFK9601(W9601)

                End If

            Next
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
        If sender.Equals(tst_5) Then
            MAIN_JOB05()
        End If
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        Try

            Call DATA_SEARCH_VS1()

        Catch ex As Exception
            Call MsgBoxP("35", "cmd_SEARCH_Click")
        End Try
    End Sub

    Private Sub Vs1_Change(sender As Object, e As ChangeEventArgs) Handles Vs1.Change
        Dim seFactory As String
        Dim cdFactory As String
        Dim seSubProcess As String
        Dim cdSubProcess As String
        Dim DateTarget As String

        seFactory = ListCode("Factory")
        seSubProcess = ListCode("SubProcess")
        cdFactory = getData(Vs1, getColumIndex(Vs1, "cdFactory"), e.Row)
        cdSubProcess = getData(Vs1, getColumIndex(Vs1, "cdSubProcess"), e.Row)
        DateTarget = getData(Vs1, getColumIndex(Vs1, "DateTarget"), e.Row)

        Try
            If READ_PFK9601(seFactory, cdFactory, seSubProcess, cdSubProcess, DateTarget) = False Then
                W9601.seFactory = seFactory
                W9601.seSubProcess = seSubProcess
                W9601.cdFactory = cdFactory
                W9601.cdSubProcess = cdSubProcess
                W9601.DateTarget = DateTarget
                W9601.QtyTarget = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyTarget"), e.Row))
                W9601.AmtTarget = CDecp(getData(Vs1, getColumIndex(Vs1, "AmtTarget"), e.Row))

                Call WRITE_PFK9601(W9601)

            ElseIf READ_PFK9601(seFactory, cdFactory, seSubProcess, cdSubProcess, DateTarget) = True Then
                W9601 = D9601
                W9601.QtyTarget = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyTarget"), e.Row))
                W9601.AmtTarget = CDecp(getData(Vs1, getColumIndex(Vs1, "AmtTarget"), e.Row))

                Call REWRITE_PFK9601(W9601)

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Vs1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown
        Dim seFactory As String
        Dim cdFactory As String
        Dim seSubProcess As String
        Dim cdSubProcess As String
        Dim DateTarget As String

        Dim xrow As Integer
        xrow = Vs1.ActiveSheet.ActiveRowIndex

        seFactory = ListCode("Factory")
        seSubProcess = ListCode("SubProcess")
        cdFactory = getData(Vs1, getColumIndex(Vs1, "cdFactory"), xrow)
        cdSubProcess = getData(Vs1, getColumIndex(Vs1, "cdSubProcess"), xrow)
        DateTarget = getData(Vs1, getColumIndex(Vs1, "DateTarget"), xrow)

        If e.KeyCode = Keys.Enter Then
            seFactory = ListCode("Factory")
            seSubProcess = ListCode("SubProcess")
            cdFactory = getData(Vs1, getColumIndex(Vs1, "cdFactory"), xrow)
            cdSubProcess = getData(Vs1, getColumIndex(Vs1, "cdSubProcess"), xrow)
            DateTarget = getData(Vs1, getColumIndex(Vs1, "DateTarget"), xrow)

            Try
                If READ_PFK9601(seFactory, cdFactory, seSubProcess, cdSubProcess, DateTarget) = False Then
                    W9601.seFactory = seFactory
                    W9601.seSubProcess = seSubProcess
                    W9601.cdFactory = cdFactory
                    W9601.cdSubProcess = cdSubProcess
                    W9601.DateTarget = DateTarget
                    W9601.QtyTarget = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyTarget"), xrow))
                    W9601.AmtTarget = CDecp(getData(Vs1, getColumIndex(Vs1, "AmtTarget"), xrow))

                    Call WRITE_PFK9601(W9601)

                ElseIf READ_PFK9601(seFactory, cdFactory, seSubProcess, cdSubProcess, DateTarget) = True Then
                    W9601 = D9601
                    W9601.QtyTarget = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyTarget"), xrow))
                    W9601.AmtTarget = CDecp(getData(Vs1, getColumIndex(Vs1, "AmtTarget"), xrow))

                    Call REWRITE_PFK9601(W9601)

                End If

            Catch ex As Exception

            End Try
        End If
    End Sub
#End Region


 
   
 
End Class