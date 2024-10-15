Public Class ISUD7103A

#Region "Variable"
    Private wJOB As Integer

    Private WRITE_CHK As String
    Private KEY_CHK As String

    Private W7103 As T7103_AREA
    Private L7103 As T7103_AREA

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7103A(job As Integer, Autokey As String, cdTypeCode As String, TypeCode As String, Optional ByVal TAG As String = "") As Boolean
        D7103.cdTypeCode = cdTypeCode
        D7103.TypeCode = TypeCode
        D7103.Autokey = Autokey

        wJOB = job : L7103 = D7103

        Link_ISUD7103A = False

        Select Case job
            Case 1
            Case Else
                'If READ_PFK7103(L7103.TypeCode) = False Then
                '    Call MsgBoxP("3", "LINK_ISUD")

                '    Exit Function
                'End If
        End Select


        If READ_PFK7171(ListCode("TypeCode"), cdTypeCode) Then
            txt_cdTypeCode.Data = D7171.BasicName
            txt_cdTypeCode.Code = D7171.BasicCode
        End If

        formA = False
        Me.Tag = TAG
        Me.ShowDialog()

        Link_ISUD7103A = isudCHK

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
                tst_iDelete.Visible = False

                Call KEY_COUNT()

                Setfocus(txt_TypeName)
            Case 2
                Me.Text = Me.Text & " - SEARCH"
                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                tst_iDelete.Visible = False
                tst_iSave.Visible = False

                Call DATA_SEARCH()

            Case 3
                Me.Text = Me.Text & " - UPDATE"

                If CHK(3) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                tst_iSave.Visible = True
                tst_iDelete.Visible = False

                Call DATA_SEARCH()

            Case 4
                Me.Text = Me.Text & " - DELETE"
                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                tst_iDelete.Visible = True
                tst_iSave.Visible = False

                Call DATA_SEARCH()

        End Select

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Call D7103_CLEAR()

        W7103 = D7103

        KEY_CHK = ""

        txt_TypeSimpleName.Data = ""
        txt_TypeName.Data = ""
    End Sub
    Private Sub FORM_INIT()
        txt_TypeCode.Enabled = False

        tst_iUtilities.Visible = True
        tst_iAttach.Visible = True
        tst_iHistory.Visible = False
    End Sub
#End Region

#Region "Function"
    Private Function Data_Check() As Boolean
        Data_Check = False
        If READ_PFK7103_TYPENAME("003", txt_TypeName.Data) = True Then MsgBoxP("Already Name!") : Exit Function
        Return DataCheck(Me, "PFK7103")
    End Function
    Private Sub DATA_MOVE()
        Call K7103_MOVE(Me, W7103, 1, L7103.Autokey)

        W7103.seTypeCode = ListCode("TypeCode")
        W7103.seComponentType = ListCode("ComponentType")
    End Sub

    Private Sub DATA_INSERT()
        Call DATA_MOVE()
        W7103.DateInsert = Pub.DAT
        W7103.InchargeInsert = Pub.SAW
        If WRITE_PFK7103(W7103) = True Then isudCHK = True : WRITE_CHK = "*"

    End Sub
    Private Sub DATA_UPDATE()

        Call DATA_MOVE()
        W7103.DateUpdate = Pub.DAT
        W7103.InchargeUpdate = Pub.SAW
        W7103.Autokey = L7103.Autokey
        If REWRITE_PFK7103(W7103) = True Then isudCHK = True

        Me.Dispose()

    End Sub
    Private Sub DATA_DELETE()
        Dim str As String = MsgBoxP("Do you want to delete ?", vbYesNo)
        If str <> vbYes Then Exit Sub
        DATA_MOVE()
        If DELETE_PFK7103(W7103) = True Then isudCHK = True
        Me.Dispose()
    End Sub
    Private Sub KEY_COUNT()
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        If KEY_CHK = "*" Then Exit Sub

        SQL = "SELECT MAX(CAST(K7103_TypeCode AS DECIMAL)) AS MAX_CODE FROM PFK7103 "
        SQL = SQL + " WHERE K7103_cdTypeCode = '" + txt_cdTypeCode.Code + "'"

        'If txt_cdTypeCode.Code = "003" Then SQL = SQL + " AND K7103_cdComponentType = '" + txt_cdComponentType.Code + "'"

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            L7103.TypeCode = "000001"
        Else
            L7103.TypeCode = Format(CIntp(rd!MAX_CODE + 1), "000000")
        End If

        W7103.TypeCode = L7103.TypeCode

        rd.Close()

        txt_TypeCode.Data = W7103.TypeCode
    End Sub


#End Region

#Region "DATA_SEARCH"
    Private Function DATA_SEARCH() As Boolean

        DATA_SEARCH = False

        DS1 = READ_PFK7103(L7103.Autokey, cn)

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
                Setfocus(txt_TypeName)

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

        If CHK(4) <> "1" Then
            Call MsgBoxP("4", "tst_iDelete_Click")
            Exit Sub
        End If

        Call DATA_DELETE()
        Me.Dispose()
    End Sub
#End Region

    
End Class