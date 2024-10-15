Public Class HLP3011A_AUTOKEY

#Region "Variable"
    Private Dsu01 As Long
    Protected prg As E_PRG

    Private W3011 As New T3011_AREA
    Private L3011 As New T3011_AREA

    Private Form_Close As Boolean

#End Region

#Region "Form_load"

    Friend Function Link_HLP3011Material(MaterialInboundNo As String, MaterialInBoundSeq As String) As Boolean
        Link_HLP3011Material = False
        Try

            If READ_PFK2351(MaterialInboundNo, MaterialInBoundSeq) Then
                txt_MaterialCode.Code = D2351.MaterialCode

                If READ_PFK7231(D2351.MaterialCode) Then
                    txt_MaterialCode.Data = D7231.MaterialName
                End If

                txt_ColorName.Data = D2351.ColorName

            End If


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

        chk_CheckDate.Checked = False





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
        VS1.Enabled = False

        DS1 = PrcDSVN("USP_HLP3011_AUTOKEY_SEARCH_APPROVAL_VS1", cn,
                                                        SdateEdate.text1,
                                                        SdateEdate.text2,
                                                        txt_cdSeason.Code,
                                                        txt_CustomerCode.Code,
                                                        txt_Article.Data,
                                                        txt_Line.Data,
                                                        txt_MaterialCode.Code,
                                                        txt_ColorName.Data,
                                                        "",
                                                        "",
                                                        chk_POYes.CheckState,
                                                        chk_POno.CheckState,
                                                        chk_CheckDate.CheckState)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(VS1, DS1, "USP_HLP3011_AUTOKEY_SEARCH_APPROVAL_VS1", "Vs1")
            VS1.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(VS1, DS1, "USP_HLP3011_AUTOKEY_SEARCH_APPROVAL_VS1", "Vs1")
        DATA_SEARCH_VS1 = True

        VS1.Enabled = True
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
    Private Sub vS1_GotFocus(sender As Object, e As EventArgs) Handles VS1.GotFocus
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

            hlp0000SeVa = getData(VS1, getColumIndex(VS1, "KEY_AUTOKEY"), VS1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVaTt = getData(VS1, getColumIndex(VS1, "KEY_AUTOKEY"), VS1.ActiveSheet.ActiveRowIndex)
            isudCHK = True
            Me.Dispose()
        Catch ex As Exception
            MsgBoxP("cmd_OK_Click!", vbCritical)
        End Try
    End Sub

    Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        isudCHK = False
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        Me.Dispose()
    End Sub

    Private Sub PeacePanalSeach_KeyDown(sender As Object, e As KeyEventArgs) Handles VS1.KeyDown
        If e.KeyCode = Keys.F And e.Control = True Then
            Exit Sub
        End If
    End Sub

#End Region

End Class