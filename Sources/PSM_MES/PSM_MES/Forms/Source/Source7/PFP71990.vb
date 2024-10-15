Public Class PFP71990

#Region "Variable"
    Protected prg As E_PRG
    Private Dsu01 As Long     'Data Su
    Private Dsu02 As Long     'Data Su
    Private Dsu03 As Long     'Data Su
    Private a7171() As T7171_AREA
    Private b7171() As T7171_AREA
    Private Form_Close As Boolean
    'Private L7825 As T7825_AREA
    Private W7199 As T7199_AREA
#End Region

#Region "Formload"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)
        Me.KeyPreview = True
        Call FORM_INIT()
        Call DATA_INIT()
    End Sub

    Private Sub Me_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub

    Private Sub FORM_INIT()

    End Sub
    Private Sub DATA_INIT()
        txt_Month.Value = CIntp(Strings.Mid(System_Date_8(), 5, 2))
        txt_Month.Maximum = 12
        txt_Month.Minimum = 1
        txt_Year.Value = CIntp(Strings.Mid(System_Date_8(), 1, 4))
        txt_Year.Maximum = txt_Year.Value + 10
        txt_Year.Minimum = txt_Year.Value - 10
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
    Private Sub tst_1_Click(sender As Object, e As EventArgs) Handles tst_1.Click, tst_2.Click, tst_3.Click, tst_4.Click, tst_5.Click, tst_6.Click
        If sender.Equals(tst_1) Then
            MAIN_JOB01()
        End If
        If sender.Equals(tst_2) Then
            MAIN_JOB02()
        End If
        If sender.Equals(tst_3) Then
            MAIN_JOB03()
        End If
        If sender.Equals(tst_4) Then
            MAIN_JOB04()
        End If
    End Sub

    Private Sub MAIN_JOB01()
        If ISUD7199A.Link_ISUD7199A(1, Pub.DAT, Me.Name) = False Then Exit Sub

        Call DATA_SEARCH01()
    End Sub

    Private Sub MAIN_JOB02()
        Dim Datecv As String
        Datecv = getData(Vs1, getColumIndex(Vs1, "KEY_DateExchange"), Vs1.ActiveSheet.ActiveRowIndex)
        If ISUD7199A.Link_ISUD7199A(2, Datecv, Me.Name) = False Then Exit Sub
    End Sub

    Private Sub MAIN_JOB03()
        Dim Datecv As String
        Datecv = getData(Vs1, getColumIndex(Vs1, "KEY_DateExchange"), Vs1.ActiveSheet.ActiveRowIndex)
        If ISUD7199A.Link_ISUD7199A(3, Datecv, Me.Name) = False Then Exit Sub

        Call DATA_SEARCH01()
    End Sub

    Private Sub MAIN_JOB04()
        Dim Datecv As String
        Datecv = getData(Vs1, getColumIndex(Vs1, "KEY_DateExchange"), Vs1.ActiveSheet.ActiveRowIndex)
        If ISUD7199A.Link_ISUD7199A(4, Datecv, Me.Name) = False Then Exit Sub

        Call DATA_SEARCH01()
    End Sub

    Private Sub MAIN_JOB05()
        If getData(Vs1, 12, Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
    End Sub

#End Region

#Region "PFP_SEARCH"
    Private Function DATA_SEARCH01() As Boolean
        Dim i, j, k As Integer
        

        DATA_SEARCH01 = False
        Vs1.Enabled = False

        'SPR_SET(Vs1, , , , OperationMode.Normal, False)
        DS1 = PrcDS("USP_PFP71990_SEARCH_VS1", cn, txt_Year.Value.ToString & txt_Month.Value.ToString("00"))

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs1, DS1, "USP_PFP71990_SEARCH_VS1", "Vs1")
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "USP_PFP71990_SEARCH_VS1", "Vs1")
        'Vs1.ActiveSheet.ColumnCount = 0
        'Vs1.ActiveSheet.RowCount = 16
        'Vs1.ActiveSheet.Columns.Add(0, 10)

        'SPR_NUMBERCELL(Vs1, 2, 100, 1, 5)
        'SPR_NUMBERCELL(Vs1, 2, 100, 2, 3, 6, 7)

        'For i = 0 To 1
        '    Vs1.ActiveSheet.ColumnHeader.Cells(0, 5 * i + 0).Value = "DAY"
        '    Vs1.ActiveSheet.ColumnHeader.Cells(0, 5 * i + 1).Value = "Exchange"
        '    Vs1.ActiveSheet.ColumnHeader.Cells(0, 5 * i + 2).Value = "TTM "
        '    Vs1.ActiveSheet.ColumnHeader.Cells(0, 5 * i + 3).Value = "TTB "
        '    Vs1.ActiveSheet.ColumnHeader.Cells(0, 5 * i + 4).Value = "TTS "

        '    Vs1.ActiveSheet.Columns(5 * i + 0).BackColor = Color.Aqua
        '    Vs1.ActiveSheet.Columns(5 * i + 1).Width = 100
        '    Vs1.ActiveSheet.Columns(5 * i + 2).Width = 100
        '    Vs1.ActiveSheet.Columns(5 * i + 3).Width = 100
        '    Vs1.ActiveSheet.Columns(5 * i + 4).Width = 100
        'Next

        'If GetDsRc(DS1) = 0 Then
        '    For i = 0 To 1
        '        For j = 0 To 15
        '            setData(Vs1, 5 * i, j, (j + 1) + i * 15)
        '        Next
        '    Next

        '    Vs1.Enabled = True
        '    Exit Function
        'End If

        'For i = 0 To 1
        '    For j = 0 To 15
        '        setData(Vs1, 5 * i, j, (j + 1) + i * 15)
        '        For k = 0 To GetDsRc(DS1) - 1
        '            If CDblp(GetDsData(DS1, k, "Day")) = CDblp((j + 1) + i * 15) Then
        '                setData(Vs1, i * 5 + 1, j, GetDsData(DS1, k, "Exchange"))
        '                setData(Vs1, i * 5 + 2, j, GetDsData(DS1, k, "TTM"))
        '                setData(Vs1, i * 5 + 3, j, GetDsData(DS1, k, "TTB"))
        '                setData(Vs1, i * 5 + 4, j, GetDsData(DS1, k, "TTS"))
        '            End If
        '        Next
        '    Next
        'Next



        Vs1.Enabled = True

        DATA_SEARCH01 = True
    End Function
    'Insert new

