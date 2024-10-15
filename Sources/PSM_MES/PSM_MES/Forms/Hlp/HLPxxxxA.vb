Public Class HLPxxxxA

#Region "Variable"
    Protected prg As E_PRG
    Private Form_Close As Boolean
    Private _FormName As String
    Private _StoreName As String
    Private M9911 As T9911_AREA
    Private _ParaCount As Integer
    Private _ParaValue As String
    Private Value(20) As Object
#End Region

#Region "Formload"

    Friend Function Link_HLPxxxxA(Optional FormName As String = "ISUD8790A", Optional StoreName As String = "ISUD8790A") As Boolean
        Link_HLPxxxxA = False
        _FormName = FormName
        _StoreName = StoreName
        Try

            Me.ShowDialog()

            Link_HLPxxxxA = isudCHK
        Catch ex As Exception
            Call MsgBoxP("61", WordConv("PROCESSING"))
        End Try


    End Function

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        hlp0000SeVaTt1 = ""
        Me.KeyPreview = True
        Call DATA_INIT()
        Call DATA_SEARCH_PARAMETER()
    End Sub

    Private Sub PFP87761_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
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
    Private Sub DATA_INIT()
        chk_FSEL.CheckState = 1
        chk_FSEL.BackColor = clrCheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("CLOSE")
        ssp_WHERE.Visible = True
    End Sub
    Private Sub vS1_GotFocus(sender As Object, e As EventArgs) Handles Vs1.GotFocus
        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False
    End Sub
#End Region

