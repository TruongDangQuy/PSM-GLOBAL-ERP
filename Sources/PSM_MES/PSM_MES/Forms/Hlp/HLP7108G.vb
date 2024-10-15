Public Class HLP7108G
#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Private wGCODE As String
    Private W7106 As T7106_AREA


    Private formA As Boolean
#End Region

#Region "Form_load"
    Public Function Link_HLP7108G(Optional ByVal TAG As String = "") As Boolean
        Link_HLP7108G = False
        Me.Tag = TAG

        Try
            formA = False

            Me.ShowDialog()
            Link_HLP7108G = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))
        End Try
    End Function

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True
        Call FORM_INIT()
        Call DATA_INIT()

    End Sub
    Private Sub Me_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)

        If e.Control = True And e.KeyCode = Keys.G Then
            chk_Total.Checked = Not chk_Total.Checked
        End If
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
        chk_Total.Checked = True
        Me.WindowState = FormWindowState.Maximized

        Call DATA_SEARCH_HEAD_vs_Season()
        Call DATA_SEARCH_HEAD_vS_Cus()

    End Sub

#End Region

#Region "Function"


#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS2(ShoesCode As String) As Boolean
        DATA_SEARCH_VS2 = False

        vS2.Enabled = False

        DS1 = PrcDS("USP_HLP7108G_SEARCH_VS2", cn, ShoesCode)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS2, DS1, "USP_HLP7108G_SEARCH_VS2", "VS2")
            vS2.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS2, DS1, "USP_HLP7108G_SEARCH_VS2", "VS2")
        DATA_SEARCH_VS2 = True

        vS2.Enabled = True
    End Function
    Private Function LINE_MOVE_DISPLAY01() As Boolean
        Dim ShoesCode As String
        Dim xrow As Integer
        LINE_MOVE_DISPLAY01 = False
        Try
            xrow = vS2.ActiveSheet.ActiveRowIndex
            ShoesCode = getData(vS2, getColumIndex(vS2, "KEY_ShoesCode"), xrow)
            DS1 = PrcDS("USP_HLP7108G_SEARCH_Vs2_LINE", cn, ShoesCode)

            If GetDsRc(DS1) = 0 Then
                Exit Function
            End If
            READ_SPREAD(vS2, DS1, "USP_HLP7108G_SEARCH_Vs2", "Vs2", xrow)

            LINE_MOVE_DISPLAY01 = True
        Catch ex As Exception

        End Try
    End Function

    Public Function DATA_SEARCH_HEAD_vs_Season() As Boolean
        DATA_SEARCH_HEAD_vs_Season = False

        Try
            DS1 = PrcDS("USP_HLP7108G_SEARCH_VS_SEASON", cn, ListCode("Season"))
            SPR_PRO_NEW(vs_Season, DS1, "USP_HLP7108G_SEARCH_VS_SEASON", "vs_Season")

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
            DS1 = PrcDS("USP_HLP7108G_SEARCH_vS_Cus", cn, CustomerCode, cdSeason)
            SPR_PRO_NEW(vS_Cus, DS1, "USP_HLP7108G_SEARCH_vS_Cus", "vS_Cus")

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
            DS1 = PrcDS("USP_HLP7108G_SEARCH_vS_Line", cn, cdSeason, CustomerCode)
            SPR_PRO_NEW(vS_Line, DS1, "USP_HLP7108G_SEARCH_vS_Line", "vS_Line")

            SplitContainer1.SplitterDistance = SPR_SHEETWIDHT(vS_Cus) + SPR_SHEETWIDHT(vS_Line) + cSprWidthSize + cSprWidthSize

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
        Dim ShoesCode As String
        ShoesCode = getData(vS_Line, getColumIndex(vS_Line, "ShoesCode"), vS_Line.ActiveSheet.ActiveRowIndex)

        Call DATA_SEARCH_VS2(ShoesCode)
    End Sub


    Private Sub Vs2_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS2.CellDoubleClick
        'If e.ColumnHeader = False Then
        '    Call MAIN_JOB02()
        'End If
    End Sub

    Private Sub Vs2_GotFocus(sender As Object, e As EventArgs) Handles vS2.GotFocus
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

    Private Sub Vs2_KeyDown(sender As Object, e As KeyEventArgs) Handles vS2.KeyDown

    End Sub
    Private Sub Vs2_LostFocus(sender As Object, e As EventArgs) Handles vS2.LostFocus


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

    End Sub

    Private Sub chk_Total_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Total.CheckedChanged
        Psc_1.Panel1Collapsed = Not chk_Total.Checked
        Psc_3.Panel1Collapsed = Not chk_Total.Checked
        SplitContainer1.Panel1Collapsed = Not chk_Total.Checked

        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False

        If chk_Total.Checked = True Then

            'SplitContainer1.SplitterDistance = SPR_SHEETWIDHT(vS_Cus) + SPR_SHEETWIDHT(vS_Line) + cSprWidthSize + cSprWidthSize

        Else

            'SplitContainer1.SplitterDistance = SPR_SHEETWIDHT(Vs1) + cSprWidthSize


        End If

    End Sub

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If getData(vS2, getColumIndex(vS2, "KEY_GroupComponentBOM"), vS2.ActiveSheet.ActiveRowIndex) IsNot Nothing Then
            If getData(vS2, getColumIndex(vS2, "KEY_GroupComponentBOM"), vS2.ActiveSheet.ActiveRowIndex) <> "" Then
                hlp0000SeVa = getData(vS2, getColumIndex(vS2, "KEY_GroupComponentBOM"), vS2.ActiveSheet.ActiveRowIndex)
                hlp0000SeVaTt = getData(vS2, getColumIndex(vS2, "KEY_GroupComponentBOM"), vS2.ActiveSheet.ActiveRowIndex)
                hlp0000SeVaTt1 = getData(vS2, getColumIndex(vS2, "KEY_GroupComponentBOM"), vS2.ActiveSheet.ActiveRowIndex)
                isudCHK = True
            End If
        Else
            hlp0000SeVa = ""
            hlp0000SeVaTt = ""
            hlp0000SeVaTt1 = ""
            isudCHK = False
        End If
        Me.Close()
    End Sub

    Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        hlp0000SeVaTt1 = ""
        isudCHK = False
        Me.Close()
    End Sub
#End Region

End Class