Public Class ISUD7235A

#Region "Variable"
    Private wJOB As Integer

    Private W7235 As New T7235_AREA
    Private L7235 As New T7235_AREA

    Private WRITE_CHK As String
    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7235A(job As Integer, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG

        wJOB = job : L7235 = D7235
        Link_ISUD7235A = False

        Try

            Select Case job
                Case 1
                Case Else

            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD7235A = isudCHK


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

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH()
                Call DATA_SEARCH_VS1()

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

                Call DATA_SEARCH()
                Call DATA_SEARCH_VS1()

            Case 3
                Me.Text = Me.Text & " - UPDATE"

                Frame1.Enabled = True
                txt_MappingNo.Enabled = False
                tst_iDelete.Visible = False

                Call DATA_SEARCH()
                Call DATA_SEARCH_VS1()

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

            Case 4
                Me.Text = Me.Text & " - DELETE"

                tst_iSave.Visible = False

                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If
                Call DATA_SEARCH()
                Call DATA_SEARCH_VS1()

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
    Private Function DATA_SEARCH() As Boolean

        DATA_SEARCH = False
        DATA_SEARCH = True

    End Function
    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False

        DS1 = PrcDS("USP_ISUD7235A_SEARCH_VS1", cn)


        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs1, DS1, "USP_ISUD7235A_SEARCH_VS1", "Vs1")
            Vs1.ActiveSheet.RowCount = 10
            Vs1.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "USP_ISUD7235A_SEARCH_VS1", "Vs1")

        DATA_SEARCH_VS1 = True


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
            If Trim(getData(Vs1, getColumIndex(Vs1, "cdUnitMaterial"), i)) = "" Then GoTo skip

            j = j + 1
            If K7235_MOVE(Vs1, i, W7235, getData(Vs1, getColumIndex(Vs1, "KEY_Autokey"), i)) = True Then
                W7235.seUnitMaterial = ListCode("UnitMaterial")
                Call REWRITE_PFK7235(W7235)
            Else
                W7235.seUnitMaterial = ListCode("UnitMaterial")
                If WRITE_PFK7235(W7235) = True Then
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


    End Sub
    Private Sub KEY_COUNT()
    End Sub

    Private Sub KEY_COUNT_SEQ()

    End Sub

#End Region

#Region "Event"
    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        Select Case wJOB
            Case 1
                Call DATA_MOVE()
                Call DATA_MOVE_WRITE01()
                wJOB = 3
                Me.Dispose()
            Case 2
                Me.Dispose()
            Case 3
                Call DATA_MOVE()
                Call DATA_MOVE_WRITE01()
                Me.Dispose()
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
        '    Case getColumIndex(Vs1, "cdMappingNo")
        '        Dim f As New Form
        '        f = New HLP7231C
        '        f.ShowDialog()
        '        If hlp0000SeVaTt = "" Or hlp0000SeVa = "" Then Exit Sub
        '        If READ_PFK7231(hlp0000SeVaTt) = True Then
        '            setData(Vs1, getColumIndex(Vs1, "MappingNo"), xrow, D7231.MappingNo)
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



        End Select
    End Sub
#End Region

End Class