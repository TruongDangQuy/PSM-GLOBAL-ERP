Public Class ISUD7231SP

#Region "Variable"
    Private wJOB As Integer

    Private WRITE_CHK As String
    Private KEY_CHK As String

    Private W7231 As T7231_AREA
    Private L7231 As T7231_AREA

    Private formA As Boolean
    Private CHK(0 To 5) As String
    Private chkBOM As Boolean = False
#End Region

#Region "Link"
    Public Function Link_ISUD7231SP(job As Integer, MaterialCode As String, Optional ByVal TAG As String = "") As Boolean
        D7231.MaterialCode = MaterialCode

        wJOB = job : L7231 = D7231

        Link_ISUD7231SP = False

        Select Case job
            Case 1
            Case Else
                If READ_PFK7231(L7231.MaterialCode) = False Then
                    Call MsgBoxP("3", "LINK_ISUD")

                    Exit Function
                End If
        End Select

        formA = False
        Me.Tag = TAG
        Me.ShowDialog()

        Link_ISUD7231SP = isudCHK
    End Function

   
#End Region

#Region "Form_load"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub
        Me.Form_KeyDown()

        WRITE_CHK = ""
        Call DATA_INIT()
        Call FORM_INIT()

        CHK(1) = "1"
        CHK(2) = "1"
        CHK(3) = "1"
        CHK(4) = "2"

        'Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        Select Case wJOB

            Case 3
                Me.Text = Me.Text & " - UPDATE"

                txt_MaterialCode.Enabled = False
                txt_MaterialName.Enabled = True

                txt_MaterialName.TextEnabled = True

                Call DATA_SEARCH01()

                If CHK(3) <> "1" Then
                    If CHK(2) <> "1" Then
                        isudCHK = False
                        Me.Dispose()
                        formA = True
                        Call MsgBoxP("4", "Form_Activate")
                        Exit Sub
                    Else

                        Me.Text = Me.Text & " - SEARCH"
                        isudCHK = False
                        formA = True
                        wJOB = 2
                        Call MsgBoxP("Only Search !") : tst_iSave.Visible = False
                    End If
                End If


        End Select

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Call D7231_CLEAR()

        W7231 = D7231

        KEY_CHK = ""
        tst_iClose.Enabled = True
        tst_iSave.Enabled = True
        tst_iClose.Visible = True
        tst_iSave.Visible = True

        tst_iDelete.Visible = False
        tst_iUtilities.Visible = False
        tst_iAttach.Visible = False
        tst_iHistory.Visible = False

    End Sub

    Private Sub FORM_INIT()


    End Sub

#End Region

#Region "Function"
    Private Function Data_Check() As Boolean
        Data_Check = False

        If FormatCut(txt_MaterialName.Data) = "" Then MsgBoxP("Material Name,pls") : Setfocus(txt_MaterialSimple) : Exit Function

        Return DataCheck(Me, "PFK7231")
    End Function
    Private Sub DATA_MOVE()
        W7231.MaterialCode = txt_MaterialCode.Data

    End Sub

    Private Sub DATA_UPDATE()

        If txt_Check9.Data = "1" Then

            If READ_PFK7231(txt_MaterialCode.Data) = True Then
                W7231 = D7231
                W7231.MaterialSimple = txt_MaterialSimple.Data
                W7231.Check9 = "1"
                isudCHK = True
                Call REWRITE_PFK7231(W7231)
            End If

        Else
            If READ_PFK7231(txt_MaterialCode.Data) = True Then
                W7231 = D7231
                W7231.MaterialSimple = ""
                W7231.Check9 = ""
                isudCHK = True
                Call REWRITE_PFK7231(W7231)
            End If

        End If
        Me.Dispose()

    End Sub

#End Region

#Region "DATA_SEARCH"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False

        DS1 = READ_PFK7231(L7231.MaterialCode, cn)

        If GetDsRc(DS1) = 0 Then
            Exit Function
            isudCHK = False
        End If

        READER_MOVE(Me, DS1)

        StoreFormat_New(Me)

        txt_MaterialName.Data = GetDsData(DS1, 0, "K7231_MaterialName") + " " + GetDsData(DS1, 0, "K7231_MaterialPName")
        txt_MaterialName.Data = Trim(txt_MaterialName.Data)
        Setfocus(txt_MaterialSimple)

        DATA_SEARCH01 = True

    End Function

#End Region

#Region "Event"
    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        Dim i As Integer

        Select Case wJOB
            Case 1

            Case 2 : Me.Dispose()
            Case 3
                If Data_Check() = False Then Exit Sub
                Call DATA_UPDATE()
                Me.Dispose()


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


#End Region

End Class