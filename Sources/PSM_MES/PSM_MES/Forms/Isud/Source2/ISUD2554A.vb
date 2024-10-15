Public Class ISUD2554A

#Region "Variable"
    Private wJOB As Integer

    Private W2554 As New T2554_AREA
    Private L2554 As New T2554_AREA

    Private WRITE_CHK As String
    Public gpp As Graphics
    Public twtopi As Decimal = 39.5

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Form"


    Public Function Link_ISUD2554A(job As Integer, DateAudit As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D2554.DateAudit = DateAudit
        wJOB = job : L2554 = D2554

        txt_DateAudit.Data = DateAudit

        Link_ISUD2554A = False
        Try

            Select Case job
                Case 1
                Case Else

            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD2554A = isudCHK


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
                Call DATA_SEARCH_VS2()

                Me.Show()
                Application.DoEvents()
                txt_Barcode.PeaceTextbox1.Focus()
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
                Call DATA_SEARCH_VS2()

                Frame1.Enabled = True
                cmd_DEL.Visible = False
                cmd_OK.Visible = False
            Case 3
                Me.Text = Me.Text & " - UPDATE"

                If CHK(3) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If
                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()

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
                Call DATA_SEARCH_VS2()

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
            DS1 = PrcDS("USP_ISUD2554A_SEARCH_VS1", cn, txt_DateAudit.Data)

            If GetDsRc(DS1) = 0 Then
                SPR_SET(Vs1, , , 1, OperationMode.SingleSelect)
                SPR_PRO(Vs1, DS1, "USP_ISUD2554A_SEARCH_VS1", "vS1")
                Vs1.Enabled = True
                Exit Function
            End If
            SPR_SET(Vs1, , , , OperationMode.SingleSelect)
            SPR_PRO(Vs1, DS1, "USP_ISUD2554A_SEARCH_VS1", "Vs1")
            Call Calculation()
            DATA_SEARCH_VS1 = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try
    End Function

    Private Function DATA_SEARCH_VS2() As Boolean
        DATA_SEARCH_VS2 = False
        Try
            DS1 = PrcDS("USP_ISUD2554A_SEARCH_VS2", cn, txt_DateAudit.Data)

            If GetDsRc(DS1) = 0 Then
                SPR_SET(vS2, , , 1, OperationMode.SingleSelect)
                SPR_PRO(vS2, DS1, "USP_ISUD2554A_SEARCH_VS2", "VS2")
                vS2.Enabled = True
                Exit Function
            End If
            SPR_SET(vS2, , , , OperationMode.SingleSelect)
            SPR_PRO(vS2, DS1, "USP_ISUD2554A_SEARCH_VS2", "VS2")
            Call Calculation()
            DATA_SEARCH_VS2 = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS2")
        End Try
    End Function


    Private Sub Calculation()
        txt_CntRoll.Data = Vs1.ActiveSheet.RowCount
        Dim i As Integer
        Dim TotalN As Decimal = 0
        Dim TotalQ As Decimal = 0

        For i = 0 To Vs1.ActiveSheet.RowCount - 1
            If CIntp(getDataM(Vs1, getColumIndex(Vs1, "KEY_Autokey"), i)) > 0 Then
                TotalN += 1
                TotalQ += CDecp(getData(Vs1, getColumIndex(Vs1, "QtyAudit"), i))

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
        Dim xrow As Integer = 0

        Try
            txt_Barcode.Data = FormatCut(txt_Barcode.Data)

            If txt_Barcode.Data.Trim.Length > 12 Then
                MaterialInBoundNo = Strings.Left(txt_Barcode.Data, 9)
                MaterialInBoundSeq = Strings.Mid(txt_Barcode.Data, 10, 3)
                MaterialInBoundSno = Strings.Mid(txt_Barcode.Data, 13)
            Else
                MsgBoxP("Barcode is wrong information!")
                MaterialInBoundNo = ""
                MaterialInBoundSeq = ""
                MaterialInBoundSno = ""

                txt_MaterialInBoundNo.Data = ""
                txt_MaterialInBoundSeq.Data = ""
                txt_MaterialInBoundSno.Data = ""
                txt_MaterialName.Data = ""

                Exit Function
            End If

            If READ_PFK2352(MaterialInBoundNo, MaterialInBoundSeq, MaterialInBoundSno) = True Then
                txt_MaterialInBoundNo.Data = MaterialInBoundNo
                txt_MaterialInBoundSeq.Data = MaterialInBoundSeq
                txt_MaterialInBoundSno.Data = MaterialInBoundSno

                txt_QtyAudit.Data = D2352.QtyInBound - D2352.QtyOutBound

                If READ_PFK2351(D2352.MaterialInBoundNo, D2352.MaterialInBoundSeq) Then

                    If READ_PFK7231(D2351.MaterialCode) Then
                        txt_MaterialName.Data = D7231.MaterialName

                    End If
                End If

                DATA_SEARCH_VS1_INSERT_INSIDE = True
                cmd_OK.PerformClick()

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

            If READ_PFK2352(txt_MaterialInBoundNo.Data, txt_MaterialInBoundSeq.Data, txt_MaterialInBoundSno.Data) = True Then
                W2554.PackAudit = 1
                W2554.DateAudit = txt_DateAudit.Data

                W2554.MaterialInBoundDseq = D2352.MaterialInBoundDseq
                W2554.MaterialInBoundNo = D2352.MaterialInBoundNo
                W2554.MaterialInBoundSeq = D2352.MaterialInBoundSeq
                W2554.MaterialInBoundSno = D2352.MaterialInBoundSno

                W2554.QtyAudit = CDecp(txt_QtyAudit.Data)

                If WRITE_PFK2554(W2554) = True Then
                    isudCHK = True
                    Call READ_PFK2351(W2554.MaterialInBoundNo, W2554.MaterialInBoundSeq)

                    Call READ_PFK7231(D2351.MaterialCode)

                    Vs1.ActiveSheet.RowCount += 1

                    Dim sTRINGaUDITO As String

                    sTRINGaUDITO = READ_PFK2554_AUTOKEY(W2554.MaterialInBoundNo, W2554.MaterialInBoundSeq, W2554.MaterialInBoundSno)

                    setData(Vs1, getColumIndex(Vs1, "KEY_MaterialInboundNo"), Vs1.ActiveSheet.RowCount - 1, W2554.MaterialInBoundNo)
                    setData(Vs1, getColumIndex(Vs1, "KEY_MaterialInboundSeq"), Vs1.ActiveSheet.RowCount - 1, W2554.MaterialInBoundSeq)
                    setData(Vs1, getColumIndex(Vs1, "KEY_MaterialInBoundSno"), Vs1.ActiveSheet.RowCount - 1, W2554.MaterialInBoundSno)
                    setData(Vs1, getColumIndex(Vs1, "KEY_Autokey"), Vs1.ActiveSheet.RowCount - 1, sTRINGaUDITO)
                    setData(Vs1, getColumIndex(Vs1, "Autokey"), Vs1.ActiveSheet.RowCount - 1, sTRINGaUDITO)
                    setData(Vs1, getColumIndex(Vs1, "DateAudit"), Vs1.ActiveSheet.RowCount - 1, W2554.DateAudit)
                    setData(Vs1, getColumIndex(Vs1, "MaterialCode"), Vs1.ActiveSheet.RowCount - 1, D7231.MaterialCode)
                    setData(Vs1, getColumIndex(Vs1, "MaterialName"), Vs1.ActiveSheet.RowCount - 1, D7231.MaterialName)
                    setData(Vs1, getColumIndex(Vs1, "PackInBound"), Vs1.ActiveSheet.RowCount - 1, "1")
                    setData(Vs1, getColumIndex(Vs1, "QtyInBound"), Vs1.ActiveSheet.RowCount - 1, D2352.QtyInBound)
                    setData(Vs1, getColumIndex(Vs1, "PackAudit"), Vs1.ActiveSheet.RowCount - 1, "1")
                    setData(Vs1, getColumIndex(Vs1, "QtyAudit"), Vs1.ActiveSheet.RowCount - 1, W2554.QtyAudit)
                    setData(Vs1, getColumIndex(Vs1, "MaterialInboundNo"), Vs1.ActiveSheet.RowCount - 1, W2554.MaterialInBoundNo)
                    setData(Vs1, getColumIndex(Vs1, "MaterialInboundSeq"), Vs1.ActiveSheet.RowCount - 1, W2554.MaterialInBoundSeq)
                    setData(Vs1, getColumIndex(Vs1, "MaterialInBoundSno"), Vs1.ActiveSheet.RowCount - 1, W2554.MaterialInBoundSno)
                    setData(Vs1, getColumIndex(Vs1, "Remark"), Vs1.ActiveSheet.RowCount - 1, "")

                End If

            End If

        Catch ex As Exception
            MsgBoxP("DATA_MOVE!")
        End Try
    End Function

    Private Sub DATA_UPDATE()
        Try



        Catch ex As Exception
            Call MsgBoxP("DATA_UPDATE")
        End Try
    End Sub

    Private Sub DATA_DELETE()
        Dim i As Integer



        Try
            'For i = 0 To Vs1.ActiveSheet.RowCount - 1
            '    If READ_PFK2554(getData(Vs1, getColumIndex(Vs1, "KEY_Autokey"), i)) = True Then
            '        W2554 = D2554
            '        DELETE_PFK2554(W2554)
            '    End If

            'Next
            Dim xROW As Integer = Vs1.ActiveSheet.ActiveRowIndex

            If READ_PFK2554(getData(Vs1, getColumIndex(Vs1, "KEY_Autokey"), xROW)) = True Then
                W2554 = D2554
                Call DELETE_PFK2554(W2554)
                isudCHK = True
                SPR_DEL(Vs1, 0, xROW)
            Else
                Vs1.Focus()
            End If

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub
    Private Sub DATA_LINE_DELETE(xrow As Integer)
        Try
            If READ_PFK2554(getData(Vs1, getColumIndex(Vs1, "KEY_Autokey"), xrow)) = True Then
                W2554 = D2554
                DELETE_PFK2554(W2554)
                SPR_DEL(Vs1, 0, xrow)
            End If

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_LINE_DELETE")
        End Try

    End Sub

    Private Sub DATA_INIT()
        Try
            txt_Barcode.Data = ""
            txt_MaterialInBoundNo.Data = ""
            txt_MaterialInBoundSeq.Data = ""
            txt_MaterialInBoundSno.Data = ""

            txt_QtyAudit.Data = ""
            txt_MaterialName.Data = ""

            Me.Show()
            Application.DoEvents()
            Setfocus(txt_Barcode)

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Sub FORM_INIT()
        RemoveHandler txt_Barcode.PeaceTextbox1.KeyDown, AddressOf standard_KeyDown

        txt_Barcode.PeaceTextbox1.Properties.CharacterCasing = CharacterCasing.Upper
        txt_DateAudit.Enabled = False
    End Sub

    Private Sub vS1_DATA_INSERT(xrow As Integer)

    End Sub


#End Region

#Region "Event"


    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Select Case wJOB
            Case 1
                If DataCheck(Me, "PFK2554") = False Then Exit Sub
                Call DATA_MOVE()
                Calculation()

                Call DATA_INIT()


            Case 2
                Me.Dispose()
            Case 3
                If DataCheck(Me, "PFK2554") = False Then Exit Sub
                Call DATA_MOVE()
                Calculation()

                Call DATA_INIT()

            Case 4
                If txt_DateAudit.Data <> System_Date_8() Then
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

        If txt_DateAudit.Data <> System_Date_8() Then
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

        txt_Barcode.Data = getData(Vs1, getColumIndex(Vs1, "MaterialInBoundNo"), Vs1.ActiveSheet.ActiveRowIndex) & "-" & _
                                      getData(Vs1, getColumIndex(Vs1, "MaterialInBoundSeq"), Vs1.ActiveSheet.ActiveRowIndex) & "-" & _
                                      getData(Vs1, getColumIndex(Vs1, "MaterialInBoundSno"), Vs1.ActiveSheet.ActiveRowIndex)

    End Sub

    Private Sub Vs1_Change(sender As Object, e As ChangeEventArgs) Handles Vs1.Change


        If READ_PFK2554(getData(Vs1, getColumIndex(Vs1, "KEY_AUTOKEY"), e.Row)) = True Then
            W2554 = D2554
            W2554.QtyAudit = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyAudit"), e.Row))

            Call REWRITE_PFK2554(W2554)

        End If

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

                If READ_PFK2554(getData(Vs1, getColumIndex(Vs1, "KEY_Autokey"), xROW)) = True Then
                    W2554 = D2554
                    Call DELETE_PFK2554(W2554)
                    SPR_DEL(Vs1, 0, xROW)
                Else
                    Vs1.Focus()
                End If

        End Select
    End Sub


    Private Sub txt_InboundYarnNo_txtTextKeyDown(sender As Object, e As KeyEventArgs) Handles txt_Barcode.txtTextKeyDown
        If e.KeyCode = Keys.Enter Then

            Call DATA_SEARCH_VS1_INSERT_INSIDE()
            txt_Barcode.Data = ""
            Me.Show()
            Application.DoEvents()
            Setfocus(txt_Barcode)
        End If
    End Sub

    Private Sub cmd_Refresh_Click(sender As Object, e As EventArgs) Handles cmd_Refresh.Click
        Call DATA_SEARCH_VS2()

    End Sub
#End Region

End Class