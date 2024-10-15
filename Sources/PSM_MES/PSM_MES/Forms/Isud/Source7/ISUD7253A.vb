Public Class ISUD7253A

#Region "Variable"
    Protected prg As E_PRG
    Private Dsu01 As Long     'Data Su
    Private Dsu02 As Long     'Data Su
    Private Dsu03 As Long     'Data Su
    Private formA As Boolean
    Private L7253 As T7253_AREA

#End Region

#Region "Formload"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Select Case wJOB
            Case 0, 1
                Me.KeyPreview = True
                Call FORM_INIT()
                Call DATA_INIT()
                Call DATA_SEARCH01()
            Case Else

                txt_Month.Value = CIntp(L7253.MonthMaterial)
                txt_Month.Maximum = 12
                txt_Month.Minimum = 1
                txt_Year.Value = CIntp(L7253.YearMaterial)
                txt_Year.Maximum = txt_Year.Value + 10
                txt_Year.Minimum = txt_Year.Value - 10

                txt_MonthF.Value = CIntp(L7253.MonthMaterial)
                txt_MonthF.Maximum = 12
                txt_MonthF.Minimum = 1
                txt_YearF.Value = CIntp(L7253.YearMaterial)
                txt_YearF.Maximum = txt_Year.Value + 10
                txt_YearF.Minimum = txt_Year.Value - 10
                txt_CustomerCode.Code = L7253.CustomerCode

                If READ_PFK7101(L7253.CustomerCode) = True Then
                    txt_CustomerCode.Data = D7101.CustomerName
                End If

                cmd_SEARCH.PerformClick()

        End Select
     
    End Sub
    Public Function Link_ISUD7253A(job As Integer, YearMaterial As String, MonthMaterial As String, CustomerCode As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = Tag
        D7253.YearMaterial = YearMaterial
        D7253.MonthMaterial = MonthMaterial
        D7253.CustomerCode = CustomerCode

        wJOB = job : L7253 = D7253

        Link_ISUD7253A = False
        Try

            Select Case job
                Case 1
                Case Else
                   
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD7253A = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))
        End Try


    End Function
    Private Sub Me_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub

    Private Sub FORM_INIT()
        btn_Print.Visible = True

    End Sub
    Private Sub DATA_INIT()
        L7253 = D7253
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

        DS1 = PrcDS("USP_ISUD7253A_SEARCH_vS1", cn, txt_Year.Value.ToString, txt_Month.Value.ToString("00"), txt_CustomerCode.Code,
                    Const_LargeGroupMaterial, _
                    Const_SemiGroupMaterial, _
                    Const_UnitMaterial, _
                    Const_UnitPacking, _
                    Const_UnitPrice)
        If GetDsRc(DS1) = 0 Then
            DS2 = PrcDS("USP_ISUD7253A_SEARCH_vS1_INSERT", cn, txt_Year.Value.ToString, txt_Month.Value.ToString("00"), txt_CustomerCode.Code,
                    Const_LargeGroupMaterial, _
                    Const_SemiGroupMaterial, _
                    Const_UnitMaterial, _
                    Const_UnitPacking, _
                    Const_UnitPrice)
            Vs1.Enabled = True
            SPR_SET(Vs1, , , , OperationMode.Normal)
            SPR_PRO(Vs1, DS2, "USP_ISUD7253A_SEARCH_vS1", "Vs1")
            SPR_INSERT(Vs1)
            DATA_SEARCH01 = True
            Exit Function
        End If
        SPR_SET(Vs1, , , , OperationMode.Normal)
        SPR_PRO(Vs1, DS1, "USP_ISUD7253A_SEARCH_vS1", "Vs1")
        Me.Show()
        Vs1.Enabled = True
        DATA_SEARCH01 = True


    End Function
    'Insert new
    Private Function DATA_SEARCH02() As Boolean
        DATA_SEARCH02 = False

        Vs1.Enabled = False


        DS1 = PrcDS("USP_ISUD7253A_SEARCH_vS1", cn, txt_YearF.Value.ToString, txt_MonthF.Value.ToString("00"))
        If GetDsRc(DS1) = 0 Then
            Vs1.Enabled = True
            Vs1.ActiveSheet.RowCount = 0
            Exit Function
        End If
        SPR_SET(Vs1, , , , OperationMode.Normal)
        SPR_PRO(Vs1, DS1, "USP_ISUD7253A_SEARCH_vS1", "Vs1")

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
            If txt_Year.Value * 100 + txt_Month.Value > txt_YearF.Value * 100 + txt_MonthF.Value Then Vs1.ActiveSheet.RowCount = 0 : btn_Print.Visible = True : cmd_OK.Visible = False : Exit Sub
            Dim SQL As String
            Dim cmd As New SqlClient.SqlCommand
            SQL = "SELECT TOP 1 * FROM PFK7253 WHERE K7253_YearMaterial = '" + txt_Year.Value.ToString("0000") + "'"
            SQL = SQL + " AND K7253_MonthMaterial = '" + txt_Month.Value.ToString("00") + "'"
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            If rd.HasRows = False Then
                txt_YearF.Value = txt_Year.Value
                txt_MonthF.Value = txt_Month.Value
                rd.Close()
                btn_Print.Visible = True
                cmd_OK.Visible = False
                Exit Sub
            End If
            rd.Close()

            SQL = "SELECT TOP 1 * FROM PFK7253 WHERE K7253_YearMaterial = '" + txt_YearF.Value.ToString("0000") + "'"
            SQL = SQL + " AND K7253_MonthMaterial = '" + txt_MonthF.Value.ToString("00") + "'"
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            If rd.HasRows = False Then
                btn_Print.Visible = True
                cmd_OK.Visible = False
            Else
                btn_Print.Visible = True
                cmd_OK.Visible = True
                cmd_OK.Text = "DELETE"
            End If
            rd.Close()
            cmd_OK.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))

        End If
    End Sub

