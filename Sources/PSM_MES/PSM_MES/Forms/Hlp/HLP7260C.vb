Public Class HLP7260C

#Region "Variable"

    Private Dsu01 As Long     'Data Su
    Private wGCODE As String

    Private W7260 As New T7260_AREA
    Private L7260 As New T7260_AREA

    Private Form_Close As Boolean
    Private CheckMaterialType As String = "2"
#End Region

#Region "Form_load"
    Friend Function Link_HLP7260C(SupplierCode As String, Optional _CheckMaterialType As String = "2") As Boolean
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        hlp0000SeVaTt1 = ""

        Link_HLP7260C = False

        CheckMaterialType = _CheckMaterialType

        Call DATA_SEARCH_VS3()

        Try
            Me.ShowDialog()

            Link_HLP7260C = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Link_HLP7260B"))
        End Try


    End Function
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
       
        Me.KeyPreview = True

        Call FORM_INIT()
        Call DATA_INIT()

        SdateEdate.text1 = System_Date_Add(-1)
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

    Private Sub MAIN_JOB05()
    End Sub

#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS1(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS1 = False
        Vs1.Enabled = False
        Dim MaterialType As String = "1"

        If Me.PeaceFormType = "RnD" Then
            MaterialType = "2"
        Else
            MaterialType = "1"
        End If

        DS1 = PrcDS("USP_HLP7106C_SEARCH_VS1", cn, "*" & txt_CustomerCode.Data, MaterialType)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs1, DS1, "USP_HLP7106C_SEARCH_VS1", "Vs1")
            Vs1.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "USP_HLP7106C_SEARCH_VS1", "Vs1")
        DATA_SEARCH_VS1 = True

        Vs1.Enabled = True
    End Function


     Private Function DATA_SEARCH_VS2(CustomerCode As String) As Boolean
        DATA_SEARCH_VS2 = False
        vS2.Enabled = False
        Dim MaterialType As String = "1"

        If Me.PeaceFormType = "RnD" Then
            MaterialType = "2"
        Else
            MaterialType = "1"
        End If

        DS1 = PrcDS("USP_HLP7106C_SEARCH_VS2", cn, txt_ContractNo.Data,
                                                    CustomerCode,
                                                    txt_MaterialCode.Data,
                                                    rad_CheckSupplierPrice1.CheckState,
                                                    rad_CheckSupplierPrice2.CheckState,
                                                    rad_CheckSupplierPrice3.CheckState,
                                                    rad_CheckSupplierPrice4.CheckState,
                                                    rad_CheckSupplierPrice5.CheckState,
                                                    rad_CheckSupplierPrice6.CheckState,
                                                    rad_CheckUse1.CheckState,
                                                    rad_CheckUse2.CheckState,
                                                    MaterialType)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS2, DS1, "USP_HLP7106C_SEARCH_VS2", "VS2")
            vS2.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS2, DS1, "USP_HLP7106C_SEARCH_VS2", "VS2")
        DATA_SEARCH_VS2 = True

        vS2.Enabled = True
    End Function

    Private Function DATA_SEARCH_VS3() As Boolean
        DATA_SEARCH_VS3 = False
        vS3.Enabled = False
        Dim MaterialType As String = "1"

        If Me.PeaceFormType = "RnD" Then
            MaterialType = "2"
        Else
            MaterialType = "1"
        End If

        DS1 = PrcDS("USP_HLP7106C_SEARCH_VS3", cn)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS3, DS1, "USP_HLP7106C_SEARCH_VS3", "vS3")
            vS3.ActiveSheet.RowCount = 0
            vS3.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS3, DS1, "USP_HLP7106C_SEARCH_VS3", "vS3")
        DATA_SEARCH_VS3 = True
        vS3.Enabled = True

    End Function

#End Region

