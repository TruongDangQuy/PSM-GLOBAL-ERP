Public Class PFP96030

#Region "Variable"
    Private Dsu01 As Long
    Private wGCODE As String
    Protected prg As E_PRG

    Private W1317 As T1317_AREA

    Private Form_Close As Boolean

#End Region

#Region "Form_load"

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
        Vs1.Enabled = False

        DATA_SEARCH_VS1 = False

        DS1 = PrcDS("USP_PFP96030_SEARCH_VS1", cn, ListCode("Department"),
                                                txt_cdDepartment.Code,
                                                ListCode("Factory"),
                                                txt_cdFactory.Code,
                                                ListCode("LineProd"),
                                                txt_cdLineProd.Code,
                                                ListCode("SubProcess"),
                                               txt_cdSubProcess.Code,
                                                txt_DateTarget.Value.ToString)

        If GetDsRc(DS1) = 0 Then
            DS2 = PrcDS("USP_PFP96030_SEARCH_VS1_INSERT", cn, ListCode("Department"),
                                                txt_cdDepartment.Code,
                                                ListCode("Factory"),
                                                txt_cdFactory.Code,
                                                ListCode("LineProd"),
                                                txt_cdLineProd.Code,
                                                ListCode("SubProcess"),
                                               txt_cdSubProcess.Code,
                                                txt_DateTarget.Value.ToString)

            SPR_PRO(Vs1, DS2, "USP_PFP96030_SEARCH_VS1", "Vs1", True)

            Vs1.Enabled = True
            Exit Function
        End If
        SPR_SET(Vs1, , , , OperationMode.SingleSelect)
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


#End Region


End Class