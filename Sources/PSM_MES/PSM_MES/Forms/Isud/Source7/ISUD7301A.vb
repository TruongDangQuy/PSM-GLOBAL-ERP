Public Class ISUD7301A
#Region "Variable"
    Private wJOB As Integer

    Private W7301 As T7301_AREA
    Private L7301 As T7301_AREA

    Private W7302 As T7302_AREA
    Private L7302 As T7302_AREA

    Private WRITE_CHK As String

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7301A(job As Integer, MaterialBOMCode As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D7301.MaterialBOMCode = MaterialBOMCode

        wJOB = job : L7301 = D7301

        Link_ISUD7301A = False

        Try
            Select Case job
                Case 1
                Case Else

                    If READ_PFK7301(L7301.MaterialBOMCode) = False Then
                        Call MsgBoxP("3", "LINK_ISUD")

                        Me.Dispose()
                        Exit Function
                    End If
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD7301A = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("MaterialBOMCode"))
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


                cmd_DEL.Visible = False

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call KEY_COUNT()

                Call DATA_SEARCH01()
                Call DATA_SEARCH02()

                Setfocus(txt_MaterialBOMName)
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
                Call DATA_SEARCH02()
            Case 3
                Me.Text = Me.Text & " - UPDATE"
                txt_MaterialBOMCode.Enabled = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH02()

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
                        Call MsgBoxP("16", "Form_Activate")
                    End If
                End If

            Case 4
                Me.Text = Me.Text & " - DELETE"

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
    Private Sub DATA_INIT()
        Try
            txt_MaterialBOMCode.Enabled = False
            Call D7301_CLEAR()
            W7301 = D7301

            txt_MaterialBOMName.Data = ""

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Sub FORM_INIT()

    End Sub
#End Region

#Region "Data_Search"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False
        Try

            DS1 = READ_PFK7301(L7301.MaterialBOMCode, cn)

            If GetDsRc(DS1) = 0 Then
                Exit Function : Me.Dispose()
                isudCHK = False
            End If

            Call READER_MOVE(Me, DS1)


            If GetDsData(DS1, 0, "K7301_CheckUse") = "1" Then
                rad_CheckUse1.Checked = True
                rad_CheckUse2.Checked = False
            Else
                rad_CheckUse1.Checked = False
                rad_CheckUse2.Checked = True
            End If

            DATA_SEARCH01 = True

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_SEARCH01")
        End Try

    End Function

    Private Function DATA_SEARCH02() As Boolean
        DATA_SEARCH02 = False

        DS1 = PrcDS("USP_ISUD7301A_SEARCH_VS1", cn, L7301.MaterialBOMCode)

        If GetDsRc(DS1) = 0 Then
            SPR_SET(Vs1, , , , OperationMode.Normal)
            SPR_PRO_NEW(Vs1, DS1, "USP_ISUD7301A_SEARCH_VS1", "Vs1")
            Vs1.ActiveSheet.RowCount = 10
            Vs1.Enabled = True
            Exit Function
        End If
        SPR_SET(Vs1, , , , OperationMode.Normal)
        SPR_PRO_NEW(Vs1, DS1, "USP_ISUD7301A_SEARCH_VS1", "Vs1")

        DATA_SEARCH02 = True


    End Function
#End Region

#Region "Function"

    Private Function Data_Check() As Boolean
        Data_Check = False
        Dim i As Integer

        Try
            If txt_MaterialBOMName.Data.Trim = "" Then Setfocus(txt_MaterialBOMName) : Exit Function
            txt_MaterialBOMName.Data = Replace(txt_MaterialBOMName.Data, "'", "`")

            If wJOB = "1" Then
                If READ_PFK7301(L7301.MaterialBOMCode) = True Then
                    Call MsgBoxP("5", "DATA_INSERT")
                    txt_MaterialBOMCode.Focus()
                    KEY_COUNT()
                    Exit Function
                End If
            End If

            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If getData(Vs1, getColumIndex(Vs1, "cdGroupComponent"), i) = "" Then MsgBoxP("GroupComponent Name at Line" & (i + 1)) : Exit Function
            Next

            Data_Check = True
