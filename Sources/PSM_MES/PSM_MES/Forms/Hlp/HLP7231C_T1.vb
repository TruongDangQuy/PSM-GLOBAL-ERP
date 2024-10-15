Public Class HLP7231C_1

#Region "Variable"
    Public W1_Head As Integer

#End Region

#Region "Form_Load"
    Public Function Link_HLP7231C(BasicName As String) As Boolean
        hlp0000SeVaTt = ""
        hlp0000SeVa = ""
        hlp0000SeVaTt1 = ""
        txt_Name.Data = BasicName
        hlpCHK = False

        Me.ShowDialog()

        Link_HLP7231C = hlpCHK
    End Function

    Public Overridable Sub HLP0001_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hlp0000SeVaTt = ""
        hlp0000SeVa = ""
        hlp0000SeVaTt1 = ""
        hlpCHK = False
        Me.WindowState = FormWindowState.Maximized

        chk_Detail.Checked = False

        Call DATA_SEARCH_HEAD_vs_Large()
        Call DATA_SEARCH_HEAD_vS_Semi()
        Call DATA_SEARCH_HEAD_vS_Detail()

        Call DATA_SEARCH_HEAD_WIDTH()
        Call DATA_SEARCH_HEAD_vS_Unit()

        Setfocus(txt_Name)
    End Sub
#End Region

#Region "Methods"
    Public Function DATA_SEARCH01(Head_No As Long) As Boolean
        DATA_SEARCH01 = False

        Try
            If chkCut = True Then txt_cdSemiGroupMaterial.Code = "134" : Call READ_PFK7171(ListCode("SemiGroupMaterial"), "134") : txt_cdSemiGroupMaterial.Data = D7171.BasicName

            If chkLast = True Then
                txt_cdLargeGroupMaterial.Code = "005" : Call READ_PFK7171(ListCode("LargeGroupMaterial"), "005") : txt_cdLargeGroupMaterial.Data = D7171.BasicName
                txt_cdSemiGroupMaterial.Code = "132" : Call READ_PFK7171(ListCode("SemiGroupMaterial"), "160") : txt_cdSemiGroupMaterial.Data = D7171.BasicName
            End If

            If chkMold = True Then
                txt_cdLargeGroupMaterial.Code = "005" : Call READ_PFK7171(ListCode("LargeGroupMaterial"), "005") : txt_cdLargeGroupMaterial.Data = D7171.BasicName
                txt_cdSemiGroupMaterial.Code = "133" : Call READ_PFK7171(ListCode("SemiGroupMaterial"), "159") : txt_cdSemiGroupMaterial.Data = D7171.BasicName
            End If
            DS1 = PrcDS("USP_HLP7231C_SEARCH_VS1_F1", cn, txt_cdLargeGroupMaterial.Code, "*" & txt_Name.Data, txt_Width.Data, txt_Height.Data, txt_SizeName.Data, txt_cdSemiGroupMaterial.Code, txt_cdDetailGroupMaterial.Code)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_HLP7231C_SEARCH_VS1_F1", "Vs1")
                Vs1.ActiveSheet.RowCount = 0
                Vs1.Enabled = True
                Exit Function
            End If
            SPR_PRO_NEW(Vs1, DS1, "USP_HLP7231C_SEARCH_VS1_F1", "Vs1", , True)

            Me.Show()
            Application.DoEvents()
            Vs1.Focus()

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Public Function DATA_SEARCH_HEAD_vs_Large() As Boolean
        DATA_SEARCH_HEAD_vs_Large = False

        Try
            DS1 = PrcDS("USP_HLP7231C_SEARCH_HEAD", cn, ListCode("LargeGroupMaterial"))
            SPR_PRO_NEW(vs_Large, DS1, "USP_HLP7231C_SEARCH_HEAD", "vs_Large")

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
            DS1 = PrcDS("USP_HLP7231C_SEARCH_HEAD_DETAIL", cn, ListCode("DetailGroupMaterial"), ListCode("SemiGroupMaterial"), cdSemiGroupMaterial)
            SPR_PRO_NEW(vS_Detail, DS1, "USP_HLP7231C_SEARCH_HEAD_DETAIL", "vS_Detail")

            DS1 = Nothing

            DATA_SEARCH_HEAD_vS_Detail = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Public Function DATA_SEARCH_HEAD_vS_Unit() As Boolean
        DATA_SEARCH_HEAD_vS_Unit = False

        Try
            DS1 = PrcDS("USP_HLP7231C_SEARCH_HEAD", cn, ListCode("UnitMaterial"))
            SPR_PRO_NEW(vS_Unit, DS1, "USP_HLP7231C_SEARCH_HEAD_DETAIL", "vS_Unit")

            DS1 = Nothing

            DATA_SEARCH_HEAD_vS_Unit = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Public Function DATA_SEARCH_HEAD_WIDTH() As Boolean
        DATA_SEARCH_HEAD_WIDTH = False

        Try
            DS1 = PrcDS("USP_HLP7231C_SEARCH_HEAD_WIDTH", cn, txt_cdLargeGroupMaterial.Code, txt_cdSemiGroupMaterial.Code, txt_cdDetailGroupMaterial.Code)

            If GetDsRc(DS1) = 0 Then
                DS2 = PrcDS("USP_HLP7231C_SEARCH_HEAD_WIDTH_INSERT", cn)
                SPR_PRO_NEW(vS_Spec, DS2, "USP_HLP7231C_SEARCH_HEAD_WIDTH", "vS_Spec")
                Exit Function
            End If

            SPR_PRO_NEW(vS_Spec, DS1, "USP_HLP7231C_SEARCH_HEAD_WIDTH", "vS_Spec")

            DS1 = Nothing

            DATA_SEARCH_HEAD_WIDTH = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function
