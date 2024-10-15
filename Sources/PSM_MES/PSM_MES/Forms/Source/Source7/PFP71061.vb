Imports System.Data.SqlClient
Imports System.IO
Public Class PFP71061
#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Private wGCODE As String
    Private W7106 As T7106_AREA
    Private KEY_SEQ As String
    Private CHK(0 To 5) As String

    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        If CHK(1) <> "1" Then
            isudCHK = False
            Call MsgBoxP("You have no right is this program !")
            Me.Dispose()
        End If

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False, WordConv("INPUT") & "(F5)")
        Me.KeyPreview = True
        Call FORM_INIT()
        Call DATA_INIT()
        vS2.ContextMenuStrip = Cms_1

    End Sub
    Private Sub Me_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)

        If e.Control = True And e.KeyCode = Keys.G Then
            chk_Total.Checked = Not chk_Total.Checked
        End If

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
        chk_FSEL.BackColor = clrCheck           '³ì»ö
        chk_FSEL.ForeColor = Color.Black              '»¡°­»ö

        chk_FSEL.Text = WordConv("CLOSE")
        ssp_WHERE.Visible = True
    End Sub

    Private Sub DATA_INIT()
        Psc_1.Panel1Collapsed = True
        Psc_3.Panel1Collapsed = True
        Psc_2.Panel1Collapsed = True

        SplitContainer1.SplitterDistance = SPR_SHEETWIDHT(Vs1) + cSprWidthSize
    End Sub

#End Region

#Region "Function"
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
            MAIN_JOB_COPY()
        End If
    End Sub
    Private Sub MAIN_JOB01()
       

    End Sub
    Private Sub MAIN_JOB02()

    End Sub
    Private Sub MAIN_JOB03()
       
    End Sub
    Private Sub MAIN_JOB04()
       
    End Sub

    Private Sub MAIN_JOB_COPY()
        
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
    Private Sub KEY_COUNT_IMAGE(ShoesCode As String)
      
    End Sub

    Private Sub KEY_COUNT()
       
    End Sub
