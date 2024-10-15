Public Class PFP01602

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
        txt_Date.Data = System_Date_8()
       
    End Sub

    Private Sub DATA_INIT()

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
    Private Function DATA_SEARCH_VS10() As Boolean
        DATA_SEARCH_VS10 = False
        Try
            Vs1.Enabled = False
            Dim ProdDate As String
            ProdDate = txt_Date.Data
            ProdDate = ProdDate.Replace("/", "").Replace("-", "")
            If (chk_CheckSL1.Checked) Then
                DS1 = PrcDS("USP_PFP01602_SEARCH_VS10", cn, ProdDate, _
                      txt_cdFactory.Code, _
                      txt_cdLineProd.Code, _
                      txt_CustomerCode.Code, _
                      txt_Line.Data, _
                      txt_Article.Data, _
                      "1")
            Else
                DS1 = PrcDS("USP_PFP01602_SEARCH_VS10", cn, ProdDate, _
                      txt_cdFactory.Code, _
                      txt_cdLineProd.Code, _
                      txt_CustomerCode.Code, _
                      txt_Line.Data, _
                      txt_Article.Data, _
                      "2")
            End If

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_PFP01602_SEARCH_VS10", "VS1")
                Vs1.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs1, DS1, "USP_PFP01602_SEARCH_VS10", "VS1")

            '' Jun add P.646-B 2019/04/02 11:32 AM

            'Dim Sheetname = Vs11.ActiveSheet.SheetName

            ''Upper
            'Dim str1 = Vs1.ActiveSheet.GetColumnAutoText(getColumIndex(Vs1, "UpperIn"))
            'str1 = str1 & "1"
            'str1 = Sheetname & "!" & str1

            'Dim str2 = Vs1.ActiveSheet.GetColumnAutoText(getColumIndex(Vs1, "UpperOut"))
            'str2 = str2 & "1"
            'str2 = Sheetname & "!" & str2
            'str2 = str2 & " < " & str1

            'Dim TmpConFor1 As New FarPoint.Win.Spread.FormulaConditionalFormattingRule(str2)
            'TmpConFor1.BackColor = Color.Red
            'TmpConFor1.ForeColor = Color.White

            'Dim TmpConFor2 As New FarPoint.Win.Spread.FormulaConditionalFormattingRule(str2)
            'TmpConFor2.BackColor = Color.Red
            'TmpConFor2.ForeColor = Color.White

            'Vs1.ActiveSheet.SetConditionalFormatting(0, getColumIndex(Vs1, "UpperIn"), Vs1.ActiveSheet.RowCount, 1, TmpConFor1)
            'Vs1.ActiveSheet.SetConditionalFormatting(0, getColumIndex(Vs1, "UpperOut"), Vs1.ActiveSheet.RowCount, 1, TmpConFor2)
            ''End Upper

            ''Outsole
            'Dim str3 = Vs1.ActiveSheet.GetColumnAutoText(getColumIndex(Vs1, "OutsoleIn"))
            'str3 = str3 & "1"
            'str3 = Sheetname & "!" & str3

            'Dim str4 = Vs1.ActiveSheet.GetColumnAutoText(getColumIndex(Vs1, "OutsoleOut"))
            'str4 = str4 & "1"
            'str4 = Sheetname & "!" & str4
            'str4 = str4 & " < " & str3

            'Dim TmpConFor3 As New FarPoint.Win.Spread.FormulaConditionalFormattingRule(str4)
            'TmpConFor3.BackColor = Color.Red
            'TmpConFor3.ForeColor = Color.White

            'Dim TmpConFor4 As New FarPoint.Win.Spread.FormulaConditionalFormattingRule(str4)
            'TmpConFor4.BackColor = Color.Red
            'TmpConFor4.ForeColor = Color.White

            'Vs1.ActiveSheet.SetConditionalFormatting(0, getColumIndex(Vs1, "OutsoleIn"), Vs1.ActiveSheet.RowCount, 1, TmpConFor3)
            'Vs1.ActiveSheet.SetConditionalFormatting(0, getColumIndex(Vs1, "OutsoleOut"), Vs1.ActiveSheet.RowCount, 1, TmpConFor4)
            ''End Outsole

            ''Footbed
            'Dim str5 = Vs1.ActiveSheet.GetColumnAutoText(getColumIndex(Vs1, "FootbedIn"))
            'str5 = str5 & "1"
            'str5 = Sheetname & "!" & str5

            'Dim str6 = Vs1.ActiveSheet.GetColumnAutoText(getColumIndex(Vs1, "FootbedOut"))
            'str6 = str6 & "1"
            'str6 = Sheetname & "!" & str6
            'str6 = str6 & " < " & str5

            'Dim TmpConFor5 As New FarPoint.Win.Spread.FormulaConditionalFormattingRule(str6)
            'TmpConFor5.BackColor = Color.Red
            'TmpConFor5.ForeColor = Color.White

            'Dim TmpConFor6 As New FarPoint.Win.Spread.FormulaConditionalFormattingRule(str6)
            'TmpConFor6.BackColor = Color.Red
            'TmpConFor6.ForeColor = Color.White

            'Vs1.ActiveSheet.SetConditionalFormatting(0, getColumIndex(Vs1, "FootbedIn"), Vs1.ActiveSheet.RowCount, 1, TmpConFor5)
            'Vs1.ActiveSheet.SetConditionalFormatting(0, getColumIndex(Vs1, "FootbedOut"), Vs1.ActiveSheet.RowCount, 1, TmpConFor6)
            'End Footbed
            ' End Jun add P.646-B 2019/04/02 11:32 AM
            DATA_SEARCH_VS10 = True

            Vs1.Enabled = True
        Catch ex As Exception
            MsgBox("DATA_SEARCH_VS10")
        Finally
            Vs1.Enabled = True
        End Try
    End Function

    Private Function DATA_SEARCH_VS11() As Boolean
        DATA_SEARCH_VS11 = False
        Dim JobCard As String
        Dim cdLineProd As String
        Dim cdMainProcess As String
        Dim ProdDate As String

        JobCard = getData(Vs1, getColumIndex(Vs1, "KEY_JobCard"), Vs1.ActiveSheet.ActiveRowIndex)
        cdLineProd = getData(Vs1, getColumIndex(Vs1, "KEY_cdLineProd"), Vs1.ActiveSheet.ActiveRowIndex)
        cdMainProcess = getData(Vs1, getColumIndex(Vs1, "KEY_cdSubProcess"), Vs1.ActiveSheet.ActiveRowIndex)
        ProdDate = getData(Vs1, getColumIndex(Vs1, "ProdDate"), Vs1.ActiveSheet.ActiveRowIndex)

        If JobCard = "" Then
            Exit Function
        End If

        ProdDate = ProdDate.Replace("/", "").Replace("-", "")

        Vs11.Enabled = True
        Try
            DS1 = PrcDS("USP_PFP01602_SEARCH_VS11", cn, txt_cdFactory.Code, cdMainProcess, cdLineProd, JobCard, ProdDate)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs11, DS1, "USP_PFP01602_SEARCH_VS11", "Vs11")
                Vs11.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs11, DS1, "USP_PFP01602_SEARCH_VS11", "Vs11")
            Dim i As Integer
            For i = 0 To Vs11.ActiveSheet.RowCount - 1

                If Trim$(getData(Vs11, getColumIndex(Vs11, "FormatRow"), i)) <> "" Then
                    If Trim$(getData(Vs11, getColumIndex(Vs11, "FormatRow"), i)) = "cButtomHelpColor" Then Call SPR_BACKCOLOR(Vs11, cButtomHelpColor, i)
                    If Trim$(getData(Vs11, getColumIndex(Vs11, "FormatRow"), i)) = "cSprSealNo" Then Call SPR_BACKCOLOR(Vs11, cSprSealNo, i)
                    If Trim$(getData(Vs11, getColumIndex(Vs11, "FormatRow"), i)) = "cSprBalance" Then Call SPR_BACKCOLOR(Vs11, cSprBalance, i)
                    If Trim$(getData(Vs11, getColumIndex(Vs11, "FormatRow"), i)) = "cSprProduction" Then Call SPR_BACKCOLOR(Vs11, cSprProduction, i)
                    If Trim$(getData(Vs11, getColumIndex(Vs11, "FormatRow"), i)) = "cSprSetBalance" Then Call SPR_BACKCOLOR(Vs11, cSprSetBalance, i)
                End If

            Next

            Call VsSizeRangeNew_one(Vs11, "USP_PFP01602_SEARCH_VS11_HEAD", getColumIndex(Vs11, "QtyTotal"), getData(Vs11, getColumIndex(Vs11, "OrderNo"), 0), getData(Vs11, getColumIndex(Vs11, "OrderNoSeq"), 0))

            DATA_SEARCH_VS11 = True

            Vs11.Enabled = True

        Catch ex As Exception

        End Try

    End Function

    Private Function DATA_SEARCH_VS20() As Boolean
        DATA_SEARCH_VS20 = False
        Try
            Vs2.Enabled = False
            Dim ProdDate As String
            ProdDate = txt_Date.Data
            ProdDate = ProdDate.Replace("/", "").Replace("-", "")

            If (chk_CheckSL1.Checked) Then
                DS1 = PrcDS("USP_PFP01602_SEARCH_VS20", cn, ProdDate, _
                      txt_cdFactory.Code, _
                      txt_cdLineProd.Code, _
                      txt_CustomerCode.Code, _
                      txt_Line.Data, _
                      txt_Article.Data, _
                                     "1")
            Else
                DS1 = PrcDS("USP_PFP01602_SEARCH_VS20", cn, ProdDate,
                      txt_cdFactory.Code, _
                      txt_cdLineProd.Code, _
                      txt_CustomerCode.Code, _
                      txt_Line.Data, _
                      txt_Article.Data, _
                                     "2")
            End If


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs2, DS1, "USP_PFP01602_SEARCH_VS20", "VS2")
                Vs2.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs2, DS1, "USP_PFP01602_SEARCH_VS20", "VS2")
            DATA_SEARCH_VS20 = True

            Vs2.Enabled = True
        Catch ex As Exception
            MsgBox("USP_PFP01602_SEARCH_VS20")
        Finally
            Vs2.Enabled = True
        End Try
    End Function

    Private Function DATA_SEARCH_VS21() As Boolean
        DATA_SEARCH_VS21 = False
        Dim JobCard As String
        Dim cdLineProd As String
        Dim cdMainProcess As String
        Dim ProdDate As String

        JobCard = getData(Vs2, getColumIndex(Vs2, "KEY_JobCard"), Vs2.ActiveSheet.ActiveRowIndex)
        cdLineProd = getData(Vs2, getColumIndex(Vs2, "KEY_cdLineProd"), Vs2.ActiveSheet.ActiveRowIndex)
        cdMainProcess = getData(Vs2, getColumIndex(Vs2, "KEY_cdSubProcess"), Vs2.ActiveSheet.ActiveRowIndex)
        ProdDate = getData(Vs2, getColumIndex(Vs2, "ProdDate"), Vs2.ActiveSheet.ActiveRowIndex)

        If JobCard = "" Then
            Exit Function
        End If
    
        ProdDate = ProdDate.Replace("/", "").Replace("-", "")

        Vs21.Enabled = True
        Try
            DS1 = PrcDS("USP_PFP01602_SEARCH_VS21", cn, txt_cdFactory.Code, cdMainProcess, cdLineProd, JobCard, ProdDate)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs21, DS1, "USP_PFP01602_SEARCH_VS21", "Vs21")
                Vs21.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs21, DS1, "USP_PFP01602_SEARCH_VS21", "Vs21")
            Dim i As Integer
            For i = 0 To Vs21.ActiveSheet.RowCount - 1

                If Trim$(getData(Vs21, getColumIndex(Vs21, "FormatRow"), i)) <> "" Then
                    If Trim$(getData(Vs21, getColumIndex(Vs21, "FormatRow"), i)) = "cButtomHelpColor" Then Call SPR_BACKCOLOR(Vs21, cButtomHelpColor, i)
                    If Trim$(getData(Vs21, getColumIndex(Vs21, "FormatRow"), i)) = "cSprSealNo" Then Call SPR_BACKCOLOR(Vs21, cSprSealNo, i)
                    If Trim$(getData(Vs21, getColumIndex(Vs21, "FormatRow"), i)) = "cSprBalance" Then Call SPR_BACKCOLOR(Vs21, cSprBalance, i)
                    If Trim$(getData(Vs21, getColumIndex(Vs21, "FormatRow"), i)) = "cSprProduction" Then Call SPR_BACKCOLOR(Vs21, cSprProduction, i)
                    If Trim$(getData(Vs21, getColumIndex(Vs21, "FormatRow"), i)) = "cSprSetBalance" Then Call SPR_BACKCOLOR(Vs21, cSprSetBalance, i)
                End If

            Next

            Call VsSizeRangeNew_one(Vs21, "USP_PFP01602_SEARCH_VS21_HEAD", getColumIndex(Vs21, "QtyTotal"), getData(Vs21, getColumIndex(Vs21, "OrderNo"), 0), getData(Vs21, getColumIndex(Vs21, "OrderNoSeq"), 0))

            DATA_SEARCH_VS21 = True

            Vs21.Enabled = True

        Catch ex As Exception

        End Try

    End Function

    Private Function DATA_SEARCH_VS30() As Boolean
        DATA_SEARCH_VS30 = False
        Try
            Vs3.Enabled = False
            Dim ProdDate As String
            ProdDate = txt_Date.Data
            ProdDate = ProdDate.Replace("/", "").Replace("-", "")
            If (chk_CheckSL1.Checked) Then
                DS1 = PrcDS("USP_PFP01602_SEARCH_VS30", cn, ProdDate, _
                      txt_cdFactory.Code, _
                      txt_cdLineProd.Code, _
                      txt_CustomerCode.Code, _
                      txt_Line.Data, _
                      txt_Article.Data, _
                                       "1")
            Else
                DS1 = PrcDS("USP_PFP01602_SEARCH_VS30", cn, ProdDate, _
                      txt_cdFactory.Code, _
                      txt_cdLineProd.Code, _
                      txt_CustomerCode.Code, _
                      txt_Line.Data, _
                      txt_Article.Data, _
                                       "2")
            End If


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs3, DS1, "USP_PFP01602_SEARCH_VS30", "VS3")
                Vs3.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs3, DS1, "USP_PFP01602_SEARCH_VS30", "VS3")
            DATA_SEARCH_VS30 = True

            Vs3.Enabled = True
        Catch ex As Exception
            MsgBox("USP_PFP01602_SEARCH_VS30")
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

        ProdDate = ProdDate.Replace("/", "").Replace("-", "")

        Vs31.Enabled = True
        Try
            DS1 = PrcDS("USP_PFP01602_SEARCH_VS31", cn, txt_cdFactory.Code, cdMainProcess, cdLineProd, JobCard, ProdDate)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs31, DS1, "USP_PFP01602_SEARCH_VS31", "Vs31")
                Vs31.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs31, DS1, "USP_PFP01602_SEARCH_VS31", "Vs31")
            Dim i As Integer
            For i = 0 To Vs31.ActiveSheet.RowCount - 1

                If Trim$(getData(Vs31, getColumIndex(Vs31, "FormatRow"), i)) <> "" Then
                    If Trim$(getData(Vs31, getColumIndex(Vs31, "FormatRow"), i)) = "cButtomHelpColor" Then Call SPR_BACKCOLOR(Vs31, cButtomHelpColor, i)
                    If Trim$(getData(Vs31, getColumIndex(Vs31, "FormatRow"), i)) = "cSprSealNo" Then Call SPR_BACKCOLOR(Vs31, cSprSealNo, i)
                    If Trim$(getData(Vs31, getColumIndex(Vs31, "FormatRow"), i)) = "cSprBalance" Then Call SPR_BACKCOLOR(Vs31, cSprBalance, i)
                    If Trim$(getData(Vs31, getColumIndex(Vs31, "FormatRow"), i)) = "cSprProduction" Then Call SPR_BACKCOLOR(Vs31, cSprProduction, i)
                    If Trim$(getData(Vs31, getColumIndex(Vs31, "FormatRow"), i)) = "cSprSetBalance" Then Call SPR_BACKCOLOR(Vs31, cSprSetBalance, i)
                End If

            Next

            Call VsSizeRangeNew_one(Vs31, "USP_PFP01602_SEARCH_VS31_HEAD", getColumIndex(Vs31, "QtyTotal"), getData(Vs31, getColumIndex(Vs31, "OrderNo"), 0), getData(Vs31, getColumIndex(Vs31, "OrderNoSeq"), 0))

            DATA_SEARCH_VS31 = True

            Vs31.Enabled = True

        Catch ex As Exception

        End Try

    End Function

#End Region

#Region "Function"

#End Region

#Region "Event"
    Private Sub ptc_1_DoubleClick(sender As Object, e As EventArgs) Handles ptc_1.DoubleClick

        Call cmd_SEARCH.PerformClick()

    End Sub
    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click

        If ptc_1.SelectedIndex = 0 Then Call DATA_SEARCH_VS10()
        If ptc_1.SelectedIndex = 1 Then Call DATA_SEARCH_VS20()
        If ptc_1.SelectedIndex = 2 Then Call DATA_SEARCH_VS30()

    End Sub
    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        Call DATA_SEARCH_VS11()
    End Sub
    Private Sub Vs2_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs2.CellDoubleClick
        Call DATA_SEARCH_VS21()
    End Sub
    Private Sub Vs3_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs3.CellDoubleClick
        Call DATA_SEARCH_VS31()
    End Sub

    Private Sub Me_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Width > 20 Then
            ptc_1.ItemSize = New Size((Me.Width - 20) / 3, 30)
        End If
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