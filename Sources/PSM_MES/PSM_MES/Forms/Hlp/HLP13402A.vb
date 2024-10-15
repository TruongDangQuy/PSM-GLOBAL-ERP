Public Class HLP13402A

#Region "Variable"
    Private Dsu01 As Long
    Protected prg As E_PRG

    Private W3011 As New T3011_AREA
    Private L3011 As New T3011_AREA

    Private Form_Close As Boolean
    Private strsite As String
    Private strYear As String
    Private strItemCode As String
    Private strItemCodeFG As String
    Private strintColum As String

#End Region

#Region "Form_load"

    Friend Function Link_HLP3011Material(intColum As Integer, site As String, Year As String, ItemCode As String, ItemCodeFG As String) As Boolean
        Link_HLP3011Material = False

        strsite = site
        strYear = Year
        strItemCode = ItemCode
        strItemCodeFG = ItemCodeFG

        strintColum = intColum


        Try


            Call DATA_SEARCH_VS1()

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
    End Sub
    Private Sub HLP3011A_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub
    Overrides Sub Function_Event(PressKey As Integer)
        Try
            Select Case PressKey

            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FORM_INIT()
        chk_FSEL.CheckState = 1
        chk_FSEL.BackColor = clrCheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("CLOSE")



    End Sub

    Private Sub DATA_INIT()
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""


    End Sub

#End Region

#Region "Function"

#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS1(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS1 = False
        vs1.Enabled = False

        DS1 = PrcDSVN("USP_HLP13402A_SEARCH_VS1", cn, strintColum, strsite, strYear, strItemCode, strItemCodeFG)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vs1, DS1, "USP_HLP13402A_SEARCH_VS1", "Vs1")
            vs1.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vs1, DS1, "USP_HLP13402A_SEARCH_VS1", "Vs1")
        DATA_SEARCH_VS1 = True

        vs1.Enabled = True
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
    Private Sub chk_FSEL_Click(sender As Object, e As EventArgs) Handles chk_FSEL.CheckedChanged
        If chk_FSEL.CheckState = 0 Then                  '
            chk_FSEL.BackColor = clrUncheck
            chk_FSEL.ForeColor = Color.Black

            chk_FSEL.Text = WordConv("OPEN")

        Else                                        '
            chk_FSEL.BackColor = clrCheck
            chk_FSEL.ForeColor = Color.Black

            chk_FSEL.Text = WordConv("CLOSE")

        End If
    End Sub
    Private Sub vS1_GotFocus(sender As Object, e As EventArgs) Handles vs1.GotFocus
        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")

    End Sub


    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")

        Call DATA_SEARCH_VS1()
    End Sub

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        Dim i As Integer
        Dim CheckValue As Boolean = False

        Try

   
            isudCHK = True


            Me.Dispose()
        Catch ex As Exception
            MsgBoxP("cmd_OK_Click!", vbCritical)
        End Try
    End Sub

    Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        isudCHK = False
        Me.Dispose()
    End Sub

    Private Sub PeacePanalSeach_KeyDown(sender As Object, e As KeyEventArgs) Handles vs1.KeyDown
        If e.KeyCode = Keys.F And e.Control = True Then
            Exit Sub
        End If
    End Sub

#End Region

End Class