Public Class ISUD7251A

#Region "Variable"
    Protected prg As E_PRG
    Private Dsu01 As Long     'Data Su
    Private Dsu02 As Long     'Data Su
    Private Dsu03 As Long     'Data Su
    Private Form_Close As Boolean
    Private L7251 As T7251_AREA

#End Region

#Region "Formload"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True
        Call FORM_INIT()
        Call DATA_INIT()
    End Sub

    Private Sub Me_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub

    Private Sub FORM_INIT()
        btn_Insert.Visible = True

    End Sub
    Private Sub DATA_INIT()
        L7251 = D7251
        txt_MonthF.Value = CInt(Strings.Mid(System_Date_8(), 5, 2))
        txt_MonthF.Maximum = 12
        txt_MonthF.Minimum = 1
        txt_YearF.Value = CInt(Strings.Mid(System_Date_8(), 1, 4))
        txt_YearF.Maximum = txt_Year.Value + 10
        txt_YearF.Minimum = txt_Year.Value - 10

        If txt_MonthF.Value = 1 Then
            txt_Month.Value = 12
            txt_Month.Maximum = 12
            txt_Month.Minimum = 1
            txt_Year.Value = txt_YearF.Value - 1
            txt_Year.Maximum = txt_Year.Value + 10
            txt_Year.Minimum = txt_Year.Value - 10
        Else
            txt_Month.Value = txt_MonthF.Value - 1
            txt_Month.Maximum = 12
            txt_Month.Minimum = 1
            txt_Year.Value = txt_YearF.Value
            txt_Year.Maximum = txt_Year.Value + 10
            txt_Year.Minimum = txt_Year.Value - 10
        End If


    End Sub

#End Region

