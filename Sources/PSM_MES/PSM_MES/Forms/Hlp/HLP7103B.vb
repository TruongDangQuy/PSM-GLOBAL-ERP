Public Class HLP7103B

#Region "Variable"
    Private Dsu01 As Long
    Private W1_Head As Integer = 2
    Private wGCHK As String

    Private W7103 As T7103_AREA
    Private vschkbx As New FarPoint.Win.Spread.CellType.CheckBoxCellType
    Private WCHK As String
#End Region

#Region "Form_Load"
    Public Function Link_HLP7103B(KSEL As String, Optional CHK1 As String = "") As Boolean

        W7103.cdTypeCode = KSEL

        If READ_PFK7171(ListCode("TypeCode"), KSEL) Then
            txt_cdTypeCode.Data = D7171.BasicName
            txt_cdTypeCode.Code = D7171.BasicCode
            txt_cdTypeCode.Enabled = True
        End If

        If CHK1 <> "" Then WCHK = CHK1

        Me.ShowDialog()

        Link_HLP7103B = hlpCHK

        If hlpCHK = False Then Call D7109_CLEAR()

    End Function

    Private Sub HLP7103B_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        hlp0000SeVaTt1 = ""
        VS1.AllowRowMove = True

        Call DATA_SEARCH_HEAD_vS_Group()
        Call DATA_SEARCH_vs1()
    End Sub
#End Region

#Region "Methods"
    Public Function DATA_SEARCH_vs1() As Boolean
        DATA_SEARCH_vs1 = False
        Try

            DS1 = PrcDS("USP_HLP7103B_SEARCH_VS1", cn)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(VS1, DS1, "USP_HLP7103B_SEARCH_vs1", "vs1")
                VS1.ActiveSheet.RowCount = 0
                VS1.Enabled = True
                Exit Function
            End If
            SPR_PRO_NEW(VS1, DS1, "USP_HLP7103B_SEARCH_vs1", "vs1")

        Catch ex As Exception
            Call MsgBoxP("1", "DATA_SEARCH_vs1")
        End Try
    End Function

    Public Function DATA_SEARCH_HEAD_vS_Group() As Boolean
        DATA_SEARCH_HEAD_vS_Group = False

        Try
            DS1 = PrcDS("USP_HLP7103B_SEARCH_HEAD", cn, ListCode("ComponentType"))
            SPR_PRO_NEW(vS_Group, DS1, "USP_HLP7103B_SEARCH_HEAD", "vS_Group")
            vS_Group.VerticalScrollBarPolicy = ScrollBarPolicy.Never
            vS_Group.HorizontalScrollBarPolicy = ScrollBarPolicy.Never
            DS1 = Nothing
            DATA_SEARCH_HEAD_vS_Group = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function
#End Region

