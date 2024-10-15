Public Class ISUD2354B

#Region "Variable"
    Private wJOB As Integer

    Private W2351 As New T2351_AREA
    Private L2351 As New T2351_AREA

    Private W2352 As New T2352_AREA
    Private L2352 As New T2352_AREA

    Private WRITE_CHK As String
    Public gpp As Graphics
    Public twtopi As Decimal = 39.5

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Form"


    Public Function Link_ISUD2354B(job As Integer, MaterialInBoundNo As String, MaterialInBoundSeq As String, MaterialInBoundSno As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D2352.MaterialInBoundNo = MaterialInBoundNo
        D2352.MaterialInBoundSeq = MaterialInBoundSeq
        D2352.MaterialInBoundSno = MaterialInBoundSno

        D2351.MaterialInBoundNo = MaterialInBoundNo
        D2351.MaterialInBoundSeq = MaterialInBoundSeq

        wJOB = job : L2351 = D2351 : L2352 = D2352

        txt_Barcode.Data = MaterialInBoundNo

        Link_ISUD2354B = False
        Try

            Select Case job
                Case 1
                Case Else

            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD2354B = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))
        End Try


    End Function

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
            Case 2
                Me.Text = Me.Text & " - SEARCH"

                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If
                Call DATA_SEARCH_HEAD()

                Frame1.Enabled = True
                tst_iDelete.Visible = False
                tst_iSave.Visible = False
            Case 3
                Me.Text = Me.Text & " - UPDATE"


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

                Call DATA_SEARCH_HEAD()

                tst_iDelete.Visible = False

            Case 4
                Me.Text = Me.Text & " - DELETE"

                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If
                Call DATA_SEARCH_HEAD()

                tst_iDelete.Visible = True
                tst_iSave.Visible = False

        End Select

        formA = True
    End Sub

#End Region

#Region "Search"

    Private Function DATA_SEARCH_HEAD() As Boolean
        DATA_SEARCH_HEAD = False
        Try


            DS1 = PrcDS("USP_ISUD2352A_SEARCH_HEAD", cn, L2352.MaterialInBoundNo, L2352.MaterialInBoundSeq, L2352.MaterialInBoundSno)

            If GetDsRc(DS1) = 0 Then
                Exit Function

            End If

            STORE_MOVE(Me, DS1)

            txt_CntInbound.Data = GetDsData(DS1, 0, "CntInbound")
            txt_CntQC.Data = GetDsData(DS1, 0, "CntQC")

            DATA_SEARCH_HEAD = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH01")
        End Try

    End Function


    Private Sub Calculation()

    End Sub


#End Region

#Region "Function"


    Private Function DATA_MOVE() As Boolean
        DATA_MOVE = False
        Try
            Dim i As Integer



        Catch ex As Exception
            MsgBoxP("DATA_MOVE!")
        End Try
    End Function

    Private Sub DATA_UPDATE()
        Try



        Catch ex As Exception
            Call MsgBoxP("DATA_UPDATE")
        End Try
    End Sub

    Private Sub DATA_DELETE()
        Dim i As Integer

        Try

            isudCHK = True

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub
    Private Sub DATA_LINE_DELETE(xrow As Integer)
        Try

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_LINE_DELETE")
        End Try

    End Sub

    Private Sub DATA_INIT()
        Try
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Sub FORM_INIT()
        txt_Barcode.Data = ""
        txt_Barcode.TextEnabled = True
        Setfocus(txt_Barcode)

    End Sub




#End Region

