Public Class CALENDAR_DOUBLE
    Private maxs, maxe As Boolean
    Private checka As Boolean = False
    Private checkb As Boolean = False

    Private Sub CALENDAR_DOUBLE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        maxs = False
        maxe = False
        combongaythangs()
        combongaythange()
        cb_syear.Text = syearn.ToString
        cb_eyear.Text = eyearn.ToString
        cb_smonth.Text = smonth.ToString("00")
        cb_emonth.Text = emonth.ToString("00")
        FpSpread1.Sheets(0).Cells(0, 0, 5, 6).BackColor = Color.White
        FpSpread2.Sheets(0).Cells(0, 0, 5, 6).BackColor = Color.White
        ngaythangs()
        ngaythange()
    End Sub
    Private Function combongaythangs() As Boolean
        Dim i As Integer
        Dim datetime8 As String = System_Date_8()
        Dim nam As Integer = CInt(Strings.Left(datetime8, 4))
        If checka = False Then
            For i = -5 To 5
                cb_syear.Items.Add(nam + i)
            Next
            checka = True
        End If
        Return checka
    End Function
    Private Function combongaythange() As Boolean
        Dim i As Integer
        Dim datetime8 As String = System_Date_8()
        Dim nam As Integer = CInt(Strings.Left(datetime8, 4))
        If checkb = False Then
            For i = -5 To 5
                cb_eyear.Items.Add(nam + i)
            Next
            checkb = True
        End If
        Return checkb
    End Function
    Private Sub ngaythangs()
        Dim i, j As Integer
        Dim firstdate As Date = New Date(syearn, smonth, 1)
        Select Case firstdate.DayOfWeek
            Case DayOfWeek.Sunday
                diembatdau = 0
            Case DayOfWeek.Monday
                diembatdau = 1
            Case DayOfWeek.Tuesday
                diembatdau = 2
            Case DayOfWeek.Wednesday
                diembatdau = 3
            Case DayOfWeek.Thursday
                diembatdau = 4
            Case DayOfWeek.Friday
                diembatdau = 5
            Case DayOfWeek.Saturday
                diembatdau = 6
        End Select
        FpSpread1.Sheets(0).Cells(0, diembatdau).Value = firstdate.Day
        For j = 0 To 5
            For i = 0 To 6
                FpSpread1.Sheets(0).Cells(j, i).Tag = firstdate.AddDays(i - diembatdau + 7 * j).Month
                If FpSpread1.Sheets(0).Cells(j, i).Tag = firstdate.Month Then
                    FpSpread1.Sheets(0).Cells(j, i).Text = firstdate.AddDays(i - diembatdau + 7 * j).Day
                    FpSpread1.Sheets(0).Cells(j, i).Font = New Font("Tahoma", 12, FontStyle.Bold)
                    If firstdate.AddDays(i - diembatdau + 7 * j).DayOfWeek = DayOfWeek.Sunday Then
                        FpSpread1.Sheets(0).Cells(j, i).ForeColor = Color.Red
                    ElseIf firstdate.AddDays(i - diembatdau + 7 * j).DayOfWeek = DayOfWeek.Saturday Then
                        FpSpread1.Sheets(0).Cells(j, i).ForeColor = Color.Blue
                    End If
                    'If firstdate.AddDays(i - diembatdau + 7 * j).Date = Today Then
                    '    FpSpread1.Sheets(0).Cells(j, i).BackColor = Color.Yellow
                    'End If
                    If CInt(FpSpread1.Sheets(0).Cells(j, i).Text) = sday Then
                        FpSpread1.Sheets(0).Cells(j, i).BackColor = Color.YellowGreen
                        FpSpread1.ActiveSheet.SetActiveCell(j, i)
                        maxs = True
                    End If

                Else
                    FpSpread1.Sheets(0).Cells(j, i).Text = firstdate.AddDays(i - diembatdau + 7 * j).Day
                    FpSpread1.Sheets(0).Cells(j, i).ForeColor = Color.Black
                    FpSpread1.Sheets(0).Cells(j, i).Font = New Font("Tahoma", 10, FontStyle.Regular)
                    If maxs = False And CInt(FpSpread1.Sheets(0).Cells(j, i).Text) = 1 And FpSpread1.Sheets(0).Cells(j, i).Tag = smonth + 1 Then
                        If i = 0 Then
                            FpSpread1.Sheets(0).Cells(j - 1, 6).BackColor = Color.YellowGreen
                            FpSpread1.ActiveSheet.SetActiveCell(j - 1, 6)
                        Else
                            FpSpread1.Sheets(0).Cells(j, i - 1).BackColor = Color.YellowGreen
                            FpSpread1.ActiveSheet.SetActiveCell(j, i - 1)
                        End If
                        maxs = True
                    End If
                End If

            Next
        Next
        maxs = False
    End Sub
    Private Sub ngaythange()
        Dim i, j As Integer
        Dim firstdate As Date = New Date(eyearn, emonth, 1)
        Select Case firstdate.DayOfWeek
            Case DayOfWeek.Sunday
                diembatdau = 0
            Case DayOfWeek.Monday
                diembatdau = 1
            Case DayOfWeek.Tuesday
                diembatdau = 2
            Case DayOfWeek.Wednesday
                diembatdau = 3
            Case DayOfWeek.Thursday
                diembatdau = 4
            Case DayOfWeek.Friday
                diembatdau = 5
            Case DayOfWeek.Saturday
                diembatdau = 6
        End Select
        FpSpread2.Sheets(0).Cells(0, diembatdau).Value = firstdate.Day
        For j = 0 To 5
            For i = 0 To 6
                FpSpread2.Sheets(0).Cells(j, i).Tag = firstdate.AddDays(i - diembatdau + 7 * j).Month
                If FpSpread2.Sheets(0).Cells(j, i).Tag = firstdate.Month Then
                    FpSpread2.Sheets(0).Cells(j, i).Text = firstdate.AddDays(i - diembatdau + 7 * j).Day
                    FpSpread2.Sheets(0).Cells(j, i).Font = New Font("Tahoma", 12, FontStyle.Bold)
                    If firstdate.AddDays(i - diembatdau + 7 * j).DayOfWeek = DayOfWeek.Sunday Then
                        FpSpread2.Sheets(0).Cells(j, i).ForeColor = Color.Red
                    ElseIf firstdate.AddDays(i - diembatdau + 7 * j).DayOfWeek = DayOfWeek.Saturday Then
                        FpSpread2.Sheets(0).Cells(j, i).ForeColor = Color.Blue
                    End If
                    'If firstdate.AddDays(i - diembatdau + 7 * j).Date = Today Then
                    '    FpSpread2.Sheets(0).Cells(j, i).BackColor = Color.Yellow
                    'End If
                    If CInt(FpSpread2.Sheets(0).Cells(j, i).Text) = eday Then
                        FpSpread2.Sheets(0).Cells(j, i).BackColor = Color.YellowGreen
                        FpSpread2.ActiveSheet.SetActiveCell(j, i)
                        maxe = True
                    End If

                Else

                    FpSpread2.Sheets(0).Cells(j, i).Text = firstdate.AddDays(i - diembatdau + 7 * j).Day
                    FpSpread2.Sheets(0).Cells(j, i).ForeColor = Color.Black
                    FpSpread2.Sheets(0).Cells(j, i).Font = New Font("Tahoma", 10, FontStyle.Regular)
                    If maxe = False And CInt(FpSpread2.Sheets(0).Cells(j, i).Text) = 1 And FpSpread2.Sheets(0).Cells(j, i).Tag = emonth + 1 Then
                        If i = 0 Then
                            FpSpread2.Sheets(0).Cells(j - 1, 6).BackColor = Color.YellowGreen
                            FpSpread2.ActiveSheet.SetActiveCell(j - 1, 6)
                        Else
                            FpSpread2.Sheets(0).Cells(j, i - 1).BackColor = Color.YellowGreen
                            FpSpread2.ActiveSheet.SetActiveCell(j, i - 1)
                        End If
                        maxe = True
                    End If
                End If
            Next
        Next
        maxe = False
    End Sub
    Private Sub PeaceCombobox2_Click(sender As Object, e As EventArgs) Handles cb_smonth.SelectedIndexChanged, cb_emonth.SelectedIndexChanged, _
         cb_syear.SelectedIndexChanged, cb_eyear.SelectedIndexChanged
        Select Case True
            Case sender Is cb_syear
                If cb_syear.Text = "" Then
                    cb_syear.Text = syearn
                End If
                syearn = CInt(cb_syear.Text)
            Case sender Is cb_smonth
                If cb_smonth.Text = "" Then
                    cb_smonth.Text = smonth.ToString("00")
                End If
                smonth = CInt(cb_smonth.Text)
                FpSpread1.Sheets(0).Cells(0, 0, 5, 6).Value = Nothing
                FpSpread1.Sheets(0).Cells(0, 0, 5, 6).BackColor = Color.White
                FpSpread1.Sheets(0).ClearSelection()
                ngaythangs()
            Case sender Is cb_eyear
                If cb_eyear.Text = "" Then
                    cb_eyear.Text = eyearn
                End If
                eyearn = CInt(cb_eyear.Text)
            Case sender Is cb_emonth
                If cb_emonth.Text = "" Then
                    cb_emonth.Text = emonth.ToString("00")
                End If
                emonth = CInt(cb_emonth.Text)
                FpSpread2.Sheets(0).Cells(0, 0, 5, 6).Value = Nothing
                FpSpread2.Sheets(0).Cells(0, 0, 5, 6).BackColor = Color.White
                FpSpread2.Sheets(0).ClearSelection()
                ngaythange()
        End Select

    End Sub

    Private Sub PeaceButton5_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        sday = Nothing
        eday = Nothing
        syearn = Nothing
        smonth = Nothing
        eyearn = Nothing
        emonth = Nothing
        Me.Close()
    End Sub

    Private Sub btn_back1_Click(sender As Object, e As EventArgs) Handles btn_back1.Click, btn_back2.Click, btn_next1.Click, btn_next2.Click
        Select Case True
            Case sender Is btn_back1
                If cb_smonth.Text = "01" Then
                    cb_smonth.Text = "12"
                    cb_syear.Text = CInt(cb_syear.Text) - 1
                Else
                    cb_smonth.Text = (CInt(cb_smonth.Text) - 1).ToString("00")
                End If
            Case sender Is btn_next1
                If cb_smonth.Text = "12" Then
                    cb_smonth.Text = "01"
                    cb_syear.Text = CInt(cb_syear.Text) + 1
                Else
                    cb_smonth.Text = (CInt(cb_smonth.Text) + 1).ToString("00")
                End If
            Case sender Is btn_back2
                If cb_emonth.Text = "01" Then
                    cb_emonth.Text = "12"
                    cb_eyear.Text = CInt(cb_eyear.Text) - 1
                Else
                    cb_emonth.Text = (CInt(cb_emonth.Text) - 1).ToString("00")
                End If

            Case sender Is btn_next2
                If cb_emonth.Text = "12" Then
                    cb_emonth.Text = "01"
                    cb_eyear.Text = CInt(cb_eyear.Text) + 1
                Else
                    cb_emonth.Text = (CInt(cb_emonth.Text) + 1).ToString("00")
                End If
        End Select
        sday = CInt(FpSpread1.ActiveSheet.ActiveCell.Value)
        eday = CInt(FpSpread2.ActiveSheet.ActiveCell.Value)
        smonth = CInt(cb_smonth.GetItemText(cb_smonth.SelectedItem))
        emonth = CInt(cb_emonth.GetItemText(cb_emonth.SelectedItem))
        syearn = CInt(cb_syear.GetItemText(cb_syear.SelectedItem))
        eyearn = CInt(cb_eyear.GetItemText(cb_eyear.SelectedItem))
    End Sub

    Private Sub FpSpread1_CellClick(sender As Object, e As FarPoint.Win.Spread.CellClickEventArgs) Handles FpSpread1.CellClick
        FpSpread1.Sheets(0).Cells(0, 0, 5, 6).BackColor = Color.White
        sday = FpSpread1.Sheets(0).Cells(e.Row, e.Column).Text
        FpSpread1.Sheets(0).Cells(e.Row, e.Column).BackColor = Color.YellowGreen
        If FpSpread1.Sheets(0).Cells(e.Row, e.Column).Tag <> smonth And FpSpread1.Sheets(0).Cells(e.Row, e.Column).Tag = "12" And smonth <> 11 Then
            cb_smonth.Text = CInt(FpSpread1.Sheets(0).Cells(e.Row, e.Column).Tag).ToString("00")
            cb_syear.Text = CIntp(cb_syear.Text) - 1
            e.Cancel = True
        ElseIf FpSpread1.Sheets(0).Cells(e.Row, e.Column).Tag <> smonth And FpSpread1.Sheets(0).Cells(e.Row, e.Column).Tag = "1" And smonth <> 2 Then
            cb_smonth.Text = CInt(FpSpread1.Sheets(0).Cells(e.Row, e.Column).Tag).ToString("00")
            cb_syear.Text = CIntp(cb_syear.Text) + 1
            e.Cancel = True
        ElseIf FpSpread1.Sheets(0).Cells(e.Row, e.Column).Tag <> smonth Then
            cb_smonth.Text = CInt(FpSpread1.Sheets(0).Cells(e.Row, e.Column).Tag).ToString("00")
            e.Cancel = True
        End If
    End Sub

    Private Sub FpSpread2_CellClick(sender As Object, e As FarPoint.Win.Spread.CellClickEventArgs) Handles FpSpread2.CellClick
        FpSpread2.Sheets(0).Cells(0, 0, 5, 6).BackColor = Color.White
        eday = FpSpread2.Sheets(0).Cells(e.Row, e.Column).Text
        FpSpread2.Sheets(0).Cells(e.Row, e.Column).BackColor = Color.YellowGreen
        If FpSpread2.Sheets(0).Cells(e.Row, e.Column).Tag <> emonth And FpSpread2.Sheets(0).Cells(e.Row, e.Column).Tag = "12" And emonth <> 11 Then
            cb_emonth.Text = CInt(FpSpread2.Sheets(0).Cells(e.Row, e.Column).Tag).ToString("00")
            cb_eyear.Text = CIntp(cb_eyear.Text) - 1
            e.Cancel = True
        ElseIf FpSpread2.Sheets(0).Cells(e.Row, e.Column).Tag <> emonth And FpSpread2.Sheets(0).Cells(e.Row, e.Column).Tag = "1" And emonth <> 2 Then
            cb_emonth.Text = CInt(FpSpread2.Sheets(0).Cells(e.Row, e.Column).Tag).ToString("00")
            cb_eyear.Text = CIntp(cb_eyear.Text) + 1
            e.Cancel = True
        ElseIf FpSpread2.Sheets(0).Cells(e.Row, e.Column).Tag <> emonth Then
            cb_emonth.Text = CInt(FpSpread2.Sheets(0).Cells(e.Row, e.Column).Tag).ToString("00")
            e.Cancel = True
        End If
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click, btn_Close.Click
        sday = CInt(FpSpread1.ActiveSheet.ActiveCell.Value)
        eday = CInt(FpSpread2.ActiveSheet.ActiveCell.Value)
        smonth = CInt(cb_smonth.GetItemText(cb_smonth.SelectedItem))
        emonth = CInt(cb_emonth.GetItemText(cb_emonth.SelectedItem))
        syearn = CInt(cb_syear.GetItemText(cb_syear.SelectedItem))
        eyearn = CInt(cb_eyear.GetItemText(cb_eyear.SelectedItem))
        Me.Close()
    End Sub

    Private Sub FpSpread2_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles FpSpread2.CellDoubleClick, FpSpread1.CellDoubleClick
        btn_ok.PerformClick()
    End Sub

    Private Sub FpSpread1_KeyDown(sender As Object, e As KeyEventArgs) Handles FpSpread1.KeyDown, FpSpread2.KeyDown
        If e.KeyCode = Keys.Enter Then
            sday = CInt(FpSpread1.ActiveSheet.ActiveCell.Value)
            eday = CInt(FpSpread2.ActiveSheet.ActiveCell.Value)
            smonth = CInt(cb_smonth.GetItemText(cb_smonth.SelectedItem))
            emonth = CInt(cb_emonth.GetItemText(cb_emonth.SelectedItem))
            syearn = CInt(cb_syear.GetItemText(cb_syear.SelectedItem))
            eyearn = CInt(cb_eyear.GetItemText(cb_eyear.SelectedItem))
            Me.Close()
        End If
    End Sub
End Class