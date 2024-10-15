Public Class PFP00000

#Region "Variable"
    Private Dsu01 As Long
    Private wGCODE As String
    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
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
                Case Keys.F5 : Call MAIN_JOB00()
                Case Keys.F6 : Call MAIN_JOB01()
                Case Keys.F7 : Call MAIN_JOB02()
                Case Keys.F8 : Call MAIN_JOB03()
                Case Keys.F9 : Call MAIN_JOB04()
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

        Try
            If READ_PFK9970(Pub.SITE, Me.strFormOriginName) Then
                Me.Name = Me.strFormOriginName
                ptc_1.TabPages(0).Text = D9970.TagName1
                ptc_1.TabPages(1).Text = D9970.TagName2
                ptc_1.TabPages(2).Text = D9970.TagName3

                If D9970.cntTab = 0 Then
                    ptc_1.TabPages.Clear()
                End If

                If D9970.cntTab = 1 Then
                    ptc_1.TabPages.RemoveAt(1) : ptc_1.TabPages.RemoveAt(1)
                End If

                If D9970.cntTab = 2 Then
                    ptc_1.TabPages.RemoveAt(2)
                End If

                Vs10.SheetDSName = D9970.SheetName10
                vS20.SheetDSName = D9970.SheetName20
                vS30.SheetDSName = D9970.SheetName30

                Select Case D9970.Parameter01
                    Case "D0"
                        SdateEdate.text1 = Pub.DAT

                    Case "M0"
                        SdateEdate.text1 = System_Date_6() & "01"

                End Select

                Select Case D9970.Parameter02
                    Case "D0"
                        SdateEdate.text2 = Pub.DAT

                    Case "M0"
                        SdateEdate.text2 = System_Date_6() & "01"

                End Select

                If D9970.Parameter03 <> "" Then
                    txt_CustomerCode.Code = D9970.Parameter03
                    If READ_PFK7101(txt_CustomerCode.Code) Then
                        txt_CustomerCode.Data = D7101.CustomerName
                        txt_CustomerCode.Enabled = False
                    End If
                End If

                If D9970.Parameter04 <> "" Then
                    txt_InchargeInsert.Code = Pub.SAW
                    txt_InchargeInsert.Data = Pub.NAM
                End If

                If D9970.Parameter05 <> "" Then

                End If

                If D9970.Parameter06 <> "" Then

                End If

                If D9970.Parameter07 <> "" Then opt_SEL0.CheckState = CIntp(D9970.Parameter07)
                If D9970.Parameter08 <> "" Then opt_SEL1.CheckState = CIntp(D9970.Parameter08)
                If D9970.Parameter09 <> "" Then opt_SEL2.CheckState = CIntp(D9970.Parameter09)
                If D9970.Parameter10 <> "" Then opt_SEL3.CheckState = CIntp(D9970.Parameter10)
                If D9970.Parameter12 <> "" Then opt_SEL4.CheckState = CIntp(D9970.Parameter11)
                If D9970.Parameter12 <> "" Then opt_SEL5.CheckState = CIntp(D9970.Parameter12)


            End If



        Catch ex As Exception

        End Try
    End Sub

    Private Sub DATA_INIT()
        ssp_WHERE.Location = New Point(38, 110)
    End Sub
#End Region

#Region "Function"
    Private Sub MAIN_JOB00()
    End Sub

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

    Private Sub MAIN_JOB07()
    End Sub

    Private Sub MAIN_JOB08()

    End Sub

    Private Sub MAIN_JOB09()

    End Sub
    Private Sub MAIN_JOB10()

    End Sub

    Private Sub MAIN_JOB11()

    End Sub


    Private Sub MAIN_JOB12()

    End Sub


    Private Sub MAIN_JOB13()

    End Sub


    Private Sub MAIN_JOB14()

    End Sub


    Private Sub MAIN_JOB15()

    End Sub

#End Region

