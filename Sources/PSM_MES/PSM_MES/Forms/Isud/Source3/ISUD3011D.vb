Public Class ISUD3011D
#Region "Variable"
    Private wJOB As Integer

    Private W3011 As T3011_AREA
    Private L3011 As T3011_AREA


    Private WRITE_CHK As String

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD3011D(job As Integer, OrderNo As String, OrderNoSeq As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG

        txt_OrderNo.Data = OrderNo
        txt_OrderNoSeq.Data = OrderNoSeq

        D3011.OrderNo = OrderNo
        D3011.OrderNoSeq = OrderNoSeq


        wJOB = job : L3011 = D3011

        Link_ISUD3011D = False
        Try
            Select Case job
                Case 1
                Case Else
                    If READ_PFK1312(OrderNo, OrderNoSeq) = False Then
                        Call MsgBoxP("You have no right is this ShoesCode !")
                        Me.Dispose()

                        Exit Function
                    End If
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD3011D = isudCHK


        Catch ex As Exception
            '       Call MsgBoxP("61", WordConv("GroupComponentBOM"))
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
            Case 1
                Me.Text = Me.Text & " - INSERT"
                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call KEY_COUNT()
                Call DATA_SEARCH01()

                Call DATA_SEARCH_VS1()

                Frame1.Enabled = True
                tst_iDelete.Visible = False

                Setfocus(txt_GroupComponentBOMName)

            Case 2
                Me.Text = Me.Text & " - SEARCH"
                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1_SEARCH()

                Pal_1.Enabled = False
                tst_iDelete.Visible = False
                tst_iSave.Visible = False

            Case 3
                Me.Text = Me.Text & " - UPDATE"
                If CHK(3) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()

                Frame1.Enabled = True
                txt_GroupComponentBOM.Enabled = False

                tst_iDelete.Visible = False
                tst_iSave.Visible = True

            Case 4
                Me.Text = Me.Text & " - DELETE"
                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If
                Frame1.Enabled = True

                tst_iDelete.Visible = True
                tst_iSave.Visible = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()

        End Select

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Try


        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Sub FORM_INIT()
        Vs1.AllowRowMove = True
        PeaceSplitContainer1.Panel1Collapsed = True


    End Sub
#End Region

#Region "Data_Search"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False
        Try

            txt_OrderNo.Data = L3011.OrderNo
            txt_OrderNoSeq.Data = L3011.OrderNoSeq


            If READ_PFK1312(txt_OrderNo.Data, txt_OrderNoSeq.Data) Then
                txt_DateDeliveryD.Data = D1312.PONO & "/" & D1312.DateLable
            End If

            If READ_PFK1311(txt_OrderNo.Data) Then
                txt_CustPONO.Data = D1311.CustPoNo
            End If

            DS1 = Nothing

            DATA_SEARCH01 = True

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_SEARCH01")
        End Try

    End Function

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False

        DS1 = PrcDS("USP_ISUD3011D_SEARCH_VS1", cn, txt_OrderNo.Data, txt_OrderNoSeq.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs1, DS1, "USP_ISUD3011D_SEARCH_VS1", "Vs1")
            Vs1.Enabled = True
            Exit Function
        End If
        SPR_SET(Vs1, , , , OperationMode.Normal)
        SPR_PRO_NEW(Vs1, DS1, "USP_ISUD3011D_SEARCH_VS1", "Vs1")

        W3011.Autokey = CIntp(getData(Vs1, getColumIndex(Vs1, "KEY_AutoKey"), 0))

        If READ_PFK3011(W3011.Autokey) Then
            txt_PRName.Data = D3011.PRName
        End If

        DATA_SEARCH_VS1 = True
    End Function

    Private Function DATA_SEARCH_VS1_SEARCH() As Boolean
        DATA_SEARCH_VS1_SEARCH = False

        DS1 = PrcDS("USP_ISUD3011D_SEARCH_VS1", cn, txt_OrderNo.Data, txt_OrderNoSeq.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs1, DS1, "USP_ISUD3011D_SEARCH_VS1", "Vs1")
            Vs1.Enabled = True
            Exit Function
        End If
        SPR_SET(Vs1, , , , OperationMode.Normal)
        SPR_PRO_NEW(Vs1, DS1, "USP_ISUD3011D_SEARCH_VS1", "Vs1")

        W3011.Autokey = CIntp(getData(Vs1, getColumIndex(Vs1, "KEY_AutoKey"), 0))

        If READ_PFK3011(W3011.Autokey) Then
            txt_PRName.Data = D3011.PRName
        End If

        DATA_SEARCH_VS1_SEARCH = True
    End Function

    Private Function DATA_SEARCH_VS1_CHECK() As Boolean
        DATA_SEARCH_VS1_CHECK = True
    End Function
    Private Function DATA_SEARCH_VS1_HistoryCode(HistoryCode) As Boolean
        DATA_SEARCH_VS1_HistoryCode = True
    End Function

#End Region

#Region "Function"

    Private Function Data_Check() As Boolean
        Dim i As Integer

        Data_Check = True

        Try
            If txt_PRName.Data.Trim = "" Then Setfocus(txt_PRName) : Exit Function
            'txt_GroupComponentBOMName.Data = Replace(txt_GroupComponentBOMName.Data, "'", "`")


            Data_Check = True
skip_1:
        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))

        End Try
    End Function


    Private Sub DATA_MOVE()
        Try
          
        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE"))
        End Try
    End Sub

    Private Sub KEY_COUNT_MATERIAL()


    End Sub

    Private Sub KEY_COUNT_7103()


    End Sub

    Private Sub DATA_MOVE_WRITE01()
        Try

            Dim i As Integer
            Dim j As Integer
            Dim k As Integer
            Dim l As Integer
            Dim tmpSTR1 As String = ""
            Dim tmpSTR2 As String = ""

            j = 0
            l = 0
            k = 1
            i = 0

            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                j = j + 1
                l = l + 1

                Call D3011_CLEAR() : W3011 = D3011

                W3011.OrderNo = txt_OrderNo.Data
                W3011.OrderNoSeq = txt_OrderNoSeq.Data

                W3011.AutoKey = CIntp(getData(Vs1, getColumIndex(Vs1, "KEY_AutoKey"), i))



                If READ_PFK3011(W3011.Autokey) = True Then
                    W3011 = D3011
                    W3011.QANote = getData(Vs1, getColumIndex(Vs1, "QANote"), i)
                    W3011.QANote1 = getData(Vs1, getColumIndex(Vs1, "QANote1"), i)
                    W3011.QANote2 = getData(Vs1, getColumIndex(Vs1, "QANote2"), i)
                    W3011.QANote3 = getData(Vs1, getColumIndex(Vs1, "QANote3"), i)

                    Call REWRITE_PFK3011(W3011)


                End If
skip:
            Next

            Call PrcExeNoError("USP_PFK3011B_MPODATA_QA", cn, Pub.SAW, System_Date_time, W3011.OrderNo, W3011.OrderNoSeq)

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE_WRITE01"))
        End Try

    End Sub


    Private Sub DATA_INSERT()
        Try
            Call DATA_MOVE()
            Call KEY_COUNT()

            Call DATA_MOVE_WRITE01()

            isudCHK = True : WRITE_CHK = "*"
            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INSERT")
        End Try

    End Sub

    Private Sub DATA_UPDATE()
        Try
            Call DATA_MOVE()
            Call DATA_MOVE_WRITE01()

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

    Private Sub DATA_DELETE()
        Try


        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub

    Private Sub KEY_COUNT()

    End Sub


    Private Sub KEY_COUNT_SEQ()
        Try


        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

#End Region

#Region "Event"

    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        Dim Starting As Object
        Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")

        Msg_Result = MsgBox("This is important confirmation ! Please be careful to save ! Đây là thông tin cực kỳ quan trọng. Xin lưu ý ! Bấm Yes để tiếp tục !", vbYesNo)
        If Msg_Result <> vbYes Then Exit Sub

        Try
            Select Case wJOB
                Case 1
                    If Data_Check() = False Then Exit Sub
                    If DataCheck(Me, "PFK7018") = False Then Exit Sub
                    Call KEY_COUNT()
                    Call DATA_INSERT()
                    MsgBoxP("Save Successfully!", vbInformation)
                    wJOB = 3
                    Call DATA_SEARCH01()
                    Call DATA_SEARCH_VS1()

                Case 2
                    Me.Dispose()
                Case 3
                    If Data_Check() = False Then Exit Sub
                    If DataCheck(Me, "PFK7018") = False Then Exit Sub
                    Call DATA_UPDATE()
                    MsgBoxP("Save Successfully!", vbInformation)
                    Call DATA_SEARCH01()
                    Call DATA_SEARCH_VS1()
                Case 4
                    Call DATA_DELETE()
            End Select
        Catch ex As Exception

        Finally
            Starting.close()
        End Try
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

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub


    Private Sub vS1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown
        Dim xCOL As Integer
        Dim xROW As Integer
        Dim Autokey As String

        xCOL = Vs1.ActiveSheet.ActiveColumnIndex
        xROW = Vs1.ActiveSheet.ActiveRowIndex

        Select Case e.KeyCode
            Case Keys.Delete

            Case Keys.Enter

        End Select
    End Sub



#End Region




End Class