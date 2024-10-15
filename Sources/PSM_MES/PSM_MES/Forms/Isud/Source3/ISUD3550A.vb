Public Class ISUD3550A

#Region "Variable"
    Private wJOB As Integer

    Private W3550 As T3550_AREA
    Private L3550 As T3550_AREA

    Private W3551 As T3551_AREA
    Private L3551 As T3551_AREA


    Private W1320 As T1320_AREA
    Private L1320 As T1320_AREA

    Private W1321 As T1321_AREA
    Private L1321 As T1321_AREA

    Private WRITE_CHK As String
    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD3550A(job As Integer, TestOrder As String, TestSeq As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG

        L3551.TestOrder = TestOrder
        L3551.TestSeq = TestSeq
        wJOB = job : L3551 = D3551

        Link_ISUD3550A = False


        Try

            formA = False
            Me.ShowDialog()

            Link_ISUD3550A = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("TEST PROCESSING"))
        End Try


    End Function
#End Region

#Region "Form"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))
        Me.Text = Me.Text & " - INSERT"
        Frame1.Enabled = True

        If CHK(3) <> "1" Then
            If CHK(2) <> "1" Then
                isudCHK = False
                formA = True
                Me.Dispose()
                Call MsgBoxP("You have no right is this program !")
                Exit Sub
            Else
                Me.Text = Me.Text & " - SEARCH"
                isudCHK = False
                formA = True
                wJOB = 2
                cmd_OK.Visible = False
                Call MsgBoxP("Only Search !") : cmd_OK.Visible = False
            End If
        End If

        txt_DateAccept.Data = Pub.DAT
        txt_InchargeAccept.Data = Pub.SAW

        If APPROVAL_CHECK() = False Then Call Block_Check()

        formA = True
    End Sub
    
#End Region

#Region "Search"
    Private Function APPROVAL_CHECK() As Boolean

        APPROVAL_CHECK = False


        If READ_PFK3551(L3551.TestOrder, L3551.TestSeq) = False Then
            Exit Function
        End If

        L3551 = D3551
        APPROVAL_CHECK = True

    End Function


    Private Sub KEY_COUNT()
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        Try
            SQL = "SELECT MAX(CAST(K3550_LABNo AS DECIMAL)) AS MAX_CODE FROM PFK3550 "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_CODE) Then
                L3550.LABNo = "000000001"
            Else
                L3550.LABNo = Format(CInt(rd!MAX_CODE + 1), "000000000")
            End If

            rd.Close()

            D3550.LABNo = L3550.LABNo
           
        Catch ex As Exception
            MsgBoxP("KEY_COUNT")
        End Try
    End Sub

#End Region

#Region "Functions"
    Private Sub Block_Check()
        rad_LabTestStatus1.Enabled = False
        rad_LabTestStatus2.Enabled = True
        rad_LabTestStatus3.Enabled = False
        rad_LabTestStatus4.Enabled = True
        rad_LabTestStatus5.Enabled = True
    End Sub
    Private Sub Check_Status()
        If rad_LabTestStatus1.Enabled = True Then W3550.LabTestStatus = "1"
        If rad_LabTestStatus2.Enabled = True Then W3550.LabTestStatus = "2"
        If rad_LabTestStatus3.Enabled = True Then W3550.LabTestStatus = "3"
        If rad_LabTestStatus4.Enabled = True Then W3550.LabTestStatus = "4"
        If rad_LabTestStatus5.Enabled = True Then W3550.LabTestStatus = "5"
    End Sub
    Private Function DATA_UPDATE() As Boolean
        DATA_UPDATE = False
        Try
            If READ_PFK1320(L3551.TestOrder) = True Then
                W1320 = D1320

                Call KEY_COUNT()
                W3550.TestOrder = W1320.TestOrder
                W3550.seTestSide = W1320.TestOrder
                W3550.cdTestSide = W1320.TestOrder
                W3550.CustomerCode = W1320.TestOrder
                W3550.TotalQty = W1320.TestOrder
                W3550.InchargeOrder = W1320.TestOrder
                W3550.InchargeAccept = txt_InchargeAccept.Code

                Call Check_Status()

                W3550.DateApproval = txt_DateAccept.Data
                W3550.Remark = W1320.TestOrder

                If WRITE_PFK3550(W3550) = True Then
                    Dim SQl = "SELECT * FORM PFK1321 WHERE K1321.TestOrder = '" + L3551.TestOrder + "' AND K1321.TestSeq = '" + L3551.TestSeq + "' "
                    cmd = New SqlClient.SqlCommand(SQl, cn)
                    DS1 = PrcDS(cmd, cn)

                    Dim i = 1
                    For Each DS01 As DataRow In DS1.Tables(0).Rows
                        W3551.LABNo = W3550.LABNo
                        W3551.LABNoSeq = i.ToString("000")

                        W3551.OrderNo = DS01![OrderNo]
                        W3551.OrderNoSeq = DS01![OrderNoSeq]
                        W3551.SpecStatus = DS01![SpecStatus]
                        W3551.SpecNo = DS01![SpecNo]
                        W3551.Article = DS01![Article]
                        W3551.Line = DS01![Line]
                        W3551.SizeRange = DS01![SizeRange]
                        W3551.SpeciticSize = DS01![SpeciticSize]
                        W3551.QtyTest = DS01![QtyTest]
                        W3551.seTestCode = DS01![seTestCode]
                        W3551.cdTestCode = DS01![cdTestCode]
                        W3551.SupplierCode = DS01![SupplierCode]
                        W3551.seProductionProcess = DS01![seProductionProcess]
                        W3551.cdProductionProcess = DS01![cdProductionProcess]
                        W3551.Remark = DS01![Remark]

                        Call WRITE_PFK3551(W3551)
                        i += 1
                    Next
                    isudCHK = True
                    Me.Dispose()
                End If
            End If
            DATA_UPDATE = True
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Function
#End Region

#Region "Events"
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Try
            Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

            If CHK(5) <> "1" And rad_LabTestStatus3.Checked = True Then
                Call MsgBoxP("No right to update this!")
                Exit Sub
            End If

            If CHK(5) <> "1" And rad_LabTestStatus2.Checked = True Then
                Call MsgBoxP("No right to update this!")
                Exit Sub
            End If

            If DATA_UPDATE() = True Then
                isudCHK = True
                Me.Dispose()
            End If
        Catch ex As Exception
            MsgBoxP("Error!")
            Me.Dispose()
        End Try


    End Sub

    Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        isudCHK = False
        Me.Dispose()
    End Sub
#End Region
    


    
End Class