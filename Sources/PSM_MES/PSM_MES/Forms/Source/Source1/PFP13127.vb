Public Class PFP13127

#Region "Variable"
    Private Dsu01 As Long
    Private wGCODE As String
    Protected prg As E_PRG

    Private W1311 As T1311_AREA
    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

        Call Cms_additem(Cms_1, "UPDATE GROSS WEIGHT & NET WEIGHT " & "(F5)")

        Vs1.ContextMenuStrip = Cms_1

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

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

            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FORM_INIT()
        chk_FSEL.CheckState = 1
        chk_FSEL.BackColor = clrCheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("CLOSE")
        ssp_WHERE.Visible = True

    End Sub

    Private Sub DATA_INIT()
        ssp_WHERE.txt_SdateEdate.text1 = System_Date_Add(-1)
        ssp_WHERE.txt_SdateEdate.text2 = System_Date_8()

        Call Gadget_Load(ssp_WHERE, Me.Name)

       ssp_WHERE.txt_cdSpecState.Code = "006"
        ssp_WHERE.txt_cdSpecState.Data = "PPS"
        ssp_WHERE.txt_cdSpecState.Enabled = False


    End Sub
#End Region

#Region "Function"
    Private Sub MAIN_JOB01()
        Dim ItemCodeFIN As String
        Dim OrderNo As String
        Dim OrderNoSeq As String
        Dim i As Integer
        Dim QtyGW As Decimal
        Dim QtyNW As Decimal

        Try
            If chk_Multi.Checked = True Then

                OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
                OrderNoSeq = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex)


                If READ_PFK1312(OrderNo, OrderNoSeq) Then
                    If READ_PFK7108_SHOESCODE(D1312.ShoesCode) Then
                        If ISUD1310B.Link_ISUD1310B(3, D7108.GroupComponentBOM, OrderNo, OrderNoSeq, Me.Name) Then Exit Sub

                        If READ_PFK1312(OrderNo, OrderNoSeq) Then
                            QtyGW = D1312.QtyGW
                            QtyNW = D1312.QtyNW

                            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                                If getDataM(Vs1, getColumIndex(Vs1, "DCHK"), i) = "1" Then

                                    OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), i)
                                    OrderNoSeq = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), i)

                                    If READ_PFK1312(OrderNo, OrderNoSeq) Then
                                        D1312.QtyGW = QtyGW
                                        D1312.QtyNW = QtyNW

                                        If REWRITE_PFK1312(D1312) Then
                                            setData(Vs1, getColumIndex(Vs1, "QtyGW"), i, D1312.QtyGW)
                                            setData(Vs1, getColumIndex(Vs1, "QtyNW"), i, D1312.QtyNW)
                                        End If
                                      

                                    End If

                                  

                                End If
                            Next

                        End If



                    End If

                End If



            Else
                OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
                OrderNoSeq = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex)


                If READ_PFK1312(OrderNo, OrderNoSeq) Then
                    If READ_PFK7108_SHOESCODE(D1312.ShoesCode) Then
                        If ISUD1310B.Link_ISUD1310B(3, D7108.GroupComponentBOM, OrderNo, OrderNoSeq, Me.Name) Then Exit Sub

                        If READ_PFK1312(OrderNo, OrderNoSeq) Then
                            setData(Vs1, getColumIndex(Vs1, "QtyGW"), Vs1.ActiveSheet.ActiveRowIndex, D1312.QtyGW)
                            setData(Vs1, getColumIndex(Vs1, "QtyNW"), Vs1.ActiveSheet.ActiveRowIndex, D1312.QtyNW)
                        End If

                    End If

                End If
            End If
           

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB05!", vbCritical)
        End Try

    End Sub

#End Region

#Region "Data_search"

    Private Function DATA_SEARCH_VS1(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS1 = False

        Vs1.Enabled = False


        Try
             DS1 = PrcDS("USP_PFP13127_SEARCH_VS1", cn, ssp_WHERE.gData_SDate,
                                                          ssp_WHERE.gData_EDate,
                                                          ssp_WHERE.gData_chkGCodeCheck,
                                                          ssp_WHERE.gData_chkGCodeSQL,
                                                          ssp_WHERE.gData_CustomerName,
                                                          ssp_WHERE.gData_Season,
                                                          ssp_WHERE.gData_SpecNoRef,
                                                          ssp_WHERE.gData_SpecStatus,
                                                          ssp_WHERE.gData_SpecState,
                                                          ssp_WHERE.gData_SpecKind,
                                                          ssp_WHERE.gData_SizeRange,
                                                          ssp_WHERE.gData_Article,
                                                          ssp_WHERE.gData_Line,
                                                          ssp_WHERE.gData_MaterialName,
                                                          ssp_WHERE.gData_ColorName,
                                                          ssp_WHERE.gData_MoldName,
                                                          ssp_WHERE.gData_LastName,
                                                          ssp_WHERE.gData_Incharge,
                                                          ssp_WHERE.gData_CheckRequest,
                                                          ssp_WHERE.gData_CheckUse0,
                                                          ssp_WHERE.gData_CheckUse1)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_PFP13127_SEARCH_VS1", "Vs1")
                Vs1.ActiveSheet.RowCount = 0
                Vs1.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs1, DS1, "USP_PFP13127_SEARCH_VS1", "Vs1")
            DATA_SEARCH_VS1 = True

            Vs1.Enabled = True




        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try

    End Function

#End Region

#Region "Event"

    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        Dim OrderNo As String

        OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
        Call MAIN_JOB01()
    End Sub

    Private Sub tst_1_Click(sender As Object, e As EventArgs) Handles tst_1.Click, tst_2.Click, tst_3.Click, tst_4.Click, tst_5.Click, tst_6.Click
        If sender.Equals(tst_1) Then
            MAIN_JOB01()
        End If

    End Sub


    Private Sub chk_FSEL_Click(sender As Object, e As EventArgs) Handles chk_FSEL.CheckedChanged
        If chk_FSEL.CheckState = 0 Then                  '
            chk_FSEL.BackColor = clrUncheck
            chk_FSEL.ForeColor = Color.Black

            chk_FSEL.Text = WordConv("OPEN")
            ssp_WHERE.Visible = False
        Else                                        '
            chk_FSEL.BackColor = clrCheck
            chk_FSEL.ForeColor = Color.Black

            chk_FSEL.Text = WordConv("CLOSE")
            ssp_WHERE.Visible = True
        End If
    End Sub
    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        Try

            chk_FSEL.CheckState = 0
            chk_FSEL.BackColor = clrUncheck
            chk_FSEL.ForeColor = Color.Black

            chk_FSEL.Text = WordConv("OPEN")
            ssp_WHERE.Visible = False
            Call DATA_SEARCH_VS1()

        Catch ex As Exception
            Call MsgBoxP("35", "cmd_SEARCH_Click")
        End Try
    End Sub
    Private Sub Cms_1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_1.ItemClicked
        Try

            If Cms_1.Items(0).Selected = True Then
                Cms_1.Hide()
                MAIN_JOB01()

            End If

        Catch ex As Exception
            Call MsgBoxP("35", "cmd_SEARCH_Click")
        End Try

    End Sub

    Private Sub vs_GotFocus(sender As Object, e As EventArgs) Handles Vs1.GotFocus
        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False
    End Sub

    Private Sub chk_Total_CheckedChanged(sender As Object, e As EventArgs)


    End Sub
#End Region






End Class