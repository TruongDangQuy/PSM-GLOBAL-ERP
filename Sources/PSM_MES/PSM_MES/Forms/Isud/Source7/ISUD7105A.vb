Public Class ISUD7105A
#Region "Variable"
    Private wJOB As Integer

    Private W7105 As T7105_AREA
    Private L7105 As T7105_AREA

    Private W7109 As T7109_AREA
    Private L7109 As T7109_AREA

    Private WRITE_CHK As String

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7105A(job As Integer, CustomerCode As String, SizeRangeTool As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D7105.SizeRangeTool = SizeRangeTool
        D7105.CustomerCode = CustomerCode

        wJOB = job : L7105 = D7105

        Link_ISUD7105A = False
        Try
            Select Case job
                Case 1
                Case Else
                    If READ_PFK7105(L7105.SizeRangeTool) = False Then
                        Call MsgBoxP("3", "LINK_ISUD")

                        Me.Dispose()
                        Exit Function
                    End If
            End Select

            If READ_PFK7101(CustomerCode) Then
                txt_CustomerCode.Data = D7101.CustomerName
                txt_CustomerCode.Code = D7101.CustomerCode
            End If


            formA = False
            Me.ShowDialog()

            Link_ISUD7105A = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("SizeRangeTool"))
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
                tst_iDelete.Visible = False
                tst_iSave.Visible = True

                Call KEY_COUNT()
                Call DATA_SEARCH02()

                Setfocus(txt_SizeRangeToolName)
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

                Call DATA_SEARCH01()
                Call DATA_SEARCH02()
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
                txt_SizeRangeTool.Enabled = False

                tst_iDelete.Visible = False
                tst_iSave.Visible = True

                Call DATA_SEARCH01()
                Call DATA_SEARCH02()


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
                Call DATA_SEARCH02()

        End Select

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Try
            txt_SizeRangeTool.Enabled = False
            Call D7105_CLEAR()
            W7105 = D7105

            txt_SizeRangeToolName.Data = ""
            txt_SizeRangeToolSimpleName.Data = ""

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub
    Private Sub FORM_INIT()
        Try

            tst_iUtilities.Visible = True
            tst_iAttach.Visible = True
            tst_iHistory.Visible = False
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Data_Search"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False

        DS1 = READ_PFK7105(L7105.SizeRangeTool, cn)
        If GetDsRc(DS1) = 0 Then
            Exit Function
            isudCHK = False
        End If

        READER_MOVE(Me, DS1)
        If GetDsData(DS1, 0, "CheckUse") = "1" Then rad_CheckUse1.Checked = True
        If GetDsData(DS1, 0, "CheckUse") = "2" Then rad_CheckUse2.Checked = True

        DATA_SEARCH01 = True

    End Function

    Private Function DATA_SEARCH02() As Boolean
        DATA_SEARCH02 = False

        DS1 = PrcDS("USP_ISUD7105A_SEARCH_VS1", cn, L7105.SizeRangeTool)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs1, DS1, "USP_ISUD7105A_SEARCH_VS1", "Vs1")
            Vs1.ActiveSheet.RowCount = 1
            Vs1.HorizontalScrollBarPolicy = ScrollBarPolicy.Never
            Vs1.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "USP_ISUD7105A_SEARCH_VS1", "Vs1")
        Vs1.ActiveSheet.RowCount = 1
        Vs1.HorizontalScrollBarPolicy = ScrollBarPolicy.Never

        DATA_SEARCH02 = True


    End Function
#End Region

#Region "Function"

    Private Function Data_Check() As Boolean
        Data_Check = False

        Try
            If txt_SizeRangeToolName.Data.Trim = "" Then Setfocus(txt_SizeRangeToolName) : Exit Function
            txt_SizeRangeToolName.Data = Replace(txt_SizeRangeToolName.Data, "'", "`")

            If wJOB = "1" Then
                If READ_PFK7105(L7105.SizeRangeTool) = True Then
                    Call MsgBoxP("5", "DATA_INSERT")
                    txt_SizeRangeTool.Focus()
                    KEY_COUNT()
                    Exit Function
                End If
            End If


            Data_Check = True
