Public Class PFP99997
    Private Dsu01 As Long     'Data Su
    Private wGCODE As String
    Protected prg As E_PRG
    Private a7101() As T7101_AREA

    Private Form_Close As Boolean

    Private Enum colvS1
        MTSEL = 1
        MTCODE = 2
        NameSimply = 3
        EGNAME = 4
        CHNAME = 5
        VTNAME = 6
        SPNAME = 7
    End Enum

#Region "rezise"


    Private fhei, fthei As Integer
    Private ofhei, otstr As Integer
    Private ofont, otfont As Integer
    Private fsize As Decimal = 1
    Private ftsize As Decimal = 1
    Private sizeb As Boolean = False


    Public Sub fresize()
        Try
            ofhei = 23
            ofont = 9
            otstr = 23
            otfont = 9
            fhei = chk_FSEL.Height
            fthei = tst_1.Height
            fsize = Math.Abs(fhei / ofhei)
            ftsize = Math.Abs(fthei / otstr)

            TableLayoutPanel1.RowStyles(0).Height = 30
            TableLayoutPanel1.RowStyles(1).Height = 34
            TableLayoutPanel1.RowStyles(2).Height = Me.Height - TableLayoutPanel1.RowStyles(0).Height - TableLayoutPanel1.RowStyles(1).Height
            'If fsize > (13 / 9) Or ftsize > (13 / 9) Then
            '    Exit Sub
            'End If
            'Dim c As Object
            'For Each c In TableLayoutPanel1.Controls
            '    If (TypeOf c Is PeaceTabControl) Then
            '        c.Font = New Font("Tahoma", ofont * ftsize)
            '    End If
            'Next
            'For Each c In TableLayoutPanel3.Controls
            '    If (TypeOf c Is PeaceButton) Or (TypeOf c Is PeaceCheckbox) Then
            '        c.Font = New Font("Tahoma", ofont * ftsize)
            '    End If
            'Next
            'For Each c In TableLayoutPanel2.Controls
            '    If (TypeOf c Is Button) Then
            '        c.Font = New Font("Tahoma", ofont * fsize)
            '    End If
            '    If (TypeOf c Is SelectLabelSearch) Then
            '        Dim d As Object
            '        For Each d In c.Controls
            '            If (TypeOf d Is TableLayoutPanel) Then
            '                Dim f As Object
            '                For Each f In d.Controls
            '                    If (TypeOf f Is PeaceTextbox) Or (TypeOf f Is PeaceButton) Then
            '                        f.Font = New Font("Tahoma", ofont * fsize)
            '                    End If
            '                Next
            '            End If
            '        Next
            '    End If
            '    If (TypeOf c Is SelectPeaceHLPButton) Then
            '        Dim d As Object
            '        For Each d In c.Controls
            '            If (TypeOf d Is TableLayoutPanel) Then
            '                Dim f As Object
            '                For Each f In d.Controls
            '                    If (TypeOf f Is PeaceButton) Or (TypeOf f Is PeaceTextbox) Then
            '                        f.Font = New Font("Tahoma", ofont * fsize)
            '                    End If
            '                Next
            '            End If
            '        Next
            '    End If
            '    If (TypeOf c Is SelectPeaceCalDou) Then
            '        Dim d As Object
            '        For Each d In c.Controls
            '            If (TypeOf d Is TableLayoutPanel) Then
            '                Dim f As Object
            '                For Each f In d.Controls
            '                    If (TypeOf f Is PeaceButton) Or (TypeOf f Is PeaceTextbox) Or (TypeOf f Is PeaceMaskedtextbox) Then
            '                        f.Font = New Font("Tahoma", ofont * fsize)
            '                    End If
            '                Next
            '            End If
            '        Next
            '    End If
            'Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub PFP0002_ResizeEnd(sender As Object, e As EventArgs) Handles Me.SizeChanged
        Timer1.Enabled = True
        fresize()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.WindowState = FormWindowState.Maximized Then
            fresize()
            Timer1.Enabled = False
        End If
    End Sub