#End Region

#Region "Events"
    Private Sub SelectLabelSearch1_KeyDown(sender As Object, e As KeyPressEventArgs) Handles txt_Name.txtTextKeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cmd_SEARCH.PerformClick()
        End If
    End Sub


    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        Call DATA_SEARCH_HEAD_vs_Large()
        Call DATA_SEARCH_HEAD_vS_Semi()
        Call DATA_SEARCH_HEAD_vS_Detail()

        Call DATA_SEARCH_HEAD_vS_Unit()

        chk_Detail.Checked = True

        DATA_SEARCH01(W1_Head)
    End Sub

    Public Overridable Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If READ_PFK7231(getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex)) Then
            If D7231.cdLargeGroupMaterial = "" Or D7231.cdSemiGroupMaterial = "" Or D7231.cdUnitMaterial = "" Then
                If ISUD7231S.Link_ISUD7231S(3, getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex), "PFP70231") = False Then Exit Sub
            End If
        End If

        If getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex) Is Nothing Then
            MsgBoxP("NO VALUE !")
            hlpCHK = False
            Exit Sub
        Else
            hlp0000SeVaTt = getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVa = getData(Vs1, getColumIndex(Vs1, "MaterialName"), Vs1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVaTt1 = getData(Vs1, getColumIndex(Vs1, "MaterialName"), Vs1.ActiveSheet.ActiveRowIndex)
            hlpCHK = True
        End If
        Me.Dispose()
    End Sub

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs)
        If e.Row < 0 Then Exit Sub
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub

    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        If READ_PFK7231(getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex)) Then
            If FormatCut(D7231.cdLargeGroupMaterial) = "" Or FormatCut(D7231.cdSemiGroupMaterial) = "" Or FormatCut(D7231.cdUnitMaterial) = "" Then
                If ISUD7231S.Link_ISUD7231S(3, getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex), "PFP70231") = False Then Exit Sub
            End If
        End If

        If getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex) Is Nothing Then
            MsgBoxP("NO VALUE !")
            hlpCHK = False
            Exit Sub
        Else
            hlp0000SeVaTt = getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVa = getData(Vs1, getColumIndex(Vs1, "MaterialName"), Vs1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVaTt1 = getData(Vs1, getColumIndex(Vs1, "MaterialName"), Vs1.ActiveSheet.ActiveRowIndex)
            hlpCHK = True
        End If
        Me.Dispose()
    End Sub

    Private Sub cmd_Cancel_Click_1(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        hlp0000SeVaTt = ""
        hlp0000SeVa = ""
        hlp0000SeVaTt1 = ""
        hlpCHK = False
        Me.Dispose()
    End Sub

    Private Sub Vs1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmd_OK.PerformClick()
        End If
    End Sub

    Private Sub txt_Add_Click(sender As Object, e As EventArgs) Handles txt_Add.Click
        If ISUD7231S.Link_ISUD7231S(1, getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), Vs1.ActiveSheet.ActiveRowIndex), "PFP70231") = False Then Exit Sub

        Call DATA_SEARCH01(W1_Head)
    End Sub

    Private Sub vs_Large_CellClick(sender As Object, e As CellClickEventArgs) Handles vs_Large.CellClick
        Try
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

            DS1 = PrcDS("USP_HLP7231C_SEARCH_VS1_F1", cn, txt_cdLargeGroupMaterial.Code, "*" & txt_Name.Data, txt_Width.Data, txt_Height.Data, txt_SizeName.Data, txt_cdSemiGroupMaterial.Code, txt_cdDetailGroupMaterial.Code)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_HLP7231C_SEARCH_VS1_F1", "Vs1")
                Vs1.Enabled = True
                Exit Sub
            End If
            SPR_PRO_NEW(Vs1, DS1, "USP_HLP7231C_SEARCH_VS1_F1", "Vs1", , True)

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Sub

    Private Sub vS_Semi_CellClick(sender As Object, e As CellClickEventArgs) Handles vS_Semi.CellClick
        Try
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

            DS1 = PrcDS("USP_HLP7231C_SEARCH_VS1_F1", cn, txt_cdLargeGroupMaterial.Code, "*" & txt_Name.Data, txt_Width.Data, txt_Height.Data, txt_SizeName.Data, txt_cdSemiGroupMaterial.Code, txt_cdDetailGroupMaterial.Code)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_HLP7231C_SEARCH_VS1_F1", "Vs1")
                Vs1.Enabled = True
                Exit Sub
            End If

            SPR_PRO_NEW(Vs1, DS1, "USP_HLP7231C_SEARCH_VS1_F1", "Vs1", , True)

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Sub

    Private Sub vS_Detail_CellClick(sender As Object, e As CellClickEventArgs) Handles vS_Detail.CellClick
        Try
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
            DS1 = PrcDS("USP_HLP7231C_SEARCH_VS1_F1", cn, txt_cdLargeGroupMaterial.Code, "*" & txt_Name.Data, txt_Width.Data, txt_Height.Data, txt_SizeName.Data, txt_cdSemiGroupMaterial.Code, txt_cdDetailGroupMaterial.Code)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_HLP7231C_SEARCH_VS1_F1", "Vs1")
                Vs1.Enabled = True
                Exit Sub
            End If
            SPR_PRO_NEW(Vs1, DS1, "USP_HLP7231C_SEARCH_VS1_F1", "Vs1", , True)

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Sub
    Private Sub vS_Spec_CellClick(sender As Object, e As CellClickEventArgs) Handles vS_Spec.CellClick
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

            DS1 = PrcDS("USP_HLP7231C_SEARCH_VS1_F1", cn, txt_cdLargeGroupMaterial.Code, "*" & txt_Name.Data, txt_Width.Data, txt_Height.Data, txt_SizeName.Data, txt_cdSemiGroupMaterial.Code, txt_cdDetailGroupMaterial.Code)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_HLP7231C_SEARCH_VS1_F1", "Vs1")
                Vs1.Enabled = True
                Exit Sub
            End If
            SPR_PRO_NEW(Vs1, DS1, "USP_HLP7231C_SEARCH_VS1_F1", "Vs1", , True)

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Sub
    Private Sub cmd_QuickAdd_Click(sender As Object, e As EventArgs) Handles cmd_QuickAdd.Click

        If txt_cdLargeGroupMaterial.Code = "" Then MsgBoxP("Large Group") : Exit Sub
        If txt_cdSemiGroupMaterial.Code = "" Then MsgBoxP("Semi Group") : Exit Sub

        Dim cdUnitMaterial As String

        cdUnitMaterial = getData(vS_Unit, getColumIndex(vS_Unit, "BasicCode"), vS_Unit.ActiveSheet.ActiveRowIndex)

        If ISUD7231S.Link_ISUD7231S_ADD(11, txt_cdLargeGroupMaterial.Code, txt_cdSemiGroupMaterial.Code, txt_cdDetailGroupMaterial.Code, txt_Width.Data, txt_Height.Data, txt_SizeName.Data, "", cdUnitMaterial) = False Then Exit Sub
        Call DATA_SEARCH01(W1_Head)

    End Sub
#End Region

End Class