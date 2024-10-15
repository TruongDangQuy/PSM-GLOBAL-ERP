Public Class ISUD7411A

#Region "Variable"
    'Private wJOB As Integer

    Private W7411 As T7411_AREA
    Private L7411 As T7411_AREA

    Private WRITE_CHK As String
    Private KEY_CHK As String

    Private forma As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7411A(job As Integer, IDNO As String, Optional ByVal TAG As String = "") As Boolean
        forma = False
        Me.Tag = TAG
        D7411.IDNO = IDNO

        wJOB = job : L7411 = D7411

        Link_ISUD7411A = False

        Select Case job
            Case 1

            Case Else
                If READ_PFK7411(L7411.IDNO) = False Then
                    Call MsgBoxP("3", "LINK_ISUD")

                    Exit Function
                End If
        End Select

        Me.ShowDialog()

        Link_ISUD7411A = isudCHK

    End Function
#End Region

#Region "Form_Load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        If forma = True Then Exit Sub
        Me.Form_Initial()
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
                    forma = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                tst_iDelete.Visible = False

                Call KEY_COUNT()

                Setfocus(txt_Name)
            Case 2
                Me.Text = Me.Text & " - SEARCH"

                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    forma = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Block1.Enabled = False

                tst_iDelete.Visible = False
                tst_iClose.Visible = True
                tst_iSave.Visible = False

                Call DATA_SEARCH01()

            Case 3
                Me.Text = Me.Text & " - UPDATE"

                If CHK(3) <> "1" Then
                    isudCHK = False
                    forma = True
                    Me.Dispose()
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                tst_iDelete.Visible = False
                txt_IDNO.Enabled = False

                Call DATA_SEARCH01()

            Case 4
                Me.Text = Me.Text & " - DELETE"

                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    forma = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Block1.Enabled = False

                tst_iDelete.Visible = True
                tst_iSave.Visible = False

                Call DATA_SEARCH01()
        End Select
        forma = True
    End Sub

    Private Sub DATA_INIT()
        Call D7411_CLEAR()
        W7411 = D7411

        WRITE_CHK = ""
        KEY_CHK = ""
    End Sub

    Private Sub FORM_INIT()

    End Sub
#End Region

#Region "DATA_SEARCH"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False

        DS1 = READ_PFK7411(L7411.IDNO, cn)
        If GetDsRc(DS1) = 0 Then
            Exit Function : Me.Dispose()
            isudCHK = False
        End If


        READER_MOVE(Me, DS1)

        If GetDsData(DS1, 0, "K7411_CheckUse") = "1" Then rad_CheckUse1.Checked = True
        If GetDsData(DS1, 0, "K7411_CheckUse") = "2" Then rad_CheckUse2.Checked = True

        txt_cdNationality.Code = txt_cdNationality.Code
        DATA_SEARCH01 = True

    End Function
#End Region