skip_1:
        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))

        End Try
    End Function

    Private Sub DATA_MOVE()
        W7105.SizeRangeTool = txt_SizeRangeTool.Data
        W7105.SizeRangeToolName = txt_SizeRangeToolName.Data

        Call K7105_MOVE(Me, W7105, 1, txt_SizeAverage01.Data)

        W7105.Size01 = getData(Vs1, getColumIndex(Vs1, "Size01"), 0)
        W7105.Size02 = getData(Vs1, getColumIndex(Vs1, "Size02"), 0)
        W7105.Size03 = getData(Vs1, getColumIndex(Vs1, "Size03"), 0)
        W7105.Size04 = getData(Vs1, getColumIndex(Vs1, "Size04"), 0)
        W7105.Size05 = getData(Vs1, getColumIndex(Vs1, "Size05"), 0)
        W7105.Size06 = getData(Vs1, getColumIndex(Vs1, "Size06"), 0)
        W7105.Size07 = getData(Vs1, getColumIndex(Vs1, "Size07"), 0)
        W7105.Size08 = getData(Vs1, getColumIndex(Vs1, "Size08"), 0)
        W7105.Size09 = getData(Vs1, getColumIndex(Vs1, "Size09"), 0)
        W7105.Size10 = getData(Vs1, getColumIndex(Vs1, "Size10"), 0)

        W7105.Size11 = getData(Vs1, getColumIndex(Vs1, "Size11"), 0)
        W7105.Size12 = getData(Vs1, getColumIndex(Vs1, "Size12"), 0)
        W7105.Size13 = getData(Vs1, getColumIndex(Vs1, "Size13"), 0)
        W7105.Size14 = getData(Vs1, getColumIndex(Vs1, "Size14"), 0)
        W7105.Size15 = getData(Vs1, getColumIndex(Vs1, "Size15"), 0)
        W7105.Size16 = getData(Vs1, getColumIndex(Vs1, "Size16"), 0)
        W7105.Size17 = getData(Vs1, getColumIndex(Vs1, "Size17"), 0)
        W7105.Size18 = getData(Vs1, getColumIndex(Vs1, "Size18"), 0)
        W7105.Size19 = getData(Vs1, getColumIndex(Vs1, "Size19"), 0)
        W7105.Size20 = getData(Vs1, getColumIndex(Vs1, "Size20"), 0)

        W7105.Size21 = getData(Vs1, getColumIndex(Vs1, "Size21"), 0)
        W7105.Size22 = getData(Vs1, getColumIndex(Vs1, "Size22"), 0)
        W7105.Size23 = getData(Vs1, getColumIndex(Vs1, "Size23"), 0)
        W7105.Size24 = getData(Vs1, getColumIndex(Vs1, "Size24"), 0)
        W7105.Size25 = getData(Vs1, getColumIndex(Vs1, "Size25"), 0)
        W7105.Size26 = getData(Vs1, getColumIndex(Vs1, "Size26"), 0)
        W7105.Size27 = getData(Vs1, getColumIndex(Vs1, "Size27"), 0)
        W7105.Size28 = getData(Vs1, getColumIndex(Vs1, "Size28"), 0)
        W7105.Size29 = getData(Vs1, getColumIndex(Vs1, "Size29"), 0)
        W7105.Size30 = getData(Vs1, getColumIndex(Vs1, "Size30"), 0)

        W7105.seGender = ListCode("Gender")
        W7105.seSeason = ListCode("Season")

        If rad_CheckUse1.Checked = True Then W7105.CheckUse = "1"
        If rad_CheckUse2.Checked = True Then W7105.CheckUse = "2"
    End Sub


    Private Sub DATA_INSERT()
        Try

            Call DATA_MOVE()
            Call KEY_COUNT()
            W7105.DateInsert = Pub.DAT
            W7105.InchargeInsert = Pub.SAW
            If WRITE_PFK7105(W7105) = True Then

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
            W7105.DateUpdate = Pub.DAT
            W7105.InchargeUpdate = Pub.SAW
            If REWRITE_PFK7105(W7105) = True Then

                isudCHK = True
                Me.Dispose()
            End If

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

    Private Sub KEY_COUNT()
        Try

            SQL = " SELECT MAX(CAST(K7105_SizeRangeTool AS DECIMAL)) as MAX_CODE FROM PFK7105 "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If IsDBNull(rd!MAX_CODE) Then
                W7105.SizeRangeTool = "000001"
            Else
                W7105.SizeRangeTool = Format(CInt(rd!MAX_CODE + 1), "000000")
            End If

            rd.Close()

            txt_SizeRangeTool.Data = W7105.SizeRangeTool
            L7105.SizeRangeTool = W7105.SizeRangeTool

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

    Private Sub DATA_DELETE()
        Try
            Call DATA_MOVE()
            If DELETE_PFK7105(W7105) = True Then

                isudCHK = True
                Me.Dispose()
            End If

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

