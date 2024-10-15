Public Class HLP3011F

#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Protected prg As E_PRG

    Private W3011 As New T3011_AREA
    Private L3011 As New T3011_AREA

    Private Form_Close As Boolean
    Private L_CustomerCode As String
    Private L_cdSeason As String
    Private L_Line As String
    Private L_cdLargeGroupMaterial As String
    Private L_cdSemiGroupMaterial As String
    Private L_checkSample As String

#End Region

#Region "Form_load"
    Friend Function Link_HLP3011Material(cdSeason As String, CustomerCode As String, _Line As String, _cdLargeGroupMaterial As String, _cdSemiGroupMaterial As String, _checkSample As String) As Boolean
        Link_HLP3011Material = False
        txt_cdSeason.Code = cdSeason
        txt_CustomerCode.Code = CustomerCode

        L_CustomerCode = CustomerCode
        L_cdSeason = cdSeason
        L_Line = _Line
        L_cdLargeGroupMaterial = _cdLargeGroupMaterial
        L_cdSemiGroupMaterial = _cdSemiGroupMaterial
        L_checkSample = _checkSample

        Try
            Me.ShowDialog()

            Link_HLP3011Material = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Link_HLP3011Material"))
        End Try


    End Function

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.KeyPreview = True

        Call FORM_INIT()

        Call DATA_INIT()

        Call DATA_SEARCH_VS1()
    End Sub
    Private Sub HLP3011F_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub
    Overrides Sub Function_Event(PressKey As Integer)
        Try

        Catch ex As Exception

        End Try
    End Sub
    Private Sub FORM_INIT()
        chk_FSEL.CheckState = 1
        chk_FSEL.BackColor = clrCheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("CLOSE")
        ssp_WHERE.Visible = True

        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub DATA_INIT()
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""

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
    Private Sub vS1_GotFocus(sender As Object, e As EventArgs) Handles vS2.GotFocus
        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False

    End Sub
#End Region

#Region "Function"

