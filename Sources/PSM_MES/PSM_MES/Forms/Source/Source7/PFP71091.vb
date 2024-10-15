Imports System.Data.SqlClient
Imports System.IO
Public Class PFP71091
#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Private wGCODE As String
    Private W7106 As T7106_AREA
    Private KEY_SEQ As String

    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim xISUD3208O As String
        xISUD3208O = ISUD3208O.Text

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False, WordConv("INPUT") & "(F5)")
        Me.KeyPreview = True

        Call FORM_INIT()
        Call DATA_INIT()

        Call Cms_additem(Cms_1, xISUD3208O & " - " & WordConv("SEARCH") & "(F5)", _
                                xISUD3208O & " - " & WordConv("UPDATE") & "(F6)")



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
        chk_FSEL.BackColor = clrCheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("CLOSE")
        ssp_WHERE.Visible = True
    End Sub

    Private Sub DATA_INIT()
        Psc_1.Panel1Collapsed = True
        Psc_3.Panel1Collapsed = False
        Psc_2.Panel1Collapsed = True

        txt_InchargeInsert.Data = Pub.NAM
        txt_InchargeInsert.Code = Pub.SAW

        chk_Total.Checked = True
        Psc_1.SplitterDistance = 311
        Psc_2.SplitterDistance = 353
        Psc_3.SplitterDistance = 280
        SplitContainer1.SplitterDistance = 450
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
            MAIN_JOB05()
        End If

    End Sub
    Private Sub MAIN_JOB01()
        Dim ShoesCode As String
        ShoesCode = getData(vS_Line, getColumIndex(vS_Line, "KEY_ShoesCode"), vS_Line.ActiveSheet.ActiveRowIndex)

        If READ_PFK3208_SHOESCODE(ShoesCode) Then
            If ISUD3208O.Link_ISUD3208O(2, D3208.GroupComponentBOM, Me.Name) = False Then Exit Sub
        End If
    End Sub

    Private Sub MAIN_JOB02()
        Dim ShoesCode As String
        ShoesCode = getData(vS_Line, getColumIndex(vS_Line, "KEY_ShoesCode"), vS_Line.ActiveSheet.ActiveRowIndex)

        If READ_PFK3208_SHOESCODE(ShoesCode) Then
            If ISUD3208O.Link_ISUD3208O(3, D3208.GroupComponentBOM, Me.Name) = False Then Exit Sub
        Else
            If ISUD3208O.Link_ISUD3208O(1, ShoesCode, Me.Name) = False Then Exit Sub
        End If

    End Sub

    Private Sub MAIN_JOB03()
       
    End Sub
    Private Sub MAIN_JOB04()
       
    End Sub
    Private Sub MAIN_JOB05()
    End Sub


    Private Sub KEY_COUNT_IMAGE(ShoesCode As String)
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader


        SQL = "SELECT MAX(K7107_SEQ) AS MAX_CODE FROM [PFK7107] "
        SQL = SQL & " WHERE K7107_ShoesCode     = '" + ShoesCode + "'"


        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            KEY_SEQ = 1
        Else
            KEY_SEQ = CIntp(rd!MAX_CODE + 1)
        End If

        rd.Close()
    End Sub

    Private Sub KEY_COUNT()
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        SQL = "SELECT MAX(CAST(K7106_ShoesCode AS DECIMAL)) AS MAX_CODE FROM PFK7106 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            W7106.ShoesCode = "000001"
        Else
            W7106.ShoesCode = Format(CInt(rd!MAX_CODE + 1), "000000")
        End If

        rd.Close()
    End Sub
