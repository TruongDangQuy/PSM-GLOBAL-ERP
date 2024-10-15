Public Class PFP01601

#Region "Variable"

    Private Dsu01 As Long     'Data Su
    Private wGCODE As String
    Private Form_Close As Boolean



#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load

        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)

        Me.KeyPreview = True

        Call FORM_INIT()
        Call DATA_INIT()
    End Sub
   
    Private Sub FORM_INIT()

    End Sub

    Private Sub DATA_INIT()
        SdateEdate.text1 = Pub.DAT
        SdateEdate.text2 = Pub.DAT
        txt_cdSubProcess.Code = "003"
        txt_cdSubProcess.Data = "Stitching"
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


    Private Sub MAIN_JOB12()

    End Sub

    Private Sub MAIN_JOB13()

    End Sub

    Private Sub MAIN_JOB14()

    End Sub

    Private Sub MAIN_JOB05()

    End Sub


#End Region

#Region "Data_search"


    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False
        Try
            Vs1.Enabled = False

            If (chk_CheckSL1.Checked) Then
                DS1 = PrcDS("USP_PFP01601_SEARCH_VS1", cn, SdateEdate.text1, _
                       SdateEdate.text2, _
                      txt_cdFactory.Code, _
                      txt_cdSubProcess.Code, _
                      txt_cdLineProd.Code, _
                      txt_cdSeason.Code, _
                      txt_CustomerCode.Code, _
                      txt_Line.Data, _
                      txt_Article.Data, _
                      "1")
            Else
                DS1 = PrcDS("USP_PFP01601_SEARCH_VS1", cn, SdateEdate.text1, _
                       SdateEdate.text2, _
                      txt_cdFactory.Code, _
                      txt_cdSubProcess.Code, _
                      txt_cdLineProd.Code, _
                      txt_cdSeason.Code, _
                      txt_CustomerCode.Code, _
                      txt_Line.Data, _
                      txt_Article.Data, _
                      "2")
            End If

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_PFP01601_SEARCH_VS1", "VS1")
                Vs1.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs1, DS1, "USP_PFP01601_SEARCH_VS1", "VS1")

            Call VsSizeRange(Vs1, "USP_PFP01601_SEARCH_VS1_HEAD", SdateEdate.text1, _
                       SdateEdate.text2, _
                      txt_cdFactory.Code, _
                      txt_cdSubProcess.Code, _
                      txt_cdLineProd.Code, _
                      txt_cdSeason.Code, _
                      txt_CustomerCode.Code, _
                      txt_Line.Data, _
                      txt_Article.Data, _
                      "1")
            DATA_SEARCH_VS1 = True

            Vs1.Enabled = True
        Catch ex As Exception
            MsgBox("DATA_SEARCH_VS1")
        Finally
            Vs1.Enabled = True
        End Try
    End Function

    Private Function DATA_SEARCH_VS2() As Boolean
        DATA_SEARCH_VS2 = False
        Try
            Vs2.Enabled = False
            If (chk_CheckSL1.Checked) Then
                DS1 = PrcDS("USP_PFP01601_SEARCH_VS2", cn, SdateEdate.text1, _
                       SdateEdate.text2, _
                      txt_cdFactory.Code, _
                      txt_cdSubProcess.Code, _
                      txt_cdLineProd.Code, _
                      txt_cdSeason.Code, _
                      txt_CustomerCode.Code, _
                      txt_Line.Data, _
                      txt_Article.Data, _
                                     "1")
            Else
                DS1 = PrcDS("USP_PFP01601_SEARCH_VS2", cn, SdateEdate.text1, _
                       SdateEdate.text2, _
                      txt_cdFactory.Code, _
                      txt_cdSubProcess.Code, _
                      txt_cdLineProd.Code, _
                      txt_cdSeason.Code, _
                      txt_CustomerCode.Code, _
                      txt_Line.Data, _
                      txt_Article.Data, _
                                     "2")
            End If


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs2, DS1, "USP_PFP01601_SEARCH_VS2", "VS2")
                Vs2.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs2, DS1, "USP_PFP01601_SEARCH_VS2", "VS2")
            DATA_SEARCH_VS2 = True

            Vs2.Enabled = True
        Catch ex As Exception
            MsgBox("USP_PFP01601_SEARCH_VS2")
        Finally
            Vs2.Enabled = True
        End Try
    End Function

    Private Function DATA_SEARCH_VS3() As Boolean
        DATA_SEARCH_VS3 = False
        Try
            Vs3.Enabled = False
            If (chk_CheckSL1.Checked) Then
                DS1 = PrcDS("USP_PFP01601_SEARCH_VS3", cn, SdateEdate.text1, _
                       SdateEdate.text2, _
                      txt_cdFactory.Code, _
                      txt_cdSubProcess.Code, _
                      txt_cdLineProd.Code, _
                      txt_cdSeason.Code, _
                      txt_CustomerCode.Code, _
                      txt_Line.Data, _
                      txt_Article.Data, _
                                       "1")
            Else
                DS1 = PrcDS("USP_PFP01601_SEARCH_VS3", cn, SdateEdate.text1, _
                       SdateEdate.text2, _
                      txt_cdFactory.Code, _
                      txt_cdSubProcess.Code, _
                      txt_cdLineProd.Code, _
                      txt_cdSeason.Code, _
                      txt_CustomerCode.Code, _
                      txt_Line.Data, _
                      txt_Article.Data, _
                                       "2")
            End If


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs3, DS1, "USP_PFP01601_SEARCH_VS3", "VS3")
                Vs3.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs3, DS1, "USP_PFP01601_SEARCH_VS3", "VS3")
            DATA_SEARCH_VS3 = True

            Vs3.Enabled = True
        Catch ex As Exception
            MsgBox("USP_PFP01601_SEARCH_VS3")
        Finally
            Vs3.Enabled = True
        End Try
    End Function

    Private Function DATA_SEARCH_VS31() As Boolean
        DATA_SEARCH_VS31 = False
        Dim JobCard As String
        Dim cdLineProd As String
        Dim cdMainProcess As String
        Dim ProdDate As String

        JobCard = getData(Vs3, getColumIndex(Vs3, "KEY_JobCard"), Vs3.ActiveSheet.ActiveRowIndex)
        cdLineProd = getData(Vs3, getColumIndex(Vs3, "KEY_cdLineProd"), Vs3.ActiveSheet.ActiveRowIndex)
        cdMainProcess = getData(Vs3, getColumIndex(Vs3, "KEY_cdSubProcess"), Vs3.ActiveSheet.ActiveRowIndex)
        ProdDate = getData(Vs3, getColumIndex(Vs3, "ProdDate"), Vs3.ActiveSheet.ActiveRowIndex)

        If JobCard = "" Then
            Exit Function
        End If

        ProdDate = ProdDate.Replace("/", "")

        Vs31.Enabled = True
        Try
            DS1 = PrcDS("USP_PFP01601_SEARCH_VS31", cn, txt_cdFactory.Code, cdMainProcess, cdLineProd, JobCard, ProdDate)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs31, DS1, "USP_PFP01601_SEARCH_VS31", "Vs31")
                Vs31.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs31, DS1, "USP_PFP01601_SEARCH_VS31", "Vs31")
            Dim i As Integer
            For i = 0 To Vs31.ActiveSheet.RowCount - 1

                If Trim$(getData(Vs31, getColumIndex(Vs31, "TITILE_S150"), i)) <> "" Then
                    If Trim$(getData(Vs31, getColumIndex(Vs31, "TITILE_S150"), i)) = "1.SealNo" Then Call SPR_BACKCOLOR(Vs31, cSprSealNo, i)
                    If Trim$(getData(Vs31, getColumIndex(Vs31, "TITILE_S150"), i)) = "2.Prod" Then Call SPR_BACKCOLOR(Vs31, cSprProduction, i)
                    If Trim$(getData(Vs31, getColumIndex(Vs31, "TITILE_S150"), i)) = "5.Balance" Then Call SPR_BACKCOLOR(Vs31, cSprBalance, i)

                End If

            Next

            Call VsSizeRangeNew_one(Vs31, "USP_PFP01601_SEARCH_VS31_HEAD", getColumIndex(Vs31, "QtyTotal"), getData(Vs31, getColumIndex(Vs31, "OrderNo"), 0), getData(Vs31, getColumIndex(Vs31, "OrderNoSeq"), 0))

            DATA_SEARCH_VS31 = True

            Vs31.Enabled = True

        Catch ex As Exception

        End Try

    End Function
    Private Function DATA_SEARCH_VS4() As Boolean
        DATA_SEARCH_VS4 = False
        If txt_cdFactory.Code = "" Then
            MsgBox("Can not Search ! Please Input Factory  !")
            Exit Function
        End If
        Try
            Vs4.Enabled = False
            If (chk_CheckSL1.Checked) Then
                DS1 = PrcDS("USP_PFP01601_SEARCH_VS4", cn, SdateEdate.text1, _
                       SdateEdate.text2, _
                      txt_cdFactory.Code, _
                      txt_cdSubProcess.Code, _
                      txt_cdLineProd.Code, _
                      txt_cdSeason.Code, _
                      txt_CustomerCode.Code, _
                      txt_Line.Data, _
                      txt_Article.Data, _
                                        "1")
            Else
                DS1 = PrcDS("USP_PFP01601_SEARCH_VS4", cn, SdateEdate.text1, _
                       SdateEdate.text2, _
                      txt_cdFactory.Code, _
                      txt_cdSubProcess.Code, _
                      txt_cdLineProd.Code, _
                      txt_cdSeason.Code, _
                      txt_CustomerCode.Code, _
                      txt_Line.Data, _
                      txt_Article.Data, _
                                        "2")
            End If


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs4, DS1, "USP_PFP01601_SEARCH_VS4", "Vs4")
                Vs4.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs4, DS1, "USP_PFP01601_SEARCH_VS4", "Vs4")
            DATA_SEARCH_VS4 = True

            Vs4.Enabled = True
        Catch ex As Exception
            MsgBox("USP_PFP01601_SEARCH_VS4")
        Finally
            Vs4.Enabled = True
        End Try
    End Function

    Private Function DATA_SEARCH_VS5() As Boolean
        DATA_SEARCH_VS5 = False

        Try
            If txt_cdFactory.Code = "" Then
                MsgBox("Can not Search ! Please Input Factory  !")
                Exit Function
            End If

            Vs5.Enabled = False
            If (chk_CheckSL1.Checked) Then
                DS1 = PrcDS("USP_PFP01601_SEARCH_VS5", cn, SdateEdate.text1, _
                       SdateEdate.text2, _
                      txt_cdFactory.Code, _
                      txt_cdSubProcess.Code, _
                      txt_cdLineProd.Code, _
                      txt_cdSeason.Code, _
                      txt_CustomerCode.Code, _
                      txt_Line.Data, _
                      txt_Article.Data, _
                                        "1")
            Else
                DS1 = PrcDS("USP_PFP01601_SEARCH_VS5", cn, SdateEdate.text1, _
                       SdateEdate.text2, _
                      txt_cdFactory.Code, _
                      txt_cdSubProcess.Code, _
                      txt_cdLineProd.Code, _
                      txt_cdSeason.Code, _
                      txt_CustomerCode.Code, _
                      txt_Line.Data, _
                      txt_Article.Data, _
                                        "2")
            End If


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs5, DS1, "USP_PFP01601_SEARCH_VS5", "Vs5")
                Vs5.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs5, DS1, "USP_PFP01601_SEARCH_VS5", "Vs5")
            DATA_SEARCH_VS5 = True

            Vs5.Enabled = True
        Catch ex As Exception
            MsgBox("USP_PFP01601_SEARCH_VS5")
        Finally
            Vs5.Enabled = True
        End Try
    End Function

    Private Function DATA_SEARCH_VS6() As Boolean
        DATA_SEARCH_VS6 = False

        Try
            Vs6.Enabled = False
            If (chk_CheckSL1.Checked) Then
                DS1 = PrcDS("USP_PFP01601_SEARCH_VS6", cn, SdateEdate.text1, _
                       SdateEdate.text2, _
                      txt_cdFactory.Code, _
                      txt_cdSubProcess.Code, _
                      txt_cdLineProd.Code, _
                      txt_cdSeason.Code, _
                      txt_CustomerCode.Code, _
                      txt_Line.Data, _
                      txt_Article.Data, _
                                       "1")
            Else
                DS1 = PrcDS("USP_PFP01601_SEARCH_VS6", cn, SdateEdate.text1, _
                       SdateEdate.text2, _
                      txt_cdFactory.Code, _
                      txt_cdSubProcess.Code, _
                      txt_cdLineProd.Code, _
                      txt_cdSeason.Code, _
                      txt_CustomerCode.Code, _
                      txt_Line.Data, _
                      txt_Article.Data, _
                                       "2")
            End If


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs6, DS1, "USP_PFP01601_SEARCH_VS6", "Vs6")
                Vs6.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs6, DS1, "USP_PFP01601_SEARCH_VS6", "Vs6")
            DATA_SEARCH_VS6 = True

            Vs6.Enabled = True
        Catch ex As Exception
            MsgBox("USP_PFP01601_SEARCH_VS6")
        Finally
            Vs6.Enabled = True
        End Try
    End Function

#End Region

#Region "Function"
  
#End Region

#Region "Event"


    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click

        If ptc_1.SelectedIndex = 0 Then Call DATA_SEARCH_VS1()
        If ptc_1.SelectedIndex = 1 Then Call DATA_SEARCH_VS2()
        If ptc_1.SelectedIndex = 2 Then Call DATA_SEARCH_VS3()
        If ptc_1.SelectedIndex = 3 Then Call DATA_SEARCH_VS4()
        If ptc_1.SelectedIndex = 4 Then Call DATA_SEARCH_VS5()
        If ptc_1.SelectedIndex = 5 Then Call DATA_SEARCH_VS6()
    End Sub

    Private Sub Vs3_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs3.CellDoubleClick
        Call DATA_SEARCH_VS31()
    End Sub

    Private Sub Me_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Width > 20 Then
            ptc_1.ItemSize = New Size((Me.Width - 20) / 6, 30)
        End If
    End Sub

#End Region

    Private Sub ptc_1_DoubleClick(sender As Object, e As EventArgs) Handles ptc_1.DoubleClick
        Call cmd_SEARCH.PerformClick()
    End Sub
End Class