#End Region

#Region "EVENT"
    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column

        If e.Row < 0 Then Exit Sub
        Vs1.Enabled = False
        Vs1.Enabled = True
    End Sub
    Private Sub Vs1_Change(sender As Object, e As ChangeEventArgs) Handles Vs1.Change
        Dim Xcol, Xrow As Integer

        Xcol = Vs1.ActiveSheet.ActiveColumnIndex
        Xrow = Vs1.ActiveSheet.ActiveRowIndex

        Try

            'If Xcol <= 4 Then
            '    W7199.DateExchange = txt_Year.Value.ToString("00") & txt_Month.Value.ToString("00") & CIntp(getData(Vs1, 0, Xrow)).ToString("00")
            '    W7199.VND = CDblp(getData(Vs1, 1, Xrow))
            '    W7199.VND_Tax = CDblp(getData(Vs1, 2, Xrow))
            '    W7199.KOR = CDblp(getData(Vs1, 3, Xrow))
            '    W7199.EURO = CDblp(getData(Vs1, 4, Xrow))
            'Else

            '    W7199.DateExchange = txt_Year.Value.ToString("00") & txt_Month.Value.ToString("00") & CIntp(getData(Vs1, 5, Xrow)).ToString("00")
            '    W7199.VND = CDblp(getData(Vs1, 6, Xrow))
            '    W7199.VND_Tax = CDblp(getData(Vs1, 7, Xrow))
            '    W7199.KOR = CDblp(getData(Vs1, 8, Xrow))
            '    W7199.EURO = CDblp(getData(Vs1, 9, Xrow))

            'End If

            'If READ_PFK7199(W7199.DateExchange) = False Then
            '    Call WRITE_PFK7199(W7199)
            'Else
            '    Call REWRITE_PFK7199(W7199)
            'End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Vs1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown
       

    End Sub
    'GOTFOCUS

    Private Sub Vs1_GotFocus(sender As Object, e As EventArgs) Handles Vs1.GotFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)
    End Sub



    'LOSTFOCUS

    Private Sub Vs1_LostFocus(sender As Object, e As EventArgs) Handles Vs1.LostFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False, WordConv("INSERT") & "(F5)")
    End Sub


    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        If DATA_SEARCH01() = True Then
        End If
    End Sub
 
#End Region

End Class