#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False

        Vs1.Enabled = False

        DS1 = PrcDS("USP_PFP71091_SEARCH_VS1", cn, txt_cdSeason.Code, txt_CustomerCode.Code, txt_cdSpecState.Code)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs1, DS1, "USP_PFP71091_SEARCH_VS1", "Vs1")
            SplitContainer1.SplitterDistance = SPR_SHEETWIDHT(Vs1) + cSprWidthSize
            Vs1.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "USP_PFP71091_SEARCH_VS1", "Vs1")
        SplitContainer1.SplitterDistance = SPR_SHEETWIDHT(Vs1) + cSprWidthSize
        DATA_SEARCH_VS1 = True

        Vs1.Enabled = True
    End Function
    Private Function DATA_SEARCH_VS2(cdSpecState As String) As Boolean
        DATA_SEARCH_VS2 = False

        vS2.Enabled = False

        DS1 = PrcDS("USP_PFP71091_SEARCH_VS2_F2", cn, getData(vS_Line, getColumIndex(vS_Line, "KEY_ShoesCode"), vS_Line.ActiveSheet.ActiveRowIndex))

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS2, DS1, "USP_PFP71091_SEARCH_VS2_F2", "VS2")

            SplitContainer1.SplitterDistance = SPR_SHEETWIDHT(Vs1) + SPR_SHEETWIDHT(vS_Line) + cSprWidthSize * 2
            vS2.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS2, DS1, "USP_PFP71091_SEARCH_VS2_F2", "VS2")
        DATA_SEARCH_VS2 = True



        If chk_Total.Checked Then SplitContainer1.SplitterDistance = SPR_SHEETWIDHT(Vs1) + SPR_SHEETWIDHT(vS_Line) + cSprWidthSize * 2

        If chk_Total.Checked = True Then
            'SPR_HIDE(vS2, False, getColumIndex(vS2, "SeasonName"), getColumIndex(vS2, "CustomerName"), getColumIndex(vS2, "cdSpecStateName"), getColumIndex(vS2, "Article"))
        End If

        vS2.Enabled = True
    End Function

    Private Function DATA_SEARCH_vs_Image(ShoesCode As String) As Boolean
        DATA_SEARCH_vs_Image = False
        If chk_Image.Checked = False Then Exit Function

        vs_Image.Enabled = False

        DS1 = PrcDS("USP_PFP71091_SEARCH_vs_Image", cn, ShoesCode)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vs_Image, DS1, "USP_PFP71091_SEARCH_vs_Image", "vs_Image")
            vs_Image.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vs_Image, DS1, "USP_PFP71091_SEARCH_vs_Image", "vs_Image")
        DATA_SEARCH_vs_Image = True

        vs_Image.Enabled = True
    End Function

    Private Function DATA_SEARCH_vs_Doc(ShoesCode As String) As Boolean
        DATA_SEARCH_vs_Doc = False

        If chk_Image.Checked = False Then Exit Function
        vS_Doc.Enabled = False

        DS1 = PrcDS("USP_PFP71091_SEARCH_vs_Doc", cn, ShoesCode)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS_Doc, DS1, "USP_PFP71091_SEARCH_vs_Doc", "vs_Doc")
            vS_Doc.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS_Doc, DS1, "USP_PFP71091_SEARCH_vs_Doc", "vs_Doc")
        DATA_SEARCH_vs_Doc = True

        vS_Doc.Enabled = True
    End Function
    Private Function LINE_MOVE_DISPLAY01() As Boolean
        Dim ShoesCode As String
        Dim xrow As Integer
        LINE_MOVE_DISPLAY01 = False
        Try
            xrow = vS2.ActiveSheet.ActiveRowIndex
            ShoesCode = getData(vS2, getColumIndex(vS2, "KEY_ShoesCode"), xrow)
            DS1 = PrcDS("USP_PFP71091_SEARCH_Vs2_LINE", cn, ShoesCode)

            If GetDsRc(DS1) = 0 Then
                Exit Function
            End If
            READ_SPREAD(vS2, DS1, "USP_PFP71091_SEARCH_Vs2", "Vs2", xrow)

            LINE_MOVE_DISPLAY01 = True
        Catch ex As Exception

        End Try
    End Function

    Public Function DATA_SEARCH_HEAD_vs_Season() As Boolean
        DATA_SEARCH_HEAD_vs_Season = False

        Try
            DS1 = PrcDS("USP_PFP71091_SEARCH_VS_SEASON", cn, ListCode("Season"))
            SPR_PRO_NEW(vs_Season, DS1, "USP_PFP71091_SEARCH_VS_SEASON", "vs_Season")

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
            DS1 = PrcDS("USP_PFP71091_SEARCH_vS_Cus", cn, CustomerCode, cdSeason)
            SPR_PRO_NEW(vS_Cus, DS1, "USP_PFP71091_SEARCH_vS_Cus", "vS_Cus")

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
            DS1 = PrcDS("USP_PFP71091_SEARCH_vS_Line", cn, cdSeason, CustomerCode, txt_cdSpecState.Code)
            SPR_PRO_NEW(vS_Line, DS1, "USP_PFP71091_SEARCH_vS_Line", "vS_Line")

            Psc_2.SplitterDistance = SPR_SHEETWIDHT(vS_Line) + cSprWidthSize

            DS1 = Nothing
            DATA_SEARCH_HEAD_vS_Line = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

