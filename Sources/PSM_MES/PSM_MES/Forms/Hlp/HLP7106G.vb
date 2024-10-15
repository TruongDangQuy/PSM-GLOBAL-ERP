Public Class HLP7106G

#Region "Variable"

    Protected prg As E_PRG
    Private Dsu01 As Long
    Private Dsu02 As Long
    Private Dsu03 As Long
    Private W7106 As T7106_AREA

    Private Form_Close As Boolean

#End Region

#Region "Formload"

    Friend Function Link_HLP7106G(Optional ShoesCode As String = "") As Boolean
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        hlp0000SeVaTt1 = ""

        Link_HLP7106G = False

        txt_ShoesCode.Code = ShoesCode
        txt_ShoesCode.Data = ShoesCode

        Call DATA_SEARCH()

        txt_ShoesCode.Enabled = False

        Try
            Me.ShowDialog()

            Link_HLP7106G = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Link_HLP7106G"))
        End Try


    End Function

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        hlp0000SeVaTt1 = ""
        Me.KeyPreview = True
        Call DATA_INIT()

    End Sub
    Private Function DATA_SEARCH() As Boolean

        DATA_SEARCH = False

        DS1 = READ_PFK7106(txt_ShoesCode.Data, cn)

        If GetDsRc(DS1) = 0 Then
            Exit Function
            isudCHK = False
        End If

        READER_MOVE(Me, DS1)

        DATA_SEARCH = True

    End Function
    Private Sub Me_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
    End Sub

    Private Sub DATA_INIT()
        Try
            If Trim$(txt_ShoesCode.Code) <> "" Then
                DATA_SEARCH_VS1()
            End If
        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "PFP_SEARCH"
    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False


        Vs1.Enabled = False

        DS1 = PrcDS("USP_HLP7106G_SEARCH_VS1", cn, txt_ShoesCode.Data)

        If GetDsRc(DS1) = 0 Then
            DS2 = PrcDS("USP_HLP7106G_SEARCH_VS1_INSERT", cn, txt_ShoesCode.Data, ListCode("SizeGroup"))
            SPR_PRO_NEW(Vs1, DS2, "USP_HLP7106G_SEARCH_VS1", "VS1")
            SPR_INSERT(Vs1)
            Vs1.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "USP_HLP7106G_SEARCH_VS1", "VS1")
        DATA_SEARCH_VS1 = True

        Vs1.Enabled = True

    End Function



#End Region

