Public Class PFP40860

#Region "Variable"
    Private Dsu01 As Long
    Private wGCODE As String
    Protected prg As E_PRG

    Private W4086 As T4086_AREA

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
        txt_DateProd.Data = System_Date_8()

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
        If txt_cdQCProcess.Code = "" Then MsgBoxP("QCProcess Pls!") : Setfocus(txt_cdQCProcess) : Exit Function
        If txt_cdLineProd.Code = "" Then MsgBoxP("LineProd Pls!") : Setfocus(txt_cdLineProd) : Exit Function

        DATA_SEARCH_VS1 = False

        DS1 = PrcDS("USP_PFP40860_SEARCH_VS1", cn, ListCode("Factory"),
                                                txt_cdFactory.Code,
                                                ListCode("QCProcess"),
                                                txt_cdQCProcess.Code,
                                               txt_cdLineProd.Code,
                                                txt_DateProd.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO(Vs1, DS2, "USP_PFP40860_SEARCH_VS1", "Vs1", True)

            Vs1.Enabled = True
            Exit Function
        End If
        SPR_SET(Vs1, , , , OperationMode.SingleSelect)
        SPR_PRO(Vs1, DS1, "USP_PFP40860_SEARCH_VS1", "Vs1", True)
        DATA_SEARCH_VS1 = True
        Vs1.Focus()
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

    Private Sub Vs1_Change(sender As Object, e As ChangeEventArgs) Handles Vs1.Change

        Dim AutoKey As String

        AutoKey = getData(Vs1, getColumIndex(Vs1, "AutoKey_KEY"), e.Row)

        Dim QtyHour01 As Decimal = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyHour01"), e.Row))
        Dim QtyHour02 As Decimal = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyHour02"), e.Row))
        Dim QtyHour03 As Decimal = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyHour03"), e.Row))
        Dim QtyHour04 As Decimal = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyHour04"), e.Row))
        Dim QtyHour05 As Decimal = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyHour05"), e.Row))
        Dim QtyHour06 As Decimal = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyHour06"), e.Row))
        Dim QtyHour07 As Decimal = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyHour07"), e.Row))
        Dim QtyHour08 As Decimal = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyHour08"), e.Row))
        Dim QtyHour09 As Decimal = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyHour09"), e.Row))
        Dim QtyHour10 As Decimal = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyHour10"), e.Row))
        Dim QtyHour11 As Decimal = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyHour11"), e.Row))
        Dim QtyHour12 As Decimal = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyHour12"), e.Row))
        Dim QtyHour13 As Decimal = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyHour13"), e.Row))
        Dim QtyHour14 As Decimal = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyHour14"), e.Row))
        Dim QtyHour15 As Decimal = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyHour15"), e.Row))
        Dim QtyHour16 As Decimal = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyHour16"), e.Row))
        Dim QtyHour17 As Decimal = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyHour17"), e.Row))
        Dim QtyHour18 As Decimal = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyHour18"), e.Row))
        Dim QtyHour19 As Decimal = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyHour19"), e.Row))
        Dim QtyHour20 As Decimal = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyHour20"), e.Row))
        Dim QtyTotal As Decimal = QtyHour01 + QtyHour02 + QtyHour03 + QtyHour04 + QtyHour05 + QtyHour06 + QtyHour07 + QtyHour08 + QtyHour09 + QtyHour10 + QtyHour11 + QtyHour12 + QtyHour13 + QtyHour14 + QtyHour15 + QtyHour16 + QtyHour17 + QtyHour18 + QtyHour19 + QtyHour20

        setData(Vs1, getColumIndex(Vs1, "QtyTotal"), e.Row, QtyTotal)

        Try

            If READ_PFK4086_1(txt_cdFactory.Code, txt_cdQCProcess.Code, getData(Vs1, getColumIndex(Vs1, "seDefect"), e.Row), getData(Vs1, getColumIndex(Vs1, "cdDefect"), e.Row), txt_cdLineProd.Code, txt_DateProd.Data) = False Then

                Call K4086_MOVE_1(Vs1, e.Row, W4086, txt_cdFactory.Code, txt_cdQCProcess.Code, getData(Vs1, getColumIndex(Vs1, "seDefect"), e.Row), getData(Vs1, getColumIndex(Vs1, "cdDefect"), e.Row), txt_cdLineProd.Code, txt_DateProd.Data)

                W4086.seFactory = ListCode("Factory")
                W4086.cdFactory = txt_cdFactory.Code
                W4086.seQCProcess = ListCode("QCProcess")
                W4086.cdQCProcess = txt_cdQCProcess.Code
                W4086.InchargeQC = Pub.SAW
                W4086.DateAccept = txt_DateProd.Data
                W4086.seLineProd = ListCode("LineProd")
                W4086.cdLineProd = txt_cdLineProd.Code
                Call WRITE_PFK4086(W4086)

            Else
                W4086 = D4086

                Call K4086_MOVE_1(Vs1, e.Row, W4086, txt_cdFactory.Code, txt_cdQCProcess.Code, getData(Vs1, getColumIndex(Vs1, "seDefect"), e.Row), getData(Vs1, getColumIndex(Vs1, "cdDefect"), e.Row), txt_cdLineProd.Code, txt_DateProd.Data)

                Call REWRITE_PFK4086(W4086)

            End If

        Catch ex As Exception

        End Try
    End Sub
#End Region

End Class