Public Class ISUD7121A

#Region "Variable"
    Private wJOB As Integer

    Private WRITE_CHK As String
    Private KEY_CHK As String

    Private W7121 As T7121_AREA
    Private L7121 As T7121_AREA

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7121A(job As Integer, ColorCode As String, Optional ByVal TAG As String = "") As Boolean
      
        D7121.ColorCode = ColorCode

        wJOB = job : L7121 = D7121

        Link_ISUD7121A = False

        Select Case job
            Case 1
            Case Else
                If READ_PFK7121(L7121.ColorCode) = False Then
                    Call MsgBoxP("3", "LINK_ISUD")

                    Exit Function
                End If
        End Select


        formA = False
        Me.Tag = TAG
        Me.ShowDialog()

        Link_ISUD7121A = isudCHK

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

                tst_iDelete.Visible = False

                Call KEY_COUNT()

                Setfocus(txt_CustomerCode)

            Case 2
                Me.Text = Me.Text & " - SEARCH"
                If CHK(2) <> "1" Then
                    isudCHK = False
                    formA = True
                    Me.Dispose()

                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                txt_ColorCode.Enabled = False
                txt_CustomerCode.Enabled = False

                Bloack2.Enabled = False

                tst_iDelete.Visible = False
                tst_iSave.Visible = False

                Call DATA_SEARCH()

            Case 3
                Me.Text = Me.Text & " - UPDATE"
                If CHK(3) <> "1" Then
                    isudCHK = False
                    formA = True
                    Me.Dispose()

                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                txt_ColorCode.Enabled = False
                txt_CustomerCode.Enabled = False

                Bloack2.Enabled = True

                tst_iDelete.Visible = False

                If Pub.DEVCHK <> "1" Then tst_iDelete.Visible = False

                Call DATA_SEARCH()

            Case 4
                Me.Text = Me.Text & " - DELETE"
                If CHK(4) <> "1" Then
                    isudCHK = False
                    formA = True
                    Me.Dispose()

                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                txt_ColorCode.Enabled = False
                txt_CustomerCode.Enabled = False

                Bloack2.Enabled = False

                tst_iDelete.Visible = True
                tst_iSave.Visible = False

                Call DATA_SEARCH()
        End Select

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Call D7121_CLEAR()

        W7121 = D7121

        KEY_CHK = ""

        txt_ColorNameSimple.Data = ""
        txt_ColorName.Data = ""
        txt_ColorPosition.PeaceTextbox1.BackColor = Color.Empty
    End Sub
    Private Sub FORM_INIT()
        txt_ColorCode.Enabled = False
    End Sub
#End Region

#Region "Function"
    Private Function Data_Check() As Boolean
        Return DataCheck(Me, "PFK7121")
    End Function
    Private Sub DATA_MOVE()
        Call K7121_MOVE(Me, W7121, 1, L7121.ColorCode)

        W7121.ColorNameS1 = txt_ColorNameS1.Data
        W7121.ColorNameS2 = txt_ColorNameS2.Data

        W7121.seColorBase = ListCode("ColorBase")
        W7121.seColorCategory = ListCode("ColorCategory")

        If rad_CheckUse1.Checked = True Then W7121.CheckUse = "1" Else W7121.CheckUse = "2"
        If rad_CheckBase2.Checked = True Then W7121.CheckBase = "1" Else W7121.CheckBase = "2"

        W7121.ColorPosition = txt_ColorPosition.Data
    End Sub

    Private Sub DATA_INSERT()
        Call DATA_MOVE()

        W7121.DateInsert = Pub.DAT
        W7121.InchargeInsert = Pub.SAW

        If WRITE_PFK7121(W7121) = True Then isudCHK = True : WRITE_CHK = "*"

    End Sub
    Private Sub DATA_UPDATE()

        Call DATA_MOVE()

        W7121.DateUpdate = Pub.DAT
        W7121.InchargeUpdate = Pub.SAW

        W7121.ColorCode = L7121.ColorCode
        If REWRITE_PFK7121(W7121) = True Then isudCHK = True

        Me.Dispose()

    End Sub
    Private Sub DATA_DELETE()
        Dim str As String = MsgBoxP("Do you want to delete ?", vbYesNo)
        If str <> vbYes Then Exit Sub
        DATA_MOVE()
        If DELETE_PFK7121(W7121) = True Then isudCHK = True
        Me.Dispose()
    End Sub
    Private Sub KEY_COUNT()
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        If KEY_CHK = "*" Then Exit Sub

        SQL = "SELECT MAX(CAST(K7121_ColorCode AS DECIMAL)) AS MAX_CODE FROM PFK7121 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            L7121.ColorCode = "000001"
        Else
            L7121.ColorCode = Format(CIntp(rd!MAX_CODE + 1), "000000")
        End If

        W7121.ColorCode = L7121.ColorCode

        rd.Close()

        txt_ColorCode.Data = W7121.ColorCode
    End Sub


