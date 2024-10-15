Public Class ISUD7232A

#Region "Variable"
    Private wJOB As Integer

    Private W7232 As New T7232_AREA
    Private L7232 As New T7232_AREA

    Private W7231 As New T7231_AREA
    Private ExportTax As Decimal
    Private EnvironmentTax As Decimal
    Private VatTax As Decimal

    Private WRITE_CHK As String
    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7232A(job As Integer, MaterialCode As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D7232.MaterialCode = MaterialCode

        wJOB = job : L7232 = D7232
        txt_MaterialCode.Data = MaterialCode

        Link_ISUD7232A = False
        Try

            Select Case job
                Case 1
                Case Else

            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD7232A = isudCHK


        Catch ex As Exception
            '           Call MsgBoxP("61", WordConv("YARN PROCESSING"))
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
                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Frame1.Enabled = True
                tst_iDelete.Visible = False

                Call KEY_COUNT()
                Call DATA_SEARCHvS1()
            Case 2
                Me.Text = Me.Text & " - SEARCH"
                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Frame1.Enabled = True
                tst_iDelete.Visible = False
                tst_iSave.Visible = False

                Call DATA_SEARCHvS1()
            Case 3
                Me.Text = Me.Text & " - UPDATE"
                If CHK(3) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                txt_MaterialCode.Enabled = False

                Frame1.Enabled = True
                tst_iDelete.Visible = False
                tst_iSave.Visible = True

                Call DATA_SEARCHvS1()
            Case 4                                                      '»èÁ¦
                Me.Text = Me.Text & " - DELETE"
                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                tst_iSave.Visible = False
                tst_iDelete.Visible = True

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

        If READ_PFK7231(L7232.MaterialCode) = True Then
            txt_MaterialName.Data = D7231.MaterialName
        End If

        DS1 = PrcDS("USP_ISUD7232A_SEARCH_VS1", cn, L7232.MaterialCode)


        If GetDsRc(DS1) = 0 Then
            SPR_SET(Vs1, , , , OperationMode.Normal)
            SPR_PRO(Vs1, DS1, "USP_ISUD7232A_SEARCH_VS1", "Vs1")
            Vs1.ActiveSheet.RowCount = 10
            Vs1.Enabled = True
            Exit Function
        End If

        SPR_SET(Vs1, , , , OperationMode.Normal)
        SPR_PRO(Vs1, DS1, "USP_ISUD7232A_SEARCH_VS1", "Vs1")

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
            If Trim(getData(Vs1, getColumIndex(Vs1, "MaterialName"), i)) = "" Then GoTo skip

            j = j + 1
            If K7232_MOVE(Vs1, i, W7232, txt_MaterialCode.Data, getData(Vs1, getColumIndex(Vs1, "KEY_MaterialCodeSeq"), i)) = True Then
                W7232.Dseq = j
                If REWRITE_PFK7232(W7232) Then

                    If READ_PFK7231(W7232.MaterialCodeBom) Then
                        W7231 = D7231
                        W7231.Check1 = "1"
                        Call REWRITE_PFK7231(W7231)
                    End If

                End If

            Else
                W7232.Dseq = j
                W7232.MaterialCode = L7232.MaterialCode
                W7232.MaterialCodeBom = getData(Vs1, getColumIndex(Vs1, "MaterialCode"), i)
                KEY_COUNT()
                If WRITE_PFK7232(W7232) = True Then

                    If READ_PFK7231(W7232.MaterialCodeBom) Then
                        W7231 = D7231
                        W7231.Check1 = "1"
                        Call REWRITE_PFK7231(W7231)
                    End If

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
                If K7232_MOVE(Vs1, i, W7232, txt_MaterialCode.Data, getData(Vs1, getColumIndex(Vs1, "KEY_MaterialCodeSeq"), i)) = True Then

                    If DELETE_PFK7232(W7232) = True Then isudCHK = True

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
            SQL = "SELECT MAX(CAST(K7232_MaterialCodeSeq AS DECIMAL)) AS MAX_MCODE FROM PFK7232 "
            SQL = SQL & " WHERE K7232_MaterialCode = '" & txt_MaterialCode.Data & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W7232.MaterialCodeSeq = "01"
            Else
                W7232.MaterialCodeSeq = Format(CInt(rd!MAX_MCODE + 1), "00")
            End If

            rd.Close()

            L7232.MaterialCodeSeq = W7232.MaterialCodeSeq

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

#End Region

#Region "Event"
    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        Select Case wJOB
            Case 1
                If DataCheck(Me, "PFK7232") = False Then Exit Sub

                Call DATA_MOVE_WRITE01()
                Call DATA_SEARCHvS1()
                wJOB = 3

            Case 2
                Me.Dispose()
            Case 3
                If DataCheck(Me, "PFK7232") = False Then Exit Sub
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
        'Dim xrow As Integer
        'xrow = e.Row

        'Select Case e.Column
        '    Case getColumIndex(Vs1, "cdMaterialCode")
        '        Dim f As New Form
        '        f = New HLP7231C
        '        f.ShowDialog()
        '        If hlp0000SeVaTt = "" Or hlp0000SeVa = "" Then Exit Sub
        '        If READ_PFK7231(hlp0000SeVaTt) = True Then
        '            setData(Vs1, getColumIndex(Vs1, "MaterialCode"), xrow, D7231.MaterialCode)
        '            setData(Vs1, getColumIndex(Vs1, "MaterialName"), xrow, D7231.MaterialName)
        '            If READ_PFK7171(Const_UnitMaterial, D7231.cdUnitMaterial) = True Then
        '                setData(Vs1, getColumIndex(Vs1, "cdUnitMaterialName"), xrow, D7171.BasicName)
        '            End If
        '        End If

        '    Case getColumIndex(Vs1, "cdUnitPrice")
        '        HLPCHECK("Const_UnitPrice")
        '        If hlp0000SeVa = "" Or hlp0000SeVaTt = "" Then Exit Sub
        '        setData(Vs1, getColumIndex(Vs1, "cdUnitPrice"), xrow, hlp0000SeVaTt)
        '        setData(Vs1, getColumIndex(Vs1, "cdUnitPriceExpenseName"), xrow, hlp0000SeVa)

        'End Select

        'vSChange(e.Row)

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
                If xROW = sender.ActiveSheet.RowCount - 1 Then
                    Vs1.ActiveSheet.RowCount += 1
                    Vs1.ActiveSheet.ActiveRowIndex = xROW + 1
                Else
                    Vs1.ActiveSheet.AddRows(xROW, 1)
                End If

            Case Keys.Delete

                Msg_Result = MsgBoxP("Do you want to delete?", vbYesNo)

                If Msg_Result <> vbYes Then Exit Sub

                If K7232_MOVE(Vs1, xROW, W7232, txt_MaterialCode.Data, getData(Vs1, getColumIndex(Vs1, "KEY_MaterialCodeSeq"), xROW)) Then
                    If DELETE_PFK7232(W7232) = True Then
                        isudCHK = True
                    End If
                End If

                SPR_DEL(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex)
                Vs1.Focus()
            Case Keys.Enter
                Select Case xCOL
                    Case getColumIndex(Vs1, "cdMaterialCode")
                        Dim f As New Form
                        f = New HLP7231C
                        f.ShowDialog()
                        If hlp0000SeVaTt = "" Or hlp0000SeVa = "" Then Exit Sub
                        If READ_PFK7231(hlp0000SeVaTt) = True Then
                            setData(Vs1, getColumIndex(Vs1, "MaterialCode"), xROW, D7231.MaterialCode)
                            setData(Vs1, getColumIndex(Vs1, "MaterialName"), xROW, D7231.MaterialName)

                            If READ_PFK7171(Const_UnitMaterial, D7231.cdUnitMaterial) = True Then
                                setData(Vs1, getColumIndex(Vs1, "cdUnitMaterialName"), xROW, D7171.BasicName)
                            End If

                        End If

                    Case getColumIndex(Vs1, "DirectName")

                    Case Else
                        Dim I As Integer
                        For I = 0 To xROW
                            If CDecp(getData(Vs1, xCOL, I)) = 0 Then
                                setData(Vs1, xCOL, I, getData(Vs1, xCOL, xROW))
                            End If

                        Next

                End Select

                vSChange(xROW)
        End Select
    End Sub
#End Region

End Class