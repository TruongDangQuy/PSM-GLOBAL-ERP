Public Class ISUD7106M

#Region "Variable"
    Private wJOB As Integer

    Private WRITE_CHK As String
    Private KEY_CHK As String

    Private W7106 As T7106_AREA
    Private L7106 As T7106_AREA

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7106M(job As Integer, ShoesCode As String, Optional ByVal TAG As String = "") As Boolean
        D7106.ShoesCode = ShoesCode
        txt_ShoesCode.Data = ShoesCode
        txt_ShoesCode.Code = ShoesCode

        wJOB = job

        Link_ISUD7106M = False

        Select Case job
            Case 1
            Case Else
                If READ_PFK7106(D7106.ShoesCode) = False Then
                    Call MsgBoxP("3", "LINK_ISUD")

                    Exit Function
                End If


        End Select

        L7106 = D7106

        formA = False
        Me.Tag = TAG
        Me.ShowDialog()

        Link_ISUD7106M = isudCHK

    End Function
#End Region

#Region "Form_load"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""
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

       
                tst_iSave.Visible = True

                Call KEY_COUNT()

            Case 2
                Me.Text = Me.Text & " - SEARCH"
                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                If CheckData_Customer(L7106.Customercode, ISUD.Search) = False Then
                    isudCHK = False
                    formA = True
                    Me.Dispose()
                    MsgBoxP("No Correct Customer !")
                    Exit Sub
                End If

                tst_iSave.Visible = False
                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()
            Case 3
                Me.Text = Me.Text & " - UPDATE"
                If CHK(3) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                If CheckData_Customer(L7106.Customercode, ISUD.Update) = False Then
                    isudCHK = False
                    formA = True
                    Me.Dispose()
                    MsgBoxP("No Correct Customer !")
                    Exit Sub
                End If

                txt_ShoesCode.Enabled = False

                tst_iSave.Visible = True

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()

            Case 4
                Me.Text = Me.Text & " - DELETE"
                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                If CheckData_Customer(L7106.Customercode, ISUD.Delete) = False Then
                    isudCHK = False
                    formA = True
                    Me.Dispose()
                    MsgBoxP("No Correct Customer !")
                    Exit Sub
                End If


                tst_iSave.Visible = False

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH()
                Call DATA_SEARCH_VS1()

            Case 5
                Me.Text = Me.Text & " - COPY"

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                If CheckData_Customer(L7106.Customercode, ISUD.Insert) = False Then
                    isudCHK = False
                    formA = True
                    Me.Dispose()
                    MsgBoxP("No Correct Customer !")
                    Exit Sub
                End If

                tst_iSave.Visible = True

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH()
                Call DATA_SEARCH_VS1()
                Call KEY_COUNT()

                wJOB = 1
            Case 6
                Me.Text = Me.Text & " - UPDATE LAST CODE"

                If CHK(3) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                If CheckData_Customer(L7106.Customercode, ISUD.Update) = False Then
                    isudCHK = False
                    formA = True
                    Me.Dispose()
                    MsgBoxP("No Correct Customer !")
                    Exit Sub
                End If


                txt_ShoesCode.Enabled = False
                tst_iSave.Visible = True

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH()
                Call DATA_SEARCH_VS1()
                Call DisableAllType()

                wJOB = 3
        End Select

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Call D7106_CLEAR()

        W7106 = D7106

        KEY_CHK = ""


    End Sub
    Private Sub FORM_INIT()
        txt_ShoesCode.Enabled = False
        Vs1.HorizontalScrollBarPolicy = ScrollBarPolicy.Never

        tst_iDelete.Visible = False
    End Sub
#End Region

#Region "Function"
    Private Function Data_Check() As Boolean
        Data_Check = False
        If txt_ShoesCodeC.Code = "" Then Setfocus(txt_ShoesCodeC) : MsgBoxP("ShoesCode End?") : Exit Function

        Data_Check = True

    End Function

    Private Sub DATA_MOVE()


    End Sub

    Private Sub DATA_INSERT()


    End Sub
    Private Sub DATA_UPDATE()

        Call DATA_MOVE()

        Try
            Dim i As Integer
            Dim OrderNo As String
            Dim OrderNoSeq As String

            For i = 0 To Vs2.ActiveSheet.RowCount - 1
                OrderNo = getData(Vs2, getColumIndex(Vs2, "OrderNo"), i)
                OrderNoSeq = getData(Vs2, getColumIndex(Vs2, "OrderNoSeq"), i)

                If READ_PFK1312(OrderNo, OrderNoSeq) Then
                    If PrcExe(" EXP_CLOSSING_PFK7106_MERGE_ORDERNO", cn, txt_ShoesCode.Data, txt_ShoesCodeC.Data, OrderNo, OrderNoSeq) Then

                        tst_iSave.Visible = False
                    End If
                End If
                
            Next

            Call DATA_SEARCH_VS1()
            Call DATA_SEARCH_VS2()
            Call DATA_SEARCH_VS3()
            Call DATA_SEARCH_VS4()


        Catch ex As Exception

        End Try
     



    End Sub
    Private Sub DATA_DELETE()

    End Sub
    Private Sub vS2_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs2.KeyDown
        Dim xCOL As Integer
        Dim xROW As Integer
        Dim Autokey As String

        xCOL = vS2.ActiveSheet.ActiveColumnIndex
        xROW = vS2.ActiveSheet.ActiveRowIndex

        Select Case e.KeyCode
            Case Keys.Delete

                Call Select_Message("3", WordConv("PROCESSING"), 2)

                If Msg_Result <> vbYes Then Exit Sub

                SPR_DEL(vS2, xCOL, xROW)

        End Select
    End Sub



    Private Sub KEY_COUNT()
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        If KEY_CHK = "*" Then Exit Sub

        SQL = "SELECT MAX(CAST(K7106_ShoesCode AS DECIMAL)) AS MAX_CODE FROM PFK7106 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            L7106.ShoesCode = "000001"
        Else
            L7106.ShoesCode = Format(CInt(rd!MAX_CODE + 1), "000000")
        End If

        W7106.ShoesCode = L7106.ShoesCode

        rd.Close()
        If Val(W7106.ShoesCode) > 999999 Then
            Call MsgBoxP("46", "KEY_COUNT")

            Call tst_iClose.PerformClick() : Exit Sub
        End If

        txt_ShoesCode.Data = W7106.ShoesCode
    End Sub