#Region "Event"


    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        Select Case wJOB
            Case 1

                If READ_PFK2352(L2352.MaterialInBoundNo, L2352.MaterialInBoundSeq, L2352.MaterialInBoundSno) Then
                    Call PrcExeNoError("USP_ISUD2352A_INSERT_QC1", cn, L2352.MaterialInBoundNo, L2352.MaterialInBoundSeq, L2352.MaterialInBoundSno, txt_cdDefectMaterial.Code, txt_LotGrade.Data)
                    Call MsgBoxP("Update QC Finsihly !", vbInformation)
                    txt_Barcode.Data = ""
                    txt_cdDefectMaterial.Code = ""
                    txt_cdDefectMaterial.Data = ""
                    txt_TimeQC.Data = ""
                    txt_CntInbound.Data = ""
                    txt_CntQC.Data = ""

                    txt_LotGrade.Data = ""

                    L2352.MaterialInBoundNo = ""
                    L2352.MaterialInBoundSeq = ""
                    L2352.MaterialInBoundSno = ""

                    Call DATA_SEARCH_HEAD()

                    txt_Barcode.Select()

                    Application.DoEvents()
                    Me.Show()
                    Setfocus(txt_Barcode.Data)

                End If

            Case 2
                Me.Dispose()
            Case 3

                Call PrcExeNoError("USP_ISUD2352A_INSERT_QC1", cn, L2352.MaterialInBoundNo, L2352.MaterialInBoundSeq, L2352.MaterialInBoundSno, txt_cdDefectMaterial.Code, txt_LotGrade.Data)
                Call MsgBoxP("Update QC Finsihly !", vbInformation)

                txt_Barcode.Data = ""
                txt_cdDefectMaterial.Code = ""
                txt_cdDefectMaterial.Data = ""
                txt_TimeQC.Data = ""
                txt_CntInbound.Data = ""
                txt_CntQC.Data = ""

                txt_LotGrade.Data = ""

                L2352.MaterialInBoundNo = ""
                L2352.MaterialInBoundSeq = ""
                L2352.MaterialInBoundSno = ""

                Call DATA_SEARCH_HEAD()


                txt_Barcode.Select()

                Application.DoEvents()
                Me.Show()
                Setfocus(txt_Barcode.Data)


            Case 4
                If txt_Barcode.Data <> System_Date_8() Then
                    MsgBoxP("Can not edit because of not today!")
                    If MsgBoxPPW("Please type the password to modify!", const_pwGreyInbound) = False Then Exit Sub
                End If
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

        If txt_Barcode.Data <> System_Date_8() Then
            MsgBoxP("Can not edit because of not today!")
            If MsgBoxPPW("Please type the password to modify!", const_pwGreyInbound) = False Then Exit Sub
        End If

        Dim str As String = MsgBoxP("Do you want to delete it?", vbYesNo)

        If str <> vbYes Then Exit Sub

        Call DATA_DELETE()
    End Sub

    Private Sub KEY_COUNT()

    End Sub

    Private Sub txt_GreyFullNo_txtTextKeyDown(sender As Object, e As KeyEventArgs) Handles txt_Barcode.txtTextKeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True

            If txt_Barcode.Data = "" Then Exit Sub

            txt_Barcode.Code = FormatCut(txt_Barcode.Data)

            If Len(txt_Barcode.Code) < 13 Then Exit Sub

            L2352.MaterialInBoundNo = Strings.Left(txt_Barcode.Code, 9)
            L2352.MaterialInBoundSeq = Strings.Mid(txt_Barcode.Code, 10, 3)
            L2352.MaterialInBoundSno = Strings.Mid(txt_Barcode.Code, 13)

         
            If DATA_SEARCH_HEAD() = True Then
                Me.Show()

                Application.DoEvents()
                Setfocus(txt_LotGrade)

            Else
                txt_Barcode.TextEnabled = True
                txt_Barcode.Data = ""
                txt_Barcode.Code = ""

                L2352.MaterialInBoundNo = ""
                L2352.MaterialInBoundSeq = ""
                L2352.MaterialInBoundSno = ""

                Me.Show()
                Application.DoEvents()
                Setfocus(txt_Barcode)
            End If
        End If
    End Sub

    Private Sub rad_CheckQC2_CheckedChanged(sender As Object, e As EventArgs) Handles rad_CheckQC2.CheckedChanged, rad_CheckQC1.CheckedChanged
        If rad_CheckQC1.Checked = True Then
            txt_cdDefectMaterial.Visible = True
        Else
            txt_cdDefectMaterial.Visible = True
        End If

    End Sub

#End Region






End Class