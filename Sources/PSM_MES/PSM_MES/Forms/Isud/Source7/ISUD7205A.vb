Public Class ISUD7205A
#Region "Variable"
    Private wJOB As Integer

    Private W7205 As T7205_AREA
    Private L7205 As T7205_AREA

    Private W7106 As T7106_AREA
    Private L7106 As T7106_AREA

    Private WRITE_CHK As String

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7205A(job As Integer, ShoesCode As String, Optional ByVal TAG As String = "") As Boolean

        Me.Tag = TAG

        D7205.ShoesCode = ShoesCode

        txt_Shoescode.Data = ShoesCode

        If READ_PFK7106(ShoesCode) = True Then txt_Article.Data = D7106.Article : txt_Line.Data = D7106.Line

        wJOB = job : L7205 = D7205

        Link_ISUD7205A = False

        Try
            Select Case job
                Case 1
                    Call DATA_SEARCH01(D7205.ShoesCode)
                Case Else
                    If READ_PFK7106(D7205.ShoesCode) = False Then
                        Call MsgBoxP("3", "LINK_ISUD")

                        Me.Dispose()
                        Exit Function
                    End If
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD7205A = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("SizeRange"))
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

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Frame1.Enabled = True
                cmd_DEL.Visible = False
                cmd_OK.Visible = True

                Call DATA_SEARCH02(D7205.ShoesCode)

                Vs1.ActiveSheet.Rows(0).Locked = True

            Case 2
                Me.Text = Me.Text & " - SEARCH"
                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If


                cmd_DEL.Visible = False
                cmd_OK.Visible = False

                Call DATA_SEARCH02(D7205.ShoesCode)

                SPR_LOCK(Vs1)
                Vs1.Enabled = False

            Case 3
                Me.Text = Me.Text & " - UPDATE"
                If CHK(3) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Frame1.Enabled = True

                cmd_DEL.Visible = False
                cmd_OK.Visible = True

                Call DATA_SEARCH02(D7205.ShoesCode)

                Vs1.ActiveSheet.Rows(0).Locked = True

            Case 4
                Me.Text = Me.Text & " - DELETE"

                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Frame1.Enabled = False

                cmd_DEL.Visible = True
                cmd_OK.Visible = False

                Call DATA_SEARCH02(D7205.ShoesCode)

        End Select

        formA = True
    End Sub

    Private Sub DATA_INIT()
        Try

            W7205 = D7205

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Sub FORM_INIT()

    End Sub
#End Region

#Region "Data_Search"

    Private Function DATA_SEARCH01(ShoesCode As String) As Boolean
        DATA_SEARCH01 = False

        Vs1.Enabled = False

        DS1 = PrcDS("USP_PFP71064_SEARCH_vs_Price", cn, ShoesCode)

        If GetDsRc(DS1) = 0 Then
            DS2 = PrcDS("USP_PFP71064_SEARCH_vs_Price_INSERT", cn, ShoesCode, ListCode("SizeGroup"))
            SPR_PRO_NEW(Vs1, DS2, "USP_PFP71064_SEARCH_vs_Price", "Vs1")
            SPR_INSERT(Vs1)
            Vs1.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "USP_PFP71064_SEARCH_vs_Price", "Vs1")
        DATA_SEARCH01 = True

        Vs1.Enabled = True
    End Function

    Private Function DATA_SEARCH02(ShoesCode As String) As Boolean
        DATA_SEARCH02 = False

        Vs1.Enabled = False

        DS1 = PrcDS("USP_PFP71064_SEARCH_vs_Price", cn, ShoesCode)

        If GetDsRc(DS1) = 0 Then
            DS2 = PrcDS("USP_PFP71064_SEARCH_vs_Price", cn, ShoesCode, ListCode("SizeGroup"))
            SPR_PRO_NEW(Vs1, DS2, "USP_PFP71064_SEARCH_vs_Price", "Vs1")
            SPR_INSERT(Vs1)
            Vs1.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "USP_PFP71064_SEARCH_vs_Price", "Vs1")
        DATA_SEARCH02 = True

        Vs1.Enabled = True
    End Function

#End Region

