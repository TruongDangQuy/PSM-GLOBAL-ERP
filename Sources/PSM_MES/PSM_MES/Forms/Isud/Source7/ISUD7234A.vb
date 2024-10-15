Public Class ISUD7234A

#Region "Variable"
    Private wJOB As Integer

    Private W7234 As New T7234_AREA
    Private L7234 As New T7234_AREA


    Private ExportTax As Decimal
    Private EnvironmentTax As Decimal
    Private VatTax As Decimal

    Private WRITE_CHK As String
    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7234A(job As Integer, MaterialCode As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D7234.MaterialCode = MaterialCode

        wJOB = job : L7234 = D7234
        txt_MaterialCode.Data = MaterialCode

        Link_ISUD7234A = False
        Try

            Select Case job
                Case 1
                Case Else

            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD7234A = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))
        End Try


    End Function
#End Region

#Region "Form"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub
        WRITE_CHK = ""
        Me.Form_KeyDown()

        Call DATA_INIT()
        Call FORM_INIT()

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        Select Case wJOB
            Case 1                                                      'ÀÔ·Â
                Me.Text = Me.Text & " - INSERT"
                Frame1.Enabled = True
                tst_iDelete.Visible = False

                Call KEY_COUNT()

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCHvS1()
            Case 2
                Me.Text = Me.Text & " - SEARCH"

                Frame1.Enabled = True
                tst_iDelete.Visible = False
                tst_iSave.Visible = False

                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCHvS1()
            Case 3
                Me.Text = Me.Text & " - UPDATE"

                Frame1.Enabled = True
                txt_MaterialCode.Enabled = False
                tst_iDelete.Visible = False
                Call DATA_SEARCHvS1()

                If CHK(3) <> "1" Then
                    If CHK(2) <> "1" Then
                        isudCHK = False
                        Me.Dispose()
                        formA = True
                        Call MsgBoxP("You have no right is this program !")
                        Exit Sub
                    Else

                        Me.Text = Me.Text & " - SEARCH"
                        isudCHK = False
                        formA = True
                        wJOB = 2
                        tst_iDelete.Visible = False
                        Call MsgBoxP("Only Search !") : tst_iSave.Visible = False
                    End If
                End If

            Case 4                                                      '»èÁ¦
                Me.Text = Me.Text & " - DELETE"

                tst_iSave.Visible = False

                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCHvS1()

        End Select

        formA = True
    End Sub
    Private Sub DATA_INIT()

        tst_iPrint.Visible = False
        tst_iUtilities.Visible = True
        tst_iAttach.Visible = True
        tst_iHistory.Visible = False
    End Sub

    Private Sub FORM_INIT()

    End Sub
#End Region

#Region "Search"

    Private Function DATA_SEARCHvS1() As Boolean
        DATA_SEARCHvS1 = False

        If READ_PFK7231(L7234.MaterialCode) = True Then
            txt_MaterialName.Data = D7231.MaterialName
        End If

        DS1 = PrcDS("USP_ISUD7234A_SEARCH_VS1", cn, L7234.MaterialCode)


        If GetDsRc(DS1) = 0 Then
            SPR_SET(Vs1, , , , OperationMode.Normal)
            SPR_PRO(Vs1, DS1, "USP_ISUD7234A_SEARCH_VS1", "Vs1")
            Vs1.ActiveSheet.RowCount = 10
            Vs1.Enabled = True
            Exit Function
        End If

        SPR_SET(Vs1, , , , OperationMode.Normal)
        SPR_PRO(Vs1, DS1, "USP_ISUD7234A_SEARCH_VS1", "Vs1")

        DATA_SEARCHvS1 = True


    End Function

#End Region

