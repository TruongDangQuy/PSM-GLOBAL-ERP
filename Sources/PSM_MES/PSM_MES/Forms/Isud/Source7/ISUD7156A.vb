Public Class ISUD7156A
    Private wJOB As Integer

    Private KEY_CHK As String
    Private WRITE_CHK As String

    Private W7156 As T7156_AREA
    Private L7156 As T7156_AREA

    Private formA As Boolean
    Private CHK(0 To 5) As String

    Public Function Link_ISUD7156A(job As Integer, cdToolGroup As String, ToolCode As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D7156.cdToolGroup = cdToolGroup
        D7156.ToolCode = ToolCode

        wJOB = job : L7156 = D7156

        Link_ISUD7156A = False

        Select Case job
            Case 1
                If READ_PFK7171(ListCode("ToolGroup"), cdToolGroup) = True Then
                    txt_cdToolGroup.Code = D7171.BasicCode
                    txt_cdToolGroup.Data = D7171.BasicName
                End If

            Case Else
                If READ_PFK7156(L7156.ToolCode) = False Then
                    Call MsgBoxP("3", "LINK_ISUD")
                    Exit Function
                End If
        End Select

        formA = False
        Me.ShowDialog()

        Link_ISUD7156A = isudCHK
    End Function

#Region "Form_load"
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
                    Call MsgBoxP("4", "Form_Activate")
                    Me.Dispose()
                    Exit Sub
                End If

                Call KEY_COUNT()
                Setfocus(txt_ToolName)

            Case 2
                Me.Text = Me.Text & " - SEARCH"

                cmd_DEL.Visible = False
                cmd_OK.Visible = False

                If CHK(2) <> "1" Then
                    isudCHK = False
                    Call MsgBoxP("4", "Form_Activate")
                    Me.Dispose()
                    Exit Sub
                End If

                Call DATA_SEARCH01()

            Case 3
                Me.Text = Me.Text & " - UPDATE"

                Call DATA_SEARCH01()

                If CHK(3) <> "1" Then
                    If CHK(2) <> "1" Then
                        isudCHK = False
                        Call MsgBoxP("4", "Form_Activate")

                        Me.Dispose()
                        Exit Sub
                    Else
                        Call MsgBoxP("16", "Form_Activate")
                        Me.Text = Me.Text & " - SEARCH"
                        isudCHK = False
                        wJOB = 2

                        cmd_DEL.Visible = False
                        frm_Condition.Enabled = False
                    End If
                End If

            Case 4
                Me.Text = Me.Text & " - DELETE"

                frm_Condition.Enabled = False

                Call DATA_SEARCH01()

                If CHK(4) <> "1" Then
                    Call MsgBoxP("4", "Form_Activate")
                    Me.Dispose()
                    Exit Sub
                End If

        End Select

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Call D7156_CLEAR()
        W7156 = D7156

        txt_ToolName.Data = ""
        txt_ToolNameSimply.Data = ""

        txt_ToolWidth.Data = ""
        txt_ToolWeight.Data = ""

        KEY_CHK = ""
    End Sub

#End Region

#Region "Function"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False
        DS1 = READ_PFK7156(L7156.ToolCode, cn)

        If GetDsRc(DS1) = 0 Then
            Exit Function : Me.Dispose()
            isudCHK = False
        End If

        READER_MOVE(Me, DS1)
        DATA_SEARCH01 = True

    End Function

    Private Sub DATA_MOVE()
        Call K7156_MOVE(Me, W7156, wJOB, txt_ToolCode.Data)

        W7156.seToolGroup = ListCode("ToolGroup")
        W7156.seProcessProduction = ListCode("ProcessProduction")

    End Sub

    Private Function DATA_INSERT() As Boolean
        DATA_INSERT = False
        Call DATA_MOVE()
        Call KEY_COUNT()

        If READ_PFK7156(W7156.ToolCode) = True Then
            Call MsgBoxP("5", "DATA_INSERT")
            Call KEY_COUNT()
            Exit Function
        End If


        If WRITE_PFK7156(W7156) = True Then isudCHK = True : WRITE_CHK = "*"
        DATA_INSERT = True
    End Function

    Private Function DATA_UPDATE() As Boolean
        DATA_UPDATE = False
        If DataCheck(Me) = False Then Exit Function

        Call DATA_MOVE()

        If REWRITE_PFK7156(W7156) = True Then isudCHK = True
        DATA_UPDATE = True
        Me.Dispose()
    End Function

    Private Sub DATA_DELETE()
        DATA_MOVE()

        If DELETE_PFK7156(W7156) = True Then isudCHK = True

        Me.Dispose()

    End Sub

    Private Sub KEY_COUNT()
        If KEY_CHK = "*" Then Exit Sub

        SQL = "SELECT MAX(CAST(K7156_ToolCode AS DECIMAL)) AS MAX_MCODE FROM PFK7156 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_MCODE) Then
            L7156.ToolCode = "00000001"
        Else
            L7156.ToolCode = Format(CInt(rd!MAX_MCODE + 1), "00000000")
        End If

        W7156.ToolCode = L7156.ToolCode
        rd.Close()

        txt_ToolCode.Data = W7156.ToolCode
    End Sub

#End Region

#Region "Event"
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click

        Select Case wJOB
            Case 1
                If DataCheck(Me, "PFK7156") = False Then Exit Sub
                If DATA_INSERT() = False Then Exit Sub

                Call DATA_INIT()
                Call KEY_COUNT()
                Setfocus(txt_ToolName)
            Case 2
                Me.Dispose()
            Case 3
                If DataCheck(Me, "PFK7156") = False Then Exit Sub
                If DATA_UPDATE() = False Then Exit Sub
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

    Private Sub cmd_Picture_Click(sender As Object, e As EventArgs)
        If ISUD7555A.Link_ISUD7555A(3, Me.Name, getPrimaryKey(Me)) = False Then Exit Sub
    End Sub

   


#End Region




  
End Class