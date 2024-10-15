Public Class ISUD7101C

#Region "Variable"
    'Private wJOB As Integer

    Private WRITE_CHK As String
    Private KEY_CHK As String

    Private W7101 As T7101_AREA
    Private L7101 As T7101_AREA

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7101A(job As Integer, CustomerCode As String, Optional ByVal TAG As String = "") As Boolean

        D7101.CustomerCode = CustomerCode

        wJOB = job : L7101 = D7101

        Link_ISUD7101A = False

        Select Case job
            Case 1

            Case Else
                If READ_PFK7101(L7101.CustomerCode) = False Then
                    Call MsgBoxP("3", "LINK_ISUD")

                    Exit Function
                End If
                'txt_CustomerName.Enabled = False
                'txt_CustomerNameSimply.Enabled = False

        End Select

        formA = False
        Me.Tag = TAG
        Me.ShowDialog()

        Link_ISUD7101A = isudCHK

    End Function

    Public Function Link_ISUD7101A_CHECK(job As Integer, CheckKind As String, CustomerCode As String, Optional ByVal TAG As String = "") As Boolean

        D7101.CustomerCode = CustomerCode

        wJOB = job : L7101 = D7101

        Link_ISUD7101A_CHECK = False

        Select Case job
            Case 1

            Case Else
                If READ_PFK7101(L7101.CustomerCode) = False Then
                    Call MsgBoxP("3", "LINK_ISUD")

                    Exit Function
                End If
                'txt_CustomerName.Enabled = False
                'txt_CustomerNameSimply.Enabled = False

        End Select

        chk_CheckCustomer.Checked = False
        chk_CheckEmployee.Checked = False
        chk_CheckInside.Checked = False
        chk_CheckOthers.Checked = False
        chk_CheckOutside.Checked = False
        chk_CheckSupplier.Checked = False

        chk_CheckCustomer.Enabled = False
        chk_CheckEmployee.Enabled = False
        chk_CheckInside.Enabled = False
        chk_CheckOthers.Enabled = False
        chk_CheckOutside.Enabled = False
        chk_CheckSupplier.Enabled = False

        Select Case CheckKind
            Case "1"
                chk_CheckCustomer.Checked = True
            Case "2"
                chk_CheckSupplier.Checked = True
            Case "3"
                chk_CheckEmployee.Checked = True
            Case "4"
                chk_CheckInside.Checked = True
            Case "5"
                chk_CheckOutside.Checked = True
            Case "6"
                chk_CheckOthers.Checked = True
        End Select
        formA = False
        Me.Tag = TAG
        Me.ShowDialog()

        Link_ISUD7101A_CHECK = isudCHK

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

                Setfocus(txt_CustomerName)
                tst_iDelete.Visible = False

                Call KEY_COUNT()
                Call DATA_SEARCH_vS2()

            Case 2
                Me.Text = Me.Text & " - SEARCH"
                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                frm_Condition.Enabled = True
                tst_iSave.Visible = False
                tst_iDelete.Visible = False

                Call DATA_SEARCH()
                Call DATA_SEARCH_vS2()
            Case 3
                Me.Text = Me.Text & " - UPDATE"
                If CHK(3) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                tst_iDelete.Visible = False

                Call DATA_SEARCH()
                Call DATA_SEARCH_vS2()
            Case 4
                Me.Text = Me.Text & " - DELETE"
                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                frm_Condition.Enabled = True

                tst_iSave.Visible = False
                tst_iDelete.Visible = True

                Call DATA_SEARCH()
                Call DATA_SEARCH_vS2()
            Case 91
                Me.Text = Me.Text & " - Approved"

                If CHK(5) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                tst_iSave.Visible = True
                'tst_iSave2.Visible = True
                tst_iDelete.Visible = False

                'tst_iSave2.Text = "NotApproved"
                tst_iSave.Text = "Pending2"

                Call DATA_SEARCH()
                Call DATA_SEARCH_vS2()

            Case 92
                Me.Text = Me.Text & " - Approved"
                If CHK(5) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                tst_iSave.Visible = True
                'tst_iSave2.Visible = True
                tst_iDelete.Visible = False

                'tst_iSave2.Text = "Pending1"
                tst_iSave.Text = "Approved"

                Call DATA_SEARCH()
                Call DATA_SEARCH_vS2()
        End Select

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Call D7101_CLEAR()

        W7101 = D7101

        KEY_CHK = ""


    End Sub
    Private Sub FORM_INIT()
        txt_CustomerCode.Enabled = False

        tst_iUtilities.Visible = True
        tst_iAttach.Visible = True
        tst_iHistory.Visible = False
    End Sub
#End Region

