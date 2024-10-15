Public Class ISUD2351B

#Region "Variable"
    Private wJOB As Integer

    Private W2351 As New T2351_AREA
    Private L2351 As New T2351_AREA

    Private W2352 As New T2352_AREA
    Private L2352 As New T2352_AREA

    Private WRITE_CHK As String
    Public gpp As Graphics
    Public twtopi As Decimal = 39.5

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Form"


    Public Function Link_ISUD2351B(job As Integer, MaterialInBoundNo As String, MaterialInBoundSeq As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D2351.MaterialInBoundNo = MaterialInBoundNo
        D2351.MaterialInBoundSeq = MaterialInBoundSeq
        wJOB = job : L2351 = D2351

        txt_MaterialInBoundNo.Data = MaterialInBoundNo
        txt_MaterialInBoundSeq.Data = MaterialInBoundSeq

        Link_ISUD2351B = False
        Try

            Select Case job
                Case 1
                Case Else

            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD2351B = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))
        End Try


    End Function

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

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH_VS1()

                Me.Show()
                Application.DoEvents()
                txt_WeavingRollInbound.PeaceTextbox1.Focus()
                Frame1.Enabled = True
                cmd_DEL.Visible = False
            Case 2
                Me.Text = Me.Text & " - SEARCH"

                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If
                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH_VS1()

                Frame1.Enabled = True
                cmd_DEL.Visible = False
                cmd_OK.Visible = False
            Case 3
                Me.Text = Me.Text & " - UPDATE"

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
                        Call MsgBoxP("Only Search !") : cmd_OK.Visible = False
                    End If
                End If
                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH_VS1()

                Frame1.Enabled = True
                cmd_DEL.Visible = False

            Case 4
                Me.Text = Me.Text & " - DELETE"

                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If
                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH_VS1()

                Frame1.Enabled = True
                cmd_DEL.Visible = True
                cmd_OK.Visible = False
                cmd_Print.Visible = False

        End Select

        formA = True
    End Sub

#End Region

#Region "Search"

    Private Function DATA_SEARCH_HEAD() As Boolean
        DATA_SEARCH_HEAD = False
        Try
            DATA_SEARCH_HEAD = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH01")
        End Try

    End Function

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False
        Try
            DS1 = PrcDS("USP_ISUD2351B_SEARCH_VS1", cn, txt_MaterialInBoundNo.Data, txt_MaterialInBoundSeq.Data)

            If GetDsRc(DS1) = 0 Then
                SPR_SET(Vs1, , , 1, OperationMode.SingleSelect)
                SPR_PRO(Vs1, DS1, "USP_ISUD2351B_SEARCH_VS1", "vS1")
                Vs1.Enabled = True
                Exit Function
            End If
            SPR_SET(Vs1, , , , OperationMode.SingleSelect)
            SPR_PRO(Vs1, DS1, "USP_ISUD2351B_SEARCH_VS1", "Vs1")
            Call Calculation()
            DATA_SEARCH_VS1 = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try
    End Function

    Private Sub Calculation()
        txt_CntRoll.Data = Vs1.ActiveSheet.RowCount
        Dim i As Integer
        Dim TotalN As Decimal = 0
        Dim TotalQ As Decimal = 0

        For i = 0 To Vs1.ActiveSheet.RowCount - 1
            If getDataM(Vs1, getColumIndex(Vs1, "CheckComplete"), i) = "1" Then
                TotalN += 1
                TotalQ += CDecp(getData(Vs1, getColumIndex(Vs1, "QtyInBoundMaterial"), i))

            End If
        Next

        txt_CntRoll.Data = FormatNumber(TotalN, 0)
        txt_CntYdsGross.Data = FormatNumber(TotalQ, 0)

    End Sub

    Private Function DATA_SEARCH_VS1_INSERT_INSIDE() As Boolean
        DATA_SEARCH_VS1_INSERT_INSIDE = False
        Dim MaterialInBoundNo As String
        Dim MaterialInBoundSeq As String
        Dim MaterialInBoundSno As String

        Dim CheckInBoundWH As String = "1"
        
        Try
            txt_WeavingRollInbound.Data = FormatCut(txt_WeavingRollInbound.Data)

            If txt_WeavingRollInbound.Data.Trim.Length > 12 Then
                MaterialInBoundNo = Strings.Left(txt_WeavingRollInbound.Data, 9)
                MaterialInBoundSeq = Strings.Mid(txt_WeavingRollInbound.Data, 10, 3)
                MaterialInBoundSno = Strings.Mid(txt_WeavingRollInbound.Data, 13)
            Else
                MsgBoxP("Barcode is wrong information!")
                MaterialInBoundNo = ""
                MaterialInBoundSeq = ""
                MaterialInBoundSno = ""
                Exit Function
            End If

            If READ_PFK2352(MaterialInBoundNo, MaterialInBoundSeq, MaterialInBoundSno) = True Then
                If D2352.CheckComplete = "1" Then MsgBoxP("Already inbound. Please check!") : Exit Function
                W2352 = D2352
                W2352.CheckComplete = "1"

                Call REWRITE_PFK2352(W2352)
                Call DATA_MOVE(W2352.MaterialInBoundNo, W2352.MaterialInBoundSeq, W2352.MaterialInBoundSno)

                DATA_SEARCH_VS1_INSERT_INSIDE = True
            End If

            Call Calculation()
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try
    End Function