#Region "Function"
    Private Sub DATA_MOVE()



    End Sub

    Private Sub DATA_MOVE_WRITE01()
        Dim i As Integer
        Dim j As Integer
        j = 0
        For i = 0 To Vs1.ActiveSheet.RowCount - 1
            'If Trim(getData(Vs1, getColumIndex(Vs1, "cdUnitPacking"), i)) = "" Then GoTo skip
            If Trim(getData(Vs1, getColumIndex(Vs1, "cdUnitMaterial"), i)) = "" Then GoTo skip

            j = j + 1
            If K7234_MOVE(Vs1, i, W7234, txt_MaterialCode.Data, getData(Vs1, getColumIndex(Vs1, "KEY_PackingSeq"), i)) = True Then
                W7234.seUnitMaterial = ListCode("UnitMaterial")
                W7234.seUnitPacking = ListCode("UnitPacking")

                Call REWRITE_PFK7234(W7234)
            Else
                W7234.MaterialCode = L7234.MaterialCode
                W7234.seUnitMaterial = ListCode("UnitMaterial")
                W7234.seUnitPacking = ListCode("UnitPacking")

                KEY_COUNT()
                If WRITE_PFK7234(W7234) = True Then
                    isudCHK = True
                End If
            End If
skip:
        Next
    End Sub

    Private Sub DATA_UPDATE()
        Try
            Call DATA_MOVE_WRITE01()
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

    Private Sub DATA_DELETE()
        Try
            Dim i As Integer

            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If K7234_MOVE(Vs1, i, W7234, txt_MaterialCode.Data, getData(Vs1, getColumIndex(Vs1, "KEY_PackingSeq"), i)) = True Then

                    If DELETE_PFK7234(W7234) = True Then isudCHK = True

                End If
skip:
            Next
        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub

    Private Sub KEY_COUNT()

        Dim YRNO As Integer
        YRNO = Mid(System_Date_8(), 3, 4)

        Try
            SQL = "SELECT MAX(K7234_PackingSeq) AS MAX_MCODE FROM PFK7234 "
            SQL = SQL & " WHERE K7234_MaterialCode = '" & txt_MaterialCode.Data & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W7234.PackingSeq = 1
            Else
                W7234.PackingSeq = Format(CInt(rd!MAX_MCODE + 1))
            End If

            rd.Close()

            L7234.PackingSeq = W7234.PackingSeq

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

#End Region