#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False

        Vs1.Enabled = False

        DS1 = PrcDS("USP_PFP71061_SEARCH_VS1", cn, ListCode("SpecState"))

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs1, DS1, "USP_PFP71061_SEARCH_VS1", "Vs1")
            SplitContainer1.SplitterDistance = SPR_SHEETWIDHT(Vs1) + cSprWidthSize
            Vs1.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "USP_PFP71061_SEARCH_VS1", "Vs1")
        SplitContainer1.SplitterDistance = SPR_SHEETWIDHT(Vs1) + cSprWidthSize
        DATA_SEARCH_VS1 = True

        Vs1.Enabled = True
    End Function
    Private Function DATA_SEARCH_VS2(cdSpecState As String) As Boolean
        DATA_SEARCH_VS2 = False

        vS2.Enabled = False

        DS1 = PrcDS("USP_PFP71061_SEARCH_VS2", cn, txt_CustomerCode.Code, txt_cdSpecState.Code, txt_cdSeason.Code, txt_Line.Data, "*" & txt_Article.Data, txt_ColorName.Data, txt_LastCode.Code, txt_MoldCode.Code, chk_CheckUse1.CheckState, chk_CheckUse2.CheckState)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS2, DS1, "USP_PFP71061_SEARCH_VS2", "VS2")
            vS2.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS2, DS1, "USP_PFP71061_SEARCH_VS2", "VS2")
        DATA_SEARCH_VS2 = True
        If chk_Total.Checked = True Then
            SPR_HIDE(vS2, False, getColumIndex(vS2, "SeasonName"), getColumIndex(vS2, "CustomerName"), getColumIndex(vS2, "cdSpecStateName"), getColumIndex(vS2, "Line"))
        End If

        vS2.Enabled = True
    End Function

    Private Function DATA_SEARCH_vs_Price(ShoesCode As String) As Boolean
        DATA_SEARCH_vs_Price = False


        vs_Price.Enabled = False

        DS1 = PrcDS("USP_PFP71061_SEARCH_vs_Price", cn, ShoesCode)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vs_Price, DS1, "USP_PFP71061_SEARCH_vs_Price", "vs_Price")
            vs_Price.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vs_Price, DS1, "USP_PFP71061_SEARCH_vs_Price", "vs_Price")
        DATA_SEARCH_vs_Price = True

        vs_Price.Enabled = True
    End Function

    Private Function LINE_MOVE_DISPLAY01() As Boolean
        Dim ShoesCode As String
        Dim xrow As Integer
        LINE_MOVE_DISPLAY01 = False
        Try
            xrow = vS2.ActiveSheet.ActiveRowIndex
            ShoesCode = getData(vS2, getColumIndex(vS2, "KEY_ShoesCode"), xrow)
            DS1 = PrcDS("USP_PFP71061_SEARCH_Vs2_LINE", cn, ShoesCode)

            If GetDsRc(DS1) = 0 Then
                Exit Function
            End If
            READ_SPREAD(vS2, DS1, "USP_PFP71061_SEARCH_Vs2", "Vs2", xrow)

            LINE_MOVE_DISPLAY01 = True
        Catch ex As Exception

        End Try
    End Function

    Public Function DATA_SEARCH_HEAD_vs_Season() As Boolean
        DATA_SEARCH_HEAD_vs_Season = False

        Try
            DS1 = PrcDS("USP_PFP71061_SEARCH_VS_SEASON", cn, ListCode("Season"))
            SPR_PRO_NEW(vs_Season, DS1, "USP_PFP71061_SEARCH_VS_SEASON", "vs_Season")

            DS1 = Nothing
            DATA_SEARCH_HEAD_vs_Season = True

            Psc_3.SplitterDistance = SPR_SHEETWIDHT(vS_Cus) + cSprWidthSize

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Public Function DATA_SEARCH_HEAD_vS_Cus() As Boolean
        DATA_SEARCH_HEAD_vS_Cus = False

        Dim cdSeason As String
        cdSeason = getData(vs_Season, getColumIndex(vs_Season, "BasicCode"), vs_Season.ActiveSheet.ActiveRowIndex)

        Dim CustomerCode As String
        CustomerCode = getData(vS_Cus, getColumIndex(vS_Cus, "CustomerCode"), vS_Cus.ActiveSheet.ActiveRowIndex)


        Try
            DS1 = PrcDS("USP_PFP71061_SEARCH_vS_Cus", cn, CustomerCode, cdSeason)
            SPR_PRO_NEW(vS_Cus, DS1, "USP_PFP71061_SEARCH_vS_Cus", "vS_Cus")

            Psc_3.SplitterDistance = SPR_SHEETWIDHT(vS_Cus) + cSprWidthSize
            DS1 = Nothing
            DATA_SEARCH_HEAD_vS_Cus = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Public Function DATA_SEARCH_HEAD_vS_Line() As Boolean
        DATA_SEARCH_HEAD_vS_Line = False
        Dim cdSeason As String
        Dim CustomerCode As String

        cdSeason = txt_cdSeason.Code
        CustomerCode = txt_CustomerCode.Code


        Try
            DS1 = PrcDS("USP_PFP71061_SEARCH_vS_Line", cn, cdSeason, CustomerCode)
            SPR_PRO_NEW(vS_Line, DS1, "USP_PFP71061_SEARCH_vS_Line", "vS_Line")

            Psc_2.SplitterDistance = SPR_SHEETWIDHT(vS_Line) + cSprWidthSize

            DS1 = Nothing
            DATA_SEARCH_HEAD_vS_Line = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

#End Region

