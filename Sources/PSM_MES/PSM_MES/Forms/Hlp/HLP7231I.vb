Public Class HLP7231I

#Region "Variable"
    Public W1_Head As Integer
#End Region

#Region "Form_Load"
    Public Function Link_HLP7231I(BasicName As String) As Boolean
        hlp0000SeVaTt = ""
        hlp0000SeVa = ""
        hlp0000SeVaTt1 = ""
        Array_hlp0000SeVaTt.Clear()
        txt_Name.Data = BasicName
        hlpCHK = False

        Call DATA_SEARCH02()
        Me.ShowDialog()

        Link_HLP7231I = hlpCHK
    End Function
    Public Overridable Sub HLP0001_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hlp0000SeVaTt = ""
        hlp0000SeVa = ""
        hlp0000SeVaTt1 = ""
        Me.WindowState = FormWindowState.Maximized
        Array_hlp0000SeVaTt.Clear()
        hlpCHK = False

        vS2.AllowRowMove = True
        Call Cms_additem(Cms_1,
                     WordConv("ADD GROUP PROCESSING") & "(F5)")

        Call DATA_SEARCH_HEAD_vs_Large()
        Call DATA_SEARCH_HEAD_vS_Semi()
        Call DATA_SEARCH_HEAD_vS_Detail()

        Call DATA_SEARCH_HEAD_WIDTH()

        Call DATA_SEARCH02()

        Setfocus(txt_Name)

    End Sub
#End Region