#End Region

#Region "DATA_SEARCH"
    Private Function DATA_SEARCH() As Boolean

        DATA_SEARCH = False


        DATA_SEARCH = True

    End Function

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False

        DS1 = PrcDS("USP_ISUD7106M_SEARCH_VS1", cn, txt_ShoesCode.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs1, DS1, "USP_ISUD7106M_SEARCH_VS1", "Vs1")
            Vs1.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "USP_ISUD7106M_SEARCH_VS1", "Vs1")
        DATA_SEARCH_VS1 = True

    End Function

    Private Function DATA_SEARCH_VS2() As Boolean
        DATA_SEARCH_VS2 = False

        DS1 = PrcDS("USP_ISUD7106M_SEARCH_VS2", cn, txt_ShoesCode.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(VS2, DS1, "USP_ISUD7106M_SEARCH_VS2", "VS2")
            VS2.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(VS2, DS1, "USP_ISUD7106M_SEARCH_VS2", "VS2")
        DATA_SEARCH_VS2 = True

    End Function

    Private Function DATA_SEARCH_VS3() As Boolean
        DATA_SEARCH_VS3 = False

        DS1 = PrcDS("USP_ISUD7106M_SEARCH_VS3", cn, txt_ShoesCodeC.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(VS3, DS1, "USP_ISUD7106M_SEARCH_VS3", "VS3")
            VS3.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(VS3, DS1, "USP_ISUD7106M_SEARCH_VS3", "VS3")
        DATA_SEARCH_VS3 = True

    End Function

    Private Function DATA_SEARCH_VS4() As Boolean
        DATA_SEARCH_VS4 = False

        DS1 = PrcDS("USP_ISUD7106M_SEARCH_VS4", cn, txt_ShoesCodeC.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(VS4, DS1, "USP_ISUD7106M_SEARCH_VS4", "VS4")
            VS4.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(VS4, DS1, "USP_ISUD7106M_SEARCH_VS4", "VS4")
        DATA_SEARCH_VS4 = True

    End Function


    Private Function DATA_SEARCH_HEAD() As Boolean
        DATA_SEARCH_HEAD = False

        DATA_SEARCH_HEAD = True

    End Function

#End Region

#Region "Event"
    Private Sub cmd_UpdateSize_Click(sender As Object, e As EventArgs)
        If HLP7106G.Link_HLP7106G(txt_ShoesCode.Data) Then

        End If

    End Sub
    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        Select Case wJOB
            Case 3
                If Data_Check() = False Then Exit Sub
                Call DATA_UPDATE()
            Case 4 : Call DATA_DELETE()
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
    Private Sub tst_iDelete_Click(sender As Object, e As EventArgs)
        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        If CHK(4) <> "1" Then
            Call MsgBoxP("4", "tst_iDelete_Click")
            Exit Sub
        End If
        Call DATA_DELETE()
        Me.Dispose()
    End Sub
    Private Sub txt_ShoesCodeC_btnTitleClick(sender As Object, e As EventArgs) Handles txt_ShoesCodeC.btnTitleClick
        If READ_PFK7106(L7106.ShoesCode) Then
            If D7106.cdSpecState = "006" Then
                If HLP7106B.Link_HLP7106A(D7106.ShoesCode, True) Then
                    txt_ShoesCodeC.Data = hlp0000SeVaTt
                    txt_ShoesCodeC.Code = hlp0000SeVaTt
                    Call DATA_SEARCH_VS3()
                    Call DATA_SEARCH_VS4()
                End If
            Else
                If HLP7106B.Link_HLP7106A(D7106.ShoesCode, False) Then
                    txt_ShoesCodeC.Data = hlp0000SeVaTt
                    txt_ShoesCodeC.Code = hlp0000SeVaTt
                    Call DATA_SEARCH_VS3()
                    Call DATA_SEARCH_VS4()
                End If
            End If

        End If

    End Sub


#End Region




End Class