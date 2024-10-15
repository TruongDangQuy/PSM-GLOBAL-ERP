Public Class PFP01637

#Region "Variable"
    Private Dsu01 As Long
    Private wGCODE As String
    Protected prg As E_PRG

    Private W2351 As T2351_AREA
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
        txt_Date.Data = System_Date_8()

        ssp_WHERE.Location = New Point(38, 110)
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
    Private Function DATA_SEARCH_VS10() As Boolean
        DATA_SEARCH_VS10 = False

        Vs10.Enabled = False

        Dim ProdDate As String
        ProdDate = txt_Date.Data
        ProdDate = ProdDate.Replace("/", "").Replace("-", "")

        If txt_cdFactory.Code = "" Then
            MsgBoxP("Factory Plz!")
            Exit Function
        End If


        Try
            DS1 = PrcDS("USP_PFP01637_SEARCH_VS10", cn, ProdDate,
                                                        txt_CustomerCode.Code,
                                                        txt_cdSeason.Code,
                                                        txt_cdFactory.Code,
                                                        txt_cdLineProd.Code,
                                                        txt_SlNoD.Data,
                                                        txt_Line.Data,
                                                        txt_Article.Data)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs10, DS1, "USP_PFP01637_SEARCH_VS10", "vS10")
                Vs10.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs10, DS1, "USP_PFP01637_SEARCH_VS10", "vS10")
            DATA_SEARCH_VS10 = True

            Vs10.Enabled = True

        Catch ex As Exception

        End Try

    End Function

    Private Function DATA_SEARCH_VS11(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS11 = False

        vS11.Enabled = False

        Dim ProdDate As String
        Dim JobCard As String
        Dim cdFactory As String
        Dim cdLineProd As String

        ProdDate = getData(Vs10, getColumIndex(Vs10, "KEY_ProdDate"), Vs10.ActiveSheet.ActiveRowIndex)
        JobCard = getData(Vs10, getColumIndex(Vs10, "KEY_JobCard"), Vs10.ActiveSheet.ActiveRowIndex)
        cdFactory = getData(Vs10, getColumIndex(Vs10, "KEY_cdFactory"), Vs10.ActiveSheet.ActiveRowIndex)
        cdLineProd = getData(Vs10, getColumIndex(Vs10, "KEY_cdLineProd"), Vs10.ActiveSheet.ActiveRowIndex)

        If JobCard = "" Then
            Exit Function
        End If

        Try
            DS1 = PrcDS("USP_PFP01637_SEARCH_VS11", cn, ProdDate,
                                                       JobCard,
                                                       cdFactory,
                                                       cdLineProd)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS11, DS1, "USP_PFP01637_SEARCH_VS11", "vS11")
                vS11.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS11, DS1, "USP_PFP01637_SEARCH_VS11", "vS11")

            Dim i As Integer
            For i = 0 To vS11.ActiveSheet.RowCount - 1

                If Trim$(getData(vS11, getColumIndex(vS11, "FormatRow"), i)) <> "" Then
                    If Trim$(getData(vS11, getColumIndex(vS11, "FormatRow"), i)) = "cButtomHelpColor" Then Call SPR_BACKCOLOR(vS11, cButtomHelpColor, i)
                    If Trim$(getData(vS11, getColumIndex(vS11, "FormatRow"), i)) = "cSprSealNo" Then Call SPR_BACKCOLOR(vS11, cSprSealNo, i)
                    If Trim$(getData(vS11, getColumIndex(vS11, "FormatRow"), i)) = "cSprBalance" Then Call SPR_BACKCOLOR(vS11, cSprBalance, i)
                    If Trim$(getData(vS11, getColumIndex(vS11, "FormatRow"), i)) = "cSprProduction" Then Call SPR_BACKCOLOR(vS11, cSprProduction, i)
                    If Trim$(getData(vS11, getColumIndex(vS11, "FormatRow"), i)) = "cSprSetBalance" Then Call SPR_BACKCOLOR(vS11, cSprSetBalance, i)
                End If

            Next

            Call VsSizeRangeNew_one(vS11, "USP_PFP01637_SEARCH_VS11_HEAD", getColumIndex(vS11, "QtyTotal"), getData(vS11, getColumIndex(vS11, "OrderNo"), 0), getData(vS11, getColumIndex(vS11, "OrderNoSeq"), 0))


            DATA_SEARCH_VS11 = True

            vS11.Enabled = True

        Catch ex As Exception

        End Try

    End Function

#End Region

#Region "Event"
    
    Private Sub Vs10_GotFocus(sender As Object, e As EventArgs)
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False

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

        Call DATA_SEARCH_VS10()

    End Sub

    Private Sub Vs10_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs10.CellDoubleClick
        Call DATA_SEARCH_VS11()
    End Sub

    Private Sub cmd_Closing_Click(sender As Object, e As EventArgs) Handles cmd_Closing.Click
        Msg_Result = MsgBoxP("Do you want to closing all date?", vbYesNo)

        If Msg_Result <> vbYes Then Exit Sub


        Dim Starting As Object
        Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")


        Try
            Call PrcExeNoError("CLOSING_ALL_SUB_PROCESS_PRODUCTION_DATE", cn, Pub.DAT)

        Catch ex As Exception

        Finally
            Starting.close()
        End Try
    End Sub

#End Region

End Class