#Region "PFP_SEARCH"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False

        Vs1.Enabled = False
        Dim i As Integer
        If _ParaCount = 0 Then Exit Function
        _ParaValue = ""
        For i = 0 To _ParaCount - 1
            If TypeOf Value(i) Is PeaceCheckbox Then
                _ParaValue = _ParaValue & Value(i).CheckState & ";"
            ElseIf TypeOf Value(i) Is SelectPeaceCombo Then
                _ParaValue = _ParaValue & (Value(i).Inselected + 1) & ";"
            Else
                _ParaValue = _ParaValue & Value(i).Data & ";"
            End If
        Next
        _ParaValue = Strings.Left(_ParaValue, _ParaValue.Length - 1)

        DS1 = PrcDS(_StoreName, cn, _ParaValue.Split(";"))
        If GetDsRc(DS1) = 0 Then
            Vs1.Enabled = True
            Vs1.ActiveSheet.RowCount = 0
            Exit Function
        End If
        'SPR_PRO_NEW(Vs1, DS1, _StoreName,  _FormName)
        'H change 2016/10/27

        SPR_PRO_NEW(Vs1, DS1, _StoreName, "VS1")
        Vs1.Enabled = True
        DATA_SEARCH01 = True
    End Function

    Private Sub DATA_SEARCH_PARAMETER()
        Dim ds As New DataSet
        Dim SQL As String
        Dim RS01 As DataRow = Nothing
        Dim i As Integer = 0
        Dim j As Integer = 0
        Try
            SQL = ""
            SQL = SQL + "SELECT A.name as ID "
            SQL = SQL + "      ,B.name AS IDNAME "
            SQL = SQL + "     ,C.name AS IDTYPE "
            SQL = SQL + "     ,  D.* "
            SQL = SQL + "      FROM [sys].[procedures] A   "
            SQL = SQL + "       INNER JOIN [sys].[parameters] B "
            SQL = SQL + "       ON A.object_id = B.object_id  "
            SQL = SQL + "       INNER JOIN [sys].[types] C"
            SQL = SQL + "       ON B.user_type_id = C.user_type_id"
            SQL = SQL + "       LEFT JOIN PFK9911 D    ON D.K9911_ItemName =  SUBSTRING(B.name,2,LEN(B.name)-1) "
            SQL = SQL + "      WHERE A.name = '" + _StoreName + "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            da.SelectCommand = cmd
            da.Fill(ds)
            i = 0
            If GetDsRc(ds) = 0 Then Exit Sub

            ReDim Value(20)
            Dim VName As String

            For Each RS01 In ds.Tables(0).Rows
                VName = ""
                VName = Mid(GetDsData(ds, i, "IDNAME"), 2)

                If READ_PFK9911(VName) = True Then

                    Select Case D9911.FormType
                        Case "0"
                            Value(i) = New SelectLabelText
                            Value(i).Name = "txt_" & VName
                            Value(i).ButtonTitle = D9911.ItemNameSimply
                            Value(i).TextboxFont = New Font("Tahoma", 12)
                            Value(i).TextMultiline = False
                            Value(i).Size = New Size(399, 26)

                        Case "1"
                            Value(i) = New SelectPeaceCalSin
                            Value(i).Name = "txt_" & VName
                            Value(i).ButtonTitle = D9911.ItemNameSimply
                            Value(i).TextboxFont = New Font("Tahoma", 12)
                            Value(i).Size = New Size(253, 26)

                        Case "2"
                            Value(i) = New SelectPeaceHLPButton
                            Value(i).Name = "txt_" & VName
                            Value(i).ButtonTitle = D9911.ItemNameSimply
                            Value(i).TextboxFont = New Font("Tahoma", 12)
                            Value(i).TextMultiline = False
                            Value(i).Size = New Size(399, 26)

                        Case "3"
                            Value(i) = New SelectPeaceCombo
                            Value(i).Name = "cmb_" & VName
                            Value(i).ButtonTitle = D9911.ItemNameSimply
                            Value(i).Cvalue = D9911.REMK
                            Value(i).TextboxFont = New Font("Tahoma", 12)
                            Value(i).Size = New Size(399, 26)

                        Case "4"
                            Value(i) = New PeaceCheckbox
                            Value(i).Name = "chk_" & VName
                            Value(i).Font = New Font("Tahoma", 12)
                            Value(i).Text = D9911.ItemNameSimply
                            Value(i).AutoSize = False
                            Value(i).Size = New Size(189, 19)

                        Case "5"
                            Value(i) = New PeaceRadioButton
                            Value(i).Name = "rad_" & VName
                            Value(i).Font = New Font("Tahoma", 12)
                            Value(i).Text = D9911.ItemNameSimply
                            Value(i).AutoSize = False
                            Value(i).Size = New Size(189, 19)

                    End Select
                    PanelFlow.Controls.Add(Value(i))
                    i += 1

                Else
                    M9911 = D9911
                    M9911.ItemName = VName
                    M9911.ItemCode = key_count()
                    M9911.ItemNameSimply = VName
                    M9911.ItemNameForeign1 = VName
                    M9911.ItemNameForeign2 = VName
                    M9911.ProdjectName = "DMS"
                    M9911.FormType = 0
                    M9911.DataType = 0
                    M9911.DataSize = 100
                    M9911.DataDecimal = 2
                    M9911.TextAlign = 2
                    M9911.HorizontalAlignment = 2
                    M9911.VerticalAlignment = 2
                    M9911.SizeWidth = 100
                    M9911.SizeHeight = 30
                    M9911.BackColot = "255-255-255"
                    M9911.ForeColor = "0-0-0"
                    M9911.FontName = "Tahoma"
                    M9911.FontSize = "9.00"
                    M9911.FontBold = "0"
                    M9911.Lock = "1"
                    M9911.Hidden = "1"
                    If Strings.Left(M9911.ItemName, 4).ToUpper = "KEY_" Then M9911.Hidden = "0"

                    If M9911.ItemName.Contains("Amount") Or M9911.ItemName.Contains("amount") _
                      Or M9911.ItemName.Contains("Price") _
                     Or M9911.ItemName.Contains("price") _
                      Or M9911.ItemName.Contains("quantity") _
                      Or M9911.ItemName.Contains("Balance") _
                      Or M9911.ItemName.Contains("balance") _
                      Or M9911.ItemName.Contains("Qty") _
                      Or M9911.ItemName.Contains("qty") _
                       Or M9911.ItemName.Contains("Quantity") Then
                        M9911.DataType = 1
                        M9911.HorizontalAlignment = 3
                    End If

                    M9911.REMK = ""
                    WRITE_PFK9911(M9911)

                    'Select Case M9911.FormType
                    '    Case "0"
                    '        Value(i) = New SelectLabelText
                    '        Value(i).Name = "txt_" & VName
                    '        Value(i).ButtonTitle = D9911.ItemNameSimply
                    '        Value(i).Size = New Size(399, 26)

                    '    Case "1"
                    '        Value(i) = New SelectPeaceCalSin
                    '        Value(i).Name = "txt_" & VName
                    '        Value(i).ButtonTitle = D9911.ItemNameSimply
                    '        Value(i).Size = New Size(253, 26)

                    '    Case "2"
                    '        Value(i) = New SelectPeaceHLPButton
                    '        Value(i).Name = "txt_" & VName
                    '        Value(i).ButtonTitle = D9911.ItemNameSimply
                    '        Value(i).Size = New Size(399, 26)

                    '    Case "3"
                    '        Value(i) = New SelectPeaceCombo
                    '        Value(i).Name = "cmb_" & VName
                    '        Value(i).ButtonTitle = D9911.ItemNameSimply
                    '        Value(i).Size = New Size(399, 26)

                    '    Case "4"
                    '        Value(i) = New PeaceCheckbox
                    '        Value(i).Name = "chk_" & VName
                    '        Value(i).Text = D9911.ItemNameSimply
                    '        Value(i).AutoSize = False
                    '        Value(i).Size = New Size(189, 19)

                    '    Case "5"
                    '        Value(i) = New PeaceRadioButton
                    '        Value(i).Name = "rad_" & VName
                    '        Value(i).Text = D9911.ItemNameSimply
                    '        Value(i).AutoSize = False
                    '        Value(i).Size = New Size(189, 19)

                    'End Select

                    Select Case M9911.FormType
                        Case "0"
                            Value(i) = New SelectLabelText
                            Value(i).Name = "txt_" & VName
                            Value(i).ButtonTitle = M9911.ItemNameSimply
                            Value(i).TextboxFont = New Font("Tahoma", 12)
                            Value(i).TextMultiline = False
                            Value(i).Size = New Size(399, 26)

                        Case "1"
                            Value(i) = New SelectPeaceCalSin
                            Value(i).Name = "txt_" & VName
                            Value(i).ButtonTitle = M9911.ItemNameSimply
                            Value(i).TextboxFont = New Font("Tahoma", 12)
                            Value(i).Size = New Size(253, 26)

                        Case "2"
                            Value(i) = New SelectPeaceHLPButton
                            Value(i).Name = "txt_" & VName
                            Value(i).ButtonTitle = M9911.ItemNameSimply
                            Value(i).TextboxFont = New Font("Tahoma", 12)
                            Value(i).TextMultiline = False
                            Value(i).Size = New Size(399, 26)

                        Case "3"
                            Value(i) = New SelectPeaceCombo
                            Value(i).Name = "cmb_" & VName
                            Value(i).ButtonTitle = M9911.ItemNameSimply
                            Value(i).Cvalue = M9911.REMK
                            Value(i).TextboxFont = New Font("Tahoma", 12)
                            Value(i).Size = New Size(399, 26)

                        Case "4"
                            Value(i) = New PeaceCheckbox
                            Value(i).Name = "chk_" & VName
                            Value(i).Font = New Font("Tahoma", 12)
                            Value(i).Text = M9911.ItemNameSimply
                            Value(i).AutoSize = False
                            Value(i).Size = New Size(189, 19)

                        Case "5"
                            Value(i) = New PeaceRadioButton
                            Value(i).Name = "rad_" & VName
                            Value(i).Font = New Font("Tahoma", 12)
                            Value(i).Text = M9911.ItemNameSimply
                            Value(i).AutoSize = False
                            Value(i).Size = New Size(189, 19)

                    End Select

                    PanelFlow.Controls.Add(Value(i))
                    i += 1

                End If
            Next
            _ParaCount = i
        Catch ex As Exception

        End Try
    End Sub
    Private Function key_count() As String
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        SQL = "SELECT MAX(CAST(K9911_ItemCode AS DECIMAL)) AS MAX_CODE FROM PFK9911 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            key_count = "000001"
        Else
            key_count = Format(CInt(rd!MAX_CODE + 1), "000000")
        End If
        rd.Close()
    End Function