#Region "Function"


    Private Sub DATA_MOVE()


        If READ_PFK7205(getData(Vs1, getColumIndex(Vs1, "KEY_ShoesCode"), Vs1.ActiveSheet.ActiveRowIndex),
                        getData(Vs1, getColumIndex(Vs1, "KEY_seSizeGroup"), Vs1.ActiveSheet.ActiveRowIndex),
                        getData(Vs1, getColumIndex(Vs1, "KEY_cdSizeGroup"), Vs1.ActiveSheet.ActiveRowIndex)) Then

            D7205.Size01 = getData(Vs1, getColumIndex(Vs1, "Size01"), Vs1.ActiveSheet.ActiveRowIndex)
            D7205.Size02 = getData(Vs1, getColumIndex(Vs1, "Size02"), Vs1.ActiveSheet.ActiveRowIndex)
            D7205.Size03 = getData(Vs1, getColumIndex(Vs1, "Size03"), Vs1.ActiveSheet.ActiveRowIndex)
            D7205.Size04 = getData(Vs1, getColumIndex(Vs1, "Size04"), Vs1.ActiveSheet.ActiveRowIndex)
            D7205.Size05 = getData(Vs1, getColumIndex(Vs1, "Size05"), Vs1.ActiveSheet.ActiveRowIndex)
            D7205.Size06 = getData(Vs1, getColumIndex(Vs1, "Size06"), Vs1.ActiveSheet.ActiveRowIndex)
            D7205.Size07 = getData(Vs1, getColumIndex(Vs1, "Size07"), Vs1.ActiveSheet.ActiveRowIndex)
            D7205.Size08 = getData(Vs1, getColumIndex(Vs1, "Size08"), Vs1.ActiveSheet.ActiveRowIndex)
            D7205.Size09 = getData(Vs1, getColumIndex(Vs1, "Size09"), Vs1.ActiveSheet.ActiveRowIndex)
            D7205.Size10 = getData(Vs1, getColumIndex(Vs1, "Size10"), Vs1.ActiveSheet.ActiveRowIndex)

            D7205.Size11 = getData(Vs1, getColumIndex(Vs1, "Size11"), Vs1.ActiveSheet.ActiveRowIndex)
            D7205.Size12 = getData(Vs1, getColumIndex(Vs1, "Size12"), Vs1.ActiveSheet.ActiveRowIndex)
            D7205.Size13 = getData(Vs1, getColumIndex(Vs1, "Size13"), Vs1.ActiveSheet.ActiveRowIndex)
            D7205.Size14 = getData(Vs1, getColumIndex(Vs1, "Size14"), Vs1.ActiveSheet.ActiveRowIndex)
            D7205.Size15 = getData(Vs1, getColumIndex(Vs1, "Size15"), Vs1.ActiveSheet.ActiveRowIndex)
            D7205.Size16 = getData(Vs1, getColumIndex(Vs1, "Size16"), Vs1.ActiveSheet.ActiveRowIndex)
            D7205.Size17 = getData(Vs1, getColumIndex(Vs1, "Size17"), Vs1.ActiveSheet.ActiveRowIndex)
            D7205.Size18 = getData(Vs1, getColumIndex(Vs1, "Size18"), Vs1.ActiveSheet.ActiveRowIndex)
            D7205.Size19 = getData(Vs1, getColumIndex(Vs1, "Size19"), Vs1.ActiveSheet.ActiveRowIndex)
            D7205.Size20 = getData(Vs1, getColumIndex(Vs1, "Size20"), Vs1.ActiveSheet.ActiveRowIndex)

            D7205.Size21 = getData(Vs1, getColumIndex(Vs1, "Size21"), Vs1.ActiveSheet.ActiveRowIndex)
            D7205.Size22 = getData(Vs1, getColumIndex(Vs1, "Size22"), Vs1.ActiveSheet.ActiveRowIndex)
            D7205.Size23 = getData(Vs1, getColumIndex(Vs1, "Size23"), Vs1.ActiveSheet.ActiveRowIndex)
            D7205.Size24 = getData(Vs1, getColumIndex(Vs1, "Size24"), Vs1.ActiveSheet.ActiveRowIndex)
            D7205.Size25 = getData(Vs1, getColumIndex(Vs1, "Size25"), Vs1.ActiveSheet.ActiveRowIndex)
            D7205.Size26 = getData(Vs1, getColumIndex(Vs1, "Size26"), Vs1.ActiveSheet.ActiveRowIndex)
            D7205.Size27 = getData(Vs1, getColumIndex(Vs1, "Size27"), Vs1.ActiveSheet.ActiveRowIndex)
            D7205.Size28 = getData(Vs1, getColumIndex(Vs1, "Size28"), Vs1.ActiveSheet.ActiveRowIndex)
            D7205.Size29 = getData(Vs1, getColumIndex(Vs1, "Size29"), Vs1.ActiveSheet.ActiveRowIndex)
            D7205.Size30 = getData(Vs1, getColumIndex(Vs1, "Size30"), Vs1.ActiveSheet.ActiveRowIndex)

        End If


    End Sub


    Private Sub DATA_INSERT()
        Try

            Call DATA_MOVE()

            W7205 = D7205

            If WRITE_PFK7205(W7205) = True Then

                isudCHK = True : WRITE_CHK = "*"
                Exit Sub
            End If
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INSERT")
        End Try

    End Sub

    Private Sub DATA_UPDATE()
        Try

            Call DATA_MOVE()

            W7205 = D7205

            If REWRITE_PFK7205(W7205) = True Then

                isudCHK = True
                Me.Dispose()
            End If

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

    Private Sub DATA_DELETE()
        Try
            Call DATA_MOVE()
            If DELETE_PFK7205(W7205) = True Then

                isudCHK = True
                Me.Dispose()
            End If

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

#End Region