#Region "EVENT"
    Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        hlp0000SeVaTt1 = ""
        isudCHK = False
        Me.Close()
    End Sub
    Private Sub Vs1_CellClick1(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        If e.ColumnHeader = True Then Exit Sub
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub

    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        cmd_OK.PerformClick()
    End Sub

    Private Sub Vs1_KeyUp(sender As Object, e As KeyEventArgs) Handles Vs1.KeyUp
        Select Case e.KeyCode
            Case Keys.Down, Keys.Up, Keys.PageDown, Keys.PageUp
        End Select
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        Try
            DATA_SEARCH_VS1()
        Catch ex As Exception
            MsgBoxP("cmd_SEARCH_Click")
        End Try
    End Sub

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Try
            If READ_PFK7205(getData(Vs1, getColumIndex(Vs1, "KEY_ShoesCode"), Vs1.ActiveSheet.ActiveRowIndex),
                                   getData(Vs1, getColumIndex(Vs1, "KEY_seSizeGroup"), Vs1.ActiveSheet.ActiveRowIndex),
                                   getData(Vs1, getColumIndex(Vs1, "KEY_cdSizeGroup"), Vs1.ActiveSheet.ActiveRowIndex)) Then

                D7205.Size01 = getData(Vs1, getColumIndex(Vs1, "Size01"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size02 = getData(Vs1, getColumIndex(Vs1, "Size02"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size03 = getData(Vs1, getColumIndex(Vs1, "Size03"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size04 = getData(Vs1, getColumIndex(Vs1, "Size04"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size05 = getData(Vs1, getColumIndex(Vs1, "Size05"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size06 = getData(Vs1, getColumIndex(Vs1, "Size06"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size07 = getData(Vs1, getColumIndex(Vs1, "Size07"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size08 = getData(Vs1, getColumIndex(Vs1, "Size08"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size09 = getData(Vs1, getColumIndex(Vs1, "Size09"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size10 = getData(Vs1, getColumIndex(Vs1, "Size10"), Vs1.ActiveSheet.ActiveRowIndex)

                D7205.Size11 = getData(Vs1, getColumIndex(Vs1, "Size11"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size12 = getData(Vs1, getColumIndex(Vs1, "Size12"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size13 = getData(Vs1, getColumIndex(Vs1, "Size13"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size14 = getData(Vs1, getColumIndex(Vs1, "Size14"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size15 = getData(Vs1, getColumIndex(Vs1, "Size15"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size16 = getData(Vs1, getColumIndex(Vs1, "Size16"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size17 = getData(Vs1, getColumIndex(Vs1, "Size17"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size18 = getData(Vs1, getColumIndex(Vs1, "Size18"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size19 = getData(Vs1, getColumIndex(Vs1, "Size19"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size20 = getData(Vs1, getColumIndex(Vs1, "Size20"), Vs1.ActiveSheet.ActiveRowIndex)

                D7205.Size21 = getData(Vs1, getColumIndex(Vs1, "Size21"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size22 = getData(Vs1, getColumIndex(Vs1, "Size22"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size23 = getData(Vs1, getColumIndex(Vs1, "Size23"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size24 = getData(Vs1, getColumIndex(Vs1, "Size24"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size25 = getData(Vs1, getColumIndex(Vs1, "Size25"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size26 = getData(Vs1, getColumIndex(Vs1, "Size26"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size27 = getData(Vs1, getColumIndex(Vs1, "Size27"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size28 = getData(Vs1, getColumIndex(Vs1, "Size28"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size29 = getData(Vs1, getColumIndex(Vs1, "Size29"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size30 = getData(Vs1, getColumIndex(Vs1, "Size30"), Vs1.ActiveSheet.ActiveRowIndex)

                Call REWRITE_PFK7205(D7205)

            Else
                D7205.ShoesCode = getData(Vs1, getColumIndex(Vs1, "KEY_ShoesCode"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.seSizeGroup = ListCode("SizeGroup")
                D7205.cdSizeGroup = getData(Vs1, getColumIndex(Vs1, "cdSizeGroup"), Vs1.ActiveSheet.ActiveRowIndex)

                D7205.Size01 = getData(Vs1, getColumIndex(Vs1, "Size01"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size02 = getData(Vs1, getColumIndex(Vs1, "Size02"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size03 = getData(Vs1, getColumIndex(Vs1, "Size03"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size04 = getData(Vs1, getColumIndex(Vs1, "Size04"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size05 = getData(Vs1, getColumIndex(Vs1, "Size05"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size06 = getData(Vs1, getColumIndex(Vs1, "Size06"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size07 = getData(Vs1, getColumIndex(Vs1, "Size07"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size08 = getData(Vs1, getColumIndex(Vs1, "Size08"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size09 = getData(Vs1, getColumIndex(Vs1, "Size09"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size10 = getData(Vs1, getColumIndex(Vs1, "Size10"), Vs1.ActiveSheet.ActiveRowIndex)

                D7205.Size11 = getData(Vs1, getColumIndex(Vs1, "Size11"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size12 = getData(Vs1, getColumIndex(Vs1, "Size12"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size13 = getData(Vs1, getColumIndex(Vs1, "Size13"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size14 = getData(Vs1, getColumIndex(Vs1, "Size14"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size15 = getData(Vs1, getColumIndex(Vs1, "Size15"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size16 = getData(Vs1, getColumIndex(Vs1, "Size16"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size17 = getData(Vs1, getColumIndex(Vs1, "Size17"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size18 = getData(Vs1, getColumIndex(Vs1, "Size18"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size19 = getData(Vs1, getColumIndex(Vs1, "Size19"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size20 = getData(Vs1, getColumIndex(Vs1, "Size20"), Vs1.ActiveSheet.ActiveRowIndex)

                D7205.Size21 = getData(Vs1, getColumIndex(Vs1, "Size21"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size22 = getData(Vs1, getColumIndex(Vs1, "Size22"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size23 = getData(Vs1, getColumIndex(Vs1, "Size23"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size24 = getData(Vs1, getColumIndex(Vs1, "Size24"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size25 = getData(Vs1, getColumIndex(Vs1, "Size25"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size26 = getData(Vs1, getColumIndex(Vs1, "Size26"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size27 = getData(Vs1, getColumIndex(Vs1, "Size27"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size28 = getData(Vs1, getColumIndex(Vs1, "Size28"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size29 = getData(Vs1, getColumIndex(Vs1, "Size29"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size30 = getData(Vs1, getColumIndex(Vs1, "Size30"), Vs1.ActiveSheet.ActiveRowIndex)

                Call WRITE_PFK7205(D7205)
            End If


            If READ_PFK7106(txt_ShoesCode.Data) Then
                W7106 = D7106

                Call DATA_MOVE()

                W7106.DateUpdate = Pub.DAT
                W7106.InchargeUpdate = Pub.SAW
                If REWRITE_PFK7106(W7106) = True Then isudCHK = True

            End If

        Catch ex As Exception
            MsgBoxP("cmd_OK_Click")
        End Try
    End Sub

    Private Sub DATA_MOVE()

        W7106.OutsoleColor = txt_OutsoleColor.Data
        W7106.LogoColor = txt_LogoColor.Data

        W7106.OutsoleColorCode = txt_OutsoleColorCode.Data
        W7106.LogoColorCode = txt_LogoColorCode.Data

        W7106.MoldCode = txt_MoldCode.Code

        W7106.MidsoleColor = txt_MidsoleColor.Data
        W7106.InsoleColor = txt_InsoleColor.Data

    End Sub

#End Region

End Class