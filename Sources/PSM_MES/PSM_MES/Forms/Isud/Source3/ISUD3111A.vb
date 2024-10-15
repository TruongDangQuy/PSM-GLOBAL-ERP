Public Class ISUD3111A

#Region "Variable"
    Private wJOB As Integer

    Private W3111 As T3111_AREA
    Private L3111 As T3111_AREA

    Private W3113 As T3113_AREA
    Private L3113 As T3113_AREA

    Private WRITE_CHK As String
    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD3111A(job As Integer, RequestPurchasingNo As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D3111.RequestPurchasingNo = RequestPurchasingNo

        wJOB = job : L3111 = D3111

        Link_ISUD3111A = False
        Try

            Select Case job
                Case 1
                Case Else
                    If READ_PFK3111(L3111.RequestPurchasingNo) = False Then
                        Call MsgBoxP("3", "LINK_ISUD")

                        Me.Dispose()
                        Exit Function
                    Else
                        L3111 = D3111
                    End If
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD3111A = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Material PROCESSING"))
        End Try


    End Function
#End Region

#Region "Form"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        Me.Form_Initial()
        Me.Form_KeyDown()

        Call DATA_INIT()
        Call FORM_INIT()

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        Select Case wJOB
            Case 1                                                      'ÀÔ·Â
                Me.Text = Me.Text & " - INSERT"
                Frame1.Enabled = True
                cmd_DEL.Visible = False

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call KEY_COUNT()
                DATA_SEARCH02()
            Case 2
                Me.Text = Me.Text & " - SEARCH"

                Frame1.Enabled = True
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
                Call DATA_SEARCH02()
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
                        Call MsgBoxP("Only Search !"): cmd_OK.Visible = False
                    End If
                End If
                Frame1.Enabled = True
                txt_RequestPurchasingNo.Enabled = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH02()

            Case 4                                                      '»èÁ¦
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
                Call DATA_SEARCH02()

        End Select

        formA = True
    End Sub
#End Region

#Region "Search"
    Private Function DATA_SEARCH01() As Boolean

        DATA_SEARCH01 = False



        DS1 = READ_PFK3111(L3111.RequestPurchasingNo, cn)
        If GetDsRc(DS1) = 0 Then
            Exit Function : Me.Dispose()
            isudCHK = False
        End If

        READER_MOVE(Me, DS1)

        CheckProcessPurchsing(GetDsData(DS1, 0, "K3111_CheckProcessPurchsing"))
        CheckMarketType(GetDsData(DS1, 0, "K3111_CheckMarketType"))

        If READ_PFK7101(txt_CustomerPurchasing.Data) = True Then
            txt_CustomerPurchasing.Data = D7101.CustomerName
        End If

        DATA_SEARCH01 = True

    End Function

    Private Function DATA_SEARCH02() As Boolean
        DATA_SEARCH02 = False



        DS1 = PrcDS("USP_ISUD3111A_SEARCH_VS1", cn, L3111.RequestPurchasingNo, Const_UnitPrice)

        If GetDsRc(DS1) = 0 Then
            SPR_SET(Vs1, , , , OperationMode.Normal)
            SPR_PRO(Vs1, DS1, "USP_ISUD3111A_SEARCH_VS1", "Vs1")
            Vs1.ActiveSheet.RowCount = 1
            Vs1.Enabled = True
            Exit Function
        End If

        txt_DateExchange.Data = GetDsData(DS1, 0, "DateExchange")
        txt_PriceExchange.Data = GetDsData(DS1, 0, "PriceExchange")

        SPR_SET(Vs1, , , , OperationMode.Normal)
        SPR_PRO(Vs1, DS1, "USP_ISUD3111A_SEARCH_VS1", "Vs1")

        DATA_SEARCH02 = True


    End Function
#End Region

#Region "Function"
    Private Sub CheckProcessPurchsing(Process As String)
        Select Case Process
            Case "1" : rad_CheckProcessPurchsing1.Checked = True
            Case "2" : rad_CheckProcessPurchsing2.Checked = True
            Case "3" : rad_CheckProcessPurchsing3.Checked = True
            Case Else : rad_CheckProcessPurchsing1.Checked = True
        End Select
    End Sub

    Private Sub CheckMarketType(Market As String)
        Select Case Market
            Case "1" : rad_CheckMarketType1.Checked = True
            Case "2" : rad_CheckMarketType2.Checked = True
            Case Else : rad_CheckMarketType1.Checked = True
        End Select
    End Sub

    Private Sub DATA_MOVE()



    End Sub

    Private Sub DATA_MOVE_WRITE01()

        Dim i As Integer
        Dim j As Integer
        j = 0
        For i = 0 To Vs1.ActiveSheet.RowCount - 1
            If Trim(getData(Vs1, getColumIndex(Vs1, "MaterialCode"), i)) = "" Then GoTo skip
            If Trim(getData(Vs1, getColumIndex(Vs1, "cdUnitPricePurchasing"), i)) = "" Then GoTo skip
            If Trim(getData(Vs1, getColumIndex(Vs1, "AmountOrderUSD"), i)) = "" Then GoTo skip
            j = j + 1
            If K3113_MOVE(Vs1, i, W3113, txt_RequestPurchasingNo.Data, getData(Vs1, getColumIndex(Vs1, "KEY_RequestPurchasingSeq"), i)) = True Then
                W3113.RequestPurchasingNo = L3111.RequestPurchasingNo
                W3113.RequestPurchasingSeq = getData(Vs1, getColumIndex(Vs1, "KEY_RequestPurchasingSeq"), i)
                W3113.Dseq = j
                W3113.CheckRequestPurchasing = D3113.CheckRequestPurchasing
                W3113.DateRequestPurchasing = txt_DateRequestPurchasing.Data

                W3113.PriceExchange = txt_PriceExchange.Data
                W3113.DateExchange = txt_DateExchange.Data

                Call REWRITE_PFK3113(W3113)
            Else
                W3113.RequestPurchasingNo = L3111.RequestPurchasingNo
                W3113.Dseq = j
                KEY_COUNT_3113()
                W3113.CheckRequestPurchasing = "1"
                W3113.DateRequestPurchasing = txt_DateRequestPurchasing.Data

                W3113.PriceExchange = txt_PriceExchange.Data
                W3113.DateExchange = txt_DateExchange.Data

                Call WRITE_PFK3113(W3113)
            End If
skip:

        Next

    End Sub


    Private Sub DATA_INSERT()

        Try
            Call DATA_MOVE()
            Call KEY_COUNT()
            K3111_MOVE(Me, W3111, 1, txt_RequestPurchasingNo.Data)
            If rad_CheckMarketType1.Checked = True Then W3111.CheckMarketType = "1"
            If rad_CheckMarketType2.Checked = True Then W3111.CheckMarketType = "2"
            If rad_CheckProcessPurchsing1.Checked = True Then W3111.CheckProcessPurchsing = "1"
            If rad_CheckProcessPurchsing2.Checked = True Then W3111.CheckProcessPurchsing = "2"
            If rad_CheckProcessPurchsing3.Checked = True Then W3111.CheckProcessPurchsing = "3"

            If WRITE_PFK3111(W3111) = True Then
                Call DATA_MOVE_WRITE01()

                isudCHK = True : WRITE_CHK = "*"
                Exit Sub
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub DATA_UPDATE()
        Try
            K3111_MOVE(Me, W3111, 3, txt_RequestPurchasingNo.Data)
            If rad_CheckMarketType1.Checked = True Then W3111.CheckMarketType = "1"
            If rad_CheckMarketType2.Checked = True Then W3111.CheckMarketType = "2"
            If rad_CheckProcessPurchsing1.Checked = True Then W3111.CheckProcessPurchsing = "1"
            If rad_CheckProcessPurchsing2.Checked = True Then W3111.CheckProcessPurchsing = "2"
            If rad_CheckProcessPurchsing3.Checked = True Then W3111.CheckProcessPurchsing = "3"
            If REWRITE_PFK3111(W3111) = True Then
                Call DATA_MOVE_WRITE01()

                isudCHK = True
                Me.Dispose()
            End If

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

    Private Sub DATA_DELETE()
        Try


            Dim i As Integer
            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If Trim(getData(Vs1, getColumIndex(Vs1, "KEY_RequestPurchasingNo"), i)) = "" Then GoTo skip
                If Trim(getData(Vs1, getColumIndex(Vs1, "KEY_RequestPurchasingSeq"), i)) = "" Then GoTo skip
                W3113.RequestPurchasingNo = getData(Vs1, getColumIndex(Vs1, "KEY_RequestPurchasingNo"), i)
                W3113.RequestPurchasingSeq = getData(Vs1, getColumIndex(Vs1, "KEY_RequestPurchasingSeq"), i)
                If K3113_MOVE(Vs1, i, W3113, W3113.RequestPurchasingNo, W3113.RequestPurchasingSeq) = True Then
                    If W3113.CheckRequestPurchasing <> "1" Then MsgBoxP("Approval already at row " & getData(Vs1, getColumIndex(Vs1, "Dseq"), i)) : Exit Sub
                    DELETE_PFK3113(W3113)
                End If
skip:
            Next

            If READ_PFK3111(L3111.RequestPurchasingNo) = True Then
                W3111 = D3111
                Call DELETE_PFK3111(W3111)
            End If
            isudCHK = True : Me.Dispose() : Exit Sub

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub
    Private Sub KEY_COUNT_3113()
        Try


            SQL = "SELECT MAX(CAST(K3113_RequestPurchasingSeq AS DECIMAL)) AS MAX_MCODE FROM PFK3113 "
            SQL = SQL & " WHERE K3113_RequestPurchasingNo = '" & txt_RequestPurchasingNo.Data & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W3113.RequestPurchasingSeq = "1"
            Else
                W3113.RequestPurchasingSeq = Format(CInt(rd!MAX_MCODE + 1), "0")
            End If

            rd.Close()

            W3113.RequestPurchasingSeq = W3113.RequestPurchasingSeq

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub
    Private Sub KEY_COUNT()

        Dim YRNO As Integer
        YRNO = Mid(System_Date_8(), 3, 4)

        Try
            SQL = "SELECT MAX(CAST(SUBSTRING(K3111_RequestPurchasingNo,7,3) AS DECIMAL)) AS MAX_MCODE FROM PFK3111 "
            SQL = SQL & " WHERE SUBSTRING(K3111_RequestPurchasingNo,3,4) = '" & YRNO.ToString & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W3111.RequestPurchasingNo = "SP" & YRNO & "001"
            Else
                W3111.RequestPurchasingNo = "SP" & YRNO & Format(CInt(rd!MAX_MCODE + 1), "000")
            End If

            rd.Close()

            txt_RequestPurchasingNo.Data = W3111.RequestPurchasingNo
            L3111.RequestPurchasingNo = W3111.RequestPurchasingNo

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

    Private Sub DATA_INIT()
        Try
            txt_RequestPurchasingNo.Enabled = False

            Call D3111_CLEAR()

            txt_DateRequestPurchasing.Data = System_Date_8()
            txt_DateDelivery.Data = System_Date_8()
            txt_DateExchange.Data = System_Date_8()
            txt_DateFinish.Data = System_Date_8()
            txt_DateSart.Data = System_Date_8()

            W3111 = D3111

            W3113 = D3113
            L3113 = D3113

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Sub FORM_INIT()

    End Sub

#End Region

#Region "Event"
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Select Case wJOB
            Case 1
                If DataCheck(Me, "PFK3111") = False Then Exit Sub
                Call DATA_INSERT()
                Me.Dispose()
            Case 2
                Me.Dispose()
            Case 3
                If DataCheck(Me, "PFK3111") = False Then Exit Sub
                Call DATA_UPDATE()
            Case 4
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

        Dim str As String = MsgBoxP("Do you want to delete it?", vbYesNo)

        If str <> vbYes Then Exit Sub

        Call DATA_DELETE()
    End Sub

    Private Sub Vs1_ButtonClicked(sender As Object, e As EditorNotifyEventArgs) Handles Vs1.ButtonClicked
        Select Case e.Column
            Case getColumIndex(Vs1, "MaterialCode")
                HLPCHECK("btn_MaterialSearch")
                If hlp0000SeVaTt = "" Or hlp0000SeVa = "" Then Exit Sub
                setData(Vs1, getColumIndex(Vs1, "MaterialCode"), e.Row, hlp0000SeVaTt)
                setData(Vs1, getColumIndex(Vs1, "MaterialName"), e.Row, hlp0000SeVa)
                Vs1.ActiveSheet.ActiveColumnIndex = 8 : Vs1.ActiveSheet.ActiveRowIndex = e.Row

                Vs1.Focus()
            Case getColumIndex(Vs1, "cdUnitPricePurchasing")
                HLPCHECK("Const_UnitPrice")
                If hlp0000SeVaTt = "" Or hlp0000SeVa = "" Then Exit Sub
                setData(Vs1, getColumIndex(Vs1, "cdUnitPricePurchasing"), e.Row, hlp0000SeVaTt)
                setData(Vs1, getColumIndex(Vs1, "cdUnitPricePurchasingName"), e.Row, hlp0000SeVa)
                Vs1.ActiveSheet.ActiveColumnIndex = 8 : Vs1.ActiveSheet.ActiveRowIndex = e.Row

                Vs1.Focus()
        End Select

        vSChange(e.Row)
    End Sub

    Private Sub Vs1_Change(sender As Object, e As ChangeEventArgs) Handles Vs1.Change
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
        setData(Vs1, getColumIndex(Vs1, "WgtBox"), xROW, CDecp(getData(Vs1, getColumIndex(Vs1, "WgtCone"), xROW) * CDecp(getData(Vs1, getColumIndex(Vs1, "ConeBox"), xROW))))
        setData(Vs1, getColumIndex(Vs1, "ConeRequestPurchasing"), xROW, CDecp(getData(Vs1, getColumIndex(Vs1, "BoxRequestPurchasing"), xROW) * CDecp(getData(Vs1, getColumIndex(Vs1, "ConeBox"), xROW))))
        If CDecp(getData(Vs1, getColumIndex(Vs1, "ConeBox"), xROW)) > 0 Then
            setData(Vs1, getColumIndex(Vs1, "BoxRequestPurchasing"), xROW, CDecp(getData(Vs1, getColumIndex(Vs1, "ConeRequestPurchasing"), xROW) / CDecp(getData(Vs1, getColumIndex(Vs1, "ConeBox"), xROW))))
        End If

        setData(Vs1, getColumIndex(Vs1, "WgtRequestPurchasing"), xROW, CDecp(getData(Vs1, getColumIndex(Vs1, "BoxRequestPurchasing"), xROW) * CDecp(getData(Vs1, getColumIndex(Vs1, "WgtBox"), xROW))))

        If CDecp(getData(Vs1, getColumIndex(Vs1, "PricePurchasing"), xROW)) > 0 And CDecp(getData(Vs1, getColumIndex(Vs1, "WgtRequestPurchasing"), xROW)) > 0 Then
            If getData(Vs1, getColumIndex(Vs1, "cdUnitPricePurchasingName"), xROW).ToString.ToUpper = "USD" Then
                setData(Vs1, getColumIndex(Vs1, "PricePurchasingUSD"), xROW, CDecp(getData(Vs1, getColumIndex(Vs1, "PricePurchasing"), xROW)))
                setData(Vs1, getColumIndex(Vs1, "PricePurchasingVND"), xROW, CDecp(getData(Vs1, getColumIndex(Vs1, "PricePurchasingUSD"), xROW) * CDecp(txt_PriceExchange.Data)))
                setData(Vs1, getColumIndex(Vs1, "AmountOrderUSD"), xROW, CDecp(getData(Vs1, getColumIndex(Vs1, "PricePurchasingUSD"), xROW) * _
                                                                                         CDecp(getData(Vs1, getColumIndex(Vs1, "WgtRequestPurchasing"), xROW))))
                setData(Vs1, getColumIndex(Vs1, "AmountOrderVND"), xROW, CDecp(getData(Vs1, getColumIndex(Vs1, "AmountOrderUSD"), xROW) * CDecp(txt_PriceExchange.Data)))
            ElseIf getData(Vs1, getColumIndex(Vs1, "cdUnitPricePurchasingName"), xROW).ToString.ToUpper = "VND" Then
                If CDecp(txt_PriceExchange.Data) = 0 Then Exit Sub
                setData(Vs1, getColumIndex(Vs1, "PricePurchasingVND"), xROW, CDecp(getData(Vs1, getColumIndex(Vs1, "PricePurchasing"), xROW)))
                setData(Vs1, getColumIndex(Vs1, "PricePurchasingUSD"), xROW, CDecp(getData(Vs1, getColumIndex(Vs1, "PricePurchasingVND"), xROW) / CDecp(txt_PriceExchange.Data)))
                setData(Vs1, getColumIndex(Vs1, "AmountOrderUSD"), xROW, CDecp(getData(Vs1, getColumIndex(Vs1, "PricePurchasingUSD"), xROW) * _
                                                                                         CDecp(getData(Vs1, getColumIndex(Vs1, "WgtRequestPurchasing"), xROW))))
                setData(Vs1, getColumIndex(Vs1, "AmountOrderVND"), xROW, CDecp(getData(Vs1, getColumIndex(Vs1, "AmountOrderUSD"), xROW) * CDecp(txt_PriceExchange.Data)))

            End If
        End If
    End Sub

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub

    Private Sub vS1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown
        Dim xCOL As Long
        Dim xROW As Long

        xCOL = Vs1.ActiveSheet.ActiveColumnIndex
        xROW = Vs1.ActiveSheet.ActiveRowIndex

        Select Case e.KeyCode
            Case Keys.Delete

                Msg_Result = MsgBoxP("Do you want to delete?", vbYesNo)

                If Msg_Result <> vbYes Then Exit Sub

                If Trim(getData(Vs1, getColumIndex(Vs1, "KEY_RequestPurchasingSeq"), xROW)) = "" Then Exit Sub

                W3113.RequestPurchasingNo = txt_RequestPurchasingNo.Data
                W3113.RequestPurchasingSeq = getData(Vs1, getColumIndex(Vs1, "KEY_RequestPurchasingSeq"), xROW)
                If READ_PFK3113(W3113.RequestPurchasingNo, W3113.RequestPurchasingSeq) = True Then
                    If D3113.CheckRequestPurchasing <> "1" Then MsgBoxP("Check condition at row " & xROW) : Exit Sub
                    DELETE_PFK3113(W3113)
                End If
                SPR_DEL(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex)
                Vs1.Focus()

            Case Keys.Enter
                Select Case xCOL
                    Case getColumIndex(Vs1, "MaterialCode")
                        HLPCHECK("btn_MaterialSearch")
                        setData(Vs1, getColumIndex(Vs1, "MaterialCode"), xROW, hlp0000SeVaTt)
                        setData(Vs1, getColumIndex(Vs1, "MaterialName"), xROW, hlp0000SeVa)
                        Vs1.ActiveSheet.ActiveColumnIndex = getColumIndex(Vs1, "MaterialCode") + 1 : Vs1.ActiveSheet.ActiveRowIndex = xROW
skip_2:

                        Vs1.Focus()
                    Case getColumIndex(Vs1, "cdUnitPricePurchasing")
                        HLPCHECK("Const_UnitPrice")
                        If hlp0000SeVaTt = "" Or hlp0000SeVa = "" Then Exit Sub
                        setData(Vs1, getColumIndex(Vs1, "cdUnitPricePurchasing"), xROW, hlp0000SeVaTt)
                        setData(Vs1, getColumIndex(Vs1, "cdUnitPricePurchasingName"), xROW, hlp0000SeVa)
                        Vs1.ActiveSheet.ActiveColumnIndex = 8 : Vs1.ActiveSheet.ActiveRowIndex = xROW

                        Vs1.Focus()

                End Select
        End Select
    End Sub
    Private Sub txt_DateExchange_Load(sender As Object, e As EventArgs) Handles txt_DateExchange.m_Textchange
        Dim i As Integer
        Try
            'If READ_PFK7199(txt_DateExchange.Data) = True Then
            '    txt_PriceExchange.Data = FormatNumber(D7199.VND, 4)
            'Else
            '    PriceExchange(txt_DateExchange.Data, txt_PriceExchange, txt_DateExchange)
            'End If

            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If CDecp(getData(Vs1, getColumIndex(Vs1, "ConeBox"), i)) > 0 Then
                    Call vSChange(i)
                End If
            Next
        Catch ex As Exception

        End Try

    End Sub
#End Region

   
End Class