#End Region

#Region "Function"
    Private Function DATA_MOVE(MaterialInBoundNo As String, MaterialInBoundSeq As String, MaterialInBoundSno As String) As Boolean
        DATA_MOVE = False
        Try
            Dim i As Integer

            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If getData(Vs1, getColumIndex(Vs1, "KEY_MaterialInBoundNo"), i) = MaterialInBoundNo _
                    And getData(Vs1, getColumIndex(Vs1, "KEY_MaterialInBoundSeq"), i) = MaterialInBoundSeq _
                    And getData(Vs1, getColumIndex(Vs1, "KEY_MaterialInBoundSno"), i) = MaterialInBoundSno Then

                    setData(Vs1, getColumIndex(Vs1, "CheckComplete"), i, "1", , True)
                    SPR_FORECOLORROW(Vs1, Color.Blue, i)
                End If
            Next

        Catch ex As Exception
            MsgBoxP("DATA_MOVE!")
        End Try
    End Function


    Private Function DATA_MOVE() As Boolean
        DATA_MOVE = False
        Try
            Dim i As Integer

            For i = 0 To Vs1.ActiveSheet.RowCount - 1

            Next

        Catch ex As Exception
            MsgBoxP("DATA_MOVE!")
        End Try
    End Function

    Private Sub DATA_UPDATE()
        Try

            If REWRITE_PFK2351(W2351) = True Then
                isudCHK = True
                Me.Dispose()
            End If

        Catch ex As Exception
            Call MsgBoxP("DATA_UPDATE")
        End Try
    End Sub

    Private Sub DATA_DELETE()
        Dim i As Integer

        Try
            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                DATA_LINE_DELETE(i)
            Next
            isudCHK = True : Me.Dispose() : Exit Sub

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub
    Private Sub DATA_LINE_DELETE(xrow As Integer)
        Try
            'If READ_PFK2352(getData(Vs1, getColumIndex(Vs1, "KEY_MaterialInBoundNo"), xrow), getData(Vs1, getColumIndex(Vs1, "KEY_MaterialInBoundSeq"), xrow), getData(Vs1, getColumIndex(Vs1, "KEY_MaterialInBoundSno"), xrow)) = True Then
            '    W2351 = D2351
            '    REWRITE_PFK2351(W2351)
            '    setData(Vs1, getColumIndex(Vs1, "CheckComplete"), xrow, "0", , True)
            '    SPR_FORECOLORROW(Vs1, Color.Black, xrow)
            'End If
        Catch ex As Exception
            Call MsgBoxP("38", "DATA_LINE_DELETE")
        End Try

    End Sub

    Private Sub DATA_INIT()
        Try
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Sub FORM_INIT()
        RemoveHandler txt_WeavingRollInbound.PeaceTextbox1.KeyDown, AddressOf standard_KeyDown

        txt_WeavingRollInbound.PeaceTextbox1.Properties.CharacterCasing = CharacterCasing.Upper
        txt_MaterialInBoundNo.Enabled = False
    End Sub

    Private Sub vS1_DATA_INSERT(xrow As Integer)
        setData(Vs1, getColumIndex(Vs1, "InboundYarnSeq"), xrow, xrow + 1)
        setData(Vs1, getColumIndex(Vs1, "BoxInBoundYarn"), xrow, 1)
    End Sub


