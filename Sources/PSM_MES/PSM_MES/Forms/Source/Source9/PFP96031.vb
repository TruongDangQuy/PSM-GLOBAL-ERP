Public Class PFP96031

#Region "Variable"
    Private Dsu01 As Long
    Private wGCODE As String
    Protected prg As E_PRG

    Private W9603 As T9603_AREA

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
        txt_Month.Value = CIntp(Pub.DAT.Substring(4, 2))

    End Sub
#End Region

#Region "Function"
    Private Sub MAIN_JOB01()

        Dim I As Integer
        Dim seFactory As String
        Dim cdFactory As String
        Dim seSubProcess As String
        Dim cdSubProcess As String
        Dim cdLineProd As String
        Dim DateTarget As String
        Dim seLineProd As String

        seFactory = ListCode("Factory")
        seSubProcess = ListCode("SubProcess")
        cdFactory = txt_cdFactory.Code
        cdSubProcess = txt_cdSubProcess.Code
        cdLineProd = txt_cdLineProd.Code
        seLineProd = ListCode("LineProd")

        For I = 1 To CInt(Date.DaysInMonth(txt_DateTarget.Value.ToString, txt_Month.Value.ToString))

            DateTarget = txt_DateTarget.Value.ToString & FormatP(txt_Month.Value.ToString, "00") & FormatP(I, "00")

            If READ_PFK9603(seFactory, cdFactory, seSubProcess, cdSubProcess, seLineProd, cdLineProd, DateTarget) = False Then

                W9603.seFactory = seFactory
                W9603.seSubProcess = seSubProcess
                W9603.cdFactory = cdFactory
                W9603.cdSubProcess = cdSubProcess
                W9603.seLineProd = seLineProd
                W9603.cdLineProd = cdLineProd
                W9603.DateTarget = txt_DateTarget.Value.ToString & FormatP(txt_Month.Value.ToString, "00") & FormatP(I, "00")

                Call WRITE_PFK9603(W9603)
            Else

                W9603 = D9603
                W9603.QtyTarget = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyTaget"), I))
                W9603.AmtTaget = CDecp(getData(Vs1, getColumIndex(Vs1, "AmtTaget"), I))
                W9603.PersonTO = CDecp(getData(Vs1, getColumIndex(Vs1, "PersonTO"), I))
                W9603.PersonActualDirect = CDecp(getData(Vs1, getColumIndex(Vs1, "PersonActualDirect"), I))
                W9603.ABSENT = CDecp(getData(Vs1, getColumIndex(Vs1, "PersonABSENT"), I))

                Call REWRITE_PFK9603(W9603)

            End If



        Next

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
        'If txt_cdLineProd.Code = "" Then MsgBoxP("LineProd Pls!") : Setfocus(txt_cdLineProd) : Exit Function

        DATA_SEARCH_VS1 = False

        DS1 = PrcDS("USP_PFP96030_SEARCH_VS1", cn, ListCode("Factory"),
                                                   txt_cdFactory.Code,
                                                   ListCode("cdLineProd"),
                                                   txt_cdLineProd.Code,
                                                   ListCode("SubProcess"),
                                                    txt_cdSubProcess.Code,
                                                 txt_DateTarget.Value.ToString & FormatP(txt_Month.Value.ToString, "00"))


        If GetDsRc(DS1) = 0 Then

            Call MAIN_JOB01()

            DS2 = PrcDS("USP_PFP96030_SEARCH_VS1", cn, ListCode("Factory"),
                                                  txt_cdFactory.Code,
                                                  ListCode("cdLineProd"),
                                                  txt_cdLineProd.Code,
                                                  ListCode("SubProcess"),
                                                   txt_cdSubProcess.Code,
                                               txt_DateTarget.Value.ToString & FormatP(txt_Month.Value.ToString, "00"))

            SPR_PRO(Vs1, DS2, "USP_PFP96030_SEARCH_VS1", "Vs1", True)
            DATA_SEARCH_VS1 = True

            Vs1.Enabled = True

            Exit Function

        End If

        SPR_PRO(Vs1, DS1, "USP_PFP96030_SEARCH_VS1", "Vs1", True)
        DATA_SEARCH_VS1 = True

        Vs1.Enabled = True

    


    End Function



    Private Function LINE_MOVE_DISPLAY01() As Boolean

    End Function

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
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Try

            Dim seFactory As String
            Dim cdFactory As String
            Dim seSubProcess As String
            Dim cdSubProcess As String
            Dim cdLineProd As String
            Dim DateTarget As String
            Dim seLineProd As String
            Dim xRow As Integer

            For xRow = 0 To Vs1.ActiveSheet.RowCount - 1

                seFactory = ListCode("Factory")
                seSubProcess = ListCode("SubProcess")
                seLineProd = ListCode("LineProd")

                cdFactory = txt_cdFactory.Code
                cdSubProcess = txt_cdSubProcess.Code
                cdLineProd = txt_cdLineProd.Code

                DateTarget = Replace(getData(Vs1, getColumIndex(Vs1, "DateTarget"), xRow), "/", "")

                If READ_PFK9603(seFactory, cdFactory, seSubProcess, cdSubProcess, seLineProd, cdLineProd, DateTarget) = False Then
                    W9603.seFactory = seFactory
                    W9603.seSubProcess = seSubProcess
                    W9603.cdFactory = cdFactory
                    W9603.cdSubProcess = cdSubProcess
                    W9603.seLineProd = seLineProd
                    W9603.cdLineProd = cdLineProd
                    W9603.DateTarget = DateTarget

                    W9603.QtyTarget = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyTaget"), xRow))
                    W9603.AmtTaget = CDecp(getData(Vs1, getColumIndex(Vs1, "AmtTaget"), xRow))
                    W9603.PersonTO = CDecp(getData(Vs1, getColumIndex(Vs1, "PersonTO"), xRow))
                    W9603.PersonActualDirect = CDecp(getData(Vs1, getColumIndex(Vs1, "PersonActualDirect"), xRow))
                    W9603.ABSENT = CDecp(getData(Vs1, getColumIndex(Vs1, "PersonABSENT"), xRow))

                    Call WRITE_PFK9603(W9603)
                Else

                    W9603.seFactory = seFactory
                    W9603.seSubProcess = seSubProcess
                    W9603.cdFactory = cdFactory
                    W9603.cdSubProcess = cdSubProcess
                    W9603.seLineProd = seLineProd
                    W9603.cdLineProd = cdLineProd
                    W9603.DateTarget = DateTarget

                    W9603.QtyTarget = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyTaget"), xRow))
                    W9603.AmtTaget = CDecp(getData(Vs1, getColumIndex(Vs1, "AmtTaget"), xRow))
                    W9603.PersonTO = CDecp(getData(Vs1, getColumIndex(Vs1, "PersonTO"), xRow))
                    W9603.PersonActualDirect = CDecp(getData(Vs1, getColumIndex(Vs1, "PersonActualDirect"), xRow))
                    W9603.ABSENT = CDecp(getData(Vs1, getColumIndex(Vs1, "PersonABSENT"), xRow))

                    Call REWRITE_PFK9603(W9603)

                End If


            Next

            Call MsgBoxP("Update Successully!", vbInformation)

        Catch ex As Exception
            Call MsgBoxP("35", "cmd_SEARCH_Click")
        End Try
    End Sub
    Private Sub Vs1_Change(sender As Object, e As ChangeEventArgs) Handles Vs1.Change

        Dim seFactory As String
        Dim cdFactory As String
        Dim seSubProcess As String
        Dim cdSubProcess As String
        Dim cdLineProd As String
        Dim DateTarget As String
        Dim seLineProd As String

        seFactory = ListCode("Factory")
        seSubProcess = ListCode("SubProcess")
        seLineProd = ListCode("LineProd")

        cdFactory = txt_cdFactory.Code
        cdSubProcess = txt_cdSubProcess.Code
        cdLineProd = txt_cdLineProd.Code

        DateTarget = Replace(getData(Vs1, getColumIndex(Vs1, "DateTarget"), e.Row), "/", "")

        Try

            If READ_PFK9603(seFactory, cdFactory, seSubProcess, cdSubProcess, seLineProd, cdLineProd, DateTarget) = False Then

                W9603.seFactory = seFactory
                W9603.seSubProcess = seSubProcess
                W9603.cdFactory = cdFactory
                W9603.cdSubProcess = cdSubProcess
                W9603.seLineProd = seLineProd
                W9603.cdLineProd = cdLineProd
                W9603.DateTarget = DateTarget
                W9603.QtyTarget = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyTaget"), e.Row))
                W9603.AmtTaget = CDecp(getData(Vs1, getColumIndex(Vs1, "AmtTaget"), e.Row))
                W9603.PersonTO = CDecp(getData(Vs1, getColumIndex(Vs1, "PersonTO"), e.Row))
                W9603.PersonActualDirect = CDecp(getData(Vs1, getColumIndex(Vs1, "PersonActualDirect"), e.Row))
                W9603.ABSENT = CDecp(getData(Vs1, getColumIndex(Vs1, "PersonABSENT"), e.Row))

                Call WRITE_PFK9603(W9603)
            Else

                W9603.seFactory = seFactory
                W9603.seSubProcess = seSubProcess
                W9603.cdFactory = cdFactory
                W9603.cdSubProcess = cdSubProcess
                W9603.seLineProd = seLineProd
                W9603.cdLineProd = cdLineProd
                W9603.DateTarget = DateTarget
                W9603.QtyTarget = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyTaget"), e.Row))
                W9603.AmtTaget = CDecp(getData(Vs1, getColumIndex(Vs1, "AmtTaget"), e.Row))
                W9603.PersonTO = CDecp(getData(Vs1, getColumIndex(Vs1, "PersonTO"), e.Row))
                W9603.PersonActualDirect = CDecp(getData(Vs1, getColumIndex(Vs1, "PersonActualDirect"), e.Row))
                W9603.ABSENT = CDecp(getData(Vs1, getColumIndex(Vs1, "PersonABSENT"), e.Row))

                Call REWRITE_PFK9603(W9603)

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Vs1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown

        Dim seFactory As String
        Dim cdFactory As String
        Dim seSubProcess As String
        Dim cdSubProcess As String
        Dim cdLineProd As String
        Dim DateTarget As String
        Dim seLineProd As String

        seFactory = ListCode("Factory")
        seSubProcess = ListCode("SubProcess")
        seLineProd = ListCode("LineProd")

        cdFactory = txt_cdFactory.Code
        cdSubProcess = txt_cdSubProcess.Code
        cdLineProd = txt_cdLineProd.Code

        DateTarget = Replace(getData(Vs1, getColumIndex(Vs1, "DateTarget"), Vs1.ActiveSheet.ActiveRowIndex), "/", "")

        Try

            If READ_PFK9603(seFactory, cdFactory, seSubProcess, cdSubProcess, seLineProd, cdLineProd, DateTarget) = False Then

                W9603.seFactory = seFactory
                W9603.seSubProcess = seSubProcess
                W9603.cdFactory = cdFactory
                W9603.cdSubProcess = cdSubProcess
                W9603.seLineProd = seLineProd
                W9603.cdLineProd = cdLineProd
                W9603.DateTarget = DateTarget
                W9603.QtyTarget = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyTaget"), Vs1.ActiveSheet.ActiveRowIndex))
                W9603.AmtTaget = CDecp(getData(Vs1, getColumIndex(Vs1, "AmtTaget"), Vs1.ActiveSheet.ActiveRowIndex))
                W9603.PersonTO = CDecp(getData(Vs1, getColumIndex(Vs1, "PersonTO"), Vs1.ActiveSheet.ActiveRowIndex))
                W9603.PersonActualDirect = CDecp(getData(Vs1, getColumIndex(Vs1, "PersonActualDirect"), Vs1.ActiveSheet.ActiveRowIndex))
                W9603.ABSENT = CDecp(getData(Vs1, getColumIndex(Vs1, "PersonABSENT"), Vs1.ActiveSheet.ActiveRowIndex))

                Call WRITE_PFK9603(W9603)
            Else

                W9603.seFactory = seFactory
                W9603.seSubProcess = seSubProcess
                W9603.cdFactory = cdFactory
                W9603.cdSubProcess = cdSubProcess
                W9603.seLineProd = seLineProd
                W9603.cdLineProd = cdLineProd
                W9603.DateTarget = DateTarget
                W9603.QtyTarget = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyTaget"), Vs1.ActiveSheet.ActiveRowIndex))
                W9603.AmtTaget = CDecp(getData(Vs1, getColumIndex(Vs1, "AmtTaget"), Vs1.ActiveSheet.ActiveRowIndex))
                W9603.PersonTO = CDecp(getData(Vs1, getColumIndex(Vs1, "PersonTO"), Vs1.ActiveSheet.ActiveRowIndex))
                W9603.PersonActualDirect = CDecp(getData(Vs1, getColumIndex(Vs1, "PersonActualDirect"), Vs1.ActiveSheet.ActiveRowIndex))
                W9603.ABSENT = CDecp(getData(Vs1, getColumIndex(Vs1, "PersonABSENT"), Vs1.ActiveSheet.ActiveRowIndex))

                Call REWRITE_PFK9603(W9603)

            End If

        Catch ex As Exception

        End Try

    End Sub

#End Region


End Class