#Region "Event"

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Select Case wJOB
            Case 1
                Try
                    Dim i As Integer

                    For i = 0 To Vs1.ActiveSheet.RowCount - 1
                        If getDataM(Vs1, getColumIndex(Vs1, "DCHK"), i) = "1" Then
                            If READ_PFK7205(getData(Vs1, getColumIndex(Vs1, "KEY_ShoesCode"), i),
                                          getData(Vs1, getColumIndex(Vs1, "KEY_seSizeGroup"), Vs1.ActiveSheet.ActiveRowIndex),
                                          getData(Vs1, getColumIndex(Vs1, "KEY_cdSizeGroup"), Vs1.ActiveSheet.ActiveRowIndex)) Then


                                D7205.DateUpdate = Pub.DAT
                                D7205.InchargeUpdate = Pub.SAW

                                D7205.CheckCondition = "1"
                                If getData(Vs1, getColumIndex(Vs1, "CheckCondition"), Vs1.ActiveSheet.ActiveRowIndex).ToString.Contains("UP") Then D7205.CheckCondition = "2"
                                If getData(Vs1, getColumIndex(Vs1, "CheckCondition"), Vs1.ActiveSheet.ActiveRowIndex).ToString.Contains("DOWN") Then D7205.CheckCondition = "3"


                                D7205.Size01 = getData(Vs1, getColumIndex(Vs1, "Size01"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size02 = getData(Vs1, getColumIndex(Vs1, "Size02"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size03 = getData(Vs1, getColumIndex(Vs1, "Size03"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size04 = getData(Vs1, getColumIndex(Vs1, "Size04"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size05 = getData(Vs1, getColumIndex(Vs1, "Size05"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size06 = getData(Vs1, getColumIndex(Vs1, "Size06"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size07 = getData(Vs1, getColumIndex(Vs1, "Size07"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size08 = getData(Vs1, getColumIndex(Vs1, "Size08"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size09 = getData(Vs1, getColumIndex(Vs1, "Size09"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size10 = getData(Vs1, getColumIndex(Vs1, "Size10"), Vs1.ActiveSheet.ActiveRowIndex)

                                D7205.Size11 = getData(Vs1, getColumIndex(Vs1, "Size11"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size12 = getData(Vs1, getColumIndex(Vs1, "Size12"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size13 = getData(Vs1, getColumIndex(Vs1, "Size13"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size14 = getData(Vs1, getColumIndex(Vs1, "Size14"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size15 = getData(Vs1, getColumIndex(Vs1, "Size15"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size16 = getData(Vs1, getColumIndex(Vs1, "Size16"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size17 = getData(Vs1, getColumIndex(Vs1, "Size17"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size18 = getData(Vs1, getColumIndex(Vs1, "Size18"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size19 = getData(Vs1, getColumIndex(Vs1, "Size19"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size20 = getData(Vs1, getColumIndex(Vs1, "Size20"), Vs1.ActiveSheet.ActiveRowIndex)

                                D7205.Size21 = getData(Vs1, getColumIndex(Vs1, "Size21"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size22 = getData(Vs1, getColumIndex(Vs1, "Size22"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size23 = getData(Vs1, getColumIndex(Vs1, "Size23"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size24 = getData(Vs1, getColumIndex(Vs1, "Size24"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size25 = getData(Vs1, getColumIndex(Vs1, "Size25"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size26 = getData(Vs1, getColumIndex(Vs1, "Size26"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size27 = getData(Vs1, getColumIndex(Vs1, "Size27"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size28 = getData(Vs1, getColumIndex(Vs1, "Size28"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size29 = getData(Vs1, getColumIndex(Vs1, "Size29"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size30 = getData(Vs1, getColumIndex(Vs1, "Size30"), Vs1.ActiveSheet.ActiveRowIndex)

                                Call REWRITE_PFK7205(D7205)

                            Else
                                D7205.ShoesCode = getData(Vs1, getColumIndex(Vs1, "KEY_ShoesCode"), i)
                                D7205.seSizeGroup = ListCode("SizeGroup")
                                D7205.cdSizeGroup = getData(Vs1, getColumIndex(Vs1, "cdSizeGroup"), Vs1.ActiveSheet.ActiveRowIndex)

                                D7205.DateInsert = Pub.DAT
                                D7205.InchargeInsert = Pub.SAW

                                D7205.Size01 = getData(Vs1, getColumIndex(Vs1, "Size01"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size02 = getData(Vs1, getColumIndex(Vs1, "Size02"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size03 = getData(Vs1, getColumIndex(Vs1, "Size03"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size04 = getData(Vs1, getColumIndex(Vs1, "Size04"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size05 = getData(Vs1, getColumIndex(Vs1, "Size05"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size06 = getData(Vs1, getColumIndex(Vs1, "Size06"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size07 = getData(Vs1, getColumIndex(Vs1, "Size07"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size08 = getData(Vs1, getColumIndex(Vs1, "Size08"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size09 = getData(Vs1, getColumIndex(Vs1, "Size09"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size10 = getData(Vs1, getColumIndex(Vs1, "Size10"), Vs1.ActiveSheet.ActiveRowIndex)

                                D7205.Size11 = getData(Vs1, getColumIndex(Vs1, "Size11"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size12 = getData(Vs1, getColumIndex(Vs1, "Size12"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size13 = getData(Vs1, getColumIndex(Vs1, "Size13"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size14 = getData(Vs1, getColumIndex(Vs1, "Size14"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size15 = getData(Vs1, getColumIndex(Vs1, "Size15"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size16 = getData(Vs1, getColumIndex(Vs1, "Size16"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size17 = getData(Vs1, getColumIndex(Vs1, "Size17"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size18 = getData(Vs1, getColumIndex(Vs1, "Size18"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size19 = getData(Vs1, getColumIndex(Vs1, "Size19"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size20 = getData(Vs1, getColumIndex(Vs1, "Size20"), Vs1.ActiveSheet.ActiveRowIndex)

                                D7205.Size21 = getData(Vs1, getColumIndex(Vs1, "Size21"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size22 = getData(Vs1, getColumIndex(Vs1, "Size22"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size23 = getData(Vs1, getColumIndex(Vs1, "Size23"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size24 = getData(Vs1, getColumIndex(Vs1, "Size24"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size25 = getData(Vs1, getColumIndex(Vs1, "Size25"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size26 = getData(Vs1, getColumIndex(Vs1, "Size26"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size27 = getData(Vs1, getColumIndex(Vs1, "Size27"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size28 = getData(Vs1, getColumIndex(Vs1, "Size28"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size29 = getData(Vs1, getColumIndex(Vs1, "Size29"), Vs1.ActiveSheet.ActiveRowIndex)
                                D7205.Size30 = getData(Vs1, getColumIndex(Vs1, "Size30"), Vs1.ActiveSheet.ActiveRowIndex)

                                Call WRITE_PFK7205(D7205)
                            End If
                        End If
                    Next
                Catch ex As Exception

                End Try
                Me.Dispose()
            Case 2
                Me.Dispose()
            Case 3
                Me.Dispose()
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

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub

    Private Sub Vs1_Change(sender As Object, e As ChangeEventArgs) Handles Vs1.Change
        Dim i As Integer = 0
        Dim chk As Boolean = False

        If chk = False Then

            If READ_PFK7205(getData(Vs1, getColumIndex(Vs1, "KEY_ShoesCode"), Vs1.ActiveSheet.ActiveRowIndex),
                            getData(Vs1, getColumIndex(Vs1, "KEY_seSizeGroup"), Vs1.ActiveSheet.ActiveRowIndex),
                            getData(Vs1, getColumIndex(Vs1, "KEY_cdSizeGroup"), Vs1.ActiveSheet.ActiveRowIndex)) Then

                D7205.CheckCondition = "1"
                If getData(Vs1, getColumIndex(Vs1, "CheckCondition"), Vs1.ActiveSheet.ActiveRowIndex).ToString.Contains("UP") Then D7205.CheckCondition = "2"
                If getData(Vs1, getColumIndex(Vs1, "CheckCondition"), Vs1.ActiveSheet.ActiveRowIndex).ToString.Contains("DOWN") Then D7205.CheckCondition = "3"

                D7205.DateUpdate = Pub.DAT
                D7205.InchargeUpdate = Pub.SAW

                D7205.Size01 = getData(Vs1, getColumIndex(Vs1, "Size01"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size02 = getData(Vs1, getColumIndex(Vs1, "Size02"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size03 = getData(Vs1, getColumIndex(Vs1, "Size03"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size04 = getData(Vs1, getColumIndex(Vs1, "Size04"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size05 = getData(Vs1, getColumIndex(Vs1, "Size05"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size06 = getData(Vs1, getColumIndex(Vs1, "Size06"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size07 = getData(Vs1, getColumIndex(Vs1, "Size07"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size08 = getData(Vs1, getColumIndex(Vs1, "Size08"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size09 = getData(Vs1, getColumIndex(Vs1, "Size09"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size10 = getData(Vs1, getColumIndex(Vs1, "Size10"), Vs1.ActiveSheet.ActiveRowIndex)

                D7205.Size11 = getData(Vs1, getColumIndex(Vs1, "Size11"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size12 = getData(Vs1, getColumIndex(Vs1, "Size12"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size13 = getData(Vs1, getColumIndex(Vs1, "Size13"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size14 = getData(Vs1, getColumIndex(Vs1, "Size14"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size15 = getData(Vs1, getColumIndex(Vs1, "Size15"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size16 = getData(Vs1, getColumIndex(Vs1, "Size16"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size17 = getData(Vs1, getColumIndex(Vs1, "Size17"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size18 = getData(Vs1, getColumIndex(Vs1, "Size18"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size19 = getData(Vs1, getColumIndex(Vs1, "Size19"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size20 = getData(Vs1, getColumIndex(Vs1, "Size20"), Vs1.ActiveSheet.ActiveRowIndex)

                D7205.Size21 = getData(Vs1, getColumIndex(Vs1, "Size21"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size22 = getData(Vs1, getColumIndex(Vs1, "Size22"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size23 = getData(Vs1, getColumIndex(Vs1, "Size23"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size24 = getData(Vs1, getColumIndex(Vs1, "Size24"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size25 = getData(Vs1, getColumIndex(Vs1, "Size25"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size26 = getData(Vs1, getColumIndex(Vs1, "Size26"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size27 = getData(Vs1, getColumIndex(Vs1, "Size27"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size28 = getData(Vs1, getColumIndex(Vs1, "Size28"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size29 = getData(Vs1, getColumIndex(Vs1, "Size29"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size30 = getData(Vs1, getColumIndex(Vs1, "Size30"), Vs1.ActiveSheet.ActiveRowIndex)

                Call REWRITE_PFK7205(D7205)

            Else
                D7205.ShoesCode = getData(Vs1, getColumIndex(Vs1, "KEY_ShoesCode"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.seSizeGroup = ListCode("SizeGroup")
                D7205.cdSizeGroup = getData(Vs1, getColumIndex(Vs1, "cdSizeGroup"), Vs1.ActiveSheet.ActiveRowIndex)

                D7205.DateInsert = Pub.DAT
                D7205.InchargeInsert = Pub.SAW

                D7205.CheckCondition = "1"
                If getData(Vs1, getColumIndex(Vs1, "CheckCondition"), Vs1.ActiveSheet.ActiveRowIndex).ToString.Contains("UP") Then D7205.CheckCondition = "2"
                If getData(Vs1, getColumIndex(Vs1, "CheckCondition"), Vs1.ActiveSheet.ActiveRowIndex).ToString.Contains("DOWN") Then D7205.CheckCondition = "3"

                D7205.Size01 = getData(Vs1, getColumIndex(Vs1, "Size01"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size02 = getData(Vs1, getColumIndex(Vs1, "Size02"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size03 = getData(Vs1, getColumIndex(Vs1, "Size03"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size04 = getData(Vs1, getColumIndex(Vs1, "Size04"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size05 = getData(Vs1, getColumIndex(Vs1, "Size05"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size06 = getData(Vs1, getColumIndex(Vs1, "Size06"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size07 = getData(Vs1, getColumIndex(Vs1, "Size07"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size08 = getData(Vs1, getColumIndex(Vs1, "Size08"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size09 = getData(Vs1, getColumIndex(Vs1, "Size09"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size10 = getData(Vs1, getColumIndex(Vs1, "Size10"), Vs1.ActiveSheet.ActiveRowIndex)

                D7205.Size11 = getData(Vs1, getColumIndex(Vs1, "Size11"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size12 = getData(Vs1, getColumIndex(Vs1, "Size12"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size13 = getData(Vs1, getColumIndex(Vs1, "Size13"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size14 = getData(Vs1, getColumIndex(Vs1, "Size14"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size15 = getData(Vs1, getColumIndex(Vs1, "Size15"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size16 = getData(Vs1, getColumIndex(Vs1, "Size16"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size17 = getData(Vs1, getColumIndex(Vs1, "Size17"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size18 = getData(Vs1, getColumIndex(Vs1, "Size18"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size19 = getData(Vs1, getColumIndex(Vs1, "Size19"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size20 = getData(Vs1, getColumIndex(Vs1, "Size20"), Vs1.ActiveSheet.ActiveRowIndex)

                D7205.Size21 = getData(Vs1, getColumIndex(Vs1, "Size21"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size22 = getData(Vs1, getColumIndex(Vs1, "Size22"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size23 = getData(Vs1, getColumIndex(Vs1, "Size23"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size24 = getData(Vs1, getColumIndex(Vs1, "Size24"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size25 = getData(Vs1, getColumIndex(Vs1, "Size25"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size26 = getData(Vs1, getColumIndex(Vs1, "Size26"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size27 = getData(Vs1, getColumIndex(Vs1, "Size27"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size28 = getData(Vs1, getColumIndex(Vs1, "Size28"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size29 = getData(Vs1, getColumIndex(Vs1, "Size29"), Vs1.ActiveSheet.ActiveRowIndex)
                D7205.Size30 = getData(Vs1, getColumIndex(Vs1, "Size30"), Vs1.ActiveSheet.ActiveRowIndex)

                Call WRITE_PFK7205(D7205)
            End If
        Else
            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If getDataM(Vs1, getColumIndex(Vs1, "DCHK"), i) = "1" Then
                    If READ_PFK7205(getData(Vs1, getColumIndex(Vs1, "KEY_ShoesCode"), i),
                                  getData(Vs1, getColumIndex(Vs1, "KEY_seSizeGroup"), Vs1.ActiveSheet.ActiveRowIndex),
                                  getData(Vs1, getColumIndex(Vs1, "KEY_cdSizeGroup"), Vs1.ActiveSheet.ActiveRowIndex)) Then


                        D7205.CheckCondition = "1"
                        If getData(Vs1, getColumIndex(Vs1, "CheckCondition"), Vs1.ActiveSheet.ActiveRowIndex).ToString.Contains("UP") Then D7205.CheckCondition = "2"
                        If getData(Vs1, getColumIndex(Vs1, "CheckCondition"), Vs1.ActiveSheet.ActiveRowIndex).ToString.Contains("DOWN") Then D7205.CheckCondition = "3"

                        D7205.DateUpdate = Pub.DAT
                        D7205.InchargeUpdate = Pub.SAW

                        D7205.Size01 = getData(Vs1, getColumIndex(Vs1, "Size01"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size02 = getData(Vs1, getColumIndex(Vs1, "Size02"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size03 = getData(Vs1, getColumIndex(Vs1, "Size03"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size04 = getData(Vs1, getColumIndex(Vs1, "Size04"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size05 = getData(Vs1, getColumIndex(Vs1, "Size05"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size06 = getData(Vs1, getColumIndex(Vs1, "Size06"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size07 = getData(Vs1, getColumIndex(Vs1, "Size07"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size08 = getData(Vs1, getColumIndex(Vs1, "Size08"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size09 = getData(Vs1, getColumIndex(Vs1, "Size09"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size10 = getData(Vs1, getColumIndex(Vs1, "Size10"), Vs1.ActiveSheet.ActiveRowIndex)

                        D7205.Size11 = getData(Vs1, getColumIndex(Vs1, "Size11"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size12 = getData(Vs1, getColumIndex(Vs1, "Size12"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size13 = getData(Vs1, getColumIndex(Vs1, "Size13"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size14 = getData(Vs1, getColumIndex(Vs1, "Size14"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size15 = getData(Vs1, getColumIndex(Vs1, "Size15"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size16 = getData(Vs1, getColumIndex(Vs1, "Size16"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size17 = getData(Vs1, getColumIndex(Vs1, "Size17"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size18 = getData(Vs1, getColumIndex(Vs1, "Size18"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size19 = getData(Vs1, getColumIndex(Vs1, "Size19"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size20 = getData(Vs1, getColumIndex(Vs1, "Size20"), Vs1.ActiveSheet.ActiveRowIndex)

                        D7205.Size21 = getData(Vs1, getColumIndex(Vs1, "Size21"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size22 = getData(Vs1, getColumIndex(Vs1, "Size22"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size23 = getData(Vs1, getColumIndex(Vs1, "Size23"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size24 = getData(Vs1, getColumIndex(Vs1, "Size24"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size25 = getData(Vs1, getColumIndex(Vs1, "Size25"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size26 = getData(Vs1, getColumIndex(Vs1, "Size26"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size27 = getData(Vs1, getColumIndex(Vs1, "Size27"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size28 = getData(Vs1, getColumIndex(Vs1, "Size28"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size29 = getData(Vs1, getColumIndex(Vs1, "Size29"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size30 = getData(Vs1, getColumIndex(Vs1, "Size30"), Vs1.ActiveSheet.ActiveRowIndex)

                        Call REWRITE_PFK7205(D7205)

                    Else
                        D7205.ShoesCode = getData(Vs1, getColumIndex(Vs1, "KEY_ShoesCode"), i)
                        D7205.seSizeGroup = ListCode("SizeGroup")
                        D7205.cdSizeGroup = getData(Vs1, getColumIndex(Vs1, "cdSizeGroup"), Vs1.ActiveSheet.ActiveRowIndex)

                        D7205.CheckCondition = "1"
                        If getData(Vs1, getColumIndex(Vs1, "CheckCondition"), Vs1.ActiveSheet.ActiveRowIndex).ToString.Contains("UP") Then D7205.CheckCondition = "2"
                        If getData(Vs1, getColumIndex(Vs1, "CheckCondition"), Vs1.ActiveSheet.ActiveRowIndex).ToString.Contains("DOWN") Then D7205.CheckCondition = "3"

                        D7205.DateInsert = Pub.DAT
                        D7205.InchargeInsert = Pub.SAW

                        D7205.Size01 = getData(Vs1, getColumIndex(Vs1, "Size01"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size02 = getData(Vs1, getColumIndex(Vs1, "Size02"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size03 = getData(Vs1, getColumIndex(Vs1, "Size03"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size04 = getData(Vs1, getColumIndex(Vs1, "Size04"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size05 = getData(Vs1, getColumIndex(Vs1, "Size05"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size06 = getData(Vs1, getColumIndex(Vs1, "Size06"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size07 = getData(Vs1, getColumIndex(Vs1, "Size07"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size08 = getData(Vs1, getColumIndex(Vs1, "Size08"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size09 = getData(Vs1, getColumIndex(Vs1, "Size09"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size10 = getData(Vs1, getColumIndex(Vs1, "Size10"), Vs1.ActiveSheet.ActiveRowIndex)

                        D7205.Size11 = getData(Vs1, getColumIndex(Vs1, "Size11"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size12 = getData(Vs1, getColumIndex(Vs1, "Size12"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size13 = getData(Vs1, getColumIndex(Vs1, "Size13"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size14 = getData(Vs1, getColumIndex(Vs1, "Size14"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size15 = getData(Vs1, getColumIndex(Vs1, "Size15"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size16 = getData(Vs1, getColumIndex(Vs1, "Size16"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size17 = getData(Vs1, getColumIndex(Vs1, "Size17"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size18 = getData(Vs1, getColumIndex(Vs1, "Size18"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size19 = getData(Vs1, getColumIndex(Vs1, "Size19"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size20 = getData(Vs1, getColumIndex(Vs1, "Size20"), Vs1.ActiveSheet.ActiveRowIndex)

                        D7205.Size21 = getData(Vs1, getColumIndex(Vs1, "Size21"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size22 = getData(Vs1, getColumIndex(Vs1, "Size22"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size23 = getData(Vs1, getColumIndex(Vs1, "Size23"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size24 = getData(Vs1, getColumIndex(Vs1, "Size24"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size25 = getData(Vs1, getColumIndex(Vs1, "Size25"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size26 = getData(Vs1, getColumIndex(Vs1, "Size26"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size27 = getData(Vs1, getColumIndex(Vs1, "Size27"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size28 = getData(Vs1, getColumIndex(Vs1, "Size28"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size29 = getData(Vs1, getColumIndex(Vs1, "Size29"), Vs1.ActiveSheet.ActiveRowIndex)
                        D7205.Size30 = getData(Vs1, getColumIndex(Vs1, "Size30"), Vs1.ActiveSheet.ActiveRowIndex)

                        Call WRITE_PFK7205(D7205)
                    End If
                End If
            Next
        End If

    End Sub


    Private Sub Vs1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown
        Dim StrMsg As String

        If e.KeyCode = Keys.Enter Then

            Dim i As Integer = 0
            Dim chk As Boolean = False

            If chk = False Then

                If READ_PFK7205(getData(Vs1, getColumIndex(Vs1, "KEY_ShoesCode"), Vs1.ActiveSheet.ActiveRowIndex),
                                getData(Vs1, getColumIndex(Vs1, "KEY_seSizeGroup"), Vs1.ActiveSheet.ActiveRowIndex),
                                getData(Vs1, getColumIndex(Vs1, "KEY_cdSizeGroup"), Vs1.ActiveSheet.ActiveRowIndex)) Then

                    D7205.DateUpdate = Pub.DAT
                    D7205.InchargeUpdate = Pub.SAW

                    D7205.CheckCondition = "1"
                    If getData(Vs1, getColumIndex(Vs1, "CheckCondition"), Vs1.ActiveSheet.ActiveRowIndex).ToString.Contains("UP") Then D7205.CheckCondition = "2"
                    If getData(Vs1, getColumIndex(Vs1, "CheckCondition"), Vs1.ActiveSheet.ActiveRowIndex).ToString.Contains("DOWN") Then D7205.CheckCondition = "3"

                    D7205.Size01 = getData(Vs1, getColumIndex(Vs1, "Size01"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size02 = getData(Vs1, getColumIndex(Vs1, "Size02"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size03 = getData(Vs1, getColumIndex(Vs1, "Size03"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size04 = getData(Vs1, getColumIndex(Vs1, "Size04"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size05 = getData(Vs1, getColumIndex(Vs1, "Size05"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size06 = getData(Vs1, getColumIndex(Vs1, "Size06"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size07 = getData(Vs1, getColumIndex(Vs1, "Size07"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size08 = getData(Vs1, getColumIndex(Vs1, "Size08"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size09 = getData(Vs1, getColumIndex(Vs1, "Size09"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size10 = getData(Vs1, getColumIndex(Vs1, "Size10"), Vs1.ActiveSheet.ActiveRowIndex)

                    D7205.Size11 = getData(Vs1, getColumIndex(Vs1, "Size11"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size12 = getData(Vs1, getColumIndex(Vs1, "Size12"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size13 = getData(Vs1, getColumIndex(Vs1, "Size13"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size14 = getData(Vs1, getColumIndex(Vs1, "Size14"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size15 = getData(Vs1, getColumIndex(Vs1, "Size15"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size16 = getData(Vs1, getColumIndex(Vs1, "Size16"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size17 = getData(Vs1, getColumIndex(Vs1, "Size17"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size18 = getData(Vs1, getColumIndex(Vs1, "Size18"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size19 = getData(Vs1, getColumIndex(Vs1, "Size19"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size20 = getData(Vs1, getColumIndex(Vs1, "Size20"), Vs1.ActiveSheet.ActiveRowIndex)

                    D7205.Size21 = getData(Vs1, getColumIndex(Vs1, "Size21"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size22 = getData(Vs1, getColumIndex(Vs1, "Size22"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size23 = getData(Vs1, getColumIndex(Vs1, "Size23"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size24 = getData(Vs1, getColumIndex(Vs1, "Size24"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size25 = getData(Vs1, getColumIndex(Vs1, "Size25"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size26 = getData(Vs1, getColumIndex(Vs1, "Size26"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size27 = getData(Vs1, getColumIndex(Vs1, "Size27"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size28 = getData(Vs1, getColumIndex(Vs1, "Size28"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size29 = getData(Vs1, getColumIndex(Vs1, "Size29"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size30 = getData(Vs1, getColumIndex(Vs1, "Size30"), Vs1.ActiveSheet.ActiveRowIndex)

                    Call REWRITE_PFK7205(D7205)

                Else
                    D7205.DateInsert = Pub.DAT
                    D7205.InchargeInsert = Pub.SAW

                    D7205.ShoesCode = getData(Vs1, getColumIndex(Vs1, "KEY_ShoesCode"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.seSizeGroup = ListCode("SizeGroup")
                    D7205.cdSizeGroup = getData(Vs1, getColumIndex(Vs1, "cdSizeGroup"), Vs1.ActiveSheet.ActiveRowIndex)

                    D7205.CheckCondition = "1"
                    If getData(Vs1, getColumIndex(Vs1, "CheckCondition"), Vs1.ActiveSheet.ActiveRowIndex).ToString.Contains("UP") Then D7205.CheckCondition = "2"
                    If getData(Vs1, getColumIndex(Vs1, "CheckCondition"), Vs1.ActiveSheet.ActiveRowIndex).ToString.Contains("DOWN") Then D7205.CheckCondition = "3"

                    D7205.Size01 = getData(Vs1, getColumIndex(Vs1, "Size01"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size02 = getData(Vs1, getColumIndex(Vs1, "Size02"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size03 = getData(Vs1, getColumIndex(Vs1, "Size03"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size04 = getData(Vs1, getColumIndex(Vs1, "Size04"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size05 = getData(Vs1, getColumIndex(Vs1, "Size05"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size06 = getData(Vs1, getColumIndex(Vs1, "Size06"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size07 = getData(Vs1, getColumIndex(Vs1, "Size07"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size08 = getData(Vs1, getColumIndex(Vs1, "Size08"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size09 = getData(Vs1, getColumIndex(Vs1, "Size09"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size10 = getData(Vs1, getColumIndex(Vs1, "Size10"), Vs1.ActiveSheet.ActiveRowIndex)

                    D7205.Size11 = getData(Vs1, getColumIndex(Vs1, "Size11"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size12 = getData(Vs1, getColumIndex(Vs1, "Size12"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size13 = getData(Vs1, getColumIndex(Vs1, "Size13"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size14 = getData(Vs1, getColumIndex(Vs1, "Size14"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size15 = getData(Vs1, getColumIndex(Vs1, "Size15"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size16 = getData(Vs1, getColumIndex(Vs1, "Size16"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size17 = getData(Vs1, getColumIndex(Vs1, "Size17"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size18 = getData(Vs1, getColumIndex(Vs1, "Size18"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size19 = getData(Vs1, getColumIndex(Vs1, "Size19"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size20 = getData(Vs1, getColumIndex(Vs1, "Size20"), Vs1.ActiveSheet.ActiveRowIndex)

                    D7205.Size21 = getData(Vs1, getColumIndex(Vs1, "Size21"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size22 = getData(Vs1, getColumIndex(Vs1, "Size22"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size23 = getData(Vs1, getColumIndex(Vs1, "Size23"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size24 = getData(Vs1, getColumIndex(Vs1, "Size24"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size25 = getData(Vs1, getColumIndex(Vs1, "Size25"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size26 = getData(Vs1, getColumIndex(Vs1, "Size26"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size27 = getData(Vs1, getColumIndex(Vs1, "Size27"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size28 = getData(Vs1, getColumIndex(Vs1, "Size28"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size29 = getData(Vs1, getColumIndex(Vs1, "Size29"), Vs1.ActiveSheet.ActiveRowIndex)
                    D7205.Size30 = getData(Vs1, getColumIndex(Vs1, "Size30"), Vs1.ActiveSheet.ActiveRowIndex)

                    Call WRITE_PFK7205(D7205)
                End If
            End If
        End If

    End Sub

    Private Sub Vs1_ClipboardPasted(sender As Object, e As ClipboardPastedEventArgs) Handles Vs1.ClipboardPasted
        Try
            Dim i As Integer

            For i = e.CellRange.Row To e.CellRange.Row + e.CellRange.RowCount - 1
                VsChange(i)
            Next
        Catch ex As Exception
            Call MsgBox("Vs2_ClipboardPasted")
        End Try
    End Sub

    Private Sub VsChange(xRow As Integer)
        Dim i As Integer = 0
        Dim chk As Boolean = False

        If chk = False Then

            If READ_PFK7205(txt_Shoescode.Data,
                            getData(Vs1, getColumIndex(Vs1, "KEY_seSizeGroup"), xRow),
                            getData(Vs1, getColumIndex(Vs1, "KEY_cdSizeGroup"), xRow)) Then

                D7205.DateUpdate = Pub.DAT
                D7205.InchargeUpdate = Pub.SAW

                D7205.CheckCondition = "1"
                If getData(Vs1, getColumIndex(Vs1, "CheckCondition"), Vs1.ActiveSheet.ActiveRowIndex).ToString.Contains("UP") Then D7205.CheckCondition = "2"
                If getData(Vs1, getColumIndex(Vs1, "CheckCondition"), Vs1.ActiveSheet.ActiveRowIndex).ToString.Contains("DOWN") Then D7205.CheckCondition = "3"

                D7205.Size01 = getData(Vs1, getColumIndex(Vs1, "Size01"), xRow)
                D7205.Size02 = getData(Vs1, getColumIndex(Vs1, "Size02"), xRow)
                D7205.Size03 = getData(Vs1, getColumIndex(Vs1, "Size03"), xRow)
                D7205.Size04 = getData(Vs1, getColumIndex(Vs1, "Size04"), xRow)
                D7205.Size05 = getData(Vs1, getColumIndex(Vs1, "Size05"), xRow)
                D7205.Size06 = getData(Vs1, getColumIndex(Vs1, "Size06"), xRow)
                D7205.Size07 = getData(Vs1, getColumIndex(Vs1, "Size07"), xRow)
                D7205.Size08 = getData(Vs1, getColumIndex(Vs1, "Size08"), xRow)
                D7205.Size09 = getData(Vs1, getColumIndex(Vs1, "Size09"), xRow)
                D7205.Size10 = getData(Vs1, getColumIndex(Vs1, "Size10"), xRow)

                D7205.Size11 = getData(Vs1, getColumIndex(Vs1, "Size11"), xRow)
                D7205.Size12 = getData(Vs1, getColumIndex(Vs1, "Size12"), xRow)
                D7205.Size13 = getData(Vs1, getColumIndex(Vs1, "Size13"), xRow)
                D7205.Size14 = getData(Vs1, getColumIndex(Vs1, "Size14"), xRow)
                D7205.Size15 = getData(Vs1, getColumIndex(Vs1, "Size15"), xRow)
                D7205.Size16 = getData(Vs1, getColumIndex(Vs1, "Size16"), xRow)
                D7205.Size17 = getData(Vs1, getColumIndex(Vs1, "Size17"), xRow)
                D7205.Size18 = getData(Vs1, getColumIndex(Vs1, "Size18"), xRow)
                D7205.Size19 = getData(Vs1, getColumIndex(Vs1, "Size19"), xRow)
                D7205.Size20 = getData(Vs1, getColumIndex(Vs1, "Size20"), xRow)

                D7205.Size21 = getData(Vs1, getColumIndex(Vs1, "Size21"), xRow)
                D7205.Size22 = getData(Vs1, getColumIndex(Vs1, "Size22"), xRow)
                D7205.Size23 = getData(Vs1, getColumIndex(Vs1, "Size23"), xRow)
                D7205.Size24 = getData(Vs1, getColumIndex(Vs1, "Size24"), xRow)
                D7205.Size25 = getData(Vs1, getColumIndex(Vs1, "Size25"), xRow)
                D7205.Size26 = getData(Vs1, getColumIndex(Vs1, "Size26"), xRow)
                D7205.Size27 = getData(Vs1, getColumIndex(Vs1, "Size27"), xRow)
                D7205.Size28 = getData(Vs1, getColumIndex(Vs1, "Size28"), xRow)
                D7205.Size29 = getData(Vs1, getColumIndex(Vs1, "Size29"), xRow)
                D7205.Size30 = getData(Vs1, getColumIndex(Vs1, "Size30"), xRow)

                Call REWRITE_PFK7205(D7205)

            Else
                D7205.ShoesCode = getData(Vs1, getColumIndex(Vs1, "KEY_ShoesCode"), xRow)
                D7205.seSizeGroup = ListCode("SizeGroup")
                D7205.cdSizeGroup = getData(Vs1, getColumIndex(Vs1, "cdSizeGroup"), xRow)

                D7205.CheckCondition = "1"
                If getData(Vs1, getColumIndex(Vs1, "CheckCondition"), Vs1.ActiveSheet.ActiveRowIndex).ToString.Contains("UP") Then D7205.CheckCondition = "2"
                If getData(Vs1, getColumIndex(Vs1, "CheckCondition"), Vs1.ActiveSheet.ActiveRowIndex).ToString.Contains("DOWN") Then D7205.CheckCondition = "3"

                D7205.DateInsert = Pub.DAT
                D7205.InchargeInsert = Pub.SAW

                D7205.Size01 = getData(Vs1, getColumIndex(Vs1, "Size01"), xRow)
                D7205.Size02 = getData(Vs1, getColumIndex(Vs1, "Size02"), xRow)
                D7205.Size03 = getData(Vs1, getColumIndex(Vs1, "Size03"), xRow)
                D7205.Size04 = getData(Vs1, getColumIndex(Vs1, "Size04"), xRow)
                D7205.Size05 = getData(Vs1, getColumIndex(Vs1, "Size05"), xRow)
                D7205.Size06 = getData(Vs1, getColumIndex(Vs1, "Size06"), xRow)
                D7205.Size07 = getData(Vs1, getColumIndex(Vs1, "Size07"), xRow)
                D7205.Size08 = getData(Vs1, getColumIndex(Vs1, "Size08"), xRow)
                D7205.Size09 = getData(Vs1, getColumIndex(Vs1, "Size09"), xRow)
                D7205.Size10 = getData(Vs1, getColumIndex(Vs1, "Size10"), xRow)

                D7205.Size11 = getData(Vs1, getColumIndex(Vs1, "Size11"), xRow)
                D7205.Size12 = getData(Vs1, getColumIndex(Vs1, "Size12"), xRow)
                D7205.Size13 = getData(Vs1, getColumIndex(Vs1, "Size13"), xRow)
                D7205.Size14 = getData(Vs1, getColumIndex(Vs1, "Size14"), xRow)
                D7205.Size15 = getData(Vs1, getColumIndex(Vs1, "Size15"), xRow)
                D7205.Size16 = getData(Vs1, getColumIndex(Vs1, "Size16"), xRow)
                D7205.Size17 = getData(Vs1, getColumIndex(Vs1, "Size17"), xRow)
                D7205.Size18 = getData(Vs1, getColumIndex(Vs1, "Size18"), xRow)
                D7205.Size19 = getData(Vs1, getColumIndex(Vs1, "Size19"), xRow)
                D7205.Size20 = getData(Vs1, getColumIndex(Vs1, "Size20"), xRow)

                D7205.Size21 = getData(Vs1, getColumIndex(Vs1, "Size21"), xRow)
                D7205.Size22 = getData(Vs1, getColumIndex(Vs1, "Size22"), xRow)
                D7205.Size23 = getData(Vs1, getColumIndex(Vs1, "Size23"), xRow)
                D7205.Size24 = getData(Vs1, getColumIndex(Vs1, "Size24"), xRow)
                D7205.Size25 = getData(Vs1, getColumIndex(Vs1, "Size25"), xRow)
                D7205.Size26 = getData(Vs1, getColumIndex(Vs1, "Size26"), xRow)
                D7205.Size27 = getData(Vs1, getColumIndex(Vs1, "Size27"), xRow)
                D7205.Size28 = getData(Vs1, getColumIndex(Vs1, "Size28"), xRow)
                D7205.Size29 = getData(Vs1, getColumIndex(Vs1, "Size29"), xRow)
                D7205.Size30 = getData(Vs1, getColumIndex(Vs1, "Size30"), xRow)

                Call WRITE_PFK7205(D7205)
            End If
        End If

    End Sub

#End Region


End Class