#End Region

#Region "Event"
    Private Sub vs_Season_CellClick(sender As Object, e As CellClickEventArgs) Handles vs_Season.CellDoubleClick

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
    Private Sub vS_Cus_CellClick(sender As Object, e As CellClickEventArgs) Handles vS_Cus.CellDoubleClick

        vS_Line.ActiveSheet.RowCount = 0
        Vs1.ActiveSheet.RowCount = 0

        txt_CustomerCode.Code = ""
        txt_CustomerCode.Data = ""

        txt_Line.Code = ""
        txt_Line.Data = ""

        'txt_cdSpecState.Code = ""
        'txt_cdSpecState.Data = ""

        Dim CustomerCode As String
        CustomerCode = getData(vS_Cus, getColumIndex(vS_Cus, "CustomerCode"), vS_Cus.ActiveSheet.ActiveRowIndex)

        If READ_PFK7101(CustomerCode) Then
            txt_CustomerCode.Code = D7101.CustomerCode
            txt_CustomerCode.Data = D7101.CustomerName
        End If

        Call DATA_SEARCH_HEAD_vS_Line()

    End Sub
    Private Sub vS_Line_CellClick(sender As Object, e As CellClickEventArgs) Handles vS_Line.CellDoubleClick
        Dim cdSpecState As String

        txt_cdSpecState.Code = ""
        txt_cdSpecState.Data = ""

        If vS_Line.ActiveSheet.ActiveRowIndex = 0 Then
            txt_Line.Code = ""
            txt_Line.Data = ""

            cdSpecState = "006"
            If READ_PFK7171(ListCode("SpecState"), cdSpecState) Then
                txt_cdSpecState.Code = D7171.BasicCode
                txt_cdSpecState.Data = D7171.BasicName
            End If

        Else
            cdSpecState = getData(vS_Line, getColumIndex(vS_Line, "cdSpecState"), vS_Line.ActiveSheet.ActiveRowIndex)

            If READ_PFK7171(ListCode("SpecState"), cdSpecState) Then
                txt_cdSpecState.Code = D7171.BasicCode
                txt_cdSpecState.Data = D7171.BasicName

                txt_Line.Code = ""
                txt_Line.Data = ""

                txt_Line.Data = "#" & getData(vS_Line, getColumIndex(vS_Line, "Line"), vS_Line.ActiveSheet.ActiveRowIndex)
            End If
        End If

        Call DATA_SEARCH_VS2(cdSpecState)
    End Sub

    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        Dim cdSpecState As String

        cdSpecState = getData(Vs1, getColumIndex(Vs1, "cdSpecState"), Vs1.ActiveSheet.ActiveRowIndex)

        If READ_PFK7171(ListCode("SpecState"), cdSpecState) Then
            txt_cdSpecState.Code = D7171.BasicCode
            txt_cdSpecState.Data = D7171.BasicName
        End If

        Call DATA_SEARCH_VS2(cdSpecState)

    End Sub

    Private Sub Vs2_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS2.CellDoubleClick
        If e.ColumnHeader = False And e.Column = getColumIndex(vS2, "ShoesCode") And chk_Image.Checked Then
            Dim ShoesCode As String
            ShoesCode = getData(vS2, getColumIndex(vS2, "KEY_SHOESCODE"), vS2.ActiveSheet.ActiveRowIndex)

            Call DATA_SEARCH_vs_Image(ShoesCode)
            Call DATA_SEARCH_vs_Doc(ShoesCode)
        End If
    End Sub

    Private Sub Vs2_GotFocus(sender As Object, e As EventArgs) Handles vS2.GotFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, True, False, WordConv("UPDATE") & "(F5)", WordConv("COMPLETE") & "(F6)", WordConv("UN-COMPLETE") & "(F7)", WordConv("PRINT") & "(F8)")

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
        Dim i As Integer
        Dim Xrow As Integer
        Dim ShoesCode As String
        Dim cHECKp As Boolean = False

        Xrow = vS2.ActiveSheet.ActiveRowIndex
        ShoesCode = getData(vS2, getColumIndex(vS2, "ShoesCode"), Xrow)

        Try
            If e.KeyCode = Keys.Enter And Pub.SAW <> "PSMADMIN" Then
                Dim StrMsg As String
                StrMsg = MsgBox("Do you want to update ITEM CODE Parent", vbYesNo)

                If StrMsg <> vbYes Then Exit Sub

                For i = 0 To vS2.ActiveSheet.RowCount - 1
                    If getDataM(vS2, getColumIndex(vS2, "DCHK"), i) = "1" Then
                        If READ_PFK7106(getData(vS2, getColumIndex(vS2, "ShoesCode"), i)) Then
                            W7106 = D7106
                            W7106.ShoesParent = ShoesCode

                            If D7106.ShoesParent = "" Then Call REWRITE_PFK7106(W7106) : cHECKp = True

                        End If
                    End If
                Next

                If READ_PFK7106(ShoesCode) = True And cHECKp = True Then
                    If D7106.CheckParent = "1" Then Exit Sub
                    D7106.CheckParent = "1"
                    Call REWRITE_PFK7106(D7106)
                End If

            ElseIf e.KeyCode = Keys.Enter And Pub.SAW = "PSMADMIN" Then
                Dim StrMsg As String

                StrMsg = MsgBox("Do you want to update ITEM CODE Parent", vbYesNo)

                If StrMsg <> vbYes Then Exit Sub

                For i = 0 To vS2.ActiveSheet.RowCount - 1
                    If getDataM(vS2, getColumIndex(vS2, "DCHK"), i) = "1" Then
                        If READ_PFK7106(getData(vS2, getColumIndex(vS2, "ShoesCode"), i)) Then
                            D7106.ShoesParent = ShoesCode

                            If REWRITE_PFK7106(D7106) Then
                                cHECKp = True
                            End If

                        End If
                    End If
                Next

                If READ_PFK7106(ShoesCode) = True And cHECKp = True Then
                    D7106.CheckParent = "1"
                    Call REWRITE_PFK7106(D7106)
                End If

            End If

            For i = 0 To vS2.ActiveSheet.RowCount - 1
                If getDataM(vS2, getColumIndex(vS2, "DCHK"), i) = "1" Then
                    ShoesCode = getData(vS2, getColumIndex(vS2, "KEY_ShoesCode"), i)

                    DS1 = PrcDS("USP_PFP71091_SEARCH_VS2_LINE", cn, ShoesCode)

                    If GetDsRc(DS1) > 0 Then
                        READ_SPREAD(vS2, DS1, "USP_PFP71091_SEARCH_VS2", "vS2", i)
                    End If


                End If
            Next

        Catch ex As Exception

        End Try

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
            Call DATA_SEARCH_HEAD_vS_Cus()
            Exit Sub
        End If

        If DATA_SEARCH_VS1() Then
            'Call DATA_SEARCH_VS2(txt_cdSpecState.Code)
        End If
        'Call DATA_SEARCH_vs_Image("")
        'Call DATA_SEARCH_vs_Doc("")
    End Sub

    Private Sub Cms_1_Click(sender As Object, e As EventArgs) Handles Cms_1.ItemClicked
        Select Case True
            Case Cms_1.Items(0).Selected
                Cms_1.Hide()
                Call MAIN_JOB01()

            Case Cms_1.Items(1).Selected
                Cms_1.Hide()
                Call MAIN_JOB02()

        End Select
    End Sub