#Region "Function"
    Private Function Data_Check() As Boolean
        If chk_CheckInside.CheckState = 1 Then
            'If FormatCut(txt_CustomerNameSimply.Data).Length <> 2 Then MsgBoxP("Simple name only 2 Char and use the #MPO ") : Data_Check = False : Exit Function
        End If
        Return DataCheck(Me, "PFK7101")

    End Function
    Private Sub DATA_MOVE()
        Call K7101_MOVE(Me, W7101, 1, L7101.CustomerCode)

        W7101.CheckTax = "1"

        If FormatCut(W7101.DevelopmentCode) = "" Then W7101.DevelopmentCode = W7101.CustomerCode

        If chk_CheckCustomer.CheckState = 1 Then W7101.CheckCustomer = "1"
        If chk_CheckCustomer.CheckState = 0 Then W7101.CheckCustomer = "2"

        If chk_CheckSupplier.CheckState = 1 Then W7101.CheckSupplier = "1"
        If chk_CheckSupplier.CheckState = 0 Then W7101.CheckSupplier = "2"

        If chk_CheckEmployee.CheckState = 1 Then W7101.CheckEmployee = "1"
        If chk_CheckEmployee.CheckState = 0 Then W7101.CheckEmployee = "2"

        If chk_CheckInside.CheckState = 1 Then W7101.CheckInside = "1"
        If chk_CheckInside.CheckState = 0 Then W7101.CheckInside = "2"

        If chk_CheckOutside.CheckState = 1 Then W7101.CheckOutside = "1"
        If chk_CheckOutside.CheckState = 0 Then W7101.CheckOutside = "2"

        If chk_CheckOthers.CheckState = 1 Then W7101.CheckOthers = "1"
        If chk_CheckOthers.CheckState = 0 Then W7101.CheckOthers = "2"

        If rad_CheckUse1.Checked = True Then W7101.CheckUse = "1"
        If rad_CheckUse2.Checked = True Then W7101.CheckUse = "2"

        W7101.seCustomerDivision = ListCode("CustomerDivision")
        W7101.seCustomerLocation = ListCode("CustomerLocation")

        W7101.seSupplierGroup = ListCode("SupplierGroup")
        W7101.seDeliveryTerm = ListCode("DeliveryTerm")

        W7101.seCancelDate = ListCode("CancelDate")

        W7101.sePaymentTerm = ListCode("PaymentTerm")
        W7101.sePaymentCondition = ListCode("PaymentCondition")
        W7101.sePaymentDay = ListCode("PaymentDay")
        W7101.sePaymentTime = ListCode("PaymentTime")

        W7101.sePOGroup = ListCode("POGroup")
        W7101.seSOGroup = ListCode("SOGroup")
        W7101.seSite = ListCode("Site")
        W7101.seTeam = ListCode("Team")

        If wJOB = "1" Then
            W7101.CheckActive = "1"  '1.Standard 2.R&D Upload 
            W7101.CheckCustomerStatus = "1"  '1.Not Approved 2.Complete  3.Approed 4.Cancel 5.Pending1 , 6.pending2.

            W7101.DateActive = Pub.DAT
            W7101.DateInsert = Pub.DAT
        End If

    End Sub

    Private Sub DATA_INSERT()
        Call DATA_MOVE()
        W7101.InchargeInsert = Pub.SAW
        W7101.DateInsert = Pub.DAT
        If READ_PFK7101(W7101.CustomerCode) = True Then
            Call MsgBoxP("5", "DATA_INSERT")

            Call KEY_COUNT()
            Setfocus(txt_CustomerCode)
            Exit Sub
        End If

        If READ_PFK7101_NAME(W7101.CustomerName) = True Then
            Call MsgBoxP("Already Data!")
            txt_CustomerName.Data = ""
            Exit Sub
        End If


        If WRITE_PFK7101(W7101) = True Then isudCHK = True : WRITE_CHK = "*"

    End Sub
    Private Sub DATA_UPDATE()
        Call DATA_MOVE()
        W7101.InchargeUpdate = Pub.SAW
        W7101.DateUpdate = Pub.DAT
        If REWRITE_PFK7101(W7101) = True Then isudCHK = True : WRITE_CHK = "*"

        If ptc_001.SelectedIndex = 1 Then
            Dim i As Integer
            Dim strList As New List(Of String)

            strList.Add(W7101.CustomerCode)

            For i = 0 To vS2.ActiveSheet.RowCount - 1
                strList.Add(getData(vS2, 1, i))

            Next

            For i = 0 To vS2.ActiveSheet.RowCount - 1
                strList.Add(getData(vS2, 2, i))

            Next

            Call PrcExeNoError("EXP_PFK7101_UPDATE_INVOICE_INFORMATION", cn, strList.ToArray)

        End If


    End Sub
    Private Function DATA_UPDATE_APPROVED(xStatus As String) As Boolean
        DATA_UPDATE_APPROVED = False

        Try
            If READ_PFK7101(L7101.CustomerCode) = True Then
                W7101 = D7101
                Select Case xStatus
                    Case "1"
                        W7101.CheckCustomerStatus = xStatus
                        W7101.DatePending1 = ""

                    Case "3"
                        W7101.CheckCustomerStatus = xStatus
                        W7101.DateApproved = Pub.DAT

                    Case "5"
                        W7101.CheckCustomerStatus = xStatus
                        W7101.DatePending2 = ""

                    Case "6"
                        W7101.CheckCustomerStatus = xStatus
                        W7101.DatePending2 = Pub.DAT

                End Select

                If REWRITE_PFK7101(W7101) = True Then
                    isudCHK = True : WRITE_CHK = "*"
                End If
            End If

            DATA_UPDATE_APPROVED = True
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Function

    Private Sub DATA_DELETE()
        Dim str As String = MsgBoxP("Do you want to delete ?", vbYesNo)
        If str <> vbYes Then Exit Sub
        DATA_MOVE()

        W7101.CheckActive = "2"
        W7101.DateDeactive = Pub.DAT
        W7101.InchargeUpdate = Pub.SAW
        W7101.CheckUse = "2"

        If DELETE_PFK7101(W7101) = True Then isudCHK = True : WRITE_CHK = "*"

    End Sub
    Private Sub KEY_COUNT()
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        If KEY_CHK = "*" Then Exit Sub

        SQL = "SELECT MAX(CAST(K7101_CustomerCode AS DECIMAL)) AS MAX_CODE FROM PFK7101 "
        SQL = SQL & " WHERE K7101_CustomerCode < '900000' "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            L7101.CustomerCode = "000001"
        Else
            L7101.CustomerCode = Format(CInt(rd!MAX_CODE + 1), "000000")
        End If

        W7101.CustomerCode = L7101.CustomerCode

        rd.Close()
        If Val(W7101.CustomerCode) > 999999 Then
            Call MsgBoxP("46", "KEY_COUNT")

            Call tst_iClose.PerformClick() : Exit Sub
        End If

        txt_CustomerCode.Data = W7101.CustomerCode
    End Sub