#End Region

#Region "EVENT"
    Private Sub Vs1_CellClick1(sender As Object, e As CellClickEventArgs)
        If e.ColumnHeader = True Then Exit Sub
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False

        If DATA_SEARCH01() = True Then

        End If
    End Sub

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex) IsNot Nothing Then
            If getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex) <> "" Then

                DSxxx = Nothing
                DSxxx = Vs1.ActiveSheet.GetDataView(False).Item(Vs1.ActiveSheet.GetModelRowFromViewRow(Vs1.ActiveSheet.ActiveRowIndex)).Row

                'DSxxx = Vs1.ActiveSheet.GetDataView(True).Item(Vs1.ActiveSheet.GetModelRowFromViewRow(Vs1.ActiveSheet.ActiveRowIndex)).Row
                'DSxxx = Nothing
                'DSxxx = CType(CType(Vs1.ActiveSheet.DataSource, DataTable).Rows(Vs1.ActiveSheet.ActiveRowIndex), DataRow)
                isudCHK = True

            End If
        Else
            hlp0000SeVa = ""
            hlp0000SeVaTt = ""
            hlp0000SeVaTt1 = ""
            DSxxx = Nothing
        End If
        Me.Dispose()
    End Sub

    Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        hlp0000SeVaTt1 = ""
        DSxxx = Nothing
        isudCHK = False
        Me.Dispose()
    End Sub

    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs)
        cmd_OK.PerformClick()
    End Sub

    Private Sub cmd_New_Click(sender As Object, e As EventArgs) Handles cmd_New.Click

    End Sub
#End Region

    
End Class