#End Region
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False, WordConv("INPUT") & "(F5)")
        Me.KeyPreview = True
        Call FORM_INIT()
        Call DATA_INIT()
        SPR_SET(Vs1, 2, , , OperationMode.SingleSelect)
    End Sub

    Private Sub Me_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
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

    Private Sub tst_1_Click(sender As Object, e As EventArgs) Handles tst_1.Click, tst_2.Click, tst_3.Click, tst_4.Click, tst_5.Click, tst_6.Click
        If sender.Equals(tst_1) Then
            MAIN_JOB01()
        End If
        If sender.Equals(tst_2) Then
            MAIN_JOB02()
        End If
    End Sub
    Private Sub MAIN_JOB01()
        Dim tmpSELECT As String

        Call READ_PFK9992(Pub.SITE, Pub.SAW)
        If Pub.DEVCHK = "1" Or Pub.GRP = "007" Then D9992.GROUPPW = "..."
        'Dim f As Form
        'f = New PASSWORDFORM
        'f.ShowDialog()
        tmpSELECT = getData(Vs1, colvS1.MTSEL, Vs1.ActiveSheet.ActiveRowIndex)

        '   If ISUD9997A.Link_ISUD9997A(1, 0, tmpSELECT) = False Then Exit Sub

        Call DATA_SEARCH01()

    End Sub

    Private Sub MAIN_JOB02()
        '  If Toolbar1.Buttons.Item(3).Enabled = False Then Exit Sub
        If getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        ' If ISUD7101A.Link_ISUD7101A(3, a7101(Vs1.ActiveSheet.ActiveRowIndex).GCODE) = False Then Exit Sub
        Call LINE_MOVE_DISPLAY01()
    End Sub

    Private Sub MAIN_JOB03()
        '  If Toolbar1.Buttons.Item(5).Enabled = False Then Exit Sub
        If getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

    End Sub

    Private Sub MAIN_JOB04()
        ' If Toolbar1.Buttons.Item(7).Enabled = False Then Exit Sub
        If getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

    End Sub

    Private Sub MAIN_JOB05()
        'If Toolbar1.Buttons.Item(9).Enabled = False Then Exit Sub
        If getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

    End Sub

    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False

        Dim RS01 As DataRow = Nothing
        Dim i As Double

        DATA_SEARCH01 = False
        If opt_SEL0.Checked = True Then
            PrcDR("SP_PFP70101_SEARCH_1", cn, txt_GNAME.Text, chk_GCHK0.CheckState, chk_GCHK1.CheckState, chk_GCHK2.CheckState, _
                                      chk_GCHK3.CheckState, chk_GCHK4.CheckState, chk_GCHK5.CheckState, "1", chk_USE0.CheckState, chk_USE1.CheckState)
        End If

        If opt_SEL1.Checked = True Then
            PrcDR("SP_PFP70101_SEARCH_1", cn, txt_GNAME.Text, chk_GCHK0.CheckState, chk_GCHK1.CheckState, chk_GCHK2.CheckState, _
                                       chk_GCHK3.CheckState, chk_GCHK4.CheckState, chk_GCHK5.CheckState, "2", chk_USE0.CheckState, chk_USE1.CheckState)
        End If

        da.SelectCommand = cmd
        ds.Reset()
        da.Fill(ds)
        If GetDsRc(ds) = 0 Then
            Exit Function
        End If

        Dsu01 = GetDsRc(ds) - 1
        ReDim a7101(0 To Dsu01)
        PRG_SET(prg, Dsu01)
        prg.Visible = True

        i = 0
        For Each RS01 In ds.Tables(0).Rows
            PRG_VALUE(prg, i)
            Vs1.ActiveSheet.RowCount = i + 1
            Call K7101_MOVE(RS01) : a7101(i) = D7101

            'setdata(Vs1, 1, i, a7101(i).GCODE)
            'setdata(Vs1, 2, i, a7101(i).GNAME)
            'setdata(Vs1, 3, i, a7101(i).PNAME)
            'setdata(Vs1, 4, i, a7101(i).JOBNO)
            'setdata(Vs1, 5, i, a7101(i).UPTAE)
            'setdata(Vs1, 6, i, a7101(i).JONGM)
            'setdata(Vs1, 7, i, a7101(i).ZIPNO)
            'setdata(Vs1, 8, i, a7101(i).ADDR)
            'setdata(Vs1, 9, i, a7101(i).TEL)
            'setdata(Vs1, 10, i, a7101(i).FAX)

            'If a7101(i).VSEL = "1" Then setdata(Vs1, 11, i, WordConv("EXISTENCE"))
            'If a7101(i).VSEL = "2" Then setdata(Vs1, 11, i, WordConv("NOTHING"))

            'If a7101(i).XCHK = "1" Then setdata(Vs1, 15, i, WordConv("EXISTENCE"))
            'If a7101(i).XCHK = "2" Then setdata(Vs1, 15, i, WordConv("NOTHING"))

            setdata(Vs1, 12, i, a7101(i).EMAIL)

            setdata(Vs1, 13, i, RS01![SANO])
            setdata(Vs1, 14, i, RS01![SALE])

            'setdata(Vs1, 16, i, a7101(i).REMK)
            'Application.DoEvents()
            'Threading.Thread.Sleep(100)
            If Form_Close = True Then Me.Close()
            If INTERRUPT_BREAK() = True Then Exit For
            i += 1
        Next
        DATA_SEARCH01 = True
        prg.Visible = False
        PRG_VALUE(prg, 0)

    End Function

    Private Function LINE_MOVE_DISPLAY01() As Boolean
        LINE_MOVE_DISPLAY01 = False

        Dim r1 As Long
        r1 = Vs1.ActiveSheet.ActiveRowIndex

        'PrcDR("SP_PFP70101_UPDATE_1", cn, a7101(r1).GCODE)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            Call K7101_MOVE(rd) : a7101(r1) = D7101

            'setData(Vs1, 1, r1, a7101(r1).GCODE)
            'setData(Vs1, 2, r1, a7101(r1).GNAME)
            'setData(Vs1, 3, r1, a7101(r1).PNAME)
            'setData(Vs1, 4, r1, a7101(r1).JOBNO)
            'setData(Vs1, 5, r1, a7101(r1).UPTAE)
            'setData(Vs1, 6, r1, a7101(r1).JONGM)
            'setData(Vs1, 7, r1, a7101(r1).ZIPNO)
            'setData(Vs1, 8, r1, a7101(r1).ADDR)
            'setData(Vs1, 9, r1, a7101(r1).TEL)
            'setData(Vs1, 10, r1, a7101(r1).FAX)


            'If a7101(r1).VSEL = "1" Then setData(Vs1, 11, r1, WordConv("EXISTENCE"))
            'If a7101(r1).VSEL = "2" Then setData(Vs1, 11, r1, WordConv("NOTHING"))

            'If a7101(r1).VSEL = "1" Then setData(Vs1, 11, r1, WordConv("EXISTENCE"))
            'If a7101(r1).VSEL = "2" Then setData(Vs1, 11, r1, WordConv("NOTHING"))

            setData(Vs1, 12, r1, a7101(r1).EMAIL)

            setData(Vs1, 13, r1, rd![SANO])
            setData(Vs1, 14, r1, rd![SALE])

            'setData(Vs1, 16, r1, a7101(r1).REMK)

            LINE_MOVE_DISPLAY01 = True
        Else
            'sau
            '    Call LineClear(Vs1, r1)
            'a7101(r1).GCODE = ""

            setData(Vs1, 1, r1, "[" & WordConv("DELETE COMPLETE") & "]")
        End If

        rd.Close()

    End Function

    Private Sub FORM_INIT()
        chk_FSEL.CheckState = 1
        chk_FSEL.BackColor = Color.White           '³ì»ö
        chk_FSEL.ForeColor = Color.Red              '»¡°­»ö

        chk_FSEL.Text = WordConv("CLOSE")
        ssp_WHERE.Visible = True


    End Sub

    Private Sub DATA_INIT()

    End Sub

    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        Call MAIN_JOB02()
    End Sub

    'KEYDOWN

    Private Sub vS1_GotFocus(sender As Object, e As EventArgs) Handles Vs1.GotFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, False, False, False, False, WordConv("INPUT") & "(F5)", WordConv("CHANGE") & "(F6)")

        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = Color.Yellow           '³ì»ö
        chk_FSEL.ForeColor = Color.Red              '»¡°­»ö

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False               '¾È´­·ÁÁ³À½
    End Sub

    Private Sub txt_GNAME_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_GNAME.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter : cmd_SEARCH.focus()
        End Select
    End Sub

    Private Sub vS1_LostFocus(sender As Object, e As EventArgs) Handles Vs1.LostFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False, WordConv("INPUT") & "(F5)")

    End Sub

    Private Sub chk_FSEL_Click(sender As Object, e As EventArgs) Handles chk_FSEL.CheckedChanged
        If chk_FSEL.CheckState = 0 Then                  '
            chk_FSEL.BackColor = Color.Yellow           '³ì»ö
            chk_FSEL.ForeColor = Color.Red              '»¡°­»ö

            chk_FSEL.Text = WordConv("OPEN")
            ssp_WHERE.Visible = False                     '¾È´­·ÁÁ³À½
        Else                                        '
            chk_FSEL.BackColor = Color.White           '³ì»ö
            chk_FSEL.ForeColor = Color.Red              '»¡°­»ö

            chk_FSEL.Text = WordConv("CLOSE")
            ssp_WHERE.Visible = True         '´­·¯Á³À½
        End If
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click

        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = Color.Yellow           '³ì»ö
        chk_FSEL.ForeColor = Color.Red              '»¡°­»ö

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False                '¾È´­·ÁÁ³À½

        Call DATA_SEARCH01()

    End Sub

End Class