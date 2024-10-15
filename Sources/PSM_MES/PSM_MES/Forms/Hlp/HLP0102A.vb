Public Class HLP0102A

#Region "Variable"
    Private Dsu01 As Long
    Protected prg As E_PRG

    Private W0102 As New T0102_AREA
    Private L0102 As New T0102_AREA

    Private Form_Close As Boolean

#End Region

#Region "Form_load"
    Friend Function Link_HLP0102(Optional Article As String = "", Optional Line As String = "") As Boolean

        Link_HLP0102 = False
        txt_Article.Data = Article
        txt_Line.Data = Line

        Try
            Me.ShowDialog()

            Link_HLP0102 = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Link_HLP0102"))
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
    Private Function DATA_SEARCH01(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH01 = False
        PeacePanalSeach.Enabled = False
        Dim OrderRnDStatus As String
        Try

            If opt_SEL0.Checked = True Then OrderRnDStatus = "1"
            If opt_SEL1.Checked = True Then OrderRnDStatus = "2"
            If opt_SEL2.Checked = True Then OrderRnDStatus = "3"
            If opt_SEL3.Checked = True Then OrderRnDStatus = "4"
            If opt_SEL4.Checked = True Then OrderRnDStatus = "5"
            If opt_SEL5.Checked = True Then OrderRnDStatus = "9"

            OrderRnDStatus = "9"

            DS1 = PrcDSVN("USP_HLP0101_SEARCH_VS1", cn,
                                                        SdateEdate.text1,
                                                        SdateEdate.text2,
                                                        txt_SpecNo.Data,
                                                        txt_Article.Data,
                                                        txt_Line.Data,
                                                        txt_MaterialSCode.Data,
                                                        OrderRnDStatus)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(PeacePanalSeach, DS1, "USP_HLP01010_SEARCH_VS1", "Vs1")
                PeacePanalSeach.Enabled = True

                Exit Function
            End If

            SPR_PRO_NEW(PeacePanalSeach, DS1, "USP_HLP0101_SEARCH_VS1", "Vs1")
            DATA_SEARCH01 = True

            PeacePanalSeach.Enabled = True

        Catch ex As Exception

        End Try

    End Function

#End Region

#Region "Event"

    Private Sub Vs1_CellClick1(sender As Object, e As CellClickEventArgs) Handles PeacePanalSeach.CellClick
        If e.ColumnHeader = True Then Exit Sub
        PeacePanalSeach.ActiveSheet.ActiveRowIndex = e.Row
        PeacePanalSeach.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub


    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click

        Try
            chk_FSEL.CheckState = 0
            chk_FSEL.BackColor = clrUncheck
            chk_FSEL.ForeColor = Color.Black

            chk_FSEL.Text = WordConv("OPEN")
            ssp_WHERE.Visible = False

            Call DATA_SEARCH01()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Try
            If getData(PeacePanalSeach, 0, PeacePanalSeach.ActiveSheet.ActiveRowIndex) IsNot Nothing Then
                If getData(PeacePanalSeach, 0, PeacePanalSeach.ActiveSheet.ActiveRowIndex) <> "" Then
                    hlp0000SeVa = getData(PeacePanalSeach, 1, PeacePanalSeach.ActiveSheet.ActiveRowIndex)
                    hlp0000SeVaTt = getData(PeacePanalSeach, 0, PeacePanalSeach.ActiveSheet.ActiveRowIndex)

                    isudCHK = True
                End If
            Else
                hlp0000SeVa = ""
                hlp0000SeVaTt = ""

                isudCHK = False
            End If
            Me.Close()
        Catch ex As Exception
            MsgBoxP("cmd_OK_Click!", vbCritical)
        End Try
    End Sub

    Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""

        isudCHK = False
        Me.Close()
    End Sub

#End Region


End Class