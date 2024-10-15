Public Class ISUD2354A

#Region "Variable"
    Private wJOB As Integer

    Private W2351 As New T2351_AREA
    Private L2351 As New T2351_AREA

    Private W2354 As New T2354_AREA
    Private L2354 As New T2354_AREA

    Private WRITE_CHK As String
    Public gpp As Graphics
    Public twtopi As Decimal = 39.5

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Form"


    Public Function Link_ISUD2354A(job As Integer, MaterialInBoundNo As String, MaterialInBoundSeq As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D2351.MaterialInBoundNo = MaterialInBoundNo
        D2351.MaterialInBoundSeq = MaterialInBoundSeq

        D2354.MaterialInBoundNo = MaterialInBoundNo
        D2354.MaterialInBoundSeq = MaterialInBoundSeq

        wJOB = job : L2351 = D2351 : L2354 = D2354

        txt_MaterialInBoundNo.Data = MaterialInBoundNo
        txt_MaterialInBoundSeq.Data = MaterialInBoundSeq

        Link_ISUD2354A = False
        Try

            Select Case job
                Case 1
                Case Else

            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD2354A = isudCHK


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

                Call DATA_SEARCH_VS1()

                Frame1.Enabled = True
                cmd_DEL.Visible = False
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
                Call DATA_SEARCH_VS1()

                Frame1.Enabled = True
                cmd_DEL.Visible = False
                cmd_OK.Visible = False
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
                        cmd_DEL.Visible = False
                        Call MsgBoxP("Only Search !") : cmd_OK.Visible = False
                    End If
                End If

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH_VS1()
                Frame1.Enabled = True
                cmd_DEL.Visible = False

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
                Call DATA_SEARCH_VS1()

                Frame1.Enabled = True
                cmd_DEL.Visible = True
                cmd_OK.Visible = False
                cmd_Print.Visible = False

        End Select

        formA = True
    End Sub

#End Region

#Region "Search"

    Private Function DATA_SEARCH_HEAD() As Boolean
        DATA_SEARCH_HEAD = False
        Try
            DATA_SEARCH_HEAD = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH01")
        End Try

    End Function

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False
        Try
            DS1 = PrcDS("USP_ISUD2354A_SEARCH_VS1", cn, txt_MaterialInBoundNo.Data, txt_MaterialInBoundSeq.Data)

            If GetDsRc(DS1) = 0 Then
                SPR_SET(Vs1, , , 1, OperationMode.SingleSelect)
                SPR_PRO(Vs1, DS1, "USP_ISUD2354A_SEARCH_VS1", "vS1")
                Vs1.Enabled = True
                Exit Function
            End If
            SPR_SET(Vs1, , , , OperationMode.SingleSelect)
            SPR_PRO(Vs1, DS1, "USP_ISUD2354A_SEARCH_VS1", "Vs1")
            Call Calculation()
            DATA_SEARCH_VS1 = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try
    End Function

    Private Sub Calculation()
        txt_CntInbound.Data = Vs1.ActiveSheet.RowCount
        Dim i As Integer
        Dim TotalN As Decimal = 0
        Dim TotalQ As Decimal = 0

        For i = 0 To Vs1.ActiveSheet.RowCount - 1
            If getDataM(Vs1, getColumIndex(Vs1, "CheckComplete"), i) = "1" Then
                TotalN += CDecp(getData(Vs1, getColumIndex(Vs1, "QtyInBound"), i))
                TotalQ += CDecp(getData(Vs1, getColumIndex(Vs1, "QtyQC"), i))
            End If
        Next

        txt_CntInbound.Data = FormatNumber(TotalN, 2)
        txt_CntQC.Data = FormatNumber(TotalQ, 2)

    End Sub


#End Region

#Region "Function"


    Private Function DATA_MOVE() As Boolean
        DATA_MOVE = False
        Try
            Dim i As Integer

            For i = 0 To Vs1.ActiveSheet.RowCount - 1

            Next

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
            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                DATA_LINE_DELETE(i)
            Next
            isudCHK = True : Me.Dispose() : Exit Sub

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
    End Sub

  


#End Region

#Region "Event"


    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Select Case wJOB
            Case 1
                If DataCheck(Me, "PFK2351") = False Then Exit Sub
                Me.Dispose()
            Case 2
                Me.Dispose()
            Case 3
                If DataCheck(Me, "PFK2351") = False Then Exit Sub
                Me.Dispose()

            Case 4
                If txt_MaterialInBoundNo.Data <> System_Date_8() Then
                    MsgBoxP("Can not edit because of not today!")
                    If MsgBoxPPW("Please type the password to modify!", const_pwGreyInbound) = False Then Exit Sub
                End If
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

        If txt_MaterialInBoundNo.Data <> System_Date_8() Then
            MsgBoxP("Can not edit because of not today!")
            If MsgBoxPPW("Please type the password to modify!", const_pwGreyInbound) = False Then Exit Sub
        End If

        Dim str As String = MsgBoxP("Do you want to delete it?", vbYesNo)

        If str <> vbYes Then Exit Sub

        Call DATA_DELETE()
    End Sub

    Private Sub KEY_COUNT()
        Try
            SQL = "SELECT MAX(K2354_MaterialInBoundQno) AS MAX_MCODE FROM PFK2354 "
            SQL = SQL & " WHERE K2354_MaterialInBoundNo = '" & L2354.MaterialInBoundNo & "' "
            SQL = SQL & " AND K2354_MaterialInBoundSeq = '" & L2354.MaterialInBoundSeq & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W2354.MaterialInBoundQno = 1
            Else
                W2354.MaterialInBoundQno = CIntp(rd!MAX_MCODE + 1)
            End If

            rd.Close()

            L2354.MaterialInBoundQno = W2354.MaterialInBoundQno

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        Dim xCOL As Integer
        Dim xROW As Integer

        xCOL = Vs1.ActiveSheet.ActiveColumnIndex
        xROW = Vs1.ActiveSheet.ActiveRowIndex

        If READ_PFK2354(getData(Vs1, getColumIndex(Vs1, "KEY_MaterialInBoundNo"), xROW), getData(Vs1, getColumIndex(Vs1, "KEY_MaterialInBoundSeq"), xROW), getData(Vs1, getColumIndex(Vs1, "KEY_MaterialInBoundQno"), xROW)) = True Then
            txt_cdDefectMaterial.Code = D2354.cdDefectMaterial

            If READ_PFK7171(ListCode("DefectMaterial"), D2354.cdDefectMaterial) Then
                txt_cdDefectMaterial.Data = D7171.BasicName
            End If

            If D2354.CheckQC = "1" Then rad_CheckQC1.Checked = True
            If D2354.CheckQC = "2" Then rad_CheckQC2.Checked = True

            txt_TimeQC.Data = FSDateTime(D2354.TimeQC)
            txt_InchargeQC.Data = D2354.InchargeQC

            If READ_PFK7411(D2354.InchargeQC) Then
                txt_InchargeQC.Data = D7411.Name
            End If
        End If
    End Sub

    Private Sub Vs1_Change(sender As Object, e As ChangeEventArgs) Handles Vs1.Change
        Dim xCOL As Integer
        Dim xROW As Integer

        xCOL = Vs1.ActiveSheet.ActiveColumnIndex
        xROW = Vs1.ActiveSheet.ActiveRowIndex

        If xCOL = getColumIndex(Vs1, "QtyQC") Or xCOL = getColumIndex(Vs1, "QtyInBound") Then
            If READ_PFK2354(getData(Vs1, getColumIndex(Vs1, "KEY_MaterialInBoundNo"), xROW), getData(Vs1, getColumIndex(Vs1, "KEY_MaterialInBoundSeq"), xROW), getData(Vs1, getColumIndex(Vs1, "KEY_MaterialInBoundQno"), xROW)) = True Then
                W2354 = D2354
                W2354.CheckComplete = "1"

                If rad_CheckQC1.Checked = True Then W2354.CheckQC = "1" : W2354.Grade = "A"
                If rad_CheckQC2.Checked = True Then W2354.CheckQC = "2" : W2354.Grade = "X"

                W2354.seDefectMaterial = ListCode("DefectMaterial")
                W2354.cdDefectMaterial = getData(Vs1, getColumIndex(Vs1, "cdDefectMaterial"), xROW)

                W2354.PackInBound = 1
                W2354.PackQC = 1

                W2354.QtyInBound = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyInBound"), xROW))
                W2354.QtyQC = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyQC"), xROW))

                W2354.InchargeQC = txt_InchargeQC.Code
                W2354.DateUpdate = Pub.DAT

                Call REWRITE_PFK2354(W2354)

                DS1 = PrcDS("USP_ISUD2354A_SEARCH_VS1_LINE", cn, W2354.MaterialInBoundNo, W2354.MaterialInBoundSeq, W2354.MaterialInBoundQno)
                Call READ_SPREAD(Vs1, DS1, "USP_ISUD2354A_SEARCH_VS1", "Vs1", xROW)
                Vs1.Focus()

            Else
                W2354 = D2354
                W2354.CheckComplete = "1"

                Call KEY_COUNT()

                If rad_CheckQC1.Checked = True Then W2354.CheckQC = "1" : W2354.Grade = "A"
                If rad_CheckQC2.Checked = True Then W2354.CheckQC = "2" : W2354.Grade = "X"

                W2354.PackInBound = 1
                W2354.PackQC = 1

                W2354.QtyInBound = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyInBound"), xROW))
                W2354.QtyQC = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyQC"), xROW))

                W2354.seDefectMaterial = ListCode("DefectMaterial")
                W2354.cdDefectMaterial = getData(Vs1, getColumIndex(Vs1, "cdDefectMaterial"), xROW)

                W2354.TimeQC = System_Date_time()
                W2354.DateInsert = Pub.DAT

                W2354.MaterialInBoundNo = L2354.MaterialInBoundNo
                W2354.MaterialInBoundSeq = L2354.MaterialInBoundSeq

                WRITE_PFK2354(W2354)

                DS1 = PrcDS("USP_ISUD2354A_SEARCH_VS1_LINE", cn, W2354.MaterialInBoundNo, W2354.MaterialInBoundSeq, W2354.MaterialInBoundQno)
                Call READ_SPREAD(Vs1, DS1, "USP_ISUD2354A_SEARCH_VS1", "Vs1", xROW)
                Vs1.Focus()


                If xCOL >= getColumIndex(Vs1, "Remark") Then
                    Vs1.ActiveSheet.RowCount += 1
                    Vs1.ActiveSheet.ActiveRowIndex += 1
                    Vs1.ActiveSheet.ActiveColumnIndex = getColumIndex(Vs1, "QtyInBound") - 1

                End If
            End If
        End If

        Call Calculation()

    End Sub
    Private Sub vS1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown
        Dim xCOL As Integer
        Dim xROW As Integer

        xCOL = Vs1.ActiveSheet.ActiveColumnIndex
        xROW = Vs1.ActiveSheet.ActiveRowIndex

        Select Case e.KeyCode
            Case Keys.Enter
                If xCOL = getColumIndex(Vs1, "QtyQC") Or xCOL = getColumIndex(Vs1, "QtyInBound") Then
                    If READ_PFK2354(getData(Vs1, getColumIndex(Vs1, "KEY_MaterialInBoundNo"), xROW), getData(Vs1, getColumIndex(Vs1, "KEY_MaterialInBoundSeq"), xROW), getData(Vs1, getColumIndex(Vs1, "KEY_MaterialInBoundQno"), xROW)) = True Then
                        W2354 = D2354
                        W2354.CheckComplete = "1"

                        If rad_CheckQC1.Checked = True Then W2354.CheckQC = "1" : W2354.Grade = "A"
                        If rad_CheckQC2.Checked = True Then W2354.CheckQC = "2" : W2354.Grade = "X"

                        W2354.seDefectMaterial = ListCode("DefectMaterial")
                        W2354.cdDefectMaterial = getData(Vs1, getColumIndex(Vs1, "cdDefectMaterial"), xROW)

                        W2354.InchargeQC = txt_InchargeQC.Code
                        W2354.DateUpdate = Pub.DAT

                        W2354.PackInBound = 1
                        W2354.PackQC = 1

                        W2354.QtyInBound = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyInBound"), xROW))
                        W2354.QtyQC = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyQC"), xROW))

                        Call REWRITE_PFK2354(W2354)

                        DS1 = PrcDS("USP_ISUD2354A_SEARCH_VS1_LINE", cn, W2354.MaterialInBoundNo, W2354.MaterialInBoundSeq, W2354.MaterialInBoundQno)
                        Call READ_SPREAD(Vs1, DS1, "USP_ISUD2354A_SEARCH_VS1", "Vs1", xROW)
                        Vs1.Focus()

                    Else
                        W2354 = D2354
                        W2354.CheckComplete = "1"

                        Call KEY_COUNT()
                        W2354.InchargeQC = txt_InchargeQC.Code
                        W2354.TimeQC = System_Date_time()
                        W2354.DateInsert = Pub.DAT

                        If rad_CheckQC1.Checked = True Then W2354.CheckQC = "1" : W2354.Grade = "A"
                        If rad_CheckQC2.Checked = True Then W2354.CheckQC = "2" : W2354.Grade = "X"

                        W2354.seDefectMaterial = ListCode("DefectMaterial")
                        W2354.cdDefectMaterial = getData(Vs1, getColumIndex(Vs1, "cdDefectMaterial"), xROW)

                        W2354.MaterialInBoundNo = L2354.MaterialInBoundNo
                        W2354.MaterialInBoundSeq = L2354.MaterialInBoundSeq

                        W2354.PackInBound = 1
                        W2354.PackQC = 1

                        W2354.QtyInBound = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyInBound"), xROW))
                        W2354.QtyQC = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyQC"), xROW))

                        WRITE_PFK2354(W2354)

                        DS1 = PrcDS("USP_ISUD2354A_SEARCH_VS1_LINE", cn, W2354.MaterialInBoundNo, W2354.MaterialInBoundSeq, W2354.MaterialInBoundQno)
                        Call READ_SPREAD(Vs1, DS1, "USP_ISUD2354A_SEARCH_VS1", "Vs1", xROW)
                        Vs1.Focus()

                    End If


                End If

                If xCOL >= getColumIndex(Vs1, "Remark") Then
                    Vs1.ActiveSheet.RowCount += 1
                    Vs1.ActiveSheet.ActiveRowIndex += 1
                    Vs1.ActiveSheet.ActiveColumnIndex = getColumIndex(Vs1, "QtyInBound") - 1
                End If

            Case Keys.Delete
                Msg_Result = MsgBoxP("Do you want to delete?", vbYesNo)

                If Msg_Result <> vbYes Then Exit Sub

                If READ_PFK2354(getData(Vs1, getColumIndex(Vs1, "KEY_MaterialInBoundNo"), xROW), getData(Vs1, getColumIndex(Vs1, "KEY_MaterialInBoundSeq"), xROW), getData(Vs1, getColumIndex(Vs1, "KEY_MaterialInBoundQno"), xROW)) = True Then
                    W2354 = D2354
                    Call DELETE_PFK2354(W2354)
                    SPR_DEL(Vs1, 0, xROW)
                Else
                    SPR_DEL(Vs1, 0, xROW)
                End If

        End Select

        Call Calculation()
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