#Region "Link_ISUD"
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

    Private Sub MAIN_JOB01()
        'If getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
        'If ISUD7604A.Link_ISUD7604A(1, getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex), "001") = False Then Exit Sub

        'DATA_SEARCH01()
    End Sub

    Private Sub MAIN_JOB02()
        'If getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        'If ISUD7604A.Link_ISUD7604A(3, getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex), getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex)) = False Then Exit Sub

        'DATA_SEARCH01()
    End Sub

    Private Sub MAIN_JOB03()
        If getData(Vs1, 13, Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
    End Sub

    Private Sub MAIN_JOB04()
        If getData(Vs1, 13, Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
    End Sub

    Private Sub MAIN_JOB05()
        If getData(Vs1, 12, Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
    End Sub

#End Region

#Region "PFP_SEARCH"
    Private Function DATA_SEARCH01() As Boolean


        DATA_SEARCH01 = False
        Vs1.Enabled = False

        DS1 = PrcDS("USP_ISUD7251A_SEARCH_vS1", cn, txt_Year.Value.ToString, txt_Month.Value.ToString("00"), _
                    Const_LargeGroupMaterial, _
                    Const_SemiGroupMaterial, _
                    Const_UnitMaterial, _
                    Const_UnitPacking, _
                    Const_UnitPrice)

        If GetDsRc(DS1) = 0 Then
            DS2 = PrcDS("USP_ISUD7251A_SEARCH_vS1_INSERT", cn, txt_Year.Value.ToString, txt_Month.Value.ToString("00"), _
                    Const_LargeGroupMaterial, _
                    Const_SemiGroupMaterial, _
                    Const_UnitMaterial, _
                    Const_UnitPacking, _
                    Const_UnitPrice)
            Vs1.Enabled = True
            SPR_SET(Vs1, , , , OperationMode.Normal)
            SPR_PRO(Vs1, DS2, "USP_ISUD7251A_SEARCH_vS1", "Vs1")
            SPR_INSERT(Vs1)
            DATA_SEARCH01 = True
            Exit Function
        End If
        SPR_SET(Vs1, , , , OperationMode.Normal)
        SPR_PRO(Vs1, DS1, "USP_ISUD7251A_SEARCH_vS1", "Vs1")
        Me.Show()
        Vs1.Enabled = True
        DATA_SEARCH01 = True


    End Function
    'Insert new
    Private Function DATA_SEARCH02() As Boolean
        DATA_SEARCH02 = False

        Vs1.Enabled = False


        DS1 = PrcDS("USP_ISUD7251A_SEARCH_vS1", cn, txt_YearF.Value.ToString, txt_MonthF.Value.ToString("00"))
        If GetDsRc(DS1) = 0 Then
            Vs1.Enabled = True
            Vs1.ActiveSheet.RowCount = 0
            Exit Function
        End If
        SPR_SET(Vs1, , , , OperationMode.Normal)
        SPR_PRO(Vs1, DS1, "USP_ISUD7251A_SEARCH_vS1", "Vs1")

        Vs1.Enabled = True
        DATA_SEARCH02 = True
    End Function

#End Region

#Region "EVENT"
    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs)
        Vs1.ActiveSheet.ActiveRowIndex = e.Row

        If e.Row < 0 Then Exit Sub
        If getData(Vs1, 1, e.Row) = "" Then Exit Sub
        Vs1.Enabled = False
        Vs1.Enabled = True
    End Sub

    'GOTFOCUS

    Private Sub Vs1_GotFocus(sender As Object, e As EventArgs)

    End Sub

    'LOSTFOCUS

    Private Sub Vs1_KeyUp(sender As Object, e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Down, Keys.Up, Keys.PageDown, Keys.PageUp
                Call vS1_Click(Vs1.ActiveSheet.ActiveColumnIndex, Vs1.ActiveSheet.ActiveRowIndex)
        End Select
    End Sub

    Private Sub Vs1_LostFocus(sender As Object, e As EventArgs)

    End Sub

    Private Sub vS1_Click(ByVal Col As Long, ByVal Row As Long)
        If Row < 0 Then Exit Sub
        If getData(Vs1, 12, Row) = "" Then Exit Sub

    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        If DATA_SEARCH01() = True Then
            If txt_Year.Value * 100 + txt_Month.Value > txt_YearF.Value * 100 + txt_MonthF.Value Then Vs1.ActiveSheet.RowCount = 0 : btn_Insert.Visible = True : cmd_OK.Visible = False : Exit Sub
            Dim SQL As String
            Dim cmd As New SqlClient.SqlCommand
            SQL = "SELECT TOP 1 * FROM PFK7251 WHERE K7251_YearMaterial = '" + txt_Year.Value.ToString("0000") + "'"
            SQL = SQL + " AND K7251_MonthMaterial = '" + txt_Month.Value.ToString("00") + "'"
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            If rd.HasRows = False Then
                txt_YearF.Value = txt_Year.Value
                txt_MonthF.Value = txt_Month.Value
                rd.Close()
                btn_Insert.Visible = True
                cmd_OK.Visible = False
                Exit Sub
            End If
            rd.Close()

            SQL = "SELECT TOP 1 * FROM PFK7251 WHERE K7251_YearMaterial = '" + txt_YearF.Value.ToString("0000") + "'"
            SQL = SQL + " AND K7251_MonthMaterial = '" + txt_MonthF.Value.ToString("00") + "'"
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            If rd.HasRows = False Then
                btn_Insert.Visible = True
                cmd_OK.Visible = False
            Else
                btn_Insert.Visible = True
                cmd_OK.Visible = True
                cmd_OK.Text = "DELETE"
            End If
            rd.Close()
            cmd_OK.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))

        End If
    End Sub

#End Region

    Private Sub btn_Print_Click(sender As Object, e As EventArgs) Handles btn_Insert.Click
        Try
            Dim i As Integer
            Dim tmpExchange As Double

            SQL = "SELECT TOP 1 * FROM PFK7199 WHERE K7199_DateExchange <= '" + txt_YearF.Value.ToString("0000") + txt_MonthF.Value.ToString("00") + "31" + "'"
            SQL = SQL + " ORDER BY K7199_DateExchange DESC "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then
                tmpExchange = 0
            Else
                tmpExchange = rd!K7199_VND
            End If

            rd.Close()

            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If getData(Vs1, getColumIndex(Vs1, "MaterialCode"), i) <> "" Then
                    If READ_PFK7231(getData(Vs1, getColumIndex(Vs1, "MaterialCode"), i)) = True Then
                        If READ_PFK7251(txt_YearF.Value.ToString("0000"), txt_MonthF.Value.ToString("00"), getData(Vs1, getColumIndex(Vs1, "MaterialCode"), i)) = False Then
                            L7251.YearMaterial = txt_YearF.Value.ToString("0000")
                            L7251.MonthMaterial = txt_MonthF.Value.ToString("00")
                            L7251.MaterialCode = getData(Vs1, getColumIndex(Vs1, "MaterialCode"), i)
                            If READ_PFK7251(txt_Year.Value.ToString("0000"), txt_Month.Value.ToString("00"), getData(Vs1, getColumIndex(Vs1, "MaterialCode"), i)) = False Then

                                L7251.PriceMaterialUsd = D7231.PriceUSD

                                If D7231.cdUnitPrice = "001" Then
                                    L7251.PriceMaterialVND = D7231.PriceMaterial
                                Else
                                    L7251.PriceMaterialVND = L7251.PriceMaterialUsd * CDbl(tmpExchange)
                                End If

                            Else
                                L7251.PriceMaterialUsd = getData(Vs1, getColumIndex(Vs1, "PriceMaterialUsd"), i)
                                L7251.PriceMaterialVND = getData(Vs1, getColumIndex(Vs1, "PriceMaterialVND"), i)
                            End If

                            WRITE_PFK7251(L7251)
                        Else
                            L7251.YearMaterial = txt_YearF.Value.ToString("0000")
                            L7251.MonthMaterial = txt_MonthF.Value.ToString("00")
                            L7251.MaterialCode = getData(Vs1, getColumIndex(Vs1, "MaterialCode"), i)

                            L7251.PriceMaterialUsd = getData(Vs1, getColumIndex(Vs1, "PriceMaterialUsd"), i)
                            L7251.PriceMaterialVND = getData(Vs1, getColumIndex(Vs1, "PriceMaterialVND"), i)

                            REWRITE_PFK7251(L7251)
                        End If
                    End If
                End If
            Next
            txt_Year.Value = txt_YearF.Value
            txt_Month.Value = txt_MonthF.Value
            cmd_SEARCH.PerformClick()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Dim i As Integer
        If cmd_OK.Text = "DELETE" Then
            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If READ_PFK7251(getData(Vs1, getColumIndex(Vs1, "KEY_YearMaterial"), i), getData(Vs1, getColumIndex(Vs1, "KEY_MonthMaterial"), i), getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), i)) = True Then
                    L7251 = D7251
                    DELETE_PFK7251(L7251)
                End If
            Next
            cmd_SEARCH.PerformClick()
        ElseIf cmd_OK.Text = "SAVE" Then
            cmd_SEARCH.Visible = True
            btn_Insert.Visible = True
            cmd_OK.Visible = False
        End If
    End Sub

    Private Sub txt_Year_ValueChanged(sender As Object, e As EventArgs) Handles txt_Year.ValueChanged, txt_Month.ValueChanged
        cmd_SEARCH.Visible = True
        btn_Insert.Visible = True
        cmd_OK.Visible = False
    End Sub
End Class