#Region "Methods"
    Public Function DATA_SEARCH01(Head_No As Long) As Boolean
        DATA_SEARCH01 = False
        Dim Value() As String
        Dim strTemp As String

        Try
            If chkCut = True Then txt_cdSemiGroupMaterial.Code = "161" : Call READ_PFK7171(ListCode("SemiGroupMaterial"), "161") : txt_cdSemiGroupMaterial.Data = D7171.BasicName

            If chkLast = True Then
                txt_cdLargeGroupMaterial.Code = "005" : Call READ_PFK7171(ListCode("LargeGroupMaterial"), "005") : txt_cdLargeGroupMaterial.Data = D7171.BasicName
                txt_cdSemiGroupMaterial.Code = "132" : Call READ_PFK7171(ListCode("SemiGroupMaterial"), "160") : txt_cdSemiGroupMaterial.Data = D7171.BasicName
            End If

            If chkMold = True Then
                txt_cdLargeGroupMaterial.Code = "005" : Call READ_PFK7171(ListCode("LargeGroupMaterial"), "005") : txt_cdLargeGroupMaterial.Data = D7171.BasicName
                txt_cdSemiGroupMaterial.Code = "133" : Call READ_PFK7171(ListCode("SemiGroupMaterial"), "159") : txt_cdSemiGroupMaterial.Data = D7171.BasicName
            End If

            If chk_FullText.Checked = False Then
                Value = Trim(txt_Name.Data).Split(" ")

                txt_Name1.Data = ""
                txt_Name2.Data = ""
                txt_Name3.Data = ""
                txt_Name4.Data = ""
                txt_Name5.Data = ""
                txt_Name6.Data = ""
                txt_Name7.Data = ""
                txt_Name8.Data = ""

                If Value.Length >= 1 Then
                    If Value.Length = 1 Then chk_1.Checked = True : txt_Name1.Data = Value(0)

                    If Value.Length = 2 Then chk_1.Checked = True : chk_2.Checked = True : txt_Name1.Data = Value(0) : txt_Name2.Data = Value(1)

                    If Value.Length = 3 Then chk_1.Checked = True : chk_2.Checked = True : chk_3.Checked = True : txt_Name1.Data = Value(0) : txt_Name2.Data = Value(1) : txt_Name3.Data = Value(2)

                    If Value.Length = 4 Then chk_1.Checked = True : chk_2.Checked = True : chk_3.Checked = True : chk_4.Checked = True : txt_Name1.Data = Value(0) : txt_Name2.Data = Value(1) : txt_Name3.Data = Value(2) : txt_Name4.Data = Value(3)

                    If Value.Length = 5 Then chk_1.Checked = True : chk_2.Checked = True : chk_3.Checked = True : chk_4.Checked = True : chk_5.Checked = True : txt_Name1.Data = Value(0) : txt_Name2.Data = Value(1) : txt_Name3.Data = Value(2) : txt_Name4.Data = Value(3) : txt_Name5.Data = Value(4)

                    If Value.Length = 6 Then chk_1.Checked = True : chk_2.Checked = True : chk_3.Checked = True : chk_4.Checked = True : chk_5.Checked = True : chk_6.Checked = True : txt_Name1.Data = Value(0) : txt_Name2.Data = Value(1) : txt_Name3.Data = Value(2) : txt_Name4.Data = Value(3) : txt_Name5.Data = Value(4) : txt_Name6.Data = Value(5)

                    If Value.Length = 7 Then chk_1.Checked = True : chk_2.Checked = True : chk_3.Checked = True : chk_4.Checked = True : chk_5.Checked = True : chk_6.Checked = True : chk_7.Checked = True : txt_Name1.Data = Value(0) : txt_Name2.Data = Value(1) : txt_Name3.Data = Value(2) : txt_Name4.Data = Value(3) : txt_Name5.Data = Value(4) : txt_Name6.Data = Value(5) : txt_Name7.Data = Value(6)

                    If Value.Length = 8 Then chk_1.Checked = True : chk_2.Checked = True : chk_3.Checked = True : chk_4.Checked = True : chk_5.Checked = True : chk_6.Checked = True : chk_7.Checked = True : chk_8.Checked = True : txt_Name1.Data = Value(0) : txt_Name2.Data = Value(1) : txt_Name3.Data = Value(2) : txt_Name4.Data = Value(3) : txt_Name5.Data = Value(4) : txt_Name6.Data = Value(5) : txt_Name7.Data = Value(6) : txt_Name8.Data = Value(7)

                End If

                DS1 = PrcDS("USP_HLP7231I_SEARCH_VS1", cn, txt_cdLargeGroupMaterial.Code, "*" & txt_Name.Data, txt_cdSemiGroupMaterial.Code, txt_cdDetailGroupMaterial.Code)
            Else
                If chk_1.Checked = True Then If FormatCut(txt_Name1.Data) <> "" Then If rad_N1.Checked = True Then strTemp &= " AND " & txt_Name1.Data
                If chk_2.Checked = True Then If FormatCut(txt_Name2.Data) <> "" Then If rad_N2.Checked = True Then strTemp &= " AND " & txt_Name2.Data
                If chk_3.Checked = True Then If FormatCut(txt_Name3.Data) <> "" Then If rad_N3.Checked = True Then strTemp &= " AND " & txt_Name3.Data
                If chk_4.Checked = True Then If FormatCut(txt_Name4.Data) <> "" Then If rad_N4.Checked = True Then strTemp &= " AND " & txt_Name4.Data
                If chk_5.Checked = True Then If FormatCut(txt_Name5.Data) <> "" Then If rad_N5.Checked = True Then strTemp &= " AND " & txt_Name5.Data
                If chk_6.Checked = True Then If FormatCut(txt_Name6.Data) <> "" Then If rad_N6.Checked = True Then strTemp &= " AND " & txt_Name6.Data
                If chk_7.Checked = True Then If FormatCut(txt_Name7.Data) <> "" Then If rad_N7.Checked = True Then strTemp &= " AND " & txt_Name7.Data
                If chk_8.Checked = True Then If FormatCut(txt_Name8.Data) <> "" Then If rad_N8.Checked = True Then strTemp &= " AND " & txt_Name8.Data

                If chk_1.Checked = True Then If FormatCut(txt_Name1.Data) <> "" Then If rad_O1.Checked = True Then strTemp &= " OR " & txt_Name1.Data
                If chk_2.Checked = True Then If FormatCut(txt_Name2.Data) <> "" Then If rad_O2.Checked = True Then strTemp &= " OR " & txt_Name2.Data
                If chk_3.Checked = True Then If FormatCut(txt_Name3.Data) <> "" Then If rad_O3.Checked = True Then strTemp &= " OR " & txt_Name3.Data
                If chk_4.Checked = True Then If FormatCut(txt_Name4.Data) <> "" Then If rad_O4.Checked = True Then strTemp &= " OR " & txt_Name4.Data
                If chk_5.Checked = True Then If FormatCut(txt_Name5.Data) <> "" Then If rad_O5.Checked = True Then strTemp &= " OR " & txt_Name5.Data
                If chk_6.Checked = True Then If FormatCut(txt_Name6.Data) <> "" Then If rad_O6.Checked = True Then strTemp &= " OR " & txt_Name6.Data
                If chk_7.Checked = True Then If FormatCut(txt_Name7.Data) <> "" Then If rad_O7.Checked = True Then strTemp &= " OR " & txt_Name7.Data
                If chk_8.Checked = True Then If FormatCut(txt_Name8.Data) <> "" Then If rad_O8.Checked = True Then strTemp &= " OR " & txt_Name8.Data

                strTemp = strTemp.Replace("""", "''")
                strTemp = Mid(strTemp, 5)

                DS1 = PrcDS("USP_HLP7231I_SEARCH_VS1_FULLTEXT", cn, txt_cdLargeGroupMaterial.Code, strTemp, txt_cdSemiGroupMaterial.Code, txt_cdDetailGroupMaterial.Code)
            End If

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_HLP7231I_SEARCH_VS1", "Vs1")
                Vs1.ActiveSheet.RowCount = 0
                Vs1.Enabled = True
                Exit Function
            End If
            SPR_PRO_NEW(Vs1, DS1, "USP_HLP7231I_SEARCH_VS1", "Vs1")

            Me.Show()
            Application.DoEvents()
            Vs1.Focus()

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Public Function DATA_SEARCH02() As Boolean
        DATA_SEARCH02 = False
        Try

            DS1 = PrcDS("USP_HLP7231I_SEARCH_VS2", cn)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS2, DS1, "USP_HLP7231I_SEARCH_VS2", "Vs2")
                vS2.ActiveSheet.RowCount = 0
                vS2.Enabled = True
                Exit Function
            End If
            SPR_PRO_NEW(vS2, DS1, "USP_HLP7231I_SEARCH_VS2", "Vs2")

        Catch ex As Exception
            Call MsgBoxP("1", "DATA_SEARCH02")
        End Try
    End Function

    Public Function DATA_SEARCH_HEAD_vs_Large() As Boolean
        DATA_SEARCH_HEAD_vs_Large = False

        Try
            DS1 = PrcDS("USP_HLP7231I_SEARCH_HEAD", cn, ListCode("LargeGroupMaterial"))
            SPR_PRO_NEW(vs_Large, DS1, "USP_HLP7231I_SEARCH_HEAD", "vs_Large")
            vs_Large.VerticalScrollBarPolicy = ScrollBarPolicy.Never
            vs_Large.HorizontalScrollBarPolicy = ScrollBarPolicy.Never
            DS1 = Nothing
            DATA_SEARCH_HEAD_vs_Large = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Public Function DATA_SEARCH_HEAD_vS_Semi() As Boolean
        DATA_SEARCH_HEAD_vS_Semi = False

        Dim cdLargeGroupMaterial As String
        cdLargeGroupMaterial = getData(vs_Large, getColumIndex(vs_Large, "BasicCode"), vs_Large.ActiveSheet.ActiveRowIndex)

        Try
            DS1 = PrcDS("USP_HLP7231I_SEARCH_HEAD_DETAIL", cn, ListCode("SemiGroupMaterial"), ListCode("LargeGroupMaterial"), cdLargeGroupMaterial)
            SPR_PRO_NEW(vS_Semi, DS1, "USP_HLP7231I_SEARCH_HEAD_DETAIL", "vS_Semi")
            vS_Semi.VerticalScrollBarPolicy = ScrollBarPolicy.Never
            vS_Semi.HorizontalScrollBarPolicy = ScrollBarPolicy.Never
            DATA_SEARCH_HEAD_vS_Semi = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Public Function DATA_SEARCH_HEAD_vS_Detail() As Boolean
        DATA_SEARCH_HEAD_vS_Detail = False

        Dim cdSemiGroupMaterial As String
        cdSemiGroupMaterial = getData(vS_Semi, getColumIndex(vS_Semi, "BasicCode"), vS_Semi.ActiveSheet.ActiveRowIndex)
        Try
            DS1 = PrcDS("USP_HLP7231I_SEARCH_HEAD_DETAIL", cn, ListCode("DetailGroupMaterial"), ListCode("SemiGroupMaterial"), cdSemiGroupMaterial)
            SPR_PRO_NEW(vS_Detail, DS1, "USP_HLP7231I_SEARCH_HEAD_DETAIL", "vS_Detail")
            vS_Detail.VerticalScrollBarPolicy = ScrollBarPolicy.Never
            vS_Detail.HorizontalScrollBarPolicy = ScrollBarPolicy.Never
            DS1 = Nothing

            DATA_SEARCH_HEAD_vS_Detail = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Public Function DATA_SEARCH_HEAD_WIDTH() As Boolean
        DATA_SEARCH_HEAD_WIDTH = False

        Try
            DS1 = PrcDS("USP_HLP7231I_SEARCH_HEAD_WIDTH", cn, txt_cdLargeGroupMaterial.Code, txt_cdSemiGroupMaterial.Code, txt_cdDetailGroupMaterial.Code)

            If GetDsRc(DS1) = 0 Then
                DS2 = PrcDS("USP_HLP7231I_SEARCH_HEAD_WIDTH_INSERT", cn)
                SPR_PRO_NEW(vS_Spec, DS2, "USP_HLP7231I_SEARCH_HEAD_WIDTH", "vS_Spec")
                Exit Function
            End If

            SPR_PRO_NEW(vS_Spec, DS1, "USP_HLP7231I_SEARCH_HEAD_WIDTH", "vS_Spec")

            DATA_SEARCH_HEAD_WIDTH = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Private Sub MAIN_JOB05()


    End Sub
#End Region

#Region "Events"
    Private Sub SelectLabelSearch1_KeyDown(sender As Object, e As KeyPressEventArgs) Handles txt_Name.txtTextKeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cmd_SEARCH.PerformClick()
        End If

    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        DATA_SEARCH01(W1_Head)

        Call DATA_SEARCH_HEAD_vs_Large()
        Call DATA_SEARCH_HEAD_vS_Semi()
        Call DATA_SEARCH_HEAD_vS_Detail()

        Call DATA_SEARCH_HEAD_WIDTH()

    End Sub

    Public Overridable Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Dim i As Integer

        hlp0000SeVaTt = 0
        hlp0000SeVa = 0
        hlp0000SeVaTt1 = 0

        Array_hlp0000SeVaTt.Clear()
        Array_hlp0000SeVaTt1.Clear()

        For i = 0 To vS2.ActiveSheet.RowCount - 1
            Array_hlp0000SeVaTt.Add(getData(vS2, getColumIndex(vS2, "Key_MaterialCode"), i))
            Array_hlp0000SeVaTt1.Add(getData(vS2, getColumIndex(vS2, "ColorName"), i))
        Next

        Me.Dispose()
    End Sub

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs)
        If e.Row < 0 Then Exit Sub
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub

    Private Sub Vs1_CellClick1(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        Dim Value() As String

        Value = Trim(getData(Vs1, getColumIndex(Vs1, "MaterialName"), Vs1.ActiveSheet.ActiveRowIndex)).Split(" ")

        txt_Name1.Data = ""
        txt_Name2.Data = ""
        txt_Name3.Data = ""
        txt_Name4.Data = ""
        txt_Name5.Data = ""
        txt_Name6.Data = ""
        txt_Name7.Data = ""
        txt_Name8.Data = ""

        If Value.Length >= 1 Then
            If Value.Length = 1 Then txt_Name1.Data = Value(0)

            If Value.Length = 2 Then txt_Name1.Data = Value(0) : txt_Name2.Data = Value(1)

            If Value.Length = 3 Then txt_Name1.Data = Value(0) : txt_Name2.Data = Value(1) : txt_Name3.Data = Value(2)

            If Value.Length = 4 Then txt_Name1.Data = Value(0) : txt_Name2.Data = Value(1) : txt_Name3.Data = Value(2) : txt_Name4.Data = Value(3)

            If Value.Length = 5 Then txt_Name1.Data = Value(0) : txt_Name2.Data = Value(1) : txt_Name3.Data = Value(2) : txt_Name4.Data = Value(3) : txt_Name5.Data = Value(4)

            If Value.Length = 6 Then txt_Name1.Data = Value(0) : txt_Name2.Data = Value(1) : txt_Name3.Data = Value(2) : txt_Name4.Data = Value(3) : txt_Name5.Data = Value(4) : txt_Name6.Data = Value(5)

            If Value.Length = 7 Then txt_Name1.Data = Value(0) : txt_Name2.Data = Value(1) : txt_Name3.Data = Value(2) : txt_Name4.Data = Value(3) : txt_Name5.Data = Value(4) : txt_Name6.Data = Value(5) : txt_Name7.Data = Value(6)

            If Value.Length = 8 Then txt_Name1.Data = Value(0) : txt_Name2.Data = Value(1) : txt_Name3.Data = Value(2) : txt_Name4.Data = Value(3) : txt_Name5.Data = Value(4) : txt_Name6.Data = Value(5) : txt_Name7.Data = Value(6) : txt_Name8.Data = Value(7)

        End If
    End Sub

    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        'If chk_FullText.Checked = False Then Exit Sub

        hlp0000SeVaTt = getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex)


        If READ_PFK7231(getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex)) Then
            If vS2.ActiveSheet.RowCount >= 1 And getData(vS2, getColumIndex(vS2, "Key_MaterialCode"), vS2.ActiveSheet.RowCount - 1) <> "" Then vS2.ActiveSheet.RowCount += 1
            setData(vS2, getColumIndex(vS2, "Key_MaterialCode"), vS2.ActiveSheet.RowCount - 1, D7231.MaterialCode)
            setData(vS2, getColumIndex(vS2, "MaterialCode"), vS2.ActiveSheet.RowCount - 1, D7231.MaterialCode)
            setData(vS2, getColumIndex(vS2, "MaterialName"), vS2.ActiveSheet.RowCount - 1, D7231.MaterialName + " " + D7231.MaterialPName)

            setData(vS2, getColumIndex(vS2, "MaterialPName"), vS2.ActiveSheet.RowCount - 1, D7231.MaterialPName)
            setData(vS2, getColumIndex(vS2, "Width"), vS2.ActiveSheet.RowCount - 1, D7231.Width)
            setData(vS2, getColumIndex(vS2, "Height"), vS2.ActiveSheet.RowCount - 1, D7231.Height)
            setData(vS2, getColumIndex(vS2, "SizeName"), vS2.ActiveSheet.RowCount - 1, D7231.SizeName)

            If READ_PFK7171(ListCode("LargeGroupMaterial"), D7231.cdLargeGroupMaterial) Then
                setCell(vS2, getColumIndex(vS2, "cdLargeGroupMaterialName"), vS2.ActiveSheet.RowCount - 1, D7171.BasicCode)
                setData(vS2, getColumIndex(vS2, "cdLargeGroupMaterialName"), vS2.ActiveSheet.RowCount - 1, D7171.BasicName)
            End If

            If READ_PFK7171(ListCode("SemiGroupMaterial"), D7231.cdSemiGroupMaterial) Then
                setCell(vS2, getColumIndex(vS2, "cdSemiGroupMaterialName"), vS2.ActiveSheet.RowCount - 1, D7171.BasicCode)
                setData(vS2, getColumIndex(vS2, "cdSemiGroupMaterialName"), vS2.ActiveSheet.RowCount - 1, D7171.BasicName)
            End If

            If READ_PFK7171(ListCode("DetailGroupMaterial"), D7231.cdDetailGroupMaterial) Then
                setCell(vS2, getColumIndex(vS2, "cdDetailGroupMaterialName"), vS2.ActiveSheet.RowCount - 1, D7171.BasicCode)
                setData(vS2, getColumIndex(vS2, "cdDetailGroupMaterialName"), vS2.ActiveSheet.RowCount - 1, D7171.BasicName)
            End If

            If READ_PFK7171(ListCode("UnitMaterial"), D7231.cdUnitMaterial) Then
                setData(vS2, getColumIndex(vS2, "cdUnitMaterialName"), vS2.ActiveSheet.RowCount - 1, D7171.BasicName)
            End If

            If READ_PFK7171(ListCode("UnitPacking"), D7231.cdUnitPacking) Then
                setData(vS2, getColumIndex(vS2, "cdUnitPackingName"), vS2.ActiveSheet.RowCount - 1, D7171.BasicName)
            End If


            setData(vS2, getColumIndex(vS2, "ColorName"), vS2.ActiveSheet.RowCount - 1, getData(Vs1, getColumIndex(Vs1, "ColorName"), Vs1.ActiveSheet.ActiveRowIndex))

        End If

    End Sub

    Private Sub cmd_Cancel_Click_1(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        hlp0000SeVaTt = ""
        hlp0000SeVa = ""
        hlp0000SeVaTt1 = ""
        Array_hlp0000SeVaTt.Clear()

        hlpCHK = False
        Me.Dispose()
    End Sub

    Private Sub Vs1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmd_OK.PerformClick()
        End If
    End Sub

    Private Sub txt_Add_Click(sender As Object, e As EventArgs)
        If ISUD7231A.Link_ISUD7231A(1, getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex), "PFP70231") = False Then Exit Sub

        Call DATA_SEARCH01(W1_Head)

    End Sub

    Private Sub vS2_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS2.CellDoubleClick
        If ISUD7231S.Link_ISUD7231S(3, getData(vS2, getColumIndex(vS2, "Key_MaterialCode"), vS2.ActiveSheet.ActiveRowIndex), "PFP70231") = False Then Exit Sub
        If READ_PFK7231(getData(vS2, getColumIndex(vS2, "Key_MaterialCode"), vS2.ActiveSheet.ActiveRowIndex)) Then

            setData(vS2, getColumIndex(vS2, "Key_MaterialCode"), vS2.ActiveSheet.ActiveRowIndex, D7231.MaterialCode)
            setData(vS2, getColumIndex(vS2, "MaterialCode"), vS2.ActiveSheet.ActiveRowIndex, D7231.MaterialCode)
            setData(vS2, getColumIndex(vS2, "MaterialName"), vS2.ActiveSheet.ActiveRowIndex, D7231.MaterialName)
            setData(vS2, getColumIndex(vS2, "MaterialSimple"), vS2.ActiveSheet.ActiveRowIndex, D7231.MaterialSimple)

            If READ_PFK7171(ListCode("LargeGroupMaterial"), D7231.cdLargeGroupMaterial) Then
                setCell(vS2, getColumIndex(vS2, "cdLargeGroupMaterialName"), vS2.ActiveSheet.ActiveRowIndex, D7171.BasicCode)
                setData(vS2, getColumIndex(vS2, "cdLargeGroupMaterialName"), vS2.ActiveSheet.ActiveRowIndex, D7171.BasicName)
            End If

            If READ_PFK7171(ListCode("SemiGroupMaterial"), D7231.cdSemiGroupMaterial) Then
                setCell(vS2, getColumIndex(vS2, "cdSemiGroupMaterialName"), vS2.ActiveSheet.ActiveRowIndex, D7171.BasicCode)
                setData(vS2, getColumIndex(vS2, "cdSemiGroupMaterialName"), vS2.ActiveSheet.ActiveRowIndex, D7171.BasicName)
            End If

            If READ_PFK7171(ListCode("DetailGroupMaterial"), D7231.cdDetailGroupMaterial) Then
                setCell(vS2, getColumIndex(vS2, "cdDetailGroupMaterialName"), vS2.ActiveSheet.ActiveRowIndex, D7171.BasicCode)
                setData(vS2, getColumIndex(vS2, "cdDetailGroupMaterialName"), vS2.ActiveSheet.ActiveRowIndex, D7171.BasicName)
            End If


        End If

    End Sub

    Private Sub vS2_KeyDown(sender As Object, e As KeyEventArgs) Handles vS2.KeyDown
        If e.KeyCode = Keys.Delete Then
            SPR_DEL(vS2, vS2.ActiveSheet.ActiveColumnIndex, vS2.ActiveSheet.ActiveRowIndex)
        End If
    End Sub

    Private Sub vs_Large_CellClick(sender As Object, e As CellClickEventArgs) Handles vs_Large.CellClick
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        Try
            txt_cdLargeGroupMaterial.Code = ""
            txt_cdLargeGroupMaterial.Data = ""

            Dim cdLargeGroupMaterial As String

            cdLargeGroupMaterial = getData(vs_Large, getColumIndex(vs_Large, "BasicCode"), vs_Large.ActiveSheet.ActiveRowIndex)

            If READ_PFK7171(ListCode("LargeGroupMaterial"), cdLargeGroupMaterial) Then
                txt_cdLargeGroupMaterial.Code = D7171.BasicCode
                txt_cdLargeGroupMaterial.Data = D7171.BasicName
            End If

            txt_Name.Data = ""
            txt_cdSemiGroupMaterial.Code = ""
            txt_cdDetailGroupMaterial.Code = ""
            txt_cdSemiGroupMaterial.Data = ""
            txt_cdDetailGroupMaterial.Data = ""

            txt_Width.Data = ""
            txt_Height.Data = ""
            txt_SizeName.Data = ""

            Call DATA_SEARCH_HEAD_WIDTH()
            Call DATA_SEARCH_HEAD_vS_Semi()

            DS1 = PrcDS("USP_HLP7231I_SEARCH_VS1_F1", cn, txt_cdLargeGroupMaterial.Code, "*" & txt_Name.Data, txt_Width.Data, txt_Height.Data, txt_SizeName.Data, txt_cdSemiGroupMaterial.Code, txt_cdDetailGroupMaterial.Code)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_HLP7231I_SEARCH_VS1_F1", "Vs1")
                Vs1.Enabled = True
                Exit Sub
            End If
            SPR_PRO_NEW(Vs1, DS1, "USP_HLP7231I_SEARCH_VS1_F1", "Vs1")

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Sub

    Private Sub vS_Semi_CellClick(sender As Object, e As CellClickEventArgs) Handles vS_Semi.CellClick
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub

        Try
            txt_cdSemiGroupMaterial.Code = ""
            txt_cdSemiGroupMaterial.Data = ""

            Dim cdSemiGroupMaterial As String

            cdSemiGroupMaterial = getData(vS_Semi, getColumIndex(vS_Semi, "BasicCode"), vS_Semi.ActiveSheet.ActiveRowIndex)

            If READ_PFK7171(ListCode("SemiGroupMaterial"), cdSemiGroupMaterial) Then
                txt_cdSemiGroupMaterial.Code = D7171.BasicCode
                txt_cdSemiGroupMaterial.Data = D7171.BasicName
            End If

            txt_Name.Data = ""
            txt_cdDetailGroupMaterial.Code = ""
            txt_cdDetailGroupMaterial.Data = ""

            txt_Width.Data = ""
            txt_Height.Data = ""
            txt_SizeName.Data = ""

            Call DATA_SEARCH_HEAD_WIDTH()
            Call DATA_SEARCH_HEAD_vS_Detail()

            DS1 = PrcDS("USP_HLP7231I_SEARCH_VS1_F1", cn, txt_cdLargeGroupMaterial.Code, "*" & txt_Name.Data, txt_Width.Data, txt_Height.Data, txt_SizeName.Data, txt_cdSemiGroupMaterial.Code, txt_cdDetailGroupMaterial.Code)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_HLP7231I_SEARCH_VS1_F1", "Vs1")
                Vs1.Enabled = True
                Exit Sub
            End If

            SPR_PRO_NEW(Vs1, DS1, "USP_HLP7231I_SEARCH_VS1_F1", "Vs1")

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Sub

    Private Sub vS_Detail_CellClick(sender As Object, e As CellClickEventArgs) Handles vS_Detail.CellClick
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub

        Try
            txt_cdDetailGroupMaterial.Code = ""
            txt_cdDetailGroupMaterial.Data = ""

            Dim cdDetailGroupMaterial As String

            cdDetailGroupMaterial = getData(vS_Detail, getColumIndex(vS_Detail, "BasicCode"), vS_Detail.ActiveSheet.ActiveRowIndex)

            If READ_PFK7171(ListCode("DetailGroupMaterial"), cdDetailGroupMaterial) Then
                txt_cdDetailGroupMaterial.Code = D7171.BasicCode
                txt_cdDetailGroupMaterial.Data = D7171.BasicName
            End If

            txt_Width.Data = ""
            txt_Height.Data = ""
            txt_SizeName.Data = ""

            Call DATA_SEARCH_HEAD_WIDTH()

            DS1 = PrcDS("USP_HLP7231I_SEARCH_VS1_F1", cn, txt_cdLargeGroupMaterial.Code, "*" & txt_Name.Data, txt_Width.Data, txt_Height.Data, txt_SizeName.Data, txt_cdSemiGroupMaterial.Code, txt_cdDetailGroupMaterial.Code)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_HLP7231I_SEARCH_VS1_F1", "Vs1")
                Vs1.Enabled = True
                Exit Sub
            End If
            SPR_PRO_NEW(Vs1, DS1, "USP_HLP7231I_SEARCH_VS1_F1", "Vs1")

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Sub

    Private Sub vS_Spec_CellClick(sender As Object, e As CellClickEventArgs) Handles vS_Spec.CellClick
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub

        Try
            Dim Width As String
            Dim Height As String
            Dim SizeName As String

            If e.Column = getColumIndex(vS_Spec, "Width") Then
                Width = getData(vS_Spec, getColumIndex(vS_Spec, "Width"), vS_Spec.ActiveSheet.ActiveRowIndex)
                txt_Width.Data = Width
            End If

            If e.Column = getColumIndex(vS_Spec, "Height") Then
                Height = getData(vS_Spec, getColumIndex(vS_Spec, "Height"), vS_Spec.ActiveSheet.ActiveRowIndex)
                txt_Height.Data = Height
            End If

            If e.Column = getColumIndex(vS_Spec, "SizeName") Then
                SizeName = getData(vS_Spec, getColumIndex(vS_Spec, "SizeName"), vS_Spec.ActiveSheet.ActiveRowIndex)
                txt_SizeName.Data = SizeName
            End If

            DS1 = PrcDS("USP_HLP7231I_SEARCH_VS1_F1", cn, txt_cdLargeGroupMaterial.Code, "*" & txt_Name.Data, txt_Width.Data, txt_Height.Data, txt_SizeName.Data, txt_cdSemiGroupMaterial.Code, txt_cdDetailGroupMaterial.Code)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_HLP7231I_SEARCH_VS1_F1", "Vs1")
                Vs1.Enabled = True
                Exit Sub
            End If
            SPR_PRO_NEW(Vs1, DS1, "USP_HLP7231I_SEARCH_VS1_F1", "Vs1")

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Sub

    Private Sub Cms_1_Click(sender As Object, e As EventArgs) Handles Cms_1.ItemClicked
        Select Case True
            Case Cms_1.Items(0).Selected
                Cms_1.Hide()
                Call MAIN_JOB05()
        End Select

    End Sub
#End Region

End Class