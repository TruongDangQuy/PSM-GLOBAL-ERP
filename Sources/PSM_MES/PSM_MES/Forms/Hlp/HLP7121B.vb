Public Class HLP7121B

#Region "Variable"
    Private Dsu01 As Long
    Private W1_Head As Integer = 2
    Private wGCHK As String

    Private W7121 As T7121_AREA
    Private vschkbx As New FarPoint.Win.Spread.CellType.CheckBoxCellType
    Private WCHK As String
#End Region

#Region "Form_Load"
    Public Function Link_HLP7121B(Optional Value As String = "") As Boolean
        If Value = "1" Then Value = ""

        txt_Name.Data = Value

        Me.ShowDialog()

        Link_HLP7121B = hlpCHK

        If hlpCHK = False Then Call D7109_CLEAR()

    End Function

    Private Sub HLP7121B_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        hlp0000SeVaTt1 = ""

        Call DATA_SEARCH_VS02()
        If txt_Name.Data = "" Then Setfocus(txt_Name) Else Call DATA_SEARCH_VS01()

    End Sub
#End Region

#Region "Methods"
    Public Overridable Function DATA_SEARCH_VS01() As Boolean
        DATA_SEARCH_VS01 = False
        vS2.AllowRowMove = True

        Try
            DS1 = PrcDS("USP_HLP7121B_SEARCH_vS1", cn)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(VS1, DS1, "USP_HLP7121B_SEARCH_vS1", "Vs1")
                VS1.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(VS1, DS1, "USP_HLP7121B_SEARCH_vS1", "Vs1")
            DATA_SEARCH_VS01 = True

            Me.Show()
            Application.DoEvents()
            VS1.Focus()
            VS1.Select()

        Catch ex As Exception

            Call MsgBoxP("DATA_SEARCH_VS01", vbCritical)
        End Try
    End Function

    Public Function DATA_SEARCH_VS02() As Boolean
        DATA_SEARCH_VS02 = False

        Dim BasicCode As String
        BasicCode = getData(VS1, getColumIndex(VS1, "BasicCode"), VS1.ActiveSheet.ActiveRowIndex)

        Try

            DS1 = PrcDS("USP_HLP7121B_SEARCH_vS2", cn, BasicCode, "*" & txt_Name.Data)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS2, DS1, "USP_HLP7121B_SEARCH_vS2", "Vs2")
                vS2.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS2, DS1, "USP_HLP7121B_SEARCH_vS2", "Vs2")

        Catch ex As Exception
            Call MsgBoxP("1", "DATA_SEARCH_VS02")
        End Try
    End Function

    Public Function DATA_SEARCH_VS03() As Boolean
        DATA_SEARCH_VS03 = False

        Try
            DS1 = PrcDS("USP_HLP7121B_SEARCH_vS3", cn)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS3, DS1, "USP_HLP7121B_SEARCH_vS3", "vS3")
                vS3.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS3, DS1, "USP_HLP7121B_SEARCH_vS3", "vS3")

        Catch ex As Exception
            Call MsgBoxP("1", "DATA_SEARCH_VS03")
        End Try
    End Function
#End Region

#Region "Events"
    Private Sub SelectLabelSearch1_Load(sender As Object, e As KeyEventArgs) Handles txt_Name.txtTextKeyDown
        If e.KeyCode = Keys.Enter Then DATA_SEARCH_VS01()
    End Sub
    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        hlp0000SeVaTt = ""
        hlp0000SeVa = ""
        hlp0000SeVaTt1 = ""
        Array_hlp0000SeVaTt.Clear()

        hlpCHK = False
        Me.Dispose()
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        Call DATA_SEARCH_VS01()
    End Sub


    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Dim i As Integer

        hlp0000SeVaTt = 0
        hlp0000SeVa = 0
        hlp0000SeVaTt1 = 0

        For i = 0 To vS2.ActiveSheet.RowCount - 1
            Array_hlp0000SeVaTt.Add(getData(vS2, getColumIndex(vS2, "Key_ColorCode"), i))
        Next

        Me.Dispose()
    End Sub

    Private Sub vS2_KeyDown(sender As Object, e As KeyEventArgs) Handles vS2.KeyDown
        If e.KeyCode = Keys.Delete Then
            SPR_DEL(vS2, vS2.ActiveSheet.ActiveColumnIndex, vS2.ActiveSheet.ActiveRowIndex)
        End If
    End Sub

    Private Sub VS1_CellClick(sender As Object, e As CellClickEventArgs) Handles VS1.CellClick
        If e.Row < 0 Then Exit Sub
        VS1.ActiveSheet.ActiveRowIndex = e.Row
        VS1.ActiveSheet.ActiveColumnIndex = e.Column

        If e.ColumnHeader = True Then Exit Sub



        Call DATA_SEARCH_VS02()
    End Sub

    Private Sub vs2_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS2.CellDoubleClick
        hlp0000SeVaTt = getData(vS2, getColumIndex(vS2, "Key_ColorCode"), vS2.ActiveSheet.ActiveRowIndex)

        If READ_PFK7121(getData(vS2, getColumIndex(vS2, "Key_ColorCode"), vS2.ActiveSheet.ActiveRowIndex)) Then
            If vS3.ActiveSheet.RowCount = 1 Then
                setData(vS3, getColumIndex(vS3, "Key_ColorCode"), vS3.ActiveSheet.RowCount - 1, D7121.ColorCode)
                setData(vS3, getColumIndex(vS3, "ColorCode"), vS3.ActiveSheet.RowCount - 1, D7121.ColorCode)
                setData(vS3, getColumIndex(vS3, "ColorName"), vS3.ActiveSheet.RowCount - 1, D7121.ColorName)
                vS3.ActiveSheet.RowCount += 1
                Exit Sub
            End If

            If vS3.ActiveSheet.RowCount >= 1 And getData(vS3, getColumIndex(vS3, "Key_ColorCode"), vS3.ActiveSheet.RowCount - 1) <> "" Then vS3.ActiveSheet.RowCount += 1
            setData(vS3, getColumIndex(vS3, "Key_ColorCode"), vS3.ActiveSheet.RowCount - 1, D7121.ColorCode)
            setData(vS3, getColumIndex(vS3, "ColorCode"), vS3.ActiveSheet.RowCount - 1, D7121.ColorCode)
            setData(vS3, getColumIndex(vS3, "ColorName"), vS3.ActiveSheet.RowCount - 1, D7121.ColorName)
        End If

    End Sub

    Private Sub vs3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles vS3.KeyPress
        Select Case e.KeyChar
            Case ChrW(Keys.Enter) : cmd_OK.PerformClick()
            Case ChrW(Keys.Escape) : cmd_Cancel.PerformClick()
        End Select
    End Sub

    Private Sub txt_Add_Click(sender As Object, e As EventArgs) Handles txt_Add.Click

    End Sub
#End Region

End Class