#End Region

#Region "Event"


    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Select Case wJOB
            Case 1
                If DataCheck(Me, "PFK2351") = False Then Exit Sub
                'Call DATA_MOVE()
                Me.Dispose()
            Case 2
                Me.Dispose()
            Case 3
                If DataCheck(Me, "PFK2351") = False Then Exit Sub
                'Call DATA_MOVE()
                Me.Dispose()

            Case 4
                If txt_MaterialInBoundNo.Data <> System_Date_8() Then
                    MsgBoxP("Can not edit because of not today!")
                    If MsgBoxPPW("Please type the password to modify!", const_pwGreyInbound) = False Then Exit Sub
                End If
                Call DATA_DELETE()
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

        If txt_MaterialInBoundNo.Data <> System_Date_8() Then
            MsgBoxP("Can not edit because of not today!")
            If MsgBoxPPW("Please type the password to modify!", const_pwGreyInbound) = False Then Exit Sub
        End If

        Dim str As String = MsgBoxP("Do you want to delete it?", vbYesNo)

        If str <> vbYes Then Exit Sub

        Call DATA_DELETE()
    End Sub

    Private Sub Vs1_ButtonClicked(sender As Object, e As EditorNotifyEventArgs) Handles Vs1.ButtonClicked
        Dim ColWHYarnCode As Integer
        Dim ColWHYarnName As Integer
        Dim ColWHPositionCode As Integer
        Dim ColWHPositionName As Integer

        ColWHYarnCode = CDblp(getColumIndex(Vs1, "cdWareHouseNameYarn"))
        ColWHYarnName = CDblp(getColumIndex(Vs1, "cdWareHouseNameYarnName"))
        ColWHPositionCode = CDblp(getColumIndex(Vs1, "cdWareHousePositionYarn"))
        ColWHPositionName = CDblp(getColumIndex(Vs1, "cdWareHousePositionYarnName"))

        Select Case e.Column
            Case ColWHYarnCode
                If READ_PFK7171(Const_WareHouseGroup, Const_WareHouseGroup_002) = True Then
                    HLPNA = D7171.Check6
                    Dim f As New Form
                    f = New HLP7171ALL
                    f.ShowDialog()
                    If hlp0000SeVaTt = "" Or hlp0000SeVaTt = "" Then Exit Sub
                    setData(Vs1, ColWHYarnCode, e.Row, hlp0000SeVaTt)
                    setData(Vs1, ColWHYarnName, e.Row, hlp0000SeVa)
                    setData(Vs1, ColWHPositionCode, e.Row, "")
                    setData(Vs1, ColWHPositionName, e.Row, "")
                    Vs1.ActiveSheet.ActiveColumnIndex = ColWHYarnName + 1 : Vs1.ActiveSheet.ActiveRowIndex = e.Row
                    Vs1.Focus()
                End If
            Case ColWHPositionCode
                If getData(Vs1, ColWHYarnCode, e.Row) <> "" Then
                    HLP7271A.Link_ISUD7271A(Const_WareHouseGroup_002, getData(Vs1, ColWHYarnCode, e.Row))
                    If hlp0000SeVaTt = "" Or hlp0000SeVaTt = "" Then Exit Sub
                    setData(Vs1, ColWHPositionCode, e.Row, hlp0000SeVaTt)
                    setData(Vs1, ColWHPositionName, e.Row, hlp0000SeVa)
                    Vs1.ActiveSheet.ActiveColumnIndex = ColWHPositionName + 1 : Vs1.ActiveSheet.ActiveRowIndex = e.Row
                    Vs1.Focus()
                End If
        End Select
    End Sub

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        If e.ColumnHeader = True Then Exit Sub

        txt_WeavingRollInbound.Data = getData(Vs1, getColumIndex(Vs1, "MaterialInBoundNo"), Vs1.ActiveSheet.ActiveRowIndex) & "-" & _
                                      getData(Vs1, getColumIndex(Vs1, "MaterialInBoundSeq"), Vs1.ActiveSheet.ActiveRowIndex) & "-" & _
                                      getData(Vs1, getColumIndex(Vs1, "MaterialInBoundSno"), Vs1.ActiveSheet.ActiveRowIndex)

    End Sub
    Private Sub vS1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown
        Dim xCOL As Integer
        Dim xROW As Integer

        xCOL = Vs1.ActiveSheet.ActiveColumnIndex
        xROW = Vs1.ActiveSheet.ActiveRowIndex

        Select Case e.KeyCode
            Case Keys.Delete
                Msg_Result = MsgBoxP("Do you want to delete?", vbYesNo)

                If Msg_Result <> vbYes Then Exit Sub

                If READ_PFK2352(getData(Vs1, getColumIndex(Vs1, "KEY_MaterialInBoundNo"), xROW), getData(Vs1, getColumIndex(Vs1, "KEY_MaterialInBoundSeq"), xROW), getData(Vs1, getColumIndex(Vs1, "KEY_MaterialInBoundSno"), xROW)) = True Then
                    W2352 = D2352
                    W2352.CheckComplete = "2"
                    REWRITE_PFK2352(W2352)
                    Call Delete_History("PFK2352", W2352.MaterialInBoundNo & "-" & W2352.MaterialInBoundSeq)
                    setData(Vs1, getColumIndex(Vs1, "CheckComplete"), xROW, "0", , True)
                    SPR_FORECOLORROW(Vs1, Color.Black, xROW)
                    Vs1.Focus()
                Else
                    Vs1.Focus()
                End If

        End Select
    End Sub


    Private Sub txt_InboundYarnNo_txtTextKeyDown(sender As Object, e As KeyEventArgs) Handles txt_WeavingRollInbound.txtTextKeyDown
        If e.KeyCode = Keys.Enter Then
           
            If DataCheck(Me, "PFK2351") = False Then MsgBoxP("Please fill the information first !") : Exit Sub

            Call DATA_SEARCH_VS1_INSERT_INSIDE()
            txt_WeavingRollInbound.Data = ""
            Me.Show()
            Application.DoEvents()
            Setfocus(txt_WeavingRollInbound)
        End If
    End Sub

    Private Function CheckSameData() As Boolean
        CheckSameData = False
        Dim WeavingRollNo As String
        Dim i As Integer

        txt_WeavingRollInbound.Data = FormatCut(txt_WeavingRollInbound.Data)

        Try
            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                WeavingRollNo = getData(Vs1, getColumIndex(Vs1, "MaterialInBoundNo"), i) &
                                getData(Vs1, getColumIndex(Vs1, "MaterialInBoundSeq"), i) &
                                getData(Vs1, getColumIndex(Vs1, "MaterialInBoundSno"), i)

                If txt_WeavingRollInbound.Data = WeavingRollNo Then
                    Exit Function
                End If
            Next
            CheckSameData = True

        Catch ex As Exception
            MsgBoxP("CheckSameData")
        End Try
    End Function

#End Region




End Class