#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS2_COLUMN(MPO As String) As Boolean
        DATA_SEARCH_VS2_COLUMN = False

        VS2.Enabled = False
        Dim SCol As Integer
        Dim Value() As String

        DS1 = PrcDSVN("USP_HLP3011F_SEARCH_VS2_COLUMN", cn, MPO)

        If GetDsRc(DS1) = 0 Or MPO = "" Then
            vS2.Enabled = True
            SPR_PRO_NEW(vS2, DS1, "USP_HLP3011F_SEARCH_VS2_COLUMN", "vS2")
            Exit Function
        End If
        vS2.ActiveSheet.ColumnHeader.RowCount = 0

        SPR_PRO_NEW_NO_PFK9911(vS2, DS1, "USP_HLP3011F_SEARCH_VS2_COLUMN", "VS2")
        SCol = getColumIndex(vS2, "cdUnitMaterialName") + 1

        SPR_NUMBERCOLUMN(vS2, 0, SCol, GetDsCc(DS1) - 1)
        SPR_TOTALHEAD(vS2, SCol, GetDsCc(DS1) - 1)
        SPR_WIDTHCOLRANGE(vS2, 100, SCol, GetDsCc(DS1) - 1)

        vS2.ActiveSheet.ColumnHeader.RowCount += 5

        For i As Integer = 0 To SCol - 1
            vS2.ActiveSheet.ColumnHeader.Cells(0, i).RowSpan = 6
        Next


        For i As Integer = SCol To GetDsCc(DS1) - 1
            Value = vS2.ActiveSheet.ColumnHeader.Columns(i).Label.Split("!")
            If Value.Length = 2 Then
                If READ_PFK1311(Value(0)) Then
                    Call READ_PFK7101(D1311.CustomerCode)
                    setDataCH(vS2, i, 1, D7101.CustomerName)
                End If

                If READ_PFK1312(Value(0), Value(1)) Then
                    setDataCH(vS2, i, 0, D1312.OrderNo + Chr(13) + Chr(9) + D1312.SpecNoSeq)

                    setDataCH(vS2, i, 4, D1312.QtyOrder)
                    setDataCH(vS2, i, 5, D1312.SizeRange)
                End If
            End If
        Next

        SPR_TEXTBOXWARP(vS2, getColumIndex(vS2, "MaterialName"))

        DATA_SEARCH_VS2_COLUMN = True

        vS2.Enabled = True
    End Function

    Private Function DATA_SEARCH_VS2(MPO As String) As Boolean

        DATA_SEARCH_VS2 = False

        vS2.Enabled = False

        DS1 = PrcDSVN("USP_HLP3011F_SEARCH_VS2", cn, MPO)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS2, DS1, "USP_HLP3011F_SEARCH_VS2", "VS2")
            vS2.Enabled = True

            Exit Function
        End If

        SPR_PRO_NEW(vS2, DS1, "USP_HLP3011F_SEARCH_VS2", "VS2")
        DATA_SEARCH_VS2 = True

        vS2.Enabled = True
    End Function

    Private Function DATA_SEARCH_VS1(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS1 = False

        VS1.Enabled = False

        DS1 = PrcDSVN("USP_HLP3011F_SEARCH_VS1", cn, txt_cdSeason.Code, txt_CustomerCode.Code, L_checkSample)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(VS1, DS1, "USP_HLP3011F_SEARCH_VS1", "VS1")
            vS1.Enabled = True

            Exit Function
        End If

        SPR_PRO_NEW(vS1, DS1, "USP_HLP3011F_SEARCH_VS1", "VS1")
        DATA_SEARCH_VS1 = True

        vS1.Enabled = True
    End Function

    Private Function LINE_MOVE_DISPLAY01() As Boolean
        LINE_MOVE_DISPLAY01 = False

    End Function
    Private Function CustomerPurchasing_CHK() As String
        CustomerPurchasing_CHK = "1"
        Return CustomerPurchasing_CHK
    End Function
#End Region

#Region "Event"


    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False

        Call DATA_SEARCH_VS1()
    End Sub

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Try
            Dim MPO As String
            MPO = getData(vS1, getColumIndex(vS1, "KEY_PRNo"), vS1.ActiveSheet.ActiveRowIndex)

            DS2 = Nothing
            DS2 = PrcDS("USP_ISUD3011A_SEARCH_VS2_INSERT_AUTO_CHECK", cn, L_cdSeason, L_CustomerCode, L_Line, L_cdLargeGroupMaterial, L_cdSemiGroupMaterial, L_checkSample)

            If GetDsRc(DS2) > 0 Then
                If ISUD7231R.Link_ISUD7231R(3, L_cdSeason, L_CustomerCode, L_Line, L_cdLargeGroupMaterial, L_cdSemiGroupMaterial, L_checkSample) = False Then Exit Sub
            End If

            If READ_PFK3011_1(MPO) Then
                If ISUD3011A.Link_ISUD3011A_AUTO(5, L_cdSeason, L_CustomerCode, L_Line, L_cdLargeGroupMaterial, L_cdSemiGroupMaterial, L_checkSample, D3011.PRNo, Me.Name) = False Then Exit Sub
            End If


        Catch ex As Exception
            MsgBoxP("cmd_OK_Click!", vbCritical)
        End Try
    End Sub

    Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        isudCHK = False
        Me.Dispose()
    End Sub

    Private Sub vS1_CellClick(sender As Object, e As CellClickEventArgs) Handles vS1.CellClick
        Dim MPO As String
        MPO = getData(sender, getColumIndex(vS1, "KEY_PRNo"), e.Row)

        If chk_Column.Checked = False Then Call DATA_SEARCH_VS2(MPO)
        If chk_Column.Checked = True Then Call DATA_SEARCH_VS2_COLUMN(MPO)

    End Sub
#End Region

End Class