Public Class ISUD9001A

#Region "Variable"
    Private wJOB As Integer

    Private W9001 As New T9001_AREA
    Private L9001 As New T9001_AREA

    Private W9002 As New T9002_AREA
    Private L9002 As New T9002_AREA

    Private ExportTax As Decimal
    Private EnvironmentTax As Decimal
    Private VatTax As Decimal

    Private WRITE_CHK As String
    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD9001A(job As Integer, MappingNo As String, Optional ByVal TAG As String = "") As Boolean
        If Pub.ADMCHK <> "1" Then Exit Function

        Me.Tag = TAG
        D9001.MappingNo = MappingNo

        If job = "1" Then
            txt_CustomerCode.Code = MappingNo
            txt_CustomerCode.Enabled = True
            Call READ_PFK7101(MappingNo)
            txt_CustomerCode.Data = D7101.CustomerName
            D9001.CustomerCode = MappingNo
            D9001.MappingNo = ""
        End If

        wJOB = job : L9001 = D9001
        Link_ISUD9001A = False

        Try

            Select Case job
                Case 1
                Case Else

            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD9001A = isudCHK


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
            Case 1
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

                Call KEY_COUNT()
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
                Call DATA_SEARCH()
                Call DATA_SEARCH_VS1()

        End Select

        formA = True
    End Sub
#End Region

#Region "Search"
    Private Function DATA_SEARCH() As Boolean

        DATA_SEARCH = False

        DS1 = READ_PFK9001(L9001.MappingNo, cn)

        If GetDsRc(DS1) = 0 Then
            Setfocus(txt_MappingName)
            Exit Function
            isudCHK = False
        End If

        READER_MOVE(Me, DS1)

        Setfocus(txt_MappingName)

        DATA_SEARCH = True

    End Function
    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False

        DS1 = PrcDS("USP_ISUD9001A_SEARCH_VS1", cn, L9001.MappingNo)


        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs1, DS1, "USP_ISUD9001A_SEARCH_VS1", "Vs1")
            Vs1.ActiveSheet.RowCount = 10
            Vs1.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "USP_ISUD9001A_SEARCH_VS1", "Vs1")

        DATA_SEARCH_VS1 = True


    End Function

#End Region

#Region "Function"
    Private Sub DATA_MOVE()
        If READ_PFK9001(txt_MappingNo.Data) = False Then
            Call K9001_MOVE(Me, W9001, 1, txt_MappingNo.Data)
            Call KEY_COUNT()
            Call WRITE_PFK9001(W9001)
        Else
            Call K9001_MOVE(Me, W9001, 1, txt_MappingNo.Data)
            Call REWRITE_PFK9001(W9001)
        End If
    End Sub

    Private Sub DATA_MOVE_WRITE01()
        Dim i As Integer
        Dim j As Integer
        j = 0
        For i = 0 To Vs1.ActiveSheet.RowCount - 1
            If Trim(getData(Vs1, getColumIndex(Vs1, "ItemCode"), i)) = "" Then GoTo skip

            j = j + 1
            If K9002_MOVE(Vs1, i, W9002, txt_MappingNo.Data, getData(Vs1, getColumIndex(Vs1, "KEY_MappingSeq"), i)) = True Then

                Call REWRITE_PFK9002(W9002)
            Else
                W9002.MappingNo = L9001.MappingNo
                KEY_COUNT_SEQ()
                If WRITE_PFK9002(W9002) = True Then
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
                If K9002_MOVE(Vs1, i, W9002, txt_MappingNo.Data, getData(Vs1, getColumIndex(Vs1, "KEY_MappingSeq"), i)) = True Then

                    If DELETE_PFK9002(W9002) = True Then isudCHK = True

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
            SQL = "SELECT MAX(CAST(K9001_MappingNo AS DECIMAL)) AS MAX_MCODE FROM PFK9001 "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W9001.MappingNo = "000001"
            Else
                W9001.MappingNo = Format(CInt(rd!MAX_MCODE + 1), "000000")
            End If

            rd.Close()

            L9001.MappingNo = W9001.MappingNo
            txt_MappingNo.Data = W9001.MappingNo
        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

    Private Sub KEY_COUNT_SEQ()

        Dim YRNO As Integer
        YRNO = Mid(System_Date_8(), 3, 4)

        Try
            SQL = "SELECT MAX(CAST(K9002_MappingSeq AS DECIMAL)) AS MAX_MCODE FROM PFK9002 "
            SQL = SQL & " WHERE K9002_MappingNo = '" & L9001.MappingNo & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W9002.MappingSeq = "001"
            Else
                W9002.MappingSeq = Format(CInt(rd!MAX_MCODE + 1), "000")
            End If

            rd.Close()

            L9002.MappingSeq = W9002.MappingSeq

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

    Private Sub DATA_INIT()
        tst_iUtilities.Visible = True
        tst_iAttach.Visible = True
        tst_iHistory.Visible = False
    End Sub

    Private Sub FORM_INIT()

    End Sub

#End Region

#Region "Event"
    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        Select Case wJOB
            Case 1
                Call KEY_COUNT()
                Call DATA_MOVE()
                Call DATA_MOVE_WRITE01()
                Call DATA_SEARCH_VS1()
                wJOB = 3
            Case 2
                Me.Dispose()
            Case 3
                Call DATA_MOVE()
                Call DATA_MOVE_WRITE01()
                Call DATA_SEARCH_VS1()
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
            Case getColumIndex(Vs1, "CLItemCode")
                If HLP9911ALL.Link_HLP9911A("") = False Then Exit Sub

                setData(Vs1, getColumIndex(Vs1, "ItemCode"), xrow, D9911.ItemCode)
                setData(Vs1, getColumIndex(Vs1, "ItemName"), xrow, D9911.ItemName)

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

                If READ_PFK9002(txt_MappingNo.Data, getData(Vs1, getColumIndex(Vs1, "KEY_MappingSeq"), xROW)) Then
                    W9002 = D9002
                    Call DELETE_PFK9002(W9002)
                End If

                SPR_DEL(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex)
                Vs1.Focus()

            Case Keys.Enter
                Select Case xCOL
                    Case getColumIndex(Vs1, "CLItemCode")
                        If HLP9911ALL.Link_HLP9911A("") = False Then Exit Sub

                        setData(Vs1, getColumIndex(Vs1, "ItemCode"), xROW, D9911.ItemCode)
                        setData(Vs1, getColumIndex(Vs1, "ItemName"), xROW, D9911.ItemName)

                End Select

                vSChange(xROW)

        End Select
    End Sub
#End Region

End Class