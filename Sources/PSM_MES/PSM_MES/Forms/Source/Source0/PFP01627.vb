Public Class PFP01627

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
            Dim cdFactory As String

            Select Case Strings.Right(Me.PeaceFormType, 2).ToUpper
                Case "F1"
                    cdFactory = "001"

                Case "F2"
                    cdFactory = "002"

                Case "F3"
                    cdFactory = "003"

                Case "OS"
                    cdFactory = "051"
            End Select

            DS1 = PrcDS("USP_PFP01627_SEARCH_VS10", cn, _
                  cdFactory, _
                  txt_cdSeason.Code, _
                  txt_CustomerCode.Code, _
                  txt_Line.Data, _
                  txt_Article.Data, _
                  txt_SlNoD.Data)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_PFP01627_SEARCH_VS10", "VS1")
                Vs1.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs1, DS1, "USP_PFP01627_SEARCH_VS10", "VS1")

            'Call VsSizeRange(Vs1, "USP_PFP01627_SEARCH_VS10", SdateEdate.text1, _
            '           SdateEdate.text2, _
            '          txt_cdFactory.Code, _
            '          txt_cdLineProd.Code, _
            '          txt_CustomerCode.Code, _
            '          txt_Line.Data, _
            '          txt_Article.Data, _
            '          "1")

            DATA_SEARCH_VS10 = True

            Vs1.Enabled = True
        Catch ex As Exception
            MsgBox("DATA_SEARCH_VS10")
        Finally
            Vs1.Enabled = True
        End Try
    End Function

    Private Function DATA_SEARCH_VS20(cdFactory As String, cdSeason As String, CustomerCode As String, OrderNo As String, OrderNoSeq As String, JobCard As String) As Boolean
        DATA_SEARCH_VS20 = False
        Try
            Vs2.Enabled = False

            DS1 = PrcDS("USP_PFP01627_SEARCH_VS20", cn, cdFactory, _
                      cdSeason, _
                      CustomerCode, _
                      OrderNo, _
                      OrderNoSeq, _
                      JobCard)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs2, DS1, "USP_PFP01627_SEARCH_VS20", "VS2")
                Vs2.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs2, DS1, "USP_PFP01627_SEARCH_VS20", "VS2")

            Dim i As Integer
            For i = 0 To Vs2.ActiveSheet.RowCount - 1
                Dim FormatRowValue As String = Trim$(getData(Vs2, getColumIndex(Vs2, "FormatRow"), i))
                If FormatRowValue <> "" Then
                    Select Case FormatRowValue
                        Case "cButtomHelpColor"
                            Call SPR_BACKCOLOR(Vs2, cButtomHelpColor, i)
                        Case "cSprSealNo"
                            Call SPR_BACKCOLOR(Vs2, cSprSealNo, i)
                        Case "cSprBalance"
                            Call SPR_BACKCOLOR(Vs2, cSprBalance, i)
                        Case "cSprProduction"
                            Call SPR_BACKCOLOR(Vs2, cSprProduction, i)
                        Case "cSprSetBalance"
                            Call SPR_BACKCOLOR(Vs2, cSprSetBalance, i)
                        Case Else
                            If FormatRowValue.Contains(";") And FormatRowValue.Split(";").Count = 3 Then
                                Call SPR_BACKCOLOR(Vs2, System.Drawing.Color.FromArgb(CType(CType(FormatRowValue.Split(";")(0), Byte), Integer), CType(CType(FormatRowValue.Split(";")(1), Byte), Integer), CType(CType(FormatRowValue.Split(";")(2), Byte), Integer)), i)
                            End If
                    End Select
                End If

            Next

            Call VsSizeRangeNew_Many(Vs2, "USP_PFP01627_SEARCH_VS20_HEAD", getColumIndex(Vs2, "QtyTotal"), OrderNo, OrderNoSeq)

            DATA_SEARCH_VS20 = True

            Vs2.Enabled = True
        Catch ex As Exception
            MsgBox("USP_PFP01627_SEARCH_VS20")
        Finally
            Vs2.Enabled = True
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
        'If ptc_1.SelectedIndex = 1 Then Call DATA_SEARCH_VS20()

    End Sub
    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick

        ptc_1.SelectedIndex = 1

        Dim cdFactory As String = ""
        Dim cdSeason As String = ""
        Dim CustomerCode As String = ""
        Dim OrderNo As String = ""
        Dim OrderNoSeq As String = ""
        Dim JobCard As String = ""


        Select Case Strings.Right(Me.PeaceFormType, 2).ToUpper
            Case "F1"
                cdFactory = "001"

            Case "F2"
                cdFactory = "002"

            Case "F3"
                cdFactory = "003"

            Case "OS"
                cdFactory = "051"
        End Select

        cdSeason = txt_cdSeason.Code
        CustomerCode = txt_CustomerCode.Code
        OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)
        OrderNoSeq = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNoSeq"), Vs1.ActiveSheet.ActiveRowIndex)
        JobCard = getData(Vs1, getColumIndex(Vs1, "KEY_JobCard"), Vs1.ActiveSheet.ActiveRowIndex)

        Call DATA_SEARCH_VS20(cdFactory, cdSeason, CustomerCode, OrderNo, OrderNoSeq, JobCard)

    End Sub
    'Private Sub Vs2_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs2.CellDoubleClick
    '    Call DATA_SEARCH_VS21()
    'End Sub

    Private Sub Me_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Width > 20 Then
            ptc_1.ItemSize = New Size((Me.Width - 20) / 2, 30)
        End If
    End Sub

#End Region

End Class