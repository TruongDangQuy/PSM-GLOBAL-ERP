Public Class ISUD7156B

#Region "Variable"
    Private wJOB As Integer

    Private W7156 As New T7156_AREA
    Private L7156 As New T7156_AREA

    Private ExportTax As Decimal
    Private EnvironmentTax As Decimal
    Private VatTax As Decimal

    Private WRITE_CHK As String
    Private formA As Boolean
    Private CHK(0 To 5) As String

#End Region

#Region "Link"
    Public Function Link_ISUD7156B(job As Integer, cdToolGroup As String, ToolNo As String, MaterialCode As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D7156.ToolNo = ToolNo
        D7156.MaterialCode = MaterialCode
        D7156.cdToolGroup = cdToolGroup

        wJOB = job : L7156 = D7156
        txt_MaterialCode.Data = MaterialCode
        txt_ToolNo.Data = ToolNo

        Link_ISUD7156B = False
        Try

            Select Case job
                Case 1
                    Call KEY_COUNT_TOOLNO()
                Case Else

            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD7156B = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))
        End Try


    End Function
#End Region

#Region "Form"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        'Me.Form_Initial()
        Me.Form_KeyDown()

        Call DATA_INIT()
        Call FORM_INIT()

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        Select Case wJOB
            Case 1                                                      'ÀÔ·Â
                Me.Text = Me.Text & " - INSERT"
                Frame1.Enabled = True
                cmd_DEL.Visible = False
                Call KEY_COUNT_TOOLNO()
                Call KEY_COUNT()

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH_vS0()
                Call DATA_SEARCHvS1()
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

                Call DATA_SEARCH_vS0()
                Call DATA_SEARCHvS1()
            Case 3
                Me.Text = Me.Text & " - UPDATE"

                Frame1.Enabled = True
                txt_MaterialCode.Enabled = False
                cmd_DEL.Visible = True
                cmd_OK.Visible = False

                Call DATA_SEARCH_vS0()
                Call DATA_SEARCHvS1()

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

                Call DATA_SEARCH_vS0()
                Call DATA_SEARCHvS1()

        End Select

        formA = True
    End Sub
#End Region

#Region "Search"

    Private Function DATA_SEARCH_vS0() As Boolean
        DATA_SEARCH_vS0 = False

        DS1 = PrcDS("USP_ISUD7156B_SEARCH_VS0", cn, L7156.MaterialCode, L7156.ToolNo)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO(vS0, DS1, "USP_ISUD7156B_SEARCH_VS0", "VS0")

            DS2 = PrcDS("USP_ISUD7156B_SEARCH_VS0_INSERT", cn, L7156.MaterialCode)

            If GetDsRc(DS2) = 0 Then Exit Function

            SPR_PRO(vS0, DS2, "USP_ISUD7156B_SEARCH_VS0", "VS0")

            Call VsSizeRangeTool(vS0, "USP_ISUD7156B_SEARCH_HEAD", L7156.MaterialCode)

            vS0.Enabled = True
            Exit Function
        End If

        SPR_PRO(vS0, DS1, "USP_ISUD7156B_SEARCH_VS0", "VS0")
        Call VsSizeRangeTool(vS0, "USP_ISUD7156B_SEARCH_HEAD", L7156.MaterialCode)

        DATA_SEARCH_vS0 = True


    End Function

    Private Function DATA_SEARCHvS1() As Boolean
        DATA_SEARCHvS1 = False
        Dim i As Integer

        If READ_PFK7231(L7156.MaterialCode) = True Then
            txt_MaterialName.Data = D7231.MaterialName
        End If

        If READ_PFK7171(ListCode("ToolGroup"), L7156.cdToolGroup) Then
            txt_cdToolGroup.Data = D7171.BasicName
            txt_cdToolGroup.Code = D7171.BasicCode
        End If

        DS1 = PrcDS("USP_ISUD7156B_SEARCH_VS1", cn, L7156.ToolNo, L7156.MaterialCode)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO(Vs1, DS1, "USP_ISUD7156B_SEARCH_VS1", "Vs1")
            Vs1.ActiveSheet.RowCount = CIntp(txt_QtyBase.Data)
            Vs1.Enabled = True
            Exit Function
        End If

        SPR_PRO(Vs1, DS1, "USP_ISUD7156B_SEARCH_VS1", "Vs1")

        DATA_SEARCHvS1 = True


    End Function

    Private Sub cmd_Generate_Load(sender As Object, e As EventArgs) Handles cmd_Generate.btnTitleClick
        Call DATA_SEARCHvS1()
    End Sub

#End Region

