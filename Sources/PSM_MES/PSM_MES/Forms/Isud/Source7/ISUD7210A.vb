Public Class ISUD7210A

#Region "Variable"
    Private wJOB As Integer

    Private WRITE_CHK As String
    Private KEY_CHK As String

    Private W7210 As T7210_AREA
    Private L7210 As T7210_AREA

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7210A(job As Integer, CartonCode As String, Optional ByVal TAG As String = "") As Boolean
        D7210.CartonCode = CartonCode

        wJOB = job : L7210 = D7210

        Link_ISUD7210A = False

        Select Case job
            Case 1
            Case Else
            
        End Select


        formA = False
        Me.Tag = TAG
        Me.ShowDialog()

        Link_ISUD7210A = isudCHK

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
                Setfocus(txt_CartonType)
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
        Call D7210_CLEAR()

        W7210 = D7210

        KEY_CHK = ""

        txt_CartonType.Data = ""
        txt_CTHeight.Data = ""
        txt_CTLength.Data = ""
        txt_CTNetWeight.Data = ""

        txt_CTWidth.Data = ""
        txt_CBM.Data = ""
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

        If txt_CustomerCode.Code = "" Then MsgBoxP("Customer Pls!") : Setfocus(txt_CustomerCode) : Exit Function
        If IsNumeric(txt_CTHeight.Data) = False Then MsgBoxP("Height Pls!") : Setfocus(txt_CTHeight) : Exit Function
        If IsNumeric(txt_CTLength.Data) = False Then MsgBoxP("Length Pls!") : Setfocus(txt_CTLength) : Exit Function
        If IsNumeric(txt_CTNetWeight.Data) = False Then MsgBoxP("Weight Pls!") : Setfocus(txt_CTNetWeight) : Exit Function
        If IsNumeric(txt_CTWidth.Data) = False Then MsgBoxP("Width Pls!") : Setfocus(txt_CTWidth) : Exit Function

        Return DataCheck(Me, "PFK7210")
    End Function
    Private Sub DATA_MOVE()
        Call K7210_MOVE(Me, W7210, 1, L7210.CartonCode)

    End Sub

    Private Sub DATA_INSERT()
        Call DATA_MOVE()

        If WRITE_PFK7210(W7210) = True Then isudCHK = True : WRITE_CHK = "*"

    End Sub
    Private Sub DATA_UPDATE()

        Call DATA_MOVE()

        If REWRITE_PFK7210(W7210) = True Then isudCHK = True

        Me.Dispose()

    End Sub
    Private Sub DATA_DELETE()
        Dim str As String = MsgBoxP("Do you want to delete ?", vbYesNo)
        If str <> vbYes Then Exit Sub
        DATA_MOVE()
        If DELETE_PFK7210(W7210) = True Then isudCHK = True
        Me.Dispose()
    End Sub
    Private Sub KEY_COUNT()
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        If KEY_CHK = "*" Then Exit Sub

        SQL = "SELECT MAX(CAST(K7210_CartonCode AS DECIMAL)) AS MAX_CODE FROM PFK7210 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            L7210.CartonCode = "000001"
        Else
            L7210.CartonCode = Format(CIntp(rd!MAX_CODE + 1), "000000")
        End If

        W7210.CartonCode = L7210.CartonCode

        rd.Close()

        txt_CartonCode.Data = W7210.CartonCode
    End Sub


#End Region

#Region "DATA_SEARCH"
    Private Function DATA_SEARCH() As Boolean

        DATA_SEARCH = False

        DS1 = READ_PFK7210(L7210.CartonCode, cn)

        If GetDsRc(DS1) = 0 Then
            Exit Function
            isudCHK = False
        End If

        READER_MOVE(Me, DS1)

        If GetDsData(DS1, 0, "CheckUse") = "1" Then rad_CheckUse1.Checked = True
        If GetDsData(DS1, 0, "CheckUse") = "2" Then rad_CheckUse2.Checked = True

        DATA_SEARCH = True

    End Function

#End Region

#Region "Event"
    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click

        Select Case wJOB
            Case 1
                If Data_Check() = False Then Exit Sub

                Call KEY_COUNT()
                Call DATA_INSERT()

                Call DATA_INIT()
                Call KEY_COUNT()
                Call PrcExeNoError("USP_ISUD7210A_WEIGHTCAL", cn, txt_CartonCode.Data)
                Setfocus(txt_CartonType)

            Case 2 : Me.Dispose()

            Case 3
                If Data_Check() = False Then Exit Sub
                Call DATA_UPDATE()
                Call PrcExeNoError("USP_ISUD7210A_WEIGHTCAL", cn, txt_CartonCode.Data)

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

        Call DATA_DELETE()
        Me.Dispose()
    End Sub

    Private Sub txt_CTHeight_txtTextChanged(sender As Object, e As EventArgs) Handles txt_CTHeight.txtTextChanged, txt_CTLength.txtTextChanged, txt_CTWidth.txtTextChanged
        Try
            If IsNumeric(txt_CTHeight.Data) = False Then Exit Sub
            If IsNumeric(txt_CTLength.Data) = False Then Exit Sub
            If IsNumeric(txt_CTWidth.Data) = False Then Exit Sub

            txt_CBM.Data = CDecp(txt_CTHeight.Data) / 1000 * CDecp(txt_CTLength.Data) / 1000 * CDecp(txt_CTWidth.Data) / 1000 * 1.02
            txt_CBM.Data = FormatNumber(txt_CBM.Data, 6)

        Catch ex As Exception

        End Try
    End Sub
#End Region

End Class