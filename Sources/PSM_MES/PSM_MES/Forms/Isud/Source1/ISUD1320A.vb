Public Class ISUD1320A

#Region "Variable"
    Private wJOB As Integer

    Private W1320 As New T1320_AREA
    Private L1320 As New T1320_AREA

    Private W1321 As New T1321_AREA
    Private L1321 As New T1321_AREA

    Private WRITE_CHK As String
    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD1320A(job As Integer, TestOrder As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG

        D1320.TestOrder = TestOrder

        wJOB = job : L1320 = D1320

        Link_ISUD1320A = False
        Try

            Select Case job
                Case 1
                Case Else
                    If READ_PFK1320(L1320.TestOrder) = False Then
                        Call MsgBoxP("3", "LINK_ISUD")

                        Me.Dispose()
                        Exit Function
                    Else
                        L1320 = D1320
                    End If
                    txt_DateTest.Enabled = False

            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD1320A = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Request Order Processing"))
        End Try


    End Function

    Public Function Link_ISUD1320A_AUTO(job As Integer, OrderNo As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG

        D1321.OrderNo = OrderNo

     

        wJOB = job : L1320 = D1320 : L1321 = D1321

        Link_ISUD1320A_AUTO = False
        Try

            Select Case job
                Case 1
                Case Else
                    If READ_PFK1320(L1320.TestOrder) = False Then
                        Call MsgBoxP("3", "LINK_ISUD")

                        Me.Dispose()
                        Exit Function
                    Else
                        L1320 = D1320
                    End If
                    txt_DateTest.Enabled = False

            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD1320A_AUTO = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Request Order Processing"))
        End Try


    End Function
#End Region

#Region "Form"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        Call DATA_INIT()

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        Select Case wJOB
            Case 1
                Me.Text = Me.Text & " - INSERT"
                cmd_DEL.Visible = False

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call KEY_COUNT()
                Call KEY_COUNT_SEQ()

                Call DATA_SEARCH_VS1()

                Setfocus(txt_CustomerCode)
            Case 2
                Me.Text = Me.Text & " - SEARCH"

                cmd_DEL.Visible = False
                cmd_OK.Visible = False

                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()

            Case 3
                Me.Text = Me.Text & " - UPDATE"
                txt_TestOrder.Enabled = False
                cmd_DEL.Visible = False

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
                        cmd_DEL.Visible = False
                        cmd_OK.Visible = False
                        Call Error_Message("16", "Form_Activate")
                    End If
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()

            Case 4
                Me.Text = Me.Text & " - DELETE"

                cmd_OK.Visible = False


                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()

            Case 5
                Me.Text = Me.Text & " - ADD"
                cmd_DEL.Visible = False

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call KEY_COUNT_SEQ()
                Call DATA_SEARCH_VS1()

                Setfocus(txt_CustomerCode)

        End Select

        formA = True

    End Sub
#End Region

#Region "Search"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False

        DS1 = READ_PFK1320(L1320.TestOrder, cn)

        If GetDsRc(DS1) = 0 Then
            isudCHK = False
            Exit Function
        End If

        If GetDsData(DS1, 0, "K1321_TestStatus") = "1" Then chk_TestStatus1.Checked = True
        If GetDsData(DS1, 0, "K1321_TestStatus") = "2" Then chk_TestStatus2.Checked = True
        If GetDsData(DS1, 0, "K1321_TestStatus") = "3" Then chk_TestStatus3.Checked = True
        If GetDsData(DS1, 0, "K1321_TestStatus") = "4" Then chk_TestStatus4.Checked = True
        If GetDsData(DS1, 0, "K1321_TestStatus") = "5" Then chk_TestStatus5.Checked = True

        READER_MOVE(Me, DS1)
    End Function

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False
        Try
            DS1 = PrcDS("USP_ISUD1320A_SEARCH_VS1", cn, L1320.TestOrder)
            If GetDsRc(DS1) = 0 Then
                DS2 = PrcDS("USP_ISUD1320A_SEARCH_VS1_INSERT_F1", cn, L1321.OrderNo)
                SPR_PRO_NEW(vS1, DS2, "USP_ISUD1320A_SEARCH_VS1", "VS1")

                vS1.Enabled = True
                Exit Function
            End If

            Call SPR_PRO_NEW(vS1, DS1, "USP_ISUD1320A_SEARCH_VS1", "VS1")
            Dim i As Integer

            For i = 0 To vS1.ActiveSheet.RowCount - 1

                If getData(vS1, getColumIndex(vS1, "TestStatus"), i) <> "1" Then
                    Call SPR_LOCK(vS1, i)
                    Call SPR_BACKCOLOR(vS1, Color.Pink, i)
                    Call DisableAllType()
                End If

            Next

            DATA_SEARCH_VS1 = True
        Catch ex As Exception

        End Try
    End Function
#End Region

#Region "Function"
    Private Sub DATA_MOVE()
        If K1320_MOVE(Me, W1320, 1, txt_TestOrder.Data) = False Then
            Call KEY_COUNT()
            W1320.seSite = ListCode("Site")
            W1320.TestStatus = "1"
            W1320.DateTest = Pub.DAT

            W1320.InchargeInsert = Pub.SAW
            W1320.InsertDate = Pub.DAT

            Call WRITE_PFK1320(W1320)

        Else
            W1320.InchargeUpdate = Pub.SAW
            W1320.UpdateDate = Pub.DAT

            Call REWRITE_PFK1320(W1320)
        End If
    End Sub

    Private Sub CheckStatus()
        If chk_TestStatus1.Checked = True Then W1320.TestStatus = "1" : W1321.TestStatus = "1"
        If chk_TestStatus2.Checked = True Then W1320.TestStatus = "2" : W1321.TestStatus = "2" : W1320.DateComplete = Pub.DAT
        If chk_TestStatus3.Checked = True Then W1320.TestStatus = "3" : W1321.TestStatus = "3" : W1320.DateApproval = Pub.DAT
        If chk_TestStatus4.Checked = True Then W1320.TestStatus = "4" : W1321.TestStatus = "4" : W1320.DateCancel = Pub.DAT
        If chk_TestStatus5.Checked = True Then W1320.TestStatus = "5" : W1321.TestStatus = "5" : W1320.DatePending = Pub.DAT
    End Sub
    Private Sub DATA_INSERT()

        Try
            Call KEY_COUNT()
            Dim i As Integer
            Call DATA_MOVE()

            For i = 0 To vS1.ActiveSheet.RowCount - 1
                If getData(vS1, getColumIndex(vS1, "OrderNo"), i) = "" Then GoTo next1

                If K1321_MOVE(vS1, i, W1321, getData(vS1, getColumIndex(vS1, "KEY_TestOrder"), i), getData(vS1, getColumIndex(vS1, "KEY_TestSeq"), i)) = True Then
                    W1321.TestOrder = L1320.TestOrder

                    W1321.seProductionProcess = ListCode("ProductionProcess")
                    W1321.seTestCode = ListCode("TestCode")

                    Call CheckStatus()

                    If REWRITE_PFK1321(W1321) = True Then
                        isudCHK = True : WRITE_CHK = "*"
                    End If

                Else
                    W1321.TestOrder = L1320.TestOrder
                    Call KEY_COUNT_SEQ()

                    W1321.seProductionProcess = ListCode("ProductionProcess")
                    W1321.seTestCode = ListCode("TestCode")
                    W1321.DateTest = Pub.DAT
                    Call CheckStatus()

                    If WRITE_PFK1321(W1321) = True Then
                        isudCHK = True : WRITE_CHK = "*"
                    End If

                End If
next1:
            Next

            Call MsgBoxP("Insert Succesfully!", vbInformation)
        Catch ex As Exception

        End Try

    End Sub
    Private Sub UPDATE_INFORMATION()

    End Sub

    Private Sub DATA_UPDATE()
        Try
            Dim i As Integer

            Call DATA_MOVE()

            For i = 0 To vS1.ActiveSheet.RowCount - 1
                If getData(vS1, getColumIndex(vS1, "OrderNo"), i) = "" Then GoTo next1

                If K1321_MOVE(vS1, i, W1321, getData(vS1, getColumIndex(vS1, "KEY_TestOrder"), i), getData(vS1, getColumIndex(vS1, "KEY_TestSeq"), i)) = True Then
                    W1321.TestOrder = L1320.TestOrder

                    W1321.seProductionProcess = ListCode("ProductionProcess")
                    W1321.seTestCode = ListCode("TestCode")

                    Call CheckStatus()

                    If REWRITE_PFK1321(W1321) = True Then
                        isudCHK = True : WRITE_CHK = "*"
                    End If

                Else
                    W1321.TestOrder = L1320.TestOrder
                    Call KEY_COUNT_SEQ()

                    W1321.seProductionProcess = ListCode("ProductionProcess")
                    W1321.seTestCode = ListCode("TestCode")

                    Call CheckStatus()

                    If WRITE_PFK1321(W1321) = True Then
                        isudCHK = True : WRITE_CHK = "*"
                    End If

                End If
next1:
            Next

            Call MsgBoxP("Update Succesfully!", vbInformation)
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

    Private Function DATA_DELETE() As Boolean
        DATA_DELETE = False
        Dim i As Integer

        Try
            For i = 0 To vS1.ActiveSheet.RowCount - 1
                If getDataM(vS1, getColumIndex(vS1, "checkUse"), i) = "1" Then
                    If DATA_LINE_DELETE(i) = False Then Exit Function
                    isudCHK = True
                End If
            Next

            If isudCHK = True Then Call MsgBoxP("Delete Succesfully!", vbInformation)
            DATA_DELETE = True

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Function

    Private Function DATA_LINE_DELETE(xrow As Integer) As Boolean
        DATA_LINE_DELETE = False

        Try
            If READ_PFK1321(getData(vS1, getColumIndex(vS1, "KEY_TestOrder"), xrow), getData(vS1, getColumIndex(vS1, "KEY_TestSeq"), xrow)) = True Then

                W1321 = D1321

                If DELETE_PFK1321(W1321) = True Then
                    isudCHK = True
                End If
            End If
            DATA_LINE_DELETE = True
        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Function

    Private Function CheckSamePO(OrderNo As String) As Boolean
        CheckSamePO = True
        Dim i As Integer
        Try
            For i = 0 To vS1.ActiveSheet.RowCount - 1
                If getData(vS1, getColumIndex(vS1, "OrderNo"), i) = OrderNo Then
                    CheckSamePO = False
                    MsgBoxP("Already Data! No again!") : Exit Function
                End If
            Next

        Catch ex As Exception

        End Try
    End Function
    Private Sub KEY_COUNT()
        Try

            SQL = "SELECT MAX(CAST(RIGHT(K1320_TestOrder,3) AS DECIMAL)) AS MAX_MCODE FROM PFK1320 "
            SQL = SQL + " WHERE SUBSTRING(K1320_TestOrder,3,4) = '" + Strings.Mid(Pub.DAT, 3, 4) + "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W1320.TestOrder = "TO" & Strings.Mid(Pub.DAT, 3, 4) & "001"
            Else
                W1320.TestOrder = "TO" & Strings.Mid(Pub.DAT, 3, 4) & Format(CInt(rd!MAX_MCODE + 1), "000")
            End If

            rd.Close()

            L1320.TestOrder = W1320.TestOrder
            txt_TestOrder.Data = L1320.TestOrder

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

    Private Sub KEY_COUNT_SEQ()
        Try

            SQL = "SELECT MAX(CAST(K1321_TestSeq AS DECIMAL)) AS MAX_MCODE FROM PFK1321 "
            SQL = SQL + " WHERE K1321_TestOrder = '" + L1320.TestOrder + "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W1321.TestSeq = "001"
            Else
                W1321.TestSeq = Format(CIntp(rd!MAX_MCODE + 1), "000")
            End If

            rd.Close()

            L1321.TestSeq = W1321.TestSeq

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub
    Private Sub DATA_INIT()
        Try
            txt_TestOrder.Enabled = False
            isudCHK = False
            txt_DateTest.Data = System_Date_8()
            txt_DateDelivery.Data = System_Date_8()

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Sub FORM_INIT()

    End Sub

    Private Function Data_Check() As Boolean
        Data_Check = True

        Try

        Catch ex As Exception

        End Try
    End Function

#End Region

#Region "Event"
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Select Case wJOB
            Case 1
                If DataCheck(Me, "PFK1320") = False Then Exit Sub
                If Data_Check() = False Then Exit Sub
                Call KEY_COUNT()
                Call DATA_INSERT()
                Call UPDATE_INFORMATION()
                wJOB = 3
                Call DATA_SEARCH_VS1()

            Case 2
                Me.Dispose()

            Case 3
                If DataCheck(Me, "PFK1320") = False Then Exit Sub
                If Data_Check = False Then Exit Sub

                Call DATA_UPDATE()
                Call UPDATE_INFORMATION()
                Call DATA_SEARCH_VS1()
            Case 4
                Call DATA_DELETE()

            Case 5
                If DataCheck(Me, "PFK1320") = False Then Exit Sub
                If Data_Check() = False Then Exit Sub
                Call UPDATE_INFORMATION()
                wJOB = 3
                Call DATA_SEARCH_VS1()

        End Select
    End Sub

    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        If WRITE_CHK = "*" Then
            isudCHK = True
        Else
            isudCHK = False
        End If

        Me.Dispose()
    End Sub

    Private Sub cmd_DEL_Click(sender As Object, e As EventArgs) Handles cmd_DEL.Click
        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        If CHK(4) <> "1" Then
            Call MsgBoxP("4", "cmd_DEL_Click")
            Exit Sub
        End If

        Dim str As String = MsgBoxP("Do you want to delete it?", vbYesNo)

        If str <> vbYes Then Exit Sub

        If DATA_DELETE() Then

            If READ_PFK1320(txt_TestOrder.Data) Then
                W1320 = D1320
                Call DELETE_PFK1320(W1320)
            End If
        End If

        Me.Dispose()
    End Sub

    Private Sub VS1_ButtonClicked(sender As Object, e As EditorNotifyEventArgs) Handles vS1.ButtonClicked
        Dim xCOL As Integer
        Dim xROW As Integer
        Dim Value2(5) As String

        xROW = e.Row
        xCOL = e.Column

        Select Case xCOL
            Case getColumIndex(vS1, "cdTestOrder")
                If HLP1312A.Link_HLP1312Material() = True Then
                    hlp0000SeVa = hlp0000SeVa.Replace("|", ",")
                    DS1 = PrcDS("USP_ISUD1320A_SEARCH_VS1_INSERT", cn, hlp0000SeVa)
                    Call READ_SPREAD_N(vS1, DS1, xROW, GetDsRc(DS1), "USP_ISUD1320A_SEARCH_VS1", "VS1")

                    Exit Sub
                End If

                vS1.Focus()

        End Select

        vSChange(e.Row)
    End Sub

    Private Sub VS1_Change(sender As Object, e As ChangeEventArgs) Handles vS1.Change
        Dim xCOL As Integer
        Dim xROW As Integer

        Try
            xROW = e.Row
            xCOL = e.Column

            vSChange(xROW)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub vSChange(xROW As Integer)

    End Sub

    Private Sub VS1_KeyDown(sender As Object, e As KeyEventArgs) Handles vS1.KeyDown
        If wJOB = 2 Then Exit Sub
        Dim xCOL As Long
        Dim xROW As Long
        Dim Value2(5) As String
        Dim Type As String = ""

        xCOL = vS1.ActiveSheet.ActiveColumnIndex
        xROW = vS1.ActiveSheet.ActiveRowIndex

        Select Case e.KeyCode

            Case Keys.Delete

                Msg_Result = MsgBoxP("Do you want to delete?", vbYesNo)

                If Msg_Result <> vbYes Then Exit Sub

                W1321.TestOrder = txt_TestOrder.Data
                W1321.TestSeq = getData(vS1, getColumIndex(vS1, "KEY_TestSeq"), xROW)

                If READ_PFK1321(W1321.TestOrder, W1321.TestSeq) = True Then
                    If D1320.TestStatus <> "1" Then MsgBoxP("Check condition at row " & xROW) : Exit Sub
                    If CDblp(D1321.TestQty) > 0 Then MsgBoxP("Check condition at row " & xROW) : Exit Sub

                    Call DATA_LINE_DELETE(xROW)

                End If

                SPR_DEL(vS1, 0, vS1.ActiveSheet.ActiveRowIndex)
                vS1.Focus()

            Case Keys.Enter
                Select Case xCOL
                    Case getColumIndex(sender, "cdTestOrder")
                        If HLP1312A.Link_HLP1312Material() = True Then
                            hlp0000SeVa = hlp0000SeVa.Replace("|", ",")
                            DS1 = PrcDS("USP_ISUD1320A_SEARCH_VS1_INSERT", cn, hlp0000SeVa)
                            Call READ_SPREAD_N(vS1, DS1, xROW, GetDsRc(DS1), "USP_ISUD1320A_SEARCH_VS1", "VS1")

                            Exit Sub
                        End If

                        vS1.Focus()

                End Select
        End Select
        Call vSChange(xROW)
    End Sub

#End Region


End Class