skip_1:
        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))

        End Try
    End Function


    Private Sub DATA_MOVE()
        Try

            Call K7301_MOVE(Me, W7301, 1, txt_MaterialBOMCode.Code)
            If rad_CheckUse1.Checked = True Then W7301.CheckUse = "1"
            If rad_CheckUse2.Checked = True Then W7301.CheckUse = "2"

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE"))
        End Try
    End Sub

    Private Sub DATA_MOVE_WRITE01()
        Try

            SQL = "DELETE FROM PFK7302 "
            SQL = SQL & " WHERE K7302_MaterialBOMCode  = '" & W7301.MaterialBOMCode & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            Dim i As Integer
            Dim j As Integer
            j = 0
            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If getData(Vs1, getColumIndex(Vs1, "cdGroupComponent"), i) = "" Then GoTo skip

                j = j + 1

                Call D7302_CLEAR() : W7302 = D7302

                W7302.MaterialBOMCode = txt_MaterialBOMCode.Data

                W7302.MaterialBOMSeq = CIntp(getData(Vs1, getColumIndex(Vs1, "KEY_MaterialBOMSeq"), i))

                If K7302_MOVE(Vs1, i, W7302, W7302.MaterialBOMCode, W7302.MaterialBOMSeq) = False Then
                    W7302.MaterialBOMCode = L7301.MaterialBOMCode
                    Call KEY_COUNT_SEQ()

                    W7302.Dseq = j

                    W7302.seGroupComponent = ListCode("GroupComponent")


                    Call WRITE_PFK7302(W7302)
                Else
                    W7302.Dseq = j

                    W7302.seGroupComponent = ListCode("GroupComponent")

                    Call REWRITE_PFK7302(W7302)
                End If
skip:
            Next

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE_WRITE01"))
        End Try

    End Sub


    Private Sub DATA_INSERT()
        Try

            Call DATA_MOVE()
            Call KEY_COUNT()

            If WRITE_PFK7301(W7301) = True Then
                Call DATA_MOVE_WRITE01()

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
            If REWRITE_PFK7301(W7301) = True Then
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

            If READ_PFK7301(L7301.MaterialBOMCode) = True Then
                W7301 = D7301

                SQL = "DELETE FROM PFK7302 "
                SQL = SQL & " WHERE K7302_MaterialBOMCode  = '" & W7301.MaterialBOMCode & "' "
                cmd = New SqlClient.SqlCommand(SQL, cn)
                cmd.ExecuteNonQuery()

                Call DELETE_PFK7301(W7301)
            End If

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub

    Private Sub KEY_COUNT()
        Try

            SQL = " SELECT MAX(CAST(K7301_MaterialBOMCode AS DECIMAL)) as MAX_CODE FROM PFK7301 "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If IsDBNull(rd!MAX_CODE) Then
                W7301.MaterialBOMCode = "000001"
            Else
                W7301.MaterialBOMCode = Format(CIntp(rd!MAX_CODE + 1), "000000")
            End If

            rd.Close()

            txt_MaterialBOMCode.Data = W7301.MaterialBOMCode
            L7301.MaterialBOMCode = W7301.MaterialBOMCode

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub


    Private Sub KEY_COUNT_SEQ()
        Try

            SQL = " SELECT MAX(K7302_MaterialBOMSeq) as MAX_CODE FROM PFK7302 "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If IsDBNull(rd!MAX_CODE) Then
                W7302.MaterialBOMSeq = 1
            Else
                W7302.MaterialBOMSeq = CIntp(rd!MAX_CODE + 1)
            End If

            rd.Close()

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub


#End Region

#Region "Event"

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Select Case wJOB
            Case 1
                If Data_Check() = False Then Exit Sub
                If DataCheck(Me, "PFK7301") = False Then Exit Sub
                Call KEY_COUNT()
                Call DATA_INSERT()

                wJOB = 3
                Me.Dispose()
            Case 2
                Me.Dispose()
            Case 3
                If Data_Check() = False Then Exit Sub
                If DataCheck(Me, "PFK7301") = False Then Exit Sub
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
        Me.Dispose()

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

                Call Select_Message("3", WordConv("PROCESSING"), 2)
                W7302.MaterialBOMCode = getData(Vs1, getColumIndex(Vs1, "KEY_MaterialBOMCode"), xROW)
                W7302.MaterialBOMSeq = getData(Vs1, getColumIndex(Vs1, "KEY_MaterialBOMSeq"), xROW)

                If Msg_Result <> vbYes Then Exit Sub

                SPR_DEL(Vs1, xCOL, xROW)
                Call DELETE_PFK7302(W7302)
                Vs1.ActiveSheet.ActiveColumnIndex = xCOL
                Vs1.ActiveSheet.ActiveRowIndex = xROW
                Vs1.Focus()

            Case Keys.Enter

        End Select
    End Sub


    Private Sub txt_cdMasterBOM_Load(sender As Object, e As EventArgs) Handles txt_cdMasterBOM.btnTitleClick
        Dim xROW As Integer

        xROW = Vs1.ActiveSheet.ActiveRowIndex
        If Vs1.ActiveSheet.ActiveRowIndex < 0 Then Exit Sub

        If HLP7301A.Link_HLP7301A("") = False Then Exit Sub

        If hlp0000SeVa = "" Then Exit Sub
        DS1 = PrcDS("USP_ISUD7301A_SEARCH_VS1", cn, hlp0000SeVaTt)

        Call READ_SPREAD_N(Vs1, DS1, xROW, GetDsRc(DS1), "USP_ISUD7301A_SEARCH_VS1", "VS1")

    End Sub

    

#End Region



End Class