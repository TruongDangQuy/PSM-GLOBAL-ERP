Public Class HLP3011A_P

#Region "Variable"
    Private Dsu01 As Long
    Protected prg As E_PRG

    Private W3011 As New T3011_AREA
    Private L3011 As New T3011_AREA

    Private Form_Close As Boolean

#End Region

#Region "Form_load"
    Friend Function Link_HLP3011Material() As Boolean
        Link_HLP3011Material = False

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
        ssp_WHERE.Visible = True
    End Sub

    Private Sub DATA_INIT()
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""

        SdateEdate.text1 = Pub.DAT
        SdateEdate.text2 = Pub.DAT
    End Sub

#End Region

#Region "Function"

#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS1(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS1 = False
        PeacePanalSeach.Enabled = False

        DS1 = PrcDSVN("USP_HLP3011A_SEARCH_APPROVAL_VS1", cn,
                                                        SdateEdate.text1,
                                                        SdateEdate.text2,
                                                        txt_cdSeason.Code,
                                                        txt_Customer.Code,
                                                        txt_Article.Data,
                                                        txt_Line.Data,
                                                        txt_MaterialCode.Data,
                                                        txt_cdLargeGroupMaterial.Code,
                                                        txt_cdSemiGroupMaterial.Code,
                                                        txt_cdDetailGroupMaterial.Code,
                                                        chk_POYes.CheckState,
                                                        chk_POno.CheckState,
                                                        chk_CheckDate.CheckState)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(PeacePanalSeach, DS1, "USP_HLP3011A_SEARCH_APPROVAL_VS1", "Vs1")
            PeacePanalSeach.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(PeacePanalSeach, DS1, "USP_HLP3011A_SEARCH_APPROVAL_VS1", "Vs1")
        DATA_SEARCH_VS1 = True

        PeacePanalSeach.Enabled = True
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
            ssp_WHERE.Visible = False
        Else                                        '
            chk_FSEL.BackColor = clrCheck
            chk_FSEL.ForeColor = Color.Black

            chk_FSEL.Text = WordConv("CLOSE")
            ssp_WHERE.Visible = True
        End If
    End Sub
    Private Sub vS1_GotFocus(sender As Object, e As EventArgs) Handles PeacePanalSeach.GotFocus
        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False
    End Sub


    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False
        Call DATA_SEARCH_VS1()
    End Sub

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        Dim i As Integer
        Dim CheckValue As Boolean = False

        Try

            For i = 0 To PeacePanalSeach.ActiveSheet.RowCount - 1
                If getDataM(PeacePanalSeach, getColumIndex(PeacePanalSeach, "CheckUse"), i) = "1" And CIntp(getData(PeacePanalSeach, getColumIndex(PeacePanalSeach, "KEY_Autokey"), i)) > 0 Then
                    CheckValue = True
                    hlp0000SeVa &= getData(PeacePanalSeach, getColumIndex(PeacePanalSeach, "KEY_Autokey"), i) & "|"
                End If
            Next

            hlp0000SeVa = Strings.Left(hlp0000SeVa, Len(hlp0000SeVa) - 1)
            hlp0000SeVaTt = hlp0000SeVa
            isudCHK = True

            If CheckValue = False Then
                hlp0000SeVa = ""
                hlp0000SeVaTt = ""
                isudCHK = False
            End If
            Me.Dispose()
        Catch ex As Exception
            MsgBoxP("cmd_OK_Click!", vbCritical)
        End Try
    End Sub

    Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        isudCHK = False
        Me.Dispose()
    End Sub

    Private Sub PeacePanalSeach_KeyDown(sender As Object, e As KeyEventArgs) Handles PeacePanalSeach.KeyDown
        If e.KeyCode = Keys.F And e.Control = True Then
            Exit Sub
        End If
    End Sub

#End Region
    
End Class