Public Class PFP13402

#Region "Variable"
    Private Dsu01 As Long
    Private wGCODE As String
    Protected prg As E_PRG

    Private W1311 As T1311_AREA
    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True

        Call FORM_INIT()
        Call DATA_INIT()

    End Sub
    Private Sub Cms_2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_2.ItemClicked
      

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
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FORM_INIT()
        chk_FSEL.CheckState = 1
        chk_FSEL.BackColor = clrCheck
        chk_FSEL.ForeColor = Color.Black
        Me.chk_FormEnterkey = False

        chk_FSEL.Text = WordConv("CLOSE")
        ssp_WHERE.Visible = True

    End Sub

    Private Sub DATA_INIT()
        Call Gadget_Load(ssp_WHERE, Me.Name)

        txt_Year.Value = CIntp(Strings.Left(Pub.DAT, 4))
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
#End Region

#Region "Data_search"

    Private Function DATA_SEARCH_Vs10(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_Vs10 = False

        Vs10.Enabled = False
        Try
            DS1 = PrcDS("USP_PFP13402_SEARCH_Vs10", cn, txt_cdSite.Code, txt_Year.Value)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS10, DS1, "USP_PFP13402_SEARCH_Vs10", "Vs10")

                vS10.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS10, DS1, "USP_PFP13402_SEARCH_Vs10", "Vs10")
            DATA_SEARCH_Vs10 = True

            vS10.Enabled = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_Vs10")
        End Try

    End Function

    Private Function DATA_SEARCH_Vs20(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_Vs20 = False

        Vs20.Enabled = False


        Try
            DS1 = PrcDS("USP_PFP13402_SEARCH_Vs20", cn, txt_cdSite.Code, txt_Year.Value)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs20, DS1, "USP_PFP13402_SEARCH_Vs20", "Vs20")

                Vs20.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS20, DS1, "USP_PFP13402_SEARCH_Vs20", "Vs20")


            DATA_SEARCH_Vs20 = True

            Vs20.Enabled = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_Vs20")
        End Try

    End Function

    Private Function DATA_SEARCH_Vs30(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_Vs30 = False

        Vs30.Enabled = False


        Try
            DS1 = PrcDS("USP_PFP13402_SEARCH_Vs30", cn, txt_cdSite.Code, txt_Year.Value)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs30, DS1, "USP_PFP13402_SEARCH_Vs30", "Vs30")

                Vs30.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS30, DS1, "USP_PFP13402_SEARCH_Vs30", "Vs30")
            DATA_SEARCH_Vs30 = True

            Vs30.Enabled = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_Vs30")
        End Try

    End Function

    Private Function DATA_SEARCH_vS40(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_vS40 = False

        vS40.Enabled = False


        Try
            DS1 = PrcDS("USP_PFP13402_SEARCH_vS40", cn, txt_cdSite.Code, txt_Year.Value, txt_Declare.Data, txt_Article.Data, txt_TradingCode.Data)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS40, DS1, "USP_PFP13402_SEARCH_vS40", "vS40")

                vS40.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS40, DS1, "USP_PFP13402_SEARCH_vS40", "vS40")
            DATA_SEARCH_vS40 = True

            vS40.Enabled = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_vS40")
        End Try

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
            If ptc_001.SelectedIndex = 0 Then Call DATA_SEARCH_Vs10()
            If ptc_001.SelectedIndex = 1 Then Call DATA_SEARCH_Vs20()
            If ptc_001.SelectedIndex = 2 Then Call DATA_SEARCH_Vs30()
            If ptc_001.SelectedIndex = 3 Then Call DATA_SEARCH_Vs40()
        Catch ex As Exception
            Call MsgBoxP("35", "cmd_SEARCH_Click")
        End Try
    End Sub
    Private Sub Cms_1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_1.ItemClicked
        Try



        Catch ex As Exception
            Call MsgBoxP("35", "cmd_SEARCH_Click")
        End Try

    End Sub

    Private Sub vS10_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS10.CellDoubleClick
        Try
            Dim cdSite As String
            Dim Year As String
            Dim ItemCode As String
            Dim ItemCodeFG As String
            cdSite = txt_cdSite.Code
            Year = txt_Year.Value
            ItemCode = getData(vS10, getColumIndex(vS10, "I9000_ItemCode"), vS10.ActiveSheet.ActiveRowIndex)
            ItemCodeFG = getData(vS10, getColumIndex(vS10, "I9000_ItemCodeFG"), vS10.ActiveSheet.ActiveRowIndex)


            Call HLP13402A.Link_HLP3011Material(e.Column, cdSite, Year, ItemCode, ItemCodeFG)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub vS20_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS20.CellDoubleClick
        Try
            Dim cdSite As String
            Dim Year As String
            Dim ItemCode As String
            Dim ItemCodeFG As String
            cdSite = txt_cdSite.Code
            Year = txt_Year.Value
            ItemCode = getData(vS20, getColumIndex(vS20, "I9000_ItemCode"), vS20.ActiveSheet.ActiveRowIndex)
            ItemCodeFG = getData(vS20, getColumIndex(vS20, "I9000_ItemCodeFG"), vS20.ActiveSheet.ActiveRowIndex)


            Call HLP13402A.Link_HLP3011Material(e.Column, cdSite, Year, ItemCode, ItemCodeFG)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub vS30_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS30.CellDoubleClick
        Try
            Dim cdSite As String
            Dim Year As String
            Dim ItemCode As String
            Dim ItemCodeFG As String
            cdSite = txt_cdSite.Code
            Year = txt_Year.Value
            ItemCode = getData(vS30, getColumIndex(vS30, "I9000_ItemCode"), vS30.ActiveSheet.ActiveRowIndex)
            ItemCodeFG = getData(vS30, getColumIndex(vS30, "I9000_ItemCodeFG"), vS30.ActiveSheet.ActiveRowIndex)


            Call HLP13402A.Link_HLP3011Material(e.Column, cdSite, Year, ItemCode, ItemCodeFG)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub vS40_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS40.CellDoubleClick
        Try
            Dim cdSite As String
            Dim Year As String
            Dim ItemCode As String
            Dim ItemCodeFG As String
            cdSite = txt_cdSite.Code
            Year = txt_Year.Value
            ItemCode = getData(vS40, getColumIndex(vS40, "I9000_ItemCode"), vS40.ActiveSheet.ActiveRowIndex)
            ItemCodeFG = getData(vS40, getColumIndex(vS40, "I9000_ItemCodeFG"), vS40.ActiveSheet.ActiveRowIndex)


            Call HLP13402A.Link_HLP3011Material(e.Column, cdSite, Year, ItemCode, ItemCodeFG)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub vs_GotFocus(sender As Object, e As EventArgs) Handles vS10.GotFocus
        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False
    End Sub

#End Region

End Class