Public Class ISUD2345P

#Region "Variable"
    Private wJOB As Integer

    Private W2345 As New T2345_AREA
    Private L2345 As New T2345_AREA

    Private W2346 As New T2346_AREA
    Private L2346 As New T2346_AREA

    Private WRITE_CHK As String
    Private formA As Boolean

    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD2345P(job As Integer, FactOrderNo As String, FactOrderSeq As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG

        If FactOrderSeq = "" Then FactOrderSeq = "1"
        D2346.FactOrderNo = FactOrderNo
        D2346.FactOrderSeq = FactOrderSeq

        wJOB = job : L2346 = D2346

        Link_ISUD2345P = False

        Try

            formA = False
            Me.ShowDialog()

            Link_ISUD2345P = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Return Grey Sales PROCESSING"))
        End Try
    End Function
#End Region

#Region "Form"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))
        Me.Text = Me.Text & " - UPDATE"
        Frame1.Enabled = True

        If CHK(3) <> "1" And CHK(5) <> "1" Then
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
                Call Error_Message("16", "Form_Activate")
            End If
        End If

        If APPROVAL_CHECK() = False Then Call Block_Check()

        formA = True
    End Sub

#End Region

#Region "Search"
    Private Function APPROVAL_CHECK() As Boolean
        APPROVAL_CHECK = False

        If READ_PFK2346(L2346.FactOrderNo, L2346.FactOrderSeq) = False Then
            Exit Function
        End If

        L2346 = D2346

        K2346_CheckPurchasing(L2346.CheckPurchasing)

        If wJOB = 3 Then If Purchasing_Check(L2346) = False Then MsgBoxP("Purchasing had data already!") : Exit Function
        If wJOB = 4 Then If Purchasing_Check_All(L2346) = False Then MsgBoxP("Purchasing had data already!") : Exit Function

        APPROVAL_CHECK = True

    End Function

#End Region

#Region "Functions"
    Private Sub Block_Check()
        rad_CheckPurchasing1.Enabled = False
        rad_CheckPurchasing2.Enabled = True
        rad_CheckPurchasing3.Enabled = True
        rad_CheckPurchasing4.Enabled = True
        rad_CheckPurchasing5.Enabled = False
    End Sub
    Private Function Purchasing_Check(z2346 As T2346_AREA) As Boolean
        Purchasing_Check = False
        If z2346.CheckPurchasing = "2" Then Exit Function
        If z2346.QtyWarehouse > 0 Then Exit Function

        Purchasing_Check = True
    End Function
    Private Function Purchasing_Check_All(z2346 As T2346_AREA) As Boolean
        Purchasing_Check_All = False
        DS1 = READ_PFK2346_1(z2346.FactOrderNo, cn)

        For Each RS01 As DataRow In DS1.Tables(0).Rows
            If READ_PFK2346(RS01!K2346_FactOrderNo, RS01!K2346_FactOrderSeq) = True Then
                W2346 = D2346
                If W2346.QtyWarehouse > 0 Then Exit Function
            End If
        Next

        Purchasing_Check_All = True
    End Function
    Private Sub K2346_CheckPurchasing(Process As String)
        Select Case Process
            Case "1" : rad_CheckPurchasing1.Checked = True
            Case "2" : rad_CheckPurchasing2.Checked = True
            Case "3" : rad_CheckPurchasing3.Checked = True
            Case "4" : rad_CheckPurchasing4.Checked = True
            Case "6" : rad_CheckPurchasing5.Checked = True
            Case Else : rad_CheckPurchasing1.Checked = True
        End Select
    End Sub
    Private Sub K2346_CheckPurchasing()
        If rad_CheckPurchasing1.Checked = True Then W2346.CheckPurchasing = "1"
        If rad_CheckPurchasing2.Checked = True Then W2346.CheckPurchasing = "2"
        If rad_CheckPurchasing3.Checked = True Then W2346.CheckPurchasing = "3"
        If rad_CheckPurchasing4.Checked = True Then W2346.CheckPurchasing = "4"
        If rad_CheckPurchasing5.Checked = True Then W2346.CheckPurchasing = "6"
    End Sub
    Private Sub Enable_CheckPurchasing(check1 As Boolean, check2 As Boolean, check3 As Boolean, check4 As Boolean, check5 As Boolean)
        rad_CheckPurchasing1.Enabled = check1
        rad_CheckPurchasing2.Enabled = check2
        rad_CheckPurchasing3.Enabled = check3
        rad_CheckPurchasing4.Enabled = check4
        rad_CheckPurchasing5.Enabled = check5
    End Sub

    Private Function DATA_UPDATE() As Boolean
        DATA_UPDATE = False
        Try
            If READ_PFK2346(L2346.FactOrderNo, L2346.FactOrderSeq) = True Then

                W2346 = D2346
                K2346_CheckPurchasing()

                If REWRITE_PFK2346(W2346) = True Then
                    isudCHK = True
                End If
            End If


            DATA_UPDATE = True
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Function
    Private Function DATA_UPDATE_ALL() As Boolean
        DATA_UPDATE_ALL = False
        Try
            DS1 = READ_PFK2346_1(L2346.FactOrderNo, cn)
          
            For Each RS01 As DataRow In DS1.Tables(0).Rows

                If READ_PFK2346(RS01!K2346_FactOrderNo, RS01!K2346_FactOrderSeq) = True Then
                    W2346 = D2346
                    K2346_CheckPurchasing()

                    If REWRITE_PFK2346(W2346) = True Then
                        isudCHK = True
                    End If
                End If
            Next

            DATA_UPDATE_ALL = True
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Function
#End Region

#Region "Events"
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Try
            Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

            If CHK(3) <> "1" And rad_CheckPurchasing3.Checked = True Then
                Call MsgBoxP("No right to update this!")
                Exit Sub
            End If

            If CHK(5) <> "1" And rad_CheckPurchasing2.Checked = True Then
                Call MsgBoxP("No right to update this!")
                Exit Sub
            End If

            Select Case wJOB
                Case "3"
                    If DATA_UPDATE() = True Then
                        isudCHK = True
                        Me.Dispose()
                    End If

                Case "4"
                    If DATA_UPDATE_ALL() = True Then
                        isudCHK = True
                        Me.Dispose()
                    End If
            End Select

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