#End Region

    Private Sub btn_Print_Click(sender As Object, e As EventArgs) Handles btn_Print.Click
        Try
            Dim i As Integer
            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If txt_CustomerCode.Code <> "" Then
                    If READ_PFK7253(txt_YearF.Value.ToString("0000"), txt_MonthF.Value.ToString("00"), txt_CustomerCode.Code, getData(Vs1, getColumIndex(Vs1, "MaterialCode"), i)) = False Then
                        L7253.YearMaterial = txt_YearF.Value.ToString("0000")
                        L7253.MonthMaterial = txt_MonthF.Value.ToString("00")
                        L7253.MaterialCode = getData(Vs1, getColumIndex(Vs1, "MaterialCode"), i)

                        L7253.CustomerCode = txt_CustomerCode.Code
                        L7253.PriceSalesUsd = getData(Vs1, getColumIndex(Vs1, "PriceSalesUsd"), i)
                        L7253.PriceSalesVND = getData(Vs1, getColumIndex(Vs1, "PriceSalesVND"), i)

                        L7253.Remark = getData(Vs1, getColumIndex(Vs1, "Remark"), i)
                        WRITE_PFK7253(L7253)
                    Else
                        L7253.YearMaterial = txt_YearF.Value.ToString("0000")
                        L7253.MonthMaterial = txt_MonthF.Value.ToString("00")
                        L7253.MaterialCode = getData(Vs1, getColumIndex(Vs1, "MaterialCode"), i)

                        L7253.PriceSalesUsd = getData(Vs1, getColumIndex(Vs1, "PriceSalesUsd"), i)
                        L7253.PriceSalesVND = getData(Vs1, getColumIndex(Vs1, "PriceSalesVND"), i)

                        L7253.CustomerCode = txt_CustomerCode.Code
                        L7253.Remark = getData(Vs1, getColumIndex(Vs1, "Remark"), i)
                        REWRITE_PFK7253(L7253)
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
                If READ_PFK7253(getData(Vs1, getColumIndex(Vs1, "KEY_YearMaterial"), i), getData(Vs1, getColumIndex(Vs1, "KEY_MonthMaterial"), i), txt_CustomerCode.Code, getData(Vs1, getColumIndex(Vs1, "Key_MaterialCode"), i)) = True Then
                    L7253 = D7253
                    DELETE_PFK7253(L7253)
                End If
            Next
            cmd_SEARCH.PerformClick()
        ElseIf cmd_OK.Text = "SAVE" Then
            cmd_SEARCH.Visible = True
            btn_Print.Visible = True
            cmd_OK.Visible = False
        End If
    End Sub

    Private Sub txt_Year_ValueChanged(sender As Object, e As EventArgs) Handles txt_Year.ValueChanged, txt_Month.ValueChanged
        cmd_SEARCH.Visible = True
        btn_Print.Visible = True
        cmd_OK.Visible = False
    End Sub
End Class