#Region "Function"
    Private Function Data_Check() As Boolean
        Data_Check = False
        If Trim$(txt_Name.Data) = "" Then txt_Name.Code = "" : MsgBoxP("Name Card") : Exit Function
        If Trim$(txt_cdNationality.Data) = "" Then txt_cdNationality.Code = ""
        If Trim$(txt_cdSite.Data) = "" Then txt_cdSite.Code = ""
        If Trim$(txt_cdOnePosition.Data) = "" Then txt_cdOnePosition.Code = ""
        If Trim$(txt_cdDepartment.Data) = "" Then txt_cdDepartment.Code = ""
        If Trim$(txt_cdInCharge.Data) = "" Then txt_cdInCharge.Code = ""
        If Trim$(txt_cdPosition.Data) = "" Then txt_cdPosition.Code = ""

        If Trim$(txt_cdMainProcess.Data) = "" Then txt_cdMainProcess.Code = ""
        If Trim$(txt_cdSubProcess.Data) = "" Then txt_cdSubProcess.Code = ""

        If Trim$(txt_IDCard.Data) = "" Then txt_IDCard.Code = ""
        If Trim$(txt_IDHRCode.Data) = "" Then txt_IDHRCode.Code = "" : MsgBoxP("No ID Card") : Exit Function

        If IsDBNull(txt_Name.Data) = True Then
            Call MsgBoxP("34", "DATA_CHECK")
            Data_Check = False
            Setfocus(txt_Name)
        End If

        If txt_IDNO.Data = "" Then
            Call MsgBoxP("34", "DATA_CHECK")
            Data_Check = False
            Setfocus(txt_IDNO)
            Exit Function
        End If
        Data_Check = True
    End Function

    Private Sub DATA_MOVE()
        W7411.IDNO = L7411.IDNO
        W7411.Name = txt_Name.Data
        W7411.ForeignName = txt_ForeignName.Data

        W7411.IDCard = txt_IDCard.Data
        W7411.IDHRCode = txt_IDHRCode.Data

        W7411.cdNationality = txt_cdNationality.Code
        W7411.cdSite = txt_cdSite.Code
        W7411.cdOnePosition = txt_cdOnePosition.Code
        W7411.cdNationality = txt_cdNationality.Code
        W7411.cdPosition = txt_cdPosition.Code
        W7411.cdInCharge = txt_cdInCharge.Code
        W7411.cdDepartment = txt_cdDepartment.Code
        W7411.cdMainProcess = txt_cdMainProcess.Code
        W7411.cdSubProcess = txt_cdSubProcess.Code
        W7411.cdFactory = txt_cdFactory.Code
        W7411.cdLineProd = txt_cdLineProd.Code

        W7411.seMainProcess = ListCode("MainProcess")
        W7411.seSubProcess = ListCode("SubProcess")

        W7411.seFactory = ListCode("Factory")
        W7411.seLineProd = ListCode("LineProd")


        W7411.seSite = ListCode("Site")

        W7411.seOnePosition = ListCode("OnePosition")
        W7411.seNationality = ListCode("Nationality")
        W7411.sePosition = ListCode("Position")
        W7411.seInCharge = ListCode("InCharge")
        W7411.seDepartment = ListCode("Department")

        If rad_CheckUse1.Checked = True Then W7411.CheckUse = 1
        If rad_CheckUse2.Checked = True Then W7411.CheckUse = 2

        If FormatCut(W7411.DevelopmenetCode) = "" Then W7411.DevelopmenetCode = W7411.IDNO
        If FormatCut(W7411.UserID) = "" Then W7411.UserID = W7411.IDNO
    End Sub

    Private Sub DATA_MOVE_UPDATE()
        W7411.IDNO = L7411.IDNO

        Call DATA_MOVE()

        W7411.cdMainProcess = txt_cdMainProcess.Code
        W7411.cdSubProcess = txt_cdSubProcess.Code
        W7411.cdFactory = txt_cdFactory.Code
        W7411.cdLineProd = txt_cdLineProd.Code

        W7411.seMainProcess = ListCode("MainProcess")
        W7411.seSubProcess = ListCode("SubProcess")

        W7411.seFactory = ListCode("Factory")
        W7411.seLineProd = ListCode("LineProd")


        W7411.seSite = ListCode("Site")

        W7411.seOnePosition = ListCode("OnePosition")
        W7411.seNationality = ListCode("Nationality")
        W7411.sePosition = ListCode("Position")
        W7411.seInCharge = ListCode("InCharge")
        W7411.seDepartment = ListCode("Department")

        If rad_CheckUse1.Checked = True Then W7411.CheckUse = 1
        If rad_CheckUse2.Checked = True Then W7411.CheckUse = 2
    End Sub

    Private Sub DATA_INSERT()


        Call KEY_COUNT()
        Call DATA_MOVE()
        W7411.DateInsert = Pub.DAT
        W7411.InchargeInsert = Pub.SAW
        If WRITE_PFK7411(W7411) = True Then isudCHK = True : WRITE_CHK = "*"

    End Sub

    Private Sub DATA_UPDATE()

        Call DATA_MOVE_UPDATE()

        W7411.DateUpdate = Pub.DAT
        W7411.InchargeUpdate = Pub.SAW
        If REWRITE_PFK7411(W7411) = True Then isudCHK = True

        Me.Dispose()
    End Sub

    Private Sub DATA_DELETE()
        DATA_MOVE()
        If DELETE_PFK7411(W7411) = True Then isudCHK = True

        Call Delete_History("PFK7411", W7411.IDNO)

        Me.Dispose()

    End Sub

    Private Sub KEY_COUNT()
        Try
            SQL = "SELECT MAX(K7411_IDNO) AS MAX_CODE FROM PFK7411 WHERE ISNUMERIC(K7411_IDNO) > 0 AND K7411_IDNO < 90000000  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If IsDBNull(rd!MAX_CODE) = True Then
                L7411.IDNO = "00000001"
            Else
                L7411.IDNO = Format(CInt(rd!MAX_CODE + 1), "00000000")
            End If

            W7411.IDNO = L7411.IDNO
            txt_IDNO.Data = L7411.IDNO
            rd.Close()
        Catch ex As Exception
            MsgBoxP("KeyCount")
        Finally
            If rd IsNot Nothing Then
                If rd.IsClosed = False Then
                    rd.Close()
                End If
            End If
        End Try

    End Sub
#End Region

#Region "Events"

    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        'If wJOB = 1 Then wJOB = 3

        Select Case wJOB
            Case 1
                If Data_Check() = False Then Exit Sub
                Call DATA_INSERT()
                txt_IDNO.Data = ""
                txt_ForeignName.Data = ""
                txt_Name.Data = ""
                Setfocus(txt_Name)
                Call DATA_INIT()
                Call KEY_COUNT()
            Case 2 : Me.Dispose()
            Case 3
                If Data_Check() = False Then Exit Sub
                Call DATA_UPDATE()
            Case 4 : Call DATA_DELETE()
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

        Select Case MsgBoxP("Do you want to delete ?", vbYesNo)
            Case vbYes
            Case vbNo : Exit Sub
        End Select
        Call DATA_DELETE()

    End Sub
#End Region

End Class