#Region "Function"
    Private Sub DATA_MOVE()



    End Sub

    Private Sub DATA_MOVE_WRITE01()
        Dim i As Integer
        Dim j As Integer
        j = 0
        Dim Xcol As Integer
        Xcol = getColumIndex(vS0, "SizeRangeToolName") + 1

        For i = Xcol To vS0.ActiveSheet.ColumnCount - 1
            If CIntp(getData(vS0, i, 0)) > 0 Then
                For j = 0 To CIntp(getData(vS0, i, 0)) - 1
                    W7156.SizeNo = (i - Xcol + 1).ToString("00")

                    W7156.ToolName = txt_MaterialName.Data & "-" & getDataCH(vS0, i, 0)
                    W7156.ToolNameSimply = txt_MaterialName.Data & "-" & getDataCH(vS0, i, 0)

                    W7156.ToolSize = getDataCH(vS0, i, 0)
                    W7156.DateTool = txt_DateTool.Data

                    W7156.MaterialCode = L7156.MaterialCode
                    Call KEY_COUNT()
                    W7156.ToolNo = L7156.ToolNo

                    W7156.DateInsert = Pub.DAT
                    W7156.InchargeInsert = Pub.SAW

                    W7156.DateTool = Pub.DAT

                    W7156.CheckUse = "1"

                    W7156.cdToolGroup = txt_cdToolGroup.Code
                    W7156.seToolGroup = ListCode("ToolGroup")

                    If WRITE_PFK7156(W7156) = True Then
                        isudCHK = True
                        WRITE_CHK = "*"
                    End If

                Next

            End If
        Next

        '        For i = 0 To Vs1.ActiveSheet.RowCount - 1
        '            If Trim(getData(Vs1, getColumIndex(Vs1, "ToolName"), i)) = "" Then GoTo skip

        '            j = j + 1
        '            If K7156_MOVE(Vs1, i, W7156, getData(Vs1, getColumIndex(Vs1, "Key_ToolCode"), i)) = True Then
        '                W7156.ToolNo = L7156.ToolNo
        '                W7156.seToolGroup = ListCode("ToolGroup")
        '                W7156.DateUpdate = Pub.DAT
        '                W7156.InchargeUpdate = Pub.SAW

        '                Call REWRITE_PFK7156(W7156)
        '            Else
        '                W7156.MaterialCode = L7156.MaterialCode
        '                KEY_COUNT()
        '                W7156.ToolNo = L7156.ToolNo

        '                W7156.DateInsert = Pub.DAT
        '                W7156.InchargeInsert = Pub.SAW

        '                W7156.DateTool = Pub.DAT

        '                W7156.CheckUse = "1"

        '                W7156.cdToolGroup = txt_cdToolGroup.Code
        '                W7156.seToolGroup = ListCode("ToolGroup")

        '                If WRITE_PFK7156(W7156) = True Then
        '                    isudCHK = True
        '                End If
        '            End If
        'skip:
        '        Next
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
                If K7156_MOVE(Vs1, i, W7156, getData(Vs1, getColumIndex(Vs1, "Key_ToolCode"), i)) = True Then

                    If DELETE_PFK7156(W7156) = True Then isudCHK = True

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
            SQL = "SELECT MAX(CAST(K7156_ToolCode AS DECIMAL)) AS MAX_MCODE FROM PFK7156 "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W7156.ToolCode = "00000001"
            Else
                W7156.ToolCode = Format(CInt(rd!MAX_MCODE + 1), "00000000")
            End If

            rd.Close()

            L7156.ToolCode = W7156.ToolCode

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

    Private Sub KEY_COUNT_TOOLNO()
        Try
            SQL = "SELECT MAX(CAST(K7156_ToolNo AS DECIMAL)) AS MAX_MCODE FROM PFK7156 "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W7156.ToolNo = "000001"
            Else
                W7156.ToolNo = Format(CInt(rd!MAX_MCODE + 1), "000000")
            End If

            rd.Close()

            L7156.ToolNo = W7156.ToolNo
            txt_ToolNo.Data = W7156.ToolNo

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub
    Private Sub DATA_INIT()
        txt_DateTool.Data = Pub.DAT
    End Sub

    Private Sub FORM_INIT()

    End Sub

#End Region

#Region "Event"
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Select Case wJOB
            Case 1
                If DataCheck(Me, "PFK7156") = False Then Exit Sub
                Call KEY_COUNT_TOOLNO()
                Call KEY_COUNT()

                Call DATA_MOVE_WRITE01()
                Call DATA_SEARCHvS1()
                wJOB = 3
            Case 2
                Me.Dispose()
            Case 3
                If DataCheck(Me, "PFK7156") = False Then Exit Sub
                Call DATA_MOVE_WRITE01()
                Call DATA_SEARCHvS1()
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

    Private Sub Vs1_ButtonClicked(sender As Object, e As EditorNotifyEventArgs) Handles Vs1.ButtonClicked
     

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

                If K7156_MOVE(Vs1, xROW, W7156, getData(Vs1, getColumIndex(Vs1, "KEY_ToolCode"), xROW)) Then
                    If DELETE_PFK7156(W7156) = True Then
                        isudCHK = True
                    End If
                End If

                SPR_DEL(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex)
                Vs1.Focus()
            Case Keys.Enter

        End Select
    End Sub

#End Region

End Class