#End Region

#Region "DATA_SEARCH"
    Private Function DATA_SEARCH() As Boolean

        DATA_SEARCH = False

        DS1 = READ_PFK7121(L7121.ColorCode, cn)

        If GetDsRc(DS1) = 0 Then
            Exit Function
            isudCHK = False
        End If

        READER_MOVE(Me, DS1)

        If GetDsData(DS1, 0, "CheckUse") = "1" Then rad_CheckUse1.Checked = True
        If GetDsData(DS1, 0, "CheckUse") = "2" Then rad_CheckUse2.Checked = True

        If GetDsData(DS1, 0, "CheckBase") = "1" Then rad_CheckBase1.Checked = True
        If GetDsData(DS1, 0, "CheckBase") = "2" Then rad_CheckBase2.Checked = True


        txt_ColorPosition.Data = txt_ColorPosition.Code
        Try
            Dim R, G, B As String
            R = Split(txt_ColorPosition.Data, ";")(0)
            G = Split(txt_ColorPosition.Data, ";")(2)
            B = Split(txt_ColorPosition.Data, ";")(1)

            txt_ColorPosition.PeaceTextbox1.BackColor = Color.FromArgb(R, G, B)
        Catch ex As Exception

        End Try

        DATA_SEARCH = True

    End Function

#End Region

#Region "Event"
    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click

        Select Case wJOB
            Case 1
                If Data_Check() = False Then Exit Sub
                Call DATA_INSERT()

                Call DATA_INIT()
                Call KEY_COUNT()
                Setfocus(txt_ColorName)

            Case 2 : Me.Dispose()

            Case 3
                If Data_Check() = False Then Exit Sub
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
        rd = PrcDR("USP_ALL_CHECKDATA_PRIMARYKEY_1KEY", cn, "PFK7121", "ColorCode", L7121.ColorCode)

        If rd.HasRows = False Then rd.Close() : Exit Sub
        rd.Read()
        Try


            If rd("CHECKVALUE") <> "0" Then
                MsgBoxP("Can not delete becase of Item " & rd("STRVALUE1"))
                rd.Close()
                Exit Sub
            End If
            rd.Close()

            If CHK(4) <> "1" Then
                Call MsgBoxP("4", "tst_iDelete_Click")
                Exit Sub
            End If
            Call DATA_DELETE()
            Me.Dispose()
        Catch ex As Exception
            MsgBoxP("Can not delete becase of Item " & rd("STRVALUE1"))
            rd.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub txt_ColorPosition_Load(sender As Object, e As EventArgs) Handles txt_ColorPosition.btnTitleClick
        If ColorDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt_ColorPosition.Data = ColorDialog.Color.R.ToString & ";" & ColorDialog.Color.B.ToString & ";" & ColorDialog.Color.G.ToString
            txt_ColorPosition.PeaceTextbox1.BackColor = ColorDialog.Color
        End If
    End Sub

    Private Sub txt_ColorPosition_txtTextKeyDown(sender As Object, e As KeyEventArgs) Handles txt_ColorPosition.txtTextKeyDown
        If e.KeyCode = Keys.Enter Then
            If ColorDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                txt_ColorPosition.Data = ColorDialog.Color.R.ToString & ";" & ColorDialog.Color.B.ToString & ";" & ColorDialog.Color.G.ToString
                txt_ColorPosition.PeaceTextbox1.BackColor = ColorDialog.Color
            End If
        End If
    End Sub

#End Region

End Class