Public Class ISUD7213A

#Region "Variable"
    Private wJOB As Integer

    Private WRITE_CHK As String
    Private KEY_CHK As String

    Private W7213 As T7213_AREA
    Private L7213 As T7213_AREA
    Private D7213 As T7213_AREA

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7213A(job As Integer, CartonCode As String, Optional ByVal TAG As String = "") As Boolean

        D7213.CartonCode = CartonCode

        wJOB = job : L7213 = D7213

        Link_ISUD7213A = False

        Select Case job
            Case 1
            Case Else

        End Select


        formA = False
        Me.Tag = TAG
        Me.ShowDialog()

        Link_ISUD7213A = isudCHK

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

                Call KEY_COUNT()

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                tst_iDelete.Visible = False

            Case 2
                Me.Text = Me.Text & " - SEARCH"

                tst_iDelete.Visible = False

                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH()

            Case 3
                Me.Text = Me.Text & " - UPDATE"

                If Pub.DEVCHK <> "1" Then tst_iDelete.Visible = False

                Call DATA_SEARCH()

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
                        tst_iDelete.Visible = False
                        Call MsgBoxP("Only Search !") : tst_iSave.Visible = False
                    End If
                End If

                tst_iSave.Visible = True
                tst_iDelete.Visible = False

            Case 4
                Me.Text = Me.Text & " - DELETE"

                tst_iDelete.Visible = True
                tst_iSave.Visible = False

                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH()

        End Select

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Call D7213_CLEAR()

        W7213 = D7213

        KEY_CHK = ""

        txt_Article.Data = ""
        txt_CartonCode.Data = ""
        txt_CartonCode.Code = ""

    End Sub
    Private Sub FORM_INIT()
        txt_CartonCode.Enabled = False

        tst_iPrint.Visible = False
        tst_iPrint_Print.Visible = False

        tst_iUtilities.Visible = True
        tst_iAttach.Visible = True
        tst_iHistory.Visible = False
    End Sub
#End Region

#Region "Function"
    Private Function Data_Check() As Boolean
        Data_Check = False

        Return DataCheck(Me, "PFK7213")
    End Function
    Private Sub DATA_MOVE()

        Call K7213_MOVE(Me, W7213, 1, L7213.CartonCode)

    End Sub

    Private Sub DATA_INSERT()
        Call DATA_MOVE()

        If WRITE_PFK7213(W7213) = True Then isudCHK = True : WRITE_CHK = "*"

    End Sub
    Private Sub DATA_UPDATE()

        Call DATA_MOVE()

        If REWRITE_PFK7213(W7213) = True Then isudCHK = True

        Me.Dispose()

    End Sub
    Private Sub DATA_DELETE()
        Dim str As String = MsgBoxP("Do you want to delete ?", vbYesNo)
        If str <> vbYes Then Exit Sub
        DATA_MOVE()
        If DELETE_PFK7213(W7213) = True Then isudCHK = True
        Me.Dispose()
    End Sub
    Private Sub KEY_COUNT()
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        If KEY_CHK = "*" Then Exit Sub

        SQL = "SELECT MAX(CAST(K7213_CartonCode AS DECIMAL)) AS MAX_CODE FROM PFK7213 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            L7213.CartonCode = "000001"
        Else
            L7213.CartonCode = Format(CIntp(rd!MAX_CODE + 1), "000000")
        End If

        W7213.CartonCode = L7213.CartonCode

        rd.Close()

        txt_CartonCode.Data = W7213.CartonCode
    End Sub


#End Region

#Region "DATA_SEARCH"
    Private Function DATA_SEARCH() As Boolean

        DATA_SEARCH = False

        DS1 = READ_PFK7213(L7213.CartonCode, cn)

        If GetDsRc(DS1) = 0 Then
            Exit Function
            isudCHK = False
        End If

        READER_MOVE(Me, DS1)

        DATA_SEARCH = True

    End Function

#End Region

#Region "Event"
    Private Sub tst_iSave_Click(sender As Object, e As EventArgs)

        Select Case wJOB
            Case 1
                If Data_Check() = False Then Exit Sub

                Call KEY_COUNT()
                Call DATA_INSERT()

                Call DATA_INIT()
                Call KEY_COUNT()

            Case 2 : Me.Dispose()

            Case 3
                If Data_Check() = False Then Exit Sub
                Call DATA_UPDATE()

            Case 4
                Call DATA_DELETE()

        End Select

    End Sub
    Private Sub tst_iClose_Click(sender As Object, e As EventArgs)
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
#End Region


End Class