#End Region

#Region "DATA_SEARCH"
    Private Function DATA_SEARCH_vS2() As Boolean
        DATA_SEARCH_vS2 = False
        Try
            Dim i As Integer

            DS1 = PrcDS("USP_ISUD7101A_SEARCH_vS2", cn, L7101.CustomerCode)

            If GetDsRc(DS1) = 0 Then

                SPR_PRO(vS2, DS2, "USP_ISUD7101A_SEARCH_vS2", "vS2")
                SPR_TEXTBOXM(vS2, getColumIndex(vS2, "Content"))
                SPR_TEXTBOXM(vS2, getColumIndex(vS2, "Content1"))
                For i = 0 To vS2.ActiveSheet.RowCount - 1
                    If vS2.ActiveSheet.Rows(i).GetPreferredHeight > D9914.Rowheight Then vS2.ActiveSheet.Rows(i).Height = vS2.ActiveSheet.Rows(i).GetPreferredHeight
                Next

                vS2.Enabled = True
                Exit Function
            End If

            SPR_PRO(vS2, DS1, "USP_ISUD7101A_SEARCH_vS2", "vS2")
            SPR_TEXTBOXM(vS2, getColumIndex(vS2, "Content"))
            SPR_TEXTBOXM(vS2, getColumIndex(vS2, "Content1"))
            For i = 0 To vS2.ActiveSheet.RowCount - 1
                If vS2.ActiveSheet.Rows(i).GetPreferredHeight > D9914.Rowheight Then vS2.ActiveSheet.Rows(i).Height = vS2.ActiveSheet.Rows(i).GetPreferredHeight
            Next


            DATA_SEARCH_vS2 = True
        Catch ex As Exception

        End Try
    End Function
    Private Function DATA_SEARCH() As Boolean

        DATA_SEARCH = False

        DS1 = READ_PFK7101(L7101.CustomerCode, cn)

        If GetDsRc(DS1) = 0 Then
            Setfocus(txt_CustomerName)
            Exit Function
            isudCHK = False
        End If

        READER_MOVE(Me, DS1)

        If GetDsData(DS1, 0, "K7101_CheckUse") = "1" Then rad_CheckUse1.Checked = True
        If GetDsData(DS1, 0, "K7101_CheckUse") = "2" Then rad_CheckUse2.Checked = True

        Setfocus(txt_CustomerName)



        DATA_SEARCH = True

    End Function

#End Region

#Region "Event"
    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click

        Select Case wJOB
            Case 1
                If Data_Check() = False Then Exit Sub
                Call DATA_INSERT()
                Me.Form_ClearData()
                Call DATA_INIT()
                Call KEY_COUNT()
                Setfocus(txt_CustomerName)
            Case 2
                Me.Dispose()
            Case 3
                If Data_Check() = False Then Exit Sub
                Call DATA_UPDATE()
                Call DATA_SEARCH_vS2()
                Me.Dispose()
            Case 4
                Call DATA_DELETE()

                Me.Dispose()
            Case 91
                Call DATA_UPDATE_APPROVED("6")  'PENDDING 2
                WRITE_CHK = "*"

                Me.Dispose()
            Case 92
                Call DATA_UPDATE_APPROVED("3")  'Approved
                WRITE_CHK = "*"

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
    Private Sub tst_iDelete_Click(sender As Object, e As EventArgs) Handles tst_iDelete.Click
        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        rd = PrcDR("USP_ALL_CHECKDATA_PRIMARYKEY_1KEY", cn, "PFK7101", "CustomerCode", L7101.CustomerCode)

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
#End Region

End Class