#Region "Event"

    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        Dim CustomerCode As String

        CustomerCode = getData(Vs1, getColumIndex(Vs1, "KEY_CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex)

        If CustomerCode <> "" Then
            If READ_PFK7101(CustomerCode) Then
                txt_CustomerCode.Code = D7101.CustomerCode
                txt_CustomerCode.Data = D7101.CustomerName
            Else
                txt_CustomerCode.Code = ""
                txt_CustomerCode.Data = ""
            End If
        Else
            If txt_CustomerCode.Data = "" Then txt_CustomerCode.Code = ""
        End If

        Call DATA_SEARCH_VS2(txt_CustomerCode.Code)
    End Sub

    Private Sub vS1_GotFocus(sender As Object, e As EventArgs) Handles Vs1.GotFocus

        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False
    End Sub
    Private Sub vS2_GotFocus(sender As Object, e As EventArgs)


        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False
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

        Call DATA_SEARCH_VS1()

    End Sub

    Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        isudCHK = False
        Me.Dispose()
    End Sub

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        Dim i As Integer
        Dim CheckValue As Boolean = False
        Dim KEY_ContractID As String
        Dim KEY_MaterialCode As String
        Dim KEY_ColorName As String

        Array_hlp0000SeVaTt.Clear()
        Array_hlp0000SeVaTt1.Clear()

        hlp0000SeVaTt = 0
        hlp0000SeVa = 0
        hlp0000SeVaTt1 = 0

        For i = 0 To vS3.ActiveSheet.RowCount - 1

            Array_hlp0000SeVaTt.Add(getData(vS3, getColumIndex(vS3, "KEY_ContractID"), i))
            Array_hlp0000SeVaTt1.Add(getData(vS3, getColumIndex(vS3, "KEY_MaterialCode"), i))

            isudCHK = True
        Next

        Me.Dispose()

    End Sub
    Private Sub vS2_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS2.CellDoubleClick

        Dim colorname As String

        hlp0000SeVaTt = getData(vS2, getColumIndex(vS2, "KEY_MaterialCode"), vS2.ActiveSheet.ActiveRowIndex)
        hlp0000SeVaTt1 = getData(vS2, getColumIndex(vS2, "KEY_ContractID"), vS2.ActiveSheet.ActiveRowIndex)
        colorname = getData(vS2, getColumIndex(vS2, "ColorName"), vS2.ActiveSheet.ActiveRowIndex)

        If READ_PFK7231(getData(vS2, getColumIndex(vS2, "KEY_MaterialCode"), vS2.ActiveSheet.ActiveRowIndex)) Then
            If vS3.ActiveSheet.RowCount >= 1 And getData(vS3, getColumIndex(vS3, "KEY_MaterialCode"), vS3.ActiveSheet.RowCount - 1) <> "" Then vS3.ActiveSheet.RowCount += 1
            setData(vS3, getColumIndex(vS3, "ContractID"), vS3.ActiveSheet.RowCount - 1, hlp0000SeVaTt1)
            setData(vS3, getColumIndex(vS3, "KEY_ContractID"), vS3.ActiveSheet.RowCount - 1, hlp0000SeVaTt1)
            setData(vS3, getColumIndex(vS3, "KEY_MaterialCode"), vS3.ActiveSheet.RowCount - 1, D7231.MaterialCode)
            setData(vS3, getColumIndex(vS3, "MaterialCode"), vS3.ActiveSheet.RowCount - 1, D7231.MaterialCode)
            setData(vS3, getColumIndex(vS3, "MaterialName"), vS3.ActiveSheet.RowCount - 1, D7231.MaterialName + " " + D7231.MaterialPName)

            setData(vS3, getColumIndex(vS3, "MaterialPName"), vS3.ActiveSheet.RowCount - 1, D7231.MaterialPName)
            setData(vS3, getColumIndex(vS3, "ColorName"), vS3.ActiveSheet.RowCount - 1, colorname)
            setData(vS3, getColumIndex(vS3, "Width"), vS3.ActiveSheet.RowCount - 1, D7231.Width)
            setData(vS3, getColumIndex(vS3, "Height"), vS3.ActiveSheet.RowCount - 1, D7231.Height)
            setData(vS3, getColumIndex(vS3, "SizeName"), vS3.ActiveSheet.RowCount - 1, D7231.SizeName)

            If READ_PFK7171(ListCode("UnitMaterial"), D7231.cdUnitMaterial) Then
                setData(vS3, getColumIndex(vS3, "cdUnitMaterialName"), vS3.ActiveSheet.RowCount - 1, D7171.BasicName)
            End If

            If READ_PFK7171(ListCode("UnitPacking"), D7231.cdUnitPacking) Then
                setData(vS3, getColumIndex(vS3, "cdUnitPackingName"), vS3.ActiveSheet.RowCount - 1, D7171.BasicName)
            End If


        End If

    End Sub
#End Region


    

End Class