#End Region

#Region "Event"

    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        Select Case wJOB
            Case 1
                Call KEY_COUNT()
                Call DATA_INSERT()

                Call FORM_INIT()
                Call DATA_INIT()
                Call KEY_COUNT()
                Setfocus(txt_SizeRangeToolName)

            Case 2
                Me.Dispose()
            Case 3
                If DataCheck(Me, "PFK7018") = False Then Exit Sub
                Call DATA_UPDATE()
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
            Case Keys.Enter
                If READ_PFK7105(txt_SizeRangeTool.Data) Then
                    W7105 = D7105
                    W7105.Size01 = getData(Vs1, getColumIndex(Vs1, "Size01"), 0)
                    W7105.Size02 = getData(Vs1, getColumIndex(Vs1, "Size02"), 0)
                    W7105.Size03 = getData(Vs1, getColumIndex(Vs1, "Size03"), 0)
                    W7105.Size04 = getData(Vs1, getColumIndex(Vs1, "Size04"), 0)
                    W7105.Size05 = getData(Vs1, getColumIndex(Vs1, "Size05"), 0)
                    W7105.Size06 = getData(Vs1, getColumIndex(Vs1, "Size06"), 0)
                    W7105.Size07 = getData(Vs1, getColumIndex(Vs1, "Size07"), 0)
                    W7105.Size08 = getData(Vs1, getColumIndex(Vs1, "Size08"), 0)
                    W7105.Size09 = getData(Vs1, getColumIndex(Vs1, "Size09"), 0)
                    W7105.Size10 = getData(Vs1, getColumIndex(Vs1, "Size10"), 0)

                    W7105.Size11 = getData(Vs1, getColumIndex(Vs1, "Size11"), 0)
                    W7105.Size12 = getData(Vs1, getColumIndex(Vs1, "Size12"), 0)
                    W7105.Size13 = getData(Vs1, getColumIndex(Vs1, "Size13"), 0)
                    W7105.Size14 = getData(Vs1, getColumIndex(Vs1, "Size14"), 0)
                    W7105.Size15 = getData(Vs1, getColumIndex(Vs1, "Size15"), 0)
                    W7105.Size16 = getData(Vs1, getColumIndex(Vs1, "Size16"), 0)
                    W7105.Size17 = getData(Vs1, getColumIndex(Vs1, "Size17"), 0)
                    W7105.Size18 = getData(Vs1, getColumIndex(Vs1, "Size18"), 0)
                    W7105.Size19 = getData(Vs1, getColumIndex(Vs1, "Size19"), 0)
                    W7105.Size20 = getData(Vs1, getColumIndex(Vs1, "Size20"), 0)

                    W7105.Size21 = getData(Vs1, getColumIndex(Vs1, "Size21"), 0)
                    W7105.Size22 = getData(Vs1, getColumIndex(Vs1, "Size22"), 0)
                    W7105.Size23 = getData(Vs1, getColumIndex(Vs1, "Size23"), 0)
                    W7105.Size24 = getData(Vs1, getColumIndex(Vs1, "Size24"), 0)
                    W7105.Size25 = getData(Vs1, getColumIndex(Vs1, "Size25"), 0)
                    W7105.Size26 = getData(Vs1, getColumIndex(Vs1, "Size26"), 0)
                    W7105.Size27 = getData(Vs1, getColumIndex(Vs1, "Size27"), 0)
                    W7105.Size28 = getData(Vs1, getColumIndex(Vs1, "Size28"), 0)
                    W7105.Size29 = getData(Vs1, getColumIndex(Vs1, "Size29"), 0)
                    W7105.Size30 = getData(Vs1, getColumIndex(Vs1, "Size30"), 0)

                    Call REWRITE_PFK7105(W7105)
                End If

        End Select
    End Sub

#End Region


End Class