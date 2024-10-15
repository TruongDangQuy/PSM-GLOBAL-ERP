Public Class PFP30114
#Region "Variable"
    Private Dsu01 As Long
    Private wGCODE As String
    Private Form_Close As Boolean
#End Region

#Region "Form_load"

    Private Sub PFP30114_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control = True And e.KeyCode = Keys.G Then
            chk_Total.Checked = Not chk_Total.Checked
        End If
    End Sub
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)

        Me.KeyPreview = True

        Call FORM_INIT()
        Call DATA_INIT()

        SdateEdate.text1 = System_Date_8()
        SdateEdate.text2 = System_Date_8()
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

        SplitContainer1.Panel1Collapsed = True
        SplitContainer2.Panel1Collapsed = True
        SplitContainer3.Panel1Collapsed = True

    End Sub

    Private Sub DATA_INIT()
        If Me.Name = "PFP30114RnD" Then
            chk_CheckSample.Checked = True
            chk_CheckSample.Enabled = False
        Else
            chk_CheckSample.Checked = False
            chk_CheckSample.Enabled = False
        End If
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

    Private Sub MAIN_JOB07()
       

    End Sub

#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS1(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS1 = False
        Vs1.Enabled = False

        If chk_Period.Checked = True Then
            DS1 = PrcDS("USP_PFP30114_SEARCH_VS1_F1", cn, SdateEdate.text1,
                                                       SdateEdate.text2,
                                                       txt_PRName.Data,
                                                       txt_cdSite.Code,
                                                       txt_Customer.Code,
                                                       txt_SupplierCode.Code,
                                                       txt_Article.Data,
                                                       txt_Line.Data,
                                                       txt_MaterialCode.Data,
                                                       txt_cdLargeGroupMaterial.Code,
                                                       txt_cdSemiGroupMaterial.Code,
                                                       txt_cdDetailGroupMaterial.Code,
                                                       chk_CheckUse.CheckState)
            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_PFP30114_SEARCH_VS1_F1", "Vs1")
                Vs1.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs1, DS1, "USP_PFP30114_SEARCH_VS1_F1", "Vs1")
            DATA_SEARCH_VS1 = True

            Vs1.Enabled = True

        Else
            DS1 = PrcDS("USP_PFP30114_SEARCH_VS1", cn, SdateEdate.text1,
                                                    SdateEdate.text2,
                                                    txt_PRName.Data,
                                                    txt_cdSite.Code,
                                                    txt_Customer.Code,
                                                    txt_SupplierCode.Code,
                                                    txt_Article.Data,
                                                    txt_Line.Data,
                                                    txt_MaterialCode.Data,
                                                    txt_cdLargeGroupMaterial.Code,
                                                    txt_cdSemiGroupMaterial.Code,
                                                    txt_cdDetailGroupMaterial.Code,
                                                    chk_CheckUse.CheckState)
            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_PFP30114_SEARCH_VS1", "Vs1")
                Vs1.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs1, DS1, "USP_PFP30114_SEARCH_VS1", "Vs1")
            DATA_SEARCH_VS1 = True

            Vs1.Enabled = True
        End If



    End Function

    Public Function DATA_SEARCH_HEAD_vs_Season() As Boolean
        DATA_SEARCH_HEAD_vs_Season = False

        Try
            DS1 = PrcDS("USP_PFP30114_SEARCH_VS_SEASON", cn, ListCode("Season"))
            SPR_PRO_NEW(vs_Season, DS1, "USP_PFP30114_SEARCH_VS_SEASON", "vs_Season")

            DS1 = Nothing
            DATA_SEARCH_HEAD_vs_Season = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Public Function DATA_SEARCH_HEAD_vS_Cus() As Boolean
        DATA_SEARCH_HEAD_vS_Cus = False

        Dim cdSeason As String
        cdSeason = getData(vs_Season, getColumIndex(vs_Season, "BasicCode"), vs_Season.ActiveSheet.ActiveRowIndex)


        If READ_PFK7171(ListCode("Season"), cdSeason) Then
            txt_cdSite.Code = D7171.BasicCode
            txt_cdSite.Data = D7171.BasicName
        End If


        Try
            If chk_Period.Checked = True Then
                DS1 = PrcDS("USP_PFP30114_SEARCH_vS_Cus_F1", cn, SdateEdate.text1, SdateEdate.text2, txt_CustomerCode.Code, cdSeason,
                                                       chk_CheckSample.CheckState)
                SPR_PRO_NEW(vS_Cus, DS1, "USP_PFP30114_SEARCH_vS_Cus_F1", "vS_Cus")

                SplitContainer1.SplitterDistance = SPR_SHEETWIDHT(vS_Cus) + cSprWidthSize

                DS1 = Nothing
                DATA_SEARCH_HEAD_vS_Cus = True

            Else
                DS1 = PrcDS("USP_PFP30114_SEARCH_vS_Cus", cn, txt_CustomerCode.Code, cdSeason,
                                                       chk_CheckSample.CheckState)
                SPR_PRO_NEW(vS_Cus, DS1, "USP_PFP30114_SEARCH_vS_Cus", "vS_Cus")

                SplitContainer1.SplitterDistance = SPR_SHEETWIDHT(vS_Cus) + cSprWidthSize

                DS1 = Nothing
                DATA_SEARCH_HEAD_vS_Cus = True
            End If


        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Public Function DATA_SEARCH_HEAD_vS_Line() As Boolean
        DATA_SEARCH_HEAD_vS_Line = False
        Dim cdSeason As String
        Dim CustomerCode As String

        cdSeason = getData(vs_Season, getColumIndex(vs_Season, "BasicCode"), vs_Season.ActiveSheet.ActiveRowIndex)
        CustomerCode = getData(vS_Cus, getColumIndex(vS_Cus, "CustomerCode"), vS_Cus.ActiveSheet.ActiveRowIndex)

        If READ_PFK7171(ListCode("Season"), cdSeason) Then
            txt_cdSite.Code = D7171.BasicCode
            txt_cdSite.Data = D7171.BasicName
        End If

        If READ_PFK7101(CustomerCode) Then
            txt_SupplierCode.Code = D7101.CustomerCode
            txt_SupplierCode.Data = D7101.CustomerName
        End If

        Try
            If chk_Period.Checked = True Then
                DS1 = PrcDS("USP_PFP30114_SEARCH_vS_Line_F1", cn, SdateEdate.text1, SdateEdate.text2, cdSeason, CustomerCode,
                                                       chk_CheckSample.CheckState)

                SPR_PRO_NEW(vS_Line, DS1, "USP_PFP30114_SEARCH_vS_Line_F1", "vS_Line")
                SplitContainer2.SplitterDistance = SPR_SHEETWIDHT(vS_Line) + cSprWidthSize

                DS1 = Nothing
                DATA_SEARCH_HEAD_vS_Line = True

            Else
                DS1 = PrcDS("USP_PFP30114_SEARCH_vS_Line", cn, cdSeason, CustomerCode,
                                                       chk_CheckSample.CheckState)

                SPR_PRO_NEW(vS_Line, DS1, "USP_PFP30114_SEARCH_vS_Line", "vS_Line")
                SplitContainer2.SplitterDistance = SPR_SHEETWIDHT(vS_Line) + cSprWidthSize

                DS1 = Nothing
                DATA_SEARCH_HEAD_vS_Line = True
            End If


        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Public Function DATA_SEARCH_HEAD_vs_Large() As Boolean
        DATA_SEARCH_HEAD_vs_Large = False
        Dim cdSeason As String
        Dim CustomerCode As String
        Dim Line As String

        cdSeason = getData(vs_Season, getColumIndex(vs_Season, "BasicCode"), vs_Season.ActiveSheet.ActiveRowIndex)
        CustomerCode = getData(vS_Cus, getColumIndex(vS_Cus, "CustomerCode"), vS_Cus.ActiveSheet.ActiveRowIndex)
        Line = getData(vS_Line, getColumIndex(vS_Line, "Line"), vS_Line.ActiveSheet.ActiveRowIndex)

        Try
            If chk_Period.Checked = True Then
                DS1 = PrcDS("USP_PFP30114_SEARCH_vS_Large_F1", cn, SdateEdate.text1, SdateEdate.text2, ListCode("LargeGroupMaterial"), CustomerCode, cdSeason, Line,
                                                      chk_CheckSample.CheckState)

                SPR_PRO_NEW(vs_Large, DS1, "USP_PFP30114_SEARCH_vS_Large_F1", "vs_Large")
                SplitContainer2.SplitterDistance = SPR_SHEETWIDHT(vs_Large) + cSprWidthSize

                DS1 = Nothing
                DATA_SEARCH_HEAD_vs_Large = True

            Else
                DS1 = PrcDS("USP_PFP30114_SEARCH_vS_Large", cn, ListCode("LargeGroupMaterial"), CustomerCode, cdSeason, Line,
                                                    chk_CheckSample.CheckState)

                SPR_PRO_NEW(vs_Large, DS1, "USP_PFP30114_SEARCH_vS_Large", "vs_Large")
                SplitContainer2.SplitterDistance = SPR_SHEETWIDHT(vs_Large) + cSprWidthSize

                DS1 = Nothing
                DATA_SEARCH_HEAD_vs_Large = True
            End If


        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function


    Private Function LINE_MOVE_DISPLAY01() As Boolean
        LINE_MOVE_DISPLAY01 = False
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
        If sender.Equals(tst_5) Then
            MAIN_JOB05()
        End If
    End Sub
    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        If e.ColumnHeader = True Then Exit Sub
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.AddSelection(e.Row, e.Column, 1, 1)
    End Sub

    Private Sub vS1_GotFocus(sender As Object, e As EventArgs) Handles Vs1.GotFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False
    End Sub
    Private Sub txt_GNAME_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Enter : cmd_SEARCH.Focus()
        End Select
    End Sub

    Private Sub Vs1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown

    End Sub
    Private Sub vS1_LostFocus(sender As Object, e As EventArgs) Handles Vs1.LostFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False)

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

        If chk_Total.Checked = False Then
            Call DATA_SEARCH_VS1()
        Else
            Call DATA_SEARCH_HEAD_vs_Season()
            Call DATA_SEARCH_HEAD_vS_Cus()
        End If

    End Sub

    Private Sub vs_Season_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vs_Season.CellDoubleClick
        txt_cdSite.Code = ""
        txt_cdSite.Data = ""

        txt_CustomerCode.Code = ""
        txt_CustomerCode.Data = ""

        txt_SupplierCode.Code = ""
        txt_SupplierCode.Data = ""

        vS_Cus.ActiveSheet.RowCount = 0
        vS_Line.ActiveSheet.RowCount = 0
        vs_Large.ActiveSheet.RowCount = 0

        Vs1.ActiveSheet.RowCount = 0

        Call DATA_SEARCH_HEAD_vS_Cus()

    End Sub
    Private Sub vS_Cus_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS_Cus.CellDoubleClick
        txt_CustomerCode.Code = ""
        txt_CustomerCode.Data = ""

        txt_Line.Code = ""
        txt_Line.Data = ""

        txt_cdLargeGroupMaterial.Code = ""
        txt_cdLargeGroupMaterial.Data = ""

        txt_cdSemiGroupMaterial.Code = ""
        txt_cdSemiGroupMaterial.Data = ""

        txt_SupplierCode.Code = ""
        txt_SupplierCode.Data = ""

        vS_Line.ActiveSheet.RowCount = 0
        vs_Large.ActiveSheet.RowCount = 0
        Vs1.ActiveSheet.RowCount = 0


        Call DATA_SEARCH_HEAD_vS_Line()

    End Sub
    Private Sub vS_Line_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS_Line.CellDoubleClick
        txt_Line.Code = ""
        txt_Line.Data = ""

        txt_Line.Code = getData(vS_Line, getColumIndex(vS_Line, "Line"), vS_Line.ActiveSheet.ActiveRowIndex)
        txt_Line.Data = getData(vS_Line, getColumIndex(vS_Line, "Line"), vS_Line.ActiveSheet.ActiveRowIndex)

        txt_cdLargeGroupMaterial.Code = ""
        txt_cdLargeGroupMaterial.Data = ""

        txt_cdSemiGroupMaterial.Code = ""
        txt_cdSemiGroupMaterial.Data = ""

        vs_Large.ActiveSheet.RowCount = 0
        Vs1.ActiveSheet.RowCount = 0

        Call DATA_SEARCH_VS1()
        Call DATA_SEARCH_HEAD_vs_Large()

    End Sub

    Private Sub vs_Large_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vs_Large.CellDoubleClick
        Try
            Dim cdLargeGroupMaterial As String

            cdLargeGroupMaterial = getData(vs_Large, getColumIndex(vs_Large, "BasicCode"), vs_Large.ActiveSheet.ActiveRowIndex)

            If READ_PFK7171(ListCode("LargeGroupMaterial"), cdLargeGroupMaterial) Then
                txt_cdLargeGroupMaterial.Code = D7171.BasicCode
                txt_cdLargeGroupMaterial.Data = D7171.BasicName
            End If

            txt_cdSemiGroupMaterial.Code = ""
            txt_cdDetailGroupMaterial.Code = ""
            txt_cdSemiGroupMaterial.Data = ""
            txt_cdDetailGroupMaterial.Data = ""

            txt_SupplierCode.Code = ""
            txt_SupplierCode.Data = ""

            Call DATA_SEARCH_VS1()
        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Sub



    Private Sub chk_Total_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Total.CheckedChanged
        SplitContainer1.Panel1Collapsed = Not chk_Total.Checked
        SplitContainer2.Panel1Collapsed = Not chk_Total.Checked
        SplitContainer3.Panel1Collapsed = Not chk_Total.Checked

    End Sub


#End Region


    Private Sub cmd_Save_Click(sender As Object, e As EventArgs) Handles cmd_Save.Click
        Exit Sub

        Try
            Dim intRow As Integer
            Dim KEY_Autokey As String


            For intRow = 0 To Vs1.ActiveSheet.RowCount - 1
                If getDataM(Vs1, getColumIndex(Vs1, "DCHK"), intRow) = "1" Then
                    KEY_Autokey = getData(Vs1, getColumIndex(Vs1, "KEY_Autokey"), intRow)

                    If READ_PFK3011(KEY_Autokey) Then
                        D3011.QtyBooking = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyBooking"), intRow))
                        D3011.InchargeUpdate = Pub.SAW
                        D3011.DateUdate = Pub.DAT

                        D3011.RemarkLine = getData(Vs1, getColumIndex(Vs1, "RemarkLine"), intRow)
                        D3011.Remark = getData(Vs1, getColumIndex(Vs1, "Remark"), intRow)

                        Call REWRITE_PFK3011(D3011)
                    End If

                End If
            Next


            Call DATA_SEARCH_VS1()

        Catch ex As Exception

        End Try
    End Sub
End Class