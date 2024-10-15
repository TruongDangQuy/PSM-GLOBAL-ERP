Public Class HLP1312B

#Region "Variable"

#End Region

#Region "Form_load"
    Friend Function Link_HLP1312B(Optional Chk_Order As String = "0") As Boolean
        Link_HLP1312B = False

        Try
            Me.ShowDialog()

            Link_HLP1312B = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Link_HLP1312B"))
        End Try


    End Function

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.KeyPreview = True

        Call FORM_INIT()

        Call DATA_INIT()

    End Sub
    Private Sub HLP1312A_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

        Setfocus(txt_cdSeason)

    End Sub

    Private Sub DATA_INIT()
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""

        SdateEdate.text1 = Pub.DAT
        SdateEdate.text2 = Pub.DAT
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
    Private Sub vS1_GotFocus(sender As Object, e As EventArgs) Handles PeacePanalSeach.GotFocus
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
    Private Function DATA_SEARCH_VS1(Optional ByVal xsort As String = "1") As Boolean

        DATA_SEARCH_VS1 = False

        PeacePanalSeach.Enabled = False

        DS1 = PrcDSVN("USP_HLP1312B_SEARCH_VS1", cn, SdateEdate.text1,
                                                        SdateEdate.text2,
                                                        txt_cdSeason.Code,
                                                        txt_CustomerCode.Code,
                                                        txt_Customer.Data,
                                                        txt_Article.Data,
                                                        txt_Line.Data,
                                                        chk_CheckDate.CheckState)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(PeacePanalSeach, DS1, "USP_HLP1312B_SEARCH_VS1", "Vs1")
            PeacePanalSeach.Enabled = True

            Exit Function
        End If

        SPR_PRO_NEW(PeacePanalSeach, DS1, "USP_HLP1312B_SEARCH_VS1", "Vs1")
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
            hlp0000SeVa = ""
            hlp0000SeVaTt = ""
            hlp0000SeVaTt1 = ""

            If Trim(getData(PeacePanalSeach, getColumIndex(PeacePanalSeach, "KEY_OrderNo"), PeacePanalSeach.ActiveSheet.ActiveRowIndex)) <> "" Then
                hlp0000SeVa = getData(PeacePanalSeach, getColumIndex(PeacePanalSeach, "KEY_OrderNo"), PeacePanalSeach.ActiveSheet.ActiveRowIndex)
                hlp0000SeVaTt = getData(PeacePanalSeach, getColumIndex(PeacePanalSeach, "KEY_OrderNoSeq"), PeacePanalSeach.ActiveSheet.ActiveRowIndex)
                hlp0000SeVaTt1 = getData(PeacePanalSeach, getColumIndex(PeacePanalSeach, "KEY_SLNo"), PeacePanalSeach.ActiveSheet.ActiveRowIndex)
                isudCHK = True
            End If
            Me.Dispose()
        Catch ex As Exception
            MsgBoxP("cmd_OK_Click!", vbCritical)
        End Try
    End Sub

    Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        isudCHK = False
        Me.Dispose()
    End Sub

    Private Sub PeacePanalSeach_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles PeacePanalSeach.CellDoubleClick
        cmd_OK.PerformClick()
    End Sub

#End Region


End Class