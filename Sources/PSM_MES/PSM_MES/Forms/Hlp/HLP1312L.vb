Public Class HLP1312L

#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Protected prg As E_PRG

    Private W1312 As New T1312_AREA
    Private L1312 As New T1312_AREA

    Private W1322 As New T1322_AREA
    Private L1322 As New T1322_AREA

    Private Form_Close As Boolean
    Private ShoesCode As String

#End Region

#Region "Form_load"
    Friend Function Link_HLP1312Material(Optional _ShoesCode As String = "") As Boolean
        Link_HLP1312Material = False

        ShoesCode = _ShoesCode

        txt_ShoesCode.Data = ShoesCode
        txt_ShoesCode.Code = ShoesCode

        chk_CheckDate.Checked = False

        If READ_PFK7106(ShoesCode) = False Then Exit Function

        txt_Article.Data = D7106.Article
        txt_Line.Data = D7106.Line
        txt_ColorCode.Data = D7106.ColorCode

        Call READ_PFK7171(ListCode("Season"), D7106.cdSeason)
        txt_cdSeason.Data = D7171.BasicName
        txt_cdSeason.Code = D7171.BasicCode

        Call READ_PFK7101(D7106.Customercode)
        txt_Customer.Data = D7101.CustomerName
        txt_CustomerCode.Data = D7101.CustomerName
        txt_CustomerCode.Code = D7101.CustomerCode
        Try
            Me.ShowDialog()

            Link_HLP1312Material = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Link_HLP1312Material"))
        End Try


    End Function

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.KeyPreview = True

        Call FORM_INIT()

        Call DATA_INIT()
        Call DATA_SEARCH_VS1()
    End Sub
    Private Sub HLP1312L_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
    Private Function DATA_SEARCH_VS1(Optional ByVal xsort As String = "1") As Boolean

        DATA_SEARCH_VS1 = False

        PeacePanalSeach.Enabled = False

        DS1 = PrcDSVN("USP_HLP1312L_SEARCH_VS1_01", cn, SdateEdate.text1,
                                                        SdateEdate.text2,
                                                        opt_CheckRelationType0.CheckState,
                                                        opt_CheckRelationType1.CheckState,
                                                        txt_ShoesCode.Data,
                                                        txt_cdSeason.Code,
                                                        txt_ColorCode.Data,
                                                        chk_CheckDate.CheckState)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(PeacePanalSeach, DS1, "USP_HLP1312L_SEARCH_VS1_01", "Vs1")
            PeacePanalSeach.Enabled = True

            Exit Function
        End If

        SPR_PRO_NEW(PeacePanalSeach, DS1, "USP_HLP1312L_SEARCH_VS1_01", "Vs1")

        Call VsSizeRangeNew(PeacePanalSeach, "USP_VS_SIZERANGE_SHOESCODEBASE", "SizeQty01", ShoesCode)

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
            Dim i As Integer

            Dim StrMsg As String

            StrMsg = MsgBox("Quan trọng ! Vui lòng kiểm tra kỹ khi matching ! Hệ thống tự động tạo yêu cầu ! Important! Please check carefully !", vbYesNo)

            If StrMsg <> vbYes Then Exit Sub

            Dim CheckValue As Boolean = False

            Call READ_PFK7106(ShoesCode)

            If FormatCutAll(READ_PFK7104_SZNO(D7106.SizeRange, txt_SizeSpecifize.Data)) = "" Then MsgBoxP("Size Wrong!") : Exit Sub

            For i = 0 To PeacePanalSeach.ActiveSheet.RowCount - 1
                If getDataM(PeacePanalSeach, getColumIndex(PeacePanalSeach, "CheckUse"), i) = "1" Then

                    If READ_PFK1312(getData(PeacePanalSeach, getColumIndex(PeacePanalSeach, "KEY_OrderNo"), i), getData(PeacePanalSeach, getColumIndex(PeacePanalSeach, "KEY_OrderNoSeq"), i)) Then
                        W1312 = D1312

                        W1312.SpeciticSize = txt_SizeSpecifize.Data
                        W1312.DateSize = Pub.SAW

                        If REWRITE_PFK1312(W1312) = True Then

                        End If

                    End If

                End If
            Next
          
            Me.Dispose()
        Catch ex As Exception
            MsgBoxP("cmd_OK_Click!", vbCritical)
        End Try
    End Sub

    Private Sub KEY_COUNT_K1322()
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader


        SQL = "SELECT MAX(CAST(K1322_MatchingAutoKey AS DECIMAL)) AS MAX_CODE FROM PFK1322 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            L1322.MatchingAutoKey = "00000001"
        Else
            L1322.MatchingAutoKey = Format(CInt(rd!MAX_CODE + 1), "00000000")
        End If

        W1322.MatchingAutoKey = L1322.MatchingAutoKey

        rd.Close()

    End Sub

    Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        isudCHK = False
        Me.Dispose()
    End Sub

#End Region


End Class