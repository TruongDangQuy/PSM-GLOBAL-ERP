Public Class CALENDAR_SINGLE
    Private datechk As Date
    Private formA As Boolean
    Public Function CALENDAR_SINGLE_Link() As Boolean
        CALENDAR_SINGLE_Link = False
        Try
            formA = False
            Me.ShowDialog()
            CALENDAR_SINGLE_Link = isudCHK
        Catch ex As Exception

        End Try
    End Function
    Public Function CALENDAR_SINGLE_Link(SDate As String) As Boolean
        CALENDAR_SINGLE_Link = False
        formA = False
        Try
            Dim CSdate As Date
            SDate = FormatCut(SDate)

            Try
                CSdate = New Date(Strings.Left(SDate, 4), Mid(SDate, 5, 2), Strings.Right(SDate, 2))
            Catch ex As Exception
                SDate = System_Date_8()
            End Try

            'If IsNumeric(SDate) = False Then SDate = System_Date_8()
            'If CIntp(SDate) = 0 Then SDate = System_Date_8()
            sday = CIntp(Strings.Right(SDate, 2))
            smonth = CIntp(Strings.Mid(SDate, 5, 2))
            syearn = CIntp(Strings.Left(SDate, 4))
            Me.ShowDialog()
            CALENDAR_SINGLE_Link = isudCHK
        Catch ex As Exception

        End Try
    End Function
    Private Sub CALENDAR_SINGLE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datechk = System_Datetime()
        cmb_year.Items.Clear()
        'sday = CIntp(Strings.Right(System_Date_8, 2))


        FpSpread1_Sheet1.Cells(0, 0, 5, 6).BackColor = Color.White
        combongaythang()
        cmb_year.Text = syearn.ToString
        cmb_month.Text = smonth.ToString("00")
        ngaythang()

        formA = True
    End Sub

    Private Sub combongaythang()
        Dim i As Integer
        Dim datetime8 As String = System_Date_8()
        Dim nam As Integer = CIntp(Strings.Left(datetime8, 4))
        For i = -5 To 5
            cmb_year.Items.Add(nam + i)
        Next

        'syearn = CIntp(Strings.Left(datetime8, 4))
        'smonth = CIntp(Strings.Mid(datetime8, 5, 2))
        'cmb_year.Text = Strings.Left(datetime8, 4)
        'cmb_month.Text = Strings.Mid(datetime8, 5, 2)
    End Sub
    Private Sub ngaythang()
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
        FpSpread1_Sheet1.Cells(0, diembatdau).Value = firstdate.Day
        For j = 0 To 5
            For i = 0 To 6
                FpSpread1_Sheet1.Cells(j, i).Tag = firstdate.AddDays(i - diembatdau + 7 * j).Month
                If FpSpread1_Sheet1.Cells(j, i).Tag = firstdate.Month Then
                    FpSpread1_Sheet1.Cells(j, i).Text = firstdate.AddDays(i - diembatdau + 7 * j).Day
                    FpSpread1_Sheet1.Cells(j, i).Font = New Font("Tahoma", 10, FontStyle.Bold)
                    If firstdate.AddDays(i - diembatdau + 7 * j).DayOfWeek = DayOfWeek.Sunday Then
                        FpSpread1_Sheet1.Cells(j, i).ForeColor = Color.Red
                    ElseIf firstdate.AddDays(i - diembatdau + 7 * j).DayOfWeek = DayOfWeek.Saturday Then
                        FpSpread1_Sheet1.Cells(j, i).ForeColor = Color.Blue
                    End If
                    If firstdate.AddDays(i - diembatdau + 7 * j).Date = datechk Then
                        FpSpread1_Sheet1.Cells(j, i).BackColor = Color.Yellow
                        FpSpread1.ActiveSheet.ActiveColumnIndex = i
                        FpSpread1.ActiveSheet.ActiveRowIndex = j
                    End If
                    If FpSpread1_Sheet1.Cells(j, i).Text = sday Then
                        FpSpread1_Sheet1.Cells(j, i).BackColor = Color.YellowGreen
                    End If
                Else
                    FpSpread1_Sheet1.Cells(j, i).Text = firstdate.AddDays(i - diembatdau + 7 * j).Day
                    FpSpread1_Sheet1.Cells(j, i).ForeColor = Color.Black
                    FpSpread1_Sheet1.Cells(j, i).Font = New Font("Tahoma", 10, FontStyle.Regular)
                End If
            Next
        Next
        FpSpread1.Select()
    End Sub

    Private Sub PeaceCombobox2_Click(sender As Object, e As EventArgs) Handles cmb_month.SelectedIndexChanged, cmb_year.SelectedIndexChanged
        If formA = False Then Exit Sub
        If cmb_year.Text = "" Or cmb_month.Text = "" Then
            cmb_year.Text = CIntp(Strings.Left(System_Date_8, 4))
            cmb_month.Text = CIntp(Strings.Mid(System_Date_8, 5, 2))
        End If
        syearn = CIntp(cmb_year.Text)
        smonth = CIntp(cmb_month.Text)
        FpSpread1_Sheet1.Cells(0, 0, 5, 6).Value = Nothing
        FpSpread1_Sheet1.Cells(0, 0, 5, 6).BackColor = Color.White
        FpSpread1_Sheet1.ClearSelection()
        ngaythang()
    End Sub

    Private Sub PeaceButton4_Click(sender As Object, e As EventArgs) Handles btn_close.Click, btn_del.Click, btn_ok.Click
        Select Case True
            Case sender Is btn_del
                syearn = Nothing
                smonth = Nothing
                sday = Nothing
                FpSpread1_Sheet1.ClearSelection()
                isudCHK = False
                Me.Close()
            Case sender Is btn_ok
                xacnhan()
            Case sender Is btn_close
                isudCHK = False
                Me.Close()
        End Select

    End Sub

    Private Sub PeaceButton2_Click(sender As Object, e As EventArgs) Handles btn_next.Click, btn_back.Click
        Select Case True
            Case sender Is btn_back
                If cmb_month.Text = "01" Then
                    cmb_month.Text = "12"
                    cmb_year.Text = CIntp(cmb_year.Text) - 1
                Else
                    cmb_month.Text = (CIntp(cmb_month.Text) - 1).ToString("00")
                End If

            Case sender Is btn_next
                If cmb_month.Text = "12" Then
                    cmb_month.Text = "01"
                    cmb_year.Text = CIntp(cmb_year.Text) + 1
                Else
                    cmb_month.Text = (CIntp(cmb_month.Text) + 1).ToString("00")
                End If
        End Select
    End Sub

    Private Sub FpSpread1_CellClick(sender As Object, e As FarPoint.Win.Spread.CellClickEventArgs) Handles FpSpread1.CellClick
        FpSpread1_Sheet1.Cells(0, 0, 5, 6).BackColor = Color.White
        sday = FpSpread1_Sheet1.Cells(e.Row, e.Column).Text
        FpSpread1_Sheet1.Cells(e.Row, e.Column).BackColor = Color.YellowGreen
        If FpSpread1_Sheet1.Cells(e.Row, e.Column).Tag <> smonth Then
            cmb_month.Text = CIntp(FpSpread1_Sheet1.Cells(e.Row, e.Column).Tag).ToString("00")
        End If
    End Sub

    Private Sub xacnhan()
        syearn = cmb_year.Text
        smonth = cmb_month.Text
        FpSpread1_Sheet1.ClearSelection()
        isudCHK = True
        Me.Close()
    End Sub
    Private Sub FpSpread1_CellDoubleClick(sender As Object, e As FarPoint.Win.Spread.CellClickEventArgs) Handles FpSpread1.CellDoubleClick
        xacnhan()

    End Sub
    Private Sub FpSpread1_KeyDown(sender As Object, e As KeyEventArgs) Handles FpSpread1.KeyDown
        Dim xCol As Integer
        Dim xRow As Integer
        xCol = FpSpread1.ActiveSheet.ActiveColumnIndex
        xRow = FpSpread1.ActiveSheet.ActiveRowIndex
        If e.KeyCode = Keys.Enter Then
            'xacnhan()
            FpSpread1_Sheet1.Cells(0, 0, 5, 6).BackColor = Color.White
            sday = FpSpread1_Sheet1.Cells(xRow, xCol).Text
            FpSpread1_Sheet1.Cells(xRow, xCol).BackColor = Color.YellowGreen
            If FpSpread1_Sheet1.Cells(xRow, xCol).Tag <> smonth Then
                cmb_month.Text = CIntp(FpSpread1_Sheet1.Cells(xRow, xCol).Tag).ToString("00")
            End If
            xacnhan()
        End If
    End Sub
End Class