#Region "Event"
    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        Select Case wJOB
            Case 1
                If DataCheck(Me, "PFK7234") = False Then Exit Sub

                Call DATA_MOVE_WRITE01()
                Call DATA_SEARCHvS1()
                wJOB = 3
            Case 2
                Me.Dispose()
            Case 3
                If DataCheck(Me, "PFK7234") = False Then Exit Sub
                Call DATA_MOVE_WRITE01()
                Call DATA_SEARCHvS1()
            Case 4
                Call DATA_DELETE()
        End Select
    End Sub

    Private Sub tst_iClose_Click(sender As Object, e As EventArgs) Handles tst_iClose.Click
        If WRITE_CHK = "*" Then
            isudCHK = True
        Else
            isudCHK = False
        End If

        Me.Dispose()
    End Sub

    Private Sub tst_iDelete_Click(sender As Object, e As EventArgs) Handles tst_iDelete.Click
        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        If CHK(4) <> "1" Then
            Call MsgBoxP("4", "tst_iDelete_Click")
            Exit Sub
        End If

        Dim str As String = MsgBoxP("Do you want to delete it?", vbYesNo)

        If str <> vbYes Then Exit Sub

        Call DATA_DELETE()
        Me.Dispose()

    End Sub

    Private Sub Vs1_ButtonClicked(sender As Object, e As EditorNotifyEventArgs) Handles Vs1.ButtonClicked
        Dim xrow As Integer
        xrow = e.Row

        Select Case e.Column
            Case getColumIndex(Vs1, "cdMaterialCode")
                Dim f As New Form
                f = New HLP7231C
                f.ShowDialog()
                If hlp0000SeVaTt = "" Or hlp0000SeVa = "" Then Exit Sub
                If READ_PFK7231(hlp0000SeVaTt) = True Then
                    setData(Vs1, getColumIndex(Vs1, "MaterialCode"), xrow, D7231.MaterialCode)
                    setData(Vs1, getColumIndex(Vs1, "MaterialName"), xrow, D7231.MaterialName)
                    If READ_PFK7171(Const_UnitMaterial, D7231.cdUnitMaterial) = True Then
                        setData(Vs1, getColumIndex(Vs1, "cdUnitMaterialName"), xrow, D7171.BasicName)
                    End If
                End If

            Case getColumIndex(Vs1, "cdUnitPrice")
                HLPCHECK("Const_UnitPrice")
                If hlp0000SeVa = "" Or hlp0000SeVaTt = "" Then Exit Sub
                setData(Vs1, getColumIndex(Vs1, "cdUnitPrice"), xrow, hlp0000SeVaTt)
                setData(Vs1, getColumIndex(Vs1, "cdUnitPriceExpenseName"), xrow, hlp0000SeVa)

        End Select

        vSChange(e.Row)

    End Sub

    Private Sub Vs1_Change(sender As Object, e As ChangeEventArgs) Handles Vs1.Change
        Dim xCOL As Long
        Dim xROW As Long

        Try

            xROW = e.Row
            xCOL = e.Column

            vSChange(xROW)



        Catch ex As Exception

        End Try

    End Sub

    Private Sub vSChange(xROW As Integer)
        'Try

        '    Dim AmountExpenseUSD As Decimal
        '    Dim AmountExpenseVND As Decimal
        '    Dim PriceExpenseUSD As Decimal
        '    Dim PriceExpenseVND As Decimal

        '    Dim cdUnitMaterialName As Decimal
        '    Dim BoxExpense As Decimal
        '    Dim QtyExpense As Decimal

        '    If CDecp(L2001.PriceExchange) = 0 Then Exit Sub

        '    PriceExpenseVND = CDecp(getData(Vs1, getColumIndex(Vs1, "PriceExpenseVND"), xROW))
        '    PriceExpenseUSD = PriceExpenseVND / L2001.PriceExchange

        '    BoxExpense = CDecp(getData(Vs1, getColumIndex(Vs1, "BoxExpense"), xROW))

        '    cdUnitMaterialName = CDecp(getData(Vs1, getColumIndex(Vs1, "cdUnitMaterialName"), xROW))

        '    QtyExpense = cdUnitMaterialName * BoxExpense


        '    If CDecp(getData(Vs1, getColumIndex(Vs1, "PriceExpenseVND"), xROW)) >= 0 And CDecp(getData(Vs1, getColumIndex(Vs1, "BoxExpense"), xROW)) > 0 Then
        '        setData(Vs1, getColumIndex(Vs1, "PriceExpenseUSD"), xROW, PriceExpenseUSD)
        '        setData(Vs1, getColumIndex(Vs1, "PriceExpenseVND"), xROW, PriceExpenseVND)

        '        AmountExpenseUSD = PriceExpenseUSD * BoxExpense
        '        AmountExpenseVND = PriceExpenseVND * BoxExpense

        '        setData(Vs1, getColumIndex(Vs1, "BoxExpense"), xROW, BoxExpense)
        '        setData(Vs1, getColumIndex(Vs1, "QtyExpense"), xROW, QtyExpense)
        '        setData(Vs1, getColumIndex(Vs1, "AmountExpenseVND"), xROW, AmountExpenseVND)
        '        setData(Vs1, getColumIndex(Vs1, "AmountExpenseUSD"), xROW, AmountExpenseUSD)
        '    End If

        'Catch ex As Exception
        '    MsgBoxP("vSChange")
        'End Try
    End Sub

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub

    Private Sub vS1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown
        If wJOB = 2 Then Exit Sub

        Dim xCOL As Long
        Dim xROW As Long

        xCOL = Vs1.ActiveSheet.ActiveColumnIndex
        xROW = Vs1.ActiveSheet.ActiveRowIndex

        Select Case e.KeyCode
            Case Keys.Insert

            Case Keys.Delete

                Msg_Result = MsgBoxP("Do you want to delete?", vbYesNo)

                If Msg_Result <> vbYes Then Exit Sub

                If K7234_MOVE(Vs1, xROW, W7234, txt_MaterialCode.Data, getData(Vs1, getColumIndex(Vs1, "KEY_PackingSeq"), xROW)) Then
                    If DELETE_PFK7234(W7234) = True Then
                        isudCHK = True
                    End If
                End If

                SPR_DEL(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex)
                Vs1.Focus()
            Case Keys.Enter
                

                vSChange(xROW)
        End Select
    End Sub
#End Region

End Class