#Region "Events"
    Private Sub vS_Group_CellClick(sender As Object, e As CellClickEventArgs) Handles vS_Group.CellClick
        Try
            Dim cdComponentType As String

            cdComponentType = getData(vS_Group, getColumIndex(vS_Group, "BasicCode"), vS_Group.ActiveSheet.ActiveRowIndex)

            Call DATA_SEARCH_VS0(cdComponentType)

        Catch ex As Exception

        End Try
    End Sub
    Public Function DATA_SEARCH_VS0(Optional cdComponentType As String = "") As Boolean

        DATA_SEARCH_VS0 = False

        Try
            DS1 = PrcDS("USP_HLP7103B_SEARCH_VS0", cn, "*" & txt_TypeName.Data, txt_cdTypeCode.Code, CDComponentType)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS0, DS1, "USP_HLP7103B_SEARCH_VS0", "VS0")
                vS0.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS0, DS1, "USP_HLP7103B_SEARCH_VS0", "VS0")
            DATA_SEARCH_VS0 = True

        Catch ex As Exception

            Call MsgBoxP("DATA_SEARCH_VS0", vbCritical)
        End Try
    End Function
    Private Sub SelectLabelSearch1_Load(sender As Object, e As KeyEventArgs) Handles txt_TypeName.txtTextKeyDown
        If e.KeyCode = Keys.Enter Then DATA_SEARCH_VS0()
    End Sub
    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        hlp0000SeVaTt1 = ""
        hlpCHK = False
        D7103_CLEAR()
        Me.close()
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        DATA_SEARCH_VS0()
    End Sub

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Dim i As Integer

        hlp0000SeVaTt = 0
        hlp0000SeVa = 0
        hlp0000SeVaTt1 = 0

        Array_hlp0000SeVaTt.Clear()

        For i = 0 To VS1.ActiveSheet.RowCount - 1
            Array_hlp0000SeVaTt.Add(getData(VS1, getColumIndex(VS1, "KEY_TypeCode"), i))
        Next

        If Array_hlp0000SeVaTt.Count > 0 Then hlpCHK = True

        Me.Dispose()

    End Sub

    Private Sub VS0_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS0.CellDoubleClick

        hlp0000SeVaTt = getData(vS0, getColumIndex(vS0, "KEY_TypeCode"), vS0.ActiveSheet.ActiveRowIndex)

        If READ_PFK7103_TYPECODE(txt_cdTypeCode.Code, getData(vS0, getColumIndex(vS0, "KEY_TypeCode"), vS0.ActiveSheet.ActiveRowIndex)) Then
            If VS1.ActiveSheet.RowCount >= 1 And getData(VS1, getColumIndex(VS1, "KEY_TypeCode"), VS1.ActiveSheet.RowCount - 1) <> "" Then VS1.ActiveSheet.RowCount += 1
            setData(VS1, getColumIndex(VS1, "KEY_TypeCode"), VS1.ActiveSheet.RowCount - 1, D7103.TypeCode)

            setData(VS1, getColumIndex(VS1, "TypeName"), VS1.ActiveSheet.RowCount - 1, D7103.TypeName)

            If READ_PFK7171(ListCode("TypeCode"), D7103.cdTypeCode) Then
                setCell(VS1, getColumIndex(VS1, "cdTypeCode"), VS1.ActiveSheet.RowCount - 1, D7171.BasicCode)
                setData(VS1, getColumIndex(VS1, "cdTypeCodeName"), VS1.ActiveSheet.RowCount - 1, D7171.BasicName)
            End If

            If READ_PFK7171(ListCode("ComponentType"), D7103.cdComponentType) Then
                setCell(VS1, getColumIndex(VS1, "cdComponentType"), VS1.ActiveSheet.RowCount - 1, D7171.BasicCode)
                setData(VS1, getColumIndex(VS1, "cdComponentTypeName"), VS1.ActiveSheet.RowCount - 1, D7171.BasicName)
            End If
        End If



    End Sub

    Private Sub txt_Add_Click(sender As Object, e As EventArgs) Handles txt_Add.Click
        If ISUD7103A.Link_ISUD7103A(1, "0000", W7103.cdTypeCode, "000", "PFP71030") = False Then Exit Sub
        Call DATA_SEARCH_VS0()
    End Sub

    Private Sub vS0_KeyDown(sender As Object, e As KeyEventArgs) Handles vS0.KeyDown
        If e.KeyCode = Keys.Enter Then

            hlp0000SeVaTt = getData(vS0, getColumIndex(vS0, "KEY_TypeCode"), vS0.ActiveSheet.ActiveRowIndex)

            If READ_PFK7103_TYPECODE(txt_cdTypeCode.Code, getData(vS0, getColumIndex(vS0, "KEY_TypeCode"), vS0.ActiveSheet.ActiveRowIndex)) Then
                If VS1.ActiveSheet.RowCount >= 1 And getData(VS1, getColumIndex(VS1, "KEY_TypeCode"), VS1.ActiveSheet.RowCount - 1) <> "" Then VS1.ActiveSheet.RowCount += 1
                setData(VS1, getColumIndex(VS1, "KEY_TypeCode"), VS1.ActiveSheet.RowCount - 1, D7103.TypeCode)

                setData(VS1, getColumIndex(VS1, "TypeName"), VS1.ActiveSheet.RowCount - 1, D7103.TypeName)

                If READ_PFK7171(ListCode("TypeCode"), D7103.cdTypeCode) Then
                    setCell(VS1, getColumIndex(VS1, "cdTypeCode"), VS1.ActiveSheet.RowCount - 1, D7171.BasicCode)
                    setData(VS1, getColumIndex(VS1, "cdTypeCodeName"), VS1.ActiveSheet.RowCount - 1, D7171.BasicName)
                End If

                If READ_PFK7171(ListCode("ComponentType"), D7103.cdComponentType) Then
                    setCell(VS1, getColumIndex(VS1, "cdComponentType"), VS1.ActiveSheet.RowCount - 1, D7171.BasicCode)
                    setData(VS1, getColumIndex(VS1, "cdComponentTypeName"), VS1.ActiveSheet.RowCount - 1, D7171.BasicName)
                End If
            End If

        End If
    End Sub

    Private Sub VS1_CellClick(sender As Object, e As CellClickEventArgs) Handles VS1.CellClick

    End Sub

    Private Sub VS1_KeyDown(sender As Object, e As KeyEventArgs) Handles VS1.KeyDown
        If e.KeyCode = Keys.Delete Then
            SPR_DEL(VS1, VS1.ActiveSheet.ActiveColumnIndex, VS1.ActiveSheet.ActiveRowIndex)
        End If
    End Sub
#End Region
    
End Class