#End Region

    Private Sub chk_Total_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Total.CheckedChanged
        Psc_3.Panel1Collapsed = Not chk_Total.Checked
        Psc_2.Panel1Collapsed = Not chk_Total.Checked

        Psc_2.Panel2Collapsed = chk_Total.Checked

        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False

        If chk_Total.Checked = True Then
            SplitContainer1.SplitterDistance = SPR_SHEETWIDHT(vS_Cus) + SPR_SHEETWIDHT(vS_Line) + cSprWidthSize + cSprWidthSize

        Else
            txt_Line.Data = ""
            txt_Article.Data = ""

            SplitContainer1.SplitterDistance = SPR_SHEETWIDHT(Vs1) + cSprWidthSize
        End If
    End Sub

    Private Sub chk_Image_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Image.CheckedChanged
        psc_Imange.Panel2Collapsed = Not chk_Image.Checked
    End Sub


    Private Sub Me_KeyDown_123(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control = True And e.KeyCode = Keys.V And (vs_Image.Focused Or vS_Doc.Focused) Then
            Dim ShoesCode As String
            ShoesCode = getData(vS2, getColumIndex(vS2, "KEY_SHOESCODE"), vS2.ActiveSheet.ActiveRowIndex)

            If READ_PFK7106(ShoesCode) Then
                Call PastePicture(ShoesCode)

            Else
                MsgBoxP("No ITEM CODE!")
            End If

        End If
    End Sub

    Private Sub vS_Doc_CellClick(sender As Object, e As CellClickEventArgs) Handles vS_Doc.CellClick, vs_Image.CellClick
        If e.Column = getColumIndex(sender, "DoucmentName") Then
            sender.ActiveSheet.OperationMode = OperationMode.Normal
        Else
            sender.ActiveSheet.OperationMode = OperationMode.SingleSelect
        End If
    End Sub

    Private Sub vS_Doc_Change(sender As Object, e As ChangeEventArgs) Handles vS_Doc.Change, vs_Image.Change
        If e.Column = getColumIndex(sender, "DoucmentName") Then
            SQL = "UPDATE [dbo].[PFK7107] "
            SQL = SQL & " SET [K7107_DoucmentName] = '" + getData(sender, getColumIndex(sender, "DoucmentName"), sender.ActiveSheet.ActiveRowIndex) + "'"
            SQL = SQL & " WHERE [K7107_ShoesCode] = '" + getData(sender, getColumIndex(sender, "KEY_ShoesCode"), sender.ActiveSheet.ActiveRowIndex) + "'"
            SQL = SQL & " AND [K7107_SEQ] = '" + CIntp(getData(sender, getColumIndex(sender, "KEY_SEQ"), sender.ActiveSheet.ActiveRowIndex)).ToString + "'"
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()
        End If

    End Sub

    Private Sub vs_Image_KeyDown(sender As Object, e As KeyEventArgs) Handles vs_Image.KeyDown, vS_Doc.KeyDown
        If e.KeyCode = Keys.Delete Then
            Call DATA_DELETE_IMANGE(sender)
        End If
    End Sub

    Private Sub DATA_DELETE_IMANGE(sender As Object)
        Try

            SQL = "DELETE FROM [dbo].[PFK7107] "
            SQL = SQL & " WHERE [K7107_ShoesCode] = '" + getData(sender, getColumIndex(sender, "KEY_ShoesCode"), sender.ActiveSheet.ActiveRowIndex) + "'"
            SQL = SQL & " AND [K7107_SEQ] = '" + CIntp(getData(sender, getColumIndex(sender, "KEY_SEQ"), sender.ActiveSheet.ActiveRowIndex)).ToString + "'"
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            SPR_CLEAR(sender, sender.ActiveSheet.ActiveRowIndex, 0, sender.ActiveSheet.ActiveRowIndex, sender.ActiveSheet.ColumnCount - 1)
            setData(sender, getColumIndex(sender, "FileName"), sender.ActiveSheet.ActiveRowIndex, "[DELETED]")
            'Call MsgBoxP("Delete Successfully!", vbInformation)

            'Call DATA_SEARCH01()

        Catch ex As Exception

        End Try
    End Sub
    Private Function ReadFile(ByVal sPath As String) As Byte()

        'Initialize byte array with a null value initially. 
        Dim data As Byte() = Nothing

        'Use FileInfo object to get file size. 
        Dim fInfo As New FileInfo(sPath)
        Dim numBytes As Long = fInfo.Length

        'Open FileStream to read file 
        Dim fStream As New FileStream(sPath, FileMode.Open, FileAccess.Read)

        'Use BinaryReader to read file stream into byte array. 
        Dim br As New BinaryReader(fStream)

        'When you use BinaryReader, you need to supply number of bytes to read from file. 
        'In this case we want to read entire file. So supplying total number of bytes. 
        data = br.ReadBytes(CInt(numBytes))

        Return data
    End Function
    Private Function ReadFile_Resize_Pic(Imagex As Image) As Byte()

        'Initialize byte array with a null value initially. 
        Dim data As Byte() = Nothing

        'Use FileInfo object to get file size. 
        Imagex = ResizeImage(Imagex, New Size(100, 100))

        Dim imageConverter As New ImageConverter()
        Dim imageByte As Byte() = DirectCast(imageConverter.ConvertTo(Imagex, GetType(Byte())), Byte())


        Return imageByte

    End Function
    Public Function ResizeImage(ByVal image As Image, ByVal size As Size, Optional ByVal preserveAspectRatio As Boolean = True) As Image
        Try
            Dim newWidth As Integer
            Dim newHeight As Integer
            If preserveAspectRatio Then
                Dim originalWidth As Integer = image.Width
                Dim originalHeight As Integer = image.Height
                Dim percentWidth As Single = CSng(size.Width) / CSng(originalWidth)
                Dim percentHeight As Single = CSng(size.Height) / CSng(originalHeight)
                Dim percent As Single = IIf(percentHeight < percentWidth, percentHeight, percentWidth)
                newWidth = CInt(originalWidth * percent)
                newHeight = CInt(originalHeight * percent)
            Else
                newWidth = size.Width
                newHeight = size.Height
            End If

            Dim newImage As Image = New Bitmap(newWidth, newHeight)
            Using graphicsHandle As Graphics = Graphics.FromImage(newImage)
                graphicsHandle.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight)
            End Using

            Return newImage

        Catch ex As Exception
            Return image
        End Try
    End Function

    Private Sub PastePicture(ShoesCode As String)
        Dim Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")

        Dim SqlCom As SqlCommand
        Dim MaxByte As Integer
        Dim imageData As Byte()
        Dim sFileName As String
        Dim qry As String
        Dim sFileType As String

        Dim CntFile As Integer

        Dim StrConvert As String

        CntFile = Clipboard.GetFileDropList.Count

        If READ_PFK7171("000", "889") = True Then

            MaxByte = CIntp(D7171.Check1) * 1024 * 1024

        Else

            MaxByte = 2 * 1024 * 1024

        End If

        Try
            For i As Integer = 0 To CntFile - 1

                'Convert File to bytes Array
                imageData = ReadFile(Clipboard.GetFileDropList(i))

                StrConvert = StrReverse(Clipboard.GetFileDropList(i))
                sFileType = Strings.Left(StrConvert, StrConvert.IndexOf(".", 0))

                sFileType = StrReverse(sFileType)

                If imageData.Length > MaxByte And Pub.SAW <> "PSMADMIN" Then MsgBoxP("Image size is not over 2 MB!") : Exit Sub
                'Set insert query 
                qry = "insert into [PFK7107] ([K7107_ShoesCode],[K7107_SEQ],[K7107_FileName],[K7107_DoucmentName],[K7107_ImageData]," & _
                "[K7107_FileType],[K7107_AttachDate],[K7107_AttachIncharge],[K7107_Time],K7107_CheckType) values (@ShoesCode, @SEQ,@FileName,@DoucmentName,@ImageData,@FileType,@AttachDate,@AttachIncharge,@Time,@CheckType)"

                'Initialize SqlCommand object for insert. 
                SqlCom = New SqlCommand(qry, cn)

                'We are passing File Name and Image byte data as sql parameters. 
                Call KEY_COUNT_IMAGE(ShoesCode)

                sFileName = KEY_SEQ
                sFileName = System.IO.Path.GetFileNameWithoutExtension(Clipboard.GetFileDropList(i))

                SqlCom.Parameters.Add(New SqlParameter("@ShoesCode", ShoesCode))
                SqlCom.Parameters.Add(New SqlParameter("@SEQ", KEY_SEQ))

                SqlCom.Parameters.Add(New SqlParameter("@FileName", sFileName))
                SqlCom.Parameters.Add(New SqlParameter("@DoucmentName", sFileName))

                SqlCom.Parameters.Add(New SqlParameter("@ImageData", DirectCast(imageData, Object)))

                SqlCom.Parameters.Add(New SqlParameter("@FileType", sFileType))
                SqlCom.Parameters.Add(New SqlParameter("@AttachDate", Pub.DAT))
                SqlCom.Parameters.Add(New SqlParameter("@AttachIncharge", Pub.SAW))
                SqlCom.Parameters.Add(New SqlParameter("@Time", System_Date_time))

                If sFileType.ToUpper.Contains("BMP") Or
                    sFileType.ToUpper.Contains("JPG") Or
                    sFileType.ToUpper.Contains("PNG") Or
                    sFileType.ToUpper.Contains("GIF") Or
                    sFileType.ToUpper.Contains("JPEG") Then
                    SqlCom.Parameters.Add(New SqlParameter("@CheckType", "1"))
                    SqlCom.ExecuteNonQuery()


                    qry = "insert into [PFK7117] ([K7117_ShoesCode],[K7117_SEQ],[K7117_FileName],[K7117_DoucmentName],[K7117_ImageData]," & _
                    "[K7117_FileType],[K7117_AttachDate],[K7117_AttachIncharge],[K7117_Time],K7117_CheckType) values (@_ShoesCode, @_SEQ,@_FileName,@_DoucmentName,@_ImageData,@_FileType,@_AttachDate,@_AttachIncharge,@_Time,@_CheckType)"


                    Dim newImage As Image = Nothing

                    Using ms As New MemoryStream(imageData, 0, imageData.Length)
                        ms.Write(imageData, 0, imageData.Length)
                        'Set image variable value using memory stream. 
                        newImage = Image.FromStream(ms, True)
                    End Using

                    'Initialize SqlCommand object for insert. 
                    SqlCom = New SqlCommand(qry, cn)

                    sFileName = KEY_SEQ
                    sFileName = System.IO.Path.GetFileNameWithoutExtension(Clipboard.GetFileDropList(i))

                    SqlCom.Parameters.Add(New SqlParameter("@_ShoesCode", ShoesCode))
                    SqlCom.Parameters.Add(New SqlParameter("@_SEQ", KEY_SEQ))

                    SqlCom.Parameters.Add(New SqlParameter("@_FileName", sFileName))
                    SqlCom.Parameters.Add(New SqlParameter("@_DoucmentName", sFileName))

                    SqlCom.Parameters.Add(New SqlParameter("@_ImageData", DirectCast(ReadFile_Resize_Pic(ResizeImage(newImage, New Size(120, 120))), Object)))

                    SqlCom.Parameters.Add(New SqlParameter("@_FileType", sFileType))
                    SqlCom.Parameters.Add(New SqlParameter("@_AttachDate", Pub.DAT))
                    SqlCom.Parameters.Add(New SqlParameter("@_AttachIncharge", Pub.SAW))
                    SqlCom.Parameters.Add(New SqlParameter("@_Time", System_Date_time))
                    SqlCom.Parameters.Add(New SqlParameter("@_CheckType", "1"))
                    SqlCom.ExecuteNonQuery()


                Else
                    SqlCom.Parameters.Add(New SqlParameter("@CheckType", "2"))
                    SqlCom.ExecuteNonQuery()



                End If

                'Execute the Query


            Next

            Call DATA_SEARCH_vs_Image(ShoesCode)
            Call DATA_SEARCH_vs_Doc(ShoesCode)

        Catch ex As Exception

            MessageBox.Show(ex.ToString())

        Finally
            Starting.Close()


        End Try


    End Sub

    Private Sub vs_Image_CellClick(sender As Object, e As CellClickEventArgs) Handles vs_Image.CellDoubleClick, vS_Doc.CellDoubleClick
        Dim strSql As String = ""

        Try
            If e.Column = getColumIndex(sender, "DoucmentName") Then Exit Sub

            downLoadFile(sender)


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub


    Private Sub downLoadFile(sender As Object)
        Dim sFileName As String
        Dim strSql As String

        'For Document
        Try
            'Get image data from gridview column. 
            strSql = "Select K7107_ImageData from [PFK7107] "
            strSql = strSql & "WHERE [K7107_ShoesCode]= '" & getData(sender, getColumIndex(sender, "Key_ShoesCode"), sender.ActiveSheet.ActiveRowIndex) & "'"
            strSql = strSql & "AND   [K7107_SEQ]= '" & getData(sender, getColumIndex(sender, "KEY_SEQ"), sender.ActiveSheet.ActiveRowIndex) & "'"

            Dim sqlCmd As New SqlCommand(strSql, cn)

            sFileName = getData(sender, getColumIndex(sender, "FileName"), sender.ActiveSheet.ActiveRowIndex)
            sFileName &= "." & getData(sender, getColumIndex(sender, "FileType"), sender.ActiveSheet.ActiveRowIndex)

            'Get image data from DB
            Dim fileData As Byte() = DirectCast(sqlCmd.ExecuteScalar(), Byte())

            Dim sTempFileName As String = System.IO.Path.GetTempPath & sFileName

            If Not fileData Is Nothing Then

                'Read image data into a file stream 
                Using fs As New FileStream(sTempFileName, FileMode.OpenOrCreate, FileAccess.Write)
                    fs.Write(fileData, 0, fileData.Length)
                    'Set image variable value using memory stream. 
                    fs.Flush()
                    fs.Close()
                End Using

                'Open File

                Process.Start(sTempFileName)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Cms_1_Click(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_1.ItemClicked

    End Sub
End Class