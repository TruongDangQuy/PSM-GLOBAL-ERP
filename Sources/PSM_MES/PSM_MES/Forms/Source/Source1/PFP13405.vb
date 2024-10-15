Public Class PFP13405

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

        Call Cms_additem(Cms_1, "UPLOAD CONTROL" & "(F5)", "DELETE CONTROL" & "(F6)")

        vS10.ContextMenuStrip = Cms_1


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
                Case Keys.F6 : Call MAIN_JOB02()

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
        SdateEdate.text1 = System_Date_6() & "01"
        SdateEdate.text2 = Function_Date_Add(FSDate(SdateEdate.text1), 1, -1)

    End Sub
#End Region

#Region "Function"
    Private Sub MAIN_JOB01()
        Dim strKey As String


     
        If ptc_001.SelectedIndex <> 0 Then Exit Sub

        
        Try
            strKey = DatePart(DateInterval.WeekOfYear, CDate(FSDate(Pub.DAT))).ToString("00")
            strKey = Strings.Left(Pub.DAT, 4) & strKey


            If ISUD1340U.Link_ISUD1340U(1, strKey) = False Then Exit Sub

        Catch ex As Exception

        End Try

    End Sub
    Private Sub MAIN_JOB02()
        Dim strKey As String

        Try
            strKey = getData(vS10, getColumIndex(vS10, "KEY_WeekNO"), vS10.ActiveSheet.ActiveRowIndex)
            Dim str As String = MsgBoxP("Do you want to delete " & strKey, vbYesNo)
            If str <> vbYes Then Exit Sub
            If MsgBoxPPW("Please type the password to delete!", const_pwDeleteLiq) = False Then GoTo next1

            Call PrcExeNoError("USP_PFL13405_DELETE_WEEKNO", cn, strKey)

            Call DATA_SEARCH_Vs10()

next1:

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB02!", vbCritical)
        End Try
    End Sub

 
#End Region

#Region "Data_search"

    Private Function DATA_SEARCH_Vs10(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_Vs10 = False

        Vs10.Enabled = False


        Try
            DS1 = PrcDS("USP_PFP13405_SEARCH_Vs10", cn, SdateEdate.text1, SdateEdate.text2, txt_cdSite.Code, txt_Article.Data, txt_CustPONO.Data)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs10, DS1, "USP_PFP13405_SEARCH_Vs10", "Vs10")

                Vs10.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs10, DS1, "USP_PFP13405_SEARCH_Vs10", "Vs10")
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
            DS1 = PrcDS("USP_PFP13405_SEARCH_Vs20", cn, SdateEdate.text1, SdateEdate.text2, txt_cdSite.Code, txt_Article.Data, txt_CustPONO.Data)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs20, DS1, "USP_PFP13405_SEARCH_Vs20", "Vs20")

                Vs20.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS20, DS1, "USP_PFP13405_SEARCH_Vs20", "Vs20")

            DATA_SEARCH_Vs20 = True

            Vs20.Enabled = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_Vs20")
        End Try

    End Function

    Private Function DATA_SEARCH_vS30(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_vS30 = False

        vS30.Enabled = False


        Try
            DS1 = PrcDS("USP_PFP13405_SEARCH_vS30", cn, SdateEdate.text1, SdateEdate.text2, txt_cdSite.Code, txt_Article.Data, txt_CustPONO.Data)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS30, DS1, "USP_PFP13405_SEARCH_vS30", "vS30")

                vS30.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS30, DS1, "USP_PFP13405_SEARCH_vS30", "vS30")

            DATA_SEARCH_vS30 = True

            vS30.Enabled = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_vS30")
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

            If Cms_1.Items(1).Selected = True Then
                Cms_1.Hide()
                MAIN_JOB02()

            End If

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




    Private Sub vSChange(xROW As Integer)
        Try

            Dim KEY_Autokey As String = getData(vS10, getColumIndex(vS10, "KEY_Autokey"), xROW)
            Dim DSTP_new As String = getData(vS10, getColumIndex(vS10, "DSTP_new"), xROW)
            Dim StrValue As String


            StrValue = PrcExeNoError_Value("USP_PFL13405_UPDATE_WEEKNO_DSTP", cn, KEY_Autokey, DSTP_new, Pub.SAW, Pub.DAT)

            setData(vS10, getColumIndex(vS10, "Result"), xROW, StrValue)



        Catch ex As Exception

        End Try
    End Sub
    Private Sub Vs10_Change(sender As Object, e As ChangeEventArgs) Handles vS10.Change
        Try
            Dim xROW As Integer

            xROW = e.Row

            vSChange(xROW)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Vs10_KeyDown(sender As Object, e As KeyEventArgs) Handles vS10.KeyDown
        Try
            Dim xROW As Integer
            If e.KeyCode = Keys.Enter Then

                xROW = Vs10.ActiveSheet.ActiveRowIndex

                vSChange(xROW)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class