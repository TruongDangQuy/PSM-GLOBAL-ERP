Public Class HLP7231MM

#Region "Variable"
    Public W1_Head As Integer
#End Region

#Region "Form_Load"
    Public Function Link_HLP7231C(BasicName As String) As Boolean
        hlp0000SeVaTt = ""
        hlp0000SeVa = ""
        hlp0000SeVaTt1 = ""
        Array_hlp0000SeVaTt.Clear()
        txt_Name.Data = BasicName
        hlpCHK = False

        Call DATA_SEARCH02()
        Me.ShowDialog()

        Link_HLP7231C = hlpCHK
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

           DS1 = PrcDS("USP_HLP7231C_SEARCH_VS1", cn, txt_cdLargeGroupMaterial.Code, "*" & txt_Name.Data, txt_cdSemiGroupMaterial.Code, txt_cdDetailGroupMaterial.Code)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_HLP7231C_SEARCH_VS1", "Vs1")
                Vs1.ActiveSheet.RowCount = 0
                Vs1.Enabled = True
                Exit Function
            End If
            SPR_PRO_NEW(Vs1, DS1, "USP_HLP7231C_SEARCH_VS1", "Vs1")

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

            DS1 = PrcDS("USP_HLP7231C_SEARCH_VS2", cn)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS2, DS1, "USP_HLP7231C_SEARCH_VS2", "Vs2")
                vS2.ActiveSheet.RowCount = 0
                vS2.Enabled = True
                Exit Function
            End If
            SPR_PRO_NEW(vS2, DS1, "USP_HLP7231C_SEARCH_VS2", "Vs2")

        Catch ex As Exception
            Call MsgBoxP("1", "DATA_SEARCH02")
        End Try
    End Function

    Public Function DATA_SEARCH_HEAD_vs_Large() As Boolean
        DATA_SEARCH_HEAD_vs_Large = False

        Try
            DS1 = PrcDS("USP_HLP7231C_SEARCH_HEAD", cn, ListCode("LargeGroupMaterial"))
            SPR_PRO_NEW(vs_Large, DS1, "USP_HLP7231C_SEARCH_HEAD", "vs_Large")
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
            DS1 = PrcDS("USP_HLP7231C_SEARCH_HEAD_DETAIL", cn, ListCode("SemiGroupMaterial"), ListCode("LargeGroupMaterial"), cdLargeGroupMaterial)
            SPR_PRO_NEW(vS_Semi, DS1, "USP_HLP7231C_SEARCH_HEAD_DETAIL", "vS_Semi")
            vS_Semi.VerticalScrollBarPolicy = ScrollBarPolicy.Never
            vS_Semi.HorizontalScrollBarPolicy = ScrollBarPolicy.Never
            DATA_SEARCH_HEAD_vS_Semi = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Private Sub MAIN_JOB05()
        Select Case True
            Case vs_Large.Focused
                Dim cdLargeGroupMaterial As String

                cdLargeGroupMaterial = getData(vs_Large, getColumIndex(vs_Large, "BasicCode"), vs_Large.ActiveSheet.ActiveRowIndex)

                Call ISUD7171A.Link_ISUD7171A(1, ListCode("LargeGroupMaterial"), cdLargeGroupMaterial, ListCode("SemiGroupMaterial"), "000")

        End Select

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

    End Sub

    Public Overridable Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Dim i As Integer

        hlp0000SeVaTt = 0
        hlp0000SeVa = 0
        hlp0000SeVaTt1 = 0

        For i = 0 To vS2.ActiveSheet.RowCount - 1
            Array_hlp0000SeVaTt.Add(getData(vS2, getColumIndex(vS2, "Key_MaterialCode"), i))
        Next

        Me.Dispose()
    End Sub

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        If e.Row < 0 Then Exit Sub
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
        Dim Value() As String

        Value = Trim(getData(Vs1, getColumIndex(Vs1, "MaterialName"), Vs1.ActiveSheet.ActiveRowIndex)).Split(" ")

       
    End Sub

    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        'If chk_FullText.Checked = False Then Exit Sub

        hlp0000SeVaTt = getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex)

        'If READ_PFK7231(hlp0000SeVaTt) Then
        '    If FormatCut(D7231.cdLargeGroupMaterial) = "" Or FormatCut(D7231.cdSemiGroupMaterial) = "" Or FormatCut(D7231.cdUnitMaterial) = "" Then
        '        If ISUD7231S.Link_ISUD7231S(3, getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex), "PFP70231") = False Then Exit Sub
        '    End If
        'End If

        If READ_PFK7231(getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex)) Then
            If vS2.ActiveSheet.RowCount >= 1 And getData(vS2, getColumIndex(vS2, "Key_MaterialCode"), vS2.ActiveSheet.RowCount - 1) <> "" Then vS2.ActiveSheet.RowCount += 1
            setData(vS2, getColumIndex(vS2, "Key_MaterialCode"), vS2.ActiveSheet.RowCount - 1, D7231.MaterialCode)
            setData(vS2, getColumIndex(vS2, "MaterialCode"), vS2.ActiveSheet.RowCount - 1, D7231.MaterialCode)
            setData(vS2, getColumIndex(vS2, "MaterialName"), vS2.ActiveSheet.RowCount - 1, D7231.MaterialName)
            setData(vS2, getColumIndex(vS2, "MaterialSimple"), vS2.ActiveSheet.RowCount - 1, D7231.MaterialSimple)

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

    Private Sub vS2_CellDoubleClick(sender As Object, e As CellClickEventArgs)
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

    Private Sub vs_Large_CellClick(sender As Object, e As CellClickEventArgs) Handles vs_Large.CellDoubleClick
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


            Call DATA_SEARCH_HEAD_vS_Semi()

            DS1 = PrcDS("USP_HLP7231C_SEARCH_VS1_F1", cn, txt_cdLargeGroupMaterial.Code, "*" & txt_Name.Data, "", "", "", txt_cdSemiGroupMaterial.Code, txt_cdDetailGroupMaterial.Code)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_HLP7231C_SEARCH_VS1_F1", "Vs1")
                Vs1.Enabled = True
                Exit Sub
            End If
            SPR_PRO_NEW(Vs1, DS1, "USP_HLP7231C_SEARCH_VS1_F1", "Vs1")

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Sub

    Private Sub vS_Semi_CellClick(sender As Object, e As CellClickEventArgs) Handles vS_Semi.CellDoubleClick
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


            DS1 = PrcDS("USP_HLP7231C_SEARCH_VS1_F1", cn, txt_cdLargeGroupMaterial.Code, "*" & txt_Name.Data, "", "", "", txt_cdSemiGroupMaterial.Code, txt_cdDetailGroupMaterial.Code)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_HLP7231C_SEARCH_VS1_F1", "Vs1")
                Vs1.Enabled = True
                Exit Sub
            End If

            SPR_PRO_NEW(Vs1, DS1, "USP_HLP7231C_SEARCH_VS1_F1", "Vs1")

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Sub

    Private Sub cmd_Copy_Click(sender As Object, e As EventArgs) Handles cmd_Copy.Click
        Dim MaterialCode As String

        MaterialCode = getData(Vs1, getColumIndex(Vs1, "MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex)
        If ISUD7231S.Link_ISUD7231S(5, MaterialCode, "PFP70231") = False Then Exit Sub
    End Sub

    Private Sub cmd_QuickAdd_Click(sender As Object, e As EventArgs) Handles cmd_QuickAdd.Click
        If ISUD7231S.Link_ISUD7231S_ADD(11, txt_cdLargeGroupMaterial.Code, txt_cdSemiGroupMaterial.Code, txt_cdDetailGroupMaterial.Code, "", "", "", "PFP70231") = False Then Exit Sub
    End Sub

    Private Sub Cms_1_Click(sender As Object, e As EventArgs) Handles Cms_1.ItemClicked
        Select Case True
            Case Cms_1.Items(0).Selected
                Cms_1.Hide()
                Call MAIN_JOB05()
        End Select

    End Sub

    Private Sub cmd_BOM_Click(sender As Object, e As EventArgs) Handles cmd_BOM.Click
        Dim i As Integer

        hlp0000SeVaTt = 0
        hlp0000SeVa = 0
        hlp0000SeVaTt1 = 0
        Array_hlp0000SeVaTt.Clear()

        For i = 0 To vS2.ActiveSheet.RowCount - 1
            Array_hlp0000SeVaTt.Add(getData(vS2, getColumIndex(vS2, "Key_MaterialCode"), i))
        Next

        If ISUD7231S.Link_ISUD7231S_ADD_MULTI(12, getCell(vS2, getColumIndex(vS2, "cdLargeGroupMaterialName"), 0), getCell(vS2, getColumIndex(vS2, "cdSemiGroupMaterialName"), 0), "", Array_hlp0000SeVaTt, "", "", "", "PFP70231") = False Then Exit Sub
        vS2.ActiveSheet.RowCount = 0
        vS2.ActiveSheet.RowCount = 1
        Array_hlp0000SeVaTt.Clear()

        If READ_PFK7231(D7231.MaterialCode) Then

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

    Private Sub cmd_Width_Click(sender As Object, e As EventArgs) Handles cmd_Update.Click
        Dim MaterialCode As String

        MaterialCode = getData(Vs1, getColumIndex(Vs1, "MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex)

        If ISUD7231S.Link_ISUD7231S(3, MaterialCode, "PFP70231") = False Then Exit Sub


    End Sub
#End Region

End Class