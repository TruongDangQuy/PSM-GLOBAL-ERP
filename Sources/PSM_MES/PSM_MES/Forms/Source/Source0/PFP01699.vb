Public Class PFP01699

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
        txt_sDate.Data = System_Date_8()
        txt_sDate.Visible = True
 
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
    Private Function DATA_SEARCH_vS00() As Boolean
        DATA_SEARCH_vS00 = False
        Try
            vS00.Enabled = False

            DS1 = PrcDS("USP_PFP01699_SEARCH_vS00", cn, txt_sDate.Data, _
                       txt_cdFactory.Code, _
                       txt_cdLineProd.Code, _
                       txt_cdSeason.Code,
                       txt_CustomerCode.Code, _
                       txt_Line.Data, _
                       txt_Article.Data)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS00, DS1, "USP_PFP01699_SEARCH_vS00", "vS00")
                vS00.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS00, DS1, "USP_PFP01699_SEARCH_vS00", "vS00")


            DATA_SEARCH_vS00 = True

            vS00.Enabled = True
        Catch ex As Exception
            MsgBox("DATA_SEARCH_vS00")
        Finally
            vS00.Enabled = True
        End Try
    End Function

    Private Function DATA_SEARCH_VS10() As Boolean
        DATA_SEARCH_VS10 = False
        Try
            vS10.Enabled = False

            DS1 = PrcDS("USP_PFP01699_SEARCH_VS10", cn, txt_sDate.Data, _
                       txt_cdFactory.Code, _
                       txt_cdLineProd.Code, _
                       txt_cdSeason.Code,
                       txt_CustomerCode.Code, _
                       txt_Line.Data, _
                       txt_Article.Data)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS10, DS1, "USP_PFP01699_SEARCH_VS10", "Vs10")
                vS10.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS10, DS1, "USP_PFP01699_SEARCH_VS10", "Vs10")


            DATA_SEARCH_VS10 = True

            vS10.Enabled = True
        Catch ex As Exception
            MsgBox("DATA_SEARCH_VS10")
        Finally
            vS10.Enabled = True
        End Try
    End Function
    Private Function DATA_SEARCH_VS_LINE(sender As Object, receiver As Object, SheetName As String) As Boolean
        DATA_SEARCH_VS_LINE = False
        Dim JobCard As String
        Dim cdLineProd As String
        Dim cdMainProcess As String
        Dim ProdDate As String
        Dim OrderNo As String
        Dim OrderNoSeq As String

        OrderNo = getData(sender, getColumIndex(sender, "KEY_OrderNo"), sender.ActiveSheet.ActiveRowIndex)
        OrderNoSeq = getData(sender, getColumIndex(sender, "KEY_OrderNoSeq"), sender.ActiveSheet.ActiveRowIndex)

        JobCard = getData(sender, getColumIndex(sender, "KEY_JobCard"), sender.ActiveSheet.ActiveRowIndex)
        cdLineProd = getData(sender, getColumIndex(sender, "KEY_cdLineProd"), sender.ActiveSheet.ActiveRowIndex)
        cdMainProcess = getData(sender, getColumIndex(sender, "KEY_cdSubProcess"), sender.ActiveSheet.ActiveRowIndex)
        ProdDate = txt_sDate.Data

       

        receiver.Enabled = True

        If SheetName.ToUpper = "VS71" Or SheetName.ToUpper = "VS81" Then


            If OrderNo = "" Then
                Exit Function
            End If

            Try
                DS1 = PrcDS("USP_PFP01699_SEARCH_" & SheetName, cn, txt_cdFactory.Code, cdMainProcess, cdLineProd, OrderNo, OrderNoSeq, ProdDate)

                If GetDsRc(DS1) = 0 Then
                    SPR_PRO_NEW(receiver, DS1, "USP_PFP01699_SEARCH_" & SheetName, SheetName)
                    receiver.Enabled = True
                    Exit Function
                End If

                SPR_PRO_NEW(receiver, DS1, "USP_PFP01699_SEARCH_" & SheetName, SheetName)

                Dim i As Integer
                For i = 0 To receiver.ActiveSheet.RowCount - 1

                    If Trim$(getData(receiver, getColumIndex(receiver, "FormatRow"), i)) <> "" Then
                        If Trim$(getData(receiver, getColumIndex(receiver, "FormatRow"), i)) = "cButtomHelpColor" Then Call SPR_BACKCOLOR(receiver, cButtomHelpColor, i)
                        If Trim$(getData(receiver, getColumIndex(receiver, "FormatRow"), i)) = "cSprSealNo" Then Call SPR_BACKCOLOR(receiver, cSprSealNo, i)
                        If Trim$(getData(receiver, getColumIndex(receiver, "FormatRow"), i)) = "cSprBalance" Then Call SPR_BACKCOLOR(receiver, cSprBalance, i)
                        If Trim$(getData(receiver, getColumIndex(receiver, "FormatRow"), i)) = "cSprProduction" Then Call SPR_BACKCOLOR(receiver, cSprProduction, i)
                        If Trim$(getData(receiver, getColumIndex(receiver, "FormatRow"), i)) = "cSprSetBalance" Then Call SPR_BACKCOLOR(receiver, cSprSetBalance, i)
                    End If

                Next

                Call VsSizeRangeNew_one(receiver, "USP_PFP01699_SEARCH_HEAD", getColumIndex(receiver, "QtyTotal"), getData(receiver, getColumIndex(receiver, "OrderNo"), 0), getData(receiver, getColumIndex(receiver, "OrderNoSeq"), 0))

                DATA_SEARCH_VS_LINE = True

                receiver.Enabled = True

            Catch ex As Exception

            End Try
            Exit Function

        End If

        If JobCard = "" Then
            Exit Function
        End If

        Try
            DS1 = PrcDS("USP_PFP01699_SEARCH_" & SheetName, cn, txt_cdFactory.Code, cdMainProcess, cdLineProd, JobCard, ProdDate)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(receiver, DS1, "USP_PFP01699_SEARCH_" & SheetName, SheetName)
                receiver.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(receiver, DS1, "USP_PFP01699_SEARCH_" & SheetName, SheetName)

            Dim i As Integer
            For i = 0 To receiver.ActiveSheet.RowCount - 1

                If Trim$(getData(receiver, getColumIndex(receiver, "FormatRow"), i)) <> "" Then
                    If Trim$(getData(receiver, getColumIndex(receiver, "FormatRow"), i)) = "cButtomHelpColor" Then Call SPR_BACKCOLOR(receiver, cButtomHelpColor, i)
                    If Trim$(getData(receiver, getColumIndex(receiver, "FormatRow"), i)) = "cSprSealNo" Then Call SPR_BACKCOLOR(receiver, cSprSealNo, i)
                    If Trim$(getData(receiver, getColumIndex(receiver, "FormatRow"), i)) = "cSprBalance" Then Call SPR_BACKCOLOR(receiver, cSprBalance, i)
                    If Trim$(getData(receiver, getColumIndex(receiver, "FormatRow"), i)) = "cSprProduction" Then Call SPR_BACKCOLOR(receiver, cSprProduction, i)
                    If Trim$(getData(receiver, getColumIndex(receiver, "FormatRow"), i)) = "cSprSetBalance" Then Call SPR_BACKCOLOR(receiver, cSprSetBalance, i)
                End If

            Next

            Call VsSizeRangeNew_one(receiver, "USP_PFP01699_SEARCH_HEAD", getColumIndex(receiver, "QtyTotal"), getData(receiver, getColumIndex(receiver, "OrderNo"), 0), getData(receiver, getColumIndex(receiver, "OrderNoSeq"), 0))

            DATA_SEARCH_VS_LINE = True

            receiver.Enabled = True

        Catch ex As Exception

        End Try

    End Function

    Private Function DATA_SEARCH_VS11() As Boolean
        DATA_SEARCH_VS11 = False
        Dim JobCard As String
        Dim cdLineProd As String
        Dim cdMainProcess As String
        Dim ProdDate As String

        JobCard = getData(vS10, getColumIndex(vS10, "KEY_JobCard"), vS10.ActiveSheet.ActiveRowIndex)
        cdLineProd = getData(vS10, getColumIndex(vS10, "KEY_cdLineProd"), vS10.ActiveSheet.ActiveRowIndex)
        cdMainProcess = getData(vS10, getColumIndex(vS10, "KEY_cdSubProcess"), vS10.ActiveSheet.ActiveRowIndex)
        ProdDate = txt_sDate.Data

        If JobCard = "" Then
            Exit Function
        End If



        Vs11.Enabled = True
        Try
            DS1 = PrcDS("USP_PFP01699_SEARCH_VS11", cn, txt_cdFactory.Code, cdMainProcess, cdLineProd, JobCard, ProdDate)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs11, DS1, "USP_PFP01699_SEARCH_VS11", "Vs11")
                Vs11.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs11, DS1, "USP_PFP01699_SEARCH_VS11", "Vs11")
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

            Call VsSizeRangeNew_one(Vs11, "USP_PFP01699_SEARCH_VS11_HEAD", getColumIndex(Vs11, "QtyTotal"), getData(Vs11, getColumIndex(Vs11, "OrderNo"), 0), getData(Vs11, getColumIndex(Vs11, "OrderNoSeq"), 0))

            DATA_SEARCH_VS11 = True

            Vs11.Enabled = True

        Catch ex As Exception

        End Try

    End Function

    Private Function DATA_SEARCH_VS20() As Boolean
        DATA_SEARCH_VS20 = False
        Try
            Vs20.Enabled = False

            DS1 = PrcDS("USP_PFP01699_SEARCH_VS20", cn, txt_sDate.Data, _
                       txt_cdFactory.Code, _
                       txt_cdLineProd.Code, _
                       txt_cdSeason.Code,
                       txt_CustomerCode.Code, _
                       txt_Line.Data, _
                       txt_Article.Data)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs20, DS1, "USP_PFP01699_SEARCH_VS20", "Vs20")
                Vs20.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs20, DS1, "USP_PFP01699_SEARCH_VS20", "Vs20")
            DATA_SEARCH_VS20 = True

            Vs20.Enabled = True
        Catch ex As Exception
            MsgBox("USP_PFP01699_SEARCH_VS20")
        Finally
            Vs20.Enabled = True
        End Try
    End Function

    Private Function DATA_SEARCH_VS21() As Boolean
        DATA_SEARCH_VS21 = False
        Dim JobCard As String
        Dim cdLineProd As String
        Dim cdMainProcess As String
        Dim ProdDate As String

        JobCard = getData(Vs20, getColumIndex(Vs20, "KEY_JobCard"), Vs20.ActiveSheet.ActiveRowIndex)
        cdLineProd = getData(Vs20, getColumIndex(Vs20, "KEY_cdLineProd"), Vs20.ActiveSheet.ActiveRowIndex)
        cdMainProcess = getData(Vs20, getColumIndex(Vs20, "KEY_cdSubProcess"), Vs20.ActiveSheet.ActiveRowIndex)
        ProdDate = getData(Vs20, getColumIndex(Vs20, "ProdDate"), Vs20.ActiveSheet.ActiveRowIndex)

        If JobCard = "" Then
            Exit Function
        End If

        ProdDate = ProdDate.Replace("/", "").Replace("-", "")

        Vs21.Enabled = True
        Try
            DS1 = PrcDS("USP_PFP01699_SEARCH_VS21", cn, txt_cdFactory.Code, cdMainProcess, cdLineProd, JobCard, ProdDate)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs21, DS1, "USP_PFP01699_SEARCH_VS21", "Vs21")
                Vs21.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs21, DS1, "USP_PFP01699_SEARCH_VS21", "Vs21")
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

            Call VsSizeRangeNew_one(Vs21, "USP_PFP01699_SEARCH_VS21_HEAD", getColumIndex(Vs21, "QtyTotal"), getData(Vs21, getColumIndex(Vs21, "OrderNo"), 0), getData(Vs21, getColumIndex(Vs21, "OrderNoSeq"), 0))

            DATA_SEARCH_VS21 = True

            Vs21.Enabled = True

        Catch ex As Exception

        End Try

    End Function

    Private Function DATA_SEARCH_VS30() As Boolean
        DATA_SEARCH_VS30 = False
        Try
            Vs30.Enabled = False

            DS1 = PrcDS("USP_PFP01699_SEARCH_VS30", cn, txt_sDate.Data, _
                       txt_cdFactory.Code, _
                       txt_cdLineProd.Code, _
                       txt_cdSeason.Code,
                       txt_CustomerCode.Code, _
                       txt_Line.Data, _
                       txt_Article.Data)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs30, DS1, "USP_PFP01699_SEARCH_VS30", "Vs30")
                Vs30.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs30, DS1, "USP_PFP01699_SEARCH_VS30", "Vs30")
            DATA_SEARCH_VS30 = True

            Vs30.Enabled = True
        Catch ex As Exception
            MsgBox("USP_PFP01699_SEARCH_VS30")
        Finally
            Vs30.Enabled = True
        End Try
    End Function

    Private Function DATA_SEARCH_VS31() As Boolean
        DATA_SEARCH_VS31 = False
        Dim JobCard As String
        Dim cdLineProd As String
        Dim cdMainProcess As String
        Dim ProdDate As String

        JobCard = getData(Vs30, getColumIndex(Vs30, "KEY_JobCard"), Vs30.ActiveSheet.ActiveRowIndex)
        cdLineProd = getData(Vs30, getColumIndex(Vs30, "KEY_cdLineProd"), Vs30.ActiveSheet.ActiveRowIndex)
        cdMainProcess = getData(Vs30, getColumIndex(Vs30, "KEY_cdSubProcess"), Vs30.ActiveSheet.ActiveRowIndex)
        ProdDate = getData(Vs30, getColumIndex(Vs30, "ProdDate"), Vs30.ActiveSheet.ActiveRowIndex)

        If JobCard = "" Then
            Exit Function
        End If

        ProdDate = ProdDate.Replace("/", "").Replace("-", "")

        Vs31.Enabled = True
        Try
            DS1 = PrcDS("USP_PFP01699_SEARCH_VS31", cn, txt_cdFactory.Code, cdMainProcess, cdLineProd, JobCard, ProdDate)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs31, DS1, "USP_PFP01699_SEARCH_VS31", "Vs31")
                Vs31.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs31, DS1, "USP_PFP01699_SEARCH_VS31", "Vs31")
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

            Call VsSizeRangeNew_one(Vs31, "USP_PFP01699_SEARCH_VS31_HEAD", getColumIndex(Vs31, "QtyTotal"), getData(Vs31, getColumIndex(Vs31, "OrderNo"), 0), getData(Vs31, getColumIndex(Vs31, "OrderNoSeq"), 0))

            DATA_SEARCH_VS31 = True

            Vs31.Enabled = True

        Catch ex As Exception

        End Try

    End Function



    Private Function DATA_SEARCH_vS40() As Boolean
        DATA_SEARCH_vS40 = False
        Try
            vS40.Enabled = False

            DS1 = PrcDS("USP_PFP01699_SEARCH_VS40", cn, txt_sDate.Data, _
                       txt_cdFactory.Code, _
                       txt_cdLineProd.Code, _
                       txt_cdSeason.Code,
                       txt_CustomerCode.Code, _
                       txt_Line.Data, _
                       txt_Article.Data)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS40, DS1, "USP_PFP01699_SEARCH_vS40", "vS40")
                vS40.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS40, DS1, "USP_PFP01699_SEARCH_vS40", "vS40")
            DATA_SEARCH_vS40 = True

            vS40.Enabled = True
        Catch ex As Exception
            MsgBox("USP_PFP01699_SEARCH_vS40")
        Finally
            vS40.Enabled = True
        End Try
    End Function

    Private Function DATA_SEARCH_vS41() As Boolean
        DATA_SEARCH_vS41 = False
        Dim JobCard As String
        Dim cdLineProd As String
        Dim cdMainProcess As String
        Dim ProdDate As String

        JobCard = getData(vS40, getColumIndex(vS40, "KEY_JobCard"), vS40.ActiveSheet.ActiveRowIndex)
        cdLineProd = getData(vS40, getColumIndex(vS40, "KEY_cdLineProd"), vS40.ActiveSheet.ActiveRowIndex)
        cdMainProcess = getData(vS40, getColumIndex(vS40, "KEY_cdSubProcess"), vS40.ActiveSheet.ActiveRowIndex)
        ProdDate = getData(vS40, getColumIndex(vS40, "ProdDate"), vS40.ActiveSheet.ActiveRowIndex)

        If JobCard = "" Then
            Exit Function
        End If

        ProdDate = ProdDate.Replace("/", "").Replace("-", "")

        vS41.Enabled = True
        Try
            DS1 = PrcDS("USP_PFP01699_SEARCH_vS41", cn, txt_cdFactory.Code, cdMainProcess, cdLineProd, JobCard, ProdDate)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS41, DS1, "USP_PFP01699_SEARCH_vS41", "vS41")
                vS41.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS41, DS1, "USP_PFP01699_SEARCH_vS41", "vS41")
            Dim i As Integer
            For i = 0 To vS41.ActiveSheet.RowCount - 1

                If Trim$(getData(vS41, getColumIndex(vS41, "FormatRow"), i)) <> "" Then
                    If Trim$(getData(vS41, getColumIndex(vS41, "FormatRow"), i)) = "cButtomHelpColor" Then Call SPR_BACKCOLOR(vS41, cButtomHelpColor, i)
                    If Trim$(getData(vS41, getColumIndex(vS41, "FormatRow"), i)) = "cSprSealNo" Then Call SPR_BACKCOLOR(vS41, cSprSealNo, i)
                    If Trim$(getData(vS41, getColumIndex(vS41, "FormatRow"), i)) = "cSprBalance" Then Call SPR_BACKCOLOR(vS41, cSprBalance, i)
                    If Trim$(getData(vS41, getColumIndex(vS41, "FormatRow"), i)) = "cSprProduction" Then Call SPR_BACKCOLOR(vS41, cSprProduction, i)
                    If Trim$(getData(vS41, getColumIndex(vS41, "FormatRow"), i)) = "cSprSetBalance" Then Call SPR_BACKCOLOR(vS41, cSprSetBalance, i)
                End If

            Next

            Call VsSizeRangeNew_one(vS41, "USP_PFP01699_SEARCH_vS41_HEAD", getColumIndex(vS41, "QtyTotal"), getData(vS41, getColumIndex(vS41, "OrderNo"), 0), getData(vS41, getColumIndex(vS41, "OrderNoSeq"), 0))

            DATA_SEARCH_vS41 = True

            vS41.Enabled = True

        Catch ex As Exception

        End Try

    End Function

    Private Function DATA_SEARCH_vS50() As Boolean
        DATA_SEARCH_vS50 = False
        Try
            vS50.Enabled = False

            DS1 = PrcDS("USP_PFP01699_SEARCH_VS50", cn, txt_sDate.Data, _
                       txt_cdFactory.Code, _
                       txt_cdLineProd.Code, _
                       txt_cdSeason.Code,
                       txt_CustomerCode.Code, _
                       txt_Line.Data, _
                       txt_Article.Data)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS50, DS1, "USP_PFP01699_SEARCH_vS50", "vS50")
                vS50.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS50, DS1, "USP_PFP01699_SEARCH_vS50", "vS50")
            DATA_SEARCH_vS50 = True

            vS50.Enabled = True
        Catch ex As Exception
            MsgBox("USP_PFP01699_SEARCH_vS50")
        Finally
            vS50.Enabled = True
        End Try
    End Function

    Private Function DATA_SEARCH_vS51() As Boolean
        DATA_SEARCH_vS51 = False
        Dim JobCard As String
        Dim cdLineProd As String
        Dim cdMainProcess As String
        Dim ProdDate As String

        JobCard = getData(vS50, getColumIndex(vS50, "KEY_JobCard"), vS50.ActiveSheet.ActiveRowIndex)
        cdLineProd = getData(vS50, getColumIndex(vS50, "KEY_cdLineProd"), vS50.ActiveSheet.ActiveRowIndex)
        cdMainProcess = getData(vS50, getColumIndex(vS50, "KEY_cdSubProcess"), vS50.ActiveSheet.ActiveRowIndex)
        ProdDate = getData(vS50, getColumIndex(vS50, "ProdDate"), vS50.ActiveSheet.ActiveRowIndex)

        If JobCard = "" Then
            Exit Function
        End If

        ProdDate = ProdDate.Replace("/", "").Replace("-", "")

        vS51.Enabled = True
        Try
            DS1 = PrcDS("USP_PFP01699_SEARCH_vS51", cn, txt_cdFactory.Code, cdMainProcess, cdLineProd, JobCard, ProdDate)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS51, DS1, "USP_PFP01699_SEARCH_vS51", "vS51")
                vS51.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS51, DS1, "USP_PFP01699_SEARCH_vS51", "vS51")
            Dim i As Integer
            For i = 0 To vS51.ActiveSheet.RowCount - 1

                If Trim$(getData(vS51, getColumIndex(vS51, "FormatRow"), i)) <> "" Then
                    If Trim$(getData(vS51, getColumIndex(vS51, "FormatRow"), i)) = "cButtomHelpColor" Then Call SPR_BACKCOLOR(vS51, cButtomHelpColor, i)
                    If Trim$(getData(vS51, getColumIndex(vS51, "FormatRow"), i)) = "cSprSealNo" Then Call SPR_BACKCOLOR(vS51, cSprSealNo, i)
                    If Trim$(getData(vS51, getColumIndex(vS51, "FormatRow"), i)) = "cSprBalance" Then Call SPR_BACKCOLOR(vS51, cSprBalance, i)
                    If Trim$(getData(vS51, getColumIndex(vS51, "FormatRow"), i)) = "cSprProduction" Then Call SPR_BACKCOLOR(vS51, cSprProduction, i)
                    If Trim$(getData(vS51, getColumIndex(vS51, "FormatRow"), i)) = "cSprSetBalance" Then Call SPR_BACKCOLOR(vS51, cSprSetBalance, i)
                End If

            Next

            Call VsSizeRangeNew_one(vS51, "USP_PFP01699_SEARCH_vS51_HEAD", getColumIndex(vS51, "QtyTotal"), getData(vS51, getColumIndex(vS51, "OrderNo"), 0), getData(vS51, getColumIndex(vS51, "OrderNoSeq"), 0))

            DATA_SEARCH_vS51 = True

            vS51.Enabled = True

        Catch ex As Exception

        End Try

    End Function



    Private Function DATA_SEARCH_vS60() As Boolean
        DATA_SEARCH_vS60 = False
        Try
            vS60.Enabled = False

            DS1 = PrcDS("USP_PFP01699_SEARCH_VS60", cn, txt_sDate.Data, _
                       txt_cdFactory.Code, _
                       txt_cdLineProd.Code, _
                       txt_cdSeason.Code,
                       txt_CustomerCode.Code, _
                       txt_Line.Data, _
                       txt_Article.Data)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS60, DS1, "USP_PFP01699_SEARCH_vS60", "vS60")
                vS60.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS60, DS1, "USP_PFP01699_SEARCH_vS60", "vS60")
            DATA_SEARCH_vS60 = True

            vS60.Enabled = True
        Catch ex As Exception
            MsgBox("USP_PFP01699_SEARCH_vS60")
        Finally
            vS60.Enabled = True
        End Try
    End Function

    Private Function DATA_SEARCH_vS70() As Boolean
        DATA_SEARCH_vS70 = False
        Try
            vS70.Enabled = False

            DS1 = PrcDS("USP_PFP01699_SEARCH_vS70", cn, txt_sDate.Data, _
                       txt_cdFactory.Code, _
                       txt_cdLineProd.Code, _
                       txt_cdSeason.Code,
                       txt_CustomerCode.Code, _
                       txt_Line.Data, _
                       txt_Article.Data)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS70, DS1, "USP_PFP01699_SEARCH_vS70", "vS70")
                vS70.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS70, DS1, "USP_PFP01699_SEARCH_vS70", "vS70")
            DATA_SEARCH_vS70 = True

            vS70.Enabled = True
        Catch ex As Exception
            MsgBox("USP_PFP01699_SEARCH_vS70")
        Finally
            vS70.Enabled = True
        End Try
    End Function

    Private Function DATA_SEARCH_vS80() As Boolean
        DATA_SEARCH_vS80 = False
        Try
            vS80.Enabled = False

            DS1 = PrcDS("USP_PFP01699_SEARCH_vS80", cn, txt_sDate.Data, _
                       txt_cdFactory.Code, _
                       txt_cdLineProd.Code, _
                       txt_cdSeason.Code,
                       txt_CustomerCode.Code, _
                       txt_Line.Data, _
                       txt_Article.Data)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS80, DS1, "USP_PFP01699_SEARCH_vS80", "vS80")
                vS80.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS80, DS1, "USP_PFP01699_SEARCH_vS80", "vS80")
            DATA_SEARCH_vS80 = True

            vS80.Enabled = True
        Catch ex As Exception
            MsgBox("USP_PFP01699_SEARCH_vS80")
        Finally
            vS80.Enabled = True
        End Try
    End Function

    Private Function DATA_SEARCH_vS61() As Boolean
        DATA_SEARCH_vS61 = False
        Dim JobCard As String
        Dim cdLineProd As String
        Dim cdMainProcess As String
        Dim ProdDate As String

        JobCard = getData(vS60, getColumIndex(vS60, "KEY_JobCard"), vS60.ActiveSheet.ActiveRowIndex)
        cdLineProd = getData(vS60, getColumIndex(vS60, "KEY_cdLineProd"), vS60.ActiveSheet.ActiveRowIndex)
        cdMainProcess = getData(vS60, getColumIndex(vS60, "KEY_cdSubProcess"), vS60.ActiveSheet.ActiveRowIndex)
        ProdDate = getData(vS60, getColumIndex(vS60, "ProdDate"), vS60.ActiveSheet.ActiveRowIndex)

        If JobCard = "" Then
            Exit Function
        End If

        ProdDate = ProdDate.Replace("/", "").Replace("-", "")

        vS61.Enabled = True
        Try
            DS1 = PrcDS("USP_PFP01699_SEARCH_vS61", cn, txt_cdFactory.Code, cdMainProcess, cdLineProd, JobCard, ProdDate)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS61, DS1, "USP_PFP01699_SEARCH_vS61", "vS61")
                vS61.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS61, DS1, "USP_PFP01699_SEARCH_vS61", "vS61")
            Dim i As Integer
            For i = 0 To vS61.ActiveSheet.RowCount - 1

                If Trim$(getData(vS61, getColumIndex(vS61, "FormatRow"), i)) <> "" Then
                    If Trim$(getData(vS61, getColumIndex(vS61, "FormatRow"), i)) = "cButtomHelpColor" Then Call SPR_BACKCOLOR(vS61, cButtomHelpColor, i)
                    If Trim$(getData(vS61, getColumIndex(vS61, "FormatRow"), i)) = "cSprSealNo" Then Call SPR_BACKCOLOR(vS61, cSprSealNo, i)
                    If Trim$(getData(vS61, getColumIndex(vS61, "FormatRow"), i)) = "cSprBalance" Then Call SPR_BACKCOLOR(vS61, cSprBalance, i)
                    If Trim$(getData(vS61, getColumIndex(vS61, "FormatRow"), i)) = "cSprProduction" Then Call SPR_BACKCOLOR(vS61, cSprProduction, i)
                    If Trim$(getData(vS61, getColumIndex(vS61, "FormatRow"), i)) = "cSprSetBalance" Then Call SPR_BACKCOLOR(vS61, cSprSetBalance, i)
                End If

            Next

            Call VsSizeRangeNew_one(vS61, "USP_PFP01699_SEARCH_vS61_HEAD", getColumIndex(vS61, "QtyTotal"), getData(vS61, getColumIndex(vS61, "OrderNo"), 0), getData(vS61, getColumIndex(vS61, "OrderNoSeq"), 0))

            DATA_SEARCH_vS61 = True

            vS61.Enabled = True

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
        If ptc_1.SelectedIndex = 0 Then Call DATA_SEARCH_vS00()
        If ptc_1.SelectedIndex = 1 Then Call DATA_SEARCH_VS10()
        If ptc_1.SelectedIndex = 2 Then Call DATA_SEARCH_VS20()
        If ptc_1.SelectedIndex = 3 Then Call DATA_SEARCH_VS30()
        If ptc_1.SelectedIndex = 4 Then Call DATA_SEARCH_vS40()
        If ptc_1.SelectedIndex = 5 Then Call DATA_SEARCH_vS50()
        If ptc_1.SelectedIndex = 6 Then Call DATA_SEARCH_vS60()
        If ptc_1.SelectedIndex = 7 Then Call DATA_SEARCH_vS70()
        If ptc_1.SelectedIndex = 8 Then Call DATA_SEARCH_vS80()
    End Sub
    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS10.CellDoubleClick, Vs20.CellDoubleClick, Vs30.CellDoubleClick, vS40.CellDoubleClick, vS50.CellDoubleClick, vS60.CellDoubleClick, vS70.CellDoubleClick, vS80.CellDoubleClick
        If sender Is vS10 Then
            Call DATA_SEARCH_VS_LINE(vS10, Vs11, "vS11")
        ElseIf sender Is Vs20 Then
            Call DATA_SEARCH_VS_LINE(Vs20, Vs21, "vS21")
        ElseIf sender Is Vs30 Then
            Call DATA_SEARCH_VS_LINE(Vs30, Vs31, "vS31")
        ElseIf sender Is vS40 Then
            Call DATA_SEARCH_VS_LINE(vS40, vS41, "vS41")
        ElseIf sender Is vS50 Then
            Call DATA_SEARCH_VS_LINE(vS50, vS51, "vS51")
        ElseIf sender Is vS60 Then
            Call DATA_SEARCH_VS_LINE(vS60, vS61, "vS61")
        ElseIf sender Is vS70 Then
            Call DATA_SEARCH_VS_LINE(vS70, vS71, "vS71")
        ElseIf sender Is vS80 Then
            Call DATA_SEARCH_VS_LINE(vS80, vS81, "vS81")
        End If
    End Sub

    Private Sub Me_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Width > 20 Then
            ptc_1.ItemSize = New Size((Me.Width - 20) / ptc_1.TabCount, 30)
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