#Region "Event"
    Private Sub vs_Season_CellClick(sender As Object, e As CellClickEventArgs) Handles vs_Season.CellClick

        vS_Cus.ActiveSheet.RowCount = 0
        vS_Line.ActiveSheet.RowCount = 0
        Vs1.ActiveSheet.RowCount = 0

        txt_cdSeason.Code = ""
        txt_cdSeason.Data = ""

        txt_CustomerCode.Code = ""
        txt_CustomerCode.Data = ""

        txt_Line.Code = ""
        txt_Line.Data = ""

        txt_cdSpecState.Code = ""
        txt_cdSpecState.Data = ""

        Dim cdSeason As String
        cdSeason = getData(vs_Season, getColumIndex(vs_Season, "BasicCode"), vs_Season.ActiveSheet.ActiveRowIndex)

        If READ_PFK7171(ListCode("Season"), cdSeason) Then
            txt_cdSeason.Code = D7171.BasicCode
            txt_cdSeason.Data = D7171.BasicName
        End If

        Call DATA_SEARCH_HEAD_vS_Cus()

    End Sub
    Private Sub vS_Cus_CellClick(sender As Object, e As CellClickEventArgs) Handles vS_Cus.CellClick

        vS_Line.ActiveSheet.RowCount = 0
        Vs1.ActiveSheet.RowCount = 0

        txt_CustomerCode.Code = ""
        txt_CustomerCode.Data = ""

        txt_Line.Code = ""
        txt_Line.Data = ""

        txt_cdSpecState.Code = ""
        txt_cdSpecState.Data = ""

        Dim CustomerCode As String
        CustomerCode = getData(vS_Cus, getColumIndex(vS_Cus, "CustomerCode"), vS_Cus.ActiveSheet.ActiveRowIndex)

        If READ_PFK7101(CustomerCode) Then
            txt_CustomerCode.Code = D7101.CustomerCode
            txt_CustomerCode.Data = D7101.CustomerName
        End If

        Call DATA_SEARCH_HEAD_vS_Line()

    End Sub
    Private Sub vS_Line_CellClick(sender As Object, e As CellClickEventArgs) Handles vS_Line.CellClick
        Dim cdSpecState As String

        txt_cdSpecState.Code = ""
        txt_cdSpecState.Data = ""

        cdSpecState = getData(vS_Line, getColumIndex(vS_Line, "cdSpecState"), vS_Line.ActiveSheet.ActiveRowIndex)

        If READ_PFK7171(ListCode("SpecState"), cdSpecState) Then
            txt_cdSpecState.Code = D7171.BasicCode
            txt_cdSpecState.Data = D7171.BasicName
        End If

        txt_Line.Code = ""
        txt_Line.Data = ""

        txt_Line.Data = "#" & getData(vS_Line, getColumIndex(vS_Line, "Line"), vS_Line.ActiveSheet.ActiveRowIndex)

        Call DATA_SEARCH_VS2(cdSpecState)
    End Sub

    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        Dim cdSpecState As String

        cdSpecState = getData(Vs1, getColumIndex(Vs1, "KEY_BasicCode"), Vs1.ActiveSheet.ActiveRowIndex)

        If READ_PFK7171(ListCode("SpecState"), cdSpecState) Then
            txt_cdSpecState.Code = D7171.BasicCode
            txt_cdSpecState.Data = D7171.BasicName
        End If

        Call DATA_SEARCH_VS2(cdSpecState)

    End Sub

    Private Sub Vs2_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS2.CellDoubleClick
        If e.ColumnHeader = False And e.Column = getColumIndex(vS2, "ShoesCode") Then
            Dim ShoesCode As String
            ShoesCode = getData(vS2, getColumIndex(vS2, "KEY_SHOESCODE"), vS2.ActiveSheet.ActiveRowIndex)

            Call DATA_SEARCH_vs_Price(ShoesCode)
        End If
    End Sub

    Private Sub Vs2_GotFocus(sender As Object, e As EventArgs) Handles vS2.GotFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, True, False, WordConv("INPUT") & "(F5)", WordConv("SEARCH") & "(F6)", WordConv("UPDATE") & "(F7)", WordConv("DELETE") & "(F8)", WordConv("COPY") & "(F9)")

        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False
    End Sub
    Private Sub txt_GNAME_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Article.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter : cmd_SEARCH.Focus()
        End Select
    End Sub

    Private Sub vs_Price_Change(sender As Object, e As ChangeEventArgs) Handles vs_Price.Change
        If READ_PFK7265(getData(vs_Price, getColumIndex(vs_Price, "KEY_ShoesCode"), vs_Price.ActiveSheet.ActiveRowIndex)) Then
            D7265.PriceS01 = getData(vs_Price, getColumIndex(vs_Price, "PriceS01"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS02 = getData(vs_Price, getColumIndex(vs_Price, "PriceS02"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS03 = getData(vs_Price, getColumIndex(vs_Price, "PriceS03"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS04 = getData(vs_Price, getColumIndex(vs_Price, "PriceS04"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS05 = getData(vs_Price, getColumIndex(vs_Price, "PriceS05"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS06 = getData(vs_Price, getColumIndex(vs_Price, "PriceS06"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS07 = getData(vs_Price, getColumIndex(vs_Price, "PriceS07"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS08 = getData(vs_Price, getColumIndex(vs_Price, "PriceS08"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS09 = getData(vs_Price, getColumIndex(vs_Price, "PriceS09"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS10 = getData(vs_Price, getColumIndex(vs_Price, "PriceS10"), vs_Price.ActiveSheet.ActiveRowIndex)

            D7265.PriceS11 = getData(vs_Price, getColumIndex(vs_Price, "PriceS11"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS12 = getData(vs_Price, getColumIndex(vs_Price, "PriceS12"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS13 = getData(vs_Price, getColumIndex(vs_Price, "PriceS13"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS14 = getData(vs_Price, getColumIndex(vs_Price, "PriceS14"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS15 = getData(vs_Price, getColumIndex(vs_Price, "PriceS15"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS16 = getData(vs_Price, getColumIndex(vs_Price, "PriceS16"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS17 = getData(vs_Price, getColumIndex(vs_Price, "PriceS17"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS18 = getData(vs_Price, getColumIndex(vs_Price, "PriceS18"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS19 = getData(vs_Price, getColumIndex(vs_Price, "PriceS19"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS20 = getData(vs_Price, getColumIndex(vs_Price, "PriceS20"), vs_Price.ActiveSheet.ActiveRowIndex)

            D7265.PriceS21 = getData(vs_Price, getColumIndex(vs_Price, "PriceS21"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS22 = getData(vs_Price, getColumIndex(vs_Price, "PriceS22"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS23 = getData(vs_Price, getColumIndex(vs_Price, "PriceS23"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS24 = getData(vs_Price, getColumIndex(vs_Price, "PriceS24"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS25 = getData(vs_Price, getColumIndex(vs_Price, "PriceS25"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS26 = getData(vs_Price, getColumIndex(vs_Price, "PriceS26"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS27 = getData(vs_Price, getColumIndex(vs_Price, "PriceS27"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS28 = getData(vs_Price, getColumIndex(vs_Price, "PriceS28"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS29 = getData(vs_Price, getColumIndex(vs_Price, "PriceS29"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS30 = getData(vs_Price, getColumIndex(vs_Price, "PriceS30"), vs_Price.ActiveSheet.ActiveRowIndex)

            Call REWRITE_PFK7265(D7265)

        Else
            D7265.ShoesCode = getData(vs_Price, getColumIndex(vs_Price, "KEY_ShoesCode"), vs_Price.ActiveSheet.ActiveRowIndex)

            D7265.PriceS01 = getData(vs_Price, getColumIndex(vs_Price, "PriceS01"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS02 = getData(vs_Price, getColumIndex(vs_Price, "PriceS02"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS03 = getData(vs_Price, getColumIndex(vs_Price, "PriceS03"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS04 = getData(vs_Price, getColumIndex(vs_Price, "PriceS04"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS05 = getData(vs_Price, getColumIndex(vs_Price, "PriceS05"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS06 = getData(vs_Price, getColumIndex(vs_Price, "PriceS06"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS07 = getData(vs_Price, getColumIndex(vs_Price, "PriceS07"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS08 = getData(vs_Price, getColumIndex(vs_Price, "PriceS08"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS09 = getData(vs_Price, getColumIndex(vs_Price, "PriceS09"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS10 = getData(vs_Price, getColumIndex(vs_Price, "PriceS10"), vs_Price.ActiveSheet.ActiveRowIndex)

            D7265.PriceS11 = getData(vs_Price, getColumIndex(vs_Price, "PriceS11"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS12 = getData(vs_Price, getColumIndex(vs_Price, "PriceS12"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS13 = getData(vs_Price, getColumIndex(vs_Price, "PriceS13"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS14 = getData(vs_Price, getColumIndex(vs_Price, "PriceS14"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS15 = getData(vs_Price, getColumIndex(vs_Price, "PriceS15"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS16 = getData(vs_Price, getColumIndex(vs_Price, "PriceS16"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS17 = getData(vs_Price, getColumIndex(vs_Price, "PriceS17"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS18 = getData(vs_Price, getColumIndex(vs_Price, "PriceS18"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS19 = getData(vs_Price, getColumIndex(vs_Price, "PriceS19"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS20 = getData(vs_Price, getColumIndex(vs_Price, "PriceS20"), vs_Price.ActiveSheet.ActiveRowIndex)

            D7265.PriceS21 = getData(vs_Price, getColumIndex(vs_Price, "PriceS21"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS22 = getData(vs_Price, getColumIndex(vs_Price, "PriceS22"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS23 = getData(vs_Price, getColumIndex(vs_Price, "PriceS23"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS24 = getData(vs_Price, getColumIndex(vs_Price, "PriceS24"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS25 = getData(vs_Price, getColumIndex(vs_Price, "PriceS25"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS26 = getData(vs_Price, getColumIndex(vs_Price, "PriceS26"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS27 = getData(vs_Price, getColumIndex(vs_Price, "PriceS27"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS28 = getData(vs_Price, getColumIndex(vs_Price, "PriceS28"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS29 = getData(vs_Price, getColumIndex(vs_Price, "PriceS29"), vs_Price.ActiveSheet.ActiveRowIndex)
            D7265.PriceS30 = getData(vs_Price, getColumIndex(vs_Price, "PriceS30"), vs_Price.ActiveSheet.ActiveRowIndex)

            Call WRITE_PFK7265(D7265)
        End If
    End Sub

    Private Sub vs_Price_KeyDown(sender As Object, e As KeyEventArgs) Handles vs_Price.KeyDown
        If e.KeyCode = Keys.Enter Then
            If READ_PFK7265(getData(vs_Price, getColumIndex(vs_Price, "KEY_ShoesCode"), vs_Price.ActiveSheet.ActiveRowIndex)) Then
                D7265.PriceS01 = getData(vs_Price, getColumIndex(vs_Price, "PriceS01"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS02 = getData(vs_Price, getColumIndex(vs_Price, "PriceS02"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS03 = getData(vs_Price, getColumIndex(vs_Price, "PriceS03"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS04 = getData(vs_Price, getColumIndex(vs_Price, "PriceS04"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS05 = getData(vs_Price, getColumIndex(vs_Price, "PriceS05"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS06 = getData(vs_Price, getColumIndex(vs_Price, "PriceS06"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS07 = getData(vs_Price, getColumIndex(vs_Price, "PriceS07"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS08 = getData(vs_Price, getColumIndex(vs_Price, "PriceS08"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS09 = getData(vs_Price, getColumIndex(vs_Price, "PriceS09"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS10 = getData(vs_Price, getColumIndex(vs_Price, "PriceS10"), vs_Price.ActiveSheet.ActiveRowIndex)

                D7265.PriceS11 = getData(vs_Price, getColumIndex(vs_Price, "PriceS11"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS12 = getData(vs_Price, getColumIndex(vs_Price, "PriceS12"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS13 = getData(vs_Price, getColumIndex(vs_Price, "PriceS13"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS14 = getData(vs_Price, getColumIndex(vs_Price, "PriceS14"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS15 = getData(vs_Price, getColumIndex(vs_Price, "PriceS15"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS16 = getData(vs_Price, getColumIndex(vs_Price, "PriceS16"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS17 = getData(vs_Price, getColumIndex(vs_Price, "PriceS17"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS18 = getData(vs_Price, getColumIndex(vs_Price, "PriceS18"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS19 = getData(vs_Price, getColumIndex(vs_Price, "PriceS19"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS20 = getData(vs_Price, getColumIndex(vs_Price, "PriceS20"), vs_Price.ActiveSheet.ActiveRowIndex)

                D7265.PriceS21 = getData(vs_Price, getColumIndex(vs_Price, "PriceS21"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS22 = getData(vs_Price, getColumIndex(vs_Price, "PriceS22"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS23 = getData(vs_Price, getColumIndex(vs_Price, "PriceS23"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS24 = getData(vs_Price, getColumIndex(vs_Price, "PriceS24"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS25 = getData(vs_Price, getColumIndex(vs_Price, "PriceS25"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS26 = getData(vs_Price, getColumIndex(vs_Price, "PriceS26"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS27 = getData(vs_Price, getColumIndex(vs_Price, "PriceS27"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS28 = getData(vs_Price, getColumIndex(vs_Price, "PriceS28"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS29 = getData(vs_Price, getColumIndex(vs_Price, "PriceS29"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS30 = getData(vs_Price, getColumIndex(vs_Price, "PriceS30"), vs_Price.ActiveSheet.ActiveRowIndex)

                Call REWRITE_PFK7265(D7265)

            Else
                D7265.ShoesCode = getData(vs_Price, getColumIndex(vs_Price, "KEY_ShoesCode"), vs_Price.ActiveSheet.ActiveRowIndex)

                D7265.PriceS01 = getData(vs_Price, getColumIndex(vs_Price, "PriceS01"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS02 = getData(vs_Price, getColumIndex(vs_Price, "PriceS02"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS03 = getData(vs_Price, getColumIndex(vs_Price, "PriceS03"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS04 = getData(vs_Price, getColumIndex(vs_Price, "PriceS04"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS05 = getData(vs_Price, getColumIndex(vs_Price, "PriceS05"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS06 = getData(vs_Price, getColumIndex(vs_Price, "PriceS06"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS07 = getData(vs_Price, getColumIndex(vs_Price, "PriceS07"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS08 = getData(vs_Price, getColumIndex(vs_Price, "PriceS08"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS09 = getData(vs_Price, getColumIndex(vs_Price, "PriceS09"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS10 = getData(vs_Price, getColumIndex(vs_Price, "PriceS10"), vs_Price.ActiveSheet.ActiveRowIndex)

                D7265.PriceS11 = getData(vs_Price, getColumIndex(vs_Price, "PriceS11"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS12 = getData(vs_Price, getColumIndex(vs_Price, "PriceS12"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS13 = getData(vs_Price, getColumIndex(vs_Price, "PriceS13"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS14 = getData(vs_Price, getColumIndex(vs_Price, "PriceS14"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS15 = getData(vs_Price, getColumIndex(vs_Price, "PriceS15"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS16 = getData(vs_Price, getColumIndex(vs_Price, "PriceS16"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS17 = getData(vs_Price, getColumIndex(vs_Price, "PriceS17"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS18 = getData(vs_Price, getColumIndex(vs_Price, "PriceS18"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS19 = getData(vs_Price, getColumIndex(vs_Price, "PriceS19"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS20 = getData(vs_Price, getColumIndex(vs_Price, "PriceS20"), vs_Price.ActiveSheet.ActiveRowIndex)

                D7265.PriceS21 = getData(vs_Price, getColumIndex(vs_Price, "PriceS21"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS22 = getData(vs_Price, getColumIndex(vs_Price, "PriceS22"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS23 = getData(vs_Price, getColumIndex(vs_Price, "PriceS23"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS24 = getData(vs_Price, getColumIndex(vs_Price, "PriceS24"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS25 = getData(vs_Price, getColumIndex(vs_Price, "PriceS25"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS26 = getData(vs_Price, getColumIndex(vs_Price, "PriceS26"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS27 = getData(vs_Price, getColumIndex(vs_Price, "PriceS27"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS28 = getData(vs_Price, getColumIndex(vs_Price, "PriceS28"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS29 = getData(vs_Price, getColumIndex(vs_Price, "PriceS29"), vs_Price.ActiveSheet.ActiveRowIndex)
                D7265.PriceS30 = getData(vs_Price, getColumIndex(vs_Price, "PriceS30"), vs_Price.ActiveSheet.ActiveRowIndex)

                Call WRITE_PFK7265(D7265)
            End If
        End If
    End Sub
    Private Sub Vs2_KeyDown(sender As Object, e As KeyEventArgs) Handles vS2.KeyDown
        If e.KeyCode = Keys.Enter Then
            If READ_PFK7106(getData(vS2, getColumIndex(vS2, "KEY_ShoesCode"), vS2.ActiveSheet.ActiveRowIndex)) Then
                D7106.PriceUSD = getData(vS2, getColumIndex(vS2, "PriceUSD"), vS2.ActiveSheet.ActiveRowIndex)
                Call REWRITE_PFK7106(D7106)
            End If
        End If
    End Sub
    Private Sub vS2_Change(sender As Object, e As ChangeEventArgs) Handles vS2.Change
        If e.Column = getColumIndex(vS2, "PriceUSD") Then
            If READ_PFK7106(getData(vS2, getColumIndex(vS2, "KEY_ShoesCode"), vS2.ActiveSheet.ActiveRowIndex)) Then
                D7106.PriceUSD = getData(vS2, getColumIndex(vS2, "PriceUSD"), vS2.ActiveSheet.ActiveRowIndex)
                Call REWRITE_PFK7106(D7106)
            End If
        End If
    End Sub
    Private Sub Vs2_LostFocus(sender As Object, e As EventArgs) Handles vS2.LostFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False, WordConv("INPUT") & "(F5)")

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

        If chk_Total.Checked = True Then
            Call DATA_SEARCH_HEAD_vs_Season()
            Exit Sub
        End If

        Call DATA_SEARCH_VS1()
        Call DATA_SEARCH_VS2(txt_cdSpecState.Code)
        Call DATA_SEARCH_vs_Price("")

    End Sub


#End Region

    Private Sub chk_Total_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Total.CheckedChanged
        Psc_1.Panel1Collapsed = Not chk_Total.Checked
        Psc_3.Panel1Collapsed = Not chk_Total.Checked
        Psc_2.Panel1Collapsed = Not chk_Total.Checked

        Psc_2.Panel2Collapsed = chk_Total.Checked

        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False

        If chk_Total.Checked = True Then
            'Call DATA_SEARCH_HEAD_vs_Season()
            'Call DATA_SEARCH_HEAD_vS_Cus()
            'Call DATA_SEARCH_HEAD_vS_Line()
            'vS_Cus.ActiveSheet.RowCount = 0
            'vS_Line.ActiveSheet.RowCount = 0
            'vS2.ActiveSheet.RowCount = 0
            SplitContainer1.SplitterDistance = SPR_SHEETWIDHT(vS_Cus) + SPR_SHEETWIDHT(vS_Line) + cSprWidthSize + cSprWidthSize

        Else
            'Call DATA_SEARCH_VS1()
            'vS2.ActiveSheet.RowCount = 0
            SplitContainer1.SplitterDistance = SPR_SHEETWIDHT(Vs1) + cSprWidthSize
            'txt_cdSeason.Code = ""
            'txt_cdSeason.Data = ""

            'txt_CustomerCode.Code = ""
            'txt_CustomerCode.Data = ""

            'txt_Line.Code = ""
            'txt_Line.Data = ""

            'txt_cdSpecState.Code = ""
            'txt_cdSpecState.Data = ""

        End If
    End Sub





End Class