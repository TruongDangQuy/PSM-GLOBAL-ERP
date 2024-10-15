Public Class PFP13407

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

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

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


    End Sub
#End Region

#Region "Function"
    Private Sub MAIN_JOB01()


    End Sub

    Private Sub MAIN_JOB05()
       

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
            DS1 = PrcDS("USP_PFP13407_SEARCH_Vs10", cn, txt_cdSite.Code, txt_Article.Data, txt_CustPONO.Data)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs10, DS1, "USP_PFP13407_SEARCH_Vs10", "Vs10")

                Vs10.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs10, DS1, "USP_PFP13407_SEARCH_Vs10", "Vs10")
            DATA_SEARCH_Vs10 = True

            Vs10.Enabled = True




        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_Vs10")
        End Try

    End Function

    Private Function DATA_SEARCH_Vs20(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_Vs20 = False

        Vs20.Enabled = False


        Try
            DS1 = PrcDS("USP_PFP13407_SEARCH_Vs20", cn, txt_cdSite.Code, txt_Article.Data, txt_CustPONO.Data)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs20, DS1, "USP_PFP13407_SEARCH_Vs20", "Vs20")

                Vs20.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS20, DS1, "USP_PFP13407_SEARCH_Vs20", "Vs20")

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
            DS1 = PrcDS("USP_PFP13407_SEARCH_Vs30", cn, txt_cdSite.Code, txt_Article.Data, txt_CustPONO.Data)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs30, DS1, "USP_PFP13407_SEARCH_Vs30", "Vs30")

                Vs30.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS30, DS1, "USP_PFP13407_SEARCH_Vs30", "Vs30")



            DATA_SEARCH_Vs30 = True

            Vs30.Enabled = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_Vs30")
        End Try

    End Function

    Private Function DATA_SEARCH_Vs40(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_Vs40 = False

        Vs40.Enabled = False


        Try
            DS1 = PrcDS("USP_PFP13407_SEARCH_Vs40", cn, txt_cdSite.Code, txt_Article.Data, txt_CustPONO.Data)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs40, DS1, "USP_PFP13407_SEARCH_Vs40", "Vs40")

                Vs40.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs40, DS1, "USP_PFP13407_SEARCH_Vs40", "Vs40")
            DATA_SEARCH_Vs40 = True

            Vs40.Enabled = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_Vs40")
        End Try

    End Function

    Private Function DATA_SEARCH_vS50(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_vS50 = False

        vS50.Enabled = False


        Try
            DS1 = PrcDS("USP_PFP13407_SEARCH_vS50", cn, txt_cdSite.Code, txt_Article.Data, txt_CustPONO.Data)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS50, DS1, "USP_PFP13407_SEARCH_vS50", "vS50")

                vS50.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS50, DS1, "USP_PFP13407_SEARCH_vS50", "vS50")
            DATA_SEARCH_vS50 = True

            vS50.Enabled = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_vS50")
        End Try

    End Function


    Private Function DATA_SEARCH_vS60(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_vS60 = False

        vS60.Enabled = False


        Try
            DS1 = PrcDS("USP_PFP13407_SEARCH_vS60", cn, txt_cdSite.Code, txt_Article.Data, txt_CustPONO.Data)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS60, DS1, "USP_PFP13407_SEARCH_vS60", "vS60")

                vS60.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS60, DS1, "USP_PFP13407_SEARCH_vS60", "vS60")
            DATA_SEARCH_vS60 = True

            vS60.Enabled = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_vS60")
        End Try

    End Function


#End Region

#Region "Event"


    Private Sub tst_1_Click(sender As Object, e As EventArgs) Handles tst_1.Click, tst_2.Click, tst_3.Click, tst_4.Click, tst_5.Click, tst_6.Click
       

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
            If ptc_001.SelectedIndex = 4 Then Call DATA_SEARCH_Vs50()
            If ptc_001.SelectedIndex = 5 Then Call DATA_SEARCH_Vs60()

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


    Private Sub vs_GotFocus(sender As Object, e As EventArgs) Handles vS10.GotFocus
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