#Region "Data_search"

    Private Function strArrayData() As List(Of String)
        strArrayData = New List(Of String)

        Try
            strArrayData.Add(SdateEdate.text1)
            strArrayData.Add(SdateEdate.text2)

            strArrayData.Add(txt_CustomerCode.Code)
            strArrayData.Add(txt_InchargeInsert.Code)
            strArrayData.Add(txt_Article.Data)
            strArrayData.Add(txt_ProductCode.Data)

            strArrayData.Add(opt_SEL0.CheckState.ToString)
            strArrayData.Add(opt_SEL1.CheckState.ToString)
            strArrayData.Add(opt_SEL2.CheckState.ToString)
            strArrayData.Add(opt_SEL3.CheckState.ToString)
            strArrayData.Add(opt_SEL4.CheckState.ToString)
            strArrayData.Add(opt_SEL5.CheckState.ToString)

        Catch ex As Exception

        End Try
    End Function
    Private Function DATA_SEARCH_VS10(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS10 = False

        Vs10.Enabled = False
        Try
            DS1 = PrcDS(Vs10.SheetDSName, cn, strArrayData.ToArray)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs10, DS1, Vs10.SheetDSName, "vS10")
                Vs10.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs10, DS1, Vs10.SheetDSName, "vS10")
            DATA_SEARCH_VS10 = True

            Vs10.Enabled = True

        Catch ex As Exception

        End Try

    End Function

    Private Function DATA_SEARCH_VS20(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS20 = False

        vS20.Enabled = False
        Try
            DS1 = PrcDS(vS20.SheetDSName, cn, strArrayData.ToArray)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS20, DS1, vS20.SheetDSName, "VS20")
                vS20.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS20, DS1, vS20.SheetDSName, "VS20")
            DATA_SEARCH_VS20 = True

            vS20.Enabled = True

        Catch ex As Exception

        End Try

    End Function

    Dim i As Integer

    Private Function DATA_SEARCH_VS30() As Boolean
        DATA_SEARCH_VS30 = False
        Dim SCol As Integer
        Dim Value() As String
        Dim SpecNoList As String

        Try

            DATA_SEARCH_VS30 = True

            vS30.Enabled = True

        Catch ex As Exception

        End Try

    End Function

    Private Function LINE_MOVE_DISPLAY01() As Boolean
        LINE_MOVE_DISPLAY01 = False

    End Function
    Private Function CustomerPurchasing_CHK() As String
        CustomerPurchasing_CHK = "1"
        Return CustomerPurchasing_CHK
    End Function

#End Region

#Region "Event"
    Private Sub tst_1_Click(sender As Object, e As EventArgs) Handles tst_1.Click, tst_2.Click, tst_3.Click, tst_4.Click, tst_5.Click, tst_6.Click
        If sender.Equals(tst_1) Then
            MAIN_JOB00()
        End If
        If sender.Equals(tst_2) Then
            MAIN_JOB01()
        End If
        If sender.Equals(tst_3) Then
            MAIN_JOB02()
        End If
        If sender.Equals(tst_4) Then
            MAIN_JOB03()
        End If
        If sender.Equals(tst_5) Then
            MAIN_JOB04()
        End If
    End Sub

    Private Sub vS20_CellClick(sender As Object, e As CellClickEventArgs) Handles vS20.CellClick

    End Sub

    Private Sub vS20_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS20.CellDoubleClick

    End Sub


    Private Sub vS20_LostFocus(sender As Object, e As EventArgs) Handles vS20.LostFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False)
    End Sub
    Private Sub Vs10_GotFocus(sender As Object, e As EventArgs) Handles Vs10.GotFocus
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False)

    End Sub


    Private Sub Vs20_GotFocus(sender As Object, e As EventArgs) Handles vS20.GotFocus
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

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

        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False

        If ptc_1.SelectedIndex = 0 Then Call DATA_SEARCH_VS10()
        If ptc_1.SelectedIndex = 1 Then Call DATA_SEARCH_VS20()
        If ptc_1.SelectedIndex = 2 Then Call DATA_SEARCH_VS30()
    End Sub
    Private Sub Cms_1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_1.ItemClicked

    End Sub
    Private Sub Cms_2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_2.ItemClicked

    End Sub

    Private Sub HLP8986A_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If ptc_1.TabCount < 1 Then Exit Sub
        If Me.Width > 30 Then
            ptc_1.ItemSize = New Size((Me.Width - 30) / ptc_1.TabCount, 25)
        End If
    End Sub

#End Region


End Class